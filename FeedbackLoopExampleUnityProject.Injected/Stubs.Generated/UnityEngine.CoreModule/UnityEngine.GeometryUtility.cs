using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class GeometryUtility {
		//public GeometryUtility() { }
		public static UnityEngine.Bounds CalculateBounds(UnityEngine.Vector3[] positions, UnityEngine.Matrix4x4 transform) => throw new NotImplementedException();
		public static UnityEngine.Plane[] CalculateFrustumPlanes(FL_UnityEngine.Camera camera) => throw new NotImplementedException();
		public static UnityEngine.Plane[] CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix) => throw new NotImplementedException();
		public static void CalculateFrustumPlanes(FL_UnityEngine.Camera camera, UnityEngine.Plane[] planes) => throw new NotImplementedException();
		public static void CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix, UnityEngine.Plane[] planes) => throw new NotImplementedException();
		public static bool TestPlanesAABB(UnityEngine.Plane[] planes, UnityEngine.Bounds bounds) => throw new NotImplementedException();
		public static bool TryCreatePlaneFromPolygon(UnityEngine.Vector3[] vertices, out UnityEngine.Plane plane) => throw new NotImplementedException();
	}
}
