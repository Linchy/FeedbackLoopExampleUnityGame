using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class ContextMenuItemAttribute : FL_UnityEngine.PropertyAttribute {
		//public ContextMenuItemAttribute(string name, string function) { }
		public string function;
		public string name;
	}
}
