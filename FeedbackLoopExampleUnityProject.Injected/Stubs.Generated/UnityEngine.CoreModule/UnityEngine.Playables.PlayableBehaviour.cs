using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Playables
{
	public unsafe partial class PlayableBehaviour {
		//public PlayableBehaviour() { }
		public virtual System.Object Clone() => throw new NotImplementedException();
		public virtual void OnBehaviourDelay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) => throw new NotImplementedException();
		public virtual void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) => throw new NotImplementedException();
		public virtual void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) => throw new NotImplementedException();
		public virtual void OnGraphStart(UnityEngine.Playables.Playable playable) => throw new NotImplementedException();
		public virtual void OnGraphStop(UnityEngine.Playables.Playable playable) => throw new NotImplementedException();
		public virtual void OnPlayableCreate(UnityEngine.Playables.Playable playable) => throw new NotImplementedException();
		public virtual void OnPlayableDestroy(UnityEngine.Playables.Playable playable) => throw new NotImplementedException();
		public virtual void PrepareData(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) => throw new NotImplementedException();
		public virtual void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info) => throw new NotImplementedException();
		public virtual void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData) => throw new NotImplementedException();
	}
}
