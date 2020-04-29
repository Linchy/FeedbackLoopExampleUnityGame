using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.iOS
{
	public unsafe partial class NotificationServices {
		//public NotificationServices() { }
		public static void CancelAllLocalNotifications() => throw new NotImplementedException();
		public static void CancelLocalNotification(FL_UnityEngine.iOS.LocalNotification notification) => throw new NotImplementedException();
		public static void ClearLocalNotifications() => throw new NotImplementedException();
		public static void ClearRemoteNotifications() => throw new NotImplementedException();
		public static FL_UnityEngine.iOS.LocalNotification GetLocalNotification(int index) => throw new NotImplementedException();
		public static FL_UnityEngine.iOS.RemoteNotification GetRemoteNotification(int index) => throw new NotImplementedException();
		public static void PresentLocalNotificationNow(FL_UnityEngine.iOS.LocalNotification notification) => throw new NotImplementedException();
		public static void RegisterForNotifications(UnityEngine.iOS.NotificationType notificationTypes) => throw new NotImplementedException();
		public static void RegisterForNotifications(UnityEngine.iOS.NotificationType notificationTypes, bool registerForRemote) => throw new NotImplementedException();
		public static void ScheduleLocalNotification(FL_UnityEngine.iOS.LocalNotification notification) => throw new NotImplementedException();
		public static void UnregisterForRemoteNotifications() => throw new NotImplementedException();
		public static byte[] deviceToken => throw new NotImplementedException();
		public static UnityEngine.iOS.NotificationType enabledNotificationTypes => throw new NotImplementedException();
		public static int localNotificationCount => throw new NotImplementedException();
		public static FL_UnityEngine.iOS.LocalNotification[] localNotifications => throw new NotImplementedException();
		public static string registrationError => throw new NotImplementedException();
		public static int remoteNotificationCount => throw new NotImplementedException();
		public static FL_UnityEngine.iOS.RemoteNotification[] remoteNotifications => throw new NotImplementedException();
		public static FL_UnityEngine.iOS.LocalNotification[] scheduledLocalNotifications => throw new NotImplementedException();
	}
}
