using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AddComponentMenu : System.Attribute {
		//public AddComponentMenu(string menuName) { }
		//public AddComponentMenu(string menuName, int order) { }
		public string componentMenu => throw new NotImplementedException();
		public int componentOrder => throw new NotImplementedException();
	}
}
