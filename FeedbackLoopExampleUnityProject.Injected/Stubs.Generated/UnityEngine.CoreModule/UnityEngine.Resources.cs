using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Resources {
		//public Resources() { }
		public static FL_UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type) => throw new NotImplementedException();
		public static T[] FindObjectsOfTypeAll<T>() where T : FL_UnityEngine.Object => throw new NotImplementedException();
		public static FL_UnityEngine.Object GetBuiltinResource(System.Type type, string path) => throw new NotImplementedException();
		public static T GetBuiltinResource<T>(string path) where T : FL_UnityEngine.Object => throw new NotImplementedException();
		public static FL_UnityEngine.Object Load(string path) => throw new NotImplementedException();
		public static T Load<T>(string path) where T : FL_UnityEngine.Object => throw new NotImplementedException();
		public static FL_UnityEngine.Object Load(string path, System.Type systemTypeInstance) => throw new NotImplementedException();
		public static FL_UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance) => throw new NotImplementedException();
		public static FL_UnityEngine.Object[] LoadAll(string path) => throw new NotImplementedException();
		public static T[] LoadAll<T>(string path) where T : FL_UnityEngine.Object => throw new NotImplementedException();
		public static FL_UnityEngine.ResourceRequest LoadAsync(string path) => throw new NotImplementedException();
		public static FL_UnityEngine.ResourceRequest LoadAsync<T>(string path) where T : FL_UnityEngine.Object => throw new NotImplementedException();
		public static FL_UnityEngine.ResourceRequest LoadAsync(string path, System.Type type) => throw new NotImplementedException();
		public static void UnloadAsset(FL_UnityEngine.Object assetToUnload) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation UnloadUnusedAssets() => throw new NotImplementedException();
	}
}
