using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Experimental.Rendering
{
	public unsafe partial class RenderPipelineAsset : FL_UnityEngine.ScriptableObject {
		public virtual UnityEngine.Experimental.Rendering.IRenderPipeline CreatePipeline() => throw new NotImplementedException();
		public virtual void DestroyCreatedInstances() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Shader GetAutodeskInteractiveMaskedShader() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Shader GetAutodeskInteractiveShader() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Shader GetAutodeskInteractiveTransparentShader() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Material GetDefault2DMaterial() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Material GetDefaultLineMaterial() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Material GetDefaultMaterial() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Material GetDefaultParticleMaterial() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Shader GetDefaultShader() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Material GetDefaultTerrainMaterial() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Material GetDefaultUIETC1SupportedMaterial() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Material GetDefaultUIMaterial() => throw new NotImplementedException();
		public virtual FL_UnityEngine.Material GetDefaultUIOverdrawMaterial() => throw new NotImplementedException();
		public virtual string[] GetRenderingLayerMaskNames() => throw new NotImplementedException();
		public virtual int GetTerrainBrushPassIndex() => throw new NotImplementedException();
	}
}
