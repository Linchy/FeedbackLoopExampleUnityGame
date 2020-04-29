using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class GameObject : FL_UnityEngine.Object {
		//public GameObject(string name) { }
		//public GameObject() { }
		//public GameObject(string name, System.Type[] components) { }
		public FL_UnityEngine.Component AddComponent(System.Type componentType) => throw new NotImplementedException();
		public T AddComponent<T>() where T : FL_UnityEngine.Component => throw new NotImplementedException();
		public void BroadcastMessage(string methodName, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void BroadcastMessage(string methodName, System.Object parameter, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void BroadcastMessage(string methodName, System.Object parameter) => throw new NotImplementedException();
		public void BroadcastMessage(string methodName) => throw new NotImplementedException();
		public bool CompareTag(string tag) => throw new NotImplementedException();
		public static FL_UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType type) => throw new NotImplementedException();
		public static FL_UnityEngine.GameObject Find(string name) => throw new NotImplementedException();
		public static FL_UnityEngine.GameObject[] FindGameObjectsWithTag(string tag) => throw new NotImplementedException();
		public static FL_UnityEngine.GameObject FindGameObjectWithTag(string tag) => throw new NotImplementedException();
		public static FL_UnityEngine.GameObject FindWithTag(string tag) => throw new NotImplementedException();
		public T GetComponent<T>() => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponent(System.Type type) => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponent(string type) => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponentInChildren(System.Type type, bool includeInactive) => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponentInChildren(System.Type type) => throw new NotImplementedException();
		public T GetComponentInChildren<T>() => throw new NotImplementedException();
		public T GetComponentInChildren<T>(bool includeInactive) => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponentInParent(System.Type type) => throw new NotImplementedException();
		public T GetComponentInParent<T>() => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponents(System.Type type) => throw new NotImplementedException();
		public T[] GetComponents<T>() => throw new NotImplementedException();
		public void GetComponents(System.Type type, System.Collections.Generic.List<FL_UnityEngine.Component> results) => throw new NotImplementedException();
		public void GetComponents<T>(System.Collections.Generic.List<T> results) => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponentsInChildren(System.Type type) => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponentsInChildren(System.Type type, bool includeInactive) => throw new NotImplementedException();
		public T[] GetComponentsInChildren<T>(bool includeInactive) => throw new NotImplementedException();
		public void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> results) => throw new NotImplementedException();
		public T[] GetComponentsInChildren<T>() => throw new NotImplementedException();
		public void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results) => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponentsInParent(System.Type type) => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponentsInParent(System.Type type, bool includeInactive) => throw new NotImplementedException();
		public void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results) => throw new NotImplementedException();
		public T[] GetComponentsInParent<T>(bool includeInactive) => throw new NotImplementedException();
		public T[] GetComponentsInParent<T>() => throw new NotImplementedException();
		public void SendMessage(string methodName, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void SendMessage(string methodName, System.Object value, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void SendMessage(string methodName, System.Object value) => throw new NotImplementedException();
		public void SendMessage(string methodName) => throw new NotImplementedException();
		public void SendMessageUpwards(string methodName, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void SendMessageUpwards(string methodName, System.Object value, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void SendMessageUpwards(string methodName, System.Object value) => throw new NotImplementedException();
		public void SendMessageUpwards(string methodName) => throw new NotImplementedException();
		public void SetActive(bool value) => throw new NotImplementedException();
		public bool activeInHierarchy => throw new NotImplementedException();
		public bool activeSelf => throw new NotImplementedException();
		public FL_UnityEngine.GameObject gameObject => throw new NotImplementedException();
		public bool isStatic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int layer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.SceneManagement.Scene scene => throw new NotImplementedException();
		public string tag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Transform transform => throw new NotImplementedException();
	}
}
