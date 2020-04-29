using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Logger {
		//public Logger(UnityEngine.ILogHandler logHandler) { }
		public virtual bool IsLogTypeAllowed(UnityEngine.LogType logType) => throw new NotImplementedException();
		public virtual void Log(UnityEngine.LogType logType, System.Object message) => throw new NotImplementedException();
		public virtual void Log(UnityEngine.LogType logType, System.Object message, FL_UnityEngine.Object context) => throw new NotImplementedException();
		public virtual void Log(UnityEngine.LogType logType, string tag, System.Object message) => throw new NotImplementedException();
		public virtual void Log(UnityEngine.LogType logType, string tag, System.Object message, FL_UnityEngine.Object context) => throw new NotImplementedException();
		public virtual void Log(System.Object message) => throw new NotImplementedException();
		public virtual void Log(string tag, System.Object message) => throw new NotImplementedException();
		public virtual void Log(string tag, System.Object message, FL_UnityEngine.Object context) => throw new NotImplementedException();
		public virtual void LogError(string tag, System.Object message) => throw new NotImplementedException();
		public virtual void LogError(string tag, System.Object message, FL_UnityEngine.Object context) => throw new NotImplementedException();
		public virtual void LogException(System.Exception exception) => throw new NotImplementedException();
		public virtual void LogException(System.Exception exception, FL_UnityEngine.Object context) => throw new NotImplementedException();
		public virtual void LogFormat(UnityEngine.LogType logType, string format, System.Object[] args) => throw new NotImplementedException();
		public virtual void LogFormat(UnityEngine.LogType logType, FL_UnityEngine.Object context, string format, System.Object[] args) => throw new NotImplementedException();
		public virtual void LogWarning(string tag, System.Object message) => throw new NotImplementedException();
		public virtual void LogWarning(string tag, System.Object message, FL_UnityEngine.Object context) => throw new NotImplementedException();
		public virtual UnityEngine.LogType filterLogType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual bool logEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual UnityEngine.ILogHandler logHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
