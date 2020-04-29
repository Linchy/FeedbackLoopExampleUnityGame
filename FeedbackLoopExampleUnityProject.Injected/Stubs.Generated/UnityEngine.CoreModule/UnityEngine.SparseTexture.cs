using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class SparseTexture : FL_UnityEngine.Texture {
		//public SparseTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount) { }
		//public SparseTexture(int width, int height, UnityEngine.TextureFormat format, int mipCount) { }
		//public SparseTexture(int width, int height, UnityEngine.TextureFormat format, int mipCount, bool linear) { }
		public void UnloadTile(int tileX, int tileY, int miplevel) => throw new NotImplementedException();
		public void UpdateTile(int tileX, int tileY, int miplevel, UnityEngine.Color32[] data) => throw new NotImplementedException();
		public void UpdateTileRaw(int tileX, int tileY, int miplevel, byte[] data) => throw new NotImplementedException();
		public bool isCreated => throw new NotImplementedException();
		public int tileHeight => throw new NotImplementedException();
		public int tileWidth => throw new NotImplementedException();
	}
}
