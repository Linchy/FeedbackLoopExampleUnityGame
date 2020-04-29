using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Diagnostics
{
	public unsafe partial class Utils {
		public static void ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory crashCategory) => throw new NotImplementedException();
		public static void NativeAssert(string message) => throw new NotImplementedException();
		public static void NativeError(string message) => throw new NotImplementedException();
		public static void NativeWarning(string message) => throw new NotImplementedException();
	}
}
