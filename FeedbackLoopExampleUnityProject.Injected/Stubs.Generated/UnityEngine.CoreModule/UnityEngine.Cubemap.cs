using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Cubemap : FL_UnityEngine.Texture {
		//public Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
		//public Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain) { }
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) => throw new NotImplementedException();
		public void Apply(bool updateMipmaps) => throw new NotImplementedException();
		public void Apply() => throw new NotImplementedException();
		public static FL_UnityEngine.Cubemap CreateExternalTexture(int width, UnityEngine.TextureFormat format, bool mipmap, System.IntPtr nativeTex) => throw new NotImplementedException();
		public UnityEngine.Color GetPixel(UnityEngine.CubemapFace face, int x, int y) => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace face, int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace face) => throw new NotImplementedException();
		public void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int miplevel) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face) => throw new NotImplementedException();
		public void SmoothEdges(int smoothRegionWidthInPixels) => throw new NotImplementedException();
		public void SmoothEdges() => throw new NotImplementedException();
		public UnityEngine.TextureFormat format => throw new NotImplementedException();
		public override bool isReadable => throw new NotImplementedException();
		public int mipmapCount => throw new NotImplementedException();
	}
}
