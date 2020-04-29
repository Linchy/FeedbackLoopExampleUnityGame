using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Events
{
	public unsafe partial class UnityEventBase {
		public int GetPersistentEventCount() => throw new NotImplementedException();
		public string GetPersistentMethodName(int index) => throw new NotImplementedException();
		public FL_UnityEngine.Object GetPersistentTarget(int index) => throw new NotImplementedException();
		public static System.Reflection.MethodInfo GetValidMethodInfo(System.Object obj, string functionName, System.Type[] argumentTypes) => throw new NotImplementedException();
		public void RemoveAllListeners() => throw new NotImplementedException();
		public void SetPersistentListenerState(int index, UnityEngine.Events.UnityEventCallState state) => throw new NotImplementedException();
		public override string ToString() => throw new NotImplementedException();
	}
}
