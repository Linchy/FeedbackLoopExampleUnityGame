using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Transform : FL_UnityEngine.Component {
		public void DetachChildren() => throw new NotImplementedException();
		public FL_UnityEngine.Transform Find(string n) => throw new NotImplementedException();
		public FL_UnityEngine.Transform GetChild(int index) => throw new NotImplementedException();
		public virtual System.Collections.IEnumerator GetEnumerator() => throw new NotImplementedException();
		public int GetSiblingIndex() => throw new NotImplementedException();
		public UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public UnityEngine.Vector3 InverseTransformDirection(float x, float y, float z) => throw new NotImplementedException();
		public UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public UnityEngine.Vector3 InverseTransformPoint(float x, float y, float z) => throw new NotImplementedException();
		public UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 vector) => throw new NotImplementedException();
		public UnityEngine.Vector3 InverseTransformVector(float x, float y, float z) => throw new NotImplementedException();
		public bool IsChildOf(FL_UnityEngine.Transform parent) => throw new NotImplementedException();
		public void LookAt(FL_UnityEngine.Transform target, UnityEngine.Vector3 worldUp) => throw new NotImplementedException();
		public void LookAt(FL_UnityEngine.Transform target) => throw new NotImplementedException();
		public void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp) => throw new NotImplementedException();
		public void LookAt(UnityEngine.Vector3 worldPosition) => throw new NotImplementedException();
		public void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo) => throw new NotImplementedException();
		public void Rotate(UnityEngine.Vector3 eulers) => throw new NotImplementedException();
		public void Rotate(float xAngle, float yAngle, float zAngle, UnityEngine.Space relativeTo) => throw new NotImplementedException();
		public void Rotate(float xAngle, float yAngle, float zAngle) => throw new NotImplementedException();
		public void Rotate(UnityEngine.Vector3 axis, float angle, UnityEngine.Space relativeTo) => throw new NotImplementedException();
		public void Rotate(UnityEngine.Vector3 axis, float angle) => throw new NotImplementedException();
		public void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, float angle) => throw new NotImplementedException();
		public void SetAsFirstSibling() => throw new NotImplementedException();
		public void SetAsLastSibling() => throw new NotImplementedException();
		public void SetParent(FL_UnityEngine.Transform p) => throw new NotImplementedException();
		public void SetParent(FL_UnityEngine.Transform parent, bool worldPositionStays) => throw new NotImplementedException();
		public void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) => throw new NotImplementedException();
		public void SetSiblingIndex(int index) => throw new NotImplementedException();
		public UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public UnityEngine.Vector3 TransformDirection(float x, float y, float z) => throw new NotImplementedException();
		public UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public UnityEngine.Vector3 TransformPoint(float x, float y, float z) => throw new NotImplementedException();
		public UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 vector) => throw new NotImplementedException();
		public UnityEngine.Vector3 TransformVector(float x, float y, float z) => throw new NotImplementedException();
		public void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo) => throw new NotImplementedException();
		public void Translate(UnityEngine.Vector3 translation) => throw new NotImplementedException();
		public void Translate(float x, float y, float z, UnityEngine.Space relativeTo) => throw new NotImplementedException();
		public void Translate(float x, float y, float z) => throw new NotImplementedException();
		public void Translate(UnityEngine.Vector3 translation, FL_UnityEngine.Transform relativeTo) => throw new NotImplementedException();
		public void Translate(float x, float y, float z, FL_UnityEngine.Transform relativeTo) => throw new NotImplementedException();
		public int childCount => throw new NotImplementedException();
		public UnityEngine.Vector3 eulerAngles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 forward { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool hasChanged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int hierarchyCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int hierarchyCount => throw new NotImplementedException();
		public UnityEngine.Vector3 localEulerAngles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 localPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Quaternion localRotation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 localScale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Matrix4x4 localToWorldMatrix => throw new NotImplementedException();
		public UnityEngine.Vector3 lossyScale => throw new NotImplementedException();
		//public FL_UnityEngine.Transform parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 right { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Transform root => throw new NotImplementedException();
		public UnityEngine.Quaternion rotation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 up { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Matrix4x4 worldToLocalMatrix => throw new NotImplementedException();
	}
}
