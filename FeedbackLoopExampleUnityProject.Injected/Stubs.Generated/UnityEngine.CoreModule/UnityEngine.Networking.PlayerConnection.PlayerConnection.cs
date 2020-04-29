using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Networking.PlayerConnection
{
	public unsafe partial class PlayerConnection : FL_UnityEngine.ScriptableObject {
		//public PlayerConnection() { }
		public bool BlockUntilRecvMsg(System.Guid messageId, int timeout) => throw new NotImplementedException();
		public virtual void DisconnectAll() => throw new NotImplementedException();
		public void OnEnable() => throw new NotImplementedException();
		public virtual void Register(System.Guid messageId, UnityEngine.Events.UnityAction<FL_UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) => throw new NotImplementedException();
		public virtual void RegisterConnection(UnityEngine.Events.UnityAction<int> callback) => throw new NotImplementedException();
		public virtual void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback) => throw new NotImplementedException();
		public virtual void Send(System.Guid messageId, byte[] data) => throw new NotImplementedException();
		public virtual bool TrySend(System.Guid messageId, byte[] data) => throw new NotImplementedException();
		public virtual void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<FL_UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) => throw new NotImplementedException();
		public static FL_UnityEngine.Networking.PlayerConnection.PlayerConnection instance => throw new NotImplementedException();
		public bool isConnected => throw new NotImplementedException();
	}
}
