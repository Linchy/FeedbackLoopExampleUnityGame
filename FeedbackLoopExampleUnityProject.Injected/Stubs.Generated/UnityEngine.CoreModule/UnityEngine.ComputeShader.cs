using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class ComputeShader : FL_UnityEngine.Object {
		public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) => throw new NotImplementedException();
		public void DispatchIndirect(int kernelIndex, FL_UnityEngine.ComputeBuffer argsBuffer, System.UInt32 argsOffset) => throw new NotImplementedException();
		public void DispatchIndirect(int kernelIndex, FL_UnityEngine.ComputeBuffer argsBuffer) => throw new NotImplementedException();
		public int FindKernel(string name) => throw new NotImplementedException();
		public void GetKernelThreadGroupSizes(int kernelIndex, out System.UInt32 x, out System.UInt32 y, out System.UInt32 z) => throw new NotImplementedException();
		public bool HasKernel(string name) => throw new NotImplementedException();
		public void SetBool(string name, bool val) => throw new NotImplementedException();
		public void SetBool(int nameID, bool val) => throw new NotImplementedException();
		public void SetBuffer(int kernelIndex, int nameID, FL_UnityEngine.ComputeBuffer buffer) => throw new NotImplementedException();
		public void SetBuffer(int kernelIndex, string name, FL_UnityEngine.ComputeBuffer buffer) => throw new NotImplementedException();
		public void SetFloat(int nameID, float val) => throw new NotImplementedException();
		public void SetFloat(string name, float val) => throw new NotImplementedException();
		public void SetFloats(string name, float[] values) => throw new NotImplementedException();
		public void SetFloats(int nameID, float[] values) => throw new NotImplementedException();
		public void SetInt(int nameID, int val) => throw new NotImplementedException();
		public void SetInt(string name, int val) => throw new NotImplementedException();
		public void SetInts(string name, int[] values) => throw new NotImplementedException();
		public void SetInts(int nameID, int[] values) => throw new NotImplementedException();
		public void SetMatrix(int nameID, UnityEngine.Matrix4x4 val) => throw new NotImplementedException();
		public void SetMatrix(string name, UnityEngine.Matrix4x4 val) => throw new NotImplementedException();
		public void SetMatrixArray(int nameID, UnityEngine.Matrix4x4[] values) => throw new NotImplementedException();
		public void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values) => throw new NotImplementedException();
		public void SetTexture(int kernelIndex, int nameID, FL_UnityEngine.Texture texture, int mipLevel) => throw new NotImplementedException();
		public void SetTexture(int kernelIndex, int nameID, FL_UnityEngine.Texture texture) => throw new NotImplementedException();
		public void SetTexture(int kernelIndex, string name, FL_UnityEngine.Texture texture) => throw new NotImplementedException();
		public void SetTexture(int kernelIndex, string name, FL_UnityEngine.Texture texture, int mipLevel) => throw new NotImplementedException();
		public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID) => throw new NotImplementedException();
		public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName) => throw new NotImplementedException();
		public void SetVector(int nameID, UnityEngine.Vector4 val) => throw new NotImplementedException();
		public void SetVector(string name, UnityEngine.Vector4 val) => throw new NotImplementedException();
		public void SetVectorArray(int nameID, UnityEngine.Vector4[] values) => throw new NotImplementedException();
		public void SetVectorArray(string name, UnityEngine.Vector4[] values) => throw new NotImplementedException();
	}
}
