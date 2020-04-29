using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class CustomYieldInstruction {
		public virtual bool MoveNext() => throw new NotImplementedException();
		public virtual void Reset() => throw new NotImplementedException();
		public virtual System.Object Current => throw new NotImplementedException();
		public virtual bool keepWaiting => throw new NotImplementedException();
	}
}
