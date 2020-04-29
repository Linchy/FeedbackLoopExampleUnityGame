using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Texture2DArray : FL_UnityEngine.Texture {
		//public Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
		//public Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear) { }
		//public Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain) { }
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) => throw new NotImplementedException();
		public void Apply(bool updateMipmaps) => throw new NotImplementedException();
		public void Apply() => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(int arrayElement, int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(int arrayElement) => throw new NotImplementedException();
		public UnityEngine.Color32[] GetPixels32(int arrayElement, int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color32[] GetPixels32(int arrayElement) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors, int arrayElement, int miplevel) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors, int arrayElement) => throw new NotImplementedException();
		public void SetPixels32(UnityEngine.Color32[] colors, int arrayElement, int miplevel) => throw new NotImplementedException();
		public void SetPixels32(UnityEngine.Color32[] colors, int arrayElement) => throw new NotImplementedException();
		public int depth => throw new NotImplementedException();
		public UnityEngine.TextureFormat format => throw new NotImplementedException();
		public override bool isReadable => throw new NotImplementedException();
	}
}
