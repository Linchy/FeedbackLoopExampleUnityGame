using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Application {
		//public Application() { }
		public static event System.Action<bool> focusChanged;
		public static event UnityEngine.Application.LogCallback logMessageReceived;
		public static event UnityEngine.Application.LogCallback logMessageReceivedThreaded;
		public static event UnityEngine.Application.LowMemoryCallback lowMemory;
		public static event UnityEngine.Events.UnityAction onBeforeRender;
		public static event System.Action quitting;
		public static event System.Func<bool> wantsToQuit;
		public static bool CanStreamedLevelBeLoaded(int levelIndex) => throw new NotImplementedException();
		public static bool CanStreamedLevelBeLoaded(string levelName) => throw new NotImplementedException();
		public static string[] GetBuildTags() => throw new NotImplementedException();
		public static UnityEngine.StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType) => throw new NotImplementedException();
		public static bool HasProLicense() => throw new NotImplementedException();
		public static bool HasUserAuthorization(UnityEngine.UserAuthorization mode) => throw new NotImplementedException();
		public static bool IsPlaying(FL_UnityEngine.Object obj) => throw new NotImplementedException();
		public static void OpenURL(string url) => throw new NotImplementedException();
		public static void Quit(int exitCode) => throw new NotImplementedException();
		public static void Quit() => throw new NotImplementedException();
		public static bool RequestAdvertisingIdentifierAsync(UnityEngine.Application.AdvertisingIdentifierCallback delegateMethod) => throw new NotImplementedException();
		public static FL_UnityEngine.AsyncOperation RequestUserAuthorization(UnityEngine.UserAuthorization mode) => throw new NotImplementedException();
		public static void SetBuildTags(string[] buildTags) => throw new NotImplementedException();
		public static void SetStackTraceLogType(UnityEngine.LogType logType, UnityEngine.StackTraceLogType stackTraceType) => throw new NotImplementedException();
		public static void Unload() => throw new NotImplementedException();
		public static string absoluteURL => throw new NotImplementedException();
		public static UnityEngine.ThreadPriority backgroundLoadingPriority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static string buildGUID => throw new NotImplementedException();
		public static string cloudProjectId => throw new NotImplementedException();
		public static string companyName => throw new NotImplementedException();
		public static string consoleLogPath => throw new NotImplementedException();
		public static string dataPath => throw new NotImplementedException();
		public static bool genuine => throw new NotImplementedException();
		public static bool genuineCheckAvailable => throw new NotImplementedException();
		public static string identifier => throw new NotImplementedException();
		public static string installerName => throw new NotImplementedException();
		public static UnityEngine.ApplicationInstallMode installMode => throw new NotImplementedException();
		public static UnityEngine.NetworkReachability internetReachability => throw new NotImplementedException();
		public static bool isBatchMode => throw new NotImplementedException();
		public static bool isConsolePlatform => throw new NotImplementedException();
		public static bool isEditor => throw new NotImplementedException();
		public static bool isFocused => throw new NotImplementedException();
		public static bool isMobilePlatform => throw new NotImplementedException();
		public static bool isPlaying => throw new NotImplementedException();
		public static string persistentDataPath => throw new NotImplementedException();
		public static UnityEngine.RuntimePlatform platform => throw new NotImplementedException();
		public static string productName => throw new NotImplementedException();
		public static bool runInBackground { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static UnityEngine.ApplicationSandboxType sandboxType => throw new NotImplementedException();
		public static string streamingAssetsPath => throw new NotImplementedException();
		public static UnityEngine.SystemLanguage systemLanguage => throw new NotImplementedException();
		public static int targetFrameRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static string temporaryCachePath => throw new NotImplementedException();
		public static string unityVersion => throw new NotImplementedException();
		public static string version => throw new NotImplementedException();
	}
}
