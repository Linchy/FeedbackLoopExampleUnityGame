using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class WaitWhile : FL_UnityEngine.CustomYieldInstruction {
		//public WaitWhile(System.Func<bool> predicate) { }
		public override bool keepWaiting => throw new NotImplementedException();
	}
}
