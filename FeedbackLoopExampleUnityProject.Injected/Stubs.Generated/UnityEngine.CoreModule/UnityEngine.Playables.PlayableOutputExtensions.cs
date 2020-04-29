using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Playables
{
	public unsafe partial class PlayableOutputExtensions {
		public static void AddNotificationReceiver<U>(U output, UnityEngine.Playables.INotificationReceiver receiver) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static UnityEngine.Playables.INotificationReceiver[] GetNotificationReceivers<U>(U output) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static FL_UnityEngine.Object GetReferenceObject<U>(U output) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static int GetSourceOutputPort<U>(U output) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static UnityEngine.Playables.Playable GetSourcePlayable<U>(U output) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static FL_UnityEngine.Object GetUserData<U>(U output) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static float GetWeight<U>(U output) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static bool IsOutputNull<U>(U output) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static bool IsOutputValid<U>(U output) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static void PushNotification<U>(U output, UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, System.Object context) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static void RemoveNotificationReceiver<U>(U output, UnityEngine.Playables.INotificationReceiver receiver) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static void SetReferenceObject<U>(U output, FL_UnityEngine.Object value) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static void SetSourceOutputPort<U>(U output, int value) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static void SetSourcePlayable<U, V>(U output, V value) where U : struct,UnityEngine.Playables.IPlayableOutput where V : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetSourcePlayable<U, V>(U output, V value, int port) where U : struct,UnityEngine.Playables.IPlayableOutput where V : struct,UnityEngine.Playables.IPlayable => throw new NotImplementedException();
		public static void SetUserData<U>(U output, FL_UnityEngine.Object value) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
		public static void SetWeight<U>(U output, float value) where U : struct,UnityEngine.Playables.IPlayableOutput => throw new NotImplementedException();
	}
}
