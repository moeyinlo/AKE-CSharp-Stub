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

// Image 29: AK.Wwise.Unity.API.dll - Assembly: AK.Wwise.Unity.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 83026-83207

public class Ak3DAudioSinkCapabilities : IDisposable // TypeDefIndex: 83027
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkChannelConfig channelConfig { get; set; } // 0x0000000187841028-0x00000001878410A4 0x0000000187841214-0x000000018784127C
	public uint uMaxSystemAudioObjects { get; set; } // 0x00000001878410F4-0x0000000187841144 0x00000001878412D0-0x0000000187841324
	public uint uAvailableSystemAudioObjects { get; set; } // 0x00000001878410A4-0x00000001878410F4 0x000000018784127C-0x00000001878412D0
	public bool bPassthrough { get; set; } // 0x0000000187840FD8-0x0000000187841028 0x00000001878411C0-0x0000000187841214
	public bool bMultiChannelObjects { get; set; } // 0x0000000187840F88-0x0000000187840FD8 0x000000018784116C-0x00000001878411C0

	// Constructors
	internal Ak3DAudioSinkCapabilities(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public Ak3DAudioSinkCapabilities(); // 0x0000000187840F28-0x0000000187840F78

	// Methods
	internal static IntPtr getCPtr(Ak3DAudioSinkCapabilities obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187841144-0x000000018784116C
	~Ak3DAudioSinkCapabilities(); // 0x0000000187840EB0-0x0000000187840F28
	public void Dispose(); // 0x0000000187840E60-0x0000000187840EB0
	protected virtual void Dispose(bool disposing); // 0x0000000187840D50-0x0000000187840E60
}

public class Ak3dData : IDisposable // TypeDefIndex: 83028
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkTransform xform { get; set; } // 0x000000018784163C-0x00000001878416B8 0x00000001878417E4-0x000000018784184C
	public float spread { get; set; } // 0x000000018784159C-0x00000001878415EC 0x0000000187841738-0x0000000187841790
	public float focus { get; set; } // 0x000000018784154C-0x000000018784159C 0x00000001878416E0-0x0000000187841738
	public uint uEmitterChannelMask { get; set; } // 0x00000001878415EC-0x000000018784163C 0x0000000187841790-0x00000001878417E4

	// Constructors
	internal Ak3dData(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public Ak3dData(); // 0x00000001878414FC-0x000000018784154C

	// Methods
	internal static IntPtr getCPtr(Ak3dData obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878416B8-0x00000001878416E0
	~Ak3dData(); // 0x0000000187841484-0x00000001878414FC
	public void Dispose(); // 0x0000000187841434-0x0000000187841484
	protected virtual void Dispose(bool disposing); // 0x0000000187841324-0x0000000187841434
}

public enum Ak3DPositionType // TypeDefIndex: 83029
{
	AK_3DPositionType_Emitter = 0,
	AK_3DPositionType_EmitterWithAutomation = 1,
	AK_3DPositionType_ListenerWithAutomation = 2
}

public enum Ak3DSpatializationMode // TypeDefIndex: 83030
{
	AK_SpatializationMode_None = 0,
	AK_SpatializationMode_PositionOnly = 1,
	AK_SpatializationMode_PositionAndOrientation = 2
}

public class AkAcousticSurface : IDisposable // TypeDefIndex: 83031
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint textureID { get; set; } // 0x0000000187841C28-0x0000000187841C78 0x0000000187841D44-0x0000000187841D98
	public float transmissionLoss { get; set; } // 0x0000000187841C78-0x0000000187841CC8 0x0000000187841D98-0x0000000187841DF0
	public string strName { get; set; } // 0x0000000187841BBC-0x0000000187841C28 0x0000000187841CF0-0x0000000187841D44

	// Constructors
	internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkAcousticSurface(); // 0x0000000187841B6C-0x0000000187841BBC

	// Methods
	internal static IntPtr getCPtr(AkAcousticSurface obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187841CC8-0x0000000187841CF0
	~AkAcousticSurface(); // 0x0000000187841AB4-0x0000000187841B2C
	public void Dispose(); // 0x0000000187841954-0x00000001878419A4
	protected virtual void Dispose(bool disposing); // 0x00000001878419A4-0x0000000187841AB4
	public void Clear(); // 0x000000018784184C-0x000000018784189C
	public void DeleteName(); // 0x0000000187841904-0x0000000187841954
	public static int GetSizeOf(); // 0x0000000187841B2C-0x0000000187841B6C
	public void Clone(AkAcousticSurface other); // 0x000000018784189C-0x0000000187841904
}

public enum AkActionOnEventType // TypeDefIndex: 83032
{
	AkActionOnEventType_Stop = 0,
	AkActionOnEventType_Pause = 1,
	AkActionOnEventType_Resume = 2,
	AkActionOnEventType_Break = 3,
	AkActionOnEventType_ReleaseEnvelope = 4
}

public enum AkAttenuationCurveType // TypeDefIndex: 83033
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

public enum AkAudioDeviceState // TypeDefIndex: 83034
{
	AkDeviceState_Unknown = 0,
	AkDeviceState_Active = 1,
	AkDeviceState_Disabled = 2,
	AkDeviceState_NotPresent = 4,
	AkDeviceState_Unplugged = 8,
	AkDeviceState_All = 15
}

public class AkAudioFormat : IDisposable // TypeDefIndex: 83035
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uSampleRate { get; set; } // 0x000000018784239C-0x00000001878423EC 0x00000001878425C8-0x000000018784261C
	public AkChannelConfig channelConfig { get; set; } // 0x0000000187842230-0x00000001878422AC 0x0000000187842464-0x00000001878424CC
	public uint uBitsPerSample { get; set; } // 0x00000001878422AC-0x00000001878422FC 0x00000001878424CC-0x0000000187842520
	public uint uBlockAlign { get; set; } // 0x00000001878422FC-0x000000018784234C 0x0000000187842520-0x0000000187842574
	public uint uTypeID { get; set; } // 0x00000001878423EC-0x000000018784243C 0x000000018784261C-0x0000000187842670
	public uint uInterleaveID { get; set; } // 0x000000018784234C-0x000000018784239C 0x0000000187842574-0x00000001878425C8

	// Constructors
	internal AkAudioFormat(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkAudioFormat(); // 0x00000001878421E0-0x0000000187842230

	// Methods
	internal static IntPtr getCPtr(AkAudioFormat obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784243C-0x0000000187842464
	~AkAudioFormat(); // 0x0000000187841F50-0x0000000187841FC8
	public void Dispose(); // 0x0000000187841DF0-0x0000000187841E40
	protected virtual void Dispose(bool disposing); // 0x0000000187841E40-0x0000000187841F50
	public uint GetNumChannels(); // 0x00000001878420B8-0x0000000187842108
	public uint GetBitsPerSample(); // 0x0000000187841FC8-0x0000000187842018
	public uint GetBlockAlign(); // 0x0000000187842018-0x0000000187842068
	public uint GetTypeID(); // 0x0000000187842108-0x0000000187842158
	public uint GetInterleaveID(); // 0x0000000187842068-0x00000001878420B8
	public void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID); // 0x0000000187842158-0x00000001878421E0
}

public class AkAudioInterruptionCallbackInfo : IDisposable // TypeDefIndex: 83036
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public bool bEnterInterruption { get; } // 0x0000000187842898-0x00000001878428E8 

	// Constructors
	internal AkAudioInterruptionCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkAudioInterruptionCallbackInfo(); // 0x0000000187842848-0x0000000187842898

	// Methods
	internal static IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878428E8-0x0000000187842910
	~AkAudioInterruptionCallbackInfo(); // 0x00000001878427D0-0x0000000187842848
	public void Dispose(); // 0x0000000187842670-0x00000001878426C0
	protected virtual void Dispose(bool disposing); // 0x00000001878426C0-0x00000001878427D0
}

public enum AkAudioObjectDestination // TypeDefIndex: 83037
{
	eDefault = 0,
	eMainMix = 1,
	ePassthrough = 2,
	eSystemAudioObject = 3
}

public class AkAudioSettings : IDisposable // TypeDefIndex: 83038
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumSamplesPerFrame { get; set; } // 0x0000000187842B38-0x0000000187842B88 0x0000000187842C00-0x0000000187842C54
	public uint uNumSamplesPerSecond { get; set; } // 0x0000000187842B88-0x0000000187842BD8 0x0000000187842C54-0x0000000187842CA8

	// Constructors
	internal AkAudioSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkAudioSettings(); // 0x0000000187842AE8-0x0000000187842B38

	// Methods
	internal static IntPtr getCPtr(AkAudioSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187842BD8-0x0000000187842C00
	~AkAudioSettings(); // 0x0000000187842A70-0x0000000187842AE8
	public void Dispose(); // 0x0000000187842A20-0x0000000187842A70
	protected virtual void Dispose(bool disposing); // 0x0000000187842910-0x0000000187842A20
}

public class AkAudioSourceChangeCallbackInfo : IDisposable // TypeDefIndex: 83039
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public bool bOtherAudioPlaying { get; } // 0x0000000187842ED0-0x0000000187842F20 

	// Constructors
	internal AkAudioSourceChangeCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkAudioSourceChangeCallbackInfo(); // 0x0000000187842E80-0x0000000187842ED0

	// Methods
	internal static IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187842F20-0x0000000187842F48
	~AkAudioSourceChangeCallbackInfo(); // 0x0000000187842E08-0x0000000187842E80
	public void Dispose(); // 0x0000000187842CA8-0x0000000187842CF8
	protected virtual void Dispose(bool disposing); // 0x0000000187842CF8-0x0000000187842E08
}

public class AkAuxSendValue : IDisposable // TypeDefIndex: 83040
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong listenerID { get; set; } // 0x00000001878433CC-0x000000018784341C 0x00000001878434F0-0x0000000187843544
	public uint auxBusID { get; set; } // 0x000000018784332C-0x000000018784337C 0x0000000187843444-0x0000000187843498
	public float fControlValue { get; set; } // 0x000000018784337C-0x00000001878433CC 0x0000000187843498-0x00000001878434F0

	// Constructors
	internal AkAuxSendValue(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0

	// Methods
	internal static IntPtr getCPtr(AkAuxSendValue obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784341C-0x0000000187843444
	~AkAuxSendValue(); // 0x00000001878430A8-0x0000000187843120
	public void Dispose(); // 0x0000000187842F48-0x0000000187842F98
	protected virtual void Dispose(bool disposing); // 0x0000000187842F98-0x00000001878430A8
	public void Set(ulong listener, uint id, float value); // 0x00000001878432B0-0x000000018784332C
	public bool IsSame(ulong listener, uint id); // 0x0000000187843160-0x00000001878431C4
	public void Set(GameObject listener, uint id, float value); // 0x0000000187843230-0x00000001878432B0
	public bool IsSame(GameObject listener, uint id); // 0x00000001878431C4-0x0000000187843230
	public static int GetSizeOf(); // 0x0000000187843120-0x0000000187843160
}

public class AkBankCallbackInfo : IDisposable // TypeDefIndex: 83041
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint bankID { get; } // 0x000000018577DF70-0x000000018577DFC0 
	public IntPtr inMemoryBankPtr { get; } // 0x000000018577DE50-0x000000018577DEA0 
	public AKRESULT loadResult { get; } // 0x000000018577DEE0-0x000000018577DF30 

	// Constructors
	internal AkBankCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkBankCallbackInfo(); // 0x00000001878435BC-0x000000018784360C

	// Methods
	internal static IntPtr getCPtr(AkBankCallbackInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878377B8-0x00000001878377E0
	~AkBankCallbackInfo(); // 0x0000000187843544-0x00000001878435BC
	public void Dispose(); // 0x00000001862281B0-0x0000000186228210
	protected virtual void Dispose(bool disposing); // 0x0000000186228210-0x0000000186228390
}

public enum AkBankContent // TypeDefIndex: 83042
{
	AkBankContent_StructureOnly = 0,
	AkBankContent_All = 1
}

public enum AkBankTypeEnum // TypeDefIndex: 83043
{
	AkBankType_User = 0,
	AkBankType_Event = 30,
	AkBankType_Bus = 31
}

public class AkBehavioralPositioningData : IDisposable // TypeDefIndex: 83044
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float center { get; set; } // 0x0000000187843834-0x0000000187843884 0x0000000187843ADC-0x0000000187843B34
	public float panLR { get; set; } // 0x0000000187843974-0x00000001878439C4 0x0000000187843C38-0x0000000187843C90
	public float panBF { get; set; } // 0x00000001878438D4-0x0000000187843924 0x0000000187843B88-0x0000000187843BE0
	public float panDU { get; set; } // 0x0000000187843924-0x0000000187843974 0x0000000187843BE0-0x0000000187843C38
	public float panSpatMix { get; set; } // 0x00000001878439C4-0x0000000187843A14 0x0000000187843C90-0x0000000187843CE8
	public Ak3DSpatializationMode spatMode { get; set; } // 0x0000000187843A64-0x0000000187843AB4 0x0000000187843D3C-0x0000000187843D90
	public AkSpeakerPanningType panType { get; set; } // 0x0000000187843A14-0x0000000187843A64 0x0000000187843CE8-0x0000000187843D3C
	public bool enableHeightSpread { get; set; } // 0x0000000187843884-0x00000001878438D4 0x0000000187843B34-0x0000000187843B88

	// Constructors
	internal AkBehavioralPositioningData(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkBehavioralPositioningData(); // 0x00000001878437E4-0x0000000187843834

	// Methods
	internal static IntPtr getCPtr(AkBehavioralPositioningData obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187843AB4-0x0000000187843ADC
	~AkBehavioralPositioningData(); // 0x000000018784376C-0x00000001878437E4
	public void Dispose(); // 0x000000018784371C-0x000000018784376C
	protected virtual void Dispose(bool disposing); // 0x000000018784360C-0x000000018784371C
}

public enum AkBusHierarchyFlags // TypeDefIndex: 83045
{
	AkBusHierarchy_Primary = 1,
	AkBusHierarchy_Secondary = 2,
	AkBusHierarchy_IsMaster = 128
}

public class AkCallbackInfo : IDisposable // TypeDefIndex: 83046
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pCookie { get; } // 0x000000018577C750-0x000000018577C7F0 
	public ulong gameObjID { get; } // 0x000000018577C6D0-0x000000018577C720 

	// Constructors
	internal AkCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkCallbackInfo(); // 0x0000000187843E0C-0x0000000187843E5C

	// Methods
	internal static IntPtr getCPtr(AkCallbackInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018783B7D8-0x000000018783B800
	~AkCallbackInfo(); // 0x0000000187843D90-0x0000000187843E0C
	public void Dispose(); // 0x0000000185721F60-0x0000000185721FC0
	protected virtual void Dispose(bool disposing); // 0x0000000185721FC0-0x0000000185722140
}

public class AkCallbackSerializer : IDisposable // TypeDefIndex: 83047
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkCallbackSerializer(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkCallbackSerializer(); // 0x000000018784415C-0x00000001878441AC

	// Methods
	internal static IntPtr getCPtr(AkCallbackSerializer obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878441AC-0x00000001878441D4
	~AkCallbackSerializer(); // 0x000000018784402C-0x00000001878440A4
	public void Dispose(); // 0x0000000187843ECC-0x0000000187843F1C
	protected virtual void Dispose(bool disposing); // 0x0000000187843F1C-0x000000018784402C
	public static AKRESULT Init(); // 0x0000000186805A90-0x0000000186805AD0
	public static void Term(); // 0x000000018784411C-0x000000018784415C
	public static IntPtr Lock(); // 0x000000018577ECF0-0x000000018577ED40
	public static void Unlock(); // 0x00000001861B03B0-0x00000001861B03E0
	public static void SetLocalOutput(uint in_uErrorLevel, string in_ip, uint in_port, string in_xmlFilePath, uint in_msXmlTranslatorTimeout, uint in_msWaapiTranslatorTimeout); // 0x00000001878440A4-0x000000018784411C
	public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie); // 0x0000000187843E5C-0x0000000187843ECC
}

public enum AkCallbackType // TypeDefIndex: 83048
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

public class AkChannelConfig : IDisposable // TypeDefIndex: 83049
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumChannels { get; set; } // 0x00000001862FA5D0-0x00000001862FA630 0x000000018784498C-0x00000001878449E0
	public uint eConfigType { get; set; } // 0x00000001862FA530-0x00000001862FA590 0x00000001878448E4-0x0000000187844938
	public uint uChannelMask { get; set; } // 0x00000001862FA490-0x00000001862FA4F0 0x0000000187844938-0x000000018784498C

	// Constructors
	internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkChannelConfig(); // 0x0000000187844808-0x0000000187844858
	public AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask); // 0x0000000187844858-0x00000001878448BC

	// Methods
	internal static IntPtr getCPtr(AkChannelConfig obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878448BC-0x00000001878448E4
	~AkChannelConfig(); // 0x0000000186B76C80-0x0000000186B76CD0
	public void Dispose(); // 0x0000000187844358-0x00000001878443A8
	protected virtual void Dispose(bool disposing); // 0x0000000186B76CD0-0x0000000186B76F00
	public static AkChannelConfig Standard(uint in_uChannelMask); // 0x0000000187844798-0x0000000187844808
	public static AkChannelConfig Anonymous(uint in_uNumChannels); // 0x0000000187844244-0x00000001878442B4
	public static AkChannelConfig Ambisonic(uint in_uNumChannels); // 0x00000001878441D4-0x0000000187844244
	public static AkChannelConfig Object(); // 0x00000001878443F8-0x0000000187844464
	public void Clear(); // 0x00000001878442B4-0x0000000187844304
	public void SetStandard(uint in_uChannelMask); // 0x0000000187844744-0x0000000187844798
	public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask); // 0x00000001878446E0-0x0000000187844744
	public void SetAnonymous(uint in_uNumChannels); // 0x00000001850C9670-0x00000001850C96D0
	public void SetAmbisonic(uint in_uNumChannels); // 0x000000018784459C-0x00000001878445F0
	public void SetObject(); // 0x00000001878445F0-0x0000000187844640
	public void SetSameAsMainMix(); // 0x0000000187844640-0x0000000187844690
	public void SetSameAsPassthrough(); // 0x0000000187844690-0x00000001878446E0
	public bool IsValid(); // 0x00000001878443A8-0x00000001878443F8
	public uint Serialize(); // 0x000000018784454C-0x000000018784459C
	public void Deserialize(uint in_uChannelConfig); // 0x0000000187844304-0x0000000187844358
	public AkChannelConfig RemoveLFE(); // 0x00000001878444D8-0x000000018784454C
	public AkChannelConfig RemoveCenter(); // 0x0000000187844464-0x00000001878444D8
}

public enum AkChannelConfigType // TypeDefIndex: 83050
{
	AK_ChannelConfigType_Anonymous = 0,
	AK_ChannelConfigType_Standard = 1,
	AK_ChannelConfigType_Ambisonic = 2,
	AK_ChannelConfigType_Objects = 3,
	AK_ChannelConfigType_UseDeviceMain = 14,
	AK_ChannelConfigType_UseDevicePassthrough = 15
}

public class AkChannelEmitter : IDisposable // TypeDefIndex: 83051
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkWorldTransform position { get; set; } // 0x0000000187844C24-0x0000000187844CA0 0x0000000187844D6C-0x0000000187844DD4
	public uint uInputChannels { get; set; } // 0x0000000187844CA0-0x0000000187844CF0 0x0000000187844DD4-0x0000000187844E28
	public string padding { get; set; } // 0x0000000187844BB8-0x0000000187844C24 0x0000000187844D18-0x0000000187844D6C

	// Constructors
	internal AkChannelEmitter(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0

	// Methods
	internal static IntPtr getCPtr(AkChannelEmitter obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187844CF0-0x0000000187844D18
	~AkChannelEmitter(); // 0x0000000187844B40-0x0000000187844BB8
	public void Dispose(); // 0x0000000187844AF0-0x0000000187844B40
	protected virtual void Dispose(bool disposing); // 0x00000001878449E0-0x0000000187844AF0
}

public enum AkChannelOrdering // TypeDefIndex: 83052
{
	ChannelOrdering_Standard = 0,
	ChannelOrdering_RunTime = 1
}

public enum AkConnectionType // TypeDefIndex: 83053
{
	ConnectionType_Direct = 0,
	ConnectionType_GameDefSend = 1,
	ConnectionType_UserDefSend = 2,
	ConnectionType_ReflectionsSend = 3
}

public enum AkCurveInterpolation // TypeDefIndex: 83054
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

public class AkDeviceDescription : IDisposable // TypeDefIndex: 83055
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint idDevice { get; set; } // 0x00000001862E6D60-0x00000001862E6DB0 0x00000001878453C0-0x0000000187845414
	public string deviceName { get; set; } // 0x0000000187845234-0x00000001878452A0 0x0000000187845318-0x000000018784536C
	public AkAudioDeviceState deviceStateMask { get; set; } // 0x00000001878452A0-0x00000001878452F0 0x000000018784536C-0x00000001878453C0
	public bool isDefaultDevice { get; set; } // 0x00000001862E6BA0-0x00000001862E6C00 0x0000000187845414-0x0000000187845468

	// Constructors
	internal AkDeviceDescription(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkDeviceDescription(); // 0x00000001878451E4-0x0000000187845234

	// Methods
	internal static IntPtr getCPtr(AkDeviceDescription obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878452F0-0x0000000187845318
	~AkDeviceDescription(); // 0x0000000186B0F860-0x0000000186B0F8B0
	public void Dispose(); // 0x0000000187845154-0x00000001878451A4
	protected virtual void Dispose(bool disposing); // 0x0000000186B0F8B0-0x0000000186B0FA50
	public void Clear(); // 0x000000018784509C-0x00000001878450EC
	public static int GetSizeOf(); // 0x00000001878451A4-0x00000001878451E4
	public void Clone(AkDeviceDescription other); // 0x00000001878450EC-0x0000000187845154
}

public class AkDeviceSettings : IDisposable // TypeDefIndex: 83056
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pIOMemory { get; set; } // 0x00000001878455A8-0x00000001878455F8 0x0000000187845880-0x00000001878458D4
	public uint uIOMemorySize { get; set; } // 0x0000000187845714-0x0000000187845764 0x00000001868054A0-0x0000000186805500
	public uint uIOMemoryAlignment { get; set; } // 0x00000001878456C4-0x0000000187845714 0x0000000187845990-0x00000001878459E4
	public uint ePoolAttributes { get; set; } // 0x0000000187845508-0x0000000187845558 0x000000018784582C-0x0000000187845880
	public uint uGranularity { get; set; } // 0x0000000187845674-0x00000001878456C4 0x000000018784593C-0x0000000187845990
	public AkThreadProperties threadProperties { get; set; } // 0x00000001878455F8-0x0000000187845674 0x00000001878458D4-0x000000018784593C
	public float fTargetAutoStmBufferLength { get; set; } // 0x0000000187845558-0x00000001878455A8 0x0000000186805540-0x00000001868055A0
	public uint uMaxConcurrentIO { get; set; } // 0x00000001878457B4-0x0000000187845804 0x00000001878459E4-0x0000000187845A38
	public bool bUseStreamCache { get; set; } // 0x00000001878454B8-0x0000000187845508 0x00000001868055F0-0x0000000186805650
	public uint uMaxCachePinnedBytes { get; set; } // 0x0000000187845764-0x00000001878457B4 0x00000001868056A0-0x0000000186805700

	// Constructors
	internal AkDeviceSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0

	// Methods
	internal static IntPtr getCPtr(AkDeviceSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187845804-0x000000018784582C
	~AkDeviceSettings(); // 0x0000000186D46D00-0x0000000186D46D50
	public void Dispose(); // 0x0000000187845468-0x00000001878454B8
	protected virtual void Dispose(bool disposing); // 0x0000000186D46D50-0x0000000186D46EE0
}

public class AkDiffractionPathInfo : IDisposable // TypeDefIndex: 83057
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18
	public const uint kMaxNodes = 8; // Metadata: 0x02641855

	// Properties
	public AkVector64 emitterPos { get; set; } // 0x0000000187845ECC-0x0000000187845F38 0x00000001878461C4-0x0000000187846230
	public AkWorldTransform virtualPos { get; set; } // 0x00000001878460C8-0x0000000187846144 0x00000001878463E4-0x000000018784644C
	public uint nodeCount { get; set; } // 0x0000000187845F38-0x0000000187845F88 0x0000000187846230-0x0000000187846284
	public float diffraction { get; set; } // 0x0000000187845E7C-0x0000000187845ECC 0x000000018784616C-0x00000001878461C4
	public float transmissionLoss { get; set; } // 0x0000000187846078-0x00000001878460C8 0x000000018784638C-0x00000001878463E4
	public float totLength { get; set; } // 0x0000000187846028-0x0000000187846078 0x0000000187846334-0x000000018784638C
	public float obstructionValue { get; set; } // 0x0000000187845F88-0x0000000187845FD8 0x0000000187846284-0x00000001878462DC
	public float occlusionValue { get; set; } // 0x0000000187845FD8-0x0000000187846028 0x00000001878462DC-0x0000000187846334

	// Constructors
	internal AkDiffractionPathInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkDiffractionPathInfo(); // 0x0000000187845E2C-0x0000000187845E7C

	// Methods
	internal static IntPtr getCPtr(AkDiffractionPathInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187846144-0x000000018784616C
	~AkDiffractionPathInfo(); // 0x0000000187845C00-0x0000000187845C78
	public void Dispose(); // 0x0000000187845AA0-0x0000000187845AF0
	protected virtual void Dispose(bool disposing); // 0x0000000187845AF0-0x0000000187845C00
	public static int GetSizeOf(); // 0x0000000187845DEC-0x0000000187845E2C
	public Vector3 GetNodes(uint idx); // 0x0000000187845CCC-0x0000000187845D44
	public float GetAngles(uint idx); // 0x0000000187845C78-0x0000000187845CCC
	public ulong GetPortals(uint idx); // 0x0000000187845D44-0x0000000187845D98
	public ulong GetRooms(uint idx); // 0x0000000187845D98-0x0000000187845DEC
	public void Clone(AkDiffractionPathInfo other); // 0x0000000187845A38-0x0000000187845AA0
}

public class AkDurationCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 83058
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public float fDuration { get; } // 0x0000000187846678-0x00000001878466C8 
	public float fEstimatedDuration { get; } // 0x00000001878466C8-0x0000000187846718 
	public uint audioNodeID { get; } // 0x00000001878465D8-0x0000000187846628 
	public uint mediaID { get; } // 0x0000000187846718-0x0000000187846768 
	public bool bStreaming { get; } // 0x0000000187846628-0x0000000187846678 

	// Constructors
	internal AkDurationCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000186124790-0x0000000186124810
	public AkDurationCallbackInfo(); // 0x0000000187846578-0x00000001878465C8

	// Methods
	internal static IntPtr getCPtr(AkDurationCallbackInfo obj); // 0x00000001878465C8-0x00000001878465D8
	internal override void setCPtr(IntPtr cPtr); // 0x0000000187846768-0x00000001878467C8
	protected override void Dispose(bool disposing); // 0x000000018784644C-0x0000000187846578
}

public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo // TypeDefIndex: 83059
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get; } // 0x00000001878469F4-0x0000000187846A44 
	public uint audioNodeID { get; } // 0x0000000187846954-0x00000001878469A4 
	public IntPtr pCustomInfo { get; } // 0x00000001878469A4-0x00000001878469F4 

	// Constructors
	internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x00000001861242A0-0x0000000186124310
	public AkDynamicSequenceItemCallbackInfo(); // 0x00000001878468F4-0x0000000187846944

	// Methods
	internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj); // 0x0000000187846944-0x0000000187846954
	internal override void setCPtr(IntPtr cPtr); // 0x0000000187846A44-0x0000000187846AA4
	protected override void Dispose(bool disposing); // 0x00000001878467C8-0x00000001878468F4
}

public enum AkDynamicSequenceType // TypeDefIndex: 83060
{
	DynamicSequenceType_SampleAccurate = 0,
	DynamicSequenceType_NormalTransition = 1
}

public class AkEventCallbackInfo : AkCallbackInfo // TypeDefIndex: 83061
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get; } // 0x0000000187846AF4-0x0000000187846B44 
	public uint eventID { get; } // 0x000000018577C870-0x000000018577C8C0 

	// Constructors
	internal AkEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000186124610-0x0000000186124690
	public AkEventCallbackInfo(); // 0x0000000187846AA4-0x0000000187846AF4

	// Methods
	internal static IntPtr getCPtr(AkEventCallbackInfo obj); // 0x0000000187846944-0x0000000187846954
	internal override void setCPtr(IntPtr cPtr); // 0x0000000186124690-0x0000000186124750
	protected override void Dispose(bool disposing); // 0x0000000185722140-0x00000001857222D0
}

public class AkExtent : IDisposable // TypeDefIndex: 83062
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float halfWidth { get; set; } // 0x0000000187846E88-0x0000000187846ED8 0x0000000187846FB0-0x0000000187847008
	public float halfHeight { get; set; } // 0x0000000187846E38-0x0000000187846E88 0x0000000187846F58-0x0000000187846FB0
	public float halfDepth { get; set; } // 0x0000000187846DE8-0x0000000187846E38 0x0000000187846F00-0x0000000187846F58

	// Constructors
	internal AkExtent(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkExtent(); // 0x0000000187846D1C-0x0000000187846D6C
	public AkExtent(float in_halfWidth, float in_halfHeight, float in_halfDepth); // 0x0000000187846D6C-0x0000000187846DE8

	// Methods
	internal static IntPtr getCPtr(AkExtent obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187846ED8-0x0000000187846F00
	~AkExtent(); // 0x0000000187846CA4-0x0000000187846D1C
	public void Dispose(); // 0x0000000187846C54-0x0000000187846CA4
	protected virtual void Dispose(bool disposing); // 0x0000000187846B44-0x0000000187846C54
}

public class AkExternalSourceInfo : IDisposable // TypeDefIndex: 83063
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint iExternalSrcCookie { get; set; } // 0x000000018784730C-0x000000018784735C 0x00000001863A8500-0x00000001863A8560
	public uint idCodec { get; set; } // 0x000000018784735C-0x00000001878473AC 0x00000001863A8450-0x00000001863A84B0
	public string szFile { get; set; } // 0x000000018784744C-0x00000001878474B8 0x00000001863A85B0-0x00000001863A8620
	public IntPtr pInMemory { get; set; } // 0x00000001878473FC-0x000000018784744C 0x0000000187847584-0x00000001878475D8
	public uint uiMemorySize { get; set; } // 0x00000001878474B8-0x0000000187847508 0x00000001878475D8-0x000000018784762C
	public uint idFile { get; set; } // 0x00000001878473AC-0x00000001878473FC 0x0000000187847530-0x0000000187847584

	// Constructors
	internal AkExternalSourceInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkExternalSourceInfo(); // 0x000000018784723C-0x000000018784728C
	public AkExternalSourceInfo(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec); // 0x000000018784728C-0x000000018784730C
	public AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec); // 0x00000001878471C4-0x000000018784723C
	public AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec); // 0x0000000187847150-0x00000001878471C4

	// Methods
	internal static IntPtr getCPtr(AkExternalSourceInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187847508-0x0000000187847530
	~AkExternalSourceInfo(); // 0x0000000186500710-0x0000000186500760
	public void Dispose(); // 0x00000001878470C0-0x0000000187847110
	protected virtual void Dispose(bool disposing); // 0x0000000186500760-0x00000001865008E0
	public void Clear(); // 0x0000000187847008-0x0000000187847058
	public void Clone(AkExternalSourceInfo other); // 0x0000000187847058-0x00000001878470C0
	public static int GetSizeOf(); // 0x0000000187847110-0x0000000187847150
}

public enum AkFloorPlane // TypeDefIndex: 83064
{
	AkFloorPlane_XZ = 0,
	AkFloorPlane_Default = 0,
	AkFloorPlane_XY = 1,
	AkFloorPlane_YZ = 2
}

public class AkGeometryInstanceParams : IDisposable // TypeDefIndex: 83065
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkWorldTransform PositionAndOrientation { get; set; } // 0x0000000187847854-0x00000001878478D0 0x00000001878479B0-0x0000000187847A18
	public Vector3 Scale { get; set; } // 0x00000001878478D0-0x0000000187847938 0x0000000187847A18-0x0000000187847A80
	public bool UseForReflectionAndDiffraction { get; set; } // 0x0000000187847938-0x0000000187847988 0x0000000187847A80-0x0000000187847AD4

	// Constructors
	internal AkGeometryInstanceParams(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkGeometryInstanceParams(); // 0x0000000187847804-0x0000000187847854

	// Methods
	internal static IntPtr getCPtr(AkGeometryInstanceParams obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187847988-0x00000001878479B0
	~AkGeometryInstanceParams(); // 0x000000018784778C-0x0000000187847804
	public void Dispose(); // 0x000000018784762C-0x000000018784767C
	protected virtual void Dispose(bool disposing); // 0x000000018784767C-0x000000018784778C
}

public enum AkGlobalCallbackLocation // TypeDefIndex: 83066
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

public enum AkGroupType // TypeDefIndex: 83067
{
	AkGroupType_Switch = 0,
	AkGroupType_State = 1
}

public class AkImageSourceParams : IDisposable // TypeDefIndex: 83068
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkVector64 sourcePosition { get; set; } // 0x0000000187847EC8-0x0000000187847F34 0x000000018784815C-0x00000001878481C8
	public float fDistanceScalingFactor { get; set; } // 0x0000000187847DD8-0x0000000187847E28 0x0000000187848054-0x00000001878480AC
	public float fLevel { get; set; } // 0x0000000187847E28-0x0000000187847E78 0x00000001878480AC-0x0000000187848104
	public float fDiffraction { get; set; } // 0x0000000187847D88-0x0000000187847DD8 0x0000000187847FFC-0x0000000187848054
	public float fOcclusion { get; set; } // 0x0000000187847E78-0x0000000187847EC8 0x0000000187848104-0x000000018784815C
	public byte uDiffractionEmitterSide { get; set; } // 0x0000000187847F34-0x0000000187847F84 0x00000001878481C8-0x000000018784821C
	public byte uDiffractionListenerSide { get; set; } // 0x0000000187847F84-0x0000000187847FD4 0x000000018784821C-0x0000000187848270

	// Constructors
	internal AkImageSourceParams(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkImageSourceParams(); // 0x0000000187847CAC-0x0000000187847CFC
	public AkImageSourceParams(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel); // 0x0000000187847CFC-0x0000000187847D88

	// Methods
	internal static IntPtr getCPtr(AkImageSourceParams obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187847FD4-0x0000000187847FFC
	~AkImageSourceParams(); // 0x0000000187847C34-0x0000000187847CAC
	public void Dispose(); // 0x0000000187847AD4-0x0000000187847B24
	protected virtual void Dispose(bool disposing); // 0x0000000187847B24-0x0000000187847C34
}

public class AkImageSourceSettings : IDisposable // TypeDefIndex: 83069
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkImageSourceParams params_ { get; set; } // 0x0000000187848578-0x00000001878485F4 0x000000018784861C-0x0000000187848684

	// Constructors
	internal AkImageSourceSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkImageSourceSettings(); // 0x0000000187848528-0x0000000187848578
	public AkImageSourceSettings(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel); // 0x000000018784849C-0x0000000187848528

	// Methods
	internal static IntPtr getCPtr(AkImageSourceSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878485F4-0x000000018784861C
	~AkImageSourceSettings(); // 0x00000001878483D0-0x0000000187848448
	public void Dispose(); // 0x0000000187848380-0x00000001878483D0
	protected virtual void Dispose(bool disposing); // 0x0000000187848270-0x0000000187848380
	public void SetOneTexture(uint in_texture); // 0x0000000187848448-0x000000018784849C
}

public class AkInitializationSettings : IDisposable // TypeDefIndex: 83070
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkStreamMgrSettings streamMgrSettings { get; set; } // 0x0000000186806DB0-0x0000000186806E40 0x0000000187849118-0x0000000187849180
	public AkDeviceSettings deviceSettings { get; set; } // 0x0000000186806080-0x0000000186806110 0x0000000187848F78-0x0000000187848FE0
	public AkInitSettings initSettings { get; set; } // 0x0000000186805FB0-0x0000000186806040 0x0000000187848FE0-0x0000000187849048
	public AkPlatformInitSettings platformSettings { get; set; } // 0x0000000186805EE0-0x0000000186805F70 0x00000001878490B0-0x0000000187849118
	public AkMusicSettings musicSettings { get; set; } // 0x0000000186806CE0-0x0000000186806D70 0x0000000187849048-0x00000001878490B0
	public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings { get; set; } // 0x0000000186805E10-0x0000000186805EA0 0x0000000187849180-0x00000001878491E8
	public uint uMemAllocationSizeLimit { get; set; } // 0x0000000187848E60-0x0000000187848EB0 0x0000000186805740-0x00000001868057A0
	public uint uMemDebugLevel { get; set; } // 0x0000000187848EB0-0x0000000187848F00 0x00000001868057E0-0x0000000186805840
	public uint uMemSpanCount { get; set; } // 0x0000000187848F00-0x0000000187848F50 0x0000000186805880-0x00000001868058E0

	// Constructors
	internal AkInitializationSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkInitializationSettings(); // 0x0000000186805980-0x00000001868059D0

	// Methods
	internal static IntPtr getCPtr(AkInitializationSettings obj); // 0x000000018566BC30-0x000000018566BC40
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187848F50-0x0000000187848F78
	~AkInitializationSettings(); // 0x0000000186E24FF0-0x0000000186E25040
	public void Dispose(); // 0x0000000187848E10-0x0000000187848E60
	protected virtual void Dispose(bool disposing); // 0x0000000186E25040-0x0000000186E25240
}

public class AkInitSettings : IDisposable // TypeDefIndex: 83071
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxNumPaths { get; set; } // 0x0000000187848A94-0x0000000187848AE4 0x00000001850C9420-0x00000001850C9480
	public uint uCommandQueueSize { get; set; } // 0x0000000187848954-0x00000001878489A4 0x00000001850C9380-0x00000001850C93E0
	public bool bEnableGameSyncPreparation { get; set; } // 0x0000000187848724-0x0000000187848774 0x00000001868051F0-0x0000000186805250
	public uint uContinuousPlaybackLookAhead { get; set; } // 0x00000001878489A4-0x00000001878489F4 0x0000000186805150-0x00000001868051B0
	public uint uNumSamplesPerFrame { get; set; } // 0x0000000187848B34-0x0000000187848B84 0x00000001850C92E0-0x00000001850C9340
	public uint uMonitorQueuePoolSize { get; set; } // 0x0000000187848AE4-0x0000000187848B34 0x00000001868050B0-0x0000000186805110
	public uint uCpuMonitorQueueMaxSize { get; set; } // 0x00000001878489F4-0x0000000187848A44 0x0000000187848DBC-0x0000000187848E10
	public AkOutputSettings settingsMainOutput { get; set; } // 0x00000001850C8E80-0x00000001850C8F10 0x0000000187848D00-0x0000000187848D68
	public uint uMaxHardwareTimeoutMs { get; set; } // 0x0000000187848A44-0x0000000187848A94 0x0000000186805010-0x0000000186805070
	public bool bUseSoundBankMgrThread { get; set; } // 0x00000001878487C4-0x0000000187848814 0x0000000187848C00-0x0000000187848C54
	public bool bUseLEngineThread { get; set; } // 0x0000000187848774-0x00000001878487C4 0x0000000187848BAC-0x0000000187848C00
	public string szPluginDLLPath { get; set; } // 0x00000001850C8D20-0x00000001850C8DA0 0x00000001850C9280-0x00000001850C92E0
	public AkFloorPlane eFloorPlane { get; set; } // 0x0000000187848814-0x0000000187848864 0x0000000187848C54-0x0000000187848CA8
	public float fGameUnitsToMeters { get; set; } // 0x00000001878488B4-0x0000000187848904 0x0000000187848CA8-0x0000000187848D00
	public uint uBankReadBufferSize { get; set; } // 0x0000000187848904-0x0000000187848954 0x0000000187848D68-0x0000000187848DBC
	public float fDebugOutOfRangeLimit { get; set; } // 0x0000000187848864-0x00000001878488B4 0x0000000186804F60-0x0000000186804FC0
	public bool bDebugOutOfRangeCheckEnabled { get; set; } // 0x00000001878486D4-0x0000000187848724 0x0000000186804EB0-0x0000000186804F10

	// Constructors
	internal AkInitSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0

	// Methods
	internal static IntPtr getCPtr(AkInitSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187848B84-0x0000000187848BAC
	~AkInitSettings(); // 0x0000000186D46B20-0x0000000186D46B70
	public void Dispose(); // 0x0000000187848684-0x00000001878486D4
	protected virtual void Dispose(bool disposing); // 0x0000000186D46B70-0x0000000186D46D00
}

public class AkIterator : IDisposable // TypeDefIndex: 83072
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkPlaylistItem pItem { get; set; } // 0x000000018784963C-0x00000001878496B8 0x00000001878496E0-0x0000000187849748

	// Constructors
	internal AkIterator(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkIterator(); // 0x00000001878495EC-0x000000018784963C

	// Methods
	internal static IntPtr getCPtr(AkIterator obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878496B8-0x00000001878496E0
	~AkIterator(); // 0x0000000187849348-0x00000001878493C0
	public void Dispose(); // 0x00000001878492F8-0x0000000187849348
	protected virtual void Dispose(bool disposing); // 0x00000001878491E8-0x00000001878492F8
	public AkIterator NextIter(); // 0x0000000187849504-0x0000000187849578
	public AkIterator PrevIter(); // 0x0000000187849578-0x00000001878495EC
	public AkPlaylistItem GetItem(); // 0x00000001878493C0-0x0000000187849434
	public bool IsEqualTo(AkIterator in_rOp); // 0x000000018784949C-0x0000000187849504
	public bool IsDifferentFrom(AkIterator in_rOp); // 0x0000000187849434-0x000000018784949C
}

public class AkMarkerCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 83073
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public uint uIdentifier { get; } // 0x000000018784BB8C-0x000000018784BBDC 
	public uint uPosition { get; } // 0x000000018784BBDC-0x000000018784BC2C 
	public string strLabel { get; } // 0x000000018784BB20-0x000000018784BB8C 

	// Constructors
	internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000186124550-0x00000001861245D0
	public AkMarkerCallbackInfo(); // 0x000000018784BAD0-0x000000018784BB20

	// Methods
	internal static IntPtr getCPtr(AkMarkerCallbackInfo obj); // 0x00000001878465C8-0x00000001878465D8
	internal override void setCPtr(IntPtr cPtr); // 0x000000018784BC2C-0x000000018784BC8C
	protected override void Dispose(bool disposing); // 0x000000018784B9A4-0x000000018784BAD0
}

public class AkMemCategroyStats : IDisposable // TypeDefIndex: 83074
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong uUsed { get; set; } // 0x000000018784BF54-0x000000018784BFA4 0x000000018784C0C8-0x000000018784C11C
	public ulong uPeakUsed { get; set; } // 0x000000018784BF04-0x000000018784BF54 0x000000018784C074-0x000000018784C0C8
	public uint uAllocs { get; set; } // 0x000000018784BE64-0x000000018784BEB4 0x000000018784BFCC-0x000000018784C020
	public uint uFrees { get; set; } // 0x000000018784BEB4-0x000000018784BF04 0x000000018784C020-0x000000018784C074

	// Constructors
	internal AkMemCategroyStats(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkMemCategroyStats(); // 0x00000001862FA910-0x00000001862FA960

	// Methods
	internal static IntPtr getCPtr(AkMemCategroyStats obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784BFA4-0x000000018784BFCC
	~AkMemCategroyStats(); // 0x000000018784BDEC-0x000000018784BE64
	public void Dispose(); // 0x000000018784BC8C-0x000000018784BCDC
	protected virtual void Dispose(bool disposing); // 0x000000018784BCDC-0x000000018784BDEC
}

public class AkMemGlobalStats : IDisposable // TypeDefIndex: 83075
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong uUsed { get; set; } // 0x000000018784C434-0x000000018784C484 0x000000018784C5A8-0x000000018784C5FC
	public ulong uDeviceUsed { get; set; } // 0x000000018784C344-0x000000018784C394 0x000000018784C4AC-0x000000018784C500
	public ulong uReserved { get; set; } // 0x000000018784C3E4-0x000000018784C434 0x000000018784C554-0x000000018784C5A8
	public ulong uMax { get; set; } // 0x000000018784C394-0x000000018784C3E4 0x000000018784C500-0x000000018784C554

	// Constructors
	internal AkMemGlobalStats(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkMemGlobalStats(); // 0x000000018784C2F4-0x000000018784C344

	// Methods
	internal static IntPtr getCPtr(AkMemGlobalStats obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784C484-0x000000018784C4AC
	~AkMemGlobalStats(); // 0x000000018784C27C-0x000000018784C2F4
	public void Dispose(); // 0x000000018784C22C-0x000000018784C27C
	protected virtual void Dispose(bool disposing); // 0x000000018784C11C-0x000000018784C22C
}

public enum AkMemID : uint // TypeDefIndex: 83076
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

public enum AkMeteringFlags // TypeDefIndex: 83077
{
	AK_NoMetering = 0,
	AK_EnableBusMeter_Peak = 1,
	AK_EnableBusMeter_TruePeak = 2,
	AK_EnableBusMeter_RMS = 4,
	AK_EnableBusMeter_KPower = 16,
	AK_EnableBusMeter_3DMeter = 32
}

public enum AkMIDICcTypes // TypeDefIndex: 83078
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

public class AkMIDIEvent : IDisposable // TypeDefIndex: 83087
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public byte byChan { get; set; } // 0x000000018784A454-0x000000018784A4A4 0x000000018784AC2C-0x000000018784AC80
	public tGen Gen { get; set; } // 0x000000018784A02C-0x000000018784A0A8 0x000000018784A86C-0x000000018784A8D4
	public tCc Cc { get; set; } // 0x0000000187849F34-0x0000000187849FB0 0x000000018784A79C-0x000000018784A804
	public tNoteOnOff NoteOnOff { get; set; } // 0x000000018784A124-0x000000018784A1A0 0x000000018784A93C-0x000000018784A9A4
	public tPitchBend PitchBend { get; set; } // 0x000000018784A1A0-0x000000018784A21C 0x000000018784A9A4-0x000000018784AA0C
	public tNoteAftertouch NoteAftertouch { get; set; } // 0x000000018784A0A8-0x000000018784A124 0x000000018784A8D4-0x000000018784A93C
	public tChanAftertouch ChanAftertouch { get; set; } // 0x0000000187849FB0-0x000000018784A02C 0x000000018784A804-0x000000018784A86C
	public tProgramChange ProgramChange { get; set; } // 0x000000018784A21C-0x000000018784A298 0x000000018784AA0C-0x000000018784AA74
	public tWwiseCmd WwiseCmd { get; set; } // 0x000000018784A298-0x000000018784A314 0x000000018784AA74-0x000000018784AADC
	public AkMIDIEventTypes byType { get; set; } // 0x000000018784A594-0x000000018784A5E4 0x000000018784AD7C-0x000000018784ADD0
	public byte byOnOffNote { get; set; } // 0x000000018784A4F4-0x000000018784A544 0x000000018784ACD4-0x000000018784AD28
	public byte byVelocity { get; set; } // 0x000000018784A684-0x000000018784A6D4 0x000000018784AE78-0x000000018784AECC
	public AkMIDICcTypes byCc { get; set; } // 0x000000018784A3B4-0x000000018784A404 0x000000018784AB84-0x000000018784ABD8
	public byte byCcValue { get; set; } // 0x000000018784A364-0x000000018784A3B4 0x000000018784AB30-0x000000018784AB84
	public byte byValueLsb { get; set; } // 0x000000018784A5E4-0x000000018784A634 0x000000018784ADD0-0x000000018784AE24
	public byte byValueMsb { get; set; } // 0x000000018784A634-0x000000018784A684 0x000000018784AE24-0x000000018784AE78
	public byte byAftertouchNote { get; set; } // 0x000000018784A314-0x000000018784A364 0x000000018784AADC-0x000000018784AB30
	public byte byNoteAftertouchValue { get; set; } // 0x000000018784A4A4-0x000000018784A4F4 0x000000018784AC80-0x000000018784ACD4
	public byte byChanAftertouchValue { get; set; } // 0x000000018784A404-0x000000018784A454 0x000000018784ABD8-0x000000018784AC2C
	public byte byProgramNum { get; set; } // 0x000000018784A544-0x000000018784A594 0x000000018784AD28-0x000000018784AD7C
	public ushort uCmd { get; set; } // 0x000000018784A724-0x000000018784A774 0x000000018784AF20-0x000000018784AF74
	public uint uArg { get; set; } // 0x000000018784A6D4-0x000000018784A724 0x000000018784AECC-0x000000018784AF20

	// Nested types
	public class tGen : IDisposable // TypeDefIndex: 83079
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byParam1 { get; set; } // 0x000000018786F5CC-0x000000018786F61C 0x000000018786F694-0x000000018786F6E8
		public byte byParam2 { get; set; } // 0x000000018786F61C-0x000000018786F66C 0x000000018786F6E8-0x000000018786F73C

		// Constructors
		internal tGen(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
		public tGen(); // 0x000000018786F57C-0x000000018786F5CC

		// Methods
		internal static IntPtr getCPtr(tGen obj); // 0x0000000187840F78-0x0000000187840F88
		internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786F66C-0x000000018786F694
		~tGen(); // 0x000000018786F504-0x000000018786F57C
		public void Dispose(); // 0x000000018786F3A4-0x000000018786F3F4
		protected virtual void Dispose(bool disposing); // 0x000000018786F3F4-0x000000018786F504
	}

	public class tNoteOnOff : IDisposable // TypeDefIndex: 83080
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byNote { get; set; } // 0x000000018786FCFC-0x000000018786FD4C 0x000000018786FDC4-0x000000018786FE18
		public byte byVelocity { get; set; } // 0x000000018786FD4C-0x000000018786FD9C 0x000000018786FE18-0x000000018786FE6C

		// Constructors
		internal tNoteOnOff(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
		public tNoteOnOff(); // 0x000000018786FCAC-0x000000018786FCFC

		// Methods
		internal static IntPtr getCPtr(tNoteOnOff obj); // 0x0000000187840F78-0x0000000187840F88
		internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786FD9C-0x000000018786FDC4
		~tNoteOnOff(); // 0x000000018786FC34-0x000000018786FCAC
		public void Dispose(); // 0x000000018786FAD4-0x000000018786FB24
		protected virtual void Dispose(bool disposing); // 0x000000018786FB24-0x000000018786FC34
	}

	public class tCc : IDisposable // TypeDefIndex: 83081
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byCc { get; set; } // 0x000000018786EF40-0x000000018786EF90 0x000000018786F008-0x000000018786F05C
		public byte byValue { get; set; } // 0x000000018786EF90-0x000000018786EFE0 0x000000018786F05C-0x000000018786F0B0

		// Constructors
		internal tCc(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
		public tCc(); // 0x000000018786EEF0-0x000000018786EF40

		// Methods
		internal static IntPtr getCPtr(tCc obj); // 0x0000000187840F78-0x0000000187840F88
		internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786EFE0-0x000000018786F008
		~tCc(); // 0x000000018786EE78-0x000000018786EEF0
		public void Dispose(); // 0x000000018786EE28-0x000000018786EE78
		protected virtual void Dispose(bool disposing); // 0x000000018786ED18-0x000000018786EE28
	}

	public class tPitchBend : IDisposable // TypeDefIndex: 83082
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byValueLsb { get; set; } // 0x0000000187870094-0x00000001878700E4 0x000000018787015C-0x00000001878701B0
		public byte byValueMsb { get; set; } // 0x00000001878700E4-0x0000000187870134 0x00000001878701B0-0x0000000187870204

		// Constructors
		internal tPitchBend(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
		public tPitchBend(); // 0x0000000187870044-0x0000000187870094

		// Methods
		internal static IntPtr getCPtr(tPitchBend obj); // 0x0000000187840F78-0x0000000187840F88
		internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187870134-0x000000018787015C
		~tPitchBend(); // 0x000000018786FFCC-0x0000000187870044
		public void Dispose(); // 0x000000018786FF7C-0x000000018786FFCC
		protected virtual void Dispose(bool disposing); // 0x000000018786FE6C-0x000000018786FF7C
	}

	public class tNoteAftertouch : IDisposable // TypeDefIndex: 83083
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byNote { get; set; } // 0x000000018786F964-0x000000018786F9B4 0x000000018786FA2C-0x000000018786FA80
		public byte byValue { get; set; } // 0x000000018786F9B4-0x000000018786FA04 0x000000018786FA80-0x000000018786FAD4

		// Constructors
		internal tNoteAftertouch(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
		public tNoteAftertouch(); // 0x000000018786F914-0x000000018786F964

		// Methods
		internal static IntPtr getCPtr(tNoteAftertouch obj); // 0x0000000187840F78-0x0000000187840F88
		internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786FA04-0x000000018786FA2C
		~tNoteAftertouch(); // 0x000000018786F89C-0x000000018786F914
		public void Dispose(); // 0x000000018786F84C-0x000000018786F89C
		protected virtual void Dispose(bool disposing); // 0x000000018786F73C-0x000000018786F84C
	}

	public class tChanAftertouch : IDisposable // TypeDefIndex: 83084
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byValue { get; set; } // 0x000000018786F2D8-0x000000018786F328 0x000000018786F350-0x000000018786F3A4

		// Constructors
		internal tChanAftertouch(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
		public tChanAftertouch(); // 0x000000018786F288-0x000000018786F2D8

		// Methods
		internal static IntPtr getCPtr(tChanAftertouch obj); // 0x0000000187840F78-0x0000000187840F88
		internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786F328-0x000000018786F350
		~tChanAftertouch(); // 0x000000018786F210-0x000000018786F288
		public void Dispose(); // 0x000000018786F0B0-0x000000018786F100
		protected virtual void Dispose(bool disposing); // 0x000000018786F100-0x000000018786F210
	}

	public class tProgramChange : IDisposable // TypeDefIndex: 83085
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byProgramNum { get; set; } // 0x000000018787042C-0x000000018787047C 0x00000001878704A4-0x00000001878704F8

		// Constructors
		internal tProgramChange(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
		public tProgramChange(); // 0x00000001878703DC-0x000000018787042C

		// Methods
		internal static IntPtr getCPtr(tProgramChange obj); // 0x0000000187840F78-0x0000000187840F88
		internal virtual void setCPtr(IntPtr cPtr); // 0x000000018787047C-0x00000001878704A4
		~tProgramChange(); // 0x0000000187870364-0x00000001878703DC
		public void Dispose(); // 0x0000000187870204-0x0000000187870254
		protected virtual void Dispose(bool disposing); // 0x0000000187870254-0x0000000187870364
	}

	public class tWwiseCmd : IDisposable // TypeDefIndex: 83086
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public ushort uCmd { get; set; } // 0x0000000187870770-0x00000001878707C0 0x000000018787083C-0x0000000187870890
		public uint uArg { get; set; } // 0x0000000187870720-0x0000000187870770 0x00000001878707E8-0x000000018787083C

		// Constructors
		internal tWwiseCmd(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
		public tWwiseCmd(); // 0x00000001878706D0-0x0000000187870720

		// Methods
		internal static IntPtr getCPtr(tWwiseCmd obj); // 0x0000000187840F78-0x0000000187840F88
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878707C0-0x00000001878707E8
		~tWwiseCmd(); // 0x0000000187870658-0x00000001878706D0
		public void Dispose(); // 0x00000001878704F8-0x0000000187870548
		protected virtual void Dispose(bool disposing); // 0x0000000187870548-0x0000000187870658
	}

	// Constructors
	internal AkMIDIEvent(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkMIDIEvent(); // 0x0000000187849EE4-0x0000000187849F34

	// Methods
	internal static IntPtr getCPtr(AkMIDIEvent obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784A774-0x000000018784A79C
	~AkMIDIEvent(); // 0x0000000187843D90-0x0000000187843E0C
	public void Dispose(); // 0x0000000187849D84-0x0000000187849DD4
	protected virtual void Dispose(bool disposing); // 0x0000000187849DD4-0x0000000187849EE4
}

public class AkMIDIEventCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 83088
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public byte byChan { get; } // 0x0000000187849A04-0x0000000187849A54 
	public byte byParam1 { get; } // 0x0000000187849AF4-0x0000000187849B44 
	public byte byParam2 { get; } // 0x0000000187849B44-0x0000000187849B94 
	public AkMIDIEventTypes byType { get; } // 0x0000000187849BE4-0x0000000187849C34 
	public byte byOnOffNote { get; } // 0x0000000187849AA4-0x0000000187849AF4 
	public byte byVelocity { get; } // 0x0000000187849CD4-0x0000000187849D24 
	public AkMIDICcTypes byCc { get; } // 0x0000000187849964-0x00000001878499B4 
	public byte byCcValue { get; } // 0x0000000187849914-0x0000000187849964 
	public byte byValueLsb { get; } // 0x0000000187849C34-0x0000000187849C84 
	public byte byValueMsb { get; } // 0x0000000187849C84-0x0000000187849CD4 
	public byte byAftertouchNote { get; } // 0x00000001878498C4-0x0000000187849914 
	public byte byNoteAftertouchValue { get; } // 0x0000000187849A54-0x0000000187849AA4 
	public byte byChanAftertouchValue { get; } // 0x00000001878499B4-0x0000000187849A04 
	public byte byProgramNum { get; } // 0x0000000187849B94-0x0000000187849BE4 

	// Constructors
	internal AkMIDIEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000186124450-0x00000001861244D0
	public AkMIDIEventCallbackInfo(); // 0x0000000187849874-0x00000001878498C4

	// Methods
	internal static IntPtr getCPtr(AkMIDIEventCallbackInfo obj); // 0x00000001878465C8-0x00000001878465D8
	internal override void setCPtr(IntPtr cPtr); // 0x0000000187849D24-0x0000000187849D84
	protected override void Dispose(bool disposing); // 0x0000000187849748-0x0000000187849874
}

public enum AkMIDIEventTypes // TypeDefIndex: 83089
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

public class AkMIDIPost : AkMIDIEvent // TypeDefIndex: 83090
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public ulong uOffset { get; set; } // 0x000000018784B8A0-0x000000018784B8F0 0x000000018784B950-0x000000018784B9A4

	// Constructors
	internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn); // 0x000000018784B7E8-0x000000018784B850
	public AkMIDIPost(); // 0x000000018784B850-0x000000018784B8A0

	// Methods
	internal static IntPtr getCPtr(AkMIDIPost obj); // 0x0000000187846944-0x0000000187846954
	internal override void setCPtr(IntPtr cPtr); // 0x000000018784B8F0-0x000000018784B950
	protected override void Dispose(bool disposing); // 0x000000018784AFDC-0x000000018784B108
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts); // 0x000000018784B33C-0x000000018784B3DC
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets); // 0x000000018784B3DC-0x000000018784B484
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x000000018784B530-0x000000018784B644
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID); // 0x000000018784B148-0x000000018784B268
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts); // 0x000000018784B744-0x000000018784B7E8
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets); // 0x000000018784B484-0x000000018784B530
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x000000018784B268-0x000000018784B33C
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID); // 0x000000018784B644-0x000000018784B744
	public void Clone(AkMIDIPost other); // 0x000000018784AF74-0x000000018784AFDC
	public static int GetSizeOf(); // 0x000000018784B108-0x000000018784B148
}

public enum AkMonitorErrorCode // TypeDefIndex: 83091
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

public enum AkMonitorErrorLevel // TypeDefIndex: 83092
{
	ErrorLevel_Message = 1,
	ErrorLevel_Error = 2,
	ErrorLevel_All = 3
}

public class AkMonitoringCallbackInfo : IDisposable // TypeDefIndex: 83093
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkMonitorErrorCode errorCode { get; } // 0x000000018784C824-0x000000018784C874 
	public AkMonitorErrorLevel errorLevel { get; } // 0x000000018784C874-0x000000018784C8C4 
	public uint playingID { get; } // 0x000000018784C980-0x000000018784C9D0 
	public ulong gameObjID { get; } // 0x000000018784C8C4-0x000000018784C914 
	public string message { get; } // 0x000000018784C914-0x000000018784C980 

	// Constructors
	internal AkMonitoringCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkMonitoringCallbackInfo(); // 0x000000018784C7D4-0x000000018784C824

	// Methods
	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784C9D0-0x000000018784C9F8
	~AkMonitoringCallbackInfo(); // 0x000000018784C75C-0x000000018784C7D4
	public void Dispose(); // 0x000000018784C70C-0x000000018784C75C
	protected virtual void Dispose(bool disposing); // 0x000000018784C5FC-0x000000018784C70C
}

public enum AkMultiPositionType // TypeDefIndex: 83094
{
	MultiPositionType_SingleSource = 0,
	MultiPositionType_MultiSources = 1,
	MultiPositionType_MultiDirections = 2
}

public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 83095
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public uint playlistID { get; } // 0x000000018784CB74-0x000000018784CBC4 
	public uint uNumPlaylistItems { get; } // 0x000000018784CBC4-0x000000018784CC14 
	public uint uPlaylistSelection { get; } // 0x000000018784CC64-0x000000018784CCB4 
	public uint uPlaylistItemDone { get; } // 0x000000018784CC14-0x000000018784CC64 

	// Constructors
	internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000186124350-0x00000001861243D0
	public AkMusicPlaylistCallbackInfo(); // 0x000000018784CB24-0x000000018784CB74

	// Methods
	internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj); // 0x00000001878465C8-0x00000001878465D8
	internal override void setCPtr(IntPtr cPtr); // 0x000000018784CCB4-0x000000018784CD14
	protected override void Dispose(bool disposing); // 0x000000018784C9F8-0x000000018784CB24
}

public class AkMusicSettings : IDisposable // TypeDefIndex: 83096
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fStreamingLookAheadRatio { get; set; } // 0x000000018784CD64-0x000000018784CDB4 0x00000001868052A0-0x0000000186805300

	// Constructors
	internal AkMusicSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0

	// Methods
	internal static IntPtr getCPtr(AkMusicSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784CDB4-0x000000018784CDDC
	~AkMusicSettings(); // 0x0000000186ED8C40-0x0000000186ED8C90
	public void Dispose(); // 0x000000018784CD14-0x000000018784CD64
	protected virtual void Dispose(bool disposing); // 0x0000000186ED8C90-0x0000000186ED8E10
}

public class AkMusicSyncCallbackInfo : AkCallbackInfo // TypeDefIndex: 83097
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get; } // 0x000000018784CFA8-0x000000018784CFF8 
	public int segmentInfo_iCurrentPosition { get; } // 0x000000018784D188-0x000000018784D1D8 
	public int segmentInfo_iPreEntryDuration { get; } // 0x000000018784D228-0x000000018784D278 
	public int segmentInfo_iActiveDuration { get; } // 0x000000018784D138-0x000000018784D188 
	public int segmentInfo_iPostExitDuration { get; } // 0x000000018784D1D8-0x000000018784D228 
	public int segmentInfo_iRemainingLookAheadTime { get; } // 0x000000018784D278-0x000000018784D2C8 
	public float segmentInfo_fBeatDuration { get; } // 0x000000018784D048-0x000000018784D098 
	public float segmentInfo_fBarDuration { get; } // 0x000000018784CFF8-0x000000018784D048 
	public float segmentInfo_fGridDuration { get; } // 0x000000018784D098-0x000000018784D0E8 
	public float segmentInfo_fGridOffset { get; } // 0x000000018784D0E8-0x000000018784D138 
	public AkCallbackType musicSyncType { get; } // 0x000000018784CF58-0x000000018784CFA8 
	public string userCueName { get; } // 0x000000018784D2C8-0x000000018784D334 

	// Constructors
	internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x00000001861241F0-0x0000000186124260
	public AkMusicSyncCallbackInfo(); // 0x000000018784CF08-0x000000018784CF58

	// Methods
	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj); // 0x0000000187846944-0x0000000187846954
	internal override void setCPtr(IntPtr cPtr); // 0x000000018784D334-0x000000018784D394
	protected override void Dispose(bool disposing); // 0x000000018784CDDC-0x000000018784CF08
}

public class AkObjectInfo : IDisposable // TypeDefIndex: 83098
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint objID { get; set; } // 0x000000018784D704-0x000000018784D754 0x000000018784D820-0x000000018784D874
	public uint parentID { get; set; } // 0x000000018784D754-0x000000018784D7A4 0x000000018784D874-0x000000018784D8C8
	public int iDepth { get; set; } // 0x000000018784D6B4-0x000000018784D704 0x000000018784D7CC-0x000000018784D820

	// Constructors
	internal AkObjectInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkObjectInfo(); // 0x000000018784D664-0x000000018784D6B4

	// Methods
	internal static IntPtr getCPtr(AkObjectInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784D7A4-0x000000018784D7CC
	~AkObjectInfo(); // 0x000000018784D5AC-0x000000018784D624
	public void Dispose(); // 0x000000018784D55C-0x000000018784D5AC
	protected virtual void Dispose(bool disposing); // 0x000000018784D44C-0x000000018784D55C
	public void Clear(); // 0x000000018784D394-0x000000018784D3E4
	public static int GetSizeOf(); // 0x000000018784D624-0x000000018784D664
	public void Clone(AkObjectInfo other); // 0x000000018784D3E4-0x000000018784D44C
}

public class AkObstructionOcclusionValues : IDisposable // TypeDefIndex: 83099
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float occlusion { get; set; } // 0x000000018784DC38-0x000000018784DC88 0x000000018784DD08-0x000000018784DD60
	public float obstruction { get; set; } // 0x000000018784DBE8-0x000000018784DC38 0x000000018784DCB0-0x000000018784DD08

	// Constructors
	internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkObstructionOcclusionValues(); // 0x000000018784DB98-0x000000018784DBE8

	// Methods
	internal static IntPtr getCPtr(AkObstructionOcclusionValues obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784DC88-0x000000018784DCB0
	~AkObstructionOcclusionValues(); // 0x000000018784DAE0-0x000000018784DB58
	public void Dispose(); // 0x000000018784DA90-0x000000018784DAE0
	protected virtual void Dispose(bool disposing); // 0x000000018784D980-0x000000018784DA90
	public void Clear(); // 0x000000018784D8C8-0x000000018784D918
	public static int GetSizeOf(); // 0x000000018784DB58-0x000000018784DB98
	public void Clone(AkObstructionOcclusionValues other); // 0x000000018784D918-0x000000018784D980
}

public class AkOutputSettings : IDisposable // TypeDefIndex: 83100
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioDeviceShareset { get; set; } // 0x000000018784DFD8-0x000000018784E028 0x00000001850C9850-0x00000001850C98B0
	public uint idDevice { get; set; } // 0x000000018784E078-0x000000018784E0C8 0x00000001850C97B0-0x00000001850C9810
	public AkPanningRule ePanningRule { get; set; } // 0x000000018784E028-0x000000018784E078 0x00000001850C9710-0x00000001850C9770
	public AkChannelConfig channelConfig { get; set; } // 0x00000001850C9560-0x00000001850C95F0 0x000000018784E0F0-0x000000018784E158

	// Constructors
	internal AkOutputSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkOutputSettings(); // 0x000000018784DF88-0x000000018784DFD8
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning); // 0x000000018784DEFC-0x000000018784DF88
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig); // 0x000000018784DE08-0x000000018784DE94
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice); // 0x000000018784DE94-0x000000018784DEFC
	public AkOutputSettings(string in_szDeviceShareSet); // 0x000000018784DDB0-0x000000018784DE08

	// Methods
	internal static IntPtr getCPtr(AkOutputSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784E0C8-0x000000018784E0F0
	~AkOutputSettings(); // 0x0000000186ED8A70-0x0000000186ED8AC0
	public void Dispose(); // 0x000000018784DD60-0x000000018784DDB0
	protected virtual void Dispose(bool disposing); // 0x0000000186ED8AC0-0x0000000186ED8C40
}

public enum AkPanningRule // TypeDefIndex: 83101
{
	AkPanningRule_Speakers = 0,
	AkPanningRule_Headphones = 1
}

public class AkPlaylist : AkPlaylistArray // TypeDefIndex: 83102
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Constructors
	internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn); // 0x000000018785004C-0x00000001878500B4
	public AkPlaylist(); // 0x000000018784FFFC-0x000000018785004C

	// Methods
	internal static IntPtr getCPtr(AkPlaylist obj); // 0x0000000187846944-0x0000000187846954
	internal override void setCPtr(IntPtr cPtr); // 0x00000001878500B4-0x0000000187850114
	protected override void Dispose(bool disposing); // 0x000000018784FC78-0x000000018784FDA4
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x000000018784FED4-0x000000018784FF84
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals); // 0x000000018784FE08-0x000000018784FE80
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo); // 0x000000018784FF84-0x000000018784FFFC
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay); // 0x000000018784FDA4-0x000000018784FE08
	public AKRESULT Enqueue(uint in_audioNodeID); // 0x000000018784FE80-0x000000018784FED4
}

public class AkPlaylistArray : IDisposable // TypeDefIndex: 83103
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkPlaylistArray(); // 0x000000018784F5E0-0x000000018784F630

	// Methods
	internal static IntPtr getCPtr(AkPlaylistArray obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784F630-0x000000018784F658
	~AkPlaylistArray(); // 0x0000000187843D90-0x0000000187843E0C
	public void Dispose(); // 0x000000018784EB14-0x000000018784EB64
	protected virtual void Dispose(bool disposing); // 0x000000018784EA04-0x000000018784EB14
	public AkIterator Begin(); // 0x000000018784E8AC-0x000000018784E920
	public AkIterator End(); // 0x000000018784EB64-0x000000018784EBD8
	public AkIterator FindEx(AkPlaylistItem in_Item); // 0x000000018784EE38-0x000000018784EEC8
	public AkIterator Erase(AkIterator in_rIter); // 0x000000018784ECBC-0x000000018784ED4C
	public void Erase(uint in_uIndex); // 0x000000018784ED4C-0x000000018784EDA0
	public AkIterator EraseSwap(AkIterator in_rIter); // 0x000000018784EBD8-0x000000018784EC68
	public void EraseSwap(uint in_uIndex); // 0x000000018784EC68-0x000000018784ECBC
	public bool IsGrowingAllowed(); // 0x000000018784F0D4-0x000000018784F124
	public AKRESULT Reserve(uint in_ulReserve); // 0x000000018784F430-0x000000018784F484
	public AKRESULT ReserveExtra(uint in_ulReserve); // 0x000000018784F3DC-0x000000018784F430
	public uint Reserved(); // 0x000000018784F484-0x000000018784F4D4
	public void Term(); // 0x000000018784F528-0x000000018784F578
	public uint Length(); // 0x000000018784F21C-0x000000018784F26C
	public AkPlaylistItem Data(); // 0x000000018784E988-0x000000018784EA04
	public bool IsEmpty(); // 0x000000018784F084-0x000000018784F0D4
	public AkPlaylistItem Exists(AkPlaylistItem in_Item); // 0x000000018784EDA0-0x000000018784EE38
	public AkPlaylistItem AddLast(); // 0x000000018784E798-0x000000018784E814
	public AkPlaylistItem AddLast(AkPlaylistItem in_rItem); // 0x000000018784E814-0x000000018784E8AC
	public AkPlaylistItem Last(); // 0x000000018784F1A8-0x000000018784F21C
	public void RemoveLast(); // 0x000000018784F2BC-0x000000018784F30C
	public AKRESULT Remove(AkPlaylistItem in_rItem); // 0x000000018784F374-0x000000018784F3DC
	public AKRESULT RemoveSwap(AkPlaylistItem in_rItem); // 0x000000018784F30C-0x000000018784F374
	public void RemoveAll(); // 0x000000018784F26C-0x000000018784F2BC
	public AkPlaylistItem ItemAtIndex(uint uiIndex); // 0x000000018784F124-0x000000018784F1A8
	public AkIterator Insert(AkIterator in_rIter); // 0x000000018784EFF4-0x000000018784F084
	public AkPlaylistItem Insert(uint in_uIndex); // 0x000000018784EF6C-0x000000018784EFF4
	public bool GrowArray(); // 0x000000018784EEC8-0x000000018784EF18
	public bool GrowArray(uint in_uGrowBy); // 0x000000018784EF18-0x000000018784EF6C
	public bool Resize(uint in_uiSize); // 0x000000018784F4D4-0x000000018784F528
	public void Transfer(AkPlaylistArray in_rSource); // 0x000000018784F578-0x000000018784F5E0
	public AKRESULT Copy(AkPlaylistArray in_rSource); // 0x000000018784E920-0x000000018784E988
}

public class AkPlaylistItem : IDisposable // TypeDefIndex: 83104
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioNodeID { get; set; } // 0x000000018784FA64-0x000000018784FAB4 0x000000018784FB7C-0x000000018784FBD0
	public int msDelay { get; set; } // 0x000000018784FAB4-0x000000018784FB04 0x000000018784FBD0-0x000000018784FC24
	public IntPtr pCustomInfo { get; set; } // 0x000000018784FB04-0x000000018784FB54 0x000000018784FC24-0x000000018784FC78

	// Constructors
	internal AkPlaylistItem(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkPlaylistItem(); // 0x000000018784F9A8-0x000000018784F9F8
	public AkPlaylistItem(AkPlaylistItem in_rCopy); // 0x000000018784F9F8-0x000000018784FA64

	// Methods
	internal static IntPtr getCPtr(AkPlaylistItem obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784FB54-0x000000018784FB7C
	~AkPlaylistItem(); // 0x000000018784F848-0x000000018784F8C0
	public void Dispose(); // 0x000000018784F7F8-0x000000018784F848
	protected virtual void Dispose(bool disposing); // 0x000000018784F6E8-0x000000018784F7F8
	public AkPlaylistItem Assign(AkPlaylistItem in_rCopy); // 0x000000018784F658-0x000000018784F6E8
	public bool IsEqualTo(AkPlaylistItem in_rCopy); // 0x000000018784F8C0-0x000000018784F928
	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc); // 0x000000018784F928-0x000000018784F9A8
}

public enum AkPluginType // TypeDefIndex: 83105
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

public class AkPositioningData : IDisposable // TypeDefIndex: 83106
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Ak3dData threeD { get; set; } // 0x00000001878503B8-0x0000000187850434 0x00000001878504C4-0x000000018785052C
	public AkBehavioralPositioningData behavioral { get; set; } // 0x000000018785033C-0x00000001878503B8 0x000000018785045C-0x00000001878504C4

	// Constructors
	internal AkPositioningData(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkPositioningData(); // 0x00000001878502EC-0x000000018785033C

	// Methods
	internal static IntPtr getCPtr(AkPositioningData obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187850434-0x000000018785045C
	~AkPositioningData(); // 0x0000000187850274-0x00000001878502EC
	public void Dispose(); // 0x0000000187850114-0x0000000187850164
	protected virtual void Dispose(bool disposing); // 0x0000000187850164-0x0000000187850274
}

public class AkPositioningInfo : IDisposable // TypeDefIndex: 83107
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fCenterPct { get; set; } // 0x0000000187850A24-0x0000000187850A74 0x0000000187851020-0x0000000187851078
	public AkSpeakerPanningType pannerType { get; set; } // 0x0000000187850CA4-0x0000000187850CF4 0x00000001878512E0-0x0000000187851334
	public Ak3DPositionType e3dPositioningType { get; set; } // 0x00000001878509D4-0x0000000187850A24 0x0000000187850FCC-0x0000000187851020
	public bool bHoldEmitterPosAndOrient { get; set; } // 0x00000001878508E4-0x0000000187850934 0x0000000187850ED0-0x0000000187850F24
	public Ak3DSpatializationMode e3DSpatializationMode { get; set; } // 0x0000000187850984-0x00000001878509D4 0x0000000187850F78-0x0000000187850FCC
	public bool bEnableAttenuation { get; set; } // 0x0000000187850894-0x00000001878508E4 0x0000000187850E7C-0x0000000187850ED0
	public bool bUseConeAttenuation { get; set; } // 0x0000000187850934-0x0000000187850984 0x0000000187850F24-0x0000000187850F78
	public float fInnerAngle { get; set; } // 0x0000000187850AC4-0x0000000187850B14 0x00000001878510D0-0x0000000187851128
	public float fOuterAngle { get; set; } // 0x0000000187850B64-0x0000000187850BB4 0x0000000187851180-0x00000001878511D8
	public float fConeMaxAttenuation { get; set; } // 0x0000000187850A74-0x0000000187850AC4 0x0000000187851078-0x00000001878510D0
	public float LPFCone { get; set; } // 0x00000001878507F4-0x0000000187850844 0x0000000187850DCC-0x0000000187850E24
	public float HPFCone { get; set; } // 0x0000000187850754-0x00000001878507A4 0x0000000187850D1C-0x0000000187850D74
	public float fMaxDistance { get; set; } // 0x0000000187850B14-0x0000000187850B64 0x0000000187851128-0x0000000187851180
	public float fVolDryAtMaxDist { get; set; } // 0x0000000187850C54-0x0000000187850CA4 0x0000000187851288-0x00000001878512E0
	public float fVolAuxGameDefAtMaxDist { get; set; } // 0x0000000187850BB4-0x0000000187850C04 0x00000001878511D8-0x0000000187851230
	public float fVolAuxUserDefAtMaxDist { get; set; } // 0x0000000187850C04-0x0000000187850C54 0x0000000187851230-0x0000000187851288
	public float LPFValueAtMaxDist { get; set; } // 0x0000000187850844-0x0000000187850894 0x0000000187850E24-0x0000000187850E7C
	public float HPFValueAtMaxDist { get; set; } // 0x00000001878507A4-0x00000001878507F4 0x0000000187850D74-0x0000000187850DCC

	// Constructors
	internal AkPositioningInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkPositioningInfo(); // 0x0000000187850704-0x0000000187850754

	// Methods
	internal static IntPtr getCPtr(AkPositioningInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187850CF4-0x0000000187850D1C
	~AkPositioningInfo(); // 0x000000018785068C-0x0000000187850704
	public void Dispose(); // 0x000000018785052C-0x000000018785057C
	protected virtual void Dispose(bool disposing); // 0x000000018785057C-0x000000018785068C
}

public enum AkPreparationType // TypeDefIndex: 83108
{
	Preparation_Load = 0,
	Preparation_Unload = 1,
	Preparation_LoadAndDecode = 2
}

public enum AkQueryRTPCValue // TypeDefIndex: 83109
{
	RTPCValue_Default = 0,
	RTPCValue_Global = 1,
	RTPCValue_GameObject = 2,
	RTPCValue_PlayingID = 3,
	RTPCValue_Unavailable = 4
}

public class AkRamp : IDisposable // TypeDefIndex: 83110
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fPrev { get; set; } // 0x0000000187851614-0x0000000187851664 0x00000001878516E4-0x000000018785173C
	public float fNext { get; set; } // 0x00000001878515C4-0x0000000187851614 0x000000018785168C-0x00000001878516E4

	// Constructors
	internal AkRamp(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkRamp(); // 0x0000000187851574-0x00000001878515C4
	public AkRamp(float in_fPrev, float in_fNext); // 0x000000018785150C-0x0000000187851574

	// Methods
	internal static IntPtr getCPtr(AkRamp obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187851664-0x000000018785168C
	~AkRamp(); // 0x0000000187851494-0x000000018785150C
	public void Dispose(); // 0x0000000187851444-0x0000000187851494
	protected virtual void Dispose(bool disposing); // 0x0000000187851334-0x0000000187851444
}

public class AkReflectionPathInfo : IDisposable // TypeDefIndex: 83111
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkVector64 imageSource { get; set; } // 0x0000000187851B5C-0x0000000187851BC8 0x0000000187851D30-0x0000000187851D9C
	public uint numPathPoints { get; set; } // 0x0000000187851C68-0x0000000187851CB8 0x0000000187851E48-0x0000000187851E9C
	public uint numReflections { get; set; } // 0x0000000187851CB8-0x0000000187851D08 0x0000000187851E9C-0x0000000187851EF0
	public float level { get; set; } // 0x0000000187851C18-0x0000000187851C68 0x0000000187851DF0-0x0000000187851E48
	public bool isOccluded { get; set; } // 0x0000000187851BC8-0x0000000187851C18 0x0000000187851D9C-0x0000000187851DF0

	// Constructors
	internal AkReflectionPathInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkReflectionPathInfo(); // 0x0000000187851B0C-0x0000000187851B5C

	// Methods
	internal static IntPtr getCPtr(AkReflectionPathInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187851D08-0x0000000187851D30
	~AkReflectionPathInfo(); // 0x0000000187851904-0x000000018785197C
	public void Dispose(); // 0x00000001878517A4-0x00000001878517F4
	protected virtual void Dispose(bool disposing); // 0x00000001878517F4-0x0000000187851904
	public static int GetSizeOf(); // 0x0000000187851ACC-0x0000000187851B0C
	public Vector3 GetPathPoint(uint idx); // 0x0000000187851A54-0x0000000187851ACC
	public AkAcousticSurface GetAcousticSurface(uint idx); // 0x000000018785197C-0x0000000187851A00
	public float GetDiffraction(uint idx); // 0x0000000187851A00-0x0000000187851A54
	public void Clone(AkReflectionPathInfo other); // 0x000000018785173C-0x00000001878517A4
}

public class AkResourceMonitorDataSummary : IDisposable // TypeDefIndex: 83112
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float totalCPU { get; set; } // 0x00000001878521B8-0x0000000187852208 0x00000001878523D0-0x0000000187852428
	public float pluginCPU { get; set; } // 0x0000000187852168-0x00000001878521B8 0x0000000187852378-0x00000001878523D0
	public uint physicalVoices { get; set; } // 0x0000000187852118-0x0000000187852168 0x0000000187852324-0x0000000187852378
	public uint virtualVoices { get; set; } // 0x0000000187852258-0x00000001878522A8 0x000000018785247C-0x00000001878524D0
	public uint totalVoices { get; set; } // 0x0000000187852208-0x0000000187852258 0x0000000187852428-0x000000018785247C
	public uint nbActiveEvents { get; set; } // 0x00000001878520C8-0x0000000187852118 0x00000001878522D0-0x0000000187852324

	// Constructors
	internal AkResourceMonitorDataSummary(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkResourceMonitorDataSummary(); // 0x00000001865E93E0-0x00000001865E9430

	// Methods
	internal static IntPtr getCPtr(AkResourceMonitorDataSummary obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001878522A8-0x00000001878522D0
	~AkResourceMonitorDataSummary(); // 0x0000000187852050-0x00000001878520C8
	public void Dispose(); // 0x0000000187851EF0-0x0000000187851F40
	protected virtual void Dispose(bool disposing); // 0x0000000187851F40-0x0000000187852050
}

public enum AKRESULT // TypeDefIndex: 83113
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

public class AkRoomParams : IDisposable // TypeDefIndex: 83114
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Vector3 Front { get; set; } // 0x00000001878526A8-0x0000000187852710 0x000000018566C1F0-0x000000018566C280
	public Vector3 Up { get; set; } // 0x00000001878528F0-0x0000000187852958 0x000000018566C110-0x000000018566C1A0
	public uint ReverbAuxBus { get; set; } // 0x0000000187852710-0x0000000187852760 0x000000018566BD70-0x000000018566BDD0
	public float ReverbLevel { get; set; } // 0x0000000187852760-0x00000001878527B0 0x000000018566C050-0x000000018566C0C0
	public float TransmissionLoss { get; set; } // 0x00000001878528A0-0x00000001878528F0 0x000000018566BF90-0x000000018566C000
	public float RoomGameObj_AuxSendLevelToSelf { get; set; } // 0x00000001878527B0-0x0000000187852800 0x000000018566BED0-0x000000018566BF40
	public bool RoomGameObj_KeepRegistered { get; set; } // 0x0000000187852800-0x0000000187852850 0x000000018566BE20-0x000000018566BE90
	public uint RoomPriority { get; set; } // 0x0000000187852850-0x00000001878528A0 0x000000018566BCC0-0x000000018566BD20

	// Constructors
	internal AkRoomParams(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkRoomParams(); // 0x00000001862FAB70-0x00000001862FABC0

	// Methods
	internal static IntPtr getCPtr(AkRoomParams obj); // 0x000000018566BC30-0x000000018566BC40
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187852958-0x0000000187852980
	~AkRoomParams(); // 0x0000000187852630-0x00000001878526A8
	public void Dispose(); // 0x00000001878525E0-0x0000000187852630
	protected virtual void Dispose(bool disposing); // 0x00000001878524D0-0x00000001878525E0
}

public class AkSegmentInfo : IDisposable // TypeDefIndex: 83115
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int iCurrentPosition { get; set; } // 0x0000000187852D38-0x0000000187852D88 0x0000000187853054-0x00000001878530A8
	public int iPreEntryDuration { get; set; } // 0x0000000187852DD8-0x0000000187852E28 0x00000001878530FC-0x0000000187853150
	public int iActiveDuration { get; set; } // 0x0000000187852CE8-0x0000000187852D38 0x0000000187853000-0x0000000187853054
	public int iPostExitDuration { get; set; } // 0x0000000187852D88-0x0000000187852DD8 0x00000001878530A8-0x00000001878530FC
	public int iRemainingLookAheadTime { get; set; } // 0x0000000187852E28-0x0000000187852E78 0x0000000187853150-0x00000001878531A4
	public float fBeatDuration { get; set; } // 0x0000000187852BF8-0x0000000187852C48 0x0000000187852EF8-0x0000000187852F50
	public float fBarDuration { get; set; } // 0x0000000187852BA8-0x0000000187852BF8 0x0000000187852EA0-0x0000000187852EF8
	public float fGridDuration { get; set; } // 0x0000000187852C48-0x0000000187852C98 0x0000000187852F50-0x0000000187852FA8
	public float fGridOffset { get; set; } // 0x0000000187852C98-0x0000000187852CE8 0x0000000187852FA8-0x0000000187853000

	// Constructors
	internal AkSegmentInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkSegmentInfo(); // 0x0000000187852B58-0x0000000187852BA8

	// Methods
	internal static IntPtr getCPtr(AkSegmentInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187852E78-0x0000000187852EA0
	~AkSegmentInfo(); // 0x0000000187852AE0-0x0000000187852B58
	public void Dispose(); // 0x0000000187852980-0x00000001878529D0
	protected virtual void Dispose(bool disposing); // 0x00000001878529D0-0x0000000187852AE0
}

public class AkSerializedCallbackHeader : IDisposable // TypeDefIndex: 83116
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pPackage { get; } // 0x00000001878534E8-0x0000000187853538 
	public uint eType { get; } // 0x000000018785341C-0x000000018785346C 
	public AkSerializedCallbackHeader pNext { get; } // 0x000000018785346C-0x00000001878534E8 

	// Constructors
	internal AkSerializedCallbackHeader(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkSerializedCallbackHeader(); // 0x00000001878533CC-0x000000018785341C

	// Methods
	internal static IntPtr getCPtr(AkSerializedCallbackHeader obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187853538-0x0000000187853560
	~AkSerializedCallbackHeader(); // 0x0000000187853304-0x000000018785337C
	public void Dispose(); // 0x00000001878531A4-0x00000001878531F4
	protected virtual void Dispose(bool disposing); // 0x00000001878531F4-0x0000000187853304
	public IntPtr GetData(); // 0x000000018785337C-0x00000001878533CC
}

public enum AkSetPositionFlags // TypeDefIndex: 83117
{
	AkSetPositionFlags_Emitter = 1,
	AkSetPositionFlags_Listener = 2,
	AkSetPositionFlags_Default = 3
}

public enum AkSourceChannelOrdering // TypeDefIndex: 83118
{
	SourceChannelOrdering_Standard = 0,
	SourceChannelOrdering_Film = 1,
	SourceChannelOrdering_FuMa = 2,
	SourceChannelOrdering_Last = 3
}

public class AkSourceSettings : IDisposable // TypeDefIndex: 83119
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint sourceID { get; set; } // 0x000000018786C3B0-0x000000018786C400 0x000000018786C4CC-0x000000018786C520
	public IntPtr pMediaMemory { get; set; } // 0x000000018786C360-0x000000018786C3B0 0x000000018786C478-0x000000018786C4CC
	public uint uMediaSize { get; set; } // 0x000000018786C400-0x000000018786C450 0x000000018786C520-0x000000018786C574

	// Constructors
	internal AkSourceSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkSourceSettings(); // 0x000000018786C310-0x000000018786C360

	// Methods
	internal static IntPtr getCPtr(AkSourceSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786C450-0x000000018786C478
	~AkSourceSettings(); // 0x000000018786C258-0x000000018786C2D0
	public void Dispose(); // 0x000000018786C0F8-0x000000018786C148
	protected virtual void Dispose(bool disposing); // 0x000000018786C148-0x000000018786C258
	public void Clear(); // 0x000000018786C040-0x000000018786C090
	public static int GetSizeOf(); // 0x000000018786C2D0-0x000000018786C310
	public void Clone(AkSourceSettings other); // 0x000000018786C090-0x000000018786C0F8
}

public class AkSpatialAudioInitSettings : IDisposable // TypeDefIndex: 83120
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxSoundPropagationDepth { get; set; } // 0x000000018786C7F4-0x000000018786C844 0x0000000186806820-0x0000000186806880
	public float fMovementThreshold { get; set; } // 0x000000018786C704-0x000000018786C754 0x0000000186806BD0-0x0000000186806C40
	public uint uNumberOfPrimaryRays { get; set; } // 0x00000001862E6830-0x00000001862E6880 0x0000000186806770-0x00000001868067D0
	public uint uMaxReflectionOrder { get; set; } // 0x00000001862E67A0-0x00000001862E67F0 0x00000001868066C0-0x0000000186806720
	public uint uMaxDiffractionOrder { get; set; } // 0x00000001862E6710-0x00000001862E6760 0x0000000186806610-0x0000000186806670
	public uint uMaxEmitterRoomAuxSends { get; set; } // 0x000000018786C7A4-0x000000018786C7F4 0x0000000186806560-0x00000001868065C0
	public uint uDiffractionOnReflectionsOrder { get; set; } // 0x000000018786C754-0x000000018786C7A4 0x00000001868064B0-0x0000000186806510
	public float fMaxPathLength { get; set; } // 0x000000018786C6B4-0x000000018786C704 0x0000000186806B10-0x0000000186806B80
	public float fCPULimitPercentage { get; set; } // 0x000000018786C664-0x000000018786C6B4 0x0000000186806A50-0x0000000186806AC0
	public uint uLoadBalancingSpread { get; set; } // 0x00000001862E6680-0x00000001862E66D0 0x0000000186806400-0x0000000186806460
	public bool bEnableGeometricDiffractionAndTransmission { get; set; } // 0x000000018786C614-0x000000018786C664 0x0000000186806990-0x0000000186806A00
	public bool bCalcEmitterVirtualPosition { get; set; } // 0x000000018786C5C4-0x000000018786C614 0x00000001868068D0-0x0000000186806940

	// Constructors
	internal AkSpatialAudioInitSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkSpatialAudioInitSettings(); // 0x0000000186806200-0x0000000186806260

	// Methods
	internal static IntPtr getCPtr(AkSpatialAudioInitSettings obj); // 0x000000018566BC30-0x000000018566BC40
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786C844-0x000000018786C86C
	~AkSpatialAudioInitSettings(); // 0x0000000186C36AA0-0x0000000186C36AF0
	public void Dispose(); // 0x000000018786C574-0x000000018786C5C4
	protected virtual void Dispose(bool disposing); // 0x0000000186C36AF0-0x0000000186C36D00
}

public enum AkSpeakerPanningType // TypeDefIndex: 83121
{
	AK_DirectSpeakerAssignment = 0,
	AK_BalanceFadeHeight = 1,
	AK_SteeringPanner = 2
}

public class AkStdMovePolicy : IDisposable // TypeDefIndex: 83122
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkStdMovePolicy(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkStdMovePolicy(); // 0x000000018786CA84-0x000000018786CAD4

	// Methods
	internal static IntPtr getCPtr(AkStdMovePolicy obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786CAD4-0x000000018786CAFC
	~AkStdMovePolicy(); // 0x000000018786C9CC-0x000000018786CA44
	public void Dispose(); // 0x000000018786C86C-0x000000018786C8BC
	protected virtual void Dispose(bool disposing); // 0x000000018786C8BC-0x000000018786C9CC
	public static bool IsTrivial(); // 0x000000018786CA44-0x000000018786CA84
}

public class AkStreamMgrSettings : IDisposable // TypeDefIndex: 83123
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkStreamMgrSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0

	// Methods
	internal static IntPtr getCPtr(AkStreamMgrSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786CB4C-0x000000018786CB74
	~AkStreamMgrSettings(); // 0x0000000186ED88A0-0x0000000186ED88F0
	public void Dispose(); // 0x000000018786CAFC-0x000000018786CB4C
	protected virtual void Dispose(bool disposing); // 0x0000000186ED88F0-0x0000000186ED8A70
}

public class AkTransform : IDisposable // TypeDefIndex: 83124
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkTransform(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkTransform(); // 0x000000018786D1C4-0x000000018786D214

	// Methods
	internal static IntPtr getCPtr(AkTransform obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786D214-0x000000018786D23C
	~AkTransform(); // 0x000000018786CCD4-0x000000018786CD4C
	public void Dispose(); // 0x000000018786CC84-0x000000018786CCD4
	protected virtual void Dispose(bool disposing); // 0x000000018786CB74-0x000000018786CC84
	public Vector3 Position(); // 0x000000018786CE1C-0x000000018786CE84
	public Vector3 OrientationFront(); // 0x000000018786CD4C-0x000000018786CDB4
	public Vector3 OrientationTop(); // 0x000000018786CDB4-0x000000018786CE1C
	public void Set(Vector3 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop); // 0x000000018786D080-0x000000018786D138
	public void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ); // 0x000000018786D138-0x000000018786D1C4
	public void SetPosition(Vector3 in_position); // 0x000000018786CF94-0x000000018786CFFC
	public void SetPosition(float in_x, float in_y, float in_z); // 0x000000018786CFFC-0x000000018786D080
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop); // 0x000000018786CE84-0x000000018786CF10
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ); // 0x000000018786CF10-0x000000018786CF94
}

public class AkTriangle : IDisposable // TypeDefIndex: 83125
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ushort point0 { get; set; } // 0x000000018786D5E4-0x000000018786D634 0x000000018786D74C-0x000000018786D7A0
	public ushort point1 { get; set; } // 0x000000018786D634-0x000000018786D684 0x000000018786D7A0-0x000000018786D7F4
	public ushort point2 { get; set; } // 0x000000018786D684-0x000000018786D6D4 0x000000018786D7F4-0x000000018786D848
	public ushort surface { get; set; } // 0x000000018786D6D4-0x000000018786D724 0x000000018786D848-0x000000018786D89C

	// Constructors
	internal AkTriangle(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkTriangle(); // 0x000000018786D50C-0x000000018786D55C
	public AkTriangle(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo); // 0x000000018786D55C-0x000000018786D5E4

	// Methods
	internal static IntPtr getCPtr(AkTriangle obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786D724-0x000000018786D74C
	~AkTriangle(); // 0x000000018786D454-0x000000018786D4CC
	public void Dispose(); // 0x000000018786D404-0x000000018786D454
	protected virtual void Dispose(bool disposing); // 0x000000018786D2F4-0x000000018786D404
	public void Clear(); // 0x000000018786D23C-0x000000018786D28C
	public static int GetSizeOf(); // 0x000000018786D4CC-0x000000018786D50C
	public void Clone(AkTriangle other); // 0x000000018786D28C-0x000000018786D2F4
}

public class AkTrivialStdMovePolicy : IDisposable // TypeDefIndex: 83126
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkTrivialStdMovePolicy(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkTrivialStdMovePolicy(); // 0x000000018786DAB4-0x000000018786DB04

	// Methods
	internal static IntPtr getCPtr(AkTrivialStdMovePolicy obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786DB04-0x000000018786DB2C
	~AkTrivialStdMovePolicy(); // 0x000000018786D9FC-0x000000018786DA74
	public void Dispose(); // 0x000000018786D9AC-0x000000018786D9FC
	protected virtual void Dispose(bool disposing); // 0x000000018786D89C-0x000000018786D9AC
	public static bool IsTrivial(); // 0x000000018786DA74-0x000000018786DAB4
}

public class AkWorldTransform : IDisposable // TypeDefIndex: 83127
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkWorldTransform(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkWorldTransform(); // 0x000000018786E184-0x000000018786E1D4

	// Methods
	internal static IntPtr getCPtr(AkWorldTransform obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786E1D4-0x000000018786E1FC
	~AkWorldTransform(); // 0x000000018786DC8C-0x000000018786DD04
	public void Dispose(); // 0x000000018786DB2C-0x000000018786DB7C
	protected virtual void Dispose(bool disposing); // 0x000000018786DB7C-0x000000018786DC8C
	public AkVector64 Position(); // 0x000000018786DDD4-0x000000018786DE40
	public Vector3 OrientationFront(); // 0x000000018786DD04-0x000000018786DD6C
	public Vector3 OrientationTop(); // 0x000000018786DD6C-0x000000018786DDD4
	public void Set(AkVector64 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop); // 0x000000018786E0CC-0x000000018786E184
	public void Set(double in_positionX, double in_positionY, double in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ); // 0x000000018786E040-0x000000018786E0CC
	public void SetPosition(AkVector64 in_position); // 0x000000018786DF50-0x000000018786DFBC
	public void SetPosition(double in_x, double in_y, double in_z); // 0x000000018786DFBC-0x000000018786E040
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop); // 0x000000018786DEC4-0x000000018786DF50
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ); // 0x000000018786DE40-0x000000018786DEC4
}

public class MonitorErrorInfo : IDisposable // TypeDefIndex: 83128
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public string m_name { get; set; } // 0x000000018786E550-0x000000018786E5BC 0x000000018786E638-0x000000018786E68C
	public string m_message { get; set; } // 0x000000018786E4E4-0x000000018786E550 0x000000018786E5E4-0x000000018786E638

	// Constructors
	internal MonitorErrorInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public MonitorErrorInfo(string in_name, string in_message); // 0x000000018786E3D4-0x000000018786E43C
	public MonitorErrorInfo(string in_name); // 0x000000018786E43C-0x000000018786E494
	public MonitorErrorInfo(); // 0x000000018786E494-0x000000018786E4E4

	// Methods
	internal static IntPtr getCPtr(MonitorErrorInfo obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786E5BC-0x000000018786E5E4
	~MonitorErrorInfo(); // 0x000000018786E35C-0x000000018786E3D4
	public void Dispose(); // 0x000000018786E30C-0x000000018786E35C
	protected virtual void Dispose(bool disposing); // 0x000000018786E1FC-0x000000018786E30C
}

public class MsgContext : IDisposable // TypeDefIndex: 83129
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint in_playingID { get; set; } // 0x000000018786EB00-0x000000018786EB50 0x000000018786EC70-0x000000018786ECC4
	public ulong in_gameObjID { get; set; } // 0x000000018786EAB0-0x000000018786EB00 0x000000018786EC1C-0x000000018786EC70
	public uint in_soundID { get; set; } // 0x000000018786EB50-0x000000018786EBA0 0x000000018786ECC4-0x000000018786ED18
	public bool in_bIsBus { get; set; } // 0x000000018786EA60-0x000000018786EAB0 0x000000018786EBC8-0x000000018786EC1C

	// Constructors
	internal MsgContext(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public MsgContext(uint pId, ulong goId, uint nodeId, bool isBus); // 0x000000018786E9E0-0x000000018786EA60
	public MsgContext(uint pId, ulong goId, uint nodeId); // 0x000000018786E864-0x000000018786E8D8
	public MsgContext(uint pId, ulong goId); // 0x000000018786E97C-0x000000018786E9E0
	public MsgContext(uint pId); // 0x000000018786E928-0x000000018786E97C
	public MsgContext(); // 0x000000018786E8D8-0x000000018786E928

	// Methods
	internal static IntPtr getCPtr(MsgContext obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018786EBA0-0x000000018786EBC8
	~MsgContext(); // 0x000000018786E7EC-0x000000018786E864
	public void Dispose(); // 0x000000018786E79C-0x000000018786E7EC
	protected virtual void Dispose(bool disposing); // 0x000000018786E68C-0x000000018786E79C
}

public class AkCommunicationSettings : IDisposable // TypeDefIndex: 83131
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uPoolSize { get; set; } // 0x0000000187845024-0x0000000187845074 0x0000000186ABB980-0x0000000186ABB9E0
	public ushort uDiscoveryBroadcastPort { get; set; } // 0x0000000187844FD4-0x0000000187845024 0x0000000186ABB920-0x0000000186ABB980
	public ushort uCommandPort { get; set; } // 0x0000000187844F84-0x0000000187844FD4 0x0000000186ABB8C0-0x0000000186ABB920
	public AkCommSystem commSystem { get; set; } // 0x0000000187844EC8-0x0000000187844F18 0x0000000186ABB860-0x0000000186ABB8C0
	public bool bInitSystemLib { get; set; } // 0x0000000187844E78-0x0000000187844EC8 0x0000000186ABB7B0-0x0000000186ABB810
	public string szAppNetworkName { get; set; } // 0x0000000187844F18-0x0000000187844F84 0x0000000186ABB750-0x0000000186ABB7B0

	// Nested types
	public enum AkCommSystem // TypeDefIndex: 83130
	{
		AkCommSystem_Socket = 0,
		AkCommSystem_HTCS = 1
	}

	// Constructors
	internal AkCommunicationSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkCommunicationSettings(); // 0x0000000186ABB300-0x0000000186ABB350

	// Methods
	internal static IntPtr getCPtr(AkCommunicationSettings obj); // 0x000000018566BC30-0x000000018566BC40
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187845074-0x000000018784509C
	~AkCommunicationSettings(); // 0x0000000186E5C470-0x0000000186E5C4C0
	public void Dispose(); // 0x0000000187844E28-0x0000000187844E78
	protected virtual void Dispose(bool disposing); // 0x0000000186E5C4C0-0x0000000186E5C6C0
}

public class AkPlatformInitSettings : IDisposable // TypeDefIndex: 83132
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkThreadProperties threadLEngine { get; set; } // 0x000000018784E2C4-0x000000018784E340 0x000000018784E660-0x000000018784E6C8
	public AkThreadProperties threadOutputMgr { get; set; } // 0x000000018784E3BC-0x000000018784E438 0x000000018784E730-0x000000018784E798
	public AkThreadProperties threadBankManager { get; set; } // 0x000000018784E248-0x000000018784E2C4 0x000000018784E5F8-0x000000018784E660
	public AkThreadProperties threadMonitor { get; set; } // 0x000000018784E340-0x000000018784E3BC 0x000000018784E6C8-0x000000018784E730
	public ushort uNumRefillsInVoice { get; set; } // 0x000000018784E488-0x000000018784E4D8 0x00000001868053F0-0x0000000186805450
	public uint uSampleRate { get; set; } // 0x000000018784E4D8-0x000000018784E528 0x0000000186805350-0x00000001868053B0
	public bool bEnableAvxSupport { get; set; } // 0x000000018784E1A8-0x000000018784E1F8 0x000000018784E550-0x000000018784E5A4
	public uint uMaxSystemAudioObjects { get; set; } // 0x000000018784E438-0x000000018784E488 0x00000001870D3FD0-0x00000001870D4030
	public bool bEnableDirectInputSupport { get; set; } // 0x000000018784E1F8-0x000000018784E248 0x000000018784E5A4-0x000000018784E5F8

	// Constructors
	internal AkPlatformInitSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0

	// Methods
	internal static IntPtr getCPtr(AkPlatformInitSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018784E528-0x000000018784E550
	~AkPlatformInitSettings(); // 0x0000000186D46940-0x0000000186D46990
	public void Dispose(); // 0x000000018784E158-0x000000018784E1A8
	protected virtual void Dispose(bool disposing); // 0x0000000186D46990-0x0000000186D46B20
}

internal class AkSoundEnginePINVOKE // TypeDefIndex: 83133
{
	// Constructors
	static AkSoundEnginePINVOKE(); // 0x0000000186805BA0-0x0000000186805BB0
	public AkSoundEnginePINVOKE(); // 0x0000000186805BA0-0x0000000186805BB0

	// Methods
	public static extern uint CSharp_JoystickIdToWwiseId(uint jarg1); // 0x00000001878624A4-0x000000018786251C
	public static extern uint CSharp_AK_INVALID_SHARE_SET_ID_get(); // 0x00000001878537C0-0x00000001878537EC
	public static extern uint CSharp_AK_INVALID_PIPELINE_ID_get(); // 0x0000000187853794-0x00000001878537C0
	public static extern ulong CSharp_AK_INVALID_AUDIO_OBJECT_ID_get(); // 0x0000000187853698-0x0000000187853700
	public static extern uint CSharp_AK_SOUNDBANK_VERSION_get(); // 0x00000001878538C8-0x0000000187853930
	public static extern uint CSharp_AkJobType_Generic_get(); // 0x0000000187857FD0-0x0000000187857FFC
	public static extern uint CSharp_AkJobType_AudioProcessing_get(); // 0x0000000187857FA4-0x0000000187857FD0
	public static extern uint CSharp_AkJobType_SpatialAudio_get(); // 0x0000000187857FFC-0x0000000187858064
	public static extern uint CSharp_AK_NUM_JOB_TYPES_get(); // 0x000000018785389C-0x00000001878538C8
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2); // 0x00000001878549B8-0x00000001878549F8
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerFrame_get(IntPtr jarg1); // 0x0000000187854984-0x00000001878549B8
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(IntPtr jarg1, uint jarg2); // 0x0000000187854A2C-0x0000000187854A6C
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerSecond_get(IntPtr jarg1); // 0x00000001878549F8-0x0000000187854A2C
	public static extern IntPtr CSharp_new_AkAudioSettings(); // 0x000000018786AC34-0x000000018786AC60
	public static extern void CSharp_delete_AkAudioSettings(IntPtr jarg1); // 0x0000000187869CBC-0x0000000187869CF0
	public static extern void CSharp_AkDeviceDescription_idDevice_set(IntPtr jarg1, uint jarg2); // 0x0000000187855DB4-0x0000000187855DF4
	public static extern uint CSharp_AkDeviceDescription_idDevice_get(IntPtr jarg1); // 0x00000001862E6DB0-0x00000001862E6DF0
	public static extern void CSharp_AkDeviceDescription_deviceName_set(IntPtr jarg1, string jarg2); // 0x0000000187855CB0-0x0000000187855D40
	public static extern IntPtr CSharp_AkDeviceDescription_deviceName_get(IntPtr jarg1); // 0x0000000187855C7C-0x0000000187855CB0
	public static extern void CSharp_AkDeviceDescription_deviceStateMask_set(IntPtr jarg1, int jarg2); // 0x0000000187855D74-0x0000000187855DB4
	public static extern int CSharp_AkDeviceDescription_deviceStateMask_get(IntPtr jarg1); // 0x0000000187855D40-0x0000000187855D74
	public static extern void CSharp_AkDeviceDescription_isDefaultDevice_set(IntPtr jarg1, bool jarg2); // 0x0000000187855DF4-0x0000000187855E38
	public static extern bool CSharp_AkDeviceDescription_isDefaultDevice_get(IntPtr jarg1); // 0x00000001862E6C00-0x00000001862E6C40
	public static extern void CSharp_AkDeviceDescription_Clear(IntPtr jarg1); // 0x0000000186C5A110-0x0000000186C5A150
	public static extern int CSharp_AkDeviceDescription_GetSizeOf(); // 0x0000000186BB7D30-0x0000000186BB7D60
	public static extern void CSharp_AkDeviceDescription_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000187855C38-0x0000000187855C7C
	public static extern IntPtr CSharp_new_AkDeviceDescription(); // 0x000000018786ADE8-0x000000018786AE14
	public static extern void CSharp_delete_AkDeviceDescription(IntPtr jarg1); // 0x0000000187869E5C-0x0000000187869E90
	public static extern AkVector64 CSharp_AkWorldTransform_Position(IntPtr jarg1); // 0x000000018785E940-0x000000018785E9DC
	public static extern Vector3 CSharp_AkWorldTransform_OrientationFront(IntPtr jarg1); // 0x000000018785E810-0x000000018785E8A8
	public static extern Vector3 CSharp_AkWorldTransform_OrientationTop(IntPtr jarg1); // 0x000000018785E8A8-0x000000018785E940
	public static extern void CSharp_AkWorldTransform_Set__SWIG_0(IntPtr jarg1, AkVector64 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x000000018785EBF8-0x000000018785ECD4
	public static extern void CSharp_AkWorldTransform_Set__SWIG_1(IntPtr jarg1, double jarg2, double jarg3, double jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10); // 0x000000018785ECD4-0x000000018785ED3C
	public static extern void CSharp_AkWorldTransform_SetPosition__SWIG_0(IntPtr jarg1, AkVector64 jarg2); // 0x000000018785EAF8-0x000000018785EB98
	public static extern void CSharp_AkWorldTransform_SetPosition__SWIG_1(IntPtr jarg1, double jarg2, double jarg3, double jarg4); // 0x000000018785EB98-0x000000018785EBF8
	public static extern void CSharp_AkWorldTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3); // 0x000000018785E9DC-0x000000018785EA98
	public static extern void CSharp_AkWorldTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7); // 0x000000018785EA98-0x000000018785EAF8
	public static extern IntPtr CSharp_new_AkWorldTransform(); // 0x000000018786BC70-0x000000018786BC9C
	public static extern void CSharp_delete_AkWorldTransform(IntPtr jarg1); // 0x000000018786A954-0x000000018786A988
	public static extern Vector3 CSharp_AkTransform_Position(IntPtr jarg1); // 0x000000018785E2E8-0x000000018785E380
	public static extern Vector3 CSharp_AkTransform_OrientationFront(IntPtr jarg1); // 0x000000018785E1B8-0x000000018785E250
	public static extern Vector3 CSharp_AkTransform_OrientationTop(IntPtr jarg1); // 0x000000018785E250-0x000000018785E2E8
	public static extern void CSharp_AkTransform_Set__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x000000018566C810-0x000000018566C8B0
	public static extern void CSharp_AkTransform_Set__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10); // 0x000000018785E598-0x000000018785E600
	public static extern void CSharp_AkTransform_SetPosition__SWIG_0(IntPtr jarg1, Vector3 jarg2); // 0x000000018785E49C-0x000000018785E538
	public static extern void CSharp_AkTransform_SetPosition__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4); // 0x000000018785E538-0x000000018785E598
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3); // 0x000000018785E380-0x000000018785E43C
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7); // 0x000000018785E43C-0x000000018785E49C
	public static extern IntPtr CSharp_new_AkTransform(); // 0x00000001871048C0-0x00000001871048F0
	public static extern void CSharp_delete_AkTransform(IntPtr jarg1); // 0x000000018786A884-0x000000018786A8B8
	public static extern Vector3 CSharp_ConvertAkVector64ToAkVector(AkVector64 jarg1); // 0x000000018785F1CC-0x000000018785F27C
	public static extern IntPtr CSharp_ConvertAkWorldTransformToAkTransform(IntPtr jarg1); // 0x000000018785F32C-0x000000018785F360
	public static extern AkVector64 CSharp_ConvertAkVectorToAkVector64(Vector3 jarg1); // 0x000000018785F27C-0x000000018785F32C
	public static extern IntPtr CSharp_ConvertAkTransformToAkWorldTransform(IntPtr jarg1); // 0x000000018785F198-0x000000018785F1CC
	public static extern void CSharp_AkObstructionOcclusionValues_occlusion_set(IntPtr jarg1, float jarg2); // 0x000000018785AD20-0x000000018785AD64
	public static extern float CSharp_AkObstructionOcclusionValues_occlusion_get(IntPtr jarg1); // 0x000000018785ACEC-0x000000018785AD20
	public static extern void CSharp_AkObstructionOcclusionValues_obstruction_set(IntPtr jarg1, float jarg2); // 0x000000018785ACA8-0x000000018785ACEC
	public static extern float CSharp_AkObstructionOcclusionValues_obstruction_get(IntPtr jarg1); // 0x000000018785AC74-0x000000018785ACA8
	public static extern void CSharp_AkObstructionOcclusionValues_Clear(IntPtr jarg1); // 0x000000018785ABD0-0x000000018785AC04
	public static extern int CSharp_AkObstructionOcclusionValues_GetSizeOf(); // 0x000000018785AC48-0x000000018785AC74
	public static extern void CSharp_AkObstructionOcclusionValues_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018785AC04-0x000000018785AC48
	public static extern IntPtr CSharp_new_AkObstructionOcclusionValues(); // 0x000000018786B5AC-0x000000018786B5D8
	public static extern void CSharp_delete_AkObstructionOcclusionValues(IntPtr jarg1); // 0x000000018786A4DC-0x000000018786A510
	public static extern void CSharp_AkChannelEmitter_position_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187855970-0x00000001878559B4
	public static extern IntPtr CSharp_AkChannelEmitter_position_get(IntPtr jarg1); // 0x0000000187855934-0x0000000187855970
	public static extern void CSharp_AkChannelEmitter_uInputChannels_set(IntPtr jarg1, uint jarg2); // 0x00000001878559E8-0x0000000187855A28
	public static extern uint CSharp_AkChannelEmitter_uInputChannels_get(IntPtr jarg1); // 0x00000001878559B4-0x00000001878559E8
	public static extern void CSharp_AkChannelEmitter_padding_set(IntPtr jarg1, string jarg2); // 0x00000001878558A0-0x0000000187855934
	public static extern IntPtr CSharp_AkChannelEmitter_padding_get(IntPtr jarg1); // 0x000000018785586C-0x00000001878558A0
	public static extern void CSharp_delete_AkChannelEmitter(IntPtr jarg1); // 0x0000000187869E28-0x0000000187869E5C
	public static extern void CSharp_AkAuxSendValue_listenerID_set(IntPtr jarg1, ulong jarg2); // 0x0000000187854D64-0x0000000187854DE8
	public static extern ulong CSharp_AkAuxSendValue_listenerID_get(IntPtr jarg1); // 0x0000000187854CEC-0x0000000187854D64
	public static extern void CSharp_AkAuxSendValue_auxBusID_set(IntPtr jarg1, uint jarg2); // 0x0000000187854BF8-0x0000000187854C7C
	public static extern uint CSharp_AkAuxSendValue_auxBusID_get(IntPtr jarg1); // 0x0000000187854BC4-0x0000000187854BF8
	public static extern void CSharp_AkAuxSendValue_fControlValue_set(IntPtr jarg1, float jarg2); // 0x0000000187854CA8-0x0000000187854CEC
	public static extern float CSharp_AkAuxSendValue_fControlValue_get(IntPtr jarg1); // 0x0000000187854C7C-0x0000000187854CA8
	public static extern void CSharp_AkAuxSendValue_Set(IntPtr jarg1, ulong jarg2, uint jarg3, float jarg4); // 0x0000000187854B68-0x0000000187854BC4
	public static extern bool CSharp_AkAuxSendValue_IsSame(IntPtr jarg1, ulong jarg2, uint jarg3); // 0x0000000187854AD0-0x0000000187854B68
	public static extern int CSharp_AkAuxSendValue_GetSizeOf(); // 0x0000000187854AA4-0x0000000187854AD0
	public static extern void CSharp_delete_AkAuxSendValue(IntPtr jarg1); // 0x0000000187869D24-0x0000000187869D58
	public static extern IntPtr CSharp_new_AkRamp__SWIG_0(); // 0x000000018786B9F0-0x000000018786BA24
	public static extern IntPtr CSharp_new_AkRamp__SWIG_1(float jarg1, float jarg2); // 0x000000018786BA24-0x000000018786BA68
	public static extern void CSharp_AkRamp_fPrev_set(IntPtr jarg1, float jarg2); // 0x000000018785CD6C-0x000000018785CDB0
	public static extern float CSharp_AkRamp_fPrev_get(IntPtr jarg1); // 0x000000018785CD38-0x000000018785CD6C
	public static extern void CSharp_AkRamp_fNext_set(IntPtr jarg1, float jarg2); // 0x000000018785CCFC-0x000000018785CD38
	public static extern float CSharp_AkRamp_fNext_get(IntPtr jarg1); // 0x000000018785CCC8-0x000000018785CCFC
	public static extern void CSharp_delete_AkRamp(IntPtr jarg1); // 0x000000018786A67C-0x000000018786A6B0
	public static extern ushort CSharp_AK_INT_get(); // 0x0000000187853630-0x0000000187853698
	public static extern ushort CSharp_AK_FLOAT_get(); // 0x0000000187853560-0x00000001878535C8
	public static extern byte CSharp_AK_INTERLEAVED_get(); // 0x00000001878535C8-0x0000000187853630
	public static extern byte CSharp_AK_NONINTERLEAVED_get(); // 0x0000000187853870-0x000000018785389C
	public static extern uint CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get(); // 0x00000001878537EC-0x0000000187853818
	public static extern uint CSharp_AK_LE_NATIVE_SAMPLETYPE_get(); // 0x0000000187853844-0x0000000187853870
	public static extern uint CSharp_AK_LE_NATIVE_INTERLEAVE_get(); // 0x0000000187853818-0x0000000187853844
	public static extern void CSharp_AkAudioFormat_uSampleRate_set(IntPtr jarg1, uint jarg2); // 0x0000000187854898-0x00000001878548D8
	public static extern uint CSharp_AkAudioFormat_uSampleRate_get(IntPtr jarg1); // 0x0000000187854864-0x0000000187854898
	public static extern void CSharp_AkAudioFormat_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187854684-0x0000000187854708
	public static extern IntPtr CSharp_AkAudioFormat_channelConfig_get(IntPtr jarg1); // 0x0000000187854648-0x0000000187854684
	public static extern void CSharp_AkAudioFormat_uBitsPerSample_set(IntPtr jarg1, uint jarg2); // 0x000000018785473C-0x000000018785477C
	public static extern uint CSharp_AkAudioFormat_uBitsPerSample_get(IntPtr jarg1); // 0x0000000187854708-0x000000018785473C
	public static extern void CSharp_AkAudioFormat_uBlockAlign_set(IntPtr jarg1, uint jarg2); // 0x00000001878547B0-0x00000001878547F0
	public static extern uint CSharp_AkAudioFormat_uBlockAlign_get(IntPtr jarg1); // 0x000000018785477C-0x00000001878547B0
	public static extern void CSharp_AkAudioFormat_uTypeID_set(IntPtr jarg1, uint jarg2); // 0x000000018785490C-0x000000018785494C
	public static extern uint CSharp_AkAudioFormat_uTypeID_get(IntPtr jarg1); // 0x00000001878548D8-0x000000018785490C
	public static extern void CSharp_AkAudioFormat_uInterleaveID_set(IntPtr jarg1, uint jarg2); // 0x0000000187854824-0x0000000187854864
	public static extern uint CSharp_AkAudioFormat_uInterleaveID_get(IntPtr jarg1); // 0x00000001878547F0-0x0000000187854824
	public static extern uint CSharp_AkAudioFormat_GetNumChannels(IntPtr jarg1); // 0x000000018785453C-0x0000000187854570
	public static extern uint CSharp_AkAudioFormat_GetBitsPerSample(IntPtr jarg1); // 0x000000018785445C-0x00000001878544D4
	public static extern uint CSharp_AkAudioFormat_GetBlockAlign(IntPtr jarg1); // 0x00000001878544D4-0x0000000187854508
	public static extern uint CSharp_AkAudioFormat_GetTypeID(IntPtr jarg1); // 0x0000000187854570-0x00000001878545A4
	public static extern uint CSharp_AkAudioFormat_GetInterleaveID(IntPtr jarg1); // 0x0000000187854508-0x000000018785453C
	public static extern void CSharp_AkAudioFormat_SetAll(IntPtr jarg1, uint jarg2, IntPtr jarg3, uint jarg4, uint jarg5, uint jarg6, uint jarg7); // 0x00000001878545A4-0x0000000187854648
	public static extern IntPtr CSharp_new_AkAudioFormat(); // 0x000000018786ABDC-0x000000018786AC08
	public static extern void CSharp_delete_AkAudioFormat(IntPtr jarg1); // 0x0000000187869C10-0x0000000187869C88
	public static extern bool CSharp_IsBankCodecID(uint jarg1); // 0x00000001878623D8-0x0000000187862410
	public static extern IntPtr CSharp_new_Ak3dData(); // 0x000000018786AB84-0x000000018786ABB0
	public static extern void CSharp_Ak3dData_xform_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187854270-0x00000001878542B4
	public static extern IntPtr CSharp_Ak3dData_xform_get(IntPtr jarg1); // 0x0000000187854234-0x0000000187854270
	public static extern void CSharp_Ak3dData_spread_set(IntPtr jarg1, float jarg2); // 0x000000018785417C-0x00000001878541C0
	public static extern float CSharp_Ak3dData_spread_get(IntPtr jarg1); // 0x0000000187854148-0x000000018785417C
	public static extern void CSharp_Ak3dData_focus_set(IntPtr jarg1, float jarg2); // 0x0000000187854104-0x0000000187854148
	public static extern float CSharp_Ak3dData_focus_get(IntPtr jarg1); // 0x00000001878540D0-0x0000000187854104
	public static extern void CSharp_Ak3dData_uEmitterChannelMask_set(IntPtr jarg1, uint jarg2); // 0x00000001878541F4-0x0000000187854234
	public static extern uint CSharp_Ak3dData_uEmitterChannelMask_get(IntPtr jarg1); // 0x00000001878541C0-0x00000001878541F4
	public static extern void CSharp_delete_Ak3dData(IntPtr jarg1); // 0x0000000187869B64-0x0000000187869BDC
	public static extern IntPtr CSharp_new_AkBehavioralPositioningData(); // 0x000000018786ACB8-0x000000018786ACE4
	public static extern void CSharp_AkBehavioralPositioningData_center_set(IntPtr jarg1, float jarg2); // 0x0000000187854E1C-0x0000000187854E60
	public static extern float CSharp_AkBehavioralPositioningData_center_get(IntPtr jarg1); // 0x0000000187854DE8-0x0000000187854E1C
	public static extern void CSharp_AkBehavioralPositioningData_panLR_set(IntPtr jarg1, float jarg2); // 0x0000000187854FF0-0x0000000187855034
	public static extern float CSharp_AkBehavioralPositioningData_panLR_get(IntPtr jarg1); // 0x0000000187854FBC-0x0000000187854FF0
	public static extern void CSharp_AkBehavioralPositioningData_panBF_set(IntPtr jarg1, float jarg2); // 0x0000000187854F08-0x0000000187854F44
	public static extern float CSharp_AkBehavioralPositioningData_panBF_get(IntPtr jarg1); // 0x0000000187854EDC-0x0000000187854F08
	public static extern void CSharp_AkBehavioralPositioningData_panDU_set(IntPtr jarg1, float jarg2); // 0x0000000187854F78-0x0000000187854FBC
	public static extern float CSharp_AkBehavioralPositioningData_panDU_get(IntPtr jarg1); // 0x0000000187854F44-0x0000000187854F78
	public static extern void CSharp_AkBehavioralPositioningData_panSpatMix_set(IntPtr jarg1, float jarg2); // 0x0000000187855068-0x00000001878550AC
	public static extern float CSharp_AkBehavioralPositioningData_panSpatMix_get(IntPtr jarg1); // 0x0000000187855034-0x0000000187855068
	public static extern void CSharp_AkBehavioralPositioningData_spatMode_set(IntPtr jarg1, int jarg2); // 0x000000018785515C-0x000000018785519C
	public static extern int CSharp_AkBehavioralPositioningData_spatMode_get(IntPtr jarg1); // 0x0000000187855128-0x000000018785515C
	public static extern void CSharp_AkBehavioralPositioningData_panType_set(IntPtr jarg1, int jarg2); // 0x00000001878550E8-0x0000000187855128
	public static extern int CSharp_AkBehavioralPositioningData_panType_get(IntPtr jarg1); // 0x00000001878550AC-0x00000001878550E8
	public static extern void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(IntPtr jarg1, bool jarg2); // 0x0000000187854E98-0x0000000187854EDC
	public static extern bool CSharp_AkBehavioralPositioningData_enableHeightSpread_get(IntPtr jarg1); // 0x0000000187854E60-0x0000000187854E98
	public static extern void CSharp_delete_AkBehavioralPositioningData(IntPtr jarg1); // 0x0000000187869D8C-0x0000000187869DC0
	public static extern void CSharp_AkPositioningData_threeD_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785C3E4-0x000000018785C428
	public static extern IntPtr CSharp_AkPositioningData_threeD_get(IntPtr jarg1); // 0x000000018785C3B0-0x000000018785C3E4
	public static extern void CSharp_AkPositioningData_behavioral_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785C32C-0x000000018785C3B0
	public static extern IntPtr CSharp_AkPositioningData_behavioral_get(IntPtr jarg1); // 0x000000018785C2F8-0x000000018785C32C
	public static extern IntPtr CSharp_new_AkPositioningData(); // 0x000000018786B95C-0x000000018786B988
	public static extern void CSharp_delete_AkPositioningData(IntPtr jarg1); // 0x000000018786A614-0x000000018786A648
	public static extern void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187853FA4-0x0000000187853FE8
	public static extern IntPtr CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(IntPtr jarg1); // 0x0000000187853F68-0x0000000187853FA4
	public static extern void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x0000000187854090-0x00000001878540D0
	public static extern uint CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(IntPtr jarg1); // 0x000000018785405C-0x0000000187854090
	public static extern void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x000000018785401C-0x000000018785405C
	public static extern uint CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(IntPtr jarg1); // 0x0000000187853FE8-0x000000018785401C
	public static extern void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(IntPtr jarg1, bool jarg2); // 0x0000000187853F24-0x0000000187853F68
	public static extern bool CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(IntPtr jarg1); // 0x0000000187853EEC-0x0000000187853F24
	public static extern void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(IntPtr jarg1, bool jarg2); // 0x0000000187853EA8-0x0000000187853EEC
	public static extern bool CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(IntPtr jarg1); // 0x0000000187853E70-0x0000000187853EA8
	public static extern IntPtr CSharp_new_Ak3DAudioSinkCapabilities(); // 0x000000018786AB58-0x000000018786AB84
	public static extern void CSharp_delete_Ak3DAudioSinkCapabilities(IntPtr jarg1); // 0x0000000187869B30-0x0000000187869B64
	public static extern void CSharp_AkIterator_pItem_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857F60-0x0000000187857FA4
	public static extern IntPtr CSharp_AkIterator_pItem_get(IntPtr jarg1); // 0x0000000187857F2C-0x0000000187857F60
	public static extern IntPtr CSharp_AkIterator_NextIter(IntPtr jarg1); // 0x0000000187857EC4-0x0000000187857EF8
	public static extern IntPtr CSharp_AkIterator_PrevIter(IntPtr jarg1); // 0x0000000187857EF8-0x0000000187857F2C
	public static extern IntPtr CSharp_AkIterator_GetItem(IntPtr jarg1); // 0x0000000187857DBC-0x0000000187857DF0
	public static extern bool CSharp_AkIterator_IsEqualTo(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857E38-0x0000000187857EC4
	public static extern bool CSharp_AkIterator_IsDifferentFrom(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857DF0-0x0000000187857E38
	public static extern IntPtr CSharp_new_AkIterator(); // 0x000000018786B28C-0x000000018786B2B8
	public static extern void CSharp_delete_AkIterator(IntPtr jarg1); // 0x000000018786A0CC-0x000000018786A100
	public static extern bool CSharp_AkStdMovePolicy_IsTrivial(); // 0x000000018785E02C-0x000000018785E05C
	public static extern IntPtr CSharp_new_AkStdMovePolicy(); // 0x000000018786BB18-0x000000018786BB44
	public static extern void CSharp_delete_AkStdMovePolicy(IntPtr jarg1); // 0x000000018786A7E8-0x000000018786A81C
	public static extern bool CSharp_AkTrivialStdMovePolicy_IsTrivial(); // 0x000000018785E7E0-0x000000018785E810
	public static extern IntPtr CSharp_new_AkTrivialStdMovePolicy(); // 0x000000018786BC44-0x000000018786BC70
	public static extern void CSharp_delete_AkTrivialStdMovePolicy(IntPtr jarg1); // 0x000000018786A8EC-0x000000018786A920
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_0(); // 0x000000018786B8D0-0x000000018786B8FC
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_1(IntPtr jarg1); // 0x000000018786B8FC-0x000000018786B930
	public static extern void CSharp_delete_AkPlaylistItem(IntPtr jarg1); // 0x000000018786A5AC-0x000000018786A5E0
	public static extern IntPtr CSharp_AkPlaylistItem_Assign(IntPtr jarg1, IntPtr jarg2); // 0x000000018785BD44-0x000000018785BD88
	public static extern bool CSharp_AkPlaylistItem_IsEqualTo(IntPtr jarg1, IntPtr jarg2); // 0x000000018785BD88-0x000000018785BE14
	public static extern int CSharp_AkPlaylistItem_SetExternalSources(IntPtr jarg1, uint jarg2, IntPtr jarg3); // 0x000000018785BE14-0x000000018785BEA8
	public static extern void CSharp_AkPlaylistItem_audioNodeID_set(IntPtr jarg1, uint jarg2); // 0x000000018785BEDC-0x000000018785BF1C
	public static extern uint CSharp_AkPlaylistItem_audioNodeID_get(IntPtr jarg1); // 0x000000018785BEA8-0x000000018785BEDC
	public static extern void CSharp_AkPlaylistItem_msDelay_set(IntPtr jarg1, int jarg2); // 0x000000018785BF50-0x000000018785BF90
	public static extern int CSharp_AkPlaylistItem_msDelay_get(IntPtr jarg1); // 0x000000018785BF1C-0x000000018785BF50
	public static extern void CSharp_AkPlaylistItem_pCustomInfo_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785BFC4-0x000000018785C008
	public static extern IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(IntPtr jarg1); // 0x000000018785BF90-0x000000018785BFC4
	public static extern IntPtr CSharp_new_AkPlaylistArray(); // 0x000000018786B8A4-0x000000018786B8D0
	public static extern void CSharp_delete_AkPlaylistArray(IntPtr jarg1); // 0x000000018786A578-0x000000018786A5AC
	public static extern IntPtr CSharp_AkPlaylistArray_Begin(IntPtr jarg1); // 0x000000018785B400-0x000000018785B43C
	public static extern IntPtr CSharp_AkPlaylistArray_End(IntPtr jarg1); // 0x000000018785B4F4-0x000000018785B528
	public static extern IntPtr CSharp_AkPlaylistArray_FindEx(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B6B4-0x000000018785B738
	public static extern IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B5EC-0x000000018785B630
	public static extern void CSharp_AkPlaylistArray_Erase__SWIG_1(IntPtr jarg1, uint jarg2); // 0x000000018785B630-0x000000018785B670
	public static extern IntPtr CSharp_AkPlaylistArray_EraseSwap__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B528-0x000000018785B5AC
	public static extern void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(IntPtr jarg1, uint jarg2); // 0x000000018785B5AC-0x000000018785B5EC
	public static extern bool CSharp_AkPlaylistArray_IsGrowingAllowed(IntPtr jarg1); // 0x000000018785B8F8-0x000000018785B974
	public static extern int CSharp_AkPlaylistArray_Reserve(IntPtr jarg1, uint jarg2); // 0x000000018785BBD0-0x000000018785BC10
	public static extern int CSharp_AkPlaylistArray_ReserveExtra(IntPtr jarg1, uint jarg2); // 0x000000018785BB90-0x000000018785BBD0
	public static extern uint CSharp_AkPlaylistArray_Reserved(IntPtr jarg1); // 0x000000018785BC10-0x000000018785BC44
	public static extern void CSharp_AkPlaylistArray_Term(IntPtr jarg1); // 0x000000018785BCCC-0x000000018785BD00
	public static extern uint CSharp_AkPlaylistArray_Length(IntPtr jarg1); // 0x000000018785BA2C-0x000000018785BA60
	public static extern IntPtr CSharp_AkPlaylistArray_Data(IntPtr jarg1); // 0x000000018785B4C0-0x000000018785B4F4
	public static extern bool CSharp_AkPlaylistArray_IsEmpty(IntPtr jarg1); // 0x000000018785B8C0-0x000000018785B8F8
	public static extern IntPtr CSharp_AkPlaylistArray_Exists(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B670-0x000000018785B6B4
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(IntPtr jarg1); // 0x000000018785B304-0x000000018785B37C
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B37C-0x000000018785B400
	public static extern IntPtr CSharp_AkPlaylistArray_Last(IntPtr jarg1); // 0x000000018785B9F8-0x000000018785BA2C
	public static extern void CSharp_AkPlaylistArray_RemoveLast(IntPtr jarg1); // 0x000000018785BA94-0x000000018785BAC8
	public static extern int CSharp_AkPlaylistArray_Remove(IntPtr jarg1, IntPtr jarg2); // 0x000000018785BB0C-0x000000018785BB90
	public static extern int CSharp_AkPlaylistArray_RemoveSwap(IntPtr jarg1, IntPtr jarg2); // 0x000000018785BAC8-0x000000018785BB0C
	public static extern void CSharp_AkPlaylistArray_RemoveAll(IntPtr jarg1); // 0x000000018785BA60-0x000000018785BA94
	public static extern IntPtr CSharp_AkPlaylistArray_ItemAtIndex(IntPtr jarg1, uint jarg2); // 0x000000018785B974-0x000000018785B9F8
	public static extern IntPtr CSharp_AkPlaylistArray_Insert__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B7F8-0x000000018785B83C
	public static extern IntPtr CSharp_AkPlaylistArray_Insert__SWIG_1(IntPtr jarg1, uint jarg2); // 0x000000018785B83C-0x000000018785B8C0
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_0(IntPtr jarg1); // 0x000000018785B738-0x000000018785B770
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_1(IntPtr jarg1, uint jarg2); // 0x000000018785B770-0x000000018785B7F8
	public static extern bool CSharp_AkPlaylistArray_Resize(IntPtr jarg1, uint jarg2); // 0x000000018785BC44-0x000000018785BCCC
	public static extern void CSharp_AkPlaylistArray_Transfer(IntPtr jarg1, IntPtr jarg2); // 0x000000018785BD00-0x000000018785BD44
	public static extern int CSharp_AkPlaylistArray_Copy(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B43C-0x000000018785B4C0
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_0(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6); // 0x000000018785C008-0x000000018785C0AC
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_1(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5); // 0x000000018785C0AC-0x000000018785C150
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_2(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4); // 0x000000018785C150-0x000000018785C1F0
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_3(IntPtr jarg1, uint jarg2, int jarg3); // 0x000000018785C1F0-0x000000018785C284
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_4(IntPtr jarg1, uint jarg2); // 0x000000018785C284-0x000000018785C2C4
	public static extern IntPtr CSharp_new_AkPlaylist(); // 0x000000018786B930-0x000000018786B95C
	public static extern void CSharp_delete_AkPlaylist(IntPtr jarg1); // 0x000000018786A5E0-0x000000018786A614
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_0(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x000000018785F598-0x000000018785F63C
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_1(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4); // 0x000000018785F63C-0x000000018785F6DC
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_2(ulong jarg1); // 0x000000018785F6DC-0x000000018785F754
	public static extern int CSharp_DynamicSequenceClose(uint jarg1); // 0x000000018785F458-0x000000018785F48C
	public static extern int CSharp_DynamicSequencePlay__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x000000018785F898-0x000000018785F928
	public static extern int CSharp_DynamicSequencePlay__SWIG_1(uint jarg1, int jarg2); // 0x000000018785F928-0x000000018785F9A8
	public static extern int CSharp_DynamicSequencePlay__SWIG_2(uint jarg1); // 0x000000018785F9A8-0x000000018785F9DC
	public static extern int CSharp_DynamicSequencePause__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x000000018785F754-0x000000018785F7E4
	public static extern int CSharp_DynamicSequencePause__SWIG_1(uint jarg1, int jarg2); // 0x000000018785F7E4-0x000000018785F864
	public static extern int CSharp_DynamicSequencePause__SWIG_2(uint jarg1); // 0x000000018785F864-0x000000018785F898
	public static extern int CSharp_DynamicSequenceResume__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x000000018785F9DC-0x000000018785FA6C
	public static extern int CSharp_DynamicSequenceResume__SWIG_1(uint jarg1, int jarg2); // 0x000000018785FA6C-0x000000018785FAAC
	public static extern int CSharp_DynamicSequenceResume__SWIG_2(uint jarg1); // 0x000000018785FAAC-0x000000018785FAE0
	public static extern int CSharp_DynamicSequenceStop__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x000000018785FAE0-0x000000018785FB30
	public static extern int CSharp_DynamicSequenceStop__SWIG_1(uint jarg1, int jarg2); // 0x000000018785FB30-0x000000018785FB70
	public static extern int CSharp_DynamicSequenceStop__SWIG_2(uint jarg1); // 0x000000018785FB70-0x000000018785FBE8
	public static extern int CSharp_DynamicSequenceBreak(uint jarg1); // 0x000000018785F3E0-0x000000018785F458
	public static extern int CSharp_Seek__SWIG_0(uint jarg1, int jarg2, bool jarg3); // 0x00000001878669D8-0x0000000187866A28
	public static extern int CSharp_Seek__SWIG_1(uint jarg1, float jarg2, bool jarg3); // 0x0000000187866A28-0x0000000187866A74
	public static extern int CSharp_DynamicSequenceGetPauseTimes(uint jarg1, out uint jarg2, out uint jarg3); // 0x000000018785F48C-0x000000018785F520
	public static extern IntPtr CSharp_DynamicSequenceLockPlaylist(uint jarg1); // 0x000000018785F520-0x000000018785F598
	public static extern int CSharp_DynamicSequenceUnlockPlaylist(uint jarg1); // 0x000000018785FBE8-0x000000018785FC1C
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_0(); // 0x000000018786B5D8-0x000000018786B604
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_1(string jarg1, uint jarg2, IntPtr jarg3, int jarg4); // 0x000000018786B604-0x000000018786B6C0
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_2(string jarg1, uint jarg2, IntPtr jarg3); // 0x000000018786B6C0-0x000000018786B76C
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_3(string jarg1, uint jarg2); // 0x000000018786B76C-0x000000018786B80C
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_4(string jarg1); // 0x000000018786B80C-0x000000018786B8A4
	public static extern void CSharp_AkOutputSettings_audioDeviceShareset_set(IntPtr jarg1, uint jarg2); // 0x00000001850C98B0-0x00000001850C98F0
	public static extern uint CSharp_AkOutputSettings_audioDeviceShareset_get(IntPtr jarg1); // 0x000000018785AD64-0x000000018785ADDC
	public static extern void CSharp_AkOutputSettings_idDevice_set(IntPtr jarg1, uint jarg2); // 0x00000001850C9810-0x00000001850C9850
	public static extern uint CSharp_AkOutputSettings_idDevice_get(IntPtr jarg1); // 0x000000018785AE54-0x000000018785AE88
	public static extern void CSharp_AkOutputSettings_ePanningRule_set(IntPtr jarg1, int jarg2); // 0x00000001850C9770-0x00000001850C97B0
	public static extern int CSharp_AkOutputSettings_ePanningRule_get(IntPtr jarg1); // 0x000000018785AE20-0x000000018785AE54
	public static extern void CSharp_AkOutputSettings_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785ADDC-0x000000018785AE20
	public static extern IntPtr CSharp_AkOutputSettings_channelConfig_get(IntPtr jarg1); // 0x00000001850C95F0-0x00000001850C9630
	public static extern void CSharp_delete_AkOutputSettings(IntPtr jarg1); // 0x000000018786A510-0x000000018786A544
	public static extern void CSharp_AkInitSettings_uMaxNumPaths_set(IntPtr jarg1, uint jarg2); // 0x00000001850C9480-0x00000001850C94C0
	public static extern uint CSharp_AkInitSettings_uMaxNumPaths_get(IntPtr jarg1); // 0x0000000187857AAC-0x0000000187857AE0
	public static extern void CSharp_AkInitSettings_uCommandQueueSize_set(IntPtr jarg1, uint jarg2); // 0x00000001850C93E0-0x00000001850C9420
	public static extern uint CSharp_AkInitSettings_uCommandQueueSize_get(IntPtr jarg1); // 0x000000018785799C-0x00000001878579D0
	public static extern void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(IntPtr jarg1, bool jarg2); // 0x0000000186805250-0x00000001868052A0
	public static extern bool CSharp_AkInitSettings_bEnableGameSyncPreparation_get(IntPtr jarg1); // 0x0000000187857650-0x00000001878576CC
	public static extern void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(IntPtr jarg1, uint jarg2); // 0x00000001868051B0-0x00000001868051F0
	public static extern uint CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(IntPtr jarg1); // 0x00000001878579D0-0x0000000187857A04
	public static extern void CSharp_AkInitSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2); // 0x00000001850C9340-0x00000001850C9380
	public static extern uint CSharp_AkInitSettings_uNumSamplesPerFrame_get(IntPtr jarg1); // 0x0000000187857B14-0x0000000187857B48
	public static extern void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(IntPtr jarg1, uint jarg2); // 0x0000000186805110-0x0000000186805150
	public static extern uint CSharp_AkInitSettings_uMonitorQueuePoolSize_get(IntPtr jarg1); // 0x0000000187857AE0-0x0000000187857B14
	public static extern void CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_set(IntPtr jarg1, uint jarg2); // 0x0000000187857A38-0x0000000187857A78
	public static extern uint CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_get(IntPtr jarg1); // 0x0000000187857A04-0x0000000187857A38
	public static extern void CSharp_AkInitSettings_settingsMainOutput_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001878578E4-0x0000000187857928
	public static extern IntPtr CSharp_AkInitSettings_settingsMainOutput_get(IntPtr jarg1); // 0x00000001850C8F10-0x00000001850C8F50
	public static extern void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(IntPtr jarg1, uint jarg2); // 0x0000000186805070-0x00000001868050B0
	public static extern uint CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(IntPtr jarg1); // 0x0000000187857A78-0x0000000187857AAC
	public static extern void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(IntPtr jarg1, bool jarg2); // 0x0000000187857780-0x00000001878577C4
	public static extern bool CSharp_AkInitSettings_bUseSoundBankMgrThread_get(IntPtr jarg1); // 0x0000000187857748-0x0000000187857780
	public static extern void CSharp_AkInitSettings_bUseLEngineThread_set(IntPtr jarg1, bool jarg2); // 0x0000000187857704-0x0000000187857748
	public static extern bool CSharp_AkInitSettings_bUseLEngineThread_get(IntPtr jarg1); // 0x00000001878576CC-0x0000000187857704
	public static extern void CSharp_AkInitSettings_szPluginDLLPath_set(IntPtr jarg1, string jarg2); // 0x00000001850C98F0-0x00000001850C9990
	public static extern IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(IntPtr jarg1); // 0x00000001850C8DA0-0x00000001850C8DE0
	public static extern void CSharp_AkInitSettings_eFloorPlane_set(IntPtr jarg1, int jarg2); // 0x00000001878577F8-0x0000000187857838
	public static extern int CSharp_AkInitSettings_eFloorPlane_get(IntPtr jarg1); // 0x00000001878577C4-0x00000001878577F8
	public static extern void CSharp_AkInitSettings_fGameUnitsToMeters_set(IntPtr jarg1, float jarg2); // 0x00000001878578A0-0x00000001878578E4
	public static extern float CSharp_AkInitSettings_fGameUnitsToMeters_get(IntPtr jarg1); // 0x000000018785786C-0x00000001878578A0
	public static extern void CSharp_AkInitSettings_uBankReadBufferSize_set(IntPtr jarg1, uint jarg2); // 0x000000018785795C-0x000000018785799C
	public static extern uint CSharp_AkInitSettings_uBankReadBufferSize_get(IntPtr jarg1); // 0x0000000187857928-0x000000018785795C
	public static extern void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(IntPtr jarg1, float jarg2); // 0x0000000186804FC0-0x0000000186805010
	public static extern float CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(IntPtr jarg1); // 0x0000000187857838-0x000000018785786C
	public static extern void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(IntPtr jarg1, bool jarg2); // 0x0000000186804F10-0x0000000186804F60
	public static extern bool CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(IntPtr jarg1); // 0x0000000187857618-0x0000000187857650
	public static extern void CSharp_delete_AkInitSettings(IntPtr jarg1); // 0x000000018786A098-0x000000018786A0CC
	public static extern void CSharp_AkSourceSettings_sourceID_set(IntPtr jarg1, uint jarg2); // 0x000000018785DDD0-0x000000018785DE10
	public static extern uint CSharp_AkSourceSettings_sourceID_get(IntPtr jarg1); // 0x000000018785DD9C-0x000000018785DDD0
	public static extern void CSharp_AkSourceSettings_pMediaMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785DD58-0x000000018785DD9C
	public static extern IntPtr CSharp_AkSourceSettings_pMediaMemory_get(IntPtr jarg1); // 0x000000018785DD24-0x000000018785DD58
	public static extern void CSharp_AkSourceSettings_uMediaSize_set(IntPtr jarg1, uint jarg2); // 0x000000018785DE44-0x000000018785DE84
	public static extern uint CSharp_AkSourceSettings_uMediaSize_get(IntPtr jarg1); // 0x000000018785DE10-0x000000018785DE44
	public static extern void CSharp_AkSourceSettings_Clear(IntPtr jarg1); // 0x000000018785DC78-0x000000018785DCAC
	public static extern int CSharp_AkSourceSettings_GetSizeOf(); // 0x000000018785DCF0-0x000000018785DD24
	public static extern void CSharp_AkSourceSettings_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018785DCAC-0x000000018785DCF0
	public static extern IntPtr CSharp_new_AkSourceSettings(); // 0x000000018786BAEC-0x000000018786BB18
	public static extern void CSharp_delete_AkSourceSettings(IntPtr jarg1); // 0x000000018786A7B4-0x000000018786A7E8
	public static extern bool CSharp_IsInitialized(); // 0x00000001862FA6C0-0x00000001862FA730
	public static extern int CSharp_GetAudioSettings(IntPtr jarg1); // 0x0000000187860358-0x000000018786038C
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(ulong jarg1); // 0x0000000187861D34-0x0000000187861DAC
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_1(); // 0x00000001862FA460-0x00000001862FA490
	public static extern int CSharp_GetOutputDeviceConfiguration(ulong jarg1, IntPtr jarg2, IntPtr jarg3); // 0x0000000187860EC8-0x0000000187860F5C
	public static extern int CSharp_GetPanningRule__SWIG_0(out int jarg1, ulong jarg2); // 0x000000018786107C-0x0000000187861100
	public static extern int CSharp_GetPanningRule__SWIG_1(out int jarg1); // 0x0000000187861100-0x0000000187861178
	public static extern int CSharp_SetPanningRule__SWIG_0(int jarg1, ulong jarg2); // 0x0000000187868094-0x0000000187868118
	public static extern int CSharp_SetPanningRule__SWIG_1(int jarg1); // 0x0000000187868118-0x0000000187868190
	public static extern int CSharp_GetSpeakerAngles__SWIG_0([In, Out] float[] jarg1, ref uint jarg2, out float jarg3, ulong jarg4); // 0x0000000187861BE8-0x0000000187861C94
	public static extern int CSharp_GetSpeakerAngles__SWIG_1([In, Out] float[] jarg1, ref uint jarg2, out float jarg3); // 0x0000000187861C94-0x0000000187861D34
	public static extern int CSharp_SetSpeakerAngles__SWIG_0(in float[] jarg1, uint jarg2, float jarg3, ulong jarg4); // 0x0000000187868958-0x00000001878689BC
	public static extern int CSharp_SetSpeakerAngles__SWIG_1(in float[] jarg1, uint jarg2, float jarg3); // 0x00000001878689BC-0x0000000187868A10
	public static extern int CSharp_SetVolumeThreshold(float jarg1); // 0x0000000187868BE0-0x0000000187868C14
	public static extern int CSharp_SetMaxNumVoicesLimit(ushort jarg1); // 0x00000001878678EC-0x0000000187867964
	public static extern int CSharp_SetJobMgrMaxActiveWorkers(uint jarg1, uint jarg2); // 0x0000000187867658-0x00000001878676D8
	public static extern int CSharp_RenderAudio__SWIG_0(bool jarg1); // 0x00000001878655C8-0x0000000187865640
	public static extern int CSharp_RenderAudio__SWIG_1(); // 0x000000018577E1B0-0x000000018577E1E0
	public static extern int CSharp_RegisterPluginDLL__SWIG_0(string jarg1, string jarg2); // 0x00000001878651D0-0x0000000187865268
	public static extern int CSharp_RegisterPluginDLL__SWIG_1(string jarg1); // 0x0000000187865268-0x00000001878652A8
	public static extern bool CSharp_IsPluginRegistered(int jarg1, uint jarg2, uint jarg3); // 0x0000000187862410-0x00000001878624A4
	public static extern uint CSharp_GetIDFromString__SWIG_0(string jarg1); // 0x0000000186118A60-0x0000000186118AA0
	public static extern uint CSharp_PostEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8); // 0x00000001878637D4-0x0000000187863878
	public static extern uint CSharp_PostEvent__SWIG_1(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7); // 0x00000001863A83F0-0x00000001863A8450
	public static extern uint CSharp_PostEvent__SWIG_2(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x000000018598AF30-0x000000018598AF90
	public static extern uint CSharp_PostEvent__SWIG_3(uint jarg1, ulong jarg2); // 0x0000000187863878-0x00000001878638FC
	public static extern uint CSharp_PostEvent__SWIG_4(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8); // 0x00000001878638FC-0x00000001878639AC
	public static extern uint CSharp_PostEvent__SWIG_5(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7); // 0x00000001878639AC-0x0000000187863A5C
	public static extern uint CSharp_PostEvent__SWIG_6(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x0000000187863A5C-0x0000000187863B0C
	public static extern uint CSharp_PostEvent__SWIG_7(string jarg1, ulong jarg2); // 0x0000000187863B0C-0x0000000187863B9C
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_0(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6); // 0x000000018785FC1C-0x000000018785FCBC
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_1(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5); // 0x000000018785FCBC-0x000000018785FD5C
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_2(uint jarg1, int jarg2, ulong jarg3, int jarg4); // 0x000000018785FD5C-0x000000018785FDFC
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_3(uint jarg1, int jarg2, ulong jarg3); // 0x000000018785FDFC-0x000000018785FE8C
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_4(uint jarg1, int jarg2); // 0x000000018785FE8C-0x000000018785FF0C
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_5(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6); // 0x000000018785FF0C-0x000000018785FFB8
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_6(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5); // 0x000000018785FFB8-0x0000000187860064
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_7(string jarg1, int jarg2, ulong jarg3, int jarg4); // 0x0000000187860064-0x0000000187860110
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_8(string jarg1, int jarg2, ulong jarg3); // 0x0000000187860110-0x00000001878601AC
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_9(string jarg1, int jarg2); // 0x00000001878601AC-0x0000000187860238
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8, uint jarg9); // 0x0000000187863B9C-0x0000000187863C54
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8); // 0x0000000187863C54-0x0000000187863D08
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_2(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5); // 0x0000000187863D08-0x0000000187863DBC
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_3(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4); // 0x0000000187863DBC-0x0000000187863E60
	public static extern int CSharp_StopMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3); // 0x0000000187868E98-0x0000000187868F2C
	public static extern int CSharp_StopMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2); // 0x0000000187868F2C-0x0000000187868F6C
	public static extern int CSharp_StopMIDIOnEvent__SWIG_2(uint jarg1); // 0x0000000187868F6C-0x0000000187868FA0
	public static extern int CSharp_StopMIDIOnEvent__SWIG_3(); // 0x0000000187868FA0-0x0000000187869008
	public static extern int CSharp_PinEventInStreamCache__SWIG_0(uint jarg1, sbyte jarg2, sbyte jarg3); // 0x0000000187863310-0x00000001878633A4
	public static extern int CSharp_PinEventInStreamCache__SWIG_1(string jarg1, sbyte jarg2, sbyte jarg3); // 0x00000001878633A4-0x0000000187863444
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_0(uint jarg1); // 0x0000000187869848-0x00000001878698C0
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_1(string jarg1); // 0x00000001878698C0-0x0000000187869940
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_0(uint jarg1, out float jarg2, out int jarg3); // 0x00000001878603F8-0x000000018786048C
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_1(string jarg1, out float jarg2, out int jarg3); // 0x000000018786048C-0x0000000187860534
	public static extern int CSharp_SeekOnEvent__SWIG_0(uint jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5); // 0x00000001878663D0-0x0000000187866474
	public static extern int CSharp_SeekOnEvent__SWIG_1(uint jarg1, ulong jarg2, int jarg3, bool jarg4); // 0x0000000187866644-0x00000001878666E8
	public static extern int CSharp_SeekOnEvent__SWIG_2(uint jarg1, ulong jarg2, int jarg3); // 0x00000001878666E8-0x000000018786677C
	public static extern int CSharp_SeekOnEvent__SWIG_3(string jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5); // 0x000000018786677C-0x000000018786682C
	public static extern int CSharp_SeekOnEvent__SWIG_4(string jarg1, ulong jarg2, int jarg3, bool jarg4); // 0x000000018786682C-0x00000001878668DC
	public static extern int CSharp_SeekOnEvent__SWIG_5(string jarg1, ulong jarg2, int jarg3); // 0x00000001878668DC-0x000000018786697C
	public static extern int CSharp_SeekOnEvent__SWIG_9(uint jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5); // 0x000000018786697C-0x00000001878669D8
	public static extern int CSharp_SeekOnEvent__SWIG_10(uint jarg1, ulong jarg2, float jarg3, bool jarg4); // 0x0000000187866474-0x00000001878664D0
	public static extern int CSharp_SeekOnEvent__SWIG_11(uint jarg1, ulong jarg2, float jarg3); // 0x00000001878664D0-0x000000018786651C
	public static extern int CSharp_SeekOnEvent__SWIG_12(string jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5); // 0x000000018786651C-0x0000000187866584
	public static extern int CSharp_SeekOnEvent__SWIG_13(string jarg1, ulong jarg2, float jarg3, bool jarg4); // 0x0000000187866584-0x00000001878665EC
	public static extern int CSharp_SeekOnEvent__SWIG_14(string jarg1, ulong jarg2, float jarg3); // 0x00000001878665EC-0x0000000187866644
	public static extern void CSharp_CancelEventCallbackCookie(IntPtr jarg1); // 0x000000018785EDE8-0x000000018785EE1C
	public static extern void CSharp_CancelEventCallbackGameObject(ulong jarg1); // 0x000000018785EE1C-0x000000018785EE50
	public static extern void CSharp_CancelEventCallback(uint jarg1); // 0x000000018785EE50-0x000000018785EE84
	public static extern int CSharp_GetSourcePlayPosition__SWIG_0(uint jarg1, out int jarg2, bool jarg3); // 0x0000000187861A3C-0x0000000187861AD0
	public static extern int CSharp_GetSourcePlayPosition__SWIG_1(uint jarg1, out int jarg2); // 0x0000000187861AD0-0x0000000187861B54
	public static extern int CSharp_GetSourceStreamBuffering(uint jarg1, out int jarg2, out int jarg3); // 0x0000000187861B54-0x0000000187861BE8
	public static extern void CSharp_StopAll__SWIG_0(ulong jarg1); // 0x00000001858F35B0-0x00000001858F3650
	public static extern void CSharp_StopAll__SWIG_1(); // 0x0000000187868E38-0x0000000187868E64
	public static extern void CSharp_StopPlayingID__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x0000000187869034-0x00000001878690C4
	public static extern void CSharp_StopPlayingID__SWIG_1(uint jarg1, int jarg2); // 0x00000001878690C4-0x0000000187869144
	public static extern void CSharp_StopPlayingID__SWIG_2(uint jarg1); // 0x0000000187869144-0x00000001878691BC
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_0(int jarg1, uint jarg2, int jarg3, int jarg4); // 0x0000000187860238-0x00000001878602D8
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_1(int jarg1, uint jarg2, int jarg3); // 0x0000000185A7D070-0x0000000185A7D0C0
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_2(int jarg1, uint jarg2); // 0x00000001878602D8-0x0000000187860358
	public static extern void CSharp_SetRandomSeed(uint jarg1); // 0x00000001878687F4-0x000000018786886C
	public static extern void CSharp_MuteBackgroundMusic(bool jarg1); // 0x000000018786326C-0x00000001878632E4
	public static extern bool CSharp_GetBackgroundMusicMute(); // 0x000000018786038C-0x00000001878603F8
	public static extern int CSharp_SendPluginCustomGameData(uint jarg1, ulong jarg2, int jarg3, uint jarg4, uint jarg5, IntPtr jarg6, uint jarg7); // 0x0000000187866A74-0x0000000187866B18
	public static extern int CSharp_UnregisterAllGameObj(); // 0x0000000187869940-0x000000018786996C
	public static extern int CSharp_SetMultiplePositions__SWIG_0(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4, int jarg5); // 0x0000000187867B98-0x0000000187867C40
	public static extern int CSharp_SetMultiplePositions__SWIG_1(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4); // 0x0000000185A1AE60-0x0000000185A1AEC0
	public static extern int CSharp_SetMultiplePositions__SWIG_2(ulong jarg1, IntPtr jarg2, ushort jarg3); // 0x0000000187867C40-0x0000000187867CD8
	public static extern int CSharp_SetMultiplePositions__SWIG_3(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4, int jarg5); // 0x0000000187867CD8-0x0000000187867D80
	public static extern int CSharp_SetMultiplePositions__SWIG_4(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4); // 0x0000000187867D80-0x0000000187867E24
	public static extern int CSharp_SetMultiplePositions__SWIG_5(ulong jarg1, IntPtr jarg2, ushort jarg3); // 0x0000000187867E24-0x0000000187867EBC
	public static extern int CSharp_SetScalingFactor(ulong jarg1, float jarg2); // 0x0000000185E86E90-0x0000000185E86ED0
	public static extern int CSharp_SetDistanceProbe(ulong jarg1, ulong jarg2); // 0x0000000187867038-0x00000001878670BC
	public static extern int CSharp_ClearBanks(); // 0x000000018785EFB0-0x000000018785EFDC
	public static extern int CSharp_SetBankLoadIOSettings(float jarg1, sbyte jarg2); // 0x0000000187866C40-0x0000000187866C7C
	public static extern int CSharp_LoadBank__SWIG_0(string jarg1, out uint jarg2, uint jarg3); // 0x0000000187862A14-0x0000000187862AB4
	public static extern int CSharp_LoadBank__SWIG_1(string jarg1, out uint jarg2); // 0x0000000187862AB4-0x0000000187862B44
	public static extern int CSharp_LoadBank__SWIG_4(uint jarg1, uint jarg2); // 0x0000000187862B44-0x0000000187862BC4
	public static extern int CSharp_LoadBank__SWIG_5(uint jarg1); // 0x000000018668F5F0-0x000000018668F670
	public static extern int CSharp_LoadBankMemoryView__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3); // 0x0000000187862798-0x000000018786282C
	public static extern int CSharp_LoadBankMemoryView__SWIG_1(IntPtr jarg1, uint jarg2, out uint jarg3, out uint jarg4); // 0x000000018786282C-0x00000001878628CC
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3); // 0x000000018786251C-0x00000001878625B0
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_1(IntPtr jarg1, uint jarg2, out uint jarg3, out uint jarg4); // 0x00000001878625B0-0x0000000187862650
	public static extern int CSharp_LoadBank__SWIG_6(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4, uint jarg5); // 0x0000000187862BC4-0x0000000187862C74
	public static extern int CSharp_LoadBank__SWIG_7(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4); // 0x0000000187862C74-0x0000000187862D20
	public static extern int CSharp_LoadBank__SWIG_10(uint jarg1, IntPtr jarg2, IntPtr jarg3, uint jarg4); // 0x0000000186119290-0x00000001861192F0
	public static extern int CSharp_LoadBank__SWIG_11(uint jarg1, IntPtr jarg2, IntPtr jarg3); // 0x0000000186119630-0x0000000186119680
	public static extern int CSharp_LoadBankMemoryView__SWIG_2(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5); // 0x00000001878628CC-0x0000000187862970
	public static extern int CSharp_LoadBankMemoryView__SWIG_3(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5, out uint jarg6); // 0x0000000187862970-0x0000000187862A14
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_2(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5); // 0x0000000187862650-0x00000001878626F4
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_3(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5, out uint jarg6); // 0x00000001878626F4-0x0000000187862798
	public static extern int CSharp_UnloadBank__SWIG_0(string jarg1, IntPtr jarg2, uint jarg3); // 0x0000000187869404-0x00000001878694A4
	public static extern int CSharp_UnloadBank__SWIG_1(string jarg1, IntPtr jarg2); // 0x0000000187869544-0x00000001878695D4
	public static extern int CSharp_UnloadBank__SWIG_4(uint jarg1, IntPtr jarg2, uint jarg3); // 0x00000001878695D4-0x0000000187869668
	public static extern int CSharp_UnloadBank__SWIG_5(uint jarg1, IntPtr jarg2); // 0x0000000187869668-0x00000001878696EC
	public static extern int CSharp_UnloadBank__SWIG_6(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5); // 0x00000001878696EC-0x000000018786979C
	public static extern int CSharp_UnloadBank__SWIG_7(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4); // 0x000000018786979C-0x0000000187869848
	public static extern int CSharp_UnloadBank__SWIG_10(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5); // 0x00000001861192F0-0x0000000186119350
	public static extern int CSharp_UnloadBank__SWIG_11(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001878694A4-0x0000000187869544
	public static extern void CSharp_CancelBankCallbackCookie(IntPtr jarg1); // 0x000000018785EDB4-0x000000018785EDE8
	public static extern int CSharp_PrepareBank__SWIG_0(int jarg1, string jarg2, int jarg3, uint jarg4); // 0x000000018786426C-0x0000000187864318
	public static extern int CSharp_PrepareBank__SWIG_1(int jarg1, string jarg2, int jarg3); // 0x0000000187864650-0x00000001878646EC
	public static extern int CSharp_PrepareBank__SWIG_2(int jarg1, string jarg2); // 0x00000001878646EC-0x0000000187864778
	public static extern int CSharp_PrepareBank__SWIG_6(int jarg1, uint jarg2, int jarg3, uint jarg4); // 0x0000000187864778-0x0000000187864818
	public static extern int CSharp_PrepareBank__SWIG_7(int jarg1, uint jarg2, int jarg3); // 0x0000000187864818-0x00000001878648A8
	public static extern int CSharp_PrepareBank__SWIG_8(int jarg1, uint jarg2); // 0x00000001878648A8-0x0000000187864928
	public static extern int CSharp_PrepareBank__SWIG_9(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, uint jarg6); // 0x0000000187864928-0x00000001878649D4
	public static extern int CSharp_PrepareBank__SWIG_10(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x0000000187864318-0x00000001878643C4
	public static extern int CSharp_PrepareBank__SWIG_11(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001878643C4-0x0000000187864470
	public static extern int CSharp_PrepareBank__SWIG_15(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, uint jarg6); // 0x0000000187864470-0x0000000187864510
	public static extern int CSharp_PrepareBank__SWIG_16(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x0000000187864510-0x00000001878645B0
	public static extern int CSharp_PrepareBank__SWIG_17(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001878645B0-0x0000000187864650
	public static extern int CSharp_ClearPreparedEvents(); // 0x000000018785F130-0x000000018785F198
	public static extern int CSharp_PrepareEvent__SWIG_0(int jarg1, IntPtr jarg2, uint jarg3); // 0x00000001878649D4-0x0000000187864A68
	public static extern int CSharp_PrepareEvent__SWIG_1(int jarg1, in uint[] jarg2, uint jarg3); // 0x0000000187864A68-0x0000000187864B04
	public static extern int CSharp_PrepareEvent__SWIG_2(int jarg1, IntPtr jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x0000000187864B04-0x0000000187864BA8
	public static extern int CSharp_PrepareEvent__SWIG_3(int jarg1, in uint[] jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x0000000186119220-0x0000000186119290
	public static extern int CSharp_SetMedia(IntPtr jarg1, uint jarg2); // 0x0000000187867964-0x00000001878679E8
	public static extern int CSharp_UnsetMedia(IntPtr jarg1, uint jarg2); // 0x00000001878699D4-0x0000000187869A58
	public static extern int CSharp_PrepareGameSyncs__SWIG_0(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5); // 0x0000000187864BA8-0x0000000187864C54
	public static extern int CSharp_PrepareGameSyncs__SWIG_1(int jarg1, int jarg2, uint jarg3, in uint[] jarg4, uint jarg5); // 0x0000000187864C54-0x0000000187864D00
	public static extern int CSharp_PrepareGameSyncs__SWIG_2(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7); // 0x0000000187864D00-0x0000000187864DAC
	public static extern int CSharp_PrepareGameSyncs__SWIG_3(int jarg1, int jarg2, uint jarg3, in uint[] jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7); // 0x0000000187864DAC-0x0000000187864E58
	public static extern int CSharp_AddListener(ulong jarg1, ulong jarg2); // 0x0000000187853B10-0x0000000187853B94
	public static extern int CSharp_RemoveListener(ulong jarg1, ulong jarg2); // 0x0000000187865464-0x00000001878654E8
	public static extern int CSharp_AddDefaultListener(ulong jarg1); // 0x0000000187853A98-0x0000000187853B10
	public static extern int CSharp_RemoveDefaultListener(ulong jarg1); // 0x00000001878652A8-0x00000001878652DC
	public static extern int CSharp_ResetListenersToDefault(ulong jarg1); // 0x0000000187865758-0x00000001878657D0
	public static extern int CSharp_SetListenerSpatialization__SWIG_0(ulong jarg1, bool jarg2, IntPtr jarg3, in float[] jarg4); // 0x00000001878676D8-0x0000000187867784
	public static extern int CSharp_SetListenerSpatialization__SWIG_1(ulong jarg1, bool jarg2, IntPtr jarg3); // 0x0000000187867784-0x0000000187867818
	public static extern int CSharp_SetRTPCValue__SWIG_0(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001878684CC-0x0000000187868530
	public static extern int CSharp_SetRTPCValue__SWIG_1(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5); // 0x0000000187868530-0x000000018786858C
	public static extern int CSharp_SetRTPCValue__SWIG_2(uint jarg1, float jarg2, ulong jarg3, int jarg4); // 0x0000000185778AE0-0x0000000185778B40
	public static extern int CSharp_SetRTPCValue__SWIG_3(uint jarg1, float jarg2, ulong jarg3); // 0x000000018786858C-0x00000001878685D8
	public static extern int CSharp_SetRTPCValue__SWIG_4(uint jarg1, float jarg2); // 0x00000001878685D8-0x0000000187868614
	public static extern int CSharp_SetRTPCValue__SWIG_5(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6); // 0x0000000187868614-0x0000000187868684
	public static extern int CSharp_SetRTPCValue__SWIG_6(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5); // 0x0000000187868684-0x00000001878686EC
	public static extern int CSharp_SetRTPCValue__SWIG_7(string jarg1, float jarg2, ulong jarg3, int jarg4); // 0x00000001878686EC-0x0000000187868754
	public static extern int CSharp_SetRTPCValue__SWIG_8(string jarg1, float jarg2, ulong jarg3); // 0x0000000187868754-0x00000001878687AC
	public static extern int CSharp_SetRTPCValue__SWIG_9(string jarg1, float jarg2); // 0x00000001878687AC-0x00000001878687F4
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_0(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6); // 0x0000000187868228-0x000000018786828C
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_1(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5); // 0x000000018786828C-0x00000001878682E8
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_2(uint jarg1, float jarg2, uint jarg3, int jarg4); // 0x00000001862BE2D0-0x00000001862BE330
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_3(uint jarg1, float jarg2, uint jarg3); // 0x00000001878682E8-0x0000000187868334
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_4(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6); // 0x0000000187868334-0x00000001878683A4
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_5(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5); // 0x00000001878683A4-0x000000018786840C
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_6(string jarg1, float jarg2, uint jarg3, int jarg4); // 0x000000018786840C-0x0000000187868474
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_7(string jarg1, float jarg2, uint jarg3); // 0x0000000187868474-0x00000001878684CC
	public static extern int CSharp_ResetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5); // 0x0000000187865CC0-0x0000000187865D70
	public static extern int CSharp_ResetRTPCValue__SWIG_1(uint jarg1, ulong jarg2, int jarg3, int jarg4); // 0x0000000187865D70-0x0000000187865E10
	public static extern int CSharp_ResetRTPCValue__SWIG_2(uint jarg1, ulong jarg2, int jarg3); // 0x0000000187865E10-0x0000000187865EA4
	public static extern int CSharp_ResetRTPCValue__SWIG_3(uint jarg1, ulong jarg2); // 0x0000000187865EA4-0x0000000187865EE4
	public static extern int CSharp_ResetRTPCValue__SWIG_4(uint jarg1); // 0x0000000187865EE4-0x0000000187865F18
	public static extern int CSharp_ResetRTPCValue__SWIG_5(string jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5); // 0x0000000187865F18-0x0000000187865FD8
	public static extern int CSharp_ResetRTPCValue__SWIG_6(string jarg1, ulong jarg2, int jarg3, int jarg4); // 0x0000000187865FD8-0x0000000187866084
	public static extern int CSharp_ResetRTPCValue__SWIG_7(string jarg1, ulong jarg2, int jarg3); // 0x0000000187866084-0x0000000187866120
	public static extern int CSharp_ResetRTPCValue__SWIG_8(string jarg1, ulong jarg2); // 0x0000000187866120-0x00000001878661B0
	public static extern int CSharp_ResetRTPCValue__SWIG_9(string jarg1); // 0x00000001878661B0-0x0000000187866230
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_0(uint jarg1, uint jarg2, int jarg3, int jarg4, bool jarg5); // 0x00000001878657D0-0x0000000187865880
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_1(uint jarg1, uint jarg2, int jarg3, int jarg4); // 0x0000000187865880-0x0000000187865920
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_2(uint jarg1, uint jarg2, int jarg3); // 0x0000000187865920-0x00000001878659B0
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_3(uint jarg1, uint jarg2); // 0x00000001878659B0-0x0000000187865A30
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_4(string jarg1, uint jarg2, int jarg3, int jarg4, bool jarg5); // 0x0000000187865A30-0x0000000187865AEC
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_5(string jarg1, uint jarg2, int jarg3, int jarg4); // 0x0000000187865AEC-0x0000000187865B98
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_6(string jarg1, uint jarg2, int jarg3); // 0x0000000187865B98-0x0000000187865C34
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_7(string jarg1, uint jarg2); // 0x0000000187865C34-0x0000000187865CC0
	public static extern int CSharp_SetSwitch__SWIG_0(uint jarg1, uint jarg2, ulong jarg3); // 0x0000000187868AA8-0x0000000187868B38
	public static extern int CSharp_SetSwitch__SWIG_1(string jarg1, string jarg2, ulong jarg3); // 0x0000000187868B38-0x0000000187868BE0
	public static extern int CSharp_PostTrigger__SWIG_0(uint jarg1, ulong jarg2); // 0x000000018786419C-0x00000001878641DC
	public static extern int CSharp_PostTrigger__SWIG_1(string jarg1, ulong jarg2); // 0x00000001878641DC-0x000000018786426C
	public static extern int CSharp_SetState__SWIG_0(uint jarg1, uint jarg2); // 0x0000000185AC0580-0x0000000185AC05C0
	public static extern int CSharp_SetState__SWIG_1(string jarg1, string jarg2); // 0x0000000187868A10-0x0000000187868AA8
	public static extern int CSharp_SetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, uint jarg3); // 0x0000000187867224-0x00000001878672B8
	public static extern int CSharp_SetGameObjectOutputBusVolume(ulong jarg1, ulong jarg2, float jarg3); // 0x000000018786733C-0x0000000187867388
	public static extern int CSharp_SetActorMixerEffect(uint jarg1, uint jarg2, uint jarg3); // 0x0000000187866B18-0x0000000187866BA8
	public static extern int CSharp_SetBusEffect__SWIG_0(uint jarg1, uint jarg2, uint jarg3); // 0x0000000187866F0C-0x0000000187866F9C
	public static extern int CSharp_SetBusEffect__SWIG_1(string jarg1, uint jarg2, uint jarg3); // 0x0000000187866F9C-0x0000000187867038
	public static extern int CSharp_SetOutputDeviceEffect(ulong jarg1, uint jarg2, uint jarg3); // 0x0000000187867FC4-0x0000000187868058
	public static extern int CSharp_SetMixer__SWIG_0(uint jarg1, uint jarg2); // 0x00000001878679E8-0x0000000187867A68
	public static extern int CSharp_SetMixer__SWIG_1(string jarg1, uint jarg2); // 0x0000000187867A68-0x0000000187867AF4
	public static extern int CSharp_SetBusConfig__SWIG_0(uint jarg1, IntPtr jarg2); // 0x0000000187866CBC-0x0000000187866D40
	public static extern int CSharp_SetBusConfig__SWIG_1(string jarg1, IntPtr jarg2); // 0x0000000187866D40-0x0000000187866DD0
	public static extern int CSharp_SetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, float jarg3, float jarg4); // 0x0000000187867EBC-0x0000000187867F18
	public static extern int CSharp_SetMultipleObstructionAndOcclusion(ulong jarg1, ulong jarg2, IntPtr jarg3, uint jarg4); // 0x0000000187867AF4-0x0000000187867B98
	public static extern int CSharp_StartOutputCapture(string jarg1); // 0x0000000187868C48-0x0000000187868CC8
	public static extern int CSharp_StopOutputCapture(); // 0x0000000187869008-0x0000000187869034
	public static extern int CSharp_AddOutputCaptureMarker(string jarg1); // 0x0000000187853BD4-0x0000000187853C6C
	public static extern int CSharp_AddOutputCaptureBinaryMarker(IntPtr jarg1, uint jarg2); // 0x0000000187853B94-0x0000000187853BD4
	public static extern uint CSharp_GetSampleRate(); // 0x000000018786162C-0x0000000187861658
	public static extern int CSharp_StartProfilerCapture(string jarg1); // 0x0000000187868CF4-0x0000000187868D74
	public static extern int CSharp_StopProfilerCapture(); // 0x00000001878691E8-0x0000000187869214
	public static extern int CSharp_SetOfflineRenderingFrameTime(float jarg1); // 0x0000000187867F18-0x0000000187867F4C
	public static extern int CSharp_SetOfflineRendering(bool jarg1); // 0x0000000187867F4C-0x0000000187867FC4
	public static extern int CSharp_RemoveOutput(ulong jarg1); // 0x00000001878654E8-0x0000000187865560
	public static extern int CSharp_ReplaceOutput__SWIG_0(IntPtr jarg1, ulong jarg2, out ulong jarg3); // 0x0000000187865640-0x00000001878656D4
	public static extern int CSharp_ReplaceOutput__SWIG_1(IntPtr jarg1, ulong jarg2); // 0x00000001878656D4-0x0000000187865758
	public static extern ulong CSharp_GetOutputID__SWIG_0(uint jarg1, uint jarg2); // 0x0000000187860F5C-0x0000000187860FDC
	public static extern ulong CSharp_GetOutputID__SWIG_1(string jarg1, uint jarg2); // 0x0000000187860FDC-0x000000018786107C
	public static extern int CSharp_SetBusDevice__SWIG_0(uint jarg1, uint jarg2); // 0x0000000187866DD0-0x0000000187866E50
	public static extern int CSharp_SetBusDevice__SWIG_1(string jarg1, string jarg2); // 0x0000000187866E50-0x0000000187866F0C
	public static extern int CSharp_GetDeviceList__SWIG_0(uint jarg1, uint jarg2, out uint jarg3, IntPtr jarg4); // 0x00000001878608D0-0x0000000187860970
	public static extern int CSharp_GetDeviceList__SWIG_1(uint jarg1, out uint jarg2, IntPtr jarg3); // 0x00000001862E6E80-0x00000001862E6ED0
	public static extern int CSharp_SetOutputVolume(ulong jarg1, float jarg2); // 0x0000000187868058-0x0000000187868094
	public static extern int CSharp_GetDeviceSpatialAudioSupport(uint jarg1); // 0x00000001862E6D20-0x00000001862E6D60
	public static extern int CSharp_Suspend__SWIG_0(bool jarg1, bool jarg2); // 0x0000000187869248-0x00000001878692CC
	public static extern int CSharp_Suspend__SWIG_1(bool jarg1); // 0x00000001878692CC-0x0000000187869344
	public static extern int CSharp_Suspend__SWIG_2(); // 0x0000000187869344-0x0000000187869370
	public static extern int CSharp_WakeupFromSuspend__SWIG_0(uint jarg1); // 0x0000000187869AD0-0x0000000187869B04
	public static extern int CSharp_WakeupFromSuspend__SWIG_1(); // 0x0000000187869B04-0x0000000187869B30
	public static extern uint CSharp_GetBufferTick(); // 0x0000000187860534-0x0000000187860560
	public static extern ulong CSharp_GetSampleTick(); // 0x0000000187861658-0x0000000187861684
	public static extern void CSharp_AkSegmentInfo_iCurrentPosition_set(IntPtr jarg1, int jarg2); // 0x000000018785DA90-0x000000018785DB14
	public static extern int CSharp_AkSegmentInfo_iCurrentPosition_get(IntPtr jarg1); // 0x000000018785DA54-0x000000018785DA90
	public static extern void CSharp_AkSegmentInfo_iPreEntryDuration_set(IntPtr jarg1, int jarg2); // 0x000000018785DBBC-0x000000018785DBFC
	public static extern int CSharp_AkSegmentInfo_iPreEntryDuration_get(IntPtr jarg1); // 0x000000018785DB88-0x000000018785DBBC
	public static extern void CSharp_AkSegmentInfo_iActiveDuration_set(IntPtr jarg1, int jarg2); // 0x000000018785DA14-0x000000018785DA54
	public static extern int CSharp_AkSegmentInfo_iActiveDuration_get(IntPtr jarg1); // 0x000000018785D9D8-0x000000018785DA14
	public static extern void CSharp_AkSegmentInfo_iPostExitDuration_set(IntPtr jarg1, int jarg2); // 0x000000018785DB48-0x000000018785DB88
	public static extern int CSharp_AkSegmentInfo_iPostExitDuration_get(IntPtr jarg1); // 0x000000018785DB14-0x000000018785DB48
	public static extern void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(IntPtr jarg1, int jarg2); // 0x000000018785DC38-0x000000018785DC78
	public static extern int CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1); // 0x000000018785DBFC-0x000000018785DC38
	public static extern void CSharp_AkSegmentInfo_fBeatDuration_set(IntPtr jarg1, float jarg2); // 0x000000018785D8AC-0x000000018785D8F0
	public static extern float CSharp_AkSegmentInfo_fBeatDuration_get(IntPtr jarg1); // 0x000000018785D878-0x000000018785D8AC
	public static extern void CSharp_AkSegmentInfo_fBarDuration_set(IntPtr jarg1, float jarg2); // 0x000000018785D834-0x000000018785D878
	public static extern float CSharp_AkSegmentInfo_fBarDuration_get(IntPtr jarg1); // 0x000000018785D800-0x000000018785D834
	public static extern void CSharp_AkSegmentInfo_fGridDuration_set(IntPtr jarg1, float jarg2); // 0x000000018785D924-0x000000018785D968
	public static extern float CSharp_AkSegmentInfo_fGridDuration_get(IntPtr jarg1); // 0x000000018785D8F0-0x000000018785D924
	public static extern void CSharp_AkSegmentInfo_fGridOffset_set(IntPtr jarg1, float jarg2); // 0x000000018785D99C-0x000000018785D9D8
	public static extern float CSharp_AkSegmentInfo_fGridOffset_get(IntPtr jarg1); // 0x000000018785D968-0x000000018785D99C
	public static extern IntPtr CSharp_new_AkSegmentInfo(); // 0x000000018786BA94-0x000000018786BAC0
	public static extern void CSharp_delete_AkSegmentInfo(IntPtr jarg1); // 0x000000018786A74C-0x000000018786A780
	public static extern void CSharp_AkResourceMonitorDataSummary_totalCPU_set(IntPtr jarg1, float jarg2); // 0x000000018785D470-0x000000018785D4B4
	public static extern float CSharp_AkResourceMonitorDataSummary_totalCPU_get(IntPtr jarg1); // 0x000000018785D43C-0x000000018785D470
	public static extern void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(IntPtr jarg1, float jarg2); // 0x000000018785D400-0x000000018785D43C
	public static extern float CSharp_AkResourceMonitorDataSummary_pluginCPU_get(IntPtr jarg1); // 0x000000018785D3CC-0x000000018785D400
	public static extern void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(IntPtr jarg1, uint jarg2); // 0x000000018785D38C-0x000000018785D3CC
	public static extern uint CSharp_AkResourceMonitorDataSummary_physicalVoices_get(IntPtr jarg1); // 0x000000018785D358-0x000000018785D38C
	public static extern void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(IntPtr jarg1, uint jarg2); // 0x000000018785D55C-0x000000018785D59C
	public static extern uint CSharp_AkResourceMonitorDataSummary_virtualVoices_get(IntPtr jarg1); // 0x000000018785D528-0x000000018785D55C
	public static extern void CSharp_AkResourceMonitorDataSummary_totalVoices_set(IntPtr jarg1, uint jarg2); // 0x000000018785D4E8-0x000000018785D528
	public static extern uint CSharp_AkResourceMonitorDataSummary_totalVoices_get(IntPtr jarg1); // 0x000000018785D4B4-0x000000018785D4E8
	public static extern void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(IntPtr jarg1, uint jarg2); // 0x000000018785D318-0x000000018785D358
	public static extern uint CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(IntPtr jarg1); // 0x000000018785D2E4-0x000000018785D318
	public static extern IntPtr CSharp_new_AkResourceMonitorDataSummary(); // 0x00000001865E9430-0x00000001865E9460
	public static extern void CSharp_delete_AkResourceMonitorDataSummary(IntPtr jarg1); // 0x000000018786A6E4-0x000000018786A718
	public static extern byte CSharp_AK_INVALID_MIDI_CHANNEL_get(); // 0x0000000187853700-0x0000000187853768
	public static extern byte CSharp_AK_INVALID_MIDI_NOTE_get(); // 0x0000000187853768-0x0000000187853794
	public static extern void CSharp_AkMIDIEvent_byChan_set(IntPtr jarg1, byte jarg2); // 0x0000000187858B34-0x0000000187858B74
	public static extern byte CSharp_AkMIDIEvent_byChan_get(IntPtr jarg1); // 0x0000000187858B00-0x0000000187858B34
	public static extern void CSharp_AkMIDIEvent_tGen_byParam1_set(IntPtr jarg1, byte jarg2); // 0x0000000187859140-0x0000000187859180
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam1_get(IntPtr jarg1); // 0x000000018785910C-0x0000000187859140
	public static extern void CSharp_AkMIDIEvent_tGen_byParam2_set(IntPtr jarg1, byte jarg2); // 0x00000001878591F8-0x0000000187859238
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam2_get(IntPtr jarg1); // 0x0000000187859180-0x00000001878591F8
	public static extern IntPtr CSharp_new_AkMIDIEvent_tGen(); // 0x000000018786B368-0x000000018786B394
	public static extern void CSharp_delete_AkMIDIEvent_tGen(IntPtr jarg1); // 0x000000018786A1D0-0x000000018786A204
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(IntPtr jarg1, byte jarg2); // 0x0000000187859398-0x00000001878593D8
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(IntPtr jarg1); // 0x0000000187859364-0x0000000187859398
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(IntPtr jarg1, byte jarg2); // 0x000000018785940C-0x0000000187859490
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(IntPtr jarg1); // 0x00000001878593D8-0x000000018785940C
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff(); // 0x000000018786B3C0-0x000000018786B3EC
	public static extern void CSharp_delete_AkMIDIEvent_tNoteOnOff(IntPtr jarg1); // 0x000000018786A238-0x000000018786A26C
	public static extern void CSharp_AkMIDIEvent_tCc_byCc_set(IntPtr jarg1, byte jarg2); // 0x0000000187858F5C-0x0000000187858F9C
	public static extern byte CSharp_AkMIDIEvent_tCc_byCc_get(IntPtr jarg1); // 0x0000000187858F28-0x0000000187858F5C
	public static extern void CSharp_AkMIDIEvent_tCc_byValue_set(IntPtr jarg1, byte jarg2); // 0x0000000187859014-0x0000000187859098
	public static extern byte CSharp_AkMIDIEvent_tCc_byValue_get(IntPtr jarg1); // 0x0000000187858F9C-0x0000000187859014
	public static extern IntPtr CSharp_new_AkMIDIEvent_tCc(); // 0x000000018786B310-0x000000018786B33C
	public static extern void CSharp_delete_AkMIDIEvent_tCc(IntPtr jarg1); // 0x000000018786A168-0x000000018786A19C
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(IntPtr jarg1, byte jarg2); // 0x00000001878594C4-0x0000000187859548
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(IntPtr jarg1); // 0x0000000187859490-0x00000001878594C4
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(IntPtr jarg1, byte jarg2); // 0x000000018785957C-0x0000000187859600
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(IntPtr jarg1); // 0x0000000187859548-0x000000018785957C
	public static extern IntPtr CSharp_new_AkMIDIEvent_tPitchBend(); // 0x000000018786B3EC-0x000000018786B418
	public static extern void CSharp_delete_AkMIDIEvent_tPitchBend(IntPtr jarg1); // 0x000000018786A26C-0x000000018786A2A0
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(IntPtr jarg1, byte jarg2); // 0x000000018785926C-0x00000001878592AC
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(IntPtr jarg1); // 0x0000000187859238-0x000000018785926C
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(IntPtr jarg1, byte jarg2); // 0x0000000187859324-0x0000000187859364
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(IntPtr jarg1); // 0x00000001878592AC-0x0000000187859324
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch(); // 0x000000018786B394-0x000000018786B3C0
	public static extern void CSharp_delete_AkMIDIEvent_tNoteAftertouch(IntPtr jarg1); // 0x000000018786A204-0x000000018786A238
	public static extern void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(IntPtr jarg1, byte jarg2); // 0x00000001878590CC-0x000000018785910C
	public static extern byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(IntPtr jarg1); // 0x0000000187859098-0x00000001878590CC
	public static extern IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch(); // 0x000000018786B33C-0x000000018786B368
	public static extern void CSharp_delete_AkMIDIEvent_tChanAftertouch(IntPtr jarg1); // 0x000000018786A19C-0x000000018786A1D0
	public static extern void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(IntPtr jarg1, byte jarg2); // 0x0000000187859678-0x00000001878596B8
	public static extern byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(IntPtr jarg1); // 0x0000000187859600-0x0000000187859678
	public static extern IntPtr CSharp_new_AkMIDIEvent_tProgramChange(); // 0x000000018786B418-0x000000018786B444
	public static extern void CSharp_delete_AkMIDIEvent_tProgramChange(IntPtr jarg1); // 0x000000018786A2A0-0x000000018786A2D4
	public static extern void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(IntPtr jarg1, ushort jarg2); // 0x00000001878597A4-0x0000000187859828
	public static extern ushort CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(IntPtr jarg1); // 0x0000000187859770-0x00000001878597A4
	public static extern void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(IntPtr jarg1, uint jarg2); // 0x00000001878596EC-0x0000000187859770
	public static extern uint CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(IntPtr jarg1); // 0x00000001878596B8-0x00000001878596EC
	public static extern IntPtr CSharp_new_AkMIDIEvent_tWwiseCmd(); // 0x000000018786B444-0x000000018786B478
	public static extern void CSharp_delete_AkMIDIEvent_tWwiseCmd(IntPtr jarg1); // 0x000000018786A2D4-0x000000018786A308
	public static extern void CSharp_AkMIDIEvent_Gen_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187858574-0x00000001878585B8
	public static extern IntPtr CSharp_AkMIDIEvent_Gen_get(IntPtr jarg1); // 0x0000000187858540-0x0000000187858574
	public static extern void CSharp_AkMIDIEvent_Cc_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785843C-0x00000001878584C0
	public static extern IntPtr CSharp_AkMIDIEvent_Cc_get(IntPtr jarg1); // 0x0000000187858408-0x000000018785843C
	public static extern void CSharp_AkMIDIEvent_NoteOnOff_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187858664-0x00000001878586A8
	public static extern IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(IntPtr jarg1); // 0x0000000187858630-0x0000000187858664
	public static extern void CSharp_AkMIDIEvent_PitchBend_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001878586E4-0x0000000187858728
	public static extern IntPtr CSharp_AkMIDIEvent_PitchBend_get(IntPtr jarg1); // 0x00000001878586A8-0x00000001878586E4
	public static extern void CSharp_AkMIDIEvent_NoteAftertouch_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001878585EC-0x0000000187858630
	public static extern IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(IntPtr jarg1); // 0x00000001878585B8-0x00000001878585EC
	public static extern void CSharp_AkMIDIEvent_ChanAftertouch_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001878584FC-0x0000000187858540
	public static extern IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(IntPtr jarg1); // 0x00000001878584C0-0x00000001878584FC
	public static extern void CSharp_AkMIDIEvent_ProgramChange_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785875C-0x00000001878587A0
	public static extern IntPtr CSharp_AkMIDIEvent_ProgramChange_get(IntPtr jarg1); // 0x0000000187858728-0x000000018785875C
	public static extern void CSharp_AkMIDIEvent_WwiseCmd_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001878587DC-0x0000000187858820
	public static extern IntPtr CSharp_AkMIDIEvent_WwiseCmd_get(IntPtr jarg1); // 0x00000001878587A0-0x00000001878587DC
	public static extern void CSharp_AkMIDIEvent_byType_set(IntPtr jarg1, int jarg2); // 0x0000000187858D8C-0x0000000187858DCC
	public static extern int CSharp_AkMIDIEvent_byType_get(IntPtr jarg1); // 0x0000000187858D58-0x0000000187858D8C
	public static extern void CSharp_AkMIDIEvent_byOnOffNote_set(IntPtr jarg1, byte jarg2); // 0x0000000187858C60-0x0000000187858CE4
	public static extern byte CSharp_AkMIDIEvent_byOnOffNote_get(IntPtr jarg1); // 0x0000000187858C2C-0x0000000187858C60
	public static extern void CSharp_AkMIDIEvent_byVelocity_set(IntPtr jarg1, byte jarg2); // 0x0000000187858EE8-0x0000000187858F28
	public static extern byte CSharp_AkMIDIEvent_byVelocity_get(IntPtr jarg1); // 0x0000000187858EB4-0x0000000187858EE8
	public static extern void CSharp_AkMIDIEvent_byCc_set(IntPtr jarg1, int jarg2); // 0x00000001878589C4-0x0000000187858A04
	public static extern int CSharp_AkMIDIEvent_byCc_get(IntPtr jarg1); // 0x0000000187858990-0x00000001878589C4
	public static extern void CSharp_AkMIDIEvent_byCcValue_set(IntPtr jarg1, byte jarg2); // 0x0000000187858950-0x0000000187858990
	public static extern byte CSharp_AkMIDIEvent_byCcValue_get(IntPtr jarg1); // 0x00000001878588D8-0x0000000187858950
	public static extern void CSharp_AkMIDIEvent_byValueLsb_set(IntPtr jarg1, byte jarg2); // 0x0000000187858E00-0x0000000187858E40
	public static extern byte CSharp_AkMIDIEvent_byValueLsb_get(IntPtr jarg1); // 0x0000000187858DCC-0x0000000187858E00
	public static extern void CSharp_AkMIDIEvent_byValueMsb_set(IntPtr jarg1, byte jarg2); // 0x0000000187858E74-0x0000000187858EB4
	public static extern byte CSharp_AkMIDIEvent_byValueMsb_get(IntPtr jarg1); // 0x0000000187858E40-0x0000000187858E74
	public static extern void CSharp_AkMIDIEvent_byAftertouchNote_set(IntPtr jarg1, byte jarg2); // 0x0000000187858854-0x00000001878588D8
	public static extern byte CSharp_AkMIDIEvent_byAftertouchNote_get(IntPtr jarg1); // 0x0000000187858820-0x0000000187858854
	public static extern void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(IntPtr jarg1, byte jarg2); // 0x0000000187858BEC-0x0000000187858C2C
	public static extern byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(IntPtr jarg1); // 0x0000000187858B74-0x0000000187858BEC
	public static extern void CSharp_AkMIDIEvent_byChanAftertouchValue_set(IntPtr jarg1, byte jarg2); // 0x0000000187858A7C-0x0000000187858B00
	public static extern byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(IntPtr jarg1); // 0x0000000187858A04-0x0000000187858A7C
	public static extern void CSharp_AkMIDIEvent_byProgramNum_set(IntPtr jarg1, byte jarg2); // 0x0000000187858D18-0x0000000187858D58
	public static extern byte CSharp_AkMIDIEvent_byProgramNum_get(IntPtr jarg1); // 0x0000000187858CE4-0x0000000187858D18
	public static extern void CSharp_AkMIDIEvent_uCmd_set(IntPtr jarg1, ushort jarg2); // 0x0000000187859914-0x0000000187859998
	public static extern ushort CSharp_AkMIDIEvent_uCmd_get(IntPtr jarg1); // 0x000000018785989C-0x0000000187859914
	public static extern void CSharp_AkMIDIEvent_uArg_set(IntPtr jarg1, uint jarg2); // 0x000000018785985C-0x000000018785989C
	public static extern uint CSharp_AkMIDIEvent_uArg_get(IntPtr jarg1); // 0x0000000187859828-0x000000018785985C
	public static extern IntPtr CSharp_new_AkMIDIEvent(); // 0x000000018786B2E4-0x000000018786B310
	public static extern void CSharp_delete_AkMIDIEvent(IntPtr jarg1); // 0x000000018786A134-0x000000018786A168
	public static extern void CSharp_AkMIDIPost_uOffset_set(IntPtr jarg1, ulong jarg2); // 0x0000000187859D6C-0x0000000187859DB0
	public static extern ulong CSharp_AkMIDIPost_uOffset_get(IntPtr jarg1); // 0x0000000187859CF4-0x0000000187859D6C
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_0(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4); // 0x0000000187859A08-0x0000000187859AA8
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_1(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5); // 0x0000000187859AA8-0x0000000187859B58
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_2(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8); // 0x0000000187859B58-0x0000000187859C08
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_3(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8, uint jarg9); // 0x0000000187859C08-0x0000000187859CC0
	public static extern void CSharp_AkMIDIPost_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000187859998-0x00000001878599DC
	public static extern int CSharp_AkMIDIPost_GetSizeOf(); // 0x00000001878599DC-0x0000000187859A08
	public static extern IntPtr CSharp_new_AkMIDIPost(); // 0x000000018786B478-0x000000018786B4A4
	public static extern void CSharp_delete_AkMIDIPost(IntPtr jarg1); // 0x000000018786A308-0x000000018786A33C
	public static extern void CSharp_AkMemCategroyStats_uUsed_set(IntPtr jarg1, ulong jarg2); // 0x000000018785A064-0x000000018785A0E8
	public static extern ulong CSharp_AkMemCategroyStats_uUsed_get(IntPtr jarg1); // 0x000000018785A030-0x000000018785A064
	public static extern void CSharp_AkMemCategroyStats_uPeakUsed_set(IntPtr jarg1, ulong jarg2); // 0x0000000187859FAC-0x000000018785A030
	public static extern ulong CSharp_AkMemCategroyStats_uPeakUsed_get(IntPtr jarg1); // 0x0000000187859F34-0x0000000187859FAC
	public static extern void CSharp_AkMemCategroyStats_uAllocs_set(IntPtr jarg1, uint jarg2); // 0x0000000187859E80-0x0000000187859EC0
	public static extern uint CSharp_AkMemCategroyStats_uAllocs_get(IntPtr jarg1); // 0x0000000187859E4C-0x0000000187859E80
	public static extern void CSharp_AkMemCategroyStats_uFrees_set(IntPtr jarg1, uint jarg2); // 0x0000000187859EF4-0x0000000187859F34
	public static extern uint CSharp_AkMemCategroyStats_uFrees_get(IntPtr jarg1); // 0x0000000187859EC0-0x0000000187859EF4
	public static extern IntPtr CSharp_new_AkMemCategroyStats(); // 0x00000001862FA960-0x00000001862FA990
	public static extern void CSharp_delete_AkMemCategroyStats(IntPtr jarg1); // 0x000000018786A370-0x000000018786A3A4
	public static extern void CSharp_AkMemGlobalStats_uUsed_set(IntPtr jarg1, ulong jarg2); // 0x000000018785A488-0x000000018785A50C
	public static extern ulong CSharp_AkMemGlobalStats_uUsed_get(IntPtr jarg1); // 0x000000018785A410-0x000000018785A488
	public static extern void CSharp_AkMemGlobalStats_uDeviceUsed_set(IntPtr jarg1, ulong jarg2); // 0x000000018785A1D4-0x000000018785A258
	public static extern ulong CSharp_AkMemGlobalStats_uDeviceUsed_get(IntPtr jarg1); // 0x000000018785A1A0-0x000000018785A1D4
	public static extern void CSharp_AkMemGlobalStats_uReserved_set(IntPtr jarg1, ulong jarg2); // 0x000000018785A38C-0x000000018785A410
	public static extern ulong CSharp_AkMemGlobalStats_uReserved_get(IntPtr jarg1); // 0x000000018785A314-0x000000018785A38C
	public static extern void CSharp_AkMemGlobalStats_uMax_set(IntPtr jarg1, ulong jarg2); // 0x000000018785A2D0-0x000000018785A314
	public static extern ulong CSharp_AkMemGlobalStats_uMax_get(IntPtr jarg1); // 0x000000018785A258-0x000000018785A2D0
	public static extern IntPtr CSharp_new_AkMemGlobalStats(); // 0x000000018786B4D0-0x000000018786B4FC
	public static extern void CSharp_delete_AkMemGlobalStats(IntPtr jarg1); // 0x000000018786A3A4-0x000000018786A3D8
	public static extern void CSharp_AkMemGetCategoryStats(int jarg1, IntPtr jarg2); // 0x000000018785A0E8-0x000000018785A16C
	public static extern void CSharp_AkMemGetGlobalStats(IntPtr jarg1); // 0x000000018785A16C-0x000000018785A1A0
	public static extern void CSharp_StartProfileThreadUsage(); // 0x0000000187868CC8-0x0000000187868CF4
	public static extern ulong CSharp_StopProfileThreadUsage(); // 0x00000001878691BC-0x00000001878691E8
	public static extern void CSharp_DumpToFile(string jarg1); // 0x000000018785F360-0x000000018785F3E0
	public static extern ulong CSharp_GetGlobalUsed(); // 0x0000000187860C98-0x0000000187860CC4
	public static extern ulong CSharp_GetGlobalReserved(); // 0x0000000187860C30-0x0000000187860C98
	public static extern void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(IntPtr jarg1, float jarg2); // 0x0000000186805300-0x0000000186805350
	public static extern float CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(IntPtr jarg1); // 0x000000018785A72C-0x000000018785A760
	public static extern void CSharp_delete_AkMusicSettings(IntPtr jarg1); // 0x000000018786A440-0x000000018786A474
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_0(uint jarg1, IntPtr jarg2, bool jarg3); // 0x0000000187861284-0x0000000187861318
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_1(uint jarg1, IntPtr jarg2); // 0x0000000187861318-0x000000018786139C
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(IntPtr jarg1); // 0x000000018577F440-0x000000018577F480
	public static extern uint CSharp_AkSerializedCallbackHeader_eType_get(IntPtr jarg1); // 0x000000018577F500-0x000000018577F540
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_GetData(IntPtr jarg1); // 0x000000018577F400-0x000000018577F440
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(IntPtr jarg1); // 0x000000018577F480-0x000000018577F500
	public static extern IntPtr CSharp_new_AkSerializedCallbackHeader(); // 0x000000018786BAC0-0x000000018786BAEC
	public static extern void CSharp_delete_AkSerializedCallbackHeader(IntPtr jarg1); // 0x000000018786A780-0x000000018786A7B4
	public static extern IntPtr CSharp_AkCallbackInfo_pCookie_get(IntPtr jarg1); // 0x000000018577C7F0-0x000000018577C870
	public static extern ulong CSharp_AkCallbackInfo_gameObjID_get(IntPtr jarg1); // 0x000000018577C720-0x000000018577C750
	public static extern IntPtr CSharp_new_AkCallbackInfo(); // 0x000000018786ACE4-0x000000018786AD10
	public static extern void CSharp_delete_AkCallbackInfo(IntPtr jarg1); // 0x0000000187869DC0-0x0000000187869DF4
	public static extern uint CSharp_AkEventCallbackInfo_playingID_get(IntPtr jarg1); // 0x0000000187856A54-0x0000000187856A88
	public static extern uint CSharp_AkEventCallbackInfo_eventID_get(IntPtr jarg1); // 0x000000018577C8C0-0x000000018577C950
	public static extern IntPtr CSharp_new_AkEventCallbackInfo(); // 0x000000018786AE98-0x000000018786AEC4
	public static extern void CSharp_delete_AkEventCallbackInfo(IntPtr jarg1); // 0x0000000187869F60-0x0000000187869F94
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChan_get(IntPtr jarg1); // 0x0000000187858134-0x0000000187858168
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(IntPtr jarg1); // 0x00000001878581D0-0x0000000187858204
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(IntPtr jarg1); // 0x0000000187858204-0x000000018785827C
	public static extern int CSharp_AkMIDIEventCallbackInfo_byType_get(IntPtr jarg1); // 0x00000001878582B0-0x00000001878582E4
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(IntPtr jarg1); // 0x000000018785819C-0x00000001878581D0
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(IntPtr jarg1); // 0x0000000187858390-0x0000000187858408
	public static extern int CSharp_AkMIDIEventCallbackInfo_byCc_get(IntPtr jarg1); // 0x00000001878580CC-0x0000000187858100
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(IntPtr jarg1); // 0x0000000187858098-0x00000001878580CC
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(IntPtr jarg1); // 0x00000001878582E4-0x000000018785835C
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(IntPtr jarg1); // 0x000000018785835C-0x0000000187858390
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(IntPtr jarg1); // 0x0000000187858064-0x0000000187858098
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(IntPtr jarg1); // 0x0000000187858168-0x000000018785819C
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(IntPtr jarg1); // 0x0000000187858100-0x0000000187858134
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(IntPtr jarg1); // 0x000000018785827C-0x00000001878582B0
	public static extern IntPtr CSharp_new_AkMIDIEventCallbackInfo(); // 0x000000018786B2B8-0x000000018786B2E4
	public static extern void CSharp_delete_AkMIDIEventCallbackInfo(IntPtr jarg1); // 0x000000018786A100-0x000000018786A134
	public static extern uint CSharp_AkMarkerCallbackInfo_uIdentifier_get(IntPtr jarg1); // 0x0000000187859DE4-0x0000000187859E18
	public static extern uint CSharp_AkMarkerCallbackInfo_uPosition_get(IntPtr jarg1); // 0x0000000187859E18-0x0000000187859E4C
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(IntPtr jarg1); // 0x0000000187859DB0-0x0000000187859DE4
	public static extern IntPtr CSharp_new_AkMarkerCallbackInfo(); // 0x000000018786B4A4-0x000000018786B4D0
	public static extern void CSharp_delete_AkMarkerCallbackInfo(IntPtr jarg1); // 0x000000018786A33C-0x000000018786A370
	public static extern float CSharp_AkDurationCallbackInfo_fDuration_get(IntPtr jarg1); // 0x0000000187856914-0x0000000187856948
	public static extern float CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(IntPtr jarg1); // 0x0000000187856948-0x000000018785697C
	public static extern uint CSharp_AkDurationCallbackInfo_audioNodeID_get(IntPtr jarg1); // 0x00000001878568A8-0x00000001878568DC
	public static extern uint CSharp_AkDurationCallbackInfo_mediaID_get(IntPtr jarg1); // 0x000000018785697C-0x00000001878569B0
	public static extern bool CSharp_AkDurationCallbackInfo_bStreaming_get(IntPtr jarg1); // 0x00000001878568DC-0x0000000187856914
	public static extern IntPtr CSharp_new_AkDurationCallbackInfo(); // 0x000000018786AE40-0x000000018786AE6C
	public static extern void CSharp_delete_AkDurationCallbackInfo(IntPtr jarg1); // 0x0000000187869EF8-0x0000000187869F2C
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(IntPtr jarg1); // 0x0000000187856A20-0x0000000187856A54
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(IntPtr jarg1); // 0x00000001878569B0-0x00000001878569E4
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(IntPtr jarg1); // 0x00000001878569E4-0x0000000187856A20
	public static extern IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo(); // 0x000000018786AE6C-0x000000018786AE98
	public static extern void CSharp_delete_AkDynamicSequenceItemCallbackInfo(IntPtr jarg1); // 0x0000000187869F2C-0x0000000187869F60
	public static extern uint CSharp_AkMusicSyncCallbackInfo_playingID_get(IntPtr jarg1); // 0x000000018785A794-0x000000018785A7C8
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(IntPtr jarg1); // 0x000000018785A8CC-0x000000018785A900
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(IntPtr jarg1); // 0x000000018785A934-0x000000018785A968
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(IntPtr jarg1); // 0x000000018785A898-0x000000018785A8CC
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(IntPtr jarg1); // 0x000000018785A900-0x000000018785A934
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1); // 0x000000018785A968-0x000000018785A99C
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(IntPtr jarg1); // 0x000000018785A7FC-0x000000018785A830
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(IntPtr jarg1); // 0x000000018785A7C8-0x000000018785A7FC
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(IntPtr jarg1); // 0x000000018785A830-0x000000018785A864
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(IntPtr jarg1); // 0x000000018785A864-0x000000018785A898
	public static extern int CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(IntPtr jarg1); // 0x000000018785A760-0x000000018785A794
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(IntPtr jarg1); // 0x000000018785A99C-0x000000018785A9D0
	public static extern IntPtr CSharp_new_AkMusicSyncCallbackInfo(); // 0x000000018786B554-0x000000018786B580
	public static extern void CSharp_delete_AkMusicSyncCallbackInfo(IntPtr jarg1); // 0x000000018786A474-0x000000018786A4A8
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(IntPtr jarg1); // 0x000000018785A65C-0x000000018785A690
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(IntPtr jarg1); // 0x000000018785A690-0x000000018785A6C4
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(IntPtr jarg1); // 0x000000018785A6F8-0x000000018785A72C
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(IntPtr jarg1); // 0x000000018785A6C4-0x000000018785A6F8
	public static extern IntPtr CSharp_new_AkMusicPlaylistCallbackInfo(); // 0x000000018786B528-0x000000018786B554
	public static extern void CSharp_delete_AkMusicPlaylistCallbackInfo(IntPtr jarg1); // 0x000000018786A40C-0x000000018786A440
	public static extern uint CSharp_AkBankCallbackInfo_bankID_get(IntPtr jarg1); // 0x000000018577DFC0-0x000000018577E000
	public static extern IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(IntPtr jarg1); // 0x000000018577DEA0-0x000000018577DEE0
	public static extern int CSharp_AkBankCallbackInfo_loadResult_get(IntPtr jarg1); // 0x000000018577DF30-0x000000018577DF70
	public static extern IntPtr CSharp_new_AkBankCallbackInfo(); // 0x000000018786AC8C-0x000000018786ACB8
	public static extern void CSharp_delete_AkBankCallbackInfo(IntPtr jarg1); // 0x0000000187869D58-0x0000000187869D8C
	public static extern int CSharp_AkMonitoringCallbackInfo_errorCode_get(IntPtr jarg1); // 0x000000018785A50C-0x000000018785A540
	public static extern int CSharp_AkMonitoringCallbackInfo_errorLevel_get(IntPtr jarg1); // 0x000000018785A540-0x000000018785A574
	public static extern uint CSharp_AkMonitoringCallbackInfo_playingID_get(IntPtr jarg1); // 0x000000018785A628-0x000000018785A65C
	public static extern ulong CSharp_AkMonitoringCallbackInfo_gameObjID_get(IntPtr jarg1); // 0x000000018785A574-0x000000018785A5EC
	public static extern IntPtr CSharp_AkMonitoringCallbackInfo_message_get(IntPtr jarg1); // 0x000000018785A5EC-0x000000018785A628
	public static extern IntPtr CSharp_new_AkMonitoringCallbackInfo(); // 0x000000018786B4FC-0x000000018786B528
	public static extern void CSharp_delete_AkMonitoringCallbackInfo(IntPtr jarg1); // 0x000000018786A3D8-0x000000018786A40C
	public static extern bool CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(IntPtr jarg1); // 0x000000018785494C-0x0000000187854984
	public static extern IntPtr CSharp_new_AkAudioInterruptionCallbackInfo(); // 0x000000018786AC08-0x000000018786AC34
	public static extern void CSharp_delete_AkAudioInterruptionCallbackInfo(IntPtr jarg1); // 0x0000000187869C88-0x0000000187869CBC
	public static extern bool CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(IntPtr jarg1); // 0x0000000187854A6C-0x0000000187854AA4
	public static extern IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo(); // 0x000000018786AC60-0x000000018786AC8C
	public static extern void CSharp_delete_AkAudioSourceChangeCallbackInfo(IntPtr jarg1); // 0x0000000187869CF0-0x0000000187869D24
	public static extern int CSharp_AkCallbackSerializer_Init(); // 0x0000000186805AD0-0x0000000186805B00
	public static extern void CSharp_AkCallbackSerializer_Term(); // 0x00000001878552FC-0x0000000187855364
	public static extern IntPtr CSharp_AkCallbackSerializer_Lock(); // 0x000000018577ED40-0x000000018577ED70
	public static extern void CSharp_AkCallbackSerializer_Unlock(); // 0x00000001861B03E0-0x00000001861B04C0
	public static extern void CSharp_AkCallbackSerializer_SetLocalOutput(uint jarg1, string jarg2, uint jarg3, string jarg4, uint jarg5, uint jarg6); // 0x0000000187855220-0x00000001878552FC
	public static extern int CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(bool jarg1, IntPtr jarg2); // 0x000000018785519C-0x0000000187855220
	public static extern IntPtr CSharp_new_AkCallbackSerializer(); // 0x000000018786AD10-0x000000018786AD3C
	public static extern void CSharp_delete_AkCallbackSerializer(IntPtr jarg1); // 0x0000000187869DF4-0x0000000187869E28
	public static extern IntPtr CSharp_new_MsgContext__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, bool jarg4); // 0x000000018786BDE0-0x000000018786BE84
	public static extern IntPtr CSharp_new_MsgContext__SWIG_1(uint jarg1, ulong jarg2, uint jarg3); // 0x000000018786BE84-0x000000018786BF18
	public static extern IntPtr CSharp_new_MsgContext__SWIG_2(uint jarg1, ulong jarg2); // 0x000000018786BF18-0x000000018786BF9C
	public static extern IntPtr CSharp_new_MsgContext__SWIG_3(uint jarg1); // 0x000000018786BF9C-0x000000018786C014
	public static extern IntPtr CSharp_new_MsgContext__SWIG_4(); // 0x000000018786C014-0x000000018786C040
	public static extern void CSharp_MsgContext_in_playingID_set(IntPtr jarg1, uint jarg2); // 0x00000001878631B8-0x00000001878631F8
	public static extern uint CSharp_MsgContext_in_playingID_get(IntPtr jarg1); // 0x0000000187863184-0x00000001878631B8
	public static extern void CSharp_MsgContext_in_gameObjID_set(IntPtr jarg1, ulong jarg2); // 0x0000000187863100-0x0000000187863184
	public static extern ulong CSharp_MsgContext_in_gameObjID_get(IntPtr jarg1); // 0x0000000187863088-0x0000000187863100
	public static extern void CSharp_MsgContext_in_soundID_set(IntPtr jarg1, uint jarg2); // 0x000000018786322C-0x000000018786326C
	public static extern uint CSharp_MsgContext_in_soundID_get(IntPtr jarg1); // 0x00000001878631F8-0x000000018786322C
	public static extern void CSharp_MsgContext_in_bIsBus_set(IntPtr jarg1, bool jarg2); // 0x0000000187863044-0x0000000187863088
	public static extern bool CSharp_MsgContext_in_bIsBus_get(IntPtr jarg1); // 0x000000018786300C-0x0000000187863044
	public static extern void CSharp_delete_MsgContext(IntPtr jarg1); // 0x000000018786A9BC-0x000000018786A9F0
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_0(string jarg1, string jarg2); // 0x000000018786BC9C-0x000000018786BD34
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_1(string jarg1); // 0x000000018786BD34-0x000000018786BDB4
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_2(); // 0x000000018786BDB4-0x000000018786BDE0
	public static extern void CSharp_MonitorErrorInfo_m_name_set(IntPtr jarg1, string jarg2); // 0x0000000187862E28-0x0000000187862EB8
	public static extern IntPtr CSharp_MonitorErrorInfo_m_name_get(IntPtr jarg1); // 0x0000000187862DEC-0x0000000187862E28
	public static extern void CSharp_MonitorErrorInfo_m_message_set(IntPtr jarg1, string jarg2); // 0x0000000187862D5C-0x0000000187862DEC
	public static extern IntPtr CSharp_MonitorErrorInfo_m_message_get(IntPtr jarg1); // 0x0000000187862D20-0x0000000187862D5C
	public static extern void CSharp_delete_MonitorErrorInfo(IntPtr jarg1); // 0x000000018786A988-0x000000018786A9BC
	public static extern int CSharp_PostCode__SWIG_0(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6); // 0x00000001878634D4-0x0000000187863584
	public static extern int CSharp_PostCode__SWIG_1(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5); // 0x0000000187863584-0x0000000187863624
	public static extern int CSharp_PostCode__SWIG_2(int jarg1, int jarg2, uint jarg3, ulong jarg4); // 0x0000000187863624-0x00000001878636C4
	public static extern int CSharp_PostCode__SWIG_3(int jarg1, int jarg2, uint jarg3); // 0x00000001878636C4-0x0000000187863754
	public static extern int CSharp_PostCode__SWIG_4(int jarg1, int jarg2); // 0x0000000187863754-0x00000001878637D4
	public static extern int CSharp_PostCodeVarArg(int jarg1, int jarg2, IntPtr jarg3); // 0x0000000187863444-0x00000001878634D4
	public static extern int CSharp_PostString__SWIG_0(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6); // 0x0000000187863E60-0x0000000187863F1C
	public static extern int CSharp_PostString__SWIG_1(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5); // 0x0000000187863F1C-0x0000000187863FC8
	public static extern int CSharp_PostString__SWIG_2(string jarg1, int jarg2, uint jarg3, ulong jarg4); // 0x0000000187863FC8-0x0000000187864074
	public static extern int CSharp_PostString__SWIG_3(string jarg1, int jarg2, uint jarg3); // 0x0000000187864074-0x0000000187864110
	public static extern int CSharp_PostString__SWIG_4(string jarg1, int jarg2); // 0x0000000187864110-0x000000018786419C
	public static extern int CSharp_ResetTranslator(); // 0x000000018786625C-0x0000000187866288
	public static extern int CSharp_GetTimeStamp(); // 0x0000000187861FF4-0x0000000187862020
	public static extern void CSharp_MonitorStreamMgrInit(IntPtr jarg1); // 0x0000000187862EB8-0x0000000187862EEC
	public static extern void CSharp_MonitorStreamingDeviceInit(uint jarg1, IntPtr jarg2); // 0x0000000187862F88-0x000000018786300C
	public static extern void CSharp_MonitorStreamingDeviceDestroyed(uint jarg1); // 0x0000000187862F54-0x0000000187862F88
	public static extern void CSharp_MonitorStreamMgrTerm(); // 0x0000000187862EEC-0x0000000187862F54
	public static extern void CSharp_AkGetDefaultHighPriorityThreadProperties(IntPtr jarg1); // 0x00000001878570E4-0x0000000187857118
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_0(uint jarg1, in uint[] jarg2, uint jarg3, uint jarg4); // 0x0000000187866288-0x0000000187866334
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_1(uint jarg1, in uint[] jarg2, uint jarg3); // 0x0000000187866334-0x00000001878663D0
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3); // 0x0000000187860970-0x0000000187860A00
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3); // 0x0000000187860A00-0x0000000187860A90
	public static extern void CSharp_AkPositioningInfo_fCenterPct_set(IntPtr jarg1, float jarg2); // 0x000000018785C8D0-0x000000018785C914
	public static extern float CSharp_AkPositioningInfo_fCenterPct_get(IntPtr jarg1); // 0x000000018785C89C-0x000000018785C8D0
	public static extern void CSharp_AkPositioningInfo_pannerType_set(IntPtr jarg1, int jarg2); // 0x000000018785CC88-0x000000018785CCC8
	public static extern int CSharp_AkPositioningInfo_pannerType_get(IntPtr jarg1); // 0x000000018785CC4C-0x000000018785CC88
	public static extern void CSharp_AkPositioningInfo_e3dPositioningType_set(IntPtr jarg1, int jarg2); // 0x000000018785C85C-0x000000018785C89C
	public static extern int CSharp_AkPositioningInfo_e3dPositioningType_get(IntPtr jarg1); // 0x000000018785C828-0x000000018785C85C
	public static extern void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(IntPtr jarg1, bool jarg2); // 0x000000018785C6B4-0x000000018785C738
	public static extern bool CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(IntPtr jarg1); // 0x000000018785C67C-0x000000018785C6B4
	public static extern void CSharp_AkPositioningInfo_e3DSpatializationMode_set(IntPtr jarg1, int jarg2); // 0x000000018785C7E8-0x000000018785C828
	public static extern int CSharp_AkPositioningInfo_e3DSpatializationMode_get(IntPtr jarg1); // 0x000000018785C7B4-0x000000018785C7E8
	public static extern void CSharp_AkPositioningInfo_bEnableAttenuation_set(IntPtr jarg1, bool jarg2); // 0x000000018785C638-0x000000018785C67C
	public static extern bool CSharp_AkPositioningInfo_bEnableAttenuation_get(IntPtr jarg1); // 0x000000018785C600-0x000000018785C638
	public static extern void CSharp_AkPositioningInfo_bUseConeAttenuation_set(IntPtr jarg1, bool jarg2); // 0x000000018785C770-0x000000018785C7B4
	public static extern bool CSharp_AkPositioningInfo_bUseConeAttenuation_get(IntPtr jarg1); // 0x000000018785C738-0x000000018785C770
	public static extern void CSharp_AkPositioningInfo_fInnerAngle_set(IntPtr jarg1, float jarg2); // 0x000000018785C9C0-0x000000018785CA04
	public static extern float CSharp_AkPositioningInfo_fInnerAngle_get(IntPtr jarg1); // 0x000000018785C98C-0x000000018785C9C0
	public static extern void CSharp_AkPositioningInfo_fOuterAngle_set(IntPtr jarg1, float jarg2); // 0x000000018785CAA8-0x000000018785CAEC
	public static extern float CSharp_AkPositioningInfo_fOuterAngle_get(IntPtr jarg1); // 0x000000018785CA74-0x000000018785CAA8
	public static extern void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(IntPtr jarg1, float jarg2); // 0x000000018785C948-0x000000018785C98C
	public static extern float CSharp_AkPositioningInfo_fConeMaxAttenuation_get(IntPtr jarg1); // 0x000000018785C914-0x000000018785C948
	public static extern void CSharp_AkPositioningInfo_LPFCone_set(IntPtr jarg1, float jarg2); // 0x000000018785C544-0x000000018785C588
	public static extern float CSharp_AkPositioningInfo_LPFCone_get(IntPtr jarg1); // 0x000000018785C510-0x000000018785C544
	public static extern void CSharp_AkPositioningInfo_HPFCone_set(IntPtr jarg1, float jarg2); // 0x000000018785C454-0x000000018785C498
	public static extern float CSharp_AkPositioningInfo_HPFCone_get(IntPtr jarg1); // 0x000000018785C428-0x000000018785C454
	public static extern void CSharp_AkPositioningInfo_fMaxDistance_set(IntPtr jarg1, float jarg2); // 0x000000018785CA38-0x000000018785CA74
	public static extern float CSharp_AkPositioningInfo_fMaxDistance_get(IntPtr jarg1); // 0x000000018785CA04-0x000000018785CA38
	public static extern void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x000000018785CC10-0x000000018785CC4C
	public static extern float CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(IntPtr jarg1); // 0x000000018785CBDC-0x000000018785CC10
	public static extern void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x000000018785CB20-0x000000018785CB64
	public static extern float CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(IntPtr jarg1); // 0x000000018785CAEC-0x000000018785CB20
	public static extern void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x000000018785CB98-0x000000018785CBDC
	public static extern float CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(IntPtr jarg1); // 0x000000018785CB64-0x000000018785CB98
	public static extern void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x000000018785C5BC-0x000000018785C600
	public static extern float CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(IntPtr jarg1); // 0x000000018785C588-0x000000018785C5BC
	public static extern void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x000000018785C4CC-0x000000018785C510
	public static extern float CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(IntPtr jarg1); // 0x000000018785C498-0x000000018785C4CC
	public static extern IntPtr CSharp_new_AkPositioningInfo(); // 0x000000018786B988-0x000000018786B9F0
	public static extern void CSharp_delete_AkPositioningInfo(IntPtr jarg1); // 0x000000018786A648-0x000000018786A67C
	public static extern void CSharp_AkObjectInfo_objID_set(IntPtr jarg1, uint jarg2); // 0x000000018785AB1C-0x000000018785AB5C
	public static extern uint CSharp_AkObjectInfo_objID_get(IntPtr jarg1); // 0x000000018785AAE8-0x000000018785AB1C
	public static extern void CSharp_AkObjectInfo_parentID_set(IntPtr jarg1, uint jarg2); // 0x000000018785AB90-0x000000018785ABD0
	public static extern uint CSharp_AkObjectInfo_parentID_get(IntPtr jarg1); // 0x000000018785AB5C-0x000000018785AB90
	public static extern void CSharp_AkObjectInfo_iDepth_set(IntPtr jarg1, int jarg2); // 0x000000018785AAA8-0x000000018785AAE8
	public static extern int CSharp_AkObjectInfo_iDepth_get(IntPtr jarg1); // 0x000000018785AA74-0x000000018785AAA8
	public static extern void CSharp_AkObjectInfo_Clear(IntPtr jarg1); // 0x000000018785A9D0-0x000000018785AA04
	public static extern int CSharp_AkObjectInfo_GetSizeOf(); // 0x000000018785AA48-0x000000018785AA74
	public static extern void CSharp_AkObjectInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018785AA04-0x000000018785AA48
	public static extern IntPtr CSharp_new_AkObjectInfo(); // 0x000000018786B580-0x000000018786B5AC
	public static extern void CSharp_delete_AkObjectInfo(IntPtr jarg1); // 0x000000018786A4A8-0x000000018786A4DC
	public static extern int CSharp_GetPosition(ulong jarg1, IntPtr jarg2); // 0x000000018786139C-0x0000000187861420
	public static extern int CSharp_GetListenerPosition(ulong jarg1, IntPtr jarg2); // 0x0000000187860CFC-0x0000000187860D80
	public static extern int CSharp_GetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5); // 0x00000001878614A4-0x0000000187861548
	public static extern int CSharp_GetRTPCValue__SWIG_1(string jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5); // 0x0000000187861548-0x00000001878615F8
	public static extern int CSharp_GetSwitch__SWIG_0(uint jarg1, ulong jarg2, out uint jarg3); // 0x0000000187861EC0-0x0000000187861F54
	public static extern int CSharp_GetSwitch__SWIG_1(string jarg1, ulong jarg2, out uint jarg3); // 0x0000000187861F54-0x0000000187861FF4
	public static extern int CSharp_GetState__SWIG_0(uint jarg1, out uint jarg2); // 0x0000000187861DAC-0x0000000187861E30
	public static extern int CSharp_GetState__SWIG_1(string jarg1, out uint jarg2); // 0x0000000187861E30-0x0000000187861EC0
	public static extern int CSharp_GetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, ref uint jarg3); // 0x0000000187860A90-0x0000000187860B24
	public static extern int CSharp_GetGameObjectDryLevelValue(ulong jarg1, ulong jarg2, out float jarg3); // 0x0000000187860B24-0x0000000187860BB8
	public static extern int CSharp_GetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, out float jarg3, out float jarg4); // 0x0000000187860E24-0x0000000187860EC8
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_0(uint jarg1, ref uint jarg2, IntPtr jarg3); // 0x0000000187864E58-0x0000000187864EEC
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_1(string jarg1, ref uint jarg2, IntPtr jarg3); // 0x0000000187864EEC-0x0000000187864F8C
	public static extern int CSharp_GetPositioningInfo(uint jarg1, IntPtr jarg2); // 0x0000000187861420-0x00000001878614A4
	public static extern bool CSharp_GetIsGameObjectActive(ulong jarg1); // 0x0000000187860CC4-0x0000000187860CFC
	public static extern float CSharp_GetMaxRadius(ulong jarg1); // 0x0000000187860DF8-0x0000000187860E24
	public static extern uint CSharp_GetEventIDFromPlayingID(uint jarg1); // 0x000000018679B690-0x000000018679B6C0
	public static extern ulong CSharp_GetGameObjectFromPlayingID(uint jarg1); // 0x0000000187860BB8-0x0000000187860C30
	public static extern int CSharp_GetPlayingIDsFromGameObject(ulong jarg1, ref uint jarg2, out uint[] jarg3); // 0x0000000187861178-0x0000000187861284
	public static extern int CSharp_GetCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3); // 0x000000018786062C-0x00000001878606BC
	public static extern int CSharp_GetCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3); // 0x00000001878606BC-0x000000018786074C
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint jarg1); // 0x00000001878539A8-0x0000000187853A20
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint jarg1); // 0x0000000187853A20-0x0000000187853A98
	public static extern void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint jarg1); // 0x0000000187853930-0x00000001878539A8
	public static extern byte CSharp_ChannelMaskToNumChannels(uint jarg1); // 0x000000018785EF38-0x000000018785EFB0
	public static extern uint CSharp_ChannelMaskFromNumChannels(uint jarg1); // 0x000000018785EF04-0x000000018785EF38
	public static extern byte CSharp_ChannelBitToIndex(uint jarg1, uint jarg2); // 0x000000018785EE84-0x000000018785EF04
	public static extern bool CSharp_HasSurroundChannels(uint jarg1); // 0x00000001878622C4-0x00000001878622FC
	public static extern bool CSharp_HasStrictlyOnePairOfSurroundChannels(uint jarg1); // 0x000000018786224C-0x00000001878622C4
	public static extern bool CSharp_HasSideAndRearChannels(uint jarg1); // 0x0000000187862214-0x000000018786224C
	public static extern bool CSharp_HasHeightChannels(uint jarg1); // 0x00000001878621DC-0x0000000187862214
	public static extern uint CSharp_BackToSideChannels(uint jarg1); // 0x000000018785ED3C-0x000000018785EDB4
	public static extern uint CSharp_StdChannelIndexToDisplayIndex(int jarg1, uint jarg2, uint jarg3); // 0x0000000187868DA8-0x0000000187868E38
	public static extern void CSharp_AkChannelConfig_uNumChannels_set(IntPtr jarg1, uint jarg2); // 0x000000018785582C-0x000000018785586C
	public static extern uint CSharp_AkChannelConfig_uNumChannels_get(IntPtr jarg1); // 0x00000001862FA630-0x00000001862FA670
	public static extern void CSharp_AkChannelConfig_eConfigType_set(IntPtr jarg1, uint jarg2); // 0x0000000187855768-0x00000001878557EC
	public static extern uint CSharp_AkChannelConfig_eConfigType_get(IntPtr jarg1); // 0x00000001862FA590-0x00000001862FA5D0
	public static extern void CSharp_AkChannelConfig_uChannelMask_set(IntPtr jarg1, uint jarg2); // 0x00000001878557EC-0x000000018785582C
	public static extern uint CSharp_AkChannelConfig_uChannelMask_get(IntPtr jarg1); // 0x00000001862FA4F0-0x00000001862FA530
	public static extern IntPtr CSharp_AkChannelConfig_Standard(uint jarg1); // 0x0000000187855734-0x0000000187855768
	public static extern IntPtr CSharp_AkChannelConfig_Anonymous(uint jarg1); // 0x0000000187855398-0x0000000187855410
	public static extern IntPtr CSharp_AkChannelConfig_Ambisonic(uint jarg1); // 0x0000000187855364-0x0000000187855398
	public static extern IntPtr CSharp_AkChannelConfig_Object(); // 0x00000001878554BC-0x00000001878554E8
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_0(); // 0x000000018786AD3C-0x000000018786AD68
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_1(uint jarg1, uint jarg2); // 0x000000018786AD68-0x000000018786ADE8
	public static extern void CSharp_AkChannelConfig_Clear(IntPtr jarg1); // 0x0000000187855410-0x0000000187855444
	public static extern void CSharp_AkChannelConfig_SetStandard(IntPtr jarg1, uint jarg2); // 0x00000001878556F4-0x0000000187855734
	public static extern void CSharp_AkChannelConfig_SetStandardOrAnonymous(IntPtr jarg1, uint jarg2, uint jarg3); // 0x0000000187855660-0x00000001878556F4
	public static extern void CSharp_AkChannelConfig_SetAnonymous(IntPtr jarg1, uint jarg2); // 0x00000001850C96D0-0x00000001850C9710
	public static extern void CSharp_AkChannelConfig_SetAmbisonic(IntPtr jarg1, uint jarg2); // 0x0000000187855584-0x00000001878555C4
	public static extern void CSharp_AkChannelConfig_SetObject(IntPtr jarg1); // 0x00000001878555C4-0x00000001878555F8
	public static extern void CSharp_AkChannelConfig_SetSameAsMainMix(IntPtr jarg1); // 0x00000001878555F8-0x000000018785562C
	public static extern void CSharp_AkChannelConfig_SetSameAsPassthrough(IntPtr jarg1); // 0x000000018785562C-0x0000000187855660
	public static extern bool CSharp_AkChannelConfig_IsValid(IntPtr jarg1); // 0x0000000187855484-0x00000001878554BC
	public static extern uint CSharp_AkChannelConfig_Serialize(IntPtr jarg1); // 0x0000000187855550-0x0000000187855584
	public static extern void CSharp_AkChannelConfig_Deserialize(IntPtr jarg1, uint jarg2); // 0x0000000187855444-0x0000000187855484
	public static extern IntPtr CSharp_AkChannelConfig_RemoveLFE(IntPtr jarg1); // 0x000000018785551C-0x0000000187855550
	public static extern IntPtr CSharp_AkChannelConfig_RemoveCenter(IntPtr jarg1); // 0x00000001878554E8-0x000000018785551C
	public static extern void CSharp_delete_AkChannelConfig(IntPtr jarg1); // 0x0000000186B76F00-0x0000000186B76F40
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_0(); // 0x000000018786B16C-0x000000018786B198
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3); // 0x000000018786B198-0x000000018786B1FC
	public static extern void CSharp_AkImageSourceParams_sourcePosition_set(IntPtr jarg1, AkVector64 jarg2); // 0x0000000187857394-0x0000000187857434
	public static extern AkVector64 CSharp_AkImageSourceParams_sourcePosition_get(IntPtr jarg1); // 0x00000001878572F8-0x0000000187857394
	public static extern void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(IntPtr jarg1, float jarg2); // 0x00000001878571C4-0x0000000187857208
	public static extern float CSharp_AkImageSourceParams_fDistanceScalingFactor_get(IntPtr jarg1); // 0x0000000187857190-0x00000001878571C4
	public static extern void CSharp_AkImageSourceParams_fLevel_set(IntPtr jarg1, float jarg2); // 0x000000018785723C-0x0000000187857280
	public static extern float CSharp_AkImageSourceParams_fLevel_get(IntPtr jarg1); // 0x0000000187857208-0x000000018785723C
	public static extern void CSharp_AkImageSourceParams_fDiffraction_set(IntPtr jarg1, float jarg2); // 0x000000018785714C-0x0000000187857190
	public static extern float CSharp_AkImageSourceParams_fDiffraction_get(IntPtr jarg1); // 0x0000000187857118-0x000000018785714C
	public static extern void CSharp_AkImageSourceParams_fOcclusion_set(IntPtr jarg1, float jarg2); // 0x00000001878572B4-0x00000001878572F8
	public static extern float CSharp_AkImageSourceParams_fOcclusion_get(IntPtr jarg1); // 0x0000000187857280-0x00000001878572B4
	public static extern void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(IntPtr jarg1, byte jarg2); // 0x00000001878574AC-0x00000001878574EC
	public static extern byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(IntPtr jarg1); // 0x0000000187857434-0x00000001878574AC
	public static extern void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(IntPtr jarg1, byte jarg2); // 0x0000000187857520-0x0000000187857560
	public static extern byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(IntPtr jarg1); // 0x00000001878574EC-0x0000000187857520
	public static extern void CSharp_delete_AkImageSourceParams(IntPtr jarg1); // 0x000000018786A030-0x000000018786A064
	public static extern uint CSharp_kDefaultDiffractionMaxEdges_get(); // 0x000000018786A9F0-0x000000018786AA1C
	public static extern uint CSharp_kDefaultDiffractionMaxPaths_get(); // 0x000000018786AA1C-0x000000018786AA48
	public static extern float CSharp_kMaxDiffraction_get(); // 0x000000018786AB08-0x000000018786AB2C
	public static extern uint CSharp_kHashListBlockAllocItemCount_get(); // 0x000000018786AAA0-0x000000018786AB08
	public static extern uint CSharp_kDiffractionMaxEdges_get(); // 0x000000018786AA48-0x000000018786AA74
	public static extern uint CSharp_kDiffractionMaxPaths_get(); // 0x000000018786AA74-0x000000018786AAA0
	public static extern uint CSharp_kPortalToPortalDiffractionMaxPaths_get(); // 0x000000018786AB2C-0x000000018786AB58
	public static extern IntPtr CSharp_new_AkSpatialAudioInitSettings(); // 0x0000000186806260-0x0000000186806290
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(IntPtr jarg1, uint jarg2); // 0x0000000186806880-0x00000001868068D0
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(IntPtr jarg1); // 0x000000018785DFF8-0x000000018785E02C
	public static extern void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(IntPtr jarg1, float jarg2); // 0x0000000186806C40-0x0000000186806C90
	public static extern float CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(IntPtr jarg1); // 0x000000018785DF5C-0x000000018785DF90
	public static extern void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(IntPtr jarg1, uint jarg2); // 0x00000001868067D0-0x0000000186806820
	public static extern uint CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(IntPtr jarg1); // 0x00000001862E6880-0x00000001862E68C0
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000186806720-0x0000000186806770
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(IntPtr jarg1); // 0x00000001862E67F0-0x00000001862E6830
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000186806670-0x00000001868066C0
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(IntPtr jarg1); // 0x00000001862E6760-0x00000001862E67A0
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(IntPtr jarg1, uint jarg2); // 0x00000001868065C0-0x0000000186806610
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(IntPtr jarg1); // 0x000000018785DFC4-0x000000018785DFF8
	public static extern void CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(IntPtr jarg1, uint jarg2); // 0x0000000186806510-0x0000000186806560
	public static extern uint CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(IntPtr jarg1); // 0x000000018785DF90-0x000000018785DFC4
	public static extern void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(IntPtr jarg1, float jarg2); // 0x0000000186806B80-0x0000000186806BD0
	public static extern float CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(IntPtr jarg1); // 0x000000018785DF28-0x000000018785DF5C
	public static extern void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(IntPtr jarg1, float jarg2); // 0x0000000186806AC0-0x0000000186806B10
	public static extern float CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(IntPtr jarg1); // 0x000000018785DEF4-0x000000018785DF28
	public static extern void CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(IntPtr jarg1, uint jarg2); // 0x0000000186806460-0x00000001868064B0
	public static extern uint CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(IntPtr jarg1); // 0x00000001862E66D0-0x00000001862E6710
	public static extern void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(IntPtr jarg1, bool jarg2); // 0x0000000186806A00-0x0000000186806A50
	public static extern bool CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(IntPtr jarg1); // 0x000000018785DEBC-0x000000018785DEF4
	public static extern void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(IntPtr jarg1, bool jarg2); // 0x0000000186806940-0x0000000186806990
	public static extern bool CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(IntPtr jarg1); // 0x000000018785DE84-0x000000018785DEBC
	public static extern void CSharp_delete_AkSpatialAudioInitSettings(IntPtr jarg1); // 0x0000000186C36D00-0x0000000186C36D40
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_0(); // 0x000000018786B1FC-0x000000018786B228
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3); // 0x000000018786B228-0x000000018786B28C
	public static extern void CSharp_AkImageSourceSettings_SetOneTexture(IntPtr jarg1, uint jarg2); // 0x0000000187857560-0x00000001878575A0
	public static extern void CSharp_AkImageSourceSettings_params__set(IntPtr jarg1, IntPtr jarg2); // 0x00000001878575D4-0x0000000187857618
	public static extern IntPtr CSharp_AkImageSourceSettings_params__get(IntPtr jarg1); // 0x00000001878575A0-0x00000001878575D4
	public static extern void CSharp_delete_AkImageSourceSettings(IntPtr jarg1); // 0x000000018786A064-0x000000018786A098
	public static extern IntPtr CSharp_new_AkExtent__SWIG_0(); // 0x000000018786AEC4-0x000000018786AEF0
	public static extern IntPtr CSharp_new_AkExtent__SWIG_1(float jarg1, float jarg2, float jarg3); // 0x000000018786AEF0-0x000000018786AF48
	public static extern void CSharp_AkExtent_halfWidth_set(IntPtr jarg1, float jarg2); // 0x0000000187856BAC-0x0000000187856BF0
	public static extern float CSharp_AkExtent_halfWidth_get(IntPtr jarg1); // 0x0000000187856B78-0x0000000187856BAC
	public static extern void CSharp_AkExtent_halfHeight_set(IntPtr jarg1, float jarg2); // 0x0000000187856B34-0x0000000187856B78
	public static extern float CSharp_AkExtent_halfHeight_get(IntPtr jarg1); // 0x0000000187856B00-0x0000000187856B34
	public static extern void CSharp_AkExtent_halfDepth_set(IntPtr jarg1, float jarg2); // 0x0000000187856ABC-0x0000000187856B00
	public static extern float CSharp_AkExtent_halfDepth_get(IntPtr jarg1); // 0x0000000187856A88-0x0000000187856ABC
	public static extern void CSharp_delete_AkExtent(IntPtr jarg1); // 0x0000000187869F94-0x0000000187869FC8
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_0(); // 0x000000018786BB70-0x000000018786BB9C
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_1(ushort jarg1, ushort jarg2, ushort jarg3, ushort jarg4); // 0x000000018786BB9C-0x000000018786BC44
	public static extern void CSharp_AkTriangle_point0_set(IntPtr jarg1, ushort jarg2); // 0x0000000185A1CF90-0x0000000185A1CFE0
	public static extern ushort CSharp_AkTriangle_point0_get(IntPtr jarg1); // 0x000000018785E644-0x000000018785E6BC
	public static extern void CSharp_AkTriangle_point1_set(IntPtr jarg1, ushort jarg2); // 0x0000000185A1CF40-0x0000000185A1CF90
	public static extern ushort CSharp_AkTriangle_point1_get(IntPtr jarg1); // 0x000000018785E6BC-0x000000018785E6F0
	public static extern void CSharp_AkTriangle_point2_set(IntPtr jarg1, ushort jarg2); // 0x0000000185A1CEB0-0x0000000185A1CEF0
	public static extern ushort CSharp_AkTriangle_point2_get(IntPtr jarg1); // 0x000000018785E6F0-0x000000018785E768
	public static extern void CSharp_AkTriangle_surface_set(IntPtr jarg1, ushort jarg2); // 0x0000000185A1CEF0-0x0000000185A1CF40
	public static extern ushort CSharp_AkTriangle_surface_get(IntPtr jarg1); // 0x000000018785E768-0x000000018785E7E0
	public static extern void CSharp_AkTriangle_Clear(IntPtr jarg1); // 0x0000000185A1C8D0-0x0000000185A1C910
	public static extern int CSharp_AkTriangle_GetSizeOf(); // 0x0000000185A1C940-0x0000000185A1C970
	public static extern void CSharp_AkTriangle_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018785E600-0x000000018785E644
	public static extern void CSharp_delete_AkTriangle(IntPtr jarg1); // 0x000000018786A8B8-0x000000018786A8EC
	public static extern IntPtr CSharp_new_AkAcousticSurface(); // 0x000000018786ABB0-0x000000018786ABDC
	public static extern void CSharp_AkAcousticSurface_textureID_set(IntPtr jarg1, uint jarg2); // 0x0000000185A1D0A0-0x0000000185A1D0F0
	public static extern uint CSharp_AkAcousticSurface_textureID_get(IntPtr jarg1); // 0x00000001878543F4-0x0000000187854428
	public static extern void CSharp_AkAcousticSurface_transmissionLoss_set(IntPtr jarg1, float jarg2); // 0x0000000185A1D050-0x0000000185A1D0A0
	public static extern float CSharp_AkAcousticSurface_transmissionLoss_get(IntPtr jarg1); // 0x0000000187854428-0x000000018785445C
	public static extern void CSharp_AkAcousticSurface_strName_set(IntPtr jarg1, string jarg2); // 0x0000000187854360-0x00000001878543F4
	public static extern IntPtr CSharp_AkAcousticSurface_strName_get(IntPtr jarg1); // 0x000000018785432C-0x0000000187854360
	public static extern void CSharp_AkAcousticSurface_Clear(IntPtr jarg1); // 0x0000000185A1C7A0-0x0000000185A1C7E0
	public static extern void CSharp_AkAcousticSurface_DeleteName(IntPtr jarg1); // 0x00000001878542F8-0x000000018785432C
	public static extern int CSharp_AkAcousticSurface_GetSizeOf(); // 0x0000000185A1C910-0x0000000185A1C940
	public static extern void CSharp_AkAcousticSurface_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001878542B4-0x00000001878542F8
	public static extern void CSharp_delete_AkAcousticSurface(IntPtr jarg1); // 0x0000000187869BDC-0x0000000187869C10
	public static extern void CSharp_AkReflectionPathInfo_imageSource_set(IntPtr jarg1, AkVector64 jarg2); // 0x000000018785D024-0x000000018785D0C4
	public static extern AkVector64 CSharp_AkReflectionPathInfo_imageSource_get(IntPtr jarg1); // 0x000000018785CF88-0x000000018785D024
	public static extern void CSharp_AkReflectionPathInfo_numPathPoints_set(IntPtr jarg1, uint jarg2); // 0x000000018785D230-0x000000018785D270
	public static extern uint CSharp_AkReflectionPathInfo_numPathPoints_get(IntPtr jarg1); // 0x000000018785D1FC-0x000000018785D230
	public static extern void CSharp_AkReflectionPathInfo_numReflections_set(IntPtr jarg1, uint jarg2); // 0x000000018785D2A4-0x000000018785D2E4
	public static extern uint CSharp_AkReflectionPathInfo_numReflections_get(IntPtr jarg1); // 0x000000018785D270-0x000000018785D2A4
	public static extern void CSharp_AkReflectionPathInfo_level_set(IntPtr jarg1, float jarg2); // 0x000000018785D1B8-0x000000018785D1FC
	public static extern float CSharp_AkReflectionPathInfo_level_get(IntPtr jarg1); // 0x000000018785D184-0x000000018785D1B8
	public static extern void CSharp_AkReflectionPathInfo_isOccluded_set(IntPtr jarg1, bool jarg2); // 0x000000018785D140-0x000000018785D184
	public static extern bool CSharp_AkReflectionPathInfo_isOccluded_get(IntPtr jarg1); // 0x000000018785D0C4-0x000000018785D140
	public static extern int CSharp_AkReflectionPathInfo_GetSizeOf(); // 0x000000018785CF5C-0x000000018785CF88
	public static extern Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(IntPtr jarg1, uint jarg2); // 0x000000018785CEB4-0x000000018785CF5C
	public static extern IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(IntPtr jarg1, uint jarg2); // 0x000000018785CDF4-0x000000018785CE78
	public static extern float CSharp_AkReflectionPathInfo_GetDiffraction(IntPtr jarg1, uint jarg2); // 0x000000018785CE78-0x000000018785CEB4
	public static extern void CSharp_AkReflectionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x000000018785CDB0-0x000000018785CDF4
	public static extern IntPtr CSharp_new_AkReflectionPathInfo(); // 0x000000018786BA68-0x000000018786BA94
	public static extern void CSharp_delete_AkReflectionPathInfo(IntPtr jarg1); // 0x000000018786A6B0-0x000000018786A6E4
	public static extern void CSharp_AkDiffractionPathInfo_emitterPos_set(IntPtr jarg1, AkVector64 jarg2); // 0x000000018785653C-0x00000001878565DC
	public static extern AkVector64 CSharp_AkDiffractionPathInfo_emitterPos_get(IntPtr jarg1); // 0x00000001878564A0-0x000000018785653C
	public static extern void CSharp_AkDiffractionPathInfo_virtualPos_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187856864-0x00000001878568A8
	public static extern IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(IntPtr jarg1); // 0x0000000187856830-0x0000000187856864
	public static extern void CSharp_AkDiffractionPathInfo_nodeCount_set(IntPtr jarg1, uint jarg2); // 0x0000000187856610-0x0000000187856650
	public static extern uint CSharp_AkDiffractionPathInfo_nodeCount_get(IntPtr jarg1); // 0x00000001878565DC-0x0000000187856610
	public static extern void CSharp_AkDiffractionPathInfo_diffraction_set(IntPtr jarg1, float jarg2); // 0x0000000187856464-0x00000001878564A0
	public static extern float CSharp_AkDiffractionPathInfo_diffraction_get(IntPtr jarg1); // 0x0000000187856430-0x0000000187856464
	public static extern void CSharp_AkDiffractionPathInfo_transmissionLoss_set(IntPtr jarg1, float jarg2); // 0x00000001878567EC-0x0000000187856830
	public static extern float CSharp_AkDiffractionPathInfo_transmissionLoss_get(IntPtr jarg1); // 0x00000001878567B8-0x00000001878567EC
	public static extern void CSharp_AkDiffractionPathInfo_totLength_set(IntPtr jarg1, float jarg2); // 0x0000000187856774-0x00000001878567B8
	public static extern float CSharp_AkDiffractionPathInfo_totLength_get(IntPtr jarg1); // 0x0000000187856740-0x0000000187856774
	public static extern void CSharp_AkDiffractionPathInfo_obstructionValue_set(IntPtr jarg1, float jarg2); // 0x0000000187856684-0x00000001878566C8
	public static extern float CSharp_AkDiffractionPathInfo_obstructionValue_get(IntPtr jarg1); // 0x0000000187856650-0x0000000187856684
	public static extern void CSharp_AkDiffractionPathInfo_occlusionValue_set(IntPtr jarg1, float jarg2); // 0x00000001878566FC-0x0000000187856740
	public static extern float CSharp_AkDiffractionPathInfo_occlusionValue_get(IntPtr jarg1); // 0x00000001878566C8-0x00000001878566FC
	public static extern int CSharp_AkDiffractionPathInfo_GetSizeOf(); // 0x0000000187856404-0x0000000187856430
	public static extern Vector3 CSharp_AkDiffractionPathInfo_GetNodes(IntPtr jarg1, uint jarg2); // 0x0000000187856254-0x00000001878562FC
	public static extern float CSharp_AkDiffractionPathInfo_GetAngles(IntPtr jarg1, uint jarg2); // 0x0000000187856218-0x0000000187856254
	public static extern ulong CSharp_AkDiffractionPathInfo_GetPortals(IntPtr jarg1, uint jarg2); // 0x00000001878562FC-0x0000000187856380
	public static extern ulong CSharp_AkDiffractionPathInfo_GetRooms(IntPtr jarg1, uint jarg2); // 0x0000000187856380-0x0000000187856404
	public static extern void CSharp_AkDiffractionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001878561D4-0x0000000187856218
	public static extern IntPtr CSharp_new_AkDiffractionPathInfo(); // 0x000000018786AE14-0x000000018786AE40
	public static extern void CSharp_delete_AkDiffractionPathInfo(IntPtr jarg1); // 0x0000000187869EC4-0x0000000187869EF8
	public static extern IntPtr CSharp_new_AkRoomParams(); // 0x00000001862FABC0-0x00000001862FABF0
	public static extern void CSharp_AkRoomParams_Front_set(IntPtr jarg1, Vector3 jarg2); // 0x000000018566C280-0x000000018566C2D0
	public static extern Vector3 CSharp_AkRoomParams_Front_get(IntPtr jarg1); // 0x000000018785D59C-0x000000018785D634
	public static extern void CSharp_AkRoomParams_Up_set(IntPtr jarg1, Vector3 jarg2); // 0x000000018566C1A0-0x000000018566C1F0
	public static extern Vector3 CSharp_AkRoomParams_Up_get(IntPtr jarg1); // 0x000000018785D768-0x000000018785D800
	public static extern void CSharp_AkRoomParams_ReverbAuxBus_set(IntPtr jarg1, uint jarg2); // 0x000000018566BDD0-0x000000018566BE20
	public static extern uint CSharp_AkRoomParams_ReverbAuxBus_get(IntPtr jarg1); // 0x000000018785D634-0x000000018785D668
	public static extern void CSharp_AkRoomParams_ReverbLevel_set(IntPtr jarg1, float jarg2); // 0x000000018566C0C0-0x000000018566C110
	public static extern float CSharp_AkRoomParams_ReverbLevel_get(IntPtr jarg1); // 0x000000018785D668-0x000000018785D69C
	public static extern void CSharp_AkRoomParams_TransmissionLoss_set(IntPtr jarg1, float jarg2); // 0x000000018566C000-0x000000018566C050
	public static extern float CSharp_AkRoomParams_TransmissionLoss_get(IntPtr jarg1); // 0x000000018785D734-0x000000018785D768
	public static extern void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(IntPtr jarg1, float jarg2); // 0x000000018566BF40-0x000000018566BF90
	public static extern float CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(IntPtr jarg1); // 0x000000018785D69C-0x000000018785D6C8
	public static extern void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(IntPtr jarg1, bool jarg2); // 0x000000018566BE90-0x000000018566BED0
	public static extern bool CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(IntPtr jarg1); // 0x000000018785D6C8-0x000000018785D700
	public static extern void CSharp_AkRoomParams_RoomPriority_set(IntPtr jarg1, uint jarg2); // 0x000000018566BD20-0x000000018566BD70
	public static extern uint CSharp_AkRoomParams_RoomPriority_get(IntPtr jarg1); // 0x000000018785D700-0x000000018785D734
	public static extern void CSharp_delete_AkRoomParams(IntPtr jarg1); // 0x000000018786A718-0x000000018786A74C
	public static extern IntPtr CSharp_new_AkGeometryInstanceParams(); // 0x000000018786B140-0x000000018786B16C
	public static extern void CSharp_AkGeometryInstanceParams_PositionAndOrientation_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187856E6C-0x0000000187856EB0
	public static extern IntPtr CSharp_AkGeometryInstanceParams_PositionAndOrientation_get(IntPtr jarg1); // 0x0000000187856E30-0x0000000187856E6C
	public static extern void CSharp_AkGeometryInstanceParams_Scale_set(IntPtr jarg1, Vector3 jarg2); // 0x0000000187856F48-0x0000000187856FE4
	public static extern Vector3 CSharp_AkGeometryInstanceParams_Scale_get(IntPtr jarg1); // 0x0000000187856EB0-0x0000000187856F48
	public static extern void CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_set(IntPtr jarg1, bool jarg2); // 0x0000000187857060-0x00000001878570E4
	public static extern bool CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_get(IntPtr jarg1); // 0x0000000187856FE4-0x0000000187857060
	public static extern void CSharp_delete_AkGeometryInstanceParams(IntPtr jarg1); // 0x0000000187869FFC-0x000000018786A030
	public static extern int CSharp_SetGameObjectRadius(ulong jarg1, float jarg2, float jarg3); // 0x0000000187867388-0x00000001878673D4
	public static extern int CSharp_SetImageSource__SWIG_0(uint jarg1, IntPtr jarg2, string jarg3, uint jarg4, ulong jarg5); // 0x0000000187867420-0x00000001878674E8
	public static extern int CSharp_SetImageSource__SWIG_1(uint jarg1, IntPtr jarg2, string jarg3, uint jarg4); // 0x00000001878674E8-0x00000001878675A4
	public static extern int CSharp_SetImageSource__SWIG_2(uint jarg1, IntPtr jarg2, string jarg3); // 0x00000001878675A4-0x0000000187867658
	public static extern int CSharp_RemoveImageSource__SWIG_0(uint jarg1, uint jarg2, ulong jarg3); // 0x00000001878652DC-0x000000018786536C
	public static extern int CSharp_RemoveImageSource__SWIG_1(uint jarg1, uint jarg2); // 0x000000018786536C-0x00000001878653EC
	public static extern int CSharp_RemoveImageSource__SWIG_2(uint jarg1); // 0x00000001878653EC-0x0000000187865464
	public static extern int CSharp_ClearImageSources__SWIG_0(uint jarg1, ulong jarg2); // 0x000000018785F044-0x000000018785F0C8
	public static extern int CSharp_ClearImageSources__SWIG_1(uint jarg1); // 0x000000018785F0C8-0x000000018785F0FC
	public static extern int CSharp_ClearImageSources__SWIG_2(); // 0x000000018785F0FC-0x000000018785F130
	public static extern int CSharp_RemoveGeometry(ulong jarg1); // 0x00000001858F45D0-0x00000001858F4600
	public static extern int CSharp_RemoveGeometryInstance(ulong jarg1); // 0x00000001858F49C0-0x00000001858F4A60
	public static extern int CSharp_RemoveRoom(ulong jarg1); // 0x00000001858F4AB0-0x00000001858F4AE0
	public static extern int CSharp_RemovePortal(ulong jarg1); // 0x0000000187865560-0x0000000187865594
	public static extern int CSharp_SetReverbZone(ulong jarg1, ulong jarg2, float jarg3); // 0x000000018566B890-0x000000018566B8E0
	public static extern int CSharp_RemoveReverbZone(ulong jarg1); // 0x0000000187865594-0x00000001878655C8
	public static extern int CSharp_SetGameObjectInRoom(ulong jarg1, ulong jarg2); // 0x00000001878672B8-0x000000018786733C
	public static extern int CSharp_UnsetGameObjectInRoom(ulong jarg1); // 0x00000001878699A0-0x00000001878699D4
	public static extern int CSharp_SetReflectionsOrder(uint jarg1, bool jarg2); // 0x00000001862E69C0-0x00000001862E6A00
	public static extern int CSharp_SetDiffractionOrder(uint jarg1, bool jarg2); // 0x00000001862E6920-0x00000001862E6960
	public static extern int CSharp_SetMaxEmitterRoomAuxSends(uint jarg1); // 0x00000001878678B8-0x00000001878678EC
	public static extern int CSharp_SetNumberOfPrimaryRays(uint jarg1); // 0x00000001862E6650-0x00000001862E6680
	public static extern int CSharp_SetLoadBalancingSpread(uint jarg1); // 0x00000001862E65C0-0x00000001862E6600
	public static extern int CSharp_SetEarlyReflectionsAuxSend(ulong jarg1, uint jarg2); // 0x00000001878670BC-0x0000000187867140
	public static extern int CSharp_SetEarlyReflectionsVolume(ulong jarg1, float jarg2); // 0x0000000187867140-0x000000018786717C
	public static extern int CSharp_SetPortalObstructionAndOcclusion(ulong jarg1, float jarg2, float jarg3); // 0x0000000187868190-0x00000001878681DC
	public static extern int CSharp_SetGameObjectToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001878673D4-0x0000000187867420
	public static extern int CSharp_SetPortalToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001878681DC-0x0000000187868228
	public static extern int CSharp_QueryWetDiffraction(ulong jarg1, out float jarg2); // 0x00000001878650D4-0x0000000187865158
	public static extern int CSharp_ResetStochasticEngine(); // 0x0000000187866230-0x000000018786625C
	public static extern void CSharp_AkPlatformInitSettings_threadLEngine_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B06C-0x000000018785B0B0
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(IntPtr jarg1); // 0x000000018785B038-0x000000018785B06C
	public static extern void CSharp_AkPlatformInitSettings_threadOutputMgr_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B15C-0x000000018785B1E0
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(IntPtr jarg1); // 0x000000018785B128-0x000000018785B15C
	public static extern void CSharp_AkPlatformInitSettings_threadBankManager_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785AFF4-0x000000018785B038
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(IntPtr jarg1); // 0x000000018785AFC0-0x000000018785AFF4
	public static extern void CSharp_AkPlatformInitSettings_threadMonitor_set(IntPtr jarg1, IntPtr jarg2); // 0x000000018785B0E4-0x000000018785B128
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(IntPtr jarg1); // 0x000000018785B0B0-0x000000018785B0E4
	public static extern void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(IntPtr jarg1, ushort jarg2); // 0x0000000186805450-0x00000001868054A0
	public static extern ushort CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(IntPtr jarg1); // 0x000000018785B214-0x000000018785B28C
	public static extern void CSharp_AkPlatformInitSettings_uSampleRate_set(IntPtr jarg1, uint jarg2); // 0x00000001868053B0-0x00000001868053F0
	public static extern uint CSharp_AkPlatformInitSettings_uSampleRate_get(IntPtr jarg1); // 0x000000018785B28C-0x000000018785B304
	public static extern void CSharp_AkPlatformInitSettings_bEnableAvxSupport_set(IntPtr jarg1, bool jarg2); // 0x000000018785AEC0-0x000000018785AF04
	public static extern bool CSharp_AkPlatformInitSettings_bEnableAvxSupport_get(IntPtr jarg1); // 0x000000018785AE88-0x000000018785AEC0
	public static extern void CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x00000001870D4030-0x00000001870D4070
	public static extern uint CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_get(IntPtr jarg1); // 0x000000018785B1E0-0x000000018785B214
	public static extern void CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_set(IntPtr jarg1, bool jarg2); // 0x000000018785AF3C-0x000000018785AFC0
	public static extern bool CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_get(IntPtr jarg1); // 0x000000018785AF04-0x000000018785AF3C
	public static extern void CSharp_delete_AkPlatformInitSettings(IntPtr jarg1); // 0x000000018786A544-0x000000018786A578
	public static extern uint CSharp_GetDeviceIDFromName(string jarg1); // 0x0000000187860850-0x00000001878608D0
	public static extern IntPtr CSharp_GetWindowsDeviceName__SWIG_0(int jarg1, out uint jarg2, int jarg3); // 0x00000001878620C4-0x0000000187862158
	public static extern IntPtr CSharp_GetWindowsDeviceName__SWIG_1(int jarg1, out uint jarg2); // 0x0000000187862158-0x00000001878621DC
	public static extern uint CSharp_GetWindowsDeviceCount__SWIG_0(int jarg1); // 0x0000000187862020-0x0000000187862098
	public static extern uint CSharp_GetWindowsDeviceCount__SWIG_1(); // 0x0000000187862098-0x00000001878620C4
	public static extern void CSharp_delete_AkStreamMgrSettings(IntPtr jarg1); // 0x000000018786A81C-0x000000018786A850
	public static extern void CSharp_AkDeviceSettings_pIOMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187855F54-0x0000000187855F98
	public static extern IntPtr CSharp_AkDeviceSettings_pIOMemory_get(IntPtr jarg1); // 0x0000000187855F20-0x0000000187855F54
	public static extern void CSharp_AkDeviceSettings_uIOMemorySize_set(IntPtr jarg1, uint jarg2); // 0x0000000186805500-0x0000000186805540
	public static extern uint CSharp_AkDeviceSettings_uIOMemorySize_get(IntPtr jarg1); // 0x00000001878560F8-0x000000018785612C
	public static extern void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(IntPtr jarg1, uint jarg2); // 0x00000001878560B8-0x00000001878560F8
	public static extern uint CSharp_AkDeviceSettings_uIOMemoryAlignment_get(IntPtr jarg1); // 0x0000000187856084-0x00000001878560B8
	public static extern void CSharp_AkDeviceSettings_ePoolAttributes_set(IntPtr jarg1, uint jarg2); // 0x0000000187855EAC-0x0000000187855EEC
	public static extern uint CSharp_AkDeviceSettings_ePoolAttributes_get(IntPtr jarg1); // 0x0000000187855E78-0x0000000187855EAC
	public static extern void CSharp_AkDeviceSettings_uGranularity_set(IntPtr jarg1, uint jarg2); // 0x0000000187856044-0x0000000187856084
	public static extern uint CSharp_AkDeviceSettings_uGranularity_get(IntPtr jarg1); // 0x0000000187856010-0x0000000187856044
	public static extern void CSharp_AkDeviceSettings_threadProperties_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187855FCC-0x0000000187856010
	public static extern IntPtr CSharp_AkDeviceSettings_threadProperties_get(IntPtr jarg1); // 0x0000000187855F98-0x0000000187855FCC
	public static extern void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(IntPtr jarg1, float jarg2); // 0x00000001868055A0-0x00000001868055F0
	public static extern float CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(IntPtr jarg1); // 0x0000000187855EEC-0x0000000187855F20
	public static extern void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(IntPtr jarg1, uint jarg2); // 0x0000000187856194-0x00000001878561D4
	public static extern uint CSharp_AkDeviceSettings_uMaxConcurrentIO_get(IntPtr jarg1); // 0x0000000187856160-0x0000000187856194
	public static extern void CSharp_AkDeviceSettings_bUseStreamCache_set(IntPtr jarg1, bool jarg2); // 0x0000000186805650-0x00000001868056A0
	public static extern bool CSharp_AkDeviceSettings_bUseStreamCache_get(IntPtr jarg1); // 0x0000000187855E38-0x0000000187855E78
	public static extern void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(IntPtr jarg1, uint jarg2); // 0x0000000186805700-0x0000000186805740
	public static extern uint CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(IntPtr jarg1); // 0x000000018785612C-0x0000000187856160
	public static extern void CSharp_delete_AkDeviceSettings(IntPtr jarg1); // 0x0000000187869E90-0x0000000187869EC4
	public static extern void CSharp_AkThreadProperties_nPriority_set(IntPtr jarg1, int jarg2); // 0x000000018785E104-0x000000018785E144
	public static extern int CSharp_AkThreadProperties_nPriority_get(IntPtr jarg1); // 0x000000018785E0D0-0x000000018785E104
	public static extern void CSharp_AkThreadProperties_dwAffinityMask_set(IntPtr jarg1, uint jarg2); // 0x000000018785E090-0x000000018785E0D0
	public static extern uint CSharp_AkThreadProperties_dwAffinityMask_get(IntPtr jarg1); // 0x000000018785E05C-0x000000018785E090
	public static extern void CSharp_AkThreadProperties_uStackSize_set(IntPtr jarg1, uint jarg2); // 0x000000018785E178-0x000000018785E1B8
	public static extern uint CSharp_AkThreadProperties_uStackSize_get(IntPtr jarg1); // 0x000000018785E144-0x000000018785E178
	public static extern IntPtr CSharp_new_AkThreadProperties(); // 0x000000018786BB44-0x000000018786BB70
	public static extern void CSharp_delete_AkThreadProperties(IntPtr jarg1); // 0x000000018786A850-0x000000018786A884
	public static extern void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1); // 0x0000000185AFBA20-0x0000000185AFBAB0
	public static extern void CSharp_SetErrorLogger__SWIG_1(); // 0x000000018786717C-0x00000001878671E4
	public static extern void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2); // 0x0000000187866BA8-0x0000000187866C40
	public static extern void CSharp_delete_AkUnityPlatformSpecificSettings(IntPtr jarg1); // 0x000000018786A920-0x000000018786A954
	public static extern IntPtr CSharp_new_AkCommunicationSettings(); // 0x0000000186ABB350-0x0000000186ABB380
	public static extern void CSharp_AkCommunicationSettings_uPoolSize_set(IntPtr jarg1, uint jarg2); // 0x0000000186ABB9E0-0x0000000186ABBA20
	public static extern uint CSharp_AkCommunicationSettings_uPoolSize_get(IntPtr jarg1); // 0x0000000187855BC0-0x0000000187855C38
	public static extern void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(IntPtr jarg1, ushort jarg2); // 0x0000000186ABBBC0-0x0000000186ABBC50
	public static extern ushort CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(IntPtr jarg1); // 0x0000000187855B48-0x0000000187855BC0
	public static extern void CSharp_AkCommunicationSettings_uCommandPort_set(IntPtr jarg1, ushort jarg2); // 0x0000000186ABBB30-0x0000000186ABBBC0
	public static extern ushort CSharp_AkCommunicationSettings_uCommandPort_get(IntPtr jarg1); // 0x0000000187855AD0-0x0000000187855B48
	public static extern void CSharp_AkCommunicationSettings_commSystem_set(IntPtr jarg1, int jarg2); // 0x0000000186ABBAA0-0x0000000186ABBB30
	public static extern int CSharp_AkCommunicationSettings_commSystem_get(IntPtr jarg1); // 0x0000000187855A68-0x0000000187855A9C
	public static extern void CSharp_AkCommunicationSettings_bInitSystemLib_set(IntPtr jarg1, bool jarg2); // 0x0000000186ABB810-0x0000000186ABB860
	public static extern bool CSharp_AkCommunicationSettings_bInitSystemLib_get(IntPtr jarg1); // 0x0000000187855A28-0x0000000187855A68
	public static extern void CSharp_AkCommunicationSettings_szAppNetworkName_set(IntPtr jarg1, string jarg2); // 0x0000000186ABBC50-0x0000000186ABBD00
	public static extern IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(IntPtr jarg1); // 0x0000000187855A9C-0x0000000187855AD0
	public static extern void CSharp_delete_AkCommunicationSettings(IntPtr jarg1); // 0x0000000186E5C6C0-0x0000000186E5C700
	public static extern IntPtr CSharp_new_AkInitializationSettings(); // 0x00000001868059D0-0x0000000186805A40
	public static extern void CSharp_delete_AkInitializationSettings(IntPtr jarg1); // 0x0000000186E25240-0x0000000186E25280
	public static extern void CSharp_AkInitializationSettings_streamMgrSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857C98-0x0000000187857CDC
	public static extern IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(IntPtr jarg1); // 0x0000000186806E40-0x0000000186806E80
	public static extern void CSharp_AkInitializationSettings_deviceSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857B48-0x0000000187857BCC
	public static extern IntPtr CSharp_AkInitializationSettings_deviceSettings_get(IntPtr jarg1); // 0x0000000186806110-0x0000000186806150
	public static extern void CSharp_AkInitializationSettings_initSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857BCC-0x0000000187857C10
	public static extern IntPtr CSharp_AkInitializationSettings_initSettings_get(IntPtr jarg1); // 0x0000000186806040-0x0000000186806080
	public static extern void CSharp_AkInitializationSettings_platformSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857C54-0x0000000187857C98
	public static extern IntPtr CSharp_AkInitializationSettings_platformSettings_get(IntPtr jarg1); // 0x0000000186805F70-0x0000000186805FB0
	public static extern void CSharp_AkInitializationSettings_musicSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857C10-0x0000000187857C54
	public static extern IntPtr CSharp_AkInitializationSettings_musicSettings_get(IntPtr jarg1); // 0x0000000186806D70-0x0000000186806DB0
	public static extern void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187857D78-0x0000000187857DBC
	public static extern IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(IntPtr jarg1); // 0x0000000186805EA0-0x0000000186805EE0
	public static extern void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(IntPtr jarg1, uint jarg2); // 0x00000001868057A0-0x00000001868057E0
	public static extern uint CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(IntPtr jarg1); // 0x0000000187857CDC-0x0000000187857D10
	public static extern void CSharp_AkInitializationSettings_uMemDebugLevel_set(IntPtr jarg1, uint jarg2); // 0x0000000186805840-0x0000000186805880
	public static extern uint CSharp_AkInitializationSettings_uMemDebugLevel_get(IntPtr jarg1); // 0x0000000187857D10-0x0000000187857D44
	public static extern void CSharp_AkInitializationSettings_uMemSpanCount_set(IntPtr jarg1, uint jarg2); // 0x00000001868058E0-0x0000000186805920
	public static extern uint CSharp_AkInitializationSettings_uMemSpanCount_get(IntPtr jarg1); // 0x0000000187857D44-0x0000000187857D78
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0(); // 0x000000018786AF48-0x000000018786AF74
	public static extern void CSharp_delete_AkExternalSourceInfo(IntPtr jarg1); // 0x0000000187869FC8-0x0000000187869FFC
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4); // 0x000000018786AF74-0x000000018786B014
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(string jarg1, uint jarg2, uint jarg3); // 0x000000018786B014-0x000000018786B0B0
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(uint jarg1, uint jarg2, uint jarg3); // 0x000000018786B0B0-0x000000018786B140
	public static extern void CSharp_AkExternalSourceInfo_Clear(IntPtr jarg1); // 0x00000001870C02C0-0x00000001870C0300
	public static extern void CSharp_AkExternalSourceInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x0000000187856BF0-0x0000000187856C34
	public static extern int CSharp_AkExternalSourceInfo_GetSizeOf(); // 0x0000000186903FD0-0x0000000186904000
	public static extern void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(IntPtr jarg1, uint jarg2); // 0x00000001863A8560-0x00000001863A85B0
	public static extern uint CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(IntPtr jarg1); // 0x0000000187856C34-0x0000000187856C68
	public static extern void CSharp_AkExternalSourceInfo_idCodec_set(IntPtr jarg1, uint jarg2); // 0x00000001863A84B0-0x00000001863A8500
	public static extern uint CSharp_AkExternalSourceInfo_idCodec_get(IntPtr jarg1); // 0x0000000187856C68-0x0000000187856C9C
	public static extern void CSharp_AkExternalSourceInfo_szFile_set(IntPtr jarg1, string jarg2); // 0x00000001863A8620-0x00000001863A86D0
	public static extern IntPtr CSharp_AkExternalSourceInfo_szFile_get(IntPtr jarg1); // 0x0000000187856D88-0x0000000187856DBC
	public static extern void CSharp_AkExternalSourceInfo_pInMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x0000000187856D44-0x0000000187856D88
	public static extern IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(IntPtr jarg1); // 0x0000000187856D10-0x0000000187856D44
	public static extern void CSharp_AkExternalSourceInfo_uiMemorySize_set(IntPtr jarg1, uint jarg2); // 0x0000000187856DF0-0x0000000187856E30
	public static extern uint CSharp_AkExternalSourceInfo_uiMemorySize_get(IntPtr jarg1); // 0x0000000187856DBC-0x0000000187856DF0
	public static extern void CSharp_AkExternalSourceInfo_idFile_set(IntPtr jarg1, uint jarg2); // 0x0000000187856CD0-0x0000000187856D10
	public static extern uint CSharp_AkExternalSourceInfo_idFile_get(IntPtr jarg1); // 0x0000000187856C9C-0x0000000187856CD0
	public static extern int CSharp_Init(IntPtr jarg1); // 0x0000000186805BB0-0x0000000186805C30
	public static extern int CSharp_InitSpatialAudio(IntPtr jarg1); // 0x00000001862E7250-0x00000001862E7290
	public static extern int CSharp_InitCommunication(IntPtr jarg1); // 0x00000001870E9C00-0x00000001870E9C40
	public static extern void CSharp_Term(); // 0x0000000187869370-0x00000001878693D8
	public static extern int CSharp_RegisterGameObjInternal(ulong jarg1); // 0x0000000187865158-0x00000001878651D0
	public static extern int CSharp_UnregisterGameObjInternal(ulong jarg1); // 0x00000001858F36A0-0x00000001858F36D0
	public static extern int CSharp_RegisterGameObjInternal_WithName(ulong jarg1, string jarg2); // 0x000000018587CC80-0x000000018587CCD0
	public static extern int CSharp_SetBasePath(string jarg1); // 0x0000000187866C7C-0x0000000187866CBC
	public static extern int CSharp_SetCurrentLanguage(string jarg1); // 0x000000018668F8A0-0x000000018668F8E0
	public static extern int CSharp_LoadFilePackage(string jarg1, out uint jarg2); // 0x00000001866918A0-0x00000001866918F0
	public static extern int CSharp_AddBasePath(string jarg1); // 0x00000001862F9C50-0x00000001862F9C90
	public static extern int CSharp_SetGameName(string jarg1); // 0x00000001878671E4-0x0000000187867224
	public static extern IntPtr CSharp_GetCurrentLanguage(); // 0x0000000187860600-0x000000018786062C
	public static extern int CSharp_UnloadFilePackage(uint jarg1); // 0x0000000186691D10-0x0000000186691D50
	public static extern int CSharp_UnloadAllFilePackages(); // 0x00000001878693D8-0x0000000187869404
	public static extern int CSharp_SetObjectPosition(ulong jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x00000001857A13B0-0x00000001857A1450
	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_0(uint jarg1, out uint[] jarg2, out uint[] jarg3, out int[] jarg4, ref uint jarg5, bool jarg6); // 0x0000000187861684-0x0000000187861868
	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_1(uint jarg1, out uint[] jarg2, out uint[] jarg3, out int[] jarg4, ref uint jarg5); // 0x0000000187861868-0x0000000187861A3C
	public static extern int CSharp_SetListeners(ulong jarg1, ulong[] jarg2, uint jarg3); // 0x0000000187867818-0x00000001878678B8
	public static extern int CSharp_SetDefaultListeners(ulong[] jarg1, uint jarg2); // 0x000000018611CFC0-0x000000018611D060
	public static extern uint CSharp_GetNumOutputDevices(uint jarg1); // 0x00000001862E6C90-0x00000001862E6CD0
	public static extern int CSharp_AddOutput__SWIG_0(IntPtr jarg1, out ulong jarg2, ulong[] jarg3, uint jarg4); // 0x0000000187853C6C-0x0000000187853D18
	public static extern int CSharp_AddOutput__SWIG_1(IntPtr jarg1, out ulong jarg2, ulong[] jarg3); // 0x0000000187853D18-0x0000000187853DB8
	public static extern int CSharp_AddOutput__SWIG_2(IntPtr jarg1, out ulong jarg2); // 0x0000000187853DB8-0x0000000187853E3C
	public static extern int CSharp_AddOutput__SWIG_3(IntPtr jarg1); // 0x0000000187853E3C-0x0000000187853E70
	public static extern void CSharp_GetDefaultStreamSettings(IntPtr jarg1); // 0x000000018786081C-0x0000000187860850
	public static extern void CSharp_GetDefaultDeviceSettings(IntPtr jarg1); // 0x000000018786074C-0x0000000187860780
	public static extern void CSharp_GetDefaultMusicSettings(IntPtr jarg1); // 0x00000001878607B4-0x00000001878607E8
	public static extern void CSharp_GetDefaultInitSettings(IntPtr jarg1); // 0x0000000187860780-0x00000001878607B4
	public static extern void CSharp_GetDefaultPlatformInitSettings(IntPtr jarg1); // 0x00000001878607E8-0x000000018786081C
	public static extern uint CSharp_GetMajorMinorVersion(); // 0x0000000186144590-0x00000001861445C0
	public static extern uint CSharp_GetSubminorBuildVersion(); // 0x00000001861444E0-0x0000000186144550
	public static extern void CSharp_StartResourceMonitoring(); // 0x0000000187868D74-0x0000000187868DA8
	public static extern void CSharp_StopResourceMonitoring(); // 0x0000000187869214-0x0000000187869248
	public static extern void CSharp_GetResourceMonitorDataSummary(IntPtr jarg1); // 0x00000001878615F8-0x000000018786162C
	public static extern void CSharp_StartDeviceCapture(ulong jarg1); // 0x0000000187868C14-0x0000000187868C48
	public static extern void CSharp_StopDeviceCapture(ulong jarg1); // 0x0000000187868E64-0x0000000187868E98
	public static extern void CSharp_ClearCaptureData(); // 0x000000018785EFDC-0x000000018785F044
	public static extern uint CSharp_UpdateCaptureSampleCount(ulong jarg1); // 0x0000000187869A58-0x0000000187869AD0
	public static extern uint CSharp_GetCaptureSamples(ulong jarg1, [In, Out] float[] jarg2, uint jarg3); // 0x0000000187860560-0x0000000187860600
	public static extern int CSharp_SetRoomPortal(ulong jarg1, ulong jarg2, ulong jarg3, IntPtr jarg4, IntPtr jarg5, bool jarg6, string jarg7); // 0x000000018786886C-0x0000000187868958
	public static extern int CSharp_SetRoom(ulong jarg1, IntPtr jarg2, ulong jarg3, string jarg4); // 0x000000018566BC40-0x000000018566BCC0
	public static extern int CSharp_RegisterSpatialAudioListener(ulong jarg1); // 0x000000018611CF40-0x000000018611CFC0
	public static extern int CSharp_UnregisterSpatialAudioListener(ulong jarg1); // 0x000000018786996C-0x00000001878699A0
	public static extern int CSharp_SetGeometry(ulong jarg1, IntPtr jarg2, uint jarg3, Vector3[] jarg4, uint jarg5, IntPtr jarg6, uint jarg7, bool jarg8, bool jarg9); // 0x0000000185A1D1A0-0x0000000185A1D230
	public static extern int CSharp_SetGeometryInstance(ulong jarg1, IntPtr jarg2, Vector3 jarg3, ulong jarg4, ulong jarg5, bool jarg6); // 0x000000018566C780-0x000000018566C810
	public static extern int CSharp_QueryReflectionPaths(ulong jarg1, uint jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out uint jarg6); // 0x0000000187865030-0x00000001878650D4
	public static extern int CSharp_QueryDiffractionPaths(ulong jarg1, uint jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out uint jarg6); // 0x0000000187864F8C-0x0000000187865030
	public static extern void CSharp_PerformStreamMgrIO(); // 0x00000001878632E4-0x0000000187863310
	public static extern void CSharp_HgMemShrink(); // 0x00000001878623AC-0x00000001878623D8
	public static extern ulong CSharp_HgGetGlobalMemoryUsed(); // 0x000000018577BF60-0x000000018577BF90
	public static extern ulong CSharp_HgGetGlobalMemoryReserved(); // 0x0000000186A82040-0x0000000186A82070
	public static extern ulong CSharp_HgGetGlobalMemoryAllocated(); // 0x0000000187862328-0x0000000187862354
	public static extern ulong CSharp_HgGetGlobalMemoryActive(); // 0x00000001878622FC-0x0000000187862328
	public static extern ulong CSharp_HgGetGlobalMemoryMapped(); // 0x0000000187862354-0x0000000187862380
	public static extern ulong CSharp_HgGetGlobalMemoryRetained(); // 0x0000000187862380-0x00000001878623AC
	public static extern void CSharp_InitScePad(); // 0x00000001869794F0-0x0000000186979560
	public static extern uint CSharp_GetMMDeviceIdFromPadContainerInfo(int jarg1); // 0x0000000187860D80-0x0000000187860DF8
	public static extern IntPtr CSharp_AkPlaylist_SWIGUpcast(IntPtr jarg1); // 0x000000018785C2C4-0x000000018785C2F8
	public static extern IntPtr CSharp_AkMIDIPost_SWIGUpcast(IntPtr jarg1); // 0x0000000187859CC0-0x0000000187859CF4
	public static extern IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000186124750-0x0000000186124790
	public static extern IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001861244D0-0x0000000186124550
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001861245D0-0x0000000186124610
	public static extern IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000186124810-0x0000000186124850
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000186124310-0x0000000186124350
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000186124260-0x00000001861242A0
	public static extern IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x00000001861243D0-0x0000000186124450
}

public class AkSoundEngine // TypeDefIndex: 83135
{
	// Fields
	public const int _WIN32_WINNT = 1538; // Metadata: 0x02641B63
	public const int AK_SIMD_ALIGNMENT = 16; // Metadata: 0x02641B65
	public const int AK_BUFFER_ALIGNMENT = 16; // Metadata: 0x02641B66
	public const int AK_XAUDIO2_FLAGS = 0; // Metadata: 0x02641B67
	public const int AK_MAX_PATH = 260; // Metadata: 0x02641B68
	public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16; // Metadata: 0x02641B6A
	public const string AK_OSCHAR_FMT = "%ls"; // Metadata: 0x02641B6B
	public const uint AK_INVALID_PLUGINID = 4294967295; // Metadata: 0x02641B6F
	public const ulong AK_INVALID_GAME_OBJECT = 18446744073709551615; // Metadata: 0x02641B70
	public const uint AK_INVALID_UNIQUE_ID = 0; // Metadata: 0x02641B78
	public const uint AK_INVALID_RTPC_ID = 0; // Metadata: 0x02641B79
	public const uint AK_INVALID_LISTENER_INDEX = 4294967295; // Metadata: 0x02641B7A
	public const uint AK_INVALID_PLAYING_ID = 0; // Metadata: 0x02641B7B
	public const uint AK_DEFAULT_SWITCH_STATE = 0; // Metadata: 0x02641B7C
	public const int AK_INVALID_POOL_ID = -1; // Metadata: 0x02641B7D
	public const int AK_DEFAULT_POOL_ID = -1; // Metadata: 0x02641B7E
	public const uint AK_INVALID_AUX_ID = 0; // Metadata: 0x02641B7F
	public const uint AK_INVALID_FILE_ID = 4294967295; // Metadata: 0x02641B80
	public const uint AK_INVALID_DEVICE_ID = 4294967295; // Metadata: 0x02641B81
	public const uint AK_INVALID_BANK_ID = 0; // Metadata: 0x02641B82
	public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0; // Metadata: 0x02641B83
	public const uint AK_INVALID_CHANNELMASK = 0; // Metadata: 0x02641B84
	public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0; // Metadata: 0x02641B85
	public const uint AK_MIXER_FX_SLOT = 4294967295; // Metadata: 0x02641B86
	public const ulong AK_DEFAULT_LISTENER_OBJ = 0; // Metadata: 0x02641B87
	public const uint AK_DEFAULT_PRIORITY = 50; // Metadata: 0x02641B8F
	public const uint AK_MIN_PRIORITY = 0; // Metadata: 0x02641B90
	public const uint AK_MAX_PRIORITY = 100; // Metadata: 0x02641B91
	public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50; // Metadata: 0x02641B92
	public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576; // Metadata: 0x02641B93
	public const uint AKCOMPANYID_AUDIOKINETIC = 0; // Metadata: 0x02641B9B
	public const uint AK_LISTENERS_MASK_ALL = 4294967295; // Metadata: 0x02641B9C
	public const int NULL = 0; // Metadata: 0x02641B9D
	public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5; // Metadata: 0x02641B9E
	public const int AK_MAX_LANGUAGE_NAME_SIZE = 32; // Metadata: 0x02641B9F
	public const int AKCOMPANYID_PLUGINDEV_MIN = 64; // Metadata: 0x02641BA0
	public const int AKCOMPANYID_PLUGINDEV_MAX = 255; // Metadata: 0x02641BA2
	public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1; // Metadata: 0x02641BA4
	public const int AKCOMPANYID_MCDSP = 256; // Metadata: 0x02641BA5
	public const int AKCOMPANYID_WAVEARTS = 257; // Metadata: 0x02641BA7
	public const int AKCOMPANYID_PHONETICARTS = 258; // Metadata: 0x02641BA9
	public const int AKCOMPANYID_IZOTOPE = 259; // Metadata: 0x02641BAB
	public const int AKCOMPANYID_CRANKCASEAUDIO = 261; // Metadata: 0x02641BAD
	public const int AKCOMPANYID_IOSONO = 262; // Metadata: 0x02641BAF
	public const int AKCOMPANYID_AUROTECHNOLOGIES = 263; // Metadata: 0x02641BB1
	public const int AKCOMPANYID_DOLBY = 264; // Metadata: 0x02641BB3
	public const int AKCOMPANYID_TWOBIGEARS = 265; // Metadata: 0x02641BB5
	public const int AKCOMPANYID_OCULUS = 266; // Metadata: 0x02641BB7
	public const int AKCOMPANYID_BLUERIPPLESOUND = 267; // Metadata: 0x02641BB9
	public const int AKCOMPANYID_ENZIEN = 268; // Metadata: 0x02641BBB
	public const int AKCOMPANYID_KROTOS = 269; // Metadata: 0x02641BBD
	public const int AKCOMPANYID_NURULIZE = 270; // Metadata: 0x02641BBF
	public const int AKCOMPANYID_SUPERPOWERED = 271; // Metadata: 0x02641BC1
	public const int AKCOMPANYID_GOOGLE = 272; // Metadata: 0x02641BC3
	public const int AKCOMPANYID_VISISONICS = 277; // Metadata: 0x02641BC5
	public const int AKCODECID_BANK = 0; // Metadata: 0x02641BC7
	public const int AKCODECID_PCM = 1; // Metadata: 0x02641BC8
	public const int AKCODECID_ADPCM = 2; // Metadata: 0x02641BC9
	public const int AKCODECID_XMA = 3; // Metadata: 0x02641BCA
	public const int AKCODECID_VORBIS = 4; // Metadata: 0x02641BCB
	public const int AKCODECID_WIIADPCM = 5; // Metadata: 0x02641BCC
	public const int AKCODECID_PCMEX = 7; // Metadata: 0x02641BCD
	public const int AKCODECID_EXTERNAL_SOURCE = 8; // Metadata: 0x02641BCE
	public const int AKCODECID_XWMA = 9; // Metadata: 0x02641BCF
	public const int AKCODECID_FILE_PACKAGE = 11; // Metadata: 0x02641BD0
	public const int AKCODECID_ATRAC9 = 12; // Metadata: 0x02641BD1
	public const int AKCODECID_VAG = 13; // Metadata: 0x02641BD2
	public const int AKCODECID_PROFILERCAPTURE = 14; // Metadata: 0x02641BD3
	public const int AKCODECID_ANALYSISFILE = 15; // Metadata: 0x02641BD4
	public const int AKCODECID_MIDI = 16; // Metadata: 0x02641BD5
	public const int AKCODECID_OPUSNX = 17; // Metadata: 0x02641BD6
	public const int AKCODECID_CAF = 18; // Metadata: 0x02641BD7
	public const int AKCODECID_AKOPUS = 19; // Metadata: 0x02641BD8
	public const int AKCODECID_AKOPUS_WEM = 20; // Metadata: 0x02641BD9
	public const int AKCODECID_MEMORYMGR_DUMP = 21; // Metadata: 0x02641BDA
	public const int AKCODECID_SONY360 = 22; // Metadata: 0x02641BDB
	public const int AKCODECID_BANK_EVENT = 30; // Metadata: 0x02641BDC
	public const int AKCODECID_BANK_BUS = 31; // Metadata: 0x02641BDD
	public const int AKPLUGINID_METER = 129; // Metadata: 0x02641BDE
	public const int AKPLUGINID_RECORDER = 132; // Metadata: 0x02641BE0
	public const int AKPLUGINID_IMPACTER = 184; // Metadata: 0x02641BE2
	public const int AKPLUGINID_SYSTEM_OUTPUT_META = 900; // Metadata: 0x02641BE4
	public const int AKPLUGINID_AUDIO_OBJECT_ATTENUATION_META = 901; // Metadata: 0x02641BE6
	public const int AKPLUGINID_AUDIO_OBJECT_PRIORITY_META = 902; // Metadata: 0x02641BE8
	public const int AKEXTENSIONID_SPATIALAUDIO = 800; // Metadata: 0x02641BEA
	public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801; // Metadata: 0x02641BEC
	public const int AKEXTENSIONID_MIDIDEVICEMGR = 802; // Metadata: 0x02641BEE
	public const int AK_WAVE_FORMAT_VAG = 65531; // Metadata: 0x02641BF0
	public const int AK_WAVE_FORMAT_AT9 = 65532; // Metadata: 0x02641BF4
	public const int AK_WAVE_FORMAT_VORBIS = 65535; // Metadata: 0x02641BF8
	public const int AK_WAVE_FORMAT_OPUSNX = 12345; // Metadata: 0x02641BFC
	public const int AK_WAVE_FORMAT_OPUS = 12352; // Metadata: 0x02641C00
	public const int AK_WAVE_FORMAT_OPUS_WEM = 12353; // Metadata: 0x02641C04
	public const int WAVE_FORMAT_XMA2 = 358; // Metadata: 0x02641C08
	public const int AK_PANNER_NUM_STORAGE_BITS = 3; // Metadata: 0x02641C0A
	public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3; // Metadata: 0x02641C0B
	public const int AK_SPAT_NUM_STORAGE_BITS = 3; // Metadata: 0x02641C0C
	public const int AK_MAX_BITS_METERING_FLAGS = 5; // Metadata: 0x02641C0D
	public const bool AK_ASYNC_OPEN_DEFAULT = false; // Metadata: 0x02641C0E
	public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024; // Metadata: 0x02641C0F
	public const double AK_DEFAULT_LISTENER_POSITION_X = 0; // Metadata: 0x02641C13
	public const double AK_DEFAULT_LISTENER_POSITION_Y = 0; // Metadata: 0x02641C1B
	public const double AK_DEFAULT_LISTENER_POSITION_Z = 0; // Metadata: 0x02641C23
	public const double AK_DEFAULT_LISTENER_FRONT_X = 0; // Metadata: 0x02641C2B
	public const double AK_DEFAULT_LISTENER_FRONT_Y = 0; // Metadata: 0x02641C33
	public const double AK_DEFAULT_LISTENER_FRONT_Z = 1; // Metadata: 0x02641C3B
	public const double AK_DEFAULT_TOP_X = 0; // Metadata: 0x02641C43
	public const double AK_DEFAULT_TOP_Y = 1; // Metadata: 0x02641C4B
	public const double AK_DEFAULT_TOP_Z = 0; // Metadata: 0x02641C53
	public const double AK_SA_EPSILON = 0.001; // Metadata: 0x02641C5B
	public const double AK_SA_DIFFRACTION_EPSILON = 0.002; // Metadata: 0x02641C63
	public const double AK_SA_PLANE_THICKNESS = 0.01; // Metadata: 0x02641C6B
	public const double AK_SA_MIN_ENVIRONMENT_ABSORPTION = 0.01; // Metadata: 0x02641C73
	public const double AK_SA_MIN_ENVIRONMENT_SURFACE_AREA = 1; // Metadata: 0x02641C7B
	public const int AK_MIDI_EVENT_TYPE_INVALID = 0; // Metadata: 0x02641C83
	public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128; // Metadata: 0x02641C84
	public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144; // Metadata: 0x02641C86
	public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160; // Metadata: 0x02641C88
	public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176; // Metadata: 0x02641C8A
	public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192; // Metadata: 0x02641C8C
	public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208; // Metadata: 0x02641C8E
	public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224; // Metadata: 0x02641C90
	public const int AK_MIDI_EVENT_TYPE_SYSEX = 240; // Metadata: 0x02641C92
	public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247; // Metadata: 0x02641C94
	public const int AK_MIDI_EVENT_TYPE_WWISE_CMD = 254; // Metadata: 0x02641C96
	public const int AK_MIDI_EVENT_TYPE_META = 255; // Metadata: 0x02641C98
	public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0; // Metadata: 0x02641C9A
	public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1; // Metadata: 0x02641C9B
	public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2; // Metadata: 0x02641C9C
	public const int AK_MIDI_CC_CTRL_3_COARSE = 3; // Metadata: 0x02641C9D
	public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4; // Metadata: 0x02641C9E
	public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5; // Metadata: 0x02641C9F
	public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6; // Metadata: 0x02641CA0
	public const int AK_MIDI_CC_VOLUME_COARSE = 7; // Metadata: 0x02641CA1
	public const int AK_MIDI_CC_BALANCE_COARSE = 8; // Metadata: 0x02641CA2
	public const int AK_MIDI_CC_CTRL_9_COARSE = 9; // Metadata: 0x02641CA3
	public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10; // Metadata: 0x02641CA4
	public const int AK_MIDI_CC_EXPRESSION_COARSE = 11; // Metadata: 0x02641CA5
	public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12; // Metadata: 0x02641CA6
	public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13; // Metadata: 0x02641CA7
	public const int AK_MIDI_CC_CTRL_14_COARSE = 14; // Metadata: 0x02641CA8
	public const int AK_MIDI_CC_CTRL_15_COARSE = 15; // Metadata: 0x02641CA9
	public const int AK_MIDI_CC_GEN_SLIDER_1 = 16; // Metadata: 0x02641CAA
	public const int AK_MIDI_CC_GEN_SLIDER_2 = 17; // Metadata: 0x02641CAB
	public const int AK_MIDI_CC_GEN_SLIDER_3 = 18; // Metadata: 0x02641CAC
	public const int AK_MIDI_CC_GEN_SLIDER_4 = 19; // Metadata: 0x02641CAD
	public const int AK_MIDI_CC_CTRL_20_COARSE = 20; // Metadata: 0x02641CAE
	public const int AK_MIDI_CC_CTRL_21_COARSE = 21; // Metadata: 0x02641CAF
	public const int AK_MIDI_CC_CTRL_22_COARSE = 22; // Metadata: 0x02641CB0
	public const int AK_MIDI_CC_CTRL_23_COARSE = 23; // Metadata: 0x02641CB1
	public const int AK_MIDI_CC_CTRL_24_COARSE = 24; // Metadata: 0x02641CB2
	public const int AK_MIDI_CC_CTRL_25_COARSE = 25; // Metadata: 0x02641CB3
	public const int AK_MIDI_CC_CTRL_26_COARSE = 26; // Metadata: 0x02641CB4
	public const int AK_MIDI_CC_CTRL_27_COARSE = 27; // Metadata: 0x02641CB5
	public const int AK_MIDI_CC_CTRL_28_COARSE = 28; // Metadata: 0x02641CB6
	public const int AK_MIDI_CC_CTRL_29_COARSE = 29; // Metadata: 0x02641CB7
	public const int AK_MIDI_CC_CTRL_30_COARSE = 30; // Metadata: 0x02641CB8
	public const int AK_MIDI_CC_CTRL_31_COARSE = 31; // Metadata: 0x02641CB9
	public const int AK_MIDI_CC_BANK_SELECT_FINE = 32; // Metadata: 0x02641CBA
	public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33; // Metadata: 0x02641CBB
	public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34; // Metadata: 0x02641CBC
	public const int AK_MIDI_CC_CTRL_3_FINE = 35; // Metadata: 0x02641CBD
	public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36; // Metadata: 0x02641CBE
	public const int AK_MIDI_CC_PORTAMENTO_FINE = 37; // Metadata: 0x02641CBF
	public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38; // Metadata: 0x02641CC0
	public const int AK_MIDI_CC_VOLUME_FINE = 39; // Metadata: 0x02641CC1
	public const int AK_MIDI_CC_BALANCE_FINE = 40; // Metadata: 0x02641CC2
	public const int AK_MIDI_CC_CTRL_9_FINE = 41; // Metadata: 0x02641CC3
	public const int AK_MIDI_CC_PAN_POSITION_FINE = 42; // Metadata: 0x02641CC4
	public const int AK_MIDI_CC_EXPRESSION_FINE = 43; // Metadata: 0x02641CC5
	public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44; // Metadata: 0x02641CC6
	public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45; // Metadata: 0x02641CC7
	public const int AK_MIDI_CC_CTRL_14_FINE = 46; // Metadata: 0x02641CC8
	public const int AK_MIDI_CC_CTRL_15_FINE = 47; // Metadata: 0x02641CC9
	public const int AK_MIDI_CC_CTRL_20_FINE = 52; // Metadata: 0x02641CCA
	public const int AK_MIDI_CC_CTRL_21_FINE = 53; // Metadata: 0x02641CCB
	public const int AK_MIDI_CC_CTRL_22_FINE = 54; // Metadata: 0x02641CCC
	public const int AK_MIDI_CC_CTRL_23_FINE = 55; // Metadata: 0x02641CCD
	public const int AK_MIDI_CC_CTRL_24_FINE = 56; // Metadata: 0x02641CCE
	public const int AK_MIDI_CC_CTRL_25_FINE = 57; // Metadata: 0x02641CCF
	public const int AK_MIDI_CC_CTRL_26_FINE = 58; // Metadata: 0x02641CD0
	public const int AK_MIDI_CC_CTRL_27_FINE = 59; // Metadata: 0x02641CD1
	public const int AK_MIDI_CC_CTRL_28_FINE = 60; // Metadata: 0x02641CD2
	public const int AK_MIDI_CC_CTRL_29_FINE = 61; // Metadata: 0x02641CD3
	public const int AK_MIDI_CC_CTRL_30_FINE = 62; // Metadata: 0x02641CD4
	public const int AK_MIDI_CC_CTRL_31_FINE = 63; // Metadata: 0x02641CD5
	public const int AK_MIDI_CC_HOLD_PEDAL = 64; // Metadata: 0x02641CD6
	public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65; // Metadata: 0x02641CD8
	public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66; // Metadata: 0x02641CDA
	public const int AK_MIDI_CC_SOFT_PEDAL = 67; // Metadata: 0x02641CDC
	public const int AK_MIDI_CC_LEGATO_PEDAL = 68; // Metadata: 0x02641CDE
	public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69; // Metadata: 0x02641CE0
	public const int AK_MIDI_CC_SOUND_VARIATION = 70; // Metadata: 0x02641CE2
	public const int AK_MIDI_CC_SOUND_TIMBRE = 71; // Metadata: 0x02641CE4
	public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72; // Metadata: 0x02641CE6
	public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73; // Metadata: 0x02641CE8
	public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74; // Metadata: 0x02641CEA
	public const int AK_MIDI_CC_SOUND_CTRL_6 = 75; // Metadata: 0x02641CEC
	public const int AK_MIDI_CC_SOUND_CTRL_7 = 76; // Metadata: 0x02641CEE
	public const int AK_MIDI_CC_SOUND_CTRL_8 = 77; // Metadata: 0x02641CF0
	public const int AK_MIDI_CC_SOUND_CTRL_9 = 78; // Metadata: 0x02641CF2
	public const int AK_MIDI_CC_SOUND_CTRL_10 = 79; // Metadata: 0x02641CF4
	public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80; // Metadata: 0x02641CF6
	public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81; // Metadata: 0x02641CF8
	public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82; // Metadata: 0x02641CFA
	public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83; // Metadata: 0x02641CFC
	public const int AK_MIDI_CC_REVERB_LEVEL = 91; // Metadata: 0x02641CFE
	public const int AK_MIDI_CC_TREMOLO_LEVEL = 92; // Metadata: 0x02641D00
	public const int AK_MIDI_CC_CHORUS_LEVEL = 93; // Metadata: 0x02641D02
	public const int AK_MIDI_CC_CELESTE_LEVEL = 94; // Metadata: 0x02641D04
	public const int AK_MIDI_CC_PHASER_LEVEL = 95; // Metadata: 0x02641D06
	public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96; // Metadata: 0x02641D08
	public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97; // Metadata: 0x02641D0A
	public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98; // Metadata: 0x02641D0C
	public const int AK_MIDI_CC_NON_REGISTER_FINE = 99; // Metadata: 0x02641D0E
	public const int AK_MIDI_CC_ALL_SOUND_OFF = 120; // Metadata: 0x02641D10
	public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121; // Metadata: 0x02641D12
	public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122; // Metadata: 0x02641D14
	public const int AK_MIDI_CC_ALL_NOTES_OFF = 123; // Metadata: 0x02641D16
	public const int AK_MIDI_CC_OMNI_MODE_OFF = 124; // Metadata: 0x02641D18
	public const int AK_MIDI_CC_OMNI_MODE_ON = 125; // Metadata: 0x02641D1A
	public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126; // Metadata: 0x02641D1C
	public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127; // Metadata: 0x02641D1E
	public const int AK_MIDI_WWISE_CMD_PLAY = 0; // Metadata: 0x02641D20
	public const int AK_MIDI_WWISE_CMD_STOP = 1; // Metadata: 0x02641D21
	public const int AK_MIDI_WWISE_CMD_PAUSE = 2; // Metadata: 0x02641D22
	public const int AK_MIDI_WWISE_CMD_RESUME = 3; // Metadata: 0x02641D23
	public const int AK_MIDI_WWISE_CMD_SEEK_MS = 4; // Metadata: 0x02641D24
	public const int AK_MIDI_WWISE_CMD_SEEK_SAMPLES = 5; // Metadata: 0x02641D25
	public const int AK_SPEAKER_FRONT_LEFT = 1; // Metadata: 0x02641D26
	public const int AK_SPEAKER_FRONT_RIGHT = 2; // Metadata: 0x02641D27
	public const int AK_SPEAKER_FRONT_CENTER = 4; // Metadata: 0x02641D28
	public const int AK_SPEAKER_LOW_FREQUENCY = 8; // Metadata: 0x02641D29
	public const int AK_SPEAKER_BACK_LEFT = 16; // Metadata: 0x02641D2A
	public const int AK_SPEAKER_BACK_RIGHT = 32; // Metadata: 0x02641D2B
	public const int AK_SPEAKER_BACK_CENTER = 256; // Metadata: 0x02641D2C
	public const int AK_SPEAKER_SIDE_LEFT = 512; // Metadata: 0x02641D2E
	public const int AK_SPEAKER_SIDE_RIGHT = 1024; // Metadata: 0x02641D30
	public const int AK_SPEAKER_TOP = 2048; // Metadata: 0x02641D32
	public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096; // Metadata: 0x02641D34
	public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192; // Metadata: 0x02641D36
	public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384; // Metadata: 0x02641D3A
	public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768; // Metadata: 0x02641D3E
	public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536; // Metadata: 0x02641D42
	public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072; // Metadata: 0x02641D46
	public const int AK_SPEAKER_SETUP_MONO = 4; // Metadata: 0x02641D4A
	public const int AK_SPEAKER_SETUP_0POINT1 = 8; // Metadata: 0x02641D4B
	public const int AK_SPEAKER_SETUP_1POINT1 = 12; // Metadata: 0x02641D4C
	public const int AK_SPEAKER_SETUP_STEREO = 3; // Metadata: 0x02641D4D
	public const int AK_SPEAKER_SETUP_2POINT1 = 11; // Metadata: 0x02641D4E
	public const int AK_SPEAKER_SETUP_3STEREO = 7; // Metadata: 0x02641D4F
	public const int AK_SPEAKER_SETUP_3POINT1 = 15; // Metadata: 0x02641D50
	public const int AK_SPEAKER_SETUP_4 = 1539; // Metadata: 0x02641D51
	public const int AK_SPEAKER_SETUP_4POINT1 = 1547; // Metadata: 0x02641D53
	public const int AK_SPEAKER_SETUP_5 = 1543; // Metadata: 0x02641D55
	public const int AK_SPEAKER_SETUP_5POINT1 = 1551; // Metadata: 0x02641D57
	public const int AK_SPEAKER_SETUP_6 = 1587; // Metadata: 0x02641D59
	public const int AK_SPEAKER_SETUP_6POINT1 = 1595; // Metadata: 0x02641D5B
	public const int AK_SPEAKER_SETUP_7 = 1591; // Metadata: 0x02641D5D
	public const int AK_SPEAKER_SETUP_7POINT1 = 1599; // Metadata: 0x02641D5F
	public const int AK_SPEAKER_SETUP_SURROUND = 259; // Metadata: 0x02641D61
	public const int AK_SPEAKER_SETUP_DPL2 = 1539; // Metadata: 0x02641D63
	public const int AK_SPEAKER_SETUP_HEIGHT_2 = 20480; // Metadata: 0x02641D65
	public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320; // Metadata: 0x02641D69
	public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512; // Metadata: 0x02641D6D
	public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048; // Metadata: 0x02641D71
	public const int AK_SPEAKER_SETUP_HEIGHT_4_TOP = 186368; // Metadata: 0x02641D75
	public const int AK_SPEAKER_SETUP_HEIGHT_5_TOP = 194560; // Metadata: 0x02641D79
	public const int AK_SPEAKER_SETUP_AURO_222 = 22019; // Metadata: 0x02641D7D
	public const int AK_SPEAKER_SETUP_AURO_8 = 185859; // Metadata: 0x02641D81
	public const int AK_SPEAKER_SETUP_AURO_9 = 185863; // Metadata: 0x02641D85
	public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871; // Metadata: 0x02641D89
	public const int AK_SPEAKER_SETUP_AURO_10 = 187911; // Metadata: 0x02641D8D
	public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919; // Metadata: 0x02641D91
	public const int AK_SPEAKER_SETUP_AURO_11 = 196103; // Metadata: 0x02641D95
	public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111; // Metadata: 0x02641D99
	public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911; // Metadata: 0x02641D9D
	public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919; // Metadata: 0x02641DA1
	public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151; // Metadata: 0x02641DA5
	public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159; // Metadata: 0x02641DA9
	public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023; // Metadata: 0x02641DAD
	public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031; // Metadata: 0x02641DB1
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067; // Metadata: 0x02641DB5
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075; // Metadata: 0x02641DB9
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907; // Metadata: 0x02641DBD
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915; // Metadata: 0x02641DC1
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071; // Metadata: 0x02641DC5
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079; // Metadata: 0x02641DC9
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911; // Metadata: 0x02641DCD
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919; // Metadata: 0x02641DD1
	public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951; // Metadata: 0x02641DD5
	public const int AK_IDX_SETUP_FRONT_LEFT = 0; // Metadata: 0x02641DD9
	public const int AK_IDX_SETUP_FRONT_RIGHT = 1; // Metadata: 0x02641DDA
	public const int AK_IDX_SETUP_CENTER = 2; // Metadata: 0x02641DDB
	public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2; // Metadata: 0x02641DDC
	public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3; // Metadata: 0x02641DDD
	public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4; // Metadata: 0x02641DDE
	public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5; // Metadata: 0x02641DDF
	public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3; // Metadata: 0x02641DE0
	public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4; // Metadata: 0x02641DE1
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5; // Metadata: 0x02641DE2
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6; // Metadata: 0x02641DE3
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_LEFT = 7; // Metadata: 0x02641DE4
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_RIGHT = 8; // Metadata: 0x02641DE5
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_LEFT = 9; // Metadata: 0x02641DE6
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_RIGHT = 10; // Metadata: 0x02641DE7
	public const int AK_IDX_SETUP_0_LFE = 0; // Metadata: 0x02641DE8
	public const int AK_IDX_SETUP_1_CENTER = 0; // Metadata: 0x02641DE9
	public const int AK_IDX_SETUP_1_LFE = 1; // Metadata: 0x02641DEA
	public const int AK_IDX_SETUP_2_LEFT = 0; // Metadata: 0x02641DEB
	public const int AK_IDX_SETUP_2_RIGHT = 1; // Metadata: 0x02641DEC
	public const int AK_IDX_SETUP_2_LFE = 2; // Metadata: 0x02641DED
	public const int AK_IDX_SETUP_3_LEFT = 0; // Metadata: 0x02641DEE
	public const int AK_IDX_SETUP_3_RIGHT = 1; // Metadata: 0x02641DEF
	public const int AK_IDX_SETUP_3_CENTER = 2; // Metadata: 0x02641DF0
	public const int AK_IDX_SETUP_3_LFE = 3; // Metadata: 0x02641DF1
	public const int AK_IDX_SETUP_4_FRONTLEFT = 0; // Metadata: 0x02641DF2
	public const int AK_IDX_SETUP_4_FRONTRIGHT = 1; // Metadata: 0x02641DF3
	public const int AK_IDX_SETUP_4_REARLEFT = 2; // Metadata: 0x02641DF4
	public const int AK_IDX_SETUP_4_REARRIGHT = 3; // Metadata: 0x02641DF5
	public const int AK_IDX_SETUP_4_LFE = 4; // Metadata: 0x02641DF6
	public const int AK_IDX_SETUP_5_FRONTLEFT = 0; // Metadata: 0x02641DF7
	public const int AK_IDX_SETUP_5_FRONTRIGHT = 1; // Metadata: 0x02641DF8
	public const int AK_IDX_SETUP_5_CENTER = 2; // Metadata: 0x02641DF9
	public const int AK_IDX_SETUP_5_REARLEFT = 3; // Metadata: 0x02641DFA
	public const int AK_IDX_SETUP_5_REARRIGHT = 4; // Metadata: 0x02641DFB
	public const int AK_IDX_SETUP_5_LFE = 5; // Metadata: 0x02641DFC
	public const int AK_IDX_SETUP_6_FRONTLEFT = 0; // Metadata: 0x02641DFD
	public const int AK_IDX_SETUP_6_FRONTRIGHT = 1; // Metadata: 0x02641DFE
	public const int AK_IDX_SETUP_6_REARLEFT = 2; // Metadata: 0x02641DFF
	public const int AK_IDX_SETUP_6_REARRIGHT = 3; // Metadata: 0x02641E00
	public const int AK_IDX_SETUP_6_SIDELEFT = 4; // Metadata: 0x02641E01
	public const int AK_IDX_SETUP_6_SIDERIGHT = 5; // Metadata: 0x02641E02
	public const int AK_IDX_SETUP_6_LFE = 6; // Metadata: 0x02641E03
	public const int AK_IDX_SETUP_7_FRONTLEFT = 0; // Metadata: 0x02641E04
	public const int AK_IDX_SETUP_7_FRONTRIGHT = 1; // Metadata: 0x02641E05
	public const int AK_IDX_SETUP_7_CENTER = 2; // Metadata: 0x02641E06
	public const int AK_IDX_SETUP_7_REARLEFT = 3; // Metadata: 0x02641E07
	public const int AK_IDX_SETUP_7_REARRIGHT = 4; // Metadata: 0x02641E08
	public const int AK_IDX_SETUP_7_SIDELEFT = 5; // Metadata: 0x02641E09
	public const int AK_IDX_SETUP_7_SIDERIGHT = 6; // Metadata: 0x02641E0A
	public const int AK_IDX_SETUP_7_LFE = 7; // Metadata: 0x02641E0B
	public const int AK_SPEAKER_SETUP_0_1 = 8; // Metadata: 0x02641E0C
	public const int AK_SPEAKER_SETUP_1_0_CENTER = 4; // Metadata: 0x02641E0D
	public const int AK_SPEAKER_SETUP_1_1_CENTER = 12; // Metadata: 0x02641E0E
	public const int AK_SPEAKER_SETUP_2_0 = 3; // Metadata: 0x02641E0F
	public const int AK_SPEAKER_SETUP_2_1 = 11; // Metadata: 0x02641E10
	public const int AK_SPEAKER_SETUP_3_0 = 7; // Metadata: 0x02641E11
	public const int AK_SPEAKER_SETUP_3_1 = 15; // Metadata: 0x02641E12
	public const int AK_SPEAKER_SETUP_FRONT = 7; // Metadata: 0x02641E13
	public const int AK_SPEAKER_SETUP_4_0 = 1539; // Metadata: 0x02641E14
	public const int AK_SPEAKER_SETUP_4_1 = 1547; // Metadata: 0x02641E16
	public const int AK_SPEAKER_SETUP_5_0 = 1543; // Metadata: 0x02641E18
	public const int AK_SPEAKER_SETUP_5_1 = 1551; // Metadata: 0x02641E1A
	public const int AK_SPEAKER_SETUP_6_0 = 1587; // Metadata: 0x02641E1C
	public const int AK_SPEAKER_SETUP_6_1 = 1595; // Metadata: 0x02641E1E
	public const int AK_SPEAKER_SETUP_7_0 = 1591; // Metadata: 0x02641E20
	public const int AK_SPEAKER_SETUP_7_1 = 1599; // Metadata: 0x02641E22
	public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599; // Metadata: 0x02641E24
	public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951; // Metadata: 0x02641E26
	public const int AK_STANDARD_MAX_NUM_CHANNELS = 8; // Metadata: 0x02641E2A
	public const int AK_MAX_AMBISONICS_ORDER = 5; // Metadata: 0x02641E2B
	public const int AK_MAX_NUM_TEXTURE = 4; // Metadata: 0x02641E2C
	public const int AK_MAX_REFLECT_ORDER = 4; // Metadata: 0x02641E2D
	public const int AK_MAX_REFLECTION_PATH_LENGTH = 8; // Metadata: 0x02641E2E
	public const int AK_STOCHASTIC_RESERVE_LENGTH = 8; // Metadata: 0x02641E2F
	public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8; // Metadata: 0x02641E30
	public const int AK_MAX_SOUND_PROPAGATION_WIDTH = 8; // Metadata: 0x02641E31
	public const double AK_SA_DIFFRACTION_DOT_EPSILON = 5E-05; // Metadata: 0x02641E32
	public const double AK_DEFAULT_GEOMETRY_POSITION_X = 0; // Metadata: 0x02641E3A
	public const double AK_DEFAULT_GEOMETRY_POSITION_Y = 0; // Metadata: 0x02641E42
	public const double AK_DEFAULT_GEOMETRY_POSITION_Z = 0; // Metadata: 0x02641E4A
	public const double AK_DEFAULT_GEOMETRY_FRONT_X = 0; // Metadata: 0x02641E52
	public const double AK_DEFAULT_GEOMETRY_FRONT_Y = 0; // Metadata: 0x02641E5A
	public const double AK_DEFAULT_GEOMETRY_FRONT_Z = 1; // Metadata: 0x02641E62
	public const double AK_DEFAULT_GEOMETRY_TOP_X = 0; // Metadata: 0x02641E6A
	public const double AK_DEFAULT_GEOMETRY_TOP_Y = 1; // Metadata: 0x02641E72
	public const double AK_DEFAULT_GEOMETRY_TOP_Z = 0; // Metadata: 0x02641E7A
	private static GameObjectHashFunction gameObjectHash; // 0x00
	public const uint AK_PENDING_EVENT_LOAD_ID = 4294967295; // Metadata: 0x02641E82

	// Properties
	public static uint AK_INVALID_SHARE_SET_ID { get; } // 0x000000018788235C-0x000000018788239C 
	public static uint AK_INVALID_PIPELINE_ID { get; } // 0x000000018788231C-0x000000018788235C 
	public static ulong AK_INVALID_AUDIO_OBJECT_ID { get; } // 0x000000018788225C-0x000000018788229C 
	public static uint AK_SOUNDBANK_VERSION { get; } // 0x00000001878824DC-0x000000018788251C 
	public static uint AkJobType_Generic { get; } // 0x000000018788255C-0x000000018788259C 
	public static uint AkJobType_AudioProcessing { get; } // 0x000000018788251C-0x000000018788255C 
	public static uint AkJobType_SpatialAudio { get; } // 0x000000018788259C-0x00000001878825DC 
	public static uint AK_NUM_JOB_TYPES { get; } // 0x000000018788249C-0x00000001878824DC 
	public static ushort AK_INT { get; } // 0x000000018788221C-0x000000018788225C 
	public static ushort AK_FLOAT { get; } // 0x000000018788219C-0x00000001878821DC 
	public static byte AK_INTERLEAVED { get; } // 0x00000001878821DC-0x000000018788221C 
	public static byte AK_NONINTERLEAVED { get; } // 0x000000018788245C-0x000000018788249C 
	public static uint AK_LE_NATIVE_BITSPERSAMPLE { get; } // 0x000000018788239C-0x00000001878823DC 
	public static uint AK_LE_NATIVE_SAMPLETYPE { get; } // 0x000000018788241C-0x000000018788245C 
	public static uint AK_LE_NATIVE_INTERLEAVE { get; } // 0x00000001878823DC-0x000000018788241C 
	public static byte AK_INVALID_MIDI_CHANNEL { get; } // 0x000000018788229C-0x00000001878822DC 
	public static byte AK_INVALID_MIDI_NOTE { get; } // 0x00000001878822DC-0x000000018788231C 
	public static uint kDefaultDiffractionMaxEdges { get; } // 0x00000001878825DC-0x000000018788261C 
	public static uint kDefaultDiffractionMaxPaths { get; } // 0x000000018788261C-0x000000018788265C 
	public static float kMaxDiffraction { get; } // 0x000000018788271C-0x000000018788275C 
	public static uint kHashListBlockAllocItemCount { get; } // 0x00000001878826DC-0x000000018788271C 
	public static uint kDiffractionMaxEdges { get; } // 0x000000018788265C-0x000000018788269C 
	public static uint kDiffractionMaxPaths { get; } // 0x000000018788269C-0x00000001878826DC 
	public static uint kPortalToPortalDiffractionMaxPaths { get; } // 0x000000018788275C-0x000000018788279C 
	public static GameObjectHashFunction GameObjectHash { set; } // 0x000000018788279C-0x0000000187882844
	public static string WwiseVersion { get; } // 0x0000000186144820-0x00000001861449C0 

	// Nested types
	public delegate ulong GameObjectHashFunction(GameObject gameObject); // TypeDefIndex: 83134; 0x0000000185B78EA0-0x0000000185B78EB0

	// Constructors
	public AkSoundEngine(); // 0x0000000186805BA0-0x0000000186805BB0
	static AkSoundEngine(); // 0x0000000186FC26C0-0x0000000186FC2760

	// Methods
	public static uint JoystickIdToWwiseId(uint joyStickID); // 0x00000001878783D0-0x0000000187878418
	public static Vector3 ConvertAkVector64ToAkVector(AkVector64 in_); // 0x0000000187874E18-0x0000000187874E94
	public static AkTransform ConvertAkWorldTransformToAkTransform(AkWorldTransform in_); // 0x0000000187874F10-0x0000000187874F8C
	public static AkVector64 ConvertAkVectorToAkVector64(Vector3 in_); // 0x0000000187874E94-0x0000000187874F10
	public static AkWorldTransform ConvertAkTransformToAkWorldTransform(AkTransform in_); // 0x0000000187874D9C-0x0000000187874E18
	public static bool IsBankCodecID(uint in_codecID); // 0x000000018787832C-0x0000000187878374
	public static uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType); // 0x000000018787524C-0x0000000187875328
	public static uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x0000000187875328-0x00000001878753FC
	public static uint DynamicSequenceOpen(ulong in_gameObjectID); // 0x0000000187875488-0x00000001878754F0
	public static AKRESULT DynamicSequenceClose(uint in_playingID); // 0x0000000187875020-0x0000000187875068
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001878756EC-0x0000000187875748
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration); // 0x0000000187875748-0x00000001878757A0
	public static AKRESULT DynamicSequencePlay(uint in_playingID); // 0x00000001878757A0-0x00000001878757E8
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x0000000187875638-0x0000000187875694
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration); // 0x0000000187875694-0x00000001878756EC
	public static AKRESULT DynamicSequencePause(uint in_playingID); // 0x00000001878755F0-0x0000000187875638
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x0000000187875888-0x00000001878758E4
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration); // 0x00000001878757E8-0x0000000187875840
	public static AKRESULT DynamicSequenceResume(uint in_playingID); // 0x0000000187875840-0x0000000187875888
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001878758E4-0x0000000187875940
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration); // 0x0000000187875940-0x0000000187875998
	public static AKRESULT DynamicSequenceStop(uint in_playingID); // 0x0000000187875998-0x00000001878759E0
	public static AKRESULT DynamicSequenceBreak(uint in_playingID); // 0x0000000187874FD8-0x0000000187875020
	public static AKRESULT Seek(uint in_playingID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x000000018787DF6C-0x000000018787DFC8
	public static AKRESULT Seek(uint in_playingID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x000000018787DFC8-0x000000018787E028
	public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration); // 0x0000000187875068-0x00000001878750C8
	public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID); // 0x00000001878750C8-0x0000000187875154
	public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID); // 0x00000001878759E0-0x0000000187875A28
	public static bool IsInitialized(); // 0x00000001862FA670-0x00000001862FA6C0
	public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings); // 0x000000018787642C-0x0000000187876480
	public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput); // 0x0000000187877BB4-0x0000000187877C24
	public static AkChannelConfig GetSpeakerConfiguration(); // 0x00000001862FA3E0-0x00000001862FA460
	public static AKRESULT GetOutputDeviceConfiguration(ulong in_idOutput, AkChannelConfig io_channelConfig, Ak3DAudioSinkCapabilities io_capabilities); // 0x00000001878770F0-0x0000000187877174
	public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput); // 0x0000000187877270-0x00000001878772CC
	public static AKRESULT GetPanningRule(out int out_ePanningRule); // 0x0000000187877224-0x0000000187877270
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput); // 0x0000000187880008-0x0000000187880060
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule); // 0x000000018787FFC0-0x0000000187880008
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput); // 0x0000000187877ADC-0x0000000187877B54
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle); // 0x0000000187877B54-0x0000000187877BB4
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput); // 0x0000000187880E28-0x0000000187880E9C
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle); // 0x0000000187880E9C-0x0000000187880EFC
	public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB); // 0x0000000187881120-0x0000000187881170
	public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices); // 0x000000018787F250-0x000000018787F29C
	public static AKRESULT SetJobMgrMaxActiveWorkers(uint in_jobType, uint in_uNewMaxActiveWorkers); // 0x000000018787EE8C-0x000000018787EEE4
	public static AKRESULT RenderAudio(bool in_bAllowSyncRender); // 0x000000018787C494-0x000000018787C4E0
	public static AKRESULT RenderAudio(); // 0x000000018577E160-0x000000018577E1B0
	public static AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath); // 0x000000018787BF8C-0x000000018787BFE8
	public static AKRESULT RegisterPluginDLL(string in_DllName); // 0x000000018787BFE8-0x000000018787C034
	public static bool IsPluginRegistered(AkPluginType in_eType, uint in_ulCompanyID, uint in_ulPluginID); // 0x0000000187878374-0x00000001878783D0
	public static uint GetIDFromString(string in_pszString); // 0x0000000186118A10-0x0000000186118A60
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID); // 0x000000018787925C-0x0000000187879384
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x00000001863A82A0-0x00000001863A83F0
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x000000018598AA20-0x000000018598ADA0
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID); // 0x00000001878795E4-0x0000000187879658
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID); // 0x0000000187879DA4-0x0000000187879ECC
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x00000001878794D0-0x00000001878795E4
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x0000000187879BC4-0x0000000187879CA4
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID); // 0x00000001878798DC-0x0000000187879954
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID); // 0x0000000187875EFC-0x0000000187875F74
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x0000000187875CD4-0x0000000187875D48
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration); // 0x0000000187876288-0x00000001878762FC
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID); // 0x0000000187875AC4-0x0000000187875B20
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType); // 0x000000018787605C-0x00000001878760B4
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID); // 0x0000000187875C5C-0x0000000187875CD4
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x0000000187875FE8-0x000000018787605C
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration); // 0x0000000187875F74-0x0000000187875FE8
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID); // 0x0000000187875B20-0x0000000187875B80
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType); // 0x0000000187875C04-0x0000000187875C5C
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID); // 0x0000000187879ECC-0x0000000187879FF8
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x000000018787A204-0x000000018787A328
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets); // 0x000000018787A150-0x000000018787A204
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts); // 0x000000018787A0A4-0x000000018787A150
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_playingID); // 0x00000001878815FC-0x000000018788165C
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID); // 0x00000001878815A4-0x00000001878815FC
	public static AKRESULT StopMIDIOnEvent(uint in_eventID); // 0x000000018788155C-0x00000001878815A4
	public static AKRESULT StopMIDIOnEvent(); // 0x000000018788151C-0x000000018788155C
	public static AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority); // 0x0000000187878C50-0x0000000187878CB0
	public static AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority); // 0x0000000187878CB0-0x0000000187878D10
	public static AKRESULT UnpinEventInStreamCache(uint in_eventID); // 0x0000000187881D90-0x0000000187881DD8
	public static AKRESULT UnpinEventInStreamCache(string in_pszEventName); // 0x0000000187881D44-0x0000000187881D90
	public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull); // 0x0000000187876520-0x0000000187876580
	public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull); // 0x00000001878764C0-0x0000000187876520
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x000000018787D490-0x000000018787D504
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x000000018787D57C-0x000000018787D5F0
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition); // 0x000000018787D950-0x000000018787D9B0
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x000000018787D704-0x000000018787D77C
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x000000018787D344-0x000000018787D3BC
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition); // 0x000000018787DE84-0x000000018787DEE4
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x000000018787DB6C-0x000000018787DBE0
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x000000018787D3BC-0x000000018787D430
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent); // 0x000000018787D430-0x000000018787D490
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x000000018787D504-0x000000018787D57C
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x000000018787D68C-0x000000018787D704
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent); // 0x000000018787DD88-0x000000018787DDE8
	public static void CancelEventCallbackCookie(object in_pCookie); // 0x0000000187874958-0x00000001878749A4
	public static void CancelEventCallbackGameObject(ulong in_gameObjectID); // 0x0000000187874A0C-0x0000000187874A58
	public static void CancelEventCallback(uint in_playingID); // 0x0000000187874A58-0x0000000187874AA0
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate); // 0x0000000187877A1C-0x0000000187877A7C
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition); // 0x00000001878779C4-0x0000000187877A1C
	public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering); // 0x0000000187877A7C-0x0000000187877ADC
	public static void StopAll(ulong in_gameObjectID); // 0x00000001858F3580-0x00000001858F35B0
	public static void StopAll(); // 0x0000000187881398-0x00000001878813D8
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018788169C-0x00000001878816F8
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration); // 0x00000001878816F8-0x0000000187881750
	public static void StopPlayingID(uint in_playingID); // 0x0000000187881750-0x0000000187881798
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x0000000187876354-0x00000001878763C8
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration); // 0x0000000185A7D020-0x0000000185A7D070
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID); // 0x00000001878762FC-0x0000000187876354
	public static void SetRandomSeed(uint in_uSeed); // 0x0000000187880CC0-0x0000000187880D08
	public static void MuteBackgroundMusic(bool in_bMute); // 0x0000000187878BC4-0x0000000187878C10
	public static bool GetBackgroundMusicMute(); // 0x0000000187876480-0x00000001878764C0
	public static AKRESULT SendPluginCustomGameData(uint in_busID, ulong in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes); // 0x000000018787E028-0x000000018787E0A0
	public static AKRESULT UnregisterAllGameObj(); // 0x0000000187881DD8-0x0000000187881E18
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags); // 0x000000018787F510-0x000000018787F598
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType); // 0x0000000185A1ADC0-0x0000000185A1AE60
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions); // 0x000000018787F90C-0x000000018787F980
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags); // 0x000000018787F598-0x000000018787F620
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType); // 0x000000018787F694-0x000000018787F71C
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions); // 0x000000018787F620-0x000000018787F694
	public static AKRESULT SetScalingFactor(ulong in_GameObjectID, float in_fAttenuationScalingFactor); // 0x0000000185E86E50-0x0000000185E86E90
	public static AKRESULT SetDistanceProbe(ulong in_listenerGameObjectID, ulong in_distanceProbeGameObjectID); // 0x000000018787E4D4-0x000000018787E530
	public static AKRESULT ClearBanks(); // 0x0000000187874B88-0x0000000187874BC8
	public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority); // 0x000000018787E1F4-0x000000018787E250
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID, uint in_bankType); // 0x0000000187878A24-0x0000000187878A84
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID); // 0x0000000187878970-0x00000001878789CC
	public static AKRESULT LoadBank(uint in_bankID, uint in_bankType); // 0x00000001878789CC-0x0000000187878A24
	public static AKRESULT LoadBank(uint in_bankID); // 0x000000018668F5A0-0x000000018668F5F0
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID); // 0x000000018787873C-0x000000018787879C
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID, out uint out_bankType); // 0x00000001878786C8-0x000000018787873C
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID); // 0x00000001878784B4-0x0000000187878514
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID, out uint out_bankType); // 0x0000000187878514-0x0000000187878588
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, uint in_bankType); // 0x00000001878788D4-0x0000000187878970
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID); // 0x0000000187878838-0x00000001878788D4
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType); // 0x0000000186118F90-0x0000000186119010
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x0000000186118AA0-0x0000000186118B40
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID); // 0x000000018787879C-0x0000000187878838
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, out uint out_bankType); // 0x0000000187878628-0x00000001878786C8
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID); // 0x0000000187878418-0x00000001878784B4
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, out uint out_bankType); // 0x0000000187878588-0x0000000187878628
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, uint in_bankType); // 0x0000000187881B9C-0x0000000187881BFC
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr); // 0x0000000187881C48-0x0000000187881CA4
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, uint in_bankType); // 0x0000000187881BFC-0x0000000187881C48
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr); // 0x0000000187881A08-0x0000000187881A60
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType); // 0x0000000187881A60-0x0000000187881B00
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x0000000187881CA4-0x0000000187881D44
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType); // 0x0000000186118DC0-0x0000000186118E40
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x0000000187881B00-0x0000000187881B9C
	public static void CancelBankCallbackCookie(object in_pCookie); // 0x000000018787490C-0x0000000187874958
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags, uint in_bankType); // 0x000000018787ABD4-0x000000018787AC48
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags); // 0x000000018787ADE0-0x000000018787AE40
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString); // 0x000000018787A950-0x000000018787A9A8
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags, uint in_bankType); // 0x000000018787AE40-0x000000018787AEB4
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags); // 0x000000018787ACE4-0x000000018787AD40
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID); // 0x000000018787AB7C-0x000000018787ABD4
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType); // 0x000000018787AD40-0x000000018787ADE0
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags); // 0x000000018787AC48-0x000000018787ACE4
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x000000018787A9A8-0x000000018787AA44
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType); // 0x000000018787AA44-0x000000018787AAE0
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags); // 0x000000018787A8B4-0x000000018787A950
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x000000018787AAE0-0x000000018787AB7C
	public static AKRESULT ClearPreparedEvents(); // 0x0000000187874D5C-0x0000000187874D9C
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent); // 0x000000018787B158-0x000000018787B370
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent); // 0x000000018787AEB4-0x000000018787AF00
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x000000018787AF00-0x000000018787B158
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x0000000186119010-0x00000001861190D0
	public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings); // 0x000000018787F29C-0x000000018787F308
	public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings); // 0x000000018788205C-0x00000001878820C8
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs); // 0x000000018787B3E4-0x000000018787B610
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs); // 0x000000018787B370-0x000000018787B3E4
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x000000018787B6D4-0x000000018787B93C
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x000000018787B610-0x000000018787B6D4
	public static AKRESULT AddListener(ulong in_emitterGameObj, ulong in_listenerGameObj); // 0x0000000187874484-0x00000001878744E0
	public static AKRESULT RemoveListener(ulong in_emitterGameObj, ulong in_listenerGameObj); // 0x000000018787C354-0x000000018787C3B0
	public static AKRESULT AddDefaultListener(ulong in_listenerGameObj); // 0x0000000187874438-0x0000000187874484
	public static AKRESULT RemoveDefaultListener(ulong in_listenerGameObj); // 0x000000018787C09C-0x000000018787C0E8
	public static AKRESULT ResetListenersToDefault(ulong in_emitterGameObj); // 0x000000018787C620-0x000000018787C66C
	public static AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets); // 0x000000018787EF58-0x000000018787EFDC
	public static AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig); // 0x000000018787EEE4-0x000000018787EF58
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018788062C-0x00000001878806A4
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x0000000187880558-0x00000001878805CC
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration); // 0x0000000185778A60-0x0000000185778AE0
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID); // 0x00000001878805CC-0x000000018788062C
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value); // 0x0000000187880AD4-0x0000000187880B2C
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001878804DC-0x0000000187880558
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018788071C-0x0000000187880794
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration); // 0x00000001878806A4-0x000000018788071C
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID); // 0x0000000187880A74-0x0000000187880AD4
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value); // 0x0000000187880C64-0x0000000187880CC0
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001878801E4-0x000000018788025C
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001878802D8-0x000000018788034C
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration); // 0x00000001862BE240-0x00000001862BE2D0
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID); // 0x0000000187880124-0x0000000187880184
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018788025C-0x00000001878802D8
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018788034C-0x00000001878803C4
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration); // 0x00000001878803C4-0x000000018788043C
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID); // 0x0000000187880184-0x00000001878801E4
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018787CF00-0x000000018787CF74
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018787CE44-0x000000018787CEB8
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration); // 0x000000018787CC28-0x000000018787CC88
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID); // 0x000000018787CDEC-0x000000018787CE44
	public static AKRESULT ResetRTPCValue(uint in_rtpcID); // 0x000000018787CEB8-0x000000018787CF00
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018787CC88-0x000000018787CD00
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018787CD00-0x000000018787CD78
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration); // 0x000000018787C9A8-0x000000018787CA08
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID); // 0x000000018787D194-0x000000018787D1F0
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName); // 0x000000018787D0AC-0x000000018787D0F8
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018787C798-0x000000018787C80C
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018787C66C-0x000000018787C6E0
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration); // 0x000000018787C864-0x000000018787C8C0
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID); // 0x000000018787C6E0-0x000000018787C738
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018787C8C0-0x000000018787C934
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018787C934-0x000000018787C9A8
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration); // 0x000000018787C738-0x000000018787C798
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID); // 0x000000018787C80C-0x000000018787C864
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, ulong in_gameObjectID); // 0x0000000187880F58-0x0000000187880FB4
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, ulong in_gameObjectID); // 0x000000018788103C-0x000000018788109C
	public static AKRESULT PostTrigger(uint in_triggerID, ulong in_gameObjectID); // 0x000000018787A85C-0x000000018787A8B4
	public static AKRESULT PostTrigger(string in_pszTrigger, ulong in_gameObjectID); // 0x000000018787A714-0x000000018787A770
	public static AKRESULT SetState(uint in_stateGroup, uint in_state); // 0x0000000185AC0520-0x0000000185AC0580
	public static AKRESULT SetState(string in_pszStateGroup, string in_pszState); // 0x0000000187880EFC-0x0000000187880F58
	public static AKRESULT SetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues); // 0x000000018787E7F0-0x000000018787E860
	public static AKRESULT SetGameObjectOutputBusVolume(ulong in_emitterObjID, ulong in_listenerObjID, float in_fControlValue); // 0x000000018787E9C8-0x000000018787EA28
	public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID); // 0x000000018787E13C-0x000000018787E198
	public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID); // 0x000000018787E418-0x000000018787E474
	public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID); // 0x000000018787E474-0x000000018787E4D4
	public static AKRESULT SetOutputDeviceEffect(ulong in_outputDeviceID, uint in_uFXIndex, uint in_FXShareSetID); // 0x000000018787FF04-0x000000018787FF64
	public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID); // 0x000000018787F308-0x000000018787F360
	public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID); // 0x000000018787F360-0x000000018787F3B8
	public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig); // 0x000000018787E300-0x000000018787E364
	public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig); // 0x000000018787E29C-0x000000018787E300
	public static AKRESULT SetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel); // 0x000000018787FAC4-0x000000018787FB40
	public static AKRESULT SetMultipleObstructionAndOcclusion(ulong in_EmitterID, ulong in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction); // 0x000000018787F3B8-0x000000018787F44C
	public static AKRESULT StartOutputCapture(string in_CaptureFileName); // 0x00000001878811BC-0x0000000187881208
	public static AKRESULT StopOutputCapture(); // 0x000000018788165C-0x000000018788169C
	public static AKRESULT AddOutputCaptureMarker(string in_MarkerText); // 0x00000001878745BC-0x0000000187874608
	public static AKRESULT AddOutputCaptureBinaryMarker(IntPtr in_pMarkerData, uint in_uMarkerDataSize); // 0x0000000187874564-0x00000001878745BC
	public static uint GetSampleRate(); // 0x0000000187877858-0x0000000187877898
	public static AKRESULT StartProfilerCapture(string in_CaptureFileName); // 0x0000000187881248-0x0000000187881294
	public static AKRESULT StopProfilerCapture(); // 0x00000001878817D8-0x0000000187881818
	public static AKRESULT SetOfflineRenderingFrameTime(float in_fFrameTimeInSeconds); // 0x000000018787FE68-0x000000018787FEB8
	public static AKRESULT SetOfflineRendering(bool in_bEnableOfflineRendering); // 0x000000018787FEB8-0x000000018787FF04
	public static AKRESULT RemoveOutput(ulong in_idOutput); // 0x000000018787C3B0-0x000000018787C3FC
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, out ulong out_pOutputDeviceId); // 0x000000018787C544-0x000000018787C5B8
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId); // 0x000000018787C4E0-0x000000018787C544
	public static ulong GetOutputID(uint in_idShareset, uint in_idDevice); // 0x0000000187877174-0x00000001878771CC
	public static ulong GetOutputID(string in_szShareSet, uint in_idDevice); // 0x00000001878771CC-0x0000000187877224
	public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice); // 0x000000018787E3C0-0x000000018787E418
	public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName); // 0x000000018787E364-0x000000018787E3C0
	public static AKRESULT GetDeviceList(uint in_ulCompanyID, uint in_ulPluginID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions); // 0x0000000187876928-0x00000001878769B8
	public static AKRESULT GetDeviceList(uint in_audioDeviceShareSetID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions); // 0x00000001862E6DF0-0x00000001862E6E80
	public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume); // 0x000000018787FF64-0x000000018787FFC0
	public static AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice); // 0x00000001862E6CD0-0x00000001862E6D20
	public static AKRESULT Suspend(bool in_bRenderAnyway, bool in_bFadeOut); // 0x000000018788192C-0x0000000187881988
	public static AKRESULT Suspend(bool in_bRenderAnyway); // 0x00000001878818A0-0x00000001878818EC
	public static AKRESULT Suspend(); // 0x00000001878818EC-0x000000018788192C
	public static AKRESULT WakeupFromSuspend(uint in_uDelayMs); // 0x0000000187882114-0x000000018788215C
	public static AKRESULT WakeupFromSuspend(); // 0x000000018788215C-0x000000018788219C
	public static uint GetBufferTick(); // 0x0000000187876580-0x00000001878765C0
	public static ulong GetSampleTick(); // 0x0000000187877898-0x00000001878778D8
	public static void AkMemGetCategoryStats(int in_poolId, AkMemCategroyStats out_poolStats); // 0x000000018787480C-0x0000000187874870
	public static void AkMemGetGlobalStats(AkMemGlobalStats out_stats); // 0x0000000187874870-0x00000001878748C4
	public static void StartProfileThreadUsage(); // 0x0000000187881208-0x0000000187881248
	public static ulong StopProfileThreadUsage(); // 0x0000000187881798-0x00000001878817D8
	public static void DumpToFile(string pszFilename); // 0x0000000187874F8C-0x0000000187874FD8
	public static ulong GetGlobalUsed(); // 0x0000000187876CF0-0x0000000187876D30
	public static ulong GetGlobalReserved(); // 0x0000000187876CB0-0x0000000187876CF0
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate); // 0x00000001878773B4-0x0000000187877428
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo); // 0x0000000187877428-0x000000018787748C
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus); // 0x00000001878790E8-0x0000000187879160
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID); // 0x0000000187878F24-0x0000000187878F98
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID); // 0x0000000187878D80-0x0000000187878DF4
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID); // 0x0000000187879034-0x0000000187879090
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel); // 0x0000000187879090-0x00000001878790E8
	public static AKRESULT PostCodeVarArg(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, MsgContext msgContext); // 0x0000000187878D10-0x0000000187878D80
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus); // 0x000000018787A534-0x000000018787A5AC
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID); // 0x000000018787A328-0x000000018787A39C
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID); // 0x000000018787A604-0x000000018787A678
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID); // 0x000000018787A4D4-0x000000018787A534
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel); // 0x000000018787A5AC-0x000000018787A604
	public static AKRESULT ResetTranslator(); // 0x000000018787D230-0x000000018787D270
	public static int GetTimeStamp(); // 0x0000000187877EA4-0x0000000187877EE4
	public static void MonitorStreamMgrInit(AkStreamMgrSettings in_streamMgrSettings); // 0x0000000187878A84-0x0000000187878AD8
	public static void MonitorStreamingDeviceInit(uint in_deviceID, AkDeviceSettings in_deviceSettings); // 0x0000000187878B60-0x0000000187878BC4
	public static void MonitorStreamingDeviceDestroyed(uint in_deviceID); // 0x0000000187878B18-0x0000000187878B60
	public static void MonitorStreamMgrTerm(); // 0x0000000187878AD8-0x0000000187878B18
	public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties); // 0x00000001878747B8-0x000000018787480C
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence); // 0x000000018787D270-0x000000018787D2E4
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments); // 0x000000018787D2E4-0x000000018787D344
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue); // 0x0000000187876A14-0x0000000187876A70
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue); // 0x00000001878769B8-0x0000000187876A14
	public static AKRESULT GetPosition(ulong in_GameObjectID, AkWorldTransform out_rPosition); // 0x000000018787748C-0x00000001878774F0
	public static AKRESULT GetListenerPosition(ulong in_uListenerID, AkWorldTransform out_rPosition); // 0x0000000187876DE4-0x0000000187876E48
	public static AKRESULT GetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType); // 0x000000018787767C-0x00000001878776F0
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType); // 0x000000018787778C-0x0000000187877804
	public static AKRESULT GetSwitch(uint in_switchGroup, ulong in_gameObjectID, out uint out_rSwitchState); // 0x0000000187877CD8-0x0000000187877D38
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, ulong in_GameObj, out uint out_rSwitchState); // 0x0000000187877E44-0x0000000187877EA4
	public static AKRESULT GetState(uint in_stateGroup, out uint out_rState); // 0x0000000187877C80-0x0000000187877CD8
	public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState); // 0x0000000187877C24-0x0000000187877C80
	public static AKRESULT GetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues); // 0x0000000187876B04-0x0000000187876B74
	public static AKRESULT GetGameObjectDryLevelValue(ulong in_EmitterID, ulong in_ListenerID, out float out_rfControlValue); // 0x0000000187876B74-0x0000000187876BD4
	public static AKRESULT GetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel); // 0x0000000187876FD0-0x0000000187877048
	public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos); // 0x000000018787B9B8-0x000000018787BA34
	public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos); // 0x000000018787B93C-0x000000018787B9B8
	public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo); // 0x000000018787757C-0x00000001878775E0
	public static bool GetIsGameObjectActive(ulong in_GameObjId); // 0x0000000187876D98-0x0000000187876DE4
	public static float GetMaxRadius(ulong in_GameObjId); // 0x0000000187876F84-0x0000000187876FD0
	public static uint GetEventIDFromPlayingID(uint in_playingID); // 0x000000018679B640-0x000000018679B690
	public static ulong GetGameObjectFromPlayingID(uint in_playingID); // 0x0000000187876C68-0x0000000187876CB0
	public static AKRESULT GetPlayingIDsFromGameObject(ulong in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs); // 0x0000000187877354-0x00000001878773B4
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue); // 0x0000000187876680-0x00000001878766DC
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue); // 0x00000001878766DC-0x0000000187876738
	public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask); // 0x0000000187874338-0x0000000187874384
	public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask); // 0x0000000187874384-0x00000001878743D0
	public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask); // 0x00000001878742EC-0x0000000187874338
	public static byte ChannelMaskToNumChannels(uint in_uChannelMask); // 0x0000000187874B40-0x0000000187874B88
	public static uint ChannelMaskFromNumChannels(uint in_uNumChannels); // 0x0000000187874AF8-0x0000000187874B40
	public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask); // 0x0000000187874AA0-0x0000000187874AF8
	public static bool HasSurroundChannels(uint in_uChannelMask); // 0x000000018787813C-0x0000000187878184
	public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask); // 0x00000001878780F4-0x000000018787813C
	public static bool HasSideAndRearChannels(uint in_uChannelMask); // 0x00000001878780AC-0x00000001878780F4
	public static bool HasHeightChannels(uint in_uChannelMask); // 0x0000000187878064-0x00000001878780AC
	public static uint BackToSideChannels(uint in_uChannelMask); // 0x00000001878748C4-0x000000018787490C
	public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx); // 0x00000001878812D4-0x0000000187881330
	public static AKRESULT SetGameObjectRadius(ulong in_gameObjectID, float in_outerRadius, float in_innerRadius); // 0x000000018787EA28-0x000000018787EA8C
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID, ulong in_gameObjectID); // 0x000000018787EE0C-0x000000018787EE8C
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID); // 0x000000018787ED8C-0x000000018787EE0C
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name); // 0x000000018787ED18-0x000000018787ED8C
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, ulong in_gameObjectID); // 0x000000018787C274-0x000000018787C2D0
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID); // 0x000000018787C150-0x000000018787C1A8
	public static AKRESULT RemoveImageSource(uint in_srcID); // 0x000000018787C22C-0x000000018787C274
	public static AKRESULT ClearImageSources(uint in_AuxBusID, ulong in_gameObjectID); // 0x0000000187874C7C-0x0000000187874CD4
	public static AKRESULT ClearImageSources(uint in_AuxBusID); // 0x0000000187874CD4-0x0000000187874D1C
	public static AKRESULT ClearImageSources(); // 0x0000000187874D1C-0x0000000187874D5C
	public static AKRESULT RemoveGeometry(ulong in_SetID); // 0x00000001858F45A0-0x00000001858F45D0
	public static AKRESULT RemoveGeometryInstance(ulong in_GeometryInstanceID); // 0x00000001858F4970-0x00000001858F49C0
	public static AKRESULT RemoveRoom(ulong in_RoomID); // 0x00000001858F4A60-0x00000001858F4AB0
	public static AKRESULT RemovePortal(ulong in_PortalID); // 0x000000018787C3FC-0x000000018787C448
	public static AKRESULT SetReverbZone(ulong in_ReverbZone, ulong in_ParentRoom, float in_transitionRegionWidth); // 0x000000018566B820-0x000000018566B890
	public static AKRESULT RemoveReverbZone(ulong in_ReverbZone); // 0x000000018787C448-0x000000018787C494
	public static AKRESULT SetGameObjectInRoom(ulong in_gameObjectID, ulong in_CurrentRoomID); // 0x000000018787E860-0x000000018787E8BC
	public static AKRESULT UnsetGameObjectInRoom(ulong in_gameObjectID); // 0x0000000187882010-0x000000018788205C
	public static AKRESULT SetReflectionsOrder(uint in_uReflectionsOrder, bool in_bUpdatePaths); // 0x00000001862E6960-0x00000001862E69C0
	public static AKRESULT SetDiffractionOrder(uint in_uDiffractionOrder, bool in_bUpdatePaths); // 0x00000001862E68C0-0x00000001862E6920
	public static AKRESULT SetMaxEmitterRoomAuxSends(uint in_uMaxEmitterRoomAuxSends); // 0x000000018787F208-0x000000018787F250
	public static AKRESULT SetNumberOfPrimaryRays(uint in_uNbPrimaryRays); // 0x00000001862E6600-0x00000001862E6650
	public static AKRESULT SetLoadBalancingSpread(uint in_uNbFrames); // 0x00000001862E6570-0x00000001862E65C0
	public static AKRESULT SetEarlyReflectionsAuxSend(ulong in_gameObjectID, uint in_auxBusID); // 0x000000018787E530-0x000000018787E588
	public static AKRESULT SetEarlyReflectionsVolume(ulong in_gameObjectID, float in_fSendVolume); // 0x000000018787E5FC-0x000000018787E658
	public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion); // 0x0000000187880060-0x00000001878800C4
	public static AKRESULT SetGameObjectToPortalObstruction(ulong in_gameObjectID, ulong in_PortalID, float in_fObstruction); // 0x000000018787EA8C-0x000000018787EAEC
	public static AKRESULT SetPortalToPortalObstruction(ulong in_PortalID0, ulong in_PortalID1, float in_fObstruction); // 0x00000001878800C4-0x0000000187880124
	public static AKRESULT QueryWetDiffraction(ulong in_portal, out float out_wetDiffraction); // 0x000000018787BD24-0x000000018787BD80
	public static AKRESULT ResetStochasticEngine(); // 0x000000018787D1F0-0x000000018787D230
	public static uint GetDeviceIDFromName(string in_szToken); // 0x00000001878768DC-0x0000000187876928
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID, AkAudioDeviceState uDeviceStateMask); // 0x0000000187877FE0-0x0000000187878064
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID); // 0x0000000187877F6C-0x0000000187877FE0
	public static uint GetWindowsDeviceCount(AkAudioDeviceState uDeviceStateMask); // 0x0000000187877EE4-0x0000000187877F2C
	public static uint GetWindowsDeviceCount(); // 0x0000000187877F2C-0x0000000187877F6C
	public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger); // 0x0000000186E2D4C0-0x0000000186E2D510
	public static void SetErrorLogger(); // 0x000000018787E6D0-0x000000018787E710
	public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat); // 0x000000018787E198-0x000000018787E1F4
	public static AKRESULT Init(AkInitializationSettings settings); // 0x0000000186805C30-0x0000000186805C90
	public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings); // 0x00000001862E71F0-0x00000001862E7250
	public static AKRESULT InitCommunication(AkCommunicationSettings settings); // 0x00000001870E9BA0-0x00000001870E9C00
	public static void Term(); // 0x0000000187881988-0x00000001878819C8
	public static AKRESULT RegisterGameObjInternal(ulong in_GameObj); // 0x000000018787BDF8-0x000000018787BE44
	public static AKRESULT UnregisterGameObjInternal(ulong in_GameObj); // 0x00000001858F3650-0x00000001858F36A0
	public static AKRESULT RegisterGameObjInternal_WithName(ulong in_GameObj, string in_pszObjName); // 0x000000018587CC40-0x000000018587CC80
	public static AKRESULT SetBasePath(string in_pszBasePath); // 0x000000018787E250-0x000000018787E29C
	public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath); // 0x000000018668F850-0x000000018668F8A0
	public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID); // 0x0000000186691840-0x00000001866918A0
	public static AKRESULT AddBasePath(string in_pszBasePath); // 0x00000001862F9C00-0x00000001862F9C50
	public static AKRESULT SetGameName(string in_GameName); // 0x000000018787E710-0x000000018787E75C
	public static string GetCurrentLanguage(); // 0x0000000187876620-0x0000000187876680
	public static AKRESULT UnloadFilePackage(uint in_uPackageID); // 0x0000000186691CC0-0x0000000186691D10
	public static AKRESULT UnloadAllFilePackages(); // 0x00000001878819C8-0x0000000187881A08
	public static AKRESULT SetObjectPosition(ulong in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top); // 0x00000001857A1300-0x00000001857A13B0
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate); // 0x000000018787794C-0x00000001878779C4
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions); // 0x00000001878778D8-0x000000018787794C
	public static AKRESULT SetListeners(ulong in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners); // 0x000000018787F1A8-0x000000018787F208
	public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners); // 0x000000018611CEE0-0x000000018611CF40
	public static uint GetNumOutputDevices(uint in_AudioDeviceShareSetID); // 0x00000001862E6C40-0x00000001862E6C90
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners); // 0x0000000187874608-0x000000018787468C
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs); // 0x00000001878746E0-0x0000000187874754
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID); // 0x0000000187874754-0x00000001878747B8
	public static AKRESULT AddOutput(AkOutputSettings in_Settings); // 0x000000018787468C-0x00000001878746E0
	public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings); // 0x0000000187876888-0x00000001878768DC
	public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings); // 0x0000000187876738-0x000000018787678C
	public static void GetDefaultMusicSettings(AkMusicSettings out_settings); // 0x00000001878767E0-0x0000000187876834
	public static void GetDefaultInitSettings(AkInitSettings out_settings); // 0x000000018787678C-0x00000001878767E0
	public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings); // 0x0000000187876834-0x0000000187876888
	public static uint GetMajorMinorVersion(); // 0x0000000186144550-0x0000000186144590
	public static uint GetSubminorBuildVersion(); // 0x00000001861445C0-0x0000000186144650
	public static void StartResourceMonitoring(); // 0x0000000187881294-0x00000001878812D4
	public static void StopResourceMonitoring(); // 0x0000000187881818-0x0000000187881858
	public static void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary); // 0x0000000187877804-0x0000000187877858
	public static void StartDeviceCapture(ulong in_idOutputDeviceID); // 0x0000000187881170-0x00000001878811BC
	public static void StopDeviceCapture(ulong in_idOutputDeviceID); // 0x00000001878813D8-0x0000000187881424
	public static void ClearCaptureData(); // 0x0000000187874BC8-0x0000000187874C08
	public static uint UpdateCaptureSampleCount(ulong in_idOutputDeviceID); // 0x00000001878820C8-0x0000000187882114
	public static uint GetCaptureSamples(ulong in_idOutputDeviceID, float[] out_pSamples, uint in_uBufferSize); // 0x00000001878765C0-0x0000000187876620
	public static AKRESULT SetRoomPortal(ulong in_PortalID, ulong FrontRoom, ulong BackRoom, AkTransform Transform, AkExtent Extent, bool bEnabled, string in_pName); // 0x0000000187880D08-0x0000000187880DB0
	public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, ulong GeometryInstanceID, string in_pName); // 0x000000018566BBA0-0x000000018566BC30
	public static AKRESULT RegisterSpatialAudioListener(ulong in_gameObjectID); // 0x000000018611CE90-0x000000018611CEE0
	public static AKRESULT UnregisterSpatialAudioListener(ulong in_gameObjectID); // 0x0000000187881F5C-0x0000000187881FA8
	public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, Vector3[] Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges); // 0x000000018787EB9C-0x000000018787EC60
	public static AKRESULT SetGeometryInstance(ulong in_GeomInstanceID, AkTransform Transform, Vector3 Scale, ulong GeometrySetID, ulong RoomID, bool UseForReflectionAndDiffraction); // 0x000000018787EAEC-0x000000018787EB9C
	public static AKRESULT QueryReflectionPaths(ulong in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize); // 0x000000018787BBAC-0x000000018787BC54
	public static AKRESULT QueryDiffractionPaths(ulong in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize); // 0x000000018787BA34-0x000000018787BADC
	public static void PerformStreamMgrIO(); // 0x0000000187878C10-0x0000000187878C50
	public static void HgMemShrink(); // 0x0000000187878284-0x00000001878782C4
	public static ulong HgGetGlobalMemoryUsed(); // 0x000000018577BF10-0x000000018577BF60
	public static ulong HgGetGlobalMemoryReserved(); // 0x0000000186A82010-0x0000000186A82040
	public static ulong HgGetGlobalMemoryAllocated(); // 0x00000001878781C4-0x0000000187878204
	public static ulong HgGetGlobalMemoryActive(); // 0x0000000187878184-0x00000001878781C4
	public static ulong HgGetGlobalMemoryMapped(); // 0x0000000187878204-0x0000000187878244
	public static ulong HgGetGlobalMemoryRetained(); // 0x0000000187878244-0x0000000187878284
	public static void InitScePad(); // 0x00000001869794B0-0x00000001869794F0
	public static uint GetMMDeviceIdFromPadContainerInfo(int in_padHandle); // 0x0000000187876ED4-0x0000000187876F1C
	public static string StringFromIntPtrString(IntPtr ptr); // 0x0000000187881858-0x00000001878818A0
	public static string StringFromIntPtrWString(IntPtr ptr); // 0x00000001850C8E30-0x00000001850C8E80
	private static ulong InternalGameObjectHash(GameObject gameObject); // 0x00000001878782C4-0x000000018787832C
	public static ulong GetAkGameObjectID(GameObject gameObject); // 0x00000001878763C8-0x000000018787642C
	public static AKRESULT RegisterGameObj(GameObject gameObject); // 0x000000018787BEAC-0x000000018787BF14
	public static AKRESULT RegisterGameObj(GameObject gameObject, string name); // 0x000000018787BF14-0x000000018787BF8C
	public static AKRESULT UnregisterGameObj(GameObject gameObject); // 0x0000000187881EC0-0x0000000187881F5C
	public static void UnregisterAllGameObjects(); // 0x0000000187881E18-0x0000000187881E58
	public static AKRESULT SetObjectPosition(GameObject gameObject, Transform transform); // 0x000000018787FC18-0x000000018787FD24
	public static AKRESULT SetObjectPosition(GameObject gameObject, float posX, float posY, float posZ, float frontX, float frontY, float frontZ, float topX, float topY, float topZ); // 0x000000018787FD24-0x000000018787FE68
	public static void PreGameObjectAPICall(GameObject gameObject, ulong id); // 0x0000000186805BA0-0x0000000186805BB0
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType); // 0x00000001878754F0-0x00000001878755F0
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x0000000187875154-0x000000018787524C
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID); // 0x00000001878753FC-0x0000000187875488
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID); // 0x0000000187879790-0x00000001878798DC
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x0000000187879954-0x0000000187879A8C
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x0000000187879160-0x000000018787925C
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID); // 0x0000000187879658-0x00000001878796F4
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID); // 0x0000000187879384-0x00000001878794D0
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x0000000187879A8C-0x0000000187879BC4
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x0000000187879CA4-0x0000000187879DA4
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID); // 0x00000001878796F4-0x0000000187879790
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID); // 0x0000000187876150-0x00000001878761EC
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x0000000187875E64-0x0000000187875EFC
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration); // 0x0000000187875DCC-0x0000000187875E64
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID); // 0x0000000187875D48-0x0000000187875DCC
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID); // 0x00000001878760B4-0x0000000187876150
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001878761EC-0x0000000187876288
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration); // 0x0000000187875A28-0x0000000187875AC4
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID); // 0x0000000187875B80-0x0000000187875C04
	public static AKRESULT PostMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts); // 0x0000000187879FF8-0x000000018787A0A4
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID); // 0x00000001878814A8-0x000000018788151C
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_playingID); // 0x0000000187881424-0x00000001878814A8
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x000000018787DBE0-0x000000018787DC7C
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x000000018787D5F0-0x000000018787D68C
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition); // 0x000000018787DD04-0x000000018787DD88
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x000000018787D8B4-0x000000018787D950
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x000000018787D818-0x000000018787D8B4
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition); // 0x000000018787DC7C-0x000000018787DD04
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x000000018787D77C-0x000000018787D818
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x000000018787DDE8-0x000000018787DE84
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent); // 0x000000018787DA4C-0x000000018787DAD0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x000000018787D9B0-0x000000018787DA4C
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x000000018787DAD0-0x000000018787DB6C
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent); // 0x000000018787DEE4-0x000000018787DF6C
	public static void CancelEventCallbackGameObject(GameObject in_gameObjectID); // 0x00000001878749A4-0x0000000187874A0C
	public static void StopAll(GameObject in_gameObjectID); // 0x0000000187881330-0x0000000187881398
	public static AKRESULT SendPluginCustomGameData(uint in_busID, GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes); // 0x000000018787E0A0-0x000000018787E13C
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType); // 0x000000018787F860-0x000000018787F90C
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions); // 0x000000018787F71C-0x000000018787F7B4
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType); // 0x000000018787F7B4-0x000000018787F860
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions); // 0x000000018787F980-0x000000018787FA18
	public static AKRESULT SetScalingFactor(GameObject in_GameObjectID, float in_fAttenuationScalingFactor); // 0x0000000187880DB0-0x0000000187880E28
	public static AKRESULT AddListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj); // 0x00000001878744E0-0x0000000187874564
	public static AKRESULT RemoveListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj); // 0x000000018787C2D0-0x000000018787C354
	public static AKRESULT AddDefaultListener(GameObject in_listenerGameObj); // 0x00000001878743D0-0x0000000187874438
	public static AKRESULT RemoveDefaultListener(GameObject in_listenerGameObj); // 0x000000018787C0E8-0x000000018787C150
	public static AKRESULT ResetListenersToDefault(GameObject in_emitterGameObj); // 0x000000018787C5B8-0x000000018787C620
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets); // 0x000000018787F078-0x000000018787F120
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig); // 0x000000018787EFDC-0x000000018787F078
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x0000000187880BC8-0x0000000187880C64
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x0000000187880B2C-0x0000000187880BC8
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration); // 0x0000000187880818-0x00000001878808B4
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID); // 0x0000000187880794-0x0000000187880818
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018788043C-0x00000001878804DC
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001878808B4-0x0000000187880950
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration); // 0x00000001878809D8-0x0000000187880A74
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID); // 0x0000000187880950-0x00000001878809D8
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018787CB04-0x000000018787CBA0
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018787D0F8-0x000000018787D194
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration); // 0x000000018787CA08-0x000000018787CA8C
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID); // 0x000000018787CD78-0x000000018787CDEC
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x000000018787D010-0x000000018787D0AC
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x000000018787CF74-0x000000018787D010
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration); // 0x000000018787CBA0-0x000000018787CC28
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID); // 0x000000018787CA8C-0x000000018787CB04
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject in_gameObjectID); // 0x000000018788109C-0x0000000187881120
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, GameObject in_gameObjectID); // 0x0000000187880FB4-0x000000018788103C
	public static AKRESULT PostTrigger(uint in_triggerID, GameObject in_gameObjectID); // 0x000000018787A770-0x000000018787A7E4
	public static AKRESULT PostTrigger(string in_pszTrigger, GameObject in_gameObjectID); // 0x000000018787A7E4-0x000000018787A85C
	public static AKRESULT SetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues); // 0x000000018787E75C-0x000000018787E7F0
	public static AKRESULT SetGameObjectOutputBusVolume(GameObject in_emitterObjID, GameObject in_listenerObjID, float in_fControlValue); // 0x000000018787E934-0x000000018787E9C8
	public static AKRESULT SetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel); // 0x000000018787FA18-0x000000018787FAC4
	public static AKRESULT SetMultipleObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction); // 0x000000018787F44C-0x000000018787F510
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus); // 0x0000000187878F98-0x0000000187879034
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID); // 0x0000000187878DF4-0x0000000187878E8C
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID); // 0x0000000187878E8C-0x0000000187878F24
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus); // 0x000000018787A438-0x000000018787A4D4
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID); // 0x000000018787A678-0x000000018787A714
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID); // 0x000000018787A39C-0x000000018787A438
	public static AKRESULT GetPosition(GameObject in_GameObjectID, AkTransform out_rPosition); // 0x00000001878774F0-0x000000018787757C
	public static AKRESULT GetListenerPosition(GameObject in_uIndex, AkTransform out_rPosition); // 0x0000000187876E48-0x0000000187876ED4
	public static AKRESULT GetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType); // 0x00000001878776F0-0x000000018787778C
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType); // 0x00000001878775E0-0x000000018787767C
	public static AKRESULT GetSwitch(uint in_switchGroup, GameObject in_gameObjectID, out uint out_rSwitchState); // 0x0000000187877D38-0x0000000187877DBC
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, GameObject in_GameObj, out uint out_rSwitchState); // 0x0000000187877DBC-0x0000000187877E44
	public static AKRESULT GetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues); // 0x0000000187876A70-0x0000000187876B04
	public static AKRESULT GetGameObjectDryLevelValue(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfControlValue); // 0x0000000187876BD4-0x0000000187876C68
	public static AKRESULT GetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel); // 0x0000000187877048-0x00000001878770F0
	public static bool GetIsGameObjectActive(GameObject in_GameObjId); // 0x0000000187876D30-0x0000000187876D98
	public static float GetMaxRadius(GameObject in_GameObjId); // 0x0000000187876F1C-0x0000000187876F84
	public static AKRESULT GetPlayingIDsFromGameObject(GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs); // 0x00000001878772CC-0x0000000187877354
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_imageSourceName, uint in_AuxBusID, GameObject in_gameObjectID); // 0x000000018787EC60-0x000000018787ED18
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, GameObject in_gameObjectID); // 0x000000018787C1A8-0x000000018787C22C
	public static AKRESULT ClearImageSources(uint in_AuxBusID, GameObject in_gameObjectID); // 0x0000000187874C08-0x0000000187874C7C
	public static AKRESULT QueryReflectionPaths(GameObject in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize); // 0x000000018787BC54-0x000000018787BD24
	public static AKRESULT SetGameObjectInRoom(GameObject in_gameObjectID, ulong in_CurrentRoomID); // 0x000000018787E8BC-0x000000018787E934
	public static AKRESULT SetEarlyReflectionsAuxSend(GameObject in_gameObjectID, uint in_auxBusID); // 0x000000018787E588-0x000000018787E5FC
	public static AKRESULT SetEarlyReflectionsVolume(GameObject in_gameObjectID, float in_fSendVolume); // 0x000000018787E658-0x000000018787E6D0
	public static AKRESULT QueryDiffractionPaths(GameObject in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize); // 0x000000018787BADC-0x000000018787BBAC
	public static AKRESULT RegisterGameObjInternal(GameObject in_GameObj); // 0x000000018787BE44-0x000000018787BEAC
	public static AKRESULT UnregisterGameObjInternal(GameObject in_GameObj); // 0x0000000187881E58-0x0000000187881EC0
	public static AKRESULT RegisterGameObjInternal_WithName(GameObject in_GameObj, string in_pszObjName); // 0x000000018787BD80-0x000000018787BDF8
	public static AKRESULT SetObjectPosition(GameObject in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top); // 0x000000018787FB40-0x000000018787FC18
	public static AKRESULT SetListeners(GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners); // 0x000000018787F120-0x000000018787F1A8
	public static AKRESULT RegisterSpatialAudioListener(GameObject in_gameObjectID); // 0x000000018787C034-0x000000018787C09C
	public static AKRESULT UnregisterSpatialAudioListener(GameObject in_gameObjectID); // 0x0000000187881FA8-0x0000000187882010
	public static string StringFromIntPtrOSString(IntPtr ptr); // 0x00000001850C8DE0-0x00000001850C8E30
}

public class AkThreadProperties : IDisposable // TypeDefIndex: 83136
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int nPriority { get; set; } // 0x0000000187882C40-0x0000000187882C90 0x0000000187882D5C-0x0000000187882DB0
	public uint dwAffinityMask { get; set; } // 0x0000000187882BF0-0x0000000187882C40 0x0000000187882D08-0x0000000187882D5C
	public uint uStackSize { get; set; } // 0x0000000187882C90-0x0000000187882CE0 0x0000000187882DB0-0x0000000187882E04

	// Constructors
	internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0
	public AkThreadProperties(); // 0x0000000187882BA0-0x0000000187882BF0

	// Methods
	internal static IntPtr getCPtr(AkThreadProperties obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187882CE0-0x0000000187882D08
	~AkThreadProperties(); // 0x0000000187882B28-0x0000000187882BA0
	public void Dispose(); // 0x00000001878829C8-0x0000000187882A18
	protected virtual void Dispose(bool disposing); // 0x0000000187882A18-0x0000000187882B28
}

public class AkUnityPlatformSpecificSettings : IDisposable // TypeDefIndex: 83137
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkUnityPlatformSpecificSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000187232790-0x00000001872327A0

	// Methods
	internal static IntPtr getCPtr(AkUnityPlatformSpecificSettings obj); // 0x0000000187840F78-0x0000000187840F88
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000187882FD8-0x0000000187883000
	~AkUnityPlatformSpecificSettings(); // 0x0000000186D46760-0x0000000186D467B0
	public void Dispose(); // 0x0000000187882F88-0x0000000187882FD8
	protected virtual void Dispose(bool disposing); // 0x0000000186D467B0-0x0000000186D46940
}

public class AkAndroidSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 83140
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 83139
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
		public enum AudioAPI // TypeDefIndex: 83138
		{
			Default = -1,
			None = 0,
			AAudio = 1,
			OpenSL_ES = 2
		}

		// Constructors
		public PlatformAdvancedSettings(); // 0x0000000187200A30-0x0000000187200A80

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
	}

	// Constructors
	public AkAndroidSettings(); // 0x0000000185DEE9B0-0x0000000185DEEB10

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001829600D0-0x00000001829600E0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000182986470-0x0000000182986480
	protected override AkCommonCommSettings GetCommsSettings(); // 0x000000018226EEA0-0x000000018226EEB0
}

public static class AkAudioInputManager // TypeDefIndex: 83145
{
	// Fields
	private static bool initialized; // 0x00
	private static readonly Dictionary<uint, AudioSamplesDelegate> audioSamplesDelegates; // 0x08
	private static readonly Dictionary<uint, AudioFormatDelegate> audioFormatDelegates; // 0x10
	private static readonly AkAudioFormat audioFormat; // 0x18
	private static readonly AudioSamplesInteropDelegate audioSamplesDelegate; // 0x20
	private static readonly AudioFormatInteropDelegate audioFormatDelegate; // 0x28

	// Nested types
	public delegate void AudioFormatDelegate(uint playingID, AkAudioFormat format); // TypeDefIndex: 83141; 0x00000001859B7730-0x00000001859B7740

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void AudioFormatInteropDelegate(uint playingID, IntPtr format); // TypeDefIndex: 83142; 0x00000001859B7730-0x00000001859B7740

	public delegate bool AudioSamplesDelegate(uint playingID, uint channelIndex, float[] samples); // TypeDefIndex: 83143; 0x00000001811DF7F0-0x00000001811DF810

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate bool AudioSamplesInteropDelegate(uint playingID, [In, Out] float[] samples, uint channelIndex, uint frames); // TypeDefIndex: 83144; 0x00000001811CDB70-0x00000001811CDB90

	// Constructors
	static AkAudioInputManager(); // 0x0000000187871084-0x00000001878712B0

	// Methods
	public static uint PostAudioInputEvent(uint akEventID, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null); // 0x0000000187870DD0-0x0000000187870ED8
	public static uint PostAudioInputEvent(string akEventName, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null); // 0x0000000187870ED8-0x0000000187870FE0
	[AOT.MonoPInvokeCallback(typeof(AudioSamplesInteropDelegate))]
	private static bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames); // 0x0000000187870CE4-0x0000000187870DD0
	[AOT.MonoPInvokeCallback(typeof(AudioFormatInteropDelegate))]
	private static void InternalAudioFormatDelegate(uint playingID, IntPtr format); // 0x0000000187870BDC-0x0000000187870CE4
	private static void TryInitialize(); // 0x0000000187870FE0-0x0000000187871084
	private static void AddPlayingID(uint playingID, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate); // 0x0000000187870A14-0x0000000187870AEC
	private static void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo); // 0x0000000187870AEC-0x0000000187870BDC
}

public class AkBasePathGetter // TypeDefIndex: 83146
{
	// Fields
	public static readonly string DefaultBasePath; // 0x00
	[CompilerGenerated]
	private static bool _IsWwiseProjectAvailable_k__BackingField; // 0x08
	[CompilerGenerated]
	private string _SoundBankBasePath_k__BackingField; // 0x10
	[CompilerGenerated]
	private string _PersistentDataPath_k__BackingField; // 0x18
	[CompilerGenerated]
	private static string _WwiseProjectFullPath_k__BackingField; // 0x10
	private static AkBasePathGetter Instance; // 0x18

	// Properties
	public static bool IsWwiseProjectAvailable { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187871B94-0x0000000187871BE4 0x0000000187871C34-0x0000000187871C88
	public string SoundBankBasePath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	public string PersistentDataPath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	public static string WwiseProjectFullPath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187871BE4-0x0000000187871C34 0x0000000187871C88-0x0000000187871CE8

	// Constructors
	public AkBasePathGetter(); // 0x0000000186805BA0-0x0000000186805BB0
	static AkBasePathGetter(); // 0x0000000187170CB0-0x0000000187170D50

	// Methods
	public static string GetPlatformName(); // 0x00000001862E6F20-0x00000001862E6F50
	public static string GetPlatformBasePath(string platformName = "" /* Metadata: 0x02641E87 */); // 0x00000001878719D0-0x0000000187871AC4
	public static AkBasePathGetter Get(); // 0x0000000187871AC4-0x0000000187871B94
	public static void Reset(); // 0x00000001862FA760-0x00000001862FA7D0
	public void EvaluateGamePaths(); // 0x0000000187871834-0x00000001878719D0
}

public static class AkCallbackManager // TypeDefIndex: 83155
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
	public static int bnkCallbackCount { get; } // 0x0000000187872C44-0x0000000187872CA4 
	public static int evtCallbackCount { get; } // 0x0000000187872CA4-0x0000000187872D04 

	// Nested types
	public delegate void EventCallback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info); // TypeDefIndex: 83147; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void MonitoringCallback(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg); // TypeDefIndex: 83148; 0x00000001812083C0-0x00000001812083E0

	public delegate void BankCallback(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie); // TypeDefIndex: 83149; 0x00000001811CDB70-0x00000001811CDB90

	public class EventCallbackPackage // TypeDefIndex: 83150
	{
		// Fields
		public EventCallback callback; // 0x10
		public object cookie; // 0x18
		public uint playingID; // 0x20

		// Constructors
		public EventCallbackPackage(); // 0x0000000186805BA0-0x0000000186805BB0

		// Methods
		internal static void Recycle(EventCallbackPackage inPkg); // 0x000000018577F5D0-0x000000018577F6D0
		public static EventCallbackPackage Create(EventCallback inCb, object inCookie, ref uint ioFlags); // 0x000000018598ADA0-0x000000018598AF30
	}

	public class BankCallbackPackage // TypeDefIndex: 83151
	{
		// Fields
		public BankCallback callback; // 0x10
		public object cookie; // 0x18

		// Constructors
		public BankCallbackPackage(); // 0x0000000186805BA0-0x0000000186805BB0

		// Methods
		public static BankCallbackPackage Create(BankCallback inCb, object inCookie); // 0x00000001861190D0-0x0000000186119220
		public static void Recycle(BankCallbackPackage pkg); // 0x000000018577E000-0x000000018577E080
	}

	private class SimplePool<T> // TypeDefIndex: 83152
		where T : new()
	{
		// Fields
		private readonly T[] m_pool;
		private readonly int m_poolSize;
		private int m_poolIndex;

		// Constructors
		public SimplePool(int poolSize);

		// Methods
		public T Alloc();
		public void Recycle(T obj);
	}

	public delegate AKRESULT BGMCallback(bool in_bOtherAudioPlaying, object in_Cookie); // TypeDefIndex: 83153; 0x00000001859B7730-0x00000001859B7740

	public class BGMCallbackPackage // TypeDefIndex: 83154
	{
		// Fields
		public BGMCallback m_Callback; // 0x10
		public object m_Cookie; // 0x18

		// Constructors
		public BGMCallbackPackage(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	// Constructors
	static AkCallbackManager(); // 0x0000000186123CA0-0x00000001861241F0

	// Methods
	public static void CancelAllCallbacks(); // 0x0000000187871D38-0x00000001878720AC
	public static void RemoveEventCallback(uint in_playingID); // 0x0000000187872900-0x0000000187872B84
	public static void RemoveEventCallbackCookie(object in_cookie); // 0x00000001878724D8-0x0000000187872900
	public static void RemoveBankCallback(object in_cookie); // 0x00000001878720FC-0x00000001878724D8
	public static void SetLastAddedPlayingID(uint in_playingID); // 0x000000018598AF90-0x000000018598B110
	public static void Init(); // 0x0000000186805A40-0x0000000186805A90
	public static void Term(); // 0x0000000187872C3C-0x0000000187872C44
	public static void SetMonitoringCallback(AkMonitorErrorLevel in_Level, MonitoringCallback in_CB); // 0x00000001862FAA40-0x00000001862FAAB0
	private static void SetLocalOutput(AkMonitorErrorLevel in_Level); // 0x0000000186805BA0-0x0000000186805BB0
	public static void SetBGMCallback(BGMCallback in_CB, object in_cookie); // 0x0000000187872B84-0x0000000187872C3C
	public static void PostCallbacksNoInvoke(); // 0x00000001878720AC-0x00000001878720FC
	public static int PostCallbacks(); // 0x000000018577E1E0-0x000000018577ECF0
	private static void _ProcessBankCallback(IntPtr pPackage, IntPtr pData); // 0x000000018577DB60-0x000000018577DE50
	private static AkCallbackInfo _ProcessEventCallback(AkCallbackType eType, IntPtr pData); // 0x000000018577F540-0x000000018577F5D0
}

public class AkBasePlatformSettings : ScriptableObject // TypeDefIndex: 83156
{
	// Properties
	public virtual AkInitializationSettings AkInitializationSettings { get; } // 0x0000000186806C90-0x0000000186806CE0 
	public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; } // 0x00000001868061A0-0x0000000186806200 
	public virtual string SoundBankPersistentDataPath { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	public virtual string SoundbankPath { get; } // 0x0000000187871CE8-0x0000000187871D38 
	public virtual AkCommunicationSettings AkCommunicationSettings { get; } // 0x0000000186ABB2B0-0x0000000186ABB300 
	public virtual uint MemoryAllocationSizeLimit { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	public virtual uint MemoryDebugLevel { get; } // 0x0000000185829EC0-0x0000000185829ED0 

	// Constructors
	public AkBasePlatformSettings(); // 0x0000000185DD6260-0x0000000185DD6270
}

[Serializable]
public class AkCommonOutputSettings // TypeDefIndex: 83161
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
	public enum PanningRule // TypeDefIndex: 83157
	{
		Speakers = 0,
		Headphones = 1
	}

	[Serializable]
	public class ChannelConfiguration // TypeDefIndex: 83160
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
		public enum ChannelConfigType // TypeDefIndex: 83158
		{
			Anonymous = 0,
			Standard = 1,
			Ambisonic = 2
		}

		public enum ChannelMask // TypeDefIndex: 83159
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
		public ChannelConfiguration(); // 0x0000000186805BA0-0x0000000186805BB0

		// Methods
		public void CopyTo(AkChannelConfig config); // 0x00000001850C9630-0x00000001850C9670
	}

	// Constructors
	public AkCommonOutputSettings(); // 0x0000000185DEE500-0x0000000185DEE580

	// Methods
	public void CopyTo(AkOutputSettings settings); // 0x00000001850C94C0-0x00000001850C9560
}

[Serializable]
public class AkCommonUserSettings // TypeDefIndex: 83163
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
	public class SpatialAudioSettings // TypeDefIndex: 83162
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
		public SpatialAudioSettings(); // 0x0000000186F94AB0-0x0000000186F94B00
	}

	// Constructors
	public AkCommonUserSettings(); // 0x0000000185DEE470-0x0000000185DEE500

	// Methods
	protected static string GetPluginPath(); // 0x00000001850C8F50-0x00000001850C90F0
	public virtual void CopyTo(AkInitSettings settings); // 0x00000001850C8BE0-0x00000001850C8D20
	public void CopyTo(AkMusicSettings settings); // 0x0000000186805B70-0x0000000186805BA0
	public void CopyTo(AkStreamMgrSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
	public virtual void CopyTo(AkDeviceSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
	private void SetSampleRate(AkPlatformInitSettings settings); // 0x0000000186805B40-0x0000000186805B70
	public virtual void CopyTo(AkPlatformInitSettings settings); // 0x0000000186805B00-0x0000000186805B40
	public virtual void CopyTo(AkSpatialAudioInitSettings settings); // 0x0000000186806290-0x0000000186806400
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
	public virtual void Validate(); // 0x00000001878731AC-0x000000018787320C
}

[Serializable]
public class AkCommonAdvancedSettings // TypeDefIndex: 83165
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
	public enum MemSpanCount // TypeDefIndex: 83164
	{
		Small = 0,
		Medium = 1,
		Huge = 2
	}

	// Constructors
	public AkCommonAdvancedSettings(); // 0x00000001872327C0-0x0000000187232800

	// Methods
	public virtual void CopyTo(AkDeviceSettings settings); // 0x0000000186805920-0x0000000186805980
	public virtual void CopyTo(AkInitSettings settings); // 0x0000000186804E30-0x0000000186804EB0
	public virtual void CopyTo(AkPlatformInitSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
}

[Serializable]
public class AkCommonCommSettings // TypeDefIndex: 83166
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
	public AkCommonCommSettings(); // 0x0000000185DEE400-0x0000000185DEE470
	static AkCommonCommSettings(); // 0x000000018721CCA0-0x000000018721CCE0

	// Methods
	public virtual void CopyTo(AkCommunicationSettings settings); // 0x0000000186ABB380-0x0000000186ABB420
	public virtual void Validate(); // 0x0000000186805BA0-0x0000000186805BB0
}

public abstract class AkCommonPlatformSettings : AkBasePlatformSettings // TypeDefIndex: 83167
{
	// Properties
	public override AkInitializationSettings AkInitializationSettings { get; } // 0x0000000186805C90-0x0000000186805E10 
	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; } // 0x0000000186806150-0x00000001868061A0 
	public override string SoundBankPersistentDataPath { get; } // 0x000000018787316C-0x000000018787318C 
	public override string SoundbankPath { get; } // 0x000000018787318C-0x00000001878731AC 
	public override uint MemoryAllocationSizeLimit { get; } // 0x000000018787312C-0x000000018787314C 
	public override uint MemoryDebugLevel { get; } // 0x000000018787314C-0x000000018787316C 
	public override AkCommunicationSettings AkCommunicationSettings { get; } // 0x0000000186ABB250-0x0000000186ABB2B0 

	// Constructors
	protected AkCommonPlatformSettings(); // 0x0000000185DD6260-0x0000000185DD6270

	// Methods
	protected abstract AkCommonUserSettings GetUserSettings();
	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();
	protected abstract AkCommonCommSettings GetCommsSettings();
}

[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class AkEnumFlagAttribute : PropertyAttribute // TypeDefIndex: 83168
{
	// Fields
	public System.Type Type; // 0x10

	// Constructors
	public AkEnumFlagAttribute(System.Type type); // 0x0000000184FD2410-0x0000000184FD2420
}

public class AkLogger // TypeDefIndex: 83170
{
	// Fields
	private static AkLogger ms_Instance; // 0x00
	private ErrorLoggerInteropDelegate errorLoggerDelegate; // 0x10

	// Properties
	public static AkLogger Instance { get; } // 0x0000000187873870-0x00000001878738C0 

	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void ErrorLoggerInteropDelegate(string message); // TypeDefIndex: 83169; 0x0000000185B78EA0-0x0000000185B78EB0

	// Constructors
	private AkLogger(); // 0x0000000186E2D3A0-0x0000000186E2D4C0
	static AkLogger(); // 0x0000000186E2D330-0x0000000186E2D3A0

	// Methods
	~AkLogger(); // 0x00000001878734F8-0x0000000187873690
	public void Init(); // 0x0000000186805BA0-0x0000000186805BB0
	[AOT.MonoPInvokeCallback(typeof(ErrorLoggerInteropDelegate))]
	public static void WwiseInternalLogError(string message); // 0x00000001878737D0-0x0000000187873870
	public static void Message(string message); // 0x0000000187873690-0x0000000187873730
	public static void Warning(string message); // 0x0000000187873730-0x00000001878737D0
	public static void Error(string message); // 0x0000000187873458-0x00000001878734F8
}

public static class AkSoundEngineInitialization // TypeDefIndex: 83173
{
	// Fields
	public static InitializationDelegate s_initializationDelegate; // 0x00
	public static TerminationDelegate s_terminationDelegate; // 0x08

	// Nested types
	public delegate void InitializationDelegate(); // TypeDefIndex: 83171; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void TerminationDelegate(); // TypeDefIndex: 83172; 0x0000000185B44B70-0x0000000185B44B80

	// Methods
	public static bool InitializeSoundEngine(); // 0x0000000186806E80-0x0000000186808F20
	private static void _TryInitSpatialAudio(ref AkBasePlatformSettings activePlatformSettings); // 0x00000001862E5B50-0x00000001862E5BE0
	private static void _TryInitCommunication(ref AkBasePlatformSettings activePlatformSettings); // 0x0000000186805BA0-0x0000000186805BB0
	public static void TerminateSoundEngine(bool hgDeepTerm = false /* Metadata: 0x02641F38 */); // 0x0000000187874188-0x000000018787428C
	private static void _WaitCallbacks(int retry); // 0x000000018787428C-0x00000001878742EC
}

public class AkUtilities // TypeDefIndex: 83175
{
	// Nested types
	public class ShortIDGenerator // TypeDefIndex: 83174
	{
		// Fields
		private const uint s_prime32 = 16777619; // Metadata: 0x02641F39
		private const uint s_offsetBasis32 = 2166136261; // Metadata: 0x02641F3D
		private static byte s_hashSize; // 0x00
		private static uint s_mask; // 0x04

		// Properties
		public static byte HashSize { get; set; } // 0x00000001878844D4-0x0000000187884524 0x0000000187884524-0x0000000187884588

		// Constructors
		static ShortIDGenerator(); // 0x00000001878844C8-0x00000001878844D4
		public ShortIDGenerator(); // 0x0000000186805BA0-0x0000000186805BB0

		// Methods
		public static uint Compute(string in_name); // 0x00000001878843D0-0x00000001878844C8
	}

	// Constructors
	public AkUtilities(); // 0x0000000186805BA0-0x0000000186805BB0

	// Methods
	public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash); // 0x0000000187883070-0x000000018788319C
	public static void FixSlashes(ref string path); // 0x0000000187883000-0x0000000187883070
	public static string GetPathInPackage(string relativePath); // 0x000000018788319C-0x000000018788347C
}

public struct AkVector64 // TypeDefIndex: 83176
{
	// Fields
	public double X; // 0x00
	public double Y; // 0x08
	public double Z; // 0x10

	// Methods
	public void Zero(); // 0x0000000187232800-0x0000000187232810
	public static implicit operator AkVector64(Vector3 vector); // 0x0000000185B1AE20-0x0000000185B1AE50
}

public class AkWwiseInitializationSettings : AkCommonPlatformSettings // TypeDefIndex: 83179
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
	public bool IsValid { get; } // 0x00000001862E7290-0x00000001862E72F0 
	public int Count { get; } // 0x00000001862E70B0-0x00000001862E70F0 
	public static AkWwiseInitializationSettings Instance { get; set; } // 0x00000001862E70F0-0x00000001862E71F0 0x0000000186143C20-0x0000000186143FE0
	public static AkBasePlatformSettings ActivePlatformSettings { get; } // 0x00000001862E63F0-0x00000001862E6570 

	// Nested types
	public abstract class PlatformSettings : AkCommonPlatformSettings // TypeDefIndex: 83177
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
		public HashSet<string> GlobalPropertyHashSet { get; set; } // 0x000000018788433C-0x00000001878843D0 0x0000000185CA30F0-0x0000000185CA3100

		// Constructors
		protected PlatformSettings(); // 0x0000000185DEE300-0x0000000185DEE400

		// Methods
		public void IgnorePropertyValue(string propertyPath); // 0x0000000185DEEB10-0x0000000185DEEB90
		public bool IsPropertyIgnored(string propertyPath); // 0x0000000185DEEB90-0x0000000185DEEBF0
		public void SetUseGlobalPropertyValue(string propertyPath, bool use); // 0x0000000185DF0540-0x0000000185DF05E0
		public void SetGlobalPropertyValues(IEnumerable enumerable); // 0x0000000185DF1490-0x0000000185DF1620
		private bool IsUsingGlobalPropertyValue(string propertyPath); // 0x0000000185DF1620-0x0000000185DF1650
	}

	public class CommonPlatformSettings : PlatformSettings // TypeDefIndex: 83178
	{
		// Fields
		public AkCommonUserSettings UserSettings; // 0x30
		public AkCommonAdvancedSettings AdvancedSettings; // 0x38
		public AkCommonCommSettings CommsSettings; // 0x40

		// Constructors
		public CommonPlatformSettings(); // 0x0000000185DEE110-0x0000000185DEE120

		// Methods
		protected override AkCommonUserSettings GetUserSettings(); // 0x00000001829600D0-0x00000001829600E0
		protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000182986470-0x0000000182986480
		protected override AkCommonCommSettings GetCommsSettings(); // 0x000000018226EEA0-0x000000018226EEB0
	}

	// Constructors
	public AkWwiseInitializationSettings(); // 0x0000000185DEE120-0x0000000185DEE300
	static AkWwiseInitializationSettings(); // 0x0000000186B2F240-0x0000000186B2F990

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001829600D0-0x00000001829600E0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000182986470-0x0000000182986480
	protected override AkCommonCommSettings GetCommsSettings(); // 0x000000018226EEA0-0x000000018226EEB0
	private static AkBasePlatformSettings GetPlatformSettings(string platformName); // 0x00000001862E6F50-0x00000001862E70B0
	private void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
}

public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface> // TypeDefIndex: 83180
{
	// Properties
	protected override int StructureSize { get; } // 0x00000001878709D4-0x0000000187870A14 

	// Constructors
	public AkAcousticSurfaceArray(int count); // 0x000000018787098C-0x00000001878709D4

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x0000000187870940-0x000000018787098C
	protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001878708F4-0x0000000187870940
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other); // 0x0000000187870890-0x00000001878708F4
}

public class AkAuxSendArray : IDisposable // TypeDefIndex: 83181
{
	// Fields
	private const int MAX_COUNT = 4; // Metadata: 0x02641F42
	private readonly int SIZE_OF_AKAUXSENDVALUE; // 0x10
	private IntPtr m_Buffer; // 0x18
	private int m_Count; // 0x20

	// Properties
	public AkAuxSendValue this[int index] { get => default; } // 0x000000018787176C-0x0000000187871820 
	public bool isFull { get; } // 0x0000000187871820-0x0000000187871834 

	// Constructors
	public AkAuxSendArray(); // 0x00000001878716EC-0x000000018787176C

	// Methods
	public void Dispose(); // 0x000000018787152C-0x0000000187871590
	~AkAuxSendArray(); // 0x0000000187871590-0x0000000187871604
	public void Reset(); // 0x00000001872327A0-0x00000001872327B0
	public bool Add(ulong in_listenerGameObj, uint in_AuxBusID, float in_fValue); // 0x00000001878712B0-0x0000000187871358
	public bool Add(uint in_AuxBusID, float in_fValue); // 0x0000000187871358-0x00000001878713F4
	public bool Contains(ulong in_listenerGameObj, uint in_AuxBusID); // 0x00000001878713F4-0x0000000187871498
	public bool Contains(uint in_AuxBusID); // 0x0000000187871498-0x000000018787152C
	public AKRESULT SetValues(ulong gameObject); // 0x0000000187871678-0x00000001878716DC
	public AKRESULT GetValues(ulong gameObject); // 0x0000000187871604-0x0000000187871678
	public IntPtr GetBuffer(); // 0x0000000182234E30-0x0000000182234E40
	public int Count(); // 0x000000018226A850-0x000000018226A860
	private IntPtr _GetObjectPtr(int index); // 0x00000001878716DC-0x00000001878716EC
}

public abstract class AkBaseArray<T> : IDisposable // TypeDefIndex: 83182
{
	// Fields
	[CompilerGenerated]
	private int _Capacity_k__BackingField;
	private IntPtr m_Buffer;

	// Properties
	public int Capacity { [CompilerGenerated] get; [CompilerGenerated] private set; }
	protected abstract int StructureSize { get; }
	public T this[int index] { get => default; set {} }

	// Constructors
	public AkBaseArray(int capacity);

	// Methods
	public void Dispose();
	~AkBaseArray();
	public virtual int Count();
	protected virtual void DefaultConstructAtIntPtr(IntPtr address);
	protected virtual void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address);
	protected abstract T CreateNewReferenceFromIntPtr(IntPtr address);
	protected abstract void CloneIntoReferenceFromIntPtr(IntPtr address, T other);
	public IntPtr GetBuffer();
	protected IntPtr GetObjectPtr(int index);
}

public class AkChannelEmitterArray : IDisposable // TypeDefIndex: 83183
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20
	[CompilerGenerated]
	private uint _Count_k__BackingField; // 0x24

	// Properties
	public uint Count { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0

	// Constructors
	public AkChannelEmitterArray(uint in_Count); // 0x00000001878730CC-0x000000018787312C

	// Methods
	public void Dispose(); // 0x0000000187872FF4-0x0000000187873058
	~AkChannelEmitterArray(); // 0x0000000187873058-0x00000001878730CC
	public void Reset(); // 0x00000001872327B0-0x00000001872327C0
	public void Add(AkVector64 in_Pos, Vector3 in_Forward, Vector3 in_Top, uint in_ChannelMask); // 0x0000000187872D04-0x0000000187872FF4
}

public class AkDeviceDescriptionArray : AkBaseArray<AkDeviceDescription> // TypeDefIndex: 83184
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000186BB7D00-0x0000000186BB7D30 

	// Constructors
	public AkDeviceDescriptionArray(int count); // 0x00000001862E6ED0-0x00000001862E6F20

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x0000000186C5A0C0-0x0000000186C5A110
	protected override AkDeviceDescription CreateNewReferenceFromIntPtr(IntPtr address); // 0x0000000186EBF510-0x0000000186EBF560
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDeviceDescription other); // 0x000000018787320C-0x0000000187873270
}

public class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo> // TypeDefIndex: 83185
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000187873368-0x00000001878733A8 

	// Constructors
	public AkDiffractionPathInfoArray(int count); // 0x0000000187873320-0x0000000187873368

	// Methods
	protected override AkDiffractionPathInfo CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001878732D4-0x0000000187873320
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDiffractionPathInfo other); // 0x0000000187873270-0x00000001878732D4
}

public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo> // TypeDefIndex: 83186
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000186903FA0-0x0000000186903FD0 

	// Constructors
	public AkExternalSourceInfoArray(int count); // 0x00000001865E9390-0x00000001865E93E0

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x00000001870C0270-0x00000001870C02C0
	protected override void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address); // 0x000000018787340C-0x0000000187873458
	protected override AkExternalSourceInfo CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001869102D0-0x0000000186910300
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other); // 0x00000001878733A8-0x000000018787340C
}

public class AkMIDIPostArray // TypeDefIndex: 83187
{
	// Fields
	private readonly int m_Count; // 0x10
	private readonly int SIZE_OF; // 0x14
	private IntPtr m_Buffer; // 0x18

	// Properties
	public AkMIDIPost this[int index] { get => default; set {} } // 0x0000000187873BA8-0x0000000187873C74 0x0000000187873C74-0x0000000187873D48

	// Constructors
	public AkMIDIPostArray(int size); // 0x0000000187873B1C-0x0000000187873BA8

	// Methods
	~AkMIDIPostArray(); // 0x00000001878738C0-0x0000000187873974
	public void PostOnEvent(uint in_eventID, GameObject gameObject); // 0x0000000187873984-0x0000000187873A24
	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count); // 0x0000000187873A24-0x0000000187873B1C
	public IntPtr GetBuffer(); // 0x0000000182234E30-0x0000000182234E40
	public int Count(); // 0x00000001828BC2B0-0x00000001828BC2C0
	private IntPtr GetObjectPtr(int index); // 0x0000000187873974-0x0000000187873984
}

public class AkObjectInfoArray : AkBaseArray<AkObjectInfo> // TypeDefIndex: 83188
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000187873E8C-0x0000000187873ECC 

	// Constructors
	public AkObjectInfoArray(int count); // 0x0000000187873E44-0x0000000187873E8C

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x0000000187873DF8-0x0000000187873E44
	protected override AkObjectInfo CreateNewReferenceFromIntPtr(IntPtr address); // 0x0000000187873DAC-0x0000000187873DF8
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObjectInfo other); // 0x0000000187873D48-0x0000000187873DAC
}

public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues> // TypeDefIndex: 83189
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000187874010-0x0000000187874050 

	// Constructors
	public AkObstructionOcclusionValuesArray(int count); // 0x0000000187873FC8-0x0000000187874010

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x0000000187873F7C-0x0000000187873FC8
	protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address); // 0x0000000187873F30-0x0000000187873F7C
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other); // 0x0000000187873ECC-0x0000000187873F30
}

public class AkPositionArray : IDisposable // TypeDefIndex: 83190
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20
	[CompilerGenerated]
	private uint _Count_k__BackingField; // 0x24

	// Properties
	public uint Count { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0

	// Constructors
	public AkPositionArray(uint in_Count); // 0x0000000185A1B0A0-0x0000000185A1B110

	// Methods
	public void Dispose(); // 0x0000000185A1D310-0x0000000185A1D380
	~AkPositionArray(); // 0x0000000185A1D280-0x0000000185A1D2C0
	public void Reset(); // 0x00000001872327B0-0x00000001872327C0
	public void Add(AkVector64 in_Pos, Vector3 in_Forward, Vector3 in_Top); // 0x0000000185A1AC40-0x0000000185A1ACB0
}

public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo> // TypeDefIndex: 83191
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000187874148-0x0000000187874188 

	// Constructors
	public AkReflectionPathInfoArray(int count); // 0x0000000187874100-0x0000000187874148

	// Methods
	protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001878740B4-0x0000000187874100
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other); // 0x0000000187874050-0x00000001878740B4
}

public class AkSourceSettingsArray : AkBaseArray<AkSourceSettings> // TypeDefIndex: 83192
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000187882988-0x00000001878829C8 

	// Constructors
	public AkSourceSettingsArray(int count); // 0x0000000187882940-0x0000000187882988

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x00000001878828F4-0x0000000187882940
	protected override AkSourceSettings CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001878828A8-0x00000001878828F4
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkSourceSettings other); // 0x0000000187882844-0x00000001878828A8
}

public class AkTriangleArray : AkBaseArray<AkTriangle> // TypeDefIndex: 83193
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000187882F48-0x0000000187882F88 

	// Constructors
	public AkTriangleArray(int count); // 0x0000000187882F00-0x0000000187882F48

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x0000000187882EB4-0x0000000187882F00
	protected override AkTriangle CreateNewReferenceFromIntPtr(IntPtr address); // 0x0000000187882E68-0x0000000187882EB4
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkTriangle other); // 0x0000000187882E04-0x0000000187882E68
}

public static class AudioNativeHelper // TypeDefIndex: 83196
{
	// Fields
	private static IntPtr s_reusedTransformPtr; // 0x00

	// Nested types
	public struct AudioTriangleArrayNoGc : IDisposable // TypeDefIndex: 83194
	{
		// Fields
		private IntPtr m_buffer; // 0x00
		private int m_capacity; // 0x08
		private int m_elementSize; // 0x0C

		// Properties
		internal IntPtr Buffer { get; } // 0x0000000184431970-0x0000000184431980 

		// Constructors
		public AudioTriangleArrayNoGc(int capacity); // 0x0000000185A1C7E0-0x0000000185A1C8D0

		// Methods
		public void Set(int idx, ushort p0, ushort p1, ushort p2, ushort surface); // 0x0000000185A1CDB0-0x0000000185A1CEB0
		public void Dispose(); // 0x0000000185A1D230-0x0000000185A1D280
	}

	public struct AudioAcousticSurfaceArrayNoGc : IDisposable // TypeDefIndex: 83195
	{
		// Fields
		private IntPtr m_buffer; // 0x00
		private int m_capacity; // 0x08
		private int m_elementSize; // 0x0C

		// Properties
		internal IntPtr Buffer { get; } // 0x0000000184431970-0x0000000184431980 

		// Constructors
		public AudioAcousticSurfaceArrayNoGc(int capacity); // 0x0000000185A1C6E0-0x0000000185A1C7A0

		// Methods
		public void Set(int idx, float transmissionLoss, uint textureId); // 0x0000000185A1CFE0-0x0000000185A1D050
		public void Dispose(); // 0x0000000185A1D230-0x0000000185A1D280
	}

	// Constructors
	static AudioNativeHelper(); // 0x0000000187220B70-0x0000000187220BB0

	// Methods
	internal static void Init(); // 0x0000000187104840-0x00000001871048C0
	internal static void Term(); // 0x000000018788399C-0x0000000187883A04
	public static AKRESULT SetRoomPortal(ulong portalID, ulong frontRoom, ulong backRoom, Vector3 position, Vector3 orientationFront, Vector3 orientationTop, Vector3 extent, bool enabled, string portalName = "" /* Metadata: 0x02641F43 */); // 0x0000000187883818-0x000000018788399C
	public static AKRESULT SetGeometry(ulong geoId, AudioTriangleArrayNoGc triangles, uint numTriangles, Vector3[] vertices, uint numVertices, AudioAcousticSurfaceArrayNoGc surfaces, uint numSurfaces, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges); // 0x0000000185A1D0F0-0x0000000185A1D1A0
	public static AKRESULT SetGeometryInstance(ulong geomInstanceID, Vector3 pos, Quaternion rot, Vector3 scale, ulong geometrySetID, ulong roomID, bool useForReflectionAndDiffraction); // 0x000000018566C570-0x000000018566C780
}

public class AkiOSSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 83201
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 83200
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
		public enum Category // TypeDefIndex: 83197
		{
			Ambient = 0,
			SoloAmbient = 1,
			PlayAndRecord = 2,
			Playback = 3
		}

		public enum CategoryOptions // TypeDefIndex: 83198
		{
			MixWithOthers = 1,
			DuckOthers = 2,
			AllowBluetooth = 4,
			DefaultToSpeaker = 8
		}

		public enum Mode // TypeDefIndex: 83199
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
		public PlatformAdvancedSettings(); // 0x00000001872009E0-0x0000000187200A30

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
	}

	// Constructors
	public AkiOSSettings(); // 0x0000000185DEEBF0-0x0000000185DEED80

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001829600D0-0x00000001829600E0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000182986470-0x0000000182986480
	protected override AkCommonCommSettings GetCommsSettings(); // 0x000000018226EEA0-0x000000018226EEB0
}

public class AkMacSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 83203
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 83202
	{
		// Fields
		[Tooltip("Number of Apple Spatial Audio point sources to allocate for 3D audio use (each point source is a system audio object).")]
		public uint NumSpatialAudioPointSources; // 0x50
		[Tooltip("Print debug information related to audio device initialization in the system log.")]
		public bool VerboseSystemOutput; // 0x54

		// Constructors
		public PlatformAdvancedSettings(); // 0x0000000187232810-0x0000000187232850

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
	}

	// Constructors
	public AkMacSettings(); // 0x0000000185DEE110-0x0000000185DEE120

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001829600D0-0x00000001829600E0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000182986470-0x0000000182986480
	protected override AkCommonCommSettings GetCommsSettings(); // 0x000000018226EEA0-0x000000018226EEB0
}

public class AkPS5Settings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 83205
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 83204
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
		public PlatformAdvancedSettings(); // 0x0000000185DEE760-0x0000000185DEE820

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x0000000186805BA0-0x0000000186805BB0
	}

	// Constructors
	public AkPS5Settings(); // 0x0000000185DEE8E0-0x0000000185DEE9B0

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001829600D0-0x00000001829600E0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000182986470-0x0000000182986480
	protected override AkCommonCommSettings GetCommsSettings(); // 0x000000018226EEA0-0x000000018226EEB0
}

public class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 83207
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 83206
	{
		// Fields
		[Tooltip("Maximum number of System Audio Objects to reserve. Other processes will not be able to use them. Default is 128.")]
		public uint MaxSystemAudioObjects; // 0x50

		// Constructors
		public PlatformAdvancedSettings(); // 0x0000000187232810-0x0000000187232850

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x00000001870D3FA0-0x00000001870D3FD0
	}

	// Constructors
	public AkWindowsSettings(); // 0x0000000185DEE110-0x0000000185DEE120

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001829600D0-0x00000001829600E0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000182986470-0x0000000182986480
	protected override AkCommonCommSettings GetCommsSettings(); // 0x000000018226EEA0-0x000000018226EEB0
}

