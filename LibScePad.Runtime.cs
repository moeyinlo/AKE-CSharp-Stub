/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;

// Image 109: LibScePad.Runtime.dll - Assembly: LibScePad.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60780-60869

namespace Plugins.LibScePad
{
	public static class LibScePad // TypeDefIndex: 60784
	{
		// Fields
		private static bool s_available; // 0x00
	
		// Properties
		public static bool available { get; } // 0x000000018AA48A00-0x000000018AA48BFC 
	
		// Nested types
		public static class Audio // TypeDefIndex: 60781
		{
			// Methods
			public static int IsSupportAudioFunction(int handle) => default; // 0x000000018AA479EC-0x000000018AA47A24
			public static int SetAudioOutPath(int handle, ScePadAudioOutPath path) => default; // 0x000000018AA460E8-0x000000018AA46138
			public static int SetVolumeGain(int handle, byte speakerVol, byte jackVol, byte micGain) => default; // 0x000000018AA46138-0x000000018AA46194
			public static ScePadHeadsetType GetHeadSetType(int handle) => default; // 0x000000018AA46194-0x000000018AA46228
		}
	
		public static class Basic // TypeDefIndex: 60782
		{
			// Methods
			public static int Init() => default; // 0x000000018AA46078-0x000000018AA460E8
			public static int GetOrOpen(int userId, ScePadType type) => default; // 0x000000018571C770-0x000000018571C7C0
			public static int GetHandle(int userId, ScePadType type) => default; // 0x000000018AA46394-0x000000018AA46400
			public static int Close(int handle) => default; // 0x000000018AA46334-0x000000018AA46394
			public static int ResetLightBar(int handle) => default; // 0x000000018AA46228-0x000000018AA46278
			public static int SetLightBar(int handle, UnityEngine.Color color) => default; // 0x000000018AA4652C-0x000000018AA4657C
			public static int SetLightBar(int handle, byte r, byte g, byte b) => default; // 0x000000018AA46684-0x000000018AA46718
			public static int GetControllerInformation(int handle, out ScePadControllerInformation info) {
				info = default;
				return default;
			} // 0x000000018AA46718-0x000000018AA467AC
			public static int ReadState(int handle, out ScePadData data) {
				data = default;
				return default;
			} // 0x000000018AA46278-0x000000018AA46334
			public static int SetMotionSensorState(int handle, bool enable) => default; // 0x000000018AA46400-0x000000018AA4652C
			public static int SetTiltCorrectionState(int handle, bool enable) => default; // 0x000000018AA467AC-0x000000018AA46808
			public static int SetAngularVelocityDeadbandState(int handle, bool enable) => default; // 0x000000018AA46808-0x000000018AA46864
			public static int SetAngularVelocityBiasCorrectionState(int handle, bool enable) => default; // 0x000000018AA46628-0x000000018AA46684
			public static int ResetOrientation(int handle) => default; // 0x000000018AA465CC-0x000000018AA46628
			public static int SetVibrationMode(int handle, ScePadVibrationMode mode) => default; // 0x000000018AA4657C-0x000000018AA465CC
			private static int _InitWithBluetooth() => default; // 0x000000018AA46864-0x000000018AA468C0
		}
	
		public static class Trigger // TypeDefIndex: 60783
		{
			// Fields
			private static ScePadTriggerEffectOffParamIternal.Command[] s_cachedOffEffectCmdArray; // 0x00
			private static ScePadTriggerFeedbackEffectParamInternal.Command[] s_cachedFeedBackEffectCmdArray; // 0x08
			private static ScePadTriggerVibrationEffectParamInternal.Command[] s_cachedVibrationEffectCmdArray; // 0x10
			private static ScePadTriggerWeaponEffectParamInternal.Command[] s_cachedWeaponEffectCmdArray; // 0x18
			private static ScePadTriggerSlopeFeedbackEffectParamInternal.Command[] s_cachedSlopeEffectCmdArray; // 0x20
			private static ScePadTriggerMultiPositionFeedbackEffectParamInternal.Command[] s_cachedMulPosEffectCmdArray; // 0x28
			private static ScePadTriggerMultiPositionVibrationEffectParamInternal.Command[] s_cachedMulVibEffectCmdArray; // 0x30
	
			// Constructors
			static Trigger() {} // 0x000000018AA47F94-0x000000018AA4819C
	
			// Methods
			public static int GetTriggerEffectStates(int handle, out ScePadTriggerEffectState l2, out ScePadTriggerEffectState r2) {
				l2 = default;
				r2 = default;
				return default;
			} // 0x000000018571C7C0-0x000000018571C810
			public static int SetTriggerEffectOff(int handle, TriggerMask mask) => default; // 0x000000018AA47A24-0x000000018AA47AA8
			public static int SetTriggerEffect(int handle, TriggerEffectCommandUnion command) => default; // 0x000000018AA47AA8-0x000000018AA47BA4
			private static int _SetTriggerEffectFeedback(int handle, TriggerMask mask, TriggerFeedbackEffect paramL2, TriggerFeedbackEffect paramR2) => default; // 0x000000018AA47BA4-0x000000018AA47DD0
			private static int _SetTriggerEffectVibration(int handle, TriggerMask mask, TriggerVibrationEffect paramL2, TriggerVibrationEffect paramR2) => default; // 0x000000018AA47DD0-0x000000018AA47F94
			private static int _SetTriggerEffectWeapon(int handle, TriggerMask mask, TriggerWeaponEffect paramL2, TriggerWeaponEffect paramR2) => default; // 0x000000018AA485C0-0x000000018AA487E0
			private static int _SetTriggerEffectSlope(int handle, TriggerMask mask, TriggerSlopeFeedbackEffect slopeL2, TriggerSlopeFeedbackEffect slopeR2) => default; // 0x000000018AA487E0-0x000000018AA48A00
			private static int _SetTriggerEffectMultiPosition(int handle, TriggerMask mask, TriggerMultiPositionFeedbackEffect paramL2, TriggerMultiPositionFeedbackEffect paramR2) => default; // 0x000000018AA48354-0x000000018AA485C0
			private static int _SetTriggerEffectMultiPositionVibration(int handle, TriggerMask mask, TriggerMultiPositionVibrationEffect paramL2, TriggerMultiPositionVibrationEffect paramR2) => default; // 0x000000018AA4819C-0x000000018AA48354
		}
	}

	public enum ScePadType // TypeDefIndex: 60785
	{
		SCE_PAD_PORT_TYPE_STANDARD = 0,
		SCE_PAD_PORT_TYPE_SPECIAL = 2,
		SCE_PAD_PORT_TYPE_REMOTE_CONTROL = 16
	}

	public enum ScePadSupportBusType // TypeDefIndex: 60786
	{
		SCE_PAD_SUPPORT_BUS_TYPE_USB = 0,
		SCE_PAD_SUPPORT_BUS_TYPE_USB_BT = 1
	}

	public enum ScePadVibrationMode // TypeDefIndex: 60787
	{
		SCE_PAD_VIBRATION_MODE_ADVANCED = 1,
		SCE_PAD_VIBRATION_MODE_COMPATIBLE = 2,
		SCE_PAD_VIBRATION_MODE_COMPATIBLE2 = 3,
		SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE = 4,
		SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE2 = 5
	}

	public enum ScePadAudioOutPath // TypeDefIndex: 60788
	{
		SCE_PAD_AUDIO_OUT_PATH_STEREO_HEADSET = 0,
		SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET = 1,
		SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET_SPEAKER = 2,
		SCE_PAD_AUDIO_OUT_PATH_SPEAKER = 3,
		SCE_PAD_AUDIO_OUT_PATH_OFF = 4
	}

	public enum ScePadHeadsetType // TypeDefIndex: 60789
	{
		SCE_PAD_HEADSET_TYPE_NONE = 0,
		SCE_PAD_HEADSET_TYPE_HEADPHONE = 1,
		SCE_PAD_HEADSET_TYPE_HEADSET = 2
	}

	public enum ScePadTriggerEffectMode // TypeDefIndex: 60790
	{
		SCE_PAD_TRIGGER_EFFECT_MODE_OFF = 0,
		SCE_PAD_TRIGGER_EFFECT_MODE_FEEDBACK = 1,
		SCE_PAD_TRIGGER_EFFECT_MODE_WEAPON = 2,
		SCE_PAD_TRIGGER_EFFECT_MODE_VIBRATION = 3,
		SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_FEEDBACK = 4,
		SCE_PAD_TRIGGER_EFFECT_MODE_SLOPE_FEEDBACK = 5,
		SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_VIBRATION = 6
	}

	public enum ScePadTriggerEffectState // TypeDefIndex: 60791
	{
		SCE_PAD_TRIGGER_EFFECT_STATE_INTERCEPTED = -1,
		SCE_PAD_TRIGGER_EFFECT_STATE_OFF = 0,
		SCE_PAD_TRIGGER_EFFECT_STATE_FEEDBACK_STANDBY = 1,
		SCE_PAD_TRIGGER_EFFECT_STATE_FEEDBACK_ACTIVE = 2,
		SCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_STANDBY = 3,
		SCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_PULLING = 4,
		SCE_PAD_TRIGGER_EFFECT_STATE_WEAPON_FIRED = 5,
		SCE_PAD_TRIGGER_EFFECT_STATE_VIBRATION_STANDBY = 6,
		SCE_PAD_TRIGGER_EFFECT_STATE_VIBRATION_ACTIVE = 7
	}

	public enum TriggerMask : byte // TypeDefIndex: 60792
	{
		NONE = 0,
		L2 = 1,
		R2 = 2,
		ALL = 3
	}

	[Serializable]
	public struct TriggerEffectCommandUnion // TypeDefIndex: 60793
	{
		// Fields
		public TriggerFeedbackEffect feedback; // 0x00
		public TriggerWeaponEffect weapon; // 0x00
		public TriggerVibrationEffect vibration; // 0x00
		public TriggerSlopeFeedbackEffect slopeFeedback; // 0x00
		public TriggerMultiPositionFeedbackEffect multiPositionFeedback; // 0x00
		public TriggerMultiPositionVibrationEffect multiPositionVibration; // 0x00
		public TriggerMask mask; // 0x0B
		public ScePadTriggerEffectMode mode; // 0x0C
	}

	[Serializable]
	public struct TriggerFeedbackEffect // TypeDefIndex: 60794
	{
		// Fields
		public byte position; // 0x00
		public byte strength; // 0x01
	}

	[Serializable]
	public struct TriggerWeaponEffect // TypeDefIndex: 60795
	{
		// Fields
		public byte startPosition; // 0x00
		public byte endPosition; // 0x01
		public byte strength; // 0x02
	}

	[Serializable]
	public struct TriggerVibrationEffect // TypeDefIndex: 60796
	{
		// Fields
		public byte position; // 0x00
		public byte amplitude; // 0x01
		public byte frequency; // 0x02
	}

	[Serializable]
	public struct TriggerSlopeFeedbackEffect // TypeDefIndex: 60797
	{
		// Fields
		public byte startPosition; // 0x00
		public byte endPosition; // 0x01
		public byte startStrength; // 0x02
		public byte endStrength; // 0x03
	}

	[Serializable]
	public struct TriggerMultiPositionFeedbackEffect // TypeDefIndex: 60798
	{
		// Fields
		public byte strength0; // 0x00
		public byte strength1; // 0x01
		public byte strength2; // 0x02
		public byte strength3; // 0x03
		public byte strength4; // 0x04
		public byte strength5; // 0x05
		public byte strength6; // 0x06
		public byte strength7; // 0x07
		public byte strength8; // 0x08
		public byte strength9; // 0x09
	}

	[Serializable]
	public struct TriggerMultiPositionVibrationEffect // TypeDefIndex: 60799
	{
		// Fields
		public byte amplitude0; // 0x00
		public byte amplitude1; // 0x01
		public byte amplitude2; // 0x02
		public byte amplitude3; // 0x03
		public byte amplitude4; // 0x04
		public byte amplitude5; // 0x05
		public byte amplitude6; // 0x06
		public byte amplitude7; // 0x07
		public byte amplitude8; // 0x08
		public byte amplitude9; // 0x09
		public byte frequency; // 0x0A
	}

	[Serializable]
	public struct ScePadTouchPadInformation // TypeDefIndex: 60800
	{
		// Fields
		public float pixelDensity; // 0x00
		public ushort resolutionX; // 0x04
		public ushort resolutionY; // 0x06
	}

	[Serializable]
	public struct ScePadStickInformation // TypeDefIndex: 60801
	{
		// Fields
		public byte deadZoneLeft; // 0x00
		public byte deadZoneRight; // 0x01
	}

	[Serializable]
	public struct ScePadAnalogStick // TypeDefIndex: 60802
	{
		// Fields
		public byte x; // 0x00
		public byte y; // 0x01
	}

	[Serializable]
	public struct ScePadAnalogButtons // TypeDefIndex: 60803
	{
		// Fields
		public byte l2; // 0x00
		public byte r2; // 0x01
	}

	[Serializable]
	public struct ScePadData // TypeDefIndex: 60804
	{
		// Fields
		public uint buttons; // 0x00
		public ScePadAnalogStick leftStick; // 0x04
		public ScePadAnalogStick rightStick; // 0x06
		public ScePadAnalogButtons analogButtons; // 0x08
		public Quaternion orientation; // 0x0C
		public Vector3 acceleration; // 0x1C
		public Vector3 angularVelocity; // 0x28
		public bool connected; // 0x34
		public ulong timeStamp; // 0x38
		public byte connectedCount; // 0x40
	
		// Constructors
		internal ScePadData(ScePadDataInternal data) {
			buttons = default;
			leftStick = default;
			rightStick = default;
			analogButtons = default;
			orientation = default;
			acceleration = default;
			angularVelocity = default;
			connected = default;
			timeStamp = default;
			connectedCount = default;
		} // 0x0000000185FCE8E0-0x0000000185FCE970
	}

	public struct ScePadControllerInformation // TypeDefIndex: 60805
	{
		// Fields
		public ScePadTouchPadInformation touchPadInfo; // 0x00
		public ScePadStickInformation stickInfo; // 0x08
		public byte connectionType; // 0x0A
		public byte connectionCount; // 0x0B
		public bool connected; // 0x0C
	
		// Constructors
		internal ScePadControllerInformation(ScePadControllerInformationInternal info) {
			touchPadInfo = default;
			stickInfo = default;
			connectionType = default;
			connectionCount = default;
			connected = default;
		} // 0x0000000185FCE8B0-0x0000000185FCE8E0
	}

	internal static class LibScePadInvoke // TypeDefIndex: 60806
	{
		// Fields
		private const string LibName = "libScePad"; // Metadata: 0x02082B54
	
		// Methods
		internal static extern int IsSupportedAudioFunction(int handle); // 0x000000018AA46C40-0x000000018AA46CB8
		internal static extern int SetAudioOutPath(int handle, ScePadAudioOutPath path); // 0x000000018AA4719C-0x000000018AA4721C
		internal static extern int SetVolumeGain(int handle, in ScePadVolumeGainInternal gain); // 0x000000018AA4796C-0x000000018AA479EC
		internal static extern int GetJackState(int handle, [In, Out] ScePadJackStateInternal headSetType); // 0x000000018AA46AD8-0x000000018AA46B58
		internal static extern int Init(); // 0x000000018AA46BD8-0x000000018AA46C40
		internal static extern int Init3_WindowsOnly(ScePadInit3ParamInternal init3Param); // 0x00000001844CE200-0x00000001844CE2A0
		internal static extern int Close(int handle); // 0x000000018AA468C0-0x000000018AA46938
		internal static extern int Open(int userId, ScePadType type, int index, IntPtr param); // 0x000000018AA46CB8-0x000000018AA46D54
		internal static extern int GetHandle(int userId, ScePadType type, int index); // 0x000000018AA46A4C-0x000000018AA46AD8
		internal static extern int ResetLightBar(int handle); // 0x000000018AA46FAC-0x000000018AA47024
		internal static extern int SetLightBar(int handle, in ScePadColorInternal color); // 0x000000018AA4721C-0x000000018AA4729C
		internal static extern int ReadState(int handle, [In, Out] ScePadDataInternal data); // 0x000000018AA46D54-0x000000018AA46E78
		internal static extern int Read(int handle, [In, Out] ScePadDataInternal data, int num); // 0x000000018AA46E78-0x000000018AA46FAC
		internal static extern int GetControllerInformation(int handle, [In, Out] ScePadControllerInformationInternal info); // 0x000000018AA46938-0x000000018AA46A4C
		internal static extern int SetMotionSensorState(int handle, bool enable); // 0x000000018AA4729C-0x000000018AA4731C
		internal static extern int SetTiltCorrectionState(int handle, bool enable); // 0x000000018AA4731C-0x000000018AA4739C
		internal static extern int SetAngularVelocityDeadbandState(int handle, bool enable); // 0x000000018AA4711C-0x000000018AA4719C
		internal static extern int SetAngularVelocityBiasCorrectionState(int handle, bool enable); // 0x000000018AA4709C-0x000000018AA4711C
		internal static extern int ResetOrientation(int handle); // 0x000000018AA47024-0x000000018AA4709C
		internal static extern int SetVibrationMode(int handle, ScePadVibrationMode mode); // 0x000000018AA4786C-0x000000018AA478EC
		internal static extern int SetVibration(int handle, in ScePadVibrationParamInternal mode); // 0x000000018AA478EC-0x000000018AA4796C
		internal static extern int GetTriggerEffectState(int handle, [In, Out] ScePadTriggerEffectStateInformationInternal info); // 0x000000018AA46B58-0x000000018AA46BD8
		internal static extern int SetTriggerEffectOff(int handle, in ScePadTriggerEffectOffParamIternal param); // 0x000000018AA475AC-0x000000018AA4765C
		internal static extern int SetTriggerEffectFeedback(int handle, in ScePadTriggerFeedbackEffectParamInternal param); // 0x000000018AA4739C-0x000000018AA4744C
		internal static extern int SetTriggerEffectVibration(int handle, in ScePadTriggerVibrationEffectParamInternal param); // 0x000000018AA4770C-0x000000018AA477BC
		internal static extern int SetTriggerEffectWeapon(int handle, in ScePadTriggerWeaponEffectParamInternal param); // 0x000000018AA477BC-0x000000018AA4786C
		internal static extern int SetTriggerEffectSlope(int handle, in ScePadTriggerSlopeFeedbackEffectParamInternal param); // 0x000000018AA4765C-0x000000018AA4770C
		internal static extern int SetTriggerEffectMultiPosition(int handle, in ScePadTriggerMultiPositionFeedbackEffectParamInternal param); // 0x000000018AA474FC-0x000000018AA475AC
		internal static extern int SetTriggerEffectMultiPositionVibration(int handle, in ScePadTriggerMultiPositionVibrationEffectParamInternal param); // 0x000000018AA4744C-0x000000018AA474FC
	}

	internal struct ScePadColorInternal // TypeDefIndex: 60807
	{
		// Fields
		public byte r; // 0x00
		public byte g; // 0x01
		public byte b; // 0x02
		public byte reserved; // 0x03
	}

	internal struct ScePadInit3ParamInternal // TypeDefIndex: 60809
	{
		// Fields
		public IntPtr allocFunc; // 0x00
		public IntPtr freeFunc; // 0x08
		public ScePadSupportBusType supportBusType; // 0x10
		private _reserve_e__FixedBuffer reserve; // 0x14
	
		// Nested types
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 60808
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadDataInternal // TypeDefIndex: 60812
	{
		// Fields
		public uint buttons; // 0x00
		public ScePadAnalogStick leftStick; // 0x04
		public ScePadAnalogStick rightStick; // 0x06
		public ScePadAnalogButtonsInternal analogButtons; // 0x08
		public SceFQuaternionInternal orientation; // 0x0C
		public SceFVector3Internal acceleration; // 0x1C
		public SceFVector3Internal angularVelocity; // 0x28
		public ScePadTouchDataInternal touchData; // 0x34
		public bool connected; // 0x4C
		public ulong timestamp; // 0x50
		public ScePadExtensionUnitDataInternal extennsionnUnitData; // 0x58
		public byte connectedCount; // 0x68
		private _reserve_e__FixedBuffer reserve; // 0x69
		public byte deviceUniqueDataLen; // 0x6B
		public _deviceUniqueData_e__FixedBuffer deviceUniqueData; // 0x6C
	
		// Nested types
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 60810
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _deviceUniqueData_e__FixedBuffer // TypeDefIndex: 60811
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadControllerInformationInternal // TypeDefIndex: 60814
	{
		// Fields
		public ScePadTouchPadInformation touchPadInfo; // 0x00
		public ScePadStickInformation stickInfo; // 0x08
		public byte connectionType; // 0x0A
		public byte connectionCount; // 0x0B
		public bool connected; // 0x0C
		private ___e__FixedBuffer _; // 0x0D
	
		// Nested types
		public struct ___e__FixedBuffer // TypeDefIndex: 60813
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadVibrationParamInternal // TypeDefIndex: 60815
	{
		// Fields
		public byte largeMotor; // 0x00
		public byte smallMotor; // 0x01
	}

	internal struct ScePadAnalogButtonsInternal // TypeDefIndex: 60817
	{
		// Fields
		public byte l2; // 0x00
		public byte r2; // 0x01
		private ___e__FixedBuffer _; // 0x02
	
		// Nested types
		public struct ___e__FixedBuffer // TypeDefIndex: 60816
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTouchDataInternal // TypeDefIndex: 60819
	{
		// Fields
		public byte touchNum; // 0x00
		private _reserve_e__FixedBuffer reserve; // 0x01
		private uint reserve1; // 0x04
		public ScePadTouchInternal touch1; // 0x08
		public ScePadTouchInternal touch2; // 0x10
	
		// Nested types
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 60818
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTouchInternal // TypeDefIndex: 60821
	{
		// Fields
		public ushort x; // 0x00
		public ushort y; // 0x02
		public byte id; // 0x04
		private _reserve_e__FixedBuffer reserve; // 0x05
	
		// Nested types
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 60820
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadOpenParamInternal // TypeDefIndex: 60823
	{
		// Fields
		public _reserve_e__FixedBuffer reserve; // 0x00
	
		// Nested types
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 60822
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	}

	internal struct ScePadExtensionUnitDataInternal // TypeDefIndex: 60826
	{
		// Fields
		public uint extensionUnitId; // 0x00
		private _reserve_e__FixedBuffer reserve; // 0x04
		public byte dateLength; // 0x05
		public _data_e__FixedBuffer data; // 0x06
	
		// Nested types
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 60824
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 60825
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadVolumeGainInternal // TypeDefIndex: 60827
	{
		// Fields
		public byte speakerVol; // 0x00
		public byte jackVol; // 0x01
		private byte reserved; // 0x02
		public byte micGain; // 0x03
	}

	internal struct ScePadJackStateInternal // TypeDefIndex: 60829
	{
		// Fields
		public ScePadHeadsetType headsetType; // 0x00
		private _reserve_e__FixedBuffer reserve; // 0x04
	
		// Nested types
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 60828
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct SceFVector3Internal // TypeDefIndex: 60830
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
	}

	internal struct SceFQuaternionInternal // TypeDefIndex: 60831
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
	}

	internal struct ScePadTriggerEffectOffParamIternal // TypeDefIndex: 60835
	{
		// Fields
		public byte triggerMask; // 0x00
		private ___e__FixedBuffer _; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 60833
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private ___e__FixedBuffer _; // 0x04
	
			// Nested types
			public struct ___e__FixedBuffer // TypeDefIndex: 60832
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct ___e__FixedBuffer // TypeDefIndex: 60834
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerFeedbackEffectParamInternal // TypeDefIndex: 60840
	{
		// Fields
		public byte triggerMask; // 0x00
		private ___e__FixedBuffer _; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 60838
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private __1_e__FixedBuffer _1; // 0x04
			public byte position; // 0x08
			public byte strength; // 0x09
			private __2_e__FixedBuffer _2; // 0x0A
	
			// Nested types
			public struct __1_e__FixedBuffer // TypeDefIndex: 60836
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct __2_e__FixedBuffer // TypeDefIndex: 60837
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct ___e__FixedBuffer // TypeDefIndex: 60839
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerWeaponEffectParamInternal // TypeDefIndex: 60845
	{
		// Fields
		public byte triggerMask; // 0x00
		private ___e__FixedBuffer _; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 60843
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private __1_e__FixedBuffer _1; // 0x04
			public byte startPosition; // 0x08
			public byte endPosition; // 0x09
			public byte strength; // 0x0A
			private __2_e__FixedBuffer _2; // 0x0B
	
			// Nested types
			public struct __1_e__FixedBuffer // TypeDefIndex: 60841
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct __2_e__FixedBuffer // TypeDefIndex: 60842
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct ___e__FixedBuffer // TypeDefIndex: 60844
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerVibrationEffectParamInternal // TypeDefIndex: 60850
	{
		// Fields
		public byte triggerMask; // 0x00
		private ___e__FixedBuffer _; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 60848
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private __1_e__FixedBuffer _1; // 0x04
			public byte position; // 0x08
			public byte amplitude; // 0x09
			public byte frequency; // 0x0A
			private __2_e__FixedBuffer _2; // 0x0B
	
			// Nested types
			public struct __1_e__FixedBuffer // TypeDefIndex: 60846
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct __2_e__FixedBuffer // TypeDefIndex: 60847
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct ___e__FixedBuffer // TypeDefIndex: 60849
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerSlopeFeedbackEffectParamInternal // TypeDefIndex: 60855
	{
		// Fields
		public byte triggerMask; // 0x00
		public ___e__FixedBuffer _; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 60853
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private __1_e__FixedBuffer _1; // 0x04
			public byte startPosition; // 0x08
			public byte endPosition; // 0x09
			public byte startStrength; // 0x0A
			public byte endStrength; // 0x0B
			private __2_e__FixedBuffer _2; // 0x0C
	
			// Nested types
			public struct __1_e__FixedBuffer // TypeDefIndex: 60851
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct __2_e__FixedBuffer // TypeDefIndex: 60852
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct ___e__FixedBuffer // TypeDefIndex: 60854
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerMultiPositionFeedbackEffectParamInternal // TypeDefIndex: 60861
	{
		// Fields
		public byte triggerMask; // 0x00
		public ___e__FixedBuffer _; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 60859
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private __1_e__FixedBuffer _1; // 0x04
			public _strength_e__FixedBuffer strength; // 0x08
			private __2_e__FixedBuffer _2; // 0x12
	
			// Nested types
			public struct __1_e__FixedBuffer // TypeDefIndex: 60856
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct _strength_e__FixedBuffer // TypeDefIndex: 60857
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct __2_e__FixedBuffer // TypeDefIndex: 60858
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct ___e__FixedBuffer // TypeDefIndex: 60860
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerMultiPositionVibrationEffectParamInternal // TypeDefIndex: 60867
	{
		// Fields
		public byte triggerMask; // 0x00
		public ___e__FixedBuffer _; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 60865
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private __1_e__FixedBuffer _1; // 0x04
			public byte frequency; // 0x08
			public _amplitude_e__FixedBuffer amplitude; // 0x09
			private __2_e__FixedBuffer _2; // 0x13
	
			// Nested types
			public struct __1_e__FixedBuffer // TypeDefIndex: 60862
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct _amplitude_e__FixedBuffer // TypeDefIndex: 60863
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct __2_e__FixedBuffer // TypeDefIndex: 60864
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		public struct ___e__FixedBuffer // TypeDefIndex: 60866
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerEffectStateInformationInternal // TypeDefIndex: 60869
	{
		// Fields
		public _state_e__FixedBuffer state; // 0x00
	
		// Nested types
		public struct _state_e__FixedBuffer // TypeDefIndex: 60868
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	}
}
