using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Playables
{
	public unsafe partial class PlayableExtensions {
		public static int AddInput<U, V>(U playable, V sourcePlayable, int sourceOutputIndex, float weight) where U : struct,UnityEngine.Playables.IPlayable where V : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static bool CanChangeInputs<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static bool CanDestroy<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static bool CanSetWeights<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) where U : struct,UnityEngine.Playables.IPlayable where V : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) where U : struct,UnityEngine.Playables.IPlayable where V : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void Destroy<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void DisconnectInput<U>(U playable, int inputPort) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static double GetDelay<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static double GetDuration<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static UnityEngine.Playables.PlayableGraph GetGraph<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static UnityEngine.Playables.Playable GetInput<U>(U playable, int inputPort) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static int GetInputCount<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static float GetInputWeight<U>(U playable, int inputIndex) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static float GetLeadTime<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static UnityEngine.Playables.Playable GetOutput<U>(U playable, int outputPort) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static int GetOutputCount<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static UnityEngine.Playables.PlayState GetPlayState<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static double GetPreviousTime<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static bool GetPropagateSetTime<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static double GetSpeed<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static double GetTime<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static UnityEngine.Playables.PlayableTraversalMode GetTraversalMode<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static bool IsDelayed<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static bool IsDone<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static bool IsNull<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static bool IsValid<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void Pause<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void Play<U>(U playable) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetDelay<U>(U playable, double delay) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetDone<U>(U playable, bool value) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetDuration<U>(U playable, double value) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetInputCount<U>(U playable, int value) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetInputWeight<U>(U playable, int inputIndex, float weight) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetInputWeight<U, V>(U playable, V input, float weight) where U : struct,UnityEngine.Playables.IPlayable where V : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetLeadTime<U>(U playable, float value) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetOutputCount<U>(U playable, int value) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetPropagateSetTime<U>(U playable, bool value) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetSpeed<U>(U playable, double value) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetTime<U>(U playable, double value) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetTraversalMode<U>(U playable, UnityEngine.Playables.PlayableTraversalMode mode) where U : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
	}
}
