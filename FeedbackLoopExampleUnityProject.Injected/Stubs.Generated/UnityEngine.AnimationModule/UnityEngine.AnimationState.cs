using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AnimationState : FL_UnityEngine.TrackedReference {
		//public AnimationState() { }
		public void AddMixingTransform(FL_UnityEngine.Transform mix, bool recursive) => throw new NotImplementedException();
		public void AddMixingTransform(FL_UnityEngine.Transform mix) => throw new NotImplementedException();
		public void RemoveMixingTransform(FL_UnityEngine.Transform mix) => throw new NotImplementedException();
		public UnityEngine.AnimationBlendMode blendMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.AnimationClip clip => throw new NotImplementedException();
		public bool enabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int layer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float length => throw new NotImplementedException();
		public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float normalizedSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float normalizedTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float time { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.WrapMode wrapMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
