using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.SceneManagement
{
	public unsafe partial class SceneManager {
		//public SceneManager() { }
		public static event UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> activeSceneChanged;
		public static event UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded;
		public static event UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded;
		public static UnityEngine.SceneManagement.Scene CreateScene(string sceneName, UnityEngine.SceneManagement.CreateSceneParameters parameters) => throw new NotImplementedException();
		public static UnityEngine.SceneManagement.Scene CreateScene(string sceneName) => throw new NotImplementedException();
		public static UnityEngine.SceneManagement.Scene GetActiveScene() => throw new NotImplementedException();
		public static UnityEngine.SceneManagement.Scene GetSceneAt(int index) => throw new NotImplementedException();
		public static UnityEngine.SceneManagement.Scene GetSceneByBuildIndex(int buildIndex) => throw new NotImplementedException();
		public static UnityEngine.SceneManagement.Scene GetSceneByName(string name) => throw new NotImplementedException();
		public static UnityEngine.SceneManagement.Scene GetSceneByPath(string scenePath) => throw new NotImplementedException();
		public static void LoadScene(string sceneName, UnityEngine.SceneManagement.LoadSceneMode mode) => throw new NotImplementedException();
		public static void LoadScene(string sceneName) => throw new NotImplementedException();
		public static UnityEngine.SceneManagement.Scene LoadScene(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters) => throw new NotImplementedException();
		public static void LoadScene(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneMode mode) => throw new NotImplementedException();
		public static void LoadScene(int sceneBuildIndex) => throw new NotImplementedException();
		public static UnityEngine.SceneManagement.Scene LoadScene(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneMode mode) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation LoadSceneAsync(string sceneName, UnityEngine.SceneManagement.LoadSceneMode mode) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation LoadSceneAsync(string sceneName) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation LoadSceneAsync(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters) => throw new NotImplementedException();
		public static void MergeScenes(UnityEngine.SceneManagement.Scene sourceScene, UnityEngine.SceneManagement.Scene destinationScene) => throw new NotImplementedException();
		public static void MoveGameObjectToScene(FL_UnityEngine.GameObject go, UnityEngine.SceneManagement.Scene scene) => throw new NotImplementedException();
		public static bool SetActiveScene(UnityEngine.SceneManagement.Scene scene) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation UnloadSceneAsync(int sceneBuildIndex) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation UnloadSceneAsync(string sceneName) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnityEngine.SceneManagement.UnloadSceneOptions options) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation UnloadSceneAsync(string sceneName, UnityEngine.SceneManagement.UnloadSceneOptions options) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options) => throw new NotImplementedException();
		public static int sceneCount => throw new NotImplementedException();
		public static int sceneCountInBuildSettings => throw new NotImplementedException();
	}
}
