using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class MonoBehaviour : FL_UnityEngine.Behaviour {
		//public MonoBehaviour() { }
		public void CancelInvoke() => throw new NotImplementedException();
		public void CancelInvoke(string methodName) => throw new NotImplementedException();
		public void Invoke(string methodName, float time) => throw new NotImplementedException();
		public void InvokeRepeating(string methodName, float time, float repeatRate) => throw new NotImplementedException();
		public bool IsInvoking() => throw new NotImplementedException();
		public bool IsInvoking(string methodName) => throw new NotImplementedException();
		public static void print(System.Object message) => throw new NotImplementedException();
		public FL_UnityEngine.Coroutine StartCoroutine(string methodName) => throw new NotImplementedException();
		public FL_UnityEngine.Coroutine StartCoroutine(string methodName, System.Object value) => throw new NotImplementedException();
		public FL_UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine) => throw new NotImplementedException();
		public void StopAllCoroutines() => throw new NotImplementedException();
		public void StopCoroutine(System.Collections.IEnumerator routine) => throw new NotImplementedException();
		public void StopCoroutine(FL_UnityEngine.Coroutine routine) => throw new NotImplementedException();
		public void StopCoroutine(string methodName) => throw new NotImplementedException();
		public bool runInEditMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool useGUILayout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
