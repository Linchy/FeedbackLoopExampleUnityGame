using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class RectTransform : FL_UnityEngine.Transform {
		//public RectTransform() { }
		public static event UnityEngine.RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;
		public void ForceUpdateRectTransforms() => throw new NotImplementedException();
		public void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray) => throw new NotImplementedException();
		public void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray) => throw new NotImplementedException();
		public void SetInsetAndSizeFromParentEdge(UnityEngine.RectTransform.Edge edge, float inset, float size) => throw new NotImplementedException();
		public void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, float size) => throw new NotImplementedException();
		public UnityEngine.Vector2 anchoredPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 anchoredPosition3D { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 anchorMax { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 anchorMin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 offsetMax { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 offsetMin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 pivot { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rect rect => throw new NotImplementedException();
		public UnityEngine.Vector2 sizeDelta { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
