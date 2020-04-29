using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Events
{
	public unsafe partial class UnityEvent : FL_UnityEngine.Events.UnityEventBase {
		//public UnityEvent() { }
		public void AddListener(UnityEngine.Events.UnityAction call) => throw new NotImplementedException();
		public void Invoke() => throw new NotImplementedException();
		public void RemoveListener(UnityEngine.Events.UnityAction call) => throw new NotImplementedException();
	}
}
