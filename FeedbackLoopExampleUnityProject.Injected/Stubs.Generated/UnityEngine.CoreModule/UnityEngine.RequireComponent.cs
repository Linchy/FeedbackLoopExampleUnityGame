using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class RequireComponent : System.Attribute {
		//public RequireComponent(System.Type requiredComponent) { }
		//public RequireComponent(System.Type requiredComponent, System.Type requiredComponent2) { }
		//public RequireComponent(System.Type requiredComponent, System.Type requiredComponent2, System.Type requiredComponent3) { }
		public System.Type m_Type0;
		public System.Type m_Type1;
		public System.Type m_Type2;
	}
}
