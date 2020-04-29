using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Experimental.Rendering
{
	public unsafe partial class RenderPassAttachment : FL_UnityEngine.Object {
		//public RenderPassAttachment(UnityEngine.RenderTextureFormat fmt) { }
		public void BindResolveSurface(UnityEngine.Rendering.RenderTargetIdentifier tgt) => throw new NotImplementedException();
		public void BindSurface(UnityEngine.Rendering.RenderTargetIdentifier tgt, bool loadExistingContents, bool storeResults) => throw new NotImplementedException();
		public void Clear(UnityEngine.Color clearCol, float clearDep, System.UInt32 clearStenc) => throw new NotImplementedException();
		public static void Internal_CreateAttachment(FL_UnityEngine.Experimental.Rendering.RenderPassAttachment self) => throw new NotImplementedException();
		public UnityEngine.Color clearColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float clearDepth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public System.UInt32 clearStencil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.RenderTextureFormat format { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rendering.RenderBufferLoadAction loadAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rendering.RenderBufferStoreAction storeAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
