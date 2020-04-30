using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AnimationClip : FL_UnityEngine.Motion {
		//public AnimationClip() { }
		public void AddEvent(FL_UnityEngine.AnimationEvent evt) => throw new NotImplementedException();
		public void ClearCurves() => throw new NotImplementedException();
		public void EnsureQuaternionContinuity() => throw new NotImplementedException();
		public void SampleAnimation(FL_UnityEngine.GameObject go, float time) => throw new NotImplementedException();
		public void SetCurve(string relativePath, System.Type type, string propertyName, FL_UnityEngine.AnimationCurve curve) => throw new NotImplementedException();
		public bool empty => throw new NotImplementedException();
		public FL_UnityEngine.AnimationEvent[] events { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float frameRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool hasGenericRootTransform => throw new NotImplementedException();
		public bool hasMotionCurves => throw new NotImplementedException();
		public bool hasMotionFloatCurves => throw new NotImplementedException();
		public bool hasRootCurves => throw new NotImplementedException();
		public bool humanMotion => throw new NotImplementedException();
		public bool legacy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float length => throw new NotImplementedException();
		public UnityEngine.Bounds localBounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.WrapMode wrapMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
