using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Profiling
{
	public unsafe partial class Profiler {
		public static void AddFramesFromFile(string file) => throw new NotImplementedException();
		public static void BeginSample(string name) => throw new NotImplementedException();
		public static void BeginSample(string name, FL_UnityEngine.Object targetObject) => throw new NotImplementedException();
		public static void BeginThreadProfiling(string threadGroupName, string threadName) => throw new NotImplementedException();
		public static void EndSample() => throw new NotImplementedException();
		public static void EndThreadProfiling() => throw new NotImplementedException();
		public static long GetAllocatedMemoryForGraphicsDriver() => throw new NotImplementedException();
		public static bool GetAreaEnabled(UnityEngine.Profiling.ProfilerArea area) => throw new NotImplementedException();
		public static long GetMonoHeapSizeLong() => throw new NotImplementedException();
		public static long GetMonoUsedSizeLong() => throw new NotImplementedException();
		public static long GetRuntimeMemorySizeLong(FL_UnityEngine.Object o) => throw new NotImplementedException();
		public static System.UInt32 GetTempAllocatorSize() => throw new NotImplementedException();
		public static long GetTotalAllocatedMemoryLong() => throw new NotImplementedException();
		public static long GetTotalReservedMemoryLong() => throw new NotImplementedException();
		public static long GetTotalUnusedReservedMemoryLong() => throw new NotImplementedException();
		public static void SetAreaEnabled(UnityEngine.Profiling.ProfilerArea area, bool enabled) => throw new NotImplementedException();
		public static bool SetTempAllocatorRequestedSize(System.UInt32 size) => throw new NotImplementedException();
		public static int areaCount => throw new NotImplementedException();
		public static bool enableBinaryLog { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool enabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static string logFile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static int maxUsedMemory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool supported => throw new NotImplementedException();
		public static long usedHeapSizeLong => throw new NotImplementedException();
	}
}
