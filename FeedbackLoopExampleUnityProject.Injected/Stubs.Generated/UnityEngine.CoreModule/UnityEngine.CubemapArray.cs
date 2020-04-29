using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class CubemapArray : FL_UnityEngine.Texture {
		//public CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
		//public CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear) { }
		//public CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain) { }
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) => throw new NotImplementedException();
		public void Apply(bool updateMipmaps) => throw new NotImplementedException();
		public void Apply() => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace face, int arrayElement, int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace face, int arrayElement) => throw new NotImplementedException();
		public UnityEngine.Color32[] GetPixels32(UnityEngine.CubemapFace face, int arrayElement, int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color32[] GetPixels32(UnityEngine.CubemapFace face, int arrayElement) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement) => throw new NotImplementedException();
		public void SetPixels32(UnityEngine.Color32[] colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel) => throw new NotImplementedException();
		public void SetPixels32(UnityEngine.Color32[] colors, UnityEngine.CubemapFace face, int arrayElement) => throw new NotImplementedException();
		public int cubemapCount => throw new NotImplementedException();
		public UnityEngine.TextureFormat format => throw new NotImplementedException();
		public override bool isReadable => throw new NotImplementedException();
	}
}
