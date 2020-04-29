using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Windows.Speech
{
	public unsafe partial class DictationRecognizer {
		//public DictationRecognizer() { }
		//public DictationRecognizer(UnityEngine.Windows.Speech.ConfidenceLevel confidenceLevel) { }
		//public DictationRecognizer(UnityEngine.Windows.Speech.DictationTopicConstraint topic) { }
		//public DictationRecognizer(UnityEngine.Windows.Speech.ConfidenceLevel minimumConfidence, UnityEngine.Windows.Speech.DictationTopicConstraint topic) { }
		public event UnityEngine.Windows.Speech.DictationRecognizer.DictationCompletedDelegate DictationComplete;
		public event UnityEngine.Windows.Speech.DictationRecognizer.DictationErrorHandler DictationError;
		public event UnityEngine.Windows.Speech.DictationRecognizer.DictationHypothesisDelegate DictationHypothesis;
		public event UnityEngine.Windows.Speech.DictationRecognizer.DictationResultDelegate DictationResult;
		public virtual void Dispose() => throw new NotImplementedException();
		public void Start() => throw new NotImplementedException();
		public void Stop() => throw new NotImplementedException();
		public float AutoSilenceTimeoutSeconds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float InitialSilenceTimeoutSeconds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Windows.Speech.SpeechSystemStatus Status => throw new NotImplementedException();
	}
}
