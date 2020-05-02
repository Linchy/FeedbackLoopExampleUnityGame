using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace Live.Feedback.Editor.Plugin
{
    [InitializeOnLoad]
    public class LiveFeedbackEditorPlugin : MonoBehaviour
    {
        static LiveFeedbackEditorPlugin()
        {
            Debug.Log("Up and running");

            EditorApplication.playModeStateChanged += EditorApplication_playModeStateChanged;
        }

        [DidReloadScripts]
        public static void OnCompileScripts()
        {
            Debug.Log("OnCompileScripts");
        }

        private static void EditorApplication_playModeStateChanged(PlayModeStateChange playMode)
        {
            switch (playMode)
            {
                case PlayModeStateChange.ExitingEditMode:
                    SetupContainers();
                    break;

                case PlayModeStateChange.ExitingPlayMode:
                    TeardownContainers();
                    break;
            }

            //Debug.Log("check " + i++);
            //Debug.Log(obj.ToString());


            //if (EditorApplication.isPlayingOrWillChangePlaymode)
            //{
            //    Debug.Log("isPlayingOrWillChangePlaymode");
            //}

            //if (EditorApplication.isCompiling)
            //{
            //    Debug.Log("isCompiling");
            //}
        }

        private static void SetupContainers()
        {
            // find scripts
            var scriptFilepaths = GetGameScriptAssetFilepaths();

            string assetsDirectory = Application.dataPath;
            string projectDirectory = Path.GetDirectoryName(assetsDirectory);
            string liveDirectory = Path.Combine(assetsDirectory, "Live Feedback Directory");

            if (Directory.Exists(liveDirectory))
            {
                Directory.Delete(liveDirectory, true);
                AssetDatabase.Refresh();
            }
            Directory.CreateDirectory(liveDirectory);

            // rewrite them
            CopyScriptsToLiveDirectoryAndRewrite(scriptFilepaths, liveDirectory);

            // re-point gameobject monobehaviours
            foreach (var gameObject in UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects())
            {
                var scripts = gameObject.GetComponents<MonoBehaviour>();
                foreach (var script in scripts)
                {
                    if (script.GetType().FullName == "UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl")
                    {
                        // null because https://stackoverflow.com/questions/23795173/notification-when-assetdatabase-refresh-is-ready
                        var rewrittenScriptInstance = AssetDatabase.LoadAssetAtPath<MonoBehaviour>("Assets/Live Feedback Directory/ThirdPersonCharacter/Scripts/ThirdPersonCharacter.cs");
                        var newScriptInstance = (MonoBehaviour)gameObject.AddComponent(rewrittenScriptInstance.GetType());

                        CopyClassValues(script, newScriptInstance);
                        Destroy(script);
                    }
                }
                
            }

        }

        private static List<string> GetGameScriptAssetFilepaths()
        {
            var scriptFilepaths  = new List<string>();

            string[] assetFilepaths = AssetDatabase.GetAllAssetPaths();
            foreach (string assetPath in assetFilepaths)
            {
                if (assetPath.StartsWith("assets", StringComparison.OrdinalIgnoreCase)
                 && assetPath.EndsWith(".cs", StringComparison.OrdinalIgnoreCase)
                 && !assetPath.StartsWith("assets/editor", StringComparison.OrdinalIgnoreCase))
                {
                    scriptFilepaths.Add(assetPath);
                }
            }

            return scriptFilepaths;
        }

        private static void CopyScriptsToLiveDirectoryAndRewrite(List<string> scriptFilepaths, string liveDirectory)
        {
            foreach (var filepath in scriptFilepaths)
            {
                //string destinationPath = "Assets/Live Feedback Directory/" + filepath.Substring("assets/".Length);
                string destinationPath = Path.Combine(liveDirectory, filepath.Substring("assets/".Length));
                string destinationDirectory = Path.GetDirectoryName(destinationPath);

                Directory.CreateDirectory(destinationDirectory);

                string sourceCode = File.ReadAllText(filepath);
                string rewrittenCode = sourceCode.Replace("namespace ", "namespace _rewrite_");

                File.WriteAllText(destinationPath, rewrittenCode);

                //File.Copy(filepath, destinationPath, true);

                //bool success = AssetDatabase.CopyAsset(filepath, destinationPath);

                //AssetDatabase.SaveAssets();
                //AssetDatabase.Refresh();
                //AssetDatabase.ImportAsset(destinationPath);
                //var tst = AssetDatabase.LoadAssetAtPath(destinationPath, typeof(MonoBehaviour));

                //Debug.Log($"{destinationPath}");
            }

            AssetDatabase.Refresh();
        }

        private static void CopyClassValues(MonoBehaviour sourceComp, MonoBehaviour targetComp)
        {
            FieldInfo[] sourceFields = sourceComp.GetType().GetFields(BindingFlags.Public |
                                                             BindingFlags.NonPublic |
                                                             BindingFlags.Instance);
            int i = 0;
            for (i = 0; i < sourceFields.Length; i++)
            {
                var value = sourceFields[i].GetValue(sourceComp);
                sourceFields[i].SetValue(targetComp, value);
            }
        }

        private static void TeardownContainers()
        {
        }
    }
}