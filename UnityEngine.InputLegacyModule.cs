/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 110: UnityEngine.InputLegacyModule.dll - Assembly: UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90808-90821

namespace UnityEngine
{
	public enum TouchPhase // TypeDefIndex: 90809
	{
		Began = 0,
		Moved = 1,
		Stationary = 2,
		Ended = 3,
		Canceled = 4
	}

	public enum IMECompositionMode // TypeDefIndex: 90810
	{
		Auto = 0,
		On = 1,
		Off = 2
	}

	public enum TouchType // TypeDefIndex: 90811
	{
		Direct = 0,
		Indirect = 1,
		Stylus = 2
	}

	[NativeHeader("Runtime/Input/InputBindings.h")]
	public struct Touch // TypeDefIndex: 90812
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
		public int fingerId { get; } // 0x000000018725FD00-0x000000018725FD10 
		public Vector2 position { get; set; } // 0x0000000187262060-0x0000000187262080 0x0000000187239E00-0x0000000187239E10
		public Vector2 rawPosition { get; set; } // 0x0000000187262090-0x00000001872620B0 0x00000001872620C0-0x00000001872620D0
		public Vector2 deltaPosition { get; set; } // 0x00000001872445F0-0x0000000187244610 0x00000001872620B0-0x00000001872620C0
		public float deltaTime { get; } // 0x0000000187262050-0x0000000187262060 
		public int tapCount { get; } // 0x0000000187261360-0x0000000187261370 
		public TouchPhase phase { get; } // 0x000000018725FF50-0x000000018725FF60 
		public float pressure { get; } // 0x0000000187262080-0x0000000187262090 
		public float maximumPossiblePressure { get; } // 0x000000018725EFA0-0x000000018725EFB0 
		public TouchType type { get; } // 0x00000001872613C0-0x00000001872613D0 
		public float altitudeAngle { get; } // 0x0000000187837310-0x0000000187837318 
		public float azimuthAngle { get; } // 0x0000000187837380-0x0000000187837390 
		public float radius { get; } // 0x000000018783AB70-0x000000018783AB78 
		public float radiusVariance { get; } // 0x0000000187837390-0x0000000187837398 
	}

	public enum DeviceOrientation // TypeDefIndex: 90813
	{
		Unknown = 0,
		Portrait = 1,
		PortraitUpsideDown = 2,
		LandscapeLeft = 3,
		LandscapeRight = 4,
		FaceUp = 5,
		FaceDown = 6
	}

	public struct AccelerationEvent // TypeDefIndex: 90814
	{
		// Fields
		internal float x; // 0x00
		internal float y; // 0x04
		internal float z; // 0x08
		internal float m_TimeDelta; // 0x0C
	}

	[NativeHeader("Runtime/Input/GetInput.h")]
	public class Gyroscope // TypeDefIndex: 90815
	{
		// Fields
		private int m_GyroIndex; // 0x10
	
		// Properties
		public bool enabled { set; } // 0x0000000184F705C0-0x0000000184F729C0
	
		// Constructors
		internal Gyroscope(int index); // 0x0000000182234E90-0x0000000182234EA0
	
		// Methods
		[FreeFunction("SetGyroEnabled")]
		private static void setEnabled_Internal(int idx, bool enabled); // 0x0000000184F70560-0x0000000184F705C0
	}

	[NativeHeader("Runtime/Input/InputBindings.h")]
	[NativeHeader("Runtime/Input/LocationService.h")]
	public class LocationService // TypeDefIndex: 90816
	{
		// Constructors
		public LocationService(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class Compass // TypeDefIndex: 90817
	{
		// Constructors
		public Compass(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[NativeHeader("Runtime/Camera/Camera.h")]
	internal class CameraRaycastHelper // TypeDefIndex: 90818
	{
		// Methods
		[FreeFunction("CameraScripting::RaycastTry")]
		internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask); // 0x0000000187836744-0x000000018783675C
		[FreeFunction("CameraScripting::RaycastTry2D")]
		internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask); // 0x000000018783675C-0x0000000187836774
		private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask); // 0x000000018606D2F0-0x000000018606D360
		private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask); // 0x000000018606D360-0x000000018606D3D0
	}

	[NativeHeader("Runtime/Input/InputBindings.h")]
	public class Input // TypeDefIndex: 90819
	{
		// Fields
		private static LocationService locationServiceInstance; // 0x00
		private static Compass compassInstance; // 0x08
		private static Gyroscope s_MainGyro; // 0x10
	
		// Properties
		public static bool simulateMouseWithTouches { get; set; } // 0x000000018D5429BC-0x000000018D5429E8 0x0000000187066B20-0x0000000187066B60
		[NativeThrows]
		public static bool anyKey { get; } // 0x000000018D5425D0-0x000000018D5425FC 
		[NativeThrows]
		public static bool anyKeyDown { get; } // 0x00000001856F6C90-0x00000001856F6CD0 
		[NativeThrows]
		public static string inputString { get; } // 0x000000018D5428A4-0x000000018D5428D0 
		[NativeThrows]
		public static Vector3 mousePosition { get; } // 0x00000001856F8AD0-0x00000001856F8B20 
		[NativeThrows]
		public static Vector2 mouseScrollDelta { get; } // 0x00000001851D1BA0-0x00000001851D1BF0 
		public static IMECompositionMode imeCompositionMode { get; set; } // 0x000000018D54284C-0x000000018D542878 0x000000018716D630-0x000000018716D670
		public static string compositionString { get; } // 0x00000001867E3880-0x00000001867E38C0 
		public static bool imeIsSelected { get; } // 0x000000018D542878-0x000000018D5428A4 
		public static Vector2 compositionCursorPos { get; set; } // 0x000000018D542724-0x000000018D542748 0x000000018D542B8C-0x000000018D542BA8
		[Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
		public static bool eatKeyPressOnTextFieldFocus { get; set; } // 0x000000018D542774-0x000000018D5427A0 0x000000018D542BA8-0x000000018D542BDC
		public static bool mousePresent { [FreeFunction("GetMousePresent")] get; } // 0x00000001856F77B0-0x00000001856F77F0 
		public static int touchCount { [FreeFunction("GetTouchCount")] get; } // 0x0000000185F2D940-0x0000000185F2D980 
		public static bool touchPressureSupported { [FreeFunction("IsTouchPressureSupported")] get; } // 0x000000018D542A14-0x000000018D542A40 
		public static bool stylusTouchSupported { [FreeFunction("IsStylusTouchSupported")] get; } // 0x000000018D5429E8-0x000000018D542A14 
		public static bool touchSupported { [FreeFunction("IsTouchSupported")] get; } // 0x000000018D542A40-0x000000018D542A6C 
		public static bool multiTouchEnabled { [FreeFunction("IsMultiTouchEnabled")] get; [FreeFunction("SetMultiTouchEnabled")] set; } // 0x000000018D542990-0x000000018D5429BC 0x0000000187066BD0-0x0000000187066C10
		[Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
		public static bool isGyroAvailable { [FreeFunction("IsGyroAvailable")] get; } // 0x000000018D5428D0-0x000000018D5428FC 
		public static DeviceOrientation deviceOrientation { [FreeFunction("GetOrientation")] get; } // 0x000000018D542748-0x000000018D542774 
		public static Vector3 acceleration { [FreeFunction("GetAcceleration")] get; } // 0x000000018D5425AC-0x000000018D5425D0 
		public static bool compensateSensors { [FreeFunction("IsCompensatingSensors")] get; [FreeFunction("SetCompensatingSensors")] set; } // 0x000000018D5426C4-0x000000018D5426F0 0x000000018D542B58-0x000000018D542B8C
		public static int accelerationEventCount { [FreeFunction("GetAccelerationCount")] get; } // 0x000000018D542494-0x000000018D5424C0 
		public static bool backButtonLeavesApp { [FreeFunction("GetBackButtonLeavesApp")] get; [FreeFunction("SetBackButtonLeavesApp")] set; } // 0x000000018D5425FC-0x000000018D542628 0x000000018D542B24-0x000000018D542B58
		public static LocationService location { get; } // 0x000000018D5428FC-0x000000018D542990 
		public static Compass compass { get; } // 0x000000018D542628-0x000000018D5426C4 
		public static Gyroscope gyro { get; } // 0x000000018D5427A0-0x000000018D54284C 
		public static Touch[] touches { get; } // 0x000000018D542A6C-0x000000018D542B24 
		public static AccelerationEvent[] accelerationEvents { get; } // 0x000000018D5424C0-0x000000018D542578 
	
		// Constructors
		public Input(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[NativeThrows]
		private static bool GetKeyInt(KeyCode key); // 0x0000000185FEC920-0x0000000185FEC960
		[NativeThrows]
		private static bool GetKeyString(string name); // 0x000000018D542318-0x000000018D54234C
		[NativeThrows]
		private static bool GetKeyUpInt(KeyCode key); // 0x000000018601BDD0-0x000000018601BE10
		[NativeThrows]
		private static bool GetKeyUpString(string name); // 0x000000018D54234C-0x000000018D542380
		[NativeThrows]
		private static bool GetKeyDownInt(KeyCode key); // 0x0000000185EC6F10-0x0000000185EC6F50
		[NativeThrows]
		private static bool GetKeyDownString(string name); // 0x000000018D5422D8-0x000000018D54230C
		[NativeThrows]
		public static float GetAxis(string axisName); // 0x000000018D5421E4-0x000000018D542218
		[NativeThrows]
		public static float GetAxisRaw(string axisName); // 0x00000001856F8540-0x00000001856F8580
		[NativeThrows]
		public static bool GetButton(string buttonName); // 0x00000001856F8420-0x00000001856F8460
		[NativeThrows]
		public static bool GetButtonDown(string buttonName); // 0x000000018D542218-0x000000018D54224C
		[NativeThrows]
		public static bool GetButtonUp(string buttonName); // 0x000000018D54224C-0x000000018D542280
		[NativeThrows]
		public static bool GetMouseButton(int button); // 0x00000001853AB230-0x00000001853AB270
		[NativeThrows]
		public static bool GetMouseButtonDown(int button); // 0x00000001856F8BA0-0x00000001856F8BE0
		[NativeThrows]
		public static bool GetMouseButtonUp(int button); // 0x0000000185E58140-0x0000000185E58180
		[FreeFunction("ResetInput")]
		public static void ResetInputAxes(); // 0x000000018D542410-0x000000018D54243C
		[NativeThrows]
		public static string[] GetJoystickNames(); // 0x000000018D5422AC-0x000000018D5422D8
		[NativeThrows]
		public static Touch GetTouch(int index); // 0x000000018D5423D8-0x000000018D542410
		[NativeThrows]
		public static AccelerationEvent GetAccelerationEvent(int index); // 0x000000018D5421BC-0x000000018D5421E4
		public static bool GetKey(KeyCode key); // 0x0000000187835054-0x0000000187835060
		public static bool GetKey(string name); // 0x000000018D54238C-0x000000018D542398
		public static bool GetKeyUp(KeyCode key); // 0x0000000187835060-0x000000018783506C
		public static bool GetKeyUp(string name); // 0x000000018D542380-0x000000018D54238C
		public static bool GetKeyDown(KeyCode key); // 0x000000018783506C-0x0000000187835078
		public static bool GetKeyDown(string name); // 0x000000018D54230C-0x000000018D542318
		[Conditional("UNITY_EDITOR")]
		internal static void SimulateTouch(Touch touch); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		[FreeFunction("SimulateTouch")]
		[NativeConditional("UNITY_EDITOR")]
		private static void SimulateTouchInternal(Touch touch, long timestamp); // 0x000000018D542480-0x000000018D542494
		[FreeFunction("GetGyro")]
		private static int GetGyroInternal(); // 0x000000018D542280-0x000000018D5422AC
		internal static bool CheckDisabled(); // 0x00000001856F8B60-0x00000001856F8BA0
		private static void GetTouch_Injected(int index, out Touch ret); // 0x000000018D542398-0x000000018D5423D8
		private static void GetAccelerationEvent_Injected(int index, out AccelerationEvent ret); // 0x000000018D54217C-0x000000018D5421BC
		private static void SimulateTouchInternal_Injected(ref Touch touch, long timestamp); // 0x000000018D54243C-0x000000018D542480
		private static void get_mousePosition_Injected(out Vector3 ret); // 0x00000001856F8B20-0x00000001856F8B60
		private static void get_mouseScrollDelta_Injected(out Vector2 ret); // 0x00000001851D1BF0-0x00000001851D1C30
		private static void get_compositionCursorPos_Injected(out Vector2 ret); // 0x000000018D5426F0-0x000000018D542724
		private static void set_compositionCursorPos_Injected(ref Vector2 value); // 0x000000018702CB90-0x000000018702CBD0
		private static void get_acceleration_Injected(out Vector3 ret); // 0x000000018D542578-0x000000018D5425AC
	}

	internal class SendMouseEvents // TypeDefIndex: 90821
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
		private struct HitInfo // TypeDefIndex: 90820
		{
			// Fields
			public GameObject target; // 0x00
			public Camera camera; // 0x08
	
			// Methods
			public void SendMessage(string name); // 0x000000018643DA00-0x000000018643DA30
			public static implicit operator bool(HitInfo exists); // 0x0000000185511820-0x0000000185511900
			public static bool Compare(HitInfo lhs, HitInfo rhs); // 0x0000000185511900-0x0000000185511AB0
		}
	
		// Constructors
		static SendMouseEvents(); // 0x00000001870A1FB0-0x00000001870A20A0
	
		// Methods
		private static void UpdateMouse(); // 0x00000001856F8580-0x00000001856F86E0
		[RequiredByNativeCode]
		private static void SetMouseMoved(); // 0x000000018D542BDC-0x000000018D542C2C
		[RequiredByNativeCode]
		private static void DoSendMouseEvents(int skipRTCameras); // 0x00000001855102A0-0x0000000185510F20
		private static void SendEvents(int i, HitInfo hit); // 0x0000000185510FE0-0x0000000185511820
	}
}
