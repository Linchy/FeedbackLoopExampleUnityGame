using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Texture : FL_UnityEngine.Object {
		public System.IntPtr GetNativeTexturePtr() => throw new NotImplementedException();
		public void IncrementUpdateCount() => throw new NotImplementedException();
		public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) => throw new NotImplementedException();
		public static void SetStreamingTextureMaterialDebugProperties() => throw new NotImplementedException();
		public int anisoLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static UnityEngine.AnisotropicFiltering anisotropicFiltering { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static System.UInt64 currentTextureMemory => throw new NotImplementedException();
		public static System.UInt64 desiredTextureMemory => throw new NotImplementedException();
		public virtual UnityEngine.Rendering.TextureDimension dimension { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.FilterMode filterMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual int height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Hash128 imageContentsHash { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual bool isReadable => throw new NotImplementedException();
		public static int masterTextureLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float mipMapBias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static System.UInt64 nonStreamingTextureCount => throw new NotImplementedException();
		public static System.UInt64 nonStreamingTextureMemory => throw new NotImplementedException();
		public static System.UInt64 streamingMipmapUploadCount => throw new NotImplementedException();
		public static System.UInt64 streamingRendererCount => throw new NotImplementedException();
		public static System.UInt64 streamingTextureCount => throw new NotImplementedException();
		public static bool streamingTextureDiscardUnusedMips { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool streamingTextureForceLoadAll { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static System.UInt64 streamingTextureLoadingCount => throw new NotImplementedException();
		public static System.UInt64 streamingTexturePendingLoadCount => throw new NotImplementedException();
		public static System.UInt64 targetTextureMemory => throw new NotImplementedException();
		public UnityEngine.Vector2 texelSize => throw new NotImplementedException();
		public static System.UInt64 totalTextureMemory => throw new NotImplementedException();
		public System.UInt32 updateCount => throw new NotImplementedException();
		public virtual int width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.TextureWrapMode wrapMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.TextureWrapMode wrapModeU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.TextureWrapMode wrapModeV { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.TextureWrapMode wrapModeW { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
