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
using IFix;
using IFix.Core;
using Newtonsoft.Json;
using Unity.Profiling;
using UnityEngine;

// Image 45: Audio.Beyond.dll - Assembly: Audio.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 86793-87140

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 86936
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _662FC6EB33F1099AA2416EFBD9D5716B0AC7D68036E4C225784C78C03695D2AC; // 0x00 // Static value (base64): S7HlCQ17hMDxZ40p - Metadata: 0x02646108

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 86935
	{
	}
}

namespace Beyond.Audio
{
	public static class AudioAdapter // TypeDefIndex: 86809
	{
		// Fields
		private static readonly AkCallbackManager.BankCallback ON_EVENT_PREPARED_DO_POST_EVENT; // 0x00
		private static readonly AkCallbackManager.EventCallback ON_EVENT_CALLBACK; // 0x08
		private static readonly AkCallbackManager.EventCallback ON_EXTERNAL_SOURCE_EVENT_CALLBACK; // 0x10
	
		// Properties
		public static ulong listenerObjId { get; } // 0x00000001887E8540-0x00000001887E85BC 
	
		// Nested types
		private static class Context // TypeDefIndex: 86802
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
			static Context(); // 0x00000001865E7F10-0x00000001865E8FF0
	
			// Methods
			public static void PostSoundEngineInit(); // 0x00000001862FAAB0-0x00000001862FAB70
			public static void Reset(); // 0x00000001862FB5E0-0x00000001862FB760
			private static PayloadPostEvent _CreatePayloadPostEvent(); // 0x00000001855B24B0-0x00000001855B2510
		}
	
		private class PayloadPostEvent // TypeDefIndex: 86803
		{
			// Fields
			public ulong audioObjectId; // 0x10
			public uint callbackType; // 0x18
			public uint internalPlayingId; // 0x1C
			public AudioEventCallback callback; // 0x20
			public object cookie; // 0x28
	
			// Constructors
			public PayloadPostEvent(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public static void OnRecycle(PayloadPostEvent obj); // 0x0000000186187100-0x0000000186187150
		}
	
		public static class Device // TypeDefIndex: 86804
		{
			// Methods
			public static bool GetSpeakerConfiguration(out AudioChannelMask channelMask, out uint numChannels, out AudioChannelConfigType configType); // 0x00000001862FA2E0-0x00000001862FA3E0
			public static bool AddOutputDevice(string deviceName, uint deviceId, uint numChannels, uint speakerSetup, out ulong outDeviceId); // 0x00000001887EB310-0x00000001887EB474
			public static bool AddOutput(string shareSetName, uint deviceId, out ulong outId); // 0x00000001887EB474-0x00000001887EB554
			public static ulong GetOutputDeviceId(string shareSetName, uint deviceId); // 0x00000001887EB5D0-0x00000001887EB660
			public static bool RemoveOutputDevice(ulong output); // 0x00000001887EB660-0x00000001887EB700
			public static bool Switch3DOutput(bool use3DDevice); // 0x00000001862E6A00-0x00000001862E6BA0
			public static void SetOutputDeviceEffect(ulong outputDeviceId, uint effectIdx, uint shareSetId); // 0x00000001887EB700-0x00000001887EB7A4
			public static uint GetMmDeviceIdFromScePadHandle(int scePadHandle); // 0x00000001887EB554-0x00000001887EB5D0
		}
	
		[CompilerGenerated]
		private sealed class _LoadAndPinEventsCoroutine_d__26 : IEnumerator<object> // TypeDefIndex: 86805
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ICollection<string> events; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _LoadAndPinEventsCoroutine_d__26(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001887EFBFC-0x00000001887EFE88
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001887EFE88-0x00000001887EFED4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass101_0 // TypeDefIndex: 86806
		{
			// Fields
			public int doneCount; // 0x10
			public AkCallbackManager.BankCallback __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass101_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DoLoadAndPinEventsSync_b__0(uint _, IntPtr _, AKRESULT _, object _); // 0x0000000182233630-0x0000000182233640
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass102_0 // TypeDefIndex: 86807
		{
			// Fields
			public int doneCount; // 0x10
			public AkCallbackManager.BankCallback __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass102_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DoLoadAndPinEventsAsync_b__0(uint _, IntPtr _, AKRESULT _, object _); // 0x0000000182233630-0x0000000182233640
		}
	
		[CompilerGenerated]
		private sealed class __DoLoadAndPinEventsAsync_d__102 : IEnumerator<object> // TypeDefIndex: 86808
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public IList<uint> events; // 0x20
			public Action<object> onDone; // 0x28
			public object payload; // 0x30
			private __c__DisplayClass102_0 __8__1; // 0x38
			private int _allCount_5__2; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DoLoadAndPinEventsAsync_d__102(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182233640-0x0000000182234E30
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182234E40-0x0000000182234E90
		}
	
		// Constructors
		static AudioAdapter(); // 0x0000000186B04E00-0x0000000186B04F60
	
		// Methods
		public static uint PostEvent(string eventName); // 0x0000000186797590-0x0000000186797610
		public static uint PostEvent(uint eventId); // 0x00000001887E5F54-0x00000001887E5FE0
		public static uint PostEvent(string eventName, ulong audioObjectId); // 0x00000001887E6118-0x00000001887E6188
		public static uint PostEvent(uint eventId, ulong audioObjectId); // 0x00000001887E6188-0x00000001887E61EC
		public static uint PostEvent(string eventName, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null); // 0x00000001887E61EC-0x00000001887E6298
		public static uint PostEvent(uint eventId, [IsReadOnly] in AudioCallbackType callbackType, [IsReadOnly] in AudioEventCallback callback, object cookie = null); // 0x00000001887E6060-0x00000001887E6118
		public static uint PostEvent(string eventName, ulong audioObjectId, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null); // 0x00000001887E5FE0-0x00000001887E6060
		public static uint PostEvent(uint eventId, ulong audioObjectId, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null); // 0x00000001887E5EE0-0x00000001887E5F54
		[IDTag(0)]
		public static uint PostEventExternal(string eventName, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x02645C69 */); // 0x00000001863A7E60-0x00000001863A7F60
		[IDTag(1)]
		public static uint PostEventExternal(uint eventId, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x02645C6A */); // 0x00000001887E5D98-0x00000001887E5EE0
		public static void StopByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x02645C6B */); // 0x00000001887E768C-0x00000001887E76DC
		public static void PauseByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x02645C6D */); // 0x00000001887E5CFC-0x00000001887E5D50
		public static void ResumeByPlayingId(uint playingId, int fadeTimeMs = 100 /* Metadata: 0x02645C6F */); // 0x00000001887E67C0-0x00000001887E6814
		public static void PinEvent(uint eventId); // 0x00000001887E5D50-0x00000001887E5D98
		public static void UnpinEvent(uint eventId); // 0x00000001887E7C2C-0x00000001887E7C78
		public static void UnpinEvent(string eventName); // 0x0000000186E35CD0-0x0000000186E35DC0
		[IDTag(0)]
		public static void LoadAndPinEventsSync(IList<uint> events); // 0x00000001887E5B54-0x00000001887E5BD4
		[IDTag(1)]
		public static void LoadAndPinEventsSync(ICollection<string> events); // 0x00000001887E5930-0x00000001887E5B54
		[IDTag(0)]
		public static void LoadAndPinEventsAsync(IList<uint> events, Action<object> onDone = null, object payload = null); // 0x000000018668FC00-0x0000000186690520
		[IDTag(1)]
		public static void LoadAndPinEventsAsync(IList<AudioId> events, Action<object> onDone = null, object payload = null); // 0x00000001864E36D0-0x00000001864E3810
		[IDTag(2)]
		public static void LoadAndPinEventsAsync(ICollection<string> events, Action<object> onDone = null, object payload = null); // 0x00000001887E55C4-0x00000001887E5814
		[IDTag(0)]
		public static IEnumerator LoadAndPinEventsCoroutine(IList<uint> events); // 0x00000001887E58AC-0x00000001887E5930
		[IDTag(1)]
		[IteratorStateMachine(typeof(_LoadAndPinEventsCoroutine_d__26))]
		public static IEnumerator LoadAndPinEventsCoroutine(ICollection<string> events); // 0x00000001887E5814-0x00000001887E58AC
		public static void SetState(string stateGroup, string stateName); // 0x00000001887E7400-0x00000001887E745C
		public static void SetState(uint stateGroup, uint stateName); // 0x00000001887E73A8-0x00000001887E7400
		public static bool TryGetState(uint stateGroupId, out uint stateId); // 0x00000001887E7BD4-0x00000001887E7C2C
		[IDTag(0)]
		public static void SetSwitch(uint switchGroup, uint switchValue, ulong audioObjectId); // 0x00000001887E745C-0x00000001887E7508
		[IDTag(1)]
		public static void SetSwitch(string switchGroup, string switchValue, ulong audioObjectId); // 0x00000001887E7508-0x00000001887E75C4
		[IDTag(1)]
		public static void SetRtpc(string rtpcName, float rtpcValue, int fadeTimeMs = 0 /* Metadata: 0x02645C71 */); // 0x0000000186AD49E0-0x0000000186AD4A80
		[IDTag(0)]
		public static void SetRtpc(uint rtpcId, float rtpcValue, int fadeTimeMs = 0 /* Metadata: 0x02645C72 */); // 0x0000000186AD4A80-0x0000000186AD4B20
		[IDTag(3)]
		public static void SetRtpc(string rtpcName, float rtpcValue, ulong audioObjectId); // 0x00000001861E9500-0x00000001861E95A0
		[IDTag(2)]
		public static void SetRtpc(uint rtpcId, float rtpcValue, ulong audioObjectId); // 0x00000001857789C0-0x0000000185778A60
		[IDTag(4)]
		public static void SetRtpc(uint rtpcId, float rtpcValue, ulong audioObjectId, int fadeTimeMs); // 0x0000000185E823D0-0x0000000185E82470
		public static void SetRtpcValueByPlayingID(uint rtpcId, float rtpcValue, uint playingId, int fadeTimeMs); // 0x00000001862BE100-0x00000001862BE240
		[IDTag(0)]
		public static void ResetRtpc(uint rtpcId, ulong audioObjectId, int fadeTimeMs); // 0x00000001887E6668-0x00000001887E670C
		[IDTag(1)]
		public static void ResetRtpc(string rtpcName, ulong audioObjectId, int fadeTimeMs = 100 /* Metadata: 0x02645C73 */); // 0x00000001887E670C-0x00000001887E67C0
		public static bool GetRtpcValue(string rtpcName, ulong audioObjectId, uint playingId, out float value, ref int valueType); // 0x00000001887E53A4-0x00000001887E5494
		public static bool GetRtpcValue(uint rtpcId, ulong audioObjectId, uint playingId, out float value, ref int valueType); // 0x00000001887E5494-0x00000001887E5584
		[IDTag(1)]
		public static void SeekOnEvent(string eventName, ulong audioObjectId, int timeMs, bool toNearestMarker, uint playingId); // 0x00000001887E6B6C-0x00000001887E6C44
		[IDTag(0)]
		public static void SeekOnEvent(uint eventId, ulong audioObjectId, int timeMs, bool toNearestMarker, uint playingId); // 0x00000001887E6908-0x00000001887E6A78
		[IDTag(2)]
		public static void SeekOnEvent(string eventName, int timeMs, bool toNearestMarker, uint playingId); // 0x00000001887E6814-0x00000001887E6908
		[IDTag(3)]
		public static void SeekOnEvent(uint eventId, int timeMs, bool toNearestMarker, uint playingId); // 0x00000001887E6A78-0x00000001887E6B6C
		public static bool TryGetPlayingPosition(uint playingId, out int posTimeMs, bool extrapolate = true /* Metadata: 0x02645C75 */); // 0x00000001887E7ABC-0x00000001887E7BD4
		public static bool TryGetMusicPlayingPosition(uint playingId, out int posTimeMs, bool extrapolate = true /* Metadata: 0x02645C76 */); // 0x00000001887E7968-0x00000001887E7ABC
		public static bool IsPlaying(uint playingId); // 0x000000018679B540-0x000000018679B640
		public static uint SetScalingFactor(ulong audioObjectId, float factor); // 0x00000001887E734C-0x00000001887E73A8
		public static bool RegisterGameObject(ulong audioObjectId); // 0x00000001887E62F0-0x00000001887E6338
		public static bool RegisterGameObject(ulong audioObjectId, string name); // 0x00000001887E6298-0x00000001887E62F0
		public static bool UnregisterGameObject(ulong audioObjectId); // 0x00000001887E7C78-0x00000001887E7CC0
		public static void SetPosition(ulong audioObjectId, UnityEngine.Vector3 pos, UnityEngine.Vector3 forward, UnityEngine.Vector3 up); // 0x00000001887E7228-0x00000001887E72DC
		public static void StopAll(); // 0x00000001887E764C-0x00000001887E768C
		public static void StopAllOnObject(ulong audioObjectId); // 0x00000001887E7600-0x00000001887E764C
		public static void ReleaseAllCachedEventsSync(); // 0x00000001864E4070-0x00000001864E40E0
		public static void SetLargePositions(ulong audioObjectId, AudioPositionArrayProxy positions, AudioLargeType type = AudioLargeType.Sum /* Metadata: 0x02645C77 */); // 0x0000000185A1ACB0-0x0000000185A1AD80
		public static void SetDefaultListener(ulong audioObjectId); // 0x000000018611CD80-0x000000018611CE90
		public static void SetListener(ulong audioObjectId, ulong listenerId); // 0x00000001887E6DD4-0x00000001887E6EA4
		public static bool TryGetRealPlayingId(uint playingId, out uint realPlayingId); // 0x000000018577F6D0-0x000000018577F750
		public static void SetDefaultEmitter(ulong audioObjectId); // 0x00000001887E6CA0-0x00000001887E6D28
		public static bool AddBasePath(string path); // 0x00000001821E7B40-0x00000001821E81C0
		public static void SetAudioLanguage(string language); // 0x000000018668F7B0-0x000000018668F850
		public static void SetDistanceProbe(ulong probeObjectId = 18446744073709551615 /* Metadata: 0x02645C78 */); // 0x00000001887E6D28-0x00000001887E6DD4
		public static uint ComputeIdFromString(string name); // 0x00000001887E529C-0x00000001887E52BC
		public static void SetAudioEngineInitSetting(AudioEngineInitSetting settings); // 0x000000018668F370-0x000000018668F3E0
		public static void UnsetAudioEngineInitSetting(); // 0x00000001887E7CC0-0x00000001887E7D30
		public static bool InitWwise(); // 0x000000018668F300-0x000000018668F370
		public static void TermWwise(bool hgDeepTerm = false /* Metadata: 0x02645C80 */); // 0x00000001887E775C-0x00000001887E77D8
		public static void LoadInitResources(); // 0x000000018668F510-0x000000018668F5A0
		public static void ReloadInitResources(); // 0x00000001887E6338-0x00000001887E6460
		public static void RenderAudio(); // 0x00000001887E65F0-0x00000001887E6668
		public static void Suspend(bool renderAnyway); // 0x00000001887E7710-0x00000001887E775C
		public static void WakeupFromSuspend(); // 0x00000001887E7D30-0x00000001887E7D70
		public static void InitScePad(); // 0x00000001887E5584-0x00000001887E55C4
		public static void SetAudioMemoryBudget(ulong inMemoryBytes, ushort inGcCount = 10 /* Metadata: 0x02645C81 */); // 0x00000001887E6C44-0x00000001887E6CA0
		[Conditional("ENABLE_PROFILER")]
		public static void LogToWwise(string msg, bool isError = false /* Metadata: 0x02645C83 */, uint playingId = 0 /* Metadata: 0x02645C84 */, ulong goId = 0 /* Metadata: 0x02645C85 */); // 0x00000001887E5C54-0x00000001887E5CCC
		public static void MemoryShrink(); // 0x00000001887E5CCC-0x00000001887E5CFC
		public static void TouchAudioHotfixPlaceholder(); // 0x00000001887E786C-0x00000001887E7968
		public static void TouchAudioHotfixPlaceholderArgs(string[] stringArray, int[] intArray, uint[] uintArray, float[] floatArray, bool[] boolArray, long[] longArray, ulong[] ulongArray, double[] doubleArray, object[] objects); // 0x00000001887E77D8-0x00000001887E786C
		public static void AudioHotfixPlaceholder1(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null); // 0x00000001887E4D80-0x00000001887E4F34
		public static void AudioHotfixPlaceholder2(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null); // 0x00000001887E4F34-0x00000001887E50E8
		public static void AudioHotfixPlaceholder3(string[] stringArray = null, int[] intArray = null, uint[] uintArray = null, float[] floatArray = null, bool[] boolArray = null, long[] longArray = null, ulong[] ulongArray = null, double[] doubleArray = null, object[] objects = null); // 0x00000001887E50E8-0x00000001887E529C
		public static void LoadExtraPckFromPath(string path); // 0x00000001887E5BD4-0x00000001887E5C54
		private static bool _InitInternal(); // 0x00000001862FA050-0x00000001862FA230
		private static void _ReleaseInternal(bool hgDeepTerm = false /* Metadata: 0x02645C8D */); // 0x00000001887E824C-0x00000001887E84E0
		private static void _OnBeforeTerminate(); // 0x00000001887E81BC-0x00000001887E824C
		private static void _ResetStaticFields(); // 0x00000001862FA7D0-0x00000001862FA860
		private static void _OnEventPreparedDoPostEvent(uint inId, IntPtr _, AKRESULT __, object inCookie); // 0x000000018598A540-0x000000018598AA20
		private static void _OnEventCallback(object inCookie, AkCallbackType inType, AkCallbackInfo inInfo); // 0x000000018577C060-0x000000018577C6D0
		private static void _OnExternalSourceEventCallback(object inCookie, AkCallbackType inType, AkCallbackInfo inInfo); // 0x00000001863B1C50-0x00000001863B2010
		private static uint _PostEvent(uint eventId, ulong audioObjectId, AudioCallbackType callbackType = AudioCallbackType.None /* Metadata: 0x02645C8E */, AudioEventCallback originCallback = null, object originCookie = null); // 0x000000018577B3F0-0x000000018577B5B0
		private static uint _PostEventWithExternalSource(uint eventId, ulong audioObjectId, string externalSourceKey, uint externalCookie, AudioCallbackType callbackType, AudioEventCallback callback, object cookie = null, AudioCodec codec = AudioCodec.VORBIS /* Metadata: 0x02645C8F */); // 0x00000001863A7F60-0x00000001863A82A0
		private static void _ExecuteActionOnPlayingId(AkActionOnEventType type, uint playingId, int durationMs = 100 /* Metadata: 0x02645C90 */); // 0x0000000185A7CF30-0x0000000185A7D020
		private static uint _GetInternalPlayingId(); // 0x00000001887E8074-0x00000001887E80D0
		private static void _LoadAndPinEventsAsync([IsReadOnly] in IList<uint> events, [IsReadOnly] in Action<object> onDone = null, [IsReadOnly] in object payload = null); // 0x00000001887E80D0-0x00000001887E81BC
		private static void _DoLoadAndPinEventsSync(IList<uint> events); // 0x00000001887E7D70-0x00000001887E8074
		[IteratorStateMachine(typeof(__DoLoadAndPinEventsAsync_d__102))]
		private static IEnumerator _DoLoadAndPinEventsAsync(IList<uint> events, Action<object> onDone = null, object payload = null); // 0x0000000186690520-0x00000001866905E0
		private static void _InitAndroidActivityEnvironment(); // 0x00000001862FA730-0x00000001862FA760
		[Conditional("ENABLE_PROFILER")]
		internal static void SetUprSamplingEnabled(bool isEnabled); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("ENABLE_PROFILER")]
		private static void _ProfilerUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("ENABLE_PROFILER")]
		private static void _SampleAllData(); // 0x00000001887E84E0-0x00000001887E8510
		[Conditional("ENABLE_PROFILER")]
		private static void _SampleMemoryOnly(); // 0x00000001887E8510-0x00000001887E8540
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[Conditional("ENABLE_PROFILER")]
		public static void StartProfileCapture(string fileName = null); // 0x00000001887E75C4-0x00000001887E7600
		[Conditional("ENABLE_PROFILER")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void StopProfileCapture(); // 0x00000001887E76DC-0x00000001887E7710
		public static AkResourceMonitorDataSummary GetResourceSummaryData(); // 0x00000001887E536C-0x00000001887E53A4
		public static AudioMemoryMonitor.FGlobalMemoryStats GetGlobalMemoryStats(); // 0x00000001887E5318-0x00000001887E536C
		public static AudioMemoryMonitor.FExtraMemoryStats GetExtraMemoryStats(); // 0x00000001887E52BC-0x00000001887E5318
		public static void SetEnableSpatialAudio(bool enable); // 0x00000001862E62E0-0x00000001862E63F0
		public static void SetObjectObstructionAndOcclusion(ulong audioObjectId, float obstructionLevel, float occlusionLevel); // 0x00000001887E6EA4-0x00000001887E6F78
		public static bool SetGeometry(ulong geoId, UnityEngine.Vector3[] vertices, ushort[] triangles, AudioAcousticSurfaceData[] surfaceData, ushort[] surfaceIdx, bool enableDiffraction = true /* Metadata: 0x02645C92 */, bool enableEdgeDiffraction = false /* Metadata: 0x02645C93 */); // 0x0000000185A1C970-0x0000000185A1CDB0
		public static bool SetGeometryInstance(ulong instanceId, UnityEngine.Vector3 pos, UnityEngine.Vector3 scale, Quaternion rot, ulong geoId, bool useReflectionAndDiffraction = false /* Metadata: 0x02645C94 */); // 0x000000018566C430-0x000000018566C570
		public static bool SetRoom(ulong roomId, AudioRoomData roomData, ulong geoInstanceId, string roomName = "room" /* Metadata: 0x02645C95 */); // 0x000000018566B8E0-0x000000018566BBA0
		public static bool SetPortal(ulong portalId, ulong roomIdA, ulong roomIdB, UnityEngine.Vector3 pos, Quaternion rot, UnityEngine.Vector3 extent, bool enabled, string portalName = "portal" /* Metadata: 0x02645C9A */); // 0x00000001887E6FE8-0x00000001887E7228
		public static bool SetPortalObstructionAndOcclusion(ulong portalId, float obstruction, float occlusion); // 0x00000001887E6F78-0x00000001887E6FE8
		public static bool SetReverbZone(ulong reverbZoneId, ulong parentRoom, float transitionWidth); // 0x00000001887E72DC-0x00000001887E734C
		public static bool RemoveRoom(ulong roomId); // 0x00000001887E65A0-0x00000001887E65F0
		public static bool RemovePortal(ulong portalId); // 0x00000001887E6500-0x00000001887E6550
		public static bool RemoveGeometry(ulong geoId); // 0x00000001887E64B0-0x00000001887E6500
		public static bool RemoveGeometryInstance(ulong instanceId); // 0x00000001887E6460-0x00000001887E64B0
		public static bool RemoveReverbZone(ulong reverbZoneId); // 0x00000001887E6550-0x00000001887E65A0
	}

	public delegate void AudioEventCallback(object in_cookie, AudioCallbackType in_type, AudioCallbackInfo in_info); // TypeDefIndex: 86810; 0x00000001826EAF30-0x00000001826EAF70

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioStringAttribute : PropertyAttribute // TypeDefIndex: 86811
	{
		// Constructors
		public AudioStringAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioVectorAttribute : PropertyAttribute // TypeDefIndex: 86812
	{
		// Constructors
		public AudioVectorAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AudioEventWarnAttribute : PropertyAttribute // TypeDefIndex: 86814
	{
		// Fields
		public WarnType warnType; // 0x10
	
		// Nested types
		public enum WarnType : byte // TypeDefIndex: 86813
		{
			NONE = 0,
			ONE_SHOT = 2,
			LOOP = 4
		}
	
		// Constructors
		public AudioEventWarnAttribute(WarnType type); // 0x0000000182A819C0-0x0000000182A819D0
	}

	public class BankHandle : IDisposable // TypeDefIndex: 86815
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
		public string name { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public AKRESULT result { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public bool isDone { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EB80-0x000000018226EB90 0x000000018226EB90-0x000000018226EBA0
		public int refCount { get; } // 0x00000001887EB290-0x00000001887EB2D0 
	
		// Constructors
		public BankHandle(string bankName); // 0x0000000186119890-0x00000001861198B0
	
		// Methods
		public void Dispose(); // 0x00000001887EB1D0-0x00000001887EB254
		public void IncRef(); // 0x00000001887EB254-0x00000001887EB290
		public void DecRef(); // 0x00000001887EB194-0x00000001887EB1D0
	}

	public class AsyncLoadBankTask : IEnumerator, IDisposable // TypeDefIndex: 86816
	{
		// Fields
		private readonly List<BankHandle> m_handles; // 0x10
	
		// Properties
		public object Current { get; } // 0x00000001871FE520-0x00000001871FE550 
	
		// Constructors
		public AsyncLoadBankTask(IList<string> bankNames); // 0x00000001861182C0-0x00000001861187D0
	
		// Methods
		public static AsyncLoadBankTask LoadBanksAsync(IList<string> bankNames); // 0x00000001862B3400-0x00000001862B3480
		public bool MoveNext(); // 0x0000000186CAB810-0x0000000186CAB950
		public void Reset(); // 0x00000001887E47D4-0x00000001887E480C
		public void Dispose(); // 0x00000001887E4670-0x00000001887E47D4
	}

	public static class AudioBankManager // TypeDefIndex: 86818
	{
		// Fields
		private static readonly AkCallbackManager.BankCallback s_loadBankCallback; // 0x00
		internal static Dictionary<string, BankHandle> s_loadedBankHandles; // 0x08
	
		// Nested types
		public class CallbackCookie // TypeDefIndex: 86817
		{
			// Fields
			public string bankName; // 0x10
			public Action callback; // 0x18
			public BankHandle handle; // 0x20
	
			// Constructors
			public CallbackCookie(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		static AudioBankManager(); // 0x0000000186B04FE0-0x0000000186B050E0
	
		// Methods
		public static void LoadMainPCK(); // 0x0000000186692A70-0x0000000186692AE0
		public static BankHandle LoadBankAsync(string bankName, Action callback = null); // 0x00000001861187D0-0x0000000186118A10
		private static void _LoadBankCallback(uint inBankId, IntPtr _, AKRESULT inLoadResult, object inCookie); // 0x0000000186119680-0x00000001861197D0
		public static bool UnloadBank(string bankName); // 0x00000001887E9508-0x00000001887E9674
		public static void UnloadAllBanks(); // 0x00000001887E9300-0x00000001887E9508
		public static bool IsBankLoaded(string bankName); // 0x00000001861197D0-0x0000000186119890
		public static void Reset(); // 0x00000001887E9264-0x00000001887E9300
		[Conditional("ENABLE_PROFILER")]
		public static void LoadDebugFilePackage(string path); // 0x00000001887E9130-0x00000001887E9264
		[Conditional("ENABLE_PROFILER")]
		public static void AddDebugBankPath(string path); // 0x00000001887E9078-0x00000001887E9130
		private static void _PreResetBasePath(out List<uint> unPinnedEventIds); // 0x00000001887E96F4-0x00000001887E984C
		private static void _PostResetBasePath(List<uint> unPinnedEventIds); // 0x00000001887E9674-0x00000001887E96F4
	}

	public class AudioConstants // TypeDefIndex: 86819
	{
		// Fields
		public const ulong AUDIO_INVALID_GAME_OBJECT = 18446744073709551615; // Metadata: 0x02645CA4
		public const uint AUDIO_INVALID_UNIQUE_ID = 0; // Metadata: 0x02645CAC
		public const uint AUDIO_INVALID_INTERNAL_PLAYING_ID = 0; // Metadata: 0x02645CAD
		public const ulong AUDIO_GLOBAL_GAME_OBJECT = 18446744073709551615; // Metadata: 0x02645CAE
		public const ulong AUDIO_ROOM_OUTDOOR_ID = 18446744073709551615; // Metadata: 0x02645CB6
		public const ulong AUDIO_ROOM_OUTDOORS_ID = 18446744073709551612; // Metadata: 0x02645CBE
		public const string AU_UI_BATTLE_BREAK_POISE = "au_ui_bat_break_poise"; // Metadata: 0x02645CC6
		public const string AU_GLOBAL_GAIN_ON = "au_global_gain_on"; // Metadata: 0x02645CDC
		public const string AU_GLOBAL_GAIN_OFF = "au_global_gain_off"; // Metadata: 0x02645CEE
		public const uint AU_HASH_EXTERNAL_SOURCE_COOKIE = 618371124; // Metadata: 0x02645D01
		public const uint AU_BANK_INIT = 1355168291; // Metadata: 0x02645D06
		public const string AU_DEVICE_CONTROLLER_SPEAKER = "Controller_Speaker"; // Metadata: 0x02645D0B
		public const int AUDIO_SPEAKER_SETUP_4_0 = 1539; // Metadata: 0x02645D1E
		public const string AU_DEVICE_WWISE_MOTION = "Wwise_Motion"; // Metadata: 0x02645D20
		public const string AU_DEVICE_SYSTEM = "System"; // Metadata: 0x02645D2D
		public const string AU_DEVICE_SYSTEM_3D = "System_3D"; // Metadata: 0x02645D34
		public const uint AUDIO_UI_FULLSCREEN_OPEN = 3229907725; // Metadata: 0x02645D3E
		public const uint AUDIO_UI_FULLSCREEN_CLOSE = 166048075; // Metadata: 0x02645D43
		public const uint AUDIO_UI_FULLSCREEN_PAUSE = 697133041; // Metadata: 0x02645D47
	
		// Constructors
		public AudioConstants(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public struct AudioId // TypeDefIndex: 86820
	{
		// Fields
		[JsonProperty]
		[SerializeField]
		public int _id; // 0x00
	
		// Constructors
		public AudioId(uint id); // 0x0000000184547F40-0x0000000184547F50
	
		// Methods
		public string GetName(); // 0x00000001887E9E7C-0x00000001887E9EF4
		[IDTag(0)]
		public static implicit operator uint(AudioId id); // 0x00000001887E9F44-0x00000001887E9F80
		[IDTag(1)]
		public static implicit operator int(AudioId id); // 0x00000001887E9F80-0x00000001887E9FBC
		[IDTag(2)]
		public static implicit operator AudioId(uint id); // 0x0000000185778B40-0x0000000185778B70
		[IDTag(3)]
		public static implicit operator AudioId(int id); // 0x00000001887E9FBC-0x00000001887E9FFC
		[IDTag(4)]
		public static implicit operator AudioId(string id); // 0x00000001887E9EF4-0x00000001887E9F44
	}

	public static class AudioIdExtensions // TypeDefIndex: 86821
	{
		// Extension methods
		public static uint[] ToUIntArray(this ICollection<AudioId> ids); // 0x00000001887E9C9C-0x00000001887E9E7C
	}

	[Serializable]
	public struct AudioState : IEquatable<AudioState> // TypeDefIndex: 86822
	{
		// Fields
		[SerializeField]
		private int _stateGroup; // 0x00
		[SerializeField]
		private int _stateValue; // 0x04
	
		// Properties
		public uint stateGroup { get; } // 0x00000001887EAA94-0x00000001887EAAD4 
		public uint stateValue { get; } // 0x00000001887EAAD4-0x00000001887EAB14 
	
		// Constructors
		public AudioState(uint stateGroup, uint stateValue); // 0x00000001827241A0-0x00000001827241B0
	
		// Methods
		[IDTag(0)]
		public bool Equals(AudioState other); // 0x00000001887EA854-0x00000001887EA8AC
		[IDTag(1)]
		public override bool Equals(object obj); // 0x00000001887EA8AC-0x00000001887EA950
		public override int GetHashCode(); // 0x00000001887EA950-0x00000001887EA9E4
		public bool __iFixBaseProxy_Equals(object P0); // 0x00000001887EA9E4-0x00000001887EAA44
		public int __iFixBaseProxy_GetHashCode(); // 0x00000001887EAA44-0x00000001887EAA94
	}

	[Serializable]
	public struct AudioIdList // TypeDefIndex: 86823
	{
		// Fields
		public AudioId[] _ids; // 0x00
	}

	[Serializable]
	public struct AudioStateList // TypeDefIndex: 86824
	{
		// Fields
		[SerializeField]
		public AudioState[] _states; // 0x00
	}

	[Serializable]
	public struct AudioEngineInitSetting // TypeDefIndex: 86825
	{
		// Fields
		public AkWwiseInitializationSettings akInitSettings; // 0x00
	}

	[Serializable]
	public struct AudioLargeSource // TypeDefIndex: 86826
	{
		// Fields
		public UnityEngine.Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
	}

	public struct AudioCallbackInfo // TypeDefIndex: 86827
	{
		// Fields
		public ulong objectId; // 0x00
		public IntPtr pCookie; // 0x08
		internal AkCallbackInfo rawInfo; // 0x10
	
		// Methods
		public AudioDurationCallbackInfo CastToDurationCallbackInfo(); // 0x00000001887E984C-0x00000001887E9948
	}

	public struct AudioDurationCallbackInfo // TypeDefIndex: 86828
	{
		// Fields
		public float duration; // 0x00
		public float estimatedDuration; // 0x04
		public uint audioNodeId; // 0x08
		public uint mediaId; // 0x0C
		public bool isStreaming; // 0x10
	}

	public class AudioPositionArrayProxy // TypeDefIndex: 86829
	{
		// Fields
		private AkPositionArray m_array; // 0x10
	
		// Properties
		public uint count { get; } // 0x0000000185A1AD80-0x0000000185A1ADC0 
	
		// Constructors
		public AudioPositionArrayProxy(uint count); // 0x0000000185A1B020-0x0000000185A1B0A0
	
		// Methods
		public AkPositionArray GetRawArray(); // 0x00000001887EA814-0x00000001887EA854
		public void Add(UnityEngine.Vector3 position, UnityEngine.Vector3 forward, UnityEngine.Vector3 up); // 0x0000000185A1AB60-0x0000000185A1AC40
		public void Reset(); // 0x0000000185A1AFE0-0x0000000185A1B020
		~AudioPositionArrayProxy(); // 0x0000000185A1D2C0-0x0000000185A1D310
	}

	[Serializable]
	public struct AudioAcousticSurfaceData // TypeDefIndex: 86830
	{
		// Fields
		public uint textureId; // 0x00
		[Range(0f, 1f)]
		public float transmissionLoss; // 0x04
	}

	[Serializable]
	public struct AudioRoomData // TypeDefIndex: 86832
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
		public enum EBoolFlags : ushort // TypeDefIndex: 86831
		{
			None = 0,
			KeepRegistered = 1,
			UseForReflectionAndDiffraction = 2,
			AsReverbZone = 4
		}
	}

	public static class AudioDebugMsg // TypeDefIndex: 86833
	{
		// Methods
		public static EAudioDebugMsgFilter GetEnabledFilters(); // 0x00000001821F1820-0x00000001821F1850
		public static bool IsFilterEnabled(EAudioDebugMsgFilter filters); // 0x00000001821F1880-0x00000001821F18C0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void SetFilterEnabled(EAudioDebugMsgFilter filters, bool enabled); // 0x00000001821F1960-0x00000001821F19A0
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[Conditional("UNITY_EDITOR")]
		public static void SetEnabledFilters(EAudioDebugMsgFilter filters); // 0x00000001821F1920-0x00000001821F1960
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void ResetFilter(); // 0x00000001821F18F0-0x00000001821F1920
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void ExpandBuffer(int newCapacity); // 0x00000001821F1400-0x00000001821F1440
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void ClearBuffer(); // 0x00000001821F13D0-0x00000001821F1400
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void ResetBuffer(); // 0x00000001821F18C0-0x00000001821F18F0
		public static int GetBufferCapacity(); // 0x00000001821F1440-0x00000001821F1470
		public static int GetBufferSize(); // 0x00000001821F1470-0x00000001821F14A0
		public static AudioDebugMsgItem[] GetBufferedMessages(); // 0x00000001821F14A0-0x00000001821F1820
		public static long GetOverwrittenMessageCount(); // 0x00000001821F1850-0x00000001821F1880
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAnimEventMsg(EAudioDebugMsgLevel level, string eventName, string animName, int animFrame); // 0x00000001821F12E0-0x00000001821F1330
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIEmitterCallMsg([IsReadOnly] in AudioDebugAPIEmitterCallMsg message, AKRESULT? result = default); // 0x00000001821F08B0-0x00000001821F08F0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIEmitterPositionCallMsg([IsReadOnly] in AudioDebugAPIEmitterPositionCallMsg message, AKRESULT? result = default); // 0x00000001821F0980-0x00000001821F09C0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(0)]
		public static void AddAPIEmitterMultiplePositionsCallMsg([IsReadOnly] in AudioDebugAPIEmitterMultiplePositionsCallMsg message, AKRESULT? result = default); // 0x00000001821F08F0-0x00000001821F0930
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(1)]
		public static void AddAPIEmitterMultiplePositionsCallMsg(ulong emitterId, ushort positionCount, AkMultiPositionType positionType, AKRESULT result); // 0x00000001821F0930-0x00000001821F0980
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIEngineLifecycleMsg(EAudioDebugAPIEngineLifecycleOperation operation, bool deepTermination = false /* Metadata: 0x02645D54 */, bool? isInitialized = default); // 0x00000001821F0A00-0x00000001821F0A50
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIEngineCallMsg([IsReadOnly] in AudioDebugAPIEngineCallMsg message, AKRESULT? result = default); // 0x00000001821F09C0-0x00000001821F0A00
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIRenderAudioCallMsg(AudioDebugAPIRenderAudioCallMsg message, AKRESULT? result = default); // 0x00000001821F0E60-0x00000001821F0EA0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIListenerCallMsg([IsReadOnly] in AudioDebugAPIListenerCallMsg message, AKRESULT? result = default); // 0x00000001821F0C20-0x00000001821F0C60
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIScePadOutputDeviceMappingMsg([IsReadOnly] in AudioDebugAPIScePadOutputDeviceMappingMsg message); // 0x00000001821F1100-0x00000001821F1140
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(0)]
		public static void AddAPIOutputDeviceCallMsg([IsReadOnly] in AudioDebugAPIOutputDeviceCallMsg message, AKRESULT? result = default); // 0x00000001821F0CA0-0x00000001821F0CE0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(1)]
		public static void AddAPIOutputDeviceCallMsg(EAudioDebugAPIOutputDeviceOperation operation, ulong outputId, uint deviceShareSetId, AKRESULT? result = default, uint? deviceId = default, uint? channelMask = default, uint? numChannels = default); // 0x00000001821F0CE0-0x00000001821F0D60
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIOutputDeviceEffectCallMsg([IsReadOnly] in AudioDebugAPIOutputDeviceEffectCallMsg message, AKRESULT? result = default); // 0x00000001821F0D60-0x00000001821F0DA0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIAudioSessionCallMsg([IsReadOnly] in AudioDebugAPIAudioSessionCallMsg message); // 0x00000001821F0830-0x00000001821F0870
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void AddAPIEventCallMsg([IsReadOnly] in AudioDebugAPIEventCallMsg message); // 0x00000001821F0AE0-0x00000001821F0B20
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(1)]
		public static void AddAPIEventCallMsg(EAudioDebugMsgLevel level, int eventId, long emitterId); // 0x00000001821F0A90-0x00000001821F0AE0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(0)]
		public static void AddAPIStateCallMsg([IsReadOnly] in AudioDebugAPIStateCallMsg message, AKRESULT? result = default); // 0x00000001821F11C0-0x00000001821F1200
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(1)]
		public static void AddAPIStateCallMsg(EAudioDebugMsgLevel level, int stateGroupId, int stateId); // 0x00000001821F1200-0x00000001821F1250
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(0)]
		public static void AddAPISwitchCallMsg([IsReadOnly] in AudioDebugAPISwitchCallMsg message, AKRESULT? result = default); // 0x00000001821F1250-0x00000001821F1290
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(1)]
		public static void AddAPISwitchCallMsg(EAudioDebugMsgLevel level, int switchGroupId, int switchId, long emitterId); // 0x00000001821F1290-0x00000001821F12E0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIEventActionCallMsg([IsReadOnly] in AudioDebugAPIEventActionCallMsg message); // 0x00000001821F0A50-0x00000001821F0A90
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIEventSeekCallMsg([IsReadOnly] in AudioDebugAPIEventSeekCallMsg message, AKRESULT? result = default); // 0x00000001821F0B20-0x00000001821F0B60
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[IDTag(0)]
		public static void AddAPIRtpcCallMsg([IsReadOnly] in AudioDebugAPIRtpcCallMsg message, AKRESULT? result = default); // 0x00000001821F0FC0-0x00000001821F1000
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void AddAPIRtpcCallMsg(EAudioDebugMsgLevel level, int rtpcId, float value, int fadeTimeMs, long emitterId); // 0x00000001821F0F60-0x00000001821F0FC0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIResourcePathCallMsg([IsReadOnly] in AudioDebugAPIResourcePathCallMsg message); // 0x00000001821F0EA0-0x00000001821F0EE0
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[Conditional("UNITY_EDITOR")]
		public static void AddAPIFilePackageCallMsg([IsReadOnly] in AudioDebugAPIFilePackageCallMsg message); // 0x00000001821F0B60-0x00000001821F0BA0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIBankCallMsg([IsReadOnly] in AudioDebugAPIBankCallMsg message); // 0x00000001821F0870-0x00000001821F08B0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIPrepareEventCallMsg([IsReadOnly] in AudioDebugAPIPrepareEventCallMsg message); // 0x00000001821F0DE0-0x00000001821F0E20
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIScePadDeviceCallMsg([IsReadOnly] in AudioDebugAPIScePadDeviceCallMsg message); // 0x00000001821F1080-0x00000001821F10C0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIScePadControllerInfoMsg([IsReadOnly] in AudioDebugAPIScePadControllerInfoMsg message); // 0x00000001821F1040-0x00000001821F1080
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIScePadAudioCallMsg([IsReadOnly] in AudioDebugAPIScePadAudioCallMsg message); // 0x00000001821F1000-0x00000001821F1040
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIScePadLightBarCallMsg([IsReadOnly] in AudioDebugAPIScePadLightBarCallMsg message); // 0x00000001821F10C0-0x00000001821F1100
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIScePadTriggerCallMsg([IsReadOnly] in AudioDebugAPIScePadTriggerCallMsg message); // 0x00000001821F1140-0x00000001821F1180
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPISpatialSettingsCallMsg([IsReadOnly] in AudioDebugAPISpatialSettingsCallMsg message, AKRESULT? result = default); // 0x00000001821F1180-0x00000001821F11C0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIGeometryCallMsg([IsReadOnly] in AudioDebugAPIGeometryCallMsg message, AKRESULT? result = default); // 0x00000001821F0BA0-0x00000001821F0BE0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIRoomCallMsg([IsReadOnly] in AudioDebugAPIRoomCallMsg message, AKRESULT? result = default); // 0x00000001821F0F20-0x00000001821F0F60
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIPortalCallMsg([IsReadOnly] in AudioDebugAPIPortalCallMsg message, AKRESULT? result = default); // 0x00000001821F0DA0-0x00000001821F0DE0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIReverbZoneCallMsg([IsReadOnly] in AudioDebugAPIReverbZoneCallMsg message, AKRESULT? result = default); // 0x00000001821F0EE0-0x00000001821F0F20
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIRemoveSpatialObjectCallMsg([IsReadOnly] in AudioDebugAPIRemoveSpatialObjectCallMsg message, AKRESULT? result = default); // 0x00000001821F0E20-0x00000001821F0E60
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIObstructionCallMsg([IsReadOnly] in AudioDebugAPIObstructionCallMsg message, AKRESULT? result = default); // 0x00000001821F0C60-0x00000001821F0CA0
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddAPIGeometryInstanceCallMsg([IsReadOnly] in AudioDebugAPIGeometryInstanceCallMsg message, AKRESULT? result = default); // 0x00000001821F0BE0-0x00000001821F0C20
		[Conditional("BEYOND_DEBUG_COMMAND")]
		[Conditional("UNITY_EDITOR")]
		public static void AddEventEndMsg(uint eventId, ulong emitterId, uint playingId, uint internalPlayingId); // 0x00000001821F1330-0x00000001821F1380
		[Conditional("UNITY_EDITOR")]
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void AddLevelScriptEventMsg(EAudioDebugMsgLevel level, int eventId, string levelScriptNode); // 0x00000001821F1380-0x00000001821F13D0
	}

	public enum EAudioDebugMsgLevel // TypeDefIndex: 86834
	{
		INFO = 0,
		WARNING = 1,
		ERROR = 2
	}

	public enum EAudioDebugMsgCategory // TypeDefIndex: 86835
	{
		NONE = 0,
		API_PLAYBACK_CALL = 1,
		API_EMITTER_CALL = 2,
		API_LISTENER_CALL = 3,
		API_SPATIAL_CALL = 4,
		API_OUTPUT_DEVICE_CALL = 5,
		API_ENGINE_CALL = 6,
		API_RESOURCE_CALL = 7,
		API_SCE_PAD_CALL = 8,
		ANIM_EVENT = 9,
		LEVEL_SCRIPT_EVENT = 10,
		EVENT_CALLBACK = 11
	}

	[Flags]
	public enum EAudioDebugMsgFilter : long // TypeDefIndex: 86836
	{
		ALL = -1,
		NONE = 0,
		API_PLAYBACK = 1,
		API_RTPC = 2,
		API_EMITTER_LISTENER = 4,
		API_POSITION = 8,
		API_SPATIAL = 16,
		API_OUTPUT_DEVICE = 32,
		API_ENGINE = 64,
		API_RENDER_AUDIO = 128,
		API_RESOURCE = 256,
		API_SCE_PAD = 512,
		ANIM_EVENT = 1024,
		LEVEL_SCRIPT_EVENT = 2048,
		EVENT_CALLBACK = 4096
	}

	public struct AudioDebugMsgItem // TypeDefIndex: 86837
	{
		// Fields
		public System.DateTime timestamp; // 0x00
		public int frameCount; // 0x08
		public long monotonicTicks; // 0x10
		public long sequence; // 0x18
		public EAudioDebugMsgLevel level; // 0x20
		public EAudioDebugMsgCategory category; // 0x24
		public int messageType; // 0x28
		public int intArg0; // 0x2C
		public int intArg1; // 0x30
		public int intArg2; // 0x34
		public long longArg0; // 0x38
		public float floatArg0; // 0x40
		public float floatArg1; // 0x44
		public float floatArg2; // 0x48
		public float floatArg3; // 0x4C
		public string strArg0; // 0x50
		public string strArg1; // 0x58
		public int intArg3; // 0x60
		public int intArg4; // 0x64
		public int intArg5; // 0x68
		public long longArg1; // 0x70
		public long longArg2; // 0x78
		public UnityEngine.Vector3 vectorArg0; // 0x80
		public UnityEngine.Vector3 vectorArg1; // 0x8C
		public UnityEngine.Vector3 vectorArg2; // 0x98
		public UnityEngine.Vector3 vectorArg3; // 0xA4
		public Quaternion quaternionArg0; // 0xB0
		public object objectArg0; // 0xC0
	
		// Methods
		public AudioDebugLevelScriptEventMsg ToLevelScriptEventMsg(); // 0x00000001821F0780-0x00000001821F0830
	}

	public struct AudioDebugAnimEventMsg // TypeDefIndex: 86838
	{
		// Fields
		public string eventName; // 0x00
		public string animName; // 0x08
		public int animFrame; // 0x10
	}

	public enum EAudioDebugAPIEmitterCallType // TypeDefIndex: 86839
	{
		CONTROL = 0,
		POSITION = 1,
		MULTIPLE_POSITIONS = 2
	}

	public enum EAudioDebugAPIEmitterOperation // TypeDefIndex: 86840
	{
		REGISTER = 0,
		REGISTER_WITH_NAME = 1,
		UNREGISTER = 2,
		SET_SCALING_FACTOR = 3
	}

	public struct AudioDebugAPIEmitterCallMsg // TypeDefIndex: 86841
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_EMITTER_CALL; // Metadata: 0x02645DE3
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_EMITTER_LISTENER; // Metadata: 0x02645DE4
		public const EAudioDebugAPIEmitterCallType TYPE = EAudioDebugAPIEmitterCallType.CONTROL; // Metadata: 0x02645DEC
		public AKRESULT? result; // 0x00
		public EAudioDebugAPIEmitterOperation operation; // 0x08
		public ulong emitterId; // 0x10
		public string name; // 0x18
		public float scalingFactor; // 0x20
	
		// Methods
		public static AudioDebugAPIEmitterCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821E8720-0x00000001821E8BA0
	}

	public struct AudioDebugAPIEmitterPosition // TypeDefIndex: 86842
	{
		// Fields
		public UnityEngine.Vector3 forward; // 0x00
		public UnityEngine.Vector3 up; // 0x0C
		public double x; // 0x18
		public double y; // 0x20
		public double z; // 0x28
	}

	public struct AudioDebugAPIEmitterPositionCallMsg // TypeDefIndex: 86843
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_EMITTER_CALL; // Metadata: 0x02645DED
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_POSITION; // Metadata: 0x02645DEE
		public const EAudioDebugAPIEmitterCallType TYPE = EAudioDebugAPIEmitterCallType.POSITION; // Metadata: 0x02645DF6
		public AKRESULT? result; // 0x00
		public ulong emitterId; // 0x08
		public UnityEngine.Vector3 position; // 0x10
		public UnityEngine.Vector3 forward; // 0x1C
		public UnityEngine.Vector3 up; // 0x28
	
		// Methods
		public static AudioDebugAPIEmitterPositionCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821E93B0-0x00000001821E9810
	}

	public struct AudioDebugAPIEmitterMultiplePositionsCallMsg // TypeDefIndex: 86844
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_EMITTER_CALL; // Metadata: 0x02645DF7
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_POSITION; // Metadata: 0x02645DF8
		public const EAudioDebugAPIEmitterCallType TYPE = EAudioDebugAPIEmitterCallType.MULTIPLE_POSITIONS; // Metadata: 0x02645E00
		public AKRESULT? result; // 0x00
		public ulong emitterId; // 0x08
		public AkMultiPositionType positionType; // 0x10
		public AudioDebugAPIEmitterPosition[] positions; // 0x18
		public int positionCount; // 0x20
	
		// Methods
		public static AudioDebugAPIEmitterMultiplePositionsCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821E8BA0-0x00000001821E93B0
	}

	public enum EAudioDebugAPIEngineCallType // TypeDefIndex: 86845
	{
		CONTROL = 0,
		LIFECYCLE = 1,
		RENDER_AUDIO = 2
	}

	public enum EAudioDebugAPIEngineOperation // TypeDefIndex: 86846
	{
		SUSPEND = 0,
		WAKEUP = 1,
		SET_LANGUAGE = 2,
		INITIALIZE = 3,
		TERMINATE = 4,
		INIT_SCE_PAD = 5,
		SET_ANDROID_ACTIVITY = 6,
		MEMORY_SHRINK = 7
	}

	public struct AudioDebugAPIEngineCallMsg // TypeDefIndex: 86847
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_ENGINE_CALL; // Metadata: 0x02645E0C
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_ENGINE; // Metadata: 0x02645E0D
		public const EAudioDebugAPIEngineCallType TYPE = EAudioDebugAPIEngineCallType.CONTROL; // Metadata: 0x02645E15
		public AKRESULT? result; // 0x00
		public EAudioDebugAPIEngineOperation operation; // 0x08
		public string name; // 0x10
		public bool flag; // 0x18
		public bool? succeeded; // 0x19
	
		// Methods
		public static AudioDebugAPIEngineCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821E9810-0x00000001821E9F40
	}

	public enum EAudioDebugAPIEngineLifecycleOperation // TypeDefIndex: 86848
	{
		INITIALIZE = 0,
		TERMINATE = 1,
		HOT_RESTART = 2
	}

	public struct AudioDebugAPIEngineLifecycleMsg // TypeDefIndex: 86849
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_ENGINE_CALL; // Metadata: 0x02645E19
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_ENGINE; // Metadata: 0x02645E1A
		public const EAudioDebugAPIEngineCallType TYPE = EAudioDebugAPIEngineCallType.LIFECYCLE; // Metadata: 0x02645E22
		public EAudioDebugAPIEngineLifecycleOperation operation; // 0x00
		public bool? isInitialized; // 0x04
		public bool deepTermination; // 0x06
	
		// Methods
		public static AudioDebugAPIEngineLifecycleMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821E9F40-0x00000001821EA310
	}

	public struct AudioDebugAPIRenderAudioCallMsg // TypeDefIndex: 86850
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_ENGINE_CALL; // Metadata: 0x02645E23
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_RENDER_AUDIO; // Metadata: 0x02645E24
		public const EAudioDebugAPIEngineCallType TYPE = EAudioDebugAPIEngineCallType.RENDER_AUDIO; // Metadata: 0x02645E2C
		public AKRESULT? result; // 0x00
	
		// Methods
		public static AudioDebugAPIRenderAudioCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EDA60-0x00000001821EDE20
	}

	public enum EAudioDebugAPIListenerOperation // TypeDefIndex: 86851
	{
		SET_DEFAULT_LISTENERS = 0,
		SET_LISTENERS = 1,
		REGISTER_SPATIAL_LISTENER = 2,
		UNREGISTER_SPATIAL_LISTENER = 3,
		SET_DISTANCE_PROBE = 4
	}

	public struct AudioDebugAPIListenerCallMsg // TypeDefIndex: 86852
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_LISTENER_CALL; // Metadata: 0x02645E32
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_EMITTER_LISTENER; // Metadata: 0x02645E33
		public const int TYPE = 0; // Metadata: 0x02645E3B
		public AKRESULT? result; // 0x00
		public EAudioDebugAPIListenerOperation operation; // 0x08
		public ulong emitterId; // 0x10
		public ulong listenerId; // 0x18
	
		// Methods
		public static AudioDebugAPIListenerCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EB9B0-0x00000001821EBDC0
	}

	public enum EAudioDebugAPIOutputDeviceCallType // TypeDefIndex: 86853
	{
		CONTROL = 0,
		EFFECT = 1,
		AUDIO_SESSION = 2,
		SCE_PAD_MAPPING = 3
	}

	public enum EAudioDebugAPIOutputDeviceOperation // TypeDefIndex: 86854
	{
		ADD = 0,
		REMOVE = 1,
		REPLACE = 2
	}

	public struct AudioDebugAPIOutputDeviceCallMsg // TypeDefIndex: 86855
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_OUTPUT_DEVICE_CALL; // Metadata: 0x02645E43
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_OUTPUT_DEVICE; // Metadata: 0x02645E44
		public const EAudioDebugAPIOutputDeviceCallType TYPE = EAudioDebugAPIOutputDeviceCallType.CONTROL; // Metadata: 0x02645E4C
		public AKRESULT? result; // 0x00
		public EAudioDebugAPIOutputDeviceOperation operation; // 0x08
		public ulong outputId; // 0x10
		public uint deviceShareSetId; // 0x18
		public uint? deviceId; // 0x1C
		public uint? channelMask; // 0x24
		public uint? numChannels; // 0x2C
	
		// Methods
		public static AudioDebugAPIOutputDeviceCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EC1F0-0x00000001821EC970
	}

	public struct AudioDebugAPIOutputDeviceEffectCallMsg // TypeDefIndex: 86856
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_OUTPUT_DEVICE_CALL; // Metadata: 0x02645E4D
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_OUTPUT_DEVICE; // Metadata: 0x02645E4E
		public const EAudioDebugAPIOutputDeviceCallType TYPE = EAudioDebugAPIOutputDeviceCallType.EFFECT; // Metadata: 0x02645E56
		public AKRESULT? result; // 0x00
		public ulong outputId; // 0x08
		public uint effectIndex; // 0x10
		public uint shareSetId; // 0x14
	
		// Methods
		public static AudioDebugAPIOutputDeviceEffectCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EC970-0x00000001821ECD70
	}

	public struct AudioDebugAPIAudioSessionCallMsg // TypeDefIndex: 86857
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_OUTPUT_DEVICE_CALL; // Metadata: 0x02645E57
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_OUTPUT_DEVICE; // Metadata: 0x02645E58
		public const EAudioDebugAPIOutputDeviceCallType TYPE = EAudioDebugAPIOutputDeviceCallType.AUDIO_SESSION; // Metadata: 0x02645E60
		public int category; // 0x00
		public int categoryOptions; // 0x04
	
		// Methods
		public static AudioDebugAPIAudioSessionCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821E81C0-0x00000001821E82A0
	}

	public struct AudioDebugAPIScePadOutputDeviceMappingMsg // TypeDefIndex: 86858
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_OUTPUT_DEVICE_CALL; // Metadata: 0x02645E61
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_OUTPUT_DEVICE; // Metadata: 0x02645E62
		public const int TYPE = 3; // Metadata: 0x02645E6A
		public int scePadHandle; // 0x00
		public uint deviceId; // 0x04
	
		// Methods
		public static AudioDebugAPIScePadOutputDeviceMappingMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EF710-0x00000001821EF7F0
	}

	public enum EAudioDebugAPIPlaybackCallType // TypeDefIndex: 86859
	{
		EVENT = 0,
		STATE = 1,
		SWITCH = 2,
		ACTION = 3,
		SEEK = 4,
		RTPC = 5
	}

	public enum EAudioDebugAPIEventActionOperation // TypeDefIndex: 86860
	{
		STOP_ALL = 0,
		STOP_ALL_ON_EMITTER = 1,
		EXECUTE_ON_PLAYING_ID = 2
	}

	public struct AudioDebugAPIEventCallMsg // TypeDefIndex: 86861
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_PLAYBACK_CALL; // Metadata: 0x02645E74
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_PLAYBACK; // Metadata: 0x02645E75
		public const EAudioDebugAPIPlaybackCallType TYPE = EAudioDebugAPIPlaybackCallType.EVENT; // Metadata: 0x02645E7D
		public uint eventId; // 0x00
		public ulong emitterId; // 0x08
		public uint playingId; // 0x10
		public uint internalPlayingId; // 0x14
		public uint callbackFlags; // 0x18
		public bool hasExternalSource; // 0x1C
		public string externalSourceKey; // 0x20
		public uint externalCookie; // 0x28
		public uint codecId; // 0x2C
	
		// Methods
		public static AudioDebugAPIEventCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EA420-0x00000001821EA5A0
	}

	public struct AudioDebugAPIStateCallMsg // TypeDefIndex: 86862
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_PLAYBACK_CALL; // Metadata: 0x02645E7E
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_PLAYBACK; // Metadata: 0x02645E7F
		public const EAudioDebugAPIPlaybackCallType TYPE = EAudioDebugAPIPlaybackCallType.STATE; // Metadata: 0x02645E87
		public AKRESULT? result; // 0x00
		public uint stateGroupId; // 0x08
		public uint stateId; // 0x0C
		public string stateGroupName; // 0x10
		public string stateName; // 0x18
	
		// Methods
		public static AudioDebugAPIStateCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EFD00-0x00000001821F01B0
	}

	public struct AudioDebugAPISwitchCallMsg // TypeDefIndex: 86863
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_PLAYBACK_CALL; // Metadata: 0x02645E88
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_PLAYBACK; // Metadata: 0x02645E89
		public const EAudioDebugAPIPlaybackCallType TYPE = EAudioDebugAPIPlaybackCallType.SWITCH; // Metadata: 0x02645E91
		public AKRESULT? result; // 0x00
		public uint switchGroupId; // 0x08
		public uint switchId; // 0x0C
		public ulong emitterId; // 0x10
		public string switchGroupName; // 0x18
		public string switchName; // 0x20
	
		// Methods
		public static AudioDebugAPISwitchCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821F01B0-0x00000001821F0680
	}

	public struct AudioDebugAPIEventActionCallMsg // TypeDefIndex: 86864
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_PLAYBACK_CALL; // Metadata: 0x02645E92
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_PLAYBACK; // Metadata: 0x02645E93
		public const EAudioDebugAPIPlaybackCallType TYPE = EAudioDebugAPIPlaybackCallType.ACTION; // Metadata: 0x02645E9B
		public EAudioDebugAPIEventActionOperation operation; // 0x00
		public ulong emitterId; // 0x08
		public uint playingId; // 0x10
		public uint internalPlayingId; // 0x14
		public AkActionOnEventType actionType; // 0x18
		public int fadeTimeMs; // 0x1C
	
		// Methods
		public static AudioDebugAPIEventActionCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EA310-0x00000001821EA420
	}

	public struct AudioDebugAPIEventSeekCallMsg // TypeDefIndex: 86865
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_PLAYBACK_CALL; // Metadata: 0x02645E9C
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_PLAYBACK; // Metadata: 0x02645E9D
		public const EAudioDebugAPIPlaybackCallType TYPE = EAudioDebugAPIPlaybackCallType.SEEK; // Metadata: 0x02645EA5
		public AKRESULT? result; // 0x00
		public uint eventId; // 0x08
		public ulong emitterId; // 0x10
		public uint playingId; // 0x18
		public uint internalPlayingId; // 0x1C
		public int timeMs; // 0x20
		public bool toNearestMarker; // 0x24
	
		// Methods
		public static AudioDebugAPIEventSeekCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EA5A0-0x00000001821EA9C0
	}

	public enum EAudioDebugAPIRtpcOperation // TypeDefIndex: 86866
	{
		SET_VALUE = 0,
		SET_VALUE_BY_PLAYING_ID = 1,
		RESET_VALUE = 2
	}

	public struct AudioDebugAPIRtpcCallMsg // TypeDefIndex: 86867
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_PLAYBACK_CALL; // Metadata: 0x02645EA9
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_RTPC; // Metadata: 0x02645EAA
		public const EAudioDebugAPIPlaybackCallType TYPE = EAudioDebugAPIPlaybackCallType.RTPC; // Metadata: 0x02645EB2
		public AKRESULT? result; // 0x00
		public uint rtpcId; // 0x08
		public float value; // 0x0C
		public int fadeTimeMs; // 0x10
		public ulong emitterId; // 0x18
		public EAudioDebugAPIRtpcOperation operation; // 0x20
		public uint playingId; // 0x24
		public uint internalPlayingId; // 0x28
		public string rtpcName; // 0x30
	
		// Methods
		public static AudioDebugAPIRtpcCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EEDB0-0x00000001821EF260
	}

	public enum EAudioDebugAPIResourcePathOperation // TypeDefIndex: 86868
	{
		SET_BASE_PATH = 0,
		ADD_BASE_PATH = 1
	}

	public enum EAudioDebugAPIFilePackageOperation // TypeDefIndex: 86869
	{
		LOAD = 0,
		UNLOAD = 1,
		UNLOAD_ALL = 2
	}

	public enum EAudioDebugAPIBankOperation // TypeDefIndex: 86870
	{
		LOAD = 0,
		UNLOAD = 1,
		CLEAR = 2
	}

	public struct AudioDebugAPIResourcePathCallMsg // TypeDefIndex: 86871
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_RESOURCE_CALL; // Metadata: 0x02645EBB
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_RESOURCE; // Metadata: 0x02645EBC
		public const int TYPE = 0; // Metadata: 0x02645EC4
		public EAudioDebugAPIResourcePathOperation operation; // 0x00
		public string path; // 0x08
		public AKRESULT? result; // 0x10
	
		// Methods
		public static AudioDebugAPIResourcePathCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EDE20-0x00000001821EE260
	}

	public struct AudioDebugAPIFilePackageCallMsg // TypeDefIndex: 86872
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_RESOURCE_CALL; // Metadata: 0x02645EC5
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_RESOURCE; // Metadata: 0x02645EC6
		public const int TYPE = 1; // Metadata: 0x02645ECE
		public EAudioDebugAPIFilePackageOperation operation; // 0x00
		public string path; // 0x08
		public uint packageId; // 0x10
		public AKRESULT? result; // 0x14
	
		// Methods
		public static AudioDebugAPIFilePackageCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EA9C0-0x00000001821EAE20
	}

	public struct AudioDebugAPIBankCallMsg // TypeDefIndex: 86873
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_RESOURCE_CALL; // Metadata: 0x02645ECF
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_RESOURCE; // Metadata: 0x02645ED0
		public const int TYPE = 2; // Metadata: 0x02645ED8
		public EAudioDebugAPIBankOperation operation; // 0x00
		public uint bankId; // 0x04
		public uint bankType; // 0x08
		public string bankName; // 0x10
		public bool usesName; // 0x18
		public bool asynchronous; // 0x19
		public long bankMemory; // 0x20
		public AKRESULT? result; // 0x28
	
		// Methods
		public static AudioDebugAPIBankCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821E82A0-0x00000001821E8720
	}

	public struct AudioDebugAPIPrepareEventCallMsg // TypeDefIndex: 86874
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_RESOURCE_CALL; // Metadata: 0x02645ED9
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_RESOURCE; // Metadata: 0x02645EDA
		public const int TYPE = 3; // Metadata: 0x02645EE2
		public int preparationType; // 0x00
		public uint eventId; // 0x04
		public bool asynchronous; // 0x08
		public AKRESULT? result; // 0x0C
	
		// Methods
		public static AudioDebugAPIPrepareEventCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821ED270-0x00000001821ED670
	}

	public enum EAudioDebugAPIScePadDeviceOperation // TypeDefIndex: 86875
	{
		INITIALIZE = 0,
		GET_HANDLE = 1,
		GET_OR_OPEN = 2,
		CLOSE = 3,
		SET_VIBRATION_MODE = 4
	}

	public enum EAudioDebugAPIScePadAudioOperation // TypeDefIndex: 86876
	{
		SET_VOLUME_GAIN = 0,
		GET_HEADSET_TYPE = 1,
		SET_AUDIO_OUT_PATH = 2
	}

	public enum EAudioDebugAPIScePadLightBarOperation // TypeDefIndex: 86877
	{
		SET = 0,
		RESET = 1
	}

	public struct AudioDebugAPIScePadDeviceCallMsg // TypeDefIndex: 86878
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SCE_PAD_CALL; // Metadata: 0x02645EED
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SCE_PAD; // Metadata: 0x02645EEE
		public const int TYPE = 0; // Metadata: 0x02645EF6
		public EAudioDebugAPIScePadDeviceOperation operation; // 0x00
		public int handle; // 0x04
		public int userId; // 0x08
		public int portType; // 0x0C
		public int vibrationMode; // 0x10
		public int result; // 0x14
		public string platform; // 0x18
	
		// Methods
		public static AudioDebugAPIScePadDeviceCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EF4B0-0x00000001821EF610
	}

	public struct AudioDebugAPIScePadControllerInfoMsg // TypeDefIndex: 86879
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SCE_PAD_CALL; // Metadata: 0x02645EF7
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SCE_PAD; // Metadata: 0x02645EF8
		public const int TYPE = 1; // Metadata: 0x02645F00
		public int handle; // 0x00
		public int result; // 0x04
		public float touchPixelDensity; // 0x08
		public int touchResolutionX; // 0x0C
		public int touchResolutionY; // 0x10
		public int deadZoneLeft; // 0x14
		public int deadZoneRight; // 0x18
		public int connectionType; // 0x1C
		public int connectionCount; // 0x20
		public bool connected; // 0x24
	
		// Methods
		public static AudioDebugAPIScePadControllerInfoMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EF380-0x00000001821EF4B0
	}

	public struct AudioDebugAPIScePadAudioCallMsg // TypeDefIndex: 86880
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SCE_PAD_CALL; // Metadata: 0x02645F01
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SCE_PAD; // Metadata: 0x02645F02
		public const int TYPE = 2; // Metadata: 0x02645F0A
		public EAudioDebugAPIScePadAudioOperation operation; // 0x00
		public int handle; // 0x04
		public int result; // 0x08
		public int headsetType; // 0x0C
		public int outputPath; // 0x10
		public byte speakerVolume; // 0x14
		public byte jackVolume; // 0x15
		public byte micGain; // 0x16
	
		// Methods
		public static AudioDebugAPIScePadAudioCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EF260-0x00000001821EF380
	}

	public struct AudioDebugAPIScePadLightBarCallMsg // TypeDefIndex: 86881
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SCE_PAD_CALL; // Metadata: 0x02645F0B
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SCE_PAD; // Metadata: 0x02645F0C
		public const int TYPE = 3; // Metadata: 0x02645F14
		public EAudioDebugAPIScePadLightBarOperation operation; // 0x00
		public int handle; // 0x04
		public int result; // 0x08
		public byte red; // 0x0C
		public byte green; // 0x0D
		public byte blue; // 0x0E
	
		// Methods
		public static AudioDebugAPIScePadLightBarCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EF610-0x00000001821EF710
	}

	public struct AudioDebugAPIScePadTriggerCallMsg // TypeDefIndex: 86882
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SCE_PAD_CALL; // Metadata: 0x02645F15
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SCE_PAD; // Metadata: 0x02645F16
		public const int TYPE = 4; // Metadata: 0x02645F1E
		public int handle; // 0x00
		public int result; // 0x04
		public int mode; // 0x08
		public byte mask; // 0x0C
		public long parameters0To7; // 0x10
		public int parameters8To10; // 0x18
	
		// Methods
		public static AudioDebugAPIScePadTriggerCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EF7F0-0x00000001821EF900
	}

	public enum EAudioDebugAPISpatialCallType // TypeDefIndex: 86883
	{
		SETTINGS = 0,
		GEOMETRY = 1,
		ROOM = 2,
		PORTAL = 3,
		REVERB_ZONE = 4,
		REMOVE_OBJECT = 5,
		OBSTRUCTION = 6,
		GEOMETRY_INSTANCE = 7
	}

	public enum EAudioDebugAPISpatialSetting // TypeDefIndex: 86884
	{
		PRIMARY_RAYS = 0,
		REFLECTIONS_ORDER = 1,
		DIFFRACTION_ORDER = 2,
		LOAD_BALANCING_SPREAD = 3
	}

	public enum EAudioDebugAPISpatialObjectType // TypeDefIndex: 86885
	{
		ROOM = 0,
		PORTAL = 1,
		GEOMETRY = 2,
		GEOMETRY_INSTANCE = 3,
		REVERB_ZONE = 4
	}

	public struct AudioDebugAPISpatialSettingsCallMsg // TypeDefIndex: 86886
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SPATIAL_CALL; // Metadata: 0x02645F30
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SPATIAL; // Metadata: 0x02645F31
		public const EAudioDebugAPISpatialCallType TYPE = EAudioDebugAPISpatialCallType.SETTINGS; // Metadata: 0x02645F39
		public AKRESULT? result; // 0x00
		public EAudioDebugAPISpatialSetting setting; // 0x08
		public uint value; // 0x0C
		public bool updatePaths; // 0x10
	
		// Methods
		public static AudioDebugAPISpatialSettingsCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EF900-0x00000001821EFD00
	}

	public struct AudioDebugAPIGeometryCallMsg // TypeDefIndex: 86887
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SPATIAL_CALL; // Metadata: 0x02645F3A
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SPATIAL; // Metadata: 0x02645F3B
		public const EAudioDebugAPISpatialCallType TYPE = EAudioDebugAPISpatialCallType.GEOMETRY; // Metadata: 0x02645F43
		public AKRESULT? result; // 0x00
		public ulong geometryId; // 0x08
		public UnityEngine.Vector3[] vertices; // 0x10
		public ushort[] triangles; // 0x18
		public AudioAcousticSurfaceData[] surfaces; // 0x20
		public ushort[] surfaceIndices; // 0x28
		public bool enableDiffraction; // 0x30
		public bool enableEdgeDiffraction; // 0x31
	
		// Methods
		public static AudioDebugAPIGeometryCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EAE20-0x00000001821EB530
	}

	public struct AudioDebugAPIRoomCallMsg // TypeDefIndex: 86888
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SPATIAL_CALL; // Metadata: 0x02645F44
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SPATIAL; // Metadata: 0x02645F45
		public const EAudioDebugAPISpatialCallType TYPE = EAudioDebugAPISpatialCallType.ROOM; // Metadata: 0x02645F4D
		public AKRESULT? result; // 0x00
		public ulong roomId; // 0x08
		public AudioRoomData data; // 0x10
		public ulong geometryInstanceId; // 0x48
		public string name; // 0x50
	
		// Methods
		public static AudioDebugAPIRoomCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EE670-0x00000001821EEDB0
	}

	public struct AudioDebugAPIPortalCallMsg // TypeDefIndex: 86889
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SPATIAL_CALL; // Metadata: 0x02645F4E
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SPATIAL; // Metadata: 0x02645F4F
		public const EAudioDebugAPISpatialCallType TYPE = EAudioDebugAPISpatialCallType.PORTAL; // Metadata: 0x02645F57
		public AKRESULT? result; // 0x00
		public ulong portalId; // 0x08
		public ulong frontRoomId; // 0x10
		public ulong backRoomId; // 0x18
		public UnityEngine.Vector3 position; // 0x20
		public UnityEngine.Vector3 forward; // 0x2C
		public UnityEngine.Vector3 up; // 0x38
		public UnityEngine.Vector3 extent; // 0x44
		public bool enabled; // 0x50
		public string name; // 0x58
	
		// Methods
		public static AudioDebugAPIPortalCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821ECD70-0x00000001821ED270
	}

	public struct AudioDebugAPIReverbZoneCallMsg // TypeDefIndex: 86890
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SPATIAL_CALL; // Metadata: 0x02645F58
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SPATIAL; // Metadata: 0x02645F59
		public const EAudioDebugAPISpatialCallType TYPE = EAudioDebugAPISpatialCallType.REVERB_ZONE; // Metadata: 0x02645F61
		public AKRESULT? result; // 0x00
		public ulong zoneId; // 0x08
		public ulong parentRoomId; // 0x10
		public float transitionWidth; // 0x18
	
		// Methods
		public static AudioDebugAPIReverbZoneCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EE260-0x00000001821EE670
	}

	public struct AudioDebugAPIRemoveSpatialObjectCallMsg // TypeDefIndex: 86891
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SPATIAL_CALL; // Metadata: 0x02645F62
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SPATIAL; // Metadata: 0x02645F63
		public const EAudioDebugAPISpatialCallType TYPE = EAudioDebugAPISpatialCallType.REMOVE_OBJECT; // Metadata: 0x02645F6B
		public AKRESULT? result; // 0x00
		public EAudioDebugAPISpatialObjectType objectType; // 0x08
		public ulong objectId; // 0x10
	
		// Methods
		public static AudioDebugAPIRemoveSpatialObjectCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821ED670-0x00000001821EDA60
	}

	public struct AudioDebugAPIObstructionCallMsg // TypeDefIndex: 86892
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SPATIAL_CALL; // Metadata: 0x02645F6C
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SPATIAL; // Metadata: 0x02645F6D
		public const EAudioDebugAPISpatialCallType TYPE = EAudioDebugAPISpatialCallType.OBSTRUCTION; // Metadata: 0x02645F75
		public AKRESULT? result; // 0x00
		public bool isPortal; // 0x08
		public ulong emitterId; // 0x10
		public ulong listenerId; // 0x18
		public float obstruction; // 0x20
		public float occlusion; // 0x24
	
		// Methods
		public static AudioDebugAPIObstructionCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EBDC0-0x00000001821EC1F0
	}

	public struct AudioDebugAPIGeometryInstanceCallMsg // TypeDefIndex: 86893
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.API_SPATIAL_CALL; // Metadata: 0x02645F76
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.API_SPATIAL; // Metadata: 0x02645F77
		public const EAudioDebugAPISpatialCallType TYPE = EAudioDebugAPISpatialCallType.GEOMETRY_INSTANCE; // Metadata: 0x02645F7F
		public AKRESULT? result; // 0x00
		public ulong instanceId; // 0x08
		public ulong geometryId; // 0x10
		public UnityEngine.Vector3 position; // 0x18
		public UnityEngine.Vector3 scale; // 0x24
		public Quaternion rotation; // 0x30
		public bool useReflectionAndDiffraction; // 0x40
	
		// Methods
		public static AudioDebugAPIGeometryInstanceCallMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821EB530-0x00000001821EB9B0
	}

	public struct AudioDebugEventEndMsg // TypeDefIndex: 86894
	{
		// Fields
		public const EAudioDebugMsgCategory CATEGORY = EAudioDebugMsgCategory.EVENT_CALLBACK; // Metadata: 0x02645F80
		public const EAudioDebugMsgFilter FILTER = EAudioDebugMsgFilter.NONE | EAudioDebugMsgFilter.EVENT_CALLBACK; // Metadata: 0x02645F81
		public const int TYPE = 0; // Metadata: 0x02645F89
		public uint eventId; // 0x00
		public ulong emitterId; // 0x08
		public uint playingId; // 0x10
		public uint internalPlayingId; // 0x14
	
		// Methods
		public static AudioDebugEventEndMsg FromMessage([IsReadOnly] in AudioDebugMsgItem message); // 0x00000001821F0680-0x00000001821F0780
	}

	public struct AudioDebugLevelScriptEventMsg // TypeDefIndex: 86895
	{
		// Fields
		public int eventId; // 0x00
		public string levelScriptNode; // 0x08
	}

	[Flags]
	public enum AudioCallbackType // TypeDefIndex: 86896
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

	public enum AudioLargeType : byte // TypeDefIndex: 86897
	{
		Sum = 0,
		Nearest = 1,
		Single = 2
	}

	[Flags]
	public enum AudioPlayableActions // TypeDefIndex: 86898
	{
		None = 0,
		Playback = 1,
		Stop = 2,
		Seek = 4
	}

	public enum AudioEventType // TypeDefIndex: 86899
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

	public enum AudioMixDownMode // TypeDefIndex: 86900
	{
		Direct = 0,
		ForceToMono = 1
	}

	public enum AudioMasteringSuiteMode // TypeDefIndex: 86901
	{
		Headphone = 1,
		TV = 2,
		HomeCinema = 3,
		SoundBar = 4,
		Speaker = 5,
		DevMode = 99
	}

	public enum AudioChannelConfigType : uint // TypeDefIndex: 86902
	{
		Anonymous = 0,
		Standard = 1,
		Ambisonic = 2,
		Objects = 3,
		UseDeviceMain = 14,
		UseDevicePassthrough = 15
	}

	public enum AudioCodec : uint // TypeDefIndex: 86903
	{
		PCM = 1,
		ADPCM = 2,
		VORBIS = 4,
		ATRAC9 = 12,
		OPUS_WEM = 20
	}

	public enum AudioChannelMask : uint // TypeDefIndex: 86904
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
	public enum AudioLogChannel // TypeDefIndex: 86905
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

	public static class AudioLogger // TypeDefIndex: 86906
	{
		// Fields
		public static AudioLogChannel s_enabledChannels; // 0x00
	
		// Constructors
		static AudioLogger(); // 0x0000000187220BB0-0x0000000187220BF0
	
		// Methods
		public static bool IsChannelEnabled(AudioLogChannel channel); // 0x0000000184F892A0-0x0000000184F89300
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void EnableChannel(AudioLogChannel channel); // 0x00000001887EA084-0x00000001887EA108
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void DisableChannel(AudioLogChannel channel); // 0x00000001887E9FFC-0x00000001887EA084
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void SetChannels(AudioLogChannel channel); // 0x00000001887EA2D0-0x00000001887EA354
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log(AudioLogChannel channel, string msg); // 0x00000001887EA228-0x00000001887EA2D0
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
		[Conditional("ENABLE_LOG")]
		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(AudioLogChannel channel, string msg); // 0x00000001887EA198-0x00000001887EA228
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
		public static void LogError(AudioLogChannel channel, string msg); // 0x00000001887EA108-0x00000001887EA198
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
		private static void _DoLog(AudioLogChannel channel, string msg); // 0x00000001887EA4DC-0x00000001887EA58C
		private static void _DoLogWarning(AudioLogChannel channel, string msg); // 0x00000001887EA42C-0x00000001887EA4DC
		private static void _DoLogError(AudioLogChannel channel, string msg); // 0x00000001887EA354-0x00000001887EA42C
	}

	public static class AudioAcousticUtil // TypeDefIndex: 86907
	{
		// Fields
		private const float SOUND_SPEED = 343f; // Metadata: 0x026460DB
	
		// Methods
		public static float RT60DecayTime(float volume, float surfaceArea, float absorptionFactor); // 0x00000001887E4928-0x00000001887E4998
		public static float PreDelayTime(UnityEngine.Vector3 size); // 0x00000001887E48BC-0x00000001887E4928
		public static float CriticalDistance(float volume, float rt60, float gamma = 1f /* Metadata: 0x026460D7 */); // 0x00000001887E480C-0x00000001887E4864
		public static float ReverbIntensity(UnityEngine.Vector3 size); // 0x00000001887E4998-0x00000001887E4A20
		public static float ErIntensity(UnityEngine.Vector3 size); // 0x00000001887E4864-0x00000001887E48BC
	}

	internal static class AudioActionQueueHelper // TypeDefIndex: 86911
	{
		// Fields
		private static Queue<FExecuteAction> s_executeActionQueue; // 0x00
		private static Queue<FRTPCAction> s_rtpcActionQueue; // 0x08
		private static Queue<FSeekAction> s_seekActionQueue; // 0x10
		private const int QUEUE_LIFETIME_FRAME = 10; // Metadata: 0x026460DF
	
		// Nested types
		private struct FExecuteAction // TypeDefIndex: 86908
		{
			// Fields
			public int queuedFrame; // 0x00
			public uint playingId; // 0x04
			public AkActionOnEventType actionType; // 0x08
			public int durationMs; // 0x0C
		}
	
		private struct FRTPCAction // TypeDefIndex: 86909
		{
			// Fields
			public int queuedFrame; // 0x00
			public uint playingId; // 0x04
			public uint rtpcId; // 0x08
			public float targetValue; // 0x0C
			public int durationMs; // 0x10
		}
	
		private struct FSeekAction // TypeDefIndex: 86910
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
		static AudioActionQueueHelper(); // 0x0000000186F80780-0x0000000186F80950
	
		// Methods
		internal static void QueueExecuteAction(uint playingId, AkActionOnEventType actionType, int durationMs); // 0x0000000185A7D0C0-0x0000000185A7D180
		internal static void QueueRtpcAction(uint playingId, uint rtpcId, float targetValue, int durationMs); // 0x00000001887E4B1C-0x00000001887E4C2C
		internal static void QueueSeekAction(uint playingId, uint eventId, ulong audioObjectId, int timeMs, bool toNearestMarker); // 0x00000001887E4C2C-0x00000001887E4D80
		internal static void ConsumeQueue(); // 0x000000018577ED70-0x000000018577F0D0
		internal static void ClearQueue(); // 0x00000001887E4A20-0x00000001887E4B1C
		private static void _ConsumeExecute(int currFrame); // 0x000000018577F220-0x000000018577F400
		private static void _ConsumeRtpc(int currFrame); // 0x000000018577F0D0-0x000000018577F150
		private static void _ConsumeSeek(int currFrame); // 0x000000018577F150-0x000000018577F220
	}

	internal static class AudioAssetCache // TypeDefIndex: 86915
	{
		// Fields
		private static Dictionary<uint, LinkedListNode<EventCacheInfo>> s_lruUsingEvents; // 0x00
		private static Cache s_cachedEvents; // 0x08
		private static HashSet<uint> s_pinnedEvents; // 0x10
		private const int INIT_PREPARE_CAP = 128; // Metadata: 0x026460E0
		private static ObjectPool<LinkedListNode<EventCacheInfo>> s_nodePool; // 0x18
	
		// Nested types
		internal class EventCacheInfo // TypeDefIndex: 86912
		{
			// Fields
			public uint id; // 0x10
			public uint refCount; // 0x14
	
			// Constructors
			public EventCacheInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class Cache // TypeDefIndex: 86913
		{
			// Fields
			private readonly LinkedList<EventCacheInfo> m_lruCachedEventsList; // 0x10
			private readonly Dictionary<uint, LinkedListNode<EventCacheInfo>> m_lruCachedEvents; // 0x18
	
			// Properties
			public LinkedList<EventCacheInfo> lruCachedEventsList { get; } // 0x00000001887EB2D0-0x00000001887EB310 
			public int count { get; } // 0x0000000186FC4F60-0x0000000186FC5030 
	
			// Constructors
			public Cache(); // 0x0000000186E55A90-0x0000000186E55B50
	
			// Methods
			public void Clear(); // 0x00000001862F9FC0-0x00000001862FA050
			public uint RemoveFirst(out LinkedListNode<EventCacheInfo> outNode); // 0x0000000186119420-0x00000001861194C0
			public bool Remove(uint inId, out LinkedListNode<EventCacheInfo> outNode); // 0x000000018577D9F0-0x000000018577DA70
			public void AddLast(ref LinkedListNode<EventCacheInfo> node); // 0x000000018577DA70-0x000000018577DB60
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86914
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<LinkedListNode<EventCacheInfo>> __9__7_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E4580-0x00000001871E45E0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal LinkedListNode<EventCacheInfo> _Reset_b__7_0(); // 0x0000000186668050-0x00000001866680A0
		}
	
		// Constructors
		static AudioAssetCache(); // 0x0000000186E55940-0x0000000186E55A90
	
		// Methods
		internal static void Reset(); // 0x00000001862F9D70-0x00000001862F9FC0
		internal static void PinEvent(uint inId); // 0x0000000186BD2910-0x0000000186BD29B0
		internal static void UnpinEvent(uint inId); // 0x0000000186E35DC0-0x0000000186E35E60
		internal static void GetAllUsingAssetsAndRelease(ref List<uint> allIds); // 0x00000001887E85BC-0x00000001887E891C
		internal static uint GetLeastActiveAssetAndUncache(); // 0x0000000186119350-0x0000000186119420
		internal static int GetCachedAssetCount(); // 0x0000000186FC4ED0-0x0000000186FC4F60
		internal static bool ActivateAsset(uint inId); // 0x000000018577CEB0-0x000000018577D1E0
		internal static void DeactivateAsset(uint inId); // 0x000000018577C950-0x000000018577CC10
		internal static void ForceReleaseCachedAsset(uint inId); // 0x0000000186119540-0x0000000186119630
		[Conditional("BEYOND_DEBUG")]
		private static void _NotifyDebugger(); // 0x00000001887E8954-0x00000001887E8984
		[Conditional("BEYOND_DEBUG")]
		private static void _NotifyDebuggerCacheHit(bool isHit); // 0x00000001887E891C-0x00000001887E8954
		[Conditional("BEYOND_DEBUG")]
		private static void _ResetDebugger(); // 0x00000001887E8A10-0x00000001887E8A40
		[Conditional("BEYOND_DEBUG")]
		private static void _PinnedEventLeakDetect(); // 0x00000001887E8984-0x00000001887E8A10
	}

	internal static class AudioAssetHelper // TypeDefIndex: 86918
	{
		// Fields
		private static ulong s_memoryBudget; // 0x00
		private const float FACTOR_B_TO_MB = 9.5367E-07f; // Metadata: 0x026460E4
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
		private static bool isGcProcessing { get; } // 0x000000018577BE30-0x000000018577BF10 
	
		// Nested types
		private struct FOnBankLoadedDoPrepareEventPayload // TypeDefIndex: 86916
		{
			// Fields
			public uint id; // 0x00
			public AkCallbackManager.BankCallback callback; // 0x08
			public object cookie; // 0x10
		}
	
		private struct FPendingLoadRequest // TypeDefIndex: 86917
		{
			// Fields
			public uint id; // 0x00
			public FOnBankLoadedDoPrepareEventPayload payload; // 0x08
		}
	
		// Constructors
		static AudioAssetHelper(); // 0x0000000186B050E0-0x0000000186B054A0
	
		// Methods
		internal static void SetMemoryBudget(ulong inBudgetBytes, ushort inGcCount = 10 /* Metadata: 0x026460E2 */); // 0x0000000186EDF830-0x0000000186EDF8D0
		internal static bool HasPreparingEvents(); // 0x00000001887E8A40-0x00000001887E8AD8
		internal static void UnPrepareAllEventsSync(); // 0x00000001887E8B20-0x00000001887E8EE0
		[IFixIgnore]
		internal static void LoadEventAsync(uint inId, AkCallbackManager.BankCallback callback = null, object cookie = null); // 0x000000018577B5B0-0x000000018577BE30
		private static void _TryConsumePendingLoadRequests(); // 0x000000018661D500-0x000000018661D610
		private static void _ConsumePendingLoadRequests(); // 0x000000018577BF90-0x000000018577C060
		private static void _DoLoadEventAsync(uint inId, FOnBankLoadedDoPrepareEventPayload payload); // 0x000000018577CC10-0x000000018577CEB0
		internal static void PinEvent(uint inId); // 0x00000001887E8AD8-0x00000001887E8B20
		internal static void UnpinEvent(uint inId); // 0x00000001887E8F28-0x00000001887E8F70
		internal static void ResetStaticFields(); // 0x00000001862FABF0-0x00000001862FAD10
		internal static void ReleaseAllCachedEventsSync(); // 0x000000018577AAF0-0x000000018577ABD0
		private static void _TryGC(); // 0x00000001887E9008-0x00000001887E9078
		private static void _DoGc(int gcCount); // 0x0000000186118B40-0x0000000186118D10
		internal static void UnloadEvent(uint inId); // 0x00000001887E8EE0-0x00000001887E8F28
		private static void _OnUnpreparedDoUnloadBank(uint inId, IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, object inCookie); // 0x0000000186118D10-0x0000000186118DC0
		private static void _OnDoneUnloadBank(uint inId, IntPtr inInMemoryBankPtr, AKRESULT inLoadResult, object inCookie); // 0x000000018661D4A0-0x000000018661D500
		private static void _OnBankLoadedDoPrepareEvent(uint inId, IntPtr _, AKRESULT inLoadResult, object __); // 0x0000000186118E40-0x0000000186118F90
		private static void _OnDonePrepareEvent(uint inId, IntPtr _, AKRESULT __, object ___); // 0x00000001861194C0-0x0000000186119540
		private static void _TryDequeueAndInvokeCallback(); // 0x000000018577D1E0-0x000000018577D9F0
		[Conditional("BEYOND_DEBUG")]
		private static void _RemoveLoadingDebug(uint inId); // 0x00000001887E8FD4-0x00000001887E9008
		[Conditional("BEYOND_DEBUG")]
		private static void _AddLoadingDebug(uint inId); // 0x00000001887E8F70-0x00000001887E8FA4
		[Conditional("BEYOND_DEBUG")]
		private static void _ClearLoadingDebug(); // 0x00000001887E8FA4-0x00000001887E8FD4
	}

	internal static class AudioCallbackMessageParser // TypeDefIndex: 86919
	{
		// Fields
		private static readonly AkCallbackManager.MonitoringCallback s_onMonitoringCallback; // 0x00
	
		// Constructors
		static AudioCallbackMessageParser(); // 0x0000000186FC25A0-0x0000000186FC2640
	
		// Methods
		internal static void Set(); // 0x00000001862FA990-0x00000001862FAA40
		private static void _OnMonitoringCallback(AkMonitorErrorCode inErrorCode, AkMonitorErrorLevel inErrorLevel, uint inPlayingID, ulong inGameObjID, string inMsg); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class AudioDebugInfoContainer // TypeDefIndex: 86920
	{
		// Methods
		[Conditional("BEYOND_DEBUG")]
		public static void SetAudioObjectName(ulong audioObjId, string name); // 0x00000001887E9ABC-0x00000001887E9AF4
		[Conditional("BEYOND_DEBUG")]
		public static void RemoveAudioObjectName(ulong audioObjId); // 0x00000001887E9A88-0x00000001887E9ABC
		public static string GetAudioObjectName(ulong audioObjId); // 0x00000001887E99E0-0x00000001887E9A18
		public static string ForceGetEventName(uint eventId); // 0x00000001887E9948-0x00000001887E9994
		public static string ForceGetRtpcName(uint rtpcId); // 0x00000001887E9994-0x00000001887E99E0
		public static string GetRtpcName(uint rtpcId); // 0x00000001887E9A50-0x00000001887E9A88
		public static string GetEventName(uint eventId); // 0x00000001887E9A18-0x00000001887E9A50
	}

	public static class AudioHashGenerator // TypeDefIndex: 86921
	{
		// Fields
		public const short MAX_STRING_LENGTH = 256; // Metadata: 0x026460E8
		private const uint PRIME32 = 16777619; // Metadata: 0x026460EA
		private const uint OFFSET_BASIS32 = 2166136261; // Metadata: 0x026460EE
	
		// Methods
		[IDTag(0)]
		public static uint Compute(string inStr); // 0x00000001850C11F0-0x00000001850C12C0
		[IDTag(2)]
		public static uint Compute(IntPtr inCharPtr); // 0x0000000184F85CB0-0x0000000184F85D00
		[IDTag(1)]
		public static uint Compute(ReadOnlySpan<byte> buffer); // 0x0000000184F89340-0x0000000184F893C0
		[IDTag(3)]
		public static uint Compute(string inStr1, string inStr2); // 0x00000001865A9760-0x00000001865A98A0
		[IDTag(4)]
		public static uint Compute(params string[] strings); // 0x00000001887E9B98-0x00000001887E9C8C
		private static uint _GetUintFromCharToLower(char c); // 0x00000001887E9C8C-0x00000001887E9C9C
	}

	public static class AudioMemoryMonitor // TypeDefIndex: 86924
	{
		// Fields
		private static AkMemCategroyStats s_categoryStats; // 0x00
		private static bool s_monitorInited; // 0x08
	
		// Nested types
		public struct FGlobalMemoryStats // TypeDefIndex: 86922
		{
			// Fields
			public ulong used; // 0x00
			public ulong reserved; // 0x08
		}
	
		public struct FExtraMemoryStats // TypeDefIndex: 86923
		{
			// Fields
			public ulong active; // 0x00
			public ulong mapped; // 0x08
			public ulong retained; // 0x10
			public ulong allocated; // 0x18
		}
	
		// Methods
		internal static void Init(); // 0x00000001862FA860-0x00000001862FA910
		internal static void Release(); // 0x00000001887EA788-0x00000001887EA814
		internal static bool IsValid(); // 0x00000001887EA750-0x00000001887EA788
		internal static ulong GetUsedMemoryUnsafe(); // 0x00000001887EA6B0-0x00000001887EA6F0
		internal static ulong GetUsedMemory(); // 0x00000001887EA6F0-0x00000001887EA750
		public static FGlobalMemoryStats GetGlobalMemoryStats(); // 0x0000000186A81F90-0x0000000186A82010
		public static FExtraMemoryStats GetExtraMemoryStats(); // 0x00000001887EA58C-0x00000001887EA5E8
		internal static ulong GetUsedMemoryByCategory(AkMemID memCategory); // 0x00000001887EA5E8-0x00000001887EA6B0
	}

	public static class AudioUIUtil // TypeDefIndex: 86926
	{
		// Fields
		private static ushort s_fullScreenCounter; // 0x00
	
		// Nested types
		[Flags]
		public enum UIAudioType // TypeDefIndex: 86925
		{
			None = 0,
			FullScreen = 1,
			Tips = 2
		}
	
		// Methods
		public static void Init(); // 0x000000018668FB30-0x000000018668FC00
		public static void Release(); // 0x00000001887EABA0-0x00000001887EAC4C
		[IDTag(0)]
		public static uint PostUIEvent(string eventName, GameObject uiGameObject); // 0x0000000185035810-0x00000001850358E0
		[IDTag(1)]
		public static uint PostUIEvent(string eventName, string objPath); // 0x00000001887EAB14-0x00000001887EABA0
		public static void OnUIPanelClose(UIAudioType uiAudioType); // 0x0000000185573DA0-0x0000000185573E20
		public static void OnUIPanelOpen(UIAudioType uiAudioType); // 0x00000001862E60C0-0x00000001862E61E0
	}

	internal static class AudioVFSLoader // TypeDefIndex: 86928
	{
		// Fields
		private const string PCK_SUFFIX = ".pck"; // Metadata: 0x026460F6
		private static VfsLoadedInfo s_loadedInitPckInfo; // 0x00
		private static VfsLoadedInfo s_loadedMainPckInfo; // 0x10
		private static VfsLoadedInfo s_loadedAuditPckInfo; // 0x20
		private static VfsLoadedInfo s_loadedLangPckInfo; // 0x30
		private static VfsLoadedInfo s_loadedHotfixPckInfo; // 0x40
		private static EVFSBlockType s_pendingLanguageBlock; // 0x50
		private static readonly FVFBlockChunkInfo[] s_emptyChunks; // 0x58
	
		// Nested types
		private struct VfsLoadedInfo // TypeDefIndex: 86927
		{
			// Fields
			public List<uint> loadedPcks; // 0x00
			public int loadedVersion; // 0x08
			public bool isLoaded; // 0x0C
	
			// Methods
			public static VfsLoadedInfo Create(); // 0x00000001862F9B20-0x00000001862F9C00
		}
	
		// Constructors
		static AudioVFSLoader(); // 0x0000000186BF9240-0x0000000186BF92C0
	
		// Methods
		internal static void UnloadAll(); // 0x00000001887EAF58-0x00000001887EB038
		internal static bool TryLoadInitPck(); // 0x000000018668FA70-0x000000018668FB30
		internal static bool TryLoadMainPck(); // 0x0000000186691D50-0x0000000186692970
		internal static bool TryLoadLanguagePck(string language); // 0x000000018668F8E0-0x000000018668F9E0
		private static bool _DoLoadLanguageAndHotfixPck(EVFSBlockType langBlockType); // 0x00000001866906C0-0x0000000186690840
		internal static void InitBasePaths(); // 0x00000001862F9170-0x00000001862F9B20
		private static bool _TryLoadPcksFromVfsInfo(VFBlockMainInfo vfsInfo, ref VfsLoadedInfo info); // 0x0000000186690840-0x0000000186690920
		private static IReadOnlyList<FVFBlockChunkInfo> _SplitChunksByTag(VFBlockMainInfo block, VFSFileTag tag, bool includeMatching); // 0x00000001821F19A0-0x00000001821F27C0
		private static bool _TryLoadPcksFromChunks(IReadOnlyList<FVFBlockChunkInfo> chunks, int version, ref VfsLoadedInfo info); // 0x0000000186692970-0x0000000186692A70
		private static bool _DoLoadPcksFromChunks(IReadOnlyList<FVFBlockChunkInfo> chunks, ref List<uint> loaded); // 0x0000000186690920-0x0000000186690EC0
		private static bool _DoLoadPcksFromVfs(VFBlockMainInfo vfs, ref List<uint> loaded); // 0x0000000186690EC0-0x00000001866912A0
		private static bool _DoLoadSinglePckFromVfs(FVFBlockFileInfo fileInfo, out uint loadedId); // 0x00000001866912A0-0x0000000186691430
		private static void _UnloadPcks(ref VfsLoadedInfo info); // 0x00000001866918F0-0x0000000186691CC0
		private static EVFSBlockType _GetVfsBlockTypeFromLanguage(string language); // 0x000000018668F9E0-0x000000018668FA70
		public static void LoadExtraPckFromPath(string path); // 0x00000001887EAC4C-0x00000001887EAF58
	}

	public class AudioVoiceUtil // TypeDefIndex: 86929
	{
		// Constructors
		public AudioVoiceUtil(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static bool TryGetVoiceData(string voiceStrId, out VoiceData voData, out int voiceId, string genderSuffix); // 0x0000000185C80750-0x0000000185C807E0
		public static bool GetVoDataFromVoId(int voId, out VoiceData voData); // 0x0000000185C28A70-0x0000000185C28B90
		public static int GetVoiceIdFromString(string strId); // 0x0000000185C807E0-0x0000000185C80870
		public static int GetVoiceIdFromStrings(string str1, string str2); // 0x00000001865A9700-0x00000001865A9760
		[IDTag(0)]
		private static void _HandleVoiceIdConflict(ref int voiceIntId, string voiceStrId); // 0x0000000185C80870-0x0000000185C809E0
		[IDTag(1)]
		private static void _HandleVoiceIdConflict(ref int voiceIntId, string voiceStrId1, string voiceStrId2); // 0x00000001865A98A0-0x00000001865A9950
	}
}

namespace Beyond.Audio.AudioPerformanceMonitor
{
	public class AudioProfiling // TypeDefIndex: 86932
	{
		// Nested types
		public static class AudioWwiseProfilingData // TypeDefIndex: 86931
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
			static AudioWwiseProfilingData(); // 0x00000001887EB038-0x00000001887EB194
		}
	
		// Constructors
		public AudioProfiling(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WwiseResourceMonitor : Singleton<WwiseResourceMonitor> // TypeDefIndex: 86933
	{
		// Fields
		private const float TIME_OF_SOUND_FRAME = 0.21333334f; // Metadata: 0x026460FB
		private const float MB_RATE = 9.536743E-07f; // Metadata: 0x026460FF
		private bool m_isActiveAkResourceMonitoring; // 0x10
		private WwiseResourceMonitorItem m_wwiseResourceMonitorData; // 0x14
	
		// Properties
		public bool isActiveAkResourceMonitoring { get; } // 0x00000001829D0800-0x00000001829D0810 
	
		// Constructors
		private WwiseResourceMonitor(); // 0x00000001887EFEEC-0x00000001887EFF14
	
		// Methods
		public static bool IsSupportMemoryMonitor(); // 0x00000001851A4410-0x00000001851A4420
		public void StartSoundEngineResourceMonitor(); // 0x00000001887EFED4-0x00000001887EFEE0
		public void StopSoundEngineResourceMonitor(); // 0x00000001887EFEE0-0x00000001887EFEEC
		public WwiseResourceMonitorItem SampleRawWwiseResource(); // 0x0000000187232EE0-0x0000000187232F10
	}

	[Serializable]
	public struct WwiseResourceMonitorItem // TypeDefIndex: 86934
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
	public static class AudioEditorAssetsLoader // TypeDefIndex: 86930
	{
		// Methods
		[Conditional("UNITY_EDITOR")]
		internal static void Init(); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		internal static void Release(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 86795
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 86796
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 86797
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 86798
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 86799
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 86800
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 86801
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 86794
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 86937
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x00000001887EFB98-0x00000001887EFBFC
	
		// Methods
		public ulong __Gen_Wrap_0(); // 0x00000001887EB7A4-0x00000001887EB840
		public uint __Gen_Wrap_1(uint P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7); // 0x00000001887EC170-0x00000001887EC2B8
		public uint __Gen_Wrap_2(object P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7); // 0x00000001887ECB88-0x00000001887ECCD0
		public void __Gen_Wrap_3(uint P0, IntPtr P1, AKRESULT P2, object P3); // 0x00000001887ED3DC-0x00000001887ED4D8
		public void __Gen_Wrap_4(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public IEnumerator __Gen_Wrap_5(object P0, object P1, object P2); // 0x00000001887EE07C-0x00000001887EE198
		public void __Gen_Wrap_6(in IList<uint> P0, in Action<object> P1, in object P2); // 0x00000001887EED2C-0x00000001887EEE48
		public void __Gen_Wrap_7(object P0, object P1, object P2); // 0x00000001887EF660-0x00000001887EF74C
		public uint __Gen_Wrap_8(AudioId P0); // 0x00000001887EF9C0-0x00000001887EFAB8
		public IEnumerator __Gen_Wrap_9(object P0); // 0x00000001887EFAB8-0x00000001887EFB98
		public void __Gen_Wrap_10(uint P0, uint P1, ulong P2); // 0x00000001887EB840-0x00000001887EB928
		public void __Gen_Wrap_11(object P0, object P1, ulong P2); // 0x00000001887EB928-0x00000001887EBA14
		public uint __Gen_Wrap_12(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public void __Gen_Wrap_13(uint P0, float P1, int P2); // 0x00000001887EBAD4-0x00000001887EBBBC
		public void __Gen_Wrap_14(object P0, float P1, int P2); // 0x00000001887EBBBC-0x00000001887EBCA8
		public void __Gen_Wrap_15(uint P0, float P1, ulong P2); // 0x00000001887EBCA8-0x00000001887EBD90
		public void __Gen_Wrap_16(object P0, float P1, ulong P2); // 0x00000001887EBD90-0x00000001887EBE7C
		public void __Gen_Wrap_17(uint P0, float P1, ulong P2, int P3); // 0x00000001887EBE7C-0x00000001887EBF78
		public void __Gen_Wrap_18(uint P0, uint P1, float P2, int P3); // 0x00000001887EBF78-0x00000001887EC074
		public void __Gen_Wrap_19(uint P0, float P1, uint P2, int P3); // 0x00000001887EC074-0x00000001887EC170
		public void __Gen_Wrap_20(uint P0, ulong P1, int P2); // 0x00000001887EC2B8-0x00000001887EC3A0
		public void __Gen_Wrap_21(object P0, ulong P1, int P2); // 0x00000001887EC3A0-0x00000001887EC488
		public void __Gen_Wrap_22(uint P0, uint P1, ulong P2, int P3, bool P4); // 0x00000001887EC488-0x00000001887EC598
		public void __Gen_Wrap_23(uint P0, ulong P1, int P2, bool P3, uint P4); // 0x00000001887EC598-0x00000001887EC6A8
		public void __Gen_Wrap_24(object P0, ulong P1, int P2, bool P3, uint P4); // 0x00000001887EC6A8-0x00000001887EC7B8
		public void __Gen_Wrap_25(object P0, int P1, bool P2, uint P3); // 0x00000001887EC7B8-0x00000001887EC8B4
		public void __Gen_Wrap_26(uint P0, int P1, bool P2, uint P3); // 0x00000001887EC8B4-0x00000001887EC9B0
		public bool __Gen_Wrap_27(uint P0, out int P1, bool P2); // 0x00000001887EC9B0-0x00000001887ECAC8
		public bool __Gen_Wrap_28(uint P0); // 0x00000001887ECAC8-0x00000001887ECB88
		public int __Gen_Wrap_29(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public int __Gen_Wrap_30(); // 0x00000001887ECCD0-0x00000001887ECD6C
		public uint __Gen_Wrap_31(object P0, out LinkedListNode<AudioAssetCache.EventCacheInfo> P1); // 0x00000001887ECD6C-0x00000001887ECE94
		public uint __Gen_Wrap_32(); // 0x00000001887ECCD0-0x00000001887ECD6C
		public bool __Gen_Wrap_33(); // 0x00000001887ECE94-0x00000001887ECF30
		public bool __Gen_Wrap_34(object P0, uint P1, out LinkedListNode<AudioAssetCache.EventCacheInfo> P2); // 0x00000001887ECF30-0x00000001887ED074
		public void __Gen_Wrap_35(); // 0x00000001887ED074-0x00000001887ED104
		public void __Gen_Wrap_36(uint P0, AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload P1); // 0x00000001887ED104-0x00000001887ED210
		public void __Gen_Wrap_37(int P0); // 0x00000001887DBA64-0x00000001887DBB14
		public AkPositionArray __Gen_Wrap_38(object P0); // 0x00000001887ED210-0x00000001887ED2F0
		public void __Gen_Wrap_39(ulong P0, object P1, AudioLargeType P2); // 0x00000001887ED2F0-0x00000001887ED3DC
		public void __Gen_Wrap_40(ulong P0); // 0x00000001887ED4D8-0x00000001887ED58C
		public void __Gen_Wrap_41(ulong P0, ulong P1); // 0x00000001887ED58C-0x00000001887ED65C
		public bool __Gen_Wrap_42(uint P0, out uint P1); // 0x00000001887ED65C-0x00000001887ED758
		public bool __Gen_Wrap_43(object P0); // 0x00000001822262C0-0x0000000182226590
		public EVFSBlockType __Gen_Wrap_44(object P0); // 0x0000000182226590-0x0000000182226850
		public void __Gen_Wrap_45(ref AudioVFSLoader.VfsLoadedInfo P0); // 0x0000000182226850-0x0000000182227430
		public bool __Gen_Wrap_46(FVFBlockFileInfo P0, out uint P1); // 0x0000000182227430-0x0000000182227A30
		public bool __Gen_Wrap_47(object P0, ref List<uint> P1); // 0x0000000182227A30-0x0000000182228500
		public bool __Gen_Wrap_48(object P0, ref AudioVFSLoader.VfsLoadedInfo P1); // 0x0000000182228500-0x00000001822291E0
		public bool __Gen_Wrap_49(EVFSBlockType P0); // 0x00000001822291E0-0x00000001822293E0
		public void __Gen_Wrap_50(AudioEngineInitSetting P0); // 0x00000001887ED80C-0x00000001887ED8F8
		public LinkedListNode<AudioAssetCache.EventCacheInfo> __Gen_Wrap_51(); // 0x00000001887ED8F8-0x00000001887ED9B4
		public AudioVFSLoader.VfsLoadedInfo __Gen_Wrap_52(); // 0x00000001887ED9B4-0x00000001887EDA94
		public void __Gen_Wrap_53(ref List<uint> P0); // 0x00000001887EDA94-0x00000001887EDB90
		public void __Gen_Wrap_54(bool P0); // 0x00000001887EDB90-0x00000001887EDC44
		public void __Gen_Wrap_55(object P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8); // 0x00000001887EDC44-0x00000001887EDD90
		public void __Gen_Wrap_56(object P0, AkCallbackType P1, object P2); // 0x00000001887EDD90-0x00000001887EDE78
		public uint __Gen_Wrap_57(uint P0, ulong P1, AudioCallbackType P2, object P3, object P4); // 0x00000001887EDE78-0x00000001887EDF94
		public void __Gen_Wrap_58(uint P0, AkActionOnEventType P1, int P2); // 0x00000001887EDF94-0x00000001887EE07C
		public void __Gen_Wrap_59(AkActionOnEventType P0, uint P1, int P2); // 0x00000001887EDF94-0x00000001887EE07C
		public AkResourceMonitorDataSummary __Gen_Wrap_60(); // 0x00000001887EE198-0x00000001887EE254
		public AudioMemoryMonitor.FGlobalMemoryStats __Gen_Wrap_61(); // 0x00000001887EE254-0x00000001887EE334
		public AudioMemoryMonitor.FExtraMemoryStats __Gen_Wrap_62(); // 0x00000001887EE334-0x00000001887EE41C
		public void __Gen_Wrap_63(ulong P0, float P1, float P2); // 0x00000001887EE41C-0x00000001887EE508
		public bool __Gen_Wrap_64(ulong P0, object P1, object P2, object P3, object P4, bool P5, bool P6); // 0x00000001887EE508-0x00000001887EE640
		public bool __Gen_Wrap_65(ulong P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, Quaternion P3, ulong P4, bool P5); // 0x00000001887EE640-0x00000001887EE7EC
		public bool __Gen_Wrap_66(ulong P0, AudioRoomData P1, ulong P2, object P3); // 0x00000001887EE7EC-0x00000001887EE940
		public bool __Gen_Wrap_67(ulong P0, ulong P1, ulong P2, UnityEngine.Vector3 P3, Quaternion P4, UnityEngine.Vector3 P5, bool P6, object P7); // 0x00000001887EE940-0x00000001887EEB14
		public AudioAdapter.PayloadPostEvent __Gen_Wrap_68(); // 0x00000001887EEB14-0x00000001887EEBD0
		public bool __Gen_Wrap_69(out AudioChannelMask P0, out uint P1, out AudioChannelConfigType P2); // 0x00000001887EEBD0-0x00000001887EED2C
		public bool __Gen_Wrap_70(object P0, uint P1, uint P2, uint P3, out ulong P4); // 0x00000001887EEE48-0x00000001887EEF84
		public bool __Gen_Wrap_71(object P0, uint P1, out ulong P2); // 0x00000001887EEF84-0x00000001887EF09C
		public ulong __Gen_Wrap_72(object P0, uint P1); // 0x00000001887EF09C-0x00000001887EF178
		public bool __Gen_Wrap_73(ulong P0); // 0x00000001887EF178-0x00000001887EF238
		public bool __Gen_Wrap_74(bool P0); // 0x00000001887EF238-0x00000001887EF2F8
		public void __Gen_Wrap_75(ulong P0, uint P1, uint P2); // 0x00000001887EF2F8-0x00000001887EF3E0
		public uint __Gen_Wrap_76(int P0); // 0x00000001887EF3E0-0x00000001887EF4A0
		public AsyncLoadBankTask __Gen_Wrap_77(object P0); // 0x00000001887EF4A0-0x00000001887EF580
		public object __Gen_Wrap_78(object P0); // 0x00000001887EF580-0x00000001887EF660
		public IReadOnlyList<FVFBlockChunkInfo> __Gen_Wrap_79(object P0, VFSFileTag P1, bool P2); // 0x00000001822293E0-0x000000018222A0D0
		public bool __Gen_Wrap_80(object P0, int P1, ref AudioVFSLoader.VfsLoadedInfo P2); // 0x00000001887EF74C-0x00000001887EF8C0
		public BankHandle __Gen_Wrap_81(object P0, object P1); // 0x00000001887EF8C0-0x00000001887EF9C0
		public void __Gen_Wrap_82(out List<uint> P0); // 0x000000018222A0D0-0x000000018222A9C0
		public string __Gen_Wrap_83(ref AudioId P0); // 0x000000018222A9C0-0x000000018222B860
		public int __Gen_Wrap_84(AudioId P0); // 0x000000018222B860-0x000000018222BE00
		public AudioId __Gen_Wrap_85(uint P0); // 0x000000018222BE00-0x000000018222C610
		public AudioId __Gen_Wrap_86(int P0); // 0x000000018222C610-0x000000018222CE20
		public AudioId __Gen_Wrap_87(object P0); // 0x000000018222CE20-0x000000018222D6E0
		public uint[] __Gen_Wrap_88(object P0); // 0x000000018222D6E0-0x000000018222E000
		public uint __Gen_Wrap_89(ref AudioState P0); // 0x000000018222E000-0x000000018222EBA0
		public bool __Gen_Wrap_90(ref AudioState P0, AudioState P1); // 0x000000018222EBA0-0x000000018222F840
		public bool __Gen_Wrap_91(ref AudioState P0, object P1); // 0x000000018222F840-0x00000001822304E0
		public int __Gen_Wrap_92(ref AudioState P0); // 0x00000001822304E0-0x0000000182231080
		public AudioDurationCallbackInfo __Gen_Wrap_93(ref AudioCallbackInfo P0); // 0x0000000182231080-0x0000000182231FB0
		public void __Gen_Wrap_94(object P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3); // 0x0000000182231FB0-0x0000000182232810
		public EAudioDebugMsgFilter __Gen_Wrap_95(); // 0x00000001821F27C0-0x00000001821F2990
		public bool __Gen_Wrap_96(EAudioDebugMsgFilter P0); // 0x0000000182232810-0x0000000182232A10
		public void __Gen_Wrap_97(EAudioDebugMsgFilter P0, bool P1); // 0x0000000182232A10-0x0000000182232C20
		public void __Gen_Wrap_98(EAudioDebugMsgFilter P0); // 0x0000000182232C20-0x0000000182232E10
		public AudioDebugMsgItem[] __Gen_Wrap_99(); // 0x0000000182232E10-0x0000000182233630
		public long __Gen_Wrap_100(); // 0x00000001821F27C0-0x00000001821F2990
		public void __Gen_Wrap_101(EAudioDebugMsgLevel P0, object P1, object P2, int P3); // 0x00000001821F2990-0x00000001821F2D50
		public void __Gen_Wrap_102(in AudioDebugAPIEmitterCallMsg P0, AKRESULT? P1); // 0x00000001821F2D50-0x00000001821F3690
		public void __Gen_Wrap_103(in AudioDebugAPIEmitterPositionCallMsg P0, AKRESULT? P1); // 0x00000001821F3690-0x00000001821F3FE0
		public void __Gen_Wrap_104(in AudioDebugAPIEmitterMultiplePositionsCallMsg P0, AKRESULT? P1); // 0x00000001821F3FE0-0x00000001821F4920
		public void __Gen_Wrap_105(ulong P0, ushort P1, AkMultiPositionType P2, AKRESULT P3); // 0x00000001821F4920-0x00000001821F4B60
		public void __Gen_Wrap_106(EAudioDebugAPIEngineLifecycleOperation P0, bool P1, bool? P2); // 0x00000001821F4B60-0x00000001821F5130
		public void __Gen_Wrap_107(in AudioDebugAPIEngineCallMsg P0, AKRESULT? P1); // 0x00000001821F5130-0x00000001821F5A60
		public void __Gen_Wrap_108(AudioDebugAPIRenderAudioCallMsg P0, AKRESULT? P1); // 0x00000001821F5A60-0x00000001821F6370
		public void __Gen_Wrap_109(in AudioDebugAPIListenerCallMsg P0, AKRESULT? P1); // 0x00000001821F6370-0x00000001821F6CA0
		public void __Gen_Wrap_110(in AudioDebugAPIScePadOutputDeviceMappingMsg P0); // 0x00000001821F6CA0-0x00000001821F7250
		public void __Gen_Wrap_111(in AudioDebugAPIOutputDeviceCallMsg P0, AKRESULT? P1); // 0x00000001821F7250-0x00000001821F7BA0
		public void __Gen_Wrap_112(EAudioDebugAPIOutputDeviceOperation P0, ulong P1, uint P2, AKRESULT? P3, uint? P4, uint? P5, uint? P6); // 0x00000001821F7BA0-0x00000001821F86E0
		public void __Gen_Wrap_113(in AudioDebugAPIOutputDeviceEffectCallMsg P0, AKRESULT? P1); // 0x00000001821F86E0-0x00000001821F9020
		public void __Gen_Wrap_114(in AudioDebugAPIAudioSessionCallMsg P0); // 0x00000001821F9020-0x00000001821F95D0
		public void __Gen_Wrap_115(in AudioDebugAPIEventCallMsg P0); // 0x00000001821F95D0-0x00000001821F9B80
		public void __Gen_Wrap_116(EAudioDebugMsgLevel P0, int P1, long P2); // 0x00000001821F9B80-0x00000001821F9DA0
		public void __Gen_Wrap_117(in AudioDebugAPIStateCallMsg P0, AKRESULT? P1); // 0x00000001821F9DA0-0x00000001821FA6D0
		public void __Gen_Wrap_118(EAudioDebugMsgLevel P0, int P1, int P2); // 0x00000001821FA6D0-0x00000001821FA8F0
		public void __Gen_Wrap_119(in AudioDebugAPISwitchCallMsg P0, AKRESULT? P1); // 0x00000001821FA8F0-0x00000001821FB230
		public void __Gen_Wrap_120(EAudioDebugMsgLevel P0, int P1, int P2, long P3); // 0x00000001821FB230-0x00000001821FB470
		public void __Gen_Wrap_121(in AudioDebugAPIEventActionCallMsg P0); // 0x00000001821FB470-0x00000001821FBA20
		public void __Gen_Wrap_122(in AudioDebugAPIEventSeekCallMsg P0, AKRESULT? P1); // 0x00000001821FBA20-0x00000001821FC360
		public void __Gen_Wrap_123(in AudioDebugAPIRtpcCallMsg P0, AKRESULT? P1); // 0x00000001821FC360-0x00000001821FCCB0
		public void __Gen_Wrap_124(EAudioDebugMsgLevel P0, int P1, float P2, int P3, long P4); // 0x00000001821FCCB0-0x00000001821FCF00
		public void __Gen_Wrap_125(in AudioDebugAPIResourcePathCallMsg P0); // 0x00000001821FCF00-0x00000001821FD4B0
		public void __Gen_Wrap_126(in AudioDebugAPIFilePackageCallMsg P0); // 0x00000001821FD4B0-0x00000001821FDA60
		public void __Gen_Wrap_127(in AudioDebugAPIBankCallMsg P0); // 0x00000001821FDA60-0x00000001821FE010
		public void __Gen_Wrap_128(in AudioDebugAPIPrepareEventCallMsg P0); // 0x00000001821FE010-0x00000001821FE5C0
		public void __Gen_Wrap_129(in AudioDebugAPIScePadDeviceCallMsg P0); // 0x00000001821FE5C0-0x00000001821FEB70
		public void __Gen_Wrap_130(in AudioDebugAPIScePadControllerInfoMsg P0); // 0x00000001821FEB70-0x00000001821FF130
		public void __Gen_Wrap_131(in AudioDebugAPIScePadAudioCallMsg P0); // 0x00000001821FF130-0x00000001821FF6E0
		public void __Gen_Wrap_132(in AudioDebugAPIScePadLightBarCallMsg P0); // 0x00000001821FF6E0-0x00000001821FFC80
		public void __Gen_Wrap_133(in AudioDebugAPIScePadTriggerCallMsg P0); // 0x00000001821FFC80-0x0000000182200230
		public void __Gen_Wrap_134(in AudioDebugAPISpatialSettingsCallMsg P0, AKRESULT? P1); // 0x0000000182200230-0x0000000182200B60
		public void __Gen_Wrap_135(in AudioDebugAPIGeometryCallMsg P0, AKRESULT? P1); // 0x0000000182200B60-0x00000001822014B0
		public void __Gen_Wrap_136(in AudioDebugAPIRoomCallMsg P0, AKRESULT? P1); // 0x00000001822014B0-0x0000000182201E20
		public void __Gen_Wrap_137(in AudioDebugAPIPortalCallMsg P0, AKRESULT? P1); // 0x0000000182201E20-0x0000000182202790
		public void __Gen_Wrap_138(in AudioDebugAPIReverbZoneCallMsg P0, AKRESULT? P1); // 0x0000000182202790-0x00000001822030C0
		public void __Gen_Wrap_139(in AudioDebugAPIRemoveSpatialObjectCallMsg P0, AKRESULT? P1); // 0x00000001822030C0-0x0000000182203A00
		public void __Gen_Wrap_140(in AudioDebugAPIObstructionCallMsg P0, AKRESULT? P1); // 0x0000000182203A00-0x0000000182204340
		public void __Gen_Wrap_141(in AudioDebugAPIGeometryInstanceCallMsg P0, AKRESULT? P1); // 0x0000000182204340-0x0000000182204CA0
		public void __Gen_Wrap_142(uint P0, ulong P1, uint P2, uint P3); // 0x0000000182204CA0-0x0000000182204EE0
		public void __Gen_Wrap_143(EAudioDebugMsgLevel P0, int P1, object P2); // 0x0000000182204EE0-0x00000001822051D0
		public AudioDebugLevelScriptEventMsg __Gen_Wrap_144(ref AudioDebugMsgItem P0); // 0x00000001822051D0-0x0000000182206260
		public AudioDebugAPIEmitterCallMsg __Gen_Wrap_145(in AudioDebugMsgItem P0); // 0x0000000182206260-0x0000000182206E80
		public AudioDebugAPIEmitterPositionCallMsg __Gen_Wrap_146(in AudioDebugMsgItem P0); // 0x0000000182206E80-0x0000000182207AB0
		public AudioDebugAPIEmitterMultiplePositionsCallMsg __Gen_Wrap_147(in AudioDebugMsgItem P0); // 0x0000000182207AB0-0x00000001822086D0
		public AudioDebugAPIEngineCallMsg __Gen_Wrap_148(in AudioDebugMsgItem P0); // 0x00000001822086D0-0x00000001822092F0
		public AudioDebugAPIEngineLifecycleMsg __Gen_Wrap_149(in AudioDebugMsgItem P0); // 0x00000001822092F0-0x0000000182209EF0
		public AudioDebugAPIRenderAudioCallMsg __Gen_Wrap_150(in AudioDebugMsgItem P0); // 0x0000000182209EF0-0x000000018220AAF0
		public AudioDebugAPIListenerCallMsg __Gen_Wrap_151(in AudioDebugMsgItem P0); // 0x000000018220AAF0-0x000000018220B710
		public AudioDebugAPIOutputDeviceCallMsg __Gen_Wrap_152(in AudioDebugMsgItem P0); // 0x000000018220B710-0x000000018220C340
		public AudioDebugAPIOutputDeviceEffectCallMsg __Gen_Wrap_153(in AudioDebugMsgItem P0); // 0x000000018220C340-0x000000018220CF60
		public AudioDebugAPIAudioSessionCallMsg __Gen_Wrap_154(in AudioDebugMsgItem P0); // 0x000000018220CF60-0x000000018220DB60
		public AudioDebugAPIScePadOutputDeviceMappingMsg __Gen_Wrap_155(in AudioDebugMsgItem P0); // 0x000000018220DB60-0x000000018220E760
		public AudioDebugAPIEventCallMsg __Gen_Wrap_156(in AudioDebugMsgItem P0); // 0x000000018220E760-0x000000018220F380
		public AudioDebugAPIStateCallMsg __Gen_Wrap_157(in AudioDebugMsgItem P0); // 0x000000018220F380-0x000000018220FFA0
		public AudioDebugAPISwitchCallMsg __Gen_Wrap_158(in AudioDebugMsgItem P0); // 0x000000018220FFA0-0x0000000182210BC0
		public AudioDebugAPIEventActionCallMsg __Gen_Wrap_159(in AudioDebugMsgItem P0); // 0x0000000182210BC0-0x00000001822117E0
		public AudioDebugAPIEventSeekCallMsg __Gen_Wrap_160(in AudioDebugMsgItem P0); // 0x00000001822117E0-0x0000000182212400
		public AudioDebugAPIRtpcCallMsg __Gen_Wrap_161(in AudioDebugMsgItem P0); // 0x0000000182212400-0x0000000182213030
		public AudioDebugAPIResourcePathCallMsg __Gen_Wrap_162(in AudioDebugMsgItem P0); // 0x0000000182213030-0x0000000182213C50
		public AudioDebugAPIFilePackageCallMsg __Gen_Wrap_163(in AudioDebugMsgItem P0); // 0x0000000182213C50-0x0000000182214870
		public AudioDebugAPIBankCallMsg __Gen_Wrap_164(in AudioDebugMsgItem P0); // 0x0000000182214870-0x0000000182215490
		public AudioDebugAPIPrepareEventCallMsg __Gen_Wrap_165(in AudioDebugMsgItem P0); // 0x0000000182215490-0x00000001822160B0
		public AudioDebugAPIScePadDeviceCallMsg __Gen_Wrap_166(in AudioDebugMsgItem P0); // 0x00000001822160B0-0x0000000182216CD0
		public AudioDebugAPIScePadControllerInfoMsg __Gen_Wrap_167(in AudioDebugMsgItem P0); // 0x0000000182216CD0-0x00000001822178F0
		public AudioDebugAPIScePadAudioCallMsg __Gen_Wrap_168(in AudioDebugMsgItem P0); // 0x00000001822178F0-0x0000000182218510
		public AudioDebugAPIScePadLightBarCallMsg __Gen_Wrap_169(in AudioDebugMsgItem P0); // 0x0000000182218510-0x0000000182219120
		public AudioDebugAPIScePadTriggerCallMsg __Gen_Wrap_170(in AudioDebugMsgItem P0); // 0x0000000182219120-0x0000000182219D40
		public AudioDebugAPISpatialSettingsCallMsg __Gen_Wrap_171(in AudioDebugMsgItem P0); // 0x0000000182219D40-0x000000018221A960
		public AudioDebugAPIGeometryCallMsg __Gen_Wrap_172(in AudioDebugMsgItem P0); // 0x000000018221A960-0x000000018221B590
		public AudioDebugAPIRoomCallMsg __Gen_Wrap_173(in AudioDebugMsgItem P0); // 0x000000018221B590-0x000000018221C1E0
		public AudioDebugAPIPortalCallMsg __Gen_Wrap_174(in AudioDebugMsgItem P0); // 0x000000018221C1E0-0x000000018221CE30
		public AudioDebugAPIReverbZoneCallMsg __Gen_Wrap_175(in AudioDebugMsgItem P0); // 0x000000018221CE30-0x000000018221DA50
		public AudioDebugAPIRemoveSpatialObjectCallMsg __Gen_Wrap_176(in AudioDebugMsgItem P0); // 0x000000018221DA50-0x000000018221E670
		public AudioDebugAPIObstructionCallMsg __Gen_Wrap_177(in AudioDebugMsgItem P0); // 0x000000018221E670-0x000000018221F290
		public AudioDebugAPIGeometryInstanceCallMsg __Gen_Wrap_178(in AudioDebugMsgItem P0); // 0x000000018221F290-0x000000018221FED0
		public AudioDebugEventEndMsg __Gen_Wrap_179(in AudioDebugMsgItem P0); // 0x000000018221FED0-0x0000000182220AF0
		public bool __Gen_Wrap_180(AudioLogChannel P0); // 0x0000000182220AF0-0x0000000182220CF0
		public void __Gen_Wrap_181(AudioLogChannel P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_182(AudioLogChannel P0, object P1); // 0x0000000182220EE0-0x00000001822211B0
		public float __Gen_Wrap_183(float P0, float P1, float P2); // 0x00000001822211B0-0x00000001822213F0
		public float __Gen_Wrap_184(UnityEngine.Vector3 P0); // 0x00000001822213F0-0x00000001822219C0
		public void __Gen_Wrap_185(uint P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_186(object P0, ref LinkedListNode<AudioAssetCache.EventCacheInfo> P1); // 0x00000001822219C0-0x0000000182222480
		public LinkedList<AudioAssetCache.EventCacheInfo> __Gen_Wrap_187(object P0); // 0x0000000182222480-0x0000000182222DA0
		public void __Gen_Wrap_188(ulong P0, ushort P1); // 0x0000000182222DA0-0x0000000182222FB0
		public void __Gen_Wrap_189(ulong P0, object P1); // 0x0000000182222FB0-0x0000000182223280
		public string __Gen_Wrap_190(uint P0); // 0x0000000182223280-0x0000000182223AE0
		public uint __Gen_Wrap_191(ReadOnlySpan<byte> P0); // 0x0000000182223AE0-0x0000000182224090
		public uint __Gen_Wrap_192(IntPtr P0); // 0x0000000182224090-0x0000000182224290
		public uint __Gen_Wrap_193(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public ulong __Gen_Wrap_194(AkMemID P0); // 0x0000000182224620-0x0000000182224820
		public void __Gen_Wrap_195(AudioUIUtil.UIAudioType P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_196(ref int P0, object P1); // 0x0000000182224820-0x0000000182224B10
		public bool __Gen_Wrap_197(int P0, out VoiceData P1); // 0x0000000182224B10-0x00000001822253E0
		public void __Gen_Wrap_198(ref int P0, object P1, object P2); // 0x00000001822253E0-0x00000001822257C0
		public int __Gen_Wrap_199(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public bool __Gen_Wrap_200(object P0, out VoiceData P1, out int P2, object P3); // 0x00000001822257C0-0x00000001822262C0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 86938
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x00000001887EFFA4-0x00000001887F0054 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x00000001887F00D4-0x00000001887F0184 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x00000001887F0204-0x00000001887F02E4
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x00000001887F0184-0x00000001887F0204
		[IDTag(1)]
		private bool MoveNext(); // 0x00000001887EFF14-0x00000001887EFFA4
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x00000001887F0054-0x00000001887F00D4
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 86939
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x00000001887F04D0-0x00000001887F0534
		public static bool IsPatched(int id); // 0x00000001887F05C0-0x00000001887F063C
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x00000001887F0388-0x00000001887F0454
		public object CreateWrapper(int id); // 0x00000001887F0454-0x00000001887F04D0
		public object InitWrapperArray(int len); // 0x00000001887F0534-0x00000001887F05C0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x00000001887F02E4-0x00000001887F0388
	}

	public delegate ulong __HotPatchDelegate_0(); // TypeDefIndex: 86940; 0x0000000185B44B70-0x0000000185B44B80

	public enum HotPatchIDMAP0 // TypeDefIndex: 86941
	{
		Beyond-Audio-AudioAdapter-get_listenerObjId0 = 0,
		Beyond-Audio-AudioAdapter-_PostEventWithExternalSource0 = 1,
		Beyond-Audio-AudioAdapter-PostEventExternal1 = 1,
		Beyond-Audio-AudioAdapter-PostEventExternal0 = 2,
		Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsSync0 = 3,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsSync0 = 3,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsSync1 = 3,
		Beyond-Audio-AudioAdapter-SetAudioLanguage0 = 3,
		Beyond-Audio-AudioAssetCache-Cache-Clear0 = 3,
		Beyond-Audio-AudioVFSLoader-LoadExtraPckFromPath0 = 3,
		Beyond-Audio-AudioAdapter-LoadExtraPckFromPath0 = 3,
		Beyond-Audio-AudioAdapter-StartProfileCapture0 = 3,
		Beyond-Audio-AudioAdapter-PayloadPostEvent-OnRecycle0 = 3,
		Beyond-Audio-BankHandle-DecRef0 = 3,
		Beyond-Audio-BankHandle-Dispose0 = 3,
		Beyond-Audio-BankHandle-IncRef0 = 3,
		Beyond-Audio-AsyncLoadBankTask-Dispose0 = 3,
		Beyond-Audio-AsyncLoadBankTask-Reset0 = 3,
		Beyond-Audio-AudioBankManager-_PostResetBasePath0 = 3,
		Beyond-Audio-AudioBankManager-LoadDebugFilePackage0 = 3,
		Beyond-Audio-AudioBankManager-AddDebugBankPath0 = 3,
		Beyond-Audio-AudioPositionArrayProxy-Reset0 = 3,
		Beyond-Audio-AudioAdapter-_DoLoadAndPinEventsAsync0 = 4,
		Beyond-Audio-AudioAdapter-_LoadAndPinEventsAsync0 = 5,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync0 = 6,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync1 = 6,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsAsync2 = 6,
		Beyond-Audio-AudioId-op_Implicit0 = 7,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine0 = 8,
		Beyond-Audio-AudioAdapter-LoadAndPinEventsCoroutine1 = 8,
		Beyond-Audio-AudioAdapter-SetSwitch0 = 9,
		Beyond-Audio-AudioAdapter-SetSwitch1 = 10,
		Beyond-Audio-AudioHashGenerator-Compute0 = 11,
		Beyond-Audio-AudioPositionArrayProxy-get_count0 = 11,
		Beyond-Audio-AudioHashGenerator-Compute4 = 11,
		Beyond-Audio-AudioAdapter-SetRtpc0 = 12,
		Beyond-Audio-AudioAdapter-SetRtpc1 = 13,
		Beyond-Audio-AudioAdapter-SetRtpc2 = 14,
		Beyond-Audio-AudioAdapter-SetRtpc3 = 15,
		Beyond-Audio-AudioAdapter-SetRtpc4 = 16,
		Beyond-Audio-AudioActionQueueHelper-QueueRtpcAction0 = 17,
		Beyond-Audio-AudioAdapter-SetRtpcValueByPlayingID0 = 18,
		Beyond-Audio-AudioAdapter-ResetRtpc0 = 19,
		Beyond-Audio-AudioAdapter-ResetRtpc1 = 20,
		Beyond-Audio-AudioActionQueueHelper-QueueSeekAction0 = 21,
		Beyond-Audio-AudioAdapter-SeekOnEvent0 = 22,
		Beyond-Audio-AudioAdapter-SeekOnEvent1 = 23,
		Beyond-Audio-AudioAdapter-SeekOnEvent2 = 24,
		Beyond-Audio-AudioAdapter-SeekOnEvent3 = 25,
		Beyond-Audio-AudioAdapter-TryGetPlayingPosition0 = 26,
		Beyond-Audio-AudioAdapter-TryGetMusicPlayingPosition0 = 26,
		Beyond-Audio-AudioAdapter-IsPlaying0 = 27,
		Beyond-Audio-AudioAssetCache-ActivateAsset0 = 27,
		Beyond-Audio-AudioAssetCache-Cache-get_count0 = 28,
		Beyond-Audio-BankHandle-get_refCount0 = 28,
		Beyond-Audio-AudioVoiceUtil-GetVoiceIdFromString0 = 28,
		Beyond-Audio-AudioAssetCache-GetCachedAssetCount0 = 29,
		Beyond-Audio-AudioDebugMsg-GetBufferCapacity0 = 29,
		Beyond-Audio-AudioDebugMsg-GetBufferSize0 = 29,
		Beyond-Audio-AudioAssetCache-Cache-RemoveFirst0 = 30,
		Beyond-Audio-AudioAssetCache-GetLeastActiveAssetAndUncache0 = 31,
		Beyond-Audio-AudioAssetHelper-get_isGcProcessing0 = 32,
		Beyond-Audio-AudioAdapter-_InitInternal0 = 32,
		Beyond-Audio-AudioVFSLoader-TryLoadInitPck0 = 32,
		Beyond-Audio-AudioAdapter-InitWwise0 = 32,
		Beyond-Audio-AudioAssetHelper-HasPreparingEvents0 = 32,
		Beyond-Audio-AudioVFSLoader-TryLoadMainPck0 = 32,
		Beyond-Audio-AudioAssetCache-Cache-Remove0 = 33,
		Beyond-Audio-AudioAssetHelper-_TryDequeueAndInvokeCallback0 = 34,
		Beyond-Audio-AudioAssetHelper-_ConsumePendingLoadRequests0 = 34,
		Beyond-Audio-AudioAssetHelper-_TryConsumePendingLoadRequests0 = 34,
		Beyond-Audio-AudioAssetHelper-ReleaseAllCachedEventsSync0 = 34,
		Beyond-Audio-AudioAdapter-ReleaseAllCachedEventsSync0 = 34,
		Beyond-Audio-AudioAdapter-UnsetAudioEngineInitSetting0 = 34,
		Beyond-Audio-AudioAdapter-Context-Reset0 = 34,
		Beyond-Audio-AudioAssetCache-Reset0 = 34,
		Beyond-Audio-AudioAssetHelper-ResetStaticFields0 = 34,
		Beyond-Audio-AudioAdapter-_ResetStaticFields0 = 34,
		Beyond-Audio-AudioAdapter-_InitAndroidActivityEnvironment0 = 34,
		Beyond-Audio-AudioCallbackMessageParser-Set0 = 34,
		Beyond-Audio-AudioMemoryMonitor-Init0 = 34,
		Beyond-Audio-AudioAdapter-Context-PostSoundEngineInit0 = 34,
		Beyond-Audio-AudioVFSLoader-InitBasePaths0 = 34,
		Beyond-Audio-AudioAdapter-LoadInitResources0 = 34,
		Beyond-Audio-AudioActionQueueHelper-ClearQueue0 = 34,
		Beyond-Audio-AudioAdapter-_OnBeforeTerminate0 = 34,
		Beyond-Audio-AudioAssetHelper-UnPrepareAllEventsSync0 = 34,
		Beyond-Audio-AudioMemoryMonitor-Release0 = 34,
		Beyond-Audio-AudioBankManager-Reset0 = 34,
		Beyond-Audio-AudioVFSLoader-UnloadAll0 = 34,
		Beyond-Audio-AudioAdapter-ReloadInitResources0 = 34,
		Beyond-Audio-AudioAdapter-MemoryShrink0 = 34,
		Beyond-Audio-AudioAdapter-TouchAudioHotfixPlaceholder0 = 34,
		Beyond-Audio-AudioAdapter-_SampleAllData0 = 34,
		Beyond-Audio-AudioAdapter-_SampleMemoryOnly0 = 34,
		Beyond-Audio-AudioAdapter-StopProfileCapture0 = 34,
		Beyond-Audio-AudioBankManager-LoadMainPCK0 = 34,
		Beyond-Audio-AudioBankManager-UnloadAllBanks0 = 34,
		Beyond-Audio-AudioDebugMsg-ResetFilter0 = 34,
		Beyond-Audio-AudioDebugMsg-ClearBuffer0 = 34,
		Beyond-Audio-AudioDebugMsg-ResetBuffer0 = 34,
		Beyond-Audio-AudioActionQueueHelper-ConsumeQueue0 = 34,
		Beyond-Audio-AudioAssetCache-_NotifyDebugger0 = 34,
		Beyond-Audio-AudioAssetCache-_ResetDebugger0 = 34,
		Beyond-Audio-AudioAssetCache-_PinnedEventLeakDetect0 = 34,
		Beyond-Audio-AudioAssetHelper-_ClearLoadingDebug0 = 34,
		Beyond-Audio-AudioUIUtil-Init0 = 34,
		Beyond-Audio-AudioUIUtil-Release0 = 34,
		Beyond-Audio-AudioAssetHelper-_DoLoadEventAsync0 = 35,
		Beyond-Audio-AudioAssetHelper-_DoGc0 = 36,
		Beyond-Audio-AudioDebugMsg-ExpandBuffer0 = 36,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeExecute0 = 36,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeRtpc0 = 36,
		Beyond-Audio-AudioActionQueueHelper-_ConsumeSeek0 = 36,
		Beyond-Audio-AudioPositionArrayProxy-GetRawArray0 = 37,
		Beyond-Audio-AudioAdapter-SetLargePositions0 = 38,
		Beyond-Audio-AudioAdapter-SetDefaultListener0 = 39,
		Beyond-Audio-AudioAdapter-SetDefaultEmitter0 = 39,
		Beyond-Audio-AudioAdapter-SetDistanceProbe0 = 39,
		Beyond-Audio-AudioDebugInfoContainer-RemoveAudioObjectName0 = 39,
		Beyond-Audio-AudioAdapter-SetListener0 = 40,
		Beyond-Audio-AudioAdapter-TryGetRealPlayingId0 = 41,
		Beyond-Audio-AudioAdapter-AddBasePath0 = 42,
		Beyond-Audio-AudioVFSLoader-TryLoadLanguagePck0 = 42,
		Beyond-Audio-AudioBankManager-UnloadBank0 = 42,
		Beyond-Audio-AsyncLoadBankTask-MoveNext0 = 42,
		Beyond-Audio-AudioBankManager-IsBankLoaded0 = 42,
		Beyond-Audio-AudioVFSLoader-_GetVfsBlockTypeFromLanguage0 = 43,
		Beyond-Audio-AudioVFSLoader-_UnloadPcks0 = 44,
		Beyond-Audio-AudioVFSLoader-_DoLoadSinglePckFromVfs0 = 45,
		Beyond-Audio-AudioVFSLoader-_DoLoadPcksFromVfs0 = 46,
		Beyond-Audio-AudioVFSLoader-_DoLoadPcksFromChunks0 = 46,
		Beyond-Audio-AudioVFSLoader-_TryLoadPcksFromVfsInfo0 = 47,
		Beyond-Audio-AudioVFSLoader-_DoLoadLanguageAndHotfixPck0 = 48,
		Beyond-Audio-AudioAdapter-SetAudioEngineInitSetting0 = 49,
		Beyond-Audio-AudioVFSLoader-VfsLoadedInfo-Create0 = 50,
		Beyond-Audio-AudioAssetCache-GetAllUsingAssetsAndRelease0 = 51,
		Beyond-Audio-AudioAdapter-_ReleaseInternal0 = 52,
		Beyond-Audio-AudioAdapter-TermWwise0 = 52,
		Beyond-Audio-AudioAdapter-SetEnableSpatialAudio0 = 52,
		Beyond-Audio-AudioAssetCache-_NotifyDebuggerCacheHit0 = 52,
		Beyond-Audio-AudioAdapter-TouchAudioHotfixPlaceholderArgs0 = 53,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder10 = 53,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder20 = 53,
		Beyond-Audio-AudioAdapter-AudioHotfixPlaceholder30 = 53,
		Beyond-Audio-AudioAdapter-_OnEventPreparedDoPostEvent0 = 54,
		Beyond-Audio-AudioBankManager-_LoadBankCallback0 = 54,
		Beyond-Audio-AudioAssetHelper-_OnUnpreparedDoUnloadBank0 = 54,
		Beyond-Audio-AudioAssetHelper-_OnDoneUnloadBank0 = 54,
		Beyond-Audio-AudioAssetHelper-_OnDonePrepareEvent0 = 54,
		Beyond-Audio-AudioAssetHelper-_OnBankLoadedDoPrepareEvent0 = 54,
		Beyond-Audio-AudioAdapter-_OnEventCallback0 = 55,
		Beyond-Audio-AudioAdapter-_OnExternalSourceEventCallback0 = 55,
		Beyond-Audio-AudioAdapter-_PostEvent0 = 56,
		Beyond-Audio-AudioActionQueueHelper-QueueExecuteAction0 = 57,
		Beyond-Audio-AudioAdapter-_ExecuteActionOnPlayingId0 = 58,
		Beyond-Audio-AudioAdapter-GetResourceSummaryData0 = 59,
		Beyond-Audio-AudioAdapter-GetGlobalMemoryStats0 = 60,
		Beyond-Audio-AudioMemoryMonitor-GetGlobalMemoryStats0 = 60,
		Beyond-Audio-AudioAdapter-GetExtraMemoryStats0 = 61,
		Beyond-Audio-AudioMemoryMonitor-GetExtraMemoryStats0 = 61,
		Beyond-Audio-AudioAdapter-SetObjectObstructionAndOcclusion0 = 62,
		Beyond-Audio-AudioAdapter-SetGeometry0 = 63,
		Beyond-Audio-AudioAdapter-SetGeometryInstance0 = 64,
		Beyond-Audio-AudioAdapter-SetRoom0 = 65,
		Beyond-Audio-AudioAdapter-SetPortal0 = 66,
		Beyond-Audio-AudioAdapter-Context-_CreatePayloadPostEvent0 = 67,
		Beyond-Audio-AudioAdapter-Device-GetSpeakerConfiguration0 = 68,
		Beyond-Audio-AudioAdapter-Device-AddOutputDevice0 = 69,
		Beyond-Audio-AudioAdapter-Device-AddOutput0 = 70,
		Beyond-Audio-AudioAdapter-Device-GetOutputDeviceId0 = 71,
		Beyond-Audio-AudioAdapter-Device-RemoveOutputDevice0 = 72,
		Beyond-Audio-AudioAdapter-Device-Switch3DOutput0 = 73,
		Beyond-Audio-AudioAdapter-Device-SetOutputDeviceEffect0 = 74,
		Beyond-Audio-AudioAdapter-Device-GetMmDeviceIdFromScePadHandle0 = 75,
		Beyond-Audio-AsyncLoadBankTask-LoadBanksAsync0 = 76,
		Beyond-Audio-AsyncLoadBankTask-get_Current0 = 77,
		Beyond-Audio-AudioVFSLoader-_SplitChunksByTag0 = 78,
		Beyond-Audio-AudioVFSLoader-_TryLoadPcksFromChunks0 = 79,
		Beyond-Audio-AudioBankManager-LoadBankAsync0 = 80,
		Beyond-Audio-AudioBankManager-_PreResetBasePath0 = 81,
		Beyond-Audio-AudioId-GetName0 = 82,
		Beyond-Audio-AudioId-op_Implicit1 = 83,
		Beyond-Audio-AudioId-op_Implicit2 = 84,
		Beyond-Audio-AudioId-op_Implicit3 = 85,
		Beyond-Audio-AudioId-op_Implicit4 = 86,
		Beyond-Audio-AudioIdExtensions-ToUIntArray0 = 87,
		Beyond-Audio-AudioState-get_stateGroup0 = 88,
		Beyond-Audio-AudioState-get_stateValue0 = 88,
		Beyond-Audio-AudioState-Equals0 = 89,
		Beyond-Audio-AudioState-Equals1 = 90,
		Beyond-Audio-AudioState-GetHashCode0 = 91,
		Beyond-Audio-AudioCallbackInfo-CastToDurationCallbackInfo0 = 92,
		Beyond-Audio-AudioPositionArrayProxy-Add0 = 93,
		Beyond-Audio-AudioDebugMsg-GetEnabledFilters0 = 94,
		Beyond-Audio-AudioDebugMsg-IsFilterEnabled0 = 95,
		Beyond-Audio-AudioDebugMsg-SetFilterEnabled0 = 96,
		Beyond-Audio-AudioDebugMsg-SetEnabledFilters0 = 97,
		Beyond-Audio-AudioDebugMsg-GetBufferedMessages0 = 98,
		Beyond-Audio-AudioDebugMsg-GetOverwrittenMessageCount0 = 99,
		Beyond-Audio-AudioDebugMsg-AddAnimEventMsg0 = 100,
		Beyond-Audio-AudioDebugMsg-AddAPIEmitterCallMsg0 = 101,
		Beyond-Audio-AudioDebugMsg-AddAPIEmitterPositionCallMsg0 = 102,
		Beyond-Audio-AudioDebugMsg-AddAPIEmitterMultiplePositionsCallMsg0 = 103,
		Beyond-Audio-AudioDebugMsg-AddAPIEmitterMultiplePositionsCallMsg1 = 104,
		Beyond-Audio-AudioDebugMsg-AddAPIEngineLifecycleMsg0 = 105,
		Beyond-Audio-AudioDebugMsg-AddAPIEngineCallMsg0 = 106,
		Beyond-Audio-AudioDebugMsg-AddAPIRenderAudioCallMsg0 = 107,
		Beyond-Audio-AudioDebugMsg-AddAPIListenerCallMsg0 = 108,
		Beyond-Audio-AudioDebugMsg-AddAPIScePadOutputDeviceMappingMsg0 = 109,
		Beyond-Audio-AudioDebugMsg-AddAPIOutputDeviceCallMsg0 = 110,
		Beyond-Audio-AudioDebugMsg-AddAPIOutputDeviceCallMsg1 = 111,
		Beyond-Audio-AudioDebugMsg-AddAPIOutputDeviceEffectCallMsg0 = 112,
		Beyond-Audio-AudioDebugMsg-AddAPIAudioSessionCallMsg0 = 113,
		Beyond-Audio-AudioDebugMsg-AddAPIEventCallMsg0 = 114,
		Beyond-Audio-AudioDebugMsg-AddAPIEventCallMsg1 = 115,
		Beyond-Audio-AudioDebugMsg-AddAPIStateCallMsg0 = 116,
		Beyond-Audio-AudioDebugMsg-AddAPIStateCallMsg1 = 117,
		Beyond-Audio-AudioDebugMsg-AddAPISwitchCallMsg0 = 118,
		Beyond-Audio-AudioDebugMsg-AddAPISwitchCallMsg1 = 119,
		Beyond-Audio-AudioDebugMsg-AddAPIEventActionCallMsg0 = 120,
		Beyond-Audio-AudioDebugMsg-AddAPIEventSeekCallMsg0 = 121,
		Beyond-Audio-AudioDebugMsg-AddAPIRtpcCallMsg0 = 122,
		Beyond-Audio-AudioDebugMsg-AddAPIRtpcCallMsg1 = 123,
		Beyond-Audio-AudioDebugMsg-AddAPIResourcePathCallMsg0 = 124,
		Beyond-Audio-AudioDebugMsg-AddAPIFilePackageCallMsg0 = 125,
		Beyond-Audio-AudioDebugMsg-AddAPIBankCallMsg0 = 126,
		Beyond-Audio-AudioDebugMsg-AddAPIPrepareEventCallMsg0 = 127,
		Beyond-Audio-AudioDebugMsg-AddAPIScePadDeviceCallMsg0 = 128,
		Beyond-Audio-AudioDebugMsg-AddAPIScePadControllerInfoMsg0 = 129,
		Beyond-Audio-AudioDebugMsg-AddAPIScePadAudioCallMsg0 = 130,
		Beyond-Audio-AudioDebugMsg-AddAPIScePadLightBarCallMsg0 = 131,
		Beyond-Audio-AudioDebugMsg-AddAPIScePadTriggerCallMsg0 = 132,
		Beyond-Audio-AudioDebugMsg-AddAPISpatialSettingsCallMsg0 = 133,
		Beyond-Audio-AudioDebugMsg-AddAPIGeometryCallMsg0 = 134,
		Beyond-Audio-AudioDebugMsg-AddAPIRoomCallMsg0 = 135,
		Beyond-Audio-AudioDebugMsg-AddAPIPortalCallMsg0 = 136,
		Beyond-Audio-AudioDebugMsg-AddAPIReverbZoneCallMsg0 = 137,
		Beyond-Audio-AudioDebugMsg-AddAPIRemoveSpatialObjectCallMsg0 = 138,
		Beyond-Audio-AudioDebugMsg-AddAPIObstructionCallMsg0 = 139,
		Beyond-Audio-AudioDebugMsg-AddAPIGeometryInstanceCallMsg0 = 140,
		Beyond-Audio-AudioDebugMsg-AddEventEndMsg0 = 141,
		Beyond-Audio-AudioDebugMsg-AddLevelScriptEventMsg0 = 142,
		Beyond-Audio-AudioDebugMsgItem-ToLevelScriptEventMsg0 = 143,
		Beyond-Audio-AudioDebugAPIEmitterCallMsg-FromMessage0 = 144,
		Beyond-Audio-AudioDebugAPIEmitterPositionCallMsg-FromMessage0 = 145,
		Beyond-Audio-AudioDebugAPIEmitterMultiplePositionsCallMsg-FromMessage0 = 146,
		Beyond-Audio-AudioDebugAPIEngineCallMsg-FromMessage0 = 147,
		Beyond-Audio-AudioDebugAPIEngineLifecycleMsg-FromMessage0 = 148,
		Beyond-Audio-AudioDebugAPIRenderAudioCallMsg-FromMessage0 = 149,
		Beyond-Audio-AudioDebugAPIListenerCallMsg-FromMessage0 = 150,
		Beyond-Audio-AudioDebugAPIOutputDeviceCallMsg-FromMessage0 = 151,
		Beyond-Audio-AudioDebugAPIOutputDeviceEffectCallMsg-FromMessage0 = 152,
		Beyond-Audio-AudioDebugAPIAudioSessionCallMsg-FromMessage0 = 153,
		Beyond-Audio-AudioDebugAPIScePadOutputDeviceMappingMsg-FromMessage0 = 154,
		Beyond-Audio-AudioDebugAPIEventCallMsg-FromMessage0 = 155,
		Beyond-Audio-AudioDebugAPIStateCallMsg-FromMessage0 = 156,
		Beyond-Audio-AudioDebugAPISwitchCallMsg-FromMessage0 = 157,
		Beyond-Audio-AudioDebugAPIEventActionCallMsg-FromMessage0 = 158,
		Beyond-Audio-AudioDebugAPIEventSeekCallMsg-FromMessage0 = 159,
		Beyond-Audio-AudioDebugAPIRtpcCallMsg-FromMessage0 = 160,
		Beyond-Audio-AudioDebugAPIResourcePathCallMsg-FromMessage0 = 161,
		Beyond-Audio-AudioDebugAPIFilePackageCallMsg-FromMessage0 = 162,
		Beyond-Audio-AudioDebugAPIBankCallMsg-FromMessage0 = 163,
		Beyond-Audio-AudioDebugAPIPrepareEventCallMsg-FromMessage0 = 164,
		Beyond-Audio-AudioDebugAPIScePadDeviceCallMsg-FromMessage0 = 165,
		Beyond-Audio-AudioDebugAPIScePadControllerInfoMsg-FromMessage0 = 166,
		Beyond-Audio-AudioDebugAPIScePadAudioCallMsg-FromMessage0 = 167,
		Beyond-Audio-AudioDebugAPIScePadLightBarCallMsg-FromMessage0 = 168,
		Beyond-Audio-AudioDebugAPIScePadTriggerCallMsg-FromMessage0 = 169,
		Beyond-Audio-AudioDebugAPISpatialSettingsCallMsg-FromMessage0 = 170,
		Beyond-Audio-AudioDebugAPIGeometryCallMsg-FromMessage0 = 171,
		Beyond-Audio-AudioDebugAPIRoomCallMsg-FromMessage0 = 172,
		Beyond-Audio-AudioDebugAPIPortalCallMsg-FromMessage0 = 173,
		Beyond-Audio-AudioDebugAPIReverbZoneCallMsg-FromMessage0 = 174,
		Beyond-Audio-AudioDebugAPIRemoveSpatialObjectCallMsg-FromMessage0 = 175,
		Beyond-Audio-AudioDebugAPIObstructionCallMsg-FromMessage0 = 176,
		Beyond-Audio-AudioDebugAPIGeometryInstanceCallMsg-FromMessage0 = 177,
		Beyond-Audio-AudioDebugEventEndMsg-FromMessage0 = 178,
		Beyond-Audio-AudioLogger-IsChannelEnabled0 = 179,
		Beyond-Audio-AudioLogger-EnableChannel0 = 180,
		Beyond-Audio-AudioLogger-DisableChannel0 = 180,
		Beyond-Audio-AudioLogger-SetChannels0 = 180,
		Beyond-Audio-AudioLogger-_DoLog0 = 181,
		Beyond-Audio-AudioLogger-Log0 = 181,
		Beyond-Audio-AudioLogger-_DoLogWarning0 = 181,
		Beyond-Audio-AudioLogger-LogWarning0 = 181,
		Beyond-Audio-AudioLogger-_DoLogError0 = 181,
		Beyond-Audio-AudioLogger-LogError0 = 181,
		Beyond-Audio-AudioAcousticUtil-RT60DecayTime0 = 182,
		Beyond-Audio-AudioAcousticUtil-CriticalDistance0 = 182,
		Beyond-Audio-AudioAcousticUtil-PreDelayTime0 = 183,
		Beyond-Audio-AudioAcousticUtil-ReverbIntensity0 = 183,
		Beyond-Audio-AudioAcousticUtil-ErIntensity0 = 183,
		Beyond-Audio-AudioAssetCache-PinEvent0 = 184,
		Beyond-Audio-AudioAssetCache-UnpinEvent0 = 184,
		Beyond-Audio-AudioAssetCache-DeactivateAsset0 = 184,
		Beyond-Audio-AudioAssetCache-ForceReleaseCachedAsset0 = 184,
		Beyond-Audio-AudioAssetHelper-_RemoveLoadingDebug0 = 184,
		Beyond-Audio-AudioAssetHelper-_AddLoadingDebug0 = 184,
		Beyond-Audio-AudioAssetCache-Cache-AddLast0 = 185,
		Beyond-Audio-AudioAssetCache-Cache-get_lruCachedEventsList0 = 186,
		Beyond-Audio-AudioAssetHelper-SetMemoryBudget0 = 187,
		Beyond-Audio-AudioDebugInfoContainer-SetAudioObjectName0 = 188,
		Beyond-Audio-AudioDebugInfoContainer-ForceGetEventName0 = 189,
		Beyond-Audio-AudioDebugInfoContainer-ForceGetRtpcName0 = 189,
		Beyond-Audio-AudioHashGenerator-Compute1 = 190,
		Beyond-Audio-AudioHashGenerator-Compute2 = 191,
		Beyond-Audio-AudioHashGenerator-Compute3 = 192,
		Beyond-Audio-AudioUIUtil-PostUIEvent0 = 192,
		Beyond-Audio-AudioUIUtil-PostUIEvent1 = 192,
		Beyond-Audio-AudioMemoryMonitor-GetUsedMemoryByCategory0 = 193,
		Beyond-Audio-AudioUIUtil-OnUIPanelClose0 = 194,
		Beyond-Audio-AudioUIUtil-OnUIPanelOpen0 = 194,
		Beyond-Audio-AudioVoiceUtil-_HandleVoiceIdConflict0 = 195,
		Beyond-Audio-AudioVoiceUtil-GetVoDataFromVoId0 = 196,
		Beyond-Audio-AudioVoiceUtil-_HandleVoiceIdConflict1 = 197,
		Beyond-Audio-AudioVoiceUtil-GetVoiceIdFromStrings0 = 198,
		Beyond-Audio-AudioVoiceUtil-TryGetVoiceData0 = 199
	}

	public delegate uint __HotPatchDelegate_1(uint P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7); // TypeDefIndex: 86942; 0x00000001812458F0-0x0000000181245910

	public delegate uint __HotPatchDelegate_2(object P0, ulong P1, object P2, uint P3, AudioCallbackType P4, object P5, object P6, AudioCodec P7); // TypeDefIndex: 86943; 0x00000001812458F0-0x0000000181245910

	public delegate void __HotPatchDelegate_3(object P0); // TypeDefIndex: 86944; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_4(object P0, object P1, object P2); // TypeDefIndex: 86945; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_5(in IList<uint> P0, in Action<object> P1, in object P2); // TypeDefIndex: 86946; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_6(object P0, object P1, object P2); // TypeDefIndex: 86947; 0x00000001811DF7F0-0x00000001811DF810

	public delegate uint __HotPatchDelegate_7(AudioId P0); // TypeDefIndex: 86948; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_8(object P0); // TypeDefIndex: 86949; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_9(uint P0, uint P1, ulong P2); // TypeDefIndex: 86950; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_10(object P0, object P1, ulong P2); // TypeDefIndex: 86951; 0x00000001811DF7F0-0x00000001811DF810

	public delegate uint __HotPatchDelegate_11(object P0); // TypeDefIndex: 86952; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_12(uint P0, float P1, int P2); // TypeDefIndex: 86953; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_13(object P0, float P1, int P2); // TypeDefIndex: 86954; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_14(uint P0, float P1, ulong P2); // TypeDefIndex: 86955; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_15(object P0, float P1, ulong P2); // TypeDefIndex: 86956; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_16(uint P0, float P1, ulong P2, int P3); // TypeDefIndex: 86957; 0x00000001812250A0-0x00000001812250C0

	public delegate void __HotPatchDelegate_17(uint P0, uint P1, float P2, int P3); // TypeDefIndex: 86958; 0x000000018129E8F0-0x000000018129E910

	public delegate void __HotPatchDelegate_18(uint P0, float P1, uint P2, int P3); // TypeDefIndex: 86959; 0x00000001812250A0-0x00000001812250C0

	public delegate void __HotPatchDelegate_19(uint P0, ulong P1, int P2); // TypeDefIndex: 86960; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_20(object P0, ulong P1, int P2); // TypeDefIndex: 86961; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_21(uint P0, uint P1, ulong P2, int P3, bool P4); // TypeDefIndex: 86962; 0x000000018129F400-0x000000018129F420

	public delegate void __HotPatchDelegate_22(uint P0, ulong P1, int P2, bool P3, uint P4); // TypeDefIndex: 86963; 0x00000001826EA060-0x00000001826EA080

	public delegate void __HotPatchDelegate_23(object P0, ulong P1, int P2, bool P3, uint P4); // TypeDefIndex: 86964; 0x00000001826EA060-0x00000001826EA080

	public delegate void __HotPatchDelegate_24(object P0, int P1, bool P2, uint P3); // TypeDefIndex: 86965; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_25(uint P0, int P1, bool P2, uint P3); // TypeDefIndex: 86966; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_26(uint P0, out int P1, bool P2); // TypeDefIndex: 86967; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_27(uint P0); // TypeDefIndex: 86968; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_28(object P0); // TypeDefIndex: 86969; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_29(); // TypeDefIndex: 86970; 0x0000000185B44B70-0x0000000185B44B80

	public delegate uint __HotPatchDelegate_30(object P0, out LinkedListNode<AudioAssetCache.EventCacheInfo> P1); // TypeDefIndex: 86971; 0x00000001859B7730-0x00000001859B7740

	public delegate uint __HotPatchDelegate_31(); // TypeDefIndex: 86972; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_32(); // TypeDefIndex: 86973; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_33(object P0, uint P1, out LinkedListNode<AudioAssetCache.EventCacheInfo> P2); // TypeDefIndex: 86974; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_34(); // TypeDefIndex: 86975; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_35(uint P0, AudioAssetHelper.FOnBankLoadedDoPrepareEventPayload P1); // TypeDefIndex: 86976; 0x00000001826DF780-0x00000001826DF7C0

	public delegate void __HotPatchDelegate_36(int P0); // TypeDefIndex: 86977; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AkPositionArray __HotPatchDelegate_37(object P0); // TypeDefIndex: 86978; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_38(ulong P0, object P1, AudioLargeType P2); // TypeDefIndex: 86979; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_39(ulong P0); // TypeDefIndex: 86980; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_40(ulong P0, ulong P1); // TypeDefIndex: 86981; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_41(uint P0, out uint P1); // TypeDefIndex: 86982; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_42(object P0); // TypeDefIndex: 86983; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate EVFSBlockType __HotPatchDelegate_43(object P0); // TypeDefIndex: 86984; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_44(ref AudioVFSLoader.VfsLoadedInfo P0); // TypeDefIndex: 86985; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_45(FVFBlockFileInfo P0, out uint P1); // TypeDefIndex: 86986; 0x00000001812056F0-0x0000000181205730

	public delegate bool __HotPatchDelegate_46(object P0, ref List<uint> P1); // TypeDefIndex: 86987; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_47(object P0, ref AudioVFSLoader.VfsLoadedInfo P1); // TypeDefIndex: 86988; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_48(EVFSBlockType P0); // TypeDefIndex: 86989; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_49(AudioEngineInitSetting P0); // TypeDefIndex: 86990; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioVFSLoader.VfsLoadedInfo __HotPatchDelegate_50(); // TypeDefIndex: 86991; 0x0000000185378C70-0x0000000185378CA0

	public delegate void __HotPatchDelegate_51(ref List<uint> P0); // TypeDefIndex: 86992; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_52(bool P0); // TypeDefIndex: 86993; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_53(object P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8); // TypeDefIndex: 86994; 0x00000001823B2550-0x00000001823B25C0

	public delegate void __HotPatchDelegate_54(uint P0, IntPtr P1, AKRESULT P2, object P3); // TypeDefIndex: 86995; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_55(object P0, AkCallbackType P1, object P2); // TypeDefIndex: 86996; 0x00000001811DF7F0-0x00000001811DF810

	public delegate uint __HotPatchDelegate_56(uint P0, ulong P1, AudioCallbackType P2, object P3, object P4); // TypeDefIndex: 86997; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_57(uint P0, AkActionOnEventType P1, int P2); // TypeDefIndex: 86998; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_58(AkActionOnEventType P0, uint P1, int P2); // TypeDefIndex: 86999; 0x00000001811DF7F0-0x00000001811DF810

	public delegate AkResourceMonitorDataSummary __HotPatchDelegate_59(); // TypeDefIndex: 87000; 0x0000000185B44B70-0x0000000185B44B80

	public delegate AudioMemoryMonitor.FGlobalMemoryStats __HotPatchDelegate_60(); // TypeDefIndex: 87001; 0x0000000185378C70-0x0000000185378CA0

	public delegate AudioMemoryMonitor.FExtraMemoryStats __HotPatchDelegate_61(); // TypeDefIndex: 87002; 0x000000018416D460-0x000000018416D4A0

	public delegate void __HotPatchDelegate_62(ulong P0, float P1, float P2); // TypeDefIndex: 87003; 0x000000018238E680-0x000000018238E6A0

	public delegate bool __HotPatchDelegate_63(ulong P0, object P1, object P2, object P3, object P4, bool P5, bool P6); // TypeDefIndex: 87004; 0x0000000184172110-0x0000000184172140

	public delegate bool __HotPatchDelegate_64(ulong P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, Quaternion P3, ulong P4, bool P5); // TypeDefIndex: 87005; 0x00000001878B17F0-0x00000001878B1870

	public delegate bool __HotPatchDelegate_65(ulong P0, AudioRoomData P1, ulong P2, object P3); // TypeDefIndex: 87006; 0x00000001878AEDC4-0x00000001878AEE18

	public delegate bool __HotPatchDelegate_66(ulong P0, ulong P1, ulong P2, UnityEngine.Vector3 P3, Quaternion P4, UnityEngine.Vector3 P5, bool P6, object P7); // TypeDefIndex: 87007; 0x00000001878B1300-0x00000001878B1398

	public delegate AudioAdapter.PayloadPostEvent __HotPatchDelegate_67(); // TypeDefIndex: 87008; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_68(out AudioChannelMask P0, out uint P1, out AudioChannelConfigType P2); // TypeDefIndex: 87009; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_69(object P0, uint P1, uint P2, uint P3, out ulong P4); // TypeDefIndex: 87010; 0x00000001812083C0-0x00000001812083E0

	public delegate bool __HotPatchDelegate_70(object P0, uint P1, out ulong P2); // TypeDefIndex: 87011; 0x00000001811DF7F0-0x00000001811DF810

	public delegate ulong __HotPatchDelegate_71(object P0, uint P1); // TypeDefIndex: 87012; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_72(ulong P0); // TypeDefIndex: 87013; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_73(bool P0); // TypeDefIndex: 87014; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_74(ulong P0, uint P1, uint P2); // TypeDefIndex: 87015; 0x00000001811DF7F0-0x00000001811DF810

	public delegate uint __HotPatchDelegate_75(int P0); // TypeDefIndex: 87016; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AsyncLoadBankTask __HotPatchDelegate_76(object P0); // TypeDefIndex: 87017; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate object __HotPatchDelegate_77(object P0); // TypeDefIndex: 87018; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IReadOnlyList<FVFBlockChunkInfo> __HotPatchDelegate_78(object P0, VFSFileTag P1, bool P2); // TypeDefIndex: 87019; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_79(object P0, int P1, ref AudioVFSLoader.VfsLoadedInfo P2); // TypeDefIndex: 87020; 0x00000001811DF7F0-0x00000001811DF810

	public delegate BankHandle __HotPatchDelegate_80(object P0, object P1); // TypeDefIndex: 87021; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_81(out List<uint> P0); // TypeDefIndex: 87022; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_82(ref AudioId P0); // TypeDefIndex: 87023; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_83(AudioId P0); // TypeDefIndex: 87024; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioId __HotPatchDelegate_84(uint P0); // TypeDefIndex: 87025; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioId __HotPatchDelegate_85(int P0); // TypeDefIndex: 87026; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioId __HotPatchDelegate_86(object P0); // TypeDefIndex: 87027; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate uint[] __HotPatchDelegate_87(object P0); // TypeDefIndex: 87028; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate uint __HotPatchDelegate_88(ref AudioState P0); // TypeDefIndex: 87029; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_89(ref AudioState P0, AudioState P1); // TypeDefIndex: 87030; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_90(ref AudioState P0, object P1); // TypeDefIndex: 87031; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_91(ref AudioState P0); // TypeDefIndex: 87032; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioDurationCallbackInfo __HotPatchDelegate_92(ref AudioCallbackInfo P0); // TypeDefIndex: 87033; 0x00000001811CBDB0-0x00000001811CBDF0

	public delegate void __HotPatchDelegate_93(object P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2, UnityEngine.Vector3 P3); // TypeDefIndex: 87034; 0x0000000182236C20-0x00000001822372D0

	public delegate EAudioDebugMsgFilter __HotPatchDelegate_94(); // TypeDefIndex: 87035; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_95(EAudioDebugMsgFilter P0); // TypeDefIndex: 87036; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_96(EAudioDebugMsgFilter P0, bool P1); // TypeDefIndex: 87037; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_97(EAudioDebugMsgFilter P0); // TypeDefIndex: 87038; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioDebugMsgItem[] __HotPatchDelegate_98(); // TypeDefIndex: 87039; 0x0000000185B44B70-0x0000000185B44B80

	public delegate long __HotPatchDelegate_99(); // TypeDefIndex: 87040; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_100(EAudioDebugMsgLevel P0, object P1, object P2, int P3); // TypeDefIndex: 87041; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_101(in AudioDebugAPIEmitterCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87042; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_102(in AudioDebugAPIEmitterPositionCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87043; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_103(in AudioDebugAPIEmitterMultiplePositionsCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87044; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_104(ulong P0, ushort P1, AkMultiPositionType P2, AKRESULT P3); // TypeDefIndex: 87045; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_105(EAudioDebugAPIEngineLifecycleOperation P0, bool P1, bool? P2); // TypeDefIndex: 87046; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_106(in AudioDebugAPIEngineCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87047; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_107(AudioDebugAPIRenderAudioCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87048; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_108(in AudioDebugAPIListenerCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87049; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_109(in AudioDebugAPIScePadOutputDeviceMappingMsg P0); // TypeDefIndex: 87050; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_110(in AudioDebugAPIOutputDeviceCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87051; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_111(EAudioDebugAPIOutputDeviceOperation P0, ulong P1, uint P2, AKRESULT? P3, uint? P4, uint? P5, uint? P6); // TypeDefIndex: 87052; 0x00000001811C5A40-0x00000001811C5A60

	public delegate void __HotPatchDelegate_112(in AudioDebugAPIOutputDeviceEffectCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87053; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_113(in AudioDebugAPIAudioSessionCallMsg P0); // TypeDefIndex: 87054; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_114(in AudioDebugAPIEventCallMsg P0); // TypeDefIndex: 87055; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_115(EAudioDebugMsgLevel P0, int P1, long P2); // TypeDefIndex: 87056; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_116(in AudioDebugAPIStateCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87057; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_117(EAudioDebugMsgLevel P0, int P1, int P2); // TypeDefIndex: 87058; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_118(in AudioDebugAPISwitchCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87059; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_119(EAudioDebugMsgLevel P0, int P1, int P2, long P3); // TypeDefIndex: 87060; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_120(in AudioDebugAPIEventActionCallMsg P0); // TypeDefIndex: 87061; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_121(in AudioDebugAPIEventSeekCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87062; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_122(in AudioDebugAPIRtpcCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87063; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_123(EAudioDebugMsgLevel P0, int P1, float P2, int P3, long P4); // TypeDefIndex: 87064; 0x00000001811DB3F0-0x00000001811DB410

	public delegate void __HotPatchDelegate_124(in AudioDebugAPIResourcePathCallMsg P0); // TypeDefIndex: 87065; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_125(in AudioDebugAPIFilePackageCallMsg P0); // TypeDefIndex: 87066; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_126(in AudioDebugAPIBankCallMsg P0); // TypeDefIndex: 87067; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_127(in AudioDebugAPIPrepareEventCallMsg P0); // TypeDefIndex: 87068; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_128(in AudioDebugAPIScePadDeviceCallMsg P0); // TypeDefIndex: 87069; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_129(in AudioDebugAPIScePadControllerInfoMsg P0); // TypeDefIndex: 87070; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_130(in AudioDebugAPIScePadAudioCallMsg P0); // TypeDefIndex: 87071; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_131(in AudioDebugAPIScePadLightBarCallMsg P0); // TypeDefIndex: 87072; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_132(in AudioDebugAPIScePadTriggerCallMsg P0); // TypeDefIndex: 87073; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_133(in AudioDebugAPISpatialSettingsCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87074; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_134(in AudioDebugAPIGeometryCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87075; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_135(in AudioDebugAPIRoomCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87076; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_136(in AudioDebugAPIPortalCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87077; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_137(in AudioDebugAPIReverbZoneCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87078; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_138(in AudioDebugAPIRemoveSpatialObjectCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87079; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_139(in AudioDebugAPIObstructionCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87080; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_140(in AudioDebugAPIGeometryInstanceCallMsg P0, AKRESULT? P1); // TypeDefIndex: 87081; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_141(uint P0, ulong P1, uint P2, uint P3); // TypeDefIndex: 87082; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_142(EAudioDebugMsgLevel P0, int P1, object P2); // TypeDefIndex: 87083; 0x00000001811DF7F0-0x00000001811DF810

	public delegate AudioDebugLevelScriptEventMsg __HotPatchDelegate_143(ref AudioDebugMsgItem P0); // TypeDefIndex: 87084; 0x0000000186464680-0x00000001864646B0

	public delegate AudioDebugAPIEmitterCallMsg __HotPatchDelegate_144(in AudioDebugMsgItem P0); // TypeDefIndex: 87085; 0x00000001811C4340-0x00000001811C4380

	public delegate AudioDebugAPIEmitterPositionCallMsg __HotPatchDelegate_145(in AudioDebugMsgItem P0); // TypeDefIndex: 87086; 0x00000001811C0280-0x00000001811C02D0

	public delegate AudioDebugAPIEmitterMultiplePositionsCallMsg __HotPatchDelegate_146(in AudioDebugMsgItem P0); // TypeDefIndex: 87087; 0x00000001811C4340-0x00000001811C4380

	public delegate AudioDebugAPIEngineCallMsg __HotPatchDelegate_147(in AudioDebugMsgItem P0); // TypeDefIndex: 87088; 0x00000001811C8690-0x00000001811C86D0

	public delegate AudioDebugAPIEngineLifecycleMsg __HotPatchDelegate_148(in AudioDebugMsgItem P0); // TypeDefIndex: 87089; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioDebugAPIRenderAudioCallMsg __HotPatchDelegate_149(in AudioDebugMsgItem P0); // TypeDefIndex: 87090; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioDebugAPIListenerCallMsg __HotPatchDelegate_150(in AudioDebugMsgItem P0); // TypeDefIndex: 87091; 0x00000001811C8690-0x00000001811C86D0

	public delegate AudioDebugAPIOutputDeviceCallMsg __HotPatchDelegate_151(in AudioDebugMsgItem P0); // TypeDefIndex: 87092; 0x00000001811C0280-0x00000001811C02D0

	public delegate AudioDebugAPIOutputDeviceEffectCallMsg __HotPatchDelegate_152(in AudioDebugMsgItem P0); // TypeDefIndex: 87093; 0x00000001811D4E00-0x00000001811D4E40

	public delegate AudioDebugAPIAudioSessionCallMsg __HotPatchDelegate_153(in AudioDebugMsgItem P0); // TypeDefIndex: 87094; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioDebugAPIScePadOutputDeviceMappingMsg __HotPatchDelegate_154(in AudioDebugMsgItem P0); // TypeDefIndex: 87095; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AudioDebugAPIEventCallMsg __HotPatchDelegate_155(in AudioDebugMsgItem P0); // TypeDefIndex: 87096; 0x00000001811C6FD0-0x00000001811C7010

	public delegate AudioDebugAPIStateCallMsg __HotPatchDelegate_156(in AudioDebugMsgItem P0); // TypeDefIndex: 87097; 0x00000001811C8690-0x00000001811C86D0

	public delegate AudioDebugAPISwitchCallMsg __HotPatchDelegate_157(in AudioDebugMsgItem P0); // TypeDefIndex: 87098; 0x00000001811C4340-0x00000001811C4380

	public delegate AudioDebugAPIEventActionCallMsg __HotPatchDelegate_158(in AudioDebugMsgItem P0); // TypeDefIndex: 87099; 0x00000001811C8690-0x00000001811C86D0

	public delegate AudioDebugAPIEventSeekCallMsg __HotPatchDelegate_159(in AudioDebugMsgItem P0); // TypeDefIndex: 87100; 0x00000001811C4340-0x00000001811C4380

	public delegate AudioDebugAPIRtpcCallMsg __HotPatchDelegate_160(in AudioDebugMsgItem P0); // TypeDefIndex: 87101; 0x00000001811C0280-0x00000001811C02D0

	public delegate AudioDebugAPIResourcePathCallMsg __HotPatchDelegate_161(in AudioDebugMsgItem P0); // TypeDefIndex: 87102; 0x00000001811D4E00-0x00000001811D4E40

	public delegate AudioDebugAPIFilePackageCallMsg __HotPatchDelegate_162(in AudioDebugMsgItem P0); // TypeDefIndex: 87103; 0x00000001811C8690-0x00000001811C86D0

	public delegate AudioDebugAPIBankCallMsg __HotPatchDelegate_163(in AudioDebugMsgItem P0); // TypeDefIndex: 87104; 0x00000001811C6FD0-0x00000001811C7010

	public delegate AudioDebugAPIPrepareEventCallMsg __HotPatchDelegate_164(in AudioDebugMsgItem P0); // TypeDefIndex: 87105; 0x00000001811CBDB0-0x00000001811CBDF0

	public delegate AudioDebugAPIScePadDeviceCallMsg __HotPatchDelegate_165(in AudioDebugMsgItem P0); // TypeDefIndex: 87106; 0x00000001811C8690-0x00000001811C86D0

	public delegate AudioDebugAPIScePadControllerInfoMsg __HotPatchDelegate_166(in AudioDebugMsgItem P0); // TypeDefIndex: 87107; 0x00000001811C4340-0x00000001811C4380

	public delegate AudioDebugAPIScePadAudioCallMsg __HotPatchDelegate_167(in AudioDebugMsgItem P0); // TypeDefIndex: 87108; 0x00000001811D4E00-0x00000001811D4E40

	public delegate AudioDebugAPIScePadLightBarCallMsg __HotPatchDelegate_168(in AudioDebugMsgItem P0); // TypeDefIndex: 87109; 0x0000000186464680-0x00000001864646B0

	public delegate AudioDebugAPIScePadTriggerCallMsg __HotPatchDelegate_169(in AudioDebugMsgItem P0); // TypeDefIndex: 87110; 0x00000001811C8690-0x00000001811C86D0

	public delegate AudioDebugAPISpatialSettingsCallMsg __HotPatchDelegate_170(in AudioDebugMsgItem P0); // TypeDefIndex: 87111; 0x00000001811CBDB0-0x00000001811CBDF0

	public delegate AudioDebugAPIGeometryCallMsg __HotPatchDelegate_171(in AudioDebugMsgItem P0); // TypeDefIndex: 87112; 0x00000001811C0280-0x00000001811C02D0

	public delegate AudioDebugAPIRoomCallMsg __HotPatchDelegate_172(in AudioDebugMsgItem P0); // TypeDefIndex: 87113; 0x00000001811C1EE0-0x00000001811C1F40

	public delegate AudioDebugAPIPortalCallMsg __HotPatchDelegate_173(in AudioDebugMsgItem P0); // TypeDefIndex: 87114; 0x00000001811F6F00-0x00000001811F6F60

	public delegate AudioDebugAPIReverbZoneCallMsg __HotPatchDelegate_174(in AudioDebugMsgItem P0); // TypeDefIndex: 87115; 0x00000001811C8690-0x00000001811C86D0

	public delegate AudioDebugAPIRemoveSpatialObjectCallMsg __HotPatchDelegate_175(in AudioDebugMsgItem P0); // TypeDefIndex: 87116; 0x00000001811D4E00-0x00000001811D4E40

	public delegate AudioDebugAPIObstructionCallMsg __HotPatchDelegate_176(in AudioDebugMsgItem P0); // TypeDefIndex: 87117; 0x00000001811C4340-0x00000001811C4380

	public delegate AudioDebugAPIGeometryInstanceCallMsg __HotPatchDelegate_177(in AudioDebugMsgItem P0); // TypeDefIndex: 87118; 0x00000001811C9C50-0x00000001811C9CA0

	public delegate AudioDebugEventEndMsg __HotPatchDelegate_178(in AudioDebugMsgItem P0); // TypeDefIndex: 87119; 0x00000001811D4E00-0x00000001811D4E40

	public delegate bool __HotPatchDelegate_179(AudioLogChannel P0); // TypeDefIndex: 87120; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_180(AudioLogChannel P0); // TypeDefIndex: 87121; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_181(AudioLogChannel P0, object P1); // TypeDefIndex: 87122; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_182(float P0, float P1, float P2); // TypeDefIndex: 87123; 0x0000000182235E70-0x0000000182235E90

	public delegate float __HotPatchDelegate_183(UnityEngine.Vector3 P0); // TypeDefIndex: 87124; 0x0000000182235FB0-0x0000000182235FE0

	public delegate void __HotPatchDelegate_184(uint P0); // TypeDefIndex: 87125; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_185(object P0, ref LinkedListNode<AudioAssetCache.EventCacheInfo> P1); // TypeDefIndex: 87126; 0x00000001859B7730-0x00000001859B7740

	public delegate LinkedList<AudioAssetCache.EventCacheInfo> __HotPatchDelegate_186(object P0); // TypeDefIndex: 87127; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_187(ulong P0, ushort P1); // TypeDefIndex: 87128; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_188(ulong P0, object P1); // TypeDefIndex: 87129; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_189(uint P0); // TypeDefIndex: 87130; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate uint __HotPatchDelegate_190(ReadOnlySpan<byte> P0); // TypeDefIndex: 87131; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate uint __HotPatchDelegate_191(IntPtr P0); // TypeDefIndex: 87132; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate uint __HotPatchDelegate_192(object P0, object P1); // TypeDefIndex: 87133; 0x00000001859B7730-0x00000001859B7740

	public delegate ulong __HotPatchDelegate_193(AkMemID P0); // TypeDefIndex: 87134; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_194(AudioUIUtil.UIAudioType P0); // TypeDefIndex: 87135; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_195(ref int P0, object P1); // TypeDefIndex: 87136; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_196(int P0, out VoiceData P1); // TypeDefIndex: 87137; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_197(ref int P0, object P1, object P2); // TypeDefIndex: 87138; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_198(object P0, object P1); // TypeDefIndex: 87139; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_199(object P0, out VoiceData P1, out int P2, object P3); // TypeDefIndex: 87140; 0x00000001811CDB70-0x00000001811CDB90
}
