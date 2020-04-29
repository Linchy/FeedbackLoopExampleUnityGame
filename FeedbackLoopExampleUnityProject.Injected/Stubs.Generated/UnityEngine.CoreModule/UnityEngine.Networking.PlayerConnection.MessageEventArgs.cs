using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Networking.PlayerConnection
{
	public unsafe partial class MessageEventArgs {
		//public MessageEventArgs() { }
		public byte[] data;
		public int playerId;
	}
}
