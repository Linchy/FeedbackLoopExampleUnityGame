using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AndroidJavaException : System.Exception {
		public override string StackTrace => throw new NotImplementedException();
	}
}
