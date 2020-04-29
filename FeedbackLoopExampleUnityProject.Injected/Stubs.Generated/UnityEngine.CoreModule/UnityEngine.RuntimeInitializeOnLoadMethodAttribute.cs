using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class RuntimeInitializeOnLoadMethodAttribute : FL_UnityEngine.Scripting.PreserveAttribute {
		//public RuntimeInitializeOnLoadMethodAttribute() { }
		//public RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType loadType) { }
		public UnityEngine.RuntimeInitializeLoadType loadType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
