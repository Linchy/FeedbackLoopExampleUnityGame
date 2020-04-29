using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.WSA
{
	public unsafe partial class Application {
		//public Application() { }
		public static event UnityEngine.WSA.WindowActivated windowActivated;
		public static event UnityEngine.WSA.WindowSizeChanged windowSizeChanged;
		public static void InvokeOnAppThread(UnityEngine.WSA.AppCallbackItem item, bool waitUntilDone) => throw new NotImplementedException();
		public static void InvokeOnUIThread(UnityEngine.WSA.AppCallbackItem item, bool waitUntilDone) => throw new NotImplementedException();
		public static bool RunningOnAppThread() => throw new NotImplementedException();
		public static bool RunningOnUIThread() => throw new NotImplementedException();
		public static string advertisingIdentifier => throw new NotImplementedException();
		public static string arguments => throw new NotImplementedException();
	}
}
