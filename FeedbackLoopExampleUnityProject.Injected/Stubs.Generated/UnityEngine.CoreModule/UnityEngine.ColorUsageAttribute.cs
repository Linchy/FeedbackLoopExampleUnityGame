using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class ColorUsageAttribute : FL_UnityEngine.PropertyAttribute {
		//public ColorUsageAttribute(bool showAlpha) { }
		//public ColorUsageAttribute(bool showAlpha, bool hdr) { }
		public bool hdr;
		public bool showAlpha;
	}
}
