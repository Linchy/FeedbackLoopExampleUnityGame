using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class DefaultExecutionOrder : System.Attribute {
		//public DefaultExecutionOrder(int order) { }
		public int order { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
