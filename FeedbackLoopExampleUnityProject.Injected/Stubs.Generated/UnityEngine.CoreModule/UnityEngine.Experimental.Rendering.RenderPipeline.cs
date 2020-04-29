using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Experimental.Rendering
{
	public unsafe partial class RenderPipeline {
		public static event System.Action<FL_UnityEngine.Camera> beginCameraRendering;
		public static event System.Action<FL_UnityEngine.Camera[]> beginFrameRendering;
		public static void BeginCameraRendering(FL_UnityEngine.Camera camera) => throw new NotImplementedException();
		public static void BeginFrameRendering(FL_UnityEngine.Camera[] cameras) => throw new NotImplementedException();
		public virtual void Dispose() => throw new NotImplementedException();
		public virtual void Render(UnityEngine.Experimental.Rendering.ScriptableRenderContext renderContext, FL_UnityEngine.Camera[] cameras) => throw new NotImplementedException();
		public virtual bool disposed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
