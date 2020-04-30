using FL_UnityEngine;
using Live.Core;
using Live.Core.Rendering;
using Microsoft.Xna.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;
using imgui = ImGuiNET.ImGui;

namespace FeedbackLoopExampleUnityProject.Scenarios
{
    public class FeedbackLoopScenario : ScenarioGameLoopWithImgui
    {
        private readonly GameObject sceneRoot;

        private readonly GameObject thirdPersonController;
        private readonly ThirdPersonUserControl thirdPersonUserControl;
        private readonly ThirdPersonCharacter thirdPersonCharacter;

        public FeedbackLoopScenario()
        {
            // create scene tree

            sceneRoot = new GameObject();

            thirdPersonController = new GameObject();
            thirdPersonUserControl = thirdPersonController.AddComponent<ThirdPersonUserControl>();
            thirdPersonCharacter = thirdPersonController.AddComponent<ThirdPersonCharacter>();

            thirdPersonController.transform.parent = sceneRoot.transform;

            // start

            sceneRoot.BroadcastMessage(nameof(MonoBehaviourAction.Awake));
            sceneRoot.BroadcastMessage(nameof(MonoBehaviourAction.Start));
        }

        protected override void Update(TimeInterval time)
        {
            sceneRoot.BroadcastMessage(nameof(MonoBehaviourAction.Update));
            sceneRoot.BroadcastMessage(nameof(MonoBehaviourAction.FixedUpdate));
        }

        protected override void Draw(TimeInterval time)
        {
            GraphicsDevice.Clear(Color.Gray);
            DrawUserInterface(time, () =>
            {
                var pos = thirdPersonCharacter.transform.position;

                imgui.SetCursorPos(new System.Numerics.Vector2(pos.x, pos.y));
                imgui.Button("", new System.Numerics.Vector2(50, 50));
            });
        }
    }
}