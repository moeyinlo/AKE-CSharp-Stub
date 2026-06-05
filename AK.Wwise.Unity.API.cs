/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Image 29: AK.Wwise.Unity.API.dll - Assembly: AK.Wwise.Unity.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54096-54277

public class Ak3DAudioSinkCapabilities : IDisposable // TypeDefIndex: 54097
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkChannelConfig channelConfig { get => default; set {} } // 0x0000000186478AC0-0x0000000186478B3C 0x0000000186478CAC-0x0000000186478D14
	public uint uMaxSystemAudioObjects { get => default; set {} } // 0x0000000186478B8C-0x0000000186478BDC 0x0000000186478D68-0x0000000186478DBC
	public uint uAvailableSystemAudioObjects { get => default; set {} } // 0x0000000186478B3C-0x0000000186478B8C 0x0000000186478D14-0x0000000186478D68
	public bool bPassthrough { get => default; set {} } // 0x0000000186478A70-0x0000000186478AC0 0x0000000186478C58-0x0000000186478CAC
	public bool bMultiChannelObjects { get => default; set {} } // 0x0000000186478A20-0x0000000186478A70 0x0000000186478C04-0x0000000186478C58

	// Constructors
	internal Ak3DAudioSinkCapabilities(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public Ak3DAudioSinkCapabilities() {} // 0x00000001864789C0-0x0000000186478A10

	// Methods
	internal static IntPtr getCPtr(Ak3DAudioSinkCapabilities obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186478BDC-0x0000000186478C04
	~Ak3DAudioSinkCapabilities() {} // 0x000000018647894C-0x00000001864789C0
	public void Dispose() {} // 0x00000001864788FC-0x000000018647894C
	protected virtual void Dispose(bool disposing) {} // 0x00000001864787E8-0x00000001864788FC
}

public class Ak3dData : IDisposable // TypeDefIndex: 54098
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkTransform xform { get => default; set {} } // 0x00000001864790D4-0x0000000186479150 0x000000018647927C-0x00000001864792E4
	public float spread { get => default; set {} } // 0x0000000186479034-0x0000000186479084 0x00000001864791D0-0x0000000186479228
	public float focus { get => default; set {} } // 0x0000000186478FE4-0x0000000186479034 0x0000000186479178-0x00000001864791D0
	public uint uEmitterChannelMask { get => default; set {} } // 0x0000000186479084-0x00000001864790D4 0x0000000186479228-0x000000018647927C

	// Constructors
	internal Ak3dData(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public Ak3dData() {} // 0x0000000186478F94-0x0000000186478FE4

	// Methods
	internal static IntPtr getCPtr(Ak3dData obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186479150-0x0000000186479178
	~Ak3dData() {} // 0x0000000186478F20-0x0000000186478F94
	public void Dispose() {} // 0x0000000186478ED0-0x0000000186478F20
	protected virtual void Dispose(bool disposing) {} // 0x0000000186478DBC-0x0000000186478ED0
}

public enum Ak3DPositionType // TypeDefIndex: 54099
{
	AK_3DPositionType_Emitter = 0,
	AK_3DPositionType_EmitterWithAutomation = 1,
	AK_3DPositionType_ListenerWithAutomation = 2
}

public enum Ak3DSpatializationMode // TypeDefIndex: 54100
{
	AK_SpatializationMode_None = 0,
	AK_SpatializationMode_PositionOnly = 1,
	AK_SpatializationMode_PositionAndOrientation = 2
}

public class AkAcousticSurface : IDisposable // TypeDefIndex: 54101
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint textureID { get => default; set {} } // 0x00000001864796C0-0x0000000186479710 0x00000001864797DC-0x0000000186479830
	public float transmissionLoss { get => default; set {} } // 0x0000000186479710-0x0000000186479760 0x0000000186479830-0x0000000186479888
	public string strName { get => default; set {} } // 0x0000000186479654-0x00000001864796C0 0x0000000186479788-0x00000001864797DC

	// Constructors
	internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkAcousticSurface() {} // 0x0000000186479604-0x0000000186479654

	// Methods
	internal static IntPtr getCPtr(AkAcousticSurface obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186479760-0x0000000186479788
	~AkAcousticSurface() {} // 0x0000000186479550-0x00000001864795C4
	public void Dispose() {} // 0x00000001864793EC-0x000000018647943C
	protected virtual void Dispose(bool disposing) {} // 0x000000018647943C-0x0000000186479550
	public void Clear() {} // 0x00000001864792E4-0x0000000186479334
	public void DeleteName() {} // 0x000000018647939C-0x00000001864793EC
	public static int GetSizeOf() => default; // 0x00000001864795C4-0x0000000186479604
	public void Clone(AkAcousticSurface other) {} // 0x0000000186479334-0x000000018647939C
}

public enum AkActionOnEventType // TypeDefIndex: 54102
{
	AkActionOnEventType_Stop = 0,
	AkActionOnEventType_Pause = 1,
	AkActionOnEventType_Resume = 2,
	AkActionOnEventType_Break = 3,
	AkActionOnEventType_ReleaseEnvelope = 4
}

public enum AkAttenuationCurveType // TypeDefIndex: 54103
{
	AttenuationCurveID_VolumeDry = 0,
	AttenuationCurveID_VolumeAuxGameDef = 1,
	AttenuationCurveID_VolumeAuxUserDef = 2,
	AttenuationCurveID_LowPassFilter = 3,
	AttenuationCurveID_HighPassFilter = 4,
	AttenuationCurveID_Spread = 5,
	AttenuationCurveID_Focus = 6,
	AttenuationCurveID_ObstructionVolume = 7,
	AttenuationCurveID_ObstructionLPF = 8,
	AttenuationCurveID_ObstructionHPF = 9,
	AttenuationCurveID_OcclusionVolume = 10,
	AttenuationCurveID_OcclusionLPF = 11,
	AttenuationCurveID_OcclusionHPF = 12,
	AttenuationCurveID_DiffractionVolume = 13,
	AttenuationCurveID_DiffractionLPF = 14,
	AttenuationCurveID_DiffractionHPF = 15,
	AttenuationCurveID_TransmissionVolume = 16,
	AttenuationCurveID_TransmissionLPF = 17,
	AttenuationCurveID_TransmissionHPF = 18,
	AttenuationCurveID_MaxCount = 19,
	AttenuationCurveID_Project = 254,
	AttenuationCurveID_None = 255
}

public enum AkAudioDeviceState // TypeDefIndex: 54104
{
	AkDeviceState_Unknown = 0,
	AkDeviceState_Active = 1,
	AkDeviceState_Disabled = 2,
	AkDeviceState_NotPresent = 4,
	AkDeviceState_Unplugged = 8,
	AkDeviceState_All = 15
}

public class AkAudioFormat : IDisposable // TypeDefIndex: 54105
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uSampleRate { get => default; set {} } // 0x0000000186479E48-0x0000000186479E98 0x000000018647A074-0x000000018647A0C8
	public AkChannelConfig channelConfig { get => default; set {} } // 0x0000000186479CDC-0x0000000186479D58 0x0000000186479F10-0x0000000186479F78
	public uint uBitsPerSample { get => default; set {} } // 0x0000000186479D58-0x0000000186479DA8 0x0000000186479F78-0x0000000186479FCC
	public uint uBlockAlign { get => default; set {} } // 0x0000000186479DA8-0x0000000186479DF8 0x0000000186479FCC-0x000000018647A020
	public uint uTypeID { get => default; set {} } // 0x0000000186479E98-0x0000000186479EE8 0x000000018647A0C8-0x000000018647A11C
	public uint uInterleaveID { get => default; set {} } // 0x0000000186479DF8-0x0000000186479E48 0x000000018647A020-0x000000018647A074

	// Constructors
	internal AkAudioFormat(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkAudioFormat() {} // 0x0000000186479C8C-0x0000000186479CDC

	// Methods
	internal static IntPtr getCPtr(AkAudioFormat obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186479EE8-0x0000000186479F10
	~AkAudioFormat() {} // 0x00000001864799EC-0x0000000186479A60
	public void Dispose() {} // 0x0000000186479888-0x00000001864798D8
	protected virtual void Dispose(bool disposing) {} // 0x00000001864798D8-0x00000001864799EC
	public uint GetNumChannels() => default; // 0x0000000186479B50-0x0000000186479BA0
	public uint GetBitsPerSample() => default; // 0x0000000186479A60-0x0000000186479AB0
	public uint GetBlockAlign() => default; // 0x0000000186479AB0-0x0000000186479B00
	public uint GetTypeID() => default; // 0x0000000186479BA0-0x0000000186479BF0
	public uint GetInterleaveID() => default; // 0x0000000186479B00-0x0000000186479B50
	public void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID) {} // 0x0000000186479BF0-0x0000000186479C8C
}

public class AkAudioInterruptionCallbackInfo : IDisposable // TypeDefIndex: 54106
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public bool bEnterInterruption { get => default; } // 0x000000018647A344-0x000000018647A394 

	// Constructors
	internal AkAudioInterruptionCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkAudioInterruptionCallbackInfo() {} // 0x000000018647A2F4-0x000000018647A344

	// Methods
	internal static IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647A394-0x000000018647A3BC
	~AkAudioInterruptionCallbackInfo() {} // 0x000000018647A280-0x000000018647A2F4
	public void Dispose() {} // 0x000000018647A11C-0x000000018647A16C
	protected virtual void Dispose(bool disposing) {} // 0x000000018647A16C-0x000000018647A280
}

public enum AkAudioObjectDestination // TypeDefIndex: 54107
{
	eDefault = 0,
	eMainMix = 1,
	ePassthrough = 2,
	eSystemAudioObject = 3
}

public class AkAudioSettings : IDisposable // TypeDefIndex: 54108
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumSamplesPerFrame { get => default; set {} } // 0x000000018647A5E4-0x000000018647A634 0x000000018647A6AC-0x000000018647A700
	public uint uNumSamplesPerSecond { get => default; set {} } // 0x000000018647A634-0x000000018647A684 0x000000018647A700-0x000000018647A754

	// Constructors
	internal AkAudioSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkAudioSettings() {} // 0x000000018647A594-0x000000018647A5E4

	// Methods
	internal static IntPtr getCPtr(AkAudioSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647A684-0x000000018647A6AC
	~AkAudioSettings() {} // 0x000000018647A520-0x000000018647A594
	public void Dispose() {} // 0x000000018647A4D0-0x000000018647A520
	protected virtual void Dispose(bool disposing) {} // 0x000000018647A3BC-0x000000018647A4D0
}

public class AkAudioSourceChangeCallbackInfo : IDisposable // TypeDefIndex: 54109
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public bool bOtherAudioPlaying { get => default; } // 0x000000018647A97C-0x000000018647A9CC 

	// Constructors
	internal AkAudioSourceChangeCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkAudioSourceChangeCallbackInfo() {} // 0x000000018647A92C-0x000000018647A97C

	// Methods
	internal static IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647A9CC-0x000000018647A9F4
	~AkAudioSourceChangeCallbackInfo() {} // 0x000000018647A8B8-0x000000018647A92C
	public void Dispose() {} // 0x000000018647A754-0x000000018647A7A4
	protected virtual void Dispose(bool disposing) {} // 0x000000018647A7A4-0x000000018647A8B8
}

public class AkAuxSendValue : IDisposable // TypeDefIndex: 54110
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong listenerID { get => default; set {} } // 0x000000018647AE74-0x000000018647AEC4 0x000000018647AF98-0x000000018647AFEC
	public uint auxBusID { get => default; set {} } // 0x000000018647ADD4-0x000000018647AE24 0x000000018647AEEC-0x000000018647AF40
	public float fControlValue { get => default; set {} } // 0x000000018647AE24-0x000000018647AE74 0x000000018647AF40-0x000000018647AF98

	// Constructors
	public AkAuxSendValue() {} // Dummy constructor
	internal AkAuxSendValue(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40

	// Methods
	internal static IntPtr getCPtr(AkAuxSendValue obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647AEC4-0x000000018647AEEC
	~AkAuxSendValue() {} // 0x000000018647AB58-0x000000018647ABCC
	public void Dispose() {} // 0x000000018647A9F4-0x000000018647AA44
	protected virtual void Dispose(bool disposing) {} // 0x000000018647AA44-0x000000018647AB58
	public void Set(ulong listener, uint id, float value) {} // 0x000000018647AD5C-0x000000018647ADD4
	public bool IsSame(ulong listener, uint id) => default; // 0x000000018647AC0C-0x000000018647AC70
	public void Set(GameObject listener, uint id, float value) {} // 0x000000018647ACDC-0x000000018647AD5C
	public bool IsSame(GameObject listener, uint id) => default; // 0x000000018647AC70-0x000000018647ACDC
	public static int GetSizeOf() => default; // 0x000000018647ABCC-0x000000018647AC0C
}

public class AkBankCallbackInfo : IDisposable // TypeDefIndex: 54111
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint bankID { get => default; } // 0x0000000184597200-0x0000000184597260 
	public IntPtr inMemoryBankPtr { get => default; } // 0x00000001845970C0-0x0000000184597120 
	public AKRESULT loadResult { get => default; } // 0x0000000184597160-0x00000001845971C0 

	// Constructors
	internal AkBankCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkBankCallbackInfo() {} // 0x000000018647B060-0x000000018647B0B0

	// Methods
	internal static IntPtr getCPtr(AkBankCallbackInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018646F538-0x000000018646F560
	~AkBankCallbackInfo() {} // 0x000000018647AFEC-0x000000018647B060
	public void Dispose() {} // 0x00000001851C4B00-0x00000001851C4B60
	protected virtual void Dispose(bool disposing) {} // 0x00000001851C4B60-0x00000001851C5010
}

public enum AkBankContent // TypeDefIndex: 54112
{
	AkBankContent_StructureOnly = 0,
	AkBankContent_All = 1
}

public enum AkBankTypeEnum // TypeDefIndex: 54113
{
	AkBankType_User = 0,
	AkBankType_Event = 30,
	AkBankType_Bus = 31
}

public class AkBehavioralPositioningData : IDisposable // TypeDefIndex: 54114
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float center { get => default; set {} } // 0x000000018647B2D8-0x000000018647B328 0x000000018647B580-0x000000018647B5D8
	public float panLR { get => default; set {} } // 0x000000018647B418-0x000000018647B468 0x000000018647B6DC-0x000000018647B734
	public float panBF { get => default; set {} } // 0x000000018647B378-0x000000018647B3C8 0x000000018647B62C-0x000000018647B684
	public float panDU { get => default; set {} } // 0x000000018647B3C8-0x000000018647B418 0x000000018647B684-0x000000018647B6DC
	public float panSpatMix { get => default; set {} } // 0x000000018647B468-0x000000018647B4B8 0x000000018647B734-0x000000018647B78C
	public Ak3DSpatializationMode spatMode { get => default; set {} } // 0x000000018647B508-0x000000018647B558 0x000000018647B7E0-0x000000018647B834
	public AkSpeakerPanningType panType { get => default; set {} } // 0x000000018647B4B8-0x000000018647B508 0x000000018647B78C-0x000000018647B7E0
	public bool enableHeightSpread { get => default; set {} } // 0x000000018647B328-0x000000018647B378 0x000000018647B5D8-0x000000018647B62C

	// Constructors
	internal AkBehavioralPositioningData(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkBehavioralPositioningData() {} // 0x000000018647B288-0x000000018647B2D8

	// Methods
	internal static IntPtr getCPtr(AkBehavioralPositioningData obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647B558-0x000000018647B580
	~AkBehavioralPositioningData() {} // 0x000000018647B214-0x000000018647B288
	public void Dispose() {} // 0x000000018647B1C4-0x000000018647B214
	protected virtual void Dispose(bool disposing) {} // 0x000000018647B0B0-0x000000018647B1C4
}

public enum AkBusHierarchyFlags // TypeDefIndex: 54115
{
	AkBusHierarchy_Primary = 1,
	AkBusHierarchy_Secondary = 2,
	AkBusHierarchy_IsMaster = 128
}

public class AkCallbackInfo : IDisposable // TypeDefIndex: 54116
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pCookie { get => default; } // 0x0000000184CD9500-0x0000000184CD9560 
	public ulong gameObjID { get => default; } // 0x0000000184CD95E0-0x0000000184CD9650 

	// Constructors
	internal AkCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkCallbackInfo() {} // 0x000000018647B8AC-0x000000018647B8FC

	// Methods
	internal static IntPtr getCPtr(AkCallbackInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647365C-0x0000000186473684
	~AkCallbackInfo() {} // 0x000000018647B834-0x000000018647B8AC
	public void Dispose() {} // 0x000000018521B390-0x000000018521B450
	protected virtual void Dispose(bool disposing) {} // 0x0000000184EBA3F0-0x0000000184EBA8A0
}

public class AkCallbackSerializer : IDisposable // TypeDefIndex: 54117
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkCallbackSerializer(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkCallbackSerializer() {} // 0x000000018647BC08-0x000000018647BC58

	// Methods
	internal static IntPtr getCPtr(AkCallbackSerializer obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647BC58-0x000000018647BC80
	~AkCallbackSerializer() {} // 0x000000018647BAD0-0x000000018647BB44
	public void Dispose() {} // 0x000000018647B96C-0x000000018647B9BC
	protected virtual void Dispose(bool disposing) {} // 0x000000018647B9BC-0x000000018647BAD0
	public static AKRESULT Init() => default; // 0x00000001854FF040-0x00000001854FF080
	public static void Term() {} // 0x000000018647BBC8-0x000000018647BC08
	public static IntPtr Lock() => default; // 0x0000000184599270-0x00000001845992E0
	public static void Unlock() {} // 0x0000000184E6FB00-0x0000000184E6FB50
	public static void SetLocalOutput(uint in_uErrorLevel, string in_ip, uint in_port, string in_xmlFilePath, uint in_msXmlTranslatorTimeout, uint in_msWaapiTranslatorTimeout) {} // 0x000000018647BB44-0x000000018647BBC8
	public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie) => default; // 0x000000018647B8FC-0x000000018647B96C
}

public enum AkCallbackType // TypeDefIndex: 54118
{
	AK_EndOfEvent = 1,
	AK_EndOfDynamicSequenceItem = 2,
	AK_Marker = 4,
	AK_Duration = 8,
	AK_SpeakerVolumeMatrix = 16,
	AK_Starvation = 32,
	AK_MusicPlaylistSelect = 64,
	AK_MusicPlayStarted = 128,
	AK_MusicSyncBeat = 256,
	AK_MusicSyncBar = 512,
	AK_MusicSyncEntry = 1024,
	AK_MusicSyncExit = 2048,
	AK_MusicSyncGrid = 4096,
	AK_MusicSyncUserCue = 8192,
	AK_MusicSyncPoint = 16384,
	AK_MusicSyncAll = 32512,
	AK_MIDIEvent = 65536,
	AK_CallbackBits = 1048575,
	AK_EnableGetSourcePlayPosition = 1048576,
	AK_EnableGetMusicPlayPosition = 2097152,
	AK_EnableGetSourceStreamBuffering = 4194304,
	AK_Monitoring = 536870912,
	AK_AudioInterruption = 570425344,
	AK_AudioSourceChange = 587202560,
	AK_Bank = 1073741824
}

public class AkChannelConfig : IDisposable // TypeDefIndex: 54119
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumChannels { get => default; set {} } // 0x0000000184A84C60-0x0000000184A84CB0 0x000000018647C438-0x000000018647C48C
	public uint eConfigType { get => default; set {} } // 0x0000000184A84BD0-0x0000000184A84C20 0x000000018647C390-0x000000018647C3E4
	public uint uChannelMask { get => default; set {} } // 0x0000000184A84B40-0x0000000184A84B90 0x000000018647C3E4-0x000000018647C438

	// Constructors
	internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkChannelConfig() {} // 0x000000018647C2B4-0x000000018647C304
	public AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask) {} // 0x000000018647C304-0x000000018647C368

	// Methods
	internal static IntPtr getCPtr(AkChannelConfig obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647C368-0x000000018647C390
	~AkChannelConfig() {} // 0x000000018596CED0-0x000000018596CF20
	public void Dispose() {} // 0x000000018647BE04-0x000000018647BE54
	protected virtual void Dispose(bool disposing) {} // 0x000000018596CF20-0x000000018596D250
	public static AkChannelConfig Standard(uint in_uChannelMask) => default; // 0x000000018647C244-0x000000018647C2B4
	public static AkChannelConfig Anonymous(uint in_uNumChannels) => default; // 0x000000018647BCF0-0x000000018647BD60
	public static AkChannelConfig Ambisonic(uint in_uNumChannels) => default; // 0x000000018647BC80-0x000000018647BCF0
	public static AkChannelConfig Object() => default; // 0x000000018647BEA4-0x000000018647BF10
	public void Clear() {} // 0x000000018647BD60-0x000000018647BDB0
	public void SetStandard(uint in_uChannelMask) {} // 0x000000018647C1F0-0x000000018647C244
	public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask) {} // 0x000000018647C18C-0x000000018647C1F0
	public void SetAnonymous(uint in_uNumChannels) {} // 0x00000001856B5D40-0x00000001856B5DA0
	public void SetAmbisonic(uint in_uNumChannels) {} // 0x000000018647C048-0x000000018647C09C
	public void SetObject() {} // 0x000000018647C09C-0x000000018647C0EC
	public void SetSameAsMainMix() {} // 0x000000018647C0EC-0x000000018647C13C
	public void SetSameAsPassthrough() {} // 0x000000018647C13C-0x000000018647C18C
	public bool IsValid() => default; // 0x000000018647BE54-0x000000018647BEA4
	public uint Serialize() => default; // 0x000000018647BFF8-0x000000018647C048
	public void Deserialize(uint in_uChannelConfig) {} // 0x000000018647BDB0-0x000000018647BE04
	public AkChannelConfig RemoveLFE() => default; // 0x000000018647BF84-0x000000018647BFF8
	public AkChannelConfig RemoveCenter() => default; // 0x000000018647BF10-0x000000018647BF84
}

public enum AkChannelConfigType // TypeDefIndex: 54120
{
	AK_ChannelConfigType_Anonymous = 0,
	AK_ChannelConfigType_Standard = 1,
	AK_ChannelConfigType_Ambisonic = 2,
	AK_ChannelConfigType_Objects = 3,
	AK_ChannelConfigType_UseDeviceMain = 14,
	AK_ChannelConfigType_UseDevicePassthrough = 15
}

public class AkChannelEmitter : IDisposable // TypeDefIndex: 54121
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkWorldTransform position { get => default; set {} } // 0x000000018647C6D0-0x000000018647C74C 0x000000018647C818-0x000000018647C880
	public uint uInputChannels { get => default; set {} } // 0x000000018647C74C-0x000000018647C79C 0x000000018647C880-0x000000018647C8D4
	public string padding { get => default; set {} } // 0x000000018647C664-0x000000018647C6D0 0x000000018647C7C4-0x000000018647C818

	// Constructors
	public AkChannelEmitter() {} // Dummy constructor
	internal AkChannelEmitter(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40

	// Methods
	internal static IntPtr getCPtr(AkChannelEmitter obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647C79C-0x000000018647C7C4
	~AkChannelEmitter() {} // 0x000000018647C5F0-0x000000018647C664
	public void Dispose() {} // 0x000000018647C5A0-0x000000018647C5F0
	protected virtual void Dispose(bool disposing) {} // 0x000000018647C48C-0x000000018647C5A0
}

public enum AkChannelOrdering // TypeDefIndex: 54122
{
	ChannelOrdering_Standard = 0,
	ChannelOrdering_RunTime = 1
}

public enum AkConnectionType // TypeDefIndex: 54123
{
	ConnectionType_Direct = 0,
	ConnectionType_GameDefSend = 1,
	ConnectionType_UserDefSend = 2,
	ConnectionType_ReflectionsSend = 3
}

public enum AkCurveInterpolation // TypeDefIndex: 54124
{
	AkCurveInterpolation_Log3 = 0,
	AkCurveInterpolation_Sine = 1,
	AkCurveInterpolation_Log1 = 2,
	AkCurveInterpolation_InvSCurve = 3,
	AkCurveInterpolation_Linear = 4,
	AkCurveInterpolation_SCurve = 5,
	AkCurveInterpolation_Exp1 = 6,
	AkCurveInterpolation_SineRecip = 7,
	AkCurveInterpolation_Exp3 = 8,
	AkCurveInterpolation_LastFadeCurve = 8,
	AkCurveInterpolation_Constant = 9
}

public class AkDeviceDescription : IDisposable // TypeDefIndex: 54125
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint idDevice { get => default; set {} } // 0x0000000184A7A780-0x0000000184A7A7D0 0x000000018647D23C-0x000000018647D290
	public string deviceName { get => default; set {} } // 0x000000018647D0B0-0x000000018647D11C 0x000000018647D194-0x000000018647D1E8
	public AkAudioDeviceState deviceStateMask { get => default; set {} } // 0x000000018647D11C-0x000000018647D16C 0x000000018647D1E8-0x000000018647D23C
	public bool isDefaultDevice { get => default; set {} } // 0x0000000184A7A5C0-0x0000000184A7A620 0x000000018647D290-0x000000018647D2E4

	// Constructors
	internal AkDeviceDescription(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkDeviceDescription() {} // 0x000000018647D060-0x000000018647D0B0

	// Methods
	internal static IntPtr getCPtr(AkDeviceDescription obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647D16C-0x000000018647D194
	~AkDeviceDescription() {} // 0x0000000185628D30-0x0000000185628D80
	public void Dispose() {} // 0x000000018647CFD0-0x000000018647D020
	protected virtual void Dispose(bool disposing) {} // 0x0000000185628D80-0x0000000185629030
	public void Clear() {} // 0x000000018647CF18-0x000000018647CF68
	public static int GetSizeOf() => default; // 0x000000018647D020-0x000000018647D060
	public void Clone(AkDeviceDescription other) {} // 0x000000018647CF68-0x000000018647CFD0
}

public class AkDeviceSettings : IDisposable // TypeDefIndex: 54126
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pIOMemory { get => default; set {} } // 0x000000018647D424-0x000000018647D474 0x000000018647D6FC-0x000000018647D750
	public uint uIOMemorySize { get => default; set {} } // 0x000000018647D590-0x000000018647D5E0 0x0000000185501460-0x00000001855014C0
	public uint uIOMemoryAlignment { get => default; set {} } // 0x000000018647D540-0x000000018647D590 0x000000018647D80C-0x000000018647D860
	public uint ePoolAttributes { get => default; set {} } // 0x000000018647D384-0x000000018647D3D4 0x000000018647D6A8-0x000000018647D6FC
	public uint uGranularity { get => default; set {} } // 0x000000018647D4F0-0x000000018647D540 0x000000018647D7B8-0x000000018647D80C
	public AkThreadProperties threadProperties { get => default; set {} } // 0x000000018647D474-0x000000018647D4F0 0x000000018647D750-0x000000018647D7B8
	public float fTargetAutoStmBufferLength { get => default; set {} } // 0x000000018647D3D4-0x000000018647D424 0x00000001855013B0-0x0000000185501410
	public uint uMaxConcurrentIO { get => default; set {} } // 0x000000018647D630-0x000000018647D680 0x000000018647D860-0x000000018647D8B4
	public bool bUseStreamCache { get => default; set {} } // 0x000000018647D334-0x000000018647D384 0x0000000185501300-0x0000000185501360
	public uint uMaxCachePinnedBytes { get => default; set {} } // 0x000000018647D5E0-0x000000018647D630 0x0000000185501260-0x00000001855012C0

	// Constructors
	public AkDeviceSettings() {} // Dummy constructor
	internal AkDeviceSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40

	// Methods
	internal static IntPtr getCPtr(AkDeviceSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647D680-0x000000018647D6A8
	~AkDeviceSettings() {} // 0x0000000185AE59D0-0x0000000185AE5A20
	public void Dispose() {} // 0x000000018647D2E4-0x000000018647D334
	protected virtual void Dispose(bool disposing) {} // 0x0000000185AE5A20-0x0000000185AE5CD0
}

public class AkDiffractionPathInfo : IDisposable // TypeDefIndex: 54127
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18
	public const uint kMaxNodes = 8; // Metadata: 0x020795BE

	// Properties
	public AkVector64 emitterPos { get => default; set {} } // 0x000000018647DD48-0x000000018647DDB4 0x000000018647E040-0x000000018647E0AC
	public AkWorldTransform virtualPos { get => default; set {} } // 0x000000018647DF44-0x000000018647DFC0 0x000000018647E260-0x000000018647E2C8
	public uint nodeCount { get => default; set {} } // 0x000000018647DDB4-0x000000018647DE04 0x000000018647E0AC-0x000000018647E100
	public float diffraction { get => default; set {} } // 0x000000018647DCF8-0x000000018647DD48 0x000000018647DFE8-0x000000018647E040
	public float transmissionLoss { get => default; set {} } // 0x000000018647DEF4-0x000000018647DF44 0x000000018647E208-0x000000018647E260
	public float totLength { get => default; set {} } // 0x000000018647DEA4-0x000000018647DEF4 0x000000018647E1B0-0x000000018647E208
	public float obstructionValue { get => default; set {} } // 0x000000018647DE04-0x000000018647DE54 0x000000018647E100-0x000000018647E158
	public float occlusionValue { get => default; set {} } // 0x000000018647DE54-0x000000018647DEA4 0x000000018647E158-0x000000018647E1B0

	// Constructors
	internal AkDiffractionPathInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkDiffractionPathInfo() {} // 0x000000018647DCA8-0x000000018647DCF8

	// Methods
	internal static IntPtr getCPtr(AkDiffractionPathInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647DFC0-0x000000018647DFE8
	~AkDiffractionPathInfo() {} // 0x000000018647DA80-0x000000018647DAF4
	public void Dispose() {} // 0x000000018647D91C-0x000000018647D96C
	protected virtual void Dispose(bool disposing) {} // 0x000000018647D96C-0x000000018647DA80
	public static int GetSizeOf() => default; // 0x000000018647DC68-0x000000018647DCA8
	public Vector3 GetNodes(uint idx) => default; // 0x000000018647DB48-0x000000018647DBC0
	public float GetAngles(uint idx) => default; // 0x000000018647DAF4-0x000000018647DB48
	public ulong GetPortals(uint idx) => default; // 0x000000018647DBC0-0x000000018647DC14
	public ulong GetRooms(uint idx) => default; // 0x000000018647DC14-0x000000018647DC68
	public void Clone(AkDiffractionPathInfo other) {} // 0x000000018647D8B4-0x000000018647D91C
}

public class AkDurationCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 54128
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public float fDuration { get => default; } // 0x000000018647E4F8-0x000000018647E548 
	public float fEstimatedDuration { get => default; } // 0x000000018647E548-0x000000018647E598 
	public uint audioNodeID { get => default; } // 0x000000018647E458-0x000000018647E4A8 
	public uint mediaID { get => default; } // 0x000000018647E598-0x000000018647E5E8 
	public bool bStreaming { get => default; } // 0x000000018647E4A8-0x000000018647E4F8 

	// Constructors
	internal AkDurationCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185144810-0x0000000185144890
	public AkDurationCallbackInfo() {} // 0x000000018647E3F8-0x000000018647E448

	// Methods
	internal static IntPtr getCPtr(AkDurationCallbackInfo obj) => default; // 0x000000018647E448-0x000000018647E458
	internal override void setCPtr(IntPtr cPtr) {} // 0x000000018647E5E8-0x000000018647E648
	protected override void Dispose(bool disposing) {} // 0x000000018647E2C8-0x000000018647E3F8
}

public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo // TypeDefIndex: 54129
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get => default; } // 0x000000018647E878-0x000000018647E8C8 
	public uint audioNodeID { get => default; } // 0x000000018647E7D8-0x000000018647E828 
	public IntPtr pCustomInfo { get => default; } // 0x000000018647E828-0x000000018647E878 

	// Constructors
	internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185144340-0x00000001851443B0
	public AkDynamicSequenceItemCallbackInfo() {} // 0x000000018647E778-0x000000018647E7C8

	// Methods
	internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj) => default; // 0x000000018647E7C8-0x000000018647E7D8
	internal override void setCPtr(IntPtr cPtr) {} // 0x000000018647E8C8-0x000000018647E928
	protected override void Dispose(bool disposing) {} // 0x000000018647E648-0x000000018647E778
}

public enum AkDynamicSequenceType // TypeDefIndex: 54130
{
	DynamicSequenceType_SampleAccurate = 0,
	DynamicSequenceType_NormalTransition = 1
}

public class AkEventCallbackInfo : AkCallbackInfo // TypeDefIndex: 54131
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get => default; } // 0x000000018647E978-0x000000018647E9C8 
	public uint eventID { get => default; } // 0x0000000184CD9680-0x0000000184CD96F0 

	// Constructors
	internal AkEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001851446B0-0x0000000185144730
	public AkEventCallbackInfo() {} // 0x000000018647E928-0x000000018647E978

	// Methods
	internal static IntPtr getCPtr(AkEventCallbackInfo obj) => default; // 0x000000018647E7C8-0x000000018647E7D8
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000185144730-0x00000001851447D0
	protected override void Dispose(bool disposing) {} // 0x0000000184EB9F20-0x0000000184EBA3F0
}

public class AkExtent : IDisposable // TypeDefIndex: 54132
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float halfWidth { get => default; set {} } // 0x000000018647ED0C-0x000000018647ED5C 0x000000018647EE34-0x000000018647EE8C
	public float halfHeight { get => default; set {} } // 0x000000018647ECBC-0x000000018647ED0C 0x000000018647EDDC-0x000000018647EE34
	public float halfDepth { get => default; set {} } // 0x000000018647EC6C-0x000000018647ECBC 0x000000018647ED84-0x000000018647EDDC

	// Constructors
	internal AkExtent(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkExtent() {} // 0x000000018647EBA0-0x000000018647EBF0
	public AkExtent(float in_halfWidth, float in_halfHeight, float in_halfDepth) {} // 0x000000018647EBF0-0x000000018647EC6C

	// Methods
	internal static IntPtr getCPtr(AkExtent obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647ED5C-0x000000018647ED84
	~AkExtent() {} // 0x000000018647EB2C-0x000000018647EBA0
	public void Dispose() {} // 0x000000018647EADC-0x000000018647EB2C
	protected virtual void Dispose(bool disposing) {} // 0x000000018647E9C8-0x000000018647EADC
}

public class AkExternalSourceInfo : IDisposable // TypeDefIndex: 54133
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint iExternalSrcCookie { get => default; set {} } // 0x000000018647F190-0x000000018647F1E0 0x0000000184BDD940-0x0000000184BDD9A0
	public uint idCodec { get => default; set {} } // 0x000000018647F1E0-0x000000018647F230 0x0000000184BDD9F0-0x0000000184BDDA50
	public string szFile { get => default; set {} } // 0x000000018647F2D0-0x000000018647F33C 0x0000000184BDD880-0x0000000184BDD8F0
	public IntPtr pInMemory { get => default; set {} } // 0x000000018647F280-0x000000018647F2D0 0x000000018647F408-0x000000018647F45C
	public uint uiMemorySize { get => default; set {} } // 0x000000018647F33C-0x000000018647F38C 0x000000018647F45C-0x000000018647F4B0
	public uint idFile { get => default; set {} } // 0x000000018647F230-0x000000018647F280 0x000000018647F3B4-0x000000018647F408

	// Constructors
	internal AkExternalSourceInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkExternalSourceInfo() {} // 0x000000018647F0C0-0x000000018647F110
	public AkExternalSourceInfo(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec) {} // 0x000000018647F110-0x000000018647F190
	public AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec) {} // 0x000000018647F048-0x000000018647F0C0
	public AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec) {} // 0x000000018647EFD4-0x000000018647F048

	// Methods
	internal static IntPtr getCPtr(AkExternalSourceInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647F38C-0x000000018647F3B4
	~AkExternalSourceInfo() {} // 0x0000000185591280-0x00000001855912D0
	public void Dispose() {} // 0x000000018647EF44-0x000000018647EF94
	protected virtual void Dispose(bool disposing) {} // 0x00000001855912D0-0x0000000185591700
	public void Clear() {} // 0x000000018647EE8C-0x000000018647EEDC
	public void Clone(AkExternalSourceInfo other) {} // 0x000000018647EEDC-0x000000018647EF44
	public static int GetSizeOf() => default; // 0x000000018647EF94-0x000000018647EFD4
}

public enum AkFloorPlane // TypeDefIndex: 54134
{
	AkFloorPlane_XZ = 0,
	AkFloorPlane_Default = 0,
	AkFloorPlane_XY = 1,
	AkFloorPlane_YZ = 2
}

public class AkGeometryInstanceParams : IDisposable // TypeDefIndex: 54135
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkWorldTransform PositionAndOrientation { get => default; set {} } // 0x000000018647F6D8-0x000000018647F754 0x000000018647F834-0x000000018647F89C
	public Vector3 Scale { get => default; set {} } // 0x000000018647F754-0x000000018647F7BC 0x000000018647F89C-0x000000018647F904
	public bool UseForReflectionAndDiffraction { get => default; set {} } // 0x000000018647F7BC-0x000000018647F80C 0x000000018647F904-0x000000018647F958

	// Constructors
	internal AkGeometryInstanceParams(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkGeometryInstanceParams() {} // 0x000000018647F688-0x000000018647F6D8

	// Methods
	internal static IntPtr getCPtr(AkGeometryInstanceParams obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647F80C-0x000000018647F834
	~AkGeometryInstanceParams() {} // 0x000000018647F614-0x000000018647F688
	public void Dispose() {} // 0x000000018647F4B0-0x000000018647F500
	protected virtual void Dispose(bool disposing) {} // 0x000000018647F500-0x000000018647F614
}

public enum AkGlobalCallbackLocation // TypeDefIndex: 54136
{
	AkGlobalCallbackLocation_Register = 1,
	AkGlobalCallbackLocation_Begin = 2,
	AkGlobalCallbackLocation_PreProcessMessageQueueForRender = 4,
	AkGlobalCallbackLocation_PostMessagesProcessed = 8,
	AkGlobalCallbackLocation_Num = 13,
	AkGlobalCallbackLocation_BeginRender = 16,
	AkGlobalCallbackLocation_EndRender = 32,
	AkGlobalCallbackLocation_End = 64,
	AkGlobalCallbackLocation_Term = 128,
	AkGlobalCallbackLocation_Monitor = 256,
	AkGlobalCallbackLocation_MonitorRecap = 512,
	AkGlobalCallbackLocation_Init = 1024,
	AkGlobalCallbackLocation_Suspend = 2048,
	AkGlobalCallbackLocation_WakeupFromSuspend = 4096
}

public enum AkGroupType // TypeDefIndex: 54137
{
	AkGroupType_Switch = 0,
	AkGroupType_State = 1
}

public class AkImageSourceParams : IDisposable // TypeDefIndex: 54138
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkVector64 sourcePosition { get => default; set {} } // 0x000000018647FD4C-0x000000018647FDB8 0x000000018647FFE0-0x000000018648004C
	public float fDistanceScalingFactor { get => default; set {} } // 0x000000018647FC5C-0x000000018647FCAC 0x000000018647FED8-0x000000018647FF30
	public float fLevel { get => default; set {} } // 0x000000018647FCAC-0x000000018647FCFC 0x000000018647FF30-0x000000018647FF88
	public float fDiffraction { get => default; set {} } // 0x000000018647FC0C-0x000000018647FC5C 0x000000018647FE80-0x000000018647FED8
	public float fOcclusion { get => default; set {} } // 0x000000018647FCFC-0x000000018647FD4C 0x000000018647FF88-0x000000018647FFE0
	public byte uDiffractionEmitterSide { get => default; set {} } // 0x000000018647FDB8-0x000000018647FE08 0x000000018648004C-0x00000001864800A0
	public byte uDiffractionListenerSide { get => default; set {} } // 0x000000018647FE08-0x000000018647FE58 0x00000001864800A0-0x00000001864800F4

	// Constructors
	internal AkImageSourceParams(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkImageSourceParams() {} // 0x000000018647FB30-0x000000018647FB80
	public AkImageSourceParams(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel) {} // 0x000000018647FB80-0x000000018647FC0C

	// Methods
	internal static IntPtr getCPtr(AkImageSourceParams obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647FE58-0x000000018647FE80
	~AkImageSourceParams() {} // 0x000000018647FABC-0x000000018647FB30
	public void Dispose() {} // 0x000000018647F958-0x000000018647F9A8
	protected virtual void Dispose(bool disposing) {} // 0x000000018647F9A8-0x000000018647FABC
}

public class AkImageSourceSettings : IDisposable // TypeDefIndex: 54139
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkImageSourceParams params_ { get => default; set {} } // 0x00000001864803FC-0x0000000186480478 0x00000001864804A0-0x0000000186480508

	// Constructors
	internal AkImageSourceSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkImageSourceSettings() {} // 0x00000001864803AC-0x00000001864803FC
	public AkImageSourceSettings(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel) {} // 0x0000000186480320-0x00000001864803AC

	// Methods
	internal static IntPtr getCPtr(AkImageSourceSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186480478-0x00000001864804A0
	~AkImageSourceSettings() {} // 0x0000000186480258-0x00000001864802CC
	public void Dispose() {} // 0x0000000186480208-0x0000000186480258
	protected virtual void Dispose(bool disposing) {} // 0x00000001864800F4-0x0000000186480208
	public void SetOneTexture(uint in_texture) {} // 0x00000001864802CC-0x0000000186480320
}

public class AkInitializationSettings : IDisposable // TypeDefIndex: 54140
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkStreamMgrSettings streamMgrSettings { get => default; set {} } // 0x0000000185500B80-0x0000000185500C10 0x0000000186480F9C-0x0000000186481004
	public AkDeviceSettings deviceSettings { get => default; set {} } // 0x00000001854FFF20-0x00000001854FFFB0 0x0000000186480DFC-0x0000000186480E64
	public AkInitSettings initSettings { get => default; set {} } // 0x00000001854FFE50-0x00000001854FFEE0 0x0000000186480E64-0x0000000186480ECC
	public AkPlatformInitSettings platformSettings { get => default; set {} } // 0x00000001854FFD80-0x00000001854FFE10 0x0000000186480F34-0x0000000186480F9C
	public AkMusicSettings musicSettings { get => default; set {} } // 0x0000000185500AB0-0x0000000185500B40 0x0000000186480ECC-0x0000000186480F34
	public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings { get => default; set {} } // 0x00000001854FFCB0-0x00000001854FFD40 0x0000000186481004-0x000000018648106C
	public uint uMemAllocationSizeLimit { get => default; set {} } // 0x0000000186480CE4-0x0000000186480D34 0x00000001854FEEF0-0x00000001854FEF50
	public uint uMemDebugLevel { get => default; set {} } // 0x0000000186480D34-0x0000000186480D84 0x00000001855011C0-0x0000000185501220
	public uint uMemSpanCount { get => default; set {} } // 0x0000000186480D84-0x0000000186480DD4 0x0000000185501120-0x0000000185501180

	// Constructors
	internal AkInitializationSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkInitializationSettings() {} // 0x0000000185501000-0x0000000185501050

	// Methods
	internal static IntPtr getCPtr(AkInitializationSettings obj) => default; // 0x0000000183FD9A90-0x0000000183FD9AA0
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186480DD4-0x0000000186480DFC
	~AkInitializationSettings() {} // 0x0000000185BA5DF0-0x0000000185BA5E40
	public void Dispose() {} // 0x0000000186480C94-0x0000000186480CE4
	protected virtual void Dispose(bool disposing) {} // 0x0000000185BA5E40-0x0000000185BA6150
}

public class AkInitSettings : IDisposable // TypeDefIndex: 54141
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxNumPaths { get => default; set {} } // 0x0000000186480918-0x0000000186480968 0x00000001856B5470-0x00000001856B54D0
	public uint uCommandQueueSize { get => default; set {} } // 0x00000001864807D8-0x0000000186480828 0x00000001856B53D0-0x00000001856B5430
	public bool bEnableGameSyncPreparation { get => default; set {} } // 0x00000001864805A8-0x00000001864805F8 0x00000001854FED90-0x00000001854FEDF0
	public uint uContinuousPlaybackLookAhead { get => default; set {} } // 0x0000000186480828-0x0000000186480878 0x00000001854FECF0-0x00000001854FED50
	public uint uNumSamplesPerFrame { get => default; set {} } // 0x00000001864809B8-0x0000000186480A08 0x00000001856B5330-0x00000001856B5390
	public uint uMonitorQueuePoolSize { get => default; set {} } // 0x0000000186480968-0x00000001864809B8 0x00000001854FEC50-0x00000001854FECB0
	public uint uCpuMonitorQueueMaxSize { get => default; set {} } // 0x0000000186480878-0x00000001864808C8 0x0000000186480C40-0x0000000186480C94
	public AkOutputSettings settingsMainOutput { get => default; set {} } // 0x00000001856B5200-0x00000001856B5290 0x0000000186480B84-0x0000000186480BEC
	public uint uMaxHardwareTimeoutMs { get => default; set {} } // 0x00000001864808C8-0x0000000186480918 0x00000001854FEBB0-0x00000001854FEC10
	public bool bUseSoundBankMgrThread { get => default; set {} } // 0x0000000186480648-0x0000000186480698 0x0000000186480A84-0x0000000186480AD8
	public bool bUseLEngineThread { get => default; set {} } // 0x00000001864805F8-0x0000000186480648 0x0000000186480A30-0x0000000186480A84
	public string szPluginDLLPath { get => default; set {} } // 0x00000001856B50A0-0x00000001856B5120 0x00000001856B52D0-0x00000001856B5330
	public AkFloorPlane eFloorPlane { get => default; set {} } // 0x0000000186480698-0x00000001864806E8 0x0000000186480AD8-0x0000000186480B2C
	public float fGameUnitsToMeters { get => default; set {} } // 0x0000000186480738-0x0000000186480788 0x0000000186480B2C-0x0000000186480B84
	public uint uBankReadBufferSize { get => default; set {} } // 0x0000000186480788-0x00000001864807D8 0x0000000186480BEC-0x0000000186480C40
	public float fDebugOutOfRangeLimit { get => default; set {} } // 0x00000001864806E8-0x0000000186480738 0x00000001854FEB00-0x00000001854FEB60
	public bool bDebugOutOfRangeCheckEnabled { get => default; set {} } // 0x0000000186480558-0x00000001864805A8 0x00000001854FEA50-0x00000001854FEAB0

	// Constructors
	public AkInitSettings() {} // Dummy constructor
	internal AkInitSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40

	// Methods
	internal static IntPtr getCPtr(AkInitSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186480A08-0x0000000186480A30
	~AkInitSettings() {} // 0x0000000185AE56D0-0x0000000185AE5720
	public void Dispose() {} // 0x0000000186480508-0x0000000186480558
	protected virtual void Dispose(bool disposing) {} // 0x0000000185AE5720-0x0000000185AE59D0
}

public class AkIterator : IDisposable // TypeDefIndex: 54142
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkPlaylistItem pItem { get => default; set {} } // 0x00000001864814C0-0x000000018648153C 0x0000000186481564-0x00000001864815CC

	// Constructors
	internal AkIterator(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkIterator() {} // 0x0000000186481470-0x00000001864814C0

	// Methods
	internal static IntPtr getCPtr(AkIterator obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018648153C-0x0000000186481564
	~AkIterator() {} // 0x00000001864811D0-0x0000000186481244
	public void Dispose() {} // 0x0000000186481180-0x00000001864811D0
	protected virtual void Dispose(bool disposing) {} // 0x000000018648106C-0x0000000186481180
	public AkIterator NextIter() => default; // 0x0000000186481388-0x00000001864813FC
	public AkIterator PrevIter() => default; // 0x00000001864813FC-0x0000000186481470
	public AkPlaylistItem GetItem() => default; // 0x0000000186481244-0x00000001864812B8
	public bool IsEqualTo(AkIterator in_rOp) => default; // 0x0000000186481320-0x0000000186481388
	public bool IsDifferentFrom(AkIterator in_rOp) => default; // 0x00000001864812B8-0x0000000186481320
}

public class AkMarkerCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 54143
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public uint uIdentifier { get => default; } // 0x0000000186483A14-0x0000000186483A64 
	public uint uPosition { get => default; } // 0x0000000186483A64-0x0000000186483AB4 
	public string strLabel { get => default; } // 0x00000001864839A8-0x0000000186483A14 

	// Constructors
	internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001851445F0-0x0000000185144670
	public AkMarkerCallbackInfo() {} // 0x0000000186483958-0x00000001864839A8

	// Methods
	internal static IntPtr getCPtr(AkMarkerCallbackInfo obj) => default; // 0x000000018647E448-0x000000018647E458
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000186483AB4-0x0000000186483B14
	protected override void Dispose(bool disposing) {} // 0x0000000186483828-0x0000000186483958
}

public class AkMemCategroyStats : IDisposable // TypeDefIndex: 54144
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong uUsed { get => default; set {} } // 0x0000000186483DDC-0x0000000186483E2C 0x0000000186483F50-0x0000000186483FA4
	public ulong uPeakUsed { get => default; set {} } // 0x0000000186483D8C-0x0000000186483DDC 0x0000000186483EFC-0x0000000186483F50
	public uint uAllocs { get => default; set {} } // 0x0000000186483CEC-0x0000000186483D3C 0x0000000186483E54-0x0000000186483EA8
	public uint uFrees { get => default; set {} } // 0x0000000186483D3C-0x0000000186483D8C 0x0000000186483EA8-0x0000000186483EFC

	// Constructors
	internal AkMemCategroyStats(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkMemCategroyStats() {} // 0x0000000185D69AC0-0x0000000185D69B10

	// Methods
	internal static IntPtr getCPtr(AkMemCategroyStats obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186483E2C-0x0000000186483E54
	~AkMemCategroyStats() {} // 0x0000000186483C78-0x0000000186483CEC
	public void Dispose() {} // 0x0000000186483B14-0x0000000186483B64
	protected virtual void Dispose(bool disposing) {} // 0x0000000186483B64-0x0000000186483C78
}

public class AkMemGlobalStats : IDisposable // TypeDefIndex: 54145
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong uUsed { get => default; set {} } // 0x00000001864842BC-0x000000018648430C 0x0000000186484430-0x0000000186484484
	public ulong uDeviceUsed { get => default; set {} } // 0x00000001864841CC-0x000000018648421C 0x0000000186484334-0x0000000186484388
	public ulong uReserved { get => default; set {} } // 0x000000018648426C-0x00000001864842BC 0x00000001864843DC-0x0000000186484430
	public ulong uMax { get => default; set {} } // 0x000000018648421C-0x000000018648426C 0x0000000186484388-0x00000001864843DC

	// Constructors
	internal AkMemGlobalStats(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkMemGlobalStats() {} // 0x000000018648417C-0x00000001864841CC

	// Methods
	internal static IntPtr getCPtr(AkMemGlobalStats obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018648430C-0x0000000186484334
	~AkMemGlobalStats() {} // 0x0000000186484108-0x000000018648417C
	public void Dispose() {} // 0x00000001864840B8-0x0000000186484108
	protected virtual void Dispose(bool disposing) {} // 0x0000000186483FA4-0x00000001864840B8
}

public enum AkMemID : uint // TypeDefIndex: 54146
{
	AkMemID_Object = 0,
	AkMemID_Event = 1,
	AkMemID_Structure = 2,
	AkMemID_Media = 3,
	AkMemID_GameObject = 4,
	AkMemID_Processing = 5,
	AkMemID_ProcessingPlugin = 6,
	AkMemID_Streaming = 7,
	AkMemID_StreamingIO = 8,
	AkMemID_SpatialAudio = 9,
	AkMemID_SpatialAudioGeometry = 10,
	AkMemID_SpatialAudioPaths = 11,
	AkMemID_GameSim = 12,
	AkMemID_MonitorQueue = 13,
	AkMemID_Profiler = 14,
	AkMemID_FilePackage = 15,
	AkMemID_SoundEngine = 16,
	AkMemID_Integration = 17,
	AkMemID_JobMgr = 18,
	AkMemID_TempAudioRender = 19,
	AkMemID_NUM = 20,
	AkMemID_MASK = 536870911,
	AkMemType_Media = 536870912,
	AkMemType_Device = 1073741824,
	AkMemType_NoTrack = 2147483648
}

public enum AkMeteringFlags // TypeDefIndex: 54147
{
	AK_NoMetering = 0,
	AK_EnableBusMeter_Peak = 1,
	AK_EnableBusMeter_TruePeak = 2,
	AK_EnableBusMeter_RMS = 4,
	AK_EnableBusMeter_KPower = 16,
	AK_EnableBusMeter_3DMeter = 32
}

public enum AkMIDICcTypes // TypeDefIndex: 54148
{
	BANK_SELECT_COARSE = 0,
	MOD_WHEEL_COARSE = 1,
	BREATH_CTRL_COARSE = 2,
	CTRL_3_COARSE = 3,
	FOOT_PEDAL_COARSE = 4,
	PORTAMENTO_COARSE = 5,
	DATA_ENTRY_COARSE = 6,
	VOLUME_COARSE = 7,
	BALANCE_COARSE = 8,
	CTRL_9_COARSE = 9,
	PAN_POSITION_COARSE = 10,
	EXPRESSION_COARSE = 11,
	EFFECT_CTRL_1_COARSE = 12,
	EFFECT_CTRL_2_COARSE = 13,
	CTRL_14_COARSE = 14,
	CTRL_15_COARSE = 15,
	GEN_SLIDER_1 = 16,
	GEN_SLIDER_2 = 17,
	GEN_SLIDER_3 = 18,
	GEN_SLIDER_4 = 19,
	CTRL_20_COARSE = 20,
	CTRL_21_COARSE = 21,
	CTRL_22_COARSE = 22,
	CTRL_23_COARSE = 23,
	CTRL_24_COARSE = 24,
	CTRL_25_COARSE = 25,
	CTRL_26_COARSE = 26,
	CTRL_27_COARSE = 27,
	CTRL_28_COARSE = 28,
	CTRL_29_COARSE = 29,
	CTRL_30_COARSE = 30,
	CTRL_31_COARSE = 31,
	BANK_SELECT_FINE = 32,
	MOD_WHEEL_FINE = 33,
	BREATH_CTRL_FINE = 34,
	CTRL_3_FINE = 35,
	FOOT_PEDAL_FINE = 36,
	PORTAMENTO_FINE = 37,
	DATA_ENTRY_FINE = 38,
	VOLUME_FINE = 39,
	BALANCE_FINE = 40,
	CTRL_9_FINE = 41,
	PAN_POSITION_FINE = 42,
	EXPRESSION_FINE = 43,
	EFFECT_CTRL_1_FINE = 44,
	EFFECT_CTRL_2_FINE = 45,
	CTRL_14_FINE = 46,
	CTRL_15_FINE = 47,
	CTRL_20_FINE = 52,
	CTRL_21_FINE = 53,
	CTRL_22_FINE = 54,
	CTRL_23_FINE = 55,
	CTRL_24_FINE = 56,
	CTRL_25_FINE = 57,
	CTRL_26_FINE = 58,
	CTRL_27_FINE = 59,
	CTRL_28_FINE = 60,
	CTRL_29_FINE = 61,
	CTRL_30_FINE = 62,
	CTRL_31_FINE = 63,
	HOLD_PEDAL = 64,
	PORTAMENTO_ON_OFF = 65,
	SUSTENUTO_PEDAL = 66,
	SOFT_PEDAL = 67,
	LEGATO_PEDAL = 68,
	HOLD_PEDAL_2 = 69,
	SOUND_VARIATION = 70,
	SOUND_TIMBRE = 71,
	SOUND_RELEASE_TIME = 72,
	SOUND_ATTACK_TIME = 73,
	SOUND_BRIGHTNESS = 74,
	SOUND_CTRL_6 = 75,
	SOUND_CTRL_7 = 76,
	SOUND_CTRL_8 = 77,
	SOUND_CTRL_9 = 78,
	SOUND_CTRL_10 = 79,
	GENERAL_BUTTON_1 = 80,
	GENERAL_BUTTON_2 = 81,
	GENERAL_BUTTON_3 = 82,
	GENERAL_BUTTON_4 = 83,
	REVERB_LEVEL = 91,
	TREMOLO_LEVEL = 92,
	CHORUS_LEVEL = 93,
	CELESTE_LEVEL = 94,
	PHASER_LEVEL = 95,
	DATA_BUTTON_P1 = 96,
	DATA_BUTTON_M1 = 97,
	NON_REGISTER_COARSE = 98,
	NON_REGISTER_FINE = 99,
	ALL_SOUND_OFF = 120,
	ALL_CONTROLLERS_OFF = 121,
	LOCAL_KEYBOARD = 122,
	ALL_NOTES_OFF = 123,
	OMNI_MODE_OFF = 124,
	OMNI_MODE_ON = 125,
	OMNI_MONOPHONIC_ON = 126,
	OMNI_POLYPHONIC_ON = 127
}

public class AkMIDIEvent : IDisposable // TypeDefIndex: 54157
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public byte byChan { get => default; set {} } // 0x00000001864A7F88-0x00000001864A7FD8 0x00000001864A8050-0x00000001864A80A4
	public tGen Gen { get => default; set {} } // 0x00000001864A7FD8-0x00000001864A8028 0x00000001864A80A4-0x00000001864A80F8
	public tCc Cc { get => default; set {} } // 0x0000000185FAFE30-0x0000000185FAFE40 0x00000001864A7F38-0x00000001864A7F88
	public tNoteOnOff NoteOnOff { get => default; set {} } // 0x00000001864A78F8-0x00000001864A7920 0x0000000186478A10-0x0000000186478A20
	public tPitchBend PitchBend { get => default; set {} } // 0x00000001864A7744-0x00000001864A7794 0x00000001864A7794-0x00000001864A7808
	public tNoteAftertouch NoteAftertouch { get => default; set {} } // 0x00000001864A7920-0x00000001864A7974 0x00000001864A7630-0x00000001864A7744
	public tChanAftertouch ChanAftertouch { get => default; set {} } // 0x00000001864A7974-0x00000001864A79C8 0x00000001864A7858-0x00000001864A78A8
	public tProgramChange ProgramChange { get => default; set {} } // 0x00000001864A7808-0x00000001864A7858 0x00000001864A78A8-0x00000001864A78F8
	public tWwiseCmd WwiseCmd { get => default; set {} } // 0x0000000186478A10-0x0000000186478A20 0x0000000185FAFE30-0x0000000185FAFE40
	public AkMIDIEventTypes byType { get => default; set {} } // 0x00000001864A7108-0x00000001864A717C 0x00000001864A721C-0x00000001864A7244
	public byte byOnOffNote { get => default; set {} } // 0x00000001864A6FF4-0x00000001864A7108 0x00000001864A6FA4-0x00000001864A6FF4
	public byte byVelocity { get => default; set {} } // 0x00000001864A71CC-0x00000001864A721C 0x00000001864A7244-0x00000001864A7298
	public AkMIDICcTypes byCc { get => default; set {} } // 0x0000000185FAFE30-0x0000000185FAFE40 0x00000001864A717C-0x00000001864A71CC
	public byte byCcValue { get => default; set {} } // 0x00000001864A8370-0x00000001864A8398 0x0000000186478A10-0x0000000186478A20
	public byte byValueLsb { get => default; set {} } // 0x00000001864A80F8-0x00000001864A8148 0x00000001864A825C-0x00000001864A82D0
	public byte byValueMsb { get => default; set {} } // 0x00000001864A8398-0x00000001864A83EC 0x00000001864A8148-0x00000001864A825C
	public byte byAftertouchNote { get => default; set {} } // 0x00000001864A82D0-0x00000001864A8320 0x00000001864A8320-0x00000001864A8370
	public byte byNoteAftertouchValue { get => default; set {} } // 0x0000000186478A10-0x0000000186478A20 0x0000000185FAFE30-0x0000000185FAFE40
	public byte byChanAftertouchValue { get => default; set {} } // 0x00000001864A8550-0x00000001864A85C4 0x00000001864A86B4-0x00000001864A86DC
	public byte byProgramNum { get => default; set {} } // 0x00000001864A843C-0x00000001864A8550 0x00000001864A83EC-0x00000001864A843C
	public ushort uCmd { get => default; set {} } // 0x00000001864A8664-0x00000001864A86B4 0x00000001864A8730-0x00000001864A8784
	public uint uArg { get => default; set {} } // 0x00000001864A8614-0x00000001864A8664 0x00000001864A86DC-0x00000001864A8730

	// Nested types
	public class tGen : IDisposable // TypeDefIndex: 54149
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byParam1 { get => default; set {} } // 0x00000001864822E0-0x0000000186482330 0x0000000186482AB8-0x0000000186482B0C
		public byte byParam2 { get => default; set {} } // 0x0000000186481EB8-0x0000000186481F34 0x00000001864826F8-0x0000000186482760

		// Constructors
		internal tGen(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
		public tGen() {} // 0x0000000186482628-0x0000000186482690

		// Methods
		internal static IntPtr getCPtr(tGen obj) => default; // 0x0000000186478A10-0x0000000186478A20
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186482600-0x0000000186482628
		~tGen() {} // 0x000000018647B834-0x000000018647B8AC
		public void Dispose() {} // 0x0000000186481C0C-0x0000000186481C5C
		protected virtual void Dispose(bool disposing) {} // 0x0000000186481C5C-0x0000000186481D70
	}

	public class tNoteOnOff : IDisposable // TypeDefIndex: 54150
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byNote { get => default; set {} } // 0x0000000186482690-0x00000001864826F8 0x0000000186481F34-0x0000000186481FB0
		public byte byVelocity { get => default; set {} } // 0x0000000186482898-0x0000000186482900 0x0000000186481E3C-0x0000000186481EB8

		// Constructors
		internal tNoteOnOff(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000186481DC0-0x0000000186481E3C
		public tNoteOnOff() {} // 0x00000001864820A8-0x0000000186482124

		// Methods
		internal static IntPtr getCPtr(tNoteOnOff obj) => default; // 0x00000001864827C8-0x0000000186482830
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186481FB0-0x000000018648202C
		~tNoteOnOff() {} // 0x0000000186482830-0x0000000186482898
		public void Dispose() {} // 0x000000018648202C-0x00000001864820A8
		protected virtual void Dispose(bool disposing) {} // 0x0000000186482760-0x00000001864827C8
	}

	public class tCc : IDisposable // TypeDefIndex: 54151
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byCc { get => default; set {} } // 0x0000000186482510-0x0000000186482560 0x0000000186482D04-0x0000000186482D58
		public byte byValue { get => default; set {} } // 0x0000000186482240-0x0000000186482290 0x0000000186482A10-0x0000000186482A64

		// Constructors
		internal tCc(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000186482900-0x0000000186482968
		public tCc() {} // 0x00000001864829BC-0x0000000186482A10

		// Methods
		internal static IntPtr getCPtr(tCc obj) => default; // 0x0000000186482124-0x00000001864821A0
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186482C08-0x0000000186482C5C
		~tCc() {} // 0x0000000186482420-0x0000000186482470
		public void Dispose() {} // 0x0000000186482B60-0x0000000186482BB4
		protected virtual void Dispose(bool disposing) {} // 0x0000000186482380-0x00000001864823D0
	}

	public class tPitchBend : IDisposable // TypeDefIndex: 54152
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byValueLsb { get => default; set {} } // 0x0000000186482B0C-0x0000000186482B60 0x00000001864821A0-0x00000001864821F0
		public byte byValueMsb { get => default; set {} } // 0x0000000186482A64-0x0000000186482AB8 0x0000000186482330-0x0000000186482380

		// Constructors
		internal tPitchBend(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001864821F0-0x0000000186482240
		public tPitchBend() {} // 0x0000000186482290-0x00000001864822E0

		// Methods
		internal static IntPtr getCPtr(tPitchBend obj) => default; // 0x0000000186482C5C-0x0000000186482CB0
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186482470-0x00000001864824C0
		~tPitchBend() {} // 0x0000000186482CB0-0x0000000186482D04
		public void Dispose() {} // 0x00000001864824C0-0x0000000186482510
		protected virtual void Dispose(bool disposing) {} // 0x0000000186482968-0x00000001864829BC
	}

	public class tNoteAftertouch : IDisposable // TypeDefIndex: 54153
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byNote { get => default; set {} } // 0x0000000185FAFE30-0x0000000185FAFE40 0x0000000186481D70-0x0000000186481DC0
		public byte byValue { get => default; set {} } // 0x00000001864A7560-0x00000001864A7588 0x0000000186478A10-0x0000000186478A20

		// Constructors
		internal tNoteAftertouch(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000186482BB4-0x0000000186482C08
		public tNoteAftertouch() {} // 0x00000001864A73FC-0x00000001864A7470

		// Methods
		internal static IntPtr getCPtr(tNoteAftertouch obj) => default; // 0x00000001864823D0-0x0000000186482420
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186482DAC-0x0000000186482E00
		~tNoteAftertouch() {} // 0x00000001864825B0-0x0000000186482600
		public void Dispose() {} // 0x0000000186482D58-0x0000000186482DAC
		protected virtual void Dispose(bool disposing) {} // 0x0000000186482560-0x00000001864825B0
	}

	public class tChanAftertouch : IDisposable // TypeDefIndex: 54154
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byValue { get => default; set {} } // 0x0000000185FAFE30-0x0000000185FAFE40 0x00000001864A7470-0x00000001864A74C0

		// Constructors
		internal tChanAftertouch(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001864A7298-0x00000001864A72E8
		public tChanAftertouch() {} // 0x0000000186478A10-0x0000000186478A20

		// Methods
		internal static IntPtr getCPtr(tChanAftertouch obj) => default; // 0x00000001864A72E8-0x00000001864A73FC
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A7588-0x00000001864A75DC
		~tChanAftertouch() {} // 0x00000001864A74C0-0x00000001864A7510
		public void Dispose() {} // 0x00000001864A75DC-0x00000001864A7630
		protected virtual void Dispose(bool disposing) {} // 0x00000001864A7510-0x00000001864A7560
	}

	public class tProgramChange : IDisposable // TypeDefIndex: 54155
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byProgramNum { get => default; set {} } // 0x00000001864A7C40-0x00000001864A7C90 0x00000001864A7D0C-0x00000001864A7D60

		// Constructors
		internal tProgramChange(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001864A7C90-0x00000001864A7CB8
		public tProgramChange() {} // 0x00000001864A7BA0-0x00000001864A7BF0

		// Methods
		internal static IntPtr getCPtr(tProgramChange obj) => default; // 0x00000001864A7B2C-0x00000001864A7BA0
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A79C8-0x00000001864A7A18
		~tProgramChange() {} // 0x00000001864A7A18-0x00000001864A7B2C
		public void Dispose() {} // 0x00000001864A7CB8-0x00000001864A7D0C
		protected virtual void Dispose(bool disposing) {} // 0x00000001864A7BF0-0x00000001864A7C40
	}

	public class tWwiseCmd : IDisposable // TypeDefIndex: 54156
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public ushort uCmd { get => default; set {} } // 0x00000001864A6E34-0x00000001864A6E84 0x00000001864A6EFC-0x00000001864A6F50
		public uint uArg { get => default; set {} } // 0x00000001864A6E84-0x00000001864A6ED4 0x00000001864A6F50-0x00000001864A6FA4

		// Constructors
		internal tWwiseCmd(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
		public tWwiseCmd() {} // 0x00000001864A6DE4-0x00000001864A6E34

		// Methods
		internal static IntPtr getCPtr(tWwiseCmd obj) => default; // 0x0000000186478A10-0x0000000186478A20
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A6ED4-0x00000001864A6EFC
		~tWwiseCmd() {} // 0x00000001864A6D70-0x00000001864A6DE4
		public void Dispose() {} // 0x00000001864A6D20-0x00000001864A6D70
		protected virtual void Dispose(bool disposing) {} // 0x00000001864A6C0C-0x00000001864A6D20
	}

	// Constructors
	internal AkMIDIEvent(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkMIDIEvent() {} // 0x00000001864A85C4-0x00000001864A8614

	// Methods
	internal static IntPtr getCPtr(AkMIDIEvent obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A8028-0x00000001864A8050
	~AkMIDIEvent() {} // 0x00000001864A7EC4-0x00000001864A7F38
	public void Dispose() {} // 0x00000001864A7E74-0x00000001864A7EC4
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A7D60-0x00000001864A7E74
}

public class AkMIDIEventCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 54158
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public byte byChan { get => default; } // 0x000000018648188C-0x00000001864818DC 
	public byte byParam1 { get => default; } // 0x000000018648197C-0x00000001864819CC 
	public byte byParam2 { get => default; } // 0x00000001864819CC-0x0000000186481A1C 
	public AkMIDIEventTypes byType { get => default; } // 0x0000000186481A6C-0x0000000186481ABC 
	public byte byOnOffNote { get => default; } // 0x000000018648192C-0x000000018648197C 
	public byte byVelocity { get => default; } // 0x0000000186481B5C-0x0000000186481BAC 
	public AkMIDICcTypes byCc { get => default; } // 0x00000001864817EC-0x000000018648183C 
	public byte byCcValue { get => default; } // 0x000000018648179C-0x00000001864817EC 
	public byte byValueLsb { get => default; } // 0x0000000186481ABC-0x0000000186481B0C 
	public byte byValueMsb { get => default; } // 0x0000000186481B0C-0x0000000186481B5C 
	public byte byAftertouchNote { get => default; } // 0x000000018648174C-0x000000018648179C 
	public byte byNoteAftertouchValue { get => default; } // 0x00000001864818DC-0x000000018648192C 
	public byte byChanAftertouchValue { get => default; } // 0x000000018648183C-0x000000018648188C 
	public byte byProgramNum { get => default; } // 0x0000000186481A1C-0x0000000186481A6C 

	// Constructors
	internal AkMIDIEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001851444F0-0x0000000185144570
	public AkMIDIEventCallbackInfo() {} // 0x00000001864816FC-0x000000018648174C

	// Methods
	internal static IntPtr getCPtr(AkMIDIEventCallbackInfo obj) => default; // 0x000000018647E448-0x000000018647E458
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000186481BAC-0x0000000186481C0C
	protected override void Dispose(bool disposing) {} // 0x00000001864815CC-0x00000001864816FC
}

public enum AkMIDIEventTypes // TypeDefIndex: 54159
{
	NOTE_OFF = 128,
	NOTE_ON = 144,
	NOTE_AFTERTOUCH = 160,
	CONTROLLER = 176,
	PROGRAM_CHANGE = 192,
	CHANNEL_AFTERTOUCH = 208,
	PITCH_BEND = 224,
	SYSEX = 240,
	ESCAPE = 247,
	META = 255
}

public class AkMIDIPost : AkMIDIEvent // TypeDefIndex: 54160
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public ulong uOffset { get => default; set {} } // 0x0000000186483724-0x0000000186483774 0x00000001864837D4-0x0000000186483828

	// Constructors
	internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn) {} // 0x000000018648366C-0x00000001864836D4
	public AkMIDIPost() {} // 0x00000001864836D4-0x0000000186483724

	// Methods
	internal static IntPtr getCPtr(AkMIDIPost obj) => default; // 0x000000018647E7C8-0x000000018647E7D8
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000186483774-0x00000001864837D4
	protected override void Dispose(bool disposing) {} // 0x0000000186482E68-0x0000000186482F98
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts) => default; // 0x00000001864831C8-0x0000000186483264
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets) => default; // 0x0000000186483264-0x0000000186483308
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864833B4-0x00000001864834C8
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID) => default; // 0x0000000186482FD8-0x00000001864830F4
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts) => default; // 0x00000001864835C8-0x000000018648366C
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets) => default; // 0x0000000186483308-0x00000001864833B4
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864830F4-0x00000001864831C8
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID) => default; // 0x00000001864834C8-0x00000001864835C8
	public void Clone(AkMIDIPost other) {} // 0x0000000186482E00-0x0000000186482E68
	public static int GetSizeOf() => default; // 0x0000000186482F98-0x0000000186482FD8
}

public enum AkMonitorErrorCode // TypeDefIndex: 54161
{
	ErrorCode_NoError = 0,
	ErrorCode_FileNotFound = 1,
	ErrorCode_CannotOpenFile = 2,
	ErrorCode_CannotStartStreamNoMemory = 3,
	ErrorCode_IODevice = 4,
	ErrorCode_IncompatibleIOSettings = 5,
	ErrorCode_PluginUnsupportedChannelConfiguration = 6,
	ErrorCode_PluginMediaUnavailable = 7,
	ErrorCode_PluginInitialisationFailed = 8,
	ErrorCode_PluginProcessingFailed = 9,
	ErrorCode_PluginExecutionInvalid = 10,
	ErrorCode_PluginAllocationFailed = 11,
	ErrorCode_VorbisSeekTableRecommended = 12,
	ErrorCode_VorbisDecodeError = 13,
	ErrorCode_ATRAC9DecodeFailed = 14,
	ErrorCode_ATRAC9LoopSectionTooSmall = 15,
	ErrorCode_InvalidAudioFileHeader = 16,
	ErrorCode_AudioFileHeaderTooLarge = 17,
	ErrorCode_LoopTooSmall = 18,
	ErrorCode_TransitionNotAccurateChannel = 19,
	ErrorCode_TransitionNotAccuratePluginMismatch = 20,
	ErrorCode_TransitionNotAccurateRejectedByPlugin = 21,
	ErrorCode_TransitionNotAccurateStarvation = 22,
	ErrorCode_TransitionNotAccurateCodecError = 23,
	ErrorCode_NothingToPlay = 24,
	ErrorCode_PlayFailed = 25,
	ErrorCode_StingerCouldNotBeScheduled = 26,
	ErrorCode_TooLongSegmentLookAhead = 27,
	ErrorCode_CannotScheduleMusicSwitch = 28,
	ErrorCode_TooManySimultaneousMusicSegments = 29,
	ErrorCode_PlaylistStoppedForEditing = 30,
	ErrorCode_MusicClipsRescheduledAfterTrackEdit = 31,
	ErrorCode_CannotPlaySource_Create = 32,
	ErrorCode_CannotPlaySource_VirtualOff = 33,
	ErrorCode_CannotPlaySource_TimeSkip = 34,
	ErrorCode_CannotPlaySource_InconsistentState = 35,
	ErrorCode_MediaNotLoaded = 36,
	ErrorCode_VoiceStarving = 37,
	ErrorCode_StreamingSourceStarving = 38,
	ErrorCode_XMADecoderSourceStarving = 39,
	ErrorCode_XMADecodingError = 40,
	ErrorCode_InvalidXMAData = 41,
	ErrorCode_PluginNotRegistered = 42,
	ErrorCode_CodecNotRegistered = 43,
	ErrorCode_PluginVersionMismatch = 44,
	ErrorCode_EventIDNotFound = 45,
	ErrorCode_InvalidGroupID = 46,
	ErrorCode_SelectedNodeNotAvailable = 47,
	ErrorCode_SelectedMediaNotAvailable = 48,
	ErrorCode_NoValidSwitch = 49,
	ErrorCode_BankLoadFailed = 50,
	ErrorCode_ErrorWhileLoadingBank = 51,
	ErrorCode_InsufficientSpaceToLoadBank = 52,
	ErrorCode_LowerEngineCommandListFull = 53,
	ErrorCode_SeekNoMarker = 54,
	ErrorCode_CannotSeekContinuous = 55,
	ErrorCode_SeekAfterEof = 56,
	ErrorCode_UnknownGameObject = 57,
	ErrorCode_GameObjectNeverRegistered = 58,
	ErrorCode_DeadGameObject = 59,
	ErrorCode_GameObjectIsNotEmitter = 60,
	ErrorCode_ExternalSourceNotResolved = 61,
	ErrorCode_FileFormatMismatch = 62,
	ErrorCode_CommandQueueFull = 63,
	ErrorCode_CommandTooLarge = 64,
	ErrorCode_XMACreateDecoderLimitReached = 65,
	ErrorCode_XMAStreamBufferTooSmall = 66,
	ErrorCode_ModulatorScopeError_Inst = 67,
	ErrorCode_ModulatorScopeError_Obj = 68,
	ErrorCode_SeekAfterEndOfPlaylist = 69,
	ErrorCode_OpusRequireSeekTable = 70,
	ErrorCode_OpusDecodeError = 71,
	ErrorCode_SourcePluginNotFound = 72,
	ErrorCode_VirtualVoiceLimit = 73,
	ErrorCode_NotEnoughMemoryToStart = 74,
	ErrorCode_UnknownOpusError = 75,
	ErrorCode_AudioDeviceInitFailure = 76,
	ErrorCode_AudioDeviceRemoveFailure = 77,
	ErrorCode_AudioDeviceNotFound = 78,
	ErrorCode_AudioDeviceNotValid = 79,
	ErrorCode_SpatialAudio_ListenerAutomationNotSupported = 80,
	ErrorCode_MediaDuplicationLength = 81,
	ErrorCode_HwVoicesSystemInitFailed = 82,
	ErrorCode_HwVoicesDecodeBatchFailed = 83,
	ErrorCode_HwVoiceLimitReached = 84,
	ErrorCode_HwVoiceInitFailed = 85,
	ErrorCode_OpusHWCommandFailed = 86,
	ErrorCode_AddOutputListenerIdWithZeroListeners = 87,
	ErrorCode_3DObjectLimitExceeded = 88,
	ErrorCode_OpusHWFatalError = 89,
	ErrorCode_OpusHWDecodeUnavailable = 90,
	ErrorCode_OpusHWTimeout = 91,
	ErrorCode_SystemAudioObjectsUnavailable = 92,
	ErrorCode_AddOutputNoDistinctListener = 93,
	ErrorCode_PluginCannotRunOnObjectConfig = 94,
	ErrorCode_SpatialAudio_ReflectionBusError = 95,
	ErrorCode_VorbisHWDecodeUnavailable = 96,
	ErrorCode_ExternalSourceNoMemorySize = 97,
	ErrorCode_MonitorQueueFull = 98,
	ErrorCode_MonitorMsgTooLarge = 99,
	ErrorCode_NonCompliantDeviceMemory = 100,
	ErrorCode_JobWorkerFuncCallMismatch = 101,
	ErrorCode_JobMgrOutOfMemory = 102,
	ErrorCode_InvalidFileSize = 103,
	ErrorCode_PluginMsg = 104,
	ErrorCode_SinkOpenSL = 105,
	ErrorCode_AudioOutOfRange = 106,
	ErrorCode_AudioOutOfRangeOnBus = 107,
	ErrorCode_AudioOutOfRangeOnBusFx = 108,
	ErrorCode_AudioOutOfRangeRay = 109,
	ErrorCode_UnknownDialogueEvent = 110,
	ErrorCode_FailedPostingEvent = 111,
	ErrorCode_OutputDeviceInitializationFailed = 112,
	ErrorCode_UnloadBankFailed = 113,
	ErrorCode_PluginFileNotFound = 114,
	ErrorCode_PluginFileIncompatible = 115,
	ErrorCode_PluginFileNotEnoughMemoryToStart = 116,
	ErrorCode_PluginFileInvalid = 117,
	ErrorCode_PluginFileRegisterFailed = 118,
	ErrorCode_UnknownArgument = 119,
	ErrorCode_DynamicSequenceAlreadyClosed = 120,
	ErrorCode_PendingActionDestroyed = 121,
	ErrorCode_CrossFadeTransitionIgnored = 122,
	ErrorCode_MusicRendererSeekingFailed = 123,
	ErrorCode_DynamicSequenceIdNotFound = 124,
	ErrorCode_BusNotFoundByName = 125,
	ErrorCode_AudioDeviceShareSetNotFound = 126,
	ErrorCode_AudioDeviceShareSetNotFoundByName = 127,
	ErrorCode_SoundEngineTooManyGameObjects = 128,
	ErrorCode_SoundEngineTooManyPositions = 129,
	ErrorCode_SoundEngineCantCallOnChildBus = 130,
	ErrorCode_SoundEnginePlayingIdNotFound = 131,
	ErrorCode_SoundEngineInvalidTransform = 132,
	ErrorCode_SoundEngineTooManyEventPosts = 133,
	ErrorCode_AudioSubsystemStoppedResponding = 134,
	ErrorCode_NotEnoughMemInFunction = 135,
	ErrorCode_FXNotFound = 136,
	ErrorCode_SetMixerNotABus = 137,
	ErrorCode_AudioNodeNotFound = 138,
	ErrorCode_SetMixerFailed = 139,
	ErrorCode_SetBusConfigUnsupported = 140,
	ErrorCode_BusNotFound = 141,
	ErrorCode_MismatchingMediaSize = 142,
	ErrorCode_IncompatibleBankVersion = 143,
	ErrorCode_UnexpectedPrepareGameSyncsCall = 144,
	ErrorCode_MusicEngineNotInitialized = 145,
	ErrorCode_LoadingBankMismatch = 146,
	ErrorCode_MasterBusStructureNotLoaded = 147,
	ErrorCode_TooManyChildren = 148,
	ErrorCode_BankContainUneditableEffect = 149,
	ErrorCode_MemoryAllocationFailed = 150,
	ErrorCode_InvalidFloatPriority = 151,
	ErrorCode_SoundLoadFailedInsufficientMemory = 152,
	ErrorCode_NXDeviceRegistrationFailed = 153,
	ErrorCode_MixPluginOnObjectBus = 154,
	ErrorCode_XboxXMAVoiceResetFailed = 155,
	ErrorCode_XboxACPMessage = 156,
	ErrorCode_XboxFrameDropped = 157,
	ErrorCode_XboxACPError = 158,
	ErrorCode_XboxXMAFatalError = 159,
	ErrorCode_MissingMusicNodeParent = 160,
	ErrorCode_HardwareOpusDecoderError = 161,
	ErrorCode_SetGeometryTooManyTriangleConnected = 162,
	ErrorCode_SetGeometryTriangleTooLarge = 163,
	ErrorCode_SetGeometryFailed = 164,
	ErrorCode_RemovingGeometrySetFailed = 165,
	ErrorCode_SetGeometryInstanceFailed = 166,
	ErrorCode_RemovingGeometryInstanceFailed = 167,
	ErrorCode_RevertingToDefaultAudioDevice = 168,
	ErrorCode_RevertingToDummyAudioDevice = 169,
	ErrorCode_AudioThreadSuspended = 170,
	ErrorCode_AudioThreadResumed = 171,
	ErrorCode_ResetPlaylistActionIgnoredGlobalScope = 172,
	ErrorCode_ResetPlaylistActionIgnoredContinuous = 173,
	ErrorCode_PlayingTriggerRateNotSupported = 174,
	ErrorCode_SetGeometryTriangleIsSkipped = 175,
	ErrorCode_SetGeometryInstanceInvalidTransform = 176,
	ErrorCode_SetGameObjectRadiusSizeError = 177,
	ErrorCode_SetPortalNonDistinctRoom = 178,
	ErrorCode_SetPortalInvalidExtent = 179,
	ErrorCode_SpatialAudio_PortalNotFound = 180,
	ErrorCode_InvalidFloatInFunction = 181,
	ErrorCode_FLTMAXNotSupported = 182,
	ErrorCode_CannotInitializeAmbisonicChannelConfiguration = 183,
	ErrorCode_CannotInitializePassthrough = 184,
	ErrorCode_3DAudioUnsupportedSize = 185,
	ErrorCode_AmbisonicNotAvailable = 186,
	ErrorCode_NoAudioDevice = 187,
	ErrorCode_Support = 188,
	ErrorCode_ReplayMessage = 189,
	ErrorCode_GameMessage = 190,
	ErrorCode_TestMessage = 191,
	ErrorCode_TranslatorStandardTagTest = 192,
	ErrorCode_TranslatorWwiseTagTest = 193,
	ErrorCode_TranslatorStringSizeTest = 194,
	ErrorCode_InvalidParameter = 195,
	ErrorCode_MaxAudioObjExceeded = 196,
	ErrorCode_MMSNotEnabled = 197,
	ErrorCode_NotEnoughSystemObj = 198,
	ErrorCode_NotEnoughSystemObjWin = 199,
	ErrorCode_TransitionNotAccurateSourceTooShort = 200,
	ErrorCode_AlreadyInitialized = 201,
	ErrorCode_WrongNumberOfArguments = 202,
	ErrorCode_DataAlignement = 203,
	ErrorCode_PluginMsgWithShareSet = 204,
	ErrorCode_SoundEngineNotInit = 205,
	ErrorCode_NoDefaultSwitch = 206,
	ErrorCode_CantSetBoundSwitch = 207,
	ErrorCode_IODeviceInitFailed = 208,
	ErrorCode_SwitchListEmpty = 209,
	ErrorCode_NoSwitchSelected = 210,
	ErrorCode_FilePermissionError = 211,
	ErrorCode_SetEffectOnRendered = 212,
	ErrorCode_GeometryNotWatertight = 213,
	ErrorCode_CannotInitialize3DAudio = 214,
	ErrorCode_CannotInitializeInputCallbacks = 215,
	ErrorCode_CannotConnectAVAudioEngineSource = 216,
	ErrorCode_ChannelConfigRequestDenied = 217,
	ErrorCode_MediaUpdatedFromWwise = 218,
	ErrorCode_MediaErrorFromWwise = 219,
	ErrorCode_OutputAlreadyExists = 220,
	ErrorCode_UnknownStateGroup = 221,
	ErrorCode_MediaErrorWwiseMRUFull = 222,
	ErrorCode_AudioOut2ContextCreateError = 223,
	ErrorCode_AudioOut2UserCreateError = 224,
	ErrorCode_FeedbackOnAudioObjectsBus = 225,
	ErrorCode_AssetSwapEnabled = 226,
	ErrorCode_SpatialAudio_SiblingPortal = 227,
	Num_ErrorCodes = 228
}

public enum AkMonitorErrorLevel // TypeDefIndex: 54162
{
	ErrorLevel_Message = 1,
	ErrorLevel_Error = 2,
	ErrorLevel_All = 3
}

public class AkMonitoringCallbackInfo : IDisposable // TypeDefIndex: 54163
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkMonitorErrorCode errorCode { get => default; } // 0x00000001864846AC-0x00000001864846FC 
	public AkMonitorErrorLevel errorLevel { get => default; } // 0x00000001864846FC-0x000000018648474C 
	public uint playingID { get => default; } // 0x0000000186484808-0x0000000186484858 
	public ulong gameObjID { get => default; } // 0x000000018648474C-0x000000018648479C 
	public string message { get => default; } // 0x000000018648479C-0x0000000186484808 

	// Constructors
	internal AkMonitoringCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkMonitoringCallbackInfo() {} // 0x000000018648465C-0x00000001864846AC

	// Methods
	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186484858-0x0000000186484880
	~AkMonitoringCallbackInfo() {} // 0x00000001864845E8-0x000000018648465C
	public void Dispose() {} // 0x0000000186484598-0x00000001864845E8
	protected virtual void Dispose(bool disposing) {} // 0x0000000186484484-0x0000000186484598
}

public enum AkMultiPositionType // TypeDefIndex: 54164
{
	MultiPositionType_SingleSource = 0,
	MultiPositionType_MultiSources = 1,
	MultiPositionType_MultiDirections = 2
}

public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 54165
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public uint playlistID { get => default; } // 0x0000000186484A00-0x0000000186484A50 
	public uint uNumPlaylistItems { get => default; } // 0x0000000186484A50-0x0000000186484AA0 
	public uint uPlaylistSelection { get => default; } // 0x0000000186484AF0-0x0000000186484B40 
	public uint uPlaylistItemDone { get => default; } // 0x0000000186484AA0-0x0000000186484AF0 

	// Constructors
	internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001851443F0-0x0000000185144470
	public AkMusicPlaylistCallbackInfo() {} // 0x00000001864849B0-0x0000000186484A00

	// Methods
	internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj) => default; // 0x000000018647E448-0x000000018647E458
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000186484B40-0x0000000186484BA0
	protected override void Dispose(bool disposing) {} // 0x0000000186484880-0x00000001864849B0
}

public class AkMusicSettings : IDisposable // TypeDefIndex: 54166
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fStreamingLookAheadRatio { get => default; set {} } // 0x0000000186484BF0-0x0000000186484C40 0x0000000185501650-0x00000001855016B0

	// Constructors
	public AkMusicSettings() {} // Dummy constructor
	internal AkMusicSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40

	// Methods
	internal static IntPtr getCPtr(AkMusicSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186484C40-0x0000000186484C68
	~AkMusicSettings() {} // 0x0000000185C58910-0x0000000185C58960
	public void Dispose() {} // 0x0000000186484BA0-0x0000000186484BF0
	protected virtual void Dispose(bool disposing) {} // 0x0000000185C58960-0x0000000185C58BF0
}

public class AkMusicSyncCallbackInfo : AkCallbackInfo // TypeDefIndex: 54167
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get => default; } // 0x0000000186484E38-0x0000000186484E88 
	public int segmentInfo_iCurrentPosition { get => default; } // 0x0000000186485018-0x0000000186485068 
	public int segmentInfo_iPreEntryDuration { get => default; } // 0x00000001864850B8-0x0000000186485108 
	public int segmentInfo_iActiveDuration { get => default; } // 0x0000000186484FC8-0x0000000186485018 
	public int segmentInfo_iPostExitDuration { get => default; } // 0x0000000186485068-0x00000001864850B8 
	public int segmentInfo_iRemainingLookAheadTime { get => default; } // 0x0000000186485108-0x0000000186485158 
	public float segmentInfo_fBeatDuration { get => default; } // 0x0000000186484ED8-0x0000000186484F28 
	public float segmentInfo_fBarDuration { get => default; } // 0x0000000186484E88-0x0000000186484ED8 
	public float segmentInfo_fGridDuration { get => default; } // 0x0000000186484F28-0x0000000186484F78 
	public float segmentInfo_fGridOffset { get => default; } // 0x0000000186484F78-0x0000000186484FC8 
	public AkCallbackType musicSyncType { get => default; } // 0x0000000186484DE8-0x0000000186484E38 
	public string userCueName { get => default; } // 0x0000000186485158-0x00000001864851C4 

	// Constructors
	internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185144290-0x0000000185144300
	public AkMusicSyncCallbackInfo() {} // 0x0000000186484D98-0x0000000186484DE8

	// Methods
	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj) => default; // 0x000000018647E7C8-0x000000018647E7D8
	internal override void setCPtr(IntPtr cPtr) {} // 0x00000001864851C4-0x0000000186485224
	protected override void Dispose(bool disposing) {} // 0x0000000186484C68-0x0000000186484D98
}

public class AkObjectInfo : IDisposable // TypeDefIndex: 54168
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint objID { get => default; set {} } // 0x0000000186485594-0x00000001864855E4 0x00000001864856B0-0x0000000186485704
	public uint parentID { get => default; set {} } // 0x00000001864855E4-0x0000000186485634 0x0000000186485704-0x0000000186485758
	public int iDepth { get => default; set {} } // 0x0000000186485544-0x0000000186485594 0x000000018648565C-0x00000001864856B0

	// Constructors
	internal AkObjectInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkObjectInfo() {} // 0x00000001864854F4-0x0000000186485544

	// Methods
	internal static IntPtr getCPtr(AkObjectInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186485634-0x000000018648565C
	~AkObjectInfo() {} // 0x0000000186485440-0x00000001864854B4
	public void Dispose() {} // 0x00000001864853F0-0x0000000186485440
	protected virtual void Dispose(bool disposing) {} // 0x00000001864852DC-0x00000001864853F0
	public void Clear() {} // 0x0000000186485224-0x0000000186485274
	public static int GetSizeOf() => default; // 0x00000001864854B4-0x00000001864854F4
	public void Clone(AkObjectInfo other) {} // 0x0000000186485274-0x00000001864852DC
}

public class AkObstructionOcclusionValues : IDisposable // TypeDefIndex: 54169
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float occlusion { get => default; set {} } // 0x0000000186485AC8-0x0000000186485B18 0x0000000186485B98-0x0000000186485BF0
	public float obstruction { get => default; set {} } // 0x0000000186485A78-0x0000000186485AC8 0x0000000186485B40-0x0000000186485B98

	// Constructors
	internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkObstructionOcclusionValues() {} // 0x0000000186485A28-0x0000000186485A78

	// Methods
	internal static IntPtr getCPtr(AkObstructionOcclusionValues obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186485B18-0x0000000186485B40
	~AkObstructionOcclusionValues() {} // 0x0000000186485974-0x00000001864859E8
	public void Dispose() {} // 0x0000000186485924-0x0000000186485974
	protected virtual void Dispose(bool disposing) {} // 0x0000000186485810-0x0000000186485924
	public void Clear() {} // 0x0000000186485758-0x00000001864857A8
	public static int GetSizeOf() => default; // 0x00000001864859E8-0x0000000186485A28
	public void Clone(AkObstructionOcclusionValues other) {} // 0x00000001864857A8-0x0000000186485810
}

public class AkOutputSettings : IDisposable // TypeDefIndex: 54170
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioDeviceShareset { get => default; set {} } // 0x0000000186485E64-0x0000000186485EB4 0x00000001856B5F20-0x00000001856B5F80
	public uint idDevice { get => default; set {} } // 0x0000000186485F04-0x0000000186485F54 0x00000001856B5E80-0x00000001856B5EE0
	public AkPanningRule ePanningRule { get => default; set {} } // 0x0000000186485EB4-0x0000000186485F04 0x00000001856B5DE0-0x00000001856B5E40
	public AkChannelConfig channelConfig { get => default; set {} } // 0x00000001856B5C30-0x00000001856B5CC0 0x0000000186485F7C-0x0000000186485FE4

	// Constructors
	internal AkOutputSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkOutputSettings() {} // 0x0000000186485E14-0x0000000186485E64
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning) {} // 0x0000000186485D8C-0x0000000186485E14
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig) {} // 0x0000000186485C98-0x0000000186485D24
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice) {} // 0x0000000186485D24-0x0000000186485D8C
	public AkOutputSettings(string in_szDeviceShareSet) {} // 0x0000000186485C40-0x0000000186485C98

	// Methods
	internal static IntPtr getCPtr(AkOutputSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186485F54-0x0000000186485F7C
	~AkOutputSettings() {} // 0x0000000185C58630-0x0000000185C58680
	public void Dispose() {} // 0x0000000186485BF0-0x0000000186485C40
	protected virtual void Dispose(bool disposing) {} // 0x0000000185C58680-0x0000000185C58910
}

public enum AkPanningRule // TypeDefIndex: 54171
{
	AkPanningRule_Speakers = 0,
	AkPanningRule_Headphones = 1
}

public class AkPlaylist : AkPlaylistArray // TypeDefIndex: 54172
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Constructors
	internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000186487EE8-0x0000000186487F50
	public AkPlaylist() {} // 0x0000000186487E98-0x0000000186487EE8

	// Methods
	internal static IntPtr getCPtr(AkPlaylist obj) => default; // 0x000000018647E7C8-0x000000018647E7D8
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000186487F50-0x0000000186487FB0
	protected override void Dispose(bool disposing) {} // 0x0000000186487B08-0x0000000186487C38
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x0000000186487D70-0x0000000186487E20
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals) => default; // 0x0000000186487C9C-0x0000000186487D1C
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo) => default; // 0x0000000186487E20-0x0000000186487E98
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay) => default; // 0x0000000186487C38-0x0000000186487C9C
	public AKRESULT Enqueue(uint in_audioNodeID) => default; // 0x0000000186487D1C-0x0000000186487D70
}

public class AkPlaylistArray : IDisposable // TypeDefIndex: 54173
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkPlaylistArray() {} // 0x0000000186487470-0x00000001864874C0

	// Methods
	internal static IntPtr getCPtr(AkPlaylistArray obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864874C0-0x00000001864874E8
	~AkPlaylistArray() {} // 0x000000018647B834-0x000000018647B8AC
	public void Dispose() {} // 0x00000001864869A4-0x00000001864869F4
	protected virtual void Dispose(bool disposing) {} // 0x0000000186486890-0x00000001864869A4
	public AkIterator Begin() => default; // 0x0000000186486738-0x00000001864867AC
	public AkIterator End() => default; // 0x00000001864869F4-0x0000000186486A68
	public AkIterator FindEx(AkPlaylistItem in_Item) => default; // 0x0000000186486CC8-0x0000000186486D58
	public AkIterator Erase(AkIterator in_rIter) => default; // 0x0000000186486B4C-0x0000000186486BDC
	public void Erase(uint in_uIndex) {} // 0x0000000186486BDC-0x0000000186486C30
	public AkIterator EraseSwap(AkIterator in_rIter) => default; // 0x0000000186486A68-0x0000000186486AF8
	public void EraseSwap(uint in_uIndex) {} // 0x0000000186486AF8-0x0000000186486B4C
	public bool IsGrowingAllowed() => default; // 0x0000000186486F64-0x0000000186486FB4
	public AKRESULT Reserve(uint in_ulReserve) => default; // 0x00000001864872C0-0x0000000186487314
	public AKRESULT ReserveExtra(uint in_ulReserve) => default; // 0x000000018648726C-0x00000001864872C0
	public uint Reserved() => default; // 0x0000000186487314-0x0000000186487364
	public void Term() {} // 0x00000001864873B8-0x0000000186487408
	public uint Length() => default; // 0x00000001864870AC-0x00000001864870FC
	public AkPlaylistItem Data() => default; // 0x0000000186486814-0x0000000186486890
	public bool IsEmpty() => default; // 0x0000000186486F14-0x0000000186486F64
	public AkPlaylistItem Exists(AkPlaylistItem in_Item) => default; // 0x0000000186486C30-0x0000000186486CC8
	public AkPlaylistItem AddLast() => default; // 0x0000000186486624-0x00000001864866A0
	public AkPlaylistItem AddLast(AkPlaylistItem in_rItem) => default; // 0x00000001864866A0-0x0000000186486738
	public AkPlaylistItem Last() => default; // 0x0000000186487038-0x00000001864870AC
	public void RemoveLast() {} // 0x000000018648714C-0x000000018648719C
	public AKRESULT Remove(AkPlaylistItem in_rItem) => default; // 0x0000000186487204-0x000000018648726C
	public AKRESULT RemoveSwap(AkPlaylistItem in_rItem) => default; // 0x000000018648719C-0x0000000186487204
	public void RemoveAll() {} // 0x00000001864870FC-0x000000018648714C
	public AkPlaylistItem ItemAtIndex(uint uiIndex) => default; // 0x0000000186486FB4-0x0000000186487038
	public AkIterator Insert(AkIterator in_rIter) => default; // 0x0000000186486E84-0x0000000186486F14
	public AkPlaylistItem Insert(uint in_uIndex) => default; // 0x0000000186486DFC-0x0000000186486E84
	public bool GrowArray() => default; // 0x0000000186486D58-0x0000000186486DA8
	public bool GrowArray(uint in_uGrowBy) => default; // 0x0000000186486DA8-0x0000000186486DFC
	public bool Resize(uint in_uiSize) => default; // 0x0000000186487364-0x00000001864873B8
	public void Transfer(AkPlaylistArray in_rSource) {} // 0x0000000186487408-0x0000000186487470
	public AKRESULT Copy(AkPlaylistArray in_rSource) => default; // 0x00000001864867AC-0x0000000186486814
}

public class AkPlaylistItem : IDisposable // TypeDefIndex: 54174
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioNodeID { get => default; set {} } // 0x00000001864878F4-0x0000000186487944 0x0000000186487A0C-0x0000000186487A60
	public int msDelay { get => default; set {} } // 0x0000000186487944-0x0000000186487994 0x0000000186487A60-0x0000000186487AB4
	public IntPtr pCustomInfo { get => default; set {} } // 0x0000000186487994-0x00000001864879E4 0x0000000186487AB4-0x0000000186487B08

	// Constructors
	internal AkPlaylistItem(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkPlaylistItem() {} // 0x0000000186487838-0x0000000186487888
	public AkPlaylistItem(AkPlaylistItem in_rCopy) {} // 0x0000000186487888-0x00000001864878F4

	// Methods
	internal static IntPtr getCPtr(AkPlaylistItem obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864879E4-0x0000000186487A0C
	~AkPlaylistItem() {} // 0x00000001864876DC-0x0000000186487750
	public void Dispose() {} // 0x000000018648768C-0x00000001864876DC
	protected virtual void Dispose(bool disposing) {} // 0x0000000186487578-0x000000018648768C
	public AkPlaylistItem Assign(AkPlaylistItem in_rCopy) => default; // 0x00000001864874E8-0x0000000186487578
	public bool IsEqualTo(AkPlaylistItem in_rCopy) => default; // 0x0000000186487750-0x00000001864877B8
	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc) => default; // 0x00000001864877B8-0x0000000186487838
}

public enum AkPluginType // TypeDefIndex: 54175
{
	AkPluginTypeNone = 0,
	AkPluginTypeCodec = 1,
	AkPluginTypeSource = 2,
	AkPluginTypeEffect = 3,
	AkPluginTypeMixer = 6,
	AkPluginTypeSink = 7,
	AkPluginTypeGlobalExtension = 8,
	AkPluginTypeMetadata = 9,
	AkPluginTypeMask = 15
}

public class AkPositioningData : IDisposable // TypeDefIndex: 54176
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Ak3dData threeD { get => default; set {} } // 0x0000000186488254-0x00000001864882D0 0x0000000186488360-0x00000001864883C8
	public AkBehavioralPositioningData behavioral { get => default; set {} } // 0x00000001864881D8-0x0000000186488254 0x00000001864882F8-0x0000000186488360

	// Constructors
	internal AkPositioningData(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkPositioningData() {} // 0x0000000186488188-0x00000001864881D8

	// Methods
	internal static IntPtr getCPtr(AkPositioningData obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864882D0-0x00000001864882F8
	~AkPositioningData() {} // 0x0000000186488114-0x0000000186488188
	public void Dispose() {} // 0x0000000186487FB0-0x0000000186488000
	protected virtual void Dispose(bool disposing) {} // 0x0000000186488000-0x0000000186488114
}

public class AkPositioningInfo : IDisposable // TypeDefIndex: 54177
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fCenterPct { get => default; set {} } // 0x00000001864888C0-0x0000000186488910 0x0000000186488EBC-0x0000000186488F14
	public AkSpeakerPanningType pannerType { get => default; set {} } // 0x0000000186488B40-0x0000000186488B90 0x000000018648917C-0x00000001864891D0
	public Ak3DPositionType e3dPositioningType { get => default; set {} } // 0x0000000186488870-0x00000001864888C0 0x0000000186488E68-0x0000000186488EBC
	public bool bHoldEmitterPosAndOrient { get => default; set {} } // 0x0000000186488780-0x00000001864887D0 0x0000000186488D6C-0x0000000186488DC0
	public Ak3DSpatializationMode e3DSpatializationMode { get => default; set {} } // 0x0000000186488820-0x0000000186488870 0x0000000186488E14-0x0000000186488E68
	public bool bEnableAttenuation { get => default; set {} } // 0x0000000186488730-0x0000000186488780 0x0000000186488D18-0x0000000186488D6C
	public bool bUseConeAttenuation { get => default; set {} } // 0x00000001864887D0-0x0000000186488820 0x0000000186488DC0-0x0000000186488E14
	public float fInnerAngle { get => default; set {} } // 0x0000000186488960-0x00000001864889B0 0x0000000186488F6C-0x0000000186488FC4
	public float fOuterAngle { get => default; set {} } // 0x0000000186488A00-0x0000000186488A50 0x000000018648901C-0x0000000186489074
	public float fConeMaxAttenuation { get => default; set {} } // 0x0000000186488910-0x0000000186488960 0x0000000186488F14-0x0000000186488F6C
	public float LPFCone { get => default; set {} } // 0x0000000186488690-0x00000001864886E0 0x0000000186488C68-0x0000000186488CC0
	public float HPFCone { get => default; set {} } // 0x00000001864885F0-0x0000000186488640 0x0000000186488BB8-0x0000000186488C10
	public float fMaxDistance { get => default; set {} } // 0x00000001864889B0-0x0000000186488A00 0x0000000186488FC4-0x000000018648901C
	public float fVolDryAtMaxDist { get => default; set {} } // 0x0000000186488AF0-0x0000000186488B40 0x0000000186489124-0x000000018648917C
	public float fVolAuxGameDefAtMaxDist { get => default; set {} } // 0x0000000186488A50-0x0000000186488AA0 0x0000000186489074-0x00000001864890CC
	public float fVolAuxUserDefAtMaxDist { get => default; set {} } // 0x0000000186488AA0-0x0000000186488AF0 0x00000001864890CC-0x0000000186489124
	public float LPFValueAtMaxDist { get => default; set {} } // 0x00000001864886E0-0x0000000186488730 0x0000000186488CC0-0x0000000186488D18
	public float HPFValueAtMaxDist { get => default; set {} } // 0x0000000186488640-0x0000000186488690 0x0000000186488C10-0x0000000186488C68

	// Constructors
	internal AkPositioningInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkPositioningInfo() {} // 0x00000001864885A0-0x00000001864885F0

	// Methods
	internal static IntPtr getCPtr(AkPositioningInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186488B90-0x0000000186488BB8
	~AkPositioningInfo() {} // 0x000000018648852C-0x00000001864885A0
	public void Dispose() {} // 0x00000001864883C8-0x0000000186488418
	protected virtual void Dispose(bool disposing) {} // 0x0000000186488418-0x000000018648852C
}

public enum AkPreparationType // TypeDefIndex: 54178
{
	Preparation_Load = 0,
	Preparation_Unload = 1,
	Preparation_LoadAndDecode = 2
}

public enum AkQueryRTPCValue // TypeDefIndex: 54179
{
	RTPCValue_Default = 0,
	RTPCValue_Global = 1,
	RTPCValue_GameObject = 2,
	RTPCValue_PlayingID = 3,
	RTPCValue_Unavailable = 4
}

public class AkRamp : IDisposable // TypeDefIndex: 54180
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fPrev { get => default; set {} } // 0x00000001864894B0-0x0000000186489500 0x0000000186489580-0x00000001864895D8
	public float fNext { get => default; set {} } // 0x0000000186489460-0x00000001864894B0 0x0000000186489528-0x0000000186489580

	// Constructors
	internal AkRamp(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkRamp() {} // 0x0000000186489410-0x0000000186489460
	public AkRamp(float in_fPrev, float in_fNext) {} // 0x00000001864893A8-0x0000000186489410

	// Methods
	internal static IntPtr getCPtr(AkRamp obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186489500-0x0000000186489528
	~AkRamp() {} // 0x0000000186489334-0x00000001864893A8
	public void Dispose() {} // 0x00000001864892E4-0x0000000186489334
	protected virtual void Dispose(bool disposing) {} // 0x00000001864891D0-0x00000001864892E4
}

public class AkReflectionPathInfo : IDisposable // TypeDefIndex: 54181
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkVector64 imageSource { get => default; set {} } // 0x00000001864899F8-0x0000000186489A64 0x0000000186489BCC-0x0000000186489C38
	public uint numPathPoints { get => default; set {} } // 0x0000000186489B04-0x0000000186489B54 0x0000000186489CE4-0x0000000186489D38
	public uint numReflections { get => default; set {} } // 0x0000000186489B54-0x0000000186489BA4 0x0000000186489D38-0x0000000186489D8C
	public float level { get => default; set {} } // 0x0000000186489AB4-0x0000000186489B04 0x0000000186489C8C-0x0000000186489CE4
	public bool isOccluded { get => default; set {} } // 0x0000000186489A64-0x0000000186489AB4 0x0000000186489C38-0x0000000186489C8C

	// Constructors
	internal AkReflectionPathInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkReflectionPathInfo() {} // 0x00000001864899A8-0x00000001864899F8

	// Methods
	internal static IntPtr getCPtr(AkReflectionPathInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000186489BA4-0x0000000186489BCC
	~AkReflectionPathInfo() {} // 0x00000001864897A4-0x0000000186489818
	public void Dispose() {} // 0x0000000186489640-0x0000000186489690
	protected virtual void Dispose(bool disposing) {} // 0x0000000186489690-0x00000001864897A4
	public static int GetSizeOf() => default; // 0x0000000186489968-0x00000001864899A8
	public Vector3 GetPathPoint(uint idx) => default; // 0x00000001864898F0-0x0000000186489968
	public AkAcousticSurface GetAcousticSurface(uint idx) => default; // 0x0000000186489818-0x000000018648989C
	public float GetDiffraction(uint idx) => default; // 0x000000018648989C-0x00000001864898F0
	public void Clone(AkReflectionPathInfo other) {} // 0x00000001864895D8-0x0000000186489640
}

public class AkResourceMonitorDataSummary : IDisposable // TypeDefIndex: 54182
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float totalCPU { get => default; set {} } // 0x000000018648A0A4-0x000000018648A0F4 0x000000018648A2BC-0x000000018648A314
	public float pluginCPU { get => default; set {} } // 0x000000018648A054-0x000000018648A0A4 0x000000018648A264-0x000000018648A2BC
	public uint physicalVoices { get => default; set {} } // 0x000000018648A004-0x000000018648A054 0x000000018648A210-0x000000018648A264
	public uint virtualVoices { get => default; set {} } // 0x000000018648A144-0x000000018648A194 0x000000018648A368-0x000000018648A3BC
	public uint totalVoices { get => default; set {} } // 0x000000018648A0F4-0x000000018648A144 0x000000018648A314-0x000000018648A368
	public uint nbActiveEvents { get => default; set {} } // 0x0000000186489FB4-0x000000018648A004 0x000000018648A1BC-0x000000018648A210

	// Constructors
	internal AkResourceMonitorDataSummary(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkResourceMonitorDataSummary() {} // 0x0000000186489F64-0x0000000186489FB4

	// Methods
	internal static IntPtr getCPtr(AkResourceMonitorDataSummary obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018648A194-0x000000018648A1BC
	~AkResourceMonitorDataSummary() {} // 0x0000000186489EF0-0x0000000186489F64
	public void Dispose() {} // 0x0000000186489D8C-0x0000000186489DDC
	protected virtual void Dispose(bool disposing) {} // 0x0000000186489DDC-0x0000000186489EF0
}

public enum AKRESULT // TypeDefIndex: 54183
{
	AK_NotImplemented = 0,
	AK_Success = 1,
	AK_Fail = 2,
	AK_PartialSuccess = 3,
	AK_NotCompatible = 4,
	AK_AlreadyConnected = 5,
	AK_InvalidFile = 7,
	AK_AudioFileHeaderTooLarge = 8,
	AK_MaxReached = 9,
	AK_InvalidID = 14,
	AK_IDNotFound = 15,
	AK_InvalidInstanceID = 16,
	AK_NoMoreData = 17,
	AK_InvalidStateGroup = 20,
	AK_ChildAlreadyHasAParent = 21,
	AK_InvalidLanguage = 22,
	AK_CannotAddItselfAsAChild = 23,
	AK_InvalidParameter = 31,
	AK_ElementAlreadyInList = 35,
	AK_PathNotFound = 36,
	AK_PathNoVertices = 37,
	AK_PathNotRunning = 38,
	AK_PathNotPaused = 39,
	AK_PathNodeAlreadyInList = 40,
	AK_PathNodeNotInList = 41,
	AK_DataNeeded = 43,
	AK_NoDataNeeded = 44,
	AK_DataReady = 45,
	AK_NoDataReady = 46,
	AK_InsufficientMemory = 52,
	AK_Cancelled = 53,
	AK_UnknownBankID = 54,
	AK_BankReadError = 56,
	AK_InvalidSwitchType = 57,
	AK_FormatNotReady = 63,
	AK_WrongBankVersion = 64,
	AK_FileNotFound = 66,
	AK_DeviceNotReady = 67,
	AK_BankAlreadyLoaded = 69,
	AK_RenderedFX = 71,
	AK_ProcessNeeded = 72,
	AK_ProcessDone = 73,
	AK_MemManagerNotInitialized = 74,
	AK_StreamMgrNotInitialized = 75,
	AK_SSEInstructionsNotSupported = 76,
	AK_Busy = 77,
	AK_UnsupportedChannelConfig = 78,
	AK_PluginMediaNotAvailable = 79,
	AK_MustBeVirtualized = 80,
	AK_CommandTooLarge = 81,
	AK_RejectedByFilter = 82,
	AK_InvalidCustomPlatformName = 83,
	AK_DLLCannotLoad = 84,
	AK_DLLPathNotFound = 85,
	AK_NoJavaVM = 86,
	AK_OpenSLError = 87,
	AK_PluginNotRegistered = 88,
	AK_DataAlignmentError = 89,
	AK_DeviceNotCompatible = 90,
	AK_DuplicateUniqueID = 91,
	AK_InitBankNotLoaded = 92,
	AK_DeviceNotFound = 93,
	AK_PlayingIDNotFound = 94,
	AK_InvalidFloatValue = 95,
	AK_FileFormatMismatch = 96,
	AK_NoDistinctListener = 97,
	AK_ACP_Error = 98,
	AK_ResourceInUse = 99,
	AK_InvalidBankType = 100,
	AK_AlreadyInitialized = 101,
	AK_NotInitialized = 102,
	AK_FilePermissionError = 103,
	AK_UnknownFileError = 104,
	AK_TooManyConcurrentOperations = 105,
	AK_InvalidFileSize = 106,
	AK_Deferred = 107,
	AK_FilePathTooLong = 108,
	AK_InvalidState = 109
}

public class AkRoomParams : IDisposable // TypeDefIndex: 54184
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Vector3 Front { get => default; set {} } // 0x000000018648A594-0x000000018648A5FC 0x0000000184B68820-0x0000000184B688B0
	public Vector3 Up { get => default; set {} } // 0x000000018648A7DC-0x000000018648A844 0x0000000184B68740-0x0000000184B687D0
	public uint ReverbAuxBus { get => default; set {} } // 0x000000018648A5FC-0x000000018648A64C 0x0000000184B683A0-0x0000000184B68400
	public float ReverbLevel { get => default; set {} } // 0x000000018648A64C-0x000000018648A69C 0x0000000184B68680-0x0000000184B686F0
	public float TransmissionLoss { get => default; set {} } // 0x000000018648A78C-0x000000018648A7DC 0x0000000184B685C0-0x0000000184B68630
	public float RoomGameObj_AuxSendLevelToSelf { get => default; set {} } // 0x000000018648A69C-0x000000018648A6EC 0x0000000184B68500-0x0000000184B68570
	public bool RoomGameObj_KeepRegistered { get => default; set {} } // 0x000000018648A6EC-0x000000018648A73C 0x0000000184B68450-0x0000000184B684C0
	public uint RoomPriority { get => default; set {} } // 0x000000018648A73C-0x000000018648A78C 0x0000000184B682F0-0x0000000184B68350

	// Constructors
	internal AkRoomParams(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkRoomParams() {} // 0x0000000185D21D30-0x0000000185D21D80

	// Methods
	internal static IntPtr getCPtr(AkRoomParams obj) => default; // 0x0000000183FD9A90-0x0000000183FD9AA0
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018648A844-0x000000018648A86C
	~AkRoomParams() {} // 0x000000018648A520-0x000000018648A594
	public void Dispose() {} // 0x000000018648A4D0-0x000000018648A520
	protected virtual void Dispose(bool disposing) {} // 0x000000018648A3BC-0x000000018648A4D0
}

public class AkSegmentInfo : IDisposable // TypeDefIndex: 54185
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int iCurrentPosition { get => default; set {} } // 0x000000018648AC24-0x000000018648AC74 0x000000018648AF40-0x000000018648AF94
	public int iPreEntryDuration { get => default; set {} } // 0x000000018648ACC4-0x000000018648AD14 0x000000018648AFE8-0x000000018648B03C
	public int iActiveDuration { get => default; set {} } // 0x000000018648ABD4-0x000000018648AC24 0x000000018648AEEC-0x000000018648AF40
	public int iPostExitDuration { get => default; set {} } // 0x000000018648AC74-0x000000018648ACC4 0x000000018648AF94-0x000000018648AFE8
	public int iRemainingLookAheadTime { get => default; set {} } // 0x000000018648AD14-0x000000018648AD64 0x000000018648B03C-0x000000018648B090
	public float fBeatDuration { get => default; set {} } // 0x000000018648AAE4-0x000000018648AB34 0x000000018648ADE4-0x000000018648AE3C
	public float fBarDuration { get => default; set {} } // 0x000000018648AA94-0x000000018648AAE4 0x000000018648AD8C-0x000000018648ADE4
	public float fGridDuration { get => default; set {} } // 0x000000018648AB34-0x000000018648AB84 0x000000018648AE3C-0x000000018648AE94
	public float fGridOffset { get => default; set {} } // 0x000000018648AB84-0x000000018648ABD4 0x000000018648AE94-0x000000018648AEEC

	// Constructors
	internal AkSegmentInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkSegmentInfo() {} // 0x000000018648AA44-0x000000018648AA94

	// Methods
	internal static IntPtr getCPtr(AkSegmentInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018648AD64-0x000000018648AD8C
	~AkSegmentInfo() {} // 0x000000018648A9D0-0x000000018648AA44
	public void Dispose() {} // 0x000000018648A86C-0x000000018648A8BC
	protected virtual void Dispose(bool disposing) {} // 0x000000018648A8BC-0x000000018648A9D0
}

public class AkSerializedCallbackHeader : IDisposable // TypeDefIndex: 54186
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pPackage { get => default; } // 0x000000018648B3D4-0x000000018648B424 
	public uint eType { get => default; } // 0x000000018648B308-0x000000018648B358 
	public AkSerializedCallbackHeader pNext { get => default; } // 0x000000018648B358-0x000000018648B3D4 

	// Constructors
	internal AkSerializedCallbackHeader(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkSerializedCallbackHeader() {} // 0x000000018648B2B8-0x000000018648B308

	// Methods
	internal static IntPtr getCPtr(AkSerializedCallbackHeader obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018648B424-0x000000018648B44C
	~AkSerializedCallbackHeader() {} // 0x000000018648B1F4-0x000000018648B268
	public void Dispose() {} // 0x000000018648B090-0x000000018648B0E0
	protected virtual void Dispose(bool disposing) {} // 0x000000018648B0E0-0x000000018648B1F4
	public IntPtr GetData() => default; // 0x000000018648B268-0x000000018648B2B8
}

public enum AkSetPositionFlags // TypeDefIndex: 54187
{
	AkSetPositionFlags_Emitter = 1,
	AkSetPositionFlags_Listener = 2,
	AkSetPositionFlags_Default = 3
}

public enum AkSourceChannelOrdering // TypeDefIndex: 54188
{
	SourceChannelOrdering_Standard = 0,
	SourceChannelOrdering_Film = 1,
	SourceChannelOrdering_FuMa = 2,
	SourceChannelOrdering_Last = 3
}

public class AkSourceSettings : IDisposable // TypeDefIndex: 54189
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint sourceID { get => default; set {} } // 0x00000001864A41C0-0x00000001864A4210 0x00000001864A42DC-0x00000001864A4330
	public IntPtr pMediaMemory { get => default; set {} } // 0x00000001864A4170-0x00000001864A41C0 0x00000001864A4288-0x00000001864A42DC
	public uint uMediaSize { get => default; set {} } // 0x00000001864A4210-0x00000001864A4260 0x00000001864A4330-0x00000001864A4384

	// Constructors
	internal AkSourceSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkSourceSettings() {} // 0x00000001864A4120-0x00000001864A4170

	// Methods
	internal static IntPtr getCPtr(AkSourceSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A4260-0x00000001864A4288
	~AkSourceSettings() {} // 0x00000001864A406C-0x00000001864A40E0
	public void Dispose() {} // 0x00000001864A3F08-0x00000001864A3F58
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A3F58-0x00000001864A406C
	public void Clear() {} // 0x00000001864A3E50-0x00000001864A3EA0
	public static int GetSizeOf() => default; // 0x00000001864A40E0-0x00000001864A4120
	public void Clone(AkSourceSettings other) {} // 0x00000001864A3EA0-0x00000001864A3F08
}

public class AkSpatialAudioInitSettings : IDisposable // TypeDefIndex: 54190
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxSoundPropagationDepth { get => default; set {} } // 0x00000001864A4604-0x00000001864A4654 0x00000001855009C0-0x0000000185500A20
	public float fMovementThreshold { get => default; set {} } // 0x00000001864A4514-0x00000001864A4564 0x0000000185500910-0x0000000185500970
	public uint uNumberOfPrimaryRays { get => default; set {} } // 0x00000001854FF3D0-0x00000001854FF420 0x0000000185500870-0x00000001855008D0
	public uint uMaxReflectionOrder { get => default; set {} } // 0x0000000185500E50-0x0000000185500EA0 0x00000001855007D0-0x0000000185500830
	public uint uMaxDiffractionOrder { get => default; set {} } // 0x0000000185500DC0-0x0000000185500E10 0x0000000185500730-0x0000000185500790
	public uint uMaxEmitterRoomAuxSends { get => default; set {} } // 0x00000001864A45B4-0x00000001864A4604 0x0000000185500690-0x00000001855006F0
	public uint uDiffractionOnReflectionsOrder { get => default; set {} } // 0x00000001864A4564-0x00000001864A45B4 0x00000001855005F0-0x0000000185500650
	public float fMaxPathLength { get => default; set {} } // 0x00000001864A44C4-0x00000001864A4514 0x0000000185500540-0x00000001855005A0
	public float fCPULimitPercentage { get => default; set {} } // 0x00000001864A4474-0x00000001864A44C4 0x0000000185500490-0x00000001855004F0
	public uint uLoadBalancingSpread { get => default; set {} } // 0x0000000185500D30-0x0000000185500D80 0x00000001855003F0-0x0000000185500450
	public bool bEnableGeometricDiffractionAndTransmission { get => default; set {} } // 0x00000001864A4424-0x00000001864A4474 0x0000000185500340-0x00000001855003A0
	public bool bCalcEmitterVirtualPosition { get => default; set {} } // 0x00000001864A43D4-0x00000001864A4424 0x0000000185500290-0x00000001855002F0

	// Constructors
	internal AkSpatialAudioInitSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkSpatialAudioInitSettings() {} // 0x0000000185500090-0x00000001855000F0

	// Methods
	internal static IntPtr getCPtr(AkSpatialAudioInitSettings obj) => default; // 0x0000000183FD9A90-0x0000000183FD9AA0
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A4654-0x00000001864A467C
	~AkSpatialAudioInitSettings() {} // 0x0000000185A178A0-0x0000000185A178F0
	public void Dispose() {} // 0x00000001864A4384-0x00000001864A43D4
	protected virtual void Dispose(bool disposing) {} // 0x0000000185A178F0-0x0000000185A17C20
}

public enum AkSpeakerPanningType // TypeDefIndex: 54191
{
	AK_DirectSpeakerAssignment = 0,
	AK_BalanceFadeHeight = 1,
	AK_SteeringPanner = 2
}

public class AkStdMovePolicy : IDisposable // TypeDefIndex: 54192
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkStdMovePolicy(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkStdMovePolicy() {} // 0x00000001864A4894-0x00000001864A48E4

	// Methods
	internal static IntPtr getCPtr(AkStdMovePolicy obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A48E4-0x00000001864A490C
	~AkStdMovePolicy() {} // 0x00000001864A47E0-0x00000001864A4854
	public void Dispose() {} // 0x00000001864A467C-0x00000001864A46CC
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A46CC-0x00000001864A47E0
	public static bool IsTrivial() => default; // 0x00000001864A4854-0x00000001864A4894
}

public class AkStreamMgrSettings : IDisposable // TypeDefIndex: 54193
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	public AkStreamMgrSettings() {} // Dummy constructor
	internal AkStreamMgrSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40

	// Methods
	internal static IntPtr getCPtr(AkStreamMgrSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A495C-0x00000001864A4984
	~AkStreamMgrSettings() {} // 0x0000000185C58350-0x0000000185C583A0
	public void Dispose() {} // 0x00000001864A490C-0x00000001864A495C
	protected virtual void Dispose(bool disposing) {} // 0x0000000185C583A0-0x0000000185C58630
}

public class AkTransform : IDisposable // TypeDefIndex: 54194
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkTransform(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkTransform() {} // 0x00000001864A5048-0x00000001864A5098

	// Methods
	internal static IntPtr getCPtr(AkTransform obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A5098-0x00000001864A50C0
	~AkTransform() {} // 0x00000001864A4AE8-0x00000001864A4B5C
	public void Dispose() {} // 0x00000001864A4A98-0x00000001864A4AE8
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A4984-0x00000001864A4A98
	public Vector3 Position() => default; // 0x00000001864A4C2C-0x00000001864A4C94
	public Vector3 OrientationFront() => default; // 0x00000001864A4B5C-0x00000001864A4BC4
	public Vector3 OrientationTop() => default; // 0x00000001864A4BC4-0x00000001864A4C2C
	public void Set(Vector3 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop) {} // 0x00000001864A4EB4-0x00000001864A4F68
	public void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) {} // 0x00000001864A4F68-0x00000001864A5048
	public void SetPosition(Vector3 in_position) {} // 0x00000001864A4DCC-0x00000001864A4E34
	public void SetPosition(float in_x, float in_y, float in_z) {} // 0x00000001864A4E34-0x00000001864A4EB4
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop) {} // 0x00000001864A4C94-0x00000001864A4D20
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) {} // 0x00000001864A4D20-0x00000001864A4DCC
}

public class AkTriangle : IDisposable // TypeDefIndex: 54195
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ushort point0 { get => default; set {} } // 0x00000001864A5464-0x00000001864A54B4 0x00000001864A55CC-0x00000001864A5620
	public ushort point1 { get => default; set {} } // 0x00000001864A54B4-0x00000001864A5504 0x00000001864A5620-0x00000001864A5674
	public ushort point2 { get => default; set {} } // 0x00000001864A5504-0x00000001864A5554 0x00000001864A5674-0x00000001864A56C8
	public ushort surface { get => default; set {} } // 0x00000001864A5554-0x00000001864A55A4 0x00000001864A56C8-0x00000001864A571C

	// Constructors
	internal AkTriangle(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkTriangle() {} // 0x00000001864A5390-0x00000001864A53E0
	public AkTriangle(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo) {} // 0x00000001864A53E0-0x00000001864A5464

	// Methods
	internal static IntPtr getCPtr(AkTriangle obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A55A4-0x00000001864A55CC
	~AkTriangle() {} // 0x00000001864A52DC-0x00000001864A5350
	public void Dispose() {} // 0x00000001864A528C-0x00000001864A52DC
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A5178-0x00000001864A528C
	public void Clear() {} // 0x00000001864A50C0-0x00000001864A5110
	public static int GetSizeOf() => default; // 0x00000001864A5350-0x00000001864A5390
	public void Clone(AkTriangle other) {} // 0x00000001864A5110-0x00000001864A5178
}

public class AkTrivialStdMovePolicy : IDisposable // TypeDefIndex: 54196
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkTrivialStdMovePolicy(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkTrivialStdMovePolicy() {} // 0x00000001864A5934-0x00000001864A5984

	// Methods
	internal static IntPtr getCPtr(AkTrivialStdMovePolicy obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A5984-0x00000001864A59AC
	~AkTrivialStdMovePolicy() {} // 0x00000001864A5880-0x00000001864A58F4
	public void Dispose() {} // 0x00000001864A5830-0x00000001864A5880
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A571C-0x00000001864A5830
	public static bool IsTrivial() => default; // 0x00000001864A58F4-0x00000001864A5934
}

public class AkWorldTransform : IDisposable // TypeDefIndex: 54197
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkWorldTransform(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkWorldTransform() {} // 0x00000001864A607C-0x00000001864A60CC

	// Methods
	internal static IntPtr getCPtr(AkWorldTransform obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A60CC-0x00000001864A60F4
	~AkWorldTransform() {} // 0x00000001864A5B10-0x00000001864A5B84
	public void Dispose() {} // 0x00000001864A59AC-0x00000001864A59FC
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A59FC-0x00000001864A5B10
	public AkVector64 Position() => default; // 0x00000001864A5C54-0x00000001864A5CC0
	public Vector3 OrientationFront() => default; // 0x00000001864A5B84-0x00000001864A5BEC
	public Vector3 OrientationTop() => default; // 0x00000001864A5BEC-0x00000001864A5C54
	public void Set(AkVector64 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop) {} // 0x00000001864A5FC4-0x00000001864A607C
	public void Set(double in_positionX, double in_positionY, double in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) {} // 0x00000001864A5EE4-0x00000001864A5FC4
	public void SetPosition(AkVector64 in_position) {} // 0x00000001864A5DF8-0x00000001864A5E64
	public void SetPosition(double in_x, double in_y, double in_z) {} // 0x00000001864A5E64-0x00000001864A5EE4
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop) {} // 0x00000001864A5D6C-0x00000001864A5DF8
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) {} // 0x00000001864A5CC0-0x00000001864A5D6C
}

public class MonitorErrorInfo : IDisposable // TypeDefIndex: 54198
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public string m_name { get => default; set {} } // 0x00000001864A6448-0x00000001864A64B4 0x00000001864A6530-0x00000001864A6584
	public string m_message { get => default; set {} } // 0x00000001864A63DC-0x00000001864A6448 0x00000001864A64DC-0x00000001864A6530

	// Constructors
	internal MonitorErrorInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public MonitorErrorInfo(string in_name, string in_message) {} // 0x00000001864A62CC-0x00000001864A6334
	public MonitorErrorInfo(string in_name) {} // 0x00000001864A6334-0x00000001864A638C
	public MonitorErrorInfo() {} // 0x00000001864A638C-0x00000001864A63DC

	// Methods
	internal static IntPtr getCPtr(MonitorErrorInfo obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A64B4-0x00000001864A64DC
	~MonitorErrorInfo() {} // 0x00000001864A6258-0x00000001864A62CC
	public void Dispose() {} // 0x00000001864A6208-0x00000001864A6258
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A60F4-0x00000001864A6208
}

public class MsgContext : IDisposable // TypeDefIndex: 54199
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint in_playingID { get => default; set {} } // 0x00000001864A69F4-0x00000001864A6A44 0x00000001864A6B64-0x00000001864A6BB8
	public ulong in_gameObjID { get => default; set {} } // 0x00000001864A69A4-0x00000001864A69F4 0x00000001864A6B10-0x00000001864A6B64
	public uint in_soundID { get => default; set {} } // 0x00000001864A6A44-0x00000001864A6A94 0x00000001864A6BB8-0x00000001864A6C0C
	public bool in_bIsBus { get => default; set {} } // 0x00000001864A6954-0x00000001864A69A4 0x00000001864A6ABC-0x00000001864A6B10

	// Constructors
	internal MsgContext(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public MsgContext(uint pId, ulong goId, uint nodeId, bool isBus) {} // 0x00000001864A68D8-0x00000001864A6954
	public MsgContext(uint pId, ulong goId, uint nodeId) {} // 0x00000001864A675C-0x00000001864A67D0
	public MsgContext(uint pId, ulong goId) {} // 0x00000001864A6874-0x00000001864A68D8
	public MsgContext(uint pId) {} // 0x00000001864A6820-0x00000001864A6874
	public MsgContext() {} // 0x00000001864A67D0-0x00000001864A6820

	// Methods
	internal static IntPtr getCPtr(MsgContext obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864A6A94-0x00000001864A6ABC
	~MsgContext() {} // 0x00000001864A66E8-0x00000001864A675C
	public void Dispose() {} // 0x00000001864A6698-0x00000001864A66E8
	protected virtual void Dispose(bool disposing) {} // 0x00000001864A6584-0x00000001864A6698
}

public class AkCommunicationSettings : IDisposable // TypeDefIndex: 54201
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uPoolSize { get => default; set {} } // 0x000000018647CCA8-0x000000018647CCF8 0x000000018647CEC4-0x000000018647CF18
	public ushort uDiscoveryBroadcastPort { get => default; set {} } // 0x000000018647CC58-0x000000018647CCA8 0x000000018647CE70-0x000000018647CEC4
	public ushort uCommandPort { get => default; set {} } // 0x000000018647CC08-0x000000018647CC58 0x000000018647CE1C-0x000000018647CE70
	public AkCommSystem commSystem { get => default; set {} } // 0x000000018647CB4C-0x000000018647CB9C 0x000000018647CD74-0x000000018647CDC8
	public bool bInitSystemLib { get => default; set {} } // 0x000000018647CAFC-0x000000018647CB4C 0x000000018647CD20-0x000000018647CD74
	public string szAppNetworkName { get => default; set {} } // 0x000000018647CB9C-0x000000018647CC08 0x000000018647CDC8-0x000000018647CE1C

	// Nested types
	public enum AkCommSystem // TypeDefIndex: 54200
	{
		AkCommSystem_Socket = 0,
		AkCommSystem_HTCS = 1
	}

	// Constructors
	internal AkCommunicationSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkCommunicationSettings() {} // 0x000000018647CAAC-0x000000018647CAFC

	// Methods
	internal static IntPtr getCPtr(AkCommunicationSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018647CCF8-0x000000018647CD20
	~AkCommunicationSettings() {} // 0x000000018647CA38-0x000000018647CAAC
	public void Dispose() {} // 0x000000018647C8D4-0x000000018647C924
	protected virtual void Dispose(bool disposing) {} // 0x000000018647C924-0x000000018647CA38
}

public class AkPlatformInitSettings : IDisposable // TypeDefIndex: 54202
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkThreadProperties threadLEngine { get => default; set {} } // 0x0000000186486150-0x00000001864861CC 0x00000001864864EC-0x0000000186486554
	public AkThreadProperties threadOutputMgr { get => default; set {} } // 0x0000000186486248-0x00000001864862C4 0x00000001864865BC-0x0000000186486624
	public AkThreadProperties threadBankManager { get => default; set {} } // 0x00000001864860D4-0x0000000186486150 0x0000000186486484-0x00000001864864EC
	public AkThreadProperties threadMonitor { get => default; set {} } // 0x00000001864861CC-0x0000000186486248 0x0000000186486554-0x00000001864865BC
	public ushort uNumRefillsInVoice { get => default; set {} } // 0x0000000186486314-0x0000000186486364 0x0000000185501500-0x0000000185501560
	public uint uSampleRate { get => default; set {} } // 0x0000000186486364-0x00000001864863B4 0x00000001855015B0-0x0000000185501610
	public bool bEnableAvxSupport { get => default; set {} } // 0x0000000186486034-0x0000000186486084 0x00000001864863DC-0x0000000186486430
	public uint uMaxSystemAudioObjects { get => default; set {} } // 0x00000001864862C4-0x0000000186486314 0x0000000185EE6220-0x0000000185EE6280
	public bool bEnableDirectInputSupport { get => default; set {} } // 0x0000000186486084-0x00000001864860D4 0x0000000186486430-0x0000000186486484

	// Constructors
	public AkPlatformInitSettings() {} // Dummy constructor
	internal AkPlatformInitSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40

	// Methods
	internal static IntPtr getCPtr(AkPlatformInitSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864863B4-0x00000001864863DC
	~AkPlatformInitSettings() {} // 0x0000000185AE53D0-0x0000000185AE5420
	public void Dispose() {} // 0x0000000186485FE4-0x0000000186486034
	protected virtual void Dispose(bool disposing) {} // 0x0000000185AE5420-0x0000000185AE56D0
}

internal class AkSoundEnginePINVOKE // TypeDefIndex: 54203
{
	// Constructors
	static AkSoundEnginePINVOKE() {} // 0x0000000185492010-0x0000000185492020
	public AkSoundEnginePINVOKE() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public static extern uint CSharp_JoystickIdToWwiseId(uint jarg1); // 0x000000018649A46C-0x000000018649A4E4
	public static extern uint CSharp_AK_INVALID_SHARE_SET_ID_get(); // 0x000000018648B6AC-0x000000018648B6D8
	public static extern uint CSharp_AK_INVALID_PIPELINE_ID_get(); // 0x000000018648B680-0x000000018648B6AC
	public static extern ulong CSharp_AK_INVALID_AUDIO_OBJECT_ID_get(); // 0x000000018648B584-0x000000018648B5EC
	public static extern uint CSharp_AK_SOUNDBANK_VERSION_get(); // 0x000000018648B7B4-0x000000018648B81C
	public static extern uint CSharp_AkJobType_Generic_get(); // 0x00000001864900F0-0x000000018649011C
	public static extern uint CSharp_AkJobType_AudioProcessing_get(); // 0x00000001864900C4-0x00000001864900F0
	public static extern uint CSharp_AkJobType_SpatialAudio_get(); // 0x000000018649011C-0x0000000186490184
	public static extern uint CSharp_AK_NUM_JOB_TYPES_get(); // 0x000000018648B788-0x000000018648B7B4
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2); // 0x000000018648C898-0x000000018648C8D8
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerFrame_get(IntPtr jarg1); // 0x000000018648C864-0x000000018648C898
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(IntPtr jarg1, uint jarg2); // 0x000000018648C90C-0x000000018648C94C
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerSecond_get(IntPtr jarg1); // 0x000000018648C8D8-0x000000018648C90C
	public static extern IntPtr CSharp_new_AkAudioSettings(); // 0x00000001864A2A08-0x00000001864A2A34
	public static extern void CSharp_delete_AkAudioSettings(IntPtr jarg1); // 0x00000001864A1A5C-0x00000001864A1A90
	public static extern void CSharp_AkDeviceDescription_idDevice_set(IntPtr jarg1, uint jarg2); // 0x000000018648DF10-0x000000018648DF50
	public static extern uint CSharp_AkDeviceDescription_idDevice_get(IntPtr jarg1); // 0x0000000184A7A7D0-0x0000000184A7A810
	public static extern void CSharp_AkDeviceDescription_deviceName_set(IntPtr jarg1, string jarg2); // 0x000000018648DE10-0x000000018648DE9C
	public static extern IntPtr CSharp_AkDeviceDescription_deviceName_get(IntPtr jarg1); // 0x000000018648DDDC-0x000000018648DE10
	public static extern void CSharp_AkDeviceDescription_deviceStateMask_set(IntPtr jarg1, int jarg2); // 0x000000018648DED0-0x000000018648DF10
	public static extern int CSharp_AkDeviceDescription_deviceStateMask_get(IntPtr jarg1); // 0x000000018648DE9C-0x000000018648DED0
	public static extern void CSharp_AkDeviceDescription_isDefaultDevice_set(IntPtr jarg1, bool jarg2); // 0x000000018648DF50-0x000000018648DF94
	public static extern bool CSharp_AkDeviceDescription_isDefaultDevice_get(IntPtr jarg1); // 0x0000000184A7A620-0x0000000184A7A660
	public static extern void CSharp_AkDeviceDescription_Clear(IntPtr jarg1); // 0x00000001858C1710-0x00000001858C17A0
	public static extern int CSharp_AkDeviceDescription_GetSizeOf(); // 0x00000001857744B0-0x00000001857748C0
	public static extern void CSharp_AkDeviceDescription_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018648DD98-0x000000018648DDDC
	public static extern IntPtr CSharp_new_AkDeviceDescription(); // 0x00000001864A2BE8-0x00000001864A2C14
	public static extern void CSharp_delete_AkDeviceDescription(IntPtr jarg1); // 0x00000001864A1C30-0x00000001864A1C64
	public static extern AkVector64 CSharp_AkWorldTransform_Position(IntPtr jarg1); // 0x00000001864969B0-0x0000000186496A48
	public static extern Vector3 CSharp_AkWorldTransform_OrientationFront(IntPtr jarg1); // 0x0000000186496888-0x000000018649691C
	public static extern Vector3 CSharp_AkWorldTransform_OrientationTop(IntPtr jarg1); // 0x000000018649691C-0x00000001864969B0
	public static extern void CSharp_AkWorldTransform_Set__SWIG_0(IntPtr jarg1, AkVector64 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x0000000186496C60-0x0000000186496D3C
	public static extern void CSharp_AkWorldTransform_Set__SWIG_1(IntPtr jarg1, double jarg2, double jarg3, double jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10); // 0x0000000186496D3C-0x0000000186496DA4
	public static extern void CSharp_AkWorldTransform_SetPosition__SWIG_0(IntPtr jarg1, AkVector64 jarg2); // 0x0000000186496B64-0x0000000186496C00
	public static extern void CSharp_AkWorldTransform_SetPosition__SWIG_1(IntPtr jarg1, double jarg2, double jarg3, double jarg4); // 0x0000000186496C00-0x0000000186496C60
	public static extern void CSharp_AkWorldTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3); // 0x0000000186496A48-0x0000000186496B04
	public static extern void CSharp_AkWorldTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7); // 0x0000000186496B04-0x0000000186496B64
	public static extern IntPtr CSharp_new_AkWorldTransform(); // 0x00000001864A3A90-0x00000001864A3ABC
	public static extern void CSharp_delete_AkWorldTransform(IntPtr jarg1); // 0x00000001864A2728-0x00000001864A275C
	public static extern Vector3 CSharp_AkTransform_Position(IntPtr jarg1); // 0x0000000186496368-0x00000001864963FC
	public static extern Vector3 CSharp_AkTransform_OrientationFront(IntPtr jarg1); // 0x0000000186496240-0x00000001864962D4
	public static extern Vector3 CSharp_AkTransform_OrientationTop(IntPtr jarg1); // 0x00000001864962D4-0x0000000186496368
	public static extern void CSharp_AkTransform_Set__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x0000000184B68F80-0x0000000184B69020
	public static extern void CSharp_AkTransform_Set__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10); // 0x0000000186496610-0x0000000186496678
	public static extern void CSharp_AkTransform_SetPosition__SWIG_0(IntPtr jarg1, Vector3 jarg2); // 0x0000000186496518-0x00000001864965B0
	public static extern void CSharp_AkTransform_SetPosition__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4); // 0x00000001864965B0-0x0000000186496610
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3); // 0x00000001864963FC-0x00000001864964B8
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7); // 0x00000001864964B8-0x0000000186496518
	public static extern IntPtr CSharp_new_AkTransform(); // 0x00000001854FEEC0-0x00000001854FEEF0
	public static extern void CSharp_delete_AkTransform(IntPtr jarg1); // 0x00000001864A2658-0x00000001864A268C
	public static extern Vector3 CSharp_ConvertAkVector64ToAkVector(AkVector64 jarg1); // 0x0000000186497230-0x00000001864972DC
	public static extern IntPtr CSharp_ConvertAkWorldTransformToAkTransform(IntPtr jarg1); // 0x0000000186497388-0x00000001864973BC
	public static extern AkVector64 CSharp_ConvertAkVectorToAkVector64(Vector3 jarg1); // 0x00000001864972DC-0x0000000186497388
	public static extern IntPtr CSharp_ConvertAkTransformToAkWorldTransform(IntPtr jarg1); // 0x00000001864971FC-0x0000000186497230
	public static extern void CSharp_AkObstructionOcclusionValues_occlusion_set(IntPtr jarg1, float jarg2); // 0x0000000186492E18-0x0000000186492E5C
	public static extern float CSharp_AkObstructionOcclusionValues_occlusion_get(IntPtr jarg1); // 0x0000000186492DE4-0x0000000186492E18
	public static extern void CSharp_AkObstructionOcclusionValues_obstruction_set(IntPtr jarg1, float jarg2); // 0x0000000186492DA0-0x0000000186492DE4
	public static extern float CSharp_AkObstructionOcclusionValues_obstruction_get(IntPtr jarg1); // 0x0000000186492D6C-0x0000000186492DA0
	public static extern void CSharp_AkObstructionOcclusionValues_Clear(IntPtr jarg1); // 0x0000000186492CC8-0x0000000186492CFC
	public static extern int CSharp_AkObstructionOcclusionValues_GetSizeOf(); // 0x0000000186492D40-0x0000000186492D6C
	public static extern void CSharp_AkObstructionOcclusionValues_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000186492CFC-0x0000000186492D40
	public static extern IntPtr CSharp_new_AkObstructionOcclusionValues(); // 0x00000001864A33A4-0x00000001864A33D0
	public static extern void CSharp_delete_AkObstructionOcclusionValues(IntPtr jarg1); // 0x00000001864A22B0-0x00000001864A22E4
	public static extern void CSharp_AkChannelEmitter_position_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648D838-0x000000018648D87C
	public static extern IntPtr CSharp_AkChannelEmitter_position_get(IntPtr jarg1); // 0x000000018648D7FC-0x000000018648D838
	public static extern void CSharp_AkChannelEmitter_uInputChannels_set(IntPtr jarg1, uint jarg2); // 0x000000018648D8B0-0x000000018648D8F0
	public static extern uint CSharp_AkChannelEmitter_uInputChannels_get(IntPtr jarg1); // 0x000000018648D87C-0x000000018648D8B0
	public static extern void CSharp_AkChannelEmitter_padding_set(IntPtr jarg1, string jarg2); // 0x000000018648D768-0x000000018648D7FC
	public static extern IntPtr CSharp_AkChannelEmitter_padding_get(IntPtr jarg1); // 0x000000018648D734-0x000000018648D768
	public static extern void CSharp_delete_AkChannelEmitter(IntPtr jarg1); // 0x00000001864A1BC8-0x00000001864A1BFC
	public static extern void CSharp_AkAuxSendValue_listenerID_set(IntPtr jarg1, ulong jarg2); // 0x000000018648CC40-0x000000018648CCC4
	public static extern ulong CSharp_AkAuxSendValue_listenerID_get(IntPtr jarg1); // 0x000000018648CBC8-0x000000018648CC40
	public static extern void CSharp_AkAuxSendValue_auxBusID_set(IntPtr jarg1, uint jarg2); // 0x000000018648CAD8-0x000000018648CB58
	public static extern uint CSharp_AkAuxSendValue_auxBusID_get(IntPtr jarg1); // 0x000000018648CAA4-0x000000018648CAD8
	public static extern void CSharp_AkAuxSendValue_fControlValue_set(IntPtr jarg1, float jarg2); // 0x000000018648CB84-0x000000018648CBC8
	public static extern float CSharp_AkAuxSendValue_fControlValue_get(IntPtr jarg1); // 0x000000018648CB58-0x000000018648CB84
	public static extern void CSharp_AkAuxSendValue_Set(IntPtr jarg1, ulong jarg2, uint jarg3, float jarg4); // 0x000000018648CA48-0x000000018648CAA4
	public static extern bool CSharp_AkAuxSendValue_IsSame(IntPtr jarg1, ulong jarg2, uint jarg3); // 0x000000018648C9B0-0x000000018648CA48
	public static extern int CSharp_AkAuxSendValue_GetSizeOf(); // 0x000000018648C984-0x000000018648C9B0
	public static extern void CSharp_delete_AkAuxSendValue(IntPtr jarg1); // 0x00000001864A1AC4-0x00000001864A1AF8
	public static extern IntPtr CSharp_new_AkRamp__SWIG_0(); // 0x00000001864A37E8-0x00000001864A381C
	public static extern IntPtr CSharp_new_AkRamp__SWIG_1(float jarg1, float jarg2); // 0x00000001864A381C-0x00000001864A3860
	public static extern void CSharp_AkRamp_fPrev_set(IntPtr jarg1, float jarg2); // 0x0000000186494E2C-0x0000000186494E70
	public static extern float CSharp_AkRamp_fPrev_get(IntPtr jarg1); // 0x0000000186494DF8-0x0000000186494E2C
	public static extern void CSharp_AkRamp_fNext_set(IntPtr jarg1, float jarg2); // 0x0000000186494DBC-0x0000000186494DF8
	public static extern float CSharp_AkRamp_fNext_get(IntPtr jarg1); // 0x0000000186494D88-0x0000000186494DBC
	public static extern void CSharp_delete_AkRamp(IntPtr jarg1); // 0x00000001864A2450-0x00000001864A2484
	public static extern ushort CSharp_AK_INT_get(); // 0x000000018648B51C-0x000000018648B584
	public static extern ushort CSharp_AK_FLOAT_get(); // 0x000000018648B44C-0x000000018648B4B4
	public static extern byte CSharp_AK_INTERLEAVED_get(); // 0x000000018648B4B4-0x000000018648B51C
	public static extern byte CSharp_AK_NONINTERLEAVED_get(); // 0x000000018648B75C-0x000000018648B788
	public static extern uint CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get(); // 0x000000018648B6D8-0x000000018648B704
	public static extern uint CSharp_AK_LE_NATIVE_SAMPLETYPE_get(); // 0x000000018648B730-0x000000018648B75C
	public static extern uint CSharp_AK_LE_NATIVE_INTERLEAVE_get(); // 0x000000018648B704-0x000000018648B730
	public static extern void CSharp_AkAudioFormat_uSampleRate_set(IntPtr jarg1, uint jarg2); // 0x000000018648C778-0x000000018648C7B8
	public static extern uint CSharp_AkAudioFormat_uSampleRate_get(IntPtr jarg1); // 0x000000018648C744-0x000000018648C778
	public static extern void CSharp_AkAudioFormat_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648C568-0x000000018648C5E8
	public static extern IntPtr CSharp_AkAudioFormat_channelConfig_get(IntPtr jarg1); // 0x000000018648C52C-0x000000018648C568
	public static extern void CSharp_AkAudioFormat_uBitsPerSample_set(IntPtr jarg1, uint jarg2); // 0x000000018648C61C-0x000000018648C65C
	public static extern uint CSharp_AkAudioFormat_uBitsPerSample_get(IntPtr jarg1); // 0x000000018648C5E8-0x000000018648C61C
	public static extern void CSharp_AkAudioFormat_uBlockAlign_set(IntPtr jarg1, uint jarg2); // 0x000000018648C690-0x000000018648C6D0
	public static extern uint CSharp_AkAudioFormat_uBlockAlign_get(IntPtr jarg1); // 0x000000018648C65C-0x000000018648C690
	public static extern void CSharp_AkAudioFormat_uTypeID_set(IntPtr jarg1, uint jarg2); // 0x000000018648C7EC-0x000000018648C82C
	public static extern uint CSharp_AkAudioFormat_uTypeID_get(IntPtr jarg1); // 0x000000018648C7B8-0x000000018648C7EC
	public static extern void CSharp_AkAudioFormat_uInterleaveID_set(IntPtr jarg1, uint jarg2); // 0x000000018648C704-0x000000018648C744
	public static extern uint CSharp_AkAudioFormat_uInterleaveID_get(IntPtr jarg1); // 0x000000018648C6D0-0x000000018648C704
	public static extern uint CSharp_AkAudioFormat_GetNumChannels(IntPtr jarg1); // 0x000000018648C424-0x000000018648C458
	public static extern uint CSharp_AkAudioFormat_GetBitsPerSample(IntPtr jarg1); // 0x000000018648C344-0x000000018648C3BC
	public static extern uint CSharp_AkAudioFormat_GetBlockAlign(IntPtr jarg1); // 0x000000018648C3BC-0x000000018648C3F0
	public static extern uint CSharp_AkAudioFormat_GetTypeID(IntPtr jarg1); // 0x000000018648C458-0x000000018648C48C
	public static extern uint CSharp_AkAudioFormat_GetInterleaveID(IntPtr jarg1); // 0x000000018648C3F0-0x000000018648C424
	public static extern void CSharp_AkAudioFormat_SetAll(IntPtr jarg1, uint jarg2, IntPtr jarg3, uint jarg4, uint jarg5, uint jarg6, uint jarg7); // 0x000000018648C48C-0x000000018648C52C
	public static extern IntPtr CSharp_new_AkAudioFormat(); // 0x00000001864A29B0-0x00000001864A29DC
	public static extern void CSharp_delete_AkAudioFormat(IntPtr jarg1); // 0x00000001864A19B0-0x00000001864A1A28
	public static extern bool CSharp_IsBankCodecID(uint jarg1); // 0x000000018649A3A0-0x000000018649A3D8
	public static extern IntPtr CSharp_new_Ak3dData(); // 0x00000001864A2958-0x00000001864A2984
	public static extern void CSharp_Ak3dData_xform_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648C158-0x000000018648C19C
	public static extern IntPtr CSharp_Ak3dData_xform_get(IntPtr jarg1); // 0x000000018648C11C-0x000000018648C158
	public static extern void CSharp_Ak3dData_spread_set(IntPtr jarg1, float jarg2); // 0x000000018648C064-0x000000018648C0A8
	public static extern float CSharp_Ak3dData_spread_get(IntPtr jarg1); // 0x000000018648C030-0x000000018648C064
	public static extern void CSharp_Ak3dData_focus_set(IntPtr jarg1, float jarg2); // 0x000000018648BFEC-0x000000018648C030
	public static extern float CSharp_Ak3dData_focus_get(IntPtr jarg1); // 0x000000018648BFB8-0x000000018648BFEC
	public static extern void CSharp_Ak3dData_uEmitterChannelMask_set(IntPtr jarg1, uint jarg2); // 0x000000018648C0DC-0x000000018648C11C
	public static extern uint CSharp_Ak3dData_uEmitterChannelMask_get(IntPtr jarg1); // 0x000000018648C0A8-0x000000018648C0DC
	public static extern void CSharp_delete_Ak3dData(IntPtr jarg1); // 0x00000001864A1904-0x00000001864A197C
	public static extern IntPtr CSharp_new_AkBehavioralPositioningData(); // 0x00000001864A2A8C-0x00000001864A2AB8
	public static extern void CSharp_AkBehavioralPositioningData_center_set(IntPtr jarg1, float jarg2); // 0x000000018648CCF8-0x000000018648CD3C
	public static extern float CSharp_AkBehavioralPositioningData_center_get(IntPtr jarg1); // 0x000000018648CCC4-0x000000018648CCF8
	public static extern void CSharp_AkBehavioralPositioningData_panLR_set(IntPtr jarg1, float jarg2); // 0x000000018648CECC-0x000000018648CF10
	public static extern float CSharp_AkBehavioralPositioningData_panLR_get(IntPtr jarg1); // 0x000000018648CE98-0x000000018648CECC
	public static extern void CSharp_AkBehavioralPositioningData_panBF_set(IntPtr jarg1, float jarg2); // 0x000000018648CDE4-0x000000018648CE20
	public static extern float CSharp_AkBehavioralPositioningData_panBF_get(IntPtr jarg1); // 0x000000018648CDB8-0x000000018648CDE4
	public static extern void CSharp_AkBehavioralPositioningData_panDU_set(IntPtr jarg1, float jarg2); // 0x000000018648CE54-0x000000018648CE98
	public static extern float CSharp_AkBehavioralPositioningData_panDU_get(IntPtr jarg1); // 0x000000018648CE20-0x000000018648CE54
	public static extern void CSharp_AkBehavioralPositioningData_panSpatMix_set(IntPtr jarg1, float jarg2); // 0x000000018648CF44-0x000000018648CF88
	public static extern float CSharp_AkBehavioralPositioningData_panSpatMix_get(IntPtr jarg1); // 0x000000018648CF10-0x000000018648CF44
	public static extern void CSharp_AkBehavioralPositioningData_spatMode_set(IntPtr jarg1, int jarg2); // 0x000000018648D030-0x000000018648D070
	public static extern int CSharp_AkBehavioralPositioningData_spatMode_get(IntPtr jarg1); // 0x000000018648CFFC-0x000000018648D030
	public static extern void CSharp_AkBehavioralPositioningData_panType_set(IntPtr jarg1, int jarg2); // 0x000000018648CFBC-0x000000018648CFFC
	public static extern int CSharp_AkBehavioralPositioningData_panType_get(IntPtr jarg1); // 0x000000018648CF88-0x000000018648CFBC
	public static extern void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(IntPtr jarg1, bool jarg2); // 0x000000018648CD74-0x000000018648CDB8
	public static extern bool CSharp_AkBehavioralPositioningData_enableHeightSpread_get(IntPtr jarg1); // 0x000000018648CD3C-0x000000018648CD74
	public static extern void CSharp_delete_AkBehavioralPositioningData(IntPtr jarg1); // 0x00000001864A1B2C-0x00000001864A1B60
	public static extern void CSharp_AkPositioningData_threeD_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001864944B0-0x00000001864944F4
	public static extern IntPtr CSharp_AkPositioningData_threeD_get(IntPtr jarg1); // 0x000000018649447C-0x00000001864944B0
	public static extern void CSharp_AkPositioningData_behavioral_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001864943F8-0x000000018649447C
	public static extern IntPtr CSharp_AkPositioningData_behavioral_get(IntPtr jarg1); // 0x00000001864943C4-0x00000001864943F8
	public static extern IntPtr CSharp_new_AkPositioningData(); // 0x00000001864A3754-0x00000001864A3780
	public static extern void CSharp_delete_AkPositioningData(IntPtr jarg1); // 0x00000001864A23E8-0x00000001864A241C
	public static extern void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648BE8C-0x000000018648BED0
	public static extern IntPtr CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(IntPtr jarg1); // 0x000000018648BE50-0x000000018648BE8C
	public static extern void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x000000018648BF78-0x000000018648BFB8
	public static extern uint CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(IntPtr jarg1); // 0x000000018648BF44-0x000000018648BF78
	public static extern void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x000000018648BF04-0x000000018648BF44
	public static extern uint CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(IntPtr jarg1); // 0x000000018648BED0-0x000000018648BF04
	public static extern void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(IntPtr jarg1, bool jarg2); // 0x000000018648BE0C-0x000000018648BE50
	public static extern bool CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(IntPtr jarg1); // 0x000000018648BDD4-0x000000018648BE0C
	public static extern void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(IntPtr jarg1, bool jarg2); // 0x000000018648BD90-0x000000018648BDD4
	public static extern bool CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(IntPtr jarg1); // 0x000000018648BD58-0x000000018648BD90
	public static extern IntPtr CSharp_new_Ak3DAudioSinkCapabilities(); // 0x00000001864A292C-0x00000001864A2958
	public static extern void CSharp_delete_Ak3DAudioSinkCapabilities(IntPtr jarg1); // 0x00000001864A18D0-0x00000001864A1904
	public static extern void CSharp_AkIterator_pItem_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000186490080-0x00000001864900C4
	public static extern IntPtr CSharp_AkIterator_pItem_get(IntPtr jarg1); // 0x000000018649004C-0x0000000186490080
	public static extern IntPtr CSharp_AkIterator_NextIter(IntPtr jarg1); // 0x000000018648FFE4-0x0000000186490018
	public static extern IntPtr CSharp_AkIterator_PrevIter(IntPtr jarg1); // 0x0000000186490018-0x000000018649004C
	public static extern IntPtr CSharp_AkIterator_GetItem(IntPtr jarg1); // 0x000000018648FEE0-0x000000018648FF14
	public static extern bool CSharp_AkIterator_IsEqualTo(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FF5C-0x000000018648FFE4
	public static extern bool CSharp_AkIterator_IsDifferentFrom(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FF14-0x000000018648FF5C
	public static extern IntPtr CSharp_new_AkIterator(); // 0x00000001864A3084-0x00000001864A30B0
	public static extern void CSharp_delete_AkIterator(IntPtr jarg1); // 0x00000001864A1EA0-0x00000001864A1ED4
	public static extern bool CSharp_AkStdMovePolicy_IsTrivial(); // 0x00000001864960B4-0x00000001864960E4
	public static extern IntPtr CSharp_new_AkStdMovePolicy(); // 0x00000001864A393C-0x00000001864A3968
	public static extern void CSharp_delete_AkStdMovePolicy(IntPtr jarg1); // 0x00000001864A25BC-0x00000001864A25F0
	public static extern bool CSharp_AkTrivialStdMovePolicy_IsTrivial(); // 0x0000000186496858-0x0000000186496888
	public static extern IntPtr CSharp_new_AkTrivialStdMovePolicy(); // 0x00000001864A3A64-0x00000001864A3A90
	public static extern void CSharp_delete_AkTrivialStdMovePolicy(IntPtr jarg1); // 0x00000001864A26C0-0x00000001864A26F4
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_0(); // 0x00000001864A36C8-0x00000001864A36F4
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_1(IntPtr jarg1); // 0x00000001864A36F4-0x00000001864A3728
	public static extern void CSharp_delete_AkPlaylistItem(IntPtr jarg1); // 0x00000001864A2380-0x00000001864A23B4
	public static extern IntPtr CSharp_AkPlaylistItem_Assign(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493E24-0x0000000186493E68
	public static extern bool CSharp_AkPlaylistItem_IsEqualTo(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493E68-0x0000000186493EF0
	public static extern int CSharp_AkPlaylistItem_SetExternalSources(IntPtr jarg1, uint jarg2, IntPtr jarg3); // 0x0000000186493EF0-0x0000000186493F80
	public static extern void CSharp_AkPlaylistItem_audioNodeID_set(IntPtr jarg1, uint jarg2); // 0x0000000186493FB4-0x0000000186493FF4
	public static extern uint CSharp_AkPlaylistItem_audioNodeID_get(IntPtr jarg1); // 0x0000000186493F80-0x0000000186493FB4
	public static extern void CSharp_AkPlaylistItem_msDelay_set(IntPtr jarg1, int jarg2); // 0x0000000186494028-0x0000000186494068
	public static extern int CSharp_AkPlaylistItem_msDelay_get(IntPtr jarg1); // 0x0000000186493FF4-0x0000000186494028
	public static extern void CSharp_AkPlaylistItem_pCustomInfo_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018649409C-0x00000001864940E0
	public static extern IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(IntPtr jarg1); // 0x0000000186494068-0x000000018649409C
	public static extern IntPtr CSharp_new_AkPlaylistArray(); // 0x00000001864A369C-0x00000001864A36C8
	public static extern void CSharp_delete_AkPlaylistArray(IntPtr jarg1); // 0x00000001864A234C-0x00000001864A2380
	public static extern IntPtr CSharp_AkPlaylistArray_Begin(IntPtr jarg1); // 0x00000001864934F4-0x0000000186493530
	public static extern IntPtr CSharp_AkPlaylistArray_End(IntPtr jarg1); // 0x00000001864935E8-0x000000018649361C
	public static extern IntPtr CSharp_AkPlaylistArray_FindEx(IntPtr jarg1, IntPtr jarg2); // 0x00000001864937A8-0x000000018649382C
	public static extern IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x00000001864936E0-0x0000000186493724
	public static extern void CSharp_AkPlaylistArray_Erase__SWIG_1(IntPtr jarg1, uint jarg2); // 0x0000000186493724-0x0000000186493764
	public static extern IntPtr CSharp_AkPlaylistArray_EraseSwap__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x000000018649361C-0x00000001864936A0
	public static extern void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(IntPtr jarg1, uint jarg2); // 0x00000001864936A0-0x00000001864936E0
	public static extern bool CSharp_AkPlaylistArray_IsGrowingAllowed(IntPtr jarg1); // 0x00000001864939E4-0x0000000186493A5C
	public static extern int CSharp_AkPlaylistArray_Reserve(IntPtr jarg1, uint jarg2); // 0x0000000186493CB4-0x0000000186493CF4
	public static extern int CSharp_AkPlaylistArray_ReserveExtra(IntPtr jarg1, uint jarg2); // 0x0000000186493C74-0x0000000186493CB4
	public static extern uint CSharp_AkPlaylistArray_Reserved(IntPtr jarg1); // 0x0000000186493CF4-0x0000000186493D28
	public static extern void CSharp_AkPlaylistArray_Term(IntPtr jarg1); // 0x0000000186493DAC-0x0000000186493DE0
	public static extern uint CSharp_AkPlaylistArray_Length(IntPtr jarg1); // 0x0000000186493B10-0x0000000186493B44
	public static extern IntPtr CSharp_AkPlaylistArray_Data(IntPtr jarg1); // 0x00000001864935B4-0x00000001864935E8
	public static extern bool CSharp_AkPlaylistArray_IsEmpty(IntPtr jarg1); // 0x00000001864939AC-0x00000001864939E4
	public static extern IntPtr CSharp_AkPlaylistArray_Exists(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493764-0x00000001864937A8
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(IntPtr jarg1); // 0x00000001864933F8-0x0000000186493470
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493470-0x00000001864934F4
	public static extern IntPtr CSharp_AkPlaylistArray_Last(IntPtr jarg1); // 0x0000000186493ADC-0x0000000186493B10
	public static extern void CSharp_AkPlaylistArray_RemoveLast(IntPtr jarg1); // 0x0000000186493B78-0x0000000186493BAC
	public static extern int CSharp_AkPlaylistArray_Remove(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493BF0-0x0000000186493C74
	public static extern int CSharp_AkPlaylistArray_RemoveSwap(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493BAC-0x0000000186493BF0
	public static extern void CSharp_AkPlaylistArray_RemoveAll(IntPtr jarg1); // 0x0000000186493B44-0x0000000186493B78
	public static extern IntPtr CSharp_AkPlaylistArray_ItemAtIndex(IntPtr jarg1, uint jarg2); // 0x0000000186493A5C-0x0000000186493ADC
	public static extern IntPtr CSharp_AkPlaylistArray_Insert__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x00000001864938E8-0x000000018649392C
	public static extern IntPtr CSharp_AkPlaylistArray_Insert__SWIG_1(IntPtr jarg1, uint jarg2); // 0x000000018649392C-0x00000001864939AC
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_0(IntPtr jarg1); // 0x000000018649382C-0x0000000186493864
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_1(IntPtr jarg1, uint jarg2); // 0x0000000186493864-0x00000001864938E8
	public static extern bool CSharp_AkPlaylistArray_Resize(IntPtr jarg1, uint jarg2); // 0x0000000186493D28-0x0000000186493DAC
	public static extern void CSharp_AkPlaylistArray_Transfer(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493DE0-0x0000000186493E24
	public static extern int CSharp_AkPlaylistArray_Copy(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493530-0x00000001864935B4
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_0(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6); // 0x00000001864940E0-0x0000000186494180
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_1(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5); // 0x0000000186494180-0x0000000186494220
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_2(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4); // 0x0000000186494220-0x00000001864942C0
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_3(IntPtr jarg1, uint jarg2, int jarg3); // 0x00000001864942C0-0x0000000186494350
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_4(IntPtr jarg1, uint jarg2); // 0x0000000186494350-0x0000000186494390
	public static extern IntPtr CSharp_new_AkPlaylist(); // 0x00000001864A3728-0x00000001864A3754
	public static extern void CSharp_delete_AkPlaylist(IntPtr jarg1); // 0x00000001864A23B4-0x00000001864A23E8
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_0(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x00000001864975EC-0x000000018649768C
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_1(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4); // 0x000000018649768C-0x000000018649772C
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_2(ulong jarg1); // 0x000000018649772C-0x00000001864977A4
	public static extern int CSharp_DynamicSequenceClose(uint jarg1); // 0x00000001864974B0-0x00000001864974E4
	public static extern int CSharp_DynamicSequencePlay__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001864978E4-0x0000000186497970
	public static extern int CSharp_DynamicSequencePlay__SWIG_1(uint jarg1, int jarg2); // 0x0000000186497970-0x00000001864979F0
	public static extern int CSharp_DynamicSequencePlay__SWIG_2(uint jarg1); // 0x00000001864979F0-0x0000000186497A24
	public static extern int CSharp_DynamicSequencePause__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001864977A4-0x0000000186497830
	public static extern int CSharp_DynamicSequencePause__SWIG_1(uint jarg1, int jarg2); // 0x0000000186497830-0x00000001864978B0
	public static extern int CSharp_DynamicSequencePause__SWIG_2(uint jarg1); // 0x00000001864978B0-0x00000001864978E4
	public static extern int CSharp_DynamicSequenceResume__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x0000000186497A24-0x0000000186497AB0
	public static extern int CSharp_DynamicSequenceResume__SWIG_1(uint jarg1, int jarg2); // 0x0000000186497AB0-0x0000000186497AF0
	public static extern int CSharp_DynamicSequenceResume__SWIG_2(uint jarg1); // 0x0000000186497AF0-0x0000000186497B24
	public static extern int CSharp_DynamicSequenceStop__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x0000000186497B24-0x0000000186497B74
	public static extern int CSharp_DynamicSequenceStop__SWIG_1(uint jarg1, int jarg2); // 0x0000000186497B74-0x0000000186497BB4
	public static extern int CSharp_DynamicSequenceStop__SWIG_2(uint jarg1); // 0x0000000186497BB4-0x0000000186497C2C
	public static extern int CSharp_DynamicSequenceBreak(uint jarg1); // 0x0000000186497438-0x00000001864974B0
	public static extern int CSharp_Seek__SWIG_0(uint jarg1, int jarg2, bool jarg3); // 0x000000018649E800-0x000000018649E850
	public static extern int CSharp_Seek__SWIG_1(uint jarg1, float jarg2, bool jarg3); // 0x000000018649E850-0x000000018649E89C
	public static extern int CSharp_DynamicSequenceGetPauseTimes(uint jarg1, out uint jarg2, out uint jarg3); // 0x00000001864974E4-0x0000000186497574
	public static extern IntPtr CSharp_DynamicSequenceLockPlaylist(uint jarg1); // 0x0000000186497574-0x00000001864975EC
	public static extern int CSharp_DynamicSequenceUnlockPlaylist(uint jarg1); // 0x0000000186497C2C-0x0000000186497C60
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_0(); // 0x00000001864A33D0-0x00000001864A33FC
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_1(string jarg1, uint jarg2, IntPtr jarg3, int jarg4); // 0x00000001864A33FC-0x00000001864A34B8
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_2(string jarg1, uint jarg2, IntPtr jarg3); // 0x00000001864A34B8-0x00000001864A3564
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_3(string jarg1, uint jarg2); // 0x00000001864A3564-0x00000001864A3604
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_4(string jarg1); // 0x00000001864A3604-0x00000001864A369C
	public static extern void CSharp_AkOutputSettings_audioDeviceShareset_set(IntPtr jarg1, uint jarg2); // 0x00000001856B5F80-0x00000001856B5FC0
	public static extern uint CSharp_AkOutputSettings_audioDeviceShareset_get(IntPtr jarg1); // 0x0000000186492E5C-0x0000000186492ED4
	public static extern void CSharp_AkOutputSettings_idDevice_set(IntPtr jarg1, uint jarg2); // 0x00000001856B5EE0-0x00000001856B5F20
	public static extern uint CSharp_AkOutputSettings_idDevice_get(IntPtr jarg1); // 0x0000000186492F4C-0x0000000186492F80
	public static extern void CSharp_AkOutputSettings_ePanningRule_set(IntPtr jarg1, int jarg2); // 0x00000001856B5E40-0x00000001856B5E80
	public static extern int CSharp_AkOutputSettings_ePanningRule_get(IntPtr jarg1); // 0x0000000186492F18-0x0000000186492F4C
	public static extern void CSharp_AkOutputSettings_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000186492ED4-0x0000000186492F18
	public static extern IntPtr CSharp_AkOutputSettings_channelConfig_get(IntPtr jarg1); // 0x00000001856B5CC0-0x00000001856B5D00
	public static extern void CSharp_delete_AkOutputSettings(IntPtr jarg1); // 0x00000001864A22E4-0x00000001864A2318
	public static extern void CSharp_AkInitSettings_uMaxNumPaths_set(IntPtr jarg1, uint jarg2); // 0x00000001856B54D0-0x00000001856B5510
	public static extern uint CSharp_AkInitSettings_uMaxNumPaths_get(IntPtr jarg1); // 0x000000018648FBD0-0x000000018648FC04
	public static extern void CSharp_AkInitSettings_uCommandQueueSize_set(IntPtr jarg1, uint jarg2); // 0x00000001856B5430-0x00000001856B5470
	public static extern uint CSharp_AkInitSettings_uCommandQueueSize_get(IntPtr jarg1); // 0x000000018648FAC0-0x000000018648FAF4
	public static extern void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(IntPtr jarg1, bool jarg2); // 0x00000001854FEDF0-0x00000001854FEE40
	public static extern bool CSharp_AkInitSettings_bEnableGameSyncPreparation_get(IntPtr jarg1); // 0x000000018648F778-0x000000018648F7F0
	public static extern void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(IntPtr jarg1, uint jarg2); // 0x00000001854FED50-0x00000001854FED90
	public static extern uint CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(IntPtr jarg1); // 0x000000018648FAF4-0x000000018648FB28
	public static extern void CSharp_AkInitSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2); // 0x00000001856B5390-0x00000001856B53D0
	public static extern uint CSharp_AkInitSettings_uNumSamplesPerFrame_get(IntPtr jarg1); // 0x000000018648FC38-0x000000018648FC6C
	public static extern void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(IntPtr jarg1, uint jarg2); // 0x00000001854FECB0-0x00000001854FECF0
	public static extern uint CSharp_AkInitSettings_uMonitorQueuePoolSize_get(IntPtr jarg1); // 0x000000018648FC04-0x000000018648FC38
	public static extern void CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_set(IntPtr jarg1, uint jarg2); // 0x000000018648FB5C-0x000000018648FB9C
	public static extern uint CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_get(IntPtr jarg1); // 0x000000018648FB28-0x000000018648FB5C
	public static extern void CSharp_AkInitSettings_settingsMainOutput_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FA08-0x000000018648FA4C
	public static extern IntPtr CSharp_AkInitSettings_settingsMainOutput_get(IntPtr jarg1); // 0x00000001856B5290-0x00000001856B52D0
	public static extern void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(IntPtr jarg1, uint jarg2); // 0x00000001854FEC10-0x00000001854FEC50
	public static extern uint CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(IntPtr jarg1); // 0x000000018648FB9C-0x000000018648FBD0
	public static extern void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(IntPtr jarg1, bool jarg2); // 0x000000018648F8A4-0x000000018648F8E8
	public static extern bool CSharp_AkInitSettings_bUseSoundBankMgrThread_get(IntPtr jarg1); // 0x000000018648F86C-0x000000018648F8A4
	public static extern void CSharp_AkInitSettings_bUseLEngineThread_set(IntPtr jarg1, bool jarg2); // 0x000000018648F828-0x000000018648F86C
	public static extern bool CSharp_AkInitSettings_bUseLEngineThread_get(IntPtr jarg1); // 0x000000018648F7F0-0x000000018648F828
	public static extern void CSharp_AkInitSettings_szPluginDLLPath_set(IntPtr jarg1, string jarg2); // 0x00000001856B5FC0-0x00000001856B6060
	public static extern IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(IntPtr jarg1); // 0x00000001856B5120-0x00000001856B5160
	public static extern void CSharp_AkInitSettings_eFloorPlane_set(IntPtr jarg1, int jarg2); // 0x000000018648F91C-0x000000018648F95C
	public static extern int CSharp_AkInitSettings_eFloorPlane_get(IntPtr jarg1); // 0x000000018648F8E8-0x000000018648F91C
	public static extern void CSharp_AkInitSettings_fGameUnitsToMeters_set(IntPtr jarg1, float jarg2); // 0x000000018648F9C4-0x000000018648FA08
	public static extern float CSharp_AkInitSettings_fGameUnitsToMeters_get(IntPtr jarg1); // 0x000000018648F990-0x000000018648F9C4
	public static extern void CSharp_AkInitSettings_uBankReadBufferSize_set(IntPtr jarg1, uint jarg2); // 0x000000018648FA80-0x000000018648FAC0
	public static extern uint CSharp_AkInitSettings_uBankReadBufferSize_get(IntPtr jarg1); // 0x000000018648FA4C-0x000000018648FA80
	public static extern void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(IntPtr jarg1, float jarg2); // 0x00000001854FEB60-0x00000001854FEBB0
	public static extern float CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(IntPtr jarg1); // 0x000000018648F95C-0x000000018648F990
	public static extern void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(IntPtr jarg1, bool jarg2); // 0x00000001854FEAB0-0x00000001854FEB00
	public static extern bool CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(IntPtr jarg1); // 0x000000018648F740-0x000000018648F778
	public static extern void CSharp_delete_AkInitSettings(IntPtr jarg1); // 0x00000001864A1E6C-0x00000001864A1EA0
	public static extern void CSharp_AkSourceSettings_sourceID_set(IntPtr jarg1, uint jarg2); // 0x0000000186495E58-0x0000000186495E98
	public static extern uint CSharp_AkSourceSettings_sourceID_get(IntPtr jarg1); // 0x0000000186495E24-0x0000000186495E58
	public static extern void CSharp_AkSourceSettings_pMediaMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000186495DE0-0x0000000186495E24
	public static extern IntPtr CSharp_AkSourceSettings_pMediaMemory_get(IntPtr jarg1); // 0x0000000186495DAC-0x0000000186495DE0
	public static extern void CSharp_AkSourceSettings_uMediaSize_set(IntPtr jarg1, uint jarg2); // 0x0000000186495ECC-0x0000000186495F0C
	public static extern uint CSharp_AkSourceSettings_uMediaSize_get(IntPtr jarg1); // 0x0000000186495E98-0x0000000186495ECC
	public static extern void CSharp_AkSourceSettings_Clear(IntPtr jarg1); // 0x0000000186495D00-0x0000000186495D34
	public static extern int CSharp_AkSourceSettings_GetSizeOf(); // 0x0000000186495D78-0x0000000186495DAC
	public static extern void CSharp_AkSourceSettings_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000186495D34-0x0000000186495D78
	public static extern IntPtr CSharp_new_AkSourceSettings(); // 0x00000001864A3910-0x00000001864A393C
	public static extern void CSharp_delete_AkSourceSettings(IntPtr jarg1); // 0x00000001864A2588-0x00000001864A25BC
	public static extern bool CSharp_IsInitialized(); // 0x0000000184A84D40-0x0000000184A84DB0
	public static extern int CSharp_GetAudioSettings(IntPtr jarg1); // 0x0000000186498378-0x00000001864983AC
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(ulong jarg1); // 0x0000000186499D28-0x0000000186499DA0
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_1(); // 0x0000000184A84B10-0x0000000184A84B40
	public static extern int CSharp_GetOutputDeviceConfiguration(ulong jarg1, IntPtr jarg2, IntPtr jarg3); // 0x0000000186498EE8-0x0000000186498F78
	public static extern int CSharp_GetPanningRule__SWIG_0(out int jarg1, ulong jarg2); // 0x0000000186499098-0x000000018649911C
	public static extern int CSharp_GetPanningRule__SWIG_1(out int jarg1); // 0x000000018649911C-0x0000000186499194
	public static extern int CSharp_SetPanningRule__SWIG_0(int jarg1, ulong jarg2); // 0x000000018649FE74-0x000000018649FEF4
	public static extern int CSharp_SetPanningRule__SWIG_1(int jarg1); // 0x000000018649FEF4-0x000000018649FF6C
	public static extern int CSharp_GetSpeakerAngles__SWIG_0([In, Out] float[] jarg1, ref uint jarg2, out float jarg3, ulong jarg4); // 0x0000000186499BE4-0x0000000186499C8C
	public static extern int CSharp_GetSpeakerAngles__SWIG_1([In, Out] float[] jarg1, ref uint jarg2, out float jarg3); // 0x0000000186499C8C-0x0000000186499D28
	public static extern int CSharp_SetSpeakerAngles__SWIG_0(in float[] jarg1, uint jarg2, float jarg3, ulong jarg4); // 0x00000001864A0734-0x00000001864A0798
	public static extern int CSharp_SetSpeakerAngles__SWIG_1(in float[] jarg1, uint jarg2, float jarg3); // 0x00000001864A0798-0x00000001864A07EC
	public static extern int CSharp_SetVolumeThreshold(float jarg1); // 0x00000001864A09B4-0x00000001864A09E8
	public static extern int CSharp_SetMaxNumVoicesLimit(ushort jarg1); // 0x000000018649F6E8-0x000000018649F760
	public static extern int CSharp_SetJobMgrMaxActiveWorkers(uint jarg1, uint jarg2); // 0x000000018649F460-0x000000018649F4E0
	public static extern int CSharp_RenderAudio__SWIG_0(bool jarg1); // 0x000000018649D440-0x000000018649D4B8
	public static extern int CSharp_RenderAudio__SWIG_1(); // 0x0000000184597E90-0x0000000184597EC0
	public static extern int CSharp_RegisterPluginDLL__SWIG_0(string jarg1, string jarg2); // 0x000000018649D050-0x000000018649D0E8
	public static extern int CSharp_RegisterPluginDLL__SWIG_1(string jarg1); // 0x000000018649D0E8-0x000000018649D128
	public static extern bool CSharp_IsPluginRegistered(int jarg1, uint jarg2, uint jarg3); // 0x000000018649A3D8-0x000000018649A46C
	public static extern uint CSharp_GetIDFromString__SWIG_0(string jarg1); // 0x0000000184CD80A0-0x0000000184CD80E0
	public static extern uint CSharp_PostEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8); // 0x000000018649B750-0x000000018649B7F0
	public static extern uint CSharp_PostEvent__SWIG_1(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7); // 0x0000000184BDEF90-0x0000000184BDEFF0
	public static extern uint CSharp_PostEvent__SWIG_2(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x000000018459A5E0-0x000000018459A640
	public static extern uint CSharp_PostEvent__SWIG_3(uint jarg1, ulong jarg2); // 0x000000018649B7F0-0x000000018649B870
	public static extern uint CSharp_PostEvent__SWIG_4(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8); // 0x000000018649B870-0x000000018649B920
	public static extern uint CSharp_PostEvent__SWIG_5(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7); // 0x000000018649B920-0x000000018649B9CC
	public static extern uint CSharp_PostEvent__SWIG_6(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x000000018649B9CC-0x000000018649BA78
	public static extern uint CSharp_PostEvent__SWIG_7(string jarg1, ulong jarg2); // 0x000000018649BA78-0x000000018649BB04
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_0(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6); // 0x0000000186497C60-0x0000000186497CFC
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_1(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5); // 0x0000000186497CFC-0x0000000186497D98
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_2(uint jarg1, int jarg2, ulong jarg3, int jarg4); // 0x0000000186497D98-0x0000000186497E34
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_3(uint jarg1, int jarg2, ulong jarg3); // 0x0000000186497E34-0x0000000186497EC0
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_4(uint jarg1, int jarg2); // 0x0000000186497EC0-0x0000000186497F40
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_5(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6); // 0x0000000186497F40-0x0000000186497FE8
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_6(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5); // 0x0000000186497FE8-0x0000000186498090
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_7(string jarg1, int jarg2, ulong jarg3, int jarg4); // 0x0000000186498090-0x0000000186498138
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_8(string jarg1, int jarg2, ulong jarg3); // 0x0000000186498138-0x00000001864981D0
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_9(string jarg1, int jarg2); // 0x00000001864981D0-0x000000018649825C
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8, uint jarg9); // 0x000000018649BB04-0x000000018649BBBC
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8); // 0x000000018649BBBC-0x000000018649BC6C
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_2(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5); // 0x000000018649BC6C-0x000000018649BD1C
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_3(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4); // 0x000000018649BD1C-0x000000018649BDBC
	public static extern int CSharp_StopMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3); // 0x00000001864A0C60-0x00000001864A0CF0
	public static extern int CSharp_StopMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2); // 0x00000001864A0CF0-0x00000001864A0D30
	public static extern int CSharp_StopMIDIOnEvent__SWIG_2(uint jarg1); // 0x00000001864A0D30-0x00000001864A0D64
	public static extern int CSharp_StopMIDIOnEvent__SWIG_3(); // 0x00000001864A0D64-0x00000001864A0DCC
	public static extern int CSharp_PinEventInStreamCache__SWIG_0(uint jarg1, sbyte jarg2, sbyte jarg3); // 0x000000018649B2A8-0x000000018649B338
	public static extern int CSharp_PinEventInStreamCache__SWIG_1(string jarg1, sbyte jarg2, sbyte jarg3); // 0x000000018649B338-0x000000018649B3D4
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_0(uint jarg1); // 0x00000001864A15F0-0x00000001864A1668
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_1(string jarg1); // 0x00000001864A1668-0x00000001864A16E4
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_0(uint jarg1, out float jarg2, out int jarg3); // 0x0000000186498418-0x00000001864984A8
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_1(string jarg1, out float jarg2, out int jarg3); // 0x00000001864984A8-0x0000000186498550
	public static extern int CSharp_SeekOnEvent__SWIG_0(uint jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5); // 0x000000018649E210-0x000000018649E2B0
	public static extern int CSharp_SeekOnEvent__SWIG_1(uint jarg1, ulong jarg2, int jarg3, bool jarg4); // 0x000000018649E480-0x000000018649E520
	public static extern int CSharp_SeekOnEvent__SWIG_2(uint jarg1, ulong jarg2, int jarg3); // 0x000000018649E520-0x000000018649E5B0
	public static extern int CSharp_SeekOnEvent__SWIG_3(string jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5); // 0x000000018649E5B0-0x000000018649E65C
	public static extern int CSharp_SeekOnEvent__SWIG_4(string jarg1, ulong jarg2, int jarg3, bool jarg4); // 0x000000018649E65C-0x000000018649E708
	public static extern int CSharp_SeekOnEvent__SWIG_5(string jarg1, ulong jarg2, int jarg3); // 0x000000018649E708-0x000000018649E7A4
	public static extern int CSharp_SeekOnEvent__SWIG_9(uint jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5); // 0x000000018649E7A4-0x000000018649E800
	public static extern int CSharp_SeekOnEvent__SWIG_10(uint jarg1, ulong jarg2, float jarg3, bool jarg4); // 0x000000018649E2B0-0x000000018649E30C
	public static extern int CSharp_SeekOnEvent__SWIG_11(uint jarg1, ulong jarg2, float jarg3); // 0x000000018649E30C-0x000000018649E358
	public static extern int CSharp_SeekOnEvent__SWIG_12(string jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5); // 0x000000018649E358-0x000000018649E3C0
	public static extern int CSharp_SeekOnEvent__SWIG_13(string jarg1, ulong jarg2, float jarg3, bool jarg4); // 0x000000018649E3C0-0x000000018649E428
	public static extern int CSharp_SeekOnEvent__SWIG_14(string jarg1, ulong jarg2, float jarg3); // 0x000000018649E428-0x000000018649E480
	public static extern void CSharp_CancelEventCallbackCookie(IntPtr jarg1); // 0x0000000186496E50-0x0000000186496E84
	public static extern void CSharp_CancelEventCallbackGameObject(ulong jarg1); // 0x0000000186496E84-0x0000000186496EB8
	public static extern void CSharp_CancelEventCallback(uint jarg1); // 0x0000000186496EB8-0x0000000186496EEC
	public static extern int CSharp_GetSourcePlayPosition__SWIG_0(uint jarg1, out int jarg2, bool jarg3); // 0x0000000186499A44-0x0000000186499AD4
	public static extern int CSharp_GetSourcePlayPosition__SWIG_1(uint jarg1, out int jarg2); // 0x0000000186499AD4-0x0000000186499B54
	public static extern int CSharp_GetSourceStreamBuffering(uint jarg1, out int jarg2, out int jarg3); // 0x0000000186499B54-0x0000000186499BE4
	public static extern void CSharp_StopAll__SWIG_0(ulong jarg1); // 0x0000000184C9ED90-0x0000000184C9EE30
	public static extern void CSharp_StopAll__SWIG_1(); // 0x00000001864A0C00-0x00000001864A0C2C
	public static extern void CSharp_StopPlayingID__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001864A0DF8-0x00000001864A0E84
	public static extern void CSharp_StopPlayingID__SWIG_1(uint jarg1, int jarg2); // 0x00000001864A0E84-0x00000001864A0F04
	public static extern void CSharp_StopPlayingID__SWIG_2(uint jarg1); // 0x00000001864A0F04-0x00000001864A0F7C
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_0(int jarg1, uint jarg2, int jarg3, int jarg4); // 0x000000018649825C-0x00000001864982F8
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_1(int jarg1, uint jarg2, int jarg3); // 0x0000000184733B00-0x0000000184733B50
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_2(int jarg1, uint jarg2); // 0x00000001864982F8-0x0000000186498378
	public static extern void CSharp_SetRandomSeed(uint jarg1); // 0x00000001864A05D0-0x00000001864A0648
	public static extern void CSharp_MuteBackgroundMusic(bool jarg1); // 0x000000018649B204-0x000000018649B27C
	public static extern bool CSharp_GetBackgroundMusicMute(); // 0x00000001864983AC-0x0000000186498418
	public static extern int CSharp_SendPluginCustomGameData(uint jarg1, ulong jarg2, int jarg3, uint jarg4, uint jarg5, IntPtr jarg6, uint jarg7); // 0x000000018649E89C-0x000000018649E93C
	public static extern int CSharp_UnregisterAllGameObj(); // 0x00000001864A16E4-0x00000001864A1710
	public static extern int CSharp_SetMultiplePositions__SWIG_0(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4, int jarg5); // 0x000000018649F98C-0x000000018649FA30
	public static extern int CSharp_SetMultiplePositions__SWIG_1(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4); // 0x00000001851E7710-0x00000001851E7770
	public static extern int CSharp_SetMultiplePositions__SWIG_2(ulong jarg1, IntPtr jarg2, ushort jarg3); // 0x000000018649FA30-0x000000018649FAC4
	public static extern int CSharp_SetMultiplePositions__SWIG_3(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4, int jarg5); // 0x000000018649FAC4-0x000000018649FB68
	public static extern int CSharp_SetMultiplePositions__SWIG_4(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4); // 0x000000018649FB68-0x000000018649FC0C
	public static extern int CSharp_SetMultiplePositions__SWIG_5(ulong jarg1, IntPtr jarg2, ushort jarg3); // 0x000000018649FC0C-0x000000018649FCA0
	public static extern int CSharp_SetScalingFactor(ulong jarg1, float jarg2); // 0x0000000184A7C980-0x0000000184A7C9C0
	public static extern int CSharp_SetDistanceProbe(ulong jarg1, ulong jarg2); // 0x000000018649EE48-0x000000018649EECC
	public static extern int CSharp_ClearBanks(); // 0x0000000186497018-0x0000000186497044
	public static extern int CSharp_SetBankLoadIOSettings(float jarg1, sbyte jarg2); // 0x000000018649EA60-0x000000018649EA9C
	public static extern int CSharp_LoadBank__SWIG_0(string jarg1, out uint jarg2, uint jarg3); // 0x000000018649A9C4-0x000000018649AA60
	public static extern int CSharp_LoadBank__SWIG_1(string jarg1, out uint jarg2); // 0x000000018649AA60-0x000000018649AAEC
	public static extern int CSharp_LoadBank__SWIG_4(uint jarg1, uint jarg2); // 0x000000018649AAEC-0x000000018649AB6C
	public static extern int CSharp_LoadBank__SWIG_5(uint jarg1); // 0x0000000184957F10-0x0000000184957F90
	public static extern int CSharp_LoadBankMemoryView__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3); // 0x000000018649A754-0x000000018649A7E4
	public static extern int CSharp_LoadBankMemoryView__SWIG_1(IntPtr jarg1, uint jarg2, out uint jarg3, out uint jarg4); // 0x000000018649A7E4-0x000000018649A884
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3); // 0x000000018649A4E4-0x000000018649A574
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_1(IntPtr jarg1, uint jarg2, out uint jarg3, out uint jarg4); // 0x000000018649A574-0x000000018649A614
	public static extern int CSharp_LoadBank__SWIG_6(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4, uint jarg5); // 0x000000018649AB6C-0x000000018649AC18
	public static extern int CSharp_LoadBank__SWIG_7(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4); // 0x000000018649AC18-0x000000018649ACC4
	public static extern int CSharp_LoadBank__SWIG_10(uint jarg1, IntPtr jarg2, IntPtr jarg3, uint jarg4); // 0x0000000184CD8A80-0x0000000184CD8AE0
	public static extern int CSharp_LoadBank__SWIG_11(uint jarg1, IntPtr jarg2, IntPtr jarg3); // 0x0000000184CD9F40-0x0000000184CD9F90
	public static extern int CSharp_LoadBankMemoryView__SWIG_2(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5); // 0x000000018649A884-0x000000018649A924
	public static extern int CSharp_LoadBankMemoryView__SWIG_3(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5, out uint jarg6); // 0x000000018649A924-0x000000018649A9C4
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_2(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5); // 0x000000018649A614-0x000000018649A6B4
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_3(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5, out uint jarg6); // 0x000000018649A6B4-0x000000018649A754
	public static extern int CSharp_UnloadBank__SWIG_0(string jarg1, IntPtr jarg2, uint jarg3); // 0x00000001864A11C0-0x00000001864A125C
	public static extern int CSharp_UnloadBank__SWIG_1(string jarg1, IntPtr jarg2); // 0x00000001864A12FC-0x00000001864A1388
	public static extern int CSharp_UnloadBank__SWIG_4(uint jarg1, IntPtr jarg2, uint jarg3); // 0x00000001864A1388-0x00000001864A1418
	public static extern int CSharp_UnloadBank__SWIG_5(uint jarg1, IntPtr jarg2); // 0x00000001864A1418-0x00000001864A1498
	public static extern int CSharp_UnloadBank__SWIG_6(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5); // 0x00000001864A1498-0x00000001864A1544
	public static extern int CSharp_UnloadBank__SWIG_7(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001864A1544-0x00000001864A15F0
	public static extern int CSharp_UnloadBank__SWIG_10(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5); // 0x0000000184CD9CF0-0x0000000184CD9D50
	public static extern int CSharp_UnloadBank__SWIG_11(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001864A125C-0x00000001864A12FC
	public static extern void CSharp_CancelBankCallbackCookie(IntPtr jarg1); // 0x0000000186496E1C-0x0000000186496E50
	public static extern int CSharp_PrepareBank__SWIG_0(int jarg1, string jarg2, int jarg3, uint jarg4); // 0x000000018649C1B8-0x000000018649C260
	public static extern int CSharp_PrepareBank__SWIG_1(int jarg1, string jarg2, int jarg3); // 0x000000018649C584-0x000000018649C61C
	public static extern int CSharp_PrepareBank__SWIG_2(int jarg1, string jarg2); // 0x000000018649C61C-0x000000018649C6A8
	public static extern int CSharp_PrepareBank__SWIG_6(int jarg1, uint jarg2, int jarg3, uint jarg4); // 0x000000018649C6A8-0x000000018649C744
	public static extern int CSharp_PrepareBank__SWIG_7(int jarg1, uint jarg2, int jarg3); // 0x000000018649C744-0x000000018649C7D0
	public static extern int CSharp_PrepareBank__SWIG_8(int jarg1, uint jarg2); // 0x000000018649C7D0-0x000000018649C850
	public static extern int CSharp_PrepareBank__SWIG_9(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, uint jarg6); // 0x000000018649C850-0x000000018649C8F8
	public static extern int CSharp_PrepareBank__SWIG_10(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x000000018649C260-0x000000018649C308
	public static extern int CSharp_PrepareBank__SWIG_11(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4); // 0x000000018649C308-0x000000018649C3B0
	public static extern int CSharp_PrepareBank__SWIG_15(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, uint jarg6); // 0x000000018649C3B0-0x000000018649C44C
	public static extern int CSharp_PrepareBank__SWIG_16(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x000000018649C44C-0x000000018649C4E8
	public static extern int CSharp_PrepareBank__SWIG_17(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4); // 0x000000018649C4E8-0x000000018649C584
	public static extern int CSharp_ClearPreparedEvents(); // 0x0000000186497194-0x00000001864971FC
	public static extern int CSharp_PrepareEvent__SWIG_0(int jarg1, IntPtr jarg2, uint jarg3); // 0x000000018649C8F8-0x000000018649C988
	public static extern int CSharp_PrepareEvent__SWIG_1(int jarg1, in uint[] jarg2, uint jarg3); // 0x000000018649C988-0x000000018649CA20
	public static extern int CSharp_PrepareEvent__SWIG_2(int jarg1, IntPtr jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x000000018649CA20-0x000000018649CAC0
	public static extern int CSharp_PrepareEvent__SWIG_3(int jarg1, in uint[] jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x0000000184CD8AE0-0x0000000184CD8B50
	public static extern int CSharp_SetMedia(IntPtr jarg1, uint jarg2); // 0x000000018649F760-0x000000018649F7E0
	public static extern int CSharp_UnsetMedia(IntPtr jarg1, uint jarg2); // 0x00000001864A1778-0x00000001864A17F8
	public static extern int CSharp_PrepareGameSyncs__SWIG_0(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5); // 0x000000018649CAC0-0x000000018649CB68
	public static extern int CSharp_PrepareGameSyncs__SWIG_1(int jarg1, int jarg2, uint jarg3, in uint[] jarg4, uint jarg5); // 0x000000018649CB68-0x000000018649CC10
	public static extern int CSharp_PrepareGameSyncs__SWIG_2(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7); // 0x000000018649CC10-0x000000018649CCB8
	public static extern int CSharp_PrepareGameSyncs__SWIG_3(int jarg1, int jarg2, uint jarg3, in uint[] jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7); // 0x000000018649CCB8-0x000000018649CD60
	public static extern int CSharp_AddListener(ulong jarg1, ulong jarg2); // 0x000000018648B9FC-0x000000018648BA80
	public static extern int CSharp_RemoveListener(ulong jarg1, ulong jarg2); // 0x000000018649D2DC-0x000000018649D360
	public static extern int CSharp_AddDefaultListener(ulong jarg1); // 0x000000018648B984-0x000000018648B9FC
	public static extern int CSharp_RemoveDefaultListener(ulong jarg1); // 0x000000018649D128-0x000000018649D15C
	public static extern int CSharp_ResetListenersToDefault(ulong jarg1); // 0x000000018649D5CC-0x000000018649D644
	public static extern int CSharp_SetListenerSpatialization__SWIG_0(ulong jarg1, bool jarg2, IntPtr jarg3, in float[] jarg4); // 0x000000018649F4E0-0x000000018649F588
	public static extern int CSharp_SetListenerSpatialization__SWIG_1(ulong jarg1, bool jarg2, IntPtr jarg3); // 0x000000018649F588-0x000000018649F618
	public static extern int CSharp_SetRTPCValue__SWIG_0(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001864A02A8-0x00000001864A030C
	public static extern int CSharp_SetRTPCValue__SWIG_1(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5); // 0x00000001864A030C-0x00000001864A0368
	public static extern int CSharp_SetRTPCValue__SWIG_2(uint jarg1, float jarg2, ulong jarg3, int jarg4); // 0x00000001848C0C20-0x00000001848C0C80
	public static extern int CSharp_SetRTPCValue__SWIG_3(uint jarg1, float jarg2, ulong jarg3); // 0x00000001864A0368-0x00000001864A03B4
	public static extern int CSharp_SetRTPCValue__SWIG_4(uint jarg1, float jarg2); // 0x00000001864A03B4-0x00000001864A03F0
	public static extern int CSharp_SetRTPCValue__SWIG_5(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001864A03F0-0x00000001864A0460
	public static extern int CSharp_SetRTPCValue__SWIG_6(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5); // 0x00000001864A0460-0x00000001864A04C8
	public static extern int CSharp_SetRTPCValue__SWIG_7(string jarg1, float jarg2, ulong jarg3, int jarg4); // 0x00000001864A04C8-0x00000001864A0530
	public static extern int CSharp_SetRTPCValue__SWIG_8(string jarg1, float jarg2, ulong jarg3); // 0x00000001864A0530-0x00000001864A0588
	public static extern int CSharp_SetRTPCValue__SWIG_9(string jarg1, float jarg2); // 0x00000001864A0588-0x00000001864A05D0
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_0(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001864A0004-0x00000001864A0068
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_1(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5); // 0x00000001864A0068-0x00000001864A00C4
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_2(uint jarg1, float jarg2, uint jarg3, int jarg4); // 0x0000000185905B10-0x0000000185905B70
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_3(uint jarg1, float jarg2, uint jarg3); // 0x00000001864A00C4-0x00000001864A0110
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_4(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001864A0110-0x00000001864A0180
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_5(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5); // 0x00000001864A0180-0x00000001864A01E8
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_6(string jarg1, float jarg2, uint jarg3, int jarg4); // 0x00000001864A01E8-0x00000001864A0250
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_7(string jarg1, float jarg2, uint jarg3); // 0x00000001864A0250-0x00000001864A02A8
	public static extern int CSharp_ResetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5); // 0x000000018649DB20-0x000000018649DBCC
	public static extern int CSharp_ResetRTPCValue__SWIG_1(uint jarg1, ulong jarg2, int jarg3, int jarg4); // 0x000000018649DBCC-0x000000018649DC6C
	public static extern int CSharp_ResetRTPCValue__SWIG_2(uint jarg1, ulong jarg2, int jarg3); // 0x000000018649DC6C-0x000000018649DCFC
	public static extern int CSharp_ResetRTPCValue__SWIG_3(uint jarg1, ulong jarg2); // 0x000000018649DCFC-0x000000018649DD3C
	public static extern int CSharp_ResetRTPCValue__SWIG_4(uint jarg1); // 0x000000018649DD3C-0x000000018649DD70
	public static extern int CSharp_ResetRTPCValue__SWIG_5(string jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5); // 0x000000018649DD70-0x000000018649DE2C
	public static extern int CSharp_ResetRTPCValue__SWIG_6(string jarg1, ulong jarg2, int jarg3, int jarg4); // 0x000000018649DE2C-0x000000018649DED8
	public static extern int CSharp_ResetRTPCValue__SWIG_7(string jarg1, ulong jarg2, int jarg3); // 0x000000018649DED8-0x000000018649DF70
	public static extern int CSharp_ResetRTPCValue__SWIG_8(string jarg1, ulong jarg2); // 0x000000018649DF70-0x000000018649DFFC
	public static extern int CSharp_ResetRTPCValue__SWIG_9(string jarg1); // 0x000000018649DFFC-0x000000018649E078
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_0(uint jarg1, uint jarg2, int jarg3, int jarg4, bool jarg5); // 0x000000018649D644-0x000000018649D6F0
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_1(uint jarg1, uint jarg2, int jarg3, int jarg4); // 0x000000018649D6F0-0x000000018649D78C
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_2(uint jarg1, uint jarg2, int jarg3); // 0x000000018649D78C-0x000000018649D818
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_3(uint jarg1, uint jarg2); // 0x000000018649D818-0x000000018649D898
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_4(string jarg1, uint jarg2, int jarg3, int jarg4, bool jarg5); // 0x000000018649D898-0x000000018649D954
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_5(string jarg1, uint jarg2, int jarg3, int jarg4); // 0x000000018649D954-0x000000018649D9FC
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_6(string jarg1, uint jarg2, int jarg3); // 0x000000018649D9FC-0x000000018649DA94
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_7(string jarg1, uint jarg2); // 0x000000018649DA94-0x000000018649DB20
	public static extern int CSharp_SetSwitch__SWIG_0(uint jarg1, uint jarg2, ulong jarg3); // 0x00000001864A0884-0x00000001864A0910
	public static extern int CSharp_SetSwitch__SWIG_1(string jarg1, string jarg2, ulong jarg3); // 0x00000001864A0910-0x00000001864A09B4
	public static extern int CSharp_PostTrigger__SWIG_0(uint jarg1, ulong jarg2); // 0x000000018649C0EC-0x000000018649C12C
	public static extern int CSharp_PostTrigger__SWIG_1(string jarg1, ulong jarg2); // 0x000000018649C12C-0x000000018649C1B8
	public static extern int CSharp_SetState__SWIG_0(uint jarg1, uint jarg2); // 0x00000001848A7C90-0x00000001848A7CD0
	public static extern int CSharp_SetState__SWIG_1(string jarg1, string jarg2); // 0x00000001864A07EC-0x00000001864A0884
	public static extern int CSharp_SetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, uint jarg3); // 0x000000018649F030-0x000000018649F0C0
	public static extern int CSharp_SetGameObjectOutputBusVolume(ulong jarg1, ulong jarg2, float jarg3); // 0x000000018649F144-0x000000018649F190
	public static extern int CSharp_SetActorMixerEffect(uint jarg1, uint jarg2, uint jarg3); // 0x000000018649E93C-0x000000018649E9C8
	public static extern int CSharp_SetBusEffect__SWIG_0(uint jarg1, uint jarg2, uint jarg3); // 0x000000018649ED24-0x000000018649EDB0
	public static extern int CSharp_SetBusEffect__SWIG_1(string jarg1, uint jarg2, uint jarg3); // 0x000000018649EDB0-0x000000018649EE48
	public static extern int CSharp_SetOutputDeviceEffect(ulong jarg1, uint jarg2, uint jarg3); // 0x000000018649FDA8-0x000000018649FE38
	public static extern int CSharp_SetMixer__SWIG_0(uint jarg1, uint jarg2); // 0x000000018649F7E0-0x000000018649F860
	public static extern int CSharp_SetMixer__SWIG_1(string jarg1, uint jarg2); // 0x000000018649F860-0x000000018649F8EC
	public static extern int CSharp_SetBusConfig__SWIG_0(uint jarg1, IntPtr jarg2); // 0x000000018649EADC-0x000000018649EB5C
	public static extern int CSharp_SetBusConfig__SWIG_1(string jarg1, IntPtr jarg2); // 0x000000018649EB5C-0x000000018649EBE8
	public static extern int CSharp_SetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, float jarg3, float jarg4); // 0x000000018649FCA0-0x000000018649FCFC
	public static extern int CSharp_SetMultipleObstructionAndOcclusion(ulong jarg1, ulong jarg2, IntPtr jarg3, uint jarg4); // 0x000000018649F8EC-0x000000018649F98C
	public static extern int CSharp_StartOutputCapture(string jarg1); // 0x00000001864A0A1C-0x00000001864A0A98
	public static extern int CSharp_StopOutputCapture(); // 0x00000001864A0DCC-0x00000001864A0DF8
	public static extern int CSharp_AddOutputCaptureMarker(string jarg1); // 0x000000018648BAC0-0x000000018648BB58
	public static extern int CSharp_AddOutputCaptureBinaryMarker(IntPtr jarg1, uint jarg2); // 0x000000018648BA80-0x000000018648BAC0
	public static extern uint CSharp_GetSampleRate(); // 0x0000000186499634-0x0000000186499660
	public static extern int CSharp_StartProfilerCapture(string jarg1); // 0x00000001864A0AC4-0x00000001864A0B40
	public static extern int CSharp_StopProfilerCapture(); // 0x00000001864A0FA8-0x00000001864A0FD4
	public static extern int CSharp_SetOfflineRenderingFrameTime(float jarg1); // 0x000000018649FCFC-0x000000018649FD30
	public static extern int CSharp_SetOfflineRendering(bool jarg1); // 0x000000018649FD30-0x000000018649FDA8
	public static extern int CSharp_RemoveOutput(ulong jarg1); // 0x000000018649D360-0x000000018649D3D8
	public static extern int CSharp_ReplaceOutput__SWIG_0(IntPtr jarg1, ulong jarg2, out ulong jarg3); // 0x000000018649D4B8-0x000000018649D548
	public static extern int CSharp_ReplaceOutput__SWIG_1(IntPtr jarg1, ulong jarg2); // 0x000000018649D548-0x000000018649D5CC
	public static extern ulong CSharp_GetOutputID__SWIG_0(uint jarg1, uint jarg2); // 0x0000000186498F78-0x0000000186498FF8
	public static extern ulong CSharp_GetOutputID__SWIG_1(string jarg1, uint jarg2); // 0x0000000186498FF8-0x0000000186499098
	public static extern int CSharp_SetBusDevice__SWIG_0(uint jarg1, uint jarg2); // 0x000000018649EBE8-0x000000018649EC68
	public static extern int CSharp_SetBusDevice__SWIG_1(string jarg1, string jarg2); // 0x000000018649EC68-0x000000018649ED24
	public static extern int CSharp_GetDeviceList__SWIG_0(uint jarg1, uint jarg2, out uint jarg3, IntPtr jarg4); // 0x00000001864988DC-0x0000000186498978
	public static extern int CSharp_GetDeviceList__SWIG_1(uint jarg1, out uint jarg2, IntPtr jarg3); // 0x0000000184A7A8A0-0x0000000184A7A940
	public static extern int CSharp_SetOutputVolume(ulong jarg1, float jarg2); // 0x000000018649FE38-0x000000018649FE74
	public static extern int CSharp_GetDeviceSpatialAudioSupport(uint jarg1); // 0x0000000184A7A740-0x0000000184A7A780
	public static extern int CSharp_Suspend__SWIG_0(bool jarg1, bool jarg2); // 0x00000001864A1008-0x00000001864A1088
	public static extern int CSharp_Suspend__SWIG_1(bool jarg1); // 0x00000001864A1088-0x00000001864A1100
	public static extern int CSharp_Suspend__SWIG_2(); // 0x00000001864A1100-0x00000001864A112C
	public static extern int CSharp_WakeupFromSuspend__SWIG_0(uint jarg1); // 0x00000001864A1870-0x00000001864A18A4
	public static extern int CSharp_WakeupFromSuspend__SWIG_1(); // 0x00000001864A18A4-0x00000001864A18D0
	public static extern uint CSharp_GetBufferTick(); // 0x0000000186498550-0x000000018649857C
	public static extern ulong CSharp_GetSampleTick(); // 0x0000000186499660-0x000000018649968C
	public static extern void CSharp_AkSegmentInfo_iCurrentPosition_set(IntPtr jarg1, int jarg2); // 0x0000000186495B24-0x0000000186495BA4
	public static extern int CSharp_AkSegmentInfo_iCurrentPosition_get(IntPtr jarg1); // 0x0000000186495AF0-0x0000000186495B24
	public static extern void CSharp_AkSegmentInfo_iPreEntryDuration_set(IntPtr jarg1, int jarg2); // 0x0000000186495C4C-0x0000000186495C8C
	public static extern int CSharp_AkSegmentInfo_iPreEntryDuration_get(IntPtr jarg1); // 0x0000000186495C18-0x0000000186495C4C
	public static extern void CSharp_AkSegmentInfo_iActiveDuration_set(IntPtr jarg1, int jarg2); // 0x0000000186495AB0-0x0000000186495AF0
	public static extern int CSharp_AkSegmentInfo_iActiveDuration_get(IntPtr jarg1); // 0x0000000186495A7C-0x0000000186495AB0
	public static extern void CSharp_AkSegmentInfo_iPostExitDuration_set(IntPtr jarg1, int jarg2); // 0x0000000186495BD8-0x0000000186495C18
	public static extern int CSharp_AkSegmentInfo_iPostExitDuration_get(IntPtr jarg1); // 0x0000000186495BA4-0x0000000186495BD8
	public static extern void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(IntPtr jarg1, int jarg2); // 0x0000000186495CC0-0x0000000186495D00
	public static extern int CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1); // 0x0000000186495C8C-0x0000000186495CC0
	public static extern void CSharp_AkSegmentInfo_fBeatDuration_set(IntPtr jarg1, float jarg2); // 0x0000000186495950-0x0000000186495994
	public static extern float CSharp_AkSegmentInfo_fBeatDuration_get(IntPtr jarg1); // 0x000000018649591C-0x0000000186495950
	public static extern void CSharp_AkSegmentInfo_fBarDuration_set(IntPtr jarg1, float jarg2); // 0x00000001864958D8-0x000000018649591C
	public static extern float CSharp_AkSegmentInfo_fBarDuration_get(IntPtr jarg1); // 0x00000001864958A4-0x00000001864958D8
	public static extern void CSharp_AkSegmentInfo_fGridDuration_set(IntPtr jarg1, float jarg2); // 0x00000001864959C8-0x0000000186495A0C
	public static extern float CSharp_AkSegmentInfo_fGridDuration_get(IntPtr jarg1); // 0x0000000186495994-0x00000001864959C8
	public static extern void CSharp_AkSegmentInfo_fGridOffset_set(IntPtr jarg1, float jarg2); // 0x0000000186495A40-0x0000000186495A7C
	public static extern float CSharp_AkSegmentInfo_fGridOffset_get(IntPtr jarg1); // 0x0000000186495A0C-0x0000000186495A40
	public static extern IntPtr CSharp_new_AkSegmentInfo(); // 0x00000001864A38B8-0x00000001864A38E4
	public static extern void CSharp_delete_AkSegmentInfo(IntPtr jarg1); // 0x00000001864A2520-0x00000001864A2554
	public static extern void CSharp_AkResourceMonitorDataSummary_totalCPU_set(IntPtr jarg1, float jarg2); // 0x000000018649551C-0x0000000186495560
	public static extern float CSharp_AkResourceMonitorDataSummary_totalCPU_get(IntPtr jarg1); // 0x00000001864954E8-0x000000018649551C
	public static extern void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(IntPtr jarg1, float jarg2); // 0x00000001864954AC-0x00000001864954E8
	public static extern float CSharp_AkResourceMonitorDataSummary_pluginCPU_get(IntPtr jarg1); // 0x0000000186495478-0x00000001864954AC
	public static extern void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(IntPtr jarg1, uint jarg2); // 0x0000000186495438-0x0000000186495478
	public static extern uint CSharp_AkResourceMonitorDataSummary_physicalVoices_get(IntPtr jarg1); // 0x0000000186495404-0x0000000186495438
	public static extern void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(IntPtr jarg1, uint jarg2); // 0x0000000186495608-0x0000000186495648
	public static extern uint CSharp_AkResourceMonitorDataSummary_virtualVoices_get(IntPtr jarg1); // 0x00000001864955D4-0x0000000186495608
	public static extern void CSharp_AkResourceMonitorDataSummary_totalVoices_set(IntPtr jarg1, uint jarg2); // 0x0000000186495594-0x00000001864955D4
	public static extern uint CSharp_AkResourceMonitorDataSummary_totalVoices_get(IntPtr jarg1); // 0x0000000186495560-0x0000000186495594
	public static extern void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(IntPtr jarg1, uint jarg2); // 0x00000001864953C4-0x0000000186495404
	public static extern uint CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(IntPtr jarg1); // 0x0000000186495390-0x00000001864953C4
	public static extern IntPtr CSharp_new_AkResourceMonitorDataSummary(); // 0x00000001864A388C-0x00000001864A38B8
	public static extern void CSharp_delete_AkResourceMonitorDataSummary(IntPtr jarg1); // 0x00000001864A24B8-0x00000001864A24EC
	public static extern byte CSharp_AK_INVALID_MIDI_CHANNEL_get(); // 0x000000018648B5EC-0x000000018648B654
	public static extern byte CSharp_AK_INVALID_MIDI_NOTE_get(); // 0x000000018648B654-0x000000018648B680
	public static extern void CSharp_AkMIDIEvent_byChan_set(IntPtr jarg1, byte jarg2); // 0x0000000186490C4C-0x0000000186490C8C
	public static extern byte CSharp_AkMIDIEvent_byChan_get(IntPtr jarg1); // 0x0000000186490C18-0x0000000186490C4C
	public static extern void CSharp_AkMIDIEvent_tGen_byParam1_set(IntPtr jarg1, byte jarg2); // 0x0000000186491250-0x0000000186491290
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam1_get(IntPtr jarg1); // 0x000000018649121C-0x0000000186491250
	public static extern void CSharp_AkMIDIEvent_tGen_byParam2_set(IntPtr jarg1, byte jarg2); // 0x0000000186491308-0x0000000186491348
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam2_get(IntPtr jarg1); // 0x0000000186491290-0x0000000186491308
	public static extern IntPtr CSharp_new_AkMIDIEvent_tGen(); // 0x00000001864A3160-0x00000001864A318C
	public static extern void CSharp_delete_AkMIDIEvent_tGen(IntPtr jarg1); // 0x00000001864A1FA4-0x00000001864A1FD8
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(IntPtr jarg1, byte jarg2); // 0x00000001864914A8-0x00000001864914E8
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(IntPtr jarg1); // 0x0000000186491474-0x00000001864914A8
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(IntPtr jarg1, byte jarg2); // 0x000000018649151C-0x000000018649159C
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(IntPtr jarg1); // 0x00000001864914E8-0x000000018649151C
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff(); // 0x00000001864A31B8-0x00000001864A31E4
	public static extern void CSharp_delete_AkMIDIEvent_tNoteOnOff(IntPtr jarg1); // 0x00000001864A200C-0x00000001864A2040
	public static extern void CSharp_AkMIDIEvent_tCc_byCc_set(IntPtr jarg1, byte jarg2); // 0x0000000186491070-0x00000001864910B0
	public static extern byte CSharp_AkMIDIEvent_tCc_byCc_get(IntPtr jarg1); // 0x000000018649103C-0x0000000186491070
	public static extern void CSharp_AkMIDIEvent_tCc_byValue_set(IntPtr jarg1, byte jarg2); // 0x0000000186491128-0x00000001864911A8
	public static extern byte CSharp_AkMIDIEvent_tCc_byValue_get(IntPtr jarg1); // 0x00000001864910B0-0x0000000186491128
	public static extern IntPtr CSharp_new_AkMIDIEvent_tCc(); // 0x00000001864A3108-0x00000001864A3134
	public static extern void CSharp_delete_AkMIDIEvent_tCc(IntPtr jarg1); // 0x00000001864A1F3C-0x00000001864A1F70
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(IntPtr jarg1, byte jarg2); // 0x00000001864915D0-0x0000000186491650
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(IntPtr jarg1); // 0x000000018649159C-0x00000001864915D0
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(IntPtr jarg1, byte jarg2); // 0x0000000186491684-0x0000000186491704
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(IntPtr jarg1); // 0x0000000186491650-0x0000000186491684
	public static extern IntPtr CSharp_new_AkMIDIEvent_tPitchBend(); // 0x00000001864A31E4-0x00000001864A3210
	public static extern void CSharp_delete_AkMIDIEvent_tPitchBend(IntPtr jarg1); // 0x00000001864A2040-0x00000001864A2074
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(IntPtr jarg1, byte jarg2); // 0x000000018649137C-0x00000001864913BC
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(IntPtr jarg1); // 0x0000000186491348-0x000000018649137C
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(IntPtr jarg1, byte jarg2); // 0x0000000186491434-0x0000000186491474
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(IntPtr jarg1); // 0x00000001864913BC-0x0000000186491434
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch(); // 0x00000001864A318C-0x00000001864A31B8
	public static extern void CSharp_delete_AkMIDIEvent_tNoteAftertouch(IntPtr jarg1); // 0x00000001864A1FD8-0x00000001864A200C
	public static extern void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(IntPtr jarg1, byte jarg2); // 0x00000001864911DC-0x000000018649121C
	public static extern byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(IntPtr jarg1); // 0x00000001864911A8-0x00000001864911DC
	public static extern IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch(); // 0x00000001864A3134-0x00000001864A3160
	public static extern void CSharp_delete_AkMIDIEvent_tChanAftertouch(IntPtr jarg1); // 0x00000001864A1F70-0x00000001864A1FA4
	public static extern void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(IntPtr jarg1, byte jarg2); // 0x000000018649177C-0x00000001864917BC
	public static extern byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(IntPtr jarg1); // 0x0000000186491704-0x000000018649177C
	public static extern IntPtr CSharp_new_AkMIDIEvent_tProgramChange(); // 0x00000001864A3210-0x00000001864A323C
	public static extern void CSharp_delete_AkMIDIEvent_tProgramChange(IntPtr jarg1); // 0x00000001864A2074-0x00000001864A20A8
	public static extern void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(IntPtr jarg1, ushort jarg2); // 0x00000001864918A4-0x0000000186491928
	public static extern ushort CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(IntPtr jarg1); // 0x0000000186491870-0x00000001864918A4
	public static extern void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(IntPtr jarg1, uint jarg2); // 0x00000001864917F0-0x0000000186491870
	public static extern uint CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(IntPtr jarg1); // 0x00000001864917BC-0x00000001864917F0
	public static extern IntPtr CSharp_new_AkMIDIEvent_tWwiseCmd(); // 0x00000001864A323C-0x00000001864A3270
	public static extern void CSharp_delete_AkMIDIEvent_tWwiseCmd(IntPtr jarg1); // 0x00000001864A20A8-0x00000001864A20DC
	public static extern void CSharp_AkMIDIEvent_Gen_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000186490694-0x00000001864906D8
	public static extern IntPtr CSharp_AkMIDIEvent_Gen_get(IntPtr jarg1); // 0x0000000186490660-0x0000000186490694
	public static extern void CSharp_AkMIDIEvent_Cc_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018649055C-0x00000001864905E0
	public static extern IntPtr CSharp_AkMIDIEvent_Cc_get(IntPtr jarg1); // 0x0000000186490528-0x000000018649055C
	public static extern void CSharp_AkMIDIEvent_NoteOnOff_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000186490784-0x00000001864907C8
	public static extern IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(IntPtr jarg1); // 0x0000000186490750-0x0000000186490784
	public static extern void CSharp_AkMIDIEvent_PitchBend_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000186490804-0x0000000186490848
	public static extern IntPtr CSharp_AkMIDIEvent_PitchBend_get(IntPtr jarg1); // 0x00000001864907C8-0x0000000186490804
	public static extern void CSharp_AkMIDIEvent_NoteAftertouch_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018649070C-0x0000000186490750
	public static extern IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(IntPtr jarg1); // 0x00000001864906D8-0x000000018649070C
	public static extern void CSharp_AkMIDIEvent_ChanAftertouch_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018649061C-0x0000000186490660
	public static extern IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(IntPtr jarg1); // 0x00000001864905E0-0x000000018649061C
	public static extern void CSharp_AkMIDIEvent_ProgramChange_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018649087C-0x00000001864908C0
	public static extern IntPtr CSharp_AkMIDIEvent_ProgramChange_get(IntPtr jarg1); // 0x0000000186490848-0x000000018649087C
	public static extern void CSharp_AkMIDIEvent_WwiseCmd_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001864908FC-0x0000000186490940
	public static extern IntPtr CSharp_AkMIDIEvent_WwiseCmd_get(IntPtr jarg1); // 0x00000001864908C0-0x00000001864908FC
	public static extern void CSharp_AkMIDIEvent_byType_set(IntPtr jarg1, int jarg2); // 0x0000000186490EA0-0x0000000186490EE0
	public static extern int CSharp_AkMIDIEvent_byType_get(IntPtr jarg1); // 0x0000000186490E6C-0x0000000186490EA0
	public static extern void CSharp_AkMIDIEvent_byOnOffNote_set(IntPtr jarg1, byte jarg2); // 0x0000000186490D78-0x0000000186490DF8
	public static extern byte CSharp_AkMIDIEvent_byOnOffNote_get(IntPtr jarg1); // 0x0000000186490D44-0x0000000186490D78
	public static extern void CSharp_AkMIDIEvent_byVelocity_set(IntPtr jarg1, byte jarg2); // 0x0000000186490FFC-0x000000018649103C
	public static extern byte CSharp_AkMIDIEvent_byVelocity_get(IntPtr jarg1); // 0x0000000186490FC8-0x0000000186490FFC
	public static extern void CSharp_AkMIDIEvent_byCc_set(IntPtr jarg1, int jarg2); // 0x0000000186490AE0-0x0000000186490B20
	public static extern int CSharp_AkMIDIEvent_byCc_get(IntPtr jarg1); // 0x0000000186490AAC-0x0000000186490AE0
	public static extern void CSharp_AkMIDIEvent_byCcValue_set(IntPtr jarg1, byte jarg2); // 0x0000000186490A6C-0x0000000186490AAC
	public static extern byte CSharp_AkMIDIEvent_byCcValue_get(IntPtr jarg1); // 0x00000001864909F4-0x0000000186490A6C
	public static extern void CSharp_AkMIDIEvent_byValueLsb_set(IntPtr jarg1, byte jarg2); // 0x0000000186490F14-0x0000000186490F54
	public static extern byte CSharp_AkMIDIEvent_byValueLsb_get(IntPtr jarg1); // 0x0000000186490EE0-0x0000000186490F14
	public static extern void CSharp_AkMIDIEvent_byValueMsb_set(IntPtr jarg1, byte jarg2); // 0x0000000186490F88-0x0000000186490FC8
	public static extern byte CSharp_AkMIDIEvent_byValueMsb_get(IntPtr jarg1); // 0x0000000186490F54-0x0000000186490F88
	public static extern void CSharp_AkMIDIEvent_byAftertouchNote_set(IntPtr jarg1, byte jarg2); // 0x0000000186490974-0x00000001864909F4
	public static extern byte CSharp_AkMIDIEvent_byAftertouchNote_get(IntPtr jarg1); // 0x0000000186490940-0x0000000186490974
	public static extern void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(IntPtr jarg1, byte jarg2); // 0x0000000186490D04-0x0000000186490D44
	public static extern byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(IntPtr jarg1); // 0x0000000186490C8C-0x0000000186490D04
	public static extern void CSharp_AkMIDIEvent_byChanAftertouchValue_set(IntPtr jarg1, byte jarg2); // 0x0000000186490B98-0x0000000186490C18
	public static extern byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(IntPtr jarg1); // 0x0000000186490B20-0x0000000186490B98
	public static extern void CSharp_AkMIDIEvent_byProgramNum_set(IntPtr jarg1, byte jarg2); // 0x0000000186490E2C-0x0000000186490E6C
	public static extern byte CSharp_AkMIDIEvent_byProgramNum_get(IntPtr jarg1); // 0x0000000186490DF8-0x0000000186490E2C
	public static extern void CSharp_AkMIDIEvent_uCmd_set(IntPtr jarg1, ushort jarg2); // 0x0000000186491A14-0x0000000186491A98
	public static extern ushort CSharp_AkMIDIEvent_uCmd_get(IntPtr jarg1); // 0x000000018649199C-0x0000000186491A14
	public static extern void CSharp_AkMIDIEvent_uArg_set(IntPtr jarg1, uint jarg2); // 0x000000018649195C-0x000000018649199C
	public static extern uint CSharp_AkMIDIEvent_uArg_get(IntPtr jarg1); // 0x0000000186491928-0x000000018649195C
	public static extern IntPtr CSharp_new_AkMIDIEvent(); // 0x00000001864A30DC-0x00000001864A3108
	public static extern void CSharp_delete_AkMIDIEvent(IntPtr jarg1); // 0x00000001864A1F08-0x00000001864A1F3C
	public static extern void CSharp_AkMIDIPost_uOffset_set(IntPtr jarg1, ulong jarg2); // 0x0000000186491E68-0x0000000186491EAC
	public static extern ulong CSharp_AkMIDIPost_uOffset_get(IntPtr jarg1); // 0x0000000186491DF0-0x0000000186491E68
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_0(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4); // 0x0000000186491B08-0x0000000186491BA8
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_1(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5); // 0x0000000186491BA8-0x0000000186491C58
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_2(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8); // 0x0000000186491C58-0x0000000186491D08
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_3(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8, uint jarg9); // 0x0000000186491D08-0x0000000186491DBC
	public static extern void CSharp_AkMIDIPost_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000186491A98-0x0000000186491ADC
	public static extern int CSharp_AkMIDIPost_GetSizeOf(); // 0x0000000186491ADC-0x0000000186491B08
	public static extern IntPtr CSharp_new_AkMIDIPost(); // 0x00000001864A3270-0x00000001864A329C
	public static extern void CSharp_delete_AkMIDIPost(IntPtr jarg1); // 0x00000001864A20DC-0x00000001864A2110
	public static extern void CSharp_AkMemCategroyStats_uUsed_set(IntPtr jarg1, ulong jarg2); // 0x0000000186492160-0x00000001864921E4
	public static extern ulong CSharp_AkMemCategroyStats_uUsed_get(IntPtr jarg1); // 0x000000018649212C-0x0000000186492160
	public static extern void CSharp_AkMemCategroyStats_uPeakUsed_set(IntPtr jarg1, ulong jarg2); // 0x00000001864920A8-0x000000018649212C
	public static extern ulong CSharp_AkMemCategroyStats_uPeakUsed_get(IntPtr jarg1); // 0x0000000186492030-0x00000001864920A8
	public static extern void CSharp_AkMemCategroyStats_uAllocs_set(IntPtr jarg1, uint jarg2); // 0x0000000186491F7C-0x0000000186491FBC
	public static extern uint CSharp_AkMemCategroyStats_uAllocs_get(IntPtr jarg1); // 0x0000000186491F48-0x0000000186491F7C
	public static extern void CSharp_AkMemCategroyStats_uFrees_set(IntPtr jarg1, uint jarg2); // 0x0000000186491FF0-0x0000000186492030
	public static extern uint CSharp_AkMemCategroyStats_uFrees_get(IntPtr jarg1); // 0x0000000186491FBC-0x0000000186491FF0
	public static extern IntPtr CSharp_new_AkMemCategroyStats(); // 0x0000000185D69B10-0x0000000185D69B40
	public static extern void CSharp_delete_AkMemCategroyStats(IntPtr jarg1); // 0x00000001864A2144-0x00000001864A2178
	public static extern void CSharp_AkMemGlobalStats_uUsed_set(IntPtr jarg1, ulong jarg2); // 0x0000000186492580-0x0000000186492604
	public static extern ulong CSharp_AkMemGlobalStats_uUsed_get(IntPtr jarg1); // 0x0000000186492508-0x0000000186492580
	public static extern void CSharp_AkMemGlobalStats_uDeviceUsed_set(IntPtr jarg1, ulong jarg2); // 0x00000001864922CC-0x0000000186492350
	public static extern ulong CSharp_AkMemGlobalStats_uDeviceUsed_get(IntPtr jarg1); // 0x0000000186492298-0x00000001864922CC
	public static extern void CSharp_AkMemGlobalStats_uReserved_set(IntPtr jarg1, ulong jarg2); // 0x0000000186492484-0x0000000186492508
	public static extern ulong CSharp_AkMemGlobalStats_uReserved_get(IntPtr jarg1); // 0x000000018649240C-0x0000000186492484
	public static extern void CSharp_AkMemGlobalStats_uMax_set(IntPtr jarg1, ulong jarg2); // 0x00000001864923C8-0x000000018649240C
	public static extern ulong CSharp_AkMemGlobalStats_uMax_get(IntPtr jarg1); // 0x0000000186492350-0x00000001864923C8
	public static extern IntPtr CSharp_new_AkMemGlobalStats(); // 0x00000001864A32C8-0x00000001864A32F4
	public static extern void CSharp_delete_AkMemGlobalStats(IntPtr jarg1); // 0x00000001864A2178-0x00000001864A21AC
	public static extern void CSharp_AkMemGetCategoryStats(int jarg1, IntPtr jarg2); // 0x00000001864921E4-0x0000000186492264
	public static extern void CSharp_AkMemGetGlobalStats(IntPtr jarg1); // 0x0000000186492264-0x0000000186492298
	public static extern void CSharp_StartProfileThreadUsage(); // 0x00000001864A0A98-0x00000001864A0AC4
	public static extern ulong CSharp_StopProfileThreadUsage(); // 0x00000001864A0F7C-0x00000001864A0FA8
	public static extern void CSharp_DumpToFile(string jarg1); // 0x00000001864973BC-0x0000000186497438
	public static extern ulong CSharp_GetGlobalUsed(); // 0x0000000186498C90-0x0000000186498CBC
	public static extern ulong CSharp_GetGlobalReserved(); // 0x0000000186498C28-0x0000000186498C90
	public static extern void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(IntPtr jarg1, float jarg2); // 0x00000001855016B0-0x0000000185501700
	public static extern float CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(IntPtr jarg1); // 0x0000000186492824-0x0000000186492858
	public static extern void CSharp_delete_AkMusicSettings(IntPtr jarg1); // 0x00000001864A2214-0x00000001864A2248
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_0(uint jarg1, IntPtr jarg2, bool jarg3); // 0x00000001864992A0-0x0000000186499330
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_1(uint jarg1, IntPtr jarg2); // 0x0000000186499330-0x00000001864993B0
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(IntPtr jarg1); // 0x00000001845999D0-0x0000000184599A10
	public static extern uint CSharp_AkSerializedCallbackHeader_eType_get(IntPtr jarg1); // 0x0000000184599A90-0x0000000184599AD0
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_GetData(IntPtr jarg1); // 0x0000000184599990-0x00000001845999D0
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(IntPtr jarg1); // 0x0000000184599A10-0x0000000184599A90
	public static extern IntPtr CSharp_new_AkSerializedCallbackHeader(); // 0x00000001864A38E4-0x00000001864A3910
	public static extern void CSharp_delete_AkSerializedCallbackHeader(IntPtr jarg1); // 0x00000001864A2554-0x00000001864A2588
	public static extern IntPtr CSharp_AkCallbackInfo_pCookie_get(IntPtr jarg1); // 0x0000000184CD9560-0x0000000184CD95E0
	public static extern ulong CSharp_AkCallbackInfo_gameObjID_get(IntPtr jarg1); // 0x0000000184CD9650-0x0000000184CD9680
	public static extern IntPtr CSharp_new_AkCallbackInfo(); // 0x00000001864A2AB8-0x00000001864A2AE4
	public static extern void CSharp_delete_AkCallbackInfo(IntPtr jarg1); // 0x00000001864A1B60-0x00000001864A1B94
	public static extern uint CSharp_AkEventCallbackInfo_playingID_get(IntPtr jarg1); // 0x000000018648EB94-0x000000018648EBC8
	public static extern uint CSharp_AkEventCallbackInfo_eventID_get(IntPtr jarg1); // 0x0000000184CD96F0-0x0000000184CD9780
	public static extern IntPtr CSharp_new_AkEventCallbackInfo(); // 0x00000001864A2C98-0x00000001864A2CC4
	public static extern void CSharp_delete_AkEventCallbackInfo(IntPtr jarg1); // 0x00000001864A1D34-0x00000001864A1D68
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChan_get(IntPtr jarg1); // 0x0000000186490254-0x0000000186490288
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(IntPtr jarg1); // 0x00000001864902F0-0x0000000186490324
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(IntPtr jarg1); // 0x0000000186490324-0x000000018649039C
	public static extern int CSharp_AkMIDIEventCallbackInfo_byType_get(IntPtr jarg1); // 0x00000001864903D0-0x0000000186490404
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(IntPtr jarg1); // 0x00000001864902BC-0x00000001864902F0
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(IntPtr jarg1); // 0x00000001864904B0-0x0000000186490528
	public static extern int CSharp_AkMIDIEventCallbackInfo_byCc_get(IntPtr jarg1); // 0x00000001864901EC-0x0000000186490220
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(IntPtr jarg1); // 0x00000001864901B8-0x00000001864901EC
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(IntPtr jarg1); // 0x0000000186490404-0x000000018649047C
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(IntPtr jarg1); // 0x000000018649047C-0x00000001864904B0
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(IntPtr jarg1); // 0x0000000186490184-0x00000001864901B8
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(IntPtr jarg1); // 0x0000000186490288-0x00000001864902BC
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(IntPtr jarg1); // 0x0000000186490220-0x0000000186490254
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(IntPtr jarg1); // 0x000000018649039C-0x00000001864903D0
	public static extern IntPtr CSharp_new_AkMIDIEventCallbackInfo(); // 0x00000001864A30B0-0x00000001864A30DC
	public static extern void CSharp_delete_AkMIDIEventCallbackInfo(IntPtr jarg1); // 0x00000001864A1ED4-0x00000001864A1F08
	public static extern uint CSharp_AkMarkerCallbackInfo_uIdentifier_get(IntPtr jarg1); // 0x0000000186491EE0-0x0000000186491F14
	public static extern uint CSharp_AkMarkerCallbackInfo_uPosition_get(IntPtr jarg1); // 0x0000000186491F14-0x0000000186491F48
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(IntPtr jarg1); // 0x0000000186491EAC-0x0000000186491EE0
	public static extern IntPtr CSharp_new_AkMarkerCallbackInfo(); // 0x00000001864A329C-0x00000001864A32C8
	public static extern void CSharp_delete_AkMarkerCallbackInfo(IntPtr jarg1); // 0x00000001864A2110-0x00000001864A2144
	public static extern float CSharp_AkDurationCallbackInfo_fDuration_get(IntPtr jarg1); // 0x000000018648EA54-0x000000018648EA88
	public static extern float CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(IntPtr jarg1); // 0x000000018648EA88-0x000000018648EABC
	public static extern uint CSharp_AkDurationCallbackInfo_audioNodeID_get(IntPtr jarg1); // 0x000000018648E9E8-0x000000018648EA1C
	public static extern uint CSharp_AkDurationCallbackInfo_mediaID_get(IntPtr jarg1); // 0x000000018648EABC-0x000000018648EAF0
	public static extern bool CSharp_AkDurationCallbackInfo_bStreaming_get(IntPtr jarg1); // 0x000000018648EA1C-0x000000018648EA54
	public static extern IntPtr CSharp_new_AkDurationCallbackInfo(); // 0x00000001864A2C40-0x00000001864A2C6C
	public static extern void CSharp_delete_AkDurationCallbackInfo(IntPtr jarg1); // 0x00000001864A1CCC-0x00000001864A1D00
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(IntPtr jarg1); // 0x000000018648EB60-0x000000018648EB94
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(IntPtr jarg1); // 0x000000018648EAF0-0x000000018648EB24
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(IntPtr jarg1); // 0x000000018648EB24-0x000000018648EB60
	public static extern IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo(); // 0x00000001864A2C6C-0x00000001864A2C98
	public static extern void CSharp_delete_AkDynamicSequenceItemCallbackInfo(IntPtr jarg1); // 0x00000001864A1D00-0x00000001864A1D34
	public static extern uint CSharp_AkMusicSyncCallbackInfo_playingID_get(IntPtr jarg1); // 0x000000018649288C-0x00000001864928C0
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(IntPtr jarg1); // 0x00000001864929C4-0x00000001864929F8
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(IntPtr jarg1); // 0x0000000186492A2C-0x0000000186492A60
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(IntPtr jarg1); // 0x0000000186492990-0x00000001864929C4
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(IntPtr jarg1); // 0x00000001864929F8-0x0000000186492A2C
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1); // 0x0000000186492A60-0x0000000186492A94
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(IntPtr jarg1); // 0x00000001864928F4-0x0000000186492928
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(IntPtr jarg1); // 0x00000001864928C0-0x00000001864928F4
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(IntPtr jarg1); // 0x0000000186492928-0x000000018649295C
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(IntPtr jarg1); // 0x000000018649295C-0x0000000186492990
	public static extern int CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(IntPtr jarg1); // 0x0000000186492858-0x000000018649288C
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(IntPtr jarg1); // 0x0000000186492A94-0x0000000186492AC8
	public static extern IntPtr CSharp_new_AkMusicSyncCallbackInfo(); // 0x00000001864A334C-0x00000001864A3378
	public static extern void CSharp_delete_AkMusicSyncCallbackInfo(IntPtr jarg1); // 0x00000001864A2248-0x00000001864A227C
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(IntPtr jarg1); // 0x0000000186492754-0x0000000186492788
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(IntPtr jarg1); // 0x0000000186492788-0x00000001864927BC
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(IntPtr jarg1); // 0x00000001864927F0-0x0000000186492824
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(IntPtr jarg1); // 0x00000001864927BC-0x00000001864927F0
	public static extern IntPtr CSharp_new_AkMusicPlaylistCallbackInfo(); // 0x00000001864A3320-0x00000001864A334C
	public static extern void CSharp_delete_AkMusicPlaylistCallbackInfo(IntPtr jarg1); // 0x00000001864A21E0-0x00000001864A2214
	public static extern uint CSharp_AkBankCallbackInfo_bankID_get(IntPtr jarg1); // 0x0000000184597260-0x00000001845972A0
	public static extern IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(IntPtr jarg1); // 0x0000000184597120-0x0000000184597160
	public static extern int CSharp_AkBankCallbackInfo_loadResult_get(IntPtr jarg1); // 0x00000001845971C0-0x0000000184597200
	public static extern IntPtr CSharp_new_AkBankCallbackInfo(); // 0x00000001864A2A60-0x00000001864A2A8C
	public static extern void CSharp_delete_AkBankCallbackInfo(IntPtr jarg1); // 0x00000001864A1AF8-0x00000001864A1B2C
	public static extern int CSharp_AkMonitoringCallbackInfo_errorCode_get(IntPtr jarg1); // 0x0000000186492604-0x0000000186492638
	public static extern int CSharp_AkMonitoringCallbackInfo_errorLevel_get(IntPtr jarg1); // 0x0000000186492638-0x000000018649266C
	public static extern uint CSharp_AkMonitoringCallbackInfo_playingID_get(IntPtr jarg1); // 0x0000000186492720-0x0000000186492754
	public static extern ulong CSharp_AkMonitoringCallbackInfo_gameObjID_get(IntPtr jarg1); // 0x000000018649266C-0x00000001864926E4
	public static extern IntPtr CSharp_AkMonitoringCallbackInfo_message_get(IntPtr jarg1); // 0x00000001864926E4-0x0000000186492720
	public static extern IntPtr CSharp_new_AkMonitoringCallbackInfo(); // 0x00000001864A32F4-0x00000001864A3320
	public static extern void CSharp_delete_AkMonitoringCallbackInfo(IntPtr jarg1); // 0x00000001864A21AC-0x00000001864A21E0
	public static extern bool CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(IntPtr jarg1); // 0x000000018648C82C-0x000000018648C864
	public static extern IntPtr CSharp_new_AkAudioInterruptionCallbackInfo(); // 0x00000001864A29DC-0x00000001864A2A08
	public static extern void CSharp_delete_AkAudioInterruptionCallbackInfo(IntPtr jarg1); // 0x00000001864A1A28-0x00000001864A1A5C
	public static extern bool CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(IntPtr jarg1); // 0x000000018648C94C-0x000000018648C984
	public static extern IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo(); // 0x00000001864A2A34-0x00000001864A2A60
	public static extern void CSharp_delete_AkAudioSourceChangeCallbackInfo(IntPtr jarg1); // 0x00000001864A1A90-0x00000001864A1AC4
	public static extern int CSharp_AkCallbackSerializer_Init(); // 0x00000001854FF080-0x00000001854FF0B0
	public static extern void CSharp_AkCallbackSerializer_Term(); // 0x000000018648D1CC-0x000000018648D234
	public static extern IntPtr CSharp_AkCallbackSerializer_Lock(); // 0x00000001845992E0-0x0000000184599310
	public static extern void CSharp_AkCallbackSerializer_Unlock(); // 0x0000000184E6FB50-0x0000000184E6FBC0
	public static extern void CSharp_AkCallbackSerializer_SetLocalOutput(uint jarg1, string jarg2, uint jarg3, string jarg4, uint jarg5, uint jarg6); // 0x000000018648D0F0-0x000000018648D1CC
	public static extern int CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(bool jarg1, IntPtr jarg2); // 0x000000018648D070-0x000000018648D0F0
	public static extern IntPtr CSharp_new_AkCallbackSerializer(); // 0x00000001864A2AE4-0x00000001864A2B10
	public static extern void CSharp_delete_AkCallbackSerializer(IntPtr jarg1); // 0x00000001864A1B94-0x00000001864A1BC8
	public static extern IntPtr CSharp_new_MsgContext__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, bool jarg4); // 0x00000001864A3BFC-0x00000001864A3C9C
	public static extern IntPtr CSharp_new_MsgContext__SWIG_1(uint jarg1, ulong jarg2, uint jarg3); // 0x00000001864A3C9C-0x00000001864A3D2C
	public static extern IntPtr CSharp_new_MsgContext__SWIG_2(uint jarg1, ulong jarg2); // 0x00000001864A3D2C-0x00000001864A3DAC
	public static extern IntPtr CSharp_new_MsgContext__SWIG_3(uint jarg1); // 0x00000001864A3DAC-0x00000001864A3E24
	public static extern IntPtr CSharp_new_MsgContext__SWIG_4(); // 0x00000001864A3E24-0x00000001864A3E50
	public static extern void CSharp_MsgContext_in_playingID_set(IntPtr jarg1, uint jarg2); // 0x000000018649B150-0x000000018649B190
	public static extern uint CSharp_MsgContext_in_playingID_get(IntPtr jarg1); // 0x000000018649B11C-0x000000018649B150
	public static extern void CSharp_MsgContext_in_gameObjID_set(IntPtr jarg1, ulong jarg2); // 0x000000018649B098-0x000000018649B11C
	public static extern ulong CSharp_MsgContext_in_gameObjID_get(IntPtr jarg1); // 0x000000018649B020-0x000000018649B098
	public static extern void CSharp_MsgContext_in_soundID_set(IntPtr jarg1, uint jarg2); // 0x000000018649B1C4-0x000000018649B204
	public static extern uint CSharp_MsgContext_in_soundID_get(IntPtr jarg1); // 0x000000018649B190-0x000000018649B1C4
	public static extern void CSharp_MsgContext_in_bIsBus_set(IntPtr jarg1, bool jarg2); // 0x000000018649AFDC-0x000000018649B020
	public static extern bool CSharp_MsgContext_in_bIsBus_get(IntPtr jarg1); // 0x000000018649AFA4-0x000000018649AFDC
	public static extern void CSharp_delete_MsgContext(IntPtr jarg1); // 0x00000001864A2790-0x00000001864A27C4
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_0(string jarg1, string jarg2); // 0x00000001864A3ABC-0x00000001864A3B54
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_1(string jarg1); // 0x00000001864A3B54-0x00000001864A3BD0
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_2(); // 0x00000001864A3BD0-0x00000001864A3BFC
	public static extern void CSharp_MonitorErrorInfo_m_name_set(IntPtr jarg1, string jarg2); // 0x000000018649ADC8-0x000000018649AE54
	public static extern IntPtr CSharp_MonitorErrorInfo_m_name_get(IntPtr jarg1); // 0x000000018649AD8C-0x000000018649ADC8
	public static extern void CSharp_MonitorErrorInfo_m_message_set(IntPtr jarg1, string jarg2); // 0x000000018649AD00-0x000000018649AD8C
	public static extern IntPtr CSharp_MonitorErrorInfo_m_message_get(IntPtr jarg1); // 0x000000018649ACC4-0x000000018649AD00
	public static extern void CSharp_delete_MonitorErrorInfo(IntPtr jarg1); // 0x00000001864A275C-0x00000001864A2790
	public static extern int CSharp_PostCode__SWIG_0(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6); // 0x000000018649B460-0x000000018649B50C
	public static extern int CSharp_PostCode__SWIG_1(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5); // 0x000000018649B50C-0x000000018649B5A8
	public static extern int CSharp_PostCode__SWIG_2(int jarg1, int jarg2, uint jarg3, ulong jarg4); // 0x000000018649B5A8-0x000000018649B644
	public static extern int CSharp_PostCode__SWIG_3(int jarg1, int jarg2, uint jarg3); // 0x000000018649B644-0x000000018649B6D0
	public static extern int CSharp_PostCode__SWIG_4(int jarg1, int jarg2); // 0x000000018649B6D0-0x000000018649B750
	public static extern int CSharp_PostCodeVarArg(int jarg1, int jarg2, IntPtr jarg3); // 0x000000018649B3D4-0x000000018649B460
	public static extern int CSharp_PostString__SWIG_0(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6); // 0x000000018649BDBC-0x000000018649BE78
	public static extern int CSharp_PostString__SWIG_1(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5); // 0x000000018649BE78-0x000000018649BF20
	public static extern int CSharp_PostString__SWIG_2(string jarg1, int jarg2, uint jarg3, ulong jarg4); // 0x000000018649BF20-0x000000018649BFC8
	public static extern int CSharp_PostString__SWIG_3(string jarg1, int jarg2, uint jarg3); // 0x000000018649BFC8-0x000000018649C060
	public static extern int CSharp_PostString__SWIG_4(string jarg1, int jarg2); // 0x000000018649C060-0x000000018649C0EC
	public static extern int CSharp_ResetTranslator(); // 0x000000018649E0A4-0x000000018649E0D0
	public static extern int CSharp_GetTimeStamp(); // 0x000000018649A040-0x000000018649A06C
	public static extern void CSharp_MonitorStreamMgrInit(IntPtr jarg1); // 0x000000018649AE54-0x000000018649AE88
	public static extern void CSharp_MonitorStreamingDeviceInit(uint jarg1, IntPtr jarg2); // 0x000000018649AF24-0x000000018649AFA4
	public static extern void CSharp_MonitorStreamingDeviceDestroyed(uint jarg1); // 0x000000018649AEF0-0x000000018649AF24
	public static extern void CSharp_MonitorStreamMgrTerm(); // 0x000000018649AE88-0x000000018649AEF0
	public static extern void CSharp_AkGetDefaultHighPriorityThreadProperties(IntPtr jarg1); // 0x000000018648F214-0x000000018648F248
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_0(uint jarg1, in uint[] jarg2, uint jarg3, uint jarg4); // 0x000000018649E0D0-0x000000018649E178
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_1(uint jarg1, in uint[] jarg2, uint jarg3); // 0x000000018649E178-0x000000018649E210
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3); // 0x0000000186498978-0x0000000186498A04
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3); // 0x0000000186498A04-0x0000000186498A90
	public static extern void CSharp_AkPositioningInfo_fCenterPct_set(IntPtr jarg1, float jarg2); // 0x0000000186494998-0x00000001864949DC
	public static extern float CSharp_AkPositioningInfo_fCenterPct_get(IntPtr jarg1); // 0x0000000186494964-0x0000000186494998
	public static extern void CSharp_AkPositioningInfo_pannerType_set(IntPtr jarg1, int jarg2); // 0x0000000186494D48-0x0000000186494D88
	public static extern int CSharp_AkPositioningInfo_pannerType_get(IntPtr jarg1); // 0x0000000186494D14-0x0000000186494D48
	public static extern void CSharp_AkPositioningInfo_e3dPositioningType_set(IntPtr jarg1, int jarg2); // 0x0000000186494924-0x0000000186494964
	public static extern int CSharp_AkPositioningInfo_e3dPositioningType_get(IntPtr jarg1); // 0x00000001864948F0-0x0000000186494924
	public static extern void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(IntPtr jarg1, bool jarg2); // 0x0000000186494780-0x0000000186494800
	public static extern bool CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(IntPtr jarg1); // 0x0000000186494748-0x0000000186494780
	public static extern void CSharp_AkPositioningInfo_e3DSpatializationMode_set(IntPtr jarg1, int jarg2); // 0x00000001864948B0-0x00000001864948F0
	public static extern int CSharp_AkPositioningInfo_e3DSpatializationMode_get(IntPtr jarg1); // 0x000000018649487C-0x00000001864948B0
	public static extern void CSharp_AkPositioningInfo_bEnableAttenuation_set(IntPtr jarg1, bool jarg2); // 0x0000000186494704-0x0000000186494748
	public static extern bool CSharp_AkPositioningInfo_bEnableAttenuation_get(IntPtr jarg1); // 0x00000001864946CC-0x0000000186494704
	public static extern void CSharp_AkPositioningInfo_bUseConeAttenuation_set(IntPtr jarg1, bool jarg2); // 0x0000000186494838-0x000000018649487C
	public static extern bool CSharp_AkPositioningInfo_bUseConeAttenuation_get(IntPtr jarg1); // 0x0000000186494800-0x0000000186494838
	public static extern void CSharp_AkPositioningInfo_fInnerAngle_set(IntPtr jarg1, float jarg2); // 0x0000000186494A88-0x0000000186494ACC
	public static extern float CSharp_AkPositioningInfo_fInnerAngle_get(IntPtr jarg1); // 0x0000000186494A54-0x0000000186494A88
	public static extern void CSharp_AkPositioningInfo_fOuterAngle_set(IntPtr jarg1, float jarg2); // 0x0000000186494B70-0x0000000186494BB4
	public static extern float CSharp_AkPositioningInfo_fOuterAngle_get(IntPtr jarg1); // 0x0000000186494B3C-0x0000000186494B70
	public static extern void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(IntPtr jarg1, float jarg2); // 0x0000000186494A10-0x0000000186494A54
	public static extern float CSharp_AkPositioningInfo_fConeMaxAttenuation_get(IntPtr jarg1); // 0x00000001864949DC-0x0000000186494A10
	public static extern void CSharp_AkPositioningInfo_LPFCone_set(IntPtr jarg1, float jarg2); // 0x0000000186494610-0x0000000186494654
	public static extern float CSharp_AkPositioningInfo_LPFCone_get(IntPtr jarg1); // 0x00000001864945DC-0x0000000186494610
	public static extern void CSharp_AkPositioningInfo_HPFCone_set(IntPtr jarg1, float jarg2); // 0x0000000186494520-0x0000000186494564
	public static extern float CSharp_AkPositioningInfo_HPFCone_get(IntPtr jarg1); // 0x00000001864944F4-0x0000000186494520
	public static extern void CSharp_AkPositioningInfo_fMaxDistance_set(IntPtr jarg1, float jarg2); // 0x0000000186494B00-0x0000000186494B3C
	public static extern float CSharp_AkPositioningInfo_fMaxDistance_get(IntPtr jarg1); // 0x0000000186494ACC-0x0000000186494B00
	public static extern void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x0000000186494CD8-0x0000000186494D14
	public static extern float CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(IntPtr jarg1); // 0x0000000186494CA4-0x0000000186494CD8
	public static extern void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x0000000186494BE8-0x0000000186494C2C
	public static extern float CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(IntPtr jarg1); // 0x0000000186494BB4-0x0000000186494BE8
	public static extern void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x0000000186494C60-0x0000000186494CA4
	public static extern float CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(IntPtr jarg1); // 0x0000000186494C2C-0x0000000186494C60
	public static extern void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x0000000186494688-0x00000001864946CC
	public static extern float CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(IntPtr jarg1); // 0x0000000186494654-0x0000000186494688
	public static extern void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x0000000186494598-0x00000001864945DC
	public static extern float CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(IntPtr jarg1); // 0x0000000186494564-0x0000000186494598
	public static extern IntPtr CSharp_new_AkPositioningInfo(); // 0x00000001864A3780-0x00000001864A37E8
	public static extern void CSharp_delete_AkPositioningInfo(IntPtr jarg1); // 0x00000001864A241C-0x00000001864A2450
	public static extern void CSharp_AkObjectInfo_objID_set(IntPtr jarg1, uint jarg2); // 0x0000000186492C14-0x0000000186492C54
	public static extern uint CSharp_AkObjectInfo_objID_get(IntPtr jarg1); // 0x0000000186492BE0-0x0000000186492C14
	public static extern void CSharp_AkObjectInfo_parentID_set(IntPtr jarg1, uint jarg2); // 0x0000000186492C88-0x0000000186492CC8
	public static extern uint CSharp_AkObjectInfo_parentID_get(IntPtr jarg1); // 0x0000000186492C54-0x0000000186492C88
	public static extern void CSharp_AkObjectInfo_iDepth_set(IntPtr jarg1, int jarg2); // 0x0000000186492BA0-0x0000000186492BE0
	public static extern int CSharp_AkObjectInfo_iDepth_get(IntPtr jarg1); // 0x0000000186492B6C-0x0000000186492BA0
	public static extern void CSharp_AkObjectInfo_Clear(IntPtr jarg1); // 0x0000000186492AC8-0x0000000186492AFC
	public static extern int CSharp_AkObjectInfo_GetSizeOf(); // 0x0000000186492B40-0x0000000186492B6C
	public static extern void CSharp_AkObjectInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000186492AFC-0x0000000186492B40
	public static extern IntPtr CSharp_new_AkObjectInfo(); // 0x00000001864A3378-0x00000001864A33A4
	public static extern void CSharp_delete_AkObjectInfo(IntPtr jarg1); // 0x00000001864A227C-0x00000001864A22B0
	public static extern int CSharp_GetPosition(ulong jarg1, IntPtr jarg2); // 0x00000001864993B0-0x0000000186499434
	public static extern int CSharp_GetListenerPosition(ulong jarg1, IntPtr jarg2); // 0x0000000186498CF4-0x0000000186498D78
	public static extern int CSharp_GetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5); // 0x00000001864994B4-0x0000000186499554
	public static extern int CSharp_GetRTPCValue__SWIG_1(string jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5); // 0x0000000186499554-0x0000000186499600
	public static extern int CSharp_GetSwitch__SWIG_0(uint jarg1, ulong jarg2, out uint jarg3); // 0x0000000186499F14-0x0000000186499FA4
	public static extern int CSharp_GetSwitch__SWIG_1(string jarg1, ulong jarg2, out uint jarg3); // 0x0000000186499FA4-0x000000018649A040
	public static extern int CSharp_GetState__SWIG_0(uint jarg1, out uint jarg2); // 0x0000000186499DA0-0x0000000186499E20
	public static extern int CSharp_GetState__SWIG_1(string jarg1, out uint jarg2); // 0x0000000186499E20-0x0000000186499EAC
	public static extern int CSharp_GetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, ref uint jarg3); // 0x0000000186498A90-0x0000000186498B20
	public static extern int CSharp_GetGameObjectDryLevelValue(ulong jarg1, ulong jarg2, out float jarg3); // 0x0000000186498B20-0x0000000186498BB0
	public static extern int CSharp_GetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, out float jarg3, out float jarg4); // 0x0000000186498E48-0x0000000186498EE8
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_0(uint jarg1, ref uint jarg2, IntPtr jarg3); // 0x000000018649CD60-0x000000018649CDF0
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_1(string jarg1, ref uint jarg2, IntPtr jarg3); // 0x000000018649CDF0-0x000000018649CE8C
	public static extern int CSharp_GetPositioningInfo(uint jarg1, IntPtr jarg2); // 0x0000000186499434-0x00000001864994B4
	public static extern bool CSharp_GetIsGameObjectActive(ulong jarg1); // 0x0000000186498CBC-0x0000000186498CF4
	public static extern float CSharp_GetMaxRadius(ulong jarg1); // 0x0000000186498E1C-0x0000000186498E48
	public static extern uint CSharp_GetEventIDFromPlayingID(uint jarg1); // 0x0000000185774100-0x0000000185774130
	public static extern ulong CSharp_GetGameObjectFromPlayingID(uint jarg1); // 0x0000000186498BB0-0x0000000186498C28
	public static extern int CSharp_GetPlayingIDsFromGameObject(ulong jarg1, ref uint jarg2, out uint[] jarg3); // 0x0000000186499194-0x00000001864992A0
	public static extern int CSharp_GetCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3); // 0x0000000186498644-0x00000001864986D0
	public static extern int CSharp_GetCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3); // 0x00000001864986D0-0x000000018649875C
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint jarg1); // 0x000000018648B894-0x000000018648B90C
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint jarg1); // 0x000000018648B90C-0x000000018648B984
	public static extern void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint jarg1); // 0x000000018648B81C-0x000000018648B894
	public static extern byte CSharp_ChannelMaskToNumChannels(uint jarg1); // 0x0000000186496FA0-0x0000000186497018
	public static extern uint CSharp_ChannelMaskFromNumChannels(uint jarg1); // 0x0000000186496F6C-0x0000000186496FA0
	public static extern byte CSharp_ChannelBitToIndex(uint jarg1, uint jarg2); // 0x0000000186496EEC-0x0000000186496F6C
	public static extern bool CSharp_HasSurroundChannels(uint jarg1); // 0x000000018649A308-0x000000018649A340
	public static extern bool CSharp_HasStrictlyOnePairOfSurroundChannels(uint jarg1); // 0x000000018649A290-0x000000018649A308
	public static extern bool CSharp_HasSideAndRearChannels(uint jarg1); // 0x000000018649A258-0x000000018649A290
	public static extern bool CSharp_HasHeightChannels(uint jarg1); // 0x000000018649A220-0x000000018649A258
	public static extern uint CSharp_BackToSideChannels(uint jarg1); // 0x0000000186496DA4-0x0000000186496E1C
	public static extern uint CSharp_StdChannelIndexToDisplayIndex(int jarg1, uint jarg2, uint jarg3); // 0x00000001864A0B74-0x00000001864A0C00
	public static extern void CSharp_AkChannelConfig_uNumChannels_set(IntPtr jarg1, uint jarg2); // 0x000000018648D6F4-0x000000018648D734
	public static extern uint CSharp_AkChannelConfig_uNumChannels_get(IntPtr jarg1); // 0x0000000184A84CB0-0x0000000184A84CF0
	public static extern void CSharp_AkChannelConfig_eConfigType_set(IntPtr jarg1, uint jarg2); // 0x000000018648D634-0x000000018648D6B4
	public static extern uint CSharp_AkChannelConfig_eConfigType_get(IntPtr jarg1); // 0x0000000184A84C20-0x0000000184A84C60
	public static extern void CSharp_AkChannelConfig_uChannelMask_set(IntPtr jarg1, uint jarg2); // 0x000000018648D6B4-0x000000018648D6F4
	public static extern uint CSharp_AkChannelConfig_uChannelMask_get(IntPtr jarg1); // 0x0000000184A84B90-0x0000000184A84BD0
	public static extern IntPtr CSharp_AkChannelConfig_Standard(uint jarg1); // 0x000000018648D600-0x000000018648D634
	public static extern IntPtr CSharp_AkChannelConfig_Anonymous(uint jarg1); // 0x000000018648D268-0x000000018648D2E0
	public static extern IntPtr CSharp_AkChannelConfig_Ambisonic(uint jarg1); // 0x000000018648D234-0x000000018648D268
	public static extern IntPtr CSharp_AkChannelConfig_Object(); // 0x000000018648D38C-0x000000018648D3B8
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_0(); // 0x00000001864A2B10-0x00000001864A2B3C
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_1(uint jarg1, uint jarg2); // 0x00000001864A2B3C-0x00000001864A2BBC
	public static extern void CSharp_AkChannelConfig_Clear(IntPtr jarg1); // 0x000000018648D2E0-0x000000018648D314
	public static extern void CSharp_AkChannelConfig_SetStandard(IntPtr jarg1, uint jarg2); // 0x000000018648D5C0-0x000000018648D600
	public static extern void CSharp_AkChannelConfig_SetStandardOrAnonymous(IntPtr jarg1, uint jarg2, uint jarg3); // 0x000000018648D530-0x000000018648D5C0
	public static extern void CSharp_AkChannelConfig_SetAnonymous(IntPtr jarg1, uint jarg2); // 0x00000001856B5DA0-0x00000001856B5DE0
	public static extern void CSharp_AkChannelConfig_SetAmbisonic(IntPtr jarg1, uint jarg2); // 0x000000018648D454-0x000000018648D494
	public static extern void CSharp_AkChannelConfig_SetObject(IntPtr jarg1); // 0x000000018648D494-0x000000018648D4C8
	public static extern void CSharp_AkChannelConfig_SetSameAsMainMix(IntPtr jarg1); // 0x000000018648D4C8-0x000000018648D4FC
	public static extern void CSharp_AkChannelConfig_SetSameAsPassthrough(IntPtr jarg1); // 0x000000018648D4FC-0x000000018648D530
	public static extern bool CSharp_AkChannelConfig_IsValid(IntPtr jarg1); // 0x000000018648D354-0x000000018648D38C
	public static extern uint CSharp_AkChannelConfig_Serialize(IntPtr jarg1); // 0x000000018648D420-0x000000018648D454
	public static extern void CSharp_AkChannelConfig_Deserialize(IntPtr jarg1, uint jarg2); // 0x000000018648D314-0x000000018648D354
	public static extern IntPtr CSharp_AkChannelConfig_RemoveLFE(IntPtr jarg1); // 0x000000018648D3EC-0x000000018648D420
	public static extern IntPtr CSharp_AkChannelConfig_RemoveCenter(IntPtr jarg1); // 0x000000018648D3B8-0x000000018648D3EC
	public static extern void CSharp_delete_AkChannelConfig(IntPtr jarg1); // 0x000000018596D250-0x000000018596D290
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_0(); // 0x00000001864A2F64-0x00000001864A2F90
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3); // 0x00000001864A2F90-0x00000001864A2FF4
	public static extern void CSharp_AkImageSourceParams_sourcePosition_set(IntPtr jarg1, AkVector64 jarg2); // 0x000000018648F4C0-0x000000018648F55C
	public static extern AkVector64 CSharp_AkImageSourceParams_sourcePosition_get(IntPtr jarg1); // 0x000000018648F428-0x000000018648F4C0
	public static extern void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(IntPtr jarg1, float jarg2); // 0x000000018648F2F4-0x000000018648F338
	public static extern float CSharp_AkImageSourceParams_fDistanceScalingFactor_get(IntPtr jarg1); // 0x000000018648F2C0-0x000000018648F2F4
	public static extern void CSharp_AkImageSourceParams_fLevel_set(IntPtr jarg1, float jarg2); // 0x000000018648F36C-0x000000018648F3B0
	public static extern float CSharp_AkImageSourceParams_fLevel_get(IntPtr jarg1); // 0x000000018648F338-0x000000018648F36C
	public static extern void CSharp_AkImageSourceParams_fDiffraction_set(IntPtr jarg1, float jarg2); // 0x000000018648F27C-0x000000018648F2C0
	public static extern float CSharp_AkImageSourceParams_fDiffraction_get(IntPtr jarg1); // 0x000000018648F248-0x000000018648F27C
	public static extern void CSharp_AkImageSourceParams_fOcclusion_set(IntPtr jarg1, float jarg2); // 0x000000018648F3E4-0x000000018648F428
	public static extern float CSharp_AkImageSourceParams_fOcclusion_get(IntPtr jarg1); // 0x000000018648F3B0-0x000000018648F3E4
	public static extern void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(IntPtr jarg1, byte jarg2); // 0x000000018648F5D4-0x000000018648F614
	public static extern byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(IntPtr jarg1); // 0x000000018648F55C-0x000000018648F5D4
	public static extern void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(IntPtr jarg1, byte jarg2); // 0x000000018648F648-0x000000018648F688
	public static extern byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(IntPtr jarg1); // 0x000000018648F614-0x000000018648F648
	public static extern void CSharp_delete_AkImageSourceParams(IntPtr jarg1); // 0x00000001864A1E04-0x00000001864A1E38
	public static extern uint CSharp_kDefaultDiffractionMaxEdges_get(); // 0x00000001864A27C4-0x00000001864A27F0
	public static extern uint CSharp_kDefaultDiffractionMaxPaths_get(); // 0x00000001864A27F0-0x00000001864A281C
	public static extern float CSharp_kMaxDiffraction_get(); // 0x00000001864A28DC-0x00000001864A2900
	public static extern uint CSharp_kHashListBlockAllocItemCount_get(); // 0x00000001864A2874-0x00000001864A28DC
	public static extern uint CSharp_kDiffractionMaxEdges_get(); // 0x00000001864A281C-0x00000001864A2848
	public static extern uint CSharp_kDiffractionMaxPaths_get(); // 0x00000001864A2848-0x00000001864A2874
	public static extern uint CSharp_kPortalToPortalDiffractionMaxPaths_get(); // 0x00000001864A2900-0x00000001864A292C
	public static extern IntPtr CSharp_new_AkSpatialAudioInitSettings(); // 0x00000001855000F0-0x0000000185500120
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(IntPtr jarg1, uint jarg2); // 0x0000000185500A20-0x0000000185500A60
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(IntPtr jarg1); // 0x0000000186496080-0x00000001864960B4
	public static extern void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(IntPtr jarg1, float jarg2); // 0x0000000185500970-0x00000001855009C0
	public static extern float CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(IntPtr jarg1); // 0x0000000186495FE4-0x0000000186496018
	public static extern void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(IntPtr jarg1, uint jarg2); // 0x00000001855008D0-0x0000000185500910
	public static extern uint CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(IntPtr jarg1); // 0x00000001854FF420-0x00000001854FF460
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000185500830-0x0000000185500870
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(IntPtr jarg1); // 0x0000000185500EA0-0x0000000185500EE0
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000185500790-0x00000001855007D0
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(IntPtr jarg1); // 0x0000000185500E10-0x0000000185500E50
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(IntPtr jarg1, uint jarg2); // 0x00000001855006F0-0x0000000185500730
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(IntPtr jarg1); // 0x000000018649604C-0x0000000186496080
	public static extern void CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000185500650-0x0000000185500690
	public static extern uint CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(IntPtr jarg1); // 0x0000000186496018-0x000000018649604C
	public static extern void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(IntPtr jarg1, float jarg2); // 0x00000001855005A0-0x00000001855005F0
	public static extern float CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(IntPtr jarg1); // 0x0000000186495FB0-0x0000000186495FE4
	public static extern void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(IntPtr jarg1, float jarg2); // 0x00000001855004F0-0x0000000185500540
	public static extern float CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(IntPtr jarg1); // 0x0000000186495F7C-0x0000000186495FB0
	public static extern void CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(IntPtr jarg1, uint jarg2); // 0x0000000185500450-0x0000000185500490
	public static extern uint CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(IntPtr jarg1); // 0x0000000185500D80-0x0000000185500DC0
	public static extern void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(IntPtr jarg1, bool jarg2); // 0x00000001855003A0-0x00000001855003F0
	public static extern bool CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(IntPtr jarg1); // 0x0000000186495F44-0x0000000186495F7C
	public static extern void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(IntPtr jarg1, bool jarg2); // 0x00000001855002F0-0x0000000185500340
	public static extern bool CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(IntPtr jarg1); // 0x0000000186495F0C-0x0000000186495F44
	public static extern void CSharp_delete_AkSpatialAudioInitSettings(IntPtr jarg1); // 0x0000000185A17C20-0x0000000185A17C60
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_0(); // 0x00000001864A2FF4-0x00000001864A3020
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3); // 0x00000001864A3020-0x00000001864A3084
	public static extern void CSharp_AkImageSourceSettings_SetOneTexture(IntPtr jarg1, uint jarg2); // 0x000000018648F688-0x000000018648F6C8
	public static extern void CSharp_AkImageSourceSettings_params__set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648F6FC-0x000000018648F740
	public static extern IntPtr CSharp_AkImageSourceSettings_params__get(IntPtr jarg1); // 0x000000018648F6C8-0x000000018648F6FC
	public static extern void CSharp_delete_AkImageSourceSettings(IntPtr jarg1); // 0x00000001864A1E38-0x00000001864A1E6C
	public static extern IntPtr CSharp_new_AkExtent__SWIG_0(); // 0x00000001864A2CC4-0x00000001864A2CF0
	public static extern IntPtr CSharp_new_AkExtent__SWIG_1(float jarg1, float jarg2, float jarg3); // 0x00000001864A2CF0-0x00000001864A2D48
	public static extern void CSharp_AkExtent_halfWidth_set(IntPtr jarg1, float jarg2); // 0x000000018648ECEC-0x000000018648ED30
	public static extern float CSharp_AkExtent_halfWidth_get(IntPtr jarg1); // 0x000000018648ECB8-0x000000018648ECEC
	public static extern void CSharp_AkExtent_halfHeight_set(IntPtr jarg1, float jarg2); // 0x000000018648EC74-0x000000018648ECB8
	public static extern float CSharp_AkExtent_halfHeight_get(IntPtr jarg1); // 0x000000018648EC40-0x000000018648EC74
	public static extern void CSharp_AkExtent_halfDepth_set(IntPtr jarg1, float jarg2); // 0x000000018648EBFC-0x000000018648EC40
	public static extern float CSharp_AkExtent_halfDepth_get(IntPtr jarg1); // 0x000000018648EBC8-0x000000018648EBFC
	public static extern void CSharp_delete_AkExtent(IntPtr jarg1); // 0x00000001864A1D68-0x00000001864A1D9C
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_0(); // 0x00000001864A3994-0x00000001864A39C0
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_1(ushort jarg1, ushort jarg2, ushort jarg3, ushort jarg4); // 0x00000001864A39C0-0x00000001864A3A64
	public static extern void CSharp_AkTriangle_point0_set(IntPtr jarg1, ushort jarg2); // 0x0000000184125E60-0x0000000184125EB0
	public static extern ushort CSharp_AkTriangle_point0_get(IntPtr jarg1); // 0x00000001864966BC-0x0000000186496734
	public static extern void CSharp_AkTriangle_point1_set(IntPtr jarg1, ushort jarg2); // 0x0000000184125E10-0x0000000184125E60
	public static extern ushort CSharp_AkTriangle_point1_get(IntPtr jarg1); // 0x0000000186496734-0x0000000186496768
	public static extern void CSharp_AkTriangle_point2_set(IntPtr jarg1, ushort jarg2); // 0x0000000184125D80-0x0000000184125DC0
	public static extern ushort CSharp_AkTriangle_point2_get(IntPtr jarg1); // 0x0000000186496768-0x00000001864967E0
	public static extern void CSharp_AkTriangle_surface_set(IntPtr jarg1, ushort jarg2); // 0x0000000184125DC0-0x0000000184125E10
	public static extern ushort CSharp_AkTriangle_surface_get(IntPtr jarg1); // 0x00000001864967E0-0x0000000186496858
	public static extern void CSharp_AkTriangle_Clear(IntPtr jarg1); // 0x00000001841238D0-0x0000000184123910
	public static extern int CSharp_AkTriangle_GetSizeOf(); // 0x0000000184123940-0x0000000184123970
	public static extern void CSharp_AkTriangle_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000186496678-0x00000001864966BC
	public static extern void CSharp_delete_AkTriangle(IntPtr jarg1); // 0x00000001864A268C-0x00000001864A26C0
	public static extern IntPtr CSharp_new_AkAcousticSurface(); // 0x00000001864A2984-0x00000001864A29B0
	public static extern void CSharp_AkAcousticSurface_textureID_set(IntPtr jarg1, uint jarg2); // 0x0000000184123CA0-0x0000000184123CF0
	public static extern uint CSharp_AkAcousticSurface_textureID_get(IntPtr jarg1); // 0x000000018648C2DC-0x000000018648C310
	public static extern void CSharp_AkAcousticSurface_transmissionLoss_set(IntPtr jarg1, float jarg2); // 0x0000000184123C50-0x0000000184123CA0
	public static extern float CSharp_AkAcousticSurface_transmissionLoss_get(IntPtr jarg1); // 0x000000018648C310-0x000000018648C344
	public static extern void CSharp_AkAcousticSurface_strName_set(IntPtr jarg1, string jarg2); // 0x000000018648C248-0x000000018648C2DC
	public static extern IntPtr CSharp_AkAcousticSurface_strName_get(IntPtr jarg1); // 0x000000018648C214-0x000000018648C248
	public static extern void CSharp_AkAcousticSurface_Clear(IntPtr jarg1); // 0x0000000184123770-0x00000001841237B0
	public static extern void CSharp_AkAcousticSurface_DeleteName(IntPtr jarg1); // 0x000000018648C1E0-0x000000018648C214
	public static extern int CSharp_AkAcousticSurface_GetSizeOf(); // 0x0000000184123910-0x0000000184123940
	public static extern void CSharp_AkAcousticSurface_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018648C19C-0x000000018648C1E0
	public static extern void CSharp_delete_AkAcousticSurface(IntPtr jarg1); // 0x00000001864A197C-0x00000001864A19B0
	public static extern void CSharp_AkReflectionPathInfo_imageSource_set(IntPtr jarg1, AkVector64 jarg2); // 0x00000001864950D8-0x0000000186495174
	public static extern AkVector64 CSharp_AkReflectionPathInfo_imageSource_get(IntPtr jarg1); // 0x0000000186495040-0x00000001864950D8
	public static extern void CSharp_AkReflectionPathInfo_numPathPoints_set(IntPtr jarg1, uint jarg2); // 0x00000001864952DC-0x000000018649531C
	public static extern uint CSharp_AkReflectionPathInfo_numPathPoints_get(IntPtr jarg1); // 0x00000001864952A8-0x00000001864952DC
	public static extern void CSharp_AkReflectionPathInfo_numReflections_set(IntPtr jarg1, uint jarg2); // 0x0000000186495350-0x0000000186495390
	public static extern uint CSharp_AkReflectionPathInfo_numReflections_get(IntPtr jarg1); // 0x000000018649531C-0x0000000186495350
	public static extern void CSharp_AkReflectionPathInfo_level_set(IntPtr jarg1, float jarg2); // 0x0000000186495264-0x00000001864952A8
	public static extern float CSharp_AkReflectionPathInfo_level_get(IntPtr jarg1); // 0x0000000186495230-0x0000000186495264
	public static extern void CSharp_AkReflectionPathInfo_isOccluded_set(IntPtr jarg1, bool jarg2); // 0x00000001864951EC-0x0000000186495230
	public static extern bool CSharp_AkReflectionPathInfo_isOccluded_get(IntPtr jarg1); // 0x0000000186495174-0x00000001864951EC
	public static extern int CSharp_AkReflectionPathInfo_GetSizeOf(); // 0x0000000186495014-0x0000000186495040
	public static extern Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(IntPtr jarg1, uint jarg2); // 0x0000000186494F70-0x0000000186495014
	public static extern IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(IntPtr jarg1, uint jarg2); // 0x0000000186494EB4-0x0000000186494F34
	public static extern float CSharp_AkReflectionPathInfo_GetDiffraction(IntPtr jarg1, uint jarg2); // 0x0000000186494F34-0x0000000186494F70
	public static extern void CSharp_AkReflectionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000186494E70-0x0000000186494EB4
	public static extern IntPtr CSharp_new_AkReflectionPathInfo(); // 0x00000001864A3860-0x00000001864A388C
	public static extern void CSharp_delete_AkReflectionPathInfo(IntPtr jarg1); // 0x00000001864A2484-0x00000001864A24B8
	public static extern void CSharp_AkDiffractionPathInfo_emitterPos_set(IntPtr jarg1, AkVector64 jarg2); // 0x000000018648E680-0x000000018648E71C
	public static extern AkVector64 CSharp_AkDiffractionPathInfo_emitterPos_get(IntPtr jarg1); // 0x000000018648E5E8-0x000000018648E680
	public static extern void CSharp_AkDiffractionPathInfo_virtualPos_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648E9A4-0x000000018648E9E8
	public static extern IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(IntPtr jarg1); // 0x000000018648E970-0x000000018648E9A4
	public static extern void CSharp_AkDiffractionPathInfo_nodeCount_set(IntPtr jarg1, uint jarg2); // 0x000000018648E750-0x000000018648E790
	public static extern uint CSharp_AkDiffractionPathInfo_nodeCount_get(IntPtr jarg1); // 0x000000018648E71C-0x000000018648E750
	public static extern void CSharp_AkDiffractionPathInfo_diffraction_set(IntPtr jarg1, float jarg2); // 0x000000018648E5AC-0x000000018648E5E8
	public static extern float CSharp_AkDiffractionPathInfo_diffraction_get(IntPtr jarg1); // 0x000000018648E578-0x000000018648E5AC
	public static extern void CSharp_AkDiffractionPathInfo_transmissionLoss_set(IntPtr jarg1, float jarg2); // 0x000000018648E92C-0x000000018648E970
	public static extern float CSharp_AkDiffractionPathInfo_transmissionLoss_get(IntPtr jarg1); // 0x000000018648E8F8-0x000000018648E92C
	public static extern void CSharp_AkDiffractionPathInfo_totLength_set(IntPtr jarg1, float jarg2); // 0x000000018648E8B4-0x000000018648E8F8
	public static extern float CSharp_AkDiffractionPathInfo_totLength_get(IntPtr jarg1); // 0x000000018648E880-0x000000018648E8B4
	public static extern void CSharp_AkDiffractionPathInfo_obstructionValue_set(IntPtr jarg1, float jarg2); // 0x000000018648E7C4-0x000000018648E808
	public static extern float CSharp_AkDiffractionPathInfo_obstructionValue_get(IntPtr jarg1); // 0x000000018648E790-0x000000018648E7C4
	public static extern void CSharp_AkDiffractionPathInfo_occlusionValue_set(IntPtr jarg1, float jarg2); // 0x000000018648E83C-0x000000018648E880
	public static extern float CSharp_AkDiffractionPathInfo_occlusionValue_get(IntPtr jarg1); // 0x000000018648E808-0x000000018648E83C
	public static extern int CSharp_AkDiffractionPathInfo_GetSizeOf(); // 0x000000018648E54C-0x000000018648E578
	public static extern Vector3 CSharp_AkDiffractionPathInfo_GetNodes(IntPtr jarg1, uint jarg2); // 0x000000018648E3A8-0x000000018648E44C
	public static extern float CSharp_AkDiffractionPathInfo_GetAngles(IntPtr jarg1, uint jarg2); // 0x000000018648E36C-0x000000018648E3A8
	public static extern ulong CSharp_AkDiffractionPathInfo_GetPortals(IntPtr jarg1, uint jarg2); // 0x000000018648E44C-0x000000018648E4CC
	public static extern ulong CSharp_AkDiffractionPathInfo_GetRooms(IntPtr jarg1, uint jarg2); // 0x000000018648E4CC-0x000000018648E54C
	public static extern void CSharp_AkDiffractionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018648E328-0x000000018648E36C
	public static extern IntPtr CSharp_new_AkDiffractionPathInfo(); // 0x00000001864A2C14-0x00000001864A2C40
	public static extern void CSharp_delete_AkDiffractionPathInfo(IntPtr jarg1); // 0x00000001864A1C98-0x00000001864A1CCC
	public static extern IntPtr CSharp_new_AkRoomParams(); // 0x0000000185D21D80-0x0000000185D21DB0
	public static extern void CSharp_AkRoomParams_Front_set(IntPtr jarg1, Vector3 jarg2); // 0x0000000184B688B0-0x0000000184B68900
	public static extern Vector3 CSharp_AkRoomParams_Front_get(IntPtr jarg1); // 0x0000000186495648-0x00000001864956DC
	public static extern void CSharp_AkRoomParams_Up_set(IntPtr jarg1, Vector3 jarg2); // 0x0000000184B687D0-0x0000000184B68820
	public static extern Vector3 CSharp_AkRoomParams_Up_get(IntPtr jarg1); // 0x0000000186495810-0x00000001864958A4
	public static extern void CSharp_AkRoomParams_ReverbAuxBus_set(IntPtr jarg1, uint jarg2); // 0x0000000184B68400-0x0000000184B68450
	public static extern uint CSharp_AkRoomParams_ReverbAuxBus_get(IntPtr jarg1); // 0x00000001864956DC-0x0000000186495710
	public static extern void CSharp_AkRoomParams_ReverbLevel_set(IntPtr jarg1, float jarg2); // 0x0000000184B686F0-0x0000000184B68740
	public static extern float CSharp_AkRoomParams_ReverbLevel_get(IntPtr jarg1); // 0x0000000186495710-0x0000000186495744
	public static extern void CSharp_AkRoomParams_TransmissionLoss_set(IntPtr jarg1, float jarg2); // 0x0000000184B68630-0x0000000184B68680
	public static extern float CSharp_AkRoomParams_TransmissionLoss_get(IntPtr jarg1); // 0x00000001864957DC-0x0000000186495810
	public static extern void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(IntPtr jarg1, float jarg2); // 0x0000000184B68570-0x0000000184B685C0
	public static extern float CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(IntPtr jarg1); // 0x0000000186495744-0x0000000186495770
	public static extern void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(IntPtr jarg1, bool jarg2); // 0x0000000184B684C0-0x0000000184B68500
	public static extern bool CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(IntPtr jarg1); // 0x0000000186495770-0x00000001864957A8
	public static extern void CSharp_AkRoomParams_RoomPriority_set(IntPtr jarg1, uint jarg2); // 0x0000000184B68350-0x0000000184B683A0
	public static extern uint CSharp_AkRoomParams_RoomPriority_get(IntPtr jarg1); // 0x00000001864957A8-0x00000001864957DC
	public static extern void CSharp_delete_AkRoomParams(IntPtr jarg1); // 0x00000001864A24EC-0x00000001864A2520
	public static extern IntPtr CSharp_new_AkGeometryInstanceParams(); // 0x00000001864A2F38-0x00000001864A2F64
	public static extern void CSharp_AkGeometryInstanceParams_PositionAndOrientation_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648EFAC-0x000000018648EFF0
	public static extern IntPtr CSharp_AkGeometryInstanceParams_PositionAndOrientation_get(IntPtr jarg1); // 0x000000018648EF70-0x000000018648EFAC
	public static extern void CSharp_AkGeometryInstanceParams_Scale_set(IntPtr jarg1, Vector3 jarg2); // 0x000000018648F084-0x000000018648F11C
	public static extern Vector3 CSharp_AkGeometryInstanceParams_Scale_get(IntPtr jarg1); // 0x000000018648EFF0-0x000000018648F084
	public static extern void CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_set(IntPtr jarg1, bool jarg2); // 0x000000018648F194-0x000000018648F214
	public static extern bool CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_get(IntPtr jarg1); // 0x000000018648F11C-0x000000018648F194
	public static extern void CSharp_delete_AkGeometryInstanceParams(IntPtr jarg1); // 0x00000001864A1DD0-0x00000001864A1E04
	public static extern int CSharp_SetGameObjectRadius(ulong jarg1, float jarg2, float jarg3); // 0x000000018649F190-0x000000018649F1DC
	public static extern int CSharp_SetImageSource__SWIG_0(uint jarg1, IntPtr jarg2, string jarg3, uint jarg4, ulong jarg5); // 0x000000018649F228-0x000000018649F2F0
	public static extern int CSharp_SetImageSource__SWIG_1(uint jarg1, IntPtr jarg2, string jarg3, uint jarg4); // 0x000000018649F2F0-0x000000018649F3AC
	public static extern int CSharp_SetImageSource__SWIG_2(uint jarg1, IntPtr jarg2, string jarg3); // 0x000000018649F3AC-0x000000018649F460
	public static extern int CSharp_RemoveImageSource__SWIG_0(uint jarg1, uint jarg2, ulong jarg3); // 0x000000018649D15C-0x000000018649D1E8
	public static extern int CSharp_RemoveImageSource__SWIG_1(uint jarg1, uint jarg2); // 0x000000018649D1E8-0x000000018649D264
	public static extern int CSharp_RemoveImageSource__SWIG_2(uint jarg1); // 0x000000018649D264-0x000000018649D2DC
	public static extern int CSharp_ClearImageSources__SWIG_0(uint jarg1, ulong jarg2); // 0x00000001864970AC-0x000000018649712C
	public static extern int CSharp_ClearImageSources__SWIG_1(uint jarg1); // 0x000000018649712C-0x0000000186497160
	public static extern int CSharp_ClearImageSources__SWIG_2(); // 0x0000000186497160-0x0000000186497194
	public static extern int CSharp_RemoveGeometry(ulong jarg1); // 0x0000000184B69840-0x0000000184B69870
	public static extern int CSharp_RemoveGeometryInstance(ulong jarg1); // 0x0000000184B67C80-0x0000000184B67CC0
	public static extern int CSharp_RemoveRoom(ulong jarg1); // 0x0000000184B67BA0-0x0000000184B67C30
	public static extern int CSharp_RemovePortal(ulong jarg1); // 0x000000018649D3D8-0x000000018649D40C
	public static extern int CSharp_SetReverbZone(ulong jarg1, ulong jarg2, float jarg3); // 0x0000000184B68B50-0x0000000184B68BA0
	public static extern int CSharp_RemoveReverbZone(ulong jarg1); // 0x000000018649D40C-0x000000018649D440
	public static extern int CSharp_SetGameObjectInRoom(ulong jarg1, ulong jarg2); // 0x000000018649F0C0-0x000000018649F144
	public static extern int CSharp_UnsetGameObjectInRoom(ulong jarg1); // 0x00000001864A1744-0x00000001864A1778
	public static extern int CSharp_SetReflectionsOrder(uint jarg1, bool jarg2); // 0x00000001854FF0B0-0x00000001854FF140
	public static extern int CSharp_SetDiffractionOrder(uint jarg1, bool jarg2); // 0x00000001854FF140-0x00000001854FF1D0
	public static extern int CSharp_SetMaxEmitterRoomAuxSends(uint jarg1); // 0x000000018649F6B4-0x000000018649F6E8
	public static extern int CSharp_SetNumberOfPrimaryRays(uint jarg1); // 0x0000000185500EE0-0x0000000185500F60
	public static extern int CSharp_SetLoadBalancingSpread(uint jarg1); // 0x0000000185500CA0-0x0000000185500CE0
	public static extern int CSharp_SetEarlyReflectionsAuxSend(ulong jarg1, uint jarg2); // 0x000000018649EECC-0x000000018649EF4C
	public static extern int CSharp_SetEarlyReflectionsVolume(ulong jarg1, float jarg2); // 0x000000018649EF4C-0x000000018649EF88
	public static extern int CSharp_SetPortalObstructionAndOcclusion(ulong jarg1, float jarg2, float jarg3); // 0x000000018649FF6C-0x000000018649FFB8
	public static extern int CSharp_SetGameObjectToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3); // 0x000000018649F1DC-0x000000018649F228
	public static extern int CSharp_SetPortalToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3); // 0x000000018649FFB8-0x00000001864A0004
	public static extern int CSharp_QueryWetDiffraction(ulong jarg1, out float jarg2); // 0x000000018649CFCC-0x000000018649D050
	public static extern int CSharp_ResetStochasticEngine(); // 0x000000018649E078-0x000000018649E0A4
	public static extern void CSharp_AkPlatformInitSettings_threadLEngine_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493160-0x00000001864931A4
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(IntPtr jarg1); // 0x000000018649312C-0x0000000186493160
	public static extern void CSharp_AkPlatformInitSettings_threadOutputMgr_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000186493250-0x00000001864932D4
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(IntPtr jarg1); // 0x000000018649321C-0x0000000186493250
	public static extern void CSharp_AkPlatformInitSettings_threadBankManager_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001864930E8-0x000000018649312C
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(IntPtr jarg1); // 0x00000001864930B4-0x00000001864930E8
	public static extern void CSharp_AkPlatformInitSettings_threadMonitor_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001864931D8-0x000000018649321C
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(IntPtr jarg1); // 0x00000001864931A4-0x00000001864931D8
	public static extern void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(IntPtr jarg1, ushort jarg2); // 0x0000000185501560-0x00000001855015B0
	public static extern ushort CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(IntPtr jarg1); // 0x0000000186493308-0x0000000186493380
	public static extern void CSharp_AkPlatformInitSettings_uSampleRate_set(IntPtr jarg1, uint jarg2); // 0x0000000185501610-0x0000000185501650
	public static extern uint CSharp_AkPlatformInitSettings_uSampleRate_get(IntPtr jarg1); // 0x0000000186493380-0x00000001864933F8
	public static extern void CSharp_AkPlatformInitSettings_bEnableAvxSupport_set(IntPtr jarg1, bool jarg2); // 0x0000000186492FB8-0x0000000186492FFC
	public static extern bool CSharp_AkPlatformInitSettings_bEnableAvxSupport_get(IntPtr jarg1); // 0x0000000186492F80-0x0000000186492FB8
	public static extern void CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x0000000185EE6280-0x0000000185EE62C0
	public static extern uint CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_get(IntPtr jarg1); // 0x00000001864932D4-0x0000000186493308
	public static extern void CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_set(IntPtr jarg1, bool jarg2); // 0x0000000186493034-0x00000001864930B4
	public static extern bool CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_get(IntPtr jarg1); // 0x0000000186492FFC-0x0000000186493034
	public static extern void CSharp_delete_AkPlatformInitSettings(IntPtr jarg1); // 0x00000001864A2318-0x00000001864A234C
	public static extern uint CSharp_GetDeviceIDFromName(string jarg1); // 0x0000000186498860-0x00000001864988DC
	public static extern IntPtr CSharp_GetWindowsDeviceName__SWIG_0(int jarg1, out uint jarg2, int jarg3); // 0x000000018649A110-0x000000018649A1A0
	public static extern IntPtr CSharp_GetWindowsDeviceName__SWIG_1(int jarg1, out uint jarg2); // 0x000000018649A1A0-0x000000018649A220
	public static extern uint CSharp_GetWindowsDeviceCount__SWIG_0(int jarg1); // 0x000000018649A06C-0x000000018649A0E4
	public static extern uint CSharp_GetWindowsDeviceCount__SWIG_1(); // 0x000000018649A0E4-0x000000018649A110
	public static extern void CSharp_delete_AkStreamMgrSettings(IntPtr jarg1); // 0x00000001864A25F0-0x00000001864A2624
	public static extern void CSharp_AkDeviceSettings_pIOMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648E0A8-0x000000018648E0EC
	public static extern IntPtr CSharp_AkDeviceSettings_pIOMemory_get(IntPtr jarg1); // 0x000000018648E074-0x000000018648E0A8
	public static extern void CSharp_AkDeviceSettings_uIOMemorySize_set(IntPtr jarg1, uint jarg2); // 0x00000001855014C0-0x0000000185501500
	public static extern uint CSharp_AkDeviceSettings_uIOMemorySize_get(IntPtr jarg1); // 0x000000018648E24C-0x000000018648E280
	public static extern void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(IntPtr jarg1, uint jarg2); // 0x000000018648E20C-0x000000018648E24C
	public static extern uint CSharp_AkDeviceSettings_uIOMemoryAlignment_get(IntPtr jarg1); // 0x000000018648E1D8-0x000000018648E20C
	public static extern void CSharp_AkDeviceSettings_ePoolAttributes_set(IntPtr jarg1, uint jarg2); // 0x000000018648E000-0x000000018648E040
	public static extern uint CSharp_AkDeviceSettings_ePoolAttributes_get(IntPtr jarg1); // 0x000000018648DFCC-0x000000018648E000
	public static extern void CSharp_AkDeviceSettings_uGranularity_set(IntPtr jarg1, uint jarg2); // 0x000000018648E198-0x000000018648E1D8
	public static extern uint CSharp_AkDeviceSettings_uGranularity_get(IntPtr jarg1); // 0x000000018648E164-0x000000018648E198
	public static extern void CSharp_AkDeviceSettings_threadProperties_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648E120-0x000000018648E164
	public static extern IntPtr CSharp_AkDeviceSettings_threadProperties_get(IntPtr jarg1); // 0x000000018648E0EC-0x000000018648E120
	public static extern void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(IntPtr jarg1, float jarg2); // 0x0000000185501410-0x0000000185501460
	public static extern float CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(IntPtr jarg1); // 0x000000018648E040-0x000000018648E074
	public static extern void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(IntPtr jarg1, uint jarg2); // 0x000000018648E2E8-0x000000018648E328
	public static extern uint CSharp_AkDeviceSettings_uMaxConcurrentIO_get(IntPtr jarg1); // 0x000000018648E2B4-0x000000018648E2E8
	public static extern void CSharp_AkDeviceSettings_bUseStreamCache_set(IntPtr jarg1, bool jarg2); // 0x0000000185501360-0x00000001855013B0
	public static extern bool CSharp_AkDeviceSettings_bUseStreamCache_get(IntPtr jarg1); // 0x000000018648DF94-0x000000018648DFCC
	public static extern void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(IntPtr jarg1, uint jarg2); // 0x00000001855012C0-0x0000000185501300
	public static extern uint CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(IntPtr jarg1); // 0x000000018648E280-0x000000018648E2B4
	public static extern void CSharp_delete_AkDeviceSettings(IntPtr jarg1); // 0x00000001864A1C64-0x00000001864A1C98
	public static extern void CSharp_AkThreadProperties_nPriority_set(IntPtr jarg1, int jarg2); // 0x000000018649618C-0x00000001864961CC
	public static extern int CSharp_AkThreadProperties_nPriority_get(IntPtr jarg1); // 0x0000000186496158-0x000000018649618C
	public static extern void CSharp_AkThreadProperties_dwAffinityMask_set(IntPtr jarg1, uint jarg2); // 0x0000000186496118-0x0000000186496158
	public static extern uint CSharp_AkThreadProperties_dwAffinityMask_get(IntPtr jarg1); // 0x00000001864960E4-0x0000000186496118
	public static extern void CSharp_AkThreadProperties_uStackSize_set(IntPtr jarg1, uint jarg2); // 0x0000000186496200-0x0000000186496240
	public static extern uint CSharp_AkThreadProperties_uStackSize_get(IntPtr jarg1); // 0x00000001864961CC-0x0000000186496200
	public static extern IntPtr CSharp_new_AkThreadProperties(); // 0x00000001864A3968-0x00000001864A3994
	public static extern void CSharp_delete_AkThreadProperties(IntPtr jarg1); // 0x00000001864A2624-0x00000001864A2658
	public static extern void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1); // 0x00000001844CEA00-0x00000001844CEA90
	public static extern void CSharp_SetErrorLogger__SWIG_1(); // 0x000000018649EF88-0x000000018649EFF0
	public static extern void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2); // 0x000000018649E9C8-0x000000018649EA60
	public static extern void CSharp_delete_AkUnityPlatformSpecificSettings(IntPtr jarg1); // 0x00000001864A26F4-0x00000001864A2728
	public static extern IntPtr CSharp_new_AkCommunicationSettings(); // 0x00000001864A2BBC-0x00000001864A2BE8
	public static extern void CSharp_AkCommunicationSettings_uPoolSize_set(IntPtr jarg1, uint jarg2); // 0x000000018648DD58-0x000000018648DD98
	public static extern uint CSharp_AkCommunicationSettings_uPoolSize_get(IntPtr jarg1); // 0x000000018648DCE0-0x000000018648DD58
	public static extern void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(IntPtr jarg1, ushort jarg2); // 0x000000018648DC5C-0x000000018648DCE0
	public static extern ushort CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(IntPtr jarg1); // 0x000000018648DBE4-0x000000018648DC5C
	public static extern void CSharp_AkCommunicationSettings_uCommandPort_set(IntPtr jarg1, ushort jarg2); // 0x000000018648DB60-0x000000018648DBE4
	public static extern ushort CSharp_AkCommunicationSettings_uCommandPort_get(IntPtr jarg1); // 0x000000018648DAE8-0x000000018648DB60
	public static extern void CSharp_AkCommunicationSettings_commSystem_set(IntPtr jarg1, int jarg2); // 0x000000018648D9A0-0x000000018648DA20
	public static extern int CSharp_AkCommunicationSettings_commSystem_get(IntPtr jarg1); // 0x000000018648D96C-0x000000018648D9A0
	public static extern void CSharp_AkCommunicationSettings_bInitSystemLib_set(IntPtr jarg1, bool jarg2); // 0x000000018648D928-0x000000018648D96C
	public static extern bool CSharp_AkCommunicationSettings_bInitSystemLib_get(IntPtr jarg1); // 0x000000018648D8F0-0x000000018648D928
	public static extern void CSharp_AkCommunicationSettings_szAppNetworkName_set(IntPtr jarg1, string jarg2); // 0x000000018648DA54-0x000000018648DAE8
	public static extern IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(IntPtr jarg1); // 0x000000018648DA20-0x000000018648DA54
	public static extern void CSharp_delete_AkCommunicationSettings(IntPtr jarg1); // 0x00000001864A1BFC-0x00000001864A1C30
	public static extern IntPtr CSharp_new_AkInitializationSettings(); // 0x0000000185501050-0x00000001855010C0
	public static extern void CSharp_delete_AkInitializationSettings(IntPtr jarg1); // 0x0000000185BA6150-0x0000000185BA6190
	public static extern void CSharp_AkInitializationSettings_streamMgrSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FDBC-0x000000018648FE00
	public static extern IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(IntPtr jarg1); // 0x0000000185500C10-0x0000000185500C50
	public static extern void CSharp_AkInitializationSettings_deviceSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FC6C-0x000000018648FCF0
	public static extern IntPtr CSharp_AkInitializationSettings_deviceSettings_get(IntPtr jarg1); // 0x00000001854FFFB0-0x00000001854FFFF0
	public static extern void CSharp_AkInitializationSettings_initSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FCF0-0x000000018648FD34
	public static extern IntPtr CSharp_AkInitializationSettings_initSettings_get(IntPtr jarg1); // 0x00000001854FFEE0-0x00000001854FFF20
	public static extern void CSharp_AkInitializationSettings_platformSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FD78-0x000000018648FDBC
	public static extern IntPtr CSharp_AkInitializationSettings_platformSettings_get(IntPtr jarg1); // 0x00000001854FFE10-0x00000001854FFE50
	public static extern void CSharp_AkInitializationSettings_musicSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FD34-0x000000018648FD78
	public static extern IntPtr CSharp_AkInitializationSettings_musicSettings_get(IntPtr jarg1); // 0x0000000185500B40-0x0000000185500B80
	public static extern void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648FE9C-0x000000018648FEE0
	public static extern IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(IntPtr jarg1); // 0x00000001854FFD40-0x00000001854FFD80
	public static extern void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(IntPtr jarg1, uint jarg2); // 0x00000001854FEF50-0x00000001854FEF90
	public static extern uint CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(IntPtr jarg1); // 0x000000018648FE00-0x000000018648FE34
	public static extern void CSharp_AkInitializationSettings_uMemDebugLevel_set(IntPtr jarg1, uint jarg2); // 0x0000000185501220-0x0000000185501260
	public static extern uint CSharp_AkInitializationSettings_uMemDebugLevel_get(IntPtr jarg1); // 0x000000018648FE34-0x000000018648FE68
	public static extern void CSharp_AkInitializationSettings_uMemSpanCount_set(IntPtr jarg1, uint jarg2); // 0x0000000185501180-0x00000001855011C0
	public static extern uint CSharp_AkInitializationSettings_uMemSpanCount_get(IntPtr jarg1); // 0x000000018648FE68-0x000000018648FE9C
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0(); // 0x00000001864A2D48-0x00000001864A2D74
	public static extern void CSharp_delete_AkExternalSourceInfo(IntPtr jarg1); // 0x00000001864A1D9C-0x00000001864A1DD0
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4); // 0x00000001864A2D74-0x00000001864A2E14
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(string jarg1, uint jarg2, uint jarg3); // 0x00000001864A2E14-0x00000001864A2EAC
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(uint jarg1, uint jarg2, uint jarg3); // 0x00000001864A2EAC-0x00000001864A2F38
	public static extern void CSharp_AkExternalSourceInfo_Clear(IntPtr jarg1); // 0x0000000185EE0490-0x0000000185EE04D0
	public static extern void CSharp_AkExternalSourceInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018648ED30-0x000000018648ED74
	public static extern int CSharp_AkExternalSourceInfo_GetSizeOf(); // 0x00000001858458A0-0x00000001858458D0
	public static extern void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(IntPtr jarg1, uint jarg2); // 0x0000000184BDD9A0-0x0000000184BDD9F0
	public static extern uint CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(IntPtr jarg1); // 0x000000018648ED74-0x000000018648EDA8
	public static extern void CSharp_AkExternalSourceInfo_idCodec_set(IntPtr jarg1, uint jarg2); // 0x0000000184BDDA50-0x0000000184BDE950
	public static extern uint CSharp_AkExternalSourceInfo_idCodec_get(IntPtr jarg1); // 0x000000018648EDA8-0x000000018648EDDC
	public static extern void CSharp_AkExternalSourceInfo_szFile_set(IntPtr jarg1, string jarg2); // 0x0000000184BDD8F0-0x0000000184BDD940
	public static extern IntPtr CSharp_AkExternalSourceInfo_szFile_get(IntPtr jarg1); // 0x000000018648EEC8-0x000000018648EEFC
	public static extern void CSharp_AkExternalSourceInfo_pInMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018648EE84-0x000000018648EEC8
	public static extern IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(IntPtr jarg1); // 0x000000018648EE50-0x000000018648EE84
	public static extern void CSharp_AkExternalSourceInfo_uiMemorySize_set(IntPtr jarg1, uint jarg2); // 0x000000018648EF30-0x000000018648EF70
	public static extern uint CSharp_AkExternalSourceInfo_uiMemorySize_get(IntPtr jarg1); // 0x000000018648EEFC-0x000000018648EF30
	public static extern void CSharp_AkExternalSourceInfo_idFile_set(IntPtr jarg1, uint jarg2); // 0x000000018648EE10-0x000000018648EE50
	public static extern uint CSharp_AkExternalSourceInfo_idFile_get(IntPtr jarg1); // 0x000000018648EDDC-0x000000018648EE10
	public static extern int CSharp_Init(IntPtr jarg1); // 0x00000001854FF230-0x00000001854FF270
	public static extern int CSharp_InitSpatialAudio(IntPtr jarg1); // 0x00000001854FF2D0-0x00000001854FF310
	public static extern int CSharp_InitCommunication(IntPtr jarg1); // 0x000000018649A36C-0x000000018649A3A0
	public static extern void CSharp_Term(); // 0x00000001864A112C-0x00000001864A1194
	public static extern int CSharp_RegisterGameObjInternal(ulong jarg1); // 0x00000001847A8090-0x00000001847A80C0
	public static extern int CSharp_UnregisterGameObjInternal(ulong jarg1); // 0x0000000184C9EE80-0x0000000184C9EEB0
	public static extern int CSharp_RegisterGameObjInternal_WithName(ulong jarg1, string jarg2); // 0x0000000184B69290-0x0000000184B692E0
	public static extern int CSharp_SetBasePath(string jarg1); // 0x000000018649EA9C-0x000000018649EADC
	public static extern int CSharp_SetCurrentLanguage(string jarg1); // 0x0000000184958120-0x0000000184958160
	public static extern int CSharp_LoadFilePackage(string jarg1, out uint jarg2); // 0x0000000184955DE0-0x0000000184955E30
	public static extern int CSharp_AddBasePath(string jarg1); // 0x0000000185809180-0x00000001858091C0
	public static extern int CSharp_SetGameName(string jarg1); // 0x000000018649EFF0-0x000000018649F030
	public static extern IntPtr CSharp_GetCurrentLanguage(); // 0x0000000186498618-0x0000000186498644
	public static extern int CSharp_UnloadFilePackage(uint jarg1); // 0x0000000184957DA0-0x0000000184957DE0
	public static extern int CSharp_UnloadAllFilePackages(); // 0x00000001864A1194-0x00000001864A11C0
	public static extern int CSharp_SetObjectPosition(ulong jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x00000001845BF4C0-0x00000001845BF560
	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_0(uint jarg1, out uint[] jarg2, out uint[] jarg3, out int[] jarg4, ref uint jarg5, bool jarg6); // 0x000000018649968C-0x0000000186499870
	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_1(uint jarg1, out uint[] jarg2, out uint[] jarg3, out int[] jarg4, ref uint jarg5); // 0x0000000186499870-0x0000000186499A44
	public static extern int CSharp_SetListeners(ulong jarg1, ulong[] jarg2, uint jarg3); // 0x000000018649F618-0x000000018649F6B4
	public static extern int CSharp_SetDefaultListeners(ulong[] jarg1, uint jarg2); // 0x0000000184A7F9C0-0x0000000184A7FA60
	public static extern uint CSharp_GetNumOutputDevices(uint jarg1); // 0x0000000184A7A6B0-0x0000000184A7A6F0
	public static extern int CSharp_AddOutput__SWIG_0(IntPtr jarg1, out ulong jarg2, ulong[] jarg3, uint jarg4); // 0x000000018648BB58-0x000000018648BC04
	public static extern int CSharp_AddOutput__SWIG_1(IntPtr jarg1, out ulong jarg2, ulong[] jarg3); // 0x000000018648BC04-0x000000018648BCA0
	public static extern int CSharp_AddOutput__SWIG_2(IntPtr jarg1, out ulong jarg2); // 0x000000018648BCA0-0x000000018648BD24
	public static extern int CSharp_AddOutput__SWIG_3(IntPtr jarg1); // 0x000000018648BD24-0x000000018648BD58
	public static extern void CSharp_GetDefaultStreamSettings(IntPtr jarg1); // 0x000000018649882C-0x0000000186498860
	public static extern void CSharp_GetDefaultDeviceSettings(IntPtr jarg1); // 0x000000018649875C-0x0000000186498790
	public static extern void CSharp_GetDefaultMusicSettings(IntPtr jarg1); // 0x00000001864987C4-0x00000001864987F8
	public static extern void CSharp_GetDefaultInitSettings(IntPtr jarg1); // 0x0000000186498790-0x00000001864987C4
	public static extern void CSharp_GetDefaultPlatformInitSettings(IntPtr jarg1); // 0x00000001864987F8-0x000000018649882C
	public static extern uint CSharp_GetMajorMinorVersion(); // 0x0000000186498DF0-0x0000000186498E1C
	public static extern uint CSharp_GetSubminorBuildVersion(); // 0x0000000186499EAC-0x0000000186499F14
	public static extern void CSharp_StartResourceMonitoring(); // 0x00000001864A0B40-0x00000001864A0B74
	public static extern void CSharp_StopResourceMonitoring(); // 0x00000001864A0FD4-0x00000001864A1008
	public static extern void CSharp_GetResourceMonitorDataSummary(IntPtr jarg1); // 0x0000000186499600-0x0000000186499634
	public static extern void CSharp_StartDeviceCapture(ulong jarg1); // 0x00000001864A09E8-0x00000001864A0A1C
	public static extern void CSharp_StopDeviceCapture(ulong jarg1); // 0x00000001864A0C2C-0x00000001864A0C60
	public static extern void CSharp_ClearCaptureData(); // 0x0000000186497044-0x00000001864970AC
	public static extern uint CSharp_UpdateCaptureSampleCount(ulong jarg1); // 0x00000001864A17F8-0x00000001864A1870
	public static extern uint CSharp_GetCaptureSamples(ulong jarg1, [In, Out] float[] jarg2, uint jarg3); // 0x000000018649857C-0x0000000186498618
	public static extern int CSharp_SetRoomPortal(ulong jarg1, ulong jarg2, ulong jarg3, IntPtr jarg4, IntPtr jarg5, bool jarg6, string jarg7); // 0x00000001864A0648-0x00000001864A0734
	public static extern int CSharp_SetRoom(ulong jarg1, IntPtr jarg2, ulong jarg3, string jarg4); // 0x0000000184B68270-0x0000000184B682F0
	public static extern int CSharp_RegisterSpatialAudioListener(ulong jarg1); // 0x0000000184A7F940-0x0000000184A7F9C0
	public static extern int CSharp_UnregisterSpatialAudioListener(ulong jarg1); // 0x00000001864A1710-0x00000001864A1744
	public static extern int CSharp_SetGeometry(ulong jarg1, IntPtr jarg2, uint jarg3, Vector3[] jarg4, uint jarg5, IntPtr jarg6, uint jarg7, bool jarg8, bool jarg9); // 0x0000000184123B20-0x0000000184123BB0
	public static extern int CSharp_SetGeometryInstance(ulong jarg1, IntPtr jarg2, Vector3 jarg3, ulong jarg4, ulong jarg5, bool jarg6); // 0x0000000184B68EF0-0x0000000184B68F80
	public static extern int CSharp_QueryReflectionPaths(ulong jarg1, uint jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out uint jarg6); // 0x000000018649CF2C-0x000000018649CFCC
	public static extern int CSharp_QueryDiffractionPaths(ulong jarg1, uint jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out uint jarg6); // 0x000000018649CE8C-0x000000018649CF2C
	public static extern void CSharp_PerformStreamMgrIO(); // 0x000000018649B27C-0x000000018649B2A8
	public static extern void CSharp_HgMemShrink(); // 0x000000018649A340-0x000000018649A36C
	public static extern ulong CSharp_HgGetGlobalMemoryUsed(); // 0x0000000184597C10-0x0000000184597C40
	public static extern ulong CSharp_HgGetGlobalMemoryReserved(); // 0x0000000185BB12B0-0x0000000185BB12E0
	public static extern void CSharp_InitScePad(); // 0x000000018571C940-0x000000018571C9B0
	public static extern uint CSharp_GetMMDeviceIdFromPadContainerInfo(int jarg1); // 0x0000000186498D78-0x0000000186498DF0
	public static extern IntPtr CSharp_AkPlaylist_SWIGUpcast(IntPtr jarg1); // 0x0000000186494390-0x00000001864943C4
	public static extern IntPtr CSharp_AkMIDIPost_SWIGUpcast(IntPtr jarg1); // 0x0000000186491DBC-0x0000000186491DF0
	public static extern IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001851447D0-0x0000000185144810
	public static extern IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000185144570-0x00000001851445F0
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000185144670-0x00000001851446B0
	public static extern IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000185144890-0x00000001851448D0
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001851443B0-0x00000001851443F0
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000185144300-0x0000000185144340
	public static extern IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000185144470-0x00000001851444F0
}

public class AkSoundEngine // TypeDefIndex: 54205
{
	// Fields
	public const int _WIN32_WINNT = 1538; // Metadata: 0x020798CC
	public const int AK_SIMD_ALIGNMENT = 16; // Metadata: 0x020798CE
	public const int AK_BUFFER_ALIGNMENT = 16; // Metadata: 0x020798CF
	public const int AK_XAUDIO2_FLAGS = 0; // Metadata: 0x020798D0
	public const int AK_MAX_PATH = 260; // Metadata: 0x020798D1
	public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16; // Metadata: 0x020798D3
	public const string AK_OSCHAR_FMT = "%ls"; // Metadata: 0x020798D4
	public const uint AK_INVALID_PLUGINID = 4294967295; // Metadata: 0x020798D8
	public const ulong AK_INVALID_GAME_OBJECT = 18446744073709551615; // Metadata: 0x020798D9
	public const uint AK_INVALID_UNIQUE_ID = 0; // Metadata: 0x020798E1
	public const uint AK_INVALID_RTPC_ID = 0; // Metadata: 0x020798E2
	public const uint AK_INVALID_LISTENER_INDEX = 4294967295; // Metadata: 0x020798E3
	public const uint AK_INVALID_PLAYING_ID = 0; // Metadata: 0x020798E4
	public const uint AK_DEFAULT_SWITCH_STATE = 0; // Metadata: 0x020798E5
	public const int AK_INVALID_POOL_ID = -1; // Metadata: 0x020798E6
	public const int AK_DEFAULT_POOL_ID = -1; // Metadata: 0x020798E7
	public const uint AK_INVALID_AUX_ID = 0; // Metadata: 0x020798E8
	public const uint AK_INVALID_FILE_ID = 4294967295; // Metadata: 0x020798E9
	public const uint AK_INVALID_DEVICE_ID = 4294967295; // Metadata: 0x020798EA
	public const uint AK_INVALID_BANK_ID = 0; // Metadata: 0x020798EB
	public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0; // Metadata: 0x020798EC
	public const uint AK_INVALID_CHANNELMASK = 0; // Metadata: 0x020798ED
	public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0; // Metadata: 0x020798EE
	public const uint AK_MIXER_FX_SLOT = 4294967295; // Metadata: 0x020798EF
	public const ulong AK_DEFAULT_LISTENER_OBJ = 0; // Metadata: 0x020798F0
	public const uint AK_DEFAULT_PRIORITY = 50; // Metadata: 0x020798F8
	public const uint AK_MIN_PRIORITY = 0; // Metadata: 0x020798F9
	public const uint AK_MAX_PRIORITY = 100; // Metadata: 0x020798FA
	public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50; // Metadata: 0x020798FB
	public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576; // Metadata: 0x020798FC
	public const uint AKCOMPANYID_AUDIOKINETIC = 0; // Metadata: 0x02079904
	public const uint AK_LISTENERS_MASK_ALL = 4294967295; // Metadata: 0x02079905
	public const int NULL = 0; // Metadata: 0x02079906
	public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5; // Metadata: 0x02079907
	public const int AK_MAX_LANGUAGE_NAME_SIZE = 32; // Metadata: 0x02079908
	public const int AKCOMPANYID_PLUGINDEV_MIN = 64; // Metadata: 0x02079909
	public const int AKCOMPANYID_PLUGINDEV_MAX = 255; // Metadata: 0x0207990B
	public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1; // Metadata: 0x0207990D
	public const int AKCOMPANYID_MCDSP = 256; // Metadata: 0x0207990E
	public const int AKCOMPANYID_WAVEARTS = 257; // Metadata: 0x02079910
	public const int AKCOMPANYID_PHONETICARTS = 258; // Metadata: 0x02079912
	public const int AKCOMPANYID_IZOTOPE = 259; // Metadata: 0x02079914
	public const int AKCOMPANYID_CRANKCASEAUDIO = 261; // Metadata: 0x02079916
	public const int AKCOMPANYID_IOSONO = 262; // Metadata: 0x02079918
	public const int AKCOMPANYID_AUROTECHNOLOGIES = 263; // Metadata: 0x0207991A
	public const int AKCOMPANYID_DOLBY = 264; // Metadata: 0x0207991C
	public const int AKCOMPANYID_TWOBIGEARS = 265; // Metadata: 0x0207991E
	public const int AKCOMPANYID_OCULUS = 266; // Metadata: 0x02079920
	public const int AKCOMPANYID_BLUERIPPLESOUND = 267; // Metadata: 0x02079922
	public const int AKCOMPANYID_ENZIEN = 268; // Metadata: 0x02079924
	public const int AKCOMPANYID_KROTOS = 269; // Metadata: 0x02079926
	public const int AKCOMPANYID_NURULIZE = 270; // Metadata: 0x02079928
	public const int AKCOMPANYID_SUPERPOWERED = 271; // Metadata: 0x0207992A
	public const int AKCOMPANYID_GOOGLE = 272; // Metadata: 0x0207992C
	public const int AKCOMPANYID_VISISONICS = 277; // Metadata: 0x0207992E
	public const int AKCODECID_BANK = 0; // Metadata: 0x02079930
	public const int AKCODECID_PCM = 1; // Metadata: 0x02079931
	public const int AKCODECID_ADPCM = 2; // Metadata: 0x02079932
	public const int AKCODECID_XMA = 3; // Metadata: 0x02079933
	public const int AKCODECID_VORBIS = 4; // Metadata: 0x02079934
	public const int AKCODECID_WIIADPCM = 5; // Metadata: 0x02079935
	public const int AKCODECID_PCMEX = 7; // Metadata: 0x02079936
	public const int AKCODECID_EXTERNAL_SOURCE = 8; // Metadata: 0x02079937
	public const int AKCODECID_XWMA = 9; // Metadata: 0x02079938
	public const int AKCODECID_FILE_PACKAGE = 11; // Metadata: 0x02079939
	public const int AKCODECID_ATRAC9 = 12; // Metadata: 0x0207993A
	public const int AKCODECID_VAG = 13; // Metadata: 0x0207993B
	public const int AKCODECID_PROFILERCAPTURE = 14; // Metadata: 0x0207993C
	public const int AKCODECID_ANALYSISFILE = 15; // Metadata: 0x0207993D
	public const int AKCODECID_MIDI = 16; // Metadata: 0x0207993E
	public const int AKCODECID_OPUSNX = 17; // Metadata: 0x0207993F
	public const int AKCODECID_CAF = 18; // Metadata: 0x02079940
	public const int AKCODECID_AKOPUS = 19; // Metadata: 0x02079941
	public const int AKCODECID_AKOPUS_WEM = 20; // Metadata: 0x02079942
	public const int AKCODECID_MEMORYMGR_DUMP = 21; // Metadata: 0x02079943
	public const int AKCODECID_SONY360 = 22; // Metadata: 0x02079944
	public const int AKCODECID_BANK_EVENT = 30; // Metadata: 0x02079945
	public const int AKCODECID_BANK_BUS = 31; // Metadata: 0x02079946
	public const int AKPLUGINID_METER = 129; // Metadata: 0x02079947
	public const int AKPLUGINID_RECORDER = 132; // Metadata: 0x02079949
	public const int AKPLUGINID_IMPACTER = 184; // Metadata: 0x0207994B
	public const int AKPLUGINID_SYSTEM_OUTPUT_META = 900; // Metadata: 0x0207994D
	public const int AKPLUGINID_AUDIO_OBJECT_ATTENUATION_META = 901; // Metadata: 0x0207994F
	public const int AKPLUGINID_AUDIO_OBJECT_PRIORITY_META = 902; // Metadata: 0x02079951
	public const int AKEXTENSIONID_SPATIALAUDIO = 800; // Metadata: 0x02079953
	public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801; // Metadata: 0x02079955
	public const int AKEXTENSIONID_MIDIDEVICEMGR = 802; // Metadata: 0x02079957
	public const int AK_WAVE_FORMAT_VAG = 65531; // Metadata: 0x02079959
	public const int AK_WAVE_FORMAT_AT9 = 65532; // Metadata: 0x0207995D
	public const int AK_WAVE_FORMAT_VORBIS = 65535; // Metadata: 0x02079961
	public const int AK_WAVE_FORMAT_OPUSNX = 12345; // Metadata: 0x02079965
	public const int AK_WAVE_FORMAT_OPUS = 12352; // Metadata: 0x02079969
	public const int AK_WAVE_FORMAT_OPUS_WEM = 12353; // Metadata: 0x0207996D
	public const int WAVE_FORMAT_XMA2 = 358; // Metadata: 0x02079971
	public const int AK_PANNER_NUM_STORAGE_BITS = 3; // Metadata: 0x02079973
	public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3; // Metadata: 0x02079974
	public const int AK_SPAT_NUM_STORAGE_BITS = 3; // Metadata: 0x02079975
	public const int AK_MAX_BITS_METERING_FLAGS = 5; // Metadata: 0x02079976
	public const bool AK_ASYNC_OPEN_DEFAULT = false; // Metadata: 0x02079977
	public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024; // Metadata: 0x02079978
	public const double AK_DEFAULT_LISTENER_POSITION_X = 0; // Metadata: 0x0207997C
	public const double AK_DEFAULT_LISTENER_POSITION_Y = 0; // Metadata: 0x02079984
	public const double AK_DEFAULT_LISTENER_POSITION_Z = 0; // Metadata: 0x0207998C
	public const double AK_DEFAULT_LISTENER_FRONT_X = 0; // Metadata: 0x02079994
	public const double AK_DEFAULT_LISTENER_FRONT_Y = 0; // Metadata: 0x0207999C
	public const double AK_DEFAULT_LISTENER_FRONT_Z = 1; // Metadata: 0x020799A4
	public const double AK_DEFAULT_TOP_X = 0; // Metadata: 0x020799AC
	public const double AK_DEFAULT_TOP_Y = 1; // Metadata: 0x020799B4
	public const double AK_DEFAULT_TOP_Z = 0; // Metadata: 0x020799BC
	public const double AK_SA_EPSILON = 0.001; // Metadata: 0x020799C4
	public const double AK_SA_DIFFRACTION_EPSILON = 0.002; // Metadata: 0x020799CC
	public const double AK_SA_PLANE_THICKNESS = 0.01; // Metadata: 0x020799D4
	public const double AK_SA_MIN_ENVIRONMENT_ABSORPTION = 0.01; // Metadata: 0x020799DC
	public const double AK_SA_MIN_ENVIRONMENT_SURFACE_AREA = 1; // Metadata: 0x020799E4
	public const int AK_MIDI_EVENT_TYPE_INVALID = 0; // Metadata: 0x020799EC
	public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128; // Metadata: 0x020799ED
	public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144; // Metadata: 0x020799EF
	public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160; // Metadata: 0x020799F1
	public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176; // Metadata: 0x020799F3
	public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192; // Metadata: 0x020799F5
	public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208; // Metadata: 0x020799F7
	public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224; // Metadata: 0x020799F9
	public const int AK_MIDI_EVENT_TYPE_SYSEX = 240; // Metadata: 0x020799FB
	public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247; // Metadata: 0x020799FD
	public const int AK_MIDI_EVENT_TYPE_WWISE_CMD = 254; // Metadata: 0x020799FF
	public const int AK_MIDI_EVENT_TYPE_META = 255; // Metadata: 0x02079A01
	public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0; // Metadata: 0x02079A03
	public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1; // Metadata: 0x02079A04
	public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2; // Metadata: 0x02079A05
	public const int AK_MIDI_CC_CTRL_3_COARSE = 3; // Metadata: 0x02079A06
	public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4; // Metadata: 0x02079A07
	public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5; // Metadata: 0x02079A08
	public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6; // Metadata: 0x02079A09
	public const int AK_MIDI_CC_VOLUME_COARSE = 7; // Metadata: 0x02079A0A
	public const int AK_MIDI_CC_BALANCE_COARSE = 8; // Metadata: 0x02079A0B
	public const int AK_MIDI_CC_CTRL_9_COARSE = 9; // Metadata: 0x02079A0C
	public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10; // Metadata: 0x02079A0D
	public const int AK_MIDI_CC_EXPRESSION_COARSE = 11; // Metadata: 0x02079A0E
	public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12; // Metadata: 0x02079A0F
	public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13; // Metadata: 0x02079A10
	public const int AK_MIDI_CC_CTRL_14_COARSE = 14; // Metadata: 0x02079A11
	public const int AK_MIDI_CC_CTRL_15_COARSE = 15; // Metadata: 0x02079A12
	public const int AK_MIDI_CC_GEN_SLIDER_1 = 16; // Metadata: 0x02079A13
	public const int AK_MIDI_CC_GEN_SLIDER_2 = 17; // Metadata: 0x02079A14
	public const int AK_MIDI_CC_GEN_SLIDER_3 = 18; // Metadata: 0x02079A15
	public const int AK_MIDI_CC_GEN_SLIDER_4 = 19; // Metadata: 0x02079A16
	public const int AK_MIDI_CC_CTRL_20_COARSE = 20; // Metadata: 0x02079A17
	public const int AK_MIDI_CC_CTRL_21_COARSE = 21; // Metadata: 0x02079A18
	public const int AK_MIDI_CC_CTRL_22_COARSE = 22; // Metadata: 0x02079A19
	public const int AK_MIDI_CC_CTRL_23_COARSE = 23; // Metadata: 0x02079A1A
	public const int AK_MIDI_CC_CTRL_24_COARSE = 24; // Metadata: 0x02079A1B
	public const int AK_MIDI_CC_CTRL_25_COARSE = 25; // Metadata: 0x02079A1C
	public const int AK_MIDI_CC_CTRL_26_COARSE = 26; // Metadata: 0x02079A1D
	public const int AK_MIDI_CC_CTRL_27_COARSE = 27; // Metadata: 0x02079A1E
	public const int AK_MIDI_CC_CTRL_28_COARSE = 28; // Metadata: 0x02079A1F
	public const int AK_MIDI_CC_CTRL_29_COARSE = 29; // Metadata: 0x02079A20
	public const int AK_MIDI_CC_CTRL_30_COARSE = 30; // Metadata: 0x02079A21
	public const int AK_MIDI_CC_CTRL_31_COARSE = 31; // Metadata: 0x02079A22
	public const int AK_MIDI_CC_BANK_SELECT_FINE = 32; // Metadata: 0x02079A23
	public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33; // Metadata: 0x02079A24
	public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34; // Metadata: 0x02079A25
	public const int AK_MIDI_CC_CTRL_3_FINE = 35; // Metadata: 0x02079A26
	public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36; // Metadata: 0x02079A27
	public const int AK_MIDI_CC_PORTAMENTO_FINE = 37; // Metadata: 0x02079A28
	public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38; // Metadata: 0x02079A29
	public const int AK_MIDI_CC_VOLUME_FINE = 39; // Metadata: 0x02079A2A
	public const int AK_MIDI_CC_BALANCE_FINE = 40; // Metadata: 0x02079A2B
	public const int AK_MIDI_CC_CTRL_9_FINE = 41; // Metadata: 0x02079A2C
	public const int AK_MIDI_CC_PAN_POSITION_FINE = 42; // Metadata: 0x02079A2D
	public const int AK_MIDI_CC_EXPRESSION_FINE = 43; // Metadata: 0x02079A2E
	public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44; // Metadata: 0x02079A2F
	public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45; // Metadata: 0x02079A30
	public const int AK_MIDI_CC_CTRL_14_FINE = 46; // Metadata: 0x02079A31
	public const int AK_MIDI_CC_CTRL_15_FINE = 47; // Metadata: 0x02079A32
	public const int AK_MIDI_CC_CTRL_20_FINE = 52; // Metadata: 0x02079A33
	public const int AK_MIDI_CC_CTRL_21_FINE = 53; // Metadata: 0x02079A34
	public const int AK_MIDI_CC_CTRL_22_FINE = 54; // Metadata: 0x02079A35
	public const int AK_MIDI_CC_CTRL_23_FINE = 55; // Metadata: 0x02079A36
	public const int AK_MIDI_CC_CTRL_24_FINE = 56; // Metadata: 0x02079A37
	public const int AK_MIDI_CC_CTRL_25_FINE = 57; // Metadata: 0x02079A38
	public const int AK_MIDI_CC_CTRL_26_FINE = 58; // Metadata: 0x02079A39
	public const int AK_MIDI_CC_CTRL_27_FINE = 59; // Metadata: 0x02079A3A
	public const int AK_MIDI_CC_CTRL_28_FINE = 60; // Metadata: 0x02079A3B
	public const int AK_MIDI_CC_CTRL_29_FINE = 61; // Metadata: 0x02079A3C
	public const int AK_MIDI_CC_CTRL_30_FINE = 62; // Metadata: 0x02079A3D
	public const int AK_MIDI_CC_CTRL_31_FINE = 63; // Metadata: 0x02079A3E
	public const int AK_MIDI_CC_HOLD_PEDAL = 64; // Metadata: 0x02079A3F
	public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65; // Metadata: 0x02079A41
	public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66; // Metadata: 0x02079A43
	public const int AK_MIDI_CC_SOFT_PEDAL = 67; // Metadata: 0x02079A45
	public const int AK_MIDI_CC_LEGATO_PEDAL = 68; // Metadata: 0x02079A47
	public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69; // Metadata: 0x02079A49
	public const int AK_MIDI_CC_SOUND_VARIATION = 70; // Metadata: 0x02079A4B
	public const int AK_MIDI_CC_SOUND_TIMBRE = 71; // Metadata: 0x02079A4D
	public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72; // Metadata: 0x02079A4F
	public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73; // Metadata: 0x02079A51
	public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74; // Metadata: 0x02079A53
	public const int AK_MIDI_CC_SOUND_CTRL_6 = 75; // Metadata: 0x02079A55
	public const int AK_MIDI_CC_SOUND_CTRL_7 = 76; // Metadata: 0x02079A57
	public const int AK_MIDI_CC_SOUND_CTRL_8 = 77; // Metadata: 0x02079A59
	public const int AK_MIDI_CC_SOUND_CTRL_9 = 78; // Metadata: 0x02079A5B
	public const int AK_MIDI_CC_SOUND_CTRL_10 = 79; // Metadata: 0x02079A5D
	public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80; // Metadata: 0x02079A5F
	public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81; // Metadata: 0x02079A61
	public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82; // Metadata: 0x02079A63
	public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83; // Metadata: 0x02079A65
	public const int AK_MIDI_CC_REVERB_LEVEL = 91; // Metadata: 0x02079A67
	public const int AK_MIDI_CC_TREMOLO_LEVEL = 92; // Metadata: 0x02079A69
	public const int AK_MIDI_CC_CHORUS_LEVEL = 93; // Metadata: 0x02079A6B
	public const int AK_MIDI_CC_CELESTE_LEVEL = 94; // Metadata: 0x02079A6D
	public const int AK_MIDI_CC_PHASER_LEVEL = 95; // Metadata: 0x02079A6F
	public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96; // Metadata: 0x02079A71
	public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97; // Metadata: 0x02079A73
	public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98; // Metadata: 0x02079A75
	public const int AK_MIDI_CC_NON_REGISTER_FINE = 99; // Metadata: 0x02079A77
	public const int AK_MIDI_CC_ALL_SOUND_OFF = 120; // Metadata: 0x02079A79
	public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121; // Metadata: 0x02079A7B
	public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122; // Metadata: 0x02079A7D
	public const int AK_MIDI_CC_ALL_NOTES_OFF = 123; // Metadata: 0x02079A7F
	public const int AK_MIDI_CC_OMNI_MODE_OFF = 124; // Metadata: 0x02079A81
	public const int AK_MIDI_CC_OMNI_MODE_ON = 125; // Metadata: 0x02079A83
	public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126; // Metadata: 0x02079A85
	public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127; // Metadata: 0x02079A87
	public const int AK_MIDI_WWISE_CMD_PLAY = 0; // Metadata: 0x02079A89
	public const int AK_MIDI_WWISE_CMD_STOP = 1; // Metadata: 0x02079A8A
	public const int AK_MIDI_WWISE_CMD_PAUSE = 2; // Metadata: 0x02079A8B
	public const int AK_MIDI_WWISE_CMD_RESUME = 3; // Metadata: 0x02079A8C
	public const int AK_MIDI_WWISE_CMD_SEEK_MS = 4; // Metadata: 0x02079A8D
	public const int AK_MIDI_WWISE_CMD_SEEK_SAMPLES = 5; // Metadata: 0x02079A8E
	public const int AK_SPEAKER_FRONT_LEFT = 1; // Metadata: 0x02079A8F
	public const int AK_SPEAKER_FRONT_RIGHT = 2; // Metadata: 0x02079A90
	public const int AK_SPEAKER_FRONT_CENTER = 4; // Metadata: 0x02079A91
	public const int AK_SPEAKER_LOW_FREQUENCY = 8; // Metadata: 0x02079A92
	public const int AK_SPEAKER_BACK_LEFT = 16; // Metadata: 0x02079A93
	public const int AK_SPEAKER_BACK_RIGHT = 32; // Metadata: 0x02079A94
	public const int AK_SPEAKER_BACK_CENTER = 256; // Metadata: 0x02079A95
	public const int AK_SPEAKER_SIDE_LEFT = 512; // Metadata: 0x02079A97
	public const int AK_SPEAKER_SIDE_RIGHT = 1024; // Metadata: 0x02079A99
	public const int AK_SPEAKER_TOP = 2048; // Metadata: 0x02079A9B
	public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096; // Metadata: 0x02079A9D
	public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192; // Metadata: 0x02079A9F
	public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384; // Metadata: 0x02079AA3
	public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768; // Metadata: 0x02079AA7
	public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536; // Metadata: 0x02079AAB
	public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072; // Metadata: 0x02079AAF
	public const int AK_SPEAKER_SETUP_MONO = 4; // Metadata: 0x02079AB3
	public const int AK_SPEAKER_SETUP_0POINT1 = 8; // Metadata: 0x02079AB4
	public const int AK_SPEAKER_SETUP_1POINT1 = 12; // Metadata: 0x02079AB5
	public const int AK_SPEAKER_SETUP_STEREO = 3; // Metadata: 0x02079AB6
	public const int AK_SPEAKER_SETUP_2POINT1 = 11; // Metadata: 0x02079AB7
	public const int AK_SPEAKER_SETUP_3STEREO = 7; // Metadata: 0x02079AB8
	public const int AK_SPEAKER_SETUP_3POINT1 = 15; // Metadata: 0x02079AB9
	public const int AK_SPEAKER_SETUP_4 = 1539; // Metadata: 0x02079ABA
	public const int AK_SPEAKER_SETUP_4POINT1 = 1547; // Metadata: 0x02079ABC
	public const int AK_SPEAKER_SETUP_5 = 1543; // Metadata: 0x02079ABE
	public const int AK_SPEAKER_SETUP_5POINT1 = 1551; // Metadata: 0x02079AC0
	public const int AK_SPEAKER_SETUP_6 = 1587; // Metadata: 0x02079AC2
	public const int AK_SPEAKER_SETUP_6POINT1 = 1595; // Metadata: 0x02079AC4
	public const int AK_SPEAKER_SETUP_7 = 1591; // Metadata: 0x02079AC6
	public const int AK_SPEAKER_SETUP_7POINT1 = 1599; // Metadata: 0x02079AC8
	public const int AK_SPEAKER_SETUP_SURROUND = 259; // Metadata: 0x02079ACA
	public const int AK_SPEAKER_SETUP_DPL2 = 1539; // Metadata: 0x02079ACC
	public const int AK_SPEAKER_SETUP_HEIGHT_2 = 20480; // Metadata: 0x02079ACE
	public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320; // Metadata: 0x02079AD2
	public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512; // Metadata: 0x02079AD6
	public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048; // Metadata: 0x02079ADA
	public const int AK_SPEAKER_SETUP_HEIGHT_4_TOP = 186368; // Metadata: 0x02079ADE
	public const int AK_SPEAKER_SETUP_HEIGHT_5_TOP = 194560; // Metadata: 0x02079AE2
	public const int AK_SPEAKER_SETUP_AURO_222 = 22019; // Metadata: 0x02079AE6
	public const int AK_SPEAKER_SETUP_AURO_8 = 185859; // Metadata: 0x02079AEA
	public const int AK_SPEAKER_SETUP_AURO_9 = 185863; // Metadata: 0x02079AEE
	public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871; // Metadata: 0x02079AF2
	public const int AK_SPEAKER_SETUP_AURO_10 = 187911; // Metadata: 0x02079AF6
	public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919; // Metadata: 0x02079AFA
	public const int AK_SPEAKER_SETUP_AURO_11 = 196103; // Metadata: 0x02079AFE
	public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111; // Metadata: 0x02079B02
	public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911; // Metadata: 0x02079B06
	public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919; // Metadata: 0x02079B0A
	public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151; // Metadata: 0x02079B0E
	public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159; // Metadata: 0x02079B12
	public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023; // Metadata: 0x02079B16
	public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031; // Metadata: 0x02079B1A
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067; // Metadata: 0x02079B1E
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075; // Metadata: 0x02079B22
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907; // Metadata: 0x02079B26
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915; // Metadata: 0x02079B2A
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071; // Metadata: 0x02079B2E
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079; // Metadata: 0x02079B32
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911; // Metadata: 0x02079B36
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919; // Metadata: 0x02079B3A
	public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951; // Metadata: 0x02079B3E
	public const int AK_IDX_SETUP_FRONT_LEFT = 0; // Metadata: 0x02079B42
	public const int AK_IDX_SETUP_FRONT_RIGHT = 1; // Metadata: 0x02079B43
	public const int AK_IDX_SETUP_CENTER = 2; // Metadata: 0x02079B44
	public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2; // Metadata: 0x02079B45
	public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3; // Metadata: 0x02079B46
	public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4; // Metadata: 0x02079B47
	public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5; // Metadata: 0x02079B48
	public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3; // Metadata: 0x02079B49
	public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4; // Metadata: 0x02079B4A
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5; // Metadata: 0x02079B4B
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6; // Metadata: 0x02079B4C
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_LEFT = 7; // Metadata: 0x02079B4D
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_RIGHT = 8; // Metadata: 0x02079B4E
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_LEFT = 9; // Metadata: 0x02079B4F
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_RIGHT = 10; // Metadata: 0x02079B50
	public const int AK_IDX_SETUP_0_LFE = 0; // Metadata: 0x02079B51
	public const int AK_IDX_SETUP_1_CENTER = 0; // Metadata: 0x02079B52
	public const int AK_IDX_SETUP_1_LFE = 1; // Metadata: 0x02079B53
	public const int AK_IDX_SETUP_2_LEFT = 0; // Metadata: 0x02079B54
	public const int AK_IDX_SETUP_2_RIGHT = 1; // Metadata: 0x02079B55
	public const int AK_IDX_SETUP_2_LFE = 2; // Metadata: 0x02079B56
	public const int AK_IDX_SETUP_3_LEFT = 0; // Metadata: 0x02079B57
	public const int AK_IDX_SETUP_3_RIGHT = 1; // Metadata: 0x02079B58
	public const int AK_IDX_SETUP_3_CENTER = 2; // Metadata: 0x02079B59
	public const int AK_IDX_SETUP_3_LFE = 3; // Metadata: 0x02079B5A
	public const int AK_IDX_SETUP_4_FRONTLEFT = 0; // Metadata: 0x02079B5B
	public const int AK_IDX_SETUP_4_FRONTRIGHT = 1; // Metadata: 0x02079B5C
	public const int AK_IDX_SETUP_4_REARLEFT = 2; // Metadata: 0x02079B5D
	public const int AK_IDX_SETUP_4_REARRIGHT = 3; // Metadata: 0x02079B5E
	public const int AK_IDX_SETUP_4_LFE = 4; // Metadata: 0x02079B5F
	public const int AK_IDX_SETUP_5_FRONTLEFT = 0; // Metadata: 0x02079B60
	public const int AK_IDX_SETUP_5_FRONTRIGHT = 1; // Metadata: 0x02079B61
	public const int AK_IDX_SETUP_5_CENTER = 2; // Metadata: 0x02079B62
	public const int AK_IDX_SETUP_5_REARLEFT = 3; // Metadata: 0x02079B63
	public const int AK_IDX_SETUP_5_REARRIGHT = 4; // Metadata: 0x02079B64
	public const int AK_IDX_SETUP_5_LFE = 5; // Metadata: 0x02079B65
	public const int AK_IDX_SETUP_6_FRONTLEFT = 0; // Metadata: 0x02079B66
	public const int AK_IDX_SETUP_6_FRONTRIGHT = 1; // Metadata: 0x02079B67
	public const int AK_IDX_SETUP_6_REARLEFT = 2; // Metadata: 0x02079B68
	public const int AK_IDX_SETUP_6_REARRIGHT = 3; // Metadata: 0x02079B69
	public const int AK_IDX_SETUP_6_SIDELEFT = 4; // Metadata: 0x02079B6A
	public const int AK_IDX_SETUP_6_SIDERIGHT = 5; // Metadata: 0x02079B6B
	public const int AK_IDX_SETUP_6_LFE = 6; // Metadata: 0x02079B6C
	public const int AK_IDX_SETUP_7_FRONTLEFT = 0; // Metadata: 0x02079B6D
	public const int AK_IDX_SETUP_7_FRONTRIGHT = 1; // Metadata: 0x02079B6E
	public const int AK_IDX_SETUP_7_CENTER = 2; // Metadata: 0x02079B6F
	public const int AK_IDX_SETUP_7_REARLEFT = 3; // Metadata: 0x02079B70
	public const int AK_IDX_SETUP_7_REARRIGHT = 4; // Metadata: 0x02079B71
	public const int AK_IDX_SETUP_7_SIDELEFT = 5; // Metadata: 0x02079B72
	public const int AK_IDX_SETUP_7_SIDERIGHT = 6; // Metadata: 0x02079B73
	public const int AK_IDX_SETUP_7_LFE = 7; // Metadata: 0x02079B74
	public const int AK_SPEAKER_SETUP_0_1 = 8; // Metadata: 0x02079B75
	public const int AK_SPEAKER_SETUP_1_0_CENTER = 4; // Metadata: 0x02079B76
	public const int AK_SPEAKER_SETUP_1_1_CENTER = 12; // Metadata: 0x02079B77
	public const int AK_SPEAKER_SETUP_2_0 = 3; // Metadata: 0x02079B78
	public const int AK_SPEAKER_SETUP_2_1 = 11; // Metadata: 0x02079B79
	public const int AK_SPEAKER_SETUP_3_0 = 7; // Metadata: 0x02079B7A
	public const int AK_SPEAKER_SETUP_3_1 = 15; // Metadata: 0x02079B7B
	public const int AK_SPEAKER_SETUP_FRONT = 7; // Metadata: 0x02079B7C
	public const int AK_SPEAKER_SETUP_4_0 = 1539; // Metadata: 0x02079B7D
	public const int AK_SPEAKER_SETUP_4_1 = 1547; // Metadata: 0x02079B7F
	public const int AK_SPEAKER_SETUP_5_0 = 1543; // Metadata: 0x02079B81
	public const int AK_SPEAKER_SETUP_5_1 = 1551; // Metadata: 0x02079B83
	public const int AK_SPEAKER_SETUP_6_0 = 1587; // Metadata: 0x02079B85
	public const int AK_SPEAKER_SETUP_6_1 = 1595; // Metadata: 0x02079B87
	public const int AK_SPEAKER_SETUP_7_0 = 1591; // Metadata: 0x02079B89
	public const int AK_SPEAKER_SETUP_7_1 = 1599; // Metadata: 0x02079B8B
	public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599; // Metadata: 0x02079B8D
	public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951; // Metadata: 0x02079B8F
	public const int AK_STANDARD_MAX_NUM_CHANNELS = 8; // Metadata: 0x02079B93
	public const int AK_MAX_AMBISONICS_ORDER = 5; // Metadata: 0x02079B94
	public const int AK_MAX_NUM_TEXTURE = 4; // Metadata: 0x02079B95
	public const int AK_MAX_REFLECT_ORDER = 4; // Metadata: 0x02079B96
	public const int AK_MAX_REFLECTION_PATH_LENGTH = 8; // Metadata: 0x02079B97
	public const int AK_STOCHASTIC_RESERVE_LENGTH = 8; // Metadata: 0x02079B98
	public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8; // Metadata: 0x02079B99
	public const int AK_MAX_SOUND_PROPAGATION_WIDTH = 8; // Metadata: 0x02079B9A
	public const double AK_SA_DIFFRACTION_DOT_EPSILON = 5E-05; // Metadata: 0x02079B9B
	public const double AK_DEFAULT_GEOMETRY_POSITION_X = 0; // Metadata: 0x02079BA3
	public const double AK_DEFAULT_GEOMETRY_POSITION_Y = 0; // Metadata: 0x02079BAB
	public const double AK_DEFAULT_GEOMETRY_POSITION_Z = 0; // Metadata: 0x02079BB3
	public const double AK_DEFAULT_GEOMETRY_FRONT_X = 0; // Metadata: 0x02079BBB
	public const double AK_DEFAULT_GEOMETRY_FRONT_Y = 0; // Metadata: 0x02079BC3
	public const double AK_DEFAULT_GEOMETRY_FRONT_Z = 1; // Metadata: 0x02079BCB
	public const double AK_DEFAULT_GEOMETRY_TOP_X = 0; // Metadata: 0x02079BD3
	public const double AK_DEFAULT_GEOMETRY_TOP_Y = 1; // Metadata: 0x02079BDB
	public const double AK_DEFAULT_GEOMETRY_TOP_Z = 0; // Metadata: 0x02079BE3
	private static GameObjectHashFunction gameObjectHash; // 0x00
	public const uint AK_PENDING_EVENT_LOAD_ID = 4294967295; // Metadata: 0x02079BEB

	// Properties
	public static uint AK_INVALID_SHARE_SET_ID { get => default; } // 0x00000001864BA488-0x00000001864BA4C8 
	public static uint AK_INVALID_PIPELINE_ID { get => default; } // 0x00000001864BA448-0x00000001864BA488 
	public static ulong AK_INVALID_AUDIO_OBJECT_ID { get => default; } // 0x00000001864BA4C8-0x00000001864BA508 
	public static uint AK_SOUNDBANK_VERSION { get => default; } // 0x00000001864BA3C8-0x00000001864BA408 
	public static uint AkJobType_Generic { get => default; } // 0x00000001864ACBC4-0x00000001864ACC40 
	public static uint AkJobType_AudioProcessing { get => default; } // 0x00000001864ACCBC-0x00000001864ACD38 
	public static uint AkJobType_SpatialAudio { get => default; } // 0x00000001864ACC40-0x00000001864ACCBC 
	public static uint AK_NUM_JOB_TYPES { get => default; } // 0x00000001864ACB48-0x00000001864ACBC4 
	public static ushort AK_INT { get => default; } // 0x00000001864BA2C8-0x00000001864BA308 
	public static ushort AK_FLOAT { get => default; } // 0x00000001864BA348-0x00000001864BA388 
	public static byte AK_INTERLEAVED { get => default; } // 0x00000001864BA308-0x00000001864BA348 
	public static byte AK_NONINTERLEAVED { get => default; } // 0x00000001864B0104-0x00000001864B014C 
	public static uint AK_LE_NATIVE_BITSPERSAMPLE { get => default; } // 0x00000001864ACFF8-0x00000001864AD0D0 
	public static uint AK_LE_NATIVE_SAMPLETYPE { get => default; } // 0x00000001864AD0D0-0x00000001864AD1A0 
	public static uint AK_LE_NATIVE_INTERLEAVE { get => default; } // 0x00000001864AD22C-0x00000001864AD294 
	public static byte AK_INVALID_MIDI_CHANNEL { get => default; } // 0x00000001864B9120-0x00000001864B9160 
	public static byte AK_INVALID_MIDI_NOTE { get => default; } // 0x00000001864B96B0-0x00000001864B96F0 
	public static uint kDefaultDiffractionMaxEdges { get => default; } // 0x00000001864BA718-0x00000001864BA758 
	public static uint kDefaultDiffractionMaxPaths { get => default; } // 0x00000001864BA758-0x00000001864BA798 
	public static float kMaxDiffraction { get => default; } // 0x00000001864BA818-0x00000001864BA858 
	public static uint kHashListBlockAllocItemCount { get => default; } // 0x00000001864B6898-0x00000001864B68FC 
	public static uint kDiffractionMaxEdges { get => default; } // 0x00000001864B6CA0-0x00000001864B6D28 
	public static uint kDiffractionMaxPaths { get => default; } // 0x00000001864B6C20-0x00000001864B6CA0 
	public static uint kPortalToPortalDiffractionMaxPaths { get => default; } // 0x00000001864B6BAC-0x00000001864B6C20 
	public static GameObjectHashFunction GameObjectHash { set {} } // 0x00000001864B9DEC-0x00000001864B9E88
	public static string WwiseVersion { get => default; } // 0x00000001864AD294-0x00000001864AD394 

	// Nested types
	public delegate ulong GameObjectHashFunction(GameObject gameObject); // TypeDefIndex: 54204; 0x00000001864BA288-0x00000001864BA2C8

	// Constructors
	public AkSoundEngine() {} // 0x0000000185A264E0-0x0000000185A26510
	static AkSoundEngine() {} // 0x00000001864BC1CC-0x00000001864BC2FC

	// Methods
	public static uint JoystickIdToWwiseId(uint joyStickID) => default; // 0x00000001864BA408-0x00000001864BA448
	public static Vector3 ConvertAkVector64ToAkVector(AkVector64 in_) => default; // 0x00000001864BA148-0x00000001864BA188
	public static AkTransform ConvertAkWorldTransformToAkTransform(AkWorldTransform in_) => default; // 0x00000001864BA0C8-0x00000001864BA108
	public static AkVector64 ConvertAkVectorToAkVector64(Vector3 in_) => default; // 0x00000001864BA108-0x00000001864BA148
	public static AkWorldTransform ConvertAkTransformToAkWorldTransform(AkTransform in_) => default; // 0x00000001864BA388-0x00000001864BA3C8
	public static bool IsBankCodecID(uint in_codecID) => default; // 0x00000001864ACDCC-0x00000001864ACE14
	public static uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) => default; // 0x00000001864AD490-0x00000001864AD4EC
	public static uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864AD4EC-0x00000001864AD544
	public static uint DynamicSequenceOpen(ulong in_gameObjectID) => default; // 0x00000001864AD544-0x00000001864AD58C
	public static AKRESULT DynamicSequenceClose(uint in_playingID) => default; // 0x00000001864AD3DC-0x00000001864AD438
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864AD438-0x00000001864AD490
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration) => default; // 0x00000001864AD394-0x00000001864AD3DC
	public static AKRESULT DynamicSequencePlay(uint in_playingID) => default; // 0x00000001864AD62C-0x00000001864AD688
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864AD58C-0x00000001864AD5E4
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration) => default; // 0x00000001864AD5E4-0x00000001864AD62C
	public static AKRESULT DynamicSequencePause(uint in_playingID) => default; // 0x00000001864AD688-0x00000001864AD6E4
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864AD6E4-0x00000001864AD73C
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration) => default; // 0x00000001864AD73C-0x00000001864AD784
	public static AKRESULT DynamicSequenceResume(uint in_playingID) => default; // 0x00000001864ACD84-0x00000001864ACDCC
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B5DAC-0x00000001864B5E08
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration) => default; // 0x00000001864B5E08-0x00000001864B5E68
	public static AKRESULT DynamicSequenceStop(uint in_playingID) => default; // 0x00000001864ACE14-0x00000001864ACE74
	public static AKRESULT DynamicSequenceBreak(uint in_playingID) => default; // 0x00000001864ACE74-0x00000001864ACF00
	public static AKRESULT Seek(uint in_playingID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001864AD784-0x00000001864AD7CC
	public static AKRESULT Seek(uint in_playingID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x0000000184A84CF0-0x0000000184A84D40
	public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration) {
		out_uTime = default;
		out_uDuration = default;
		return default;
	} // 0x00000001864AE208-0x00000001864AE25C
	public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID) => default; // 0x00000001864AF9F8-0x00000001864AFA68
	public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID) => default; // 0x0000000184A84A90-0x0000000184A84B10
	public static bool IsInitialized() => default; // 0x00000001864AEF04-0x00000001864AEF88
	public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings) => default; // 0x00000001864AF084-0x00000001864AF0E0
	public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput) => default; // 0x00000001864AF038-0x00000001864AF084
	public static AkChannelConfig GetSpeakerConfiguration() => default; // 0x00000001864B7E94-0x00000001864B7EEC
	public static AKRESULT GetOutputDeviceConfiguration(ulong in_idOutput, AkChannelConfig io_channelConfig, Ak3DAudioSinkCapabilities io_capabilities) => default; // 0x00000001864B7E4C-0x00000001864B7E94
	public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput) {
		out_ePanningRule = default;
		return default;
	} // 0x00000001864AF924-0x00000001864AF998
	public static AKRESULT GetPanningRule(out int out_ePanningRule) {
		out_ePanningRule = default;
		return default;
	} // 0x00000001864AF998-0x00000001864AF9F8
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput) => default; // 0x00000001864B8D40-0x00000001864B8DB4
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule) => default; // 0x00000001864B8DB4-0x00000001864B8E14
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput) {
		out_fHeightAngle = default;
		return default;
	} // 0x00000001864B9038-0x00000001864B9088
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle) {
		out_fHeightAngle = default;
		return default;
	} // 0x00000001864B70E4-0x00000001864B7130
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput) => default; // 0x00000001864B6D28-0x00000001864B6D80
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle) => default; // 0x00000001864B429C-0x00000001864B42E8
	public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB) => default; // 0x0000000184597E40-0x0000000184597E90
	public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices) => default; // 0x00000001864B3D94-0x00000001864B3DF0
	public static AKRESULT SetJobMgrMaxActiveWorkers(uint in_jobType, uint in_uNewMaxActiveWorkers) => default; // 0x00000001864B3DF0-0x00000001864B3E3C
	public static AKRESULT RenderAudio(bool in_bAllowSyncRender) => default; // 0x00000001864B014C-0x00000001864B01A8
	public static AKRESULT RenderAudio() => default; // 0x0000000184CD8050-0x0000000184CD80A0
	public static AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath) => default; // 0x00000001864B1088-0x00000001864B11AC
	public static AKRESULT RegisterPluginDLL(string in_DllName) => default; // 0x0000000184BDEE40-0x0000000184BDEF90
	public static bool IsPluginRegistered(AkPluginType in_eType, uint in_ulCompanyID, uint in_ulPluginID) => default; // 0x000000018459A340-0x000000018459A450
	public static uint GetIDFromString(string in_pszString) => default; // 0x00000001864B1408-0x00000001864B147C
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) => default; // 0x00000001864B1BB8-0x00000001864B1CDC
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x00000001864B12F8-0x00000001864B1408
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864B19E0-0x00000001864B1ABC
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID) => default; // 0x00000001864B16FC-0x00000001864B1774
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) => default; // 0x00000001864ADCB4-0x00000001864ADD34
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x00000001864ADA80-0x00000001864ADAF8
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864AE06C-0x00000001864AE0DC
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID) => default; // 0x00000001864AD864-0x00000001864AD8C0
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) => default; // 0x00000001864ADE24-0x00000001864ADE7C
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864AD9FC-0x00000001864ADA80
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration) => default; // 0x00000001864ADDA8-0x00000001864ADE24
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID) => default; // 0x00000001864ADD34-0x00000001864ADDA8
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType) => default; // 0x00000001864AD8C0-0x00000001864AD920
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) => default; // 0x00000001864AD9A4-0x00000001864AD9FC
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B1CDC-0x00000001864B1E08
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration) => default; // 0x00000001864B2008-0x00000001864B2128
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID) => default; // 0x00000001864B1F58-0x00000001864B2008
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType) => default; // 0x00000001864B1EB0-0x00000001864B1F58
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID) => default; // 0x00000001864B9514-0x00000001864B9574
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864B94BC-0x00000001864B9514
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets) => default; // 0x00000001864B9474-0x00000001864B94BC
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts) => default; // 0x00000001864B9434-0x00000001864B9474
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_playingID) => default; // 0x00000001864B0A60-0x00000001864B0AC0
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID) => default; // 0x00000001864B0AC0-0x00000001864B0B20
	public static AKRESULT StopMIDIOnEvent(uint in_eventID) => default; // 0x00000001864B9CBC-0x00000001864B9D04
	public static AKRESULT StopMIDIOnEvent() => default; // 0x00000001864B9C70-0x00000001864B9CBC
	public static AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority) => default; // 0x00000001864AE2FC-0x00000001864AE35C
	public static AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority) => default; // 0x00000001864AE29C-0x00000001864AE2FC
	public static AKRESULT UnpinEventInStreamCache(uint in_eventID) => default; // 0x00000001864B52AC-0x00000001864B5328
	public static AKRESULT UnpinEventInStreamCache(string in_pszEventName) => default; // 0x00000001864B53A4-0x00000001864B5418
	public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull) {
		out_fPercentBuffered = default;
		out_bCachePinnedMemoryFull = default;
		return default;
	} // 0x00000001864B5780-0x00000001864B57E0
	public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull) {
		out_fPercentBuffered = default;
		out_bCachePinnedMemoryFull = default;
		return default;
	} // 0x00000001864B5524-0x00000001864B55A0
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001864B5164-0x00000001864B51D8
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001864B5CC4-0x00000001864B5D24
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition) => default; // 0x00000001864B59A4-0x00000001864B5A20
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001864B51D8-0x00000001864B524C
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001864B524C-0x00000001864B52AC
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition) => default; // 0x00000001864B5328-0x00000001864B53A4
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001864B54B0-0x00000001864B5524
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001864B5BCC-0x00000001864B5C2C
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent) => default; // 0x00000001864AC704-0x00000001864AC750
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001864AC7B8-0x00000001864AC804
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001864AC804-0x00000001864AC84C
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent) => default; // 0x00000001864AF864-0x00000001864AF8C4
	public static void CancelEventCallbackCookie(object in_pCookie) {} // 0x00000001864AF80C-0x00000001864AF864
	public static void CancelEventCallbackGameObject(ulong in_gameObjectID) {} // 0x00000001864AF8C4-0x00000001864AF924
	public static void CancelEventCallback(uint in_playingID) {} // 0x0000000184C9ED40-0x0000000184C9ED90
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate) {
		out_puPosition = default;
		return default;
	} // 0x00000001864B92B0-0x00000001864B92F0
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition) {
		out_puPosition = default;
		return default;
	} // 0x00000001864B95B4-0x00000001864B9610
	public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering) {
		out_buffering = default;
		out_bIsBuffering = default;
		return default;
	} // 0x00000001864B9610-0x00000001864B9668
	public static void StopAll(ulong in_gameObjectID) {} // 0x00000001864B9668-0x00000001864B96B0
	public static void StopAll() {} // 0x00000001864AE134-0x00000001864AE1A4
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) {} // 0x0000000184733A90-0x0000000184733B00
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration) {} // 0x00000001864AE0DC-0x00000001864AE134
	public static void StopPlayingID(uint in_playingID) {} // 0x00000001864B8BC8-0x00000001864B8C10
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) {} // 0x00000001864B09D4-0x00000001864B0A20
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration) {} // 0x00000001864AE25C-0x00000001864AE29C
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID) {} // 0x00000001864B5E68-0x00000001864B5EF8
	public static void SetRandomSeed(uint in_uSeed) {} // 0x00000001864B9D04-0x00000001864B9D44
	public static void MuteBackgroundMusic(bool in_bMute) {} // 0x00000001864B73A0-0x00000001864B7430
	public static bool GetBackgroundMusicMute() => default; // 0x00000001851E7670-0x00000001851E7710
	public static AKRESULT SendPluginCustomGameData(uint in_busID, ulong in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes) => default; // 0x00000001864B77AC-0x00000001864B7820
	public static AKRESULT UnregisterAllGameObj() => default; // 0x00000001864B7430-0x00000001864B74C0
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags) => default; // 0x00000001864B7534-0x00000001864B75BC
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) => default; // 0x00000001864B74C0-0x00000001864B7534
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions) => default; // 0x0000000184A7C920-0x0000000184A7C980
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags) => default; // 0x00000001864B6344-0x00000001864B63A0
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) => default; // 0x00000001864AC934-0x00000001864AC974
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions) => default; // 0x00000001864B6064-0x00000001864B60C0
	public static AKRESULT SetScalingFactor(ulong in_GameObjectID, float in_fAttenuationScalingFactor) => default; // 0x00000001864B0834-0x00000001864B0894
	public static AKRESULT SetDistanceProbe(ulong in_listenerGameObjectID, ulong in_distanceProbeGameObjectID) => default; // 0x00000001864B0780-0x00000001864B07DC
	public static AKRESULT ClearBanks() => default; // 0x00000001864B07DC-0x00000001864B0834
	public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority) => default; // 0x0000000184957EC0-0x0000000184957F10
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID, uint in_bankType) {
		out_bankID = default;
		return default;
	} // 0x00000001864B053C-0x00000001864B059C
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001864B04C8-0x00000001864B053C
	public static AKRESULT LoadBank(uint in_bankID, uint in_bankType) => default; // 0x00000001864B0294-0x00000001864B02F4
	public static AKRESULT LoadBank(uint in_bankID) => default; // 0x00000001864B02F4-0x00000001864B0368
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001864B06DC-0x00000001864B0780
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID, out uint out_bankType) {
		out_bankID = default;
		out_bankType = default;
		return default;
	} // 0x00000001864B0640-0x00000001864B06DC
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x0000000184CD88C0-0x0000000184CD8970
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID, out uint out_bankType) {
		out_bankID = default;
		out_bankType = default;
		return default;
	} // 0x0000000184CD80E0-0x0000000184CD8180
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, uint in_bankType) {
		out_bankID = default;
		return default;
	} // 0x00000001864B059C-0x00000001864B0640
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001864B0418-0x00000001864B04C8
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType) => default; // 0x00000001864B01F0-0x00000001864B0294
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864B0368-0x00000001864B0418
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001864B9AB8-0x00000001864B9B18
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, out uint out_bankType) {
		out_bankID = default;
		out_bankType = default;
		return default;
	} // 0x00000001864B9B78-0x00000001864B9BD4
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001864B9B18-0x00000001864B9B78
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, out uint out_bankType) {
		out_bankID = default;
		out_bankType = default;
		return default;
	} // 0x00000001864B9920-0x00000001864B9978
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, uint in_bankType) => default; // 0x00000001864B9978-0x00000001864B9A1C
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr) => default; // 0x00000001864B9BD4-0x00000001864B9C70
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, uint in_bankType) => default; // 0x0000000184CD8420-0x0000000184CD84D0
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr) => default; // 0x00000001864B9A1C-0x00000001864B9AB8
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType) => default; // 0x00000001864AC6B8-0x00000001864AC704
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864B2A00-0x00000001864B2A74
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType) => default; // 0x00000001864B2C20-0x00000001864B2C80
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864B2774-0x00000001864B27CC
	public static void CancelBankCallbackCookie(object in_pCookie) {} // 0x00000001864B2C80-0x00000001864B2CF0
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags, uint in_bankType) => default; // 0x00000001864B2B18-0x00000001864B2B74
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags) => default; // 0x00000001864B29A8-0x00000001864B2A00
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString) => default; // 0x00000001864B2B74-0x00000001864B2C20
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags, uint in_bankType) => default; // 0x00000001864B2A74-0x00000001864B2B18
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags) => default; // 0x00000001864B27CC-0x00000001864B2868
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID) => default; // 0x00000001864B2868-0x00000001864B2910
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType) => default; // 0x00000001864B26D4-0x00000001864B2774
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags) => default; // 0x00000001864B2910-0x00000001864B29A8
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864ACB08-0x00000001864ACB48
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType) => default; // 0x00000001864B2FA4-0x00000001864B31B4
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags) => default; // 0x00000001864B2CF0-0x00000001864B2D50
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864B2D50-0x00000001864B2FA4
	public static AKRESULT ClearPreparedEvents() => default; // 0x0000000184CD8810-0x0000000184CD88C0
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent) => default; // 0x00000001864B7130-0x00000001864B719C
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent) => default; // 0x00000001864B9F88-0x00000001864B9FF4
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864B322C-0x00000001864B3458
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864B31B4-0x00000001864B322C
	public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings) => default; // 0x00000001864B3518-0x00000001864B3780
	public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings) => default; // 0x00000001864B3458-0x00000001864B3518
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs) => default; // 0x00000001864AC234-0x00000001864AC290
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs) => default; // 0x00000001864B415C-0x00000001864B41B8
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864AC1E8-0x00000001864AC234
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001864B3EA4-0x00000001864B3EF0
	public static AKRESULT AddListener(ulong in_emitterGameObj, ulong in_listenerGameObj) => default; // 0x00000001864B4428-0x00000001864B4474
	public static AKRESULT RemoveListener(ulong in_emitterGameObj, ulong in_listenerGameObj) => default; // 0x00000001864B6DF4-0x00000001864B6E74
	public static AKRESULT AddDefaultListener(ulong in_listenerGameObj) => default; // 0x00000001864B6D80-0x00000001864B6DF4
	public static AKRESULT RemoveDefaultListener(ulong in_listenerGameObj) => default; // 0x00000001864B8508-0x00000001864B8590
	public static AKRESULT ResetListenersToDefault(ulong in_emitterGameObj) => default; // 0x00000001864B842C-0x00000001864B84A8
	public static AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets) => default; // 0x00000001848C0B90-0x00000001848C0C20
	public static AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig) => default; // 0x00000001864B84A8-0x00000001864B8508
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B89C4-0x00000001864B8A1C
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B83A0-0x00000001864B842C
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001864B8604-0x00000001864B8680
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID) => default; // 0x00000001864B8590-0x00000001864B8604
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value) => default; // 0x00000001864B8964-0x00000001864B89C4
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B8B6C-0x00000001864B8BC8
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B8070-0x00000001864B80F8
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001864B8184-0x00000001864B8200
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID) => default; // 0x0000000185905A80-0x0000000185905B10
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value) => default; // 0x00000001864B7FB0-0x00000001864B8010
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B80F8-0x00000001864B8184
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B8200-0x00000001864B827C
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration) => default; // 0x00000001864B827C-0x00000001864B82F0
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID) => default; // 0x00000001864B8010-0x00000001864B8070
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B4D14-0x00000001864B4D90
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B4C58-0x00000001864B4CCC
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration) => default; // 0x00000001864B4A3C-0x00000001864B4A9C
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID) => default; // 0x00000001864B4C00-0x00000001864B4C58
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B4CCC-0x00000001864B4D14
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B4A9C-0x00000001864B4B18
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001864B4B18-0x00000001864B4B8C
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID) => default; // 0x00000001864B47B8-0x00000001864B4818
	public static AKRESULT ResetRTPCValue(uint in_rtpcID) => default; // 0x00000001864B4FB4-0x00000001864B5010
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B4ED0-0x00000001864B4F1C
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B459C-0x00000001864B4614
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001864B4474-0x00000001864B44E4
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID) => default; // 0x00000001864B466C-0x00000001864B46C8
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName) => default; // 0x00000001864B44E4-0x00000001864B453C
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B46C8-0x00000001864B4744
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B4744-0x00000001864B47B8
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration) => default; // 0x00000001864B453C-0x00000001864B459C
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID) => default; // 0x00000001864B4614-0x00000001864B466C
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B8E70-0x00000001864B8ECC
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B8F54-0x00000001864B8FB4
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration) => default; // 0x00000001864B267C-0x00000001864B26D4
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID) => default; // 0x00000001864B2534-0x00000001864B2590
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, ulong in_gameObjectID) => default; // 0x00000001848A7C30-0x00000001848A7C90
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, ulong in_gameObjectID) => default; // 0x00000001864B8E14-0x00000001864B8E70
	public static AKRESULT PostTrigger(uint in_triggerID, ulong in_gameObjectID) => default; // 0x00000001864B6660-0x00000001864B66D0
	public static AKRESULT PostTrigger(string in_pszTrigger, ulong in_gameObjectID) => default; // 0x00000001864B6838-0x00000001864B6898
	public static AKRESULT SetState(uint in_stateGroup, uint in_state) => default; // 0x00000001864B5FAC-0x00000001864B6008
	public static AKRESULT SetState(string in_pszStateGroup, string in_pszState) => default; // 0x00000001864B6288-0x00000001864B62E4
	public static AKRESULT SetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues) => default; // 0x00000001864B62E4-0x00000001864B6344
	public static AKRESULT SetGameObjectOutputBusVolume(ulong in_emitterObjID, ulong in_listenerObjID, float in_fControlValue) => default; // 0x00000001864B7D90-0x00000001864B7DF0
	public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID) => default; // 0x00000001864B719C-0x00000001864B71F4
	public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID) => default; // 0x00000001864B71F4-0x00000001864B724C
	public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID) => default; // 0x00000001864B6170-0x00000001864B61D4
	public static AKRESULT SetOutputDeviceEffect(ulong in_outputDeviceID, uint in_uFXIndex, uint in_FXShareSetID) => default; // 0x00000001864B610C-0x00000001864B6170
	public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID) => default; // 0x00000001864B7960-0x00000001864B79D4
	public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID) => default; // 0x00000001864B724C-0x00000001864B72DC
	public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig) => default; // 0x00000001864B90D4-0x00000001864B9120
	public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig) => default; // 0x00000001864B9574-0x00000001864B95B4
	public static AKRESULT SetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel) => default; // 0x00000001864AC36C-0x00000001864AC3B8
	public static AKRESULT SetMultipleObstructionAndOcclusion(ulong in_EmitterID, ulong in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction) => default; // 0x00000001864AC314-0x00000001864AC36C
	public static AKRESULT StartOutputCapture(string in_CaptureFileName) => default; // 0x00000001864AF68C-0x00000001864AF6CC
	public static AKRESULT StopOutputCapture() => default; // 0x00000001864B9160-0x00000001864B91AC
	public static AKRESULT AddOutputCaptureMarker(string in_MarkerText) => default; // 0x00000001864B96F0-0x00000001864B9730
	public static AKRESULT AddOutputCaptureBinaryMarker(IntPtr in_pMarkerData, uint in_uMarkerDataSize) => default; // 0x00000001864B7CF4-0x00000001864B7D44
	public static uint GetSampleRate() => default; // 0x00000001864B7D44-0x00000001864B7D90
	public static AKRESULT StartProfilerCapture(string in_CaptureFileName) => default; // 0x00000001864B41B8-0x00000001864B4204
	public static AKRESULT StopProfilerCapture() => default; // 0x00000001864B434C-0x00000001864B43C0
	public static AKRESULT SetOfflineRenderingFrameTime(float in_fFrameTimeInSeconds) => default; // 0x00000001864B42E8-0x00000001864B434C
	public static AKRESULT SetOfflineRendering(bool in_bEnableOfflineRendering) => default; // 0x00000001864AEF88-0x00000001864AEFE0
	public static AKRESULT RemoveOutput(ulong in_idOutput) => default; // 0x00000001864AEFE0-0x00000001864AF038
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, out ulong out_pOutputDeviceId) {
		out_pOutputDeviceId = default;
		return default;
	} // 0x00000001864B6230-0x00000001864B6288
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId) => default; // 0x00000001864B61D4-0x00000001864B6230
	public static ulong GetOutputID(uint in_idShareset, uint in_idDevice) => default; // 0x00000001864AE704-0x00000001864AE790
	public static ulong GetOutputID(string in_szShareSet, uint in_idDevice) => default; // 0x0000000184A7A810-0x0000000184A7A8A0
	public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice) => default; // 0x00000001864B7DF0-0x00000001864B7E4C
	public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName) => default; // 0x0000000184A7A6F0-0x0000000184A7A740
	public static AKRESULT GetDeviceList(uint in_ulCompanyID, uint in_ulPluginID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) {
		io_maxNumDevices = default;
		return default;
	} // 0x00000001864B9844-0x00000001864B98A0
	public static AKRESULT GetDeviceList(uint in_audioDeviceShareSetID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) {
		io_maxNumDevices = default;
		return default;
	} // 0x00000001864B97B8-0x00000001864B9804
	public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume) => default; // 0x00000001864B9804-0x00000001864B9844
	public static AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice) => default; // 0x00000001864BA040-0x00000001864BA088
	public static AKRESULT Suspend(bool in_bRenderAnyway, bool in_bFadeOut) => default; // 0x00000001864BA088-0x00000001864BA0C8
	public static AKRESULT Suspend(bool in_bRenderAnyway) => default; // 0x00000001864AE35C-0x00000001864AE39C
	public static AKRESULT Suspend() => default; // 0x00000001864AF6CC-0x00000001864AF70C
	public static AKRESULT WakeupFromSuspend(uint in_uDelayMs) => default; // 0x00000001864BA1C8-0x00000001864BA208
	public static AKRESULT WakeupFromSuspend() => default; // 0x00000001864BA208-0x00000001864BA248
	public static uint GetBufferTick() => default; // 0x00000001864AC5B8-0x00000001864AC61C
	public static ulong GetSampleTick() => default; // 0x00000001864AC61C-0x00000001864AC670
	public static void AkMemGetCategoryStats(int in_poolId, AkMemCategroyStats out_poolStats) {} // 0x00000001864ACD38-0x00000001864ACD84
	public static void AkMemGetGlobalStats(AkMemGlobalStats out_stats) {} // 0x00000001864AEAC8-0x00000001864AEB08
	public static void StartProfileThreadUsage() {} // 0x00000001864AEA88-0x00000001864AEAC8
	public static ulong StopProfileThreadUsage() => default; // 0x00000001864AF1C8-0x00000001864AF23C
	public static void DumpToFile(string pszFilename) {} // 0x00000001864AF23C-0x00000001864AF2A0
	public static ulong GetGlobalUsed() => default; // 0x00000001864B0F0C-0x00000001864B0F8C
	public static ulong GetGlobalReserved() => default; // 0x00000001864B0D38-0x00000001864B0DB0
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate) => default; // 0x00000001864B0B90-0x00000001864B0C00
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo) => default; // 0x00000001864B0E58-0x00000001864B0EB4
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus) => default; // 0x00000001864B0EB4-0x00000001864B0F0C
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID) => default; // 0x00000001864B0B20-0x00000001864B0B90
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID) => default; // 0x00000001864B2344-0x00000001864B23C8
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID) => default; // 0x00000001864B2128-0x00000001864B21A4
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel) => default; // 0x00000001864B2420-0x00000001864B2494
	public static AKRESULT PostCodeVarArg(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, MsgContext msgContext) => default; // 0x00000001864B22E4-0x00000001864B2344
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus) => default; // 0x00000001864B23C8-0x00000001864B2420
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID) => default; // 0x00000001864B5050-0x00000001864B5090
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID) => default; // 0x00000001864AFD28-0x00000001864AFD68
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID) => default; // 0x00000001864B0894-0x00000001864B08E8
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel) => default; // 0x00000001864B0970-0x00000001864B09D4
	public static AKRESULT ResetTranslator() => default; // 0x00000001864B0928-0x00000001864B0970
	public static int GetTimeStamp() => default; // 0x00000001864B08E8-0x00000001864B0928
	public static void MonitorStreamMgrInit(AkStreamMgrSettings in_streamMgrSettings) {} // 0x00000001864AC564-0x00000001864AC5B8
	public static void MonitorStreamingDeviceInit(uint in_deviceID, AkDeviceSettings in_deviceSettings) {} // 0x00000001864B5090-0x00000001864B5104
	public static void MonitorStreamingDeviceDestroyed(uint in_deviceID) {} // 0x00000001864B5104-0x00000001864B5164
	public static void MonitorStreamMgrTerm() {} // 0x00000001864AE7EC-0x00000001864AE848
	public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties) {} // 0x00000001864AE790-0x00000001864AE7EC
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence) => default; // 0x00000001864AF2A0-0x00000001864AF304
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments) => default; // 0x00000001864AEBBC-0x00000001864AEC20
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue) {
		out_iValue = default;
		return default;
	} // 0x00000001864AF498-0x00000001864AF514
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue) {
		out_fValue = default;
		return default;
	} // 0x00000001864AF5B8-0x00000001864AF638
	public static AKRESULT GetPosition(ulong in_GameObjectID, AkWorldTransform out_rPosition) => default; // 0x00000001864AFB5C-0x00000001864AFBBC
	public static AKRESULT GetListenerPosition(ulong in_uListenerID, AkWorldTransform out_rPosition) => default; // 0x00000001864AFCC8-0x00000001864AFD28
	public static AKRESULT GetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) {
		out_rValue = default;
		return default;
	} // 0x00000001864AFAC4-0x00000001864AFB1C
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) {
		out_rValue = default;
		return default;
	} // 0x00000001864AFA68-0x00000001864AFAC4
	public static AKRESULT GetSwitch(uint in_switchGroup, ulong in_gameObjectID, out uint out_rSwitchState) {
		out_rSwitchState = default;
		return default;
	} // 0x00000001864AE8DC-0x00000001864AE94C
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, ulong in_GameObj, out uint out_rSwitchState) {
		out_rSwitchState = default;
		return default;
	} // 0x00000001864AE94C-0x00000001864AE9AC
	public static AKRESULT GetState(uint in_stateGroup, out uint out_rState) {
		out_rState = default;
		return default;
	} // 0x00000001864AEDE8-0x00000001864AEE5C
	public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState) {
		out_rState = default;
		return default;
	} // 0x00000001864B37FC-0x00000001864B3878
	public static AKRESULT GetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues) => default; // 0x00000001864B3780-0x00000001864B37FC
	public static AKRESULT GetGameObjectDryLevelValue(ulong in_EmitterID, ulong in_ListenerID, out float out_rfControlValue) {
		out_rfControlValue = default;
		return default;
	} // 0x00000001864AF390-0x00000001864AF3F4
	public static AKRESULT GetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel) {
		out_rfObstructionLevel = default;
		out_rfOcclusionLevel = default;
		return default;
	} // 0x00000001864AEB70-0x00000001864AEBBC
	public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos) => default; // 0x00000001864AED9C-0x00000001864AEDE8
	public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos) => default; // 0x00000001857740B0-0x0000000185774100
	public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo) => default; // 0x00000001864AEA40-0x00000001864AEA88
	public static bool GetIsGameObjectActive(ulong in_GameObjId) => default; // 0x00000001864AF168-0x00000001864AF1C8
	public static float GetMaxRadius(ulong in_GameObjId) => default; // 0x00000001864AE45C-0x00000001864AE4B8
	public static uint GetEventIDFromPlayingID(uint in_playingID) => default; // 0x00000001864AE4B8-0x00000001864AE514
	public static ulong GetGameObjectFromPlayingID(uint in_playingID) => default; // 0x00000001864AC0E8-0x00000001864AC134
	public static AKRESULT GetPlayingIDsFromGameObject(ulong in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs) => default; // 0x00000001864AC134-0x00000001864AC180
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue) {
		out_iValue = default;
		return default;
	} // 0x00000001864AC09C-0x00000001864AC0E8
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue) {
		out_fValue = default;
		return default;
	} // 0x00000001864AC8EC-0x00000001864AC934
	public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask) {} // 0x00000001864AC8A4-0x00000001864AC8EC
	public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask) {} // 0x00000001864AC84C-0x00000001864AC8A4
	public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask) {} // 0x00000001864AFFC0-0x00000001864B0008
	public static byte ChannelMaskToNumChannels(uint in_uChannelMask) => default; // 0x00000001864AFF78-0x00000001864AFFC0
	public static uint ChannelMaskFromNumChannels(uint in_uNumChannels) => default; // 0x00000001864AFF30-0x00000001864AFF78
	public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask) => default; // 0x00000001864AFEE8-0x00000001864AFF30
	public static bool HasSurroundChannels(uint in_uChannelMask) => default; // 0x00000001864AC670-0x00000001864AC6B8
	public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask) => default; // 0x00000001864B91EC-0x00000001864B9248
	public static bool HasSideAndRearChannels(uint in_uChannelMask) => default; // 0x00000001864BA698-0x00000001864BA6D8
	public static bool HasHeightChannels(uint in_uChannelMask) => default; // 0x00000001864BA6D8-0x00000001864BA718
	public static uint BackToSideChannels(uint in_uChannelMask) => default; // 0x00000001864BA7D8-0x00000001864BA818
	public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx) => default; // 0x00000001864BA798-0x00000001864BA7D8
	public static AKRESULT SetGameObjectRadius(ulong in_gameObjectID, float in_outerRadius, float in_innerRadius) => default; // 0x00000001864B407C-0x00000001864B40D8
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID, ulong in_gameObjectID) => default; // 0x00000001864B3F58-0x00000001864B3FB0
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID) => default; // 0x00000001864B4034-0x00000001864B407C
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name) => default; // 0x00000001864ACA28-0x00000001864ACA80
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, ulong in_gameObjectID) => default; // 0x00000001864ACA80-0x00000001864ACAC8
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID) => default; // 0x00000001864ACAC8-0x00000001864ACB08
	public static AKRESULT RemoveImageSource(uint in_srcID) => default; // 0x0000000184B697F0-0x0000000184B69840
	public static AKRESULT ClearImageSources(uint in_AuxBusID, ulong in_gameObjectID) => default; // 0x0000000184B67C30-0x0000000184B67C80
	public static AKRESULT ClearImageSources(uint in_AuxBusID) => default; // 0x0000000184B67B50-0x0000000184B67BA0
	public static AKRESULT ClearImageSources() => default; // 0x00000001864B4204-0x00000001864B4250
	public static AKRESULT RemoveGeometry(ulong in_SetID) => default; // 0x0000000184B68AE0-0x0000000184B68B50
	public static AKRESULT RemoveGeometryInstance(ulong in_GeometryInstanceID) => default; // 0x00000001864B4250-0x00000001864B429C
	public static AKRESULT RemoveRoom(ulong in_RoomID) => default; // 0x00000001864B66D0-0x00000001864B672C
	public static AKRESULT RemovePortal(ulong in_PortalID) => default; // 0x00000001864B9F3C-0x00000001864B9F88
	public static AKRESULT SetReverbZone(ulong in_ReverbZone, ulong in_ParentRoom, float in_transitionRegionWidth) => default; // 0x00000001854FF310-0x00000001854FF370
	public static AKRESULT RemoveReverbZone(ulong in_ReverbZone) => default; // 0x00000001854FF370-0x00000001854FF3D0
	public static AKRESULT SetGameObjectInRoom(ulong in_gameObjectID, ulong in_CurrentRoomID) => default; // 0x00000001864B709C-0x00000001864B70E4
	public static AKRESULT UnsetGameObjectInRoom(ulong in_gameObjectID) => default; // 0x0000000185500CE0-0x0000000185500D30
	public static AKRESULT SetReflectionsOrder(uint in_uReflectionsOrder, bool in_bUpdatePaths) => default; // 0x0000000185500C50-0x0000000185500CA0
	public static AKRESULT SetDiffractionOrder(uint in_uDiffractionOrder, bool in_bUpdatePaths) => default; // 0x00000001864B63A0-0x00000001864B63F8
	public static AKRESULT SetMaxEmitterRoomAuxSends(uint in_uMaxEmitterRoomAuxSends) => default; // 0x00000001864B646C-0x00000001864B64C8
	public static AKRESULT SetNumberOfPrimaryRays(uint in_uNbPrimaryRays) => default; // 0x00000001864B7EEC-0x00000001864B7F50
	public static AKRESULT SetLoadBalancingSpread(uint in_uNbFrames) => default; // 0x00000001864B68FC-0x00000001864B695C
	public static AKRESULT SetEarlyReflectionsAuxSend(ulong in_gameObjectID, uint in_auxBusID) => default; // 0x00000001864B7F50-0x00000001864B7FB0
	public static AKRESULT SetEarlyReflectionsVolume(ulong in_gameObjectID, float in_fSendVolume) => default; // 0x00000001864B3B78-0x00000001864B3BD4
	public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion) => default; // 0x00000001864B5010-0x00000001864B5050
	public static AKRESULT SetGameObjectToPortalObstruction(ulong in_gameObjectID, ulong in_PortalID, float in_fObstruction) => default; // 0x00000001864AE6B8-0x00000001864AE704
	public static AKRESULT SetPortalToPortalObstruction(ulong in_PortalID0, ulong in_PortalID1, float in_fObstruction) => default; // 0x00000001864AFE64-0x00000001864AFEE8
	public static AKRESULT QueryWetDiffraction(ulong in_portal, out float out_wetDiffraction) {
		out_wetDiffraction = default;
		return default;
	} // 0x00000001864AFDF0-0x00000001864AFE64
	public static AKRESULT ResetStochasticEngine() => default; // 0x00000001864AFD68-0x00000001864AFDB0
	public static uint GetDeviceIDFromName(string in_szToken) => default; // 0x00000001864AFDB0-0x00000001864AFDF0
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID, AkAudioDeviceState uDeviceStateMask) {
		out_uDeviceID = default;
		return default;
	} // 0x0000000185BAB830-0x0000000185BAB880
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID) {
		out_uDeviceID = default;
		return default;
	} // 0x00000001864B6540-0x00000001864B6580
	public static uint GetWindowsDeviceCount(AkAudioDeviceState uDeviceStateMask) => default; // 0x00000001864B6008-0x00000001864B6064
	public static uint GetWindowsDeviceCount() => default; // 0x00000001854FF1D0-0x00000001854FF230
	public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger) {} // 0x00000001854FF270-0x00000001854FF2D0
	public static void SetErrorLogger() {} // 0x00000001864B0048-0x00000001864B009C
	public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat) {} // 0x00000001864B98A0-0x00000001864B98E0
	public static AKRESULT Init(AkInitializationSettings settings) => default; // 0x00000001847A8040-0x00000001847A8090
	public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings) => default; // 0x0000000184C9EE30-0x0000000184C9EE80
	public static AKRESULT InitCommunication(AkCommunicationSettings settings) => default; // 0x0000000184B69230-0x0000000184B69290
	public static void Term() {} // 0x00000001864B60C0-0x00000001864B610C
	public static AKRESULT RegisterGameObjInternal(ulong in_GameObj) => default; // 0x00000001849580D0-0x0000000184958120
	public static AKRESULT UnregisterGameObjInternal(ulong in_GameObj) => default; // 0x0000000184955D80-0x0000000184955DE0
	public static AKRESULT RegisterGameObjInternal_WithName(ulong in_GameObj, string in_pszObjName) => default; // 0x0000000185809130-0x0000000185809180
	public static AKRESULT SetBasePath(string in_pszBasePath) => default; // 0x00000001864B6580-0x00000001864B65CC
	public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath) => default; // 0x00000001864AE3FC-0x00000001864AE45C
	public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID) {
		out_uPackageID = default;
		return default;
	} // 0x0000000184957D50-0x0000000184957DA0
	public static AKRESULT AddBasePath(string in_pszBasePath) => default; // 0x00000001864B98E0-0x00000001864B9920
	public static AKRESULT SetGameName(string in_GameName) => default; // 0x00000001845BF3E0-0x00000001845BF4C0
	public static string GetCurrentLanguage() => default; // 0x00000001864AF788-0x00000001864AF80C
	public static AKRESULT UnloadFilePackage(uint in_uPackageID) => default; // 0x00000001864AF70C-0x00000001864AF788
	public static AKRESULT UnloadAllFilePackages() => default; // 0x00000001864B703C-0x00000001864B709C
	public static AKRESULT SetObjectPosition(ulong in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top) => default; // 0x0000000184A7F8E0-0x0000000184A7F940
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate) => default; // 0x0000000184A7A660-0x0000000184A7A6B0
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions) => default; // 0x00000001864AC3B8-0x00000001864AC438
	public static AKRESULT SetListeners(ulong in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners) => default; // 0x00000001864AC48C-0x00000001864AC500
	public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners) => default; // 0x00000001864AC500-0x00000001864AC564
	public static uint GetNumOutputDevices(uint in_AudioDeviceShareSetID) => default; // 0x00000001864AC438-0x00000001864AC48C
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners) {
		out_pDeviceID = default;
		return default;
	} // 0x00000001864AE664-0x00000001864AE6B8
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs) {
		out_pDeviceID = default;
		return default;
	} // 0x00000001864AE514-0x00000001864AE568
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID) {
		out_pDeviceID = default;
		return default;
	} // 0x00000001864AE5BC-0x00000001864AE610
	public static AKRESULT AddOutput(AkOutputSettings in_Settings) => default; // 0x00000001864AE568-0x00000001864AE5BC
	public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings) {} // 0x00000001864AE610-0x00000001864AE664
	public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings) {} // 0x00000001864AECF4-0x00000001864AED34
	public static void GetDefaultMusicSettings(AkMusicSettings out_settings) {} // 0x00000001864AFB1C-0x00000001864AFB5C
	public static void GetDefaultInitSettings(AkInitSettings out_settings) {} // 0x00000001864B91AC-0x00000001864B91EC
	public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings) {} // 0x00000001864B9730-0x00000001864B9770
	public static uint GetMajorMinorVersion() => default; // 0x00000001864AF638-0x00000001864AF68C
	public static uint GetSubminorBuildVersion() => default; // 0x00000001864B9088-0x00000001864B90D4
	public static void StartResourceMonitoring() {} // 0x00000001864B92F0-0x00000001864B933C
	public static void StopResourceMonitoring() {} // 0x00000001864AC974-0x00000001864AC9B4
	public static void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary) {} // 0x00000001864B9FF4-0x00000001864BA040
	public static void StartDeviceCapture(ulong in_idOutputDeviceID) {} // 0x00000001864AE39C-0x00000001864AE3FC
	public static void StopDeviceCapture(ulong in_idOutputDeviceID) {} // 0x00000001864B8C10-0x00000001864B8CC8
	public static void ClearCaptureData() {} // 0x0000000184B681E0-0x0000000184B68270
	public static uint UpdateCaptureSampleCount(ulong in_idOutputDeviceID) => default; // 0x0000000184A7F890-0x0000000184A7F8E0
	public static uint GetCaptureSamples(ulong in_idOutputDeviceID, float[] out_pSamples, uint in_uBufferSize) => default; // 0x00000001864B9E88-0x00000001864B9ED4
	public static AKRESULT SetRoomPortal(ulong in_PortalID, ulong FrontRoom, ulong BackRoom, AkTransform Transform, AkExtent Extent, bool bEnabled, string in_pName) => default; // 0x00000001864B6A08-0x00000001864B6AF4
	public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, ulong GeometryInstanceID, string in_pName) => default; // 0x00000001864B695C-0x00000001864B6A08
	public static AKRESULT RegisterSpatialAudioListener(ulong in_gameObjectID) => default; // 0x00000001864B39F8-0x00000001864B3AA4
	public static AKRESULT UnregisterSpatialAudioListener(ulong in_gameObjectID) => default; // 0x00000001864B3878-0x00000001864B3924
	public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, Vector3[] Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges) => default; // 0x00000001864B0A20-0x00000001864B0A60
	public static AKRESULT SetGeometryInstance(ulong in_GeomInstanceID, AkTransform Transform, Vector3 Scale, ulong GeometrySetID, ulong RoomID, bool UseForReflectionAndDiffraction) => default; // 0x00000001864B0008-0x00000001864B0048
	public static AKRESULT QueryReflectionPaths(ulong in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize) {
		io_uArraySize = default;
		return default;
	} // 0x0000000184597BC0-0x0000000184597C10
	public static AKRESULT QueryDiffractionPaths(ulong in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize) {
		io_uArraySize = default;
		return default;
	} // 0x0000000185BB1260-0x0000000185BB12B0
	public static void PerformStreamMgrIO() {} // 0x000000018571C9B0-0x000000018571C9F0
	public static void HgMemShrink() {} // 0x00000001864AECAC-0x00000001864AECF4
	public static ulong HgGetGlobalMemoryUsed() => default; // 0x00000001864B9770-0x00000001864B97B8
	public static ulong HgGetGlobalMemoryReserved() => default; // 0x00000001856B51B0-0x00000001856B5200
	public static void InitScePad() {} // 0x00000001864B009C-0x00000001864B0104
	public static uint GetMMDeviceIdFromPadContainerInfo(int in_padHandle) => default; // 0x00000001864BA858-0x00000001864BA900
	public static string StringFromIntPtrString(IntPtr ptr) => default; // 0x00000001864AE1A4-0x00000001864AE208
	public static string StringFromIntPtrWString(IntPtr ptr) => default; // 0x00000001864B3CB4-0x00000001864B3D1C
	private static ulong InternalGameObjectHash(GameObject gameObject) => default; // 0x00000001864B3D1C-0x00000001864B3D94
	public static ulong GetAkGameObjectID(GameObject gameObject) => default; // 0x00000001864B9D44-0x00000001864B9D84
	public static AKRESULT RegisterGameObj(GameObject gameObject) => default; // 0x00000001864BA508-0x00000001864BA698
	public static AKRESULT RegisterGameObj(GameObject gameObject, string name) => default; // 0x00000001864B7AA8-0x00000001864B7BB4
	public static AKRESULT UnregisterGameObj(GameObject gameObject) => default; // 0x00000001864B7BB4-0x00000001864B7CF4
	public static void UnregisterAllGameObjects() {} // 0x0000000185492010-0x0000000185492020
	public static AKRESULT SetObjectPosition(GameObject gameObject, Transform transform) => default; // 0x00000001864ACF00-0x00000001864ACFF8
	public static AKRESULT SetObjectPosition(GameObject gameObject, float posX, float posY, float posZ, float frontX, float frontY, float frontZ, float topX, float topY, float topZ) => default; // 0x00000001864AD1A0-0x00000001864AD22C
	public static void PreGameObjectAPICall(GameObject gameObject, ulong id) {} // 0x00000001864B15B4-0x00000001864B16FC
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) => default; // 0x00000001864B1774-0x00000001864B18A8
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864B0F8C-0x00000001864B1088
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID) => default; // 0x00000001864B147C-0x00000001864B1518
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) => default; // 0x00000001864B11AC-0x00000001864B12F8
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x00000001864B18A8-0x00000001864B19E0
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864B1ABC-0x00000001864B1BB8
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID) => default; // 0x00000001864B1518-0x00000001864B15B4
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) => default; // 0x00000001864ADF24-0x00000001864ADFCC
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x00000001864ADC14-0x00000001864ADCB4
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001864ADB7C-0x00000001864ADC14
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID) => default; // 0x00000001864ADAF8-0x00000001864ADB7C
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) => default; // 0x00000001864ADE7C-0x00000001864ADF24
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864ADFCC-0x00000001864AE06C
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration) => default; // 0x00000001864AD7CC-0x00000001864AD864
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID) => default; // 0x00000001864AD920-0x00000001864AD9A4
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) => default; // 0x00000001864B1E08-0x00000001864B1EB0
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B93C0-0x00000001864B9434
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration) => default; // 0x00000001864B933C-0x00000001864B93C0
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID) => default; // 0x00000001864B5A20-0x00000001864B5AC0
	public static AKRESULT PostMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts) => default; // 0x00000001864B5418-0x00000001864B54B0
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID) => default; // 0x00000001864B5B48-0x00000001864B5BCC
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_playingID) => default; // 0x00000001864B56DC-0x00000001864B5780
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001864B5640-0x00000001864B56DC
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001864B5AC0-0x00000001864B5B48
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition) => default; // 0x00000001864B55A0-0x00000001864B5640
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001864B5C2C-0x00000001864B5CC4
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001864B5884-0x00000001864B5908
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition) => default; // 0x00000001864B57E0-0x00000001864B5884
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001864B5908-0x00000001864B59A4
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001864B5D24-0x00000001864B5DAC
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent) => default; // 0x00000001864AC750-0x00000001864AC7B8
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001864B9248-0x00000001864B92B0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001864B5EF8-0x00000001864B5FAC
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent) => default; // 0x00000001864B7700-0x00000001864B77AC
	public static void CancelEventCallbackGameObject(GameObject in_gameObjectID) {} // 0x00000001864B75BC-0x00000001864B7654
	public static void StopAll(GameObject in_gameObjectID) {} // 0x00000001864B7654-0x00000001864B7700
	public static AKRESULT SendPluginCustomGameData(uint in_busID, GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes) => default; // 0x00000001864B7820-0x00000001864B78B8
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) => default; // 0x00000001864B8CC8-0x00000001864B8D40
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions) => default; // 0x00000001864AC290-0x00000001864AC314
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) => default; // 0x00000001864B40D8-0x00000001864B415C
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions) => default; // 0x00000001864AC180-0x00000001864AC1E8
	public static AKRESULT SetScalingFactor(GameObject in_GameObjectID, float in_fAttenuationScalingFactor) => default; // 0x00000001864B3EF0-0x00000001864B3F58
	public static AKRESULT AddListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj) => default; // 0x00000001864B43C0-0x00000001864B4428
	public static AKRESULT RemoveListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj) => default; // 0x00000001864B6F10-0x00000001864B6FB4
	public static AKRESULT AddDefaultListener(GameObject in_listenerGameObj) => default; // 0x00000001864B6E74-0x00000001864B6F10
	public static AKRESULT RemoveDefaultListener(GameObject in_listenerGameObj) => default; // 0x00000001864B8ABC-0x00000001864B8B6C
	public static AKRESULT ResetListenersToDefault(GameObject in_emitterGameObj) => default; // 0x00000001864B8A1C-0x00000001864B8ABC
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets) => default; // 0x00000001864B8704-0x00000001864B879C
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig) => default; // 0x00000001864B8680-0x00000001864B8704
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B82F0-0x00000001864B83A0
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B879C-0x00000001864B8840
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001864B88C8-0x00000001864B8964
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID) => default; // 0x00000001864B8840-0x00000001864B88C8
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B4914-0x00000001864B49B4
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B4F1C-0x00000001864B4FB4
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001864B4818-0x00000001864B489C
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID) => default; // 0x00000001864B4B8C-0x00000001864B4C00
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B4E2C-0x00000001864B4ED0
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B4D90-0x00000001864B4E2C
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001864B49B4-0x00000001864B4A3C
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID) => default; // 0x00000001864B489C-0x00000001864B4914
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001864B8FB4-0x00000001864B9038
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001864B8ECC-0x00000001864B8F54
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001864B2590-0x00000001864B2604
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID) => default; // 0x00000001864B2604-0x00000001864B267C
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject in_gameObjectID) => default; // 0x00000001864B65CC-0x00000001864B6660
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, GameObject in_gameObjectID) => default; // 0x00000001864B67A4-0x00000001864B6838
	public static AKRESULT PostTrigger(uint in_triggerID, GameObject in_gameObjectID) => default; // 0x00000001864B78B8-0x00000001864B7960
	public static AKRESULT PostTrigger(string in_pszTrigger, GameObject in_gameObjectID) => default; // 0x00000001864B72DC-0x00000001864B73A0
	public static AKRESULT SetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues) => default; // 0x00000001864B0DB0-0x00000001864B0E58
	public static AKRESULT SetGameObjectOutputBusVolume(GameObject in_emitterObjID, GameObject in_listenerObjID, float in_fControlValue) => default; // 0x00000001864B0C00-0x00000001864B0CA0
	public static AKRESULT SetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel) => default; // 0x00000001864B0CA0-0x00000001864B0D38
	public static AKRESULT SetMultipleObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction) => default; // 0x00000001864B223C-0x00000001864B22E4
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus) => default; // 0x00000001864B2494-0x00000001864B2534
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID) => default; // 0x00000001864B21A4-0x00000001864B223C
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID) => default; // 0x00000001864AF304-0x00000001864AF390
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus) => default; // 0x00000001864AEC20-0x00000001864AECAC
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID) => default; // 0x00000001864AF514-0x00000001864AF5B8
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID) => default; // 0x00000001864AF3F4-0x00000001864AF498
	public static AKRESULT GetPosition(GameObject in_GameObjectID, AkTransform out_rPosition) => default; // 0x00000001864AFBBC-0x00000001864AFC40
	public static AKRESULT GetListenerPosition(GameObject in_uIndex, AkTransform out_rPosition) => default; // 0x00000001864AFC40-0x00000001864AFCC8
	public static AKRESULT GetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) {
		out_rValue = default;
		return default;
	} // 0x00000001864AE848-0x00000001864AE8DC
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) {
		out_rValue = default;
		return default;
	} // 0x00000001864AE9AC-0x00000001864AEA40
	public static AKRESULT GetSwitch(uint in_switchGroup, GameObject in_gameObjectID, out uint out_rSwitchState) {
		out_rSwitchState = default;
		return default;
	} // 0x00000001864AEE5C-0x00000001864AEF04
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, GameObject in_GameObj, out uint out_rSwitchState) {
		out_rSwitchState = default;
		return default;
	} // 0x00000001864AEB08-0x00000001864AEB70
	public static AKRESULT GetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues) => default; // 0x00000001864AED34-0x00000001864AED9C
	public static AKRESULT GetGameObjectDryLevelValue(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfControlValue) {
		out_rfControlValue = default;
		return default;
	} // 0x00000001864AF0E0-0x00000001864AF168
	public static AKRESULT GetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel) {
		out_rfObstructionLevel = default;
		out_rfOcclusionLevel = default;
		return default;
	} // 0x00000001864B6AF4-0x00000001864B6BAC
	public static bool GetIsGameObjectActive(GameObject in_GameObjId) => default; // 0x00000001864B3FB0-0x00000001864B4034
	public static float GetMaxRadius(GameObject in_GameObjId) => default; // 0x00000001864AC9B4-0x00000001864ACA28
	public static AKRESULT GetPlayingIDsFromGameObject(GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs) => default; // 0x00000001864B3AA4-0x00000001864B3B78
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_imageSourceName, uint in_AuxBusID, GameObject in_gameObjectID) => default; // 0x00000001864B672C-0x00000001864B67A4
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, GameObject in_gameObjectID) => default; // 0x00000001864B63F8-0x00000001864B646C
	public static AKRESULT ClearImageSources(uint in_AuxBusID, GameObject in_gameObjectID) => default; // 0x00000001864B64C8-0x00000001864B6540
	public static AKRESULT QueryReflectionPaths(GameObject in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize) {
		io_uArraySize = default;
		return default;
	} // 0x00000001864B3924-0x00000001864B39F8
	public static AKRESULT SetGameObjectInRoom(GameObject in_gameObjectID, ulong in_CurrentRoomID) => default; // 0x00000001864B3C4C-0x00000001864B3CB4
	public static AKRESULT SetEarlyReflectionsAuxSend(GameObject in_gameObjectID, uint in_auxBusID) => default; // 0x00000001864B9D84-0x00000001864B9DEC
	public static AKRESULT SetEarlyReflectionsVolume(GameObject in_gameObjectID, float in_fSendVolume) => default; // 0x00000001864B3BD4-0x00000001864B3C4C
	public static AKRESULT QueryDiffractionPaths(GameObject in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize) {
		io_uArraySize = default;
		return default;
	} // 0x00000001864B79D4-0x00000001864B7AA8
	public static AKRESULT RegisterGameObjInternal(GameObject in_GameObj) => default; // 0x00000001864B6FB4-0x00000001864B703C
	public static AKRESULT UnregisterGameObjInternal(GameObject in_GameObj) => default; // 0x00000001864B3E3C-0x00000001864B3EA4
	public static AKRESULT RegisterGameObjInternal_WithName(GameObject in_GameObj, string in_pszObjName) => default; // 0x00000001864B9ED4-0x00000001864B9F3C
	public static AKRESULT SetObjectPosition(GameObject in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top) => default; // 0x00000001856B5160-0x00000001856B51B0
	public static AKRESULT SetListeners(GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners) => default; // 0x0000000185492010-0x0000000185492020
	public static AKRESULT RegisterSpatialAudioListener(GameObject in_gameObjectID) => default; // 0x0000000185D6CBF0-0x0000000185D6CC90
	public static AKRESULT UnregisterSpatialAudioListener(GameObject in_gameObjectID) => default; // 0x0000000185A26510-0x0000000185A265A0
	public static string StringFromIntPtrOSString(IntPtr ptr) => default; // 0x00000001817C2F70-0x00000001817C2F80
}

public class AkThreadProperties : IDisposable // TypeDefIndex: 54206
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int nPriority { get => default; set {} } // 0x00000001864BACFC-0x00000001864BAD4C 0x00000001864BAE18-0x00000001864BAE6C
	public uint dwAffinityMask { get => default; set {} } // 0x00000001864BACAC-0x00000001864BACFC 0x00000001864BADC4-0x00000001864BAE18
	public uint uStackSize { get => default; set {} } // 0x00000001864BAD4C-0x00000001864BAD9C 0x00000001864BAE6C-0x00000001864BAEC0

	// Constructors
	internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40
	public AkThreadProperties() {} // 0x00000001864BAC5C-0x00000001864BACAC

	// Methods
	internal static IntPtr getCPtr(AkThreadProperties obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864BAD9C-0x00000001864BADC4
	~AkThreadProperties() {} // 0x00000001864BABE8-0x00000001864BAC5C
	public void Dispose() {} // 0x00000001864BAA84-0x00000001864BAAD4
	protected virtual void Dispose(bool disposing) {} // 0x00000001864BAAD4-0x00000001864BABE8
}

public class AkUnityPlatformSpecificSettings : IDisposable // TypeDefIndex: 54207
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	public AkUnityPlatformSpecificSettings() {} // Dummy constructor
	internal AkUnityPlatformSpecificSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000185FAFE30-0x0000000185FAFE40

	// Methods
	internal static IntPtr getCPtr(AkUnityPlatformSpecificSettings obj) => default; // 0x0000000186478A10-0x0000000186478A20
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001864BB094-0x00000001864BB0BC
	~AkUnityPlatformSpecificSettings() {} // 0x0000000185AE50D0-0x0000000185AE5120
	public void Dispose() {} // 0x00000001864BB044-0x00000001864BB094
	protected virtual void Dispose(bool disposing) {} // 0x0000000185AE5120-0x0000000185AE53D0
}

public class AkAndroidSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 54210
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 54209
	{
		// Fields
		public AudioAPI m_AudioAPI; // 0x50
		public bool m_RoundFrameSizeToHardwareSize; // 0x54
		public bool m_UseLowLatencyMode; // 0x55

		// Nested types
		public enum AudioAPI // TypeDefIndex: 54208
		{
			Default = -1,
			None = 0,
			AAudio = 1,
			OpenSL_ES = 2
		}

		// Constructors
		public PlatformAdvancedSettings() {} // 0x00000001813B51D0-0x00000001813B51E0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x00000001857030B0-0x0000000185703210
	}

	// Constructors
	public AkAndroidSettings() {} // 0x00000001813ECBC0-0x00000001813ECBD0

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x00000001813FF010-0x00000001813FF020
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000185492010-0x0000000185492020
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000185F8D460-0x0000000185F8D4B0
}

public static class AkAudioInputManager // TypeDefIndex: 54215
{
	// Fields
	private static bool initialized; // 0x00
	private static readonly Dictionary<uint, AudioSamplesDelegate> audioSamplesDelegates; // 0x08
	private static readonly Dictionary<uint, AudioFormatDelegate> audioFormatDelegates; // 0x10
	private static readonly AkAudioFormat audioFormat; // 0x18
	private static readonly AudioSamplesInteropDelegate audioSamplesDelegate; // 0x20
	private static readonly AudioFormatInteropDelegate audioFormatDelegate; // 0x28

	// Nested types
	public delegate void AudioFormatDelegate(uint playingID, AkAudioFormat format); // TypeDefIndex: 54211; 0x00000001864A8DC4-0x00000001864A8EC8

	public delegate void AudioFormatInteropDelegate(uint playingID, IntPtr format); // TypeDefIndex: 54212; 0x00000001864A8908-0x00000001864A89E0

	public delegate bool AudioSamplesDelegate(uint playingID, uint channelIndex, float[] samples); // TypeDefIndex: 54213; 0x00000001831C5680-0x00000001831C5690

	public delegate bool AudioSamplesInteropDelegate(uint playingID, [In, Out] float[] samples, uint channelIndex, uint frames); // TypeDefIndex: 54214; 0x00000001831C5680-0x00000001831C5690

	// Constructors
	static AkAudioInputManager() {} // 0x00000001864BBBD0-0x00000001864BBD00

	// Methods
	public static uint PostAudioInputEvent(uint akEventID, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null) => default; // 0x00000001864BBD00-0x00000001864BBDC8
	public static uint PostAudioInputEvent(string akEventName, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null) => default; // 0x00000001817E31E0-0x00000001817E3200
	private static bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames) => default; // 0x00000001864BBB40-0x00000001864BBBD0
	private static void InternalAudioFormatDelegate(uint playingID, IntPtr format) {} // 0x00000001864BBBD0-0x00000001864BBD00
	private static void TryInitialize() {} // 0x00000001864BBE78-0x00000001864BBF40
	private static void AddPlayingID(uint playingID, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate) {} // 0x00000001817B21C0-0x00000001817B21E0
	private static void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo) {} // 0x00000001864BBDC8-0x00000001864BBE78
}

public class AkBasePathGetter // TypeDefIndex: 54216
{
	// Fields
	public static readonly string DefaultBasePath; // 0x00
	private static bool _IsWwiseProjectAvailable_k__BackingField; // 0x08
	private string _SoundBankBasePath_k__BackingField; // 0x10
	private string _PersistentDataPath_k__BackingField; // 0x18
	private static string _WwiseProjectFullPath_k__BackingField; // 0x10
	private static AkBasePathGetter Instance; // 0x18

	// Properties
	public static bool IsWwiseProjectAvailable { get; private set; } // 0x00000001864A99FC-0x00000001864A9A4C 0x00000001864A9A9C-0x00000001864A9AF0
	public string SoundBankBasePath { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	public string PersistentDataPath { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	public static string WwiseProjectFullPath { get; private set; } // 0x00000001864A9A4C-0x00000001864A9A9C 0x00000001864A9AF0-0x00000001864A9B50

	// Constructors
	public AkBasePathGetter() {} // 0x0000000185492010-0x0000000185492020
	static AkBasePathGetter() {} // 0x0000000185F3B630-0x0000000185F3B6D0

	// Methods
	public static string GetPlatformName() => default; // 0x00000001854FF880-0x00000001854FF8B0
	public static string GetPlatformBasePath(string platformName = "" /* Metadata: 0x02079BF0 */) => default; // 0x00000001864A983C-0x00000001864A992C
	public static AkBasePathGetter Get() => default; // 0x00000001864A992C-0x00000001864A99FC
	public static void Reset() {} // 0x0000000185F80090-0x0000000185F80100
	public void EvaluateGamePaths() {} // 0x00000001864A9730-0x00000001864A983C
}

public static class AkCallbackManager // TypeDefIndex: 54225
{
	// Fields
	private static readonly AkEventCallbackInfo AkEventCallbackInfo; // 0x00
	private static readonly AkDynamicSequenceItemCallbackInfo AkDynamicSequenceItemCallbackInfo; // 0x08
	private static readonly AkMIDIEventCallbackInfo AkMIDIEventCallbackInfo; // 0x10
	private static readonly AkMarkerCallbackInfo AkMarkerCallbackInfo; // 0x18
	private static readonly AkDurationCallbackInfo AkDurationCallbackInfo; // 0x20
	private static readonly AkMusicSyncCallbackInfo AkMusicSyncCallbackInfo; // 0x28
	private static readonly AkMusicPlaylistCallbackInfo AkMusicPlaylistCallbackInfo; // 0x30
	private static readonly AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo; // 0x38
	private static readonly AkMonitoringCallbackInfo AkMonitoringCallbackInfo; // 0x40
	private static readonly AkBankCallbackInfo AkBankCallbackInfo; // 0x48
	private static readonly SimplePool<EventCallbackPackage> s_EventCallbackPackagePool; // 0x50
	private static readonly SimplePool<BankCallbackPackage> s_BankCallbackPackagePool; // 0x58
	private static readonly Dictionary<int, BankCallbackPackage> s_mapBankCallbacks; // 0x60
	private static readonly Dictionary<int, EventCallbackPackage> s_mapEventCallbacks; // 0x68
	private static EventCallbackPackage s_lastAddedEventPackage; // 0x70
	private static MonitoringCallback m_MonitoringCB; // 0x78
	private static BGMCallbackPackage ms_sourceChangeCallbackPkg; // 0x80

	// Properties
	public static int bnkCallbackCount { get; } // 0x00000001832D8120-0x00000001832D8140 
	public static int evtCallbackCount { get; } // 0x00000001864BC088-0x00000001864BC144 

	// Nested types
	public delegate void EventCallback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info); // TypeDefIndex: 54217; 0x00000001864AA8C0-0x00000001864AA920

	public delegate void MonitoringCallback(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg); // TypeDefIndex: 54218; 0x00000001864A9F98-0x00000001864AA264

	public delegate void BankCallback(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie); // TypeDefIndex: 54219; 0x0000000185C4D840-0x0000000185C4D8B0

	public class EventCallbackPackage // TypeDefIndex: 54220
	{
		// Fields
		public EventCallback callback; // 0x10
		public object cookie; // 0x18
		public uint playingID; // 0x20

		// Constructors
		public EventCallbackPackage() {} // 0x0000000184596EC0-0x00000001845970C0

		// Methods
		internal static void Recycle(EventCallbackPackage inPkg) {} // 0x00000001864A9F48-0x00000001864A9F98
		public static EventCallbackPackage Create(EventCallback inCb, object inCookie, ref uint ioFlags) => default; // 0x0000000184598010-0x0000000184599270
	}

	public class BankCallbackPackage // TypeDefIndex: 54221
	{
		// Fields
		public BankCallback callback; // 0x10
		public object cookie; // 0x18

		// Constructors
		public BankCallbackPackage() {} // 0x0000000184CD6F70-0x0000000184CD7000

		// Methods
		public static BankCallbackPackage Create(BankCallback inCb, object inCookie) => default; // 0x0000000184597470-0x0000000184597BC0
		public static void Recycle(BankCallbackPackage pkg) {} // 0x0000000185143D40-0x0000000185144290
	}

	private class SimplePool<T> // TypeDefIndex: 54222
		where T : new()
	{
		// Fields
		private readonly T[] m_pool;
		private readonly int m_poolSize;
		private int m_poolIndex;

		// Constructors
		public SimplePool() {} // Dummy constructor
		public SimplePool(int poolSize) {} // 0x0000000181A578C0-0x0000000181A578E0

		// Methods
		public T Alloc() => default; // 0x00000001864BC144-0x00000001864BC1CC
		public void Recycle(T obj) {} // 0x00000001864BB614-0x00000001864BB734
	}

	public delegate AKRESULT BGMCallback(bool in_bOtherAudioPlaying, object in_Cookie); // TypeDefIndex: 54223; 0x00000001817C0490-0x00000001817C04B0

	public class BGMCallbackPackage // TypeDefIndex: 54224
	{
		// Fields
		public BGMCallback m_Callback; // 0x10
		public object m_Cookie; // 0x18

		// Constructors
		public BGMCallbackPackage() {} // 0x0000000184CD73C0-0x0000000184CD7460
	}

	// Constructors
	static AkCallbackManager() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public static void CancelAllCallbacks() {} // 0x00000001864BB614-0x00000001864BB734
	public static void RemoveEventCallback(uint in_playingID) {} // 0x0000000184597350-0x0000000184597470
	public static void RemoveEventCallbackCookie(object in_cookie) {} // 0x000000018459A450-0x000000018459A5E0
	public static void RemoveBankCallback(object in_cookie) {} // 0x0000000185492010-0x0000000185492020
	public static void SetLastAddedPlayingID(uint in_playingID) {} // 0x0000000184CD8970-0x0000000184CD8A80
	public static void Init() {} // 0x00000001845972A0-0x0000000184597350
	public static void Term() {} // 0x0000000185492010-0x0000000185492020
	public static void SetMonitoringCallback(AkMonitorErrorLevel in_Level, MonitoringCallback in_CB) {}
	private static void SetLocalOutput(AkMonitorErrorLevel in_Level) {}
	public static void SetBGMCallback(BGMCallback in_CB, object in_cookie) {}
	public static void PostCallbacksNoInvoke() {} // 0x00000001864BBFC0-0x00000001864BC088
	public static int PostCallbacks() => default; // 0x0000000181B59400-0x0000000181B59410
	private static void _ProcessBankCallback(IntPtr pPackage, IntPtr pData) {} // 0x00000001864BBF40-0x00000001864BBFC0
	private static AkCallbackInfo _ProcessEventCallback(AkCallbackType eType, IntPtr pData) => default; // 0x0000000186477E54-0x0000000186477F84
}

public class AkBasePlatformSettings : ScriptableObject // TypeDefIndex: 54226
{
	// Properties
	public virtual AkInitializationSettings AkInitializationSettings { get => default; } // 0x0000000185500A60-0x0000000185500AB0 
	public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get => default; } // 0x0000000185500040-0x0000000185500090 
	public virtual string SoundBankPersistentDataPath { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	public virtual string SoundbankPath { get => default; } // 0x00000001864A9BA0-0x00000001864A9BF0 
	public virtual AkCommunicationSettings AkCommunicationSettings { get => default; } // 0x00000001864A9B50-0x00000001864A9BA0 
	public virtual uint MemoryAllocationSizeLimit { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	public virtual uint MemoryDebugLevel { get => default; } // 0x00000001813AE580-0x00000001813AE590 

	// Constructors
	public AkBasePlatformSettings() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
}

[Serializable]
public class AkCommonOutputSettings // TypeDefIndex: 54231
{
	// Fields
	public string m_AudioDeviceShareset; // 0x10
	public uint m_DeviceID; // 0x18
	public PanningRule m_PanningRule; // 0x1C
	public ChannelConfiguration m_ChannelConfig; // 0x20

	// Nested types
	public enum PanningRule // TypeDefIndex: 54227
	{
		Speakers = 0,
		Headphones = 1
	}

	[Serializable]
	public class ChannelConfiguration // TypeDefIndex: 54230
	{
		// Fields
		public ChannelConfigType m_ChannelConfigType; // 0x10
		public ChannelMask m_ChannelMask; // 0x14
		public uint m_NumberOfChannels; // 0x18

		// Nested types
		public enum ChannelConfigType // TypeDefIndex: 54228
		{
			Anonymous = 0,
			Standard = 1,
			Ambisonic = 2
		}

		public enum ChannelMask // TypeDefIndex: 54229
		{
			NONE = 0,
			FRONT_LEFT = 1,
			FRONT_RIGHT = 2,
			SETUP_STEREO = 3,
			FRONT_CENTER = 4,
			SETUP_MONO = 4,
			SETUP_3STEREO = 7,
			LOW_FREQUENCY = 8,
			SETUP_0POINT1 = 8,
			SETUP_2POINT1 = 11,
			SETUP_1POINT1 = 12,
			SETUP_3POINT1 = 15,
			BACK_LEFT = 16,
			BACK_RIGHT = 32,
			BACK_CENTER = 256,
			SETUP_SURROUND = 259,
			SIDE_LEFT = 512,
			SIDE_RIGHT = 1024,
			SETUP_4 = 1539,
			SETUP_DPL2 = 1539,
			SETUP_5 = 1543,
			SETUP_4POINT1 = 1547,
			SETUP_5POINT1 = 1551,
			SETUP_6 = 1587,
			SETUP_7 = 1591,
			SETUP_6POINT1 = 1595,
			SETUP_7POINT1 = 1599,
			TOP = 2048,
			HEIGHT_FRONT_LEFT = 4096,
			HEIGHT_FRONT_CENTER = 8192,
			HEIGHT_FRONT_RIGHT = 16384,
			SETUP_AURO_222 = 22019,
			SETUP_DOLBY_5_0_2 = 22023,
			SETUP_DOLBY_5_1_2 = 22031,
			SETUP_DOLBY_6_0_2 = 22067,
			SETUP_DOLBY_7_0_2 = 22071,
			SETUP_DOLBY_6_1_2 = 22075,
			SETUP_DOLBY_7_1_2 = 22079,
			HEIGHT_BACK_LEFT = 32768,
			HEIGHT_BACK_CENTER = 65536,
			HEIGHT_BACK_RIGHT = 131072,
			SETUP_HEIGHT_4 = 184320,
			SETUP_AURO_8 = 185859,
			SETUP_AURO_9 = 185863,
			SETUP_AURO_9POINT1 = 185871,
			SETUP_DOLBY_6_0_4 = 185907,
			SETUP_AURO_11_740 = 185911,
			SETUP_DOLBY_7_0_4 = 185911,
			SETUP_DOLBY_6_1_4 = 185915,
			SETUP_AURO_11POINT1_740 = 185919,
			SETUP_DOLBY_7_1_4 = 185919,
			SETUP_AURO_10 = 187911,
			SETUP_AURO_10POINT1 = 187919,
			SETUP_HEIGHT_5 = 192512,
			SETUP_AURO_11 = 196103,
			SETUP_AURO_11POINT1 = 196111,
			SETUP_AURO_13_751 = 196151,
			SETUP_AURO_13POINT1_751 = 196159,
			SETUP_HEIGHT_ALL = 258048,
			SETUP_ALL_SPEAKERS = 261951
		}

		// Constructors
		public ChannelConfiguration() {} // 0x00000001857035B0-0x0000000185703630

		// Methods
		public void CopyTo(AkChannelConfig config) {} // 0x00000001856B5B90-0x00000001856B5C30
	}

	// Constructors
	public AkCommonOutputSettings() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public void CopyTo(AkOutputSettings settings) {} // 0x00000001856B5D00-0x00000001856B5D40
}

[Serializable]
public class AkCommonUserSettings // TypeDefIndex: 54233
{
	// Fields
	public string m_BasePath; // 0x10
	public uint m_MaximumNumberOfPositioningPaths; // 0x18
	public uint m_CommandQueueSize; // 0x1C
	public uint m_SamplesPerFrame; // 0x20
	public AkCommonOutputSettings m_MainOutputSettings; // 0x28
	public float m_StreamingLookAheadRatio; // 0x30
	public uint m_SampleRate; // 0x34
	public ushort m_NumberOfRefillsInVoice; // 0x38
	public SpatialAudioSettings m_SpatialAudioSettings; // 0x40

	// Nested types
	[Serializable]
	public class SpatialAudioSettings // TypeDefIndex: 54232
	{
		// Fields
		public uint m_MaxSoundPropagationDepth; // 0x10
		public float m_MovementThreshold; // 0x14
		public uint m_NumberOfPrimaryRays; // 0x18
		public uint m_MaxReflectionOrder; // 0x1C
		public uint m_MaxDiffractionOrder; // 0x20
		public uint m_DiffractionOnReflectionsOrder; // 0x24
		public uint m_MaxEmitterRoomAuxSends; // 0x28
		public float m_MaxPathLength; // 0x2C
		public float m_CPULimitPercentage; // 0x30
		public bool m_EnableGeometricDiffractionAndTransmission; // 0x34
		public bool m_CalcEmitterVirtualPosition; // 0x35
		public uint m_LoadBalancingSpread; // 0x38

		// Constructors
		public SpatialAudioSettings() {} // 0x00000001847EB4F0-0x00000001847EB690
	}

	// Constructors
	public AkCommonUserSettings() {} // 0x0000000185D4BC50-0x0000000185D4BCA0

	// Methods
	protected static string GetPluginPath() => default; // 0x00000001856B4F60-0x00000001856B50A0
	public virtual void CopyTo(AkInitSettings settings) {} // 0x0000000185500F60-0x0000000185500F90
	public void CopyTo(AkMusicSettings settings) {} // 0x0000000185492010-0x0000000185492020
	public void CopyTo(AkStreamMgrSettings settings) {} // 0x0000000185492010-0x0000000185492020
	public virtual void CopyTo(AkDeviceSettings settings) {} // 0x0000000185500FD0-0x0000000185501000
	private void SetSampleRate(AkPlatformInitSettings settings) {} // 0x0000000185500F90-0x0000000185500FD0
	public virtual void CopyTo(AkPlatformInitSettings settings) {} // 0x0000000185500120-0x0000000185500290
	public virtual void CopyTo(AkSpatialAudioInitSettings settings) {} // 0x0000000185492010-0x0000000185492020
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings) {} // 0x00000001864AAEA4-0x00000001864AAF04
	public virtual void Validate() {} // 0x0000000185703630-0x00000001857036C0
}

[Serializable]
public class AkCommonAdvancedSettings // TypeDefIndex: 54235
{
	// Fields
	public uint m_IOMemorySize; // 0x10
	public float m_TargetAutoStreamBufferLengthMs; // 0x14
	public bool m_UseStreamCache; // 0x18
	public uint m_MaximumPinnedBytesInCache; // 0x1C
	public bool m_EnableGameSyncPreparation; // 0x20
	public uint m_ContinuousPlaybackLookAhead; // 0x24
	public uint m_MonitorQueuePoolSize; // 0x28
	public uint m_MaximumHardwareTimeoutMs; // 0x2C
	public bool m_DebugOutOfRangeCheckEnabled; // 0x30
	public float m_DebugOutOfRangeLimit; // 0x34
	public string m_SoundBankPersistentDataPath; // 0x38
	public uint m_MemoryAllocationSizeLimit; // 0x40
	public uint m_MemoryDebugLevel; // 0x44
	public MemSpanCount m_MemorySpanCount; // 0x48

	// Nested types
	public enum MemSpanCount // TypeDefIndex: 54234
	{
		Small = 0,
		Medium = 1,
		Huge = 2
	}

	// Constructors
	public AkCommonAdvancedSettings() {} // 0x0000000185FAFE60-0x0000000185FAFEA0

	// Methods
	public virtual void CopyTo(AkDeviceSettings settings) {} // 0x00000001855010C0-0x0000000185501120
	public virtual void CopyTo(AkInitSettings settings) {} // 0x00000001854FE9D0-0x00000001854FEA50
	public virtual void CopyTo(AkPlatformInitSettings settings) {} // 0x0000000185492010-0x0000000185492020
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings) {} // 0x0000000185492010-0x0000000185492020
}

[Serializable]
public class AkCommonCommSettings // TypeDefIndex: 54236
{
	// Fields
	public uint m_PoolSize; // 0x10
	public static ushort DefaultDiscoveryBroadcastPort; // 0x00
	public ushort m_DiscoveryBroadcastPort; // 0x14
	public ushort m_CommandPort; // 0x16
	public ushort m_NotificationPort; // 0x18
	public bool m_InitializeSystemComms; // 0x1A
	public string m_NetworkName; // 0x20
	public AkCommunicationSettings.AkCommSystem m_commSystem; // 0x28

	// Constructors
	public AkCommonCommSettings() {} // 0x0000000185703040-0x00000001857030B0
	static AkCommonCommSettings() {} // 0x0000000185FA2670-0x0000000185FA26B0

	// Methods
	public virtual void CopyTo(AkCommunicationSettings settings) {} // 0x00000001864AAD30-0x00000001864AADC4
	public virtual void Validate() {} // 0x0000000185492010-0x0000000185492020
}

public abstract class AkCommonPlatformSettings : AkBasePlatformSettings // TypeDefIndex: 54237
{
	// Properties
	public override AkInitializationSettings AkInitializationSettings { get; } // 0x00000001854FFB30-0x00000001854FFCB0 
	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; } // 0x00000001854FFFF0-0x0000000185500040 
	public override string SoundBankPersistentDataPath { get; } // 0x00000001864AAE64-0x00000001864AAE84 
	public override string SoundbankPath { get; } // 0x00000001864AAE84-0x00000001864AAEA4 
	public override uint MemoryAllocationSizeLimit { get; } // 0x00000001864AAE24-0x00000001864AAE44 
	public override uint MemoryDebugLevel { get; } // 0x00000001864AAE44-0x00000001864AAE64 
	public override AkCommunicationSettings AkCommunicationSettings { get; } // 0x00000001864AADC4-0x00000001864AAE24 

	// Constructors
	protected AkCommonPlatformSettings() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0

	// Methods
	protected abstract AkCommonUserSettings GetUserSettings();
	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();
	protected abstract AkCommonCommSettings GetCommsSettings();
}

public class AkEnumFlagAttribute : PropertyAttribute // TypeDefIndex: 54238
{
	// Fields
	public System.Type Type; // 0x10

	// Constructors
	public AkEnumFlagAttribute() {} // Dummy constructor
	public AkEnumFlagAttribute(System.Type type) {} // 0x0000000184096E30-0x0000000184096EF0
}

public class AkLogger // TypeDefIndex: 54240
{
	// Fields
	private static AkLogger ms_Instance; // 0x00
	private ErrorLoggerInteropDelegate errorLoggerDelegate; // 0x10

	// Properties
	public static AkLogger Instance { get => default; } // 0x00000001864AB380-0x00000001864AB420 

	// Nested types
	public delegate void ErrorLoggerInteropDelegate(string message); // TypeDefIndex: 54239; 0x00000001864AB560-0x00000001864AB5B0

	// Constructors
	private AkLogger() {} // 0x00000001864AB4C0-0x00000001864AB560
	static AkLogger() {} // 0x00000001864BB614-0x00000001864BB734

	// Methods
	~AkLogger() {} // 0x00000001864AB420-0x00000001864AB4C0
	public void Init() {} // 0x00000001864AB150-0x00000001864AB1F0
	public static void WwiseInternalLogError(string message) {} // 0x0000000185BAB6A0-0x0000000185BAB710
	public static void Message(string message) {} // 0x000000018458A270-0x000000018458A300
	public static void Warning(string message) {} // 0x00000001833EEC70-0x00000001833EEC80
	public static void Error(string message) {} // 0x0000000185A264E0-0x0000000185A26510
}

public static class AkSoundEngineInitialization // TypeDefIndex: 54243
{
	// Fields
	public static InitializationDelegate s_initializationDelegate; // 0x00
	public static TerminationDelegate s_terminationDelegate; // 0x08

	// Nested types
	public delegate void InitializationDelegate(); // TypeDefIndex: 54241; 0x00000001854FF5B0-0x00000001854FF640

	public delegate void TerminationDelegate(); // TypeDefIndex: 54242; 0x00000001864BC330-0x00000001864BC3F4

	// Methods
	public static bool InitializeSoundEngine() => default; // 0x00000001864BB614-0x00000001864BB734
	private static void _TryInitSpatialAudio(ref AkBasePlatformSettings activePlatformSettings) {} // 0x00000001864BC330-0x00000001864BC3F4
	private static void _TryInitCommunication(ref AkBasePlatformSettings activePlatformSettings) {} // 0x00000001864BC320-0x00000001864BC330
	public static void TerminateSoundEngine(bool hgDeepTerm = false /* Metadata: 0x02079CA1 */) {} // 0x00000001864BC2FC-0x00000001864BC320
	private static void _WaitCallbacks(int retry) {} // 0x00000001864BB614-0x00000001864BB734
}

public class AkUtilities // TypeDefIndex: 54245
{
	// Nested types
	public class ShortIDGenerator // TypeDefIndex: 54244
	{
		// Fields
		private const uint s_prime32 = 16777619; // Metadata: 0x02079CA2
		private const uint s_offsetBasis32 = 2166136261; // Metadata: 0x02079CA6
		private static byte s_hashSize; // 0x00
		private static uint s_mask; // 0x04

		// Properties
		public static byte HashSize { get => default; set {} } // 0x00000001864BB0BC-0x00000001864BB128 0x00000001864BB254-0x00000001864BB534

		// Constructors
		static ShortIDGenerator() {} // 0x00000001864BB128-0x00000001864BB254
		public ShortIDGenerator() {} // 0x00000001864BC65C-0x00000001864BC668

		// Methods
		public static uint Compute(string in_name) => default; // 0x0000000185492010-0x0000000185492020
	}

	// Constructors
	public AkUtilities() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash) {} // 0x00000001864BC668-0x00000001864BC6B8
	public static void FixSlashes(ref string path) {} // 0x00000001864BC6B8-0x00000001864BC720
	public static string GetPathInPackage(string relativePath) => default; // 0x00000001864BC564-0x00000001864BC65C
}

public struct AkVector64 // TypeDefIndex: 54246
{
	// Fields
	public double X; // 0x00
	public double Y; // 0x08
	public double Z; // 0x10

	// Methods
	public void Zero() {} // 0x0000000185FAFEA0-0x0000000185FAFEB0
	public static implicit operator AkVector64(Vector3 vector) => default; // 0x0000000184B3C800-0x0000000184B3C830
}

public class AkWwiseInitializationSettings : AkCommonPlatformSettings // TypeDefIndex: 54249
{
	// Fields
	public List<string> PlatformSettingsNameList; // 0x18
	public List<PlatformSettings> PlatformSettingsList; // 0x20
	public List<string> InvalidReferencePlatforms; // 0x28
	public AkCommonUserSettings UserSettings; // 0x30
	public AkCommonAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40
	private static readonly string[] AllGlobalValues; // 0x00
	private static AkWwiseInitializationSettings m_Instance; // 0x08
	private static AkBasePlatformSettings m_ActivePlatformSettings; // 0x10

	// Properties
	public bool IsValid { get => default; } // 0x00000001857034D0-0x0000000185703550 
	public int Count { get => default; } // 0x0000000185703550-0x00000001857035B0 
	public static AkWwiseInitializationSettings Instance { get => default; set {} } // 0x0000000184E09410-0x0000000184E09470 0x00000001864BC4D0-0x00000001864BC564
	public static AkBasePlatformSettings ActivePlatformSettings { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 

	// Nested types
	public abstract class PlatformSettings : AkCommonPlatformSettings // TypeDefIndex: 54247
	{
		// Fields
		private List<string> IgnorePropertyNameList; // 0x18
		private List<string> GlobalPropertyNameList; // 0x20
		private HashSet<string> _GlobalPropertyHashSet; // 0x28

		// Properties
		public HashSet<string> GlobalPropertyHashSet { get; set; } // 0x00000001864BB534-0x00000001864BB594 0x00000001854FF8B0-0x00000001854FFA10

		// Constructors
		protected PlatformSettings() {} // 0x00000001813B51D0-0x00000001813B51E0

		// Methods
		public void IgnorePropertyValue(string propertyPath) {} // 0x00000001854FEF90-0x00000001854FEFF0
		public bool IsPropertyIgnored(string propertyPath) => default; // 0x00000001854FFA10-0x00000001854FFA50
		public void SetUseGlobalPropertyValue(string propertyPath, bool use) {} // 0x00000001813ECBC0-0x00000001813ECBD0
		public void SetGlobalPropertyValues(IEnumerable enumerable) {} // 0x00000001813FF010-0x00000001813FF020
		private bool IsUsingGlobalPropertyValue(string propertyPath) => default; // 0x00000001854FFA50-0x00000001854FFB30
	}

	public class CommonPlatformSettings : PlatformSettings // TypeDefIndex: 54248
	{
		// Fields
		public AkCommonUserSettings UserSettings; // 0x30
		public AkCommonAdvancedSettings AdvancedSettings; // 0x38
		public AkCommonCommSettings CommsSettings; // 0x40

		// Constructors
		public CommonPlatformSettings() {} // 0x00000001857F3210-0x00000001857F39F0

		// Methods
		protected override AkCommonUserSettings GetUserSettings() => default; // 0x00000001854FF740-0x00000001854FF880
		protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000185492010-0x0000000185492020
		protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000185702D50-0x0000000185702F30
	}

	// Constructors
	public AkWwiseInitializationSettings() {} // 0x00000001813FF010-0x00000001813FF020
	static AkWwiseInitializationSettings() {} // 0x0000000185702D40-0x0000000185702D50

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x0000000185702F30-0x0000000185703040
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000184E09B40-0x0000000184E09BE0
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000184E08FA0-0x0000000184E09410
	private static AkBasePlatformSettings GetPlatformSettings(string platformName) => default; // 0x0000000184A4EDC0-0x0000000184A4EDD0
	private void OnEnable() {} // 0x00000001813ECBC0-0x00000001813ECBD0
}

public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface> // TypeDefIndex: 54250
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001864A88C8-0x00000001864A8908 

	// Constructors
	public AkAcousticSurfaceArray() {} // Dummy constructor
	public AkAcousticSurfaceArray(int count) {} // 0x00000001864A8880-0x00000001864A88C8

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001864A8834-0x00000001864A8880
	protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001864A87E8-0x00000001864A8834
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other) {} // 0x00000001864A8784-0x00000001864A87E8
}

public class AkAuxSendArray : IDisposable // TypeDefIndex: 54251
{
	// Fields
	private const int MAX_COUNT = 4; // Metadata: 0x02079CAB
	private readonly int SIZE_OF_AKAUXSENDVALUE; // 0x10
	private IntPtr m_Buffer; // 0x18
	private int m_Count; // 0x20

	// Properties
	public AkAuxSendValue this[int index] { get => default; } // 0x00000001864A965C-0x00000001864A971C 
	public bool isFull { get => default; } // 0x00000001864A971C-0x00000001864A9730 

	// Constructors
	public AkAuxSendArray() {} // 0x00000001864A95E0-0x00000001864A965C

	// Methods
	public void Dispose() {} // 0x00000001864A9428-0x00000001864A9488
	~AkAuxSendArray() {} // 0x00000001864A9488-0x00000001864A94F8
	public void Reset() {} // 0x0000000185FAFE40-0x0000000185FAFE50
	public bool Add(ulong in_listenerGameObj, uint in_AuxBusID, float in_fValue) => default; // 0x00000001864A9198-0x00000001864A9248
	public bool Add(uint in_AuxBusID, float in_fValue) => default; // 0x00000001864A9248-0x00000001864A92E8
	public bool Contains(ulong in_listenerGameObj, uint in_AuxBusID) => default; // 0x00000001864A92E8-0x00000001864A9388
	public bool Contains(uint in_AuxBusID) => default; // 0x00000001864A9388-0x00000001864A9428
	public AKRESULT SetValues(ulong gameObject) => default; // 0x00000001864A956C-0x00000001864A95D0
	public AKRESULT GetValues(ulong gameObject) => default; // 0x00000001864A94F8-0x00000001864A956C
	public IntPtr GetBuffer() => default; // 0x0000000181377E40-0x0000000181377E50
	public int Count() => default; // 0x00000001813B88B0-0x00000001813B88C0
	private IntPtr _GetObjectPtr(int index) => default; // 0x00000001864A95D0-0x00000001864A95E0
}

public abstract class AkBaseArray<T> : IDisposable // TypeDefIndex: 54252
{
	// Fields
	private int _Capacity_k__BackingField;
	private IntPtr m_Buffer;

	// Properties
	public int Capacity { get; private set; }
	protected abstract int StructureSize { get; }
	public T this[int index] { get => default; set {} }

	// Constructors
	protected AkBaseArray() {} // Dummy constructor
	public AkBaseArray(int capacity) {}

	// Methods
	public void Dispose() {}
	~AkBaseArray() {}
	public virtual int Count() => default;
	protected virtual void DefaultConstructAtIntPtr(IntPtr address) {}
	protected virtual void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address) {}
	protected abstract T CreateNewReferenceFromIntPtr(IntPtr address);
	protected abstract void CloneIntoReferenceFromIntPtr(IntPtr address, T other);
	public IntPtr GetBuffer() => default;
	protected IntPtr GetObjectPtr(int index) => default;
}

public class AkChannelEmitterArray : IDisposable // TypeDefIndex: 54253
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20
	private uint _Count_k__BackingField; // 0x24

	// Properties
	public uint Count { get; private set; } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950

	// Constructors
	public AkChannelEmitterArray() {} // Dummy constructor
	public AkChannelEmitterArray(uint in_Count) {} // 0x00000001864AACD4-0x00000001864AAD30

	// Methods
	public void Dispose() {} // 0x00000001864AAC04-0x00000001864AAC64
	~AkChannelEmitterArray() {} // 0x00000001864AAC64-0x00000001864AACD4
	public void Reset() {} // 0x0000000185FAFE50-0x0000000185FAFE60
	public void Add(AkVector64 in_Pos, Vector3 in_Forward, Vector3 in_Top, uint in_ChannelMask) {} // 0x00000001864AA920-0x00000001864AAC04
}

public class AkDeviceDescriptionArray : AkBaseArray<AkDeviceDescription> // TypeDefIndex: 54254
{
	// Properties
	protected override int StructureSize { get => default; } // 0x0000000185774460-0x00000001857744B0 

	// Constructors
	public AkDeviceDescriptionArray() {} // Dummy constructor
	public AkDeviceDescriptionArray(int count) {} // 0x0000000184A7A940-0x0000000184A7A990

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001858C16C0-0x00000001858C1710
	protected override AkDeviceDescription CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001859E2590-0x00000001859E25E0
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDeviceDescription other) {} // 0x00000001864AAF04-0x00000001864AAF68
}

public class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo> // TypeDefIndex: 54255
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001864AB060-0x00000001864AB0A0 

	// Constructors
	public AkDiffractionPathInfoArray() {} // Dummy constructor
	public AkDiffractionPathInfoArray(int count) {} // 0x00000001864AB018-0x00000001864AB060

	// Methods
	protected override AkDiffractionPathInfo CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001864AAFCC-0x00000001864AB018
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDiffractionPathInfo other) {} // 0x00000001864AAF68-0x00000001864AAFCC
}

public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo> // TypeDefIndex: 54256
{
	// Properties
	protected override int StructureSize { get => default; } // 0x0000000185845850-0x00000001858458A0 

	// Constructors
	public AkExternalSourceInfoArray() {} // Dummy constructor
	public AkExternalSourceInfoArray(int count) {} // 0x000000018599B200-0x000000018599B250

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x0000000185EE0440-0x0000000185EE0490
	protected override void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address) {} // 0x00000001864AB104-0x00000001864AB150
	protected override AkExternalSourceInfo CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x000000018587CBB0-0x000000018587CC00
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other) {} // 0x00000001864AB0A0-0x00000001864AB104
}

public class AkMIDIPostArray // TypeDefIndex: 54257
{
	// Fields
	private readonly int m_Count; // 0x10
	private readonly int SIZE_OF; // 0x14
	private IntPtr m_Buffer; // 0x18

	// Properties
	public AkMIDIPost this[int index] { get => default; set {} } // 0x00000001864AB88C-0x00000001864AB958 0x00000001864AB958-0x00000001864ABA2C

	// Constructors
	public AkMIDIPostArray() {} // Dummy constructor
	public AkMIDIPostArray(int size) {} // 0x00000001864AB804-0x00000001864AB88C

	// Methods
	~AkMIDIPostArray() {} // 0x00000001864AB5B0-0x00000001864AB660
	public void PostOnEvent(uint in_eventID, GameObject gameObject) {} // 0x00000001864AB670-0x00000001864AB70C
	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count) {} // 0x00000001864AB70C-0x00000001864AB804
	public IntPtr GetBuffer() => default; // 0x0000000181377E40-0x0000000181377E50
	public int Count() => default; // 0x0000000181C0BBD0-0x0000000181C0BBE0
	private IntPtr GetObjectPtr(int index) => default; // 0x00000001864AB660-0x00000001864AB670
}

public class AkObjectInfoArray : AkBaseArray<AkObjectInfo> // TypeDefIndex: 54258
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001864ABB70-0x00000001864ABBB0 

	// Constructors
	public AkObjectInfoArray() {} // Dummy constructor
	public AkObjectInfoArray(int count) {} // 0x00000001864ABB28-0x00000001864ABB70

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001864ABADC-0x00000001864ABB28
	protected override AkObjectInfo CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001864ABA90-0x00000001864ABADC
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObjectInfo other) {} // 0x00000001864ABA2C-0x00000001864ABA90
}

public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues> // TypeDefIndex: 54259
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001864ABCF4-0x00000001864ABD34 

	// Constructors
	public AkObstructionOcclusionValuesArray() {} // Dummy constructor
	public AkObstructionOcclusionValuesArray(int count) {} // 0x00000001864ABCAC-0x00000001864ABCF4

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001864ABC60-0x00000001864ABCAC
	protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001864ABC14-0x00000001864ABC60
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other) {} // 0x00000001864ABBB0-0x00000001864ABC14
}

public class AkPositionArray : IDisposable // TypeDefIndex: 54260
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20
	private uint _Count_k__BackingField; // 0x24

	// Properties
	public uint Count { get; private set; } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950

	// Constructors
	public AkPositionArray() {} // Dummy constructor
	public AkPositionArray(uint in_Count) {} // 0x00000001851E7AA0-0x00000001851E7B10

	// Methods
	public void Dispose() {} // 0x00000001864ABD34-0x00000001864ABD94
	~AkPositionArray() {} // 0x00000001864ABD94-0x00000001864ABE04
	public void Reset() {} // 0x0000000185FAFE50-0x0000000185FAFE60
	public void Add(AkVector64 in_Pos, Vector3 in_Forward, Vector3 in_Top) {} // 0x00000001851E7850-0x00000001851E78C0
}

public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo> // TypeDefIndex: 54261
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001864ABEFC-0x00000001864ABF3C 

	// Constructors
	public AkReflectionPathInfoArray() {} // Dummy constructor
	public AkReflectionPathInfoArray(int count) {} // 0x00000001864ABEB4-0x00000001864ABEFC

	// Methods
	protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001864ABE68-0x00000001864ABEB4
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other) {} // 0x00000001864ABE04-0x00000001864ABE68
}

public class AkSourceSettingsArray : AkBaseArray<AkSourceSettings> // TypeDefIndex: 54262
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001864BAA44-0x00000001864BAA84 

	// Constructors
	public AkSourceSettingsArray() {} // Dummy constructor
	public AkSourceSettingsArray(int count) {} // 0x00000001864BA9FC-0x00000001864BAA44

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001864BA9B0-0x00000001864BA9FC
	protected override AkSourceSettings CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001864BA964-0x00000001864BA9B0
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkSourceSettings other) {} // 0x00000001864BA900-0x00000001864BA964
}

public class AkTriangleArray : AkBaseArray<AkTriangle> // TypeDefIndex: 54263
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001864BB004-0x00000001864BB044 

	// Constructors
	public AkTriangleArray() {} // Dummy constructor
	public AkTriangleArray(int count) {} // 0x00000001864BAFBC-0x00000001864BB004

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001864BAF70-0x00000001864BAFBC
	protected override AkTriangle CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001864BAF24-0x00000001864BAF70
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkTriangle other) {} // 0x00000001864BAEC0-0x00000001864BAF24
}

public static class AudioNativeHelper // TypeDefIndex: 54266
{
	// Fields
	private static IntPtr s_reusedTransformPtr; // 0x00

	// Nested types
	public struct AudioTriangleArrayNoGc : IDisposable // TypeDefIndex: 54264
	{
		// Fields
		private IntPtr m_buffer; // 0x00
		private int m_capacity; // 0x08
		private int m_elementSize; // 0x0C

		// Properties
		internal IntPtr Buffer { get => default; } // 0x00000001854FEE40-0x00000001854FEEC0 

		// Constructors
		public AudioTriangleArrayNoGc(int capacity) : this() {
			m_buffer = default;
			m_capacity = default;
			m_elementSize = default;
		} // 0x00000001864BBAD8-0x00000001864BBB40

		// Methods
		public void Set(int idx, ushort p0, ushort p1, ushort p2, ushort surface) {} // 0x00000001864BB958-0x00000001864BBAD8
		public void Dispose() {} // 0x0000000184123A50-0x0000000184123B20
	}

	public struct AudioAcousticSurfaceArrayNoGc : IDisposable // TypeDefIndex: 54265
	{
		// Fields
		private IntPtr m_buffer; // 0x00
		private int m_capacity; // 0x08
		private int m_elementSize; // 0x0C

		// Properties
		internal IntPtr Buffer { get => default; } // 0x0000000184B68CE0-0x0000000184B68EF0 

		// Constructors
		public AudioAcousticSurfaceArrayNoGc(int capacity) : this() {
			m_buffer = default;
			m_capacity = default;
			m_elementSize = default;
		} // 0x0000000185FA5060-0x0000000185FA50A0

		// Methods
		public void Set(int idx, float transmissionLoss, uint textureId) {} // 0x00000001834AFB60-0x00000001834AFB70
		public void Dispose() {} // 0x00000001841237B0-0x00000001841238D0
	}

	// Constructors
	static AudioNativeHelper() {} // 0x0000000184123970-0x00000001841239E0

	// Methods
	internal static void Init() {} // 0x0000000184125C40-0x0000000184125D80
	internal static void Term() {} // 0x00000001841239E0-0x0000000184123A50
	public static AKRESULT SetRoomPortal(ulong portalID, ulong frontRoom, ulong backRoom, Vector3 position, Vector3 orientationFront, Vector3 orientationTop, Vector3 extent, bool enabled, string portalName = "" /* Metadata: 0x02079CAC */) => default; // 0x00000001834AFB60-0x00000001834AFB70
	public static AKRESULT SetGeometry(ulong geoId, AudioTriangleArrayNoGc triangles, uint numTriangles, Vector3[] vertices, uint numVertices, AudioAcousticSurfaceArrayNoGc surfaces, uint numSurfaces, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges) => default; // 0x0000000184123670-0x0000000184123770
	public static AKRESULT SetGeometryInstance(ulong geomInstanceID, Vector3 pos, Quaternion rot, Vector3 scale, ulong geometrySetID, ulong roomID, bool useForReflectionAndDiffraction) => default; // 0x0000000184123BB0-0x0000000184123C50
}

public class AkiOSSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 54271
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 54270
	{
		// Fields
		public Category m_AudioSessionCategory; // 0x50
		public CategoryOptions m_AudioSessionCategoryOptions; // 0x54
		public Mode m_AudioSessionMode; // 0x58
		public uint NumSpatialAudioPointSources; // 0x5C
		public bool VerboseSystemOutput; // 0x60

		// Nested types
		public enum Category // TypeDefIndex: 54267
		{
			Ambient = 0,
			SoloAmbient = 1,
			PlayAndRecord = 2,
			Playback = 3
		}

		public enum CategoryOptions // TypeDefIndex: 54268
		{
			MixWithOthers = 1,
			DuckOthers = 2,
			AllowBluetooth = 4,
			DefaultToSpeaker = 8
		}

		public enum Mode // TypeDefIndex: 54269
		{
			Default = 0,
			VoiceChat = 1,
			GameChat = 2,
			VideoRecording = 3,
			Measurement = 4,
			MoviePlayback = 5,
			VideoChat = 6
		}

		// Constructors
		public PlatformAdvancedSettings() {} // 0x00000001813B51D0-0x00000001813B51E0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x0000000185703340-0x00000001857034D0
	}

	// Constructors
	public AkiOSSettings() {} // 0x00000001813ECBC0-0x00000001813ECBD0

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x00000001813FF010-0x00000001813FF020
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000185492010-0x0000000185492020
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000185F8D410-0x0000000185F8D460
}

public class AkMacSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 54273
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 54272
	{
		// Fields
		public uint NumSpatialAudioPointSources; // 0x50
		public bool VerboseSystemOutput; // 0x54

		// Constructors
		public PlatformAdvancedSettings() {} // 0x00000001813ECBC0-0x00000001813ECBD0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x00000001813B51D0-0x00000001813B51E0
	}

	// Constructors
	public AkMacSettings() {} // 0x0000000185FAFEB0-0x0000000185FAFEF0

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x00000001813FF010-0x00000001813FF020
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000185702D40-0x0000000185702D50
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000185492010-0x0000000185492020
}

public class AkPS5Settings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 54275
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 54274
	{
		// Fields
		public uint NumAudioOut2Ports; // 0x50
		public uint NumAudioOut2ObjectPorts; // 0x54
		public bool HwCodecLowLatencyMode; // 0x58
		public bool VorbisHwAcceleration; // 0x59
		public bool Enable3DAudioSync; // 0x5A
		public uint NumOperationsForHwMixing; // 0x5C
		public bool PlotQueueLevel; // 0x60

		// Constructors
		public PlatformAdvancedSettings() {} // 0x00000001813B51D0-0x00000001813B51E0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x0000000185703210-0x00000001857032E0
	}

	// Constructors
	public AkPS5Settings() {} // 0x00000001813ECBC0-0x00000001813ECBD0

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x00000001813FF010-0x00000001813FF020
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000185492010-0x0000000185492020
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x00000001857032E0-0x0000000185703340
}

public class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 54277
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 54276
	{
		// Fields
		public uint MaxSystemAudioObjects; // 0x50

		// Constructors
		public PlatformAdvancedSettings() {} // 0x00000001813ECBC0-0x00000001813ECBD0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x00000001813B51D0-0x00000001813B51E0
	}

	// Constructors
	public AkWindowsSettings() {} // 0x0000000185FAFEB0-0x0000000185FAFEF0

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x00000001813FF010-0x00000001813FF020
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000185702D40-0x0000000185702D50
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000185EE61F0-0x0000000185EE6220
}

