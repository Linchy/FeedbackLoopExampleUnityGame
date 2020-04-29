using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class WaitUntil : FL_UnityEngine.CustomYieldInstruction {
		//public WaitUntil(System.Func<bool> predicate) { }
		public override bool keepWaiting => throw new NotImplementedException();
	}
}
