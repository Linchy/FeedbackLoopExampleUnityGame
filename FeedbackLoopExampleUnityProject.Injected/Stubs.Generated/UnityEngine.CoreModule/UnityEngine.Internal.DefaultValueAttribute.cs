using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Internal
{
	public unsafe partial class DefaultValueAttribute : System.Attribute {
		//public DefaultValueAttribute(string value) { }
		public override bool Equals(System.Object obj) => throw new NotImplementedException();
		public override int GetHashCode() => throw new NotImplementedException();
		public System.Object Value => throw new NotImplementedException();
	}
}
