using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Experimental.Rendering
{
	public unsafe partial class RenderPass {
		//public RenderPass(UnityEngine.Experimental.Rendering.ScriptableRenderContext ctx, int w, int h, int samples, FL_UnityEngine.Experimental.Rendering.RenderPassAttachment[] colors, FL_UnityEngine.Experimental.Rendering.RenderPassAttachment depth) { }
		public virtual void Dispose() => throw new NotImplementedException();
		public FL_UnityEngine.Experimental.Rendering.RenderPassAttachment[] colorAttachments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Experimental.Rendering.ScriptableRenderContext context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Experimental.Rendering.RenderPassAttachment depthAttachment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int sampleCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
