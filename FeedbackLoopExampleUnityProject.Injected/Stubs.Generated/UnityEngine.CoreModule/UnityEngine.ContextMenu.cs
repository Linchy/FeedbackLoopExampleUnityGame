using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class ContextMenu : System.Attribute {
		//public ContextMenu(string itemName) { }
		//public ContextMenu(string itemName, bool isValidateFunction) { }
		//public ContextMenu(string itemName, bool isValidateFunction, int priority) { }
		public string menuItem;
		public int priority;
		public bool validate;
	}
}
