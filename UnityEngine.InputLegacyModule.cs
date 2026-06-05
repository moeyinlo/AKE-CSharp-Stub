/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;

// Image 110: UnityEngine.InputLegacyModule.dll - Assembly: UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60870-60883

namespace UnityEngine
{
	public enum TouchPhase // TypeDefIndex: 60871
	{
		Began = 0,
		Moved = 1,
		Stationary = 2,
		Ended = 3,
		Canceled = 4
	}

	public enum IMECompositionMode // TypeDefIndex: 60872
	{
		Auto = 0,
		On = 1,
		Off = 2
	}

	public enum TouchType // TypeDefIndex: 60873
	{
		Direct = 0,
		Indirect = 1,
		Stylus = 2
	}

	public struct Touch // TypeDefIndex: 60874
	{
		// Fields
		private int m_FingerId; // 0x00
		private Vector2 m_Position; // 0x04
		private Vector2 m_RawPosition; // 0x0C
		private Vector2 m_PositionDelta; // 0x14
		private float m_TimeDelta; // 0x1C
		private int m_TapCount; // 0x20
		private TouchPhase m_Phase; // 0x24
		private TouchType m_Type; // 0x28
		private float m_Pressure; // 0x2C
		private float m_maximumPossiblePressure; // 0x30
		private float m_Radius; // 0x34
		private float m_RadiusVariance; // 0x38
		private float m_AltitudeAngle; // 0x3C
		private float m_AzimuthAngle; // 0x40
	
		// Properties
		public int fingerId { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public Vector2 position { get => default; set {} } // 0x0000000185FE8D00-0x0000000185FE8D20 0x0000000185FB6E10-0x0000000185FB6E20
		public Vector2 rawPosition { get => default; set {} } // 0x0000000185FE8D30-0x0000000185FE8D50 0x0000000185FE8D60-0x0000000185FE8D70
		public Vector2 deltaPosition { get => default; set {} } // 0x0000000185FC3450-0x0000000185FC3470 0x0000000185FE8D50-0x0000000185FE8D60
		public float deltaTime { get => default; } // 0x0000000185FE8CF0-0x0000000185FE8D00 
		public int tapCount { get => default; } // 0x0000000185FE7AF0-0x0000000185FE7B00 
		public TouchPhase phase { get => default; } // 0x0000000185FE6730-0x0000000185FE6740 
		public float pressure { get => default; } // 0x0000000185FE8D20-0x0000000185FE8D30 
		public float maximumPossiblePressure { get => default; } // 0x0000000185FE5830-0x0000000185FE5840 
		public TouchType type { get => default; } // 0x0000000185FE7B60-0x0000000185FE7B70 
		public float altitudeAngle { get => default; } // 0x000000018646D240-0x000000018646D248 
		public float azimuthAngle { get => default; } // 0x000000018646D1F0-0x000000018646D200 
		public float radius { get => default; } // 0x0000000186472350-0x0000000186472358 
		public float radiusVariance { get => default; } // 0x000000018646D1E0-0x000000018646D1F0 
	}

	public enum DeviceOrientation // TypeDefIndex: 60875
	{
		Unknown = 0,
		Portrait = 1,
		PortraitUpsideDown = 2,
		LandscapeLeft = 3,
		LandscapeRight = 4,
		FaceUp = 5,
		FaceDown = 6
	}

	public struct AccelerationEvent // TypeDefIndex: 60876
	{
		// Fields
		internal float x; // 0x00
		internal float y; // 0x04
		internal float z; // 0x08
		internal float m_TimeDelta; // 0x0C
	}

	public class Gyroscope // TypeDefIndex: 60877
	{
		// Fields
		private int m_GyroIndex; // 0x10
	
		// Constructors
		public Gyroscope() {} // Dummy constructor
		internal Gyroscope(int index) {} // 0x0000000181378230-0x0000000181378240
	}

	public class LocationService // TypeDefIndex: 60878
	{
		// Constructors
		public LocationService() {} // 0x0000000185492010-0x0000000185492020
	}

	public class Compass // TypeDefIndex: 60879
	{
		// Constructors
		public Compass() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraRaycastHelper // TypeDefIndex: 60880
	{
		// Constructors
		public CameraRaycastHelper() {} // Dummy constructor
	
		// Methods
		internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) => default; // 0x000000018646E57C-0x000000018646E594
		internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) => default; // 0x000000018646E594-0x000000018646E5AC
		private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) => default; // 0x0000000184F09BC0-0x0000000184F09C30
		private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) => default; // 0x0000000184F09C30-0x0000000184F09CA0
	}

	public class Input // TypeDefIndex: 60881
	{
		// Fields
		private static LocationService locationServiceInstance; // 0x00
		private static Compass compassInstance; // 0x08
		private static Gyroscope s_MainGyro; // 0x10
	
		// Properties
		public static bool simulateMouseWithTouches { get => default; set {} } // 0x000000018BF2C794-0x000000018BF2C7C0 0x0000000185DAF390-0x0000000185DAF3D0
		public static bool anyKey { get => default; } // 0x000000018BF2C3A8-0x000000018BF2C3D4 
		public static bool anyKeyDown { get => default; } // 0x0000000185292A00-0x0000000185292A40 
		public static string inputString { get => default; } // 0x000000018BF2C67C-0x000000018BF2C6A8 
		public static Vector3 mousePosition { get => default; } // 0x00000001842AC5E0-0x00000001842AC630 
		public static Vector2 mouseScrollDelta { get => default; } // 0x00000001842AAFC0-0x00000001842AB010 
		public static IMECompositionMode imeCompositionMode { get => default; set {} } // 0x000000018BF2C624-0x000000018BF2C650 0x0000000185FA7400-0x0000000185FA7440
		public static string compositionString { get => default; } // 0x00000001857D81D0-0x00000001857D8210 
		public static bool imeIsSelected { get => default; } // 0x000000018BF2C650-0x000000018BF2C67C 
		public static Vector2 compositionCursorPos { get => default; set {} } // 0x000000018BF2C4FC-0x000000018BF2C520 0x000000018BF2C8AC-0x000000018BF2C8C8
		public static bool eatKeyPressOnTextFieldFocus { get => default; set {} } // 0x000000018BF2C54C-0x000000018BF2C578 0x000000018BF2C8C8-0x000000018BF2C8FC
		public static bool mousePresent { get => default; } // 0x00000001842A9F20-0x00000001842AAFB0 
		public static int touchCount { get => default; } // 0x000000018457C9E0-0x000000018457CA20 
		public static bool touchPressureSupported { get => default; } // 0x000000018BF2C7EC-0x000000018BF2C818 
		public static bool stylusTouchSupported { get => default; } // 0x000000018BF2C7C0-0x000000018BF2C7EC 
		public static bool touchSupported { get => default; } // 0x000000018BF2C818-0x000000018BF2C844 
		public static bool multiTouchEnabled { get => default; set {} } // 0x000000018BF2C768-0x000000018BF2C794 0x0000000185DAF440-0x0000000185DAF480
		public static bool isGyroAvailable { get => default; } // 0x000000018BF2C6A8-0x000000018BF2C6D4 
		public static DeviceOrientation deviceOrientation { get => default; } // 0x000000018BF2C520-0x000000018BF2C54C 
		public static Vector3 acceleration { get => default; } // 0x000000018BF2C384-0x000000018BF2C3A8 
		public static bool compensateSensors { get => default; set {} } // 0x000000018BF2C49C-0x000000018BF2C4C8 0x000000018BF2C878-0x000000018BF2C8AC
		public static int accelerationEventCount { get => default; } // 0x000000018BF2C288-0x000000018BF2C2B4 
		public static bool backButtonLeavesApp { get => default; set {} } // 0x000000018BF2C3D4-0x000000018BF2C400 0x000000018BF2C844-0x000000018BF2C878
		public static LocationService location { get => default; } // 0x000000018BF2C6D4-0x000000018BF2C768 
		public static Compass compass { get => default; } // 0x000000018BF2C400-0x000000018BF2C49C 
		public static Gyroscope gyro { get => default; } // 0x000000018BF2C578-0x000000018BF2C624 
		public static Touch[] touches { get => default; } // 0x0000000184B48B30-0x0000000184B48BA0 
		public static AccelerationEvent[] accelerationEvents { get => default; } // 0x000000018BF2C2B4-0x000000018BF2C350 
	
		// Constructors
		public Input() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static bool GetKeyInt(KeyCode key) => default; // 0x0000000184D32760-0x0000000184D327A0
		private static bool GetKeyString(string name) => default; // 0x000000018BF2C10C-0x000000018BF2C140
		private static bool GetKeyUpInt(KeyCode key) => default; // 0x0000000184DCDE50-0x0000000184DCDF10
		private static bool GetKeyUpString(string name) => default; // 0x000000018BF2C140-0x000000018BF2C174
		private static bool GetKeyDownInt(KeyCode key) => default; // 0x0000000184CEFE80-0x0000000184CEFEC0
		private static bool GetKeyDownString(string name) => default; // 0x000000018BF2C0CC-0x000000018BF2C100
		public static float GetAxis(string axisName) => default; // 0x000000018BF2BFD8-0x000000018BF2C00C
		public static float GetAxisRaw(string axisName) => default; // 0x00000001842ABAD0-0x00000001842ABB10
		public static bool GetButton(string buttonName) => default; // 0x00000001842AB9B0-0x00000001842AB9F0
		public static bool GetButtonDown(string buttonName) => default; // 0x000000018BF2C00C-0x000000018BF2C040
		public static bool GetButtonUp(string buttonName) => default; // 0x000000018BF2C040-0x000000018BF2C074
		public static bool GetMouseButton(int button) => default; // 0x000000018457E950-0x000000018457E990
		public static bool GetMouseButtonDown(int button) => default; // 0x00000001842AC6B0-0x00000001842AC6F0
		public static bool GetMouseButtonUp(int button) => default; // 0x0000000184EC1060-0x0000000184EC10A0
		public static void ResetInputAxes() {} // 0x000000018BF2C204-0x000000018BF2C230
		public static string[] GetJoystickNames() => default; // 0x000000018BF2C0A0-0x000000018BF2C0CC
		public static Touch GetTouch(int index) => default; // 0x000000018BF2C1CC-0x000000018BF2C204
		public static AccelerationEvent GetAccelerationEvent(int index) => default; // 0x000000018BF2BFB0-0x000000018BF2BFD8
		public static bool GetKey(KeyCode key) => default; // 0x000000018646E7D8-0x000000018646E7E4
		public static bool GetKey(string name) => default; // 0x000000018BF2C180-0x000000018BF2C18C
		public static bool GetKeyUp(KeyCode key) => default; // 0x000000018646E7F0-0x000000018646E7FC
		public static bool GetKeyUp(string name) => default; // 0x000000018BF2C174-0x000000018BF2C180
		public static bool GetKeyDown(KeyCode key) => default; // 0x000000018646E7E4-0x000000018646E7F0
		public static bool GetKeyDown(string name) => default; // 0x000000018BF2C100-0x000000018BF2C10C
		internal static void SimulateTouch(Touch touch) {} // 0x0000000185492010-0x0000000185492020
		private static void SimulateTouchInternal(Touch touch, long timestamp) {} // 0x000000018BF2C274-0x000000018BF2C288
		private static int GetGyroInternal() => default; // 0x000000018BF2C074-0x000000018BF2C0A0
		internal static bool CheckDisabled() => default; // 0x00000001842AC670-0x00000001842AC6B0
		private static void GetTouch_Injected(int index, out Touch ret) {
			ret = default;
		} // 0x000000018BF2C18C-0x000000018BF2C1CC
		private static void GetAccelerationEvent_Injected(int index, out AccelerationEvent ret) {
			ret = default;
		} // 0x000000018BF2BF70-0x000000018BF2BFB0
		private static void SimulateTouchInternal_Injected(ref Touch touch, long timestamp) {} // 0x000000018BF2C230-0x000000018BF2C274
		private static void get_mousePosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001842AC630-0x00000001842AC670
		private static void get_mouseScrollDelta_Injected(out Vector2 ret) {
			ret = default;
		} // 0x00000001842AB010-0x00000001842AB050
		private static void get_compositionCursorPos_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF2C4C8-0x000000018BF2C4FC
		private static void set_compositionCursorPos_Injected(ref Vector2 value) {} // 0x0000000185F7A5D0-0x0000000185F7A610
		private static void get_acceleration_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF2C350-0x000000018BF2C384
	}

	internal class SendMouseEvents // TypeDefIndex: 60883
	{
		// Fields
		private static bool s_MouseUsed; // 0x00
		private static readonly HitInfo[] m_LastHit; // 0x08
		private static readonly HitInfo[] m_MouseDownHit; // 0x10
		private static readonly HitInfo[] m_CurrentHit; // 0x18
		private static Camera[] m_Cameras; // 0x20
		public static Func<KeyValuePair<int, Vector2>> s_GetMouseState; // 0x28
		private static Vector2 s_MousePosition; // 0x30
		private static bool s_MouseButtonPressedThisFrame; // 0x38
		private static bool s_MouseButtonIsPressed; // 0x39
	
		// Nested types
		private struct HitInfo // TypeDefIndex: 60882
		{
			// Fields
			public GameObject target; // 0x00
			public Camera camera; // 0x08
	
			// Methods
			public void SendMessage(string name) {} // 0x00000001842AC450-0x00000001842AC5E0
			public static implicit operator bool(HitInfo exists) => default; // 0x000000018BF2C8FC-0x000000018BF2C94C
			public static bool Compare(HitInfo lhs, HitInfo rhs) => default; // 0x00000001842ADE30-0x00000001842AEE00
		}
	
		// Constructors
		public SendMouseEvents() {} // Dummy constructor
		static SendMouseEvents() {} // 0x00000001842AF990-0x00000001842AFC20
	
		// Methods
		private static void UpdateMouse() {} // 0x00000001842AEEC0-0x00000001842AF860
		private static void SetMouseMoved() {} // 0x0000000185EC2BD0-0x0000000185EC2CC0
		private static void DoSendMouseEvents(int skipRTCameras) {} // 0x0000000185781940-0x0000000185781970
		private static void SendEvents(int i, HitInfo hit) {} // 0x00000001842AF860-0x00000001842AF990
	}
}
