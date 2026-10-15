/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 112: LibScePad.Runtime.dll - Assembly: LibScePad.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90854-90943

namespace Plugins.LibScePad
{
	public static class LibScePad // TypeDefIndex: 90858
	{
		// Fields
		private static bool s_available; // 0x00
	
		// Properties
		public static bool available { get; } // 0x000000018C2EB05C-0x000000018C2EB094 
	
		// Nested types
		public static class Audio // TypeDefIndex: 90855
		{
			// Methods
			public static int IsSupportAudioFunction(int handle); // 0x000000018C2E9710-0x000000018C2E9760
			public static int SetAudioOutPath(int handle, ScePadAudioOutPath path); // 0x000000018C2E9760-0x000000018C2E97BC
			public static int SetVolumeGain(int handle, byte speakerVol, byte jackVol, byte micGain); // 0x000000018C2E97BC-0x000000018C2E985C
			public static ScePadHeadsetType GetHeadSetType(int handle); // 0x000000018C2E96A0-0x000000018C2E9710
		}
	
		public static class Basic // TypeDefIndex: 90856
		{
			// Methods
			public static int Init(); // 0x00000001869797D0-0x0000000186979820
			public static int GetOrOpen(int userId, ScePadType type); // 0x000000018C2E99C8-0x000000018C2E9A38
			public static int GetHandle(int userId, ScePadType type); // 0x000000018C2E9968-0x000000018C2E99C8
			public static int Close(int handle); // 0x000000018C2E985C-0x000000018C2E98AC
			public static int ResetLightBar(int handle); // 0x000000018C2E9B64-0x000000018C2E9BB4
			public static int SetLightBar(int handle, UnityEngine.Color color); // 0x000000018C2E9CBC-0x000000018C2E9D50
			public static int SetLightBar(int handle, byte r, byte g, byte b); // 0x000000018C2E9D50-0x000000018C2E9DF0
			public static int GetControllerInformation(int handle, out ScePadControllerInformation info); // 0x000000018C2E98AC-0x000000018C2E9968
			public static int ReadState(int handle, out ScePadData data); // 0x000000018C2E9A38-0x000000018C2E9B64
			public static int SetMotionSensorState(int handle, bool enable); // 0x000000018C2E9DF0-0x000000018C2E9E4C
			public static int SetTiltCorrectionState(int handle, bool enable); // 0x000000018C2E9E4C-0x000000018C2E9EA8
			public static int SetAngularVelocityDeadbandState(int handle, bool enable); // 0x000000018C2E9C60-0x000000018C2E9CBC
			public static int SetAngularVelocityBiasCorrectionState(int handle, bool enable); // 0x000000018C2E9C04-0x000000018C2E9C60
			public static int ResetOrientation(int handle); // 0x000000018C2E9BB4-0x000000018C2E9C04
			public static int SetVibrationMode(int handle, ScePadVibrationMode mode); // 0x000000018C2E9EA8-0x000000018C2E9F04
			private static int _InitWithBluetooth(); // 0x0000000186979820-0x0000000186979870
		}
	
		public static class Trigger // TypeDefIndex: 90857
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
			static Trigger(); // 0x000000018C2EC0C8-0x000000018C2EC2C4
	
			// Methods
			public static int GetTriggerEffectStates(int handle, out ScePadTriggerEffectState l2, out ScePadTriggerEffectState r2); // 0x000000018C2EB094-0x000000018C2EB120
			public static int SetTriggerEffectOff(int handle, TriggerMask mask); // 0x000000018C2EB120-0x000000018C2EB22C
			public static int SetTriggerEffect(int handle, TriggerEffectCommandUnion command); // 0x000000018C2EB22C-0x000000018C2EB468
			private static int _SetTriggerEffectFeedback(int handle, TriggerMask mask, TriggerFeedbackEffect paramL2, TriggerFeedbackEffect paramR2); // 0x000000018C2EB468-0x000000018C2EB634
			private static int _SetTriggerEffectVibration(int handle, TriggerMask mask, TriggerVibrationEffect paramL2, TriggerVibrationEffect paramR2); // 0x000000018C2EBC78-0x000000018C2EBEA0
			private static int _SetTriggerEffectWeapon(int handle, TriggerMask mask, TriggerWeaponEffect paramL2, TriggerWeaponEffect paramR2); // 0x000000018C2EBEA0-0x000000018C2EC0C8
			private static int _SetTriggerEffectSlope(int handle, TriggerMask mask, TriggerSlopeFeedbackEffect slopeL2, TriggerSlopeFeedbackEffect slopeR2); // 0x000000018C2EBA04-0x000000018C2EBC78
			private static int _SetTriggerEffectMultiPosition(int handle, TriggerMask mask, TriggerMultiPositionFeedbackEffect paramL2, TriggerMultiPositionFeedbackEffect paramR2); // 0x000000018C2EB844-0x000000018C2EBA04
			private static int _SetTriggerEffectMultiPositionVibration(int handle, TriggerMask mask, TriggerMultiPositionVibrationEffect paramL2, TriggerMultiPositionVibrationEffect paramR2); // 0x000000018C2EB634-0x000000018C2EB844
		}
	}

	public enum ScePadType // TypeDefIndex: 90859
	{
		SCE_PAD_PORT_TYPE_STANDARD = 0,
		SCE_PAD_PORT_TYPE_SPECIAL = 2,
		SCE_PAD_PORT_TYPE_REMOTE_CONTROL = 16
	}

	public enum ScePadSupportBusType // TypeDefIndex: 90860
	{
		SCE_PAD_SUPPORT_BUS_TYPE_USB = 0,
		SCE_PAD_SUPPORT_BUS_TYPE_USB_BT = 1
	}

	public enum ScePadVibrationMode // TypeDefIndex: 90861
	{
		SCE_PAD_VIBRATION_MODE_ADVANCED = 1,
		SCE_PAD_VIBRATION_MODE_COMPATIBLE = 2,
		SCE_PAD_VIBRATION_MODE_COMPATIBLE2 = 3,
		SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE = 4,
		SCE_PAD_VIBRATION_MODE_ADVANCED_AND_COMPATIBLE2 = 5
	}

	public enum ScePadAudioOutPath // TypeDefIndex: 90862
	{
		SCE_PAD_AUDIO_OUT_PATH_STEREO_HEADSET = 0,
		SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET = 1,
		SCE_PAD_AUDIO_OUT_PATH_MONO_HEADSET_SPEAKER = 2,
		SCE_PAD_AUDIO_OUT_PATH_SPEAKER = 3,
		SCE_PAD_AUDIO_OUT_PATH_OFF = 4
	}

	public enum ScePadHeadsetType // TypeDefIndex: 90863
	{
		SCE_PAD_HEADSET_TYPE_NONE = 0,
		SCE_PAD_HEADSET_TYPE_HEADPHONE = 1,
		SCE_PAD_HEADSET_TYPE_HEADSET = 2
	}

	public enum ScePadTriggerEffectMode // TypeDefIndex: 90864
	{
		SCE_PAD_TRIGGER_EFFECT_MODE_OFF = 0,
		SCE_PAD_TRIGGER_EFFECT_MODE_FEEDBACK = 1,
		SCE_PAD_TRIGGER_EFFECT_MODE_WEAPON = 2,
		SCE_PAD_TRIGGER_EFFECT_MODE_VIBRATION = 3,
		SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_FEEDBACK = 4,
		SCE_PAD_TRIGGER_EFFECT_MODE_SLOPE_FEEDBACK = 5,
		SCE_PAD_TRIGGER_EFFECT_MODE_MULTIPLE_POSITION_VIBRATION = 6
	}

	public enum ScePadTriggerEffectState // TypeDefIndex: 90865
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
	public enum TriggerMask : byte // TypeDefIndex: 90866
	{
		NONE = 0,
		L2 = 1,
		R2 = 2,
		ALL = 3
	}

	[Serializable]
	public struct TriggerEffectCommandUnion // TypeDefIndex: 90867
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
	public struct TriggerFeedbackEffect // TypeDefIndex: 90868
	{
		// Fields
		[Range(0f, 9f)]
		public byte position; // 0x00
		[Range(0f, 8f)]
		public byte strength; // 0x01
	}

	[Serializable]
	public struct TriggerWeaponEffect // TypeDefIndex: 90869
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
	public struct TriggerVibrationEffect // TypeDefIndex: 90870
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
	public struct TriggerSlopeFeedbackEffect // TypeDefIndex: 90871
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
	public struct TriggerMultiPositionFeedbackEffect // TypeDefIndex: 90872
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
	public struct TriggerMultiPositionVibrationEffect // TypeDefIndex: 90873
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
	public struct ScePadTouchPadInformation // TypeDefIndex: 90874
	{
		// Fields
		public float pixelDensity; // 0x00
		public ushort resolutionX; // 0x04
		public ushort resolutionY; // 0x06
	}

	[Serializable]
	public struct ScePadStickInformation // TypeDefIndex: 90875
	{
		// Fields
		public byte deadZoneLeft; // 0x00
		public byte deadZoneRight; // 0x01
	}

	[Serializable]
	public struct ScePadAnalogStick // TypeDefIndex: 90876
	{
		// Fields
		public byte x; // 0x00
		public byte y; // 0x01
	}

	[Serializable]
	public struct ScePadAnalogButtons // TypeDefIndex: 90877
	{
		// Fields
		public byte l2; // 0x00
		public byte r2; // 0x01
	}

	[Serializable]
	public struct ScePadData // TypeDefIndex: 90878
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
		internal ScePadData(ScePadDataInternal data); // 0x0000000187250C10-0x0000000187250CA0
	}

	public struct ScePadControllerInformation // TypeDefIndex: 90879
	{
		// Fields
		public ScePadTouchPadInformation touchPadInfo; // 0x00
		public ScePadStickInformation stickInfo; // 0x08
		public byte connectionType; // 0x0A
		public byte connectionCount; // 0x0B
		public bool connected; // 0x0C
	
		// Constructors
		internal ScePadControllerInformation(ScePadControllerInformationInternal info); // 0x0000000187250BE0-0x0000000187250C10
	}

	internal static class LibScePadInvoke // TypeDefIndex: 90880
	{
		// Fields
		private const string LibName = "libScePad"; // Metadata: 0x0264B1B6
	
		// Methods
		internal static extern int IsSupportedAudioFunction(int handle); // 0x000000018C2EA290-0x000000018C2EA308
		internal static extern int SetAudioOutPath(int handle, ScePadAudioOutPath path); // 0x000000018C2EA7F8-0x000000018C2EA878
		internal static extern int SetVolumeGain(int handle, in ScePadVolumeGainInternal gain); // 0x000000018C2EAFD8-0x000000018C2EB05C
		internal static extern int GetJackState(int handle, [In, Out] ScePadJackStateInternal headSetType); // 0x000000018C2EA120-0x000000018C2EA1A4
		internal static extern int Init(); // 0x000000018C2EA228-0x000000018C2EA290
		internal static extern int Init3_WindowsOnly(ScePadInit3ParamInternal init3Param); // 0x0000000185AFCEF0-0x0000000185AFCF90
		internal static extern int Close(int handle); // 0x000000018C2E9F04-0x000000018C2E9F7C
		internal static extern int Open(int userId, ScePadType type, int index, IntPtr param); // 0x000000018C2EA308-0x000000018C2EA3A8
		internal static extern int GetHandle(int userId, ScePadType type, int index); // 0x000000018C2EA090-0x000000018C2EA120
		internal static extern int ResetLightBar(int handle); // 0x000000018C2EA600-0x000000018C2EA678
		internal static extern int SetLightBar(int handle, in ScePadColorInternal color); // 0x000000018C2EA878-0x000000018C2EA8FC
		internal static extern int ReadState(int handle, [In, Out] ScePadDataInternal data); // 0x000000018C2EA3A8-0x000000018C2EA4CC
		internal static extern int Read(int handle, [In, Out] ScePadDataInternal data, int num); // 0x000000018C2EA4CC-0x000000018C2EA600
		internal static extern int GetControllerInformation(int handle, [In, Out] ScePadControllerInformationInternal info); // 0x000000018C2E9F7C-0x000000018C2EA090
		internal static extern int SetMotionSensorState(int handle, bool enable); // 0x000000018C2EA8FC-0x000000018C2EA980
		internal static extern int SetTiltCorrectionState(int handle, bool enable); // 0x000000018C2EA980-0x000000018C2EAA04
		internal static extern int SetAngularVelocityDeadbandState(int handle, bool enable); // 0x000000018C2EA774-0x000000018C2EA7F8
		internal static extern int SetAngularVelocityBiasCorrectionState(int handle, bool enable); // 0x000000018C2EA6F0-0x000000018C2EA774
		internal static extern int ResetOrientation(int handle); // 0x000000018C2EA678-0x000000018C2EA6F0
		internal static extern int SetVibrationMode(int handle, ScePadVibrationMode mode); // 0x000000018C2EAED4-0x000000018C2EAF54
		internal static extern int SetVibration(int handle, in ScePadVibrationParamInternal mode); // 0x000000018C2EAF54-0x000000018C2EAFD8
		internal static extern int GetTriggerEffectState(int handle, [In, Out] ScePadTriggerEffectStateInformationInternal info); // 0x000000018C2EA1A4-0x000000018C2EA228
		internal static extern int SetTriggerEffectOff(int handle, in ScePadTriggerEffectOffParamIternal param); // 0x000000018C2EAC14-0x000000018C2EACC4
		internal static extern int SetTriggerEffectFeedback(int handle, in ScePadTriggerFeedbackEffectParamInternal param); // 0x000000018C2EAA04-0x000000018C2EAAB4
		internal static extern int SetTriggerEffectVibration(int handle, in ScePadTriggerVibrationEffectParamInternal param); // 0x000000018C2EAD74-0x000000018C2EAE24
		internal static extern int SetTriggerEffectWeapon(int handle, in ScePadTriggerWeaponEffectParamInternal param); // 0x000000018C2EAE24-0x000000018C2EAED4
		internal static extern int SetTriggerEffectSlope(int handle, in ScePadTriggerSlopeFeedbackEffectParamInternal param); // 0x000000018C2EACC4-0x000000018C2EAD74
		internal static extern int SetTriggerEffectMultiPosition(int handle, in ScePadTriggerMultiPositionFeedbackEffectParamInternal param); // 0x000000018C2EAB64-0x000000018C2EAC14
		internal static extern int SetTriggerEffectMultiPositionVibration(int handle, in ScePadTriggerMultiPositionVibrationEffectParamInternal param); // 0x000000018C2EAAB4-0x000000018C2EAB64
	}

	internal struct ScePadColorInternal // TypeDefIndex: 90881
	{
		// Fields
		public byte r; // 0x00
		public byte g; // 0x01
		public byte b; // 0x02
		public byte reserved; // 0x03
	}

	internal struct ScePadInit3ParamInternal // TypeDefIndex: 90883
	{
		// Fields
		public IntPtr allocFunc; // 0x00
		public IntPtr freeFunc; // 0x08
		public ScePadSupportBusType supportBusType; // 0x10
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x14
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 90882
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadDataInternal // TypeDefIndex: 90886
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
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 90884
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _deviceUniqueData_e__FixedBuffer // TypeDefIndex: 90885
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadControllerInformationInternal // TypeDefIndex: 90888
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
		public struct ___e__FixedBuffer // TypeDefIndex: 90887
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadVibrationParamInternal // TypeDefIndex: 90889
	{
		// Fields
		public byte largeMotor; // 0x00
		public byte smallMotor; // 0x01
	}

	internal struct ScePadAnalogButtonsInternal // TypeDefIndex: 90891
	{
		// Fields
		public byte l2; // 0x00
		public byte r2; // 0x01
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x02
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 90890
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTouchDataInternal // TypeDefIndex: 90893
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
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 90892
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTouchInternal // TypeDefIndex: 90895
	{
		// Fields
		public ushort x; // 0x00
		public ushort y; // 0x02
		public byte id; // 0x04
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x05
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 90894
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadOpenParamInternal // TypeDefIndex: 90897
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ uint reserve[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 90896
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	}

	internal struct ScePadExtensionUnitDataInternal // TypeDefIndex: 90900
	{
		// Fields
		public uint extensionUnitId; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x04
		public byte dateLength; // 0x05
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x06
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 90898
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 90899
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadVolumeGainInternal // TypeDefIndex: 90901
	{
		// Fields
		public byte speakerVol; // 0x00
		public byte jackVol; // 0x01
		private byte reserved; // 0x02
		public byte micGain; // 0x03
	}

	internal struct ScePadJackStateInternal // TypeDefIndex: 90903
	{
		// Fields
		public ScePadHeadsetType headsetType; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte reserve[0]; // 0x04
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reserve_e__FixedBuffer // TypeDefIndex: 90902
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct SceFVector3Internal // TypeDefIndex: 90904
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
	}

	internal struct SceFQuaternionInternal // TypeDefIndex: 90905
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
	}

	internal struct ScePadTriggerEffectOffParamIternal // TypeDefIndex: 90909
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 90907
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x04
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct ___e__FixedBuffer // TypeDefIndex: 90906
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 90908
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerFeedbackEffectParamInternal // TypeDefIndex: 90914
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 90912
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
			public struct __1_e__FixedBuffer // TypeDefIndex: 90910
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 90911
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 90913
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerWeaponEffectParamInternal // TypeDefIndex: 90919
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 90917
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
			public struct __1_e__FixedBuffer // TypeDefIndex: 90915
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 90916
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 90918
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerVibrationEffectParamInternal // TypeDefIndex: 90924
	{
		// Fields
		public byte triggerMask; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 90922
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
			public struct __1_e__FixedBuffer // TypeDefIndex: 90920
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 90921
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 90923
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerSlopeFeedbackEffectParamInternal // TypeDefIndex: 90929
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 90927
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
			public struct __1_e__FixedBuffer // TypeDefIndex: 90925
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 90926
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 90928
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerMultiPositionFeedbackEffectParamInternal // TypeDefIndex: 90935
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 90933
		{
			// Fields
			public ScePadTriggerEffectMode mode; // 0x00
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _1[0]; // 0x04
			public unsafe fixed /* 0x00000000-0x00000000 */ byte strength[0]; // 0x08
			private unsafe fixed /* 0x00000000-0x00000000 */ byte _2[0]; // 0x12
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __1_e__FixedBuffer // TypeDefIndex: 90930
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _strength_e__FixedBuffer // TypeDefIndex: 90931
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 90932
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 90934
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerMultiPositionVibrationEffectParamInternal // TypeDefIndex: 90941
	{
		// Fields
		public byte triggerMask; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte _[0]; // 0x01
		public Command[] command; // 0x08
	
		// Nested types
		public struct Command // TypeDefIndex: 90939
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
			public struct __1_e__FixedBuffer // TypeDefIndex: 90936
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _amplitude_e__FixedBuffer // TypeDefIndex: 90937
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct __2_e__FixedBuffer // TypeDefIndex: 90938
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct ___e__FixedBuffer // TypeDefIndex: 90940
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct ScePadTriggerEffectStateInformationInternal // TypeDefIndex: 90943
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ int state[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _state_e__FixedBuffer // TypeDefIndex: 90942
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	}
}
