using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Texture3D : FL_UnityEngine.Texture {
		//public Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
		//public Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain) { }
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) => throw new NotImplementedException();
		public void Apply(bool updateMipmaps) => throw new NotImplementedException();
		public void Apply() => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels() => throw new NotImplementedException();
		public UnityEngine.Color32[] GetPixels32(int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color32[] GetPixels32() => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors, int miplevel) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors) => throw new NotImplementedException();
		public void SetPixels32(UnityEngine.Color32[] colors, int miplevel) => throw new NotImplementedException();
		public void SetPixels32(UnityEngine.Color32[] colors) => throw new NotImplementedException();
		public int depth => throw new NotImplementedException();
		public UnityEngine.TextureFormat format => throw new NotImplementedException();
		public override bool isReadable => throw new NotImplementedException();
	}
}
