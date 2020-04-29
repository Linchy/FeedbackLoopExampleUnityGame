using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Display {
		public static event UnityEngine.Display.DisplaysUpdatedDelegate onDisplaysUpdated;
		public static FL_UnityEngine.Display[] displays;
		public void Activate() => throw new NotImplementedException();
		public void Activate(int width, int height, int refreshRate) => throw new NotImplementedException();
		public static UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates) => throw new NotImplementedException();
		public void SetParams(int width, int height, int x, int y) => throw new NotImplementedException();
		public void SetRenderingResolution(int w, int h) => throw new NotImplementedException();
		public bool active => throw new NotImplementedException();
		public UnityEngine.RenderBuffer colorBuffer => throw new NotImplementedException();
		public UnityEngine.RenderBuffer depthBuffer => throw new NotImplementedException();
		public static FL_UnityEngine.Display main => throw new NotImplementedException();
		public int renderingHeight => throw new NotImplementedException();
		public int renderingWidth => throw new NotImplementedException();
		public int systemHeight => throw new NotImplementedException();
		public int systemWidth => throw new NotImplementedException();
	}
}
