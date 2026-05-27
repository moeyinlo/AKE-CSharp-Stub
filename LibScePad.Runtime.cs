/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 106: LibScePad.Runtime.dll - Assembly: LibScePad.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59676-59765
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Plugins.LibScePad
{
	public static class LibScePad // TypeDefIndex: 59680
	{
		// Fields
		private static bool s_available; // 0x00
	
		// Properties
		public static bool available { get; } // 0x0000000188934A94-0x0000000188934ACC 
	
		// Nested types
		public static class Audio // TypeDefIndex: 59677
		{
			// Methods
			public static int IsSupportAudioFunction(int handle) => default; // 0x0000000188933190-0x00000001889331E0
			public static int SetAudioOutPath(int handle, ScePadAudioOutPath path) => default; // 0x00000001889331E0-0x000000018893323C
			public static int SetVolumeGain(int handle, byte speakerVol, byte jackVol, byte micGain) => default; // 0x000000018893323C-0x00000001889332D0
			public static ScePadHeadsetType GetHeadSetType(int handle) => default; // 0x0000000188933120-0x0000000188933190
		}
	
		public static class Basic // TypeDefIndex: 59678
		{
			// Methods
			public static int Init() => default; // 0x0000000183656680-0x00000001836566D0
			public static int GetOrOpen(int userId, ScePadType type) => default; // 0x000000018893343C-0x00000001889334A8
			public static int GetHandle(int userId, ScePadType type) => default; // 0x00000001889333DC-0x000000018893343C
			public static int Close(int handle) => default; // 0x00000001889332D0-0x0000000188933320
			public static int ResetLightBar(int handle) => default; // 0x00000001889335D4-0x0000000188933624
			public static int SetLightBar(int handle, UnityEngine.Color color) => default; // 0x000000018893372C-0x00000001889337C0
			public static int SetLightBar(int handle, byte r, byte g, byte b) => default; // 0x00000001889337C0-0x0000000188933854
			public static int GetControllerInformation(int handle, out ScePadControllerInformation info) {
				info = default;
				return default;
			} // 0x0000000188933320-0x00000001889333DC
			public static int ReadState(int handle, out ScePadData data) {
				data = default;
				return default;
			} // 0x00000001889334A8-0x00000001889335D4
			public static int SetMotionSensorState(int handle, bool enable) => default; // 0x0000000188933854-0x00000001889338B0
			public static int SetTiltCorrectionState(int handle, bool enable) => default; // 0x00000001889338B0-0x000000018893390C
			public static int SetAngularVelocityDeadbandState(int handle, bool enable) => default; // 0x00000001889336D0-0x000000018893372C
			public static int SetAngularVelocityBiasCorrectionState(int handle, bool enable) => default; // 0x0000000188933674-0x00000001889336D0
			public static int ResetOrientation(int handle) => default; // 0x0000000188933624-0x0000000188933674
			public static int SetVibrationMode(int handle, ScePadVibrationMode mode) => default; // 0x000000018893390C-0x0000000188933968
			private static int _InitWithBluetooth() => default; // 0x00000001836566D0-0x0000000183656720
		}
	
		public static class Trigger // TypeDefIndex: 59679
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
			static Trigger() {} // 0x0000000188935AA8-0x0000000188935CA4
	
			// Methods
			public static int GetTriggerEffectStates(int handle, out ScePadTriggerEffectState l2, out ScePadTriggerEffectState r2) {
				l2 = default;
				r2 = default;
				return default;
			} // 0x0000000188934ACC-0x0000000188934B50
			public static int SetTriggerEffectOff(int handle, TriggerMask mask) => default; // 0x0000000188934B50-0x0000000188934C4C
			public static int SetTriggerEffect(int handle, TriggerEffectCommandUnion command) => default; // 0x0000000188934C4C-0x0000000188934E78
			private static int _SetTriggerEffectFeedback(int handle, TriggerMask mask, TriggerFeedbackEffect paramL2, TriggerFeedbackEffect paramR2) => default; // 0x0000000188934E78-0x000000018893503C
			private static int _SetTriggerEffectVibration(int handle, TriggerMask mask, TriggerVibrationEffect paramL2, TriggerVibrationEffect paramR2) => default; // 0x0000000188935668-0x0000000188935888
			private static int _SetTriggerEffectWeapon(int handle, TriggerMask mask, TriggerWeaponEffect paramL2, TriggerWeaponEffect paramR2) => default; // 0x0000000188935888-0x0000000188935AA8
			private static int _SetTriggerEffectSlope(int handle, TriggerMask mask, TriggerSlopeFeedbackEffect slopeL2, TriggerSlopeFeedbackEffect slopeR2) => default; // 0x00000001889353FC-0x0000000188935668
			private static int _SetTriggerEffectMultiPosition(int handle, TriggerMask mask, TriggerMultiPositionFeedbackEffect paramL2, TriggerMultiPositionFeedbackEffect paramR2) => default; // 0x0000000188935244-0x00000001889353FC
			private static int _SetTriggerEffectMultiPositionVibration(int handle, TriggerMask mask, TriggerMultiPositionVibrationEffect paramL2, TriggerMultiPositionVibrationEffect paramR2) => default; // 0x000000018893503C-0x0000000188935244
		}
	}

	public enum ScePadType // TypeDefIndex: 59681
	{
		SCE_PAD_PORT_TYPE_STANDARD = 0,
		SCE_PAD_PORT_TYPE_SPECIAL = 2,
		SCE_PAD_PORT_TYPE_REMOTE_CONTROL = 16
	}

	public enum ScePadSupportBusType // TypeDefIndex: 59682
	{
		SCE_PAD_SUPPORT_BUS_TYPE_USB = 0,
		SCE_PAD_SUPPORT_BUS_TYPE_USB_BT = 1
	}

	public enum ScePadVibrationMode // TypeDefIndex: 59683
	{
		SCE_PAD_VIBRATION_MODE_ADVANCED = 1,
		SCE_PAD_VIBRATION_MODE_COMPATIBLE = 2,
		SCE_PAD_VIBRATION_MODE_COMPATIBLE2 = 3,
		SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE = 4,
		SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE2 = 5
	}

	public enum ScePadAudioOutPath // TypeDefIndex: 59684
	{
		SCE_PAD_AUDIO_OUT_PATH_STEREO_HEADSET = 0,
		SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET = 1,
		SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET_SPEAKER = 2,
		SCE_PAD_AUDIO_OUT_PATH_SPEAKER = 3,
		SCE_PAD_AUDIO_OUT_PATH_OFF = 4
	}

	public enum ScePadHeadsetType // TypeDefIndex: 59685
	{
		SCE_PAD_HEADSET_TYPE_NONE = 0,
		SCE_PAD_HEADSET_TYPE_HEADPHONE = 1,
		SCE_PAD_HEADSET_TYPE_HEADSET = 2
	}

	public enum ScePadTriggerEffectMode // TypeDefIndex: 59686
	{
		SCE_PAD_TRIGGER_EFFECT_MODE_OFF = 0,
		SCE_PAD_TRIGGER_EFFECT_MODE_FEEDBACK = 1,
		SCE_PAD_TRIGGER_EFFECT_MODE_WEAPON = 2,
		SCE_PAD_TRIGGER_EFFECT_MODE_VIBRATION = 3,
		SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_FEEDBACK = 4,
		SCE_PAD_TRIGGER_EFFECT_MODE_SLOPE_FEEDBACK = 5,
		SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_VIBRATION = 6
	}

	public enum ScePadTriggerEffectState // TypeDefIndex: 59687
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

	[Flags]
	public enum TriggerMask : byte // TypeDefIndex: 59688
	{
		NONE = 0,
		L2 = 1,
		R2 = 2,
		ALL = 3
	}

	[Serializable]
	public struct TriggerEffectCommandUnion // TypeDefIndex: 59689
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
	public struct TriggerFeedbackEffect // TypeDefIndex: 59690
	{
		// Fields
		[Range(0f, 9f)]
		public byte position; // 0x00
		[Range(0f, 8f)]
		public byte strength; // 0x01
	}

	[Serializable]
	public struct TriggerWeaponEffect // TypeDefIndex: 59691
	{
		// Fields
		[Range(2f, 7f)]
		public byte startPosition; // 0x00
		[Range(3f, 8f)]
		public byte endPosition; // 0x01
		[Range(0f, 8f)]
		public byte strength; // 0x02
	}

	[Serializable]
	public struct TriggerVibrationEffect // TypeDefIndex: 59692
	{
		// Fields
		[Range(0f, 9f)]
		public byte position; // 0x00
		[Range(0f, 8f)]
		public byte amplitude; // 0x01
		[Range(0f, 255f)]
		public byte frequency; // 0x02
	}

	[Serializable]
	public struct TriggerSlopeFeedbackEffect // TypeDefIndex: 59693
	{
		// Fields
		[Range(0f, 9f)]
		public byte startPosition; // 0x00
		[Range(1f, 9f)]
		public byte endPosition; // 0x01
		[Range(1f, 8f)]
		public byte startStrength; // 0x02
		[Range(1f, 8f)]
		public byte endStrength; // 0x03
	}

	[Serializable]
	public struct TriggerMultiPositionFeedbackEffect // TypeDefIndex: 59694
	{
		// Fields
		[Range(0f, 8f)]
		public byte strength0; // 0x00
		[Range(0f, 8f)]
		public byte strength1; // 0x01
		[Range(0f, 8f)]
		public byte strength2; // 0x02
		[Range(0f, 8f)]
		public byte strength3; // 0x03
		[Range(0f, 8f)]
		public byte strength4; // 0x04
		[Range(0f, 8f)]
		public byte strength5; // 0x05
		[Range(0f, 8f)]
		public byte strength6; // 0x06
		[Range(0f, 8f)]
		public byte strength7; // 0x07
		[Range(0f, 8f)]
		public byte strength8; // 0x08
		[Range(0f, 8f)]
		public byte strength9; // 0x09
	}

	[Serializable]
	public struct TriggerMultiPositionVibrationEffect // TypeDefIndex: 59695
	{
		// Fields
		[Range(0f, 8f)]
		public byte amplitude0; // 0x00
		[Range(0f, 8f)]
		public byte amplitude1; // 0x01
		[Range(0f, 8f)]
		public byte amplitude2; // 0x02
		[Range(0f, 8f)]
		public byte amplitude3; // 0x03
		[Range(0f, 8f)]
		public byte amplitude4; // 0x04
		[Range(0f, 8f)]
		public byte amplitude5; // 0x05
		[Range(0f, 8f)]
		public byte amplitude6; // 0x06
		[Range(0f, 8f)]
		public byte amplitude7; // 0x07
		[Range(0f, 8f)]
		public byte amplitude8; // 0x08
		[Range(0f, 8f)]
		public byte amplitude9; // 0x09
		[Range(0f, 255f)]
		public byte frequency; // 0x0A
	}

	[Serializable]
	public struct ScePadTouchPadInformation // TypeDefIndex: 59696
	{
		// Fields
		public float pixelDensity; // 0x00
		public ushort resolutionX; // 0x04
		public ushort resolutionY; // 0x06
	}

	[Serializable]
	public struct ScePadStickInformation // TypeDefIndex: 59697
	{
		// Fields
		public byte deadZoneLeft; // 0x00
		public byte deadZoneRight; // 0x01
	}

	[Serializable]
	public struct ScePadAnalogStick // TypeDefIndex: 59698
	{
		// Fields
		public byte x; // 0x00
		public byte y; // 0x01
	}

	[Serializable]
	public struct ScePadAnalogButtons // TypeDefIndex: 59699
	{
		// Fields
		public byte l2; // 0x00
		public byte r2; // 0x01
	}

	[Serializable]
	public struct ScePadData // TypeDefIndex: 59700
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
		} // 0x0000000183D6DCC0-0x0000000183D6DD50
	}

	public struct ScePadControllerInformation // TypeDefIndex: 59701
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
		} // 0x0000000183D6DC90-0x0000000183D6DCC0
	}

	internal static class LibScePadInvoke // TypeDefIndex: 59702
	{
		// Fields
		private const string LibName = "libScePad"; // Metadata: 0x01FDD268
	
		// Methods
		internal static extern int IsSupportedAudioFunction(int handle); // 0x0000000188933CE8-0x0000000188933D60
		internal static extern int SetAudioOutPath(int handle, ScePadAudioOutPath path); // 0x0000000188934244-0x00000001889342C4
		internal static extern int SetVolumeGain(int handle, in ScePadVolumeGainInternal gain); // 0x0000000188934A14-0x0000000188934A94
		internal static extern int GetJackState(int handle, [In, Out] ScePadJackStateInternal headSetType); // 0x0000000188933B80-0x0000000188933C00
		internal static extern int Init(); // 0x0000000188933C80-0x0000000188933CE8
		internal static extern int Init3_WindowsOnly(ScePadInit3ParamInternal init3Param); // 0x00000001822C7690-0x00000001822C7730
		internal static extern int Close(int handle); // 0x0000000188933968-0x00000001889339E0
		internal static extern int Open(int userId, ScePadType type, int index, IntPtr param); // 0x0000000188933D60-0x0000000188933DFC
		internal static extern int GetHandle(int userId, ScePadType type, int index); // 0x0000000188933AF4-0x0000000188933B80
		internal static extern int ResetLightBar(int handle); // 0x0000000188934054-0x00000001889340CC
		internal static extern int SetLightBar(int handle, in ScePadColorInternal color); // 0x00000001889342C4-0x0000000188934344
		internal static extern int ReadState(int handle, [In, Out] ScePadDataInternal data); // 0x0000000188933DFC-0x0000000188933F20
		internal static extern int Read(int handle, [In, Out] ScePadDataInternal data, int num); // 0x0000000188933F20-0x0000000188934054
		internal static extern int GetControllerInformation(int handle, [In, Out] ScePadControllerInformationInternal info); // 0x00000001889339E0-0x0000000188933AF4
		internal static extern int SetMotionSensorState(int handle, bool enable); // 0x0000000188934344-0x00000001889343C4
		internal static extern int SetTiltCorrectionState(int handle, bool enable); // 0x00000001889343C4-0x0000000188934444
		internal static extern int SetAngularVelocityDeadbandState(int handle, bool enable); // 0x00000001889341C4-0x0000000188934244
		internal static extern int SetAngularVelocityBiasCorrectionState(int handle, bool enable); // 0x0000000188934144-0x00000001889341C4
		internal static extern int ResetOrientation(int handle); // 0x00000001889340CC-0x0000000188934144
		internal static extern int SetVibrationMode(int handle, ScePadVibrationMode mode); // 0x0000000188934914-0x0000000188934994
		internal static extern int SetVibration(int handle, in ScePadVibrationParamInternal mode); // 0x0000000188934994-0x0000000188934A14
		internal static extern int GetTriggerEffectState(int handle, [In, Out] ScePadTriggerEffectStateInformationInternal info); // 0x0000000188933C00-0x0000000188933C80
		internal static extern int SetTriggerEffectOff(int handle, in ScePadTriggerEffectOffParamIternal param); // 0x0000000188934654-0x0000000188934704
		internal static extern int SetTriggerEffectFeedback(int handle, in ScePadTriggerFeedbackEffectParamInternal param); // 0x0000000188934444-0x00000001889344F4
		internal static extern int SetTriggerEffectVibration(int handle, in ScePadTriggerVibrationEffectParamInternal param); // 0x00000001889347B4-0x0000000188934864
		internal static extern int SetTriggerEffectWeapon(int handle, in ScePadTriggerWeaponEffectParamInternal param); // 0x0000000188934864-0x0000000188934914
		internal static extern int SetTriggerEffectSlope(int handle, in ScePadTriggerSlopeFeedbackEffectParamInternal param); // 0x0000000188934704-0x00000001889347B4
		internal static extern int SetTriggerEffectMultiPosition(int handle, in ScePadTriggerMultiPositionFeedbackEffectParamInternal param); // 0x00000001889345A4-0x0000000188934654
		internal static extern int SetTriggerEffectMultiPositionVibration(int handle, in ScePadTriggerMultiPositionVibrationEffectParamInternal param); // 0x00000001889344F4-0x00000001889345A4
	}

	internal struct ScePadColorInternal // TypeDefIndex: 59703
	{
		// Fields
		public byte r; // 0x00
		public byte g; // 0x01
		public byte b; // 0x02
		public byte reserved; // 0x03
	}

	internal struct ScePadInit3ParamInternal // TypeDefIndex: 59705
	{
		// Fields
		public IntPtr allocFunc; // 0x00
		public IntPtr freeFunc; // 0x08
		public ScePadSupportBusType supportBusType; // 0x10
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x14
	}

	internal struct ScePadDataInternal // TypeDefIndex: 59708
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
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x69
		public byte deviceUniqueDataLen; // 0x6B
		public unsafe fixed /* 0x00000000-0x00000000 */ byte deviceUniqueData[0]; // 0x6C
	}

	internal struct ScePadControllerInformationInternal // TypeDefIndex: 59710
	{
		// Fields
		public ScePadTouchPadInformation touchPadInfo; // 0x00
		public ScePadStickInformation stickInfo; // 0x08
		public byte connectionType; // 0x0A
		public byte connectionCount; // 0x0B
		public bool connected; // 0x0C
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x0D
	}

	internal struct ScePadVibrationParamInternal // TypeDefIndex: 59711
	{
		// Fields
		public byte largeMotor; // 0x00
		public byte smallMotor; // 0x01
	}

	internal struct ScePadAnalogButtonsInternal // TypeDefIndex: 59713
	{
		// Fields
		public byte l2; // 0x00
		public byte r2; // 0x01
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x02
	}

	internal struct ScePadTouchDataInternal // TypeDefIndex: 59715
	{
		// Fields
		public byte touchNum; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x01
		private uint reserve1; // 0x04
		public ScePadTouchInternal touch1; // 0x08
		public ScePadTouchInternal touch2; // 0x10
	}

	internal struct ScePadTouchInternal // TypeDefIndex: 59717
	{
		// Fields
		public ushort x; // 0x00
		public ushort y; // 0x02
		public byte id; // 0x04
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x05
	}

	internal struct ScePadOpenParamInternal // TypeDefIndex: 59719
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ uint reserve[0]; // 0x00
	}

	internal struct ScePadExtensionUnitDataInternal // TypeDefIndex: 59722
	{
		// Fields
		public uint extensionUnitId; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x04
		public byte dateLength; // 0x05
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x06
	}

	internal struct ScePadVolumeGainInternal // TypeDefIndex: 59723
	{
		// Fields
		public byte speakerVol; // 0x00
		public byte jackVol; // 0x01
		private byte reserved; // 0x02
		public byte micGain; // 0x03
	}

	internal struct ScePadJackStateInternal // TypeDefIndex: 59725
	{
		// Fields
		public ScePadHeadsetType headsetType; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x04
	}

	internal struct SceFVector3Internal // TypeDefIndex: 59726
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
	}

	internal struct SceFQuaternionInternal // TypeDefIndex: 59727
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
	}

	internal struct ScePadTriggerEffectOffParamIternal // TypeDefIndex: 59731
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 59729
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x04
		}
	}

	internal struct ScePadTriggerFeedbackEffectParamInternal // TypeDefIndex: 59736
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 59734
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte position; // 0x08
			public byte strength; // 0x09
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x0A
		}
	}

	internal struct ScePadTriggerWeaponEffectParamInternal // TypeDefIndex: 59741
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 59739
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte startPosition; // 0x08
			public byte endPosition; // 0x09
			public byte strength; // 0x0A
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x0B
		}
	}

	internal struct ScePadTriggerVibrationEffectParamInternal // TypeDefIndex: 59746
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 59744
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte position; // 0x08
			public byte amplitude; // 0x09
			public byte frequency; // 0x0A
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x0B
		}
	}

	internal struct ScePadTriggerSlopeFeedbackEffectParamInternal // TypeDefIndex: 59751
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 59749
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte startPosition; // 0x08
			public byte endPosition; // 0x09
			public byte startStrength; // 0x0A
			public byte endStrength; // 0x0B
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x0C
		}
	}

	internal struct ScePadTriggerMultiPositionFeedbackEffectParamInternal // TypeDefIndex: 59757
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 59755
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public unsafe fixed /* 0x00000000-0x00000000 */ byte strength[0]; // 0x08
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x12
		}
	}

	internal struct ScePadTriggerMultiPositionVibrationEffectParamInternal // TypeDefIndex: 59763
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 59761
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte frequency; // 0x08
			public unsafe fixed /* 0x00000000-0x00000000 */ byte amplitude[0]; // 0x09
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x13
		}
	}

	internal struct ScePadTriggerEffectStateInformationInternal // TypeDefIndex: 59765
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ int state[0]; // 0x00
	}
}
