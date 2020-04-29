using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class SkinnedMeshRenderer : FL_UnityEngine.Renderer {
		//public SkinnedMeshRenderer() { }
		public void BakeMesh(FL_UnityEngine.Mesh mesh) => throw new NotImplementedException();
		public float GetBlendShapeWeight(int index) => throw new NotImplementedException();
		public void SetBlendShapeWeight(int index, float value) => throw new NotImplementedException();
		public FL_UnityEngine.Transform[] bones { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool forceMatrixRecalculationPerRender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Bounds localBounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.SkinQuality quality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Transform rootBone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Mesh sharedMesh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool skinnedMotionVectors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool updateWhenOffscreen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
