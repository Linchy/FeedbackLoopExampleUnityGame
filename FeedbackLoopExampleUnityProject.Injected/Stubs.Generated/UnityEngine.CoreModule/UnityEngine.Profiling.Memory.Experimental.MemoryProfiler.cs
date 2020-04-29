using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Profiling.Memory.Experimental
{
	public unsafe partial class MemoryProfiler {
		//public MemoryProfiler() { }
		public static event System.Action<FL_UnityEngine.Profiling.Memory.Experimental.MetaData> createMetaData;
		public static void TakeSnapshot(string path, System.Action<string, bool> finishCallback, UnityEngine.Profiling.Memory.Experimental.CaptureFlags captureFlags) => throw new NotImplementedException();
		public static void TakeTempSnapshot(System.Action<string, bool> finishCallback, UnityEngine.Profiling.Memory.Experimental.CaptureFlags captureFlags) => throw new NotImplementedException();
	}
}
