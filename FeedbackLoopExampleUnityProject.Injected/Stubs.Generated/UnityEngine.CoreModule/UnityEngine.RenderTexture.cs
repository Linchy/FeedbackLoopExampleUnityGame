using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class RenderTexture : FL_UnityEngine.Texture {
		//public RenderTexture(UnityEngine.RenderTextureDescriptor desc) { }
		//public RenderTexture(FL_UnityEngine.RenderTexture textureToCopy) { }
		//public RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format) { }
		//public RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite) { }
		//public RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format) { }
		//public RenderTexture(int width, int height, int depth) { }
		public void ConvertToEquirect(FL_UnityEngine.RenderTexture equirect, UnityEngine.Camera.MonoOrStereoscopicEye eye) => throw new NotImplementedException();
		public bool Create() => throw new NotImplementedException();
		public void DiscardContents(bool discardColor, bool discardDepth) => throw new NotImplementedException();
		public void DiscardContents() => throw new NotImplementedException();
		public void GenerateMips() => throw new NotImplementedException();
		public System.IntPtr GetNativeDepthBufferPtr() => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(int width, int height) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc) => throw new NotImplementedException();
		public bool IsCreated() => throw new NotImplementedException();
		public void MarkRestoreExpected() => throw new NotImplementedException();
		public void Release() => throw new NotImplementedException();
		public static void ReleaseTemporary(FL_UnityEngine.RenderTexture temp) => throw new NotImplementedException();
		public void ResolveAntiAliasedSurface() => throw new NotImplementedException();
		public void ResolveAntiAliasedSurface(FL_UnityEngine.RenderTexture target) => throw new NotImplementedException();
		public void SetGlobalShaderProperty(string propertyName) => throw new NotImplementedException();
		public static bool SupportsStencil(FL_UnityEngine.RenderTexture rt) => throw new NotImplementedException();
		public static FL_UnityEngine.RenderTexture active { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int antiAliasing { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool autoGenerateMips { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool bindTextureMS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.RenderBuffer colorBuffer => throw new NotImplementedException();
		public int depth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.RenderBuffer depthBuffer => throw new NotImplementedException();
		public UnityEngine.RenderTextureDescriptor descriptor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public override UnityEngine.Rendering.TextureDimension dimension { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool enableRandomWrite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.RenderTextureFormat format { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public override int height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool isPowerOfTwo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.RenderTextureMemoryless memorylessMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool sRGB => throw new NotImplementedException();
		public bool useDynamicScale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool useMipMap { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int volumeDepth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.VRTextureUsage vrUsage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public override int width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
