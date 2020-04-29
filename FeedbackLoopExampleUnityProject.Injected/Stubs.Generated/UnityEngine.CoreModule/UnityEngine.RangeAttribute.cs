using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class RangeAttribute : FL_UnityEngine.PropertyAttribute {
		//public RangeAttribute(float min, float max) { }
		public float max;
		public float min;
	}
}
