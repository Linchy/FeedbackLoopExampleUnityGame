using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AnimationCurve {
		//public AnimationCurve(UnityEngine.Keyframe[] keys) { }
		//public AnimationCurve() { }
		public int AddKey(float time, float value) => throw new NotImplementedException();
		public int AddKey(UnityEngine.Keyframe key) => throw new NotImplementedException();
		public static FL_UnityEngine.AnimationCurve Constant(float timeStart, float timeEnd, float value) => throw new NotImplementedException();
		public static FL_UnityEngine.AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) => throw new NotImplementedException();
		public override bool Equals(System.Object o) => throw new NotImplementedException();
		public virtual bool Equals(FL_UnityEngine.AnimationCurve other) => throw new NotImplementedException();
		public float Evaluate(float time) => throw new NotImplementedException();
		public override int GetHashCode() => throw new NotImplementedException();
		public static FL_UnityEngine.AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) => throw new NotImplementedException();
		public int MoveKey(int index, UnityEngine.Keyframe key) => throw new NotImplementedException();
		public void RemoveKey(int index) => throw new NotImplementedException();
		public void SmoothTangents(int index, float weight) => throw new NotImplementedException();
		public UnityEngine.Keyframe this[int index] => throw new NotImplementedException();
		public UnityEngine.Keyframe[] keys { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int length => throw new NotImplementedException();
		public UnityEngine.WrapMode postWrapMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.WrapMode preWrapMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
