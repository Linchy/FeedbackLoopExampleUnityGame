using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class CharacterController : FL_UnityEngine.Collider {
		//public CharacterController() { }
		public UnityEngine.CollisionFlags Move(UnityEngine.Vector3 motion) => throw new NotImplementedException();
		public bool SimpleMove(UnityEngine.Vector3 speed) => throw new NotImplementedException();
		public UnityEngine.Vector3 center { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.CollisionFlags collisionFlags => throw new NotImplementedException();
		public bool detectCollisions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool enableOverlapRecovery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool isGrounded => throw new NotImplementedException();
		public float minMoveDistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float radius { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float skinWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float slopeLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float stepOffset { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 velocity => throw new NotImplementedException();
	}
}
