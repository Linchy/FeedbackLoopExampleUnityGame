using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Playables
{
	public unsafe partial class PlayableAsset : FL_UnityEngine.ScriptableObject {
		public virtual UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, FL_UnityEngine.GameObject owner) => throw new NotImplementedException();
		public virtual double duration => throw new NotImplementedException();
		public virtual System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> outputs => throw new NotImplementedException();
	}
}
