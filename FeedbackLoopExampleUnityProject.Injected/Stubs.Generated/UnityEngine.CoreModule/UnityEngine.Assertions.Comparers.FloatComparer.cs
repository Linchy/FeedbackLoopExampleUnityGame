using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Assertions.Comparers
{
	public unsafe partial class FloatComparer {
		//public FloatComparer() { }
		//public FloatComparer(bool relative) { }
		//public FloatComparer(float error) { }
		//public FloatComparer(float error, bool relative) { }
		public static float kEpsilon;
		public static FL_UnityEngine.Assertions.Comparers.FloatComparer s_ComparerWithDefaultTolerance;
		public static bool AreEqual(float expected, float actual, float error) => throw new NotImplementedException();
		public static bool AreEqualRelative(float expected, float actual, float error) => throw new NotImplementedException();
		public virtual bool Equals(float a, float b) => throw new NotImplementedException();
		public virtual int GetHashCode(float obj) => throw new NotImplementedException();
	}
}
