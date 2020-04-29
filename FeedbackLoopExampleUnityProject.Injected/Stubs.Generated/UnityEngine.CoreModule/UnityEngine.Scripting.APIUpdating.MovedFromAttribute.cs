using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Scripting.APIUpdating
{
	public unsafe partial class MovedFromAttribute : System.Attribute {
		//public MovedFromAttribute(string sourceNamespace) { }
		//public MovedFromAttribute(string sourceNamespace, bool isInDifferentAssembly) { }
		public bool IsInDifferentAssembly { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string Namespace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
