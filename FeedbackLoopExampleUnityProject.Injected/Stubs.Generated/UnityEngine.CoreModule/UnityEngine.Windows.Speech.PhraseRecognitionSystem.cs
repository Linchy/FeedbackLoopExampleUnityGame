using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Windows.Speech
{
	public unsafe partial class PhraseRecognitionSystem {
		public static event UnityEngine.Windows.Speech.PhraseRecognitionSystem.ErrorDelegate OnError;
		public static event UnityEngine.Windows.Speech.PhraseRecognitionSystem.StatusDelegate OnStatusChanged;
		public static void Restart() => throw new NotImplementedException();
		public static void Shutdown() => throw new NotImplementedException();
		public static bool isSupported => throw new NotImplementedException();
		public static UnityEngine.Windows.Speech.SpeechSystemStatus Status => throw new NotImplementedException();
	}
}
