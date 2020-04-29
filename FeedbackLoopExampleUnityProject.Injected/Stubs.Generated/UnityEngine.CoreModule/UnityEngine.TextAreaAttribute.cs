using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class TextAreaAttribute : FL_UnityEngine.PropertyAttribute {
		//public TextAreaAttribute() { }
		//public TextAreaAttribute(int minLines, int maxLines) { }
		public int maxLines;
		public int minLines;
	}
}
