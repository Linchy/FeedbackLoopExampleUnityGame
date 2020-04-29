using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class CustomRenderTexture : FL_UnityEngine.RenderTexture {
		//public CustomRenderTexture(int width, int height, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite) { }
		//public CustomRenderTexture(int width, int height, UnityEngine.RenderTextureFormat format) { }
		//public CustomRenderTexture(int width, int height) { }
		//public CustomRenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
		public void ClearUpdateZones() => throw new NotImplementedException();
		public void GetUpdateZones(System.Collections.Generic.List<UnityEngine.CustomRenderTextureUpdateZone> updateZones) => throw new NotImplementedException();
		public void Initialize() => throw new NotImplementedException();
		public void SetUpdateZones(UnityEngine.CustomRenderTextureUpdateZone[] updateZones) => throw new NotImplementedException();
		public void Update(int count) => throw new NotImplementedException();
		public void Update() => throw new NotImplementedException();
		public System.UInt32 cubemapFaceMask { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool doubleBuffered { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Color initializationColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Material initializationMaterial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.CustomRenderTextureUpdateMode initializationMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.CustomRenderTextureInitializationSource initializationSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Texture initializationTexture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Material material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int shaderPass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.CustomRenderTextureUpdateMode updateMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.CustomRenderTextureUpdateZoneSpace updateZoneSpace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool wrapUpdateZones { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
