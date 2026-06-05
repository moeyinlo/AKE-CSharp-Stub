/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.Audio;
using Beyond.PoolCore;
using Beyond.VFS;
using IFix.Core;
using Unity.Profiling;
using UnityEngine;

// Image 59: Audio.Beyond.dll - Assembly: Audio.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58934-59016

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 59012
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _662FC6EB33F1099AA2416EFBD9D5716B0AC7D68036E4C225784C78C03695D2AC; // 0x00 // Static value (base64): S7HlCQ17hMDxZ40p - Metadata: 0x020801DC

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 59011
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond.Audio
{
	public static class AudioAdapter // TypeDefIndex: 58949
	{
		// Fields
		private static readonly AkCallbackManager.BankCallback ON_EVENT_PREPARED_DO_POST_EVENT; // 0x00
		private static readonly AkCallbackManager.EventCallback ON_EVENT_CALLBACK; // 0x08
		private static readonly AkCallbackManager.EventCallback ON_EXTERNAL_SOURCE_EVENT_CALLBACK; // 0x10
	
		// Properties
		public static ulong listenerObjId { get; } // 0x00000001848C0B00-0x00000001848C0B90 
	
		// Nested types
		private static class Context // TypeDefIndex: 58942
		{
			// Fields
			public static ulong s_listenerObjId; // 0x00
			public static ulong s_2dEmitterObjectId; // 0x08
			public static uint s_playingIdInternal; // 0x10
			public static Dictionary<uint, uint> s_playingIdLut; // 0x18
			public static ObjectPool<PayloadPostEvent> s_payloadPool; // 0x20
			public static readonly AkExternalSourceInfoArray S_EXTERNAL_SOURCE_INFO_ARRAY; // 0x28
			public static AkRoomParams s_reusableAkRoomParams; // 0x30
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 58941
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<PayloadPostEvent> __9__8_0; // 0x08
	
				// Constructors
				static __c() {} // 0x000000018733D570-0x000000018733D5C0
				public __c() {} // 0x00000001856062D0-0x0000000185606390
	
				// Methods
				internal PayloadPostEvent _Reset_b__8_0() => default; // 0x000000018733B234-0x000000018733B2BC
			}
	
			// Constructors
			static Context() {} // 0x000000018733B4E0-0x000000018733B59C
	
			// Methods
			public static void PostSoundEngineInit() {} // 0x000000018733B408-0x000000018733B480
			public static void Reset() {} // 0x000000018733B480-0x000000018733B4E0
		}
	
		private class PayloadPostEvent // TypeDefIndex: 58943
		{
			// Fields
			public ulong audioObjectId; // 0x10
			public uint callbackType; // 0x18
			public uint internalPlayingId; // 0x1C
			public AudioEventCallback callback; // 0x20
			public object cookie; // 0x28
	
			// Constructors
			public PayloadPostEvent() {} // 0x000000018733B2BC-0x000000018733B354
	
			// Methods
			public static void OnRecycle(PayloadPostEvent obj) {} // 0x000000018733B354-0x000000018733B408
		}
	
		public static class Device // TypeDefIndex: 58944
		{
			// Methods
			public static bool GetSpeakerConfiguration(out AudioChannelMask channelMask, out uint numChannels, out AudioChannelConfigType configType) {
				channelMask = default;
				numChannels = default;
				configType = default;
				return default;
			} // 0x000000018733B1B8-0x000000018733B234
			public static bool AddOutputDevice(string deviceName, uint deviceId, uint numChannels, uint speakerSetup, out ulong outDeviceId) {
				outDeviceId = default;
				return default;
			} // 0x0000000184BDE950-0x0000000184BDEB10
			public static bool AddOutput(string shareSetName, uint deviceId, out ulong outId) {
				outId = default;
				return default;
			} // 0x000000018733B078-0x000000018733B1B8
			public static ulong GetOutputDeviceId(string shareSetName, uint deviceId) => default; // 0x000000018733C94C-0x000000018733C99C
			public static bool RemoveOutputDevice(ulong output) => default; // 0x000000018733AFDC-0x000000018733B030
			public static bool Switch3DOutput(bool use3DDevice) => default; // 0x000000018733BA94-0x000000018733BAE8
			public static void SetOutputDeviceEffect(ulong outputDeviceId, uint effectIdx, uint shareSetId) {} // 0x000000018733B030-0x000000018733B078
			public static uint GetMmDeviceIdFromScePadHandle(int scePadHandle) => default; // 0x000000018733CBF4-0x000000018733CC40
		}
	
		private sealed class _LoadAndPinEventsCoroutine_d__26 : IEnumerator<object> // TypeDefIndex: 58945
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ICollection<string> events; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184B4FF70-0x0000000184B4FFF0 
			object IEnumerator.Current { get => default; } // 0x000000018733A90C-0x000000018733AB74 
	
			// Constructors
			public _LoadAndPinEventsCoroutine_d__26() {} // Dummy constructor
			public _LoadAndPinEventsCoroutine_d__26(int __1__state) {} // 0x000000018733CC40-0x000000018733CCA0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018733AEB0-0x000000018733AF28
			private bool MoveNext() => default; // 0x000000018733AC7C-0x000000018733AEB0
			void IEnumerator.Reset() {} // 0x0000000184B4FFF0-0x0000000184B501F0
		}
	
		private sealed class __c__DisplayClass99_0 // TypeDefIndex: 58946
		{
			// Fields
			public int doneCount; // 0x10
			public AkCallbackManager.BankCallback __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass99_0() {} // 0x000000018733AC00-0x000000018733AC7C
	
			// Methods
			internal void __DoLoadAndPinEventsSync_b__0(uint _, IntPtr _, AKRESULT _, object _) {} // 0x000000018733AB74-0x000000018733AC00
		}
	
		private sealed class __c__DisplayClass100_0 // TypeDefIndex: 58947
		{
			// Fields
			public int doneCount; // 0x10
			public AkCallbackManager.BankCallback __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass100_0() {} // 0x000000018733C6D0-0x000000018733C72C
	
			// Methods
			internal void __DoLoadAndPinEventsAsync_b__0(uint _, IntPtr _, AKRESULT _, object _) {} // 0x000000018733C678-0x000000018733C6D0
		}
	
		private sealed class __DoLoadAndPinEventsAsync_d__100 : IEnumerator<object> // TypeDefIndex: 58948
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public IList<uint> events; // 0x20
			public Action<object> onDone; // 0x28
			public object payload; // 0x30
			private __c__DisplayClass100_0 __8__1; // 0x38
			private int _allCount_5__2; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181380BB0-0x0000000181381520 
			object IEnumerator.Current { get => default; } // 0x0000000184A7B560-0x0000000184A7B5F0 
	
			// Constructors
			public __DoLoadAndPinEventsAsync_d__100() {} // Dummy constructor
			public __DoLoadAndPinEventsAsync_d__100(int __1__state) {} // 0x000000018733CB9C-0x000000018733CBF4
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018733C72C-0x000000018733C7CC
			private bool MoveNext() => default; // 0x000000018733C7CC-0x000000018733C880
			void IEnumerator.Reset() {} // 0x0000000181381520-0x0000000181381EA0
		}
	
		// Constructors
		static AudioAdapter() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static uint PostEvent(string eventName) => default; // 0x000000018733C568-0x000000018733C61C
		public static uint PostEvent(uint eventId) => default; // 0x0000000185905940-0x0000000185905A80
		public static uint PostEvent(string eventName, ulong audioObjectId) => default; // 0x000000018733B950-0x000000018733B9EC
		public static uint PostEvent(uint eventId, ulong audioObjectId) => default; // 0x000000018733B9EC-0x000000018733BA94
		public static uint PostEvent(string eventName, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null) => default; // 0x000000018733A6F4-0x000000018733A7E0
		public static uint PostEvent(uint eventId, in AudioCallbackType callbackType, in AudioEventCallback callback, object cookie = null) => default; // 0x000000018733A7E0-0x000000018733A8CC
		public static uint PostEvent(string eventName, ulong audioObjectId, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null) => default; // 0x000000018733BE28-0x000000018733BEF8
		public static uint PostEvent(uint eventId, ulong audioObjectId, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null) => default; // 0x000000018733BBD8-0x000000018733BD38
		public static uint PostEventExternal(string eventName, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x0207FF77 */) => default; // 0x000000018733BAE8-0x000000018733BBD8
		public static uint PostEventExternal(uint eventId, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x0207FF78 */) => default; // 0x000000018733BD38-0x000000018733BE28
		public static void StopByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x0207FF79 */) {} // 0x000000018733CA9C-0x000000018733CB9C
		public static void PauseByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x0207FF7B */) {} // 0x0000000185773FC0-0x00000001857740B0
		public static void ResumeByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x0207FF7D */) {} // 0x000000018733C61C-0x000000018733C678
		public static void PinEvent(uint eventId) {} // 0x000000018733B5F4-0x000000018733B63C
		public static void UnpinEvent(uint eventId) {} // 0x000000018733B59C-0x000000018733B5F4
		public static void UnpinEvent(string eventName) {} // 0x000000018733CCA0-0x000000018733CCE8
		public static void LoadAndPinEventsSync(IList<uint> events) {} // 0x000000018733C448-0x000000018733C4F8
		public static void LoadAndPinEventsSync(ICollection<string> events) {} // 0x000000018733C90C-0x000000018733C94C
		public static void LoadAndPinEventsAsync(IList<uint> events, Action<object> onDone = null, object payload = null) {} // 0x000000018733C8C0-0x000000018733C90C
		public static void LoadAndPinEventsAsync(IList<AudioId> events, Action<object> onDone = null, object payload = null) {} // 0x0000000184B51770-0x0000000184B517D0
		public static void LoadAndPinEventsAsync(ICollection<string> events, Action<object> onDone = null, object payload = null) {} // 0x00000001851E7550-0x00000001851E7620
		public static IEnumerator LoadAndPinEventsCoroutine(IList<uint> events) => default; // 0x0000000184A7F780-0x0000000184A7F890
		public static IEnumerator LoadAndPinEventsCoroutine(ICollection<string> events) => default; // 0x000000018733C000-0x000000018733C0CC
		public static void SetState(string stateGroup, string stateName) {} // 0x0000000184733670-0x0000000184733710
		public static void SetState(uint stateGroup, uint stateName) {} // 0x0000000184A7F710-0x0000000184A7F780
		public static bool TryGetState(uint stateGroupId, out uint stateId) {
			stateId = default;
			return default;
		} // 0x0000000184958060-0x00000001849580D0
		public static void SetSwitch(uint switchGroup, uint switchValue, ulong audioObjectId) {} // 0x000000018733BF54-0x000000018733C000
		public static void SetSwitch(string switchGroup, string switchValue, ulong audioObjectId) {} // 0x000000018733A5D8-0x000000018733A5F8
		public static void SetRtpc(string rtpcName, float rtpcValue, int fadeTimeMs = 0 /* Metadata: 0x0207FF7F */) {} // 0x0000000185F05180-0x0000000185F05260
		public static void SetRtpc(uint rtpcId, float rtpcValue, int fadeTimeMs = 0 /* Metadata: 0x0207FF80 */) {} // 0x000000018733CCE8-0x000000018733CD50
		public static void SetRtpc(string rtpcName, float rtpcValue, ulong audioObjectId) {} // 0x0000000184957DE0-0x0000000184957E50
		public static void SetRtpc(uint rtpcId, float rtpcValue, ulong audioObjectId) {} // 0x000000018733CA28-0x000000018733CA9C
		public static void SetRtpc(uint rtpcId, float rtpcValue, ulong audioObjectId, int fadeTimeMs) {} // 0x0000000184957E50-0x0000000184957EC0
		public static void SetRtpcValueByPlayingID(uint rtpcId, float rtpcValue, uint playingId, int fadeTimeMs) {} // 0x000000018733B63C-0x000000018733B748
		public static void ResetRtpc(uint rtpcId, ulong audioObjectId, int fadeTimeMs) {} // 0x000000018733B8D8-0x000000018733B950
		public static void ResetRtpc(string rtpcName, ulong audioObjectId, int fadeTimeMs = 100 /* Metadata: 0x0207FF81 */) {} // 0x000000018733C9DC-0x000000018733CA28
		public static bool GetRtpcValue(string rtpcName, ulong audioObjectId, uint playingId, out float value, ref int valueType) {
			value = default;
			return default;
		} // 0x000000018733CD50-0x000000018733CD90
		public static bool GetRtpcValue(uint rtpcId, ulong audioObjectId, uint playingId, out float value, ref int valueType) {
			value = default;
			return default;
		} // 0x000000018733A8CC-0x000000018733A90C
		public static void SeekOnEvent(string eventName, ulong audioObjectId, int timeMs, bool toNearestMarker, uint playingId) {} // 0x000000018733BEF8-0x000000018733BF54
		public static void SeekOnEvent(uint eventId, ulong audioObjectId, int timeMs, bool toNearestMarker, uint playingId) {} // 0x000000018733AF28-0x000000018733AF9C
		public static void SeekOnEvent(string eventName, int timeMs, bool toNearestMarker, uint playingId) {} // 0x000000018733AF9C-0x000000018733AFDC
		public static void SeekOnEvent(uint eventId, int timeMs, bool toNearestMarker, uint playingId) {} // 0x0000000181382580-0x0000000181382F40
		public static bool TryGetPlayingPosition(uint playingId, out int posTimeMs, bool extrapolate = true /* Metadata: 0x0207FF83 */) {
			posTimeMs = default;
			return default;
		} // 0x0000000181381EA0-0x0000000181382580
		public static bool IsPlaying(uint playingId) => default; // 0x000000018137D2A0-0x000000018137E380
		public static uint SetScalingFactor(ulong audioObjectId, float factor) => default; // 0x000000018137E380-0x000000018137F460
		public static bool RegisterGameObject(ulong audioObjectId) => default; // 0x000000018137F460-0x0000000181380540
		public static bool RegisterGameObject(ulong audioObjectId, string name) => default; // 0x0000000181380540-0x0000000181380BB0
		public static bool UnregisterGameObject(ulong audioObjectId) => default; // 0x0000000184A84820-0x0000000184A849B0
		public static void SetPosition(ulong audioObjectId, Vector3 pos, Vector3 forward, Vector3 up) {} // 0x000000018733D25C-0x000000018733D4F0
		public static void StopAll() {} // 0x000000018733D1D0-0x000000018733D25C
		public static void StopAllOnObject(ulong audioObjectId) {} // 0x00000001859E1A20-0x00000001859E1AB0
		public static void ReleaseAllCachedEventsSync() {} // 0x000000018459A130-0x000000018459A340
		public static void SetLargePositions(ulong audioObjectId, AudioPositionArrayProxy positions, AudioLargeType type = AudioLargeType.Sum /* Metadata: 0x0207FF84 */) {} // 0x0000000184CD8C40-0x0000000184CD9500
		public static void SetDefaultListener(ulong audioObjectId) {} // 0x0000000184CD84D0-0x0000000184CD8680
		public static void SetListener(ulong audioObjectId, ulong listenerId) {} // 0x0000000184599F30-0x000000018459A130
		public static bool TryGetRealPlayingId(uint playingId, out uint realPlayingId) {
			realPlayingId = default;
			return default;
		} // 0x0000000184BDEB10-0x0000000184BDEE40
		public static void SetDefaultEmitter(ulong audioObjectId) {} // 0x0000000184733710-0x0000000184733920
		public static void SetAudioLanguage(string language) {} // 0x000000018733D098-0x000000018733D0F0
		public static void SetDistanceProbe(ulong probeObjectId = 18446744073709551615 /* Metadata: 0x0207FF85 */) {} // 0x000000018733D0F0-0x000000018733D1D0
		public static uint ComputeIdFromString(string name) => default; // 0x000000018733CD90-0x000000018733D098
		public static void SetAudioEngineInitSetting(AudioEngineInitSetting settings) {} // 0x0000000184B501F0-0x0000000184B502A0
		public static void UnsetAudioEngineInitSetting() {} // 0x0000000185FADBB0-0x0000000185FADBD0
		public static bool InitWwise() => default; // 0x0000000185492010-0x0000000185492020
		public static void TermWwise(bool hgDeepTerm = false /* Metadata: 0x0207FF8D */) {} // 0x0000000185492010-0x0000000185492020
		public static void LoadInitResources() {} // 0x000000018733D4F0-0x000000018733D530
		public static void ReloadInitResources() {} // 0x000000018733D530-0x000000018733D570
		public static void RenderAudio() {} // 0x000000018733C880-0x000000018733C8C0
		public static void Suspend(bool renderAnyway) {} // 0x000000018733C99C-0x000000018733C9DC
		public static void WakeupFromSuspend() {} // 0x000000018733A6B4-0x000000018733A6F4
		public static void InitScePad() {} // 0x000000018733A65C-0x000000018733A6B4
		public static void SetAudioMemoryBudget(ulong inMemoryBytes, ushort inGcCount = 10 /* Metadata: 0x0207FF8E */) {} // 0x000000018733A5F8-0x000000018733A65C
		public static void LogToWwise(string msg, bool isError = false /* Metadata: 0x0207FF90 */, uint playingId = 0 /* Metadata: 0x0207FF91 */, ulong goId = 0 /* Metadata: 0x0207FF92 */) {} // 0x00000001854FF640-0x00000001854FF740
		public static void MemoryShrink() {} // 0x000000018733C0CC-0x000000018733C198
		public static void TouchAudioHotfixPlaceholder() {} // 0x00000001841257F0-0x0000000184125AE0
		public static void TouchAudioHotfixPlaceholderArgs(string[] stringArray, int[] intArray, uint[] uintArray, float[] floatArray, bool[] boolArray, long[] longArray, ulong[] ulongArray, double[] doubleArray, object[] objects) {} // 0x0000000184B68BA0-0x0000000184B68CE0
		public static void AudioHotfixPlaceholder1(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null) {} // 0x0000000184B67F20-0x0000000184B681E0
		public static void AudioHotfixPlaceholder2(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null) {} // 0x000000018733C208-0x000000018733C448
		public static void AudioHotfixPlaceholder3(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null) {} // 0x000000018733C198-0x000000018733C208
		public static void LoadExtraPckFromPath(string path) {} // 0x000000018733C4F8-0x000000018733C568
		private static bool _InitInternal() => default; // 0x000000018733B888-0x000000018733B8D8
		private static void _ReleaseInternal(bool hgDeepTerm = false /* Metadata: 0x0207FF9A */) {} // 0x000000018733B7E8-0x000000018733B838
		private static void _OnBeforeTerminate() {} // 0x000000018733B798-0x000000018733B7E8
		private static void _ResetStaticFields() {} // 0x000000018733B748-0x000000018733B798
		private static void _OnEventPreparedDoPostEvent(uint inId, IntPtr _, AKRESULT __, object inCookie) {} // 0x000000018733B838-0x000000018733B888
		private static void _OnEventCallback(object inCookie, AkCallbackType inType, AkCallbackInfo inInfo) {} // 0x0000000184CD6E10-0x0000000184CD6F70
		private static void _OnExternalSourceEventCallback(object inCookie, AkCallbackType inType, AkCallbackInfo inInfo) {} // 0x0000000185D21C70-0x0000000185D21D30
		private static uint _PostEvent(uint eventId, ulong audioObjectId, AudioCallbackType callbackType = AudioCallbackType.None /* Metadata: 0x0207FF9B */, AudioEventCallback originCallback = null, object originCookie = null) => default; // 0x000000018550D850-0x000000018550DAD0
		private static uint _PostEventWithExternalSource(uint eventId, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x0207FF9C */) => default; // 0x000000018599AFB0-0x000000018599B0A0
		private static void _ExecuteActionOnPlayingId(AkActionOnEventType type, uint playingId, int durationMs = 100 /* Metadata: 0x0207FF9D */) {} // 0x0000000185F6CC70-0x0000000185F6CCD0
		private static uint _GetInternalPlayingId() => default; // 0x0000000185492010-0x0000000185492020
		private static void _LoadAndPinEventsAsync(in IList<uint> events, in Action<object> onDone = null, in object payload = null) {} // 0x0000000184902600-0x0000000184902640
		private static void _DoLoadAndPinEventsSync(IList<uint> events) {} // 0x00000001851756F0-0x0000000185175740
		private static IEnumerator _DoLoadAndPinEventsAsync(IList<uint> events, Action<object> onDone = null, object payload = null) => default; // 0x0000000185492010-0x0000000185492020
		private static void _InitAndroidActivityEnvironment() {} // 0x0000000184A849B0-0x0000000184A84A90
		internal static void SetUprSamplingEnabled(bool isEnabled) {} // 0x0000000187340210-0x000000018734036C
		private static void _ProfilerUpdate() {} // 0x000000018734036C-0x000000018734044C
		private static void _SampleAllData() {} // 0x00000001873404C4-0x0000000187340550
		private static void _SampleMemoryOnly() {} // 0x0000000187340550-0x00000001873405F0
		public static void StartProfileCapture(string fileName = null) {} // 0x0000000184A7A420-0x0000000184A7A5C0
		public static void StopProfileCapture() {} // 0x00000001873405F0-0x0000000187340690
		public static AkResourceMonitorDataSummary GetResourceSummaryData() => default; // 0x000000018734044C-0x00000001873404C4
		public static AudioMemoryMonitor.FGlobalMemoryStats GetGlobalMemoryStats() => default; // 0x0000000181378230-0x0000000181378240
		public static AudioMemoryMonitor.FExtraMemoryStats GetExtraMemoryStats() => default; // 0x0000000185492010-0x0000000185492020
		public static void SetEnableSpatialAudio(bool enable) {} // 0x00000001873411FC-0x000000018734148C
		public static void SetObjectObstructionAndOcclusion(ulong audioObjectId, float obstructionLevel, float occlusionLevel) {} // 0x0000000181377E40-0x0000000181377E50
		public static bool SetGeometry(ulong geoId, Vector3[] vertices, ushort[] triangles, AudioAcousticSurfaceData[] surfaceData, ushort[] surfaceIdx, bool enableDiffraction = true /* Metadata: 0x0207FF9F */, bool enableEdgeDiffraction = false /* Metadata: 0x0207FFA0 */) => default; // 0x000000018734148C-0x00000001873414D8
		public static bool SetGeometryInstance(ulong instanceId, Vector3 pos, Vector3 scale, Quaternion rot, ulong geoId, bool useReflectionAndDiffraction = false /* Metadata: 0x0207FFA1 */) => default; // 0x0000000181377E40-0x0000000181377E50
		public static bool SetRoom(ulong roomId, AudioRoomData roomData, ulong geoInstanceId, string roomName = "room" /* Metadata: 0x0207FFA2 */) => default; // 0x0000000185492010-0x0000000185492020
		public static bool SetPortal(ulong portalId, ulong roomIdA, ulong roomIdB, Vector3 pos, Quaternion rot, Vector3 extent, bool enabled, string portalName = "portal" /* Metadata: 0x0207FFA7 */) => default; // 0x00000001813A28C0-0x00000001813A28D0
		public static bool SetPortalObstructionAndOcclusion(ulong portalId, float obstruction, float occlusion) => default; // 0x0000000185492010-0x0000000185492020
		public static bool SetReverbZone(ulong reverbZoneId, ulong parentRoom, float transitionWidth) => default; // 0x00000001813A28C0-0x00000001813A28D0
		public static bool RemoveRoom(ulong roomId) => default; // 0x0000000181378230-0x0000000181378240
		public static bool RemovePortal(ulong portalId) => default; // 0x0000000185492010-0x0000000185492020
		public static bool RemoveGeometry(ulong geoId) => default; // 0x00000001813A28D0-0x00000001813A4020
		public static bool RemoveGeometryInstance(ulong instanceId) => default; // 0x0000000181377E40-0x0000000181377E50
		public static bool RemoveReverbZone(ulong reverbZoneId) => default; // 0x00000001813A4020-0x00000001813A4180
	}

	public delegate void AudioEventCallback(object in_cookie, AudioCallbackType in_type, AudioCallbackInfo in_info); // TypeDefIndex: 58950; 0x000000018377F8A0-0x000000018377F8E0

	public class AudioStringAttribute : PropertyAttribute // TypeDefIndex: 58951
	{
		// Constructors
		public AudioStringAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class AudioVectorAttribute : PropertyAttribute // TypeDefIndex: 58952
	{
		// Constructors
		public AudioVectorAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class AudioEventWarnAttribute : PropertyAttribute // TypeDefIndex: 58954
	{
		// Fields
		public WarnType warnType; // 0x10
	
		// Nested types
		public enum WarnType : byte // TypeDefIndex: 58953
		{
			NONE = 0,
			ONE_SHOT = 2,
			LOOP = 4
		}
	
		// Constructors
		public AudioEventWarnAttribute() {} // Dummy constructor
		public AudioEventWarnAttribute(WarnType type) {} // 0x000000018184FBD0-0x000000018184FBE0
	}

	public class BankHandle : IDisposable // TypeDefIndex: 58955
	{
		// Fields
		private readonly string _name_k__BackingField; // 0x10
		private AKRESULT _result_k__BackingField; // 0x18
		private bool _isDone_k__BackingField; // 0x1C
		private int m_refCount; // 0x20
	
		// Properties
		public string name { get; } // 0x000000018346D130-0x000000018346D140 
		public AKRESULT result { get; set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public bool isDone { get; set; } // 0x00000001814088D0-0x00000001814088E0 0x0000000181408D10-0x0000000181408D20
		public int refCount { get => default; } // 0x00000001813B88B0-0x00000001813B88C0 
	
		// Constructors
		public BankHandle() {} // Dummy constructor
		public BankHandle(string bankName) {} // 0x0000000184CD7460-0x0000000184CD7480
	
		// Methods
		public void Dispose() {} // 0x00000001873400F4-0x0000000187340174
		public void IncRef() {} // 0x0000000187340174-0x00000001873401C0
		public void DecRef() {} // 0x00000001873400A8-0x00000001873400F4
	}

	public class AsyncLoadBankTask : IEnumerator, IDisposable // TypeDefIndex: 58956
	{
		// Fields
		private readonly List<BankHandle> m_handles; // 0x10
	
		// Properties
		public object Current { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public AsyncLoadBankTask() {} // Dummy constructor
		public AsyncLoadBankTask(IList<string> bankNames) {} // 0x0000000184CD7670-0x0000000184CD7DF0
	
		// Methods
		public static AsyncLoadBankTask LoadBanksAsync(IList<string> bankNames) => default; // 0x00000001852D5730-0x00000001852D57B0
		public bool MoveNext() => default; // 0x00000001859EB6B0-0x00000001859EB7F0
		public void Reset() {} // 0x0000000187339FA8-0x0000000187339FF8
		public void Dispose() {} // 0x0000000187339E58-0x0000000187339FA8
	}

	public static class AudioBankManager // TypeDefIndex: 58958
	{
		// Fields
		internal static Dictionary<string, BankHandle> s_loadedBankHandles; // 0x00
	
		// Nested types
		public class CallbackCookie // TypeDefIndex: 58957
		{
			// Fields
			public string bankName; // 0x10
			public Action callback; // 0x18
			public BankHandle handle; // 0x20
	
			// Constructors
			public CallbackCookie() {} // 0x0000000184958030-0x0000000184958060
		}
	
		// Constructors
		static AudioBankManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void LoadMainPCK() {} // 0x0000000184CD7DF0-0x0000000184CD8050
		public static BankHandle LoadBankAsync(string bankName, Action callback = null) => default; // 0x0000000184CD7480-0x0000000184CD75C0
		private static void _LoadBankCallback(uint inBankId, IntPtr _, AKRESULT inLoadResult, object inCookie) {} // 0x000000018733E728-0x000000018733E884
		public static bool UnloadBank(string bankName) => default; // 0x000000018733E52C-0x000000018733E728
		public static void UnloadAllBanks() {} // 0x0000000184CD75C0-0x0000000184CD7670
		public static bool IsBankLoaded(string bankName) => default; // 0x000000018733E49C-0x000000018733E52C
		public static void Reset() {} // 0x000000018733E368-0x000000018733E49C
		public static void LoadDebugFilePackage(string path) {} // 0x000000018733E2B8-0x000000018733E368
		public static void AddDebugBankPath(string path) {} // 0x000000018733E900-0x000000018733EA20
		private static void _PreResetBasePath(out List<uint> unPinnedEventIds) {
			unPinnedEventIds = default;
		} // 0x000000018733E884-0x000000018733E900
		private static void _PostResetBasePath(List<uint> unPinnedEventIds) {} // 0x0000000185F40F00-0x0000000185F40F90
	}

	public class AudioConstants // TypeDefIndex: 58959
	{
		// Fields
		public const ulong AUDIO_INVALID_GAME_OBJECT = 18446744073709551615; // Metadata: 0x0207FFB1
		public const uint AUDIO_INVALID_UNIQUE_ID = 0; // Metadata: 0x0207FFB9
		public const uint AUDIO_INVALID_INTERNAL_PLAYING_ID = 0; // Metadata: 0x0207FFBA
		public const ulong AUDIO_GLOBAL_GAME_OBJECT = 18446744073709551615; // Metadata: 0x0207FFBB
		public const ulong AUDIO_ROOM_OUTDOOR_ID = 18446744073709551615; // Metadata: 0x0207FFC3
		public const ulong AUDIO_ROOM_OUTDOORS_ID = 18446744073709551612; // Metadata: 0x0207FFCB
		public const string AU_UI_BATTLE_BREAK_POISE = "au_ui_bat_break_poise"; // Metadata: 0x0207FFD3
		public const string AU_GLOBAL_GAIN_ON = "au_global_gain_on"; // Metadata: 0x0207FFE9
		public const string AU_GLOBAL_GAIN_OFF = "au_global_gain_off"; // Metadata: 0x0207FFFB
		public const uint AU_HASH_EXTERNAL_SOURCE_COOKIE = 618371124; // Metadata: 0x0208000E
		public const uint AU_BANK_INIT = 1355168291; // Metadata: 0x02080013
		public const string AU_DEVICE_CONTROLLER_SPEAKER = "Controller_Speaker"; // Metadata: 0x02080018
		public const int AUDIO_SPEAKER_SETUP_4_0 = 1539; // Metadata: 0x0208002B
		public const string AU_DEVICE_WWISE_MOTION = "Wwise_Motion"; // Metadata: 0x0208002D
		public const string AU_DEVICE_SYSTEM = "System"; // Metadata: 0x0208003A
		public const string AU_DEVICE_SYSTEM_3D = "System_3D"; // Metadata: 0x02080041
		public const uint AUDIO_UI_FULLSCREEN_OPEN = 3229907725; // Metadata: 0x0208004B
		public const uint AUDIO_UI_FULLSCREEN_CLOSE = 166048075; // Metadata: 0x02080050
		public const uint AUDIO_UI_FULLSCREEN_PAUSE = 697133041; // Metadata: 0x02080054
	
		// Constructors
		public AudioConstants() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public struct AudioId // TypeDefIndex: 58960
	{
		// Fields
		public int _id; // 0x00
	
		// Constructors
		public AudioId(uint id) {
			_id = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	
		// Methods
		public string GetName() => default; // 0x000000018733F094-0x000000018733F10C
		public static implicit operator uint(AudioId id) => default; // 0x0000000184501850-0x0000000184501880
		public static implicit operator int(AudioId id) => default; // 0x00000001849082E0-0x0000000184908310
		public static implicit operator AudioId(uint id) => default; // 0x00000001847A87F0-0x00000001847A8880
		public static implicit operator AudioId(int id) => default; // 0x000000018733F178-0x000000018733F1C4
		public static implicit operator AudioId(string id) => default; // 0x000000018733F10C-0x000000018733F178
	}

	public static class AudioIdExtensions // TypeDefIndex: 58961
	{
		// Methods
		public static uint[] ToUIntArray(ICollection<AudioId> ids) => default; // 0x000000018733EEB0-0x000000018733F094
	}

	[Serializable]
	public struct AudioState : IEquatable<AudioState> // TypeDefIndex: 58962
	{
		// Fields
		private int _stateGroup; // 0x00
		private int _stateValue; // 0x04
	
		// Properties
		public uint stateGroup { get => default; } // 0x00000001818226B0-0x00000001818226C0 
		public uint stateValue { get => default; } // 0x000000018357CBC0-0x000000018357CBD0 
	
		// Constructors
		public AudioState(uint stateGroup, uint stateValue) : this() {
			_stateGroup = default;
			_stateValue = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	
		// Methods
		public bool Equals(AudioState other) => default; // 0x000000018733FAFC-0x000000018733FB68
		public override bool Equals(object obj) => default; // 0x000000018733FB68-0x000000018733FC04
		public override int GetHashCode() => default; // 0x000000018733FC04-0x000000018733FC9C
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018733FC9C-0x000000018733FCFC
		public int __iFixBaseProxy_GetHashCode() => default; // 0x000000018733FCFC-0x000000018733FD4C
	}

	[Serializable]
	public struct AudioIdList // TypeDefIndex: 58963
	{
		// Fields
		public AudioId[] _ids; // 0x00
	}

	[Serializable]
	public struct AudioStateList // TypeDefIndex: 58964
	{
		// Fields
		public AudioState[] _states; // 0x00
	}

	[Serializable]
	public struct AudioEngineInitSetting // TypeDefIndex: 58965
	{
		// Fields
		public AkWwiseInitializationSettings akInitSettings; // 0x00
	}

	[Serializable]
	public struct AudioLargeSource // TypeDefIndex: 58966
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
	}

	public struct AudioCallbackInfo // TypeDefIndex: 58967
	{
		// Fields
		public ulong objectId; // 0x00
		public IntPtr pCookie; // 0x08
		internal AkCallbackInfo rawInfo; // 0x10
	
		// Methods
		public AudioDurationCallbackInfo CastToDurationCallbackInfo() => default; // 0x000000018733EA20-0x000000018733EB2C
	}

	public struct AudioDurationCallbackInfo // TypeDefIndex: 58968
	{
		// Fields
		public float duration; // 0x00
		public float estimatedDuration; // 0x04
		public uint audioNodeId; // 0x08
		public uint mediaId; // 0x0C
		public bool isStreaming; // 0x10
	}

	public class AudioPositionArrayProxy // TypeDefIndex: 58969
	{
		// Fields
		private AkPositionArray m_array; // 0x10
	
		// Properties
		public uint count { get => default; } // 0x00000001851E7650-0x00000001851E7670 
	
		// Constructors
		public AudioPositionArrayProxy() {} // Dummy constructor
		public AudioPositionArrayProxy(uint count) {} // 0x00000001851E7A20-0x00000001851E7AA0
	
		// Methods
		public AkPositionArray GetRawArray() => default; // 0x00000001851E7620-0x00000001851E7650
		public void Add(Vector3 position, Vector3 forward, Vector3 up) {} // 0x00000001851E7770-0x00000001851E7850
		public void Reset() {} // 0x00000001851E79D0-0x00000001851E7A20
		~AudioPositionArrayProxy() {} // 0x000000018733FA7C-0x000000018733FAFC
	}

	[Serializable]
	public struct AudioAcousticSurfaceData // TypeDefIndex: 58970
	{
		// Fields
		public uint textureId; // 0x00
		public float transmissionLoss; // 0x04
	}

	[Serializable]
	public struct AudioRoomData // TypeDefIndex: 58972
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
		public enum EBoolFlags : ushort // TypeDefIndex: 58971
		{
			None = 0,
			KeepRegistered = 1,
			UseForReflectionAndDiffraction = 2,
			AsReverbZone = 4
		}
	}

	public enum AudioCallbackType // TypeDefIndex: 58973
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

	public enum AudioLargeType : byte // TypeDefIndex: 58974
	{
		Sum = 0,
		Nearest = 1,
		Single = 2
	}

	public enum AudioPlayableActions // TypeDefIndex: 58975
	{
		None = 0,
		Playback = 1,
		Stop = 2,
		Seek = 4
	}

	public enum AudioEventType // TypeDefIndex: 58976
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

	public enum AudioMixDownMode // TypeDefIndex: 58977
	{
		Direct = 0,
		ForceToMono = 1
	}

	public enum AudioMasteringSuiteMode // TypeDefIndex: 58978
	{
		Headphone = 1,
		TV = 2,
		HomeCinema = 3,
		SoundBar = 4,
		Speaker = 5,
		DevMode = 99
	}

	public enum AudioChannelConfigType : uint // TypeDefIndex: 58979
	{
		Anonymous = 0,
		Standard = 1,
		Ambisonic = 2,
		Objects = 3,
		UseDeviceMain = 14,
		UseDevicePassthrough = 15
	}

	public enum AudioCodec : uint // TypeDefIndex: 58980
	{
		PCM = 1,
		ADPCM = 2,
		VORBIS = 4,
		ATRAC9 = 12,
		OPUS_WEM = 20
	}

	public enum AudioChannelMask : uint // TypeDefIndex: 58981
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

	public enum AudioLogChannel // TypeDefIndex: 58982
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

	public static class AudioLogger // TypeDefIndex: 58983
	{
		// Fields
		public static AudioLogChannel s_enabledChannels; // 0x00
	
		// Constructors
		static AudioLogger() {} // 0x000000018733F7B4-0x000000018733F7F0
	
		// Methods
		public static bool IsChannelEnabled(AudioLogChannel channel) => default; // 0x000000018733F2D0-0x000000018733F354
		public static void EnableChannel(AudioLogChannel channel) {} // 0x000000018733F24C-0x000000018733F2D0
		public static void DisableChannel(AudioLogChannel channel) {} // 0x000000018733F1C4-0x000000018733F24C
		public static void SetChannels(AudioLogChannel channel) {} // 0x000000018733F508-0x000000018733F588
		public static void Log(AudioLogChannel channel, string msg) {} // 0x000000018733F464-0x000000018733F508
		public static void Log<T1>(AudioLogChannel channel, string msg, T1 param1) {}
		public static void Log<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2) {}
		public static void Log<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3) {}
		public static void Log<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void Log<T1, T2, T3, T4, T5>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogWarning(AudioLogChannel channel, string msg) {} // 0x000000018733F3DC-0x000000018733F464
		public static void LogWarning<T1>(AudioLogChannel channel, string msg, T1 param1) {}
		public static void LogWarning<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2) {}
		public static void LogWarning<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3) {}
		public static void LogWarning<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError(AudioLogChannel channel, string msg) {} // 0x000000018733F354-0x000000018733F3DC
		public static void LogError<T1>(AudioLogChannel channel, string msg, T1 param1) {}
		public static void LogError<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4) {}
		private static void _DoLog(AudioLogChannel channel, string msg) {} // 0x000000018733F708-0x000000018733F7B4
		private static void _DoLogWarning(AudioLogChannel channel, string msg) {} // 0x000000018733F65C-0x000000018733F708
		private static void _DoLogError(AudioLogChannel channel, string msg) {} // 0x000000018733F588-0x000000018733F65C
	}

	public static class AudioAcousticUtil // TypeDefIndex: 58984
	{
		// Fields
		private const float SOUND_SPEED = 343f; // Metadata: 0x020801B2
	
		// Methods
		public static float RT60DecayTime(float volume, float surfaceArea, float absorptionFactor) => default; // 0x000000018733A15C-0x000000018733A204
		public static float PreDelayTime(Vector3 size) => default; // 0x000000018733A0E4-0x000000018733A15C
		public static float CriticalDistance(float volume, float rt60, float gamma = 1f /* Metadata: 0x020801AE */) => default; // 0x0000000187339FF8-0x000000018733A088
		public static float ReverbIntensity(Vector3 size) => default; // 0x000000018733A204-0x000000018733A290
		public static float ErIntensity(Vector3 size) => default; // 0x000000018733A088-0x000000018733A0E4
	}

	internal static class AudioActionQueueHelper // TypeDefIndex: 58988
	{
		// Fields
		private static Queue<FExecuteAction> s_executeActionQueue; // 0x00
		private static Queue<FRTPCAction> s_rtpcActionQueue; // 0x08
		private static Queue<FSeekAction> s_seekActionQueue; // 0x10
		private const int QUEUE_LIFETIME_FRAME = 10; // Metadata: 0x020801B6
	
		// Nested types
		private struct FExecuteAction // TypeDefIndex: 58985
		{
			// Fields
			public int queuedFrame; // 0x00
			public uint playingId; // 0x04
			public AkActionOnEventType actionType; // 0x08
			public int durationMs; // 0x0C
		}
	
		private struct FRTPCAction // TypeDefIndex: 58986
		{
			// Fields
			public int queuedFrame; // 0x00
			public uint playingId; // 0x04
			public uint rtpcId; // 0x08
			public float targetValue; // 0x0C
			public int durationMs; // 0x10
		}
	
		private struct FSeekAction // TypeDefIndex: 58987
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
		static AudioActionQueueHelper() {} // 0x0000000185CA6CE0-0x0000000185CA6EB0
	
		// Methods
		internal static void QueueExecuteAction(uint playingId, AkActionOnEventType actionType, int durationMs) {} // 0x0000000184733BB0-0x0000000184733CA0
		internal static void QueueRtpcAction(uint playingId, uint rtpcId, float targetValue, int durationMs) {} // 0x000000018733A380-0x000000018733A484
		internal static void QueueSeekAction(uint playingId, uint eventId, ulong audioObjectId, int timeMs, bool toNearestMarker) {} // 0x000000018733A484-0x000000018733A5D8
		internal static void ConsumeQueue() {} // 0x0000000184599310-0x0000000184599400
		internal static void ClearQueue() {} // 0x000000018733A290-0x000000018733A380
		private static void _ConsumeExecute(int currFrame) {} // 0x0000000184599400-0x0000000184599670
		private static void _ConsumeRtpc(int currFrame) {} // 0x0000000184599670-0x00000001845997A0
		private static void _ConsumeSeek(int currFrame) {} // 0x00000001845997A0-0x0000000184599920
	}

	internal static class AudioAssetCache // TypeDefIndex: 58992
	{
		// Fields
		private static Dictionary<uint, LinkedListNode<EventCacheInfo>> s_lruUsingEvents; // 0x00
		private static Cache s_cachedEvents; // 0x08
		private static HashSet<uint> s_pinnedEvents; // 0x10
		private const int INIT_PREPARE_CAP = 128; // Metadata: 0x020801B7
		private static ObjectPool<LinkedListNode<EventCacheInfo>> s_nodePool; // 0x18
	
		// Nested types
		internal class EventCacheInfo // TypeDefIndex: 58989
		{
			// Fields
			public uint id; // 0x10
			public uint refCount; // 0x14
	
			// Constructors
			public EventCacheInfo() {} // 0x00000001859E1BC0-0x00000001859E1E10
		}
	
		private class Cache // TypeDefIndex: 58990
		{
			// Fields
			private readonly LinkedList<EventCacheInfo> m_lruCachedEventsList; // 0x10
			private readonly Dictionary<uint, LinkedListNode<EventCacheInfo>> m_lruCachedEvents; // 0x18
	
			// Properties
			public LinkedList<EventCacheInfo> lruCachedEventsList { get => default; } // 0x00000001858C17A0-0x00000001858C1840 
			public int count { get => default; } // 0x000000018733D920-0x000000018733D9C0 
	
			// Constructors
			public Cache() {} // 0x0000000184CD9780-0x0000000184CD9950
	
			// Methods
			public void Clear() {} // 0x000000018733D5C0-0x000000018733D920
			public uint RemoveFirst(out LinkedListNode<EventCacheInfo> outNode) {
				outNode = default;
				return default;
			} // 0x0000000184CD9D50-0x0000000184CD9E50
			public bool Remove(uint inId, out LinkedListNode<EventCacheInfo> outNode) {
				outNode = default;
				return default;
			} // 0x0000000185D6A8C0-0x0000000185D6A940
			public void AddLast(ref LinkedListNode<EventCacheInfo> node) {} // 0x0000000184599CD0-0x0000000184599F30
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 58991
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<LinkedListNode<EventCacheInfo>> __9__7_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000184CD8B50-0x0000000184CD8C40
			public __c() {} // 0x000000018733DA04-0x000000018733DA44
	
			// Methods
			internal LinkedListNode<EventCacheInfo> _Reset_b__7_0() => default; // 0x000000018733D9C0-0x000000018733DA04
		}
	
		// Constructors
		static AudioAssetCache() {} // 0x0000000184902820-0x00000001849028A0
	
		// Methods
		internal static void Reset() {} // 0x000000018733DACC-0x000000018733DB0C
		internal static void PinEvent(uint inId) {} // 0x000000018733DA44-0x000000018733DACC
		internal static void UnpinEvent(uint inId) {} // 0x0000000185BBC590-0x0000000185BBC6E0
		internal static void GetAllUsingAssetsAndRelease(ref List<uint> allIds) {} // 0x0000000185492010-0x0000000185492020
		internal static uint GetLeastActiveAssetAndUncache() => default; // 0x00000001873401C0-0x0000000187340210
		internal static int GetCachedAssetCount() => default; // 0x0000000185D6A940-0x0000000185D6A980
		internal static bool ActivateAsset(uint inId) => default; // 0x00000001859E1E10-0x00000001859E1E90
		internal static void DeactivateAsset(uint inId) {} // 0x0000000184CD9E50-0x0000000184CD9F40
		internal static void ForceReleaseCachedAsset(uint inId) {} // 0x0000000184CD9A10-0x0000000184CD9CF0
		private static void _NotifyDebugger() {} // 0x0000000184CD9950-0x0000000184CD9A10
		private static void _NotifyDebuggerCacheHit(bool isHit) {} // 0x0000000185BBC6E0-0x0000000185BBC7A0
		private static void _ResetDebugger() {} // 0x0000000185F6B530-0x0000000185F6B590
		private static void _PinnedEventLeakDetect() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AudioAssetHelper // TypeDefIndex: 58995
	{
		// Fields
		private static ulong s_memoryBudget; // 0x00
		private const float FACTOR_B_TO_MB = 9.5367E-07f; // Metadata: 0x020801BB
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
		private static bool isGcProcessing { get; } // 0x0000000184597FB0-0x0000000184598010 
	
		// Nested types
		private struct FOnBankLoadedDoPrepareEventPayload // TypeDefIndex: 58993
		{
			// Fields
			public uint id; // 0x00
			public AkCallbackManager.BankCallback callback; // 0x08
			public object cookie; // 0x10
		}
	
		private struct FPendingLoadRequest // TypeDefIndex: 58994
		{
			// Fields
			public uint id; // 0x00
			public FOnBankLoadedDoPrepareEventPayload payload; // 0x08
		}
	
		// Constructors
		static AudioAssetHelper() {} // 0x0000000184CD7000-0x0000000184CD73C0
	
		// Methods
		internal static void SetMemoryBudget(ulong inBudgetBytes, ushort inGcCount = 10 /* Metadata: 0x020801B9 */) {} // 0x0000000185C35010-0x0000000185C350A0
		internal static bool HasPreparingEvents() => default; // 0x000000018733DB0C-0x000000018733DB98
		internal static void UnPrepareAllEventsSync() {} // 0x000000018733DD4C-0x000000018733E0F0
		internal static void LoadEventAsync(uint inId, AkCallbackManager.BankCallback callback = null, object cookie = null) {} // 0x000000018733DB98-0x000000018733DD04
		private static void _TryConsumePendingLoadRequests() {} // 0x000000018598A6B0-0x000000018598A730
		private static void _ConsumePendingLoadRequests() {} // 0x0000000184597C40-0x0000000184597CE0
		private static void _DoLoadEventAsync(uint inId, FOnBankLoadedDoPrepareEventPayload payload) {} // 0x0000000184599AD0-0x0000000184599CD0
		internal static void PinEvent(uint inId) {} // 0x000000018733DD04-0x000000018733DD4C
		internal static void UnpinEvent(uint inId) {} // 0x000000018733E138-0x000000018733E180
		internal static void ResetStaticFields() {} // 0x00000001859E1AB0-0x00000001859E1BC0
		internal static void ReleaseAllCachedEventsSync() {} // 0x0000000184597EC0-0x0000000184597FB0
		private static void _TryGC() {} // 0x000000018733E248-0x000000018733E2B8
		private static void _DoGc(int gcCount) {} // 0x0000000184CD8180-0x0000000184CD8330
		internal static void UnloadEvent(uint inId) {} // 0x000000018733E0F0-0x000000018733E138
		private static void _OnUnpreparedDoUnloadBank(uint inId, IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, object inCookie) {} // 0x0000000184CD8330-0x0000000184CD8420
		private static void _OnDoneUnloadBank(uint inId, IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, object inCookie) {} // 0x000000018598A610-0x000000018598A6B0
		private static void _OnBankLoadedDoPrepareEvent(uint inId, IntPtr _, AKRESULT inLoadResult, object __) {} // 0x0000000184CD8680-0x0000000184CD8810
		private static void _OnDonePrepareEvent(uint inId, IntPtr _, AKRESULT __, object ___) {} // 0x0000000184596890-0x0000000184596950
		private static void _TryDequeueAndInvokeCallback() {} // 0x0000000184596950-0x0000000184596EC0
		private static void _RemoveLoadingDebug(uint inId) {} // 0x000000018733E204-0x000000018733E248
		private static void _AddLoadingDebug(uint inId) {} // 0x000000018733E180-0x000000018733E1C4
		private static void _ClearLoadingDebug() {} // 0x000000018733E1C4-0x000000018733E204
	}

	internal static class AudioCallbackMessageParser // TypeDefIndex: 58996
	{
		// Methods
		internal static void Set() {} // 0x0000000185C4D780-0x0000000185C4D840
		private static void _OnMonitoringCallback(AkMonitorErrorCode inErrorCode, AkMonitorErrorLevel inErrorLevel, uint inPlayingID, ulong inGameObjID, string inMsg) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class AudioDebugInfoContainer // TypeDefIndex: 58997
	{
		// Methods
		public static void SetAudioObjectName(ulong audioObjId, string name) {} // 0x000000018733ECC0-0x000000018733ED14
		public static void RemoveAudioObjectName(ulong audioObjId) {} // 0x000000018733EC7C-0x000000018733ECC0
		public static string GetAudioObjectName(ulong audioObjId) => default; // 0x000000018733EBD4-0x000000018733EC0C
		public static string ForceGetEventName(uint eventId) => default; // 0x000000018733EB2C-0x000000018733EB80
		public static string ForceGetRtpcName(uint rtpcId) => default; // 0x000000018733EB80-0x000000018733EBD4
		public static string GetRtpcName(uint rtpcId) => default; // 0x000000018733EC44-0x000000018733EC7C
		public static string GetEventName(uint eventId) => default; // 0x000000018733EC0C-0x000000018733EC44
	}

	public static class AudioHashGenerator // TypeDefIndex: 58998
	{
		// Fields
		public const short MAX_STRING_LENGTH = 256; // Metadata: 0x020801BF
		private const uint PRIME32 = 16777619; // Metadata: 0x020801C1
		private const uint OFFSET_BASIS32 = 2166136261; // Metadata: 0x020801C5
	
		// Methods
		public static uint Compute(string inStr) => default; // 0x00000001848BFA80-0x00000001848BFB70
		public static uint Compute(IntPtr inCharPtr) => default; // 0x00000001848BE210-0x00000001848BE340
		public static uint Compute(ReadOnlySpan<byte> buffer) => default; // 0x00000001848BF9D0-0x00000001848BFA80
		public static uint Compute(string inStr1, string inStr2) => default; // 0x00000001848BF8A0-0x00000001848BF9D0
		public static uint Compute(string[] strings) => default; // 0x000000018733EDB8-0x000000018733EEA0
		private static uint _GetUintFromCharToLower(char c) => default; // 0x000000018733EEA0-0x000000018733EEB0
	}

	public static class AudioMemoryMonitor // TypeDefIndex: 59001
	{
		// Fields
		private static AkMemCategroyStats s_categoryStats; // 0x00
		private static bool s_monitorInited; // 0x08
	
		// Nested types
		public struct FGlobalMemoryStats // TypeDefIndex: 58999
		{
			// Fields
			public ulong used; // 0x00
			public ulong reserved; // 0x08
		}
	
		public struct FExtraMemoryStats // TypeDefIndex: 59000
		{
			// Fields
			public ulong active; // 0x00
			public ulong mapped; // 0x08
			public ulong retained; // 0x10
			public ulong allocated; // 0x18
		}
	
		// Methods
		internal static void Init() {} // 0x0000000185D69A10-0x0000000185D69AC0
		internal static void Release() {} // 0x000000018733F9F4-0x000000018733FA7C
		internal static bool IsValid() => default; // 0x000000018733F9BC-0x000000018733F9F4
		internal static ulong GetUsedMemoryUnsafe() => default; // 0x000000018733F91C-0x000000018733F95C
		internal static ulong GetUsedMemory() => default; // 0x000000018733F95C-0x000000018733F9BC
		public static FGlobalMemoryStats GetGlobalMemoryStats() => default; // 0x0000000185BB11B0-0x0000000185BB1260
		public static FExtraMemoryStats GetExtraMemoryStats() => default; // 0x000000018733F7F0-0x000000018733F854
		internal static ulong GetUsedMemoryByCategory(AkMemID memCategory) => default; // 0x000000018733F854-0x000000018733F91C
	}

	public static class AudioUIUtil // TypeDefIndex: 59003
	{
		// Fields
		private static ushort s_fullScreenCounter; // 0x00
	
		// Nested types
		public enum UIAudioType // TypeDefIndex: 59002
		{
			None = 0,
			FullScreen = 1,
			Tips = 2
		}
	
		// Methods
		public static void Init() {} // 0x0000000184B4FEA0-0x0000000184B4FF70
		public static void Release() {} // 0x000000018733FDD4-0x000000018733FE7C
		public static uint PostUIEvent(string eventName, GameObject uiGameObject) => default; // 0x0000000184FBF600-0x0000000184FBF730
		public static uint PostUIEvent(string eventName, string objPath) => default; // 0x000000018733FD4C-0x000000018733FDD4
		public static void OnUIPanelClose(UIAudioType uiAudioType) {} // 0x0000000184A7CE50-0x0000000184A7CF00
		public static void OnUIPanelOpen(UIAudioType uiAudioType) {} // 0x0000000184A7D170-0x0000000184A7D220
	}

	internal static class AudioVFSLoader // TypeDefIndex: 59005
	{
		// Fields
		private const string PCK_SUFFIX = ".pck"; // Metadata: 0x020801CD
		private static VfsLoadedInfo s_loadedInitPckInfo; // 0x00
		private static VfsLoadedInfo s_loadedMainPckInfo; // 0x10
		private static VfsLoadedInfo s_loadedAuditPckInfo; // 0x20
		private static VfsLoadedInfo s_loadedLangPckInfo; // 0x30
		private static VfsLoadedInfo s_loadedHotfixPckInfo; // 0x40
		private static EVFSBlockType s_pendingLanguageBlock; // 0x50
	
		// Nested types
		private struct VfsLoadedInfo // TypeDefIndex: 59004
		{
			// Fields
			public List<uint> loadedPcks; // 0x00
			public int loadedVersion; // 0x08
			public bool isLoaded; // 0x0C
	
			// Methods
			public static VfsLoadedInfo Create() => default; // 0x000000018733FE7C-0x000000018733FF4C
		}
	
		// Methods
		internal static void UnloadAll() {} // 0x0000000184957F90-0x0000000184958030
		internal static bool TryLoadInitPck() => default; // 0x0000000184957850-0x0000000184957980
		internal static bool TryLoadMainPck() => default; // 0x0000000184958160-0x00000001849581F0
		internal static bool TryLoadLanguagePck(string language) => default; // 0x00000001849576E0-0x0000000184957850
		private static bool _DoLoadLanguageAndHotfixPck(EVFSBlockType langBlockType) => default; // 0x0000000185808860-0x0000000185809030
		internal static void InitBasePaths() {} // 0x0000000184957570-0x0000000184957620
		private static bool _TryLoadPcksFromVfsInfo(VFBlockMainInfo vfsInfo, ref VfsLoadedInfo info) => default; // 0x00000001849561C0-0x0000000184956540
		private static bool _DoLoadPcksFromVfs(VFBlockMainInfo vfs, ref List<uint> loaded) => default; // 0x0000000184955B30-0x0000000184955CC0
		private static bool _DoLoadSinglePckFromVfs(FVFBlockFileInfo fileInfo, out uint loadedId) {
			loadedId = default;
			return default;
		} // 0x0000000184957980-0x0000000184957D50
		private static void _UnloadPcks(ref VfsLoadedInfo info) {} // 0x00000001849581F0-0x0000000184958270
		private static EVFSBlockType _GetVfsBlockTypeFromLanguage(string language) => default; // 0x0000000181382F40-0x0000000181384D70
		public static void LoadExtraPckFromPath(string path) {} // 0x0000000185809030-0x0000000185809130
	}
}

namespace Beyond.Audio.AudioPerformanceMonitor
{
	public class AudioProfiling // TypeDefIndex: 59008
	{
		// Nested types
		public static class AudioWwiseProfilingData // TypeDefIndex: 59007
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
			static AudioWwiseProfilingData() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public AudioProfiling() {} // 0x000000018733FF4C-0x00000001873400A8
	}

	public class WwiseResourceMonitor : Singleton<WwiseResourceMonitor> // TypeDefIndex: 59009
	{
		// Fields
		private const float TIME_OF_SOUND_FRAME = 0.21333334f; // Metadata: 0x020801D2
		private const float MB_RATE = 9.536743E-07f; // Metadata: 0x020801D6
		private bool m_isActiveAkResourceMonitoring; // 0x10
		private WwiseResourceMonitorItem m_wwiseResourceMonitorData; // 0x14
	
		// Properties
		public bool isActiveAkResourceMonitoring { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
	
		// Constructors
		private WwiseResourceMonitor() {} // 0x00000001873414F0-0x0000000187341518
	
		// Methods
		public static bool IsSupportMemoryMonitor() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public void StartSoundEngineResourceMonitor() {} // 0x00000001873414D8-0x00000001873414E4
		public void StopSoundEngineResourceMonitor() {} // 0x00000001873414E4-0x00000001873414F0
		public WwiseResourceMonitorItem SampleRawWwiseResource() => default; // 0x0000000185FB04A0-0x0000000185FB04D0
	}

	[Serializable]
	public struct WwiseResourceMonitorItem // TypeDefIndex: 59010
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
	public static class AudioEditorAssetsLoader // TypeDefIndex: 59006
	{
		// Methods
		internal static void Init() {} // 0x0000000185492010-0x0000000185492020
		internal static void Release() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 58936
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 58937
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 58938
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 58939
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 58940
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 58935
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59013
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F640F0-0x0000000185F64160
	
		// Methods
		public uint __Gen_Wrap_0(uint P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7) => default; // 0x0000000187340690-0x00000001873407E4
		public uint __Gen_Wrap_1(object P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7) => default; // 0x0000000187340998-0x0000000187340AEC
		public void __Gen_Wrap_2(uint P0, IntPtr P1, AKRESULT P2, object P3) {} // 0x0000000187340AEC-0x0000000187340BF4
		public void __Gen_Wrap_3(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public IEnumerator __Gen_Wrap_4(object P0, object P1, object P2) => default; // 0x0000000187340BF4-0x0000000187340D1C
		public void __Gen_Wrap_5(in IList<uint> P0, in Action<object> P1, in object P2) {} // 0x0000000187340D1C-0x0000000187340E48
		public void __Gen_Wrap_6(object P0, object P1, object P2) {} // 0x0000000187340E48-0x0000000187340F40
		public uint __Gen_Wrap_7(AudioId P0) => default; // 0x0000000187340F40-0x0000000187341040
		public IEnumerator __Gen_Wrap_8(object P0) => default; // 0x0000000187341040-0x000000018734111C
		public void __Gen_Wrap_9(uint P0, uint P1, ulong P2) {} // 0x000000018734111C-0x00000001873411FC
		public void __Gen_Wrap_10(object P0, object P1, ulong P2) {} // 0x00000001873407E4-0x00000001873408C8
		public uint __Gen_Wrap_11(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public void __Gen_Wrap_12(uint P0, float P1, int P2) {} // 0x0000000181385AD0-0x0000000181385CE0
		public void __Gen_Wrap_13(object P0, float P1, int P2) {} // 0x0000000181385CE0-0x0000000181385FD0
		public void __Gen_Wrap_14(uint P0, float P1, ulong P2) {} // 0x0000000181385FD0-0x0000000181386220
		public void __Gen_Wrap_15(object P0, float P1, ulong P2) {} // 0x0000000181386220-0x0000000181386530
		public void __Gen_Wrap_16(uint P0, float P1, ulong P2, int P3) {} // 0x0000000181386530-0x00000001813867A0
		public void __Gen_Wrap_17(uint P0, uint P1, float P2, int P3) {} // 0x00000001813867A0-0x0000000181386A10
		public void __Gen_Wrap_18(uint P0, float P1, uint P2, int P3) {} // 0x0000000181386A10-0x0000000181386C80
		public void __Gen_Wrap_19(uint P0, ulong P1, int P2) {} // 0x0000000181386C80-0x0000000181386EA0
		public void __Gen_Wrap_20(object P0, ulong P1, int P2) {} // 0x0000000181386EA0-0x0000000181387190
		public void __Gen_Wrap_21(uint P0, uint P1, ulong P2, int P3, bool P4) {} // 0x0000000181387190-0x00000001813873F0
		public void __Gen_Wrap_22(uint P0, ulong P1, int P2, bool P3, uint P4) {} // 0x00000001813873F0-0x0000000181387650
		public void __Gen_Wrap_23(object P0, ulong P1, int P2, bool P3, uint P4) {} // 0x0000000181387650-0x0000000181387970
		public void __Gen_Wrap_24(object P0, int P1, bool P2, uint P3) {} // 0x0000000181387970-0x0000000181387C80
		public void __Gen_Wrap_25(uint P0, int P1, bool P2, uint P3) {} // 0x0000000181387C80-0x0000000181387EC0
		public bool __Gen_Wrap_26(uint P0, out int P1, bool P2) {
			P1 = default;
			return default;
		} // 0x0000000181387EC0-0x0000000181388120
		public bool __Gen_Wrap_27(uint P0) => default; // 0x0000000181388120-0x0000000181388320
		public int __Gen_Wrap_28() => default; // 0x0000000181361E60-0x0000000181362020
		public uint __Gen_Wrap_29(object P0, out LinkedListNode<AudioAssetCache.EventCacheInfo> P1) {
			P1 = default;
			return default;
		} // 0x0000000181388320-0x0000000181388D50
		public uint __Gen_Wrap_30() => default; // 0x0000000181361E60-0x0000000181362020
		public bool __Gen_Wrap_31(object P0, uint P1, out LinkedListNode<AudioAssetCache.EventCacheInfo> P2) {
			P2 = default;
			return default;
		} // 0x0000000181388D50-0x00000001813897C0
		public void __Gen_Wrap_32() {} // 0x000000018136DA00-0x000000018136DBB0
		public void __Gen_Wrap_33(uint P0, AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload P1) {} // 0x00000001813897C0-0x0000000181389D90
		public void __Gen_Wrap_34(int P0) {} // 0x0000000181389D90-0x0000000181389F80
		public AkPositionArray __Gen_Wrap_35(object P0) => default; // 0x0000000181389F80-0x000000018138A8C0
		public void __Gen_Wrap_36(ulong P0, object P1, AudioLargeType P2) {} // 0x000000018138A8C0-0x000000018138ABD0
		public void __Gen_Wrap_37(ulong P0) {} // 0x000000018138ABD0-0x000000018138ADC0
		public void __Gen_Wrap_38(ulong P0, ulong P1) {} // 0x000000018138ADC0-0x000000018138AFE0
		public bool __Gen_Wrap_39(uint P0, out uint P1) {
			P1 = default;
			return default;
		} // 0x000000018138AFE0-0x000000018138B240
		public EVFSBlockType __Gen_Wrap_40(object P0) => default; // 0x000000018138B240-0x000000018138B500
		public void __Gen_Wrap_41(ref AudioVFSLoader.VfsLoadedInfo P0) {} // 0x000000018138B500-0x000000018138C0F0
		public bool __Gen_Wrap_42(FVFBlockFileInfo P0, out uint P1) {
			P1 = default;
			return default;
		} // 0x000000018138C0F0-0x000000018138C700
		public bool __Gen_Wrap_43(object P0, ref List<uint> P1) => default; // 0x000000018138C700-0x000000018138D1C0
		public bool __Gen_Wrap_44(object P0, ref AudioVFSLoader.VfsLoadedInfo P1) => default; // 0x000000018138D1C0-0x000000018138DED0
		public bool __Gen_Wrap_45(EVFSBlockType P0) => default; // 0x000000018138DED0-0x000000018138E0D0
		public bool __Gen_Wrap_46(object P0) => default; // 0x0000000181370BF0-0x0000000181370EB0
		public void __Gen_Wrap_47(AudioEngineInitSetting P0) {} // 0x000000018138E0D0-0x000000018138E670
		public AudioAdapter.PayloadPostEvent __Gen_Wrap_48() => default; // 0x000000018138E670-0x000000018138EEB0
		public LinkedListNode<AudioAssetCache.EventCacheInfo> __Gen_Wrap_49() => default; // 0x000000018138EEB0-0x000000018138F6F0
		public AudioVFSLoader.VfsLoadedInfo __Gen_Wrap_50() => default; // 0x000000018138F6F0-0x000000018138FF00
		public bool __Gen_Wrap_51() => default; // 0x000000018138FF00-0x00000001813900C0
		public void __Gen_Wrap_52(ref List<uint> P0) {} // 0x00000001813900C0-0x0000000181390A70
		public void __Gen_Wrap_53(bool P0) {} // 0x0000000181390A70-0x0000000181390C60
		public void __Gen_Wrap_54(object P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8) {} // 0x0000000181390C60-0x0000000181391570
		public void __Gen_Wrap_55(object P0, AkCallbackType P1, object P2) {} // 0x0000000181391570-0x0000000181391940
		public uint __Gen_Wrap_56(uint P0, ulong P1, AudioCallbackType P2, object P3, object P4) => default; // 0x0000000181391940-0x0000000181391D70
		public void __Gen_Wrap_57(uint P0, AkActionOnEventType P1, int P2) {} // 0x0000000181391D70-0x0000000181391FC0
		public void __Gen_Wrap_58(AkActionOnEventType P0, uint P1, int P2) {} // 0x0000000181391D70-0x0000000181391FC0
		public AkResourceMonitorDataSummary __Gen_Wrap_59() => default; // 0x0000000181391FC0-0x0000000181392800
		public AudioMemoryMonitor.FGlobalMemoryStats __Gen_Wrap_60() => default; // 0x0000000181392800-0x0000000181393010
		public AudioMemoryMonitor.FExtraMemoryStats __Gen_Wrap_61() => default; // 0x0000000181393010-0x0000000181393820
		public void __Gen_Wrap_62(ulong P0, float P1, float P2) {} // 0x0000000181393820-0x0000000181393A50
		public bool __Gen_Wrap_63(ulong P0, object P1, object P2, object P3, object P4, bool P5, bool P6) => default; // 0x0000000181393A50-0x0000000181393FE0
		public bool __Gen_Wrap_64(ulong P0, Vector3 P1, Vector3 P2, Quaternion P3, ulong P4, bool P5) => default; // 0x0000000181393FE0-0x0000000181394A60
		public bool __Gen_Wrap_65(ulong P0, AudioRoomData P1, ulong P2, object P3) => default; // 0x0000000181394A60-0x0000000181395170
		public bool __Gen_Wrap_66(ulong P0, ulong P1, ulong P2, Vector3 P3, Quaternion P4, Vector3 P5, bool P6, object P7) => default; // 0x0000000181395170-0x0000000181395CE0
		public bool __Gen_Wrap_67(out AudioChannelMask P0, out uint P1, out AudioChannelConfigType P2) {
			P0 = default;
			P1 = default;
			P2 = default;
			return default;
		} // 0x0000000181395CE0-0x0000000181395FE0
		public bool __Gen_Wrap_68(object P0, uint P1, uint P2, uint P3, out ulong P4) {
			P4 = default;
			return default;
		} // 0x0000000181395FE0-0x0000000181396320
		public bool __Gen_Wrap_69(object P0, uint P1, out ulong P2) {
			P2 = default;
			return default;
		} // 0x0000000181396320-0x0000000181396660
		public ulong __Gen_Wrap_70(object P0, uint P1) => default; // 0x0000000181396660-0x0000000181396940
		public bool __Gen_Wrap_71(ulong P0) => default; // 0x0000000181396940-0x0000000181396B40
		public bool __Gen_Wrap_72(bool P0) => default; // 0x000000018138DED0-0x000000018138E0D0
		public void __Gen_Wrap_73(ulong P0, uint P1, uint P2) {} // 0x0000000181396B40-0x0000000181396D60
		public uint __Gen_Wrap_74(int P0) => default; // 0x000000018136EEF0-0x000000018136F0F0
		public AsyncLoadBankTask __Gen_Wrap_75(object P0) => default; // 0x0000000181396D60-0x00000001813976A0
		public BankHandle __Gen_Wrap_76(object P0, object P1) => default; // 0x00000001813976A0-0x00000001813980D0
		public void __Gen_Wrap_77(out List<uint> P0) {
			P0 = default;
		} // 0x00000001813980D0-0x0000000181398A00
		public string __Gen_Wrap_78(ref AudioId P0) => default; // 0x0000000181398A00-0x00000001813998A0
		public int __Gen_Wrap_79(AudioId P0) => default; // 0x00000001813998A0-0x0000000181399E40
		public AudioId __Gen_Wrap_80(uint P0) => default; // 0x0000000181399E40-0x000000018139A670
		public AudioId __Gen_Wrap_81(int P0) => default; // 0x000000018139A670-0x000000018139AEA0
		public AudioId __Gen_Wrap_82(object P0) => default; // 0x000000018139AEA0-0x000000018139B790
		public uint[] __Gen_Wrap_83(object P0) => default; // 0x000000018139B790-0x000000018139C0C0
		public bool __Gen_Wrap_84(ref AudioState P0, AudioState P1) => default; // 0x000000018139C0C0-0x000000018139CD60
		public bool __Gen_Wrap_85(ref AudioState P0, object P1) => default; // 0x000000018139CD60-0x000000018139DA00
		public int __Gen_Wrap_86(ref AudioState P0) => default; // 0x000000018139DA00-0x000000018139E5B0
		public AudioDurationCallbackInfo __Gen_Wrap_87(ref AudioCallbackInfo P0) => default; // 0x000000018139E5B0-0x000000018139F4D0
		public void __Gen_Wrap_88(object P0, Vector3 P1, Vector3 P2, Vector3 P3) {} // 0x000000018139F4D0-0x000000018139FD70
		public bool __Gen_Wrap_89(AudioLogChannel P0) => default; // 0x000000018139FD70-0x000000018139FF70
		public void __Gen_Wrap_90(AudioLogChannel P0) {} // 0x0000000181355200-0x00000001813553F0
		public void __Gen_Wrap_91(AudioLogChannel P0, object P1) {} // 0x0000000181366C10-0x0000000181366EE0
		public float __Gen_Wrap_92(float P0, float P1, float P2) => default; // 0x000000018139FF70-0x00000001813A01B0
		public float __Gen_Wrap_93(Vector3 P0) => default; // 0x00000001813A01B0-0x00000001813A0780
		public void __Gen_Wrap_94(uint P0) {} // 0x0000000181389D90-0x0000000181389F80
		public void __Gen_Wrap_95(object P0, ref LinkedListNode<AudioAssetCache.EventCacheInfo> P1) {} // 0x00000001813A0780-0x00000001813A1230
		public LinkedList<AudioAssetCache.EventCacheInfo> __Gen_Wrap_96(object P0) => default; // 0x00000001813A1230-0x00000001813A1B60
		public void __Gen_Wrap_97(ulong P0, ushort P1) {} // 0x00000001813A1B60-0x00000001813A1D70
		public void __Gen_Wrap_98(ulong P0, object P1) {} // 0x00000001813A1D70-0x00000001813A2040
		public string __Gen_Wrap_99(uint P0) => default; // 0x00000001813A2040-0x00000001813A28C0
		public uint __Gen_Wrap_100(ReadOnlySpan<byte> P0) => default; // 0x0000000181384D70-0x0000000181385320
		public uint __Gen_Wrap_101(IntPtr P0) => default; // 0x0000000181385320-0x0000000181385520
		public uint __Gen_Wrap_102(object P0, object P1) => default; // 0x0000000181385520-0x00000001813858D0
		public ulong __Gen_Wrap_103(AkMemID P0) => default; // 0x00000001813858D0-0x0000000181385AD0
		public void __Gen_Wrap_104(AudioUIUtil.UIAudioType P0) {} // 0x0000000181355200-0x00000001813553F0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 59014
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { get => default; } // 0x00000001873415A4-0x0000000187341650 
		object IEnumerator.Current { get => default; } // 0x0000000187341650-0x00000001873416FC 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000187341778-0x0000000187341854
	
		// Methods
		void IDisposable.Dispose() {} // 0x00000001873416FC-0x0000000187341778
		private bool MoveNext() => default; // 0x0000000187341518-0x00000001873415A4
		void IEnumerator.Reset() {} // 0x00000001872E7280-0x00000001872E72FC
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59015
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000187341A3C-0x0000000187341AA0
		public static bool IsPatched(int id) => default; // 0x0000000184599920-0x0000000184599990
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001873418F8-0x00000001873419C4
		public object CreateWrapper(int id) => default; // 0x00000001873419C4-0x0000000187341A3C
		public object InitWrapperArray(int len) => default; // 0x0000000187341AA0-0x0000000187341B2C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000187341854-0x00000001873418F8
	}

	public enum IDMAP0 // TypeDefIndex: 59016
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
		Beyond-Audio-AudioAdapter-SetRtpc3 = 35,
		Beyond-Audio-AudioAdapter-SetRtpc2 = 36,
		Beyond-Audio-AudioAdapter-SetRtpc4 = 37,
		Beyond-Audio-AudioAdapter-SetRtpcValueByPlayingID0 = 38,
		Beyond-Audio-AudioActionQueueHelper-QueueRtpcAction0 = 39,
		Beyond-Audio-AudioAdapter-ResetRtpc0 = 40,
		Beyond-Audio-AudioAdapter-ResetRtpc1 = 41,
		Beyond-Audio-AudioAdapter-SeekOnEvent1 = 42,
		Beyond-Audio-AudioAdapter-SeekOnEvent0 = 43,
		Beyond-Audio-AudioActionQueueHelper-QueueSeekAction0 = 44,
		Beyond-Audio-AudioAdapter-SeekOnEvent2 = 45,
		Beyond-Audio-AudioAdapter-SeekOnEvent3 = 46,
		Beyond-Audio-AudioAdapter-TryGetPlayingPosition0 = 47,
		Beyond-Audio-AudioAdapter-IsPlaying0 = 48,
		Beyond-Audio-AudioAdapter-ReleaseAllCachedEventsSync0 = 49,
		Beyond-Audio-AudioAssetHelper-ReleaseAllCachedEventsSync0 = 50,
		Beyond-Audio-AudioAssetCache-GetCachedAssetCount0 = 51,
		Beyond-Audio-AudioAssetHelper-_DoGc0 = 52,
		Beyond-Audio-AudioAssetCache-GetLeastActiveAssetAndUncache0 = 53,
		Beyond-Audio-AudioAssetCache-Cache-RemoveFirst0 = 54,
		Beyond-Audio-AudioAssetHelper-_TryConsumePendingLoadRequests0 = 55,
		Beyond-Audio-AudioAssetHelper-_ConsumePendingLoadRequests0 = 56,
		Beyond-Audio-AudioAssetHelper-_DoLoadEventAsync0 = 57,
		Beyond-Audio-AudioAssetCache-ActivateAsset0 = 58,
		Beyond-Audio-AudioAssetCache-Cache-Remove0 = 59,
		Beyond-Audio-AudioAssetHelper-_TryDequeueAndInvokeCallback0 = 60,
		Beyond-Audio-AudioAdapter-SetLargePositions0 = 61,
		Beyond-Audio-AudioPositionArrayProxy-GetRawArray0 = 62,
		Beyond-Audio-AudioAdapter-SetDefaultListener0 = 63,
		Beyond-Audio-AudioAdapter-SetListener0 = 64,
		Beyond-Audio-AudioAdapter-TryGetRealPlayingId0 = 65,
		Beyond-Audio-AudioAdapter-SetDefaultEmitter0 = 66,
		Beyond-Audio-AudioAdapter-SetAudioLanguage0 = 67,
		Beyond-Audio-AudioVFSLoader-TryLoadLanguagePck0 = 68,
		Beyond-Audio-AudioVFSLoader-_GetVfsBlockTypeFromLanguage0 = 69,
		Beyond-Audio-AudioVFSLoader-_DoLoadLanguageAndHotfixPck0 = 70,
		Beyond-Audio-AudioVFSLoader-_UnloadPcks0 = 71,
		Beyond-Audio-AudioVFSLoader-_TryLoadPcksFromVfsInfo0 = 72,
		Beyond-Audio-AudioVFSLoader-_DoLoadPcksFromVfs0 = 73,
		Beyond-Audio-AudioVFSLoader-_DoLoadSinglePckFromVfs0 = 74,
		Beyond-Audio-AudioAdapter-SetDistanceProbe0 = 75,
		Beyond-Audio-AudioAdapter-SetAudioEngineInitSetting0 = 76,
		Beyond-Audio-AudioAdapter-UnsetAudioEngineInitSetting0 = 77,
		Beyond-Audio-AudioAdapter-InitWwise0 = 78,
		Beyond-Audio-AudioAdapter-_InitInternal0 = 79,
		Beyond-Audio-AudioAdapter-_ResetStaticFields0 = 80,
		Beyond-Audio-AudioAdapter-Context-Reset0 = 81,
		Beyond-Audio-AudioAdapter-PayloadPostEvent-OnRecycle0 = 82,
		Beyond-Audio-AudioAssetHelper-ResetStaticFields0 = 86,
		Beyond-Audio-AudioAssetCache-Reset0 = 87,
		Beyond-Audio-AudioAssetCache-Cache-Clear0 = 88,
		Beyond-Audio-AudioAdapter-_InitAndroidActivityEnvironment0 = 92,
		Beyond-Audio-AudioCallbackMessageParser-Set0 = 93,
		Beyond-Audio-AudioMemoryMonitor-Init0 = 94,
		Beyond-Audio-AudioAdapter-Context-PostSoundEngineInit0 = 95,
		Beyond-Audio-AudioVFSLoader-InitBasePaths0 = 96,
		Beyond-Audio-AudioVFSLoader-VfsLoadedInfo-Create0 = 97,
		Beyond-Audio-AudioAdapter-LoadInitResources0 = 98,
		Beyond-Audio-AudioVFSLoader-TryLoadInitPck0 = 99,
		Beyond-Audio-AudioAdapter-TermWwise0 = 100,
		Beyond-Audio-AudioAdapter-_ReleaseInternal0 = 101,
		Beyond-Audio-AudioActionQueueHelper-ClearQueue0 = 102,
		Beyond-Audio-AudioAdapter-_OnBeforeTerminate0 = 103,
		Beyond-Audio-AudioAssetHelper-HasPreparingEvents0 = 104,
		Beyond-Audio-AudioAssetHelper-UnPrepareAllEventsSync0 = 105,
		Beyond-Audio-AudioAssetCache-GetAllUsingAssetsAndRelease0 = 106,
		Beyond-Audio-AudioMemoryMonitor-Release0 = 107,
		Beyond-Audio-AudioAdapter-ReloadInitResources0 = 108,
		Beyond-Audio-AudioBankManager-Reset0 = 109,
		Beyond-Audio-AudioVFSLoader-UnloadAll0 = 110,
		Beyond-Audio-AudioAdapter-MemoryShrink0 = 111,
		Beyond-Audio-AudioAdapter-TouchAudioHotfixPlaceholder0 = 112,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder10 = 113,
		Beyond-Audio-AudioAdapter-TouchAudioHotfixPlaceholderArgs0 = 114,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder20 = 115,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder30 = 116,
		Beyond-Audio-AudioAdapter-LoadExtraPckFromPath0 = 117,
		Beyond-Audio-AudioVFSLoader-LoadExtraPckFromPath0 = 118,
		Beyond-Audio-AudioAdapter-_OnEventPreparedDoPostEvent0 = 119,
		Beyond-Audio-AudioAdapter-_OnEventCallback0 = 120,
		Beyond-Audio-AudioAdapter-_OnExternalSourceEventCallback0 = 121,
		Beyond-Audio-AudioAdapter-_PostEvent0 = 122,
		Beyond-Audio-AudioAdapter-_ExecuteActionOnPlayingId0 = 123,
		Beyond-Audio-AudioActionQueueHelper-QueueExecuteAction0 = 124,
		Beyond-Audio-AudioAdapter-_SampleAllData0 = 125,
		Beyond-Audio-AudioAdapter-_SampleMemoryOnly0 = 126,
		Beyond-Audio-AudioAdapter-StartProfileCapture0 = 127,
		Beyond-Audio-AudioAdapter-StopProfileCapture0 = 128,
		Beyond-Audio-AudioAdapter-GetResourceSummaryData0 = 129,
		Beyond-Audio-AudioAdapter-GetGlobalMemoryStats0 = 130,
		Beyond-Audio-AudioAdapter-GetExtraMemoryStats0 = 131,
		Beyond-Audio-AudioAdapter-SetEnableSpatialAudio0 = 132,
		Beyond-Audio-AudioAdapter-SetObjectObstructionAndOcclusion0 = 133,
		Beyond-Audio-AudioAdapter-SetGeometry0 = 134,
		Beyond-Audio-AudioAdapter-SetGeometryInstance0 = 135,
		Beyond-Audio-AudioAdapter-SetRoom0 = 136,
		Beyond-Audio-AudioAdapter-SetPortal0 = 137,
		Beyond-Audio-AudioAdapter-Device-GetSpeakerConfiguration0 = 138,
		Beyond-Audio-AudioAdapter-Device-AddOutputDevice0 = 139,
		Beyond-Audio-AudioAdapter-Device-AddOutput0 = 140,
		Beyond-Audio-AudioAdapter-Device-GetOutputDeviceId0 = 141,
		Beyond-Audio-AudioAdapter-Device-RemoveOutputDevice0 = 142,
		Beyond-Audio-AudioAdapter-Device-Switch3DOutput0 = 143,
		Beyond-Audio-AudioAdapter-Device-SetOutputDeviceEffect0 = 144,
		Beyond-Audio-AudioAdapter-Device-GetMmDeviceIdFromScePadHandle0 = 145,
		Beyond-Audio-BankHandle-Dispose0 = 146,
		Beyond-Audio-AudioBankManager-UnloadBank0 = 148,
		Beyond-Audio-BankHandle-DecRef0 = 149,
		Beyond-Audio-BankHandle-IncRef0 = 151,
		Beyond-Audio-AsyncLoadBankTask-LoadBanksAsync0 = 152,
		Beyond-Audio-AsyncLoadBankTask-MoveNext0 = 153,
		Beyond-Audio-AsyncLoadBankTask-Reset0 = 154,
		Beyond-Audio-AsyncLoadBankTask-Dispose0 = 155,
		Beyond-Audio-AudioBankManager-LoadMainPCK0 = 156,
		Beyond-Audio-AudioVFSLoader-TryLoadMainPck0 = 157,
		Beyond-Audio-AudioBankManager-LoadBankAsync0 = 158,
		Beyond-Audio-AudioBankManager-_LoadBankCallback0 = 159,
		Beyond-Audio-AudioBankManager-UnloadAllBanks0 = 162,
		Beyond-Audio-AudioBankManager-IsBankLoaded0 = 163,
		Beyond-Audio-AudioBankManager-LoadDebugFilePackage0 = 164,
		Beyond-Audio-AudioBankManager-_PreResetBasePath0 = 165,
		Beyond-Audio-AudioBankManager-_PostResetBasePath0 = 166,
		Beyond-Audio-AudioBankManager-AddDebugBankPath0 = 167,
		Beyond-Audio-AudioId-GetName0 = 168,
		Beyond-Audio-AudioId-op_Implicit1 = 169,
		Beyond-Audio-AudioId-op_Implicit2 = 170,
		Beyond-Audio-AudioId-op_Implicit3 = 171,
		Beyond-Audio-AudioId-op_Implicit4 = 172,
		Beyond-Audio-AudioIdExtensions-ToUIntArray0 = 173,
		Beyond-Audio-AudioState-Equals0 = 174,
		Beyond-Audio-AudioState-Equals1 = 175,
		Beyond-Audio-AudioState-GetHashCode0 = 176,
		Beyond-Audio-AudioCallbackInfo-CastToDurationCallbackInfo0 = 177,
		Beyond-Audio-AudioPositionArrayProxy-Add0 = 178,
		Beyond-Audio-AudioPositionArrayProxy-Reset0 = 179,
		Beyond-Audio-AudioLogger-IsChannelEnabled0 = 180,
		Beyond-Audio-AudioLogger-EnableChannel0 = 181,
		Beyond-Audio-AudioLogger-DisableChannel0 = 182,
		Beyond-Audio-AudioLogger-SetChannels0 = 183,
		Beyond-Audio-AudioLogger-Log0 = 184,
		Beyond-Audio-AudioLogger-_DoLog0 = 185,
		Beyond-Audio-AudioLogger-LogWarning0 = 186,
		Beyond-Audio-AudioLogger-_DoLogWarning0 = 187,
		Beyond-Audio-AudioLogger-LogError0 = 188,
		Beyond-Audio-AudioLogger-_DoLogError0 = 189,
		Beyond-Audio-AudioAcousticUtil-RT60DecayTime0 = 190,
		Beyond-Audio-AudioAcousticUtil-PreDelayTime0 = 191,
		Beyond-Audio-AudioAcousticUtil-CriticalDistance0 = 192,
		Beyond-Audio-AudioAcousticUtil-ReverbIntensity0 = 193,
		Beyond-Audio-AudioAcousticUtil-ErIntensity0 = 194,
		Beyond-Audio-AudioActionQueueHelper-ConsumeQueue0 = 195,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeExecute0 = 196,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeRtpc0 = 197,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeSeek0 = 198,
		Beyond-Audio-AudioAssetCache-PinEvent0 = 199,
		Beyond-Audio-AudioAssetCache-UnpinEvent0 = 200,
		Beyond-Audio-AudioAssetCache-DeactivateAsset0 = 201,
		Beyond-Audio-AudioAssetCache-Cache-AddLast0 = 202,
		Beyond-Audio-AudioAssetCache-ForceReleaseCachedAsset0 = 203,
		Beyond-Audio-AudioAssetCache-_NotifyDebugger0 = 204,
		Beyond-Audio-AudioAssetCache-_NotifyDebuggerCacheHit0 = 205,
		Beyond-Audio-AudioAssetCache-_ResetDebugger0 = 206,
		Beyond-Audio-AudioAssetCache-_PinnedEventLeakDetect0 = 207,
		Beyond-Audio-AudioAssetCache-Cache-get_lruCachedEventsList0 = 208,
		Beyond-Audio-AudioAssetHelper-SetMemoryBudget0 = 209,
		Beyond-Audio-AudioAssetHelper-_OnUnpreparedDoUnloadBank0 = 210,
		Beyond-Audio-AudioAssetHelper-_OnDoneUnloadBank0 = 211,
		Beyond-Audio-AudioAssetHelper-_OnBankLoadedDoPrepareEvent0 = 212,
		Beyond-Audio-AudioAssetHelper-_OnDonePrepareEvent0 = 213,
		Beyond-Audio-AudioAssetHelper-_RemoveLoadingDebug0 = 214,
		Beyond-Audio-AudioAssetHelper-_AddLoadingDebug0 = 215,
		Beyond-Audio-AudioAssetHelper-_ClearLoadingDebug0 = 216,
		Beyond-Audio-AudioDebugInfoContainer-SetAudioObjectName0 = 217,
		Beyond-Audio-AudioDebugInfoContainer-RemoveAudioObjectName0 = 218,
		Beyond-Audio-AudioDebugInfoContainer-ForceGetEventName0 = 219,
		Beyond-Audio-AudioDebugInfoContainer-ForceGetRtpcName0 = 220,
		Beyond-Audio-AudioHashGenerator-Compute2 = 221,
		Beyond-Audio-AudioHashGenerator-Compute1 = 222,
		Beyond-Audio-AudioHashGenerator-Compute3 = 223,
		Beyond-Audio-AudioHashGenerator-Compute4 = 224,
		Beyond-Audio-AudioMemoryMonitor-GetGlobalMemoryStats0 = 225,
		Beyond-Audio-AudioMemoryMonitor-GetExtraMemoryStats0 = 226,
		Beyond-Audio-AudioMemoryMonitor-GetUsedMemoryByCategory0 = 227,
		Beyond-Audio-AudioUIUtil-Init0 = 228,
		Beyond-Audio-AudioUIUtil-Release0 = 229,
		Beyond-Audio-AudioUIUtil-PostUIEvent0 = 230,
		Beyond-Audio-AudioUIUtil-PostUIEvent1 = 231,
		Beyond-Audio-AudioUIUtil-OnUIPanelClose0 = 232,
		Beyond-Audio-AudioUIUtil-OnUIPanelOpen0 = 233
	}
}
