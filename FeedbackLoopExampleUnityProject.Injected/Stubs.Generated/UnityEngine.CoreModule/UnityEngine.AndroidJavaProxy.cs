using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AndroidJavaProxy {
		//public AndroidJavaProxy(string javaInterface) { }
		//public AndroidJavaProxy(FL_UnityEngine.AndroidJavaClass javaInterface) { }
		public FL_UnityEngine.AndroidJavaClass javaInterface;
		public virtual bool equals(FL_UnityEngine.AndroidJavaObject obj) => throw new NotImplementedException();
		public virtual int hashCode() => throw new NotImplementedException();
		public virtual FL_UnityEngine.AndroidJavaObject Invoke(string methodName, System.Object[] args) => throw new NotImplementedException();
		public virtual FL_UnityEngine.AndroidJavaObject Invoke(string methodName, FL_UnityEngine.AndroidJavaObject[] javaArgs) => throw new NotImplementedException();
		public virtual string toString() => throw new NotImplementedException();
	}
}
