using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Input {
		//public Input() { }
		public static UnityEngine.AccelerationEvent GetAccelerationEvent(int index) => throw new NotImplementedException();
		public static float GetAxis(string axisName) => 0;
		public static float GetAxisRaw(string axisName) => 0;
		public static bool GetButton(string buttonName) => false;
		public static bool GetButtonDown(string buttonName) => false;
		public static bool GetButtonUp(string buttonName) => false;
		public static string[] GetJoystickNames() => throw new NotImplementedException();
		public static bool GetKey(UnityEngine.KeyCode key) => false;
		public static bool GetKey(string name) => false;
		public static bool GetKeyDown(UnityEngine.KeyCode key) => false;
		public static bool GetKeyDown(string name) => false;
		public static bool GetKeyUp(UnityEngine.KeyCode key) => false;
		public static bool GetKeyUp(string name) => false;
		public static bool GetMouseButton(int button) => false;
		public static bool GetMouseButtonDown(int button) => false;
		public static bool GetMouseButtonUp(int button) => false;
		public static UnityEngine.Touch GetTouch(int index) => throw new NotImplementedException();
		public static bool IsJoystickPreconfigured(string joystickName) => false;
		public static void ResetInputAxes() => throw new NotImplementedException();
		public static UnityEngine.Vector3 acceleration { get; }
		public static int accelerationEventCount { get; }
		public static UnityEngine.AccelerationEvent[] accelerationEvents { get; }
		public static bool anyKey { get; }
		public static bool anyKeyDown { get; }
		public static bool backButtonLeavesApp { get; set; }
		public static FL_UnityEngine.Compass compass { get; }
		public static bool compensateSensors { get; set; }
		public static UnityEngine.Vector2 compositionCursorPos { get; set; }
		public static string compositionString { get; }
		public static UnityEngine.DeviceOrientation deviceOrientation { get; }
		public static FL_UnityEngine.Gyroscope gyro { get; }
		public static UnityEngine.IMECompositionMode imeCompositionMode { get; set; }
		public static bool imeIsSelected { get; }
		public static string inputString { get; }
		public static FL_UnityEngine.LocationService location { get; }
		public static UnityEngine.Vector3 mousePosition { get; }
		public static bool mousePresent { get; }
		public static UnityEngine.Vector2 mouseScrollDelta { get; }
		public static bool multiTouchEnabled { get; set; }
		public static bool simulateMouseWithTouches { get; set; }
		public static bool stylusTouchSupported { get; }
		public static int touchCount { get; }
		public static UnityEngine.Touch[] touches { get; }
		public static bool touchPressureSupported { get; }
		public static bool touchSupported { get; }
	}
}
