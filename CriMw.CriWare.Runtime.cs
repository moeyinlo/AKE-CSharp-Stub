/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare;
using CriWare.CriMana;
using CriWare.CriMana.Detail;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Timeline;
using UnityEngine.UI;

// Image 33: CriMw.CriWare.Runtime.dll - Assembly: CriMw.CriWare.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55012-55341

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 55338
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D; // 0x00 // Static value (base64): AQAAAAIAAAADAAAA - Metadata: 0x0207BE0C

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 55337
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond.SourceGenerator
{
	internal class DataNAttribute : Attribute // TypeDefIndex: 55014
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 55015
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 55016
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 55017
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 55018
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace CriWare
{
	public class CriWarePS5 // TypeDefIndex: 55023
	{
		// Fields
		public const int SystemUserID = 255; // Metadata: 0x0207BAB8
	
		// Nested types
		public enum AudioPortType : ushort // TypeDefIndex: 55019
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
	
		public enum AttributeId // TypeDefIndex: 55020
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
	
		public enum PortFlag : uint // TypeDefIndex: 55021
		{
			Restricted = 1,
			Passthrough = 2
		}
	
		internal static class SafeNativeMethods // TypeDefIndex: 55022
		{
			// Methods
			public static void criFsUnity_Setup_PS5(bool enable_apr_direct_mode) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public CriWarePS5() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static void SetupFileSystem(bool enableAprDirectMode) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class CriAtomPlugin // TypeDefIndex: 55025
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
		public static bool isInitialized { get; } // 0x0000000187878C38-0x0000000187878D5C 
	
		// Nested types
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 55024; 0x0000000187879294-0x00000001878792DC
	
		// Constructors
		static CriAtomPlugin() {} // 0x00000001864BC1CC-0x00000001864BC2FC
	
		// Methods
		public static void Log(string log) {} // 0x0000000184DCF2A0-0x0000000184DCF2F0
		public static void ExecuteQueuedCueLinkCallbacks() {} // 0x000000018787904C-0x00000001878791E4
		public static void ExecuteQueuedEventCallbacks() {} // 0x00000001850FA230-0x00000001850FA3C0
		public static void ExecuteQueuedBeatSyncCallbacks() {} // 0x00000001850F9730-0x00000001850F97A0
		public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list) {
			effect_interface_list = default;
			return default;
		} // 0x00000001850F95D0-0x00000001850F9620
		private static IntPtr GetSpatializerCoreInterfaceFromAtomOculusAudioBridge() => default; // 0x00000001850F9580-0x00000001850F95D0
		public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_aisacs, int max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, bool vr_mode) {} // 0x00000001850F9660-0x00000001850F96C0
		public static void SetConfigMonitorParametes(int max_preview_objects, int communication_buffer_size, int playback_position_update_interval) {} // 0x00000001850F96C0-0x00000001850F9730
		public static void SetConfigAdditionalParameters_EDITOR(bool enable_user_pcm_output, int user_pcm_buffer_length) {} // 0x00000001850F97A0-0x00000001850F9850
		public static void SetConfigAdditionalParameters_PC(long buffering_time_pc) {} // 0x0000000185492010-0x0000000185492020
		public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output, int pulse_latency_usec) {} // 0x0000000185492010-0x0000000185492020
		public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios) {} // 0x0000000185492010-0x0000000185492020
		public static void SetConfigAdditionalParameters_ANDROID(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio, int stream_type) {} // 0x0000000185492010-0x0000000185492020
		public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders) {} // 0x0000000185492010-0x0000000185492020
		public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices) {} // 0x000000018787923C-0x0000000187879294
		public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports) {} // 0x00000001850F9270-0x00000001850F92B0
		public static void SetConfigAdditionalParameters_SWITCH(bool enable_sonicsync, int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket) {} // 0x00000001850F8A50-0x00000001850F8C10
		public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices) {} // 0x00000001850F94F0-0x00000001850F9540
		public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming) {} // 0x0000000187878A84-0x0000000187878C38
		public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig) => default; // 0x00000001878791E4-0x000000018787923C
		public static void InitializeLibrary() {} // 0x0000000187878D5C-0x0000000187878F18
		public static bool IsLibraryInitialized() => default; // 0x000000018787900C-0x000000018787904C
		public static void FinalizeLibrary() {} // 0x0000000187878FCC-0x000000018787900C
		public static void Pause(bool pause) {} // 0x00000001814A81B0-0x00000001814A81C0
		public static Common.CpuUsage GetCpuUsage() => default; // 0x0000000187878F18-0x0000000187878FCC
		public static int GetOutputSamplingRate() => default; // 0x00000001878789B8-0x0000000187878A84
		public static int GetOutputChannels() => default; // 0x0000000187878968-0x00000001878789B8
		public static bool IsInitializedForPcmOutput() => default; // 0x00000001844CF4B0-0x00000001844CF600
		public static ushort GetLoopCountParameterId() => default; // 0x00000001844CE970-0x00000001844CEA00
		public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce) {} // 0x00000001850F9620-0x00000001850F9660
		private static ulong CallbackFromNative(IntPtr ptr1) => default; // 0x00000001844CF470-0x00000001844CF4B0
		private static extern void CRIWARE009CE561(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_aisacs, int max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, bool use_ambisonics, IntPtr spatializer_core_interface); // 0x00000001844CF430-0x00000001844CF470
		private static extern void CRIWARE8384362B(uint max_preivew_objects, uint communication_buffer_size, int playback_position_update_interval); // 0x00000001844CE8D0-0x00000001844CE970
		private static extern void CRIWARE237CA5E3(bool enable_user_pcm_out_mode); // 0x00000001844CE810-0x00000001844CE8D0
		private static extern void CRIWARE780E6ED2(long buffering_time_pc); // 0x00000001850F8C10-0x00000001850F8C40
		private static extern void CRIWAREE996B258(int output, int pulse_latency_usec); // 0x00000001850F9540-0x00000001850F9580
		private static extern void CRIWARE2F034134(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios); // 0x0000000187878794-0x00000001878787C0
		private static extern void CRIWARE70981A20(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool apply_hw_property, int stream_type); // 0x0000000187878878-0x00000001878788AC
		private static extern void CRIWARE2626EF5B(); // 0x000000018787884C-0x0000000187878878
		public static extern bool CRIWAREC176B113(); // 0x00000001878788AC-0x00000001878788E0
		private static extern void CRIWARE63E1F278(); // 0x000000018787853C-0x00000001878785D4
		private static extern void CRIWAREB64E0C3B(bool pause); // 0x0000000187878608-0x000000018787863C
		public static extern uint CRIWAREA703719E(); // 0x0000000184DCF370-0x0000000184DCF3A0
		public static extern void CRIWAREBF97E87F(int code); // 0x00000001878787EC-0x0000000187878820
		public static extern void CRIWARE15B0037A(IntPtr cbfunc, string separator_string); // 0x0000000184DCF2F0-0x0000000184DCF320
		public static extern void CRIWARE28E5ABA4(IntPtr cbfunc); // 0x00000001878785D4-0x0000000187878608
		private static extern void CRIWARECCA1268B(); // 0x0000000184DCF3F0-0x0000000184DCF540
		public static extern void CRIWARE88175F19(IntPtr cbfunc); // 0x000000018787863C-0x000000018787867C
		private static extern void CRIWARE7581CF8C(); // 0x00000001878787C0-0x00000001878787EC
		public static extern void CRIWARE15F30D07(IntPtr cbfunc); // 0x00000001878788E0-0x000000018787890C
		private static extern void CRIWARED1FD92AA(); // 0x00000001878786F4-0x0000000187878794
		private static extern void CRIWARE2CFF30B7(int sampling_rate_for_memory, int sampling_rate_for_streaming); // 0x000000018787867C-0x00000001878786F4
		public static extern void CRIWARE797E0462(); // 0x000000018787890C-0x000000018787893C
		public static extern void CRIWAREC54D0552(); // 0x000000018787893C-0x0000000187878968
		public static extern void CRIWARE5BC8942D(IntPtr acb_hn, CallbackFromNativeDelegate func, IntPtr obj); // 0x0000000187878820-0x000000018787884C
		public static extern ushort CRIWARE5B1C5B3B(int id); // 0x0000000185EF73D0-0x0000000185EF74A0
		private static extern bool CRIWAREE097EA6E(); // 0x0000000187868998-0x0000000187868A60
		private static extern int CRIWAREE320F01B(); // 0x00000001817C2F70-0x00000001817C2F80
		private static extern int CRIWARE98A6BE5C(); // 0x0000000187868920-0x0000000187868998
	}

	[Serializable]
	public class CriAtomCueSheet // TypeDefIndex: 55026
	{
		// Fields
		public string name; // 0x10
		public string acbFile; // 0x18
		public string awbFile; // 0x20
		public CriAtomExAcb acb; // 0x28
		public CriAtomExAcbLoader.Status loaderStatus; // 0x30
	
		// Properties
		public bool IsLoading { get => default; } // 0x0000000187868D70-0x0000000187868D78 
		public bool IsError { get => default; } // 0x0000000187868D54-0x0000000187868D70 
	
		// Constructors
		public CriAtomCueSheet() {} // 0x0000000187868CEC-0x0000000187868D54
	}

	public class CriAtom : CriMonoBehaviour // TypeDefIndex: 55030
	{
		// Fields
		public string acfFile; // 0x28
		private bool acfIsLoading; // 0x30
		public CriAtomCueSheet[] cueSheets; // 0x38
		public string dspBusSetting; // 0x40
		public bool dontDestroyOnLoad; // 0x48
		private static CriAtomExSequencer.EventCallback eventUserCallback; // 0x00
		private static CriAtomExSequencer.EventCbFunc eventUserCbFunc; // 0x08
		private static CriAtomExBeatSync.CbFunc beatsyncUserCbFunc; // 0x10
		private static CriAtomExBeatSync.CbFunc obsoleteBeatSyncFunc; // 0x18
		private static CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc; // 0x20
		private static CriAtom _instance_k__BackingField; // 0x28
		private GCHandle acfRegisterGCHandle; // 0x50
		public bool dontRemoveExistsCueSheet; // 0x58
	
		// Properties
		private static CriAtom instance { get; set; } // 0x000000018787CD48-0x000000018787CD78 0x000000018787CD78-0x000000018787CDA4
		public static bool CueSheetsAreLoading { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Events
		internal static event CriAtomExSequencer.EventCallback OnEventSequencerCallback;
		private static event CriAtomExBeatSync.CbFunc beatsyncUserCbFunc;
		internal static event CriAtomExBeatSync.CbFunc OnBeatSyncCallback;
		private static event CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc;
		internal static event CriAtomEx.CueLinkCbFunc OnCueLinkCallback;
	
		// Nested types
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 55027
		{
			// Fields
			public CriAtom __4__this; // 0x10
			public int i; // 0x18
			public Predicate<CriAtomCueSheet> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass58_0() {} // 0x0000000187875C94-0x0000000187875C9C
	
			// Methods
			internal bool _MargeCueSheet_b__0(CriAtomCueSheet sheet) => default; // 0x0000000187875C9C-0x0000000187875CA4
		}
	
		private sealed class _LoadAcbFileCoroutine_d__62 : IEnumerator<object> // TypeDefIndex: 55028
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriAtomCueSheet cueSheet; // 0x20
			public CriFsBinder binder; // 0x28
			public string acbPath; // 0x30
			public string awbPath; // 0x38
			public CriAtom __4__this; // 0x40
			public bool loadAwbOnMemory; // 0x48
			private CriAtomExAcbLoader _asyncLoader_5__2; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018787D4C0-0x000000018787D570 
			object IEnumerator.Current { get => default; } // 0x0000000187876824-0x000000018787682C 
	
			// Constructors
			public _LoadAcbFileCoroutine_d__62() {} // Dummy constructor
			public _LoadAcbFileCoroutine_d__62(int __1__state) {} // 0x000000018787D410-0x000000018787D4C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018787D63C-0x000000018787D6EC
			private bool MoveNext() => default; // 0x0000000187872388-0x0000000187872390
			private void __m__Finally1() {} // 0x0000000187872390-0x0000000187872398
			void IEnumerator.Reset() {} // 0x000000018787D6EC-0x000000018787D79C
		}
	
		private sealed class _LoadAcbDataCoroutine_d__64 : IEnumerator<object> // TypeDefIndex: 55029
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriAtomCueSheet cueSheet; // 0x20
			public string awbPath; // 0x28
			public CriFsBinder awbBinder; // 0x30
			public CriAtom __4__this; // 0x38
			public byte[] acbData; // 0x40
			public bool loadAwbOnMemory; // 0x48
			private CriAtomExAcbLoader _asyncLoader_5__2; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018787BD54-0x000000018787BDC0 
			object IEnumerator.Current { get => default; } // 0x000000018787BA18-0x000000018787BAC0 
	
			// Constructors
			public _LoadAcbDataCoroutine_d__64() {} // Dummy constructor
			public _LoadAcbDataCoroutine_d__64(int __1__state) {} // 0x00000001878776F4-0x00000001878776FC
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018787D604-0x000000018787D63C
			private bool MoveNext() => default; // 0x000000018787D79C-0x000000018787D7F0
			private void __m__Finally1() {} // 0x000000018787BAC0-0x000000018787BB40
			void IEnumerator.Reset() {} // 0x000000018787BF88-0x000000018787BFB4
		}
	
		// Constructors
		public CriAtom() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static void AttachDspBusSetting(string settingName) {} // 0x000000018787BEB0-0x000000018787BEE0
		public static void DetachDspBusSetting() {} // 0x000000018787BEE0-0x000000018787BF0C
		public static CriAtomCueSheet GetCueSheet(string name) => default; // 0x000000018787CEB8-0x000000018787D0D8
		public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, CriFsBinder binder = null) => default; // 0x000000018787D0D8-0x000000018787D1C8
		public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, CriFsBinder binder = null, bool loadAwbOnMemory = false /* Metadata: 0x0207BADD */) => default; // 0x000000018787BB40-0x000000018787BCAC
		public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null) => default; // 0x000000018787C600-0x000000018787C670
		public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null, bool loadAwbOnMemory = false /* Metadata: 0x0207BADE */) => default; // 0x000000018787C50C-0x000000018787C600
		public static void RemoveCueSheet(string name) {} // 0x0000000185492010-0x0000000185492020
		public static CriAtomExAcb GetAcb(string cueSheetName) => default; // 0x000000018787BF0C-0x000000018787BF88
		public static void SetCategoryVolume(string name, float volume) {} // 0x000000018787B7E4-0x000000018787B950
		public static void SetCategoryVolume(int id, float volume) {} // 0x000000018787C9B4-0x000000018787CB1C
		public static float GetCategoryVolume(string name) => default; // 0x000000018787C36C-0x000000018787C50C
		public static float GetCategoryVolume(int id) => default; // 0x000000018787C274-0x000000018787C36C
		public static void SetBusAnalyzer(string busName, bool sw) {} // 0x000000018787C0B8-0x000000018787C168
		public static void SetBusAnalyzer(bool sw) {} // 0x000000018787C168-0x000000018787C1B0
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName) => default; // 0x000000018787C1B0-0x000000018787C274
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId) => default; // 0x000000018787BFB4-0x000000018787BFF4
		public void Setup() {} // 0x000000018787BFF4-0x000000018787C0B8
		public void Shutdown() {} // 0x000000018787CBE8-0x000000018787CC3C
		private void Awake() {} // 0x000000018787CB94-0x000000018787CBE8
		protected override void OnEnable() {} // 0x000000018787BCAC-0x000000018787BD00
		private void OnDestroy() {} // 0x000000018787BD00-0x000000018787BD54
		public override void CriInternalUpdate() {} // 0x000000018787CDA4-0x000000018787CEB8
		public override void CriInternalLateUpdate() {} // 0x000000018787C850-0x000000018787C9B4
		public CriAtomCueSheet GetCueSheetInternal(string name) => default; // 0x000000018787D2A0-0x000000018787D38C
		public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder) => default; // 0x000000018787CC3C-0x000000018787CD48
		public void RemoveCueSheetInternal(string name) {} // 0x000000018787C670-0x000000018787C760
		private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet) {} // 0x000000018787D1C8-0x000000018787D234
		private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile) => default; // 0x000000018787C760-0x000000018787C850
		private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile) => default; // 0x000000018787D234-0x000000018787D2A0
		private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory) {} // 0x000000018787D38C-0x000000018787D410
		private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory) => default; // 0x0000000185492010-0x0000000185492020
		private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory) {} // 0x000000018787F81C-0x000000018787F870
		private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory) => default; // 0x0000000181378230-0x0000000181378240
		public static void SequenceEventCallbackFromNative(string eventString) {} // 0x000000018787F618-0x000000018787F690
		private static void SequenceCallbackFromNative(ref CriAtomExSequencer.CriAtomExSequenceEventInfo criAtomExSequenceInfo) {} // 0x000000018787F00C-0x000000018787F5CC
		public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info) {} // 0x000000018787F690-0x000000018787F6D8
		public static void CueLinkCallbackFromNative(ref CriAtomEx.CueLinkInfo info) {} // 0x0000000181377E40-0x0000000181377E50
		public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator) {} // 0x000000018787F5CC-0x000000018787F618
		private static void RegisterEventCallbackChain(CriAtomExSequencer.EventCallback func) {} // 0x0000000181377E40-0x0000000181377E50
		private static void UnregisterEventCallbackChain(CriAtomExSequencer.EventCallback func) {} // 0x0000000181378230-0x0000000181378240
		public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func) {} // 0x000000018787EF4C-0x000000018787EFC4
		private static void RegisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func) {} // 0x000000018787EA48-0x000000018787EF00
		private static void UnregisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func) {} // 0x000000018787EFC4-0x000000018787F00C
		private static void RegisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func) {} // 0x0000000181377E40-0x0000000181377E50
		private static void UnregisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func) {} // 0x000000018787EF00-0x000000018787EF4C
	}

	public class CriAtomListener : CriMonoBehaviour // TypeDefIndex: 55031
	{
		// Fields
		private CriAtomEx3dListener _nativeListener_k__BackingField; // 0x28
		private CriAtomRegion regionOnStart; // 0x30
		public bool activateListenerOnEnable; // 0x38
		private static List<CriAtomListener> listenersList; // 0x00
		private static CriAtomEx3dListener dummyNativeListener; // 0x08
		private Vector3 lastPosition; // 0x3C
		private CriAtomRegion currentRegion; // 0x48
		private bool _isActive; // 0x50
	
		// Properties
		public CriAtomEx3dListener nativeListener { get; protected set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public bool isActive { get => default; set {} } // 0x00000001813ECBE0-0x00000001813ECBF0 0x0000000187877DEC-0x0000000187877E4C
		public CriAtomRegion region3d { get => default; set {} } // 0x00000001813ECF20-0x00000001813ECF30 0x0000000187877E4C-0x0000000187878008
	
		// Constructors
		public CriAtomListener() {} // 0x0000000187877DE0-0x0000000187877DEC
		static CriAtomListener() {} // 0x0000000185F407B0-0x0000000185F40840
	
		// Methods
		public static void CreateDummyNativeListener() {} // 0x00000001850F9920-0x00000001850F9A00
		public static void DestroyDummyNativeListener() {} // 0x00000001878779CC-0x0000000187877A68
		private void Awake() {} // 0x00000001878778A0-0x00000001878779BC
		private void Start() {} // 0x0000000187877B8C-0x0000000187877BF0
		protected override void OnEnable() {} // 0x0000000187877B68-0x0000000187877B8C
		protected override void OnDisable() {} // 0x0000000187877B44-0x0000000187877B68
		private void OnDestroy() {} // 0x0000000187877A68-0x0000000187877B44
		public override void CriInternalUpdate() {} // 0x0000000185492010-0x0000000185492020
		public override void CriInternalLateUpdate() {} // 0x00000001878779BC-0x00000001878779CC
		private void UpdatePosition() {} // 0x0000000187877BF0-0x0000000187877DE0
		public void ActivateListener(bool exclusive = true /* Metadata: 0x0207BADF */) {} // 0x00000001878776FC-0x00000001878778A0
	}

	public class CriAtomOutputDeviceObserver : CriMonoBehaviour // TypeDefIndex: 55035
	{
		// Fields
		private bool dontDestroyOnLoad; // 0x28
		private bool lastIsConnected; // 0x29
		private bool isConnected; // 0x2A
		private OutputDeviceType lastDeviceType; // 0x2C
		private OutputDeviceType deviceType; // 0x30
		private static CriAtomOutputDeviceObserver instance; // 0x00
		private static DeviceConnectionChangeCallback _onDeviceConnectionChanged; // 0x08
	
		// Properties
		public static bool IsDeviceConnected { get => default; } // 0x0000000187878008-0x000000018787815C 
		public static OutputDeviceType DeviceType { get => default; } // 0x00000001878781E0-0x0000000187878274 
	
		// Events
		public static event DeviceConnectionChangeCallback OnDeviceConnectionChanged;
		private static event DeviceConnectionChangeCallback _onDeviceConnectionChanged;
	
		// Nested types
		public enum OutputDeviceType // TypeDefIndex: 55032
		{
			BuiltinSpeaker = 0,
			WiredDevice = 1,
			WirelessDevice = 2
		}
	
		public delegate void DeviceConnectionChangeCallback(bool isConnected, OutputDeviceType deviceType); // TypeDefIndex: 55033; 0x0000000187878484-0x000000018787848C
	
		private static class UnsafeNativeMethods // TypeDefIndex: 55034
		{
		}
	
		// Constructors
		public CriAtomOutputDeviceObserver() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		private void Awake() {} // 0x0000000185FAF3F0-0x0000000185FAF400
		private void OnDestroy() {} // 0x000000018787DD34-0x000000018787DDFC
		public override void CriInternalUpdate() {} // 0x00000001831C5680-0x00000001831C5690
		public override void CriInternalLateUpdate() {} // 0x000000018787DCA0-0x000000018787DD34
	}

	public class CriAtomRegion : CriMonoBehaviour // TypeDefIndex: 55036
	{
		// Fields
		private CriAtomEx3dRegion _region3dHn_k__BackingField; // 0x28
		internal List<CriAtomSourceBase> referringSources; // 0x30
		internal List<CriAtomListener> referringListeners; // 0x38
		internal List<CriAtomTransceiver> referringTransceivers; // 0x40
	
		// Properties
		public CriAtomEx3dRegion region3dHn { get; protected set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Constructors
		public CriAtomRegion() {} // 0x00000001878795A4-0x00000001878796B8
	
		// Methods
		private void Awake() {} // 0x00000001878792DC-0x00000001878792E4
		protected override void OnEnable() {} // 0x0000000187879584-0x00000001878795A4
		private void OnDestroy() {} // 0x000000018787957C-0x0000000187879584
		protected virtual void InternalInitialize() {} // 0x00000001878794F8-0x000000018787957C
		protected virtual void InternalFinalize() {} // 0x0000000187879340-0x00000001878794F8
		protected virtual void InitializeParameters() {} // 0x00000001878792E4-0x0000000187879340
		public override void CriInternalUpdate() {} // 0x0000000185492010-0x0000000185492020
		public override void CriInternalLateUpdate() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CriAtomServer : CriMonoBehaviour // TypeDefIndex: 55037
	{
		// Fields
		private static CriAtomServer _instance; // 0x00
		public Action<bool> onApplicationPausePreProcess; // 0x28
		public Action<bool> onApplicationPausePostProcess; // 0x30
		public static bool KeepPlayingSoundOnPause; // 0x08
		public static bool EnableAutoConsumePcmOutput; // 0x09
	
		// Properties
		public static CriAtomServer instance { get => default; } // 0x00000001878798C4-0x0000000187879918 
	
		// Constructors
		public CriAtomServer() {} // 0x0000000185FAF3F0-0x0000000185FAF400
		static CriAtomServer() {} // 0x0000000185F63360-0x0000000185F63460
	
		// Methods
		public static void CreateInstance() {} // 0x0000000184A82E80-0x0000000184A82F40
		public static void DestroyInstance() {} // 0x00000001878796B8-0x000000018787975C
		private void Awake() {} // 0x0000000185F09290-0x0000000185F09360
		protected override void OnEnable() {} // 0x0000000184A81D70-0x0000000184A81D80
		protected override void OnDisable() {} // 0x0000000187879764-0x000000018787981C
		public override void CriInternalUpdate() {} // 0x0000000184DCF220-0x0000000184DCF2A0
		public override void CriInternalLateUpdate() {} // 0x0000000185492010-0x0000000185492020
		private void ConsumePcmOutput() {} // 0x0000000185492010-0x0000000185492020
		private void OnApplicationPause(bool appPause) {} // 0x000000018787975C-0x0000000187879764
		private void ProcessApplicationPause(bool appPause) {} // 0x000000018787981C-0x00000001878798C4
	}

	public class CriAtomSource : CriAtomSourceBase // TypeDefIndex: 55039
	{
		// Fields
		private string _cueName; // 0xA0
		private string _cueSheet; // 0xA8
	
		// Properties
		public string cueName { get => default; set {} } // 0x000000018787A930-0x000000018787A970 0x000000018787A8BC-0x000000018787A930
		public string cueSheet { get => default; set {} } // 0x000000018787A980-0x000000018787A9E8 0x0000000181378230-0x0000000181378240
	
		// Nested types
		private sealed class _PlayAsync_d__11 : IEnumerator<object> // TypeDefIndex: 55038
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriAtomSource __4__this; // 0x20
			public string cueName; // 0x28
			private CriAtomExAcb _acb_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018774BD8C-0x000000018774BDA0 
			object IEnumerator.Current { get => default; } // 0x000000018787A890-0x000000018787A8BC 
	
			// Constructors
			public _PlayAsync_d__11() {} // Dummy constructor
			public _PlayAsync_d__11(int __1__state) {} // 0x0000000185FB0520-0x0000000185FB0530
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018646EBCC-0x000000018646EBE0
			private bool MoveNext() => default; // 0x000000018349D730-0x000000018349D740
			void IEnumerator.Reset() {} // 0x000000018787A970-0x000000018787A980
		}
	
		// Constructors
		public CriAtomSource() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override CriAtomExPlayback Play() => default; // 0x0000000185492010-0x0000000185492020
		protected override CriAtomExAcb GetAcb() => default; // 0x000000018787F6D8-0x000000018787F7D0
		protected override void PlayOnStart() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator PlayAsync(string cueName) => default; // 0x000000018787F7D0-0x000000018787F81C
	}

	public abstract class CriAtomSourceBase : CriMonoBehaviour // TypeDefIndex: 55041
	{
		// Fields
		private CriAtomExPlayer _player_k__BackingField; // 0x28
		private CriAtomEx3dSource _source_k__BackingField; // 0x30
		protected bool initialized; // 0x38
		protected Vector3 lastPosition; // 0x3C
		protected bool hasValidPosition; // 0x48
		private CriAtomRegion currentRegion; // 0x50
		private CriAtomListener currentListener; // 0x58
		private bool _playOnStart; // 0x60
		private CriAtomRegion _regionOnStart; // 0x68
		private CriAtomListener _listenerOnStart; // 0x70
		private bool _use3dPositioning; // 0x78
		private bool _freezeOrientation; // 0x79
		private bool _loop; // 0x7A
		private float _volume; // 0x7C
		private float _pitch; // 0x80
		private bool _androidUseLowLatencyVoicePool; // 0x84
		private bool need_to_player_update_all; // 0x85
		private bool _use3dRandomization; // 0x86
		private uint _randomPositionListMaxLength; // 0x88
		private CriAtomEx.Randomize3dConfig randomize3dConfig; // 0x90
	
		// Properties
		public CriAtomExPlayer player { get; protected set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public CriAtomEx3dSource source { get; protected set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public bool playOnStart { get; set; } // 0x000000018386C570-0x000000018386C580 0x000000018386C580-0x000000018386C590
		public bool use3dPositioning { get; set; } // 0x0000000185FB0DA0-0x0000000185FB0DB0 0x000000018787A754-0x000000018787A78C
		public bool freezeOrientation { get; set; } // 0x0000000185FB2E50-0x0000000185FB2E60 0x0000000185FB2EB0-0x0000000185FB2EC0
		public bool use3dRandomization { get; set; } // 0x0000000185FB2E80-0x0000000185FB2E90 0x000000018787A78C-0x000000018787A85C
		public uint randomPositionListMaxLength { get; set; } // 0x00000001834A1F30-0x00000001834A1F40 0x000000018787A4C4-0x000000018787A534
		public CriAtomRegion region3d { get; set; } // 0x0000000181460F60-0x0000000181460F70 0x000000018787A534-0x000000018787A724
		public CriAtomListener listener { get; set; } // 0x00000001813F1630-0x00000001813F1640 0x000000018787A368-0x000000018787A42C
		public CriAtomRegion regionOnStart { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public CriAtomListener listenerOnStart { get; set; } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public bool loop { get; set; } // 0x0000000185FB2E60-0x0000000185FB2E70 0x0000000185FB2EC0-0x0000000185FB2ED0
		public float volume { get; set; } // 0x0000000185FB2E90-0x0000000185FB2EA0 0x000000018787A85C-0x000000018787A890
		public float pitch { get; set; } // 0x0000000185FB2E70-0x0000000185FB2E80 0x000000018787A48C-0x000000018787A4C4
		public float pan3dAngle { get; set; } // 0x000000018787A268-0x000000018787A290 0x000000018787A42C-0x000000018787A45C
		public float pan3dDistance { get; set; } // 0x000000018787A290-0x000000018787A2B8 0x000000018787A45C-0x000000018787A48C
		public int startTime { get; set; } // 0x000000018787A2B8-0x000000018787A2E0 0x000000018787A724-0x000000018787A754
		public long time { get; } // 0x000000018787A308-0x000000018787A32C 
		public Status status { get; } // 0x000000018787A2E0-0x000000018787A308 
		public bool attenuationDistanceSetting { get; set; } // 0x000000018787A244-0x000000018787A268 0x000000018787A32C-0x000000018787A368
		public bool androidUseLowLatencyVoicePool { get; set; } // 0x0000000185FB2E40-0x0000000185FB2E50 0x0000000185FB2EA0-0x0000000185FB2EB0
	
		// Nested types
		public enum Status // TypeDefIndex: 55040
		{
			Stop = 0,
			Prep = 1,
			Playing = 2,
			PlayEnd = 3,
			Error = 4
		}
	
		// Constructors
		protected CriAtomSourceBase() {} // 0x000000018787A1E8-0x000000018787A244
	
		// Methods
		protected void SetNeedToPlayerUpdateAll() {} // 0x0000000185FB2E30-0x0000000185FB2E40
		protected virtual void InternalInitialize() {} // 0x0000000187879A54-0x0000000187879B2C
		protected virtual void InternalFinalize() {} // 0x00000001878799BC-0x0000000187879A54
		private void Awake() {} // 0x000000018787994C-0x0000000187879954
		protected override void OnEnable() {} // 0x0000000187879BB0-0x0000000187879BDC
		private void OnDestroy() {} // 0x0000000187879BA8-0x0000000187879BB0
		protected bool SetInitialSourcePosition() => default; // 0x0000000187879ED8-0x0000000187879F60
		protected virtual void SetInitialParameters() {} // 0x0000000187879E20-0x0000000187879ED8
		protected virtual void UpdatePosition() {} // 0x000000018787A020-0x000000018787A1E8
		private void Start() {} // 0x0000000187879F60-0x000000018787A00C
		public override void CriInternalUpdate() {} // 0x0000000185492010-0x0000000185492020
		public override void CriInternalLateUpdate() {} // 0x0000000187879954-0x000000018787999C
		public abstract CriAtomExPlayback Play();
		protected abstract CriAtomExAcb GetAcb();
		protected abstract void PlayOnStart();
		public CriAtomExPlayback Play(string cueName) => default; // 0x0000000187879C0C-0x0000000187879C80
		public CriAtomExPlayback Play(int cueId) => default; // 0x0000000187879C80-0x0000000187879CF0
		protected CriAtomExPlayback InternalPlayCue() => default; // 0x0000000187879B2C-0x0000000187879B84
		public void Stop() {} // 0x000000018787A00C-0x000000018787A020
		public void Pause(bool sw) {} // 0x0000000187879BDC-0x0000000187879C0C
		public bool IsPaused() => default; // 0x0000000187879B84-0x0000000187879BA8
		public void SetBusSendLevel(string busName, float level) {} // 0x0000000187879DF0-0x0000000187879E20
		public void SetBusSendLevel(int busId, float level) {} // 0x0000000187879DC0-0x0000000187879DF0
		public void SetBusSendLevelOffset(string busName, float levelOffset) {} // 0x0000000187879D90-0x0000000187879DC0
		public void SetBusSendLevelOffset(int busId, float levelOffset) {} // 0x0000000187879D60-0x0000000187879D90
		public void SetAisacControl(string controlName, float value) {} // 0x0000000187879CF0-0x0000000187879D20
		public void SetAisac(string controlName, float value) {} // 0x0000000187879D58-0x0000000187879D60
		public void SetAisacControl(uint controlId, float value) {} // 0x0000000187879D20-0x0000000187879D50
		public void SetAisac(uint controlId, float value) {} // 0x0000000187879D50-0x0000000187879D58
		public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer) {} // 0x0000000187879918-0x000000018787994C
		public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer) {} // 0x000000018787999C-0x00000001878799BC
	}

	public class CriAtomTransceiver : CriMonoBehaviour // TypeDefIndex: 55043
	{
		// Fields
		private CriAtomEx3dTransceiver _transceiverHn_k__BackingField; // 0x28
		private Vector3 _inputPos_k__BackingField; // 0x30
		private Vector3 _inputFront_k__BackingField; // 0x3C
		private Vector3 _inputUp_k__BackingField; // 0x48
		private CriAtomRegion regionOnStart; // 0x58
		private bool useDedicatedInput; // 0x60
		private GameObject dedicatedInput; // 0x68
		private float outputVolume; // 0x70
		private float directAudioRadius; // 0x74
		private float crossFadeDistance; // 0x78
		private float coneInsideAngle; // 0x7C
		private float coneOutsideAngle; // 0x80
		private float coneOutsideVolume; // 0x84
		private float transceiverRadius; // 0x88
		private float interiorDistance; // 0x8C
		public float minAttenuation; // 0x90
		public float maxAttenuation; // 0x94
		private string globalAisacName; // 0x98
		private float maxAngleAisacDelta; // 0xA0
		private string distanceAisacControlId; // 0xA8
		private string listenerAzimuthAisacControlId; // 0xB0
		private string listenerElevationAisacControlId; // 0xB8
		private string outputAzimuthAisacControlId; // 0xC0
		private string outputElevationAisacControlId; // 0xC8
		[NonSerialized]
		public bool inspectorAisacSettingFoldout; // 0xD0
		private bool isInitialized; // 0xD1
		private bool dedicatedInputNotSetWarned; // 0xD2
		private CriAtomRegion currentRegion; // 0xD8
	
		// Properties
		public CriAtomEx3dTransceiver transceiverHn { get; protected set; } // 0x0000000185FB2ED0-0x0000000185FB2EF0 0x0000000185FB2F10-0x0000000185FB2F20
		public Vector3 inputPos { get; private set; } // 0x0000000185FB1570-0x0000000185FB1590 0x0000000185FB1590-0x0000000185FB15A0
		public Vector3 inputFront { get; private set; } // 0x0000000185FB02F0-0x0000000185FB0300 0x000000018787B4AC-0x000000018787B684
		public Vector3 inputUp { get; private set; } // 0x000000018787B040-0x000000018787B048 0x000000018787B1F0-0x000000018787B254
		public CriAtomRegion region3d { get => default; set {} } // 0x000000018787B1D0-0x000000018787B1F0 0x000000018787B1C8-0x000000018787B1D0
	
		// Nested types
		private delegate void SetControlIdMethod(ushort id); // TypeDefIndex: 55042; 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Constructors
		public CriAtomTransceiver() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		private void Awake() {} // 0x000000018787B13C-0x000000018787B1C8
		private void Start() {} // 0x000000018787B0C4-0x000000018787B13C
		protected override void OnEnable() {} // 0x000000018787B050-0x000000018787B0C4
		private void OnDestroy() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void InternalInitialize() {} // 0x000000018787B048-0x000000018787B050
		protected virtual void InternalFinalize() {} // 0x000000018787A9E8-0x000000018787AD20
		protected virtual void InitializeParameters() {} // 0x000000018787AD20-0x000000018787B040
		public override void CriInternalUpdate() {} // 0x000000018787B254-0x000000018787B358
		public override void CriInternalLateUpdate() {} // 0x000000018787B358-0x000000018787B4AC
		private void ApplyCurrentPosition() {} // 0x000000018787E980-0x000000018787EA48
		private void ApplyParameters() {} // 0x00000001833EEC70-0x00000001833EEC80
		private void TrySetAisacControlId(string strId, SetControlIdMethod callback) {} // 0x000000018787E908-0x000000018787E980
	}

	public class CriStructMemory<Type> : IDisposable // TypeDefIndex: 55044
	{
		// Fields
		private byte[] _bytes_k__BackingField;
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

	public static class CriAtomEx // TypeDefIndex: 55074
	{
		// Fields
		public const uint InvalidAisacControlId = 4294967295; // Metadata: 0x0207BAE8
		public static readonly Dictionary<Randomize3dCalcType, Randomize3dParamType[]> randomize3dParamTable; // 0x00
	
		// Events
		public static event CueLinkCbFunc OnCueLinkCallback;
	
		// Nested types
		public enum CharacterEncoding // TypeDefIndex: 55045
		{
			Utf8 = 0,
			Sjis = 1
		}
	
		public enum SoundRendererType // TypeDefIndex: 55046
		{
			Default = 0,
			Native = 1,
			Hw1 = 1,
			Asr = 2,
			Haptic = 3,
			Hw2 = 9
		}
	
		public enum VoiceAllocationMethod // TypeDefIndex: 55047
		{
			Once = 0,
			Retry = 1
		}
	
		public enum BiquadFilterType // TypeDefIndex: 55048
		{
			Off = 0,
			LowPass = 1,
			HighPass = 2,
			Notch = 3,
			LowShelf = 4,
			HighShelf = 5,
			Peaking = 6
		}
	
		public enum ResumeMode // TypeDefIndex: 55049
		{
			AllPlayback = 0,
			PausedPlayback = 1,
			PreparedPlayback = 2
		}
	
		public enum PanType // TypeDefIndex: 55050
		{
			Unknown = -1,
			Pan3d = 0,
			Pos3d = 1,
			Auto = 2
		}
	
		public enum VoiceControlMethod // TypeDefIndex: 55051
		{
			PreferLast = 0,
			PreferFirst = 1
		}
	
		public enum Parameter // TypeDefIndex: 55052
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
	
		public enum Speaker // TypeDefIndex: 55053
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
	
		public enum Format : uint // TypeDefIndex: 55054
		{
			ADX = 1,
			HCA = 3,
			HCA_MX = 4,
			WAVE = 5,
			RAW_PCM = 6,
			AUDIO_BUFFER = 9
		}
	
		private enum SpeakerSystem : uint // TypeDefIndex: 55055
		{
			Surround_5_1 = 0,
			Surround_7_1 = 1
		}
	
		public struct SpeakerAngles6ch // TypeDefIndex: 55056
		{
			// Fields
			public float frontLeft; // 0x00
			public float frontRight; // 0x04
			public float frontCenter; // 0x08
			public float lowFrequency; // 0x0C
			public float surroundLeft; // 0x10
			public float surroundRight; // 0x14
	
			// Methods
			public static SpeakerAngles6ch Default() => default; // 0x0000000187876664-0x00000001878766B4
		}
	
		public struct SpeakerAngles8ch // TypeDefIndex: 55057
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
			public static SpeakerAngles8ch Default() => default; // 0x00000001878766B4-0x0000000187876704
		}
	
		public struct FormatInfo // TypeDefIndex: 55058
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
	
		public struct AisacControlInfo // TypeDefIndex: 55059
		{
			// Fields
			public readonly string name; // 0x00
			public uint id; // 0x08
	
			// Constructors
			public AisacControlInfo(byte[] data, int startIndex) {
				name = default;
				id = default;
			} // 0x0000000187876704-0x0000000187876754
		}
	
		public enum Randomize3dCalcType // TypeDefIndex: 55060
		{
			None = -1,
			Rectangle = 0,
			Cuboid = 1,
			Circle = 2,
			Cylinder = 3,
			Sphere = 4,
			List = 6
		}
	
		public enum Randomize3dParamType // TypeDefIndex: 55061
		{
			None = 0,
			Width = 1,
			Depth = 2,
			Height = 3,
			Radius = 4
		}
	
		[Serializable]
		public struct Randomize3dConfig // TypeDefIndex: 55062
		{
			// Fields
			public const int NumOfCalcParams = 3; // Metadata: 0x0207BB49
			private bool followsOriginalSource; // 0x00
			private Randomize3dCalcType calculationType; // 0x04
			private float[] calculationParameters; // 0x08
	
			// Properties
			public bool FollowsOriginalSource { get => default; } // 0x0000000187876754-0x00000001878767A4 
			public Randomize3dCalcType CalculationType { get => default; } // 0x0000000187875D4C-0x0000000187875D98 
			public float CalculationParameter1 { get => default; } // 0x0000000187876824-0x000000018787682C 
			public float CalculationParameter2 { get => default; } // 0x00000001878776F4-0x00000001878776FC 
			public float CalculationParameter3 { get => default; } // 0x0000000187876304-0x0000000187876368 
	
			// Constructors
			internal Randomize3dConfig(byte[] data, int startIndex) : this() {
				followsOriginalSource = default;
				calculationType = default;
				calculationParameters = default;
			} // 0x0000000187876368-0x00000001878763C0
			public Randomize3dConfig(bool followsOriginalSource, Randomize3dCalcType calculationType, float param1 = 0f /* Metadata: 0x0207BB39 */, float param2 = 0f /* Metadata: 0x0207BB3D */, float param3 = 0f /* Metadata: 0x0207BB41 */) : this() {
				this.followsOriginalSource = default;
				this.calculationType = default;
				calculationParameters = default;
			} // 0x00000001878762A8-0x0000000187876304
			public Randomize3dConfig(int dummy) : this() {
				followsOriginalSource = default;
				calculationType = default;
				calculationParameters = default;
			} // 0x00000001878767E4-0x0000000187876824
	
			// Methods
			public void ClearCalcParams(float initVal = 0f /* Metadata: 0x0207BB45 */) {} // 0x0000000187875E24-0x0000000187875E8C
			public bool GetParamByType(Randomize3dParamType paramType, ref float paramVal) => default; // 0x0000000187875CFC-0x0000000187875D4C
			public bool SetParamByType(Randomize3dParamType paramType, float paramVal) => default; // 0x0000000187875D98-0x0000000187875DD8
		}
	
		public struct CuePos3dInfo // TypeDefIndex: 55063
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
			} // 0x0000000187875CA4-0x0000000187875CFC
		}
	
		public struct GameVariableInfo // TypeDefIndex: 55064
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
			} // 0x000000018787619C-0x00000001878761DC
			public GameVariableInfo(string name, uint id, float gameValue) {
				this.name = default;
				this.id = default;
				this.gameValue = default;
			} // 0x0000000187875EF8-0x00000001878760C8
		}
	
		public enum CueType // TypeDefIndex: 55065
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
	
		public struct CueInfo // TypeDefIndex: 55066
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
			} // 0x0000000187876114-0x000000018787615C
		}
	
		public struct WaveformInfo // TypeDefIndex: 55067
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
			} // 0x00000001878760C8-0x0000000187876114
		}
	
		public struct AisacInfo // TypeDefIndex: 55068
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
			} // 0x000000018787645C-0x00000001878764B4
		}
	
		public struct PerformanceInfo // TypeDefIndex: 55069
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
	
		public struct ResourceUsage // TypeDefIndex: 55070
		{
			// Fields
			public uint useCount; // 0x00
			public uint limit; // 0x04
		}
	
		public struct NativeVector // TypeDefIndex: 55071
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
			} // 0x0000000187876400-0x000000018787645C
			public NativeVector(Vector3 vector) {
				x = default;
				y = default;
				z = default;
			} // 0x00000001850F92B0-0x00000001850F9300
		}
	
		public struct CueLinkInfo // TypeDefIndex: 55072
		{
			// Fields
			public IntPtr nativePlayerHn; // 0x00
			public uint basePlaybackId; // 0x08
			public uint targetPlaybackId; // 0x0C
			public int cueLinkType; // 0x10
		}
	
		public delegate void CueLinkCbFunc(ref CueLinkInfo info); // TypeDefIndex: 55073; 0x00000001878761DC-0x0000000187876228
	
		// Constructors
		static CriAtomEx() {} // 0x00000001872076D8-0x00000001872076F4
	
		// Methods
		public static void SetSpeakerAngle(SpeakerAngles6ch speakerAngle) {} // 0x0000000187876268-0x00000001878762A8
		public static void SetSpeakerAngle(SpeakerAngles8ch speakerAngle) {} // 0x00000001878767A4-0x00000001878767E4
		public static void SetVirtualSpeakerAngle(SpeakerAngles6ch speakerAngle) {} // 0x000000018787656C-0x0000000187876614
		public static void SetVirtualSpeakerAngle(SpeakerAngles8ch speakerAngle) {} // 0x0000000187876228-0x0000000187876268
		public static void ControlVirtualSpeakerSetting(bool sw) {} // 0x000000018787615C-0x000000018787619C
		public static void RegisterAcf(CriFsBinder binder, string acfPath) {} // 0x0000000185492010-0x0000000185492020
		public static void RegisterAcf(IntPtr acfData, int dataSize) {} // 0x00000001840A27C0-0x00000001840A27D0
		public static void RegisterAcf(byte[] acfData) {} // 0x00000001814A81B0-0x00000001814A81C0
		public static void UnregisterAcf() {} // 0x0000000185492010-0x0000000185492020
		public static string GetAppliedDspBusSnapshotName() => default; // 0x0000000187875DD8-0x0000000187875E24
		public static void AttachDspBusSetting(string settingName) {} // 0x0000000187876F04-0x0000000187876FC8
		public static void DetachDspBusSetting() {} // 0x0000000187876DB8-0x0000000187876E58
		public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms) {} // 0x0000000187876E58-0x0000000187876F04
		public static int GetNumGameVariables() => default; // 0x00000001878772D4-0x000000018787733C
		public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info) {
			info = default;
			return default;
		} // 0x00000001878769B0-0x0000000187876A58
		public static float GetGameVariable(uint game_variable_id) => default; // 0x0000000187876AD0-0x0000000187876B38
		public static float GetGameVariable(string game_variable_name) => default; // 0x000000018787695C-0x00000001878769B0
		public static void SetGameVariable(uint game_variable_id, float game_variable_value) {} // 0x0000000187876BB0-0x0000000187876C18
		public static void SetGameVariable(string game_variable_name, float game_variable_value) {} // 0x0000000187876D24-0x0000000187876D50
		public static void SetRandomSeed(uint seed) {} // 0x0000000187876C98-0x0000000187876D24
		public static void ResetPerformanceMonitor() {} // 0x0000000187876C18-0x0000000187876C44
		public static void GetPerformanceInfo(out PerformanceInfo info) {
			info = default;
		} // 0x0000000187876C44-0x0000000187876C98
		public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index) {} // 0x0000000187876FC8-0x0000000187877004
		public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name) {} // 0x0000000187877004-0x000000018787705C
		public static void Lock() {} // 0x00000001844CED50-0x00000001844CEDD0
		public static void Unlock() {} // 0x0000000187876D50-0x0000000187876DB8
		public static void SetOutputAudioDevice_PC(string deviceId) {} // 0x000000018787726C-0x00000001878772D4
		public static bool LoadAudioDeviceList_PC() => default; // 0x000000018787757C-0x00000001878775E4
		public static int GetNumAudioDevices_PC() => default; // 0x0000000187877504-0x000000018787757C
		public static string GetAudioDeviceName_PC(int index) => default; // 0x000000018787682C-0x00000001878768B0
		public static void SetOutputAudioDevice_PC(int index) {} // 0x00000001878768B0-0x000000018787695C
		public static void SetOutputVolume_VITA(float volume) {} // 0x000000018787705C-0x00000001878770E0
		public static bool IsBgmPortAcquired_VITA() => default; // 0x00000001878770E0-0x0000000187877164
		public static bool IsSoundStopped_IOS() => default; // 0x0000000187877164-0x00000001878771E8
		public static void EnableAudioSessionRestoration_IOS(bool flag) {} // 0x00000001878771E8-0x000000018787726C
		public static void EnableBusSendOffsetWhenLevelNotExist(bool enable) {} // 0x0000000187876A58-0x0000000187876AD0
		private static extern bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize); // 0x0000000187876B38-0x0000000187876BB0
		private static extern void criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize); // 0x0000000187877668-0x00000001878776F4
		private static extern void criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize); // 0x00000001878775E4-0x0000000187877668
		private static extern void criAtomEx_UnregisterAcf(); // 0x0000000187877494-0x0000000187877504
		private static extern void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize); // 0x000000018787742C-0x0000000187877494
		private static extern void criAtomEx_DetachDspBusSetting(); // 0x00000001878773B4-0x000000018787742C
		private static extern void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms); // 0x000000018787733C-0x00000001878773B4
		private static extern IntPtr criAtomEx_GetAppliedDspBusSnapshotName(); // 0x0000000185A614B0-0x0000000185A61720
		private static extern int criAtomEx_GetNumGameVariables(); // 0x0000000185FB2F70-0x0000000185FB2FA0
		private static extern bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info); // 0x0000000185FB2FA0-0x0000000185FB2FE0
		private static extern float criAtomEx_GetGameVariableById(uint game_variable_id); // 0x000000018786846C-0x0000000187868514
		private static extern float criAtomEx_GetGameVariableByName(string game_variable_name); // 0x00000001835E3010-0x00000001835E3020
		private static extern void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value); // 0x000000018357CBC0-0x000000018357CBD0
		private static extern void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value); // 0x000000018787E6F0-0x000000018787E71C
		private static extern void criAtomEx_SetRandomSeed(uint seed); // 0x000000018787E71C-0x000000018787E748
		private static extern void criAtomEx_Lock(); // 0x000000018787E748-0x000000018787E774
		private static extern void criAtomEx_Unlock(); // 0x000000018787E58C-0x000000018787E690
		private static extern void criAtom_ResetPerformanceMonitor(); // 0x000000018787E4C0-0x000000018787E58C
		private static extern void criAtom_GetPerformanceInfo(out PerformanceInfo info); // 0x000000018787E690-0x000000018787E6F0
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index); // 0x000000018787E0E4-0x000000018787E11C
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name); // 0x000000018787E11C-0x000000018787E2E8
		private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array); // 0x000000018787E2E8-0x000000018787E4C0
		private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array); // 0x000000018787DB48-0x000000018787DCA0
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array); // 0x000000018787DE7C-0x000000018787DF38
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array); // 0x000000018787DF38-0x000000018787DF5C
		private static extern void criAtomEx_ControlVirtualSpeakerSetting(bool sw); // 0x000000018787D7F0-0x000000018787DAC8
		private static extern void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(bool enable); // 0x00000001878801F0-0x00000001878803AC
		private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType soundRendererType, string deviceId); // 0x0000000187868608-0x00000001878686FC
		private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType type, IntPtr deviceId); // 0x0000000185FB2F40-0x0000000185FB2F50
		private static extern bool criAtomUnity_LoadAudioDeviceList_PC(); // 0x0000000185FB2F50-0x0000000185FB2F70
		private static extern int criAtomUnity_GetNumAudioDevices_PC(); // 0x0000000187868BC8-0x0000000187868C9C
		private static extern IntPtr criAtomUnity_GetAudioDeviceName_PC(int index); // 0x00000001833EEC70-0x00000001833EEC80
		private static extern IntPtr criAtomUnity_GetAudioDeviceId_PC(int index); // 0x000000018787DAC8-0x000000018787DB48
	}

	public static class CriAtomExCategory // TypeDefIndex: 55088
	{
		// Nested types
		public enum ReactType // TypeDefIndex: 55075
		{
			Ducker = 0,
			AisacModulationTrigger = 1
		}
	
		public enum ReactDuckerTargetType // TypeDefIndex: 55076
		{
			Volume = 0,
			AisacControlValue = 1
		}
	
		public enum ReactDuckerCurveType // TypeDefIndex: 55077
		{
			Linear = 0,
			Square = 1,
			SquareReverse = 2,
			SCurve = 3,
			FlatAtHalf = 4
		}
	
		public struct ReactFadeParameter // TypeDefIndex: 55078
		{
			// Fields
			public ReactDuckerCurveType curveType; // 0x00
			public float curveStrength; // 0x04
			public ushort fadeTimeMs; // 0x08
		}
	
		public enum ReactHoldType // TypeDefIndex: 55079
		{
			WhilePlaying = 0,
			FixedTime = 1
		}
	
		public struct ReactDuckerParameter // TypeDefIndex: 55083
		{
			// Fields
			public Target target; // 0x00
			public ReactDuckerTargetType targetType; // 0x08
			public ReactFadeParameter entry; // 0x0C
			public ReactFadeParameter exit; // 0x18
			public ReactHoldType holdType; // 0x24
			public ushort holdTimeMs; // 0x28
	
			// Nested types
			public struct Volume // TypeDefIndex: 55080
			{
				// Fields
				public float level; // 0x00
			}
	
			public struct AisacControl // TypeDefIndex: 55081
			{
				// Fields
				public uint id; // 0x00
				public float value; // 0x04
			}
	
			public struct Target // TypeDefIndex: 55082
			{
				// Fields
				public CriWare.CriAtomExCategory.ReactDuckerParameter.Volume volume; // 0x00
				public AisacControl aisacControl; // 0x00
			}
		}
	
		public struct ReactAisacModulationParameter // TypeDefIndex: 55084
		{
			// Fields
			private int _enableDecrementAisacModulationKey; // 0x00
			public uint decrementAisacModulationKey; // 0x04
			private int _enableIncrementAisacModulationKey; // 0x08
			public uint incrementAisacModulationKey; // 0x0C
	
			// Properties
			public bool enableDecrementAisacModulationKey { get => default; } // 0x0000000187872820-0x0000000187872828 
			public bool enableIncrementAisacModulationKey { get => default; } // 0x0000000187872818-0x0000000187872820 
		}
	
		public struct ReactParameter // TypeDefIndex: 55086
		{
			// Fields
			public Parameter parameter; // 0x00
			public ReactType type; // 0x2C
			public bool enablePausingCue; // 0x30
	
			// Nested types
			public struct Parameter // TypeDefIndex: 55085
			{
				// Fields
				public ReactDuckerParameter ducker; // 0x00
				public ReactAisacModulationParameter aisacModulation; // 0x00
			}
		}
	
		public enum ReactStatus // TypeDefIndex: 55087
		{
			Stop = 0,
			FadeOut = 1,
			Hold = 2,
			FadeIn = 3,
			Error = 4
		}
	
		// Methods
		public static void SetVolume(string name, float volume) {} // 0x0000000187872794-0x000000018787279C
		public static void SetVolume(int id, float volume) {} // 0x000000018787279C-0x00000001878727A4
		public static float GetVolume(string name) => default; // 0x00000001878727D4-0x00000001878727DC
		public static float GetVolume(int id) => default; // 0x00000001878727DC-0x00000001878727E4
		public static void Mute(string name, bool mute) {} // 0x00000001878727AC-0x00000001878727B4
		public static void Mute(int id, bool mute) {} // 0x00000001878727A4-0x00000001878727AC
		public static bool IsMuted(string name) => default; // 0x0000000187872830-0x0000000187872838
		public static bool IsMuted(int id) => default; // 0x0000000187872828-0x0000000187872830
		public static void Solo(string name, bool solo, float muteVolume) {} // 0x00000001878727CC-0x00000001878727D4
		public static void Solo(int id, bool solo, float muteVolume) {} // 0x00000001878727C4-0x00000001878727CC
		public static bool IsSoloed(string name) => default; // 0x00000001878727E4-0x00000001878727EC
		public static bool IsSoloed(int id) => default; // 0x00000001878727EC-0x00000001878727F4
		public static void Pause(string name, bool pause) {} // 0x00000001878727B4-0x00000001878727BC
		public static void Pause(int id, bool pause) {} // 0x00000001878727BC-0x00000001878727C4
		public static bool IsPaused(string name) => default; // 0x00000001878727FC-0x0000000187872804
		public static bool IsPaused(int id) => default; // 0x00000001878727FC-0x0000000187872804
		public static void SetAisacControl(string name, string controlName, float value) {} // 0x00000001878727F4-0x00000001878727FC
		public static void SetAisac(string name, string controlName, float value) {} // 0x00000001878727F4-0x00000001878727FC
		public static void SetAisacControl(int id, int controlId, float value) {} // 0x0000000187872804-0x0000000187872818
		public static void SetAisac(int id, int controlId, float value) {} // 0x0000000187872784-0x000000018787278C
		public static void SetReactParameter(string name, ReactParameter parameter) {} // 0x0000000187872398-0x0000000187872584
		public static bool GetReactParameter(string name, out ReactParameter parameter) {
			parameter = default;
			return default;
		} // 0x0000000187872584-0x000000018787277C
		public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
			aisacInfo = default;
			return default;
		} // 0x000000018787277C-0x0000000187872784
		public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
			aisacInfo = default;
			return default;
		} // 0x000000018787278C-0x0000000187872794
		public static bool GetCurrentAisacControlValue(string categoryName, string aisacControlName, out float controlValue) {
			controlValue = default;
			return default;
		} // 0x00000001878732A0-0x00000001878732F0
		public static ReactStatus GetReactStatus(string reactName) => default; // 0x0000000187872BEC-0x0000000187872C40
		private static extern void criAtomExCategory_SetVolumeByName(string name, float volume); // 0x0000000187873264-0x00000001878732A0
		private static extern float criAtomExCategory_GetVolumeByName(string name); // 0x0000000187872BC0-0x0000000187872BEC
		private static extern void criAtomExCategory_SetVolumeById(int id, float volume); // 0x0000000187872E80-0x0000000187872F04
		private static extern float criAtomExCategory_GetVolumeById(int id); // 0x0000000187872C40-0x0000000187872CB8
		private static extern void criAtomExCategory_MuteById(int id, bool mute); // 0x0000000187872F04-0x0000000187872F9C
		private static extern bool criAtomExCategory_IsMutedById(int id); // 0x0000000187872CB8-0x0000000187872D58
		private static extern void criAtomExCategory_MuteByName(string name, bool mute); // 0x00000001878732F0-0x0000000187873338
		private static extern bool criAtomExCategory_IsMutedByName(string name); // 0x0000000187872DEC-0x0000000187872E24
		private static extern void criAtomExCategory_SoloById(int id, bool solo, float volume); // 0x0000000187873338-0x0000000187873398
		private static extern bool criAtomExCategory_IsSoloedById(int id); // 0x0000000187872E24-0x0000000187872E80
		private static extern void criAtomExCategory_SoloByName(string name, bool solo, float volume); // 0x0000000187872F9C-0x0000000187873020
		private static extern bool criAtomExCategory_IsSoloedByName(string name); // 0x0000000187872D58-0x0000000187872D90
		private static extern void criAtomExCategory_PauseById(int id, bool pause); // 0x0000000187873020-0x0000000187873078
		private static extern bool criAtomExCategory_IsPausedById(int id); // 0x0000000187872D90-0x0000000187872DEC
		private static extern void criAtomExCategory_PauseByName(string name, bool pause); // 0x0000000187873078-0x00000001878730C4
		private static extern bool criAtomExCategory_IsPausedByName(string name); // 0x00000001878730C4-0x0000000187873138
		private static extern void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value); // 0x0000000187873138-0x0000000187873264
		private static extern void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value); // 0x0000000187872A48-0x0000000187872B68
		private static extern void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter); // 0x0000000187872838-0x00000001878728CC
		private static extern bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter); // 0x00000001878728CC-0x0000000187872980
		private static extern bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo); // 0x0000000187872980-0x0000000187872A48
		private static extern bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo); // 0x0000000187872B68-0x0000000187872BC0
		private static extern bool criAtomExCategory_GetCurrentAisacControlValueByName(string category_name, string aisac_control_name, out float control_value); // 0x000000018787E774-0x000000018787E77C
		private static extern ReactStatus criAtomExCategory_GetReactStatus(string react_name); // 0x000000018787E77C-0x000000018787E784
	}

	public static class CriAtomExSequencer // TypeDefIndex: 55092
	{
		// Events
		public static event EventCallback OnCallback;
	
		// Nested types
		public struct CriAtomExSequenceEventInfo // TypeDefIndex: 55089
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
	
		public delegate void EventCbFunc(string eventParamsString); // TypeDefIndex: 55090; 0x0000000187875C9C-0x0000000187875CA4
	
		public delegate void EventCallback(ref CriAtomExSequenceEventInfo criAtomExSequenceInfo); // TypeDefIndex: 55091; 0x0000000185A264E0-0x0000000185A26510
	
		// Methods
		public static void SetEventCallback(EventCbFunc func, string separator = "\t" /* Metadata: 0x0207BB63 */) {} // 0x00000001872076D8-0x00000001872076F4
	}

	public static class CriAtomExBeatSync // TypeDefIndex: 55095
	{
		// Events
		public static event CbFunc OnCallback;
	
		// Nested types
		public struct Info // TypeDefIndex: 55093
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
	
		public delegate void CbFunc(ref Info info); // TypeDefIndex: 55094; 0x0000000187872390-0x0000000187872398
	
		// Methods
		public static void SetCallback(CbFunc func) {} // 0x00000001872076D8-0x00000001872076F4
	}

	public class CriAtomExAsr // TypeDefIndex: 55098
	{
		// Nested types
		private struct BusAnalyzerConfig // TypeDefIndex: 55096
		{
			// Fields
			public int interval; // 0x00
			public int peakHoldTime; // 0x04
		}
	
		public struct BusAnalyzerInfo // TypeDefIndex: 55097
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
			} // 0x0000000187871008-0x0000000187871028
		}
	
		// Constructors
		public CriAtomExAsr() {} // 0x00000001878686FC-0x0000000187868920
	
		// Methods
		public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime) {} // 0x0000000187870FDC-0x0000000187871008
		public static void AttachBusAnalyzer(int interval, int peakHoldTime) {} // 0x0000000187871028-0x0000000187871030
		public static void DetachBusAnalyzer(string busName) {} // 0x0000000187871030-0x0000000187871050
		public static void DetachBusAnalyzer() {} // 0x000000018787120C-0x00000001878713C0
		public static void GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info) {
			info = default;
		} // 0x0000000187871050-0x000000018787120C
		public static void GetBusAnalyzerInfo(int busId, out BusAnalyzerInfo info) {
			info = default;
		} // 0x0000000187871408-0x0000000187871410
		public static void SetBusVolume(string busName, float volume) {} // 0x0000000187871410-0x0000000187871418
		public static void SetBusVolume(int busId, float volume) {} // 0x0000000187871400-0x0000000187871408
		public static void SetBusSendLevel(string busName, string sendTo, float level) {} // 0x00000001878713F8-0x0000000187871400
		public static void SetBusSendLevel(int busId, int sendTo, float level) {} // 0x00000001878713E8-0x00000001878713F8
		public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix) {} // 0x00000001878713D8-0x00000001878713E8
		public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, float[] matrix) {} // 0x0000000187871418-0x0000000187871420
		public static void SetEffectBypass(string busName, string effectName, bool bypass) {} // 0x0000000187871420-0x0000000187871458
		public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue) {} // 0x00000001878713C8-0x00000001878713D0
		public static float GetEffectParameter(string busName, string effectName, uint parameterIndex) => default; // 0x00000001878713D0-0x00000001878713D8
		public static bool RegisterEffectInterface(IntPtr afx_interface) => default; // 0x0000000187871458-0x0000000187871460
		public static void UnregisterEffectInterface(IntPtr afx_interface) {} // 0x00000001878713C0-0x00000001878713C8
		public static void GetBusVolume(string busName, out float volume) {
			volume = default;
		} // 0x00000001813AE580-0x00000001813AE590
		public static int GetPcmOutput(int outputChannels, int outputSamples, float[][] buffer) => default; // 0x00000001813AE580-0x00000001813AE590
		public static int GetNumBufferedPcmOutputSamples() => default; // 0x0000000185492010-0x0000000185492020
		public static void SetPcmBufferSize(int numSamples) {} // 0x0000000187871460-0x00000001878714F8
		private static extern void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config); // 0x00000001878714F8-0x000000018787157C
		private static extern void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config); // 0x000000018787157C-0x0000000187871608
		private static extern void criAtomExAsr_DetachBusAnalyzerByName(string busName); // 0x0000000187871608-0x0000000187871680
		private static extern void criAtomExAsr_DetachBusAnalyzer(int busNo); // 0x0000000187871680-0x0000000187871718
		private static extern void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info); // 0x0000000187871718-0x000000018787179C
		private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info); // 0x0000000187871B18-0x0000000187871B70
		private static extern void criAtomExAsr_SetBusVolumeByName(string busName, float volume); // 0x0000000187871B70-0x0000000187871BAC
		private static extern void criAtomExAsr_SetBusVolume(int busNo, float volume); // 0x0000000187871A5C-0x0000000187871AD0
		private static extern void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level); // 0x0000000187871AD0-0x0000000187871B18
		private static extern void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level); // 0x00000001878718F4-0x00000001878719B4
		private static extern void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix); // 0x00000001878719B4-0x0000000187871A5C
		private static extern void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix); // 0x0000000187871BAC-0x0000000187871C68
		private static extern void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass); // 0x0000000187871D20-0x0000000187871DCC
		private static extern void criAtomExAsr_UpdateEffectParameters(string busName, string effectName); // 0x0000000187871C68-0x0000000187871CEC
		private static extern void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue); // 0x0000000187871834-0x00000001878718BC
		private static extern float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex); // 0x00000001878718BC-0x00000001878718F4
		private static extern bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface); // 0x0000000187871CEC-0x0000000187871D20
		private static extern void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface); // 0x000000018787179C-0x0000000187871834
		private static extern void criAtomExAsr_GetBusVolumeByName(string busName, out float volume); // 0x0000000185492010-0x0000000185492020
	}

	public static class CriAtomExLatencyEstimator // TypeDefIndex: 55101
	{
		// Nested types
		public enum Status // TypeDefIndex: 55099
		{
			Stop = 0,
			Processing = 1,
			Done = 2,
			Error = 3
		}
	
		public struct EstimatorInfo // TypeDefIndex: 55100
		{
			// Fields
			public Status status; // 0x00
			public uint estimated_latency; // 0x04
		}
	
		// Methods
		public static void InitializeModule() {} // 0x0000000185492010-0x0000000185492020
		public static void FinalizeModule() {} // 0x0000000185492010-0x0000000185492020
		public static EstimatorInfo GetCurrentInfo() => default; // 0x0000000185FB2E20-0x0000000185FB2E30
	}

	public class CriAtomEx3dListener : CriDisposable // TypeDefIndex: 55103
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
	
		// Nested types
		public struct Config // TypeDefIndex: 55102
		{
			// Fields
			public int reserved; // 0x00
		}
	
		// Constructors
		public CriAtomEx3dListener() {} // 0x00000001844CF600-0x00000001844CF680
	
		// Methods
		public override void Dispose() {} // 0x0000000187868D78-0x0000000187868D84
		private void Dispose(bool disposing) {} // 0x0000000187868D84-0x0000000187868E10
		public void Update() {} // 0x0000000187869100-0x0000000187869114
		public void ResetParameters() {} // 0x0000000187868E90-0x0000000187868EA4
		public void SetPosition(float x, float y, float z) {} // 0x0000000187869098-0x00000001878690CC
		public void SetVelocity(float x, float y, float z) {} // 0x00000001878690CC-0x0000000187869100
		public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz) {} // 0x000000018786903C-0x0000000187869098
		public void SetDistanceFactor(float distanceFactor) {} // 0x0000000187868EE4-0x0000000187868F74
		public void SetDopplerMultiplier(float dopplerMultiplier) {} // 0x0000000187868F88-0x0000000187869008
		public void SetFocusPoint(float x, float y, float z) {} // 0x0000000187869008-0x000000018786903C
		public void SetDistanceFocusLevel(float distanceFocusLevel) {} // 0x0000000187868F74-0x0000000187868F88
		public void SetDirectionFocusLevel(float directionFocusLevel) {} // 0x0000000187868ED0-0x0000000187868EE4
		public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x0000000187868EA4-0x0000000187868ED0
		public bool IsDestroyable() => default; // 0x0000000187868E84-0x0000000187868E90
		~CriAtomEx3dListener() {} // 0x0000000187868E10-0x0000000187868E84
		private static extern IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size); // 0x00000001844CEF80-0x00000001844CF020
		private static extern void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener); // 0x0000000187869114-0x0000000187869148
		private static extern void criAtomEx3dListener_Update(IntPtr ex_3d_listener); // 0x00000001878694DC-0x0000000187869510
		private static extern void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener); // 0x00000001878691C4-0x00000001878691F8
		private static extern void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position); // 0x0000000187869454-0x0000000187869498
		private static extern void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity); // 0x0000000187869498-0x00000001878694DC
		private static extern void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001878693C0-0x0000000187869454
		private static extern void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor); // 0x0000000187869278-0x00000001878692BC
		private static extern void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier); // 0x00000001878692F8-0x000000018786933C
		private static extern void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector focus_point); // 0x000000018786933C-0x00000001878693C0
		private static extern void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level); // 0x00000001878692BC-0x00000001878692F8
		private static extern void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level); // 0x000000018786923C-0x0000000187869278
		private static extern bool criAtomEx3dListener_IsDestroyable(IntPtr ex_3d_listener); // 0x0000000187869148-0x00000001878691C4
		private static extern void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region); // 0x00000001878691F8-0x000000018786923C
	}

	public class CriAtomEx3dSource : CriDisposable // TypeDefIndex: 55105
	{
		// Fields
		private uint currentRandomPositionListMaxLength; // 0x20
		private IntPtr handle; // 0x28
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x0000000187869B58-0x0000000187869B64 
	
		// Nested types
		public struct Config // TypeDefIndex: 55104
		{
			// Fields
			public bool enableVoicePriorityDecay; // 0x00
			public uint randomPositionListMaxLength; // 0x04
	
			// Constructors
			public Config(bool enableVoicePriorityDecay, uint randomPositionListMaxLength) {
				this.enableVoicePriorityDecay = default;
				this.randomPositionListMaxLength = default;
			} // 0x0000000187869B64-0x0000000187869BF8
		}
	
		// Constructors
		public CriAtomEx3dSource() {} // Dummy constructor
		public CriAtomEx3dSource(bool enableVoicePriorityDecay = false /* Metadata: 0x0207BB69 */, uint randomPositionListMaxLength = 0 /* Metadata: 0x0207BB6A */) {} // 0x000000018786968C-0x0000000187869698
	
		// Methods
		public override void Dispose() {} // 0x0000000187869698-0x0000000187869724
		private void Dispose(bool disposing) {} // 0x00000001813B8590-0x00000001813B85A0
		public void Update() {} // 0x00000001878697E4-0x00000001878697F0
		public void ResetParameters() {} // 0x00000001878698FC-0x0000000187869928
		public void SetPosition(float x, float y, float z) {} // 0x0000000187869B20-0x0000000187869B4C
		public void SetVelocity(float x, float y, float z) {} // 0x000000018786989C-0x00000001878698FC
		public void SetOrientation(Vector3 front, Vector3 top) {} // 0x0000000187869814-0x0000000187869840
		public void SetConeOrientation(float x, float y, float z) {} // 0x0000000187869840-0x0000000187869854
		public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume) {} // 0x0000000187869890-0x000000018786989C
		public void SetMinMaxDistance(float minDistance, float maxDistance) {} // 0x000000018786986C-0x0000000187869878
		public void SetInteriorPanField(float sourceRadius, float interiorDistance) {} // 0x0000000187869860-0x000000018786986C
		public void SetDopplerFactor(float dopplerFactor) {} // 0x0000000187869B4C-0x0000000187869B58
		public void SetVolume(float volume) {} // 0x0000000187869884-0x0000000187869890
		public void SetMaxAngleAisacDelta(float maxDelta) {} // 0x0000000187869808-0x0000000187869814
		public void SetAttenuationDistanceSetting(bool flag) {} // 0x0000000187869798-0x00000001878697A4
		public bool GetAttenuationDistanceSetting() => default; // 0x0000000187869928-0x00000001878699D4
		public void SetRandomPositionConfig(CriAtomEx.Randomize3dConfig? config) {} // 0x00000001878699D4-0x0000000187869B14
		public void SetRandomPositionList(Vector3[] positionList) {} // 0x00000001878697F0-0x0000000187869808
		public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x0000000187869878-0x0000000187869884
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x0000000187869B14-0x0000000187869B20
		public void SetSourceBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x0000000187869854-0x0000000187869860
		public void SetDistanceAisacControlId(ushort aisacControlId) {} // 0x00000001878697D8-0x00000001878697E4
		public bool IsDestroyable() => default; // 0x00000001878697A4-0x00000001878697D8
		public CriAtomEx.NativeVector GetPosition() => default; // 0x0000000187869724-0x0000000187869798
		~CriAtomEx3dSource() {} // 0x0000000187869BF8-0x0000000187869CBC
		private static extern IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size); // 0x0000000187869CBC-0x0000000187869CF0
		private static extern void criAtomEx3dSource_Destroy(IntPtr ex_3d_source); // 0x000000018786A698-0x000000018786A710
		private static extern void criAtomEx3dSource_Update(IntPtr ex_3d_source); // 0x0000000187869E80-0x0000000187869EF8
		private static extern void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source); // 0x000000018786A358-0x000000018786A39C
		private static extern void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position); // 0x000000018786A618-0x000000018786A65C
		private static extern void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity); // 0x000000018786A2C4-0x000000018786A358
		private static extern void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x0000000187869FC0-0x000000018786A044
		private static extern void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector cone_orient); // 0x000000018786A044-0x000000018786A0A4
		private static extern void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume); // 0x000000018786A278-0x000000018786A2C4
		private static extern void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance); // 0x000000018786A164-0x000000018786A1B0
		private static extern void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance); // 0x000000018786A128-0x000000018786A164
		private static extern void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor); // 0x000000018786A65C-0x000000018786A698
		private static extern void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume); // 0x000000018786A234-0x000000018786A278
		private static extern void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta); // 0x0000000187869F3C-0x0000000187869FC0
		private static extern void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag); // 0x0000000187869CF0-0x0000000187869D6C
		private static extern bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source); // 0x000000018786A420-0x000000018786A4F4
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref CriAtomEx.Randomize3dConfig config); // 0x000000018786A39C-0x000000018786A420
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config); // 0x000000018786A4F4-0x000000018786A594
		private static extern void criAtomEx3dSource_SetRandomPositionList(IntPtr ex_3d_source, CriAtomEx.NativeVector[] position_list, uint length); // 0x000000018786A0A4-0x000000018786A128
		private static extern void criAtomEx3dSource_SetDistanceAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x0000000187869E04-0x0000000187869E80
		private static extern bool criAtomEx3dSource_IsDestroyable(IntPtr ex_3d_source); // 0x0000000187869D6C-0x0000000187869E04
		private static extern CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(IntPtr ex_3d_source); // 0x0000000187869EF8-0x0000000187869F3C
		private static extern void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region); // 0x000000018786A1B0-0x000000018786A234
		private static extern void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x000000018786A594-0x000000018786A618
		private static extern void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x0000000181B53950-0x0000000181B53960
	}

	public class CriAtomEx3dTransceiver : CriDisposable // TypeDefIndex: 55108
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x000000018787F990-0x000000018787FA24 
	
		// Nested types
		public struct Config // TypeDefIndex: 55106
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private static class UnsafeNativeMethods // TypeDefIndex: 55107
		{
			// Methods
			internal static extern IntPtr criAtomEx3dTransceiver_Create(ref Config config, IntPtr work, int work_size); // 0x000000018786AA44-0x000000018786AAB4
			internal static extern void criAtomEx3dTransceiver_Destroy(IntPtr ex_3d_transceiver); // 0x000000018786A7B4-0x000000018786A7C0
			internal static extern void criAtomEx3dTransceiver_Update(IntPtr ex_3d_transceiver); // 0x000000018786A728-0x000000018786A7B4
			internal static extern void criAtomEx3dTransceiver_SetInputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x00000001813B31A0-0x00000001813B31B0
			internal static extern void criAtomEx3dTransceiver_SetOutputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x000000018786AA38-0x000000018786AA44
			internal static extern void criAtomEx3dTransceiver_SetInputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x000000018786A8D8-0x000000018786A914
			internal static extern void criAtomEx3dTransceiver_SetOutputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x000000018786A9D8-0x000000018786AA14
			internal static extern void criAtomEx3dTransceiver_SetOutputConeParameter(IntPtr ex_3d_transceiver, float inside_angle, float outside_angle, float outside_volume); // 0x000000018786A864-0x000000018786A8D8
			internal static extern void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(IntPtr ex_3d_transceiver, float min_attenuation_distance, float max_attenuation_distance); // 0x000000018786A964-0x000000018786A9D8
			internal static extern void criAtomEx3dTransceiver_SetOutputInteriorPanField(IntPtr ex_3d_transceiver, float transceiver_radius, float interior_distance); // 0x000000018786A938-0x000000018786A94C
			internal static extern void criAtomEx3dTransceiver_SetInputCrossFadeField(IntPtr ex_3d_transceiver, float direct_audio_radius, float crossfade_distance); // 0x000000018786A958-0x000000018786A964
			internal static extern void criAtomEx3dTransceiver_SetOutputVolume(IntPtr ex_3d_transceiver, float volume); // 0x000000018786A94C-0x000000018786A958
			internal static extern void criAtomEx3dTransceiver_AttachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x000000018786A858-0x000000018786A864
			internal static extern void criAtomEx3dTransceiver_DetachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x000000018786AA14-0x000000018786AA20
			internal static extern void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(IntPtr ex_3d_transceiver, float max_delta); // 0x000000018786A710-0x000000018786A71C
			internal static extern void criAtomEx3dTransceiver_SetDistanceAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018786A71C-0x000000018786A728
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018786A92C-0x000000018786A938
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018786A84C-0x000000018786A858
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018786A914-0x000000018786A920
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x000000018786A920-0x000000018786A92C
			internal static extern void criAtomEx3dTransceiver_Set3dRegionHn(IntPtr ex_3d_transceiver, IntPtr ex_3d_region); // 0x000000018786AA20-0x000000018786AA2C
		}
	
		// Constructors
		public CriAtomEx3dTransceiver() {} // 0x000000018786AA2C-0x000000018786AA38
	
		// Methods
		public override void Dispose() {} // 0x000000018786A834-0x000000018786A84C
		private void Dispose(bool disposing) {} // 0x000000018786A7C0-0x000000018786A834
		public void Update() {} // 0x000000018787FA24-0x000000018787FA58
		public void SetInputPosition(Vector3 position) {} // 0x00000001878801BC-0x00000001878801F0
		public void SetOutputPosition(Vector3 position) {} // 0x000000018787FC98-0x000000018787FD1C
		public void SetInputOrientation(Vector3 front, Vector3 top) {} // 0x000000018787FFEC-0x0000000187880070
		public void SetOutputOrientation(Vector3 front, Vector3 top) {} // 0x000000018787FC04-0x000000018787FC98
		public void SetOutputConeParameter(float insideAngle, float outsideAngle, float outsideVolume) {} // 0x000000018787FF58-0x000000018787FFEC
		public void SetOutputMinMaxDistance(float minDistance, float maxDistance) {} // 0x000000018787FE60-0x000000018787FEC0
		public void SetOutputInteriorPanField(float radius, float interiorDistance) {} // 0x000000018787FF0C-0x000000018787FF58
		public void SetInputCrossFadeField(float directAudioRadius, float crossfadeDistance) {} // 0x000000018787FEC0-0x000000018787FF0C
		public void SetOutputVolume(float volume) {} // 0x000000018787FBB8-0x000000018787FC04
		public void AttachAisac(string globalAisacName) {} // 0x0000000187880070-0x00000001878800B4
		public void DetachAisac(string globalAisacName) {} // 0x000000018787F938-0x000000018787F990
		public void SetMaxAngleAisacDelta(float maxDelta) {} // 0x000000018787FA58-0x000000018787FAB0
		public void SetDistanceAisacControlId(ushort aisacControlId) {} // 0x000000018787FE24-0x000000018787FE60
		public void SetListenerBasedAzimuthAngleAisacControlId(ushort aisacControlId) {} // 0x000000018787FB34-0x000000018787FBB8
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x000000018787FD1C-0x000000018787FDA0
		public void SetTransceiverOutputBasedAzimuthAngleAisacControlId(ushort aisacControlId) {} // 0x000000018787FDA0-0x000000018787FE24
		public void SetTransceiverOutputBasedElevationAngleAisacControlId(ushort aisacControlId) {} // 0x00000001878800B4-0x0000000187880138
		public void Set3dRegion(CriAtomEx3dRegion region3d) {} // 0x0000000187880138-0x00000001878801BC
		~CriAtomEx3dTransceiver() {} // 0x000000018787FAB0-0x000000018787FB34
	}

	public class CriAtomEx3dRegion : CriDisposable // TypeDefIndex: 55111
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x000000018787F904-0x000000018787F938 
	
		// Nested types
		public struct Config // TypeDefIndex: 55109
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private static class UnsafeNativeMethods // TypeDefIndex: 55110
		{
			// Methods
			internal static extern IntPtr criAtomEx3dRegion_Create(ref Config config, IntPtr work, int work_size); // 0x000000018786961C-0x000000018786968C
			internal static extern void criAtomEx3dRegion_Destroy(IntPtr ex_3d_region); // 0x0000000187869510-0x000000018786951C
		}
	
		// Constructors
		public CriAtomEx3dRegion() {} // 0x000000018786951C-0x00000001878695A8
	
		// Methods
		public override void Dispose() {} // 0x00000001878695A8-0x000000018786961C
		private void Dispose(bool disposing) {} // 0x00000001813B31A0-0x00000001813B31B0
		~CriAtomEx3dRegion() {} // 0x000000018787F870-0x000000018787F904
	}

	public class CriAtomExAcb : CriDisposable // TypeDefIndex: 55112
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle dataHandle; // 0x28
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public bool isAvailable { get => default; } // 0x000000018786D7C0-0x000000018786D7CC 
	
		// Constructors
		public CriAtomExAcb() {} // Dummy constructor
		internal CriAtomExAcb(IntPtr handle, GCHandle? dataHandle) {} // 0x000000018786C854-0x000000018786C8F4
	
		// Methods
		public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath) => default; // 0x000000018786C770-0x000000018786C83C
		public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath) => default; // 0x000000018786C654-0x000000018786C770
		public override void Dispose() {} // 0x000000018786B428-0x000000018786B478
		private void Dispose(bool disposing) {} // 0x000000018786B478-0x000000018786B4F4
		public bool Exists(string cueName) => default; // 0x000000018786B4F4-0x000000018786B500
		public bool Exists(int cueId) => default; // 0x000000018786B500-0x000000018786B50C
		public bool GetCueInfo(string cueName, out CriAtomEx.CueInfo info) {
			info = default;
			return default;
		} // 0x000000018786BAAC-0x000000018786BCE0
		public bool GetCueInfo(int cueId, out CriAtomEx.CueInfo info) {
			info = default;
			return default;
		} // 0x000000018786B878-0x000000018786BAAC
		public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info) {
			info = default;
			return default;
		} // 0x000000018786B598-0x000000018786B7CC
		public CriAtomEx.CueInfo[] GetCueInfoList() => default; // 0x000000018786B7CC-0x000000018786B878
		public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info) {
			info = default;
			return default;
		} // 0x000000018786C254-0x000000018786C448
		public bool GetWaveFormInfo(int cueId, out CriAtomEx.WaveformInfo info) {
			info = default;
			return default;
		} // 0x000000018786C448-0x000000018786C63C
		public int GetNumCuePlaying(string name) => default; // 0x000000018786BCEC-0x000000018786BCF8
		public int GetNumCuePlaying(int id) => default; // 0x000000018786BCE0-0x000000018786BCEC
		public int GetBlockIndex(string cueName, string blockName) => default; // 0x000000018786B58C-0x000000018786B598
		public int GetBlockIndex(int cueId, string blockName) => default; // 0x000000018786B580-0x000000018786B58C
		public int GetNumUsableAisacControls(string cueName) => default; // 0x000000018786BCF8-0x000000018786BD04
		public int GetNumUsableAisacControls(int cueId) => default; // 0x000000018786BD04-0x000000018786BD10
		public bool GetUsableAisacControl(string cueName, int index, out CriAtomEx.AisacControlInfo info) {
			info = default;
			return default;
		} // 0x000000018786C07C-0x000000018786C254
		public bool GetUsableAisacControl(int cueId, int index, out CriAtomEx.AisacControlInfo info) {
			info = default;
			return default;
		} // 0x000000018786BE94-0x000000018786C07C
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(string cueName) => default; // 0x000000018786BD10-0x000000018786BDD4
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(int cueId) => default; // 0x000000018786BDD4-0x000000018786BE94
		public void ResetCueTypeState(string cueName) {} // 0x000000018786C848-0x000000018786C854
		public void ResetCueTypeState(int cueId) {} // 0x000000018786C83C-0x000000018786C848
		public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name) {} // 0x000000018786B370-0x000000018786B3A8
		public void DetachAwbFile(string awb_name) {} // 0x000000018786B414-0x000000018786B428
		public bool IsReadyToRelease() => default; // 0x000000018786C63C-0x000000018786C654
		public float GetLoadProgress() => default; // 0x0000000185FB2DD0-0x0000000185FB2DE0
		public void Decrypt(ulong key, ulong nonce) {} // 0x000000018786B3A8-0x000000018786B414
		~CriAtomExAcb() {} // 0x000000018786B50C-0x000000018786B580
		private static extern IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x000000018786D5BC-0x000000018786D6B4
		private static extern IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x000000018786D4D8-0x000000018786D5BC
		private static extern void criAtomExAcb_Release(IntPtr acb_hn); // 0x000000018786D6B4-0x000000018786D6E8
		private static extern int criAtomExAcb_GetNumCues(IntPtr acb_hn); // 0x000000018786D040-0x000000018786D074
		private static extern bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id); // 0x000000018786CA70-0x000000018786CAF8
		private static extern bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name); // 0x000000018786CAF8-0x000000018786CBA8
		private static extern int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id); // 0x000000018786D074-0x000000018786D0F8
		private static extern int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name); // 0x000000018786D0F8-0x000000018786D1A4
		private static extern bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info); // 0x000000018786D1A4-0x000000018786D24C
		private static extern bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info); // 0x000000018786D24C-0x000000018786D310
		private static extern bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info); // 0x000000018786D310-0x000000018786D3A8
		private static extern bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info); // 0x000000018786D3A8-0x000000018786D45C
		private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info); // 0x000000018786CE5C-0x000000018786CF10
		private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info); // 0x000000018786CD2C-0x000000018786CDC4
		private static extern bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info); // 0x000000018786CDC4-0x000000018786CE5C
		private static extern int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name); // 0x000000018786CF94-0x000000018786D040
		private static extern int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id); // 0x000000018786CF10-0x000000018786CF94
		private static extern int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name); // 0x000000018786CBA8-0x000000018786CC60
		private static extern int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name); // 0x000000018786CC60-0x000000018786CD2C
		private static extern void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name); // 0x000000018786D728-0x000000018786D7C0
		private static extern void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id); // 0x000000018786D6E8-0x000000018786D728
		private static extern void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size); // 0x000000018786C8F4-0x000000018786C9D8
		private static extern void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name); // 0x000000018786C9D8-0x000000018786CA70
		private static extern bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn); // 0x000000018786D45C-0x000000018786D4D8
	}

	public class CriAtomExAcbLoader : CriDisposable // TypeDefIndex: 55115
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle? gch; // 0x28
	
		// Nested types
		public enum Status // TypeDefIndex: 55113
		{
			Stop = 0,
			Loading = 1,
			Complete = 2,
			Error = 3
		}
	
		private struct LoaderConfig // TypeDefIndex: 55114
		{
			// Fields
			public bool shouldLoadAwbOnMemory; // 0x00
		}
	
		// Constructors
		public CriAtomExAcbLoader() {} // Dummy constructor
		private CriAtomExAcbLoader(IntPtr handle, GCHandle? dataHandle) {} // 0x000000018786AF0C-0x000000018786AFD0
	
		// Methods
		public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x0207BB6B */) => default; // 0x000000018786AD84-0x000000018786AE6C
		public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x0207BB6C */) => default; // 0x000000018786AC48-0x000000018786AD84
		public Status GetStatus() => default; // 0x000000018786AC3C-0x000000018786AC48
		public CriAtomExAcb MoveAcb() => default; // 0x000000018786AE6C-0x000000018786AF0C
		public override void Dispose() {} // 0x000000018786AAB4-0x000000018786AB04
		private void Dispose(bool disposing) {} // 0x000000018786AB04-0x000000018786ABC8
		~CriAtomExAcbLoader() {} // 0x000000018786ABC8-0x000000018786AC3C
		private static extern IntPtr criAtomExAcbLoader_Create(in LoaderConfig config); // 0x000000018786AFD0-0x000000018786B050
		private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader); // 0x000000018786B050-0x000000018786B084
		private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path); // 0x000000018786B1D4-0x000000018786B2C0
		private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path); // 0x000000018786B0FC-0x000000018786B1D4
		private static extern Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader); // 0x000000018786B084-0x000000018786B0FC
		private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader); // 0x000000018786B338-0x000000018786B370
		private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader); // 0x000000018786B2C0-0x000000018786B338
	}

	public class CriAtomExAcf // TypeDefIndex: 55130
	{
		// Nested types
		public struct AcfDspSettingInfo // TypeDefIndex: 55116
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
			} // 0x000000018786F004-0x000000018786F00C
		}
	
		public struct AcfDspSettingSnapshotInfo // TypeDefIndex: 55117
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
			} // 0x000000018786D9C4-0x000000018786DB7C
		}
	
		public struct AcfDspBusInfo // TypeDefIndex: 55118
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
			} // 0x000000018786F02C-0x000000018786F034
		}
	
		public enum AcfDspBusLinkType : uint // TypeDefIndex: 55119
		{
			preVolume = 0,
			postVolume = 1,
			postPan = 2
		}
	
		public struct AcfDspBusLinkInfo // TypeDefIndex: 55120
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
			} // 0x000000018786F024-0x000000018786F02C
		}
	
		public struct CategoryInfo // TypeDefIndex: 55121
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
			} // 0x000000018786E654-0x000000018786E6AC
		}
	
		public enum AcfAisacType : uint // TypeDefIndex: 55122
		{
			normal = 0,
			autoModulation = 1
		}
	
		public struct GlobalAisacInfo // TypeDefIndex: 55123
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
			} // 0x000000018786E6AC-0x000000018786E720
		}
	
		public enum AisacGraphType // TypeDefIndex: 55124
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
	
		public struct AisacGraphInfo // TypeDefIndex: 55125
		{
			// Fields
			public AisacGraphType type; // 0x00
	
			// Constructors
			public AisacGraphInfo(byte[] data, int startIndex) {
				type = default;
			} // 0x000000018786E470-0x000000018786E654
		}
	
		public enum CharacterEncoding : uint // TypeDefIndex: 55126
		{
			utf8 = 0,
			sjis = 1
		}
	
		public struct AcfInfo // TypeDefIndex: 55127
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
			} // 0x000000018786E720-0x000000018786E90C
		}
	
		public struct SelectorInfo // TypeDefIndex: 55128
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
			} // 0x000000018786E0F0-0x000000018786E2F0
		}
	
		public struct SelectorLabelInfo // TypeDefIndex: 55129
		{
			// Fields
			public string selectorName; // 0x00
			public string labelName; // 0x08
	
			// Constructors
			public SelectorLabelInfo(byte[] data, int startIndex) {
				selectorName = default;
				labelName = default;
			} // 0x000000018786E2F0-0x000000018786E470
		}
	
		// Constructors
		public CriAtomExAcf() {} // 0x000000018787E850-0x000000018787E908
	
		// Methods
		public static int GetNumAisacControls() => default; // 0x000000018786F01C-0x000000018786F024
		public static bool GetAisacControlInfo(ushort index, out CriAtomEx.AisacControlInfo info) {
			info = default;
			return default;
		} // 0x000000018786F014-0x000000018786F01C
		public static int GetNumDspSettings() => default; // 0x000000018786DD50-0x000000018786DF28
		public static int GetNumDspSettings(IntPtr acfData, int size) => default; // 0x000000018786DF28-0x000000018786E0F0
		public static string GetDspSettingNameByIndex(ushort index) => default; // 0x000000018786DB7C-0x000000018786DD50
		public static string GetDspSettingNameByIndex(IntPtr acfData, int size, ushort index) => default; // 0x000000018786F034-0x000000018786F03C
		public static bool GetDspSettingInformation(string name, out AcfDspSettingInfo info) {
			info = default;
			return default;
		} // 0x000000018786EB50-0x000000018786ED24
		public static bool GetDspSettingSnapshotInformation(ushort index, out AcfDspSettingSnapshotInfo info) {
			info = default;
			return default;
		} // 0x000000018786ED24-0x000000018786EEEC
		public static bool GetDspBusInformation(ushort index, out AcfDspBusInfo info) {
			info = default;
			return default;
		} // 0x000000018786E90C-0x000000018786EB50
		public static bool GetDspBusLinkInformation(ushort index, out AcfDspBusLinkInfo info) {
			info = default;
			return default;
		} // 0x000000018786EEEC-0x000000018786EFFC
		public static int GetNumCategories() => default; // 0x000000018786D7D4-0x000000018786D9C4
		public static int GetNumCategoriesPerPlayback() => default; // 0x000000018786F03C-0x000000018786F044
		public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo info) {
			info = default;
			return default;
		} // 0x000000018786F044-0x000000018786F1FC
		public static bool GetCategoryInfoByName(string name, out CategoryInfo info) {
			info = default;
			return default;
		} // 0x000000018786F1FC-0x000000018786F3B4
		public static bool GetCategoryInfoById(uint id, out CategoryInfo info) {
			info = default;
			return default;
		} // 0x000000018786F3B4-0x000000018786F63C
		public static int GetNumGlobalAisacs() => default; // 0x000000018786F00C-0x000000018786F014
		public static bool GetGlobalAisacInfoByIndex(ushort index, out GlobalAisacInfo info) {
			info = default;
			return default;
		} // 0x000000018786EFFC-0x000000018786F004
		public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info) {
			info = default;
			return default;
		} // 0x000000018786D7CC-0x000000018786D7D4
		public static bool GetGlobalAisacGraphInfo(GlobalAisacInfo aisacInfo, ushort graphIndex, out AisacGraphInfo graphInfo) {
			graphInfo = default;
			return default;
		} // 0x00000001878701C4-0x00000001878701E8
		public static bool GetGlobalAisacValue(GlobalAisacInfo aisacInfo, float control, AisacGraphType type, out float value) {
			value = default;
			return default;
		} // 0x000000018786F818-0x000000018786F8A4
		public static bool GetAcfInfo(out AcfInfo acfInfo) {
			acfInfo = default;
			return default;
		} // 0x000000018786F7C4-0x000000018786F818
		public static int GetNumSelectors() => default; // 0x000000018786F8A4-0x000000018786F93C
		public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info) {
			info = default;
			return default;
		} // 0x0000000187870438-0x00000001878704A0
		public static bool GetSelectorInfoByName(string name, out SelectorInfo info) {
			info = default;
			return default;
		} // 0x00000001878703B4-0x0000000187870438
		public static bool GetSelectorLabelInfo(SelectorInfo selectorInfo, ushort labelIndex, out SelectorLabelInfo info) {
			info = default;
			return default;
		} // 0x000000018786FE6C-0x000000018786FEE4
		public static int GetNumBuses() => default; // 0x000000018786FDD8-0x000000018786FE6C
		public static int GetMaxBusesOfDspBusSettings() => default; // 0x000000018786FD74-0x000000018786FDD8
		public static string FindBusName(string busName) => default; // 0x000000018786FEE4-0x000000018786FF70
		private static extern int criAtomExAcf_GetNumAisacControls(); // 0x000000018786FAB4-0x000000018786FB40
		private static extern bool criAtomExAcf_GetAisacControlInfo(ushort index, IntPtr info); // 0x000000018786FCFC-0x000000018786FD74
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x000000018786FBCC-0x000000018786FC64
		private static extern string criAtomExAcf_GetAisacControlNameById(uint id); // 0x000000018786FC64-0x000000018786FCFC
		private static extern int criAtomExAcf_GetNumDspSettings(); // 0x000000018786FB40-0x000000018786FBCC
		private static extern int criAtomExAcf_GetNumDspSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x0000000187870298-0x000000018787031C
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndex(ushort index); // 0x0000000187870388-0x00000001878703B4
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(IntPtr acf_data, int acf_data_size, ushort index); // 0x000000018787031C-0x000000018787035C
		private static extern bool criAtomExAcf_GetDspSettingInformation(string name, IntPtr info); // 0x000000018787035C-0x0000000187870388
		private static extern bool criAtomExAcf_GetDspSettingSnapshotInformation(ushort index, IntPtr info); // 0x000000018786FA28-0x000000018786FAB4
		private static extern bool criAtomExAcf_GetDspBusInformation(ushort index, IntPtr info); // 0x000000018786F9C4-0x000000018786FA28
		private static extern int criAtomExAcf_GetDspFxType(ushort index); // 0x000000018786F93C-0x000000018786F9C4
		private static extern string criAtomExAcf_GetDspFxName(ushort index); // 0x00000001878704A0-0x00000001878704C4
		private static extern bool criAtomExAcf_GetDspFxParameters(ushort index, IntPtr parameters, int size); // 0x000000018787006C-0x00000001878700F8
		private static extern bool criAtomExAcf_GetDspBusLinkInformation(ushort index, IntPtr info); // 0x0000000187870008-0x000000018787006C
		private static extern int criAtomExAcf_GetNumCategoriesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x000000018786FF70-0x0000000187870008
		private static extern int criAtomExAcf_GetNumCategories(); // 0x00000001878700F8-0x0000000187870158
		private static extern int criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(IntPtr acf_data, int acf_data_size); // 0x000000018786F78C-0x000000018786F7C4
		private static extern int criAtomExAcf_GetNumCategoriesPerPlayback(); // 0x000000018786F6F4-0x000000018786F78C
		private static extern bool criAtomExAcf_GetCategoryInfo(ushort index, IntPtr info); // 0x00000001878704C4-0x00000001878704E8
		private static extern bool criAtomExAcf_GetCategoryInfoByName(string name, IntPtr info); // 0x00000001878704E8-0x0000000187870574
		private static extern bool criAtomExAcf_GetCategoryInfoById(uint id, IntPtr info); // 0x0000000187870574-0x00000001878705D8
		private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x00000001878705D8-0x0000000187870670
		private static extern bool criAtomExAcf_GetGlobalAisacInfo(ushort index, IntPtr info); // 0x00000001878701E8-0x000000018787026C
		private static extern bool criAtomExAcf_GetGlobalAisacInfoByName(string name, IntPtr info); // 0x000000018787026C-0x0000000187870298
		private static extern bool criAtomExAcf_GetGlobalAisacGraphInfo(IntPtr aisac_info, ushort graph_index, IntPtr graph_info); // 0x0000000187870158-0x0000000187870198
		private static extern bool criAtomExAcf_GetGlobalAisacValue(IntPtr aisac_info, float control, AisacGraphType type, out float value); // 0x0000000187870198-0x00000001878701C4
		private static extern bool criAtomExAcf_GetAcfInfo(IntPtr acf_info); // 0x000000018786F63C-0x000000018786F6F4
		private static extern bool criAtomExAcf_GetAcfInfoFromAcfData(IntPtr acf_data, int acf_data_size, IntPtr acf_info); // 0x0000000185492010-0x0000000185492020
		private static extern int criAtomExAcf_GetNumSelectors(); // 0x0000000187867E10-0x0000000187868044
		private static extern bool criAtomExAcf_GetSelectorInfoByIndex(ushort index, IntPtr info); // 0x0000000187868044-0x0000000187868260
		private static extern bool criAtomExAcf_GetSelectorInfoByName(string name, IntPtr info); // 0x0000000187867AB4-0x0000000187867CE4
		private static extern bool criAtomExAcf_GetSelectorLabelInfo(IntPtr selector_info, ushort label_index, IntPtr info); // 0x0000000187867CE4-0x0000000187867E10
		private static extern int criAtomExAcf_GetNumBusesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x0000000187868A60-0x0000000187868B48
		private static extern int criAtomExAcf_GetNumBuses(); // 0x000000018787DF5C-0x000000018787E0E4
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x0000000187868514-0x0000000187868608
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettings(); // 0x0000000187868260-0x000000018786846C
		private static extern string criAtomExAcf_FindBusName(string bus_name); // 0x000000018787E784-0x000000018787E850
	}

	public class CriAtomExAsrRack : CriDisposable // TypeDefIndex: 55135
	{
		// Fields
		public const int defaultRackId = 0; // Metadata: 0x0207BBAF
		private int _rackId; // 0x20
		private bool hasExistingRackId; // 0x24
	
		// Properties
		public int rackId { get => default; } // 0x00000001813B88B0-0x00000001813B88C0 
		public static Config defaultConfig { get => default; } // 0x0000000185FB2DE0-0x0000000185FB2E20 
	
		// Nested types
		public enum SpeakerMapping // TypeDefIndex: 55131
		{
			Auto = 0,
			Monaural = 1,
			Stereo = 2,
			Ch5_1 = 3,
			Ch7_1 = 4,
			Ch5_1_2 = 5,
			Ch7_1_4 = 6
		}
	
		public struct Config // TypeDefIndex: 55132
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
	
		public struct PlatformConfig // TypeDefIndex: 55133
		{
			// Fields
			public byte reserved; // 0x00
		}
	
		public struct PerformanceInfo // TypeDefIndex: 55134
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
		public CriAtomExAsrRack(Config config, PlatformConfig platformConfig) {} // 0x00000001878709A8-0x0000000187870AB4
		public CriAtomExAsrRack(int existingRackId) {} // 0x0000000187870AB4-0x0000000187870B70
	
		// Methods
		public void AttachDspBusSetting(string settingName) {} // 0x000000018787067C-0x000000018787069C
		public void DetachDspBusSetting() {} // 0x0000000187870720-0x000000018787072C
		public void ApplyDspBusSnapshot(string snapshotName, int timeMs) {} // 0x0000000187870670-0x000000018787067C
		public static string GetAppliedDspBusSnapshotName(int rackId) => default; // 0x0000000187870874-0x00000001878708C8
		public string GetAppliedDspBusSnapshotName() => default; // 0x000000018787081C-0x0000000187870874
		public PerformanceInfo GetPerformanceInfo() => default; // 0x00000001878708FC-0x0000000187870984
		public static PerformanceInfo GetPerformanceInfoByRackId(int rackId = 0 /* Metadata: 0x0207BBAD */) => default; // 0x00000001878708C8-0x00000001878708FC
		public void ResetPerformanceMonitor() {} // 0x000000018787098C-0x0000000187870998
		public static void ResetPerformanceMonitorByRackId(int rackId = 0 /* Metadata: 0x0207BBAE */) {} // 0x0000000187870984-0x000000018787098C
		public static void SetAisacControl(int rackId, string controlName, float value) {} // 0x0000000187870998-0x00000001878709A0
		public static void SetAisacControl(int rackId, int controlId, float value) {} // 0x00000001878709A0-0x00000001878709A8
		public override void Dispose() {} // 0x000000018787072C-0x00000001878707A8
		~CriAtomExAsrRack() {} // 0x00000001878707A8-0x000000018787081C
		private static extern int CRIWARE6158351D(in Config config, in PlatformConfig platformConfig); // 0x000000018787069C-0x0000000187870720
		private static extern void criAtomExAsrRack_Destroy(int rackId); // 0x0000000187870CCC-0x0000000187870D44
		private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize); // 0x0000000187870C18-0x0000000187870CCC
		private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId); // 0x0000000187870D44-0x0000000187870DBC
		private static extern IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(int rackId); // 0x0000000187870DBC-0x0000000187870E34
		private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs); // 0x0000000187870B70-0x0000000187870C18
		private static extern void criAtomExAsrRack_GetPerformanceInfo(int rackId, out PerformanceInfo perfInfo); // 0x0000000187870E34-0x0000000187870EB8
		private static extern void criAtomExAsrRack_ResetPerformanceMonitor(int rackId); // 0x0000000187870EB8-0x0000000187870F30
		private static extern void criAtomExAsrRack_SetAisacControlById(int rackId, ushort controlId, float value); // 0x0000000187870F30-0x0000000187870F7C
		private static extern void criAtomExAsrRack_SetAisacControlByName(int rackId, string controlName, float value); // 0x0000000187870F7C-0x0000000187870FDC
	}

	public class CriAtomExAuxIn : CriDisposable // TypeDefIndex: 55137
	{
		// Fields
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomExAuxIn."; // Metadata: 0x0207BBB7
		private IntPtr handle; // 0x20
		private CriAudioReadStream inputReadStream; // 0x28
	
		// Nested types
		public struct Config // TypeDefIndex: 55136
		{
			// Fields
			public int maxChannels; // 0x00
			public int maxSamplingRate; // 0x04
			public CriAtomEx.SoundRendererType soundRendererType; // 0x08
	
			// Properties
			public static Config Default { get => default; } // 0x0000000187871EE0-0x0000000187871FB0 
		}
	
		// Constructors
		public CriAtomExAuxIn() {} // Dummy constructor
		public CriAtomExAuxIn(Config? config = default) {} // 0x00000001878707A8-0x000000018787081C
	
		// Methods
		~CriAtomExAuxIn() {} // 0x0000000187871DCC-0x0000000187871E48
		public override void Dispose() {} // 0x0000000187871EC0-0x0000000187871ECC
		public void Start() {} // 0x0000000187871ECC-0x0000000187871EE0
		public void Stop() {} // 0x0000000187871E60-0x0000000187871E6C
		public void SetFormat(int numChannels, int samplingRate) {} // 0x0000000187871E48-0x0000000187871E54
		public void GetFormat(out int numChannels, out int samplingRate) {
			numChannels = default;
			samplingRate = default;
		} // 0x0000000187871EB4-0x0000000187871EC0
		public void SetVolume(float volume) {} // 0x0000000187871E6C-0x0000000187871E78
		public void SetFrequencyRatio(float frequencyRatio) {} // 0x0000000187871E54-0x0000000187871E60
		public void SetBusSendLevel(string busName, float level) {} // 0x0000000187871E78-0x0000000187871EB4
		public void SetInputReadStream(CriAudioReadStream stream) {} // 0x0000000187871FB0-0x0000000187872044
		private static extern IntPtr criAtomAuxIn_Create(in Config config, IntPtr work, int work_size); // 0x0000000187872044-0x0000000187872078
		private static extern void criAtomAuxIn_Destroy(IntPtr aux_in); // 0x00000001878722D4-0x0000000187872308
		private static extern void criAtomAuxIn_Start(IntPtr aux_in); // 0x0000000187872308-0x0000000187872380
		private static extern void criAtomAuxIn_Stop(IntPtr aux_in); // 0x0000000187872298-0x00000001878722D4
		private static extern void criAtomAuxIn_SetVolume(IntPtr aux_in, float volume); // 0x0000000187872200-0x0000000187872244
		private static extern void criAtomAuxIn_SetFrequencyRatio(IntPtr aux_in, float ratio); // 0x000000018787210C-0x000000018787216C
		private static extern void criAtomAuxIn_SetBusSendLevelByName(IntPtr aux_in, string bus_name, float level); // 0x000000018787216C-0x0000000187872200
		private static extern void criAtomAuxIn_SetFormat(IntPtr aux_in, int num_channels, int sampling_rate); // 0x0000000187872078-0x000000018787210C
		private static extern void criAtomAuxIn_GetFormat(IntPtr aux_in, out int num_channels, out int sampling_rate); // 0x0000000187872244-0x0000000187872298
		private static extern void criAtomAuxIn_SetInputReadStream(IntPtr aux_in, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x0000000185FB2DB0-0x0000000185FB2DD0
	}

	public class CriAtomExMic : CriDisposable // TypeDefIndex: 55141
	{
		// Fields
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic."; // Metadata: 0x0207BBEA
		private const string errorInvalidBufferLength = "[CRIWARE] Invalid buffer length for CriAtomMic.ReadData."; // Metadata: 0x0207BC19
		private const string errorInvalidNumBuffers = "[CRIWARE] Number of buffers are not same with channels of CriAtomMic."; // Metadata: 0x0207BC52
		private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized."; // Metadata: 0x0207BC99
		private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized."; // Metadata: 0x0207BCCD
		private static bool _isInitialized_k__BackingField; // 0x00
		private IntPtr handle; // 0x20
		private IntPtr[] bufferPointers; // 0x28
		private GCHandle[] gcHandles; // 0x30
		private CriAudioWriteStream outputWriteStream; // 0x38
		private static int _initializationCount; // 0x04
	
		// Properties
		public static bool isInitialized { get; private set; } // 0x0000000187873928-0x0000000187873930 0x000000018787371C-0x000000018787381C
	
		// Nested types
		public struct DeviceInfo // TypeDefIndex: 55138
		{
			// Fields
			public string deviceId; // 0x00
			public string deviceName; // 0x08
			public uint deviceFlags; // 0x10
			public int maxChannels; // 0x14
			public int maxSamplingRate; // 0x18
		}
	
		public struct Config // TypeDefIndex: 55139
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
			public static Config Default { get => default; } // 0x0000000187874B6C-0x0000000187874BA4 
		}
	
		public class Effect // TypeDefIndex: 55140
		{
			// Fields
			private IntPtr _handle_k__BackingField; // 0x10
			private IntPtr _afxInstance_k__BackingField; // 0x18
	
			// Properties
			public IntPtr handle { get; private set; } // 0x0000000187874BA4-0x0000000187874BE0 0x00000001878739A0-0x0000000187873A3C
			public IntPtr afxInstance { get; private set; } // 0x0000000187873658-0x000000018787371C 0x0000000185492010-0x0000000185492020
	
			// Constructors
			public Effect() {} // Dummy constructor
			public Effect(IntPtr handle, IntPtr afxInstance) {} // 0x000000018787381C-0x00000001878738EC
		}
	
		// Constructors
		public CriAtomExMic() {} // Dummy constructor
		private CriAtomExMic(IntPtr handle) {} // 0x000000018787391C-0x0000000187873928
	
		// Methods
		public static void InitializeModule() {} // 0x0000000187873AF4-0x0000000187873B04
		public static void FinalizeModule() {} // 0x0000000187873440-0x000000018787358C
		public static void SetupOutputCategoryForMic_IOS(bool enable) {} // 0x0000000187873F10-0x0000000187873FD0
		public static DeviceInfo[] GetDevices() => default; // 0x00000001878707A8-0x000000018787081C
		public static int GetNumDevices() => default; // 0x0000000187873608-0x0000000187873658
		public static DeviceInfo? GetDefaultDevice() => default; // 0x00000001878735B0-0x0000000187873608
		public static bool IsFormatSupported(Config config) => default; // 0x0000000187873ED4-0x0000000187873EE0
		public static CriAtomExMic Create(Config? config = default) => default; // 0x0000000187873EE0-0x0000000187873EEC
		~CriAtomExMic() {} // 0x0000000187873994-0x00000001878739A0
		public override void Dispose() {} // 0x0000000187873910-0x000000018787391C
		private void Dispose(bool disposing) {} // 0x0000000187873910-0x000000018787391C
		public void Start() {} // 0x0000000187873AD4-0x0000000187873AF4
		public void Stop() {} // 0x0000000187873B68-0x0000000187873B88
		public int GetNumChannels() => default; // 0x0000000187873CAC-0x0000000187873D3C
		public int GetSamplingRate() => default; // 0x0000000187873B04-0x0000000187873B2C
		public uint GetNumBufferedSamples() => default; // 0x0000000187873B88-0x0000000187873CAC
		public uint GetNumBufferredSamples() => default; // 0x0000000187873B2C-0x0000000187873B68
		public bool IsAvailable() => default; // 0x0000000187873D3C-0x0000000187873E44
		public uint ReadData(float[] bufferMono) => default; // 0x0000000187873E94-0x0000000187873ED4
		public uint ReadData(float[] bufferMono, uint numToRead) => default; // 0x0000000187873930-0x0000000187873994
		public uint ReadData(float[] bufferL, float[] bufferR) => default; // 0x0000000187873398-0x0000000187873440
		public uint ReadData(float[] bufferL, float[] bufferR, uint numToRead) => default; // 0x000000018787358C-0x00000001878735B0
		public uint ReadData(float[][] buffers) => default; // 0x0000000187873E68-0x0000000187873E94
		public uint ReadData(float[][] buffers, uint numToRead) => default; // 0x00000001878738EC-0x0000000187873910
		public void SetOutputWriteStream(CriAudioWriteStream stream) {} // 0x0000000187873E44-0x0000000187873E68
		public CriAudioReadStream GetOutputReadStream() => default; // 0x0000000187873EEC-0x0000000187873F10
		public Effect AttachEffect(IntPtr afxInterface, float[] configParameters) => default; // 0x0000000187873AC0-0x0000000187873AD4
		public void DetachEffect(Effect effect) {} // 0x0000000187873A3C-0x0000000187873AC0
		public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue) {} // 0x0000000187874038-0x00000001878740A0
		public float GetEffectParameter(Effect effect, int parameterIndex) => default; // 0x0000000187873FD0-0x0000000187874038
		public void SetEffectBypass(Effect effect, bool bypass) {} // 0x00000001878746E4-0x0000000187874710
		public void UpdateEffectParameters(Effect effect) {} // 0x000000018787446C-0x0000000187874568
		private uint InternalReadDataFromBufferPointers(uint numToRead) => default; // 0x000000018787437C-0x000000018787446C
		private void InternalClearBuffers() {} // 0x00000001878747EC-0x0000000187874898
		private static extern void criAtomMicUnity_Initialize(); // 0x00000001878741FC-0x00000001878742C4
		private static extern void criAtomMicUnity_Finalize(); // 0x00000001878742C4-0x00000001878742F8
		private static extern int criAtomMic_GetNumDevices(); // 0x0000000187874A7C-0x0000000187874AF4
		private static extern bool criAtomMic_GetDevice(int index, out DeviceInfo info); // 0x0000000187874AF4-0x0000000187874B28
		private static extern bool criAtomMic_GetDefaultDevice(out DeviceInfo info); // 0x00000001878746B0-0x00000001878746E4
		private static extern bool criAtomMic_IsFormatSupported(in Config config); // 0x000000018787473C-0x00000001878747B4
		private static extern IntPtr criAtomMic_Create(in Config config, IntPtr work, int work_size); // 0x0000000187874638-0x00000001878746B0
		private static extern void criAtomMic_Destroy(IntPtr mic); // 0x00000001878747B4-0x00000001878747EC
		private static extern void criAtomMic_Start(IntPtr mic); // 0x0000000187874898-0x0000000187874938
		private static extern void criAtomMic_Stop(IntPtr mic); // 0x0000000187874A28-0x0000000187874A7C
		private static extern int criAtomMic_GetNumChannels(IntPtr mic); // 0x0000000187874710-0x000000018787473C
		private static extern int criAtomMic_GetSamplingRate(IntPtr mic); // 0x0000000187874150-0x00000001878741FC
		private static extern uint criAtomMic_GetNumBufferedSamples(IntPtr mic); // 0x00000001878740A0-0x0000000187874150
		private static extern bool criAtomMic_IsAvailable(IntPtr mic); // 0x00000001878742F8-0x000000018787437C
		private static extern uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples); // 0x0000000187874568-0x00000001878745EC
		private static extern void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x0000000187874938-0x00000001878749CC
		private static extern IntPtr criAtomMic_GetOutputReadStream(); // 0x00000001878749CC-0x0000000187874A28
		private static extern int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters); // 0x00000001878745EC-0x0000000187874638
		private static extern IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters, IntPtr work, int work_size); // 0x0000000187874B28-0x0000000187874B6C
		private static extern void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect); // 0x0000000187868C9C-0x0000000187868CEC
		private static extern IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect); // 0x000000018346D130-0x000000018346D140
		private static extern void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass); // 0x0000000185FB2C40-0x0000000185FB2C50
		private static extern void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value); // 0x0000000181377E40-0x0000000181377E50
		private static extern float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index); // 0x0000000181448AC0-0x0000000181448AD0
		private static extern void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect); // 0x0000000185FB2F30-0x0000000185FB2F40
	}

	public class CriAtomExOutputAnalyzer : CriDisposable // TypeDefIndex: 55145
	{
		// Fields
		public const int MaximumSpectrumBands = 512; // Metadata: 0x0207BCFD
		protected IntPtr handle; // 0x20
		protected CriAtomExPlayer player; // 0x28
		protected string busName; // 0x30
		protected int numBands; // 0x38
		protected int numCapturedPcmSamples; // 0x3C
		protected PcmCaptureCallback userPcmCaptureCallback; // 0x40
		protected float[] dataL; // 0x48
		protected float[] dataR; // 0x50
		protected const int pcmCapturerNumMaxData = 512; // Metadata: 0x0207BCFF
		protected static IntPtr InternalCallbackFunctionPointer; // 0x00
		protected static InternalPcmCaptureCallback DelegateObject; // 0x08
		protected static float[] DataL; // 0x10
		protected static float[] DataR; // 0x18
		protected static PcmCaptureCallback UserPcmCaptureCallback; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x00000001878754BC-0x0000000187875564 
	
		// Nested types
		public delegate void PcmCaptureCallback(float[] dataL, float[] dataR, int numChannels, int numData); // TypeDefIndex: 55142; 0x000000018787581C-0x00000001878758AC
	
		public struct Config // TypeDefIndex: 55143
		{
			// Fields
			public bool enableLevelmeter; // 0x00
			public bool enableSpectrumAnalyzer; // 0x01
			public bool enablePcmCapture; // 0x02
			public bool enablePcmCaptureCallback; // 0x03
			public int numSpectrumAnalyzerBands; // 0x04
			public int numCapturedPcmSamples; // 0x08
		}
	
		protected delegate void InternalPcmCaptureCallback(IntPtr dataL, IntPtr dataR, int numChannels, int numData); // TypeDefIndex: 55144; 0x0000000187874F18-0x0000000187875004
	
		// Constructors
		public CriAtomExOutputAnalyzer(Config config) {} // 0x0000000187875564-0x0000000187875650
		protected CriAtomExOutputAnalyzer() {} // 0x00000001878758AC-0x0000000187875904
		static CriAtomExOutputAnalyzer() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		public override void Dispose() {} // 0x00000001878753C4-0x00000001878754BC
		protected void Dispose(bool disposing) {} // 0x0000000185F05C80-0x0000000185F05C90
		public bool AttachExPlayer(CriAtomExPlayer player) => default; // 0x00000001878750F8-0x0000000187875350
		public void DetachExPlayer() {} // 0x00000001878750D4-0x00000001878750F8
		public bool AttachDspBus(string busName) => default; // 0x00000001878757BC-0x000000018787581C
		public void DetachDspBus() {} // 0x0000000187875350-0x00000001878753C4
		public float GetRms(int channel) => default; // 0x0000000187875650-0x000000018787575C
		public void GetSpectrumLevels(ref float[] levels) {} // 0x0000000187874D2C-0x0000000187874E9C
		public void GetPcmData(ref float[] data, int ch) {} // 0x0000000187875948-0x0000000187875A00
		public void SetPcmCaptureCallback(PcmCaptureCallback callback) {} // 0x0000000187875A00-0x0000000187875A34
		public void ExecutePcmCaptureCallback() {} // 0x0000000187875904-0x0000000187875948
		public void ExecutePcmCaptureCallback(PcmCaptureCallback callback) {} // 0x0000000187875A8C-0x0000000187875AD0
		~CriAtomExOutputAnalyzer() {} // 0x0000000187875A34-0x0000000187875A8C
		protected void InitializeWithConfig(Config config) {} // 0x0000000187875BD8-0x0000000187875C14
		private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData) {} // 0x0000000187875C14-0x0000000187875C8C
		protected static extern IntPtr criAtomExOutputAnalyzer_Create(in Config config); // 0x0000000187875B54-0x0000000187875BD8
		protected static extern void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer); // 0x0000000187875AD0-0x0000000187875B54
		protected static extern void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player); // 0x000000018787575C-0x00000001878757BC
		protected static extern void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player); // 0x00000001878948C0-0x0000000187894994
		protected static extern void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName); // 0x00000001832D8120-0x00000001832D8140
		protected static extern void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName); // 0x0000000187894818-0x00000001878948C0
		protected static extern float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel); // 0x00000001864BB614-0x00000001864BB734
		protected static extern IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer); // 0x0000000187894494-0x000000018789455C
		protected static extern IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch); // 0x00000001832D8120-0x00000001832D8140
		protected static extern void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback); // 0x00000001878943D8-0x0000000187894494
	}

	public struct CriAtomExPlayback // TypeDefIndex: 55148
	{
		// Fields
		private uint _id_k__BackingField; // 0x00
		public const uint invalidId = 4294967295; // Metadata: 0x0207BD01
	
		// Properties
		public uint id { get; private set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public Status status { get => default; } // 0x000000018788182C-0x0000000187881838 
		public long time { get => default; } // 0x0000000187881844-0x0000000187881850 
		public long timeSyncedWithAudio { get => default; } // 0x0000000187881838-0x0000000187881844 
	
		// Nested types
		public enum Status // TypeDefIndex: 55146
		{
			Prep = 1,
			Playing = 2,
			Removed = 3
		}
	
		public struct TrackInfo // TypeDefIndex: 55147
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
			<id>k__BackingField = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	
		// Methods
		public void Stop(bool ignoresReleaseTime) {} // 0x00000001878818F0-0x0000000187881954
		public void Pause() {} // 0x0000000187881874-0x0000000187881880
		public void Resume(CriAtomEx.ResumeMode mode) {} // 0x0000000187881880-0x000000018788188C
		public bool IsPaused() => default; // 0x000000018788185C-0x0000000187881868
		public bool GetFormatInfo(out CriAtomEx.FormatInfo info) {
			info = default;
			return default;
		} // 0x0000000187881808-0x0000000187881814
		public Status GetStatus() => default; // 0x000000018788182C-0x0000000187881838
		public long GetTime() => default; // 0x0000000187881844-0x0000000187881850
		public long GetTimeSyncedWithAudio() => default; // 0x0000000187881838-0x0000000187881844
		public bool GetNumPlayedSamples(out long numSamples, out int samplingRate) {
			numSamples = default;
			samplingRate = default;
			return default;
		} // 0x0000000187881814-0x0000000187881820
		public long GetSequencePosition() => default; // 0x0000000187881820-0x000000018788182C
		public int GetCurrentBlockIndex() => default; // 0x00000001878817FC-0x0000000187881808
		public bool GetTrackInfo(out TrackInfo info) {
			info = default;
			return default;
		} // 0x0000000187881850-0x000000018788185C
		public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info) {
			info = default;
			return default;
		} // 0x00000001878817F0-0x00000001878817FC
		public void SetNextBlockIndex(int index) {} // 0x0000000187881898-0x00000001878818A4
		public bool SetBeatSyncOffset(short timeMs) => default; // 0x000000018788188C-0x0000000187881898
		public void Stop() {} // 0x0000000187881954-0x00000001878819A0
		public void StopWithoutReleaseTime() {} // 0x00000001878818A4-0x00000001878818F0
		public void Pause(bool sw) {} // 0x0000000187881868-0x0000000187881874
		private static extern void criAtomExPlayback_Stop(uint id); // 0x0000000187882124-0x000000018788219C
		private static extern void criAtomExPlayback_StopWithoutReleaseTime(uint id); // 0x00000001878820AC-0x0000000187882124
		private static extern void criAtomExPlayback_Pause(uint id, bool sw); // 0x0000000187881EA0-0x0000000187881F24
		private static extern void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode); // 0x0000000187881F24-0x0000000187881FA4
		private static extern bool criAtomExPlayback_IsPaused(uint id); // 0x0000000187881E28-0x0000000187881EA0
		private static extern Status criAtomExPlayback_GetStatus(uint id); // 0x0000000187881CC0-0x0000000187881D38
		private static extern bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info); // 0x0000000187881AA0-0x0000000187881B28
		private static extern long criAtomExPlayback_GetTime(uint id); // 0x0000000187881DB0-0x0000000187881E28
		private static extern long criAtomExPlayback_GetTimeSyncedWithAudio(uint id); // 0x0000000187881D38-0x0000000187881DB0
		private static extern bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate); // 0x0000000187881B28-0x0000000187881BC0
		private static extern long criAtomExPlayback_GetSequencePosition(uint id); // 0x0000000187881C48-0x0000000187881CC0
		private static extern void criAtomExPlayback_SetNextBlockIndex(uint id, int index); // 0x000000018788202C-0x00000001878820AC
		private static extern int criAtomExPlayback_GetCurrentBlockIndex(uint id); // 0x0000000187881A28-0x0000000187881AA0
		private static extern bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info); // 0x0000000187881BC0-0x0000000187881C48
		private static extern bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info); // 0x00000001878819A0-0x0000000187881A28
		private static extern bool criAtomExPlayback_SetBeatSyncOffset(uint id, short timeMs); // 0x0000000187881FA4-0x000000018788202C
	}

	public class CriAtomExPlayer : CriDisposable // TypeDefIndex: 55153
	{
		// Fields
		private CriAtomExBeatSync.CbFunc _onBeatSyncCallback; // 0x20
		private CriAtomExSequencer.EventCallback _onSequenceCallback; // 0x28
		private bool hasExistingNativeHandle; // 0x30
		private IntPtr entryPoolHandle; // 0x38
		private int _entryPoolCapacity; // 0x40
		private int max_path; // 0x44
		private IntPtr handle; // 0x48
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		public bool isAvailable { get => default; } // 0x0000000187885968-0x0000000187885974 
		public int entryPoolCapacity { get => default; } // 0x00000001813ECF10-0x00000001813ECF20 
	
		// Events
		private event CriAtomExBeatSync.CbFunc _onBeatSyncCallback;
		public event CriAtomExBeatSync.CbFunc OnBeatSyncCallback;
		private event CriAtomExSequencer.EventCallback _onSequenceCallback;
		public event CriAtomExSequencer.EventCallback OnSequenceCallback;
	
		// Nested types
		public enum Status // TypeDefIndex: 55149
		{
			Stop = 0,
			Prep = 1,
			Playing = 2,
			PlayEnd = 3,
			Error = 4
		}
	
		private struct Config // TypeDefIndex: 55150
		{
			// Fields
			public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod; // 0x00
			public int maxPathStrings; // 0x04
			public int maxPath; // 0x08
			public int maxAisacs; // 0x0C
			public bool updatesTime; // 0x10
			public bool enableAudioSyncedTimer; // 0x11
		}
	
		public enum TimeStretchParameterId // TypeDefIndex: 55151
		{
			Ratio = 0,
			FrameTime = 1,
			Quality = 2
		}
	
		public enum PitchShifterParameterId // TypeDefIndex: 55152
		{
			Pitch = 0,
			Formant = 1,
			Mode = 2
		}
	
		// Constructors
		public CriAtomExPlayer() {} // 0x0000000187883374-0x0000000187883398
		public CriAtomExPlayer(int maxPath, int maxPathStrings) {} // 0x0000000187883354-0x0000000187883374
		public CriAtomExPlayer(bool enableAudioSyncedTimer) {} // 0x0000000187883330-0x0000000187883354
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer) {} // 0x0000000187883314-0x0000000187883330
		public CriAtomExPlayer(IntPtr existingNativeHandle) {} // 0x00000001878832F0-0x0000000187883314
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle) {} // 0x0000000187883398-0x00000001878834F4
	
		// Methods
		public override void Dispose() {} // 0x00000001878828A8-0x00000001878829BC
		public void SetCue(CriAtomExAcb acb, string name) {} // 0x0000000187882FCC-0x0000000187882FE4
		public void SetCue(CriAtomExAcb acb, int id) {} // 0x0000000187882FE4-0x0000000187882FFC
		public void SetCueIndex(CriAtomExAcb acb, int index) {} // 0x0000000187882FA8-0x0000000187882FC0
		public void SetContentId(CriFsBinder binder, int contentId) {} // 0x0000000187882F90-0x0000000187882FA8
		public void SetFile(CriFsBinder binder, string path) {} // 0x00000001878830C4-0x00000001878830DC
		public void SetData(byte[] buffer, int size) {} // 0x0000000187883008-0x0000000187883014
		public void SetData(IntPtr buffer, int size) {} // 0x0000000187882FFC-0x0000000187883008
		public void SetFormat(CriAtomEx.Format format) {} // 0x00000001878830E8-0x00000001878830F4
		public void SetNumChannels(int numChannels) {} // 0x0000000187883100-0x000000018788310C
		public void SetSamplingRate(int samplingRate) {} // 0x000000018788316C-0x0000000187883178
		public void PrepareEntryPool(int capacity, bool stopOnEmpty) {} // 0x0000000187882E38-0x0000000187882EA4
		public int GetNumEntries() => default; // 0x0000000187882CC4-0x0000000187882CE4
		public int GetNumConsumedEntries() => default; // 0x0000000187882CA4-0x0000000187882CC4
		public bool EntryFile(CriFsBinder binder, string path, bool repeat) => default; // 0x0000000187882A5C-0x0000000187882A90
		public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat) => default; // 0x00000001878829BC-0x00000001878829E8
		public bool EntryData(byte[] buffer, int size, bool repeat) => default; // 0x0000000187882A38-0x0000000187882A5C
		public bool EntryData(IntPtr buffer, int size, bool repeat) => default; // 0x0000000187882A14-0x0000000187882A38
		public bool EntryCue(CriAtomExAcb acb, string name, bool repeat) => default; // 0x00000001878829E8-0x0000000187882A14
		public CriAtomExPlayback Start() => default; // 0x00000001878831EC-0x0000000187883218
		public CriAtomExPlayback Prepare() => default; // 0x0000000187882EA4-0x0000000187882EB0
		public void Stop(bool ignoresReleaseTime) {} // 0x000000018788324C-0x000000018788328C
		public void Pause() {} // 0x0000000187882E1C-0x0000000187882E2C
		public void Resume(CriAtomEx.ResumeMode mode) {} // 0x0000000187882EC8-0x0000000187882ED4
		public bool IsPaused() => default; // 0x0000000187882D2C-0x0000000187882D38
		public void SetVolume(float volume) {} // 0x00000001878831E0-0x00000001878831EC
		public void SetPitch(float pitch) {} // 0x000000018788313C-0x0000000187883148
		public void SetPlaybackRatio(float ratio) {} // 0x0000000187883148-0x0000000187883154
		public void SetPan3dAngle(float angle) {} // 0x000000018788310C-0x0000000187883118
		public void SetPan3dInteriorDistance(float distance) {} // 0x0000000187883118-0x0000000187883124
		public void SetPan3dVolume(float volume) {} // 0x0000000187883124-0x0000000187883130
		public void SetPanType(CriAtomEx.PanType panType) {} // 0x0000000187883130-0x000000018788313C
		public void SetSendLevel(int channel, CriAtomEx.Speaker id, float level) {} // 0x0000000187883184-0x0000000187883198
		public void SetBiquadFilterParameters(CriAtomEx.BiquadFilterType type, float frequency, float gain, float q) {} // 0x0000000187882F34-0x0000000187882F48
		public void SetBandpassFilterParameters(float cofLow, float cofHigh) {} // 0x0000000187882F28-0x0000000187882F34
		public void SetBusSendLevel(string busName, float level) {} // 0x0000000187882F60-0x0000000187882F6C
		public bool GetBusSendLevel(string busName, out float level) {
			level = default;
			return default;
		} // 0x0000000187882C98-0x0000000187882CA4
		public void SetBusSendLevel(int busId, float level) {} // 0x0000000187882F6C-0x0000000187882F78
		public void SetBusSendLevelOffset(string busName, float levelOffset) {} // 0x0000000187882F48-0x0000000187882F54
		public bool GetBusSendLevelOffset(string busName, out float level) {
			level = default;
			return default;
		} // 0x0000000187882C8C-0x0000000187882C98
		public void SetBusSendLevelOffset(int busId, float levelOffset) {} // 0x0000000187882F54-0x0000000187882F60
		public void AttachAisac(string globalAisacName) {} // 0x00000001878822BC-0x00000001878822C8
		public void DetachAisac(string globalAisacName) {} // 0x0000000187882860-0x000000018788286C
		public void SetAisacControl(string controlName, float value) {} // 0x0000000187882F04-0x0000000187882F10
		public void SetAisac(string controlName, float value) {} // 0x0000000187882F04-0x0000000187882F10
		public void SetAisacControl(uint controlId, float value) {} // 0x0000000187882F10-0x0000000187882F1C
		public void SetAisac(uint controlId, float value) {} // 0x0000000187882F10-0x0000000187882F1C
		public bool GetAttachedAisacInfo(int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
			aisacInfo = default;
			return default;
		} // 0x0000000187882A90-0x0000000187882C8C
		public void Set3dSource(CriAtomEx3dSource source) {} // 0x0000000187882EEC-0x0000000187882F04
		public void Set3dListener(CriAtomEx3dListener listener) {} // 0x0000000187882ED4-0x0000000187882EEC
		public void SetStartTime(long startTimeMs) {} // 0x00000001878831B0-0x00000001878831BC
		public void SetFirstBlockIndex(int index) {} // 0x00000001878830DC-0x00000001878830E8
		public void SetSelectorLabel(string selector, string label) {} // 0x0000000187883178-0x0000000187883184
		public void UnsetSelectorLabel(string selector) {} // 0x00000001878832CC-0x00000001878832D8
		public void ClearSelectorLabels() {} // 0x0000000187882854-0x0000000187882860
		public void SetCategory(int categoryId) {} // 0x0000000187882F78-0x0000000187882F84
		public void SetCategory(string categoryName) {} // 0x0000000187882F84-0x0000000187882F90
		public void UnsetCategory() {} // 0x00000001878832C0-0x00000001878832CC
		public void SetCuePriority(int priority) {} // 0x0000000187882FC0-0x0000000187882FCC
		public void SetVoicePriority(int priority) {} // 0x00000001878831D4-0x00000001878831E0
		public void SetVoiceControlMethod(CriAtomEx.VoiceControlMethod method) {} // 0x00000001878831BC-0x00000001878831C8
		public void SetPreDelayTime(float time) {} // 0x0000000187883154-0x0000000187883160
		public void SetEnvelopeAttackTime(float time) {} // 0x0000000187883058-0x0000000187883064
		public void SetEnvelopeHoldTime(float time) {} // 0x0000000187883070-0x000000018788307C
		public void SetEnvelopeDecayTime(float time) {} // 0x0000000187883064-0x0000000187883070
		public void SetEnvelopeReleaseTime(float time) {} // 0x000000018788307C-0x0000000187883088
		public void SetEnvelopeSustainLevel(float level) {} // 0x0000000187883088-0x0000000187883094
		public void AttachFader() {} // 0x00000001878822C8-0x00000001878822EC
		public void DetachFader() {} // 0x000000018788286C-0x0000000187882878
		public void SetFadeOutTime(int ms) {} // 0x00000001878830B8-0x00000001878830C4
		public void SetFadeInTime(int ms) {} // 0x00000001878830A0-0x00000001878830AC
		public void SetFadeInStartOffset(int ms) {} // 0x0000000187883094-0x00000001878830A0
		public void SetFadeOutEndDelay(int ms) {} // 0x00000001878830AC-0x00000001878830B8
		public bool IsFading() => default; // 0x0000000187882D20-0x0000000187882D2C
		public void ResetFaderParameters() {} // 0x0000000187882EB0-0x0000000187882EBC
		public void SetGroupNumber(int group_no) {} // 0x00000001878830F4-0x0000000187883100
		public void Update(CriAtomExPlayback playback) {} // 0x00000001878832E4-0x00000001878832F0
		public void UpdateAll() {} // 0x00000001878832D8-0x00000001878832E4
		public void ResetParameters() {} // 0x0000000187882EBC-0x0000000187882EC8
		public long GetTime() => default; // 0x0000000187882D14-0x0000000187882D20
		public Status GetStatus() => default; // 0x0000000187882D08-0x0000000187882D14
		public float GetParameterFloat32(CriAtomEx.Parameter id) => default; // 0x0000000187882CE4-0x0000000187882CF0
		public uint GetParameterUint32(CriAtomEx.Parameter id) => default; // 0x0000000187882CFC-0x0000000187882D08
		public int GetParameterSint32(CriAtomEx.Parameter id) => default; // 0x0000000187882CF0-0x0000000187882CFC
		public void SetSoundRendererType(CriAtomEx.SoundRendererType type) {} // 0x00000001878831A4-0x00000001878831B0
		public void SetRandomSeed(uint seed) {} // 0x0000000187883160-0x000000018788316C
		public void Loop(bool sw) {} // 0x0000000187882D38-0x0000000187882DB4
		public void SetAsrRackId(int asr_rack_id) {} // 0x0000000187882F1C-0x0000000187882F28
		public void SetVoicePoolIdentifier(uint identifier) {} // 0x00000001878831C8-0x00000001878831D4
		public void SetDspTimeStretchRatio(float ratio) {} // 0x0000000187883044-0x0000000187883058
		public void SetDspPitchShifterPitch(float pitch) {} // 0x0000000187883020-0x0000000187883044
		public void SetDspParameter(int id, float value) {} // 0x0000000187883014-0x0000000187883020
		public void SetSequencePrepareTime(uint ms) {} // 0x0000000187883198-0x00000001878831A4
		public void AttachTween(CriAtomExTween tween) {} // 0x00000001878822EC-0x0000000187882310
		public void DetachTween(CriAtomExTween tween) {} // 0x0000000187882884-0x00000001878828A8
		public void DetachTweenAll() {} // 0x0000000187882878-0x0000000187882884
		public void Stop() {} // 0x000000018788328C-0x00000001878832C0
		public void StopWithoutReleaseTime() {} // 0x0000000187883218-0x000000018788324C
		public void Pause(bool sw) {} // 0x0000000187882E2C-0x0000000187882E38
		~CriAtomExPlayer() {} // 0x00000001878707A8-0x000000018787081C
		private void OnBeatSyncCallbackChainInternal(ref CriAtomExBeatSync.Info info) {} // 0x0000000187882DB4-0x0000000187882DE8
		private void OnSequenceCallbackChainInternal(ref CriAtomExSequencer.CriAtomExSequenceEventInfo info) {} // 0x0000000187882DE8-0x0000000187882E1C
		private static extern IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size); // 0x000000018788394C-0x0000000187883A60
		private static extern void criAtomExPlayer_Destroy(IntPtr player); // 0x0000000187883A60-0x0000000187883A94
		private static extern void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id); // 0x0000000187884898-0x000000018788492C
		private static extern void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name); // 0x00000001878849C0-0x0000000187884A68
		private static extern void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index); // 0x000000018788492C-0x00000001878849C0
		private static extern void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path); // 0x0000000187884EB4-0x0000000187884F5C
		private static extern void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size); // 0x0000000187884B3C-0x0000000187884BDC
		private static extern void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size); // 0x0000000187884AA8-0x0000000187884B3C
		private static extern void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id); // 0x0000000187884804-0x0000000187884898
		private static extern void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier); // 0x0000000187885644-0x0000000187885684
		private static extern uint criAtomExPlayer_Start(IntPtr player); // 0x0000000187885744-0x00000001878857BC
		private static extern uint criAtomExPlayer_Prepare(IntPtr player); // 0x0000000187884134-0x00000001878841AC
		private static extern void criAtomExPlayer_Stop(IntPtr player); // 0x00000001878857F0-0x0000000187885824
		private static extern void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player); // 0x00000001878857BC-0x00000001878857F0
		private static extern void criAtomExPlayer_Pause(IntPtr player, bool sw); // 0x00000001878840B0-0x0000000187884134
		private static extern void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode); // 0x0000000187884258-0x00000001878842DC
		private static extern bool criAtomExPlayer_IsPaused(IntPtr player); // 0x0000000187884038-0x0000000187884070
		private static extern Status criAtomExPlayer_GetStatus(IntPtr player); // 0x0000000187883F54-0x0000000187883F88
		private static extern long criAtomExPlayer_GetTime(IntPtr player); // 0x0000000187883F88-0x0000000187884000
		private static extern void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format); // 0x0000000187884F9C-0x0000000187885020
		private static extern void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels); // 0x0000000187885060-0x00000001878850A0
		private static extern void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate); // 0x0000000187885320-0x00000001878853A4
		private static extern IntPtr CRIWAREF1DB6C3C(IntPtr player, int capacity, int max_path, bool stopOnEmpty); // 0x00000001878826F8-0x000000018788279C
		private static extern void CRIWARE348B99F2(IntPtr pool); // 0x000000018788242C-0x0000000187882460
		private static extern int CRIWAREB0CA8CB3(IntPtr pool); // 0x0000000187882690-0x00000001878826C4
		private static extern int CRIWAREF2104D05(IntPtr pool); // 0x000000018788279C-0x00000001878827D0
		private static extern void CRIWAREBAFBC575(IntPtr pool); // 0x00000001878826C4-0x00000001878826F8
		private static extern bool CRIWARE5277731E(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path); // 0x0000000187882460-0x0000000187882530
		private static extern bool CRIWARE78E74FE0(IntPtr pool, IntPtr binder, int id, bool repeat); // 0x00000001878825F4-0x000000018788265C
		private static extern bool CRIWARE10CB0D07(IntPtr pool, byte[] buffer, int size, bool repeat); // 0x0000000187882310-0x00000001878823C4
		private static extern bool CRIWARE10CB0D07(IntPtr pool, IntPtr buffer, int size, bool repeat); // 0x00000001878823C4-0x000000018788242C
		private static extern bool CRIWARE59CCEB17(IntPtr pool, IntPtr acbhn, string name, bool repeat); // 0x0000000187882530-0x00000001878825F4
		private static extern void CRIWARE94DBB2A3(IntPtr pool); // 0x000000018788265C-0x0000000187882690
		private static extern void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms); // 0x000000018788553C-0x00000001878855C0
		private static extern void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms); // 0x00000001878854BC-0x00000001878854FC
		private static extern void criAtomExPlayer_LimitLoopCount(IntPtr player, int count); // 0x0000000187884070-0x00000001878840B0
		private static extern void criAtomExPlayer_Update(IntPtr player, uint id); // 0x00000001878858E4-0x0000000187885968
		private static extern void criAtomExPlayer_UpdateAll(IntPtr player); // 0x00000001878858B0-0x00000001878858E4
		private static extern void criAtomExPlayer_ResetParameters(IntPtr player); // 0x0000000187884224-0x0000000187884258
		private static extern float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id); // 0x0000000187883D98-0x0000000187883DD4
		private static extern uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id); // 0x0000000187883E58-0x0000000187883EDC
		private static extern int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id); // 0x0000000187883DD4-0x0000000187883E58
		private static extern IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player); // 0x0000000187883EDC-0x0000000187883F54
		private static extern void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, ushort id); // 0x0000000187883754-0x00000001878837D8
		private static extern void criAtomExPlayer_SetVolume(IntPtr player, float volume); // 0x0000000187885708-0x0000000187885744
		private static extern void criAtomExPlayer_SetPitch(IntPtr player, float pitch); // 0x00000001878851E8-0x0000000187885224
		private static extern void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio); // 0x0000000187885224-0x0000000187885260
		private static extern void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle); // 0x00000001878850A0-0x00000001878850DC
		private static extern void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance); // 0x00000001878850DC-0x0000000187885120
		private static extern void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume); // 0x0000000187885120-0x0000000187885164
		private static extern void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType panType); // 0x0000000187885164-0x00000001878851E8
		private static extern void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level); // 0x0000000187885460-0x00000001878854BC
		private static extern void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level); // 0x0000000187884698-0x00000001878846E8
		private static extern void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level); // 0x0000000187884584-0x00000001878845EC
		private static extern bool criAtomExPlayer_GetBusSendLevelByName(IntPtr player, string bus_name, out float level); // 0x0000000187883C30-0x0000000187883CE4
		private static extern void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset); // 0x000000018788464C-0x0000000187884698
		private static extern void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset); // 0x00000001878845EC-0x000000018788464C
		private static extern bool criAtomExPlayer_GetBusSendLevelOffsetByName(IntPtr player, string bus_name, out float level_offset); // 0x0000000187883CE4-0x0000000187883D98
		private static extern void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high); // 0x00000001878844DC-0x0000000187884528
		private static extern void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q); // 0x0000000187884528-0x0000000187884584
		private static extern void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority); // 0x0000000187885684-0x0000000187885708
		private static extern void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method); // 0x00000001878855C0-0x0000000187885644
		private static extern void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value); // 0x00000001878843A4-0x00000001878843F0
		private static extern void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value); // 0x00000001878843F0-0x0000000187884458
		private static extern void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source); // 0x0000000187884320-0x00000001878843A4
		private static extern void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener); // 0x00000001878842DC-0x0000000187884320
		private static extern void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id); // 0x00000001878846E8-0x000000018788476C
		private static extern void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name); // 0x000000018788476C-0x0000000187884804
		private static extern void criAtomExPlayer_UnsetCategory(IntPtr player); // 0x0000000187885824-0x0000000187885858
		private static extern void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority); // 0x0000000187884A68-0x0000000187884AA8
		private static extern void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms); // 0x0000000187885260-0x000000018788529C
		private static extern void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms); // 0x0000000187884C2C-0x0000000187884C70
		private static extern void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms); // 0x0000000187884CAC-0x0000000187884CE8
		private static extern void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms); // 0x0000000187884C70-0x0000000187884CAC
		private static extern void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms); // 0x0000000187884CE8-0x0000000187884D2C
		private static extern void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level); // 0x0000000187884D2C-0x0000000187884D70
		private static extern void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size); // 0x0000000187883830-0x00000001878838D4
		private static extern void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName); // 0x00000001878837D8-0x0000000187883830
		private static extern void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName); // 0x0000000187883A94-0x0000000187883AEC
		private static extern void criAtomExPlayer_DetachFader(IntPtr player); // 0x0000000187883AEC-0x0000000187883B20
		private static extern void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms); // 0x0000000187884E74-0x0000000187884EB4
		private static extern void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms); // 0x0000000187884DB0-0x0000000187884E34
		private static extern void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms); // 0x0000000187884D70-0x0000000187884DB0
		private static extern void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms); // 0x0000000187884E34-0x0000000187884E74
		private static extern bool criAtomExPlayer_IsFading(IntPtr player); // 0x0000000187884000-0x0000000187884038
		private static extern void criAtomExPlayer_ResetFaderParameters(IntPtr player); // 0x00000001878841AC-0x0000000187884224
		private static extern void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no); // 0x0000000187885020-0x0000000187885060
		private static extern bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info); // 0x0000000187883B98-0x0000000187883C30
		private static extern void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index); // 0x0000000187884F5C-0x0000000187884F9C
		private static extern void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label); // 0x00000001878853A4-0x0000000187885460
		private static extern void criAtomExPlayer_UnsetSelectorLabel(IntPtr player, string selector); // 0x0000000187885858-0x00000001878858B0
		private static extern void criAtomExPlayer_ClearSelectorLabels(IntPtr player); // 0x0000000187883918-0x000000018788394C
		private static extern void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type); // 0x00000001878854FC-0x000000018788553C
		private static extern void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed); // 0x000000018788529C-0x0000000187885320
		private static extern void CRIWAREF466419F(IntPtr player, bool sw); // 0x00000001878827D0-0x0000000187882854
		private static extern void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id); // 0x0000000187884458-0x00000001878844DC
		private static extern void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value); // 0x0000000187884BDC-0x0000000187884C2C
		private static extern void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween); // 0x00000001878838D4-0x0000000187883918
		private static extern void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween); // 0x0000000187883B54-0x0000000187883B98
		private static extern void criAtomExPlayer_DetachTweenAll(IntPtr player); // 0x0000000187883B20-0x0000000187883B54
	}

	public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer // TypeDefIndex: 55156
	{
		// Nested types
		public enum Type // TypeDefIndex: 55154
		{
			LevelMeter = 0,
			SpectrumAnalyzer = 1,
			PcmCapture = 2
		}
	
		public struct Config // TypeDefIndex: 55155
		{
			// Fields
			public int num_spectrum_analyzer_bands; // 0x00
			public int num_stored_output_data; // 0x04
	
			// Constructors
			public Config(int num_spectrum_analyzer_bands = 8 /* Metadata: 0x0207BD13 */, int num_stored_output_data = 4096 /* Metadata: 0x0207BD14 */) {
				this.num_spectrum_analyzer_bands = default;
				this.num_stored_output_data = default;
			} // 0x000000018788219C-0x00000001878822BC
		}
	
		// Constructors
		public CriAtomExPlayerOutputAnalyzer() {} // Dummy constructor
		public CriAtomExPlayerOutputAnalyzer(Type[] types, Config[] configs = null) {} // 0x000000018357CB90-0x000000018357CBA0
	}

	public class CriAtomExSoundObject : CriDisposable // TypeDefIndex: 55158
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
	
		// Nested types
		private struct Config // TypeDefIndex: 55157
		{
			// Fields
			public bool enableVoiceLimitScope; // 0x00
			public bool enableCategoryCueLimitScope; // 0x01
		}
	
		// Constructors
		public CriAtomExSoundObject() {} // Dummy constructor
		public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope) {} // 0x0000000187885E4C-0x0000000187885F50
	
		// Methods
		public override void Dispose() {} // 0x0000000187885DD0-0x0000000187885E4C
		public void AddPlayer(CriAtomExPlayer player) {} // 0x0000000187885D7C-0x0000000187885DA0
		public void DeletePlayer(CriAtomExPlayer player) {} // 0x0000000187885DAC-0x0000000187885DD0
		public void DeleteAllPlayers() {} // 0x0000000187885DA0-0x0000000187885DAC
		~CriAtomExSoundObject() {} // 0x00000001878707A8-0x000000018787081C
		private static extern IntPtr criAtomExSoundObject_Create(ref Config config, IntPtr work, int work_size); // 0x0000000187885FD4-0x0000000187886098
		private static extern void criAtomExSoundObject_Destroy(IntPtr soundObject); // 0x0000000187886154-0x0000000187886188
		private static extern void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player); // 0x0000000187885F50-0x0000000187885FD4
		private static extern void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player); // 0x0000000187886110-0x0000000187886154
		private static extern void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject); // 0x0000000187886098-0x0000000187886110
	}

	public class CriAtomExTween : CriDisposable // TypeDefIndex: 55162
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		internal IntPtr nativeHandle { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public float Value { get => default; } // 0x00000001878868E4-0x00000001878868F0 
		public bool IsActive { get => default; } // 0x00000001878868D8-0x00000001878868E4 
	
		// Nested types
		public enum ParameterType // TypeDefIndex: 55159
		{
			Basic = 0,
			Aisac = 1
		}
	
		private struct Config // TypeDefIndex: 55161
		{
			// Fields
			public Target target; // 0x00
			public ParameterType parameterType; // 0x04
	
			// Nested types
			public struct Target // TypeDefIndex: 55160
			{
				// Fields
				public CriAtomEx.Parameter parameterId; // 0x00
				public uint aisacIds; // 0x00
			}
		}
	
		// Constructors
		public CriAtomExTween() {} // 0x00000001878864F4-0x0000000187886504
		public CriAtomExTween(CriAtomEx.Parameter parameterId) {} // 0x0000000187886614-0x0000000187886624
		public CriAtomExTween(uint aisacId) {} // 0x0000000187886604-0x0000000187886614
		public CriAtomExTween(ParameterType parameterType, uint targetId) {} // 0x0000000187886504-0x0000000187886604
	
		// Methods
		public override void Dispose() {} // 0x00000001878863B8-0x00000001878863C4
		public void MoveTo(ushort durationMs, float value) {} // 0x00000001878864D0-0x00000001878864DC
		public void MoveFrom(ushort durationMs, float value) {} // 0x00000001878864C4-0x00000001878864D0
		public void Stop() {} // 0x00000001878864E8-0x00000001878864F4
		public void Reset() {} // 0x00000001878864DC-0x00000001878864E8
		~CriAtomExTween() {} // 0x0000000187886450-0x00000001878864C4
		protected virtual void Dispose(bool disposing) {} // 0x00000001878863C4-0x0000000187886450
		private static extern IntPtr criAtomExTween_Create(ref Config config, IntPtr work, int work_size); // 0x0000000187886624-0x00000001878866B8
		private static extern void criAtomExTween_Destroy(IntPtr tween); // 0x00000001878866B8-0x0000000187886730
		private static extern float criAtomExTween_GetValue(IntPtr tween); // 0x0000000187886730-0x000000018788675C
		private static extern void criAtomExTween_MoveTo(IntPtr tween, ushort time_ms, float value); // 0x00000001878867E0-0x000000018788682C
		private static extern void criAtomExTween_MoveFrom(IntPtr tween, ushort time_ms, float value); // 0x0000000187886794-0x00000001878867E0
		private static extern void criAtomExTween_Stop(IntPtr tween); // 0x0000000187886860-0x00000001878868D8
		private static extern void criAtomExTween_Reset(IntPtr tween); // 0x000000018788682C-0x0000000187886860
		private static extern bool criAtomExTween_IsActive(IntPtr tween); // 0x000000018788675C-0x0000000187886794
	}

	public abstract class CriAtomExVoicePool : CriDisposable // TypeDefIndex: 55172
	{
		// Fields
		public const int StandardMemoryAsrVoicePoolId = 0; // Metadata: 0x0207BD1C
		public const int StandardStreamingAsrVoicePoolId = 1; // Metadata: 0x0207BD1D
		public const int StandardMemoryNsrVoicePoolId = 2; // Metadata: 0x0207BD1E
		public const int StandardStreamingNsrVoicePoolId = 3; // Metadata: 0x0207BD1F
		protected IntPtr _handle; // 0x20
		protected uint _identifier; // 0x28
		protected int _numVoices; // 0x2C
		protected int _maxChannels; // 0x30
		protected int _maxSamplingRate; // 0x34
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public uint identifier { get; } // 0x0000000181C9AC80-0x0000000181C9AC90 
		public int numVoices { get; } // 0x0000000185FB0630-0x0000000185FB0640 
		public int maxChannels { get; } // 0x00000001813CFF60-0x00000001813CFF70 
		public int maxSamplingRate { get; } // 0x0000000185FB07C0-0x0000000185FB07D0 
	
		// Nested types
		public enum VoicePoolId // TypeDefIndex: 55163
		{
			StandardMemory = 0,
			StandardStreaming = 1,
			HcaMxMemory = 4,
			HcaMxStreaming = 5
		}
	
		public enum PitchShifterMode // TypeDefIndex: 55164
		{
			Music = 0,
			Vocal = 1,
			SoundEffect = 2,
			Speech = 3
		}
	
		public struct UsedVoicesInfo // TypeDefIndex: 55165
		{
			// Fields
			public int numUsedVoices; // 0x00
			public int numPoolVoices; // 0x04
		}
	
		protected struct PlayerConfig // TypeDefIndex: 55166
		{
			// Fields
			public int maxChannels; // 0x00
			public int maxSamplingRate; // 0x04
			public bool streamingFlag; // 0x08
			public int soundRendererType; // 0x0C
			public int decodeLatency; // 0x10
			private IntPtr context; // 0x18
		}
	
		protected struct VoicePoolConfig // TypeDefIndex: 55167
		{
			// Fields
			public uint identifier; // 0x00
			public int numVoices; // 0x04
			public PlayerConfig playerConfig; // 0x08
		}
	
		private struct PitchShifterConfig // TypeDefIndex: 55168
		{
			// Fields
			public int mode; // 0x00
			public int windowSize; // 0x04
			public int overlapTimes; // 0x08
		}
	
		private struct ExPitchShifterConfig // TypeDefIndex: 55169
		{
			// Fields
			public int numDsp; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public PitchShifterConfig config; // 0x0C
		}
	
		private struct TimeStretchConfig // TypeDefIndex: 55170
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private struct ExTimeStretchConfig // TypeDefIndex: 55171
		{
			// Fields
			public int numDsp; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public TimeStretchConfig config; // 0x0C
		}
	
		// Constructors
		protected CriAtomExVoicePool() {} // 0x0000000187886B04-0x0000000187886B14
	
		// Methods
		public static UsedVoicesInfo GetNumUsedVoices(VoicePoolId voicePoolId) => default; // 0x0000000187886AA4-0x0000000187886AD0
		public override void Dispose() {} // 0x0000000187886A28-0x0000000187886AA4
		public UsedVoicesInfo GetNumUsedVoices() => default; // 0x0000000187886AD0-0x0000000187886B04
		public void AttachDspTimeStretch() {} // 0x000000018788693C-0x0000000187886980
		public void AttachDspPitchShifter(PitchShifterMode mode = PitchShifterMode.Music /* Metadata: 0x0207BD18 */, int windosSize = 1024 /* Metadata: 0x0207BD19 */, int overlapTimes = 4 /* Metadata: 0x0207BD1B */) {} // 0x00000001878868F0-0x000000018788693C
		public void DetachDsp() {} // 0x0000000187886A14-0x0000000187886A28
		~CriAtomExVoicePool() {} // 0x00000001878707A8-0x000000018787081C
		private static extern void CRIWARED389B244(int voice_pool_id, out int num_used_voices, out int num_pool_voices); // 0x0000000187886980-0x0000000187886A14
		private static extern void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices); // 0x0000000187886CC4-0x0000000187886D58
		public static extern void criAtomExVoicePool_Free(IntPtr pool); // 0x0000000187886C90-0x0000000187886CC4
		private static extern void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref ExTimeStretchConfig config, IntPtr work, int work_size); // 0x0000000187886BB8-0x0000000187886C5C
		private static extern void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref ExPitchShifterConfig config, IntPtr work, int work_size); // 0x0000000187886B14-0x0000000187886BB8
		private static extern void criAtomExVoicePool_DetachDsp(IntPtr pool); // 0x0000000187886C5C-0x0000000187886C90
	}

	public class CriAtomExStandardVoicePool : CriAtomExVoicePool // TypeDefIndex: 55173
	{
		// Constructors
		public CriAtomExStandardVoicePool() {} // Dummy constructor
		public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x0207BD28 */) {} // 0x0000000187886188-0x00000001878862B4
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x00000001878862B4-0x00000001878863B8
	}

	public class CriAtomExWaveVoicePool : CriAtomExVoicePool // TypeDefIndex: 55174
	{
		// Constructors
		public CriAtomExWaveVoicePool() {} // Dummy constructor
		public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x0207BD29 */) {} // 0x0000000187886D58-0x0000000187886E84
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x0000000187886E84-0x0000000187886F88
	}

	public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool // TypeDefIndex: 55178
	{
		// Nested types
		public enum RawPcmFormat // TypeDefIndex: 55175
		{
			Sint16 = 0,
			Float32 = 1
		}
	
		protected struct RawPcmPlayerConfig // TypeDefIndex: 55176
		{
			// Fields
			public RawPcmFormat format; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public int soundRendererType; // 0x0C
			public int decodeLatency; // 0x10
			private IntPtr context; // 0x18
		}
	
		protected struct RawPcmVoicePoolConfig // TypeDefIndex: 55177
		{
			// Fields
			public uint identifier; // 0x00
			public int numVoices; // 0x04
			public RawPcmPlayerConfig playerConfig; // 0x08
		}
	
		// Constructors
		public CriAtomExRawPcmVoicePool() {} // Dummy constructor
		public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, RawPcmFormat format, uint identifier = 0 /* Metadata: 0x0207BD2A */) {} // 0x0000000187885BC4-0x0000000187885CEC
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref RawPcmVoicePoolConfig config, IntPtr work, int work_size); // 0x0000000187885CEC-0x0000000187885D7C
	}

	public class CriAudioReadStream // TypeDefIndex: 55182
	{
		// Fields
		private InternalDelegate internalDelegate; // 0x10
		private IntPtr _callbackFunction_k__BackingField; // 0x18
		private IntPtr _callbackPointer_k__BackingField; // 0x20
	
		// Properties
		public IntPtr callbackFunction { get; private set; } // 0x0000000187893D6C-0x0000000187893E40 0x0000000181B59400-0x0000000181B59410
		public IntPtr callbackPointer { get; private set; } // 0x0000000187893C6C-0x0000000187893CEC 0x0000000186477E54-0x0000000186477F84
	
		// Nested types
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 55179; 0x0000000181448AC0-0x0000000181448AD0
	
		public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 55180; 0x0000000187886F88-0x0000000187887108
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 55181
		{
			// Fields
			public int bufferSize; // 0x10
			public CriWare.CriAudioReadStream.Delegate callback; // 0x18
			public int numChannels; // 0x20
			public float[][] buffer; // 0x28
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x000000018789426C-0x0000000187894310
	
			// Methods
			internal uint _.ctor_b__0(IntPtr cbobj, IntPtr data, uint numSamples) => default; // 0x0000000186477E54-0x0000000186477F84
		}
	
		// Constructors
		public CriAudioReadStream() {} // Dummy constructor
		public CriAudioReadStream(IntPtr callbackFunction, IntPtr callbackPointer) {} // 0x0000000185492010-0x0000000185492020
		public CriAudioReadStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x0207BD2D */) {} // 0x0000000187894E4C-0x0000000187894F3C
	}

	public class CriAudioWriteStream // TypeDefIndex: 55186
	{
		// Fields
		private InternalDelegate internalDelegate; // 0x10
		private IntPtr _callbackFunction_k__BackingField; // 0x18
		private IntPtr _callbackPointer_k__BackingField; // 0x20
	
		// Properties
		public IntPtr callbackFunction { get; private set; } // 0x0000000187893D6C-0x0000000187893E40 0x0000000181B59400-0x0000000181B59410
		public IntPtr callbackPointer { get; private set; } // 0x0000000187893CEC-0x0000000187893D6C 0x0000000186477E54-0x0000000186477F84
	
		// Nested types
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 55183; 0x0000000181448AC0-0x0000000181448AD0
	
		public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 55184; 0x0000000187887108-0x0000000187887288
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 55185
		{
			// Fields
			public int bufferSize; // 0x10
			public int numChannels; // 0x14
			public CriWare.CriAudioWriteStream.Delegate callback; // 0x18
			public float[][] buffer; // 0x20
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x00000001878941C8-0x000000018789426C
	
			// Methods
			internal uint _.ctor_b__0(IntPtr cbobj, IntPtr data, uint numSamples) => default; // 0x0000000186477E54-0x0000000186477F84
		}
	
		// Constructors
		public CriAudioWriteStream() {} // Dummy constructor
		public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer) {} // 0x0000000185492010-0x0000000185492020
		public CriAudioWriteStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x0207BD2F */) {} // 0x0000000187894D70-0x0000000187894E4C
	}

	public class CriFsLoader : CriDisposable // TypeDefIndex: 55188
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle dstGch; // 0x28
		private GCHandle srcGch; // 0x30
	
		// Nested types
		public enum Status // TypeDefIndex: 55187
		{
			Stop = 0,
			Loading = 1,
			Complete = 2,
			Error = 3
		}
	
		// Constructors
		public CriFsLoader() {} // 0x000000018788AE34-0x000000018788AF64
	
		// Methods
		public override void Dispose() {} // 0x000000018788AA28-0x000000018788AA78
		private void Dispose(bool disposing) {} // 0x000000018788A998-0x000000018788AA28
		public void Load(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer) {} // 0x000000018788AD58-0x000000018788AE08
		public void LoadById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer) {} // 0x000000018788AB48-0x000000018788ABF8
		public void LoadWithoutDecompression(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer) {} // 0x000000018788ACA8-0x000000018788AD58
		public void LoadWithoutDecompressionById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer) {} // 0x000000018788ABF8-0x000000018788ACA8
		public void DecompressData(long srcSize, byte[] srcBuffer, long dstSize, byte[] dstBuffer) {} // 0x000000018788A8F4-0x000000018788A998
		public void Stop() {} // 0x000000018788AE20-0x000000018788AE34
		public Status GetStatus() => default; // 0x000000018788AAEC-0x000000018788AB48
		public void SetReadUnitSize(int unit_size) {} // 0x000000018788AE08-0x000000018788AE20
		~CriFsLoader() {} // 0x000000018788AA78-0x000000018788AAEC
		private static extern int criFsLoader_Create(out IntPtr loader); // 0x000000018788AF64-0x000000018788AFDC
		private static extern int criFsLoader_Destroy(IntPtr loader); // 0x000000018788B080-0x000000018788B0B4
		private static extern int criFsLoader_Load(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x000000018788B368-0x000000018788B450
		private static extern int criFsLoader_LoadById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x000000018788B138-0x000000018788B1DC
		private static extern int criFsLoader_Stop(IntPtr loader); // 0x000000018788B4D4-0x000000018788B54C
		private static extern int criFsLoader_GetStatus(IntPtr loader, out Status status); // 0x000000018788B0B4-0x000000018788B138
		private static extern int criFsLoader_SetReadUnitSize(IntPtr loader, long unit_size); // 0x000000018788B450-0x000000018788B4D4
		private static extern int criFsLoader_LoadWithoutDecompression(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x000000018788B280-0x000000018788B368
		private static extern int criFsLoader_LoadWithoutDecompressionById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x000000018788B1DC-0x000000018788B280
		private static extern int criFsLoader_DecompressData(IntPtr loader, IntPtr src, long src_size, IntPtr dst, long dst_size); // 0x000000018788AFDC-0x000000018788B080
	}

	public class CriFsInstaller : CriDisposable // TypeDefIndex: 55191
	{
		// Fields
		private byte[] installBuffer; // 0x20
		private GCHandle installBufferGch; // 0x28
		private IntPtr handle; // 0x30
	
		// Nested types
		public enum Status // TypeDefIndex: 55189
		{
			Stop = 0,
			Busy = 1,
			Complete = 2,
			Error = 3
		}
	
		private enum CopyPolicy // TypeDefIndex: 55190
		{
			Always = 0
		}
	
		// Constructors
		public CriFsInstaller() {} // 0x0000000187889DC0-0x0000000187889EF4
	
		// Methods
		public override void Dispose() {} // 0x0000000187889BF8-0x0000000187889C48
		private void Dispose(bool disposing) {} // 0x0000000187889C48-0x0000000187889CD4
		public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize) {} // 0x00000001878899C8-0x0000000187889BF8
		public void Stop() {} // 0x0000000187889DAC-0x0000000187889DC0
		public Status GetStatus() => default; // 0x0000000187889D80-0x0000000187889DAC
		public float GetProgress() => default; // 0x0000000187889D50-0x0000000187889D80
		public static void ExecuteMain() {} // 0x0000000187889CD4-0x0000000187889CDC
		~CriFsInstaller() {} // 0x0000000187889CDC-0x0000000187889D50
		private static extern int criFsInstaller_ExecuteMain(); // 0x000000018788A0A4-0x000000018788A0D0
		private static extern int criFsInstaller_Create(out IntPtr installer, CopyPolicy option); // 0x0000000187889FEC-0x000000018788A070
		private static extern int criFsInstaller_Destroy(IntPtr installer); // 0x000000018788A070-0x000000018788A0A4
		private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size); // 0x0000000187889EF4-0x0000000187889FEC
		private static extern int criFsInstaller_Stop(IntPtr installer); // 0x000000018788A1D8-0x000000018788A20C
		private static extern int criFsInstaller_GetStatus(IntPtr installer, out Status status); // 0x000000018788A154-0x000000018788A1D8
		private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress); // 0x000000018788A0D0-0x000000018788A154
	}

	public class CriFsBinder : CriDisposable // TypeDefIndex: 55194
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get => default; } // 0x00000001878883F8-0x000000018788846C 
	
		// Nested types
		public enum Status // TypeDefIndex: 55192
		{
			None = 0,
			Analyze = 1,
			Complete = 2,
			Unbind = 3,
			Removed = 4,
			Invalid = 5,
			Error = 6
		}
	
		public struct ContentsFileInfo // TypeDefIndex: 55193
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
			} // 0x0000000187888D0C-0x0000000187888E3C
		}
	
		// Constructors
		public CriFsBinder() {} // 0x0000000187888350-0x00000001878883A0
	
		// Methods
		public override void Dispose() {} // 0x00000001878883A0-0x00000001878883F8
		private void Dispose(bool disposing) {} // 0x00000001878881A8-0x00000001878881F0
		public uint BindCpk(CriFsBinder srcBinder, string path) => default; // 0x00000001878881F0-0x0000000187888238
		public uint BindDirectory(CriFsBinder srcBinder, string path) => default; // 0x0000000187888298-0x00000001878882D8
		public uint BindFile(CriFsBinder srcBinder, string path) => default; // 0x0000000187888238-0x0000000187888298
		public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName) => default; // 0x0000000187888CC0-0x0000000187888D0C
		public static void Unbind(uint bindId) {} // 0x0000000187888C0C-0x0000000187888C68
		public static Status GetStatus(uint bindId) => default; // 0x0000000187888BC8-0x0000000187888C04
		public long GetFileSize(string path) => default; // 0x0000000187888B8C-0x0000000187888BC8
		public long GetFileSize(int id) => default; // 0x00000001878887AC-0x000000018788899C
		public bool GetContentsFileInfo(string path, out ContentsFileInfo info) {
			info = default;
			return default;
		} // 0x000000018788899C-0x0000000187888B8C
		public bool GetContentsFileInfo(int id, out ContentsFileInfo info) {
			info = default;
			return default;
		} // 0x000000018788846C-0x00000001878887AC
		public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info) {
			info = default;
			return default;
		} // 0x0000000187888C04-0x0000000187888C0C
		public static int GetNumContentsFiles(uint bindId) => default; // 0x0000000187888C68-0x0000000187888CC0
		public static void SetPriority(uint bindId, int priority) {} // 0x00000001813B31A0-0x00000001813B31B0
		~CriFsBinder() {} // 0x00000001878891E4-0x000000018788925C
		private static extern uint criFsBinder_Create(out IntPtr binder); // 0x000000018788925C-0x00000001878892D4
		private static extern uint criFsBinder_Destroy(IntPtr binder); // 0x0000000187888E3C-0x0000000187888F14
		private static extern uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x0000000187888F14-0x0000000187888FEC
		private static extern uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x000000018788910C-0x00000001878891E4
		private static extern uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x0000000187888FEC-0x000000018788910C
		private static extern uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId); // 0x0000000187889700-0x0000000187889778
		private static extern int criFsBinder_Unbind(uint bindId); // 0x00000001878895FC-0x0000000187889680
		private static extern int criFsBinder_GetStatus(uint bindId, out Status status); // 0x000000018788954C-0x00000001878895FC
		private static extern int criFsBinder_GetFileSize(IntPtr binder, string path, out long size); // 0x00000001878894B8-0x000000018788954C
		private static extern int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size); // 0x0000000187889680-0x0000000187889700
		private static extern int criFsBinder_SetPriority(uint bindId, int priority); // 0x0000000187889408-0x00000001878894B8
		private static extern int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info); // 0x00000001878892D4-0x0000000187889368
		private static extern int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info); // 0x0000000187889368-0x0000000187889408
		private static extern int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num); // 0x00000001878882D8-0x0000000187888350
		private static extern int CRIWAREF02BA103(uint id); // 0x0000000187880708-0x0000000187880820
	}

	public class CriFsRequest : CriDisposable // TypeDefIndex: 55197
	{
		// Fields
		private DoneDelegate _doneDelegate_k__BackingField; // 0x20
		private bool _isDone_k__BackingField; // 0x28
		private string _error_k__BackingField; // 0x30
		private bool _isDisposed_k__BackingField; // 0x38
	
		// Properties
		public DoneDelegate doneDelegate { get; protected set; } // 0x000000018788BB64-0x000000018788BB94 0x0000000185492010-0x0000000185492020
		public bool isDone { get; private set; } // 0x0000000185492010-0x0000000185492020 0x000000018788BAC0-0x000000018788BAE0
		public string error { get; protected set; } // 0x000000018788BA08-0x000000018788BA64 0x000000018788BAE0-0x000000018788BB64
		public bool isDisposed { get; protected set; } // 0x00000001878899C0-0x00000001878899C8 0x0000000187893E40-0x0000000187893F64
	
		// Nested types
		public delegate void DoneDelegate(CriFsRequest request); // TypeDefIndex: 55195; 0x000000018646EE40-0x000000018646EE50
	
		private sealed class _CheckDone_d__23 : IEnumerator<object> // TypeDefIndex: 55196
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriFsRequest __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FAFE20-0x0000000185FAFE30 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _CheckDone_d__23() {} // Dummy constructor
			public _CheckDone_d__23(int __1__state) {} // 0x00000001813B51D0-0x00000001813B51E0
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001864721F0-0x0000000186472200
			private bool MoveNext() => default; // 0x0000000185FB0700-0x0000000185FB0710
			void IEnumerator.Reset() {} // 0x000000018788BA64-0x000000018788BAC0
		}
	
		// Constructors
		public CriFsRequest() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override void Dispose() {} // 0x00000001833EEC70-0x00000001833EEC80
		public virtual void Stop() {} // 0x0000000185A264E0-0x0000000185A26510
		public YieldInstruction WaitForDone(MonoBehaviour mb) => default; // 0x00000001864BB614-0x00000001864BB734
		protected virtual void Dispose(bool disposing) {} // 0x0000000181378230-0x0000000181378240
		public virtual void Update() {} // 0x0000000185492010-0x0000000185492020
		protected void Done() {} // 0x0000000187894BA8-0x0000000187894BF0
		private IEnumerator CheckDone() => default; // 0x0000000181377E40-0x0000000181377E50
		~CriFsRequest() {} // 0x0000000187894BF0-0x0000000187894C3C
	}

	public class CriFsLoadFileRequest : CriFsRequest // TypeDefIndex: 55199
	{
		// Fields
		private string _path_k__BackingField; // 0x40
		private byte[] _bytes_k__BackingField; // 0x48
		private Phase phase; // 0x50
		private CriFsBinder refBinder; // 0x58
		private CriFsBinder newBinder; // 0x60
		private uint bindId; // 0x68
		private CriFsLoader loader; // 0x70
		private int readUnitSize; // 0x78
		private long fileSize; // 0x80
	
		// Properties
		public string path { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public byte[] bytes { get; private set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
	
		// Nested types
		private enum Phase // TypeDefIndex: 55198
		{
			Stop = 0,
			Bind = 1,
			Load = 2,
			Done = 3,
			Error = 4
		}
	
		// Constructors
		public CriFsLoadFileRequest() {} // Dummy constructor
		public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize) {} // 0x000000018788A7A8-0x000000018788A8F4
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x000000018788A408-0x000000018788A49C
		public override void Stop() {} // 0x000000018788A550-0x000000018788A57C
		public override void Update() {} // 0x000000018788A76C-0x000000018788A7A8
		private void UpdateBinder() {} // 0x000000018788A57C-0x000000018788A5E4
		private void UpdateLoader() {} // 0x000000018788A5E4-0x000000018788A76C
		private void OnError() {} // 0x000000018788A49C-0x000000018788A550
	}

	public class CriFsLoadAssetBundleRequest : CriFsRequest // TypeDefIndex: 55200
	{
		// Fields
		private string _path_k__BackingField; // 0x40
		private AssetBundle _assetBundle_k__BackingField; // 0x48
		private CriFsLoadFileRequest loadFileReq; // 0x50
		private AssetBundleCreateRequest assetBundleReq; // 0x58
	
		// Properties
		public string path { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public AssetBundle assetBundle { get; private set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
	
		// Constructors
		public CriFsLoadAssetBundleRequest() {} // Dummy constructor
		public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize) {} // 0x000000018788A368-0x000000018788A408
	
		// Methods
		public override void Update() {} // 0x000000018788A270-0x000000018788A368
		protected override void Dispose(bool disposing) {} // 0x000000018788A20C-0x000000018788A270
	}

	public class CriFsInstallRequest : CriFsRequest // TypeDefIndex: 55201
	{
		// Fields
		private string _sourcePath_k__BackingField; // 0x40
		private string _destinationPath_k__BackingField; // 0x48
		private float _progress_k__BackingField; // 0x50
	
		// Properties
		public string sourcePath { get; protected set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public string destinationPath { get; protected set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public float progress { get; protected set; } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
	
		// Constructors
		public CriFsInstallRequest() {} // 0x00000001878899C0-0x00000001878899C8
	}

	public class CriFsInstallRequestLegacy : CriFsInstallRequest // TypeDefIndex: 55202
	{
		// Fields
		private CriFsInstaller installer; // 0x58
	
		// Constructors
		public CriFsInstallRequestLegacy() {} // Dummy constructor
		public CriFsInstallRequestLegacy(CriFsBinder srcBinder, string srcPath, string dstPath, DoneDelegate doneDelegate, int installBufferSize) {} // 0x00000001878898AC-0x00000001878899C0
	
		// Methods
		public override void Stop() {} // 0x00000001878897DC-0x0000000187889804
		public override void Update() {} // 0x0000000187889804-0x00000001878898AC
		protected override void Dispose(bool disposing) {} // 0x0000000187889778-0x00000001878897DC
	}

	public class CriFsWebInstallRequest : CriFsInstallRequest // TypeDefIndex: 55203
	{
		// Fields
		private CriFsWebInstaller installer; // 0x58
		private uint crc32; // 0x60
		private bool crc32_set; // 0x64
	
		// Constructors
		public CriFsWebInstallRequest() {} // Dummy constructor
		public CriFsWebInstallRequest(string srcPath, string dstPath, DoneDelegate doneDelegate) {} // 0x000000018788CE6C-0x000000018788CF70
	
		// Methods
		public override void Stop() {} // 0x000000018788CCCC-0x000000018788CCF4
		public bool GetCRC32(out uint ret_val) {
			ret_val = default;
			return default;
		} // 0x0000000185FB3020-0x0000000185FB3030
		public override void Update() {} // 0x000000018788CCF4-0x000000018788CE6C
		protected override void Dispose(bool disposing) {} // 0x000000018788CC68-0x000000018788CCCC
	}

	public class CriFsBindRequest : CriFsRequest // TypeDefIndex: 55205
	{
		// Fields
		private string _path_k__BackingField; // 0x40
		private uint _bindId_k__BackingField; // 0x48
	
		// Properties
		public string path { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public uint bindId { get; private set; } // 0x0000000185FB0570-0x0000000185FB0580 0x0000000185FB05D0-0x0000000185FB05E0
	
		// Nested types
		public enum BindType // TypeDefIndex: 55204
		{
			Cpk = 0,
			Directory = 1,
			File = 2
		}
	
		// Constructors
		public CriFsBindRequest() {} // Dummy constructor
		public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path) {} // 0x0000000187888070-0x00000001878881A8
	
		// Methods
		public override void Stop() {} // 0x0000000185492010-0x0000000185492020
		public override void Update() {} // 0x000000018788800C-0x0000000187888070
		protected override void Dispose(bool disposing) {} // 0x0000000187887FC0-0x000000018788800C
	}

	public static class CriFsUtility // TypeDefIndex: 55206
	{
		// Fields
		public const int DefaultReadUnitSize = 1048576; // Metadata: 0x0207BD5D
	
		// Methods
		public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576 /* Metadata: 0x0207BD49 */) => default; // 0x000000018788CBB0-0x000000018788CBFC
		public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576 /* Metadata: 0x0207BD4D */) => default; // 0x000000018788CB04-0x000000018788CB58
		public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x0207BD51 */) => default; // 0x000000018788CB58-0x000000018788CBB0
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576 /* Metadata: 0x0207BD55 */) => default; // 0x000000018788CAF4-0x000000018788CB04
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x0207BD59 */) => default; // 0x000000018788CAA0-0x000000018788CAF4
		public static CriFsInstallRequest Install(string srcPath, string dstPath) => default; // 0x000000018788CA18-0x000000018788CA3C
		public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x000000018788C99C-0x000000018788C9C0
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath) => default; // 0x000000018788C9C0-0x000000018788CA18
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x000000018788CA3C-0x000000018788CAA0
		public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate) => default; // 0x000000018788CC14-0x000000018788CC68
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath) => default; // 0x000000018788C6A4-0x000000018788C6B4
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x000000018788C6B4-0x000000018788C708
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath) => default; // 0x000000018788C708-0x000000018788C750
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x000000018788C750-0x000000018788C7A4
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath) => default; // 0x000000018788C7F8-0x000000018788C840
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) => default; // 0x000000018788C7A4-0x000000018788C7F8
		public static void SetUserAgentString(string userAgentString) {} // 0x000000018788CC0C-0x000000018788CC14
		public static void SetProxyServer(string proxyPath, ushort proxyPort) {} // 0x000000018788CC04-0x000000018788CC0C
		public static void SetPathSeparator(string filter) {} // 0x000000018788CBFC-0x000000018788CC04
		private static extern bool CRIWARECD0DC04A(string userAgentString); // 0x000000018788C940-0x000000018788C99C
		private static extern bool CRIWARE48E31D64(string proxyPath, ushort proxyPort); // 0x000000018788C89C-0x000000018788C940
		private static extern bool CRIWARE0C80F382(string filter); // 0x000000018788C840-0x000000018788C89C
	}

	public static class CriFsPlugin // TypeDefIndex: 55207
	{
		// Fields
		private static int initializationCount; // 0x00
		private static bool isConfigured; // 0x04
		public static int defaultInstallBufferSize; // 0x08
		public static int installBufferSize; // 0x0C
	
		// Properties
		public static bool isInitialized { get; } // 0x000000018788B9C0-0x000000018788BA08 
	
		// Constructors
		static CriFsPlugin() {} // 0x0000000185F60CE0-0x0000000185F60D60
	
		// Methods
		public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check) {} // 0x00000001850F9F80-0x00000001850FA040
		public static void SetReadDeviceEnabled(int deviceId, bool enabled) {} // 0x000000018788B68C-0x000000018788B718
		public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps) {} // 0x0000000185492010-0x0000000185492020
		public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio) {} // 0x0000000185492010-0x0000000185492020
		public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio) {} // 0x0000000185492010-0x0000000185492020
		public static void InitializeLibrary() {} // 0x00000001850F9A00-0x00000001850F9AF0
		public static bool IsLibraryInitialized() => default; // 0x00000001850F9E60-0x00000001850F9EB0
		public static void FinalizeLibrary() {} // 0x000000018788B5A4-0x000000018788B68C
		private static extern void CRIWARE8451156E(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check); // 0x00000001844CE750-0x00000001844CE810
		private static extern void CRIWARE601ABE43(); // 0x00000001850F9AF0-0x00000001850F9B20
		public static extern bool CRIWARE1012AF20(); // 0x00000001850F9EB0-0x00000001850F9EF0
		private static extern void CRIWARE74A6103A(); // 0x000000018788B54C-0x000000018788B578
		public static extern uint CRIWARE785081A5(); // 0x000000018788B578-0x000000018788B5A4
		public static extern uint criFsLoader_GetRetryCount(); // 0x000000018788B718-0x000000018788B780
		public static extern int criFs_GetNumBinds(ref int cur, ref int max, ref int limit); // 0x000000018788B780-0x000000018788B814
		public static extern int criFs_GetNumUsedLoaders(ref int cur, ref int max, ref int limit); // 0x000000018788B8A8-0x000000018788B93C
		public static extern int criFs_GetNumUsedInstallers(ref int cur, ref int max, ref int limit); // 0x000000018788B814-0x000000018788B8A8
		private static extern int criFs_SetReadDeviceEnabled(int device_id, bool enabled); // 0x000000018788B93C-0x000000018788B9C0
	}

	public class CriFsServer : CriMonoBehaviour // TypeDefIndex: 55208
	{
		// Fields
		private static CriFsServer _instance; // 0x00
		private List<CriFsRequest> requestList; // 0x28
		private int _installBufferSize_k__BackingField; // 0x30
	
		// Properties
		public static CriFsServer instance { get => default; } // 0x000000018788C664-0x000000018788C6A4 
		public int installBufferSize { get; private set; } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
	
		// Constructors
		public CriFsServer() {} // 0x0000000185FAF3F0-0x0000000185FAF400
	
		// Methods
		public static void CreateInstance() {} // 0x000000018788BF48-0x000000018788C01C
		public static void DestroyInstance() {} // 0x000000018788C14C-0x000000018788C1D8
		private void Awake() {} // 0x000000018788BBE8-0x000000018788BD54
		private void OnDestroy() {} // 0x000000018788C3E8-0x000000018788C5B0
		public override void CriInternalUpdate() {} // 0x000000018788C01C-0x000000018788C14C
		public override void CriInternalLateUpdate() {} // 0x0000000185492010-0x0000000185492020
		public void AddRequest(CriFsRequest request) {} // 0x000000018788BB94-0x000000018788BBE8
		public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize) => default; // 0x000000018788C340-0x000000018788C3E8
		public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize) => default; // 0x000000018788C2A0-0x000000018788C340
		public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate) => default; // 0x000000018788C1D8-0x000000018788C2A0
		public CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate) => default; // 0x000000018788C5B0-0x000000018788C664
		public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x000000018788BD54-0x000000018788BDF8
		public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x000000018788BDF8-0x000000018788BEA0
		public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path) => default; // 0x000000018788BEA0-0x000000018788BF48
	}

	public class CriFsWebInstaller : CriDisposable // TypeDefIndex: 55214
	{
		// Fields
		private static bool _isInitialized_k__BackingField; // 0x00
		private static bool _isCrcEnabled_k__BackingField; // 0x01
		public const int InvalidHttpStatusCode = -1; // Metadata: 0x0207BD61
		public const long InvalidContentsSize = -1; // Metadata: 0x0207BD62
		private IntPtr handle; // 0x20
	
		// Properties
		public static bool isInitialized { get; private set; } // 0x000000018788DAC0-0x000000018788DAFC 0x000000018788DA14-0x000000018788DA4C
		public static bool isCrcEnabled { get; private set; } // 0x000000018788DA84-0x000000018788DAC0 0x000000018788D9BC-0x000000018788DA14
		public static ModuleConfig defaultModuleConfig { get => default; } // 0x000000018788D48C-0x000000018788D548 
	
		// Nested types
		public enum Status // TypeDefIndex: 55209
		{
			Stop = 0,
			Busy = 1,
			Complete = 2,
			Error = 3
		}
	
		public enum Error // TypeDefIndex: 55210
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
	
		public struct StatusInfo // TypeDefIndex: 55211
		{
			// Fields
			public Status status; // 0x00
			public Error error; // 0x04
			public int httpStatusCode; // 0x08
			public long contentsSize; // 0x10
			public long receivedSize; // 0x18
		}
	
		public struct ModuleConfig // TypeDefIndex: 55212
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
	
		public struct ModulePlatformConfig // TypeDefIndex: 55213
		{
			// Fields
			public byte reserved; // 0x00
	
			// Properties
			public static ModulePlatformConfig defaultConfig { get => default; } // 0x000000018788DA4C-0x000000018788DA84 
		}
	
		// Constructors
		public CriFsWebInstaller() {} // 0x000000018788D13C-0x000000018788D1B0
	
		// Methods
		~CriFsWebInstaller() {} // 0x000000018788CF7C-0x000000018788CFCC
		public override void Dispose() {} // 0x000000018788CF70-0x000000018788CF7C
		public void Copy(string url, string dstPath) {} // 0x000000018788D478-0x000000018788D48C
		public void Stop() {} // 0x000000018788D234-0x000000018788D284
		public StatusInfo GetStatusInfo() => default; // 0x000000018788D1B0-0x000000018788D1CC
		public bool GetCRC32(out uint ret_val) {
			ret_val = default;
			return default;
		} // 0x000000018788D284-0x000000018788D460
		public static void InitializeModule(ModuleConfig config) {} // 0x000000018788D1CC-0x000000018788D234
		private static System.Type GetCriFsWebInstallerCurlExpansionClass() => default; // 0x000000018788D094-0x000000018788D13C
		public static void FinalizeModule() {} // 0x000000018788D08C-0x000000018788D094
		public static void ExecuteMain() {} // 0x000000018788D460-0x000000018788D478
		public static bool SetRequestHeader(string field, string value) => default; // 0x000000018788CFCC-0x000000018788D08C
		private void Dispose(bool disposing) {} // 0x000000018788D820-0x000000018788D8C8
		private static extern int criFsWebInstaller_Initialize(in ModuleConfig config); // 0x000000018788D6EC-0x000000018788D718
		private static extern int criFsWebInstaller_Finalize(); // 0x000000018788D6C0-0x000000018788D6EC
		private static extern int criFsWebInstaller_ExecuteMain(); // 0x000000018788D614-0x000000018788D68C
		private static extern int criFsWebInstaller_Create(out IntPtr installer); // 0x000000018788D68C-0x000000018788D6C0
		private static extern int criFsWebInstaller_Destroy(IntPtr installer); // 0x000000018788D548-0x000000018788D614
		private static extern int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath); // 0x000000018788D988-0x000000018788D9BC
		private static extern int criFsWebInstaller_Stop(IntPtr installer); // 0x000000018788D79C-0x000000018788D820
		private static extern int criFsWebInstaller_GetStatusInfo(IntPtr installer, out StatusInfo status); // 0x000000018788D718-0x000000018788D79C
		private static extern int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32); // 0x000000018788D8C8-0x000000018788D988
		private static extern int criFsWebInstaller_SetRequestHeader(string field, string value); // 0x00000001814A81B0-0x00000001814A81C0
	}

	public class CriManaPlugin // TypeDefIndex: 55215
	{
		// Fields
		private static int initializationCount; // 0x00
		private static bool isConfigured; // 0x04
		private static bool enabledMultithreadedRendering; // 0x05
		public static int renderingEventOffset; // 0x08
	
		// Properties
		public static bool isInitialized { get => default; } // 0x0000000187892C48-0x0000000187892C90 
		public static bool isMultithreadedRenderingEnabled { get => default; } // 0x0000000187892C90-0x0000000187892CE0 
	
		// Constructors
		public CriManaPlugin() {} // 0x0000000185492010-0x0000000185492020
		static CriManaPlugin() {} // 0x0000000185F632E0-0x0000000185F63360
	
		// Methods
		public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries) {} // 0x00000001850F9850-0x00000001850F9920
		private static void SetupVp9() {} // 0x00000001850FA040-0x00000001850FA140
		public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height) {} // 0x0000000185492010-0x0000000185492020
		public static void SetConfigAdditonalParameters_PC(bool use_h264_playback) {} // 0x00000001850F9EF0-0x00000001850F9F40
		public static void SetConfigAdditonalParameters_ANDROID(bool enable_buffer_output_for_h264, bool enable_buffer_output_for_vp9) {} // 0x0000000185492010-0x0000000185492020
		public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize) {} // 0x0000000185492010-0x0000000185492020
		public static void InitializeLibrary() {} // 0x00000001850F8C40-0x00000001850F8D90
		public static bool IsLibraryInitialized() => default; // 0x00000001850F9460-0x00000001850F94B0
		public static void FinalizeLibrary() {} // 0x000000018789285C-0x000000018789298C
		public static bool IsCodecSupported(CodecType codecType) => default; // 0x00000001878929CC-0x0000000187892AB8
		private static System.Type GetVp9ExpansionClass() => default; // 0x0000000184F7B7F0-0x0000000184F7B8B0
		private static bool IsVp9CodecSupported() => default; // 0x00000001850FA140-0x00000001850FA230
		private static bool IsH264CodecSupported() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public static void SetDecodeThreadPriorityAndroidExperimental(int prio) {} // 0x0000000185492010-0x0000000185492020
		public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public static void Lock() {} // 0x0000000187892AB8-0x0000000187892AF8
		public static void Unlock() {} // 0x0000000187892AF8-0x0000000187892B38
		public static uint GetPrimeBufferAlignmentSize() => default; // 0x000000018789298C-0x00000001878929CC
		private static extern void CRIWARECFA78B41(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries); // 0x00000001844CE6B0-0x00000001844CE750
		private static extern void CRIWARE7BFC56AA(); // 0x00000001850F8D90-0x00000001850F8DC0
		public static extern bool CRIWARE611B78A5(); // 0x00000001850F94B0-0x00000001850F94F0
		private static extern void CRIWARED672C36F(); // 0x0000000187892830-0x000000018789285C
		public static extern void CRIWARE9F182D39(bool flag); // 0x00000001878927FC-0x0000000187892830
		public static extern void CRIWARE06C87176(); // 0x0000000187892778-0x00000001878927A4
		public static extern void CRIWARE46E1A37B(); // 0x00000001878927D0-0x00000001878927FC
		private static extern uint criManaUnity_GetPrimeBufferAlignmentSize(); // 0x0000000187892B38-0x0000000187892BA0
		public static extern void criMana_UseStreamerManager(bool flag); // 0x0000000187892BD0-0x0000000187892C48
		public static extern bool criMana_IsStreamerManagerUsed(); // 0x0000000187892BA0-0x0000000187892BD0
		public static extern uint CRIWARE257CA763(); // 0x00000001878927A4-0x00000001878927D0
		public static extern void CRIWARE62B7B053(bool enable); // 0x00000001850F9F40-0x00000001850F9F80
	}

	public class CriManaAmbisonicSource : CriMonoBehaviour // TypeDefIndex: 55216
	{
		// Fields
		private CriAtomEx3dSource atomEx3DsourceForAmbisonics; // 0x28
		private Vector3 ambisonicSourceOrientationFront; // 0x30
		private Vector3 ambisonicSourceOrientationTop; // 0x3C
		private Vector3 lastEulerOfAmbisonicSource; // 0x48
	
		// Constructors
		public CriManaAmbisonicSource() {} // 0x0000000185FAF3F0-0x0000000185FAF400
	
		// Methods
		public override void CriInternalUpdate() {} // 0x000000018788DAFC-0x000000018788DB04
		public override void CriInternalLateUpdate() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnEnable() {} // 0x000000018788DBAC-0x000000018788DC90
		private void ForceUpdateAmbisonicSourceOrientation() {} // 0x000000018788DB04-0x000000018788DBAC
		private void UpdateAmbisonicSourceOrientation() {} // 0x000000018788E09C-0x000000018788E13C
		private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler) {} // 0x000000018788DC90-0x000000018788E09C
	}

	public class CriManaMovieController : CriManaMovieMaterial // TypeDefIndex: 55217
	{
		// Fields
		public Renderer target; // 0x98
		public bool useOriginalMaterial; // 0xA0
		private Material originalMaterial; // 0xA8
	
		// Constructors
		public CriManaMovieController() {} // 0x00000001878911C8-0x00000001878911D0
	
		// Methods
		public override void CriInternalUpdate() {} // 0x00000001878911D0-0x0000000187891270
		public override bool RenderTargetManualSetup() => default; // 0x00000001878913E0-0x0000000187891520
		public override void RenderTargetManualFinalize() {} // 0x0000000187891334-0x00000001878913E0
		protected override void OnMaterialAvailableChanged() {} // 0x0000000187891270-0x0000000187891334
	}

	public class CriManaMovieControllerForUI : CriManaMovieMaterial // TypeDefIndex: 55218
	{
		// Fields
		public Graphic target; // 0x98
		public bool useOriginalMaterial; // 0xA0
		private Material originalMaterial; // 0xA8
	
		// Constructors
		public CriManaMovieControllerForUI() {} // 0x00000001878911C8-0x00000001878911D0
	
		// Methods
		protected override void Awake() {} // 0x0000000187890E44-0x0000000187890E68
		public override void CriInternalUpdate() {} // 0x0000000187890E68-0x0000000187890F0C
		public override bool RenderTargetManualSetup() => default; // 0x0000000187891084-0x00000001878911C8
		public override void RenderTargetManualFinalize() {} // 0x0000000187890FD4-0x0000000187891084
		protected override void OnMaterialAvailableChanged() {} // 0x0000000187890F0C-0x0000000187890FD4
	}

	public class CriManaMovieMaterial : CriManaMovieMaterialBase // TypeDefIndex: 55219
	{
		// Fields
		private string _moviePath; // 0x80
		private bool _loop; // 0x88
		private bool _additiveMode; // 0x89
		private bool _useMaterialBlendMode; // 0x8A
		private bool _advancedAudio; // 0x8B
		private bool _ambisonics; // 0x8C
		private bool _applyTargetAlpha; // 0x8D
		private bool _uiRenderMode; // 0x8E
		private GameObject ambisonicSource; // 0x90
	
		// Properties
		public string moviePath { get => default; set {} } // 0x000000018140CF50-0x000000018140CF60 0x00000001878925DC-0x0000000187892654
		public bool loop { get => default; set {} } // 0x000000018316BFD0-0x000000018316BFE0 0x0000000187892570-0x00000001878925DC
		public bool advancedAudio { get => default; set {} } // 0x0000000185FB3090-0x0000000185FB30A0 0x0000000187892008-0x0000000187892088
		public bool ambisonics { get => default; set {} } // 0x0000000181DB8300-0x0000000181DB8310 0x0000000187892088-0x0000000187892504
		public bool additiveMode { get => default; set {} } // 0x0000000185FB3080-0x0000000185FB3090 0x0000000187891F9C-0x0000000187892008
		public bool useMaterialBlendMode { get => default; set {} } // 0x0000000185FB30C0-0x0000000185FB30D0 0x00000001878926C0-0x000000018789272C
		public bool applyTargetAlpha { get => default; set {} } // 0x0000000185FB30A0-0x0000000185FB30B0 0x0000000187892504-0x0000000187892570
		public bool uiRenderMode { get => default; set {} } // 0x0000000185FB30B0-0x0000000185FB30C0 0x0000000187892654-0x00000001878926C0
		protected override uint FilePathLength { get => default; } // 0x0000000187891F4C-0x0000000187891F9C 
		protected override bool initializeWithAdvancedAudio { get => default; } // 0x0000000185FB3090-0x0000000185FB30A0 
		protected override bool initializeWithAmbisonics { get => default; } // 0x0000000181DB8300-0x0000000181DB8310 
	
		// Constructors
		public CriManaMovieMaterial() {} // 0x00000001878911C8-0x00000001878911D0
	
		// Methods
		protected override void SetDataToPlayer() {} // 0x0000000187891E88-0x0000000187891F4C
	}

	public abstract class CriManaMovieMaterialBase : CriMonoBehaviour // TypeDefIndex: 55225
	{
		// Fields
		public bool playOnStart; // 0x28
		public bool restartOnEnable; // 0x29
		private bool _isMaterialAvailable_k__BackingField; // 0x2A
		private Player _player_k__BackingField; // 0x30
		public RenderMode renderMode; // 0x38
		public OnApplicationPauseCallback onApplicationPauseCallback; // 0x40
		private Player.TimerType _timerType; // 0x48
		private Material _material; // 0x50
		private MaxFrameDrop _maxFrameDrop; // 0x58
		private bool materialOwn; // 0x5C
		protected bool isMonoBehaviourStartCalled; // 0x5D
		private bool wasDisabled; // 0x5E
		private bool wasPausedOnDisable; // 0x5F
		private bool previousOnApplicationPauseStatus; // 0x60
		private WaitForEndOfFrame frameEnd; // 0x68
		private bool unpauseOnApplicationUnpause; // 0x70
		private bool _HaveRendererOwner_k__BackingField; // 0x71
		private CriManaMoviePlayerHolder playerHolder; // 0x78
	
		// Properties
		public MaxFrameDrop maxFrameDrop { get; set; }
		protected abstract bool initializeWithAdvancedAudio { get; } // 0x0000000185FB3060-0x0000000185FB3070 
		protected abstract bool initializeWithAmbisonics { get; } // 0x0000000185FB3070-0x0000000185FB3080 
		public bool isMaterialAvailable { get; private set; } // 0x0000000187891800-0x0000000187891834 0x0000000187891D20-0x0000000187891D58
		public Player player { get; private set; } // 0x00000001878917CC-0x0000000187891800 0x0000000185492010-0x0000000185492020
		public Material material { get; set; } // 0x0000000185492010-0x0000000185492020 0x0000000187891874-0x0000000187891A14
		public Player.TimerType timerType { get; set; } // 0x0000000187891834-0x0000000187891874 0x0000000187891520-0x00000001878915C0
		protected abstract uint FilePathLength { get; } // 0x0000000187891A14-0x0000000187891AC8 
		protected bool HaveRendererOwner { get; private set; } // 0x0000000185492010-0x0000000185492020 0x0000000187891AC8-0x0000000187891BA0
	
		// Nested types
		public enum MaxFrameDrop // TypeDefIndex: 55220
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
	
		public enum RenderMode // TypeDefIndex: 55221
		{
			Always = 0,
			OnVisibility = 1,
			Never = 2
		}
	
		public delegate void OnApplicationPauseCallback(CriManaMovieMaterialBase manaMovieMaterial, bool appPause); // TypeDefIndex: 55222; 0x0000000187891E50-0x0000000187891E68
	
		private struct _AsyncDispose_d__53 : IAsyncStateMachine // TypeDefIndex: 55223
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public Player player; // 0x28
			private TaskAwaiter __u__1; // 0x30
	
			// Methods
			private void MoveNext() {} // 0x0000000181E2DB70-0x0000000181E2DB80
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018306A5F0-0x000000018306BCC0
		}
	
		private sealed class _RestartPlayerRoutine_d__60 : IEnumerator<object> // TypeDefIndex: 55224
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriManaMovieMaterialBase __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187891DB8-0x0000000187891E50 
			object IEnumerator.Current { get => default; } // 0x0000000187891E68-0x0000000187891E88 
	
			// Constructors
			public _RestartPlayerRoutine_d__60() {} // Dummy constructor
			public _RestartPlayerRoutine_d__60(int __1__state) {} // 0x00000001813B51D0-0x00000001813B51E0
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001864721F0-0x0000000186472200
			private bool MoveNext() => default; // 0x0000000181460F60-0x0000000181460F70
			void IEnumerator.Reset() {} // 0x0000000185FB0570-0x0000000185FB0580
		}
	
		// Constructors
		protected CriManaMovieMaterialBase() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected abstract void SetDataToPlayer(); // 0x00000001840A27C0-0x00000001840A27D0
		public void Play() {} // 0x00000001878915C0-0x00000001878915C8
		public void Stop() {} // 0x000000018789173C-0x000000018789179C
		public void Pause(bool sw) {} // 0x0000000187891C64-0x0000000187891CC0
		protected virtual void OnMaterialAvailableChanged() {} // 0x00000001878916E8-0x000000018789173C
		protected virtual void OnMaterialUpdated() {} // 0x00000001878916C0-0x00000001878916E8
		public void PlayerManualInitialize() {} // 0x0000000187891CC0-0x0000000187891D20
		public void PlayerManualFinalize() {} // 0x00000001878916B0-0x00000001878916B8
		private void AsyncDispose(Player player) {} // 0x0000000187891C3C-0x0000000187891C64
		public void PlayerManualSetup() {} // 0x0000000187891680-0x00000001878916B0
		public virtual bool RenderTargetManualSetup() => default; // 0x000000018789179C-0x00000001878917CC
		public virtual void RenderTargetManualFinalize() {} // 0x00000001878916B8-0x00000001878916C0
		public void PlayerManualUpdate() {} // 0x0000000187891BA0-0x0000000187891C3C
		protected virtual void Awake() {} // 0x00000001878915C8-0x0000000187891680
		protected override void OnEnable() {} // 0x0000000187891D58-0x0000000187891DB8
		private IEnumerator RestartPlayerRoutine() => default; // 0x00000001878946F0-0x0000000187894818
		protected override void OnDisable() {} // 0x00000001831C5680-0x00000001831C5690
		protected virtual void OnDestroy() {} // 0x0000000187894670-0x00000001878946F0
		protected virtual void Start() {} // 0x00000001864BB614-0x00000001864BB734
		public override void CriInternalUpdate() {} // 0x0000000187894A28-0x0000000187894BA8
		public virtual void RenderMovie() {} // 0x0000000186475504-0x0000000186475510
		public override void CriInternalLateUpdate() {} // 0x0000000181378230-0x0000000181378240
		protected virtual void OnWillRenderObject() {} // 0x0000000185492010-0x0000000185492020
		private void OnApplicationPause(bool appPause) {} // 0x0000000187894C3C-0x0000000187894D24
		private void ProcessApplicationPause(bool appPause) {} // 0x0000000181377E40-0x0000000181377E50
		private void CreateMaterial() {} // 0x0000000187894D24-0x0000000187894D70
	}

	public class CriManaMoviePlayerHolder : CriMonoBehaviour // TypeDefIndex: 55226
	{
		// Fields
		private Player _player; // 0x28
	
		// Properties
		public Player player { set {} } // 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Constructors
		public CriManaMoviePlayerHolder() {} // 0x0000000185FAF3F0-0x0000000185FAF400
	
		// Methods
		private void Awake() {} // 0x000000018789272C-0x0000000187892778
		public override void CriInternalUpdate() {} // 0x0000000185492010-0x0000000185492020
		public override void CriInternalLateUpdate() {} // 0x0000000185492010-0x0000000185492020
		private void Start() {} // 0x0000000185492010-0x0000000185492020
	}

	public class Common // TypeDefIndex: 55228
	{
		// Fields
		private const string scriptVersionString = "1.0.6(2.40.31_PS5SDKUpdate)"; // Metadata: 0x0207BD86
		public const bool supportsCriFsInstaller = true; // Metadata: 0x0207BDA2
		public const bool supportsCriFsWebInstaller = true; // Metadata: 0x0207BDA3
		public const string pluginName = "cri_ware_unity"; // Metadata: 0x0207BDA4
		public const CallingConvention pluginCallingConvention = CallingConvention.Cdecl; // Metadata: 0x0207BDB3
		private static GameObject _managerObject; // 0x00
	
		// Properties
		public static string streamingAssetsPath { get => default; } // 0x00000001844CFC90-0x00000001844CFCE0 
		public static string installTargetPath { get => default; } // 0x0000000187880700-0x0000000187880708 
		public static string installCachePath { get => default; } // 0x00000001878806D8-0x0000000187880700 
		public static GameObject managerObject { get => default; } // 0x0000000184A839A0-0x0000000184A83B40 
	
		// Nested types
		public struct CpuUsage // TypeDefIndex: 55227
		{
			// Fields
			public float last; // 0x00
			public float average; // 0x04
			public float peak; // 0x08
		}
	
		// Constructors
		public Common() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static bool IsStreamingAssetsPath(string path) => default; // 0x0000000185F4F3B0-0x0000000185F4F430
		public static string GetScriptVersionString() => default; // 0x00000001878806AC-0x00000001878806D8
		public static int GetBinaryVersionNumber() => default; // 0x0000000186471830-0x0000000186471838
		public static int GetRequiredBinaryVersionNumber() => default; // 0x0000000185FB2FE0-0x0000000185FB2FF0
		public static bool CheckBinaryVersionCompatibility() => default; // 0x0000000184A81DA0-0x0000000184A81DF0
		public static uint GetFsMemoryUsage() => default; // 0x000000018788062C-0x000000018788066C
		public static uint GetAtomMemoryUsage() => default; // 0x00000001878805EC-0x000000018788062C
		public static uint GetManaMemoryUsage() => default; // 0x000000018788066C-0x00000001878806AC
		public static CpuUsage GetAtomCpuUsage() => default; // 0x0000000187880598-0x00000001878805EC
		public static extern int CRIWAREC8077C29(); // 0x0000000185F5A910-0x0000000185F5A940
		public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset); // 0x00000001844CF1A0-0x00000001844CF220
	}

	public static class CriWareDecrypter // TypeDefIndex: 55230
	{
		// Fields
		private static ulong temporalStorage; // 0x00
	
		// Nested types
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 55229; 0x00000001844CF990-0x00000001844CFB50
	
		// Methods
		public static bool Initialize(CriWareDecrypterConfig config) => default; // 0x0000000185F1A920-0x0000000185F1A9B0
		public static bool Initialize(string key, string authenticationFile, bool enableAtomDecryption, bool enableManaDecryption) => default; // 0x00000001817C2F70-0x00000001817C2F80
		private static ulong CallbackFromNative(IntPtr ptr1) => default; // 0x00000001878804D4-0x000000018788054C
		public static extern int CRIWARE05CA8EB2(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj); // 0x00000001864BC1CC-0x00000001864BC2FC
	}

	public class CriWareErrorHandler : CriMonoBehaviour // TypeDefIndex: 55232
	{
		// Fields
		public bool enableDebugPrintOnTerminal; // 0x28
		public bool enableForceCrashOnError; // 0x29
		public bool dontDestroyOnLoad; // 0x2A
		private static string _errorMessage_k__BackingField; // 0x00
		public static readonly string logPrefix; // 0x08
		private static Callback OnCallback; // 0x10
		public static Callback callback; // 0x18
		public uint messageBufferCounts; // 0x2C
		private ConcurrentQueue<string> unThreadSafeMessages; // 0x30
		private static int initializationCount; // 0x20
	
		// Properties
		public static string errorMessage { get; set; } // 0x0000000187892EDC-0x0000000187893058 0x0000000187893458-0x0000000187893538
	
		// Events
		public static event Callback OnCallback;
	
		// Nested types
		public delegate void Callback(string message); // TypeDefIndex: 55231; 0x0000000187893AB8-0x0000000187893B14
	
		// Constructors
		public CriWareErrorHandler() {} // 0x0000000185A264E0-0x0000000185A26510
		static CriWareErrorHandler() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		private void Awake() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnEnable() {} // 0x000000018789325C-0x0000000187893378
		protected override void OnDisable() {} // 0x0000000187893060-0x0000000187893198
		public override void CriInternalUpdate() {} // 0x0000000187893198-0x000000018789325C
		public override void CriInternalLateUpdate() {} // 0x0000000187893538-0x000000018789376C
		private void OnDestroy() {} // 0x0000000187893834-0x00000001878938C0
		private void DequeueErrorMessages() {} // 0x000000018789376C-0x0000000187893834
		private void HandleMessage(string errmsg) {} // 0x0000000187759874-0x0000000187759948
		private static void OutputDefaultLog(string errmsg) {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public static class CriErrorNotifier // TypeDefIndex: 55236
	{
		// Fields
		private static Callback _onCallbackThreadUnsafe; // 0x00
		private static object objectLock; // 0x08
	
		// Events
		private static event Callback _onCallbackThreadUnsafe;
		public static event Callback OnCallbackThreadUnsafe;
	
		// Nested types
		public delegate void Callback(string message); // TypeDefIndex: 55233; 0x0000000187887EF4-0x0000000187887FC0
	
		internal delegate void ErrorCallbackFunc(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray); // TypeDefIndex: 55234; 0x00000001878877BC-0x0000000187887838
	
		public static class NativeMethod // TypeDefIndex: 55235
		{
			// Methods
			internal static extern void criErr_SetCallback(ErrorCallbackFunc callback); // 0x0000000187759874-0x0000000187759948
			internal static extern IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2); // 0x00000001833EEC70-0x00000001833EEC80
		}
	
		// Constructors
		static CriErrorNotifier() {} // 0x000000018789455C-0x00000001878945F0
	
		// Methods
		public static bool IsRegistered(Callback target) => default; // 0x0000000187893FEC-0x00000001878940A8
		public static void CallEvent(string message) {} // 0x00000001864BB614-0x00000001864BB734
		private static void ErrorCallbackFromNative(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray) {} // 0x00000001878945F0-0x0000000187894670
	}

	[Serializable]
	public class CriFsConfig // TypeDefIndex: 55237
	{
		// Fields
		public const int defaultAndroidDeviceReadBitrate = 50000000; // Metadata: 0x0207BDB4
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
		public CriFsConfig() {} // 0x00000001858A56B0-0x00000001858A5760
	}

	[Serializable]
	public class CriAtomConfig // TypeDefIndex: 55253
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
		public class StandardVoicePoolConfig // TypeDefIndex: 55238
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public StandardVoicePoolConfig() {} // 0x00000001858A5890-0x00000001858A5C30
		}
	
		[Serializable]
		public class HcaMxVoicePoolConfig // TypeDefIndex: 55239
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public HcaMxVoicePoolConfig() {} // 0x0000000185FB3120-0x0000000185FB3130
		}
	
		[Serializable]
		public enum InGamePreviewSwitchMode // TypeDefIndex: 55240
		{
			Disable = 0,
			Enable = 1,
			FollowBuildSetting = 2,
			Default = 3
		}
	
		[Serializable]
		public class InGamePreviewConfig // TypeDefIndex: 55241
		{
			// Fields
			public int maxPreviewObjects; // 0x10
			public int communicationBufferSize; // 0x14
			public int playbackPositionUpdateInterval; // 0x18
	
			// Constructors
			public InGamePreviewConfig() {} // 0x0000000185492010-0x0000000185492020
		}
	
		[Serializable]
		public class EditorPcmOutputConfig // TypeDefIndex: 55242
		{
			// Fields
			public bool enable; // 0x10
			public int bufferLength; // 0x14
	
			// Constructors
			public EditorPcmOutputConfig() {} // 0x0000000185FB3100-0x0000000185FB3120
		}
	
		public enum LinuxOutput // TypeDefIndex: 55243
		{
			Default = 0,
			PulseAudio = 1,
			ALSA = 2
		}
	
		[Serializable]
		public class AndroidLowLatencyStandardVoicePoolConfig // TypeDefIndex: 55244
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public AndroidLowLatencyStandardVoicePoolConfig() {} // 0x0000000185FB30F0-0x0000000185FB3100
		}
	
		[Serializable]
		public class VitaManaVoicePoolConfig // TypeDefIndex: 55245
		{
			// Fields
			public int numberOfManaDecoders; // 0x10
	
			// Constructors
			public VitaManaVoicePoolConfig() {} // 0x0000000185492010-0x0000000185492020
		}
	
		[Serializable]
		public class VitaAtrac9VoicePoolConfig // TypeDefIndex: 55246
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public VitaAtrac9VoicePoolConfig() {} // 0x0000000185FB3140-0x0000000185FB3150
		}
	
		[Serializable]
		public class Ps4Atrac9VoicePoolConfig // TypeDefIndex: 55247
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public Ps4Atrac9VoicePoolConfig() {} // 0x0000000185492010-0x0000000185492020
		}
	
		[Serializable]
		public class Ps5PortConfig // TypeDefIndex: 55248
		{
			// Fields
			public int maxChannelPorts; // 0x10
			public int maxObjectPorts; // 0x14
	
			// Constructors
			public Ps5PortConfig() {} // 0x0000000185492010-0x0000000185492020
		}
	
		[Serializable]
		public class SwitchOpusVoicePoolConfig // TypeDefIndex: 55249
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public SwitchOpusVoicePoolConfig() {} // 0x00000001830836C0-0x00000001830836D0
		}
	
		[Serializable]
		public class Ps4Audio3dConfig // TypeDefIndex: 55251
		{
			// Fields
			public bool useAudio3D; // 0x10
			public VoicePoolConfig voicePoolConfig; // 0x18
	
			// Nested types
			[Serializable]
			public class VoicePoolConfig // TypeDefIndex: 55250
			{
				// Fields
				public int memoryVoices; // 0x10
				public int streamingVoices; // 0x14
	
				// Constructors
				public VoicePoolConfig() {} // 0x0000000185492010-0x0000000185492020
			}
	
			// Constructors
			public Ps4Audio3dConfig() {} // 0x00000001858A5C30-0x00000001858A5C80
		}
	
		[Serializable]
		public class WebGLWebAudioVoicePoolConfig // TypeDefIndex: 55252
		{
			// Fields
			public int voices; // 0x10
	
			// Constructors
			public WebGLWebAudioVoicePoolConfig() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public CriAtomConfig() {} // 0x0000000185FB3150-0x0000000185FB3160
	}

	[Serializable]
	public class CriManaConfig // TypeDefIndex: 55257
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
		public class PCH264PlaybackConfig // TypeDefIndex: 55254
		{
			// Fields
			public bool useH264Playback; // 0x10
	
			// Constructors
			public PCH264PlaybackConfig() {} // 0x00000001858A5760-0x00000001858A5840
		}
	
		[Serializable]
		public class VitaH264PlaybackConfig // TypeDefIndex: 55255
		{
			// Fields
			public bool useH264Playback; // 0x10
			public int maxWidth; // 0x14
			public int maxHeight; // 0x18
			public bool getMemoryFromTexture; // 0x1C
	
			// Constructors
			public VitaH264PlaybackConfig() {} // 0x0000000181B9A230-0x0000000181B9A240
		}
	
		[Serializable]
		public class WebGLConfig // TypeDefIndex: 55256
		{
			// Fields
			public string webworkerPath; // 0x10
			public int heapSize; // 0x18
	
			// Constructors
			public WebGLConfig() {} // 0x0000000185FB3130-0x0000000185FB3140
		}
	
		// Constructors
		public CriManaConfig() {} // 0x00000001858A5840-0x00000001858A5890
	}

	[Serializable]
	public class CriWareDecrypterConfig // TypeDefIndex: 55258
	{
		// Fields
		public string key; // 0x10
		public string authenticationFile; // 0x18
		public bool enableAtomDecryption; // 0x20
		public bool enableManaDecryption; // 0x21
	
		// Constructors
		public CriWareDecrypterConfig() {} // 0x00000001858A5650-0x00000001858A56B0
	}

	public class CriWareInitializer : CriMonoBehaviour // TypeDefIndex: 55259
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
		public CriWareInitializer() {} // 0x00000001858A5520-0x00000001858A5650
	
		// Methods
		private void Awake() {} // 0x0000000184A81D80-0x0000000184A81DA0
		protected override void OnEnable() {} // 0x0000000184A81D70-0x0000000184A81D80
		private void Start() {} // 0x0000000185492010-0x0000000185492020
		private void OnDestroy() {} // 0x0000000187893B94-0x0000000187893B9C
		public override void CriInternalUpdate() {} // 0x0000000185492010-0x0000000185492020
		public override void CriInternalLateUpdate() {} // 0x0000000185492010-0x0000000185492020
		public void Initialize() {} // 0x00000001850F9C70-0x00000001850F9E60
		public void Shutdown() {} // 0x0000000187893B9C-0x0000000187893C6C
		public static bool IsInitialized() => default; // 0x0000000184A81DF0-0x0000000184A81E40
		public static void AddAudioEffectInterface(IntPtr effect_interface) {} // 0x0000000187893B14-0x0000000187893B8C
		public static bool InitializeFileSystem(CriFsConfig config) => default; // 0x00000001850F9B20-0x00000001850F9C70
		public static bool InitializeAtom(CriAtomConfig config) => default; // 0x00000001850F8DC0-0x00000001850F9270
		public static bool InitializeMana(CriManaConfig config) => default; // 0x00000001850F9300-0x00000001850F9420
		public static bool InitializeDecrypter(CriWareDecrypterConfig config) => default; // 0x0000000187893B8C-0x0000000187893B94
	}

	public static class CriAtomExDebug // TypeDefIndex: 55261
	{
		// Nested types
		public struct ResourcesInfo // TypeDefIndex: 55260
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
		} // 0x0000000187881408-0x0000000187881410
		private static extern void criAtomExDebug_GetResourcesInfo(out ResourcesInfo resourcesInfo); // 0x0000000187881410-0x0000000187881488
	}

	public static class CriAtomExAcfDebug // TypeDefIndex: 55275
	{
		// Nested types
		public struct CategoryInfo // TypeDefIndex: 55262
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public string name; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
		}
	
		public struct DspBusInfo // TypeDefIndex: 55263
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
	
		public struct AisacControlInfo // TypeDefIndex: 55264
		{
			// Fields
			public string name; // 0x00
			public uint id; // 0x08
		}
	
		public enum AisacType // TypeDefIndex: 55265
		{
			Normal = 0,
			AutoModulation = 1
		}
	
		public struct GlobalAisacInfo // TypeDefIndex: 55266
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numGraphs; // 0x0A
			public AisacType type; // 0x0C
			public float randomRange; // 0x10
			public ushort controlId; // 0x14
		}
	
		public struct SelectorInfo // TypeDefIndex: 55267
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
		}
	
		public struct SelectorLabelInfo // TypeDefIndex: 55268
		{
			// Fields
			public string selectorName; // 0x00
			public string labelName; // 0x08
		}
	
		private struct CategoryInfoForMarshaling // TypeDefIndex: 55269
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
			} // 0x0000000187880B4C-0x0000000187880B54
		}
	
		private struct DspBusInfoForMarshaling // TypeDefIndex: 55270
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
			} // 0x00000001878809B4-0x0000000187880A00
		}
	
		private struct AisacControlInfoForMarshaling // TypeDefIndex: 55271
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public uint id; // 0x08
	
			// Methods
			public void Convert(out AisacControlInfo x) {
				x = default;
			} // 0x0000000187880A00-0x0000000187880A4C
		}
	
		private struct GlobalAisacInfoForMarshaling // TypeDefIndex: 55272
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
			} // 0x0000000187880968-0x00000001878809B4
		}
	
		private struct SelectorInfoForMarshaling // TypeDefIndex: 55273
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
	
			// Methods
			public void Convert(out SelectorInfo x) {
				x = default;
			} // 0x0000000187880B44-0x0000000187880B4C
		}
	
		private struct SelectorLabelInfoForMarshaling // TypeDefIndex: 55274
		{
			// Fields
			public IntPtr selectorNamePtr; // 0x00
			public IntPtr labelNamePtr; // 0x08
	
			// Methods
			public void Convert(out SelectorLabelInfo x) {
				x = default;
			} // 0x0000000187880A4C-0x0000000187880AA4
		}
	
		// Methods
		public static int GetNumCategories() => default; // 0x0000000187880B3C-0x0000000187880B44
		public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo) {
			categoryInfo = default;
			return default;
		} // 0x0000000187880908-0x000000018788094C
		public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo) {
			categoryInfo = default;
			return default;
		} // 0x0000000187880900-0x0000000187880908
		public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo) {
			categoryInfo = default;
			return default;
		} // 0x000000018788094C-0x0000000187880968
		public static int GetNumBuses() => default; // 0x0000000187880B54-0x0000000187880B5C
		public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo) {
			dspBusInfo = default;
			return default;
		} // 0x0000000187880AF0-0x0000000187880B3C
		public static int GetNumAisacControls() => default; // 0x0000000187880AA4-0x0000000187880AF0
		public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info) {
			info = default;
			return default;
		} // 0x0000000187880B5C-0x0000000187880B64
		public static uint GetAisacControlIdByName(string name) => default; // 0x0000000187880B64-0x0000000187880BA8
		public static string GetAisacControlNameById(uint id) => default; // 0x0000000187880BA8-0x0000000187880BEC
		public static int GetNumGlobalAisacs() => default; // 0x0000000187880BEC-0x0000000187880C50
		public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info) {
			info = default;
			return default;
		} // 0x00000001878811D8-0x0000000187881204
		public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info) {
			info = default;
			return default;
		} // 0x0000000187880EC8-0x0000000187880F4C
		public static int GetNumSelectors() => default; // 0x0000000187880E24-0x0000000187880EC8
		public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info) {
			info = default;
			return default;
		} // 0x0000000187880DA0-0x0000000187880E24
		public static bool GetSelectorInfoByName(string name, out SelectorInfo info) {
			info = default;
			return default;
		} // 0x00000001878811AC-0x00000001878811D8
		public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo) {
			labelInfo = default;
			return default;
		} // 0x0000000187880F4C-0x0000000187881060
		private static extern int criAtomExAcf_GetNumCategories(); // 0x0000000187881188-0x00000001878811AC
		private static extern int criAtomExAcf_GetCategoryInfo(ushort index, out CategoryInfoForMarshaling categoryInfo); // 0x0000000187880CA4-0x0000000187880D28
		private static extern int criAtomExAcf_GetCategoryInfoByName(string name, out CategoryInfoForMarshaling categoryInfo); // 0x0000000187880C50-0x0000000187880CA4
		private static extern int criAtomExAcf_GetCategoryInfoById(uint id, out CategoryInfoForMarshaling categoryInfo); // 0x0000000187880D28-0x0000000187880DA0
		private static extern int criAtomExAcf_GetNumBuses(); // 0x0000000187881204-0x0000000187881228
		private static extern int criAtomExAcf_GetDspBusInformation(ushort index, out DspBusInfoForMarshaling dspBusInfo); // 0x0000000187881104-0x0000000187881188
		private static extern int criAtomExAcf_GetNumAisacControls(); // 0x0000000187881060-0x0000000187881104
		private static extern int criAtomExAcf_GetAisacControlInfo(ushort index, out AisacControlInfoForMarshaling info); // 0x0000000187881228-0x000000018788124C
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x000000018788124C-0x00000001878812D0
		private static extern IntPtr criAtomExAcf_GetAisacControlNameById(uint id); // 0x00000001878812D0-0x0000000187881374
		private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x0000000187881374-0x0000000187881408
		private static extern int criAtomExAcf_GetGlobalAisacInfo(ushort index, out GlobalAisacInfoForMarshaling info); // 0x000000018788054C-0x0000000187880598
		private static extern int criAtomExAcf_GetGlobalAisacInfoByName(string name, out GlobalAisacInfoForMarshaling info); // 0x0000000187893F64-0x0000000187893FEC
		private static extern int criAtomExAcf_GetNumSelectors(); // 0x000000018788049C-0x00000001878804D4
		private static extern int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out SelectorInfoForMarshaling info); // 0x0000000187894170-0x00000001878941C8
		private static extern int criAtomExAcf_GetSelectorInfoByName(string name, out SelectorInfoForMarshaling info); // 0x0000000187894994-0x00000001878949E0
		private static extern int criAtomExAcf_GetSelectorLabelInfo(ref SelectorInfoForMarshaling info, ushort labelIndex, out SelectorLabelInfoForMarshaling label_info); // 0x00000001878949E0-0x0000000187894A28
	}

	public static class CriAtomExAcbDebug // TypeDefIndex: 55278
	{
		// Nested types
		public struct AcbInfo // TypeDefIndex: 55276
		{
			// Fields
			public string name; // 0x00
			public uint size; // 0x08
			public uint version; // 0x0C
			public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
			public float volume; // 0x14
			public int numCues; // 0x18
		}
	
		private struct AcbInfoForMarshaling // TypeDefIndex: 55277
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
			} // 0x0000000187880820-0x000000018788087C
		}
	
		// Methods
		public static bool GetAcbInfo(CriAtomExAcb acb, out AcbInfo acbInfo) {
			acbInfo = default;
			return default;
		} // 0x000000018788087C-0x0000000187880900
		private static extern int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out AcbInfoForMarshaling acbInfo); // 0x000000018788044C-0x000000018788049C
	}

	public static class CriAtomExPlaybackDebug // TypeDefIndex: 55279
	{
		// Methods
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value) {
			value = default;
			return default;
		} // 0x00000001878814D0-0x00000001878814E8
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value) {
			value = default;
			return default;
		} // 0x00000001878814E8-0x0000000187881500
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value) {
			value = default;
			return default;
		} // 0x00000001878814B8-0x00000001878814D0
		public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value) {
			value = default;
			return default;
		} // 0x0000000187881488-0x00000001878814A0
		public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value) {
			value = default;
			return default;
		} // 0x00000001878814A0-0x00000001878814B8
		private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value); // 0x0000000187881640-0x00000001878816D0
		private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value); // 0x0000000187881760-0x00000001878817F0
		private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value); // 0x00000001878816D0-0x0000000187881760
		private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value); // 0x0000000187881500-0x0000000187881590
		private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value); // 0x0000000187881590-0x0000000187881640
	}

	public abstract class CriDisposable : IDisposable // TypeDefIndex: 55280
	{
		// Fields
		public Guid guid; // 0x10
	
		// Constructors
		public CriDisposable() {} // 0x0000000185FAA770-0x0000000185FAA7E0
	
		// Methods
		public abstract void Dispose();
	}

	public static class CriDisposableObjectManager // TypeDefIndex: 55283
	{
		// Fields
		private static List<ObjectRef> refList; // 0x00
	
		// Nested types
		public enum ModuleType // TypeDefIndex: 55281
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
	
		public struct ObjectRef // TypeDefIndex: 55282
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
			} // 0x0000000185AD1250-0x0000000185AD1520
		}
	
		// Constructors
		static CriDisposableObjectManager() {} // 0x0000000186474FC4-0x0000000186474FDC
	
		// Methods
		private static int SearchForDisposable(CriDisposable disposable) => default; // 0x0000000185AD0E90-0x0000000185AD1250
		public static void Register(CriDisposable disposable, ModuleType type) {} // 0x0000000187887678-0x00000001878877BC
		public static bool Unregister(CriDisposable disposable) => default; // 0x0000000187887634-0x0000000187887678
		public static bool IsDisposed(CriDisposable disposable) => default; // 0x0000000187887288-0x00000001878872D0
		public static void CallOnModuleFinalization(ModuleType type) {} // 0x000000018788756C-0x0000000187887634
		private static int GetNextWithType(ModuleType type) => default; // 0x00000001878872D0-0x000000018788756C
		public static void DisposeAll(ModuleType type) {} // 0x0000000185F40720-0x0000000185F407B0
	}

	public abstract class CriMonoBehaviour : MonoBehaviour // TypeDefIndex: 55284
	{
		// Fields
		private Guid _guid_k__BackingField; // 0x18
	
		// Properties
		public Guid guid { get; private set; } // 0x0000000185FB30D0-0x0000000185FB30E0 0x0000000185FB30E0-0x0000000185FB30F0
	
		// Constructors
		public CriMonoBehaviour() {} // 0x00000001843D1350-0x00000001843D13D0
	
		// Methods
		protected virtual void OnEnable() {} // 0x0000000184A82F40-0x0000000184A82FB0
		protected virtual void OnDisable() {} // 0x0000000187892E28-0x0000000187892E74
		public abstract void CriInternalUpdate();
		public abstract void CriInternalLateUpdate();
	}

	public class CriMonoBehaviourManager : MonoBehaviour // TypeDefIndex: 55285
	{
		// Fields
		private static CriMonoBehaviourManager _instance; // 0x00
		private static List<CriMonoBehaviour> criMonoBehaviourList; // 0x08
	
		// Properties
		public static CriMonoBehaviourManager instance { get => default; } // 0x0000000184A82FB0-0x0000000184A83010 
	
		// Constructors
		public CriMonoBehaviourManager() {} // 0x000000018646DB20-0x000000018646DB28
		static CriMonoBehaviourManager() {} // 0x0000000185EFF600-0x0000000185EFF6C0
	
		// Methods
		public static void CreateInstance() {} // 0x0000000184A83010-0x0000000184A830D0
		private static int GetIndex(CriMonoBehaviour criMonoBehaviour) => default; // 0x0000000184A83320-0x0000000184A83450
		public bool Register(CriMonoBehaviour criMonoBehaviour) => default; // 0x0000000184A830D0-0x0000000184A83320
		public static bool UnRegister(CriMonoBehaviour criMonoBehaviour) => default; // 0x0000000187892CE0-0x0000000187892E28
		private void Awake() {} // 0x0000000185F091C0-0x0000000185F09290
		private void Update() {} // 0x0000000184A836B0-0x0000000184A83910
		private void LateUpdate() {} // 0x0000000184A83450-0x0000000184A836B0
	}
}

namespace CriWare.CriAtomDebugDetail
{
	public class Utility // TypeDefIndex: 55286
	{
		// Constructors
		public Utility() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static string PtrToStringAutoOrNull(IntPtr stringPtr) => default; // 0x0000000187894F3C-0x0000000187894F88
	}
}

namespace CriWare.CriMana
{
	public enum CodecType // TypeDefIndex: 55305
	{
		Unknown = 0,
		SofdecPrime = 1,
		H264 = 5,
		VP9 = 9
	}

	public enum AlphaType // TypeDefIndex: 55306
	{
		CompoOpaq = 0,
		CompoAlphaFull = 1,
		CompoAlpha3Step = 2,
		CompoAlpha32Bit = 3
	}

	public struct AudioInfo // TypeDefIndex: 55307
	{
		// Fields
		public uint samplingRate; // 0x00
		public uint numChannels; // 0x04
		public uint totalSamples; // 0x08
	}

	[Serializable]
	public class MovieInfo // TypeDefIndex: 55308
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
		public bool hasAlpha { get => default; internal set {} } // 0x000000018789875C-0x0000000187898764 0x0000000187898764-0x0000000187898780
	
		// Constructors
		public MovieInfo() {} // 0x0000000185492010-0x0000000185492020
	}

	public class FrameInfo // TypeDefIndex: 55309
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
		public FrameInfo() {} // 0x0000000185492010-0x0000000185492020
	}

	public struct EventPoint // TypeDefIndex: 55310
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

	public static class Settings // TypeDefIndex: 55311
	{
		// Methods
		public static void SetDecodeSkippingEnabled(bool enabled) {} // 0x000000018789F238-0x000000018789F284
	}

	public class Player : CriDisposable // TypeDefIndex: 55326
	{
		// Fields
		private const int InvalidPlayerId = -1; // Metadata: 0x0207BDE7
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
		private SubtitleChangeCallback OnSubtitleChanged; // 0xA8
		private bool _additiveMode_k__BackingField; // 0xB0
		private bool _useMaterialBlendMode_k__BackingField; // 0xB1
		private int _maxFrameDrop_k__BackingField; // 0xB4
		private bool _applyTargetAlpha_k__BackingField; // 0xB8
		private bool _uiRenderMode_k__BackingField; // 0xB9
		private IntPtr _subtitleBuffer_k__BackingField; // 0xC0
		private int _subtitleSize_k__BackingField; // 0xC8
		private CriManaMoviePlayerHolder _playerHolder_k__BackingField; // 0xD0
		protected Queue<Operation> operationQueue; // 0xD8
		protected Operation? cntOperation; // 0xE0
	
		// Properties
		private Status requiredStatus { get => default; set {} } // 0x000000018789A0B8-0x000000018789A0F0 0x000000018789B460-0x000000018789B4A0
		public bool additiveMode { get; set; } // 0x000000018789B9FC-0x000000018789BA44 0x000000018789B948-0x000000018789B9FC
		public bool useMaterialBlendMode { get; set; } // 0x000000018789B368-0x000000018789B380 0x000000018789B1FC-0x000000018789B208
		public int maxFrameDrop { get; set; } // 0x000000018789B68C-0x000000018789B754 0x000000018789B5D0-0x000000018789B600
		public bool applyTargetAlpha { get; set; } // 0x000000018789B5A0-0x000000018789B5D0 0x000000018789B4F4-0x000000018789B5A0
		public bool uiRenderMode { get; set; } // 0x000000018789B654-0x000000018789B68C 0x000000018789B31C-0x000000018789B32C
		public bool isFrameAvailable { get => default; } // 0x000000018789B7D8-0x000000018789B7EC 
		public MovieInfo movieInfo { get => default; } // 0x000000018789B810-0x000000018789B81C 
		public FrameInfo frameInfo { get => default; } // 0x000000018789B804-0x000000018789B810 
		public Status status { get => default; } // 0x000000018789B81C-0x000000018789B828 
		public Status nativeStatus { get => default; } // 0x000000018789B7EC-0x000000018789B7F8 
		public int numberOfEntries { get => default; } // 0x000000018789B4DC-0x000000018789B4E8 
		public IntPtr subtitleBuffer { get; private set; } // 0x000000018789B7F8-0x000000018789B804 0x000000018789B4D0-0x000000018789B4DC
		public int subtitleSize { get; private set; } // 0x000000018789B4AC-0x000000018789B4D0 0x000000018789B834-0x000000018789B840
		public CriAtomExPlayer atomExPlayer { get => default; } // 0x000000018789B840-0x000000018789B864 
		public CriAtomEx3dSource atomEx3DsourceForAmbisonics { get => default; } // 0x000000018789B60C-0x000000018789B618 
		public TimerType timerType { get => default; } // 0x000000018789B618-0x000000018789B63C 
		public CriManaMoviePlayerHolder playerHolder { get; set; } // 0x000000018789B8DC-0x000000018789B8E8 0x000000018789AD10-0x000000018789AD1C
		public bool isAlive { get => default; } // 0x00000001878997E8-0x000000018789981C 
	
		// Events
		public event SubtitleChangeCallback OnSubtitleChanged;
	
		// Nested types
		public enum Status // TypeDefIndex: 55312
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
	
		public enum SetMode // TypeDefIndex: 55313
		{
			New = 0,
			Append = 1,
			AppendRepeatedly = 2
		}
	
		public enum MovieEventSyncMode // TypeDefIndex: 55314
		{
			FrameTime = 0,
			PlayBackTime = 1
		}
	
		public enum AudioTrack // TypeDefIndex: 55315
		{
			Off = 0,
			Auto = 1
		}
	
		public enum TimerType // TypeDefIndex: 55316
		{
			None = 0,
			System = 1,
			Audio = 2,
			User = 3,
			Manual = 4
		}
	
		public delegate void CuePointCallback(ref EventPoint eventPoint); // TypeDefIndex: 55317; 0x000000018789C508-0x000000018789C528
	
		public delegate void StatusChangeCallback(Status status); // TypeDefIndex: 55318; 0x0000000181B10460-0x0000000181B10470
	
		public delegate void SubtitleChangeCallback(IntPtr subtitleBuffer); // TypeDefIndex: 55319; 0x0000000185FB3300-0x0000000185FB3310
	
		public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode); // TypeDefIndex: 55320; 0x0000000185FB3320-0x0000000185FB3330
	
		private delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint); // TypeDefIndex: 55321; 0x000000018789C3FC-0x000000018789C470
	
		public enum CriManaUnityPlayer_RenderEventAction // TypeDefIndex: 55322
		{
			UPDATE = 0,
			INITIALIZE = 256,
			RENDER = 512,
			DESTROY = 768
		}
	
		protected enum OperationType // TypeDefIndex: 55323
		{
			Normal = 0,
			SetFile = 1,
			SeekToTime = 2,
			Pause = 3
		}
	
		protected struct Operation // TypeDefIndex: 55324
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
			public static Operation Start() => default; // 0x0000000181B388F0-0x0000000181B38900
			public static Operation Pause(bool sw) => default; // 0x00000001835FC740-0x00000001835FC750
			public static Operation Stop() => default; // 0x0000000185FB32E0-0x0000000185FB32F0
			public static Operation StopForSeek() => default; // 0x0000000185FB3310-0x0000000185FB3320
			public static Operation Prepare() => default; // 0x000000018140CF50-0x000000018140CF60
			public static Operation PrepareForRendering() => default; // 0x0000000185FB0510-0x0000000185FB0520
			public static Operation SetFile(CriFsBinder binder, string moviePath, SetMode setMode) => default; // 0x00000001834A0D50-0x00000001834A0D60
			public static Operation SeekToTime(float time) => default; // 0x0000000185FB15A0-0x0000000185FB15B0
		}
	
		private sealed class _IssuePluginUpdatesForFrames_d__152 : IEnumerator<object> // TypeDefIndex: 55325
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Player __4__this; // 0x20
			public int playerId; // 0x28
			public int frameCount; // 0x2C
			public bool destroy; // 0x30
			public MonoBehaviour playerHolder; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018789ABE4-0x000000018789AC58 
			object IEnumerator.Current { get => default; } // 0x0000000187899E40-0x0000000187899FBC 
	
			// Constructors
			public _IssuePluginUpdatesForFrames_d__152() {} // Dummy constructor
			public _IssuePluginUpdatesForFrames_d__152(int __1__state) {} // 0x000000018774BD78-0x000000018774BD8C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018789C024-0x000000018789C1C8
			private bool MoveNext() => default; // 0x000000018789BD34-0x000000018789C024
			void IEnumerator.Reset() {} // 0x000000018789A348-0x000000018789A398
		}
	
		// Constructors
		public Player() {} // 0x000000018789B864-0x000000018789B870
		public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length) {} // 0x000000018789AC70-0x000000018789AC7C
	
		// Methods
		~Player() {} // 0x000000018789B63C-0x000000018789B648
		public override void Dispose() {} // 0x000000018789AC64-0x000000018789AC70
		public void CreateRendererResource(int width, int height, bool alpha) {} // 0x000000018789B4E8-0x000000018789B4F4
		public void DisposeRendererResource() {} // 0x000000018789B828-0x000000018789B834
		public void Prepare() {} // 0x000000018789B600-0x000000018789B60C
		public void PrepareForRendering() {} // 0x000000018789B870-0x000000018789B8D0
		public void Start() {} // 0x0000000185A62990-0x0000000185A629A0
		public void Stop() {} // 0x000000018789AC7C-0x000000018789AC88
		public void StopForSeek() {} // 0x000000018789AC58-0x000000018789AC64
		public void Pause(bool sw) {} // 0x000000018789AD1C-0x000000018789AD44
		public bool IsPaused() => default; // 0x000000018789B4A0-0x000000018789B4AC
		public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x0207BDE0 */) => default; // 0x000000018789B8D0-0x000000018789B8DC
		public bool SetData(IntPtr data, long dataSize, SetMode setMode = SetMode.New /* Metadata: 0x0207BDE1 */) => default; // 0x000000018789B648-0x000000018789B654
		public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New /* Metadata: 0x0207BDE2 */) => default; // 0x000000018789BC88-0x000000018789BD18
		public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New /* Metadata: 0x0207BDE3 */) => default; // 0x000000018789B754-0x000000018789B7D8
		public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New /* Metadata: 0x0207BDE4 */) => default; // 0x000000018789BC18-0x000000018789BC88
		public void Loop(bool sw) {} // 0x000000018789BD18-0x000000018789BD34
		public void SetMasterTimerType(TimerType timerType) {} // 0x000000018789B32C-0x000000018789B368
		public void SetSeekPosition(int frameNumber) {} // 0x000000018789BA44-0x000000018789BAAC
		public void SetMovieEventSyncMode(MovieEventSyncMode mode) {} // 0x000000018789C3D8-0x000000018789C3E0
		public void SetSpeed(float speed) {} // 0x000000018789B208-0x000000018789B280
		public void SetMaxPictureDataSize(uint maxDataSize) {} // 0x000000018789A0F0-0x000000018789A348
		public void SetBufferingTime(float sec) {} // 0x000000018789AD44-0x000000018789B140
		public void SetMinBufferSize(int min_buffer_size) {} // 0x000000018789B280-0x000000018789B31C
		public void SetAudioTrack(int track) {} // 0x000000018789A09C-0x000000018789A0B8
		public void SetAudioTrack(AudioTrack track) {} // 0x000000018789B3C4-0x000000018789B460
		public void SetSubAudioTrack(int track) {} // 0x000000018789BAAC-0x000000018789BC18
		public void SetSubAudioTrack(AudioTrack track) {} // 0x000000018789B140-0x000000018789B1FC
		public void SetExtraAudioTrack(int track) {} // 0x00000001878988E4-0x00000001878989A8
		public void SetExtraAudioTrack(AudioTrack track) {} // 0x000000018789A024-0x000000018789A09C
		public void SetVolume(float volume) {} // 0x000000018789B368-0x000000018789B380
		public float GetVolume() => default; // 0x0000000187899FBC-0x000000018789A024
		public void SetSubAudioVolume(float volume) {} // 0x0000000187899DCC-0x0000000187899DF8
		public float GetSubAudioVolume() => default; // 0x00000001878992F4-0x0000000187899320
		public void SetExtraAudioVolume(float volume) {} // 0x0000000187899530-0x00000001878995B4
		public float GetExtraAudioVolume() => default; // 0x00000001878996BC-0x00000001878996F0
		public void SetBusSendLevel(string bus_name, float level) {} // 0x0000000187899C88-0x0000000187899D30
		public void SetSubAudioBusSendLevel(string bus_name, float volume) {} // 0x0000000187899754-0x00000001878997E8
		public void SetExtraAudioBusSendLevel(string bus_name, float volume) {} // 0x0000000187899154-0x0000000187899208
		public void SetSubtitleChannel(int channel) {} // 0x0000000187899388-0x000000018789941C
		public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback) {} // 0x000000018789941C-0x00000001878994B8
		public long GetTime() => default; // 0x0000000187898E38-0x0000000187898EFC
		public int GetDisplayedFrameNo() => default; // 0x0000000187899B6C-0x0000000187899C14
		public bool HasRenderedNewFrame() => default; // 0x0000000187898A2C-0x0000000187898AFC
		public void SetAsrRackId(int asrRackId) {} // 0x000000018789985C-0x0000000187899904
		public void SetUserTimeCorrectionThreshold(uint threshold_msec) {} // 0x0000000187899904-0x00000001878999B4
		public void SetExtraFramePoolSize(uint size) {} // 0x0000000187899208-0x000000018789923C
		public void UpdateWithUserTime(ulong timeCount, ulong timeUnit) {} // 0x00000001878994B8-0x00000001878994EC
		public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD) {} // 0x0000000187899AE0-0x0000000187899B6C
		public void UpdateWithManualTimeAdvanced() {} // 0x0000000187898B70-0x0000000187898C4C
		public void Update() {} // 0x0000000187898F64-0x0000000187898FF8
		public void OnWillRenderObject(CriManaMovieMaterialBase sender) {} // 0x0000000187898F30-0x0000000187898F64
		public bool UpdateMaterial(Material material) => default; // 0x0000000187899120-0x0000000187899154
		public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction) {} // 0x000000018789927C-0x00000001878992BC
		private void Dispose(bool disposing) {} // 0x0000000187899C48-0x0000000187899C88
		private void InternalUpdate() {} // 0x0000000187898B30-0x0000000187898B70
		private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy, int playerId) => default; // 0x0000000187899D30-0x0000000187899D68
		private void DisableInfos(bool keepFrameInfo = false /* Metadata: 0x0207BDE5 */) {} // 0x00000001878990AC-0x00000001878990EC
		private void PrepareNativePlayer() {} // 0x0000000187899354-0x0000000187899388
		private void UpdateNativePlayer() {} // 0x0000000187898EFC-0x0000000187898F30
		private void InvokePlayerStatusCheck() {} // 0x0000000187898AFC-0x0000000187898B30
		private void AllocateSubtitleBuffer(int size) {} // 0x0000000187899320-0x0000000187899354
		private void DeallocateSubtitleBuffer() {} // 0x0000000187899AA0-0x0000000187899AE0
		internal void PauseOnApplicationPause(bool sw) {} // 0x0000000187898C90-0x0000000187898CD4
		private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint) {} // 0x0000000187899A6C-0x0000000187899AA0
		private static extern int CRIWAREFD186F02(); // 0x00000001878989EC-0x0000000187898A2C
		private static extern int CRIWARE72A5B8BF(); // 0x0000000187898C4C-0x0000000187898C90
		private static extern int CRIWARE95A85424(bool useAtomExPlayer, uint maxPathLength); // 0x00000001878995B4-0x00000001878995E8
		private static extern void CRIWAREABF659EC(int player_id); // 0x0000000187898CD4-0x0000000187898D14
		private static extern void CRIWAREEDB46019(int player_id, IntPtr binder, string path); // 0x00000001878989A8-0x00000001878989EC
		private static extern void CRIWAREB28B5D50(int player_id, IntPtr binder, int content_id); // 0x00000001878999B4-0x00000001878999E8
		private static extern void CRIWARE65553651(int player_id, string path, ulong offset, long range); // 0x0000000187898DD4-0x0000000187898E38
		private static extern void CRIWARE7C753A2E(int player_id, IntPtr data, long datasize); // 0x00000001878996F0-0x0000000187899754
		private static extern void CRIWARE7C753A2E(int player_id, byte[] data, long datasize); // 0x0000000187899D68-0x0000000187899DCC
		private static extern bool CRIWARE328F2911(int player_id, IntPtr binder, string path, bool repeat); // 0x0000000187898D94-0x0000000187898DD4
		private static extern bool CRIWAREDA0693CD(int player_id, IntPtr binder, int content_id, bool repeat); // 0x0000000187899678-0x00000001878996BC
		private static extern bool CRIWARE162DD162(int player_id, string path, ulong offset, long range, bool repeat); // 0x0000000187898FF8-0x0000000187899078
		private static extern bool CRIWAREC35C3DC3(int player_id, IntPtr data, long datasize, bool repeat); // 0x00000001878994EC-0x0000000187899530
		private static extern bool CRIWAREC35C3DC3(int player_id, byte[] data, long datasize, bool repeat); // 0x000000018789923C-0x000000018789927C
		private static extern void CRIWARE66A63134(int player_id); // 0x0000000187899638-0x0000000187899678
		private static extern int CRIWARE88D04318(int player_id); // 0x0000000187899C14-0x0000000187899C48
		private static extern void CRIWARED9F7168D(int player_id, CuePointCallbackFromNativeDelegate cbfunc); // 0x000000018789981C-0x000000018789985C
		private static extern void CRIWARE1E785A43(int player_id, out MovieInfo movie_info); // 0x00000001878999E8-0x0000000187899A38
		private static extern int CRIWARE3CE8CE6A(int player_id, IntPtr subtitle_buffer, ref uint subtitle_size); // 0x00000001878995E8-0x0000000187899638
		private static extern void CRIWARE362A826C(int player_id); // 0x00000001878990EC-0x0000000187899120
		private static extern void CRIWARE61523A0C(int player_id); // 0x0000000187899A38-0x0000000187899A6C
		private static extern void CRIWAREBB898C91(int player_id); // 0x0000000187898D14-0x0000000187898D94
		private static extern void CRIWARE705B8C6D(int player_id, int seek_frame_no); // 0x00000001878992BC-0x00000001878992F4
		private static extern void CRIWAREEB32FC73(int player_id, MovieEventSyncMode mode); // 0x0000000187899078-0x00000001878990AC
		private static extern void CRIWARE18BFCB88(int player_id, int sw); // 0x000000018789C360-0x000000018789C3C8
		private static extern bool CRIWAREEFA5210A(int player_id); // 0x000000018789C2E0-0x000000018789C360
		private static extern void CRIWARE4331E077(int player_id, int sw); // 0x000000018789C260-0x000000018789C2E0
		private static extern long CRIWARE7779586C(int player_id); // 0x0000000187899DF8-0x0000000187899E40
		private static extern int CRIWARE33981CC9(int player_id); // 0x000000018789A928-0x000000018789ABE4
		private static extern IntPtr CRIWARE165B6B70(int player_id); // 0x000000018789A4A4-0x000000018789A518
		private static extern int CRIWARE7500F0DD(int player_id); // 0x000000018789A430-0x000000018789A4A4
		private static extern void CRIWARED99932F6(int player_id, int track); // 0x000000018789A7DC-0x000000018789A850
		private static extern void CRIWARE1FF2F5BE(int player_id, float vol); // 0x000000018789A398-0x000000018789A430
		private static extern float CRIWARED30C9C6F(int player_id); // 0x000000018789A8C4-0x000000018789A928
		private static extern void CRIWARE0EA59F65(int player_id, int track); // 0x000000018789A850-0x000000018789A8C4
		private static extern void CRIWARE1EBB12C5(int player_id, float vol); // 0x000000018789A518-0x000000018789A604
		private static extern float CRIWARE966C4BA9(int player_id); // 0x000000018789A604-0x000000018789A6A0
		private static extern void CRIWARE213452EF(int player_id, int track); // 0x000000018789A6A0-0x000000018789A7DC
		private static extern void CRIWARE0348BF1B(int player_id, float vol); // 0x000000018789AC88-0x000000018789AD10
		private static extern float CRIWAREC5A3A88D(int player_id); // 0x0000000187868BC8-0x0000000187868C9C
		private static extern void CRIWARE31668293(int player_id, string bus_name, float level); // 0x00000001833EEC70-0x00000001833EEC80
		private static extern void CRIWAREB2460D7A(int player_id, string bus_name, float level); // 0x00000001878985A0-0x0000000187898620
		private static extern void CRIWAREF4B0CC4E(int player_id, string bus_name, float level); // 0x00000001872076D8-0x00000001872076F4
		private static extern void CRIWARE2C8FF595(int player_id, int channel); // 0x000000018789F4A4-0x000000018789F56C
		private static extern void CRIWAREAB576D15(int player_id, float speed); // 0x00000001833EEC70-0x00000001833EEC80
		private static extern void CRIWARE3F9C5D06(int player_id, uint max_data_size); // 0x000000018789F42C-0x000000018789F4A4
		public static extern void CRIWARE8A87737B(int player_id, float sec); // 0x00000001864BB614-0x00000001864BB734
		public static extern void CRIWARE6756AE56(int player_id, int min_buffer_size); // 0x000000018789F5E4-0x000000018789F6AC
		public static extern void CRIWAREA7F6DE6B(int player_id, int asr_rack_id); // 0x00000001833EEC70-0x00000001833EEC80
		private static extern void CRIWAREE2DF1163(int player_id); // 0x000000018789F56C-0x000000018789F5E4
		private static extern void CRIWAREBD24DE27(int player_id, TimerType timer_type); // 0x00000001864BB614-0x00000001864BB734
		private static extern void CRIWAREC7C5CC77(int player_id, ulong user_count, ulong user_unit); // 0x000000018789F304-0x000000018789F42C
		private static extern void CRIWAREA59E0F01(int player_id, ulong timer_unit_n, ulong timer_unit_d); // 0x0000000181B59400-0x0000000181B59410
		private static extern void CRIWARE55ECC3E4(int player_id); // 0x000000018789F284-0x000000018789F304
		private static extern void CRIWARECEA2FA98(int player_id); // 0x00000001864750A8-0x00000001864751CC
		private static extern IntPtr CRIWARE27ED314F(int player_id, int bufferSize); // 0x00000001878984D8-0x00000001878985A0
		private static extern bool CRIWARE725ED4B4(int player_id); // 0x0000000181A578C0-0x0000000181A578E0
		private static extern void CRIWARE419ECAF8(int player_id); // 0x000000018789842C-0x00000001878984D8
		private static extern IntPtr criWareUnity_GetRenderEventFunc(); // 0x00000001872076D8-0x00000001872076F4
		private static extern void criManaUnityPlayer_SetUserTimeCorrectionThreshold(int player_id, uint threshold_msec); // 0x0000000185FB3250-0x0000000185FB3280
		private static extern void criManaUnityPlayer_SetExtraFramePoolSize(int player_id, uint size); // 0x0000000185FB31A0-0x0000000185FB31C0
		public void ClearAllOperation() {} // 0x0000000185FB32A0-0x0000000185FB32C0
		protected void ExecuteOperation() {} // 0x0000000185FB3280-0x0000000185FB32A0
		public void EasyPrepare() {} // 0x0000000185FB31F0-0x0000000185FB3220
		public void EasyPrepareForRendering() {} // 0x0000000185FB31C0-0x0000000185FB31F0
		public void EasyStart() {} // 0x0000000187898780-0x00000001878987C4
		public void EasyPause(bool sw) {} // 0x0000000185FB3220-0x0000000185FB3250
		public void EasyStop() {} // 0x0000000181378230-0x0000000181378240
		public void EasyStopForSeek() {} // 0x0000000185492010-0x0000000185492020
		public void EasySetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x0207BDE6 */) {} // 0x000000018789F6AC-0x000000018789F758
		public void EasySetSeekTime(float time) {} // 0x0000000181377E40-0x0000000181377E50
		public void EasyStartAtTime(float time) {} // 0x000000018789F758-0x000000018789F7A4
		public float GetVideoLength() => default; // 0x0000000181377E40-0x0000000181377E50
	}
}

namespace CriWare.CriMana.Detail
{
	public static class AutoResisterRendererResourceFactories // TypeDefIndex: 55330
	{
		// Nested types
		public class RendererResourceFactoryH264Yuv : RendererResourceFactory // TypeDefIndex: 55327
		{
			// Constructors
			public RendererResourceFactoryH264Yuv() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x00000001850FA3C0-0x00000001850FA600
			protected override void OnDisposeManaged() {} // 0x000000018789C528-0x000000018789C5C4
			protected override void OnDisposeUnmanaged() {} // 0x0000000185492010-0x0000000185492020
		}
	
		public class RendererResourceFactorySofdecPrimeYuv : RendererResourceFactory // TypeDefIndex: 55328
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuv() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000185FA72C0-0x0000000185FA7300
			protected override void OnDisposeManaged() {} // 0x000000018789C670-0x000000018789C71C
			protected override void OnDisposeUnmanaged() {} // 0x0000000185492010-0x0000000185492020
		}
	
		public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory // TypeDefIndex: 55329
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuvRawData() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x0000000185FA7240-0x0000000185FA7280
			protected override void OnDisposeManaged() {} // 0x000000018789C5C4-0x000000018789C670
			protected override void OnDisposeUnmanaged() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Methods
		public static void InvokeAutoRegister() {} // 0x0000000185FA7280-0x0000000185FA72C0
	}

	public class RendererResourceH264Yuv : RendererResourceSofdecPrimeYuv // TypeDefIndex: 55331
	{
		// Constructors
		public RendererResourceH264Yuv() {} // Dummy constructor
		public RendererResourceH264Yuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) {} // 0x000000018789CD5C-0x000000018789CD6C
	}

	public abstract class RendererResource : IDisposable // TypeDefIndex: 55332
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
		public bool useMaterialBlendMode { get; set; } // 0x0000000185FB08C0-0x0000000185FB08D0 0x0000000185FB08D0-0x0000000185FB08E0
	
		// Constructors
		protected RendererResource() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		~RendererResource() {} // 0x000000018789EF20-0x000000018789EF94
		public void Dispose() {} // 0x000000018789EE98-0x000000018789EEE8
		private void Dispose(bool disposing) {} // 0x000000018789EEE8-0x000000018789EF20
		public int GetNumberOfFrameBeforeDestroy(int playerId) => default; // 0x000000018789EFC8-0x000000018789EFE0
		protected void SetupStaticMaterialProperties() {} // 0x000000018789F034-0x000000018789F238
		private void GetBlendModes(out int srcBlendMode, out int dstBlendMode) {
			srcBlendMode = default;
			dstBlendMode = default;
		} // 0x000000018789EF94-0x000000018789EFC8
		public virtual void SetApplyTargetAlpha(bool flag) {} // 0x000000018789EFE8-0x000000018789EFF4
		public virtual void SetUiRenderMode(bool flag) {} // 0x000000018789F028-0x000000018789F034
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract bool IsPrepared();
		public abstract bool ContinuePreparing();
		public abstract void AttachToPlayer(int playerId);
		public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);
		public abstract bool UpdateMaterial(Material material);
		public abstract void UpdateTextures();
		public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
		public virtual void OnPlayerPause(bool pauseStatus, bool triggredFromApplciationPause) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnPlayerStop() {} // 0x0000000185492010-0x0000000185492020
		public virtual bool OnPlayerStopForSeek() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual void OnPlayerStart() {} // 0x0000000185492010-0x0000000185492020
		public virtual bool ShouldSkipDestroyOnStopForSeek() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool HasRenderedNewFrame() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public static uint NextPowerOfTwo(uint x) => default; // 0x0000000185FB33E0-0x0000000185FB3410
		public static int NextPowerOfTwo(int x) => default; // 0x000000018789EFE0-0x000000018789EFE8
		public static int CeilingWith(int x, int ceilingValue) => default; // 0x0000000185FB33D0-0x0000000185FB33E0
		public static int Ceiling16(int x) => default; // 0x0000000185FB3390-0x0000000185FB33A0
		public static int Ceiling32(int x) => default; // 0x0000000185FB33B0-0x0000000185FB33C0
		public static int Ceiling64(int x) => default; // 0x0000000185FB33C0-0x0000000185FB33D0
		public static int Ceiling256(int x) => default; // 0x0000000185FB33A0-0x0000000185FB33B0
		protected static void DisposeTextures(Texture[] textures) {} // 0x000000018789EDEC-0x000000018789EE98
		protected static void SetKeyword(Material material, string keyword, bool flag) {} // 0x000000018789EFF4-0x000000018789F028
		protected static extern bool CRIWARE98318E69(int player_id, int num_textures, IntPtr[] tex_ptrs, [In, Out] FrameInfo frame_info, ref bool frame_drop); // 0x000000018789EBD4-0x000000018789ECB4
		protected static extern bool CRIWARED618B369(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x000000018789ECB4-0x000000018789ED14
		protected static extern bool CRIWARE5267266A(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x000000018789EB74-0x000000018789EBD4
		protected static extern bool CRIWAREE519EFD4(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x000000018789ED14-0x000000018789ED74
		protected static extern sbyte CRIWAREF14F77D8(int player_id); // 0x000000018789ED74-0x000000018789EDEC
	}

	public abstract class RendererResourceFactory : IDisposable // TypeDefIndex: 55333
	{
		// Fields
		private static SortedList<int, RendererResourceFactory> factoryList; // 0x00
		private bool disposed; // 0x10
	
		// Constructors
		protected RendererResourceFactory() {} // 0x0000000185492010-0x0000000185492020
		static RendererResourceFactory() {} // 0x0000000185F3EDD0-0x0000000185F3EE60
	
		// Methods
		public static void RegisterFactory(RendererResourceFactory factory, int priority) {} // 0x00000001850FA6F0-0x00000001850FA800
		public static void DisposeAllFactories() {} // 0x000000018789CAC8-0x000000018789CC60
		public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x000000018789C71C-0x000000018789CAC8
		~RendererResourceFactory() {} // 0x000000018789CCE8-0x000000018789CD5C
		public void Dispose() {} // 0x000000018789CC98-0x000000018789CCE8
		private void Dispose(bool disposing) {} // 0x000000018789CC60-0x000000018789CC98
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
	}

	public class RendererResourceFactoryPriorityAttribute : Attribute // TypeDefIndex: 55334
	{
		// Fields
		public readonly int priority; // 0x10
	
		// Constructors
		public RendererResourceFactoryPriorityAttribute() {} // Dummy constructor
		public RendererResourceFactoryPriorityAttribute(int priority) {} // 0x0000000181378230-0x0000000181378240
	}

	public class RendererResourceSofdecPrimeYuv : RendererResource // TypeDefIndex: 55335
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
		private static int NumTextureSets { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
		private static bool IsEditor { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public RendererResourceSofdecPrimeYuv() {} // Dummy constructor
		public RendererResourceSofdecPrimeYuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) {} // 0x000000018789E60C-0x000000018789EB74
	
		// Methods
		protected override void OnDisposeManaged() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnDisposeUnmanaged() {} // 0x000000018789DE2C-0x000000018789E0A8
		public override bool IsPrepared() => default; // 0x0000000185FB3370-0x0000000185FB3380
		public override bool ContinuePreparing() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x000000018789DD3C-0x000000018789DE2C
		public override bool OnPlayerStopForSeek() => default; // 0x0000000185FB3380-0x0000000185FB3390
		public override bool HasRenderedNewFrame() => default; // 0x0000000185FB3360-0x0000000185FB3370
		public override void AttachToPlayer(int playerId) {} // 0x000000018789DCD0-0x000000018789DD3C
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop) => default; // 0x000000018789E0A8-0x000000018789E144
		public override bool UpdateMaterial(Material material) => default; // 0x000000018789E144-0x000000018789E36C
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight) {} // 0x000000018789E36C-0x000000018789E478
		public override void UpdateTextures() {} // 0x000000018789E478-0x000000018789E60C
	}

	public class RendererResourceSofdecPrimeYuvRawData : RendererResource // TypeDefIndex: 55336
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
		private static int NumTextureSets { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public RendererResourceSofdecPrimeYuvRawData() {} // Dummy constructor
		public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) {} // 0x000000018789D7A4-0x000000018789DCD0
	
		// Methods
		protected override void OnDisposeManaged() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnDisposeUnmanaged() {} // 0x000000018789CFF0-0x000000018789D05C
		public override bool IsPrepared() => default; // 0x0000000185FB3330-0x0000000185FB3340
		public override bool ContinuePreparing() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) => default; // 0x000000018789CF00-0x000000018789CFF0
		public override bool OnPlayerStopForSeek() => default; // 0x0000000185FB3340-0x0000000185FB3360
		public override bool HasRenderedNewFrame() => default; // 0x0000000185FB2E80-0x0000000185FB2E90
		public override void AttachToPlayer(int playerId) {} // 0x000000018789CD6C-0x000000018789CDD8
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop) => default; // 0x000000018789D05C-0x000000018789D0F0
		public override bool UpdateMaterial(Material material) => default; // 0x000000018789D0F0-0x000000018789D360
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight) {} // 0x000000018789D360-0x000000018789D47C
		public override void UpdateTextures() {} // 0x000000018789D47C-0x000000018789D7A4
		private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma) {} // 0x000000018789CDD8-0x000000018789CF00
	}
}

namespace CriWare.CriTimeline.Atom
{
	public struct CriAtomClipPlayConfig // TypeDefIndex: 55297
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
		} // 0x0000000187895708-0x0000000187895734
	}

	[Serializable]
	public class CriAtomBehaviour : PlayableBehaviour // TypeDefIndex: 55298
	{
		// Fields
		public float volume; // 0x10
		public float pitch; // 0x14
		public float AISACValue; // 0x18
		private static int cPreviewStopTimeMs; // 0x00
		private CriAtomExAcb m_acb; // 0x20
		private string m_lastCueSheetPath; // 0x28
		private CriAtomExPlayback _playback_k__BackingField; // 0x30
		private bool _IsClipPlaying; // 0x34
		private double _CueLength; // 0x38
	
		// Properties
		public CriAtomExPlayback playback { get; private set; } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public bool IsClipPlaying { get => default; private set {} } // 0x0000000185FB0B90-0x0000000185FB0BA0 0x0000000185FB0BB0-0x0000000185FB0BC0
		public double CueLength { get => default; private set {} } // 0x0000000185FB0910-0x0000000185FB0920 0x0000000185FB0930-0x0000000185FB0940
	
		// Constructors
		public CriAtomBehaviour() {} // 0x0000000185FB10F0-0x0000000185FB1100
		static CriAtomBehaviour() {} // 0x0000000187895588-0x00000001878955C4
	
		// Methods
		public override void OnGraphStop(Playable playable) {} // 0x0000000185FB3160-0x0000000185FB3170
		public void Play(CriAtomSourceBase atomSource, CriAtomClipPlayConfig config) {} // 0x0000000187894FE4-0x00000001878951C8
		public void PreviewPlay(Guid trackId, bool instantStop, CriAtomClipPlayConfig config) {} // 0x00000001878951C8-0x0000000187895458
		private void WaitAndStop() {} // 0x00000001878954DC-0x0000000187895588
		public void Stop(bool noReleaseTime = false /* Metadata: 0x0207BDD3 */) {} // 0x0000000187895458-0x0000000187895480
		private double GetCueLengthSec(CriAtomExAcb acb, string cueName) => default; // 0x0000000187894F88-0x0000000187894FE4
		private void _WaitAndStop_b__21_0() {} // 0x0000000187895480-0x00000001878954DC
	}

	public class CriAtomClip : CriAtomClipBase // TypeDefIndex: 55299
	{
		// Fields
		public string cueSheet; // 0x30
		public string cueName; // 0x38
	
		// Properties
		public override string CueName { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public override string AcbPath { get => default; } // 0x0000000187895838-0x00000001878958C0 
		public override string AwbPath { get => default; } // 0x00000001878958C0-0x0000000187895948 
	
		// Constructors
		public CriAtomClip() {} // 0x0000000187895830-0x0000000187895838
	
		// Methods
		public override CriAtomExAcb GetAcb() => default; // 0x0000000187895734-0x0000000187895740
		private CriAtomCueSheet GetCueSheet() => default; // 0x0000000187895740-0x000000018789574C
		public override void SetCueFromAtomSource(CriAtomSourceBase atomSource) {} // 0x000000018789574C-0x0000000187895830
	}

	public abstract class CriAtomClipBase : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 55300
	{
		// Fields
		public bool stopWithoutRelease; // 0x18
		public bool muted; // 0x19
		public bool ignoreBlend; // 0x1A
		public bool loopWithinClip; // 0x1B
		public bool stopAtClipEnd; // 0x1C
		public CriAtomBehaviour templateBehaviour; // 0x20
		private double clipDuration; // 0x28
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x0000000185FB3170-0x0000000185FB3180 
		public override double duration { get; } // 0x00000001878956EC-0x0000000187895708 
		public abstract string CueName { get; }
		public abstract string AcbPath { get; }
		public abstract string AwbPath { get; }
	
		// Constructors
		protected CriAtomClipBase() {} // 0x0000000187895688-0x00000001878956EC
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x00000001878955C4-0x0000000187895688
		public void SetClipDuration(double clipDuration) {} // 0x0000000185FB0BD0-0x0000000185FB0BE0
		public abstract CriAtomExAcb GetAcb();
		public abstract void SetCueFromAtomSource(CriAtomSourceBase atomSource);
	}

	[Serializable]
	public class CriAtomMixerBehaviour : PlayableBehaviour // TypeDefIndex: 55301
	{
		// Fields
		internal PlayableDirector m_Director; // 0x10
		internal IEnumerable<TimelineClip> m_Clips; // 0x18
		internal CriAtomSourceBase m_Bind; // 0x20
		internal string m_AisacControls; // 0x28
		internal bool m_StopOnWrapping; // 0x30
		internal bool m_StopAtGraphEnd; // 0x31
		private Guid _m_Guid_k__BackingField; // 0x34
		private const int cScratchTimeIntervalMs = 200; // Metadata: 0x0207BDD4
		private System.DateTime m_lastScrubTime; // 0x48
		private double m_lastDirectorTime; // 0x50
	
		// Properties
		public Guid m_Guid { get; private set; } // 0x0000000185FB3180-0x0000000185FB3190 0x0000000185FB3190-0x0000000185FB31A0
		private static bool IsEditor { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public CriAtomMixerBehaviour() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override void OnPlayableCreate(Playable playable) {} // 0x00000001878959C0-0x0000000187895A40
		public override void OnGraphStop(Playable playable) {} // 0x0000000187895948-0x00000001878959C0
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000187895A40-0x000000018789605C
	}

	public class CriAtomTimelinePreviewer : IDisposable // TypeDefIndex: 55303
	{
		// Fields
		private static CriAtomTimelinePreviewer instance; // 0x00
		private CriAtom atom; // 0x10
		private string lastAcfFile; // 0x18
		private Dictionary<string, CriAtomExAcb> acbTable; // 0x20
		private Dictionary<Guid, PlayerSource> playerTable; // 0x28
		private CriAtomEx3dListener listener3d; // 0x30
	
		// Properties
		public static CriAtomTimelinePreviewer Instance { get => default; } // 0x0000000187896A44-0x0000000187896AAC 
		public static bool IsInitialized { get => default; } // 0x0000000187896EF0-0x0000000187897044 
	
		// Nested types
		private struct PlayerSource // TypeDefIndex: 55302
		{
			// Fields
			public readonly CriAtomExPlayer player; // 0x00
			public readonly CriAtomEx3dSource source3d; // 0x08
	
			// Constructors
			public PlayerSource(CriAtomEx3dListener listener) {
				player = default;
				source3d = default;
			} // 0x0000000187897044-0x00000001878970D4
		}
	
		// Constructors
		public CriAtomTimelinePreviewer() {} // 0x0000000187896868-0x0000000187896A44
	
		// Methods
		public static void InstanceDispose() {} // 0x00000001878970D4-0x0000000187897110
		public CriAtomExPlayer GetPlayer(Guid trackId) => default; // 0x0000000187896B6C-0x0000000187896C2C
		public void SetCue(Guid trackId, CriAtomExAcb acb, string cueName) {} // 0x00000001878964A8-0x0000000187896868
		public CriAtomExAcb GetAcb(string acbPath, string awbPath) => default; // 0x0000000187896AAC-0x0000000187896AE0
		public CriAtomExPlayback Play(Guid trackId) => default; // 0x0000000187896E9C-0x0000000187896EF0
		public void StopTrack(Guid trackId, bool stopWithoutRelease = true /* Metadata: 0x0207BDD6 */) {} // 0x0000000187896D34-0x0000000187896E9C
		public void StopAllTracks(bool stopWithoutRelease = true /* Metadata: 0x0207BDD7 */) {} // 0x0000000187896CB0-0x0000000187896CF0
		public void SetStartTime(Guid trackId, long startTimeMs) {} // 0x0000000187896C2C-0x0000000187896C6C
		public void SetLoop(Guid trackId, bool sw) {} // 0x0000000187896CF0-0x0000000187896D34
		public void SetVolume(Guid trackId, float volume) {} // 0x0000000187896C6C-0x0000000187896CB0
		public void SetPitch(Guid trackId, float pitch) {} // 0x0000000187896B1C-0x0000000187896B6C
		public void SetAISAC(Guid trackId, string controlName, float value) {} // 0x0000000187896AE0-0x0000000187896B1C
		public void PlayerUpdateParameter(Guid trackId, CriAtomExPlayback atomExPlayback) {} // 0x0000000187896434-0x00000001878964A8
		~CriAtomTimelinePreviewer() {} // 0x000000018789605C-0x00000001878960AC
		public void Dispose() {} // 0x00000001878960AC-0x0000000187896434
		private void Dispose(bool disposing) {} // 0x00000001878987C4-0x00000001878988E4
	}

	public class CriAtomTrack : TrackAsset // TypeDefIndex: 55304
	{
		// Fields
		public string m_AisacControls; // 0xC0
		public bool m_StopOnWrapping; // 0xC8
		public bool m_StopAtGraphEnd; // 0xC9
	
		// Constructors
		public CriAtomTrack() {} // 0x000000018789757C-0x00000001878975D0
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject owner, int inputCount) => default; // 0x0000000187897110-0x000000018789757C
	}
}

namespace CriWare.CriTimeline.Mana
{
	[Serializable]
	public class CriManaBehaviour : PlayableBehaviour // TypeDefIndex: 55287
	{
		// Constructors
		public CriManaBehaviour() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CriManaClip : CriManaClipBase // TypeDefIndex: 55288
	{
		// Fields
		public string m_moviePath; // 0xA8
		public TextAsset m_movieData; // 0xB0
	
		// Properties
		public override string MoviePath { get => default; } // 0x000000018349D730-0x000000018349D740 
		public override byte[] MovieData { get => default; } // 0x000000018788E840-0x000000018788E8B8 
		public override string MovieName { get => default; } // 0x000000018788E8B8-0x000000018788E954 
		public override int DataId { get => default; } // 0x000000018788E798-0x000000018788E840 
	
		// Constructors
		public CriManaClip() {} // 0x000000018788E748-0x000000018788E798
	}

	public abstract class CriManaClipBase : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 55290
	{
		// Fields
		public readonly Guid guid; // 0x18
		public bool m_loopWithinClip; // 0x28
		public bool m_useOnMemoryPlayback; // 0x29
		public GCHandle gcHandle; // 0x30
		private double m_movieFrameRate; // 0x38
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
		public ClipCaps clipCaps { get; } // 0x0000000181B87DE0-0x0000000181B87DF0 
		public bool IsMovieInfoReady { get; } // 0x000000018788E6F0-0x000000018788E72C 
		public override double duration { get; } // 0x000000018788E72C-0x000000018788E748 
	
		// Nested types
		private struct MovieInfoStruct // TypeDefIndex: 55289
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
		protected CriManaClipBase() {} // 0x000000018788E62C-0x000000018788E6F0
	
		// Methods
		private MovieInfoStruct? StructToMovieInfo(MovieInfo movieInfo) => default; // 0x000000018788E554-0x000000018788E62C
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018788E13C-0x000000018788E200
		public void ReplaceMovieInfo(MovieInfo movieInfo) {} // 0x000000018788E3A8-0x000000018788E554
		public bool IsSameMovie(MovieInfo movieInfo) => default; // 0x000000018788E2CC-0x000000018788E3A8
		public int GetSeekFrame(double seekTimeSec, bool loop) => default; // 0x000000018788E200-0x000000018788E2CC
	}

	[Serializable]
	public class CriManaMixerBehaviour : PlayableBehaviour // TypeDefIndex: 55295
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
		private static bool IsEditMode { get => default; } // 0x000000018788EB84-0x000000018788EBA8 
	
		// Nested types
		private enum MovieMixerState // TypeDefIndex: 55291
		{
			Preloading = 0,
			Ready = 1,
			Playing = 2,
			Stopping = 3,
			Stopped = 4
		}
	
		private enum ClipState // TypeDefIndex: 55292
		{
			Idle = 0,
			Prepare = 1,
			Play = 2,
			Seek = 3
		}
	
		private struct _ProcessFrameOnSeeking_d__31 : IAsyncStateMachine // TypeDefIndex: 55293
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public CriManaMixerBehaviour __4__this; // 0x28
			public TimelineClip activeClip; // 0x30
			public CriManaClipBase clip; // 0x38
			public double frameTime; // 0x40
			private bool _movieInfoReplaced_5__2; // 0x48
			private TaskAwaiter __u__1; // 0x50
	
			// Methods
			private void MoveNext() {} // 0x00000001814A81B0-0x00000001814A81C0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018788EC44-0x000000018788ED00
		}
	
		private sealed class _seekPlaybackEnumerator_d__35 : IEnumerator<object> // TypeDefIndex: 55294
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriManaMixerBehaviour __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187890A64-0x0000000187890AE0 
			object IEnumerator.Current { get => default; } // 0x000000018788EC24-0x000000018788EC44 
	
			// Constructors
			public _seekPlaybackEnumerator_d__35() {} // Dummy constructor
			public _seekPlaybackEnumerator_d__35(int __1__state) {} // 0x000000018788F2C8-0x000000018788F68C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018788F68C-0x000000018788F8E4
			private bool MoveNext() => default; // 0x0000000187890AE0-0x0000000187890BE8
			void IEnumerator.Reset() {} // 0x000000018788EBA8-0x000000018788EBD8
		}
	
		// Constructors
		public CriManaMixerBehaviour() {} // 0x000000018789FFB0-0x000000018789FFFC
		static CriManaMixerBehaviour() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private void KeepAudioVolume(bool fadeAudio) {} // 0x000000018788EBD8-0x000000018788EC24
		private bool PlayMovie(CriManaClipBase clipAsset, int startFrame, double startTime) => default; // 0x000000018788F8E4-0x000000018788F9C0
		private bool PrepareMovie(CriManaClipBase clipAsset) => default; // 0x000000018788E954-0x000000018788EA04
		private bool StopMovie() => default; // 0x0000000187890BE8-0x0000000187890DA8
		private bool StopForSeekMovie() => default; // 0x000000018788F9C0-0x0000000187890A64
		private static bool IsPlayerPreparing(Player player) => default; // 0x0000000187890DE8-0x0000000187890E44
		private static bool IsPlayerStopped(Player player) => default; // 0x000000018788ED0C-0x000000018788ED18
		private static bool IsPlayerError(Player player) => default; // 0x000000018788ED00-0x000000018788ED0C
		private static bool IsPlayerReadyOrPlaying(Player player) => default; // 0x000000018788F240-0x000000018788F2C8
		private void ProcessFrameOnSeeking(TimelineClip activeClip, CriManaClipBase clip, double frameTime) {} // 0x000000018788ED18-0x000000018788EFF4
		private void ForceSyncedStop(bool keepLastFrame = false /* Metadata: 0x0207BDC9 */) {} // 0x000000018788EFF4-0x000000018788F15C
		private void ToggleFMVNode(FrameData info, bool isOn) {} // 0x000000018788F15C-0x000000018788F1F4
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x000000018788F1F4-0x000000018788F240
		private IEnumerator seekPlaybackEnumerator() => default; // 0x000000018788EA04-0x000000018788EB84
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000185FB3030-0x0000000185FB3060
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000187890DA8-0x0000000187890DE8
		private void PausePlayer(bool pause) {} // 0x000000018789F7A4-0x000000018789FEEC
		public override void OnGraphStart(Playable playable) {} // 0x0000000186475504-0x0000000186475510
		public override void OnGraphStop(Playable playable) {} // 0x0000000181378230-0x0000000181378240
		public override void OnPlayableCreate(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public override void OnPlayableDestroy(Playable playable) {} // 0x000000018789FEEC-0x000000018789FFB0
		public void InitMovieMixerState() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class CriManaTrack : TrackAsset // TypeDefIndex: 55296
	{
		// Fields
		public bool frameSync; // 0xC0
		public readonly Guid guid; // 0xC4
		private static Dictionary<int, Guid> bindDict; // 0x00
		private CriManaMixerBehaviour _MixerBehaviour_k__BackingField; // 0xD8
	
		// Properties
		public CriManaMixerBehaviour MixerBehaviour { get; private set; } // 0x0000000185FB02F0-0x0000000185FB0300 0x00000001873368EC-0x0000000187336900
	
		// Constructors
		public CriManaTrack() {} // 0x00000001878983CC-0x000000018789842C
		static CriManaTrack() {} // 0x0000000187898340-0x00000001878983CC
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000187897A44-0x0000000187897EC0
		public void BindBehaviourMovieMaterial(PlayableDirector director, CriManaMovieMaterialBase boundMovieMaterial) {} // 0x00000001878975D0-0x0000000187897A44
		private void OnDestroy() {} // 0x0000000187897EC0-0x0000000187897F14
		private static void RemoveTrackFromBindDict(CriManaTrack trackAsset) {} // 0x0000000187897F14-0x0000000187898340
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 55013
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 55339
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000187898620-0x0000000187898684
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 55340
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001878986C8-0x000000018789875C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000187898684-0x00000001878986C8
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 55341
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001878A01E4-0x00000001878A0248
		public static bool IsPatched(int id) => default; // 0x00000001878A02D4-0x00000001878A036C
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001878A00A0-0x00000001878A016C
		public object CreateWrapper(int id) => default; // 0x00000001878A016C-0x00000001878A01E4
		public object InitWrapperArray(int len) => default; // 0x00000001878A0248-0x00000001878A02D4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018789FFFC-0x00000001878A00A0
	}
}
