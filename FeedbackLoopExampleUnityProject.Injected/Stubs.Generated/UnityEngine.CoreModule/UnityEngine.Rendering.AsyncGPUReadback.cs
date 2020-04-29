using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Rendering
{
	public unsafe partial class AsyncGPUReadback {
		public static UnityEngine.Rendering.AsyncGPUReadbackRequest Request(FL_UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) => throw new NotImplementedException();
		public static UnityEngine.Rendering.AsyncGPUReadbackRequest Request(FL_UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) => throw new NotImplementedException();
		public static UnityEngine.Rendering.AsyncGPUReadbackRequest Request(FL_UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) => throw new NotImplementedException();
		public static UnityEngine.Rendering.AsyncGPUReadbackRequest Request(FL_UnityEngine.Texture src, int mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) => throw new NotImplementedException();
		public static UnityEngine.Rendering.AsyncGPUReadbackRequest Request(FL_UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) => throw new NotImplementedException();
		public static UnityEngine.Rendering.AsyncGPUReadbackRequest Request(FL_UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback) => throw new NotImplementedException();
	}
}
