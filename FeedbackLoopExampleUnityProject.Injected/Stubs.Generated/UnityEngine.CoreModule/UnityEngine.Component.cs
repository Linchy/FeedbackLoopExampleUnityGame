using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Component : FL_UnityEngine.Object {
		//public Component() { }
		public void BroadcastMessage(string methodName, System.Object parameter, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void BroadcastMessage(string methodName, System.Object parameter) => throw new NotImplementedException();
		public void BroadcastMessage(string methodName) => throw new NotImplementedException();
		public void BroadcastMessage(string methodName, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public bool CompareTag(string tag) => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponent(System.Type type) => throw new NotImplementedException();
		//public T GetComponent<T>() => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponent(string type) => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponentInChildren(System.Type t, bool includeInactive) => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponentInChildren(System.Type t) => throw new NotImplementedException();
		public T GetComponentInChildren<T>(bool includeInactive) => throw new NotImplementedException();
		public T GetComponentInChildren<T>() => throw new NotImplementedException();
		public FL_UnityEngine.Component GetComponentInParent(System.Type t) => throw new NotImplementedException();
		public T GetComponentInParent<T>() => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponents(System.Type type) => throw new NotImplementedException();
		public void GetComponents(System.Type type, System.Collections.Generic.List<FL_UnityEngine.Component> results) => throw new NotImplementedException();
		public void GetComponents<T>(System.Collections.Generic.List<T> results) => throw new NotImplementedException();
		public T[] GetComponents<T>() => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponentsInChildren(System.Type t, bool includeInactive) => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponentsInChildren(System.Type t) => throw new NotImplementedException();
		public T[] GetComponentsInChildren<T>(bool includeInactive) => throw new NotImplementedException();
		public void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> result) => throw new NotImplementedException();
		public T[] GetComponentsInChildren<T>() => throw new NotImplementedException();
		public void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results) => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponentsInParent(System.Type t, bool includeInactive) => throw new NotImplementedException();
		public FL_UnityEngine.Component[] GetComponentsInParent(System.Type t) => throw new NotImplementedException();
		public T[] GetComponentsInParent<T>(bool includeInactive) => throw new NotImplementedException();
		public void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results) => throw new NotImplementedException();
		public T[] GetComponentsInParent<T>() => throw new NotImplementedException();
		public void SendMessage(string methodName, System.Object value) => throw new NotImplementedException();
		public void SendMessage(string methodName) => throw new NotImplementedException();
		public void SendMessage(string methodName, System.Object value, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void SendMessage(string methodName, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void SendMessageUpwards(string methodName, System.Object value, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		public void SendMessageUpwards(string methodName, System.Object value) => throw new NotImplementedException();
		public void SendMessageUpwards(string methodName) => throw new NotImplementedException();
		public void SendMessageUpwards(string methodName, UnityEngine.SendMessageOptions options) => throw new NotImplementedException();
		//public FL_UnityEngine.GameObject gameObject => throw new NotImplementedException();
		public string tag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Transform transform => throw new NotImplementedException();
	}
}
