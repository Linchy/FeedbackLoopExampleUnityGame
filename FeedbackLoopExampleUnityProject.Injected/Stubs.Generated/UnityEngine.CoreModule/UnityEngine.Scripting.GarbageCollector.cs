using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Scripting
{
	public unsafe partial class GarbageCollector {
		public static event System.Action<UnityEngine.Scripting.GarbageCollector.Mode> GCModeChanged;
		public static UnityEngine.Scripting.GarbageCollector.Mode GCMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
