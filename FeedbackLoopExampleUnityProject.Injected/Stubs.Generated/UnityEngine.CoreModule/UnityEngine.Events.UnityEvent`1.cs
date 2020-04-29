using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Events
{
	public unsafe partial class UnityEvent<T0> : FL_UnityEngine.Events.UnityEventBase {
		//public UnityEvent() { }
		public void AddListener(UnityEngine.Events.UnityAction<T0> call) => throw new NotImplementedException();
		public void Invoke(T0 arg0) => throw new NotImplementedException();
		public void RemoveListener(UnityEngine.Events.UnityAction<T0> call) => throw new NotImplementedException();
	}
}
