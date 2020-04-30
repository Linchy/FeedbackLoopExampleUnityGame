using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Animation : FL_UnityEngine.Behaviour {
		//public Animation() { }
		public void AddClip(FL_UnityEngine.AnimationClip clip, string newName) => throw new NotImplementedException();
		public void AddClip(FL_UnityEngine.AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) => throw new NotImplementedException();
		public void AddClip(FL_UnityEngine.AnimationClip clip, string newName, int firstFrame, int lastFrame) => throw new NotImplementedException();
		public void Blend(string animation, float targetWeight, float fadeLength) => throw new NotImplementedException();
		public void Blend(string animation, float targetWeight) => throw new NotImplementedException();
		public void Blend(string animation) => throw new NotImplementedException();
		public void CrossFade(string animation, float fadeLength, UnityEngine.PlayMode mode) => throw new NotImplementedException();
		public void CrossFade(string animation, float fadeLength) => throw new NotImplementedException();
		public void CrossFade(string animation) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, UnityEngine.QueueMode queue) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationState CrossFadeQueued(string animation) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationClip GetClip(string name) => throw new NotImplementedException();
		public int GetClipCount() => throw new NotImplementedException();
		public virtual System.Collections.IEnumerator GetEnumerator() => throw new NotImplementedException();
		public bool IsPlaying(string name) => throw new NotImplementedException();
		public bool Play() => throw new NotImplementedException();
		public bool Play(UnityEngine.PlayMode mode) => throw new NotImplementedException();
		public bool Play(string animation, UnityEngine.PlayMode mode) => throw new NotImplementedException();
		public bool Play(string animation) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationState PlayQueued(string animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationState PlayQueued(string animation, UnityEngine.QueueMode queue) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationState PlayQueued(string animation) => throw new NotImplementedException();
		public void RemoveClip(FL_UnityEngine.AnimationClip clip) => throw new NotImplementedException();
		public void RemoveClip(string clipName) => throw new NotImplementedException();
		public void Rewind(string name) => throw new NotImplementedException();
		public void Rewind() => throw new NotImplementedException();
		public void Sample() => throw new NotImplementedException();
		public void Stop() => throw new NotImplementedException();
		public void Stop(string name) => throw new NotImplementedException();
		public void SyncLayer(int layer) => throw new NotImplementedException();
		public bool animatePhysics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.AnimationClip clip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.AnimationCullingType cullingType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool isPlaying => throw new NotImplementedException();
		public FL_UnityEngine.AnimationState Item => throw new NotImplementedException();
		public UnityEngine.Bounds localBounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool playAutomatically { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.WrapMode wrapMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
