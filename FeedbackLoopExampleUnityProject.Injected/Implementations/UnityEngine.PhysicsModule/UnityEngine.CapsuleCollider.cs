using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class CapsuleCollider : FL_UnityEngine.Collider {
		//public CapsuleCollider() { }
		public UnityEngine.Vector3 center { get; set; }
		public int direction { get; set; }
		public float height { get; set; }
		public float radius { get; set; }
	}
}
