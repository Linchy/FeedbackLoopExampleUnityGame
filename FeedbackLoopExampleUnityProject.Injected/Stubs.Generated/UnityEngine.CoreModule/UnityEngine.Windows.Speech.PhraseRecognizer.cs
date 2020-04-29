using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Windows.Speech
{
	public unsafe partial class PhraseRecognizer {
		public event UnityEngine.Windows.Speech.PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized;
		public virtual void Dispose() => throw new NotImplementedException();
		public void Start() => throw new NotImplementedException();
		public void Stop() => throw new NotImplementedException();
		public bool IsRunning => throw new NotImplementedException();
	}
}
