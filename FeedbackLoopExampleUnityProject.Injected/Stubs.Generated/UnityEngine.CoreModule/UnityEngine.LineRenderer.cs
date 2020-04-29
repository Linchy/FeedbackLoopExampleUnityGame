using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class LineRenderer : FL_UnityEngine.Renderer {
		//public LineRenderer() { }
		public void BakeMesh(FL_UnityEngine.Mesh mesh, bool useTransform) => throw new NotImplementedException();
		public void BakeMesh(FL_UnityEngine.Mesh mesh, FL_UnityEngine.Camera camera, bool useTransform) => throw new NotImplementedException();
		public UnityEngine.Vector3 GetPosition(int index) => throw new NotImplementedException();
		public int GetPositions(UnityEngine.Vector3[] positions) => throw new NotImplementedException();
		public void SetPosition(int index, UnityEngine.Vector3 position) => throw new NotImplementedException();
		public void SetPositions(UnityEngine.Vector3[] positions) => throw new NotImplementedException();
		public void Simplify(float tolerance) => throw new NotImplementedException();
		public UnityEngine.LineAlignment alignment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Gradient colorGradient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Color endColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float endWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool generateLightingData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool loop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int numCapVertices { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int numCornerVertices { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int positionCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float shadowBias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Color startColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float startWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.LineTextureMode textureMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool useWorldSpace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.AnimationCurve widthCurve { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float widthMultiplier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
