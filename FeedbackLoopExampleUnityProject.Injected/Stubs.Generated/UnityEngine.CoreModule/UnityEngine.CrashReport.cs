using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class CrashReport {
		public string text;
		public System.DateTime time;
		public void Remove() => throw new NotImplementedException();
		public static void RemoveAll() => throw new NotImplementedException();
		public static FL_UnityEngine.CrashReport lastReport => throw new NotImplementedException();
		public static FL_UnityEngine.CrashReport[] reports => throw new NotImplementedException();
	}
}
