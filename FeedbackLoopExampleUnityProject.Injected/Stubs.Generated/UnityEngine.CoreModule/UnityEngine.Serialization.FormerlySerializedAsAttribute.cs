using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Serialization
{
	public unsafe partial class FormerlySerializedAsAttribute : System.Attribute {
		//public FormerlySerializedAsAttribute(string oldName) { }
		public string oldName => throw new NotImplementedException();
	}
}
