using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AndroidJNIHelper {
		public static ArrayType ConvertFromJNIArray<ArrayType>(System.IntPtr array) => throw new NotImplementedException();
		public static System.IntPtr ConvertToJNIArray(System.Array array) => throw new NotImplementedException();
		public static System.IntPtr CreateJavaProxy(FL_UnityEngine.AndroidJavaProxy proxy) => throw new NotImplementedException();
		public static System.IntPtr CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable) => throw new NotImplementedException();
		public static UnityEngine.jvalue[] CreateJNIArgArray(System.Object[] args) => throw new NotImplementedException();
		public static void DeleteJNIArgArray(System.Object[] args, UnityEngine.jvalue[] jniArgs) => throw new NotImplementedException();
		public static System.IntPtr GetConstructorID(System.IntPtr javaClass) => throw new NotImplementedException();
		public static System.IntPtr GetConstructorID(System.IntPtr javaClass, string signature) => throw new NotImplementedException();
		public static System.IntPtr GetConstructorID(System.IntPtr jclass, System.Object[] args) => throw new NotImplementedException();
		public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName) => throw new NotImplementedException();
		public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName, string signature) => throw new NotImplementedException();
		public static System.IntPtr GetFieldID(System.IntPtr javaClass, string fieldName, string signature, bool isStatic) => throw new NotImplementedException();
		public static System.IntPtr GetFieldID<FieldType>(System.IntPtr jclass, string fieldName, bool isStatic) => throw new NotImplementedException();
		public static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName) => throw new NotImplementedException();
		public static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName, string signature) => throw new NotImplementedException();
		public static System.IntPtr GetMethodID(System.IntPtr javaClass, string methodName, string signature, bool isStatic) => throw new NotImplementedException();
		public static System.IntPtr GetMethodID(System.IntPtr jclass, string methodName, System.Object[] args, bool isStatic) => throw new NotImplementedException();
		public static System.IntPtr GetMethodID<ReturnType>(System.IntPtr jclass, string methodName, System.Object[] args, bool isStatic) => throw new NotImplementedException();
		public static string GetSignature(System.Object obj) => throw new NotImplementedException();
		public static string GetSignature(System.Object[] args) => throw new NotImplementedException();
		public static string GetSignature<ReturnType>(System.Object[] args) => throw new NotImplementedException();
		public static bool debug { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
