using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Events
{
	public unsafe partial class UnityEvent<T0, T1, T2, T3> : FL_UnityEngine.Events.UnityEventBase {
		//public UnityEvent() { }
		public void AddListener(UnityEngine.Events.UnityAction<T0, T1, T2, T3> call) => throw new NotImplementedException();
		public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) => throw new NotImplementedException();
		public void RemoveListener(UnityEngine.Events.UnityAction<T0, T1, T2, T3> call) => throw new NotImplementedException();
	}
}
