/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;
using UnityEngine.Serialization;

// Image 28: AK.Wwise.Unity.API.dll - Assembly: AK.Wwise.Unity.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 52823-53004
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class Ak3DAudioSinkCapabilities : IDisposable // TypeDefIndex: 52824
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkChannelConfig channelConfig { get => default; set {} } // 0x000000018427A7DC-0x000000018427A858 0x000000018427A9C8-0x000000018427AA30
	public uint uMaxSystemAudioObjects { get => default; set {} } // 0x000000018427A8A8-0x000000018427A8F8 0x000000018427AA84-0x000000018427AAD8
	public uint uAvailableSystemAudioObjects { get => default; set {} } // 0x000000018427A858-0x000000018427A8A8 0x000000018427AA30-0x000000018427AA84
	public bool bPassthrough { get => default; set {} } // 0x000000018427A78C-0x000000018427A7DC 0x000000018427A974-0x000000018427A9C8
	public bool bMultiChannelObjects { get => default; set {} } // 0x000000018427A73C-0x000000018427A78C 0x000000018427A920-0x000000018427A974

	// Constructors
	internal Ak3DAudioSinkCapabilities(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public Ak3DAudioSinkCapabilities() {} // 0x000000018427A6DC-0x000000018427A72C

	// Methods
	internal static IntPtr getCPtr(Ak3DAudioSinkCapabilities obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427A8F8-0x000000018427A920
	~Ak3DAudioSinkCapabilities() {} // 0x000000018427A668-0x000000018427A6DC
	public void Dispose() {} // 0x000000018427A618-0x000000018427A668
	protected virtual void Dispose(bool disposing) {} // 0x000000018427A504-0x000000018427A618
}

public class Ak3dData : IDisposable // TypeDefIndex: 52825
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkTransform xform { get => default; set {} } // 0x000000018427ADF0-0x000000018427AE6C 0x000000018427AF98-0x000000018427B000
	public float spread { get => default; set {} } // 0x000000018427AD50-0x000000018427ADA0 0x000000018427AEEC-0x000000018427AF44
	public float focus { get => default; set {} } // 0x000000018427AD00-0x000000018427AD50 0x000000018427AE94-0x000000018427AEEC
	public uint uEmitterChannelMask { get => default; set {} } // 0x000000018427ADA0-0x000000018427ADF0 0x000000018427AF44-0x000000018427AF98

	// Constructors
	internal Ak3dData(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public Ak3dData() {} // 0x000000018427ACB0-0x000000018427AD00

	// Methods
	internal static IntPtr getCPtr(Ak3dData obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427AE6C-0x000000018427AE94
	~Ak3dData() {} // 0x000000018427AC3C-0x000000018427ACB0
	public void Dispose() {} // 0x000000018427ABEC-0x000000018427AC3C
	protected virtual void Dispose(bool disposing) {} // 0x000000018427AAD8-0x000000018427ABEC
}

public enum Ak3DPositionType // TypeDefIndex: 52826
{
	AK_3DPositionType_Emitter = 0,
	AK_3DPositionType_EmitterWithAutomation = 1,
	AK_3DPositionType_ListenerWithAutomation = 2
}

public enum Ak3DSpatializationMode // TypeDefIndex: 52827
{
	AK_SpatializationMode_None = 0,
	AK_SpatializationMode_PositionOnly = 1,
	AK_SpatializationMode_PositionAndOrientation = 2
}

public class AkAcousticSurface : IDisposable // TypeDefIndex: 52828
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint textureID { get => default; set {} } // 0x000000018427B3DC-0x000000018427B42C 0x000000018427B4F8-0x000000018427B54C
	public float transmissionLoss { get => default; set {} } // 0x000000018427B42C-0x000000018427B47C 0x000000018427B54C-0x000000018427B5A4
	public string strName { get => default; set {} } // 0x000000018427B370-0x000000018427B3DC 0x000000018427B4A4-0x000000018427B4F8

	// Constructors
	internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkAcousticSurface() {} // 0x000000018427B320-0x000000018427B370

	// Methods
	internal static IntPtr getCPtr(AkAcousticSurface obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427B47C-0x000000018427B4A4
	~AkAcousticSurface() {} // 0x000000018427B26C-0x000000018427B2E0
	public void Dispose() {} // 0x000000018427B108-0x000000018427B158
	protected virtual void Dispose(bool disposing) {} // 0x000000018427B158-0x000000018427B26C
	public void Clear() {} // 0x000000018427B000-0x000000018427B050
	public void DeleteName() {} // 0x000000018427B0B8-0x000000018427B108
	public static int GetSizeOf() => default; // 0x000000018427B2E0-0x000000018427B320
	public void Clone(AkAcousticSurface other) {} // 0x000000018427B050-0x000000018427B0B8
}

public enum AkActionOnEventType // TypeDefIndex: 52829
{
	AkActionOnEventType_Stop = 0,
	AkActionOnEventType_Pause = 1,
	AkActionOnEventType_Resume = 2,
	AkActionOnEventType_Break = 3,
	AkActionOnEventType_ReleaseEnvelope = 4
}

public enum AkAttenuationCurveType // TypeDefIndex: 52830
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

public enum AkAudioDeviceState // TypeDefIndex: 52831
{
	AkDeviceState_Unknown = 0,
	AkDeviceState_Active = 1,
	AkDeviceState_Disabled = 2,
	AkDeviceState_NotPresent = 4,
	AkDeviceState_Unplugged = 8,
	AkDeviceState_All = 15
}

public class AkAudioFormat : IDisposable // TypeDefIndex: 52832
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uSampleRate { get => default; set {} } // 0x000000018427BB64-0x000000018427BBB4 0x000000018427BD90-0x000000018427BDE4
	public AkChannelConfig channelConfig { get => default; set {} } // 0x000000018427B9F8-0x000000018427BA74 0x000000018427BC2C-0x000000018427BC94
	public uint uBitsPerSample { get => default; set {} } // 0x000000018427BA74-0x000000018427BAC4 0x000000018427BC94-0x000000018427BCE8
	public uint uBlockAlign { get => default; set {} } // 0x000000018427BAC4-0x000000018427BB14 0x000000018427BCE8-0x000000018427BD3C
	public uint uTypeID { get => default; set {} } // 0x000000018427BBB4-0x000000018427BC04 0x000000018427BDE4-0x000000018427BE38
	public uint uInterleaveID { get => default; set {} } // 0x000000018427BB14-0x000000018427BB64 0x000000018427BD3C-0x000000018427BD90

	// Constructors
	internal AkAudioFormat(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkAudioFormat() {} // 0x000000018427B9A8-0x000000018427B9F8

	// Methods
	internal static IntPtr getCPtr(AkAudioFormat obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427BC04-0x000000018427BC2C
	~AkAudioFormat() {} // 0x000000018427B708-0x000000018427B77C
	public void Dispose() {} // 0x000000018427B5A4-0x000000018427B5F4
	protected virtual void Dispose(bool disposing) {} // 0x000000018427B5F4-0x000000018427B708
	public uint GetNumChannels() => default; // 0x000000018427B86C-0x000000018427B8BC
	public uint GetBitsPerSample() => default; // 0x000000018427B77C-0x000000018427B7CC
	public uint GetBlockAlign() => default; // 0x000000018427B7CC-0x000000018427B81C
	public uint GetTypeID() => default; // 0x000000018427B8BC-0x000000018427B90C
	public uint GetInterleaveID() => default; // 0x000000018427B81C-0x000000018427B86C
	public void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID) {} // 0x000000018427B90C-0x000000018427B9A8
}

public class AkAudioInterruptionCallbackInfo : IDisposable // TypeDefIndex: 52833
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public bool bEnterInterruption { get => default; } // 0x000000018427C060-0x000000018427C0B0 

	// Constructors
	internal AkAudioInterruptionCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkAudioInterruptionCallbackInfo() {} // 0x000000018427C010-0x000000018427C060

	// Methods
	internal static IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427C0B0-0x000000018427C0D8
	~AkAudioInterruptionCallbackInfo() {} // 0x000000018427BF9C-0x000000018427C010
	public void Dispose() {} // 0x000000018427BE38-0x000000018427BE88
	protected virtual void Dispose(bool disposing) {} // 0x000000018427BE88-0x000000018427BF9C
}

public enum AkAudioObjectDestination // TypeDefIndex: 52834
{
	eDefault = 0,
	eMainMix = 1,
	ePassthrough = 2,
	eSystemAudioObject = 3
}

public class AkAudioSettings : IDisposable // TypeDefIndex: 52835
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumSamplesPerFrame { get => default; set {} } // 0x000000018427C300-0x000000018427C350 0x000000018427C3C8-0x000000018427C41C
	public uint uNumSamplesPerSecond { get => default; set {} } // 0x000000018427C350-0x000000018427C3A0 0x000000018427C41C-0x000000018427C470

	// Constructors
	internal AkAudioSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkAudioSettings() {} // 0x000000018427C2B0-0x000000018427C300

	// Methods
	internal static IntPtr getCPtr(AkAudioSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427C3A0-0x000000018427C3C8
	~AkAudioSettings() {} // 0x000000018427C23C-0x000000018427C2B0
	public void Dispose() {} // 0x000000018427C1EC-0x000000018427C23C
	protected virtual void Dispose(bool disposing) {} // 0x000000018427C0D8-0x000000018427C1EC
}

public class AkAudioSourceChangeCallbackInfo : IDisposable // TypeDefIndex: 52836
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public bool bOtherAudioPlaying { get => default; } // 0x000000018427C698-0x000000018427C6E8 

	// Constructors
	internal AkAudioSourceChangeCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkAudioSourceChangeCallbackInfo() {} // 0x000000018427C648-0x000000018427C698

	// Methods
	internal static IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427C6E8-0x000000018427C710
	~AkAudioSourceChangeCallbackInfo() {} // 0x000000018427C5D4-0x000000018427C648
	public void Dispose() {} // 0x000000018427C470-0x000000018427C4C0
	protected virtual void Dispose(bool disposing) {} // 0x000000018427C4C0-0x000000018427C5D4
}

public class AkAuxSendValue : IDisposable // TypeDefIndex: 52837
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong listenerID { get => default; set {} } // 0x000000018427CB90-0x000000018427CBE0 0x000000018427CCB4-0x000000018427CD08
	public uint auxBusID { get => default; set {} } // 0x000000018427CAF0-0x000000018427CB40 0x000000018427CC08-0x000000018427CC5C
	public float fControlValue { get => default; set {} } // 0x000000018427CB40-0x000000018427CB90 0x000000018427CC5C-0x000000018427CCB4

	// Constructors
	public AkAuxSendValue() {} // Dummy constructor
	internal AkAuxSendValue(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0

	// Methods
	internal static IntPtr getCPtr(AkAuxSendValue obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427CBE0-0x000000018427CC08
	~AkAuxSendValue() {} // 0x000000018427C874-0x000000018427C8E8
	public void Dispose() {} // 0x000000018427C710-0x000000018427C760
	protected virtual void Dispose(bool disposing) {} // 0x000000018427C760-0x000000018427C874
	public void Set(ulong listener, uint id, float value) {} // 0x000000018427CA78-0x000000018427CAF0
	public bool IsSame(ulong listener, uint id) => default; // 0x000000018427C928-0x000000018427C98C
	public void Set(GameObject listener, uint id, float value) {} // 0x000000018427C9F8-0x000000018427CA78
	public bool IsSame(GameObject listener, uint id) => default; // 0x000000018427C98C-0x000000018427C9F8
	public static int GetSizeOf() => default; // 0x000000018427C8E8-0x000000018427C928
}

public class AkBankCallbackInfo : IDisposable // TypeDefIndex: 52838
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint bankID { get => default; } // 0x000000018269B090-0x000000018269B0F0 
	public IntPtr inMemoryBankPtr { get => default; } // 0x000000018269AF50-0x000000018269AFB0 
	public AKRESULT loadResult { get => default; } // 0x000000018269AFF0-0x000000018269B050 

	// Constructors
	internal AkBankCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkBankCallbackInfo() {} // 0x000000018427CD7C-0x000000018427CDCC

	// Methods
	internal static IntPtr getCPtr(AkBankCallbackInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842711F8-0x0000000184271220
	~AkBankCallbackInfo() {} // 0x000000018427CD08-0x000000018427CD7C
	public void Dispose() {} // 0x00000001832678F0-0x0000000183267950
	protected virtual void Dispose(bool disposing) {} // 0x0000000183267950-0x0000000183267E00
}

public enum AkBankContent // TypeDefIndex: 52839
{
	AkBankContent_StructureOnly = 0,
	AkBankContent_All = 1
}

public enum AkBankTypeEnum // TypeDefIndex: 52840
{
	AkBankType_User = 0,
	AkBankType_Event = 30,
	AkBankType_Bus = 31
}

public class AkBehavioralPositioningData : IDisposable // TypeDefIndex: 52841
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float center { get => default; set {} } // 0x000000018427CFF4-0x000000018427D044 0x000000018427D29C-0x000000018427D2F4
	public float panLR { get => default; set {} } // 0x000000018427D134-0x000000018427D184 0x000000018427D3F8-0x000000018427D450
	public float panBF { get => default; set {} } // 0x000000018427D094-0x000000018427D0E4 0x000000018427D348-0x000000018427D3A0
	public float panDU { get => default; set {} } // 0x000000018427D0E4-0x000000018427D134 0x000000018427D3A0-0x000000018427D3F8
	public float panSpatMix { get => default; set {} } // 0x000000018427D184-0x000000018427D1D4 0x000000018427D450-0x000000018427D4A8
	public Ak3DSpatializationMode spatMode { get => default; set {} } // 0x000000018427D224-0x000000018427D274 0x000000018427D4FC-0x000000018427D550
	public AkSpeakerPanningType panType { get => default; set {} } // 0x000000018427D1D4-0x000000018427D224 0x000000018427D4A8-0x000000018427D4FC
	public bool enableHeightSpread { get => default; set {} } // 0x000000018427D044-0x000000018427D094 0x000000018427D2F4-0x000000018427D348

	// Constructors
	internal AkBehavioralPositioningData(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkBehavioralPositioningData() {} // 0x000000018427CFA4-0x000000018427CFF4

	// Methods
	internal static IntPtr getCPtr(AkBehavioralPositioningData obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427D274-0x000000018427D29C
	~AkBehavioralPositioningData() {} // 0x000000018427CF30-0x000000018427CFA4
	public void Dispose() {} // 0x000000018427CEE0-0x000000018427CF30
	protected virtual void Dispose(bool disposing) {} // 0x000000018427CDCC-0x000000018427CEE0
}

public enum AkBusHierarchyFlags // TypeDefIndex: 52842
{
	AkBusHierarchy_Primary = 1,
	AkBusHierarchy_Secondary = 2,
	AkBusHierarchy_IsMaster = 128
}

public class AkCallbackInfo : IDisposable // TypeDefIndex: 52843
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pCookie { get => default; } // 0x000000018269F6C0-0x000000018269F720 
	public ulong gameObjID { get => default; } // 0x000000018269F7A0-0x000000018269F810 

	// Constructors
	internal AkCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkCallbackInfo() {} // 0x000000018427D5C8-0x000000018427D618

	// Methods
	internal static IntPtr getCPtr(AkCallbackInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184275DD4-0x0000000184275DFC
	~AkCallbackInfo() {} // 0x000000018427D550-0x000000018427D5C8
	public void Dispose() {} // 0x00000001832962F0-0x00000001832963B0
	protected virtual void Dispose(bool disposing) {} // 0x0000000183038DB0-0x0000000183039260
}

public class AkCallbackSerializer : IDisposable // TypeDefIndex: 52844
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkCallbackSerializer(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkCallbackSerializer() {} // 0x000000018427D924-0x000000018427D974

	// Methods
	internal static IntPtr getCPtr(AkCallbackSerializer obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427D974-0x000000018427D99C
	~AkCallbackSerializer() {} // 0x000000018427D7EC-0x000000018427D860
	public void Dispose() {} // 0x000000018427D688-0x000000018427D6D8
	protected virtual void Dispose(bool disposing) {} // 0x000000018427D6D8-0x000000018427D7EC
	public static AKRESULT Init() => default; // 0x0000000182A01D30-0x0000000182A01D70
	public static void Term() {} // 0x000000018427D8E4-0x000000018427D924
	public static IntPtr Lock() => default; // 0x000000018269D100-0x000000018269D170
	public static void Unlock() {} // 0x0000000183020340-0x0000000183020390
	public static void SetLocalOutput(uint in_uErrorLevel, string in_ip, uint in_port, string in_xmlFilePath, uint in_msXmlTranslatorTimeout, uint in_msWaapiTranslatorTimeout) {} // 0x000000018427D860-0x000000018427D8E4
	public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie) => default; // 0x000000018427D618-0x000000018427D688
}

public enum AkCallbackType // TypeDefIndex: 52845
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

public class AkChannelConfig : IDisposable // TypeDefIndex: 52846
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumChannels { get => default; set {} } // 0x0000000182690360-0x00000001826903B0 0x000000018427E154-0x000000018427E1A8
	public uint eConfigType { get => default; set {} } // 0x00000001826902D0-0x0000000182690320 0x000000018427E0AC-0x000000018427E100
	public uint uChannelMask { get => default; set {} } // 0x0000000182690240-0x0000000182690290 0x000000018427E100-0x000000018427E154

	// Constructors
	internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkChannelConfig() {} // 0x000000018427DFD0-0x000000018427E020
	public AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask) {} // 0x000000018427E020-0x000000018427E084

	// Methods
	internal static IntPtr getCPtr(AkChannelConfig obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427E084-0x000000018427E0AC
	~AkChannelConfig() {} // 0x0000000183805D40-0x0000000183805D90
	public void Dispose() {} // 0x000000018427DB20-0x000000018427DB70
	protected virtual void Dispose(bool disposing) {} // 0x0000000183805D90-0x00000001838060C0
	public static AkChannelConfig Standard(uint in_uChannelMask) => default; // 0x000000018427DF60-0x000000018427DFD0
	public static AkChannelConfig Anonymous(uint in_uNumChannels) => default; // 0x000000018427DA0C-0x000000018427DA7C
	public static AkChannelConfig Ambisonic(uint in_uNumChannels) => default; // 0x000000018427D99C-0x000000018427DA0C
	public static AkChannelConfig Object() => default; // 0x000000018427DBC0-0x000000018427DC2C
	public void Clear() {} // 0x000000018427DA7C-0x000000018427DACC
	public void SetStandard(uint in_uChannelMask) {} // 0x000000018427DF0C-0x000000018427DF60
	public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask) {} // 0x000000018427DEA8-0x000000018427DF0C
	public void SetAnonymous(uint in_uNumChannels) {} // 0x0000000182A4F3D0-0x0000000182A4F430
	public void SetAmbisonic(uint in_uNumChannels) {} // 0x000000018427DD64-0x000000018427DDB8
	public void SetObject() {} // 0x000000018427DDB8-0x000000018427DE08
	public void SetSameAsMainMix() {} // 0x000000018427DE08-0x000000018427DE58
	public void SetSameAsPassthrough() {} // 0x000000018427DE58-0x000000018427DEA8
	public bool IsValid() => default; // 0x000000018427DB70-0x000000018427DBC0
	public uint Serialize() => default; // 0x000000018427DD14-0x000000018427DD64
	public void Deserialize(uint in_uChannelConfig) {} // 0x000000018427DACC-0x000000018427DB20
	public AkChannelConfig RemoveLFE() => default; // 0x000000018427DCA0-0x000000018427DD14
	public AkChannelConfig RemoveCenter() => default; // 0x000000018427DC2C-0x000000018427DCA0
}

public enum AkChannelConfigType // TypeDefIndex: 52847
{
	AK_ChannelConfigType_Anonymous = 0,
	AK_ChannelConfigType_Standard = 1,
	AK_ChannelConfigType_Ambisonic = 2,
	AK_ChannelConfigType_Objects = 3,
	AK_ChannelConfigType_UseDeviceMain = 14,
	AK_ChannelConfigType_UseDevicePassthrough = 15
}

public class AkChannelEmitter : IDisposable // TypeDefIndex: 52848
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkWorldTransform position { get => default; set {} } // 0x000000018427E3EC-0x000000018427E468 0x000000018427E534-0x000000018427E59C
	public uint uInputChannels { get => default; set {} } // 0x000000018427E468-0x000000018427E4B8 0x000000018427E59C-0x000000018427E5F0
	public string padding { get => default; set {} } // 0x000000018427E380-0x000000018427E3EC 0x000000018427E4E0-0x000000018427E534

	// Constructors
	public AkChannelEmitter() {} // Dummy constructor
	internal AkChannelEmitter(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0

	// Methods
	internal static IntPtr getCPtr(AkChannelEmitter obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427E4B8-0x000000018427E4E0
	~AkChannelEmitter() {} // 0x000000018427E30C-0x000000018427E380
	public void Dispose() {} // 0x000000018427E2BC-0x000000018427E30C
	protected virtual void Dispose(bool disposing) {} // 0x000000018427E1A8-0x000000018427E2BC
}

public enum AkChannelOrdering // TypeDefIndex: 52849
{
	ChannelOrdering_Standard = 0,
	ChannelOrdering_RunTime = 1
}

public enum AkConnectionType // TypeDefIndex: 52850
{
	ConnectionType_Direct = 0,
	ConnectionType_GameDefSend = 1,
	ConnectionType_UserDefSend = 2,
	ConnectionType_ReflectionsSend = 3
}

public enum AkCurveInterpolation // TypeDefIndex: 52851
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

public class AkDeviceDescription : IDisposable // TypeDefIndex: 52852
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint idDevice { get => default; set {} } // 0x0000000183618130-0x0000000183618180 0x000000018427EF58-0x000000018427EFAC
	public string deviceName { get => default; set {} } // 0x000000018427EDCC-0x000000018427EE38 0x000000018427EEB0-0x000000018427EF04
	public AkAudioDeviceState deviceStateMask { get => default; set {} } // 0x000000018427EE38-0x000000018427EE88 0x000000018427EF04-0x000000018427EF58
	public bool isDefaultDevice { get => default; set {} } // 0x0000000183617F70-0x0000000183617FD0 0x000000018427EFAC-0x000000018427F000

	// Constructors
	internal AkDeviceDescription(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkDeviceDescription() {} // 0x000000018427ED7C-0x000000018427EDCC

	// Methods
	internal static IntPtr getCPtr(AkDeviceDescription obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427EE88-0x000000018427EEB0
	~AkDeviceDescription() {} // 0x00000001835A52A0-0x00000001835A52F0
	public void Dispose() {} // 0x000000018427ECEC-0x000000018427ED3C
	protected virtual void Dispose(bool disposing) {} // 0x00000001835A52F0-0x00000001835A55A0
	public void Clear() {} // 0x000000018427EC34-0x000000018427EC84
	public static int GetSizeOf() => default; // 0x000000018427ED3C-0x000000018427ED7C
	public void Clone(AkDeviceDescription other) {} // 0x000000018427EC84-0x000000018427ECEC
}

public class AkDeviceSettings : IDisposable // TypeDefIndex: 52853
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pIOMemory { get => default; set {} } // 0x000000018427F140-0x000000018427F190 0x000000018427F418-0x000000018427F46C
	public uint uIOMemorySize { get => default; set {} } // 0x000000018427F2AC-0x000000018427F2FC 0x0000000182A04150-0x0000000182A041B0
	public uint uIOMemoryAlignment { get => default; set {} } // 0x000000018427F25C-0x000000018427F2AC 0x000000018427F528-0x000000018427F57C
	public uint ePoolAttributes { get => default; set {} } // 0x000000018427F0A0-0x000000018427F0F0 0x000000018427F3C4-0x000000018427F418
	public uint uGranularity { get => default; set {} } // 0x000000018427F20C-0x000000018427F25C 0x000000018427F4D4-0x000000018427F528
	public AkThreadProperties threadProperties { get => default; set {} } // 0x000000018427F190-0x000000018427F20C 0x000000018427F46C-0x000000018427F4D4
	public float fTargetAutoStmBufferLength { get => default; set {} } // 0x000000018427F0F0-0x000000018427F140 0x0000000182A040A0-0x0000000182A04100
	public uint uMaxConcurrentIO { get => default; set {} } // 0x000000018427F34C-0x000000018427F39C 0x000000018427F57C-0x000000018427F5D0
	public bool bUseStreamCache { get => default; set {} } // 0x000000018427F050-0x000000018427F0A0 0x0000000182A03FF0-0x0000000182A04050
	public uint uMaxCachePinnedBytes { get => default; set {} } // 0x000000018427F2FC-0x000000018427F34C 0x0000000182A03F50-0x0000000182A03FB0

	// Constructors
	public AkDeviceSettings() {} // Dummy constructor
	internal AkDeviceSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0

	// Methods
	internal static IntPtr getCPtr(AkDeviceSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427F39C-0x000000018427F3C4
	~AkDeviceSettings() {} // 0x0000000183924810-0x0000000183924860
	public void Dispose() {} // 0x000000018427F000-0x000000018427F050
	protected virtual void Dispose(bool disposing) {} // 0x0000000183924860-0x0000000183924B10
}

public class AkDiffractionPathInfo : IDisposable // TypeDefIndex: 52854
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18
	public const uint kMaxNodes = 8; // Metadata: 0x01FD2C45

	// Properties
	public AkVector64 emitterPos { get => default; set {} } // 0x000000018427FA64-0x000000018427FAD0 0x000000018427FD5C-0x000000018427FDC8
	public AkWorldTransform virtualPos { get => default; set {} } // 0x000000018427FC60-0x000000018427FCDC 0x000000018427FF7C-0x000000018427FFE4
	public uint nodeCount { get => default; set {} } // 0x000000018427FAD0-0x000000018427FB20 0x000000018427FDC8-0x000000018427FE1C
	public float diffraction { get => default; set {} } // 0x000000018427FA14-0x000000018427FA64 0x000000018427FD04-0x000000018427FD5C
	public float transmissionLoss { get => default; set {} } // 0x000000018427FC10-0x000000018427FC60 0x000000018427FF24-0x000000018427FF7C
	public float totLength { get => default; set {} } // 0x000000018427FBC0-0x000000018427FC10 0x000000018427FECC-0x000000018427FF24
	public float obstructionValue { get => default; set {} } // 0x000000018427FB20-0x000000018427FB70 0x000000018427FE1C-0x000000018427FE74
	public float occlusionValue { get => default; set {} } // 0x000000018427FB70-0x000000018427FBC0 0x000000018427FE74-0x000000018427FECC

	// Constructors
	internal AkDiffractionPathInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkDiffractionPathInfo() {} // 0x000000018427F9C4-0x000000018427FA14

	// Methods
	internal static IntPtr getCPtr(AkDiffractionPathInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427FCDC-0x000000018427FD04
	~AkDiffractionPathInfo() {} // 0x000000018427F79C-0x000000018427F810
	public void Dispose() {} // 0x000000018427F638-0x000000018427F688
	protected virtual void Dispose(bool disposing) {} // 0x000000018427F688-0x000000018427F79C
	public static int GetSizeOf() => default; // 0x000000018427F984-0x000000018427F9C4
	public Vector3 GetNodes(uint idx) => default; // 0x000000018427F864-0x000000018427F8DC
	public float GetAngles(uint idx) => default; // 0x000000018427F810-0x000000018427F864
	public ulong GetPortals(uint idx) => default; // 0x000000018427F8DC-0x000000018427F930
	public ulong GetRooms(uint idx) => default; // 0x000000018427F930-0x000000018427F984
	public void Clone(AkDiffractionPathInfo other) {} // 0x000000018427F5D0-0x000000018427F638
}

public class AkDurationCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 52855
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public float fDuration { get => default; } // 0x0000000184280214-0x0000000184280264 
	public float fEstimatedDuration { get => default; } // 0x0000000184280264-0x00000001842802B4 
	public uint audioNodeID { get => default; } // 0x0000000184280174-0x00000001842801C4 
	public uint mediaID { get => default; } // 0x00000001842802B4-0x0000000184280304 
	public bool bStreaming { get => default; } // 0x00000001842801C4-0x0000000184280214 

	// Constructors
	internal AkDurationCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001831D89D0-0x00000001831D8A50
	public AkDurationCallbackInfo() {} // 0x0000000184280114-0x0000000184280164

	// Methods
	internal static IntPtr getCPtr(AkDurationCallbackInfo obj) => default; // 0x0000000184280164-0x0000000184280174
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000184280304-0x0000000184280364
	protected override void Dispose(bool disposing) {} // 0x000000018427FFE4-0x0000000184280114
}

public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo // TypeDefIndex: 52856
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get => default; } // 0x0000000184280594-0x00000001842805E4 
	public uint audioNodeID { get => default; } // 0x00000001842804F4-0x0000000184280544 
	public IntPtr pCustomInfo { get => default; } // 0x0000000184280544-0x0000000184280594 

	// Constructors
	internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001831D8500-0x00000001831D8570
	public AkDynamicSequenceItemCallbackInfo() {} // 0x0000000184280494-0x00000001842804E4

	// Methods
	internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj) => default; // 0x00000001842804E4-0x00000001842804F4
	internal override void setCPtr(IntPtr cPtr) {} // 0x00000001842805E4-0x0000000184280644
	protected override void Dispose(bool disposing) {} // 0x0000000184280364-0x0000000184280494
}

public enum AkDynamicSequenceType // TypeDefIndex: 52857
{
	DynamicSequenceType_SampleAccurate = 0,
	DynamicSequenceType_NormalTransition = 1
}

public class AkEventCallbackInfo : AkCallbackInfo // TypeDefIndex: 52858
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get => default; } // 0x0000000184280694-0x00000001842806E4 
	public uint eventID { get => default; } // 0x000000018269F840-0x000000018269F8B0 

	// Constructors
	internal AkEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001831D8870-0x00000001831D88F0
	public AkEventCallbackInfo() {} // 0x0000000184280644-0x0000000184280694

	// Methods
	internal static IntPtr getCPtr(AkEventCallbackInfo obj) => default; // 0x00000001842804E4-0x00000001842804F4
	internal override void setCPtr(IntPtr cPtr) {} // 0x00000001831D88F0-0x00000001831D8990
	protected override void Dispose(bool disposing) {} // 0x00000001830388E0-0x0000000183038DB0
}

public class AkExtent : IDisposable // TypeDefIndex: 52859
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float halfWidth { get => default; set {} } // 0x0000000184280A28-0x0000000184280A78 0x0000000184280B50-0x0000000184280BA8
	public float halfHeight { get => default; set {} } // 0x00000001842809D8-0x0000000184280A28 0x0000000184280AF8-0x0000000184280B50
	public float halfDepth { get => default; set {} } // 0x0000000184280988-0x00000001842809D8 0x0000000184280AA0-0x0000000184280AF8

	// Constructors
	internal AkExtent(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkExtent() {} // 0x00000001842808BC-0x000000018428090C
	public AkExtent(float in_halfWidth, float in_halfHeight, float in_halfDepth) {} // 0x000000018428090C-0x0000000184280988

	// Methods
	internal static IntPtr getCPtr(AkExtent obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184280A78-0x0000000184280AA0
	~AkExtent() {} // 0x0000000184280848-0x00000001842808BC
	public void Dispose() {} // 0x00000001842807F8-0x0000000184280848
	protected virtual void Dispose(bool disposing) {} // 0x00000001842806E4-0x00000001842807F8
}

public class AkExternalSourceInfo : IDisposable // TypeDefIndex: 52860
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint iExternalSrcCookie { get => default; set {} } // 0x0000000184280EAC-0x0000000184280EFC 0x00000001829507E0-0x0000000182950840
	public uint idCodec { get => default; set {} } // 0x0000000184280EFC-0x0000000184280F4C 0x0000000182950730-0x0000000182950790
	public string szFile { get => default; set {} } // 0x0000000184280FEC-0x0000000184281058 0x0000000182950890-0x0000000182950900
	public IntPtr pInMemory { get => default; set {} } // 0x0000000184280F9C-0x0000000184280FEC 0x0000000184281124-0x0000000184281178
	public uint uiMemorySize { get => default; set {} } // 0x0000000184281058-0x00000001842810A8 0x0000000184281178-0x00000001842811CC
	public uint idFile { get => default; set {} } // 0x0000000184280F4C-0x0000000184280F9C 0x00000001842810D0-0x0000000184281124

	// Constructors
	internal AkExternalSourceInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkExternalSourceInfo() {} // 0x0000000184280DDC-0x0000000184280E2C
	public AkExternalSourceInfo(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec) {} // 0x0000000184280E2C-0x0000000184280EAC
	public AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec) {} // 0x0000000184280D64-0x0000000184280DDC
	public AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec) {} // 0x0000000184280CF0-0x0000000184280D64

	// Methods
	internal static IntPtr getCPtr(AkExternalSourceInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842810A8-0x00000001842810D0
	~AkExternalSourceInfo() {} // 0x0000000183543B20-0x0000000183543B70
	public void Dispose() {} // 0x0000000184280C60-0x0000000184280CB0
	protected virtual void Dispose(bool disposing) {} // 0x0000000183543B70-0x0000000183543FA0
	public void Clear() {} // 0x0000000184280BA8-0x0000000184280BF8
	public void Clone(AkExternalSourceInfo other) {} // 0x0000000184280BF8-0x0000000184280C60
	public static int GetSizeOf() => default; // 0x0000000184280CB0-0x0000000184280CF0
}

public enum AkFloorPlane // TypeDefIndex: 52861
{
	AkFloorPlane_XZ = 0,
	AkFloorPlane_Default = 0,
	AkFloorPlane_XY = 1,
	AkFloorPlane_YZ = 2
}

public class AkGeometryInstanceParams : IDisposable // TypeDefIndex: 52862
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkWorldTransform PositionAndOrientation { get => default; set {} } // 0x00000001842813F4-0x0000000184281470 0x0000000184281550-0x00000001842815B8
	public Vector3 Scale { get => default; set {} } // 0x0000000184281470-0x00000001842814D8 0x00000001842815B8-0x0000000184281620
	public bool UseForReflectionAndDiffraction { get => default; set {} } // 0x00000001842814D8-0x0000000184281528 0x0000000184281620-0x0000000184281674

	// Constructors
	internal AkGeometryInstanceParams(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkGeometryInstanceParams() {} // 0x00000001842813A4-0x00000001842813F4

	// Methods
	internal static IntPtr getCPtr(AkGeometryInstanceParams obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184281528-0x0000000184281550
	~AkGeometryInstanceParams() {} // 0x0000000184281330-0x00000001842813A4
	public void Dispose() {} // 0x00000001842811CC-0x000000018428121C
	protected virtual void Dispose(bool disposing) {} // 0x000000018428121C-0x0000000184281330
}

public enum AkGlobalCallbackLocation // TypeDefIndex: 52863
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

public enum AkGroupType // TypeDefIndex: 52864
{
	AkGroupType_Switch = 0,
	AkGroupType_State = 1
}

public class AkImageSourceParams : IDisposable // TypeDefIndex: 52865
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkVector64 sourcePosition { get => default; set {} } // 0x0000000184281A68-0x0000000184281AD4 0x0000000184281CFC-0x0000000184281D68
	public float fDistanceScalingFactor { get => default; set {} } // 0x0000000184281978-0x00000001842819C8 0x0000000184281BF4-0x0000000184281C4C
	public float fLevel { get => default; set {} } // 0x00000001842819C8-0x0000000184281A18 0x0000000184281C4C-0x0000000184281CA4
	public float fDiffraction { get => default; set {} } // 0x0000000184281928-0x0000000184281978 0x0000000184281B9C-0x0000000184281BF4
	public float fOcclusion { get => default; set {} } // 0x0000000184281A18-0x0000000184281A68 0x0000000184281CA4-0x0000000184281CFC
	public byte uDiffractionEmitterSide { get => default; set {} } // 0x0000000184281AD4-0x0000000184281B24 0x0000000184281D68-0x0000000184281DBC
	public byte uDiffractionListenerSide { get => default; set {} } // 0x0000000184281B24-0x0000000184281B74 0x0000000184281DBC-0x0000000184281E10

	// Constructors
	internal AkImageSourceParams(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkImageSourceParams() {} // 0x000000018428184C-0x000000018428189C
	public AkImageSourceParams(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel) {} // 0x000000018428189C-0x0000000184281928

	// Methods
	internal static IntPtr getCPtr(AkImageSourceParams obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184281B74-0x0000000184281B9C
	~AkImageSourceParams() {} // 0x00000001842817D8-0x000000018428184C
	public void Dispose() {} // 0x0000000184281674-0x00000001842816C4
	protected virtual void Dispose(bool disposing) {} // 0x00000001842816C4-0x00000001842817D8
}

public class AkImageSourceSettings : IDisposable // TypeDefIndex: 52866
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkImageSourceParams params_ { get => default; set {} } // 0x0000000184282118-0x0000000184282194 0x00000001842821BC-0x0000000184282224

	// Constructors
	internal AkImageSourceSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkImageSourceSettings() {} // 0x00000001842820C8-0x0000000184282118
	public AkImageSourceSettings(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel) {} // 0x000000018428203C-0x00000001842820C8

	// Methods
	internal static IntPtr getCPtr(AkImageSourceSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184282194-0x00000001842821BC
	~AkImageSourceSettings() {} // 0x0000000184281F74-0x0000000184281FE8
	public void Dispose() {} // 0x0000000184281F24-0x0000000184281F74
	protected virtual void Dispose(bool disposing) {} // 0x0000000184281E10-0x0000000184281F24
	public void SetOneTexture(uint in_texture) {} // 0x0000000184281FE8-0x000000018428203C
}

public class AkInitializationSettings : IDisposable // TypeDefIndex: 52867
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkStreamMgrSettings streamMgrSettings { get => default; set {} } // 0x0000000182A03870-0x0000000182A03900 0x0000000184282CB8-0x0000000184282D20
	public AkDeviceSettings deviceSettings { get => default; set {} } // 0x0000000182A02C10-0x0000000182A02CA0 0x0000000184282B18-0x0000000184282B80
	public AkInitSettings initSettings { get => default; set {} } // 0x0000000182A02B40-0x0000000182A02BD0 0x0000000184282B80-0x0000000184282BE8
	public AkPlatformInitSettings platformSettings { get => default; set {} } // 0x0000000182A02A70-0x0000000182A02B00 0x0000000184282C50-0x0000000184282CB8
	public AkMusicSettings musicSettings { get => default; set {} } // 0x0000000182A037A0-0x0000000182A03830 0x0000000184282BE8-0x0000000184282C50
	public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings { get => default; set {} } // 0x0000000182A029A0-0x0000000182A02A30 0x0000000184282D20-0x0000000184282D88
	public uint uMemAllocationSizeLimit { get => default; set {} } // 0x0000000184282A00-0x0000000184282A50 0x0000000182A01BE0-0x0000000182A01C40
	public uint uMemDebugLevel { get => default; set {} } // 0x0000000184282A50-0x0000000184282AA0 0x0000000182A03EB0-0x0000000182A03F10
	public uint uMemSpanCount { get => default; set {} } // 0x0000000184282AA0-0x0000000184282AF0 0x0000000182A03E10-0x0000000182A03E70

	// Constructors
	internal AkInitializationSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkInitializationSettings() {} // 0x0000000182A03CF0-0x0000000182A03D40

	// Methods
	internal static IntPtr getCPtr(AkInitializationSettings obj) => default; // 0x0000000182524410-0x0000000182524420
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184282AF0-0x0000000184282B18
	~AkInitializationSettings() {} // 0x00000001839C1A20-0x00000001839C1A70
	public void Dispose() {} // 0x00000001842829B0-0x0000000184282A00
	protected virtual void Dispose(bool disposing) {} // 0x00000001839C1A70-0x00000001839C1D80
}

public class AkInitSettings : IDisposable // TypeDefIndex: 52868
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxNumPaths { get => default; set {} } // 0x0000000184282634-0x0000000184282684 0x0000000182A4EB00-0x0000000182A4EB60
	public uint uCommandQueueSize { get => default; set {} } // 0x00000001842824F4-0x0000000184282544 0x0000000182A4EA60-0x0000000182A4EAC0
	public bool bEnableGameSyncPreparation { get => default; set {} } // 0x00000001842822C4-0x0000000184282314 0x0000000182A01A80-0x0000000182A01AE0
	public uint uContinuousPlaybackLookAhead { get => default; set {} } // 0x0000000184282544-0x0000000184282594 0x0000000182A019E0-0x0000000182A01A40
	public uint uNumSamplesPerFrame { get => default; set {} } // 0x00000001842826D4-0x0000000184282724 0x0000000182A4E9C0-0x0000000182A4EA20
	public uint uMonitorQueuePoolSize { get => default; set {} } // 0x0000000184282684-0x00000001842826D4 0x0000000182A01940-0x0000000182A019A0
	public uint uCpuMonitorQueueMaxSize { get => default; set {} } // 0x0000000184282594-0x00000001842825E4 0x000000018428295C-0x00000001842829B0
	public AkOutputSettings settingsMainOutput { get => default; set {} } // 0x0000000182A4E890-0x0000000182A4E920 0x00000001842828A0-0x0000000184282908
	public uint uMaxHardwareTimeoutMs { get => default; set {} } // 0x00000001842825E4-0x0000000184282634 0x0000000182A018A0-0x0000000182A01900
	public bool bUseSoundBankMgrThread { get => default; set {} } // 0x0000000184282364-0x00000001842823B4 0x00000001842827A0-0x00000001842827F4
	public bool bUseLEngineThread { get => default; set {} } // 0x0000000184282314-0x0000000184282364 0x000000018428274C-0x00000001842827A0
	public string szPluginDLLPath { get => default; set {} } // 0x0000000182A4E730-0x0000000182A4E7B0 0x0000000182A4E960-0x0000000182A4E9C0
	public AkFloorPlane eFloorPlane { get => default; set {} } // 0x00000001842823B4-0x0000000184282404 0x00000001842827F4-0x0000000184282848
	public float fGameUnitsToMeters { get => default; set {} } // 0x0000000184282454-0x00000001842824A4 0x0000000184282848-0x00000001842828A0
	public uint uBankReadBufferSize { get => default; set {} } // 0x00000001842824A4-0x00000001842824F4 0x0000000184282908-0x000000018428295C
	public float fDebugOutOfRangeLimit { get => default; set {} } // 0x0000000184282404-0x0000000184282454 0x0000000182A017F0-0x0000000182A01850
	public bool bDebugOutOfRangeCheckEnabled { get => default; set {} } // 0x0000000184282274-0x00000001842822C4 0x0000000182A01740-0x0000000182A017A0

	// Constructors
	public AkInitSettings() {} // Dummy constructor
	internal AkInitSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0

	// Methods
	internal static IntPtr getCPtr(AkInitSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184282724-0x000000018428274C
	~AkInitSettings() {} // 0x0000000183924510-0x0000000183924560
	public void Dispose() {} // 0x0000000184282224-0x0000000184282274
	protected virtual void Dispose(bool disposing) {} // 0x0000000183924560-0x0000000183924810
}

public class AkIterator : IDisposable // TypeDefIndex: 52869
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkPlaylistItem pItem { get => default; set {} } // 0x00000001842831DC-0x0000000184283258 0x0000000184283280-0x00000001842832E8

	// Constructors
	internal AkIterator(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkIterator() {} // 0x000000018428318C-0x00000001842831DC

	// Methods
	internal static IntPtr getCPtr(AkIterator obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184283258-0x0000000184283280
	~AkIterator() {} // 0x0000000184282EEC-0x0000000184282F60
	public void Dispose() {} // 0x0000000184282E9C-0x0000000184282EEC
	protected virtual void Dispose(bool disposing) {} // 0x0000000184282D88-0x0000000184282E9C
	public AkIterator NextIter() => default; // 0x00000001842830A4-0x0000000184283118
	public AkIterator PrevIter() => default; // 0x0000000184283118-0x000000018428318C
	public AkPlaylistItem GetItem() => default; // 0x0000000184282F60-0x0000000184282FD4
	public bool IsEqualTo(AkIterator in_rOp) => default; // 0x000000018428303C-0x00000001842830A4
	public bool IsDifferentFrom(AkIterator in_rOp) => default; // 0x0000000184282FD4-0x000000018428303C
}

public class AkMarkerCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 52870
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public uint uIdentifier { get => default; } // 0x0000000184285730-0x0000000184285780 
	public uint uPosition { get => default; } // 0x0000000184285780-0x00000001842857D0 
	public string strLabel { get => default; } // 0x00000001842856C4-0x0000000184285730 

	// Constructors
	internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001831D87B0-0x00000001831D8830
	public AkMarkerCallbackInfo() {} // 0x0000000184285674-0x00000001842856C4

	// Methods
	internal static IntPtr getCPtr(AkMarkerCallbackInfo obj) => default; // 0x0000000184280164-0x0000000184280174
	internal override void setCPtr(IntPtr cPtr) {} // 0x00000001842857D0-0x0000000184285830
	protected override void Dispose(bool disposing) {} // 0x0000000184285544-0x0000000184285674
}

public class AkMemCategroyStats : IDisposable // TypeDefIndex: 52871
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong uUsed { get => default; set {} } // 0x0000000184285AF8-0x0000000184285B48 0x0000000184285C6C-0x0000000184285CC0
	public ulong uPeakUsed { get => default; set {} } // 0x0000000184285AA8-0x0000000184285AF8 0x0000000184285C18-0x0000000184285C6C
	public uint uAllocs { get => default; set {} } // 0x0000000184285A08-0x0000000184285A58 0x0000000184285B70-0x0000000184285BC4
	public uint uFrees { get => default; set {} } // 0x0000000184285A58-0x0000000184285AA8 0x0000000184285BC4-0x0000000184285C18

	// Constructors
	internal AkMemCategroyStats(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkMemCategroyStats() {} // 0x0000000183B38030-0x0000000183B38080

	// Methods
	internal static IntPtr getCPtr(AkMemCategroyStats obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184285B48-0x0000000184285B70
	~AkMemCategroyStats() {} // 0x0000000184285994-0x0000000184285A08
	public void Dispose() {} // 0x0000000184285830-0x0000000184285880
	protected virtual void Dispose(bool disposing) {} // 0x0000000184285880-0x0000000184285994
}

public class AkMemGlobalStats : IDisposable // TypeDefIndex: 52872
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong uUsed { get => default; set {} } // 0x0000000184285FD8-0x0000000184286028 0x000000018428614C-0x00000001842861A0
	public ulong uDeviceUsed { get => default; set {} } // 0x0000000184285EE8-0x0000000184285F38 0x0000000184286050-0x00000001842860A4
	public ulong uReserved { get => default; set {} } // 0x0000000184285F88-0x0000000184285FD8 0x00000001842860F8-0x000000018428614C
	public ulong uMax { get => default; set {} } // 0x0000000184285F38-0x0000000184285F88 0x00000001842860A4-0x00000001842860F8

	// Constructors
	internal AkMemGlobalStats(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkMemGlobalStats() {} // 0x0000000184285E98-0x0000000184285EE8

	// Methods
	internal static IntPtr getCPtr(AkMemGlobalStats obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184286028-0x0000000184286050
	~AkMemGlobalStats() {} // 0x0000000184285E24-0x0000000184285E98
	public void Dispose() {} // 0x0000000184285DD4-0x0000000184285E24
	protected virtual void Dispose(bool disposing) {} // 0x0000000184285CC0-0x0000000184285DD4
}

public enum AkMemID : uint // TypeDefIndex: 52873
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

public enum AkMeteringFlags // TypeDefIndex: 52874
{
	AK_NoMetering = 0,
	AK_EnableBusMeter_Peak = 1,
	AK_EnableBusMeter_TruePeak = 2,
	AK_EnableBusMeter_RMS = 4,
	AK_EnableBusMeter_KPower = 16,
	AK_EnableBusMeter_3DMeter = 32
}

public enum AkMIDICcTypes // TypeDefIndex: 52875
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

public class AkMIDIEvent : IDisposable // TypeDefIndex: 52884
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public byte byChan { get => default; set {} } // 0x0000000184283FFC-0x000000018428404C 0x00000001842847D4-0x0000000184284828
	public tGen Gen { get => default; set {} } // 0x0000000184283BD4-0x0000000184283C50 0x0000000184284414-0x000000018428447C
	public tCc Cc { get => default; set {} } // 0x0000000184283ADC-0x0000000184283B58 0x0000000184284344-0x00000001842843AC
	public tNoteOnOff NoteOnOff { get => default; set {} } // 0x0000000184283CCC-0x0000000184283D48 0x00000001842844E4-0x000000018428454C
	public tPitchBend PitchBend { get => default; set {} } // 0x0000000184283D48-0x0000000184283DC4 0x000000018428454C-0x00000001842845B4
	public tNoteAftertouch NoteAftertouch { get => default; set {} } // 0x0000000184283C50-0x0000000184283CCC 0x000000018428447C-0x00000001842844E4
	public tChanAftertouch ChanAftertouch { get => default; set {} } // 0x0000000184283B58-0x0000000184283BD4 0x00000001842843AC-0x0000000184284414
	public tProgramChange ProgramChange { get => default; set {} } // 0x0000000184283DC4-0x0000000184283E40 0x00000001842845B4-0x000000018428461C
	public tWwiseCmd WwiseCmd { get => default; set {} } // 0x0000000184283E40-0x0000000184283EBC 0x000000018428461C-0x0000000184284684
	public AkMIDIEventTypes byType { get => default; set {} } // 0x000000018428413C-0x000000018428418C 0x0000000184284924-0x0000000184284978
	public byte byOnOffNote { get => default; set {} } // 0x000000018428409C-0x00000001842840EC 0x000000018428487C-0x00000001842848D0
	public byte byVelocity { get => default; set {} } // 0x000000018428422C-0x000000018428427C 0x0000000184284A20-0x0000000184284A74
	public AkMIDICcTypes byCc { get => default; set {} } // 0x0000000184283F5C-0x0000000184283FAC 0x000000018428472C-0x0000000184284780
	public byte byCcValue { get => default; set {} } // 0x0000000184283F0C-0x0000000184283F5C 0x00000001842846D8-0x000000018428472C
	public byte byValueLsb { get => default; set {} } // 0x000000018428418C-0x00000001842841DC 0x0000000184284978-0x00000001842849CC
	public byte byValueMsb { get => default; set {} } // 0x00000001842841DC-0x000000018428422C 0x00000001842849CC-0x0000000184284A20
	public byte byAftertouchNote { get => default; set {} } // 0x0000000184283EBC-0x0000000184283F0C 0x0000000184284684-0x00000001842846D8
	public byte byNoteAftertouchValue { get => default; set {} } // 0x000000018428404C-0x000000018428409C 0x0000000184284828-0x000000018428487C
	public byte byChanAftertouchValue { get => default; set {} } // 0x0000000184283FAC-0x0000000184283FFC 0x0000000184284780-0x00000001842847D4
	public byte byProgramNum { get => default; set {} } // 0x00000001842840EC-0x000000018428413C 0x00000001842848D0-0x0000000184284924
	public ushort uCmd { get => default; set {} } // 0x00000001842842CC-0x000000018428431C 0x0000000184284AC8-0x0000000184284B1C
	public uint uArg { get => default; set {} } // 0x000000018428427C-0x00000001842842CC 0x0000000184284A74-0x0000000184284AC8

	// Nested types
	public class tGen : IDisposable // TypeDefIndex: 52876
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byParam1 { get => default; set {} } // 0x00000001842A91DC-0x00000001842A922C 0x00000001842A92A4-0x00000001842A92F8
		public byte byParam2 { get => default; set {} } // 0x00000001842A922C-0x00000001842A927C 0x00000001842A92F8-0x00000001842A934C

		// Constructors
		internal tGen(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
		public tGen() {} // 0x00000001842A918C-0x00000001842A91DC

		// Methods
		internal static IntPtr getCPtr(tGen obj) => default; // 0x000000018427A72C-0x000000018427A73C
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A927C-0x00000001842A92A4
		~tGen() {} // 0x00000001842A9118-0x00000001842A918C
		public void Dispose() {} // 0x00000001842A8FB4-0x00000001842A9004
		protected virtual void Dispose(bool disposing) {} // 0x00000001842A9004-0x00000001842A9118
	}

	public class tNoteOnOff : IDisposable // TypeDefIndex: 52877
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byNote { get => default; set {} } // 0x00000001842A990C-0x00000001842A995C 0x00000001842A99D4-0x00000001842A9A28
		public byte byVelocity { get => default; set {} } // 0x00000001842A995C-0x00000001842A99AC 0x00000001842A9A28-0x00000001842A9A7C

		// Constructors
		internal tNoteOnOff(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
		public tNoteOnOff() {} // 0x00000001842A98BC-0x00000001842A990C

		// Methods
		internal static IntPtr getCPtr(tNoteOnOff obj) => default; // 0x000000018427A72C-0x000000018427A73C
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A99AC-0x00000001842A99D4
		~tNoteOnOff() {} // 0x00000001842A9848-0x00000001842A98BC
		public void Dispose() {} // 0x00000001842A96E4-0x00000001842A9734
		protected virtual void Dispose(bool disposing) {} // 0x00000001842A9734-0x00000001842A9848
	}

	public class tCc : IDisposable // TypeDefIndex: 52878
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byCc { get => default; set {} } // 0x00000001842A8B50-0x00000001842A8BA0 0x00000001842A8C18-0x00000001842A8C6C
		public byte byValue { get => default; set {} } // 0x00000001842A8BA0-0x00000001842A8BF0 0x00000001842A8C6C-0x00000001842A8CC0

		// Constructors
		internal tCc(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
		public tCc() {} // 0x00000001842A8B00-0x00000001842A8B50

		// Methods
		internal static IntPtr getCPtr(tCc obj) => default; // 0x000000018427A72C-0x000000018427A73C
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A8BF0-0x00000001842A8C18
		~tCc() {} // 0x00000001842A8A8C-0x00000001842A8B00
		public void Dispose() {} // 0x00000001842A8A3C-0x00000001842A8A8C
		protected virtual void Dispose(bool disposing) {} // 0x00000001842A8928-0x00000001842A8A3C
	}

	public class tPitchBend : IDisposable // TypeDefIndex: 52879
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byValueLsb { get => default; set {} } // 0x00000001842A9CA4-0x00000001842A9CF4 0x00000001842A9D6C-0x00000001842A9DC0
		public byte byValueMsb { get => default; set {} } // 0x00000001842A9CF4-0x00000001842A9D44 0x00000001842A9DC0-0x00000001842A9E14

		// Constructors
		internal tPitchBend(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
		public tPitchBend() {} // 0x00000001842A9C54-0x00000001842A9CA4

		// Methods
		internal static IntPtr getCPtr(tPitchBend obj) => default; // 0x000000018427A72C-0x000000018427A73C
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A9D44-0x00000001842A9D6C
		~tPitchBend() {} // 0x00000001842A9BE0-0x00000001842A9C54
		public void Dispose() {} // 0x00000001842A9B90-0x00000001842A9BE0
		protected virtual void Dispose(bool disposing) {} // 0x00000001842A9A7C-0x00000001842A9B90
	}

	public class tNoteAftertouch : IDisposable // TypeDefIndex: 52880
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byNote { get => default; set {} } // 0x00000001842A9574-0x00000001842A95C4 0x00000001842A963C-0x00000001842A9690
		public byte byValue { get => default; set {} } // 0x00000001842A95C4-0x00000001842A9614 0x00000001842A9690-0x00000001842A96E4

		// Constructors
		internal tNoteAftertouch(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
		public tNoteAftertouch() {} // 0x00000001842A9524-0x00000001842A9574

		// Methods
		internal static IntPtr getCPtr(tNoteAftertouch obj) => default; // 0x000000018427A72C-0x000000018427A73C
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A9614-0x00000001842A963C
		~tNoteAftertouch() {} // 0x00000001842A94B0-0x00000001842A9524
		public void Dispose() {} // 0x00000001842A9460-0x00000001842A94B0
		protected virtual void Dispose(bool disposing) {} // 0x00000001842A934C-0x00000001842A9460
	}

	public class tChanAftertouch : IDisposable // TypeDefIndex: 52881
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byValue { get => default; set {} } // 0x00000001842A8EE8-0x00000001842A8F38 0x00000001842A8F60-0x00000001842A8FB4

		// Constructors
		internal tChanAftertouch(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
		public tChanAftertouch() {} // 0x00000001842A8E98-0x00000001842A8EE8

		// Methods
		internal static IntPtr getCPtr(tChanAftertouch obj) => default; // 0x000000018427A72C-0x000000018427A73C
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A8F38-0x00000001842A8F60
		~tChanAftertouch() {} // 0x00000001842A8E24-0x00000001842A8E98
		public void Dispose() {} // 0x00000001842A8CC0-0x00000001842A8D10
		protected virtual void Dispose(bool disposing) {} // 0x00000001842A8D10-0x00000001842A8E24
	}

	public class tProgramChange : IDisposable // TypeDefIndex: 52882
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byProgramNum { get => default; set {} } // 0x00000001842AA03C-0x00000001842AA08C 0x00000001842AA0B4-0x00000001842AA108

		// Constructors
		internal tProgramChange(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
		public tProgramChange() {} // 0x00000001842A9FEC-0x00000001842AA03C

		// Methods
		internal static IntPtr getCPtr(tProgramChange obj) => default; // 0x000000018427A72C-0x000000018427A73C
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842AA08C-0x00000001842AA0B4
		~tProgramChange() {} // 0x00000001842A9F78-0x00000001842A9FEC
		public void Dispose() {} // 0x00000001842A9E14-0x00000001842A9E64
		protected virtual void Dispose(bool disposing) {} // 0x00000001842A9E64-0x00000001842A9F78
	}

	public class tWwiseCmd : IDisposable // TypeDefIndex: 52883
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public ushort uCmd { get => default; set {} } // 0x00000001842AA380-0x00000001842AA3D0 0x00000001842AA44C-0x00000001842AA4A0
		public uint uArg { get => default; set {} } // 0x00000001842AA330-0x00000001842AA380 0x00000001842AA3F8-0x00000001842AA44C

		// Constructors
		internal tWwiseCmd(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
		public tWwiseCmd() {} // 0x00000001842AA2E0-0x00000001842AA330

		// Methods
		internal static IntPtr getCPtr(tWwiseCmd obj) => default; // 0x000000018427A72C-0x000000018427A73C
		internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842AA3D0-0x00000001842AA3F8
		~tWwiseCmd() {} // 0x00000001842AA26C-0x00000001842AA2E0
		public void Dispose() {} // 0x00000001842AA108-0x00000001842AA158
		protected virtual void Dispose(bool disposing) {} // 0x00000001842AA158-0x00000001842AA26C
	}

	// Constructors
	internal AkMIDIEvent(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkMIDIEvent() {} // 0x0000000184283A8C-0x0000000184283ADC

	// Methods
	internal static IntPtr getCPtr(AkMIDIEvent obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428431C-0x0000000184284344
	~AkMIDIEvent() {} // 0x000000018427D550-0x000000018427D5C8
	public void Dispose() {} // 0x0000000184283928-0x0000000184283978
	protected virtual void Dispose(bool disposing) {} // 0x0000000184283978-0x0000000184283A8C
}

public class AkMIDIEventCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 52885
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public byte byChan { get => default; } // 0x00000001842835A8-0x00000001842835F8 
	public byte byParam1 { get => default; } // 0x0000000184283698-0x00000001842836E8 
	public byte byParam2 { get => default; } // 0x00000001842836E8-0x0000000184283738 
	public AkMIDIEventTypes byType { get => default; } // 0x0000000184283788-0x00000001842837D8 
	public byte byOnOffNote { get => default; } // 0x0000000184283648-0x0000000184283698 
	public byte byVelocity { get => default; } // 0x0000000184283878-0x00000001842838C8 
	public AkMIDICcTypes byCc { get => default; } // 0x0000000184283508-0x0000000184283558 
	public byte byCcValue { get => default; } // 0x00000001842834B8-0x0000000184283508 
	public byte byValueLsb { get => default; } // 0x00000001842837D8-0x0000000184283828 
	public byte byValueMsb { get => default; } // 0x0000000184283828-0x0000000184283878 
	public byte byAftertouchNote { get => default; } // 0x0000000184283468-0x00000001842834B8 
	public byte byNoteAftertouchValue { get => default; } // 0x00000001842835F8-0x0000000184283648 
	public byte byChanAftertouchValue { get => default; } // 0x0000000184283558-0x00000001842835A8 
	public byte byProgramNum { get => default; } // 0x0000000184283738-0x0000000184283788 

	// Constructors
	internal AkMIDIEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001831D86B0-0x00000001831D8730
	public AkMIDIEventCallbackInfo() {} // 0x0000000184283418-0x0000000184283468

	// Methods
	internal static IntPtr getCPtr(AkMIDIEventCallbackInfo obj) => default; // 0x0000000184280164-0x0000000184280174
	internal override void setCPtr(IntPtr cPtr) {} // 0x00000001842838C8-0x0000000184283928
	protected override void Dispose(bool disposing) {} // 0x00000001842832E8-0x0000000184283418
}

public enum AkMIDIEventTypes // TypeDefIndex: 52886
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

public class AkMIDIPost : AkMIDIEvent // TypeDefIndex: 52887
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public ulong uOffset { get => default; set {} } // 0x0000000184285440-0x0000000184285490 0x00000001842854F0-0x0000000184285544

	// Constructors
	internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000184285388-0x00000001842853F0
	public AkMIDIPost() {} // 0x00000001842853F0-0x0000000184285440

	// Methods
	internal static IntPtr getCPtr(AkMIDIPost obj) => default; // 0x00000001842804E4-0x00000001842804F4
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000184285490-0x00000001842854F0
	protected override void Dispose(bool disposing) {} // 0x0000000184284B84-0x0000000184284CB4
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts) => default; // 0x0000000184284EE4-0x0000000184284F80
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets) => default; // 0x0000000184284F80-0x0000000184285024
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001842850D0-0x00000001842851E4
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID) => default; // 0x0000000184284CF4-0x0000000184284E10
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts) => default; // 0x00000001842852E4-0x0000000184285388
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets) => default; // 0x0000000184285024-0x00000001842850D0
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x0000000184284E10-0x0000000184284EE4
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID) => default; // 0x00000001842851E4-0x00000001842852E4
	public void Clone(AkMIDIPost other) {} // 0x0000000184284B1C-0x0000000184284B84
	public static int GetSizeOf() => default; // 0x0000000184284CB4-0x0000000184284CF4
}

public enum AkMonitorErrorCode // TypeDefIndex: 52888
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

public enum AkMonitorErrorLevel // TypeDefIndex: 52889
{
	ErrorLevel_Message = 1,
	ErrorLevel_Error = 2,
	ErrorLevel_All = 3
}

public class AkMonitoringCallbackInfo : IDisposable // TypeDefIndex: 52890
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkMonitorErrorCode errorCode { get => default; } // 0x00000001842863C8-0x0000000184286418 
	public AkMonitorErrorLevel errorLevel { get => default; } // 0x0000000184286418-0x0000000184286468 
	public uint playingID { get => default; } // 0x0000000184286524-0x0000000184286574 
	public ulong gameObjID { get => default; } // 0x0000000184286468-0x00000001842864B8 
	public string message { get => default; } // 0x00000001842864B8-0x0000000184286524 

	// Constructors
	internal AkMonitoringCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkMonitoringCallbackInfo() {} // 0x0000000184286378-0x00000001842863C8

	// Methods
	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184286574-0x000000018428659C
	~AkMonitoringCallbackInfo() {} // 0x0000000184286304-0x0000000184286378
	public void Dispose() {} // 0x00000001842862B4-0x0000000184286304
	protected virtual void Dispose(bool disposing) {} // 0x00000001842861A0-0x00000001842862B4
}

public enum AkMultiPositionType // TypeDefIndex: 52891
{
	MultiPositionType_SingleSource = 0,
	MultiPositionType_MultiSources = 1,
	MultiPositionType_MultiDirections = 2
}

public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 52892
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public uint playlistID { get => default; } // 0x000000018428671C-0x000000018428676C 
	public uint uNumPlaylistItems { get => default; } // 0x000000018428676C-0x00000001842867BC 
	public uint uPlaylistSelection { get => default; } // 0x000000018428680C-0x000000018428685C 
	public uint uPlaylistItemDone { get => default; } // 0x00000001842867BC-0x000000018428680C 

	// Constructors
	internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001831D85B0-0x00000001831D8630
	public AkMusicPlaylistCallbackInfo() {} // 0x00000001842866CC-0x000000018428671C

	// Methods
	internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj) => default; // 0x0000000184280164-0x0000000184280174
	internal override void setCPtr(IntPtr cPtr) {} // 0x000000018428685C-0x00000001842868BC
	protected override void Dispose(bool disposing) {} // 0x000000018428659C-0x00000001842866CC
}

public class AkMusicSettings : IDisposable // TypeDefIndex: 52893
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fStreamingLookAheadRatio { get => default; set {} } // 0x000000018428690C-0x000000018428695C 0x0000000182A04340-0x0000000182A043A0

	// Constructors
	public AkMusicSettings() {} // Dummy constructor
	internal AkMusicSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0

	// Methods
	internal static IntPtr getCPtr(AkMusicSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428695C-0x0000000184286984
	~AkMusicSettings() {} // 0x0000000183A50EB0-0x0000000183A50F00
	public void Dispose() {} // 0x00000001842868BC-0x000000018428690C
	protected virtual void Dispose(bool disposing) {} // 0x0000000183A50F00-0x0000000183A51190
}

public class AkMusicSyncCallbackInfo : AkCallbackInfo // TypeDefIndex: 52894
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get => default; } // 0x0000000184286B54-0x0000000184286BA4 
	public int segmentInfo_iCurrentPosition { get => default; } // 0x0000000184286D34-0x0000000184286D84 
	public int segmentInfo_iPreEntryDuration { get => default; } // 0x0000000184286DD4-0x0000000184286E24 
	public int segmentInfo_iActiveDuration { get => default; } // 0x0000000184286CE4-0x0000000184286D34 
	public int segmentInfo_iPostExitDuration { get => default; } // 0x0000000184286D84-0x0000000184286DD4 
	public int segmentInfo_iRemainingLookAheadTime { get => default; } // 0x0000000184286E24-0x0000000184286E74 
	public float segmentInfo_fBeatDuration { get => default; } // 0x0000000184286BF4-0x0000000184286C44 
	public float segmentInfo_fBarDuration { get => default; } // 0x0000000184286BA4-0x0000000184286BF4 
	public float segmentInfo_fGridDuration { get => default; } // 0x0000000184286C44-0x0000000184286C94 
	public float segmentInfo_fGridOffset { get => default; } // 0x0000000184286C94-0x0000000184286CE4 
	public AkCallbackType musicSyncType { get => default; } // 0x0000000184286B04-0x0000000184286B54 
	public string userCueName { get => default; } // 0x0000000184286E74-0x0000000184286EE0 

	// Constructors
	internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x00000001831D8450-0x00000001831D84C0
	public AkMusicSyncCallbackInfo() {} // 0x0000000184286AB4-0x0000000184286B04

	// Methods
	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj) => default; // 0x00000001842804E4-0x00000001842804F4
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000184286EE0-0x0000000184286F40
	protected override void Dispose(bool disposing) {} // 0x0000000184286984-0x0000000184286AB4
}

public class AkObjectInfo : IDisposable // TypeDefIndex: 52895
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint objID { get => default; set {} } // 0x00000001842872B0-0x0000000184287300 0x00000001842873CC-0x0000000184287420
	public uint parentID { get => default; set {} } // 0x0000000184287300-0x0000000184287350 0x0000000184287420-0x0000000184287474
	public int iDepth { get => default; set {} } // 0x0000000184287260-0x00000001842872B0 0x0000000184287378-0x00000001842873CC

	// Constructors
	internal AkObjectInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkObjectInfo() {} // 0x0000000184287210-0x0000000184287260

	// Methods
	internal static IntPtr getCPtr(AkObjectInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184287350-0x0000000184287378
	~AkObjectInfo() {} // 0x000000018428715C-0x00000001842871D0
	public void Dispose() {} // 0x000000018428710C-0x000000018428715C
	protected virtual void Dispose(bool disposing) {} // 0x0000000184286FF8-0x000000018428710C
	public void Clear() {} // 0x0000000184286F40-0x0000000184286F90
	public static int GetSizeOf() => default; // 0x00000001842871D0-0x0000000184287210
	public void Clone(AkObjectInfo other) {} // 0x0000000184286F90-0x0000000184286FF8
}

public class AkObstructionOcclusionValues : IDisposable // TypeDefIndex: 52896
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float occlusion { get => default; set {} } // 0x00000001842877E4-0x0000000184287834 0x00000001842878B4-0x000000018428790C
	public float obstruction { get => default; set {} } // 0x0000000184287794-0x00000001842877E4 0x000000018428785C-0x00000001842878B4

	// Constructors
	internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkObstructionOcclusionValues() {} // 0x0000000184287744-0x0000000184287794

	// Methods
	internal static IntPtr getCPtr(AkObstructionOcclusionValues obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184287834-0x000000018428785C
	~AkObstructionOcclusionValues() {} // 0x0000000184287690-0x0000000184287704
	public void Dispose() {} // 0x0000000184287640-0x0000000184287690
	protected virtual void Dispose(bool disposing) {} // 0x000000018428752C-0x0000000184287640
	public void Clear() {} // 0x0000000184287474-0x00000001842874C4
	public static int GetSizeOf() => default; // 0x0000000184287704-0x0000000184287744
	public void Clone(AkObstructionOcclusionValues other) {} // 0x00000001842874C4-0x000000018428752C
}

public class AkOutputSettings : IDisposable // TypeDefIndex: 52897
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioDeviceShareset { get => default; set {} } // 0x0000000184287B80-0x0000000184287BD0 0x0000000182A4F5B0-0x0000000182A4F610
	public uint idDevice { get => default; set {} } // 0x0000000184287C20-0x0000000184287C70 0x0000000182A4F510-0x0000000182A4F570
	public AkPanningRule ePanningRule { get => default; set {} } // 0x0000000184287BD0-0x0000000184287C20 0x0000000182A4F470-0x0000000182A4F4D0
	public AkChannelConfig channelConfig { get => default; set {} } // 0x0000000182A4F2C0-0x0000000182A4F350 0x0000000184287C98-0x0000000184287D00

	// Constructors
	internal AkOutputSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkOutputSettings() {} // 0x0000000184287B30-0x0000000184287B80
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning) {} // 0x0000000184287AA8-0x0000000184287B30
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig) {} // 0x00000001842879B4-0x0000000184287A40
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice) {} // 0x0000000184287A40-0x0000000184287AA8
	public AkOutputSettings(string in_szDeviceShareSet) {} // 0x000000018428795C-0x00000001842879B4

	// Methods
	internal static IntPtr getCPtr(AkOutputSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184287C70-0x0000000184287C98
	~AkOutputSettings() {} // 0x0000000183A50BD0-0x0000000183A50C20
	public void Dispose() {} // 0x000000018428790C-0x000000018428795C
	protected virtual void Dispose(bool disposing) {} // 0x0000000183A50C20-0x0000000183A50EB0
}

public enum AkPanningRule // TypeDefIndex: 52898
{
	AkPanningRule_Speakers = 0,
	AkPanningRule_Headphones = 1
}

public class AkPlaylist : AkPlaylistArray // TypeDefIndex: 52899
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Constructors
	internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000184289C04-0x0000000184289C6C
	public AkPlaylist() {} // 0x0000000184289BB4-0x0000000184289C04

	// Methods
	internal static IntPtr getCPtr(AkPlaylist obj) => default; // 0x00000001842804E4-0x00000001842804F4
	internal override void setCPtr(IntPtr cPtr) {} // 0x0000000184289C6C-0x0000000184289CCC
	protected override void Dispose(bool disposing) {} // 0x0000000184289824-0x0000000184289954
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x0000000184289A8C-0x0000000184289B3C
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals) => default; // 0x00000001842899B8-0x0000000184289A38
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo) => default; // 0x0000000184289B3C-0x0000000184289BB4
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay) => default; // 0x0000000184289954-0x00000001842899B8
	public AKRESULT Enqueue(uint in_audioNodeID) => default; // 0x0000000184289A38-0x0000000184289A8C
}

public class AkPlaylistArray : IDisposable // TypeDefIndex: 52900
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkPlaylistArray() {} // 0x000000018428918C-0x00000001842891DC

	// Methods
	internal static IntPtr getCPtr(AkPlaylistArray obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842891DC-0x0000000184289204
	~AkPlaylistArray() {} // 0x000000018427D550-0x000000018427D5C8
	public void Dispose() {} // 0x00000001842886C0-0x0000000184288710
	protected virtual void Dispose(bool disposing) {} // 0x00000001842885AC-0x00000001842886C0
	public AkIterator Begin() => default; // 0x0000000184288454-0x00000001842884C8
	public AkIterator End() => default; // 0x0000000184288710-0x0000000184288784
	public AkIterator FindEx(AkPlaylistItem in_Item) => default; // 0x00000001842889E4-0x0000000184288A74
	public AkIterator Erase(AkIterator in_rIter) => default; // 0x0000000184288868-0x00000001842888F8
	public void Erase(uint in_uIndex) {} // 0x00000001842888F8-0x000000018428894C
	public AkIterator EraseSwap(AkIterator in_rIter) => default; // 0x0000000184288784-0x0000000184288814
	public void EraseSwap(uint in_uIndex) {} // 0x0000000184288814-0x0000000184288868
	public bool IsGrowingAllowed() => default; // 0x0000000184288C80-0x0000000184288CD0
	public AKRESULT Reserve(uint in_ulReserve) => default; // 0x0000000184288FDC-0x0000000184289030
	public AKRESULT ReserveExtra(uint in_ulReserve) => default; // 0x0000000184288F88-0x0000000184288FDC
	public uint Reserved() => default; // 0x0000000184289030-0x0000000184289080
	public void Term() {} // 0x00000001842890D4-0x0000000184289124
	public uint Length() => default; // 0x0000000184288DC8-0x0000000184288E18
	public AkPlaylistItem Data() => default; // 0x0000000184288530-0x00000001842885AC
	public bool IsEmpty() => default; // 0x0000000184288C30-0x0000000184288C80
	public AkPlaylistItem Exists(AkPlaylistItem in_Item) => default; // 0x000000018428894C-0x00000001842889E4
	public AkPlaylistItem AddLast() => default; // 0x0000000184288340-0x00000001842883BC
	public AkPlaylistItem AddLast(AkPlaylistItem in_rItem) => default; // 0x00000001842883BC-0x0000000184288454
	public AkPlaylistItem Last() => default; // 0x0000000184288D54-0x0000000184288DC8
	public void RemoveLast() {} // 0x0000000184288E68-0x0000000184288EB8
	public AKRESULT Remove(AkPlaylistItem in_rItem) => default; // 0x0000000184288F20-0x0000000184288F88
	public AKRESULT RemoveSwap(AkPlaylistItem in_rItem) => default; // 0x0000000184288EB8-0x0000000184288F20
	public void RemoveAll() {} // 0x0000000184288E18-0x0000000184288E68
	public AkPlaylistItem ItemAtIndex(uint uiIndex) => default; // 0x0000000184288CD0-0x0000000184288D54
	public AkIterator Insert(AkIterator in_rIter) => default; // 0x0000000184288BA0-0x0000000184288C30
	public AkPlaylistItem Insert(uint in_uIndex) => default; // 0x0000000184288B18-0x0000000184288BA0
	public bool GrowArray() => default; // 0x0000000184288A74-0x0000000184288AC4
	public bool GrowArray(uint in_uGrowBy) => default; // 0x0000000184288AC4-0x0000000184288B18
	public bool Resize(uint in_uiSize) => default; // 0x0000000184289080-0x00000001842890D4
	public void Transfer(AkPlaylistArray in_rSource) {} // 0x0000000184289124-0x000000018428918C
	public AKRESULT Copy(AkPlaylistArray in_rSource) => default; // 0x00000001842884C8-0x0000000184288530
}

public class AkPlaylistItem : IDisposable // TypeDefIndex: 52901
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioNodeID { get => default; set {} } // 0x0000000184289610-0x0000000184289660 0x0000000184289728-0x000000018428977C
	public int msDelay { get => default; set {} } // 0x0000000184289660-0x00000001842896B0 0x000000018428977C-0x00000001842897D0
	public IntPtr pCustomInfo { get => default; set {} } // 0x00000001842896B0-0x0000000184289700 0x00000001842897D0-0x0000000184289824

	// Constructors
	internal AkPlaylistItem(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkPlaylistItem() {} // 0x0000000184289554-0x00000001842895A4
	public AkPlaylistItem(AkPlaylistItem in_rCopy) {} // 0x00000001842895A4-0x0000000184289610

	// Methods
	internal static IntPtr getCPtr(AkPlaylistItem obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184289700-0x0000000184289728
	~AkPlaylistItem() {} // 0x00000001842893F8-0x000000018428946C
	public void Dispose() {} // 0x00000001842893A8-0x00000001842893F8
	protected virtual void Dispose(bool disposing) {} // 0x0000000184289294-0x00000001842893A8
	public AkPlaylistItem Assign(AkPlaylistItem in_rCopy) => default; // 0x0000000184289204-0x0000000184289294
	public bool IsEqualTo(AkPlaylistItem in_rCopy) => default; // 0x000000018428946C-0x00000001842894D4
	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc) => default; // 0x00000001842894D4-0x0000000184289554
}

public enum AkPluginType // TypeDefIndex: 52902
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

public class AkPositioningData : IDisposable // TypeDefIndex: 52903
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Ak3dData threeD { get => default; set {} } // 0x0000000184289F70-0x0000000184289FEC 0x000000018428A07C-0x000000018428A0E4
	public AkBehavioralPositioningData behavioral { get => default; set {} } // 0x0000000184289EF4-0x0000000184289F70 0x000000018428A014-0x000000018428A07C

	// Constructors
	internal AkPositioningData(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkPositioningData() {} // 0x0000000184289EA4-0x0000000184289EF4

	// Methods
	internal static IntPtr getCPtr(AkPositioningData obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x0000000184289FEC-0x000000018428A014
	~AkPositioningData() {} // 0x0000000184289E30-0x0000000184289EA4
	public void Dispose() {} // 0x0000000184289CCC-0x0000000184289D1C
	protected virtual void Dispose(bool disposing) {} // 0x0000000184289D1C-0x0000000184289E30
}

public class AkPositioningInfo : IDisposable // TypeDefIndex: 52904
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fCenterPct { get => default; set {} } // 0x000000018428A5DC-0x000000018428A62C 0x000000018428ABD8-0x000000018428AC30
	public AkSpeakerPanningType pannerType { get => default; set {} } // 0x000000018428A85C-0x000000018428A8AC 0x000000018428AE98-0x000000018428AEEC
	public Ak3DPositionType e3dPositioningType { get => default; set {} } // 0x000000018428A58C-0x000000018428A5DC 0x000000018428AB84-0x000000018428ABD8
	public bool bHoldEmitterPosAndOrient { get => default; set {} } // 0x000000018428A49C-0x000000018428A4EC 0x000000018428AA88-0x000000018428AADC
	public Ak3DSpatializationMode e3DSpatializationMode { get => default; set {} } // 0x000000018428A53C-0x000000018428A58C 0x000000018428AB30-0x000000018428AB84
	public bool bEnableAttenuation { get => default; set {} } // 0x000000018428A44C-0x000000018428A49C 0x000000018428AA34-0x000000018428AA88
	public bool bUseConeAttenuation { get => default; set {} } // 0x000000018428A4EC-0x000000018428A53C 0x000000018428AADC-0x000000018428AB30
	public float fInnerAngle { get => default; set {} } // 0x000000018428A67C-0x000000018428A6CC 0x000000018428AC88-0x000000018428ACE0
	public float fOuterAngle { get => default; set {} } // 0x000000018428A71C-0x000000018428A76C 0x000000018428AD38-0x000000018428AD90
	public float fConeMaxAttenuation { get => default; set {} } // 0x000000018428A62C-0x000000018428A67C 0x000000018428AC30-0x000000018428AC88
	public float LPFCone { get => default; set {} } // 0x000000018428A3AC-0x000000018428A3FC 0x000000018428A984-0x000000018428A9DC
	public float HPFCone { get => default; set {} } // 0x000000018428A30C-0x000000018428A35C 0x000000018428A8D4-0x000000018428A92C
	public float fMaxDistance { get => default; set {} } // 0x000000018428A6CC-0x000000018428A71C 0x000000018428ACE0-0x000000018428AD38
	public float fVolDryAtMaxDist { get => default; set {} } // 0x000000018428A80C-0x000000018428A85C 0x000000018428AE40-0x000000018428AE98
	public float fVolAuxGameDefAtMaxDist { get => default; set {} } // 0x000000018428A76C-0x000000018428A7BC 0x000000018428AD90-0x000000018428ADE8
	public float fVolAuxUserDefAtMaxDist { get => default; set {} } // 0x000000018428A7BC-0x000000018428A80C 0x000000018428ADE8-0x000000018428AE40
	public float LPFValueAtMaxDist { get => default; set {} } // 0x000000018428A3FC-0x000000018428A44C 0x000000018428A9DC-0x000000018428AA34
	public float HPFValueAtMaxDist { get => default; set {} } // 0x000000018428A35C-0x000000018428A3AC 0x000000018428A92C-0x000000018428A984

	// Constructors
	internal AkPositioningInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkPositioningInfo() {} // 0x000000018428A2BC-0x000000018428A30C

	// Methods
	internal static IntPtr getCPtr(AkPositioningInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428A8AC-0x000000018428A8D4
	~AkPositioningInfo() {} // 0x000000018428A248-0x000000018428A2BC
	public void Dispose() {} // 0x000000018428A0E4-0x000000018428A134
	protected virtual void Dispose(bool disposing) {} // 0x000000018428A134-0x000000018428A248
}

public enum AkPreparationType // TypeDefIndex: 52905
{
	Preparation_Load = 0,
	Preparation_Unload = 1,
	Preparation_LoadAndDecode = 2
}

public enum AkQueryRTPCValue // TypeDefIndex: 52906
{
	RTPCValue_Default = 0,
	RTPCValue_Global = 1,
	RTPCValue_GameObject = 2,
	RTPCValue_PlayingID = 3,
	RTPCValue_Unavailable = 4
}

public class AkRamp : IDisposable // TypeDefIndex: 52907
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fPrev { get => default; set {} } // 0x000000018428B1CC-0x000000018428B21C 0x000000018428B29C-0x000000018428B2F4
	public float fNext { get => default; set {} } // 0x000000018428B17C-0x000000018428B1CC 0x000000018428B244-0x000000018428B29C

	// Constructors
	internal AkRamp(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkRamp() {} // 0x000000018428B12C-0x000000018428B17C
	public AkRamp(float in_fPrev, float in_fNext) {} // 0x000000018428B0C4-0x000000018428B12C

	// Methods
	internal static IntPtr getCPtr(AkRamp obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428B21C-0x000000018428B244
	~AkRamp() {} // 0x000000018428B050-0x000000018428B0C4
	public void Dispose() {} // 0x000000018428B000-0x000000018428B050
	protected virtual void Dispose(bool disposing) {} // 0x000000018428AEEC-0x000000018428B000
}

public class AkReflectionPathInfo : IDisposable // TypeDefIndex: 52908
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkVector64 imageSource { get => default; set {} } // 0x000000018428B714-0x000000018428B780 0x000000018428B8E8-0x000000018428B954
	public uint numPathPoints { get => default; set {} } // 0x000000018428B820-0x000000018428B870 0x000000018428BA00-0x000000018428BA54
	public uint numReflections { get => default; set {} } // 0x000000018428B870-0x000000018428B8C0 0x000000018428BA54-0x000000018428BAA8
	public float level { get => default; set {} } // 0x000000018428B7D0-0x000000018428B820 0x000000018428B9A8-0x000000018428BA00
	public bool isOccluded { get => default; set {} } // 0x000000018428B780-0x000000018428B7D0 0x000000018428B954-0x000000018428B9A8

	// Constructors
	internal AkReflectionPathInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkReflectionPathInfo() {} // 0x000000018428B6C4-0x000000018428B714

	// Methods
	internal static IntPtr getCPtr(AkReflectionPathInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428B8C0-0x000000018428B8E8
	~AkReflectionPathInfo() {} // 0x000000018428B4C0-0x000000018428B534
	public void Dispose() {} // 0x000000018428B35C-0x000000018428B3AC
	protected virtual void Dispose(bool disposing) {} // 0x000000018428B3AC-0x000000018428B4C0
	public static int GetSizeOf() => default; // 0x000000018428B684-0x000000018428B6C4
	public Vector3 GetPathPoint(uint idx) => default; // 0x000000018428B60C-0x000000018428B684
	public AkAcousticSurface GetAcousticSurface(uint idx) => default; // 0x000000018428B534-0x000000018428B5B8
	public float GetDiffraction(uint idx) => default; // 0x000000018428B5B8-0x000000018428B60C
	public void Clone(AkReflectionPathInfo other) {} // 0x000000018428B2F4-0x000000018428B35C
}

public class AkResourceMonitorDataSummary : IDisposable // TypeDefIndex: 52909
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float totalCPU { get => default; set {} } // 0x000000018428BDC0-0x000000018428BE10 0x000000018428BFD8-0x000000018428C030
	public float pluginCPU { get => default; set {} } // 0x000000018428BD70-0x000000018428BDC0 0x000000018428BF80-0x000000018428BFD8
	public uint physicalVoices { get => default; set {} } // 0x000000018428BD20-0x000000018428BD70 0x000000018428BF2C-0x000000018428BF80
	public uint virtualVoices { get => default; set {} } // 0x000000018428BE60-0x000000018428BEB0 0x000000018428C084-0x000000018428C0D8
	public uint totalVoices { get => default; set {} } // 0x000000018428BE10-0x000000018428BE60 0x000000018428C030-0x000000018428C084
	public uint nbActiveEvents { get => default; set {} } // 0x000000018428BCD0-0x000000018428BD20 0x000000018428BED8-0x000000018428BF2C

	// Constructors
	internal AkResourceMonitorDataSummary(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkResourceMonitorDataSummary() {} // 0x000000018428BC80-0x000000018428BCD0

	// Methods
	internal static IntPtr getCPtr(AkResourceMonitorDataSummary obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428BEB0-0x000000018428BED8
	~AkResourceMonitorDataSummary() {} // 0x000000018428BC0C-0x000000018428BC80
	public void Dispose() {} // 0x000000018428BAA8-0x000000018428BAF8
	protected virtual void Dispose(bool disposing) {} // 0x000000018428BAF8-0x000000018428BC0C
}

public enum AKRESULT // TypeDefIndex: 52910
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

public class AkRoomParams : IDisposable // TypeDefIndex: 52911
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Vector3 Front { get => default; set {} } // 0x000000018428C2B0-0x000000018428C318 0x00000001831AD520-0x00000001831AD5B0
	public Vector3 Up { get => default; set {} } // 0x000000018428C4F8-0x000000018428C560 0x00000001831AD440-0x00000001831AD4D0
	public uint ReverbAuxBus { get => default; set {} } // 0x000000018428C318-0x000000018428C368 0x00000001831AD0A0-0x00000001831AD100
	public float ReverbLevel { get => default; set {} } // 0x000000018428C368-0x000000018428C3B8 0x00000001831AD380-0x00000001831AD3F0
	public float TransmissionLoss { get => default; set {} } // 0x000000018428C4A8-0x000000018428C4F8 0x00000001831AD2C0-0x00000001831AD330
	public float RoomGameObj_AuxSendLevelToSelf { get => default; set {} } // 0x000000018428C3B8-0x000000018428C408 0x00000001831AD200-0x00000001831AD270
	public bool RoomGameObj_KeepRegistered { get => default; set {} } // 0x000000018428C408-0x000000018428C458 0x00000001831AD150-0x00000001831AD1C0
	public uint RoomPriority { get => default; set {} } // 0x000000018428C458-0x000000018428C4A8 0x00000001831ACFF0-0x00000001831AD050

	// Constructors
	internal AkRoomParams(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkRoomParams() {} // 0x0000000183B0E670-0x0000000183B0E6C0

	// Methods
	internal static IntPtr getCPtr(AkRoomParams obj) => default; // 0x0000000182524410-0x0000000182524420
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428C560-0x000000018428C588
	~AkRoomParams() {} // 0x000000018428C23C-0x000000018428C2B0
	public void Dispose() {} // 0x000000018428C1EC-0x000000018428C23C
	protected virtual void Dispose(bool disposing) {} // 0x000000018428C0D8-0x000000018428C1EC
}

public class AkSegmentInfo : IDisposable // TypeDefIndex: 52912
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int iCurrentPosition { get => default; set {} } // 0x000000018428C940-0x000000018428C990 0x000000018428CC5C-0x000000018428CCB0
	public int iPreEntryDuration { get => default; set {} } // 0x000000018428C9E0-0x000000018428CA30 0x000000018428CD04-0x000000018428CD58
	public int iActiveDuration { get => default; set {} } // 0x000000018428C8F0-0x000000018428C940 0x000000018428CC08-0x000000018428CC5C
	public int iPostExitDuration { get => default; set {} } // 0x000000018428C990-0x000000018428C9E0 0x000000018428CCB0-0x000000018428CD04
	public int iRemainingLookAheadTime { get => default; set {} } // 0x000000018428CA30-0x000000018428CA80 0x000000018428CD58-0x000000018428CDAC
	public float fBeatDuration { get => default; set {} } // 0x000000018428C800-0x000000018428C850 0x000000018428CB00-0x000000018428CB58
	public float fBarDuration { get => default; set {} } // 0x000000018428C7B0-0x000000018428C800 0x000000018428CAA8-0x000000018428CB00
	public float fGridDuration { get => default; set {} } // 0x000000018428C850-0x000000018428C8A0 0x000000018428CB58-0x000000018428CBB0
	public float fGridOffset { get => default; set {} } // 0x000000018428C8A0-0x000000018428C8F0 0x000000018428CBB0-0x000000018428CC08

	// Constructors
	internal AkSegmentInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkSegmentInfo() {} // 0x000000018428C760-0x000000018428C7B0

	// Methods
	internal static IntPtr getCPtr(AkSegmentInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428CA80-0x000000018428CAA8
	~AkSegmentInfo() {} // 0x000000018428C6EC-0x000000018428C760
	public void Dispose() {} // 0x000000018428C588-0x000000018428C5D8
	protected virtual void Dispose(bool disposing) {} // 0x000000018428C5D8-0x000000018428C6EC
}

public class AkSerializedCallbackHeader : IDisposable // TypeDefIndex: 52913
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pPackage { get => default; } // 0x000000018428D0F0-0x000000018428D140 
	public uint eType { get => default; } // 0x000000018428D024-0x000000018428D074 
	public AkSerializedCallbackHeader pNext { get => default; } // 0x000000018428D074-0x000000018428D0F0 

	// Constructors
	internal AkSerializedCallbackHeader(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkSerializedCallbackHeader() {} // 0x000000018428CFD4-0x000000018428D024

	// Methods
	internal static IntPtr getCPtr(AkSerializedCallbackHeader obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018428D140-0x000000018428D168
	~AkSerializedCallbackHeader() {} // 0x000000018428CF10-0x000000018428CF84
	public void Dispose() {} // 0x000000018428CDAC-0x000000018428CDFC
	protected virtual void Dispose(bool disposing) {} // 0x000000018428CDFC-0x000000018428CF10
	public IntPtr GetData() => default; // 0x000000018428CF84-0x000000018428CFD4
}

public enum AkSetPositionFlags // TypeDefIndex: 52914
{
	AkSetPositionFlags_Emitter = 1,
	AkSetPositionFlags_Listener = 2,
	AkSetPositionFlags_Default = 3
}

public enum AkSourceChannelOrdering // TypeDefIndex: 52915
{
	SourceChannelOrdering_Standard = 0,
	SourceChannelOrdering_Film = 1,
	SourceChannelOrdering_FuMa = 2,
	SourceChannelOrdering_Last = 3
}

public class AkSourceSettings : IDisposable // TypeDefIndex: 52916
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint sourceID { get => default; set {} } // 0x00000001842A5EDC-0x00000001842A5F2C 0x00000001842A5FF8-0x00000001842A604C
	public IntPtr pMediaMemory { get => default; set {} } // 0x00000001842A5E8C-0x00000001842A5EDC 0x00000001842A5FA4-0x00000001842A5FF8
	public uint uMediaSize { get => default; set {} } // 0x00000001842A5F2C-0x00000001842A5F7C 0x00000001842A604C-0x00000001842A60A0

	// Constructors
	internal AkSourceSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkSourceSettings() {} // 0x00000001842A5E3C-0x00000001842A5E8C

	// Methods
	internal static IntPtr getCPtr(AkSourceSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A5F7C-0x00000001842A5FA4
	~AkSourceSettings() {} // 0x00000001842A5D88-0x00000001842A5DFC
	public void Dispose() {} // 0x00000001842A5C24-0x00000001842A5C74
	protected virtual void Dispose(bool disposing) {} // 0x00000001842A5C74-0x00000001842A5D88
	public void Clear() {} // 0x00000001842A5B6C-0x00000001842A5BBC
	public static int GetSizeOf() => default; // 0x00000001842A5DFC-0x00000001842A5E3C
	public void Clone(AkSourceSettings other) {} // 0x00000001842A5BBC-0x00000001842A5C24
}

public class AkSpatialAudioInitSettings : IDisposable // TypeDefIndex: 52917
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxSoundPropagationDepth { get => default; set {} } // 0x00000001842A6320-0x00000001842A6370 0x0000000182A036B0-0x0000000182A03710
	public float fMovementThreshold { get => default; set {} } // 0x00000001842A6230-0x00000001842A6280 0x0000000182A03600-0x0000000182A03660
	public uint uNumberOfPrimaryRays { get => default; set {} } // 0x0000000182A020C0-0x0000000182A02110 0x0000000182A03560-0x0000000182A035C0
	public uint uMaxReflectionOrder { get => default; set {} } // 0x0000000182A03B40-0x0000000182A03B90 0x0000000182A034C0-0x0000000182A03520
	public uint uMaxDiffractionOrder { get => default; set {} } // 0x0000000182A03AB0-0x0000000182A03B00 0x0000000182A03420-0x0000000182A03480
	public uint uMaxEmitterRoomAuxSends { get => default; set {} } // 0x00000001842A62D0-0x00000001842A6320 0x0000000182A03380-0x0000000182A033E0
	public uint uDiffractionOnReflectionsOrder { get => default; set {} } // 0x00000001842A6280-0x00000001842A62D0 0x0000000182A032E0-0x0000000182A03340
	public float fMaxPathLength { get => default; set {} } // 0x00000001842A61E0-0x00000001842A6230 0x0000000182A03230-0x0000000182A03290
	public float fCPULimitPercentage { get => default; set {} } // 0x00000001842A6190-0x00000001842A61E0 0x0000000182A03180-0x0000000182A031E0
	public uint uLoadBalancingSpread { get => default; set {} } // 0x0000000182A03A20-0x0000000182A03A70 0x0000000182A030E0-0x0000000182A03140
	public bool bEnableGeometricDiffractionAndTransmission { get => default; set {} } // 0x00000001842A6140-0x00000001842A6190 0x0000000182A03030-0x0000000182A03090
	public bool bCalcEmitterVirtualPosition { get => default; set {} } // 0x00000001842A60F0-0x00000001842A6140 0x0000000182A02F80-0x0000000182A02FE0

	// Constructors
	internal AkSpatialAudioInitSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkSpatialAudioInitSettings() {} // 0x0000000182A02D80-0x0000000182A02DE0

	// Methods
	internal static IntPtr getCPtr(AkSpatialAudioInitSettings obj) => default; // 0x0000000182524410-0x0000000182524420
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A6370-0x00000001842A6398
	~AkSpatialAudioInitSettings() {} // 0x0000000183891700-0x0000000183891750
	public void Dispose() {} // 0x00000001842A60A0-0x00000001842A60F0
	protected virtual void Dispose(bool disposing) {} // 0x0000000183891750-0x0000000183891A80
}

public enum AkSpeakerPanningType // TypeDefIndex: 52918
{
	AK_DirectSpeakerAssignment = 0,
	AK_BalanceFadeHeight = 1,
	AK_SteeringPanner = 2
}

public class AkStdMovePolicy : IDisposable // TypeDefIndex: 52919
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkStdMovePolicy(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkStdMovePolicy() {} // 0x00000001842A65B0-0x00000001842A6600

	// Methods
	internal static IntPtr getCPtr(AkStdMovePolicy obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A6600-0x00000001842A6628
	~AkStdMovePolicy() {} // 0x00000001842A64FC-0x00000001842A6570
	public void Dispose() {} // 0x00000001842A6398-0x00000001842A63E8
	protected virtual void Dispose(bool disposing) {} // 0x00000001842A63E8-0x00000001842A64FC
	public static bool IsTrivial() => default; // 0x00000001842A6570-0x00000001842A65B0
}

public class AkStreamMgrSettings : IDisposable // TypeDefIndex: 52920
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	public AkStreamMgrSettings() {} // Dummy constructor
	internal AkStreamMgrSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0

	// Methods
	internal static IntPtr getCPtr(AkStreamMgrSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A6678-0x00000001842A66A0
	~AkStreamMgrSettings() {} // 0x0000000183A508F0-0x0000000183A50940
	public void Dispose() {} // 0x00000001842A6628-0x00000001842A6678
	protected virtual void Dispose(bool disposing) {} // 0x0000000183A50940-0x0000000183A50BD0
}

public class AkTransform : IDisposable // TypeDefIndex: 52921
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkTransform(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkTransform() {} // 0x00000001842A6D64-0x00000001842A6DB4

	// Methods
	internal static IntPtr getCPtr(AkTransform obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A6DB4-0x00000001842A6DDC
	~AkTransform() {} // 0x00000001842A6804-0x00000001842A6878
	public void Dispose() {} // 0x00000001842A67B4-0x00000001842A6804
	protected virtual void Dispose(bool disposing) {} // 0x00000001842A66A0-0x00000001842A67B4
	public Vector3 Position() => default; // 0x00000001842A6948-0x00000001842A69B0
	public Vector3 OrientationFront() => default; // 0x00000001842A6878-0x00000001842A68E0
	public Vector3 OrientationTop() => default; // 0x00000001842A68E0-0x00000001842A6948
	public void Set(Vector3 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop) {} // 0x00000001842A6BD0-0x00000001842A6C84
	public void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) {} // 0x00000001842A6C84-0x00000001842A6D64
	public void SetPosition(Vector3 in_position) {} // 0x00000001842A6AE8-0x00000001842A6B50
	public void SetPosition(float in_x, float in_y, float in_z) {} // 0x00000001842A6B50-0x00000001842A6BD0
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop) {} // 0x00000001842A69B0-0x00000001842A6A3C
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) {} // 0x00000001842A6A3C-0x00000001842A6AE8
}

public class AkTriangle : IDisposable // TypeDefIndex: 52922
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ushort point0 { get => default; set {} } // 0x00000001842A7180-0x00000001842A71D0 0x00000001842A72E8-0x00000001842A733C
	public ushort point1 { get => default; set {} } // 0x00000001842A71D0-0x00000001842A7220 0x00000001842A733C-0x00000001842A7390
	public ushort point2 { get => default; set {} } // 0x00000001842A7220-0x00000001842A7270 0x00000001842A7390-0x00000001842A73E4
	public ushort surface { get => default; set {} } // 0x00000001842A7270-0x00000001842A72C0 0x00000001842A73E4-0x00000001842A7438

	// Constructors
	internal AkTriangle(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkTriangle() {} // 0x00000001842A70AC-0x00000001842A70FC
	public AkTriangle(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo) {} // 0x00000001842A70FC-0x00000001842A7180

	// Methods
	internal static IntPtr getCPtr(AkTriangle obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A72C0-0x00000001842A72E8
	~AkTriangle() {} // 0x00000001842A6FF8-0x00000001842A706C
	public void Dispose() {} // 0x00000001842A6FA8-0x00000001842A6FF8
	protected virtual void Dispose(bool disposing) {} // 0x00000001842A6E94-0x00000001842A6FA8
	public void Clear() {} // 0x00000001842A6DDC-0x00000001842A6E2C
	public static int GetSizeOf() => default; // 0x00000001842A706C-0x00000001842A70AC
	public void Clone(AkTriangle other) {} // 0x00000001842A6E2C-0x00000001842A6E94
}

public class AkTrivialStdMovePolicy : IDisposable // TypeDefIndex: 52923
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkTrivialStdMovePolicy(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkTrivialStdMovePolicy() {} // 0x00000001842A7650-0x00000001842A76A0

	// Methods
	internal static IntPtr getCPtr(AkTrivialStdMovePolicy obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A76A0-0x00000001842A76C8
	~AkTrivialStdMovePolicy() {} // 0x00000001842A759C-0x00000001842A7610
	public void Dispose() {} // 0x00000001842A754C-0x00000001842A759C
	protected virtual void Dispose(bool disposing) {} // 0x00000001842A7438-0x00000001842A754C
	public static bool IsTrivial() => default; // 0x00000001842A7610-0x00000001842A7650
}

public class AkWorldTransform : IDisposable // TypeDefIndex: 52924
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkWorldTransform(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkWorldTransform() {} // 0x00000001842A7D98-0x00000001842A7DE8

	// Methods
	internal static IntPtr getCPtr(AkWorldTransform obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A7DE8-0x00000001842A7E10
	~AkWorldTransform() {} // 0x00000001842A782C-0x00000001842A78A0
	public void Dispose() {} // 0x00000001842A76C8-0x00000001842A7718
	protected virtual void Dispose(bool disposing) {} // 0x00000001842A7718-0x00000001842A782C
	public AkVector64 Position() => default; // 0x00000001842A7970-0x00000001842A79DC
	public Vector3 OrientationFront() => default; // 0x00000001842A78A0-0x00000001842A7908
	public Vector3 OrientationTop() => default; // 0x00000001842A7908-0x00000001842A7970
	public void Set(AkVector64 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop) {} // 0x00000001842A7CE0-0x00000001842A7D98
	public void Set(double in_positionX, double in_positionY, double in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) {} // 0x00000001842A7C00-0x00000001842A7CE0
	public void SetPosition(AkVector64 in_position) {} // 0x00000001842A7B14-0x00000001842A7B80
	public void SetPosition(double in_x, double in_y, double in_z) {} // 0x00000001842A7B80-0x00000001842A7C00
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop) {} // 0x00000001842A7A88-0x00000001842A7B14
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ) {} // 0x00000001842A79DC-0x00000001842A7A88
}

public class MonitorErrorInfo : IDisposable // TypeDefIndex: 52925
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public string m_name { get => default; set {} } // 0x00000001842A8164-0x00000001842A81D0 0x00000001842A824C-0x00000001842A82A0
	public string m_message { get => default; set {} } // 0x00000001842A80F8-0x00000001842A8164 0x00000001842A81F8-0x00000001842A824C

	// Constructors
	internal MonitorErrorInfo(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public MonitorErrorInfo(string in_name, string in_message) {} // 0x00000001842A7FE8-0x00000001842A8050
	public MonitorErrorInfo(string in_name) {} // 0x00000001842A8050-0x00000001842A80A8
	public MonitorErrorInfo() {} // 0x00000001842A80A8-0x00000001842A80F8

	// Methods
	internal static IntPtr getCPtr(MonitorErrorInfo obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A81D0-0x00000001842A81F8
	~MonitorErrorInfo() {} // 0x00000001842A7F74-0x00000001842A7FE8
	public void Dispose() {} // 0x00000001842A7F24-0x00000001842A7F74
	protected virtual void Dispose(bool disposing) {} // 0x00000001842A7E10-0x00000001842A7F24
}

public class MsgContext : IDisposable // TypeDefIndex: 52926
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint in_playingID { get => default; set {} } // 0x00000001842A8710-0x00000001842A8760 0x00000001842A8880-0x00000001842A88D4
	public ulong in_gameObjID { get => default; set {} } // 0x00000001842A86C0-0x00000001842A8710 0x00000001842A882C-0x00000001842A8880
	public uint in_soundID { get => default; set {} } // 0x00000001842A8760-0x00000001842A87B0 0x00000001842A88D4-0x00000001842A8928
	public bool in_bIsBus { get => default; set {} } // 0x00000001842A8670-0x00000001842A86C0 0x00000001842A87D8-0x00000001842A882C

	// Constructors
	internal MsgContext(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public MsgContext(uint pId, ulong goId, uint nodeId, bool isBus) {} // 0x00000001842A85F4-0x00000001842A8670
	public MsgContext(uint pId, ulong goId, uint nodeId) {} // 0x00000001842A8478-0x00000001842A84EC
	public MsgContext(uint pId, ulong goId) {} // 0x00000001842A8590-0x00000001842A85F4
	public MsgContext(uint pId) {} // 0x00000001842A853C-0x00000001842A8590
	public MsgContext() {} // 0x00000001842A84EC-0x00000001842A853C

	// Methods
	internal static IntPtr getCPtr(MsgContext obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842A87B0-0x00000001842A87D8
	~MsgContext() {} // 0x00000001842A8404-0x00000001842A8478
	public void Dispose() {} // 0x00000001842A83B4-0x00000001842A8404
	protected virtual void Dispose(bool disposing) {} // 0x00000001842A82A0-0x00000001842A83B4
}

public class AkCommunicationSettings : IDisposable // TypeDefIndex: 52928
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uPoolSize { get => default; set {} } // 0x000000018427E9C4-0x000000018427EA14 0x000000018427EBE0-0x000000018427EC34
	public ushort uDiscoveryBroadcastPort { get => default; set {} } // 0x000000018427E974-0x000000018427E9C4 0x000000018427EB8C-0x000000018427EBE0
	public ushort uCommandPort { get => default; set {} } // 0x000000018427E924-0x000000018427E974 0x000000018427EB38-0x000000018427EB8C
	public AkCommSystem commSystem { get => default; set {} } // 0x000000018427E868-0x000000018427E8B8 0x000000018427EA90-0x000000018427EAE4
	public bool bInitSystemLib { get => default; set {} } // 0x000000018427E818-0x000000018427E868 0x000000018427EA3C-0x000000018427EA90
	public string szAppNetworkName { get => default; set {} } // 0x000000018427E8B8-0x000000018427E924 0x000000018427EAE4-0x000000018427EB38

	// Nested types
	public enum AkCommSystem // TypeDefIndex: 52927
	{
		AkCommSystem_Socket = 0,
		AkCommSystem_HTCS = 1
	}

	// Constructors
	internal AkCommunicationSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkCommunicationSettings() {} // 0x000000018427E7C8-0x000000018427E818

	// Methods
	internal static IntPtr getCPtr(AkCommunicationSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x000000018427EA14-0x000000018427EA3C
	~AkCommunicationSettings() {} // 0x000000018427E754-0x000000018427E7C8
	public void Dispose() {} // 0x000000018427E5F0-0x000000018427E640
	protected virtual void Dispose(bool disposing) {} // 0x000000018427E640-0x000000018427E754
}

public class AkPlatformInitSettings : IDisposable // TypeDefIndex: 52929
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkThreadProperties threadLEngine { get => default; set {} } // 0x0000000184287E6C-0x0000000184287EE8 0x0000000184288208-0x0000000184288270
	public AkThreadProperties threadOutputMgr { get => default; set {} } // 0x0000000184287F64-0x0000000184287FE0 0x00000001842882D8-0x0000000184288340
	public AkThreadProperties threadBankManager { get => default; set {} } // 0x0000000184287DF0-0x0000000184287E6C 0x00000001842881A0-0x0000000184288208
	public AkThreadProperties threadMonitor { get => default; set {} } // 0x0000000184287EE8-0x0000000184287F64 0x0000000184288270-0x00000001842882D8
	public ushort uNumRefillsInVoice { get => default; set {} } // 0x0000000184288030-0x0000000184288080 0x0000000182A041F0-0x0000000182A04250
	public uint uSampleRate { get => default; set {} } // 0x0000000184288080-0x00000001842880D0 0x0000000182A042A0-0x0000000182A04300
	public bool bEnableAvxSupport { get => default; set {} } // 0x0000000184287D50-0x0000000184287DA0 0x00000001842880F8-0x000000018428814C
	public uint uMaxSystemAudioObjects { get => default; set {} } // 0x0000000184287FE0-0x0000000184288030 0x0000000183C977B0-0x0000000183C97810
	public bool bEnableDirectInputSupport { get => default; set {} } // 0x0000000184287DA0-0x0000000184287DF0 0x000000018428814C-0x00000001842881A0

	// Constructors
	public AkPlatformInitSettings() {} // Dummy constructor
	internal AkPlatformInitSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0

	// Methods
	internal static IntPtr getCPtr(AkPlatformInitSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842880D0-0x00000001842880F8
	~AkPlatformInitSettings() {} // 0x0000000183924210-0x0000000183924260
	public void Dispose() {} // 0x0000000184287D00-0x0000000184287D50
	protected virtual void Dispose(bool disposing) {} // 0x0000000183924260-0x0000000183924510
}

internal class AkSoundEnginePINVOKE // TypeDefIndex: 52930
{
	// Constructors
	static AkSoundEnginePINVOKE() {} // 0x000000018350B670-0x000000018350B680
	public AkSoundEnginePINVOKE() {} // 0x000000018350B670-0x000000018350B680

	// Methods
	public static extern uint CSharp_JoystickIdToWwiseId(uint jarg1); // 0x000000018429C188-0x000000018429C200
	public static extern uint CSharp_AK_INVALID_SHARE_SET_ID_get(); // 0x000000018428D3C8-0x000000018428D3F4
	public static extern uint CSharp_AK_INVALID_PIPELINE_ID_get(); // 0x000000018428D39C-0x000000018428D3C8
	public static extern ulong CSharp_AK_INVALID_AUDIO_OBJECT_ID_get(); // 0x000000018428D2A0-0x000000018428D308
	public static extern uint CSharp_AK_SOUNDBANK_VERSION_get(); // 0x000000018428D4D0-0x000000018428D538
	public static extern uint CSharp_AkJobType_Generic_get(); // 0x0000000184291E0C-0x0000000184291E38
	public static extern uint CSharp_AkJobType_AudioProcessing_get(); // 0x0000000184291DE0-0x0000000184291E0C
	public static extern uint CSharp_AkJobType_SpatialAudio_get(); // 0x0000000184291E38-0x0000000184291EA0
	public static extern uint CSharp_AK_NUM_JOB_TYPES_get(); // 0x000000018428D4A4-0x000000018428D4D0
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2); // 0x000000018428E5B4-0x000000018428E5F4
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerFrame_get(IntPtr jarg1); // 0x000000018428E580-0x000000018428E5B4
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(IntPtr jarg1, uint jarg2); // 0x000000018428E628-0x000000018428E668
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerSecond_get(IntPtr jarg1); // 0x000000018428E5F4-0x000000018428E628
	public static extern IntPtr CSharp_new_AkAudioSettings(); // 0x00000001842A4724-0x00000001842A4750
	public static extern void CSharp_delete_AkAudioSettings(IntPtr jarg1); // 0x00000001842A3778-0x00000001842A37AC
	public static extern void CSharp_AkDeviceDescription_idDevice_set(IntPtr jarg1, uint jarg2); // 0x000000018428FC2C-0x000000018428FC6C
	public static extern uint CSharp_AkDeviceDescription_idDevice_get(IntPtr jarg1); // 0x0000000183618180-0x00000001836181C0
	public static extern void CSharp_AkDeviceDescription_deviceName_set(IntPtr jarg1, string jarg2); // 0x000000018428FB2C-0x000000018428FBB8
	public static extern IntPtr CSharp_AkDeviceDescription_deviceName_get(IntPtr jarg1); // 0x000000018428FAF8-0x000000018428FB2C
	public static extern void CSharp_AkDeviceDescription_deviceStateMask_set(IntPtr jarg1, int jarg2); // 0x000000018428FBEC-0x000000018428FC2C
	public static extern int CSharp_AkDeviceDescription_deviceStateMask_get(IntPtr jarg1); // 0x000000018428FBB8-0x000000018428FBEC
	public static extern void CSharp_AkDeviceDescription_isDefaultDevice_set(IntPtr jarg1, bool jarg2); // 0x000000018428FC6C-0x000000018428FCB0
	public static extern bool CSharp_AkDeviceDescription_isDefaultDevice_get(IntPtr jarg1); // 0x0000000183617FD0-0x0000000183618010
	public static extern void CSharp_AkDeviceDescription_Clear(IntPtr jarg1); // 0x0000000183799C20-0x0000000183799C60
	public static extern int CSharp_AkDeviceDescription_GetSizeOf(); // 0x0000000183694FF0-0x0000000183695400
	public static extern void CSharp_AkDeviceDescription_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018428FAB4-0x000000018428FAF8
	public static extern IntPtr CSharp_new_AkDeviceDescription(); // 0x00000001842A4904-0x00000001842A4930
	public static extern void CSharp_delete_AkDeviceDescription(IntPtr jarg1); // 0x00000001842A394C-0x00000001842A3980
	public static extern AkVector64 CSharp_AkWorldTransform_Position(IntPtr jarg1); // 0x00000001842986CC-0x0000000184298764
	public static extern Vector3 CSharp_AkWorldTransform_OrientationFront(IntPtr jarg1); // 0x00000001842985A4-0x0000000184298638
	public static extern Vector3 CSharp_AkWorldTransform_OrientationTop(IntPtr jarg1); // 0x0000000184298638-0x00000001842986CC
	public static extern void CSharp_AkWorldTransform_Set__SWIG_0(IntPtr jarg1, AkVector64 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x000000018429897C-0x0000000184298A58
	public static extern void CSharp_AkWorldTransform_Set__SWIG_1(IntPtr jarg1, double jarg2, double jarg3, double jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10); // 0x0000000184298A58-0x0000000184298AC0
	public static extern void CSharp_AkWorldTransform_SetPosition__SWIG_0(IntPtr jarg1, AkVector64 jarg2); // 0x0000000184298880-0x000000018429891C
	public static extern void CSharp_AkWorldTransform_SetPosition__SWIG_1(IntPtr jarg1, double jarg2, double jarg3, double jarg4); // 0x000000018429891C-0x000000018429897C
	public static extern void CSharp_AkWorldTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3); // 0x0000000184298764-0x0000000184298820
	public static extern void CSharp_AkWorldTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7); // 0x0000000184298820-0x0000000184298880
	public static extern IntPtr CSharp_new_AkWorldTransform(); // 0x00000001842A57AC-0x00000001842A57D8
	public static extern void CSharp_delete_AkWorldTransform(IntPtr jarg1); // 0x00000001842A4444-0x00000001842A4478
	public static extern Vector3 CSharp_AkTransform_Position(IntPtr jarg1); // 0x0000000184298084-0x0000000184298118
	public static extern Vector3 CSharp_AkTransform_OrientationFront(IntPtr jarg1); // 0x0000000184297F5C-0x0000000184297FF0
	public static extern Vector3 CSharp_AkTransform_OrientationTop(IntPtr jarg1); // 0x0000000184297FF0-0x0000000184298084
	public static extern void CSharp_AkTransform_Set__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x00000001831ADC80-0x00000001831ADD20
	public static extern void CSharp_AkTransform_Set__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10); // 0x000000018429832C-0x0000000184298394
	public static extern void CSharp_AkTransform_SetPosition__SWIG_0(IntPtr jarg1, Vector3 jarg2); // 0x0000000184298234-0x00000001842982CC
	public static extern void CSharp_AkTransform_SetPosition__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4); // 0x00000001842982CC-0x000000018429832C
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3); // 0x0000000184298118-0x00000001842981D4
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7); // 0x00000001842981D4-0x0000000184298234
	public static extern IntPtr CSharp_new_AkTransform(); // 0x0000000182A01BB0-0x0000000182A01BE0
	public static extern void CSharp_delete_AkTransform(IntPtr jarg1); // 0x00000001842A4374-0x00000001842A43A8
	public static extern Vector3 CSharp_ConvertAkVector64ToAkVector(AkVector64 jarg1); // 0x0000000184298F4C-0x0000000184298FF8
	public static extern IntPtr CSharp_ConvertAkWorldTransformToAkTransform(IntPtr jarg1); // 0x00000001842990A4-0x00000001842990D8
	public static extern AkVector64 CSharp_ConvertAkVectorToAkVector64(Vector3 jarg1); // 0x0000000184298FF8-0x00000001842990A4
	public static extern IntPtr CSharp_ConvertAkTransformToAkWorldTransform(IntPtr jarg1); // 0x0000000184298F18-0x0000000184298F4C
	public static extern void CSharp_AkObstructionOcclusionValues_occlusion_set(IntPtr jarg1, float jarg2); // 0x0000000184294B34-0x0000000184294B78
	public static extern float CSharp_AkObstructionOcclusionValues_occlusion_get(IntPtr jarg1); // 0x0000000184294B00-0x0000000184294B34
	public static extern void CSharp_AkObstructionOcclusionValues_obstruction_set(IntPtr jarg1, float jarg2); // 0x0000000184294ABC-0x0000000184294B00
	public static extern float CSharp_AkObstructionOcclusionValues_obstruction_get(IntPtr jarg1); // 0x0000000184294A88-0x0000000184294ABC
	public static extern void CSharp_AkObstructionOcclusionValues_Clear(IntPtr jarg1); // 0x00000001842949E4-0x0000000184294A18
	public static extern int CSharp_AkObstructionOcclusionValues_GetSizeOf(); // 0x0000000184294A5C-0x0000000184294A88
	public static extern void CSharp_AkObstructionOcclusionValues_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000184294A18-0x0000000184294A5C
	public static extern IntPtr CSharp_new_AkObstructionOcclusionValues(); // 0x00000001842A50C0-0x00000001842A50EC
	public static extern void CSharp_delete_AkObstructionOcclusionValues(IntPtr jarg1); // 0x00000001842A3FCC-0x00000001842A4000
	public static extern void CSharp_AkChannelEmitter_position_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018428F554-0x000000018428F598
	public static extern IntPtr CSharp_AkChannelEmitter_position_get(IntPtr jarg1); // 0x000000018428F518-0x000000018428F554
	public static extern void CSharp_AkChannelEmitter_uInputChannels_set(IntPtr jarg1, uint jarg2); // 0x000000018428F5CC-0x000000018428F60C
	public static extern uint CSharp_AkChannelEmitter_uInputChannels_get(IntPtr jarg1); // 0x000000018428F598-0x000000018428F5CC
	public static extern void CSharp_AkChannelEmitter_padding_set(IntPtr jarg1, string jarg2); // 0x000000018428F484-0x000000018428F518
	public static extern IntPtr CSharp_AkChannelEmitter_padding_get(IntPtr jarg1); // 0x000000018428F450-0x000000018428F484
	public static extern void CSharp_delete_AkChannelEmitter(IntPtr jarg1); // 0x00000001842A38E4-0x00000001842A3918
	public static extern void CSharp_AkAuxSendValue_listenerID_set(IntPtr jarg1, ulong jarg2); // 0x000000018428E95C-0x000000018428E9E0
	public static extern ulong CSharp_AkAuxSendValue_listenerID_get(IntPtr jarg1); // 0x000000018428E8E4-0x000000018428E95C
	public static extern void CSharp_AkAuxSendValue_auxBusID_set(IntPtr jarg1, uint jarg2); // 0x000000018428E7F4-0x000000018428E874
	public static extern uint CSharp_AkAuxSendValue_auxBusID_get(IntPtr jarg1); // 0x000000018428E7C0-0x000000018428E7F4
	public static extern void CSharp_AkAuxSendValue_fControlValue_set(IntPtr jarg1, float jarg2); // 0x000000018428E8A0-0x000000018428E8E4
	public static extern float CSharp_AkAuxSendValue_fControlValue_get(IntPtr jarg1); // 0x000000018428E874-0x000000018428E8A0
	public static extern void CSharp_AkAuxSendValue_Set(IntPtr jarg1, ulong jarg2, uint jarg3, float jarg4); // 0x000000018428E764-0x000000018428E7C0
	public static extern bool CSharp_AkAuxSendValue_IsSame(IntPtr jarg1, ulong jarg2, uint jarg3); // 0x000000018428E6CC-0x000000018428E764
	public static extern int CSharp_AkAuxSendValue_GetSizeOf(); // 0x000000018428E6A0-0x000000018428E6CC
	public static extern void CSharp_delete_AkAuxSendValue(IntPtr jarg1); // 0x00000001842A37E0-0x00000001842A3814
	public static extern IntPtr CSharp_new_AkRamp__SWIG_0(); // 0x00000001842A5504-0x00000001842A5538
	public static extern IntPtr CSharp_new_AkRamp__SWIG_1(float jarg1, float jarg2); // 0x00000001842A5538-0x00000001842A557C
	public static extern void CSharp_AkRamp_fPrev_set(IntPtr jarg1, float jarg2); // 0x0000000184296B48-0x0000000184296B8C
	public static extern float CSharp_AkRamp_fPrev_get(IntPtr jarg1); // 0x0000000184296B14-0x0000000184296B48
	public static extern void CSharp_AkRamp_fNext_set(IntPtr jarg1, float jarg2); // 0x0000000184296AD8-0x0000000184296B14
	public static extern float CSharp_AkRamp_fNext_get(IntPtr jarg1); // 0x0000000184296AA4-0x0000000184296AD8
	public static extern void CSharp_delete_AkRamp(IntPtr jarg1); // 0x00000001842A416C-0x00000001842A41A0
	public static extern ushort CSharp_AK_INT_get(); // 0x000000018428D238-0x000000018428D2A0
	public static extern ushort CSharp_AK_FLOAT_get(); // 0x000000018428D168-0x000000018428D1D0
	public static extern byte CSharp_AK_INTERLEAVED_get(); // 0x000000018428D1D0-0x000000018428D238
	public static extern byte CSharp_AK_NONINTERLEAVED_get(); // 0x000000018428D478-0x000000018428D4A4
	public static extern uint CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get(); // 0x000000018428D3F4-0x000000018428D420
	public static extern uint CSharp_AK_LE_NATIVE_SAMPLETYPE_get(); // 0x000000018428D44C-0x000000018428D478
	public static extern uint CSharp_AK_LE_NATIVE_INTERLEAVE_get(); // 0x000000018428D420-0x000000018428D44C
	public static extern void CSharp_AkAudioFormat_uSampleRate_set(IntPtr jarg1, uint jarg2); // 0x000000018428E494-0x000000018428E4D4
	public static extern uint CSharp_AkAudioFormat_uSampleRate_get(IntPtr jarg1); // 0x000000018428E460-0x000000018428E494
	public static extern void CSharp_AkAudioFormat_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018428E284-0x000000018428E304
	public static extern IntPtr CSharp_AkAudioFormat_channelConfig_get(IntPtr jarg1); // 0x000000018428E248-0x000000018428E284
	public static extern void CSharp_AkAudioFormat_uBitsPerSample_set(IntPtr jarg1, uint jarg2); // 0x000000018428E338-0x000000018428E378
	public static extern uint CSharp_AkAudioFormat_uBitsPerSample_get(IntPtr jarg1); // 0x000000018428E304-0x000000018428E338
	public static extern void CSharp_AkAudioFormat_uBlockAlign_set(IntPtr jarg1, uint jarg2); // 0x000000018428E3AC-0x000000018428E3EC
	public static extern uint CSharp_AkAudioFormat_uBlockAlign_get(IntPtr jarg1); // 0x000000018428E378-0x000000018428E3AC
	public static extern void CSharp_AkAudioFormat_uTypeID_set(IntPtr jarg1, uint jarg2); // 0x000000018428E508-0x000000018428E548
	public static extern uint CSharp_AkAudioFormat_uTypeID_get(IntPtr jarg1); // 0x000000018428E4D4-0x000000018428E508
	public static extern void CSharp_AkAudioFormat_uInterleaveID_set(IntPtr jarg1, uint jarg2); // 0x000000018428E420-0x000000018428E460
	public static extern uint CSharp_AkAudioFormat_uInterleaveID_get(IntPtr jarg1); // 0x000000018428E3EC-0x000000018428E420
	public static extern uint CSharp_AkAudioFormat_GetNumChannels(IntPtr jarg1); // 0x000000018428E140-0x000000018428E174
	public static extern uint CSharp_AkAudioFormat_GetBitsPerSample(IntPtr jarg1); // 0x000000018428E060-0x000000018428E0D8
	public static extern uint CSharp_AkAudioFormat_GetBlockAlign(IntPtr jarg1); // 0x000000018428E0D8-0x000000018428E10C
	public static extern uint CSharp_AkAudioFormat_GetTypeID(IntPtr jarg1); // 0x000000018428E174-0x000000018428E1A8
	public static extern uint CSharp_AkAudioFormat_GetInterleaveID(IntPtr jarg1); // 0x000000018428E10C-0x000000018428E140
	public static extern void CSharp_AkAudioFormat_SetAll(IntPtr jarg1, uint jarg2, IntPtr jarg3, uint jarg4, uint jarg5, uint jarg6, uint jarg7); // 0x000000018428E1A8-0x000000018428E248
	public static extern IntPtr CSharp_new_AkAudioFormat(); // 0x00000001842A46CC-0x00000001842A46F8
	public static extern void CSharp_delete_AkAudioFormat(IntPtr jarg1); // 0x00000001842A36CC-0x00000001842A3744
	public static extern bool CSharp_IsBankCodecID(uint jarg1); // 0x000000018429C0BC-0x000000018429C0F4
	public static extern IntPtr CSharp_new_Ak3dData(); // 0x00000001842A4674-0x00000001842A46A0
	public static extern void CSharp_Ak3dData_xform_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018428DE74-0x000000018428DEB8
	public static extern IntPtr CSharp_Ak3dData_xform_get(IntPtr jarg1); // 0x000000018428DE38-0x000000018428DE74
	public static extern void CSharp_Ak3dData_spread_set(IntPtr jarg1, float jarg2); // 0x000000018428DD80-0x000000018428DDC4
	public static extern float CSharp_Ak3dData_spread_get(IntPtr jarg1); // 0x000000018428DD4C-0x000000018428DD80
	public static extern void CSharp_Ak3dData_focus_set(IntPtr jarg1, float jarg2); // 0x000000018428DD08-0x000000018428DD4C
	public static extern float CSharp_Ak3dData_focus_get(IntPtr jarg1); // 0x000000018428DCD4-0x000000018428DD08
	public static extern void CSharp_Ak3dData_uEmitterChannelMask_set(IntPtr jarg1, uint jarg2); // 0x000000018428DDF8-0x000000018428DE38
	public static extern uint CSharp_Ak3dData_uEmitterChannelMask_get(IntPtr jarg1); // 0x000000018428DDC4-0x000000018428DDF8
	public static extern void CSharp_delete_Ak3dData(IntPtr jarg1); // 0x00000001842A3620-0x00000001842A3698
	public static extern IntPtr CSharp_new_AkBehavioralPositioningData(); // 0x00000001842A47A8-0x00000001842A47D4
	public static extern void CSharp_AkBehavioralPositioningData_center_set(IntPtr jarg1, float jarg2); // 0x000000018428EA14-0x000000018428EA58
	public static extern float CSharp_AkBehavioralPositioningData_center_get(IntPtr jarg1); // 0x000000018428E9E0-0x000000018428EA14
	public static extern void CSharp_AkBehavioralPositioningData_panLR_set(IntPtr jarg1, float jarg2); // 0x000000018428EBE8-0x000000018428EC2C
	public static extern float CSharp_AkBehavioralPositioningData_panLR_get(IntPtr jarg1); // 0x000000018428EBB4-0x000000018428EBE8
	public static extern void CSharp_AkBehavioralPositioningData_panBF_set(IntPtr jarg1, float jarg2); // 0x000000018428EB00-0x000000018428EB3C
	public static extern float CSharp_AkBehavioralPositioningData_panBF_get(IntPtr jarg1); // 0x000000018428EAD4-0x000000018428EB00
	public static extern void CSharp_AkBehavioralPositioningData_panDU_set(IntPtr jarg1, float jarg2); // 0x000000018428EB70-0x000000018428EBB4
	public static extern float CSharp_AkBehavioralPositioningData_panDU_get(IntPtr jarg1); // 0x000000018428EB3C-0x000000018428EB70
	public static extern void CSharp_AkBehavioralPositioningData_panSpatMix_set(IntPtr jarg1, float jarg2); // 0x000000018428EC60-0x000000018428ECA4
	public static extern float CSharp_AkBehavioralPositioningData_panSpatMix_get(IntPtr jarg1); // 0x000000018428EC2C-0x000000018428EC60
	public static extern void CSharp_AkBehavioralPositioningData_spatMode_set(IntPtr jarg1, int jarg2); // 0x000000018428ED4C-0x000000018428ED8C
	public static extern int CSharp_AkBehavioralPositioningData_spatMode_get(IntPtr jarg1); // 0x000000018428ED18-0x000000018428ED4C
	public static extern void CSharp_AkBehavioralPositioningData_panType_set(IntPtr jarg1, int jarg2); // 0x000000018428ECD8-0x000000018428ED18
	public static extern int CSharp_AkBehavioralPositioningData_panType_get(IntPtr jarg1); // 0x000000018428ECA4-0x000000018428ECD8
	public static extern void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(IntPtr jarg1, bool jarg2); // 0x000000018428EA90-0x000000018428EAD4
	public static extern bool CSharp_AkBehavioralPositioningData_enableHeightSpread_get(IntPtr jarg1); // 0x000000018428EA58-0x000000018428EA90
	public static extern void CSharp_delete_AkBehavioralPositioningData(IntPtr jarg1); // 0x00000001842A3848-0x00000001842A387C
	public static extern void CSharp_AkPositioningData_threeD_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001842961CC-0x0000000184296210
	public static extern IntPtr CSharp_AkPositioningData_threeD_get(IntPtr jarg1); // 0x0000000184296198-0x00000001842961CC
	public static extern void CSharp_AkPositioningData_behavioral_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184296114-0x0000000184296198
	public static extern IntPtr CSharp_AkPositioningData_behavioral_get(IntPtr jarg1); // 0x00000001842960E0-0x0000000184296114
	public static extern IntPtr CSharp_new_AkPositioningData(); // 0x00000001842A5470-0x00000001842A549C
	public static extern void CSharp_delete_AkPositioningData(IntPtr jarg1); // 0x00000001842A4104-0x00000001842A4138
	public static extern void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018428DBA8-0x000000018428DBEC
	public static extern IntPtr CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(IntPtr jarg1); // 0x000000018428DB6C-0x000000018428DBA8
	public static extern void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x000000018428DC94-0x000000018428DCD4
	public static extern uint CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(IntPtr jarg1); // 0x000000018428DC60-0x000000018428DC94
	public static extern void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x000000018428DC20-0x000000018428DC60
	public static extern uint CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(IntPtr jarg1); // 0x000000018428DBEC-0x000000018428DC20
	public static extern void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(IntPtr jarg1, bool jarg2); // 0x000000018428DB28-0x000000018428DB6C
	public static extern bool CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(IntPtr jarg1); // 0x000000018428DAF0-0x000000018428DB28
	public static extern void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(IntPtr jarg1, bool jarg2); // 0x000000018428DAAC-0x000000018428DAF0
	public static extern bool CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(IntPtr jarg1); // 0x000000018428DA74-0x000000018428DAAC
	public static extern IntPtr CSharp_new_Ak3DAudioSinkCapabilities(); // 0x00000001842A4648-0x00000001842A4674
	public static extern void CSharp_delete_Ak3DAudioSinkCapabilities(IntPtr jarg1); // 0x00000001842A35EC-0x00000001842A3620
	public static extern void CSharp_AkIterator_pItem_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291D9C-0x0000000184291DE0
	public static extern IntPtr CSharp_AkIterator_pItem_get(IntPtr jarg1); // 0x0000000184291D68-0x0000000184291D9C
	public static extern IntPtr CSharp_AkIterator_NextIter(IntPtr jarg1); // 0x0000000184291D00-0x0000000184291D34
	public static extern IntPtr CSharp_AkIterator_PrevIter(IntPtr jarg1); // 0x0000000184291D34-0x0000000184291D68
	public static extern IntPtr CSharp_AkIterator_GetItem(IntPtr jarg1); // 0x0000000184291BFC-0x0000000184291C30
	public static extern bool CSharp_AkIterator_IsEqualTo(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291C78-0x0000000184291D00
	public static extern bool CSharp_AkIterator_IsDifferentFrom(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291C30-0x0000000184291C78
	public static extern IntPtr CSharp_new_AkIterator(); // 0x00000001842A4DA0-0x00000001842A4DCC
	public static extern void CSharp_delete_AkIterator(IntPtr jarg1); // 0x00000001842A3BBC-0x00000001842A3BF0
	public static extern bool CSharp_AkStdMovePolicy_IsTrivial(); // 0x0000000184297DD0-0x0000000184297E00
	public static extern IntPtr CSharp_new_AkStdMovePolicy(); // 0x00000001842A5658-0x00000001842A5684
	public static extern void CSharp_delete_AkStdMovePolicy(IntPtr jarg1); // 0x00000001842A42D8-0x00000001842A430C
	public static extern bool CSharp_AkTrivialStdMovePolicy_IsTrivial(); // 0x0000000184298574-0x00000001842985A4
	public static extern IntPtr CSharp_new_AkTrivialStdMovePolicy(); // 0x00000001842A5780-0x00000001842A57AC
	public static extern void CSharp_delete_AkTrivialStdMovePolicy(IntPtr jarg1); // 0x00000001842A43DC-0x00000001842A4410
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_0(); // 0x00000001842A53E4-0x00000001842A5410
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_1(IntPtr jarg1); // 0x00000001842A5410-0x00000001842A5444
	public static extern void CSharp_delete_AkPlaylistItem(IntPtr jarg1); // 0x00000001842A409C-0x00000001842A40D0
	public static extern IntPtr CSharp_AkPlaylistItem_Assign(IntPtr jarg1, IntPtr jarg2); // 0x0000000184295B40-0x0000000184295B84
	public static extern bool CSharp_AkPlaylistItem_IsEqualTo(IntPtr jarg1, IntPtr jarg2); // 0x0000000184295B84-0x0000000184295C0C
	public static extern int CSharp_AkPlaylistItem_SetExternalSources(IntPtr jarg1, uint jarg2, IntPtr jarg3); // 0x0000000184295C0C-0x0000000184295C9C
	public static extern void CSharp_AkPlaylistItem_audioNodeID_set(IntPtr jarg1, uint jarg2); // 0x0000000184295CD0-0x0000000184295D10
	public static extern uint CSharp_AkPlaylistItem_audioNodeID_get(IntPtr jarg1); // 0x0000000184295C9C-0x0000000184295CD0
	public static extern void CSharp_AkPlaylistItem_msDelay_set(IntPtr jarg1, int jarg2); // 0x0000000184295D44-0x0000000184295D84
	public static extern int CSharp_AkPlaylistItem_msDelay_get(IntPtr jarg1); // 0x0000000184295D10-0x0000000184295D44
	public static extern void CSharp_AkPlaylistItem_pCustomInfo_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184295DB8-0x0000000184295DFC
	public static extern IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(IntPtr jarg1); // 0x0000000184295D84-0x0000000184295DB8
	public static extern IntPtr CSharp_new_AkPlaylistArray(); // 0x00000001842A53B8-0x00000001842A53E4
	public static extern void CSharp_delete_AkPlaylistArray(IntPtr jarg1); // 0x00000001842A4068-0x00000001842A409C
	public static extern IntPtr CSharp_AkPlaylistArray_Begin(IntPtr jarg1); // 0x0000000184295210-0x000000018429524C
	public static extern IntPtr CSharp_AkPlaylistArray_End(IntPtr jarg1); // 0x0000000184295304-0x0000000184295338
	public static extern IntPtr CSharp_AkPlaylistArray_FindEx(IntPtr jarg1, IntPtr jarg2); // 0x00000001842954C4-0x0000000184295548
	public static extern IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x00000001842953FC-0x0000000184295440
	public static extern void CSharp_AkPlaylistArray_Erase__SWIG_1(IntPtr jarg1, uint jarg2); // 0x0000000184295440-0x0000000184295480
	public static extern IntPtr CSharp_AkPlaylistArray_EraseSwap__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x0000000184295338-0x00000001842953BC
	public static extern void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(IntPtr jarg1, uint jarg2); // 0x00000001842953BC-0x00000001842953FC
	public static extern bool CSharp_AkPlaylistArray_IsGrowingAllowed(IntPtr jarg1); // 0x0000000184295700-0x0000000184295778
	public static extern int CSharp_AkPlaylistArray_Reserve(IntPtr jarg1, uint jarg2); // 0x00000001842959D0-0x0000000184295A10
	public static extern int CSharp_AkPlaylistArray_ReserveExtra(IntPtr jarg1, uint jarg2); // 0x0000000184295990-0x00000001842959D0
	public static extern uint CSharp_AkPlaylistArray_Reserved(IntPtr jarg1); // 0x0000000184295A10-0x0000000184295A44
	public static extern void CSharp_AkPlaylistArray_Term(IntPtr jarg1); // 0x0000000184295AC8-0x0000000184295AFC
	public static extern uint CSharp_AkPlaylistArray_Length(IntPtr jarg1); // 0x000000018429582C-0x0000000184295860
	public static extern IntPtr CSharp_AkPlaylistArray_Data(IntPtr jarg1); // 0x00000001842952D0-0x0000000184295304
	public static extern bool CSharp_AkPlaylistArray_IsEmpty(IntPtr jarg1); // 0x00000001842956C8-0x0000000184295700
	public static extern IntPtr CSharp_AkPlaylistArray_Exists(IntPtr jarg1, IntPtr jarg2); // 0x0000000184295480-0x00000001842954C4
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(IntPtr jarg1); // 0x0000000184295114-0x000000018429518C
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(IntPtr jarg1, IntPtr jarg2); // 0x000000018429518C-0x0000000184295210
	public static extern IntPtr CSharp_AkPlaylistArray_Last(IntPtr jarg1); // 0x00000001842957F8-0x000000018429582C
	public static extern void CSharp_AkPlaylistArray_RemoveLast(IntPtr jarg1); // 0x0000000184295894-0x00000001842958C8
	public static extern int CSharp_AkPlaylistArray_Remove(IntPtr jarg1, IntPtr jarg2); // 0x000000018429590C-0x0000000184295990
	public static extern int CSharp_AkPlaylistArray_RemoveSwap(IntPtr jarg1, IntPtr jarg2); // 0x00000001842958C8-0x000000018429590C
	public static extern void CSharp_AkPlaylistArray_RemoveAll(IntPtr jarg1); // 0x0000000184295860-0x0000000184295894
	public static extern IntPtr CSharp_AkPlaylistArray_ItemAtIndex(IntPtr jarg1, uint jarg2); // 0x0000000184295778-0x00000001842957F8
	public static extern IntPtr CSharp_AkPlaylistArray_Insert__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x0000000184295604-0x0000000184295648
	public static extern IntPtr CSharp_AkPlaylistArray_Insert__SWIG_1(IntPtr jarg1, uint jarg2); // 0x0000000184295648-0x00000001842956C8
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_0(IntPtr jarg1); // 0x0000000184295548-0x0000000184295580
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_1(IntPtr jarg1, uint jarg2); // 0x0000000184295580-0x0000000184295604
	public static extern bool CSharp_AkPlaylistArray_Resize(IntPtr jarg1, uint jarg2); // 0x0000000184295A44-0x0000000184295AC8
	public static extern void CSharp_AkPlaylistArray_Transfer(IntPtr jarg1, IntPtr jarg2); // 0x0000000184295AFC-0x0000000184295B40
	public static extern int CSharp_AkPlaylistArray_Copy(IntPtr jarg1, IntPtr jarg2); // 0x000000018429524C-0x00000001842952D0
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_0(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6); // 0x0000000184295DFC-0x0000000184295E9C
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_1(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5); // 0x0000000184295E9C-0x0000000184295F3C
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_2(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4); // 0x0000000184295F3C-0x0000000184295FDC
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_3(IntPtr jarg1, uint jarg2, int jarg3); // 0x0000000184295FDC-0x000000018429606C
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_4(IntPtr jarg1, uint jarg2); // 0x000000018429606C-0x00000001842960AC
	public static extern IntPtr CSharp_new_AkPlaylist(); // 0x00000001842A5444-0x00000001842A5470
	public static extern void CSharp_delete_AkPlaylist(IntPtr jarg1); // 0x00000001842A40D0-0x00000001842A4104
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_0(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x0000000184299308-0x00000001842993A8
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_1(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001842993A8-0x0000000184299448
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_2(ulong jarg1); // 0x0000000184299448-0x00000001842994C0
	public static extern int CSharp_DynamicSequenceClose(uint jarg1); // 0x00000001842991CC-0x0000000184299200
	public static extern int CSharp_DynamicSequencePlay__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x0000000184299600-0x000000018429968C
	public static extern int CSharp_DynamicSequencePlay__SWIG_1(uint jarg1, int jarg2); // 0x000000018429968C-0x000000018429970C
	public static extern int CSharp_DynamicSequencePlay__SWIG_2(uint jarg1); // 0x000000018429970C-0x0000000184299740
	public static extern int CSharp_DynamicSequencePause__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001842994C0-0x000000018429954C
	public static extern int CSharp_DynamicSequencePause__SWIG_1(uint jarg1, int jarg2); // 0x000000018429954C-0x00000001842995CC
	public static extern int CSharp_DynamicSequencePause__SWIG_2(uint jarg1); // 0x00000001842995CC-0x0000000184299600
	public static extern int CSharp_DynamicSequenceResume__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x0000000184299740-0x00000001842997CC
	public static extern int CSharp_DynamicSequenceResume__SWIG_1(uint jarg1, int jarg2); // 0x00000001842997CC-0x000000018429980C
	public static extern int CSharp_DynamicSequenceResume__SWIG_2(uint jarg1); // 0x000000018429980C-0x0000000184299840
	public static extern int CSharp_DynamicSequenceStop__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x0000000184299840-0x0000000184299890
	public static extern int CSharp_DynamicSequenceStop__SWIG_1(uint jarg1, int jarg2); // 0x0000000184299890-0x00000001842998D0
	public static extern int CSharp_DynamicSequenceStop__SWIG_2(uint jarg1); // 0x00000001842998D0-0x0000000184299948
	public static extern int CSharp_DynamicSequenceBreak(uint jarg1); // 0x0000000184299154-0x00000001842991CC
	public static extern int CSharp_Seek__SWIG_0(uint jarg1, int jarg2, bool jarg3); // 0x00000001842A051C-0x00000001842A056C
	public static extern int CSharp_Seek__SWIG_1(uint jarg1, float jarg2, bool jarg3); // 0x00000001842A056C-0x00000001842A05B8
	public static extern int CSharp_DynamicSequenceGetPauseTimes(uint jarg1, out uint jarg2, out uint jarg3); // 0x0000000184299200-0x0000000184299290
	public static extern IntPtr CSharp_DynamicSequenceLockPlaylist(uint jarg1); // 0x0000000184299290-0x0000000184299308
	public static extern int CSharp_DynamicSequenceUnlockPlaylist(uint jarg1); // 0x0000000184299948-0x000000018429997C
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_0(); // 0x00000001842A50EC-0x00000001842A5118
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_1(string jarg1, uint jarg2, IntPtr jarg3, int jarg4); // 0x00000001842A5118-0x00000001842A51D4
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_2(string jarg1, uint jarg2, IntPtr jarg3); // 0x00000001842A51D4-0x00000001842A5280
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_3(string jarg1, uint jarg2); // 0x00000001842A5280-0x00000001842A5320
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_4(string jarg1); // 0x00000001842A5320-0x00000001842A53B8
	public static extern void CSharp_AkOutputSettings_audioDeviceShareset_set(IntPtr jarg1, uint jarg2); // 0x0000000182A4F610-0x0000000182A4F650
	public static extern uint CSharp_AkOutputSettings_audioDeviceShareset_get(IntPtr jarg1); // 0x0000000184294B78-0x0000000184294BF0
	public static extern void CSharp_AkOutputSettings_idDevice_set(IntPtr jarg1, uint jarg2); // 0x0000000182A4F570-0x0000000182A4F5B0
	public static extern uint CSharp_AkOutputSettings_idDevice_get(IntPtr jarg1); // 0x0000000184294C68-0x0000000184294C9C
	public static extern void CSharp_AkOutputSettings_ePanningRule_set(IntPtr jarg1, int jarg2); // 0x0000000182A4F4D0-0x0000000182A4F510
	public static extern int CSharp_AkOutputSettings_ePanningRule_get(IntPtr jarg1); // 0x0000000184294C34-0x0000000184294C68
	public static extern void CSharp_AkOutputSettings_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184294BF0-0x0000000184294C34
	public static extern IntPtr CSharp_AkOutputSettings_channelConfig_get(IntPtr jarg1); // 0x0000000182A4F350-0x0000000182A4F390
	public static extern void CSharp_delete_AkOutputSettings(IntPtr jarg1); // 0x00000001842A4000-0x00000001842A4034
	public static extern void CSharp_AkInitSettings_uMaxNumPaths_set(IntPtr jarg1, uint jarg2); // 0x0000000182A4EB60-0x0000000182A4EBA0
	public static extern uint CSharp_AkInitSettings_uMaxNumPaths_get(IntPtr jarg1); // 0x00000001842918EC-0x0000000184291920
	public static extern void CSharp_AkInitSettings_uCommandQueueSize_set(IntPtr jarg1, uint jarg2); // 0x0000000182A4EAC0-0x0000000182A4EB00
	public static extern uint CSharp_AkInitSettings_uCommandQueueSize_get(IntPtr jarg1); // 0x00000001842917DC-0x0000000184291810
	public static extern void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(IntPtr jarg1, bool jarg2); // 0x0000000182A01AE0-0x0000000182A01B30
	public static extern bool CSharp_AkInitSettings_bEnableGameSyncPreparation_get(IntPtr jarg1); // 0x0000000184291494-0x000000018429150C
	public static extern void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(IntPtr jarg1, uint jarg2); // 0x0000000182A01A40-0x0000000182A01A80
	public static extern uint CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(IntPtr jarg1); // 0x0000000184291810-0x0000000184291844
	public static extern void CSharp_AkInitSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2); // 0x0000000182A4EA20-0x0000000182A4EA60
	public static extern uint CSharp_AkInitSettings_uNumSamplesPerFrame_get(IntPtr jarg1); // 0x0000000184291954-0x0000000184291988
	public static extern void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(IntPtr jarg1, uint jarg2); // 0x0000000182A019A0-0x0000000182A019E0
	public static extern uint CSharp_AkInitSettings_uMonitorQueuePoolSize_get(IntPtr jarg1); // 0x0000000184291920-0x0000000184291954
	public static extern void CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_set(IntPtr jarg1, uint jarg2); // 0x0000000184291878-0x00000001842918B8
	public static extern uint CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_get(IntPtr jarg1); // 0x0000000184291844-0x0000000184291878
	public static extern void CSharp_AkInitSettings_settingsMainOutput_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291724-0x0000000184291768
	public static extern IntPtr CSharp_AkInitSettings_settingsMainOutput_get(IntPtr jarg1); // 0x0000000182A4E920-0x0000000182A4E960
	public static extern void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(IntPtr jarg1, uint jarg2); // 0x0000000182A01900-0x0000000182A01940
	public static extern uint CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(IntPtr jarg1); // 0x00000001842918B8-0x00000001842918EC
	public static extern void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(IntPtr jarg1, bool jarg2); // 0x00000001842915C0-0x0000000184291604
	public static extern bool CSharp_AkInitSettings_bUseSoundBankMgrThread_get(IntPtr jarg1); // 0x0000000184291588-0x00000001842915C0
	public static extern void CSharp_AkInitSettings_bUseLEngineThread_set(IntPtr jarg1, bool jarg2); // 0x0000000184291544-0x0000000184291588
	public static extern bool CSharp_AkInitSettings_bUseLEngineThread_get(IntPtr jarg1); // 0x000000018429150C-0x0000000184291544
	public static extern void CSharp_AkInitSettings_szPluginDLLPath_set(IntPtr jarg1, string jarg2); // 0x0000000182A4F650-0x0000000182A4F6F0
	public static extern IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(IntPtr jarg1); // 0x0000000182A4E7B0-0x0000000182A4E7F0
	public static extern void CSharp_AkInitSettings_eFloorPlane_set(IntPtr jarg1, int jarg2); // 0x0000000184291638-0x0000000184291678
	public static extern int CSharp_AkInitSettings_eFloorPlane_get(IntPtr jarg1); // 0x0000000184291604-0x0000000184291638
	public static extern void CSharp_AkInitSettings_fGameUnitsToMeters_set(IntPtr jarg1, float jarg2); // 0x00000001842916E0-0x0000000184291724
	public static extern float CSharp_AkInitSettings_fGameUnitsToMeters_get(IntPtr jarg1); // 0x00000001842916AC-0x00000001842916E0
	public static extern void CSharp_AkInitSettings_uBankReadBufferSize_set(IntPtr jarg1, uint jarg2); // 0x000000018429179C-0x00000001842917DC
	public static extern uint CSharp_AkInitSettings_uBankReadBufferSize_get(IntPtr jarg1); // 0x0000000184291768-0x000000018429179C
	public static extern void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(IntPtr jarg1, float jarg2); // 0x0000000182A01850-0x0000000182A018A0
	public static extern float CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(IntPtr jarg1); // 0x0000000184291678-0x00000001842916AC
	public static extern void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(IntPtr jarg1, bool jarg2); // 0x0000000182A017A0-0x0000000182A017F0
	public static extern bool CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(IntPtr jarg1); // 0x000000018429145C-0x0000000184291494
	public static extern void CSharp_delete_AkInitSettings(IntPtr jarg1); // 0x00000001842A3B88-0x00000001842A3BBC
	public static extern void CSharp_AkSourceSettings_sourceID_set(IntPtr jarg1, uint jarg2); // 0x0000000184297B74-0x0000000184297BB4
	public static extern uint CSharp_AkSourceSettings_sourceID_get(IntPtr jarg1); // 0x0000000184297B40-0x0000000184297B74
	public static extern void CSharp_AkSourceSettings_pMediaMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184297AFC-0x0000000184297B40
	public static extern IntPtr CSharp_AkSourceSettings_pMediaMemory_get(IntPtr jarg1); // 0x0000000184297AC8-0x0000000184297AFC
	public static extern void CSharp_AkSourceSettings_uMediaSize_set(IntPtr jarg1, uint jarg2); // 0x0000000184297BE8-0x0000000184297C28
	public static extern uint CSharp_AkSourceSettings_uMediaSize_get(IntPtr jarg1); // 0x0000000184297BB4-0x0000000184297BE8
	public static extern void CSharp_AkSourceSettings_Clear(IntPtr jarg1); // 0x0000000184297A1C-0x0000000184297A50
	public static extern int CSharp_AkSourceSettings_GetSizeOf(); // 0x0000000184297A94-0x0000000184297AC8
	public static extern void CSharp_AkSourceSettings_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000184297A50-0x0000000184297A94
	public static extern IntPtr CSharp_new_AkSourceSettings(); // 0x00000001842A562C-0x00000001842A5658
	public static extern void CSharp_delete_AkSourceSettings(IntPtr jarg1); // 0x00000001842A42A4-0x00000001842A42D8
	public static extern bool CSharp_IsInitialized(); // 0x0000000182690440-0x00000001826904B0
	public static extern int CSharp_GetAudioSettings(IntPtr jarg1); // 0x000000018429A094-0x000000018429A0C8
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(ulong jarg1); // 0x000000018429BA44-0x000000018429BABC
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_1(); // 0x0000000182690210-0x0000000182690240
	public static extern int CSharp_GetOutputDeviceConfiguration(ulong jarg1, IntPtr jarg2, IntPtr jarg3); // 0x000000018429AC04-0x000000018429AC94
	public static extern int CSharp_GetPanningRule__SWIG_0(out int jarg1, ulong jarg2); // 0x000000018429ADB4-0x000000018429AE38
	public static extern int CSharp_GetPanningRule__SWIG_1(out int jarg1); // 0x000000018429AE38-0x000000018429AEB0
	public static extern int CSharp_SetPanningRule__SWIG_0(int jarg1, ulong jarg2); // 0x00000001842A1B90-0x00000001842A1C10
	public static extern int CSharp_SetPanningRule__SWIG_1(int jarg1); // 0x00000001842A1C10-0x00000001842A1C88
	public static extern int CSharp_GetSpeakerAngles__SWIG_0([In, Out] float[] jarg1, ref uint jarg2, out float jarg3, ulong jarg4); // 0x000000018429B900-0x000000018429B9A8
	public static extern int CSharp_GetSpeakerAngles__SWIG_1([In, Out] float[] jarg1, ref uint jarg2, out float jarg3); // 0x000000018429B9A8-0x000000018429BA44
	public static extern int CSharp_SetSpeakerAngles__SWIG_0(in float[] jarg1, uint jarg2, float jarg3, ulong jarg4); // 0x00000001842A2450-0x00000001842A24B4
	public static extern int CSharp_SetSpeakerAngles__SWIG_1(in float[] jarg1, uint jarg2, float jarg3); // 0x00000001842A24B4-0x00000001842A2508
	public static extern int CSharp_SetVolumeThreshold(float jarg1); // 0x00000001842A26D0-0x00000001842A2704
	public static extern int CSharp_SetMaxNumVoicesLimit(ushort jarg1); // 0x00000001842A1404-0x00000001842A147C
	public static extern int CSharp_SetJobMgrMaxActiveWorkers(uint jarg1, uint jarg2); // 0x00000001842A117C-0x00000001842A11FC
	public static extern int CSharp_RenderAudio__SWIG_0(bool jarg1); // 0x000000018429F15C-0x000000018429F1D4
	public static extern int CSharp_RenderAudio__SWIG_1(); // 0x000000018269BD20-0x000000018269BD50
	public static extern int CSharp_RegisterPluginDLL__SWIG_0(string jarg1, string jarg2); // 0x000000018429ED6C-0x000000018429EE04
	public static extern int CSharp_RegisterPluginDLL__SWIG_1(string jarg1); // 0x000000018429EE04-0x000000018429EE44
	public static extern bool CSharp_IsPluginRegistered(int jarg1, uint jarg2, uint jarg3); // 0x000000018429C0F4-0x000000018429C188
	public static extern uint CSharp_GetIDFromString__SWIG_0(string jarg1); // 0x0000000183594130-0x0000000183594170
	public static extern uint CSharp_PostEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8); // 0x000000018429D46C-0x000000018429D50C
	public static extern uint CSharp_PostEvent__SWIG_1(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7); // 0x00000001829506D0-0x0000000182950730
	public static extern uint CSharp_PostEvent__SWIG_2(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x000000018269E470-0x000000018269E4D0
	public static extern uint CSharp_PostEvent__SWIG_3(uint jarg1, ulong jarg2); // 0x000000018429D50C-0x000000018429D58C
	public static extern uint CSharp_PostEvent__SWIG_4(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8); // 0x000000018429D58C-0x000000018429D63C
	public static extern uint CSharp_PostEvent__SWIG_5(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7); // 0x000000018429D63C-0x000000018429D6E8
	public static extern uint CSharp_PostEvent__SWIG_6(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x000000018429D6E8-0x000000018429D794
	public static extern uint CSharp_PostEvent__SWIG_7(string jarg1, ulong jarg2); // 0x000000018429D794-0x000000018429D820
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_0(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6); // 0x000000018429997C-0x0000000184299A18
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_1(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5); // 0x0000000184299A18-0x0000000184299AB4
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_2(uint jarg1, int jarg2, ulong jarg3, int jarg4); // 0x0000000184299AB4-0x0000000184299B50
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_3(uint jarg1, int jarg2, ulong jarg3); // 0x0000000184299B50-0x0000000184299BDC
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_4(uint jarg1, int jarg2); // 0x0000000184299BDC-0x0000000184299C5C
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_5(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6); // 0x0000000184299C5C-0x0000000184299D04
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_6(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5); // 0x0000000184299D04-0x0000000184299DAC
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_7(string jarg1, int jarg2, ulong jarg3, int jarg4); // 0x0000000184299DAC-0x0000000184299E54
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_8(string jarg1, int jarg2, ulong jarg3); // 0x0000000184299E54-0x0000000184299EEC
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_9(string jarg1, int jarg2); // 0x0000000184299EEC-0x0000000184299F78
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8, uint jarg9); // 0x000000018429D820-0x000000018429D8D8
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8); // 0x000000018429D8D8-0x000000018429D988
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_2(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5); // 0x000000018429D988-0x000000018429DA38
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_3(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4); // 0x000000018429DA38-0x000000018429DAD8
	public static extern int CSharp_StopMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3); // 0x00000001842A297C-0x00000001842A2A0C
	public static extern int CSharp_StopMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2); // 0x00000001842A2A0C-0x00000001842A2A4C
	public static extern int CSharp_StopMIDIOnEvent__SWIG_2(uint jarg1); // 0x00000001842A2A4C-0x00000001842A2A80
	public static extern int CSharp_StopMIDIOnEvent__SWIG_3(); // 0x00000001842A2A80-0x00000001842A2AE8
	public static extern int CSharp_PinEventInStreamCache__SWIG_0(uint jarg1, sbyte jarg2, sbyte jarg3); // 0x000000018429CFC4-0x000000018429D054
	public static extern int CSharp_PinEventInStreamCache__SWIG_1(string jarg1, sbyte jarg2, sbyte jarg3); // 0x000000018429D054-0x000000018429D0F0
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_0(uint jarg1); // 0x00000001842A330C-0x00000001842A3384
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_1(string jarg1); // 0x00000001842A3384-0x00000001842A3400
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_0(uint jarg1, out float jarg2, out int jarg3); // 0x000000018429A134-0x000000018429A1C4
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_1(string jarg1, out float jarg2, out int jarg3); // 0x000000018429A1C4-0x000000018429A26C
	public static extern int CSharp_SeekOnEvent__SWIG_0(uint jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5); // 0x000000018429FF2C-0x000000018429FFCC
	public static extern int CSharp_SeekOnEvent__SWIG_1(uint jarg1, ulong jarg2, int jarg3, bool jarg4); // 0x00000001842A019C-0x00000001842A023C
	public static extern int CSharp_SeekOnEvent__SWIG_2(uint jarg1, ulong jarg2, int jarg3); // 0x00000001842A023C-0x00000001842A02CC
	public static extern int CSharp_SeekOnEvent__SWIG_3(string jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5); // 0x00000001842A02CC-0x00000001842A0378
	public static extern int CSharp_SeekOnEvent__SWIG_4(string jarg1, ulong jarg2, int jarg3, bool jarg4); // 0x00000001842A0378-0x00000001842A0424
	public static extern int CSharp_SeekOnEvent__SWIG_5(string jarg1, ulong jarg2, int jarg3); // 0x00000001842A0424-0x00000001842A04C0
	public static extern int CSharp_SeekOnEvent__SWIG_9(uint jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5); // 0x00000001842A04C0-0x00000001842A051C
	public static extern int CSharp_SeekOnEvent__SWIG_10(uint jarg1, ulong jarg2, float jarg3, bool jarg4); // 0x000000018429FFCC-0x00000001842A0028
	public static extern int CSharp_SeekOnEvent__SWIG_11(uint jarg1, ulong jarg2, float jarg3); // 0x00000001842A0028-0x00000001842A0074
	public static extern int CSharp_SeekOnEvent__SWIG_12(string jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5); // 0x00000001842A0074-0x00000001842A00DC
	public static extern int CSharp_SeekOnEvent__SWIG_13(string jarg1, ulong jarg2, float jarg3, bool jarg4); // 0x00000001842A00DC-0x00000001842A0144
	public static extern int CSharp_SeekOnEvent__SWIG_14(string jarg1, ulong jarg2, float jarg3); // 0x00000001842A0144-0x00000001842A019C
	public static extern void CSharp_CancelEventCallbackCookie(IntPtr jarg1); // 0x0000000184298B6C-0x0000000184298BA0
	public static extern void CSharp_CancelEventCallbackGameObject(ulong jarg1); // 0x0000000184298BA0-0x0000000184298BD4
	public static extern void CSharp_CancelEventCallback(uint jarg1); // 0x0000000184298BD4-0x0000000184298C08
	public static extern int CSharp_GetSourcePlayPosition__SWIG_0(uint jarg1, out int jarg2, bool jarg3); // 0x000000018429B760-0x000000018429B7F0
	public static extern int CSharp_GetSourcePlayPosition__SWIG_1(uint jarg1, out int jarg2); // 0x000000018429B7F0-0x000000018429B870
	public static extern int CSharp_GetSourceStreamBuffering(uint jarg1, out int jarg2, out int jarg3); // 0x000000018429B870-0x000000018429B900
	public static extern void CSharp_StopAll__SWIG_0(ulong jarg1); // 0x0000000182AF8690-0x0000000182AF8730
	public static extern void CSharp_StopAll__SWIG_1(); // 0x00000001842A291C-0x00000001842A2948
	public static extern void CSharp_StopPlayingID__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001842A2B14-0x00000001842A2BA0
	public static extern void CSharp_StopPlayingID__SWIG_1(uint jarg1, int jarg2); // 0x00000001842A2BA0-0x00000001842A2C20
	public static extern void CSharp_StopPlayingID__SWIG_2(uint jarg1); // 0x00000001842A2C20-0x00000001842A2C98
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_0(int jarg1, uint jarg2, int jarg3, int jarg4); // 0x0000000184299F78-0x000000018429A014
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_1(int jarg1, uint jarg2, int jarg3); // 0x0000000182A9E7B0-0x0000000182A9E800
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_2(int jarg1, uint jarg2); // 0x000000018429A014-0x000000018429A094
	public static extern void CSharp_SetRandomSeed(uint jarg1); // 0x00000001842A22EC-0x00000001842A2364
	public static extern void CSharp_MuteBackgroundMusic(bool jarg1); // 0x000000018429CF20-0x000000018429CF98
	public static extern bool CSharp_GetBackgroundMusicMute(); // 0x000000018429A0C8-0x000000018429A134
	public static extern int CSharp_SendPluginCustomGameData(uint jarg1, ulong jarg2, int jarg3, uint jarg4, uint jarg5, IntPtr jarg6, uint jarg7); // 0x00000001842A05B8-0x00000001842A0658
	public static extern int CSharp_UnregisterAllGameObj(); // 0x00000001842A3400-0x00000001842A342C
	public static extern int CSharp_SetMultiplePositions__SWIG_0(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4, int jarg5); // 0x00000001842A16A8-0x00000001842A174C
	public static extern int CSharp_SetMultiplePositions__SWIG_1(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4); // 0x0000000183287A90-0x0000000183287AF0
	public static extern int CSharp_SetMultiplePositions__SWIG_2(ulong jarg1, IntPtr jarg2, ushort jarg3); // 0x00000001842A174C-0x00000001842A17E0
	public static extern int CSharp_SetMultiplePositions__SWIG_3(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4, int jarg5); // 0x00000001842A17E0-0x00000001842A1884
	public static extern int CSharp_SetMultiplePositions__SWIG_4(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4); // 0x00000001842A1884-0x00000001842A1928
	public static extern int CSharp_SetMultiplePositions__SWIG_5(ulong jarg1, IntPtr jarg2, ushort jarg3); // 0x00000001842A1928-0x00000001842A19BC
	public static extern int CSharp_SetScalingFactor(ulong jarg1, float jarg2); // 0x0000000182EA2400-0x0000000182EA24A0
	public static extern int CSharp_SetDistanceProbe(ulong jarg1, ulong jarg2); // 0x00000001842A0B64-0x00000001842A0BE8
	public static extern int CSharp_ClearBanks(); // 0x0000000184298D34-0x0000000184298D60
	public static extern int CSharp_SetBankLoadIOSettings(float jarg1, sbyte jarg2); // 0x00000001842A077C-0x00000001842A07B8
	public static extern int CSharp_LoadBank__SWIG_0(string jarg1, out uint jarg2, uint jarg3); // 0x000000018429C6E0-0x000000018429C77C
	public static extern int CSharp_LoadBank__SWIG_1(string jarg1, out uint jarg2); // 0x000000018429C77C-0x000000018429C808
	public static extern int CSharp_LoadBank__SWIG_4(uint jarg1, uint jarg2); // 0x000000018429C808-0x000000018429C888
	public static extern int CSharp_LoadBank__SWIG_5(uint jarg1); // 0x0000000182951F60-0x0000000182952050
	public static extern int CSharp_LoadBankMemoryView__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3); // 0x000000018429C470-0x000000018429C500
	public static extern int CSharp_LoadBankMemoryView__SWIG_1(IntPtr jarg1, uint jarg2, out uint jarg3, out uint jarg4); // 0x000000018429C500-0x000000018429C5A0
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3); // 0x000000018429C200-0x000000018429C290
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_1(IntPtr jarg1, uint jarg2, out uint jarg3, out uint jarg4); // 0x000000018429C290-0x000000018429C330
	public static extern int CSharp_LoadBank__SWIG_6(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4, uint jarg5); // 0x000000018429C888-0x000000018429C934
	public static extern int CSharp_LoadBank__SWIG_7(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4); // 0x000000018429C934-0x000000018429C9E0
	public static extern int CSharp_LoadBank__SWIG_10(uint jarg1, IntPtr jarg2, IntPtr jarg3, uint jarg4); // 0x000000018269FFB0-0x00000001826A0010
	public static extern int CSharp_LoadBank__SWIG_11(uint jarg1, IntPtr jarg2, IntPtr jarg3); // 0x0000000183594210-0x0000000183594260
	public static extern int CSharp_LoadBankMemoryView__SWIG_2(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5); // 0x000000018429C5A0-0x000000018429C640
	public static extern int CSharp_LoadBankMemoryView__SWIG_3(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5, out uint jarg6); // 0x000000018429C640-0x000000018429C6E0
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_2(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5); // 0x000000018429C330-0x000000018429C3D0
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_3(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5, out uint jarg6); // 0x000000018429C3D0-0x000000018429C470
	public static extern int CSharp_UnloadBank__SWIG_0(string jarg1, IntPtr jarg2, uint jarg3); // 0x00000001842A2EDC-0x00000001842A2F78
	public static extern int CSharp_UnloadBank__SWIG_1(string jarg1, IntPtr jarg2); // 0x00000001842A3018-0x00000001842A30A4
	public static extern int CSharp_UnloadBank__SWIG_4(uint jarg1, IntPtr jarg2, uint jarg3); // 0x00000001842A30A4-0x00000001842A3134
	public static extern int CSharp_UnloadBank__SWIG_5(uint jarg1, IntPtr jarg2); // 0x00000001842A3134-0x00000001842A31B4
	public static extern int CSharp_UnloadBank__SWIG_6(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5); // 0x00000001842A31B4-0x00000001842A3260
	public static extern int CSharp_UnloadBank__SWIG_7(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001842A3260-0x00000001842A330C
	public static extern int CSharp_UnloadBank__SWIG_10(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5); // 0x00000001826A05C0-0x00000001826A0620
	public static extern int CSharp_UnloadBank__SWIG_11(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001842A2F78-0x00000001842A3018
	public static extern void CSharp_CancelBankCallbackCookie(IntPtr jarg1); // 0x0000000184298B38-0x0000000184298B6C
	public static extern int CSharp_PrepareBank__SWIG_0(int jarg1, string jarg2, int jarg3, uint jarg4); // 0x000000018429DED4-0x000000018429DF7C
	public static extern int CSharp_PrepareBank__SWIG_1(int jarg1, string jarg2, int jarg3); // 0x000000018429E2A0-0x000000018429E338
	public static extern int CSharp_PrepareBank__SWIG_2(int jarg1, string jarg2); // 0x000000018429E338-0x000000018429E3C4
	public static extern int CSharp_PrepareBank__SWIG_6(int jarg1, uint jarg2, int jarg3, uint jarg4); // 0x000000018429E3C4-0x000000018429E460
	public static extern int CSharp_PrepareBank__SWIG_7(int jarg1, uint jarg2, int jarg3); // 0x000000018429E460-0x000000018429E4EC
	public static extern int CSharp_PrepareBank__SWIG_8(int jarg1, uint jarg2); // 0x000000018429E4EC-0x000000018429E56C
	public static extern int CSharp_PrepareBank__SWIG_9(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, uint jarg6); // 0x000000018429E56C-0x000000018429E614
	public static extern int CSharp_PrepareBank__SWIG_10(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x000000018429DF7C-0x000000018429E024
	public static extern int CSharp_PrepareBank__SWIG_11(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4); // 0x000000018429E024-0x000000018429E0CC
	public static extern int CSharp_PrepareBank__SWIG_15(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, uint jarg6); // 0x000000018429E0CC-0x000000018429E168
	public static extern int CSharp_PrepareBank__SWIG_16(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x000000018429E168-0x000000018429E204
	public static extern int CSharp_PrepareBank__SWIG_17(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4); // 0x000000018429E204-0x000000018429E2A0
	public static extern int CSharp_ClearPreparedEvents(); // 0x0000000184298EB0-0x0000000184298F18
	public static extern int CSharp_PrepareEvent__SWIG_0(int jarg1, IntPtr jarg2, uint jarg3); // 0x000000018429E614-0x000000018429E6A4
	public static extern int CSharp_PrepareEvent__SWIG_1(int jarg1, in uint[] jarg2, uint jarg3); // 0x000000018429E6A4-0x000000018429E73C
	public static extern int CSharp_PrepareEvent__SWIG_2(int jarg1, IntPtr jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x000000018429E73C-0x000000018429E7DC
	public static extern int CSharp_PrepareEvent__SWIG_3(int jarg1, in uint[] jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x00000001826A0010-0x00000001826A0080
	public static extern int CSharp_SetMedia(IntPtr jarg1, uint jarg2); // 0x00000001842A147C-0x00000001842A14FC
	public static extern int CSharp_UnsetMedia(IntPtr jarg1, uint jarg2); // 0x00000001842A3494-0x00000001842A3514
	public static extern int CSharp_PrepareGameSyncs__SWIG_0(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5); // 0x000000018429E7DC-0x000000018429E884
	public static extern int CSharp_PrepareGameSyncs__SWIG_1(int jarg1, int jarg2, uint jarg3, in uint[] jarg4, uint jarg5); // 0x000000018429E884-0x000000018429E92C
	public static extern int CSharp_PrepareGameSyncs__SWIG_2(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7); // 0x000000018429E92C-0x000000018429E9D4
	public static extern int CSharp_PrepareGameSyncs__SWIG_3(int jarg1, int jarg2, uint jarg3, in uint[] jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7); // 0x000000018429E9D4-0x000000018429EA7C
	public static extern int CSharp_AddListener(ulong jarg1, ulong jarg2); // 0x000000018428D718-0x000000018428D79C
	public static extern int CSharp_RemoveListener(ulong jarg1, ulong jarg2); // 0x000000018429EFF8-0x000000018429F07C
	public static extern int CSharp_AddDefaultListener(ulong jarg1); // 0x000000018428D6A0-0x000000018428D718
	public static extern int CSharp_RemoveDefaultListener(ulong jarg1); // 0x000000018429EE44-0x000000018429EE78
	public static extern int CSharp_ResetListenersToDefault(ulong jarg1); // 0x000000018429F2E8-0x000000018429F360
	public static extern int CSharp_SetListenerSpatialization__SWIG_0(ulong jarg1, bool jarg2, IntPtr jarg3, in float[] jarg4); // 0x00000001842A11FC-0x00000001842A12A4
	public static extern int CSharp_SetListenerSpatialization__SWIG_1(ulong jarg1, bool jarg2, IntPtr jarg3); // 0x00000001842A12A4-0x00000001842A1334
	public static extern int CSharp_SetRTPCValue__SWIG_0(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001842A1FC4-0x00000001842A2028
	public static extern int CSharp_SetRTPCValue__SWIG_1(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5); // 0x00000001842A2028-0x00000001842A2084
	public static extern int CSharp_SetRTPCValue__SWIG_2(uint jarg1, float jarg2, ulong jarg3, int jarg4); // 0x0000000182830C00-0x0000000182830C60
	public static extern int CSharp_SetRTPCValue__SWIG_3(uint jarg1, float jarg2, ulong jarg3); // 0x00000001842A2084-0x00000001842A20D0
	public static extern int CSharp_SetRTPCValue__SWIG_4(uint jarg1, float jarg2); // 0x00000001842A20D0-0x00000001842A210C
	public static extern int CSharp_SetRTPCValue__SWIG_5(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001842A210C-0x00000001842A217C
	public static extern int CSharp_SetRTPCValue__SWIG_6(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5); // 0x00000001842A217C-0x00000001842A21E4
	public static extern int CSharp_SetRTPCValue__SWIG_7(string jarg1, float jarg2, ulong jarg3, int jarg4); // 0x00000001842A21E4-0x00000001842A224C
	public static extern int CSharp_SetRTPCValue__SWIG_8(string jarg1, float jarg2, ulong jarg3); // 0x00000001842A224C-0x00000001842A22A4
	public static extern int CSharp_SetRTPCValue__SWIG_9(string jarg1, float jarg2); // 0x00000001842A22A4-0x00000001842A22EC
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_0(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001842A1D20-0x00000001842A1D84
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_1(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5); // 0x00000001842A1D84-0x00000001842A1DE0
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_2(uint jarg1, float jarg2, uint jarg3, int jarg4); // 0x0000000182A361A0-0x0000000182A36200
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_3(uint jarg1, float jarg2, uint jarg3); // 0x00000001842A1DE0-0x00000001842A1E2C
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_4(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001842A1E2C-0x00000001842A1E9C
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_5(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5); // 0x00000001842A1E9C-0x00000001842A1F04
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_6(string jarg1, float jarg2, uint jarg3, int jarg4); // 0x00000001842A1F04-0x00000001842A1F6C
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_7(string jarg1, float jarg2, uint jarg3); // 0x00000001842A1F6C-0x00000001842A1FC4
	public static extern int CSharp_ResetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5); // 0x000000018429F83C-0x000000018429F8E8
	public static extern int CSharp_ResetRTPCValue__SWIG_1(uint jarg1, ulong jarg2, int jarg3, int jarg4); // 0x000000018429F8E8-0x000000018429F988
	public static extern int CSharp_ResetRTPCValue__SWIG_2(uint jarg1, ulong jarg2, int jarg3); // 0x000000018429F988-0x000000018429FA18
	public static extern int CSharp_ResetRTPCValue__SWIG_3(uint jarg1, ulong jarg2); // 0x000000018429FA18-0x000000018429FA58
	public static extern int CSharp_ResetRTPCValue__SWIG_4(uint jarg1); // 0x000000018429FA58-0x000000018429FA8C
	public static extern int CSharp_ResetRTPCValue__SWIG_5(string jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5); // 0x000000018429FA8C-0x000000018429FB48
	public static extern int CSharp_ResetRTPCValue__SWIG_6(string jarg1, ulong jarg2, int jarg3, int jarg4); // 0x000000018429FB48-0x000000018429FBF4
	public static extern int CSharp_ResetRTPCValue__SWIG_7(string jarg1, ulong jarg2, int jarg3); // 0x000000018429FBF4-0x000000018429FC8C
	public static extern int CSharp_ResetRTPCValue__SWIG_8(string jarg1, ulong jarg2); // 0x000000018429FC8C-0x000000018429FD18
	public static extern int CSharp_ResetRTPCValue__SWIG_9(string jarg1); // 0x000000018429FD18-0x000000018429FD94
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_0(uint jarg1, uint jarg2, int jarg3, int jarg4, bool jarg5); // 0x000000018429F360-0x000000018429F40C
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_1(uint jarg1, uint jarg2, int jarg3, int jarg4); // 0x000000018429F40C-0x000000018429F4A8
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_2(uint jarg1, uint jarg2, int jarg3); // 0x000000018429F4A8-0x000000018429F534
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_3(uint jarg1, uint jarg2); // 0x000000018429F534-0x000000018429F5B4
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_4(string jarg1, uint jarg2, int jarg3, int jarg4, bool jarg5); // 0x000000018429F5B4-0x000000018429F670
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_5(string jarg1, uint jarg2, int jarg3, int jarg4); // 0x000000018429F670-0x000000018429F718
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_6(string jarg1, uint jarg2, int jarg3); // 0x000000018429F718-0x000000018429F7B0
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_7(string jarg1, uint jarg2); // 0x000000018429F7B0-0x000000018429F83C
	public static extern int CSharp_SetSwitch__SWIG_0(uint jarg1, uint jarg2, ulong jarg3); // 0x00000001842A25A0-0x00000001842A262C
	public static extern int CSharp_SetSwitch__SWIG_1(string jarg1, string jarg2, ulong jarg3); // 0x00000001842A262C-0x00000001842A26D0
	public static extern int CSharp_PostTrigger__SWIG_0(uint jarg1, ulong jarg2); // 0x000000018429DE08-0x000000018429DE48
	public static extern int CSharp_PostTrigger__SWIG_1(string jarg1, ulong jarg2); // 0x000000018429DE48-0x000000018429DED4
	public static extern int CSharp_SetState__SWIG_0(uint jarg1, uint jarg2); // 0x0000000183232340-0x0000000183232380
	public static extern int CSharp_SetState__SWIG_1(string jarg1, string jarg2); // 0x00000001842A2508-0x00000001842A25A0
	public static extern int CSharp_SetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, uint jarg3); // 0x00000001842A0D4C-0x00000001842A0DDC
	public static extern int CSharp_SetGameObjectOutputBusVolume(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001842A0E60-0x00000001842A0EAC
	public static extern int CSharp_SetActorMixerEffect(uint jarg1, uint jarg2, uint jarg3); // 0x00000001842A0658-0x00000001842A06E4
	public static extern int CSharp_SetBusEffect__SWIG_0(uint jarg1, uint jarg2, uint jarg3); // 0x00000001842A0A40-0x00000001842A0ACC
	public static extern int CSharp_SetBusEffect__SWIG_1(string jarg1, uint jarg2, uint jarg3); // 0x00000001842A0ACC-0x00000001842A0B64
	public static extern int CSharp_SetOutputDeviceEffect(ulong jarg1, uint jarg2, uint jarg3); // 0x00000001842A1AC4-0x00000001842A1B54
	public static extern int CSharp_SetMixer__SWIG_0(uint jarg1, uint jarg2); // 0x00000001842A14FC-0x00000001842A157C
	public static extern int CSharp_SetMixer__SWIG_1(string jarg1, uint jarg2); // 0x00000001842A157C-0x00000001842A1608
	public static extern int CSharp_SetBusConfig__SWIG_0(uint jarg1, IntPtr jarg2); // 0x00000001842A07F8-0x00000001842A0878
	public static extern int CSharp_SetBusConfig__SWIG_1(string jarg1, IntPtr jarg2); // 0x00000001842A0878-0x00000001842A0904
	public static extern int CSharp_SetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, float jarg3, float jarg4); // 0x00000001842A19BC-0x00000001842A1A18
	public static extern int CSharp_SetMultipleObstructionAndOcclusion(ulong jarg1, ulong jarg2, IntPtr jarg3, uint jarg4); // 0x00000001842A1608-0x00000001842A16A8
	public static extern int CSharp_StartOutputCapture(string jarg1); // 0x00000001842A2738-0x00000001842A27B4
	public static extern int CSharp_StopOutputCapture(); // 0x00000001842A2AE8-0x00000001842A2B14
	public static extern int CSharp_AddOutputCaptureMarker(string jarg1); // 0x000000018428D7DC-0x000000018428D874
	public static extern int CSharp_AddOutputCaptureBinaryMarker(IntPtr jarg1, uint jarg2); // 0x000000018428D79C-0x000000018428D7DC
	public static extern uint CSharp_GetSampleRate(); // 0x000000018429B350-0x000000018429B37C
	public static extern int CSharp_StartProfilerCapture(string jarg1); // 0x00000001842A27E0-0x00000001842A285C
	public static extern int CSharp_StopProfilerCapture(); // 0x00000001842A2CC4-0x00000001842A2CF0
	public static extern int CSharp_SetOfflineRenderingFrameTime(float jarg1); // 0x00000001842A1A18-0x00000001842A1A4C
	public static extern int CSharp_SetOfflineRendering(bool jarg1); // 0x00000001842A1A4C-0x00000001842A1AC4
	public static extern int CSharp_RemoveOutput(ulong jarg1); // 0x000000018429F07C-0x000000018429F0F4
	public static extern int CSharp_ReplaceOutput__SWIG_0(IntPtr jarg1, ulong jarg2, out ulong jarg3); // 0x000000018429F1D4-0x000000018429F264
	public static extern int CSharp_ReplaceOutput__SWIG_1(IntPtr jarg1, ulong jarg2); // 0x000000018429F264-0x000000018429F2E8
	public static extern ulong CSharp_GetOutputID__SWIG_0(uint jarg1, uint jarg2); // 0x000000018429AC94-0x000000018429AD14
	public static extern ulong CSharp_GetOutputID__SWIG_1(string jarg1, uint jarg2); // 0x000000018429AD14-0x000000018429ADB4
	public static extern int CSharp_SetBusDevice__SWIG_0(uint jarg1, uint jarg2); // 0x00000001842A0904-0x00000001842A0984
	public static extern int CSharp_SetBusDevice__SWIG_1(string jarg1, string jarg2); // 0x00000001842A0984-0x00000001842A0A40
	public static extern int CSharp_GetDeviceList__SWIG_0(uint jarg1, uint jarg2, out uint jarg3, IntPtr jarg4); // 0x000000018429A5F8-0x000000018429A694
	public static extern int CSharp_GetDeviceList__SWIG_1(uint jarg1, out uint jarg2, IntPtr jarg3); // 0x0000000183618250-0x00000001836182F0
	public static extern int CSharp_SetOutputVolume(ulong jarg1, float jarg2); // 0x00000001842A1B54-0x00000001842A1B90
	public static extern int CSharp_GetDeviceSpatialAudioSupport(uint jarg1); // 0x00000001836180F0-0x0000000183618130
	public static extern int CSharp_Suspend__SWIG_0(bool jarg1, bool jarg2); // 0x00000001842A2D24-0x00000001842A2DA4
	public static extern int CSharp_Suspend__SWIG_1(bool jarg1); // 0x00000001842A2DA4-0x00000001842A2E1C
	public static extern int CSharp_Suspend__SWIG_2(); // 0x00000001842A2E1C-0x00000001842A2E48
	public static extern int CSharp_WakeupFromSuspend__SWIG_0(uint jarg1); // 0x00000001842A358C-0x00000001842A35C0
	public static extern int CSharp_WakeupFromSuspend__SWIG_1(); // 0x00000001842A35C0-0x00000001842A35EC
	public static extern uint CSharp_GetBufferTick(); // 0x000000018429A26C-0x000000018429A298
	public static extern ulong CSharp_GetSampleTick(); // 0x000000018429B37C-0x000000018429B3A8
	public static extern void CSharp_AkSegmentInfo_iCurrentPosition_set(IntPtr jarg1, int jarg2); // 0x0000000184297840-0x00000001842978C0
	public static extern int CSharp_AkSegmentInfo_iCurrentPosition_get(IntPtr jarg1); // 0x000000018429780C-0x0000000184297840
	public static extern void CSharp_AkSegmentInfo_iPreEntryDuration_set(IntPtr jarg1, int jarg2); // 0x0000000184297968-0x00000001842979A8
	public static extern int CSharp_AkSegmentInfo_iPreEntryDuration_get(IntPtr jarg1); // 0x0000000184297934-0x0000000184297968
	public static extern void CSharp_AkSegmentInfo_iActiveDuration_set(IntPtr jarg1, int jarg2); // 0x00000001842977CC-0x000000018429780C
	public static extern int CSharp_AkSegmentInfo_iActiveDuration_get(IntPtr jarg1); // 0x0000000184297798-0x00000001842977CC
	public static extern void CSharp_AkSegmentInfo_iPostExitDuration_set(IntPtr jarg1, int jarg2); // 0x00000001842978F4-0x0000000184297934
	public static extern int CSharp_AkSegmentInfo_iPostExitDuration_get(IntPtr jarg1); // 0x00000001842978C0-0x00000001842978F4
	public static extern void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(IntPtr jarg1, int jarg2); // 0x00000001842979DC-0x0000000184297A1C
	public static extern int CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1); // 0x00000001842979A8-0x00000001842979DC
	public static extern void CSharp_AkSegmentInfo_fBeatDuration_set(IntPtr jarg1, float jarg2); // 0x000000018429766C-0x00000001842976B0
	public static extern float CSharp_AkSegmentInfo_fBeatDuration_get(IntPtr jarg1); // 0x0000000184297638-0x000000018429766C
	public static extern void CSharp_AkSegmentInfo_fBarDuration_set(IntPtr jarg1, float jarg2); // 0x00000001842975F4-0x0000000184297638
	public static extern float CSharp_AkSegmentInfo_fBarDuration_get(IntPtr jarg1); // 0x00000001842975C0-0x00000001842975F4
	public static extern void CSharp_AkSegmentInfo_fGridDuration_set(IntPtr jarg1, float jarg2); // 0x00000001842976E4-0x0000000184297728
	public static extern float CSharp_AkSegmentInfo_fGridDuration_get(IntPtr jarg1); // 0x00000001842976B0-0x00000001842976E4
	public static extern void CSharp_AkSegmentInfo_fGridOffset_set(IntPtr jarg1, float jarg2); // 0x000000018429775C-0x0000000184297798
	public static extern float CSharp_AkSegmentInfo_fGridOffset_get(IntPtr jarg1); // 0x0000000184297728-0x000000018429775C
	public static extern IntPtr CSharp_new_AkSegmentInfo(); // 0x00000001842A55D4-0x00000001842A5600
	public static extern void CSharp_delete_AkSegmentInfo(IntPtr jarg1); // 0x00000001842A423C-0x00000001842A4270
	public static extern void CSharp_AkResourceMonitorDataSummary_totalCPU_set(IntPtr jarg1, float jarg2); // 0x0000000184297238-0x000000018429727C
	public static extern float CSharp_AkResourceMonitorDataSummary_totalCPU_get(IntPtr jarg1); // 0x0000000184297204-0x0000000184297238
	public static extern void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(IntPtr jarg1, float jarg2); // 0x00000001842971C8-0x0000000184297204
	public static extern float CSharp_AkResourceMonitorDataSummary_pluginCPU_get(IntPtr jarg1); // 0x0000000184297194-0x00000001842971C8
	public static extern void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(IntPtr jarg1, uint jarg2); // 0x0000000184297154-0x0000000184297194
	public static extern uint CSharp_AkResourceMonitorDataSummary_physicalVoices_get(IntPtr jarg1); // 0x0000000184297120-0x0000000184297154
	public static extern void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(IntPtr jarg1, uint jarg2); // 0x0000000184297324-0x0000000184297364
	public static extern uint CSharp_AkResourceMonitorDataSummary_virtualVoices_get(IntPtr jarg1); // 0x00000001842972F0-0x0000000184297324
	public static extern void CSharp_AkResourceMonitorDataSummary_totalVoices_set(IntPtr jarg1, uint jarg2); // 0x00000001842972B0-0x00000001842972F0
	public static extern uint CSharp_AkResourceMonitorDataSummary_totalVoices_get(IntPtr jarg1); // 0x000000018429727C-0x00000001842972B0
	public static extern void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(IntPtr jarg1, uint jarg2); // 0x00000001842970E0-0x0000000184297120
	public static extern uint CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(IntPtr jarg1); // 0x00000001842970AC-0x00000001842970E0
	public static extern IntPtr CSharp_new_AkResourceMonitorDataSummary(); // 0x00000001842A55A8-0x00000001842A55D4
	public static extern void CSharp_delete_AkResourceMonitorDataSummary(IntPtr jarg1); // 0x00000001842A41D4-0x00000001842A4208
	public static extern byte CSharp_AK_INVALID_MIDI_CHANNEL_get(); // 0x000000018428D308-0x000000018428D370
	public static extern byte CSharp_AK_INVALID_MIDI_NOTE_get(); // 0x000000018428D370-0x000000018428D39C
	public static extern void CSharp_AkMIDIEvent_byChan_set(IntPtr jarg1, byte jarg2); // 0x0000000184292968-0x00000001842929A8
	public static extern byte CSharp_AkMIDIEvent_byChan_get(IntPtr jarg1); // 0x0000000184292934-0x0000000184292968
	public static extern void CSharp_AkMIDIEvent_tGen_byParam1_set(IntPtr jarg1, byte jarg2); // 0x0000000184292F6C-0x0000000184292FAC
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam1_get(IntPtr jarg1); // 0x0000000184292F38-0x0000000184292F6C
	public static extern void CSharp_AkMIDIEvent_tGen_byParam2_set(IntPtr jarg1, byte jarg2); // 0x0000000184293024-0x0000000184293064
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam2_get(IntPtr jarg1); // 0x0000000184292FAC-0x0000000184293024
	public static extern IntPtr CSharp_new_AkMIDIEvent_tGen(); // 0x00000001842A4E7C-0x00000001842A4EA8
	public static extern void CSharp_delete_AkMIDIEvent_tGen(IntPtr jarg1); // 0x00000001842A3CC0-0x00000001842A3CF4
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(IntPtr jarg1, byte jarg2); // 0x00000001842931C4-0x0000000184293204
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(IntPtr jarg1); // 0x0000000184293190-0x00000001842931C4
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(IntPtr jarg1, byte jarg2); // 0x0000000184293238-0x00000001842932B8
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(IntPtr jarg1); // 0x0000000184293204-0x0000000184293238
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff(); // 0x00000001842A4ED4-0x00000001842A4F00
	public static extern void CSharp_delete_AkMIDIEvent_tNoteOnOff(IntPtr jarg1); // 0x00000001842A3D28-0x00000001842A3D5C
	public static extern void CSharp_AkMIDIEvent_tCc_byCc_set(IntPtr jarg1, byte jarg2); // 0x0000000184292D8C-0x0000000184292DCC
	public static extern byte CSharp_AkMIDIEvent_tCc_byCc_get(IntPtr jarg1); // 0x0000000184292D58-0x0000000184292D8C
	public static extern void CSharp_AkMIDIEvent_tCc_byValue_set(IntPtr jarg1, byte jarg2); // 0x0000000184292E44-0x0000000184292EC4
	public static extern byte CSharp_AkMIDIEvent_tCc_byValue_get(IntPtr jarg1); // 0x0000000184292DCC-0x0000000184292E44
	public static extern IntPtr CSharp_new_AkMIDIEvent_tCc(); // 0x00000001842A4E24-0x00000001842A4E50
	public static extern void CSharp_delete_AkMIDIEvent_tCc(IntPtr jarg1); // 0x00000001842A3C58-0x00000001842A3C8C
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(IntPtr jarg1, byte jarg2); // 0x00000001842932EC-0x000000018429336C
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(IntPtr jarg1); // 0x00000001842932B8-0x00000001842932EC
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(IntPtr jarg1, byte jarg2); // 0x00000001842933A0-0x0000000184293420
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(IntPtr jarg1); // 0x000000018429336C-0x00000001842933A0
	public static extern IntPtr CSharp_new_AkMIDIEvent_tPitchBend(); // 0x00000001842A4F00-0x00000001842A4F2C
	public static extern void CSharp_delete_AkMIDIEvent_tPitchBend(IntPtr jarg1); // 0x00000001842A3D5C-0x00000001842A3D90
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(IntPtr jarg1, byte jarg2); // 0x0000000184293098-0x00000001842930D8
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(IntPtr jarg1); // 0x0000000184293064-0x0000000184293098
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(IntPtr jarg1, byte jarg2); // 0x0000000184293150-0x0000000184293190
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(IntPtr jarg1); // 0x00000001842930D8-0x0000000184293150
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch(); // 0x00000001842A4EA8-0x00000001842A4ED4
	public static extern void CSharp_delete_AkMIDIEvent_tNoteAftertouch(IntPtr jarg1); // 0x00000001842A3CF4-0x00000001842A3D28
	public static extern void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(IntPtr jarg1, byte jarg2); // 0x0000000184292EF8-0x0000000184292F38
	public static extern byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(IntPtr jarg1); // 0x0000000184292EC4-0x0000000184292EF8
	public static extern IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch(); // 0x00000001842A4E50-0x00000001842A4E7C
	public static extern void CSharp_delete_AkMIDIEvent_tChanAftertouch(IntPtr jarg1); // 0x00000001842A3C8C-0x00000001842A3CC0
	public static extern void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(IntPtr jarg1, byte jarg2); // 0x0000000184293498-0x00000001842934D8
	public static extern byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(IntPtr jarg1); // 0x0000000184293420-0x0000000184293498
	public static extern IntPtr CSharp_new_AkMIDIEvent_tProgramChange(); // 0x00000001842A4F2C-0x00000001842A4F58
	public static extern void CSharp_delete_AkMIDIEvent_tProgramChange(IntPtr jarg1); // 0x00000001842A3D90-0x00000001842A3DC4
	public static extern void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(IntPtr jarg1, ushort jarg2); // 0x00000001842935C0-0x0000000184293644
	public static extern ushort CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(IntPtr jarg1); // 0x000000018429358C-0x00000001842935C0
	public static extern void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(IntPtr jarg1, uint jarg2); // 0x000000018429350C-0x000000018429358C
	public static extern uint CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(IntPtr jarg1); // 0x00000001842934D8-0x000000018429350C
	public static extern IntPtr CSharp_new_AkMIDIEvent_tWwiseCmd(); // 0x00000001842A4F58-0x00000001842A4F8C
	public static extern void CSharp_delete_AkMIDIEvent_tWwiseCmd(IntPtr jarg1); // 0x00000001842A3DC4-0x00000001842A3DF8
	public static extern void CSharp_AkMIDIEvent_Gen_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001842923B0-0x00000001842923F4
	public static extern IntPtr CSharp_AkMIDIEvent_Gen_get(IntPtr jarg1); // 0x000000018429237C-0x00000001842923B0
	public static extern void CSharp_AkMIDIEvent_Cc_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184292278-0x00000001842922FC
	public static extern IntPtr CSharp_AkMIDIEvent_Cc_get(IntPtr jarg1); // 0x0000000184292244-0x0000000184292278
	public static extern void CSharp_AkMIDIEvent_NoteOnOff_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001842924A0-0x00000001842924E4
	public static extern IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(IntPtr jarg1); // 0x000000018429246C-0x00000001842924A0
	public static extern void CSharp_AkMIDIEvent_PitchBend_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184292520-0x0000000184292564
	public static extern IntPtr CSharp_AkMIDIEvent_PitchBend_get(IntPtr jarg1); // 0x00000001842924E4-0x0000000184292520
	public static extern void CSharp_AkMIDIEvent_NoteAftertouch_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184292428-0x000000018429246C
	public static extern IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(IntPtr jarg1); // 0x00000001842923F4-0x0000000184292428
	public static extern void CSharp_AkMIDIEvent_ChanAftertouch_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184292338-0x000000018429237C
	public static extern IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(IntPtr jarg1); // 0x00000001842922FC-0x0000000184292338
	public static extern void CSharp_AkMIDIEvent_ProgramChange_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184292598-0x00000001842925DC
	public static extern IntPtr CSharp_AkMIDIEvent_ProgramChange_get(IntPtr jarg1); // 0x0000000184292564-0x0000000184292598
	public static extern void CSharp_AkMIDIEvent_WwiseCmd_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184292618-0x000000018429265C
	public static extern IntPtr CSharp_AkMIDIEvent_WwiseCmd_get(IntPtr jarg1); // 0x00000001842925DC-0x0000000184292618
	public static extern void CSharp_AkMIDIEvent_byType_set(IntPtr jarg1, int jarg2); // 0x0000000184292BBC-0x0000000184292BFC
	public static extern int CSharp_AkMIDIEvent_byType_get(IntPtr jarg1); // 0x0000000184292B88-0x0000000184292BBC
	public static extern void CSharp_AkMIDIEvent_byOnOffNote_set(IntPtr jarg1, byte jarg2); // 0x0000000184292A94-0x0000000184292B14
	public static extern byte CSharp_AkMIDIEvent_byOnOffNote_get(IntPtr jarg1); // 0x0000000184292A60-0x0000000184292A94
	public static extern void CSharp_AkMIDIEvent_byVelocity_set(IntPtr jarg1, byte jarg2); // 0x0000000184292D18-0x0000000184292D58
	public static extern byte CSharp_AkMIDIEvent_byVelocity_get(IntPtr jarg1); // 0x0000000184292CE4-0x0000000184292D18
	public static extern void CSharp_AkMIDIEvent_byCc_set(IntPtr jarg1, int jarg2); // 0x00000001842927FC-0x000000018429283C
	public static extern int CSharp_AkMIDIEvent_byCc_get(IntPtr jarg1); // 0x00000001842927C8-0x00000001842927FC
	public static extern void CSharp_AkMIDIEvent_byCcValue_set(IntPtr jarg1, byte jarg2); // 0x0000000184292788-0x00000001842927C8
	public static extern byte CSharp_AkMIDIEvent_byCcValue_get(IntPtr jarg1); // 0x0000000184292710-0x0000000184292788
	public static extern void CSharp_AkMIDIEvent_byValueLsb_set(IntPtr jarg1, byte jarg2); // 0x0000000184292C30-0x0000000184292C70
	public static extern byte CSharp_AkMIDIEvent_byValueLsb_get(IntPtr jarg1); // 0x0000000184292BFC-0x0000000184292C30
	public static extern void CSharp_AkMIDIEvent_byValueMsb_set(IntPtr jarg1, byte jarg2); // 0x0000000184292CA4-0x0000000184292CE4
	public static extern byte CSharp_AkMIDIEvent_byValueMsb_get(IntPtr jarg1); // 0x0000000184292C70-0x0000000184292CA4
	public static extern void CSharp_AkMIDIEvent_byAftertouchNote_set(IntPtr jarg1, byte jarg2); // 0x0000000184292690-0x0000000184292710
	public static extern byte CSharp_AkMIDIEvent_byAftertouchNote_get(IntPtr jarg1); // 0x000000018429265C-0x0000000184292690
	public static extern void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(IntPtr jarg1, byte jarg2); // 0x0000000184292A20-0x0000000184292A60
	public static extern byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(IntPtr jarg1); // 0x00000001842929A8-0x0000000184292A20
	public static extern void CSharp_AkMIDIEvent_byChanAftertouchValue_set(IntPtr jarg1, byte jarg2); // 0x00000001842928B4-0x0000000184292934
	public static extern byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(IntPtr jarg1); // 0x000000018429283C-0x00000001842928B4
	public static extern void CSharp_AkMIDIEvent_byProgramNum_set(IntPtr jarg1, byte jarg2); // 0x0000000184292B48-0x0000000184292B88
	public static extern byte CSharp_AkMIDIEvent_byProgramNum_get(IntPtr jarg1); // 0x0000000184292B14-0x0000000184292B48
	public static extern void CSharp_AkMIDIEvent_uCmd_set(IntPtr jarg1, ushort jarg2); // 0x0000000184293730-0x00000001842937B4
	public static extern ushort CSharp_AkMIDIEvent_uCmd_get(IntPtr jarg1); // 0x00000001842936B8-0x0000000184293730
	public static extern void CSharp_AkMIDIEvent_uArg_set(IntPtr jarg1, uint jarg2); // 0x0000000184293678-0x00000001842936B8
	public static extern uint CSharp_AkMIDIEvent_uArg_get(IntPtr jarg1); // 0x0000000184293644-0x0000000184293678
	public static extern IntPtr CSharp_new_AkMIDIEvent(); // 0x00000001842A4DF8-0x00000001842A4E24
	public static extern void CSharp_delete_AkMIDIEvent(IntPtr jarg1); // 0x00000001842A3C24-0x00000001842A3C58
	public static extern void CSharp_AkMIDIPost_uOffset_set(IntPtr jarg1, ulong jarg2); // 0x0000000184293B84-0x0000000184293BC8
	public static extern ulong CSharp_AkMIDIPost_uOffset_get(IntPtr jarg1); // 0x0000000184293B0C-0x0000000184293B84
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_0(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4); // 0x0000000184293824-0x00000001842938C4
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_1(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5); // 0x00000001842938C4-0x0000000184293974
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_2(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8); // 0x0000000184293974-0x0000000184293A24
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_3(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8, uint jarg9); // 0x0000000184293A24-0x0000000184293AD8
	public static extern void CSharp_AkMIDIPost_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001842937B4-0x00000001842937F8
	public static extern int CSharp_AkMIDIPost_GetSizeOf(); // 0x00000001842937F8-0x0000000184293824
	public static extern IntPtr CSharp_new_AkMIDIPost(); // 0x00000001842A4F8C-0x00000001842A4FB8
	public static extern void CSharp_delete_AkMIDIPost(IntPtr jarg1); // 0x00000001842A3DF8-0x00000001842A3E2C
	public static extern void CSharp_AkMemCategroyStats_uUsed_set(IntPtr jarg1, ulong jarg2); // 0x0000000184293E7C-0x0000000184293F00
	public static extern ulong CSharp_AkMemCategroyStats_uUsed_get(IntPtr jarg1); // 0x0000000184293E48-0x0000000184293E7C
	public static extern void CSharp_AkMemCategroyStats_uPeakUsed_set(IntPtr jarg1, ulong jarg2); // 0x0000000184293DC4-0x0000000184293E48
	public static extern ulong CSharp_AkMemCategroyStats_uPeakUsed_get(IntPtr jarg1); // 0x0000000184293D4C-0x0000000184293DC4
	public static extern void CSharp_AkMemCategroyStats_uAllocs_set(IntPtr jarg1, uint jarg2); // 0x0000000184293C98-0x0000000184293CD8
	public static extern uint CSharp_AkMemCategroyStats_uAllocs_get(IntPtr jarg1); // 0x0000000184293C64-0x0000000184293C98
	public static extern void CSharp_AkMemCategroyStats_uFrees_set(IntPtr jarg1, uint jarg2); // 0x0000000184293D0C-0x0000000184293D4C
	public static extern uint CSharp_AkMemCategroyStats_uFrees_get(IntPtr jarg1); // 0x0000000184293CD8-0x0000000184293D0C
	public static extern IntPtr CSharp_new_AkMemCategroyStats(); // 0x0000000183B38080-0x0000000183B380B0
	public static extern void CSharp_delete_AkMemCategroyStats(IntPtr jarg1); // 0x00000001842A3E60-0x00000001842A3E94
	public static extern void CSharp_AkMemGlobalStats_uUsed_set(IntPtr jarg1, ulong jarg2); // 0x000000018429429C-0x0000000184294320
	public static extern ulong CSharp_AkMemGlobalStats_uUsed_get(IntPtr jarg1); // 0x0000000184294224-0x000000018429429C
	public static extern void CSharp_AkMemGlobalStats_uDeviceUsed_set(IntPtr jarg1, ulong jarg2); // 0x0000000184293FE8-0x000000018429406C
	public static extern ulong CSharp_AkMemGlobalStats_uDeviceUsed_get(IntPtr jarg1); // 0x0000000184293FB4-0x0000000184293FE8
	public static extern void CSharp_AkMemGlobalStats_uReserved_set(IntPtr jarg1, ulong jarg2); // 0x00000001842941A0-0x0000000184294224
	public static extern ulong CSharp_AkMemGlobalStats_uReserved_get(IntPtr jarg1); // 0x0000000184294128-0x00000001842941A0
	public static extern void CSharp_AkMemGlobalStats_uMax_set(IntPtr jarg1, ulong jarg2); // 0x00000001842940E4-0x0000000184294128
	public static extern ulong CSharp_AkMemGlobalStats_uMax_get(IntPtr jarg1); // 0x000000018429406C-0x00000001842940E4
	public static extern IntPtr CSharp_new_AkMemGlobalStats(); // 0x00000001842A4FE4-0x00000001842A5010
	public static extern void CSharp_delete_AkMemGlobalStats(IntPtr jarg1); // 0x00000001842A3E94-0x00000001842A3EC8
	public static extern void CSharp_AkMemGetCategoryStats(int jarg1, IntPtr jarg2); // 0x0000000184293F00-0x0000000184293F80
	public static extern void CSharp_AkMemGetGlobalStats(IntPtr jarg1); // 0x0000000184293F80-0x0000000184293FB4
	public static extern void CSharp_StartProfileThreadUsage(); // 0x00000001842A27B4-0x00000001842A27E0
	public static extern ulong CSharp_StopProfileThreadUsage(); // 0x00000001842A2C98-0x00000001842A2CC4
	public static extern void CSharp_DumpToFile(string jarg1); // 0x00000001842990D8-0x0000000184299154
	public static extern ulong CSharp_GetGlobalUsed(); // 0x000000018429A9AC-0x000000018429A9D8
	public static extern ulong CSharp_GetGlobalReserved(); // 0x000000018429A944-0x000000018429A9AC
	public static extern void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(IntPtr jarg1, float jarg2); // 0x0000000182A043A0-0x0000000182A043F0
	public static extern float CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(IntPtr jarg1); // 0x0000000184294540-0x0000000184294574
	public static extern void CSharp_delete_AkMusicSettings(IntPtr jarg1); // 0x00000001842A3F30-0x00000001842A3F64
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_0(uint jarg1, IntPtr jarg2, bool jarg3); // 0x000000018429AFBC-0x000000018429B04C
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_1(uint jarg1, IntPtr jarg2); // 0x000000018429B04C-0x000000018429B0CC
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(IntPtr jarg1); // 0x000000018269D860-0x000000018269D8A0
	public static extern uint CSharp_AkSerializedCallbackHeader_eType_get(IntPtr jarg1); // 0x000000018269D920-0x000000018269D960
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_GetData(IntPtr jarg1); // 0x000000018269D820-0x000000018269D860
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(IntPtr jarg1); // 0x000000018269D8A0-0x000000018269D920
	public static extern IntPtr CSharp_new_AkSerializedCallbackHeader(); // 0x00000001842A5600-0x00000001842A562C
	public static extern void CSharp_delete_AkSerializedCallbackHeader(IntPtr jarg1); // 0x00000001842A4270-0x00000001842A42A4
	public static extern IntPtr CSharp_AkCallbackInfo_pCookie_get(IntPtr jarg1); // 0x000000018269F720-0x000000018269F7A0
	public static extern ulong CSharp_AkCallbackInfo_gameObjID_get(IntPtr jarg1); // 0x000000018269F810-0x000000018269F840
	public static extern IntPtr CSharp_new_AkCallbackInfo(); // 0x00000001842A47D4-0x00000001842A4800
	public static extern void CSharp_delete_AkCallbackInfo(IntPtr jarg1); // 0x00000001842A387C-0x00000001842A38B0
	public static extern uint CSharp_AkEventCallbackInfo_playingID_get(IntPtr jarg1); // 0x00000001842908B0-0x00000001842908E4
	public static extern uint CSharp_AkEventCallbackInfo_eventID_get(IntPtr jarg1); // 0x000000018269F8B0-0x000000018269F940
	public static extern IntPtr CSharp_new_AkEventCallbackInfo(); // 0x00000001842A49B4-0x00000001842A49E0
	public static extern void CSharp_delete_AkEventCallbackInfo(IntPtr jarg1); // 0x00000001842A3A50-0x00000001842A3A84
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChan_get(IntPtr jarg1); // 0x0000000184291F70-0x0000000184291FA4
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(IntPtr jarg1); // 0x000000018429200C-0x0000000184292040
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(IntPtr jarg1); // 0x0000000184292040-0x00000001842920B8
	public static extern int CSharp_AkMIDIEventCallbackInfo_byType_get(IntPtr jarg1); // 0x00000001842920EC-0x0000000184292120
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(IntPtr jarg1); // 0x0000000184291FD8-0x000000018429200C
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(IntPtr jarg1); // 0x00000001842921CC-0x0000000184292244
	public static extern int CSharp_AkMIDIEventCallbackInfo_byCc_get(IntPtr jarg1); // 0x0000000184291F08-0x0000000184291F3C
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(IntPtr jarg1); // 0x0000000184291ED4-0x0000000184291F08
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(IntPtr jarg1); // 0x0000000184292120-0x0000000184292198
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(IntPtr jarg1); // 0x0000000184292198-0x00000001842921CC
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(IntPtr jarg1); // 0x0000000184291EA0-0x0000000184291ED4
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(IntPtr jarg1); // 0x0000000184291FA4-0x0000000184291FD8
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(IntPtr jarg1); // 0x0000000184291F3C-0x0000000184291F70
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(IntPtr jarg1); // 0x00000001842920B8-0x00000001842920EC
	public static extern IntPtr CSharp_new_AkMIDIEventCallbackInfo(); // 0x00000001842A4DCC-0x00000001842A4DF8
	public static extern void CSharp_delete_AkMIDIEventCallbackInfo(IntPtr jarg1); // 0x00000001842A3BF0-0x00000001842A3C24
	public static extern uint CSharp_AkMarkerCallbackInfo_uIdentifier_get(IntPtr jarg1); // 0x0000000184293BFC-0x0000000184293C30
	public static extern uint CSharp_AkMarkerCallbackInfo_uPosition_get(IntPtr jarg1); // 0x0000000184293C30-0x0000000184293C64
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(IntPtr jarg1); // 0x0000000184293BC8-0x0000000184293BFC
	public static extern IntPtr CSharp_new_AkMarkerCallbackInfo(); // 0x00000001842A4FB8-0x00000001842A4FE4
	public static extern void CSharp_delete_AkMarkerCallbackInfo(IntPtr jarg1); // 0x00000001842A3E2C-0x00000001842A3E60
	public static extern float CSharp_AkDurationCallbackInfo_fDuration_get(IntPtr jarg1); // 0x0000000184290770-0x00000001842907A4
	public static extern float CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(IntPtr jarg1); // 0x00000001842907A4-0x00000001842907D8
	public static extern uint CSharp_AkDurationCallbackInfo_audioNodeID_get(IntPtr jarg1); // 0x0000000184290704-0x0000000184290738
	public static extern uint CSharp_AkDurationCallbackInfo_mediaID_get(IntPtr jarg1); // 0x00000001842907D8-0x000000018429080C
	public static extern bool CSharp_AkDurationCallbackInfo_bStreaming_get(IntPtr jarg1); // 0x0000000184290738-0x0000000184290770
	public static extern IntPtr CSharp_new_AkDurationCallbackInfo(); // 0x00000001842A495C-0x00000001842A4988
	public static extern void CSharp_delete_AkDurationCallbackInfo(IntPtr jarg1); // 0x00000001842A39E8-0x00000001842A3A1C
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(IntPtr jarg1); // 0x000000018429087C-0x00000001842908B0
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(IntPtr jarg1); // 0x000000018429080C-0x0000000184290840
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(IntPtr jarg1); // 0x0000000184290840-0x000000018429087C
	public static extern IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo(); // 0x00000001842A4988-0x00000001842A49B4
	public static extern void CSharp_delete_AkDynamicSequenceItemCallbackInfo(IntPtr jarg1); // 0x00000001842A3A1C-0x00000001842A3A50
	public static extern uint CSharp_AkMusicSyncCallbackInfo_playingID_get(IntPtr jarg1); // 0x00000001842945A8-0x00000001842945DC
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(IntPtr jarg1); // 0x00000001842946E0-0x0000000184294714
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(IntPtr jarg1); // 0x0000000184294748-0x000000018429477C
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(IntPtr jarg1); // 0x00000001842946AC-0x00000001842946E0
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(IntPtr jarg1); // 0x0000000184294714-0x0000000184294748
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1); // 0x000000018429477C-0x00000001842947B0
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(IntPtr jarg1); // 0x0000000184294610-0x0000000184294644
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(IntPtr jarg1); // 0x00000001842945DC-0x0000000184294610
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(IntPtr jarg1); // 0x0000000184294644-0x0000000184294678
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(IntPtr jarg1); // 0x0000000184294678-0x00000001842946AC
	public static extern int CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(IntPtr jarg1); // 0x0000000184294574-0x00000001842945A8
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(IntPtr jarg1); // 0x00000001842947B0-0x00000001842947E4
	public static extern IntPtr CSharp_new_AkMusicSyncCallbackInfo(); // 0x00000001842A5068-0x00000001842A5094
	public static extern void CSharp_delete_AkMusicSyncCallbackInfo(IntPtr jarg1); // 0x00000001842A3F64-0x00000001842A3F98
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(IntPtr jarg1); // 0x0000000184294470-0x00000001842944A4
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(IntPtr jarg1); // 0x00000001842944A4-0x00000001842944D8
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(IntPtr jarg1); // 0x000000018429450C-0x0000000184294540
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(IntPtr jarg1); // 0x00000001842944D8-0x000000018429450C
	public static extern IntPtr CSharp_new_AkMusicPlaylistCallbackInfo(); // 0x00000001842A503C-0x00000001842A5068
	public static extern void CSharp_delete_AkMusicPlaylistCallbackInfo(IntPtr jarg1); // 0x00000001842A3EFC-0x00000001842A3F30
	public static extern uint CSharp_AkBankCallbackInfo_bankID_get(IntPtr jarg1); // 0x000000018269B0F0-0x000000018269B130
	public static extern IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(IntPtr jarg1); // 0x000000018269AFB0-0x000000018269AFF0
	public static extern int CSharp_AkBankCallbackInfo_loadResult_get(IntPtr jarg1); // 0x000000018269B050-0x000000018269B090
	public static extern IntPtr CSharp_new_AkBankCallbackInfo(); // 0x00000001842A477C-0x00000001842A47A8
	public static extern void CSharp_delete_AkBankCallbackInfo(IntPtr jarg1); // 0x00000001842A3814-0x00000001842A3848
	public static extern int CSharp_AkMonitoringCallbackInfo_errorCode_get(IntPtr jarg1); // 0x0000000184294320-0x0000000184294354
	public static extern int CSharp_AkMonitoringCallbackInfo_errorLevel_get(IntPtr jarg1); // 0x0000000184294354-0x0000000184294388
	public static extern uint CSharp_AkMonitoringCallbackInfo_playingID_get(IntPtr jarg1); // 0x000000018429443C-0x0000000184294470
	public static extern ulong CSharp_AkMonitoringCallbackInfo_gameObjID_get(IntPtr jarg1); // 0x0000000184294388-0x0000000184294400
	public static extern IntPtr CSharp_AkMonitoringCallbackInfo_message_get(IntPtr jarg1); // 0x0000000184294400-0x000000018429443C
	public static extern IntPtr CSharp_new_AkMonitoringCallbackInfo(); // 0x00000001842A5010-0x00000001842A503C
	public static extern void CSharp_delete_AkMonitoringCallbackInfo(IntPtr jarg1); // 0x00000001842A3EC8-0x00000001842A3EFC
	public static extern bool CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(IntPtr jarg1); // 0x000000018428E548-0x000000018428E580
	public static extern IntPtr CSharp_new_AkAudioInterruptionCallbackInfo(); // 0x00000001842A46F8-0x00000001842A4724
	public static extern void CSharp_delete_AkAudioInterruptionCallbackInfo(IntPtr jarg1); // 0x00000001842A3744-0x00000001842A3778
	public static extern bool CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(IntPtr jarg1); // 0x000000018428E668-0x000000018428E6A0
	public static extern IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo(); // 0x00000001842A4750-0x00000001842A477C
	public static extern void CSharp_delete_AkAudioSourceChangeCallbackInfo(IntPtr jarg1); // 0x00000001842A37AC-0x00000001842A37E0
	public static extern int CSharp_AkCallbackSerializer_Init(); // 0x0000000182A01D70-0x0000000182A01DA0
	public static extern void CSharp_AkCallbackSerializer_Term(); // 0x000000018428EEE8-0x000000018428EF50
	public static extern IntPtr CSharp_AkCallbackSerializer_Lock(); // 0x000000018269D170-0x000000018269D1A0
	public static extern void CSharp_AkCallbackSerializer_Unlock(); // 0x0000000183020390-0x0000000183020400
	public static extern void CSharp_AkCallbackSerializer_SetLocalOutput(uint jarg1, string jarg2, uint jarg3, string jarg4, uint jarg5, uint jarg6); // 0x000000018428EE0C-0x000000018428EEE8
	public static extern int CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(bool jarg1, IntPtr jarg2); // 0x000000018428ED8C-0x000000018428EE0C
	public static extern IntPtr CSharp_new_AkCallbackSerializer(); // 0x00000001842A4800-0x00000001842A482C
	public static extern void CSharp_delete_AkCallbackSerializer(IntPtr jarg1); // 0x00000001842A38B0-0x00000001842A38E4
	public static extern IntPtr CSharp_new_MsgContext__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, bool jarg4); // 0x00000001842A5918-0x00000001842A59B8
	public static extern IntPtr CSharp_new_MsgContext__SWIG_1(uint jarg1, ulong jarg2, uint jarg3); // 0x00000001842A59B8-0x00000001842A5A48
	public static extern IntPtr CSharp_new_MsgContext__SWIG_2(uint jarg1, ulong jarg2); // 0x00000001842A5A48-0x00000001842A5AC8
	public static extern IntPtr CSharp_new_MsgContext__SWIG_3(uint jarg1); // 0x00000001842A5AC8-0x00000001842A5B40
	public static extern IntPtr CSharp_new_MsgContext__SWIG_4(); // 0x00000001842A5B40-0x00000001842A5B6C
	public static extern void CSharp_MsgContext_in_playingID_set(IntPtr jarg1, uint jarg2); // 0x000000018429CE6C-0x000000018429CEAC
	public static extern uint CSharp_MsgContext_in_playingID_get(IntPtr jarg1); // 0x000000018429CE38-0x000000018429CE6C
	public static extern void CSharp_MsgContext_in_gameObjID_set(IntPtr jarg1, ulong jarg2); // 0x000000018429CDB4-0x000000018429CE38
	public static extern ulong CSharp_MsgContext_in_gameObjID_get(IntPtr jarg1); // 0x000000018429CD3C-0x000000018429CDB4
	public static extern void CSharp_MsgContext_in_soundID_set(IntPtr jarg1, uint jarg2); // 0x000000018429CEE0-0x000000018429CF20
	public static extern uint CSharp_MsgContext_in_soundID_get(IntPtr jarg1); // 0x000000018429CEAC-0x000000018429CEE0
	public static extern void CSharp_MsgContext_in_bIsBus_set(IntPtr jarg1, bool jarg2); // 0x000000018429CCF8-0x000000018429CD3C
	public static extern bool CSharp_MsgContext_in_bIsBus_get(IntPtr jarg1); // 0x000000018429CCC0-0x000000018429CCF8
	public static extern void CSharp_delete_MsgContext(IntPtr jarg1); // 0x00000001842A44AC-0x00000001842A44E0
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_0(string jarg1, string jarg2); // 0x00000001842A57D8-0x00000001842A5870
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_1(string jarg1); // 0x00000001842A5870-0x00000001842A58EC
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_2(); // 0x00000001842A58EC-0x00000001842A5918
	public static extern void CSharp_MonitorErrorInfo_m_name_set(IntPtr jarg1, string jarg2); // 0x000000018429CAE4-0x000000018429CB70
	public static extern IntPtr CSharp_MonitorErrorInfo_m_name_get(IntPtr jarg1); // 0x000000018429CAA8-0x000000018429CAE4
	public static extern void CSharp_MonitorErrorInfo_m_message_set(IntPtr jarg1, string jarg2); // 0x000000018429CA1C-0x000000018429CAA8
	public static extern IntPtr CSharp_MonitorErrorInfo_m_message_get(IntPtr jarg1); // 0x000000018429C9E0-0x000000018429CA1C
	public static extern void CSharp_delete_MonitorErrorInfo(IntPtr jarg1); // 0x00000001842A4478-0x00000001842A44AC
	public static extern int CSharp_PostCode__SWIG_0(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6); // 0x000000018429D17C-0x000000018429D228
	public static extern int CSharp_PostCode__SWIG_1(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5); // 0x000000018429D228-0x000000018429D2C4
	public static extern int CSharp_PostCode__SWIG_2(int jarg1, int jarg2, uint jarg3, ulong jarg4); // 0x000000018429D2C4-0x000000018429D360
	public static extern int CSharp_PostCode__SWIG_3(int jarg1, int jarg2, uint jarg3); // 0x000000018429D360-0x000000018429D3EC
	public static extern int CSharp_PostCode__SWIG_4(int jarg1, int jarg2); // 0x000000018429D3EC-0x000000018429D46C
	public static extern int CSharp_PostCodeVarArg(int jarg1, int jarg2, IntPtr jarg3); // 0x000000018429D0F0-0x000000018429D17C
	public static extern int CSharp_PostString__SWIG_0(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6); // 0x000000018429DAD8-0x000000018429DB94
	public static extern int CSharp_PostString__SWIG_1(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5); // 0x000000018429DB94-0x000000018429DC3C
	public static extern int CSharp_PostString__SWIG_2(string jarg1, int jarg2, uint jarg3, ulong jarg4); // 0x000000018429DC3C-0x000000018429DCE4
	public static extern int CSharp_PostString__SWIG_3(string jarg1, int jarg2, uint jarg3); // 0x000000018429DCE4-0x000000018429DD7C
	public static extern int CSharp_PostString__SWIG_4(string jarg1, int jarg2); // 0x000000018429DD7C-0x000000018429DE08
	public static extern int CSharp_ResetTranslator(); // 0x000000018429FDC0-0x000000018429FDEC
	public static extern int CSharp_GetTimeStamp(); // 0x000000018429BD5C-0x000000018429BD88
	public static extern void CSharp_MonitorStreamMgrInit(IntPtr jarg1); // 0x000000018429CB70-0x000000018429CBA4
	public static extern void CSharp_MonitorStreamingDeviceInit(uint jarg1, IntPtr jarg2); // 0x000000018429CC40-0x000000018429CCC0
	public static extern void CSharp_MonitorStreamingDeviceDestroyed(uint jarg1); // 0x000000018429CC0C-0x000000018429CC40
	public static extern void CSharp_MonitorStreamMgrTerm(); // 0x000000018429CBA4-0x000000018429CC0C
	public static extern void CSharp_AkGetDefaultHighPriorityThreadProperties(IntPtr jarg1); // 0x0000000184290F30-0x0000000184290F64
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_0(uint jarg1, in uint[] jarg2, uint jarg3, uint jarg4); // 0x000000018429FDEC-0x000000018429FE94
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_1(uint jarg1, in uint[] jarg2, uint jarg3); // 0x000000018429FE94-0x000000018429FF2C
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3); // 0x000000018429A694-0x000000018429A720
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3); // 0x000000018429A720-0x000000018429A7AC
	public static extern void CSharp_AkPositioningInfo_fCenterPct_set(IntPtr jarg1, float jarg2); // 0x00000001842966B4-0x00000001842966F8
	public static extern float CSharp_AkPositioningInfo_fCenterPct_get(IntPtr jarg1); // 0x0000000184296680-0x00000001842966B4
	public static extern void CSharp_AkPositioningInfo_pannerType_set(IntPtr jarg1, int jarg2); // 0x0000000184296A64-0x0000000184296AA4
	public static extern int CSharp_AkPositioningInfo_pannerType_get(IntPtr jarg1); // 0x0000000184296A30-0x0000000184296A64
	public static extern void CSharp_AkPositioningInfo_e3dPositioningType_set(IntPtr jarg1, int jarg2); // 0x0000000184296640-0x0000000184296680
	public static extern int CSharp_AkPositioningInfo_e3dPositioningType_get(IntPtr jarg1); // 0x000000018429660C-0x0000000184296640
	public static extern void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(IntPtr jarg1, bool jarg2); // 0x000000018429649C-0x000000018429651C
	public static extern bool CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(IntPtr jarg1); // 0x0000000184296464-0x000000018429649C
	public static extern void CSharp_AkPositioningInfo_e3DSpatializationMode_set(IntPtr jarg1, int jarg2); // 0x00000001842965CC-0x000000018429660C
	public static extern int CSharp_AkPositioningInfo_e3DSpatializationMode_get(IntPtr jarg1); // 0x0000000184296598-0x00000001842965CC
	public static extern void CSharp_AkPositioningInfo_bEnableAttenuation_set(IntPtr jarg1, bool jarg2); // 0x0000000184296420-0x0000000184296464
	public static extern bool CSharp_AkPositioningInfo_bEnableAttenuation_get(IntPtr jarg1); // 0x00000001842963E8-0x0000000184296420
	public static extern void CSharp_AkPositioningInfo_bUseConeAttenuation_set(IntPtr jarg1, bool jarg2); // 0x0000000184296554-0x0000000184296598
	public static extern bool CSharp_AkPositioningInfo_bUseConeAttenuation_get(IntPtr jarg1); // 0x000000018429651C-0x0000000184296554
	public static extern void CSharp_AkPositioningInfo_fInnerAngle_set(IntPtr jarg1, float jarg2); // 0x00000001842967A4-0x00000001842967E8
	public static extern float CSharp_AkPositioningInfo_fInnerAngle_get(IntPtr jarg1); // 0x0000000184296770-0x00000001842967A4
	public static extern void CSharp_AkPositioningInfo_fOuterAngle_set(IntPtr jarg1, float jarg2); // 0x000000018429688C-0x00000001842968D0
	public static extern float CSharp_AkPositioningInfo_fOuterAngle_get(IntPtr jarg1); // 0x0000000184296858-0x000000018429688C
	public static extern void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(IntPtr jarg1, float jarg2); // 0x000000018429672C-0x0000000184296770
	public static extern float CSharp_AkPositioningInfo_fConeMaxAttenuation_get(IntPtr jarg1); // 0x00000001842966F8-0x000000018429672C
	public static extern void CSharp_AkPositioningInfo_LPFCone_set(IntPtr jarg1, float jarg2); // 0x000000018429632C-0x0000000184296370
	public static extern float CSharp_AkPositioningInfo_LPFCone_get(IntPtr jarg1); // 0x00000001842962F8-0x000000018429632C
	public static extern void CSharp_AkPositioningInfo_HPFCone_set(IntPtr jarg1, float jarg2); // 0x000000018429623C-0x0000000184296280
	public static extern float CSharp_AkPositioningInfo_HPFCone_get(IntPtr jarg1); // 0x0000000184296210-0x000000018429623C
	public static extern void CSharp_AkPositioningInfo_fMaxDistance_set(IntPtr jarg1, float jarg2); // 0x000000018429681C-0x0000000184296858
	public static extern float CSharp_AkPositioningInfo_fMaxDistance_get(IntPtr jarg1); // 0x00000001842967E8-0x000000018429681C
	public static extern void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x00000001842969F4-0x0000000184296A30
	public static extern float CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(IntPtr jarg1); // 0x00000001842969C0-0x00000001842969F4
	public static extern void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x0000000184296904-0x0000000184296948
	public static extern float CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(IntPtr jarg1); // 0x00000001842968D0-0x0000000184296904
	public static extern void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x000000018429697C-0x00000001842969C0
	public static extern float CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(IntPtr jarg1); // 0x0000000184296948-0x000000018429697C
	public static extern void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x00000001842963A4-0x00000001842963E8
	public static extern float CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(IntPtr jarg1); // 0x0000000184296370-0x00000001842963A4
	public static extern void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x00000001842962B4-0x00000001842962F8
	public static extern float CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(IntPtr jarg1); // 0x0000000184296280-0x00000001842962B4
	public static extern IntPtr CSharp_new_AkPositioningInfo(); // 0x00000001842A549C-0x00000001842A5504
	public static extern void CSharp_delete_AkPositioningInfo(IntPtr jarg1); // 0x00000001842A4138-0x00000001842A416C
	public static extern void CSharp_AkObjectInfo_objID_set(IntPtr jarg1, uint jarg2); // 0x0000000184294930-0x0000000184294970
	public static extern uint CSharp_AkObjectInfo_objID_get(IntPtr jarg1); // 0x00000001842948FC-0x0000000184294930
	public static extern void CSharp_AkObjectInfo_parentID_set(IntPtr jarg1, uint jarg2); // 0x00000001842949A4-0x00000001842949E4
	public static extern uint CSharp_AkObjectInfo_parentID_get(IntPtr jarg1); // 0x0000000184294970-0x00000001842949A4
	public static extern void CSharp_AkObjectInfo_iDepth_set(IntPtr jarg1, int jarg2); // 0x00000001842948BC-0x00000001842948FC
	public static extern int CSharp_AkObjectInfo_iDepth_get(IntPtr jarg1); // 0x0000000184294888-0x00000001842948BC
	public static extern void CSharp_AkObjectInfo_Clear(IntPtr jarg1); // 0x00000001842947E4-0x0000000184294818
	public static extern int CSharp_AkObjectInfo_GetSizeOf(); // 0x000000018429485C-0x0000000184294888
	public static extern void CSharp_AkObjectInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000184294818-0x000000018429485C
	public static extern IntPtr CSharp_new_AkObjectInfo(); // 0x00000001842A5094-0x00000001842A50C0
	public static extern void CSharp_delete_AkObjectInfo(IntPtr jarg1); // 0x00000001842A3F98-0x00000001842A3FCC
	public static extern int CSharp_GetPosition(ulong jarg1, IntPtr jarg2); // 0x000000018429B0CC-0x000000018429B150
	public static extern int CSharp_GetListenerPosition(ulong jarg1, IntPtr jarg2); // 0x000000018429AA10-0x000000018429AA94
	public static extern int CSharp_GetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5); // 0x000000018429B1D0-0x000000018429B270
	public static extern int CSharp_GetRTPCValue__SWIG_1(string jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5); // 0x000000018429B270-0x000000018429B31C
	public static extern int CSharp_GetSwitch__SWIG_0(uint jarg1, ulong jarg2, out uint jarg3); // 0x000000018429BC30-0x000000018429BCC0
	public static extern int CSharp_GetSwitch__SWIG_1(string jarg1, ulong jarg2, out uint jarg3); // 0x000000018429BCC0-0x000000018429BD5C
	public static extern int CSharp_GetState__SWIG_0(uint jarg1, out uint jarg2); // 0x000000018429BABC-0x000000018429BB3C
	public static extern int CSharp_GetState__SWIG_1(string jarg1, out uint jarg2); // 0x000000018429BB3C-0x000000018429BBC8
	public static extern int CSharp_GetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, ref uint jarg3); // 0x000000018429A7AC-0x000000018429A83C
	public static extern int CSharp_GetGameObjectDryLevelValue(ulong jarg1, ulong jarg2, out float jarg3); // 0x000000018429A83C-0x000000018429A8CC
	public static extern int CSharp_GetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, out float jarg3, out float jarg4); // 0x000000018429AB64-0x000000018429AC04
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_0(uint jarg1, ref uint jarg2, IntPtr jarg3); // 0x000000018429EA7C-0x000000018429EB0C
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_1(string jarg1, ref uint jarg2, IntPtr jarg3); // 0x000000018429EB0C-0x000000018429EBA8
	public static extern int CSharp_GetPositioningInfo(uint jarg1, IntPtr jarg2); // 0x000000018429B150-0x000000018429B1D0
	public static extern bool CSharp_GetIsGameObjectActive(ulong jarg1); // 0x000000018429A9D8-0x000000018429AA10
	public static extern float CSharp_GetMaxRadius(ulong jarg1); // 0x000000018429AB38-0x000000018429AB64
	public static extern uint CSharp_GetEventIDFromPlayingID(uint jarg1); // 0x0000000182A9F010-0x0000000182A9F040
	public static extern ulong CSharp_GetGameObjectFromPlayingID(uint jarg1); // 0x000000018429A8CC-0x000000018429A944
	public static extern int CSharp_GetPlayingIDsFromGameObject(ulong jarg1, ref uint jarg2, out uint[] jarg3); // 0x000000018429AEB0-0x000000018429AFBC
	public static extern int CSharp_GetCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3); // 0x000000018429A360-0x000000018429A3EC
	public static extern int CSharp_GetCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3); // 0x000000018429A3EC-0x000000018429A478
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint jarg1); // 0x000000018428D5B0-0x000000018428D628
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint jarg1); // 0x000000018428D628-0x000000018428D6A0
	public static extern void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint jarg1); // 0x000000018428D538-0x000000018428D5B0
	public static extern byte CSharp_ChannelMaskToNumChannels(uint jarg1); // 0x0000000184298CBC-0x0000000184298D34
	public static extern uint CSharp_ChannelMaskFromNumChannels(uint jarg1); // 0x0000000184298C88-0x0000000184298CBC
	public static extern byte CSharp_ChannelBitToIndex(uint jarg1, uint jarg2); // 0x0000000184298C08-0x0000000184298C88
	public static extern bool CSharp_HasSurroundChannels(uint jarg1); // 0x000000018429C024-0x000000018429C05C
	public static extern bool CSharp_HasStrictlyOnePairOfSurroundChannels(uint jarg1); // 0x000000018429BFAC-0x000000018429C024
	public static extern bool CSharp_HasSideAndRearChannels(uint jarg1); // 0x000000018429BF74-0x000000018429BFAC
	public static extern bool CSharp_HasHeightChannels(uint jarg1); // 0x000000018429BF3C-0x000000018429BF74
	public static extern uint CSharp_BackToSideChannels(uint jarg1); // 0x0000000184298AC0-0x0000000184298B38
	public static extern uint CSharp_StdChannelIndexToDisplayIndex(int jarg1, uint jarg2, uint jarg3); // 0x00000001842A2890-0x00000001842A291C
	public static extern void CSharp_AkChannelConfig_uNumChannels_set(IntPtr jarg1, uint jarg2); // 0x000000018428F410-0x000000018428F450
	public static extern uint CSharp_AkChannelConfig_uNumChannels_get(IntPtr jarg1); // 0x00000001826903B0-0x00000001826903F0
	public static extern void CSharp_AkChannelConfig_eConfigType_set(IntPtr jarg1, uint jarg2); // 0x000000018428F350-0x000000018428F3D0
	public static extern uint CSharp_AkChannelConfig_eConfigType_get(IntPtr jarg1); // 0x0000000182690320-0x0000000182690360
	public static extern void CSharp_AkChannelConfig_uChannelMask_set(IntPtr jarg1, uint jarg2); // 0x000000018428F3D0-0x000000018428F410
	public static extern uint CSharp_AkChannelConfig_uChannelMask_get(IntPtr jarg1); // 0x0000000182690290-0x00000001826902D0
	public static extern IntPtr CSharp_AkChannelConfig_Standard(uint jarg1); // 0x000000018428F31C-0x000000018428F350
	public static extern IntPtr CSharp_AkChannelConfig_Anonymous(uint jarg1); // 0x000000018428EF84-0x000000018428EFFC
	public static extern IntPtr CSharp_AkChannelConfig_Ambisonic(uint jarg1); // 0x000000018428EF50-0x000000018428EF84
	public static extern IntPtr CSharp_AkChannelConfig_Object(); // 0x000000018428F0A8-0x000000018428F0D4
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_0(); // 0x00000001842A482C-0x00000001842A4858
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_1(uint jarg1, uint jarg2); // 0x00000001842A4858-0x00000001842A48D8
	public static extern void CSharp_AkChannelConfig_Clear(IntPtr jarg1); // 0x000000018428EFFC-0x000000018428F030
	public static extern void CSharp_AkChannelConfig_SetStandard(IntPtr jarg1, uint jarg2); // 0x000000018428F2DC-0x000000018428F31C
	public static extern void CSharp_AkChannelConfig_SetStandardOrAnonymous(IntPtr jarg1, uint jarg2, uint jarg3); // 0x000000018428F24C-0x000000018428F2DC
	public static extern void CSharp_AkChannelConfig_SetAnonymous(IntPtr jarg1, uint jarg2); // 0x0000000182A4F430-0x0000000182A4F470
	public static extern void CSharp_AkChannelConfig_SetAmbisonic(IntPtr jarg1, uint jarg2); // 0x000000018428F170-0x000000018428F1B0
	public static extern void CSharp_AkChannelConfig_SetObject(IntPtr jarg1); // 0x000000018428F1B0-0x000000018428F1E4
	public static extern void CSharp_AkChannelConfig_SetSameAsMainMix(IntPtr jarg1); // 0x000000018428F1E4-0x000000018428F218
	public static extern void CSharp_AkChannelConfig_SetSameAsPassthrough(IntPtr jarg1); // 0x000000018428F218-0x000000018428F24C
	public static extern bool CSharp_AkChannelConfig_IsValid(IntPtr jarg1); // 0x000000018428F070-0x000000018428F0A8
	public static extern uint CSharp_AkChannelConfig_Serialize(IntPtr jarg1); // 0x000000018428F13C-0x000000018428F170
	public static extern void CSharp_AkChannelConfig_Deserialize(IntPtr jarg1, uint jarg2); // 0x000000018428F030-0x000000018428F070
	public static extern IntPtr CSharp_AkChannelConfig_RemoveLFE(IntPtr jarg1); // 0x000000018428F108-0x000000018428F13C
	public static extern IntPtr CSharp_AkChannelConfig_RemoveCenter(IntPtr jarg1); // 0x000000018428F0D4-0x000000018428F108
	public static extern void CSharp_delete_AkChannelConfig(IntPtr jarg1); // 0x00000001838060C0-0x0000000183806100
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_0(); // 0x00000001842A4C80-0x00000001842A4CAC
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3); // 0x00000001842A4CAC-0x00000001842A4D10
	public static extern void CSharp_AkImageSourceParams_sourcePosition_set(IntPtr jarg1, AkVector64 jarg2); // 0x00000001842911DC-0x0000000184291278
	public static extern AkVector64 CSharp_AkImageSourceParams_sourcePosition_get(IntPtr jarg1); // 0x0000000184291144-0x00000001842911DC
	public static extern void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(IntPtr jarg1, float jarg2); // 0x0000000184291010-0x0000000184291054
	public static extern float CSharp_AkImageSourceParams_fDistanceScalingFactor_get(IntPtr jarg1); // 0x0000000184290FDC-0x0000000184291010
	public static extern void CSharp_AkImageSourceParams_fLevel_set(IntPtr jarg1, float jarg2); // 0x0000000184291088-0x00000001842910CC
	public static extern float CSharp_AkImageSourceParams_fLevel_get(IntPtr jarg1); // 0x0000000184291054-0x0000000184291088
	public static extern void CSharp_AkImageSourceParams_fDiffraction_set(IntPtr jarg1, float jarg2); // 0x0000000184290F98-0x0000000184290FDC
	public static extern float CSharp_AkImageSourceParams_fDiffraction_get(IntPtr jarg1); // 0x0000000184290F64-0x0000000184290F98
	public static extern void CSharp_AkImageSourceParams_fOcclusion_set(IntPtr jarg1, float jarg2); // 0x0000000184291100-0x0000000184291144
	public static extern float CSharp_AkImageSourceParams_fOcclusion_get(IntPtr jarg1); // 0x00000001842910CC-0x0000000184291100
	public static extern void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(IntPtr jarg1, byte jarg2); // 0x00000001842912F0-0x0000000184291330
	public static extern byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(IntPtr jarg1); // 0x0000000184291278-0x00000001842912F0
	public static extern void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(IntPtr jarg1, byte jarg2); // 0x0000000184291364-0x00000001842913A4
	public static extern byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(IntPtr jarg1); // 0x0000000184291330-0x0000000184291364
	public static extern void CSharp_delete_AkImageSourceParams(IntPtr jarg1); // 0x00000001842A3B20-0x00000001842A3B54
	public static extern uint CSharp_kDefaultDiffractionMaxEdges_get(); // 0x00000001842A44E0-0x00000001842A450C
	public static extern uint CSharp_kDefaultDiffractionMaxPaths_get(); // 0x00000001842A450C-0x00000001842A4538
	public static extern float CSharp_kMaxDiffraction_get(); // 0x00000001842A45F8-0x00000001842A461C
	public static extern uint CSharp_kHashListBlockAllocItemCount_get(); // 0x00000001842A4590-0x00000001842A45F8
	public static extern uint CSharp_kDiffractionMaxEdges_get(); // 0x00000001842A4538-0x00000001842A4564
	public static extern uint CSharp_kDiffractionMaxPaths_get(); // 0x00000001842A4564-0x00000001842A4590
	public static extern uint CSharp_kPortalToPortalDiffractionMaxPaths_get(); // 0x00000001842A461C-0x00000001842A4648
	public static extern IntPtr CSharp_new_AkSpatialAudioInitSettings(); // 0x0000000182A02DE0-0x0000000182A02E10
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(IntPtr jarg1, uint jarg2); // 0x0000000182A03710-0x0000000182A03750
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(IntPtr jarg1); // 0x0000000184297D9C-0x0000000184297DD0
	public static extern void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(IntPtr jarg1, float jarg2); // 0x0000000182A03660-0x0000000182A036B0
	public static extern float CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(IntPtr jarg1); // 0x0000000184297D00-0x0000000184297D34
	public static extern void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(IntPtr jarg1, uint jarg2); // 0x0000000182A035C0-0x0000000182A03600
	public static extern uint CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(IntPtr jarg1); // 0x0000000182A02110-0x0000000182A02150
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000182A03520-0x0000000182A03560
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(IntPtr jarg1); // 0x0000000182A03B90-0x0000000182A03BD0
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000182A03480-0x0000000182A034C0
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(IntPtr jarg1); // 0x0000000182A03B00-0x0000000182A03B40
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(IntPtr jarg1, uint jarg2); // 0x0000000182A033E0-0x0000000182A03420
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(IntPtr jarg1); // 0x0000000184297D68-0x0000000184297D9C
	public static extern void CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000182A03340-0x0000000182A03380
	public static extern uint CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(IntPtr jarg1); // 0x0000000184297D34-0x0000000184297D68
	public static extern void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(IntPtr jarg1, float jarg2); // 0x0000000182A03290-0x0000000182A032E0
	public static extern float CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(IntPtr jarg1); // 0x0000000184297CCC-0x0000000184297D00
	public static extern void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(IntPtr jarg1, float jarg2); // 0x0000000182A031E0-0x0000000182A03230
	public static extern float CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(IntPtr jarg1); // 0x0000000184297C98-0x0000000184297CCC
	public static extern void CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(IntPtr jarg1, uint jarg2); // 0x0000000182A03140-0x0000000182A03180
	public static extern uint CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(IntPtr jarg1); // 0x0000000182A03A70-0x0000000182A03AB0
	public static extern void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(IntPtr jarg1, bool jarg2); // 0x0000000182A03090-0x0000000182A030E0
	public static extern bool CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(IntPtr jarg1); // 0x0000000184297C60-0x0000000184297C98
	public static extern void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(IntPtr jarg1, bool jarg2); // 0x0000000182A02FE0-0x0000000182A03030
	public static extern bool CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(IntPtr jarg1); // 0x0000000184297C28-0x0000000184297C60
	public static extern void CSharp_delete_AkSpatialAudioInitSettings(IntPtr jarg1); // 0x0000000183891A80-0x0000000183891AC0
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_0(); // 0x00000001842A4D10-0x00000001842A4D3C
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3); // 0x00000001842A4D3C-0x00000001842A4DA0
	public static extern void CSharp_AkImageSourceSettings_SetOneTexture(IntPtr jarg1, uint jarg2); // 0x00000001842913A4-0x00000001842913E4
	public static extern void CSharp_AkImageSourceSettings_params__set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291418-0x000000018429145C
	public static extern IntPtr CSharp_AkImageSourceSettings_params__get(IntPtr jarg1); // 0x00000001842913E4-0x0000000184291418
	public static extern void CSharp_delete_AkImageSourceSettings(IntPtr jarg1); // 0x00000001842A3B54-0x00000001842A3B88
	public static extern IntPtr CSharp_new_AkExtent__SWIG_0(); // 0x00000001842A49E0-0x00000001842A4A0C
	public static extern IntPtr CSharp_new_AkExtent__SWIG_1(float jarg1, float jarg2, float jarg3); // 0x00000001842A4A0C-0x00000001842A4A64
	public static extern void CSharp_AkExtent_halfWidth_set(IntPtr jarg1, float jarg2); // 0x0000000184290A08-0x0000000184290A4C
	public static extern float CSharp_AkExtent_halfWidth_get(IntPtr jarg1); // 0x00000001842909D4-0x0000000184290A08
	public static extern void CSharp_AkExtent_halfHeight_set(IntPtr jarg1, float jarg2); // 0x0000000184290990-0x00000001842909D4
	public static extern float CSharp_AkExtent_halfHeight_get(IntPtr jarg1); // 0x000000018429095C-0x0000000184290990
	public static extern void CSharp_AkExtent_halfDepth_set(IntPtr jarg1, float jarg2); // 0x0000000184290918-0x000000018429095C
	public static extern float CSharp_AkExtent_halfDepth_get(IntPtr jarg1); // 0x00000001842908E4-0x0000000184290918
	public static extern void CSharp_delete_AkExtent(IntPtr jarg1); // 0x00000001842A3A84-0x00000001842A3AB8
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_0(); // 0x00000001842A56B0-0x00000001842A56DC
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_1(ushort jarg1, ushort jarg2, ushort jarg3, ushort jarg4); // 0x00000001842A56DC-0x00000001842A5780
	public static extern void CSharp_AkTriangle_point0_set(IntPtr jarg1, ushort jarg2); // 0x00000001826D77F0-0x00000001826D7840
	public static extern ushort CSharp_AkTriangle_point0_get(IntPtr jarg1); // 0x00000001842983D8-0x0000000184298450
	public static extern void CSharp_AkTriangle_point1_set(IntPtr jarg1, ushort jarg2); // 0x00000001826D77A0-0x00000001826D77F0
	public static extern ushort CSharp_AkTriangle_point1_get(IntPtr jarg1); // 0x0000000184298450-0x0000000184298484
	public static extern void CSharp_AkTriangle_point2_set(IntPtr jarg1, ushort jarg2); // 0x00000001826D7710-0x00000001826D7750
	public static extern ushort CSharp_AkTriangle_point2_get(IntPtr jarg1); // 0x0000000184298484-0x00000001842984FC
	public static extern void CSharp_AkTriangle_surface_set(IntPtr jarg1, ushort jarg2); // 0x00000001826D7750-0x00000001826D77A0
	public static extern ushort CSharp_AkTriangle_surface_get(IntPtr jarg1); // 0x00000001842984FC-0x0000000184298574
	public static extern void CSharp_AkTriangle_Clear(IntPtr jarg1); // 0x00000001826D0090-0x00000001826D00D0
	public static extern int CSharp_AkTriangle_GetSizeOf(); // 0x00000001826CFF10-0x00000001826CFF40
	public static extern void CSharp_AkTriangle_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000184298394-0x00000001842983D8
	public static extern void CSharp_delete_AkTriangle(IntPtr jarg1); // 0x00000001842A43A8-0x00000001842A43DC
	public static extern IntPtr CSharp_new_AkAcousticSurface(); // 0x00000001842A46A0-0x00000001842A46CC
	public static extern void CSharp_AkAcousticSurface_textureID_set(IntPtr jarg1, uint jarg2); // 0x00000001826D5630-0x00000001826D5680
	public static extern uint CSharp_AkAcousticSurface_textureID_get(IntPtr jarg1); // 0x000000018428DFF8-0x000000018428E02C
	public static extern void CSharp_AkAcousticSurface_transmissionLoss_set(IntPtr jarg1, float jarg2); // 0x00000001826D55E0-0x00000001826D5630
	public static extern float CSharp_AkAcousticSurface_transmissionLoss_get(IntPtr jarg1); // 0x000000018428E02C-0x000000018428E060
	public static extern void CSharp_AkAcousticSurface_strName_set(IntPtr jarg1, string jarg2); // 0x000000018428DF64-0x000000018428DFF8
	public static extern IntPtr CSharp_AkAcousticSurface_strName_get(IntPtr jarg1); // 0x000000018428DF30-0x000000018428DF64
	public static extern void CSharp_AkAcousticSurface_Clear(IntPtr jarg1); // 0x00000001826D01D0-0x00000001826D0210
	public static extern void CSharp_AkAcousticSurface_DeleteName(IntPtr jarg1); // 0x000000018428DEFC-0x000000018428DF30
	public static extern int CSharp_AkAcousticSurface_GetSizeOf(); // 0x00000001826CFF40-0x00000001826CFF70
	public static extern void CSharp_AkAcousticSurface_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018428DEB8-0x000000018428DEFC
	public static extern void CSharp_delete_AkAcousticSurface(IntPtr jarg1); // 0x00000001842A3698-0x00000001842A36CC
	public static extern void CSharp_AkReflectionPathInfo_imageSource_set(IntPtr jarg1, AkVector64 jarg2); // 0x0000000184296DF4-0x0000000184296E90
	public static extern AkVector64 CSharp_AkReflectionPathInfo_imageSource_get(IntPtr jarg1); // 0x0000000184296D5C-0x0000000184296DF4
	public static extern void CSharp_AkReflectionPathInfo_numPathPoints_set(IntPtr jarg1, uint jarg2); // 0x0000000184296FF8-0x0000000184297038
	public static extern uint CSharp_AkReflectionPathInfo_numPathPoints_get(IntPtr jarg1); // 0x0000000184296FC4-0x0000000184296FF8
	public static extern void CSharp_AkReflectionPathInfo_numReflections_set(IntPtr jarg1, uint jarg2); // 0x000000018429706C-0x00000001842970AC
	public static extern uint CSharp_AkReflectionPathInfo_numReflections_get(IntPtr jarg1); // 0x0000000184297038-0x000000018429706C
	public static extern void CSharp_AkReflectionPathInfo_level_set(IntPtr jarg1, float jarg2); // 0x0000000184296F80-0x0000000184296FC4
	public static extern float CSharp_AkReflectionPathInfo_level_get(IntPtr jarg1); // 0x0000000184296F4C-0x0000000184296F80
	public static extern void CSharp_AkReflectionPathInfo_isOccluded_set(IntPtr jarg1, bool jarg2); // 0x0000000184296F08-0x0000000184296F4C
	public static extern bool CSharp_AkReflectionPathInfo_isOccluded_get(IntPtr jarg1); // 0x0000000184296E90-0x0000000184296F08
	public static extern int CSharp_AkReflectionPathInfo_GetSizeOf(); // 0x0000000184296D30-0x0000000184296D5C
	public static extern Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(IntPtr jarg1, uint jarg2); // 0x0000000184296C8C-0x0000000184296D30
	public static extern IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(IntPtr jarg1, uint jarg2); // 0x0000000184296BD0-0x0000000184296C50
	public static extern float CSharp_AkReflectionPathInfo_GetDiffraction(IntPtr jarg1, uint jarg2); // 0x0000000184296C50-0x0000000184296C8C
	public static extern void CSharp_AkReflectionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000184296B8C-0x0000000184296BD0
	public static extern IntPtr CSharp_new_AkReflectionPathInfo(); // 0x00000001842A557C-0x00000001842A55A8
	public static extern void CSharp_delete_AkReflectionPathInfo(IntPtr jarg1); // 0x00000001842A41A0-0x00000001842A41D4
	public static extern void CSharp_AkDiffractionPathInfo_emitterPos_set(IntPtr jarg1, AkVector64 jarg2); // 0x000000018429039C-0x0000000184290438
	public static extern AkVector64 CSharp_AkDiffractionPathInfo_emitterPos_get(IntPtr jarg1); // 0x0000000184290304-0x000000018429039C
	public static extern void CSharp_AkDiffractionPathInfo_virtualPos_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001842906C0-0x0000000184290704
	public static extern IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(IntPtr jarg1); // 0x000000018429068C-0x00000001842906C0
	public static extern void CSharp_AkDiffractionPathInfo_nodeCount_set(IntPtr jarg1, uint jarg2); // 0x000000018429046C-0x00000001842904AC
	public static extern uint CSharp_AkDiffractionPathInfo_nodeCount_get(IntPtr jarg1); // 0x0000000184290438-0x000000018429046C
	public static extern void CSharp_AkDiffractionPathInfo_diffraction_set(IntPtr jarg1, float jarg2); // 0x00000001842902C8-0x0000000184290304
	public static extern float CSharp_AkDiffractionPathInfo_diffraction_get(IntPtr jarg1); // 0x0000000184290294-0x00000001842902C8
	public static extern void CSharp_AkDiffractionPathInfo_transmissionLoss_set(IntPtr jarg1, float jarg2); // 0x0000000184290648-0x000000018429068C
	public static extern float CSharp_AkDiffractionPathInfo_transmissionLoss_get(IntPtr jarg1); // 0x0000000184290614-0x0000000184290648
	public static extern void CSharp_AkDiffractionPathInfo_totLength_set(IntPtr jarg1, float jarg2); // 0x00000001842905D0-0x0000000184290614
	public static extern float CSharp_AkDiffractionPathInfo_totLength_get(IntPtr jarg1); // 0x000000018429059C-0x00000001842905D0
	public static extern void CSharp_AkDiffractionPathInfo_obstructionValue_set(IntPtr jarg1, float jarg2); // 0x00000001842904E0-0x0000000184290524
	public static extern float CSharp_AkDiffractionPathInfo_obstructionValue_get(IntPtr jarg1); // 0x00000001842904AC-0x00000001842904E0
	public static extern void CSharp_AkDiffractionPathInfo_occlusionValue_set(IntPtr jarg1, float jarg2); // 0x0000000184290558-0x000000018429059C
	public static extern float CSharp_AkDiffractionPathInfo_occlusionValue_get(IntPtr jarg1); // 0x0000000184290524-0x0000000184290558
	public static extern int CSharp_AkDiffractionPathInfo_GetSizeOf(); // 0x0000000184290268-0x0000000184290294
	public static extern Vector3 CSharp_AkDiffractionPathInfo_GetNodes(IntPtr jarg1, uint jarg2); // 0x00000001842900C4-0x0000000184290168
	public static extern float CSharp_AkDiffractionPathInfo_GetAngles(IntPtr jarg1, uint jarg2); // 0x0000000184290088-0x00000001842900C4
	public static extern ulong CSharp_AkDiffractionPathInfo_GetPortals(IntPtr jarg1, uint jarg2); // 0x0000000184290168-0x00000001842901E8
	public static extern ulong CSharp_AkDiffractionPathInfo_GetRooms(IntPtr jarg1, uint jarg2); // 0x00000001842901E8-0x0000000184290268
	public static extern void CSharp_AkDiffractionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000184290044-0x0000000184290088
	public static extern IntPtr CSharp_new_AkDiffractionPathInfo(); // 0x00000001842A4930-0x00000001842A495C
	public static extern void CSharp_delete_AkDiffractionPathInfo(IntPtr jarg1); // 0x00000001842A39B4-0x00000001842A39E8
	public static extern IntPtr CSharp_new_AkRoomParams(); // 0x0000000183B0E6C0-0x0000000183B0E6F0
	public static extern void CSharp_AkRoomParams_Front_set(IntPtr jarg1, Vector3 jarg2); // 0x00000001831AD5B0-0x00000001831AD600
	public static extern Vector3 CSharp_AkRoomParams_Front_get(IntPtr jarg1); // 0x0000000184297364-0x00000001842973F8
	public static extern void CSharp_AkRoomParams_Up_set(IntPtr jarg1, Vector3 jarg2); // 0x00000001831AD4D0-0x00000001831AD520
	public static extern Vector3 CSharp_AkRoomParams_Up_get(IntPtr jarg1); // 0x000000018429752C-0x00000001842975C0
	public static extern void CSharp_AkRoomParams_ReverbAuxBus_set(IntPtr jarg1, uint jarg2); // 0x00000001831AD100-0x00000001831AD150
	public static extern uint CSharp_AkRoomParams_ReverbAuxBus_get(IntPtr jarg1); // 0x00000001842973F8-0x000000018429742C
	public static extern void CSharp_AkRoomParams_ReverbLevel_set(IntPtr jarg1, float jarg2); // 0x00000001831AD3F0-0x00000001831AD440
	public static extern float CSharp_AkRoomParams_ReverbLevel_get(IntPtr jarg1); // 0x000000018429742C-0x0000000184297460
	public static extern void CSharp_AkRoomParams_TransmissionLoss_set(IntPtr jarg1, float jarg2); // 0x00000001831AD330-0x00000001831AD380
	public static extern float CSharp_AkRoomParams_TransmissionLoss_get(IntPtr jarg1); // 0x00000001842974F8-0x000000018429752C
	public static extern void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(IntPtr jarg1, float jarg2); // 0x00000001831AD270-0x00000001831AD2C0
	public static extern float CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(IntPtr jarg1); // 0x0000000184297460-0x000000018429748C
	public static extern void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(IntPtr jarg1, bool jarg2); // 0x00000001831AD1C0-0x00000001831AD200
	public static extern bool CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(IntPtr jarg1); // 0x000000018429748C-0x00000001842974C4
	public static extern void CSharp_AkRoomParams_RoomPriority_set(IntPtr jarg1, uint jarg2); // 0x00000001831AD050-0x00000001831AD0A0
	public static extern uint CSharp_AkRoomParams_RoomPriority_get(IntPtr jarg1); // 0x00000001842974C4-0x00000001842974F8
	public static extern void CSharp_delete_AkRoomParams(IntPtr jarg1); // 0x00000001842A4208-0x00000001842A423C
	public static extern IntPtr CSharp_new_AkGeometryInstanceParams(); // 0x00000001842A4C54-0x00000001842A4C80
	public static extern void CSharp_AkGeometryInstanceParams_PositionAndOrientation_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184290CC8-0x0000000184290D0C
	public static extern IntPtr CSharp_AkGeometryInstanceParams_PositionAndOrientation_get(IntPtr jarg1); // 0x0000000184290C8C-0x0000000184290CC8
	public static extern void CSharp_AkGeometryInstanceParams_Scale_set(IntPtr jarg1, Vector3 jarg2); // 0x0000000184290DA0-0x0000000184290E38
	public static extern Vector3 CSharp_AkGeometryInstanceParams_Scale_get(IntPtr jarg1); // 0x0000000184290D0C-0x0000000184290DA0
	public static extern void CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_set(IntPtr jarg1, bool jarg2); // 0x0000000184290EB0-0x0000000184290F30
	public static extern bool CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_get(IntPtr jarg1); // 0x0000000184290E38-0x0000000184290EB0
	public static extern void CSharp_delete_AkGeometryInstanceParams(IntPtr jarg1); // 0x00000001842A3AEC-0x00000001842A3B20
	public static extern int CSharp_SetGameObjectRadius(ulong jarg1, float jarg2, float jarg3); // 0x00000001842A0EAC-0x00000001842A0EF8
	public static extern int CSharp_SetImageSource__SWIG_0(uint jarg1, IntPtr jarg2, string jarg3, uint jarg4, ulong jarg5); // 0x00000001842A0F44-0x00000001842A100C
	public static extern int CSharp_SetImageSource__SWIG_1(uint jarg1, IntPtr jarg2, string jarg3, uint jarg4); // 0x00000001842A100C-0x00000001842A10C8
	public static extern int CSharp_SetImageSource__SWIG_2(uint jarg1, IntPtr jarg2, string jarg3); // 0x00000001842A10C8-0x00000001842A117C
	public static extern int CSharp_RemoveImageSource__SWIG_0(uint jarg1, uint jarg2, ulong jarg3); // 0x000000018429EE78-0x000000018429EF04
	public static extern int CSharp_RemoveImageSource__SWIG_1(uint jarg1, uint jarg2); // 0x000000018429EF04-0x000000018429EF80
	public static extern int CSharp_RemoveImageSource__SWIG_2(uint jarg1); // 0x000000018429EF80-0x000000018429EFF8
	public static extern int CSharp_ClearImageSources__SWIG_0(uint jarg1, ulong jarg2); // 0x0000000184298DC8-0x0000000184298E48
	public static extern int CSharp_ClearImageSources__SWIG_1(uint jarg1); // 0x0000000184298E48-0x0000000184298E7C
	public static extern int CSharp_ClearImageSources__SWIG_2(); // 0x0000000184298E7C-0x0000000184298EB0
	public static extern int CSharp_RemoveGeometry(ulong jarg1); // 0x00000001831AE770-0x00000001831AE7A0
	public static extern int CSharp_RemoveGeometryInstance(ulong jarg1); // 0x0000000182AF6B40-0x0000000182AF6B80
	public static extern int CSharp_RemoveRoom(ulong jarg1); // 0x0000000182AF6A60-0x0000000182AF6AF0
	public static extern int CSharp_RemovePortal(ulong jarg1); // 0x000000018429F0F4-0x000000018429F128
	public static extern int CSharp_SetReverbZone(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001831AD850-0x00000001831AD8A0
	public static extern int CSharp_RemoveReverbZone(ulong jarg1); // 0x000000018429F128-0x000000018429F15C
	public static extern int CSharp_SetGameObjectInRoom(ulong jarg1, ulong jarg2); // 0x00000001842A0DDC-0x00000001842A0E60
	public static extern int CSharp_UnsetGameObjectInRoom(ulong jarg1); // 0x00000001842A3460-0x00000001842A3494
	public static extern int CSharp_SetReflectionsOrder(uint jarg1, bool jarg2); // 0x0000000182A01DA0-0x0000000182A01E30
	public static extern int CSharp_SetDiffractionOrder(uint jarg1, bool jarg2); // 0x0000000182A01E30-0x0000000182A01EC0
	public static extern int CSharp_SetMaxEmitterRoomAuxSends(uint jarg1); // 0x00000001842A13D0-0x00000001842A1404
	public static extern int CSharp_SetNumberOfPrimaryRays(uint jarg1); // 0x0000000182A03BD0-0x0000000182A03C50
	public static extern int CSharp_SetLoadBalancingSpread(uint jarg1); // 0x0000000182A03990-0x0000000182A039D0
	public static extern int CSharp_SetEarlyReflectionsAuxSend(ulong jarg1, uint jarg2); // 0x00000001842A0BE8-0x00000001842A0C68
	public static extern int CSharp_SetEarlyReflectionsVolume(ulong jarg1, float jarg2); // 0x00000001842A0C68-0x00000001842A0CA4
	public static extern int CSharp_SetPortalObstructionAndOcclusion(ulong jarg1, float jarg2, float jarg3); // 0x00000001842A1C88-0x00000001842A1CD4
	public static extern int CSharp_SetGameObjectToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001842A0EF8-0x00000001842A0F44
	public static extern int CSharp_SetPortalToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001842A1CD4-0x00000001842A1D20
	public static extern int CSharp_QueryWetDiffraction(ulong jarg1, out float jarg2); // 0x000000018429ECE8-0x000000018429ED6C
	public static extern int CSharp_ResetStochasticEngine(); // 0x000000018429FD94-0x000000018429FDC0
	public static extern void CSharp_AkPlatformInitSettings_threadLEngine_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184294E7C-0x0000000184294EC0
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(IntPtr jarg1); // 0x0000000184294E48-0x0000000184294E7C
	public static extern void CSharp_AkPlatformInitSettings_threadOutputMgr_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184294F6C-0x0000000184294FF0
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(IntPtr jarg1); // 0x0000000184294F38-0x0000000184294F6C
	public static extern void CSharp_AkPlatformInitSettings_threadBankManager_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184294E04-0x0000000184294E48
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(IntPtr jarg1); // 0x0000000184294DD0-0x0000000184294E04
	public static extern void CSharp_AkPlatformInitSettings_threadMonitor_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184294EF4-0x0000000184294F38
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(IntPtr jarg1); // 0x0000000184294EC0-0x0000000184294EF4
	public static extern void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(IntPtr jarg1, ushort jarg2); // 0x0000000182A04250-0x0000000182A042A0
	public static extern ushort CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(IntPtr jarg1); // 0x0000000184295024-0x000000018429509C
	public static extern void CSharp_AkPlatformInitSettings_uSampleRate_set(IntPtr jarg1, uint jarg2); // 0x0000000182A04300-0x0000000182A04340
	public static extern uint CSharp_AkPlatformInitSettings_uSampleRate_get(IntPtr jarg1); // 0x000000018429509C-0x0000000184295114
	public static extern void CSharp_AkPlatformInitSettings_bEnableAvxSupport_set(IntPtr jarg1, bool jarg2); // 0x0000000184294CD4-0x0000000184294D18
	public static extern bool CSharp_AkPlatformInitSettings_bEnableAvxSupport_get(IntPtr jarg1); // 0x0000000184294C9C-0x0000000184294CD4
	public static extern void CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x0000000183C97810-0x0000000183C97850
	public static extern uint CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_get(IntPtr jarg1); // 0x0000000184294FF0-0x0000000184295024
	public static extern void CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_set(IntPtr jarg1, bool jarg2); // 0x0000000184294D50-0x0000000184294DD0
	public static extern bool CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_get(IntPtr jarg1); // 0x0000000184294D18-0x0000000184294D50
	public static extern void CSharp_delete_AkPlatformInitSettings(IntPtr jarg1); // 0x00000001842A4034-0x00000001842A4068
	public static extern uint CSharp_GetDeviceIDFromName(string jarg1); // 0x000000018429A57C-0x000000018429A5F8
	public static extern IntPtr CSharp_GetWindowsDeviceName__SWIG_0(int jarg1, out uint jarg2, int jarg3); // 0x000000018429BE2C-0x000000018429BEBC
	public static extern IntPtr CSharp_GetWindowsDeviceName__SWIG_1(int jarg1, out uint jarg2); // 0x000000018429BEBC-0x000000018429BF3C
	public static extern uint CSharp_GetWindowsDeviceCount__SWIG_0(int jarg1); // 0x000000018429BD88-0x000000018429BE00
	public static extern uint CSharp_GetWindowsDeviceCount__SWIG_1(); // 0x000000018429BE00-0x000000018429BE2C
	public static extern void CSharp_delete_AkStreamMgrSettings(IntPtr jarg1); // 0x00000001842A430C-0x00000001842A4340
	public static extern void CSharp_AkDeviceSettings_pIOMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018428FDC4-0x000000018428FE08
	public static extern IntPtr CSharp_AkDeviceSettings_pIOMemory_get(IntPtr jarg1); // 0x000000018428FD90-0x000000018428FDC4
	public static extern void CSharp_AkDeviceSettings_uIOMemorySize_set(IntPtr jarg1, uint jarg2); // 0x0000000182A041B0-0x0000000182A041F0
	public static extern uint CSharp_AkDeviceSettings_uIOMemorySize_get(IntPtr jarg1); // 0x000000018428FF68-0x000000018428FF9C
	public static extern void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(IntPtr jarg1, uint jarg2); // 0x000000018428FF28-0x000000018428FF68
	public static extern uint CSharp_AkDeviceSettings_uIOMemoryAlignment_get(IntPtr jarg1); // 0x000000018428FEF4-0x000000018428FF28
	public static extern void CSharp_AkDeviceSettings_ePoolAttributes_set(IntPtr jarg1, uint jarg2); // 0x000000018428FD1C-0x000000018428FD5C
	public static extern uint CSharp_AkDeviceSettings_ePoolAttributes_get(IntPtr jarg1); // 0x000000018428FCE8-0x000000018428FD1C
	public static extern void CSharp_AkDeviceSettings_uGranularity_set(IntPtr jarg1, uint jarg2); // 0x000000018428FEB4-0x000000018428FEF4
	public static extern uint CSharp_AkDeviceSettings_uGranularity_get(IntPtr jarg1); // 0x000000018428FE80-0x000000018428FEB4
	public static extern void CSharp_AkDeviceSettings_threadProperties_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018428FE3C-0x000000018428FE80
	public static extern IntPtr CSharp_AkDeviceSettings_threadProperties_get(IntPtr jarg1); // 0x000000018428FE08-0x000000018428FE3C
	public static extern void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(IntPtr jarg1, float jarg2); // 0x0000000182A04100-0x0000000182A04150
	public static extern float CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(IntPtr jarg1); // 0x000000018428FD5C-0x000000018428FD90
	public static extern void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(IntPtr jarg1, uint jarg2); // 0x0000000184290004-0x0000000184290044
	public static extern uint CSharp_AkDeviceSettings_uMaxConcurrentIO_get(IntPtr jarg1); // 0x000000018428FFD0-0x0000000184290004
	public static extern void CSharp_AkDeviceSettings_bUseStreamCache_set(IntPtr jarg1, bool jarg2); // 0x0000000182A04050-0x0000000182A040A0
	public static extern bool CSharp_AkDeviceSettings_bUseStreamCache_get(IntPtr jarg1); // 0x000000018428FCB0-0x000000018428FCE8
	public static extern void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(IntPtr jarg1, uint jarg2); // 0x0000000182A03FB0-0x0000000182A03FF0
	public static extern uint CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(IntPtr jarg1); // 0x000000018428FF9C-0x000000018428FFD0
	public static extern void CSharp_delete_AkDeviceSettings(IntPtr jarg1); // 0x00000001842A3980-0x00000001842A39B4
	public static extern void CSharp_AkThreadProperties_nPriority_set(IntPtr jarg1, int jarg2); // 0x0000000184297EA8-0x0000000184297EE8
	public static extern int CSharp_AkThreadProperties_nPriority_get(IntPtr jarg1); // 0x0000000184297E74-0x0000000184297EA8
	public static extern void CSharp_AkThreadProperties_dwAffinityMask_set(IntPtr jarg1, uint jarg2); // 0x0000000184297E34-0x0000000184297E74
	public static extern uint CSharp_AkThreadProperties_dwAffinityMask_get(IntPtr jarg1); // 0x0000000184297E00-0x0000000184297E34
	public static extern void CSharp_AkThreadProperties_uStackSize_set(IntPtr jarg1, uint jarg2); // 0x0000000184297F1C-0x0000000184297F5C
	public static extern uint CSharp_AkThreadProperties_uStackSize_get(IntPtr jarg1); // 0x0000000184297EE8-0x0000000184297F1C
	public static extern IntPtr CSharp_new_AkThreadProperties(); // 0x00000001842A5684-0x00000001842A56B0
	public static extern void CSharp_delete_AkThreadProperties(IntPtr jarg1); // 0x00000001842A4340-0x00000001842A4374
	public static extern void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1); // 0x00000001822C6E80-0x00000001822C6F10
	public static extern void CSharp_SetErrorLogger__SWIG_1(); // 0x00000001842A0CA4-0x00000001842A0D0C
	public static extern void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2); // 0x00000001842A06E4-0x00000001842A077C
	public static extern void CSharp_delete_AkUnityPlatformSpecificSettings(IntPtr jarg1); // 0x00000001842A4410-0x00000001842A4444
	public static extern IntPtr CSharp_new_AkCommunicationSettings(); // 0x00000001842A48D8-0x00000001842A4904
	public static extern void CSharp_AkCommunicationSettings_uPoolSize_set(IntPtr jarg1, uint jarg2); // 0x000000018428FA74-0x000000018428FAB4
	public static extern uint CSharp_AkCommunicationSettings_uPoolSize_get(IntPtr jarg1); // 0x000000018428F9FC-0x000000018428FA74
	public static extern void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(IntPtr jarg1, ushort jarg2); // 0x000000018428F978-0x000000018428F9FC
	public static extern ushort CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(IntPtr jarg1); // 0x000000018428F900-0x000000018428F978
	public static extern void CSharp_AkCommunicationSettings_uCommandPort_set(IntPtr jarg1, ushort jarg2); // 0x000000018428F87C-0x000000018428F900
	public static extern ushort CSharp_AkCommunicationSettings_uCommandPort_get(IntPtr jarg1); // 0x000000018428F804-0x000000018428F87C
	public static extern void CSharp_AkCommunicationSettings_commSystem_set(IntPtr jarg1, int jarg2); // 0x000000018428F6BC-0x000000018428F73C
	public static extern int CSharp_AkCommunicationSettings_commSystem_get(IntPtr jarg1); // 0x000000018428F688-0x000000018428F6BC
	public static extern void CSharp_AkCommunicationSettings_bInitSystemLib_set(IntPtr jarg1, bool jarg2); // 0x000000018428F644-0x000000018428F688
	public static extern bool CSharp_AkCommunicationSettings_bInitSystemLib_get(IntPtr jarg1); // 0x000000018428F60C-0x000000018428F644
	public static extern void CSharp_AkCommunicationSettings_szAppNetworkName_set(IntPtr jarg1, string jarg2); // 0x000000018428F770-0x000000018428F804
	public static extern IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(IntPtr jarg1); // 0x000000018428F73C-0x000000018428F770
	public static extern void CSharp_delete_AkCommunicationSettings(IntPtr jarg1); // 0x00000001842A3918-0x00000001842A394C
	public static extern IntPtr CSharp_new_AkInitializationSettings(); // 0x0000000182A03D40-0x0000000182A03DB0
	public static extern void CSharp_delete_AkInitializationSettings(IntPtr jarg1); // 0x00000001839C1D80-0x00000001839C1DC0
	public static extern void CSharp_AkInitializationSettings_streamMgrSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291AD8-0x0000000184291B1C
	public static extern IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(IntPtr jarg1); // 0x0000000182A03900-0x0000000182A03940
	public static extern void CSharp_AkInitializationSettings_deviceSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291988-0x0000000184291A0C
	public static extern IntPtr CSharp_AkInitializationSettings_deviceSettings_get(IntPtr jarg1); // 0x0000000182A02CA0-0x0000000182A02CE0
	public static extern void CSharp_AkInitializationSettings_initSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291A0C-0x0000000184291A50
	public static extern IntPtr CSharp_AkInitializationSettings_initSettings_get(IntPtr jarg1); // 0x0000000182A02BD0-0x0000000182A02C10
	public static extern void CSharp_AkInitializationSettings_platformSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291A94-0x0000000184291AD8
	public static extern IntPtr CSharp_AkInitializationSettings_platformSettings_get(IntPtr jarg1); // 0x0000000182A02B00-0x0000000182A02B40
	public static extern void CSharp_AkInitializationSettings_musicSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291A50-0x0000000184291A94
	public static extern IntPtr CSharp_AkInitializationSettings_musicSettings_get(IntPtr jarg1); // 0x0000000182A03830-0x0000000182A03870
	public static extern void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184291BB8-0x0000000184291BFC
	public static extern IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(IntPtr jarg1); // 0x0000000182A02A30-0x0000000182A02A70
	public static extern void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(IntPtr jarg1, uint jarg2); // 0x0000000182A01C40-0x0000000182A01C80
	public static extern uint CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(IntPtr jarg1); // 0x0000000184291B1C-0x0000000184291B50
	public static extern void CSharp_AkInitializationSettings_uMemDebugLevel_set(IntPtr jarg1, uint jarg2); // 0x0000000182A03F10-0x0000000182A03F50
	public static extern uint CSharp_AkInitializationSettings_uMemDebugLevel_get(IntPtr jarg1); // 0x0000000184291B50-0x0000000184291B84
	public static extern void CSharp_AkInitializationSettings_uMemSpanCount_set(IntPtr jarg1, uint jarg2); // 0x0000000182A03E70-0x0000000182A03EB0
	public static extern uint CSharp_AkInitializationSettings_uMemSpanCount_get(IntPtr jarg1); // 0x0000000184291B84-0x0000000184291BB8
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0(); // 0x00000001842A4A64-0x00000001842A4A90
	public static extern void CSharp_delete_AkExternalSourceInfo(IntPtr jarg1); // 0x00000001842A3AB8-0x00000001842A3AEC
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4); // 0x00000001842A4A90-0x00000001842A4B30
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(string jarg1, uint jarg2, uint jarg3); // 0x00000001842A4B30-0x00000001842A4BC8
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(uint jarg1, uint jarg2, uint jarg3); // 0x00000001842A4BC8-0x00000001842A4C54
	public static extern void CSharp_AkExternalSourceInfo_Clear(IntPtr jarg1); // 0x0000000183C947C0-0x0000000183C94800
	public static extern void CSharp_AkExternalSourceInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000184290A4C-0x0000000184290A90
	public static extern int CSharp_AkExternalSourceInfo_GetSizeOf(); // 0x0000000183742290-0x00000001837422C0
	public static extern void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(IntPtr jarg1, uint jarg2); // 0x0000000182950840-0x0000000182950890
	public static extern uint CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(IntPtr jarg1); // 0x0000000184290A90-0x0000000184290AC4
	public static extern void CSharp_AkExternalSourceInfo_idCodec_set(IntPtr jarg1, uint jarg2); // 0x0000000182950790-0x00000001829507E0
	public static extern uint CSharp_AkExternalSourceInfo_idCodec_get(IntPtr jarg1); // 0x0000000184290AC4-0x0000000184290AF8
	public static extern void CSharp_AkExternalSourceInfo_szFile_set(IntPtr jarg1, string jarg2); // 0x0000000182950900-0x0000000182950950
	public static extern IntPtr CSharp_AkExternalSourceInfo_szFile_get(IntPtr jarg1); // 0x0000000184290BE4-0x0000000184290C18
	public static extern void CSharp_AkExternalSourceInfo_pInMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000184290BA0-0x0000000184290BE4
	public static extern IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(IntPtr jarg1); // 0x0000000184290B6C-0x0000000184290BA0
	public static extern void CSharp_AkExternalSourceInfo_uiMemorySize_set(IntPtr jarg1, uint jarg2); // 0x0000000184290C4C-0x0000000184290C8C
	public static extern uint CSharp_AkExternalSourceInfo_uiMemorySize_get(IntPtr jarg1); // 0x0000000184290C18-0x0000000184290C4C
	public static extern void CSharp_AkExternalSourceInfo_idFile_set(IntPtr jarg1, uint jarg2); // 0x0000000184290B2C-0x0000000184290B6C
	public static extern uint CSharp_AkExternalSourceInfo_idFile_get(IntPtr jarg1); // 0x0000000184290AF8-0x0000000184290B2C
	public static extern int CSharp_Init(IntPtr jarg1); // 0x0000000182A01F20-0x0000000182A01F60
	public static extern int CSharp_InitSpatialAudio(IntPtr jarg1); // 0x0000000182A01FC0-0x0000000182A02000
	public static extern int CSharp_InitCommunication(IntPtr jarg1); // 0x000000018429C088-0x000000018429C0BC
	public static extern void CSharp_Term(); // 0x00000001842A2E48-0x00000001842A2EB0
	public static extern int CSharp_RegisterGameObjInternal(ulong jarg1); // 0x00000001827612C0-0x00000001827612F0
	public static extern int CSharp_UnregisterGameObjInternal(ulong jarg1); // 0x0000000182AF8780-0x0000000182AF87B0
	public static extern int CSharp_RegisterGameObjInternal_WithName(ulong jarg1, string jarg2); // 0x00000001831ADF90-0x00000001831AE0E0
	public static extern int CSharp_SetBasePath(string jarg1); // 0x00000001842A07B8-0x00000001842A07F8
	public static extern int CSharp_SetCurrentLanguage(string jarg1); // 0x0000000182951D50-0x0000000182951D90
	public static extern int CSharp_LoadFilePackage(string jarg1, out uint jarg2); // 0x0000000182CB3A70-0x0000000182CB3AC0
	public static extern int CSharp_AddBasePath(string jarg1); // 0x0000000183708510-0x0000000183708550
	public static extern int CSharp_SetGameName(string jarg1); // 0x00000001842A0D0C-0x00000001842A0D4C
	public static extern IntPtr CSharp_GetCurrentLanguage(); // 0x000000018429A334-0x000000018429A360
	public static extern int CSharp_UnloadFilePackage(uint jarg1); // 0x0000000182CB4230-0x0000000182CB42C0
	public static extern int CSharp_UnloadAllFilePackages(); // 0x00000001842A2EB0-0x00000001842A2EDC
	public static extern int CSharp_SetObjectPosition(ulong jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x00000001828BB4D0-0x00000001828BB570
	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_0(uint jarg1, out uint[] jarg2, out uint[] jarg3, out int[] jarg4, ref uint jarg5, bool jarg6); // 0x000000018429B3A8-0x000000018429B58C
	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_1(uint jarg1, out uint[] jarg2, out uint[] jarg3, out int[] jarg4, ref uint jarg5); // 0x000000018429B58C-0x000000018429B760
	public static extern int CSharp_SetListeners(ulong jarg1, ulong[] jarg2, uint jarg3); // 0x00000001842A1334-0x00000001842A13D0
	public static extern int CSharp_SetDefaultListeners(ulong[] jarg1, uint jarg2); // 0x00000001826BD170-0x00000001826BD210
	public static extern uint CSharp_GetNumOutputDevices(uint jarg1); // 0x0000000183618060-0x00000001836180A0
	public static extern int CSharp_AddOutput__SWIG_0(IntPtr jarg1, out ulong jarg2, ulong[] jarg3, uint jarg4); // 0x000000018428D874-0x000000018428D920
	public static extern int CSharp_AddOutput__SWIG_1(IntPtr jarg1, out ulong jarg2, ulong[] jarg3); // 0x000000018428D920-0x000000018428D9BC
	public static extern int CSharp_AddOutput__SWIG_2(IntPtr jarg1, out ulong jarg2); // 0x000000018428D9BC-0x000000018428DA40
	public static extern int CSharp_AddOutput__SWIG_3(IntPtr jarg1); // 0x000000018428DA40-0x000000018428DA74
	public static extern void CSharp_GetDefaultStreamSettings(IntPtr jarg1); // 0x000000018429A548-0x000000018429A57C
	public static extern void CSharp_GetDefaultDeviceSettings(IntPtr jarg1); // 0x000000018429A478-0x000000018429A4AC
	public static extern void CSharp_GetDefaultMusicSettings(IntPtr jarg1); // 0x000000018429A4E0-0x000000018429A514
	public static extern void CSharp_GetDefaultInitSettings(IntPtr jarg1); // 0x000000018429A4AC-0x000000018429A4E0
	public static extern void CSharp_GetDefaultPlatformInitSettings(IntPtr jarg1); // 0x000000018429A514-0x000000018429A548
	public static extern uint CSharp_GetMajorMinorVersion(); // 0x000000018429AB0C-0x000000018429AB38
	public static extern uint CSharp_GetSubminorBuildVersion(); // 0x000000018429BBC8-0x000000018429BC30
	public static extern void CSharp_StartResourceMonitoring(); // 0x00000001842A285C-0x00000001842A2890
	public static extern void CSharp_StopResourceMonitoring(); // 0x00000001842A2CF0-0x00000001842A2D24
	public static extern void CSharp_GetResourceMonitorDataSummary(IntPtr jarg1); // 0x000000018429B31C-0x000000018429B350
	public static extern void CSharp_StartDeviceCapture(ulong jarg1); // 0x00000001842A2704-0x00000001842A2738
	public static extern void CSharp_StopDeviceCapture(ulong jarg1); // 0x00000001842A2948-0x00000001842A297C
	public static extern void CSharp_ClearCaptureData(); // 0x0000000184298D60-0x0000000184298DC8
	public static extern uint CSharp_UpdateCaptureSampleCount(ulong jarg1); // 0x00000001842A3514-0x00000001842A358C
	public static extern uint CSharp_GetCaptureSamples(ulong jarg1, [In, Out] float[] jarg2, uint jarg3); // 0x000000018429A298-0x000000018429A334
	public static extern int CSharp_SetRoomPortal(ulong jarg1, ulong jarg2, ulong jarg3, IntPtr jarg4, IntPtr jarg5, bool jarg6, string jarg7); // 0x00000001842A2364-0x00000001842A2450
	public static extern int CSharp_SetRoom(ulong jarg1, IntPtr jarg2, ulong jarg3, string jarg4); // 0x00000001831ACF70-0x00000001831ACFF0
	public static extern int CSharp_RegisterSpatialAudioListener(ulong jarg1); // 0x00000001826BD0F0-0x00000001826BD170
	public static extern int CSharp_UnregisterSpatialAudioListener(ulong jarg1); // 0x00000001842A342C-0x00000001842A3460
	public static extern int CSharp_SetGeometry(ulong jarg1, IntPtr jarg2, uint jarg3, Vector3[] jarg4, uint jarg5, IntPtr jarg6, uint jarg7, bool jarg8, bool jarg9); // 0x00000001826D54B0-0x00000001826D5540
	public static extern int CSharp_SetGeometryInstance(ulong jarg1, IntPtr jarg2, Vector3 jarg3, ulong jarg4, ulong jarg5, bool jarg6); // 0x00000001831ADBF0-0x00000001831ADC80
	public static extern int CSharp_QueryReflectionPaths(ulong jarg1, uint jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out uint jarg6); // 0x000000018429EC48-0x000000018429ECE8
	public static extern int CSharp_QueryDiffractionPaths(ulong jarg1, uint jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out uint jarg6); // 0x000000018429EBA8-0x000000018429EC48
	public static extern void CSharp_PerformStreamMgrIO(); // 0x000000018429CF98-0x000000018429CFC4
	public static extern void CSharp_HgMemShrink(); // 0x000000018429C05C-0x000000018429C088
	public static extern ulong CSharp_HgGetGlobalMemoryUsed(); // 0x000000018269BAA0-0x000000018269BAD0
	public static extern ulong CSharp_HgGetGlobalMemoryReserved(); // 0x00000001839CB020-0x00000001839CB050
	public static extern void CSharp_InitScePad(); // 0x00000001836563A0-0x0000000183656410
	public static extern uint CSharp_GetMMDeviceIdFromPadContainerInfo(int jarg1); // 0x000000018429AA94-0x000000018429AB0C
	public static extern IntPtr CSharp_AkPlaylist_SWIGUpcast(IntPtr jarg1); // 0x00000001842960AC-0x00000001842960E0
	public static extern IntPtr CSharp_AkMIDIPost_SWIGUpcast(IntPtr jarg1); // 0x0000000184293AD8-0x0000000184293B0C
	public static extern IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001831D8990-0x00000001831D89D0
	public static extern IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001831D8730-0x00000001831D87B0
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001831D8830-0x00000001831D8870
	public static extern IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001831D8A50-0x00000001831D8A90
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001831D8570-0x00000001831D85B0
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001831D84C0-0x00000001831D8500
	public static extern IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001831D8630-0x00000001831D86B0
}

public class AkSoundEngine // TypeDefIndex: 52932
{
	// Fields
	public const int _WIN32_WINNT = 1538; // Metadata: 0x01FD2F53
	public const int AK_SIMD_ALIGNMENT = 16; // Metadata: 0x01FD2F55
	public const int AK_BUFFER_ALIGNMENT = 16; // Metadata: 0x01FD2F56
	public const int AK_XAUDIO2_FLAGS = 0; // Metadata: 0x01FD2F57
	public const int AK_MAX_PATH = 260; // Metadata: 0x01FD2F58
	public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16; // Metadata: 0x01FD2F5A
	public const string AK_OSCHAR_FMT = "%ls"; // Metadata: 0x01FD2F5B
	public const uint AK_INVALID_PLUGINID = 4294967295; // Metadata: 0x01FD2F5F
	public const ulong AK_INVALID_GAME_OBJECT = 18446744073709551615; // Metadata: 0x01FD2F60
	public const uint AK_INVALID_UNIQUE_ID = 0; // Metadata: 0x01FD2F68
	public const uint AK_INVALID_RTPC_ID = 0; // Metadata: 0x01FD2F69
	public const uint AK_INVALID_LISTENER_INDEX = 4294967295; // Metadata: 0x01FD2F6A
	public const uint AK_INVALID_PLAYING_ID = 0; // Metadata: 0x01FD2F6B
	public const uint AK_DEFAULT_SWITCH_STATE = 0; // Metadata: 0x01FD2F6C
	public const int AK_INVALID_POOL_ID = -1; // Metadata: 0x01FD2F6D
	public const int AK_DEFAULT_POOL_ID = -1; // Metadata: 0x01FD2F6E
	public const uint AK_INVALID_AUX_ID = 0; // Metadata: 0x01FD2F6F
	public const uint AK_INVALID_FILE_ID = 4294967295; // Metadata: 0x01FD2F70
	public const uint AK_INVALID_DEVICE_ID = 4294967295; // Metadata: 0x01FD2F71
	public const uint AK_INVALID_BANK_ID = 0; // Metadata: 0x01FD2F72
	public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0; // Metadata: 0x01FD2F73
	public const uint AK_INVALID_CHANNELMASK = 0; // Metadata: 0x01FD2F74
	public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0; // Metadata: 0x01FD2F75
	public const uint AK_MIXER_FX_SLOT = 4294967295; // Metadata: 0x01FD2F76
	public const ulong AK_DEFAULT_LISTENER_OBJ = 0; // Metadata: 0x01FD2F77
	public const uint AK_DEFAULT_PRIORITY = 50; // Metadata: 0x01FD2F7F
	public const uint AK_MIN_PRIORITY = 0; // Metadata: 0x01FD2F80
	public const uint AK_MAX_PRIORITY = 100; // Metadata: 0x01FD2F81
	public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50; // Metadata: 0x01FD2F82
	public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576; // Metadata: 0x01FD2F83
	public const uint AKCOMPANYID_AUDIOKINETIC = 0; // Metadata: 0x01FD2F8B
	public const uint AK_LISTENERS_MASK_ALL = 4294967295; // Metadata: 0x01FD2F8C
	public const int NULL = 0; // Metadata: 0x01FD2F8D
	public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5; // Metadata: 0x01FD2F8E
	public const int AK_MAX_LANGUAGE_NAME_SIZE = 32; // Metadata: 0x01FD2F8F
	public const int AKCOMPANYID_PLUGINDEV_MIN = 64; // Metadata: 0x01FD2F90
	public const int AKCOMPANYID_PLUGINDEV_MAX = 255; // Metadata: 0x01FD2F92
	public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1; // Metadata: 0x01FD2F94
	public const int AKCOMPANYID_MCDSP = 256; // Metadata: 0x01FD2F95
	public const int AKCOMPANYID_WAVEARTS = 257; // Metadata: 0x01FD2F97
	public const int AKCOMPANYID_PHONETICARTS = 258; // Metadata: 0x01FD2F99
	public const int AKCOMPANYID_IZOTOPE = 259; // Metadata: 0x01FD2F9B
	public const int AKCOMPANYID_CRANKCASEAUDIO = 261; // Metadata: 0x01FD2F9D
	public const int AKCOMPANYID_IOSONO = 262; // Metadata: 0x01FD2F9F
	public const int AKCOMPANYID_AUROTECHNOLOGIES = 263; // Metadata: 0x01FD2FA1
	public const int AKCOMPANYID_DOLBY = 264; // Metadata: 0x01FD2FA3
	public const int AKCOMPANYID_TWOBIGEARS = 265; // Metadata: 0x01FD2FA5
	public const int AKCOMPANYID_OCULUS = 266; // Metadata: 0x01FD2FA7
	public const int AKCOMPANYID_BLUERIPPLESOUND = 267; // Metadata: 0x01FD2FA9
	public const int AKCOMPANYID_ENZIEN = 268; // Metadata: 0x01FD2FAB
	public const int AKCOMPANYID_KROTOS = 269; // Metadata: 0x01FD2FAD
	public const int AKCOMPANYID_NURULIZE = 270; // Metadata: 0x01FD2FAF
	public const int AKCOMPANYID_SUPERPOWERED = 271; // Metadata: 0x01FD2FB1
	public const int AKCOMPANYID_GOOGLE = 272; // Metadata: 0x01FD2FB3
	public const int AKCOMPANYID_VISISONICS = 277; // Metadata: 0x01FD2FB5
	public const int AKCODECID_BANK = 0; // Metadata: 0x01FD2FB7
	public const int AKCODECID_PCM = 1; // Metadata: 0x01FD2FB8
	public const int AKCODECID_ADPCM = 2; // Metadata: 0x01FD2FB9
	public const int AKCODECID_XMA = 3; // Metadata: 0x01FD2FBA
	public const int AKCODECID_VORBIS = 4; // Metadata: 0x01FD2FBB
	public const int AKCODECID_WIIADPCM = 5; // Metadata: 0x01FD2FBC
	public const int AKCODECID_PCMEX = 7; // Metadata: 0x01FD2FBD
	public const int AKCODECID_EXTERNAL_SOURCE = 8; // Metadata: 0x01FD2FBE
	public const int AKCODECID_XWMA = 9; // Metadata: 0x01FD2FBF
	public const int AKCODECID_FILE_PACKAGE = 11; // Metadata: 0x01FD2FC0
	public const int AKCODECID_ATRAC9 = 12; // Metadata: 0x01FD2FC1
	public const int AKCODECID_VAG = 13; // Metadata: 0x01FD2FC2
	public const int AKCODECID_PROFILERCAPTURE = 14; // Metadata: 0x01FD2FC3
	public const int AKCODECID_ANALYSISFILE = 15; // Metadata: 0x01FD2FC4
	public const int AKCODECID_MIDI = 16; // Metadata: 0x01FD2FC5
	public const int AKCODECID_OPUSNX = 17; // Metadata: 0x01FD2FC6
	public const int AKCODECID_CAF = 18; // Metadata: 0x01FD2FC7
	public const int AKCODECID_AKOPUS = 19; // Metadata: 0x01FD2FC8
	public const int AKCODECID_AKOPUS_WEM = 20; // Metadata: 0x01FD2FC9
	public const int AKCODECID_MEMORYMGR_DUMP = 21; // Metadata: 0x01FD2FCA
	public const int AKCODECID_SONY360 = 22; // Metadata: 0x01FD2FCB
	public const int AKCODECID_BANK_EVENT = 30; // Metadata: 0x01FD2FCC
	public const int AKCODECID_BANK_BUS = 31; // Metadata: 0x01FD2FCD
	public const int AKPLUGINID_METER = 129; // Metadata: 0x01FD2FCE
	public const int AKPLUGINID_RECORDER = 132; // Metadata: 0x01FD2FD0
	public const int AKPLUGINID_IMPACTER = 184; // Metadata: 0x01FD2FD2
	public const int AKPLUGINID_SYSTEM_OUTPUT_META = 900; // Metadata: 0x01FD2FD4
	public const int AKPLUGINID_AUDIO_OBJECT_ATTENUATION_META = 901; // Metadata: 0x01FD2FD6
	public const int AKPLUGINID_AUDIO_OBJECT_PRIORITY_META = 902; // Metadata: 0x01FD2FD8
	public const int AKEXTENSIONID_SPATIALAUDIO = 800; // Metadata: 0x01FD2FDA
	public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801; // Metadata: 0x01FD2FDC
	public const int AKEXTENSIONID_MIDIDEVICEMGR = 802; // Metadata: 0x01FD2FDE
	public const int AK_WAVE_FORMAT_VAG = 65531; // Metadata: 0x01FD2FE0
	public const int AK_WAVE_FORMAT_AT9 = 65532; // Metadata: 0x01FD2FE4
	public const int AK_WAVE_FORMAT_VORBIS = 65535; // Metadata: 0x01FD2FE8
	public const int AK_WAVE_FORMAT_OPUSNX = 12345; // Metadata: 0x01FD2FEC
	public const int AK_WAVE_FORMAT_OPUS = 12352; // Metadata: 0x01FD2FF0
	public const int AK_WAVE_FORMAT_OPUS_WEM = 12353; // Metadata: 0x01FD2FF4
	public const int WAVE_FORMAT_XMA2 = 358; // Metadata: 0x01FD2FF8
	public const int AK_PANNER_NUM_STORAGE_BITS = 3; // Metadata: 0x01FD2FFA
	public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3; // Metadata: 0x01FD2FFB
	public const int AK_SPAT_NUM_STORAGE_BITS = 3; // Metadata: 0x01FD2FFC
	public const int AK_MAX_BITS_METERING_FLAGS = 5; // Metadata: 0x01FD2FFD
	public const bool AK_ASYNC_OPEN_DEFAULT = false; // Metadata: 0x01FD2FFE
	public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024; // Metadata: 0x01FD2FFF
	public const double AK_DEFAULT_LISTENER_POSITION_X = 0; // Metadata: 0x01FD3003
	public const double AK_DEFAULT_LISTENER_POSITION_Y = 0; // Metadata: 0x01FD300B
	public const double AK_DEFAULT_LISTENER_POSITION_Z = 0; // Metadata: 0x01FD3013
	public const double AK_DEFAULT_LISTENER_FRONT_X = 0; // Metadata: 0x01FD301B
	public const double AK_DEFAULT_LISTENER_FRONT_Y = 0; // Metadata: 0x01FD3023
	public const double AK_DEFAULT_LISTENER_FRONT_Z = 1; // Metadata: 0x01FD302B
	public const double AK_DEFAULT_TOP_X = 0; // Metadata: 0x01FD3033
	public const double AK_DEFAULT_TOP_Y = 1; // Metadata: 0x01FD303B
	public const double AK_DEFAULT_TOP_Z = 0; // Metadata: 0x01FD3043
	public const double AK_SA_EPSILON = 0.001; // Metadata: 0x01FD304B
	public const double AK_SA_DIFFRACTION_EPSILON = 0.002; // Metadata: 0x01FD3053
	public const double AK_SA_PLANE_THICKNESS = 0.01; // Metadata: 0x01FD305B
	public const double AK_SA_MIN_ENVIRONMENT_ABSORPTION = 0.01; // Metadata: 0x01FD3063
	public const double AK_SA_MIN_ENVIRONMENT_SURFACE_AREA = 1; // Metadata: 0x01FD306B
	public const int AK_MIDI_EVENT_TYPE_INVALID = 0; // Metadata: 0x01FD3073
	public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128; // Metadata: 0x01FD3074
	public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144; // Metadata: 0x01FD3076
	public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160; // Metadata: 0x01FD3078
	public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176; // Metadata: 0x01FD307A
	public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192; // Metadata: 0x01FD307C
	public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208; // Metadata: 0x01FD307E
	public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224; // Metadata: 0x01FD3080
	public const int AK_MIDI_EVENT_TYPE_SYSEX = 240; // Metadata: 0x01FD3082
	public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247; // Metadata: 0x01FD3084
	public const int AK_MIDI_EVENT_TYPE_WWISE_CMD = 254; // Metadata: 0x01FD3086
	public const int AK_MIDI_EVENT_TYPE_META = 255; // Metadata: 0x01FD3088
	public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0; // Metadata: 0x01FD308A
	public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1; // Metadata: 0x01FD308B
	public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2; // Metadata: 0x01FD308C
	public const int AK_MIDI_CC_CTRL_3_COARSE = 3; // Metadata: 0x01FD308D
	public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4; // Metadata: 0x01FD308E
	public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5; // Metadata: 0x01FD308F
	public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6; // Metadata: 0x01FD3090
	public const int AK_MIDI_CC_VOLUME_COARSE = 7; // Metadata: 0x01FD3091
	public const int AK_MIDI_CC_BALANCE_COARSE = 8; // Metadata: 0x01FD3092
	public const int AK_MIDI_CC_CTRL_9_COARSE = 9; // Metadata: 0x01FD3093
	public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10; // Metadata: 0x01FD3094
	public const int AK_MIDI_CC_EXPRESSION_COARSE = 11; // Metadata: 0x01FD3095
	public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12; // Metadata: 0x01FD3096
	public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13; // Metadata: 0x01FD3097
	public const int AK_MIDI_CC_CTRL_14_COARSE = 14; // Metadata: 0x01FD3098
	public const int AK_MIDI_CC_CTRL_15_COARSE = 15; // Metadata: 0x01FD3099
	public const int AK_MIDI_CC_GEN_SLIDER_1 = 16; // Metadata: 0x01FD309A
	public const int AK_MIDI_CC_GEN_SLIDER_2 = 17; // Metadata: 0x01FD309B
	public const int AK_MIDI_CC_GEN_SLIDER_3 = 18; // Metadata: 0x01FD309C
	public const int AK_MIDI_CC_GEN_SLIDER_4 = 19; // Metadata: 0x01FD309D
	public const int AK_MIDI_CC_CTRL_20_COARSE = 20; // Metadata: 0x01FD309E
	public const int AK_MIDI_CC_CTRL_21_COARSE = 21; // Metadata: 0x01FD309F
	public const int AK_MIDI_CC_CTRL_22_COARSE = 22; // Metadata: 0x01FD30A0
	public const int AK_MIDI_CC_CTRL_23_COARSE = 23; // Metadata: 0x01FD30A1
	public const int AK_MIDI_CC_CTRL_24_COARSE = 24; // Metadata: 0x01FD30A2
	public const int AK_MIDI_CC_CTRL_25_COARSE = 25; // Metadata: 0x01FD30A3
	public const int AK_MIDI_CC_CTRL_26_COARSE = 26; // Metadata: 0x01FD30A4
	public const int AK_MIDI_CC_CTRL_27_COARSE = 27; // Metadata: 0x01FD30A5
	public const int AK_MIDI_CC_CTRL_28_COARSE = 28; // Metadata: 0x01FD30A6
	public const int AK_MIDI_CC_CTRL_29_COARSE = 29; // Metadata: 0x01FD30A7
	public const int AK_MIDI_CC_CTRL_30_COARSE = 30; // Metadata: 0x01FD30A8
	public const int AK_MIDI_CC_CTRL_31_COARSE = 31; // Metadata: 0x01FD30A9
	public const int AK_MIDI_CC_BANK_SELECT_FINE = 32; // Metadata: 0x01FD30AA
	public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33; // Metadata: 0x01FD30AB
	public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34; // Metadata: 0x01FD30AC
	public const int AK_MIDI_CC_CTRL_3_FINE = 35; // Metadata: 0x01FD30AD
	public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36; // Metadata: 0x01FD30AE
	public const int AK_MIDI_CC_PORTAMENTO_FINE = 37; // Metadata: 0x01FD30AF
	public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38; // Metadata: 0x01FD30B0
	public const int AK_MIDI_CC_VOLUME_FINE = 39; // Metadata: 0x01FD30B1
	public const int AK_MIDI_CC_BALANCE_FINE = 40; // Metadata: 0x01FD30B2
	public const int AK_MIDI_CC_CTRL_9_FINE = 41; // Metadata: 0x01FD30B3
	public const int AK_MIDI_CC_PAN_POSITION_FINE = 42; // Metadata: 0x01FD30B4
	public const int AK_MIDI_CC_EXPRESSION_FINE = 43; // Metadata: 0x01FD30B5
	public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44; // Metadata: 0x01FD30B6
	public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45; // Metadata: 0x01FD30B7
	public const int AK_MIDI_CC_CTRL_14_FINE = 46; // Metadata: 0x01FD30B8
	public const int AK_MIDI_CC_CTRL_15_FINE = 47; // Metadata: 0x01FD30B9
	public const int AK_MIDI_CC_CTRL_20_FINE = 52; // Metadata: 0x01FD30BA
	public const int AK_MIDI_CC_CTRL_21_FINE = 53; // Metadata: 0x01FD30BB
	public const int AK_MIDI_CC_CTRL_22_FINE = 54; // Metadata: 0x01FD30BC
	public const int AK_MIDI_CC_CTRL_23_FINE = 55; // Metadata: 0x01FD30BD
	public const int AK_MIDI_CC_CTRL_24_FINE = 56; // Metadata: 0x01FD30BE
	public const int AK_MIDI_CC_CTRL_25_FINE = 57; // Metadata: 0x01FD30BF
	public const int AK_MIDI_CC_CTRL_26_FINE = 58; // Metadata: 0x01FD30C0
	public const int AK_MIDI_CC_CTRL_27_FINE = 59; // Metadata: 0x01FD30C1
	public const int AK_MIDI_CC_CTRL_28_FINE = 60; // Metadata: 0x01FD30C2
	public const int AK_MIDI_CC_CTRL_29_FINE = 61; // Metadata: 0x01FD30C3
	public const int AK_MIDI_CC_CTRL_30_FINE = 62; // Metadata: 0x01FD30C4
	public const int AK_MIDI_CC_CTRL_31_FINE = 63; // Metadata: 0x01FD30C5
	public const int AK_MIDI_CC_HOLD_PEDAL = 64; // Metadata: 0x01FD30C6
	public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65; // Metadata: 0x01FD30C8
	public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66; // Metadata: 0x01FD30CA
	public const int AK_MIDI_CC_SOFT_PEDAL = 67; // Metadata: 0x01FD30CC
	public const int AK_MIDI_CC_LEGATO_PEDAL = 68; // Metadata: 0x01FD30CE
	public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69; // Metadata: 0x01FD30D0
	public const int AK_MIDI_CC_SOUND_VARIATION = 70; // Metadata: 0x01FD30D2
	public const int AK_MIDI_CC_SOUND_TIMBRE = 71; // Metadata: 0x01FD30D4
	public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72; // Metadata: 0x01FD30D6
	public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73; // Metadata: 0x01FD30D8
	public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74; // Metadata: 0x01FD30DA
	public const int AK_MIDI_CC_SOUND_CTRL_6 = 75; // Metadata: 0x01FD30DC
	public const int AK_MIDI_CC_SOUND_CTRL_7 = 76; // Metadata: 0x01FD30DE
	public const int AK_MIDI_CC_SOUND_CTRL_8 = 77; // Metadata: 0x01FD30E0
	public const int AK_MIDI_CC_SOUND_CTRL_9 = 78; // Metadata: 0x01FD30E2
	public const int AK_MIDI_CC_SOUND_CTRL_10 = 79; // Metadata: 0x01FD30E4
	public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80; // Metadata: 0x01FD30E6
	public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81; // Metadata: 0x01FD30E8
	public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82; // Metadata: 0x01FD30EA
	public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83; // Metadata: 0x01FD30EC
	public const int AK_MIDI_CC_REVERB_LEVEL = 91; // Metadata: 0x01FD30EE
	public const int AK_MIDI_CC_TREMOLO_LEVEL = 92; // Metadata: 0x01FD30F0
	public const int AK_MIDI_CC_CHORUS_LEVEL = 93; // Metadata: 0x01FD30F2
	public const int AK_MIDI_CC_CELESTE_LEVEL = 94; // Metadata: 0x01FD30F4
	public const int AK_MIDI_CC_PHASER_LEVEL = 95; // Metadata: 0x01FD30F6
	public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96; // Metadata: 0x01FD30F8
	public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97; // Metadata: 0x01FD30FA
	public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98; // Metadata: 0x01FD30FC
	public const int AK_MIDI_CC_NON_REGISTER_FINE = 99; // Metadata: 0x01FD30FE
	public const int AK_MIDI_CC_ALL_SOUND_OFF = 120; // Metadata: 0x01FD3100
	public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121; // Metadata: 0x01FD3102
	public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122; // Metadata: 0x01FD3104
	public const int AK_MIDI_CC_ALL_NOTES_OFF = 123; // Metadata: 0x01FD3106
	public const int AK_MIDI_CC_OMNI_MODE_OFF = 124; // Metadata: 0x01FD3108
	public const int AK_MIDI_CC_OMNI_MODE_ON = 125; // Metadata: 0x01FD310A
	public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126; // Metadata: 0x01FD310C
	public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127; // Metadata: 0x01FD310E
	public const int AK_MIDI_WWISE_CMD_PLAY = 0; // Metadata: 0x01FD3110
	public const int AK_MIDI_WWISE_CMD_STOP = 1; // Metadata: 0x01FD3111
	public const int AK_MIDI_WWISE_CMD_PAUSE = 2; // Metadata: 0x01FD3112
	public const int AK_MIDI_WWISE_CMD_RESUME = 3; // Metadata: 0x01FD3113
	public const int AK_MIDI_WWISE_CMD_SEEK_MS = 4; // Metadata: 0x01FD3114
	public const int AK_MIDI_WWISE_CMD_SEEK_SAMPLES = 5; // Metadata: 0x01FD3115
	public const int AK_SPEAKER_FRONT_LEFT = 1; // Metadata: 0x01FD3116
	public const int AK_SPEAKER_FRONT_RIGHT = 2; // Metadata: 0x01FD3117
	public const int AK_SPEAKER_FRONT_CENTER = 4; // Metadata: 0x01FD3118
	public const int AK_SPEAKER_LOW_FREQUENCY = 8; // Metadata: 0x01FD3119
	public const int AK_SPEAKER_BACK_LEFT = 16; // Metadata: 0x01FD311A
	public const int AK_SPEAKER_BACK_RIGHT = 32; // Metadata: 0x01FD311B
	public const int AK_SPEAKER_BACK_CENTER = 256; // Metadata: 0x01FD311C
	public const int AK_SPEAKER_SIDE_LEFT = 512; // Metadata: 0x01FD311E
	public const int AK_SPEAKER_SIDE_RIGHT = 1024; // Metadata: 0x01FD3120
	public const int AK_SPEAKER_TOP = 2048; // Metadata: 0x01FD3122
	public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096; // Metadata: 0x01FD3124
	public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192; // Metadata: 0x01FD3126
	public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384; // Metadata: 0x01FD312A
	public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768; // Metadata: 0x01FD312E
	public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536; // Metadata: 0x01FD3132
	public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072; // Metadata: 0x01FD3136
	public const int AK_SPEAKER_SETUP_MONO = 4; // Metadata: 0x01FD313A
	public const int AK_SPEAKER_SETUP_0POINT1 = 8; // Metadata: 0x01FD313B
	public const int AK_SPEAKER_SETUP_1POINT1 = 12; // Metadata: 0x01FD313C
	public const int AK_SPEAKER_SETUP_STEREO = 3; // Metadata: 0x01FD313D
	public const int AK_SPEAKER_SETUP_2POINT1 = 11; // Metadata: 0x01FD313E
	public const int AK_SPEAKER_SETUP_3STEREO = 7; // Metadata: 0x01FD313F
	public const int AK_SPEAKER_SETUP_3POINT1 = 15; // Metadata: 0x01FD3140
	public const int AK_SPEAKER_SETUP_4 = 1539; // Metadata: 0x01FD3141
	public const int AK_SPEAKER_SETUP_4POINT1 = 1547; // Metadata: 0x01FD3143
	public const int AK_SPEAKER_SETUP_5 = 1543; // Metadata: 0x01FD3145
	public const int AK_SPEAKER_SETUP_5POINT1 = 1551; // Metadata: 0x01FD3147
	public const int AK_SPEAKER_SETUP_6 = 1587; // Metadata: 0x01FD3149
	public const int AK_SPEAKER_SETUP_6POINT1 = 1595; // Metadata: 0x01FD314B
	public const int AK_SPEAKER_SETUP_7 = 1591; // Metadata: 0x01FD314D
	public const int AK_SPEAKER_SETUP_7POINT1 = 1599; // Metadata: 0x01FD314F
	public const int AK_SPEAKER_SETUP_SURROUND = 259; // Metadata: 0x01FD3151
	public const int AK_SPEAKER_SETUP_DPL2 = 1539; // Metadata: 0x01FD3153
	public const int AK_SPEAKER_SETUP_HEIGHT_2 = 20480; // Metadata: 0x01FD3155
	public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320; // Metadata: 0x01FD3159
	public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512; // Metadata: 0x01FD315D
	public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048; // Metadata: 0x01FD3161
	public const int AK_SPEAKER_SETUP_HEIGHT_4_TOP = 186368; // Metadata: 0x01FD3165
	public const int AK_SPEAKER_SETUP_HEIGHT_5_TOP = 194560; // Metadata: 0x01FD3169
	public const int AK_SPEAKER_SETUP_AURO_222 = 22019; // Metadata: 0x01FD316D
	public const int AK_SPEAKER_SETUP_AURO_8 = 185859; // Metadata: 0x01FD3171
	public const int AK_SPEAKER_SETUP_AURO_9 = 185863; // Metadata: 0x01FD3175
	public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871; // Metadata: 0x01FD3179
	public const int AK_SPEAKER_SETUP_AURO_10 = 187911; // Metadata: 0x01FD317D
	public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919; // Metadata: 0x01FD3181
	public const int AK_SPEAKER_SETUP_AURO_11 = 196103; // Metadata: 0x01FD3185
	public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111; // Metadata: 0x01FD3189
	public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911; // Metadata: 0x01FD318D
	public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919; // Metadata: 0x01FD3191
	public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151; // Metadata: 0x01FD3195
	public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159; // Metadata: 0x01FD3199
	public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023; // Metadata: 0x01FD319D
	public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031; // Metadata: 0x01FD31A1
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067; // Metadata: 0x01FD31A5
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075; // Metadata: 0x01FD31A9
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907; // Metadata: 0x01FD31AD
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915; // Metadata: 0x01FD31B1
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071; // Metadata: 0x01FD31B5
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079; // Metadata: 0x01FD31B9
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911; // Metadata: 0x01FD31BD
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919; // Metadata: 0x01FD31C1
	public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951; // Metadata: 0x01FD31C5
	public const int AK_IDX_SETUP_FRONT_LEFT = 0; // Metadata: 0x01FD31C9
	public const int AK_IDX_SETUP_FRONT_RIGHT = 1; // Metadata: 0x01FD31CA
	public const int AK_IDX_SETUP_CENTER = 2; // Metadata: 0x01FD31CB
	public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2; // Metadata: 0x01FD31CC
	public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3; // Metadata: 0x01FD31CD
	public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4; // Metadata: 0x01FD31CE
	public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5; // Metadata: 0x01FD31CF
	public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3; // Metadata: 0x01FD31D0
	public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4; // Metadata: 0x01FD31D1
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5; // Metadata: 0x01FD31D2
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6; // Metadata: 0x01FD31D3
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_LEFT = 7; // Metadata: 0x01FD31D4
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_RIGHT = 8; // Metadata: 0x01FD31D5
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_LEFT = 9; // Metadata: 0x01FD31D6
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_RIGHT = 10; // Metadata: 0x01FD31D7
	public const int AK_IDX_SETUP_0_LFE = 0; // Metadata: 0x01FD31D8
	public const int AK_IDX_SETUP_1_CENTER = 0; // Metadata: 0x01FD31D9
	public const int AK_IDX_SETUP_1_LFE = 1; // Metadata: 0x01FD31DA
	public const int AK_IDX_SETUP_2_LEFT = 0; // Metadata: 0x01FD31DB
	public const int AK_IDX_SETUP_2_RIGHT = 1; // Metadata: 0x01FD31DC
	public const int AK_IDX_SETUP_2_LFE = 2; // Metadata: 0x01FD31DD
	public const int AK_IDX_SETUP_3_LEFT = 0; // Metadata: 0x01FD31DE
	public const int AK_IDX_SETUP_3_RIGHT = 1; // Metadata: 0x01FD31DF
	public const int AK_IDX_SETUP_3_CENTER = 2; // Metadata: 0x01FD31E0
	public const int AK_IDX_SETUP_3_LFE = 3; // Metadata: 0x01FD31E1
	public const int AK_IDX_SETUP_4_FRONTLEFT = 0; // Metadata: 0x01FD31E2
	public const int AK_IDX_SETUP_4_FRONTRIGHT = 1; // Metadata: 0x01FD31E3
	public const int AK_IDX_SETUP_4_REARLEFT = 2; // Metadata: 0x01FD31E4
	public const int AK_IDX_SETUP_4_REARRIGHT = 3; // Metadata: 0x01FD31E5
	public const int AK_IDX_SETUP_4_LFE = 4; // Metadata: 0x01FD31E6
	public const int AK_IDX_SETUP_5_FRONTLEFT = 0; // Metadata: 0x01FD31E7
	public const int AK_IDX_SETUP_5_FRONTRIGHT = 1; // Metadata: 0x01FD31E8
	public const int AK_IDX_SETUP_5_CENTER = 2; // Metadata: 0x01FD31E9
	public const int AK_IDX_SETUP_5_REARLEFT = 3; // Metadata: 0x01FD31EA
	public const int AK_IDX_SETUP_5_REARRIGHT = 4; // Metadata: 0x01FD31EB
	public const int AK_IDX_SETUP_5_LFE = 5; // Metadata: 0x01FD31EC
	public const int AK_IDX_SETUP_6_FRONTLEFT = 0; // Metadata: 0x01FD31ED
	public const int AK_IDX_SETUP_6_FRONTRIGHT = 1; // Metadata: 0x01FD31EE
	public const int AK_IDX_SETUP_6_REARLEFT = 2; // Metadata: 0x01FD31EF
	public const int AK_IDX_SETUP_6_REARRIGHT = 3; // Metadata: 0x01FD31F0
	public const int AK_IDX_SETUP_6_SIDELEFT = 4; // Metadata: 0x01FD31F1
	public const int AK_IDX_SETUP_6_SIDERIGHT = 5; // Metadata: 0x01FD31F2
	public const int AK_IDX_SETUP_6_LFE = 6; // Metadata: 0x01FD31F3
	public const int AK_IDX_SETUP_7_FRONTLEFT = 0; // Metadata: 0x01FD31F4
	public const int AK_IDX_SETUP_7_FRONTRIGHT = 1; // Metadata: 0x01FD31F5
	public const int AK_IDX_SETUP_7_CENTER = 2; // Metadata: 0x01FD31F6
	public const int AK_IDX_SETUP_7_REARLEFT = 3; // Metadata: 0x01FD31F7
	public const int AK_IDX_SETUP_7_REARRIGHT = 4; // Metadata: 0x01FD31F8
	public const int AK_IDX_SETUP_7_SIDELEFT = 5; // Metadata: 0x01FD31F9
	public const int AK_IDX_SETUP_7_SIDERIGHT = 6; // Metadata: 0x01FD31FA
	public const int AK_IDX_SETUP_7_LFE = 7; // Metadata: 0x01FD31FB
	public const int AK_SPEAKER_SETUP_0_1 = 8; // Metadata: 0x01FD31FC
	public const int AK_SPEAKER_SETUP_1_0_CENTER = 4; // Metadata: 0x01FD31FD
	public const int AK_SPEAKER_SETUP_1_1_CENTER = 12; // Metadata: 0x01FD31FE
	public const int AK_SPEAKER_SETUP_2_0 = 3; // Metadata: 0x01FD31FF
	public const int AK_SPEAKER_SETUP_2_1 = 11; // Metadata: 0x01FD3200
	public const int AK_SPEAKER_SETUP_3_0 = 7; // Metadata: 0x01FD3201
	public const int AK_SPEAKER_SETUP_3_1 = 15; // Metadata: 0x01FD3202
	public const int AK_SPEAKER_SETUP_FRONT = 7; // Metadata: 0x01FD3203
	public const int AK_SPEAKER_SETUP_4_0 = 1539; // Metadata: 0x01FD3204
	public const int AK_SPEAKER_SETUP_4_1 = 1547; // Metadata: 0x01FD3206
	public const int AK_SPEAKER_SETUP_5_0 = 1543; // Metadata: 0x01FD3208
	public const int AK_SPEAKER_SETUP_5_1 = 1551; // Metadata: 0x01FD320A
	public const int AK_SPEAKER_SETUP_6_0 = 1587; // Metadata: 0x01FD320C
	public const int AK_SPEAKER_SETUP_6_1 = 1595; // Metadata: 0x01FD320E
	public const int AK_SPEAKER_SETUP_7_0 = 1591; // Metadata: 0x01FD3210
	public const int AK_SPEAKER_SETUP_7_1 = 1599; // Metadata: 0x01FD3212
	public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599; // Metadata: 0x01FD3214
	public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951; // Metadata: 0x01FD3216
	public const int AK_STANDARD_MAX_NUM_CHANNELS = 8; // Metadata: 0x01FD321A
	public const int AK_MAX_AMBISONICS_ORDER = 5; // Metadata: 0x01FD321B
	public const int AK_MAX_NUM_TEXTURE = 4; // Metadata: 0x01FD321C
	public const int AK_MAX_REFLECT_ORDER = 4; // Metadata: 0x01FD321D
	public const int AK_MAX_REFLECTION_PATH_LENGTH = 8; // Metadata: 0x01FD321E
	public const int AK_STOCHASTIC_RESERVE_LENGTH = 8; // Metadata: 0x01FD321F
	public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8; // Metadata: 0x01FD3220
	public const int AK_MAX_SOUND_PROPAGATION_WIDTH = 8; // Metadata: 0x01FD3221
	public const double AK_SA_DIFFRACTION_DOT_EPSILON = 5E-05; // Metadata: 0x01FD3222
	public const double AK_DEFAULT_GEOMETRY_POSITION_X = 0; // Metadata: 0x01FD322A
	public const double AK_DEFAULT_GEOMETRY_POSITION_Y = 0; // Metadata: 0x01FD3232
	public const double AK_DEFAULT_GEOMETRY_POSITION_Z = 0; // Metadata: 0x01FD323A
	public const double AK_DEFAULT_GEOMETRY_FRONT_X = 0; // Metadata: 0x01FD3242
	public const double AK_DEFAULT_GEOMETRY_FRONT_Y = 0; // Metadata: 0x01FD324A
	public const double AK_DEFAULT_GEOMETRY_FRONT_Z = 1; // Metadata: 0x01FD3252
	public const double AK_DEFAULT_GEOMETRY_TOP_X = 0; // Metadata: 0x01FD325A
	public const double AK_DEFAULT_GEOMETRY_TOP_Y = 1; // Metadata: 0x01FD3262
	public const double AK_DEFAULT_GEOMETRY_TOP_Z = 0; // Metadata: 0x01FD326A
	private static GameObjectHashFunction gameObjectHash; // 0x00
	public const uint AK_PENDING_EVENT_LOAD_ID = 4294967295; // Metadata: 0x01FD3272

	// Properties
	public static uint AK_INVALID_SHARE_SET_ID { get => default; } // 0x00000001842BBFA4-0x00000001842BBFE4 
	public static uint AK_INVALID_PIPELINE_ID { get => default; } // 0x00000001842BBF64-0x00000001842BBFA4 
	public static ulong AK_INVALID_AUDIO_OBJECT_ID { get => default; } // 0x00000001842BBEA4-0x00000001842BBEE4 
	public static uint AK_SOUNDBANK_VERSION { get => default; } // 0x00000001842BC124-0x00000001842BC164 
	public static uint AkJobType_Generic { get => default; } // 0x00000001842BC1A4-0x00000001842BC1E4 
	public static uint AkJobType_AudioProcessing { get => default; } // 0x00000001842BC164-0x00000001842BC1A4 
	public static uint AkJobType_SpatialAudio { get => default; } // 0x00000001842BC1E4-0x00000001842BC224 
	public static uint AK_NUM_JOB_TYPES { get => default; } // 0x00000001842BC0E4-0x00000001842BC124 
	public static ushort AK_INT { get => default; } // 0x00000001842BBE64-0x00000001842BBEA4 
	public static ushort AK_FLOAT { get => default; } // 0x00000001842BBDE4-0x00000001842BBE24 
	public static byte AK_INTERLEAVED { get => default; } // 0x00000001842BBE24-0x00000001842BBE64 
	public static byte AK_NONINTERLEAVED { get => default; } // 0x00000001842BC0A4-0x00000001842BC0E4 
	public static uint AK_LE_NATIVE_BITSPERSAMPLE { get => default; } // 0x00000001842BBFE4-0x00000001842BC024 
	public static uint AK_LE_NATIVE_SAMPLETYPE { get => default; } // 0x00000001842BC064-0x00000001842BC0A4 
	public static uint AK_LE_NATIVE_INTERLEAVE { get => default; } // 0x00000001842BC024-0x00000001842BC064 
	public static byte AK_INVALID_MIDI_CHANNEL { get => default; } // 0x00000001842BBEE4-0x00000001842BBF24 
	public static byte AK_INVALID_MIDI_NOTE { get => default; } // 0x00000001842BBF24-0x00000001842BBF64 
	public static uint kDefaultDiffractionMaxEdges { get => default; } // 0x00000001842BC3B4-0x00000001842BC3F4 
	public static uint kDefaultDiffractionMaxPaths { get => default; } // 0x00000001842BC3F4-0x00000001842BC434 
	public static float kMaxDiffraction { get => default; } // 0x00000001842BC4F4-0x00000001842BC534 
	public static uint kHashListBlockAllocItemCount { get => default; } // 0x00000001842BC4B4-0x00000001842BC4F4 
	public static uint kDiffractionMaxEdges { get => default; } // 0x00000001842BC434-0x00000001842BC474 
	public static uint kDiffractionMaxPaths { get => default; } // 0x00000001842BC474-0x00000001842BC4B4 
	public static uint kPortalToPortalDiffractionMaxPaths { get => default; } // 0x00000001842BC534-0x00000001842BC574 
	public static GameObjectHashFunction GameObjectHash { set {} } // 0x00000001842BC574-0x00000001842BC61C
	public static string WwiseVersion { get => default; } // 0x00000001842BC224-0x00000001842BC3B4 

	// Nested types
	public delegate ulong GameObjectHashFunction(GameObject gameObject); // TypeDefIndex: 52931; 0x000000018102B410-0x000000018102B420

	// Constructors
	public AkSoundEngine() {} // 0x000000018350B670-0x000000018350B680
	static AkSoundEngine() {} // 0x0000000183B3A280-0x0000000183B3A320

	// Methods
	public static uint JoystickIdToWwiseId(uint joyStickID) => default; // 0x00000001842B1EC4-0x00000001842B1F0C
	public static Vector3 ConvertAkVector64ToAkVector(AkVector64 in_) => default; // 0x00000001842AE8E0-0x00000001842AE95C
	public static AkTransform ConvertAkWorldTransformToAkTransform(AkWorldTransform in_) => default; // 0x00000001842AE9D8-0x00000001842AEA54
	public static AkVector64 ConvertAkVectorToAkVector64(Vector3 in_) => default; // 0x00000001842AE95C-0x00000001842AE9D8
	public static AkWorldTransform ConvertAkTransformToAkWorldTransform(AkTransform in_) => default; // 0x00000001842AE864-0x00000001842AE8E0
	public static bool IsBankCodecID(uint in_codecID) => default; // 0x00000001842B1E20-0x00000001842B1E68
	public static uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) => default; // 0x00000001842AED14-0x00000001842AEDEC
	public static uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001842AEDEC-0x00000001842AEEBC
	public static uint DynamicSequenceOpen(ulong in_gameObjectID) => default; // 0x00000001842AEF48-0x00000001842AEFB0
	public static AKRESULT DynamicSequenceClose(uint in_playingID) => default; // 0x00000001842AEAE8-0x00000001842AEB30
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842AF1AC-0x00000001842AF208
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration) => default; // 0x00000001842AF208-0x00000001842AF260
	public static AKRESULT DynamicSequencePlay(uint in_playingID) => default; // 0x00000001842AF260-0x00000001842AF2A8
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842AF0F8-0x00000001842AF154
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration) => default; // 0x00000001842AF154-0x00000001842AF1AC
	public static AKRESULT DynamicSequencePause(uint in_playingID) => default; // 0x00000001842AF0B0-0x00000001842AF0F8
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842AF348-0x00000001842AF3A4
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration) => default; // 0x00000001842AF2A8-0x00000001842AF300
	public static AKRESULT DynamicSequenceResume(uint in_playingID) => default; // 0x00000001842AF300-0x00000001842AF348
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842AF3A4-0x00000001842AF400
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration) => default; // 0x00000001842AF400-0x00000001842AF458
	public static AKRESULT DynamicSequenceStop(uint in_playingID) => default; // 0x00000001842AF458-0x00000001842AF4A0
	public static AKRESULT DynamicSequenceBreak(uint in_playingID) => default; // 0x00000001842AEAA0-0x00000001842AEAE8
	public static AKRESULT Seek(uint in_playingID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001842B7AC8-0x00000001842B7B24
	public static AKRESULT Seek(uint in_playingID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001842B7B24-0x00000001842B7B84
	public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration) {
		out_uTime = default;
		out_uDuration = default;
		return default;
	} // 0x00000001842AEB30-0x00000001842AEB90
	public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID) => default; // 0x00000001842AEB90-0x00000001842AEC1C
	public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID) => default; // 0x00000001842AF4A0-0x00000001842AF4E8
	public static bool IsInitialized() => default; // 0x00000001826903F0-0x0000000182690440
	public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings) => default; // 0x00000001842AFF24-0x00000001842AFF78
	public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput) => default; // 0x00000001842B1714-0x00000001842B1784
	public static AkChannelConfig GetSpeakerConfiguration() => default; // 0x0000000182690190-0x0000000182690210
	public static AKRESULT GetOutputDeviceConfiguration(ulong in_idOutput, AkChannelConfig io_channelConfig, Ak3DAudioSinkCapabilities io_capabilities) => default; // 0x00000001842B0C20-0x00000001842B0CA4
	public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput) {
		out_ePanningRule = default;
		return default;
	} // 0x00000001842B0DA0-0x00000001842B0DFC
	public static AKRESULT GetPanningRule(out int out_ePanningRule) {
		out_ePanningRule = default;
		return default;
	} // 0x00000001842B0D54-0x00000001842B0DA0
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput) => default; // 0x00000001842B9BB0-0x00000001842B9C08
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule) => default; // 0x00000001842B9B68-0x00000001842B9BB0
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput) {
		out_fHeightAngle = default;
		return default;
	} // 0x00000001842B1640-0x00000001842B16B4
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle) {
		out_fHeightAngle = default;
		return default;
	} // 0x00000001842B16B4-0x00000001842B1714
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput) => default; // 0x00000001842BAA5C-0x00000001842BAAD0
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle) => default; // 0x00000001842BAAD0-0x00000001842BAB30
	public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB) => default; // 0x00000001842BAD54-0x00000001842BADA4
	public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices) => default; // 0x00000001842B8E00-0x00000001842B8E4C
	public static AKRESULT SetJobMgrMaxActiveWorkers(uint in_jobType, uint in_uNewMaxActiveWorkers) => default; // 0x00000001842B8A44-0x00000001842B8A9C
	public static AKRESULT RenderAudio(bool in_bAllowSyncRender) => default; // 0x00000001842B5FB8-0x00000001842B6004
	public static AKRESULT RenderAudio() => default; // 0x000000018269BCD0-0x000000018269BD20
	public static AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath) => default; // 0x00000001842B5AB0-0x00000001842B5B0C
	public static AKRESULT RegisterPluginDLL(string in_DllName) => default; // 0x00000001842B5B0C-0x00000001842B5B58
	public static bool IsPluginRegistered(AkPluginType in_eType, uint in_ulCompanyID, uint in_ulPluginID) => default; // 0x00000001842B1E68-0x00000001842B1EC4
	public static uint GetIDFromString(string in_pszString) => default; // 0x00000001835940E0-0x0000000183594130
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) => default; // 0x00000001842B2DA4-0x00000001842B2EC8
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x0000000182950580-0x00000001829506D0
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x000000018269E1D0-0x000000018269E2E0
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID) => default; // 0x00000001842B3124-0x00000001842B3198
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) => default; // 0x00000001842B38D4-0x00000001842B39F8
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x00000001842B3014-0x00000001842B3124
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001842B36FC-0x00000001842B37D8
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID) => default; // 0x00000001842B3418-0x00000001842B3490
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) => default; // 0x00000001842AF9D0-0x00000001842AFA50
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842AF79C-0x00000001842AF814
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration) => default; // 0x00000001842AFD88-0x00000001842AFDF8
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID) => default; // 0x00000001842AF580-0x00000001842AF5DC
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType) => default; // 0x00000001842AFB40-0x00000001842AFB98
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) => default; // 0x00000001842AF718-0x00000001842AF79C
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842AFAC4-0x00000001842AFB40
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration) => default; // 0x00000001842AFA50-0x00000001842AFAC4
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID) => default; // 0x00000001842AF5DC-0x00000001842AF63C
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType) => default; // 0x00000001842AF6C0-0x00000001842AF718
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID) => default; // 0x00000001842B39F8-0x00000001842B3B24
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001842B3D24-0x00000001842B3E44
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets) => default; // 0x00000001842B3C74-0x00000001842B3D24
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts) => default; // 0x00000001842B3BCC-0x00000001842B3C74
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_playingID) => default; // 0x00000001842BB230-0x00000001842BB290
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID) => default; // 0x00000001842BB1D8-0x00000001842BB230
	public static AKRESULT StopMIDIOnEvent(uint in_eventID) => default; // 0x00000001842BB190-0x00000001842BB1D8
	public static AKRESULT StopMIDIOnEvent() => default; // 0x00000001842BB150-0x00000001842BB190
	public static AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority) => default; // 0x00000001842B277C-0x00000001842B27DC
	public static AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority) => default; // 0x00000001842B27DC-0x00000001842B283C
	public static AKRESULT UnpinEventInStreamCache(uint in_eventID) => default; // 0x00000001842BB9D8-0x00000001842BBA20
	public static AKRESULT UnpinEventInStreamCache(string in_pszEventName) => default; // 0x00000001842BB98C-0x00000001842BB9D8
	public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull) {
		out_fPercentBuffered = default;
		out_bCachePinnedMemoryFull = default;
		return default;
	} // 0x00000001842B0018-0x00000001842B0078
	public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull) {
		out_fPercentBuffered = default;
		out_bCachePinnedMemoryFull = default;
		return default;
	} // 0x00000001842AFFB8-0x00000001842B0018
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001842B6FC8-0x00000001842B7044
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001842B70C0-0x00000001842B7134
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition) => default; // 0x00000001842B749C-0x00000001842B74FC
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001842B7240-0x00000001842B72BC
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001842B6E80-0x00000001842B6EF4
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition) => default; // 0x00000001842B79E0-0x00000001842B7A40
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001842B76C0-0x00000001842B773C
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001842B6EF4-0x00000001842B6F68
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent) => default; // 0x00000001842B6F68-0x00000001842B6FC8
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001842B7044-0x00000001842B70C0
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001842B71CC-0x00000001842B7240
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent) => default; // 0x00000001842B78E8-0x00000001842B7948
	public static void CancelEventCallbackCookie(object in_pCookie) {} // 0x00000001842AE420-0x00000001842AE46C
	public static void CancelEventCallbackGameObject(ulong in_gameObjectID) {} // 0x00000001842AE4D4-0x00000001842AE520
	public static void CancelEventCallback(uint in_playingID) {} // 0x00000001842AE520-0x00000001842AE568
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate) {
		out_puPosition = default;
		return default;
	} // 0x00000001842B1580-0x00000001842B15E0
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition) {
		out_puPosition = default;
		return default;
	} // 0x00000001842B1528-0x00000001842B1580
	public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering) {
		out_buffering = default;
		out_bIsBuffering = default;
		return default;
	} // 0x00000001842B15E0-0x00000001842B1640
	public static void StopAll(ulong in_gameObjectID) {} // 0x0000000182AF8640-0x0000000182AF8690
	public static void StopAll() {} // 0x00000001842BAFCC-0x00000001842BB00C
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) {} // 0x00000001842BB2D0-0x00000001842BB32C
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration) {} // 0x00000001842BB32C-0x00000001842BB384
	public static void StopPlayingID(uint in_playingID) {} // 0x00000001842BB384-0x00000001842BB3CC
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) {} // 0x00000001842AFE50-0x00000001842AFEC0
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration) {} // 0x0000000182A9E740-0x0000000182A9E7B0
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID) {} // 0x00000001842AFDF8-0x00000001842AFE50
	public static void SetRandomSeed(uint in_uSeed) {} // 0x00000001842BA8E4-0x00000001842BA92C
	public static void MuteBackgroundMusic(bool in_bMute) {} // 0x00000001842B26F0-0x00000001842B273C
	public static bool GetBackgroundMusicMute() => default; // 0x00000001842AFF78-0x00000001842AFFB8
	public static AKRESULT SendPluginCustomGameData(uint in_busID, ulong in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes) => default; // 0x00000001842B7B84-0x00000001842B7C14
	public static AKRESULT UnregisterAllGameObj() => default; // 0x00000001842BBA20-0x00000001842BBA60
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags) => default; // 0x00000001842B90BC-0x00000001842B914C
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) => default; // 0x00000001832879F0-0x0000000183287A90
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions) => default; // 0x00000001842B94C8-0x00000001842B953C
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags) => default; // 0x00000001842B914C-0x00000001842B91DC
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) => default; // 0x00000001842B9250-0x00000001842B92D8
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions) => default; // 0x00000001842B91DC-0x00000001842B9250
	public static AKRESULT SetScalingFactor(ulong in_GameObjectID, float in_fAttenuationScalingFactor) => default; // 0x0000000182EA23A0-0x0000000182EA2400
	public static AKRESULT SetDistanceProbe(ulong in_listenerGameObjectID, ulong in_distanceProbeGameObjectID) => default; // 0x00000001842B8060-0x00000001842B80BC
	public static AKRESULT ClearBanks() => default; // 0x00000001842AE650-0x00000001842AE690
	public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority) => default; // 0x00000001842B7D80-0x00000001842B7DDC
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID, uint in_bankType) {
		out_bankID = default;
		return default;
	} // 0x00000001842B2550-0x00000001842B25B0
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001842B249C-0x00000001842B24F8
	public static AKRESULT LoadBank(uint in_bankID, uint in_bankType) => default; // 0x00000001842B24F8-0x00000001842B2550
	public static AKRESULT LoadBank(uint in_bankID) => default; // 0x0000000182951F10-0x0000000182951F60
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001842B2258-0x00000001842B22B8
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID, out uint out_bankType) {
		out_bankID = default;
		out_bankType = default;
		return default;
	} // 0x00000001842B21E4-0x00000001842B2258
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001842B1FB0-0x00000001842B2010
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID, out uint out_bankType) {
		out_bankID = default;
		out_bankType = default;
		return default;
	} // 0x00000001842B2010-0x00000001842B2084
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, uint in_bankType) {
		out_bankID = default;
		return default;
	} // 0x00000001842B23F8-0x00000001842B249C
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001842B235C-0x00000001842B23F8
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType) => default; // 0x000000018269FDF0-0x000000018269FEA0
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x0000000183594170-0x0000000183594210
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001842B22B8-0x00000001842B235C
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, out uint out_bankType) {
		out_bankID = default;
		out_bankType = default;
		return default;
	} // 0x00000001842B2134-0x00000001842B21E4
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) {
		out_bankID = default;
		return default;
	} // 0x00000001842B1F0C-0x00000001842B1FB0
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, out uint out_bankType) {
		out_bankID = default;
		out_bankType = default;
		return default;
	} // 0x00000001842B2084-0x00000001842B2134
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, uint in_bankType) => default; // 0x00000001842BB7D4-0x00000001842BB834
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr) => default; // 0x00000001842BB894-0x00000001842BB8F0
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, uint in_bankType) => default; // 0x00000001842BB834-0x00000001842BB894
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr) => default; // 0x00000001842BB63C-0x00000001842BB694
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType) => default; // 0x00000001842BB694-0x00000001842BB738
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001842BB8F0-0x00000001842BB98C
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType) => default; // 0x00000001826A0510-0x00000001826A05C0
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001842BB738-0x00000001842BB7D4
	public static void CancelBankCallbackCookie(object in_pCookie) {} // 0x00000001842AE3D4-0x00000001842AE420
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags, uint in_bankType) => default; // 0x00000001842B471C-0x00000001842B4790
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags) => default; // 0x00000001842B493C-0x00000001842B499C
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString) => default; // 0x00000001842B4490-0x00000001842B44E8
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags, uint in_bankType) => default; // 0x00000001842B499C-0x00000001842B4A0C
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags) => default; // 0x00000001842B4834-0x00000001842B4890
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID) => default; // 0x00000001842B46C4-0x00000001842B471C
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType) => default; // 0x00000001842B4890-0x00000001842B493C
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags) => default; // 0x00000001842B4790-0x00000001842B4834
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001842B44E8-0x00000001842B4584
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType) => default; // 0x00000001842B4584-0x00000001842B462C
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags) => default; // 0x00000001842B43F0-0x00000001842B4490
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001842B462C-0x00000001842B46C4
	public static AKRESULT ClearPreparedEvents() => default; // 0x00000001842AE824-0x00000001842AE864
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent) => default; // 0x00000001842B4CC0-0x00000001842B4ED0
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent) => default; // 0x00000001842B4A0C-0x00000001842B4A6C
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001842B4A6C-0x00000001842B4CC0
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x000000018269FD40-0x000000018269FDF0
	public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings) => default; // 0x00000001842B8E4C-0x00000001842B8EB8
	public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings) => default; // 0x00000001842BBCA4-0x00000001842BBD10
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs) => default; // 0x00000001842B4F48-0x00000001842B5174
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs) => default; // 0x00000001842B4ED0-0x00000001842B4F48
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001842B5234-0x00000001842B549C
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) => default; // 0x00000001842B5174-0x00000001842B5234
	public static AKRESULT AddListener(ulong in_emitterGameObj, ulong in_listenerGameObj) => default; // 0x00000001842ADF50-0x00000001842ADFAC
	public static AKRESULT RemoveListener(ulong in_emitterGameObj, ulong in_listenerGameObj) => default; // 0x00000001842B5E78-0x00000001842B5ED4
	public static AKRESULT AddDefaultListener(ulong in_listenerGameObj) => default; // 0x00000001842ADF04-0x00000001842ADF50
	public static AKRESULT RemoveDefaultListener(ulong in_listenerGameObj) => default; // 0x00000001842B5BC0-0x00000001842B5C0C
	public static AKRESULT ResetListenersToDefault(ulong in_emitterGameObj) => default; // 0x00000001842B6144-0x00000001842B6190
	public static AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets) => default; // 0x00000001842B8B10-0x00000001842B8B90
	public static AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig) => default; // 0x00000001842B8A9C-0x00000001842B8B10
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842BA224-0x00000001842BA2AC
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842BA148-0x00000001842BA1C4
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration) => default; // 0x0000000182830B70-0x0000000182830C00
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID) => default; // 0x00000001842BA1C4-0x00000001842BA224
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value) => default; // 0x00000001842BA6E0-0x00000001842BA738
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842BA0BC-0x00000001842BA148
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842BA320-0x00000001842BA39C
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001842BA2AC-0x00000001842BA320
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID) => default; // 0x00000001842BA680-0x00000001842BA6E0
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value) => default; // 0x00000001842BA888-0x00000001842BA8E4
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842B9D8C-0x00000001842B9E14
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842B9EA0-0x00000001842B9F1C
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration) => default; // 0x0000000182A36110-0x0000000182A361A0
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID) => default; // 0x00000001842B9CCC-0x00000001842B9D2C
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842B9E14-0x00000001842B9EA0
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842B9F1C-0x00000001842B9F98
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration) => default; // 0x00000001842B9F98-0x00000001842BA00C
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID) => default; // 0x00000001842B9D2C-0x00000001842B9D8C
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842B6A30-0x00000001842B6AAC
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842B6974-0x00000001842B69E8
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001842B6758-0x00000001842B67B8
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID) => default; // 0x00000001842B691C-0x00000001842B6974
	public static AKRESULT ResetRTPCValue(uint in_rtpcID) => default; // 0x00000001842B69E8-0x00000001842B6A30
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842B67B8-0x00000001842B6834
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842B6834-0x00000001842B68A8
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001842B64D4-0x00000001842B6534
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID) => default; // 0x00000001842B6CD0-0x00000001842B6D2C
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName) => default; // 0x00000001842B6BEC-0x00000001842B6C38
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842B62B8-0x00000001842B6330
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842B6190-0x00000001842B6200
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration) => default; // 0x00000001842B6388-0x00000001842B63E4
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID) => default; // 0x00000001842B6200-0x00000001842B6258
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842B63E4-0x00000001842B6460
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842B6460-0x00000001842B64D4
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration) => default; // 0x00000001842B6258-0x00000001842B62B8
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID) => default; // 0x00000001842B6330-0x00000001842B6388
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, ulong in_gameObjectID) => default; // 0x00000001842BAB8C-0x00000001842BABE8
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, ulong in_gameObjectID) => default; // 0x00000001842BAC70-0x00000001842BACD0
	public static AKRESULT PostTrigger(uint in_triggerID, ulong in_gameObjectID) => default; // 0x00000001842B4398-0x00000001842B43F0
	public static AKRESULT PostTrigger(string in_pszTrigger, ulong in_gameObjectID) => default; // 0x00000001842B4250-0x00000001842B42AC
	public static AKRESULT SetState(uint in_stateGroup, uint in_state) => default; // 0x00000001832322E0-0x0000000183232340
	public static AKRESULT SetState(string in_pszStateGroup, string in_pszState) => default; // 0x00000001842BAB30-0x00000001842BAB8C
	public static AKRESULT SetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues) => default; // 0x00000001842B837C-0x00000001842B83EC
	public static AKRESULT SetGameObjectOutputBusVolume(ulong in_emitterObjID, ulong in_listenerObjID, float in_fControlValue) => default; // 0x00000001842B8554-0x00000001842B85B4
	public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID) => default; // 0x00000001842B7CC8-0x00000001842B7D24
	public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID) => default; // 0x00000001842B7FA4-0x00000001842B8000
	public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID) => default; // 0x00000001842B8000-0x00000001842B8060
	public static AKRESULT SetOutputDeviceEffect(ulong in_outputDeviceID, uint in_uFXIndex, uint in_FXShareSetID) => default; // 0x00000001842B9AAC-0x00000001842B9B0C
	public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID) => default; // 0x00000001842B8EB8-0x00000001842B8F10
	public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID) => default; // 0x00000001842B8F10-0x00000001842B8F68
	public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig) => default; // 0x00000001842B7E8C-0x00000001842B7EF0
	public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig) => default; // 0x00000001842B7E28-0x00000001842B7E8C
	public static AKRESULT SetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel) => default; // 0x00000001842B967C-0x00000001842B96F0
	public static AKRESULT SetMultipleObstructionAndOcclusion(ulong in_EmitterID, ulong in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction) => default; // 0x00000001842B8F68-0x00000001842B8FF8
	public static AKRESULT StartOutputCapture(string in_CaptureFileName) => default; // 0x00000001842BADF0-0x00000001842BAE3C
	public static AKRESULT StopOutputCapture() => default; // 0x00000001842BB290-0x00000001842BB2D0
	public static AKRESULT AddOutputCaptureMarker(string in_MarkerText) => default; // 0x00000001842AE088-0x00000001842AE0D4
	public static AKRESULT AddOutputCaptureBinaryMarker(IntPtr in_pMarkerData, uint in_uMarkerDataSize) => default; // 0x00000001842AE030-0x00000001842AE088
	public static uint GetSampleRate() => default; // 0x00000001842B13A8-0x00000001842B13E8
	public static AKRESULT StartProfilerCapture(string in_CaptureFileName) => default; // 0x00000001842BAE7C-0x00000001842BAEC8
	public static AKRESULT StopProfilerCapture() => default; // 0x00000001842BB40C-0x00000001842BB44C
	public static AKRESULT SetOfflineRenderingFrameTime(float in_fFrameTimeInSeconds) => default; // 0x00000001842B9A10-0x00000001842B9A60
	public static AKRESULT SetOfflineRendering(bool in_bEnableOfflineRendering) => default; // 0x00000001842B9A60-0x00000001842B9AAC
	public static AKRESULT RemoveOutput(ulong in_idOutput) => default; // 0x00000001842B5ED4-0x00000001842B5F20
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, out ulong out_pOutputDeviceId) {
		out_pOutputDeviceId = default;
		return default;
	} // 0x00000001842B6068-0x00000001842B60DC
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId) => default; // 0x00000001842B6004-0x00000001842B6068
	public static ulong GetOutputID(uint in_idShareset, uint in_idDevice) => default; // 0x00000001842B0CA4-0x00000001842B0CFC
	public static ulong GetOutputID(string in_szShareSet, uint in_idDevice) => default; // 0x00000001842B0CFC-0x00000001842B0D54
	public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice) => default; // 0x00000001842B7F4C-0x00000001842B7FA4
	public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName) => default; // 0x00000001842B7EF0-0x00000001842B7F4C
	public static AKRESULT GetDeviceList(uint in_ulCompanyID, uint in_ulPluginID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) {
		io_maxNumDevices = default;
		return default;
	} // 0x00000001842B0420-0x00000001842B04AC
	public static AKRESULT GetDeviceList(uint in_audioDeviceShareSetID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) {
		io_maxNumDevices = default;
		return default;
	} // 0x00000001836181C0-0x0000000183618250
	public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume) => default; // 0x00000001842B9B0C-0x00000001842B9B68
	public static AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice) => default; // 0x00000001836180A0-0x00000001836180F0
	public static AKRESULT Suspend(bool in_bRenderAnyway, bool in_bFadeOut) => default; // 0x00000001842BB560-0x00000001842BB5BC
	public static AKRESULT Suspend(bool in_bRenderAnyway) => default; // 0x00000001842BB4D4-0x00000001842BB520
	public static AKRESULT Suspend() => default; // 0x00000001842BB520-0x00000001842BB560
	public static AKRESULT WakeupFromSuspend(uint in_uDelayMs) => default; // 0x00000001842BBD5C-0x00000001842BBDA4
	public static AKRESULT WakeupFromSuspend() => default; // 0x00000001842BBDA4-0x00000001842BBDE4
	public static uint GetBufferTick() => default; // 0x00000001842B0078-0x00000001842B00B8
	public static ulong GetSampleTick() => default; // 0x00000001842B13E8-0x00000001842B1428
	public static void AkMemGetCategoryStats(int in_poolId, AkMemCategroyStats out_poolStats) {} // 0x00000001842AE2D4-0x00000001842AE338
	public static void AkMemGetGlobalStats(AkMemGlobalStats out_stats) {} // 0x00000001842AE338-0x00000001842AE38C
	public static void StartProfileThreadUsage() {} // 0x00000001842BAE3C-0x00000001842BAE7C
	public static ulong StopProfileThreadUsage() => default; // 0x00000001842BB3CC-0x00000001842BB40C
	public static void DumpToFile(string pszFilename) {} // 0x00000001842AEA54-0x00000001842AEAA0
	public static ulong GetGlobalUsed() => default; // 0x00000001842B07E4-0x00000001842B0824
	public static ulong GetGlobalReserved() => default; // 0x00000001842B07A4-0x00000001842B07E4
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate) => default; // 0x00000001842B0EE4-0x00000001842B0F58
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo) => default; // 0x00000001842B0F58-0x00000001842B0FBC
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus) => default; // 0x00000001842B2C28-0x00000001842B2CA8
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID) => default; // 0x00000001842B2A54-0x00000001842B2ACC
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID) => default; // 0x00000001842B28AC-0x00000001842B291C
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID) => default; // 0x00000001842B2B74-0x00000001842B2BD0
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel) => default; // 0x00000001842B2BD0-0x00000001842B2C28
	public static AKRESULT PostCodeVarArg(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, MsgContext msgContext) => default; // 0x00000001842B283C-0x00000001842B28AC
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus) => default; // 0x00000001842B4060-0x00000001842B40E4
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID) => default; // 0x00000001842B3E44-0x00000001842B3EC0
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID) => default; // 0x00000001842B413C-0x00000001842B41B0
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID) => default; // 0x00000001842B4000-0x00000001842B4060
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel) => default; // 0x00000001842B40E4-0x00000001842B413C
	public static AKRESULT ResetTranslator() => default; // 0x00000001842B6D6C-0x00000001842B6DAC
	public static int GetTimeStamp() => default; // 0x00000001842B1A44-0x00000001842B1A84
	public static void MonitorStreamMgrInit(AkStreamMgrSettings in_streamMgrSettings) {} // 0x00000001842B25B0-0x00000001842B2604
	public static void MonitorStreamingDeviceInit(uint in_deviceID, AkDeviceSettings in_deviceSettings) {} // 0x00000001842B268C-0x00000001842B26F0
	public static void MonitorStreamingDeviceDestroyed(uint in_deviceID) {} // 0x00000001842B2644-0x00000001842B268C
	public static void MonitorStreamMgrTerm() {} // 0x00000001842B2604-0x00000001842B2644
	public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties) {} // 0x00000001842AE280-0x00000001842AE2D4
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence) => default; // 0x00000001842B6DAC-0x00000001842B6E20
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments) => default; // 0x00000001842B6E20-0x00000001842B6E80
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue) {
		out_iValue = default;
		return default;
	} // 0x00000001842B0508-0x00000001842B0564
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue) {
		out_fValue = default;
		return default;
	} // 0x00000001842B04AC-0x00000001842B0508
	public static AKRESULT GetPosition(ulong in_GameObjectID, AkWorldTransform out_rPosition) => default; // 0x00000001842B0FBC-0x00000001842B1020
	public static AKRESULT GetListenerPosition(ulong in_uListenerID, AkWorldTransform out_rPosition) => default; // 0x00000001842B08D8-0x00000001842B093C
	public static AKRESULT GetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) {
		out_rValue = default;
		return default;
	} // 0x00000001842B11B4-0x00000001842B1230
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) {
		out_rValue = default;
		return default;
	} // 0x00000001842B12D4-0x00000001842B1354
	public static AKRESULT GetSwitch(uint in_switchGroup, ulong in_gameObjectID, out uint out_rSwitchState) {
		out_rSwitchState = default;
		return default;
	} // 0x00000001842B1878-0x00000001842B18D8
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, ulong in_GameObj, out uint out_rSwitchState) {
		out_rSwitchState = default;
		return default;
	} // 0x00000001842B19E4-0x00000001842B1A44
	public static AKRESULT GetState(uint in_stateGroup, out uint out_rState) {
		out_rState = default;
		return default;
	} // 0x00000001842B17E0-0x00000001842B1838
	public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState) {
		out_rState = default;
		return default;
	} // 0x00000001842B1784-0x00000001842B17E0
	public static AKRESULT GetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues) => default; // 0x00000001842B05F8-0x00000001842B0668
	public static AKRESULT GetGameObjectDryLevelValue(ulong in_EmitterID, ulong in_ListenerID, out float out_rfControlValue) {
		out_rfControlValue = default;
		return default;
	} // 0x00000001842B0668-0x00000001842B06C8
	public static AKRESULT GetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel) {
		out_rfObstructionLevel = default;
		out_rfOcclusionLevel = default;
		return default;
	} // 0x00000001842B0B04-0x00000001842B0B78
	public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos) => default; // 0x00000001842B5518-0x00000001842B5594
	public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos) => default; // 0x00000001842B549C-0x00000001842B5518
	public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo) => default; // 0x00000001842B10AC-0x00000001842B1110
	public static bool GetIsGameObjectActive(ulong in_GameObjId) => default; // 0x00000001842B088C-0x00000001842B08D8
	public static float GetMaxRadius(ulong in_GameObjId) => default; // 0x00000001842B0AB8-0x00000001842B0B04
	public static uint GetEventIDFromPlayingID(uint in_playingID) => default; // 0x0000000182A9EFC0-0x0000000182A9F010
	public static ulong GetGameObjectFromPlayingID(uint in_playingID) => default; // 0x00000001842B075C-0x00000001842B07A4
	public static AKRESULT GetPlayingIDsFromGameObject(ulong in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs) => default; // 0x00000001842B0E84-0x00000001842B0EE4
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue) {
		out_iValue = default;
		return default;
	} // 0x00000001842B0178-0x00000001842B01D4
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue) {
		out_fValue = default;
		return default;
	} // 0x00000001842B01D4-0x00000001842B0230
	public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask) {} // 0x00000001842ADE04-0x00000001842ADE50
	public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask) {} // 0x00000001842ADE50-0x00000001842ADE9C
	public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask) {} // 0x00000001842ADDB8-0x00000001842ADE04
	public static byte ChannelMaskToNumChannels(uint in_uChannelMask) => default; // 0x00000001842AE608-0x00000001842AE650
	public static uint ChannelMaskFromNumChannels(uint in_uNumChannels) => default; // 0x00000001842AE5C0-0x00000001842AE608
	public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask) => default; // 0x00000001842AE568-0x00000001842AE5C0
	public static bool HasSurroundChannels(uint in_uChannelMask) => default; // 0x00000001842B1CDC-0x00000001842B1D24
	public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask) => default; // 0x00000001842B1C94-0x00000001842B1CDC
	public static bool HasSideAndRearChannels(uint in_uChannelMask) => default; // 0x00000001842B1C4C-0x00000001842B1C94
	public static bool HasHeightChannels(uint in_uChannelMask) => default; // 0x00000001842B1C04-0x00000001842B1C4C
	public static uint BackToSideChannels(uint in_uChannelMask) => default; // 0x00000001842AE38C-0x00000001842AE3D4
	public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx) => default; // 0x00000001842BAF08-0x00000001842BAF64
	public static AKRESULT SetGameObjectRadius(ulong in_gameObjectID, float in_outerRadius, float in_innerRadius) => default; // 0x00000001842B85B4-0x00000001842B8618
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID, ulong in_gameObjectID) => default; // 0x00000001842B89BC-0x00000001842B8A44
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID) => default; // 0x00000001842B893C-0x00000001842B89BC
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name) => default; // 0x00000001842B88C8-0x00000001842B893C
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, ulong in_gameObjectID) => default; // 0x00000001842B5D98-0x00000001842B5DF4
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID) => default; // 0x00000001842B5C74-0x00000001842B5CCC
	public static AKRESULT RemoveImageSource(uint in_srcID) => default; // 0x00000001842B5D50-0x00000001842B5D98
	public static AKRESULT ClearImageSources(uint in_AuxBusID, ulong in_gameObjectID) => default; // 0x00000001842AE744-0x00000001842AE79C
	public static AKRESULT ClearImageSources(uint in_AuxBusID) => default; // 0x00000001842AE79C-0x00000001842AE7E4
	public static AKRESULT ClearImageSources() => default; // 0x00000001842AE7E4-0x00000001842AE824
	public static AKRESULT RemoveGeometry(ulong in_SetID) => default; // 0x00000001831AE720-0x00000001831AE770
	public static AKRESULT RemoveGeometryInstance(ulong in_GeometryInstanceID) => default; // 0x0000000182AF6AF0-0x0000000182AF6B40
	public static AKRESULT RemoveRoom(ulong in_RoomID) => default; // 0x0000000182AF6A10-0x0000000182AF6A60
	public static AKRESULT RemovePortal(ulong in_PortalID) => default; // 0x00000001842B5F20-0x00000001842B5F6C
	public static AKRESULT SetReverbZone(ulong in_ReverbZone, ulong in_ParentRoom, float in_transitionRegionWidth) => default; // 0x00000001831AD7E0-0x00000001831AD850
	public static AKRESULT RemoveReverbZone(ulong in_ReverbZone) => default; // 0x00000001842B5F6C-0x00000001842B5FB8
	public static AKRESULT SetGameObjectInRoom(ulong in_gameObjectID, ulong in_CurrentRoomID) => default; // 0x00000001842B83EC-0x00000001842B8448
	public static AKRESULT UnsetGameObjectInRoom(ulong in_gameObjectID) => default; // 0x00000001842BBC58-0x00000001842BBCA4
	public static AKRESULT SetReflectionsOrder(uint in_uReflectionsOrder, bool in_bUpdatePaths) => default; // 0x0000000182A02000-0x0000000182A02060
	public static AKRESULT SetDiffractionOrder(uint in_uDiffractionOrder, bool in_bUpdatePaths) => default; // 0x0000000182A02060-0x0000000182A020C0
	public static AKRESULT SetMaxEmitterRoomAuxSends(uint in_uMaxEmitterRoomAuxSends) => default; // 0x00000001842B8DB8-0x00000001842B8E00
	public static AKRESULT SetNumberOfPrimaryRays(uint in_uNbPrimaryRays) => default; // 0x0000000182A039D0-0x0000000182A03A20
	public static AKRESULT SetLoadBalancingSpread(uint in_uNbFrames) => default; // 0x0000000182A03940-0x0000000182A03990
	public static AKRESULT SetEarlyReflectionsAuxSend(ulong in_gameObjectID, uint in_auxBusID) => default; // 0x00000001842B80BC-0x00000001842B8114
	public static AKRESULT SetEarlyReflectionsVolume(ulong in_gameObjectID, float in_fSendVolume) => default; // 0x00000001842B8188-0x00000001842B81E4
	public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion) => default; // 0x00000001842B9C08-0x00000001842B9C6C
	public static AKRESULT SetGameObjectToPortalObstruction(ulong in_gameObjectID, ulong in_PortalID, float in_fObstruction) => default; // 0x00000001842B8618-0x00000001842B8678
	public static AKRESULT SetPortalToPortalObstruction(ulong in_PortalID0, ulong in_PortalID1, float in_fObstruction) => default; // 0x00000001842B9C6C-0x00000001842B9CCC
	public static AKRESULT QueryWetDiffraction(ulong in_portal, out float out_wetDiffraction) {
		out_wetDiffraction = default;
		return default;
	} // 0x00000001842B5894-0x00000001842B58F0
	public static AKRESULT ResetStochasticEngine() => default; // 0x00000001842B6D2C-0x00000001842B6D6C
	public static uint GetDeviceIDFromName(string in_szToken) => default; // 0x00000001842B03D4-0x00000001842B0420
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID, AkAudioDeviceState uDeviceStateMask) {
		out_uDeviceID = default;
		return default;
	} // 0x00000001842B1B80-0x00000001842B1C04
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID) {
		out_uDeviceID = default;
		return default;
	} // 0x00000001842B1B0C-0x00000001842B1B80
	public static uint GetWindowsDeviceCount(AkAudioDeviceState uDeviceStateMask) => default; // 0x00000001842B1A84-0x00000001842B1ACC
	public static uint GetWindowsDeviceCount() => default; // 0x00000001842B1ACC-0x00000001842B1B0C
	public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger) {} // 0x00000001839C5A70-0x00000001839C5AC0
	public static void SetErrorLogger() {} // 0x00000001842B825C-0x00000001842B829C
	public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat) {} // 0x00000001842B7D24-0x00000001842B7D80
	public static AKRESULT Init(AkInitializationSettings settings) => default; // 0x0000000182A01EC0-0x0000000182A01F20
	public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings) => default; // 0x0000000182A01F60-0x0000000182A01FC0
	public static AKRESULT InitCommunication(AkCommunicationSettings settings) => default; // 0x00000001842B1D64-0x00000001842B1DB8
	public static void Term() {} // 0x00000001842BB5BC-0x00000001842BB5FC
	public static AKRESULT RegisterGameObjInternal(ulong in_GameObj) => default; // 0x0000000182761270-0x00000001827612C0
	public static AKRESULT UnregisterGameObjInternal(ulong in_GameObj) => default; // 0x0000000182AF8730-0x0000000182AF8780
	public static AKRESULT RegisterGameObjInternal_WithName(ulong in_GameObj, string in_pszObjName) => default; // 0x00000001831ADF30-0x00000001831ADF90
	public static AKRESULT SetBasePath(string in_pszBasePath) => default; // 0x00000001842B7DDC-0x00000001842B7E28
	public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath) => default; // 0x0000000182951D00-0x0000000182951D50
	public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID) {
		out_uPackageID = default;
		return default;
	} // 0x0000000182CB3A10-0x0000000182CB3A70
	public static AKRESULT AddBasePath(string in_pszBasePath) => default; // 0x00000001837084C0-0x0000000183708510
	public static AKRESULT SetGameName(string in_GameName) => default; // 0x00000001842B829C-0x00000001842B82E8
	public static string GetCurrentLanguage() => default; // 0x00000001842B0118-0x00000001842B0178
	public static AKRESULT UnloadFilePackage(uint in_uPackageID) => default; // 0x0000000182CB41E0-0x0000000182CB4230
	public static AKRESULT UnloadAllFilePackages() => default; // 0x00000001842BB5FC-0x00000001842BB63C
	public static AKRESULT SetObjectPosition(ulong in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top) => default; // 0x00000001828BB3F0-0x00000001828BB4D0
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate) => default; // 0x00000001842B14A4-0x00000001842B1528
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions) => default; // 0x00000001842B1428-0x00000001842B14A4
	public static AKRESULT SetListeners(ulong in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners) => default; // 0x00000001842B8D58-0x00000001842B8DB8
	public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners) => default; // 0x00000001826BD090-0x00000001826BD0F0
	public static uint GetNumOutputDevices(uint in_AudioDeviceShareSetID) => default; // 0x0000000183618010-0x0000000183618060
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners) {
		out_pDeviceID = default;
		return default;
	} // 0x00000001842AE0D4-0x00000001842AE154
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs) {
		out_pDeviceID = default;
		return default;
	} // 0x00000001842AE1A8-0x00000001842AE21C
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID) {
		out_pDeviceID = default;
		return default;
	} // 0x00000001842AE21C-0x00000001842AE280
	public static AKRESULT AddOutput(AkOutputSettings in_Settings) => default; // 0x00000001842AE154-0x00000001842AE1A8
	public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings) {} // 0x00000001842B0380-0x00000001842B03D4
	public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings) {} // 0x00000001842B0230-0x00000001842B0284
	public static void GetDefaultMusicSettings(AkMusicSettings out_settings) {} // 0x00000001842B02D8-0x00000001842B032C
	public static void GetDefaultInitSettings(AkInitSettings out_settings) {} // 0x00000001842B0284-0x00000001842B02D8
	public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings) {} // 0x00000001842B032C-0x00000001842B0380
	public static uint GetMajorMinorVersion() => default; // 0x00000001842B0A10-0x00000001842B0A50
	public static uint GetSubminorBuildVersion() => default; // 0x00000001842B1838-0x00000001842B1878
	public static void StartResourceMonitoring() {} // 0x00000001842BAEC8-0x00000001842BAF08
	public static void StopResourceMonitoring() {} // 0x00000001842BB44C-0x00000001842BB48C
	public static void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary) {} // 0x00000001842B1354-0x00000001842B13A8
	public static void StartDeviceCapture(ulong in_idOutputDeviceID) {} // 0x00000001842BADA4-0x00000001842BADF0
	public static void StopDeviceCapture(ulong in_idOutputDeviceID) {} // 0x00000001842BB00C-0x00000001842BB058
	public static void ClearCaptureData() {} // 0x00000001842AE690-0x00000001842AE6D0
	public static uint UpdateCaptureSampleCount(ulong in_idOutputDeviceID) => default; // 0x00000001842BBD10-0x00000001842BBD5C
	public static uint GetCaptureSamples(ulong in_idOutputDeviceID, float[] out_pSamples, uint in_uBufferSize) => default; // 0x00000001842B00B8-0x00000001842B0118
	public static AKRESULT SetRoomPortal(ulong in_PortalID, ulong FrontRoom, ulong BackRoom, AkTransform Transform, AkExtent Extent, bool bEnabled, string in_pName) => default; // 0x00000001842BA92C-0x00000001842BA9E4
	public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, ulong GeometryInstanceID, string in_pName) => default; // 0x00000001831ACEE0-0x00000001831ACF70
	public static AKRESULT RegisterSpatialAudioListener(ulong in_gameObjectID) => default; // 0x00000001826BD040-0x00000001826BD090
	public static AKRESULT UnregisterSpatialAudioListener(ulong in_gameObjectID) => default; // 0x00000001842BBBA4-0x00000001842BBBF0
	public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, Vector3[] Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges) => default; // 0x00000001842B8724-0x00000001842B8810
	public static AKRESULT SetGeometryInstance(ulong in_GeomInstanceID, AkTransform Transform, Vector3 Scale, ulong GeometrySetID, ulong RoomID, bool UseForReflectionAndDiffraction) => default; // 0x00000001842B8678-0x00000001842B8724
	public static AKRESULT QueryReflectionPaths(ulong in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize) {
		io_uArraySize = default;
		return default;
	} // 0x00000001842B5714-0x00000001842B57C0
	public static AKRESULT QueryDiffractionPaths(ulong in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize) {
		io_uArraySize = default;
		return default;
	} // 0x00000001842B5594-0x00000001842B5640
	public static void PerformStreamMgrIO() {} // 0x00000001842B273C-0x00000001842B277C
	public static void HgMemShrink() {} // 0x00000001842B1D24-0x00000001842B1D64
	public static ulong HgGetGlobalMemoryUsed() => default; // 0x000000018269BA50-0x000000018269BAA0
	public static ulong HgGetGlobalMemoryReserved() => default; // 0x00000001839CAFD0-0x00000001839CB020
	public static void InitScePad() {} // 0x0000000183656360-0x00000001836563A0
	public static uint GetMMDeviceIdFromPadContainerInfo(int in_padHandle) => default; // 0x00000001842B09C8-0x00000001842B0A10
	public static string StringFromIntPtrString(IntPtr ptr) => default; // 0x00000001842BB48C-0x00000001842BB4D4
	public static string StringFromIntPtrWString(IntPtr ptr) => default; // 0x0000000182A4E840-0x0000000182A4E890
	private static ulong InternalGameObjectHash(GameObject gameObject) => default; // 0x00000001842B1DB8-0x00000001842B1E20
	public static ulong GetAkGameObjectID(GameObject gameObject) => default; // 0x00000001842AFEC0-0x00000001842AFF24
	public static AKRESULT RegisterGameObj(GameObject gameObject) => default; // 0x00000001842B59D0-0x00000001842B5A38
	public static AKRESULT RegisterGameObj(GameObject gameObject, string name) => default; // 0x00000001842B5A38-0x00000001842B5AB0
	public static AKRESULT UnregisterGameObj(GameObject gameObject) => default; // 0x00000001842BBB08-0x00000001842BBBA4
	public static void UnregisterAllGameObjects() {} // 0x00000001842BBA60-0x00000001842BBAA0
	public static AKRESULT SetObjectPosition(GameObject gameObject, Transform transform) => default; // 0x00000001842B97C4-0x00000001842B98D0
	public static AKRESULT SetObjectPosition(GameObject gameObject, float posX, float posY, float posZ, float frontX, float frontY, float frontZ, float topX, float topY, float topZ) => default; // 0x00000001842B98D0-0x00000001842B9A10
	public static void PreGameObjectAPICall(GameObject gameObject, ulong id) {} // 0x000000018350B670-0x000000018350B680
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) => default; // 0x00000001842AEFB0-0x00000001842AF0B0
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001842AEC1C-0x00000001842AED14
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID) => default; // 0x00000001842AEEBC-0x00000001842AEF48
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) => default; // 0x00000001842B32D0-0x00000001842B3418
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x00000001842B3490-0x00000001842B35C4
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001842B2CA8-0x00000001842B2DA4
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID) => default; // 0x00000001842B3198-0x00000001842B3234
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) => default; // 0x00000001842B2EC8-0x00000001842B3014
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) => default; // 0x00000001842B35C4-0x00000001842B36FC
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) => default; // 0x00000001842B37D8-0x00000001842B38D4
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID) => default; // 0x00000001842B3234-0x00000001842B32D0
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) => default; // 0x00000001842AFC40-0x00000001842AFCE8
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842AF930-0x00000001842AF9D0
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration) => default; // 0x00000001842AF898-0x00000001842AF930
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID) => default; // 0x00000001842AF814-0x00000001842AF898
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) => default; // 0x00000001842AFB98-0x00000001842AFC40
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842AFCE8-0x00000001842AFD88
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration) => default; // 0x00000001842AF4E8-0x00000001842AF580
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID) => default; // 0x00000001842AF63C-0x00000001842AF6C0
	public static AKRESULT PostMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts) => default; // 0x00000001842B3B24-0x00000001842B3BCC
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID) => default; // 0x00000001842BB0DC-0x00000001842BB150
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_playingID) => default; // 0x00000001842BB058-0x00000001842BB0DC
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001842B773C-0x00000001842B77DC
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001842B7134-0x00000001842B71CC
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition) => default; // 0x00000001842B7864-0x00000001842B78E8
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001842B73F8-0x00000001842B749C
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) => default; // 0x00000001842B735C-0x00000001842B73F8
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition) => default; // 0x00000001842B77DC-0x00000001842B7864
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001842B72BC-0x00000001842B735C
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001842B7948-0x00000001842B79E0
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent) => default; // 0x00000001842B75A0-0x00000001842B7624
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) => default; // 0x00000001842B74FC-0x00000001842B75A0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) => default; // 0x00000001842B7624-0x00000001842B76C0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent) => default; // 0x00000001842B7A40-0x00000001842B7AC8
	public static void CancelEventCallbackGameObject(GameObject in_gameObjectID) {} // 0x00000001842AE46C-0x00000001842AE4D4
	public static void StopAll(GameObject in_gameObjectID) {} // 0x00000001842BAF64-0x00000001842BAFCC
	public static AKRESULT SendPluginCustomGameData(uint in_busID, GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes) => default; // 0x00000001842B7C14-0x00000001842B7CC8
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) => default; // 0x00000001842B941C-0x00000001842B94C8
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions) => default; // 0x00000001842B92D8-0x00000001842B9370
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) => default; // 0x00000001842B9370-0x00000001842B941C
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions) => default; // 0x00000001842B953C-0x00000001842B95D4
	public static AKRESULT SetScalingFactor(GameObject in_GameObjectID, float in_fAttenuationScalingFactor) => default; // 0x00000001842BA9E4-0x00000001842BAA5C
	public static AKRESULT AddListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj) => default; // 0x00000001842ADFAC-0x00000001842AE030
	public static AKRESULT RemoveListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj) => default; // 0x00000001842B5DF4-0x00000001842B5E78
	public static AKRESULT AddDefaultListener(GameObject in_listenerGameObj) => default; // 0x00000001842ADE9C-0x00000001842ADF04
	public static AKRESULT RemoveDefaultListener(GameObject in_listenerGameObj) => default; // 0x00000001842B5C0C-0x00000001842B5C74
	public static AKRESULT ResetListenersToDefault(GameObject in_emitterGameObj) => default; // 0x00000001842B60DC-0x00000001842B6144
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets) => default; // 0x00000001842B8C2C-0x00000001842B8CD0
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig) => default; // 0x00000001842B8B90-0x00000001842B8C2C
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842BA7D8-0x00000001842BA888
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842BA738-0x00000001842BA7D8
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001842BA420-0x00000001842BA4B8
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID) => default; // 0x00000001842BA39C-0x00000001842BA420
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842BA00C-0x00000001842BA0BC
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842BA4B8-0x00000001842BA55C
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001842BA5E4-0x00000001842BA680
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID) => default; // 0x00000001842BA55C-0x00000001842BA5E4
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842B6630-0x00000001842B66D0
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842B6C38-0x00000001842B6CD0
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001842B6534-0x00000001842B65B8
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID) => default; // 0x00000001842B68A8-0x00000001842B691C
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) => default; // 0x00000001842B6B48-0x00000001842B6BEC
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) => default; // 0x00000001842B6AAC-0x00000001842B6B48
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration) => default; // 0x00000001842B66D0-0x00000001842B6758
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID) => default; // 0x00000001842B65B8-0x00000001842B6630
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject in_gameObjectID) => default; // 0x00000001842BACD0-0x00000001842BAD54
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, GameObject in_gameObjectID) => default; // 0x00000001842BABE8-0x00000001842BAC70
	public static AKRESULT PostTrigger(uint in_triggerID, GameObject in_gameObjectID) => default; // 0x00000001842B42AC-0x00000001842B4320
	public static AKRESULT PostTrigger(string in_pszTrigger, GameObject in_gameObjectID) => default; // 0x00000001842B4320-0x00000001842B4398
	public static AKRESULT SetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues) => default; // 0x00000001842B82E8-0x00000001842B837C
	public static AKRESULT SetGameObjectOutputBusVolume(GameObject in_emitterObjID, GameObject in_listenerObjID, float in_fControlValue) => default; // 0x00000001842B84C0-0x00000001842B8554
	public static AKRESULT SetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel) => default; // 0x00000001842B95D4-0x00000001842B967C
	public static AKRESULT SetMultipleObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction) => default; // 0x00000001842B8FF8-0x00000001842B90BC
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus) => default; // 0x00000001842B2ACC-0x00000001842B2B74
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID) => default; // 0x00000001842B291C-0x00000001842B29BC
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID) => default; // 0x00000001842B29BC-0x00000001842B2A54
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus) => default; // 0x00000001842B3F58-0x00000001842B4000
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID) => default; // 0x00000001842B41B0-0x00000001842B4250
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID) => default; // 0x00000001842B3EC0-0x00000001842B3F58
	public static AKRESULT GetPosition(GameObject in_GameObjectID, AkTransform out_rPosition) => default; // 0x00000001842B1020-0x00000001842B10AC
	public static AKRESULT GetListenerPosition(GameObject in_uIndex, AkTransform out_rPosition) => default; // 0x00000001842B093C-0x00000001842B09C8
	public static AKRESULT GetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) {
		out_rValue = default;
		return default;
	} // 0x00000001842B1230-0x00000001842B12D4
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) {
		out_rValue = default;
		return default;
	} // 0x00000001842B1110-0x00000001842B11B4
	public static AKRESULT GetSwitch(uint in_switchGroup, GameObject in_gameObjectID, out uint out_rSwitchState) {
		out_rSwitchState = default;
		return default;
	} // 0x00000001842B18D8-0x00000001842B195C
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, GameObject in_GameObj, out uint out_rSwitchState) {
		out_rSwitchState = default;
		return default;
	} // 0x00000001842B195C-0x00000001842B19E4
	public static AKRESULT GetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues) => default; // 0x00000001842B0564-0x00000001842B05F8
	public static AKRESULT GetGameObjectDryLevelValue(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfControlValue) {
		out_rfControlValue = default;
		return default;
	} // 0x00000001842B06C8-0x00000001842B075C
	public static AKRESULT GetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel) {
		out_rfObstructionLevel = default;
		out_rfOcclusionLevel = default;
		return default;
	} // 0x00000001842B0B78-0x00000001842B0C20
	public static bool GetIsGameObjectActive(GameObject in_GameObjId) => default; // 0x00000001842B0824-0x00000001842B088C
	public static float GetMaxRadius(GameObject in_GameObjId) => default; // 0x00000001842B0A50-0x00000001842B0AB8
	public static AKRESULT GetPlayingIDsFromGameObject(GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs) => default; // 0x00000001842B0DFC-0x00000001842B0E84
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_imageSourceName, uint in_AuxBusID, GameObject in_gameObjectID) => default; // 0x00000001842B8810-0x00000001842B88C8
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, GameObject in_gameObjectID) => default; // 0x00000001842B5CCC-0x00000001842B5D50
	public static AKRESULT ClearImageSources(uint in_AuxBusID, GameObject in_gameObjectID) => default; // 0x00000001842AE6D0-0x00000001842AE744
	public static AKRESULT QueryReflectionPaths(GameObject in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize) {
		io_uArraySize = default;
		return default;
	} // 0x00000001842B57C0-0x00000001842B5894
	public static AKRESULT SetGameObjectInRoom(GameObject in_gameObjectID, ulong in_CurrentRoomID) => default; // 0x00000001842B8448-0x00000001842B84C0
	public static AKRESULT SetEarlyReflectionsAuxSend(GameObject in_gameObjectID, uint in_auxBusID) => default; // 0x00000001842B8114-0x00000001842B8188
	public static AKRESULT SetEarlyReflectionsVolume(GameObject in_gameObjectID, float in_fSendVolume) => default; // 0x00000001842B81E4-0x00000001842B825C
	public static AKRESULT QueryDiffractionPaths(GameObject in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize) {
		io_uArraySize = default;
		return default;
	} // 0x00000001842B5640-0x00000001842B5714
	public static AKRESULT RegisterGameObjInternal(GameObject in_GameObj) => default; // 0x00000001842B5968-0x00000001842B59D0
	public static AKRESULT UnregisterGameObjInternal(GameObject in_GameObj) => default; // 0x00000001842BBAA0-0x00000001842BBB08
	public static AKRESULT RegisterGameObjInternal_WithName(GameObject in_GameObj, string in_pszObjName) => default; // 0x00000001842B58F0-0x00000001842B5968
	public static AKRESULT SetObjectPosition(GameObject in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top) => default; // 0x00000001842B96F0-0x00000001842B97C4
	public static AKRESULT SetListeners(GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners) => default; // 0x00000001842B8CD0-0x00000001842B8D58
	public static AKRESULT RegisterSpatialAudioListener(GameObject in_gameObjectID) => default; // 0x00000001842B5B58-0x00000001842B5BC0
	public static AKRESULT UnregisterSpatialAudioListener(GameObject in_gameObjectID) => default; // 0x00000001842BBBF0-0x00000001842BBC58
	public static string StringFromIntPtrOSString(IntPtr ptr) => default; // 0x0000000182A4E7F0-0x0000000182A4E840
}

public class AkThreadProperties : IDisposable // TypeDefIndex: 52933
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int nPriority { get => default; set {} } // 0x00000001842BCA18-0x00000001842BCA68 0x00000001842BCB34-0x00000001842BCB88
	public uint dwAffinityMask { get => default; set {} } // 0x00000001842BC9C8-0x00000001842BCA18 0x00000001842BCAE0-0x00000001842BCB34
	public uint uStackSize { get => default; set {} } // 0x00000001842BCA68-0x00000001842BCAB8 0x00000001842BCB88-0x00000001842BCBDC

	// Constructors
	internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0
	public AkThreadProperties() {} // 0x00000001842BC978-0x00000001842BC9C8

	// Methods
	internal static IntPtr getCPtr(AkThreadProperties obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842BCAB8-0x00000001842BCAE0
	~AkThreadProperties() {} // 0x00000001842BC904-0x00000001842BC978
	public void Dispose() {} // 0x00000001842BC7A0-0x00000001842BC7F0
	protected virtual void Dispose(bool disposing) {} // 0x00000001842BC7F0-0x00000001842BC904
}

public class AkUnityPlatformSpecificSettings : IDisposable // TypeDefIndex: 52934
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	public AkUnityPlatformSpecificSettings() {} // Dummy constructor
	internal AkUnityPlatformSpecificSettings(IntPtr cPtr, bool cMemoryOwn) {} // 0x0000000183D4E290-0x0000000183D4E2A0

	// Methods
	internal static IntPtr getCPtr(AkUnityPlatformSpecificSettings obj) => default; // 0x000000018427A72C-0x000000018427A73C
	internal virtual void setCPtr(IntPtr cPtr) {} // 0x00000001842BCDB0-0x00000001842BCDD8
	~AkUnityPlatformSpecificSettings() {} // 0x0000000183923F10-0x0000000183923F60
	public void Dispose() {} // 0x00000001842BCD60-0x00000001842BCDB0
	protected virtual void Dispose(bool disposing) {} // 0x0000000183923F60-0x0000000183924210
}

public class AkAndroidSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 52937
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 52936
	{
		// Fields
		[AkEnumFlag(typeof(AudioAPI))]
		[Tooltip("Main audio API to use. Leave set to \"Default\" for the default audio sink.")]
		public AudioAPI m_AudioAPI; // 0x50
		[Tooltip("Used when hardware-preferred frame size and user-preferred frame size are not compatible. If true (default), the sound engine will initialize to a multiple of the HW setting, close to the user setting. If false, the user setting is used as is, regardless of the HW preference (might incur a performance hit).")]
		public bool m_RoundFrameSizeToHardwareSize; // 0x54
		[Tooltip("Use the lowest output latency possible for the current hardware. If true (default), the output audio device will be initialized in low-latency operation, allowing for more responsive audio playback on most devices. However, when operating in low-latency mode, some devices may have differences in audio reproduction. If false, the output audio device will be initialized without low-latency operation.")]
		public bool m_UseLowLatencyMode; // 0x55

		// Nested types
		public enum AudioAPI // TypeDefIndex: 52935
		{
			Default = -1,
			None = 0,
			AAudio = 1,
			OpenSL_ES = 2
		}

		// Constructors
		public PlatformAdvancedSettings() {} // 0x0000000183D2DFA0-0x0000000183D2DFF0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x000000018350B670-0x000000018350B680
	}

	// Constructors
	public AkAndroidSettings() {} // 0x000000018346E970-0x000000018346EAD0

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x0000000181003830-0x0000000181003840
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
}

public static class AkAudioInputManager // TypeDefIndex: 52942
{
	// Fields
	private static bool initialized; // 0x00
	private static readonly Dictionary<uint, AudioSamplesDelegate> audioSamplesDelegates; // 0x08
	private static readonly Dictionary<uint, AudioFormatDelegate> audioFormatDelegates; // 0x10
	private static readonly AkAudioFormat audioFormat; // 0x18
	private static readonly AudioSamplesInteropDelegate audioSamplesDelegate; // 0x20
	private static readonly AudioFormatInteropDelegate audioFormatDelegate; // 0x28

	// Nested types
	public delegate void AudioFormatDelegate(uint playingID, AkAudioFormat format); // TypeDefIndex: 52938; 0x0000000182065C10-0x0000000182065C20

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void AudioFormatInteropDelegate(uint playingID, IntPtr format); // TypeDefIndex: 52939; 0x0000000182065C10-0x0000000182065C20

	public delegate bool AudioSamplesDelegate(uint playingID, uint channelIndex, float[] samples); // TypeDefIndex: 52940; 0x0000000181035ED0-0x0000000181035EF0

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate bool AudioSamplesInteropDelegate(uint playingID, [In, Out] float[] samples, uint channelIndex, uint frames); // TypeDefIndex: 52941; 0x000000018101C850-0x000000018101C870

	// Constructors
	static AkAudioInputManager() {} // 0x00000001842AAC88-0x00000001842AAEB4

	// Methods
	public static uint PostAudioInputEvent(uint akEventID, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null) => default; // 0x00000001842AA9DC-0x00000001842AAAE0
	public static uint PostAudioInputEvent(string akEventName, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null) => default; // 0x00000001842AAAE0-0x00000001842AABE4
	[AOT.MonoPInvokeCallback(typeof(AudioSamplesInteropDelegate))]
	private static bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames) => default; // 0x00000001842AA8F0-0x00000001842AA9DC
	[AOT.MonoPInvokeCallback(typeof(AudioFormatInteropDelegate))]
	private static void InternalAudioFormatDelegate(uint playingID, IntPtr format) {} // 0x00000001842AA7EC-0x00000001842AA8F0
	private static void TryInitialize() {} // 0x00000001842AABE4-0x00000001842AAC88
	private static void AddPlayingID(uint playingID, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate) {} // 0x00000001842AA624-0x00000001842AA6FC
	private static void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo) {} // 0x00000001842AA6FC-0x00000001842AA7EC
}

public class AkBasePathGetter // TypeDefIndex: 52943
{
	// Fields
	public static readonly string DefaultBasePath; // 0x00
	private static AkBasePathGetter Instance; // 0x18

	// Properties
	public static bool IsWwiseProjectAvailable { get; private set; } // 0x00000001842AB718-0x00000001842AB768 0x00000001842AB7B8-0x00000001842AB80C
	public string SoundBankBasePath { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	public string PersistentDataPath { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	public static string WwiseProjectFullPath { get; private set; } // 0x00000001842AB768-0x00000001842AB7B8 0x00000001842AB80C-0x00000001842AB86C

	// Constructors
	public AkBasePathGetter() {} // 0x000000018350B670-0x000000018350B680
	static AkBasePathGetter() {} // 0x0000000183CE05E0-0x0000000183CE0680

	// Methods
	public static string GetPlatformName() => default; // 0x0000000182A02570-0x0000000182A025A0
	public static string GetPlatformBasePath(string platformName = "" /* Metadata: 0x01FD3277 */) => default; // 0x00000001842AB558-0x00000001842AB648
	public static AkBasePathGetter Get() => default; // 0x00000001842AB648-0x00000001842AB718
	public static void Reset() {} // 0x0000000183D20BF0-0x0000000183D20C60
	public void EvaluateGamePaths() {} // 0x00000001842AB44C-0x00000001842AB558
}

public static class AkCallbackManager // TypeDefIndex: 52952
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
	public static int bnkCallbackCount { get; } // 0x00000001842AC57C-0x00000001842AC5DC 
	public static int evtCallbackCount { get; } // 0x00000001842AC5DC-0x00000001842AC63C 

	// Nested types
	public delegate void EventCallback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info); // TypeDefIndex: 52944; 0x00000001811360D0-0x00000001811360F0

	public delegate void MonitoringCallback(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg); // TypeDefIndex: 52945; 0x0000000181028930-0x0000000181028950

	public delegate void BankCallback(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie); // TypeDefIndex: 52946; 0x0000000182097E50-0x0000000182097E70

	public class EventCallbackPackage // TypeDefIndex: 52947
	{
		// Fields
		public EventCallback callback; // 0x10
		public object cookie; // 0x18
		public uint playingID; // 0x20

		// Constructors
		public EventCallbackPackage() {} // 0x000000018350B670-0x000000018350B680

		// Methods
		internal static void Recycle(EventCallbackPackage inPkg) {} // 0x000000018269B1E0-0x000000018269B300
		public static EventCallbackPackage Create(EventCallback inCb, object inCookie, ref uint ioFlags) => default; // 0x000000018269E2E0-0x000000018269E470
	}

	public class BankCallbackPackage // TypeDefIndex: 52948
	{
		// Fields
		public BankCallback callback; // 0x10
		public object cookie; // 0x18

		// Constructors
		public BankCallbackPackage() {} // 0x000000018350B670-0x000000018350B680

		// Methods
		public static BankCallbackPackage Create(BankCallback inCb, object inCookie) => default; // 0x000000018269FEA0-0x000000018269FFB0
		public static void Recycle(BankCallbackPackage pkg) {} // 0x000000018269B130-0x000000018269B1E0
	}

	private class SimplePool<T> // TypeDefIndex: 52949
		where T : new()
	{
		// Fields
		private readonly T[] m_pool;
		private readonly int m_poolSize;
		private int m_poolIndex;

		// Constructors
		public SimplePool() {} // Dummy constructor
		public SimplePool(int poolSize) {}

		// Methods
		public T Alloc() => default;
		public void Recycle(T obj) {}
	}

	public delegate AKRESULT BGMCallback(bool in_bOtherAudioPlaying, object in_Cookie); // TypeDefIndex: 52950; 0x0000000181165340-0x0000000181165350

	public class BGMCallbackPackage // TypeDefIndex: 52951
	{
		// Fields
		public BGMCallback m_Callback; // 0x10
		public object m_Cookie; // 0x18

		// Constructors
		public BGMCallbackPackage() {} // 0x000000018350B670-0x000000018350B680
	}

	// Constructors
	static AkCallbackManager() {} // 0x00000001831D7F00-0x00000001831D8450

	// Methods
	public static void CancelAllCallbacks() {} // 0x00000001842AB90C-0x00000001842ABC64
	public static void RemoveEventCallback(uint in_playingID) {} // 0x00000001842AC24C-0x00000001842AC4BC
	public static void RemoveEventCallbackCookie(object in_cookie) {} // 0x00000001842ABF80-0x00000001842AC24C
	public static void RemoveBankCallback(object in_cookie) {} // 0x00000001842ABCB4-0x00000001842ABF80
	public static void SetLastAddedPlayingID(uint in_playingID) {} // 0x000000018269E4D0-0x000000018269E670
	public static void Init() {} // 0x0000000182A01CE0-0x0000000182A01D30
	public static void Term() {} // 0x00000001842AC574-0x00000001842AC57C
	public static void SetMonitoringCallback(AkMonitorErrorLevel in_Level, MonitoringCallback in_CB) {} // 0x0000000183A46B40-0x0000000183A46BB0
	private static void SetLocalOutput(AkMonitorErrorLevel in_Level) {} // 0x000000018350B670-0x000000018350B680
	public static void SetBGMCallback(BGMCallback in_CB, object in_cookie) {} // 0x00000001842AC4BC-0x00000001842AC574
	public static void PostCallbacksNoInvoke() {} // 0x00000001842ABC64-0x00000001842ABCB4
	public static int PostCallbacks() => default; // 0x000000018269BEA0-0x000000018269D100
	private static void _ProcessBankCallback(IntPtr pPackage, IntPtr pData) {} // 0x000000018269AD50-0x000000018269AF50
	private static AkCallbackInfo _ProcessEventCallback(AkCallbackType eType, IntPtr pData) => default; // 0x000000018269B300-0x000000018269BA50
}

public class AkBasePlatformSettings : ScriptableObject // TypeDefIndex: 52953
{
	// Properties
	public virtual AkInitializationSettings AkInitializationSettings { get => default; } // 0x0000000182A03750-0x0000000182A037A0 
	public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get => default; } // 0x0000000182A02D30-0x0000000182A02D80 
	public virtual string SoundBankPersistentDataPath { get => default; } // 0x0000000181002730-0x0000000181002740 
	public virtual string SoundbankPath { get => default; } // 0x00000001842AB8BC-0x00000001842AB90C 
	public virtual AkCommunicationSettings AkCommunicationSettings { get => default; } // 0x00000001842AB86C-0x00000001842AB8BC 
	public virtual uint MemoryAllocationSizeLimit { get => default; } // 0x0000000181002730-0x0000000181002740 
	public virtual uint MemoryDebugLevel { get => default; } // 0x0000000181002730-0x0000000181002740 

	// Constructors
	public AkBasePlatformSettings() {} // 0x000000018286F540-0x000000018286F550
}

[Serializable]
public class AkCommonOutputSettings // TypeDefIndex: 52958
{
	// Fields
	[Tooltip("The name of a custom audio device to use. Custom audio devices are defined in the Audio Device Shareset section of the Wwise project. Leave this empty to output normally through the default audio device.")]
	public string m_AudioDeviceShareset; // 0x10
	[Tooltip("Device specific identifier, when multiple devices of the same type are possible.  If only one device is possible, leave to 0.")]
	public uint m_DeviceID; // 0x18
	[Tooltip("Rule for 3D panning of signals routed to a stereo bus. In \"Speakers\" mode, the angle of the front loudspeakers is used. In \"Headphones\" mode, the speaker angles are superseded by constant power panning between two virtual microphones spaced 180 degrees apart.")]
	public PanningRule m_PanningRule; // 0x1C
	[Tooltip("Channel configuration for this output. Hardware might not support the selected configuration.")]
	public ChannelConfiguration m_ChannelConfig; // 0x20

	// Nested types
	public enum PanningRule // TypeDefIndex: 52954
	{
		Speakers = 0,
		Headphones = 1
	}

	[Serializable]
	public class ChannelConfiguration // TypeDefIndex: 52957
	{
		// Fields
		[Tooltip("A code that completes the identification of channels by uChannelMask. Anonymous: Channel mask == 0 and channels. Standard: Channels must be identified with standard defines in AkSpeakerConfigs. Ambisonic: Channel mask == 0 and channels follow standard ambisonic order.")]
		public ChannelConfigType m_ChannelConfigType; // 0x10
		[AkEnumFlag(typeof(ChannelMask))]
		[Tooltip("A bit field, whose channel identifiers depend on AkChannelConfigType (up to 20).")]
		public ChannelMask m_ChannelMask; // 0x14
		[Tooltip("The number of channels, identified (deduced from channel mask) or anonymous (set directly).")]
		public uint m_NumberOfChannels; // 0x18

		// Nested types
		public enum ChannelConfigType // TypeDefIndex: 52955
		{
			Anonymous = 0,
			Standard = 1,
			Ambisonic = 2
		}

		public enum ChannelMask // TypeDefIndex: 52956
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
		public ChannelConfiguration() {} // 0x000000018350B670-0x000000018350B680

		// Methods
		public void CopyTo(AkChannelConfig config) {} // 0x0000000182A4F390-0x0000000182A4F3D0
	}

	// Constructors
	public AkCommonOutputSettings() {} // 0x000000018346E640-0x000000018346E720

	// Methods
	public void CopyTo(AkOutputSettings settings) {} // 0x0000000182A4F220-0x0000000182A4F2C0
}

[Serializable]
public class AkCommonUserSettings // TypeDefIndex: 52960
{
	// Fields
	[Tooltip("Path for the SoundBanks. This must contain one sub folder per platform, with the same as in the Wwise project.")]
	public string m_BasePath; // 0x10
	[Tooltip("Maximum number of automation paths for positioning sounds.")]
	public uint m_MaximumNumberOfPositioningPaths; // 0x18
	[Tooltip("Size of the command queue.")]
	public uint m_CommandQueueSize; // 0x1C
	[Tooltip("Number of samples per audio frame (256, 512, 1024, or 2048).")]
	public uint m_SamplesPerFrame; // 0x20
	[Tooltip("Main output device settings.")]
	public AkCommonOutputSettings m_MainOutputSettings; // 0x28
	[Range(0f, 1f)]
	[Tooltip("Multiplication factor for all streaming look-ahead heuristic values.")]
	public float m_StreamingLookAheadRatio; // 0x30
	[Tooltip("Sampling rate in Hz. The default value is 48000. Use 24000 for low quality audio. Any positive, reasonable sample rate is supported. However, very low sample rates might cause the sound engine to malfunction.")]
	public uint m_SampleRate; // 0x34
	[Tooltip("Number of refill buffers in voice buffer. Set to 2 for double-buffered. The default value is to 4.")]
	public ushort m_NumberOfRefillsInVoice; // 0x38
	[Tooltip("Spatial audio common settings.")]
	public SpatialAudioSettings m_SpatialAudioSettings; // 0x40

	// Nested types
	[Serializable]
	public class SpatialAudioSettings // TypeDefIndex: 52959
	{
		// Fields
		[Range(0f, 8f)]
		[Tooltip("Maximum number of portals that sound can propagate through. The default value is 8.")]
		public uint m_MaxSoundPropagationDepth; // 0x10
		[Tooltip("Distance (in game units) that an emitter or listener has to move to trigger a recalculation of reflections and diffraction. A high distance value has a lower CPU load than a low distance value, but the accuracy is also lower. Note that this value does not affect the ray tracing itself. Rays are cast each time a Spatial Audio update is executed. The default value is 0.25.")]
		public float m_MovementThreshold; // 0x14
		[Tooltip("The number of primary rays used in the ray tracing engine. A larger value increases the chances of finding reflection and diffraction paths but results in higher CPU usage. When the CPU limit is active (see the CPU Limit Percentage Spatial Audio Setting), this setting represents the maximum allowed number of primary rays. The default value is 35.")]
		public uint m_NumberOfPrimaryRays; // 0x18
		[FormerlySerializedAs("m_ReflectionsOrder")]
		[Range(0f, 4f)]
		[Tooltip("The maximum reflection order: the number of \"bounces\" in a reflection path. A higher reflection order renders more detail at the expense of higher CPU usage. The default value is 2.")]
		public uint m_MaxReflectionOrder; // 0x1C
		[Range(0f, 8f)]
		[Tooltip("Maximum diffraction order: the number of \"bends\" in a diffraction path. A high diffraction order accommodates more complex geometry at the expense of higher CPU usage. Diffraction must be enabled on the geometry to find diffraction paths. Set to 0 to disable diffraction on all geometry. This parameter limits the recursion depth of diffraction rays cast from the listener to scan the environment and also the depth of the diffraction search to find paths between emitter and listener. To optimize CPU usage, set it to the maximum number of edges you expect the obstructing geometry to traverse. The default value is 4.")]
		public uint m_MaxDiffractionOrder; // 0x20
		[Range(0f, 4f)]
		[Tooltip("The maximum possible number of diffraction points at each end of a reflection path. Diffraction on reflection allows reflections to fade in and out smoothly as the listener or emitter moves in and out of the reflection\'s shadow zone. When greater than zero, diffraction rays are sent from the listener to search for reflections around one or more corners from the listener. Diffraction must be enabled on the geometry to find diffracted reflections. Set to 0 to disable diffraction on reflections. Set to 2 or greater to allow Reflection paths to travel through Portals. The default value is 2.")]
		public uint m_DiffractionOnReflectionsOrder; // 0x24
		[Tooltip("The maximum number of game-defined auxiliary sends that can originate from a single emitter. An emitter can send to its own Room and to all adjacent Rooms if the emitter and listener are in the same Room. If a limit is set, the most prominent sends are kept, based on spread to the adjacent portal from the emitter\'s perspective. Set to 1 to only allow emitters to send directly to their current Room, and to the Room a listener is transitioning to if inside a portal. Set to 0 to disable the limit. The default value is 3.")]
		public uint m_MaxEmitterRoomAuxSends; // 0x28
		[Tooltip("Length of the rays that are cast inside Spatial Audio. Effectively caps the maximum length of an individual segment in a reflection or diffraction path. The default value is 1000.")]
		public float m_MaxPathLength; // 0x2C
		[Tooltip("Defines the targeted computation time allocated for the ray tracing engine as a percentage [0, 100] of the current audio frame. The ray tracing engine dynamically adapts the number of primary rays to target the specified computation time. The computed number of primary rays cannot exceed the value specified by the Number Of Primary Rays Spatial Audio Setting. A value of 0 indicates no target has been set. In this case, the number of primary rays is fixed and is set by the Number Of Primary Rays Spatial Audio Setting. The default value is 0.")]
		public float m_CPULimitPercentage; // 0x30
		[FormerlySerializedAs("m_EnableDirectPathDiffraction")]
		[Tooltip("Enable computation of geometric diffraction and transmission paths for all sources that have the \"Diffraction and Transmission\" option selected in the Positioning tab of the Wwise Property Editor. This flag enables sound paths around (diffraction) and through (transmission) geometry. Setting EnableGeometricDiffractionAndTransmission to false implies that geometry is only to be used for reflection calculation. Diffraction edges must be enabled on geometry for diffraction calculation. If EnableGeometricDiffractionAndTransmission is false but a sound has \"Diffraction and Transmission\" selected in the Positioning tab of Wwise Authoring, the sound will diffract through portals but pass through geometry as if it isn\'t there. Typically, we recommend you disable this setting if the game will perform obstruction calculations, but geometry is still passed to Spatial Audio for reflection calculations. The default value is true.")]
		public bool m_EnableGeometricDiffractionAndTransmission; // 0x34
		[Tooltip("An emitter that is diffracted through a portal or around geometry will have its apparent or virtual position calculated by Wwise Spatial Audio and passed on to the sound engine. The default value is true.")]
		public bool m_CalcEmitterVirtualPosition; // 0x35
		[Min(1f)]
		[Tooltip("The computation of spatial audio paths is spread on LoadBalancingSpread frames. Spreading the computation of paths over several frames can prevent CPU peaks. The spread introduces a delay in path computation. The default value is 1.")]
		public uint m_LoadBalancingSpread; // 0x38

		// Constructors
		public SpatialAudioSettings() {} // 0x0000000183B226C0-0x0000000183B22710
	}

	// Constructors
	public AkCommonUserSettings() {} // 0x000000018346E5B0-0x000000018346E640

	// Methods
	protected static string GetPluginPath() => default; // 0x0000000182A4D2D0-0x0000000182A4D470
	public virtual void CopyTo(AkInitSettings settings) {} // 0x0000000182A4E5F0-0x0000000182A4E730
	public void CopyTo(AkMusicSettings settings) {} // 0x0000000182A03C50-0x0000000182A03C80
	public void CopyTo(AkStreamMgrSettings settings) {} // 0x000000018350B670-0x000000018350B680
	public virtual void CopyTo(AkDeviceSettings settings) {} // 0x000000018350B670-0x000000018350B680
	private void SetSampleRate(AkPlatformInitSettings settings) {} // 0x0000000182A03CC0-0x0000000182A03CF0
	public virtual void CopyTo(AkPlatformInitSettings settings) {} // 0x0000000182A03C80-0x0000000182A03CC0
	public virtual void CopyTo(AkSpatialAudioInitSettings settings) {} // 0x0000000182A02E10-0x0000000182A02F80
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings) {} // 0x000000018350B670-0x000000018350B680
	public virtual void Validate() {} // 0x00000001842ACBC0-0x00000001842ACC20
}

[Serializable]
public class AkCommonAdvancedSettings // TypeDefIndex: 52962
{
	// Fields
	[Tooltip("Size of memory pool for I/O (for automatic streams). It is rounded down to a multiple of uGranularity and then passed directly to AK::MemoryMgr::CreatePool().")]
	public uint m_IOMemorySize; // 0x10
	[Tooltip("Targeted automatic stream buffer length (ms). When a stream reaches that buffering, it stops being scheduled for I/O except if the scheduler is idle.")]
	public float m_TargetAutoStreamBufferLengthMs; // 0x14
	[Tooltip("If true the device attempts to reuse IO buffers that have already been streamed from disk. This is particularly useful when streaming small looping sounds. The drawback is a small CPU hit when allocating memory, and a slightly larger memory footprint in the StreamManager pool.")]
	public bool m_UseStreamCache; // 0x18
	[Tooltip("Maximum number of bytes that can be \"pinned\" using AK::SoundEngine::PinEventInStreamCache() or AK::IAkStreamMgr::PinFileInCache()")]
	public uint m_MaximumPinnedBytesInCache; // 0x1C
	[Tooltip("Set to true to enable AK::SoundEngine::PrepareGameSync usage.")]
	public bool m_EnableGameSyncPreparation; // 0x20
	[Tooltip("Number of quanta ahead when continuous containers instantiate a new voice before the following sounds start playing. This look-ahead time allows I/O to occur, and is especially useful to reduce the latency of continuous containers with trigger rate or sample-accurate transitions.")]
	public uint m_ContinuousPlaybackLookAhead; // 0x24
	[Tooltip("Size of the monitoring queue pool. This parameter is ignored in Release build.")]
	public uint m_MonitorQueuePoolSize; // 0x28
	[Tooltip("Time (in milliseconds) to wait to wait for hardware devices to trigger an audio interrupt. If there is no interrupt after that time, the sound engine reverts to silent mode and continues operating until the hardware responds.")]
	public uint m_MaximumHardwareTimeoutMs; // 0x2C
	[Tooltip("Debug setting: Enable checks for out-of-range (and NAN) floats in the processing code. Do not enable in any normal usage because this setting uses a lot of CPU. It prints error messages in the log if invalid values are found at various points in the pipeline. Contact AK Support with the new error messages for more information.")]
	public bool m_DebugOutOfRangeCheckEnabled; // 0x30
	[Tooltip("Debug setting: Only used when bDebugOutOfRangeCheckEnabled is true. This defines the maximum values samples can have. Normal audio must be contained within +1/-1. Set this limit to a value greater than 1 to allow temporary or short excursions out of range. The default value is 16.")]
	public float m_DebugOutOfRangeLimit; // 0x34
	[Tooltip("Sets the sub-folder underneath UnityEngine.Application.persistentDataPath that will be used as the SoundBank base path. This is useful when the Init.bnk needs to be downloaded. Setting this to an empty string uses the typical SoundBank base path resolution. Setting this to \".\" uses UnityEngine.Application.persistentDataPath.")]
	public string m_SoundBankPersistentDataPath; // 0x38
	[Tooltip("Maximum amount of memory that Wwise can use. Use 0 for unlimited memory.")]
	public uint m_MemoryAllocationSizeLimit; // 0x40
	[Tooltip("Memory allocator debug level. For use under Audiokinetic Support supervision.")]
	public uint m_MemoryDebugLevel; // 0x44
	[Tooltip("Controls amount of memory mapped by Wwise. Smaller values use less memory at the cost of greater CPU utilization. For more information, refer to \"Tuning Span Count\" in the Wwise SDK Documentation.")]
	public MemSpanCount m_MemorySpanCount; // 0x48

	// Nested types
	public enum MemSpanCount // TypeDefIndex: 52961
	{
		Small = 0,
		Medium = 1,
		Huge = 2
	}

	// Constructors
	public AkCommonAdvancedSettings() {} // 0x0000000183D4E300-0x0000000183D4E340

	// Methods
	public virtual void CopyTo(AkDeviceSettings settings) {} // 0x0000000182A03DB0-0x0000000182A03E10
	public virtual void CopyTo(AkInitSettings settings) {} // 0x0000000182A016C0-0x0000000182A01740
	public virtual void CopyTo(AkPlatformInitSettings settings) {} // 0x000000018350B670-0x000000018350B680
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings) {} // 0x000000018350B670-0x000000018350B680
}

[Serializable]
public class AkCommonCommSettings // TypeDefIndex: 52963
{
	// Fields
	[Tooltip("Size of the communication pool.")]
	public uint m_PoolSize; // 0x10
	public static ushort DefaultDiscoveryBroadcastPort; // 0x00
	[Tooltip("The port where the authoring application broadcasts \"Game Discovery\" requests to discover games running on the network. Default value: 24024. (Cannot be set to 0)")]
	public ushort m_DiscoveryBroadcastPort; // 0x14
	[Tooltip("The \"command\" channel port. Set to 0 to request a dynamic/ephemeral port.")]
	public ushort m_CommandPort; // 0x16
	[Tooltip("The \"notification\" channel port. Set to 0 to request a dynamic/ephemeral port.")]
	public ushort m_NotificationPort; // 0x18
	[Tooltip("Indicates whether or not to initialize the communication system. Some consoles have critical requirements for initialization of their communications system. Set to false only if your game already uses sockets before sound engine initialization.")]
	public bool m_InitializeSystemComms; // 0x1A
	[Tooltip("The name used to identify this game within the authoring application. Leave empty to use \"UnityEngine.Application.productName\".")]
	public string m_NetworkName; // 0x20
	[Tooltip("HTCS communication can only be used with a Nintendo Switch Development Build")]
	public AkCommunicationSettings.AkCommSystem m_commSystem; // 0x28

	// Constructors
	public AkCommonCommSettings() {} // 0x000000018346E540-0x000000018346E5B0
	static AkCommonCommSettings() {} // 0x0000000183D42760-0x0000000183D427A0

	// Methods
	public virtual void CopyTo(AkCommunicationSettings settings) {} // 0x00000001842ACA4C-0x00000001842ACAE0
	public virtual void Validate() {} // 0x000000018350B670-0x000000018350B680
}

public abstract class AkCommonPlatformSettings : AkBasePlatformSettings // TypeDefIndex: 52964
{
	// Properties
	public override AkInitializationSettings AkInitializationSettings { get; } // 0x0000000182A02820-0x0000000182A029A0 
	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; } // 0x0000000182A02CE0-0x0000000182A02D30 
	public override string SoundBankPersistentDataPath { get; } // 0x00000001842ACB80-0x00000001842ACBA0 
	public override string SoundbankPath { get; } // 0x00000001842ACBA0-0x00000001842ACBC0 
	public override uint MemoryAllocationSizeLimit { get; } // 0x00000001842ACB40-0x00000001842ACB60 
	public override uint MemoryDebugLevel { get; } // 0x00000001842ACB60-0x00000001842ACB80 
	public override AkCommunicationSettings AkCommunicationSettings { get; } // 0x00000001842ACAE0-0x00000001842ACB40 

	// Constructors
	protected AkCommonPlatformSettings() {} // 0x000000018286F540-0x000000018286F550

	// Methods
	protected abstract AkCommonUserSettings GetUserSettings();
	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();
	protected abstract AkCommonCommSettings GetCommsSettings();
}

[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class AkEnumFlagAttribute : PropertyAttribute // TypeDefIndex: 52965
{
	// Fields
	public System.Type Type; // 0x10

	// Constructors
	public AkEnumFlagAttribute() {} // Dummy constructor
	public AkEnumFlagAttribute(System.Type type) {} // 0x000000018426FEE0-0x000000018426FEF0
}

public class AkLogger // TypeDefIndex: 52967
{
	// Fields
	private static AkLogger ms_Instance; // 0x00
	private ErrorLoggerInteropDelegate errorLoggerDelegate; // 0x10

	// Properties
	public static AkLogger Instance { get => default; } // 0x00000001842AD27C-0x00000001842AD2CC 

	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void ErrorLoggerInteropDelegate(string message); // TypeDefIndex: 52966; 0x0000000182149960-0x0000000182149970

	// Constructors
	private AkLogger() {} // 0x00000001839C5950-0x00000001839C5A70
	static AkLogger() {} // 0x00000001839C58E0-0x00000001839C5950

	// Methods
	~AkLogger() {} // 0x00000001842ACF0C-0x00000001842AD09C
	public void Init() {} // 0x000000018350B670-0x000000018350B680
	[AOT.MonoPInvokeCallback(typeof(ErrorLoggerInteropDelegate))]
	public static void WwiseInternalLogError(string message) {} // 0x00000001842AD1DC-0x00000001842AD27C
	public static void Message(string message) {} // 0x00000001842AD09C-0x00000001842AD13C
	public static void Warning(string message) {} // 0x00000001842AD13C-0x00000001842AD1DC
	public static void Error(string message) {} // 0x00000001842ACE6C-0x00000001842ACF0C
}

public static class AkSoundEngineInitialization // TypeDefIndex: 52970
{
	// Fields
	public static InitializationDelegate s_initializationDelegate; // 0x00
	public static TerminationDelegate s_terminationDelegate; // 0x08

	// Nested types
	public delegate void InitializationDelegate(); // TypeDefIndex: 52968; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void TerminationDelegate(); // TypeDefIndex: 52969; 0x00000001842BE03C-0x00000001842BE04C

	// Methods
	public static bool InitializeSoundEngine() => default; // 0x0000000182A02150-0x0000000182A022A0
	private static void _TryInitSpatialAudio(ref AkBasePlatformSettings activePlatformSettings) {} // 0x0000000182A022A0-0x0000000182A02330
	private static void _TryInitCommunication(ref AkBasePlatformSettings activePlatformSettings) {} // 0x000000018350B670-0x000000018350B680
	public static void TerminateSoundEngine(bool hgDeepTerm = false /* Metadata: 0x01FD3328 */) {} // 0x00000001842ADC58-0x00000001842ADD58
	private static void _WaitCallbacks(int retry) {} // 0x00000001842ADD58-0x00000001842ADDB8
}

public class AkUtilities // TypeDefIndex: 52972
{
	// Nested types
	public class ShortIDGenerator // TypeDefIndex: 52971
	{
		// Fields
		private const uint s_prime32 = 16777619; // Metadata: 0x01FD3329
		private const uint s_offsetBasis32 = 2166136261; // Metadata: 0x01FD332D
		private static byte s_hashSize; // 0x00
		private static uint s_mask; // 0x04

		// Properties
		public static byte HashSize { get => default; set {} } // 0x00000001842BE384-0x00000001842BE3D4 0x00000001842BE3D4-0x00000001842BE43C

		// Constructors
		static ShortIDGenerator() {} // 0x00000001842BE378-0x00000001842BE384
		public ShortIDGenerator() {} // 0x000000018350B670-0x000000018350B680

		// Methods
		public static uint Compute(string in_name) => default; // 0x00000001842BE280-0x00000001842BE378
	}

	// Constructors
	public AkUtilities() {} // 0x000000018350B670-0x000000018350B680

	// Methods
	public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash) {} // 0x00000001842BCE44-0x00000001842BCF70
	public static void FixSlashes(ref string path) {} // 0x00000001842BCDD8-0x00000001842BCE44
	public static string GetPathInPackage(string relativePath) => default; // 0x00000001842BCF70-0x00000001842BD250
}

public struct AkVector64 // TypeDefIndex: 52973
{
	// Fields
	public double X; // 0x00
	public double Y; // 0x08
	public double Z; // 0x10

	// Methods
	public void Zero() {} // 0x0000000183D4E350-0x0000000183D4E360
	public static implicit operator AkVector64(Vector3 vector) => default; // 0x0000000182BA1B00-0x0000000182BA1B30
}

public class AkWwiseInitializationSettings : AkCommonPlatformSettings // TypeDefIndex: 52976
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
	public bool IsValid { get => default; } // 0x0000000182A01C80-0x0000000182A01CE0 
	public int Count { get => default; } // 0x0000000182A02700-0x0000000182A02740 
	public static AkWwiseInitializationSettings Instance { get => default; set {} } // 0x0000000182A02740-0x0000000182A02820 0x00000001842BD250-0x00000001842BD2B0
	public static AkBasePlatformSettings ActivePlatformSettings { get => default; } // 0x0000000182A02430-0x0000000182A02570 

	// Nested types
	public abstract class PlatformSettings : AkCommonPlatformSettings // TypeDefIndex: 52974
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private List<string> IgnorePropertyNameList; // 0x18
		[HideInInspector]
		[SerializeField]
		private List<string> GlobalPropertyNameList; // 0x20
		private HashSet<string> _GlobalPropertyHashSet; // 0x28

		// Properties
		public HashSet<string> GlobalPropertyHashSet { get; set; } // 0x00000001842BE1EC-0x00000001842BE280 0x0000000182C92F10-0x0000000182C92F20

		// Constructors
		protected PlatformSettings() {} // 0x000000018346E430-0x000000018346E540

		// Methods
		public void IgnorePropertyValue(string propertyPath) {} // 0x000000018346EAD0-0x000000018346EB50
		public bool IsPropertyIgnored(string propertyPath) => default; // 0x000000018346EB50-0x000000018346EBB0
		public void SetUseGlobalPropertyValue(string propertyPath, bool use) {} // 0x0000000183470930-0x00000001834709D0
		public void SetGlobalPropertyValues(IEnumerable enumerable) {} // 0x0000000182B65990-0x0000000182B65E00
		private bool IsUsingGlobalPropertyValue(string propertyPath) => default; // 0x0000000182B65E00-0x0000000182B65E60
	}

	public class CommonPlatformSettings : PlatformSettings // TypeDefIndex: 52975
	{
		// Fields
		public AkCommonUserSettings UserSettings; // 0x30
		public AkCommonAdvancedSettings AdvancedSettings; // 0x38
		public AkCommonCommSettings CommsSettings; // 0x40

		// Constructors
		public CommonPlatformSettings() {} // 0x000000018346E240-0x000000018346E250

		// Methods
		protected override AkCommonUserSettings GetUserSettings() => default; // 0x0000000181003830-0x0000000181003840
		protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
		protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
	}

	// Constructors
	public AkWwiseInitializationSettings() {} // 0x000000018346E250-0x000000018346E430
	static AkWwiseInitializationSettings() {} // 0x00000001836FC180-0x00000001836FC930

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x0000000181003830-0x0000000181003840
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
	private static AkBasePlatformSettings GetPlatformSettings(string platformName) => default; // 0x0000000182A025A0-0x0000000182A02700
	private void OnEnable() {} // 0x000000018350B670-0x000000018350B680
}

public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface> // TypeDefIndex: 52977
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001842AA5E4-0x00000001842AA624 

	// Constructors
	public AkAcousticSurfaceArray() {} // Dummy constructor
	public AkAcousticSurfaceArray(int count) {} // 0x00000001842AA59C-0x00000001842AA5E4

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001842AA550-0x00000001842AA59C
	protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001842AA504-0x00000001842AA550
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other) {} // 0x00000001842AA4A0-0x00000001842AA504
}

public class AkAuxSendArray : IDisposable // TypeDefIndex: 52978
{
	// Fields
	private const int MAX_COUNT = 4; // Metadata: 0x01FD3332
	private readonly int SIZE_OF_AKAUXSENDVALUE; // 0x10
	private IntPtr m_Buffer; // 0x18
	private int m_Count; // 0x20

	// Properties
	public AkAuxSendValue this[int index] { get => default; } // 0x00000001842AB378-0x00000001842AB438 
	public bool isFull { get => default; } // 0x00000001842AB438-0x00000001842AB44C 

	// Constructors
	public AkAuxSendArray() {} // 0x00000001842AB2FC-0x00000001842AB378

	// Methods
	public void Dispose() {} // 0x00000001842AB144-0x00000001842AB1A4
	~AkAuxSendArray() {} // 0x00000001842AB1A4-0x00000001842AB214
	public void Reset() {} // 0x0000000183D4E2C0-0x0000000183D4E2D0
	public bool Add(ulong in_listenerGameObj, uint in_AuxBusID, float in_fValue) => default; // 0x00000001842AAEB4-0x00000001842AAF64
	public bool Add(uint in_AuxBusID, float in_fValue) => default; // 0x00000001842AAF64-0x00000001842AB004
	public bool Contains(ulong in_listenerGameObj, uint in_AuxBusID) => default; // 0x00000001842AB004-0x00000001842AB0A4
	public bool Contains(uint in_AuxBusID) => default; // 0x00000001842AB0A4-0x00000001842AB144
	public AKRESULT SetValues(ulong gameObject) => default; // 0x00000001842AB288-0x00000001842AB2EC
	public AKRESULT GetValues(ulong gameObject) => default; // 0x00000001842AB214-0x00000001842AB288
	public IntPtr GetBuffer() => default; // 0x0000000181041090-0x00000001810410A0
	public int Count() => default; // 0x0000000181003B50-0x0000000181003B60
	private IntPtr _GetObjectPtr(int index) => default; // 0x00000001842AB2EC-0x00000001842AB2FC
}

public abstract class AkBaseArray<T> : IDisposable // TypeDefIndex: 52979
{
	// Fields
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

public class AkChannelEmitterArray : IDisposable // TypeDefIndex: 52980
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20

	// Properties
	public uint Count { get; private set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300

	// Constructors
	public AkChannelEmitterArray() {} // Dummy constructor
	public AkChannelEmitterArray(uint in_Count) {} // 0x00000001842AC9F0-0x00000001842ACA4C

	// Methods
	public void Dispose() {} // 0x00000001842AC920-0x00000001842AC980
	~AkChannelEmitterArray() {} // 0x00000001842AC980-0x00000001842AC9F0
	public void Reset() {} // 0x0000000183D4E2D0-0x0000000183D4E2E0
	public void Add(AkVector64 in_Pos, Vector3 in_Forward, Vector3 in_Top, uint in_ChannelMask) {} // 0x00000001842AC63C-0x00000001842AC920
}

public class AkDeviceDescriptionArray : AkBaseArray<AkDeviceDescription> // TypeDefIndex: 52981
{
	// Properties
	protected override int StructureSize { get => default; } // 0x0000000183694FA0-0x0000000183694FF0 

	// Constructors
	public AkDeviceDescriptionArray() {} // Dummy constructor
	public AkDeviceDescriptionArray(int count) {} // 0x00000001836182F0-0x0000000183618340

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x0000000183799BD0-0x0000000183799C20
	protected override AkDeviceDescription CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x000000018386C0D0-0x000000018386C120
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDeviceDescription other) {} // 0x00000001842ACC20-0x00000001842ACC84
}

public class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo> // TypeDefIndex: 52982
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001842ACD7C-0x00000001842ACDBC 

	// Constructors
	public AkDiffractionPathInfoArray() {} // Dummy constructor
	public AkDiffractionPathInfoArray(int count) {} // 0x00000001842ACD34-0x00000001842ACD7C

	// Methods
	protected override AkDiffractionPathInfo CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001842ACCE8-0x00000001842ACD34
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDiffractionPathInfo other) {} // 0x00000001842ACC84-0x00000001842ACCE8
}

public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo> // TypeDefIndex: 52983
{
	// Properties
	protected override int StructureSize { get => default; } // 0x0000000183742240-0x0000000183742290 

	// Constructors
	public AkExternalSourceInfoArray() {} // Dummy constructor
	public AkExternalSourceInfoArray(int count) {} // 0x0000000183828020-0x0000000183828070

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x0000000183C94770-0x0000000183C947C0
	protected override void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address) {} // 0x00000001842ACE20-0x00000001842ACE6C
	protected override AkExternalSourceInfo CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x0000000183766780-0x00000001837667D0
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other) {} // 0x00000001842ACDBC-0x00000001842ACE20
}

public class AkMIDIPostArray // TypeDefIndex: 52984
{
	// Fields
	private readonly int m_Count; // 0x10
	private readonly int SIZE_OF; // 0x14
	private IntPtr m_Buffer; // 0x18

	// Properties
	public AkMIDIPost this[int index] { get => default; set {} } // 0x00000001842AD5A8-0x00000001842AD674 0x00000001842AD674-0x00000001842AD748

	// Constructors
	public AkMIDIPostArray() {} // Dummy constructor
	public AkMIDIPostArray(int size) {} // 0x00000001842AD520-0x00000001842AD5A8

	// Methods
	~AkMIDIPostArray() {} // 0x00000001842AD2CC-0x00000001842AD37C
	public void PostOnEvent(uint in_eventID, GameObject gameObject) {} // 0x00000001842AD38C-0x00000001842AD428
	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count) {} // 0x00000001842AD428-0x00000001842AD520
	public IntPtr GetBuffer() => default; // 0x0000000181041090-0x00000001810410A0
	public int Count() => default; // 0x0000000183D4E340-0x0000000183D4E350
	private IntPtr GetObjectPtr(int index) => default; // 0x00000001842AD37C-0x00000001842AD38C
}

public class AkObjectInfoArray : AkBaseArray<AkObjectInfo> // TypeDefIndex: 52985
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001842AD88C-0x00000001842AD8CC 

	// Constructors
	public AkObjectInfoArray() {} // Dummy constructor
	public AkObjectInfoArray(int count) {} // 0x00000001842AD844-0x00000001842AD88C

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001842AD7F8-0x00000001842AD844
	protected override AkObjectInfo CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001842AD7AC-0x00000001842AD7F8
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObjectInfo other) {} // 0x00000001842AD748-0x00000001842AD7AC
}

public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues> // TypeDefIndex: 52986
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001842ADA10-0x00000001842ADA50 

	// Constructors
	public AkObstructionOcclusionValuesArray() {} // Dummy constructor
	public AkObstructionOcclusionValuesArray(int count) {} // 0x00000001842AD9C8-0x00000001842ADA10

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001842AD97C-0x00000001842AD9C8
	protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001842AD930-0x00000001842AD97C
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other) {} // 0x00000001842AD8CC-0x00000001842AD930
}

public class AkPositionArray : IDisposable // TypeDefIndex: 52987
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20

	// Properties
	public uint Count { get; private set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300

	// Constructors
	public AkPositionArray() {} // Dummy constructor
	public AkPositionArray(uint in_Count) {} // 0x0000000183287E20-0x0000000183287E90

	// Methods
	public void Dispose() {} // 0x00000001842ADA50-0x00000001842ADAB0
	~AkPositionArray() {} // 0x00000001842ADAB0-0x00000001842ADB20
	public void Reset() {} // 0x0000000183D4E2D0-0x0000000183D4E2E0
	public void Add(AkVector64 in_Pos, Vector3 in_Forward, Vector3 in_Top) {} // 0x0000000183287BD0-0x0000000183287C40
}

public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo> // TypeDefIndex: 52988
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001842ADC18-0x00000001842ADC58 

	// Constructors
	public AkReflectionPathInfoArray() {} // Dummy constructor
	public AkReflectionPathInfoArray(int count) {} // 0x00000001842ADBD0-0x00000001842ADC18

	// Methods
	protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001842ADB84-0x00000001842ADBD0
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other) {} // 0x00000001842ADB20-0x00000001842ADB84
}

public class AkSourceSettingsArray : AkBaseArray<AkSourceSettings> // TypeDefIndex: 52989
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001842BC760-0x00000001842BC7A0 

	// Constructors
	public AkSourceSettingsArray() {} // Dummy constructor
	public AkSourceSettingsArray(int count) {} // 0x00000001842BC718-0x00000001842BC760

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001842BC6CC-0x00000001842BC718
	protected override AkSourceSettings CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001842BC680-0x00000001842BC6CC
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkSourceSettings other) {} // 0x00000001842BC61C-0x00000001842BC680
}

public class AkTriangleArray : AkBaseArray<AkTriangle> // TypeDefIndex: 52990
{
	// Properties
	protected override int StructureSize { get => default; } // 0x00000001842BCD20-0x00000001842BCD60 

	// Constructors
	public AkTriangleArray() {} // Dummy constructor
	public AkTriangleArray(int count) {} // 0x00000001842BCCD8-0x00000001842BCD20

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address) {} // 0x00000001842BCC8C-0x00000001842BCCD8
	protected override AkTriangle CreateNewReferenceFromIntPtr(IntPtr address) => default; // 0x00000001842BCC40-0x00000001842BCC8C
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkTriangle other) {} // 0x00000001842BCBDC-0x00000001842BCC40
}

public static class AudioNativeHelper // TypeDefIndex: 52993
{
	// Fields
	private static IntPtr s_reusedTransformPtr; // 0x00

	// Nested types
	public struct AudioTriangleArrayNoGc : IDisposable // TypeDefIndex: 52991
	{
		// Fields
		private IntPtr m_buffer; // 0x00
		private int m_capacity; // 0x08
		private int m_elementSize; // 0x0C

		// Properties
		internal IntPtr Buffer { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 

		// Constructors
		public AudioTriangleArrayNoGc(int capacity) : this() {
			m_buffer = default;
			m_capacity = default;
			m_elementSize = default;
		} // 0x00000001826CFF70-0x00000001826D0090

		// Methods
		public void Set(int idx, ushort p0, ushort p1, ushort p2, ushort surface) {} // 0x00000001826D75D0-0x00000001826D7710
		public void Dispose() {} // 0x00000001826CFE30-0x00000001826CFEA0
	}

	public struct AudioAcousticSurfaceArrayNoGc : IDisposable // TypeDefIndex: 52992
	{
		// Fields
		private IntPtr m_buffer; // 0x00
		private int m_capacity; // 0x08
		private int m_elementSize; // 0x0C

		// Properties
		internal IntPtr Buffer { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 

		// Constructors
		public AudioAcousticSurfaceArrayNoGc(int capacity) : this() {
			m_buffer = default;
			m_capacity = default;
			m_elementSize = default;
		} // 0x00000001826D00D0-0x00000001826D01D0

		// Methods
		public void Set(int idx, float transmissionLoss, uint textureId) {} // 0x00000001826D5540-0x00000001826D55E0
		public void Dispose() {} // 0x00000001826CFEA0-0x00000001826CFF10
	}

	// Constructors
	static AudioNativeHelper() {} // 0x0000000183D44BE0-0x0000000183D44C20

	// Methods
	internal static void Init() {} // 0x0000000182A01B30-0x0000000182A01BB0
	internal static void Term() {} // 0x00000001842BD7F4-0x00000001842BD85C
	public static AKRESULT SetRoomPortal(ulong portalID, ulong frontRoom, ulong backRoom, Vector3 position, Vector3 orientationFront, Vector3 orientationTop, Vector3 extent, bool enabled, string portalName = "" /* Metadata: 0x01FD3333 */) => default; // 0x00000001842BD674-0x00000001842BD7F4
	public static AKRESULT SetGeometry(ulong geoId, AudioTriangleArrayNoGc triangles, uint numTriangles, Vector3[] vertices, uint numVertices, AudioAcousticSurfaceArrayNoGc surfaces, uint numSurfaces, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges) => default; // 0x00000001826D53E0-0x00000001826D54B0
	public static AKRESULT SetGeometryInstance(ulong geomInstanceID, Vector3 pos, Quaternion rot, Vector3 scale, ulong geometrySetID, ulong roomID, bool useForReflectionAndDiffraction) => default; // 0x00000001831AD9E0-0x00000001831ADBF0
}

public class AkiOSSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 52998
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 52997
	{
		// Fields
		[Tooltip("The IDs of the iOS audio session categories, useful for defining app-level audio behaviours such as inter-app audio mixing policies and audio routing behaviours.These IDs are functionally equivalent to the corresponding constants defined by the iOS audio session service back-end (AVAudioSession). Refer to Xcode documentation for details on the audio session categories.")]
		public Category m_AudioSessionCategory; // 0x50
		[AkEnumFlag(typeof(CategoryOptions))]
		[Tooltip("The IDs of the iOS audio session category options, used for customizing the audio session category features. These IDs are functionally equivalent to the corresponding constants defined by the iOS audio session service back-end (AVAudioSession). Refer to Xcode documentation for details on the audio session category options.")]
		public CategoryOptions m_AudioSessionCategoryOptions; // 0x54
		[Tooltip("The IDs of the iOS audio session modes, used for customizing the audio session for typical app types. These IDs are functionally equivalent to the corresponding constants defined by the iOS audio session service back-end (AVAudioSession). Refer to Xcode documentation for details on the audio session category options.")]
		public Mode m_AudioSessionMode; // 0x58
		[Tooltip("Number of Apple Spatial Audio point sources to allocate for 3D audio use (each point source is a system audio object).")]
		public uint NumSpatialAudioPointSources; // 0x5C
		[Tooltip("Print debug information related to audio device initialization in the system log.")]
		public bool VerboseSystemOutput; // 0x60

		// Nested types
		public enum Category // TypeDefIndex: 52994
		{
			Ambient = 0,
			SoloAmbient = 1,
			PlayAndRecord = 2,
			Playback = 3
		}

		public enum CategoryOptions // TypeDefIndex: 52995
		{
			MixWithOthers = 1,
			DuckOthers = 2,
			AllowBluetooth = 4,
			DefaultToSpeaker = 8
		}

		public enum Mode // TypeDefIndex: 52996
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
		public PlatformAdvancedSettings() {} // 0x0000000183D2DF50-0x0000000183D2DFA0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x000000018350B670-0x000000018350B680
	}

	// Constructors
	public AkiOSSettings() {} // 0x000000018346EBB0-0x000000018346ED40

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x0000000181003830-0x0000000181003840
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
}

public class AkMacSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 53000
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 52999
	{
		// Fields
		[Tooltip("Number of Apple Spatial Audio point sources to allocate for 3D audio use (each point source is a system audio object).")]
		public uint NumSpatialAudioPointSources; // 0x50
		[Tooltip("Print debug information related to audio device initialization in the system log.")]
		public bool VerboseSystemOutput; // 0x54

		// Constructors
		public PlatformAdvancedSettings() {} // 0x0000000183D4E360-0x0000000183D4E3A0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x000000018350B670-0x000000018350B680
	}

	// Constructors
	public AkMacSettings() {} // 0x000000018346E240-0x000000018346E250

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x0000000181003830-0x0000000181003840
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
}

public class AkPS5Settings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 53002
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 53001
	{
		// Fields
		[Tooltip("The number of ports to initialize the audioOut2Context with. May need to be increased if using many sinks")]
		public uint NumAudioOut2Ports; // 0x50
		[Tooltip("The number of object ports to initialize the audioOut2Context with. Will need to be increased depending on sceAudio3D usage and configuration.")]
		public uint NumAudioOut2ObjectPorts; // 0x54
		[Tooltip("Use low latency mode for hardware codecs such as ATRAC9.  If true, decoding jobs are submitted at the beginning of the Wwise update and it will be necessary to wait for the result.")]
		public bool HwCodecLowLatencyMode; // 0x58
		[Tooltip("Decode all Vorbis sources on PS5\'s audio co-processor, similar to ATRAC9. Please refer to the PS5-specific section of the Wwise SDK documentation for more information on advantages and limitations of hardware decoders.")]
		public bool VorbisHwAcceleration; // 0x59
		[Tooltip("Controls synchronization of 3D Audio across the ambisonic mix, and passthrough/objects. When enabled, this increases the delay of the Passthrough and Objects audio mixes by a few milliseconds, in order to be in sync with the main Ambisonic mix. Refer to sceAudioOut2Set3DLatency in the platform documentation for more information.")]
		public bool Enable3DAudioSync; // 0x5A
		[Tooltip("Used to determine the threshold at which bus-mix operations will be performed in hardware instead of software. Please refer to the PS5-specific section of the Wwise SDK documentation for more information on this tradeoff.")]
		public uint NumOperationsForHwMixing; // 0x5C
		[Tooltip("If enabled, will constantly output the current context queue level as a plot to Razor CPU, to visualize audio starvation limits.")]
		public bool PlotQueueLevel; // 0x60

		// Constructors
		public PlatformAdvancedSettings() {} // 0x0000000183471420-0x0000000183471480

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x000000018350B670-0x000000018350B680
	}

	// Constructors
	public AkPS5Settings() {} // 0x0000000183470CB0-0x0000000183470D80

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x0000000181003830-0x0000000181003840
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
}

public class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 53004
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 53003
	{
		// Fields
		[Tooltip("Maximum number of System Audio Objects to reserve. Other processes will not be able to use them. Default is 128.")]
		public uint MaxSystemAudioObjects; // 0x50

		// Constructors
		public PlatformAdvancedSettings() {} // 0x0000000183D4E360-0x0000000183D4E3A0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings) {} // 0x0000000183C97780-0x0000000183C977B0
	}

	// Constructors
	public AkWindowsSettings() {} // 0x000000018346E240-0x000000018346E250

	// Methods
	protected override AkCommonUserSettings GetUserSettings() => default; // 0x0000000181003830-0x0000000181003840
	protected override AkCommonAdvancedSettings GetAdvancedSettings() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	protected override AkCommonCommSettings GetCommsSettings() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
}

