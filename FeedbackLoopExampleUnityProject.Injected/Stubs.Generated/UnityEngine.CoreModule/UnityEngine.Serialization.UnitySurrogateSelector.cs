using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Serialization
{
	public unsafe partial class UnitySurrogateSelector {
		//public UnitySurrogateSelector() { }
		public virtual void ChainSelector(System.Runtime.Serialization.ISurrogateSelector selector) => throw new NotImplementedException();
		public virtual System.Runtime.Serialization.ISurrogateSelector GetNextSelector() => throw new NotImplementedException();
		public virtual System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context, ref System.Runtime.Serialization.ISurrogateSelector selector) => throw new NotImplementedException();
	}
}
