using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AndroidJavaObject {
		//public AndroidJavaObject(string className, System.Object[] args) { }
		public void Call(string methodName, System.Object[] args) => throw new NotImplementedException();
		public ReturnType Call<ReturnType>(string methodName, System.Object[] args) => throw new NotImplementedException();
		public void CallStatic(string methodName, System.Object[] args) => throw new NotImplementedException();
		public ReturnType CallStatic<ReturnType>(string methodName, System.Object[] args) => throw new NotImplementedException();
		public virtual void Dispose() => throw new NotImplementedException();
		public FieldType Get<FieldType>(string fieldName) => throw new NotImplementedException();
		public System.IntPtr GetRawClass() => throw new NotImplementedException();
		public System.IntPtr GetRawObject() => throw new NotImplementedException();
		public FieldType GetStatic<FieldType>(string fieldName) => throw new NotImplementedException();
		public void Set<FieldType>(string fieldName, FieldType val) => throw new NotImplementedException();
		public void SetStatic<FieldType>(string fieldName, FieldType val) => throw new NotImplementedException();
	}
}
