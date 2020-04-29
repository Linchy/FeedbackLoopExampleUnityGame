using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class GUIElement : FL_UnityEngine.Behaviour {
		//public GUIElement() { }
		public UnityEngine.Rect GetScreenRect(FL_UnityEngine.Camera camera) => throw new NotImplementedException();
		public UnityEngine.Rect GetScreenRect() => throw new NotImplementedException();
		public bool HitTest(UnityEngine.Vector3 screenPosition) => throw new NotImplementedException();
		public bool HitTest(UnityEngine.Vector3 screenPosition, FL_UnityEngine.Camera camera) => throw new NotImplementedException();
	}
}
