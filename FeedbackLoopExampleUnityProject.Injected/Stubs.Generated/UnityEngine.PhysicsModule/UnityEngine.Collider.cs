using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Collider : FL_UnityEngine.Component {
		//public Collider() { }
		public UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance) => throw new NotImplementedException();
		public FL_UnityEngine.Rigidbody attachedRigidbody => throw new NotImplementedException();
		public UnityEngine.Bounds bounds => throw new NotImplementedException();
		public float contactOffset { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool enabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool isTrigger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.PhysicMaterial material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.PhysicMaterial sharedMaterial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
