using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Texture2D : FL_UnityEngine.Texture {
		//public Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) { }
		//public Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear) { }
		//public Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain) { }
		//public Texture2D(int width, int height) { }
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) => throw new NotImplementedException();
		public void Apply(bool updateMipmaps) => throw new NotImplementedException();
		public void Apply() => throw new NotImplementedException();
		public void ClearRequestedMipmapLevel() => throw new NotImplementedException();
		public void Compress(bool highQuality) => throw new NotImplementedException();
		public static FL_UnityEngine.Texture2D CreateExternalTexture(int width, int height, UnityEngine.TextureFormat format, bool mipChain, bool linear, System.IntPtr nativeTex) => throw new NotImplementedException();
		public static bool GenerateAtlas(UnityEngine.Vector2[] sizes, int padding, int atlasSize, System.Collections.Generic.List<UnityEngine.Rect> results) => throw new NotImplementedException();
		public UnityEngine.Color GetPixel(int x, int y) => throw new NotImplementedException();
		public UnityEngine.Color GetPixelBilinear(float x, float y) => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels() => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) => throw new NotImplementedException();
		public UnityEngine.Color32[] GetPixels32(int miplevel) => throw new NotImplementedException();
		public UnityEngine.Color32[] GetPixels32() => throw new NotImplementedException();
		public byte[] GetRawTextureData() => throw new NotImplementedException();
		public Unity.Collections.NativeArray<T> GetRawTextureData<T>() where T : struct => throw new NotImplementedException();
		public bool IsRequestedMipmapLevelLoaded() => throw new NotImplementedException();
		public void LoadRawTextureData(System.IntPtr data, int size) => throw new NotImplementedException();
		public void LoadRawTextureData(byte[] data) => throw new NotImplementedException();
		public void LoadRawTextureData<T>(Unity.Collections.NativeArray<T> data) where T : struct => throw new NotImplementedException();
		public UnityEngine.Rect[] PackTextures(FL_UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) => throw new NotImplementedException();
		public UnityEngine.Rect[] PackTextures(FL_UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize) => throw new NotImplementedException();
		public UnityEngine.Rect[] PackTextures(FL_UnityEngine.Texture2D[] textures, int padding) => throw new NotImplementedException();
		public void ReadPixels(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps) => throw new NotImplementedException();
		public void ReadPixels(UnityEngine.Rect source, int destX, int destY) => throw new NotImplementedException();
		public bool Resize(int width, int height) => throw new NotImplementedException();
		public bool Resize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap) => throw new NotImplementedException();
		public void SetPixel(int x, int y, UnityEngine.Color color) => throw new NotImplementedException();
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors, int miplevel) => throw new NotImplementedException();
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors, int miplevel) => throw new NotImplementedException();
		public void SetPixels(UnityEngine.Color[] colors) => throw new NotImplementedException();
		public void SetPixels32(UnityEngine.Color32[] colors, int miplevel) => throw new NotImplementedException();
		public void SetPixels32(UnityEngine.Color32[] colors) => throw new NotImplementedException();
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel) => throw new NotImplementedException();
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors) => throw new NotImplementedException();
		public void UpdateExternalTexture(System.IntPtr nativeTex) => throw new NotImplementedException();
		public bool alphaIsTransparency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static FL_UnityEngine.Texture2D blackTexture => throw new NotImplementedException();
		public int desiredMipmapLevel => throw new NotImplementedException();
		public UnityEngine.TextureFormat format => throw new NotImplementedException();
		public override bool isReadable => throw new NotImplementedException();
		public int loadedMipmapLevel => throw new NotImplementedException();
		public int loadingMipmapLevel => throw new NotImplementedException();
		public int mipmapCount => throw new NotImplementedException();
		public int requestedMipmapLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool streamingMipmaps => throw new NotImplementedException();
		public int streamingMipmapsPriority => throw new NotImplementedException();
		public static FL_UnityEngine.Texture2D whiteTexture => throw new NotImplementedException();
	}
}
