using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class UnityAPICompatibilityVersionAttribute : System.Attribute {
		//public UnityAPICompatibilityVersionAttribute(string version) { }
		public string version => throw new NotImplementedException();
	}
}
