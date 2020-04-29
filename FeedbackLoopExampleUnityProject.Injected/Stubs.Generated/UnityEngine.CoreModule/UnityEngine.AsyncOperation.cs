using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AsyncOperation : FL_UnityEngine.YieldInstruction {
		//public AsyncOperation() { }
		public event System.Action<FL_UnityEngine.AsyncOperation> completed;
		public bool allowSceneActivation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool isDone => throw new NotImplementedException();
		public int priority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float progress => throw new NotImplementedException();
	}
}
