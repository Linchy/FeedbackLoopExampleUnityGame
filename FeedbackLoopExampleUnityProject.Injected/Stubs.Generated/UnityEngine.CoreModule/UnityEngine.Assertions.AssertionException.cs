using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Assertions
{
	public unsafe partial class AssertionException : System.Exception {
		//public AssertionException(string message, string userMessage) { }
		public override string Message => throw new NotImplementedException();
	}
}
