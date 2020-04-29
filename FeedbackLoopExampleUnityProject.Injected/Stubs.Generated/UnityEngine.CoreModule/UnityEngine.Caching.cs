using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Caching {
		//public Caching() { }
		public static UnityEngine.Cache AddCache(string cachePath) => throw new NotImplementedException();
		public static bool ClearAllCachedVersions(string assetBundleName) => throw new NotImplementedException();
		public static bool ClearCache() => throw new NotImplementedException();
		public static bool ClearCache(int expiration) => throw new NotImplementedException();
		public static bool ClearCachedVersion(string assetBundleName, UnityEngine.Hash128 hash) => throw new NotImplementedException();
		public static bool ClearOtherCachedVersions(string assetBundleName, UnityEngine.Hash128 hash) => throw new NotImplementedException();
		public static void GetAllCachePaths(System.Collections.Generic.List<string> cachePaths) => throw new NotImplementedException();
		public static UnityEngine.Cache GetCacheAt(int cacheIndex) => throw new NotImplementedException();
		public static UnityEngine.Cache GetCacheByPath(string cachePath) => throw new NotImplementedException();
		public static void GetCachedVersions(string assetBundleName, System.Collections.Generic.List<UnityEngine.Hash128> outCachedVersions) => throw new NotImplementedException();
		public static bool IsVersionCached(string url, UnityEngine.Hash128 hash) => throw new NotImplementedException();
		public static bool IsVersionCached(UnityEngine.CachedAssetBundle cachedBundle) => throw new NotImplementedException();
		public static bool MarkAsUsed(string url, UnityEngine.Hash128 hash) => throw new NotImplementedException();
		public static bool MarkAsUsed(UnityEngine.CachedAssetBundle cachedBundle) => throw new NotImplementedException();
		public static void MoveCacheAfter(UnityEngine.Cache src, UnityEngine.Cache dst) => throw new NotImplementedException();
		public static void MoveCacheBefore(UnityEngine.Cache src, UnityEngine.Cache dst) => throw new NotImplementedException();
		public static bool RemoveCache(UnityEngine.Cache cache) => throw new NotImplementedException();
		public static void ResetNoBackupFlag(string url, UnityEngine.Hash128 hash) => throw new NotImplementedException();
		public static void ResetNoBackupFlag(UnityEngine.CachedAssetBundle cachedBundle) => throw new NotImplementedException();
		public static void SetNoBackupFlag(string url, UnityEngine.Hash128 hash) => throw new NotImplementedException();
		public static void SetNoBackupFlag(UnityEngine.CachedAssetBundle cachedBundle) => throw new NotImplementedException();
		public static int cacheCount => throw new NotImplementedException();
		public static bool compressionEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static UnityEngine.Cache currentCacheForWriting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static UnityEngine.Cache defaultCache => throw new NotImplementedException();
		public static bool ready => throw new NotImplementedException();
	}
}
