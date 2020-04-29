using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class HashUtilities {
		public static void AppendHash(ref UnityEngine.Hash128 inHash, ref UnityEngine.Hash128 outHash) => throw new NotImplementedException();
		public static void ComputeHash128<T>(ref T value, ref UnityEngine.Hash128 hash) where T : struct => throw new NotImplementedException();
		public static void QuantisedMatrixHash(ref UnityEngine.Matrix4x4 value, ref UnityEngine.Hash128 hash) => throw new NotImplementedException();
		public static void QuantisedVectorHash(ref UnityEngine.Vector3 value, ref UnityEngine.Hash128 hash) => throw new NotImplementedException();
	}
}
