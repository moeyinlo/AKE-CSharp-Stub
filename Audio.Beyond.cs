/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.Audio;
using Beyond.PoolCore;
using Beyond.VFS;
using IFix.Core;
using Newtonsoft.Json;
using Unity.Profiling;
using UnityEngine;

// Image 60: Audio.Beyond.dll - Assembly: Audio.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57964-58046
[assembly: CompilationRelaxations(8)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Audio
{
	public static class AudioAdapter // TypeDefIndex: 57979
	{
		// Fields
		private static readonly AkCallbackManager.BankCallback ON_EVENT_PREPARED_DO_POST_EVENT; // 0x00
		private static readonly AkCallbackManager.EventCallback ON_EVENT_CALLBACK; // 0x08
		private static readonly AkCallbackManager.EventCallback ON_EXTERNAL_SOURCE_EVENT_CALLBACK; // 0x10
	
		// Properties
		public static ulong listenerObjId { get; } // 0x0000000185149C38-0x0000000185149C88 
	
		// Nested types
		private static class Context // TypeDefIndex: 57972
		{
			// Fields
			public static ulong s_listenerObjId; // 0x00
			public static ulong s_2dEmitterObjectId; // 0x08
			public static uint s_playingIdInternal; // 0x10
			public static Dictionary<uint, uint> s_playingIdLut; // 0x18
			public static ObjectPool<PayloadPostEvent> s_payloadPool; // 0x20
			public static readonly AkExternalSourceInfoArray S_EXTERNAL_SOURCE_INFO_ARRAY; // 0x28
			public static AkRoomParams s_reusableAkRoomParams; // 0x30
	
			// Constructors
			static Context() {} // 0x0000000183827DD0-0x0000000183827EC0
	
			// Methods
			public static void PostSoundEngineInit() {} // 0x0000000183B0E5B0-0x0000000183B0E670
			public static void Reset() {} // 0x00000001833B6CA0-0x00000001833B6F20
		}
	
		private class PayloadPostEvent // TypeDefIndex: 57973
		{
			// Fields
			public ulong audioObjectId; // 0x10
			public uint callbackType; // 0x18
			public uint internalPlayingId; // 0x1C
			public AudioEventCallback callback; // 0x20
			public object cookie; // 0x28
	
			// Constructors
			public PayloadPostEvent() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public static void OnRecycle(PayloadPostEvent obj) {} // 0x000000018269EBE0-0x000000018269EC30
		}
	
		public static class Device // TypeDefIndex: 57974
		{
			// Methods
			public static bool GetSpeakerConfiguration(out AudioChannelMask channelMask, out uint numChannels, out AudioChannelConfigType configType) {
				channelMask = default;
				numChannels = default;
				configType = default;
				return default;
			} // 0x00000001826900B0-0x0000000182690190
			public static bool AddOutputDevice(string deviceName, uint deviceId, uint numChannels, uint speakerSetup, out ulong outDeviceId) {
				outDeviceId = default;
				return default;
			} // 0x000000018514C8D8-0x000000018514CA34
			public static bool AddOutput(string shareSetName, uint deviceId, out ulong outId) {
				outId = default;
				return default;
			} // 0x000000018514CA34-0x000000018514CB14
			public static ulong GetOutputDeviceId(string shareSetName, uint deviceId) => default; // 0x000000018514CB8C-0x000000018514CC18
			public static bool RemoveOutputDevice(ulong output) => default; // 0x000000018514CC18-0x000000018514CCB8
			public static bool Switch3DOutput(bool use3DDevice) => default; // 0x0000000183617DD0-0x0000000183617F70
			public static void SetOutputDeviceEffect(ulong outputDeviceId, uint effectIdx, uint shareSetId) {} // 0x000000018514CCB8-0x000000018514CD58
			public static uint GetMmDeviceIdFromScePadHandle(int scePadHandle) => default; // 0x000000018514CB14-0x000000018514CB8C
		}
	
		// Constructors
		static AudioAdapter() {} // 0x0000000183593510-0x0000000183593670
	
		// Methods
		public static uint PostEvent(string eventName) => default; // 0x0000000183584F00-0x0000000183584FC0
		public static uint PostEvent(uint eventId) => default; // 0x0000000185147900-0x0000000185147988
		public static uint PostEvent(string eventName, ulong audioObjectId) => default; // 0x0000000185147AD4-0x0000000185147B4C
		public static uint PostEvent(uint eventId, ulong audioObjectId) => default; // 0x0000000185147B4C-0x0000000185147BAC
		public static uint PostEvent(string eventName, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null) => default; // 0x0000000185147BAC-0x0000000185147C68
		public static uint PostEvent(uint eventId, [IsReadOnly] in AudioCallbackType callbackType, [IsReadOnly] in AudioEventCallback callback, object cookie = null) => default; // 0x0000000185147A20-0x0000000185147AD4
		public static uint PostEvent(string eventName, ulong audioObjectId, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null) => default; // 0x0000000185147988-0x0000000185147A20
		public static uint PostEvent(uint eventId, ulong audioObjectId, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null) => default; // 0x0000000185147884-0x0000000185147900
		[IDTag(0)]
		public static uint PostEventExternal(string eventName, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x01FDA753 */) => default; // 0x0000000182950090-0x0000000182950250
		[IDTag(1)]
		public static uint PostEventExternal(uint eventId, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x01FDA754 */) => default; // 0x0000000185147744-0x0000000185147884
		public static void StopByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x01FDA755 */) {} // 0x0000000185149014-0x0000000185149064
		public static void PauseByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x01FDA757 */) {} // 0x00000001851476A8-0x00000001851476FC
		public static void ResumeByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x01FDA759 */) {} // 0x0000000185148160-0x00000001851481B4
		public static void PinEvent(uint eventId) {} // 0x00000001851476FC-0x0000000185147744
		public static void UnpinEvent(uint eventId) {} // 0x00000001851492BC-0x0000000185149308
		public static void UnpinEvent(string eventName) {} // 0x0000000185149308-0x0000000185149368
		[IDTag(0)]
		public static void LoadAndPinEventsSync(IList<uint> events) {} // 0x000000018514757C-0x00000001851475F4
		[IDTag(1)]
		public static void LoadAndPinEventsSync(ICollection<string> events) {} // 0x0000000185147348-0x000000018514757C
		[IDTag(0)]
		public static void LoadAndPinEventsAsync(IList<uint> events, Action<object> onDone = null, object payload = null) {} // 0x00000001829524A0-0x0000000182952520
		[IDTag(1)]
		public static void LoadAndPinEventsAsync(IList<AudioId> events, Action<object> onDone = null, object payload = null) {} // 0x0000000182952520-0x0000000182952720
		[IDTag(2)]
		public static void LoadAndPinEventsAsync(ICollection<string> events, Action<object> onDone = null, object payload = null) {} // 0x0000000185146FD8-0x0000000185147240
		[IDTag(0)]
		public static IEnumerator LoadAndPinEventsCoroutine(IList<uint> events) => default; // 0x00000001851472CC-0x0000000185147348
		[IDTag(1)]
		[IteratorStateMachine(typeof(_LoadAndPinEventsCoroutine_d__26))]
		public static IEnumerator LoadAndPinEventsCoroutine(ICollection<string> events) => default; // 0x0000000185147240-0x00000001851472CC
		public static void SetState(string stateGroup, string stateName) {} // 0x0000000185148D98-0x0000000185148DF4
		public static void SetState(uint stateGroup, uint stateName) {} // 0x0000000185148D40-0x0000000185148D98
		public static bool TryGetState(uint stateGroupId, out uint stateId) {
			stateId = default;
			return default;
		} // 0x0000000185149264-0x00000001851492BC
		[IDTag(0)]
		public static void SetSwitch(uint switchGroup, uint switchValue, ulong audioObjectId) {} // 0x0000000185148DF4-0x0000000185148E94
		[IDTag(1)]
		public static void SetSwitch(string switchGroup, string switchValue, ulong audioObjectId) {} // 0x0000000185148E94-0x0000000185148F48
		[IDTag(1)]
		public static void SetRtpc(string rtpcName, float rtpcValue, ulong audioObjectId) {} // 0x0000000183235D90-0x0000000183235E20
		[IDTag(0)]
		public static void SetRtpc(uint rtpcId, float rtpcValue, ulong audioObjectId) {} // 0x0000000182830AE0-0x0000000182830B70
		[IDTag(2)]
		public static void SetRtpc(uint rtpcId, float rtpcValue, ulong audioObjectId, int fadeTimeMs) {} // 0x0000000185148C30-0x0000000185148CE4
		public static void SetRtpcValueByPlayingID(uint rtpcId, float rtpcValue, uint playingId, int fadeTimeMs) {} // 0x0000000182A35FD0-0x0000000182A36110
		[IDTag(0)]
		public static void ResetRtpc(uint rtpcId, ulong audioObjectId, int fadeTimeMs) {} // 0x000000018514801C-0x00000001851480B8
		[IDTag(1)]
		public static void ResetRtpc(string rtpcName, ulong audioObjectId, int fadeTimeMs = 100 /* Metadata: 0x01FDA75B */) {} // 0x00000001851480B8-0x0000000185148160
		public static bool GetRtpcValue(string rtpcName, ulong audioObjectId, uint playingId, out float value, ref int valueType) {
			value = default;
			return default;
		} // 0x0000000185146DC0-0x0000000185146EAC
		public static bool GetRtpcValue(uint rtpcId, ulong audioObjectId, uint playingId, out float value, ref int valueType) {
			value = default;
			return default;
		} // 0x0000000185146EAC-0x0000000185146F98
		[IDTag(1)]
		public static void SeekOnEvent(string eventName, ulong audioObjectId, int timeMs, bool toNearestMarker, uint playingId) {} // 0x00000001851484F4-0x00000001851485C4
		[IDTag(0)]
		public static void SeekOnEvent(uint eventId, ulong audioObjectId, int timeMs, bool toNearestMarker, uint playingId) {} // 0x00000001851482A4-0x0000000185148404
		[IDTag(2)]
		public static void SeekOnEvent(string eventName, int timeMs, bool toNearestMarker, uint playingId) {} // 0x00000001851481B4-0x00000001851482A4
		[IDTag(3)]
		public static void SeekOnEvent(uint eventId, int timeMs, bool toNearestMarker, uint playingId) {} // 0x0000000185148404-0x00000001851484F4
		public static bool TryGetPlayingPosition(uint playingId, out int posTimeMs, bool extrapolate = true /* Metadata: 0x01FDA75D */) {
			posTimeMs = default;
			return default;
		} // 0x0000000185149164-0x0000000185149264
		public static bool IsPlaying(uint playingId) => default; // 0x0000000182A9EED0-0x0000000182A9EFC0
		public static uint SetScalingFactor(ulong audioObjectId, float factor) => default; // 0x0000000185148CE4-0x0000000185148D40
		public static bool RegisterGameObject(ulong audioObjectId) => default; // 0x0000000185147CC0-0x0000000185147D08
		public static bool RegisterGameObject(ulong audioObjectId, string name) => default; // 0x0000000185147C68-0x0000000185147CC0
		public static bool UnregisterGameObject(ulong audioObjectId) => default; // 0x0000000185149368-0x00000001851493B0
		public static void SetPosition(ulong audioObjectId, Vector3 pos, Vector3 forward, Vector3 up) {} // 0x0000000185148B10-0x0000000185148BC0
		public static void StopAll() {} // 0x0000000185148FD4-0x0000000185149014
		public static void StopAllOnObject(ulong audioObjectId) {} // 0x0000000185148F88-0x0000000185148FD4
		public static void ReleaseAllCachedEventsSync() {} // 0x00000001838A5160-0x00000001838A51C0
		public static void SetLargePositions(ulong audioObjectId, AudioPositionArrayProxy positions, AudioLargeType type = AudioLargeType.Sum /* Metadata: 0x01FDA75E */) {} // 0x00000001832878F0-0x00000001832879C0
		public static void SetDefaultListener(ulong audioObjectId) {} // 0x00000001826BCF30-0x00000001826BD040
		public static void SetListener(ulong audioObjectId, ulong listenerId) {} // 0x00000001851486CC-0x0000000185148798
		public static bool TryGetRealPlayingId(uint playingId, out uint realPlayingId) {
			realPlayingId = default;
			return default;
		} // 0x0000000182A9DDB0-0x0000000182A9DE50
		public static void SetDefaultEmitter(ulong audioObjectId) {} // 0x00000001831592E0-0x0000000183159350
		public static void SetAudioLanguage(string language) {} // 0x0000000182951C90-0x0000000182951D00
		public static void SetDistanceProbe(ulong probeObjectId = 18446744073709551615 /* Metadata: 0x01FDA75F */) {} // 0x0000000185148620-0x00000001851486CC
		public static uint ComputeIdFromString(string name) => default; // 0x0000000185146CB0-0x0000000185146CD0
		public static void SetAudioEngineInitSetting(AudioEngineInitSetting settings) {} // 0x0000000182951C20-0x0000000182951C90
		public static void UnsetAudioEngineInitSetting() {} // 0x00000001851493B0-0x0000000185149418
		public static bool InitWwise() => default; // 0x0000000182951BB0-0x0000000182951C20
		public static void TermWwise(bool hgDeepTerm = false /* Metadata: 0x01FDA767 */) {} // 0x00000001851490F0-0x0000000185149164
		public static void LoadInitResources() {} // 0x0000000182951EA0-0x0000000182951F10
		public static void ReloadInitResources() {} // 0x0000000185147D08-0x0000000185147E14
		public static void RenderAudio() {} // 0x0000000185147FA4-0x000000018514801C
		public static void Suspend(bool renderAnyway) {} // 0x00000001851490A4-0x00000001851490F0
		public static void WakeupFromSuspend() {} // 0x0000000185149418-0x0000000185149458
		public static void InitScePad() {} // 0x0000000185146F98-0x0000000185146FD8
		public static void SetAudioMemoryBudget(ulong inMemoryBytes, ushort inGcCount = 10 /* Metadata: 0x01FDA768 */) {} // 0x00000001851485C4-0x0000000185148620
		[Conditional("ENABLE_PROFILER")]
		public static void LogToWwise(string msg, bool isError = false /* Metadata: 0x01FDA76A */, uint playingId = 0 /* Metadata: 0x01FDA76B */, ulong goId = 0 /* Metadata: 0x01FDA76C */) {} // 0x00000001851475F4-0x0000000185147668
		public static void MemoryShrink() {} // 0x0000000185147668-0x00000001851476A8
		private static bool _InitInternal() => default; // 0x000000018268FF20-0x00000001826900B0
		private static void _ReleaseInternal(bool hgDeepTerm = false /* Metadata: 0x01FDA774 */) {} // 0x0000000185149924-0x0000000185149BB8
		private static void _OnBeforeTerminate() {} // 0x0000000185149898-0x0000000185149924
		private static void _ResetStaticFields() {} // 0x00000001833B60C0-0x00000001833B6150
		private static void _OnEventPreparedDoPostEvent(uint inId, IntPtr _, AKRESULT __, object inCookie) {} // 0x000000018269DFC0-0x000000018269E1D0
		private static void _OnEventCallback(object inCookie, AkCallbackType inType, AkCallbackInfo inInfo) {} // 0x000000018269EE00-0x000000018269F6C0
		private static void _OnExternalSourceEventCallback(object inCookie, AkCallbackType inType, AkCallbackInfo inInfo) {} // 0x00000001826A0360-0x00000001826A0510
		private static uint _PostEvent(uint eventId, ulong audioObjectId, AudioCallbackType callbackType = AudioCallbackType.None /* Metadata: 0x01FDA775 */, AudioEventCallback originCallback = null, object originCookie = null) => default; // 0x000000018269DDC0-0x000000018269DFC0
		private static uint _PostEventWithExternalSource(uint eventId, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x01FDA776 */) => default; // 0x0000000182950250-0x0000000182950580
		private static void _ExecuteActionOnPlayingId(AkActionOnEventType type, uint playingId, int durationMs = 100 /* Metadata: 0x01FDA777 */) {} // 0x0000000182A9DE50-0x0000000182A9E000
		private static uint _GetInternalPlayingId() => default; // 0x0000000185149760-0x00000001851497B8
		private static void _LoadAndPinEventsAsync([IsReadOnly] in IList<uint> events, [IsReadOnly] in Action<object> onDone = null, [IsReadOnly] in object payload = null) {} // 0x00000001851497B8-0x0000000185149898
		private static void _DoLoadAndPinEventsSync(IList<uint> events) {} // 0x0000000185149458-0x0000000185149760
		[IteratorStateMachine(typeof(__DoLoadAndPinEventsAsync_d__92))]
		private static IEnumerator _DoLoadAndPinEventsAsync(IList<uint> events, Action<object> onDone = null, object payload = null) => default; // 0x0000000182952720-0x00000001829527D0
		private static void _InitAndroidActivityEnvironment() {} // 0x0000000183D4C3E0-0x0000000183D4C400
		[Conditional("ENABLE_PROFILER")]
		internal static void SetUprSamplingEnabled(bool isEnabled) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("ENABLE_PROFILER")]
		private static void _ProfilerUpdate() {} // 0x000000018350B670-0x000000018350B680
		[Conditional("ENABLE_PROFILER")]
		private static void _SampleAllData() {} // 0x0000000185149BB8-0x0000000185149BF8
		[Conditional("ENABLE_PROFILER")]
		private static void _SampleMemoryOnly() {} // 0x0000000185149BF8-0x0000000185149C38
		[Conditional("ENABLE_PROFILER")]
		public static void StartProfileCapture(string fileName = null) {} // 0x0000000185148F48-0x0000000185148F88
		[Conditional("ENABLE_PROFILER")]
		public static void StopProfileCapture() {} // 0x0000000185149064-0x00000001851490A4
		public static AkResourceMonitorDataSummary GetResourceSummaryData() => default; // 0x0000000185146D84-0x0000000185146DC0
		public static AudioMemoryMonitor.FGlobalMemoryStats GetGlobalMemoryStats() => default; // 0x0000000185146D30-0x0000000185146D84
		public static AudioMemoryMonitor.FExtraMemoryStats GetExtraMemoryStats() => default; // 0x0000000185146CD0-0x0000000185146D30
		public static void SetEnableSpatialAudio(bool enable) {} // 0x0000000182A02330-0x0000000182A02430
		public static void SetObjectObstructionAndOcclusion(ulong audioObjectId, float obstructionLevel, float occlusionLevel) {} // 0x0000000185148798-0x0000000185148860
		public static bool SetGeometry(ulong geoId, Vector3[] vertices, ushort[] triangles, AudioAcousticSurfaceData[] surfaceData, ushort[] surfaceIdx, bool enableDiffraction = true /* Metadata: 0x01FDA779 */, bool enableEdgeDiffraction = false /* Metadata: 0x01FDA77A */) => default; // 0x00000001826D7180-0x00000001826D7470
		public static bool SetGeometryInstance(ulong instanceId, Vector3 pos, Vector3 scale, Quaternion rot, ulong geoId, bool useReflectionAndDiffraction = false /* Metadata: 0x01FDA77B */) => default; // 0x00000001831AD8A0-0x00000001831AD9E0
		public static bool SetRoom(ulong roomId, AudioRoomData roomData, ulong geoInstanceId, string roomName = "room" /* Metadata: 0x01FDA77C */) => default; // 0x00000001831ACC20-0x00000001831ACEE0
		public static bool SetPortal(ulong portalId, ulong roomIdA, ulong roomIdB, Vector3 pos, Quaternion rot, Vector3 extent, bool enabled, string portalName = "portal" /* Metadata: 0x01FDA781 */) => default; // 0x00000001851488D0-0x0000000185148B10
		public static bool SetPortalObstructionAndOcclusion(ulong portalId, float obstruction, float occlusion) => default; // 0x0000000185148860-0x00000001851488D0
		public static bool SetReverbZone(ulong reverbZoneId, ulong parentRoom, float transitionWidth) => default; // 0x0000000185148BC0-0x0000000185148C30
		public static bool RemoveRoom(ulong roomId) => default; // 0x0000000185147F54-0x0000000185147FA4
		public static bool RemovePortal(ulong portalId) => default; // 0x0000000185147EB4-0x0000000185147F04
		public static bool RemoveGeometry(ulong geoId) => default; // 0x0000000185147E64-0x0000000185147EB4
		public static bool RemoveGeometryInstance(ulong instanceId) => default; // 0x0000000185147E14-0x0000000185147E64
		public static bool RemoveReverbZone(ulong reverbZoneId) => default; // 0x0000000185147F04-0x0000000185147F54
	}

	public delegate void AudioEventCallback(object in_cookie, AudioCallbackType in_type, AudioCallbackInfo in_info); // TypeDefIndex: 57980; 0x00000001850136BC-0x00000001850136F4

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioStringAttribute : PropertyAttribute // TypeDefIndex: 57981
	{
		// Constructors
		public AudioStringAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioVectorAttribute : PropertyAttribute // TypeDefIndex: 57982
	{
		// Constructors
		public AudioVectorAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioEventWarnAttribute : PropertyAttribute // TypeDefIndex: 57984
	{
		// Fields
		public WarnType warnType; // 0x10
	
		// Nested types
		public enum WarnType : byte // TypeDefIndex: 57983
		{
			NONE = 0,
			ONE_SHOT = 2,
			LOOP = 4
		}
	
		// Constructors
		public AudioEventWarnAttribute() {} // Dummy constructor
		public AudioEventWarnAttribute(WarnType type) {} // 0x0000000183D4E960-0x0000000183D4E970
	}

	public class BankHandle : IDisposable // TypeDefIndex: 57985
	{
		// Fields
		private int m_refCount; // 0x20
	
		// Properties
		public string name { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public AKRESULT result { get; set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public bool isDone { get; set; } // 0x0000000183D4E9A0-0x0000000183D4E9B0 0x0000000183D4E9B0-0x0000000183D4E9C0
		public int refCount { get => default; } // 0x0000000181003B50-0x0000000181003B60 
	
		// Constructors
		public BankHandle() {} // Dummy constructor
		public BankHandle(string bankName) {} // 0x0000000183594450-0x0000000183594470
	
		// Methods
		public void Dispose() {} // 0x000000018514C7BC-0x000000018514C83C
		public void IncRef() {} // 0x000000018514C83C-0x000000018514C888
		public void DecRef() {} // 0x000000018514C770-0x000000018514C7BC
	}

	public class AsyncLoadBankTask : IEnumerator, IDisposable // TypeDefIndex: 57986
	{
		// Fields
		private readonly List<BankHandle> m_handles; // 0x10
	
		// Properties
		public object Current { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public AsyncLoadBankTask() {} // Dummy constructor
		public AsyncLoadBankTask(IList<string> bankNames) {} // 0x0000000183593700-0x0000000183593E80
	
		// Methods
		public static AsyncLoadBankTask LoadBanksAsync(IList<string> bankNames) => default; // 0x0000000182C35A50-0x0000000182C35AD0
		public bool MoveNext() => default; // 0x0000000183871870-0x00000001838719B0
		public void Reset() {} // 0x0000000185146680-0x00000001851466D0
		public void Dispose() {} // 0x0000000185146530-0x0000000185146680
	}

	public static class AudioBankManager // TypeDefIndex: 57988
	{
		// Fields
		internal static Dictionary<string, BankHandle> s_loadedBankHandles; // 0x00
	
		// Nested types
		public class CallbackCookie // TypeDefIndex: 57987
		{
			// Fields
			public string bankName; // 0x10
			public Action callback; // 0x18
			public BankHandle handle; // 0x20
	
			// Constructors
			public CallbackCookie() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		static AudioBankManager() {} // 0x0000000183CE5440-0x0000000183CE54D0
	
		// Methods
		public static void LoadMainPCK() {} // 0x0000000183D47B90-0x0000000183D47C20
		public static BankHandle LoadBankAsync(string bankName, Action callback = null) => default; // 0x0000000183593E80-0x00000001835940E0
		private static void _LoadBankCallback(uint inBankId, IntPtr _, AKRESULT inLoadResult, object inCookie) {} // 0x0000000183594260-0x00000001835943A0
		public static bool UnloadBank(string bankName) => default; // 0x000000018514ADF0-0x000000018514AF4C
		public static void UnloadAllBanks() {} // 0x000000018514ABF4-0x000000018514ADF0
		public static bool IsBankLoaded(string bankName) => default; // 0x00000001835943A0-0x0000000183594450
		public static void Reset() {} // 0x000000018514AB64-0x000000018514ABF4
		[Conditional("ENABLE_PROFILER")]
		public static void LoadDebugFilePackage(string path) {} // 0x000000018514AA30-0x000000018514AB64
		[Conditional("ENABLE_PROFILER")]
		public static void AddDebugBankPath(string path) {} // 0x000000018514A980-0x000000018514AA30
		private static void _PreResetBasePath(out List<uint> unPinnedEventIds) {
			unPinnedEventIds = default;
		} // 0x000000018514AFC8-0x000000018514B0E8
		private static void _PostResetBasePath(List<uint> unPinnedEventIds) {} // 0x000000018514AF4C-0x000000018514AFC8
	}

	public class AudioConstants // TypeDefIndex: 57989
	{
		// Fields
		public const ulong AUDIO_INVALID_GAME_OBJECT = 18446744073709551615; // Metadata: 0x01FDA78B
		public const uint AUDIO_INVALID_UNIQUE_ID = 0; // Metadata: 0x01FDA793
		public const uint AUDIO_INVALID_INTERNAL_PLAYING_ID = 0; // Metadata: 0x01FDA794
		public const ulong AUDIO_GLOBAL_GAME_OBJECT = 18446744073709551615; // Metadata: 0x01FDA795
		public const ulong AUDIO_ROOM_OUTDOOR_ID = 18446744073709551615; // Metadata: 0x01FDA79D
		public const ulong AUDIO_ROOM_OUTDOORS_ID = 18446744073709551612; // Metadata: 0x01FDA7A5
		public const string AU_UI_BATTLE_BREAK_POISE = "au_ui_bat_break_poise"; // Metadata: 0x01FDA7AD
		public const string AU_GLOBAL_GAIN_ON = "au_global_gain_on"; // Metadata: 0x01FDA7C3
		public const string AU_GLOBAL_GAIN_OFF = "au_global_gain_off"; // Metadata: 0x01FDA7D5
		public const uint AU_HASH_EXTERNAL_SOURCE_COOKIE = 618371124; // Metadata: 0x01FDA7E8
		public const uint AU_BANK_INIT = 1355168291; // Metadata: 0x01FDA7ED
		public const string AU_DEVICE_CONTROLLER_SPEAKER = "Controller_Speaker"; // Metadata: 0x01FDA7F2
		public const int AUDIO_SPEAKER_SETUP_4_0 = 1539; // Metadata: 0x01FDA805
		public const string AU_DEVICE_WWISE_MOTION = "Wwise_Motion"; // Metadata: 0x01FDA807
		public const string AU_DEVICE_SYSTEM = "System"; // Metadata: 0x01FDA814
		public const string AU_DEVICE_SYSTEM_3D = "System_3D"; // Metadata: 0x01FDA81B
		public const uint AUDIO_UI_FULLSCREEN_OPEN = 3229907725; // Metadata: 0x01FDA825
		public const uint AUDIO_UI_FULLSCREEN_CLOSE = 166048075; // Metadata: 0x01FDA82A
		public const uint AUDIO_UI_FULLSCREEN_PAUSE = 697133041; // Metadata: 0x01FDA82E
	
		// Constructors
		public AudioConstants() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public struct AudioId // TypeDefIndex: 57990
	{
		// Fields
		[JsonProperty]
		[SerializeField]
		public int _id; // 0x00
	
		// Constructors
		public AudioId(uint id) {
			_id = default;
		} // 0x0000000183D4E970-0x0000000183D4E980
	
		// Methods
		public string GetName() => default; // 0x000000018514B75C-0x000000018514B7D4
		[IDTag(0)]
		public static implicit operator uint(AudioId id) => default; // 0x000000018282FE10-0x000000018282FE40
		[IDTag(1)]
		public static implicit operator int(AudioId id) => default; // 0x0000000182EA19F0-0x0000000182EA1A20
		[IDTag(2)]
		public static implicit operator AudioId(uint id) => default; // 0x0000000183635D60-0x0000000183635D90
		[IDTag(3)]
		public static implicit operator AudioId(int id) => default; // 0x000000018514B840-0x000000018514B88C
		[IDTag(4)]
		public static implicit operator AudioId(string id) => default; // 0x000000018514B7D4-0x000000018514B840
	}

	public static class AudioIdExtensions // TypeDefIndex: 57991
	{
		// Extension methods
		public static uint[] ToUIntArray(this ICollection<AudioId> ids) => default; // 0x000000018514B578-0x000000018514B75C
	}

	[Serializable]
	public struct AudioState : IEquatable<AudioState> // TypeDefIndex: 57992
	{
		// Fields
		[SerializeField]
		private int _stateGroup; // 0x00
		[SerializeField]
		private int _stateValue; // 0x04
	
		// Properties
		public uint stateGroup { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		public uint stateValue { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
	
		// Constructors
		public AudioState(uint stateGroup, uint stateValue) : this() {
			_stateGroup = default;
			_stateValue = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
	
		// Methods
		[IDTag(0)]
		public bool Equals(AudioState other) => default; // 0x000000018514C1C4-0x000000018514C230
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x000000018514C230-0x000000018514C2CC
		public override int GetHashCode() => default; // 0x000000018514C2CC-0x000000018514C364
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018514C364-0x000000018514C3C4
		public int __iFixBaseProxy_GetHashCode() => default; // 0x000000018514C3C4-0x000000018514C414
	}

	[Serializable]
	public struct AudioIdList // TypeDefIndex: 57993
	{
		// Fields
		public AudioId[] _ids; // 0x00
	}

	[Serializable]
	public struct AudioStateList // TypeDefIndex: 57994
	{
		// Fields
		[SerializeField]
		public AudioState[] _states; // 0x00
	}

	[Serializable]
	public struct AudioEngineInitSetting // TypeDefIndex: 57995
	{
		// Fields
		public AkWwiseInitializationSettings akInitSettings; // 0x00
	}

	[Serializable]
	public struct AudioLargeSource // TypeDefIndex: 57996
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
	}

	public struct AudioCallbackInfo // TypeDefIndex: 57997
	{
		// Fields
		public ulong objectId; // 0x00
		public IntPtr pCookie; // 0x08
		internal AkCallbackInfo rawInfo; // 0x10
	
		// Methods
		public AudioDurationCallbackInfo CastToDurationCallbackInfo() => default; // 0x000000018514B0E8-0x000000018514B1F4
	}

	public struct AudioDurationCallbackInfo // TypeDefIndex: 57998
	{
		// Fields
		public float duration; // 0x00
		public float estimatedDuration; // 0x04
		public uint audioNodeId; // 0x08
		public uint mediaId; // 0x0C
		public bool isStreaming; // 0x10
	}

	public class AudioPositionArrayProxy // TypeDefIndex: 57999
	{
		// Fields
		private AkPositionArray m_array; // 0x10
	
		// Properties
		public uint count { get => default; } // 0x00000001830D5E80-0x00000001830D5EA0 
	
		// Constructors
		public AudioPositionArrayProxy() {} // Dummy constructor
		public AudioPositionArrayProxy(uint count) {} // 0x0000000183287DA0-0x0000000183287E20
	
		// Methods
		public AkPositionArray GetRawArray() => default; // 0x00000001832879C0-0x00000001832879F0
		public void Add(Vector3 position, Vector3 forward, Vector3 up) {} // 0x0000000183287AF0-0x0000000183287BD0
		public void Reset() {} // 0x0000000183287D50-0x0000000183287DA0
		~AudioPositionArrayProxy() {} // 0x000000018514C144-0x000000018514C1C4
	}

	[Serializable]
	public struct AudioAcousticSurfaceData // TypeDefIndex: 58000
	{
		// Fields
		public uint textureId; // 0x00
		[Range(0f, 1f)]
		public float transmissionLoss; // 0x04
	}

	[Serializable]
	public struct AudioRoomData // TypeDefIndex: 58002
	{
		// Fields
		public uint roomToneId; // 0x00
		public uint priority; // 0x04
		public uint auxBusId; // 0x08
		public uint parentRoomId; // 0x0C
		public float auxLevel; // 0x10
		public float auxLevelToSelf; // 0x14
		public float transmissionLoss; // 0x18
		public float transitionWidth; // 0x1C
		public float t60DecayTIme; // 0x20
		public float preDelayTime; // 0x24
		public float reverbLevel; // 0x28
		public float erLevel; // 0x2C
		public EBoolFlags flags; // 0x30
	
		// Nested types
		[Flags]
		public enum EBoolFlags : ushort // TypeDefIndex: 58001
		{
			None = 0,
			KeepRegistered = 1,
			UseForReflectionAndDiffraction = 2,
			AsReverbZone = 4
		}
	}

	[Flags]
	public enum AudioCallbackType // TypeDefIndex: 58003
	{
		None = 0,
		AU_EndOfEvent = 1,
		AU_EndOfDynamicSequenceItem = 2,
		AU_Marker = 4,
		AU_Duration = 8,
		AU_SpeakerVolumeMatrix = 16,
		AU_Starvation = 32,
		AU_MusicPlaylistSelect = 64,
		AU_MusicPlayStarted = 128,
		AU_MusicSyncBeat = 256,
		AU_MusicSyncBar = 512,
		AU_MusicSyncEntry = 1024,
		AU_MusicSyncExit = 2048,
		AU_MusicSyncGrid = 4096,
		AU_MusicSyncUserCue = 8192,
		AU_MusicSyncPoint = 16384,
		AU_MusicSyncAll = 32512,
		AU_MIDIEvent = 65536,
		AU_CallbackBits = 1048575,
		AU_EnableGetSourcePlayPosition = 1048576,
		AU_EnableGetMusicPlayPosition = 2097152,
		AU_EnableGetSourceStreamBuffering = 4194304,
		AU_Monitoring = 536870912,
		AU_AudioInterruption = 570425344,
		AU_AudioSourceChange = 587202560,
		AU_Bank = 1073741824
	}

	public enum AudioLargeType : byte // TypeDefIndex: 58004
	{
		Sum = 0,
		Nearest = 1,
		Single = 2
	}

	[Flags]
	public enum AudioPlayableActions // TypeDefIndex: 58005
	{
		None = 0,
		Playback = 1,
		Stop = 2,
		Seek = 4
	}

	public enum AudioEventType // TypeDefIndex: 58006
	{
		Sfx = 0,
		Music = 1,
		State = 2,
		GameSync = 3,
		Voice = 4,
		Controller = 5,
		Vibration = 6,
		Global = 7
	}

	public enum AudioMixDownMode // TypeDefIndex: 58007
	{
		Direct = 0,
		ForceToMono = 1
	}

	public enum AudioMasteringSuiteMode // TypeDefIndex: 58008
	{
		Headphone = 1,
		TV = 2,
		HomeCinema = 3,
		SoundBar = 4,
		Speaker = 5,
		DevMode = 99
	}

	public enum AudioChannelConfigType : uint // TypeDefIndex: 58009
	{
		Anonymous = 0,
		Standard = 1,
		Ambisonic = 2,
		Objects = 3,
		UseDeviceMain = 14,
		UseDevicePassthrough = 15
	}

	public enum AudioCodec : uint // TypeDefIndex: 58010
	{
		PCM = 1,
		ADPCM = 2,
		VORBIS = 4,
		ATRAC9 = 12,
		OPUS_WEM = 20
	}

	public enum AudioChannelMask : uint // TypeDefIndex: 58011
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

	[Flags]
	public enum AudioLogChannel // TypeDefIndex: 58012
	{
		ALL = -1,
		NONE = 0,
		API = 1,
		IO = 2,
		OBJECT = 4,
		MUSIC = 1024,
		SPATIAL = 2048,
		SCENE = 4096,
		VOICE = 8192,
		GAMEPLAY = 32768,
		GP_STATE = 65536,
		GP_CUE = 131072,
		GP_FACTORY = 262144,
		GP_UI = 524288,
		GP_ANIM = 1048576,
		GP_TIMELINE = 2097152,
		MOTION = 268435456,
		WWISE = 536870912,
		EDITOR = 1073741824,
		MISC = 2147483647
	}

	public static class AudioLogger // TypeDefIndex: 58013
	{
		// Fields
		public static AudioLogChannel s_enabledChannels; // 0x00
	
		// Constructors
		static AudioLogger() {} // 0x000000018514BE7C-0x000000018514BEB8
	
		// Methods
		public static bool IsChannelEnabled(AudioLogChannel channel) => default; // 0x000000018514B998-0x000000018514BA1C
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void EnableChannel(AudioLogChannel channel) {} // 0x000000018514B914-0x000000018514B998
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void DisableChannel(AudioLogChannel channel) {} // 0x000000018514B88C-0x000000018514B914
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void SetChannels(AudioLogChannel channel) {} // 0x000000018514BBD0-0x000000018514BC50
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log(AudioLogChannel channel, string msg) {} // 0x000000018514BB2C-0x000000018514BBD0
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1>(AudioLogChannel channel, string msg, T1 param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning(AudioLogChannel channel, string msg) {} // 0x000000018514BAA4-0x000000018514BB2C
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning<T1>(AudioLogChannel channel, string msg, T1 param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError(AudioLogChannel channel, string msg) {} // 0x000000018514BA1C-0x000000018514BAA4
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError<T1>(AudioLogChannel channel, string msg, T1 param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4) {}
		private static void _DoLog(AudioLogChannel channel, string msg) {} // 0x000000018514BDD0-0x000000018514BE7C
		private static void _DoLogWarning(AudioLogChannel channel, string msg) {} // 0x000000018514BD24-0x000000018514BDD0
		private static void _DoLogError(AudioLogChannel channel, string msg) {} // 0x000000018514BC50-0x000000018514BD24
	}

	public static class AudioAcousticUtil // TypeDefIndex: 58014
	{
		// Fields
		private const float SOUND_SPEED = 343f; // Metadata: 0x01FDA98C
	
		// Methods
		public static float RT60DecayTime(float volume, float surfaceArea, float absorptionFactor) => default; // 0x0000000185146834-0x00000001851468DC
		public static float PreDelayTime(Vector3 size) => default; // 0x00000001851467BC-0x0000000185146834
		public static float CriticalDistance(float volume, float rt60, float gamma = 1f /* Metadata: 0x01FDA988 */) => default; // 0x00000001851466D0-0x0000000185146760
		public static float ReverbIntensity(Vector3 size) => default; // 0x00000001851468DC-0x0000000185146968
		public static float ErIntensity(Vector3 size) => default; // 0x0000000185146760-0x00000001851467BC
	}

	internal static class AudioActionQueueHelper // TypeDefIndex: 58018
	{
		// Fields
		private static Queue<FExecuteAction> s_executeActionQueue; // 0x00
		private static Queue<FRTPCAction> s_rtpcActionQueue; // 0x08
		private static Queue<FSeekAction> s_seekActionQueue; // 0x10
		private const int QUEUE_LIFETIME_FRAME = 10; // Metadata: 0x01FDA990
	
		// Nested types
		private struct FExecuteAction // TypeDefIndex: 58015
		{
			// Fields
			public int queuedFrame; // 0x00
			public uint playingId; // 0x04
			public AkActionOnEventType actionType; // 0x08
			public int durationMs; // 0x0C
		}
	
		private struct FRTPCAction // TypeDefIndex: 58016
		{
			// Fields
			public int queuedFrame; // 0x00
			public uint playingId; // 0x04
			public uint rtpcId; // 0x08
			public float targetValue; // 0x0C
			public int durationMs; // 0x10
		}
	
		private struct FSeekAction // TypeDefIndex: 58017
		{
			// Fields
			public int queuedFrame; // 0x00
			public float queuedTime; // 0x04
			public uint playingId; // 0x08
			public uint eventId; // 0x0C
			public ulong audioObjectId; // 0x10
			public int timeMs; // 0x18
			public bool toNearestMarker; // 0x1C
		}
	
		// Constructors
		static AudioActionQueueHelper() {} // 0x0000000183A92C80-0x0000000183A92E50
	
		// Methods
		internal static void QueueExecuteAction(uint playingId, AkActionOnEventType actionType, int durationMs) {} // 0x0000000182A9EBC0-0x0000000182A9ECB0
		internal static void QueueRtpcAction(uint playingId, uint rtpcId, float targetValue, int durationMs) {} // 0x0000000185146A58-0x0000000185146B5C
		internal static void QueueSeekAction(uint playingId, uint eventId, ulong audioObjectId, int timeMs, bool toNearestMarker) {} // 0x0000000185146B5C-0x0000000185146CB0
		internal static void ConsumeQueue() {} // 0x000000018269D1A0-0x000000018269D290
		internal static void ClearQueue() {} // 0x0000000185146968-0x0000000185146A58
		private static void _ConsumeExecute(int currFrame) {} // 0x000000018269D290-0x000000018269D500
		private static void _ConsumeRtpc(int currFrame) {} // 0x000000018269D500-0x000000018269D630
		private static void _ConsumeSeek(int currFrame) {} // 0x000000018269D630-0x000000018269D7B0
	}

	internal static class AudioAssetCache // TypeDefIndex: 58022
	{
		// Fields
		private static Dictionary<uint, LinkedListNode<EventCacheInfo>> s_lruUsingEvents; // 0x00
		private static Cache s_cachedEvents; // 0x08
		private static HashSet<uint> s_pinnedEvents; // 0x10
		private const int INIT_PREPARE_CAP = 128; // Metadata: 0x01FDA991
		private static ObjectPool<LinkedListNode<EventCacheInfo>> s_nodePool; // 0x18
	
		// Nested types
		internal class EventCacheInfo // TypeDefIndex: 58019
		{
			// Fields
			public uint id; // 0x10
			public uint refCount; // 0x14
	
			// Constructors
			public EventCacheInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class Cache // TypeDefIndex: 58020
		{
			// Fields
			private readonly LinkedList<EventCacheInfo> m_lruCachedEventsList; // 0x10
			private readonly Dictionary<uint, LinkedListNode<EventCacheInfo>> m_lruCachedEvents; // 0x18
	
			// Properties
			public LinkedList<EventCacheInfo> lruCachedEventsList { get => default; } // 0x000000018514C888-0x000000018514C8D8 
			public int count { get => default; } // 0x0000000183B38A30-0x0000000183B38A70 
	
			// Constructors
			public Cache() {} // 0x00000001839D42A0-0x00000001839D4360
	
			// Methods
			public void Clear() {} // 0x00000001833B64B0-0x00000001833B6530
			public uint RemoveFirst(out LinkedListNode<EventCacheInfo> outNode) {
				outNode = default;
				return default;
			} // 0x00000001826A09C0-0x00000001826A0AB0
			public bool Remove(uint inId, out LinkedListNode<EventCacheInfo> outNode) {
				outNode = default;
				return default;
			} // 0x00000001826A0080-0x00000001826A0360
			public void AddLast(ref LinkedListNode<EventCacheInfo> node) {} // 0x000000018269F940-0x000000018269FA00
		}
	
		// Constructors
		static AudioAssetCache() {} // 0x00000001839D4150-0x00000001839D42A0
	
		// Methods
		internal static void Reset() {} // 0x00000001833B6260-0x00000001833B64B0
		internal static void PinEvent(uint inId) {} // 0x00000001830D5190-0x00000001830D5230
		internal static void UnpinEvent(uint inId) {} // 0x0000000185149FE8-0x000000018514A088
		internal static void GetAllUsingAssetsAndRelease(ref List<uint> allIds) {} // 0x0000000185149C88-0x0000000185149FE8
		internal static uint GetLeastActiveAssetAndUncache() => default; // 0x00000001826A08C0-0x00000001826A09C0
		internal static int GetCachedAssetCount() => default; // 0x0000000183B389B0-0x0000000183B38A30
		internal static bool ActivateAsset(uint inId) => default; // 0x000000018269DB60-0x000000018269DDC0
		internal static void DeactivateAsset(uint inId) {} // 0x000000018269EC30-0x000000018269EE00
		internal static void ForceReleaseCachedAsset(uint inId) {} // 0x000000018269FAC0-0x000000018269FBB0
		[Conditional("BEYOND_DEBUG")]
		private static void _NotifyDebugger() {} // 0x000000018514A0CC-0x000000018514A10C
		[Conditional("BEYOND_DEBUG")]
		private static void _NotifyDebuggerCacheHit(bool isHit) {} // 0x000000018514A088-0x000000018514A0CC
		[Conditional("BEYOND_DEBUG")]
		private static void _ResetDebugger() {} // 0x000000018514A194-0x000000018514A1D4
		[Conditional("BEYOND_DEBUG")]
		private static void _PinnedEventLeakDetect() {} // 0x000000018514A10C-0x000000018514A194
	}

	internal static class AudioAssetHelper // TypeDefIndex: 58025
	{
		// Fields
		private static ulong s_memoryBudget; // 0x00
		private const float FACTOR_B_TO_MB = 9.5367E-07f; // Metadata: 0x01FDA995
		private static ushort s_gcCount; // 0x08
		private static int s_gcPendingCount; // 0x0C
		private static Queue<FOnBankLoadedDoPrepareEventPayload> s_waitingCallbacks; // 0x10
		private static Queue<FPendingLoadRequest> s_pendingLoadRequests; // 0x18
		private static HashSet<uint> s_solidLoadedEvents; // 0x20
		private static readonly uint[] S_REUSABLE_UINT_ARRAY; // 0x28
		private static readonly AkCallbackManager.BankCallback ON_UNPREPARED_DO_UNLOAD_BANK; // 0x30
		private static readonly AkCallbackManager.BankCallback ON_DONE_UNLOAD_BANK; // 0x38
		private static readonly AkCallbackManager.BankCallback ON_BANK_LOADED_DO_PREPARE_EVENT; // 0x40
		private static readonly AkCallbackManager.BankCallback ON_DONE_PREPARE_EVENT; // 0x48
	
		// Properties
		private static bool isGcProcessing { get; } // 0x000000018269BE40-0x000000018269BEA0 
	
		// Nested types
		private struct FOnBankLoadedDoPrepareEventPayload // TypeDefIndex: 58023
		{
			// Fields
			public uint id; // 0x00
			public AkCallbackManager.BankCallback callback; // 0x08
			public object cookie; // 0x10
		}
	
		private struct FPendingLoadRequest // TypeDefIndex: 58024
		{
			// Fields
			public uint id; // 0x00
			public FOnBankLoadedDoPrepareEventPayload payload; // 0x08
		}
	
		// Constructors
		static AudioAssetHelper() {} // 0x0000000183594470-0x0000000183594830
	
		// Methods
		internal static void SetMemoryBudget(ulong inBudgetBytes, ushort inGcCount = 10 /* Metadata: 0x01FDA993 */) {} // 0x0000000183A30840-0x0000000183A308D0
		internal static bool HasPreparingEvents() => default; // 0x000000018514A1D4-0x000000018514A260
		internal static void UnPrepareAllEventsSync() {} // 0x000000018514A414-0x000000018514A7B8
		internal static void LoadEventAsync(uint inId, AkCallbackManager.BankCallback callback = null, object cookie = null) {} // 0x000000018514A260-0x000000018514A3CC
		private static void _TryConsumePendingLoadRequests() {} // 0x000000018381D190-0x000000018381D210
		private static void _ConsumePendingLoadRequests() {} // 0x000000018269BAD0-0x000000018269BB70
		private static void _DoLoadEventAsync(uint inId, FOnBankLoadedDoPrepareEventPayload payload) {} // 0x000000018269D960-0x000000018269DB60
		internal static void PinEvent(uint inId) {} // 0x000000018514A3CC-0x000000018514A414
		internal static void UnpinEvent(uint inId) {} // 0x000000018514A800-0x000000018514A848
		internal static void ResetStaticFields() {} // 0x00000001833B6150-0x00000001833B6260
		internal static void ReleaseAllCachedEventsSync() {} // 0x000000018269BD50-0x000000018269BE40
		private static void _TryGC() {} // 0x000000018514A910-0x000000018514A980
		private static void _DoGc(int gcCount) {} // 0x00000001826A0710-0x00000001826A08C0
		internal static void UnloadEvent(uint inId) {} // 0x000000018514A7B8-0x000000018514A800
		private static void _OnUnpreparedDoUnloadBank(uint inId, IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, object inCookie) {} // 0x00000001826A0620-0x00000001826A0710
		private static void _OnDoneUnloadBank(uint inId, IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, object inCookie) {} // 0x000000018381D0F0-0x000000018381D190
		private static void _OnBankLoadedDoPrepareEvent(uint inId, IntPtr _, AKRESULT inLoadResult, object __) {} // 0x000000018269FBB0-0x000000018269FD40
		private static void _OnDonePrepareEvent(uint inId, IntPtr _, AKRESULT __, object ___) {} // 0x000000018269FA00-0x000000018269FAC0
		private static void _TryDequeueAndInvokeCallback() {} // 0x000000018269E670-0x000000018269EBE0
		[Conditional("BEYOND_DEBUG")]
		private static void _RemoveLoadingDebug(uint inId) {} // 0x000000018514A8CC-0x000000018514A910
		[Conditional("BEYOND_DEBUG")]
		private static void _AddLoadingDebug(uint inId) {} // 0x000000018514A848-0x000000018514A88C
		[Conditional("BEYOND_DEBUG")]
		private static void _ClearLoadingDebug() {} // 0x000000018514A88C-0x000000018514A8CC
	}

	internal static class AudioCallbackMessageParser // TypeDefIndex: 58026
	{
		// Methods
		internal static void Set() {} // 0x0000000183A46A80-0x0000000183A46B40
		private static void _OnMonitoringCallback(AkMonitorErrorCode inErrorCode, AkMonitorErrorLevel inErrorLevel, uint inPlayingID, ulong inGameObjID, string inMsg) {} // 0x000000018350B670-0x000000018350B680
	}

	public static class AudioDebugInfoContainer // TypeDefIndex: 58027
	{
		// Methods
		[Conditional("BEYOND_DEBUG")]
		public static void SetAudioObjectName(ulong audioObjId, string name) {} // 0x000000018514B388-0x000000018514B3DC
		[Conditional("BEYOND_DEBUG")]
		public static void RemoveAudioObjectName(ulong audioObjId) {} // 0x000000018514B344-0x000000018514B388
		public static string GetAudioObjectName(ulong audioObjId) => default; // 0x000000018514B29C-0x000000018514B2D4
		public static string ForceGetEventName(uint eventId) => default; // 0x000000018514B1F4-0x000000018514B248
		public static string ForceGetRtpcName(uint rtpcId) => default; // 0x000000018514B248-0x000000018514B29C
		public static string GetRtpcName(uint rtpcId) => default; // 0x000000018514B30C-0x000000018514B344
		public static string GetEventName(uint eventId) => default; // 0x000000018514B2D4-0x000000018514B30C
	}

	public static class AudioHashGenerator // TypeDefIndex: 58028
	{
		// Fields
		public const short MAX_STRING_LENGTH = 256; // Metadata: 0x01FDA999
		private const uint PRIME32 = 16777619; // Metadata: 0x01FDA99B
		private const uint OFFSET_BASIS32 = 2166136261; // Metadata: 0x01FDA99F
	
		// Methods
		[IDTag(0)]
		public static uint Compute(string inStr) => default; // 0x00000001828324C0-0x00000001828325B0
		[IDTag(2)]
		public static uint Compute(IntPtr inCharPtr) => default; // 0x0000000182831AA0-0x0000000182831BD0
		[IDTag(1)]
		public static uint Compute(ReadOnlySpan<byte> buffer) => default; // 0x0000000182832410-0x00000001828324C0
		[IDTag(3)]
		public static uint Compute(string inStr1, string inStr2) => default; // 0x00000001828322E0-0x0000000182832410
		[IDTag(4)]
		public static uint Compute(params string[] strings) => default; // 0x000000018514B480-0x000000018514B568
		private static uint _GetUintFromCharToLower(char c) => default; // 0x000000018514B568-0x000000018514B578
	}

	public static class AudioMemoryMonitor // TypeDefIndex: 58031
	{
		// Fields
		private static AkMemCategroyStats s_categoryStats; // 0x00
		private static bool s_monitorInited; // 0x08
	
		// Nested types
		public struct FGlobalMemoryStats // TypeDefIndex: 58029
		{
			// Fields
			public ulong used; // 0x00
			public ulong reserved; // 0x08
		}
	
		public struct FExtraMemoryStats // TypeDefIndex: 58030
		{
			// Fields
			public ulong active; // 0x00
			public ulong mapped; // 0x08
			public ulong retained; // 0x10
			public ulong allocated; // 0x18
		}
	
		// Methods
		internal static void Init() {} // 0x0000000183B37F80-0x0000000183B38030
		internal static void Release() {} // 0x000000018514C0BC-0x000000018514C144
		internal static bool IsValid() => default; // 0x000000018514C084-0x000000018514C0BC
		internal static ulong GetUsedMemoryUnsafe() => default; // 0x000000018514BFE4-0x000000018514C024
		internal static ulong GetUsedMemory() => default; // 0x000000018514C024-0x000000018514C084
		public static FGlobalMemoryStats GetGlobalMemoryStats() => default; // 0x00000001839CAF20-0x00000001839CAFD0
		public static FExtraMemoryStats GetExtraMemoryStats() => default; // 0x000000018514BEB8-0x000000018514BF1C
		internal static ulong GetUsedMemoryByCategory(AkMemID memCategory) => default; // 0x000000018514BF1C-0x000000018514BFE4
	}

	public static class AudioUIUtil // TypeDefIndex: 58033
	{
		// Fields
		private static ushort s_fullScreenCounter; // 0x00
	
		// Nested types
		[Flags]
		public enum UIAudioType // TypeDefIndex: 58032
		{
			None = 0,
			FullScreen = 1,
			Tips = 2
		}
	
		// Methods
		public static void Init() {} // 0x00000001829523D0-0x00000001829524A0
		public static void Release() {} // 0x000000018514C49C-0x000000018514C544
		[IDTag(0)]
		public static uint PostUIEvent(string eventName, GameObject uiGameObject) => default; // 0x000000018290FE60-0x000000018290FF90
		[IDTag(1)]
		public static uint PostUIEvent(string eventName, string objPath) => default; // 0x000000018514C414-0x000000018514C49C
		public static void OnUIPanelClose(UIAudioType uiAudioType) {} // 0x0000000182EA2930-0x0000000182EA29E0
		public static void OnUIPanelOpen(UIAudioType uiAudioType) {} // 0x0000000182EA2C50-0x0000000182EA2D00
	}

	internal static class AudioVFSLoader // TypeDefIndex: 58035
	{
		// Fields
		private const string PCK_SUFFIX = ".pck"; // Metadata: 0x01FDA9A7
		private static VfsLoadedInfo s_loadedInitPckInfo; // 0x00
		private static VfsLoadedInfo s_loadedMainPckInfo; // 0x10
		private static VfsLoadedInfo s_loadedAuditPckInfo; // 0x20
		private static VfsLoadedInfo s_loadedLangPckInfo; // 0x30
		private static VfsLoadedInfo s_loadedHotfixPckInfo; // 0x40
		private static EVFSBlockType s_pendingLanguageBlock; // 0x50
	
		// Nested types
		private struct VfsLoadedInfo // TypeDefIndex: 58034
		{
			// Fields
			public List<uint> loadedPcks; // 0x00
			public int loadedVersion; // 0x08
			public bool isLoaded; // 0x0C
	
			// Methods
			public static VfsLoadedInfo Create() => default; // 0x00000001837083C0-0x00000001837084C0
		}
	
		// Methods
		internal static void UnloadAll() {} // 0x000000018514C544-0x000000018514C614
		internal static bool TryLoadInitPck() => default; // 0x0000000182952190-0x0000000182952230
		internal static bool TryLoadMainPck() => default; // 0x0000000182CB3CE0-0x0000000182CB3E10
		internal static bool TryLoadLanguagePck(string language) => default; // 0x0000000182951D90-0x0000000182951E20
		private static bool _DoLoadLanguageAndHotfixPck(EVFSBlockType langBlockType) => default; // 0x0000000182CB3B70-0x0000000182CB3CE0
		internal static void InitBasePaths() {} // 0x0000000183707BF0-0x00000001837083C0
		private static bool _TryLoadPcksFromVfsInfo(VFBlockMainInfo vfsInfo, ref VfsLoadedInfo info) => default; // 0x0000000182CB3AC0-0x0000000182CB3B70
		private static bool _DoLoadPcksFromVfs(VFBlockMainInfo vfs, ref List<uint> loaded) => default; // 0x0000000182CB3290-0x0000000182CB36C0
		private static bool _DoLoadSinglePckFromVfs(FVFBlockFileInfo fileInfo, out uint loadedId) {
			loadedId = default;
			return default;
		} // 0x0000000182CB37A0-0x0000000182CB3950
		private static void _UnloadPcks(ref VfsLoadedInfo info) {} // 0x0000000182CB3E10-0x0000000182CB41E0
		private static EVFSBlockType _GetVfsBlockTypeFromLanguage(string language) => default; // 0x0000000182951E20-0x0000000182951EA0
	}
}

namespace Beyond.Audio.AudioPerformanceMonitor
{
	public class AudioProfiling // TypeDefIndex: 58038
	{
		// Nested types
		public static class AudioWwiseProfilingData // TypeDefIndex: 58037
		{
			// Fields
			public static readonly ProfilerCounterValue<float> CPU; // 0x00
			public static readonly ProfilerCounterValue<float> PLUGIN_CPU; // 0x01
			public static readonly ProfilerCounterValue<int> ACTIVE_EVENTS; // 0x02
			public static readonly ProfilerCounterValue<int> TOTAL_VOICES; // 0x03
			public static readonly ProfilerCounterValue<int> PHYS_VOICES; // 0x04
			public static readonly ProfilerCounterValue<int> VIR_VOPICES; // 0x05
			public static readonly ProfilerCounterValue<ulong> TOTAL_MEM; // 0x06
			public static readonly ProfilerCounterValue<ulong> RESERVED_MEM; // 0x07
			public static readonly ProfilerCounterValue<float> CACHE_HIT_RATE; // 0x08
	
			// Constructors
			static AudioWwiseProfilingData() {} // 0x000000018514C614-0x000000018514C770
		}
	
		// Constructors
		public AudioProfiling() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WwiseResourceMonitor : Singleton<WwiseResourceMonitor> // TypeDefIndex: 58039
	{
		// Fields
		private const float TIME_OF_SOUND_FRAME = 0.21333334f; // Metadata: 0x01FDA9AC
		private const float MB_RATE = 9.536743E-07f; // Metadata: 0x01FDA9B0
		private bool m_isActiveAkResourceMonitoring; // 0x10
		private WwiseResourceMonitorItem m_wwiseResourceMonitorData; // 0x14
	
		// Properties
		public bool isActiveAkResourceMonitoring { get => default; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		private WwiseResourceMonitor() {} // 0x0000000185152C20-0x0000000185152C48
	
		// Methods
		public static bool IsSupportMemoryMonitor() => default; // 0x000000018232EB60-0x000000018232EB70
		public void StartSoundEngineResourceMonitor() {} // 0x0000000185152C08-0x0000000185152C14
		public void StopSoundEngineResourceMonitor() {} // 0x0000000185152C14-0x0000000185152C20
		public WwiseResourceMonitorItem SampleRawWwiseResource() => default; // 0x0000000183D4E9E0-0x0000000183D4EA10
	}

	[Serializable]
	public struct WwiseResourceMonitorItem // TypeDefIndex: 58040
	{
		// Fields
		public float pluginCpu; // 0x00
		public float cpu; // 0x04
		public float pluginCpuInMs; // 0x08
		public float cpuInMs; // 0x0C
		public float reservedMemory; // 0x10
		public float usedMemory; // 0x14
		public float allocatedMemory; // 0x18
		public float mappedMemory; // 0x1C
		public float activeMemory; // 0x20
		public float retainedMemory; // 0x24
		public int eventNum; // 0x28
		public int totalVoiceNum; // 0x2C
		public int physicalVoiceNum; // 0x30
		public int virtualVoiceNum; // 0x34
		public int eventCallbackCount; // 0x38
		public int bankCallbackCount; // 0x3C
	}
}

namespace Beyond.Audio.Editor
{
	public static class AudioEditorAssetsLoader // TypeDefIndex: 58036
	{
		// Methods
		[Conditional("UNITY_EDITOR")]
		internal static void Init() {} // 0x000000018350B670-0x000000018350B680
		[Conditional("UNITY_EDITOR")]
		internal static void Release() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 57966
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 57967
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 57968
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 57969
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 57970
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 57965
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58043
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05800-0x0000000183D05870
	
		// Methods
		public uint __Gen_Wrap_0(uint P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7) => default; // 0x000000018514CD58-0x000000018514CEAC
		public uint __Gen_Wrap_1(object P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7) => default; // 0x000000018514D820-0x000000018514D974
		public void __Gen_Wrap_2(uint P0, IntPtr P1, AKRESULT P2, object P3) {} // 0x000000018514E1DC-0x000000018514E2E4
		public void __Gen_Wrap_3(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public IEnumerator __Gen_Wrap_4(object P0, object P1, object P2) => default; // 0x000000018514F42C-0x000000018514F554
		public void __Gen_Wrap_5(in IList<uint> P0, in Action<object> P1, in object P2) {} // 0x000000018514FDA4-0x000000018514FED0
		public void __Gen_Wrap_6(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public uint __Gen_Wrap_7(AudioId P0) => default; // 0x00000001851514C0-0x00000001851515C0
		public IEnumerator __Gen_Wrap_8(object P0) => default; // 0x0000000185151F14-0x0000000185151FF0
		public void __Gen_Wrap_9(uint P0, uint P1, ulong P2) {} // 0x0000000185152800-0x00000001851528E0
		public void __Gen_Wrap_10(object P0, object P1, ulong P2) {} // 0x000000018514CF64-0x000000018514D048
		public uint __Gen_Wrap_11(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public void __Gen_Wrap_12(uint P0, float P1, ulong P2) {} // 0x000000018514D048-0x000000018514D140
		public void __Gen_Wrap_13(object P0, float P1, ulong P2) {} // 0x000000018514D140-0x000000018514D23C
		public void __Gen_Wrap_14(uint P0, float P1, ulong P2, int P3) {} // 0x000000018514D23C-0x000000018514D344
		public void __Gen_Wrap_15(uint P0, uint P1, float P2, int P3) {} // 0x000000018514D344-0x000000018514D44C
		public void __Gen_Wrap_16(uint P0, float P1, uint P2, int P3) {} // 0x000000018514D44C-0x000000018514D554
		public void __Gen_Wrap_17(uint P0, ulong P1, int P2) {} // 0x000000018514D554-0x000000018514D634
		public void __Gen_Wrap_18(object P0, ulong P1, int P2) {} // 0x000000018514D634-0x000000018514D718
		public void __Gen_Wrap_19(uint P0, uint P1, ulong P2, int P3, bool P4) {} // 0x000000018514D718-0x000000018514D820
		public void __Gen_Wrap_20(uint P0, ulong P1, int P2, bool P3, uint P4) {} // 0x000000018514D974-0x000000018514DA7C
		public void __Gen_Wrap_21(object P0, ulong P1, int P2, bool P3, uint P4) {} // 0x000000018514DA7C-0x000000018514DB88
		public void __Gen_Wrap_22(object P0, int P1, bool P2, uint P3) {} // 0x000000018514DB88-0x000000018514DC80
		public void __Gen_Wrap_23(uint P0, int P1, bool P2, uint P3) {} // 0x000000018514DC80-0x000000018514DD74
		public bool __Gen_Wrap_24(uint P0, out int P1, bool P2) {
			P1 = default;
			return default;
		} // 0x000000018514DD74-0x000000018514DE88
		public bool __Gen_Wrap_25(uint P0) => default; // 0x000000018514DE88-0x000000018514DF54
		public int __Gen_Wrap_26() => default; // 0x00000001850EF068-0x00000001850EF114
		public uint __Gen_Wrap_27(object P0, out LinkedListNode<AudioAssetCache.EventCacheInfo> P1) {
			P1 = default;
			return default;
		} // 0x000000018514DF54-0x000000018514E08C
		public uint __Gen_Wrap_28() => default; // 0x00000001850EF068-0x00000001850EF114
		public bool __Gen_Wrap_29(object P0, uint P1, out LinkedListNode<AudioAssetCache.EventCacheInfo> P2) {
			P2 = default;
			return default;
		} // 0x000000018514E08C-0x000000018514E1DC
		public void __Gen_Wrap_30() {} // 0x00000001850F3444-0x00000001850F34E0
		public void __Gen_Wrap_31(uint P0, AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload P1) {} // 0x000000018514E2E4-0x000000018514E3FC
		public void __Gen_Wrap_32(int P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public AkPositionArray __Gen_Wrap_33(object P0) => default; // 0x000000018514E4BC-0x000000018514E5AC
		public void __Gen_Wrap_34(ulong P0, object P1, AudioLargeType P2) {} // 0x000000018514E5AC-0x000000018514E6A4
		public void __Gen_Wrap_35(ulong P0) {} // 0x000000018514E6A4-0x000000018514E764
		public void __Gen_Wrap_36(ulong P0, ulong P1) {} // 0x000000018514E764-0x000000018514E840
		public bool __Gen_Wrap_37(uint P0, out uint P1) {
			P1 = default;
			return default;
		} // 0x000000018514E840-0x000000018514E94C
		public EVFSBlockType __Gen_Wrap_38(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public void __Gen_Wrap_39(ref AudioVFSLoader.VfsLoadedInfo P0) {} // 0x000000018514E94C-0x000000018514EA88
		public bool __Gen_Wrap_40(FVFBlockFileInfo P0, out uint P1) {
			P1 = default;
			return default;
		} // 0x000000018514EA88-0x000000018514EBEC
		public bool __Gen_Wrap_41(object P0, ref List<uint> P1) => default; // 0x000000018514EBEC-0x000000018514ED24
		public bool __Gen_Wrap_42(object P0, ref AudioVFSLoader.VfsLoadedInfo P1) => default; // 0x000000018514ED24-0x000000018514EE8C
		public bool __Gen_Wrap_43(EVFSBlockType P0) => default; // 0x000000018514EE8C-0x000000018514EF5C
		public bool __Gen_Wrap_44(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public void __Gen_Wrap_45(AudioEngineInitSetting P0) {} // 0x000000018514F02C-0x000000018514F120
		public AudioAdapter.PayloadPostEvent __Gen_Wrap_46() => default; // 0x000000018514F120-0x000000018514F1D8
		public LinkedListNode<AudioAssetCache.EventCacheInfo> __Gen_Wrap_47() => default; // 0x000000018514F1D8-0x000000018514F290
		public AudioVFSLoader.VfsLoadedInfo __Gen_Wrap_48() => default; // 0x000000018514F290-0x000000018514F380
		public bool __Gen_Wrap_49() => default; // 0x000000018514F380-0x000000018514F42C
		public void __Gen_Wrap_50(ref List<uint> P0) {} // 0x000000018514F554-0x000000018514F660
		public void __Gen_Wrap_51(bool P0) {} // 0x000000018514F660-0x000000018514F720
		public void __Gen_Wrap_52(object P0, AkCallbackType P1, object P2) {} // 0x000000018514F720-0x000000018514F818
		public uint __Gen_Wrap_53(uint P0, ulong P1, AudioCallbackType P2, object P3, object P4) => default; // 0x000000018514F818-0x000000018514F93C
		public void __Gen_Wrap_54(uint P0, AkActionOnEventType P1, int P2) {} // 0x000000018514F93C-0x000000018514FA34
		public void __Gen_Wrap_55(AkActionOnEventType P0, uint P1, int P2) {} // 0x000000018514F93C-0x000000018514FA34
		public AkResourceMonitorDataSummary __Gen_Wrap_56() => default; // 0x000000018514FA34-0x000000018514FAEC
		public AudioMemoryMonitor.FGlobalMemoryStats __Gen_Wrap_57() => default; // 0x000000018514FAEC-0x000000018514FBDC
		public AudioMemoryMonitor.FExtraMemoryStats __Gen_Wrap_58() => default; // 0x000000018514FBDC-0x000000018514FCBC
		public void __Gen_Wrap_59(ulong P0, float P1, float P2) {} // 0x000000018514FCBC-0x000000018514FDA4
		public bool __Gen_Wrap_60(ulong P0, object P1, object P2, object P3, object P4, bool P5, bool P6) => default; // 0x000000018514FED0-0x0000000185150004
		public bool __Gen_Wrap_61(ulong P0, Vector3 P1, Vector3 P2, Quaternion P3, ulong P4, bool P5) => default; // 0x0000000185150004-0x00000001851501AC
		public bool __Gen_Wrap_62(ulong P0, AudioRoomData P1, ulong P2, object P3) => default; // 0x00000001851501AC-0x000000018515030C
		public bool __Gen_Wrap_63(ulong P0, ulong P1, ulong P2, Vector3 P3, Quaternion P4, Vector3 P5, bool P6, object P7) => default; // 0x000000018515030C-0x00000001851504D8
		public bool __Gen_Wrap_64(out AudioChannelMask P0, out uint P1, out AudioChannelConfigType P2) {
			P0 = default;
			P1 = default;
			P2 = default;
			return default;
		} // 0x00000001851504D8-0x0000000185150644
		public bool __Gen_Wrap_65(object P0, uint P1, uint P2, uint P3, out ulong P4) {
			P4 = default;
			return default;
		} // 0x0000000185150644-0x000000018515077C
		public bool __Gen_Wrap_66(object P0, uint P1, out ulong P2) {
			P2 = default;
			return default;
		} // 0x000000018515077C-0x00000001851508A4
		public ulong __Gen_Wrap_67(object P0, uint P1) => default; // 0x00000001851508A4-0x000000018515097C
		public bool __Gen_Wrap_68(ulong P0) => default; // 0x000000018515097C-0x0000000185150A4C
		public bool __Gen_Wrap_69(bool P0) => default; // 0x0000000185150A4C-0x0000000185150B1C
		public void __Gen_Wrap_70(ulong P0, uint P1, uint P2) {} // 0x0000000185150C14-0x0000000185150CF8
		public uint __Gen_Wrap_71(int P0) => default; // 0x00000001850F26FC-0x00000001850F27B4
		public AsyncLoadBankTask __Gen_Wrap_72(object P0) => default; // 0x0000000185150CF8-0x0000000185150DE8
		public BankHandle __Gen_Wrap_73(object P0, object P1) => default; // 0x0000000185150DE8-0x0000000185150EF4
		public void __Gen_Wrap_74(out List<uint> P0) {
			P0 = default;
		} // 0x0000000185150EF4-0x0000000185150FEC
		public string __Gen_Wrap_75(ref AudioId P0) => default; // 0x0000000185150FEC-0x0000000185151120
		public int __Gen_Wrap_76(AudioId P0) => default; // 0x0000000185151120-0x0000000185151220
		public AudioId __Gen_Wrap_77(uint P0) => default; // 0x0000000185151220-0x000000018515130C
		public AudioId __Gen_Wrap_78(int P0) => default; // 0x000000018515130C-0x00000001851513E4
		public AudioId __Gen_Wrap_79(object P0) => default; // 0x00000001851513E4-0x00000001851514C0
		public uint[] __Gen_Wrap_80(object P0) => default; // 0x00000001851515C0-0x000000018515169C
		public bool __Gen_Wrap_81(ref AudioState P0, AudioState P1) => default; // 0x000000018515169C-0x00000001851517F4
		public bool __Gen_Wrap_82(ref AudioState P0, object P1) => default; // 0x00000001851517F4-0x0000000185151938
		public int __Gen_Wrap_83(ref AudioState P0) => default; // 0x0000000185151938-0x0000000185151A60
		public AudioDurationCallbackInfo __Gen_Wrap_84(ref AudioCallbackInfo P0) => default; // 0x0000000185151A60-0x0000000185151BE0
		public void __Gen_Wrap_85(object P0, Vector3 P1, Vector3 P2, Vector3 P3) {} // 0x0000000185151BE0-0x0000000185151D64
		public bool __Gen_Wrap_86(AudioLogChannel P0) => default; // 0x0000000185151D64-0x0000000185151E1C
		public void __Gen_Wrap_87(AudioLogChannel P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public void __Gen_Wrap_88(AudioLogChannel P0, object P1) {} // 0x00000001850F1370-0x00000001850F1438
		public float __Gen_Wrap_89(float P0, float P1, float P2) => default; // 0x0000000185151E1C-0x0000000185151F14
		public float __Gen_Wrap_90(Vector3 P0) => default; // 0x0000000185151FF0-0x00000001851520E8
		public void __Gen_Wrap_91(uint P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public void __Gen_Wrap_92(object P0, ref LinkedListNode<AudioAssetCache.EventCacheInfo> P1) {} // 0x00000001851520E8-0x0000000185152210
		public LinkedList<AudioAssetCache.EventCacheInfo> __Gen_Wrap_93(object P0) => default; // 0x0000000185152210-0x00000001851522EC
		public void __Gen_Wrap_94(ulong P0, ushort P1) {} // 0x00000001851522EC-0x00000001851523C8
		public void __Gen_Wrap_95(ulong P0, object P1) {} // 0x00000001851523C8-0x0000000185152490
		public string __Gen_Wrap_96(uint P0) => default; // 0x0000000185152490-0x0000000185152568
		public uint __Gen_Wrap_97(ReadOnlySpan<byte> P0) => default; // 0x0000000185152568-0x0000000185152658
		public uint __Gen_Wrap_98(IntPtr P0) => default; // 0x0000000185152658-0x0000000185152714
		public uint __Gen_Wrap_99(object P0, object P1) => default; // 0x0000000185152714-0x0000000185152800
		public ulong __Gen_Wrap_100(AkMemID P0) => default; // 0x000000018514CEAC-0x000000018514CF64
		public void __Gen_Wrap_101(AudioUIUtil.UIAudioType P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 58044
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get => default; } // 0x0000000185152CD4-0x0000000185152D80 
		object IEnumerator.Current { [IDTag(4)] get => default; } // 0x0000000185152DFC-0x0000000185152EA8 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000185152F24-0x0000000185153000
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose() {} // 0x0000000185152EA8-0x0000000185152F24
		[IDTag(1)]
		private bool MoveNext() => default; // 0x0000000185152C48-0x0000000185152CD4
		[IDTag(3)]
		void IEnumerator.Reset() {} // 0x0000000185152D80-0x0000000185152DFC
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 58045
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001851531E8-0x000000018515324C
		public static bool IsPatched(int id) => default; // 0x000000018269D7B0-0x000000018269D820
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001851530A4-0x0000000185153170
		public object CreateWrapper(int id) => default; // 0x0000000185153170-0x00000001851531E8
		public object InitWrapperArray(int len) => default; // 0x000000018515324C-0x00000001851532D8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000185153000-0x00000001851530A4
	}

	public enum IDMAP0 // TypeDefIndex: 58046
	{
		Beyond-Audio-AudioAdapter-PostEventExternal0 = 0,
		Beyond-Audio-AudioAdapter-_PostEventWithExternalSource0 = 1,
		Beyond-Audio-AudioAdapter-PostEventExternal1 = 2,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsSync0 = 3,
		Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsSync0 = 4,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsSync1 = 7,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync0 = 8,
		Beyond-Audio-AudioAdapter-_LoadAndPinEventsAsync0 = 9,
		Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsAsync0 = 10,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync1 = 19,
		Beyond-Audio-AudioId-op_Implicit0 = 20,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync2 = 21,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine0 = 22,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine1 = 23,
		Beyond-Audio-AudioAdapter-SetSwitch0 = 30,
		Beyond-Audio-AudioAdapter-SetSwitch1 = 31,
		Beyond-Audio-AudioAdapter-SetRtpc1 = 32,
		Beyond-Audio-AudioHashGenerator-Compute0 = 33,
		Beyond-Audio-AudioAdapter-SetRtpc0 = 34,
		Beyond-Audio-AudioAdapter-SetRtpc2 = 35,
		Beyond-Audio-AudioAdapter-SetRtpcValueByPlayingID0 = 36,
		Beyond-Audio-AudioActionQueueHelper-QueueRtpcAction0 = 37,
		Beyond-Audio-AudioAdapter-ResetRtpc0 = 38,
		Beyond-Audio-AudioAdapter-ResetRtpc1 = 39,
		Beyond-Audio-AudioAdapter-SeekOnEvent1 = 40,
		Beyond-Audio-AudioAdapter-SeekOnEvent0 = 41,
		Beyond-Audio-AudioActionQueueHelper-QueueSeekAction0 = 42,
		Beyond-Audio-AudioAdapter-SeekOnEvent2 = 43,
		Beyond-Audio-AudioAdapter-SeekOnEvent3 = 44,
		Beyond-Audio-AudioAdapter-TryGetPlayingPosition0 = 45,
		Beyond-Audio-AudioAdapter-IsPlaying0 = 46,
		Beyond-Audio-AudioAdapter-ReleaseAllCachedEventsSync0 = 47,
		Beyond-Audio-AudioAssetHelper-ReleaseAllCachedEventsSync0 = 48,
		Beyond-Audio-AudioAssetCache-GetCachedAssetCount0 = 49,
		Beyond-Audio-AudioAssetHelper-_DoGc0 = 50,
		Beyond-Audio-AudioAssetCache-GetLeastActiveAssetAndUncache0 = 51,
		Beyond-Audio-AudioAssetCache-Cache-RemoveFirst0 = 52,
		Beyond-Audio-AudioAssetHelper-_TryConsumePendingLoadRequests0 = 53,
		Beyond-Audio-AudioAssetHelper-_ConsumePendingLoadRequests0 = 54,
		Beyond-Audio-AudioAssetHelper-_DoLoadEventAsync0 = 55,
		Beyond-Audio-AudioAssetCache-ActivateAsset0 = 56,
		Beyond-Audio-AudioAssetCache-Cache-Remove0 = 57,
		Beyond-Audio-AudioAssetHelper-_TryDequeueAndInvokeCallback0 = 58,
		Beyond-Audio-AudioAdapter-SetLargePositions0 = 59,
		Beyond-Audio-AudioPositionArrayProxy-GetRawArray0 = 60,
		Beyond-Audio-AudioAdapter-SetDefaultListener0 = 61,
		Beyond-Audio-AudioAdapter-SetListener0 = 62,
		Beyond-Audio-AudioAdapter-TryGetRealPlayingId0 = 63,
		Beyond-Audio-AudioAdapter-SetDefaultEmitter0 = 64,
		Beyond-Audio-AudioAdapter-SetAudioLanguage0 = 65,
		Beyond-Audio-AudioVFSLoader-TryLoadLanguagePck0 = 66,
		Beyond-Audio-AudioVFSLoader-_GetVfsBlockTypeFromLanguage0 = 67,
		Beyond-Audio-AudioVFSLoader-_DoLoadLanguageAndHotfixPck0 = 68,
		Beyond-Audio-AudioVFSLoader-_UnloadPcks0 = 69,
		Beyond-Audio-AudioVFSLoader-_TryLoadPcksFromVfsInfo0 = 70,
		Beyond-Audio-AudioVFSLoader-_DoLoadPcksFromVfs0 = 71,
		Beyond-Audio-AudioVFSLoader-_DoLoadSinglePckFromVfs0 = 72,
		Beyond-Audio-AudioAdapter-SetDistanceProbe0 = 73,
		Beyond-Audio-AudioAdapter-SetAudioEngineInitSetting0 = 74,
		Beyond-Audio-AudioAdapter-UnsetAudioEngineInitSetting0 = 75,
		Beyond-Audio-AudioAdapter-InitWwise0 = 76,
		Beyond-Audio-AudioAdapter-_InitInternal0 = 77,
		Beyond-Audio-AudioAdapter-_ResetStaticFields0 = 78,
		Beyond-Audio-AudioAdapter-Context-Reset0 = 79,
		Beyond-Audio-AudioAdapter-PayloadPostEvent-OnRecycle0 = 80,
		Beyond-Audio-AudioAssetHelper-ResetStaticFields0 = 84,
		Beyond-Audio-AudioAssetCache-Reset0 = 85,
		Beyond-Audio-AudioAssetCache-Cache-Clear0 = 86,
		Beyond-Audio-AudioAdapter-_InitAndroidActivityEnvironment0 = 90,
		Beyond-Audio-AudioCallbackMessageParser-Set0 = 91,
		Beyond-Audio-AudioMemoryMonitor-Init0 = 92,
		Beyond-Audio-AudioAdapter-Context-PostSoundEngineInit0 = 93,
		Beyond-Audio-AudioVFSLoader-InitBasePaths0 = 94,
		Beyond-Audio-AudioVFSLoader-VfsLoadedInfo-Create0 = 95,
		Beyond-Audio-AudioAdapter-LoadInitResources0 = 96,
		Beyond-Audio-AudioVFSLoader-TryLoadInitPck0 = 97,
		Beyond-Audio-AudioAdapter-TermWwise0 = 98,
		Beyond-Audio-AudioAdapter-_ReleaseInternal0 = 99,
		Beyond-Audio-AudioActionQueueHelper-ClearQueue0 = 100,
		Beyond-Audio-AudioAdapter-_OnBeforeTerminate0 = 101,
		Beyond-Audio-AudioAssetHelper-HasPreparingEvents0 = 102,
		Beyond-Audio-AudioAssetHelper-UnPrepareAllEventsSync0 = 103,
		Beyond-Audio-AudioAssetCache-GetAllUsingAssetsAndRelease0 = 104,
		Beyond-Audio-AudioMemoryMonitor-Release0 = 105,
		Beyond-Audio-AudioAdapter-ReloadInitResources0 = 106,
		Beyond-Audio-AudioBankManager-Reset0 = 107,
		Beyond-Audio-AudioVFSLoader-UnloadAll0 = 108,
		Beyond-Audio-AudioAdapter-MemoryShrink0 = 109,
		Beyond-Audio-AudioAdapter-_OnEventPreparedDoPostEvent0 = 110,
		Beyond-Audio-AudioAdapter-_OnEventCallback0 = 111,
		Beyond-Audio-AudioAdapter-_OnExternalSourceEventCallback0 = 112,
		Beyond-Audio-AudioAdapter-_PostEvent0 = 113,
		Beyond-Audio-AudioAdapter-_ExecuteActionOnPlayingId0 = 114,
		Beyond-Audio-AudioActionQueueHelper-QueueExecuteAction0 = 115,
		Beyond-Audio-AudioAdapter-_SampleAllData0 = 116,
		Beyond-Audio-AudioAdapter-_SampleMemoryOnly0 = 117,
		Beyond-Audio-AudioAdapter-StartProfileCapture0 = 118,
		Beyond-Audio-AudioAdapter-StopProfileCapture0 = 119,
		Beyond-Audio-AudioAdapter-GetResourceSummaryData0 = 120,
		Beyond-Audio-AudioAdapter-GetGlobalMemoryStats0 = 121,
		Beyond-Audio-AudioAdapter-GetExtraMemoryStats0 = 122,
		Beyond-Audio-AudioAdapter-SetEnableSpatialAudio0 = 123,
		Beyond-Audio-AudioAdapter-SetObjectObstructionAndOcclusion0 = 124,
		Beyond-Audio-AudioAdapter-SetGeometry0 = 125,
		Beyond-Audio-AudioAdapter-SetGeometryInstance0 = 126,
		Beyond-Audio-AudioAdapter-SetRoom0 = 127,
		Beyond-Audio-AudioAdapter-SetPortal0 = 128,
		Beyond-Audio-AudioAdapter-Device-GetSpeakerConfiguration0 = 129,
		Beyond-Audio-AudioAdapter-Device-AddOutputDevice0 = 130,
		Beyond-Audio-AudioAdapter-Device-AddOutput0 = 131,
		Beyond-Audio-AudioAdapter-Device-GetOutputDeviceId0 = 132,
		Beyond-Audio-AudioAdapter-Device-RemoveOutputDevice0 = 133,
		Beyond-Audio-AudioAdapter-Device-Switch3DOutput0 = 134,
		Beyond-Audio-AudioAdapter-Device-SetOutputDeviceEffect0 = 135,
		Beyond-Audio-AudioAdapter-Device-GetMmDeviceIdFromScePadHandle0 = 136,
		Beyond-Audio-BankHandle-Dispose0 = 137,
		Beyond-Audio-AudioBankManager-UnloadBank0 = 139,
		Beyond-Audio-BankHandle-DecRef0 = 140,
		Beyond-Audio-BankHandle-IncRef0 = 142,
		Beyond-Audio-AsyncLoadBankTask-LoadBanksAsync0 = 143,
		Beyond-Audio-AsyncLoadBankTask-MoveNext0 = 144,
		Beyond-Audio-AsyncLoadBankTask-Reset0 = 145,
		Beyond-Audio-AsyncLoadBankTask-Dispose0 = 146,
		Beyond-Audio-AudioBankManager-LoadMainPCK0 = 147,
		Beyond-Audio-AudioVFSLoader-TryLoadMainPck0 = 148,
		Beyond-Audio-AudioBankManager-LoadBankAsync0 = 149,
		Beyond-Audio-AudioBankManager-_LoadBankCallback0 = 150,
		Beyond-Audio-AudioBankManager-UnloadAllBanks0 = 153,
		Beyond-Audio-AudioBankManager-IsBankLoaded0 = 154,
		Beyond-Audio-AudioBankManager-LoadDebugFilePackage0 = 155,
		Beyond-Audio-AudioBankManager-_PreResetBasePath0 = 156,
		Beyond-Audio-AudioBankManager-_PostResetBasePath0 = 157,
		Beyond-Audio-AudioBankManager-AddDebugBankPath0 = 158,
		Beyond-Audio-AudioId-GetName0 = 159,
		Beyond-Audio-AudioId-op_Implicit1 = 160,
		Beyond-Audio-AudioId-op_Implicit2 = 161,
		Beyond-Audio-AudioId-op_Implicit3 = 162,
		Beyond-Audio-AudioId-op_Implicit4 = 163,
		Beyond-Audio-AudioIdExtensions-ToUIntArray0 = 164,
		Beyond-Audio-AudioState-Equals0 = 165,
		Beyond-Audio-AudioState-Equals1 = 166,
		Beyond-Audio-AudioState-GetHashCode0 = 167,
		Beyond-Audio-AudioCallbackInfo-CastToDurationCallbackInfo0 = 168,
		Beyond-Audio-AudioPositionArrayProxy-Add0 = 169,
		Beyond-Audio-AudioPositionArrayProxy-Reset0 = 170,
		Beyond-Audio-AudioLogger-IsChannelEnabled0 = 171,
		Beyond-Audio-AudioLogger-EnableChannel0 = 172,
		Beyond-Audio-AudioLogger-DisableChannel0 = 173,
		Beyond-Audio-AudioLogger-SetChannels0 = 174,
		Beyond-Audio-AudioLogger-Log0 = 175,
		Beyond-Audio-AudioLogger-_DoLog0 = 176,
		Beyond-Audio-AudioLogger-LogWarning0 = 177,
		Beyond-Audio-AudioLogger-_DoLogWarning0 = 178,
		Beyond-Audio-AudioLogger-LogError0 = 179,
		Beyond-Audio-AudioLogger-_DoLogError0 = 180,
		Beyond-Audio-AudioAcousticUtil-RT60DecayTime0 = 181,
		Beyond-Audio-AudioAcousticUtil-PreDelayTime0 = 182,
		Beyond-Audio-AudioAcousticUtil-CriticalDistance0 = 183,
		Beyond-Audio-AudioAcousticUtil-ReverbIntensity0 = 184,
		Beyond-Audio-AudioAcousticUtil-ErIntensity0 = 185,
		Beyond-Audio-AudioActionQueueHelper-ConsumeQueue0 = 186,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeExecute0 = 187,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeRtpc0 = 188,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeSeek0 = 189,
		Beyond-Audio-AudioAssetCache-PinEvent0 = 190,
		Beyond-Audio-AudioAssetCache-UnpinEvent0 = 191,
		Beyond-Audio-AudioAssetCache-DeactivateAsset0 = 192,
		Beyond-Audio-AudioAssetCache-Cache-AddLast0 = 193,
		Beyond-Audio-AudioAssetCache-ForceReleaseCachedAsset0 = 194,
		Beyond-Audio-AudioAssetCache-_NotifyDebugger0 = 195,
		Beyond-Audio-AudioAssetCache-_NotifyDebuggerCacheHit0 = 196,
		Beyond-Audio-AudioAssetCache-_ResetDebugger0 = 197,
		Beyond-Audio-AudioAssetCache-_PinnedEventLeakDetect0 = 198,
		Beyond-Audio-AudioAssetCache-Cache-get_lruCachedEventsList0 = 199,
		Beyond-Audio-AudioAssetHelper-SetMemoryBudget0 = 200,
		Beyond-Audio-AudioAssetHelper-_OnUnpreparedDoUnloadBank0 = 201,
		Beyond-Audio-AudioAssetHelper-_OnDoneUnloadBank0 = 202,
		Beyond-Audio-AudioAssetHelper-_OnBankLoadedDoPrepareEvent0 = 203,
		Beyond-Audio-AudioAssetHelper-_OnDonePrepareEvent0 = 204,
		Beyond-Audio-AudioAssetHelper-_RemoveLoadingDebug0 = 205,
		Beyond-Audio-AudioAssetHelper-_AddLoadingDebug0 = 206,
		Beyond-Audio-AudioAssetHelper-_ClearLoadingDebug0 = 207,
		Beyond-Audio-AudioDebugInfoContainer-SetAudioObjectName0 = 208,
		Beyond-Audio-AudioDebugInfoContainer-RemoveAudioObjectName0 = 209,
		Beyond-Audio-AudioDebugInfoContainer-ForceGetEventName0 = 210,
		Beyond-Audio-AudioDebugInfoContainer-ForceGetRtpcName0 = 211,
		Beyond-Audio-AudioHashGenerator-Compute2 = 212,
		Beyond-Audio-AudioHashGenerator-Compute1 = 213,
		Beyond-Audio-AudioHashGenerator-Compute3 = 214,
		Beyond-Audio-AudioHashGenerator-Compute4 = 215,
		Beyond-Audio-AudioMemoryMonitor-GetGlobalMemoryStats0 = 216,
		Beyond-Audio-AudioMemoryMonitor-GetExtraMemoryStats0 = 217,
		Beyond-Audio-AudioMemoryMonitor-GetUsedMemoryByCategory0 = 218,
		Beyond-Audio-AudioUIUtil-Init0 = 219,
		Beyond-Audio-AudioUIUtil-Release0 = 220,
		Beyond-Audio-AudioUIUtil-PostUIEvent0 = 221,
		Beyond-Audio-AudioUIUtil-PostUIEvent1 = 222,
		Beyond-Audio-AudioUIUtil-OnUIPanelClose0 = 223,
		Beyond-Audio-AudioUIUtil-OnUIPanelOpen0 = 224
	}
}
