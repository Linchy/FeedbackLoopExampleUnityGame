//using FL;
//using System.Collections.Generic;
//using System.Linq;

//namespace FeedbackLoopExampleUnityProject.Injected
//{
//    public class UnitySceneNode
//    {
//        private readonly MonoBehaviour monoBehaviour;
//        public readonly List<UnitySceneNode> Nodes;

//        public UnitySceneNode(MonoBehaviour monoBehaviour)
//            : this(monoBehaviour, new List<UnitySceneNode>())
//        { }

//        public UnitySceneNode(MonoBehaviour monoBehaviour, IList<UnitySceneNode> nodes)
//        {
//            this.monoBehaviour = monoBehaviour;
//            this.Nodes = nodes.ToList();
//        }

//        public void InvokeActionOnDescendants(MonoBehaviourAction action, params object[] parameters)
//        {
//            foreach (var node in Nodes)
//            {
//                node.monoBehaviour.InvokeAction(action, parameters);
//                node.InvokeActionOnDescendants(action, parameters);
//            }
//        }
//    }    
//}