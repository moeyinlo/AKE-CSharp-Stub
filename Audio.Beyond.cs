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
using Beyond.Cfg;
using Beyond.PoolCore;
using Beyond.VFS;
using IFix.Core;
using Newtonsoft.Json;
using Unity.Profiling;
using UnityEngine;

// Image 58: Audio.Beyond.dll - Assembly: Audio.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61319-61401
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 61397
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _662FC6EB33F1099AA2416EFBD9D5716B0AC7D68036E4C225784C78C03695D2AC; // 0x00 // Static value (base64): S7HlCQ17hMDxZ40p - Metadata: 0x0234FA7C

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 61396
	{
	}
}

namespace Beyond.Audio
{
	public static class AudioAdapter // TypeDefIndex: 61333
	{
		// Fields
		private static readonly AkCallbackManager.BankCallback ON_EVENT_PREPARED_DO_POST_EVENT; // 0x00
		private static readonly AkCallbackManager.EventCallback ON_EVENT_CALLBACK; // 0x08
		private static readonly AkCallbackManager.EventCallback ON_EXTERNAL_SOURCE_EVENT_CALLBACK; // 0x10
	
		// Properties
		public static ulong listenerObjId { get; } // 0x0000000184D4E610-0x0000000184D4E670 
	
		// Nested types
		private static class Context // TypeDefIndex: 61326
		{
			// Fields
			public static ulong s_listenerObjId; // 0x00
			public static ulong s_2dEmitterObjectId; // 0x08
			public static uint s_playingIdInternal; // 0x10
			public static Dictionary<uint, uint> s_playingIdLut; // 0x18
			public static ObjectPool<PayloadPostEvent> s_payloadPool; // 0x20
			private static readonly Action<PayloadPostEvent> s_recyclePayloadPostEvent; // 0x28
			private static readonly Func<PayloadPostEvent> s_createPayloadPostEvent; // 0x30
			public static readonly AkExternalSourceInfoArray S_EXTERNAL_SOURCE_INFO_ARRAY; // 0x38
			public static AkRoomParams s_reusableAkRoomParams; // 0x40
	
			// Constructors
			static Context(); // 0x0000000184770C80-0x0000000184771D50
	
			// Methods
			public static void PostSoundEngineInit(); // 0x0000000184B09520-0x0000000184B095E0
			public static void Reset(); // 0x0000000183FE1AB0-0x0000000183FE2A40
			private static PayloadPostEvent _CreatePayloadPostEvent(); // 0x00000001811C5C00-0x00000001811C6280
		}
	
		private class PayloadPostEvent // TypeDefIndex: 61327
		{
			// Fields
			public ulong audioObjectId; // 0x10
			public uint callbackType; // 0x18
			public uint internalPlayingId; // 0x1C
			public AudioEventCallback callback; // 0x20
			public object cookie; // 0x28
	
			// Constructors
			public PayloadPostEvent(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public static void OnRecycle(PayloadPostEvent obj); // 0x000000018328A610-0x000000018328A690
		}
	
		public static class Device // TypeDefIndex: 61328
		{
			// Methods
			public static bool GetSpeakerConfiguration(out AudioChannelMask channelMask, out uint numChannels, out AudioChannelConfigType configType); // 0x0000000183AC7440-0x0000000183AC7530
			public static bool AddOutputDevice(string deviceName, uint deviceId, uint numChannels, uint speakerSetup, out ulong outDeviceId); // 0x000000018635F9F8-0x000000018635FB54
			public static bool AddOutput(string shareSetName, uint deviceId, out ulong outId); // 0x000000018635FB54-0x000000018635FC34
			public static ulong GetOutputDeviceId(string shareSetName, uint deviceId); // 0x000000018635FCAC-0x000000018635FD38
			public static bool RemoveOutputDevice(ulong output); // 0x000000018635FD38-0x000000018635FDD8
			public static bool Switch3DOutput(bool use3DDevice); // 0x0000000184008EC0-0x0000000184009060
			public static void SetOutputDeviceEffect(ulong outputDeviceId, uint effectIdx, uint shareSetId); // 0x000000018635FDD8-0x000000018635FE78
			public static uint GetMmDeviceIdFromScePadHandle(int scePadHandle); // 0x000000018635FC34-0x000000018635FCAC
		}
	
		[CompilerGenerated]
		private sealed class _LoadAndPinEventsCoroutine_d__26 : IEnumerator<object> // TypeDefIndex: 61329
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ICollection<string> events; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _LoadAndPinEventsCoroutine_d__26(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001863659F8-0x0000000186365C88
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186365C88-0x0000000186365CD4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass100_0 // TypeDefIndex: 61330
		{
			// Fields
			public int doneCount; // 0x10
			public AkCallbackManager.BankCallback __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass100_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __DoLoadAndPinEventsSync_b__0(uint _, IntPtr _, AKRESULT _, object _); // 0x0000000184D86170-0x0000000184D86180
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass101_0 // TypeDefIndex: 61331
		{
			// Fields
			public int doneCount; // 0x10
			public AkCallbackManager.BankCallback __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass101_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __DoLoadAndPinEventsAsync_b__0(uint _, IntPtr _, AKRESULT _, object _); // 0x0000000184D86170-0x0000000184D86180
		}
	
		[CompilerGenerated]
		private sealed class __DoLoadAndPinEventsAsync_d__101 : IEnumerator<object> // TypeDefIndex: 61332
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public IList<uint> events; // 0x20
			public Action<object> onDone; // 0x28
			public object payload; // 0x30
			private __c__DisplayClass101_0 __8__1; // 0x38
			private int _allCount_5__2; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DoLoadAndPinEventsAsync_d__101(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001837A6DC0-0x00000001837A7440
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186365CD4-0x0000000186365D20
		}
	
		// Constructors
		static AudioAdapter(); // 0x0000000183EAE030-0x0000000183EAE190
	
		// Methods
		public static uint PostEvent(string eventName); // 0x00000001846D3F80-0x00000001846D40A0
		public static uint PostEvent(uint eventId); // 0x000000018635A6D8-0x000000018635A760
		public static uint PostEvent(string eventName, ulong audioObjectId); // 0x000000018635A8AC-0x000000018635A924
		public static uint PostEvent(uint eventId, ulong audioObjectId); // 0x000000018635A924-0x000000018635A984
		public static uint PostEvent(string eventName, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null); // 0x000000018635A984-0x000000018635AA40
		public static uint PostEvent(uint eventId, [IsReadOnly] in AudioCallbackType callbackType, [IsReadOnly] in AudioEventCallback callback, object cookie = null); // 0x000000018635A7F8-0x000000018635A8AC
		public static uint PostEvent(string eventName, ulong audioObjectId, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null); // 0x000000018635A760-0x000000018635A7F8
		public static uint PostEvent(uint eventId, ulong audioObjectId, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null); // 0x000000018635A65C-0x000000018635A6D8
		[IDTag(0)]
		public static uint PostEventExternal(string eventName, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x0234F814 */); // 0x0000000183ABF0A0-0x0000000183ABF1B0
		[IDTag(1)]
		public static uint PostEventExternal(uint eventId, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x0234F815 */); // 0x000000018635A51C-0x000000018635A65C
		public static void StopByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x0234F816 */); // 0x000000018635BBD0-0x000000018635BC20
		public static void PauseByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x0234F818 */); // 0x000000018635A480-0x000000018635A4D4
		public static void ResumeByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x0234F81A */); // 0x000000018635AF50-0x000000018635AFA4
		public static void PinEvent(uint eventId); // 0x000000018635A4D4-0x000000018635A51C
		public static void UnpinEvent(uint eventId); // 0x000000018635C160-0x000000018635C1AC
		public static void UnpinEvent(string eventName); // 0x000000018635C1AC-0x000000018635C20C
		[IDTag(0)]
		public static void LoadAndPinEventsSync(IList<uint> events); // 0x000000018635A2DC-0x000000018635A354
		[IDTag(1)]
		public static void LoadAndPinEventsSync(ICollection<string> events); // 0x000000018635A0A8-0x000000018635A2DC
		[IDTag(0)]
		public static void LoadAndPinEventsAsync(IList<uint> events, Action<object> onDone = null, object payload = null); // 0x0000000183EB4B70-0x0000000183EB4BF0
		[IDTag(1)]
		public static void LoadAndPinEventsAsync(IList<AudioId> events, Action<object> onDone = null, object payload = null); // 0x0000000183EB4BF0-0x0000000183EB4DF0
		[IDTag(2)]
		public static void LoadAndPinEventsAsync(ICollection<string> events, Action<object> onDone = null, object payload = null); // 0x0000000186359D38-0x0000000186359FA0
		[IDTag(0)]
		public static IEnumerator LoadAndPinEventsCoroutine(IList<uint> events); // 0x000000018635A02C-0x000000018635A0A8
		[IDTag(1)]
		[IteratorStateMachine(typeof(_LoadAndPinEventsCoroutine_d__26))]
		public static IEnumerator LoadAndPinEventsCoroutine(ICollection<string> events); // 0x0000000186359FA0-0x000000018635A02C
		public static void SetState(string stateGroup, string stateName); // 0x000000018635B950-0x000000018635B9AC
		public static void SetState(uint stateGroup, uint stateName); // 0x000000018635B8F8-0x000000018635B950
		public static bool TryGetState(uint stateGroupId, out uint stateId); // 0x000000018635C108-0x000000018635C160
		[IDTag(0)]
		public static void SetSwitch(uint switchGroup, uint switchValue, ulong audioObjectId); // 0x000000018635B9AC-0x000000018635BA4C
		[IDTag(1)]
		public static void SetSwitch(string switchGroup, string switchValue, ulong audioObjectId); // 0x000000018635BA4C-0x000000018635BB00
		[IDTag(1)]
		public static void SetRtpc(string rtpcName, float rtpcValue, int fadeTimeMs = 0 /* Metadata: 0x0234F81C */); // 0x000000018459C4D0-0x000000018459C560
		[IDTag(0)]
		public static void SetRtpc(uint rtpcId, float rtpcValue, int fadeTimeMs = 0 /* Metadata: 0x0234F81D */); // 0x000000018459C560-0x000000018459C5F0
		[IDTag(3)]
		public static void SetRtpc(string rtpcName, float rtpcValue, ulong audioObjectId); // 0x0000000183F92DA0-0x0000000183F92E30
		[IDTag(2)]
		public static void SetRtpc(uint rtpcId, float rtpcValue, ulong audioObjectId); // 0x0000000183197B80-0x0000000183197C40
		[IDTag(4)]
		public static void SetRtpc(uint rtpcId, float rtpcValue, ulong audioObjectId, int fadeTimeMs); // 0x000000018635B7E8-0x000000018635B89C
		public static void SetRtpcValueByPlayingID(uint rtpcId, float rtpcValue, uint playingId, int fadeTimeMs); // 0x00000001845E4230-0x00000001845E4370
		[IDTag(0)]
		public static void ResetRtpc(uint rtpcId, ulong audioObjectId, int fadeTimeMs); // 0x000000018635AE0C-0x000000018635AEA8
		[IDTag(1)]
		public static void ResetRtpc(string rtpcName, ulong audioObjectId, int fadeTimeMs = 100 /* Metadata: 0x0234F81E */); // 0x000000018635AEA8-0x000000018635AF50
		public static bool GetRtpcValue(string rtpcName, ulong audioObjectId, uint playingId, out float value, ref int valueType); // 0x0000000186359B20-0x0000000186359C0C
		public static bool GetRtpcValue(uint rtpcId, ulong audioObjectId, uint playingId, out float value, ref int valueType); // 0x0000000186359C0C-0x0000000186359CF8
		[IDTag(1)]
		public static void SeekOnEvent(string eventName, ulong audioObjectId, int timeMs, bool toNearestMarker, uint playingId); // 0x000000018635B2E4-0x000000018635B3B4
		[IDTag(0)]
		public static void SeekOnEvent(uint eventId, ulong audioObjectId, int timeMs, bool toNearestMarker, uint playingId); // 0x000000018635B094-0x000000018635B1F4
		[IDTag(2)]
		public static void SeekOnEvent(string eventName, int timeMs, bool toNearestMarker, uint playingId); // 0x000000018635AFA4-0x000000018635B094
		[IDTag(3)]
		public static void SeekOnEvent(uint eventId, int timeMs, bool toNearestMarker, uint playingId); // 0x000000018635B1F4-0x000000018635B2E4
		public static bool TryGetPlayingPosition(uint playingId, out int posTimeMs, bool extrapolate = true /* Metadata: 0x0234F820 */); // 0x000000018635C008-0x000000018635C108
		public static bool TryGetMusicPlayingPosition(uint playingId, out int posTimeMs, bool extrapolate = true /* Metadata: 0x0234F821 */); // 0x000000018635BECC-0x000000018635C008
		public static bool IsPlaying(uint playingId); // 0x00000001844B02F0-0x00000001844B03E0
		public static uint SetScalingFactor(ulong audioObjectId, float factor); // 0x000000018635B89C-0x000000018635B8F8
		public static bool RegisterGameObject(ulong audioObjectId); // 0x000000018635AA98-0x000000018635AAE0
		public static bool RegisterGameObject(ulong audioObjectId, string name); // 0x000000018635AA40-0x000000018635AA98
		public static bool UnregisterGameObject(ulong audioObjectId); // 0x000000018635C20C-0x000000018635C254
		public static void SetPosition(ulong audioObjectId, UnityEngine.Vector3 pos, UnityEngine.Vector3 forward, UnityEngine.Vector3 up); // 0x000000018635B6C8-0x000000018635B778
		public static void StopAll(); // 0x000000018635BB90-0x000000018635BBD0
		public static void StopAllOnObject(ulong audioObjectId); // 0x000000018635BB44-0x000000018635BB90
		public static void ReleaseAllCachedEventsSync(); // 0x0000000183EB1220-0x0000000183EB1280
		public static void SetLargePositions(ulong audioObjectId, AudioPositionArrayProxy positions, AudioLargeType type = AudioLargeType.Sum /* Metadata: 0x0234F822 */); // 0x0000000183B8B550-0x0000000183B8B620
		public static void SetDefaultListener(ulong audioObjectId); // 0x000000018434CC10-0x000000018434CD20
		public static void SetListener(ulong audioObjectId, ulong listenerId); // 0x000000018635B4BC-0x000000018635B588
		public static bool TryGetRealPlayingId(uint playingId, out uint realPlayingId); // 0x000000018436E720-0x000000018436E7A0
		public static void SetDefaultEmitter(ulong audioObjectId); // 0x000000018434CBA0-0x000000018434CC10
		public static void SetAudioLanguage(string language); // 0x0000000183EB4480-0x0000000183EB4510
		public static void SetDistanceProbe(ulong probeObjectId = 18446744073709551615 /* Metadata: 0x0234F823 */); // 0x000000018635B410-0x000000018635B4BC
		public static uint ComputeIdFromString(string name); // 0x0000000186359A04-0x0000000186359A24
		public static void SetAudioEngineInitSetting(AudioEngineInitSetting settings); // 0x0000000183EB41E0-0x0000000183EB42C0
		public static void UnsetAudioEngineInitSetting(); // 0x000000018635C254-0x000000018635C2BC
		public static bool InitWwise(); // 0x0000000183EB4170-0x0000000183EB41E0
		public static void TermWwise(bool hgDeepTerm = false /* Metadata: 0x0234F82B */); // 0x000000018635BCAC-0x000000018635BD20
		public static void LoadInitResources(); // 0x0000000183EB4710-0x0000000183EB47A0
		public static void ReloadInitResources(); // 0x000000018635AAE0-0x000000018635AC04
		public static void RenderAudio(); // 0x000000018635AD94-0x000000018635AE0C
		public static void Suspend(bool renderAnyway); // 0x000000018635BC60-0x000000018635BCAC
		public static void WakeupFromSuspend(); // 0x000000018635C2BC-0x000000018635C2FC
		public static void InitScePad(); // 0x0000000186359CF8-0x0000000186359D38
		public static void SetAudioMemoryBudget(ulong inMemoryBytes, ushort inGcCount = 10 /* Metadata: 0x0234F82C */); // 0x000000018635B3B4-0x000000018635B410
		[Conditional("ENABLE_PROFILER")]
		public static void LogToWwise(string msg, bool isError = false /* Metadata: 0x0234F82E */, uint playingId = 0 /* Metadata: 0x0234F82F */, ulong goId = 0 /* Metadata: 0x0234F830 */); // 0x000000018635A3CC-0x000000018635A440
		public static void MemoryShrink(); // 0x000000018635A440-0x000000018635A480
		public static void TouchAudioHotfixPlaceholder(); // 0x000000018635BDD8-0x000000018635BECC
		public static void TouchAudioHotfixPlaceholderArgs(string[] stringArray, int[] intArray, uint[] uintArray, float[] floatArray, bool[] boolArray, long[] longArray, ulong[] ulongArray, double[] doubleArray, object[] objects); // 0x000000018635BD20-0x000000018635BDD8
		public static void AudioHotfixPlaceholder1(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null); // 0x0000000186359518-0x00000001863596BC
		public static void AudioHotfixPlaceholder2(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null); // 0x00000001863596BC-0x0000000186359860
		public static void AudioHotfixPlaceholder3(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null); // 0x0000000186359860-0x0000000186359A04
		public static void LoadExtraPckFromPath(string path); // 0x000000018635A354-0x000000018635A3CC
		private static bool _InitInternal(); // 0x0000000183AC7880-0x0000000183AC9A30
		private static void _ReleaseInternal(bool hgDeepTerm = false /* Metadata: 0x0234F838 */); // 0x000000018635C7C8-0x000000018635CA5C
		private static void _OnBeforeTerminate(); // 0x000000018635C73C-0x000000018635C7C8
		private static void _ResetStaticFields(); // 0x0000000183FE2B10-0x0000000183FE2BA0
		private static void _OnEventPreparedDoPostEvent(uint inId, IntPtr _, AKRESULT __, object inCookie); // 0x000000018328C670-0x000000018328C940
		private static void _OnEventCallback(object inCookie, AkCallbackType inType, AkCallbackInfo inInfo); // 0x000000018328D3E0-0x000000018328DA50
		private static void _OnExternalSourceEventCallback(object inCookie, AkCallbackType inType, AkCallbackInfo inInfo); // 0x00000001843C7930-0x00000001843C7D30
		private static uint _PostEvent(uint eventId, ulong audioObjectId, AudioCallbackType callbackType = AudioCallbackType.None /* Metadata: 0x0234F839 */, AudioEventCallback originCallback = null, object originCookie = null); // 0x000000018328A690-0x000000018328AC00
		private static uint _PostEventWithExternalSource(uint eventId, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x0234F83A */); // 0x0000000183ABEA70-0x0000000183ABED90
		private static void _ExecuteActionOnPlayingId(AkActionOnEventType type, uint playingId, int durationMs = 100 /* Metadata: 0x0234F83B */); // 0x0000000183870420-0x0000000183870520
		private static uint _GetInternalPlayingId(); // 0x000000018635C604-0x000000018635C65C
		private static void _LoadAndPinEventsAsync([IsReadOnly] in IList<uint> events, [IsReadOnly] in Action<object> onDone = null, [IsReadOnly] in object payload = null); // 0x000000018635C65C-0x000000018635C73C
		private static void _DoLoadAndPinEventsSync(IList<uint> events); // 0x000000018635C2FC-0x000000018635C604
		[IteratorStateMachine(typeof(__DoLoadAndPinEventsAsync_d__101))]
		private static IEnumerator _DoLoadAndPinEventsAsync(IList<uint> events, Action<object> onDone = null, object payload = null); // 0x0000000183EB4DF0-0x0000000183EB4EA0
		private static void _InitAndroidActivityEnvironment(); // 0x0000000184D83C80-0x0000000184D83CA0
		[Conditional("ENABLE_PROFILER")]
		internal static void SetUprSamplingEnabled(bool isEnabled); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("ENABLE_PROFILER")]
		private static void _ProfilerUpdate(); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("ENABLE_PROFILER")]
		private static void _SampleAllData(); // 0x000000018635CA5C-0x000000018635CA9C
		[Conditional("ENABLE_PROFILER")]
		private static void _SampleMemoryOnly(); // 0x000000018635CA9C-0x000000018635CADC
		[Conditional("ENABLE_PROFILER")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void StartProfileCapture(string fileName = null); // 0x000000018635BB00-0x000000018635BB44
		[Conditional("ENABLE_PROFILER")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void StopProfileCapture(); // 0x000000018635BC20-0x000000018635BC60
		public static AkResourceMonitorDataSummary GetResourceSummaryData(); // 0x0000000186359AE0-0x0000000186359B20
		public static AudioMemoryMonitor.FGlobalMemoryStats GetGlobalMemoryStats(); // 0x0000000186359A88-0x0000000186359AE0
		public static AudioMemoryMonitor.FExtraMemoryStats GetExtraMemoryStats(); // 0x0000000186359A24-0x0000000186359A88
		public static void SetEnableSpatialAudio(bool enable); // 0x00000001840087B0-0x00000001840088B0
		public static void SetObjectObstructionAndOcclusion(ulong audioObjectId, float obstructionLevel, float occlusionLevel); // 0x000000018635B588-0x000000018635B658
		public static bool SetGeometry(ulong geoId, UnityEngine.Vector3[] vertices, ushort[] triangles, AudioAcousticSurfaceData[] surfaceData, ushort[] surfaceIdx, bool enableDiffraction = true /* Metadata: 0x0234F83D */, bool enableEdgeDiffraction = false /* Metadata: 0x0234F83E */); // 0x0000000183529D60-0x000000018352A130
		public static bool SetGeometryInstance(ulong instanceId, UnityEngine.Vector3 pos, UnityEngine.Vector3 scale, Quaternion rot, ulong geoId, bool useReflectionAndDiffraction = false /* Metadata: 0x0234F83F */); // 0x0000000183CDEB70-0x0000000183CDECB0
		public static bool SetRoom(ulong roomId, AudioRoomData roomData, ulong geoInstanceId, string roomName = "room" /* Metadata: 0x0234F840 */); // 0x0000000183CDF150-0x0000000183CDF410
		public static bool SetPortal(ulong portalId, ulong roomIdA, ulong roomIdB, UnityEngine.Vector3 pos, Quaternion rot, UnityEngine.Vector3 extent, bool enabled, string portalName = "portal" /* Metadata: 0x0234F845 */); // 0x0000000183CDFFE0-0x0000000183CE0200
		public static bool SetPortalObstructionAndOcclusion(ulong portalId, float obstruction, float occlusion); // 0x000000018635B658-0x000000018635B6C8
		public static bool SetReverbZone(ulong reverbZoneId, ulong parentRoom, float transitionWidth); // 0x000000018635B778-0x000000018635B7E8
		public static bool RemoveRoom(ulong roomId); // 0x000000018635AD44-0x000000018635AD94
		public static bool RemovePortal(ulong portalId); // 0x000000018635ACA4-0x000000018635ACF4
		public static bool RemoveGeometry(ulong geoId); // 0x000000018635AC54-0x000000018635ACA4
		public static bool RemoveGeometryInstance(ulong instanceId); // 0x000000018635AC04-0x000000018635AC54
		public static bool RemoveReverbZone(ulong reverbZoneId); // 0x000000018635ACF4-0x000000018635AD44
	}

	public delegate void AudioEventCallback(object in_cookie, AudioCallbackType in_type, AudioCallbackInfo in_info); // TypeDefIndex: 61334; 0x000000018622803C-0x0000000186228074

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioStringAttribute : PropertyAttribute // TypeDefIndex: 61335
	{
		// Constructors
		public AudioStringAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioVectorAttribute : PropertyAttribute // TypeDefIndex: 61336
	{
		// Constructors
		public AudioVectorAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioEventWarnAttribute : PropertyAttribute // TypeDefIndex: 61338
	{
		// Fields
		public WarnType warnType; // 0x10
	
		// Nested types
		public enum WarnType : byte // TypeDefIndex: 61337
		{
			NONE = 0,
			ONE_SHOT = 2,
			LOOP = 4
		}
	
		// Constructors
		public AudioEventWarnAttribute(WarnType type); // 0x0000000184D86130-0x0000000184D86140
	}

	public class BankHandle : IDisposable // TypeDefIndex: 61339
	{
		// Fields
		[CompilerGenerated]
		private readonly string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		private AKRESULT _result_k__BackingField; // 0x18
		[CompilerGenerated]
		private bool _isDone_k__BackingField; // 0x1C
		private int m_refCount; // 0x20
	
		// Properties
		public string name { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public AKRESULT result { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public bool isDone { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86150-0x0000000184D86160 0x0000000184D86160-0x0000000184D86170
		public int refCount { get; } // 0x000000018635F95C-0x000000018635F9A8 
	
		// Constructors
		public BankHandle(string bankName); // 0x0000000183EAE680-0x0000000183EAE6A0
	
		// Methods
		public void Dispose(); // 0x000000018635F890-0x000000018635F910
		public void IncRef(); // 0x000000018635F910-0x000000018635F95C
		public void DecRef(); // 0x000000018635F844-0x000000018635F890
	}

	public class AsyncLoadBankTask : IEnumerator, IDisposable // TypeDefIndex: 61340
	{
		// Fields
		private readonly List<BankHandle> m_handles; // 0x10
	
		// Properties
		public object Current { get; } // 0x0000000183CF12F0-0x0000000183CF1320 
	
		// Constructors
		public AsyncLoadBankTask(IList<string> bankNames); // 0x0000000183EAE8A0-0x0000000183EAEE30
	
		// Methods
		public static AsyncLoadBankTask LoadBanksAsync(IList<string> bankNames); // 0x0000000183EADFB0-0x0000000183EAE030
		public bool MoveNext(); // 0x000000018481FF90-0x00000001848200D0
		public void Reset(); // 0x0000000186358EE8-0x0000000186358F38
		public void Dispose(); // 0x0000000186358D98-0x0000000186358EE8
	}

	public static class AudioBankManager // TypeDefIndex: 61342
	{
		// Fields
		private static readonly AkCallbackManager.BankCallback s_loadBankCallback; // 0x00
		internal static Dictionary<string, BankHandle> s_loadedBankHandles; // 0x08
	
		// Nested types
		public class CallbackCookie // TypeDefIndex: 61341
		{
			// Fields
			public string bankName; // 0x10
			public Action callback; // 0x18
			public BankHandle handle; // 0x20
	
			// Constructors
			public CallbackCookie(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		static AudioBankManager(); // 0x0000000184D14E80-0x0000000184D15DC0
	
		// Methods
		public static void LoadMainPCK(); // 0x0000000183EB6F50-0x0000000183EB6FB0
		public static BankHandle LoadBankAsync(string bankName, Action callback = null); // 0x0000000183EAEE30-0x0000000183EB0640
		private static void _LoadBankCallback(uint inBankId, IntPtr _, AKRESULT inLoadResult, object inCookie); // 0x0000000183EAE6A0-0x0000000183EAE7F0
		public static bool UnloadBank(string bankName); // 0x000000018635DC44-0x000000018635DDB4
		public static void UnloadAllBanks(); // 0x000000018635DA48-0x000000018635DC44
		public static bool IsBankLoaded(string bankName); // 0x0000000183EAE7F0-0x0000000183EAE8A0
		public static void Reset(); // 0x000000018635D9B8-0x000000018635DA48
		[Conditional("ENABLE_PROFILER")]
		public static void LoadDebugFilePackage(string path); // 0x000000018635D884-0x000000018635D9B8
		[Conditional("ENABLE_PROFILER")]
		public static void AddDebugBankPath(string path); // 0x000000018635D7D4-0x000000018635D884
		private static void _PreResetBasePath(out List<uint> unPinnedEventIds); // 0x000000018635DE30-0x000000018635DF50
		private static void _PostResetBasePath(List<uint> unPinnedEventIds); // 0x000000018635DDB4-0x000000018635DE30
	}

	public class AudioConstants // TypeDefIndex: 61343
	{
		// Fields
		public const ulong AUDIO_INVALID_GAME_OBJECT = 18446744073709551615; // Metadata: 0x0234F84F
		public const uint AUDIO_INVALID_UNIQUE_ID = 0; // Metadata: 0x0234F857
		public const uint AUDIO_INVALID_INTERNAL_PLAYING_ID = 0; // Metadata: 0x0234F858
		public const ulong AUDIO_GLOBAL_GAME_OBJECT = 18446744073709551615; // Metadata: 0x0234F859
		public const ulong AUDIO_ROOM_OUTDOOR_ID = 18446744073709551615; // Metadata: 0x0234F861
		public const ulong AUDIO_ROOM_OUTDOORS_ID = 18446744073709551612; // Metadata: 0x0234F869
		public const string AU_UI_BATTLE_BREAK_POISE = "au_ui_bat_break_poise"; // Metadata: 0x0234F871
		public const string AU_GLOBAL_GAIN_ON = "au_global_gain_on"; // Metadata: 0x0234F887
		public const string AU_GLOBAL_GAIN_OFF = "au_global_gain_off"; // Metadata: 0x0234F899
		public const uint AU_HASH_EXTERNAL_SOURCE_COOKIE = 618371124; // Metadata: 0x0234F8AC
		public const uint AU_BANK_INIT = 1355168291; // Metadata: 0x0234F8B1
		public const string AU_DEVICE_CONTROLLER_SPEAKER = "Controller_Speaker"; // Metadata: 0x0234F8B6
		public const int AUDIO_SPEAKER_SETUP_4_0 = 1539; // Metadata: 0x0234F8C9
		public const string AU_DEVICE_WWISE_MOTION = "Wwise_Motion"; // Metadata: 0x0234F8CB
		public const string AU_DEVICE_SYSTEM = "System"; // Metadata: 0x0234F8D8
		public const string AU_DEVICE_SYSTEM_3D = "System_3D"; // Metadata: 0x0234F8DF
		public const uint AUDIO_UI_FULLSCREEN_OPEN = 3229907725; // Metadata: 0x0234F8E9
		public const uint AUDIO_UI_FULLSCREEN_CLOSE = 166048075; // Metadata: 0x0234F8EE
		public const uint AUDIO_UI_FULLSCREEN_PAUSE = 697133041; // Metadata: 0x0234F8F2
	
		// Constructors
		public AudioConstants(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public struct AudioId // TypeDefIndex: 61344
	{
		// Fields
		[JsonProperty]
		[SerializeField]
		public int _id; // 0x00
	
		// Constructors
		public AudioId(uint id); // 0x0000000184D86140-0x0000000184D86150
	
		// Methods
		public string GetName(); // 0x000000018635E5C4-0x000000018635E63C
		[IDTag(0)]
		public static implicit operator uint(AudioId id); // 0x0000000183197AD0-0x0000000183197B00
		[IDTag(1)]
		public static implicit operator int(AudioId id); // 0x0000000183197330-0x0000000183197360
		[IDTag(2)]
		public static implicit operator AudioId(uint id); // 0x0000000183B896B0-0x0000000183B89730
		[IDTag(3)]
		public static implicit operator AudioId(int id); // 0x000000018635E6A8-0x000000018635E6F4
		[IDTag(4)]
		public static implicit operator AudioId(string id); // 0x000000018635E63C-0x000000018635E6A8
	}

	public static class AudioIdExtensions // TypeDefIndex: 61345
	{
		// Extension methods
		public static uint[] ToUIntArray(this ICollection<AudioId> ids); // 0x000000018635E3E0-0x000000018635E5C4
	}

	[Serializable]
	public struct AudioState : IEquatable<AudioState> // TypeDefIndex: 61346
	{
		// Fields
		[SerializeField]
		private int _stateGroup; // 0x00
		[SerializeField]
		private int _stateValue; // 0x04
	
		// Properties
		public uint stateGroup { get; } // 0x000000018635F13C-0x000000018635F188 
		public uint stateValue { get; } // 0x000000018635F188-0x000000018635F1D4 
	
		// Constructors
		public AudioState(uint stateGroup, uint stateValue); // 0x0000000184D85C40-0x0000000184D85C50
	
		// Methods
		[IDTag(0)]
		public bool Equals(AudioState other); // 0x000000018635EEEC-0x000000018635EF58
		[IDTag(1)]
		public override bool Equals(object obj); // 0x000000018635EF58-0x000000018635EFF4
		public override int GetHashCode(); // 0x000000018635EFF4-0x000000018635F08C
		public bool __iFixBaseProxy_Equals(object P0); // 0x000000018635F08C-0x000000018635F0EC
		public int __iFixBaseProxy_GetHashCode(); // 0x000000018635F0EC-0x000000018635F13C
	}

	[Serializable]
	public struct AudioIdList // TypeDefIndex: 61347
	{
		// Fields
		public AudioId[] _ids; // 0x00
	}

	[Serializable]
	public struct AudioStateList // TypeDefIndex: 61348
	{
		// Fields
		[SerializeField]
		public AudioState[] _states; // 0x00
	}

	[Serializable]
	public struct AudioEngineInitSetting // TypeDefIndex: 61349
	{
		// Fields
		public AkWwiseInitializationSettings akInitSettings; // 0x00
	}

	[Serializable]
	public struct AudioLargeSource // TypeDefIndex: 61350
	{
		// Fields
		public UnityEngine.Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
	}

	public struct AudioCallbackInfo // TypeDefIndex: 61351
	{
		// Fields
		public ulong objectId; // 0x00
		public IntPtr pCookie; // 0x08
		internal AkCallbackInfo rawInfo; // 0x10
	
		// Methods
		public AudioDurationCallbackInfo CastToDurationCallbackInfo(); // 0x000000018635DF50-0x000000018635E05C
	}

	public struct AudioDurationCallbackInfo // TypeDefIndex: 61352
	{
		// Fields
		public float duration; // 0x00
		public float estimatedDuration; // 0x04
		public uint audioNodeId; // 0x08
		public uint mediaId; // 0x0C
		public bool isStreaming; // 0x10
	}

	public class AudioPositionArrayProxy // TypeDefIndex: 61353
	{
		// Fields
		private AkPositionArray m_array; // 0x10
	
		// Properties
		public uint count { get; } // 0x0000000183B8B650-0x0000000183B8B690 
	
		// Constructors
		public AudioPositionArrayProxy(uint count); // 0x00000001835AB520-0x00000001835AB5A0
	
		// Methods
		public AkPositionArray GetRawArray(); // 0x0000000183B8B620-0x0000000183B8B650
		public void Add(UnityEngine.Vector3 position, UnityEngine.Vector3 forward, UnityEngine.Vector3 up); // 0x0000000183B8B3D0-0x0000000183B8B4B0
		public void Reset(); // 0x0000000183B8B8A0-0x0000000183B8B8F0
		~AudioPositionArrayProxy(); // 0x0000000184416C20-0x0000000184416C70
	}

	[Serializable]
	public struct AudioAcousticSurfaceData // TypeDefIndex: 61354
	{
		// Fields
		public uint textureId; // 0x00
		[Range(0f, 1f)]
		public float transmissionLoss; // 0x04
	}

	[Serializable]
	public struct AudioRoomData // TypeDefIndex: 61356
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
		public enum EBoolFlags : ushort // TypeDefIndex: 61355
		{
			None = 0,
			KeepRegistered = 1,
			UseForReflectionAndDiffraction = 2,
			AsReverbZone = 4
		}
	}

	[Flags]
	public enum AudioCallbackType // TypeDefIndex: 61357
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

	public enum AudioLargeType : byte // TypeDefIndex: 61358
	{
		Sum = 0,
		Nearest = 1,
		Single = 2
	}

	[Flags]
	public enum AudioPlayableActions // TypeDefIndex: 61359
	{
		None = 0,
		Playback = 1,
		Stop = 2,
		Seek = 4
	}

	public enum AudioEventType // TypeDefIndex: 61360
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

	public enum AudioMixDownMode // TypeDefIndex: 61361
	{
		Direct = 0,
		ForceToMono = 1
	}

	public enum AudioMasteringSuiteMode // TypeDefIndex: 61362
	{
		Headphone = 1,
		TV = 2,
		HomeCinema = 3,
		SoundBar = 4,
		Speaker = 5,
		DevMode = 99
	}

	public enum AudioChannelConfigType : uint // TypeDefIndex: 61363
	{
		Anonymous = 0,
		Standard = 1,
		Ambisonic = 2,
		Objects = 3,
		UseDeviceMain = 14,
		UseDevicePassthrough = 15
	}

	public enum AudioCodec : uint // TypeDefIndex: 61364
	{
		PCM = 1,
		ADPCM = 2,
		VORBIS = 4,
		ATRAC9 = 12,
		OPUS_WEM = 20
	}

	public enum AudioChannelMask : uint // TypeDefIndex: 61365
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
	public enum AudioLogChannel // TypeDefIndex: 61366
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

	public static class AudioLogger // TypeDefIndex: 61367
	{
		// Fields
		public static AudioLogChannel s_enabledChannels; // 0x00
	
		// Constructors
		static AudioLogger(); // 0x0000000184D7AD50-0x0000000184D7AD90
	
		// Methods
		public static bool IsChannelEnabled(AudioLogChannel channel); // 0x000000018378D3B0-0x000000018378D410
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void EnableChannel(AudioLogChannel channel); // 0x000000018635E77C-0x000000018635E800
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void DisableChannel(AudioLogChannel channel); // 0x000000018635E6F4-0x000000018635E77C
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void SetChannels(AudioLogChannel channel); // 0x000000018635E9B4-0x000000018635EA34
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log(AudioLogChannel channel, string msg); // 0x000000018635E910-0x000000018635E9B4
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1>(AudioLogChannel channel, string msg, T1 param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning(AudioLogChannel channel, string msg); // 0x000000018635E888-0x000000018635E910
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning<T1>(AudioLogChannel channel, string msg, T1 param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogWarning<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError(AudioLogChannel channel, string msg); // 0x000000018635E800-0x000000018635E888
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError<T1>(AudioLogChannel channel, string msg, T1 param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError<T1, T2>(AudioLogChannel channel, string msg, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError<T1, T2, T3>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogError<T1, T2, T3, T4>(AudioLogChannel channel, string msg, T1 param1, T2 param2, T3 param3, T4 param4);
		private static void _DoLog(AudioLogChannel channel, string msg); // 0x000000018635EBB4-0x000000018635EC60
		private static void _DoLogWarning(AudioLogChannel channel, string msg); // 0x000000018635EB08-0x000000018635EBB4
		private static void _DoLogError(AudioLogChannel channel, string msg); // 0x000000018635EA34-0x000000018635EB08
	}

	public static class AudioAcousticUtil // TypeDefIndex: 61368
	{
		// Fields
		private const float SOUND_SPEED = 343f; // Metadata: 0x0234FA50
	
		// Methods
		public static float RT60DecayTime(float volume, float surfaceArea, float absorptionFactor); // 0x000000018635909C-0x0000000186359144
		public static float PreDelayTime(UnityEngine.Vector3 size); // 0x0000000186359024-0x000000018635909C
		public static float CriticalDistance(float volume, float rt60, float gamma = 1f /* Metadata: 0x0234FA4C */); // 0x0000000186358F38-0x0000000186358FC8
		public static float ReverbIntensity(UnityEngine.Vector3 size); // 0x0000000186359144-0x00000001863591D0
		public static float ErIntensity(UnityEngine.Vector3 size); // 0x0000000186358FC8-0x0000000186359024
	}

	internal static class AudioActionQueueHelper // TypeDefIndex: 61372
	{
		// Fields
		private static Queue<FExecuteAction> s_executeActionQueue; // 0x00
		private static Queue<FRTPCAction> s_rtpcActionQueue; // 0x08
		private static Queue<FSeekAction> s_seekActionQueue; // 0x10
		private const int QUEUE_LIFETIME_FRAME = 10; // Metadata: 0x0234FA54
	
		// Nested types
		private struct FExecuteAction // TypeDefIndex: 61369
		{
			// Fields
			public int queuedFrame; // 0x00
			public uint playingId; // 0x04
			public AkActionOnEventType actionType; // 0x08
			public int durationMs; // 0x0C
		}
	
		private struct FRTPCAction // TypeDefIndex: 61370
		{
			// Fields
			public int queuedFrame; // 0x00
			public uint playingId; // 0x04
			public uint rtpcId; // 0x08
			public float targetValue; // 0x0C
			public int durationMs; // 0x10
		}
	
		private struct FSeekAction // TypeDefIndex: 61371
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
		static AudioActionQueueHelper(); // 0x0000000184A7CB10-0x0000000184A7CCE0
	
		// Methods
		internal static void QueueExecuteAction(uint playingId, AkActionOnEventType actionType, int durationMs); // 0x0000000183870520-0x00000001838705D0
		internal static void QueueRtpcAction(uint playingId, uint rtpcId, float targetValue, int durationMs); // 0x00000001863592C0-0x00000001863593C4
		internal static void QueueSeekAction(uint playingId, uint eventId, ulong audioObjectId, int timeMs, bool toNearestMarker); // 0x00000001863593C4-0x0000000186359518
		internal static void ConsumeQueue(); // 0x000000018328BF40-0x000000018328C150
		internal static void ClearQueue(); // 0x00000001863591D0-0x00000001863592C0
		private static void _ConsumeExecute(int currFrame); // 0x000000018328C150-0x000000018328C350
		private static void _ConsumeRtpc(int currFrame); // 0x000000018328C350-0x000000018328C3F0
		private static void _ConsumeSeek(int currFrame); // 0x000000018328C3F0-0x000000018328C4E0
	}

	internal static class AudioAssetCache // TypeDefIndex: 61376
	{
		// Fields
		private static Dictionary<uint, LinkedListNode<EventCacheInfo>> s_lruUsingEvents; // 0x00
		private static Cache s_cachedEvents; // 0x08
		private static HashSet<uint> s_pinnedEvents; // 0x10
		private const int INIT_PREPARE_CAP = 128; // Metadata: 0x0234FA55
		private static ObjectPool<LinkedListNode<EventCacheInfo>> s_nodePool; // 0x18
	
		// Nested types
		internal class EventCacheInfo // TypeDefIndex: 61373
		{
			// Fields
			public uint id; // 0x10
			public uint refCount; // 0x14
	
			// Constructors
			public EventCacheInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class Cache // TypeDefIndex: 61374
		{
			// Fields
			private readonly LinkedList<EventCacheInfo> m_lruCachedEventsList; // 0x10
			private readonly Dictionary<uint, LinkedListNode<EventCacheInfo>> m_lruCachedEvents; // 0x18
	
			// Properties
			public LinkedList<EventCacheInfo> lruCachedEventsList { get; } // 0x000000018635F9A8-0x000000018635F9F8 
			public int count { get; } // 0x0000000183EB13E0-0x0000000183EB1420 
	
			// Constructors
			public Cache(); // 0x00000001849DB740-0x00000001849DB800
	
			// Methods
			public void Clear(); // 0x0000000183FE2F00-0x0000000183FE2F80
			public uint RemoveFirst(out LinkedListNode<EventCacheInfo> outNode); // 0x0000000183EB1130-0x0000000183EB11D0
			public bool Remove(uint inId, out LinkedListNode<EventCacheInfo> outNode); // 0x000000018328A260-0x000000018328A390
			public void AddLast(ref LinkedListNode<EventCacheInfo> node); // 0x000000018328A1E0-0x000000018328A260
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61375
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<LinkedListNode<EventCacheInfo>> __9__7_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D3EA70-0x0000000184D3EAD0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LinkedListNode<EventCacheInfo> _Reset_b__7_0(); // 0x000000018353D9E0-0x000000018353DA30
		}
	
		// Constructors
		static AudioAssetCache(); // 0x00000001849DB5F0-0x00000001849DB740
	
		// Methods
		internal static void Reset(); // 0x0000000183FE2CB0-0x0000000183FE2F00
		internal static void PinEvent(uint inId); // 0x00000001837A6CD0-0x00000001837A6DC0
		internal static void UnpinEvent(uint inId); // 0x000000018635CE3C-0x000000018635CEDC
		internal static void GetAllUsingAssetsAndRelease(ref List<uint> allIds); // 0x000000018635CADC-0x000000018635CE3C
		internal static uint GetLeastActiveAssetAndUncache(); // 0x0000000183EB1070-0x0000000183EB1130
		internal static int GetCachedAssetCount(); // 0x0000000183EB1360-0x0000000183EB13E0
		internal static bool ActivateAsset(uint inId); // 0x000000018328AC60-0x000000018328AFB0
		internal static void DeactivateAsset(uint inId); // 0x000000018328A390-0x000000018328A610
		internal static void ForceReleaseCachedAsset(uint inId); // 0x0000000183EB0F20-0x0000000183EB1010
		[Conditional("BEYOND_DEBUG")]
		private static void _NotifyDebugger(); // 0x000000018635CF20-0x000000018635CF60
		[Conditional("BEYOND_DEBUG")]
		private static void _NotifyDebuggerCacheHit(bool isHit); // 0x000000018635CEDC-0x000000018635CF20
		[Conditional("BEYOND_DEBUG")]
		private static void _ResetDebugger(); // 0x000000018635CFE8-0x000000018635D028
		[Conditional("BEYOND_DEBUG")]
		private static void _PinnedEventLeakDetect(); // 0x000000018635CF60-0x000000018635CFE8
	}

	internal static class AudioAssetHelper // TypeDefIndex: 61379
	{
		// Fields
		private static ulong s_memoryBudget; // 0x00
		private const float FACTOR_B_TO_MB = 9.5367E-07f; // Metadata: 0x0234FA59
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
		private static bool isGcProcessing { get; } // 0x000000018328B210-0x000000018328B290 
	
		// Nested types
		private struct FOnBankLoadedDoPrepareEventPayload // TypeDefIndex: 61377
		{
			// Fields
			public uint id; // 0x00
			public AkCallbackManager.BankCallback callback; // 0x08
			public object cookie; // 0x10
		}
	
		private struct FPendingLoadRequest // TypeDefIndex: 61378
		{
			// Fields
			public uint id; // 0x00
			public FOnBankLoadedDoPrepareEventPayload payload; // 0x08
		}
	
		// Constructors
		static AudioAssetHelper(); // 0x0000000183EAE220-0x0000000183EAE5E0
	
		// Methods
		internal static void SetMemoryBudget(ulong inBudgetBytes, ushort inGcCount = 10 /* Metadata: 0x0234FA57 */); // 0x0000000184A29290-0x0000000184A29320
		internal static bool HasPreparingEvents(); // 0x000000018635D028-0x000000018635D0B4
		internal static void UnPrepareAllEventsSync(); // 0x000000018635D268-0x000000018635D60C
		internal static void LoadEventAsync(uint inId, AkCallbackManager.BankCallback callback = null, object cookie = null); // 0x000000018635D0B4-0x000000018635D220
		private static void _TryConsumePendingLoadRequests(); // 0x0000000184815030-0x00000001848150F0
		private static void _ConsumePendingLoadRequests(); // 0x000000018328B180-0x000000018328B210
		private static void _DoLoadEventAsync(uint inId, FOnBankLoadedDoPrepareEventPayload payload); // 0x000000018328AFB0-0x000000018328B180
		internal static void PinEvent(uint inId); // 0x000000018635D220-0x000000018635D268
		internal static void UnpinEvent(uint inId); // 0x000000018635D654-0x000000018635D69C
		internal static void ResetStaticFields(); // 0x0000000183FE2BA0-0x0000000183FE2CB0
		internal static void ReleaseAllCachedEventsSync(); // 0x0000000183EB1280-0x0000000183EB1360
		private static void _TryGC(); // 0x000000018635D764-0x000000018635D7D4
		private static void _DoGc(int gcCount); // 0x0000000183EB0770-0x0000000183EB0930
		internal static void UnloadEvent(uint inId); // 0x000000018635D60C-0x000000018635D654
		private static void _OnUnpreparedDoUnloadBank(uint inId, IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, object inCookie); // 0x0000000183EB0930-0x0000000183EB09F0
		private static void _OnDoneUnloadBank(uint inId, IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, object inCookie); // 0x0000000184814FB0-0x0000000184815030
		private static void _OnBankLoadedDoPrepareEvent(uint inId, IntPtr _, AKRESULT inLoadResult, object __); // 0x0000000183EB0A70-0x0000000183EB0BD0
		private static void _OnDonePrepareEvent(uint inId, IntPtr _, AKRESULT __, object ___); // 0x0000000183EB0E80-0x0000000183EB0F20
		private static void _TryDequeueAndInvokeCallback(); // 0x000000018328CF20-0x000000018328D3E0
		[Conditional("BEYOND_DEBUG")]
		private static void _RemoveLoadingDebug(uint inId); // 0x000000018635D720-0x000000018635D764
		[Conditional("BEYOND_DEBUG")]
		private static void _AddLoadingDebug(uint inId); // 0x000000018635D69C-0x000000018635D6E0
		[Conditional("BEYOND_DEBUG")]
		private static void _ClearLoadingDebug(); // 0x000000018635D6E0-0x000000018635D720
	}

	internal static class AudioCallbackMessageParser // TypeDefIndex: 61380
	{
		// Fields
		private static readonly AkCallbackManager.MonitoringCallback s_onMonitoringCallback; // 0x00
	
		// Constructors
		static AudioCallbackMessageParser(); // 0x00000001811C5270-0x00000001811C5C00
	
		// Methods
		internal static void Set(); // 0x0000000184A35980-0x0000000184A365F0
		private static void _OnMonitoringCallback(AkMonitorErrorCode inErrorCode, AkMonitorErrorLevel inErrorLevel, uint inPlayingID, ulong inGameObjID, string inMsg); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class AudioDebugInfoContainer // TypeDefIndex: 61381
	{
		// Methods
		[Conditional("BEYOND_DEBUG")]
		public static void SetAudioObjectName(ulong audioObjId, string name); // 0x000000018635E1F0-0x000000018635E244
		[Conditional("BEYOND_DEBUG")]
		public static void RemoveAudioObjectName(ulong audioObjId); // 0x000000018635E1AC-0x000000018635E1F0
		public static string GetAudioObjectName(ulong audioObjId); // 0x000000018635E104-0x000000018635E13C
		public static string ForceGetEventName(uint eventId); // 0x000000018635E05C-0x000000018635E0B0
		public static string ForceGetRtpcName(uint rtpcId); // 0x000000018635E0B0-0x000000018635E104
		public static string GetRtpcName(uint rtpcId); // 0x000000018635E174-0x000000018635E1AC
		public static string GetEventName(uint eventId); // 0x000000018635E13C-0x000000018635E174
	}

	public static class AudioHashGenerator // TypeDefIndex: 61382
	{
		// Fields
		public const short MAX_STRING_LENGTH = 256; // Metadata: 0x0234FA5D
		private const uint PRIME32 = 16777619; // Metadata: 0x0234FA5F
		private const uint OFFSET_BASIS32 = 2166136261; // Metadata: 0x0234FA63
	
		// Methods
		[IDTag(0)]
		public static uint Compute(string inStr); // 0x000000018328DCD0-0x000000018328DD60
		[IDTag(2)]
		public static uint Compute(IntPtr inCharPtr); // 0x000000018328E280-0x000000018328E430
		[IDTag(1)]
		public static uint Compute(ReadOnlySpan<byte> buffer); // 0x000000018328DD60-0x000000018328DE10
		[IDTag(3)]
		public static uint Compute(string inStr1, string inStr2); // 0x0000000183ABCC30-0x0000000183ABCD60
		[IDTag(4)]
		public static uint Compute(params string[] strings); // 0x000000018635E2E8-0x000000018635E3D0
		private static uint _GetUintFromCharToLower(char c); // 0x000000018635E3D0-0x000000018635E3E0
	}

	public static class AudioMemoryMonitor // TypeDefIndex: 61385
	{
		// Fields
		private static AkMemCategroyStats s_categoryStats; // 0x00
		private static bool s_monitorInited; // 0x08
	
		// Nested types
		public struct FGlobalMemoryStats // TypeDefIndex: 61383
		{
			// Fields
			public ulong used; // 0x00
			public ulong reserved; // 0x08
		}
	
		public struct FExtraMemoryStats // TypeDefIndex: 61384
		{
			// Fields
			public ulong active; // 0x00
			public ulong mapped; // 0x08
			public ulong retained; // 0x10
			public ulong allocated; // 0x18
		}
	
		// Methods
		internal static void Init(); // 0x0000000184B44E60-0x0000000184B44F10
		internal static void Release(); // 0x000000018635EE64-0x000000018635EEEC
		internal static bool IsValid(); // 0x000000018635EE2C-0x000000018635EE64
		internal static ulong GetUsedMemoryUnsafe(); // 0x000000018635ED8C-0x000000018635EDCC
		internal static ulong GetUsedMemory(); // 0x000000018635EDCC-0x000000018635EE2C
		public static FGlobalMemoryStats GetGlobalMemoryStats(); // 0x0000000184819930-0x00000001848199B0
		public static FExtraMemoryStats GetExtraMemoryStats(); // 0x000000018635EC60-0x000000018635ECC4
		internal static ulong GetUsedMemoryByCategory(AkMemID memCategory); // 0x000000018635ECC4-0x000000018635ED8C
	}

	public static class AudioUIUtil // TypeDefIndex: 61387
	{
		// Fields
		private static ushort s_fullScreenCounter; // 0x00
	
		// Nested types
		[Flags]
		public enum UIAudioType // TypeDefIndex: 61386
		{
			None = 0,
			FullScreen = 1,
			Tips = 2
		}
	
		// Methods
		public static void Init(); // 0x0000000183EB4AA0-0x0000000183EB4B70
		public static void Release(); // 0x000000018635F25C-0x000000018635F304
		[IDTag(0)]
		public static uint PostUIEvent(string eventName, GameObject uiGameObject); // 0x00000001837989E0-0x0000000183798A30
		[IDTag(1)]
		public static uint PostUIEvent(string eventName, string objPath); // 0x000000018635F1D4-0x000000018635F25C
		public static void OnUIPanelClose(UIAudioType uiAudioType); // 0x00000001838D4A60-0x00000001838D4AE0
		public static void OnUIPanelOpen(UIAudioType uiAudioType); // 0x00000001838D49E0-0x00000001838D4A60
	}

	internal static class AudioVFSLoader // TypeDefIndex: 61389
	{
		// Fields
		private const string PCK_SUFFIX = ".pck"; // Metadata: 0x0234FA6B
		private static VfsLoadedInfo s_loadedInitPckInfo; // 0x00
		private static VfsLoadedInfo s_loadedMainPckInfo; // 0x10
		private static VfsLoadedInfo s_loadedAuditPckInfo; // 0x20
		private static VfsLoadedInfo s_loadedLangPckInfo; // 0x30
		private static VfsLoadedInfo s_loadedHotfixPckInfo; // 0x40
		private static EVFSBlockType s_pendingLanguageBlock; // 0x50
		private static readonly FVFBlockChunkInfo[] s_emptyChunks; // 0x58
	
		// Nested types
		private struct VfsLoadedInfo // TypeDefIndex: 61388
		{
			// Fields
			public List<uint> loadedPcks; // 0x00
			public int loadedVersion; // 0x08
			public bool isLoaded; // 0x0C
	
			// Methods
			public static VfsLoadedInfo Create(); // 0x0000000184653D10-0x0000000184653E10
		}
	
		// Constructors
		static AudioVFSLoader(); // 0x0000000184D30020-0x0000000184D300A0
	
		// Methods
		internal static void UnloadAll(); // 0x000000018635F608-0x000000018635F6E8
		internal static bool TryLoadInitPck(); // 0x0000000183EB4910-0x0000000183EB49D0
		internal static bool TryLoadMainPck(); // 0x0000000183EB5FE0-0x0000000183EB6CB0
		internal static bool TryLoadLanguagePck(string language); // 0x0000000183EB45A0-0x0000000183EB4690
		private static bool _DoLoadLanguageAndHotfixPck(EVFSBlockType langBlockType); // 0x0000000183EB4EA0-0x0000000183EB5020
		internal static void InitBasePaths(); // 0x00000001846536A0-0x0000000184653D10
		private static bool _TryLoadPcksFromVfsInfo(VFBlockMainInfo vfsInfo, ref VfsLoadedInfo info); // 0x0000000183EB5020-0x0000000183EB5100
		private static IReadOnlyList<FVFBlockChunkInfo> _SplitChunksByTag(VFBlockMainInfo block, EVFSFileTag tag, bool includeMatching); // 0x0000000183EB6CB0-0x0000000183EB6E60
		private static bool _TryLoadPcksFromChunks(IReadOnlyList<FVFBlockChunkInfo> chunks, int version, ref VfsLoadedInfo info); // 0x0000000183EB6E60-0x0000000183EB6F50
		private static bool _DoLoadPcksFromChunks(IReadOnlyList<FVFBlockChunkInfo> chunks, ref List<uint> loaded); // 0x0000000183EB54B0-0x0000000183EB5A20
		private static bool _DoLoadPcksFromVfs(VFBlockMainInfo vfs, ref List<uint> loaded); // 0x0000000183EB5100-0x0000000183EB54B0
		private static bool _DoLoadSinglePckFromVfs(FVFBlockFileInfo fileInfo, out uint loadedId); // 0x0000000183EB5A20-0x0000000183EB5BA0
		private static void _UnloadPcks(ref VfsLoadedInfo info); // 0x0000000183EB5D80-0x0000000183EB5FE0
		private static EVFSBlockType _GetVfsBlockTypeFromLanguage(string language); // 0x0000000183EB4690-0x0000000183EB4710
		public static void LoadExtraPckFromPath(string path); // 0x000000018635F304-0x000000018635F608
	}

	public class AudioVoiceUtil // TypeDefIndex: 61390
	{
		// Constructors
		public AudioVoiceUtil(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool TryGetVoiceData(string voiceStrId, out VoiceData voData, out int voiceId, string genderSuffix); // 0x0000000183ABBC00-0x0000000183ABBC90
		public static bool GetVoDataFromVoId(int voId, out VoiceData voData); // 0x0000000183AC1660-0x0000000183AC1740
		public static int GetVoiceIdFromString(string strId); // 0x0000000183ABBC90-0x0000000183ABBD20
		public static int GetVoiceIdFromStrings(string str1, string str2); // 0x0000000183ABCBD0-0x0000000183ABCC30
		[IDTag(0)]
		private static void _HandleVoiceIdConflict(ref int voiceIntId, string voiceStrId); // 0x0000000183ABBD20-0x0000000183ABBE80
		[IDTag(1)]
		private static void _HandleVoiceIdConflict(ref int voiceIntId, string voiceStrId1, string voiceStrId2); // 0x0000000183ABCD60-0x0000000183ABCE00
	}
}

namespace Beyond.Audio.AudioPerformanceMonitor
{
	public class AudioProfiling // TypeDefIndex: 61393
	{
		// Nested types
		public static class AudioWwiseProfilingData // TypeDefIndex: 61392
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
			static AudioWwiseProfilingData(); // 0x000000018635F6E8-0x000000018635F844
		}
	
		// Constructors
		public AudioProfiling(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WwiseResourceMonitor : Singleton<WwiseResourceMonitor> // TypeDefIndex: 61394
	{
		// Fields
		private const float TIME_OF_SOUND_FRAME = 0.21333334f; // Metadata: 0x0234FA70
		private const float MB_RATE = 9.536743E-07f; // Metadata: 0x0234FA74
		private bool m_isActiveAkResourceMonitoring; // 0x10
		private WwiseResourceMonitorItem m_wwiseResourceMonitorData; // 0x14
	
		// Properties
		public bool isActiveAkResourceMonitoring { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
	
		// Constructors
		private WwiseResourceMonitor(); // 0x0000000186365D38-0x0000000186365D60
	
		// Methods
		public static bool IsSupportMemoryMonitor(); // 0x0000000182FFF600-0x0000000182FFF610
		public void StartSoundEngineResourceMonitor(); // 0x0000000186365D20-0x0000000186365D2C
		public void StopSoundEngineResourceMonitor(); // 0x0000000186365D2C-0x0000000186365D38
		public WwiseResourceMonitorItem SampleRawWwiseResource(); // 0x0000000184D86180-0x0000000184D861B0
	}

	[Serializable]
	public struct WwiseResourceMonitorItem // TypeDefIndex: 61395
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
	public static class AudioEditorAssetsLoader // TypeDefIndex: 61391
	{
		// Methods
		[Conditional("UNITY_EDITOR")]
		internal static void Init(); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("UNITY_EDITOR")]
		internal static void Release(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 61321
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 61322
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 61323
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 61324
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 61325
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 61320
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61398
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37170-0x0000000184D371E0
	
		// Methods
		public ulong __Gen_Wrap_0(); // 0x000000018635FE78-0x000000018635FF24
		public uint __Gen_Wrap_1(uint P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7); // 0x0000000186361650-0x00000001863617A4
		public uint __Gen_Wrap_2(object P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7); // 0x0000000186362070-0x00000001863621C4
		public void __Gen_Wrap_3(uint P0, IntPtr P1, AKRESULT P2, object P3); // 0x0000000186362940-0x0000000186362A48
		public void __Gen_Wrap_4(object P0); // 0x00000001863633B4-0x0000000186363474
		public IEnumerator __Gen_Wrap_5(object P0, object P1, object P2); // 0x0000000186363568-0x0000000186363690
		public void __Gen_Wrap_6(in IList<uint> P0, in Action<object> P1, in object P2); // 0x00000001863637FC-0x0000000186363928
		public void __Gen_Wrap_7(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public uint __Gen_Wrap_8(AudioId P0); // 0x0000000186364DE4-0x0000000186364EE4
		public IEnumerator __Gen_Wrap_9(object P0); // 0x000000018636591C-0x00000001863659F8
		public void __Gen_Wrap_10(uint P0, uint P1, ulong P2); // 0x00000001863607B4-0x00000001863608AC
		public void __Gen_Wrap_11(object P0, object P1, ulong P2); // 0x0000000186360DA0-0x0000000186360E84
		public uint __Gen_Wrap_12(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_13(uint P0, float P1, int P2); // 0x0000000186360F54-0x000000018636104C
		public void __Gen_Wrap_14(object P0, float P1, int P2); // 0x000000018636104C-0x0000000186361144
		public void __Gen_Wrap_15(uint P0, float P1, ulong P2); // 0x0000000186361144-0x000000018636123C
		public void __Gen_Wrap_16(object P0, float P1, ulong P2); // 0x000000018636123C-0x0000000186361338
		public void __Gen_Wrap_17(uint P0, float P1, ulong P2, int P3); // 0x0000000186361338-0x0000000186361440
		public void __Gen_Wrap_18(uint P0, uint P1, float P2, int P3); // 0x0000000186361440-0x0000000186361548
		public void __Gen_Wrap_19(uint P0, float P1, uint P2, int P3); // 0x0000000186361548-0x0000000186361650
		public void __Gen_Wrap_20(uint P0, ulong P1, int P2); // 0x00000001863617A4-0x0000000186361884
		public void __Gen_Wrap_21(object P0, ulong P1, int P2); // 0x0000000186361884-0x0000000186361968
		public void __Gen_Wrap_22(uint P0, uint P1, ulong P2, int P3, bool P4); // 0x0000000186361968-0x0000000186361A7C
		public void __Gen_Wrap_23(uint P0, ulong P1, int P2, bool P3, uint P4); // 0x0000000186361A7C-0x0000000186361B90
		public void __Gen_Wrap_24(object P0, ulong P1, int P2, bool P3, uint P4); // 0x0000000186361B90-0x0000000186361CA4
		public void __Gen_Wrap_25(object P0, int P1, bool P2, uint P3); // 0x0000000186361CA4-0x0000000186361D9C
		public void __Gen_Wrap_26(uint P0, int P1, bool P2, uint P3); // 0x0000000186361D9C-0x0000000186361E90
		public bool __Gen_Wrap_27(uint P0, out int P1, bool P2); // 0x0000000186361E90-0x0000000186361FA4
		public bool __Gen_Wrap_28(uint P0); // 0x0000000186361FA4-0x0000000186362070
		public int __Gen_Wrap_29(object P0); // 0x0000000186360E84-0x0000000186360F54
		public int __Gen_Wrap_30(); // 0x00000001863621C4-0x0000000186362270
		public uint __Gen_Wrap_31(object P0, out LinkedListNode<AudioAssetCache.EventCacheInfo> P1); // 0x0000000186362270-0x00000001863623A8
		public uint __Gen_Wrap_32(); // 0x00000001863621C4-0x0000000186362270
		public bool __Gen_Wrap_33(); // 0x00000001863623A8-0x0000000186362454
		public bool __Gen_Wrap_34(object P0, uint P1, out LinkedListNode<AudioAssetCache.EventCacheInfo> P2); // 0x0000000186362454-0x00000001863625A4
		public void __Gen_Wrap_35(); // 0x00000001863625A4-0x0000000186362640
		public void __Gen_Wrap_36(uint P0, AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload P1); // 0x0000000186362640-0x0000000186362758
		public void __Gen_Wrap_37(int P0); // 0x000000018635FF24-0x000000018635FFE4
		public AkPositionArray __Gen_Wrap_38(object P0); // 0x0000000186362758-0x0000000186362848
		public void __Gen_Wrap_39(ulong P0, object P1, AudioLargeType P2); // 0x0000000186362848-0x0000000186362940
		public void __Gen_Wrap_40(ulong P0); // 0x0000000186362A48-0x0000000186362B08
		public void __Gen_Wrap_41(ulong P0, ulong P1); // 0x0000000186362B08-0x0000000186362BE4
		public bool __Gen_Wrap_42(uint P0, out uint P1); // 0x0000000186362BE4-0x0000000186362CF0
		public EVFSBlockType __Gen_Wrap_43(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_44(ref AudioVFSLoader.VfsLoadedInfo P0); // 0x0000000186362CF0-0x0000000186362E2C
		public bool __Gen_Wrap_45(FVFBlockFileInfo P0, out uint P1); // 0x0000000186362E2C-0x0000000186362F74
		public bool __Gen_Wrap_46(object P0, ref List<uint> P1); // 0x0000000186362F74-0x00000001863630AC
		public bool __Gen_Wrap_47(object P0, ref AudioVFSLoader.VfsLoadedInfo P1); // 0x00000001863630AC-0x0000000186363214
		public bool __Gen_Wrap_48(EVFSBlockType P0); // 0x0000000186363214-0x00000001863632E4
		public bool __Gen_Wrap_49(object P0); // 0x00000001863632E4-0x00000001863633B4
		public void __Gen_Wrap_50(AudioEngineInitSetting P0); // 0x0000000186363474-0x0000000186363568
		public LinkedListNode<AudioAssetCache.EventCacheInfo> __Gen_Wrap_51(); // 0x00000001811C6280-0x00000001811C6AC0
		public AudioVFSLoader.VfsLoadedInfo __Gen_Wrap_52(); // 0x00000001811C6AC0-0x00000001811C72D0
		public void __Gen_Wrap_53(ref List<uint> P0); // 0x00000001811C72D0-0x00000001811C7C80
		public void __Gen_Wrap_54(bool P0); // 0x00000001811C7C80-0x00000001811C7E70
		public void __Gen_Wrap_55(object P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8); // 0x00000001811C7E70-0x00000001811C8780
		public void __Gen_Wrap_56(object P0, AkCallbackType P1, object P2); // 0x00000001811C8780-0x00000001811C8B50
		public uint __Gen_Wrap_57(uint P0, ulong P1, AudioCallbackType P2, object P3, object P4); // 0x00000001811C8B50-0x00000001811C8F80
		public void __Gen_Wrap_58(uint P0, AkActionOnEventType P1, int P2); // 0x00000001811C8F80-0x00000001811C91D0
		public void __Gen_Wrap_59(AkActionOnEventType P0, uint P1, int P2); // 0x00000001811C8F80-0x00000001811C91D0
		public AkResourceMonitorDataSummary __Gen_Wrap_60(); // 0x00000001811C91D0-0x00000001811C9A10
		public AudioMemoryMonitor.FGlobalMemoryStats __Gen_Wrap_61(); // 0x00000001811C9A10-0x00000001811CA220
		public AudioMemoryMonitor.FExtraMemoryStats __Gen_Wrap_62(); // 0x00000001811CA220-0x00000001811CAA30
		public void __Gen_Wrap_63(ulong P0, float P1, float P2); // 0x00000001811CAA30-0x00000001811CAC60
		public bool __Gen_Wrap_64(ulong P0, object P1, object P2, object P3, object P4, bool P5, bool P6); // 0x00000001811CAC60-0x00000001811CB1F0
		public bool __Gen_Wrap_65(ulong P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, Quaternion P3, ulong P4, bool P5); // 0x00000001811CB1F0-0x00000001811CBC60
		public bool __Gen_Wrap_66(ulong P0, AudioRoomData P1, ulong P2, object P3); // 0x00000001811CBC60-0x00000001811CC360
		public bool __Gen_Wrap_67(ulong P0, ulong P1, ulong P2, UnityEngine.Vector3 P3, Quaternion P4, UnityEngine.Vector3 P5, bool P6, object P7); // 0x00000001811CC360-0x00000001811CCEC0
		public AudioAdapter.PayloadPostEvent __Gen_Wrap_68(); // 0x00000001811CCEC0-0x00000001811CD950
		public bool __Gen_Wrap_69(out AudioChannelMask P0, out uint P1, out AudioChannelConfigType P2); // 0x0000000186363690-0x00000001863637FC
		public bool __Gen_Wrap_70(object P0, uint P1, uint P2, uint P3, out ulong P4); // 0x0000000186363928-0x0000000186363A60
		public bool __Gen_Wrap_71(object P0, uint P1, out ulong P2); // 0x0000000186363A60-0x0000000186363B88
		public ulong __Gen_Wrap_72(object P0, uint P1); // 0x0000000186363B88-0x0000000186363C60
		public bool __Gen_Wrap_73(ulong P0); // 0x0000000186363C60-0x0000000186363D30
		public bool __Gen_Wrap_74(bool P0); // 0x0000000186363D30-0x0000000186363E00
		public void __Gen_Wrap_75(ulong P0, uint P1, uint P2); // 0x0000000186363E00-0x0000000186363EE4
		public uint __Gen_Wrap_76(int P0); // 0x0000000186363EE4-0x0000000186363F9C
		public AsyncLoadBankTask __Gen_Wrap_77(object P0); // 0x0000000186363F9C-0x000000018636408C
		public object __Gen_Wrap_78(object P0); // 0x000000018636408C-0x0000000186364168
		public IReadOnlyList<FVFBlockChunkInfo> __Gen_Wrap_79(object P0, EVFSFileTag P1, bool P2); // 0x0000000186364168-0x0000000186364290
		public bool __Gen_Wrap_80(object P0, int P1, ref AudioVFSLoader.VfsLoadedInfo P2); // 0x0000000186364388-0x0000000186364508
		public BankHandle __Gen_Wrap_81(object P0, object P1); // 0x0000000186364508-0x0000000186364614
		public void __Gen_Wrap_82(out List<uint> P0); // 0x0000000186364614-0x000000018636470C
		public string __Gen_Wrap_83(ref AudioId P0); // 0x000000018636470C-0x0000000186364840
		public int __Gen_Wrap_84(AudioId P0); // 0x0000000186364840-0x0000000186364940
		public AudioId __Gen_Wrap_85(uint P0); // 0x0000000186364940-0x0000000186364A2C
		public AudioId __Gen_Wrap_86(int P0); // 0x0000000186364A2C-0x0000000186364B04
		public AudioId __Gen_Wrap_87(object P0); // 0x0000000186364B04-0x0000000186364BE0
		public uint[] __Gen_Wrap_88(object P0); // 0x0000000186364BE0-0x0000000186364CBC
		public uint __Gen_Wrap_89(ref AudioState P0); // 0x0000000186364CBC-0x0000000186364DE4
		public bool __Gen_Wrap_90(ref AudioState P0, AudioState P1); // 0x0000000186364EE4-0x000000018636503C
		public bool __Gen_Wrap_91(ref AudioState P0, object P1); // 0x000000018636503C-0x0000000186365180
		public int __Gen_Wrap_92(ref AudioState P0); // 0x0000000186365180-0x00000001863652A8
		public AudioDurationCallbackInfo __Gen_Wrap_93(ref AudioCallbackInfo P0); // 0x00000001863652A8-0x0000000186365428
		public void __Gen_Wrap_94(object P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3); // 0x0000000186365428-0x00000001863655AC
		public bool __Gen_Wrap_95(AudioLogChannel P0); // 0x00000001863655AC-0x0000000186365664
		public void __Gen_Wrap_96(AudioLogChannel P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_97(AudioLogChannel P0, object P1); // 0x0000000186365664-0x000000018636572C
		public float __Gen_Wrap_98(float P0, float P1, float P2); // 0x000000018636572C-0x0000000186365824
		public float __Gen_Wrap_99(UnityEngine.Vector3 P0); // 0x0000000186365824-0x000000018636591C
		public void __Gen_Wrap_100(uint P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_101(object P0, ref LinkedListNode<AudioAssetCache.EventCacheInfo> P1); // 0x000000018635FFE4-0x000000018636010C
		public LinkedList<AudioAssetCache.EventCacheInfo> __Gen_Wrap_102(object P0); // 0x000000018636010C-0x00000001863601E8
		public void __Gen_Wrap_103(ulong P0, ushort P1); // 0x00000001863601E8-0x00000001863602C4
		public void __Gen_Wrap_104(ulong P0, object P1); // 0x00000001863602C4-0x000000018636038C
		public string __Gen_Wrap_105(uint P0); // 0x000000018636038C-0x0000000186360464
		public uint __Gen_Wrap_106(ReadOnlySpan<byte> P0); // 0x0000000186360464-0x0000000186360554
		public uint __Gen_Wrap_107(IntPtr P0); // 0x0000000186360554-0x0000000186360610
		public uint __Gen_Wrap_108(object P0, object P1); // 0x0000000186360610-0x00000001863606FC
		public ulong __Gen_Wrap_109(AkMemID P0); // 0x00000001863606FC-0x00000001863607B4
		public void __Gen_Wrap_110(AudioUIUtil.UIAudioType P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_111(ref int P0, object P1); // 0x00000001863608AC-0x00000001863609AC
		public bool __Gen_Wrap_112(int P0, out VoiceData P1); // 0x00000001863609AC-0x0000000186360AF4
		public void __Gen_Wrap_113(ref int P0, object P1, object P2); // 0x0000000186360AF4-0x0000000186360C0C
		public int __Gen_Wrap_114(object P0, object P1); // 0x0000000186360610-0x00000001863606FC
		public bool __Gen_Wrap_115(object P0, out VoiceData P1, out int P2, object P3); // 0x0000000186360C0C-0x0000000186360DA0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 61399
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x0000000186365DEC-0x0000000186365E98 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x0000000186365F14-0x0000000186365FC0 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018636603C-0x0000000186366118
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x0000000186365FC0-0x000000018636603C
		[IDTag(1)]
		private bool MoveNext(); // 0x0000000186365D60-0x0000000186365DEC
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x0000000186365E98-0x0000000186365F14
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61400
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000186366300-0x0000000186366364
		public static bool IsPatched(int id); // 0x000000018328C4E0-0x000000018328C530
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x00000001863661BC-0x0000000186366288
		public object CreateWrapper(int id); // 0x0000000186366288-0x0000000186366300
		public object InitWrapperArray(int len); // 0x0000000186366364-0x00000001863663F0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000186366118-0x00000001863661BC
	}

	public enum IDMAP0 // TypeDefIndex: 61401
	{
		Beyond-Audio-AudioAdapter-get_listenerObjId0 = 0,
		Beyond-Audio-AudioAdapter-PostEventExternal0 = 1,
		Beyond-Audio-AudioAdapter-_PostEventWithExternalSource0 = 2,
		Beyond-Audio-AudioAdapter-PostEventExternal1 = 3,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsSync0 = 4,
		Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsSync0 = 5,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsSync1 = 8,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync0 = 9,
		Beyond-Audio-AudioAdapter-_LoadAndPinEventsAsync0 = 10,
		Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsAsync0 = 11,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync1 = 20,
		Beyond-Audio-AudioId-op_Implicit0 = 21,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync2 = 22,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine0 = 23,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine1 = 24,
		Beyond-Audio-AudioAdapter-SetSwitch0 = 31,
		Beyond-Audio-AudioAdapter-SetSwitch1 = 32,
		Beyond-Audio-AudioAdapter-SetRtpc1 = 33,
		Beyond-Audio-AudioHashGenerator-Compute0 = 34,
		Beyond-Audio-AudioAdapter-SetRtpc0 = 35,
		Beyond-Audio-AudioAdapter-SetRtpc3 = 36,
		Beyond-Audio-AudioAdapter-SetRtpc2 = 37,
		Beyond-Audio-AudioAdapter-SetRtpc4 = 38,
		Beyond-Audio-AudioAdapter-SetRtpcValueByPlayingID0 = 39,
		Beyond-Audio-AudioActionQueueHelper-QueueRtpcAction0 = 40,
		Beyond-Audio-AudioAdapter-ResetRtpc0 = 41,
		Beyond-Audio-AudioAdapter-ResetRtpc1 = 42,
		Beyond-Audio-AudioAdapter-SeekOnEvent1 = 43,
		Beyond-Audio-AudioAdapter-SeekOnEvent0 = 44,
		Beyond-Audio-AudioActionQueueHelper-QueueSeekAction0 = 45,
		Beyond-Audio-AudioAdapter-SeekOnEvent2 = 46,
		Beyond-Audio-AudioAdapter-SeekOnEvent3 = 47,
		Beyond-Audio-AudioAdapter-TryGetPlayingPosition0 = 48,
		Beyond-Audio-AudioAdapter-TryGetMusicPlayingPosition0 = 49,
		Beyond-Audio-AudioAdapter-IsPlaying0 = 50,
		Beyond-Audio-AudioAdapter-ReleaseAllCachedEventsSync0 = 51,
		Beyond-Audio-AudioAssetHelper-ReleaseAllCachedEventsSync0 = 52,
		Beyond-Audio-AudioAssetCache-GetCachedAssetCount0 = 53,
		Beyond-Audio-AudioAssetCache-Cache-get_count0 = 54,
		Beyond-Audio-AudioAssetHelper-_DoGc0 = 55,
		Beyond-Audio-AudioAssetCache-GetLeastActiveAssetAndUncache0 = 56,
		Beyond-Audio-AudioAssetCache-Cache-RemoveFirst0 = 57,
		Beyond-Audio-AudioAssetHelper-_TryConsumePendingLoadRequests0 = 58,
		Beyond-Audio-AudioAssetHelper-get_isGcProcessing0 = 59,
		Beyond-Audio-AudioAssetHelper-_ConsumePendingLoadRequests0 = 60,
		Beyond-Audio-AudioAssetHelper-_DoLoadEventAsync0 = 61,
		Beyond-Audio-AudioAssetCache-ActivateAsset0 = 62,
		Beyond-Audio-AudioAssetCache-Cache-Remove0 = 63,
		Beyond-Audio-AudioAssetHelper-_TryDequeueAndInvokeCallback0 = 64,
		Beyond-Audio-AudioAdapter-SetLargePositions0 = 65,
		Beyond-Audio-AudioPositionArrayProxy-GetRawArray0 = 66,
		Beyond-Audio-AudioPositionArrayProxy-get_count0 = 67,
		Beyond-Audio-AudioAdapter-SetDefaultListener0 = 68,
		Beyond-Audio-AudioAdapter-SetListener0 = 69,
		Beyond-Audio-AudioAdapter-TryGetRealPlayingId0 = 70,
		Beyond-Audio-AudioAdapter-SetDefaultEmitter0 = 71,
		Beyond-Audio-AudioAdapter-SetAudioLanguage0 = 72,
		Beyond-Audio-AudioVFSLoader-TryLoadLanguagePck0 = 73,
		Beyond-Audio-AudioVFSLoader-_GetVfsBlockTypeFromLanguage0 = 74,
		Beyond-Audio-AudioVFSLoader-_DoLoadLanguageAndHotfixPck0 = 75,
		Beyond-Audio-AudioVFSLoader-_UnloadPcks0 = 76,
		Beyond-Audio-AudioVFSLoader-_TryLoadPcksFromVfsInfo0 = 77,
		Beyond-Audio-AudioVFSLoader-_DoLoadPcksFromVfs0 = 78,
		Beyond-Audio-AudioVFSLoader-_DoLoadSinglePckFromVfs0 = 79,
		Beyond-Audio-AudioAdapter-SetDistanceProbe0 = 80,
		Beyond-Audio-AudioAdapter-SetAudioEngineInitSetting0 = 81,
		Beyond-Audio-AudioAdapter-UnsetAudioEngineInitSetting0 = 82,
		Beyond-Audio-AudioAdapter-InitWwise0 = 83,
		Beyond-Audio-AudioAdapter-_InitInternal0 = 84,
		Beyond-Audio-AudioAdapter-_ResetStaticFields0 = 85,
		Beyond-Audio-AudioAdapter-Context-Reset0 = 86,
		Beyond-Audio-AudioAssetHelper-ResetStaticFields0 = 87,
		Beyond-Audio-AudioAssetCache-Reset0 = 88,
		Beyond-Audio-AudioAssetCache-Cache-Clear0 = 89,
		Beyond-Audio-AudioAdapter-_InitAndroidActivityEnvironment0 = 93,
		Beyond-Audio-AudioCallbackMessageParser-Set0 = 94,
		Beyond-Audio-AudioMemoryMonitor-Init0 = 95,
		Beyond-Audio-AudioAdapter-Context-PostSoundEngineInit0 = 96,
		Beyond-Audio-AudioVFSLoader-InitBasePaths0 = 97,
		Beyond-Audio-AudioVFSLoader-VfsLoadedInfo-Create0 = 98,
		Beyond-Audio-AudioAdapter-LoadInitResources0 = 99,
		Beyond-Audio-AudioVFSLoader-TryLoadInitPck0 = 100,
		Beyond-Audio-AudioAdapter-TermWwise0 = 101,
		Beyond-Audio-AudioAdapter-_ReleaseInternal0 = 102,
		Beyond-Audio-AudioActionQueueHelper-ClearQueue0 = 103,
		Beyond-Audio-AudioAdapter-_OnBeforeTerminate0 = 104,
		Beyond-Audio-AudioAssetHelper-HasPreparingEvents0 = 105,
		Beyond-Audio-AudioAssetHelper-UnPrepareAllEventsSync0 = 106,
		Beyond-Audio-AudioAssetCache-GetAllUsingAssetsAndRelease0 = 107,
		Beyond-Audio-AudioMemoryMonitor-Release0 = 108,
		Beyond-Audio-AudioAdapter-ReloadInitResources0 = 109,
		Beyond-Audio-AudioBankManager-Reset0 = 110,
		Beyond-Audio-AudioVFSLoader-UnloadAll0 = 111,
		Beyond-Audio-AudioAdapter-MemoryShrink0 = 112,
		Beyond-Audio-AudioAdapter-TouchAudioHotfixPlaceholder0 = 113,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder10 = 114,
		Beyond-Audio-AudioAdapter-TouchAudioHotfixPlaceholderArgs0 = 115,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder20 = 116,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder30 = 117,
		Beyond-Audio-AudioAdapter-LoadExtraPckFromPath0 = 118,
		Beyond-Audio-AudioVFSLoader-LoadExtraPckFromPath0 = 119,
		Beyond-Audio-AudioAdapter-_OnEventPreparedDoPostEvent0 = 120,
		Beyond-Audio-AudioAdapter-_OnEventCallback0 = 121,
		Beyond-Audio-AudioAdapter-_OnExternalSourceEventCallback0 = 122,
		Beyond-Audio-AudioAdapter-_PostEvent0 = 123,
		Beyond-Audio-AudioAdapter-_ExecuteActionOnPlayingId0 = 124,
		Beyond-Audio-AudioActionQueueHelper-QueueExecuteAction0 = 125,
		Beyond-Audio-AudioAdapter-_SampleAllData0 = 126,
		Beyond-Audio-AudioAdapter-_SampleMemoryOnly0 = 127,
		Beyond-Audio-AudioAdapter-StartProfileCapture0 = 128,
		Beyond-Audio-AudioAdapter-StopProfileCapture0 = 129,
		Beyond-Audio-AudioAdapter-GetResourceSummaryData0 = 130,
		Beyond-Audio-AudioAdapter-GetGlobalMemoryStats0 = 131,
		Beyond-Audio-AudioAdapter-GetExtraMemoryStats0 = 132,
		Beyond-Audio-AudioAdapter-SetEnableSpatialAudio0 = 133,
		Beyond-Audio-AudioAdapter-SetObjectObstructionAndOcclusion0 = 134,
		Beyond-Audio-AudioAdapter-SetGeometry0 = 135,
		Beyond-Audio-AudioAdapter-SetGeometryInstance0 = 136,
		Beyond-Audio-AudioAdapter-SetRoom0 = 137,
		Beyond-Audio-AudioAdapter-SetPortal0 = 138,
		Beyond-Audio-AudioAdapter-Context-_CreatePayloadPostEvent0 = 139,
		Beyond-Audio-AudioAdapter-PayloadPostEvent-OnRecycle0 = 140,
		Beyond-Audio-AudioAdapter-Device-GetSpeakerConfiguration0 = 141,
		Beyond-Audio-AudioAdapter-Device-AddOutputDevice0 = 142,
		Beyond-Audio-AudioAdapter-Device-AddOutput0 = 143,
		Beyond-Audio-AudioAdapter-Device-GetOutputDeviceId0 = 144,
		Beyond-Audio-AudioAdapter-Device-RemoveOutputDevice0 = 145,
		Beyond-Audio-AudioAdapter-Device-Switch3DOutput0 = 146,
		Beyond-Audio-AudioAdapter-Device-SetOutputDeviceEffect0 = 147,
		Beyond-Audio-AudioAdapter-Device-GetMmDeviceIdFromScePadHandle0 = 148,
		Beyond-Audio-BankHandle-get_refCount0 = 149,
		Beyond-Audio-BankHandle-Dispose0 = 150,
		Beyond-Audio-AudioBankManager-UnloadBank0 = 152,
		Beyond-Audio-BankHandle-DecRef0 = 153,
		Beyond-Audio-BankHandle-IncRef0 = 155,
		Beyond-Audio-AsyncLoadBankTask-LoadBanksAsync0 = 156,
		Beyond-Audio-AsyncLoadBankTask-MoveNext0 = 157,
		Beyond-Audio-AsyncLoadBankTask-Reset0 = 158,
		Beyond-Audio-AsyncLoadBankTask-Dispose0 = 159,
		Beyond-Audio-AsyncLoadBankTask-get_Current0 = 160,
		Beyond-Audio-AudioBankManager-LoadMainPCK0 = 161,
		Beyond-Audio-AudioVFSLoader-TryLoadMainPck0 = 162,
		Beyond-Audio-AudioVFSLoader-_SplitChunksByTag0 = 163,
		Beyond-Audio-AudioVFSLoader-_TryLoadPcksFromChunks0 = 164,
		Beyond-Audio-AudioVFSLoader-_DoLoadPcksFromChunks0 = 165,
		Beyond-Audio-AudioBankManager-LoadBankAsync0 = 166,
		Beyond-Audio-AudioBankManager-_LoadBankCallback0 = 167,
		Beyond-Audio-AudioBankManager-UnloadAllBanks0 = 170,
		Beyond-Audio-AudioBankManager-IsBankLoaded0 = 171,
		Beyond-Audio-AudioBankManager-LoadDebugFilePackage0 = 172,
		Beyond-Audio-AudioBankManager-_PreResetBasePath0 = 173,
		Beyond-Audio-AudioBankManager-_PostResetBasePath0 = 174,
		Beyond-Audio-AudioBankManager-AddDebugBankPath0 = 175,
		Beyond-Audio-AudioId-GetName0 = 176,
		Beyond-Audio-AudioId-op_Implicit1 = 177,
		Beyond-Audio-AudioId-op_Implicit2 = 178,
		Beyond-Audio-AudioId-op_Implicit3 = 179,
		Beyond-Audio-AudioId-op_Implicit4 = 180,
		Beyond-Audio-AudioIdExtensions-ToUIntArray0 = 181,
		Beyond-Audio-AudioState-get_stateGroup0 = 182,
		Beyond-Audio-AudioState-get_stateValue0 = 183,
		Beyond-Audio-AudioState-Equals0 = 184,
		Beyond-Audio-AudioState-Equals1 = 185,
		Beyond-Audio-AudioState-GetHashCode0 = 186,
		Beyond-Audio-AudioCallbackInfo-CastToDurationCallbackInfo0 = 187,
		Beyond-Audio-AudioPositionArrayProxy-Add0 = 188,
		Beyond-Audio-AudioPositionArrayProxy-Reset0 = 189,
		Beyond-Audio-AudioLogger-IsChannelEnabled0 = 190,
		Beyond-Audio-AudioLogger-EnableChannel0 = 191,
		Beyond-Audio-AudioLogger-DisableChannel0 = 192,
		Beyond-Audio-AudioLogger-SetChannels0 = 193,
		Beyond-Audio-AudioLogger-Log0 = 194,
		Beyond-Audio-AudioLogger-_DoLog0 = 195,
		Beyond-Audio-AudioLogger-LogWarning0 = 196,
		Beyond-Audio-AudioLogger-_DoLogWarning0 = 197,
		Beyond-Audio-AudioLogger-LogError0 = 198,
		Beyond-Audio-AudioLogger-_DoLogError0 = 199,
		Beyond-Audio-AudioAcousticUtil-RT60DecayTime0 = 200,
		Beyond-Audio-AudioAcousticUtil-PreDelayTime0 = 201,
		Beyond-Audio-AudioAcousticUtil-CriticalDistance0 = 202,
		Beyond-Audio-AudioAcousticUtil-ReverbIntensity0 = 203,
		Beyond-Audio-AudioAcousticUtil-ErIntensity0 = 204,
		Beyond-Audio-AudioActionQueueHelper-ConsumeQueue0 = 205,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeExecute0 = 206,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeRtpc0 = 207,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeSeek0 = 208,
		Beyond-Audio-AudioAssetCache-PinEvent0 = 209,
		Beyond-Audio-AudioAssetCache-UnpinEvent0 = 210,
		Beyond-Audio-AudioAssetCache-DeactivateAsset0 = 211,
		Beyond-Audio-AudioAssetCache-Cache-AddLast0 = 212,
		Beyond-Audio-AudioAssetCache-ForceReleaseCachedAsset0 = 213,
		Beyond-Audio-AudioAssetCache-_NotifyDebugger0 = 214,
		Beyond-Audio-AudioAssetCache-_NotifyDebuggerCacheHit0 = 215,
		Beyond-Audio-AudioAssetCache-_ResetDebugger0 = 216,
		Beyond-Audio-AudioAssetCache-_PinnedEventLeakDetect0 = 217,
		Beyond-Audio-AudioAssetCache-Cache-get_lruCachedEventsList0 = 218,
		Beyond-Audio-AudioAssetHelper-SetMemoryBudget0 = 219,
		Beyond-Audio-AudioAssetHelper-_OnUnpreparedDoUnloadBank0 = 220,
		Beyond-Audio-AudioAssetHelper-_OnDoneUnloadBank0 = 221,
		Beyond-Audio-AudioAssetHelper-_OnBankLoadedDoPrepareEvent0 = 222,
		Beyond-Audio-AudioAssetHelper-_OnDonePrepareEvent0 = 223,
		Beyond-Audio-AudioAssetHelper-_RemoveLoadingDebug0 = 224,
		Beyond-Audio-AudioAssetHelper-_AddLoadingDebug0 = 225,
		Beyond-Audio-AudioAssetHelper-_ClearLoadingDebug0 = 226,
		Beyond-Audio-AudioDebugInfoContainer-SetAudioObjectName0 = 227,
		Beyond-Audio-AudioDebugInfoContainer-RemoveAudioObjectName0 = 228,
		Beyond-Audio-AudioDebugInfoContainer-ForceGetEventName0 = 229,
		Beyond-Audio-AudioDebugInfoContainer-ForceGetRtpcName0 = 230,
		Beyond-Audio-AudioHashGenerator-Compute2 = 231,
		Beyond-Audio-AudioHashGenerator-Compute1 = 232,
		Beyond-Audio-AudioHashGenerator-Compute3 = 233,
		Beyond-Audio-AudioHashGenerator-Compute4 = 234,
		Beyond-Audio-AudioMemoryMonitor-GetGlobalMemoryStats0 = 235,
		Beyond-Audio-AudioMemoryMonitor-GetExtraMemoryStats0 = 236,
		Beyond-Audio-AudioMemoryMonitor-GetUsedMemoryByCategory0 = 237,
		Beyond-Audio-AudioUIUtil-Init0 = 238,
		Beyond-Audio-AudioUIUtil-Release0 = 239,
		Beyond-Audio-AudioUIUtil-PostUIEvent0 = 240,
		Beyond-Audio-AudioUIUtil-PostUIEvent1 = 241,
		Beyond-Audio-AudioUIUtil-OnUIPanelClose0 = 242,
		Beyond-Audio-AudioUIUtil-OnUIPanelOpen0 = 243,
		Beyond-Audio-AudioVoiceUtil-TryGetVoiceData0 = 244,
		Beyond-Audio-AudioVoiceUtil-GetVoiceIdFromString0 = 245,
		Beyond-Audio-AudioVoiceUtil-_HandleVoiceIdConflict0 = 246,
		Beyond-Audio-AudioVoiceUtil-GetVoDataFromVoId0 = 247,
		Beyond-Audio-AudioVoiceUtil-GetVoiceIdFromStrings0 = 248,
		Beyond-Audio-AudioVoiceUtil-_HandleVoiceIdConflict1 = 249
	}
}
