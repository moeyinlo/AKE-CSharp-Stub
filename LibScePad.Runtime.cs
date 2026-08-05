/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 111: LibScePad.Runtime.dll - Assembly: LibScePad.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63406-63495
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Plugins.LibScePad
{
	public static class LibScePad // TypeDefIndex: 63410
	{
		// Fields
		private static bool s_available; // 0x00
	
		// Properties
		public static bool available { get; } // 0x0000000189EB4E08-0x0000000189EB4E40 
	
		// Nested types
		public static class Audio // TypeDefIndex: 63407
		{
			// Methods
			public static int IsSupportAudioFunction(int handle); // 0x0000000189EB3504-0x0000000189EB3554
			public static int SetAudioOutPath(int handle, ScePadAudioOutPath path); // 0x0000000189EB3554-0x0000000189EB35B0
			public static int SetVolumeGain(int handle, byte speakerVol, byte jackVol, byte micGain); // 0x0000000189EB35B0-0x0000000189EB3644
			public static ScePadHeadsetType GetHeadSetType(int handle); // 0x0000000189EB3494-0x0000000189EB3504
		}
	
		public static class Basic // TypeDefIndex: 63408
		{
			// Methods
			public static int Init(); // 0x0000000183329C50-0x0000000183329CA0
			public static int GetOrOpen(int userId, ScePadType type); // 0x0000000189EB37B0-0x0000000189EB381C
			public static int GetHandle(int userId, ScePadType type); // 0x0000000189EB3750-0x0000000189EB37B0
			public static int Close(int handle); // 0x0000000189EB3644-0x0000000189EB3694
			public static int ResetLightBar(int handle); // 0x0000000189EB3948-0x0000000189EB3998
			public static int SetLightBar(int handle, UnityEngine.Color color); // 0x0000000189EB3AA0-0x0000000189EB3B34
			public static int SetLightBar(int handle, byte r, byte g, byte b); // 0x0000000189EB3B34-0x0000000189EB3BC8
			public static int GetControllerInformation(int handle, out ScePadControllerInformation info); // 0x0000000189EB3694-0x0000000189EB3750
			public static int ReadState(int handle, out ScePadData data); // 0x0000000189EB381C-0x0000000189EB3948
			public static int SetMotionSensorState(int handle, bool enable); // 0x0000000189EB3BC8-0x0000000189EB3C24
			public static int SetTiltCorrectionState(int handle, bool enable); // 0x0000000189EB3C24-0x0000000189EB3C80
			public static int SetAngularVelocityDeadbandState(int handle, bool enable); // 0x0000000189EB3A44-0x0000000189EB3AA0
			public static int SetAngularVelocityBiasCorrectionState(int handle, bool enable); // 0x0000000189EB39E8-0x0000000189EB3A44
			public static int ResetOrientation(int handle); // 0x0000000189EB3998-0x0000000189EB39E8
			public static int SetVibrationMode(int handle, ScePadVibrationMode mode); // 0x0000000189EB3C80-0x0000000189EB3CDC
			private static int _InitWithBluetooth(); // 0x0000000183329CA0-0x0000000183329CF0
		}
	
		public static class Trigger // TypeDefIndex: 63409
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
			static Trigger(); // 0x0000000189EB5E1C-0x0000000189EB6018
	
			// Methods
			public static int GetTriggerEffectStates(int handle, out ScePadTriggerEffectState l2, out ScePadTriggerEffectState r2); // 0x0000000189EB4E40-0x0000000189EB4EC4
			public static int SetTriggerEffectOff(int handle, TriggerMask mask); // 0x0000000189EB4EC4-0x0000000189EB4FC0
			public static int SetTriggerEffect(int handle, TriggerEffectCommandUnion command); // 0x0000000189EB4FC0-0x0000000189EB51EC
			private static int _SetTriggerEffectFeedback(int handle, TriggerMask mask, TriggerFeedbackEffect paramL2, TriggerFeedbackEffect paramR2); // 0x0000000189EB51EC-0x0000000189EB53B0
			private static int _SetTriggerEffectVibration(int handle, TriggerMask mask, TriggerVibrationEffect paramL2, TriggerVibrationEffect paramR2); // 0x0000000189EB59DC-0x0000000189EB5BFC
			private static int _SetTriggerEffectWeapon(int handle, TriggerMask mask, TriggerWeaponEffect paramL2, TriggerWeaponEffect paramR2); // 0x0000000189EB5BFC-0x0000000189EB5E1C
			private static int _SetTriggerEffectSlope(int handle, TriggerMask mask, TriggerSlopeFeedbackEffect slopeL2, TriggerSlopeFeedbackEffect slopeR2); // 0x0000000189EB5770-0x0000000189EB59DC
			private static int _SetTriggerEffectMultiPosition(int handle, TriggerMask mask, TriggerMultiPositionFeedbackEffect paramL2, TriggerMultiPositionFeedbackEffect paramR2); // 0x0000000189EB55B8-0x0000000189EB5770
			private static int _SetTriggerEffectMultiPositionVibration(int handle, TriggerMask mask, TriggerMultiPositionVibrationEffect paramL2, TriggerMultiPositionVibrationEffect paramR2); // 0x0000000189EB53B0-0x0000000189EB55B8
		}
	}

	public enum ScePadType // TypeDefIndex: 63411
	{
		SCE_PAD_PORT_TYPE_STANDARD = 0,
		SCE_PAD_PORT_TYPE_SPECIAL = 2,
		SCE_PAD_PORT_TYPE_REMOTE_CONTROL = 16
	}

	public enum ScePadSupportBusType // TypeDefIndex: 63412
	{
		SCE_PAD_SUPPORT_BUS_TYPE_USB = 0,
		SCE_PAD_SUPPORT_BUS_TYPE_USB_BT = 1
	}

	public enum ScePadVibrationMode // TypeDefIndex: 63413
	{
		SCE_PAD_VIBRATION_MODE_ADVANCED = 1,
		SCE_PAD_VIBRATION_MODE_COMPATIBLE = 2,
		SCE_PAD_VIBRATION_MODE_COMPATIBLE2 = 3,
		SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE = 4,
		SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE2 = 5
	}

	public enum ScePadAudioOutPath // TypeDefIndex: 63414
	{
		SCE_PAD_AUDIO_OUT_PATH_STEREO_HEADSET = 0,
		SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET = 1,
		SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET_SPEAKER = 2,
		SCE_PAD_AUDIO_OUT_PATH_SPEAKER = 3,
		SCE_PAD_AUDIO_OUT_PATH_OFF = 4
	}

	public enum ScePadHeadsetType // TypeDefIndex: 63415
	{
		SCE_PAD_HEADSET_TYPE_NONE = 0,
		SCE_PAD_HEADSET_TYPE_HEADPHONE = 1,
		SCE_PAD_HEADSET_TYPE_HEADSET = 2
	}

	public enum ScePadTriggerEffectMode // TypeDefIndex: 63416
	{
		SCE_PAD_TRIGGER_EFFECT_MODE_OFF = 0,
		SCE_PAD_TRIGGER_EFFECT_MODE_FEEDBACK = 1,
		SCE_PAD_TRIGGER_EFFECT_MODE_WEAPON = 2,
		SCE_PAD_TRIGGER_EFFECT_MODE_VIBRATION = 3,
		SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_FEEDBACK = 4,
		SCE_PAD_TRIGGER_EFFECT_MODE_SLOPE_FEEDBACK = 5,
		SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_VIBRATION = 6
	}

	public enum ScePadTriggerEffectState // TypeDefIndex: 63417
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
	public enum TriggerMask : byte // TypeDefIndex: 63418
	{
		NONE = 0,
		L2 = 1,
		R2 = 2,
		ALL = 3
	}

	[Serializable]
	public struct TriggerEffectCommandUnion // TypeDefIndex: 63419
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
	public struct TriggerFeedbackEffect // TypeDefIndex: 63420
	{
		// Fields
		[Range(0f, 9f)]
		public byte position; // 0x00
		[Range(0f, 8f)]
		public byte strength; // 0x01
	}

	[Serializable]
	public struct TriggerWeaponEffect // TypeDefIndex: 63421
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
	public struct TriggerVibrationEffect // TypeDefIndex: 63422
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
	public struct TriggerSlopeFeedbackEffect // TypeDefIndex: 63423
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
	public struct TriggerMultiPositionFeedbackEffect // TypeDefIndex: 63424
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
	public struct TriggerMultiPositionVibrationEffect // TypeDefIndex: 63425
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
	public struct ScePadTouchPadInformation // TypeDefIndex: 63426
	{
		// Fields
		public float pixelDensity; // 0x00
		public ushort resolutionX; // 0x04
		public ushort resolutionY; // 0x06
	}

	[Serializable]
	public struct ScePadStickInformation // TypeDefIndex: 63427
	{
		// Fields
		public byte deadZoneLeft; // 0x00
		public byte deadZoneRight; // 0x01
	}

	[Serializable]
	public struct ScePadAnalogStick // TypeDefIndex: 63428
	{
		// Fields
		public byte x; // 0x00
		public byte y; // 0x01
	}

	[Serializable]
	public struct ScePadAnalogButtons // TypeDefIndex: 63429
	{
		// Fields
		public byte l2; // 0x00
		public byte r2; // 0x01
	}

	[Serializable]
	public struct ScePadData // TypeDefIndex: 63430
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
		internal ScePadData(ScePadDataInternal data); // 0x0000000184DA2FF0-0x0000000184DA3080
	}

	public struct ScePadControllerInformation // TypeDefIndex: 63431
	{
		// Fields
		public ScePadTouchPadInformation touchPadInfo; // 0x00
		public ScePadStickInformation stickInfo; // 0x08
		public byte connectionType; // 0x0A
		public byte connectionCount; // 0x0B
		public bool connected; // 0x0C
	
		// Constructors
		internal ScePadControllerInformation(ScePadControllerInformationInternal info); // 0x0000000184DA2FC0-0x0000000184DA2FF0
	}

	internal static class LibScePadInvoke // TypeDefIndex: 63432
	{
		// Fields
		private const string LibName = "libScePad"; // Metadata: 0x0235281E
	
		// Methods
		internal static extern int IsSupportedAudioFunction(int handle); // 0x0000000189EB405C-0x0000000189EB40D4
		internal static extern int SetAudioOutPath(int handle, ScePadAudioOutPath path); // 0x0000000189EB45B8-0x0000000189EB4638
		internal static extern int SetVolumeGain(int handle, in ScePadVolumeGainInternal gain); // 0x0000000189EB4D88-0x0000000189EB4E08
		internal static extern int GetJackState(int handle, [In, Out] ScePadJackStateInternal headSetType); // 0x0000000189EB3EF4-0x0000000189EB3F74
		internal static extern int Init(); // 0x0000000189EB3FF4-0x0000000189EB405C
		internal static extern int Init3_WindowsOnly(ScePadInit3ParamInternal init3Param); // 0x0000000183826D50-0x0000000183826DF0
		internal static extern int Close(int handle); // 0x0000000189EB3CDC-0x0000000189EB3D54
		internal static extern int Open(int userId, ScePadType type, int index, IntPtr param); // 0x0000000189EB40D4-0x0000000189EB4170
		internal static extern int GetHandle(int userId, ScePadType type, int index); // 0x0000000189EB3E68-0x0000000189EB3EF4
		internal static extern int ResetLightBar(int handle); // 0x0000000189EB43C8-0x0000000189EB4440
		internal static extern int SetLightBar(int handle, in ScePadColorInternal color); // 0x0000000189EB4638-0x0000000189EB46B8
		internal static extern int ReadState(int handle, [In, Out] ScePadDataInternal data); // 0x0000000189EB4170-0x0000000189EB4294
		internal static extern int Read(int handle, [In, Out] ScePadDataInternal data, int num); // 0x0000000189EB4294-0x0000000189EB43C8
		internal static extern int GetControllerInformation(int handle, [In, Out] ScePadControllerInformationInternal info); // 0x0000000189EB3D54-0x0000000189EB3E68
		internal static extern int SetMotionSensorState(int handle, bool enable); // 0x0000000189EB46B8-0x0000000189EB4738
		internal static extern int SetTiltCorrectionState(int handle, bool enable); // 0x0000000189EB4738-0x0000000189EB47B8
		internal static extern int SetAngularVelocityDeadbandState(int handle, bool enable); // 0x0000000189EB4538-0x0000000189EB45B8
		internal static extern int SetAngularVelocityBiasCorrectionState(int handle, bool enable); // 0x0000000189EB44B8-0x0000000189EB4538
		internal static extern int ResetOrientation(int handle); // 0x0000000189EB4440-0x0000000189EB44B8
		internal static extern int SetVibrationMode(int handle, ScePadVibrationMode mode); // 0x0000000189EB4C88-0x0000000189EB4D08
		internal static extern int SetVibration(int handle, in ScePadVibrationParamInternal mode); // 0x0000000189EB4D08-0x0000000189EB4D88
		internal static extern int GetTriggerEffectState(int handle, [In, Out] ScePadTriggerEffectStateInformationInternal info); // 0x0000000189EB3F74-0x0000000189EB3FF4
		internal static extern int SetTriggerEffectOff(int handle, in ScePadTriggerEffectOffParamIternal param); // 0x0000000189EB49C8-0x0000000189EB4A78
		internal static extern int SetTriggerEffectFeedback(int handle, in ScePadTriggerFeedbackEffectParamInternal param); // 0x0000000189EB47B8-0x0000000189EB4868
		internal static extern int SetTriggerEffectVibration(int handle, in ScePadTriggerVibrationEffectParamInternal param); // 0x0000000189EB4B28-0x0000000189EB4BD8
		internal static extern int SetTriggerEffectWeapon(int handle, in ScePadTriggerWeaponEffectParamInternal param); // 0x0000000189EB4BD8-0x0000000189EB4C88
		internal static extern int SetTriggerEffectSlope(int handle, in ScePadTriggerSlopeFeedbackEffectParamInternal param); // 0x0000000189EB4A78-0x0000000189EB4B28
		internal static extern int SetTriggerEffectMultiPosition(int handle, in ScePadTriggerMultiPositionFeedbackEffectParamInternal param); // 0x0000000189EB4918-0x0000000189EB49C8
		internal static extern int SetTriggerEffectMultiPositionVibration(int handle, in ScePadTriggerMultiPositionVibrationEffectParamInternal param); // 0x0000000189EB4868-0x0000000189EB4918
	}

	internal struct ScePadColorInternal // TypeDefIndex: 63433
	{
		// Fields
		public byte r; // 0x00
		public byte g; // 0x01
		public byte b; // 0x02
		public byte reserved; // 0x03
	}

	internal struct ScePadInit3ParamInternal // TypeDefIndex: 63435
	{
		// Fields
		public IntPtr allocFunc; // 0x00
		public IntPtr freeFunc; // 0x08
		public ScePadSupportBusType supportBusType; // 0x10
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x14
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 63434
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadDataInternal // TypeDefIndex: 63438
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
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 63436
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _deviceUniqueData_e__FixedBuffer // TypeDefIndex: 63437
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadControllerInformationInternal // TypeDefIndex: 63440
	{
		// Fields
		public ScePadTouchPadInformation touchPadInfo; // 0x00
		public ScePadStickInformation stickInfo; // 0x08
		public byte connectionType; // 0x0A
		public byte connectionCount; // 0x0B
		public bool connected; // 0x0C
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x0D
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63439
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadVibrationParamInternal // TypeDefIndex: 63441
	{
		// Fields
		public byte largeMotor; // 0x00
		public byte smallMotor; // 0x01
	}

	internal struct ScePadAnalogButtonsInternal // TypeDefIndex: 63443
	{
		// Fields
		public byte l2; // 0x00
		public byte r2; // 0x01
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x02
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63442
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTouchDataInternal // TypeDefIndex: 63445
	{
		// Fields
		public byte touchNum; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x01
		private uint reserve1; // 0x04
		public ScePadTouchInternal touch1; // 0x08
		public ScePadTouchInternal touch2; // 0x10
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 63444
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTouchInternal // TypeDefIndex: 63447
	{
		// Fields
		public ushort x; // 0x00
		public ushort y; // 0x02
		public byte id; // 0x04
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x05
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 63446
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadOpenParamInternal // TypeDefIndex: 63449
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ uint reserve[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 63448
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	}

	internal struct ScePadExtensionUnitDataInternal // TypeDefIndex: 63452
	{
		// Fields
		public uint extensionUnitId; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x04
		public byte dateLength; // 0x05
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x06
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 63450
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 63451
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadVolumeGainInternal // TypeDefIndex: 63453
	{
		// Fields
		public byte speakerVol; // 0x00
		public byte jackVol; // 0x01
		private byte reserved; // 0x02
		public byte micGain; // 0x03
	}

	internal struct ScePadJackStateInternal // TypeDefIndex: 63455
	{
		// Fields
		public ScePadHeadsetType headsetType; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x04
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 63454
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct SceFVector3Internal // TypeDefIndex: 63456
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
	}

	internal struct SceFQuaternionInternal // TypeDefIndex: 63457
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
	}

	internal struct ScePadTriggerEffectOffParamIternal // TypeDefIndex: 63461
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 63459
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x04
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct ___e__FixedBuffer // TypeDefIndex: 63458
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63460
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerFeedbackEffectParamInternal // TypeDefIndex: 63466
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 63464
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte position; // 0x08
			public byte strength; // 0x09
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x0A
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __1_e__FixedBuffer // TypeDefIndex: 63462
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 63463
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63465
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerWeaponEffectParamInternal // TypeDefIndex: 63471
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 63469
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte startPosition; // 0x08
			public byte endPosition; // 0x09
			public byte strength; // 0x0A
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x0B
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __1_e__FixedBuffer // TypeDefIndex: 63467
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 63468
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63470
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerVibrationEffectParamInternal // TypeDefIndex: 63476
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 63474
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte position; // 0x08
			public byte amplitude; // 0x09
			public byte frequency; // 0x0A
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x0B
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __1_e__FixedBuffer // TypeDefIndex: 63472
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 63473
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63475
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerSlopeFeedbackEffectParamInternal // TypeDefIndex: 63481
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 63479
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte startPosition; // 0x08
			public byte endPosition; // 0x09
			public byte startStrength; // 0x0A
			public byte endStrength; // 0x0B
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x0C
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __1_e__FixedBuffer // TypeDefIndex: 63477
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 63478
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63480
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerMultiPositionFeedbackEffectParamInternal // TypeDefIndex: 63487
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 63485
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public unsafe fixed /* 0x00000000-0x00000000 */ byte strength[0]; // 0x08
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x12
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __1_e__FixedBuffer // TypeDefIndex: 63482
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _strength_e__FixedBuffer // TypeDefIndex: 63483
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 63484
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63486
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerMultiPositionVibrationEffectParamInternal // TypeDefIndex: 63493
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 63491
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public byte frequency; // 0x08
			public unsafe fixed /* 0x00000000-0x00000000 */ byte amplitude[0]; // 0x09
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x13
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __1_e__FixedBuffer // TypeDefIndex: 63488
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _amplitude_e__FixedBuffer // TypeDefIndex: 63489
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 63490
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 63492
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerEffectStateInformationInternal // TypeDefIndex: 63495
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ int state[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _state_e__FixedBuffer // TypeDefIndex: 63494
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	}
}
