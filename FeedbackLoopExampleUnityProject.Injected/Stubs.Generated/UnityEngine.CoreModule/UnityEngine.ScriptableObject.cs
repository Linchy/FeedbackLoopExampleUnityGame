using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class ScriptableObject : FL_UnityEngine.Object {
		//public ScriptableObject() { }
		public static FL_UnityEngine.ScriptableObject CreateInstance(string className) => throw new NotImplementedException();
		public static FL_UnityEngine.ScriptableObject CreateInstance(System.Type type) => throw new NotImplementedException();
		public static T CreateInstance<T>() where T : FL_UnityEngine.ScriptableObject => throw new NotImplementedException();
	}
}
