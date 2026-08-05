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

// Image 29: AK.Wwise.Unity.API.dll - Assembly: AK.Wwise.Unity.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56580-56761
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class Ak3DAudioSinkCapabilities : IDisposable // TypeDefIndex: 56581
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkChannelConfig channelConfig { get; set; } // 0x000000018539B7D0-0x000000018539B84C 0x000000018539B9BC-0x000000018539BA24
	public uint uMaxSystemAudioObjects { get; set; } // 0x000000018539B89C-0x000000018539B8EC 0x000000018539BA78-0x000000018539BACC
	public uint uAvailableSystemAudioObjects { get; set; } // 0x000000018539B84C-0x000000018539B89C 0x000000018539BA24-0x000000018539BA78
	public bool bPassthrough { get; set; } // 0x000000018539B780-0x000000018539B7D0 0x000000018539B968-0x000000018539B9BC
	public bool bMultiChannelObjects { get; set; } // 0x000000018539B730-0x000000018539B780 0x000000018539B914-0x000000018539B968

	// Constructors
	internal Ak3DAudioSinkCapabilities(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public Ak3DAudioSinkCapabilities(); // 0x000000018539B6D0-0x000000018539B720

	// Methods
	internal static IntPtr getCPtr(Ak3DAudioSinkCapabilities obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539B8EC-0x000000018539B914
	~Ak3DAudioSinkCapabilities(); // 0x000000018539B65C-0x000000018539B6D0
	public void Dispose(); // 0x000000018539B60C-0x000000018539B65C
	protected virtual void Dispose(bool disposing); // 0x000000018539B4F8-0x000000018539B60C
}

public class Ak3dData : IDisposable // TypeDefIndex: 56582
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkTransform xform { get; set; } // 0x000000018539BDE4-0x000000018539BE60 0x000000018539BF8C-0x000000018539BFF4
	public float spread { get; set; } // 0x000000018539BD44-0x000000018539BD94 0x000000018539BEE0-0x000000018539BF38
	public float focus { get; set; } // 0x000000018539BCF4-0x000000018539BD44 0x000000018539BE88-0x000000018539BEE0
	public uint uEmitterChannelMask { get; set; } // 0x000000018539BD94-0x000000018539BDE4 0x000000018539BF38-0x000000018539BF8C

	// Constructors
	internal Ak3dData(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public Ak3dData(); // 0x000000018539BCA4-0x000000018539BCF4

	// Methods
	internal static IntPtr getCPtr(Ak3dData obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539BE60-0x000000018539BE88
	~Ak3dData(); // 0x000000018539BC30-0x000000018539BCA4
	public void Dispose(); // 0x000000018539BBE0-0x000000018539BC30
	protected virtual void Dispose(bool disposing); // 0x000000018539BACC-0x000000018539BBE0
}

public enum Ak3DPositionType // TypeDefIndex: 56583
{
	AK_3DPositionType_Emitter = 0,
	AK_3DPositionType_EmitterWithAutomation = 1,
	AK_3DPositionType_ListenerWithAutomation = 2
}

public enum Ak3DSpatializationMode // TypeDefIndex: 56584
{
	AK_SpatializationMode_None = 0,
	AK_SpatializationMode_PositionOnly = 1,
	AK_SpatializationMode_PositionAndOrientation = 2
}

public class AkAcousticSurface : IDisposable // TypeDefIndex: 56585
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint textureID { get; set; } // 0x000000018539C3D0-0x000000018539C420 0x000000018539C4EC-0x000000018539C540
	public float transmissionLoss { get; set; } // 0x000000018539C420-0x000000018539C470 0x000000018539C540-0x000000018539C598
	public string strName { get; set; } // 0x000000018539C364-0x000000018539C3D0 0x000000018539C498-0x000000018539C4EC

	// Constructors
	internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkAcousticSurface(); // 0x000000018539C314-0x000000018539C364

	// Methods
	internal static IntPtr getCPtr(AkAcousticSurface obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539C470-0x000000018539C498
	~AkAcousticSurface(); // 0x000000018539C260-0x000000018539C2D4
	public void Dispose(); // 0x000000018539C0FC-0x000000018539C14C
	protected virtual void Dispose(bool disposing); // 0x000000018539C14C-0x000000018539C260
	public void Clear(); // 0x000000018539BFF4-0x000000018539C044
	public void DeleteName(); // 0x000000018539C0AC-0x000000018539C0FC
	public static int GetSizeOf(); // 0x000000018539C2D4-0x000000018539C314
	public void Clone(AkAcousticSurface other); // 0x000000018539C044-0x000000018539C0AC
}

public enum AkActionOnEventType // TypeDefIndex: 56586
{
	AkActionOnEventType_Stop = 0,
	AkActionOnEventType_Pause = 1,
	AkActionOnEventType_Resume = 2,
	AkActionOnEventType_Break = 3,
	AkActionOnEventType_ReleaseEnvelope = 4
}

public enum AkAttenuationCurveType // TypeDefIndex: 56587
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

public enum AkAudioDeviceState // TypeDefIndex: 56588
{
	AkDeviceState_Unknown = 0,
	AkDeviceState_Active = 1,
	AkDeviceState_Disabled = 2,
	AkDeviceState_NotPresent = 4,
	AkDeviceState_Unplugged = 8,
	AkDeviceState_All = 15
}

public class AkAudioFormat : IDisposable // TypeDefIndex: 56589
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uSampleRate { get; set; } // 0x000000018539CB58-0x000000018539CBA8 0x000000018539CD84-0x000000018539CDD8
	public AkChannelConfig channelConfig { get; set; } // 0x000000018539C9EC-0x000000018539CA68 0x000000018539CC20-0x000000018539CC88
	public uint uBitsPerSample { get; set; } // 0x000000018539CA68-0x000000018539CAB8 0x000000018539CC88-0x000000018539CCDC
	public uint uBlockAlign { get; set; } // 0x000000018539CAB8-0x000000018539CB08 0x000000018539CCDC-0x000000018539CD30
	public uint uTypeID { get; set; } // 0x000000018539CBA8-0x000000018539CBF8 0x000000018539CDD8-0x000000018539CE2C
	public uint uInterleaveID { get; set; } // 0x000000018539CB08-0x000000018539CB58 0x000000018539CD30-0x000000018539CD84

	// Constructors
	internal AkAudioFormat(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkAudioFormat(); // 0x000000018539C99C-0x000000018539C9EC

	// Methods
	internal static IntPtr getCPtr(AkAudioFormat obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539CBF8-0x000000018539CC20
	~AkAudioFormat(); // 0x000000018539C6FC-0x000000018539C770
	public void Dispose(); // 0x000000018539C598-0x000000018539C5E8
	protected virtual void Dispose(bool disposing); // 0x000000018539C5E8-0x000000018539C6FC
	public uint GetNumChannels(); // 0x000000018539C860-0x000000018539C8B0
	public uint GetBitsPerSample(); // 0x000000018539C770-0x000000018539C7C0
	public uint GetBlockAlign(); // 0x000000018539C7C0-0x000000018539C810
	public uint GetTypeID(); // 0x000000018539C8B0-0x000000018539C900
	public uint GetInterleaveID(); // 0x000000018539C810-0x000000018539C860
	public void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID); // 0x000000018539C900-0x000000018539C99C
}

public class AkAudioInterruptionCallbackInfo : IDisposable // TypeDefIndex: 56590
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public bool bEnterInterruption { get; } // 0x000000018539D054-0x000000018539D0A4 

	// Constructors
	internal AkAudioInterruptionCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkAudioInterruptionCallbackInfo(); // 0x000000018539D004-0x000000018539D054

	// Methods
	internal static IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539D0A4-0x000000018539D0CC
	~AkAudioInterruptionCallbackInfo(); // 0x000000018539CF90-0x000000018539D004
	public void Dispose(); // 0x000000018539CE2C-0x000000018539CE7C
	protected virtual void Dispose(bool disposing); // 0x000000018539CE7C-0x000000018539CF90
}

public enum AkAudioObjectDestination // TypeDefIndex: 56591
{
	eDefault = 0,
	eMainMix = 1,
	ePassthrough = 2,
	eSystemAudioObject = 3
}

public class AkAudioSettings : IDisposable // TypeDefIndex: 56592
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumSamplesPerFrame { get; set; } // 0x000000018539D2F4-0x000000018539D344 0x000000018539D3BC-0x000000018539D410
	public uint uNumSamplesPerSecond { get; set; } // 0x000000018539D344-0x000000018539D394 0x000000018539D410-0x000000018539D464

	// Constructors
	internal AkAudioSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkAudioSettings(); // 0x000000018539D2A4-0x000000018539D2F4

	// Methods
	internal static IntPtr getCPtr(AkAudioSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539D394-0x000000018539D3BC
	~AkAudioSettings(); // 0x000000018539D230-0x000000018539D2A4
	public void Dispose(); // 0x000000018539D1E0-0x000000018539D230
	protected virtual void Dispose(bool disposing); // 0x000000018539D0CC-0x000000018539D1E0
}

public class AkAudioSourceChangeCallbackInfo : IDisposable // TypeDefIndex: 56593
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public bool bOtherAudioPlaying { get; } // 0x000000018539D68C-0x000000018539D6DC 

	// Constructors
	internal AkAudioSourceChangeCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkAudioSourceChangeCallbackInfo(); // 0x000000018539D63C-0x000000018539D68C

	// Methods
	internal static IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539D6DC-0x000000018539D704
	~AkAudioSourceChangeCallbackInfo(); // 0x000000018539D5C8-0x000000018539D63C
	public void Dispose(); // 0x000000018539D464-0x000000018539D4B4
	protected virtual void Dispose(bool disposing); // 0x000000018539D4B4-0x000000018539D5C8
}

public class AkAuxSendValue : IDisposable // TypeDefIndex: 56594
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong listenerID { get; set; } // 0x000000018539DB84-0x000000018539DBD4 0x000000018539DCA8-0x000000018539DCFC
	public uint auxBusID { get; set; } // 0x000000018539DAE4-0x000000018539DB34 0x000000018539DBFC-0x000000018539DC50
	public float fControlValue { get; set; } // 0x000000018539DB34-0x000000018539DB84 0x000000018539DC50-0x000000018539DCA8

	// Constructors
	internal AkAuxSendValue(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50

	// Methods
	internal static IntPtr getCPtr(AkAuxSendValue obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539DBD4-0x000000018539DBFC
	~AkAuxSendValue(); // 0x000000018539D868-0x000000018539D8DC
	public void Dispose(); // 0x000000018539D704-0x000000018539D754
	protected virtual void Dispose(bool disposing); // 0x000000018539D754-0x000000018539D868
	public void Set(ulong listener, uint id, float value); // 0x000000018539DA6C-0x000000018539DAE4
	public bool IsSame(ulong listener, uint id); // 0x000000018539D91C-0x000000018539D980
	public void Set(GameObject listener, uint id, float value); // 0x000000018539D9EC-0x000000018539DA6C
	public bool IsSame(GameObject listener, uint id); // 0x000000018539D980-0x000000018539D9EC
	public static int GetSizeOf(); // 0x000000018539D8DC-0x000000018539D91C
}

public class AkBankCallbackInfo : IDisposable // TypeDefIndex: 56595
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint bankID { get; } // 0x0000000183289ED0-0x0000000183289F00 
	public IntPtr inMemoryBankPtr { get; } // 0x0000000183289E30-0x0000000183289E60 
	public AKRESULT loadResult { get; } // 0x0000000183289EA0-0x0000000183289ED0 

	// Constructors
	internal AkBankCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkBankCallbackInfo(); // 0x000000018539DD70-0x000000018539DDC0

	// Methods
	internal static IntPtr getCPtr(AkBankCallbackInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000185391B90-0x0000000185391BC0
	~AkBankCallbackInfo(); // 0x000000018539DCFC-0x000000018539DD70
	public void Dispose(); // 0x0000000184020DC0-0x0000000184020E00
	protected virtual void Dispose(bool disposing); // 0x0000000184020E00-0x0000000184020FB0
}

public enum AkBankContent // TypeDefIndex: 56596
{
	AkBankContent_StructureOnly = 0,
	AkBankContent_All = 1
}

public enum AkBankTypeEnum // TypeDefIndex: 56597
{
	AkBankType_User = 0,
	AkBankType_Event = 30,
	AkBankType_Bus = 31
}

public class AkBehavioralPositioningData : IDisposable // TypeDefIndex: 56598
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float center { get; set; } // 0x000000018539DFE8-0x000000018539E038 0x000000018539E290-0x000000018539E2E8
	public float panLR { get; set; } // 0x000000018539E128-0x000000018539E178 0x000000018539E3EC-0x000000018539E444
	public float panBF { get; set; } // 0x000000018539E088-0x000000018539E0D8 0x000000018539E33C-0x000000018539E394
	public float panDU { get; set; } // 0x000000018539E0D8-0x000000018539E128 0x000000018539E394-0x000000018539E3EC
	public float panSpatMix { get; set; } // 0x000000018539E178-0x000000018539E1C8 0x000000018539E444-0x000000018539E49C
	public Ak3DSpatializationMode spatMode { get; set; } // 0x000000018539E218-0x000000018539E268 0x000000018539E4F0-0x000000018539E544
	public AkSpeakerPanningType panType { get; set; } // 0x000000018539E1C8-0x000000018539E218 0x000000018539E49C-0x000000018539E4F0
	public bool enableHeightSpread { get; set; } // 0x000000018539E038-0x000000018539E088 0x000000018539E2E8-0x000000018539E33C

	// Constructors
	internal AkBehavioralPositioningData(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkBehavioralPositioningData(); // 0x000000018539DF98-0x000000018539DFE8

	// Methods
	internal static IntPtr getCPtr(AkBehavioralPositioningData obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539E268-0x000000018539E290
	~AkBehavioralPositioningData(); // 0x000000018539DF24-0x000000018539DF98
	public void Dispose(); // 0x000000018539DED4-0x000000018539DF24
	protected virtual void Dispose(bool disposing); // 0x000000018539DDC0-0x000000018539DED4
}

public enum AkBusHierarchyFlags // TypeDefIndex: 56599
{
	AkBusHierarchy_Primary = 1,
	AkBusHierarchy_Secondary = 2,
	AkBusHierarchy_IsMaster = 128
}

public class AkCallbackInfo : IDisposable // TypeDefIndex: 56600
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pCookie { get; } // 0x000000018328DAD0-0x000000018328DB70 
	public ulong gameObjID { get; } // 0x000000018328DA50-0x000000018328DAA0 

	// Constructors
	internal AkCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkCallbackInfo(); // 0x000000018539E5BC-0x000000018539E60C

	// Methods
	internal static IntPtr getCPtr(AkCallbackInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x0000000185396634-0x0000000185396738
	~AkCallbackInfo(); // 0x000000018539E544-0x000000018539E5BC
	public void Dispose(); // 0x0000000183FD96F0-0x0000000183FD9750
	protected virtual void Dispose(bool disposing); // 0x0000000183CC8CD0-0x0000000183CC8E80
}

public class AkCallbackSerializer : IDisposable // TypeDefIndex: 56601
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkCallbackSerializer(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkCallbackSerializer(); // 0x000000018539E918-0x000000018539E968

	// Methods
	internal static IntPtr getCPtr(AkCallbackSerializer obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539E968-0x000000018539E990
	~AkCallbackSerializer(); // 0x000000018539E7E0-0x000000018539E854
	public void Dispose(); // 0x000000018539E67C-0x000000018539E6CC
	protected virtual void Dispose(bool disposing); // 0x000000018539E6CC-0x000000018539E7E0
	public static AKRESULT Init(); // 0x000000018400AB80-0x000000018400ABC0
	public static void Term(); // 0x000000018539E8D8-0x000000018539E918
	public static IntPtr Lock(); // 0x000000018328BEC0-0x000000018328BF10
	public static void Unlock(); // 0x0000000183EB8EC0-0x0000000183EB8EF0
	public static void SetLocalOutput(uint in_uErrorLevel, string in_ip, uint in_port, string in_xmlFilePath, uint in_msXmlTranslatorTimeout, uint in_msWaapiTranslatorTimeout); // 0x000000018539E854-0x000000018539E8D8
	public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie); // 0x000000018539E60C-0x000000018539E67C
}

public enum AkCallbackType // TypeDefIndex: 56602
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

public class AkChannelConfig : IDisposable // TypeDefIndex: 56603
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumChannels { get; set; } // 0x0000000183AC7720-0x0000000183AC7780 0x000000018539F148-0x000000018539F19C
	public uint eConfigType { get; set; } // 0x0000000183AC7680-0x0000000183AC76E0 0x000000018539F0A0-0x000000018539F0F4
	public uint uChannelMask { get; set; } // 0x0000000183AC75E0-0x0000000183AC7640 0x000000018539F0F4-0x000000018539F148

	// Constructors
	internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkChannelConfig(); // 0x000000018539EFC4-0x000000018539F014
	public AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask); // 0x000000018539F014-0x000000018539F078

	// Methods
	internal static IntPtr getCPtr(AkChannelConfig obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539F078-0x000000018539F0A0
	~AkChannelConfig(); // 0x000000018468F860-0x000000018468F8B0
	public void Dispose(); // 0x000000018539EB14-0x000000018539EB64
	protected virtual void Dispose(bool disposing); // 0x000000018468F8B0-0x000000018468FB10
	public static AkChannelConfig Standard(uint in_uChannelMask); // 0x000000018539EF54-0x000000018539EFC4
	public static AkChannelConfig Anonymous(uint in_uNumChannels); // 0x000000018539EA00-0x000000018539EA70
	public static AkChannelConfig Ambisonic(uint in_uNumChannels); // 0x000000018539E990-0x000000018539EA00
	public static AkChannelConfig Object(); // 0x000000018539EBB4-0x000000018539EC20
	public void Clear(); // 0x000000018539EA70-0x000000018539EAC0
	public void SetStandard(uint in_uChannelMask); // 0x000000018539EF00-0x000000018539EF54
	public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask); // 0x000000018539EE9C-0x000000018539EF00
	public void SetAnonymous(uint in_uNumChannels); // 0x00000001845E21F0-0x00000001845E2250
	public void SetAmbisonic(uint in_uNumChannels); // 0x000000018539ED58-0x000000018539EDAC
	public void SetObject(); // 0x000000018539EDAC-0x000000018539EDFC
	public void SetSameAsMainMix(); // 0x000000018539EDFC-0x000000018539EE4C
	public void SetSameAsPassthrough(); // 0x000000018539EE4C-0x000000018539EE9C
	public bool IsValid(); // 0x000000018539EB64-0x000000018539EBB4
	public uint Serialize(); // 0x000000018539ED08-0x000000018539ED58
	public void Deserialize(uint in_uChannelConfig); // 0x000000018539EAC0-0x000000018539EB14
	public AkChannelConfig RemoveLFE(); // 0x000000018539EC94-0x000000018539ED08
	public AkChannelConfig RemoveCenter(); // 0x000000018539EC20-0x000000018539EC94
}

public enum AkChannelConfigType // TypeDefIndex: 56604
{
	AK_ChannelConfigType_Anonymous = 0,
	AK_ChannelConfigType_Standard = 1,
	AK_ChannelConfigType_Ambisonic = 2,
	AK_ChannelConfigType_Objects = 3,
	AK_ChannelConfigType_UseDeviceMain = 14,
	AK_ChannelConfigType_UseDevicePassthrough = 15
}

public class AkChannelEmitter : IDisposable // TypeDefIndex: 56605
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkWorldTransform position { get; set; } // 0x000000018539F3E0-0x000000018539F45C 0x000000018539F528-0x000000018539F590
	public uint uInputChannels { get; set; } // 0x000000018539F45C-0x000000018539F4AC 0x000000018539F590-0x000000018539F5E4
	public string padding { get; set; } // 0x000000018539F374-0x000000018539F3E0 0x000000018539F4D4-0x000000018539F528

	// Constructors
	internal AkChannelEmitter(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50

	// Methods
	internal static IntPtr getCPtr(AkChannelEmitter obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539F4AC-0x000000018539F4D4
	~AkChannelEmitter(); // 0x000000018539F300-0x000000018539F374
	public void Dispose(); // 0x000000018539F2B0-0x000000018539F300
	protected virtual void Dispose(bool disposing); // 0x000000018539F19C-0x000000018539F2B0
}

public enum AkChannelOrdering // TypeDefIndex: 56606
{
	ChannelOrdering_Standard = 0,
	ChannelOrdering_RunTime = 1
}

public enum AkConnectionType // TypeDefIndex: 56607
{
	ConnectionType_Direct = 0,
	ConnectionType_GameDefSend = 1,
	ConnectionType_UserDefSend = 2,
	ConnectionType_ReflectionsSend = 3
}

public enum AkCurveInterpolation // TypeDefIndex: 56608
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

public class AkDeviceDescription : IDisposable // TypeDefIndex: 56609
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint idDevice { get; set; } // 0x0000000184009220-0x0000000184009270 0x000000018539FF4C-0x000000018539FFA0
	public string deviceName { get; set; } // 0x000000018539FDC0-0x000000018539FE2C 0x000000018539FEA4-0x000000018539FEF8
	public AkAudioDeviceState deviceStateMask { get; set; } // 0x000000018539FE2C-0x000000018539FE7C 0x000000018539FEF8-0x000000018539FF4C
	public bool isDefaultDevice { get; set; } // 0x0000000184009060-0x00000001840090C0 0x000000018539FFA0-0x000000018539FFF4

	// Constructors
	internal AkDeviceDescription(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkDeviceDescription(); // 0x000000018539FD70-0x000000018539FDC0

	// Methods
	internal static IntPtr getCPtr(AkDeviceDescription obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539FE7C-0x000000018539FEA4
	~AkDeviceDescription(); // 0x00000001843DF660-0x00000001843DF6B0
	public void Dispose(); // 0x000000018539FCE0-0x000000018539FD30
	protected virtual void Dispose(bool disposing); // 0x00000001843DF6B0-0x00000001843DF890
	public void Clear(); // 0x000000018539FC28-0x000000018539FC78
	public static int GetSizeOf(); // 0x000000018539FD30-0x000000018539FD70
	public void Clone(AkDeviceDescription other); // 0x000000018539FC78-0x000000018539FCE0
}

public class AkDeviceSettings : IDisposable // TypeDefIndex: 56610
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pIOMemory { get; set; } // 0x00000001853A0134-0x00000001853A0184 0x00000001853A040C-0x00000001853A0460
	public uint uIOMemorySize { get; set; } // 0x00000001853A02A0-0x00000001853A02F0 0x000000018400B150-0x000000018400B1B0
	public uint uIOMemoryAlignment { get; set; } // 0x00000001853A0250-0x00000001853A02A0 0x00000001853A051C-0x00000001853A0570
	public uint ePoolAttributes { get; set; } // 0x00000001853A0094-0x00000001853A00E4 0x00000001853A03B8-0x00000001853A040C
	public uint uGranularity { get; set; } // 0x00000001853A0200-0x00000001853A0250 0x00000001853A04C8-0x00000001853A051C
	public AkThreadProperties threadProperties { get; set; } // 0x00000001853A0184-0x00000001853A0200 0x00000001853A0460-0x00000001853A04C8
	public float fTargetAutoStmBufferLength { get; set; } // 0x00000001853A00E4-0x00000001853A0134 0x000000018400B0A0-0x000000018400B100
	public uint uMaxConcurrentIO { get; set; } // 0x00000001853A0340-0x00000001853A0390 0x00000001853A0570-0x00000001853A05C4
	public bool bUseStreamCache { get; set; } // 0x00000001853A0044-0x00000001853A0094 0x000000018400AFF0-0x000000018400B050
	public uint uMaxCachePinnedBytes { get; set; } // 0x00000001853A02F0-0x00000001853A0340 0x000000018400AF50-0x000000018400AFB0

	// Constructors
	internal AkDeviceSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50

	// Methods
	internal static IntPtr getCPtr(AkDeviceSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A0390-0x00000001853A03B8
	~AkDeviceSettings(); // 0x00000001848F4630-0x00000001848F4680
	public void Dispose(); // 0x000000018539FFF4-0x00000001853A0044
	protected virtual void Dispose(bool disposing); // 0x00000001848F4680-0x00000001848F4840
}

public class AkDiffractionPathInfo : IDisposable // TypeDefIndex: 56611
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18
	public const uint kMaxNodes = 8; // Metadata: 0x02348C2E

	// Properties
	public AkVector64 emitterPos { get; set; } // 0x00000001853A0A58-0x00000001853A0AC4 0x00000001853A0D50-0x00000001853A0DBC
	public AkWorldTransform virtualPos { get; set; } // 0x00000001853A0C54-0x00000001853A0CD0 0x00000001853A0F70-0x00000001853A0FD8
	public uint nodeCount { get; set; } // 0x00000001853A0AC4-0x00000001853A0B14 0x00000001853A0DBC-0x00000001853A0E10
	public float diffraction { get; set; } // 0x00000001853A0A08-0x00000001853A0A58 0x00000001853A0CF8-0x00000001853A0D50
	public float transmissionLoss { get; set; } // 0x00000001853A0C04-0x00000001853A0C54 0x00000001853A0F18-0x00000001853A0F70
	public float totLength { get; set; } // 0x00000001853A0BB4-0x00000001853A0C04 0x00000001853A0EC0-0x00000001853A0F18
	public float obstructionValue { get; set; } // 0x00000001853A0B14-0x00000001853A0B64 0x00000001853A0E10-0x00000001853A0E68
	public float occlusionValue { get; set; } // 0x00000001853A0B64-0x00000001853A0BB4 0x00000001853A0E68-0x00000001853A0EC0

	// Constructors
	internal AkDiffractionPathInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkDiffractionPathInfo(); // 0x00000001853A09B8-0x00000001853A0A08

	// Methods
	internal static IntPtr getCPtr(AkDiffractionPathInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A0CD0-0x00000001853A0CF8
	~AkDiffractionPathInfo(); // 0x00000001853A0790-0x00000001853A0804
	public void Dispose(); // 0x00000001853A062C-0x00000001853A067C
	protected virtual void Dispose(bool disposing); // 0x00000001853A067C-0x00000001853A0790
	public static int GetSizeOf(); // 0x00000001853A0978-0x00000001853A09B8
	public Vector3 GetNodes(uint idx); // 0x00000001853A0858-0x00000001853A08D0
	public float GetAngles(uint idx); // 0x00000001853A0804-0x00000001853A0858
	public ulong GetPortals(uint idx); // 0x00000001853A08D0-0x00000001853A0924
	public ulong GetRooms(uint idx); // 0x00000001853A0924-0x00000001853A0978
	public void Clone(AkDiffractionPathInfo other); // 0x00000001853A05C4-0x00000001853A062C
}

public class AkDurationCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 56612
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public float fDuration { get; } // 0x00000001853A1208-0x00000001853A1258 
	public float fEstimatedDuration { get; } // 0x00000001853A1258-0x00000001853A12A8 
	public uint audioNodeID { get; } // 0x00000001853A1168-0x00000001853A11B8 
	public uint mediaID { get; } // 0x00000001853A12A8-0x00000001853A12F8 
	public bool bStreaming { get; } // 0x00000001853A11B8-0x00000001853A1208 

	// Constructors
	internal AkDurationCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000183F33D70-0x0000000183F33DF0
	public AkDurationCallbackInfo(); // 0x00000001853A1108-0x00000001853A1158

	// Methods
	internal static IntPtr getCPtr(AkDurationCallbackInfo obj); // 0x00000001853A1158-0x00000001853A1168
	internal override void setCPtr(IntPtr cPtr); // 0x00000001853A12F8-0x00000001853A1358
	protected override void Dispose(bool disposing); // 0x00000001853A0FD8-0x00000001853A1108
}

public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo // TypeDefIndex: 56613
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get; } // 0x00000001853A1588-0x00000001853A15D8 
	public uint audioNodeID { get; } // 0x00000001853A14E8-0x00000001853A1538 
	public IntPtr pCustomInfo { get; } // 0x00000001853A1538-0x00000001853A1588 

	// Constructors
	internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000183F33880-0x0000000183F338F0
	public AkDynamicSequenceItemCallbackInfo(); // 0x00000001853A1488-0x00000001853A14D8

	// Methods
	internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj); // 0x00000001853A14D8-0x00000001853A14E8
	internal override void setCPtr(IntPtr cPtr); // 0x00000001853A15D8-0x00000001853A1638
	protected override void Dispose(bool disposing); // 0x00000001853A1358-0x00000001853A1488
}

public enum AkDynamicSequenceType // TypeDefIndex: 56614
{
	DynamicSequenceType_SampleAccurate = 0,
	DynamicSequenceType_NormalTransition = 1
}

public class AkEventCallbackInfo : AkCallbackInfo // TypeDefIndex: 56615
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get; } // 0x00000001853A1688-0x00000001853A16D8 
	public uint eventID { get; } // 0x000000018328DBF0-0x000000018328DC40 

	// Constructors
	internal AkEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000183F33BF0-0x0000000183F33C70
	public AkEventCallbackInfo(); // 0x00000001853A1638-0x00000001853A1688

	// Methods
	internal static IntPtr getCPtr(AkEventCallbackInfo obj); // 0x00000001853A14D8-0x00000001853A14E8
	internal override void setCPtr(IntPtr cPtr); // 0x0000000183F33C70-0x0000000183F33D30
	protected override void Dispose(bool disposing); // 0x0000000183CC8B00-0x0000000183CC8CD0
}

public class AkExtent : IDisposable // TypeDefIndex: 56616
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float halfWidth { get; set; } // 0x00000001853A1A1C-0x00000001853A1A6C 0x00000001853A1B44-0x00000001853A1B9C
	public float halfHeight { get; set; } // 0x00000001853A19CC-0x00000001853A1A1C 0x00000001853A1AEC-0x00000001853A1B44
	public float halfDepth { get; set; } // 0x00000001853A197C-0x00000001853A19CC 0x00000001853A1A94-0x00000001853A1AEC

	// Constructors
	internal AkExtent(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkExtent(); // 0x00000001853A18B0-0x00000001853A1900
	public AkExtent(float in_halfWidth, float in_halfHeight, float in_halfDepth); // 0x00000001853A1900-0x00000001853A197C

	// Methods
	internal static IntPtr getCPtr(AkExtent obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A1A6C-0x00000001853A1A94
	~AkExtent(); // 0x00000001853A183C-0x00000001853A18B0
	public void Dispose(); // 0x00000001853A17EC-0x00000001853A183C
	protected virtual void Dispose(bool disposing); // 0x00000001853A16D8-0x00000001853A17EC
}

public class AkExternalSourceInfo : IDisposable // TypeDefIndex: 56617
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint iExternalSrcCookie { get; set; } // 0x00000001853A1EA0-0x00000001853A1EF0 0x0000000183ABE910-0x0000000183ABE970
	public uint idCodec { get; set; } // 0x00000001853A1EF0-0x00000001853A1F40 0x0000000183ABE9C0-0x0000000183ABEA20
	public string szFile { get; set; } // 0x00000001853A1FE0-0x00000001853A204C 0x0000000183ABE850-0x0000000183ABE8C0
	public IntPtr pInMemory { get; set; } // 0x00000001853A1F90-0x00000001853A1FE0 0x00000001853A2118-0x00000001853A216C
	public uint uiMemorySize { get; set; } // 0x00000001853A204C-0x00000001853A209C 0x00000001853A216C-0x00000001853A21C0
	public uint idFile { get; set; } // 0x00000001853A1F40-0x00000001853A1F90 0x00000001853A20C4-0x00000001853A2118

	// Constructors
	internal AkExternalSourceInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkExternalSourceInfo(); // 0x00000001853A1DD0-0x00000001853A1E20
	public AkExternalSourceInfo(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec); // 0x00000001853A1E20-0x00000001853A1EA0
	public AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec); // 0x00000001853A1D58-0x00000001853A1DD0
	public AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec); // 0x00000001853A1CE4-0x00000001853A1D58

	// Methods
	internal static IntPtr getCPtr(AkExternalSourceInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A209C-0x00000001853A20C4
	~AkExternalSourceInfo(); // 0x000000018449C9C0-0x000000018449CA10
	public void Dispose(); // 0x00000001853A1C54-0x00000001853A1CA4
	protected virtual void Dispose(bool disposing); // 0x000000018449CA10-0x000000018449CBC0
	public void Clear(); // 0x00000001853A1B9C-0x00000001853A1BEC
	public void Clone(AkExternalSourceInfo other); // 0x00000001853A1BEC-0x00000001853A1C54
	public static int GetSizeOf(); // 0x00000001853A1CA4-0x00000001853A1CE4
}

public enum AkFloorPlane // TypeDefIndex: 56618
{
	AkFloorPlane_XZ = 0,
	AkFloorPlane_Default = 0,
	AkFloorPlane_XY = 1,
	AkFloorPlane_YZ = 2
}

public class AkGeometryInstanceParams : IDisposable // TypeDefIndex: 56619
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkWorldTransform PositionAndOrientation { get; set; } // 0x00000001853A23E8-0x00000001853A2464 0x00000001853A2544-0x00000001853A25AC
	public Vector3 Scale { get; set; } // 0x00000001853A2464-0x00000001853A24CC 0x00000001853A25AC-0x00000001853A2614
	public bool UseForReflectionAndDiffraction { get; set; } // 0x00000001853A24CC-0x00000001853A251C 0x00000001853A2614-0x00000001853A2668

	// Constructors
	internal AkGeometryInstanceParams(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkGeometryInstanceParams(); // 0x00000001853A2398-0x00000001853A23E8

	// Methods
	internal static IntPtr getCPtr(AkGeometryInstanceParams obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A251C-0x00000001853A2544
	~AkGeometryInstanceParams(); // 0x00000001853A2324-0x00000001853A2398
	public void Dispose(); // 0x00000001853A21C0-0x00000001853A2210
	protected virtual void Dispose(bool disposing); // 0x00000001853A2210-0x00000001853A2324
}

public enum AkGlobalCallbackLocation // TypeDefIndex: 56620
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

public enum AkGroupType // TypeDefIndex: 56621
{
	AkGroupType_Switch = 0,
	AkGroupType_State = 1
}

public class AkImageSourceParams : IDisposable // TypeDefIndex: 56622
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkVector64 sourcePosition { get; set; } // 0x00000001853A2A5C-0x00000001853A2AC8 0x00000001853A2CF0-0x00000001853A2D5C
	public float fDistanceScalingFactor { get; set; } // 0x00000001853A296C-0x00000001853A29BC 0x00000001853A2BE8-0x00000001853A2C40
	public float fLevel { get; set; } // 0x00000001853A29BC-0x00000001853A2A0C 0x00000001853A2C40-0x00000001853A2C98
	public float fDiffraction { get; set; } // 0x00000001853A291C-0x00000001853A296C 0x00000001853A2B90-0x00000001853A2BE8
	public float fOcclusion { get; set; } // 0x00000001853A2A0C-0x00000001853A2A5C 0x00000001853A2C98-0x00000001853A2CF0
	public byte uDiffractionEmitterSide { get; set; } // 0x00000001853A2AC8-0x00000001853A2B18 0x00000001853A2D5C-0x00000001853A2DB0
	public byte uDiffractionListenerSide { get; set; } // 0x00000001853A2B18-0x00000001853A2B68 0x00000001853A2DB0-0x00000001853A2E04

	// Constructors
	internal AkImageSourceParams(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkImageSourceParams(); // 0x00000001853A2840-0x00000001853A2890
	public AkImageSourceParams(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel); // 0x00000001853A2890-0x00000001853A291C

	// Methods
	internal static IntPtr getCPtr(AkImageSourceParams obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A2B68-0x00000001853A2B90
	~AkImageSourceParams(); // 0x00000001853A27CC-0x00000001853A2840
	public void Dispose(); // 0x00000001853A2668-0x00000001853A26B8
	protected virtual void Dispose(bool disposing); // 0x00000001853A26B8-0x00000001853A27CC
}

public class AkImageSourceSettings : IDisposable // TypeDefIndex: 56623
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkImageSourceParams params_ { get; set; } // 0x00000001853A310C-0x00000001853A3188 0x00000001853A31B0-0x00000001853A3218

	// Constructors
	internal AkImageSourceSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkImageSourceSettings(); // 0x00000001853A30BC-0x00000001853A310C
	public AkImageSourceSettings(AkVector64 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel); // 0x00000001853A3030-0x00000001853A30BC

	// Methods
	internal static IntPtr getCPtr(AkImageSourceSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A3188-0x00000001853A31B0
	~AkImageSourceSettings(); // 0x00000001853A2F68-0x00000001853A2FDC
	public void Dispose(); // 0x00000001853A2F18-0x00000001853A2F68
	protected virtual void Dispose(bool disposing); // 0x00000001853A2E04-0x00000001853A2F18
	public void SetOneTexture(uint in_texture); // 0x00000001853A2FDC-0x00000001853A3030
}

public class AkInitializationSettings : IDisposable // TypeDefIndex: 56624
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkStreamMgrSettings streamMgrSettings { get; set; } // 0x000000018400A920-0x000000018400A9B0 0x00000001853A3CAC-0x00000001853A3D14
	public AkDeviceSettings deviceSettings { get; set; } // 0x0000000184009BF0-0x0000000184009C80 0x00000001853A3B0C-0x00000001853A3B74
	public AkInitSettings initSettings { get; set; } // 0x0000000184009B20-0x0000000184009BB0 0x00000001853A3B74-0x00000001853A3BDC
	public AkPlatformInitSettings platformSettings { get; set; } // 0x0000000184009A50-0x0000000184009AE0 0x00000001853A3C44-0x00000001853A3CAC
	public AkMusicSettings musicSettings { get; set; } // 0x000000018400A850-0x000000018400A8E0 0x00000001853A3BDC-0x00000001853A3C44
	public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings { get; set; } // 0x0000000184009980-0x0000000184009A10 0x00000001853A3D14-0x00000001853A3D7C
	public uint uMemAllocationSizeLimit { get; set; } // 0x00000001853A39F4-0x00000001853A3A44 0x000000018400AEB0-0x000000018400AF10
	public uint uMemDebugLevel { get; set; } // 0x00000001853A3A44-0x00000001853A3A94 0x000000018400AE10-0x000000018400AE70
	public uint uMemSpanCount { get; set; } // 0x00000001853A3A94-0x00000001853A3AE4 0x000000018400AD70-0x000000018400ADD0

	// Constructors
	internal AkInitializationSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkInitializationSettings(); // 0x000000018400ABF0-0x000000018400AC40

	// Methods
	internal static IntPtr getCPtr(AkInitializationSettings obj); // 0x00000001833021A0-0x00000001833021B0
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A3AE4-0x00000001853A3B0C
	~AkInitializationSettings(); // 0x00000001849C77D0-0x00000001849C7820
	public void Dispose(); // 0x00000001853A39A4-0x00000001853A39F4
	protected virtual void Dispose(bool disposing); // 0x00000001849C7820-0x00000001849C7A60
}

public class AkInitSettings : IDisposable // TypeDefIndex: 56625
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxNumPaths { get; set; } // 0x00000001853A3628-0x00000001853A3678 0x00000001845E1FA0-0x00000001845E2000
	public uint uCommandQueueSize { get; set; } // 0x00000001853A34E8-0x00000001853A3538 0x00000001845E1F00-0x00000001845E1F60
	public bool bEnableGameSyncPreparation { get; set; } // 0x00000001853A32B8-0x00000001853A3308 0x000000018479E730-0x000000018479E790
	public uint uContinuousPlaybackLookAhead { get; set; } // 0x00000001853A3538-0x00000001853A3588 0x000000018479E690-0x000000018479E6F0
	public uint uNumSamplesPerFrame { get; set; } // 0x00000001853A36C8-0x00000001853A3718 0x00000001845E1E60-0x00000001845E1EC0
	public uint uMonitorQueuePoolSize { get; set; } // 0x00000001853A3678-0x00000001853A36C8 0x000000018479E5F0-0x000000018479E650
	public uint uCpuMonitorQueueMaxSize { get; set; } // 0x00000001853A3588-0x00000001853A35D8 0x00000001853A3950-0x00000001853A39A4
	public AkOutputSettings settingsMainOutput { get; set; } // 0x00000001845E1D30-0x00000001845E1DC0 0x00000001853A3894-0x00000001853A38FC
	public uint uMaxHardwareTimeoutMs { get; set; } // 0x00000001853A35D8-0x00000001853A3628 0x000000018479E550-0x000000018479E5B0
	public bool bUseSoundBankMgrThread { get; set; } // 0x00000001853A3358-0x00000001853A33A8 0x00000001853A3794-0x00000001853A37E8
	public bool bUseLEngineThread { get; set; } // 0x00000001853A3308-0x00000001853A3358 0x00000001853A3740-0x00000001853A3794
	public string szPluginDLLPath { get; set; } // 0x00000001845E1BD0-0x00000001845E1C50 0x00000001845E1E00-0x00000001845E1E60
	public AkFloorPlane eFloorPlane { get; set; } // 0x00000001853A33A8-0x00000001853A33F8 0x00000001853A37E8-0x00000001853A383C
	public float fGameUnitsToMeters { get; set; } // 0x00000001853A3448-0x00000001853A3498 0x00000001853A383C-0x00000001853A3894
	public uint uBankReadBufferSize { get; set; } // 0x00000001853A3498-0x00000001853A34E8 0x00000001853A38FC-0x00000001853A3950
	public float fDebugOutOfRangeLimit { get; set; } // 0x00000001853A33F8-0x00000001853A3448 0x000000018479E4A0-0x000000018479E500
	public bool bDebugOutOfRangeCheckEnabled { get; set; } // 0x00000001853A3268-0x00000001853A32B8 0x000000018479E3F0-0x000000018479E450

	// Constructors
	internal AkInitSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50

	// Methods
	internal static IntPtr getCPtr(AkInitSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A3718-0x00000001853A3740
	~AkInitSettings(); // 0x00000001848F4420-0x00000001848F4470
	public void Dispose(); // 0x00000001853A3218-0x00000001853A3268
	protected virtual void Dispose(bool disposing); // 0x00000001848F4470-0x00000001848F4630
}

public class AkIterator : IDisposable // TypeDefIndex: 56626
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkPlaylistItem pItem { get; set; } // 0x00000001853A41D0-0x00000001853A424C 0x00000001853A4274-0x00000001853A42DC

	// Constructors
	internal AkIterator(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkIterator(); // 0x00000001853A4180-0x00000001853A41D0

	// Methods
	internal static IntPtr getCPtr(AkIterator obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A424C-0x00000001853A4274
	~AkIterator(); // 0x00000001853A3EE0-0x00000001853A3F54
	public void Dispose(); // 0x00000001853A3E90-0x00000001853A3EE0
	protected virtual void Dispose(bool disposing); // 0x00000001853A3D7C-0x00000001853A3E90
	public AkIterator NextIter(); // 0x00000001853A4098-0x00000001853A410C
	public AkIterator PrevIter(); // 0x00000001853A410C-0x00000001853A4180
	public AkPlaylistItem GetItem(); // 0x00000001853A3F54-0x00000001853A3FC8
	public bool IsEqualTo(AkIterator in_rOp); // 0x00000001853A4030-0x00000001853A4098
	public bool IsDifferentFrom(AkIterator in_rOp); // 0x00000001853A3FC8-0x00000001853A4030
}

public class AkMarkerCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 56627
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public uint uIdentifier { get; } // 0x00000001853A6724-0x00000001853A6774 
	public uint uPosition { get; } // 0x00000001853A6774-0x00000001853A67C4 
	public string strLabel { get; } // 0x00000001853A66B8-0x00000001853A6724 

	// Constructors
	internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000183F33B30-0x0000000183F33BB0
	public AkMarkerCallbackInfo(); // 0x00000001853A6668-0x00000001853A66B8

	// Methods
	internal static IntPtr getCPtr(AkMarkerCallbackInfo obj); // 0x00000001853A1158-0x00000001853A1168
	internal override void setCPtr(IntPtr cPtr); // 0x00000001853A67C4-0x00000001853A6824
	protected override void Dispose(bool disposing); // 0x00000001853A6538-0x00000001853A6668
}

public class AkMemCategroyStats : IDisposable // TypeDefIndex: 56628
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong uUsed { get; set; } // 0x00000001853A6AEC-0x00000001853A6B3C 0x00000001853A6C60-0x00000001853A6CB4
	public ulong uPeakUsed { get; set; } // 0x00000001853A6A9C-0x00000001853A6AEC 0x00000001853A6C0C-0x00000001853A6C60
	public uint uAllocs { get; set; } // 0x00000001853A69FC-0x00000001853A6A4C 0x00000001853A6B64-0x00000001853A6BB8
	public uint uFrees { get; set; } // 0x00000001853A6A4C-0x00000001853A6A9C 0x00000001853A6BB8-0x00000001853A6C0C

	// Constructors
	internal AkMemCategroyStats(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkMemCategroyStats(); // 0x0000000184B44F10-0x0000000184B44F60

	// Methods
	internal static IntPtr getCPtr(AkMemCategroyStats obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A6B3C-0x00000001853A6B64
	~AkMemCategroyStats(); // 0x00000001853A6988-0x00000001853A69FC
	public void Dispose(); // 0x00000001853A6824-0x00000001853A6874
	protected virtual void Dispose(bool disposing); // 0x00000001853A6874-0x00000001853A6988
}

public class AkMemGlobalStats : IDisposable // TypeDefIndex: 56629
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ulong uUsed { get; set; } // 0x00000001853A6FCC-0x00000001853A701C 0x00000001853A7140-0x00000001853A7194
	public ulong uDeviceUsed { get; set; } // 0x00000001853A6EDC-0x00000001853A6F2C 0x00000001853A7044-0x00000001853A7098
	public ulong uReserved { get; set; } // 0x00000001853A6F7C-0x00000001853A6FCC 0x00000001853A70EC-0x00000001853A7140
	public ulong uMax { get; set; } // 0x00000001853A6F2C-0x00000001853A6F7C 0x00000001853A7098-0x00000001853A70EC

	// Constructors
	internal AkMemGlobalStats(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkMemGlobalStats(); // 0x00000001853A6E8C-0x00000001853A6EDC

	// Methods
	internal static IntPtr getCPtr(AkMemGlobalStats obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A701C-0x00000001853A7044
	~AkMemGlobalStats(); // 0x00000001853A6E18-0x00000001853A6E8C
	public void Dispose(); // 0x00000001853A6DC8-0x00000001853A6E18
	protected virtual void Dispose(bool disposing); // 0x00000001853A6CB4-0x00000001853A6DC8
}

public enum AkMemID : uint // TypeDefIndex: 56630
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

public enum AkMeteringFlags // TypeDefIndex: 56631
{
	AK_NoMetering = 0,
	AK_EnableBusMeter_Peak = 1,
	AK_EnableBusMeter_TruePeak = 2,
	AK_EnableBusMeter_RMS = 4,
	AK_EnableBusMeter_KPower = 16,
	AK_EnableBusMeter_3DMeter = 32
}

public enum AkMIDICcTypes // TypeDefIndex: 56632
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

public class AkMIDIEvent : IDisposable // TypeDefIndex: 56641
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public byte byChan { get; set; } // 0x00000001853A4FF0-0x00000001853A5040 0x00000001853A57C8-0x00000001853A581C
	public tGen Gen { get; set; } // 0x00000001853A4BC8-0x00000001853A4C44 0x00000001853A5408-0x00000001853A5470
	public tCc Cc { get; set; } // 0x00000001853A4AD0-0x00000001853A4B4C 0x00000001853A5338-0x00000001853A53A0
	public tNoteOnOff NoteOnOff { get; set; } // 0x00000001853A4CC0-0x00000001853A4D3C 0x00000001853A54D8-0x00000001853A5540
	public tPitchBend PitchBend { get; set; } // 0x00000001853A4D3C-0x00000001853A4DB8 0x00000001853A5540-0x00000001853A55A8
	public tNoteAftertouch NoteAftertouch { get; set; } // 0x00000001853A4C44-0x00000001853A4CC0 0x00000001853A5470-0x00000001853A54D8
	public tChanAftertouch ChanAftertouch { get; set; } // 0x00000001853A4B4C-0x00000001853A4BC8 0x00000001853A53A0-0x00000001853A5408
	public tProgramChange ProgramChange { get; set; } // 0x00000001853A4DB8-0x00000001853A4E34 0x00000001853A55A8-0x00000001853A5610
	public tWwiseCmd WwiseCmd { get; set; } // 0x00000001853A4E34-0x00000001853A4EB0 0x00000001853A5610-0x00000001853A5678
	public AkMIDIEventTypes byType { get; set; } // 0x00000001853A5130-0x00000001853A5180 0x00000001853A5918-0x00000001853A596C
	public byte byOnOffNote { get; set; } // 0x00000001853A5090-0x00000001853A50E0 0x00000001853A5870-0x00000001853A58C4
	public byte byVelocity { get; set; } // 0x00000001853A5220-0x00000001853A5270 0x00000001853A5A14-0x00000001853A5A68
	public AkMIDICcTypes byCc { get; set; } // 0x00000001853A4F50-0x00000001853A4FA0 0x00000001853A5720-0x00000001853A5774
	public byte byCcValue { get; set; } // 0x00000001853A4F00-0x00000001853A4F50 0x00000001853A56CC-0x00000001853A5720
	public byte byValueLsb { get; set; } // 0x00000001853A5180-0x00000001853A51D0 0x00000001853A596C-0x00000001853A59C0
	public byte byValueMsb { get; set; } // 0x00000001853A51D0-0x00000001853A5220 0x00000001853A59C0-0x00000001853A5A14
	public byte byAftertouchNote { get; set; } // 0x00000001853A4EB0-0x00000001853A4F00 0x00000001853A5678-0x00000001853A56CC
	public byte byNoteAftertouchValue { get; set; } // 0x00000001853A5040-0x00000001853A5090 0x00000001853A581C-0x00000001853A5870
	public byte byChanAftertouchValue { get; set; } // 0x00000001853A4FA0-0x00000001853A4FF0 0x00000001853A5774-0x00000001853A57C8
	public byte byProgramNum { get; set; } // 0x00000001853A50E0-0x00000001853A5130 0x00000001853A58C4-0x00000001853A5918
	public ushort uCmd { get; set; } // 0x00000001853A52C0-0x00000001853A5310 0x00000001853A5ABC-0x00000001853A5B10
	public uint uArg { get; set; } // 0x00000001853A5270-0x00000001853A52C0 0x00000001853A5A68-0x00000001853A5ABC

	// Nested types
	public class tGen : IDisposable // TypeDefIndex: 56633
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byParam1 { get; set; } // 0x00000001853CA00C-0x00000001853CA05C 0x00000001853CA0D4-0x00000001853CA128
		public byte byParam2 { get; set; } // 0x00000001853CA05C-0x00000001853CA0AC 0x00000001853CA128-0x00000001853CA17C

		// Constructors
		internal tGen(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
		public tGen(); // 0x00000001853C9FBC-0x00000001853CA00C

		// Methods
		internal static IntPtr getCPtr(tGen obj); // 0x000000018539B720-0x000000018539B730
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853CA0AC-0x00000001853CA0D4
		~tGen(); // 0x00000001853C9F48-0x00000001853C9FBC
		public void Dispose(); // 0x00000001853C9DE4-0x00000001853C9E34
		protected virtual void Dispose(bool disposing); // 0x00000001853C9E34-0x00000001853C9F48
	}

	public class tNoteOnOff : IDisposable // TypeDefIndex: 56634
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byNote { get; set; } // 0x00000001853CA73C-0x00000001853CA78C 0x00000001853CA804-0x00000001853CA858
		public byte byVelocity { get; set; } // 0x00000001853CA78C-0x00000001853CA7DC 0x00000001853CA858-0x00000001853CA8AC

		// Constructors
		internal tNoteOnOff(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
		public tNoteOnOff(); // 0x00000001853CA6EC-0x00000001853CA73C

		// Methods
		internal static IntPtr getCPtr(tNoteOnOff obj); // 0x000000018539B720-0x000000018539B730
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853CA7DC-0x00000001853CA804
		~tNoteOnOff(); // 0x00000001853CA678-0x00000001853CA6EC
		public void Dispose(); // 0x00000001853CA514-0x00000001853CA564
		protected virtual void Dispose(bool disposing); // 0x00000001853CA564-0x00000001853CA678
	}

	public class tCc : IDisposable // TypeDefIndex: 56635
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byCc { get; set; } // 0x00000001853C9980-0x00000001853C99D0 0x00000001853C9A48-0x00000001853C9A9C
		public byte byValue { get; set; } // 0x00000001853C99D0-0x00000001853C9A20 0x00000001853C9A9C-0x00000001853C9AF0

		// Constructors
		internal tCc(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
		public tCc(); // 0x00000001853C9930-0x00000001853C9980

		// Methods
		internal static IntPtr getCPtr(tCc obj); // 0x000000018539B720-0x000000018539B730
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C9A20-0x00000001853C9A48
		~tCc(); // 0x00000001853C98BC-0x00000001853C9930
		public void Dispose(); // 0x00000001853C986C-0x00000001853C98BC
		protected virtual void Dispose(bool disposing); // 0x00000001853C9758-0x00000001853C986C
	}

	public class tPitchBend : IDisposable // TypeDefIndex: 56636
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byValueLsb { get; set; } // 0x00000001853CAAD4-0x00000001853CAB24 0x00000001853CAB9C-0x00000001853CABF0
		public byte byValueMsb { get; set; } // 0x00000001853CAB24-0x00000001853CAB74 0x00000001853CABF0-0x00000001853CAC44

		// Constructors
		internal tPitchBend(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
		public tPitchBend(); // 0x00000001853CAA84-0x00000001853CAAD4

		// Methods
		internal static IntPtr getCPtr(tPitchBend obj); // 0x000000018539B720-0x000000018539B730
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853CAB74-0x00000001853CAB9C
		~tPitchBend(); // 0x00000001853CAA10-0x00000001853CAA84
		public void Dispose(); // 0x00000001853CA9C0-0x00000001853CAA10
		protected virtual void Dispose(bool disposing); // 0x00000001853CA8AC-0x00000001853CA9C0
	}

	public class tNoteAftertouch : IDisposable // TypeDefIndex: 56637
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byNote { get; set; } // 0x00000001853CA3A4-0x00000001853CA3F4 0x00000001853CA46C-0x00000001853CA4C0
		public byte byValue { get; set; } // 0x00000001853CA3F4-0x00000001853CA444 0x00000001853CA4C0-0x00000001853CA514

		// Constructors
		internal tNoteAftertouch(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
		public tNoteAftertouch(); // 0x00000001853CA354-0x00000001853CA3A4

		// Methods
		internal static IntPtr getCPtr(tNoteAftertouch obj); // 0x000000018539B720-0x000000018539B730
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853CA444-0x00000001853CA46C
		~tNoteAftertouch(); // 0x00000001853CA2E0-0x00000001853CA354
		public void Dispose(); // 0x00000001853CA290-0x00000001853CA2E0
		protected virtual void Dispose(bool disposing); // 0x00000001853CA17C-0x00000001853CA290
	}

	public class tChanAftertouch : IDisposable // TypeDefIndex: 56638
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byValue { get; set; } // 0x00000001853C9D18-0x00000001853C9D68 0x00000001853C9D90-0x00000001853C9DE4

		// Constructors
		internal tChanAftertouch(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
		public tChanAftertouch(); // 0x00000001853C9CC8-0x00000001853C9D18

		// Methods
		internal static IntPtr getCPtr(tChanAftertouch obj); // 0x000000018539B720-0x000000018539B730
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C9D68-0x00000001853C9D90
		~tChanAftertouch(); // 0x00000001853C9C54-0x00000001853C9CC8
		public void Dispose(); // 0x00000001853C9AF0-0x00000001853C9B40
		protected virtual void Dispose(bool disposing); // 0x00000001853C9B40-0x00000001853C9C54
	}

	public class tProgramChange : IDisposable // TypeDefIndex: 56639
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public byte byProgramNum { get; set; } // 0x00000001853CAE6C-0x00000001853CAEBC 0x00000001853CAEE4-0x00000001853CAF38

		// Constructors
		internal tProgramChange(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
		public tProgramChange(); // 0x00000001853CAE1C-0x00000001853CAE6C

		// Methods
		internal static IntPtr getCPtr(tProgramChange obj); // 0x000000018539B720-0x000000018539B730
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853CAEBC-0x00000001853CAEE4
		~tProgramChange(); // 0x00000001853CADA8-0x00000001853CAE1C
		public void Dispose(); // 0x00000001853CAC44-0x00000001853CAC94
		protected virtual void Dispose(bool disposing); // 0x00000001853CAC94-0x00000001853CADA8
	}

	public class tWwiseCmd : IDisposable // TypeDefIndex: 56640
	{
		// Fields
		private IntPtr swigCPtr; // 0x10
		protected bool swigCMemOwn; // 0x18

		// Properties
		public ushort uCmd { get; set; } // 0x00000001853CB1B0-0x00000001853CB200 0x00000001853CB27C-0x00000001853CB2D0
		public uint uArg { get; set; } // 0x00000001853CB160-0x00000001853CB1B0 0x00000001853CB228-0x00000001853CB27C

		// Constructors
		internal tWwiseCmd(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
		public tWwiseCmd(); // 0x00000001853CB110-0x00000001853CB160

		// Methods
		internal static IntPtr getCPtr(tWwiseCmd obj); // 0x000000018539B720-0x000000018539B730
		internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853CB200-0x00000001853CB228
		~tWwiseCmd(); // 0x00000001853CB09C-0x00000001853CB110
		public void Dispose(); // 0x00000001853CAF38-0x00000001853CAF88
		protected virtual void Dispose(bool disposing); // 0x00000001853CAF88-0x00000001853CB09C
	}

	// Constructors
	internal AkMIDIEvent(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkMIDIEvent(); // 0x00000001853A4A80-0x00000001853A4AD0

	// Methods
	internal static IntPtr getCPtr(AkMIDIEvent obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A5310-0x00000001853A5338
	~AkMIDIEvent(); // 0x000000018539E544-0x000000018539E5BC
	public void Dispose(); // 0x00000001853A491C-0x00000001853A496C
	protected virtual void Dispose(bool disposing); // 0x00000001853A496C-0x00000001853A4A80
}

public class AkMIDIEventCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 56642
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public byte byChan { get; } // 0x00000001853A459C-0x00000001853A45EC 
	public byte byParam1 { get; } // 0x00000001853A468C-0x00000001853A46DC 
	public byte byParam2 { get; } // 0x00000001853A46DC-0x00000001853A472C 
	public AkMIDIEventTypes byType { get; } // 0x00000001853A477C-0x00000001853A47CC 
	public byte byOnOffNote { get; } // 0x00000001853A463C-0x00000001853A468C 
	public byte byVelocity { get; } // 0x00000001853A486C-0x00000001853A48BC 
	public AkMIDICcTypes byCc { get; } // 0x00000001853A44FC-0x00000001853A454C 
	public byte byCcValue { get; } // 0x00000001853A44AC-0x00000001853A44FC 
	public byte byValueLsb { get; } // 0x00000001853A47CC-0x00000001853A481C 
	public byte byValueMsb { get; } // 0x00000001853A481C-0x00000001853A486C 
	public byte byAftertouchNote { get; } // 0x00000001853A445C-0x00000001853A44AC 
	public byte byNoteAftertouchValue { get; } // 0x00000001853A45EC-0x00000001853A463C 
	public byte byChanAftertouchValue { get; } // 0x00000001853A454C-0x00000001853A459C 
	public byte byProgramNum { get; } // 0x00000001853A472C-0x00000001853A477C 

	// Constructors
	internal AkMIDIEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000183F33A30-0x0000000183F33AB0
	public AkMIDIEventCallbackInfo(); // 0x00000001853A440C-0x00000001853A445C

	// Methods
	internal static IntPtr getCPtr(AkMIDIEventCallbackInfo obj); // 0x00000001853A1158-0x00000001853A1168
	internal override void setCPtr(IntPtr cPtr); // 0x00000001853A48BC-0x00000001853A491C
	protected override void Dispose(bool disposing); // 0x00000001853A42DC-0x00000001853A440C
}

public enum AkMIDIEventTypes // TypeDefIndex: 56643
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

public class AkMIDIPost : AkMIDIEvent // TypeDefIndex: 56644
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public ulong uOffset { get; set; } // 0x00000001853A6434-0x00000001853A6484 0x00000001853A64E4-0x00000001853A6538

	// Constructors
	internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn); // 0x00000001853A637C-0x00000001853A63E4
	public AkMIDIPost(); // 0x00000001853A63E4-0x00000001853A6434

	// Methods
	internal static IntPtr getCPtr(AkMIDIPost obj); // 0x00000001853A14D8-0x00000001853A14E8
	internal override void setCPtr(IntPtr cPtr); // 0x00000001853A6484-0x00000001853A64E4
	protected override void Dispose(bool disposing); // 0x00000001853A5B78-0x00000001853A5CA8
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts); // 0x00000001853A5ED8-0x00000001853A5F74
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets); // 0x00000001853A5F74-0x00000001853A6018
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x00000001853A60C4-0x00000001853A61D8
	public uint PostOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID); // 0x00000001853A5CE8-0x00000001853A5E04
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts); // 0x00000001853A62D8-0x00000001853A637C
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets); // 0x00000001853A6018-0x00000001853A60C4
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x00000001853A5E04-0x00000001853A5ED8
	public uint PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID); // 0x00000001853A61D8-0x00000001853A62D8
	public void Clone(AkMIDIPost other); // 0x00000001853A5B10-0x00000001853A5B78
	public static int GetSizeOf(); // 0x00000001853A5CA8-0x00000001853A5CE8
}

public enum AkMonitorErrorCode // TypeDefIndex: 56645
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

public enum AkMonitorErrorLevel // TypeDefIndex: 56646
{
	ErrorLevel_Message = 1,
	ErrorLevel_Error = 2,
	ErrorLevel_All = 3
}

public class AkMonitoringCallbackInfo : IDisposable // TypeDefIndex: 56647
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkMonitorErrorCode errorCode { get; } // 0x00000001853A73BC-0x00000001853A740C 
	public AkMonitorErrorLevel errorLevel { get; } // 0x00000001853A740C-0x00000001853A745C 
	public uint playingID { get; } // 0x00000001853A7518-0x00000001853A7568 
	public ulong gameObjID { get; } // 0x00000001853A745C-0x00000001853A74AC 
	public string message { get; } // 0x00000001853A74AC-0x00000001853A7518 

	// Constructors
	internal AkMonitoringCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkMonitoringCallbackInfo(); // 0x00000001853A736C-0x00000001853A73BC

	// Methods
	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A7568-0x00000001853A7590
	~AkMonitoringCallbackInfo(); // 0x00000001853A72F8-0x00000001853A736C
	public void Dispose(); // 0x00000001853A72A8-0x00000001853A72F8
	protected virtual void Dispose(bool disposing); // 0x00000001853A7194-0x00000001853A72A8
}

public enum AkMultiPositionType // TypeDefIndex: 56648
{
	MultiPositionType_SingleSource = 0,
	MultiPositionType_MultiSources = 1,
	MultiPositionType_MultiDirections = 2
}

public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo // TypeDefIndex: 56649
{
	// Fields
	private IntPtr swigCPtr; // 0x28

	// Properties
	public uint playlistID { get; } // 0x00000001853A7710-0x00000001853A7760 
	public uint uNumPlaylistItems { get; } // 0x00000001853A7760-0x00000001853A77B0 
	public uint uPlaylistSelection { get; } // 0x00000001853A7800-0x00000001853A7850 
	public uint uPlaylistItemDone { get; } // 0x00000001853A77B0-0x00000001853A7800 

	// Constructors
	internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000183F33930-0x0000000183F339B0
	public AkMusicPlaylistCallbackInfo(); // 0x00000001853A76C0-0x00000001853A7710

	// Methods
	internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj); // 0x00000001853A1158-0x00000001853A1168
	internal override void setCPtr(IntPtr cPtr); // 0x00000001853A7850-0x00000001853A78B0
	protected override void Dispose(bool disposing); // 0x00000001853A7590-0x00000001853A76C0
}

public class AkMusicSettings : IDisposable // TypeDefIndex: 56650
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fStreamingLookAheadRatio { get; set; } // 0x00000001853A7900-0x00000001853A7950 0x000000018400B340-0x000000018400B3A0

	// Constructors
	internal AkMusicSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50

	// Methods
	internal static IntPtr getCPtr(AkMusicSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A7950-0x00000001853A7978
	~AkMusicSettings(); // 0x0000000184A3DEF0-0x0000000184A3DF40
	public void Dispose(); // 0x00000001853A78B0-0x00000001853A7900
	protected virtual void Dispose(bool disposing); // 0x0000000184A3DF40-0x0000000184A3E0F0
}

public class AkMusicSyncCallbackInfo : AkCallbackInfo // TypeDefIndex: 56651
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Properties
	public uint playingID { get; } // 0x00000001853A7B48-0x00000001853A7B98 
	public int segmentInfo_iCurrentPosition { get; } // 0x00000001853A7D28-0x00000001853A7D78 
	public int segmentInfo_iPreEntryDuration { get; } // 0x00000001853A7DC8-0x00000001853A7E18 
	public int segmentInfo_iActiveDuration { get; } // 0x00000001853A7CD8-0x00000001853A7D28 
	public int segmentInfo_iPostExitDuration { get; } // 0x00000001853A7D78-0x00000001853A7DC8 
	public int segmentInfo_iRemainingLookAheadTime { get; } // 0x00000001853A7E18-0x00000001853A7E68 
	public float segmentInfo_fBeatDuration { get; } // 0x00000001853A7BE8-0x00000001853A7C38 
	public float segmentInfo_fBarDuration { get; } // 0x00000001853A7B98-0x00000001853A7BE8 
	public float segmentInfo_fGridDuration { get; } // 0x00000001853A7C38-0x00000001853A7C88 
	public float segmentInfo_fGridOffset { get; } // 0x00000001853A7C88-0x00000001853A7CD8 
	public AkCallbackType musicSyncType { get; } // 0x00000001853A7AF8-0x00000001853A7B48 
	public string userCueName { get; } // 0x00000001853A7E68-0x00000001853A7ED4 

	// Constructors
	internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000183F337D0-0x0000000183F33840
	public AkMusicSyncCallbackInfo(); // 0x00000001853A7AA8-0x00000001853A7AF8

	// Methods
	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj); // 0x00000001853A14D8-0x00000001853A14E8
	internal override void setCPtr(IntPtr cPtr); // 0x00000001853A7ED4-0x00000001853A7F34
	protected override void Dispose(bool disposing); // 0x00000001853A7978-0x00000001853A7AA8
}

public class AkObjectInfo : IDisposable // TypeDefIndex: 56652
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint objID { get; set; } // 0x00000001853A82A4-0x00000001853A82F4 0x00000001853A83C0-0x00000001853A8414
	public uint parentID { get; set; } // 0x00000001853A82F4-0x00000001853A8344 0x00000001853A8414-0x00000001853A8468
	public int iDepth { get; set; } // 0x00000001853A8254-0x00000001853A82A4 0x00000001853A836C-0x00000001853A83C0

	// Constructors
	internal AkObjectInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkObjectInfo(); // 0x00000001853A8204-0x00000001853A8254

	// Methods
	internal static IntPtr getCPtr(AkObjectInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A8344-0x00000001853A836C
	~AkObjectInfo(); // 0x00000001853A8150-0x00000001853A81C4
	public void Dispose(); // 0x00000001853A8100-0x00000001853A8150
	protected virtual void Dispose(bool disposing); // 0x00000001853A7FEC-0x00000001853A8100
	public void Clear(); // 0x00000001853A7F34-0x00000001853A7F84
	public static int GetSizeOf(); // 0x00000001853A81C4-0x00000001853A8204
	public void Clone(AkObjectInfo other); // 0x00000001853A7F84-0x00000001853A7FEC
}

public class AkObstructionOcclusionValues : IDisposable // TypeDefIndex: 56653
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float occlusion { get; set; } // 0x00000001853A87D8-0x00000001853A8828 0x00000001853A88A8-0x00000001853A8900
	public float obstruction { get; set; } // 0x00000001853A8788-0x00000001853A87D8 0x00000001853A8850-0x00000001853A88A8

	// Constructors
	internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkObstructionOcclusionValues(); // 0x00000001853A8738-0x00000001853A8788

	// Methods
	internal static IntPtr getCPtr(AkObstructionOcclusionValues obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A8828-0x00000001853A8850
	~AkObstructionOcclusionValues(); // 0x00000001853A8684-0x00000001853A86F8
	public void Dispose(); // 0x00000001853A8634-0x00000001853A8684
	protected virtual void Dispose(bool disposing); // 0x00000001853A8520-0x00000001853A8634
	public void Clear(); // 0x00000001853A8468-0x00000001853A84B8
	public static int GetSizeOf(); // 0x00000001853A86F8-0x00000001853A8738
	public void Clone(AkObstructionOcclusionValues other); // 0x00000001853A84B8-0x00000001853A8520
}

public class AkOutputSettings : IDisposable // TypeDefIndex: 56654
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioDeviceShareset { get; set; } // 0x00000001853A8B74-0x00000001853A8BC4 0x00000001845E23D0-0x00000001845E2430
	public uint idDevice { get; set; } // 0x00000001853A8C14-0x00000001853A8C64 0x00000001845E2330-0x00000001845E2390
	public AkPanningRule ePanningRule { get; set; } // 0x00000001853A8BC4-0x00000001853A8C14 0x00000001845E2290-0x00000001845E22F0
	public AkChannelConfig channelConfig { get; set; } // 0x00000001845E20E0-0x00000001845E2170 0x00000001853A8C8C-0x00000001853A8CF4

	// Constructors
	internal AkOutputSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkOutputSettings(); // 0x00000001853A8B24-0x00000001853A8B74
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning); // 0x00000001853A8A9C-0x00000001853A8B24
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig); // 0x00000001853A89A8-0x00000001853A8A34
	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice); // 0x00000001853A8A34-0x00000001853A8A9C
	public AkOutputSettings(string in_szDeviceShareSet); // 0x00000001853A8950-0x00000001853A89A8

	// Methods
	internal static IntPtr getCPtr(AkOutputSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A8C64-0x00000001853A8C8C
	~AkOutputSettings(); // 0x0000000184A3DCF0-0x0000000184A3DD40
	public void Dispose(); // 0x00000001853A8900-0x00000001853A8950
	protected virtual void Dispose(bool disposing); // 0x0000000184A3DD40-0x0000000184A3DEF0
}

public enum AkPanningRule // TypeDefIndex: 56655
{
	AkPanningRule_Speakers = 0,
	AkPanningRule_Headphones = 1
}

public class AkPlaylist : AkPlaylistArray // TypeDefIndex: 56656
{
	// Fields
	private IntPtr swigCPtr; // 0x20

	// Constructors
	internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn); // 0x00000001853AABF8-0x00000001853AAC60
	public AkPlaylist(); // 0x00000001853AABA8-0x00000001853AABF8

	// Methods
	internal static IntPtr getCPtr(AkPlaylist obj); // 0x00000001853A14D8-0x00000001853A14E8
	internal override void setCPtr(IntPtr cPtr); // 0x00000001853AAC60-0x00000001853AACC0
	protected override void Dispose(bool disposing); // 0x00000001853AA818-0x00000001853AA948
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x00000001853AAA80-0x00000001853AAB30
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals); // 0x00000001853AA9AC-0x00000001853AAA2C
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo); // 0x00000001853AAB30-0x00000001853AABA8
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay); // 0x00000001853AA948-0x00000001853AA9AC
	public AKRESULT Enqueue(uint in_audioNodeID); // 0x00000001853AAA2C-0x00000001853AAA80
}

public class AkPlaylistArray : IDisposable // TypeDefIndex: 56657
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkPlaylistArray(); // 0x00000001853AA180-0x00000001853AA1D0

	// Methods
	internal static IntPtr getCPtr(AkPlaylistArray obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853AA1D0-0x00000001853AA1F8
	~AkPlaylistArray(); // 0x000000018539E544-0x000000018539E5BC
	public void Dispose(); // 0x00000001853A96B4-0x00000001853A9704
	protected virtual void Dispose(bool disposing); // 0x00000001853A95A0-0x00000001853A96B4
	public AkIterator Begin(); // 0x00000001853A9448-0x00000001853A94BC
	public AkIterator End(); // 0x00000001853A9704-0x00000001853A9778
	public AkIterator FindEx(AkPlaylistItem in_Item); // 0x00000001853A99D8-0x00000001853A9A68
	public AkIterator Erase(AkIterator in_rIter); // 0x00000001853A985C-0x00000001853A98EC
	public void Erase(uint in_uIndex); // 0x00000001853A98EC-0x00000001853A9940
	public AkIterator EraseSwap(AkIterator in_rIter); // 0x00000001853A9778-0x00000001853A9808
	public void EraseSwap(uint in_uIndex); // 0x00000001853A9808-0x00000001853A985C
	public bool IsGrowingAllowed(); // 0x00000001853A9C74-0x00000001853A9CC4
	public AKRESULT Reserve(uint in_ulReserve); // 0x00000001853A9FD0-0x00000001853AA024
	public AKRESULT ReserveExtra(uint in_ulReserve); // 0x00000001853A9F7C-0x00000001853A9FD0
	public uint Reserved(); // 0x00000001853AA024-0x00000001853AA074
	public void Term(); // 0x00000001853AA0C8-0x00000001853AA118
	public uint Length(); // 0x00000001853A9DBC-0x00000001853A9E0C
	public AkPlaylistItem Data(); // 0x00000001853A9524-0x00000001853A95A0
	public bool IsEmpty(); // 0x00000001853A9C24-0x00000001853A9C74
	public AkPlaylistItem Exists(AkPlaylistItem in_Item); // 0x00000001853A9940-0x00000001853A99D8
	public AkPlaylistItem AddLast(); // 0x00000001853A9334-0x00000001853A93B0
	public AkPlaylistItem AddLast(AkPlaylistItem in_rItem); // 0x00000001853A93B0-0x00000001853A9448
	public AkPlaylistItem Last(); // 0x00000001853A9D48-0x00000001853A9DBC
	public void RemoveLast(); // 0x00000001853A9E5C-0x00000001853A9EAC
	public AKRESULT Remove(AkPlaylistItem in_rItem); // 0x00000001853A9F14-0x00000001853A9F7C
	public AKRESULT RemoveSwap(AkPlaylistItem in_rItem); // 0x00000001853A9EAC-0x00000001853A9F14
	public void RemoveAll(); // 0x00000001853A9E0C-0x00000001853A9E5C
	public AkPlaylistItem ItemAtIndex(uint uiIndex); // 0x00000001853A9CC4-0x00000001853A9D48
	public AkIterator Insert(AkIterator in_rIter); // 0x00000001853A9B94-0x00000001853A9C24
	public AkPlaylistItem Insert(uint in_uIndex); // 0x00000001853A9B0C-0x00000001853A9B94
	public bool GrowArray(); // 0x00000001853A9A68-0x00000001853A9AB8
	public bool GrowArray(uint in_uGrowBy); // 0x00000001853A9AB8-0x00000001853A9B0C
	public bool Resize(uint in_uiSize); // 0x00000001853AA074-0x00000001853AA0C8
	public void Transfer(AkPlaylistArray in_rSource); // 0x00000001853AA118-0x00000001853AA180
	public AKRESULT Copy(AkPlaylistArray in_rSource); // 0x00000001853A94BC-0x00000001853A9524
}

public class AkPlaylistItem : IDisposable // TypeDefIndex: 56658
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioNodeID { get; set; } // 0x00000001853AA604-0x00000001853AA654 0x00000001853AA71C-0x00000001853AA770
	public int msDelay { get; set; } // 0x00000001853AA654-0x00000001853AA6A4 0x00000001853AA770-0x00000001853AA7C4
	public IntPtr pCustomInfo { get; set; } // 0x00000001853AA6A4-0x00000001853AA6F4 0x00000001853AA7C4-0x00000001853AA818

	// Constructors
	internal AkPlaylistItem(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkPlaylistItem(); // 0x00000001853AA548-0x00000001853AA598
	public AkPlaylistItem(AkPlaylistItem in_rCopy); // 0x00000001853AA598-0x00000001853AA604

	// Methods
	internal static IntPtr getCPtr(AkPlaylistItem obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853AA6F4-0x00000001853AA71C
	~AkPlaylistItem(); // 0x00000001853AA3EC-0x00000001853AA460
	public void Dispose(); // 0x00000001853AA39C-0x00000001853AA3EC
	protected virtual void Dispose(bool disposing); // 0x00000001853AA288-0x00000001853AA39C
	public AkPlaylistItem Assign(AkPlaylistItem in_rCopy); // 0x00000001853AA1F8-0x00000001853AA288
	public bool IsEqualTo(AkPlaylistItem in_rCopy); // 0x00000001853AA460-0x00000001853AA4C8
	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc); // 0x00000001853AA4C8-0x00000001853AA548
}

public enum AkPluginType // TypeDefIndex: 56659
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

public class AkPositioningData : IDisposable // TypeDefIndex: 56660
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Ak3dData threeD { get; set; } // 0x00000001853AAF64-0x00000001853AAFE0 0x00000001853AB070-0x00000001853AB0D8
	public AkBehavioralPositioningData behavioral { get; set; } // 0x00000001853AAEE8-0x00000001853AAF64 0x00000001853AB008-0x00000001853AB070

	// Constructors
	internal AkPositioningData(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkPositioningData(); // 0x00000001853AAE98-0x00000001853AAEE8

	// Methods
	internal static IntPtr getCPtr(AkPositioningData obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853AAFE0-0x00000001853AB008
	~AkPositioningData(); // 0x00000001853AAE24-0x00000001853AAE98
	public void Dispose(); // 0x00000001853AACC0-0x00000001853AAD10
	protected virtual void Dispose(bool disposing); // 0x00000001853AAD10-0x00000001853AAE24
}

public class AkPositioningInfo : IDisposable // TypeDefIndex: 56661
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fCenterPct { get; set; } // 0x00000001853AB5D0-0x00000001853AB620 0x00000001853ABBCC-0x00000001853ABC24
	public AkSpeakerPanningType pannerType { get; set; } // 0x00000001853AB850-0x00000001853AB8A0 0x00000001853ABE8C-0x00000001853ABEE0
	public Ak3DPositionType e3dPositioningType { get; set; } // 0x00000001853AB580-0x00000001853AB5D0 0x00000001853ABB78-0x00000001853ABBCC
	public bool bHoldEmitterPosAndOrient { get; set; } // 0x00000001853AB490-0x00000001853AB4E0 0x00000001853ABA7C-0x00000001853ABAD0
	public Ak3DSpatializationMode e3DSpatializationMode { get; set; } // 0x00000001853AB530-0x00000001853AB580 0x00000001853ABB24-0x00000001853ABB78
	public bool bEnableAttenuation { get; set; } // 0x00000001853AB440-0x00000001853AB490 0x00000001853ABA28-0x00000001853ABA7C
	public bool bUseConeAttenuation { get; set; } // 0x00000001853AB4E0-0x00000001853AB530 0x00000001853ABAD0-0x00000001853ABB24
	public float fInnerAngle { get; set; } // 0x00000001853AB670-0x00000001853AB6C0 0x00000001853ABC7C-0x00000001853ABCD4
	public float fOuterAngle { get; set; } // 0x00000001853AB710-0x00000001853AB760 0x00000001853ABD2C-0x00000001853ABD84
	public float fConeMaxAttenuation { get; set; } // 0x00000001853AB620-0x00000001853AB670 0x00000001853ABC24-0x00000001853ABC7C
	public float LPFCone { get; set; } // 0x00000001853AB3A0-0x00000001853AB3F0 0x00000001853AB978-0x00000001853AB9D0
	public float HPFCone { get; set; } // 0x00000001853AB300-0x00000001853AB350 0x00000001853AB8C8-0x00000001853AB920
	public float fMaxDistance { get; set; } // 0x00000001853AB6C0-0x00000001853AB710 0x00000001853ABCD4-0x00000001853ABD2C
	public float fVolDryAtMaxDist { get; set; } // 0x00000001853AB800-0x00000001853AB850 0x00000001853ABE34-0x00000001853ABE8C
	public float fVolAuxGameDefAtMaxDist { get; set; } // 0x00000001853AB760-0x00000001853AB7B0 0x00000001853ABD84-0x00000001853ABDDC
	public float fVolAuxUserDefAtMaxDist { get; set; } // 0x00000001853AB7B0-0x00000001853AB800 0x00000001853ABDDC-0x00000001853ABE34
	public float LPFValueAtMaxDist { get; set; } // 0x00000001853AB3F0-0x00000001853AB440 0x00000001853AB9D0-0x00000001853ABA28
	public float HPFValueAtMaxDist { get; set; } // 0x00000001853AB350-0x00000001853AB3A0 0x00000001853AB920-0x00000001853AB978

	// Constructors
	internal AkPositioningInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkPositioningInfo(); // 0x00000001853AB2B0-0x00000001853AB300

	// Methods
	internal static IntPtr getCPtr(AkPositioningInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853AB8A0-0x00000001853AB8C8
	~AkPositioningInfo(); // 0x00000001853AB23C-0x00000001853AB2B0
	public void Dispose(); // 0x00000001853AB0D8-0x00000001853AB128
	protected virtual void Dispose(bool disposing); // 0x00000001853AB128-0x00000001853AB23C
}

public enum AkPreparationType // TypeDefIndex: 56662
{
	Preparation_Load = 0,
	Preparation_Unload = 1,
	Preparation_LoadAndDecode = 2
}

public enum AkQueryRTPCValue // TypeDefIndex: 56663
{
	RTPCValue_Default = 0,
	RTPCValue_Global = 1,
	RTPCValue_GameObject = 2,
	RTPCValue_PlayingID = 3,
	RTPCValue_Unavailable = 4
}

public class AkRamp : IDisposable // TypeDefIndex: 56664
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float fPrev { get; set; } // 0x00000001853AC1C0-0x00000001853AC210 0x00000001853AC290-0x00000001853AC2E8
	public float fNext { get; set; } // 0x00000001853AC170-0x00000001853AC1C0 0x00000001853AC238-0x00000001853AC290

	// Constructors
	internal AkRamp(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkRamp(); // 0x00000001853AC120-0x00000001853AC170
	public AkRamp(float in_fPrev, float in_fNext); // 0x00000001853AC0B8-0x00000001853AC120

	// Methods
	internal static IntPtr getCPtr(AkRamp obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853AC210-0x00000001853AC238
	~AkRamp(); // 0x00000001853AC044-0x00000001853AC0B8
	public void Dispose(); // 0x00000001853ABFF4-0x00000001853AC044
	protected virtual void Dispose(bool disposing); // 0x00000001853ABEE0-0x00000001853ABFF4
}

public class AkReflectionPathInfo : IDisposable // TypeDefIndex: 56665
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkVector64 imageSource { get; set; } // 0x00000001853AC708-0x00000001853AC774 0x00000001853AC8DC-0x00000001853AC948
	public uint numPathPoints { get; set; } // 0x00000001853AC814-0x00000001853AC864 0x00000001853AC9F4-0x00000001853ACA48
	public uint numReflections { get; set; } // 0x00000001853AC864-0x00000001853AC8B4 0x00000001853ACA48-0x00000001853ACA9C
	public float level { get; set; } // 0x00000001853AC7C4-0x00000001853AC814 0x00000001853AC99C-0x00000001853AC9F4
	public bool isOccluded { get; set; } // 0x00000001853AC774-0x00000001853AC7C4 0x00000001853AC948-0x00000001853AC99C

	// Constructors
	internal AkReflectionPathInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkReflectionPathInfo(); // 0x00000001853AC6B8-0x00000001853AC708

	// Methods
	internal static IntPtr getCPtr(AkReflectionPathInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853AC8B4-0x00000001853AC8DC
	~AkReflectionPathInfo(); // 0x00000001853AC4B4-0x00000001853AC528
	public void Dispose(); // 0x00000001853AC350-0x00000001853AC3A0
	protected virtual void Dispose(bool disposing); // 0x00000001853AC3A0-0x00000001853AC4B4
	public static int GetSizeOf(); // 0x00000001853AC678-0x00000001853AC6B8
	public Vector3 GetPathPoint(uint idx); // 0x00000001853AC600-0x00000001853AC678
	public AkAcousticSurface GetAcousticSurface(uint idx); // 0x00000001853AC528-0x00000001853AC5AC
	public float GetDiffraction(uint idx); // 0x00000001853AC5AC-0x00000001853AC600
	public void Clone(AkReflectionPathInfo other); // 0x00000001853AC2E8-0x00000001853AC350
}

public class AkResourceMonitorDataSummary : IDisposable // TypeDefIndex: 56666
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public float totalCPU { get; set; } // 0x00000001853ACDB4-0x00000001853ACE04 0x00000001853ACFCC-0x00000001853AD024
	public float pluginCPU { get; set; } // 0x00000001853ACD64-0x00000001853ACDB4 0x00000001853ACF74-0x00000001853ACFCC
	public uint physicalVoices { get; set; } // 0x00000001853ACD14-0x00000001853ACD64 0x00000001853ACF20-0x00000001853ACF74
	public uint virtualVoices { get; set; } // 0x00000001853ACE54-0x00000001853ACEA4 0x00000001853AD078-0x00000001853AD0CC
	public uint totalVoices { get; set; } // 0x00000001853ACE04-0x00000001853ACE54 0x00000001853AD024-0x00000001853AD078
	public uint nbActiveEvents { get; set; } // 0x00000001853ACCC4-0x00000001853ACD14 0x00000001853ACECC-0x00000001853ACF20

	// Constructors
	internal AkResourceMonitorDataSummary(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkResourceMonitorDataSummary(); // 0x00000001853ACC74-0x00000001853ACCC4

	// Methods
	internal static IntPtr getCPtr(AkResourceMonitorDataSummary obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853ACEA4-0x00000001853ACECC
	~AkResourceMonitorDataSummary(); // 0x00000001853ACC00-0x00000001853ACC74
	public void Dispose(); // 0x00000001853ACA9C-0x00000001853ACAEC
	protected virtual void Dispose(bool disposing); // 0x00000001853ACAEC-0x00000001853ACC00
}

public enum AKRESULT // TypeDefIndex: 56667
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

public class AkRoomParams : IDisposable // TypeDefIndex: 56668
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Vector3 Front { get; set; } // 0x00000001853AD2A4-0x00000001853AD30C 0x0000000183CDFA50-0x0000000183CDFAE0
	public Vector3 Up { get; set; } // 0x00000001853AD4EC-0x00000001853AD554 0x0000000183CDF970-0x0000000183CDFA00
	public uint ReverbAuxBus { get; set; } // 0x00000001853AD30C-0x00000001853AD35C 0x0000000183CDF5D0-0x0000000183CDF630
	public float ReverbLevel { get; set; } // 0x00000001853AD35C-0x00000001853AD3AC 0x0000000183CDF8B0-0x0000000183CDF920
	public float TransmissionLoss { get; set; } // 0x00000001853AD49C-0x00000001853AD4EC 0x0000000183CDF7F0-0x0000000183CDF860
	public float RoomGameObj_AuxSendLevelToSelf { get; set; } // 0x00000001853AD3AC-0x00000001853AD3FC 0x0000000183CDF730-0x0000000183CDF7A0
	public bool RoomGameObj_KeepRegistered { get; set; } // 0x00000001853AD3FC-0x00000001853AD44C 0x0000000183CDF680-0x0000000183CDF6F0
	public uint RoomPriority { get; set; } // 0x00000001853AD44C-0x00000001853AD49C 0x0000000183CDF520-0x0000000183CDF580

	// Constructors
	internal AkRoomParams(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkRoomParams(); // 0x0000000184B095E0-0x0000000184B09630

	// Methods
	internal static IntPtr getCPtr(AkRoomParams obj); // 0x00000001833021A0-0x00000001833021B0
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853AD554-0x00000001853AD57C
	~AkRoomParams(); // 0x00000001853AD230-0x00000001853AD2A4
	public void Dispose(); // 0x00000001853AD1E0-0x00000001853AD230
	protected virtual void Dispose(bool disposing); // 0x00000001853AD0CC-0x00000001853AD1E0
}

public class AkSegmentInfo : IDisposable // TypeDefIndex: 56669
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int iCurrentPosition { get; set; } // 0x00000001853AD934-0x00000001853AD984 0x00000001853ADC50-0x00000001853ADCA4
	public int iPreEntryDuration { get; set; } // 0x00000001853AD9D4-0x00000001853ADA24 0x00000001853ADCF8-0x00000001853ADD4C
	public int iActiveDuration { get; set; } // 0x00000001853AD8E4-0x00000001853AD934 0x00000001853ADBFC-0x00000001853ADC50
	public int iPostExitDuration { get; set; } // 0x00000001853AD984-0x00000001853AD9D4 0x00000001853ADCA4-0x00000001853ADCF8
	public int iRemainingLookAheadTime { get; set; } // 0x00000001853ADA24-0x00000001853ADA74 0x00000001853ADD4C-0x00000001853ADDA0
	public float fBeatDuration { get; set; } // 0x00000001853AD7F4-0x00000001853AD844 0x00000001853ADAF4-0x00000001853ADB4C
	public float fBarDuration { get; set; } // 0x00000001853AD7A4-0x00000001853AD7F4 0x00000001853ADA9C-0x00000001853ADAF4
	public float fGridDuration { get; set; } // 0x00000001853AD844-0x00000001853AD894 0x00000001853ADB4C-0x00000001853ADBA4
	public float fGridOffset { get; set; } // 0x00000001853AD894-0x00000001853AD8E4 0x00000001853ADBA4-0x00000001853ADBFC

	// Constructors
	internal AkSegmentInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkSegmentInfo(); // 0x00000001853AD754-0x00000001853AD7A4

	// Methods
	internal static IntPtr getCPtr(AkSegmentInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853ADA74-0x00000001853ADA9C
	~AkSegmentInfo(); // 0x00000001853AD6E0-0x00000001853AD754
	public void Dispose(); // 0x00000001853AD57C-0x00000001853AD5CC
	protected virtual void Dispose(bool disposing); // 0x00000001853AD5CC-0x00000001853AD6E0
}

public class AkSerializedCallbackHeader : IDisposable // TypeDefIndex: 56670
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pPackage { get; } // 0x00000001853AE0E4-0x00000001853AE134 
	public uint eType { get; } // 0x00000001853AE018-0x00000001853AE068 
	public AkSerializedCallbackHeader pNext { get; } // 0x00000001853AE068-0x00000001853AE0E4 

	// Constructors
	internal AkSerializedCallbackHeader(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkSerializedCallbackHeader(); // 0x00000001853ADFC8-0x00000001853AE018

	// Methods
	internal static IntPtr getCPtr(AkSerializedCallbackHeader obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853AE134-0x00000001853AE15C
	~AkSerializedCallbackHeader(); // 0x00000001853ADF04-0x00000001853ADF78
	public void Dispose(); // 0x00000001853ADDA0-0x00000001853ADDF0
	protected virtual void Dispose(bool disposing); // 0x00000001853ADDF0-0x00000001853ADF04
	public IntPtr GetData(); // 0x00000001853ADF78-0x00000001853ADFC8
}

public enum AkSetPositionFlags // TypeDefIndex: 56671
{
	AkSetPositionFlags_Emitter = 1,
	AkSetPositionFlags_Listener = 2,
	AkSetPositionFlags_Default = 3
}

public enum AkSourceChannelOrdering // TypeDefIndex: 56672
{
	SourceChannelOrdering_Standard = 0,
	SourceChannelOrdering_Film = 1,
	SourceChannelOrdering_FuMa = 2,
	SourceChannelOrdering_Last = 3
}

public class AkSourceSettings : IDisposable // TypeDefIndex: 56673
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint sourceID { get; set; } // 0x00000001853C6D0C-0x00000001853C6D5C 0x00000001853C6E28-0x00000001853C6E7C
	public IntPtr pMediaMemory { get; set; } // 0x00000001853C6CBC-0x00000001853C6D0C 0x00000001853C6DD4-0x00000001853C6E28
	public uint uMediaSize { get; set; } // 0x00000001853C6D5C-0x00000001853C6DAC 0x00000001853C6E7C-0x00000001853C6ED0

	// Constructors
	internal AkSourceSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkSourceSettings(); // 0x00000001853C6C6C-0x00000001853C6CBC

	// Methods
	internal static IntPtr getCPtr(AkSourceSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C6DAC-0x00000001853C6DD4
	~AkSourceSettings(); // 0x00000001853C6BB8-0x00000001853C6C2C
	public void Dispose(); // 0x00000001853C6A54-0x00000001853C6AA4
	protected virtual void Dispose(bool disposing); // 0x00000001853C6AA4-0x00000001853C6BB8
	public void Clear(); // 0x00000001853C699C-0x00000001853C69EC
	public static int GetSizeOf(); // 0x00000001853C6C2C-0x00000001853C6C6C
	public void Clone(AkSourceSettings other); // 0x00000001853C69EC-0x00000001853C6A54
}

public class AkSpatialAudioInitSettings : IDisposable // TypeDefIndex: 56674
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxSoundPropagationDepth { get; set; } // 0x00000001853C7150-0x00000001853C71A0 0x000000018400A390-0x000000018400A3F0
	public float fMovementThreshold { get; set; } // 0x00000001853C7060-0x00000001853C70B0 0x000000018400A740-0x000000018400A7B0
	public uint uNumberOfPrimaryRays { get; set; } // 0x0000000184008CF0-0x0000000184008D40 0x000000018400A2E0-0x000000018400A340
	public uint uMaxReflectionOrder { get; set; } // 0x0000000184008C60-0x0000000184008CB0 0x000000018400A230-0x000000018400A290
	public uint uMaxDiffractionOrder { get; set; } // 0x0000000184008BD0-0x0000000184008C20 0x000000018400A180-0x000000018400A1E0
	public uint uMaxEmitterRoomAuxSends { get; set; } // 0x00000001853C7100-0x00000001853C7150 0x000000018400A0D0-0x000000018400A130
	public uint uDiffractionOnReflectionsOrder { get; set; } // 0x00000001853C70B0-0x00000001853C7100 0x000000018400A020-0x000000018400A080
	public float fMaxPathLength { get; set; } // 0x00000001853C7010-0x00000001853C7060 0x000000018400A680-0x000000018400A6F0
	public float fCPULimitPercentage { get; set; } // 0x00000001853C6FC0-0x00000001853C7010 0x000000018400A5C0-0x000000018400A630
	public uint uLoadBalancingSpread { get; set; } // 0x0000000184008B40-0x0000000184008B90 0x0000000184009F70-0x0000000184009FD0
	public bool bEnableGeometricDiffractionAndTransmission { get; set; } // 0x00000001853C6F70-0x00000001853C6FC0 0x000000018400A500-0x000000018400A570
	public bool bCalcEmitterVirtualPosition { get; set; } // 0x00000001853C6F20-0x00000001853C6F70 0x000000018400A440-0x000000018400A4B0

	// Constructors
	internal AkSpatialAudioInitSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkSpatialAudioInitSettings(); // 0x0000000184009D70-0x0000000184009DD0

	// Methods
	internal static IntPtr getCPtr(AkSpatialAudioInitSettings obj); // 0x00000001833021A0-0x00000001833021B0
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C71A0-0x00000001853C71C8
	~AkSpatialAudioInitSettings(); // 0x0000000184790530-0x0000000184790580
	public void Dispose(); // 0x00000001853C6ED0-0x00000001853C6F20
	protected virtual void Dispose(bool disposing); // 0x0000000184790580-0x00000001847907D0
}

public enum AkSpeakerPanningType // TypeDefIndex: 56675
{
	AK_DirectSpeakerAssignment = 0,
	AK_BalanceFadeHeight = 1,
	AK_SteeringPanner = 2
}

public class AkStdMovePolicy : IDisposable // TypeDefIndex: 56676
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkStdMovePolicy(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkStdMovePolicy(); // 0x00000001853C73E0-0x00000001853C7430

	// Methods
	internal static IntPtr getCPtr(AkStdMovePolicy obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C7430-0x00000001853C7458
	~AkStdMovePolicy(); // 0x00000001853C732C-0x00000001853C73A0
	public void Dispose(); // 0x00000001853C71C8-0x00000001853C7218
	protected virtual void Dispose(bool disposing); // 0x00000001853C7218-0x00000001853C732C
	public static bool IsTrivial(); // 0x00000001853C73A0-0x00000001853C73E0
}

public class AkStreamMgrSettings : IDisposable // TypeDefIndex: 56677
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkStreamMgrSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50

	// Methods
	internal static IntPtr getCPtr(AkStreamMgrSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C74A8-0x00000001853C74D0
	~AkStreamMgrSettings(); // 0x0000000184A3DAF0-0x0000000184A3DB40
	public void Dispose(); // 0x00000001853C7458-0x00000001853C74A8
	protected virtual void Dispose(bool disposing); // 0x0000000184A3DB40-0x0000000184A3DCF0
}

public class AkTransform : IDisposable // TypeDefIndex: 56678
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkTransform(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkTransform(); // 0x00000001853C7B94-0x00000001853C7BE4

	// Methods
	internal static IntPtr getCPtr(AkTransform obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C7BE4-0x00000001853C7C0C
	~AkTransform(); // 0x00000001853C7634-0x00000001853C76A8
	public void Dispose(); // 0x00000001853C75E4-0x00000001853C7634
	protected virtual void Dispose(bool disposing); // 0x00000001853C74D0-0x00000001853C75E4
	public Vector3 Position(); // 0x00000001853C7778-0x00000001853C77E0
	public Vector3 OrientationFront(); // 0x00000001853C76A8-0x00000001853C7710
	public Vector3 OrientationTop(); // 0x00000001853C7710-0x00000001853C7778
	public void Set(Vector3 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop); // 0x00000001853C7A00-0x00000001853C7AB4
	public void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ); // 0x00000001853C7AB4-0x00000001853C7B94
	public void SetPosition(Vector3 in_position); // 0x00000001853C7918-0x00000001853C7980
	public void SetPosition(float in_x, float in_y, float in_z); // 0x00000001853C7980-0x00000001853C7A00
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop); // 0x00000001853C77E0-0x00000001853C786C
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ); // 0x00000001853C786C-0x00000001853C7918
}

public class AkTriangle : IDisposable // TypeDefIndex: 56679
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public ushort point0 { get; set; } // 0x00000001853C7FB0-0x00000001853C8000 0x00000001853C8118-0x00000001853C816C
	public ushort point1 { get; set; } // 0x00000001853C8000-0x00000001853C8050 0x00000001853C816C-0x00000001853C81C0
	public ushort point2 { get; set; } // 0x00000001853C8050-0x00000001853C80A0 0x00000001853C81C0-0x00000001853C8214
	public ushort surface { get; set; } // 0x00000001853C80A0-0x00000001853C80F0 0x00000001853C8214-0x00000001853C8268

	// Constructors
	internal AkTriangle(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkTriangle(); // 0x00000001853C7EDC-0x00000001853C7F2C
	public AkTriangle(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo); // 0x00000001853C7F2C-0x00000001853C7FB0

	// Methods
	internal static IntPtr getCPtr(AkTriangle obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C80F0-0x00000001853C8118
	~AkTriangle(); // 0x00000001853C7E28-0x00000001853C7E9C
	public void Dispose(); // 0x00000001853C7DD8-0x00000001853C7E28
	protected virtual void Dispose(bool disposing); // 0x00000001853C7CC4-0x00000001853C7DD8
	public void Clear(); // 0x00000001853C7C0C-0x00000001853C7C5C
	public static int GetSizeOf(); // 0x00000001853C7E9C-0x00000001853C7EDC
	public void Clone(AkTriangle other); // 0x00000001853C7C5C-0x00000001853C7CC4
}

public class AkTrivialStdMovePolicy : IDisposable // TypeDefIndex: 56680
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkTrivialStdMovePolicy(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkTrivialStdMovePolicy(); // 0x00000001853C8480-0x00000001853C84D0

	// Methods
	internal static IntPtr getCPtr(AkTrivialStdMovePolicy obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C84D0-0x00000001853C84F8
	~AkTrivialStdMovePolicy(); // 0x00000001853C83CC-0x00000001853C8440
	public void Dispose(); // 0x00000001853C837C-0x00000001853C83CC
	protected virtual void Dispose(bool disposing); // 0x00000001853C8268-0x00000001853C837C
	public static bool IsTrivial(); // 0x00000001853C8440-0x00000001853C8480
}

public class AkWorldTransform : IDisposable // TypeDefIndex: 56681
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkWorldTransform(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkWorldTransform(); // 0x00000001853C8BC8-0x00000001853C8C18

	// Methods
	internal static IntPtr getCPtr(AkWorldTransform obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C8C18-0x00000001853C8C40
	~AkWorldTransform(); // 0x00000001853C865C-0x00000001853C86D0
	public void Dispose(); // 0x00000001853C84F8-0x00000001853C8548
	protected virtual void Dispose(bool disposing); // 0x00000001853C8548-0x00000001853C865C
	public AkVector64 Position(); // 0x00000001853C87A0-0x00000001853C880C
	public Vector3 OrientationFront(); // 0x00000001853C86D0-0x00000001853C8738
	public Vector3 OrientationTop(); // 0x00000001853C8738-0x00000001853C87A0
	public void Set(AkVector64 in_position, Vector3 in_orientationFront, Vector3 in_orientationTop); // 0x00000001853C8B10-0x00000001853C8BC8
	public void Set(double in_positionX, double in_positionY, double in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ); // 0x00000001853C8A30-0x00000001853C8B10
	public void SetPosition(AkVector64 in_position); // 0x00000001853C8944-0x00000001853C89B0
	public void SetPosition(double in_x, double in_y, double in_z); // 0x00000001853C89B0-0x00000001853C8A30
	public void SetOrientation(Vector3 in_orientationFront, Vector3 in_orientationTop); // 0x00000001853C88B8-0x00000001853C8944
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ); // 0x00000001853C880C-0x00000001853C88B8
}

public class MonitorErrorInfo : IDisposable // TypeDefIndex: 56682
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public string m_name { get; set; } // 0x00000001853C8F94-0x00000001853C9000 0x00000001853C907C-0x00000001853C90D0
	public string m_message { get; set; } // 0x00000001853C8F28-0x00000001853C8F94 0x00000001853C9028-0x00000001853C907C

	// Constructors
	internal MonitorErrorInfo(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public MonitorErrorInfo(string in_name, string in_message); // 0x00000001853C8E18-0x00000001853C8E80
	public MonitorErrorInfo(string in_name); // 0x00000001853C8E80-0x00000001853C8ED8
	public MonitorErrorInfo(); // 0x00000001853C8ED8-0x00000001853C8F28

	// Methods
	internal static IntPtr getCPtr(MonitorErrorInfo obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C9000-0x00000001853C9028
	~MonitorErrorInfo(); // 0x00000001853C8DA4-0x00000001853C8E18
	public void Dispose(); // 0x00000001853C8D54-0x00000001853C8DA4
	protected virtual void Dispose(bool disposing); // 0x00000001853C8C40-0x00000001853C8D54
}

public class MsgContext : IDisposable // TypeDefIndex: 56683
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint in_playingID { get; set; } // 0x00000001853C9540-0x00000001853C9590 0x00000001853C96B0-0x00000001853C9704
	public ulong in_gameObjID { get; set; } // 0x00000001853C94F0-0x00000001853C9540 0x00000001853C965C-0x00000001853C96B0
	public uint in_soundID { get; set; } // 0x00000001853C9590-0x00000001853C95E0 0x00000001853C9704-0x00000001853C9758
	public bool in_bIsBus { get; set; } // 0x00000001853C94A0-0x00000001853C94F0 0x00000001853C9608-0x00000001853C965C

	// Constructors
	internal MsgContext(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public MsgContext(uint pId, ulong goId, uint nodeId, bool isBus); // 0x00000001853C9424-0x00000001853C94A0
	public MsgContext(uint pId, ulong goId, uint nodeId); // 0x00000001853C92A8-0x00000001853C931C
	public MsgContext(uint pId, ulong goId); // 0x00000001853C93C0-0x00000001853C9424
	public MsgContext(uint pId); // 0x00000001853C936C-0x00000001853C93C0
	public MsgContext(); // 0x00000001853C931C-0x00000001853C936C

	// Methods
	internal static IntPtr getCPtr(MsgContext obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853C95E0-0x00000001853C9608
	~MsgContext(); // 0x00000001853C9234-0x00000001853C92A8
	public void Dispose(); // 0x00000001853C91E4-0x00000001853C9234
	protected virtual void Dispose(bool disposing); // 0x00000001853C90D0-0x00000001853C91E4
}

public class AkCommunicationSettings : IDisposable // TypeDefIndex: 56685
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uPoolSize { get; set; } // 0x000000018539F9B8-0x000000018539FA08 0x000000018539FBD4-0x000000018539FC28
	public ushort uDiscoveryBroadcastPort { get; set; } // 0x000000018539F968-0x000000018539F9B8 0x000000018539FB80-0x000000018539FBD4
	public ushort uCommandPort { get; set; } // 0x000000018539F918-0x000000018539F968 0x000000018539FB2C-0x000000018539FB80
	public AkCommSystem commSystem { get; set; } // 0x000000018539F85C-0x000000018539F8AC 0x000000018539FA84-0x000000018539FAD8
	public bool bInitSystemLib { get; set; } // 0x000000018539F80C-0x000000018539F85C 0x000000018539FA30-0x000000018539FA84
	public string szAppNetworkName { get; set; } // 0x000000018539F8AC-0x000000018539F918 0x000000018539FAD8-0x000000018539FB2C

	// Nested types
	public enum AkCommSystem // TypeDefIndex: 56684
	{
		AkCommSystem_Socket = 0,
		AkCommSystem_HTCS = 1
	}

	// Constructors
	internal AkCommunicationSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkCommunicationSettings(); // 0x000000018539F7BC-0x000000018539F80C

	// Methods
	internal static IntPtr getCPtr(AkCommunicationSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x000000018539FA08-0x000000018539FA30
	~AkCommunicationSettings(); // 0x000000018539F748-0x000000018539F7BC
	public void Dispose(); // 0x000000018539F5E4-0x000000018539F634
	protected virtual void Dispose(bool disposing); // 0x000000018539F634-0x000000018539F748
}

public class AkPlatformInitSettings : IDisposable // TypeDefIndex: 56686
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkThreadProperties threadLEngine { get; set; } // 0x00000001853A8E60-0x00000001853A8EDC 0x00000001853A91FC-0x00000001853A9264
	public AkThreadProperties threadOutputMgr { get; set; } // 0x00000001853A8F58-0x00000001853A8FD4 0x00000001853A92CC-0x00000001853A9334
	public AkThreadProperties threadBankManager { get; set; } // 0x00000001853A8DE4-0x00000001853A8E60 0x00000001853A9194-0x00000001853A91FC
	public AkThreadProperties threadMonitor { get; set; } // 0x00000001853A8EDC-0x00000001853A8F58 0x00000001853A9264-0x00000001853A92CC
	public ushort uNumRefillsInVoice { get; set; } // 0x00000001853A9024-0x00000001853A9074 0x000000018400B1F0-0x000000018400B250
	public uint uSampleRate { get; set; } // 0x00000001853A9074-0x00000001853A90C4 0x000000018400B2A0-0x000000018400B300
	public bool bEnableAvxSupport { get; set; } // 0x00000001853A8D44-0x00000001853A8D94 0x00000001853A90EC-0x00000001853A9140
	public uint uMaxSystemAudioObjects { get; set; } // 0x00000001853A8FD4-0x00000001853A9024 0x0000000184CCB190-0x0000000184CCB1F0
	public bool bEnableDirectInputSupport { get; set; } // 0x00000001853A8D94-0x00000001853A8DE4 0x00000001853A9140-0x00000001853A9194

	// Constructors
	internal AkPlatformInitSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50

	// Methods
	internal static IntPtr getCPtr(AkPlatformInitSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853A90C4-0x00000001853A90EC
	~AkPlatformInitSettings(); // 0x00000001848F4210-0x00000001848F4260
	public void Dispose(); // 0x00000001853A8CF4-0x00000001853A8D44
	protected virtual void Dispose(bool disposing); // 0x00000001848F4260-0x00000001848F4420
}

internal class AkSoundEnginePINVOKE // TypeDefIndex: 56687
{
	// Constructors
	static AkSoundEnginePINVOKE(); // 0x00000001841E1670-0x00000001841E1680
	public AkSoundEnginePINVOKE(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public static extern uint CSharp_JoystickIdToWwiseId(uint jarg1); // 0x00000001853BD17C-0x00000001853BD1F4
	public static extern uint CSharp_AK_INVALID_SHARE_SET_ID_get(); // 0x00000001853AE3BC-0x00000001853AE3E8
	public static extern uint CSharp_AK_INVALID_PIPELINE_ID_get(); // 0x00000001853AE390-0x00000001853AE3BC
	public static extern ulong CSharp_AK_INVALID_AUDIO_OBJECT_ID_get(); // 0x00000001853AE294-0x00000001853AE2FC
	public static extern uint CSharp_AK_SOUNDBANK_VERSION_get(); // 0x00000001853AE4C4-0x00000001853AE52C
	public static extern uint CSharp_AkJobType_Generic_get(); // 0x00000001853B2E00-0x00000001853B2E2C
	public static extern uint CSharp_AkJobType_AudioProcessing_get(); // 0x00000001853B2DD4-0x00000001853B2E00
	public static extern uint CSharp_AkJobType_SpatialAudio_get(); // 0x00000001853B2E2C-0x00000001853B2E94
	public static extern uint CSharp_AK_NUM_JOB_TYPES_get(); // 0x00000001853AE498-0x00000001853AE4C4
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2); // 0x00000001853AF5A8-0x00000001853AF5E8
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerFrame_get(IntPtr jarg1); // 0x00000001853AF574-0x00000001853AF5A8
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(IntPtr jarg1, uint jarg2); // 0x00000001853AF61C-0x00000001853AF65C
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerSecond_get(IntPtr jarg1); // 0x00000001853AF5E8-0x00000001853AF61C
	public static extern IntPtr CSharp_new_AkAudioSettings(); // 0x00000001853C55AC-0x00000001853C55D8
	public static extern void CSharp_delete_AkAudioSettings(IntPtr jarg1); // 0x00000001853C4634-0x00000001853C4668
	public static extern void CSharp_AkDeviceDescription_idDevice_set(IntPtr jarg1, uint jarg2); // 0x00000001853B0C20-0x00000001853B0C60
	public static extern uint CSharp_AkDeviceDescription_idDevice_get(IntPtr jarg1); // 0x0000000184009270-0x00000001840092B0
	public static extern void CSharp_AkDeviceDescription_deviceName_set(IntPtr jarg1, string jarg2); // 0x00000001853B0B20-0x00000001853B0BAC
	public static extern IntPtr CSharp_AkDeviceDescription_deviceName_get(IntPtr jarg1); // 0x00000001853B0AEC-0x00000001853B0B20
	public static extern void CSharp_AkDeviceDescription_deviceStateMask_set(IntPtr jarg1, int jarg2); // 0x00000001853B0BE0-0x00000001853B0C20
	public static extern int CSharp_AkDeviceDescription_deviceStateMask_get(IntPtr jarg1); // 0x00000001853B0BAC-0x00000001853B0BE0
	public static extern void CSharp_AkDeviceDescription_isDefaultDevice_set(IntPtr jarg1, bool jarg2); // 0x00000001853B0C60-0x00000001853B0CA4
	public static extern bool CSharp_AkDeviceDescription_isDefaultDevice_get(IntPtr jarg1); // 0x00000001840090C0-0x0000000184009100
	public static extern void CSharp_AkDeviceDescription_Clear(IntPtr jarg1); // 0x00000001845F50B0-0x00000001845F50F0
	public static extern int CSharp_AkDeviceDescription_GetSizeOf(); // 0x0000000184527E00-0x0000000184527E30
	public static extern void CSharp_AkDeviceDescription_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B0AA8-0x00000001853B0AEC
	public static extern IntPtr CSharp_new_AkDeviceDescription(); // 0x00000001853C578C-0x00000001853C57B8
	public static extern void CSharp_delete_AkDeviceDescription(IntPtr jarg1); // 0x00000001853C4808-0x00000001853C483C
	public static extern AkVector64 CSharp_AkWorldTransform_Position(IntPtr jarg1); // 0x00000001853B96C0-0x00000001853B9758
	public static extern Vector3 CSharp_AkWorldTransform_OrientationFront(IntPtr jarg1); // 0x00000001853B9598-0x00000001853B962C
	public static extern Vector3 CSharp_AkWorldTransform_OrientationTop(IntPtr jarg1); // 0x00000001853B962C-0x00000001853B96C0
	public static extern void CSharp_AkWorldTransform_Set__SWIG_0(IntPtr jarg1, AkVector64 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x00000001853B9970-0x00000001853B9A4C
	public static extern void CSharp_AkWorldTransform_Set__SWIG_1(IntPtr jarg1, double jarg2, double jarg3, double jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10); // 0x00000001853B9A4C-0x00000001853B9AB4
	public static extern void CSharp_AkWorldTransform_SetPosition__SWIG_0(IntPtr jarg1, AkVector64 jarg2); // 0x00000001853B9874-0x00000001853B9910
	public static extern void CSharp_AkWorldTransform_SetPosition__SWIG_1(IntPtr jarg1, double jarg2, double jarg3, double jarg4); // 0x00000001853B9910-0x00000001853B9970
	public static extern void CSharp_AkWorldTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3); // 0x00000001853B9758-0x00000001853B9814
	public static extern void CSharp_AkWorldTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7); // 0x00000001853B9814-0x00000001853B9874
	public static extern IntPtr CSharp_new_AkWorldTransform(); // 0x00000001853C65DC-0x00000001853C6608
	public static extern void CSharp_delete_AkWorldTransform(IntPtr jarg1); // 0x00000001853C52CC-0x00000001853C5300
	public static extern Vector3 CSharp_AkTransform_Position(IntPtr jarg1); // 0x00000001853B9078-0x00000001853B910C
	public static extern Vector3 CSharp_AkTransform_OrientationFront(IntPtr jarg1); // 0x00000001853B8F50-0x00000001853B8FE4
	public static extern Vector3 CSharp_AkTransform_OrientationTop(IntPtr jarg1); // 0x00000001853B8FE4-0x00000001853B9078
	public static extern void CSharp_AkTransform_Set__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x0000000183CDEF50-0x0000000183CDEFF0
	public static extern void CSharp_AkTransform_Set__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10); // 0x00000001853B9320-0x00000001853B9388
	public static extern void CSharp_AkTransform_SetPosition__SWIG_0(IntPtr jarg1, Vector3 jarg2); // 0x00000001853B9228-0x00000001853B92C0
	public static extern void CSharp_AkTransform_SetPosition__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4); // 0x00000001853B92C0-0x00000001853B9320
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3); // 0x00000001853B910C-0x00000001853B91C8
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7); // 0x00000001853B91C8-0x00000001853B9228
	public static extern IntPtr CSharp_new_AkTransform(); // 0x0000000184CAD7E0-0x0000000184CAD810
	public static extern void CSharp_delete_AkTransform(IntPtr jarg1); // 0x00000001853C51FC-0x00000001853C5230
	public static extern Vector3 CSharp_ConvertAkVector64ToAkVector(AkVector64 jarg1); // 0x00000001853B9F40-0x00000001853B9FEC
	public static extern IntPtr CSharp_ConvertAkWorldTransformToAkTransform(IntPtr jarg1); // 0x00000001853BA098-0x00000001853BA0CC
	public static extern AkVector64 CSharp_ConvertAkVectorToAkVector64(Vector3 jarg1); // 0x00000001853B9FEC-0x00000001853BA098
	public static extern IntPtr CSharp_ConvertAkTransformToAkWorldTransform(IntPtr jarg1); // 0x00000001853B9F0C-0x00000001853B9F40
	public static extern void CSharp_AkObstructionOcclusionValues_occlusion_set(IntPtr jarg1, float jarg2); // 0x00000001853B5B28-0x00000001853B5B6C
	public static extern float CSharp_AkObstructionOcclusionValues_occlusion_get(IntPtr jarg1); // 0x00000001853B5AF4-0x00000001853B5B28
	public static extern void CSharp_AkObstructionOcclusionValues_obstruction_set(IntPtr jarg1, float jarg2); // 0x00000001853B5AB0-0x00000001853B5AF4
	public static extern float CSharp_AkObstructionOcclusionValues_obstruction_get(IntPtr jarg1); // 0x00000001853B5A7C-0x00000001853B5AB0
	public static extern void CSharp_AkObstructionOcclusionValues_Clear(IntPtr jarg1); // 0x00000001853B59D8-0x00000001853B5A0C
	public static extern int CSharp_AkObstructionOcclusionValues_GetSizeOf(); // 0x00000001853B5A50-0x00000001853B5A7C
	public static extern void CSharp_AkObstructionOcclusionValues_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B5A0C-0x00000001853B5A50
	public static extern IntPtr CSharp_new_AkObstructionOcclusionValues(); // 0x00000001853C5EF0-0x00000001853C5F1C
	public static extern void CSharp_delete_AkObstructionOcclusionValues(IntPtr jarg1); // 0x00000001853C4E54-0x00000001853C4E88
	public static extern void CSharp_AkChannelEmitter_position_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B0548-0x00000001853B058C
	public static extern IntPtr CSharp_AkChannelEmitter_position_get(IntPtr jarg1); // 0x00000001853B050C-0x00000001853B0548
	public static extern void CSharp_AkChannelEmitter_uInputChannels_set(IntPtr jarg1, uint jarg2); // 0x00000001853B05C0-0x00000001853B0600
	public static extern uint CSharp_AkChannelEmitter_uInputChannels_get(IntPtr jarg1); // 0x00000001853B058C-0x00000001853B05C0
	public static extern void CSharp_AkChannelEmitter_padding_set(IntPtr jarg1, string jarg2); // 0x00000001853B0478-0x00000001853B050C
	public static extern IntPtr CSharp_AkChannelEmitter_padding_get(IntPtr jarg1); // 0x00000001853B0444-0x00000001853B0478
	public static extern void CSharp_delete_AkChannelEmitter(IntPtr jarg1); // 0x00000001853C47A0-0x00000001853C47D4
	public static extern void CSharp_AkAuxSendValue_listenerID_set(IntPtr jarg1, ulong jarg2); // 0x00000001853AF950-0x00000001853AF9D4
	public static extern ulong CSharp_AkAuxSendValue_listenerID_get(IntPtr jarg1); // 0x00000001853AF8D8-0x00000001853AF950
	public static extern void CSharp_AkAuxSendValue_auxBusID_set(IntPtr jarg1, uint jarg2); // 0x00000001853AF7E8-0x00000001853AF868
	public static extern uint CSharp_AkAuxSendValue_auxBusID_get(IntPtr jarg1); // 0x00000001853AF7B4-0x00000001853AF7E8
	public static extern void CSharp_AkAuxSendValue_fControlValue_set(IntPtr jarg1, float jarg2); // 0x00000001853AF894-0x00000001853AF8D8
	public static extern float CSharp_AkAuxSendValue_fControlValue_get(IntPtr jarg1); // 0x00000001853AF868-0x00000001853AF894
	public static extern void CSharp_AkAuxSendValue_Set(IntPtr jarg1, ulong jarg2, uint jarg3, float jarg4); // 0x00000001853AF758-0x00000001853AF7B4
	public static extern bool CSharp_AkAuxSendValue_IsSame(IntPtr jarg1, ulong jarg2, uint jarg3); // 0x00000001853AF6C0-0x00000001853AF758
	public static extern int CSharp_AkAuxSendValue_GetSizeOf(); // 0x00000001853AF694-0x00000001853AF6C0
	public static extern void CSharp_delete_AkAuxSendValue(IntPtr jarg1); // 0x00000001853C469C-0x00000001853C46D0
	public static extern IntPtr CSharp_new_AkRamp__SWIG_0(); // 0x00000001853C6334-0x00000001853C6368
	public static extern IntPtr CSharp_new_AkRamp__SWIG_1(float jarg1, float jarg2); // 0x00000001853C6368-0x00000001853C63AC
	public static extern void CSharp_AkRamp_fPrev_set(IntPtr jarg1, float jarg2); // 0x00000001853B7B3C-0x00000001853B7B80
	public static extern float CSharp_AkRamp_fPrev_get(IntPtr jarg1); // 0x00000001853B7B08-0x00000001853B7B3C
	public static extern void CSharp_AkRamp_fNext_set(IntPtr jarg1, float jarg2); // 0x00000001853B7ACC-0x00000001853B7B08
	public static extern float CSharp_AkRamp_fNext_get(IntPtr jarg1); // 0x00000001853B7A98-0x00000001853B7ACC
	public static extern void CSharp_delete_AkRamp(IntPtr jarg1); // 0x00000001853C4FF4-0x00000001853C5028
	public static extern ushort CSharp_AK_INT_get(); // 0x00000001853AE22C-0x00000001853AE294
	public static extern ushort CSharp_AK_FLOAT_get(); // 0x00000001853AE15C-0x00000001853AE1C4
	public static extern byte CSharp_AK_INTERLEAVED_get(); // 0x00000001853AE1C4-0x00000001853AE22C
	public static extern byte CSharp_AK_NONINTERLEAVED_get(); // 0x00000001853AE46C-0x00000001853AE498
	public static extern uint CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get(); // 0x00000001853AE3E8-0x00000001853AE414
	public static extern uint CSharp_AK_LE_NATIVE_SAMPLETYPE_get(); // 0x00000001853AE440-0x00000001853AE46C
	public static extern uint CSharp_AK_LE_NATIVE_INTERLEAVE_get(); // 0x00000001853AE414-0x00000001853AE440
	public static extern void CSharp_AkAudioFormat_uSampleRate_set(IntPtr jarg1, uint jarg2); // 0x00000001853AF488-0x00000001853AF4C8
	public static extern uint CSharp_AkAudioFormat_uSampleRate_get(IntPtr jarg1); // 0x00000001853AF454-0x00000001853AF488
	public static extern void CSharp_AkAudioFormat_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853AF278-0x00000001853AF2F8
	public static extern IntPtr CSharp_AkAudioFormat_channelConfig_get(IntPtr jarg1); // 0x00000001853AF23C-0x00000001853AF278
	public static extern void CSharp_AkAudioFormat_uBitsPerSample_set(IntPtr jarg1, uint jarg2); // 0x00000001853AF32C-0x00000001853AF36C
	public static extern uint CSharp_AkAudioFormat_uBitsPerSample_get(IntPtr jarg1); // 0x00000001853AF2F8-0x00000001853AF32C
	public static extern void CSharp_AkAudioFormat_uBlockAlign_set(IntPtr jarg1, uint jarg2); // 0x00000001853AF3A0-0x00000001853AF3E0
	public static extern uint CSharp_AkAudioFormat_uBlockAlign_get(IntPtr jarg1); // 0x00000001853AF36C-0x00000001853AF3A0
	public static extern void CSharp_AkAudioFormat_uTypeID_set(IntPtr jarg1, uint jarg2); // 0x00000001853AF4FC-0x00000001853AF53C
	public static extern uint CSharp_AkAudioFormat_uTypeID_get(IntPtr jarg1); // 0x00000001853AF4C8-0x00000001853AF4FC
	public static extern void CSharp_AkAudioFormat_uInterleaveID_set(IntPtr jarg1, uint jarg2); // 0x00000001853AF414-0x00000001853AF454
	public static extern uint CSharp_AkAudioFormat_uInterleaveID_get(IntPtr jarg1); // 0x00000001853AF3E0-0x00000001853AF414
	public static extern uint CSharp_AkAudioFormat_GetNumChannels(IntPtr jarg1); // 0x00000001853AF134-0x00000001853AF168
	public static extern uint CSharp_AkAudioFormat_GetBitsPerSample(IntPtr jarg1); // 0x00000001853AF054-0x00000001853AF0CC
	public static extern uint CSharp_AkAudioFormat_GetBlockAlign(IntPtr jarg1); // 0x00000001853AF0CC-0x00000001853AF100
	public static extern uint CSharp_AkAudioFormat_GetTypeID(IntPtr jarg1); // 0x00000001853AF168-0x00000001853AF19C
	public static extern uint CSharp_AkAudioFormat_GetInterleaveID(IntPtr jarg1); // 0x00000001853AF100-0x00000001853AF134
	public static extern void CSharp_AkAudioFormat_SetAll(IntPtr jarg1, uint jarg2, IntPtr jarg3, uint jarg4, uint jarg5, uint jarg6, uint jarg7); // 0x00000001853AF19C-0x00000001853AF23C
	public static extern IntPtr CSharp_new_AkAudioFormat(); // 0x00000001853C5554-0x00000001853C5580
	public static extern void CSharp_delete_AkAudioFormat(IntPtr jarg1); // 0x00000001853C4588-0x00000001853C4600
	public static extern bool CSharp_IsBankCodecID(uint jarg1); // 0x00000001853BD0B0-0x00000001853BD0E8
	public static extern IntPtr CSharp_new_Ak3dData(); // 0x00000001853C54FC-0x00000001853C5528
	public static extern void CSharp_Ak3dData_xform_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853AEE68-0x00000001853AEEAC
	public static extern IntPtr CSharp_Ak3dData_xform_get(IntPtr jarg1); // 0x00000001853AEE2C-0x00000001853AEE68
	public static extern void CSharp_Ak3dData_spread_set(IntPtr jarg1, float jarg2); // 0x00000001853AED74-0x00000001853AEDB8
	public static extern float CSharp_Ak3dData_spread_get(IntPtr jarg1); // 0x00000001853AED40-0x00000001853AED74
	public static extern void CSharp_Ak3dData_focus_set(IntPtr jarg1, float jarg2); // 0x00000001853AECFC-0x00000001853AED40
	public static extern float CSharp_Ak3dData_focus_get(IntPtr jarg1); // 0x00000001853AECC8-0x00000001853AECFC
	public static extern void CSharp_Ak3dData_uEmitterChannelMask_set(IntPtr jarg1, uint jarg2); // 0x00000001853AEDEC-0x00000001853AEE2C
	public static extern uint CSharp_Ak3dData_uEmitterChannelMask_get(IntPtr jarg1); // 0x00000001853AEDB8-0x00000001853AEDEC
	public static extern void CSharp_delete_Ak3dData(IntPtr jarg1); // 0x00000001853C44DC-0x00000001853C4554
	public static extern IntPtr CSharp_new_AkBehavioralPositioningData(); // 0x00000001853C5630-0x00000001853C565C
	public static extern void CSharp_AkBehavioralPositioningData_center_set(IntPtr jarg1, float jarg2); // 0x00000001853AFA08-0x00000001853AFA4C
	public static extern float CSharp_AkBehavioralPositioningData_center_get(IntPtr jarg1); // 0x00000001853AF9D4-0x00000001853AFA08
	public static extern void CSharp_AkBehavioralPositioningData_panLR_set(IntPtr jarg1, float jarg2); // 0x00000001853AFBDC-0x00000001853AFC20
	public static extern float CSharp_AkBehavioralPositioningData_panLR_get(IntPtr jarg1); // 0x00000001853AFBA8-0x00000001853AFBDC
	public static extern void CSharp_AkBehavioralPositioningData_panBF_set(IntPtr jarg1, float jarg2); // 0x00000001853AFAF4-0x00000001853AFB30
	public static extern float CSharp_AkBehavioralPositioningData_panBF_get(IntPtr jarg1); // 0x00000001853AFAC8-0x00000001853AFAF4
	public static extern void CSharp_AkBehavioralPositioningData_panDU_set(IntPtr jarg1, float jarg2); // 0x00000001853AFB64-0x00000001853AFBA8
	public static extern float CSharp_AkBehavioralPositioningData_panDU_get(IntPtr jarg1); // 0x00000001853AFB30-0x00000001853AFB64
	public static extern void CSharp_AkBehavioralPositioningData_panSpatMix_set(IntPtr jarg1, float jarg2); // 0x00000001853AFC54-0x00000001853AFC98
	public static extern float CSharp_AkBehavioralPositioningData_panSpatMix_get(IntPtr jarg1); // 0x00000001853AFC20-0x00000001853AFC54
	public static extern void CSharp_AkBehavioralPositioningData_spatMode_set(IntPtr jarg1, int jarg2); // 0x00000001853AFD40-0x00000001853AFD80
	public static extern int CSharp_AkBehavioralPositioningData_spatMode_get(IntPtr jarg1); // 0x00000001853AFD0C-0x00000001853AFD40
	public static extern void CSharp_AkBehavioralPositioningData_panType_set(IntPtr jarg1, int jarg2); // 0x00000001853AFCCC-0x00000001853AFD0C
	public static extern int CSharp_AkBehavioralPositioningData_panType_get(IntPtr jarg1); // 0x00000001853AFC98-0x00000001853AFCCC
	public static extern void CSharp_AkBehavioralPositioningData_enableHeightSpread_set(IntPtr jarg1, bool jarg2); // 0x00000001853AFA84-0x00000001853AFAC8
	public static extern bool CSharp_AkBehavioralPositioningData_enableHeightSpread_get(IntPtr jarg1); // 0x00000001853AFA4C-0x00000001853AFA84
	public static extern void CSharp_delete_AkBehavioralPositioningData(IntPtr jarg1); // 0x00000001853C4704-0x00000001853C4738
	public static extern void CSharp_AkPositioningData_threeD_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B71C0-0x00000001853B7204
	public static extern IntPtr CSharp_AkPositioningData_threeD_get(IntPtr jarg1); // 0x00000001853B718C-0x00000001853B71C0
	public static extern void CSharp_AkPositioningData_behavioral_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B7108-0x00000001853B718C
	public static extern IntPtr CSharp_AkPositioningData_behavioral_get(IntPtr jarg1); // 0x00000001853B70D4-0x00000001853B7108
	public static extern IntPtr CSharp_new_AkPositioningData(); // 0x00000001853C62A0-0x00000001853C62CC
	public static extern void CSharp_delete_AkPositioningData(IntPtr jarg1); // 0x00000001853C4F8C-0x00000001853C4FC0
	public static extern void CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853AEB9C-0x00000001853AEBE0
	public static extern IntPtr CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(IntPtr jarg1); // 0x00000001853AEB60-0x00000001853AEB9C
	public static extern void CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x00000001853AEC88-0x00000001853AECC8
	public static extern uint CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(IntPtr jarg1); // 0x00000001853AEC54-0x00000001853AEC88
	public static extern void CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x00000001853AEC14-0x00000001853AEC54
	public static extern uint CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(IntPtr jarg1); // 0x00000001853AEBE0-0x00000001853AEC14
	public static extern void CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(IntPtr jarg1, bool jarg2); // 0x00000001853AEB1C-0x00000001853AEB60
	public static extern bool CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(IntPtr jarg1); // 0x00000001853AEAE4-0x00000001853AEB1C
	public static extern void CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(IntPtr jarg1, bool jarg2); // 0x00000001853AEAA0-0x00000001853AEAE4
	public static extern bool CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(IntPtr jarg1); // 0x00000001853AEA68-0x00000001853AEAA0
	public static extern IntPtr CSharp_new_Ak3DAudioSinkCapabilities(); // 0x00000001853C54D0-0x00000001853C54FC
	public static extern void CSharp_delete_Ak3DAudioSinkCapabilities(IntPtr jarg1); // 0x00000001853C44A8-0x00000001853C44DC
	public static extern void CSharp_AkIterator_pItem_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2D90-0x00000001853B2DD4
	public static extern IntPtr CSharp_AkIterator_pItem_get(IntPtr jarg1); // 0x00000001853B2D5C-0x00000001853B2D90
	public static extern IntPtr CSharp_AkIterator_NextIter(IntPtr jarg1); // 0x00000001853B2CF4-0x00000001853B2D28
	public static extern IntPtr CSharp_AkIterator_PrevIter(IntPtr jarg1); // 0x00000001853B2D28-0x00000001853B2D5C
	public static extern IntPtr CSharp_AkIterator_GetItem(IntPtr jarg1); // 0x00000001853B2BF0-0x00000001853B2C24
	public static extern bool CSharp_AkIterator_IsEqualTo(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2C6C-0x00000001853B2CF4
	public static extern bool CSharp_AkIterator_IsDifferentFrom(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2C24-0x00000001853B2C6C
	public static extern IntPtr CSharp_new_AkIterator(); // 0x00000001853C5BD0-0x00000001853C5BFC
	public static extern void CSharp_delete_AkIterator(IntPtr jarg1); // 0x00000001853C4A44-0x00000001853C4A78
	public static extern bool CSharp_AkStdMovePolicy_IsTrivial(); // 0x00000001853B8DC4-0x00000001853B8DF4
	public static extern IntPtr CSharp_new_AkStdMovePolicy(); // 0x00000001853C6488-0x00000001853C64B4
	public static extern void CSharp_delete_AkStdMovePolicy(IntPtr jarg1); // 0x00000001853C5160-0x00000001853C5194
	public static extern bool CSharp_AkTrivialStdMovePolicy_IsTrivial(); // 0x00000001853B9568-0x00000001853B9598
	public static extern IntPtr CSharp_new_AkTrivialStdMovePolicy(); // 0x00000001853C65B0-0x00000001853C65DC
	public static extern void CSharp_delete_AkTrivialStdMovePolicy(IntPtr jarg1); // 0x00000001853C5264-0x00000001853C5298
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_0(); // 0x00000001853C6214-0x00000001853C6240
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_1(IntPtr jarg1); // 0x00000001853C6240-0x00000001853C6274
	public static extern void CSharp_delete_AkPlaylistItem(IntPtr jarg1); // 0x00000001853C4F24-0x00000001853C4F58
	public static extern IntPtr CSharp_AkPlaylistItem_Assign(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B6B34-0x00000001853B6B78
	public static extern bool CSharp_AkPlaylistItem_IsEqualTo(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B6B78-0x00000001853B6C00
	public static extern int CSharp_AkPlaylistItem_SetExternalSources(IntPtr jarg1, uint jarg2, IntPtr jarg3); // 0x00000001853B6C00-0x00000001853B6C90
	public static extern void CSharp_AkPlaylistItem_audioNodeID_set(IntPtr jarg1, uint jarg2); // 0x00000001853B6CC4-0x00000001853B6D04
	public static extern uint CSharp_AkPlaylistItem_audioNodeID_get(IntPtr jarg1); // 0x00000001853B6C90-0x00000001853B6CC4
	public static extern void CSharp_AkPlaylistItem_msDelay_set(IntPtr jarg1, int jarg2); // 0x00000001853B6D38-0x00000001853B6D78
	public static extern int CSharp_AkPlaylistItem_msDelay_get(IntPtr jarg1); // 0x00000001853B6D04-0x00000001853B6D38
	public static extern void CSharp_AkPlaylistItem_pCustomInfo_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B6DAC-0x00000001853B6DF0
	public static extern IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(IntPtr jarg1); // 0x00000001853B6D78-0x00000001853B6DAC
	public static extern IntPtr CSharp_new_AkPlaylistArray(); // 0x00000001853C61E8-0x00000001853C6214
	public static extern void CSharp_delete_AkPlaylistArray(IntPtr jarg1); // 0x00000001853C4EF0-0x00000001853C4F24
	public static extern IntPtr CSharp_AkPlaylistArray_Begin(IntPtr jarg1); // 0x00000001853B6204-0x00000001853B6240
	public static extern IntPtr CSharp_AkPlaylistArray_End(IntPtr jarg1); // 0x00000001853B62F8-0x00000001853B632C
	public static extern IntPtr CSharp_AkPlaylistArray_FindEx(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B64B8-0x00000001853B653C
	public static extern IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B63F0-0x00000001853B6434
	public static extern void CSharp_AkPlaylistArray_Erase__SWIG_1(IntPtr jarg1, uint jarg2); // 0x00000001853B6434-0x00000001853B6474
	public static extern IntPtr CSharp_AkPlaylistArray_EraseSwap__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B632C-0x00000001853B63B0
	public static extern void CSharp_AkPlaylistArray_EraseSwap__SWIG_1(IntPtr jarg1, uint jarg2); // 0x00000001853B63B0-0x00000001853B63F0
	public static extern bool CSharp_AkPlaylistArray_IsGrowingAllowed(IntPtr jarg1); // 0x00000001853B66F4-0x00000001853B676C
	public static extern int CSharp_AkPlaylistArray_Reserve(IntPtr jarg1, uint jarg2); // 0x00000001853B69C4-0x00000001853B6A04
	public static extern int CSharp_AkPlaylistArray_ReserveExtra(IntPtr jarg1, uint jarg2); // 0x00000001853B6984-0x00000001853B69C4
	public static extern uint CSharp_AkPlaylistArray_Reserved(IntPtr jarg1); // 0x00000001853B6A04-0x00000001853B6A38
	public static extern void CSharp_AkPlaylistArray_Term(IntPtr jarg1); // 0x00000001853B6ABC-0x00000001853B6AF0
	public static extern uint CSharp_AkPlaylistArray_Length(IntPtr jarg1); // 0x00000001853B6820-0x00000001853B6854
	public static extern IntPtr CSharp_AkPlaylistArray_Data(IntPtr jarg1); // 0x00000001853B62C4-0x00000001853B62F8
	public static extern bool CSharp_AkPlaylistArray_IsEmpty(IntPtr jarg1); // 0x00000001853B66BC-0x00000001853B66F4
	public static extern IntPtr CSharp_AkPlaylistArray_Exists(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B6474-0x00000001853B64B8
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(IntPtr jarg1); // 0x00000001853B6108-0x00000001853B6180
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B6180-0x00000001853B6204
	public static extern IntPtr CSharp_AkPlaylistArray_Last(IntPtr jarg1); // 0x00000001853B67EC-0x00000001853B6820
	public static extern void CSharp_AkPlaylistArray_RemoveLast(IntPtr jarg1); // 0x00000001853B6888-0x00000001853B68BC
	public static extern int CSharp_AkPlaylistArray_Remove(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B6900-0x00000001853B6984
	public static extern int CSharp_AkPlaylistArray_RemoveSwap(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B68BC-0x00000001853B6900
	public static extern void CSharp_AkPlaylistArray_RemoveAll(IntPtr jarg1); // 0x00000001853B6854-0x00000001853B6888
	public static extern IntPtr CSharp_AkPlaylistArray_ItemAtIndex(IntPtr jarg1, uint jarg2); // 0x00000001853B676C-0x00000001853B67EC
	public static extern IntPtr CSharp_AkPlaylistArray_Insert__SWIG_0(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B65F8-0x00000001853B663C
	public static extern IntPtr CSharp_AkPlaylistArray_Insert__SWIG_1(IntPtr jarg1, uint jarg2); // 0x00000001853B663C-0x00000001853B66BC
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_0(IntPtr jarg1); // 0x00000001853B653C-0x00000001853B6574
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_1(IntPtr jarg1, uint jarg2); // 0x00000001853B6574-0x00000001853B65F8
	public static extern bool CSharp_AkPlaylistArray_Resize(IntPtr jarg1, uint jarg2); // 0x00000001853B6A38-0x00000001853B6ABC
	public static extern void CSharp_AkPlaylistArray_Transfer(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B6AF0-0x00000001853B6B34
	public static extern int CSharp_AkPlaylistArray_Copy(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B6240-0x00000001853B62C4
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_0(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6); // 0x00000001853B6DF0-0x00000001853B6E90
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_1(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5); // 0x00000001853B6E90-0x00000001853B6F30
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_2(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4); // 0x00000001853B6F30-0x00000001853B6FD0
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_3(IntPtr jarg1, uint jarg2, int jarg3); // 0x00000001853B6FD0-0x00000001853B7060
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_4(IntPtr jarg1, uint jarg2); // 0x00000001853B7060-0x00000001853B70A0
	public static extern IntPtr CSharp_new_AkPlaylist(); // 0x00000001853C6274-0x00000001853C62A0
	public static extern void CSharp_delete_AkPlaylist(IntPtr jarg1); // 0x00000001853C4F58-0x00000001853C4F8C
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_0(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x00000001853BA2FC-0x00000001853BA39C
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_1(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001853BA39C-0x00000001853BA43C
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_2(ulong jarg1); // 0x00000001853BA43C-0x00000001853BA4B4
	public static extern int CSharp_DynamicSequenceClose(uint jarg1); // 0x00000001853BA1C0-0x00000001853BA1F4
	public static extern int CSharp_DynamicSequencePlay__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001853BA5F4-0x00000001853BA680
	public static extern int CSharp_DynamicSequencePlay__SWIG_1(uint jarg1, int jarg2); // 0x00000001853BA680-0x00000001853BA700
	public static extern int CSharp_DynamicSequencePlay__SWIG_2(uint jarg1); // 0x00000001853BA700-0x00000001853BA734
	public static extern int CSharp_DynamicSequencePause__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001853BA4B4-0x00000001853BA540
	public static extern int CSharp_DynamicSequencePause__SWIG_1(uint jarg1, int jarg2); // 0x00000001853BA540-0x00000001853BA5C0
	public static extern int CSharp_DynamicSequencePause__SWIG_2(uint jarg1); // 0x00000001853BA5C0-0x00000001853BA5F4
	public static extern int CSharp_DynamicSequenceResume__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001853BA734-0x00000001853BA7C0
	public static extern int CSharp_DynamicSequenceResume__SWIG_1(uint jarg1, int jarg2); // 0x00000001853BA7C0-0x00000001853BA800
	public static extern int CSharp_DynamicSequenceResume__SWIG_2(uint jarg1); // 0x00000001853BA800-0x00000001853BA834
	public static extern int CSharp_DynamicSequenceStop__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001853BA834-0x00000001853BA884
	public static extern int CSharp_DynamicSequenceStop__SWIG_1(uint jarg1, int jarg2); // 0x00000001853BA884-0x00000001853BA8C4
	public static extern int CSharp_DynamicSequenceStop__SWIG_2(uint jarg1); // 0x00000001853BA8C4-0x00000001853BA93C
	public static extern int CSharp_DynamicSequenceBreak(uint jarg1); // 0x00000001853BA148-0x00000001853BA1C0
	public static extern int CSharp_Seek__SWIG_0(uint jarg1, int jarg2, bool jarg3); // 0x00000001853C14DC-0x00000001853C152C
	public static extern int CSharp_Seek__SWIG_1(uint jarg1, float jarg2, bool jarg3); // 0x00000001853C152C-0x00000001853C1578
	public static extern int CSharp_DynamicSequenceGetPauseTimes(uint jarg1, out uint jarg2, out uint jarg3); // 0x00000001853BA1F4-0x00000001853BA284
	public static extern IntPtr CSharp_DynamicSequenceLockPlaylist(uint jarg1); // 0x00000001853BA284-0x00000001853BA2FC
	public static extern int CSharp_DynamicSequenceUnlockPlaylist(uint jarg1); // 0x00000001853BA93C-0x00000001853BA970
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_0(); // 0x00000001853C5F1C-0x00000001853C5F48
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_1(string jarg1, uint jarg2, IntPtr jarg3, int jarg4); // 0x00000001853C5F48-0x00000001853C6004
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_2(string jarg1, uint jarg2, IntPtr jarg3); // 0x00000001853C6004-0x00000001853C60B0
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_3(string jarg1, uint jarg2); // 0x00000001853C60B0-0x00000001853C6150
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_4(string jarg1); // 0x00000001853C6150-0x00000001853C61E8
	public static extern void CSharp_AkOutputSettings_audioDeviceShareset_set(IntPtr jarg1, uint jarg2); // 0x00000001845E2430-0x00000001845E2470
	public static extern uint CSharp_AkOutputSettings_audioDeviceShareset_get(IntPtr jarg1); // 0x00000001853B5B6C-0x00000001853B5BE4
	public static extern void CSharp_AkOutputSettings_idDevice_set(IntPtr jarg1, uint jarg2); // 0x00000001845E2390-0x00000001845E23D0
	public static extern uint CSharp_AkOutputSettings_idDevice_get(IntPtr jarg1); // 0x00000001853B5C5C-0x00000001853B5C90
	public static extern void CSharp_AkOutputSettings_ePanningRule_set(IntPtr jarg1, int jarg2); // 0x00000001845E22F0-0x00000001845E2330
	public static extern int CSharp_AkOutputSettings_ePanningRule_get(IntPtr jarg1); // 0x00000001853B5C28-0x00000001853B5C5C
	public static extern void CSharp_AkOutputSettings_channelConfig_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B5BE4-0x00000001853B5C28
	public static extern IntPtr CSharp_AkOutputSettings_channelConfig_get(IntPtr jarg1); // 0x00000001845E2170-0x00000001845E21B0
	public static extern void CSharp_delete_AkOutputSettings(IntPtr jarg1); // 0x00000001853C4E88-0x00000001853C4EBC
	public static extern void CSharp_AkInitSettings_uMaxNumPaths_set(IntPtr jarg1, uint jarg2); // 0x00000001845E2000-0x00000001845E2040
	public static extern uint CSharp_AkInitSettings_uMaxNumPaths_get(IntPtr jarg1); // 0x00000001853B28E0-0x00000001853B2914
	public static extern void CSharp_AkInitSettings_uCommandQueueSize_set(IntPtr jarg1, uint jarg2); // 0x00000001845E1F60-0x00000001845E1FA0
	public static extern uint CSharp_AkInitSettings_uCommandQueueSize_get(IntPtr jarg1); // 0x00000001853B27D0-0x00000001853B2804
	public static extern void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(IntPtr jarg1, bool jarg2); // 0x000000018479E790-0x000000018479E7E0
	public static extern bool CSharp_AkInitSettings_bEnableGameSyncPreparation_get(IntPtr jarg1); // 0x00000001853B2488-0x00000001853B2500
	public static extern void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(IntPtr jarg1, uint jarg2); // 0x000000018479E6F0-0x000000018479E730
	public static extern uint CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(IntPtr jarg1); // 0x00000001853B2804-0x00000001853B2838
	public static extern void CSharp_AkInitSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2); // 0x00000001845E1EC0-0x00000001845E1F00
	public static extern uint CSharp_AkInitSettings_uNumSamplesPerFrame_get(IntPtr jarg1); // 0x00000001853B2948-0x00000001853B297C
	public static extern void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(IntPtr jarg1, uint jarg2); // 0x000000018479E650-0x000000018479E690
	public static extern uint CSharp_AkInitSettings_uMonitorQueuePoolSize_get(IntPtr jarg1); // 0x00000001853B2914-0x00000001853B2948
	public static extern void CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_set(IntPtr jarg1, uint jarg2); // 0x00000001853B286C-0x00000001853B28AC
	public static extern uint CSharp_AkInitSettings_uCpuMonitorQueueMaxSize_get(IntPtr jarg1); // 0x00000001853B2838-0x00000001853B286C
	public static extern void CSharp_AkInitSettings_settingsMainOutput_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2718-0x00000001853B275C
	public static extern IntPtr CSharp_AkInitSettings_settingsMainOutput_get(IntPtr jarg1); // 0x00000001845E1DC0-0x00000001845E1E00
	public static extern void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(IntPtr jarg1, uint jarg2); // 0x000000018479E5B0-0x000000018479E5F0
	public static extern uint CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(IntPtr jarg1); // 0x00000001853B28AC-0x00000001853B28E0
	public static extern void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(IntPtr jarg1, bool jarg2); // 0x00000001853B25B4-0x00000001853B25F8
	public static extern bool CSharp_AkInitSettings_bUseSoundBankMgrThread_get(IntPtr jarg1); // 0x00000001853B257C-0x00000001853B25B4
	public static extern void CSharp_AkInitSettings_bUseLEngineThread_set(IntPtr jarg1, bool jarg2); // 0x00000001853B2538-0x00000001853B257C
	public static extern bool CSharp_AkInitSettings_bUseLEngineThread_get(IntPtr jarg1); // 0x00000001853B2500-0x00000001853B2538
	public static extern void CSharp_AkInitSettings_szPluginDLLPath_set(IntPtr jarg1, string jarg2); // 0x00000001845E2470-0x00000001845E2510
	public static extern IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(IntPtr jarg1); // 0x00000001845E1C50-0x00000001845E1C90
	public static extern void CSharp_AkInitSettings_eFloorPlane_set(IntPtr jarg1, int jarg2); // 0x00000001853B262C-0x00000001853B266C
	public static extern int CSharp_AkInitSettings_eFloorPlane_get(IntPtr jarg1); // 0x00000001853B25F8-0x00000001853B262C
	public static extern void CSharp_AkInitSettings_fGameUnitsToMeters_set(IntPtr jarg1, float jarg2); // 0x00000001853B26D4-0x00000001853B2718
	public static extern float CSharp_AkInitSettings_fGameUnitsToMeters_get(IntPtr jarg1); // 0x00000001853B26A0-0x00000001853B26D4
	public static extern void CSharp_AkInitSettings_uBankReadBufferSize_set(IntPtr jarg1, uint jarg2); // 0x00000001853B2790-0x00000001853B27D0
	public static extern uint CSharp_AkInitSettings_uBankReadBufferSize_get(IntPtr jarg1); // 0x00000001853B275C-0x00000001853B2790
	public static extern void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(IntPtr jarg1, float jarg2); // 0x000000018479E500-0x000000018479E550
	public static extern float CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(IntPtr jarg1); // 0x00000001853B266C-0x00000001853B26A0
	public static extern void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(IntPtr jarg1, bool jarg2); // 0x000000018479E450-0x000000018479E4A0
	public static extern bool CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(IntPtr jarg1); // 0x00000001853B2450-0x00000001853B2488
	public static extern void CSharp_delete_AkInitSettings(IntPtr jarg1); // 0x00000001853C4A10-0x00000001853C4A44
	public static extern void CSharp_AkSourceSettings_sourceID_set(IntPtr jarg1, uint jarg2); // 0x00000001853B8B68-0x00000001853B8BA8
	public static extern uint CSharp_AkSourceSettings_sourceID_get(IntPtr jarg1); // 0x00000001853B8B34-0x00000001853B8B68
	public static extern void CSharp_AkSourceSettings_pMediaMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B8AF0-0x00000001853B8B34
	public static extern IntPtr CSharp_AkSourceSettings_pMediaMemory_get(IntPtr jarg1); // 0x00000001853B8ABC-0x00000001853B8AF0
	public static extern void CSharp_AkSourceSettings_uMediaSize_set(IntPtr jarg1, uint jarg2); // 0x00000001853B8BDC-0x00000001853B8C1C
	public static extern uint CSharp_AkSourceSettings_uMediaSize_get(IntPtr jarg1); // 0x00000001853B8BA8-0x00000001853B8BDC
	public static extern void CSharp_AkSourceSettings_Clear(IntPtr jarg1); // 0x00000001853B8A10-0x00000001853B8A44
	public static extern int CSharp_AkSourceSettings_GetSizeOf(); // 0x00000001853B8A88-0x00000001853B8ABC
	public static extern void CSharp_AkSourceSettings_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B8A44-0x00000001853B8A88
	public static extern IntPtr CSharp_new_AkSourceSettings(); // 0x00000001853C645C-0x00000001853C6488
	public static extern void CSharp_delete_AkSourceSettings(IntPtr jarg1); // 0x00000001853C512C-0x00000001853C5160
	public static extern bool CSharp_IsInitialized(); // 0x0000000183AC7810-0x0000000183AC7880
	public static extern int CSharp_GetAudioSettings(IntPtr jarg1); // 0x00000001853BB088-0x00000001853BB0BC
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(ulong jarg1); // 0x00000001853BCA38-0x00000001853BCAB0
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_1(); // 0x0000000183AC75B0-0x0000000183AC75E0
	public static extern int CSharp_GetOutputDeviceConfiguration(ulong jarg1, IntPtr jarg2, IntPtr jarg3); // 0x00000001853BBBF8-0x00000001853BBC88
	public static extern int CSharp_GetPanningRule__SWIG_0(out int jarg1, ulong jarg2); // 0x00000001853BBDA8-0x00000001853BBE2C
	public static extern int CSharp_GetPanningRule__SWIG_1(out int jarg1); // 0x00000001853BBE2C-0x00000001853BBEA4
	public static extern int CSharp_SetPanningRule__SWIG_0(int jarg1, ulong jarg2); // 0x00000001853C2B50-0x00000001853C2BD0
	public static extern int CSharp_SetPanningRule__SWIG_1(int jarg1); // 0x00000001853C2BD0-0x00000001853C2C48
	public static extern int CSharp_GetSpeakerAngles__SWIG_0([In, Out] float[] jarg1, ref uint jarg2, out float jarg3, ulong jarg4); // 0x00000001853BC8F4-0x00000001853BC99C
	public static extern int CSharp_GetSpeakerAngles__SWIG_1([In, Out] float[] jarg1, ref uint jarg2, out float jarg3); // 0x00000001853BC99C-0x00000001853BCA38
	public static extern int CSharp_SetSpeakerAngles__SWIG_0(in float[] jarg1, uint jarg2, float jarg3, ulong jarg4); // 0x00000001853C32D8-0x00000001853C333C
	public static extern int CSharp_SetSpeakerAngles__SWIG_1(in float[] jarg1, uint jarg2, float jarg3); // 0x00000001853C333C-0x00000001853C3390
	public static extern int CSharp_SetVolumeThreshold(float jarg1); // 0x00000001853C3558-0x00000001853C358C
	public static extern int CSharp_SetMaxNumVoicesLimit(ushort jarg1); // 0x00000001853C23C4-0x00000001853C243C
	public static extern int CSharp_SetJobMgrMaxActiveWorkers(uint jarg1, uint jarg2); // 0x00000001853C213C-0x00000001853C21BC
	public static extern int CSharp_RenderAudio__SWIG_0(bool jarg1); // 0x00000001853C011C-0x00000001853C0194
	public static extern int CSharp_RenderAudio__SWIG_1(); // 0x000000018328B410-0x000000018328B440
	public static extern int CSharp_RegisterPluginDLL__SWIG_0(string jarg1, string jarg2); // 0x00000001853BFD60-0x00000001853BFDF8
	public static extern int CSharp_RegisterPluginDLL__SWIG_1(string jarg1); // 0x00000001853BFDF8-0x00000001853BFE38
	public static extern bool CSharp_IsPluginRegistered(int jarg1, uint jarg2, uint jarg3); // 0x00000001853BD0E8-0x00000001853BD17C
	public static extern uint CSharp_GetIDFromString__SWIG_0(string jarg1); // 0x0000000183EB0690-0x0000000183EB06D0
	public static extern uint CSharp_PostEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8); // 0x00000001853BE460-0x00000001853BE500
	public static extern uint CSharp_PostEvent__SWIG_1(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7); // 0x0000000183ABEEE0-0x0000000183ABF0A0
	public static extern uint CSharp_PostEvent__SWIG_2(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x000000018328CBB0-0x000000018328CC10
	public static extern uint CSharp_PostEvent__SWIG_3(uint jarg1, ulong jarg2); // 0x00000001853BE500-0x00000001853BE580
	public static extern uint CSharp_PostEvent__SWIG_4(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8); // 0x00000001853BE580-0x00000001853BE630
	public static extern uint CSharp_PostEvent__SWIG_5(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7); // 0x00000001853BE630-0x00000001853BE6DC
	public static extern uint CSharp_PostEvent__SWIG_6(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x00000001853BE6DC-0x00000001853BE788
	public static extern uint CSharp_PostEvent__SWIG_7(string jarg1, ulong jarg2); // 0x00000001853BE788-0x00000001853BE814
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_0(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6); // 0x00000001853BA970-0x00000001853BAA0C
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_1(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5); // 0x00000001853BAA0C-0x00000001853BAAA8
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_2(uint jarg1, int jarg2, ulong jarg3, int jarg4); // 0x00000001853BAAA8-0x00000001853BAB44
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_3(uint jarg1, int jarg2, ulong jarg3); // 0x00000001853BAB44-0x00000001853BABD0
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_4(uint jarg1, int jarg2); // 0x00000001853BABD0-0x00000001853BAC50
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_5(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6); // 0x00000001853BAC50-0x00000001853BACF8
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_6(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5); // 0x00000001853BACF8-0x00000001853BADA0
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_7(string jarg1, int jarg2, ulong jarg3, int jarg4); // 0x00000001853BADA0-0x00000001853BAE48
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_8(string jarg1, int jarg2, ulong jarg3); // 0x00000001853BAE48-0x00000001853BAEE0
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_9(string jarg1, int jarg2); // 0x00000001853BAEE0-0x00000001853BAF6C
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8, uint jarg9); // 0x00000001853BE814-0x00000001853BE8CC
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8); // 0x00000001853BE8CC-0x00000001853BE97C
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_2(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4, bool jarg5); // 0x00000001853BE97C-0x00000001853BEA2C
	public static extern uint CSharp_PostMIDIOnEvent__SWIG_3(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4); // 0x00000001853BEA2C-0x00000001853BEACC
	public static extern int CSharp_StopMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3); // 0x00000001853C3804-0x00000001853C3894
	public static extern int CSharp_StopMIDIOnEvent__SWIG_1(uint jarg1, ulong jarg2); // 0x00000001853C3894-0x00000001853C38D4
	public static extern int CSharp_StopMIDIOnEvent__SWIG_2(uint jarg1); // 0x00000001853C38D4-0x00000001853C3908
	public static extern int CSharp_StopMIDIOnEvent__SWIG_3(); // 0x00000001853C3908-0x00000001853C3970
	public static extern int CSharp_PinEventInStreamCache__SWIG_0(uint jarg1, sbyte jarg2, sbyte jarg3); // 0x00000001853BDFB8-0x00000001853BE048
	public static extern int CSharp_PinEventInStreamCache__SWIG_1(string jarg1, sbyte jarg2, sbyte jarg3); // 0x00000001853BE048-0x00000001853BE0E4
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_0(uint jarg1); // 0x00000001853C41C8-0x00000001853C4240
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_1(string jarg1); // 0x00000001853C4240-0x00000001853C42BC
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_0(uint jarg1, out float jarg2, out int jarg3); // 0x00000001853BB128-0x00000001853BB1B8
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_1(string jarg1, out float jarg2, out int jarg3); // 0x00000001853BB1B8-0x00000001853BB260
	public static extern int CSharp_SeekOnEvent__SWIG_0(uint jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5); // 0x00000001853C0EEC-0x00000001853C0F8C
	public static extern int CSharp_SeekOnEvent__SWIG_1(uint jarg1, ulong jarg2, int jarg3, bool jarg4); // 0x00000001853C115C-0x00000001853C11FC
	public static extern int CSharp_SeekOnEvent__SWIG_2(uint jarg1, ulong jarg2, int jarg3); // 0x00000001853C11FC-0x00000001853C128C
	public static extern int CSharp_SeekOnEvent__SWIG_3(string jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5); // 0x00000001853C128C-0x00000001853C1338
	public static extern int CSharp_SeekOnEvent__SWIG_4(string jarg1, ulong jarg2, int jarg3, bool jarg4); // 0x00000001853C1338-0x00000001853C13E4
	public static extern int CSharp_SeekOnEvent__SWIG_5(string jarg1, ulong jarg2, int jarg3); // 0x00000001853C13E4-0x00000001853C1480
	public static extern int CSharp_SeekOnEvent__SWIG_9(uint jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5); // 0x00000001853C1480-0x00000001853C14DC
	public static extern int CSharp_SeekOnEvent__SWIG_10(uint jarg1, ulong jarg2, float jarg3, bool jarg4); // 0x00000001853C0F8C-0x00000001853C0FE8
	public static extern int CSharp_SeekOnEvent__SWIG_11(uint jarg1, ulong jarg2, float jarg3); // 0x00000001853C0FE8-0x00000001853C1034
	public static extern int CSharp_SeekOnEvent__SWIG_12(string jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5); // 0x00000001853C1034-0x00000001853C109C
	public static extern int CSharp_SeekOnEvent__SWIG_13(string jarg1, ulong jarg2, float jarg3, bool jarg4); // 0x00000001853C109C-0x00000001853C1104
	public static extern int CSharp_SeekOnEvent__SWIG_14(string jarg1, ulong jarg2, float jarg3); // 0x00000001853C1104-0x00000001853C115C
	public static extern void CSharp_CancelEventCallbackCookie(IntPtr jarg1); // 0x00000001853B9B60-0x00000001853B9B94
	public static extern void CSharp_CancelEventCallbackGameObject(ulong jarg1); // 0x00000001853B9B94-0x00000001853B9BC8
	public static extern void CSharp_CancelEventCallback(uint jarg1); // 0x00000001853B9BC8-0x00000001853B9BFC
	public static extern int CSharp_GetSourcePlayPosition__SWIG_0(uint jarg1, out int jarg2, bool jarg3); // 0x00000001853BC754-0x00000001853BC7E4
	public static extern int CSharp_GetSourcePlayPosition__SWIG_1(uint jarg1, out int jarg2); // 0x00000001853BC7E4-0x00000001853BC864
	public static extern int CSharp_GetSourceStreamBuffering(uint jarg1, out int jarg2, out int jarg3); // 0x00000001853BC864-0x00000001853BC8F4
	public static extern void CSharp_StopAll__SWIG_0(ulong jarg1); // 0x0000000183CE32E0-0x0000000183CE3380
	public static extern void CSharp_StopAll__SWIG_1(); // 0x00000001853C37A4-0x00000001853C37D0
	public static extern void CSharp_StopPlayingID__SWIG_0(uint jarg1, int jarg2, int jarg3); // 0x00000001853C399C-0x00000001853C3A28
	public static extern void CSharp_StopPlayingID__SWIG_1(uint jarg1, int jarg2); // 0x00000001853C3A28-0x00000001853C3AA8
	public static extern void CSharp_StopPlayingID__SWIG_2(uint jarg1); // 0x00000001853C3AA8-0x00000001853C3B20
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_0(int jarg1, uint jarg2, int jarg3, int jarg4); // 0x00000001853BAF6C-0x00000001853BB008
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_1(int jarg1, uint jarg2, int jarg3); // 0x0000000183870310-0x0000000183870420
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_2(int jarg1, uint jarg2); // 0x00000001853BB008-0x00000001853BB088
	public static extern void CSharp_SetRandomSeed(uint jarg1); // 0x00000001853C3260-0x00000001853C32D8
	public static extern void CSharp_MuteBackgroundMusic(bool jarg1); // 0x00000001853BDF14-0x00000001853BDF8C
	public static extern bool CSharp_GetBackgroundMusicMute(); // 0x00000001853BB0BC-0x00000001853BB128
	public static extern int CSharp_SendPluginCustomGameData(uint jarg1, ulong jarg2, int jarg3, uint jarg4, uint jarg5, IntPtr jarg6, uint jarg7); // 0x00000001853C1578-0x00000001853C1618
	public static extern int CSharp_UnregisterAllGameObj(); // 0x00000001853C42BC-0x00000001853C42E8
	public static extern int CSharp_SetMultiplePositions__SWIG_0(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4, int jarg5); // 0x00000001853C2668-0x00000001853C270C
	public static extern int CSharp_SetMultiplePositions__SWIG_1(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4); // 0x0000000183B8B730-0x0000000183B8B790
	public static extern int CSharp_SetMultiplePositions__SWIG_2(ulong jarg1, IntPtr jarg2, ushort jarg3); // 0x00000001853C270C-0x00000001853C27A0
	public static extern int CSharp_SetMultiplePositions__SWIG_3(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4, int jarg5); // 0x00000001853C27A0-0x00000001853C2844
	public static extern int CSharp_SetMultiplePositions__SWIG_4(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4); // 0x00000001853C2844-0x00000001853C28E8
	public static extern int CSharp_SetMultiplePositions__SWIG_5(ulong jarg1, IntPtr jarg2, ushort jarg3); // 0x00000001853C28E8-0x00000001853C297C
	public static extern int CSharp_SetScalingFactor(ulong jarg1, float jarg2); // 0x0000000183E59660-0x0000000183E596F0
	public static extern int CSharp_SetDistanceProbe(ulong jarg1, ulong jarg2); // 0x00000001853C1B24-0x00000001853C1BA8
	public static extern int CSharp_ClearBanks(); // 0x00000001853B9D28-0x00000001853B9D54
	public static extern int CSharp_SetBankLoadIOSettings(float jarg1, sbyte jarg2); // 0x00000001853C173C-0x00000001853C1778
	public static extern int CSharp_LoadBank__SWIG_0(string jarg1, out uint jarg2, uint jarg3); // 0x00000001853BD6D4-0x00000001853BD770
	public static extern int CSharp_LoadBank__SWIG_1(string jarg1, out uint jarg2); // 0x00000001853BD770-0x00000001853BD7FC
	public static extern int CSharp_LoadBank__SWIG_4(uint jarg1, uint jarg2); // 0x00000001853BD7FC-0x00000001853BD87C
	public static extern int CSharp_LoadBank__SWIG_5(uint jarg1); // 0x0000000183EB47F0-0x0000000183EB4870
	public static extern int CSharp_LoadBankMemoryView__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3); // 0x00000001853BD464-0x00000001853BD4F4
	public static extern int CSharp_LoadBankMemoryView__SWIG_1(IntPtr jarg1, uint jarg2, out uint jarg3, out uint jarg4); // 0x00000001853BD4F4-0x00000001853BD594
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3); // 0x00000001853BD1F4-0x00000001853BD284
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_1(IntPtr jarg1, uint jarg2, out uint jarg3, out uint jarg4); // 0x00000001853BD284-0x00000001853BD324
	public static extern int CSharp_LoadBank__SWIG_6(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4, uint jarg5); // 0x00000001853BD87C-0x00000001853BD928
	public static extern int CSharp_LoadBank__SWIG_7(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4); // 0x00000001853BD928-0x00000001853BD9D4
	public static extern int CSharp_LoadBank__SWIG_10(uint jarg1, IntPtr jarg2, IntPtr jarg3, uint jarg4); // 0x0000000183EB0DB0-0x0000000183EB0E10
	public static extern int CSharp_LoadBank__SWIG_11(uint jarg1, IntPtr jarg2, IntPtr jarg3); // 0x0000000183EB11D0-0x0000000183EB1220
	public static extern int CSharp_LoadBankMemoryView__SWIG_2(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5); // 0x00000001853BD594-0x00000001853BD634
	public static extern int CSharp_LoadBankMemoryView__SWIG_3(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5, out uint jarg6); // 0x00000001853BD634-0x00000001853BD6D4
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_2(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5); // 0x00000001853BD324-0x00000001853BD3C4
	public static extern int CSharp_LoadBankMemoryCopy__SWIG_3(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5, out uint jarg6); // 0x00000001853BD3C4-0x00000001853BD464
	public static extern int CSharp_UnloadBank__SWIG_0(string jarg1, IntPtr jarg2, uint jarg3); // 0x00000001853C3D64-0x00000001853C3E00
	public static extern int CSharp_UnloadBank__SWIG_1(string jarg1, IntPtr jarg2); // 0x00000001853C3EA0-0x00000001853C3F2C
	public static extern int CSharp_UnloadBank__SWIG_4(uint jarg1, IntPtr jarg2, uint jarg3); // 0x00000001853C3F2C-0x00000001853C3FBC
	public static extern int CSharp_UnloadBank__SWIG_5(uint jarg1, IntPtr jarg2); // 0x00000001853C3FBC-0x00000001853C403C
	public static extern int CSharp_UnloadBank__SWIG_6(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5); // 0x00000001853C403C-0x00000001853C40E8
	public static extern int CSharp_UnloadBank__SWIG_7(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001853C40E8-0x00000001853C4194
	public static extern int CSharp_UnloadBank__SWIG_10(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5); // 0x0000000183EB1010-0x0000000183EB1070
	public static extern int CSharp_UnloadBank__SWIG_11(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001853C3E00-0x00000001853C3EA0
	public static extern void CSharp_CancelBankCallbackCookie(IntPtr jarg1); // 0x00000001853B9B2C-0x00000001853B9B60
	public static extern int CSharp_PrepareBank__SWIG_0(int jarg1, string jarg2, int jarg3, uint jarg4); // 0x00000001853BEEC8-0x00000001853BEF70
	public static extern int CSharp_PrepareBank__SWIG_1(int jarg1, string jarg2, int jarg3); // 0x00000001853BF294-0x00000001853BF32C
	public static extern int CSharp_PrepareBank__SWIG_2(int jarg1, string jarg2); // 0x00000001853BF32C-0x00000001853BF3B8
	public static extern int CSharp_PrepareBank__SWIG_6(int jarg1, uint jarg2, int jarg3, uint jarg4); // 0x00000001853BF3B8-0x00000001853BF454
	public static extern int CSharp_PrepareBank__SWIG_7(int jarg1, uint jarg2, int jarg3); // 0x00000001853BF454-0x00000001853BF4E0
	public static extern int CSharp_PrepareBank__SWIG_8(int jarg1, uint jarg2); // 0x00000001853BF4E0-0x00000001853BF560
	public static extern int CSharp_PrepareBank__SWIG_9(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, uint jarg6); // 0x00000001853BF560-0x00000001853BF608
	public static extern int CSharp_PrepareBank__SWIG_10(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x00000001853BEF70-0x00000001853BF018
	public static extern int CSharp_PrepareBank__SWIG_11(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001853BF018-0x00000001853BF0C0
	public static extern int CSharp_PrepareBank__SWIG_15(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, uint jarg6); // 0x00000001853BF0C0-0x00000001853BF15C
	public static extern int CSharp_PrepareBank__SWIG_16(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5); // 0x00000001853BF15C-0x00000001853BF1F8
	public static extern int CSharp_PrepareBank__SWIG_17(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4); // 0x00000001853BF1F8-0x00000001853BF294
	public static extern int CSharp_ClearPreparedEvents(); // 0x00000001853B9EA4-0x00000001853B9F0C
	public static extern int CSharp_PrepareEvent__SWIG_0(int jarg1, IntPtr jarg2, uint jarg3); // 0x00000001853BF608-0x00000001853BF698
	public static extern int CSharp_PrepareEvent__SWIG_1(int jarg1, in uint[] jarg2, uint jarg3); // 0x00000001853BF698-0x00000001853BF730
	public static extern int CSharp_PrepareEvent__SWIG_2(int jarg1, IntPtr jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x00000001853BF730-0x00000001853BF7D0
	public static extern int CSharp_PrepareEvent__SWIG_3(int jarg1, in uint[] jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5); // 0x0000000183EB0E10-0x0000000183EB0E80
	public static extern int CSharp_SetMedia(IntPtr jarg1, uint jarg2); // 0x00000001853C243C-0x00000001853C24BC
	public static extern int CSharp_UnsetMedia(IntPtr jarg1, uint jarg2); // 0x00000001853C4350-0x00000001853C43D0
	public static extern int CSharp_PrepareGameSyncs__SWIG_0(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5); // 0x00000001853BF7D0-0x00000001853BF878
	public static extern int CSharp_PrepareGameSyncs__SWIG_1(int jarg1, int jarg2, uint jarg3, in uint[] jarg4, uint jarg5); // 0x00000001853BF878-0x00000001853BF920
	public static extern int CSharp_PrepareGameSyncs__SWIG_2(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7); // 0x00000001853BF920-0x00000001853BF9C8
	public static extern int CSharp_PrepareGameSyncs__SWIG_3(int jarg1, int jarg2, uint jarg3, in uint[] jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7); // 0x00000001853BF9C8-0x00000001853BFA70
	public static extern int CSharp_AddListener(ulong jarg1, ulong jarg2); // 0x00000001853AE70C-0x00000001853AE790
	public static extern int CSharp_RemoveListener(ulong jarg1, ulong jarg2); // 0x00000001853BFFEC-0x00000001853C0070
	public static extern int CSharp_AddDefaultListener(ulong jarg1); // 0x00000001853AE694-0x00000001853AE70C
	public static extern int CSharp_RemoveDefaultListener(ulong jarg1); // 0x00000001853BFE38-0x00000001853BFE6C
	public static extern int CSharp_ResetListenersToDefault(ulong jarg1); // 0x00000001853C02A8-0x00000001853C0320
	public static extern int CSharp_SetListenerSpatialization__SWIG_0(ulong jarg1, bool jarg2, IntPtr jarg3, in float[] jarg4); // 0x00000001853C21BC-0x00000001853C2264
	public static extern int CSharp_SetListenerSpatialization__SWIG_1(ulong jarg1, bool jarg2, IntPtr jarg3); // 0x00000001853C2264-0x00000001853C22F4
	public static extern int CSharp_SetRTPCValue__SWIG_0(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001853C2F38-0x00000001853C2F9C
	public static extern int CSharp_SetRTPCValue__SWIG_1(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5); // 0x00000001853C2F9C-0x00000001853C2FF8
	public static extern int CSharp_SetRTPCValue__SWIG_2(uint jarg1, float jarg2, ulong jarg3, int jarg4); // 0x0000000183197CC0-0x0000000183197D20
	public static extern int CSharp_SetRTPCValue__SWIG_3(uint jarg1, float jarg2, ulong jarg3); // 0x00000001853C2FF8-0x00000001853C3044
	public static extern int CSharp_SetRTPCValue__SWIG_4(uint jarg1, float jarg2); // 0x00000001853C3044-0x00000001853C3080
	public static extern int CSharp_SetRTPCValue__SWIG_5(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001853C3080-0x00000001853C30F0
	public static extern int CSharp_SetRTPCValue__SWIG_6(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5); // 0x00000001853C30F0-0x00000001853C3158
	public static extern int CSharp_SetRTPCValue__SWIG_7(string jarg1, float jarg2, ulong jarg3, int jarg4); // 0x00000001853C3158-0x00000001853C31C0
	public static extern int CSharp_SetRTPCValue__SWIG_8(string jarg1, float jarg2, ulong jarg3); // 0x00000001853C31C0-0x00000001853C3218
	public static extern int CSharp_SetRTPCValue__SWIG_9(string jarg1, float jarg2); // 0x00000001853C3218-0x00000001853C3260
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_0(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001853C2C94-0x00000001853C2CF8
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_1(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5); // 0x00000001853C2CF8-0x00000001853C2D54
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_2(uint jarg1, float jarg2, uint jarg3, int jarg4); // 0x00000001845E4400-0x00000001845E4460
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_3(uint jarg1, float jarg2, uint jarg3); // 0x00000001853C2D54-0x00000001853C2DA0
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_4(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6); // 0x00000001853C2DA0-0x00000001853C2E10
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_5(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5); // 0x00000001853C2E10-0x00000001853C2E78
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_6(string jarg1, float jarg2, uint jarg3, int jarg4); // 0x00000001853C2E78-0x00000001853C2EE0
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_7(string jarg1, float jarg2, uint jarg3); // 0x00000001853C2EE0-0x00000001853C2F38
	public static extern int CSharp_ResetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5); // 0x00000001853C07FC-0x00000001853C08A8
	public static extern int CSharp_ResetRTPCValue__SWIG_1(uint jarg1, ulong jarg2, int jarg3, int jarg4); // 0x00000001853C08A8-0x00000001853C0948
	public static extern int CSharp_ResetRTPCValue__SWIG_2(uint jarg1, ulong jarg2, int jarg3); // 0x00000001853C0948-0x00000001853C09D8
	public static extern int CSharp_ResetRTPCValue__SWIG_3(uint jarg1, ulong jarg2); // 0x00000001853C09D8-0x00000001853C0A18
	public static extern int CSharp_ResetRTPCValue__SWIG_4(uint jarg1); // 0x00000001853C0A18-0x00000001853C0A4C
	public static extern int CSharp_ResetRTPCValue__SWIG_5(string jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5); // 0x00000001853C0A4C-0x00000001853C0B08
	public static extern int CSharp_ResetRTPCValue__SWIG_6(string jarg1, ulong jarg2, int jarg3, int jarg4); // 0x00000001853C0B08-0x00000001853C0BB4
	public static extern int CSharp_ResetRTPCValue__SWIG_7(string jarg1, ulong jarg2, int jarg3); // 0x00000001853C0BB4-0x00000001853C0C4C
	public static extern int CSharp_ResetRTPCValue__SWIG_8(string jarg1, ulong jarg2); // 0x00000001853C0C4C-0x00000001853C0CD8
	public static extern int CSharp_ResetRTPCValue__SWIG_9(string jarg1); // 0x00000001853C0CD8-0x00000001853C0D54
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_0(uint jarg1, uint jarg2, int jarg3, int jarg4, bool jarg5); // 0x00000001853C0320-0x00000001853C03CC
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_1(uint jarg1, uint jarg2, int jarg3, int jarg4); // 0x00000001853C03CC-0x00000001853C0468
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_2(uint jarg1, uint jarg2, int jarg3); // 0x00000001853C0468-0x00000001853C04F4
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_3(uint jarg1, uint jarg2); // 0x00000001853C04F4-0x00000001853C0574
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_4(string jarg1, uint jarg2, int jarg3, int jarg4, bool jarg5); // 0x00000001853C0574-0x00000001853C0630
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_5(string jarg1, uint jarg2, int jarg3, int jarg4); // 0x00000001853C0630-0x00000001853C06D8
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_6(string jarg1, uint jarg2, int jarg3); // 0x00000001853C06D8-0x00000001853C0770
	public static extern int CSharp_ResetRTPCValueByPlayingID__SWIG_7(string jarg1, uint jarg2); // 0x00000001853C0770-0x00000001853C07FC
	public static extern int CSharp_SetSwitch__SWIG_0(uint jarg1, uint jarg2, ulong jarg3); // 0x00000001853C3428-0x00000001853C34B4
	public static extern int CSharp_SetSwitch__SWIG_1(string jarg1, string jarg2, ulong jarg3); // 0x00000001853C34B4-0x00000001853C3558
	public static extern int CSharp_PostTrigger__SWIG_0(uint jarg1, ulong jarg2); // 0x00000001853BEDFC-0x00000001853BEE3C
	public static extern int CSharp_PostTrigger__SWIG_1(string jarg1, ulong jarg2); // 0x00000001853BEE3C-0x00000001853BEEC8
	public static extern int CSharp_SetState__SWIG_0(uint jarg1, uint jarg2); // 0x0000000183A0CC30-0x0000000183A0CC70
	public static extern int CSharp_SetState__SWIG_1(string jarg1, string jarg2); // 0x00000001853C3390-0x00000001853C3428
	public static extern int CSharp_SetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, uint jarg3); // 0x00000001853C1D0C-0x00000001853C1D9C
	public static extern int CSharp_SetGameObjectOutputBusVolume(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001853C1E20-0x00000001853C1E6C
	public static extern int CSharp_SetActorMixerEffect(uint jarg1, uint jarg2, uint jarg3); // 0x00000001853C1618-0x00000001853C16A4
	public static extern int CSharp_SetBusEffect__SWIG_0(uint jarg1, uint jarg2, uint jarg3); // 0x00000001853C1A00-0x00000001853C1A8C
	public static extern int CSharp_SetBusEffect__SWIG_1(string jarg1, uint jarg2, uint jarg3); // 0x00000001853C1A8C-0x00000001853C1B24
	public static extern int CSharp_SetOutputDeviceEffect(ulong jarg1, uint jarg2, uint jarg3); // 0x00000001853C2A84-0x00000001853C2B14
	public static extern int CSharp_SetMixer__SWIG_0(uint jarg1, uint jarg2); // 0x00000001853C24BC-0x00000001853C253C
	public static extern int CSharp_SetMixer__SWIG_1(string jarg1, uint jarg2); // 0x00000001853C253C-0x00000001853C25C8
	public static extern int CSharp_SetBusConfig__SWIG_0(uint jarg1, IntPtr jarg2); // 0x00000001853C17B8-0x00000001853C1838
	public static extern int CSharp_SetBusConfig__SWIG_1(string jarg1, IntPtr jarg2); // 0x00000001853C1838-0x00000001853C18C4
	public static extern int CSharp_SetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, float jarg3, float jarg4); // 0x00000001853C297C-0x00000001853C29D8
	public static extern int CSharp_SetMultipleObstructionAndOcclusion(ulong jarg1, ulong jarg2, IntPtr jarg3, uint jarg4); // 0x00000001853C25C8-0x00000001853C2668
	public static extern int CSharp_StartOutputCapture(string jarg1); // 0x00000001853C35C0-0x00000001853C363C
	public static extern int CSharp_StopOutputCapture(); // 0x00000001853C3970-0x00000001853C399C
	public static extern int CSharp_AddOutputCaptureMarker(string jarg1); // 0x00000001853AE7D0-0x00000001853AE868
	public static extern int CSharp_AddOutputCaptureBinaryMarker(IntPtr jarg1, uint jarg2); // 0x00000001853AE790-0x00000001853AE7D0
	public static extern uint CSharp_GetSampleRate(); // 0x00000001853BC344-0x00000001853BC370
	public static extern int CSharp_StartProfilerCapture(string jarg1); // 0x00000001853C3668-0x00000001853C36E4
	public static extern int CSharp_StopProfilerCapture(); // 0x00000001853C3B4C-0x00000001853C3B78
	public static extern int CSharp_SetOfflineRenderingFrameTime(float jarg1); // 0x00000001853C29D8-0x00000001853C2A0C
	public static extern int CSharp_SetOfflineRendering(bool jarg1); // 0x00000001853C2A0C-0x00000001853C2A84
	public static extern int CSharp_RemoveOutput(ulong jarg1); // 0x00000001853C0070-0x00000001853C00E8
	public static extern int CSharp_ReplaceOutput__SWIG_0(IntPtr jarg1, ulong jarg2, out ulong jarg3); // 0x00000001853C0194-0x00000001853C0224
	public static extern int CSharp_ReplaceOutput__SWIG_1(IntPtr jarg1, ulong jarg2); // 0x00000001853C0224-0x00000001853C02A8
	public static extern ulong CSharp_GetOutputID__SWIG_0(uint jarg1, uint jarg2); // 0x00000001853BBC88-0x00000001853BBD08
	public static extern ulong CSharp_GetOutputID__SWIG_1(string jarg1, uint jarg2); // 0x00000001853BBD08-0x00000001853BBDA8
	public static extern int CSharp_SetBusDevice__SWIG_0(uint jarg1, uint jarg2); // 0x00000001853C18C4-0x00000001853C1944
	public static extern int CSharp_SetBusDevice__SWIG_1(string jarg1, string jarg2); // 0x00000001853C1944-0x00000001853C1A00
	public static extern int CSharp_GetDeviceList__SWIG_0(uint jarg1, uint jarg2, out uint jarg3, IntPtr jarg4); // 0x00000001853BB5EC-0x00000001853BB688
	public static extern int CSharp_GetDeviceList__SWIG_1(uint jarg1, out uint jarg2, IntPtr jarg3); // 0x0000000184009340-0x0000000184009390
	public static extern int CSharp_SetOutputVolume(ulong jarg1, float jarg2); // 0x00000001853C2B14-0x00000001853C2B50
	public static extern int CSharp_GetDeviceSpatialAudioSupport(uint jarg1); // 0x00000001840091E0-0x0000000184009220
	public static extern int CSharp_Suspend__SWIG_0(bool jarg1, bool jarg2); // 0x00000001853C3BAC-0x00000001853C3C2C
	public static extern int CSharp_Suspend__SWIG_1(bool jarg1); // 0x00000001853C3C2C-0x00000001853C3CA4
	public static extern int CSharp_Suspend__SWIG_2(); // 0x00000001853C3CA4-0x00000001853C3CD0
	public static extern int CSharp_WakeupFromSuspend__SWIG_0(uint jarg1); // 0x00000001853C4448-0x00000001853C447C
	public static extern int CSharp_WakeupFromSuspend__SWIG_1(); // 0x00000001853C447C-0x00000001853C44A8
	public static extern uint CSharp_GetBufferTick(); // 0x00000001853BB260-0x00000001853BB28C
	public static extern ulong CSharp_GetSampleTick(); // 0x00000001853BC370-0x00000001853BC39C
	public static extern void CSharp_AkSegmentInfo_iCurrentPosition_set(IntPtr jarg1, int jarg2); // 0x00000001853B8834-0x00000001853B88B4
	public static extern int CSharp_AkSegmentInfo_iCurrentPosition_get(IntPtr jarg1); // 0x00000001853B8800-0x00000001853B8834
	public static extern void CSharp_AkSegmentInfo_iPreEntryDuration_set(IntPtr jarg1, int jarg2); // 0x00000001853B895C-0x00000001853B899C
	public static extern int CSharp_AkSegmentInfo_iPreEntryDuration_get(IntPtr jarg1); // 0x00000001853B8928-0x00000001853B895C
	public static extern void CSharp_AkSegmentInfo_iActiveDuration_set(IntPtr jarg1, int jarg2); // 0x00000001853B87C0-0x00000001853B8800
	public static extern int CSharp_AkSegmentInfo_iActiveDuration_get(IntPtr jarg1); // 0x00000001853B878C-0x00000001853B87C0
	public static extern void CSharp_AkSegmentInfo_iPostExitDuration_set(IntPtr jarg1, int jarg2); // 0x00000001853B88E8-0x00000001853B8928
	public static extern int CSharp_AkSegmentInfo_iPostExitDuration_get(IntPtr jarg1); // 0x00000001853B88B4-0x00000001853B88E8
	public static extern void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(IntPtr jarg1, int jarg2); // 0x00000001853B89D0-0x00000001853B8A10
	public static extern int CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1); // 0x00000001853B899C-0x00000001853B89D0
	public static extern void CSharp_AkSegmentInfo_fBeatDuration_set(IntPtr jarg1, float jarg2); // 0x00000001853B8660-0x00000001853B86A4
	public static extern float CSharp_AkSegmentInfo_fBeatDuration_get(IntPtr jarg1); // 0x00000001853B862C-0x00000001853B8660
	public static extern void CSharp_AkSegmentInfo_fBarDuration_set(IntPtr jarg1, float jarg2); // 0x00000001853B85E8-0x00000001853B862C
	public static extern float CSharp_AkSegmentInfo_fBarDuration_get(IntPtr jarg1); // 0x00000001853B85B4-0x00000001853B85E8
	public static extern void CSharp_AkSegmentInfo_fGridDuration_set(IntPtr jarg1, float jarg2); // 0x00000001853B86D8-0x00000001853B871C
	public static extern float CSharp_AkSegmentInfo_fGridDuration_get(IntPtr jarg1); // 0x00000001853B86A4-0x00000001853B86D8
	public static extern void CSharp_AkSegmentInfo_fGridOffset_set(IntPtr jarg1, float jarg2); // 0x00000001853B8750-0x00000001853B878C
	public static extern float CSharp_AkSegmentInfo_fGridOffset_get(IntPtr jarg1); // 0x00000001853B871C-0x00000001853B8750
	public static extern IntPtr CSharp_new_AkSegmentInfo(); // 0x00000001853C6404-0x00000001853C6430
	public static extern void CSharp_delete_AkSegmentInfo(IntPtr jarg1); // 0x00000001853C50C4-0x00000001853C50F8
	public static extern void CSharp_AkResourceMonitorDataSummary_totalCPU_set(IntPtr jarg1, float jarg2); // 0x00000001853B822C-0x00000001853B8270
	public static extern float CSharp_AkResourceMonitorDataSummary_totalCPU_get(IntPtr jarg1); // 0x00000001853B81F8-0x00000001853B822C
	public static extern void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(IntPtr jarg1, float jarg2); // 0x00000001853B81BC-0x00000001853B81F8
	public static extern float CSharp_AkResourceMonitorDataSummary_pluginCPU_get(IntPtr jarg1); // 0x00000001853B8188-0x00000001853B81BC
	public static extern void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(IntPtr jarg1, uint jarg2); // 0x00000001853B8148-0x00000001853B8188
	public static extern uint CSharp_AkResourceMonitorDataSummary_physicalVoices_get(IntPtr jarg1); // 0x00000001853B8114-0x00000001853B8148
	public static extern void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(IntPtr jarg1, uint jarg2); // 0x00000001853B8318-0x00000001853B8358
	public static extern uint CSharp_AkResourceMonitorDataSummary_virtualVoices_get(IntPtr jarg1); // 0x00000001853B82E4-0x00000001853B8318
	public static extern void CSharp_AkResourceMonitorDataSummary_totalVoices_set(IntPtr jarg1, uint jarg2); // 0x00000001853B82A4-0x00000001853B82E4
	public static extern uint CSharp_AkResourceMonitorDataSummary_totalVoices_get(IntPtr jarg1); // 0x00000001853B8270-0x00000001853B82A4
	public static extern void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(IntPtr jarg1, uint jarg2); // 0x00000001853B80D4-0x00000001853B8114
	public static extern uint CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(IntPtr jarg1); // 0x00000001853B80A0-0x00000001853B80D4
	public static extern IntPtr CSharp_new_AkResourceMonitorDataSummary(); // 0x00000001853C63D8-0x00000001853C6404
	public static extern void CSharp_delete_AkResourceMonitorDataSummary(IntPtr jarg1); // 0x00000001853C505C-0x00000001853C5090
	public static extern byte CSharp_AK_INVALID_MIDI_CHANNEL_get(); // 0x00000001853AE2FC-0x00000001853AE364
	public static extern byte CSharp_AK_INVALID_MIDI_NOTE_get(); // 0x00000001853AE364-0x00000001853AE390
	public static extern void CSharp_AkMIDIEvent_byChan_set(IntPtr jarg1, byte jarg2); // 0x00000001853B395C-0x00000001853B399C
	public static extern byte CSharp_AkMIDIEvent_byChan_get(IntPtr jarg1); // 0x00000001853B3928-0x00000001853B395C
	public static extern void CSharp_AkMIDIEvent_tGen_byParam1_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3F60-0x00000001853B3FA0
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam1_get(IntPtr jarg1); // 0x00000001853B3F2C-0x00000001853B3F60
	public static extern void CSharp_AkMIDIEvent_tGen_byParam2_set(IntPtr jarg1, byte jarg2); // 0x00000001853B4018-0x00000001853B4058
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam2_get(IntPtr jarg1); // 0x00000001853B3FA0-0x00000001853B4018
	public static extern IntPtr CSharp_new_AkMIDIEvent_tGen(); // 0x00000001853C5CAC-0x00000001853C5CD8
	public static extern void CSharp_delete_AkMIDIEvent_tGen(IntPtr jarg1); // 0x00000001853C4B48-0x00000001853C4B7C
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(IntPtr jarg1, byte jarg2); // 0x00000001853B41B8-0x00000001853B41F8
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(IntPtr jarg1); // 0x00000001853B4184-0x00000001853B41B8
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(IntPtr jarg1, byte jarg2); // 0x00000001853B422C-0x00000001853B42AC
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(IntPtr jarg1); // 0x00000001853B41F8-0x00000001853B422C
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff(); // 0x00000001853C5D04-0x00000001853C5D30
	public static extern void CSharp_delete_AkMIDIEvent_tNoteOnOff(IntPtr jarg1); // 0x00000001853C4BB0-0x00000001853C4BE4
	public static extern void CSharp_AkMIDIEvent_tCc_byCc_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3D80-0x00000001853B3DC0
	public static extern byte CSharp_AkMIDIEvent_tCc_byCc_get(IntPtr jarg1); // 0x00000001853B3D4C-0x00000001853B3D80
	public static extern void CSharp_AkMIDIEvent_tCc_byValue_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3E38-0x00000001853B3EB8
	public static extern byte CSharp_AkMIDIEvent_tCc_byValue_get(IntPtr jarg1); // 0x00000001853B3DC0-0x00000001853B3E38
	public static extern IntPtr CSharp_new_AkMIDIEvent_tCc(); // 0x00000001853C5C54-0x00000001853C5C80
	public static extern void CSharp_delete_AkMIDIEvent_tCc(IntPtr jarg1); // 0x00000001853C4AE0-0x00000001853C4B14
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(IntPtr jarg1, byte jarg2); // 0x00000001853B42E0-0x00000001853B4360
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(IntPtr jarg1); // 0x00000001853B42AC-0x00000001853B42E0
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(IntPtr jarg1, byte jarg2); // 0x00000001853B4394-0x00000001853B4414
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(IntPtr jarg1); // 0x00000001853B4360-0x00000001853B4394
	public static extern IntPtr CSharp_new_AkMIDIEvent_tPitchBend(); // 0x00000001853C5D30-0x00000001853C5D5C
	public static extern void CSharp_delete_AkMIDIEvent_tPitchBend(IntPtr jarg1); // 0x00000001853C4BE4-0x00000001853C4C18
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(IntPtr jarg1, byte jarg2); // 0x00000001853B408C-0x00000001853B40CC
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(IntPtr jarg1); // 0x00000001853B4058-0x00000001853B408C
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(IntPtr jarg1, byte jarg2); // 0x00000001853B4144-0x00000001853B4184
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(IntPtr jarg1); // 0x00000001853B40CC-0x00000001853B4144
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch(); // 0x00000001853C5CD8-0x00000001853C5D04
	public static extern void CSharp_delete_AkMIDIEvent_tNoteAftertouch(IntPtr jarg1); // 0x00000001853C4B7C-0x00000001853C4BB0
	public static extern void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3EEC-0x00000001853B3F2C
	public static extern byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(IntPtr jarg1); // 0x00000001853B3EB8-0x00000001853B3EEC
	public static extern IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch(); // 0x00000001853C5C80-0x00000001853C5CAC
	public static extern void CSharp_delete_AkMIDIEvent_tChanAftertouch(IntPtr jarg1); // 0x00000001853C4B14-0x00000001853C4B48
	public static extern void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(IntPtr jarg1, byte jarg2); // 0x00000001853B448C-0x00000001853B44CC
	public static extern byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(IntPtr jarg1); // 0x00000001853B4414-0x00000001853B448C
	public static extern IntPtr CSharp_new_AkMIDIEvent_tProgramChange(); // 0x00000001853C5D5C-0x00000001853C5D88
	public static extern void CSharp_delete_AkMIDIEvent_tProgramChange(IntPtr jarg1); // 0x00000001853C4C18-0x00000001853C4C4C
	public static extern void CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(IntPtr jarg1, ushort jarg2); // 0x00000001853B45B4-0x00000001853B4638
	public static extern ushort CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(IntPtr jarg1); // 0x00000001853B4580-0x00000001853B45B4
	public static extern void CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(IntPtr jarg1, uint jarg2); // 0x00000001853B4500-0x00000001853B4580
	public static extern uint CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(IntPtr jarg1); // 0x00000001853B44CC-0x00000001853B4500
	public static extern IntPtr CSharp_new_AkMIDIEvent_tWwiseCmd(); // 0x00000001853C5D88-0x00000001853C5DBC
	public static extern void CSharp_delete_AkMIDIEvent_tWwiseCmd(IntPtr jarg1); // 0x00000001853C4C4C-0x00000001853C4C80
	public static extern void CSharp_AkMIDIEvent_Gen_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B33A4-0x00000001853B33E8
	public static extern IntPtr CSharp_AkMIDIEvent_Gen_get(IntPtr jarg1); // 0x00000001853B3370-0x00000001853B33A4
	public static extern void CSharp_AkMIDIEvent_Cc_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B326C-0x00000001853B32F0
	public static extern IntPtr CSharp_AkMIDIEvent_Cc_get(IntPtr jarg1); // 0x00000001853B3238-0x00000001853B326C
	public static extern void CSharp_AkMIDIEvent_NoteOnOff_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B3494-0x00000001853B34D8
	public static extern IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(IntPtr jarg1); // 0x00000001853B3460-0x00000001853B3494
	public static extern void CSharp_AkMIDIEvent_PitchBend_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B3514-0x00000001853B3558
	public static extern IntPtr CSharp_AkMIDIEvent_PitchBend_get(IntPtr jarg1); // 0x00000001853B34D8-0x00000001853B3514
	public static extern void CSharp_AkMIDIEvent_NoteAftertouch_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B341C-0x00000001853B3460
	public static extern IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(IntPtr jarg1); // 0x00000001853B33E8-0x00000001853B341C
	public static extern void CSharp_AkMIDIEvent_ChanAftertouch_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B332C-0x00000001853B3370
	public static extern IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(IntPtr jarg1); // 0x00000001853B32F0-0x00000001853B332C
	public static extern void CSharp_AkMIDIEvent_ProgramChange_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B358C-0x00000001853B35D0
	public static extern IntPtr CSharp_AkMIDIEvent_ProgramChange_get(IntPtr jarg1); // 0x00000001853B3558-0x00000001853B358C
	public static extern void CSharp_AkMIDIEvent_WwiseCmd_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B360C-0x00000001853B3650
	public static extern IntPtr CSharp_AkMIDIEvent_WwiseCmd_get(IntPtr jarg1); // 0x00000001853B35D0-0x00000001853B360C
	public static extern void CSharp_AkMIDIEvent_byType_set(IntPtr jarg1, int jarg2); // 0x00000001853B3BB0-0x00000001853B3BF0
	public static extern int CSharp_AkMIDIEvent_byType_get(IntPtr jarg1); // 0x00000001853B3B7C-0x00000001853B3BB0
	public static extern void CSharp_AkMIDIEvent_byOnOffNote_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3A88-0x00000001853B3B08
	public static extern byte CSharp_AkMIDIEvent_byOnOffNote_get(IntPtr jarg1); // 0x00000001853B3A54-0x00000001853B3A88
	public static extern void CSharp_AkMIDIEvent_byVelocity_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3D0C-0x00000001853B3D4C
	public static extern byte CSharp_AkMIDIEvent_byVelocity_get(IntPtr jarg1); // 0x00000001853B3CD8-0x00000001853B3D0C
	public static extern void CSharp_AkMIDIEvent_byCc_set(IntPtr jarg1, int jarg2); // 0x00000001853B37F0-0x00000001853B3830
	public static extern int CSharp_AkMIDIEvent_byCc_get(IntPtr jarg1); // 0x00000001853B37BC-0x00000001853B37F0
	public static extern void CSharp_AkMIDIEvent_byCcValue_set(IntPtr jarg1, byte jarg2); // 0x00000001853B377C-0x00000001853B37BC
	public static extern byte CSharp_AkMIDIEvent_byCcValue_get(IntPtr jarg1); // 0x00000001853B3704-0x00000001853B377C
	public static extern void CSharp_AkMIDIEvent_byValueLsb_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3C24-0x00000001853B3C64
	public static extern byte CSharp_AkMIDIEvent_byValueLsb_get(IntPtr jarg1); // 0x00000001853B3BF0-0x00000001853B3C24
	public static extern void CSharp_AkMIDIEvent_byValueMsb_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3C98-0x00000001853B3CD8
	public static extern byte CSharp_AkMIDIEvent_byValueMsb_get(IntPtr jarg1); // 0x00000001853B3C64-0x00000001853B3C98
	public static extern void CSharp_AkMIDIEvent_byAftertouchNote_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3684-0x00000001853B3704
	public static extern byte CSharp_AkMIDIEvent_byAftertouchNote_get(IntPtr jarg1); // 0x00000001853B3650-0x00000001853B3684
	public static extern void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3A14-0x00000001853B3A54
	public static extern byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(IntPtr jarg1); // 0x00000001853B399C-0x00000001853B3A14
	public static extern void CSharp_AkMIDIEvent_byChanAftertouchValue_set(IntPtr jarg1, byte jarg2); // 0x00000001853B38A8-0x00000001853B3928
	public static extern byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(IntPtr jarg1); // 0x00000001853B3830-0x00000001853B38A8
	public static extern void CSharp_AkMIDIEvent_byProgramNum_set(IntPtr jarg1, byte jarg2); // 0x00000001853B3B3C-0x00000001853B3B7C
	public static extern byte CSharp_AkMIDIEvent_byProgramNum_get(IntPtr jarg1); // 0x00000001853B3B08-0x00000001853B3B3C
	public static extern void CSharp_AkMIDIEvent_uCmd_set(IntPtr jarg1, ushort jarg2); // 0x00000001853B4724-0x00000001853B47A8
	public static extern ushort CSharp_AkMIDIEvent_uCmd_get(IntPtr jarg1); // 0x00000001853B46AC-0x00000001853B4724
	public static extern void CSharp_AkMIDIEvent_uArg_set(IntPtr jarg1, uint jarg2); // 0x00000001853B466C-0x00000001853B46AC
	public static extern uint CSharp_AkMIDIEvent_uArg_get(IntPtr jarg1); // 0x00000001853B4638-0x00000001853B466C
	public static extern IntPtr CSharp_new_AkMIDIEvent(); // 0x00000001853C5C28-0x00000001853C5C54
	public static extern void CSharp_delete_AkMIDIEvent(IntPtr jarg1); // 0x00000001853C4AAC-0x00000001853C4AE0
	public static extern void CSharp_AkMIDIPost_uOffset_set(IntPtr jarg1, ulong jarg2); // 0x00000001853B4B78-0x00000001853B4BBC
	public static extern ulong CSharp_AkMIDIPost_uOffset_get(IntPtr jarg1); // 0x00000001853B4B00-0x00000001853B4B78
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_0(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4); // 0x00000001853B4818-0x00000001853B48B8
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_1(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5); // 0x00000001853B48B8-0x00000001853B4968
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_2(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8); // 0x00000001853B4968-0x00000001853B4A18
	public static extern uint CSharp_AkMIDIPost_PostOnEvent__SWIG_3(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4, bool jarg5, uint jarg6, IntPtr jarg7, IntPtr jarg8, uint jarg9); // 0x00000001853B4A18-0x00000001853B4ACC
	public static extern void CSharp_AkMIDIPost_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B47A8-0x00000001853B47EC
	public static extern int CSharp_AkMIDIPost_GetSizeOf(); // 0x00000001853B47EC-0x00000001853B4818
	public static extern IntPtr CSharp_new_AkMIDIPost(); // 0x00000001853C5DBC-0x00000001853C5DE8
	public static extern void CSharp_delete_AkMIDIPost(IntPtr jarg1); // 0x00000001853C4C80-0x00000001853C4CB4
	public static extern void CSharp_AkMemCategroyStats_uUsed_set(IntPtr jarg1, ulong jarg2); // 0x00000001853B4E70-0x00000001853B4EF4
	public static extern ulong CSharp_AkMemCategroyStats_uUsed_get(IntPtr jarg1); // 0x00000001853B4E3C-0x00000001853B4E70
	public static extern void CSharp_AkMemCategroyStats_uPeakUsed_set(IntPtr jarg1, ulong jarg2); // 0x00000001853B4DB8-0x00000001853B4E3C
	public static extern ulong CSharp_AkMemCategroyStats_uPeakUsed_get(IntPtr jarg1); // 0x00000001853B4D40-0x00000001853B4DB8
	public static extern void CSharp_AkMemCategroyStats_uAllocs_set(IntPtr jarg1, uint jarg2); // 0x00000001853B4C8C-0x00000001853B4CCC
	public static extern uint CSharp_AkMemCategroyStats_uAllocs_get(IntPtr jarg1); // 0x00000001853B4C58-0x00000001853B4C8C
	public static extern void CSharp_AkMemCategroyStats_uFrees_set(IntPtr jarg1, uint jarg2); // 0x00000001853B4D00-0x00000001853B4D40
	public static extern uint CSharp_AkMemCategroyStats_uFrees_get(IntPtr jarg1); // 0x00000001853B4CCC-0x00000001853B4D00
	public static extern IntPtr CSharp_new_AkMemCategroyStats(); // 0x0000000184B44F60-0x0000000184B45040
	public static extern void CSharp_delete_AkMemCategroyStats(IntPtr jarg1); // 0x00000001853C4CE8-0x00000001853C4D1C
	public static extern void CSharp_AkMemGlobalStats_uUsed_set(IntPtr jarg1, ulong jarg2); // 0x00000001853B5290-0x00000001853B5314
	public static extern ulong CSharp_AkMemGlobalStats_uUsed_get(IntPtr jarg1); // 0x00000001853B5218-0x00000001853B5290
	public static extern void CSharp_AkMemGlobalStats_uDeviceUsed_set(IntPtr jarg1, ulong jarg2); // 0x00000001853B4FDC-0x00000001853B5060
	public static extern ulong CSharp_AkMemGlobalStats_uDeviceUsed_get(IntPtr jarg1); // 0x00000001853B4FA8-0x00000001853B4FDC
	public static extern void CSharp_AkMemGlobalStats_uReserved_set(IntPtr jarg1, ulong jarg2); // 0x00000001853B5194-0x00000001853B5218
	public static extern ulong CSharp_AkMemGlobalStats_uReserved_get(IntPtr jarg1); // 0x00000001853B511C-0x00000001853B5194
	public static extern void CSharp_AkMemGlobalStats_uMax_set(IntPtr jarg1, ulong jarg2); // 0x00000001853B50D8-0x00000001853B511C
	public static extern ulong CSharp_AkMemGlobalStats_uMax_get(IntPtr jarg1); // 0x00000001853B5060-0x00000001853B50D8
	public static extern IntPtr CSharp_new_AkMemGlobalStats(); // 0x00000001853C5E14-0x00000001853C5E40
	public static extern void CSharp_delete_AkMemGlobalStats(IntPtr jarg1); // 0x00000001853C4D1C-0x00000001853C4D50
	public static extern void CSharp_AkMemGetCategoryStats(int jarg1, IntPtr jarg2); // 0x00000001853B4EF4-0x00000001853B4F74
	public static extern void CSharp_AkMemGetGlobalStats(IntPtr jarg1); // 0x00000001853B4F74-0x00000001853B4FA8
	public static extern void CSharp_StartProfileThreadUsage(); // 0x00000001853C363C-0x00000001853C3668
	public static extern ulong CSharp_StopProfileThreadUsage(); // 0x00000001853C3B20-0x00000001853C3B4C
	public static extern void CSharp_DumpToFile(string jarg1); // 0x00000001853BA0CC-0x00000001853BA148
	public static extern ulong CSharp_GetGlobalUsed(); // 0x00000001853BB9A0-0x00000001853BB9CC
	public static extern ulong CSharp_GetGlobalReserved(); // 0x00000001853BB938-0x00000001853BB9A0
	public static extern void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(IntPtr jarg1, float jarg2); // 0x000000018400B3A0-0x000000018400B3F0
	public static extern float CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(IntPtr jarg1); // 0x00000001853B5534-0x00000001853B5568
	public static extern void CSharp_delete_AkMusicSettings(IntPtr jarg1); // 0x00000001853C4DB8-0x00000001853C4DEC
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_0(uint jarg1, IntPtr jarg2, bool jarg3); // 0x00000001853BBFB0-0x00000001853BC040
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_1(uint jarg1, IntPtr jarg2); // 0x00000001853BC040-0x00000001853BC0C0
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(IntPtr jarg1); // 0x000000018328C570-0x000000018328C5B0
	public static extern uint CSharp_AkSerializedCallbackHeader_eType_get(IntPtr jarg1); // 0x000000018328C630-0x000000018328C670
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_GetData(IntPtr jarg1); // 0x000000018328C530-0x000000018328C570
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(IntPtr jarg1); // 0x000000018328C5B0-0x000000018328C630
	public static extern IntPtr CSharp_new_AkSerializedCallbackHeader(); // 0x00000001853C6430-0x00000001853C645C
	public static extern void CSharp_delete_AkSerializedCallbackHeader(IntPtr jarg1); // 0x00000001853C50F8-0x00000001853C512C
	public static extern IntPtr CSharp_AkCallbackInfo_pCookie_get(IntPtr jarg1); // 0x000000018328DB70-0x000000018328DBF0
	public static extern ulong CSharp_AkCallbackInfo_gameObjID_get(IntPtr jarg1); // 0x000000018328DAA0-0x000000018328DAD0
	public static extern IntPtr CSharp_new_AkCallbackInfo(); // 0x00000001853C565C-0x00000001853C5688
	public static extern void CSharp_delete_AkCallbackInfo(IntPtr jarg1); // 0x00000001853C4738-0x00000001853C476C
	public static extern uint CSharp_AkEventCallbackInfo_playingID_get(IntPtr jarg1); // 0x00000001853B18A4-0x00000001853B18D8
	public static extern uint CSharp_AkEventCallbackInfo_eventID_get(IntPtr jarg1); // 0x000000018328DC40-0x000000018328DCD0
	public static extern IntPtr CSharp_new_AkEventCallbackInfo(); // 0x00000001853C583C-0x00000001853C5868
	public static extern void CSharp_delete_AkEventCallbackInfo(IntPtr jarg1); // 0x00000001853C490C-0x00000001853C4940
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChan_get(IntPtr jarg1); // 0x00000001853B2F64-0x00000001853B2F98
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(IntPtr jarg1); // 0x00000001853B3000-0x00000001853B3034
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(IntPtr jarg1); // 0x00000001853B3034-0x00000001853B30AC
	public static extern int CSharp_AkMIDIEventCallbackInfo_byType_get(IntPtr jarg1); // 0x00000001853B30E0-0x00000001853B3114
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(IntPtr jarg1); // 0x00000001853B2FCC-0x00000001853B3000
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(IntPtr jarg1); // 0x00000001853B31C0-0x00000001853B3238
	public static extern int CSharp_AkMIDIEventCallbackInfo_byCc_get(IntPtr jarg1); // 0x00000001853B2EFC-0x00000001853B2F30
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(IntPtr jarg1); // 0x00000001853B2EC8-0x00000001853B2EFC
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(IntPtr jarg1); // 0x00000001853B3114-0x00000001853B318C
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(IntPtr jarg1); // 0x00000001853B318C-0x00000001853B31C0
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(IntPtr jarg1); // 0x00000001853B2E94-0x00000001853B2EC8
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(IntPtr jarg1); // 0x00000001853B2F98-0x00000001853B2FCC
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(IntPtr jarg1); // 0x00000001853B2F30-0x00000001853B2F64
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(IntPtr jarg1); // 0x00000001853B30AC-0x00000001853B30E0
	public static extern IntPtr CSharp_new_AkMIDIEventCallbackInfo(); // 0x00000001853C5BFC-0x00000001853C5C28
	public static extern void CSharp_delete_AkMIDIEventCallbackInfo(IntPtr jarg1); // 0x00000001853C4A78-0x00000001853C4AAC
	public static extern uint CSharp_AkMarkerCallbackInfo_uIdentifier_get(IntPtr jarg1); // 0x00000001853B4BF0-0x00000001853B4C24
	public static extern uint CSharp_AkMarkerCallbackInfo_uPosition_get(IntPtr jarg1); // 0x00000001853B4C24-0x00000001853B4C58
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(IntPtr jarg1); // 0x00000001853B4BBC-0x00000001853B4BF0
	public static extern IntPtr CSharp_new_AkMarkerCallbackInfo(); // 0x00000001853C5DE8-0x00000001853C5E14
	public static extern void CSharp_delete_AkMarkerCallbackInfo(IntPtr jarg1); // 0x00000001853C4CB4-0x00000001853C4CE8
	public static extern float CSharp_AkDurationCallbackInfo_fDuration_get(IntPtr jarg1); // 0x00000001853B1764-0x00000001853B1798
	public static extern float CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(IntPtr jarg1); // 0x00000001853B1798-0x00000001853B17CC
	public static extern uint CSharp_AkDurationCallbackInfo_audioNodeID_get(IntPtr jarg1); // 0x00000001853B16F8-0x00000001853B172C
	public static extern uint CSharp_AkDurationCallbackInfo_mediaID_get(IntPtr jarg1); // 0x00000001853B17CC-0x00000001853B1800
	public static extern bool CSharp_AkDurationCallbackInfo_bStreaming_get(IntPtr jarg1); // 0x00000001853B172C-0x00000001853B1764
	public static extern IntPtr CSharp_new_AkDurationCallbackInfo(); // 0x00000001853C57E4-0x00000001853C5810
	public static extern void CSharp_delete_AkDurationCallbackInfo(IntPtr jarg1); // 0x00000001853C48A4-0x00000001853C48D8
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(IntPtr jarg1); // 0x00000001853B1870-0x00000001853B18A4
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(IntPtr jarg1); // 0x00000001853B1800-0x00000001853B1834
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(IntPtr jarg1); // 0x00000001853B1834-0x00000001853B1870
	public static extern IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo(); // 0x00000001853C5810-0x00000001853C583C
	public static extern void CSharp_delete_AkDynamicSequenceItemCallbackInfo(IntPtr jarg1); // 0x00000001853C48D8-0x00000001853C490C
	public static extern uint CSharp_AkMusicSyncCallbackInfo_playingID_get(IntPtr jarg1); // 0x00000001853B559C-0x00000001853B55D0
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(IntPtr jarg1); // 0x00000001853B56D4-0x00000001853B5708
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(IntPtr jarg1); // 0x00000001853B573C-0x00000001853B5770
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(IntPtr jarg1); // 0x00000001853B56A0-0x00000001853B56D4
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(IntPtr jarg1); // 0x00000001853B5708-0x00000001853B573C
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1); // 0x00000001853B5770-0x00000001853B57A4
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(IntPtr jarg1); // 0x00000001853B5604-0x00000001853B5638
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(IntPtr jarg1); // 0x00000001853B55D0-0x00000001853B5604
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(IntPtr jarg1); // 0x00000001853B5638-0x00000001853B566C
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(IntPtr jarg1); // 0x00000001853B566C-0x00000001853B56A0
	public static extern int CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(IntPtr jarg1); // 0x00000001853B5568-0x00000001853B559C
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(IntPtr jarg1); // 0x00000001853B57A4-0x00000001853B57D8
	public static extern IntPtr CSharp_new_AkMusicSyncCallbackInfo(); // 0x00000001853C5E98-0x00000001853C5EC4
	public static extern void CSharp_delete_AkMusicSyncCallbackInfo(IntPtr jarg1); // 0x00000001853C4DEC-0x00000001853C4E20
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(IntPtr jarg1); // 0x00000001853B5464-0x00000001853B5498
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(IntPtr jarg1); // 0x00000001853B5498-0x00000001853B54CC
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(IntPtr jarg1); // 0x00000001853B5500-0x00000001853B5534
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(IntPtr jarg1); // 0x00000001853B54CC-0x00000001853B5500
	public static extern IntPtr CSharp_new_AkMusicPlaylistCallbackInfo(); // 0x00000001853C5E6C-0x00000001853C5E98
	public static extern void CSharp_delete_AkMusicPlaylistCallbackInfo(IntPtr jarg1); // 0x00000001853C4D84-0x00000001853C4DB8
	public static extern uint CSharp_AkBankCallbackInfo_bankID_get(IntPtr jarg1); // 0x0000000183289F40-0x0000000183289F80
	public static extern IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(IntPtr jarg1); // 0x0000000183289E60-0x0000000183289EA0
	public static extern int CSharp_AkBankCallbackInfo_loadResult_get(IntPtr jarg1); // 0x0000000183289F00-0x0000000183289F40
	public static extern IntPtr CSharp_new_AkBankCallbackInfo(); // 0x00000001853C5604-0x00000001853C5630
	public static extern void CSharp_delete_AkBankCallbackInfo(IntPtr jarg1); // 0x00000001853C46D0-0x00000001853C4704
	public static extern int CSharp_AkMonitoringCallbackInfo_errorCode_get(IntPtr jarg1); // 0x00000001853B5314-0x00000001853B5348
	public static extern int CSharp_AkMonitoringCallbackInfo_errorLevel_get(IntPtr jarg1); // 0x00000001853B5348-0x00000001853B537C
	public static extern uint CSharp_AkMonitoringCallbackInfo_playingID_get(IntPtr jarg1); // 0x00000001853B5430-0x00000001853B5464
	public static extern ulong CSharp_AkMonitoringCallbackInfo_gameObjID_get(IntPtr jarg1); // 0x00000001853B537C-0x00000001853B53F4
	public static extern IntPtr CSharp_AkMonitoringCallbackInfo_message_get(IntPtr jarg1); // 0x00000001853B53F4-0x00000001853B5430
	public static extern IntPtr CSharp_new_AkMonitoringCallbackInfo(); // 0x00000001853C5E40-0x00000001853C5E6C
	public static extern void CSharp_delete_AkMonitoringCallbackInfo(IntPtr jarg1); // 0x00000001853C4D50-0x00000001853C4D84
	public static extern bool CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(IntPtr jarg1); // 0x00000001853AF53C-0x00000001853AF574
	public static extern IntPtr CSharp_new_AkAudioInterruptionCallbackInfo(); // 0x00000001853C5580-0x00000001853C55AC
	public static extern void CSharp_delete_AkAudioInterruptionCallbackInfo(IntPtr jarg1); // 0x00000001853C4600-0x00000001853C4634
	public static extern bool CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(IntPtr jarg1); // 0x00000001853AF65C-0x00000001853AF694
	public static extern IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo(); // 0x00000001853C55D8-0x00000001853C5604
	public static extern void CSharp_delete_AkAudioSourceChangeCallbackInfo(IntPtr jarg1); // 0x00000001853C4668-0x00000001853C469C
	public static extern int CSharp_AkCallbackSerializer_Init(); // 0x000000018400ABC0-0x000000018400ABF0
	public static extern void CSharp_AkCallbackSerializer_Term(); // 0x00000001853AFEDC-0x00000001853AFF44
	public static extern IntPtr CSharp_AkCallbackSerializer_Lock(); // 0x000000018328BF10-0x000000018328BF40
	public static extern void CSharp_AkCallbackSerializer_Unlock(); // 0x0000000183EB8EF0-0x0000000183EB8F60
	public static extern void CSharp_AkCallbackSerializer_SetLocalOutput(uint jarg1, string jarg2, uint jarg3, string jarg4, uint jarg5, uint jarg6); // 0x00000001853AFE00-0x00000001853AFEDC
	public static extern int CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(bool jarg1, IntPtr jarg2); // 0x00000001853AFD80-0x00000001853AFE00
	public static extern IntPtr CSharp_new_AkCallbackSerializer(); // 0x00000001853C5688-0x00000001853C56B4
	public static extern void CSharp_delete_AkCallbackSerializer(IntPtr jarg1); // 0x00000001853C476C-0x00000001853C47A0
	public static extern IntPtr CSharp_new_MsgContext__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, bool jarg4); // 0x00000001853C6748-0x00000001853C67E8
	public static extern IntPtr CSharp_new_MsgContext__SWIG_1(uint jarg1, ulong jarg2, uint jarg3); // 0x00000001853C67E8-0x00000001853C6878
	public static extern IntPtr CSharp_new_MsgContext__SWIG_2(uint jarg1, ulong jarg2); // 0x00000001853C6878-0x00000001853C68F8
	public static extern IntPtr CSharp_new_MsgContext__SWIG_3(uint jarg1); // 0x00000001853C68F8-0x00000001853C6970
	public static extern IntPtr CSharp_new_MsgContext__SWIG_4(); // 0x00000001853C6970-0x00000001853C699C
	public static extern void CSharp_MsgContext_in_playingID_set(IntPtr jarg1, uint jarg2); // 0x00000001853BDE60-0x00000001853BDEA0
	public static extern uint CSharp_MsgContext_in_playingID_get(IntPtr jarg1); // 0x00000001853BDE2C-0x00000001853BDE60
	public static extern void CSharp_MsgContext_in_gameObjID_set(IntPtr jarg1, ulong jarg2); // 0x00000001853BDDA8-0x00000001853BDE2C
	public static extern ulong CSharp_MsgContext_in_gameObjID_get(IntPtr jarg1); // 0x00000001853BDD30-0x00000001853BDDA8
	public static extern void CSharp_MsgContext_in_soundID_set(IntPtr jarg1, uint jarg2); // 0x00000001853BDED4-0x00000001853BDF14
	public static extern uint CSharp_MsgContext_in_soundID_get(IntPtr jarg1); // 0x00000001853BDEA0-0x00000001853BDED4
	public static extern void CSharp_MsgContext_in_bIsBus_set(IntPtr jarg1, bool jarg2); // 0x00000001853BDCEC-0x00000001853BDD30
	public static extern bool CSharp_MsgContext_in_bIsBus_get(IntPtr jarg1); // 0x00000001853BDCB4-0x00000001853BDCEC
	public static extern void CSharp_delete_MsgContext(IntPtr jarg1); // 0x00000001853C5334-0x00000001853C5368
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_0(string jarg1, string jarg2); // 0x00000001853C6608-0x00000001853C66A0
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_1(string jarg1); // 0x00000001853C66A0-0x00000001853C671C
	public static extern IntPtr CSharp_new_MonitorErrorInfo__SWIG_2(); // 0x00000001853C671C-0x00000001853C6748
	public static extern void CSharp_MonitorErrorInfo_m_name_set(IntPtr jarg1, string jarg2); // 0x00000001853BDAD8-0x00000001853BDB64
	public static extern IntPtr CSharp_MonitorErrorInfo_m_name_get(IntPtr jarg1); // 0x00000001853BDA9C-0x00000001853BDAD8
	public static extern void CSharp_MonitorErrorInfo_m_message_set(IntPtr jarg1, string jarg2); // 0x00000001853BDA10-0x00000001853BDA9C
	public static extern IntPtr CSharp_MonitorErrorInfo_m_message_get(IntPtr jarg1); // 0x00000001853BD9D4-0x00000001853BDA10
	public static extern void CSharp_delete_MonitorErrorInfo(IntPtr jarg1); // 0x00000001853C5300-0x00000001853C5334
	public static extern int CSharp_PostCode__SWIG_0(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6); // 0x00000001853BE170-0x00000001853BE21C
	public static extern int CSharp_PostCode__SWIG_1(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5); // 0x00000001853BE21C-0x00000001853BE2B8
	public static extern int CSharp_PostCode__SWIG_2(int jarg1, int jarg2, uint jarg3, ulong jarg4); // 0x00000001853BE2B8-0x00000001853BE354
	public static extern int CSharp_PostCode__SWIG_3(int jarg1, int jarg2, uint jarg3); // 0x00000001853BE354-0x00000001853BE3E0
	public static extern int CSharp_PostCode__SWIG_4(int jarg1, int jarg2); // 0x00000001853BE3E0-0x00000001853BE460
	public static extern int CSharp_PostCodeVarArg(int jarg1, int jarg2, IntPtr jarg3); // 0x00000001853BE0E4-0x00000001853BE170
	public static extern int CSharp_PostString__SWIG_0(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6); // 0x00000001853BEACC-0x00000001853BEB88
	public static extern int CSharp_PostString__SWIG_1(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5); // 0x00000001853BEB88-0x00000001853BEC30
	public static extern int CSharp_PostString__SWIG_2(string jarg1, int jarg2, uint jarg3, ulong jarg4); // 0x00000001853BEC30-0x00000001853BECD8
	public static extern int CSharp_PostString__SWIG_3(string jarg1, int jarg2, uint jarg3); // 0x00000001853BECD8-0x00000001853BED70
	public static extern int CSharp_PostString__SWIG_4(string jarg1, int jarg2); // 0x00000001853BED70-0x00000001853BEDFC
	public static extern int CSharp_ResetTranslator(); // 0x00000001853C0D80-0x00000001853C0DAC
	public static extern int CSharp_GetTimeStamp(); // 0x00000001853BCD50-0x00000001853BCD7C
	public static extern void CSharp_MonitorStreamMgrInit(IntPtr jarg1); // 0x00000001853BDB64-0x00000001853BDB98
	public static extern void CSharp_MonitorStreamingDeviceInit(uint jarg1, IntPtr jarg2); // 0x00000001853BDC34-0x00000001853BDCB4
	public static extern void CSharp_MonitorStreamingDeviceDestroyed(uint jarg1); // 0x00000001853BDC00-0x00000001853BDC34
	public static extern void CSharp_MonitorStreamMgrTerm(); // 0x00000001853BDB98-0x00000001853BDC00
	public static extern void CSharp_AkGetDefaultHighPriorityThreadProperties(IntPtr jarg1); // 0x00000001853B1F24-0x00000001853B1F58
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_0(uint jarg1, in uint[] jarg2, uint jarg3, uint jarg4); // 0x00000001853C0DAC-0x00000001853C0E54
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_1(uint jarg1, in uint[] jarg2, uint jarg3); // 0x00000001853C0E54-0x00000001853C0EEC
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3); // 0x00000001853BB688-0x00000001853BB714
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3); // 0x00000001853BB714-0x00000001853BB7A0
	public static extern void CSharp_AkPositioningInfo_fCenterPct_set(IntPtr jarg1, float jarg2); // 0x00000001853B76A8-0x00000001853B76EC
	public static extern float CSharp_AkPositioningInfo_fCenterPct_get(IntPtr jarg1); // 0x00000001853B7674-0x00000001853B76A8
	public static extern void CSharp_AkPositioningInfo_pannerType_set(IntPtr jarg1, int jarg2); // 0x00000001853B7A58-0x00000001853B7A98
	public static extern int CSharp_AkPositioningInfo_pannerType_get(IntPtr jarg1); // 0x00000001853B7A24-0x00000001853B7A58
	public static extern void CSharp_AkPositioningInfo_e3dPositioningType_set(IntPtr jarg1, int jarg2); // 0x00000001853B7634-0x00000001853B7674
	public static extern int CSharp_AkPositioningInfo_e3dPositioningType_get(IntPtr jarg1); // 0x00000001853B7600-0x00000001853B7634
	public static extern void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(IntPtr jarg1, bool jarg2); // 0x00000001853B7490-0x00000001853B7510
	public static extern bool CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(IntPtr jarg1); // 0x00000001853B7458-0x00000001853B7490
	public static extern void CSharp_AkPositioningInfo_e3DSpatializationMode_set(IntPtr jarg1, int jarg2); // 0x00000001853B75C0-0x00000001853B7600
	public static extern int CSharp_AkPositioningInfo_e3DSpatializationMode_get(IntPtr jarg1); // 0x00000001853B758C-0x00000001853B75C0
	public static extern void CSharp_AkPositioningInfo_bEnableAttenuation_set(IntPtr jarg1, bool jarg2); // 0x00000001853B7414-0x00000001853B7458
	public static extern bool CSharp_AkPositioningInfo_bEnableAttenuation_get(IntPtr jarg1); // 0x00000001853B73DC-0x00000001853B7414
	public static extern void CSharp_AkPositioningInfo_bUseConeAttenuation_set(IntPtr jarg1, bool jarg2); // 0x00000001853B7548-0x00000001853B758C
	public static extern bool CSharp_AkPositioningInfo_bUseConeAttenuation_get(IntPtr jarg1); // 0x00000001853B7510-0x00000001853B7548
	public static extern void CSharp_AkPositioningInfo_fInnerAngle_set(IntPtr jarg1, float jarg2); // 0x00000001853B7798-0x00000001853B77DC
	public static extern float CSharp_AkPositioningInfo_fInnerAngle_get(IntPtr jarg1); // 0x00000001853B7764-0x00000001853B7798
	public static extern void CSharp_AkPositioningInfo_fOuterAngle_set(IntPtr jarg1, float jarg2); // 0x00000001853B7880-0x00000001853B78C4
	public static extern float CSharp_AkPositioningInfo_fOuterAngle_get(IntPtr jarg1); // 0x00000001853B784C-0x00000001853B7880
	public static extern void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(IntPtr jarg1, float jarg2); // 0x00000001853B7720-0x00000001853B7764
	public static extern float CSharp_AkPositioningInfo_fConeMaxAttenuation_get(IntPtr jarg1); // 0x00000001853B76EC-0x00000001853B7720
	public static extern void CSharp_AkPositioningInfo_LPFCone_set(IntPtr jarg1, float jarg2); // 0x00000001853B7320-0x00000001853B7364
	public static extern float CSharp_AkPositioningInfo_LPFCone_get(IntPtr jarg1); // 0x00000001853B72EC-0x00000001853B7320
	public static extern void CSharp_AkPositioningInfo_HPFCone_set(IntPtr jarg1, float jarg2); // 0x00000001853B7230-0x00000001853B7274
	public static extern float CSharp_AkPositioningInfo_HPFCone_get(IntPtr jarg1); // 0x00000001853B7204-0x00000001853B7230
	public static extern void CSharp_AkPositioningInfo_fMaxDistance_set(IntPtr jarg1, float jarg2); // 0x00000001853B7810-0x00000001853B784C
	public static extern float CSharp_AkPositioningInfo_fMaxDistance_get(IntPtr jarg1); // 0x00000001853B77DC-0x00000001853B7810
	public static extern void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x00000001853B79E8-0x00000001853B7A24
	public static extern float CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(IntPtr jarg1); // 0x00000001853B79B4-0x00000001853B79E8
	public static extern void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x00000001853B78F8-0x00000001853B793C
	public static extern float CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(IntPtr jarg1); // 0x00000001853B78C4-0x00000001853B78F8
	public static extern void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x00000001853B7970-0x00000001853B79B4
	public static extern float CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(IntPtr jarg1); // 0x00000001853B793C-0x00000001853B7970
	public static extern void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x00000001853B7398-0x00000001853B73DC
	public static extern float CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(IntPtr jarg1); // 0x00000001853B7364-0x00000001853B7398
	public static extern void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(IntPtr jarg1, float jarg2); // 0x00000001853B72A8-0x00000001853B72EC
	public static extern float CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(IntPtr jarg1); // 0x00000001853B7274-0x00000001853B72A8
	public static extern IntPtr CSharp_new_AkPositioningInfo(); // 0x00000001853C62CC-0x00000001853C6334
	public static extern void CSharp_delete_AkPositioningInfo(IntPtr jarg1); // 0x00000001853C4FC0-0x00000001853C4FF4
	public static extern void CSharp_AkObjectInfo_objID_set(IntPtr jarg1, uint jarg2); // 0x00000001853B5924-0x00000001853B5964
	public static extern uint CSharp_AkObjectInfo_objID_get(IntPtr jarg1); // 0x00000001853B58F0-0x00000001853B5924
	public static extern void CSharp_AkObjectInfo_parentID_set(IntPtr jarg1, uint jarg2); // 0x00000001853B5998-0x00000001853B59D8
	public static extern uint CSharp_AkObjectInfo_parentID_get(IntPtr jarg1); // 0x00000001853B5964-0x00000001853B5998
	public static extern void CSharp_AkObjectInfo_iDepth_set(IntPtr jarg1, int jarg2); // 0x00000001853B58B0-0x00000001853B58F0
	public static extern int CSharp_AkObjectInfo_iDepth_get(IntPtr jarg1); // 0x00000001853B587C-0x00000001853B58B0
	public static extern void CSharp_AkObjectInfo_Clear(IntPtr jarg1); // 0x00000001853B57D8-0x00000001853B580C
	public static extern int CSharp_AkObjectInfo_GetSizeOf(); // 0x00000001853B5850-0x00000001853B587C
	public static extern void CSharp_AkObjectInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B580C-0x00000001853B5850
	public static extern IntPtr CSharp_new_AkObjectInfo(); // 0x00000001853C5EC4-0x00000001853C5EF0
	public static extern void CSharp_delete_AkObjectInfo(IntPtr jarg1); // 0x00000001853C4E20-0x00000001853C4E54
	public static extern int CSharp_GetPosition(ulong jarg1, IntPtr jarg2); // 0x00000001853BC0C0-0x00000001853BC144
	public static extern int CSharp_GetListenerPosition(ulong jarg1, IntPtr jarg2); // 0x00000001853BBA04-0x00000001853BBA88
	public static extern int CSharp_GetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5); // 0x00000001853BC1C4-0x00000001853BC264
	public static extern int CSharp_GetRTPCValue__SWIG_1(string jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5); // 0x00000001853BC264-0x00000001853BC310
	public static extern int CSharp_GetSwitch__SWIG_0(uint jarg1, ulong jarg2, out uint jarg3); // 0x00000001853BCC24-0x00000001853BCCB4
	public static extern int CSharp_GetSwitch__SWIG_1(string jarg1, ulong jarg2, out uint jarg3); // 0x00000001853BCCB4-0x00000001853BCD50
	public static extern int CSharp_GetState__SWIG_0(uint jarg1, out uint jarg2); // 0x00000001853BCAB0-0x00000001853BCB30
	public static extern int CSharp_GetState__SWIG_1(string jarg1, out uint jarg2); // 0x00000001853BCB30-0x00000001853BCBBC
	public static extern int CSharp_GetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, ref uint jarg3); // 0x00000001853BB7A0-0x00000001853BB830
	public static extern int CSharp_GetGameObjectDryLevelValue(ulong jarg1, ulong jarg2, out float jarg3); // 0x00000001853BB830-0x00000001853BB8C0
	public static extern int CSharp_GetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, out float jarg3, out float jarg4); // 0x00000001853BBB58-0x00000001853BBBF8
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_0(uint jarg1, ref uint jarg2, IntPtr jarg3); // 0x00000001853BFA70-0x00000001853BFB00
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_1(string jarg1, ref uint jarg2, IntPtr jarg3); // 0x00000001853BFB00-0x00000001853BFB9C
	public static extern int CSharp_GetPositioningInfo(uint jarg1, IntPtr jarg2); // 0x00000001853BC144-0x00000001853BC1C4
	public static extern bool CSharp_GetIsGameObjectActive(ulong jarg1); // 0x00000001853BB9CC-0x00000001853BBA04
	public static extern float CSharp_GetMaxRadius(ulong jarg1); // 0x00000001853BBB2C-0x00000001853BBB58
	public static extern uint CSharp_GetEventIDFromPlayingID(uint jarg1); // 0x00000001844B0430-0x00000001844B04E0
	public static extern ulong CSharp_GetGameObjectFromPlayingID(uint jarg1); // 0x00000001853BB8C0-0x00000001853BB938
	public static extern int CSharp_GetPlayingIDsFromGameObject(ulong jarg1, ref uint jarg2, out uint[] jarg3); // 0x00000001853BBEA4-0x00000001853BBFB0
	public static extern int CSharp_GetCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3); // 0x00000001853BB354-0x00000001853BB3E0
	public static extern int CSharp_GetCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3); // 0x00000001853BB3E0-0x00000001853BB46C
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint jarg1); // 0x00000001853AE5A4-0x00000001853AE61C
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint jarg1); // 0x00000001853AE61C-0x00000001853AE694
	public static extern void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint jarg1); // 0x00000001853AE52C-0x00000001853AE5A4
	public static extern byte CSharp_ChannelMaskToNumChannels(uint jarg1); // 0x00000001853B9CB0-0x00000001853B9D28
	public static extern uint CSharp_ChannelMaskFromNumChannels(uint jarg1); // 0x00000001853B9C7C-0x00000001853B9CB0
	public static extern byte CSharp_ChannelBitToIndex(uint jarg1, uint jarg2); // 0x00000001853B9BFC-0x00000001853B9C7C
	public static extern bool CSharp_HasSurroundChannels(uint jarg1); // 0x00000001853BD018-0x00000001853BD050
	public static extern bool CSharp_HasStrictlyOnePairOfSurroundChannels(uint jarg1); // 0x00000001853BCFA0-0x00000001853BD018
	public static extern bool CSharp_HasSideAndRearChannels(uint jarg1); // 0x00000001853BCF68-0x00000001853BCFA0
	public static extern bool CSharp_HasHeightChannels(uint jarg1); // 0x00000001853BCF30-0x00000001853BCF68
	public static extern uint CSharp_BackToSideChannels(uint jarg1); // 0x00000001853B9AB4-0x00000001853B9B2C
	public static extern uint CSharp_StdChannelIndexToDisplayIndex(int jarg1, uint jarg2, uint jarg3); // 0x00000001853C3718-0x00000001853C37A4
	public static extern void CSharp_AkChannelConfig_uNumChannels_set(IntPtr jarg1, uint jarg2); // 0x00000001853B0404-0x00000001853B0444
	public static extern uint CSharp_AkChannelConfig_uNumChannels_get(IntPtr jarg1); // 0x0000000183AC7780-0x0000000183AC77C0
	public static extern void CSharp_AkChannelConfig_eConfigType_set(IntPtr jarg1, uint jarg2); // 0x00000001853B0344-0x00000001853B03C4
	public static extern uint CSharp_AkChannelConfig_eConfigType_get(IntPtr jarg1); // 0x0000000183AC76E0-0x0000000183AC7720
	public static extern void CSharp_AkChannelConfig_uChannelMask_set(IntPtr jarg1, uint jarg2); // 0x00000001853B03C4-0x00000001853B0404
	public static extern uint CSharp_AkChannelConfig_uChannelMask_get(IntPtr jarg1); // 0x0000000183AC7640-0x0000000183AC7680
	public static extern IntPtr CSharp_AkChannelConfig_Standard(uint jarg1); // 0x00000001853B0310-0x00000001853B0344
	public static extern IntPtr CSharp_AkChannelConfig_Anonymous(uint jarg1); // 0x00000001853AFF78-0x00000001853AFFF0
	public static extern IntPtr CSharp_AkChannelConfig_Ambisonic(uint jarg1); // 0x00000001853AFF44-0x00000001853AFF78
	public static extern IntPtr CSharp_AkChannelConfig_Object(); // 0x00000001853B009C-0x00000001853B00C8
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_0(); // 0x00000001853C56B4-0x00000001853C56E0
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_1(uint jarg1, uint jarg2); // 0x00000001853C56E0-0x00000001853C5760
	public static extern void CSharp_AkChannelConfig_Clear(IntPtr jarg1); // 0x00000001853AFFF0-0x00000001853B0024
	public static extern void CSharp_AkChannelConfig_SetStandard(IntPtr jarg1, uint jarg2); // 0x00000001853B02D0-0x00000001853B0310
	public static extern void CSharp_AkChannelConfig_SetStandardOrAnonymous(IntPtr jarg1, uint jarg2, uint jarg3); // 0x00000001853B0240-0x00000001853B02D0
	public static extern void CSharp_AkChannelConfig_SetAnonymous(IntPtr jarg1, uint jarg2); // 0x00000001845E2250-0x00000001845E2290
	public static extern void CSharp_AkChannelConfig_SetAmbisonic(IntPtr jarg1, uint jarg2); // 0x00000001853B0164-0x00000001853B01A4
	public static extern void CSharp_AkChannelConfig_SetObject(IntPtr jarg1); // 0x00000001853B01A4-0x00000001853B01D8
	public static extern void CSharp_AkChannelConfig_SetSameAsMainMix(IntPtr jarg1); // 0x00000001853B01D8-0x00000001853B020C
	public static extern void CSharp_AkChannelConfig_SetSameAsPassthrough(IntPtr jarg1); // 0x00000001853B020C-0x00000001853B0240
	public static extern bool CSharp_AkChannelConfig_IsValid(IntPtr jarg1); // 0x00000001853B0064-0x00000001853B009C
	public static extern uint CSharp_AkChannelConfig_Serialize(IntPtr jarg1); // 0x00000001853B0130-0x00000001853B0164
	public static extern void CSharp_AkChannelConfig_Deserialize(IntPtr jarg1, uint jarg2); // 0x00000001853B0024-0x00000001853B0064
	public static extern IntPtr CSharp_AkChannelConfig_RemoveLFE(IntPtr jarg1); // 0x00000001853B00FC-0x00000001853B0130
	public static extern IntPtr CSharp_AkChannelConfig_RemoveCenter(IntPtr jarg1); // 0x00000001853B00C8-0x00000001853B00FC
	public static extern void CSharp_delete_AkChannelConfig(IntPtr jarg1); // 0x000000018468FB10-0x000000018468FB50
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_0(); // 0x00000001853C5AB0-0x00000001853C5ADC
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3); // 0x00000001853C5ADC-0x00000001853C5B40
	public static extern void CSharp_AkImageSourceParams_sourcePosition_set(IntPtr jarg1, AkVector64 jarg2); // 0x00000001853B21D0-0x00000001853B226C
	public static extern AkVector64 CSharp_AkImageSourceParams_sourcePosition_get(IntPtr jarg1); // 0x00000001853B2138-0x00000001853B21D0
	public static extern void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(IntPtr jarg1, float jarg2); // 0x00000001853B2004-0x00000001853B2048
	public static extern float CSharp_AkImageSourceParams_fDistanceScalingFactor_get(IntPtr jarg1); // 0x00000001853B1FD0-0x00000001853B2004
	public static extern void CSharp_AkImageSourceParams_fLevel_set(IntPtr jarg1, float jarg2); // 0x00000001853B207C-0x00000001853B20C0
	public static extern float CSharp_AkImageSourceParams_fLevel_get(IntPtr jarg1); // 0x00000001853B2048-0x00000001853B207C
	public static extern void CSharp_AkImageSourceParams_fDiffraction_set(IntPtr jarg1, float jarg2); // 0x00000001853B1F8C-0x00000001853B1FD0
	public static extern float CSharp_AkImageSourceParams_fDiffraction_get(IntPtr jarg1); // 0x00000001853B1F58-0x00000001853B1F8C
	public static extern void CSharp_AkImageSourceParams_fOcclusion_set(IntPtr jarg1, float jarg2); // 0x00000001853B20F4-0x00000001853B2138
	public static extern float CSharp_AkImageSourceParams_fOcclusion_get(IntPtr jarg1); // 0x00000001853B20C0-0x00000001853B20F4
	public static extern void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(IntPtr jarg1, byte jarg2); // 0x00000001853B22E4-0x00000001853B2324
	public static extern byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(IntPtr jarg1); // 0x00000001853B226C-0x00000001853B22E4
	public static extern void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(IntPtr jarg1, byte jarg2); // 0x00000001853B2358-0x00000001853B2398
	public static extern byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(IntPtr jarg1); // 0x00000001853B2324-0x00000001853B2358
	public static extern void CSharp_delete_AkImageSourceParams(IntPtr jarg1); // 0x00000001853C49A8-0x00000001853C49DC
	public static extern uint CSharp_kDefaultDiffractionMaxEdges_get(); // 0x00000001853C5368-0x00000001853C5394
	public static extern uint CSharp_kDefaultDiffractionMaxPaths_get(); // 0x00000001853C5394-0x00000001853C53C0
	public static extern float CSharp_kMaxDiffraction_get(); // 0x00000001853C5480-0x00000001853C54A4
	public static extern uint CSharp_kHashListBlockAllocItemCount_get(); // 0x00000001853C5418-0x00000001853C5480
	public static extern uint CSharp_kDiffractionMaxEdges_get(); // 0x00000001853C53C0-0x00000001853C53EC
	public static extern uint CSharp_kDiffractionMaxPaths_get(); // 0x00000001853C53EC-0x00000001853C5418
	public static extern uint CSharp_kPortalToPortalDiffractionMaxPaths_get(); // 0x00000001853C54A4-0x00000001853C54D0
	public static extern IntPtr CSharp_new_AkSpatialAudioInitSettings(); // 0x0000000184009DD0-0x0000000184009E00
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(IntPtr jarg1, uint jarg2); // 0x000000018400A3F0-0x000000018400A440
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(IntPtr jarg1); // 0x00000001853B8D90-0x00000001853B8DC4
	public static extern void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(IntPtr jarg1, float jarg2); // 0x000000018400A7B0-0x000000018400A800
	public static extern float CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(IntPtr jarg1); // 0x00000001853B8CF4-0x00000001853B8D28
	public static extern void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(IntPtr jarg1, uint jarg2); // 0x000000018400A340-0x000000018400A390
	public static extern uint CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(IntPtr jarg1); // 0x0000000184008D40-0x0000000184008D80
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(IntPtr jarg1, uint jarg2); // 0x000000018400A290-0x000000018400A2E0
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(IntPtr jarg1); // 0x0000000184008CB0-0x0000000184008CF0
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(IntPtr jarg1, uint jarg2); // 0x000000018400A1E0-0x000000018400A230
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(IntPtr jarg1); // 0x0000000184008C20-0x0000000184008C60
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(IntPtr jarg1, uint jarg2); // 0x000000018400A130-0x000000018400A180
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(IntPtr jarg1); // 0x00000001853B8D5C-0x00000001853B8D90
	public static extern void CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(IntPtr jarg1, uint jarg2); // 0x000000018400A080-0x000000018400A0D0
	public static extern uint CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(IntPtr jarg1); // 0x00000001853B8D28-0x00000001853B8D5C
	public static extern void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(IntPtr jarg1, float jarg2); // 0x000000018400A6F0-0x000000018400A740
	public static extern float CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(IntPtr jarg1); // 0x00000001853B8CC0-0x00000001853B8CF4
	public static extern void CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(IntPtr jarg1, float jarg2); // 0x000000018400A630-0x000000018400A680
	public static extern float CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(IntPtr jarg1); // 0x00000001853B8C8C-0x00000001853B8CC0
	public static extern void CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(IntPtr jarg1, uint jarg2); // 0x0000000184009FD0-0x000000018400A020
	public static extern uint CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(IntPtr jarg1); // 0x0000000184008B90-0x0000000184008BD0
	public static extern void CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(IntPtr jarg1, bool jarg2); // 0x000000018400A570-0x000000018400A5C0
	public static extern bool CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(IntPtr jarg1); // 0x00000001853B8C54-0x00000001853B8C8C
	public static extern void CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(IntPtr jarg1, bool jarg2); // 0x000000018400A4B0-0x000000018400A500
	public static extern bool CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(IntPtr jarg1); // 0x00000001853B8C1C-0x00000001853B8C54
	public static extern void CSharp_delete_AkSpatialAudioInitSettings(IntPtr jarg1); // 0x00000001847907D0-0x0000000184790860
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_0(); // 0x00000001853C5B40-0x00000001853C5B6C
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(AkVector64 jarg1, float jarg2, float jarg3); // 0x00000001853C5B6C-0x00000001853C5BD0
	public static extern void CSharp_AkImageSourceSettings_SetOneTexture(IntPtr jarg1, uint jarg2); // 0x00000001853B2398-0x00000001853B23D8
	public static extern void CSharp_AkImageSourceSettings_params__set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B240C-0x00000001853B2450
	public static extern IntPtr CSharp_AkImageSourceSettings_params__get(IntPtr jarg1); // 0x00000001853B23D8-0x00000001853B240C
	public static extern void CSharp_delete_AkImageSourceSettings(IntPtr jarg1); // 0x00000001853C49DC-0x00000001853C4A10
	public static extern IntPtr CSharp_new_AkExtent__SWIG_0(); // 0x00000001853C5868-0x00000001853C5894
	public static extern IntPtr CSharp_new_AkExtent__SWIG_1(float jarg1, float jarg2, float jarg3); // 0x0000000183CE03E0-0x0000000183CE0440
	public static extern void CSharp_AkExtent_halfWidth_set(IntPtr jarg1, float jarg2); // 0x00000001853B19FC-0x00000001853B1A40
	public static extern float CSharp_AkExtent_halfWidth_get(IntPtr jarg1); // 0x00000001853B19C8-0x00000001853B19FC
	public static extern void CSharp_AkExtent_halfHeight_set(IntPtr jarg1, float jarg2); // 0x00000001853B1984-0x00000001853B19C8
	public static extern float CSharp_AkExtent_halfHeight_get(IntPtr jarg1); // 0x00000001853B1950-0x00000001853B1984
	public static extern void CSharp_AkExtent_halfDepth_set(IntPtr jarg1, float jarg2); // 0x00000001853B190C-0x00000001853B1950
	public static extern float CSharp_AkExtent_halfDepth_get(IntPtr jarg1); // 0x00000001853B18D8-0x00000001853B190C
	public static extern void CSharp_delete_AkExtent(IntPtr jarg1); // 0x0000000183CE04F0-0x0000000183CE0530
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_0(); // 0x00000001853C64E0-0x00000001853C650C
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_1(ushort jarg1, ushort jarg2, ushort jarg3, ushort jarg4); // 0x00000001853C650C-0x00000001853C65B0
	public static extern void CSharp_AkTriangle_point0_set(IntPtr jarg1, ushort jarg2); // 0x000000018352A430-0x000000018352A480
	public static extern ushort CSharp_AkTriangle_point0_get(IntPtr jarg1); // 0x00000001853B93CC-0x00000001853B9444
	public static extern void CSharp_AkTriangle_point1_set(IntPtr jarg1, ushort jarg2); // 0x000000018352A3E0-0x000000018352A430
	public static extern ushort CSharp_AkTriangle_point1_get(IntPtr jarg1); // 0x00000001853B9444-0x00000001853B9478
	public static extern void CSharp_AkTriangle_point2_set(IntPtr jarg1, ushort jarg2); // 0x000000018352A350-0x000000018352A390
	public static extern ushort CSharp_AkTriangle_point2_get(IntPtr jarg1); // 0x00000001853B9478-0x00000001853B94F0
	public static extern void CSharp_AkTriangle_surface_set(IntPtr jarg1, ushort jarg2); // 0x000000018352A390-0x000000018352A3E0
	public static extern ushort CSharp_AkTriangle_surface_get(IntPtr jarg1); // 0x00000001853B94F0-0x00000001853B9568
	public static extern void CSharp_AkTriangle_Clear(IntPtr jarg1); // 0x00000001835ABA10-0x00000001835ABA50
	public static extern int CSharp_AkTriangle_GetSizeOf(); // 0x00000001835AC0F0-0x00000001835AC120
	public static extern void CSharp_AkTriangle_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B9388-0x00000001853B93CC
	public static extern void CSharp_delete_AkTriangle(IntPtr jarg1); // 0x00000001853C5230-0x00000001853C5264
	public static extern IntPtr CSharp_new_AkAcousticSurface(); // 0x00000001853C5528-0x00000001853C5554
	public static extern void CSharp_AkAcousticSurface_textureID_set(IntPtr jarg1, uint jarg2); // 0x00000001843ED810-0x00000001843ED860
	public static extern uint CSharp_AkAcousticSurface_textureID_get(IntPtr jarg1); // 0x00000001853AEFEC-0x00000001853AF020
	public static extern void CSharp_AkAcousticSurface_transmissionLoss_set(IntPtr jarg1, float jarg2); // 0x00000001843ED7C0-0x00000001843ED810
	public static extern float CSharp_AkAcousticSurface_transmissionLoss_get(IntPtr jarg1); // 0x00000001853AF020-0x00000001853AF054
	public static extern void CSharp_AkAcousticSurface_strName_set(IntPtr jarg1, string jarg2); // 0x00000001853AEF58-0x00000001853AEFEC
	public static extern IntPtr CSharp_AkAcousticSurface_strName_get(IntPtr jarg1); // 0x00000001853AEF24-0x00000001853AEF58
	public static extern void CSharp_AkAcousticSurface_Clear(IntPtr jarg1); // 0x00000001835ABB10-0x00000001835ABB50
	public static extern void CSharp_AkAcousticSurface_DeleteName(IntPtr jarg1); // 0x00000001853AEEF0-0x00000001853AEF24
	public static extern int CSharp_AkAcousticSurface_GetSizeOf(); // 0x00000001835AC0C0-0x00000001835AC0F0
	public static extern void CSharp_AkAcousticSurface_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853AEEAC-0x00000001853AEEF0
	public static extern void CSharp_delete_AkAcousticSurface(IntPtr jarg1); // 0x00000001853C4554-0x00000001853C4588
	public static extern void CSharp_AkReflectionPathInfo_imageSource_set(IntPtr jarg1, AkVector64 jarg2); // 0x00000001853B7DE8-0x00000001853B7E84
	public static extern AkVector64 CSharp_AkReflectionPathInfo_imageSource_get(IntPtr jarg1); // 0x00000001853B7D50-0x00000001853B7DE8
	public static extern void CSharp_AkReflectionPathInfo_numPathPoints_set(IntPtr jarg1, uint jarg2); // 0x00000001853B7FEC-0x00000001853B802C
	public static extern uint CSharp_AkReflectionPathInfo_numPathPoints_get(IntPtr jarg1); // 0x00000001853B7FB8-0x00000001853B7FEC
	public static extern void CSharp_AkReflectionPathInfo_numReflections_set(IntPtr jarg1, uint jarg2); // 0x00000001853B8060-0x00000001853B80A0
	public static extern uint CSharp_AkReflectionPathInfo_numReflections_get(IntPtr jarg1); // 0x00000001853B802C-0x00000001853B8060
	public static extern void CSharp_AkReflectionPathInfo_level_set(IntPtr jarg1, float jarg2); // 0x00000001853B7F74-0x00000001853B7FB8
	public static extern float CSharp_AkReflectionPathInfo_level_get(IntPtr jarg1); // 0x00000001853B7F40-0x00000001853B7F74
	public static extern void CSharp_AkReflectionPathInfo_isOccluded_set(IntPtr jarg1, bool jarg2); // 0x00000001853B7EFC-0x00000001853B7F40
	public static extern bool CSharp_AkReflectionPathInfo_isOccluded_get(IntPtr jarg1); // 0x00000001853B7E84-0x00000001853B7EFC
	public static extern int CSharp_AkReflectionPathInfo_GetSizeOf(); // 0x00000001853B7D24-0x00000001853B7D50
	public static extern Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(IntPtr jarg1, uint jarg2); // 0x00000001853B7C80-0x00000001853B7D24
	public static extern IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(IntPtr jarg1, uint jarg2); // 0x00000001853B7BC4-0x00000001853B7C44
	public static extern float CSharp_AkReflectionPathInfo_GetDiffraction(IntPtr jarg1, uint jarg2); // 0x00000001853B7C44-0x00000001853B7C80
	public static extern void CSharp_AkReflectionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B7B80-0x00000001853B7BC4
	public static extern IntPtr CSharp_new_AkReflectionPathInfo(); // 0x00000001853C63AC-0x00000001853C63D8
	public static extern void CSharp_delete_AkReflectionPathInfo(IntPtr jarg1); // 0x00000001853C5028-0x00000001853C505C
	public static extern void CSharp_AkDiffractionPathInfo_emitterPos_set(IntPtr jarg1, AkVector64 jarg2); // 0x00000001853B1390-0x00000001853B142C
	public static extern AkVector64 CSharp_AkDiffractionPathInfo_emitterPos_get(IntPtr jarg1); // 0x00000001853B12F8-0x00000001853B1390
	public static extern void CSharp_AkDiffractionPathInfo_virtualPos_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B16B4-0x00000001853B16F8
	public static extern IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(IntPtr jarg1); // 0x00000001853B1680-0x00000001853B16B4
	public static extern void CSharp_AkDiffractionPathInfo_nodeCount_set(IntPtr jarg1, uint jarg2); // 0x00000001853B1460-0x00000001853B14A0
	public static extern uint CSharp_AkDiffractionPathInfo_nodeCount_get(IntPtr jarg1); // 0x00000001853B142C-0x00000001853B1460
	public static extern void CSharp_AkDiffractionPathInfo_diffraction_set(IntPtr jarg1, float jarg2); // 0x00000001853B12BC-0x00000001853B12F8
	public static extern float CSharp_AkDiffractionPathInfo_diffraction_get(IntPtr jarg1); // 0x00000001853B1288-0x00000001853B12BC
	public static extern void CSharp_AkDiffractionPathInfo_transmissionLoss_set(IntPtr jarg1, float jarg2); // 0x00000001853B163C-0x00000001853B1680
	public static extern float CSharp_AkDiffractionPathInfo_transmissionLoss_get(IntPtr jarg1); // 0x00000001853B1608-0x00000001853B163C
	public static extern void CSharp_AkDiffractionPathInfo_totLength_set(IntPtr jarg1, float jarg2); // 0x00000001853B15C4-0x00000001853B1608
	public static extern float CSharp_AkDiffractionPathInfo_totLength_get(IntPtr jarg1); // 0x00000001853B1590-0x00000001853B15C4
	public static extern void CSharp_AkDiffractionPathInfo_obstructionValue_set(IntPtr jarg1, float jarg2); // 0x00000001853B14D4-0x00000001853B1518
	public static extern float CSharp_AkDiffractionPathInfo_obstructionValue_get(IntPtr jarg1); // 0x00000001853B14A0-0x00000001853B14D4
	public static extern void CSharp_AkDiffractionPathInfo_occlusionValue_set(IntPtr jarg1, float jarg2); // 0x00000001853B154C-0x00000001853B1590
	public static extern float CSharp_AkDiffractionPathInfo_occlusionValue_get(IntPtr jarg1); // 0x00000001853B1518-0x00000001853B154C
	public static extern int CSharp_AkDiffractionPathInfo_GetSizeOf(); // 0x00000001853B125C-0x00000001853B1288
	public static extern Vector3 CSharp_AkDiffractionPathInfo_GetNodes(IntPtr jarg1, uint jarg2); // 0x00000001853B10B8-0x00000001853B115C
	public static extern float CSharp_AkDiffractionPathInfo_GetAngles(IntPtr jarg1, uint jarg2); // 0x00000001853B107C-0x00000001853B10B8
	public static extern ulong CSharp_AkDiffractionPathInfo_GetPortals(IntPtr jarg1, uint jarg2); // 0x00000001853B115C-0x00000001853B11DC
	public static extern ulong CSharp_AkDiffractionPathInfo_GetRooms(IntPtr jarg1, uint jarg2); // 0x00000001853B11DC-0x00000001853B125C
	public static extern void CSharp_AkDiffractionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B1038-0x00000001853B107C
	public static extern IntPtr CSharp_new_AkDiffractionPathInfo(); // 0x00000001853C57B8-0x00000001853C57E4
	public static extern void CSharp_delete_AkDiffractionPathInfo(IntPtr jarg1); // 0x00000001853C4870-0x00000001853C48A4
	public static extern IntPtr CSharp_new_AkRoomParams(); // 0x0000000184B09630-0x0000000184B09660
	public static extern void CSharp_AkRoomParams_Front_set(IntPtr jarg1, Vector3 jarg2); // 0x0000000183CDFAE0-0x0000000183CDFBB0
	public static extern Vector3 CSharp_AkRoomParams_Front_get(IntPtr jarg1); // 0x00000001853B8358-0x00000001853B83EC
	public static extern void CSharp_AkRoomParams_Up_set(IntPtr jarg1, Vector3 jarg2); // 0x0000000183CDFA00-0x0000000183CDFA50
	public static extern Vector3 CSharp_AkRoomParams_Up_get(IntPtr jarg1); // 0x00000001853B8520-0x00000001853B85B4
	public static extern void CSharp_AkRoomParams_ReverbAuxBus_set(IntPtr jarg1, uint jarg2); // 0x0000000183CDF630-0x0000000183CDF680
	public static extern uint CSharp_AkRoomParams_ReverbAuxBus_get(IntPtr jarg1); // 0x00000001853B83EC-0x00000001853B8420
	public static extern void CSharp_AkRoomParams_ReverbLevel_set(IntPtr jarg1, float jarg2); // 0x0000000183CDF920-0x0000000183CDF970
	public static extern float CSharp_AkRoomParams_ReverbLevel_get(IntPtr jarg1); // 0x00000001853B8420-0x00000001853B8454
	public static extern void CSharp_AkRoomParams_TransmissionLoss_set(IntPtr jarg1, float jarg2); // 0x0000000183CDF860-0x0000000183CDF8B0
	public static extern float CSharp_AkRoomParams_TransmissionLoss_get(IntPtr jarg1); // 0x00000001853B84EC-0x00000001853B8520
	public static extern void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(IntPtr jarg1, float jarg2); // 0x0000000183CDF7A0-0x0000000183CDF7F0
	public static extern float CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(IntPtr jarg1); // 0x00000001853B8454-0x00000001853B8480
	public static extern void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(IntPtr jarg1, bool jarg2); // 0x0000000183CDF6F0-0x0000000183CDF730
	public static extern bool CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(IntPtr jarg1); // 0x00000001853B8480-0x00000001853B84B8
	public static extern void CSharp_AkRoomParams_RoomPriority_set(IntPtr jarg1, uint jarg2); // 0x0000000183CDF580-0x0000000183CDF5D0
	public static extern uint CSharp_AkRoomParams_RoomPriority_get(IntPtr jarg1); // 0x00000001853B84B8-0x00000001853B84EC
	public static extern void CSharp_delete_AkRoomParams(IntPtr jarg1); // 0x00000001853C5090-0x00000001853C50C4
	public static extern IntPtr CSharp_new_AkGeometryInstanceParams(); // 0x00000001853C5A84-0x00000001853C5AB0
	public static extern void CSharp_AkGeometryInstanceParams_PositionAndOrientation_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B1CBC-0x00000001853B1D00
	public static extern IntPtr CSharp_AkGeometryInstanceParams_PositionAndOrientation_get(IntPtr jarg1); // 0x00000001853B1C80-0x00000001853B1CBC
	public static extern void CSharp_AkGeometryInstanceParams_Scale_set(IntPtr jarg1, Vector3 jarg2); // 0x00000001853B1D94-0x00000001853B1E2C
	public static extern Vector3 CSharp_AkGeometryInstanceParams_Scale_get(IntPtr jarg1); // 0x00000001853B1D00-0x00000001853B1D94
	public static extern void CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_set(IntPtr jarg1, bool jarg2); // 0x00000001853B1EA4-0x00000001853B1F24
	public static extern bool CSharp_AkGeometryInstanceParams_UseForReflectionAndDiffraction_get(IntPtr jarg1); // 0x00000001853B1E2C-0x00000001853B1EA4
	public static extern void CSharp_delete_AkGeometryInstanceParams(IntPtr jarg1); // 0x00000001853C4974-0x00000001853C49A8
	public static extern int CSharp_SetGameObjectRadius(ulong jarg1, float jarg2, float jarg3); // 0x00000001853C1E6C-0x00000001853C1EB8
	public static extern int CSharp_SetImageSource__SWIG_0(uint jarg1, IntPtr jarg2, string jarg3, uint jarg4, ulong jarg5); // 0x00000001853C1F04-0x00000001853C1FCC
	public static extern int CSharp_SetImageSource__SWIG_1(uint jarg1, IntPtr jarg2, string jarg3, uint jarg4); // 0x00000001853C1FCC-0x00000001853C2088
	public static extern int CSharp_SetImageSource__SWIG_2(uint jarg1, IntPtr jarg2, string jarg3); // 0x00000001853C2088-0x00000001853C213C
	public static extern int CSharp_RemoveImageSource__SWIG_0(uint jarg1, uint jarg2, ulong jarg3); // 0x00000001853BFE6C-0x00000001853BFEF8
	public static extern int CSharp_RemoveImageSource__SWIG_1(uint jarg1, uint jarg2); // 0x00000001853BFEF8-0x00000001853BFF74
	public static extern int CSharp_RemoveImageSource__SWIG_2(uint jarg1); // 0x00000001853BFF74-0x00000001853BFFEC
	public static extern int CSharp_ClearImageSources__SWIG_0(uint jarg1, ulong jarg2); // 0x00000001853B9DBC-0x00000001853B9E3C
	public static extern int CSharp_ClearImageSources__SWIG_1(uint jarg1); // 0x00000001853B9E3C-0x00000001853B9E70
	public static extern int CSharp_ClearImageSources__SWIG_2(); // 0x00000001853B9E70-0x00000001853B9EA4
	public static extern int CSharp_RemoveGeometry(ulong jarg1); // 0x0000000183CE2D80-0x0000000183CE2DB0
	public static extern int CSharp_RemoveGeometryInstance(ulong jarg1); // 0x0000000183CE34E0-0x0000000183CE3580
	public static extern int CSharp_RemoveRoom(ulong jarg1); // 0x0000000183CE35D0-0x0000000183CE3600
	public static extern int CSharp_RemovePortal(ulong jarg1); // 0x0000000183CE3A60-0x0000000183CE3AA0
	public static extern int CSharp_SetReverbZone(ulong jarg1, ulong jarg2, float jarg3); // 0x0000000183CDFC20-0x0000000183CDFC70
	public static extern int CSharp_RemoveReverbZone(ulong jarg1); // 0x00000001853C00E8-0x00000001853C011C
	public static extern int CSharp_SetGameObjectInRoom(ulong jarg1, ulong jarg2); // 0x00000001853C1D9C-0x00000001853C1E20
	public static extern int CSharp_UnsetGameObjectInRoom(ulong jarg1); // 0x00000001853C431C-0x00000001853C4350
	public static extern int CSharp_SetReflectionsOrder(uint jarg1, bool jarg2); // 0x0000000184008E80-0x0000000184008EC0
	public static extern int CSharp_SetDiffractionOrder(uint jarg1, bool jarg2); // 0x0000000184008DE0-0x0000000184008E20
	public static extern int CSharp_SetMaxEmitterRoomAuxSends(uint jarg1); // 0x00000001853C2390-0x00000001853C23C4
	public static extern int CSharp_SetNumberOfPrimaryRays(uint jarg1); // 0x0000000184008B10-0x0000000184008B40
	public static extern int CSharp_SetLoadBalancingSpread(uint jarg1); // 0x0000000184008A80-0x0000000184008AC0
	public static extern int CSharp_SetEarlyReflectionsAuxSend(ulong jarg1, uint jarg2); // 0x00000001853C1BA8-0x00000001853C1C28
	public static extern int CSharp_SetEarlyReflectionsVolume(ulong jarg1, float jarg2); // 0x00000001853C1C28-0x00000001853C1C64
	public static extern int CSharp_SetPortalObstructionAndOcclusion(ulong jarg1, float jarg2, float jarg3); // 0x0000000183CE0DF0-0x0000000183CE0E40
	public static extern int CSharp_SetGameObjectToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001853C1EB8-0x00000001853C1F04
	public static extern int CSharp_SetPortalToPortalObstruction(ulong jarg1, ulong jarg2, float jarg3); // 0x00000001853C2C48-0x00000001853C2C94
	public static extern int CSharp_QueryWetDiffraction(ulong jarg1, out float jarg2); // 0x00000001853BFCDC-0x00000001853BFD60
	public static extern int CSharp_ResetStochasticEngine(); // 0x00000001853C0D54-0x00000001853C0D80
	public static extern void CSharp_AkPlatformInitSettings_threadLEngine_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B5E70-0x00000001853B5EB4
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(IntPtr jarg1); // 0x00000001853B5E3C-0x00000001853B5E70
	public static extern void CSharp_AkPlatformInitSettings_threadOutputMgr_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B5F60-0x00000001853B5FE4
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(IntPtr jarg1); // 0x00000001853B5F2C-0x00000001853B5F60
	public static extern void CSharp_AkPlatformInitSettings_threadBankManager_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B5DF8-0x00000001853B5E3C
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(IntPtr jarg1); // 0x00000001853B5DC4-0x00000001853B5DF8
	public static extern void CSharp_AkPlatformInitSettings_threadMonitor_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B5EE8-0x00000001853B5F2C
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(IntPtr jarg1); // 0x00000001853B5EB4-0x00000001853B5EE8
	public static extern void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(IntPtr jarg1, ushort jarg2); // 0x000000018400B250-0x000000018400B2A0
	public static extern ushort CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(IntPtr jarg1); // 0x00000001853B6018-0x00000001853B6090
	public static extern void CSharp_AkPlatformInitSettings_uSampleRate_set(IntPtr jarg1, uint jarg2); // 0x000000018400B300-0x000000018400B340
	public static extern uint CSharp_AkPlatformInitSettings_uSampleRate_get(IntPtr jarg1); // 0x00000001853B6090-0x00000001853B6108
	public static extern void CSharp_AkPlatformInitSettings_bEnableAvxSupport_set(IntPtr jarg1, bool jarg2); // 0x00000001853B5CC8-0x00000001853B5D0C
	public static extern bool CSharp_AkPlatformInitSettings_bEnableAvxSupport_get(IntPtr jarg1); // 0x00000001853B5C90-0x00000001853B5CC8
	public static extern void CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_set(IntPtr jarg1, uint jarg2); // 0x0000000184CCB1F0-0x0000000184CCB230
	public static extern uint CSharp_AkPlatformInitSettings_uMaxSystemAudioObjects_get(IntPtr jarg1); // 0x00000001853B5FE4-0x00000001853B6018
	public static extern void CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_set(IntPtr jarg1, bool jarg2); // 0x00000001853B5D44-0x00000001853B5DC4
	public static extern bool CSharp_AkPlatformInitSettings_bEnableDirectInputSupport_get(IntPtr jarg1); // 0x00000001853B5D0C-0x00000001853B5D44
	public static extern void CSharp_delete_AkPlatformInitSettings(IntPtr jarg1); // 0x00000001853C4EBC-0x00000001853C4EF0
	public static extern uint CSharp_GetDeviceIDFromName(string jarg1); // 0x00000001853BB570-0x00000001853BB5EC
	public static extern IntPtr CSharp_GetWindowsDeviceName__SWIG_0(int jarg1, out uint jarg2, int jarg3); // 0x00000001853BCE20-0x00000001853BCEB0
	public static extern IntPtr CSharp_GetWindowsDeviceName__SWIG_1(int jarg1, out uint jarg2); // 0x00000001853BCEB0-0x00000001853BCF30
	public static extern uint CSharp_GetWindowsDeviceCount__SWIG_0(int jarg1); // 0x00000001853BCD7C-0x00000001853BCDF4
	public static extern uint CSharp_GetWindowsDeviceCount__SWIG_1(); // 0x00000001853BCDF4-0x00000001853BCE20
	public static extern void CSharp_delete_AkStreamMgrSettings(IntPtr jarg1); // 0x00000001853C5194-0x00000001853C51C8
	public static extern void CSharp_AkDeviceSettings_pIOMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B0DB8-0x00000001853B0DFC
	public static extern IntPtr CSharp_AkDeviceSettings_pIOMemory_get(IntPtr jarg1); // 0x00000001853B0D84-0x00000001853B0DB8
	public static extern void CSharp_AkDeviceSettings_uIOMemorySize_set(IntPtr jarg1, uint jarg2); // 0x000000018400B1B0-0x000000018400B1F0
	public static extern uint CSharp_AkDeviceSettings_uIOMemorySize_get(IntPtr jarg1); // 0x00000001853B0F5C-0x00000001853B0F90
	public static extern void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(IntPtr jarg1, uint jarg2); // 0x00000001853B0F1C-0x00000001853B0F5C
	public static extern uint CSharp_AkDeviceSettings_uIOMemoryAlignment_get(IntPtr jarg1); // 0x00000001853B0EE8-0x00000001853B0F1C
	public static extern void CSharp_AkDeviceSettings_ePoolAttributes_set(IntPtr jarg1, uint jarg2); // 0x00000001853B0D10-0x00000001853B0D50
	public static extern uint CSharp_AkDeviceSettings_ePoolAttributes_get(IntPtr jarg1); // 0x00000001853B0CDC-0x00000001853B0D10
	public static extern void CSharp_AkDeviceSettings_uGranularity_set(IntPtr jarg1, uint jarg2); // 0x00000001853B0EA8-0x00000001853B0EE8
	public static extern uint CSharp_AkDeviceSettings_uGranularity_get(IntPtr jarg1); // 0x00000001853B0E74-0x00000001853B0EA8
	public static extern void CSharp_AkDeviceSettings_threadProperties_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B0E30-0x00000001853B0E74
	public static extern IntPtr CSharp_AkDeviceSettings_threadProperties_get(IntPtr jarg1); // 0x00000001853B0DFC-0x00000001853B0E30
	public static extern void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(IntPtr jarg1, float jarg2); // 0x000000018400B100-0x000000018400B150
	public static extern float CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(IntPtr jarg1); // 0x00000001853B0D50-0x00000001853B0D84
	public static extern void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(IntPtr jarg1, uint jarg2); // 0x00000001853B0FF8-0x00000001853B1038
	public static extern uint CSharp_AkDeviceSettings_uMaxConcurrentIO_get(IntPtr jarg1); // 0x00000001853B0FC4-0x00000001853B0FF8
	public static extern void CSharp_AkDeviceSettings_bUseStreamCache_set(IntPtr jarg1, bool jarg2); // 0x000000018400B050-0x000000018400B0A0
	public static extern bool CSharp_AkDeviceSettings_bUseStreamCache_get(IntPtr jarg1); // 0x00000001853B0CA4-0x00000001853B0CDC
	public static extern void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(IntPtr jarg1, uint jarg2); // 0x000000018400AFB0-0x000000018400AFF0
	public static extern uint CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(IntPtr jarg1); // 0x00000001853B0F90-0x00000001853B0FC4
	public static extern void CSharp_delete_AkDeviceSettings(IntPtr jarg1); // 0x00000001853C483C-0x00000001853C4870
	public static extern void CSharp_AkThreadProperties_nPriority_set(IntPtr jarg1, int jarg2); // 0x00000001853B8E9C-0x00000001853B8EDC
	public static extern int CSharp_AkThreadProperties_nPriority_get(IntPtr jarg1); // 0x00000001853B8E68-0x00000001853B8E9C
	public static extern void CSharp_AkThreadProperties_dwAffinityMask_set(IntPtr jarg1, uint jarg2); // 0x00000001853B8E28-0x00000001853B8E68
	public static extern uint CSharp_AkThreadProperties_dwAffinityMask_get(IntPtr jarg1); // 0x00000001853B8DF4-0x00000001853B8E28
	public static extern void CSharp_AkThreadProperties_uStackSize_set(IntPtr jarg1, uint jarg2); // 0x00000001853B8F10-0x00000001853B8F50
	public static extern uint CSharp_AkThreadProperties_uStackSize_get(IntPtr jarg1); // 0x00000001853B8EDC-0x00000001853B8F10
	public static extern IntPtr CSharp_new_AkThreadProperties(); // 0x00000001853C64B4-0x00000001853C64E0
	public static extern void CSharp_delete_AkThreadProperties(IntPtr jarg1); // 0x00000001853C51C8-0x00000001853C51FC
	public static extern void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1); // 0x0000000183827530-0x00000001838275C0
	public static extern void CSharp_SetErrorLogger__SWIG_1(); // 0x00000001853C1C64-0x00000001853C1CCC
	public static extern void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2); // 0x00000001853C16A4-0x00000001853C173C
	public static extern void CSharp_delete_AkUnityPlatformSpecificSettings(IntPtr jarg1); // 0x00000001853C5298-0x00000001853C52CC
	public static extern IntPtr CSharp_new_AkCommunicationSettings(); // 0x00000001853C5760-0x00000001853C578C
	public static extern void CSharp_AkCommunicationSettings_uPoolSize_set(IntPtr jarg1, uint jarg2); // 0x00000001853B0A68-0x00000001853B0AA8
	public static extern uint CSharp_AkCommunicationSettings_uPoolSize_get(IntPtr jarg1); // 0x00000001853B09F0-0x00000001853B0A68
	public static extern void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(IntPtr jarg1, ushort jarg2); // 0x00000001853B096C-0x00000001853B09F0
	public static extern ushort CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(IntPtr jarg1); // 0x00000001853B08F4-0x00000001853B096C
	public static extern void CSharp_AkCommunicationSettings_uCommandPort_set(IntPtr jarg1, ushort jarg2); // 0x00000001853B0870-0x00000001853B08F4
	public static extern ushort CSharp_AkCommunicationSettings_uCommandPort_get(IntPtr jarg1); // 0x00000001853B07F8-0x00000001853B0870
	public static extern void CSharp_AkCommunicationSettings_commSystem_set(IntPtr jarg1, int jarg2); // 0x00000001853B06B0-0x00000001853B0730
	public static extern int CSharp_AkCommunicationSettings_commSystem_get(IntPtr jarg1); // 0x00000001853B067C-0x00000001853B06B0
	public static extern void CSharp_AkCommunicationSettings_bInitSystemLib_set(IntPtr jarg1, bool jarg2); // 0x00000001853B0638-0x00000001853B067C
	public static extern bool CSharp_AkCommunicationSettings_bInitSystemLib_get(IntPtr jarg1); // 0x00000001853B0600-0x00000001853B0638
	public static extern void CSharp_AkCommunicationSettings_szAppNetworkName_set(IntPtr jarg1, string jarg2); // 0x00000001853B0764-0x00000001853B07F8
	public static extern IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(IntPtr jarg1); // 0x00000001853B0730-0x00000001853B0764
	public static extern void CSharp_delete_AkCommunicationSettings(IntPtr jarg1); // 0x00000001853C47D4-0x00000001853C4808
	public static extern IntPtr CSharp_new_AkInitializationSettings(); // 0x000000018400AC40-0x000000018400ACB0
	public static extern void CSharp_delete_AkInitializationSettings(IntPtr jarg1); // 0x00000001849C7A60-0x00000001849C7AF0
	public static extern void CSharp_AkInitializationSettings_streamMgrSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2ACC-0x00000001853B2B10
	public static extern IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(IntPtr jarg1); // 0x000000018400A9B0-0x000000018400A9F0
	public static extern void CSharp_AkInitializationSettings_deviceSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B297C-0x00000001853B2A00
	public static extern IntPtr CSharp_AkInitializationSettings_deviceSettings_get(IntPtr jarg1); // 0x0000000184009C80-0x0000000184009CC0
	public static extern void CSharp_AkInitializationSettings_initSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2A00-0x00000001853B2A44
	public static extern IntPtr CSharp_AkInitializationSettings_initSettings_get(IntPtr jarg1); // 0x0000000184009BB0-0x0000000184009BF0
	public static extern void CSharp_AkInitializationSettings_platformSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2A88-0x00000001853B2ACC
	public static extern IntPtr CSharp_AkInitializationSettings_platformSettings_get(IntPtr jarg1); // 0x0000000184009AE0-0x0000000184009B20
	public static extern void CSharp_AkInitializationSettings_musicSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2A44-0x00000001853B2A88
	public static extern IntPtr CSharp_AkInitializationSettings_musicSettings_get(IntPtr jarg1); // 0x000000018400A8E0-0x000000018400A920
	public static extern void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B2BAC-0x00000001853B2BF0
	public static extern IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(IntPtr jarg1); // 0x0000000184009A10-0x0000000184009A50
	public static extern void CSharp_AkInitializationSettings_uMemAllocationSizeLimit_set(IntPtr jarg1, uint jarg2); // 0x000000018400AF10-0x000000018400AF50
	public static extern uint CSharp_AkInitializationSettings_uMemAllocationSizeLimit_get(IntPtr jarg1); // 0x00000001853B2B10-0x00000001853B2B44
	public static extern void CSharp_AkInitializationSettings_uMemDebugLevel_set(IntPtr jarg1, uint jarg2); // 0x000000018400AE70-0x000000018400AEB0
	public static extern uint CSharp_AkInitializationSettings_uMemDebugLevel_get(IntPtr jarg1); // 0x00000001853B2B44-0x00000001853B2B78
	public static extern void CSharp_AkInitializationSettings_uMemSpanCount_set(IntPtr jarg1, uint jarg2); // 0x000000018400ADD0-0x000000018400AE10
	public static extern uint CSharp_AkInitializationSettings_uMemSpanCount_get(IntPtr jarg1); // 0x00000001853B2B78-0x00000001853B2BAC
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0(); // 0x00000001853C5894-0x00000001853C58C0
	public static extern void CSharp_delete_AkExternalSourceInfo(IntPtr jarg1); // 0x00000001853C4940-0x00000001853C4974
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4); // 0x00000001853C58C0-0x00000001853C5960
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(string jarg1, uint jarg2, uint jarg3); // 0x00000001853C5960-0x00000001853C59F8
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(uint jarg1, uint jarg2, uint jarg3); // 0x00000001853C59F8-0x00000001853C5A84
	public static extern void CSharp_AkExternalSourceInfo_Clear(IntPtr jarg1); // 0x0000000184CC8A90-0x0000000184CC8AD0
	public static extern void CSharp_AkExternalSourceInfo_Clone(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B1A40-0x00000001853B1A84
	public static extern int CSharp_AkExternalSourceInfo_GetSizeOf(); // 0x000000018463BFA0-0x000000018463C100
	public static extern void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(IntPtr jarg1, uint jarg2); // 0x0000000183ABE970-0x0000000183ABE9C0
	public static extern uint CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(IntPtr jarg1); // 0x00000001853B1A84-0x00000001853B1AB8
	public static extern void CSharp_AkExternalSourceInfo_idCodec_set(IntPtr jarg1, uint jarg2); // 0x0000000183ABEA20-0x0000000183ABEA70
	public static extern uint CSharp_AkExternalSourceInfo_idCodec_get(IntPtr jarg1); // 0x00000001853B1AB8-0x00000001853B1AEC
	public static extern void CSharp_AkExternalSourceInfo_szFile_set(IntPtr jarg1, string jarg2); // 0x0000000183ABE8C0-0x0000000183ABE910
	public static extern IntPtr CSharp_AkExternalSourceInfo_szFile_get(IntPtr jarg1); // 0x00000001853B1BD8-0x00000001853B1C0C
	public static extern void CSharp_AkExternalSourceInfo_pInMemory_set(IntPtr jarg1, IntPtr jarg2); // 0x00000001853B1B94-0x00000001853B1BD8
	public static extern IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(IntPtr jarg1); // 0x00000001853B1B60-0x00000001853B1B94
	public static extern void CSharp_AkExternalSourceInfo_uiMemorySize_set(IntPtr jarg1, uint jarg2); // 0x00000001853B1C40-0x00000001853B1C80
	public static extern uint CSharp_AkExternalSourceInfo_uiMemorySize_get(IntPtr jarg1); // 0x00000001853B1C0C-0x00000001853B1C40
	public static extern void CSharp_AkExternalSourceInfo_idFile_set(IntPtr jarg1, uint jarg2); // 0x00000001853B1B20-0x00000001853B1B60
	public static extern uint CSharp_AkExternalSourceInfo_idFile_get(IntPtr jarg1); // 0x00000001853B1AEC-0x00000001853B1B20
	public static extern int CSharp_Init(IntPtr jarg1); // 0x000000018400AA50-0x000000018400AA90
	public static extern int CSharp_InitSpatialAudio(IntPtr jarg1); // 0x0000000184008200-0x0000000184008240
	public static extern int CSharp_InitCommunication(IntPtr jarg1); // 0x00000001853BD07C-0x00000001853BD0B0
	public static extern void CSharp_Term(); // 0x00000001853C3CD0-0x00000001853C3D38
	public static extern int CSharp_RegisterGameObjInternal(ulong jarg1); // 0x000000018319BD60-0x000000018319BD90
	public static extern int CSharp_UnregisterGameObjInternal(ulong jarg1); // 0x0000000183CE33B0-0x0000000183CE33E0
	public static extern int CSharp_RegisterGameObjInternal_WithName(ulong jarg1, string jarg2); // 0x0000000183CDE980-0x0000000183CDE9D0
	public static extern int CSharp_SetBasePath(string jarg1); // 0x00000001853C1778-0x00000001853C17B8
	public static extern int CSharp_SetCurrentLanguage(string jarg1); // 0x0000000183EB4560-0x0000000183EB45A0
	public static extern int CSharp_LoadFilePackage(string jarg1, out uint jarg2); // 0x0000000183EB5D30-0x0000000183EB5D80
	public static extern int CSharp_AddBasePath(string jarg1); // 0x0000000184653E60-0x0000000184653EA0
	public static extern int CSharp_SetGameName(string jarg1); // 0x00000001853C1CCC-0x00000001853C1D0C
	public static extern IntPtr CSharp_GetCurrentLanguage(); // 0x00000001853BB328-0x00000001853BB354
	public static extern int CSharp_UnloadFilePackage(uint jarg1); // 0x00000001853C4194-0x00000001853C41C8
	public static extern int CSharp_UnloadAllFilePackages(); // 0x00000001853C3D38-0x00000001853C3D64
	public static extern int CSharp_SetObjectPosition(ulong jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4); // 0x000000018319AEE0-0x000000018319AF80
	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_0(uint jarg1, out uint[] jarg2, out uint[] jarg3, out int[] jarg4, ref uint jarg5, bool jarg6); // 0x00000001853BC39C-0x00000001853BC580
	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_1(uint jarg1, out uint[] jarg2, out uint[] jarg3, out int[] jarg4, ref uint jarg5); // 0x00000001853BC580-0x00000001853BC754
	public static extern int CSharp_SetListeners(ulong jarg1, ulong[] jarg2, uint jarg3); // 0x00000001853C22F4-0x00000001853C2390
	public static extern int CSharp_SetDefaultListeners(ulong[] jarg1, uint jarg2); // 0x000000018434CE50-0x000000018434CEF0
	public static extern uint CSharp_GetNumOutputDevices(uint jarg1); // 0x0000000184009150-0x0000000184009190
	public static extern int CSharp_AddOutput__SWIG_0(IntPtr jarg1, out ulong jarg2, ulong[] jarg3, uint jarg4); // 0x00000001853AE868-0x00000001853AE914
	public static extern int CSharp_AddOutput__SWIG_1(IntPtr jarg1, out ulong jarg2, ulong[] jarg3); // 0x00000001853AE914-0x00000001853AE9B0
	public static extern int CSharp_AddOutput__SWIG_2(IntPtr jarg1, out ulong jarg2); // 0x00000001853AE9B0-0x00000001853AEA34
	public static extern int CSharp_AddOutput__SWIG_3(IntPtr jarg1); // 0x00000001853AEA34-0x00000001853AEA68
	public static extern void CSharp_GetDefaultStreamSettings(IntPtr jarg1); // 0x00000001853BB53C-0x00000001853BB570
	public static extern void CSharp_GetDefaultDeviceSettings(IntPtr jarg1); // 0x00000001853BB46C-0x00000001853BB4A0
	public static extern void CSharp_GetDefaultMusicSettings(IntPtr jarg1); // 0x00000001853BB4D4-0x00000001853BB508
	public static extern void CSharp_GetDefaultInitSettings(IntPtr jarg1); // 0x00000001853BB4A0-0x00000001853BB4D4
	public static extern void CSharp_GetDefaultPlatformInitSettings(IntPtr jarg1); // 0x00000001853BB508-0x00000001853BB53C
	public static extern uint CSharp_GetMajorMinorVersion(); // 0x00000001853BBB00-0x00000001853BBB2C
	public static extern uint CSharp_GetSubminorBuildVersion(); // 0x00000001853BCBBC-0x00000001853BCC24
	public static extern void CSharp_StartResourceMonitoring(); // 0x00000001853C36E4-0x00000001853C3718
	public static extern void CSharp_StopResourceMonitoring(); // 0x00000001853C3B78-0x00000001853C3BAC
	public static extern void CSharp_GetResourceMonitorDataSummary(IntPtr jarg1); // 0x00000001853BC310-0x00000001853BC344
	public static extern void CSharp_StartDeviceCapture(ulong jarg1); // 0x00000001853C358C-0x00000001853C35C0
	public static extern void CSharp_StopDeviceCapture(ulong jarg1); // 0x00000001853C37D0-0x00000001853C3804
	public static extern void CSharp_ClearCaptureData(); // 0x00000001853B9D54-0x00000001853B9DBC
	public static extern uint CSharp_UpdateCaptureSampleCount(ulong jarg1); // 0x00000001853C43D0-0x00000001853C4448
	public static extern uint CSharp_GetCaptureSamples(ulong jarg1, [In, Out] float[] jarg2, uint jarg3); // 0x00000001853BB28C-0x00000001853BB328
	public static extern int CSharp_SetRoomPortal(ulong jarg1, ulong jarg2, ulong jarg3, IntPtr jarg4, IntPtr jarg5, bool jarg6, string jarg7); // 0x0000000183CE0440-0x0000000183CE04F0
	public static extern int CSharp_SetRoom(ulong jarg1, IntPtr jarg2, ulong jarg3, string jarg4); // 0x0000000183CDF4A0-0x0000000183CDF520
	public static extern int CSharp_RegisterSpatialAudioListener(ulong jarg1); // 0x000000018434CDD0-0x000000018434CE50
	public static extern int CSharp_UnregisterSpatialAudioListener(ulong jarg1); // 0x00000001853C42E8-0x00000001853C431C
	public static extern int CSharp_SetGeometry(ulong jarg1, IntPtr jarg2, uint jarg3, Vector3[] jarg4, uint jarg5, IntPtr jarg6, uint jarg7, bool jarg8, bool jarg9); // 0x000000018437F4F0-0x000000018437F580
	public static extern int CSharp_SetGeometryInstance(ulong jarg1, IntPtr jarg2, Vector3 jarg3, ulong jarg4, ulong jarg5, bool jarg6); // 0x0000000183CDEEC0-0x0000000183CDEF50
	public static extern int CSharp_QueryReflectionPaths(ulong jarg1, uint jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out uint jarg6); // 0x00000001853BFC3C-0x00000001853BFCDC
	public static extern int CSharp_QueryDiffractionPaths(ulong jarg1, uint jarg2, ref Vector3 jarg3, ref Vector3 jarg4, IntPtr jarg5, out uint jarg6); // 0x00000001853BFB9C-0x00000001853BFC3C
	public static extern void CSharp_PerformStreamMgrIO(); // 0x00000001853BDF8C-0x00000001853BDFB8
	public static extern void CSharp_HgMemShrink(); // 0x00000001853BD050-0x00000001853BD07C
	public static extern ulong CSharp_HgGetGlobalMemoryUsed(); // 0x000000018328AC30-0x000000018328AC60
	public static extern ulong CSharp_HgGetGlobalMemoryReserved(); // 0x00000001848199E0-0x0000000184819A10
	public static extern void CSharp_InitScePad(); // 0x0000000183329FE0-0x000000018332A050
	public static extern uint CSharp_GetMMDeviceIdFromPadContainerInfo(int jarg1); // 0x00000001853BBA88-0x00000001853BBB00
	public static extern IntPtr CSharp_AkPlaylist_SWIGUpcast(IntPtr jarg1); // 0x00000001853B70A0-0x00000001853B70D4
	public static extern IntPtr CSharp_AkMIDIPost_SWIGUpcast(IntPtr jarg1); // 0x00000001853B4ACC-0x00000001853B4B00
	public static extern IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000183F33D30-0x0000000183F33D70
	public static extern IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000183F33AB0-0x0000000183F33B30
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000183F33BB0-0x0000000183F33BF0
	public static extern IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000183F33DF0-0x0000000183F33E30
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000183F338F0-0x0000000183F33930
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000183F33840-0x0000000183F33880
	public static extern IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(IntPtr jarg1); // 0x0000000183F339B0-0x0000000183F33A30
}

public class AkSoundEngine // TypeDefIndex: 56689
{
	// Fields
	public const int _WIN32_WINNT = 1538; // Metadata: 0x02348F3C
	public const int AK_SIMD_ALIGNMENT = 16; // Metadata: 0x02348F3E
	public const int AK_BUFFER_ALIGNMENT = 16; // Metadata: 0x02348F3F
	public const int AK_XAUDIO2_FLAGS = 0; // Metadata: 0x02348F40
	public const int AK_MAX_PATH = 260; // Metadata: 0x02348F41
	public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16; // Metadata: 0x02348F43
	public const string AK_OSCHAR_FMT = "%ls"; // Metadata: 0x02348F44
	public const uint AK_INVALID_PLUGINID = 4294967295; // Metadata: 0x02348F48
	public const ulong AK_INVALID_GAME_OBJECT = 18446744073709551615; // Metadata: 0x02348F49
	public const uint AK_INVALID_UNIQUE_ID = 0; // Metadata: 0x02348F51
	public const uint AK_INVALID_RTPC_ID = 0; // Metadata: 0x02348F52
	public const uint AK_INVALID_LISTENER_INDEX = 4294967295; // Metadata: 0x02348F53
	public const uint AK_INVALID_PLAYING_ID = 0; // Metadata: 0x02348F54
	public const uint AK_DEFAULT_SWITCH_STATE = 0; // Metadata: 0x02348F55
	public const int AK_INVALID_POOL_ID = -1; // Metadata: 0x02348F56
	public const int AK_DEFAULT_POOL_ID = -1; // Metadata: 0x02348F57
	public const uint AK_INVALID_AUX_ID = 0; // Metadata: 0x02348F58
	public const uint AK_INVALID_FILE_ID = 4294967295; // Metadata: 0x02348F59
	public const uint AK_INVALID_DEVICE_ID = 4294967295; // Metadata: 0x02348F5A
	public const uint AK_INVALID_BANK_ID = 0; // Metadata: 0x02348F5B
	public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0; // Metadata: 0x02348F5C
	public const uint AK_INVALID_CHANNELMASK = 0; // Metadata: 0x02348F5D
	public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0; // Metadata: 0x02348F5E
	public const uint AK_MIXER_FX_SLOT = 4294967295; // Metadata: 0x02348F5F
	public const ulong AK_DEFAULT_LISTENER_OBJ = 0; // Metadata: 0x02348F60
	public const uint AK_DEFAULT_PRIORITY = 50; // Metadata: 0x02348F68
	public const uint AK_MIN_PRIORITY = 0; // Metadata: 0x02348F69
	public const uint AK_MAX_PRIORITY = 100; // Metadata: 0x02348F6A
	public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50; // Metadata: 0x02348F6B
	public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576; // Metadata: 0x02348F6C
	public const uint AKCOMPANYID_AUDIOKINETIC = 0; // Metadata: 0x02348F74
	public const uint AK_LISTENERS_MASK_ALL = 4294967295; // Metadata: 0x02348F75
	public const int NULL = 0; // Metadata: 0x02348F76
	public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5; // Metadata: 0x02348F77
	public const int AK_MAX_LANGUAGE_NAME_SIZE = 32; // Metadata: 0x02348F78
	public const int AKCOMPANYID_PLUGINDEV_MIN = 64; // Metadata: 0x02348F79
	public const int AKCOMPANYID_PLUGINDEV_MAX = 255; // Metadata: 0x02348F7B
	public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1; // Metadata: 0x02348F7D
	public const int AKCOMPANYID_MCDSP = 256; // Metadata: 0x02348F7E
	public const int AKCOMPANYID_WAVEARTS = 257; // Metadata: 0x02348F80
	public const int AKCOMPANYID_PHONETICARTS = 258; // Metadata: 0x02348F82
	public const int AKCOMPANYID_IZOTOPE = 259; // Metadata: 0x02348F84
	public const int AKCOMPANYID_CRANKCASEAUDIO = 261; // Metadata: 0x02348F86
	public const int AKCOMPANYID_IOSONO = 262; // Metadata: 0x02348F88
	public const int AKCOMPANYID_AUROTECHNOLOGIES = 263; // Metadata: 0x02348F8A
	public const int AKCOMPANYID_DOLBY = 264; // Metadata: 0x02348F8C
	public const int AKCOMPANYID_TWOBIGEARS = 265; // Metadata: 0x02348F8E
	public const int AKCOMPANYID_OCULUS = 266; // Metadata: 0x02348F90
	public const int AKCOMPANYID_BLUERIPPLESOUND = 267; // Metadata: 0x02348F92
	public const int AKCOMPANYID_ENZIEN = 268; // Metadata: 0x02348F94
	public const int AKCOMPANYID_KROTOS = 269; // Metadata: 0x02348F96
	public const int AKCOMPANYID_NURULIZE = 270; // Metadata: 0x02348F98
	public const int AKCOMPANYID_SUPERPOWERED = 271; // Metadata: 0x02348F9A
	public const int AKCOMPANYID_GOOGLE = 272; // Metadata: 0x02348F9C
	public const int AKCOMPANYID_VISISONICS = 277; // Metadata: 0x02348F9E
	public const int AKCODECID_BANK = 0; // Metadata: 0x02348FA0
	public const int AKCODECID_PCM = 1; // Metadata: 0x02348FA1
	public const int AKCODECID_ADPCM = 2; // Metadata: 0x02348FA2
	public const int AKCODECID_XMA = 3; // Metadata: 0x02348FA3
	public const int AKCODECID_VORBIS = 4; // Metadata: 0x02348FA4
	public const int AKCODECID_WIIADPCM = 5; // Metadata: 0x02348FA5
	public const int AKCODECID_PCMEX = 7; // Metadata: 0x02348FA6
	public const int AKCODECID_EXTERNAL_SOURCE = 8; // Metadata: 0x02348FA7
	public const int AKCODECID_XWMA = 9; // Metadata: 0x02348FA8
	public const int AKCODECID_FILE_PACKAGE = 11; // Metadata: 0x02348FA9
	public const int AKCODECID_ATRAC9 = 12; // Metadata: 0x02348FAA
	public const int AKCODECID_VAG = 13; // Metadata: 0x02348FAB
	public const int AKCODECID_PROFILERCAPTURE = 14; // Metadata: 0x02348FAC
	public const int AKCODECID_ANALYSISFILE = 15; // Metadata: 0x02348FAD
	public const int AKCODECID_MIDI = 16; // Metadata: 0x02348FAE
	public const int AKCODECID_OPUSNX = 17; // Metadata: 0x02348FAF
	public const int AKCODECID_CAF = 18; // Metadata: 0x02348FB0
	public const int AKCODECID_AKOPUS = 19; // Metadata: 0x02348FB1
	public const int AKCODECID_AKOPUS_WEM = 20; // Metadata: 0x02348FB2
	public const int AKCODECID_MEMORYMGR_DUMP = 21; // Metadata: 0x02348FB3
	public const int AKCODECID_SONY360 = 22; // Metadata: 0x02348FB4
	public const int AKCODECID_BANK_EVENT = 30; // Metadata: 0x02348FB5
	public const int AKCODECID_BANK_BUS = 31; // Metadata: 0x02348FB6
	public const int AKPLUGINID_METER = 129; // Metadata: 0x02348FB7
	public const int AKPLUGINID_RECORDER = 132; // Metadata: 0x02348FB9
	public const int AKPLUGINID_IMPACTER = 184; // Metadata: 0x02348FBB
	public const int AKPLUGINID_SYSTEM_OUTPUT_META = 900; // Metadata: 0x02348FBD
	public const int AKPLUGINID_AUDIO_OBJECT_ATTENUATION_META = 901; // Metadata: 0x02348FBF
	public const int AKPLUGINID_AUDIO_OBJECT_PRIORITY_META = 902; // Metadata: 0x02348FC1
	public const int AKEXTENSIONID_SPATIALAUDIO = 800; // Metadata: 0x02348FC3
	public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801; // Metadata: 0x02348FC5
	public const int AKEXTENSIONID_MIDIDEVICEMGR = 802; // Metadata: 0x02348FC7
	public const int AK_WAVE_FORMAT_VAG = 65531; // Metadata: 0x02348FC9
	public const int AK_WAVE_FORMAT_AT9 = 65532; // Metadata: 0x02348FCD
	public const int AK_WAVE_FORMAT_VORBIS = 65535; // Metadata: 0x02348FD1
	public const int AK_WAVE_FORMAT_OPUSNX = 12345; // Metadata: 0x02348FD5
	public const int AK_WAVE_FORMAT_OPUS = 12352; // Metadata: 0x02348FD9
	public const int AK_WAVE_FORMAT_OPUS_WEM = 12353; // Metadata: 0x02348FDD
	public const int WAVE_FORMAT_XMA2 = 358; // Metadata: 0x02348FE1
	public const int AK_PANNER_NUM_STORAGE_BITS = 3; // Metadata: 0x02348FE3
	public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3; // Metadata: 0x02348FE4
	public const int AK_SPAT_NUM_STORAGE_BITS = 3; // Metadata: 0x02348FE5
	public const int AK_MAX_BITS_METERING_FLAGS = 5; // Metadata: 0x02348FE6
	public const bool AK_ASYNC_OPEN_DEFAULT = false; // Metadata: 0x02348FE7
	public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024; // Metadata: 0x02348FE8
	public const double AK_DEFAULT_LISTENER_POSITION_X = 0; // Metadata: 0x02348FEC
	public const double AK_DEFAULT_LISTENER_POSITION_Y = 0; // Metadata: 0x02348FF4
	public const double AK_DEFAULT_LISTENER_POSITION_Z = 0; // Metadata: 0x02348FFC
	public const double AK_DEFAULT_LISTENER_FRONT_X = 0; // Metadata: 0x02349004
	public const double AK_DEFAULT_LISTENER_FRONT_Y = 0; // Metadata: 0x0234900C
	public const double AK_DEFAULT_LISTENER_FRONT_Z = 1; // Metadata: 0x02349014
	public const double AK_DEFAULT_TOP_X = 0; // Metadata: 0x0234901C
	public const double AK_DEFAULT_TOP_Y = 1; // Metadata: 0x02349024
	public const double AK_DEFAULT_TOP_Z = 0; // Metadata: 0x0234902C
	public const double AK_SA_EPSILON = 0.001; // Metadata: 0x02349034
	public const double AK_SA_DIFFRACTION_EPSILON = 0.002; // Metadata: 0x0234903C
	public const double AK_SA_PLANE_THICKNESS = 0.01; // Metadata: 0x02349044
	public const double AK_SA_MIN_ENVIRONMENT_ABSORPTION = 0.01; // Metadata: 0x0234904C
	public const double AK_SA_MIN_ENVIRONMENT_SURFACE_AREA = 1; // Metadata: 0x02349054
	public const int AK_MIDI_EVENT_TYPE_INVALID = 0; // Metadata: 0x0234905C
	public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128; // Metadata: 0x0234905D
	public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144; // Metadata: 0x0234905F
	public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160; // Metadata: 0x02349061
	public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176; // Metadata: 0x02349063
	public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192; // Metadata: 0x02349065
	public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208; // Metadata: 0x02349067
	public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224; // Metadata: 0x02349069
	public const int AK_MIDI_EVENT_TYPE_SYSEX = 240; // Metadata: 0x0234906B
	public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247; // Metadata: 0x0234906D
	public const int AK_MIDI_EVENT_TYPE_WWISE_CMD = 254; // Metadata: 0x0234906F
	public const int AK_MIDI_EVENT_TYPE_META = 255; // Metadata: 0x02349071
	public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0; // Metadata: 0x02349073
	public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1; // Metadata: 0x02349074
	public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2; // Metadata: 0x02349075
	public const int AK_MIDI_CC_CTRL_3_COARSE = 3; // Metadata: 0x02349076
	public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4; // Metadata: 0x02349077
	public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5; // Metadata: 0x02349078
	public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6; // Metadata: 0x02349079
	public const int AK_MIDI_CC_VOLUME_COARSE = 7; // Metadata: 0x0234907A
	public const int AK_MIDI_CC_BALANCE_COARSE = 8; // Metadata: 0x0234907B
	public const int AK_MIDI_CC_CTRL_9_COARSE = 9; // Metadata: 0x0234907C
	public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10; // Metadata: 0x0234907D
	public const int AK_MIDI_CC_EXPRESSION_COARSE = 11; // Metadata: 0x0234907E
	public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12; // Metadata: 0x0234907F
	public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13; // Metadata: 0x02349080
	public const int AK_MIDI_CC_CTRL_14_COARSE = 14; // Metadata: 0x02349081
	public const int AK_MIDI_CC_CTRL_15_COARSE = 15; // Metadata: 0x02349082
	public const int AK_MIDI_CC_GEN_SLIDER_1 = 16; // Metadata: 0x02349083
	public const int AK_MIDI_CC_GEN_SLIDER_2 = 17; // Metadata: 0x02349084
	public const int AK_MIDI_CC_GEN_SLIDER_3 = 18; // Metadata: 0x02349085
	public const int AK_MIDI_CC_GEN_SLIDER_4 = 19; // Metadata: 0x02349086
	public const int AK_MIDI_CC_CTRL_20_COARSE = 20; // Metadata: 0x02349087
	public const int AK_MIDI_CC_CTRL_21_COARSE = 21; // Metadata: 0x02349088
	public const int AK_MIDI_CC_CTRL_22_COARSE = 22; // Metadata: 0x02349089
	public const int AK_MIDI_CC_CTRL_23_COARSE = 23; // Metadata: 0x0234908A
	public const int AK_MIDI_CC_CTRL_24_COARSE = 24; // Metadata: 0x0234908B
	public const int AK_MIDI_CC_CTRL_25_COARSE = 25; // Metadata: 0x0234908C
	public const int AK_MIDI_CC_CTRL_26_COARSE = 26; // Metadata: 0x0234908D
	public const int AK_MIDI_CC_CTRL_27_COARSE = 27; // Metadata: 0x0234908E
	public const int AK_MIDI_CC_CTRL_28_COARSE = 28; // Metadata: 0x0234908F
	public const int AK_MIDI_CC_CTRL_29_COARSE = 29; // Metadata: 0x02349090
	public const int AK_MIDI_CC_CTRL_30_COARSE = 30; // Metadata: 0x02349091
	public const int AK_MIDI_CC_CTRL_31_COARSE = 31; // Metadata: 0x02349092
	public const int AK_MIDI_CC_BANK_SELECT_FINE = 32; // Metadata: 0x02349093
	public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33; // Metadata: 0x02349094
	public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34; // Metadata: 0x02349095
	public const int AK_MIDI_CC_CTRL_3_FINE = 35; // Metadata: 0x02349096
	public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36; // Metadata: 0x02349097
	public const int AK_MIDI_CC_PORTAMENTO_FINE = 37; // Metadata: 0x02349098
	public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38; // Metadata: 0x02349099
	public const int AK_MIDI_CC_VOLUME_FINE = 39; // Metadata: 0x0234909A
	public const int AK_MIDI_CC_BALANCE_FINE = 40; // Metadata: 0x0234909B
	public const int AK_MIDI_CC_CTRL_9_FINE = 41; // Metadata: 0x0234909C
	public const int AK_MIDI_CC_PAN_POSITION_FINE = 42; // Metadata: 0x0234909D
	public const int AK_MIDI_CC_EXPRESSION_FINE = 43; // Metadata: 0x0234909E
	public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44; // Metadata: 0x0234909F
	public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45; // Metadata: 0x023490A0
	public const int AK_MIDI_CC_CTRL_14_FINE = 46; // Metadata: 0x023490A1
	public const int AK_MIDI_CC_CTRL_15_FINE = 47; // Metadata: 0x023490A2
	public const int AK_MIDI_CC_CTRL_20_FINE = 52; // Metadata: 0x023490A3
	public const int AK_MIDI_CC_CTRL_21_FINE = 53; // Metadata: 0x023490A4
	public const int AK_MIDI_CC_CTRL_22_FINE = 54; // Metadata: 0x023490A5
	public const int AK_MIDI_CC_CTRL_23_FINE = 55; // Metadata: 0x023490A6
	public const int AK_MIDI_CC_CTRL_24_FINE = 56; // Metadata: 0x023490A7
	public const int AK_MIDI_CC_CTRL_25_FINE = 57; // Metadata: 0x023490A8
	public const int AK_MIDI_CC_CTRL_26_FINE = 58; // Metadata: 0x023490A9
	public const int AK_MIDI_CC_CTRL_27_FINE = 59; // Metadata: 0x023490AA
	public const int AK_MIDI_CC_CTRL_28_FINE = 60; // Metadata: 0x023490AB
	public const int AK_MIDI_CC_CTRL_29_FINE = 61; // Metadata: 0x023490AC
	public const int AK_MIDI_CC_CTRL_30_FINE = 62; // Metadata: 0x023490AD
	public const int AK_MIDI_CC_CTRL_31_FINE = 63; // Metadata: 0x023490AE
	public const int AK_MIDI_CC_HOLD_PEDAL = 64; // Metadata: 0x023490AF
	public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65; // Metadata: 0x023490B1
	public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66; // Metadata: 0x023490B3
	public const int AK_MIDI_CC_SOFT_PEDAL = 67; // Metadata: 0x023490B5
	public const int AK_MIDI_CC_LEGATO_PEDAL = 68; // Metadata: 0x023490B7
	public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69; // Metadata: 0x023490B9
	public const int AK_MIDI_CC_SOUND_VARIATION = 70; // Metadata: 0x023490BB
	public const int AK_MIDI_CC_SOUND_TIMBRE = 71; // Metadata: 0x023490BD
	public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72; // Metadata: 0x023490BF
	public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73; // Metadata: 0x023490C1
	public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74; // Metadata: 0x023490C3
	public const int AK_MIDI_CC_SOUND_CTRL_6 = 75; // Metadata: 0x023490C5
	public const int AK_MIDI_CC_SOUND_CTRL_7 = 76; // Metadata: 0x023490C7
	public const int AK_MIDI_CC_SOUND_CTRL_8 = 77; // Metadata: 0x023490C9
	public const int AK_MIDI_CC_SOUND_CTRL_9 = 78; // Metadata: 0x023490CB
	public const int AK_MIDI_CC_SOUND_CTRL_10 = 79; // Metadata: 0x023490CD
	public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80; // Metadata: 0x023490CF
	public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81; // Metadata: 0x023490D1
	public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82; // Metadata: 0x023490D3
	public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83; // Metadata: 0x023490D5
	public const int AK_MIDI_CC_REVERB_LEVEL = 91; // Metadata: 0x023490D7
	public const int AK_MIDI_CC_TREMOLO_LEVEL = 92; // Metadata: 0x023490D9
	public const int AK_MIDI_CC_CHORUS_LEVEL = 93; // Metadata: 0x023490DB
	public const int AK_MIDI_CC_CELESTE_LEVEL = 94; // Metadata: 0x023490DD
	public const int AK_MIDI_CC_PHASER_LEVEL = 95; // Metadata: 0x023490DF
	public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96; // Metadata: 0x023490E1
	public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97; // Metadata: 0x023490E3
	public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98; // Metadata: 0x023490E5
	public const int AK_MIDI_CC_NON_REGISTER_FINE = 99; // Metadata: 0x023490E7
	public const int AK_MIDI_CC_ALL_SOUND_OFF = 120; // Metadata: 0x023490E9
	public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121; // Metadata: 0x023490EB
	public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122; // Metadata: 0x023490ED
	public const int AK_MIDI_CC_ALL_NOTES_OFF = 123; // Metadata: 0x023490EF
	public const int AK_MIDI_CC_OMNI_MODE_OFF = 124; // Metadata: 0x023490F1
	public const int AK_MIDI_CC_OMNI_MODE_ON = 125; // Metadata: 0x023490F3
	public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126; // Metadata: 0x023490F5
	public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127; // Metadata: 0x023490F7
	public const int AK_MIDI_WWISE_CMD_PLAY = 0; // Metadata: 0x023490F9
	public const int AK_MIDI_WWISE_CMD_STOP = 1; // Metadata: 0x023490FA
	public const int AK_MIDI_WWISE_CMD_PAUSE = 2; // Metadata: 0x023490FB
	public const int AK_MIDI_WWISE_CMD_RESUME = 3; // Metadata: 0x023490FC
	public const int AK_MIDI_WWISE_CMD_SEEK_MS = 4; // Metadata: 0x023490FD
	public const int AK_MIDI_WWISE_CMD_SEEK_SAMPLES = 5; // Metadata: 0x023490FE
	public const int AK_SPEAKER_FRONT_LEFT = 1; // Metadata: 0x023490FF
	public const int AK_SPEAKER_FRONT_RIGHT = 2; // Metadata: 0x02349100
	public const int AK_SPEAKER_FRONT_CENTER = 4; // Metadata: 0x02349101
	public const int AK_SPEAKER_LOW_FREQUENCY = 8; // Metadata: 0x02349102
	public const int AK_SPEAKER_BACK_LEFT = 16; // Metadata: 0x02349103
	public const int AK_SPEAKER_BACK_RIGHT = 32; // Metadata: 0x02349104
	public const int AK_SPEAKER_BACK_CENTER = 256; // Metadata: 0x02349105
	public const int AK_SPEAKER_SIDE_LEFT = 512; // Metadata: 0x02349107
	public const int AK_SPEAKER_SIDE_RIGHT = 1024; // Metadata: 0x02349109
	public const int AK_SPEAKER_TOP = 2048; // Metadata: 0x0234910B
	public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096; // Metadata: 0x0234910D
	public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192; // Metadata: 0x0234910F
	public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384; // Metadata: 0x02349113
	public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768; // Metadata: 0x02349117
	public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536; // Metadata: 0x0234911B
	public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072; // Metadata: 0x0234911F
	public const int AK_SPEAKER_SETUP_MONO = 4; // Metadata: 0x02349123
	public const int AK_SPEAKER_SETUP_0POINT1 = 8; // Metadata: 0x02349124
	public const int AK_SPEAKER_SETUP_1POINT1 = 12; // Metadata: 0x02349125
	public const int AK_SPEAKER_SETUP_STEREO = 3; // Metadata: 0x02349126
	public const int AK_SPEAKER_SETUP_2POINT1 = 11; // Metadata: 0x02349127
	public const int AK_SPEAKER_SETUP_3STEREO = 7; // Metadata: 0x02349128
	public const int AK_SPEAKER_SETUP_3POINT1 = 15; // Metadata: 0x02349129
	public const int AK_SPEAKER_SETUP_4 = 1539; // Metadata: 0x0234912A
	public const int AK_SPEAKER_SETUP_4POINT1 = 1547; // Metadata: 0x0234912C
	public const int AK_SPEAKER_SETUP_5 = 1543; // Metadata: 0x0234912E
	public const int AK_SPEAKER_SETUP_5POINT1 = 1551; // Metadata: 0x02349130
	public const int AK_SPEAKER_SETUP_6 = 1587; // Metadata: 0x02349132
	public const int AK_SPEAKER_SETUP_6POINT1 = 1595; // Metadata: 0x02349134
	public const int AK_SPEAKER_SETUP_7 = 1591; // Metadata: 0x02349136
	public const int AK_SPEAKER_SETUP_7POINT1 = 1599; // Metadata: 0x02349138
	public const int AK_SPEAKER_SETUP_SURROUND = 259; // Metadata: 0x0234913A
	public const int AK_SPEAKER_SETUP_DPL2 = 1539; // Metadata: 0x0234913C
	public const int AK_SPEAKER_SETUP_HEIGHT_2 = 20480; // Metadata: 0x0234913E
	public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320; // Metadata: 0x02349142
	public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512; // Metadata: 0x02349146
	public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048; // Metadata: 0x0234914A
	public const int AK_SPEAKER_SETUP_HEIGHT_4_TOP = 186368; // Metadata: 0x0234914E
	public const int AK_SPEAKER_SETUP_HEIGHT_5_TOP = 194560; // Metadata: 0x02349152
	public const int AK_SPEAKER_SETUP_AURO_222 = 22019; // Metadata: 0x02349156
	public const int AK_SPEAKER_SETUP_AURO_8 = 185859; // Metadata: 0x0234915A
	public const int AK_SPEAKER_SETUP_AURO_9 = 185863; // Metadata: 0x0234915E
	public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871; // Metadata: 0x02349162
	public const int AK_SPEAKER_SETUP_AURO_10 = 187911; // Metadata: 0x02349166
	public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919; // Metadata: 0x0234916A
	public const int AK_SPEAKER_SETUP_AURO_11 = 196103; // Metadata: 0x0234916E
	public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111; // Metadata: 0x02349172
	public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911; // Metadata: 0x02349176
	public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919; // Metadata: 0x0234917A
	public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151; // Metadata: 0x0234917E
	public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159; // Metadata: 0x02349182
	public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023; // Metadata: 0x02349186
	public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031; // Metadata: 0x0234918A
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067; // Metadata: 0x0234918E
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075; // Metadata: 0x02349192
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907; // Metadata: 0x02349196
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915; // Metadata: 0x0234919A
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071; // Metadata: 0x0234919E
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079; // Metadata: 0x023491A2
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911; // Metadata: 0x023491A6
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919; // Metadata: 0x023491AA
	public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951; // Metadata: 0x023491AE
	public const int AK_IDX_SETUP_FRONT_LEFT = 0; // Metadata: 0x023491B2
	public const int AK_IDX_SETUP_FRONT_RIGHT = 1; // Metadata: 0x023491B3
	public const int AK_IDX_SETUP_CENTER = 2; // Metadata: 0x023491B4
	public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2; // Metadata: 0x023491B5
	public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3; // Metadata: 0x023491B6
	public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4; // Metadata: 0x023491B7
	public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5; // Metadata: 0x023491B8
	public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3; // Metadata: 0x023491B9
	public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4; // Metadata: 0x023491BA
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5; // Metadata: 0x023491BB
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6; // Metadata: 0x023491BC
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_LEFT = 7; // Metadata: 0x023491BD
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_FRONT_RIGHT = 8; // Metadata: 0x023491BE
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_LEFT = 9; // Metadata: 0x023491BF
	public const int AK_IDX_SETUP_WITHCENTER_HEIGHT_BACK_RIGHT = 10; // Metadata: 0x023491C0
	public const int AK_IDX_SETUP_0_LFE = 0; // Metadata: 0x023491C1
	public const int AK_IDX_SETUP_1_CENTER = 0; // Metadata: 0x023491C2
	public const int AK_IDX_SETUP_1_LFE = 1; // Metadata: 0x023491C3
	public const int AK_IDX_SETUP_2_LEFT = 0; // Metadata: 0x023491C4
	public const int AK_IDX_SETUP_2_RIGHT = 1; // Metadata: 0x023491C5
	public const int AK_IDX_SETUP_2_LFE = 2; // Metadata: 0x023491C6
	public const int AK_IDX_SETUP_3_LEFT = 0; // Metadata: 0x023491C7
	public const int AK_IDX_SETUP_3_RIGHT = 1; // Metadata: 0x023491C8
	public const int AK_IDX_SETUP_3_CENTER = 2; // Metadata: 0x023491C9
	public const int AK_IDX_SETUP_3_LFE = 3; // Metadata: 0x023491CA
	public const int AK_IDX_SETUP_4_FRONTLEFT = 0; // Metadata: 0x023491CB
	public const int AK_IDX_SETUP_4_FRONTRIGHT = 1; // Metadata: 0x023491CC
	public const int AK_IDX_SETUP_4_REARLEFT = 2; // Metadata: 0x023491CD
	public const int AK_IDX_SETUP_4_REARRIGHT = 3; // Metadata: 0x023491CE
	public const int AK_IDX_SETUP_4_LFE = 4; // Metadata: 0x023491CF
	public const int AK_IDX_SETUP_5_FRONTLEFT = 0; // Metadata: 0x023491D0
	public const int AK_IDX_SETUP_5_FRONTRIGHT = 1; // Metadata: 0x023491D1
	public const int AK_IDX_SETUP_5_CENTER = 2; // Metadata: 0x023491D2
	public const int AK_IDX_SETUP_5_REARLEFT = 3; // Metadata: 0x023491D3
	public const int AK_IDX_SETUP_5_REARRIGHT = 4; // Metadata: 0x023491D4
	public const int AK_IDX_SETUP_5_LFE = 5; // Metadata: 0x023491D5
	public const int AK_IDX_SETUP_6_FRONTLEFT = 0; // Metadata: 0x023491D6
	public const int AK_IDX_SETUP_6_FRONTRIGHT = 1; // Metadata: 0x023491D7
	public const int AK_IDX_SETUP_6_REARLEFT = 2; // Metadata: 0x023491D8
	public const int AK_IDX_SETUP_6_REARRIGHT = 3; // Metadata: 0x023491D9
	public const int AK_IDX_SETUP_6_SIDELEFT = 4; // Metadata: 0x023491DA
	public const int AK_IDX_SETUP_6_SIDERIGHT = 5; // Metadata: 0x023491DB
	public const int AK_IDX_SETUP_6_LFE = 6; // Metadata: 0x023491DC
	public const int AK_IDX_SETUP_7_FRONTLEFT = 0; // Metadata: 0x023491DD
	public const int AK_IDX_SETUP_7_FRONTRIGHT = 1; // Metadata: 0x023491DE
	public const int AK_IDX_SETUP_7_CENTER = 2; // Metadata: 0x023491DF
	public const int AK_IDX_SETUP_7_REARLEFT = 3; // Metadata: 0x023491E0
	public const int AK_IDX_SETUP_7_REARRIGHT = 4; // Metadata: 0x023491E1
	public const int AK_IDX_SETUP_7_SIDELEFT = 5; // Metadata: 0x023491E2
	public const int AK_IDX_SETUP_7_SIDERIGHT = 6; // Metadata: 0x023491E3
	public const int AK_IDX_SETUP_7_LFE = 7; // Metadata: 0x023491E4
	public const int AK_SPEAKER_SETUP_0_1 = 8; // Metadata: 0x023491E5
	public const int AK_SPEAKER_SETUP_1_0_CENTER = 4; // Metadata: 0x023491E6
	public const int AK_SPEAKER_SETUP_1_1_CENTER = 12; // Metadata: 0x023491E7
	public const int AK_SPEAKER_SETUP_2_0 = 3; // Metadata: 0x023491E8
	public const int AK_SPEAKER_SETUP_2_1 = 11; // Metadata: 0x023491E9
	public const int AK_SPEAKER_SETUP_3_0 = 7; // Metadata: 0x023491EA
	public const int AK_SPEAKER_SETUP_3_1 = 15; // Metadata: 0x023491EB
	public const int AK_SPEAKER_SETUP_FRONT = 7; // Metadata: 0x023491EC
	public const int AK_SPEAKER_SETUP_4_0 = 1539; // Metadata: 0x023491ED
	public const int AK_SPEAKER_SETUP_4_1 = 1547; // Metadata: 0x023491EF
	public const int AK_SPEAKER_SETUP_5_0 = 1543; // Metadata: 0x023491F1
	public const int AK_SPEAKER_SETUP_5_1 = 1551; // Metadata: 0x023491F3
	public const int AK_SPEAKER_SETUP_6_0 = 1587; // Metadata: 0x023491F5
	public const int AK_SPEAKER_SETUP_6_1 = 1595; // Metadata: 0x023491F7
	public const int AK_SPEAKER_SETUP_7_0 = 1591; // Metadata: 0x023491F9
	public const int AK_SPEAKER_SETUP_7_1 = 1599; // Metadata: 0x023491FB
	public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599; // Metadata: 0x023491FD
	public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951; // Metadata: 0x023491FF
	public const int AK_STANDARD_MAX_NUM_CHANNELS = 8; // Metadata: 0x02349203
	public const int AK_MAX_AMBISONICS_ORDER = 5; // Metadata: 0x02349204
	public const int AK_MAX_NUM_TEXTURE = 4; // Metadata: 0x02349205
	public const int AK_MAX_REFLECT_ORDER = 4; // Metadata: 0x02349206
	public const int AK_MAX_REFLECTION_PATH_LENGTH = 8; // Metadata: 0x02349207
	public const int AK_STOCHASTIC_RESERVE_LENGTH = 8; // Metadata: 0x02349208
	public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8; // Metadata: 0x02349209
	public const int AK_MAX_SOUND_PROPAGATION_WIDTH = 8; // Metadata: 0x0234920A
	public const double AK_SA_DIFFRACTION_DOT_EPSILON = 5E-05; // Metadata: 0x0234920B
	public const double AK_DEFAULT_GEOMETRY_POSITION_X = 0; // Metadata: 0x02349213
	public const double AK_DEFAULT_GEOMETRY_POSITION_Y = 0; // Metadata: 0x0234921B
	public const double AK_DEFAULT_GEOMETRY_POSITION_Z = 0; // Metadata: 0x02349223
	public const double AK_DEFAULT_GEOMETRY_FRONT_X = 0; // Metadata: 0x0234922B
	public const double AK_DEFAULT_GEOMETRY_FRONT_Y = 0; // Metadata: 0x02349233
	public const double AK_DEFAULT_GEOMETRY_FRONT_Z = 1; // Metadata: 0x0234923B
	public const double AK_DEFAULT_GEOMETRY_TOP_X = 0; // Metadata: 0x02349243
	public const double AK_DEFAULT_GEOMETRY_TOP_Y = 1; // Metadata: 0x0234924B
	public const double AK_DEFAULT_GEOMETRY_TOP_Z = 0; // Metadata: 0x02349253
	private static GameObjectHashFunction gameObjectHash; // 0x00
	public const uint AK_PENDING_EVENT_LOAD_ID = 4294967295; // Metadata: 0x0234925B

	// Properties
	public static uint AK_INVALID_SHARE_SET_ID { get; } // 0x00000001853DCEA0-0x00000001853DCEE0 
	public static uint AK_INVALID_PIPELINE_ID { get; } // 0x00000001853DCE60-0x00000001853DCEA0 
	public static ulong AK_INVALID_AUDIO_OBJECT_ID { get; } // 0x00000001853DCDA0-0x00000001853DCDE0 
	public static uint AK_SOUNDBANK_VERSION { get; } // 0x00000001853DD020-0x00000001853DD060 
	public static uint AkJobType_Generic { get; } // 0x00000001853DD0A0-0x00000001853DD0E0 
	public static uint AkJobType_AudioProcessing { get; } // 0x00000001853DD060-0x00000001853DD0A0 
	public static uint AkJobType_SpatialAudio { get; } // 0x00000001853DD0E0-0x00000001853DD120 
	public static uint AK_NUM_JOB_TYPES { get; } // 0x00000001853DCFE0-0x00000001853DD020 
	public static ushort AK_INT { get; } // 0x00000001853DCD60-0x00000001853DCDA0 
	public static ushort AK_FLOAT { get; } // 0x00000001853DCCE0-0x00000001853DCD20 
	public static byte AK_INTERLEAVED { get; } // 0x00000001853DCD20-0x00000001853DCD60 
	public static byte AK_NONINTERLEAVED { get; } // 0x00000001853DCFA0-0x00000001853DCFE0 
	public static uint AK_LE_NATIVE_BITSPERSAMPLE { get; } // 0x00000001853DCEE0-0x00000001853DCF20 
	public static uint AK_LE_NATIVE_SAMPLETYPE { get; } // 0x00000001853DCF60-0x00000001853DCFA0 
	public static uint AK_LE_NATIVE_INTERLEAVE { get; } // 0x00000001853DCF20-0x00000001853DCF60 
	public static byte AK_INVALID_MIDI_CHANNEL { get; } // 0x00000001853DCDE0-0x00000001853DCE20 
	public static byte AK_INVALID_MIDI_NOTE { get; } // 0x00000001853DCE20-0x00000001853DCE60 
	public static uint kDefaultDiffractionMaxEdges { get; } // 0x00000001853DD2B0-0x00000001853DD2F0 
	public static uint kDefaultDiffractionMaxPaths { get; } // 0x00000001853DD2F0-0x00000001853DD330 
	public static float kMaxDiffraction { get; } // 0x00000001853DD3F0-0x00000001853DD430 
	public static uint kHashListBlockAllocItemCount { get; } // 0x00000001853DD3B0-0x00000001853DD3F0 
	public static uint kDiffractionMaxEdges { get; } // 0x00000001853DD330-0x00000001853DD370 
	public static uint kDiffractionMaxPaths { get; } // 0x00000001853DD370-0x00000001853DD3B0 
	public static uint kPortalToPortalDiffractionMaxPaths { get; } // 0x00000001853DD430-0x00000001853DD470 
	public static GameObjectHashFunction GameObjectHash { set; } // 0x00000001853DD470-0x00000001853DD518
	public static string WwiseVersion { get; } // 0x00000001853DD120-0x00000001853DD2B0 

	// Nested types
	public delegate ulong GameObjectHashFunction(GameObject gameObject); // TypeDefIndex: 56688; 0x00000001814E2060-0x00000001814E2070

	// Constructors
	public AkSoundEngine(); // 0x00000001841E1670-0x00000001841E1680
	static AkSoundEngine(); // 0x0000000184B48320-0x0000000184B483C0

	// Methods
	public static uint JoystickIdToWwiseId(uint joyStickID); // 0x00000001853D2E50-0x00000001853D2E98
	public static Vector3 ConvertAkVector64ToAkVector(AkVector64 in_); // 0x00000001853CF86C-0x00000001853CF8E8
	public static AkTransform ConvertAkWorldTransformToAkTransform(AkWorldTransform in_); // 0x00000001853CF964-0x00000001853CF9E0
	public static AkVector64 ConvertAkVectorToAkVector64(Vector3 in_); // 0x00000001853CF8E8-0x00000001853CF964
	public static AkWorldTransform ConvertAkTransformToAkWorldTransform(AkTransform in_); // 0x00000001853CF7F0-0x00000001853CF86C
	public static bool IsBankCodecID(uint in_codecID); // 0x00000001853D2DAC-0x00000001853D2DF4
	public static uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType); // 0x00000001853CFCA0-0x00000001853CFD78
	public static uint DynamicSequenceOpen(ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x00000001853CFD78-0x00000001853CFE48
	public static uint DynamicSequenceOpen(ulong in_gameObjectID); // 0x00000001853CFED4-0x00000001853CFF3C
	public static AKRESULT DynamicSequenceClose(uint in_playingID); // 0x00000001853CFA74-0x00000001853CFABC
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D0138-0x00000001853D0194
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration); // 0x00000001853D0194-0x00000001853D01EC
	public static AKRESULT DynamicSequencePlay(uint in_playingID); // 0x00000001853D01EC-0x00000001853D0234
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D0084-0x00000001853D00E0
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration); // 0x00000001853D00E0-0x00000001853D0138
	public static AKRESULT DynamicSequencePause(uint in_playingID); // 0x00000001853D003C-0x00000001853D0084
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D02D4-0x00000001853D0330
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration); // 0x00000001853D0234-0x00000001853D028C
	public static AKRESULT DynamicSequenceResume(uint in_playingID); // 0x00000001853D028C-0x00000001853D02D4
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D0330-0x00000001853D038C
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration); // 0x00000001853D038C-0x00000001853D03E4
	public static AKRESULT DynamicSequenceStop(uint in_playingID); // 0x00000001853D03E4-0x00000001853D042C
	public static AKRESULT DynamicSequenceBreak(uint in_playingID); // 0x00000001853CFA2C-0x00000001853CFA74
	public static AKRESULT Seek(uint in_playingID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x00000001853D89F4-0x00000001853D8A50
	public static AKRESULT Seek(uint in_playingID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x00000001853D8A50-0x00000001853D8AB0
	public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration); // 0x00000001853CFABC-0x00000001853CFB1C
	public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID); // 0x00000001853CFB1C-0x00000001853CFBA8
	public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID); // 0x00000001853D042C-0x00000001853D0474
	public static bool IsInitialized(); // 0x0000000183AC77C0-0x0000000183AC7810
	public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings); // 0x00000001853D0EB0-0x00000001853D0F04
	public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput); // 0x00000001853D26A0-0x00000001853D2710
	public static AkChannelConfig GetSpeakerConfiguration(); // 0x0000000183AC7530-0x0000000183AC75B0
	public static AKRESULT GetOutputDeviceConfiguration(ulong in_idOutput, AkChannelConfig io_channelConfig, Ak3DAudioSinkCapabilities io_capabilities); // 0x00000001853D1BAC-0x00000001853D1C30
	public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput); // 0x00000001853D1D2C-0x00000001853D1D88
	public static AKRESULT GetPanningRule(out int out_ePanningRule); // 0x00000001853D1CE0-0x00000001853D1D2C
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput); // 0x00000001853DAADC-0x00000001853DAB34
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule); // 0x00000001853DAA94-0x00000001853DAADC
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput); // 0x00000001853D25CC-0x00000001853D2640
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle); // 0x00000001853D2640-0x00000001853D26A0
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput); // 0x00000001853DB924-0x00000001853DB998
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle); // 0x00000001853DB998-0x00000001853DB9F8
	public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB); // 0x00000001853DBC1C-0x00000001853DBC6C
	public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices); // 0x00000001853D9D2C-0x00000001853D9D78
	public static AKRESULT SetJobMgrMaxActiveWorkers(uint in_jobType, uint in_uNewMaxActiveWorkers); // 0x00000001853D9970-0x00000001853D99C8
	public static AKRESULT RenderAudio(bool in_bAllowSyncRender); // 0x00000001853D6EE4-0x00000001853D6F30
	public static AKRESULT RenderAudio(); // 0x000000018328B3C0-0x000000018328B410
	public static AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath); // 0x00000001853D6A28-0x00000001853D6A84
	public static AKRESULT RegisterPluginDLL(string in_DllName); // 0x00000001853D6A84-0x00000001853D6AD0
	public static bool IsPluginRegistered(AkPluginType in_eType, uint in_ulCompanyID, uint in_ulPluginID); // 0x00000001853D2DF4-0x00000001853D2E50
	public static uint GetIDFromString(string in_pszString); // 0x0000000183EB0640-0x0000000183EB0690
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID); // 0x00000001853D3D30-0x00000001853D3E54
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x0000000183ABED90-0x0000000183ABEEE0
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x000000018328C940-0x000000018328CA20
	public static uint PostEvent(uint in_eventID, ulong in_gameObjectID); // 0x00000001853D40B0-0x00000001853D4124
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID); // 0x00000001853D4860-0x00000001853D4984
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x00000001853D3FA0-0x00000001853D40B0
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x00000001853D4688-0x00000001853D4764
	public static uint PostEvent(string in_pszEventName, ulong in_gameObjectID); // 0x00000001853D43A4-0x00000001853D441C
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID); // 0x00000001853D095C-0x00000001853D09DC
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D0728-0x00000001853D07A0
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration); // 0x00000001853D0D14-0x00000001853D0D84
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, ulong in_gameObjectID); // 0x00000001853D050C-0x00000001853D0568
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType); // 0x00000001853D0ACC-0x00000001853D0B24
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID); // 0x00000001853D06A4-0x00000001853D0728
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D0A50-0x00000001853D0ACC
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID, int in_uTransitionDuration); // 0x00000001853D09DC-0x00000001853D0A50
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, ulong in_gameObjectID); // 0x00000001853D0568-0x00000001853D05C8
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType); // 0x00000001853D064C-0x00000001853D06A4
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_playingID); // 0x00000001853D4984-0x00000001853D4AB0
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x00000001853D4CB0-0x00000001853D4DD0
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts, bool in_bAbsoluteOffsets); // 0x00000001853D4C00-0x00000001853D4CB0
	public static uint PostMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts); // 0x00000001853D4B58-0x00000001853D4C00
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID, uint in_playingID); // 0x00000001853DC0F8-0x00000001853DC158
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, ulong in_gameObjectID); // 0x00000001853DC0A0-0x00000001853DC0F8
	public static AKRESULT StopMIDIOnEvent(uint in_eventID); // 0x00000001853DC058-0x00000001853DC0A0
	public static AKRESULT StopMIDIOnEvent(); // 0x00000001853DC018-0x00000001853DC058
	public static AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority); // 0x00000001853D3708-0x00000001853D3768
	public static AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority); // 0x00000001853D3768-0x00000001853D37C8
	public static AKRESULT UnpinEventInStreamCache(uint in_eventID); // 0x00000001853DC8D4-0x00000001853DC91C
	public static AKRESULT UnpinEventInStreamCache(string in_pszEventName); // 0x00000001853DC888-0x00000001853DC8D4
	public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull); // 0x00000001853D0FA4-0x00000001853D1004
	public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull); // 0x00000001853D0F44-0x00000001853D0FA4
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x00000001853D7EF4-0x00000001853D7F70
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x00000001853D7FEC-0x00000001853D8060
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, int in_iPosition); // 0x00000001853D83C8-0x00000001853D8428
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x00000001853D816C-0x00000001853D81E8
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x00000001853D7DAC-0x00000001853D7E20
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, int in_iPosition); // 0x00000001853D890C-0x00000001853D896C
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x00000001853D85EC-0x00000001853D8668
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x00000001853D7E20-0x00000001853D7E94
	public static AKRESULT SeekOnEvent(uint in_eventID, ulong in_gameObjectID, float in_fPercent); // 0x00000001853D7E94-0x00000001853D7EF4
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x00000001853D7F70-0x00000001853D7FEC
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x00000001853D80F8-0x00000001853D816C
	public static AKRESULT SeekOnEvent(string in_pszEventName, ulong in_gameObjectID, float in_fPercent); // 0x00000001853D8814-0x00000001853D8874
	public static void CancelEventCallbackCookie(object in_pCookie); // 0x00000001853CF3AC-0x00000001853CF3F8
	public static void CancelEventCallbackGameObject(ulong in_gameObjectID); // 0x00000001853CF460-0x00000001853CF4AC
	public static void CancelEventCallback(uint in_playingID); // 0x00000001853CF4AC-0x00000001853CF4F4
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate); // 0x00000001853D250C-0x00000001853D256C
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition); // 0x00000001853D24B4-0x00000001853D250C
	public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering); // 0x00000001853D256C-0x00000001853D25CC
	public static void StopAll(ulong in_gameObjectID); // 0x0000000183CE32B0-0x0000000183CE32E0
	public static void StopAll(); // 0x00000001853DBE94-0x00000001853DBED4
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853DC198-0x00000001853DC1F4
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration); // 0x00000001853DC1F4-0x00000001853DC24C
	public static void StopPlayingID(uint in_playingID); // 0x00000001853DC24C-0x00000001853DC294
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D0DDC-0x00000001853D0E4C
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration); // 0x00000001838702C0-0x0000000183870310
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID); // 0x00000001853D0D84-0x00000001853D0DDC
	public static void SetRandomSeed(uint in_uSeed); // 0x00000001853DB7AC-0x00000001853DB7F4
	public static void MuteBackgroundMusic(bool in_bMute); // 0x00000001853D367C-0x00000001853D36C8
	public static bool GetBackgroundMusicMute(); // 0x00000001853D0F04-0x00000001853D0F44
	public static AKRESULT SendPluginCustomGameData(uint in_busID, ulong in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes); // 0x00000001853D8AB0-0x00000001853D8B40
	public static AKRESULT UnregisterAllGameObj(); // 0x00000001853DC91C-0x00000001853DC95C
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags); // 0x00000001853D9FE8-0x00000001853DA078
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType); // 0x0000000183B8B690-0x0000000183B8B730
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions); // 0x00000001853DA3F4-0x00000001853DA468
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType, AkSetPositionFlags in_eFlags); // 0x00000001853DA078-0x00000001853DA108
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType); // 0x00000001853DA17C-0x00000001853DA204
	public static AKRESULT SetMultiplePositions(ulong in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions); // 0x00000001853DA108-0x00000001853DA17C
	public static AKRESULT SetScalingFactor(ulong in_GameObjectID, float in_fAttenuationScalingFactor); // 0x0000000183E59620-0x0000000183E59660
	public static AKRESULT SetDistanceProbe(ulong in_listenerGameObjectID, ulong in_distanceProbeGameObjectID); // 0x00000001853D8F8C-0x00000001853D8FE8
	public static AKRESULT ClearBanks(); // 0x00000001853CF5DC-0x00000001853CF61C
	public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority); // 0x00000001853D8CAC-0x00000001853D8D08
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID, uint in_bankType); // 0x00000001853D34DC-0x00000001853D353C
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID); // 0x00000001853D3428-0x00000001853D3484
	public static AKRESULT LoadBank(uint in_bankID, uint in_bankType); // 0x00000001853D3484-0x00000001853D34DC
	public static AKRESULT LoadBank(uint in_bankID); // 0x0000000183EB47A0-0x0000000183EB47F0
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID); // 0x00000001853D31E4-0x00000001853D3244
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID, out uint out_bankType); // 0x00000001853D3170-0x00000001853D31E4
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID); // 0x00000001853D2F3C-0x00000001853D2F9C
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID, out uint out_bankType); // 0x00000001853D2F9C-0x00000001853D3010
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, uint in_bankType); // 0x00000001853D3384-0x00000001853D3428
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID); // 0x00000001853D32E8-0x00000001853D3384
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType); // 0x0000000183EB0C60-0x0000000183EB0CE0
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x0000000183EB06D0-0x0000000183EB0770
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID); // 0x00000001853D3244-0x00000001853D32E8
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, out uint out_bankType); // 0x00000001853D30C0-0x00000001853D3170
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID); // 0x00000001853D2E98-0x00000001853D2F3C
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID, out uint out_bankType); // 0x00000001853D3010-0x00000001853D30C0
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, uint in_bankType); // 0x00000001853DC69C-0x00000001853DC6FC
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr); // 0x00000001853DC748-0x00000001853DC7A4
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, uint in_bankType); // 0x00000001853DC6FC-0x00000001853DC748
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr); // 0x00000001853DC504-0x00000001853DC55C
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType); // 0x00000001853DC55C-0x00000001853DC600
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x00000001853DC7A4-0x00000001853DC840
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, uint in_bankType); // 0x0000000183EB09F0-0x0000000183EB0A70
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x00000001853DC600-0x00000001853DC69C
	public static void CancelBankCallbackCookie(object in_pCookie); // 0x00000001853CF360-0x00000001853CF3AC
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags, uint in_bankType); // 0x00000001853D56A8-0x00000001853D571C
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags); // 0x00000001853D58C8-0x00000001853D5928
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString); // 0x00000001853D541C-0x00000001853D5474
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags, uint in_bankType); // 0x00000001853D5928-0x00000001853D5998
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags); // 0x00000001853D57C0-0x00000001853D581C
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID); // 0x00000001853D5650-0x00000001853D56A8
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType); // 0x00000001853D581C-0x00000001853D58C8
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags); // 0x00000001853D571C-0x00000001853D57C0
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x00000001853D5474-0x00000001853D5510
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags, uint in_bankType); // 0x00000001853D5510-0x00000001853D55B8
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags); // 0x00000001853D537C-0x00000001853D541C
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x00000001853D55B8-0x00000001853D5650
	public static AKRESULT ClearPreparedEvents(); // 0x00000001853CF7B0-0x00000001853CF7F0
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent); // 0x00000001853D5C38-0x00000001853D5E48
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent); // 0x00000001853D5998-0x00000001853D59E4
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x00000001853D59E4-0x00000001853D5C38
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x0000000183EB0BD0-0x0000000183EB0C60
	public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings); // 0x00000001853D9D78-0x00000001853D9DE4
	public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings); // 0x00000001853DCBA0-0x00000001853DCC0C
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs); // 0x00000001853D5EC0-0x00000001853D60EC
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs); // 0x00000001853D5E48-0x00000001853D5EC0
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x00000001853D61AC-0x00000001853D6414
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie); // 0x00000001853D60EC-0x00000001853D61AC
	public static AKRESULT AddListener(ulong in_emitterGameObj, ulong in_listenerGameObj); // 0x00000001853CEEDC-0x00000001853CEF38
	public static AKRESULT RemoveListener(ulong in_emitterGameObj, ulong in_listenerGameObj); // 0x00000001853D6DF0-0x00000001853D6E4C
	public static AKRESULT AddDefaultListener(ulong in_listenerGameObj); // 0x00000001853CEE90-0x00000001853CEEDC
	public static AKRESULT RemoveDefaultListener(ulong in_listenerGameObj); // 0x00000001853D6B38-0x00000001853D6B84
	public static AKRESULT ResetListenersToDefault(ulong in_emitterGameObj); // 0x00000001853D7070-0x00000001853D70BC
	public static AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets); // 0x00000001853D9A3C-0x00000001853D9ABC
	public static AKRESULT SetListenerSpatialization(ulong in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig); // 0x00000001853D99C8-0x00000001853D9A3C
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853DB0EC-0x00000001853DB174
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853DB010-0x00000001853DB08C
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration); // 0x0000000183197C40-0x0000000183197CC0
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, ulong in_gameObjectID); // 0x00000001853DB08C-0x00000001853DB0EC
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value); // 0x00000001853DB5A8-0x00000001853DB600
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853DAF84-0x00000001853DB010
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853DB1E8-0x00000001853DB264
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID, int in_uValueChangeDuration); // 0x00000001853DB174-0x00000001853DB1E8
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, ulong in_gameObjectID); // 0x00000001853DB548-0x00000001853DB5A8
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value); // 0x00000001853DB750-0x00000001853DB7AC
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853DAC54-0x00000001853DACDC
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853DAD68-0x00000001853DADE4
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration); // 0x00000001845E4370-0x00000001845E4400
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID); // 0x00000001853DAB94-0x00000001853DABF4
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853DACDC-0x00000001853DAD68
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853DADE4-0x00000001853DAE60
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration); // 0x00000001853DAE60-0x00000001853DAED4
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID); // 0x00000001853DABF4-0x00000001853DAC54
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853D795C-0x00000001853D79D8
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D78A0-0x00000001853D7914
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, int in_uValueChangeDuration); // 0x00000001853D7684-0x00000001853D76E4
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, ulong in_gameObjectID); // 0x00000001853D7848-0x00000001853D78A0
	public static AKRESULT ResetRTPCValue(uint in_rtpcID); // 0x00000001853D7914-0x00000001853D795C
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853D76E4-0x00000001853D7760
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D7760-0x00000001853D77D4
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, int in_uValueChangeDuration); // 0x00000001853D7400-0x00000001853D7460
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID); // 0x00000001853D7BFC-0x00000001853D7C58
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName); // 0x00000001853D7B18-0x00000001853D7B64
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853D71E4-0x00000001853D725C
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D70BC-0x00000001853D712C
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID, int in_uValueChangeDuration); // 0x00000001853D72B4-0x00000001853D7310
	public static AKRESULT ResetRTPCValueByPlayingID(uint in_rtpcID, uint in_playingID); // 0x00000001853D712C-0x00000001853D7184
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853D7310-0x00000001853D738C
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D738C-0x00000001853D7400
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID, int in_uValueChangeDuration); // 0x00000001853D7184-0x00000001853D71E4
	public static AKRESULT ResetRTPCValueByPlayingID(string in_pszRtpcName, uint in_playingID); // 0x00000001853D725C-0x00000001853D72B4
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, ulong in_gameObjectID); // 0x00000001853DBA54-0x00000001853DBAB0
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, ulong in_gameObjectID); // 0x00000001853DBB38-0x00000001853DBB98
	public static AKRESULT PostTrigger(uint in_triggerID, ulong in_gameObjectID); // 0x00000001853D5324-0x00000001853D537C
	public static AKRESULT PostTrigger(string in_pszTrigger, ulong in_gameObjectID); // 0x00000001853D51DC-0x00000001853D5238
	public static AKRESULT SetState(uint in_stateGroup, uint in_state); // 0x0000000183A0CBD0-0x0000000183A0CC30
	public static AKRESULT SetState(string in_pszStateGroup, string in_pszState); // 0x00000001853DB9F8-0x00000001853DBA54
	public static AKRESULT SetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues); // 0x00000001853D92A8-0x00000001853D9318
	public static AKRESULT SetGameObjectOutputBusVolume(ulong in_emitterObjID, ulong in_listenerObjID, float in_fControlValue); // 0x00000001853D9480-0x00000001853D94E0
	public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID); // 0x00000001853D8BF4-0x00000001853D8C50
	public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID); // 0x00000001853D8ED0-0x00000001853D8F2C
	public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID); // 0x00000001853D8F2C-0x00000001853D8F8C
	public static AKRESULT SetOutputDeviceEffect(ulong in_outputDeviceID, uint in_uFXIndex, uint in_FXShareSetID); // 0x00000001853DA9D8-0x00000001853DAA38
	public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID); // 0x00000001853D9DE4-0x00000001853D9E3C
	public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID); // 0x00000001853D9E3C-0x00000001853D9E94
	public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig); // 0x00000001853D8DB8-0x00000001853D8E1C
	public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig); // 0x00000001853D8D54-0x00000001853D8DB8
	public static AKRESULT SetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel); // 0x00000001853DA5A8-0x00000001853DA61C
	public static AKRESULT SetMultipleObstructionAndOcclusion(ulong in_EmitterID, ulong in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction); // 0x00000001853D9E94-0x00000001853D9F24
	public static AKRESULT StartOutputCapture(string in_CaptureFileName); // 0x00000001853DBCB8-0x00000001853DBD04
	public static AKRESULT StopOutputCapture(); // 0x00000001853DC158-0x00000001853DC198
	public static AKRESULT AddOutputCaptureMarker(string in_MarkerText); // 0x00000001853CF014-0x00000001853CF060
	public static AKRESULT AddOutputCaptureBinaryMarker(IntPtr in_pMarkerData, uint in_uMarkerDataSize); // 0x00000001853CEFBC-0x00000001853CF014
	public static uint GetSampleRate(); // 0x00000001853D2334-0x00000001853D2374
	public static AKRESULT StartProfilerCapture(string in_CaptureFileName); // 0x00000001853DBD44-0x00000001853DBD90
	public static AKRESULT StopProfilerCapture(); // 0x00000001853DC2D4-0x00000001853DC314
	public static AKRESULT SetOfflineRenderingFrameTime(float in_fFrameTimeInSeconds); // 0x00000001853DA93C-0x00000001853DA98C
	public static AKRESULT SetOfflineRendering(bool in_bEnableOfflineRendering); // 0x00000001853DA98C-0x00000001853DA9D8
	public static AKRESULT RemoveOutput(ulong in_idOutput); // 0x00000001853D6E4C-0x00000001853D6E98
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, out ulong out_pOutputDeviceId); // 0x00000001853D6F94-0x00000001853D7008
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId); // 0x00000001853D6F30-0x00000001853D6F94
	public static ulong GetOutputID(uint in_idShareset, uint in_idDevice); // 0x00000001853D1C30-0x00000001853D1C88
	public static ulong GetOutputID(string in_szShareSet, uint in_idDevice); // 0x00000001853D1C88-0x00000001853D1CE0
	public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice); // 0x00000001853D8E78-0x00000001853D8ED0
	public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName); // 0x00000001853D8E1C-0x00000001853D8E78
	public static AKRESULT GetDeviceList(uint in_ulCompanyID, uint in_ulPluginID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions); // 0x00000001853D13AC-0x00000001853D1438
	public static AKRESULT GetDeviceList(uint in_audioDeviceShareSetID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions); // 0x00000001840092B0-0x0000000184009340
	public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume); // 0x00000001853DAA38-0x00000001853DAA94
	public static AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice); // 0x0000000184009190-0x00000001840091E0
	public static AKRESULT Suspend(bool in_bRenderAnyway, bool in_bFadeOut); // 0x00000001853DC428-0x00000001853DC484
	public static AKRESULT Suspend(bool in_bRenderAnyway); // 0x00000001853DC39C-0x00000001853DC3E8
	public static AKRESULT Suspend(); // 0x00000001853DC3E8-0x00000001853DC428
	public static AKRESULT WakeupFromSuspend(uint in_uDelayMs); // 0x00000001853DCC58-0x00000001853DCCA0
	public static AKRESULT WakeupFromSuspend(); // 0x00000001853DCCA0-0x00000001853DCCE0
	public static uint GetBufferTick(); // 0x00000001853D1004-0x00000001853D1044
	public static ulong GetSampleTick(); // 0x00000001853D2374-0x00000001853D23B4
	public static void AkMemGetCategoryStats(int in_poolId, AkMemCategroyStats out_poolStats); // 0x00000001853CF260-0x00000001853CF2C4
	public static void AkMemGetGlobalStats(AkMemGlobalStats out_stats); // 0x00000001853CF2C4-0x00000001853CF318
	public static void StartProfileThreadUsage(); // 0x00000001853DBD04-0x00000001853DBD44
	public static ulong StopProfileThreadUsage(); // 0x00000001853DC294-0x00000001853DC2D4
	public static void DumpToFile(string pszFilename); // 0x00000001853CF9E0-0x00000001853CFA2C
	public static ulong GetGlobalUsed(); // 0x00000001853D1770-0x00000001853D17B0
	public static ulong GetGlobalReserved(); // 0x00000001853D1730-0x00000001853D1770
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate); // 0x00000001853D1E70-0x00000001853D1EE4
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo); // 0x00000001853D1EE4-0x00000001853D1F48
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus); // 0x00000001853D3BB4-0x00000001853D3C34
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID); // 0x00000001853D39E0-0x00000001853D3A58
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID); // 0x00000001853D3838-0x00000001853D38A8
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID); // 0x00000001853D3B00-0x00000001853D3B5C
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel); // 0x00000001853D3B5C-0x00000001853D3BB4
	public static AKRESULT PostCodeVarArg(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, MsgContext msgContext); // 0x00000001853D37C8-0x00000001853D3838
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID, bool in_bIsBus); // 0x00000001853D4FEC-0x00000001853D5070
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID, uint in_audioNodeID); // 0x00000001853D4DD0-0x00000001853D4E4C
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, ulong in_gameObjID); // 0x00000001853D50C8-0x00000001853D513C
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID); // 0x00000001853D4F8C-0x00000001853D4FEC
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel); // 0x00000001853D5070-0x00000001853D50C8
	public static AKRESULT ResetTranslator(); // 0x00000001853D7C98-0x00000001853D7CD8
	public static int GetTimeStamp(); // 0x00000001853D29D0-0x00000001853D2A10
	public static void MonitorStreamMgrInit(AkStreamMgrSettings in_streamMgrSettings); // 0x00000001853D353C-0x00000001853D3590
	public static void MonitorStreamingDeviceInit(uint in_deviceID, AkDeviceSettings in_deviceSettings); // 0x00000001853D3618-0x00000001853D367C
	public static void MonitorStreamingDeviceDestroyed(uint in_deviceID); // 0x00000001853D35D0-0x00000001853D3618
	public static void MonitorStreamMgrTerm(); // 0x00000001853D3590-0x00000001853D35D0
	public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties); // 0x00000001853CF20C-0x00000001853CF260
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence); // 0x00000001853D7CD8-0x00000001853D7D4C
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments); // 0x00000001853D7D4C-0x00000001853D7DAC
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue); // 0x00000001853D1494-0x00000001853D14F0
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue); // 0x00000001853D1438-0x00000001853D1494
	public static AKRESULT GetPosition(ulong in_GameObjectID, AkWorldTransform out_rPosition); // 0x00000001853D1F48-0x00000001853D1FAC
	public static AKRESULT GetListenerPosition(ulong in_uListenerID, AkWorldTransform out_rPosition); // 0x00000001853D1864-0x00000001853D18C8
	public static AKRESULT GetRTPCValue(uint in_rtpcID, ulong in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType); // 0x00000001853D2140-0x00000001853D21BC
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, ulong in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType); // 0x00000001853D2260-0x00000001853D22E0
	public static AKRESULT GetSwitch(uint in_switchGroup, ulong in_gameObjectID, out uint out_rSwitchState); // 0x00000001853D2804-0x00000001853D2864
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, ulong in_GameObj, out uint out_rSwitchState); // 0x00000001853D2970-0x00000001853D29D0
	public static AKRESULT GetState(uint in_stateGroup, out uint out_rState); // 0x00000001853D276C-0x00000001853D27C4
	public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState); // 0x00000001853D2710-0x00000001853D276C
	public static AKRESULT GetGameObjectAuxSendValues(ulong in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues); // 0x00000001853D1584-0x00000001853D15F4
	public static AKRESULT GetGameObjectDryLevelValue(ulong in_EmitterID, ulong in_ListenerID, out float out_rfControlValue); // 0x00000001853D15F4-0x00000001853D1654
	public static AKRESULT GetObjectObstructionAndOcclusion(ulong in_EmitterID, ulong in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel); // 0x00000001853D1A90-0x00000001853D1B04
	public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos); // 0x00000001853D6490-0x00000001853D650C
	public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos); // 0x00000001853D6414-0x00000001853D6490
	public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo); // 0x00000001853D2038-0x00000001853D209C
	public static bool GetIsGameObjectActive(ulong in_GameObjId); // 0x00000001853D1818-0x00000001853D1864
	public static float GetMaxRadius(ulong in_GameObjId); // 0x00000001853D1A44-0x00000001853D1A90
	public static uint GetEventIDFromPlayingID(uint in_playingID); // 0x00000001844B03E0-0x00000001844B0430
	public static ulong GetGameObjectFromPlayingID(uint in_playingID); // 0x00000001853D16E8-0x00000001853D1730
	public static AKRESULT GetPlayingIDsFromGameObject(ulong in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs); // 0x00000001853D1E10-0x00000001853D1E70
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue); // 0x00000001853D1104-0x00000001853D1160
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue); // 0x00000001853D1160-0x00000001853D11BC
	public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask); // 0x00000001853CED90-0x00000001853CEDDC
	public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask); // 0x00000001853CEDDC-0x00000001853CEE28
	public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask); // 0x00000001853CED44-0x00000001853CED90
	public static byte ChannelMaskToNumChannels(uint in_uChannelMask); // 0x00000001853CF594-0x00000001853CF5DC
	public static uint ChannelMaskFromNumChannels(uint in_uNumChannels); // 0x00000001853CF54C-0x00000001853CF594
	public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask); // 0x00000001853CF4F4-0x00000001853CF54C
	public static bool HasSurroundChannels(uint in_uChannelMask); // 0x00000001853D2C68-0x00000001853D2CB0
	public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask); // 0x00000001853D2C20-0x00000001853D2C68
	public static bool HasSideAndRearChannels(uint in_uChannelMask); // 0x00000001853D2BD8-0x00000001853D2C20
	public static bool HasHeightChannels(uint in_uChannelMask); // 0x00000001853D2B90-0x00000001853D2BD8
	public static uint BackToSideChannels(uint in_uChannelMask); // 0x00000001853CF318-0x00000001853CF360
	public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx); // 0x00000001853DBDD0-0x00000001853DBE2C
	public static AKRESULT SetGameObjectRadius(ulong in_gameObjectID, float in_outerRadius, float in_innerRadius); // 0x00000001853D94E0-0x00000001853D9544
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID, ulong in_gameObjectID); // 0x00000001853D98E8-0x00000001853D9970
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name, uint in_AuxBusID); // 0x00000001853D9868-0x00000001853D98E8
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_name); // 0x00000001853D97F4-0x00000001853D9868
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, ulong in_gameObjectID); // 0x00000001853D6D10-0x00000001853D6D6C
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID); // 0x00000001853D6BEC-0x00000001853D6C44
	public static AKRESULT RemoveImageSource(uint in_srcID); // 0x00000001853D6CC8-0x00000001853D6D10
	public static AKRESULT ClearImageSources(uint in_AuxBusID, ulong in_gameObjectID); // 0x00000001853CF6D0-0x00000001853CF728
	public static AKRESULT ClearImageSources(uint in_AuxBusID); // 0x00000001853CF728-0x00000001853CF770
	public static AKRESULT ClearImageSources(); // 0x00000001853CF770-0x00000001853CF7B0
	public static AKRESULT RemoveGeometry(ulong in_SetID); // 0x0000000183CE2D50-0x0000000183CE2D80
	public static AKRESULT RemoveGeometryInstance(ulong in_GeometryInstanceID); // 0x0000000183CE3490-0x0000000183CE34E0
	public static AKRESULT RemoveRoom(ulong in_RoomID); // 0x0000000183CE3580-0x0000000183CE35D0
	public static AKRESULT RemovePortal(ulong in_PortalID); // 0x0000000183CE3A10-0x0000000183CE3A60
	public static AKRESULT SetReverbZone(ulong in_ReverbZone, ulong in_ParentRoom, float in_transitionRegionWidth); // 0x0000000183CDFBB0-0x0000000183CDFC20
	public static AKRESULT RemoveReverbZone(ulong in_ReverbZone); // 0x00000001853D6E98-0x00000001853D6EE4
	public static AKRESULT SetGameObjectInRoom(ulong in_gameObjectID, ulong in_CurrentRoomID); // 0x00000001853D9318-0x00000001853D9374
	public static AKRESULT UnsetGameObjectInRoom(ulong in_gameObjectID); // 0x00000001853DCB54-0x00000001853DCBA0
	public static AKRESULT SetReflectionsOrder(uint in_uReflectionsOrder, bool in_bUpdatePaths); // 0x0000000184008E20-0x0000000184008E80
	public static AKRESULT SetDiffractionOrder(uint in_uDiffractionOrder, bool in_bUpdatePaths); // 0x0000000184008D80-0x0000000184008DE0
	public static AKRESULT SetMaxEmitterRoomAuxSends(uint in_uMaxEmitterRoomAuxSends); // 0x00000001853D9CE4-0x00000001853D9D2C
	public static AKRESULT SetNumberOfPrimaryRays(uint in_uNbPrimaryRays); // 0x0000000184008AC0-0x0000000184008B10
	public static AKRESULT SetLoadBalancingSpread(uint in_uNbFrames); // 0x0000000184008A30-0x0000000184008A80
	public static AKRESULT SetEarlyReflectionsAuxSend(ulong in_gameObjectID, uint in_auxBusID); // 0x00000001853D8FE8-0x00000001853D9040
	public static AKRESULT SetEarlyReflectionsVolume(ulong in_gameObjectID, float in_fSendVolume); // 0x00000001853D90B4-0x00000001853D9110
	public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion); // 0x0000000183CE0D80-0x0000000183CE0DF0
	public static AKRESULT SetGameObjectToPortalObstruction(ulong in_gameObjectID, ulong in_PortalID, float in_fObstruction); // 0x00000001853D9544-0x00000001853D95A4
	public static AKRESULT SetPortalToPortalObstruction(ulong in_PortalID0, ulong in_PortalID1, float in_fObstruction); // 0x00000001853DAB34-0x00000001853DAB94
	public static AKRESULT QueryWetDiffraction(ulong in_portal, out float out_wetDiffraction); // 0x00000001853D680C-0x00000001853D6868
	public static AKRESULT ResetStochasticEngine(); // 0x00000001853D7C58-0x00000001853D7C98
	public static uint GetDeviceIDFromName(string in_szToken); // 0x00000001853D1360-0x00000001853D13AC
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID, AkAudioDeviceState uDeviceStateMask); // 0x00000001853D2B0C-0x00000001853D2B90
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID); // 0x00000001853D2A98-0x00000001853D2B0C
	public static uint GetWindowsDeviceCount(AkAudioDeviceState uDeviceStateMask); // 0x00000001853D2A10-0x00000001853D2A58
	public static uint GetWindowsDeviceCount(); // 0x00000001853D2A58-0x00000001853D2A98
	public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger); // 0x00000001849CB490-0x00000001849CB4E0
	public static void SetErrorLogger(); // 0x00000001853D9188-0x00000001853D91C8
	public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat); // 0x00000001853D8C50-0x00000001853D8CAC
	public static AKRESULT Init(AkInitializationSettings settings); // 0x000000018400A9F0-0x000000018400AA50
	public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings); // 0x00000001840081A0-0x0000000184008200
	public static AKRESULT InitCommunication(AkCommunicationSettings settings); // 0x00000001853D2CF0-0x00000001853D2D44
	public static void Term(); // 0x00000001853DC484-0x00000001853DC4C4
	public static AKRESULT RegisterGameObjInternal(ulong in_GameObj); // 0x000000018319BD10-0x000000018319BD60
	public static AKRESULT UnregisterGameObjInternal(ulong in_GameObj); // 0x0000000183CE3380-0x0000000183CE33B0
	public static AKRESULT RegisterGameObjInternal_WithName(ulong in_GameObj, string in_pszObjName); // 0x0000000183CDE940-0x0000000183CDE980
	public static AKRESULT SetBasePath(string in_pszBasePath); // 0x00000001853D8D08-0x00000001853D8D54
	public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath); // 0x0000000183EB4510-0x0000000183EB4560
	public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID); // 0x0000000183EB5CD0-0x0000000183EB5D30
	public static AKRESULT AddBasePath(string in_pszBasePath); // 0x0000000184653E10-0x0000000184653E60
	public static AKRESULT SetGameName(string in_GameName); // 0x00000001853D91C8-0x00000001853D9214
	public static string GetCurrentLanguage(); // 0x00000001853D10A4-0x00000001853D1104
	public static AKRESULT UnloadFilePackage(uint in_uPackageID); // 0x00000001853DC840-0x00000001853DC888
	public static AKRESULT UnloadAllFilePackages(); // 0x00000001853DC4C4-0x00000001853DC504
	public static AKRESULT SetObjectPosition(ulong in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top); // 0x000000018319AE30-0x000000018319AEE0
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate); // 0x00000001853D2430-0x00000001853D24B4
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions); // 0x00000001853D23B4-0x00000001853D2430
	public static AKRESULT SetListeners(ulong in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners); // 0x00000001853D9C84-0x00000001853D9CE4
	public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners); // 0x000000018434CD70-0x000000018434CDD0
	public static uint GetNumOutputDevices(uint in_AudioDeviceShareSetID); // 0x0000000184009100-0x0000000184009150
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners); // 0x00000001853CF060-0x00000001853CF0E0
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs); // 0x00000001853CF134-0x00000001853CF1A8
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID); // 0x00000001853CF1A8-0x00000001853CF20C
	public static AKRESULT AddOutput(AkOutputSettings in_Settings); // 0x00000001853CF0E0-0x00000001853CF134
	public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings); // 0x00000001853D130C-0x00000001853D1360
	public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings); // 0x00000001853D11BC-0x00000001853D1210
	public static void GetDefaultMusicSettings(AkMusicSettings out_settings); // 0x00000001853D1264-0x00000001853D12B8
	public static void GetDefaultInitSettings(AkInitSettings out_settings); // 0x00000001853D1210-0x00000001853D1264
	public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings); // 0x00000001853D12B8-0x00000001853D130C
	public static uint GetMajorMinorVersion(); // 0x00000001853D199C-0x00000001853D19DC
	public static uint GetSubminorBuildVersion(); // 0x00000001853D27C4-0x00000001853D2804
	public static void StartResourceMonitoring(); // 0x00000001853DBD90-0x00000001853DBDD0
	public static void StopResourceMonitoring(); // 0x00000001853DC314-0x00000001853DC354
	public static void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary); // 0x00000001853D22E0-0x00000001853D2334
	public static void StartDeviceCapture(ulong in_idOutputDeviceID); // 0x00000001853DBC6C-0x00000001853DBCB8
	public static void StopDeviceCapture(ulong in_idOutputDeviceID); // 0x00000001853DBED4-0x00000001853DBF20
	public static void ClearCaptureData(); // 0x00000001853CF61C-0x00000001853CF65C
	public static uint UpdateCaptureSampleCount(ulong in_idOutputDeviceID); // 0x00000001853DCC0C-0x00000001853DCC58
	public static uint GetCaptureSamples(ulong in_idOutputDeviceID, float[] out_pSamples, uint in_uBufferSize); // 0x00000001853D1044-0x00000001853D10A4
	public static AKRESULT SetRoomPortal(ulong in_PortalID, ulong FrontRoom, ulong BackRoom, AkTransform Transform, AkExtent Extent, bool bEnabled, string in_pName); // 0x00000001853DB7F4-0x00000001853DB8AC
	public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, ulong GeometryInstanceID, string in_pName); // 0x0000000183CDF410-0x0000000183CDF4A0
	public static AKRESULT RegisterSpatialAudioListener(ulong in_gameObjectID); // 0x000000018434CD20-0x000000018434CD70
	public static AKRESULT UnregisterSpatialAudioListener(ulong in_gameObjectID); // 0x00000001853DCAA0-0x00000001853DCAEC
	public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, Vector3[] Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges); // 0x00000001853D9650-0x00000001853D973C
	public static AKRESULT SetGeometryInstance(ulong in_GeomInstanceID, AkTransform Transform, Vector3 Scale, ulong GeometrySetID, ulong RoomID, bool UseForReflectionAndDiffraction); // 0x00000001853D95A4-0x00000001853D9650
	public static AKRESULT QueryReflectionPaths(ulong in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize); // 0x00000001853D668C-0x00000001853D6738
	public static AKRESULT QueryDiffractionPaths(ulong in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize); // 0x00000001853D650C-0x00000001853D65B8
	public static void PerformStreamMgrIO(); // 0x00000001853D36C8-0x00000001853D3708
	public static void HgMemShrink(); // 0x00000001853D2CB0-0x00000001853D2CF0
	public static ulong HgGetGlobalMemoryUsed(); // 0x000000018328AC00-0x000000018328AC30
	public static ulong HgGetGlobalMemoryReserved(); // 0x00000001848199B0-0x00000001848199E0
	public static void InitScePad(); // 0x000000018332A770-0x000000018332A7B0
	public static uint GetMMDeviceIdFromPadContainerInfo(int in_padHandle); // 0x00000001853D1954-0x00000001853D199C
	public static string StringFromIntPtrString(IntPtr ptr); // 0x00000001853DC354-0x00000001853DC39C
	public static string StringFromIntPtrWString(IntPtr ptr); // 0x00000001845E1CE0-0x00000001845E1D30
	private static ulong InternalGameObjectHash(GameObject gameObject); // 0x00000001853D2D44-0x00000001853D2DAC
	public static ulong GetAkGameObjectID(GameObject gameObject); // 0x00000001853D0E4C-0x00000001853D0EB0
	public static AKRESULT RegisterGameObj(GameObject gameObject); // 0x00000001853D6948-0x00000001853D69B0
	public static AKRESULT RegisterGameObj(GameObject gameObject, string name); // 0x00000001853D69B0-0x00000001853D6A28
	public static AKRESULT UnregisterGameObj(GameObject gameObject); // 0x00000001853DCA04-0x00000001853DCAA0
	public static void UnregisterAllGameObjects(); // 0x00000001853DC95C-0x00000001853DC99C
	public static AKRESULT SetObjectPosition(GameObject gameObject, Transform transform); // 0x00000001853DA6F0-0x00000001853DA7FC
	public static AKRESULT SetObjectPosition(GameObject gameObject, float posX, float posY, float posZ, float frontX, float frontY, float frontZ, float topX, float topY, float topZ); // 0x00000001853DA7FC-0x00000001853DA93C
	public static void PreGameObjectAPICall(GameObject gameObject, ulong id); // 0x00000001841E1670-0x00000001841E1680
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType); // 0x00000001853CFF3C-0x00000001853D003C
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x00000001853CFBA8-0x00000001853CFCA0
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID); // 0x00000001853CFE48-0x00000001853CFED4
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID); // 0x00000001853D425C-0x00000001853D43A4
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x00000001853D441C-0x00000001853D4550
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x00000001853D3C34-0x00000001853D3D30
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID); // 0x00000001853D4124-0x00000001853D41C0
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID); // 0x00000001853D3E54-0x00000001853D3FA0
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources); // 0x00000001853D4550-0x00000001853D4688
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie); // 0x00000001853D4764-0x00000001853D4860
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID); // 0x00000001853D41C0-0x00000001853D425C
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID); // 0x00000001853D0BCC-0x00000001853D0C74
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D08BC-0x00000001853D095C
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration); // 0x00000001853D0824-0x00000001853D08BC
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID); // 0x00000001853D07A0-0x00000001853D0824
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID); // 0x00000001853D0B24-0x00000001853D0BCC
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D0C74-0x00000001853D0D14
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration); // 0x00000001853D0474-0x00000001853D050C
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID); // 0x00000001853D05C8-0x00000001853D064C
	public static AKRESULT PostMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts); // 0x00000001853D4AB0-0x00000001853D4B58
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID); // 0x00000001853DBFA4-0x00000001853DC018
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_playingID); // 0x00000001853DBF20-0x00000001853DBFA4
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x00000001853D8668-0x00000001853D8708
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x00000001853D8060-0x00000001853D80F8
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition); // 0x00000001853D8790-0x00000001853D8814
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x00000001853D8324-0x00000001853D83C8
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker); // 0x00000001853D8288-0x00000001853D8324
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition); // 0x00000001853D8708-0x00000001853D8790
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x00000001853D81E8-0x00000001853D8288
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x00000001853D8874-0x00000001853D890C
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent); // 0x00000001853D84CC-0x00000001853D8550
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID); // 0x00000001853D8428-0x00000001853D84CC
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker); // 0x00000001853D8550-0x00000001853D85EC
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent); // 0x00000001853D896C-0x00000001853D89F4
	public static void CancelEventCallbackGameObject(GameObject in_gameObjectID); // 0x00000001853CF3F8-0x00000001853CF460
	public static void StopAll(GameObject in_gameObjectID); // 0x00000001853DBE2C-0x00000001853DBE94
	public static AKRESULT SendPluginCustomGameData(uint in_busID, GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes); // 0x00000001853D8B40-0x00000001853D8BF4
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType); // 0x00000001853DA348-0x00000001853DA3F4
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions); // 0x00000001853DA204-0x00000001853DA29C
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType); // 0x00000001853DA29C-0x00000001853DA348
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions); // 0x00000001853DA468-0x00000001853DA500
	public static AKRESULT SetScalingFactor(GameObject in_GameObjectID, float in_fAttenuationScalingFactor); // 0x00000001853DB8AC-0x00000001853DB924
	public static AKRESULT AddListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj); // 0x00000001853CEF38-0x00000001853CEFBC
	public static AKRESULT RemoveListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj); // 0x00000001853D6D6C-0x00000001853D6DF0
	public static AKRESULT AddDefaultListener(GameObject in_listenerGameObj); // 0x00000001853CEE28-0x00000001853CEE90
	public static AKRESULT RemoveDefaultListener(GameObject in_listenerGameObj); // 0x00000001853D6B84-0x00000001853D6BEC
	public static AKRESULT ResetListenersToDefault(GameObject in_emitterGameObj); // 0x00000001853D7008-0x00000001853D7070
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets); // 0x00000001853D9B58-0x00000001853D9BFC
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig); // 0x00000001853D9ABC-0x00000001853D9B58
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853DB6A0-0x00000001853DB750
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853DB600-0x00000001853DB6A0
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration); // 0x00000001853DB2E8-0x00000001853DB380
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID); // 0x00000001853DB264-0x00000001853DB2E8
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853DAED4-0x00000001853DAF84
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853DB380-0x00000001853DB424
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration); // 0x00000001853DB4AC-0x00000001853DB548
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID); // 0x00000001853DB424-0x00000001853DB4AC
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853D755C-0x00000001853D75FC
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D7B64-0x00000001853D7BFC
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration); // 0x00000001853D7460-0x00000001853D74E4
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID); // 0x00000001853D77D4-0x00000001853D7848
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation); // 0x00000001853D7A74-0x00000001853D7B18
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve); // 0x00000001853D79D8-0x00000001853D7A74
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration); // 0x00000001853D75FC-0x00000001853D7684
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID); // 0x00000001853D74E4-0x00000001853D755C
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject in_gameObjectID); // 0x00000001853DBB98-0x00000001853DBC1C
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, GameObject in_gameObjectID); // 0x00000001853DBAB0-0x00000001853DBB38
	public static AKRESULT PostTrigger(uint in_triggerID, GameObject in_gameObjectID); // 0x00000001853D5238-0x00000001853D52AC
	public static AKRESULT PostTrigger(string in_pszTrigger, GameObject in_gameObjectID); // 0x00000001853D52AC-0x00000001853D5324
	public static AKRESULT SetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues); // 0x00000001853D9214-0x00000001853D92A8
	public static AKRESULT SetGameObjectOutputBusVolume(GameObject in_emitterObjID, GameObject in_listenerObjID, float in_fControlValue); // 0x00000001853D93EC-0x00000001853D9480
	public static AKRESULT SetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel); // 0x00000001853DA500-0x00000001853DA5A8
	public static AKRESULT SetMultipleObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction); // 0x00000001853D9F24-0x00000001853D9FE8
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus); // 0x00000001853D3A58-0x00000001853D3B00
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID); // 0x00000001853D38A8-0x00000001853D3948
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID); // 0x00000001853D3948-0x00000001853D39E0
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus); // 0x00000001853D4EE4-0x00000001853D4F8C
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID); // 0x00000001853D513C-0x00000001853D51DC
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID); // 0x00000001853D4E4C-0x00000001853D4EE4
	public static AKRESULT GetPosition(GameObject in_GameObjectID, AkTransform out_rPosition); // 0x00000001853D1FAC-0x00000001853D2038
	public static AKRESULT GetListenerPosition(GameObject in_uIndex, AkTransform out_rPosition); // 0x00000001853D18C8-0x00000001853D1954
	public static AKRESULT GetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType); // 0x00000001853D21BC-0x00000001853D2260
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType); // 0x00000001853D209C-0x00000001853D2140
	public static AKRESULT GetSwitch(uint in_switchGroup, GameObject in_gameObjectID, out uint out_rSwitchState); // 0x00000001853D2864-0x00000001853D28E8
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, GameObject in_GameObj, out uint out_rSwitchState); // 0x00000001853D28E8-0x00000001853D2970
	public static AKRESULT GetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues); // 0x00000001853D14F0-0x00000001853D1584
	public static AKRESULT GetGameObjectDryLevelValue(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfControlValue); // 0x00000001853D1654-0x00000001853D16E8
	public static AKRESULT GetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel); // 0x00000001853D1B04-0x00000001853D1BAC
	public static bool GetIsGameObjectActive(GameObject in_GameObjId); // 0x00000001853D17B0-0x00000001853D1818
	public static float GetMaxRadius(GameObject in_GameObjId); // 0x00000001853D19DC-0x00000001853D1A44
	public static AKRESULT GetPlayingIDsFromGameObject(GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs); // 0x00000001853D1D88-0x00000001853D1E10
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, string in_imageSourceName, uint in_AuxBusID, GameObject in_gameObjectID); // 0x00000001853D973C-0x00000001853D97F4
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, GameObject in_gameObjectID); // 0x00000001853D6C44-0x00000001853D6CC8
	public static AKRESULT ClearImageSources(uint in_AuxBusID, GameObject in_gameObjectID); // 0x00000001853CF65C-0x00000001853CF6D0
	public static AKRESULT QueryReflectionPaths(GameObject in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize); // 0x00000001853D6738-0x00000001853D680C
	public static AKRESULT SetGameObjectInRoom(GameObject in_gameObjectID, ulong in_CurrentRoomID); // 0x00000001853D9374-0x00000001853D93EC
	public static AKRESULT SetEarlyReflectionsAuxSend(GameObject in_gameObjectID, uint in_auxBusID); // 0x00000001853D9040-0x00000001853D90B4
	public static AKRESULT SetEarlyReflectionsVolume(GameObject in_gameObjectID, float in_fSendVolume); // 0x00000001853D9110-0x00000001853D9188
	public static AKRESULT QueryDiffractionPaths(GameObject in_gameObjectID, uint in_positionIndex, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize); // 0x00000001853D65B8-0x00000001853D668C
	public static AKRESULT RegisterGameObjInternal(GameObject in_GameObj); // 0x00000001853D68E0-0x00000001853D6948
	public static AKRESULT UnregisterGameObjInternal(GameObject in_GameObj); // 0x00000001853DC99C-0x00000001853DCA04
	public static AKRESULT RegisterGameObjInternal_WithName(GameObject in_GameObj, string in_pszObjName); // 0x00000001853D6868-0x00000001853D68E0
	public static AKRESULT SetObjectPosition(GameObject in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top); // 0x00000001853DA61C-0x00000001853DA6F0
	public static AKRESULT SetListeners(GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners); // 0x00000001853D9BFC-0x00000001853D9C84
	public static AKRESULT RegisterSpatialAudioListener(GameObject in_gameObjectID); // 0x00000001853D6AD0-0x00000001853D6B38
	public static AKRESULT UnregisterSpatialAudioListener(GameObject in_gameObjectID); // 0x00000001853DCAEC-0x00000001853DCB54
	public static string StringFromIntPtrOSString(IntPtr ptr); // 0x00000001845E1C90-0x00000001845E1CE0
}

public class AkThreadProperties : IDisposable // TypeDefIndex: 56690
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public int nPriority { get; set; } // 0x00000001853DD914-0x00000001853DD964 0x00000001853DDA30-0x00000001853DDA84
	public uint dwAffinityMask { get; set; } // 0x00000001853DD8C4-0x00000001853DD914 0x00000001853DD9DC-0x00000001853DDA30
	public uint uStackSize { get; set; } // 0x00000001853DD964-0x00000001853DD9B4 0x00000001853DDA84-0x00000001853DDAD8

	// Constructors
	internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50
	public AkThreadProperties(); // 0x00000001853DD874-0x00000001853DD8C4

	// Methods
	internal static IntPtr getCPtr(AkThreadProperties obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853DD9B4-0x00000001853DD9DC
	~AkThreadProperties(); // 0x00000001853DD800-0x00000001853DD874
	public void Dispose(); // 0x00000001853DD69C-0x00000001853DD6EC
	protected virtual void Dispose(bool disposing); // 0x00000001853DD6EC-0x00000001853DD800
}

public class AkUnityPlatformSpecificSettings : IDisposable // TypeDefIndex: 56691
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Constructors
	internal AkUnityPlatformSpecificSettings(IntPtr cPtr, bool cMemoryOwn); // 0x0000000184D85A40-0x0000000184D85A50

	// Methods
	internal static IntPtr getCPtr(AkUnityPlatformSpecificSettings obj); // 0x000000018539B720-0x000000018539B730
	internal virtual void setCPtr(IntPtr cPtr); // 0x00000001853DDCAC-0x00000001853DDCD4
	~AkUnityPlatformSpecificSettings(); // 0x00000001848F4000-0x00000001848F4050
	public void Dispose(); // 0x00000001853DDC5C-0x00000001853DDCAC
	protected virtual void Dispose(bool disposing); // 0x00000001848F4050-0x00000001848F4210
}

public class AkAndroidSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 56694
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 56693
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
		public enum AudioAPI // TypeDefIndex: 56692
		{
			Default = -1,
			None = 0,
			AAudio = 1,
			OpenSL_ES = 2
		}

		// Constructors
		public PlatformAdvancedSettings(); // 0x0000000184D610D0-0x0000000184D61120

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x00000001841E1670-0x00000001841E1680
	}

	// Constructors
	public AkAndroidSettings(); // 0x0000000184165E80-0x0000000184165FE0

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001811F36E0-0x00000001811F36F0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000184D85A50-0x0000000184D85A60
	protected override AkCommonCommSettings GetCommsSettings(); // 0x0000000184D85A60-0x0000000184D85A70
}

public static class AkAudioInputManager // TypeDefIndex: 56699
{
	// Fields
	private static bool initialized; // 0x00
	private static readonly Dictionary<uint, AudioSamplesDelegate> audioSamplesDelegates; // 0x08
	private static readonly Dictionary<uint, AudioFormatDelegate> audioFormatDelegates; // 0x10
	private static readonly AkAudioFormat audioFormat; // 0x18
	private static readonly AudioSamplesInteropDelegate audioSamplesDelegate; // 0x20
	private static readonly AudioFormatInteropDelegate audioFormatDelegate; // 0x28

	// Nested types
	public delegate void AudioFormatDelegate(uint playingID, AkAudioFormat format); // TypeDefIndex: 56695; 0x00000001838E1420-0x00000001838E1430

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void AudioFormatInteropDelegate(uint playingID, IntPtr format); // TypeDefIndex: 56696; 0x00000001838E1420-0x00000001838E1430

	public delegate bool AudioSamplesDelegate(uint playingID, uint channelIndex, float[] samples); // TypeDefIndex: 56697; 0x00000001814F3120-0x00000001814F3140

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate bool AudioSamplesInteropDelegate(uint playingID, [In, Out] float[] samples, uint channelIndex, uint frames); // TypeDefIndex: 56698; 0x00000001814D0D00-0x00000001814D0D20

	// Constructors
	static AkAudioInputManager(); // 0x00000001853CBAB8-0x00000001853CBCE4

	// Methods
	public static uint PostAudioInputEvent(uint akEventID, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null); // 0x00000001853CB80C-0x00000001853CB910
	public static uint PostAudioInputEvent(string akEventName, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null); // 0x00000001853CB910-0x00000001853CBA14
	[AOT.MonoPInvokeCallback(typeof(AudioSamplesInteropDelegate))]
	private static bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames); // 0x00000001853CB720-0x00000001853CB80C
	[AOT.MonoPInvokeCallback(typeof(AudioFormatInteropDelegate))]
	private static void InternalAudioFormatDelegate(uint playingID, IntPtr format); // 0x00000001853CB61C-0x00000001853CB720
	private static void TryInitialize(); // 0x00000001853CBA14-0x00000001853CBAB8
	private static void AddPlayingID(uint playingID, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate); // 0x00000001853CB454-0x00000001853CB52C
	private static void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo); // 0x00000001853CB52C-0x00000001853CB61C
}

public class AkBasePathGetter // TypeDefIndex: 56700
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
	public static bool IsWwiseProjectAvailable { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001853CC548-0x00000001853CC598 0x00000001853CC5E8-0x00000001853CC63C
	public string SoundBankBasePath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	public string PersistentDataPath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	public static string WwiseProjectFullPath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001853CC598-0x00000001853CC5E8 0x00000001853CC63C-0x00000001853CC69C

	// Constructors
	public AkBasePathGetter(); // 0x00000001841E1670-0x00000001841E1680
	static AkBasePathGetter(); // 0x0000000184D13CB0-0x0000000184D13D50

	// Methods
	public static string GetPlatformName(); // 0x00000001840093E0-0x0000000184009410
	public static string GetPlatformBasePath(string platformName = "" /* Metadata: 0x02349260 */); // 0x00000001853CC388-0x00000001853CC478
	public static AkBasePathGetter Get(); // 0x00000001853CC478-0x00000001853CC548
	public static void Reset(); // 0x0000000184D534D0-0x0000000184D53540
	public void EvaluateGamePaths(); // 0x00000001853CC27C-0x00000001853CC388
}

public static class AkCallbackManager // TypeDefIndex: 56709
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
	public static int bnkCallbackCount { get; } // 0x00000001853CD5D8-0x00000001853CD638 
	public static int evtCallbackCount { get; } // 0x00000001853CD638-0x00000001853CD698 

	// Nested types
	public delegate void EventCallback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info); // TypeDefIndex: 56701; 0x0000000181546280-0x00000001815462A0

	public delegate void MonitoringCallback(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg); // TypeDefIndex: 56702; 0x00000001814DD080-0x00000001814DD0A0

	public delegate void BankCallback(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie); // TypeDefIndex: 56703; 0x00000001815547C0-0x00000001815547E0

	public class EventCallbackPackage // TypeDefIndex: 56704
	{
		// Fields
		public EventCallback callback; // 0x10
		public object cookie; // 0x18
		public uint playingID; // 0x20

		// Constructors
		public EventCallbackPackage(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal static void Recycle(EventCallbackPackage inPkg); // 0x000000018328CE20-0x000000018328CF20
		public static EventCallbackPackage Create(EventCallback inCb, object inCookie, ref uint ioFlags); // 0x000000018328CA20-0x000000018328CBB0
	}

	public class BankCallbackPackage // TypeDefIndex: 56705
	{
		// Fields
		public BankCallback callback; // 0x10
		public object cookie; // 0x18

		// Constructors
		public BankCallbackPackage(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		public static BankCallbackPackage Create(BankCallback inCb, object inCookie); // 0x0000000183EB0CE0-0x0000000183EB0DB0
		public static void Recycle(BankCallbackPackage pkg); // 0x0000000183289F80-0x000000018328A000
	}

	private class SimplePool<T> // TypeDefIndex: 56706
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

	public delegate AKRESULT BGMCallback(bool in_bOtherAudioPlaying, object in_Cookie); // TypeDefIndex: 56707; 0x00000001815802E0-0x00000001815802F0

	public class BGMCallbackPackage // TypeDefIndex: 56708
	{
		// Fields
		public BGMCallback m_Callback; // 0x10
		public object m_Cookie; // 0x18

		// Constructors
		public BGMCallbackPackage(); // 0x00000001841E1670-0x00000001841E1680
	}

	// Constructors
	static AkCallbackManager(); // 0x0000000183F33280-0x0000000183F337D0

	// Methods
	public static void CancelAllCallbacks(); // 0x00000001853CC73C-0x00000001853CCA94
	public static void RemoveEventCallback(uint in_playingID); // 0x00000001853CD2A8-0x00000001853CD518
	public static void RemoveEventCallbackCookie(object in_cookie); // 0x00000001853CCEA0-0x00000001853CD2A8
	public static void RemoveBankCallback(object in_cookie); // 0x00000001853CCAE4-0x00000001853CCEA0
	public static void SetLastAddedPlayingID(uint in_playingID); // 0x000000018328CC10-0x000000018328CD90
	public static void Init(); // 0x000000018400AB30-0x000000018400AB80
	public static void Term(); // 0x00000001853CD5D0-0x00000001853CD5D8
	public static void SetMonitoringCallback(AkMonitorErrorLevel in_Level, MonitoringCallback in_CB); // 0x0000000184A365F0-0x0000000184A36660
	private static void SetLocalOutput(AkMonitorErrorLevel in_Level); // 0x00000001841E1670-0x00000001841E1680
	public static void SetBGMCallback(BGMCallback in_CB, object in_cookie); // 0x00000001853CD518-0x00000001853CD5D0
	public static void PostCallbacksNoInvoke(); // 0x00000001853CCA94-0x00000001853CCAE4
	public static int PostCallbacks(); // 0x000000018328B440-0x000000018328BEC0
	private static void _ProcessBankCallback(IntPtr pPackage, IntPtr pData); // 0x0000000183289C40-0x0000000183289E30
	private static AkCallbackInfo _ProcessEventCallback(AkCallbackType eType, IntPtr pData); // 0x000000018328CD90-0x000000018328CE20
}

public class AkBasePlatformSettings : ScriptableObject // TypeDefIndex: 56710
{
	// Properties
	public virtual AkInitializationSettings AkInitializationSettings { get; } // 0x000000018400A800-0x000000018400A850 
	public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; } // 0x0000000184009D10-0x0000000184009D70 
	public virtual string SoundBankPersistentDataPath { get; } // 0x00000001811EC580-0x00000001811EC590 
	public virtual string SoundbankPath { get; } // 0x00000001853CC6EC-0x00000001853CC73C 
	public virtual AkCommunicationSettings AkCommunicationSettings { get; } // 0x00000001853CC69C-0x00000001853CC6EC 
	public virtual uint MemoryAllocationSizeLimit { get; } // 0x00000001811EC580-0x00000001811EC590 
	public virtual uint MemoryDebugLevel { get; } // 0x00000001811EC580-0x00000001811EC590 

	// Constructors
	public AkBasePlatformSettings(); // 0x0000000183573370-0x0000000183573380
}

[Serializable]
public class AkCommonOutputSettings // TypeDefIndex: 56715
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
	public enum PanningRule // TypeDefIndex: 56711
	{
		Speakers = 0,
		Headphones = 1
	}

	[Serializable]
	public class ChannelConfiguration // TypeDefIndex: 56714
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
		public enum ChannelConfigType // TypeDefIndex: 56712
		{
			Anonymous = 0,
			Standard = 1,
			Ambisonic = 2
		}

		public enum ChannelMask // TypeDefIndex: 56713
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
		public ChannelConfiguration(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		public void CopyTo(AkChannelConfig config); // 0x00000001845E21B0-0x00000001845E21F0
	}

	// Constructors
	public AkCommonOutputSettings(); // 0x0000000184166680-0x0000000184166700

	// Methods
	public void CopyTo(AkOutputSettings settings); // 0x00000001845E2040-0x00000001845E20E0
}

[Serializable]
public class AkCommonUserSettings // TypeDefIndex: 56717
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
	public class SpatialAudioSettings // TypeDefIndex: 56716
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
		public SpatialAudioSettings(); // 0x0000000184B22A20-0x0000000184B22A70
	}

	// Constructors
	public AkCommonUserSettings(); // 0x0000000184166700-0x0000000184166790

	// Methods
	protected static string GetPluginPath(); // 0x0000000183DA3310-0x0000000183DA34B0
	public virtual void CopyTo(AkInitSettings settings); // 0x00000001845E1A90-0x00000001845E1BD0
	public void CopyTo(AkMusicSettings settings); // 0x000000018400AA90-0x000000018400AAC0
	public void CopyTo(AkStreamMgrSettings settings); // 0x00000001841E1670-0x00000001841E1680
	public virtual void CopyTo(AkDeviceSettings settings); // 0x00000001841E1670-0x00000001841E1680
	private void SetSampleRate(AkPlatformInitSettings settings); // 0x000000018400AB00-0x000000018400AB30
	public virtual void CopyTo(AkPlatformInitSettings settings); // 0x000000018400AAC0-0x000000018400AB00
	public virtual void CopyTo(AkSpatialAudioInitSettings settings); // 0x0000000184009E00-0x0000000184009F70
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings); // 0x00000001841E1670-0x00000001841E1680
	public virtual void Validate(); // 0x00000001853CDC1C-0x00000001853CDC7C
}

[Serializable]
public class AkCommonAdvancedSettings // TypeDefIndex: 56719
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
	public enum MemSpanCount // TypeDefIndex: 56718
	{
		Small = 0,
		Medium = 1,
		Huge = 2
	}

	// Constructors
	public AkCommonAdvancedSettings(); // 0x0000000184D85A90-0x0000000184D85AD0

	// Methods
	public virtual void CopyTo(AkDeviceSettings settings); // 0x000000018400AD10-0x000000018400AD70
	public virtual void CopyTo(AkInitSettings settings); // 0x000000018479E370-0x000000018479E3F0
	public virtual void CopyTo(AkPlatformInitSettings settings); // 0x00000001841E1670-0x00000001841E1680
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings); // 0x00000001841E1670-0x00000001841E1680
}

[Serializable]
public class AkCommonCommSettings // TypeDefIndex: 56720
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
	public AkCommonCommSettings(); // 0x0000000184166610-0x0000000184166680
	static AkCommonCommSettings(); // 0x0000000184D77100-0x0000000184D77140

	// Methods
	public virtual void CopyTo(AkCommunicationSettings settings); // 0x00000001853CDAA8-0x00000001853CDB3C
	public virtual void Validate(); // 0x00000001841E1670-0x00000001841E1680
}

public abstract class AkCommonPlatformSettings : AkBasePlatformSettings // TypeDefIndex: 56721
{
	// Properties
	public override AkInitializationSettings AkInitializationSettings { get; } // 0x0000000184009800-0x0000000184009980 
	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings { get; } // 0x0000000184009CC0-0x0000000184009D10 
	public override string SoundBankPersistentDataPath { get; } // 0x00000001853CDBDC-0x00000001853CDBFC 
	public override string SoundbankPath { get; } // 0x00000001853CDBFC-0x00000001853CDC1C 
	public override uint MemoryAllocationSizeLimit { get; } // 0x00000001853CDB9C-0x00000001853CDBBC 
	public override uint MemoryDebugLevel { get; } // 0x00000001853CDBBC-0x00000001853CDBDC 
	public override AkCommunicationSettings AkCommunicationSettings { get; } // 0x00000001853CDB3C-0x00000001853CDB9C 

	// Constructors
	protected AkCommonPlatformSettings(); // 0x0000000183573370-0x0000000183573380

	// Methods
	protected abstract AkCommonUserSettings GetUserSettings();
	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();
	protected abstract AkCommonCommSettings GetCommsSettings();
}

[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class AkEnumFlagAttribute : PropertyAttribute // TypeDefIndex: 56722
{
	// Fields
	public System.Type Type; // 0x10

	// Constructors
	public AkEnumFlagAttribute(System.Type type); // 0x00000001853908C0-0x00000001853908D0
}

public class AkLogger // TypeDefIndex: 56724
{
	// Fields
	private static AkLogger ms_Instance; // 0x00
	private ErrorLoggerInteropDelegate errorLoggerDelegate; // 0x10

	// Properties
	public static AkLogger Instance { get; } // 0x00000001853CE2D8-0x00000001853CE328 

	// Nested types
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void ErrorLoggerInteropDelegate(string message); // TypeDefIndex: 56723; 0x0000000182B46B90-0x0000000182B46BA0

	// Constructors
	private AkLogger(); // 0x00000001849CB370-0x00000001849CB490
	static AkLogger(); // 0x00000001849CB300-0x00000001849CB370

	// Methods
	~AkLogger(); // 0x00000001853CDF68-0x00000001853CE0F8
	public void Init(); // 0x00000001841E1670-0x00000001841E1680
	[AOT.MonoPInvokeCallback(typeof(ErrorLoggerInteropDelegate))]
	public static void WwiseInternalLogError(string message); // 0x00000001853CE238-0x00000001853CE2D8
	public static void Message(string message); // 0x00000001853CE0F8-0x00000001853CE198
	public static void Warning(string message); // 0x00000001853CE198-0x00000001853CE238
	public static void Error(string message); // 0x00000001853CDEC8-0x00000001853CDF68
}

public static class AkSoundEngineInitialization // TypeDefIndex: 56727
{
	// Fields
	public static InitializationDelegate s_initializationDelegate; // 0x00
	public static TerminationDelegate s_terminationDelegate; // 0x08

	// Nested types
	public delegate void InitializationDelegate(); // TypeDefIndex: 56725; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void TerminationDelegate(); // TypeDefIndex: 56726; 0x00000001853DEDB8-0x00000001853DEDC8

	// Methods
	public static bool InitializeSoundEngine(); // 0x00000001840096B0-0x0000000184009800
	private static void _TryInitSpatialAudio(ref AkBasePlatformSettings activePlatformSettings); // 0x0000000184008240-0x00000001840082D0
	private static void _TryInitCommunication(ref AkBasePlatformSettings activePlatformSettings); // 0x00000001841E1670-0x00000001841E1680
	public static void TerminateSoundEngine(bool hgDeepTerm = false /* Metadata: 0x02349311 */); // 0x00000001853CEBE4-0x00000001853CECE4
	private static void _WaitCallbacks(int retry); // 0x00000001853CECE4-0x00000001853CED44
}

public class AkUtilities // TypeDefIndex: 56729
{
	// Nested types
	public class ShortIDGenerator // TypeDefIndex: 56728
	{
		// Fields
		private const uint s_prime32 = 16777619; // Metadata: 0x02349312
		private const uint s_offsetBasis32 = 2166136261; // Metadata: 0x02349316
		private static byte s_hashSize; // 0x00
		private static uint s_mask; // 0x04

		// Properties
		public static byte HashSize { get; set; } // 0x00000001853DF100-0x00000001853DF150 0x00000001853DF150-0x00000001853DF1B8

		// Constructors
		static ShortIDGenerator(); // 0x00000001853DF0F4-0x00000001853DF100
		public ShortIDGenerator(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		public static uint Compute(string in_name); // 0x00000001853DEFFC-0x00000001853DF0F4
	}

	// Constructors
	public AkUtilities(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash); // 0x00000001853DDD40-0x00000001853DDE6C
	public static void FixSlashes(ref string path); // 0x00000001853DDCD4-0x00000001853DDD40
	public static string GetPathInPackage(string relativePath); // 0x00000001853DDE6C-0x00000001853DE14C
}

public struct AkVector64 // TypeDefIndex: 56730
{
	// Fields
	public double X; // 0x00
	public double Y; // 0x08
	public double Z; // 0x10

	// Methods
	public void Zero(); // 0x0000000184D85AD0-0x0000000184D85AE0
	public static implicit operator AkVector64(Vector3 vector); // 0x0000000183B8B4B0-0x0000000183B8B4E0
}

public class AkWwiseInitializationSettings : AkCommonPlatformSettings // TypeDefIndex: 56733
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
	public bool IsValid { get; } // 0x000000018400ACB0-0x000000018400AD10 
	public int Count { get; } // 0x0000000184009570-0x00000001840095B0 
	public static AkWwiseInitializationSettings Instance { get; set; } // 0x00000001840095B0-0x00000001840096B0 0x00000001853DE14C-0x00000001853DE1AC
	public static AkBasePlatformSettings ActivePlatformSettings { get; } // 0x00000001840088B0-0x0000000184008A30 

	// Nested types
	public abstract class PlatformSettings : AkCommonPlatformSettings // TypeDefIndex: 56731
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
		public HashSet<string> GlobalPropertyHashSet { get; set; } // 0x00000001853DEF68-0x00000001853DEFFC 0x0000000182FDB880-0x0000000182FDB890

		// Constructors
		protected PlatformSettings(); // 0x0000000184166250-0x0000000184166350

		// Methods
		public void IgnorePropertyValue(string propertyPath); // 0x0000000184165FE0-0x0000000184166060
		public bool IsPropertyIgnored(string propertyPath); // 0x0000000184166060-0x00000001841660C0
		public void SetUseGlobalPropertyValue(string propertyPath, bool use); // 0x0000000184166350-0x00000001841663F0
		public void SetGlobalPropertyValues(IEnumerable enumerable); // 0x00000001841663F0-0x0000000184166580
		private bool IsUsingGlobalPropertyValue(string propertyPath); // 0x0000000184166580-0x00000001841665B0
	}

	public class CommonPlatformSettings : PlatformSettings // TypeDefIndex: 56732
	{
		// Fields
		public AkCommonUserSettings UserSettings; // 0x30
		public AkCommonAdvancedSettings AdvancedSettings; // 0x38
		public AkCommonCommSettings CommsSettings; // 0x40

		// Constructors
		public CommonPlatformSettings(); // 0x0000000184165BC0-0x0000000184165BD0

		// Methods
		protected override AkCommonUserSettings GetUserSettings(); // 0x00000001811F36E0-0x00000001811F36F0
		protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000184D85A50-0x0000000184D85A60
		protected override AkCommonCommSettings GetCommsSettings(); // 0x0000000184D85A60-0x0000000184D85A70
	}

	// Constructors
	public AkWwiseInitializationSettings(); // 0x0000000184165BD0-0x0000000184165DB0
	static AkWwiseInitializationSettings(); // 0x0000000184643F30-0x0000000184644680

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001811F36E0-0x00000001811F36F0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000184D85A50-0x0000000184D85A60
	protected override AkCommonCommSettings GetCommsSettings(); // 0x0000000184D85A60-0x0000000184D85A70
	private static AkBasePlatformSettings GetPlatformSettings(string platformName); // 0x0000000184009410-0x0000000184009570
	private void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
}

public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface> // TypeDefIndex: 56734
{
	// Properties
	protected override int StructureSize { get; } // 0x00000001853CB414-0x00000001853CB454 

	// Constructors
	public AkAcousticSurfaceArray(int count); // 0x00000001853CB3CC-0x00000001853CB414

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x00000001853CB380-0x00000001853CB3CC
	protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001853CB334-0x00000001853CB380
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other); // 0x00000001853CB2D0-0x00000001853CB334
}

public class AkAuxSendArray : IDisposable // TypeDefIndex: 56735
{
	// Fields
	private const int MAX_COUNT = 4; // Metadata: 0x0234931B
	private readonly int SIZE_OF_AKAUXSENDVALUE; // 0x10
	private IntPtr m_Buffer; // 0x18
	private int m_Count; // 0x20

	// Properties
	public AkAuxSendValue this[int index] { get => default; } // 0x00000001853CC1A8-0x00000001853CC268 
	public bool isFull { get; } // 0x00000001853CC268-0x00000001853CC27C 

	// Constructors
	public AkAuxSendArray(); // 0x00000001853CC12C-0x00000001853CC1A8

	// Methods
	public void Dispose(); // 0x00000001853CBF74-0x00000001853CBFD4
	~AkAuxSendArray(); // 0x00000001853CBFD4-0x00000001853CC044
	public void Reset(); // 0x0000000184D85A70-0x0000000184D85A80
	public bool Add(ulong in_listenerGameObj, uint in_AuxBusID, float in_fValue); // 0x00000001853CBCE4-0x00000001853CBD94
	public bool Add(uint in_AuxBusID, float in_fValue); // 0x00000001853CBD94-0x00000001853CBE34
	public bool Contains(ulong in_listenerGameObj, uint in_AuxBusID); // 0x00000001853CBE34-0x00000001853CBED4
	public bool Contains(uint in_AuxBusID); // 0x00000001853CBED4-0x00000001853CBF74
	public AKRESULT SetValues(ulong gameObject); // 0x00000001853CC0B8-0x00000001853CC11C
	public AKRESULT GetValues(ulong gameObject); // 0x00000001853CC044-0x00000001853CC0B8
	public IntPtr GetBuffer(); // 0x000000018385B100-0x000000018385B110
	public int Count(); // 0x0000000182B70F90-0x0000000182B70FA0
	private IntPtr _GetObjectPtr(int index); // 0x00000001853CC11C-0x00000001853CC12C
}

public abstract class AkBaseArray<T> : IDisposable // TypeDefIndex: 56736
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

public class AkChannelEmitterArray : IDisposable // TypeDefIndex: 56737
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20
	[CompilerGenerated]
	private uint _Count_k__BackingField; // 0x24

	// Properties
	public uint Count { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040

	// Constructors
	public AkChannelEmitterArray(uint in_Count); // 0x00000001853CDA4C-0x00000001853CDAA8

	// Methods
	public void Dispose(); // 0x00000001853CD97C-0x00000001853CD9DC
	~AkChannelEmitterArray(); // 0x00000001853CD9DC-0x00000001853CDA4C
	public void Reset(); // 0x0000000184D85A80-0x0000000184D85A90
	public void Add(AkVector64 in_Pos, Vector3 in_Forward, Vector3 in_Top, uint in_ChannelMask); // 0x00000001853CD698-0x00000001853CD97C
}

public class AkDeviceDescriptionArray : AkBaseArray<AkDeviceDescription> // TypeDefIndex: 56738
{
	// Properties
	protected override int StructureSize { get; } // 0x0000000184527DD0-0x0000000184527E00 

	// Constructors
	public AkDeviceDescriptionArray(int count); // 0x0000000184009390-0x00000001840093E0

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x00000001845F5060-0x00000001845F50B0
	protected override AkDeviceDescription CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001846939D0-0x0000000184693A20
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDeviceDescription other); // 0x00000001853CDC7C-0x00000001853CDCE0
}

public class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo> // TypeDefIndex: 56739
{
	// Properties
	protected override int StructureSize { get; } // 0x00000001853CDDD8-0x00000001853CDE18 

	// Constructors
	public AkDiffractionPathInfoArray(int count); // 0x00000001853CDD90-0x00000001853CDDD8

	// Methods
	protected override AkDiffractionPathInfo CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001853CDD44-0x00000001853CDD90
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDiffractionPathInfo other); // 0x00000001853CDCE0-0x00000001853CDD44
}

public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo> // TypeDefIndex: 56740
{
	// Properties
	protected override int StructureSize { get; } // 0x000000018463BF70-0x000000018463BFA0 

	// Constructors
	public AkExternalSourceInfoArray(int count); // 0x0000000184771EB0-0x0000000184771F00

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x0000000184CC8A40-0x0000000184CC8A90
	protected override void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address); // 0x00000001853CDE7C-0x00000001853CDEC8
	protected override AkExternalSourceInfo CreateNewReferenceFromIntPtr(IntPtr address); // 0x0000000184658860-0x0000000184658890
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other); // 0x00000001853CDE18-0x00000001853CDE7C
}

public class AkMIDIPostArray // TypeDefIndex: 56741
{
	// Fields
	private readonly int m_Count; // 0x10
	private readonly int SIZE_OF; // 0x14
	private IntPtr m_Buffer; // 0x18

	// Properties
	public AkMIDIPost this[int index] { get => default; set {} } // 0x00000001853CE604-0x00000001853CE6D0 0x00000001853CE6D0-0x00000001853CE7A4

	// Constructors
	public AkMIDIPostArray(int size); // 0x00000001853CE57C-0x00000001853CE604

	// Methods
	~AkMIDIPostArray(); // 0x00000001853CE328-0x00000001853CE3D8
	public void PostOnEvent(uint in_eventID, GameObject gameObject); // 0x00000001853CE3E8-0x00000001853CE484
	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count); // 0x00000001853CE484-0x00000001853CE57C
	public IntPtr GetBuffer(); // 0x000000018385B100-0x000000018385B110
	public int Count(); // 0x0000000182B2E2D0-0x0000000182B2E2E0
	private IntPtr GetObjectPtr(int index); // 0x00000001853CE3D8-0x00000001853CE3E8
}

public class AkObjectInfoArray : AkBaseArray<AkObjectInfo> // TypeDefIndex: 56742
{
	// Properties
	protected override int StructureSize { get; } // 0x00000001853CE8E8-0x00000001853CE928 

	// Constructors
	public AkObjectInfoArray(int count); // 0x00000001853CE8A0-0x00000001853CE8E8

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x00000001853CE854-0x00000001853CE8A0
	protected override AkObjectInfo CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001853CE808-0x00000001853CE854
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObjectInfo other); // 0x00000001853CE7A4-0x00000001853CE808
}

public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues> // TypeDefIndex: 56743
{
	// Properties
	protected override int StructureSize { get; } // 0x00000001853CEA6C-0x00000001853CEAAC 

	// Constructors
	public AkObstructionOcclusionValuesArray(int count); // 0x00000001853CEA24-0x00000001853CEA6C

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x00000001853CE9D8-0x00000001853CEA24
	protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001853CE98C-0x00000001853CE9D8
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other); // 0x00000001853CE928-0x00000001853CE98C
}

public class AkPositionArray : IDisposable // TypeDefIndex: 56744
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20
	[CompilerGenerated]
	private uint _Count_k__BackingField; // 0x24

	// Properties
	public uint Count { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040

	// Constructors
	public AkPositionArray(uint in_Count); // 0x00000001835AB5A0-0x00000001835AB610

	// Methods
	public void Dispose(); // 0x0000000184416C70-0x0000000184416CE0
	~AkPositionArray(); // 0x0000000184416BE0-0x0000000184416C20
	public void Reset(); // 0x0000000184D85A80-0x0000000184D85A90
	public void Add(AkVector64 in_Pos, Vector3 in_Forward, Vector3 in_Top); // 0x0000000183B8B4E0-0x0000000183B8B550
}

public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo> // TypeDefIndex: 56745
{
	// Properties
	protected override int StructureSize { get; } // 0x00000001853CEBA4-0x00000001853CEBE4 

	// Constructors
	public AkReflectionPathInfoArray(int count); // 0x00000001853CEB5C-0x00000001853CEBA4

	// Methods
	protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001853CEB10-0x00000001853CEB5C
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other); // 0x00000001853CEAAC-0x00000001853CEB10
}

public class AkSourceSettingsArray : AkBaseArray<AkSourceSettings> // TypeDefIndex: 56746
{
	// Properties
	protected override int StructureSize { get; } // 0x00000001853DD65C-0x00000001853DD69C 

	// Constructors
	public AkSourceSettingsArray(int count); // 0x00000001853DD614-0x00000001853DD65C

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x00000001853DD5C8-0x00000001853DD614
	protected override AkSourceSettings CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001853DD57C-0x00000001853DD5C8
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkSourceSettings other); // 0x00000001853DD518-0x00000001853DD57C
}

public class AkTriangleArray : AkBaseArray<AkTriangle> // TypeDefIndex: 56747
{
	// Properties
	protected override int StructureSize { get; } // 0x00000001853DDC1C-0x00000001853DDC5C 

	// Constructors
	public AkTriangleArray(int count); // 0x00000001853DDBD4-0x00000001853DDC1C

	// Methods
	protected override void DefaultConstructAtIntPtr(IntPtr address); // 0x00000001853DDB88-0x00000001853DDBD4
	protected override AkTriangle CreateNewReferenceFromIntPtr(IntPtr address); // 0x00000001853DDB3C-0x00000001853DDB88
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkTriangle other); // 0x00000001853DDAD8-0x00000001853DDB3C
}

public static class AudioNativeHelper // TypeDefIndex: 56750
{
	// Fields
	private static IntPtr s_reusedTransformPtr; // 0x00

	// Nested types
	public struct AudioTriangleArrayNoGc : IDisposable // TypeDefIndex: 56748
	{
		// Fields
		private IntPtr m_buffer; // 0x00
		private int m_capacity; // 0x08
		private int m_elementSize; // 0x0C

		// Properties
		internal IntPtr Buffer { get; } // 0x0000000182B76770-0x0000000182B76780 

		// Constructors
		public AudioTriangleArrayNoGc(int capacity); // 0x00000001835AB920-0x00000001835ABA10

		// Methods
		public void Set(int idx, ushort p0, ushort p1, ushort p2, ushort surface); // 0x000000018352A250-0x000000018352A350
		public void Dispose(); // 0x00000001835AC120-0x00000001835AC170
	}

	public struct AudioAcousticSurfaceArrayNoGc : IDisposable // TypeDefIndex: 56749
	{
		// Fields
		private IntPtr m_buffer; // 0x00
		private int m_capacity; // 0x08
		private int m_elementSize; // 0x0C

		// Properties
		internal IntPtr Buffer { get; } // 0x0000000182B76770-0x0000000182B76780 

		// Constructors
		public AudioAcousticSurfaceArrayNoGc(int capacity); // 0x00000001835ABA50-0x00000001835ABB10

		// Methods
		public void Set(int idx, float transmissionLoss, uint textureId); // 0x00000001843ED750-0x00000001843ED7C0
		public void Dispose(); // 0x00000001835AC120-0x00000001835AC170
	}

	// Constructors
	static AudioNativeHelper(); // 0x0000000184D7AD10-0x0000000184D7AD50

	// Methods
	internal static void Init(); // 0x0000000184CAD760-0x0000000184CAD7E0
	internal static void Term(); // 0x00000001853DE570-0x00000001853DE5D8
	public static AKRESULT SetRoomPortal(ulong portalID, ulong frontRoom, ulong backRoom, Vector3 position, Vector3 orientationFront, Vector3 orientationTop, Vector3 extent, bool enabled, string portalName = "" /* Metadata: 0x0234931C */); // 0x0000000183CE0200-0x0000000183CE03E0
	public static AKRESULT SetGeometry(ulong geoId, AudioTriangleArrayNoGc triangles, uint numTriangles, Vector3[] vertices, uint numVertices, AudioAcousticSurfaceArrayNoGc surfaces, uint numSurfaces, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges); // 0x000000018437F440-0x000000018437F4F0
	public static AKRESULT SetGeometryInstance(ulong geomInstanceID, Vector3 pos, Quaternion rot, Vector3 scale, ulong geometrySetID, ulong roomID, bool useForReflectionAndDiffraction); // 0x0000000183CDECB0-0x0000000183CDEEC0
}

public class AkiOSSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 56755
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 56754
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
		public enum Category // TypeDefIndex: 56751
		{
			Ambient = 0,
			SoloAmbient = 1,
			PlayAndRecord = 2,
			Playback = 3
		}

		public enum CategoryOptions // TypeDefIndex: 56752
		{
			MixWithOthers = 1,
			DuckOthers = 2,
			AllowBluetooth = 4,
			DefaultToSpeaker = 8
		}

		public enum Mode // TypeDefIndex: 56753
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
		public PlatformAdvancedSettings(); // 0x0000000184D61080-0x0000000184D610D0

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x00000001841E1670-0x00000001841E1680
	}

	// Constructors
	public AkiOSSettings(); // 0x00000001841660C0-0x0000000184166250

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001811F36E0-0x00000001811F36F0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000184D85A50-0x0000000184D85A60
	protected override AkCommonCommSettings GetCommsSettings(); // 0x0000000184D85A60-0x0000000184D85A70
}

public class AkMacSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 56757
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 56756
	{
		// Fields
		[Tooltip("Number of Apple Spatial Audio point sources to allocate for 3D audio use (each point source is a system audio object).")]
		public uint NumSpatialAudioPointSources; // 0x50
		[Tooltip("Print debug information related to audio device initialization in the system log.")]
		public bool VerboseSystemOutput; // 0x54

		// Constructors
		public PlatformAdvancedSettings(); // 0x0000000184D85AE0-0x0000000184D85B20

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x00000001841E1670-0x00000001841E1680
	}

	// Constructors
	public AkMacSettings(); // 0x0000000184165BC0-0x0000000184165BD0

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001811F36E0-0x00000001811F36F0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000184D85A50-0x0000000184D85A60
	protected override AkCommonCommSettings GetCommsSettings(); // 0x0000000184D85A60-0x0000000184D85A70
}

public class AkPS5Settings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 56759
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 56758
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
		public PlatformAdvancedSettings(); // 0x00000001841665B0-0x0000000184166610

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x00000001841E1670-0x00000001841E1680
	}

	// Constructors
	public AkPS5Settings(); // 0x0000000184165DB0-0x0000000184165E80

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001811F36E0-0x00000001811F36F0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000184D85A50-0x0000000184D85A60
	protected override AkCommonCommSettings GetCommsSettings(); // 0x0000000184D85A60-0x0000000184D85A70
}

public class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 56761
{
	// Fields
	public AkCommonUserSettings UserSettings; // 0x30
	public PlatformAdvancedSettings AdvancedSettings; // 0x38
	public AkCommonCommSettings CommsSettings; // 0x40

	// Nested types
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 56760
	{
		// Fields
		[Tooltip("Maximum number of System Audio Objects to reserve. Other processes will not be able to use them. Default is 128.")]
		public uint MaxSystemAudioObjects; // 0x50

		// Constructors
		public PlatformAdvancedSettings(); // 0x0000000184D85AE0-0x0000000184D85B20

		// Methods
		public override void CopyTo(AkPlatformInitSettings settings); // 0x0000000184CCB160-0x0000000184CCB190
	}

	// Constructors
	public AkWindowsSettings(); // 0x0000000184165BC0-0x0000000184165BD0

	// Methods
	protected override AkCommonUserSettings GetUserSettings(); // 0x00000001811F36E0-0x00000001811F36F0
	protected override AkCommonAdvancedSettings GetAdvancedSettings(); // 0x0000000184D85A50-0x0000000184D85A60
	protected override AkCommonCommSettings GetCommsSettings(); // 0x0000000184D85A60-0x0000000184D85A70
}

