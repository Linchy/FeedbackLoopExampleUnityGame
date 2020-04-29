using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Windows.Speech
{
	public unsafe partial class KeywordRecognizer : FL_UnityEngine.Windows.Speech.PhraseRecognizer {
		//public KeywordRecognizer(string[] keywords) { }
		//public KeywordRecognizer(string[] keywords, UnityEngine.Windows.Speech.ConfidenceLevel minimumConfidence) { }
		public System.Collections.Generic.IEnumerable<string> Keywords { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
