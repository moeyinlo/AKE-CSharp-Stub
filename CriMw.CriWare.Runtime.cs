/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using CriWare;
using CriWare.CriMana;
using CriWare.CriMana.Detail;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Timeline;
using UnityEngine.UI;

// Image 33: CriMw.CriWare.Runtime.dll - Assembly: CriMw.CriWare.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54019-54348
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 54021
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 54022
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 54023
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 54024
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 54025
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace CriWare
{
	public class CriWarePS5 // TypeDefIndex: 54030
	{
		// Fields
		public const int SystemUserID = 255; // Metadata: 0x01FD628C
	
		// Nested types
		public enum AudioPortType : ushort // TypeDefIndex: 54026
		{
			Main = 0,
			Bgm = 1,
			Voice = 2,
			PadSpeaker = 3,
			Personal = 4,
			Aux = 5,
			Vibration = 6,
			ObjectMain = 256,
			ObjectVoice = 258,
			ObjecPersonal = 260
		}
	
		public enum AttributeId // TypeDefIndex: 54027
		{
			Pcm = 0,
			Gain = 1,
			Priority = 2,
			Position = 3,
			Spread = 4,
			Passthrough = 5,
			ResetState = 6,
			ApplicationSpecific = 7,
			Ambisonics = 8,
			Restricted = 9,
			MixToMainGain = 10,
			DebugName = 11,
			MAX = 16
		}
	
		public enum PortFlag : uint // TypeDefIndex: 54028
		{
			Restricted = 1,
			Passthrough = 2
		}
	
		internal static class SafeNativeMethods // TypeDefIndex: 54029
		{
			// Methods
			public static void criFsUnity_Setup_PS5(bool enable_apr_direct_mode) {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CriWarePS5() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static void SetupFileSystem(bool enableAprDirectMode) {} // 0x000000018350B670-0x000000018350B680
	}

	public static class CriAtomPlugin // TypeDefIndex: 54032
	{
		// Fields
		private static int initializationCount; // 0x00
		private static List<IntPtr> effectInterfaceList; // 0x08
		private static bool isConfigured; // 0x10
		private static float timeSinceStartup; // 0x14
		private static Common.CpuUsage cpuUsage; // 0x18
		private static int CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT; // 0x24
		private static ushort CRIATOMPARAMETER2_ID_INVALID; // 0x28
		private static ulong temporalStorage; // 0x30
	
		// Properties
		public static bool isInitialized { get; } // 0x00000001856C67F8-0x00000001856C6840 
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 54031; 0x000000018102B410-0x000000018102B420
	
		// Constructors
		static CriAtomPlugin() {} // 0x0000000183CA6330-0x0000000183CA6400
	
		// Methods
		public static void Log(string log) {} // 0x000000018350B670-0x000000018350B680
		public static void ExecuteQueuedCueLinkCallbacks() {} // 0x0000000182F8C7C0-0x0000000182F8C810
		public static void ExecuteQueuedEventCallbacks() {} // 0x0000000182F8C740-0x0000000182F8C790
		public static void ExecuteQueuedBeatSyncCallbacks() {} // 0x0000000182F8C6C0-0x0000000182F8C710
		public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list) {
			effect_interface_list = default;
			return default;
		} // 0x00000001856C619C-0x00000001856C62C0
		private static IntPtr GetSpatializerCoreInterfaceFromAtomOculusAudioBridge() => default; // 0x00000001856C65B0-0x00000001856C6748
		public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_aisacs, int max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, bool vr_mode) {} // 0x0000000183183A50-0x0000000183183BE0
		public static void SetConfigMonitorParametes(int max_preview_objects, int communication_buffer_size, int playback_position_update_interval) {} // 0x0000000183183380-0x00000001831833F0
		public static void SetConfigAdditionalParameters_EDITOR(bool enable_user_pcm_output, int user_pcm_buffer_length) {} // 0x0000000183183220-0x0000000183183270
		public static void SetConfigAdditionalParameters_PC(long buffering_time_pc) {} // 0x00000001831831D0-0x0000000183183220
		public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output, int pulse_latency_usec) {} // 0x00000001831832B0-0x0000000183183310
		public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios) {} // 0x0000000183183310-0x0000000183183380
		public static void SetConfigAdditionalParameters_ANDROID(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio, int stream_type) {} // 0x00000001831833F0-0x00000001831834A0
		public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders) {} // 0x000000018350B670-0x000000018350B680
		public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices) {} // 0x000000018350B670-0x000000018350B680
		public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports) {} // 0x000000018350B670-0x000000018350B680
		public static void SetConfigAdditionalParameters_SWITCH(bool enable_sonicsync, int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket) {} // 0x000000018350B670-0x000000018350B680
		public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices) {} // 0x000000018350B670-0x000000018350B680
		public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming) {} // 0x00000001856C67A0-0x00000001856C67F8
		public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig) => default; // 0x0000000183182EC0-0x0000000183182F00
		public static void InitializeLibrary() {} // 0x00000001831826A0-0x0000000183182860
		public static bool IsLibraryInitialized() => default; // 0x0000000183183140-0x0000000183183190
		public static void FinalizeLibrary() {} // 0x00000001856C5FE8-0x00000001856C619C
		public static void Pause(bool pause) {} // 0x00000001856C6748-0x00000001856C67A0
		public static Common.CpuUsage GetCpuUsage() => default; // 0x00000001856C62C0-0x00000001856C647C
		public static int GetOutputSamplingRate() => default; // 0x00000001856C6570-0x00000001856C65B0
		public static int GetOutputChannels() => default; // 0x00000001856C6530-0x00000001856C6570
		public static bool IsInitializedForPcmOutput() => default; // 0x000000018115F4C0-0x000000018115F530
		public static ushort GetLoopCountParameterId() => default; // 0x00000001856C647C-0x00000001856C6530
		public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce) {} // 0x00000001856C5F1C-0x00000001856C5FE8
		[AOT.MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
		private static ulong CallbackFromNative(IntPtr ptr1) => default; // 0x00000001856C5ECC-0x00000001856C5F1C
		private static extern void CRIWARE009CE561(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_aisacs, int max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, bool use_ambisonics, IntPtr spatializer_core_interface); // 0x00000001822C87F0-0x00000001822C8940
		private static extern void CRIWARE8384362B(uint max_preivew_objects, uint communication_buffer_size, int playback_position_update_interval); // 0x00000001822C7B50-0x00000001822C7BE0
		private static extern void CRIWARE237CA5E3(bool enable_user_pcm_out_mode); // 0x0000000183183270-0x00000001831832B0
		private static extern void CRIWARE780E6ED2(long buffering_time_pc); // 0x00000001822C87B0-0x00000001822C87F0
		private static extern void CRIWAREE996B258(int output, int pulse_latency_usec); // 0x00000001822C8770-0x00000001822C87B0
		private static extern void CRIWARE2F034134(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios); // 0x00000001822C7AB0-0x00000001822C7B50
		private static extern void CRIWARE70981A20(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool apply_hw_property, int stream_type); // 0x00000001822C79F0-0x00000001822C7AB0
		private static extern void CRIWARE2626EF5B(); // 0x0000000183182860-0x0000000183182890
		public static extern bool CRIWAREC176B113(); // 0x0000000183183190-0x00000001831831D0
		private static extern void CRIWARE63E1F278(); // 0x00000001856C5CF8-0x00000001856C5D24
		private static extern void CRIWAREB64E0C3B(bool pause); // 0x00000001856C5DDC-0x00000001856C5E10
		public static extern uint CRIWAREA703719E(); // 0x00000001856C5DB0-0x00000001856C5DDC
		public static extern void CRIWAREBF97E87F(int code); // 0x00000001856C5E10-0x00000001856C5E44
		public static extern void CRIWARE15B0037A(IntPtr cbfunc, string separator_string); // 0x00000001856C5AA0-0x00000001856C5B38
		public static extern void CRIWARE28E5ABA4(IntPtr cbfunc); // 0x00000001856C5B6C-0x00000001856C5BA0
		private static extern void CRIWARECCA1268B(); // 0x0000000182F8C790-0x0000000182F8C7C0
		public static extern void CRIWARE88175F19(IntPtr cbfunc); // 0x00000001856C5D50-0x00000001856C5D84
		private static extern void CRIWARE7581CF8C(); // 0x0000000182F8C710-0x0000000182F8C740
		public static extern void CRIWARE15F30D07(IntPtr cbfunc); // 0x00000001856C5B38-0x00000001856C5B6C
		private static extern void CRIWARED1FD92AA(); // 0x0000000182F8C810-0x0000000182F8C960
		private static extern void CRIWARE2CFF30B7(int sampling_rate_for_memory, int sampling_rate_for_streaming); // 0x00000001856C5BA0-0x00000001856C5BE0
		public static extern void CRIWARE797E0462(); // 0x00000001856C5D24-0x00000001856C5D50
		public static extern void CRIWAREC54D0552(); // 0x00000001856C5E44-0x00000001856C5E70
		public static extern void CRIWARE5BC8942D(IntPtr acb_hn, CallbackFromNativeDelegate func, IntPtr obj); // 0x00000001856C5C58-0x00000001856C5CF8
		public static extern ushort CRIWARE5B1C5B3B(int id); // 0x00000001856C5BE0-0x00000001856C5C58
		private static extern bool CRIWAREE097EA6E(); // 0x00000001856C5E70-0x00000001856C5EA0
		private static extern int CRIWAREE320F01B(); // 0x00000001856C5EA0-0x00000001856C5ECC
		private static extern int CRIWARE98A6BE5C(); // 0x00000001856C5D84-0x00000001856C5DB0
	}

	[Serializable]
	public class CriAtomCueSheet // TypeDefIndex: 54033
	{
		// Fields
		public string name; // 0x10
		public string acbFile; // 0x18
		public string awbFile; // 0x20
		public CriAtomExAcb acb; // 0x28
		public CriAtomExAcbLoader.Status loaderStatus; // 0x30
	
		// Properties
		public bool IsLoading { get => default; } // 0x00000001856B62D4-0x00000001856B62DC 
		public bool IsError { get => default; } // 0x00000001856B62B8-0x00000001856B62D4 
	
		// Constructors
		public CriAtomCueSheet() {} // 0x00000001856B6250-0x00000001856B62B8
	}

	[AddComponentMenu("CRIWARE/CRI Atom")]
	public class CriAtom : CriMonoBehaviour // TypeDefIndex: 54037
	{
		// Fields
		public string acfFile; // 0x28
		private bool acfIsLoading; // 0x30
		public CriAtomCueSheet[] cueSheets; // 0x38
		public string dspBusSetting; // 0x40
		public bool dontDestroyOnLoad; // 0x48
		private static CriAtomExSequencer.EventCallback eventUserCallback; // 0x00
		private static CriAtomExSequencer.EventCbFunc eventUserCbFunc; // 0x08
		private static CriAtomExBeatSync.CbFunc obsoleteBeatSyncFunc; // 0x18
		private GCHandle acfRegisterGCHandle; // 0x50
		public bool dontRemoveExistsCueSheet; // 0x58
	
		// Properties
		private static CriAtom instance { get; set; } // 0x00000001856CAB68-0x00000001856CABA0 0x00000001856CAD00-0x00000001856CAD54
		public static bool CueSheetsAreLoading { get => default; } // 0x00000001856CAAD4-0x00000001856CAB68 
	
		// Events
		internal static event CriAtomExSequencer.EventCallback OnEventSequencerCallback;
		private static event CriAtomExBeatSync.CbFunc beatsyncUserCbFunc;
		internal static event CriAtomExBeatSync.CbFunc OnBeatSyncCallback;
		private static event CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc;
		internal static event CriAtomEx.CueLinkCbFunc OnCueLinkCallback;
	
		// Constructors
		public CriAtom() {} // 0x00000001856CA8F0-0x00000001856CA974
	
		// Methods
		public static void AttachDspBusSetting(string settingName) {} // 0x00000001856C9024-0x00000001856C90A4
		public static void DetachDspBusSetting() {} // 0x00000001856C92B8-0x00000001856C9324
		public static CriAtomCueSheet GetCueSheet(string name) => default; // 0x00000001856C94EC-0x00000001856C9518
		public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, CriFsBinder binder = null) => default; // 0x00000001856C8F7C-0x00000001856C9024
		public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, CriFsBinder binder = null, bool loadAwbOnMemory = false /* Metadata: 0x01FD62B1 */) => default; // 0x00000001856C8CA8-0x00000001856C8D48
		public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null) => default; // 0x00000001856C8EB4-0x00000001856C8F7C
		public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null, bool loadAwbOnMemory = false /* Metadata: 0x01FD62B2 */) => default; // 0x00000001856C8BE8-0x00000001856C8CA8
		public static void RemoveCueSheet(string name) {} // 0x00000001856CA080-0x00000001856CA0F8
		public static CriAtomExAcb GetAcb(string cueSheetName) => default; // 0x00000001856C9324-0x00000001856C9414
		public static void SetCategoryVolume(string name, float volume) {} // 0x00000001856BFD84-0x00000001856BFD8C
		public static void SetCategoryVolume(int id, float volume) {} // 0x00000001856BFD7C-0x00000001856BFD84
		public static float GetCategoryVolume(string name) => default; // 0x00000001856BFCF8-0x00000001856BFD00
		public static float GetCategoryVolume(int id) => default; // 0x00000001856BFD00-0x00000001856BFD08
		public static void SetBusAnalyzer(string busName, bool sw) {} // 0x00000001856CA2AC-0x00000001856CA2DC
		public static void SetBusAnalyzer(bool sw) {} // 0x00000001856CA2DC-0x00000001856CA308
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName) => default; // 0x00000001856C9414-0x00000001856C9444
		[Obsolete("Use CriAtom.GetBusAnalyzerInfo(string busName)")]
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId) => default; // 0x00000001856C9444-0x00000001856C9470
		public void Setup() {} // 0x00000001856CA41C-0x00000001856CA63C
		public void Shutdown() {} // 0x00000001856CA63C-0x00000001856CA72C
		private void Awake() {} // 0x00000001856C90A4-0x00000001856C9210
		protected override void OnEnable() {} // 0x00000001856C9B64-0x00000001856C9BD4
		private void OnDestroy() {} // 0x00000001856C9A70-0x00000001856C9B64
		public override void CriInternalUpdate() {} // 0x000000018350B670-0x000000018350B680
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
		public CriAtomCueSheet GetCueSheetInternal(string name) => default; // 0x00000001856C9470-0x00000001856C94EC
		public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder) => default; // 0x00000001856C8D48-0x00000001856C8EB4
		public void RemoveCueSheetInternal(string name) {} // 0x00000001856C9F18-0x00000001856CA080
		private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet) {} // 0x00000001856C98D0-0x00000001856C9A70
		private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile) => default; // 0x00000001856C97D8-0x00000001856C98D0
		private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile) => default; // 0x00000001856C961C-0x00000001856C96CC
		private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory) {} // 0x00000001856C96CC-0x00000001856C9714
		[IteratorStateMachine(typeof(_LoadAcbFileCoroutine_d__62))]
		private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory) => default; // 0x00000001856C9714-0x00000001856C97D8
		private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory) {} // 0x00000001856C9518-0x00000001856C9558
		[IteratorStateMachine(typeof(_LoadAcbDataCoroutine_d__64))]
		private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory) => default; // 0x00000001856C9558-0x00000001856C961C
		[AOT.MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCbFunc))]
		public static void SequenceEventCallbackFromNative(string eventString) {} // 0x00000001856CA14C-0x00000001856CA1A0
		[AOT.MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCallback))]
		private static void SequenceCallbackFromNative(ref CriAtomExSequencer.CriAtomExSequenceEventInfo criAtomExSequenceInfo) {} // 0x00000001856CA0F8-0x00000001856CA14C
		[AOT.MonoPInvokeCallback(typeof(CriAtomExBeatSync.CbFunc))]
		public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info) {} // 0x00000001856C9210-0x00000001856C9264
		[AOT.MonoPInvokeCallback(typeof(CriAtomEx.CueLinkCbFunc))]
		public static void CueLinkCallbackFromNative(ref CriAtomEx.CueLinkInfo info) {} // 0x00000001856C9264-0x00000001856C92B8
		public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator) {} // 0x00000001856CA308-0x00000001856CA41C
		private static void RegisterEventCallbackChain(CriAtomExSequencer.EventCallback func) {} // 0x00000001856C9DB4-0x00000001856C9F18
		private static void UnregisterEventCallbackChain(CriAtomExSequencer.EventCallback func) {} // 0x00000001856CA804-0x00000001856CA8F0
		public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func) {} // 0x00000001856CA1A0-0x00000001856CA2AC
		private static void RegisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func) {} // 0x00000001856C9BD4-0x00000001856C9CC4
		private static void UnregisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func) {} // 0x00000001856CA72C-0x00000001856CA798
		private static void RegisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func) {} // 0x00000001856C9CC4-0x00000001856C9DB4
		private static void UnregisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func) {} // 0x00000001856CA798-0x00000001856CA804
	}

	[AddComponentMenu("CRIWARE/CRI Atom Listener")]
	public class CriAtomListener : CriMonoBehaviour // TypeDefIndex: 54038
	{
		// Fields
		[SerializeField]
		private CriAtomRegion regionOnStart; // 0x30
		public bool activateListenerOnEnable; // 0x38
		private static List<CriAtomListener> listenersList; // 0x00
		private static CriAtomEx3dListener dummyNativeListener; // 0x08
		private Vector3 lastPosition; // 0x3C
		private CriAtomRegion currentRegion; // 0x48
		private bool _isActive; // 0x50
	
		// Properties
		public CriAtomEx3dListener nativeListener { get; protected set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public bool isActive { get => default; set {} } // 0x0000000183D4F000-0x0000000183D4F010 0x00000001856C5350-0x00000001856C53B0
		public CriAtomRegion region3d { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x00000001856C53B0-0x00000001856C556C
	
		// Constructors
		public CriAtomListener() {} // 0x00000001856C5344-0x00000001856C5350
		static CriAtomListener() {} // 0x0000000183CE4CF0-0x0000000183CE4D80
	
		// Methods
		public static void CreateDummyNativeListener() {} // 0x0000000183183570-0x0000000183183650
		public static void DestroyDummyNativeListener() {} // 0x00000001856C4F30-0x00000001856C4FCC
		private void Awake() {} // 0x00000001856C4E04-0x00000001856C4F20
		private void Start() {} // 0x00000001856C50F0-0x00000001856C5154
		protected override void OnEnable() {} // 0x00000001856C50CC-0x00000001856C50F0
		protected override void OnDisable() {} // 0x00000001856C50A8-0x00000001856C50CC
		private void OnDestroy() {} // 0x00000001856C4FCC-0x00000001856C50A8
		public override void CriInternalUpdate() {} // 0x000000018350B670-0x000000018350B680
		public override void CriInternalLateUpdate() {} // 0x00000001856C4F20-0x00000001856C4F30
		private void UpdatePosition() {} // 0x00000001856C5154-0x00000001856C5344
		public void ActivateListener(bool exclusive = true /* Metadata: 0x01FD62B3 */) {} // 0x00000001856C4C60-0x00000001856C4E04
	}

	public class CriAtomOutputDeviceObserver : CriMonoBehaviour // TypeDefIndex: 54042
	{
		// Fields
		[SerializeField]
		private bool dontDestroyOnLoad; // 0x28
		private bool lastIsConnected; // 0x29
		private bool isConnected; // 0x2A
		private OutputDeviceType lastDeviceType; // 0x2C
		private OutputDeviceType deviceType; // 0x30
		private static CriAtomOutputDeviceObserver instance; // 0x00
	
		// Properties
		public static bool IsDeviceConnected { get => default; } // 0x00000001856C5988-0x00000001856C59E8 
		public static OutputDeviceType DeviceType { get => default; } // 0x00000001856C5928-0x00000001856C5988 
	
		// Events
		public static event DeviceConnectionChangeCallback OnDeviceConnectionChanged;
		private static event DeviceConnectionChangeCallback _onDeviceConnectionChanged;
	
		// Nested types
		public enum OutputDeviceType // TypeDefIndex: 54039
		{
			BuiltinSpeaker = 0,
			WiredDevice = 1,
			WirelessDevice = 2
		}
	
		public delegate void DeviceConnectionChangeCallback(bool isConnected, OutputDeviceType deviceType); // TypeDefIndex: 54040; 0x0000000182065C10-0x0000000182065C20
	
		private static class UnsafeNativeMethods // TypeDefIndex: 54041
		{
		}
	
		// Constructors
		public CriAtomOutputDeviceObserver() {} // 0x0000000183772780-0x0000000183772790
	
		// Methods
		private void Awake() {} // 0x00000001856C556C-0x00000001856C56C0
		private void OnDestroy() {} // 0x00000001856C5744-0x00000001856C57D8
		public override void CriInternalUpdate() {} // 0x00000001856C56C0-0x00000001856C5744
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("CRIWARE/CRI Atom Region")]
	[DisallowMultipleComponent]
	public class CriAtomRegion : CriMonoBehaviour // TypeDefIndex: 54043
	{
		// Fields
		internal List<CriAtomSourceBase> referringSources; // 0x30
		internal List<CriAtomListener> referringListeners; // 0x38
		internal List<CriAtomTransceiver> referringTransceivers; // 0x40
	
		// Properties
		public CriAtomEx3dRegion region3dHn { get; protected set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
		// Constructors
		public CriAtomRegion() {} // 0x00000001856C6B08-0x00000001856C6C1C
	
		// Methods
		private void Awake() {} // 0x00000001856C6840-0x00000001856C6848
		protected override void OnEnable() {} // 0x00000001856C6AE8-0x00000001856C6B08
		private void OnDestroy() {} // 0x00000001856C6AE0-0x00000001856C6AE8
		protected virtual void InternalInitialize() {} // 0x00000001856C6A5C-0x00000001856C6AE0
		protected virtual void InternalFinalize() {} // 0x00000001856C68A4-0x00000001856C6A5C
		protected virtual void InitializeParameters() {} // 0x00000001856C6848-0x00000001856C68A4
		public override void CriInternalUpdate() {} // 0x000000018350B670-0x000000018350B680
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
	}

	public class CriAtomServer : CriMonoBehaviour // TypeDefIndex: 54044
	{
		// Fields
		private static CriAtomServer _instance; // 0x00
		public Action<bool> onApplicationPausePreProcess; // 0x28
		public Action<bool> onApplicationPausePostProcess; // 0x30
		public static bool KeepPlayingSoundOnPause; // 0x08
		public static bool EnableAutoConsumePcmOutput; // 0x09
	
		// Properties
		public static CriAtomServer instance { get => default; } // 0x00000001856C6E28-0x00000001856C6E7C 
	
		// Constructors
		public CriAtomServer() {} // 0x0000000183772780-0x0000000183772790
		static CriAtomServer() {} // 0x0000000183D04B40-0x0000000183D04BC0
	
		// Methods
		public static void CreateInstance() {} // 0x000000018268E010-0x000000018268E0D0
		public static void DestroyInstance() {} // 0x00000001856C6C1C-0x00000001856C6CC0
		private void Awake() {} // 0x0000000183CB6550-0x0000000183CB6620
		protected override void OnEnable() {} // 0x0000000183D4D9B0-0x0000000183D4D9C0
		protected override void OnDisable() {} // 0x00000001856C6CC8-0x00000001856C6D80
		public override void CriInternalUpdate() {} // 0x0000000182F8C640-0x0000000182F8C6C0
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
		private void ConsumePcmOutput() {} // 0x000000018350B670-0x000000018350B680
		private void OnApplicationPause(bool appPause) {} // 0x00000001856C6CC0-0x00000001856C6CC8
		private void ProcessApplicationPause(bool appPause) {} // 0x00000001856C6D80-0x00000001856C6E28
	}

	[AddComponentMenu("CRIWARE/CRI Atom Source")]
	public class CriAtomSource : CriAtomSourceBase // TypeDefIndex: 54046
	{
		// Fields
		[SerializeField]
		private string _cueName; // 0xA0
		[SerializeField]
		private string _cueSheet; // 0xA8
	
		// Properties
		public string cueName { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public string cueSheet { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
	
		// Constructors
		public CriAtomSource() {} // 0x00000001856C7EE4-0x00000001856C7F4C
	
		// Methods
		public override CriAtomExPlayback Play() => default; // 0x00000001856C7ED4-0x00000001856C7EE4
		protected override CriAtomExAcb GetAcb() => default; // 0x00000001856C7DF4-0x00000001856C7E20
		protected override void PlayOnStart() {} // 0x00000001856C7E94-0x00000001856C7ED4
		[IteratorStateMachine(typeof(_PlayAsync_d__11))]
		private IEnumerator PlayAsync(string cueName) => default; // 0x00000001856C7E20-0x00000001856C7E94
	}

	public abstract class CriAtomSourceBase : CriMonoBehaviour // TypeDefIndex: 54048
	{
		// Fields
		protected bool initialized; // 0x38
		protected Vector3 lastPosition; // 0x3C
		protected bool hasValidPosition; // 0x48
		private CriAtomRegion currentRegion; // 0x50
		private CriAtomListener currentListener; // 0x58
		[SerializeField]
		private bool _playOnStart; // 0x60
		[SerializeField]
		private CriAtomRegion _regionOnStart; // 0x68
		[SerializeField]
		private CriAtomListener _listenerOnStart; // 0x70
		[SerializeField]
		private bool _use3dPositioning; // 0x78
		[SerializeField]
		private bool _freezeOrientation; // 0x79
		[SerializeField]
		private bool _loop; // 0x7A
		[SerializeField]
		private float _volume; // 0x7C
		[SerializeField]
		private float _pitch; // 0x80
		[SerializeField]
		private bool _androidUseLowLatencyVoicePool; // 0x84
		[SerializeField]
		private bool need_to_player_update_all; // 0x85
		[SerializeField]
		private bool _use3dRandomization; // 0x86
		[SerializeField]
		private uint _randomPositionListMaxLength; // 0x88
		[SerializeField]
		private CriAtomEx.Randomize3dConfig randomize3dConfig; // 0x90
	
		// Properties
		public CriAtomExPlayer player { get; protected set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public CriAtomEx3dSource source { get; protected set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public bool playOnStart { get; set; } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000183D519B0-0x0000000183D519C0
		public bool use3dPositioning { get; set; } // 0x0000000183D4F800-0x0000000183D4F810 0x00000001856C7CB8-0x00000001856C7CF0
		public bool freezeOrientation { get; set; } // 0x0000000183D51AE0-0x0000000183D51AF0 0x0000000183D51B40-0x0000000183D51B50
		public bool use3dRandomization { get; set; } // 0x0000000183D51B10-0x0000000183D51B20 0x00000001856C7CF0-0x00000001856C7DC0
		public uint randomPositionListMaxLength { get; set; } // 0x0000000183D4F0B0-0x0000000183D4F0C0 0x00000001856C7A28-0x00000001856C7A98
		public CriAtomRegion region3d { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x00000001856C7A98-0x00000001856C7C88
		public CriAtomListener listener { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x00000001856C78CC-0x00000001856C7990
		public CriAtomRegion regionOnStart { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public CriAtomListener listenerOnStart { get; set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public bool loop { get; set; } // 0x0000000183D51AF0-0x0000000183D51B00 0x0000000183D51B50-0x0000000183D51B60
		public float volume { get; set; } // 0x0000000183D51B20-0x0000000183D51B30 0x00000001856C7DC0-0x00000001856C7DF4
		public float pitch { get; set; } // 0x0000000183D51B00-0x0000000183D51B10 0x00000001856C79F0-0x00000001856C7A28
		public float pan3dAngle { get; set; } // 0x00000001856C77CC-0x00000001856C77F4 0x00000001856C7990-0x00000001856C79C0
		public float pan3dDistance { get; set; } // 0x00000001856C77F4-0x00000001856C781C 0x00000001856C79C0-0x00000001856C79F0
		public int startTime { get; set; } // 0x00000001856C781C-0x00000001856C7844 0x00000001856C7C88-0x00000001856C7CB8
		public long time { get; } // 0x00000001856C786C-0x00000001856C7890 
		public Status status { get; } // 0x00000001856C7844-0x00000001856C786C 
		public bool attenuationDistanceSetting { get; set; } // 0x00000001856C77A8-0x00000001856C77CC 0x00000001856C7890-0x00000001856C78CC
		public bool androidUseLowLatencyVoicePool { get; set; } // 0x0000000183D51AD0-0x0000000183D51AE0 0x0000000183D51B30-0x0000000183D51B40
	
		// Nested types
		public enum Status // TypeDefIndex: 54047
		{
			Stop = 0,
			Prep = 1,
			Playing = 2,
			PlayEnd = 3,
			Error = 4
		}
	
		// Constructors
		protected CriAtomSourceBase() {} // 0x00000001856C774C-0x00000001856C77A8
	
		// Methods
		protected void SetNeedToPlayerUpdateAll() {} // 0x0000000183D51AC0-0x0000000183D51AD0
		protected virtual void InternalInitialize() {} // 0x00000001856C6FB8-0x00000001856C7090
		protected virtual void InternalFinalize() {} // 0x00000001856C6F20-0x00000001856C6FB8
		private void Awake() {} // 0x00000001856C6EB0-0x00000001856C6EB8
		protected override void OnEnable() {} // 0x00000001856C7114-0x00000001856C7140
		private void OnDestroy() {} // 0x00000001856C710C-0x00000001856C7114
		protected bool SetInitialSourcePosition() => default; // 0x00000001856C743C-0x00000001856C74C4
		protected virtual void SetInitialParameters() {} // 0x00000001856C7384-0x00000001856C743C
		protected virtual void UpdatePosition() {} // 0x00000001856C7584-0x00000001856C774C
		private void Start() {} // 0x00000001856C74C4-0x00000001856C7570
		public override void CriInternalUpdate() {} // 0x000000018350B670-0x000000018350B680
		public override void CriInternalLateUpdate() {} // 0x00000001856C6EB8-0x00000001856C6F00
		public abstract CriAtomExPlayback Play();
		protected abstract CriAtomExAcb GetAcb();
		protected abstract void PlayOnStart();
		public CriAtomExPlayback Play(string cueName) => default; // 0x00000001856C7170-0x00000001856C71E4
		public CriAtomExPlayback Play(int cueId) => default; // 0x00000001856C71E4-0x00000001856C7254
		protected CriAtomExPlayback InternalPlayCue() => default; // 0x00000001856C7090-0x00000001856C70E8
		public void Stop() {} // 0x00000001856C7570-0x00000001856C7584
		public void Pause(bool sw) {} // 0x00000001856C7140-0x00000001856C7170
		public bool IsPaused() => default; // 0x00000001856C70E8-0x00000001856C710C
		public void SetBusSendLevel(string busName, float level) {} // 0x00000001856C7354-0x00000001856C7384
		[Obsolete("Use CriAtomSource.SetBusSendLevel(string, float)")]
		public void SetBusSendLevel(int busId, float level) {} // 0x00000001856C7324-0x00000001856C7354
		public void SetBusSendLevelOffset(string busName, float levelOffset) {} // 0x00000001856C72F4-0x00000001856C7324
		[Obsolete("Use CriAtomSource.SetBusSendLevelOffset(string, float)")]
		public void SetBusSendLevelOffset(int busId, float levelOffset) {} // 0x00000001856C72C4-0x00000001856C72F4
		public void SetAisacControl(string controlName, float value) {} // 0x00000001856C7254-0x00000001856C7284
		[Obsolete("Use CriAtomSource.SetAisacControl")]
		public void SetAisac(string controlName, float value) {} // 0x00000001856C72BC-0x00000001856C72C4
		public void SetAisacControl(uint controlId, float value) {} // 0x00000001856C7284-0x00000001856C72B4
		[Obsolete("Use CriAtomSource.SetAisacControl")]
		public void SetAisac(uint controlId, float value) {} // 0x00000001856C72B4-0x00000001856C72BC
		public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer) {} // 0x00000001856C6E7C-0x00000001856C6EB0
		public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer) {} // 0x00000001856C6F00-0x00000001856C6F20
	}

	[AddComponentMenu("CRIWARE/CRI Atom Transceiver")]
	[DisallowMultipleComponent]
	public class CriAtomTransceiver : CriMonoBehaviour // TypeDefIndex: 54050
	{
		// Fields
		[SerializeField]
		private CriAtomRegion regionOnStart; // 0x58
		[SerializeField]
		private bool useDedicatedInput; // 0x60
		[SerializeField]
		private GameObject dedicatedInput; // 0x68
		[Range(0f, 1f)]
		[SerializeField]
		private float outputVolume; // 0x70
		[SerializeField]
		private float directAudioRadius; // 0x74
		[SerializeField]
		private float crossFadeDistance; // 0x78
		[Range(0f, 360f)]
		[SerializeField]
		private float coneInsideAngle; // 0x7C
		[Range(0f, 360f)]
		[SerializeField]
		private float coneOutsideAngle; // 0x80
		[Range(0f, 1f)]
		[SerializeField]
		private float coneOutsideVolume; // 0x84
		[SerializeField]
		private float transceiverRadius; // 0x88
		[SerializeField]
		private float interiorDistance; // 0x8C
		[SerializeField]
		public float minAttenuation; // 0x90
		[SerializeField]
		public float maxAttenuation; // 0x94
		[SerializeField]
		private string globalAisacName; // 0x98
		[SerializeField]
		private float maxAngleAisacDelta; // 0xA0
		[SerializeField]
		private string distanceAisacControlId; // 0xA8
		[SerializeField]
		private string listenerAzimuthAisacControlId; // 0xB0
		[SerializeField]
		private string listenerElevationAisacControlId; // 0xB8
		[SerializeField]
		private string outputAzimuthAisacControlId; // 0xC0
		[SerializeField]
		private string outputElevationAisacControlId; // 0xC8
		[NonSerialized]
		public bool inspectorAisacSettingFoldout; // 0xD0
		private bool isInitialized; // 0xD1
		private bool dedicatedInputNotSetWarned; // 0xD2
		private CriAtomRegion currentRegion; // 0xD8
	
		// Properties
		public CriAtomEx3dTransceiver transceiverHn { get; protected set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public Vector3 inputPos { get; private set; } // 0x0000000183D51B80-0x0000000183D51BA0 0x0000000183D51BB0-0x0000000183D51BC0
		public Vector3 inputFront { get; private set; } // 0x0000000183D51B60-0x0000000183D51B80 0x0000000183D51BA0-0x0000000183D51BB0
		public Vector3 inputUp { get; private set; } // 0x0000000183D50020-0x0000000183D50040 0x0000000183D50040-0x0000000183D50050
		public CriAtomRegion region3d { get => default; set {} } // 0x0000000183D4E7B0-0x0000000183D4E7C0 0x00000001856C8A10-0x00000001856C8BE8
	
		// Nested types
		private delegate void SetControlIdMethod(ushort id); // TypeDefIndex: 54049; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public CriAtomTransceiver() {} // 0x00000001856C88BC-0x00000001856C8A10
	
		// Methods
		private void Awake() {} // 0x00000001856C85A4-0x00000001856C85AC
		private void Start() {} // 0x00000001856C8754-0x00000001856C87B8
		protected override void OnEnable() {} // 0x00000001856C8734-0x00000001856C8754
		private void OnDestroy() {} // 0x00000001856C872C-0x00000001856C8734
		protected virtual void InternalInitialize() {} // 0x00000001856C86A0-0x00000001856C872C
		protected virtual void InternalFinalize() {} // 0x00000001856C8628-0x00000001856C86A0
		protected virtual void InitializeParameters() {} // 0x00000001856C85B4-0x00000001856C8628
		public override void CriInternalUpdate() {} // 0x000000018350B670-0x000000018350B680
		public override void CriInternalLateUpdate() {} // 0x00000001856C85AC-0x00000001856C85B4
		private void ApplyCurrentPosition() {} // 0x00000001856C7F4C-0x00000001856C8284
		private void ApplyParameters() {} // 0x00000001856C8284-0x00000001856C85A4
		private void TrySetAisacControlId(string strId, SetControlIdMethod callback) {} // 0x00000001856C87B8-0x00000001856C88BC
	}

	public class CriStructMemory<Type> : IDisposable // TypeDefIndex: 54051
	{
		// Fields
		private GCHandle gch;
	
		// Properties
		public byte[] bytes { get; private set; }
		public IntPtr ptr { get => default; }
	
		// Constructors
		public CriStructMemory() {}
		public CriStructMemory(int num) {}
	
		// Methods
		public void Dispose() {}
	}

	public static class CriAtomEx // TypeDefIndex: 54081
	{
		// Fields
		public const uint InvalidAisacControlId = 4294967295; // Metadata: 0x01FD62BC
		public static readonly Dictionary<Randomize3dCalcType, Randomize3dParamType[]> randomize3dParamTable; // 0x00
	
		// Events
		public static event CueLinkCbFunc OnCueLinkCallback;
	
		// Nested types
		public enum CharacterEncoding // TypeDefIndex: 54052
		{
			Utf8 = 0,
			Sjis = 1
		}
	
		public enum SoundRendererType // TypeDefIndex: 54053
		{
			Default = 0,
			Native = 1,
			Hw1 = 1,
			Asr = 2,
			Haptic = 3,
			Hw2 = 9
		}
	
		public enum VoiceAllocationMethod // TypeDefIndex: 54054
		{
			Once = 0,
			Retry = 1
		}
	
		public enum BiquadFilterType // TypeDefIndex: 54055
		{
			Off = 0,
			LowPass = 1,
			HighPass = 2,
			Notch = 3,
			LowShelf = 4,
			HighShelf = 5,
			Peaking = 6
		}
	
		public enum ResumeMode // TypeDefIndex: 54056
		{
			AllPlayback = 0,
			PausedPlayback = 1,
			PreparedPlayback = 2
		}
	
		public enum PanType // TypeDefIndex: 54057
		{
			Unknown = -1,
			Pan3d = 0,
			Pos3d = 1,
			Auto = 2
		}
	
		public enum VoiceControlMethod // TypeDefIndex: 54058
		{
			PreferLast = 0,
			PreferFirst = 1
		}
	
		public enum Parameter // TypeDefIndex: 54059
		{
			Volume = 0,
			Pitch = 1,
			Pan3dAngle = 2,
			Pan3dDistance = 3,
			Pan3dVolume = 4,
			BusSendLevel0 = 9,
			BusSendLevel1 = 10,
			BusSendLevel2 = 11,
			BusSendLevel3 = 12,
			BusSendLevel4 = 13,
			BusSendLevel5 = 14,
			BusSendLevel6 = 15,
			BusSendLevel7 = 16,
			BandPassFilterCofLow = 17,
			BandPassFilterCofHigh = 18,
			BiquadFilterType = 19,
			BiquadFilterFreq = 20,
			BiquadFIlterQ = 21,
			BiquadFilterGain = 22,
			EnvelopeAttackTime = 23,
			EnvelopeHoldTime = 24,
			EnvelopeDecayTime = 25,
			EnvelopeReleaseTime = 26,
			EnvelopeSustainLevel = 27,
			StartTime = 28,
			Priority = 31
		}
	
		public enum Speaker // TypeDefIndex: 54060
		{
			FrontLeft = 0,
			FrontRight = 1,
			FrontCenter = 2,
			LowFrequency = 3,
			SurroundLeft = 4,
			SurroundRight = 5,
			SurroundBackLeft = 6,
			SurroundBackRight = 7
		}
	
		public enum Format : uint // TypeDefIndex: 54061
		{
			ADX = 1,
			HCA = 3,
			HCA_MX = 4,
			WAVE = 5,
			RAW_PCM = 6,
			AUDIO_BUFFER = 9
		}
	
		private enum SpeakerSystem : uint // TypeDefIndex: 54062
		{
			Surround_5_1 = 0,
			Surround_7_1 = 1
		}
	
		public struct SpeakerAngles6ch // TypeDefIndex: 54063
		{
			// Fields
			public float frontLeft; // 0x00
			public float frontRight; // 0x04
			public float frontCenter; // 0x08
			public float lowFrequency; // 0x0C
			public float surroundLeft; // 0x10
			public float surroundRight; // 0x14
	
			// Methods
			public static SpeakerAngles6ch Default() => default; // 0x0000000183D51C00-0x0000000183D51C30
		}
	
		public struct SpeakerAngles8ch // TypeDefIndex: 54064
		{
			// Fields
			public float frontLeft; // 0x00
			public float frontRight; // 0x04
			public float frontCenter; // 0x08
			public float lowFrequency; // 0x0C
			public float surroundLeft; // 0x10
			public float surroundRight; // 0x14
			public float surroundBackLeft; // 0x18
			public float surroundBackRight; // 0x1C
	
			// Methods
			public static SpeakerAngles8ch Default() => default; // 0x0000000183D51C30-0x0000000183D51C70
		}
	
		public struct FormatInfo // TypeDefIndex: 54065
		{
			// Fields
			public Format format; // 0x00
			public int samplingRate; // 0x04
			public long numSamples; // 0x08
			public long loopOffset; // 0x10
			public long loopLength; // 0x18
			public int numChannels; // 0x20
			public uint reserved; // 0x24
		}
	
		public struct AisacControlInfo // TypeDefIndex: 54066
		{
			// Fields
			public readonly string name; // 0x00
			public uint id; // 0x08
	
			// Constructors
			public AisacControlInfo(byte[] data, int startIndex) {
				name = default;
				id = default;
			} // 0x00000001856B59D0-0x00000001856B5A78
		}
	
		public enum Randomize3dCalcType // TypeDefIndex: 54067
		{
			None = -1,
			Rectangle = 0,
			Cuboid = 1,
			Circle = 2,
			Cylinder = 3,
			Sphere = 4,
			List = 6
		}
	
		public enum Randomize3dParamType // TypeDefIndex: 54068
		{
			None = 0,
			Width = 1,
			Depth = 2,
			Height = 3,
			Radius = 4
		}
	
		[Serializable]
		public struct Randomize3dConfig // TypeDefIndex: 54069
		{
			// Fields
			public const int NumOfCalcParams = 3; // Metadata: 0x01FD631D
			[SerializeField]
			private bool followsOriginalSource; // 0x00
			[SerializeField]
			private Randomize3dCalcType calculationType; // 0x04
			[SerializeField]
			private float[] calculationParameters; // 0x08
	
			// Properties
			public bool FollowsOriginalSource { get => default; } // 0x0000000183D51020-0x0000000183D51030 
			public Randomize3dCalcType CalculationType { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
			public float CalculationParameter1 { get => default; } // 0x00000001856CBC54-0x00000001856CBC80 
			public float CalculationParameter2 { get => default; } // 0x00000001856CBC80-0x00000001856CBCAC 
			public float CalculationParameter3 { get => default; } // 0x00000001856CBCAC-0x00000001856CBCD8 
	
			// Constructors
			internal Randomize3dConfig(byte[] data, int startIndex) : this() {
				followsOriginalSource = default;
				calculationType = default;
				calculationParameters = default;
			} // 0x00000001856CBAF0-0x00000001856CBBF4
			public Randomize3dConfig(bool followsOriginalSource, Randomize3dCalcType calculationType, float param1 = 0f /* Metadata: 0x01FD630D */, float param2 = 0f /* Metadata: 0x01FD6311 */, float param3 = 0f /* Metadata: 0x01FD6315 */) : this() {
				this.followsOriginalSource = default;
				this.calculationType = default;
				calculationParameters = default;
			} // 0x00000001856CBA24-0x00000001856CBAF0
			public Randomize3dConfig(int dummy) : this() {
				followsOriginalSource = default;
				calculationType = default;
				calculationParameters = default;
			} // 0x00000001856CBBF4-0x00000001856CBC54
	
			// Methods
			public void ClearCalcParams(float initVal = 0f /* Metadata: 0x01FD6319 */) {} // 0x00000001856CB648-0x00000001856CB680
			public bool GetParamByType(Randomize3dParamType paramType, ref float paramVal) => default; // 0x00000001856CB680-0x00000001856CB84C
			public bool SetParamByType(Randomize3dParamType paramType, float paramVal) => default; // 0x00000001856CB84C-0x00000001856CBA24
		}
	
		public struct CuePos3dInfo // TypeDefIndex: 54070
		{
			// Fields
			public float coneInsideAngle; // 0x00
			public float coneOutsideAngle; // 0x04
			public float minAttenuationDistance; // 0x08
			public float maxAttenuationDistance; // 0x0C
			public float sourceRadius; // 0x10
			public float interiorDistance; // 0x14
			public float dopplerFactor; // 0x18
			public Randomize3dConfig randomPos; // 0x20
			public uint distanceAisacControl; // 0x30
			public uint listenerBaseAngleAisacControl; // 0x34
			public uint sourceBaseAngleAisacControl; // 0x38
			public uint listenerBaseElevationAisacControl; // 0x3C
			public uint sourceBaseElevationAisacControl; // 0x40
	
			// Constructors
			public CuePos3dInfo(byte[] data, int startIndex) {
				coneInsideAngle = default;
				coneOutsideAngle = default;
				minAttenuationDistance = default;
				maxAttenuationDistance = default;
				sourceRadius = default;
				interiorDistance = default;
				dopplerFactor = default;
				randomPos = default;
				distanceAisacControl = default;
				listenerBaseAngleAisacControl = default;
				sourceBaseAngleAisacControl = default;
				listenerBaseElevationAisacControl = default;
				sourceBaseElevationAisacControl = default;
			} // 0x00000001856CB0AC-0x00000001856CB204
		}
	
		public struct GameVariableInfo // TypeDefIndex: 54071
		{
			// Fields
			public readonly string name; // 0x00
			public uint id; // 0x08
			public float gameValue; // 0x0C
	
			// Constructors
			public GameVariableInfo(byte[] data, int startIndex) {
				name = default;
				id = default;
				gameValue = default;
			} // 0x00000001856CB3E0-0x00000001856CB49C
			public GameVariableInfo(string name, uint id, float gameValue) {
				this.name = default;
				this.id = default;
				this.gameValue = default;
			} // 0x00000001856CB49C-0x00000001856CB4C0
		}
	
		public enum CueType // TypeDefIndex: 54072
		{
			Polyphonic = 0,
			Sequential = 1,
			Shuffle = 2,
			Random = 3,
			RandomNoRepeat = 4,
			SwitchGameVariable = 5,
			ComboSequential = 6,
			SwitchSelector = 7,
			TrackTransitionBySelector = 8
		}
	
		public struct CueInfo // TypeDefIndex: 54073
		{
			// Fields
			public int id; // 0x00
			public CueType type; // 0x04
			public readonly string name; // 0x08
			public readonly string userData; // 0x10
			public long length; // 0x18
			public ushort[] categories; // 0x20
			public short numLimits; // 0x28
			public ushort numBlocks; // 0x2A
			public ushort numTracks; // 0x2C
			public ushort numRelatedWaveForms; // 0x2E
			public byte priority; // 0x30
			public byte headerVisibility; // 0x31
			public byte ignore_player_parameter; // 0x32
			public byte probability; // 0x33
			public PanType panType; // 0x34
			public CuePos3dInfo pos3dInfo; // 0x38
			public GameVariableInfo gameVariableInfo; // 0x80
	
			// Constructors
			public CueInfo(byte[] data, int startIndex) {
				id = default;
				type = default;
				name = default;
				userData = default;
				length = default;
				categories = default;
				numLimits = default;
				numBlocks = default;
				numTracks = default;
				numRelatedWaveForms = default;
				priority = default;
				headerVisibility = default;
				ignore_player_parameter = default;
				probability = default;
				panType = default;
				pos3dInfo = default;
				gameVariableInfo = default;
			} // 0x00000001856CAD54-0x00000001856CB02C
		}
	
		public struct WaveformInfo // TypeDefIndex: 54074
		{
			// Fields
			public int waveId; // 0x00
			public uint format; // 0x04
			public int samplingRate; // 0x08
			public int numChannels; // 0x0C
			public long numSamples; // 0x10
			public bool streamingFlag; // 0x18
			public uint[] reserved; // 0x20
	
			// Constructors
			public WaveformInfo(byte[] data, int startIndex) {
				waveId = default;
				format = default;
				samplingRate = default;
				numChannels = default;
				numSamples = default;
				streamingFlag = default;
				reserved = default;
			} // 0x00000001856CD754-0x00000001856CD910
		}
	
		public struct AisacInfo // TypeDefIndex: 54075
		{
			// Fields
			public readonly string name; // 0x00
			public bool defaultControlFlag; // 0x08
			public float defaultControlValue; // 0x0C
			public uint controlId; // 0x10
			public readonly string controlName; // 0x18
	
			// Constructors
			public AisacInfo(byte[] data, int startIndex) {
				name = default;
				defaultControlFlag = default;
				defaultControlValue = default;
				controlId = default;
				controlName = default;
			} // 0x00000001856B5B6C-0x00000001856B5C60
		}
	
		public struct PerformanceInfo // TypeDefIndex: 54076
		{
			// Fields
			public uint serverProcessCount; // 0x00
			public uint lastServerTime; // 0x04
			public uint maxServerTime; // 0x08
			public uint averageServerTime; // 0x0C
			public uint lastServerInterval; // 0x10
			public uint maxServerInterval; // 0x14
			public uint averageServerInterval; // 0x18
		}
	
		public struct ResourceUsage // TypeDefIndex: 54077
		{
			// Fields
			public uint useCount; // 0x00
			public uint limit; // 0x04
		}
	
		public struct NativeVector // TypeDefIndex: 54078
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float z; // 0x08
	
			// Constructors
			public NativeVector(float x, float y, float z) {
				this.x = default;
				this.y = default;
				this.z = default;
			} // 0x0000000183D51BD0-0x0000000183D51BE0
			public NativeVector(Vector3 vector) {
				x = default;
				y = default;
				z = default;
			} // 0x0000000183D51BE0-0x0000000183D51C00
		}
	
		public struct CueLinkInfo // TypeDefIndex: 54079
		{
			// Fields
			public IntPtr nativePlayerHn; // 0x00
			public uint basePlaybackId; // 0x08
			public uint targetPlaybackId; // 0x0C
			public int cueLinkType; // 0x10
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void CueLinkCbFunc(ref CueLinkInfo info); // TypeDefIndex: 54080; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		static CriAtomEx() {} // 0x00000001838C3D10-0x00000001838C3F80
	
		// Methods
		public static void SetSpeakerAngle(SpeakerAngles6ch speakerAngle) {} // 0x00000001856C3BC8-0x00000001856C3C18
		public static void SetSpeakerAngle(SpeakerAngles8ch speakerAngle) {} // 0x00000001856C3C18-0x00000001856C3C68
		public static void SetVirtualSpeakerAngle(SpeakerAngles6ch speakerAngle) {} // 0x00000001856C3C68-0x00000001856C3CB8
		public static void SetVirtualSpeakerAngle(SpeakerAngles8ch speakerAngle) {} // 0x00000001856C3CB8-0x00000001856C3D08
		public static void ControlVirtualSpeakerSetting(bool sw) {} // 0x00000001856C32B0-0x00000001856C32FC
		public static void RegisterAcf(CriFsBinder binder, string acfPath) {} // 0x00000001856C3868-0x00000001856C38CC
		public static void RegisterAcf(IntPtr acfData, int dataSize) {} // 0x00000001856C38CC-0x00000001856C3924
		[Obsolete("Use RegisterAcf(IntPtr) instead")]
		public static void RegisterAcf(byte[] acfData) {} // 0x00000001856C380C-0x00000001856C3868
		public static void UnregisterAcf() {} // 0x00000001856C3D48-0x00000001856C3D88
		public static string GetAppliedDspBusSnapshotName() => default; // 0x00000001856C3388-0x00000001856C33F0
		public static void AttachDspBusSetting(string settingName) {} // 0x00000001856C3260-0x00000001856C32B0
		public static void DetachDspBusSetting() {} // 0x00000001856C32FC-0x00000001856C333C
		public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms) {} // 0x00000001856C3208-0x00000001856C3260
		public static int GetNumGameVariables() => default; // 0x00000001856C3700-0x00000001856C3740
		public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info) {
			info = default;
			return default;
		} // 0x00000001856C345C-0x00000001856C362C
		public static float GetGameVariable(uint game_variable_id) => default; // 0x00000001856C3678-0x00000001856C36C0
		public static float GetGameVariable(string game_variable_name) => default; // 0x00000001856C362C-0x00000001856C3678
		public static void SetGameVariable(uint game_variable_id, float game_variable_value) {} // 0x00000001856C39C0-0x00000001856C3A18
		public static void SetGameVariable(string game_variable_name, float game_variable_value) {} // 0x00000001856C3964-0x00000001856C39C0
		public static void SetRandomSeed(uint seed) {} // 0x0000000183182F00-0x0000000183182F50
		public static void ResetPerformanceMonitor() {} // 0x00000001856C3924-0x00000001856C3964
		public static void GetPerformanceInfo(out PerformanceInfo info) {
			info = default;
		} // 0x00000001856C3740-0x00000001856C378C
		public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index) {} // 0x00000001856C3A18-0x00000001856C3A74
		public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name) {} // 0x00000001856C3A74-0x00000001856C3AD0
		public static void Lock() {} // 0x00000001856C37CC-0x00000001856C380C
		public static void Unlock() {} // 0x00000001856C3D08-0x00000001856C3D48
		public static void SetOutputAudioDevice_PC(string deviceId) {} // 0x00000001856C3AD0-0x00000001856C3B78
		public static bool LoadAudioDeviceList_PC() => default; // 0x00000001856C378C-0x00000001856C37CC
		public static int GetNumAudioDevices_PC() => default; // 0x00000001856C36C0-0x00000001856C3700
		public static string GetAudioDeviceName_PC(int index) => default; // 0x00000001856C33F0-0x00000001856C345C
		public static void SetOutputAudioDevice_PC(int index) {} // 0x00000001856C3B78-0x00000001856C3BC8
		public static void SetOutputVolume_VITA(float volume) {} // 0x000000018350B670-0x000000018350B680
		public static bool IsBgmPortAcquired_VITA() => default; // 0x000000018232EB60-0x000000018232EB70
		public static bool IsSoundStopped_IOS() => default; // 0x000000018115F4C0-0x000000018115F530
		public static void EnableAudioSessionRestoration_IOS(bool flag) {} // 0x000000018350B670-0x000000018350B680
		public static void EnableBusSendOffsetWhenLevelNotExist(bool enable) {} // 0x00000001856C333C-0x00000001856C3388
		private static extern bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize); // 0x00000001856C4468-0x00000001856C452C
		private static extern void criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize); // 0x00000001856C431C-0x00000001856C43BC
		private static extern void criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize); // 0x00000001856C43BC-0x00000001856C4468
		private static extern void criAtomEx_UnregisterAcf(); // 0x00000001856C4838-0x00000001856C48A0
		private static extern void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize); // 0x00000001856C3F14-0x00000001856C3FBC
		private static extern void criAtomEx_DetachDspBusSetting(); // 0x00000001856C4034-0x00000001856C409C
		private static extern void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms); // 0x00000001856C3EC0-0x00000001856C3F14
		private static extern IntPtr criAtomEx_GetAppliedDspBusSnapshotName(); // 0x00000001856C4114-0x00000001856C417C
		private static extern int criAtomEx_GetNumGameVariables(); // 0x00000001856C4288-0x00000001856C42B4
		private static extern bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info); // 0x00000001856C41FC-0x00000001856C4288
		private static extern float criAtomEx_GetGameVariableById(uint game_variable_id); // 0x00000001856C417C-0x00000001856C41A8
		private static extern float criAtomEx_GetGameVariableByName(string game_variable_name); // 0x00000001856C41A8-0x00000001856C41FC
		private static extern void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value); // 0x00000001856C452C-0x00000001856C4568
		private static extern void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value); // 0x00000001856C4568-0x00000001856C45C0
		private static extern void criAtomEx_SetRandomSeed(uint seed); // 0x00000001822C8020-0x00000001822C80A0
		private static extern void criAtomEx_Lock(); // 0x00000001856C42B4-0x00000001856C431C
		private static extern void criAtomEx_Unlock(); // 0x00000001856C47D0-0x00000001856C4838
		private static extern void criAtom_ResetPerformanceMonitor(); // 0x00000001856C4AE0-0x00000001856C4B48
		private static extern void criAtom_GetPerformanceInfo(out PerformanceInfo info); // 0x00000001856C4A68-0x00000001856C4AE0
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index); // 0x00000001856C3D90-0x00000001856C3E14
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name); // 0x00000001856C3E14-0x00000001856C3EC0
		private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array); // 0x00000001856C45C0-0x00000001856C4644
		private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array); // 0x00000001856C4644-0x00000001856C46C8
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array); // 0x00000001856C46C8-0x00000001856C474C
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array); // 0x00000001856C474C-0x00000001856C47D0
		private static extern void criAtomEx_ControlVirtualSpeakerSetting(bool sw); // 0x00000001856C3FBC-0x00000001856C4034
		private static extern void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(bool enable); // 0x00000001856C409C-0x00000001856C4114
		private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType soundRendererType, string deviceId); // 0x00000001856C4BCC-0x00000001856C4C58
		private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType type, IntPtr deviceId); // 0x00000001856C4B48-0x00000001856C4BCC
		private static extern bool criAtomUnity_LoadAudioDeviceList_PC(); // 0x00000001856C49F8-0x00000001856C4A68
		private static extern int criAtomUnity_GetNumAudioDevices_PC(); // 0x00000001856C4990-0x00000001856C49F8
		private static extern IntPtr criAtomUnity_GetAudioDeviceName_PC(int index); // 0x00000001856C4918-0x00000001856C4990
		private static extern IntPtr criAtomUnity_GetAudioDeviceId_PC(int index); // 0x00000001856C48A0-0x00000001856C4918
	}

	public static class CriAtomExCategory // TypeDefIndex: 54095
	{
		// Nested types
		public enum ReactType // TypeDefIndex: 54082
		{
			Ducker = 0,
			AisacModulationTrigger = 1
		}
	
		public enum ReactDuckerTargetType // TypeDefIndex: 54083
		{
			Volume = 0,
			AisacControlValue = 1
		}
	
		public enum ReactDuckerCurveType // TypeDefIndex: 54084
		{
			Linear = 0,
			Square = 1,
			SquareReverse = 2,
			SCurve = 3,
			FlatAtHalf = 4
		}
	
		public struct ReactFadeParameter // TypeDefIndex: 54085
		{
			// Fields
			public ReactDuckerCurveType curveType; // 0x00
			public float curveStrength; // 0x04
			public ushort fadeTimeMs; // 0x08
		}
	
		public enum ReactHoldType // TypeDefIndex: 54086
		{
			WhilePlaying = 0,
			FixedTime = 1
		}
	
		public struct ReactDuckerParameter // TypeDefIndex: 54090
		{
			// Fields
			public Target target; // 0x00
			public ReactDuckerTargetType targetType; // 0x08
			public ReactFadeParameter entry; // 0x0C
			public ReactFadeParameter exit; // 0x18
			public ReactHoldType holdType; // 0x24
			public ushort holdTimeMs; // 0x28
	
			// Nested types
			public struct Volume // TypeDefIndex: 54087
			{
				// Fields
				public float level; // 0x00
			}
	
			public struct AisacControl // TypeDefIndex: 54088
			{
				// Fields
				public uint id; // 0x00
				public float value; // 0x04
			}
	
			public struct Target // TypeDefIndex: 54089
			{
				// Fields
				public CriWare.CriAtomExCategory.ReactDuckerParameter.Volume volume; // 0x00
				public AisacControl aisacControl; // 0x00
			}
		}
	
		public struct ReactAisacModulationParameter // TypeDefIndex: 54091
		{
			// Fields
			private int _enableDecrementAisacModulationKey; // 0x00
			public uint decrementAisacModulationKey; // 0x04
			private int _enableIncrementAisacModulationKey; // 0x08
			public uint incrementAisacModulationKey; // 0x0C
	
			// Properties
			public bool enableDecrementAisacModulationKey { get => default; } // 0x00000001856CBCD8-0x00000001856CBCE0 
			public bool enableIncrementAisacModulationKey { get => default; } // 0x00000001856CBCE0-0x00000001856CBCE8 
		}
	
		public struct ReactParameter // TypeDefIndex: 54093
		{
			// Fields
			public Parameter parameter; // 0x00
			public ReactType type; // 0x2C
			public bool enablePausingCue; // 0x30
	
			// Nested types
			public struct Parameter // TypeDefIndex: 54092
			{
				// Fields
				public ReactDuckerParameter ducker; // 0x00
				public ReactAisacModulationParameter aisacModulation; // 0x00
			}
		}
	
		public enum ReactStatus // TypeDefIndex: 54094
		{
			Stop = 0,
			FadeOut = 1,
			Hold = 2,
			FadeIn = 3,
			Error = 4
		}
	
		// Methods
		public static void SetVolume(string name, float volume) {} // 0x00000001856BFD84-0x00000001856BFD8C
		public static void SetVolume(int id, float volume) {} // 0x00000001856BFD7C-0x00000001856BFD84
		public static float GetVolume(string name) => default; // 0x00000001856BFCF8-0x00000001856BFD00
		public static float GetVolume(int id) => default; // 0x00000001856BFD00-0x00000001856BFD08
		public static void Mute(string name, bool mute) {} // 0x00000001856BFD38-0x00000001856BFD40
		public static void Mute(int id, bool mute) {} // 0x00000001856BFD40-0x00000001856BFD48
		public static bool IsMuted(string name) => default; // 0x00000001856BFD10-0x00000001856BFD18
		public static bool IsMuted(int id) => default; // 0x00000001856BFD08-0x00000001856BFD10
		public static void Solo(string name, bool solo, float muteVolume) {} // 0x00000001856BFD94-0x00000001856BFD9C
		public static void Solo(int id, bool solo, float muteVolume) {} // 0x00000001856BFD8C-0x00000001856BFD94
		public static bool IsSoloed(string name) => default; // 0x00000001856BFD30-0x00000001856BFD38
		public static bool IsSoloed(int id) => default; // 0x00000001856BFD28-0x00000001856BFD30
		public static void Pause(string name, bool pause) {} // 0x00000001856BFD48-0x00000001856BFD50
		public static void Pause(int id, bool pause) {} // 0x00000001856BFD50-0x00000001856BFD58
		public static bool IsPaused(string name) => default; // 0x00000001856BFD18-0x00000001856BFD20
		public static bool IsPaused(int id) => default; // 0x00000001856BFD20-0x00000001856BFD28
		public static void SetAisacControl(string name, string controlName, float value) {} // 0x00000001856BFD60-0x00000001856BFD68
		[Obsolete("Use CriAtomExCategory.SetAisacControl")]
		public static void SetAisac(string name, string controlName, float value) {} // 0x00000001856BFD60-0x00000001856BFD68
		public static void SetAisacControl(int id, int controlId, float value) {} // 0x00000001856BFD58-0x00000001856BFD60
		[Obsolete("Use CriAtomExCategory.SetAisacControl")]
		public static void SetAisac(int id, int controlId, float value) {} // 0x00000001856BFD58-0x00000001856BFD60
		public static void SetReactParameter(string name, ReactParameter parameter) {} // 0x00000001856BFD68-0x00000001856BFD7C
		public static bool GetReactParameter(string name, out ReactParameter parameter) {
			parameter = default;
			return default;
		} // 0x00000001856BFCE8-0x00000001856BFCF0
		public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
			aisacInfo = default;
			return default;
		} // 0x00000001856BF8FC-0x00000001856BFAE8
		public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
			aisacInfo = default;
			return default;
		} // 0x00000001856BFAE8-0x00000001856BFCE0
		public static bool GetCurrentAisacControlValue(string categoryName, string aisacControlName, out float controlValue) {
			controlValue = default;
			return default;
		} // 0x00000001856BFCE0-0x00000001856BFCE8
		public static ReactStatus GetReactStatus(string reactName) => default; // 0x00000001856BFCF0-0x00000001856BFCF8
		private static extern void criAtomExCategory_SetVolumeByName(string name, float volume); // 0x00000001856C0804-0x00000001856C0854
		private static extern float criAtomExCategory_GetVolumeByName(string name); // 0x00000001856C0150-0x00000001856C01A4
		private static extern void criAtomExCategory_SetVolumeById(int id, float volume); // 0x00000001856C07C8-0x00000001856C0804
		private static extern float criAtomExCategory_GetVolumeById(int id); // 0x00000001856C0124-0x00000001856C0150
		private static extern void criAtomExCategory_MuteById(int id, bool mute); // 0x00000001856C03E4-0x00000001856C0468
		private static extern bool criAtomExCategory_IsMutedById(int id); // 0x00000001856C01A4-0x00000001856C021C
		private static extern void criAtomExCategory_MuteByName(string name, bool mute); // 0x00000001856C0468-0x00000001856C0500
		private static extern bool criAtomExCategory_IsMutedByName(string name); // 0x00000001856C021C-0x00000001856C02BC
		private static extern void criAtomExCategory_SoloById(int id, bool solo, float volume); // 0x00000001856C0854-0x00000001856C089C
		private static extern bool criAtomExCategory_IsSoloedById(int id); // 0x00000001856C0350-0x00000001856C0388
		private static extern void criAtomExCategory_SoloByName(string name, bool solo, float volume); // 0x00000001856C089C-0x00000001856C08FC
		private static extern bool criAtomExCategory_IsSoloedByName(string name); // 0x00000001856C0388-0x00000001856C03E4
		private static extern void criAtomExCategory_PauseById(int id, bool pause); // 0x00000001856C0500-0x00000001856C0584
		private static extern bool criAtomExCategory_IsPausedById(int id); // 0x00000001856C02BC-0x00000001856C02F4
		private static extern void criAtomExCategory_PauseByName(string name, bool pause); // 0x00000001856C0584-0x00000001856C05DC
		private static extern bool criAtomExCategory_IsPausedByName(string name); // 0x00000001856C02F4-0x00000001856C0350
		private static extern void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value); // 0x00000001856C05DC-0x00000001856C0628
		private static extern void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value); // 0x00000001856C0628-0x00000001856C069C
		private static extern void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter); // 0x00000001856C069C-0x00000001856C07C8
		private static extern bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter); // 0x00000001856BFFAC-0x00000001856C00CC
		private static extern bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo); // 0x00000001856BFD9C-0x00000001856BFE30
		private static extern bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo); // 0x00000001856BFE30-0x00000001856BFEE4
		private static extern bool criAtomExCategory_GetCurrentAisacControlValueByName(string category_name, string aisac_control_name, out float control_value); // 0x00000001856BFEE4-0x00000001856BFFAC
		private static extern ReactStatus criAtomExCategory_GetReactStatus(string react_name); // 0x00000001856C00CC-0x00000001856C0124
	}

	public static class CriAtomExSequencer // TypeDefIndex: 54099
	{
		// Events
		public static event EventCallback OnCallback;
	
		// Nested types
		public struct CriAtomExSequenceEventInfo // TypeDefIndex: 54096
		{
			// Fields
			public ulong position; // 0x00
			public IntPtr playerHn; // 0x08
			public readonly string tag; // 0x10
			public uint playbackId; // 0x18
			private int type; // 0x1C
			public uint id; // 0x20
			private uint reserved; // 0x24
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void EventCbFunc(string eventParamsString); // TypeDefIndex: 54097; 0x0000000182149960-0x0000000182149970
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void EventCallback(ref CriAtomExSequenceEventInfo criAtomExSequenceInfo); // TypeDefIndex: 54098; 0x0000000182149960-0x0000000182149970
	
		// Methods
		[Obsolete("SetEventCallback is deprecated. Use CriAtomExSequencer.OnCallback event", false)]
		public static void SetEventCallback(EventCbFunc func, string separator = "\t" /* Metadata: 0x01FD6337 */) {} // 0x00000001856C31F0-0x00000001856C31F8
	}

	public static class CriAtomExBeatSync // TypeDefIndex: 54102
	{
		// Events
		public static event CbFunc OnCallback;
	
		// Nested types
		public struct Info // TypeDefIndex: 54100
		{
			// Fields
			public IntPtr playerHn; // 0x00
			public uint playbackId; // 0x08
			public uint barCount; // 0x0C
			public uint beatCount; // 0x10
			public float beatProgress; // 0x14
			public float bpm; // 0x18
			public int offset; // 0x1C
			public uint numBeats; // 0x20
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void CbFunc(ref Info info); // TypeDefIndex: 54101; 0x0000000182149960-0x0000000182149970
	
		// Methods
		[Obsolete("SetCallback is deprecated. Use OnBeatSyncCallback event", false)]
		public static void SetCallback(CbFunc func) {} // 0x00000001856BF8E4-0x00000001856BF8EC
	}

	public class CriAtomExAsr // TypeDefIndex: 54105
	{
		// Nested types
		private struct BusAnalyzerConfig // TypeDefIndex: 54103
		{
			// Fields
			public int interval; // 0x00
			public int peakHoldTime; // 0x04
		}
	
		public struct BusAnalyzerInfo // TypeDefIndex: 54104
		{
			// Fields
			public int numChannels; // 0x00
			public float[] rmsLevels; // 0x08
			public float[] peakLevels; // 0x10
			public float[] peakHoldLevels; // 0x18
	
			// Constructors
			public BusAnalyzerInfo(byte[] data) {
				numChannels = default;
				rmsLevels = default;
				peakLevels = default;
				peakHoldLevels = default;
			} // 0x00000001856B5C60-0x00000001856B5E84
		}
	
		// Constructors
		public CriAtomExAsr() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime) {} // 0x00000001856BE56C-0x00000001856BE58C
		public static void AttachBusAnalyzer(int interval, int peakHoldTime) {} // 0x00000001856BE540-0x00000001856BE56C
		public static void DetachBusAnalyzer(string busName) {} // 0x00000001856BE58C-0x00000001856BE594
		public static void DetachBusAnalyzer() {} // 0x00000001856BE594-0x00000001856BE5B4
		public static void GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info) {
			info = default;
		} // 0x00000001856BE770-0x00000001856BE924
		[Obsolete("Use CriAtomExAsr.GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info)")]
		public static void GetBusAnalyzerInfo(int busId, out BusAnalyzerInfo info) {
			info = default;
		} // 0x00000001856BE5B4-0x00000001856BE770
		public static void SetBusVolume(string busName, float volume) {} // 0x00000001856BE96C-0x00000001856BE974
		[Obsolete("Use CriAtomExAsr.SetBusVolume(string busName, float volume)")]
		public static void SetBusVolume(int busId, float volume) {} // 0x00000001856BE974-0x00000001856BE97C
		public static void SetBusSendLevel(string busName, string sendTo, float level) {} // 0x00000001856BE964-0x00000001856BE96C
		[Obsolete("Use CriAtomExAsr.SetBusSendLevel(string busName, string sendTo, float level)")]
		public static void SetBusSendLevel(int busId, int sendTo, float level) {} // 0x00000001856BE95C-0x00000001856BE964
		public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix) {} // 0x00000001856BE94C-0x00000001856BE95C
		[Obsolete("Use CriAtomExAsr.SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix)")]
		public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, float[] matrix) {} // 0x00000001856BE93C-0x00000001856BE94C
		public static void SetEffectBypass(string busName, string effectName, bool bypass) {} // 0x00000001856BE97C-0x00000001856BE984
		public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue) {} // 0x00000001856BE984-0x00000001856BE9BC
		public static float GetEffectParameter(string busName, string effectName, uint parameterIndex) => default; // 0x00000001856BE92C-0x00000001856BE934
		public static bool RegisterEffectInterface(IntPtr afx_interface) => default; // 0x00000001856BE934-0x00000001856BE93C
		public static void UnregisterEffectInterface(IntPtr afx_interface) {} // 0x00000001856BE9BC-0x00000001856BE9C4
		public static void GetBusVolume(string busName, out float volume) {
			volume = default;
		} // 0x00000001856BE924-0x00000001856BE92C
		public static int GetPcmOutput(int outputChannels, int outputSamples, float[][] buffer) => default; // 0x0000000181002730-0x0000000181002740
		public static int GetNumBufferedPcmOutputSamples() => default; // 0x0000000181002730-0x0000000181002740
		public static void SetPcmBufferSize(int numSamples) {} // 0x000000018350B670-0x000000018350B680
		private static extern void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config); // 0x00000001856BE9C4-0x00000001856BEA5C
		private static extern void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config); // 0x00000001856BEA5C-0x00000001856BEAE0
		private static extern void criAtomExAsr_DetachBusAnalyzerByName(string busName); // 0x00000001856BEAE0-0x00000001856BEB6C
		private static extern void criAtomExAsr_DetachBusAnalyzer(int busNo); // 0x00000001856BEB6C-0x00000001856BEBE4
		private static extern void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info); // 0x00000001856BEBE4-0x00000001856BEC7C
		private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info); // 0x00000001856BEC7C-0x00000001856BED00
		private static extern void criAtomExAsr_SetBusVolumeByName(string busName, float volume); // 0x00000001856BF07C-0x00000001856BF0D4
		private static extern void criAtomExAsr_SetBusVolume(int busNo, float volume); // 0x00000001856BF0D4-0x00000001856BF110
		private static extern void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level); // 0x00000001856BEFC0-0x00000001856BF034
		private static extern void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level); // 0x00000001856BF034-0x00000001856BF07C
		private static extern void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix); // 0x00000001856BEE58-0x00000001856BEF18
		private static extern void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix); // 0x00000001856BEF18-0x00000001856BEFC0
		private static extern void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass); // 0x00000001856BF110-0x00000001856BF1CC
		private static extern void criAtomExAsr_UpdateEffectParameters(string busName, string effectName); // 0x00000001856BF284-0x00000001856BF330
		private static extern void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue); // 0x00000001856BF1CC-0x00000001856BF250
		private static extern float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex); // 0x00000001856BED98-0x00000001856BEE20
		private static extern bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface); // 0x00000001856BEE20-0x00000001856BEE58
		private static extern void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface); // 0x00000001856BF250-0x00000001856BF284
		private static extern void criAtomExAsr_GetBusVolumeByName(string busName, out float volume); // 0x00000001856BED00-0x00000001856BED98
	}

	public static class CriAtomExLatencyEstimator // TypeDefIndex: 54108
	{
		// Nested types
		public enum Status // TypeDefIndex: 54106
		{
			Stop = 0,
			Processing = 1,
			Done = 2,
			Error = 3
		}
	
		public struct EstimatorInfo // TypeDefIndex: 54107
		{
			// Fields
			public Status status; // 0x00
			public uint estimated_latency; // 0x04
		}
	
		// Methods
		public static void InitializeModule() {} // 0x000000018350B670-0x000000018350B680
		public static void FinalizeModule() {} // 0x000000018350B670-0x000000018350B680
		public static EstimatorInfo GetCurrentInfo() => default; // 0x0000000183D51AB0-0x0000000183D51AC0
	}

	public class CriAtomEx3dListener : CriDisposable // TypeDefIndex: 54110
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		public struct Config // TypeDefIndex: 54109
		{
			// Fields
			public int reserved; // 0x00
		}
	
		// Constructors
		public CriAtomEx3dListener() {} // 0x0000000183183650-0x00000001831836D0
	
		// Methods
		public override void Dispose() {} // 0x00000001856B62DC-0x00000001856B62E8
		private void Dispose(bool disposing) {} // 0x00000001856B62E8-0x00000001856B6374
		public void Update() {} // 0x00000001856B6664-0x00000001856B6678
		public void ResetParameters() {} // 0x00000001856B63F4-0x00000001856B6408
		public void SetPosition(float x, float y, float z) {} // 0x00000001856B65FC-0x00000001856B6630
		public void SetVelocity(float x, float y, float z) {} // 0x00000001856B6630-0x00000001856B6664
		public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz) {} // 0x00000001856B65A0-0x00000001856B65FC
		[Obsolete("Use SetDopplerMultiplier instead")]
		public void SetDistanceFactor(float distanceFactor) {} // 0x00000001856B6448-0x00000001856B64D8
		public void SetDopplerMultiplier(float dopplerMultiplier) {} // 0x00000001856B64EC-0x00000001856B656C
		public void SetFocusPoint(float x, float y, float z) {} // 0x00000001856B656C-0x00000001856B65A0
		public void SetDistanceFocusLevel(float distanceFocusLevel) {} // 0x00000001856B64D8-0x00000001856B64EC
		public void SetDirectionFocusLevel(float directionFocusLevel) {} // 0x00000001856B6434-0x00000001856B6448
		public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x00000001856B6408-0x00000001856B6434
		public bool IsDestroyable() => default; // 0x00000001856B63E8-0x00000001856B63F4
		~CriAtomEx3dListener() {} // 0x00000001856B6374-0x00000001856B63E8
		private static extern IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size); // 0x00000001822C8250-0x00000001822C82F0
		private static extern void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener); // 0x00000001856B6678-0x00000001856B66AC
		private static extern void criAtomEx3dListener_Update(IntPtr ex_3d_listener); // 0x00000001856B6A40-0x00000001856B6A74
		private static extern void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener); // 0x00000001856B6728-0x00000001856B675C
		private static extern void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position); // 0x00000001856B69B8-0x00000001856B69FC
		private static extern void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity); // 0x00000001856B69FC-0x00000001856B6A40
		private static extern void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001856B6924-0x00000001856B69B8
		private static extern void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor); // 0x00000001856B67DC-0x00000001856B6820
		private static extern void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier); // 0x00000001856B685C-0x00000001856B68A0
		private static extern void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector focus_point); // 0x00000001856B68A0-0x00000001856B6924
		private static extern void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level); // 0x00000001856B6820-0x00000001856B685C
		private static extern void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level); // 0x00000001856B67A0-0x00000001856B67DC
		private static extern bool criAtomEx3dListener_IsDestroyable(IntPtr ex_3d_listener); // 0x00000001856B66AC-0x00000001856B6728
		private static extern void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region); // 0x00000001856B675C-0x00000001856B67A0
	}

	public class CriAtomEx3dSource : CriDisposable // TypeDefIndex: 54112
	{
		// Fields
		private uint currentRandomPositionListMaxLength; // 0x20
		private IntPtr handle; // 0x28
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Nested types
		public struct Config // TypeDefIndex: 54111
		{
			// Fields
			public bool enableVoicePriorityDecay; // 0x00
			public uint randomPositionListMaxLength; // 0x04
	
			// Constructors
			public Config(bool enableVoicePriorityDecay, uint randomPositionListMaxLength) {
				this.enableVoicePriorityDecay = default;
				this.randomPositionListMaxLength = default;
			} // 0x0000000183D51A30-0x0000000183D51A40
		}
	
		// Constructors
		public CriAtomEx3dSource() {} // Dummy constructor
		public CriAtomEx3dSource(bool enableVoicePriorityDecay = false /* Metadata: 0x01FD633D */, uint randomPositionListMaxLength = 0 /* Metadata: 0x01FD633E */) {} // 0x00000001856B70C8-0x00000001856B715C
	
		// Methods
		public override void Dispose() {} // 0x00000001856B6BF0-0x00000001856B6BFC
		private void Dispose(bool disposing) {} // 0x00000001856B6BFC-0x00000001856B6C88
		public void Update() {} // 0x00000001856B70BC-0x00000001856B70C8
		public void ResetParameters() {} // 0x00000001856B6D48-0x00000001856B6D54
		public void SetPosition(float x, float y, float z) {} // 0x00000001856B6E60-0x00000001856B6E8C
		public void SetVelocity(float x, float y, float z) {} // 0x00000001856B7084-0x00000001856B70B0
		public void SetOrientation(Vector3 front, Vector3 top) {} // 0x00000001856B6E00-0x00000001856B6E60
		[Obsolete("Use CriAtomEx3dSource.SetOrientation instead")]
		public void SetConeOrientation(float x, float y, float z) {} // 0x00000001856B6D78-0x00000001856B6DA4
		public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume) {} // 0x00000001856B6DA4-0x00000001856B6DB8
		public void SetMinMaxDistance(float minDistance, float maxDistance) {} // 0x00000001856B6DF4-0x00000001856B6E00
		public void SetInteriorPanField(float sourceRadius, float interiorDistance) {} // 0x00000001856B6DD0-0x00000001856B6DDC
		public void SetDopplerFactor(float dopplerFactor) {} // 0x00000001856B6DC4-0x00000001856B6DD0
		public void SetVolume(float volume) {} // 0x00000001856B70B0-0x00000001856B70BC
		public void SetMaxAngleAisacDelta(float maxDelta) {} // 0x00000001856B6DE8-0x00000001856B6DF4
		public void SetAttenuationDistanceSetting(bool flag) {} // 0x00000001856B6D6C-0x00000001856B6D78
		public bool GetAttenuationDistanceSetting() => default; // 0x00000001856B6CFC-0x00000001856B6D08
		public void SetRandomPositionConfig(CriAtomEx.Randomize3dConfig? config) {} // 0x00000001856B6E8C-0x00000001856B6F38
		public void SetRandomPositionList(Vector3[] positionList) {} // 0x00000001856B6F38-0x00000001856B7078
		public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x00000001856B6D54-0x00000001856B6D6C
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x00000001856B6DDC-0x00000001856B6DE8
		public void SetSourceBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x00000001856B7078-0x00000001856B7084
		public void SetDistanceAisacControlId(ushort aisacControlId) {} // 0x00000001856B6DB8-0x00000001856B6DC4
		public bool IsDestroyable() => default; // 0x00000001856B6D3C-0x00000001856B6D48
		public CriAtomEx.NativeVector GetPosition() => default; // 0x00000001856B6D08-0x00000001856B6D3C
		~CriAtomEx3dSource() {} // 0x00000001856B6C88-0x00000001856B6CFC
		private static extern IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size); // 0x00000001856B715C-0x00000001856B7220
		private static extern void criAtomEx3dSource_Destroy(IntPtr ex_3d_source); // 0x00000001856B7220-0x00000001856B7254
		private static extern void criAtomEx3dSource_Update(IntPtr ex_3d_source); // 0x00000001856B7BFC-0x00000001856B7C74
		private static extern void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source); // 0x00000001856B73E4-0x00000001856B745C
		private static extern void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position); // 0x00000001856B78BC-0x00000001856B7900
		private static extern void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity); // 0x00000001856B7B7C-0x00000001856B7BC0
		private static extern void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001856B7828-0x00000001856B78BC
		private static extern void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector cone_orient); // 0x00000001856B7524-0x00000001856B75A8
		private static extern void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume); // 0x00000001856B75A8-0x00000001856B7608
		private static extern void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance); // 0x00000001856B77DC-0x00000001856B7828
		private static extern void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance); // 0x00000001856B76C8-0x00000001856B7714
		private static extern void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor); // 0x00000001856B768C-0x00000001856B76C8
		private static extern void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume); // 0x00000001856B7BC0-0x00000001856B7BFC
		private static extern void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta); // 0x00000001856B7798-0x00000001856B77DC
		private static extern void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag); // 0x00000001856B74A0-0x00000001856B7524
		private static extern bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source); // 0x00000001856B7254-0x00000001856B72D0
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref CriAtomEx.Randomize3dConfig config); // 0x00000001856B7984-0x00000001856B7A58
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config); // 0x00000001856B7900-0x00000001856B7984
		private static extern void criAtomEx3dSource_SetRandomPositionList(IntPtr ex_3d_source, CriAtomEx.NativeVector[] position_list, uint length); // 0x00000001856B7A58-0x00000001856B7AF8
		private static extern void criAtomEx3dSource_SetDistanceAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x00000001856B7608-0x00000001856B768C
		private static extern bool criAtomEx3dSource_IsDestroyable(IntPtr ex_3d_source); // 0x00000001856B7368-0x00000001856B73E4
		private static extern CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(IntPtr ex_3d_source); // 0x00000001856B72D0-0x00000001856B7368
		private static extern void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region); // 0x00000001856B745C-0x00000001856B74A0
		private static extern void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x00000001856B7714-0x00000001856B7798
		private static extern void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x00000001856B7AF8-0x00000001856B7B7C
	}

	public class CriAtomEx3dTransceiver : CriDisposable // TypeDefIndex: 54115
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		public struct Config // TypeDefIndex: 54113
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private static class UnsafeNativeMethods // TypeDefIndex: 54114
		{
			// Methods
			internal static extern IntPtr criAtomEx3dTransceiver_Create(ref Config config, IntPtr work, int work_size); // 0x00000001856CCEF4-0x00000001856CCF88
			internal static extern void criAtomEx3dTransceiver_Destroy(IntPtr ex_3d_transceiver); // 0x00000001856CCF88-0x00000001856CCFBC
			internal static extern void criAtomEx3dTransceiver_Update(IntPtr ex_3d_transceiver); // 0x00000001856CD720-0x00000001856CD754
			internal static extern void criAtomEx3dTransceiver_SetInputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x00000001856CD1FC-0x00000001856CD280
			internal static extern void criAtomEx3dTransceiver_SetOutputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x00000001856CD550-0x00000001856CD5D4
			internal static extern void criAtomEx3dTransceiver_SetInputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001856CD168-0x00000001856CD1FC
			internal static extern void criAtomEx3dTransceiver_SetOutputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001856CD4BC-0x00000001856CD550
			internal static extern void criAtomEx3dTransceiver_SetOutputConeParameter(IntPtr ex_3d_transceiver, float inside_angle, float outside_angle, float outside_volume); // 0x00000001856CD3C4-0x00000001856CD424
			internal static extern void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(IntPtr ex_3d_transceiver, float min_attenuation_distance, float max_attenuation_distance); // 0x00000001856CD470-0x00000001856CD4BC
			internal static extern void criAtomEx3dTransceiver_SetOutputInteriorPanField(IntPtr ex_3d_transceiver, float transceiver_radius, float interior_distance); // 0x00000001856CD424-0x00000001856CD470
			internal static extern void criAtomEx3dTransceiver_SetInputCrossFadeField(IntPtr ex_3d_transceiver, float direct_audio_radius, float crossfade_distance); // 0x00000001856CD11C-0x00000001856CD168
			internal static extern void criAtomEx3dTransceiver_SetOutputVolume(IntPtr ex_3d_transceiver, float volume); // 0x00000001856CD5D4-0x00000001856CD618
			internal static extern void criAtomEx3dTransceiver_AttachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x00000001856CCE9C-0x00000001856CCEF4
			internal static extern void criAtomEx3dTransceiver_DetachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x00000001856CCFBC-0x00000001856CD014
			internal static extern void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(IntPtr ex_3d_transceiver, float max_delta); // 0x00000001856CD388-0x00000001856CD3C4
			internal static extern void criAtomEx3dTransceiver_SetDistanceAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001856CD098-0x00000001856CD11C
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001856CD280-0x00000001856CD304
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001856CD304-0x00000001856CD388
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001856CD618-0x00000001856CD69C
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001856CD69C-0x00000001856CD720
			internal static extern void criAtomEx3dTransceiver_Set3dRegionHn(IntPtr ex_3d_transceiver, IntPtr ex_3d_region); // 0x00000001856CD014-0x00000001856CD098
		}
	
		// Constructors
		public CriAtomEx3dTransceiver() {} // 0x00000001856B7FA8-0x00000001856B8018
	
		// Methods
		public override void Dispose() {} // 0x00000001856B7D18-0x00000001856B7D24
		private void Dispose(bool disposing) {} // 0x00000001856B7C8C-0x00000001856B7D18
		public void Update() {} // 0x00000001856B7F9C-0x00000001856B7FA8
		public void SetInputPosition(Vector3 position) {} // 0x00000001856B7E3C-0x00000001856B7E78
		public void SetOutputPosition(Vector3 position) {} // 0x00000001856B7F3C-0x00000001856B7F78
		public void SetInputOrientation(Vector3 front, Vector3 top) {} // 0x00000001856B7DC8-0x00000001856B7E3C
		public void SetOutputOrientation(Vector3 front, Vector3 top) {} // 0x00000001856B7EC8-0x00000001856B7F3C
		public void SetOutputConeParameter(float insideAngle, float outsideAngle, float outsideVolume) {} // 0x00000001856B7E9C-0x00000001856B7EB0
		public void SetOutputMinMaxDistance(float minDistance, float maxDistance) {} // 0x00000001856B7EBC-0x00000001856B7EC8
		public void SetOutputInteriorPanField(float radius, float interiorDistance) {} // 0x00000001856B7EB0-0x00000001856B7EBC
		public void SetInputCrossFadeField(float directAudioRadius, float crossfadeDistance) {} // 0x00000001856B7DBC-0x00000001856B7DC8
		public void SetOutputVolume(float volume) {} // 0x00000001856B7F78-0x00000001856B7F84
		public void AttachAisac(string globalAisacName) {} // 0x00000001856B7C74-0x00000001856B7C80
		public void DetachAisac(string globalAisacName) {} // 0x00000001856B7C80-0x00000001856B7C8C
		public void SetMaxAngleAisacDelta(float maxDelta) {} // 0x00000001856B7E90-0x00000001856B7E9C
		public void SetDistanceAisacControlId(ushort aisacControlId) {} // 0x00000001856B7DB0-0x00000001856B7DBC
		public void SetListenerBasedAzimuthAngleAisacControlId(ushort aisacControlId) {} // 0x00000001856B7E78-0x00000001856B7E84
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x00000001856B7E84-0x00000001856B7E90
		public void SetTransceiverOutputBasedAzimuthAngleAisacControlId(ushort aisacControlId) {} // 0x00000001856B7F84-0x00000001856B7F90
		public void SetTransceiverOutputBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x00000001856B7F90-0x00000001856B7F9C
		public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x00000001856B7D98-0x00000001856B7DB0
		~CriAtomEx3dTransceiver() {} // 0x00000001856B7D24-0x00000001856B7D98
	}

	public class CriAtomEx3dRegion : CriDisposable // TypeDefIndex: 54118
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		public struct Config // TypeDefIndex: 54116
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private static class UnsafeNativeMethods // TypeDefIndex: 54117
		{
			// Methods
			internal static extern IntPtr criAtomEx3dRegion_Create(ref Config config, IntPtr work, int work_size); // 0x00000001856CCDD4-0x00000001856CCE68
			internal static extern void criAtomEx3dRegion_Destroy(IntPtr ex_3d_region); // 0x00000001856CCE68-0x00000001856CCE9C
		}
	
		// Constructors
		public CriAtomEx3dRegion() {} // 0x00000001856B6B80-0x00000001856B6BF0
	
		// Methods
		public override void Dispose() {} // 0x00000001856B6A74-0x00000001856B6A80
		private void Dispose(bool disposing) {} // 0x00000001856B6A80-0x00000001856B6B0C
		~CriAtomEx3dRegion() {} // 0x00000001856B6B0C-0x00000001856B6B80
	}

	public class CriAtomExAcb : CriDisposable // TypeDefIndex: 54119
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle dataHandle; // 0x28
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public bool isAvailable { get => default; } // 0x00000001856BAD24-0x00000001856BAD30 
	
		// Constructors
		public CriAtomExAcb() {} // Dummy constructor
		internal CriAtomExAcb(IntPtr handle, GCHandle? dataHandle) {} // 0x00000001856B9DB8-0x00000001856B9E58
	
		// Methods
		public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath) => default; // 0x00000001856B9CD4-0x00000001856B9DA0
		public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath) => default; // 0x00000001856B9BB8-0x00000001856B9CD4
		public override void Dispose() {} // 0x00000001856B898C-0x00000001856B89DC
		private void Dispose(bool disposing) {} // 0x00000001856B89DC-0x00000001856B8A58
		public bool Exists(string cueName) => default; // 0x00000001856B8A58-0x00000001856B8A64
		public bool Exists(int cueId) => default; // 0x00000001856B8A64-0x00000001856B8A70
		public bool GetCueInfo(string cueName, out CriAtomEx.CueInfo info) {
			info = default;
			return default;
		} // 0x00000001856B9010-0x00000001856B9244
		public bool GetCueInfo(int cueId, out CriAtomEx.CueInfo info) {
			info = default;
			return default;
		} // 0x00000001856B8DDC-0x00000001856B9010
		public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info) {
			info = default;
			return default;
		} // 0x00000001856B8AFC-0x00000001856B8D30
		public CriAtomEx.CueInfo[] GetCueInfoList() => default; // 0x00000001856B8D30-0x00000001856B8DDC
		public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info) {
			info = default;
			return default;
		} // 0x00000001856B97B8-0x00000001856B99AC
		public bool GetWaveFormInfo(int cueId, out CriAtomEx.WaveformInfo info) {
			info = default;
			return default;
		} // 0x00000001856B99AC-0x00000001856B9BA0
		public int GetNumCuePlaying(string name) => default; // 0x00000001856B9250-0x00000001856B925C
		public int GetNumCuePlaying(int id) => default; // 0x00000001856B9244-0x00000001856B9250
		public int GetBlockIndex(string cueName, string blockName) => default; // 0x00000001856B8AF0-0x00000001856B8AFC
		public int GetBlockIndex(int cueId, string blockName) => default; // 0x00000001856B8AE4-0x00000001856B8AF0
		public int GetNumUsableAisacControls(string cueName) => default; // 0x00000001856B925C-0x00000001856B9268
		public int GetNumUsableAisacControls(int cueId) => default; // 0x00000001856B9268-0x00000001856B9274
		public bool GetUsableAisacControl(string cueName, int index, out CriAtomEx.AisacControlInfo info) {
			info = default;
			return default;
		} // 0x00000001856B95E0-0x00000001856B97B8
		public bool GetUsableAisacControl(int cueId, int index, out CriAtomEx.AisacControlInfo info) {
			info = default;
			return default;
		} // 0x00000001856B93F8-0x00000001856B95E0
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(string cueName) => default; // 0x00000001856B9274-0x00000001856B9338
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(int cueId) => default; // 0x00000001856B9338-0x00000001856B93F8
		public void ResetCueTypeState(string cueName) {} // 0x00000001856B9DAC-0x00000001856B9DB8
		public void ResetCueTypeState(int cueId) {} // 0x00000001856B9DA0-0x00000001856B9DAC
		public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name) {} // 0x00000001856B88D4-0x00000001856B890C
		public void DetachAwbFile(string awb_name) {} // 0x00000001856B8978-0x00000001856B898C
		public bool IsReadyToRelease() => default; // 0x00000001856B9BA0-0x00000001856B9BB8
		public float GetLoadProgress() => default; // 0x0000000183D51A60-0x0000000183D51A70
		public void Decrypt(ulong key, ulong nonce) {} // 0x00000001856B890C-0x00000001856B8978
		~CriAtomExAcb() {} // 0x00000001856B8A70-0x00000001856B8AE4
		private static extern IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x00000001856BAB20-0x00000001856BAC18
		private static extern IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x00000001856BAA3C-0x00000001856BAB20
		private static extern void criAtomExAcb_Release(IntPtr acb_hn); // 0x00000001856BAC18-0x00000001856BAC4C
		private static extern int criAtomExAcb_GetNumCues(IntPtr acb_hn); // 0x00000001856BA5A4-0x00000001856BA5D8
		private static extern bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id); // 0x00000001856B9FD4-0x00000001856BA05C
		private static extern bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name); // 0x00000001856BA05C-0x00000001856BA10C
		private static extern int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id); // 0x00000001856BA5D8-0x00000001856BA65C
		private static extern int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name); // 0x00000001856BA65C-0x00000001856BA708
		private static extern bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info); // 0x00000001856BA708-0x00000001856BA7B0
		private static extern bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info); // 0x00000001856BA7B0-0x00000001856BA874
		private static extern bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info); // 0x00000001856BA874-0x00000001856BA90C
		private static extern bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info); // 0x00000001856BA90C-0x00000001856BA9C0
		private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info); // 0x00000001856BA3C0-0x00000001856BA474
		private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info); // 0x00000001856BA290-0x00000001856BA328
		private static extern bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info); // 0x00000001856BA328-0x00000001856BA3C0
		private static extern int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name); // 0x00000001856BA4F8-0x00000001856BA5A4
		private static extern int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id); // 0x00000001856BA474-0x00000001856BA4F8
		private static extern int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name); // 0x00000001856BA10C-0x00000001856BA1C4
		private static extern int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name); // 0x00000001856BA1C4-0x00000001856BA290
		private static extern void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name); // 0x00000001856BAC8C-0x00000001856BAD24
		private static extern void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id); // 0x00000001856BAC4C-0x00000001856BAC8C
		private static extern void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size); // 0x00000001856B9E58-0x00000001856B9F3C
		private static extern void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name); // 0x00000001856B9F3C-0x00000001856B9FD4
		private static extern bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn); // 0x00000001856BA9C0-0x00000001856BAA3C
	}

	public class CriAtomExAcbLoader : CriDisposable // TypeDefIndex: 54122
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle? gch; // 0x28
	
		// Nested types
		public enum Status // TypeDefIndex: 54120
		{
			Stop = 0,
			Loading = 1,
			Complete = 2,
			Error = 3
		}
	
		private struct LoaderConfig // TypeDefIndex: 54121
		{
			// Fields
			public bool shouldLoadAwbOnMemory; // 0x00
		}
	
		// Constructors
		public CriAtomExAcbLoader() {} // Dummy constructor
		private CriAtomExAcbLoader(IntPtr handle, GCHandle? dataHandle) {} // 0x00000001856B8470-0x00000001856B8534
	
		// Methods
		public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x01FD633F */) => default; // 0x00000001856B82E8-0x00000001856B83D0
		public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x01FD6340 */) => default; // 0x00000001856B81AC-0x00000001856B82E8
		public Status GetStatus() => default; // 0x00000001856B81A0-0x00000001856B81AC
		public CriAtomExAcb MoveAcb() => default; // 0x00000001856B83D0-0x00000001856B8470
		public override void Dispose() {} // 0x00000001856B8018-0x00000001856B8068
		private void Dispose(bool disposing) {} // 0x00000001856B8068-0x00000001856B812C
		~CriAtomExAcbLoader() {} // 0x00000001856B812C-0x00000001856B81A0
		private static extern IntPtr criAtomExAcbLoader_Create(in LoaderConfig config); // 0x00000001856B8534-0x00000001856B85B4
		private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader); // 0x00000001856B85B4-0x00000001856B85E8
		private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path); // 0x00000001856B8738-0x00000001856B8824
		private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path); // 0x00000001856B8660-0x00000001856B8738
		private static extern Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader); // 0x00000001856B85E8-0x00000001856B8660
		private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader); // 0x00000001856B889C-0x00000001856B88D4
		private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader); // 0x00000001856B8824-0x00000001856B889C
	}

	public class CriAtomExAcf // TypeDefIndex: 54137
	{
		// Nested types
		public struct AcfDspSettingInfo // TypeDefIndex: 54123
		{
			// Fields
			public string name; // 0x00
			public ushort[] busIndexes; // 0x08
			public ushort[] extendBusIndexes; // 0x10
			public ushort snapshotStartIndex; // 0x18
			public byte numBuses; // 0x1A
			public byte numExtendBuses; // 0x1B
			public ushort numSnapshots; // 0x1C
			public ushort snapshotWorkSize; // 0x1E
			public ushort numMixerAisacs; // 0x20
			public ushort mixerAisacStartIndex; // 0x22
	
			// Constructors
			public AcfDspSettingInfo(byte[] data, int startIndex) {
				name = default;
				busIndexes = default;
				extendBusIndexes = default;
				snapshotStartIndex = default;
				numBuses = default;
				numExtendBuses = default;
				numSnapshots = default;
				snapshotWorkSize = default;
				numMixerAisacs = default;
				mixerAisacStartIndex = default;
			} // 0x00000001856B5374-0x00000001856B55A8
		}
	
		public struct AcfDspSettingSnapshotInfo // TypeDefIndex: 54124
		{
			// Fields
			public string name; // 0x00
			public byte numBuses; // 0x08
			public byte numExtendBuses; // 0x09
			public byte[] reserved; // 0x10
			public ushort[] busIndexes; // 0x18
			public ushort[] extendBusIndexes; // 0x20
	
			// Constructors
			public AcfDspSettingSnapshotInfo(byte[] data, int startIndex) {
				name = default;
				numBuses = default;
				numExtendBuses = default;
				reserved = default;
				busIndexes = default;
				extendBusIndexes = default;
			} // 0x00000001856B55A8-0x00000001856B57C4
		}
	
		public struct AcfDspBusInfo // TypeDefIndex: 54125
		{
			// Fields
			public string name; // 0x00
			public float volume; // 0x08
			public float pan3dVolume; // 0x0C
			public float pan3dAngle; // 0x10
			public float pan3dDistance; // 0x14
			public float pan3dSpread; // 0x18
			public ushort[] fxIndexes; // 0x20
			public ushort[] busLinkIndexes; // 0x28
			public ushort busNo; // 0x30
			public byte numFxes; // 0x32
			public byte numBusLinks; // 0x33
	
			// Constructors
			public AcfDspBusInfo(byte[] data, int startIndex) {
				name = default;
				volume = default;
				pan3dVolume = default;
				pan3dAngle = default;
				pan3dDistance = default;
				pan3dSpread = default;
				fxIndexes = default;
				busLinkIndexes = default;
				busNo = default;
				numFxes = default;
				numBusLinks = default;
			} // 0x00000001856B5018-0x00000001856B5248
		}
	
		public enum AcfDspBusLinkType : uint // TypeDefIndex: 54126
		{
			preVolume = 0,
			postVolume = 1,
			postPan = 2
		}
	
		public struct AcfDspBusLinkInfo // TypeDefIndex: 54127
		{
			// Fields
			public AcfDspBusLinkType type; // 0x00
			public float sendLevel; // 0x04
			public ushort busNo; // 0x08
			public ushort busId; // 0x0A
	
			// Constructors
			public AcfDspBusLinkInfo(byte[] data, int startIndex) {
				type = default;
				sendLevel = default;
				busNo = default;
				busId = default;
			} // 0x00000001856B5248-0x00000001856B5374
		}
	
		public struct CategoryInfo // TypeDefIndex: 54128
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public string name; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
	
			// Constructors
			public CategoryInfo(byte[] data, int startIndex) {
				groupNo = default;
				id = default;
				name = default;
				numCueLimits = default;
				volume = default;
			} // 0x00000001856B5FC4-0x00000001856B60AC
		}
	
		public enum AcfAisacType : uint // TypeDefIndex: 54129
		{
			normal = 0,
			autoModulation = 1
		}
	
		public struct GlobalAisacInfo // TypeDefIndex: 54130
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numGraphs; // 0x0A
			public AcfAisacType type; // 0x0C
			public float randomRange; // 0x10
			public ushort controlId; // 0x14
			public ushort dummy; // 0x16
	
			// Constructors
			public GlobalAisacInfo(byte[] data, int startIndex) {
				name = default;
				index = default;
				numGraphs = default;
				type = default;
				randomRange = default;
				controlId = default;
				dummy = default;
			} // 0x00000001856CB4C0-0x00000001856CB648
		}
	
		public enum AisacGraphType // TypeDefIndex: 54131
		{
			none = 0,
			volume = 1,
			pitch = 2,
			bandpassHigh = 3,
			bandpassLow = 4,
			biquadFreq = 5,
			biquadQ = 6,
			busSend0 = 7,
			busSend1 = 8,
			busSend2 = 9,
			busSend3 = 10,
			busSend4 = 11,
			busSend5 = 12,
			busSend6 = 13,
			busSend7 = 14,
			pan3dAngel = 15,
			pan3dVolume = 16,
			pan3dInteriorDistance = 17,
			pan3dCenter = 18,
			pan3dLfe = 19,
			aisac0 = 20,
			aisac1 = 21,
			aisac2 = 22,
			aisac3 = 23,
			aisac4 = 24,
			aisac5 = 25,
			aisac6 = 26,
			aisac7 = 27,
			aisac8 = 28,
			aisac9 = 29,
			aisac10 = 30,
			aisac11 = 31,
			aisac12 = 32,
			aisac13 = 33,
			aisac14 = 34,
			aisac15 = 35,
			priority = 36,
			preDelayTime = 37,
			biquadGain = 38,
			pan3dMixdownCenter = 39,
			pan3dMixdownLfe = 40,
			egAttack = 41,
			egRelease = 42,
			playbackRatio = 43,
			drySendL = 44,
			drySendR = 45,
			drySendCenter = 46,
			drySendLfe = 47,
			drySendSl = 48,
			drySendSr = 49,
			drySendEx1 = 50,
			drySendEx2 = 51,
			panSpread = 52
		}
	
		public struct AisacGraphInfo // TypeDefIndex: 54132
		{
			// Fields
			public AisacGraphType type; // 0x00
	
			// Constructors
			public AisacGraphInfo(byte[] data, int startIndex) {
				type = default;
			} // 0x00000001856B5A78-0x00000001856B5B6C
		}
	
		public enum CharacterEncoding : uint // TypeDefIndex: 54133
		{
			utf8 = 0,
			sjis = 1
		}
	
		public struct AcfInfo // TypeDefIndex: 54134
		{
			// Fields
			public string name; // 0x00
			public uint size; // 0x08
			public uint version; // 0x0C
			public CharacterEncoding characterEncoding; // 0x10
			public int numDspSettings; // 0x14
			public int numCategories; // 0x18
			public int numCategoriesPerPlayback; // 0x1C
			public int numReacts; // 0x20
			public int numAisacControls; // 0x24
			public int numGlobalAisacs; // 0x28
			public int numGameVariables; // 0x2C
			public int maxBusesOfDspBusSettings; // 0x30
			public int numBuses; // 0x34
			public int numVoiceLimitGroups; // 0x38
			public int numOutputPorts; // 0x3C
	
			// Constructors
			public AcfInfo(byte[] data, int startIndex) {
				name = default;
				size = default;
				version = default;
				characterEncoding = default;
				numDspSettings = default;
				numCategories = default;
				numCategoriesPerPlayback = default;
				numReacts = default;
				numAisacControls = default;
				numGlobalAisacs = default;
				numGameVariables = default;
				maxBusesOfDspBusSettings = default;
				numBuses = default;
				numVoiceLimitGroups = default;
				numOutputPorts = default;
			} // 0x00000001856B57C4-0x00000001856B59D0
		}
	
		public struct SelectorInfo // TypeDefIndex: 54135
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
	
			// Constructors
			public SelectorInfo(byte[] data, int startIndex) {
				name = default;
				index = default;
				numLabels = default;
				globalLabelIndex = default;
			} // 0x00000001856CBCE8-0x00000001856CBDB4
		}
	
		public struct SelectorLabelInfo // TypeDefIndex: 54136
		{
			// Fields
			public string selectorName; // 0x00
			public string labelName; // 0x08
	
			// Constructors
			public SelectorLabelInfo(byte[] data, int startIndex) {
				selectorName = default;
				labelName = default;
			} // 0x00000001856CBDB4-0x00000001856CBE6C
		}
	
		// Constructors
		public CriAtomExAcf() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static int GetNumAisacControls() => default; // 0x00000001856BC568-0x00000001856BC570
		public static bool GetAisacControlInfo(ushort index, out CriAtomEx.AisacControlInfo info) {
			info = default;
			return default;
		} // 0x00000001856BAF28-0x00000001856BB0E0
		public static int GetNumDspSettings() => default; // 0x00000001856BC590-0x00000001856BC598
		public static int GetNumDspSettings(IntPtr acfData, int size) => default; // 0x00000001856BC588-0x00000001856BC590
		public static string GetDspSettingNameByIndex(ushort index) => default; // 0x00000001856BBBB8-0x00000001856BBC10
		public static string GetDspSettingNameByIndex(IntPtr acfData, int size, ushort index) => default; // 0x00000001856BBC10-0x00000001856BBC84
		public static bool GetDspSettingInformation(string name, out AcfDspSettingInfo info) {
			info = default;
			return default;
		} // 0x00000001856BB9D4-0x00000001856BBBB8
		public static bool GetDspSettingSnapshotInformation(ushort index, out AcfDspSettingSnapshotInfo info) {
			info = default;
			return default;
		} // 0x00000001856BBC84-0x00000001856BBE70
		public static bool GetDspBusInformation(ushort index, out AcfDspBusInfo info) {
			info = default;
			return default;
		} // 0x00000001856BB654-0x00000001856BB854
		public static bool GetDspBusLinkInformation(ushort index, out AcfDspBusLinkInfo info) {
			info = default;
			return default;
		} // 0x00000001856BB854-0x00000001856BB9D4
		public static int GetNumCategories() => default; // 0x00000001856BC580-0x00000001856BC588
		public static int GetNumCategoriesPerPlayback() => default; // 0x00000001856BC578-0x00000001856BC580
		public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo info) {
			info = default;
			return default;
		} // 0x00000001856BB2B4-0x00000001856BB48C
		public static bool GetCategoryInfoByName(string name, out CategoryInfo info) {
			info = default;
			return default;
		} // 0x00000001856BB48C-0x00000001856BB654
		public static bool GetCategoryInfoById(uint id, out CategoryInfo info) {
			info = default;
			return default;
		} // 0x00000001856BB0E0-0x00000001856BB2B4
		public static int GetNumGlobalAisacs() => default; // 0x00000001856BC598-0x00000001856BC5A0
		public static bool GetGlobalAisacInfoByIndex(ushort index, out GlobalAisacInfo info) {
			info = default;
			return default;
		} // 0x00000001856BC0B4-0x00000001856BC288
		public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info) {
			info = default;
			return default;
		} // 0x00000001856BC288-0x00000001856BC450
		public static bool GetGlobalAisacGraphInfo(GlobalAisacInfo aisacInfo, ushort graphIndex, out AisacGraphInfo graphInfo) {
			graphInfo = default;
			return default;
		} // 0x00000001856BBE70-0x00000001856BC0B4
		public static bool GetGlobalAisacValue(GlobalAisacInfo aisacInfo, float control, AisacGraphType type, out float value) {
			value = default;
			return default;
		} // 0x00000001856BC450-0x00000001856BC560
		public static bool GetAcfInfo(out AcfInfo acfInfo) {
			acfInfo = default;
			return default;
		} // 0x00000001856BAD38-0x00000001856BAF28
		public static int GetNumSelectors() => default; // 0x00000001856BC5A0-0x00000001856BC5A8
		public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info) {
			info = default;
			return default;
		} // 0x00000001856BC5A8-0x00000001856BC760
		public static bool GetSelectorInfoByName(string name, out SelectorInfo info) {
			info = default;
			return default;
		} // 0x00000001856BC760-0x00000001856BC918
		public static bool GetSelectorLabelInfo(SelectorInfo selectorInfo, ushort labelIndex, out SelectorLabelInfo info) {
			info = default;
			return default;
		} // 0x00000001856BC918-0x00000001856BCBA0
		public static int GetNumBuses() => default; // 0x00000001856BC570-0x00000001856BC578
		public static int GetMaxBusesOfDspBusSettings() => default; // 0x00000001856BC560-0x00000001856BC568
		public static string FindBusName(string busName) => default; // 0x00000001856BAD30-0x00000001856BAD38
		private static extern int criAtomExAcf_GetNumAisacControls(); // 0x00000001856BD728-0x00000001856BD74C
		private static extern bool criAtomExAcf_GetAisacControlInfo(ushort index, IntPtr info); // 0x00000001856BCD7C-0x00000001856BCE08
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x00000001856BCD28-0x00000001856BCD7C
		private static extern string criAtomExAcf_GetAisacControlNameById(uint id); // 0x00000001856BCE08-0x00000001856BCEA0
		private static extern int criAtomExAcf_GetNumDspSettings(); // 0x00000001856BD99C-0x00000001856BDA04
		private static extern int criAtomExAcf_GetNumDspSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001856BD918-0x00000001856BD99C
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndex(ushort index); // 0x00000001856BD3D0-0x00000001856BD448
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(IntPtr acf_data, int acf_data_size, ushort index); // 0x00000001856BD33C-0x00000001856BD3D0
		private static extern bool criAtomExAcf_GetDspSettingInformation(string name, IntPtr info); // 0x00000001856BD2D8-0x00000001856BD33C
		private static extern bool criAtomExAcf_GetDspSettingSnapshotInformation(ushort index, IntPtr info); // 0x00000001856BD448-0x00000001856BD4D4
		private static extern bool criAtomExAcf_GetDspBusInformation(ushort index, IntPtr info); // 0x00000001856BD018-0x00000001856BD0A4
		private static extern int criAtomExAcf_GetDspFxType(ushort index); // 0x00000001856BD260-0x00000001856BD2D8
		private static extern string criAtomExAcf_GetDspFxName(ushort index); // 0x00000001856BD130-0x00000001856BD1C8
		private static extern bool criAtomExAcf_GetDspFxParameters(ushort index, IntPtr parameters, int size); // 0x00000001856BD1C8-0x00000001856BD260
		private static extern bool criAtomExAcf_GetDspBusLinkInformation(ushort index, IntPtr info); // 0x00000001856BD0A4-0x00000001856BD130
		private static extern int criAtomExAcf_GetNumCategoriesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001856BD7FC-0x00000001856BD880
		private static extern int criAtomExAcf_GetNumCategories(); // 0x00000001856BD8EC-0x00000001856BD918
		private static extern int criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001856BD880-0x00000001856BD8C0
		private static extern int criAtomExAcf_GetNumCategoriesPerPlayback(); // 0x00000001856BD8C0-0x00000001856BD8EC
		private static extern bool criAtomExAcf_GetCategoryInfo(ushort index, IntPtr info); // 0x00000001856BCF8C-0x00000001856BD018
		private static extern bool criAtomExAcf_GetCategoryInfoByName(string name, IntPtr info); // 0x00000001856BCF28-0x00000001856BCF8C
		private static extern bool criAtomExAcf_GetCategoryInfoById(uint id, IntPtr info); // 0x00000001856BCEA0-0x00000001856BCF28
		private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x00000001856BDA04-0x00000001856BDA28
		private static extern bool criAtomExAcf_GetGlobalAisacInfo(ushort index, IntPtr info); // 0x00000001856BD5D0-0x00000001856BD65C
		private static extern bool criAtomExAcf_GetGlobalAisacInfoByName(string name, IntPtr info); // 0x00000001856BD56C-0x00000001856BD5D0
		private static extern bool criAtomExAcf_GetGlobalAisacGraphInfo(IntPtr aisac_info, ushort graph_index, IntPtr graph_info); // 0x00000001856BD4D4-0x00000001856BD56C
		private static extern bool criAtomExAcf_GetGlobalAisacValue(IntPtr aisac_info, float control, AisacGraphType type, out float value); // 0x00000001856BD65C-0x00000001856BD6BC
		private static extern bool criAtomExAcf_GetAcfInfo(IntPtr acf_info); // 0x00000001856BCCF0-0x00000001856BCD28
		private static extern bool criAtomExAcf_GetAcfInfoFromAcfData(IntPtr acf_data, int acf_data_size, IntPtr acf_info); // 0x00000001856BCC58-0x00000001856BCCF0
		private static extern int criAtomExAcf_GetNumSelectors(); // 0x00000001856BDA28-0x00000001856BDA4C
		private static extern bool criAtomExAcf_GetSelectorInfoByIndex(ushort index, IntPtr info); // 0x00000001856BDA4C-0x00000001856BDAD8
		private static extern bool criAtomExAcf_GetSelectorInfoByName(string name, IntPtr info); // 0x00000001856BDAD8-0x00000001856BDB3C
		private static extern bool criAtomExAcf_GetSelectorLabelInfo(IntPtr selector_info, ushort label_index, IntPtr info); // 0x00000001856BDB3C-0x00000001856BDBD4
		private static extern int criAtomExAcf_GetNumBusesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001856BD74C-0x00000001856BD7D0
		private static extern int criAtomExAcf_GetNumBuses(); // 0x00000001856BD7D0-0x00000001856BD7FC
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001856BD6BC-0x00000001856BD6FC
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettings(); // 0x00000001856BD6FC-0x00000001856BD728
		private static extern string criAtomExAcf_FindBusName(string bus_name); // 0x00000001856BCBA0-0x00000001856BCC58
	}

	public class CriAtomExAsrRack : CriDisposable // TypeDefIndex: 54142
	{
		// Fields
		public const int defaultRackId = 0; // Metadata: 0x01FD6383
		private int _rackId; // 0x20
		private bool hasExistingRackId; // 0x24
	
		// Properties
		public int rackId { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		public static Config defaultConfig { get => default; } // 0x0000000183D51A70-0x0000000183D51AB0 
	
		// Nested types
		public enum SpeakerMapping // TypeDefIndex: 54138
		{
			Auto = 0,
			Monaural = 1,
			Stereo = 2,
			Ch5_1 = 3,
			Ch7_1 = 4,
			Ch5_1_2 = 5,
			Ch7_1_4 = 6
		}
	
		public struct Config // TypeDefIndex: 54139
		{
			// Fields
			public float serverFrequency; // 0x00
			public int numBuses; // 0x04
			public int outputChannels; // 0x08
			public SpeakerMapping speakerMapping; // 0x0C
			public int outputSamplingRate; // 0x10
			public CriAtomEx.SoundRendererType soundRendererType; // 0x14
			public int outputRackId; // 0x18
			public IntPtr context; // 0x20
		}
	
		public struct PlatformConfig // TypeDefIndex: 54140
		{
			// Fields
			public byte reserved; // 0x00
		}
	
		public struct PerformanceInfo // TypeDefIndex: 54141
		{
			// Fields
			public uint processCount; // 0x00
			public uint lastProcessTime; // 0x04
			public uint maxProcessTime; // 0x08
			public uint averageProcessTime; // 0x0C
			public uint lastProcessInterval; // 0x10
			public uint maxProcessInterval; // 0x14
			public uint averageProcessInterval; // 0x18
			public uint lastProcessSamples; // 0x1C
			public uint maxProcessSamples; // 0x20
			public uint averageProcessSamples; // 0x24
		}
	
		// Constructors
		public CriAtomExAsrRack() {} // Dummy constructor
		public CriAtomExAsrRack(Config config, PlatformConfig platformConfig) {} // 0x00000001856BDF0C-0x00000001856BE018
		public CriAtomExAsrRack(int existingRackId) {} // 0x00000001856BE018-0x00000001856BE0D4
	
		// Methods
		public void AttachDspBusSetting(string settingName) {} // 0x00000001856BDBE0-0x00000001856BDC00
		public void DetachDspBusSetting() {} // 0x00000001856BDC84-0x00000001856BDC90
		public void ApplyDspBusSnapshot(string snapshotName, int timeMs) {} // 0x00000001856BDBD4-0x00000001856BDBE0
		public static string GetAppliedDspBusSnapshotName(int rackId) => default; // 0x00000001856BDDD8-0x00000001856BDE2C
		public string GetAppliedDspBusSnapshotName() => default; // 0x00000001856BDD80-0x00000001856BDDD8
		public PerformanceInfo GetPerformanceInfo() => default; // 0x00000001856BDE60-0x00000001856BDEE8
		public static PerformanceInfo GetPerformanceInfoByRackId(int rackId = 0 /* Metadata: 0x01FD6381 */) => default; // 0x00000001856BDE2C-0x00000001856BDE60
		public void ResetPerformanceMonitor() {} // 0x00000001856BDEF0-0x00000001856BDEFC
		public static void ResetPerformanceMonitorByRackId(int rackId = 0 /* Metadata: 0x01FD6382 */) {} // 0x00000001856BDEE8-0x00000001856BDEF0
		public static void SetAisacControl(int rackId, string controlName, float value) {} // 0x00000001856BDEFC-0x00000001856BDF04
		public static void SetAisacControl(int rackId, int controlId, float value) {} // 0x00000001856BDF04-0x00000001856BDF0C
		public override void Dispose() {} // 0x00000001856BDC90-0x00000001856BDD0C
		~CriAtomExAsrRack() {} // 0x00000001856BDD0C-0x00000001856BDD80
		private static extern int CRIWARE6158351D(in Config config, in PlatformConfig platformConfig); // 0x00000001856BDC00-0x00000001856BDC84
		private static extern void criAtomExAsrRack_Destroy(int rackId); // 0x00000001856BE230-0x00000001856BE2A8
		private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize); // 0x00000001856BE17C-0x00000001856BE230
		private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId); // 0x00000001856BE2A8-0x00000001856BE320
		private static extern IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(int rackId); // 0x00000001856BE320-0x00000001856BE398
		private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs); // 0x00000001856BE0D4-0x00000001856BE17C
		private static extern void criAtomExAsrRack_GetPerformanceInfo(int rackId, out PerformanceInfo perfInfo); // 0x00000001856BE398-0x00000001856BE41C
		private static extern void criAtomExAsrRack_ResetPerformanceMonitor(int rackId); // 0x00000001856BE41C-0x00000001856BE494
		private static extern void criAtomExAsrRack_SetAisacControlById(int rackId, ushort controlId, float value); // 0x00000001856BE494-0x00000001856BE4E0
		private static extern void criAtomExAsrRack_SetAisacControlByName(int rackId, string controlName, float value); // 0x00000001856BE4E0-0x00000001856BE540
	}

	public class CriAtomExAuxIn : CriDisposable // TypeDefIndex: 54144
	{
		// Fields
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomExAuxIn."; // Metadata: 0x01FD638B
		private IntPtr handle; // 0x20
		private CriAudioReadStream inputReadStream; // 0x28
	
		// Nested types
		public struct Config // TypeDefIndex: 54143
		{
			// Fields
			public int maxChannels; // 0x00
			public int maxSamplingRate; // 0x04
			public CriAtomEx.SoundRendererType soundRendererType; // 0x08
	
			// Properties
			public static Config Default { get => default; } // 0x0000000183D51A40-0x0000000183D51A60 
		}
	
		// Constructors
		public CriAtomExAuxIn() {} // Dummy constructor
		public CriAtomExAuxIn(Config? config = default) {} // 0x00000001856BF444-0x00000001856BF514
	
		// Methods
		~CriAtomExAuxIn() {} // 0x00000001856BDD0C-0x00000001856BDD80
		public override void Dispose() {} // 0x00000001856BF330-0x00000001856BF3AC
		public void Start() {} // 0x00000001856BF424-0x00000001856BF430
		public void Stop() {} // 0x00000001856BF430-0x00000001856BF444
		public void SetFormat(int numChannels, int samplingRate) {} // 0x00000001856BF3C4-0x00000001856BF3D0
		public void GetFormat(out int numChannels, out int samplingRate) {
			numChannels = default;
			samplingRate = default;
		} // 0x00000001856BF3AC-0x00000001856BF3B8
		public void SetVolume(float volume) {} // 0x00000001856BF418-0x00000001856BF424
		public void SetFrequencyRatio(float frequencyRatio) {} // 0x00000001856BF3D0-0x00000001856BF3DC
		public void SetBusSendLevel(string busName, float level) {} // 0x00000001856BF3B8-0x00000001856BF3C4
		public void SetInputReadStream(CriAudioReadStream stream) {} // 0x00000001856BF3DC-0x00000001856BF418
		private static extern IntPtr criAtomAuxIn_Create(in Config config, IntPtr work, int work_size); // 0x00000001856BF514-0x00000001856BF5A8
		private static extern void criAtomAuxIn_Destroy(IntPtr aux_in); // 0x00000001856BF5A8-0x00000001856BF5DC
		private static extern void criAtomAuxIn_Start(IntPtr aux_in); // 0x00000001856BF838-0x00000001856BF86C
		private static extern void criAtomAuxIn_Stop(IntPtr aux_in); // 0x00000001856BF86C-0x00000001856BF8E4
		private static extern void criAtomAuxIn_SetVolume(IntPtr aux_in, float volume); // 0x00000001856BF7FC-0x00000001856BF838
		private static extern void criAtomAuxIn_SetFrequencyRatio(IntPtr aux_in, float ratio); // 0x00000001856BF764-0x00000001856BF7A8
		private static extern void criAtomAuxIn_SetBusSendLevelByName(IntPtr aux_in, string bus_name, float level); // 0x00000001856BF670-0x00000001856BF6D0
		private static extern void criAtomAuxIn_SetFormat(IntPtr aux_in, int num_channels, int sampling_rate); // 0x00000001856BF6D0-0x00000001856BF764
		private static extern void criAtomAuxIn_GetFormat(IntPtr aux_in, out int num_channels, out int sampling_rate); // 0x00000001856BF5DC-0x00000001856BF670
		private static extern void criAtomAuxIn_SetInputReadStream(IntPtr aux_in, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x00000001856BF7A8-0x00000001856BF7FC
	}

	public class CriAtomExMic : CriDisposable // TypeDefIndex: 54148
	{
		// Fields
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic."; // Metadata: 0x01FD63BE
		private const string errorInvalidBufferLength = "[CRIWARE] Invalid buffer length for CriAtomMic.ReadData."; // Metadata: 0x01FD63ED
		private const string errorInvalidNumBuffers = "[CRIWARE] Number of buffers are not same with channels of CriAtomMic."; // Metadata: 0x01FD6426
		private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized."; // Metadata: 0x01FD646D
		private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized."; // Metadata: 0x01FD64A1
		private IntPtr handle; // 0x20
		private IntPtr[] bufferPointers; // 0x28
		private GCHandle[] gcHandles; // 0x30
		private CriAudioWriteStream outputWriteStream; // 0x38
		private static int _initializationCount; // 0x04
	
		// Properties
		public static bool isInitialized { get; private set; } // 0x00000001856C20D0-0x00000001856C2108 0x00000001856C2108-0x00000001856C2144
	
		// Nested types
		public struct DeviceInfo // TypeDefIndex: 54145
		{
			// Fields
			public string deviceId; // 0x00
			public string deviceName; // 0x08
			public uint deviceFlags; // 0x10
			public int maxChannels; // 0x14
			public int maxSamplingRate; // 0x18
		}
	
		public struct Config // TypeDefIndex: 54146
		{
			// Fields
			public string deviceId; // 0x00
			public uint flags; // 0x08
			public int numChannels; // 0x0C
			public int samplingRate; // 0x10
			public uint frameSize; // 0x14
			public uint bufferingTime; // 0x18
			public IntPtr context; // 0x20
	
			// Properties
			public static Config Default { get => default; } // 0x00000001856B6200-0x00000001856B6250 
		}
	
		public class Effect // TypeDefIndex: 54147
		{
			// Properties
			public IntPtr handle { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000183D517C0-0x0000000183D517D0
			public IntPtr afxInstance { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
	
			// Constructors
			public Effect() {} // Dummy constructor
			public Effect(IntPtr handle, IntPtr afxInstance) {} // 0x0000000183D51BC0-0x0000000183D51BD0
		}
	
		// Constructors
		public CriAtomExMic() {} // Dummy constructor
		private CriAtomExMic(IntPtr handle) {} // 0x00000001856C1474-0x00000001856C1534
	
		// Methods
		public static void InitializeModule() {} // 0x00000001856C0F04-0x00000001856C0FA0
		public static void FinalizeModule() {} // 0x00000001856C0BBC-0x00000001856C0C80
		public static void SetupOutputCategoryForMic_IOS(bool enable) {} // 0x000000018350B670-0x000000018350B680
		public static DeviceInfo[] GetDevices() => default; // 0x00000001856C0D80-0x00000001856C0E50
		public static int GetNumDevices() => default; // 0x00000001856C0E8C-0x00000001856C0E94
		public static DeviceInfo? GetDefaultDevice() => default; // 0x00000001856C0C80-0x00000001856C0D80
		public static bool IsFormatSupported(Config config) => default; // 0x00000001856C1058-0x00000001856C1068
		public static CriAtomExMic Create(Config? config = default) => default; // 0x00000001856C09A4-0x00000001856C0AF0
		~CriAtomExMic() {} // 0x00000001856BDD0C-0x00000001856BDD80
		public override void Dispose() {} // 0x00000001856C0B6C-0x00000001856C0BBC
		private void Dispose(bool disposing) {} // 0x00000001856C0B14-0x00000001856C0B6C
		public void Start() {} // 0x00000001856C1438-0x00000001856C1444
		public void Stop() {} // 0x00000001856C1444-0x00000001856C1450
		public int GetNumChannels() => default; // 0x00000001856C0E80-0x00000001856C0E8C
		public int GetSamplingRate() => default; // 0x00000001856C0EF8-0x00000001856C0F04
		public uint GetNumBufferedSamples() => default; // 0x00000001856C0E74-0x00000001856C0E80
		[Obsolete("Use CriAtomExMic.GetNumBufferedSamples")]
		public uint GetNumBufferredSamples() => default; // 0x00000001856C0E74-0x00000001856C0E80
		public bool IsAvailable() => default; // 0x00000001856C1038-0x00000001856C1058
		public uint ReadData(float[] bufferMono) => default; // 0x00000001856C10CC-0x00000001856C10EC
		public uint ReadData(float[] bufferMono, uint numToRead) => default; // 0x00000001856C1210-0x00000001856C12A0
		public uint ReadData(float[] bufferL, float[] bufferR) => default; // 0x00000001856C1068-0x00000001856C1090
		public uint ReadData(float[] bufferL, float[] bufferR, uint numToRead) => default; // 0x00000001856C10EC-0x00000001856C1210
		public uint ReadData(float[][] buffers) => default; // 0x00000001856C1090-0x00000001856C10CC
		public uint ReadData(float[][] buffers, uint numToRead) => default; // 0x00000001856C12A0-0x00000001856C13A8
		public void SetOutputWriteStream(CriAudioWriteStream stream) {} // 0x00000001856C13F8-0x00000001856C1438
		public CriAudioReadStream GetOutputReadStream() => default; // 0x00000001856C0E94-0x00000001856C0EF8
		public Effect AttachEffect(IntPtr afxInterface, float[] configParameters) => default; // 0x00000001856C08FC-0x00000001856C09A4
		public void DetachEffect(Effect effect) {} // 0x00000001856C0AF0-0x00000001856C0B14
		public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue) {} // 0x00000001856C13CC-0x00000001856C13F8
		public float GetEffectParameter(Effect effect, int parameterIndex) => default; // 0x00000001856C0E50-0x00000001856C0E74
		public void SetEffectBypass(Effect effect, bool bypass) {} // 0x00000001856C13A8-0x00000001856C13CC
		public void UpdateEffectParameters(Effect effect) {} // 0x00000001856C1450-0x00000001856C1474
		private uint InternalReadDataFromBufferPointers(uint numToRead) => default; // 0x00000001856C1024-0x00000001856C1038
		private void InternalClearBuffers() {} // 0x00000001856C0FA0-0x00000001856C1024
		private static extern void criAtomMicUnity_Initialize(); // 0x00000001856C159C-0x00000001856C1604
		private static extern void criAtomMicUnity_Finalize(); // 0x00000001856C1534-0x00000001856C159C
		private static extern int criAtomMic_GetNumDevices(); // 0x00000001856C1C48-0x00000001856C1C74
		private static extern bool criAtomMic_GetDevice(int index, out DeviceInfo info); // 0x00000001856C19D0-0x00000001856C1ACC
		private static extern bool criAtomMic_GetDefaultDevice(out DeviceInfo info); // 0x00000001856C18E0-0x00000001856C19D0
		private static extern bool criAtomMic_IsFormatSupported(in Config config); // 0x00000001856C1D50-0x00000001856C1DFC
		private static extern IntPtr criAtomMic_Create(in Config config, IntPtr work, int work_size); // 0x00000001856C1760-0x00000001856C1828
		private static extern void criAtomMic_Destroy(IntPtr mic); // 0x00000001856C1828-0x00000001856C185C
		private static extern void criAtomMic_Start(IntPtr mic); // 0x00000001856C1FE0-0x00000001856C2058
		private static extern void criAtomMic_Stop(IntPtr mic); // 0x00000001856C2058-0x00000001856C208C
		private static extern int criAtomMic_GetNumChannels(IntPtr mic); // 0x00000001856C1C14-0x00000001856C1C48
		private static extern int criAtomMic_GetSamplingRate(IntPtr mic); // 0x00000001856C1CA0-0x00000001856C1D18
		private static extern uint criAtomMic_GetNumBufferedSamples(IntPtr mic); // 0x00000001856C1B9C-0x00000001856C1C14
		private static extern bool criAtomMic_IsAvailable(IntPtr mic); // 0x00000001856C1D18-0x00000001856C1D50
		private static extern uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples); // 0x00000001856C1DFC-0x00000001856C1E9C
		private static extern void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x00000001856C1F8C-0x00000001856C1FE0
		private static extern IntPtr criAtomMic_GetOutputReadStream(); // 0x00000001856C1C74-0x00000001856C1CA0
		private static extern int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters); // 0x00000001856C16B4-0x00000001856C1760
		private static extern IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters, IntPtr work, int work_size); // 0x00000001856C1604-0x00000001856C16B4
		private static extern void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect); // 0x00000001856C185C-0x00000001856C18E0
		private static extern IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect); // 0x00000001856C1ACC-0x00000001856C1B50
		private static extern void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass); // 0x00000001856C1E9C-0x00000001856C1F30
		private static extern void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value); // 0x00000001856C1F30-0x00000001856C1F8C
		private static extern float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index); // 0x00000001856C1B50-0x00000001856C1B9C
		private static extern void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect); // 0x00000001856C208C-0x00000001856C20D0
	}

	public class CriAtomExOutputAnalyzer : CriDisposable // TypeDefIndex: 54152
	{
		// Fields
		public const int MaximumSpectrumBands = 512; // Metadata: 0x01FD64D1
		protected IntPtr handle; // 0x20
		protected CriAtomExPlayer player; // 0x28
		protected string busName; // 0x30
		protected int numBands; // 0x38
		protected int numCapturedPcmSamples; // 0x3C
		protected PcmCaptureCallback userPcmCaptureCallback; // 0x40
		protected float[] dataL; // 0x48
		protected float[] dataR; // 0x50
		protected const int pcmCapturerNumMaxData = 512; // Metadata: 0x01FD64D3
		protected static IntPtr InternalCallbackFunctionPointer; // 0x00
		protected static InternalPcmCaptureCallback DelegateObject; // 0x08
		protected static float[] DataL; // 0x10
		protected static float[] DataR; // 0x18
		protected static PcmCaptureCallback UserPcmCaptureCallback; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		public delegate void PcmCaptureCallback(float[] dataL, float[] dataR, int numChannels, int numData); // TypeDefIndex: 54149; 0x0000000182097E50-0x0000000182097E70
	
		public struct Config // TypeDefIndex: 54150
		{
			// Fields
			public bool enableLevelmeter; // 0x00
			public bool enableSpectrumAnalyzer; // 0x01
			public bool enablePcmCapture; // 0x02
			public bool enablePcmCaptureCallback; // 0x03
			public int numSpectrumAnalyzerBands; // 0x04
			public int numCapturedPcmSamples; // 0x08
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		protected delegate void InternalPcmCaptureCallback(IntPtr dataL, IntPtr dataR, int numChannels, int numData); // TypeDefIndex: 54151; 0x0000000182097E50-0x0000000182097E70
	
		// Constructors
		public CriAtomExOutputAnalyzer(Config config) {} // 0x00000001856C2D80-0x00000001856C2E10
		protected CriAtomExOutputAnalyzer() {} // 0x00000001856C2D20-0x00000001856C2D80
		static CriAtomExOutputAnalyzer() {} // 0x00000001856C2CC0-0x00000001856C2D20
	
		// Methods
		public override void Dispose() {} // 0x00000001856C2568-0x00000001856C2574
		protected void Dispose(bool disposing) {} // 0x00000001856C2574-0x00000001856C2638
		public bool AttachExPlayer(CriAtomExPlayer player) => default; // 0x00000001856C21D8-0x00000001856C2290
		public void DetachExPlayer() {} // 0x00000001856C247C-0x00000001856C2568
		public bool AttachDspBus(string busName) => default; // 0x00000001856C2144-0x00000001856C21D8
		public void DetachDspBus() {} // 0x00000001856C2400-0x00000001856C247C
		public float GetRms(int channel) => default; // 0x00000001856C2A20-0x00000001856C2AC8
		public void GetSpectrumLevels(ref float[] levels) {} // 0x00000001856C2AC8-0x00000001856C2BB4
		public void GetPcmData(ref float[] data, int ch) {} // 0x00000001856C2928-0x00000001856C2A20
		public void SetPcmCaptureCallback(PcmCaptureCallback callback) {} // 0x0000000183CB2D80-0x0000000183CB2D90
		public void ExecutePcmCaptureCallback() {} // 0x00000001856C265C-0x00000001856C28B4
		[Obsolete("Use SetPcmCaptureCallback(PcmCaptureCallback) and ExecutePcmCaptureCallback()")]
		public void ExecutePcmCaptureCallback(PcmCaptureCallback callback) {} // 0x00000001856C2638-0x00000001856C265C
		~CriAtomExOutputAnalyzer() {} // 0x00000001856C28B4-0x00000001856C2928
		protected void InitializeWithConfig(Config config) {} // 0x00000001856C2BB4-0x00000001856C2CC0
		[AOT.MonoPInvokeCallback(typeof(InternalPcmCaptureCallback))]
		private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData) {} // 0x00000001856C2290-0x00000001856C2400
		protected static extern IntPtr criAtomExOutputAnalyzer_Create(in Config config); // 0x00000001856C2EAC-0x00000001856C2F64
		protected static extern void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer); // 0x00000001856C2F64-0x00000001856C2F98
		protected static extern void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player); // 0x00000001856C2E68-0x00000001856C2EAC
		protected static extern void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player); // 0x00000001856C2FF0-0x00000001856C3034
		protected static extern void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName); // 0x00000001856C2E10-0x00000001856C2E68
		protected static extern void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName); // 0x00000001856C2F98-0x00000001856C2FF0
		protected static extern float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel); // 0x00000001856C313C-0x00000001856C3178
		protected static extern IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer); // 0x00000001856C3178-0x00000001856C31F0
		protected static extern IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch); // 0x00000001856C30B8-0x00000001856C313C
		protected static extern void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback); // 0x00000001856C3034-0x00000001856C30B8
	}

	public struct CriAtomExPlayback // TypeDefIndex: 54155
	{
		// Fields
		public const uint invalidId = 4294967295; // Metadata: 0x01FD64D5
	
		// Properties
		public uint id { [IsReadOnly] get; private set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public Status status { get => default; } // 0x00000001856CED90-0x00000001856CED9C 
		public long time { get => default; } // 0x00000001856CEDA8-0x00000001856CEDB4 
		public long timeSyncedWithAudio { get => default; } // 0x00000001856CED9C-0x00000001856CEDA8 
	
		// Nested types
		public enum Status // TypeDefIndex: 54153
		{
			Prep = 1,
			Playing = 2,
			Removed = 3
		}
	
		public struct TrackInfo // TypeDefIndex: 54154
		{
			// Fields
			public uint id; // 0x00
			public CriAtomEx.CueType sequenceType; // 0x04
			public IntPtr playerHn; // 0x08
			public ushort trackNo; // 0x10
			public ushort reserved; // 0x12
		}
	
		// Constructors
		public CriAtomExPlayback(uint id) : this() {
	
		} // 0x0000000183D4E970-0x0000000183D4E980
	
		// Methods
		public void Stop(bool ignoresReleaseTime) {} // 0x00000001856CEE54-0x00000001856CEEB8
		public void Pause() {} // 0x00000001856CEDD8-0x00000001856CEDE4
		public void Resume(CriAtomEx.ResumeMode mode) {} // 0x00000001856CEDE4-0x00000001856CEDF0
		public bool IsPaused() => default; // 0x00000001856CEDC0-0x00000001856CEDCC
		public bool GetFormatInfo(out CriAtomEx.FormatInfo info) {
			info = default;
			return default;
		} // 0x00000001856CED6C-0x00000001856CED78
		public Status GetStatus() => default; // 0x00000001856CED90-0x00000001856CED9C
		public long GetTime() => default; // 0x00000001856CEDA8-0x00000001856CEDB4
		public long GetTimeSyncedWithAudio() => default; // 0x00000001856CED9C-0x00000001856CEDA8
		public bool GetNumPlayedSamples(out long numSamples, out int samplingRate) {
			numSamples = default;
			samplingRate = default;
			return default;
		} // 0x00000001856CED78-0x00000001856CED84
		public long GetSequencePosition() => default; // 0x00000001856CED84-0x00000001856CED90
		public int GetCurrentBlockIndex() => default; // 0x00000001856CED60-0x00000001856CED6C
		public bool GetTrackInfo(out TrackInfo info) {
			info = default;
			return default;
		} // 0x00000001856CEDB4-0x00000001856CEDC0
		public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info) {
			info = default;
			return default;
		} // 0x00000001856CED54-0x00000001856CED60
		public void SetNextBlockIndex(int index) {} // 0x00000001856CEDFC-0x00000001856CEE08
		public bool SetBeatSyncOffset(short timeMs) => default; // 0x00000001856CEDF0-0x00000001856CEDFC
		public void Stop() {} // 0x00000001856CEEB8-0x00000001856CEF04
		public void StopWithoutReleaseTime() {} // 0x00000001856CEE08-0x00000001856CEE54
		public void Pause(bool sw) {} // 0x00000001856CEDCC-0x00000001856CEDD8
		private static extern void criAtomExPlayback_Stop(uint id); // 0x00000001856CF688-0x00000001856CF700
		private static extern void criAtomExPlayback_StopWithoutReleaseTime(uint id); // 0x00000001856CF610-0x00000001856CF688
		private static extern void criAtomExPlayback_Pause(uint id, bool sw); // 0x00000001856CF404-0x00000001856CF488
		private static extern void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode); // 0x00000001856CF488-0x00000001856CF508
		private static extern bool criAtomExPlayback_IsPaused(uint id); // 0x00000001856CF38C-0x00000001856CF404
		private static extern Status criAtomExPlayback_GetStatus(uint id); // 0x00000001856CF224-0x00000001856CF29C
		private static extern bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info); // 0x00000001856CF004-0x00000001856CF08C
		private static extern long criAtomExPlayback_GetTime(uint id); // 0x00000001856CF314-0x00000001856CF38C
		private static extern long criAtomExPlayback_GetTimeSyncedWithAudio(uint id); // 0x00000001856CF29C-0x00000001856CF314
		private static extern bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate); // 0x00000001856CF08C-0x00000001856CF124
		private static extern long criAtomExPlayback_GetSequencePosition(uint id); // 0x00000001856CF1AC-0x00000001856CF224
		private static extern void criAtomExPlayback_SetNextBlockIndex(uint id, int index); // 0x00000001856CF590-0x00000001856CF610
		private static extern int criAtomExPlayback_GetCurrentBlockIndex(uint id); // 0x00000001856CEF8C-0x00000001856CF004
		private static extern bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info); // 0x00000001856CF124-0x00000001856CF1AC
		private static extern bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info); // 0x00000001856CEF04-0x00000001856CEF8C
		private static extern bool criAtomExPlayback_SetBeatSyncOffset(uint id, short timeMs); // 0x00000001856CF508-0x00000001856CF590
	}

	public class CriAtomExPlayer : CriDisposable // TypeDefIndex: 54160
	{
		// Fields
		private bool hasExistingNativeHandle; // 0x30
		private IntPtr entryPoolHandle; // 0x38
		private int _entryPoolCapacity; // 0x40
		private int max_path; // 0x44
		private IntPtr handle; // 0x48
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public bool isAvailable { get => default; } // 0x00000001856D2ECC-0x00000001856D2ED8 
		public int entryPoolCapacity { get => default; } // 0x0000000183D4ED80-0x0000000183D4ED90 
	
		// Events
		private event CriAtomExBeatSync.CbFunc _onBeatSyncCallback;
		public event CriAtomExBeatSync.CbFunc OnBeatSyncCallback;
		private event CriAtomExSequencer.EventCallback _onSequenceCallback;
		public event CriAtomExSequencer.EventCallback OnSequenceCallback;
	
		// Nested types
		public enum Status // TypeDefIndex: 54156
		{
			Stop = 0,
			Prep = 1,
			Playing = 2,
			PlayEnd = 3,
			Error = 4
		}
	
		private struct Config // TypeDefIndex: 54157
		{
			// Fields
			public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod; // 0x00
			public int maxPathStrings; // 0x04
			public int maxPath; // 0x08
			public int maxAisacs; // 0x0C
			public bool updatesTime; // 0x10
			public bool enableAudioSyncedTimer; // 0x11
		}
	
		public enum TimeStretchParameterId // TypeDefIndex: 54158
		{
			Ratio = 0,
			FrameTime = 1,
			Quality = 2
		}
	
		public enum PitchShifterParameterId // TypeDefIndex: 54159
		{
			Pitch = 0,
			Formant = 1,
			Mode = 2
		}
	
		// Constructors
		public CriAtomExPlayer() {} // 0x00000001856D08D8-0x00000001856D08FC
		public CriAtomExPlayer(int maxPath, int maxPathStrings) {} // 0x00000001856D08B8-0x00000001856D08D8
		public CriAtomExPlayer(bool enableAudioSyncedTimer) {} // 0x00000001856D0894-0x00000001856D08B8
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer) {} // 0x00000001856D0878-0x00000001856D0894
		public CriAtomExPlayer(IntPtr existingNativeHandle) {} // 0x00000001856D0854-0x00000001856D0878
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle) {} // 0x00000001856D08FC-0x00000001856D0A58
	
		// Methods
		public override void Dispose() {} // 0x00000001856CFE0C-0x00000001856CFF20
		public void SetCue(CriAtomExAcb acb, string name) {} // 0x00000001856D0530-0x00000001856D0548
		public void SetCue(CriAtomExAcb acb, int id) {} // 0x00000001856D0548-0x00000001856D0560
		public void SetCueIndex(CriAtomExAcb acb, int index) {} // 0x00000001856D050C-0x00000001856D0524
		public void SetContentId(CriFsBinder binder, int contentId) {} // 0x00000001856D04F4-0x00000001856D050C
		public void SetFile(CriFsBinder binder, string path) {} // 0x00000001856D0628-0x00000001856D0640
		public void SetData(byte[] buffer, int size) {} // 0x00000001856D056C-0x00000001856D0578
		public void SetData(IntPtr buffer, int size) {} // 0x00000001856D0560-0x00000001856D056C
		public void SetFormat(CriAtomEx.Format format) {} // 0x00000001856D064C-0x00000001856D0658
		public void SetNumChannels(int numChannels) {} // 0x00000001856D0664-0x00000001856D0670
		public void SetSamplingRate(int samplingRate) {} // 0x00000001856D06D0-0x00000001856D06DC
		public void PrepareEntryPool(int capacity, bool stopOnEmpty) {} // 0x00000001856D039C-0x00000001856D0408
		public int GetNumEntries() => default; // 0x00000001856D0228-0x00000001856D0248
		public int GetNumConsumedEntries() => default; // 0x00000001856D0208-0x00000001856D0228
		public bool EntryFile(CriFsBinder binder, string path, bool repeat) => default; // 0x00000001856CFFC0-0x00000001856CFFF4
		public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat) => default; // 0x00000001856CFF20-0x00000001856CFF4C
		public bool EntryData(byte[] buffer, int size, bool repeat) => default; // 0x00000001856CFF9C-0x00000001856CFFC0
		public bool EntryData(IntPtr buffer, int size, bool repeat) => default; // 0x00000001856CFF78-0x00000001856CFF9C
		public bool EntryCue(CriAtomExAcb acb, string name, bool repeat) => default; // 0x00000001856CFF4C-0x00000001856CFF78
		public CriAtomExPlayback Start() => default; // 0x00000001856D0750-0x00000001856D077C
		public CriAtomExPlayback Prepare() => default; // 0x00000001856D0408-0x00000001856D0414
		public void Stop(bool ignoresReleaseTime) {} // 0x00000001856D07B0-0x00000001856D07F0
		public void Pause() {} // 0x00000001856D0380-0x00000001856D0390
		public void Resume(CriAtomEx.ResumeMode mode) {} // 0x00000001856D042C-0x00000001856D0438
		public bool IsPaused() => default; // 0x00000001856D0290-0x00000001856D029C
		public void SetVolume(float volume) {} // 0x00000001856D0744-0x00000001856D0750
		public void SetPitch(float pitch) {} // 0x00000001856D06A0-0x00000001856D06AC
		public void SetPlaybackRatio(float ratio) {} // 0x00000001856D06AC-0x00000001856D06B8
		public void SetPan3dAngle(float angle) {} // 0x00000001856D0670-0x00000001856D067C
		public void SetPan3dInteriorDistance(float distance) {} // 0x00000001856D067C-0x00000001856D0688
		public void SetPan3dVolume(float volume) {} // 0x00000001856D0688-0x00000001856D0694
		public void SetPanType(CriAtomEx.PanType panType) {} // 0x00000001856D0694-0x00000001856D06A0
		public void SetSendLevel(int channel, CriAtomEx.Speaker id, float level) {} // 0x00000001856D06E8-0x00000001856D06FC
		public void SetBiquadFilterParameters(CriAtomEx.BiquadFilterType type, float frequency, float gain, float q) {} // 0x00000001856D0498-0x00000001856D04AC
		public void SetBandpassFilterParameters(float cofLow, float cofHigh) {} // 0x00000001856D048C-0x00000001856D0498
		public void SetBusSendLevel(string busName, float level) {} // 0x00000001856D04C4-0x00000001856D04D0
		public bool GetBusSendLevel(string busName, out float level) {
			level = default;
			return default;
		} // 0x00000001856D01FC-0x00000001856D0208
		[Obsolete("Use CriAtomExPlayer.SetBusSendLevel(string busName, float level)")]
		public void SetBusSendLevel(int busId, float level) {} // 0x00000001856D04D0-0x00000001856D04DC
		public void SetBusSendLevelOffset(string busName, float levelOffset) {} // 0x00000001856D04AC-0x00000001856D04B8
		public bool GetBusSendLevelOffset(string busName, out float level) {
			level = default;
			return default;
		} // 0x00000001856D01F0-0x00000001856D01FC
		[Obsolete("Use CriAtomExPlayer.SetBusSendLevelOffset(int busId, float levelOffset)")]
		public void SetBusSendLevelOffset(int busId, float levelOffset) {} // 0x00000001856D04B8-0x00000001856D04C4
		public void AttachAisac(string globalAisacName) {} // 0x00000001856CF820-0x00000001856CF82C
		public void DetachAisac(string globalAisacName) {} // 0x00000001856CFDC4-0x00000001856CFDD0
		public void SetAisacControl(string controlName, float value) {} // 0x00000001856D0468-0x00000001856D0474
		[Obsolete("Use CriAtomExPlayer.SetAisacControl")]
		public void SetAisac(string controlName, float value) {} // 0x00000001856D0468-0x00000001856D0474
		public void SetAisacControl(uint controlId, float value) {} // 0x00000001856D0474-0x00000001856D0480
		[Obsolete("Use SetAisacControl")]
		public void SetAisac(uint controlId, float value) {} // 0x00000001856D0474-0x00000001856D0480
		public bool GetAttachedAisacInfo(int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
			aisacInfo = default;
			return default;
		} // 0x00000001856CFFF4-0x00000001856D01F0
		public void Set3dSource(CriAtomEx3dSource source) {} // 0x00000001856D0450-0x00000001856D0468
		public void Set3dListener(CriAtomEx3dListener listener) {} // 0x00000001856D0438-0x00000001856D0450
		public void SetStartTime(long startTimeMs) {} // 0x00000001856D0714-0x00000001856D0720
		public void SetFirstBlockIndex(int index) {} // 0x00000001856D0640-0x00000001856D064C
		public void SetSelectorLabel(string selector, string label) {} // 0x00000001856D06DC-0x00000001856D06E8
		public void UnsetSelectorLabel(string selector) {} // 0x00000001856D0830-0x00000001856D083C
		public void ClearSelectorLabels() {} // 0x00000001856CFDB8-0x00000001856CFDC4
		public void SetCategory(int categoryId) {} // 0x00000001856D04DC-0x00000001856D04E8
		public void SetCategory(string categoryName) {} // 0x00000001856D04E8-0x00000001856D04F4
		public void UnsetCategory() {} // 0x00000001856D0824-0x00000001856D0830
		public void SetCuePriority(int priority) {} // 0x00000001856D0524-0x00000001856D0530
		public void SetVoicePriority(int priority) {} // 0x00000001856D0738-0x00000001856D0744
		public void SetVoiceControlMethod(CriAtomEx.VoiceControlMethod method) {} // 0x00000001856D0720-0x00000001856D072C
		public void SetPreDelayTime(float time) {} // 0x00000001856D06B8-0x00000001856D06C4
		public void SetEnvelopeAttackTime(float time) {} // 0x00000001856D05BC-0x00000001856D05C8
		public void SetEnvelopeHoldTime(float time) {} // 0x00000001856D05D4-0x00000001856D05E0
		public void SetEnvelopeDecayTime(float time) {} // 0x00000001856D05C8-0x00000001856D05D4
		public void SetEnvelopeReleaseTime(float time) {} // 0x00000001856D05E0-0x00000001856D05EC
		public void SetEnvelopeSustainLevel(float level) {} // 0x00000001856D05EC-0x00000001856D05F8
		public void AttachFader() {} // 0x00000001856CF82C-0x00000001856CF850
		public void DetachFader() {} // 0x00000001856CFDD0-0x00000001856CFDDC
		public void SetFadeOutTime(int ms) {} // 0x00000001856D061C-0x00000001856D0628
		public void SetFadeInTime(int ms) {} // 0x00000001856D0604-0x00000001856D0610
		public void SetFadeInStartOffset(int ms) {} // 0x00000001856D05F8-0x00000001856D0604
		public void SetFadeOutEndDelay(int ms) {} // 0x00000001856D0610-0x00000001856D061C
		public bool IsFading() => default; // 0x00000001856D0284-0x00000001856D0290
		public void ResetFaderParameters() {} // 0x00000001856D0414-0x00000001856D0420
		public void SetGroupNumber(int group_no) {} // 0x00000001856D0658-0x00000001856D0664
		public void Update(CriAtomExPlayback playback) {} // 0x00000001856D0848-0x00000001856D0854
		public void UpdateAll() {} // 0x00000001856D083C-0x00000001856D0848
		public void ResetParameters() {} // 0x00000001856D0420-0x00000001856D042C
		public long GetTime() => default; // 0x00000001856D0278-0x00000001856D0284
		public Status GetStatus() => default; // 0x00000001856D026C-0x00000001856D0278
		public float GetParameterFloat32(CriAtomEx.Parameter id) => default; // 0x00000001856D0248-0x00000001856D0254
		public uint GetParameterUint32(CriAtomEx.Parameter id) => default; // 0x00000001856D0260-0x00000001856D026C
		public int GetParameterSint32(CriAtomEx.Parameter id) => default; // 0x00000001856D0254-0x00000001856D0260
		public void SetSoundRendererType(CriAtomEx.SoundRendererType type) {} // 0x00000001856D0708-0x00000001856D0714
		public void SetRandomSeed(uint seed) {} // 0x00000001856D06C4-0x00000001856D06D0
		public void Loop(bool sw) {} // 0x00000001856D029C-0x00000001856D0318
		public void SetAsrRackId(int asr_rack_id) {} // 0x00000001856D0480-0x00000001856D048C
		public void SetVoicePoolIdentifier(uint identifier) {} // 0x00000001856D072C-0x00000001856D0738
		public void SetDspTimeStretchRatio(float ratio) {} // 0x00000001856D05A8-0x00000001856D05BC
		public void SetDspPitchShifterPitch(float pitch) {} // 0x00000001856D0584-0x00000001856D05A8
		public void SetDspParameter(int id, float value) {} // 0x00000001856D0578-0x00000001856D0584
		public void SetSequencePrepareTime(uint ms) {} // 0x00000001856D06FC-0x00000001856D0708
		public void AttachTween(CriAtomExTween tween) {} // 0x00000001856CF850-0x00000001856CF874
		public void DetachTween(CriAtomExTween tween) {} // 0x00000001856CFDE8-0x00000001856CFE0C
		public void DetachTweenAll() {} // 0x00000001856CFDDC-0x00000001856CFDE8
		public void Stop() {} // 0x00000001856D07F0-0x00000001856D0824
		public void StopWithoutReleaseTime() {} // 0x00000001856D077C-0x00000001856D07B0
		public void Pause(bool sw) {} // 0x00000001856D0390-0x00000001856D039C
		~CriAtomExPlayer() {} // 0x00000001856BDD0C-0x00000001856BDD80
		private void OnBeatSyncCallbackChainInternal(ref CriAtomExBeatSync.Info info) {} // 0x00000001856D0318-0x00000001856D034C
		private void OnSequenceCallbackChainInternal(ref CriAtomExSequencer.CriAtomExSequenceEventInfo info) {} // 0x00000001856D034C-0x00000001856D0380
		private static extern IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size); // 0x00000001856D0EB0-0x00000001856D0FC4
		private static extern void criAtomExPlayer_Destroy(IntPtr player); // 0x00000001856D0FC4-0x00000001856D0FF8
		private static extern void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id); // 0x00000001856D1DFC-0x00000001856D1E90
		private static extern void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name); // 0x00000001856D1F24-0x00000001856D1FCC
		private static extern void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index); // 0x00000001856D1E90-0x00000001856D1F24
		private static extern void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path); // 0x00000001856D2418-0x00000001856D24C0
		private static extern void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size); // 0x00000001856D20A0-0x00000001856D2140
		private static extern void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size); // 0x00000001856D200C-0x00000001856D20A0
		private static extern void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id); // 0x00000001856D1D68-0x00000001856D1DFC
		private static extern void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier); // 0x00000001856D2BA8-0x00000001856D2BE8
		private static extern uint criAtomExPlayer_Start(IntPtr player); // 0x00000001856D2CA8-0x00000001856D2D20
		private static extern uint criAtomExPlayer_Prepare(IntPtr player); // 0x00000001856D1698-0x00000001856D1710
		private static extern void criAtomExPlayer_Stop(IntPtr player); // 0x00000001856D2D54-0x00000001856D2D88
		private static extern void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player); // 0x00000001856D2D20-0x00000001856D2D54
		private static extern void criAtomExPlayer_Pause(IntPtr player, bool sw); // 0x00000001856D1614-0x00000001856D1698
		private static extern void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode); // 0x00000001856D17BC-0x00000001856D1840
		private static extern bool criAtomExPlayer_IsPaused(IntPtr player); // 0x00000001856D159C-0x00000001856D15D4
		private static extern Status criAtomExPlayer_GetStatus(IntPtr player); // 0x00000001856D14B8-0x00000001856D14EC
		private static extern long criAtomExPlayer_GetTime(IntPtr player); // 0x00000001856D14EC-0x00000001856D1564
		private static extern void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format); // 0x00000001856D2500-0x00000001856D2584
		private static extern void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels); // 0x00000001856D25C4-0x00000001856D2604
		private static extern void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate); // 0x00000001856D2884-0x00000001856D2908
		private static extern IntPtr CRIWAREF1DB6C3C(IntPtr player, int capacity, int max_path, bool stopOnEmpty); // 0x00000001856CFC5C-0x00000001856CFD00
		private static extern void CRIWARE348B99F2(IntPtr pool); // 0x00000001856CF990-0x00000001856CF9C4
		private static extern int CRIWAREB0CA8CB3(IntPtr pool); // 0x00000001856CFBF4-0x00000001856CFC28
		private static extern int CRIWAREF2104D05(IntPtr pool); // 0x00000001856CFD00-0x00000001856CFD34
		private static extern void CRIWAREBAFBC575(IntPtr pool); // 0x00000001856CFC28-0x00000001856CFC5C
		private static extern bool CRIWARE5277731E(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path); // 0x00000001856CF9C4-0x00000001856CFA94
		private static extern bool CRIWARE78E74FE0(IntPtr pool, IntPtr binder, int id, bool repeat); // 0x00000001856CFB58-0x00000001856CFBC0
		private static extern bool CRIWARE10CB0D07(IntPtr pool, byte[] buffer, int size, bool repeat); // 0x00000001856CF874-0x00000001856CF928
		private static extern bool CRIWARE10CB0D07(IntPtr pool, IntPtr buffer, int size, bool repeat); // 0x00000001856CF928-0x00000001856CF990
		private static extern bool CRIWARE59CCEB17(IntPtr pool, IntPtr acbhn, string name, bool repeat); // 0x00000001856CFA94-0x00000001856CFB58
		private static extern void CRIWARE94DBB2A3(IntPtr pool); // 0x00000001856CFBC0-0x00000001856CFBF4
		private static extern void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms); // 0x00000001856D2AA0-0x00000001856D2B24
		private static extern void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms); // 0x00000001856D2A20-0x00000001856D2A60
		private static extern void criAtomExPlayer_LimitLoopCount(IntPtr player, int count); // 0x00000001856D15D4-0x00000001856D1614
		private static extern void criAtomExPlayer_Update(IntPtr player, uint id); // 0x00000001856D2E48-0x00000001856D2ECC
		private static extern void criAtomExPlayer_UpdateAll(IntPtr player); // 0x00000001856D2E14-0x00000001856D2E48
		private static extern void criAtomExPlayer_ResetParameters(IntPtr player); // 0x00000001856D1788-0x00000001856D17BC
		private static extern float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001856D12FC-0x00000001856D1338
		private static extern uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001856D13BC-0x00000001856D1440
		private static extern int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001856D1338-0x00000001856D13BC
		private static extern IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player); // 0x00000001856D1440-0x00000001856D14B8
		private static extern void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, ushort id); // 0x00000001856D0CB8-0x00000001856D0D3C
		private static extern void criAtomExPlayer_SetVolume(IntPtr player, float volume); // 0x00000001856D2C6C-0x00000001856D2CA8
		private static extern void criAtomExPlayer_SetPitch(IntPtr player, float pitch); // 0x00000001856D274C-0x00000001856D2788
		private static extern void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio); // 0x00000001856D2788-0x00000001856D27C4
		private static extern void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle); // 0x00000001856D2604-0x00000001856D2640
		private static extern void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance); // 0x00000001856D2640-0x00000001856D2684
		private static extern void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume); // 0x00000001856D2684-0x00000001856D26C8
		private static extern void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType panType); // 0x00000001856D26C8-0x00000001856D274C
		private static extern void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level); // 0x00000001856D29C4-0x00000001856D2A20
		private static extern void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level); // 0x00000001856D1BFC-0x00000001856D1C4C
		private static extern void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level); // 0x00000001856D1AE8-0x00000001856D1B50
		private static extern bool criAtomExPlayer_GetBusSendLevelByName(IntPtr player, string bus_name, out float level); // 0x00000001856D1194-0x00000001856D1248
		private static extern void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset); // 0x00000001856D1BB0-0x00000001856D1BFC
		private static extern void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset); // 0x00000001856D1B50-0x00000001856D1BB0
		private static extern bool criAtomExPlayer_GetBusSendLevelOffsetByName(IntPtr player, string bus_name, out float level_offset); // 0x00000001856D1248-0x00000001856D12FC
		private static extern void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high); // 0x00000001856D1A40-0x00000001856D1A8C
		private static extern void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q); // 0x00000001856D1A8C-0x00000001856D1AE8
		private static extern void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority); // 0x00000001856D2BE8-0x00000001856D2C6C
		private static extern void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method); // 0x00000001856D2B24-0x00000001856D2BA8
		private static extern void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value); // 0x00000001856D1908-0x00000001856D1954
		private static extern void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value); // 0x00000001856D1954-0x00000001856D19BC
		private static extern void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source); // 0x00000001856D1884-0x00000001856D1908
		private static extern void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener); // 0x00000001856D1840-0x00000001856D1884
		private static extern void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id); // 0x00000001856D1C4C-0x00000001856D1CD0
		private static extern void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name); // 0x00000001856D1CD0-0x00000001856D1D68
		private static extern void criAtomExPlayer_UnsetCategory(IntPtr player); // 0x00000001856D2D88-0x00000001856D2DBC
		private static extern void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority); // 0x00000001856D1FCC-0x00000001856D200C
		private static extern void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms); // 0x00000001856D27C4-0x00000001856D2800
		private static extern void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms); // 0x00000001856D2190-0x00000001856D21D4
		private static extern void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms); // 0x00000001856D2210-0x00000001856D224C
		private static extern void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms); // 0x00000001856D21D4-0x00000001856D2210
		private static extern void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms); // 0x00000001856D224C-0x00000001856D2290
		private static extern void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level); // 0x00000001856D2290-0x00000001856D22D4
		private static extern void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size); // 0x00000001856D0D94-0x00000001856D0E38
		private static extern void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName); // 0x00000001856D0D3C-0x00000001856D0D94
		private static extern void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName); // 0x00000001856D0FF8-0x00000001856D1050
		private static extern void criAtomExPlayer_DetachFader(IntPtr player); // 0x00000001856D1050-0x00000001856D1084
		private static extern void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms); // 0x00000001856D23D8-0x00000001856D2418
		private static extern void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms); // 0x00000001856D2314-0x00000001856D2398
		private static extern void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms); // 0x00000001856D22D4-0x00000001856D2314
		private static extern void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms); // 0x00000001856D2398-0x00000001856D23D8
		private static extern bool criAtomExPlayer_IsFading(IntPtr player); // 0x00000001856D1564-0x00000001856D159C
		private static extern void criAtomExPlayer_ResetFaderParameters(IntPtr player); // 0x00000001856D1710-0x00000001856D1788
		private static extern void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no); // 0x00000001856D2584-0x00000001856D25C4
		private static extern bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info); // 0x00000001856D10FC-0x00000001856D1194
		private static extern void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index); // 0x00000001856D24C0-0x00000001856D2500
		private static extern void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label); // 0x00000001856D2908-0x00000001856D29C4
		private static extern void criAtomExPlayer_UnsetSelectorLabel(IntPtr player, string selector); // 0x00000001856D2DBC-0x00000001856D2E14
		private static extern void criAtomExPlayer_ClearSelectorLabels(IntPtr player); // 0x00000001856D0E7C-0x00000001856D0EB0
		private static extern void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type); // 0x00000001856D2A60-0x00000001856D2AA0
		private static extern void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed); // 0x00000001856D2800-0x00000001856D2884
		private static extern void CRIWAREF466419F(IntPtr player, bool sw); // 0x00000001856CFD34-0x00000001856CFDB8
		private static extern void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id); // 0x00000001856D19BC-0x00000001856D1A40
		private static extern void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value); // 0x00000001856D2140-0x00000001856D2190
		private static extern void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween); // 0x00000001856D0E38-0x00000001856D0E7C
		private static extern void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween); // 0x00000001856D10B8-0x00000001856D10FC
		private static extern void criAtomExPlayer_DetachTweenAll(IntPtr player); // 0x00000001856D1084-0x00000001856D10B8
	}

	[Obsolete("Use CriAtomExOutputAnalyzer")]
	public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer // TypeDefIndex: 54163
	{
		// Nested types
		public enum Type // TypeDefIndex: 54161
		{
			LevelMeter = 0,
			SpectrumAnalyzer = 1,
			PcmCapture = 2
		}
	
		public struct Config // TypeDefIndex: 54162
		{
			// Fields
			public int num_spectrum_analyzer_bands; // 0x00
			public int num_stored_output_data; // 0x04
	
			// Constructors
			public Config(int num_spectrum_analyzer_bands = 8 /* Metadata: 0x01FD64E7 */, int num_stored_output_data = 4096 /* Metadata: 0x01FD64E8 */) {
				this.num_spectrum_analyzer_bands = default;
				this.num_stored_output_data = default;
			} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		}
	
		// Constructors
		public CriAtomExPlayerOutputAnalyzer() {} // Dummy constructor
		public CriAtomExPlayerOutputAnalyzer(Type[] types, Config[] configs = null) {} // 0x00000001856CF700-0x00000001856CF820
	}

	public class CriAtomExSoundObject : CriDisposable // TypeDefIndex: 54165
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		private struct Config // TypeDefIndex: 54164
		{
			// Fields
			public bool enableVoiceLimitScope; // 0x00
			public bool enableCategoryCueLimitScope; // 0x01
		}
	
		// Constructors
		public CriAtomExSoundObject() {} // Dummy constructor
		public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope) {} // 0x00000001856D33B0-0x00000001856D34B4
	
		// Methods
		public override void Dispose() {} // 0x00000001856D3334-0x00000001856D33B0
		public void AddPlayer(CriAtomExPlayer player) {} // 0x00000001856D32E0-0x00000001856D3304
		public void DeletePlayer(CriAtomExPlayer player) {} // 0x00000001856D3310-0x00000001856D3334
		public void DeleteAllPlayers() {} // 0x00000001856D3304-0x00000001856D3310
		~CriAtomExSoundObject() {} // 0x00000001856BDD0C-0x00000001856BDD80
		private static extern IntPtr criAtomExSoundObject_Create(ref Config config, IntPtr work, int work_size); // 0x00000001856D3538-0x00000001856D35FC
		private static extern void criAtomExSoundObject_Destroy(IntPtr soundObject); // 0x00000001856D36B8-0x00000001856D36EC
		private static extern void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player); // 0x00000001856D34B4-0x00000001856D3538
		private static extern void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player); // 0x00000001856D3674-0x00000001856D36B8
		private static extern void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject); // 0x00000001856D35FC-0x00000001856D3674
	}

	public class CriAtomExTween : CriDisposable // TypeDefIndex: 54169
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		internal IntPtr nativeHandle { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public float Value { get => default; } // 0x00000001856D3E48-0x00000001856D3E54 
		public bool IsActive { get => default; } // 0x00000001856D3E3C-0x00000001856D3E48 
	
		// Nested types
		public enum ParameterType // TypeDefIndex: 54166
		{
			Basic = 0,
			Aisac = 1
		}
	
		private struct Config // TypeDefIndex: 54168
		{
			// Fields
			public Target target; // 0x00
			public ParameterType parameterType; // 0x04
	
			// Nested types
			public struct Target // TypeDefIndex: 54167
			{
				// Fields
				public CriAtomEx.Parameter parameterId; // 0x00
				public uint aisacIds; // 0x00
			}
		}
	
		// Constructors
		public CriAtomExTween() {} // 0x00000001856D3A58-0x00000001856D3A68
		public CriAtomExTween(CriAtomEx.Parameter parameterId) {} // 0x00000001856D3B78-0x00000001856D3B88
		public CriAtomExTween(uint aisacId) {} // 0x00000001856D3B68-0x00000001856D3B78
		public CriAtomExTween(ParameterType parameterType, uint targetId) {} // 0x00000001856D3A68-0x00000001856D3B68
	
		// Methods
		public override void Dispose() {} // 0x00000001856D391C-0x00000001856D3928
		public void MoveTo(ushort durationMs, float value) {} // 0x00000001856D3A34-0x00000001856D3A40
		public void MoveFrom(ushort durationMs, float value) {} // 0x00000001856D3A28-0x00000001856D3A34
		public void Stop() {} // 0x00000001856D3A4C-0x00000001856D3A58
		public void Reset() {} // 0x00000001856D3A40-0x00000001856D3A4C
		~CriAtomExTween() {} // 0x00000001856D39B4-0x00000001856D3A28
		protected virtual void Dispose(bool disposing) {} // 0x00000001856D3928-0x00000001856D39B4
		private static extern IntPtr criAtomExTween_Create(ref Config config, IntPtr work, int work_size); // 0x00000001856D3B88-0x00000001856D3C1C
		private static extern void criAtomExTween_Destroy(IntPtr tween); // 0x00000001856D3C1C-0x00000001856D3C94
		private static extern float criAtomExTween_GetValue(IntPtr tween); // 0x00000001856D3C94-0x00000001856D3CC0
		private static extern void criAtomExTween_MoveTo(IntPtr tween, ushort time_ms, float value); // 0x00000001856D3D44-0x00000001856D3D90
		private static extern void criAtomExTween_MoveFrom(IntPtr tween, ushort time_ms, float value); // 0x00000001856D3CF8-0x00000001856D3D44
		private static extern void criAtomExTween_Stop(IntPtr tween); // 0x00000001856D3DC4-0x00000001856D3E3C
		private static extern void criAtomExTween_Reset(IntPtr tween); // 0x00000001856D3D90-0x00000001856D3DC4
		private static extern bool criAtomExTween_IsActive(IntPtr tween); // 0x00000001856D3CC0-0x00000001856D3CF8
	}

	public abstract class CriAtomExVoicePool : CriDisposable // TypeDefIndex: 54179
	{
		// Fields
		public const int StandardMemoryAsrVoicePoolId = 0; // Metadata: 0x01FD64F0
		public const int StandardStreamingAsrVoicePoolId = 1; // Metadata: 0x01FD64F1
		public const int StandardMemoryNsrVoicePoolId = 2; // Metadata: 0x01FD64F2
		public const int StandardStreamingNsrVoicePoolId = 3; // Metadata: 0x01FD64F3
		protected IntPtr _handle; // 0x20
		protected uint _identifier; // 0x28
		protected int _numVoices; // 0x2C
		protected int _maxChannels; // 0x30
		protected int _maxSamplingRate; // 0x34
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public uint identifier { get; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		public int numVoices { get; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 
		public int maxChannels { get; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public int maxSamplingRate { get; } // 0x0000000183D4EE00-0x0000000183D4EE10 
	
		// Nested types
		public enum VoicePoolId // TypeDefIndex: 54170
		{
			StandardMemory = 0,
			StandardStreaming = 1,
			HcaMxMemory = 4,
			HcaMxStreaming = 5
		}
	
		public enum PitchShifterMode // TypeDefIndex: 54171
		{
			Music = 0,
			Vocal = 1,
			SoundEffect = 2,
			Speech = 3
		}
	
		public struct UsedVoicesInfo // TypeDefIndex: 54172
		{
			// Fields
			public int numUsedVoices; // 0x00
			public int numPoolVoices; // 0x04
		}
	
		protected struct PlayerConfig // TypeDefIndex: 54173
		{
			// Fields
			public int maxChannels; // 0x00
			public int maxSamplingRate; // 0x04
			public bool streamingFlag; // 0x08
			public int soundRendererType; // 0x0C
			public int decodeLatency; // 0x10
			private IntPtr context; // 0x18
		}
	
		protected struct VoicePoolConfig // TypeDefIndex: 54174
		{
			// Fields
			public uint identifier; // 0x00
			public int numVoices; // 0x04
			public PlayerConfig playerConfig; // 0x08
		}
	
		private struct PitchShifterConfig // TypeDefIndex: 54175
		{
			// Fields
			public int mode; // 0x00
			public int windowSize; // 0x04
			public int overlapTimes; // 0x08
		}
	
		private struct ExPitchShifterConfig // TypeDefIndex: 54176
		{
			// Fields
			public int numDsp; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public PitchShifterConfig config; // 0x0C
		}
	
		private struct TimeStretchConfig // TypeDefIndex: 54177
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private struct ExTimeStretchConfig // TypeDefIndex: 54178
		{
			// Fields
			public int numDsp; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public TimeStretchConfig config; // 0x0C
		}
	
		// Constructors
		protected CriAtomExVoicePool() {} // 0x00000001856D4068-0x00000001856D4078
	
		// Methods
		public static UsedVoicesInfo GetNumUsedVoices(VoicePoolId voicePoolId) => default; // 0x00000001856D4008-0x00000001856D4034
		public override void Dispose() {} // 0x00000001856D3F8C-0x00000001856D4008
		public UsedVoicesInfo GetNumUsedVoices() => default; // 0x00000001856D4034-0x00000001856D4068
		public void AttachDspTimeStretch() {} // 0x00000001856D3EA0-0x00000001856D3EE4
		public void AttachDspPitchShifter(PitchShifterMode mode = PitchShifterMode.Music /* Metadata: 0x01FD64EC */, int windosSize = 1024 /* Metadata: 0x01FD64ED */, int overlapTimes = 4 /* Metadata: 0x01FD64EF */) {} // 0x00000001856D3E54-0x00000001856D3EA0
		public void DetachDsp() {} // 0x00000001856D3F78-0x00000001856D3F8C
		~CriAtomExVoicePool() {} // 0x00000001856BDD0C-0x00000001856BDD80
		private static extern void CRIWARED389B244(int voice_pool_id, out int num_used_voices, out int num_pool_voices); // 0x00000001856D3EE4-0x00000001856D3F78
		private static extern void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices); // 0x00000001856D4228-0x00000001856D42BC
		public static extern void criAtomExVoicePool_Free(IntPtr pool); // 0x00000001856D41F4-0x00000001856D4228
		private static extern void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref ExTimeStretchConfig config, IntPtr work, int work_size); // 0x00000001856D411C-0x00000001856D41C0
		private static extern void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref ExPitchShifterConfig config, IntPtr work, int work_size); // 0x00000001856D4078-0x00000001856D411C
		private static extern void criAtomExVoicePool_DetachDsp(IntPtr pool); // 0x00000001856D41C0-0x00000001856D41F4
	}

	public class CriAtomExStandardVoicePool : CriAtomExVoicePool // TypeDefIndex: 54180
	{
		// Constructors
		public CriAtomExStandardVoicePool() {} // Dummy constructor
		public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x01FD64FC */) {} // 0x00000001856D36EC-0x00000001856D3818
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x00000001856D3818-0x00000001856D391C
	}

	public class CriAtomExWaveVoicePool : CriAtomExVoicePool // TypeDefIndex: 54181
	{
		// Constructors
		public CriAtomExWaveVoicePool() {} // Dummy constructor
		public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x01FD64FD */) {} // 0x00000001856D42BC-0x00000001856D43E8
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x00000001856D43E8-0x00000001856D44EC
	}

	public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool // TypeDefIndex: 54185
	{
		// Nested types
		public enum RawPcmFormat // TypeDefIndex: 54182
		{
			Sint16 = 0,
			Float32 = 1
		}
	
		protected struct RawPcmPlayerConfig // TypeDefIndex: 54183
		{
			// Fields
			public RawPcmFormat format; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public int soundRendererType; // 0x0C
			public int decodeLatency; // 0x10
			private IntPtr context; // 0x18
		}
	
		protected struct RawPcmVoicePoolConfig // TypeDefIndex: 54184
		{
			// Fields
			public uint identifier; // 0x00
			public int numVoices; // 0x04
			public RawPcmPlayerConfig playerConfig; // 0x08
		}
	
		// Constructors
		public CriAtomExRawPcmVoicePool() {} // Dummy constructor
		public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, RawPcmFormat format, uint identifier = 0 /* Metadata: 0x01FD64FE */) {} // 0x00000001856D3128-0x00000001856D3250
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref RawPcmVoicePoolConfig config, IntPtr work, int work_size); // 0x00000001856D3250-0x00000001856D32E0
	}

	public class CriAudioReadStream // TypeDefIndex: 54189
	{
		// Fields
		private InternalDelegate internalDelegate; // 0x10
	
		// Properties
		public IntPtr callbackFunction { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
		public IntPtr callbackPointer { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000183D4ED30-0x0000000183D4ED40
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 54186; 0x0000000181035ED0-0x0000000181035EF0
	
		public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 54187; 0x0000000181165340-0x0000000181165350
	
		// Constructors
		public CriAudioReadStream() {} // Dummy constructor
		public CriAudioReadStream(IntPtr callbackFunction, IntPtr callbackPointer) {} // 0x0000000183D51C80-0x0000000183D51C90
		public CriAudioReadStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x01FD6501 */) {} // 0x00000001856D44EC-0x00000001856D466C
	}

	public class CriAudioWriteStream // TypeDefIndex: 54193
	{
		// Fields
		private InternalDelegate internalDelegate; // 0x10
	
		// Properties
		public IntPtr callbackFunction { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
		public IntPtr callbackPointer { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000183D4ED30-0x0000000183D4ED40
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 54190; 0x0000000181035ED0-0x0000000181035EF0
	
		public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 54191; 0x0000000181165340-0x0000000181165350
	
		// Constructors
		public CriAudioWriteStream() {} // Dummy constructor
		public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer) {} // 0x0000000183D51C80-0x0000000183D51C90
		public CriAudioWriteStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x01FD6503 */) {} // 0x00000001856D466C-0x00000001856D47EC
	}

	public class CriFsLoader : CriDisposable // TypeDefIndex: 54195
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle dstGch; // 0x28
		private GCHandle srcGch; // 0x30
	
		// Nested types
		public enum Status // TypeDefIndex: 54194
		{
			Stop = 0,
			Loading = 1,
			Complete = 2,
			Error = 3
		}
	
		// Constructors
		public CriFsLoader() {} // 0x00000001856D8398-0x00000001856D84C8
	
		// Methods
		public override void Dispose() {} // 0x00000001856D7F8C-0x00000001856D7FDC
		private void Dispose(bool disposing) {} // 0x00000001856D7EFC-0x00000001856D7F8C
		public void Load(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer) {} // 0x00000001856D82BC-0x00000001856D836C
		public void LoadById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer) {} // 0x00000001856D80AC-0x00000001856D815C
		public void LoadWithoutDecompression(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer) {} // 0x00000001856D820C-0x00000001856D82BC
		public void LoadWithoutDecompressionById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer) {} // 0x00000001856D815C-0x00000001856D820C
		public void DecompressData(long srcSize, byte[] srcBuffer, long dstSize, byte[] dstBuffer) {} // 0x00000001856D7E58-0x00000001856D7EFC
		public void Stop() {} // 0x00000001856D8384-0x00000001856D8398
		public Status GetStatus() => default; // 0x00000001856D8050-0x00000001856D80AC
		public void SetReadUnitSize(int unit_size) {} // 0x00000001856D836C-0x00000001856D8384
		~CriFsLoader() {} // 0x00000001856D7FDC-0x00000001856D8050
		private static extern int criFsLoader_Create(out IntPtr loader); // 0x00000001856D84C8-0x00000001856D8540
		private static extern int criFsLoader_Destroy(IntPtr loader); // 0x00000001856D85E4-0x00000001856D8618
		private static extern int criFsLoader_Load(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x00000001856D88CC-0x00000001856D89B4
		private static extern int criFsLoader_LoadById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x00000001856D869C-0x00000001856D8740
		private static extern int criFsLoader_Stop(IntPtr loader); // 0x00000001856D8A38-0x00000001856D8AB0
		private static extern int criFsLoader_GetStatus(IntPtr loader, out Status status); // 0x00000001856D8618-0x00000001856D869C
		private static extern int criFsLoader_SetReadUnitSize(IntPtr loader, long unit_size); // 0x00000001856D89B4-0x00000001856D8A38
		private static extern int criFsLoader_LoadWithoutDecompression(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x00000001856D87E4-0x00000001856D88CC
		private static extern int criFsLoader_LoadWithoutDecompressionById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x00000001856D8740-0x00000001856D87E4
		private static extern int criFsLoader_DecompressData(IntPtr loader, IntPtr src, long src_size, IntPtr dst, long dst_size); // 0x00000001856D8540-0x00000001856D85E4
	}

	public class CriFsInstaller : CriDisposable // TypeDefIndex: 54198
	{
		// Fields
		private byte[] installBuffer; // 0x20
		private GCHandle installBufferGch; // 0x28
		private IntPtr handle; // 0x30
	
		// Nested types
		public enum Status // TypeDefIndex: 54196
		{
			Stop = 0,
			Busy = 1,
			Complete = 2,
			Error = 3
		}
	
		private enum CopyPolicy // TypeDefIndex: 54197
		{
			Always = 0
		}
	
		// Constructors
		public CriFsInstaller() {} // 0x00000001856D7324-0x00000001856D7458
	
		// Methods
		public override void Dispose() {} // 0x00000001856D715C-0x00000001856D71AC
		private void Dispose(bool disposing) {} // 0x00000001856D71AC-0x00000001856D7238
		public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize) {} // 0x00000001856D6F2C-0x00000001856D715C
		public void Stop() {} // 0x00000001856D7310-0x00000001856D7324
		public Status GetStatus() => default; // 0x00000001856D72E4-0x00000001856D7310
		public float GetProgress() => default; // 0x00000001856D72B4-0x00000001856D72E4
		public static void ExecuteMain() {} // 0x00000001856D7238-0x00000001856D7240
		~CriFsInstaller() {} // 0x00000001856D7240-0x00000001856D72B4
		private static extern int criFsInstaller_ExecuteMain(); // 0x00000001856D7608-0x00000001856D7634
		private static extern int criFsInstaller_Create(out IntPtr installer, CopyPolicy option); // 0x00000001856D7550-0x00000001856D75D4
		private static extern int criFsInstaller_Destroy(IntPtr installer); // 0x00000001856D75D4-0x00000001856D7608
		private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size); // 0x00000001856D7458-0x00000001856D7550
		private static extern int criFsInstaller_Stop(IntPtr installer); // 0x00000001856D773C-0x00000001856D7770
		private static extern int criFsInstaller_GetStatus(IntPtr installer, out Status status); // 0x00000001856D76B8-0x00000001856D773C
		private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress); // 0x00000001856D7634-0x00000001856D76B8
	}

	public class CriFsBinder : CriDisposable // TypeDefIndex: 54201
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		public enum Status // TypeDefIndex: 54199
		{
			None = 0,
			Analyze = 1,
			Complete = 2,
			Unbind = 3,
			Removed = 4,
			Invalid = 5,
			Error = 6
		}
	
		public struct ContentsFileInfo // TypeDefIndex: 54200
		{
			// Fields
			public readonly string directory; // 0x00
			public readonly string fileName; // 0x08
			public uint readSize; // 0x10
			public uint extractSize; // 0x14
			public ulong offset; // 0x18
			public int fileId; // 0x20
			private string userStr; // 0x28
	
			// Constructors
			public ContentsFileInfo(byte[] data, int startIndex) {
				directory = default;
				fileName = default;
				readSize = default;
				extractSize = default;
				offset = default;
				fileId = default;
				userStr = default;
			} // 0x00000001856CDC6C-0x00000001856CDD84
		}
	
		// Constructors
		public CriFsBinder() {} // 0x00000001856D6270-0x00000001856D63A0
	
		// Methods
		public override void Dispose() {} // 0x00000001856D58B4-0x00000001856D5904
		private void Dispose(bool disposing) {} // 0x00000001856D5904-0x00000001856D595C
		public uint BindCpk(CriFsBinder srcBinder, string path) => default; // 0x00000001856D570C-0x00000001856D5754
		public uint BindDirectory(CriFsBinder srcBinder, string path) => default; // 0x00000001856D5754-0x00000001856D579C
		public uint BindFile(CriFsBinder srcBinder, string path) => default; // 0x00000001856D57FC-0x00000001856D583C
		public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName) => default; // 0x00000001856D579C-0x00000001856D57FC
		public static void Unbind(uint bindId) {} // 0x00000001856D6224-0x00000001856D6270
		public static Status GetStatus(uint bindId) => default; // 0x00000001856D6170-0x00000001856D61CC
		public long GetFileSize(string path) => default; // 0x00000001856D612C-0x00000001856D6168
		public long GetFileSize(int id) => default; // 0x00000001856D60F0-0x00000001856D612C
		public bool GetContentsFileInfo(string path, out ContentsFileInfo info) {
			info = default;
			return default;
		} // 0x00000001856D5D10-0x00000001856D5F00
		public bool GetContentsFileInfo(int id, out ContentsFileInfo info) {
			info = default;
			return default;
		} // 0x00000001856D5F00-0x00000001856D60F0
		public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info) {
			info = default;
			return default;
		} // 0x00000001856D59D0-0x00000001856D5D10
		public static int GetNumContentsFiles(uint bindId) => default; // 0x00000001856D6168-0x00000001856D6170
		public static void SetPriority(uint bindId, int priority) {} // 0x00000001856D61CC-0x00000001856D6224
		~CriFsBinder() {} // 0x00000001856D595C-0x00000001856D59D0
		private static extern uint criFsBinder_Create(out IntPtr binder); // 0x00000001856D6748-0x00000001856D67C0
		private static extern uint criFsBinder_Destroy(IntPtr binder); // 0x00000001856D67C0-0x00000001856D6838
		private static extern uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x00000001856D63A0-0x00000001856D6478
		private static extern uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x00000001856D6478-0x00000001856D6550
		private static extern uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x00000001856D6670-0x00000001856D6748
		private static extern uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId); // 0x00000001856D6550-0x00000001856D6670
		private static extern int criFsBinder_Unbind(uint bindId); // 0x00000001856D6C64-0x00000001856D6CDC
		private static extern int criFsBinder_GetStatus(uint bindId, out Status status); // 0x00000001856D6B60-0x00000001856D6BE4
		private static extern int criFsBinder_GetFileSize(IntPtr binder, string path, out long size); // 0x00000001856D6AB0-0x00000001856D6B60
		private static extern int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size); // 0x00000001856D6A1C-0x00000001856D6AB0
		private static extern int criFsBinder_SetPriority(uint bindId, int priority); // 0x00000001856D6BE4-0x00000001856D6C64
		private static extern int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info); // 0x00000001856D696C-0x00000001856D6A1C
		private static extern int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info); // 0x00000001856D6838-0x00000001856D68CC
		private static extern int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num); // 0x00000001856D68CC-0x00000001856D696C
		private static extern int CRIWAREF02BA103(uint id); // 0x00000001856D583C-0x00000001856D58B4
	}

	public class CriFsRequest : CriDisposable // TypeDefIndex: 54204
	{
		// Properties
		public DoneDelegate doneDelegate { get; protected set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool isDone { get; private set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public string error { get; protected set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public bool isDisposed { get; protected set; } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
	
		// Nested types
		public delegate void DoneDelegate(CriFsRequest request); // TypeDefIndex: 54202; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public CriFsRequest() {} // 0x00000001856D6F24-0x00000001856D6F2C
	
		// Methods
		public override void Dispose() {} // 0x00000001856D8FC8-0x00000001856D9024
		public virtual void Stop() {} // 0x000000018350B670-0x000000018350B680
		public YieldInstruction WaitForDone(MonoBehaviour mb) => default; // 0x00000001856D90C8-0x00000001856D90F8
		protected virtual void Dispose(bool disposing) {} // 0x000000018350B670-0x000000018350B680
		public virtual void Update() {} // 0x000000018350B670-0x000000018350B680
		protected void Done() {} // 0x00000001856D9024-0x00000001856D9044
		[IteratorStateMachine(typeof(_CheckDone_d__23))]
		private IEnumerator CheckDone() => default; // 0x00000001856D8F6C-0x00000001856D8FC8
		~CriFsRequest() {} // 0x00000001856D9044-0x00000001856D90C8
	}

	public class CriFsLoadFileRequest : CriFsRequest // TypeDefIndex: 54206
	{
		// Fields
		private Phase phase; // 0x50
		private CriFsBinder refBinder; // 0x58
		private CriFsBinder newBinder; // 0x60
		private uint bindId; // 0x68
		private CriFsLoader loader; // 0x70
		private int readUnitSize; // 0x78
		private long fileSize; // 0x80
	
		// Properties
		public string path { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public byte[] bytes { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
		// Nested types
		private enum Phase // TypeDefIndex: 54205
		{
			Stop = 0,
			Bind = 1,
			Load = 2,
			Done = 3,
			Error = 4
		}
	
		// Constructors
		public CriFsLoadFileRequest() {} // Dummy constructor
		public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize) {} // 0x00000001856D7D0C-0x00000001856D7E58
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x00000001856D796C-0x00000001856D7A00
		public override void Stop() {} // 0x00000001856D7AB4-0x00000001856D7AE0
		public override void Update() {} // 0x00000001856D7CD0-0x00000001856D7D0C
		private void UpdateBinder() {} // 0x00000001856D7AE0-0x00000001856D7B48
		private void UpdateLoader() {} // 0x00000001856D7B48-0x00000001856D7CD0
		private void OnError() {} // 0x00000001856D7A00-0x00000001856D7AB4
	}

	public class CriFsLoadAssetBundleRequest : CriFsRequest // TypeDefIndex: 54207
	{
		// Fields
		private CriFsLoadFileRequest loadFileReq; // 0x50
		private AssetBundleCreateRequest assetBundleReq; // 0x58
	
		// Properties
		public string path { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public AssetBundle assetBundle { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
		// Constructors
		public CriFsLoadAssetBundleRequest() {} // Dummy constructor
		public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize) {} // 0x00000001856D78CC-0x00000001856D796C
	
		// Methods
		public override void Update() {} // 0x00000001856D77D4-0x00000001856D78CC
		protected override void Dispose(bool disposing) {} // 0x00000001856D7770-0x00000001856D77D4
	}

	public class CriFsInstallRequest : CriFsRequest // TypeDefIndex: 54208
	{
		// Properties
		public string sourcePath { get; protected set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public string destinationPath { get; protected set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public float progress { get; protected set; } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
	
		// Constructors
		public CriFsInstallRequest() {} // 0x00000001856D6F24-0x00000001856D6F2C
	}

	public class CriFsInstallRequestLegacy : CriFsInstallRequest // TypeDefIndex: 54209
	{
		// Fields
		private CriFsInstaller installer; // 0x58
	
		// Constructors
		public CriFsInstallRequestLegacy() {} // Dummy constructor
		public CriFsInstallRequestLegacy(CriFsBinder srcBinder, string srcPath, string dstPath, DoneDelegate doneDelegate, int installBufferSize) {} // 0x00000001856D6E10-0x00000001856D6F24
	
		// Methods
		public override void Stop() {} // 0x00000001856D6D40-0x00000001856D6D68
		public override void Update() {} // 0x00000001856D6D68-0x00000001856D6E10
		protected override void Dispose(bool disposing) {} // 0x00000001856D6CDC-0x00000001856D6D40
	}

	public class CriFsWebInstallRequest : CriFsInstallRequest // TypeDefIndex: 54210
	{
		// Fields
		private CriFsWebInstaller installer; // 0x58
		private uint crc32; // 0x60
		private bool crc32_set; // 0x64
	
		// Constructors
		public CriFsWebInstallRequest() {} // Dummy constructor
		public CriFsWebInstallRequest(string srcPath, string dstPath, DoneDelegate doneDelegate) {} // 0x00000001856DA3D0-0x00000001856DA4D4
	
		// Methods
		public override void Stop() {} // 0x00000001856DA230-0x00000001856DA258
		public bool GetCRC32(out uint ret_val) {
			ret_val = default;
			return default;
		} // 0x0000000183D51CB0-0x0000000183D51CC0
		public override void Update() {} // 0x00000001856DA258-0x00000001856DA3D0
		protected override void Dispose(bool disposing) {} // 0x00000001856DA1CC-0x00000001856DA230
	}

	public class CriFsBindRequest : CriFsRequest // TypeDefIndex: 54212
	{
		// Properties
		public string path { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public uint bindId { get; private set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
	
		// Nested types
		public enum BindType // TypeDefIndex: 54211
		{
			Cpk = 0,
			Directory = 1,
			File = 2
		}
	
		// Constructors
		public CriFsBindRequest() {} // Dummy constructor
		public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path) {} // 0x00000001856D55D4-0x00000001856D570C
	
		// Methods
		public override void Stop() {} // 0x000000018350B670-0x000000018350B680
		public override void Update() {} // 0x00000001856D5570-0x00000001856D55D4
		protected override void Dispose(bool disposing) {} // 0x00000001856D5524-0x00000001856D5570
	}

	public static class CriFsUtility // TypeDefIndex: 54213
	{
		// Fields
		public const int DefaultReadUnitSize = 1048576; // Metadata: 0x01FD6531
	
		// Methods
		public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576 /* Metadata: 0x01FD651D */) => default; // 0x00000001856DA114-0x00000001856DA160
		public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576 /* Metadata: 0x01FD6521 */) => default; // 0x00000001856DA068-0x00000001856DA0BC
		public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x01FD6525 */) => default; // 0x00000001856DA0BC-0x00000001856DA114
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576 /* Metadata: 0x01FD6529 */) => default; // 0x00000001856DA058-0x00000001856DA068
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x01FD652D */) => default; // 0x00000001856DA004-0x00000001856DA058
		public static CriFsInstallRequest Install(string srcPath, string dstPath) => default; // 0x00000001856D9F7C-0x00000001856D9FA0
		public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x00000001856D9F00-0x00000001856D9F24
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath) => default; // 0x00000001856D9F24-0x00000001856D9F7C
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x00000001856D9FA0-0x00000001856DA004
		public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x00000001856DA178-0x00000001856DA1CC
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath) => default; // 0x00000001856D9C08-0x00000001856D9C18
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x00000001856D9C18-0x00000001856D9C6C
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath) => default; // 0x00000001856D9C6C-0x00000001856D9CB4
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x00000001856D9CB4-0x00000001856D9D08
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath) => default; // 0x00000001856D9D5C-0x00000001856D9DA4
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x00000001856D9D08-0x00000001856D9D5C
		public static void SetUserAgentString(string userAgentString) {} // 0x00000001856DA170-0x00000001856DA178
		public static void SetProxyServer(string proxyPath, ushort proxyPort) {} // 0x00000001856DA168-0x00000001856DA170
		public static void SetPathSeparator(string filter) {} // 0x00000001856DA160-0x00000001856DA168
		private static extern bool CRIWARECD0DC04A(string userAgentString); // 0x00000001856D9EA4-0x00000001856D9F00
		private static extern bool CRIWARE48E31D64(string proxyPath, ushort proxyPort); // 0x00000001856D9E00-0x00000001856D9EA4
		private static extern bool CRIWARE0C80F382(string filter); // 0x00000001856D9DA4-0x00000001856D9E00
	}

	public static class CriFsPlugin // TypeDefIndex: 54214
	{
		// Fields
		private static int initializationCount; // 0x00
		private static bool isConfigured; // 0x04
		public static int defaultInstallBufferSize; // 0x08
		public static int installBufferSize; // 0x0C
	
		// Properties
		public static bool isInitialized { get; } // 0x00000001856D8F24-0x00000001856D8F6C 
	
		// Constructors
		static CriFsPlugin() {} // 0x0000000183D02220-0x0000000183D022A0
	
		// Methods
		public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check) {} // 0x0000000183CC5020-0x0000000183CC50E0
		public static void SetReadDeviceEnabled(int deviceId, bool enabled) {} // 0x00000001856D8BF0-0x00000001856D8C7C
		public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps) {} // 0x000000018350B670-0x000000018350B680
		public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio) {} // 0x000000018350B670-0x000000018350B680
		public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio) {} // 0x000000018350B670-0x000000018350B680
		public static void InitializeLibrary() {} // 0x0000000183183740-0x0000000183183830
		public static bool IsLibraryInitialized() => default; // 0x000000018268CE20-0x000000018268CE70
		public static void FinalizeLibrary() {} // 0x00000001856D8B08-0x00000001856D8BF0
		private static extern void CRIWARE8451156E(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check); // 0x00000001822C7930-0x00000001822C79F0
		private static extern void CRIWARE601ABE43(); // 0x0000000183183830-0x0000000183183860
		public static extern bool CRIWARE1012AF20(); // 0x000000018268CE70-0x000000018268CEB0
		private static extern void CRIWARE74A6103A(); // 0x00000001856D8AB0-0x00000001856D8ADC
		public static extern uint CRIWARE785081A5(); // 0x00000001856D8ADC-0x00000001856D8B08
		public static extern uint criFsLoader_GetRetryCount(); // 0x00000001856D8C7C-0x00000001856D8CE4
		public static extern int criFs_GetNumBinds(ref int cur, ref int max, ref int limit); // 0x00000001856D8CE4-0x00000001856D8D78
		public static extern int criFs_GetNumUsedLoaders(ref int cur, ref int max, ref int limit); // 0x00000001856D8E0C-0x00000001856D8EA0
		public static extern int criFs_GetNumUsedInstallers(ref int cur, ref int max, ref int limit); // 0x00000001856D8D78-0x00000001856D8E0C
		private static extern int criFs_SetReadDeviceEnabled(int device_id, bool enabled); // 0x00000001856D8EA0-0x00000001856D8F24
	}

	public class CriFsServer : CriMonoBehaviour // TypeDefIndex: 54215
	{
		// Fields
		private static CriFsServer _instance; // 0x00
		private List<CriFsRequest> requestList; // 0x28
	
		// Properties
		public static CriFsServer instance { get => default; } // 0x00000001856D9BC8-0x00000001856D9C08 
		public int installBufferSize { get; private set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
	
		// Constructors
		public CriFsServer() {} // 0x0000000183772780-0x0000000183772790
	
		// Methods
		public static void CreateInstance() {} // 0x00000001856D94AC-0x00000001856D9580
		public static void DestroyInstance() {} // 0x00000001856D96B0-0x00000001856D973C
		private void Awake() {} // 0x00000001856D914C-0x00000001856D92B8
		private void OnDestroy() {} // 0x00000001856D994C-0x00000001856D9B14
		public override void CriInternalUpdate() {} // 0x00000001856D9580-0x00000001856D96B0
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
		public void AddRequest(CriFsRequest request) {} // 0x00000001856D90F8-0x00000001856D914C
		public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize) => default; // 0x00000001856D98A4-0x00000001856D994C
		public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize) => default; // 0x00000001856D9804-0x00000001856D98A4
		public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate) => default; // 0x00000001856D973C-0x00000001856D9804
		public CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate) => default; // 0x00000001856D9B14-0x00000001856D9BC8
		public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x00000001856D92B8-0x00000001856D935C
		public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x00000001856D935C-0x00000001856D9404
		public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x00000001856D9404-0x00000001856D94AC
	}

	public class CriFsWebInstaller : CriDisposable // TypeDefIndex: 54221
	{
		// Fields
		public const int InvalidHttpStatusCode = -1; // Metadata: 0x01FD6535
		public const long InvalidContentsSize = -1; // Metadata: 0x01FD6536
		private IntPtr handle; // 0x20
	
		// Properties
		public static bool isInitialized { get; private set; } // 0x00000001856DAFB0-0x00000001856DAFE8 0x00000001856DB024-0x00000001856DB060
		public static bool isCrcEnabled { get; private set; } // 0x00000001856DAF78-0x00000001856DAFB0 0x00000001856DAFE8-0x00000001856DB024
		public static ModuleConfig defaultModuleConfig { get => default; } // 0x00000001856DAF20-0x00000001856DAF78 
	
		// Nested types
		public enum Status // TypeDefIndex: 54216
		{
			Stop = 0,
			Busy = 1,
			Complete = 2,
			Error = 3
		}
	
		public enum Error // TypeDefIndex: 54217
		{
			None = 0,
			Timeout = 1,
			Memory = 2,
			LocalFs = 3,
			DNS = 4,
			Connection = 5,
			SSL = 6,
			HTTP = 7,
			Internal = 8
		}
	
		public struct StatusInfo // TypeDefIndex: 54218
		{
			// Fields
			public Status status; // 0x00
			public Error error; // 0x04
			public int httpStatusCode; // 0x08
			public long contentsSize; // 0x10
			public long receivedSize; // 0x18
		}
	
		public struct ModuleConfig // TypeDefIndex: 54219
		{
			// Fields
			public uint numInstallers; // 0x00
			public string proxyHost; // 0x08
			public ushort proxyPort; // 0x10
			public string userAgent; // 0x18
			public uint inactiveTimeoutSec; // 0x20
			public bool allowInsecureSSL; // 0x24
			public bool crcEnabled; // 0x25
			public ModulePlatformConfig platformConfig; // 0x26
		}
	
		public struct ModulePlatformConfig // TypeDefIndex: 54220
		{
			// Fields
			public byte reserved; // 0x00
	
			// Properties
			public static ModulePlatformConfig defaultConfig { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		}
	
		// Constructors
		public CriFsWebInstaller() {} // 0x00000001856DA9F0-0x00000001856DAAAC
	
		// Methods
		~CriFsWebInstaller() {} // 0x00000001856DA6A0-0x00000001856DA714
		public override void Dispose() {} // 0x00000001856DA4E0-0x00000001856DA530
		public void Copy(string url, string dstPath) {} // 0x00000001856DA4D4-0x00000001856DA4E0
		public void Stop() {} // 0x00000001856DA9DC-0x00000001856DA9F0
		public StatusInfo GetStatusInfo() => default; // 0x00000001856DA798-0x00000001856DA7E8
		public bool GetCRC32(out uint ret_val) {
			ret_val = default;
			return default;
		} // 0x00000001856DA714-0x00000001856DA730
		public static void InitializeModule(ModuleConfig config) {} // 0x00000001856DA7E8-0x00000001856DA9C4
		private static System.Type GetCriFsWebInstallerCurlExpansionClass() => default; // 0x00000001856DA730-0x00000001856DA798
		public static void FinalizeModule() {} // 0x00000001856DA5F8-0x00000001856DA6A0
		public static void ExecuteMain() {} // 0x00000001856DA5F0-0x00000001856DA5F8
		public static bool SetRequestHeader(string field, string value) => default; // 0x00000001856DA9C4-0x00000001856DA9DC
		private void Dispose(bool disposing) {} // 0x00000001856DA530-0x00000001856DA5F0
		private static extern int criFsWebInstaller_Initialize(in ModuleConfig config); // 0x00000001856DAD84-0x00000001856DAE2C
		private static extern int criFsWebInstaller_Finalize(); // 0x00000001856DAC50-0x00000001856DAC7C
		private static extern int criFsWebInstaller_ExecuteMain(); // 0x00000001856DAC24-0x00000001856DAC50
		private static extern int criFsWebInstaller_Create(out IntPtr installer); // 0x00000001856DAB78-0x00000001856DABF0
		private static extern int criFsWebInstaller_Destroy(IntPtr installer); // 0x00000001856DABF0-0x00000001856DAC24
		private static extern int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath); // 0x00000001856DAAAC-0x00000001856DAB78
		private static extern int criFsWebInstaller_Stop(IntPtr installer); // 0x00000001856DAEEC-0x00000001856DAF20
		private static extern int criFsWebInstaller_GetStatusInfo(IntPtr installer, out StatusInfo status); // 0x00000001856DAD00-0x00000001856DAD84
		private static extern int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32); // 0x00000001856DAC7C-0x00000001856DAD00
		private static extern int criFsWebInstaller_SetRequestHeader(string field, string value); // 0x00000001856DAE2C-0x00000001856DAEEC
	}

	public class CriManaPlugin // TypeDefIndex: 54222
	{
		// Fields
		private static int initializationCount; // 0x00
		private static bool isConfigured; // 0x04
		private static bool enabledMultithreadedRendering; // 0x05
		public static int renderingEventOffset; // 0x08
	
		// Properties
		public static bool isInitialized { get => default; } // 0x00000001856E01AC-0x00000001856E01F4 
		public static bool isMultithreadedRenderingEnabled { get => default; } // 0x00000001856E01F4-0x00000001856E0244 
	
		// Constructors
		public CriManaPlugin() {} // 0x000000018350B670-0x000000018350B680
		static CriManaPlugin() {} // 0x0000000183D04AC0-0x0000000183D04B40
	
		// Methods
		public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries) {} // 0x00000001831834A0-0x0000000183183570
		private static void SetupVp9() {} // 0x0000000183183860-0x0000000183183960
		[Obsolete("Use CriWareVITA.EnableH264Playback and CriWareVITA.SetH264DecoderMaxSize instead.")]
		public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height) {} // 0x000000018350B670-0x000000018350B680
		public static void SetConfigAdditonalParameters_PC(bool use_h264_playback) {} // 0x000000018268CEB0-0x000000018268CF00
		public static void SetConfigAdditonalParameters_ANDROID(bool enable_buffer_output_for_h264, bool enable_buffer_output_for_vp9) {} // 0x000000018350B670-0x000000018350B680
		public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize) {} // 0x000000018350B670-0x000000018350B680
		public static void InitializeLibrary() {} // 0x0000000183182890-0x00000001831829E0
		public static bool IsLibraryInitialized() => default; // 0x00000001831830B0-0x0000000183183100
		public static void FinalizeLibrary() {} // 0x00000001856DFDC0-0x00000001856DFEF0
		public static bool IsCodecSupported(CodecType codecType) => default; // 0x00000001856DFF30-0x00000001856E001C
		private static System.Type GetVp9ExpansionClass() => default; // 0x000000018318ADF0-0x000000018318AEB0
		private static bool IsVp9CodecSupported() => default; // 0x0000000183183960-0x0000000183183A50
		private static bool IsH264CodecSupported() => default; // 0x000000018232EB60-0x000000018232EB70
		public static void SetDecodeThreadPriorityAndroidExperimental(int prio) {} // 0x000000018350B670-0x000000018350B680
		public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr) => default; // 0x000000018115F4C0-0x000000018115F530
		public static void Lock() {} // 0x00000001856E001C-0x00000001856E005C
		public static void Unlock() {} // 0x00000001856E005C-0x00000001856E009C
		public static uint GetPrimeBufferAlignmentSize() => default; // 0x00000001856DFEF0-0x00000001856DFF30
		private static extern void CRIWARECFA78B41(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries); // 0x00000001822C7890-0x00000001822C7930
		private static extern void CRIWARE7BFC56AA(); // 0x00000001831829E0-0x0000000183182A10
		public static extern bool CRIWARE611B78A5(); // 0x0000000183183100-0x0000000183183140
		private static extern void CRIWARED672C36F(); // 0x00000001856DFD94-0x00000001856DFDC0
		public static extern void CRIWARE9F182D39(bool flag); // 0x00000001856DFD60-0x00000001856DFD94
		public static extern void CRIWARE06C87176(); // 0x00000001856DFCDC-0x00000001856DFD08
		public static extern void CRIWARE46E1A37B(); // 0x00000001856DFD34-0x00000001856DFD60
		private static extern uint criManaUnity_GetPrimeBufferAlignmentSize(); // 0x00000001856E009C-0x00000001856E0104
		public static extern void criMana_UseStreamerManager(bool flag); // 0x00000001856E0134-0x00000001856E01AC
		public static extern bool criMana_IsStreamerManagerUsed(); // 0x00000001856E0104-0x00000001856E0134
		public static extern uint CRIWARE257CA763(); // 0x00000001856DFD08-0x00000001856DFD34
		public static extern void CRIWARE62B7B053(bool enable); // 0x000000018268CF00-0x000000018268CF40
	}

	public class CriManaAmbisonicSource : CriMonoBehaviour // TypeDefIndex: 54223
	{
		// Fields
		private CriAtomEx3dSource atomEx3DsourceForAmbisonics; // 0x28
		private Vector3 ambisonicSourceOrientationFront; // 0x30
		private Vector3 ambisonicSourceOrientationTop; // 0x3C
		private Vector3 lastEulerOfAmbisonicSource; // 0x48
	
		// Constructors
		public CriManaAmbisonicSource() {} // 0x0000000183772780-0x0000000183772790
	
		// Methods
		public override void CriInternalUpdate() {} // 0x00000001856DB060-0x00000001856DB068
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnEnable() {} // 0x00000001856DB110-0x00000001856DB1F4
		private void ForceUpdateAmbisonicSourceOrientation() {} // 0x00000001856DB068-0x00000001856DB110
		private void UpdateAmbisonicSourceOrientation() {} // 0x00000001856DB600-0x00000001856DB6A0
		private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler) {} // 0x00000001856DB1F4-0x00000001856DB600
	}

	[AddComponentMenu("CRIWARE/CriManaMovieController")]
	public class CriManaMovieController : CriManaMovieMaterial // TypeDefIndex: 54224
	{
		// Fields
		public Renderer target; // 0x98
		public bool useOriginalMaterial; // 0xA0
		private Material originalMaterial; // 0xA8
	
		// Constructors
		public CriManaMovieController() {} // 0x00000001856DE72C-0x00000001856DE734
	
		// Methods
		public override void CriInternalUpdate() {} // 0x00000001856DE734-0x00000001856DE7D4
		public override bool RenderTargetManualSetup() => default; // 0x00000001856DE944-0x00000001856DEA84
		public override void RenderTargetManualFinalize() {} // 0x00000001856DE898-0x00000001856DE944
		protected override void OnMaterialAvailableChanged() {} // 0x00000001856DE7D4-0x00000001856DE898
	}

	[AddComponentMenu("CRIWARE/CriManaMovieControllerForUI")]
	public class CriManaMovieControllerForUI : CriManaMovieMaterial // TypeDefIndex: 54225
	{
		// Fields
		public Graphic target; // 0x98
		public bool useOriginalMaterial; // 0xA0
		private Material originalMaterial; // 0xA8
	
		// Constructors
		public CriManaMovieControllerForUI() {} // 0x00000001856DE72C-0x00000001856DE734
	
		// Methods
		protected override void Awake() {} // 0x00000001856DE3A8-0x00000001856DE3CC
		public override void CriInternalUpdate() {} // 0x00000001856DE3CC-0x00000001856DE470
		public override bool RenderTargetManualSetup() => default; // 0x00000001856DE5E8-0x00000001856DE72C
		public override void RenderTargetManualFinalize() {} // 0x00000001856DE538-0x00000001856DE5E8
		protected override void OnMaterialAvailableChanged() {} // 0x00000001856DE470-0x00000001856DE538
	}

	[AddComponentMenu("CRIWARE/CriManaMovieMaterial")]
	public class CriManaMovieMaterial : CriManaMovieMaterialBase // TypeDefIndex: 54226
	{
		// Fields
		[SerializeField]
		private string _moviePath; // 0x80
		[SerializeField]
		private bool _loop; // 0x88
		[SerializeField]
		private bool _additiveMode; // 0x89
		[SerializeField]
		private bool _useMaterialBlendMode; // 0x8A
		[SerializeField]
		private bool _advancedAudio; // 0x8B
		[SerializeField]
		private bool _ambisonics; // 0x8C
		[SerializeField]
		private bool _applyTargetAlpha; // 0x8D
		[SerializeField]
		private bool _uiRenderMode; // 0x8E
		private GameObject ambisonicSource; // 0x90
	
		// Properties
		public string moviePath { get => default; set {} } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001856DFB40-0x00000001856DFBB8
		public bool loop { get => default; set {} } // 0x0000000183D51D50-0x0000000183D51D60 0x00000001856DFAD4-0x00000001856DFB40
		public bool advancedAudio { get => default; set {} } // 0x0000000183D51D20-0x0000000183D51D30 0x00000001856DF56C-0x00000001856DF5EC
		public bool ambisonics { get => default; set {} } // 0x0000000183D51D30-0x0000000183D51D40 0x00000001856DF5EC-0x00000001856DFA68
		public bool additiveMode { get => default; set {} } // 0x0000000183D51D10-0x0000000183D51D20 0x00000001856DF500-0x00000001856DF56C
		public bool useMaterialBlendMode { get => default; set {} } // 0x0000000183D51D70-0x0000000183D51D80 0x00000001856DFC24-0x00000001856DFC90
		public bool applyTargetAlpha { get => default; set {} } // 0x0000000183D51D40-0x0000000183D51D50 0x00000001856DFA68-0x00000001856DFAD4
		public bool uiRenderMode { get => default; set {} } // 0x0000000183D51D60-0x0000000183D51D70 0x00000001856DFBB8-0x00000001856DFC24
		protected override uint FilePathLength { get => default; } // 0x00000001856DF4B0-0x00000001856DF500 
		protected override bool initializeWithAdvancedAudio { get => default; } // 0x0000000183D51D20-0x0000000183D51D30 
		protected override bool initializeWithAmbisonics { get => default; } // 0x0000000183D51D30-0x0000000183D51D40 
	
		// Constructors
		public CriManaMovieMaterial() {} // 0x00000001856DE72C-0x00000001856DE734
	
		// Methods
		protected override void SetDataToPlayer() {} // 0x00000001856DF3EC-0x00000001856DF4B0
	}

	public abstract class CriManaMovieMaterialBase : CriMonoBehaviour // TypeDefIndex: 54232
	{
		// Fields
		public bool playOnStart; // 0x28
		public bool restartOnEnable; // 0x29
		public RenderMode renderMode; // 0x38
		public OnApplicationPauseCallback onApplicationPauseCallback; // 0x40
		private Player.TimerType _timerType; // 0x48
		[SerializeField]
		private Material _material; // 0x50
		[SerializeField]
		private MaxFrameDrop _maxFrameDrop; // 0x58
		private bool materialOwn; // 0x5C
		protected bool isMonoBehaviourStartCalled; // 0x5D
		private bool wasDisabled; // 0x5E
		private bool wasPausedOnDisable; // 0x5F
		private bool previousOnApplicationPauseStatus; // 0x60
		private WaitForEndOfFrame frameEnd; // 0x68
		private bool unpauseOnApplicationUnpause; // 0x70
		private CriManaMoviePlayerHolder playerHolder; // 0x78
	
		// Properties
		public MaxFrameDrop maxFrameDrop { get; set; } // 0x0000000183D4EF00-0x0000000183D4EF10 0x00000001856DF3B4-0x00000001856DF3CC
		protected abstract bool initializeWithAdvancedAudio { get; }
		protected abstract bool initializeWithAmbisonics { get; }
		public bool isMaterialAvailable { get; private set; } // 0x0000000183D4F4B0-0x0000000183D4F4C0 0x0000000183D4F4E0-0x0000000183D4F4F0
		public Player player { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public Material material { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x00000001856DF31C-0x00000001856DF3B4
		public Player.TimerType timerType { get; set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x00000001856DF3CC-0x00000001856DF3EC
		protected abstract uint FilePathLength { get; }
		protected bool HaveRendererOwner { get; private set; } // 0x0000000183D51CF0-0x0000000183D51D00 0x0000000183D51D00-0x0000000183D51D10
	
		// Nested types
		public enum MaxFrameDrop // TypeDefIndex: 54227
		{
			Infinite = -1,
			Disabled = 0,
			One = 1,
			Two = 2,
			Three = 3,
			Four = 4,
			Five = 5,
			Six = 6,
			Seven = 7,
			Eight = 8,
			Nine = 9,
			Ten = 10
		}
	
		public enum RenderMode // TypeDefIndex: 54228
		{
			Always = 0,
			OnVisibility = 1,
			Never = 2
		}
	
		public delegate void OnApplicationPauseCallback(CriManaMovieMaterialBase manaMovieMaterial, bool appPause); // TypeDefIndex: 54229; 0x0000000182065C10-0x0000000182065C20
	
		// Constructors
		protected CriManaMovieMaterialBase() {} // 0x00000001856DF2BC-0x00000001856DF31C
	
		// Methods
		protected abstract void SetDataToPlayer();
		public void Play() {} // 0x00000001856DED64-0x00000001856DED98
		public void Stop() {} // 0x00000001856DF284-0x00000001856DF2BC
		public void Pause(bool sw) {} // 0x00000001856DED30-0x00000001856DED64
		protected virtual void OnMaterialAvailableChanged() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnMaterialUpdated() {} // 0x000000018350B670-0x000000018350B680
		public void PlayerManualInitialize() {} // 0x00000001856DEDD8-0x00000001856DEF78
		public void PlayerManualFinalize() {} // 0x00000001856DED98-0x00000001856DEDD8
		private async void AsyncDispose(Player player) {} // 0x00000001856DEA84-0x00000001856DEB24
		public void PlayerManualSetup() {} // 0x00000001856DEF78-0x00000001856DF02C
		public virtual bool RenderTargetManualSetup() => default; // 0x000000018232EB60-0x000000018232EB70
		public virtual void RenderTargetManualFinalize() {} // 0x000000018350B670-0x000000018350B680
		public void PlayerManualUpdate() {} // 0x00000001856DF02C-0x00000001856DF104
		protected virtual void Awake() {} // 0x00000001856DEB24-0x00000001856DEB2C
		protected override void OnEnable() {} // 0x00000001856DECA0-0x00000001856DED00
		[IteratorStateMachine(typeof(_RestartPlayerRoutine_d__60))]
		private IEnumerator RestartPlayerRoutine() => default; // 0x00000001856DF1C8-0x00000001856DF224
		protected override void OnDisable() {} // 0x00000001856DEC4C-0x00000001856DECA0
		protected virtual void OnDestroy() {} // 0x00000001856DEC24-0x00000001856DEC4C
		protected virtual void Start() {} // 0x00000001856DF224-0x00000001856DF284
		public override void CriInternalUpdate() {} // 0x00000001856DEC14-0x00000001856DEC1C
		public virtual void RenderMovie() {} // 0x00000001856DF1A0-0x00000001856DF1C8
		public override void CriInternalLateUpdate() {} // 0x00000001856DEBE4-0x00000001856DEC14
		protected virtual void OnWillRenderObject() {} // 0x00000001856DED00-0x00000001856DED30
		private void OnApplicationPause(bool appPause) {} // 0x00000001856DEC1C-0x00000001856DEC24
		private void ProcessApplicationPause(bool appPause) {} // 0x00000001856DF104-0x00000001856DF1A0
		private void CreateMaterial() {} // 0x00000001856DEB2C-0x00000001856DEBE4
	}

	public class CriManaMoviePlayerHolder : CriMonoBehaviour // TypeDefIndex: 54233
	{
		// Fields
		private Player _player; // 0x28
	
		// Properties
		public Player player { set {} } // 0x0000000182C92F10-0x0000000182C92F20
	
		// Constructors
		public CriManaMoviePlayerHolder() {} // 0x0000000183772780-0x0000000183772790
	
		// Methods
		private void Awake() {} // 0x00000001856DFC90-0x00000001856DFCDC
		public override void CriInternalUpdate() {} // 0x000000018350B670-0x000000018350B680
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
		private void Start() {} // 0x000000018350B670-0x000000018350B680
	}

	public class Common // TypeDefIndex: 54235
	{
		// Fields
		private const string scriptVersionString = "1.0.6(2.40.31_PS5SDKUpdate)"; // Metadata: 0x01FD655A
		public const bool supportsCriFsInstaller = true; // Metadata: 0x01FD6576
		public const bool supportsCriFsWebInstaller = true; // Metadata: 0x01FD6577
		public const string pluginName = "cri_ware_unity"; // Metadata: 0x01FD6578
		public const CallingConvention pluginCallingConvention = CallingConvention.Cdecl; // Metadata: 0x01FD6587
		private static GameObject _managerObject; // 0x00
	
		// Properties
		public static string streamingAssetsPath { get => default; } // 0x000000018268B580-0x000000018268B5D0 
		public static string installTargetPath { get => default; } // 0x00000001856CDC64-0x00000001856CDC6C 
		public static string installCachePath { get => default; } // 0x00000001856CDC3C-0x00000001856CDC64 
		public static GameObject managerObject { get => default; } // 0x000000018268EB30-0x000000018268ECD0 
	
		// Nested types
		public struct CpuUsage // TypeDefIndex: 54234
		{
			// Fields
			public float last; // 0x00
			public float average; // 0x04
			public float peak; // 0x08
		}
	
		// Constructors
		public Common() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool IsStreamingAssetsPath(string path) => default; // 0x0000000183CF2DE0-0x0000000183CF2E60
		public static string GetScriptVersionString() => default; // 0x00000001856CDC10-0x00000001856CDC3C
		public static int GetBinaryVersionNumber() => default; // 0x00000001842710A0-0x00000001842710A8
		public static int GetRequiredBinaryVersionNumber() => default; // 0x0000000183D51C70-0x0000000183D51C80
		public static bool CheckBinaryVersionCompatibility() => default; // 0x000000018268CF60-0x000000018268CFB0
		public static uint GetFsMemoryUsage() => default; // 0x00000001856CDB90-0x00000001856CDBD0
		public static uint GetAtomMemoryUsage() => default; // 0x00000001856CDB50-0x00000001856CDB90
		public static uint GetManaMemoryUsage() => default; // 0x00000001856CDBD0-0x00000001856CDC10
		public static CpuUsage GetAtomCpuUsage() => default; // 0x00000001856CDAFC-0x00000001856CDB50
		public static extern int CRIWAREC8077C29(); // 0x0000000183CFE760-0x0000000183CFE790
		public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset); // 0x00000001822C8470-0x00000001822C84F0
	}

	public static class CriWareDecrypter // TypeDefIndex: 54237
	{
		// Fields
		private static ulong temporalStorage; // 0x00
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 54236; 0x000000018102B410-0x000000018102B420
	
		// Methods
		public static bool Initialize(CriWareDecrypterConfig config) => default; // 0x00000001856E0410-0x00000001856E0440
		public static bool Initialize(string key, string authenticationFile, bool enableAtomDecryption, bool enableManaDecryption) => default; // 0x000000018268B280-0x000000018268B440
		[AOT.MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
		private static ulong CallbackFromNative(IntPtr ptr1) => default; // 0x00000001856E03D8-0x00000001856E0410
		public static extern int CRIWARE05CA8EB2(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj); // 0x00000001822C77E0-0x00000001822C7890
	}

	[AddComponentMenu("CRIWARE/Error Handler")]
	public class CriWareErrorHandler : CriMonoBehaviour // TypeDefIndex: 54239
	{
		// Fields
		public bool enableDebugPrintOnTerminal; // 0x28
		public bool enableForceCrashOnError; // 0x29
		public bool dontDestroyOnLoad; // 0x2A
		public static readonly string logPrefix; // 0x08
		[Obsolete("CriWareErrorHandler.callback is deprecated. Use CriWareErrorHandler.OnCallback event", false)]
		public static Callback callback; // 0x18
		public uint messageBufferCounts; // 0x2C
		private ConcurrentQueue<string> unThreadSafeMessages; // 0x30
		private static int initializationCount; // 0x20
	
		// Properties
		public static string errorMessage { get; set; } // 0x00000001856E0EF8-0x00000001856E0F48 0x00000001856E101C-0x00000001856E1078
	
		// Events
		public static event Callback OnCallback;
	
		// Nested types
		public delegate void Callback(string message); // TypeDefIndex: 54238; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public CriWareErrorHandler() {} // 0x00000001856E0D98-0x00000001856E0E24
		static CriWareErrorHandler() {} // 0x00000001856E0CD0-0x00000001856E0D98
	
		// Methods
		private void Awake() {} // 0x00000001856E0440-0x00000001856E05BC
		protected override void OnEnable() {} // 0x00000001856E09BC-0x00000001856E0A9C
		protected override void OnDisable() {} // 0x00000001856E08DC-0x00000001856E09BC
		public override void CriInternalUpdate() {} // 0x00000001856E05BC-0x00000001856E05C4
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
		private void OnDestroy() {} // 0x00000001856E07C0-0x00000001856E08DC
		private void DequeueErrorMessages() {} // 0x00000001856E05C4-0x00000001856E06FC
		private void HandleMessage(string errmsg) {} // 0x00000001856E06FC-0x00000001856E07C0
		private static void OutputDefaultLog(string errmsg) {} // 0x00000001856E0A9C-0x00000001856E0CD0
	}

	public static class CriErrorNotifier // TypeDefIndex: 54243
	{
		// Fields
		private static object objectLock; // 0x08
	
		// Events
		private static event Callback _onCallbackThreadUnsafe;
		public static event Callback OnCallbackThreadUnsafe;
	
		// Nested types
		public delegate void Callback(string message); // TypeDefIndex: 54240; 0x0000000182149960-0x0000000182149970
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void ErrorCallbackFunc(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray); // TypeDefIndex: 54241; 0x0000000182097E50-0x0000000182097E70
	
		public static class NativeMethod // TypeDefIndex: 54242
		{
			// Methods
			internal static extern void criErr_SetCallback(ErrorCallbackFunc callback); // 0x00000001856E1B54-0x00000001856E1BD4
			internal static extern IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2); // 0x00000001856E1AC0-0x00000001856E1B54
		}
	
		// Constructors
		static CriErrorNotifier() {} // 0x00000001856D4F0C-0x00000001856D4FA4
	
		// Methods
		public static bool IsRegistered(Callback target) => default; // 0x00000001856D4E2C-0x00000001856D4F0C
		public static void CallEvent(string message) {} // 0x00000001856D4D20-0x00000001856D4D9C
		[AOT.MonoPInvokeCallback(typeof(ErrorCallbackFunc))]
		private static void ErrorCallbackFromNative(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray) {} // 0x00000001856D4D9C-0x00000001856D4E2C
	}

	[Serializable]
	public class CriFsConfig // TypeDefIndex: 54244
	{
		// Fields
		public const int defaultAndroidDeviceReadBitrate = 50000000; // Metadata: 0x01FD6588
		public int numberOfLoaders; // 0x10
		public int numberOfBinders; // 0x14
		public int numberOfInstallers; // 0x18
		public int installBufferSize; // 0x1C
		public int maxPath; // 0x20
		public string userAgentString; // 0x28
		public bool minimizeFileDescriptorUsage; // 0x30
		public bool enableCrcCheck; // 0x31
		public int androidDeviceReadBitrate; // 0x34
	
		// Constructors
		public CriFsConfig() {} // 0x00000001837729A0-0x0000000183772A50
	}

	[Serializable]
	public class CriAtomConfig // TypeDefIndex: 54260
	{
		// Fields
		public string acfFileName; // 0x10
		public int maxVirtualVoices; // 0x18
		public int maxVoiceLimitGroups; // 0x1C
		public int maxCategories; // 0x20
		public int maxAisacs; // 0x24
		public int maxBusSends; // 0x28
		public int maxSequenceEventsPerFrame; // 0x2C
		public int maxBeatSyncCallbacksPerFrame; // 0x30
		public int maxCueLinkCallbacksPerFrame; // 0x34
		public StandardVoicePoolConfig standardVoicePoolConfig; // 0x38
		public HcaMxVoicePoolConfig hcaMxVoicePoolConfig; // 0x40
		public int outputSamplingRate; // 0x48
		public bool usesInGamePreview; // 0x4C
		public InGamePreviewSwitchMode inGamePreviewMode; // 0x50
		public bool switchInitializeSocket; // 0x54
		public InGamePreviewConfig inGamePreviewConfig; // 0x58
		public float serverFrequency; // 0x60
		public int asrOutputChannels; // 0x64
		public bool useRandomSeedWithTime; // 0x68
		public int categoriesPerPlayback; // 0x6C
		public int maxFaders; // 0x70
		public int maxBuses; // 0x74
		public int maxParameterBlocks; // 0x78
		public bool vrMode; // 0x7C
		public bool keepPlayingSoundOnPause; // 0x7D
		public EditorPcmOutputConfig editorPcmOutputConfig; // 0x80
		public int pcBufferingTime; // 0x88
		public LinuxOutput linuxOutput; // 0x8C
		public int linuxPulseLatencyUsec; // 0x90
		public bool iosEnableSonicSync; // 0x94
		public int iosBufferingTime; // 0x98
		public bool iosOverrideIPodMusic; // 0x9C
		public bool androidEnableSonicSync; // 0x9D
		public int androidBufferingTime; // 0xA0
		public int androidStartBufferingTime; // 0xA4
		public AndroidLowLatencyStandardVoicePoolConfig androidLowLatencyStandardVoicePoolConfig; // 0xA8
		public bool androidUsesAndroidFastMixer; // 0xB0
		public bool androidForceToUseAsrForDefaultPlayback; // 0xB1
		public bool androidUsesAAudio; // 0xB2
		public int androidStreamType; // 0xB4
		public VitaManaVoicePoolConfig vitaManaVoicePoolConfig; // 0xB8
		public VitaAtrac9VoicePoolConfig vitaAtrac9VoicePoolConfig; // 0xC0
		public Ps4Atrac9VoicePoolConfig ps4Atrac9VoicePoolConfig; // 0xC8
		public Ps5PortConfig ps5PortConfig; // 0xD0
		public bool switchEnableSonicSync; // 0xD8
		public SwitchOpusVoicePoolConfig switchOpusVoicePoolConfig; // 0xE0
		public Ps4Audio3dConfig ps4Audio3dConfig; // 0xE8
		public WebGLWebAudioVoicePoolConfig webglWebAudioVoicePoolConfig; // 0xF0
	
		// Nested types
		[Serializable]
		public class StandardVoicePoolConfig // TypeDefIndex: 54245
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public StandardVoicePoolConfig() {} // 0x0000000183D51DE0-0x0000000183D51DF0
		}
	
		[Serializable]
		public class HcaMxVoicePoolConfig // TypeDefIndex: 54246
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public HcaMxVoicePoolConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public enum InGamePreviewSwitchMode // TypeDefIndex: 54247
		{
			Disable = 0,
			Enable = 1,
			FollowBuildSetting = 2,
			Default = 3
		}
	
		[Serializable]
		public class InGamePreviewConfig // TypeDefIndex: 54248
		{
			// Fields
			public int maxPreviewObjects; // 0x10
			public int communicationBufferSize; // 0x14
			public int playbackPositionUpdateInterval; // 0x18
	
			// Constructors
			public InGamePreviewConfig() {} // 0x0000000183D51DB0-0x0000000183D51DD0
		}
	
		[Serializable]
		public class EditorPcmOutputConfig // TypeDefIndex: 54249
		{
			// Fields
			public bool enable; // 0x10
			public int bufferLength; // 0x14
	
			// Constructors
			public EditorPcmOutputConfig() {} // 0x0000000183D51DA0-0x0000000183D51DB0
		}
	
		public enum LinuxOutput // TypeDefIndex: 54250
		{
			Default = 0,
			PulseAudio = 1,
			ALSA = 2
		}
	
		[Serializable]
		public class AndroidLowLatencyStandardVoicePoolConfig // TypeDefIndex: 54251
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public AndroidLowLatencyStandardVoicePoolConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class VitaManaVoicePoolConfig // TypeDefIndex: 54252
		{
			// Fields
			public int numberOfManaDecoders; // 0x10
	
			// Constructors
			public VitaManaVoicePoolConfig() {} // 0x0000000183D51E00-0x0000000183D51E10
		}
	
		[Serializable]
		public class VitaAtrac9VoicePoolConfig // TypeDefIndex: 54253
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public VitaAtrac9VoicePoolConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class Ps4Atrac9VoicePoolConfig // TypeDefIndex: 54254
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public Ps4Atrac9VoicePoolConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class Ps5PortConfig // TypeDefIndex: 54255
		{
			// Fields
			public int maxChannelPorts; // 0x10
			public int maxObjectPorts; // 0x14
	
			// Constructors
			public Ps5PortConfig() {} // 0x0000000183D51DD0-0x0000000183D51DE0
		}
	
		[Serializable]
		public class SwitchOpusVoicePoolConfig // TypeDefIndex: 54256
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public SwitchOpusVoicePoolConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class Ps4Audio3dConfig // TypeDefIndex: 54258
		{
			// Fields
			public bool useAudio3D; // 0x10
			public VoicePoolConfig voicePoolConfig; // 0x18
	
			// Nested types
			[Serializable]
			public class VoicePoolConfig // TypeDefIndex: 54257
			{
				// Fields
				public int memoryVoices; // 0x10
				public int streamingVoices; // 0x14
	
				// Constructors
				public VoicePoolConfig() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public Ps4Audio3dConfig() {} // 0x0000000183772F20-0x0000000183772F70
		}
	
		[Serializable]
		public class WebGLWebAudioVoicePoolConfig // TypeDefIndex: 54259
		{
			// Fields
			public int voices; // 0x10
	
			// Constructors
			public WebGLWebAudioVoicePoolConfig() {} // 0x0000000183D51E10-0x0000000183D51E20
		}
	
		// Constructors
		public CriAtomConfig() {} // 0x0000000183772B80-0x0000000183772F20
	}

	[Serializable]
	public class CriManaConfig // TypeDefIndex: 54264
	{
		// Fields
		public int numberOfDecoders; // 0x10
		public int numberOfMaxEntries; // 0x14
		public readonly bool graphicsMultiThreaded; // 0x18
		public PCH264PlaybackConfig pcH264PlaybackConfig; // 0x20
		public VitaH264PlaybackConfig vitaH264PlaybackConfig; // 0x28
		public WebGLConfig webglConfig; // 0x30
	
		// Nested types
		[Serializable]
		public class PCH264PlaybackConfig // TypeDefIndex: 54261
		{
			// Fields
			public bool useH264Playback; // 0x10
	
			// Constructors
			public PCH264PlaybackConfig() {} // 0x0000000181168960-0x0000000181168970
		}
	
		[Serializable]
		public class VitaH264PlaybackConfig // TypeDefIndex: 54262
		{
			// Fields
			public bool useH264Playback; // 0x10
			public int maxWidth; // 0x14
			public int maxHeight; // 0x18
			public bool getMemoryFromTexture; // 0x1C
	
			// Constructors
			public VitaH264PlaybackConfig() {} // 0x0000000183D51DF0-0x0000000183D51E00
		}
	
		[Serializable]
		public class WebGLConfig // TypeDefIndex: 54263
		{
			// Fields
			public string webworkerPath; // 0x10
			public int heapSize; // 0x18
	
			// Constructors
			public WebGLConfig() {} // 0x0000000183772B30-0x0000000183772B80
		}
	
		// Constructors
		public CriManaConfig() {} // 0x0000000183772A50-0x0000000183772B30
	}

	[Serializable]
	public class CriWareDecrypterConfig // TypeDefIndex: 54265
	{
		// Fields
		public string key; // 0x10
		public string authenticationFile; // 0x18
		public bool enableAtomDecryption; // 0x20
		public bool enableManaDecryption; // 0x21
	
		// Constructors
		public CriWareDecrypterConfig() {} // 0x00000001837728C0-0x0000000183772920
	}

	[AddComponentMenu("CRIWARE/Library Initializer")]
	public class CriWareInitializer : CriMonoBehaviour // TypeDefIndex: 54266
	{
		// Fields
		public bool initializesFileSystem; // 0x28
		public CriFsConfig fileSystemConfig; // 0x30
		public bool initializesAtom; // 0x38
		public CriAtomConfig atomConfig; // 0x40
		public bool initializesMana; // 0x48
		public CriManaConfig manaConfig; // 0x50
		public bool useDecrypter; // 0x58
		public CriWareDecrypterConfig decrypterConfig; // 0x60
		public bool dontInitializeOnAwake; // 0x68
		public bool dontDestroyOnLoad; // 0x69
		private static int initializationCount; // 0x00
	
		// Constructors
		public CriWareInitializer() {} // 0x0000000183772790-0x00000001837728C0
	
		// Methods
		private void Awake() {} // 0x000000018268CF40-0x000000018268CF60
		protected override void OnEnable() {} // 0x0000000183D4D9B0-0x0000000183D4D9C0
		private void Start() {} // 0x000000018350B670-0x000000018350B680
		private void OnDestroy() {} // 0x00000001856E10F8-0x00000001856E1100
		public override void CriInternalUpdate() {} // 0x000000018350B670-0x000000018350B680
		public override void CriInternalLateUpdate() {} // 0x000000018350B670-0x000000018350B680
		public void Initialize() {} // 0x000000018268CC30-0x000000018268CE20
		public void Shutdown() {} // 0x00000001856E1100-0x00000001856E11D0
		public static bool IsInitialized() => default; // 0x000000018268CFB0-0x000000018268D000
		public static void AddAudioEffectInterface(IntPtr effect_interface) {} // 0x00000001856E1078-0x00000001856E10F0
		public static bool InitializeFileSystem(CriFsConfig config) => default; // 0x000000018268CAE0-0x000000018268CC30
		public static bool InitializeAtom(CriAtomConfig config) => default; // 0x0000000183182A10-0x0000000183182EC0
		public static bool InitializeMana(CriManaConfig config) => default; // 0x0000000183182F50-0x0000000183183070
		[Obsolete("Use CriWareDecypter.Initialize")]
		public static bool InitializeDecrypter(CriWareDecrypterConfig config) => default; // 0x00000001856E10F0-0x00000001856E10F8
	}

	public static class CriAtomExDebug // TypeDefIndex: 54268
	{
		// Nested types
		public struct ResourcesInfo // TypeDefIndex: 54267
		{
			// Fields
			public CriAtomEx.ResourceUsage virtualVoiceUsage; // 0x00
			public CriAtomEx.ResourceUsage sequenceUsage; // 0x08
			public CriAtomEx.ResourceUsage sequenceTrackUsage; // 0x10
			public CriAtomEx.ResourceUsage sequenceTrackItemUsage; // 0x18
		}
	
		// Methods
		public static void GetResourcesInfo(out ResourcesInfo resourcesInfo) {
			resourcesInfo = default;
		} // 0x00000001856CE96C-0x00000001856CE974
		private static extern void criAtomExDebug_GetResourcesInfo(out ResourcesInfo resourcesInfo); // 0x00000001856CE974-0x00000001856CE9EC
	}

	public static class CriAtomExAcfDebug // TypeDefIndex: 54282
	{
		// Nested types
		public struct CategoryInfo // TypeDefIndex: 54269
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public string name; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
		}
	
		public struct DspBusInfo // TypeDefIndex: 54270
		{
			// Fields
			public string name; // 0x00
			public float volume; // 0x08
			public float pan3dVolume; // 0x0C
			public float pan3dAngle; // 0x10
			public float pan3dDistance; // 0x14
			public float pan3dSpread; // 0x18
			public ushort[] fxIndexes; // 0x20
			public ushort[] busLinkIndexes; // 0x28
			public ushort busNo; // 0x30
			public byte numFxes; // 0x32
			public byte numBusLinks; // 0x33
		}
	
		public struct AisacControlInfo // TypeDefIndex: 54271
		{
			// Fields
			public string name; // 0x00
			public uint id; // 0x08
		}
	
		public enum AisacType // TypeDefIndex: 54272
		{
			Normal = 0,
			AutoModulation = 1
		}
	
		public struct GlobalAisacInfo // TypeDefIndex: 54273
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numGraphs; // 0x0A
			public AisacType type; // 0x0C
			public float randomRange; // 0x10
			public ushort controlId; // 0x14
		}
	
		public struct SelectorInfo // TypeDefIndex: 54274
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
		}
	
		public struct SelectorLabelInfo // TypeDefIndex: 54275
		{
			// Fields
			public string selectorName; // 0x00
			public string labelName; // 0x08
		}
	
		private struct CategoryInfoForMarshaling // TypeDefIndex: 54276
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public IntPtr namePtr; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
	
			// Methods
			public void Convert(out CategoryInfo x) {
				x = default;
			} // 0x00000001856CDAB0-0x00000001856CDAFC
		}
	
		private struct DspBusInfoForMarshaling // TypeDefIndex: 54277
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public float volume; // 0x08
			public float pan3dVolume; // 0x0C
			public float pan3dAngle; // 0x10
			public float pan3dDistance; // 0x14
			public float pan3dSpread; // 0x18
			public ushort[] fxIndexes; // 0x20
			public ushort[] busLinkIndexes; // 0x28
			public ushort busNo; // 0x30
			public byte numFxes; // 0x32
			public byte numBusLinks; // 0x33
	
			// Methods
			public void Convert(out DspBusInfo x) {
				x = default;
			} // 0x00000001856E14C8-0x00000001856E1550
		}
	
		private struct AisacControlInfoForMarshaling // TypeDefIndex: 54278
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public uint id; // 0x08
	
			// Methods
			public void Convert(out AisacControlInfo x) {
				x = default;
			} // 0x00000001856CDA00-0x00000001856CDA38
		}
	
		private struct GlobalAisacInfoForMarshaling // TypeDefIndex: 54279
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public ushort index; // 0x08
			public ushort numGraphs; // 0x0A
			public uint type; // 0x0C
			public float randomRange; // 0x10
			public ushort controlId; // 0x14
			public ushort dummy; // 0x16
	
			// Methods
			public void Convert(out GlobalAisacInfo x) {
				x = default;
			} // 0x00000001856E16D4-0x00000001856E172C
		}
	
		private struct SelectorInfoForMarshaling // TypeDefIndex: 54280
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
	
			// Methods
			public void Convert(out SelectorInfo x) {
				x = default;
			} // 0x00000001856E1EF8-0x00000001856E1F44
		}
	
		private struct SelectorLabelInfoForMarshaling // TypeDefIndex: 54281
		{
			// Fields
			public IntPtr selectorNamePtr; // 0x00
			public IntPtr labelNamePtr; // 0x08
	
			// Methods
			public void Convert(out SelectorLabelInfo x) {
				x = default;
			} // 0x00000001856E1F44-0x00000001856E1F8C
		}
	
		// Methods
		public static int GetNumCategories() => default; // 0x00000001856CE0B0-0x00000001856CE0B8
		public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo) {
			categoryInfo = default;
			return default;
		} // 0x00000001856CDF18-0x00000001856CDF64
		public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo) {
			categoryInfo = default;
			return default;
		} // 0x00000001856CDF64-0x00000001856CDFB0
		public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo) {
			categoryInfo = default;
			return default;
		} // 0x00000001856CDECC-0x00000001856CDF18
		public static int GetNumBuses() => default; // 0x00000001856CE0A8-0x00000001856CE0B0
		public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo) {
			dspBusInfo = default;
			return default;
		} // 0x00000001856CDFB0-0x00000001856CE008
		public static int GetNumAisacControls() => default; // 0x00000001856CE0A0-0x00000001856CE0A8
		public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info) {
			info = default;
			return default;
		} // 0x00000001856CDE6C-0x00000001856CDEB0
		public static uint GetAisacControlIdByName(string name) => default; // 0x00000001856CDE64-0x00000001856CDE6C
		public static string GetAisacControlNameById(uint id) => default; // 0x00000001856CDEB0-0x00000001856CDECC
		public static int GetNumGlobalAisacs() => default; // 0x00000001856CE0B8-0x00000001856CE0C0
		public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info) {
			info = default;
			return default;
		} // 0x00000001856CE054-0x00000001856CE0A0
		public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info) {
			info = default;
			return default;
		} // 0x00000001856CE008-0x00000001856CE054
		public static int GetNumSelectors() => default; // 0x00000001856CE0C0-0x00000001856CE0C8
		public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info) {
			info = default;
			return default;
		} // 0x00000001856CE0C8-0x00000001856CE10C
		public static bool GetSelectorInfoByName(string name, out SelectorInfo info) {
			info = default;
			return default;
		} // 0x00000001856CE10C-0x00000001856CE150
		public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo) {
			labelInfo = default;
			return default;
		} // 0x00000001856CE150-0x00000001856CE1B4
		private static extern int criAtomExAcf_GetNumCategories(); // 0x00000001856CE73C-0x00000001856CE768
		private static extern int criAtomExAcf_GetCategoryInfo(ushort index, out CategoryInfoForMarshaling categoryInfo); // 0x00000001856CE42C-0x00000001856CE4B0
		private static extern int criAtomExAcf_GetCategoryInfoByName(string name, out CategoryInfoForMarshaling categoryInfo); // 0x00000001856CE388-0x00000001856CE42C
		private static extern int criAtomExAcf_GetCategoryInfoById(uint id, out CategoryInfoForMarshaling categoryInfo); // 0x00000001856CE304-0x00000001856CE388
		private static extern int criAtomExAcf_GetNumBuses(); // 0x00000001856CE710-0x00000001856CE73C
		private static extern int criAtomExAcf_GetDspBusInformation(ushort index, out DspBusInfoForMarshaling dspBusInfo); // 0x00000001856CE4B0-0x00000001856CE5C4
		private static extern int criAtomExAcf_GetNumAisacControls(); // 0x00000001856CE6EC-0x00000001856CE710
		private static extern int criAtomExAcf_GetAisacControlInfo(ushort index, out AisacControlInfoForMarshaling info); // 0x00000001856CE208-0x00000001856CE28C
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x00000001856CE1B4-0x00000001856CE208
		private static extern IntPtr criAtomExAcf_GetAisacControlNameById(uint id); // 0x00000001856CE28C-0x00000001856CE304
		private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x00000001856CE768-0x00000001856CE78C
		private static extern int criAtomExAcf_GetGlobalAisacInfo(ushort index, out GlobalAisacInfoForMarshaling info); // 0x00000001856CE668-0x00000001856CE6EC
		private static extern int criAtomExAcf_GetGlobalAisacInfoByName(string name, out GlobalAisacInfoForMarshaling info); // 0x00000001856CE5C4-0x00000001856CE668
		private static extern int criAtomExAcf_GetNumSelectors(); // 0x00000001856CE78C-0x00000001856CE7B0
		private static extern int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out SelectorInfoForMarshaling info); // 0x00000001856CE7B0-0x00000001856CE834
		private static extern int criAtomExAcf_GetSelectorInfoByName(string name, out SelectorInfoForMarshaling info); // 0x00000001856CE834-0x00000001856CE8D8
		private static extern int criAtomExAcf_GetSelectorLabelInfo(ref SelectorInfoForMarshaling info, ushort labelIndex, out SelectorLabelInfoForMarshaling label_info); // 0x00000001856CE8D8-0x00000001856CE96C
	}

	public static class CriAtomExAcbDebug // TypeDefIndex: 54285
	{
		// Nested types
		public struct AcbInfo // TypeDefIndex: 54283
		{
			// Fields
			public string name; // 0x00
			public uint size; // 0x08
			public uint version; // 0x0C
			public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
			public float volume; // 0x14
			public int numCues; // 0x18
		}
	
		private struct AcbInfoForMarshaling // TypeDefIndex: 54284
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public uint size; // 0x08
			public uint version; // 0x0C
			public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
			public float volume; // 0x14
			public int numCues; // 0x18
	
			// Methods
			public void Convert(out AcbInfo x) {
				x = default;
			} // 0x00000001856CD9B0-0x00000001856CDA00
		}
	
		// Methods
		public static bool GetAcbInfo(CriAtomExAcb acb, out AcbInfo acbInfo) {
			acbInfo = default;
			return default;
		} // 0x00000001856CDD84-0x00000001856CDDE0
		private static extern int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out AcbInfoForMarshaling acbInfo); // 0x00000001856CDDE0-0x00000001856CDE64
	}

	public static class CriAtomExPlaybackDebug // TypeDefIndex: 54286
	{
		// Methods
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value) {
			value = default;
			return default;
		} // 0x00000001856CEA34-0x00000001856CEA4C
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value) {
			value = default;
			return default;
		} // 0x00000001856CEA4C-0x00000001856CEA64
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value) {
			value = default;
			return default;
		} // 0x00000001856CEA1C-0x00000001856CEA34
		public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value) {
			value = default;
			return default;
		} // 0x00000001856CE9EC-0x00000001856CEA04
		public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value) {
			value = default;
			return default;
		} // 0x00000001856CEA04-0x00000001856CEA1C
		private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value); // 0x00000001856CEBA4-0x00000001856CEC34
		private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value); // 0x00000001856CECC4-0x00000001856CED54
		private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value); // 0x00000001856CEC34-0x00000001856CECC4
		private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value); // 0x00000001856CEA64-0x00000001856CEAF4
		private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value); // 0x00000001856CEAF4-0x00000001856CEBA4
	}

	public abstract class CriDisposable : IDisposable // TypeDefIndex: 54287
	{
		// Fields
		public Guid guid; // 0x10
	
		// Constructors
		public CriDisposable() {} // 0x00000001831836D0-0x0000000183183740
	
		// Methods
		public abstract void Dispose();
	}

	public static class CriDisposableObjectManager // TypeDefIndex: 54290
	{
		// Fields
		private static List<ObjectRef> refList; // 0x00
	
		// Nested types
		public enum ModuleType // TypeDefIndex: 54288
		{
			Atom = 0,
			AtomMic = 1,
			Fs = 2,
			FsWeb = 3,
			Mana = 4,
			Lips = 5,
			Vip = 6,
			Rtc = 7
		}
	
		public struct ObjectRef // TypeDefIndex: 54289
		{
			// Fields
			public Guid guid; // 0x00
			public ModuleType type; // 0x10
			public CriDisposable disposable; // 0x18
	
			// Constructors
			public ObjectRef(Guid _guid, CriDisposable _disposable, ModuleType _type) {
				guid = default;
				type = default;
				disposable = default;
			} // 0x0000000184275A98-0x0000000184275AB0
		}
	
		// Constructors
		static CriDisposableObjectManager() {} // 0x0000000183CE4C60-0x0000000183CE4CF0
	
		// Methods
		private static int SearchForDisposable(CriDisposable disposable) => default; // 0x0000000183184360-0x0000000183184630
		public static void Register(CriDisposable disposable, ModuleType type) {} // 0x0000000183183FA0-0x0000000183184360
		public static bool Unregister(CriDisposable disposable) => default; // 0x00000001856D4BDC-0x00000001856D4D20
		public static bool IsDisposed(CriDisposable disposable) => default; // 0x00000001856D4B98-0x00000001856D4BDC
		public static void CallOnModuleFinalization(ModuleType type) {} // 0x00000001856D47EC-0x00000001856D4834
		private static int GetNextWithType(ModuleType type) => default; // 0x00000001856D4AD0-0x00000001856D4B98
		public static void DisposeAll(ModuleType type) {} // 0x00000001856D4834-0x00000001856D4AD0
	}

	public abstract class CriMonoBehaviour : MonoBehaviour // TypeDefIndex: 54291
	{
		// Properties
		public Guid guid { get; private set; } // 0x0000000183D51D80-0x0000000183D51D90 0x0000000183D51D90-0x0000000183D51DA0
	
		// Constructors
		public CriMonoBehaviour() {} // 0x0000000183772920-0x00000001837729A0
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018268E0D0-0x000000018268E140
		protected virtual void OnDisable() {} // 0x00000001856E038C-0x00000001856E03D8
		public abstract void CriInternalUpdate();
		public abstract void CriInternalLateUpdate();
	}

	public class CriMonoBehaviourManager : MonoBehaviour // TypeDefIndex: 54292
	{
		// Fields
		private static CriMonoBehaviourManager _instance; // 0x00
		private static List<CriMonoBehaviour> criMonoBehaviourList; // 0x08
	
		// Properties
		public static CriMonoBehaviourManager instance { get => default; } // 0x000000018268E140-0x000000018268E1A0 
	
		// Constructors
		public CriMonoBehaviourManager() {} // 0x000000018426FE60-0x000000018426FE68
		static CriMonoBehaviourManager() {} // 0x0000000183CAC4D0-0x0000000183CAC590
	
		// Methods
		public static void CreateInstance() {} // 0x000000018268E1A0-0x000000018268E260
		private static int GetIndex(CriMonoBehaviour criMonoBehaviour) => default; // 0x000000018268E4B0-0x000000018268E5E0
		public bool Register(CriMonoBehaviour criMonoBehaviour) => default; // 0x000000018268E260-0x000000018268E4B0
		public static bool UnRegister(CriMonoBehaviour criMonoBehaviour) => default; // 0x00000001856E0244-0x00000001856E038C
		private void Awake() {} // 0x0000000183CB6480-0x0000000183CB6550
		private void Update() {} // 0x000000018268E840-0x000000018268EAA0
		private void LateUpdate() {} // 0x000000018268E5E0-0x000000018268E840
	}
}

namespace CriWare.CriAtomDebugDetail
{
	public class Utility // TypeDefIndex: 54293
	{
		// Constructors
		public Utility() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static string PtrToStringAutoOrNull(IntPtr stringPtr) => default; // 0x00000001856E24A0-0x00000001856E24EC
	}
}

namespace CriWare.CriMana
{
	public enum CodecType // TypeDefIndex: 54312
	{
		Unknown = 0,
		SofdecPrime = 1,
		H264 = 5,
		VP9 = 9
	}

	public enum AlphaType // TypeDefIndex: 54313
	{
		CompoOpaq = 0,
		CompoAlphaFull = 1,
		CompoAlpha3Step = 2,
		CompoAlpha32Bit = 3
	}

	public struct AudioInfo // TypeDefIndex: 54314
	{
		// Fields
		public uint samplingRate; // 0x00
		public uint numChannels; // 0x04
		public uint totalSamples; // 0x08
	}

	[Serializable]
	public class MovieInfo // TypeDefIndex: 54315
	{
		// Fields
		private uint _reserved1; // 0x10
		public uint numAlphaStreams; // 0x14
		public uint width; // 0x18
		public uint height; // 0x1C
		public uint dispWidth; // 0x20
		public uint dispHeight; // 0x24
		public uint framerateN; // 0x28
		public uint framerateD; // 0x2C
		public uint totalFrames; // 0x30
		public CodecType codecType; // 0x34
		public CodecType alphaCodecType; // 0x38
		public uint numAudioStreams; // 0x3C
		public AudioInfo[] audioPrm; // 0x40
		public uint numSubtitleChannels; // 0x48
		public uint maxSubtitleSize; // 0x4C
		public uint maxChunkSize; // 0x50
	
		// Properties
		public bool hasAlpha { get => default; internal set {} } // 0x00000001856E5CC0-0x00000001856E5CC8 0x00000001856E5CC8-0x00000001856E5CE4
	
		// Constructors
		public MovieInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	public class FrameInfo // TypeDefIndex: 54316
	{
		// Fields
		public int frameNo; // 0x10
		public int frameNoPerFile; // 0x14
		public uint width; // 0x18
		public uint height; // 0x1C
		public uint dispWidth; // 0x20
		public uint dispHeight; // 0x24
		public uint numImages; // 0x28
		public uint framerateN; // 0x2C
		public uint framerateD; // 0x30
		private uint _reserved1; // 0x34
		public ulong time; // 0x38
		public ulong tunit; // 0x40
		public uint cntConcatenatedMovie; // 0x48
		private AlphaType alphaType; // 0x4C
		public uint cntSkippedFrames; // 0x50
		public uint totalFramesPerFile; // 0x54
	
		// Constructors
		public FrameInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	public struct EventPoint // TypeDefIndex: 54317
	{
		// Fields
		public IntPtr cueName; // 0x00
		public uint cueNameSize; // 0x08
		public ulong time; // 0x10
		public ulong tunit; // 0x18
		public int type; // 0x20
		public IntPtr paramString; // 0x28
		public uint paramStringSize; // 0x30
		public uint cntCallback; // 0x34
	}

	public static class Settings // TypeDefIndex: 54318
	{
		// Methods
		public static void SetDecodeSkippingEnabled(bool enabled) {} // 0x00000001856EC79C-0x00000001856EC7E8
	}

	public class Player : CriDisposable // TypeDefIndex: 54333
	{
		// Fields
		private const int InvalidPlayerId = -1; // Metadata: 0x01FD65BB
		private static Player updatingPlayer; // 0x00
		private int playerId; // 0x20
		private bool isDisposed; // 0x24
		private Status internalrequiredStatus; // 0x28
		private Status _nativeStatus; // 0x2C
		private Status? lastNativeStatus; // 0x30
		private Status? lastPlayerStatus; // 0x38
		private bool wasStopping; // 0x40
		private bool isPreparingForRendering; // 0x41
		private bool isNativeStartInvoked; // 0x42
		private bool isNativeInitialized; // 0x43
		private RendererResource rendererResource; // 0x48
		private MovieInfo _movieInfo; // 0x50
		private FrameInfo _frameInfo; // 0x58
		private bool isMovieInfoAvailable; // 0x60
		private bool isFrameInfoAvailable; // 0x61
		private ShaderDispatchCallback _shaderDispatchCallback; // 0x68
		private bool enableSubtitle; // 0x70
		private int subtitleBufferSize; // 0x74
		private uint droppedFrameCount; // 0x78
		private CriAtomExPlayer _atomExPlayer; // 0x80
		private CriAtomEx3dSource _atomEx3Dsource; // 0x88
		private TimerType _timerType; // 0x90
		private bool isStoppingForSeek; // 0x94
		public CuePointCallback cuePointCallback; // 0x98
		public StatusChangeCallback statusChangeCallback; // 0xA0
		protected Queue<Operation> operationQueue; // 0xD8
		protected Operation? cntOperation; // 0xE0
	
		// Properties
		private Status requiredStatus { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x00000001856E9A6C-0x00000001856E9A8C
		public bool additiveMode { get; set; } // 0x0000000181151530-0x0000000181151540 0x0000000181151540-0x0000000181151550
		public bool useMaterialBlendMode { get; set; } // 0x0000000183D51890-0x0000000183D518A0 0x0000000183D518D0-0x0000000183D518E0
		public int maxFrameDrop { get; set; } // 0x0000000183D51FA0-0x0000000183D51FB0 0x0000000183D51FE0-0x0000000183D51FF0
		public bool applyTargetAlpha { get; set; } // 0x0000000183D51F80-0x0000000183D51F90 0x0000000183D51FD0-0x0000000183D51FE0
		public bool uiRenderMode { get; set; } // 0x0000000183D51FC0-0x0000000183D51FD0 0x0000000183D52000-0x0000000183D52010
		public bool isFrameAvailable { get => default; } // 0x0000000183D51F90-0x0000000183D51FA0 
		public MovieInfo movieInfo { get => default; } // 0x00000001856E9944-0x00000001856E9954 
		public FrameInfo frameInfo { get => default; } // 0x00000001856E992C-0x00000001856E993C 
		public Status status { get => default; } // 0x00000001856E9960-0x00000001856E99D4 
		public Status nativeStatus { get => default; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 
		public int numberOfEntries { get => default; } // 0x00000001856E9954-0x00000001856E9960 
		public IntPtr subtitleBuffer { get; private set; } // 0x0000000183D50E60-0x0000000183D50E70 0x0000000183D50F30-0x0000000183D50F40
		public int subtitleSize { get; private set; } // 0x0000000183D51FB0-0x0000000183D51FC0 0x0000000183D51FF0-0x0000000183D52000
		public CriAtomExPlayer atomExPlayer { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public CriAtomEx3dSource atomEx3DsourceForAmbisonics { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public TimerType timerType { get => default; } // 0x0000000183D4FB60-0x0000000183D4FB70 
		public CriManaMoviePlayerHolder playerHolder { get; set; } // 0x0000000183D50050-0x0000000183D50060 0x000000018554A7E0-0x000000018554A7F4
		public bool isAlive { get => default; } // 0x00000001856E993C-0x00000001856E9944 
	
		// Events
		public event SubtitleChangeCallback OnSubtitleChanged;
	
		// Nested types
		public enum Status // TypeDefIndex: 54319
		{
			Stop = 0,
			Dechead = 1,
			WaitPrep = 2,
			Prep = 3,
			Ready = 4,
			Playing = 5,
			PlayEnd = 6,
			Error = 7,
			StopProcessing = 8,
			ReadyForRendering = 9
		}
	
		public enum SetMode // TypeDefIndex: 54320
		{
			New = 0,
			Append = 1,
			AppendRepeatedly = 2
		}
	
		public enum MovieEventSyncMode // TypeDefIndex: 54321
		{
			FrameTime = 0,
			PlayBackTime = 1
		}
	
		public enum AudioTrack // TypeDefIndex: 54322
		{
			Off = 0,
			Auto = 1
		}
	
		public enum TimerType // TypeDefIndex: 54323
		{
			None = 0,
			System = 1,
			Audio = 2,
			User = 3,
			Manual = 4
		}
	
		public delegate void CuePointCallback(ref EventPoint eventPoint); // TypeDefIndex: 54324; 0x0000000182149960-0x0000000182149970
	
		public delegate void StatusChangeCallback(Status status); // TypeDefIndex: 54325; 0x0000000182149960-0x0000000182149970
	
		public delegate void SubtitleChangeCallback(IntPtr subtitleBuffer); // TypeDefIndex: 54326; 0x0000000182149960-0x0000000182149970
	
		public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode); // TypeDefIndex: 54327; 0x0000000181165340-0x0000000181165350
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint); // TypeDefIndex: 54328; 0x00000001811360D0-0x00000001811360F0
	
		public enum CriManaUnityPlayer_RenderEventAction // TypeDefIndex: 54329
		{
			UPDATE = 0,
			INITIALIZE = 256,
			RENDER = 512,
			DESTROY = 768
		}
	
		protected enum OperationType // TypeDefIndex: 54330
		{
			Normal = 0,
			SetFile = 1,
			SeekToTime = 2,
			Pause = 3
		}
	
		protected struct Operation // TypeDefIndex: 54331
		{
			// Fields
			public OperationType opType; // 0x00
			public Status targetStatus; // 0x04
			public bool isStopForSeek; // 0x08
			public CriFsBinder binder; // 0x10
			public string moviePath; // 0x18
			public SetMode setMode; // 0x20
			public float timeToSeek; // 0x24
			public bool sw; // 0x28
	
			// Methods
			public static Operation Start() => default; // 0x0000000183D51F10-0x0000000183D51F40
			public static Operation Pause(bool sw) => default; // 0x0000000183D51E60-0x0000000183D51E80
			public static Operation Stop() => default; // 0x0000000183D51F60-0x0000000183D51F80
			public static Operation StopForSeek() => default; // 0x0000000183D51F40-0x0000000183D51F60
			public static Operation Prepare() => default; // 0x0000000183D51EB0-0x0000000183D51EE0
			public static Operation PrepareForRendering() => default; // 0x0000000183D51E80-0x0000000183D51EB0
			public static Operation SetFile(CriFsBinder binder, string moviePath, SetMode setMode) => default; // 0x00000001856E5CE4-0x00000001856E5D28
			public static Operation SeekToTime(float time) => default; // 0x0000000183D51EE0-0x0000000183D51F10
		}
	
		// Constructors
		public Player() {} // 0x00000001856E9588-0x00000001856E972C
		public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length) {} // 0x00000001856E9298-0x00000001856E9588
	
		// Methods
		~Player() {} // 0x00000001856E8148-0x00000001856E81BC
		public override void Dispose() {} // 0x00000001856E78AC-0x00000001856E78FC
		public void CreateRendererResource(int width, int height, bool alpha) {} // 0x00000001856E73A4-0x00000001856E7520
		public void DisposeRendererResource() {} // 0x00000001856E761C-0x00000001856E7654
		public void Prepare() {} // 0x00000001856E89C4-0x00000001856E8A04
		public void PrepareForRendering() {} // 0x00000001856E88E4-0x00000001856E8928
		public void Start() {} // 0x00000001856E8E4C-0x00000001856E8EAC
		public void Stop() {} // 0x00000001856E8F60-0x00000001856E8FA8
		public void StopForSeek() {} // 0x00000001856E8EAC-0x00000001856E8F60
		public void Pause(bool sw) {} // 0x00000001856E88CC-0x00000001856E88E4
		public bool IsPaused() => default; // 0x00000001856E8760-0x00000001856E876C
		public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x01FD65B4 */) => default; // 0x00000001856E8BF0-0x00000001856E8CB8
		public bool SetData(IntPtr data, long dataSize, SetMode setMode = SetMode.New /* Metadata: 0x01FD65B5 */) => default; // 0x00000001856E8B34-0x00000001856E8B64
		[Obsolete("Use SetData(IntPtr, Int64, SetMode) instead")]
		public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New /* Metadata: 0x01FD65B6 */) => default; // 0x00000001856E8B04-0x00000001856E8B34
		public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New /* Metadata: 0x01FD65B7 */) => default; // 0x00000001856E8A58-0x00000001856E8B04
		public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New /* Metadata: 0x01FD65B8 */) => default; // 0x00000001856E8BB8-0x00000001856E8BF0
		public void Loop(bool sw) {} // 0x00000001856E8880-0x00000001856E8890
		public void SetMasterTimerType(TimerType timerType) {} // 0x00000001856E8D3C-0x00000001856E8D50
		public void SetSeekPosition(int frameNumber) {} // 0x00000001856E8D74-0x00000001856E8D80
		public void SetMovieEventSyncMode(MovieEventSyncMode mode) {} // 0x00000001856E8D68-0x00000001856E8D74
		public void SetSpeed(float speed) {} // 0x00000001856E8D80-0x00000001856E8D8C
		public void SetMaxPictureDataSize(uint maxDataSize) {} // 0x00000001856E8D50-0x00000001856E8D5C
		public void SetBufferingTime(float sec) {} // 0x00000001856E8A40-0x00000001856E8A4C
		public void SetMinBufferSize(int min_buffer_size) {} // 0x00000001856E8D5C-0x00000001856E8D68
		public void SetAudioTrack(int track) {} // 0x00000001856E8A34-0x00000001856E8A40
		public void SetAudioTrack(AudioTrack track) {} // 0x00000001856E8A10-0x00000001856E8A34
		public void SetSubAudioTrack(int track) {} // 0x00000001856E8D98-0x00000001856E8DA4
		public void SetSubAudioTrack(AudioTrack track) {} // 0x00000001856E8DA4-0x00000001856E8DC8
		public void SetExtraAudioTrack(int track) {} // 0x00000001856E8B70-0x00000001856E8B7C
		public void SetExtraAudioTrack(AudioTrack track) {} // 0x00000001856E8B7C-0x00000001856E8BA0
		public void SetVolume(float volume) {} // 0x00000001856E8E40-0x00000001856E8E4C
		public float GetVolume() => default; // 0x00000001856E8274-0x00000001856E8280
		public void SetSubAudioVolume(float volume) {} // 0x00000001856E8DC8-0x00000001856E8DD4
		public float GetSubAudioVolume() => default; // 0x00000001856E81D4-0x00000001856E81E0
		public void SetExtraAudioVolume(float volume) {} // 0x00000001856E8BA0-0x00000001856E8BAC
		public float GetExtraAudioVolume() => default; // 0x00000001856E81C8-0x00000001856E81D4
		public void SetBusSendLevel(string bus_name, float level) {} // 0x00000001856E8A4C-0x00000001856E8A58
		public void SetSubAudioBusSendLevel(string bus_name, float volume) {} // 0x00000001856E8D8C-0x00000001856E8D98
		public void SetExtraAudioBusSendLevel(string bus_name, float volume) {} // 0x00000001856E8B64-0x00000001856E8B70
		public void SetSubtitleChannel(int channel) {} // 0x00000001856E8DD4-0x00000001856E8E34
		public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback) {} // 0x00000001838C5570-0x00000001838C5580
		public long GetTime() => default; // 0x00000001856E81E0-0x00000001856E81EC
		public int GetDisplayedFrameNo() => default; // 0x00000001856E81BC-0x00000001856E81C8
		public bool HasRenderedNewFrame() => default; // 0x00000001856E8280-0x00000001856E82A8
		public void SetAsrRackId(int asrRackId) {} // 0x00000001856E8A04-0x00000001856E8A10
		public void SetUserTimeCorrectionThreshold(uint threshold_msec) {} // 0x00000001856E8E34-0x00000001856E8E40
		public void SetExtraFramePoolSize(uint size) {} // 0x00000001856E8BAC-0x00000001856E8BB8
		public void UpdateWithUserTime(ulong timeCount, ulong timeUnit) {} // 0x00000001856E91EC-0x00000001856E927C
		public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD) {} // 0x00000001856E8CB8-0x00000001856E8D3C
		public void UpdateWithManualTimeAdvanced() {} // 0x00000001856E917C-0x00000001856E91EC
		public void Update() {} // 0x00000001856E927C-0x00000001856E9298
		public void OnWillRenderObject(CriManaMovieMaterialBase sender) {} // 0x00000001856E8890-0x00000001856E88CC
		public bool UpdateMaterial(Material material) => default; // 0x00000001856E8FA8-0x00000001856E9010
		public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction) {} // 0x00000001856E876C-0x00000001856E87E4
		private void Dispose(bool disposing) {} // 0x00000001856E7654-0x00000001856E78AC
		private void InternalUpdate() {} // 0x00000001856E82A8-0x00000001856E86A4
		[IteratorStateMachine(typeof(_IssuePluginUpdatesForFrames_d__152))]
		private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy, int playerId) => default; // 0x00000001856E87E4-0x00000001856E8880
		private void DisableInfos(bool keepFrameInfo = false /* Metadata: 0x01FD65B9 */) {} // 0x00000001856E7600-0x00000001856E761C
		private void PrepareNativePlayer() {} // 0x00000001856E8928-0x00000001856E89C4
		private void UpdateNativePlayer() {} // 0x00000001856E9010-0x00000001856E917C
		private void InvokePlayerStatusCheck() {} // 0x00000001856E86A4-0x00000001856E8760
		private void AllocateSubtitleBuffer(int size) {} // 0x00000001856E5E48-0x00000001856E5F0C
		private void DeallocateSubtitleBuffer() {} // 0x00000001856E7588-0x00000001856E7600
		internal void PauseOnApplicationPause(bool sw) {} // 0x00000001856E88CC-0x00000001856E88E4
		[AOT.MonoPInvokeCallback(typeof(CuePointCallbackFromNativeDelegate))]
		private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint) {} // 0x00000001856E7520-0x00000001856E7588
		private static extern int CRIWAREFD186F02(); // 0x00000001856E7330-0x00000001856E735C
		private static extern int CRIWARE72A5B8BF(); // 0x00000001856E6858-0x00000001856E6884
		private static extern int CRIWARE95A85424(bool useAtomExPlayer, uint maxPathLength); // 0x00000001856E6A94-0x00000001856E6B18
		private static extern void CRIWAREABF659EC(int player_id); // 0x00000001856E6C20-0x00000001856E6C54
		private static extern void CRIWAREEDB46019(int player_id, IntPtr binder, string path); // 0x00000001856E71EC-0x00000001856E7294
		private static extern void CRIWAREB28B5D50(int player_id, IntPtr binder, int content_id); // 0x00000001856E6CB8-0x00000001856E6D4C
		private static extern void CRIWARE65553651(int player_id, string path, ulong offset, long range); // 0x00000001856E66B8-0x00000001856E676C
		private static extern void CRIWARE7C753A2E(int player_id, IntPtr data, long datasize); // 0x00000001856E68EC-0x00000001856E6980
		private static extern void CRIWARE7C753A2E(int player_id, byte[] data, long datasize); // 0x00000001856E6980-0x00000001856E6A1C
		private static extern bool CRIWARE328F2911(int player_id, IntPtr binder, string path, bool repeat); // 0x00000001856E639C-0x00000001856E6460
		private static extern bool CRIWAREDA0693CD(int player_id, IntPtr binder, int content_id, bool repeat); // 0x00000001856E70D0-0x00000001856E7178
		private static extern bool CRIWARE162DD162(int player_id, string path, ulong offset, long range, bool repeat); // 0x00000001856E5F90-0x00000001856E6060
		private static extern bool CRIWAREC35C3DC3(int player_id, IntPtr data, long datasize, bool repeat); // 0x00000001856E6DC0-0x00000001856E6E68
		private static extern bool CRIWAREC35C3DC3(int player_id, byte[] data, long datasize, bool repeat); // 0x00000001856E6E68-0x00000001856E6F18
		private static extern void CRIWARE66A63134(int player_id); // 0x00000001856E676C-0x00000001856E67A0
		private static extern int CRIWARE88D04318(int player_id); // 0x00000001856E6A1C-0x00000001856E6A50
		private static extern void CRIWARED9F7168D(int player_id, CuePointCallbackFromNativeDelegate cbfunc); // 0x00000001856E7044-0x00000001856E70D0
		private static extern void CRIWARE1E785A43(int player_id, out MovieInfo movie_info); // 0x00000001856E60D4-0x00000001856E61B0
		private static extern int CRIWARE3CE8CE6A(int player_id, IntPtr subtitle_buffer, ref uint subtitle_size); // 0x00000001856E64C8-0x00000001856E655C
		private static extern void CRIWARE362A826C(int player_id); // 0x00000001856E6494-0x00000001856E64C8
		private static extern void CRIWARE61523A0C(int player_id); // 0x00000001856E6684-0x00000001856E66B8
		private static extern void CRIWAREBB898C91(int player_id); // 0x00000001856E6D4C-0x00000001856E6D80
		private static extern void CRIWARE705B8C6D(int player_id, int seek_frame_no); // 0x00000001856E67E0-0x00000001856E6820
		private static extern void CRIWAREEB32FC73(int player_id, MovieEventSyncMode mode); // 0x00000001856E71AC-0x00000001856E71EC
		private static extern void CRIWARE18BFCB88(int player_id, int sw); // 0x00000001856E6094-0x00000001856E60D4
		private static extern bool CRIWAREEFA5210A(int player_id); // 0x00000001856E7294-0x00000001856E72CC
		private static extern void CRIWARE4331E077(int player_id, int sw); // 0x00000001856E6610-0x00000001856E6650
		private static extern long CRIWARE7779586C(int player_id); // 0x00000001856E68B8-0x00000001856E68EC
		private static extern int CRIWARE33981CC9(int player_id); // 0x00000001856E6460-0x00000001856E6494
		private static extern IntPtr CRIWARE165B6B70(int player_id); // 0x00000001856E6060-0x00000001856E6094
		private static extern int CRIWARE7500F0DD(int player_id); // 0x00000001856E6884-0x00000001856E68B8
		private static extern void CRIWARED99932F6(int player_id, int track); // 0x00000001856E7004-0x00000001856E7044
		private static extern void CRIWARE1FF2F5BE(int player_id, float vol); // 0x00000001856E61F4-0x00000001856E6238
		private static extern float CRIWARED30C9C6F(int player_id); // 0x00000001856E6FD0-0x00000001856E7004
		private static extern void CRIWARE0EA59F65(int player_id, int track); // 0x00000001856E5F50-0x00000001856E5F90
		private static extern void CRIWARE1EBB12C5(int player_id, float vol); // 0x00000001856E61B0-0x00000001856E61F4
		private static extern float CRIWARE966C4BA9(int player_id); // 0x00000001856E6B18-0x00000001856E6B4C
		private static extern void CRIWARE213452EF(int player_id, int track); // 0x00000001856E6238-0x00000001856E6278
		private static extern void CRIWARE0348BF1B(int player_id, float vol); // 0x00000001856E5F0C-0x00000001856E5F50
		private static extern float CRIWAREC5A3A88D(int player_id); // 0x00000001856E6F18-0x00000001856E6F4C
		private static extern void CRIWARE31668293(int player_id, string bus_name, float level); // 0x00000001856E6338-0x00000001856E639C
		private static extern void CRIWAREB2460D7A(int player_id, string bus_name, float level); // 0x00000001856E6C54-0x00000001856E6CB8
		private static extern void CRIWAREF4B0CC4E(int player_id, string bus_name, float level); // 0x00000001856E72CC-0x00000001856E7330
		private static extern void CRIWARE2C8FF595(int player_id, int channel); // 0x00000001856E62F8-0x00000001856E6338
		private static extern void CRIWAREAB576D15(int player_id, float speed); // 0x00000001856E6BDC-0x00000001856E6C20
		private static extern void CRIWARE3F9C5D06(int player_id, uint max_data_size); // 0x00000001856E655C-0x00000001856E65DC
		public static extern void CRIWARE8A87737B(int player_id, float sec); // 0x00000001856E6A50-0x00000001856E6A94
		public static extern void CRIWARE6756AE56(int player_id, int min_buffer_size); // 0x00000001856E67A0-0x00000001856E67E0
		public static extern void CRIWAREA7F6DE6B(int player_id, int asr_rack_id); // 0x00000001856E6B9C-0x00000001856E6BDC
		private static extern void CRIWAREE2DF1163(int player_id); // 0x00000001856E7178-0x00000001856E71AC
		private static extern void CRIWAREBD24DE27(int player_id, TimerType timer_type); // 0x00000001856E6D80-0x00000001856E6DC0
		private static extern void CRIWAREC7C5CC77(int player_id, ulong user_count, ulong user_unit); // 0x00000001856E6F4C-0x00000001856E6F9C
		private static extern void CRIWAREA59E0F01(int player_id, ulong timer_unit_n, ulong timer_unit_d); // 0x00000001856E6B4C-0x00000001856E6B9C
		private static extern void CRIWARE55ECC3E4(int player_id); // 0x00000001856E6650-0x00000001856E6684
		private static extern void CRIWARECEA2FA98(int player_id); // 0x00000001856E6F9C-0x00000001856E6FD0
		private static extern IntPtr CRIWARE27ED314F(int player_id, int bufferSize); // 0x00000001856E6278-0x00000001856E62F8
		private static extern bool CRIWARE725ED4B4(int player_id); // 0x00000001856E6820-0x00000001856E6858
		private static extern void CRIWARE419ECAF8(int player_id); // 0x00000001856E65DC-0x00000001856E6610
		private static extern IntPtr criWareUnity_GetRenderEventFunc(); // 0x00000001856E98C4-0x00000001856E992C
		private static extern void criManaUnityPlayer_SetUserTimeCorrectionThreshold(int player_id, uint threshold_msec); // 0x00000001856E9844-0x00000001856E98C4
		private static extern void criManaUnityPlayer_SetExtraFramePoolSize(int player_id, uint size); // 0x00000001856E97C4-0x00000001856E9844
		public void ClearAllOperation() {} // 0x00000001856E735C-0x00000001856E73A4
		protected void ExecuteOperation() {} // 0x00000001856E7E8C-0x00000001856E8148
		public void EasyPrepare() {} // 0x00000001856E7A08-0x00000001856E7A7C
		public void EasyPrepareForRendering() {} // 0x00000001856E7994-0x00000001856E7A08
		public void EasyStart() {} // 0x00000001856E7D40-0x00000001856E7DB4
		public void EasyPause(bool sw) {} // 0x00000001856E78FC-0x00000001856E7994
		public void EasyStop() {} // 0x00000001856E7E28-0x00000001856E7E8C
		public void EasyStopForSeek() {} // 0x00000001856E7DB4-0x00000001856E7E28
		public void EasySetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x01FD65BA */) {} // 0x00000001856E7A7C-0x00000001856E7B68
		public void EasySetSeekTime(float time) {} // 0x00000001856E7B68-0x00000001856E7C04
		public void EasyStartAtTime(float time) {} // 0x00000001856E7C04-0x00000001856E7D40
		public float GetVideoLength() => default; // 0x00000001856E81EC-0x00000001856E8274
	}
}

namespace CriWare.CriMana.Detail
{
	public static class AutoResisterRendererResourceFactories // TypeDefIndex: 54337
	{
		// Nested types
		[RendererResourceFactoryPriority(7050)]
		public class RendererResourceFactoryH264Yuv : RendererResourceFactory // TypeDefIndex: 54334
		{
			// Constructors
			public RendererResourceFactoryH264Yuv() {} // 0x0000000183D46E10-0x0000000183D46E50
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x00000001856E9A8C-0x00000001856E9B28
			protected override void OnDisposeManaged() {} // 0x000000018350B670-0x000000018350B680
			protected override void OnDisposeUnmanaged() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[RendererResourceFactoryPriority(5000)]
		public class RendererResourceFactorySofdecPrimeYuv : RendererResourceFactory // TypeDefIndex: 54335
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuv() {} // 0x0000000183D46D90-0x0000000183D46DD0
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x00000001856E9BD4-0x00000001856E9C80
			protected override void OnDisposeManaged() {} // 0x000000018350B670-0x000000018350B680
			protected override void OnDisposeUnmanaged() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[RendererResourceFactoryPriority(10000)]
		public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory // TypeDefIndex: 54336
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuvRawData() {} // 0x0000000183D46DD0-0x0000000183D46E10
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x00000001856E9B28-0x00000001856E9BD4
			protected override void OnDisposeManaged() {} // 0x000000018350B670-0x000000018350B680
			protected override void OnDisposeUnmanaged() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Methods
		public static void InvokeAutoRegister() {} // 0x0000000183183BE0-0x0000000183183E20
	}

	public class RendererResourceH264Yuv : RendererResourceSofdecPrimeYuv // TypeDefIndex: 54338
	{
		// Constructors
		public RendererResourceH264Yuv() {} // Dummy constructor
		public RendererResourceH264Yuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) {} // 0x00000001856EA2C0-0x00000001856EA2D0
	}

	public abstract class RendererResource : IDisposable // TypeDefIndex: 54339
	{
		// Fields
		private bool disposed; // 0x10
		protected Shader shader; // 0x18
		protected Material currentMaterial; // 0x20
		protected bool hasAlpha; // 0x28
		protected bool additive; // 0x29
		protected bool applyTargetAlpha; // 0x2A
		protected bool ui; // 0x2B
		private bool _useMaterialBlendMode; // 0x2C
	
		// Properties
		public bool useMaterialBlendMode { get; set; } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
	
		// Constructors
		protected RendererResource() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		~RendererResource() {} // 0x00000001856EC484-0x00000001856EC4F8
		public void Dispose() {} // 0x00000001856EC3FC-0x00000001856EC44C
		private void Dispose(bool disposing) {} // 0x00000001856EC44C-0x00000001856EC484
		public int GetNumberOfFrameBeforeDestroy(int playerId) => default; // 0x00000001856EC52C-0x00000001856EC544
		protected void SetupStaticMaterialProperties() {} // 0x00000001856EC598-0x00000001856EC79C
		private void GetBlendModes(out int srcBlendMode, out int dstBlendMode) {
			srcBlendMode = default;
			dstBlendMode = default;
		} // 0x00000001856EC4F8-0x00000001856EC52C
		public virtual void SetApplyTargetAlpha(bool flag) {} // 0x00000001856EC54C-0x00000001856EC558
		public virtual void SetUiRenderMode(bool flag) {} // 0x00000001856EC58C-0x00000001856EC598
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract bool IsPrepared();
		public abstract bool ContinuePreparing();
		public abstract void AttachToPlayer(int playerId);
		public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);
		public abstract bool UpdateMaterial(Material material);
		public abstract void UpdateTextures();
		public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
		public virtual void OnPlayerPause(bool pauseStatus, bool triggredFromApplciationPause) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnPlayerStop() {} // 0x000000018350B670-0x000000018350B680
		public virtual bool OnPlayerStopForSeek() => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual void OnPlayerStart() {} // 0x000000018350B670-0x000000018350B680
		public virtual bool ShouldSkipDestroyOnStopForSeek() => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool HasRenderedNewFrame() => default; // 0x000000018232EB60-0x000000018232EB70
		public static uint NextPowerOfTwo(uint x) => default; // 0x0000000183D520C0-0x0000000183D520F0
		public static int NextPowerOfTwo(int x) => default; // 0x00000001856EC544-0x00000001856EC54C
		public static int CeilingWith(int x, int ceilingValue) => default; // 0x0000000183D520B0-0x0000000183D520C0
		public static int Ceiling16(int x) => default; // 0x0000000183D52070-0x0000000183D52080
		public static int Ceiling32(int x) => default; // 0x0000000183D52090-0x0000000183D520A0
		public static int Ceiling64(int x) => default; // 0x0000000183D520A0-0x0000000183D520B0
		public static int Ceiling256(int x) => default; // 0x0000000183D52080-0x0000000183D52090
		protected static void DisposeTextures(Texture[] textures) {} // 0x00000001856EC350-0x00000001856EC3FC
		protected static void SetKeyword(Material material, string keyword, bool flag) {} // 0x00000001856EC558-0x00000001856EC58C
		protected static extern bool CRIWARE98318E69(int player_id, int num_textures, IntPtr[] tex_ptrs, [In, Out] FrameInfo frame_info, ref bool frame_drop); // 0x00000001856EC138-0x00000001856EC218
		protected static extern bool CRIWARED618B369(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x00000001856EC218-0x00000001856EC278
		protected static extern bool CRIWARE5267266A(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x00000001856EC0D8-0x00000001856EC138
		protected static extern bool CRIWAREE519EFD4(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x00000001856EC278-0x00000001856EC2D8
		protected static extern sbyte CRIWAREF14F77D8(int player_id); // 0x00000001856EC2D8-0x00000001856EC350
	}

	public abstract class RendererResourceFactory : IDisposable // TypeDefIndex: 54340
	{
		// Fields
		private static SortedList<int, RendererResourceFactory> factoryList; // 0x00
		private bool disposed; // 0x10
	
		// Constructors
		protected RendererResourceFactory() {} // 0x000000018350B670-0x000000018350B680
		static RendererResourceFactory() {} // 0x0000000183CE31F0-0x0000000183CE3280
	
		// Methods
		public static void RegisterFactory(RendererResourceFactory factory, int priority) {} // 0x0000000183183F10-0x0000000183183FA0
		public static void DisposeAllFactories() {} // 0x00000001856EA02C-0x00000001856EA1C4
		public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x00000001856E9C80-0x00000001856EA02C
		~RendererResourceFactory() {} // 0x00000001856EA24C-0x00000001856EA2C0
		public void Dispose() {} // 0x00000001856EA1FC-0x00000001856EA24C
		private void Dispose(bool disposing) {} // 0x00000001856EA1C4-0x00000001856EA1FC
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class RendererResourceFactoryPriorityAttribute : Attribute // TypeDefIndex: 54341
	{
		// Fields
		public readonly int priority; // 0x10
	
		// Constructors
		public RendererResourceFactoryPriorityAttribute() {} // Dummy constructor
		public RendererResourceFactoryPriorityAttribute(int priority) {} // 0x00000001810410F0-0x0000000181041100
	}

	public class RendererResourceSofdecPrimeYuv : RendererResource // TypeDefIndex: 54342
	{
		// Fields
		private int width; // 0x30
		private int height; // 0x34
		private bool useUserShader; // 0x38
		private CodecType codecType; // 0x3C
		private Vector4 movieTextureST; // 0x40
		private Vector4 movieChromaTextureST; // 0x50
		private Texture2D[] textureY; // 0x60
		private Texture2D[] textureU; // 0x68
		private Texture2D[] textureV; // 0x70
		private Texture2D[] textureA; // 0x78
		private IntPtr[] nativeTextures; // 0x80
		private int currentTextureSet; // 0x88
		private int drawTextureSet; // 0x8C
		private int playerID; // 0x90
		private bool hasTextureUpdated; // 0x94
		private bool isTextureReady; // 0x95
		private bool hasRenderedNewFrame; // 0x96
	
		// Properties
		private static int NumTextureSets { get => default; } // 0x0000000181168950-0x0000000181168960 
		private static bool IsEditor { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public RendererResourceSofdecPrimeYuv() {} // Dummy constructor
		public RendererResourceSofdecPrimeYuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) {} // 0x00000001856EBB70-0x00000001856EC0D8
	
		// Methods
		protected override void OnDisposeManaged() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnDisposeUnmanaged() {} // 0x00000001856EB390-0x00000001856EB60C
		public override bool IsPrepared() => default; // 0x0000000183D52050-0x0000000183D52060
		public override bool ContinuePreparing() => default; // 0x000000018232EB60-0x000000018232EB70
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x00000001856EB2A0-0x00000001856EB390
		public override bool OnPlayerStopForSeek() => default; // 0x0000000183D52060-0x0000000183D52070
		public override bool HasRenderedNewFrame() => default; // 0x0000000183D52040-0x0000000183D52050
		public override void AttachToPlayer(int playerId) {} // 0x00000001856EB234-0x00000001856EB2A0
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop) => default; // 0x00000001856EB60C-0x00000001856EB6A8
		public override bool UpdateMaterial(Material material) => default; // 0x00000001856EB6A8-0x00000001856EB8D0
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight) {} // 0x00000001856EB8D0-0x00000001856EB9DC
		public override void UpdateTextures() {} // 0x00000001856EB9DC-0x00000001856EBB70
	}

	public class RendererResourceSofdecPrimeYuvRawData : RendererResource // TypeDefIndex: 54343
	{
		// Fields
		private int width; // 0x30
		private int height; // 0x34
		private int chromaWidth; // 0x38
		private int chromaHeight; // 0x3C
		private bool useUserShader; // 0x40
		private CodecType codecType; // 0x44
		private Vector4 movieTextureST; // 0x48
		private Vector4 movieChromaTextureST; // 0x58
		private Texture2D[][] textures; // 0x68
		private int currentTextureSet; // 0x70
		private int drawTextureSet; // 0x74
		private IntPtr[] nativePixels; // 0x78
		private int playerID; // 0x80
		private bool hasTextureUpdated; // 0x84
		private bool isTextureReady; // 0x85
		private bool hasRenderedNewFrame; // 0x86
	
		// Properties
		private static int NumTextureSets { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public RendererResourceSofdecPrimeYuvRawData() {} // Dummy constructor
		public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) {} // 0x00000001856EAD08-0x00000001856EB234
	
		// Methods
		protected override void OnDisposeManaged() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnDisposeUnmanaged() {} // 0x00000001856EA554-0x00000001856EA5C0
		public override bool IsPrepared() => default; // 0x0000000183D52010-0x0000000183D52020
		public override bool ContinuePreparing() => default; // 0x000000018232EB60-0x000000018232EB70
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x00000001856EA464-0x00000001856EA554
		public override bool OnPlayerStopForSeek() => default; // 0x0000000183D52020-0x0000000183D52040
		public override bool HasRenderedNewFrame() => default; // 0x0000000183D51B10-0x0000000183D51B20
		public override void AttachToPlayer(int playerId) {} // 0x00000001856EA2D0-0x00000001856EA33C
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop) => default; // 0x00000001856EA5C0-0x00000001856EA654
		public override bool UpdateMaterial(Material material) => default; // 0x00000001856EA654-0x00000001856EA8C4
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight) {} // 0x00000001856EA8C4-0x00000001856EA9E0
		public override void UpdateTextures() {} // 0x00000001856EA9E0-0x00000001856EAD08
		private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma) {} // 0x00000001856EA33C-0x00000001856EA464
	}
}

namespace CriWare.CriTimeline.Atom
{
	public struct CriAtomClipPlayConfig // TypeDefIndex: 54304
	{
		// Fields
		public readonly CriAtomClipBase clip; // 0x00
		public readonly long startTimeMs; // 0x08
		public readonly double speedRate; // 0x10
		public readonly bool loop; // 0x18
	
		// Constructors
		public CriAtomClipPlayConfig(CriAtomClipBase clip, long startTimeMs, double speedRate, bool loop) {
			this.clip = default;
			this.startTimeMs = default;
			this.speedRate = default;
			this.loop = default;
		} // 0x00000001856E2C6C-0x00000001856E2C98
	}

	[Serializable]
	public class CriAtomBehaviour : PlayableBehaviour // TypeDefIndex: 54305
	{
		// Fields
		[Range(0f, 1f)]
		public float volume; // 0x10
		[Range(-1200f, 1200f)]
		public float pitch; // 0x14
		[Range(0f, 1f)]
		public float AISACValue; // 0x18
		private static int cPreviewStopTimeMs; // 0x00
		private CriAtomExAcb m_acb; // 0x20
		private string m_lastCueSheetPath; // 0x28
		private bool _IsClipPlaying; // 0x34
		private double _CueLength; // 0x38
	
		// Properties
		public CriAtomExPlayback playback { get; private set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public bool IsClipPlaying { get => default; private set {} } // 0x0000000183D4F570-0x0000000183D4F580 0x0000000183D4F590-0x0000000183D4F5A0
		public double CueLength { get => default; private set {} } // 0x0000000183D4F210-0x0000000183D4F220 0x0000000183D4F230-0x0000000183D4F240
	
		// Constructors
		public CriAtomBehaviour() {} // 0x0000000183D4FB80-0x0000000183D4FB90
		static CriAtomBehaviour() {} // 0x00000001856E2AEC-0x00000001856E2B28
	
		// Methods
		public override void OnGraphStop(Playable playable) {} // 0x0000000183D51E20-0x0000000183D51E30
		public void Play(CriAtomSourceBase atomSource, CriAtomClipPlayConfig config) {} // 0x00000001856E2548-0x00000001856E272C
		public void PreviewPlay(Guid trackId, bool instantStop, CriAtomClipPlayConfig config) {} // 0x00000001856E272C-0x00000001856E29BC
		private void WaitAndStop() {} // 0x00000001856E2A40-0x00000001856E2AEC
		public void Stop(bool noReleaseTime = false /* Metadata: 0x01FD65A7 */) {} // 0x00000001856E29BC-0x00000001856E29E4
		private double GetCueLengthSec(CriAtomExAcb acb, string cueName) => default; // 0x00000001856E24EC-0x00000001856E2548
	}

	public class CriAtomClip : CriAtomClipBase // TypeDefIndex: 54306
	{
		// Fields
		public string cueSheet; // 0x30
		public string cueName; // 0x38
	
		// Properties
		public override string CueName { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public override string AcbPath { get => default; } // 0x00000001856E2D9C-0x00000001856E2E24 
		public override string AwbPath { get => default; } // 0x00000001856E2E24-0x00000001856E2EAC 
	
		// Constructors
		public CriAtomClip() {} // 0x00000001856E2D94-0x00000001856E2D9C
	
		// Methods
		public override CriAtomExAcb GetAcb() => default; // 0x00000001856E2C98-0x00000001856E2CA4
		private CriAtomCueSheet GetCueSheet() => default; // 0x00000001856E2CA4-0x00000001856E2CB0
		public override void SetCueFromAtomSource(CriAtomSourceBase atomSource) {} // 0x00000001856E2CB0-0x00000001856E2D94
	}

	public abstract class CriAtomClipBase : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 54307
	{
		// Fields
		public bool stopWithoutRelease; // 0x18
		public bool muted; // 0x19
		public bool ignoreBlend; // 0x1A
		public bool loopWithinClip; // 0x1B
		public bool stopAtClipEnd; // 0x1C
		public CriAtomBehaviour templateBehaviour; // 0x20
		[HideInInspector]
		[SerializeField]
		private double clipDuration; // 0x28
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x0000000183D51E30-0x0000000183D51E40 
		public override double duration { get; } // 0x00000001856E2C50-0x00000001856E2C6C 
		public abstract string CueName { get; }
		public abstract string AcbPath { get; }
		public abstract string AwbPath { get; }
	
		// Constructors
		protected CriAtomClipBase() {} // 0x00000001856E2BEC-0x00000001856E2C50
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x00000001856E2B28-0x00000001856E2BEC
		public void SetClipDuration(double clipDuration) {} // 0x0000000183D4F5C0-0x0000000183D4F5D0
		public abstract CriAtomExAcb GetAcb();
		public abstract void SetCueFromAtomSource(CriAtomSourceBase atomSource);
	}

	[Serializable]
	public class CriAtomMixerBehaviour : PlayableBehaviour // TypeDefIndex: 54308
	{
		// Fields
		internal PlayableDirector m_Director; // 0x10
		internal IEnumerable<TimelineClip> m_Clips; // 0x18
		internal CriAtomSourceBase m_Bind; // 0x20
		internal string m_AisacControls; // 0x28
		internal bool m_StopOnWrapping; // 0x30
		internal bool m_StopAtGraphEnd; // 0x31
		private const int cScratchTimeIntervalMs = 200; // Metadata: 0x01FD65A8
		private System.DateTime m_lastScrubTime; // 0x48
		private double m_lastDirectorTime; // 0x50
	
		// Properties
		public Guid m_Guid { get; private set; } // 0x0000000183D51E40-0x0000000183D51E50 0x0000000183D51E50-0x0000000183D51E60
		private static bool IsEditor { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public CriAtomMixerBehaviour() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void OnPlayableCreate(Playable playable) {} // 0x00000001856E2F24-0x00000001856E2FA4
		public override void OnGraphStop(Playable playable) {} // 0x00000001856E2EAC-0x00000001856E2F24
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x00000001856E2FA4-0x00000001856E35C0
	}

	public class CriAtomTimelinePreviewer : IDisposable // TypeDefIndex: 54310
	{
		// Fields
		private static CriAtomTimelinePreviewer instance; // 0x00
		private CriAtom atom; // 0x10
		private string lastAcfFile; // 0x18
		private Dictionary<string, CriAtomExAcb> acbTable; // 0x20
		private Dictionary<Guid, PlayerSource> playerTable; // 0x28
		private CriAtomEx3dListener listener3d; // 0x30
	
		// Properties
		public static CriAtomTimelinePreviewer Instance { get => default; } // 0x00000001856E45A8-0x00000001856E4638 
		public static bool IsInitialized { get => default; } // 0x00000001856E4638-0x00000001856E4674 
	
		// Nested types
		private struct PlayerSource // TypeDefIndex: 54309
		{
			// Fields
			public readonly CriAtomExPlayer player; // 0x00
			public readonly CriAtomEx3dSource source3d; // 0x08
	
			// Constructors
			public PlayerSource(CriAtomEx3dListener listener) {
				player = default;
				source3d = default;
			} // 0x00000001856E5D28-0x00000001856E5E48
		}
	
		// Constructors
		public CriAtomTimelinePreviewer() {} // 0x00000001856E4454-0x00000001856E45A8
	
		// Methods
		public static void InstanceDispose() {} // 0x00000001856E3FA8-0x00000001856E4010
		public CriAtomExPlayer GetPlayer(Guid trackId) => default; // 0x00000001856E3DCC-0x00000001856E3FA8
		public void SetCue(Guid trackId, CriAtomExAcb acb, string cueName) {} // 0x00000001856E40D0-0x00000001856E4190
		public CriAtomExAcb GetAcb(string acbPath, string awbPath) => default; // 0x00000001856E3A0C-0x00000001856E3DCC
		public CriAtomExPlayback Play(Guid trackId) => default; // 0x00000001856E4010-0x00000001856E4044
		public void StopTrack(Guid trackId, bool stopWithoutRelease = true /* Metadata: 0x01FD65AA */) {} // 0x00000001856E4400-0x00000001856E4454
		public void StopAllTracks(bool stopWithoutRelease = true /* Metadata: 0x01FD65AB */) {} // 0x00000001856E4298-0x00000001856E4400
		public void SetStartTime(Guid trackId, long startTimeMs) {} // 0x00000001856E4214-0x00000001856E4254
		public void SetLoop(Guid trackId, bool sw) {} // 0x00000001856E4190-0x00000001856E41D0
		public void SetVolume(Guid trackId, float volume) {} // 0x00000001856E4254-0x00000001856E4298
		public void SetPitch(Guid trackId, float pitch) {} // 0x00000001856E41D0-0x00000001856E4214
		public void SetAISAC(Guid trackId, string controlName, float value) {} // 0x00000001856E4080-0x00000001856E40D0
		public void PlayerUpdateParameter(Guid trackId, CriAtomExPlayback atomExPlayback) {} // 0x00000001856E4044-0x00000001856E4080
		~CriAtomTimelinePreviewer() {} // 0x00000001856E3998-0x00000001856E3A0C
		public void Dispose() {} // 0x00000001856E35C0-0x00000001856E3610
		private void Dispose(bool disposing) {} // 0x00000001856E3610-0x00000001856E3998
	}

	[TrackBindingType(typeof(CriAtomSourceBase))]
	[TrackClipType(typeof(CriAtomClipBase))]
	[TrackColor(0.3317462f, 0.6611561f, 0.990566f)]
	public class CriAtomTrack : TrackAsset // TypeDefIndex: 54311
	{
		// Fields
		public string m_AisacControls; // 0xC0
		public bool m_StopOnWrapping; // 0xC8
		public bool m_StopAtGraphEnd; // 0xC9
	
		// Constructors
		public CriAtomTrack() {} // 0x00000001856E4AE0-0x00000001856E4B34
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject owner, int inputCount) => default; // 0x00000001856E4674-0x00000001856E4AE0
	}
}

namespace CriWare.CriTimeline.Mana
{
	[Serializable]
	public class CriManaBehaviour : PlayableBehaviour // TypeDefIndex: 54294
	{
		// Constructors
		public CriManaBehaviour() {} // 0x000000018350B670-0x000000018350B680
	}

	public class CriManaClip : CriManaClipBase // TypeDefIndex: 54295
	{
		// Fields
		public string m_moviePath; // 0xA8
		public TextAsset m_movieData; // 0xB0
	
		// Properties
		public override string MoviePath { get => default; } // 0x0000000183D4EB10-0x0000000183D4EB20 
		public override byte[] MovieData { get => default; } // 0x00000001856DBDA4-0x00000001856DBE1C 
		public override string MovieName { get => default; } // 0x00000001856DBE1C-0x00000001856DBEB8 
		public override int DataId { get => default; } // 0x00000001856DBCFC-0x00000001856DBDA4 
	
		// Constructors
		public CriManaClip() {} // 0x00000001856DBCAC-0x00000001856DBCFC
	}

	public abstract class CriManaClipBase : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 54297
	{
		// Fields
		public readonly Guid guid; // 0x18
		public bool m_loopWithinClip; // 0x28
		public bool m_useOnMemoryPlayback; // 0x29
		public GCHandle gcHandle; // 0x30
		[SerializeField]
		private double m_movieFrameRate; // 0x38
		[SerializeField]
		private double m_clipDuration; // 0x40
		public float m_fadeinDuration; // 0x48
		public AnimationCurve m_fadeinCurve; // 0x50
		public float m_fadeoutDuration; // 0x58
		public AnimationCurve m_fadeoutCurve; // 0x60
		public bool m_fadeAudio; // 0x68
		[NonSerialized]
		public TimelineClip m_clip; // 0x70
		public CriManaBehaviour m_manaBehaviour; // 0x78
		private MovieInfoStruct? m_movieInfoStruct; // 0x80
	
		// Properties
		public abstract string MoviePath { get; }
		public abstract byte[] MovieData { get; }
		public abstract string MovieName { get; }
		public abstract int DataId { get; }
		public ClipCaps clipCaps { get; } // 0x0000000181168950-0x0000000181168960 
		public bool IsMovieInfoReady { get; } // 0x00000001856DBC54-0x00000001856DBC90 
		public override double duration { get; } // 0x00000001856DBC90-0x00000001856DBCAC 
	
		// Nested types
		private struct MovieInfoStruct // TypeDefIndex: 54296
		{
			// Fields
			public uint width; // 0x00
			public uint height; // 0x04
			public uint dispWidth; // 0x08
			public uint dispHeight; // 0x0C
			public uint framerateN; // 0x10
			public uint framerateD; // 0x14
			public uint totalFrames; // 0x18
			public CodecType _codecType; // 0x1C
			public CodecType _alphaCodecType; // 0x20
		}
	
		// Constructors
		protected CriManaClipBase() {} // 0x00000001856DBB90-0x00000001856DBC54
	
		// Methods
		private MovieInfoStruct? StructToMovieInfo(MovieInfo movieInfo) => default; // 0x00000001856DBAB8-0x00000001856DBB90
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x00000001856DB6A0-0x00000001856DB764
		public void ReplaceMovieInfo(MovieInfo movieInfo) {} // 0x00000001856DB90C-0x00000001856DBAB8
		public bool IsSameMovie(MovieInfo movieInfo) => default; // 0x00000001856DB830-0x00000001856DB90C
		public int GetSeekFrame(double seekTimeSec, bool loop) => default; // 0x00000001856DB764-0x00000001856DB830
	}

	[Serializable]
	public class CriManaMixerBehaviour : PlayableBehaviour // TypeDefIndex: 54302
	{
		// Fields
		internal PlayableDirector m_PlayableDirector; // 0x10
		internal IEnumerable<TimelineClip> m_clips; // 0x18
		internal CriManaMovieMaterialBase m_boundMovieMaterial; // 0x20
		internal Dictionary<int, GCHandle> m_gcHandleList; // 0x28
		internal bool m_frameSync; // 0x30
		private static double cPreloadTimeSec; // 0x00
		private Guid? m_lastClipId; // 0x34
		private double startTime; // 0x48
		private double m_currentSeekingFrameTime; // 0x50
		private float m_originalAudioVolume; // 0x58
		private float m_originalSubAudioVolume; // 0x5C
		private float m_originalExtraAudioVolume; // 0x60
		private bool enableTimelineScrubPlayback; // 0x64
		public bool IsControllingUI; // 0x65
		private CriManaMovieControllerForUI m_controllerForUI; // 0x68
		public Action<MovieInfo> MovieReadyToPlay; // 0x70
		public Action<bool> OnToggleFMVNode; // 0x78
		private MovieMixerState m_movieMixerState; // 0x80
	
		// Properties
		private static bool IsEditMode { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Nested types
		private enum MovieMixerState // TypeDefIndex: 54298
		{
			Preloading = 0,
			Ready = 1,
			Playing = 2,
			Stopping = 3,
			Stopped = 4
		}
	
		private enum ClipState // TypeDefIndex: 54299
		{
			Idle = 0,
			Prepare = 1,
			Play = 2,
			Seek = 3
		}
	
		// Constructors
		public CriManaMixerBehaviour() {} // 0x0000000183D51CC0-0x0000000183D51CF0
		static CriManaMixerBehaviour() {} // 0x00000001856DE30C-0x00000001856DE34C
	
		// Methods
		private void KeepAudioVolume(bool fadeAudio) {} // 0x00000001856DC1A8-0x00000001856DC264
		private bool PlayMovie(CriManaClipBase clipAsset, int startFrame, double startTime) => default; // 0x00000001856DC82C-0x00000001856DCBF0
		private bool PrepareMovie(CriManaClipBase clipAsset) => default; // 0x00000001856DCBF0-0x00000001856DCE48
		private bool StopMovie() => default; // 0x00000001856DE044-0x00000001856DE14C
		private bool StopForSeekMovie() => default; // 0x00000001856DDFC8-0x00000001856DE044
		private static bool IsPlayerPreparing(Player player) => default; // 0x00000001856DC10C-0x00000001856DC13C
		private static bool IsPlayerStopped(Player player) => default; // 0x00000001856DC188-0x00000001856DC1A8
		private static bool IsPlayerError(Player player) => default; // 0x00000001856DC0E8-0x00000001856DC10C
		private static bool IsPlayerReadyOrPlaying(Player player) => default; // 0x00000001856DC13C-0x00000001856DC188
		private async void ProcessFrameOnSeeking(TimelineClip activeClip, CriManaClipBase clip, double frameTime) {} // 0x00000001856DCE48-0x00000001856DCF24
		private void ForceSyncedStop(bool keepLastFrame = false /* Metadata: 0x01FD659D */) {} // 0x00000001856DBEB8-0x00000001856DBF68
		private void ToggleFMVNode(FrameData info, bool isOn) {} // 0x00000001856DE14C-0x00000001856DE30C
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x00000001856DCF24-0x00000001856DDFC8
		[IteratorStateMachine(typeof(_seekPlaybackEnumerator_d__35))]
		private IEnumerator seekPlaybackEnumerator() => default; // 0x00000001856DE34C-0x00000001856DE3A8
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x00000001856DC270-0x00000001856DC27C
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x00000001856DC264-0x00000001856DC270
		private void PausePlayer(bool pause) {} // 0x00000001856DC7A4-0x00000001856DC82C
		public override void OnGraphStart(Playable playable) {} // 0x00000001856DC27C-0x00000001856DC558
		public override void OnGraphStop(Playable playable) {} // 0x00000001856DC558-0x00000001856DC6C0
		public override void OnPlayableCreate(Playable playable) {} // 0x00000001856DC6C0-0x00000001856DC758
		public override void OnPlayableDestroy(Playable playable) {} // 0x00000001856DC758-0x00000001856DC7A4
		public void InitMovieMixerState() {} // 0x00000001856DBF68-0x00000001856DC0E8
	}

	[TrackBindingType(typeof(CriManaMovieMaterialBase))]
	[TrackClipType(typeof(CriManaClipBase))]
	[TrackColor(0.15f, 0.5f, 1f)]
	public class CriManaTrack : TrackAsset // TypeDefIndex: 54303
	{
		// Fields
		[Tooltip("\u9ED8\u8BA4\u662FTrue\uFF0C\u4E0D\u5141\u8BB8\u4FEE\u6539")]
		public bool frameSync; // 0xC0
		public readonly Guid guid; // 0xC4
		private static Dictionary<int, Guid> bindDict; // 0x00
	
		// Properties
		public CriManaMixerBehaviour MixerBehaviour { get; private set; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 0x0000000185142FC4-0x0000000185142FD8
	
		// Constructors
		public CriManaTrack() {} // 0x00000001856E5930-0x00000001856E5990
		static CriManaTrack() {} // 0x00000001856E58A4-0x00000001856E5930
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x00000001856E4FA8-0x00000001856E5424
		public void BindBehaviourMovieMaterial(PlayableDirector director, CriManaMovieMaterialBase boundMovieMaterial) {} // 0x00000001856E4B34-0x00000001856E4FA8
		private void OnDestroy() {} // 0x00000001856E5424-0x00000001856E5478
		private static void RemoveTrackFromBindDict(CriManaTrack trackAsset) {} // 0x00000001856E5478-0x00000001856E58A4
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 54020
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 54346
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x00000001856E5B84-0x00000001856E5BE8
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 54347
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001856E5C2C-0x00000001856E5CC0
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x00000001856E5BE8-0x00000001856E5C2C
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 54348
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001856ED748-0x00000001856ED7AC
		public static bool IsPatched(int id) => default; // 0x00000001856ED838-0x00000001856ED8D0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001856ED604-0x00000001856ED6D0
		public object CreateWrapper(int id) => default; // 0x00000001856ED6D0-0x00000001856ED748
		public object InitWrapperArray(int len) => default; // 0x00000001856ED7AC-0x00000001856ED838
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001856ED560-0x00000001856ED604
	}
}
