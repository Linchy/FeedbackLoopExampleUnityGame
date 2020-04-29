using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class ComputeBuffer {
		//public ComputeBuffer(int count, int stride) { }
		//public ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type) { }
		public static void CopyCount(FL_UnityEngine.ComputeBuffer src, FL_UnityEngine.ComputeBuffer dst, int dstOffsetBytes) => throw new NotImplementedException();
		public virtual void Dispose() => throw new NotImplementedException();
		public void GetData(System.Array data) => throw new NotImplementedException();
		public void GetData(System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) => throw new NotImplementedException();
		public System.IntPtr GetNativeBufferPtr() => throw new NotImplementedException();
		public bool IsValid() => throw new NotImplementedException();
		public void Release() => throw new NotImplementedException();
		public void SetCounterValue(System.UInt32 counterValue) => throw new NotImplementedException();
		public void SetData(System.Array data) => throw new NotImplementedException();
		public void SetData<T>(System.Collections.Generic.List<T> data) where T : struct => throw new NotImplementedException();
		public void SetData<T>(Unity.Collections.NativeArray<T> data) where T : struct => throw new NotImplementedException();
		public void SetData(System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) => throw new NotImplementedException();
		public void SetData<T>(System.Collections.Generic.List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count) where T : struct => throw new NotImplementedException();
		public void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) where T : struct => throw new NotImplementedException();
		public int count => throw new NotImplementedException();
		public int stride => throw new NotImplementedException();
	}
}
