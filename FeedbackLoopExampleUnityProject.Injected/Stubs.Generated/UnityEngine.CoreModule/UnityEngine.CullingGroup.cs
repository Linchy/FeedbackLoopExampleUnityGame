using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class CullingGroup {
		//public CullingGroup() { }
		public virtual void Dispose() => throw new NotImplementedException();
		public void EraseSwapBack(int index) => throw new NotImplementedException();
		public static void EraseSwapBack<T>(int index, T[] myArray, ref int size) => throw new NotImplementedException();
		public int GetDistance(int index) => throw new NotImplementedException();
		public bool IsVisible(int index) => throw new NotImplementedException();
		public int QueryIndices(bool visible, int[] result, int firstIndex) => throw new NotImplementedException();
		public int QueryIndices(int distanceIndex, int[] result, int firstIndex) => throw new NotImplementedException();
		public int QueryIndices(bool visible, int distanceIndex, int[] result, int firstIndex) => throw new NotImplementedException();
		public void SetBoundingDistances(float[] distances) => throw new NotImplementedException();
		public void SetBoundingSphereCount(int count) => throw new NotImplementedException();
		public void SetBoundingSpheres(UnityEngine.BoundingSphere[] array) => throw new NotImplementedException();
		public void SetDistanceReferencePoint(UnityEngine.Vector3 point) => throw new NotImplementedException();
		public void SetDistanceReferencePoint(FL_UnityEngine.Transform transform) => throw new NotImplementedException();
		public bool enabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.CullingGroup.StateChanged onStateChanged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Camera targetCamera { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
