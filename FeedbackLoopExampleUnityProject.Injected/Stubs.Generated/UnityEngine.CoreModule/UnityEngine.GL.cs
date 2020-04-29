using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class GL {
		//public GL() { }
		public static int LINE_STRIP;
		public static int LINES;
		public static int QUADS;
		public static int TRIANGLE_STRIP;
		public static int TRIANGLES;
		public static void Begin(int mode) => throw new NotImplementedException();
		public static void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth) => throw new NotImplementedException();
		public static void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor) => throw new NotImplementedException();
		public static void ClearWithSkybox(bool clearDepth, FL_UnityEngine.Camera camera) => throw new NotImplementedException();
		public static void Color(UnityEngine.Color c) => throw new NotImplementedException();
		public static void End() => throw new NotImplementedException();
		public static void Flush() => throw new NotImplementedException();
		public static UnityEngine.Matrix4x4 GetGPUProjectionMatrix(UnityEngine.Matrix4x4 proj, bool renderIntoTexture) => throw new NotImplementedException();
		public static void InvalidateState() => throw new NotImplementedException();
		public static void IssuePluginEvent(System.IntPtr callback, int eventID) => throw new NotImplementedException();
		public static void LoadIdentity() => throw new NotImplementedException();
		public static void LoadOrtho() => throw new NotImplementedException();
		public static void LoadPixelMatrix() => throw new NotImplementedException();
		public static void LoadPixelMatrix(float left, float right, float bottom, float top) => throw new NotImplementedException();
		public static void LoadProjectionMatrix(UnityEngine.Matrix4x4 mat) => throw new NotImplementedException();
		public static void MultiTexCoord(int unit, UnityEngine.Vector3 v) => throw new NotImplementedException();
		public static void MultiTexCoord2(int unit, float x, float y) => throw new NotImplementedException();
		public static void MultiTexCoord3(int unit, float x, float y, float z) => throw new NotImplementedException();
		public static void MultMatrix(UnityEngine.Matrix4x4 m) => throw new NotImplementedException();
		public static void PopMatrix() => throw new NotImplementedException();
		public static void PushMatrix() => throw new NotImplementedException();
		public static void RenderTargetBarrier() => throw new NotImplementedException();
		public static void TexCoord(UnityEngine.Vector3 v) => throw new NotImplementedException();
		public static void TexCoord2(float x, float y) => throw new NotImplementedException();
		public static void TexCoord3(float x, float y, float z) => throw new NotImplementedException();
		public static void Vertex(UnityEngine.Vector3 v) => throw new NotImplementedException();
		public static void Vertex3(float x, float y, float z) => throw new NotImplementedException();
		public static void Viewport(UnityEngine.Rect pixelRect) => throw new NotImplementedException();
		public static bool invertCulling { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static UnityEngine.Matrix4x4 modelview { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool sRGBWrite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool wireframe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
