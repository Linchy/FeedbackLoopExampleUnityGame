using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class WaitForSecondsRealtime : FL_UnityEngine.CustomYieldInstruction {
		//public WaitForSecondsRealtime(float time) { }
		public override bool keepWaiting => throw new NotImplementedException();
		public float waitTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
