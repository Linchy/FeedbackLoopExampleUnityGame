using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Profiling
{
	public unsafe partial class Recorder {
		public void CollectFromAllThreads() => throw new NotImplementedException();
		public void FilterToCurrentThread() => throw new NotImplementedException();
		public static FL_UnityEngine.Profiling.Recorder Get(string samplerName) => throw new NotImplementedException();
		public long elapsedNanoseconds => throw new NotImplementedException();
		public bool enabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool isValid => throw new NotImplementedException();
		public int sampleBlockCount => throw new NotImplementedException();
	}
}
