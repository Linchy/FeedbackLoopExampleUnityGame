using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Debug {
		//public Debug() { }
		public static void Assert(bool condition) { }
		public static void Assert(bool condition, FL_UnityEngine.Object context) { }
		public static void Assert(bool condition, System.Object message) { }
		public static void Assert(bool condition, string message) { }
		public static void Assert(bool condition, System.Object message, FL_UnityEngine.Object context) { }
		public static void Assert(bool condition, string message, FL_UnityEngine.Object context) { }
		public static void AssertFormat(bool condition, string format, System.Object[] args) { }
		public static void AssertFormat(bool condition, FL_UnityEngine.Object context, string format, System.Object[] args) { }
		public static void Break() { }
		public static void ClearDeveloperConsole() { }
		public static void DebugBreak() { }
		public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration) { }
		public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color) { }
		public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end) { }
		public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration, bool depthTest) { }
		public static void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, float duration) { }
		public static void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color) { }
		public static void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir) { }
		public static void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, float duration, bool depthTest) { }
		public static void Log(System.Object message) { }
		public static void Log(System.Object message, FL_UnityEngine.Object context) { }
		public static void LogAssertion(System.Object message) { }
		public static void LogAssertion(System.Object message, FL_UnityEngine.Object context) { }
		public static void LogAssertionFormat(string format, System.Object[] args) { }
		public static void LogAssertionFormat(FL_UnityEngine.Object context, string format, System.Object[] args) { }
		public static void LogError(System.Object message) { }
		public static void LogError(System.Object message, FL_UnityEngine.Object context) { }
		public static void LogErrorFormat(string format, System.Object[] args) { }
		public static void LogErrorFormat(FL_UnityEngine.Object context, string format, System.Object[] args) { }
		public static void LogException(System.Exception exception) { }
		public static void LogException(System.Exception exception, FL_UnityEngine.Object context) { }
		public static void LogFormat(string format, System.Object[] args) { }
		public static void LogFormat(FL_UnityEngine.Object context, string format, System.Object[] args) { }
		public static void LogWarning(System.Object message) { }
		public static void LogWarning(System.Object message, FL_UnityEngine.Object context) { }
		public static void LogWarningFormat(string format, System.Object[] args) { }
		public static void LogWarningFormat(FL_UnityEngine.Object context, string format, System.Object[] args) { }
		public static bool developerConsoleVisible { get; set; }
		public static bool isDebugBuild { get;  }
		public static UnityEngine.ILogger unityLogger { get; }
	}
}
