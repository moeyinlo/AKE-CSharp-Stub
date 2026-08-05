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

// Image 34: CriMw.CriWare.Runtime.dll - Assembly: CriMw.CriWare.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57653-57982
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 57979
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D; // 0x00 // Static value (base64): AQAAAAIAAAADAAAA - Metadata: 0x0234BABC

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 57978
	{
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 57655
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 57656
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 57657
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 57658
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 57659
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace CriWare
{
	public class CriWarePS5 // TypeDefIndex: 57664
	{
		// Fields
		public const int SystemUserID = 255; // Metadata: 0x0234B75F
	
		// Nested types
		public enum AudioPortType : ushort // TypeDefIndex: 57660
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
	
		public enum AttributeId // TypeDefIndex: 57661
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
	
		public enum PortFlag : uint // TypeDefIndex: 57662
		{
			Restricted = 1,
			Passthrough = 2
		}
	
		internal static class SafeNativeMethods // TypeDefIndex: 57663
		{
			// Methods
			public static void criFsUnity_Setup_PS5(bool enable_apr_direct_mode); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CriWarePS5(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal static void SetupFileSystem(bool enableAprDirectMode); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class CriAtomPlugin // TypeDefIndex: 57666
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
		public static bool isInitialized { get; } // 0x00000001868E32C4-0x00000001868E330C 
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 57665; 0x00000001814E2060-0x00000001814E2070
	
		// Constructors
		static CriAtomPlugin(); // 0x0000000184CDA3F0-0x0000000184CDA4C0
	
		// Methods
		public static void Log(string log); // 0x00000001841E1670-0x00000001841E1680
		public static void ExecuteQueuedCueLinkCallbacks(); // 0x0000000183C8D5F0-0x0000000183C8D640
		public static void ExecuteQueuedEventCallbacks(); // 0x0000000183C8D570-0x0000000183C8D5C0
		public static void ExecuteQueuedBeatSyncCallbacks(); // 0x0000000183C8D4F0-0x0000000183C8D540
		public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list); // 0x00000001868E2C68-0x00000001868E2D8C
		private static IntPtr GetSpatializerCoreInterfaceFromAtomOculusAudioBridge(); // 0x00000001868E307C-0x00000001868E3214
		public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_aisacs, int max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, bool vr_mode); // 0x0000000183A081A0-0x0000000183A08340
		public static void SetConfigMonitorParametes(int max_preview_objects, int communication_buffer_size, int playback_position_update_interval); // 0x0000000183A06C50-0x0000000183A06CC0
		public static void SetConfigAdditionalParameters_EDITOR(bool enable_user_pcm_output, int user_pcm_buffer_length); // 0x0000000183A06AF0-0x0000000183A06B40
		public static void SetConfigAdditionalParameters_PC(long buffering_time_pc); // 0x0000000183A06AA0-0x0000000183A06AF0
		public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output, int pulse_latency_usec); // 0x0000000183A06B80-0x0000000183A06BE0
		public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios); // 0x0000000183A06BE0-0x0000000183A06C50
		public static void SetConfigAdditionalParameters_ANDROID(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio, int stream_type); // 0x0000000183A06CC0-0x0000000183A06D70
		public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders); // 0x00000001841E1670-0x00000001841E1680
		public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices); // 0x00000001841E1670-0x00000001841E1680
		public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports); // 0x00000001841E1670-0x00000001841E1680
		public static void SetConfigAdditionalParameters_SWITCH(bool enable_sonicsync, int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket); // 0x00000001841E1670-0x00000001841E1680
		public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices); // 0x00000001841E1670-0x00000001841E1680
		public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming); // 0x00000001868E326C-0x00000001868E32C4
		public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig); // 0x0000000183A06790-0x0000000183A067D0
		public static void InitializeLibrary(); // 0x0000000183A05F80-0x0000000183A06130
		public static bool IsLibraryInitialized(); // 0x0000000183A06A10-0x0000000183A06A60
		public static void FinalizeLibrary(); // 0x00000001868E2AB4-0x00000001868E2C68
		public static void Pause(bool pause); // 0x00000001868E3214-0x00000001868E326C
		public static Common.CpuUsage GetCpuUsage(); // 0x00000001868E2D8C-0x00000001868E2F48
		public static int GetOutputSamplingRate(); // 0x00000001868E303C-0x00000001868E307C
		public static int GetOutputChannels(); // 0x00000001868E2FFC-0x00000001868E303C
		public static bool IsInitializedForPcmOutput(); // 0x00000001812081B0-0x0000000181208610
		public static ushort GetLoopCountParameterId(); // 0x00000001868E2F48-0x00000001868E2FFC
		public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce); // 0x00000001868E29E8-0x00000001868E2AB4
		[AOT.MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
		private static ulong CallbackFromNative(IntPtr ptr1); // 0x00000001868E2998-0x00000001868E29E8
		private static extern void CRIWARE009CE561(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_aisacs, int max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, bool use_ambisonics, IntPtr spatializer_core_interface); // 0x0000000183827F70-0x00000001838280C0
		private static extern void CRIWARE8384362B(uint max_preivew_objects, uint communication_buffer_size, int playback_position_update_interval); // 0x00000001838274A0-0x0000000183827530
		private static extern void CRIWARE237CA5E3(bool enable_user_pcm_out_mode); // 0x0000000183A06B40-0x0000000183A06B80
		private static extern void CRIWARE780E6ED2(long buffering_time_pc); // 0x0000000183827F30-0x0000000183827F70
		private static extern void CRIWAREE996B258(int output, int pulse_latency_usec); // 0x0000000183827EF0-0x0000000183827F30
		private static extern void CRIWARE2F034134(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios); // 0x0000000183827400-0x00000001838274A0
		private static extern void CRIWARE70981A20(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool apply_hw_property, int stream_type); // 0x0000000183827340-0x0000000183827400
		private static extern void CRIWARE2626EF5B(); // 0x0000000183A06130-0x0000000183A06160
		public static extern bool CRIWAREC176B113(); // 0x0000000183A06A60-0x0000000183A06AA0
		private static extern void CRIWARE63E1F278(); // 0x00000001868E27C4-0x00000001868E27F0
		private static extern void CRIWAREB64E0C3B(bool pause); // 0x00000001868E28A8-0x00000001868E28DC
		public static extern uint CRIWAREA703719E(); // 0x00000001868E287C-0x00000001868E28A8
		public static extern void CRIWAREBF97E87F(int code); // 0x00000001868E28DC-0x00000001868E2910
		public static extern void CRIWARE15B0037A(IntPtr cbfunc, string separator_string); // 0x00000001868E256C-0x00000001868E2604
		public static extern void CRIWARE28E5ABA4(IntPtr cbfunc); // 0x00000001868E2638-0x00000001868E266C
		private static extern void CRIWARECCA1268B(); // 0x0000000183C8D5C0-0x0000000183C8D5F0
		public static extern void CRIWARE88175F19(IntPtr cbfunc); // 0x00000001868E281C-0x00000001868E2850
		private static extern void CRIWARE7581CF8C(); // 0x0000000183C8D540-0x0000000183C8D570
		public static extern void CRIWARE15F30D07(IntPtr cbfunc); // 0x00000001868E2604-0x00000001868E2638
		private static extern void CRIWARED1FD92AA(); // 0x0000000183C8D640-0x0000000183C8D670
		private static extern void CRIWARE2CFF30B7(int sampling_rate_for_memory, int sampling_rate_for_streaming); // 0x00000001868E266C-0x00000001868E26AC
		public static extern void CRIWARE797E0462(); // 0x00000001868E27F0-0x00000001868E281C
		public static extern void CRIWAREC54D0552(); // 0x00000001868E2910-0x00000001868E293C
		public static extern void CRIWARE5BC8942D(IntPtr acb_hn, CallbackFromNativeDelegate func, IntPtr obj); // 0x00000001868E2724-0x00000001868E27C4
		public static extern ushort CRIWARE5B1C5B3B(int id); // 0x00000001868E26AC-0x00000001868E2724
		private static extern bool CRIWAREE097EA6E(); // 0x00000001868E293C-0x00000001868E296C
		private static extern int CRIWAREE320F01B(); // 0x00000001868E296C-0x00000001868E2998
		private static extern int CRIWARE98A6BE5C(); // 0x00000001868E2850-0x00000001868E287C
	}

	[Serializable]
	public class CriAtomCueSheet // TypeDefIndex: 57667
	{
		// Fields
		public string name; // 0x10
		public string acbFile; // 0x18
		public string awbFile; // 0x20
		public CriAtomExAcb acb; // 0x28
		public CriAtomExAcbLoader.Status loaderStatus; // 0x30
	
		// Properties
		public bool IsLoading { get; } // 0x00000001868D2DA0-0x00000001868D2DA8 
		public bool IsError { get; } // 0x00000001868D2D84-0x00000001868D2DA0 
	
		// Constructors
		public CriAtomCueSheet(); // 0x00000001868D2D1C-0x00000001868D2D84
	}

	[AddComponentMenu("CRIWARE/CRI Atom")]
	public class CriAtom : CriMonoBehaviour // TypeDefIndex: 57671
	{
		// Fields
		public string acfFile; // 0x28
		private bool acfIsLoading; // 0x30
		public CriAtomCueSheet[] cueSheets; // 0x38
		public string dspBusSetting; // 0x40
		public bool dontDestroyOnLoad; // 0x48
		private static CriAtomExSequencer.EventCallback eventUserCallback; // 0x00
		private static CriAtomExSequencer.EventCbFunc eventUserCbFunc; // 0x08
		[CompilerGenerated]
		private static CriAtomExBeatSync.CbFunc beatsyncUserCbFunc; // 0x10
		private static CriAtomExBeatSync.CbFunc obsoleteBeatSyncFunc; // 0x18
		[CompilerGenerated]
		private static CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc; // 0x20
		[CompilerGenerated]
		private static CriAtom _instance_k__BackingField; // 0x28
		private GCHandle acfRegisterGCHandle; // 0x50
		public bool dontRemoveExistsCueSheet; // 0x58
	
		// Properties
		private static CriAtom instance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001868E7634-0x00000001868E766C 0x00000001868E77CC-0x00000001868E7820
		public static bool CueSheetsAreLoading { get; } // 0x00000001868E75A0-0x00000001868E7634 
	
		// Events
		internal static event CriAtomExSequencer.EventCallback OnEventSequencerCallback {
			add; // 0x00000001868DFCC4-0x00000001868DFCCC
			remove; // 0x00000001868DFCCC-0x00000001868DFCD4
		}
		private static event CriAtomExBeatSync.CbFunc beatsyncUserCbFunc {
			add; // 0x00000001868E7440-0x00000001868E74F0
			remove; // 0x00000001868E766C-0x00000001868E771C
		}
		internal static event CriAtomExBeatSync.CbFunc OnBeatSyncCallback {
			add; // 0x00000001868DC3B8-0x00000001868DC3C0
			remove; // 0x00000001868DC3C0-0x00000001868DC3C8
		}
		private static event CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc {
			add; // 0x00000001868E74F0-0x00000001868E75A0
			remove; // 0x00000001868E771C-0x00000001868E77CC
		}
		internal static event CriAtomEx.CueLinkCbFunc OnCueLinkCallback {
			add; // 0x00000001868E0854-0x00000001868E085C
			remove; // 0x00000001868E1724-0x00000001868E172C
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 57668
		{
			// Fields
			public CriAtom __4__this; // 0x10
			public int i; // 0x18
			public Predicate<CriAtomCueSheet> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _MargeCueSheet_b__0(CriAtomCueSheet sheet); // 0x00000001868E984C-0x00000001868E98A0
		}
	
		[CompilerGenerated]
		private sealed class _LoadAcbFileCoroutine_d__62 : IEnumerator<object> // TypeDefIndex: 57669
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _LoadAcbFileCoroutine_d__62(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001868E9648-0x00000001868E96C0
			private bool MoveNext(); // 0x00000001868E903C-0x00000001868E95FC
			private void __m__Finally1(); // 0x00000001868E96C0-0x00000001868E9708
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001868E95FC-0x00000001868E9648
		}
	
		[CompilerGenerated]
		private sealed class _LoadAcbDataCoroutine_d__64 : IEnumerator<object> // TypeDefIndex: 57670
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _LoadAcbDataCoroutine_d__64(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001868E8F7C-0x00000001868E8FF4
			private bool MoveNext(); // 0x00000001868E8A78-0x00000001868E8F30
			private void __m__Finally1(); // 0x00000001868E8FF4-0x00000001868E903C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001868E8F30-0x00000001868E8F7C
		}
	
		// Constructors
		public CriAtom(); // 0x00000001868E73BC-0x00000001868E7440
	
		// Methods
		public static void AttachDspBusSetting(string settingName); // 0x00000001868E5AF0-0x00000001868E5B70
		public static void DetachDspBusSetting(); // 0x00000001868E5D84-0x00000001868E5DF0
		public static CriAtomCueSheet GetCueSheet(string name); // 0x00000001868E5FB8-0x00000001868E5FE4
		public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, CriFsBinder binder = null); // 0x00000001868E5A48-0x00000001868E5AF0
		public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, CriFsBinder binder = null, bool loadAwbOnMemory = false /* Metadata: 0x0234B784 */); // 0x00000001868E5774-0x00000001868E5814
		public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null); // 0x00000001868E5980-0x00000001868E5A48
		public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null, bool loadAwbOnMemory = false /* Metadata: 0x0234B785 */); // 0x00000001868E56B4-0x00000001868E5774
		public static void RemoveCueSheet(string name); // 0x00000001868E6B4C-0x00000001868E6BC4
		public static CriAtomExAcb GetAcb(string cueSheetName); // 0x00000001868E5DF0-0x00000001868E5EE0
		public static void SetCategoryVolume(string name, float volume); // 0x00000001868DC850-0x00000001868DC858
		public static void SetCategoryVolume(int id, float volume); // 0x00000001868DC848-0x00000001868DC850
		public static float GetCategoryVolume(string name); // 0x00000001868DC7C4-0x00000001868DC7CC
		public static float GetCategoryVolume(int id); // 0x00000001868DC7CC-0x00000001868DC7D4
		public static void SetBusAnalyzer(string busName, bool sw); // 0x00000001868E6D78-0x00000001868E6DA8
		public static void SetBusAnalyzer(bool sw); // 0x00000001868E6DA8-0x00000001868E6DD4
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName); // 0x00000001868E5EE0-0x00000001868E5F10
		[Obsolete("Use CriAtom.GetBusAnalyzerInfo(string busName)")]
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId); // 0x00000001868E5F10-0x00000001868E5F3C
		public void Setup(); // 0x00000001868E6EE8-0x00000001868E7108
		public void Shutdown(); // 0x00000001868E7108-0x00000001868E71F8
		private void Awake(); // 0x00000001868E5B70-0x00000001868E5CDC
		protected override void OnEnable(); // 0x00000001868E6630-0x00000001868E66A0
		private void OnDestroy(); // 0x00000001868E653C-0x00000001868E6630
		public override void CriInternalUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public CriAtomCueSheet GetCueSheetInternal(string name); // 0x00000001868E5F3C-0x00000001868E5FB8
		public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder); // 0x00000001868E5814-0x00000001868E5980
		public void RemoveCueSheetInternal(string name); // 0x00000001868E69E4-0x00000001868E6B4C
		private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet); // 0x00000001868E639C-0x00000001868E653C
		private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile); // 0x00000001868E62A4-0x00000001868E639C
		private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile); // 0x00000001868E60E8-0x00000001868E6198
		private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory); // 0x00000001868E6198-0x00000001868E61E0
		[IteratorStateMachine(typeof(_LoadAcbFileCoroutine_d__62))]
		private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory); // 0x00000001868E61E0-0x00000001868E62A4
		private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory); // 0x00000001868E5FE4-0x00000001868E6024
		[IteratorStateMachine(typeof(_LoadAcbDataCoroutine_d__64))]
		private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory); // 0x00000001868E6024-0x00000001868E60E8
		[AOT.MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCbFunc))]
		public static void SequenceEventCallbackFromNative(string eventString); // 0x00000001868E6C18-0x00000001868E6C6C
		[AOT.MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCallback))]
		private static void SequenceCallbackFromNative(ref CriAtomExSequencer.CriAtomExSequenceEventInfo criAtomExSequenceInfo); // 0x00000001868E6BC4-0x00000001868E6C18
		[AOT.MonoPInvokeCallback(typeof(CriAtomExBeatSync.CbFunc))]
		public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info); // 0x00000001868E5CDC-0x00000001868E5D30
		[AOT.MonoPInvokeCallback(typeof(CriAtomEx.CueLinkCbFunc))]
		public static void CueLinkCallbackFromNative(ref CriAtomEx.CueLinkInfo info); // 0x00000001868E5D30-0x00000001868E5D84
		public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator); // 0x00000001868E6DD4-0x00000001868E6EE8
		private static void RegisterEventCallbackChain(CriAtomExSequencer.EventCallback func); // 0x00000001868E6880-0x00000001868E69E4
		private static void UnregisterEventCallbackChain(CriAtomExSequencer.EventCallback func); // 0x00000001868E72D0-0x00000001868E73BC
		public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func); // 0x00000001868E6C6C-0x00000001868E6D78
		private static void RegisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func); // 0x00000001868E66A0-0x00000001868E6790
		private static void UnregisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func); // 0x00000001868E71F8-0x00000001868E7264
		private static void RegisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func); // 0x00000001868E6790-0x00000001868E6880
		private static void UnregisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func); // 0x00000001868E7264-0x00000001868E72D0
	}

	[AddComponentMenu("CRIWARE/CRI Atom Listener")]
	public class CriAtomListener : CriMonoBehaviour // TypeDefIndex: 57672
	{
		// Fields
		[CompilerGenerated]
		private CriAtomEx3dListener _nativeListener_k__BackingField; // 0x28
		[SerializeField]
		private CriAtomRegion regionOnStart; // 0x30
		public bool activateListenerOnEnable; // 0x38
		private static List<CriAtomListener> listenersList; // 0x00
		private static CriAtomEx3dListener dummyNativeListener; // 0x08
		private Vector3 lastPosition; // 0x3C
		private CriAtomRegion currentRegion; // 0x48
		private bool _isActive; // 0x50
	
		// Properties
		public CriAtomEx3dListener nativeListener { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public bool isActive { get; set; } // 0x0000000184D86800-0x0000000184D86810 0x00000001868E1E1C-0x00000001868E1E7C
		public CriAtomRegion region3d { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001868E1E7C-0x00000001868E2038
	
		// Constructors
		public CriAtomListener(); // 0x00000001868E1E10-0x00000001868E1E1C
		static CriAtomListener(); // 0x0000000184D18690-0x0000000184D18720
	
		// Methods
		public static void CreateDummyNativeListener(); // 0x0000000183A07A80-0x0000000183A07B60
		public static void DestroyDummyNativeListener(); // 0x00000001868E19FC-0x00000001868E1A98
		private void Awake(); // 0x00000001868E18D0-0x00000001868E19EC
		private void Start(); // 0x00000001868E1BBC-0x00000001868E1C20
		protected override void OnEnable(); // 0x00000001868E1B98-0x00000001868E1BBC
		protected override void OnDisable(); // 0x00000001868E1B74-0x00000001868E1B98
		private void OnDestroy(); // 0x00000001868E1A98-0x00000001868E1B74
		public override void CriInternalUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public override void CriInternalLateUpdate(); // 0x00000001868E19EC-0x00000001868E19FC
		private void UpdatePosition(); // 0x00000001868E1C20-0x00000001868E1E10
		public void ActivateListener(bool exclusive = true /* Metadata: 0x0234B786 */); // 0x00000001868E172C-0x00000001868E18D0
	}

	public class CriAtomOutputDeviceObserver : CriMonoBehaviour // TypeDefIndex: 57676
	{
		// Fields
		[SerializeField]
		private bool dontDestroyOnLoad; // 0x28
		private bool lastIsConnected; // 0x29
		private bool isConnected; // 0x2A
		private OutputDeviceType lastDeviceType; // 0x2C
		private OutputDeviceType deviceType; // 0x30
		private static CriAtomOutputDeviceObserver instance; // 0x00
		[CompilerGenerated]
		private static DeviceConnectionChangeCallback _onDeviceConnectionChanged; // 0x08
	
		// Properties
		public static bool IsDeviceConnected { get; } // 0x00000001868E2454-0x00000001868E24B4 
		public static OutputDeviceType DeviceType { get; } // 0x00000001868E23F4-0x00000001868E2454 
	
		// Events
		public static event DeviceConnectionChangeCallback OnDeviceConnectionChanged {
			add; // 0x00000001868E22A4-0x00000001868E2344
			remove; // 0x00000001868E24B4-0x00000001868E24BC
		}
		private static event DeviceConnectionChangeCallback _onDeviceConnectionChanged {
			add; // 0x00000001868E2344-0x00000001868E23F4
			remove; // 0x00000001868E24BC-0x00000001868E256C
		}
	
		// Nested types
		public enum OutputDeviceType // TypeDefIndex: 57673
		{
			BuiltinSpeaker = 0,
			WiredDevice = 1,
			WirelessDevice = 2
		}
	
		public delegate void DeviceConnectionChangeCallback(bool isConnected, OutputDeviceType deviceType); // TypeDefIndex: 57674; 0x00000001838E1420-0x00000001838E1430
	
		private static class UnsafeNativeMethods // TypeDefIndex: 57675
		{
		}
	
		// Constructors
		public CriAtomOutputDeviceObserver(); // 0x00000001846D88E0-0x00000001846D88F0
	
		// Methods
		private void Awake(); // 0x00000001868E2038-0x00000001868E218C
		private void OnDestroy(); // 0x00000001868E2210-0x00000001868E22A4
		public override void CriInternalUpdate(); // 0x00000001868E218C-0x00000001868E2210
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("CRIWARE/CRI Atom Region")]
	[DisallowMultipleComponent]
	public class CriAtomRegion : CriMonoBehaviour // TypeDefIndex: 57677
	{
		// Fields
		[CompilerGenerated]
		private CriAtomEx3dRegion _region3dHn_k__BackingField; // 0x28
		internal List<CriAtomSourceBase> referringSources; // 0x30
		internal List<CriAtomListener> referringListeners; // 0x38
		internal List<CriAtomTransceiver> referringTransceivers; // 0x40
	
		// Properties
		public CriAtomEx3dRegion region3dHn { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
		// Constructors
		public CriAtomRegion(); // 0x00000001868E35D4-0x00000001868E36E8
	
		// Methods
		private void Awake(); // 0x00000001868E330C-0x00000001868E3314
		protected override void OnEnable(); // 0x00000001868E35B4-0x00000001868E35D4
		private void OnDestroy(); // 0x00000001868E35AC-0x00000001868E35B4
		protected virtual void InternalInitialize(); // 0x00000001868E3528-0x00000001868E35AC
		protected virtual void InternalFinalize(); // 0x00000001868E3370-0x00000001868E3528
		protected virtual void InitializeParameters(); // 0x00000001868E3314-0x00000001868E3370
		public override void CriInternalUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class CriAtomServer : CriMonoBehaviour // TypeDefIndex: 57678
	{
		// Fields
		private static CriAtomServer _instance; // 0x00
		public Action<bool> onApplicationPausePreProcess; // 0x28
		public Action<bool> onApplicationPausePostProcess; // 0x30
		public static bool KeepPlayingSoundOnPause; // 0x08
		public static bool EnableAutoConsumePcmOutput; // 0x09
	
		// Properties
		public static CriAtomServer instance { get; } // 0x00000001868E38F4-0x00000001868E3948 
	
		// Constructors
		public CriAtomServer(); // 0x00000001846D88E0-0x00000001846D88F0
		static CriAtomServer(); // 0x0000000184D360B0-0x0000000184D361B0
	
		// Methods
		public static void CreateInstance(); // 0x0000000183A06E50-0x0000000183A06F30
		public static void DestroyInstance(); // 0x00000001868E36E8-0x00000001868E378C
		private void Awake(); // 0x0000000184CE6640-0x0000000184CE6740
		protected override void OnEnable(); // 0x0000000183A06E40-0x0000000183A06E50
		protected override void OnDisable(); // 0x00000001868E3794-0x00000001868E384C
		public override void CriInternalUpdate(); // 0x0000000183C8D4A0-0x0000000183C8D4F0
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
		private void ConsumePcmOutput(); // 0x00000001841E1670-0x00000001841E1680
		private void OnApplicationPause(bool appPause); // 0x00000001868E378C-0x00000001868E3794
		private void ProcessApplicationPause(bool appPause); // 0x00000001868E384C-0x00000001868E38F4
	}

	[AddComponentMenu("CRIWARE/CRI Atom Source")]
	public class CriAtomSource : CriAtomSourceBase // TypeDefIndex: 57680
	{
		// Fields
		[SerializeField]
		private string _cueName; // 0xA0
		[SerializeField]
		private string _cueSheet; // 0xA8
	
		// Properties
		public string cueName { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public string cueSheet { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D84CC0-0x0000000184D84CE0
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayAsync_d__11 : IEnumerator<object> // TypeDefIndex: 57679
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriAtomSource __4__this; // 0x20
			public string cueName; // 0x28
			private CriAtomExAcb _acb_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _PlayAsync_d__11(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001868E9708-0x00000001868E9800
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001868E9800-0x00000001868E984C
		}
	
		// Constructors
		public CriAtomSource(); // 0x00000001868E49B0-0x00000001868E4A18
	
		// Methods
		public override CriAtomExPlayback Play(); // 0x00000001868E49A0-0x00000001868E49B0
		protected override CriAtomExAcb GetAcb(); // 0x00000001868E48C0-0x00000001868E48EC
		protected override void PlayOnStart(); // 0x00000001868E4960-0x00000001868E49A0
		[IteratorStateMachine(typeof(_PlayAsync_d__11))]
		private IEnumerator PlayAsync(string cueName); // 0x00000001868E48EC-0x00000001868E4960
	}

	public abstract class CriAtomSourceBase : CriMonoBehaviour // TypeDefIndex: 57682
	{
		// Fields
		[CompilerGenerated]
		private CriAtomExPlayer _player_k__BackingField; // 0x28
		[CompilerGenerated]
		private CriAtomEx3dSource _source_k__BackingField; // 0x30
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
		public CriAtomExPlayer player { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public CriAtomEx3dSource source { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public bool playOnStart { get; set; } // 0x0000000184D88340-0x0000000184D88350 0x0000000184D88350-0x0000000184D88360
		public bool use3dPositioning { get; set; } // 0x0000000184D86F90-0x0000000184D86FA0 0x00000001868E4784-0x00000001868E47BC
		public bool freezeOrientation { get; set; } // 0x0000000184D88E40-0x0000000184D88E50 0x0000000184D88E90-0x0000000184D88EA0
		public bool use3dRandomization { get; set; } // 0x0000000184D88E70-0x0000000184D88E80 0x00000001868E47BC-0x00000001868E488C
		public uint randomPositionListMaxLength { get; set; } // 0x0000000184D86890-0x0000000184D868A0 0x00000001868E44F4-0x00000001868E4564
		public CriAtomRegion region3d { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x00000001868E4564-0x00000001868E4754
		public CriAtomListener listener { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001868E4398-0x00000001868E445C
		public CriAtomRegion regionOnStart { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public CriAtomListener listenerOnStart { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public bool loop { get; set; } // 0x0000000184D88E50-0x0000000184D88E60 0x0000000184D88EA0-0x0000000184D88EB0
		public float volume { get; set; } // 0x0000000184D88E80-0x0000000184D88E90 0x00000001868E488C-0x00000001868E48C0
		public float pitch { get; set; } // 0x0000000184D88E60-0x0000000184D88E70 0x00000001868E44BC-0x00000001868E44F4
		public float pan3dAngle { get; set; } // 0x00000001868E4298-0x00000001868E42C0 0x00000001868E445C-0x00000001868E448C
		public float pan3dDistance { get; set; } // 0x00000001868E42C0-0x00000001868E42E8 0x00000001868E448C-0x00000001868E44BC
		public int startTime { get; set; } // 0x00000001868E42E8-0x00000001868E4310 0x00000001868E4754-0x00000001868E4784
		public long time { get; } // 0x00000001868E4338-0x00000001868E435C 
		public Status status { get; } // 0x00000001868E4310-0x00000001868E4338 
		public bool attenuationDistanceSetting { get; set; } // 0x00000001868E4274-0x00000001868E4298 0x00000001868E435C-0x00000001868E4398
		public bool androidUseLowLatencyVoicePool { get; set; } // 0x0000000182A80FA0-0x0000000182A80FB0 0x0000000182A80FB0-0x0000000182A80FC0
	
		// Nested types
		public enum Status // TypeDefIndex: 57681
		{
			Stop = 0,
			Prep = 1,
			Playing = 2,
			PlayEnd = 3,
			Error = 4
		}
	
		// Constructors
		protected CriAtomSourceBase(); // 0x00000001868E4218-0x00000001868E4274
	
		// Methods
		protected void SetNeedToPlayerUpdateAll(); // 0x0000000184D88E30-0x0000000184D88E40
		protected virtual void InternalInitialize(); // 0x00000001868E3A84-0x00000001868E3B5C
		protected virtual void InternalFinalize(); // 0x00000001868E39EC-0x00000001868E3A84
		private void Awake(); // 0x00000001868E397C-0x00000001868E3984
		protected override void OnEnable(); // 0x00000001868E3BE0-0x00000001868E3C0C
		private void OnDestroy(); // 0x00000001868E3BD8-0x00000001868E3BE0
		protected bool SetInitialSourcePosition(); // 0x00000001868E3F08-0x00000001868E3F90
		protected virtual void SetInitialParameters(); // 0x00000001868E3E50-0x00000001868E3F08
		protected virtual void UpdatePosition(); // 0x00000001868E4050-0x00000001868E4218
		private void Start(); // 0x00000001868E3F90-0x00000001868E403C
		public override void CriInternalUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public override void CriInternalLateUpdate(); // 0x00000001868E3984-0x00000001868E39CC
		public abstract CriAtomExPlayback Play();
		protected abstract CriAtomExAcb GetAcb();
		protected abstract void PlayOnStart();
		public CriAtomExPlayback Play(string cueName); // 0x00000001868E3C3C-0x00000001868E3CB0
		public CriAtomExPlayback Play(int cueId); // 0x00000001868E3CB0-0x00000001868E3D20
		protected CriAtomExPlayback InternalPlayCue(); // 0x00000001868E3B5C-0x00000001868E3BB4
		public void Stop(); // 0x00000001868E403C-0x00000001868E4050
		public void Pause(bool sw); // 0x00000001868E3C0C-0x00000001868E3C3C
		public bool IsPaused(); // 0x00000001868E3BB4-0x00000001868E3BD8
		public void SetBusSendLevel(string busName, float level); // 0x00000001868E3E20-0x00000001868E3E50
		[Obsolete("Use CriAtomSource.SetBusSendLevel(string, float)")]
		public void SetBusSendLevel(int busId, float level); // 0x00000001868E3DF0-0x00000001868E3E20
		public void SetBusSendLevelOffset(string busName, float levelOffset); // 0x00000001868E3DC0-0x00000001868E3DF0
		[Obsolete("Use CriAtomSource.SetBusSendLevelOffset(string, float)")]
		public void SetBusSendLevelOffset(int busId, float levelOffset); // 0x00000001868E3D90-0x00000001868E3DC0
		public void SetAisacControl(string controlName, float value); // 0x00000001868E3D20-0x00000001868E3D50
		[Obsolete("Use CriAtomSource.SetAisacControl")]
		public void SetAisac(string controlName, float value); // 0x00000001868E3D88-0x00000001868E3D90
		public void SetAisacControl(uint controlId, float value); // 0x00000001868E3D50-0x00000001868E3D80
		[Obsolete("Use CriAtomSource.SetAisacControl")]
		public void SetAisac(uint controlId, float value); // 0x00000001868E3D80-0x00000001868E3D88
		public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer); // 0x00000001868E3948-0x00000001868E397C
		public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer); // 0x00000001868E39CC-0x00000001868E39EC
	}

	[AddComponentMenu("CRIWARE/CRI Atom Transceiver")]
	[DisallowMultipleComponent]
	public class CriAtomTransceiver : CriMonoBehaviour // TypeDefIndex: 57684
	{
		// Fields
		[CompilerGenerated]
		private CriAtomEx3dTransceiver _transceiverHn_k__BackingField; // 0x28
		[CompilerGenerated]
		private Vector3 _inputPos_k__BackingField; // 0x30
		[CompilerGenerated]
		private Vector3 _inputFront_k__BackingField; // 0x3C
		[CompilerGenerated]
		private Vector3 _inputUp_k__BackingField; // 0x48
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
		public CriAtomEx3dTransceiver transceiverHn { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public Vector3 inputPos { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88ED0-0x0000000184D88EF0 0x0000000184D88F10-0x0000000184D88F20
		public Vector3 inputFront { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88EB0-0x0000000184D88ED0 0x0000000184D88F00-0x0000000184D88F10
		public Vector3 inputUp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87680-0x0000000184D876A0 0x0000000184D876A0-0x0000000184D876B0
		public CriAtomRegion region3d { get; set; } // 0x0000000184D88EF0-0x0000000184D88F00 0x00000001868E54DC-0x00000001868E56B4
	
		// Nested types
		private delegate void SetControlIdMethod(ushort id); // TypeDefIndex: 57683; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public CriAtomTransceiver(); // 0x00000001868E5388-0x00000001868E54DC
	
		// Methods
		private void Awake(); // 0x00000001868E5070-0x00000001868E5078
		private void Start(); // 0x00000001868E5220-0x00000001868E5284
		protected override void OnEnable(); // 0x00000001868E5200-0x00000001868E5220
		private void OnDestroy(); // 0x00000001868E51F8-0x00000001868E5200
		protected virtual void InternalInitialize(); // 0x00000001868E516C-0x00000001868E51F8
		protected virtual void InternalFinalize(); // 0x00000001868E50F4-0x00000001868E516C
		protected virtual void InitializeParameters(); // 0x00000001868E5080-0x00000001868E50F4
		public override void CriInternalUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public override void CriInternalLateUpdate(); // 0x00000001868E5078-0x00000001868E5080
		private void ApplyCurrentPosition(); // 0x00000001868E4A18-0x00000001868E4D50
		private void ApplyParameters(); // 0x00000001868E4D50-0x00000001868E5070
		private void TrySetAisacControlId(string strId, SetControlIdMethod callback); // 0x00000001868E5284-0x00000001868E5388
	}

	public class CriStructMemory<Type> : IDisposable // TypeDefIndex: 57685
	{
		// Fields
		[CompilerGenerated]
		private byte[] _bytes_k__BackingField;
		private GCHandle gch;
	
		// Properties
		public byte[] bytes { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IntPtr ptr { get; }
	
		// Constructors
		public CriStructMemory();
		public CriStructMemory(int num);
	
		// Methods
		public void Dispose();
	}

	public static class CriAtomEx // TypeDefIndex: 57715
	{
		// Fields
		public const uint InvalidAisacControlId = 4294967295; // Metadata: 0x0234B78F
		public static readonly Dictionary<Randomize3dCalcType, Randomize3dParamType[]> randomize3dParamTable; // 0x00
	
		// Events
		public static event CueLinkCbFunc OnCueLinkCallback {
			add; // 0x00000001868E0854-0x00000001868E085C
			remove; // 0x00000001868E1724-0x00000001868E172C
		}
	
		// Nested types
		public enum CharacterEncoding // TypeDefIndex: 57686
		{
			Utf8 = 0,
			Sjis = 1
		}
	
		public enum SoundRendererType // TypeDefIndex: 57687
		{
			Default = 0,
			Native = 1,
			Hw1 = 1,
			Asr = 2,
			Haptic = 3,
			Hw2 = 9
		}
	
		public enum VoiceAllocationMethod // TypeDefIndex: 57688
		{
			Once = 0,
			Retry = 1
		}
	
		public enum BiquadFilterType // TypeDefIndex: 57689
		{
			Off = 0,
			LowPass = 1,
			HighPass = 2,
			Notch = 3,
			LowShelf = 4,
			HighShelf = 5,
			Peaking = 6
		}
	
		public enum ResumeMode // TypeDefIndex: 57690
		{
			AllPlayback = 0,
			PausedPlayback = 1,
			PreparedPlayback = 2
		}
	
		public enum PanType // TypeDefIndex: 57691
		{
			Unknown = -1,
			Pan3d = 0,
			Pos3d = 1,
			Auto = 2
		}
	
		public enum VoiceControlMethod // TypeDefIndex: 57692
		{
			PreferLast = 0,
			PreferFirst = 1
		}
	
		public enum Parameter // TypeDefIndex: 57693
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
	
		public enum Speaker // TypeDefIndex: 57694
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
	
		public enum Format : uint // TypeDefIndex: 57695
		{
			ADX = 1,
			HCA = 3,
			HCA_MX = 4,
			WAVE = 5,
			RAW_PCM = 6,
			AUDIO_BUFFER = 9
		}
	
		private enum SpeakerSystem : uint // TypeDefIndex: 57696
		{
			Surround_5_1 = 0,
			Surround_7_1 = 1
		}
	
		public struct SpeakerAngles6ch // TypeDefIndex: 57697
		{
			// Fields
			public float frontLeft; // 0x00
			public float frontRight; // 0x04
			public float frontCenter; // 0x08
			public float lowFrequency; // 0x0C
			public float surroundLeft; // 0x10
			public float surroundRight; // 0x14
	
			// Methods
			public static SpeakerAngles6ch Default(); // 0x0000000184D88F60-0x0000000184D88F90
		}
	
		public struct SpeakerAngles8ch // TypeDefIndex: 57698
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
			public static SpeakerAngles8ch Default(); // 0x0000000184D88F90-0x0000000184D88FD0
		}
	
		public struct FormatInfo // TypeDefIndex: 57699
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
	
		public struct AisacControlInfo // TypeDefIndex: 57700
		{
			// Fields
			public readonly string name; // 0x00
			public uint id; // 0x08
	
			// Constructors
			public AisacControlInfo(byte[] data, int startIndex); // 0x00000001868D249C-0x00000001868D2544
		}
	
		public enum Randomize3dCalcType // TypeDefIndex: 57701
		{
			None = -1,
			Rectangle = 0,
			Cuboid = 1,
			Circle = 2,
			Cylinder = 3,
			Sphere = 4,
			List = 6
		}
	
		public enum Randomize3dParamType // TypeDefIndex: 57702
		{
			None = 0,
			Width = 1,
			Depth = 2,
			Height = 3,
			Radius = 4
		}
	
		[Serializable]
		public struct Randomize3dConfig // TypeDefIndex: 57703
		{
			// Fields
			public const int NumOfCalcParams = 3; // Metadata: 0x0234B7F0
			[SerializeField]
			private bool followsOriginalSource; // 0x00
			[SerializeField]
			private Randomize3dCalcType calculationType; // 0x04
			[SerializeField]
			private float[] calculationParameters; // 0x08
	
			// Properties
			public bool FollowsOriginalSource { get; } // 0x0000000184D883E0-0x0000000184D883F0 
			public Randomize3dCalcType CalculationType { get; } // 0x0000000184D88B20-0x0000000184D88B30 
			public float CalculationParameter1 { get; } // 0x00000001868E8720-0x00000001868E874C 
			public float CalculationParameter2 { get; } // 0x00000001868E874C-0x00000001868E8778 
			public float CalculationParameter3 { get; } // 0x00000001868E8778-0x00000001868E87A4 
	
			// Constructors
			internal Randomize3dConfig(byte[] data, int startIndex); // 0x00000001868E85BC-0x00000001868E86C0
			public Randomize3dConfig(bool followsOriginalSource, Randomize3dCalcType calculationType, float param1 = 0f /* Metadata: 0x0234B7E0 */, float param2 = 0f /* Metadata: 0x0234B7E4 */, float param3 = 0f /* Metadata: 0x0234B7E8 */); // 0x00000001868E84F0-0x00000001868E85BC
			public Randomize3dConfig(int dummy); // 0x00000001868E86C0-0x00000001868E8720
	
			// Methods
			public void ClearCalcParams(float initVal = 0f /* Metadata: 0x0234B7EC */); // 0x00000001868E8114-0x00000001868E814C
			public bool GetParamByType(Randomize3dParamType paramType, ref float paramVal); // 0x00000001868E814C-0x00000001868E8318
			public bool SetParamByType(Randomize3dParamType paramType, float paramVal); // 0x00000001868E8318-0x00000001868E84F0
		}
	
		public struct CuePos3dInfo // TypeDefIndex: 57704
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
			public CuePos3dInfo(byte[] data, int startIndex); // 0x00000001868E7B78-0x00000001868E7CD0
		}
	
		public struct GameVariableInfo // TypeDefIndex: 57705
		{
			// Fields
			public readonly string name; // 0x00
			public uint id; // 0x08
			public float gameValue; // 0x0C
	
			// Constructors
			public GameVariableInfo(byte[] data, int startIndex); // 0x00000001868E7EAC-0x00000001868E7F68
			public GameVariableInfo(string name, uint id, float gameValue); // 0x00000001868E7F68-0x00000001868E7F8C
		}
	
		public enum CueType // TypeDefIndex: 57706
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
	
		public struct CueInfo // TypeDefIndex: 57707
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
			public CueInfo(byte[] data, int startIndex); // 0x00000001868E7820-0x00000001868E7AF8
		}
	
		public struct WaveformInfo // TypeDefIndex: 57708
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
			public WaveformInfo(byte[] data, int startIndex); // 0x00000001868EA220-0x00000001868EA3DC
		}
	
		public struct AisacInfo // TypeDefIndex: 57709
		{
			// Fields
			public readonly string name; // 0x00
			public bool defaultControlFlag; // 0x08
			public float defaultControlValue; // 0x0C
			public uint controlId; // 0x10
			public readonly string controlName; // 0x18
	
			// Constructors
			public AisacInfo(byte[] data, int startIndex); // 0x00000001868D2638-0x00000001868D272C
		}
	
		public struct PerformanceInfo // TypeDefIndex: 57710
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
	
		public struct ResourceUsage // TypeDefIndex: 57711
		{
			// Fields
			public uint useCount; // 0x00
			public uint limit; // 0x04
		}
	
		public struct NativeVector // TypeDefIndex: 57712
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float z; // 0x08
	
			// Constructors
			public NativeVector(float x, float y, float z); // 0x0000000184D88F30-0x0000000184D88F40
			public NativeVector(Vector3 vector); // 0x0000000184D88F40-0x0000000184D88F60
		}
	
		public struct CueLinkInfo // TypeDefIndex: 57713
		{
			// Fields
			public IntPtr nativePlayerHn; // 0x00
			public uint basePlaybackId; // 0x08
			public uint targetPlaybackId; // 0x0C
			public int cueLinkType; // 0x10
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void CueLinkCbFunc(ref CueLinkInfo info); // TypeDefIndex: 57714; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		static CriAtomEx(); // 0x000000018488E700-0x000000018488E970
	
		// Methods
		public static void SetSpeakerAngle(SpeakerAngles6ch speakerAngle); // 0x00000001868E0694-0x00000001868E06E4
		public static void SetSpeakerAngle(SpeakerAngles8ch speakerAngle); // 0x00000001868E06E4-0x00000001868E0734
		public static void SetVirtualSpeakerAngle(SpeakerAngles6ch speakerAngle); // 0x00000001868E0734-0x00000001868E0784
		public static void SetVirtualSpeakerAngle(SpeakerAngles8ch speakerAngle); // 0x00000001868E0784-0x00000001868E07D4
		public static void ControlVirtualSpeakerSetting(bool sw); // 0x00000001868DFD7C-0x00000001868DFDC8
		public static void RegisterAcf(CriFsBinder binder, string acfPath); // 0x00000001868E0334-0x00000001868E0398
		public static void RegisterAcf(IntPtr acfData, int dataSize); // 0x00000001868E0398-0x00000001868E03F0
		[Obsolete("Use RegisterAcf(IntPtr) instead")]
		public static void RegisterAcf(byte[] acfData); // 0x00000001868E02D8-0x00000001868E0334
		public static void UnregisterAcf(); // 0x00000001868E0814-0x00000001868E0854
		public static string GetAppliedDspBusSnapshotName(); // 0x00000001868DFE54-0x00000001868DFEBC
		public static void AttachDspBusSetting(string settingName); // 0x00000001868DFD2C-0x00000001868DFD7C
		public static void DetachDspBusSetting(); // 0x00000001868DFDC8-0x00000001868DFE08
		public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms); // 0x00000001868DFCD4-0x00000001868DFD2C
		public static int GetNumGameVariables(); // 0x00000001868E01CC-0x00000001868E020C
		public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info); // 0x00000001868DFF28-0x00000001868E00F8
		public static float GetGameVariable(uint game_variable_id); // 0x00000001868E0144-0x00000001868E018C
		public static float GetGameVariable(string game_variable_name); // 0x00000001868E00F8-0x00000001868E0144
		public static void SetGameVariable(uint game_variable_id, float game_variable_value); // 0x00000001868E048C-0x00000001868E04E4
		public static void SetGameVariable(string game_variable_name, float game_variable_value); // 0x00000001868E0430-0x00000001868E048C
		public static void SetRandomSeed(uint seed); // 0x0000000183A067D0-0x0000000183A06820
		public static void ResetPerformanceMonitor(); // 0x00000001868E03F0-0x00000001868E0430
		public static void GetPerformanceInfo(out PerformanceInfo info); // 0x00000001868E020C-0x00000001868E0258
		public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index); // 0x00000001868E04E4-0x00000001868E0540
		public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name); // 0x00000001868E0540-0x00000001868E059C
		public static void Lock(); // 0x00000001868E0298-0x00000001868E02D8
		public static void Unlock(); // 0x00000001868E07D4-0x00000001868E0814
		public static void SetOutputAudioDevice_PC(string deviceId); // 0x00000001868E059C-0x00000001868E0644
		public static bool LoadAudioDeviceList_PC(); // 0x00000001868E0258-0x00000001868E0298
		public static int GetNumAudioDevices_PC(); // 0x00000001868E018C-0x00000001868E01CC
		public static string GetAudioDeviceName_PC(int index); // 0x00000001868DFEBC-0x00000001868DFF28
		public static void SetOutputAudioDevice_PC(int index); // 0x00000001868E0644-0x00000001868E0694
		public static void SetOutputVolume_VITA(float volume); // 0x00000001841E1670-0x00000001841E1680
		public static bool IsBgmPortAcquired_VITA(); // 0x0000000182FFF600-0x0000000182FFF610
		public static bool IsSoundStopped_IOS(); // 0x00000001812081B0-0x0000000181208610
		public static void EnableAudioSessionRestoration_IOS(bool flag); // 0x00000001841E1670-0x00000001841E1680
		public static void EnableBusSendOffsetWhenLevelNotExist(bool enable); // 0x00000001868DFE08-0x00000001868DFE54
		private static extern bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize); // 0x00000001868E0F34-0x00000001868E0FF8
		private static extern void criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize); // 0x00000001868E0DE8-0x00000001868E0E88
		private static extern void criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize); // 0x00000001868E0E88-0x00000001868E0F34
		private static extern void criAtomEx_UnregisterAcf(); // 0x00000001868E1304-0x00000001868E136C
		private static extern void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize); // 0x00000001868E09E0-0x00000001868E0A88
		private static extern void criAtomEx_DetachDspBusSetting(); // 0x00000001868E0B00-0x00000001868E0B68
		private static extern void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms); // 0x00000001868E098C-0x00000001868E09E0
		private static extern IntPtr criAtomEx_GetAppliedDspBusSnapshotName(); // 0x00000001868E0BE0-0x00000001868E0C48
		private static extern int criAtomEx_GetNumGameVariables(); // 0x00000001868E0D54-0x00000001868E0D80
		private static extern bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info); // 0x00000001868E0CC8-0x00000001868E0D54
		private static extern float criAtomEx_GetGameVariableById(uint game_variable_id); // 0x00000001868E0C48-0x00000001868E0C74
		private static extern float criAtomEx_GetGameVariableByName(string game_variable_name); // 0x00000001868E0C74-0x00000001868E0CC8
		private static extern void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value); // 0x00000001868E0FF8-0x00000001868E1034
		private static extern void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value); // 0x00000001868E1034-0x00000001868E108C
		private static extern void criAtomEx_SetRandomSeed(uint seed); // 0x0000000183827880-0x0000000183827900
		private static extern void criAtomEx_Lock(); // 0x00000001868E0D80-0x00000001868E0DE8
		private static extern void criAtomEx_Unlock(); // 0x00000001868E129C-0x00000001868E1304
		private static extern void criAtom_ResetPerformanceMonitor(); // 0x00000001868E15AC-0x00000001868E1614
		private static extern void criAtom_GetPerformanceInfo(out PerformanceInfo info); // 0x00000001868E1534-0x00000001868E15AC
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index); // 0x00000001868E085C-0x00000001868E08E0
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name); // 0x00000001868E08E0-0x00000001868E098C
		private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array); // 0x00000001868E108C-0x00000001868E1110
		private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array); // 0x00000001868E1110-0x00000001868E1194
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array); // 0x00000001868E1194-0x00000001868E1218
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array); // 0x00000001868E1218-0x00000001868E129C
		private static extern void criAtomEx_ControlVirtualSpeakerSetting(bool sw); // 0x00000001868E0A88-0x00000001868E0B00
		private static extern void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(bool enable); // 0x00000001868E0B68-0x00000001868E0BE0
		private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType soundRendererType, string deviceId); // 0x00000001868E1698-0x00000001868E1724
		private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType type, IntPtr deviceId); // 0x00000001868E1614-0x00000001868E1698
		private static extern bool criAtomUnity_LoadAudioDeviceList_PC(); // 0x00000001868E14C4-0x00000001868E1534
		private static extern int criAtomUnity_GetNumAudioDevices_PC(); // 0x00000001868E145C-0x00000001868E14C4
		private static extern IntPtr criAtomUnity_GetAudioDeviceName_PC(int index); // 0x00000001868E13E4-0x00000001868E145C
		private static extern IntPtr criAtomUnity_GetAudioDeviceId_PC(int index); // 0x00000001868E136C-0x00000001868E13E4
	}

	public static class CriAtomExCategory // TypeDefIndex: 57729
	{
		// Nested types
		public enum ReactType // TypeDefIndex: 57716
		{
			Ducker = 0,
			AisacModulationTrigger = 1
		}
	
		public enum ReactDuckerTargetType // TypeDefIndex: 57717
		{
			Volume = 0,
			AisacControlValue = 1
		}
	
		public enum ReactDuckerCurveType // TypeDefIndex: 57718
		{
			Linear = 0,
			Square = 1,
			SquareReverse = 2,
			SCurve = 3,
			FlatAtHalf = 4
		}
	
		public struct ReactFadeParameter // TypeDefIndex: 57719
		{
			// Fields
			public ReactDuckerCurveType curveType; // 0x00
			public float curveStrength; // 0x04
			public ushort fadeTimeMs; // 0x08
		}
	
		public enum ReactHoldType // TypeDefIndex: 57720
		{
			WhilePlaying = 0,
			FixedTime = 1
		}
	
		public struct ReactDuckerParameter // TypeDefIndex: 57724
		{
			// Fields
			public Target target; // 0x00
			public ReactDuckerTargetType targetType; // 0x08
			public ReactFadeParameter entry; // 0x0C
			public ReactFadeParameter exit; // 0x18
			public ReactHoldType holdType; // 0x24
			public ushort holdTimeMs; // 0x28
	
			// Nested types
			public struct Volume // TypeDefIndex: 57721
			{
				// Fields
				public float level; // 0x00
			}
	
			public struct AisacControl // TypeDefIndex: 57722
			{
				// Fields
				public uint id; // 0x00
				public float value; // 0x04
			}
	
			public struct Target // TypeDefIndex: 57723
			{
				// Fields
				public CriWare.CriAtomExCategory.ReactDuckerParameter.Volume volume; // 0x00
				public AisacControl aisacControl; // 0x00
			}
		}
	
		public struct ReactAisacModulationParameter // TypeDefIndex: 57725
		{
			// Fields
			private int _enableDecrementAisacModulationKey; // 0x00
			public uint decrementAisacModulationKey; // 0x04
			private int _enableIncrementAisacModulationKey; // 0x08
			public uint incrementAisacModulationKey; // 0x0C
	
			// Properties
			public bool enableDecrementAisacModulationKey { get; } // 0x00000001868E87A4-0x00000001868E87AC 
			public bool enableIncrementAisacModulationKey { get; } // 0x00000001868E87AC-0x00000001868E87B4 
		}
	
		public struct ReactParameter // TypeDefIndex: 57727
		{
			// Fields
			public Parameter parameter; // 0x00
			public ReactType type; // 0x2C
			public bool enablePausingCue; // 0x30
	
			// Nested types
			public struct Parameter // TypeDefIndex: 57726
			{
				// Fields
				public ReactDuckerParameter ducker; // 0x00
				public ReactAisacModulationParameter aisacModulation; // 0x00
			}
		}
	
		public enum ReactStatus // TypeDefIndex: 57728
		{
			Stop = 0,
			FadeOut = 1,
			Hold = 2,
			FadeIn = 3,
			Error = 4
		}
	
		// Methods
		public static void SetVolume(string name, float volume); // 0x00000001868DC850-0x00000001868DC858
		public static void SetVolume(int id, float volume); // 0x00000001868DC848-0x00000001868DC850
		public static float GetVolume(string name); // 0x00000001868DC7C4-0x00000001868DC7CC
		public static float GetVolume(int id); // 0x00000001868DC7CC-0x00000001868DC7D4
		public static void Mute(string name, bool mute); // 0x00000001868DC804-0x00000001868DC80C
		public static void Mute(int id, bool mute); // 0x00000001868DC80C-0x00000001868DC814
		public static bool IsMuted(string name); // 0x00000001868DC7DC-0x00000001868DC7E4
		public static bool IsMuted(int id); // 0x00000001868DC7D4-0x00000001868DC7DC
		public static void Solo(string name, bool solo, float muteVolume); // 0x00000001868DC860-0x00000001868DC868
		public static void Solo(int id, bool solo, float muteVolume); // 0x00000001868DC858-0x00000001868DC860
		public static bool IsSoloed(string name); // 0x00000001868DC7FC-0x00000001868DC804
		public static bool IsSoloed(int id); // 0x00000001868DC7F4-0x00000001868DC7FC
		public static void Pause(string name, bool pause); // 0x00000001868DC814-0x00000001868DC81C
		public static void Pause(int id, bool pause); // 0x00000001868DC81C-0x00000001868DC824
		public static bool IsPaused(string name); // 0x00000001868DC7E4-0x00000001868DC7EC
		public static bool IsPaused(int id); // 0x00000001868DC7EC-0x00000001868DC7F4
		public static void SetAisacControl(string name, string controlName, float value); // 0x00000001868DC82C-0x00000001868DC834
		[Obsolete("Use CriAtomExCategory.SetAisacControl")]
		public static void SetAisac(string name, string controlName, float value); // 0x00000001868DC82C-0x00000001868DC834
		public static void SetAisacControl(int id, int controlId, float value); // 0x00000001868DC824-0x00000001868DC82C
		[Obsolete("Use CriAtomExCategory.SetAisacControl")]
		public static void SetAisac(int id, int controlId, float value); // 0x00000001868DC824-0x00000001868DC82C
		public static void SetReactParameter(string name, ReactParameter parameter); // 0x00000001868DC834-0x00000001868DC848
		public static bool GetReactParameter(string name, out ReactParameter parameter); // 0x00000001868DC7B4-0x00000001868DC7BC
		public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo); // 0x00000001868DC3C8-0x00000001868DC5B4
		public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo); // 0x00000001868DC5B4-0x00000001868DC7AC
		public static bool GetCurrentAisacControlValue(string categoryName, string aisacControlName, out float controlValue); // 0x00000001868DC7AC-0x00000001868DC7B4
		public static ReactStatus GetReactStatus(string reactName); // 0x00000001868DC7BC-0x00000001868DC7C4
		private static extern void criAtomExCategory_SetVolumeByName(string name, float volume); // 0x00000001868DD2D0-0x00000001868DD320
		private static extern float criAtomExCategory_GetVolumeByName(string name); // 0x00000001868DCC1C-0x00000001868DCC70
		private static extern void criAtomExCategory_SetVolumeById(int id, float volume); // 0x00000001868DD294-0x00000001868DD2D0
		private static extern float criAtomExCategory_GetVolumeById(int id); // 0x00000001868DCBF0-0x00000001868DCC1C
		private static extern void criAtomExCategory_MuteById(int id, bool mute); // 0x00000001868DCEB0-0x00000001868DCF34
		private static extern bool criAtomExCategory_IsMutedById(int id); // 0x00000001868DCC70-0x00000001868DCCE8
		private static extern void criAtomExCategory_MuteByName(string name, bool mute); // 0x00000001868DCF34-0x00000001868DCFCC
		private static extern bool criAtomExCategory_IsMutedByName(string name); // 0x00000001868DCCE8-0x00000001868DCD88
		private static extern void criAtomExCategory_SoloById(int id, bool solo, float volume); // 0x00000001868DD320-0x00000001868DD368
		private static extern bool criAtomExCategory_IsSoloedById(int id); // 0x00000001868DCE1C-0x00000001868DCE54
		private static extern void criAtomExCategory_SoloByName(string name, bool solo, float volume); // 0x00000001868DD368-0x00000001868DD3C8
		private static extern bool criAtomExCategory_IsSoloedByName(string name); // 0x00000001868DCE54-0x00000001868DCEB0
		private static extern void criAtomExCategory_PauseById(int id, bool pause); // 0x00000001868DCFCC-0x00000001868DD050
		private static extern bool criAtomExCategory_IsPausedById(int id); // 0x00000001868DCD88-0x00000001868DCDC0
		private static extern void criAtomExCategory_PauseByName(string name, bool pause); // 0x00000001868DD050-0x00000001868DD0A8
		private static extern bool criAtomExCategory_IsPausedByName(string name); // 0x00000001868DCDC0-0x00000001868DCE1C
		private static extern void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value); // 0x00000001868DD0A8-0x00000001868DD0F4
		private static extern void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value); // 0x00000001868DD0F4-0x00000001868DD168
		private static extern void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter); // 0x00000001868DD168-0x00000001868DD294
		private static extern bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter); // 0x00000001868DCA78-0x00000001868DCB98
		private static extern bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo); // 0x00000001868DC868-0x00000001868DC8FC
		private static extern bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo); // 0x00000001868DC8FC-0x00000001868DC9B0
		private static extern bool criAtomExCategory_GetCurrentAisacControlValueByName(string category_name, string aisac_control_name, out float control_value); // 0x00000001868DC9B0-0x00000001868DCA78
		private static extern ReactStatus criAtomExCategory_GetReactStatus(string react_name); // 0x00000001868DCB98-0x00000001868DCBF0
	}

	public static class CriAtomExSequencer // TypeDefIndex: 57733
	{
		// Events
		public static event EventCallback OnCallback {
			add; // 0x00000001868DFCC4-0x00000001868DFCCC
			remove; // 0x00000001868DFCCC-0x00000001868DFCD4
		}
	
		// Nested types
		public struct CriAtomExSequenceEventInfo // TypeDefIndex: 57730
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
		public delegate void EventCbFunc(string eventParamsString); // TypeDefIndex: 57731; 0x0000000182B46B90-0x0000000182B46BA0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void EventCallback(ref CriAtomExSequenceEventInfo criAtomExSequenceInfo); // TypeDefIndex: 57732; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Methods
		[Obsolete("SetEventCallback is deprecated. Use CriAtomExSequencer.OnCallback event", false)]
		public static void SetEventCallback(EventCbFunc func, string separator = "\t" /* Metadata: 0x0234B80A */); // 0x00000001868DFCBC-0x00000001868DFCC4
	}

	public static class CriAtomExBeatSync // TypeDefIndex: 57736
	{
		// Events
		public static event CbFunc OnCallback {
			add; // 0x00000001868DC3B8-0x00000001868DC3C0
			remove; // 0x00000001868DC3C0-0x00000001868DC3C8
		}
	
		// Nested types
		public struct Info // TypeDefIndex: 57734
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
		public delegate void CbFunc(ref Info info); // TypeDefIndex: 57735; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Methods
		[Obsolete("SetCallback is deprecated. Use OnBeatSyncCallback event", false)]
		public static void SetCallback(CbFunc func); // 0x00000001868DC3B0-0x00000001868DC3B8
	}

	public class CriAtomExAsr // TypeDefIndex: 57739
	{
		// Nested types
		private struct BusAnalyzerConfig // TypeDefIndex: 57737
		{
			// Fields
			public int interval; // 0x00
			public int peakHoldTime; // 0x04
		}
	
		public struct BusAnalyzerInfo // TypeDefIndex: 57738
		{
			// Fields
			public int numChannels; // 0x00
			public float[] rmsLevels; // 0x08
			public float[] peakLevels; // 0x10
			public float[] peakHoldLevels; // 0x18
	
			// Constructors
			public BusAnalyzerInfo(byte[] data); // 0x00000001868D272C-0x00000001868D2950
		}
	
		// Constructors
		public CriAtomExAsr(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime); // 0x00000001868DB038-0x00000001868DB058
		public static void AttachBusAnalyzer(int interval, int peakHoldTime); // 0x00000001868DB00C-0x00000001868DB038
		public static void DetachBusAnalyzer(string busName); // 0x00000001868DB058-0x00000001868DB060
		public static void DetachBusAnalyzer(); // 0x00000001868DB060-0x00000001868DB080
		public static void GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info); // 0x00000001868DB23C-0x00000001868DB3F0
		[Obsolete("Use CriAtomExAsr.GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info)")]
		public static void GetBusAnalyzerInfo(int busId, out BusAnalyzerInfo info); // 0x00000001868DB080-0x00000001868DB23C
		public static void SetBusVolume(string busName, float volume); // 0x00000001868DB438-0x00000001868DB440
		[Obsolete("Use CriAtomExAsr.SetBusVolume(string busName, float volume)")]
		public static void SetBusVolume(int busId, float volume); // 0x00000001868DB440-0x00000001868DB448
		public static void SetBusSendLevel(string busName, string sendTo, float level); // 0x00000001868DB430-0x00000001868DB438
		[Obsolete("Use CriAtomExAsr.SetBusSendLevel(string busName, string sendTo, float level)")]
		public static void SetBusSendLevel(int busId, int sendTo, float level); // 0x00000001868DB428-0x00000001868DB430
		public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix); // 0x00000001868DB418-0x00000001868DB428
		[Obsolete("Use CriAtomExAsr.SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix)")]
		public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, float[] matrix); // 0x00000001868DB408-0x00000001868DB418
		public static void SetEffectBypass(string busName, string effectName, bool bypass); // 0x00000001868DB448-0x00000001868DB450
		public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue); // 0x00000001868DB450-0x00000001868DB488
		public static float GetEffectParameter(string busName, string effectName, uint parameterIndex); // 0x00000001868DB3F8-0x00000001868DB400
		public static bool RegisterEffectInterface(IntPtr afx_interface); // 0x00000001868DB400-0x00000001868DB408
		public static void UnregisterEffectInterface(IntPtr afx_interface); // 0x00000001868DB488-0x00000001868DB490
		public static void GetBusVolume(string busName, out float volume); // 0x00000001868DB3F0-0x00000001868DB3F8
		public static int GetPcmOutput(int outputChannels, int outputSamples, float[][] buffer); // 0x00000001811EC580-0x00000001811EC590
		public static int GetNumBufferedPcmOutputSamples(); // 0x00000001811EC580-0x00000001811EC590
		public static void SetPcmBufferSize(int numSamples); // 0x00000001841E1670-0x00000001841E1680
		private static extern void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config); // 0x00000001868DB490-0x00000001868DB528
		private static extern void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config); // 0x00000001868DB528-0x00000001868DB5AC
		private static extern void criAtomExAsr_DetachBusAnalyzerByName(string busName); // 0x00000001868DB5AC-0x00000001868DB638
		private static extern void criAtomExAsr_DetachBusAnalyzer(int busNo); // 0x00000001868DB638-0x00000001868DB6B0
		private static extern void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info); // 0x00000001868DB6B0-0x00000001868DB748
		private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info); // 0x00000001868DB748-0x00000001868DB7CC
		private static extern void criAtomExAsr_SetBusVolumeByName(string busName, float volume); // 0x00000001868DBB48-0x00000001868DBBA0
		private static extern void criAtomExAsr_SetBusVolume(int busNo, float volume); // 0x00000001868DBBA0-0x00000001868DBBDC
		private static extern void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level); // 0x00000001868DBA8C-0x00000001868DBB00
		private static extern void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level); // 0x00000001868DBB00-0x00000001868DBB48
		private static extern void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix); // 0x00000001868DB924-0x00000001868DB9E4
		private static extern void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix); // 0x00000001868DB9E4-0x00000001868DBA8C
		private static extern void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass); // 0x00000001868DBBDC-0x00000001868DBC98
		private static extern void criAtomExAsr_UpdateEffectParameters(string busName, string effectName); // 0x00000001868DBD50-0x00000001868DBDFC
		private static extern void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue); // 0x00000001868DBC98-0x00000001868DBD1C
		private static extern float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex); // 0x00000001868DB864-0x00000001868DB8EC
		private static extern bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface); // 0x00000001868DB8EC-0x00000001868DB924
		private static extern void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface); // 0x00000001868DBD1C-0x00000001868DBD50
		private static extern void criAtomExAsr_GetBusVolumeByName(string busName, out float volume); // 0x00000001868DB7CC-0x00000001868DB864
	}

	public static class CriAtomExLatencyEstimator // TypeDefIndex: 57742
	{
		// Nested types
		public enum Status // TypeDefIndex: 57740
		{
			Stop = 0,
			Processing = 1,
			Done = 2,
			Error = 3
		}
	
		public struct EstimatorInfo // TypeDefIndex: 57741
		{
			// Fields
			public Status status; // 0x00
			public uint estimated_latency; // 0x04
		}
	
		// Methods
		public static void InitializeModule(); // 0x00000001841E1670-0x00000001841E1680
		public static void FinalizeModule(); // 0x00000001841E1670-0x00000001841E1680
		public static EstimatorInfo GetCurrentInfo(); // 0x0000000184D88E20-0x0000000184D88E30
	}

	public class CriAtomEx3dListener : CriDisposable // TypeDefIndex: 57744
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		public struct Config // TypeDefIndex: 57743
		{
			// Fields
			public int reserved; // 0x00
		}
	
		// Constructors
		public CriAtomEx3dListener(); // 0x00000001838280C0-0x0000000183828140
	
		// Methods
		public override void Dispose(); // 0x00000001868D2DA8-0x00000001868D2DB4
		private void Dispose(bool disposing); // 0x00000001868D2DB4-0x00000001868D2E40
		public void Update(); // 0x00000001868D3130-0x00000001868D3144
		public void ResetParameters(); // 0x00000001868D2EC0-0x00000001868D2ED4
		public void SetPosition(float x, float y, float z); // 0x00000001868D30C8-0x00000001868D30FC
		public void SetVelocity(float x, float y, float z); // 0x00000001868D30FC-0x00000001868D3130
		public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz); // 0x00000001868D306C-0x00000001868D30C8
		[Obsolete("Use SetDopplerMultiplier instead")]
		public void SetDistanceFactor(float distanceFactor); // 0x00000001868D2F14-0x00000001868D2FA4
		public void SetDopplerMultiplier(float dopplerMultiplier); // 0x00000001868D2FB8-0x00000001868D3038
		public void SetFocusPoint(float x, float y, float z); // 0x00000001868D3038-0x00000001868D306C
		public void SetDistanceFocusLevel(float distanceFocusLevel); // 0x00000001868D2FA4-0x00000001868D2FB8
		public void SetDirectionFocusLevel(float directionFocusLevel); // 0x00000001868D2F00-0x00000001868D2F14
		public void Set3dRegion(CriAtomEx3dRegion region3d); // 0x00000001868D2ED4-0x00000001868D2F00
		public bool IsDestroyable(); // 0x00000001868D2EB4-0x00000001868D2EC0
		~CriAtomEx3dListener(); // 0x00000001868D2E40-0x00000001868D2EB4
		private static extern IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size); // 0x0000000183827AB0-0x0000000183827B50
		private static extern void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener); // 0x00000001868D3144-0x00000001868D3178
		private static extern void criAtomEx3dListener_Update(IntPtr ex_3d_listener); // 0x00000001868D350C-0x00000001868D3540
		private static extern void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener); // 0x00000001868D31F4-0x00000001868D3228
		private static extern void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position); // 0x00000001868D3484-0x00000001868D34C8
		private static extern void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity); // 0x00000001868D34C8-0x00000001868D350C
		private static extern void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001868D33F0-0x00000001868D3484
		private static extern void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor); // 0x00000001868D32A8-0x00000001868D32EC
		private static extern void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier); // 0x00000001868D3328-0x00000001868D336C
		private static extern void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector focus_point); // 0x00000001868D336C-0x00000001868D33F0
		private static extern void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level); // 0x00000001868D32EC-0x00000001868D3328
		private static extern void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level); // 0x00000001868D326C-0x00000001868D32A8
		private static extern bool criAtomEx3dListener_IsDestroyable(IntPtr ex_3d_listener); // 0x00000001868D3178-0x00000001868D31F4
		private static extern void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region); // 0x00000001868D3228-0x00000001868D326C
	}

	public class CriAtomEx3dSource : CriDisposable // TypeDefIndex: 57746
	{
		// Fields
		private uint currentRandomPositionListMaxLength; // 0x20
		private IntPtr handle; // 0x28
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		public struct Config // TypeDefIndex: 57745
		{
			// Fields
			public bool enableVoicePriorityDecay; // 0x00
			public uint randomPositionListMaxLength; // 0x04
	
			// Constructors
			public Config(bool enableVoicePriorityDecay, uint randomPositionListMaxLength); // 0x0000000184D88DA0-0x0000000184D88DB0
		}
	
		// Constructors
		public CriAtomEx3dSource(bool enableVoicePriorityDecay = false /* Metadata: 0x0234B810 */, uint randomPositionListMaxLength = 0 /* Metadata: 0x0234B811 */); // 0x00000001868D3B94-0x00000001868D3C28
	
		// Methods
		public override void Dispose(); // 0x00000001868D36BC-0x00000001868D36C8
		private void Dispose(bool disposing); // 0x00000001868D36C8-0x00000001868D3754
		public void Update(); // 0x00000001868D3B88-0x00000001868D3B94
		public void ResetParameters(); // 0x00000001868D3814-0x00000001868D3820
		public void SetPosition(float x, float y, float z); // 0x00000001868D392C-0x00000001868D3958
		public void SetVelocity(float x, float y, float z); // 0x00000001868D3B50-0x00000001868D3B7C
		public void SetOrientation(Vector3 front, Vector3 top); // 0x00000001868D38CC-0x00000001868D392C
		[Obsolete("Use CriAtomEx3dSource.SetOrientation instead")]
		public void SetConeOrientation(float x, float y, float z); // 0x00000001868D3844-0x00000001868D3870
		public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume); // 0x00000001868D3870-0x00000001868D3884
		public void SetMinMaxDistance(float minDistance, float maxDistance); // 0x00000001868D38C0-0x00000001868D38CC
		public void SetInteriorPanField(float sourceRadius, float interiorDistance); // 0x00000001868D389C-0x00000001868D38A8
		public void SetDopplerFactor(float dopplerFactor); // 0x00000001868D3890-0x00000001868D389C
		public void SetVolume(float volume); // 0x00000001868D3B7C-0x00000001868D3B88
		public void SetMaxAngleAisacDelta(float maxDelta); // 0x00000001868D38B4-0x00000001868D38C0
		public void SetAttenuationDistanceSetting(bool flag); // 0x00000001868D3838-0x00000001868D3844
		public bool GetAttenuationDistanceSetting(); // 0x00000001868D37C8-0x00000001868D37D4
		public void SetRandomPositionConfig(CriAtomEx.Randomize3dConfig? config); // 0x00000001868D3958-0x00000001868D3A04
		public void SetRandomPositionList(Vector3[] positionList); // 0x00000001868D3A04-0x00000001868D3B44
		public void Set3dRegion(CriAtomEx3dRegion region3d); // 0x00000001868D3820-0x00000001868D3838
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId); // 0x00000001868D38A8-0x00000001868D38B4
		public void SetSourceBasedElevationAngleAisacControlId(ushort aisacControlId); // 0x00000001868D3B44-0x00000001868D3B50
		public void SetDistanceAisacControlId(ushort aisacControlId); // 0x00000001868D3884-0x00000001868D3890
		public bool IsDestroyable(); // 0x00000001868D3808-0x00000001868D3814
		public CriAtomEx.NativeVector GetPosition(); // 0x00000001868D37D4-0x00000001868D3808
		~CriAtomEx3dSource(); // 0x00000001868D3754-0x00000001868D37C8
		private static extern IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size); // 0x00000001868D3C28-0x00000001868D3CEC
		private static extern void criAtomEx3dSource_Destroy(IntPtr ex_3d_source); // 0x00000001868D3CEC-0x00000001868D3D20
		private static extern void criAtomEx3dSource_Update(IntPtr ex_3d_source); // 0x00000001868D46C8-0x00000001868D4740
		private static extern void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source); // 0x00000001868D3EB0-0x00000001868D3F28
		private static extern void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position); // 0x00000001868D4388-0x00000001868D43CC
		private static extern void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity); // 0x00000001868D4648-0x00000001868D468C
		private static extern void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001868D42F4-0x00000001868D4388
		private static extern void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector cone_orient); // 0x00000001868D3FF0-0x00000001868D4074
		private static extern void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume); // 0x00000001868D4074-0x00000001868D40D4
		private static extern void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance); // 0x00000001868D42A8-0x00000001868D42F4
		private static extern void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance); // 0x00000001868D4194-0x00000001868D41E0
		private static extern void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor); // 0x00000001868D4158-0x00000001868D4194
		private static extern void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume); // 0x00000001868D468C-0x00000001868D46C8
		private static extern void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta); // 0x00000001868D4264-0x00000001868D42A8
		private static extern void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag); // 0x00000001868D3F6C-0x00000001868D3FF0
		private static extern bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source); // 0x00000001868D3D20-0x00000001868D3D9C
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref CriAtomEx.Randomize3dConfig config); // 0x00000001868D4450-0x00000001868D4524
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config); // 0x00000001868D43CC-0x00000001868D4450
		private static extern void criAtomEx3dSource_SetRandomPositionList(IntPtr ex_3d_source, CriAtomEx.NativeVector[] position_list, uint length); // 0x00000001868D4524-0x00000001868D45C4
		private static extern void criAtomEx3dSource_SetDistanceAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x00000001868D40D4-0x00000001868D4158
		private static extern bool criAtomEx3dSource_IsDestroyable(IntPtr ex_3d_source); // 0x00000001868D3E34-0x00000001868D3EB0
		private static extern CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(IntPtr ex_3d_source); // 0x00000001868D3D9C-0x00000001868D3E34
		private static extern void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region); // 0x00000001868D3F28-0x00000001868D3F6C
		private static extern void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x00000001868D41E0-0x00000001868D4264
		private static extern void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x00000001868D45C4-0x00000001868D4648
	}

	public class CriAtomEx3dTransceiver : CriDisposable // TypeDefIndex: 57749
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		public struct Config // TypeDefIndex: 57747
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private static class UnsafeNativeMethods // TypeDefIndex: 57748
		{
			// Methods
			internal static extern IntPtr criAtomEx3dTransceiver_Create(ref Config config, IntPtr work, int work_size); // 0x00000001868E99C0-0x00000001868E9A54
			internal static extern void criAtomEx3dTransceiver_Destroy(IntPtr ex_3d_transceiver); // 0x00000001868E9A54-0x00000001868E9A88
			internal static extern void criAtomEx3dTransceiver_Update(IntPtr ex_3d_transceiver); // 0x00000001868EA1EC-0x00000001868EA220
			internal static extern void criAtomEx3dTransceiver_SetInputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x00000001868E9CC8-0x00000001868E9D4C
			internal static extern void criAtomEx3dTransceiver_SetOutputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x00000001868EA01C-0x00000001868EA0A0
			internal static extern void criAtomEx3dTransceiver_SetInputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001868E9C34-0x00000001868E9CC8
			internal static extern void criAtomEx3dTransceiver_SetOutputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x00000001868E9F88-0x00000001868EA01C
			internal static extern void criAtomEx3dTransceiver_SetOutputConeParameter(IntPtr ex_3d_transceiver, float inside_angle, float outside_angle, float outside_volume); // 0x00000001868E9E90-0x00000001868E9EF0
			internal static extern void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(IntPtr ex_3d_transceiver, float min_attenuation_distance, float max_attenuation_distance); // 0x00000001868E9F3C-0x00000001868E9F88
			internal static extern void criAtomEx3dTransceiver_SetOutputInteriorPanField(IntPtr ex_3d_transceiver, float transceiver_radius, float interior_distance); // 0x00000001868E9EF0-0x00000001868E9F3C
			internal static extern void criAtomEx3dTransceiver_SetInputCrossFadeField(IntPtr ex_3d_transceiver, float direct_audio_radius, float crossfade_distance); // 0x00000001868E9BE8-0x00000001868E9C34
			internal static extern void criAtomEx3dTransceiver_SetOutputVolume(IntPtr ex_3d_transceiver, float volume); // 0x00000001868EA0A0-0x00000001868EA0E4
			internal static extern void criAtomEx3dTransceiver_AttachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x00000001868E9968-0x00000001868E99C0
			internal static extern void criAtomEx3dTransceiver_DetachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x00000001868E9A88-0x00000001868E9AE0
			internal static extern void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(IntPtr ex_3d_transceiver, float max_delta); // 0x00000001868E9E54-0x00000001868E9E90
			internal static extern void criAtomEx3dTransceiver_SetDistanceAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001868E9B64-0x00000001868E9BE8
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001868E9D4C-0x00000001868E9DD0
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001868E9DD0-0x00000001868E9E54
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001868EA0E4-0x00000001868EA168
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x00000001868EA168-0x00000001868EA1EC
			internal static extern void criAtomEx3dTransceiver_Set3dRegionHn(IntPtr ex_3d_transceiver, IntPtr ex_3d_region); // 0x00000001868E9AE0-0x00000001868E9B64
		}
	
		// Constructors
		public CriAtomEx3dTransceiver(); // 0x00000001868D4A74-0x00000001868D4AE4
	
		// Methods
		public override void Dispose(); // 0x00000001868D47E4-0x00000001868D47F0
		private void Dispose(bool disposing); // 0x00000001868D4758-0x00000001868D47E4
		public void Update(); // 0x00000001868D4A68-0x00000001868D4A74
		public void SetInputPosition(Vector3 position); // 0x00000001868D4908-0x00000001868D4944
		public void SetOutputPosition(Vector3 position); // 0x00000001868D4A08-0x00000001868D4A44
		public void SetInputOrientation(Vector3 front, Vector3 top); // 0x00000001868D4894-0x00000001868D4908
		public void SetOutputOrientation(Vector3 front, Vector3 top); // 0x00000001868D4994-0x00000001868D4A08
		public void SetOutputConeParameter(float insideAngle, float outsideAngle, float outsideVolume); // 0x00000001868D4968-0x00000001868D497C
		public void SetOutputMinMaxDistance(float minDistance, float maxDistance); // 0x00000001868D4988-0x00000001868D4994
		public void SetOutputInteriorPanField(float radius, float interiorDistance); // 0x00000001868D497C-0x00000001868D4988
		public void SetInputCrossFadeField(float directAudioRadius, float crossfadeDistance); // 0x00000001868D4888-0x00000001868D4894
		public void SetOutputVolume(float volume); // 0x00000001868D4A44-0x00000001868D4A50
		public void AttachAisac(string globalAisacName); // 0x00000001868D4740-0x00000001868D474C
		public void DetachAisac(string globalAisacName); // 0x00000001868D474C-0x00000001868D4758
		public void SetMaxAngleAisacDelta(float maxDelta); // 0x00000001868D495C-0x00000001868D4968
		public void SetDistanceAisacControlId(ushort aisacControlId); // 0x00000001868D487C-0x00000001868D4888
		public void SetListenerBasedAzimuthAngleAisacControlId(ushort aisacControlId); // 0x00000001868D4944-0x00000001868D4950
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId); // 0x00000001868D4950-0x00000001868D495C
		public void SetTransceiverOutputBasedAzimuthAngleAisacControlId(ushort aisacControlId); // 0x00000001868D4A50-0x00000001868D4A5C
		public void SetTransceiverOutputBasedElevationAngleAisacControlId(ushort aisacControlId); // 0x00000001868D4A5C-0x00000001868D4A68
		public void Set3dRegion(CriAtomEx3dRegion region3d); // 0x00000001868D4864-0x00000001868D487C
		~CriAtomEx3dTransceiver(); // 0x00000001868D47F0-0x00000001868D4864
	}

	public class CriAtomEx3dRegion : CriDisposable // TypeDefIndex: 57752
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		public struct Config // TypeDefIndex: 57750
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private static class UnsafeNativeMethods // TypeDefIndex: 57751
		{
			// Methods
			internal static extern IntPtr criAtomEx3dRegion_Create(ref Config config, IntPtr work, int work_size); // 0x00000001868E98A0-0x00000001868E9934
			internal static extern void criAtomEx3dRegion_Destroy(IntPtr ex_3d_region); // 0x00000001868E9934-0x00000001868E9968
		}
	
		// Constructors
		public CriAtomEx3dRegion(); // 0x00000001868D364C-0x00000001868D36BC
	
		// Methods
		public override void Dispose(); // 0x00000001868D3540-0x00000001868D354C
		private void Dispose(bool disposing); // 0x00000001868D354C-0x00000001868D35D8
		~CriAtomEx3dRegion(); // 0x00000001868D35D8-0x00000001868D364C
	}

	public class CriAtomExAcb : CriDisposable // TypeDefIndex: 57753
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle dataHandle; // 0x28
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public bool isAvailable { get; } // 0x00000001868D77F0-0x00000001868D77FC 
	
		// Constructors
		internal CriAtomExAcb(IntPtr handle, GCHandle? dataHandle); // 0x00000001868D6884-0x00000001868D6924
	
		// Methods
		public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath); // 0x00000001868D67A0-0x00000001868D686C
		public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath); // 0x00000001868D6684-0x00000001868D67A0
		public override void Dispose(); // 0x00000001868D5458-0x00000001868D54A8
		private void Dispose(bool disposing); // 0x00000001868D54A8-0x00000001868D5524
		public bool Exists(string cueName); // 0x00000001868D5524-0x00000001868D5530
		public bool Exists(int cueId); // 0x00000001868D5530-0x00000001868D553C
		public bool GetCueInfo(string cueName, out CriAtomEx.CueInfo info); // 0x00000001868D5ADC-0x00000001868D5D10
		public bool GetCueInfo(int cueId, out CriAtomEx.CueInfo info); // 0x00000001868D58A8-0x00000001868D5ADC
		public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info); // 0x00000001868D55C8-0x00000001868D57FC
		public CriAtomEx.CueInfo[] GetCueInfoList(); // 0x00000001868D57FC-0x00000001868D58A8
		public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info); // 0x00000001868D6284-0x00000001868D6478
		public bool GetWaveFormInfo(int cueId, out CriAtomEx.WaveformInfo info); // 0x00000001868D6478-0x00000001868D666C
		public int GetNumCuePlaying(string name); // 0x00000001868D5D1C-0x00000001868D5D28
		public int GetNumCuePlaying(int id); // 0x00000001868D5D10-0x00000001868D5D1C
		public int GetBlockIndex(string cueName, string blockName); // 0x00000001868D55BC-0x00000001868D55C8
		public int GetBlockIndex(int cueId, string blockName); // 0x00000001868D55B0-0x00000001868D55BC
		public int GetNumUsableAisacControls(string cueName); // 0x00000001868D5D28-0x00000001868D5D34
		public int GetNumUsableAisacControls(int cueId); // 0x00000001868D5D34-0x00000001868D5D40
		public bool GetUsableAisacControl(string cueName, int index, out CriAtomEx.AisacControlInfo info); // 0x00000001868D60AC-0x00000001868D6284
		public bool GetUsableAisacControl(int cueId, int index, out CriAtomEx.AisacControlInfo info); // 0x00000001868D5EC4-0x00000001868D60AC
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(string cueName); // 0x00000001868D5D40-0x00000001868D5E04
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(int cueId); // 0x00000001868D5E04-0x00000001868D5EC4
		public void ResetCueTypeState(string cueName); // 0x00000001868D6878-0x00000001868D6884
		public void ResetCueTypeState(int cueId); // 0x00000001868D686C-0x00000001868D6878
		public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name); // 0x00000001868D53A0-0x00000001868D53D8
		public void DetachAwbFile(string awb_name); // 0x00000001868D5444-0x00000001868D5458
		public bool IsReadyToRelease(); // 0x00000001868D666C-0x00000001868D6684
		public float GetLoadProgress(); // 0x0000000184D88DD0-0x0000000184D88DE0
		public void Decrypt(ulong key, ulong nonce); // 0x00000001868D53D8-0x00000001868D5444
		~CriAtomExAcb(); // 0x00000001868D553C-0x00000001868D55B0
		private static extern IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x00000001868D75EC-0x00000001868D76E4
		private static extern IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x00000001868D7508-0x00000001868D75EC
		private static extern void criAtomExAcb_Release(IntPtr acb_hn); // 0x00000001868D76E4-0x00000001868D7718
		private static extern int criAtomExAcb_GetNumCues(IntPtr acb_hn); // 0x00000001868D7070-0x00000001868D70A4
		private static extern bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id); // 0x00000001868D6AA0-0x00000001868D6B28
		private static extern bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name); // 0x00000001868D6B28-0x00000001868D6BD8
		private static extern int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id); // 0x00000001868D70A4-0x00000001868D7128
		private static extern int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name); // 0x00000001868D7128-0x00000001868D71D4
		private static extern bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info); // 0x00000001868D71D4-0x00000001868D727C
		private static extern bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info); // 0x00000001868D727C-0x00000001868D7340
		private static extern bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info); // 0x00000001868D7340-0x00000001868D73D8
		private static extern bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info); // 0x00000001868D73D8-0x00000001868D748C
		private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info); // 0x00000001868D6E8C-0x00000001868D6F40
		private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info); // 0x00000001868D6D5C-0x00000001868D6DF4
		private static extern bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info); // 0x00000001868D6DF4-0x00000001868D6E8C
		private static extern int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name); // 0x00000001868D6FC4-0x00000001868D7070
		private static extern int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id); // 0x00000001868D6F40-0x00000001868D6FC4
		private static extern int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name); // 0x00000001868D6BD8-0x00000001868D6C90
		private static extern int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name); // 0x00000001868D6C90-0x00000001868D6D5C
		private static extern void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name); // 0x00000001868D7758-0x00000001868D77F0
		private static extern void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id); // 0x00000001868D7718-0x00000001868D7758
		private static extern void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size); // 0x00000001868D6924-0x00000001868D6A08
		private static extern void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name); // 0x00000001868D6A08-0x00000001868D6AA0
		private static extern bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn); // 0x00000001868D748C-0x00000001868D7508
	}

	public class CriAtomExAcbLoader : CriDisposable // TypeDefIndex: 57756
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle? gch; // 0x28
	
		// Nested types
		public enum Status // TypeDefIndex: 57754
		{
			Stop = 0,
			Loading = 1,
			Complete = 2,
			Error = 3
		}
	
		private struct LoaderConfig // TypeDefIndex: 57755
		{
			// Fields
			public bool shouldLoadAwbOnMemory; // 0x00
		}
	
		// Constructors
		private CriAtomExAcbLoader(IntPtr handle, GCHandle? dataHandle); // 0x00000001868D4F3C-0x00000001868D5000
	
		// Methods
		public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x0234B812 */); // 0x00000001868D4DB4-0x00000001868D4E9C
		public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x0234B813 */); // 0x00000001868D4C78-0x00000001868D4DB4
		public Status GetStatus(); // 0x00000001868D4C6C-0x00000001868D4C78
		public CriAtomExAcb MoveAcb(); // 0x00000001868D4E9C-0x00000001868D4F3C
		public override void Dispose(); // 0x00000001868D4AE4-0x00000001868D4B34
		private void Dispose(bool disposing); // 0x00000001868D4B34-0x00000001868D4BF8
		~CriAtomExAcbLoader(); // 0x00000001868D4BF8-0x00000001868D4C6C
		private static extern IntPtr criAtomExAcbLoader_Create(in LoaderConfig config); // 0x00000001868D5000-0x00000001868D5080
		private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader); // 0x00000001868D5080-0x00000001868D50B4
		private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path); // 0x00000001868D5204-0x00000001868D52F0
		private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path); // 0x00000001868D512C-0x00000001868D5204
		private static extern Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader); // 0x00000001868D50B4-0x00000001868D512C
		private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader); // 0x00000001868D5368-0x00000001868D53A0
		private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader); // 0x00000001868D52F0-0x00000001868D5368
	}

	public class CriAtomExAcf // TypeDefIndex: 57771
	{
		// Nested types
		public struct AcfDspSettingInfo // TypeDefIndex: 57757
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
			public AcfDspSettingInfo(byte[] data, int startIndex); // 0x00000001868D1E40-0x00000001868D2074
		}
	
		public struct AcfDspSettingSnapshotInfo // TypeDefIndex: 57758
		{
			// Fields
			public string name; // 0x00
			public byte numBuses; // 0x08
			public byte numExtendBuses; // 0x09
			public byte[] reserved; // 0x10
			public ushort[] busIndexes; // 0x18
			public ushort[] extendBusIndexes; // 0x20
	
			// Constructors
			public AcfDspSettingSnapshotInfo(byte[] data, int startIndex); // 0x00000001868D2074-0x00000001868D2290
		}
	
		public struct AcfDspBusInfo // TypeDefIndex: 57759
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
			public AcfDspBusInfo(byte[] data, int startIndex); // 0x00000001868D1AE4-0x00000001868D1D14
		}
	
		public enum AcfDspBusLinkType : uint // TypeDefIndex: 57760
		{
			preVolume = 0,
			postVolume = 1,
			postPan = 2
		}
	
		public struct AcfDspBusLinkInfo // TypeDefIndex: 57761
		{
			// Fields
			public AcfDspBusLinkType type; // 0x00
			public float sendLevel; // 0x04
			public ushort busNo; // 0x08
			public ushort busId; // 0x0A
	
			// Constructors
			public AcfDspBusLinkInfo(byte[] data, int startIndex); // 0x00000001868D1D14-0x00000001868D1E40
		}
	
		public struct CategoryInfo // TypeDefIndex: 57762
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public string name; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
	
			// Constructors
			public CategoryInfo(byte[] data, int startIndex); // 0x00000001868D2A90-0x00000001868D2B78
		}
	
		public enum AcfAisacType : uint // TypeDefIndex: 57763
		{
			normal = 0,
			autoModulation = 1
		}
	
		public struct GlobalAisacInfo // TypeDefIndex: 57764
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
			public GlobalAisacInfo(byte[] data, int startIndex); // 0x00000001868E7F8C-0x00000001868E8114
		}
	
		public enum AisacGraphType // TypeDefIndex: 57765
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
	
		public struct AisacGraphInfo // TypeDefIndex: 57766
		{
			// Fields
			public AisacGraphType type; // 0x00
	
			// Constructors
			public AisacGraphInfo(byte[] data, int startIndex); // 0x00000001868D2544-0x00000001868D2638
		}
	
		public enum CharacterEncoding : uint // TypeDefIndex: 57767
		{
			utf8 = 0,
			sjis = 1
		}
	
		public struct AcfInfo // TypeDefIndex: 57768
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
			public AcfInfo(byte[] data, int startIndex); // 0x00000001868D2290-0x00000001868D249C
		}
	
		public struct SelectorInfo // TypeDefIndex: 57769
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
	
			// Constructors
			public SelectorInfo(byte[] data, int startIndex); // 0x00000001868E87B4-0x00000001868E8880
		}
	
		public struct SelectorLabelInfo // TypeDefIndex: 57770
		{
			// Fields
			public string selectorName; // 0x00
			public string labelName; // 0x08
	
			// Constructors
			public SelectorLabelInfo(byte[] data, int startIndex); // 0x00000001868E8880-0x00000001868E8938
		}
	
		// Constructors
		public CriAtomExAcf(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static int GetNumAisacControls(); // 0x00000001868D9034-0x00000001868D903C
		public static bool GetAisacControlInfo(ushort index, out CriAtomEx.AisacControlInfo info); // 0x00000001868D79F4-0x00000001868D7BAC
		public static int GetNumDspSettings(); // 0x00000001868D905C-0x00000001868D9064
		public static int GetNumDspSettings(IntPtr acfData, int size); // 0x00000001868D9054-0x00000001868D905C
		public static string GetDspSettingNameByIndex(ushort index); // 0x00000001868D8684-0x00000001868D86DC
		public static string GetDspSettingNameByIndex(IntPtr acfData, int size, ushort index); // 0x00000001868D86DC-0x00000001868D8750
		public static bool GetDspSettingInformation(string name, out AcfDspSettingInfo info); // 0x00000001868D84A0-0x00000001868D8684
		public static bool GetDspSettingSnapshotInformation(ushort index, out AcfDspSettingSnapshotInfo info); // 0x00000001868D8750-0x00000001868D893C
		public static bool GetDspBusInformation(ushort index, out AcfDspBusInfo info); // 0x00000001868D8120-0x00000001868D8320
		public static bool GetDspBusLinkInformation(ushort index, out AcfDspBusLinkInfo info); // 0x00000001868D8320-0x00000001868D84A0
		public static int GetNumCategories(); // 0x00000001868D904C-0x00000001868D9054
		public static int GetNumCategoriesPerPlayback(); // 0x00000001868D9044-0x00000001868D904C
		public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo info); // 0x00000001868D7D80-0x00000001868D7F58
		public static bool GetCategoryInfoByName(string name, out CategoryInfo info); // 0x00000001868D7F58-0x00000001868D8120
		public static bool GetCategoryInfoById(uint id, out CategoryInfo info); // 0x00000001868D7BAC-0x00000001868D7D80
		public static int GetNumGlobalAisacs(); // 0x00000001868D9064-0x00000001868D906C
		public static bool GetGlobalAisacInfoByIndex(ushort index, out GlobalAisacInfo info); // 0x00000001868D8B80-0x00000001868D8D54
		public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info); // 0x00000001868D8D54-0x00000001868D8F1C
		public static bool GetGlobalAisacGraphInfo(GlobalAisacInfo aisacInfo, ushort graphIndex, out AisacGraphInfo graphInfo); // 0x00000001868D893C-0x00000001868D8B80
		public static bool GetGlobalAisacValue(GlobalAisacInfo aisacInfo, float control, AisacGraphType type, out float value); // 0x00000001868D8F1C-0x00000001868D902C
		public static bool GetAcfInfo(out AcfInfo acfInfo); // 0x00000001868D7804-0x00000001868D79F4
		public static int GetNumSelectors(); // 0x00000001868D906C-0x00000001868D9074
		public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info); // 0x00000001868D9074-0x00000001868D922C
		public static bool GetSelectorInfoByName(string name, out SelectorInfo info); // 0x00000001868D922C-0x00000001868D93E4
		public static bool GetSelectorLabelInfo(SelectorInfo selectorInfo, ushort labelIndex, out SelectorLabelInfo info); // 0x00000001868D93E4-0x00000001868D966C
		public static int GetNumBuses(); // 0x00000001868D903C-0x00000001868D9044
		public static int GetMaxBusesOfDspBusSettings(); // 0x00000001868D902C-0x00000001868D9034
		public static string FindBusName(string busName); // 0x00000001868D77FC-0x00000001868D7804
		private static extern int criAtomExAcf_GetNumAisacControls(); // 0x00000001868DA1F4-0x00000001868DA218
		private static extern bool criAtomExAcf_GetAisacControlInfo(ushort index, IntPtr info); // 0x00000001868D9848-0x00000001868D98D4
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x00000001868D97F4-0x00000001868D9848
		private static extern string criAtomExAcf_GetAisacControlNameById(uint id); // 0x00000001868D98D4-0x00000001868D996C
		private static extern int criAtomExAcf_GetNumDspSettings(); // 0x00000001868DA468-0x00000001868DA4D0
		private static extern int criAtomExAcf_GetNumDspSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001868DA3E4-0x00000001868DA468
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndex(ushort index); // 0x00000001868D9E9C-0x00000001868D9F14
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(IntPtr acf_data, int acf_data_size, ushort index); // 0x00000001868D9E08-0x00000001868D9E9C
		private static extern bool criAtomExAcf_GetDspSettingInformation(string name, IntPtr info); // 0x00000001868D9DA4-0x00000001868D9E08
		private static extern bool criAtomExAcf_GetDspSettingSnapshotInformation(ushort index, IntPtr info); // 0x00000001868D9F14-0x00000001868D9FA0
		private static extern bool criAtomExAcf_GetDspBusInformation(ushort index, IntPtr info); // 0x00000001868D9AE4-0x00000001868D9B70
		private static extern int criAtomExAcf_GetDspFxType(ushort index); // 0x00000001868D9D2C-0x00000001868D9DA4
		private static extern string criAtomExAcf_GetDspFxName(ushort index); // 0x00000001868D9BFC-0x00000001868D9C94
		private static extern bool criAtomExAcf_GetDspFxParameters(ushort index, IntPtr parameters, int size); // 0x00000001868D9C94-0x00000001868D9D2C
		private static extern bool criAtomExAcf_GetDspBusLinkInformation(ushort index, IntPtr info); // 0x00000001868D9B70-0x00000001868D9BFC
		private static extern int criAtomExAcf_GetNumCategoriesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001868DA2C8-0x00000001868DA34C
		private static extern int criAtomExAcf_GetNumCategories(); // 0x00000001868DA3B8-0x00000001868DA3E4
		private static extern int criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001868DA34C-0x00000001868DA38C
		private static extern int criAtomExAcf_GetNumCategoriesPerPlayback(); // 0x00000001868DA38C-0x00000001868DA3B8
		private static extern bool criAtomExAcf_GetCategoryInfo(ushort index, IntPtr info); // 0x00000001868D9A58-0x00000001868D9AE4
		private static extern bool criAtomExAcf_GetCategoryInfoByName(string name, IntPtr info); // 0x00000001868D99F4-0x00000001868D9A58
		private static extern bool criAtomExAcf_GetCategoryInfoById(uint id, IntPtr info); // 0x00000001868D996C-0x00000001868D99F4
		private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x00000001868DA4D0-0x00000001868DA4F4
		private static extern bool criAtomExAcf_GetGlobalAisacInfo(ushort index, IntPtr info); // 0x00000001868DA09C-0x00000001868DA128
		private static extern bool criAtomExAcf_GetGlobalAisacInfoByName(string name, IntPtr info); // 0x00000001868DA038-0x00000001868DA09C
		private static extern bool criAtomExAcf_GetGlobalAisacGraphInfo(IntPtr aisac_info, ushort graph_index, IntPtr graph_info); // 0x00000001868D9FA0-0x00000001868DA038
		private static extern bool criAtomExAcf_GetGlobalAisacValue(IntPtr aisac_info, float control, AisacGraphType type, out float value); // 0x00000001868DA128-0x00000001868DA188
		private static extern bool criAtomExAcf_GetAcfInfo(IntPtr acf_info); // 0x00000001868D97BC-0x00000001868D97F4
		private static extern bool criAtomExAcf_GetAcfInfoFromAcfData(IntPtr acf_data, int acf_data_size, IntPtr acf_info); // 0x00000001868D9724-0x00000001868D97BC
		private static extern int criAtomExAcf_GetNumSelectors(); // 0x00000001868DA4F4-0x00000001868DA518
		private static extern bool criAtomExAcf_GetSelectorInfoByIndex(ushort index, IntPtr info); // 0x00000001868DA518-0x00000001868DA5A4
		private static extern bool criAtomExAcf_GetSelectorInfoByName(string name, IntPtr info); // 0x00000001868DA5A4-0x00000001868DA608
		private static extern bool criAtomExAcf_GetSelectorLabelInfo(IntPtr selector_info, ushort label_index, IntPtr info); // 0x00000001868DA608-0x00000001868DA6A0
		private static extern int criAtomExAcf_GetNumBusesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001868DA218-0x00000001868DA29C
		private static extern int criAtomExAcf_GetNumBuses(); // 0x00000001868DA29C-0x00000001868DA2C8
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x00000001868DA188-0x00000001868DA1C8
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettings(); // 0x00000001868DA1C8-0x00000001868DA1F4
		private static extern string criAtomExAcf_FindBusName(string bus_name); // 0x00000001868D966C-0x00000001868D9724
	}

	public class CriAtomExAsrRack : CriDisposable // TypeDefIndex: 57776
	{
		// Fields
		public const int defaultRackId = 0; // Metadata: 0x0234B856
		private int _rackId; // 0x20
		private bool hasExistingRackId; // 0x24
	
		// Properties
		public int rackId { get; } // 0x0000000182B70F90-0x0000000182B70FA0 
		public static Config defaultConfig { get; } // 0x0000000184D88DE0-0x0000000184D88E20 
	
		// Nested types
		public enum SpeakerMapping // TypeDefIndex: 57772
		{
			Auto = 0,
			Monaural = 1,
			Stereo = 2,
			Ch5_1 = 3,
			Ch7_1 = 4,
			Ch5_1_2 = 5,
			Ch7_1_4 = 6
		}
	
		public struct Config // TypeDefIndex: 57773
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
	
		public struct PlatformConfig // TypeDefIndex: 57774
		{
			// Fields
			public byte reserved; // 0x00
		}
	
		public struct PerformanceInfo // TypeDefIndex: 57775
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
		public CriAtomExAsrRack(Config config, PlatformConfig platformConfig); // 0x00000001868DA9D8-0x00000001868DAAE4
		public CriAtomExAsrRack(int existingRackId); // 0x00000001868DAAE4-0x00000001868DABA0
	
		// Methods
		public void AttachDspBusSetting(string settingName); // 0x00000001868DA6AC-0x00000001868DA6CC
		public void DetachDspBusSetting(); // 0x00000001868DA750-0x00000001868DA75C
		public void ApplyDspBusSnapshot(string snapshotName, int timeMs); // 0x00000001868DA6A0-0x00000001868DA6AC
		public static string GetAppliedDspBusSnapshotName(int rackId); // 0x00000001868DA8A4-0x00000001868DA8F8
		public string GetAppliedDspBusSnapshotName(); // 0x00000001868DA84C-0x00000001868DA8A4
		public PerformanceInfo GetPerformanceInfo(); // 0x00000001868DA92C-0x00000001868DA9B4
		public static PerformanceInfo GetPerformanceInfoByRackId(int rackId = 0 /* Metadata: 0x0234B854 */); // 0x00000001868DA8F8-0x00000001868DA92C
		public void ResetPerformanceMonitor(); // 0x00000001868DA9BC-0x00000001868DA9C8
		public static void ResetPerformanceMonitorByRackId(int rackId = 0 /* Metadata: 0x0234B855 */); // 0x00000001868DA9B4-0x00000001868DA9BC
		public static void SetAisacControl(int rackId, string controlName, float value); // 0x00000001868DA9C8-0x00000001868DA9D0
		public static void SetAisacControl(int rackId, int controlId, float value); // 0x00000001868DA9D0-0x00000001868DA9D8
		public override void Dispose(); // 0x00000001868DA75C-0x00000001868DA7D8
		~CriAtomExAsrRack(); // 0x00000001868DA7D8-0x00000001868DA84C
		private static extern int CRIWARE6158351D(in Config config, in PlatformConfig platformConfig); // 0x00000001868DA6CC-0x00000001868DA750
		private static extern void criAtomExAsrRack_Destroy(int rackId); // 0x00000001868DACFC-0x00000001868DAD74
		private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize); // 0x00000001868DAC48-0x00000001868DACFC
		private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId); // 0x00000001868DAD74-0x00000001868DADEC
		private static extern IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(int rackId); // 0x00000001868DADEC-0x00000001868DAE64
		private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs); // 0x00000001868DABA0-0x00000001868DAC48
		private static extern void criAtomExAsrRack_GetPerformanceInfo(int rackId, out PerformanceInfo perfInfo); // 0x00000001868DAE64-0x00000001868DAEE8
		private static extern void criAtomExAsrRack_ResetPerformanceMonitor(int rackId); // 0x00000001868DAEE8-0x00000001868DAF60
		private static extern void criAtomExAsrRack_SetAisacControlById(int rackId, ushort controlId, float value); // 0x00000001868DAF60-0x00000001868DAFAC
		private static extern void criAtomExAsrRack_SetAisacControlByName(int rackId, string controlName, float value); // 0x00000001868DAFAC-0x00000001868DB00C
	}

	public class CriAtomExAuxIn : CriDisposable // TypeDefIndex: 57778
	{
		// Fields
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomExAuxIn."; // Metadata: 0x0234B85E
		private IntPtr handle; // 0x20
		private CriAudioReadStream inputReadStream; // 0x28
	
		// Nested types
		public struct Config // TypeDefIndex: 57777
		{
			// Fields
			public int maxChannels; // 0x00
			public int maxSamplingRate; // 0x04
			public CriAtomEx.SoundRendererType soundRendererType; // 0x08
	
			// Properties
			public static Config Default { get; } // 0x0000000184D88DB0-0x0000000184D88DD0 
		}
	
		// Constructors
		public CriAtomExAuxIn(Config? config = default); // 0x00000001868DBF10-0x00000001868DBFE0
	
		// Methods
		~CriAtomExAuxIn(); // 0x00000001868DA7D8-0x00000001868DA84C
		public override void Dispose(); // 0x00000001868DBDFC-0x00000001868DBE78
		public void Start(); // 0x00000001868DBEF0-0x00000001868DBEFC
		public void Stop(); // 0x00000001868DBEFC-0x00000001868DBF10
		public void SetFormat(int numChannels, int samplingRate); // 0x00000001868DBE90-0x00000001868DBE9C
		public void GetFormat(out int numChannels, out int samplingRate); // 0x00000001868DBE78-0x00000001868DBE84
		public void SetVolume(float volume); // 0x00000001868DBEE4-0x00000001868DBEF0
		public void SetFrequencyRatio(float frequencyRatio); // 0x00000001868DBE9C-0x00000001868DBEA8
		public void SetBusSendLevel(string busName, float level); // 0x00000001868DBE84-0x00000001868DBE90
		public void SetInputReadStream(CriAudioReadStream stream); // 0x00000001868DBEA8-0x00000001868DBEE4
		private static extern IntPtr criAtomAuxIn_Create(in Config config, IntPtr work, int work_size); // 0x00000001868DBFE0-0x00000001868DC074
		private static extern void criAtomAuxIn_Destroy(IntPtr aux_in); // 0x00000001868DC074-0x00000001868DC0A8
		private static extern void criAtomAuxIn_Start(IntPtr aux_in); // 0x00000001868DC304-0x00000001868DC338
		private static extern void criAtomAuxIn_Stop(IntPtr aux_in); // 0x00000001868DC338-0x00000001868DC3B0
		private static extern void criAtomAuxIn_SetVolume(IntPtr aux_in, float volume); // 0x00000001868DC2C8-0x00000001868DC304
		private static extern void criAtomAuxIn_SetFrequencyRatio(IntPtr aux_in, float ratio); // 0x00000001868DC230-0x00000001868DC274
		private static extern void criAtomAuxIn_SetBusSendLevelByName(IntPtr aux_in, string bus_name, float level); // 0x00000001868DC13C-0x00000001868DC19C
		private static extern void criAtomAuxIn_SetFormat(IntPtr aux_in, int num_channels, int sampling_rate); // 0x00000001868DC19C-0x00000001868DC230
		private static extern void criAtomAuxIn_GetFormat(IntPtr aux_in, out int num_channels, out int sampling_rate); // 0x00000001868DC0A8-0x00000001868DC13C
		private static extern void criAtomAuxIn_SetInputReadStream(IntPtr aux_in, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x00000001868DC274-0x00000001868DC2C8
	}

	public class CriAtomExMic : CriDisposable // TypeDefIndex: 57782
	{
		// Fields
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic."; // Metadata: 0x0234B891
		private const string errorInvalidBufferLength = "[CRIWARE] Invalid buffer length for CriAtomMic.ReadData."; // Metadata: 0x0234B8C0
		private const string errorInvalidNumBuffers = "[CRIWARE] Number of buffers are not same with channels of CriAtomMic."; // Metadata: 0x0234B8F9
		private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized."; // Metadata: 0x0234B940
		private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized."; // Metadata: 0x0234B974
		[CompilerGenerated]
		private static bool _isInitialized_k__BackingField; // 0x00
		private IntPtr handle; // 0x20
		private IntPtr[] bufferPointers; // 0x28
		private GCHandle[] gcHandles; // 0x30
		private CriAudioWriteStream outputWriteStream; // 0x38
		private static int _initializationCount; // 0x04
	
		// Properties
		public static bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001868DEB9C-0x00000001868DEBD4 0x00000001868DEBD4-0x00000001868DEC10
	
		// Nested types
		public struct DeviceInfo // TypeDefIndex: 57779
		{
			// Fields
			public string deviceId; // 0x00
			public string deviceName; // 0x08
			public uint deviceFlags; // 0x10
			public int maxChannels; // 0x14
			public int maxSamplingRate; // 0x18
		}
	
		public struct Config // TypeDefIndex: 57780
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
			public static Config Default { get; } // 0x00000001868D2CCC-0x00000001868D2D1C 
		}
	
		public class Effect // TypeDefIndex: 57781
		{
			// Fields
			[CompilerGenerated]
			private IntPtr _handle_k__BackingField; // 0x10
			[CompilerGenerated]
			private IntPtr _afxInstance_k__BackingField; // 0x18
	
			// Properties
			public IntPtr handle { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x0000000184D88BF0-0x0000000184D88C00
			public IntPtr afxInstance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
	
			// Constructors
			public Effect(IntPtr handle, IntPtr afxInstance); // 0x0000000184D88F20-0x0000000184D88F30
		}
	
		// Constructors
		private CriAtomExMic(IntPtr handle); // 0x00000001868DDF40-0x00000001868DE000
	
		// Methods
		public static void InitializeModule(); // 0x00000001868DD9D0-0x00000001868DDA6C
		public static void FinalizeModule(); // 0x00000001868DD688-0x00000001868DD74C
		public static void SetupOutputCategoryForMic_IOS(bool enable); // 0x00000001841E1670-0x00000001841E1680
		public static DeviceInfo[] GetDevices(); // 0x00000001868DD84C-0x00000001868DD91C
		public static int GetNumDevices(); // 0x00000001868DD958-0x00000001868DD960
		public static DeviceInfo? GetDefaultDevice(); // 0x00000001868DD74C-0x00000001868DD84C
		public static bool IsFormatSupported(Config config); // 0x00000001868DDB24-0x00000001868DDB34
		public static CriAtomExMic Create(Config? config = default); // 0x00000001868DD470-0x00000001868DD5BC
		~CriAtomExMic(); // 0x00000001868DA7D8-0x00000001868DA84C
		public override void Dispose(); // 0x00000001868DD638-0x00000001868DD688
		private void Dispose(bool disposing); // 0x00000001868DD5E0-0x00000001868DD638
		public void Start(); // 0x00000001868DDF04-0x00000001868DDF10
		public void Stop(); // 0x00000001868DDF10-0x00000001868DDF1C
		public int GetNumChannels(); // 0x00000001868DD94C-0x00000001868DD958
		public int GetSamplingRate(); // 0x00000001868DD9C4-0x00000001868DD9D0
		public uint GetNumBufferedSamples(); // 0x00000001868DD940-0x00000001868DD94C
		[Obsolete("Use CriAtomExMic.GetNumBufferedSamples")]
		public uint GetNumBufferredSamples(); // 0x00000001868DD940-0x00000001868DD94C
		public bool IsAvailable(); // 0x00000001868DDB04-0x00000001868DDB24
		public uint ReadData(float[] bufferMono); // 0x00000001868DDB98-0x00000001868DDBB8
		public uint ReadData(float[] bufferMono, uint numToRead); // 0x00000001868DDCDC-0x00000001868DDD6C
		public uint ReadData(float[] bufferL, float[] bufferR); // 0x00000001868DDB34-0x00000001868DDB5C
		public uint ReadData(float[] bufferL, float[] bufferR, uint numToRead); // 0x00000001868DDBB8-0x00000001868DDCDC
		public uint ReadData(float[][] buffers); // 0x00000001868DDB5C-0x00000001868DDB98
		public uint ReadData(float[][] buffers, uint numToRead); // 0x00000001868DDD6C-0x00000001868DDE74
		public void SetOutputWriteStream(CriAudioWriteStream stream); // 0x00000001868DDEC4-0x00000001868DDF04
		public CriAudioReadStream GetOutputReadStream(); // 0x00000001868DD960-0x00000001868DD9C4
		public Effect AttachEffect(IntPtr afxInterface, float[] configParameters); // 0x00000001868DD3C8-0x00000001868DD470
		public void DetachEffect(Effect effect); // 0x00000001868DD5BC-0x00000001868DD5E0
		public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue); // 0x00000001868DDE98-0x00000001868DDEC4
		public float GetEffectParameter(Effect effect, int parameterIndex); // 0x00000001868DD91C-0x00000001868DD940
		public void SetEffectBypass(Effect effect, bool bypass); // 0x00000001868DDE74-0x00000001868DDE98
		public void UpdateEffectParameters(Effect effect); // 0x00000001868DDF1C-0x00000001868DDF40
		private uint InternalReadDataFromBufferPointers(uint numToRead); // 0x00000001868DDAF0-0x00000001868DDB04
		private void InternalClearBuffers(); // 0x00000001868DDA6C-0x00000001868DDAF0
		private static extern void criAtomMicUnity_Initialize(); // 0x00000001868DE068-0x00000001868DE0D0
		private static extern void criAtomMicUnity_Finalize(); // 0x00000001868DE000-0x00000001868DE068
		private static extern int criAtomMic_GetNumDevices(); // 0x00000001868DE714-0x00000001868DE740
		private static extern bool criAtomMic_GetDevice(int index, out DeviceInfo info); // 0x00000001868DE49C-0x00000001868DE598
		private static extern bool criAtomMic_GetDefaultDevice(out DeviceInfo info); // 0x00000001868DE3AC-0x00000001868DE49C
		private static extern bool criAtomMic_IsFormatSupported(in Config config); // 0x00000001868DE81C-0x00000001868DE8C8
		private static extern IntPtr criAtomMic_Create(in Config config, IntPtr work, int work_size); // 0x00000001868DE22C-0x00000001868DE2F4
		private static extern void criAtomMic_Destroy(IntPtr mic); // 0x00000001868DE2F4-0x00000001868DE328
		private static extern void criAtomMic_Start(IntPtr mic); // 0x00000001868DEAAC-0x00000001868DEB24
		private static extern void criAtomMic_Stop(IntPtr mic); // 0x00000001868DEB24-0x00000001868DEB58
		private static extern int criAtomMic_GetNumChannels(IntPtr mic); // 0x00000001868DE6E0-0x00000001868DE714
		private static extern int criAtomMic_GetSamplingRate(IntPtr mic); // 0x00000001868DE76C-0x00000001868DE7E4
		private static extern uint criAtomMic_GetNumBufferedSamples(IntPtr mic); // 0x00000001868DE668-0x00000001868DE6E0
		private static extern bool criAtomMic_IsAvailable(IntPtr mic); // 0x00000001868DE7E4-0x00000001868DE81C
		private static extern uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples); // 0x00000001868DE8C8-0x00000001868DE968
		private static extern void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x00000001868DEA58-0x00000001868DEAAC
		private static extern IntPtr criAtomMic_GetOutputReadStream(); // 0x00000001868DE740-0x00000001868DE76C
		private static extern int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters); // 0x00000001868DE180-0x00000001868DE22C
		private static extern IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters, IntPtr work, int work_size); // 0x00000001868DE0D0-0x00000001868DE180
		private static extern void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect); // 0x00000001868DE328-0x00000001868DE3AC
		private static extern IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect); // 0x00000001868DE598-0x00000001868DE61C
		private static extern void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass); // 0x00000001868DE968-0x00000001868DE9FC
		private static extern void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value); // 0x00000001868DE9FC-0x00000001868DEA58
		private static extern float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index); // 0x00000001868DE61C-0x00000001868DE668
		private static extern void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect); // 0x00000001868DEB58-0x00000001868DEB9C
	}

	public class CriAtomExOutputAnalyzer : CriDisposable // TypeDefIndex: 57786
	{
		// Fields
		public const int MaximumSpectrumBands = 512; // Metadata: 0x0234B9A4
		protected IntPtr handle; // 0x20
		protected CriAtomExPlayer player; // 0x28
		protected string busName; // 0x30
		protected int numBands; // 0x38
		protected int numCapturedPcmSamples; // 0x3C
		protected PcmCaptureCallback userPcmCaptureCallback; // 0x40
		protected float[] dataL; // 0x48
		protected float[] dataR; // 0x50
		protected const int pcmCapturerNumMaxData = 512; // Metadata: 0x0234B9A6
		protected static IntPtr InternalCallbackFunctionPointer; // 0x00
		protected static InternalPcmCaptureCallback DelegateObject; // 0x08
		protected static float[] DataL; // 0x10
		protected static float[] DataR; // 0x18
		protected static PcmCaptureCallback UserPcmCaptureCallback; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		public delegate void PcmCaptureCallback(float[] dataL, float[] dataR, int numChannels, int numData); // TypeDefIndex: 57783; 0x00000001815547C0-0x00000001815547E0
	
		public struct Config // TypeDefIndex: 57784
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
		protected delegate void InternalPcmCaptureCallback(IntPtr dataL, IntPtr dataR, int numChannels, int numData); // TypeDefIndex: 57785; 0x00000001815547C0-0x00000001815547E0
	
		// Constructors
		public CriAtomExOutputAnalyzer(Config config); // 0x00000001868DF84C-0x00000001868DF8DC
		protected CriAtomExOutputAnalyzer(); // 0x00000001868DF7EC-0x00000001868DF84C
		static CriAtomExOutputAnalyzer(); // 0x00000001868DF78C-0x00000001868DF7EC
	
		// Methods
		public override void Dispose(); // 0x00000001868DF034-0x00000001868DF040
		protected void Dispose(bool disposing); // 0x00000001868DF040-0x00000001868DF104
		public bool AttachExPlayer(CriAtomExPlayer player); // 0x00000001868DECA4-0x00000001868DED5C
		public void DetachExPlayer(); // 0x00000001868DEF48-0x00000001868DF034
		public bool AttachDspBus(string busName); // 0x00000001868DEC10-0x00000001868DECA4
		public void DetachDspBus(); // 0x00000001868DEECC-0x00000001868DEF48
		public float GetRms(int channel); // 0x00000001868DF4EC-0x00000001868DF594
		public void GetSpectrumLevels(ref float[] levels); // 0x00000001868DF594-0x00000001868DF680
		public void GetPcmData(ref float[] data, int ch); // 0x00000001868DF3F4-0x00000001868DF4EC
		public void SetPcmCaptureCallback(PcmCaptureCallback callback); // 0x00000001842B4AE0-0x00000001842B4AF0
		public void ExecutePcmCaptureCallback(); // 0x00000001868DF128-0x00000001868DF380
		[Obsolete("Use SetPcmCaptureCallback(PcmCaptureCallback) and ExecutePcmCaptureCallback()")]
		public void ExecutePcmCaptureCallback(PcmCaptureCallback callback); // 0x00000001868DF104-0x00000001868DF128
		~CriAtomExOutputAnalyzer(); // 0x00000001868DF380-0x00000001868DF3F4
		protected void InitializeWithConfig(Config config); // 0x00000001868DF680-0x00000001868DF78C
		[AOT.MonoPInvokeCallback(typeof(InternalPcmCaptureCallback))]
		private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData); // 0x00000001868DED5C-0x00000001868DEECC
		protected static extern IntPtr criAtomExOutputAnalyzer_Create(in Config config); // 0x00000001868DF978-0x00000001868DFA30
		protected static extern void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer); // 0x00000001868DFA30-0x00000001868DFA64
		protected static extern void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player); // 0x00000001868DF934-0x00000001868DF978
		protected static extern void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player); // 0x00000001868DFABC-0x00000001868DFB00
		protected static extern void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName); // 0x00000001868DF8DC-0x00000001868DF934
		protected static extern void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName); // 0x00000001868DFA64-0x00000001868DFABC
		protected static extern float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel); // 0x00000001868DFC08-0x00000001868DFC44
		protected static extern IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer); // 0x00000001868DFC44-0x00000001868DFCBC
		protected static extern IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch); // 0x00000001868DFB84-0x00000001868DFC08
		protected static extern void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback); // 0x00000001868DFB00-0x00000001868DFB84
	}

	public struct CriAtomExPlayback // TypeDefIndex: 57789
	{
		// Fields
		[CompilerGenerated]
		private uint _id_k__BackingField; // 0x00
		public const uint invalidId = 4294967295; // Metadata: 0x0234B9A8
	
		// Properties
		public uint id { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public Status status { get; } // 0x00000001868EB85C-0x00000001868EB868 
		public long time { get; } // 0x00000001868EB874-0x00000001868EB880 
		public long timeSyncedWithAudio { get; } // 0x00000001868EB868-0x00000001868EB874 
	
		// Nested types
		public enum Status // TypeDefIndex: 57787
		{
			Prep = 1,
			Playing = 2,
			Removed = 3
		}
	
		public struct TrackInfo // TypeDefIndex: 57788
		{
			// Fields
			public uint id; // 0x00
			public CriAtomEx.CueType sequenceType; // 0x04
			public IntPtr playerHn; // 0x08
			public ushort trackNo; // 0x10
			public ushort reserved; // 0x12
		}
	
		// Constructors
		public CriAtomExPlayback(uint id); // 0x0000000184D86140-0x0000000184D86150
	
		// Methods
		public void Stop(bool ignoresReleaseTime); // 0x00000001868EB920-0x00000001868EB984
		public void Pause(); // 0x00000001868EB8A4-0x00000001868EB8B0
		public void Resume(CriAtomEx.ResumeMode mode); // 0x00000001868EB8B0-0x00000001868EB8BC
		public bool IsPaused(); // 0x00000001868EB88C-0x00000001868EB898
		public bool GetFormatInfo(out CriAtomEx.FormatInfo info); // 0x00000001868EB838-0x00000001868EB844
		public Status GetStatus(); // 0x00000001868EB85C-0x00000001868EB868
		public long GetTime(); // 0x00000001868EB874-0x00000001868EB880
		public long GetTimeSyncedWithAudio(); // 0x00000001868EB868-0x00000001868EB874
		public bool GetNumPlayedSamples(out long numSamples, out int samplingRate); // 0x00000001868EB844-0x00000001868EB850
		public long GetSequencePosition(); // 0x00000001868EB850-0x00000001868EB85C
		public int GetCurrentBlockIndex(); // 0x00000001868EB82C-0x00000001868EB838
		public bool GetTrackInfo(out TrackInfo info); // 0x00000001868EB880-0x00000001868EB88C
		public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info); // 0x00000001868EB820-0x00000001868EB82C
		public void SetNextBlockIndex(int index); // 0x00000001868EB8C8-0x00000001868EB8D4
		public bool SetBeatSyncOffset(short timeMs); // 0x00000001868EB8BC-0x00000001868EB8C8
		public void Stop(); // 0x00000001868EB984-0x00000001868EB9D0
		public void StopWithoutReleaseTime(); // 0x00000001868EB8D4-0x00000001868EB920
		public void Pause(bool sw); // 0x00000001868EB898-0x00000001868EB8A4
		private static extern void criAtomExPlayback_Stop(uint id); // 0x00000001868EC154-0x00000001868EC1CC
		private static extern void criAtomExPlayback_StopWithoutReleaseTime(uint id); // 0x00000001868EC0DC-0x00000001868EC154
		private static extern void criAtomExPlayback_Pause(uint id, bool sw); // 0x00000001868EBED0-0x00000001868EBF54
		private static extern void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode); // 0x00000001868EBF54-0x00000001868EBFD4
		private static extern bool criAtomExPlayback_IsPaused(uint id); // 0x00000001868EBE58-0x00000001868EBED0
		private static extern Status criAtomExPlayback_GetStatus(uint id); // 0x00000001868EBCF0-0x00000001868EBD68
		private static extern bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info); // 0x00000001868EBAD0-0x00000001868EBB58
		private static extern long criAtomExPlayback_GetTime(uint id); // 0x00000001868EBDE0-0x00000001868EBE58
		private static extern long criAtomExPlayback_GetTimeSyncedWithAudio(uint id); // 0x00000001868EBD68-0x00000001868EBDE0
		private static extern bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate); // 0x00000001868EBB58-0x00000001868EBBF0
		private static extern long criAtomExPlayback_GetSequencePosition(uint id); // 0x00000001868EBC78-0x00000001868EBCF0
		private static extern void criAtomExPlayback_SetNextBlockIndex(uint id, int index); // 0x00000001868EC05C-0x00000001868EC0DC
		private static extern int criAtomExPlayback_GetCurrentBlockIndex(uint id); // 0x00000001868EBA58-0x00000001868EBAD0
		private static extern bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info); // 0x00000001868EBBF0-0x00000001868EBC78
		private static extern bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info); // 0x00000001868EB9D0-0x00000001868EBA58
		private static extern bool criAtomExPlayback_SetBeatSyncOffset(uint id, short timeMs); // 0x00000001868EBFD4-0x00000001868EC05C
	}

	public class CriAtomExPlayer : CriDisposable // TypeDefIndex: 57794
	{
		// Fields
		[CompilerGenerated]
		private CriAtomExBeatSync.CbFunc _onBeatSyncCallback; // 0x20
		[CompilerGenerated]
		private CriAtomExSequencer.EventCallback _onSequenceCallback; // 0x28
		private bool hasExistingNativeHandle; // 0x30
		private IntPtr entryPoolHandle; // 0x38
		private int _entryPoolCapacity; // 0x40
		private int max_path; // 0x44
		private IntPtr handle; // 0x48
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D86200-0x0000000184D86210 
		public bool isAvailable { get; } // 0x00000001868EF998-0x00000001868EF9A4 
		public int entryPoolCapacity { get; } // 0x0000000184D865E0-0x0000000184D865F0 
	
		// Events
		private event CriAtomExBeatSync.CbFunc _onBeatSyncCallback {
			add; // 0x00000001868ED65C-0x00000001868ED6F0
			remove; // 0x00000001868EFACC-0x00000001868EFB60
		}
		public event CriAtomExBeatSync.CbFunc OnBeatSyncCallback {
			add; // 0x00000001868ED524-0x00000001868ED5C0
			remove; // 0x00000001868EF9A4-0x00000001868EFA38
		}
		private event CriAtomExSequencer.EventCallback _onSequenceCallback {
			add; // 0x00000001868ED6F0-0x00000001868ED784
			remove; // 0x00000001868EFB60-0x00000001868EFBF4
		}
		public event CriAtomExSequencer.EventCallback OnSequenceCallback {
			add; // 0x00000001868ED5C0-0x00000001868ED65C
			remove; // 0x00000001868EFA38-0x00000001868EFACC
		}
	
		// Nested types
		public enum Status // TypeDefIndex: 57790
		{
			Stop = 0,
			Prep = 1,
			Playing = 2,
			PlayEnd = 3,
			Error = 4
		}
	
		private struct Config // TypeDefIndex: 57791
		{
			// Fields
			public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod; // 0x00
			public int maxPathStrings; // 0x04
			public int maxPath; // 0x08
			public int maxAisacs; // 0x0C
			public bool updatesTime; // 0x10
			public bool enableAudioSyncedTimer; // 0x11
		}
	
		public enum TimeStretchParameterId // TypeDefIndex: 57792
		{
			Ratio = 0,
			FrameTime = 1,
			Quality = 2
		}
	
		public enum PitchShifterParameterId // TypeDefIndex: 57793
		{
			Pitch = 0,
			Formant = 1,
			Mode = 2
		}
	
		// Constructors
		public CriAtomExPlayer(); // 0x00000001868ED3A4-0x00000001868ED3C8
		public CriAtomExPlayer(int maxPath, int maxPathStrings); // 0x00000001868ED384-0x00000001868ED3A4
		public CriAtomExPlayer(bool enableAudioSyncedTimer); // 0x00000001868ED360-0x00000001868ED384
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer); // 0x00000001868ED344-0x00000001868ED360
		public CriAtomExPlayer(IntPtr existingNativeHandle); // 0x00000001868ED320-0x00000001868ED344
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle); // 0x00000001868ED3C8-0x00000001868ED524
	
		// Methods
		public override void Dispose(); // 0x00000001868EC8D8-0x00000001868EC9EC
		public void SetCue(CriAtomExAcb acb, string name); // 0x00000001868ECFFC-0x00000001868ED014
		public void SetCue(CriAtomExAcb acb, int id); // 0x00000001868ED014-0x00000001868ED02C
		public void SetCueIndex(CriAtomExAcb acb, int index); // 0x00000001868ECFD8-0x00000001868ECFF0
		public void SetContentId(CriFsBinder binder, int contentId); // 0x00000001868ECFC0-0x00000001868ECFD8
		public void SetFile(CriFsBinder binder, string path); // 0x00000001868ED0F4-0x00000001868ED10C
		public void SetData(byte[] buffer, int size); // 0x00000001868ED038-0x00000001868ED044
		public void SetData(IntPtr buffer, int size); // 0x00000001868ED02C-0x00000001868ED038
		public void SetFormat(CriAtomEx.Format format); // 0x00000001868ED118-0x00000001868ED124
		public void SetNumChannels(int numChannels); // 0x00000001868ED130-0x00000001868ED13C
		public void SetSamplingRate(int samplingRate); // 0x00000001868ED19C-0x00000001868ED1A8
		public void PrepareEntryPool(int capacity, bool stopOnEmpty); // 0x00000001868ECE68-0x00000001868ECED4
		public int GetNumEntries(); // 0x00000001868ECCF4-0x00000001868ECD14
		public int GetNumConsumedEntries(); // 0x00000001868ECCD4-0x00000001868ECCF4
		public bool EntryFile(CriFsBinder binder, string path, bool repeat); // 0x00000001868ECA8C-0x00000001868ECAC0
		public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat); // 0x00000001868EC9EC-0x00000001868ECA18
		public bool EntryData(byte[] buffer, int size, bool repeat); // 0x00000001868ECA68-0x00000001868ECA8C
		public bool EntryData(IntPtr buffer, int size, bool repeat); // 0x00000001868ECA44-0x00000001868ECA68
		public bool EntryCue(CriAtomExAcb acb, string name, bool repeat); // 0x00000001868ECA18-0x00000001868ECA44
		public CriAtomExPlayback Start(); // 0x00000001868ED21C-0x00000001868ED248
		public CriAtomExPlayback Prepare(); // 0x00000001868ECED4-0x00000001868ECEE0
		public void Stop(bool ignoresReleaseTime); // 0x00000001868ED27C-0x00000001868ED2BC
		public void Pause(); // 0x00000001868ECE4C-0x00000001868ECE5C
		public void Resume(CriAtomEx.ResumeMode mode); // 0x00000001868ECEF8-0x00000001868ECF04
		public bool IsPaused(); // 0x00000001868ECD5C-0x00000001868ECD68
		public void SetVolume(float volume); // 0x00000001868ED210-0x00000001868ED21C
		public void SetPitch(float pitch); // 0x00000001868ED16C-0x00000001868ED178
		public void SetPlaybackRatio(float ratio); // 0x00000001868ED178-0x00000001868ED184
		public void SetPan3dAngle(float angle); // 0x00000001868ED13C-0x00000001868ED148
		public void SetPan3dInteriorDistance(float distance); // 0x00000001868ED148-0x00000001868ED154
		public void SetPan3dVolume(float volume); // 0x00000001868ED154-0x00000001868ED160
		public void SetPanType(CriAtomEx.PanType panType); // 0x00000001868ED160-0x00000001868ED16C
		public void SetSendLevel(int channel, CriAtomEx.Speaker id, float level); // 0x00000001868ED1B4-0x00000001868ED1C8
		public void SetBiquadFilterParameters(CriAtomEx.BiquadFilterType type, float frequency, float gain, float q); // 0x00000001868ECF64-0x00000001868ECF78
		public void SetBandpassFilterParameters(float cofLow, float cofHigh); // 0x00000001868ECF58-0x00000001868ECF64
		public void SetBusSendLevel(string busName, float level); // 0x00000001868ECF90-0x00000001868ECF9C
		public bool GetBusSendLevel(string busName, out float level); // 0x00000001868ECCC8-0x00000001868ECCD4
		[Obsolete("Use CriAtomExPlayer.SetBusSendLevel(string busName, float level)")]
		public void SetBusSendLevel(int busId, float level); // 0x00000001868ECF9C-0x00000001868ECFA8
		public void SetBusSendLevelOffset(string busName, float levelOffset); // 0x00000001868ECF78-0x00000001868ECF84
		public bool GetBusSendLevelOffset(string busName, out float level); // 0x00000001868ECCBC-0x00000001868ECCC8
		[Obsolete("Use CriAtomExPlayer.SetBusSendLevelOffset(int busId, float levelOffset)")]
		public void SetBusSendLevelOffset(int busId, float levelOffset); // 0x00000001868ECF84-0x00000001868ECF90
		public void AttachAisac(string globalAisacName); // 0x00000001868EC2EC-0x00000001868EC2F8
		public void DetachAisac(string globalAisacName); // 0x00000001868EC890-0x00000001868EC89C
		public void SetAisacControl(string controlName, float value); // 0x00000001868ECF34-0x00000001868ECF40
		[Obsolete("Use CriAtomExPlayer.SetAisacControl")]
		public void SetAisac(string controlName, float value); // 0x00000001868ECF34-0x00000001868ECF40
		public void SetAisacControl(uint controlId, float value); // 0x00000001868ECF40-0x00000001868ECF4C
		[Obsolete("Use SetAisacControl")]
		public void SetAisac(uint controlId, float value); // 0x00000001868ECF40-0x00000001868ECF4C
		public bool GetAttachedAisacInfo(int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo); // 0x00000001868ECAC0-0x00000001868ECCBC
		public void Set3dSource(CriAtomEx3dSource source); // 0x00000001868ECF1C-0x00000001868ECF34
		public void Set3dListener(CriAtomEx3dListener listener); // 0x00000001868ECF04-0x00000001868ECF1C
		public void SetStartTime(long startTimeMs); // 0x00000001868ED1E0-0x00000001868ED1EC
		public void SetFirstBlockIndex(int index); // 0x00000001868ED10C-0x00000001868ED118
		public void SetSelectorLabel(string selector, string label); // 0x00000001868ED1A8-0x00000001868ED1B4
		public void UnsetSelectorLabel(string selector); // 0x00000001868ED2FC-0x00000001868ED308
		public void ClearSelectorLabels(); // 0x00000001868EC884-0x00000001868EC890
		public void SetCategory(int categoryId); // 0x00000001868ECFA8-0x00000001868ECFB4
		public void SetCategory(string categoryName); // 0x00000001868ECFB4-0x00000001868ECFC0
		public void UnsetCategory(); // 0x00000001868ED2F0-0x00000001868ED2FC
		public void SetCuePriority(int priority); // 0x00000001868ECFF0-0x00000001868ECFFC
		public void SetVoicePriority(int priority); // 0x00000001868ED204-0x00000001868ED210
		public void SetVoiceControlMethod(CriAtomEx.VoiceControlMethod method); // 0x00000001868ED1EC-0x00000001868ED1F8
		public void SetPreDelayTime(float time); // 0x00000001868ED184-0x00000001868ED190
		public void SetEnvelopeAttackTime(float time); // 0x00000001868ED088-0x00000001868ED094
		public void SetEnvelopeHoldTime(float time); // 0x00000001868ED0A0-0x00000001868ED0AC
		public void SetEnvelopeDecayTime(float time); // 0x00000001868ED094-0x00000001868ED0A0
		public void SetEnvelopeReleaseTime(float time); // 0x00000001868ED0AC-0x00000001868ED0B8
		public void SetEnvelopeSustainLevel(float level); // 0x00000001868ED0B8-0x00000001868ED0C4
		public void AttachFader(); // 0x00000001868EC2F8-0x00000001868EC31C
		public void DetachFader(); // 0x00000001868EC89C-0x00000001868EC8A8
		public void SetFadeOutTime(int ms); // 0x00000001868ED0E8-0x00000001868ED0F4
		public void SetFadeInTime(int ms); // 0x00000001868ED0D0-0x00000001868ED0DC
		public void SetFadeInStartOffset(int ms); // 0x00000001868ED0C4-0x00000001868ED0D0
		public void SetFadeOutEndDelay(int ms); // 0x00000001868ED0DC-0x00000001868ED0E8
		public bool IsFading(); // 0x00000001868ECD50-0x00000001868ECD5C
		public void ResetFaderParameters(); // 0x00000001868ECEE0-0x00000001868ECEEC
		public void SetGroupNumber(int group_no); // 0x00000001868ED124-0x00000001868ED130
		public void Update(CriAtomExPlayback playback); // 0x00000001868ED314-0x00000001868ED320
		public void UpdateAll(); // 0x00000001868ED308-0x00000001868ED314
		public void ResetParameters(); // 0x00000001868ECEEC-0x00000001868ECEF8
		public long GetTime(); // 0x00000001868ECD44-0x00000001868ECD50
		public Status GetStatus(); // 0x00000001868ECD38-0x00000001868ECD44
		public float GetParameterFloat32(CriAtomEx.Parameter id); // 0x00000001868ECD14-0x00000001868ECD20
		public uint GetParameterUint32(CriAtomEx.Parameter id); // 0x00000001868ECD2C-0x00000001868ECD38
		public int GetParameterSint32(CriAtomEx.Parameter id); // 0x00000001868ECD20-0x00000001868ECD2C
		public void SetSoundRendererType(CriAtomEx.SoundRendererType type); // 0x00000001868ED1D4-0x00000001868ED1E0
		public void SetRandomSeed(uint seed); // 0x00000001868ED190-0x00000001868ED19C
		public void Loop(bool sw); // 0x00000001868ECD68-0x00000001868ECDE4
		public void SetAsrRackId(int asr_rack_id); // 0x00000001868ECF4C-0x00000001868ECF58
		public void SetVoicePoolIdentifier(uint identifier); // 0x00000001868ED1F8-0x00000001868ED204
		public void SetDspTimeStretchRatio(float ratio); // 0x00000001868ED074-0x00000001868ED088
		public void SetDspPitchShifterPitch(float pitch); // 0x00000001868ED050-0x00000001868ED074
		public void SetDspParameter(int id, float value); // 0x00000001868ED044-0x00000001868ED050
		public void SetSequencePrepareTime(uint ms); // 0x00000001868ED1C8-0x00000001868ED1D4
		public void AttachTween(CriAtomExTween tween); // 0x00000001868EC31C-0x00000001868EC340
		public void DetachTween(CriAtomExTween tween); // 0x00000001868EC8B4-0x00000001868EC8D8
		public void DetachTweenAll(); // 0x00000001868EC8A8-0x00000001868EC8B4
		public void Stop(); // 0x00000001868ED2BC-0x00000001868ED2F0
		public void StopWithoutReleaseTime(); // 0x00000001868ED248-0x00000001868ED27C
		public void Pause(bool sw); // 0x00000001868ECE5C-0x00000001868ECE68
		~CriAtomExPlayer(); // 0x00000001868DA7D8-0x00000001868DA84C
		private void OnBeatSyncCallbackChainInternal(ref CriAtomExBeatSync.Info info); // 0x00000001868ECDE4-0x00000001868ECE18
		private void OnSequenceCallbackChainInternal(ref CriAtomExSequencer.CriAtomExSequenceEventInfo info); // 0x00000001868ECE18-0x00000001868ECE4C
		private static extern IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size); // 0x00000001868ED97C-0x00000001868EDA90
		private static extern void criAtomExPlayer_Destroy(IntPtr player); // 0x00000001868EDA90-0x00000001868EDAC4
		private static extern void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id); // 0x00000001868EE8C8-0x00000001868EE95C
		private static extern void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name); // 0x00000001868EE9F0-0x00000001868EEA98
		private static extern void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index); // 0x00000001868EE95C-0x00000001868EE9F0
		private static extern void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path); // 0x00000001868EEEE4-0x00000001868EEF8C
		private static extern void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size); // 0x00000001868EEB6C-0x00000001868EEC0C
		private static extern void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size); // 0x00000001868EEAD8-0x00000001868EEB6C
		private static extern void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id); // 0x00000001868EE834-0x00000001868EE8C8
		private static extern void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier); // 0x00000001868EF674-0x00000001868EF6B4
		private static extern uint criAtomExPlayer_Start(IntPtr player); // 0x00000001868EF774-0x00000001868EF7EC
		private static extern uint criAtomExPlayer_Prepare(IntPtr player); // 0x00000001868EE164-0x00000001868EE1DC
		private static extern void criAtomExPlayer_Stop(IntPtr player); // 0x00000001868EF820-0x00000001868EF854
		private static extern void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player); // 0x00000001868EF7EC-0x00000001868EF820
		private static extern void criAtomExPlayer_Pause(IntPtr player, bool sw); // 0x00000001868EE0E0-0x00000001868EE164
		private static extern void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode); // 0x00000001868EE288-0x00000001868EE30C
		private static extern bool criAtomExPlayer_IsPaused(IntPtr player); // 0x00000001868EE068-0x00000001868EE0A0
		private static extern Status criAtomExPlayer_GetStatus(IntPtr player); // 0x00000001868EDF84-0x00000001868EDFB8
		private static extern long criAtomExPlayer_GetTime(IntPtr player); // 0x00000001868EDFB8-0x00000001868EE030
		private static extern void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format); // 0x00000001868EEFCC-0x00000001868EF050
		private static extern void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels); // 0x00000001868EF090-0x00000001868EF0D0
		private static extern void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate); // 0x00000001868EF350-0x00000001868EF3D4
		private static extern IntPtr CRIWAREF1DB6C3C(IntPtr player, int capacity, int max_path, bool stopOnEmpty); // 0x00000001868EC728-0x00000001868EC7CC
		private static extern void CRIWARE348B99F2(IntPtr pool); // 0x00000001868EC45C-0x00000001868EC490
		private static extern int CRIWAREB0CA8CB3(IntPtr pool); // 0x00000001868EC6C0-0x00000001868EC6F4
		private static extern int CRIWAREF2104D05(IntPtr pool); // 0x00000001868EC7CC-0x00000001868EC800
		private static extern void CRIWAREBAFBC575(IntPtr pool); // 0x00000001868EC6F4-0x00000001868EC728
		private static extern bool CRIWARE5277731E(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path); // 0x00000001868EC490-0x00000001868EC560
		private static extern bool CRIWARE78E74FE0(IntPtr pool, IntPtr binder, int id, bool repeat); // 0x00000001868EC624-0x00000001868EC68C
		private static extern bool CRIWARE10CB0D07(IntPtr pool, byte[] buffer, int size, bool repeat); // 0x00000001868EC340-0x00000001868EC3F4
		private static extern bool CRIWARE10CB0D07(IntPtr pool, IntPtr buffer, int size, bool repeat); // 0x00000001868EC3F4-0x00000001868EC45C
		private static extern bool CRIWARE59CCEB17(IntPtr pool, IntPtr acbhn, string name, bool repeat); // 0x00000001868EC560-0x00000001868EC624
		private static extern void CRIWARE94DBB2A3(IntPtr pool); // 0x00000001868EC68C-0x00000001868EC6C0
		private static extern void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms); // 0x00000001868EF56C-0x00000001868EF5F0
		private static extern void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms); // 0x00000001868EF4EC-0x00000001868EF52C
		private static extern void criAtomExPlayer_LimitLoopCount(IntPtr player, int count); // 0x00000001868EE0A0-0x00000001868EE0E0
		private static extern void criAtomExPlayer_Update(IntPtr player, uint id); // 0x00000001868EF914-0x00000001868EF998
		private static extern void criAtomExPlayer_UpdateAll(IntPtr player); // 0x00000001868EF8E0-0x00000001868EF914
		private static extern void criAtomExPlayer_ResetParameters(IntPtr player); // 0x00000001868EE254-0x00000001868EE288
		private static extern float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001868EDDC8-0x00000001868EDE04
		private static extern uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001868EDE88-0x00000001868EDF0C
		private static extern int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id); // 0x00000001868EDE04-0x00000001868EDE88
		private static extern IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player); // 0x00000001868EDF0C-0x00000001868EDF84
		private static extern void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, ushort id); // 0x00000001868ED784-0x00000001868ED808
		private static extern void criAtomExPlayer_SetVolume(IntPtr player, float volume); // 0x00000001868EF738-0x00000001868EF774
		private static extern void criAtomExPlayer_SetPitch(IntPtr player, float pitch); // 0x00000001868EF218-0x00000001868EF254
		private static extern void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio); // 0x00000001868EF254-0x00000001868EF290
		private static extern void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle); // 0x00000001868EF0D0-0x00000001868EF10C
		private static extern void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance); // 0x00000001868EF10C-0x00000001868EF150
		private static extern void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume); // 0x00000001868EF150-0x00000001868EF194
		private static extern void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType panType); // 0x00000001868EF194-0x00000001868EF218
		private static extern void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level); // 0x00000001868EF490-0x00000001868EF4EC
		private static extern void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level); // 0x00000001868EE6C8-0x00000001868EE718
		private static extern void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level); // 0x00000001868EE5B4-0x00000001868EE61C
		private static extern bool criAtomExPlayer_GetBusSendLevelByName(IntPtr player, string bus_name, out float level); // 0x00000001868EDC60-0x00000001868EDD14
		private static extern void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset); // 0x00000001868EE67C-0x00000001868EE6C8
		private static extern void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset); // 0x00000001868EE61C-0x00000001868EE67C
		private static extern bool criAtomExPlayer_GetBusSendLevelOffsetByName(IntPtr player, string bus_name, out float level_offset); // 0x00000001868EDD14-0x00000001868EDDC8
		private static extern void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high); // 0x00000001868EE50C-0x00000001868EE558
		private static extern void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q); // 0x00000001868EE558-0x00000001868EE5B4
		private static extern void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority); // 0x00000001868EF6B4-0x00000001868EF738
		private static extern void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method); // 0x00000001868EF5F0-0x00000001868EF674
		private static extern void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value); // 0x00000001868EE3D4-0x00000001868EE420
		private static extern void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value); // 0x00000001868EE420-0x00000001868EE488
		private static extern void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source); // 0x00000001868EE350-0x00000001868EE3D4
		private static extern void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener); // 0x00000001868EE30C-0x00000001868EE350
		private static extern void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id); // 0x00000001868EE718-0x00000001868EE79C
		private static extern void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name); // 0x00000001868EE79C-0x00000001868EE834
		private static extern void criAtomExPlayer_UnsetCategory(IntPtr player); // 0x00000001868EF854-0x00000001868EF888
		private static extern void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority); // 0x00000001868EEA98-0x00000001868EEAD8
		private static extern void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms); // 0x00000001868EF290-0x00000001868EF2CC
		private static extern void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms); // 0x00000001868EEC5C-0x00000001868EECA0
		private static extern void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms); // 0x00000001868EECDC-0x00000001868EED18
		private static extern void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms); // 0x00000001868EECA0-0x00000001868EECDC
		private static extern void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms); // 0x00000001868EED18-0x00000001868EED5C
		private static extern void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level); // 0x00000001868EED5C-0x00000001868EEDA0
		private static extern void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size); // 0x00000001868ED860-0x00000001868ED904
		private static extern void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName); // 0x00000001868ED808-0x00000001868ED860
		private static extern void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName); // 0x00000001868EDAC4-0x00000001868EDB1C
		private static extern void criAtomExPlayer_DetachFader(IntPtr player); // 0x00000001868EDB1C-0x00000001868EDB50
		private static extern void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms); // 0x00000001868EEEA4-0x00000001868EEEE4
		private static extern void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms); // 0x00000001868EEDE0-0x00000001868EEE64
		private static extern void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms); // 0x00000001868EEDA0-0x00000001868EEDE0
		private static extern void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms); // 0x00000001868EEE64-0x00000001868EEEA4
		private static extern bool criAtomExPlayer_IsFading(IntPtr player); // 0x00000001868EE030-0x00000001868EE068
		private static extern void criAtomExPlayer_ResetFaderParameters(IntPtr player); // 0x00000001868EE1DC-0x00000001868EE254
		private static extern void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no); // 0x00000001868EF050-0x00000001868EF090
		private static extern bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info); // 0x00000001868EDBC8-0x00000001868EDC60
		private static extern void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index); // 0x00000001868EEF8C-0x00000001868EEFCC
		private static extern void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label); // 0x00000001868EF3D4-0x00000001868EF490
		private static extern void criAtomExPlayer_UnsetSelectorLabel(IntPtr player, string selector); // 0x00000001868EF888-0x00000001868EF8E0
		private static extern void criAtomExPlayer_ClearSelectorLabels(IntPtr player); // 0x00000001868ED948-0x00000001868ED97C
		private static extern void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type); // 0x00000001868EF52C-0x00000001868EF56C
		private static extern void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed); // 0x00000001868EF2CC-0x00000001868EF350
		private static extern void CRIWAREF466419F(IntPtr player, bool sw); // 0x00000001868EC800-0x00000001868EC884
		private static extern void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id); // 0x00000001868EE488-0x00000001868EE50C
		private static extern void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value); // 0x00000001868EEC0C-0x00000001868EEC5C
		private static extern void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween); // 0x00000001868ED904-0x00000001868ED948
		private static extern void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween); // 0x00000001868EDB84-0x00000001868EDBC8
		private static extern void criAtomExPlayer_DetachTweenAll(IntPtr player); // 0x00000001868EDB50-0x00000001868EDB84
	}

	[Obsolete("Use CriAtomExOutputAnalyzer")]
	public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer // TypeDefIndex: 57797
	{
		// Nested types
		public enum Type // TypeDefIndex: 57795
		{
			LevelMeter = 0,
			SpectrumAnalyzer = 1,
			PcmCapture = 2
		}
	
		public struct Config // TypeDefIndex: 57796
		{
			// Fields
			public int num_spectrum_analyzer_bands; // 0x00
			public int num_stored_output_data; // 0x04
	
			// Constructors
			public Config(int num_spectrum_analyzer_bands = 8 /* Metadata: 0x0234B9BA */, int num_stored_output_data = 4096 /* Metadata: 0x0234B9BB */); // 0x0000000184D85C40-0x0000000184D85C50
		}
	
		// Constructors
		public CriAtomExPlayerOutputAnalyzer(Type[] types, Config[] configs = null); // 0x00000001868EC1CC-0x00000001868EC2EC
	}

	public class CriAtomExSoundObject : CriDisposable // TypeDefIndex: 57799
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		private struct Config // TypeDefIndex: 57798
		{
			// Fields
			public bool enableVoiceLimitScope; // 0x00
			public bool enableCategoryCueLimitScope; // 0x01
		}
	
		// Constructors
		public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope); // 0x00000001868EFE7C-0x00000001868EFF80
	
		// Methods
		public override void Dispose(); // 0x00000001868EFE00-0x00000001868EFE7C
		public void AddPlayer(CriAtomExPlayer player); // 0x00000001868EFDAC-0x00000001868EFDD0
		public void DeletePlayer(CriAtomExPlayer player); // 0x00000001868EFDDC-0x00000001868EFE00
		public void DeleteAllPlayers(); // 0x00000001868EFDD0-0x00000001868EFDDC
		~CriAtomExSoundObject(); // 0x00000001868DA7D8-0x00000001868DA84C
		private static extern IntPtr criAtomExSoundObject_Create(ref Config config, IntPtr work, int work_size); // 0x00000001868F0004-0x00000001868F00C8
		private static extern void criAtomExSoundObject_Destroy(IntPtr soundObject); // 0x00000001868F0184-0x00000001868F01B8
		private static extern void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player); // 0x00000001868EFF80-0x00000001868F0004
		private static extern void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player); // 0x00000001868F0140-0x00000001868F0184
		private static extern void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject); // 0x00000001868F00C8-0x00000001868F0140
	}

	public class CriAtomExTween : CriDisposable // TypeDefIndex: 57803
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		internal IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public float Value { get; } // 0x00000001868F0914-0x00000001868F0920 
		public bool IsActive { get; } // 0x00000001868F0908-0x00000001868F0914 
	
		// Nested types
		public enum ParameterType // TypeDefIndex: 57800
		{
			Basic = 0,
			Aisac = 1
		}
	
		private struct Config // TypeDefIndex: 57802
		{
			// Fields
			public Target target; // 0x00
			public ParameterType parameterType; // 0x04
	
			// Nested types
			public struct Target // TypeDefIndex: 57801
			{
				// Fields
				public CriAtomEx.Parameter parameterId; // 0x00
				public uint aisacIds; // 0x00
			}
		}
	
		// Constructors
		public CriAtomExTween(); // 0x00000001868F0524-0x00000001868F0534
		public CriAtomExTween(CriAtomEx.Parameter parameterId); // 0x00000001868F0644-0x00000001868F0654
		public CriAtomExTween(uint aisacId); // 0x00000001868F0634-0x00000001868F0644
		public CriAtomExTween(ParameterType parameterType, uint targetId); // 0x00000001868F0534-0x00000001868F0634
	
		// Methods
		public override void Dispose(); // 0x00000001868F03E8-0x00000001868F03F4
		public void MoveTo(ushort durationMs, float value); // 0x00000001868F0500-0x00000001868F050C
		public void MoveFrom(ushort durationMs, float value); // 0x00000001868F04F4-0x00000001868F0500
		public void Stop(); // 0x00000001868F0518-0x00000001868F0524
		public void Reset(); // 0x00000001868F050C-0x00000001868F0518
		~CriAtomExTween(); // 0x00000001868F0480-0x00000001868F04F4
		protected virtual void Dispose(bool disposing); // 0x00000001868F03F4-0x00000001868F0480
		private static extern IntPtr criAtomExTween_Create(ref Config config, IntPtr work, int work_size); // 0x00000001868F0654-0x00000001868F06E8
		private static extern void criAtomExTween_Destroy(IntPtr tween); // 0x00000001868F06E8-0x00000001868F0760
		private static extern float criAtomExTween_GetValue(IntPtr tween); // 0x00000001868F0760-0x00000001868F078C
		private static extern void criAtomExTween_MoveTo(IntPtr tween, ushort time_ms, float value); // 0x00000001868F0810-0x00000001868F085C
		private static extern void criAtomExTween_MoveFrom(IntPtr tween, ushort time_ms, float value); // 0x00000001868F07C4-0x00000001868F0810
		private static extern void criAtomExTween_Stop(IntPtr tween); // 0x00000001868F0890-0x00000001868F0908
		private static extern void criAtomExTween_Reset(IntPtr tween); // 0x00000001868F085C-0x00000001868F0890
		private static extern bool criAtomExTween_IsActive(IntPtr tween); // 0x00000001868F078C-0x00000001868F07C4
	}

	public abstract class CriAtomExVoicePool : CriDisposable // TypeDefIndex: 57813
	{
		// Fields
		public const int StandardMemoryAsrVoicePoolId = 0; // Metadata: 0x0234B9C3
		public const int StandardStreamingAsrVoicePoolId = 1; // Metadata: 0x0234B9C4
		public const int StandardMemoryNsrVoicePoolId = 2; // Metadata: 0x0234B9C5
		public const int StandardStreamingNsrVoicePoolId = 3; // Metadata: 0x0234B9C6
		protected IntPtr _handle; // 0x20
		protected uint _identifier; // 0x28
		protected int _numVoices; // 0x2C
		protected int _maxChannels; // 0x30
		protected int _maxSamplingRate; // 0x34
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public uint identifier { get; } // 0x00000001811F2A90-0x00000001811F2AA0 
		public int numVoices { get; } // 0x0000000184D86710-0x0000000184D86720 
		public int maxChannels { get; } // 0x0000000184D864F0-0x0000000184D86500 
		public int maxSamplingRate { get; } // 0x0000000184D86730-0x0000000184D86740 
	
		// Nested types
		public enum VoicePoolId // TypeDefIndex: 57804
		{
			StandardMemory = 0,
			StandardStreaming = 1,
			HcaMxMemory = 4,
			HcaMxStreaming = 5
		}
	
		public enum PitchShifterMode // TypeDefIndex: 57805
		{
			Music = 0,
			Vocal = 1,
			SoundEffect = 2,
			Speech = 3
		}
	
		public struct UsedVoicesInfo // TypeDefIndex: 57806
		{
			// Fields
			public int numUsedVoices; // 0x00
			public int numPoolVoices; // 0x04
		}
	
		protected struct PlayerConfig // TypeDefIndex: 57807
		{
			// Fields
			public int maxChannels; // 0x00
			public int maxSamplingRate; // 0x04
			public bool streamingFlag; // 0x08
			public int soundRendererType; // 0x0C
			public int decodeLatency; // 0x10
			private IntPtr context; // 0x18
		}
	
		protected struct VoicePoolConfig // TypeDefIndex: 57808
		{
			// Fields
			public uint identifier; // 0x00
			public int numVoices; // 0x04
			public PlayerConfig playerConfig; // 0x08
		}
	
		private struct PitchShifterConfig // TypeDefIndex: 57809
		{
			// Fields
			public int mode; // 0x00
			public int windowSize; // 0x04
			public int overlapTimes; // 0x08
		}
	
		private struct ExPitchShifterConfig // TypeDefIndex: 57810
		{
			// Fields
			public int numDsp; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public PitchShifterConfig config; // 0x0C
		}
	
		private struct TimeStretchConfig // TypeDefIndex: 57811
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private struct ExTimeStretchConfig // TypeDefIndex: 57812
		{
			// Fields
			public int numDsp; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public TimeStretchConfig config; // 0x0C
		}
	
		// Constructors
		protected CriAtomExVoicePool(); // 0x00000001868F0B34-0x00000001868F0B44
	
		// Methods
		public static UsedVoicesInfo GetNumUsedVoices(VoicePoolId voicePoolId); // 0x00000001868F0AD4-0x00000001868F0B00
		public override void Dispose(); // 0x00000001868F0A58-0x00000001868F0AD4
		public UsedVoicesInfo GetNumUsedVoices(); // 0x00000001868F0B00-0x00000001868F0B34
		public void AttachDspTimeStretch(); // 0x00000001868F096C-0x00000001868F09B0
		public void AttachDspPitchShifter(PitchShifterMode mode = PitchShifterMode.Music /* Metadata: 0x0234B9BF */, int windosSize = 1024 /* Metadata: 0x0234B9C0 */, int overlapTimes = 4 /* Metadata: 0x0234B9C2 */); // 0x00000001868F0920-0x00000001868F096C
		public void DetachDsp(); // 0x00000001868F0A44-0x00000001868F0A58
		~CriAtomExVoicePool(); // 0x00000001868DA7D8-0x00000001868DA84C
		private static extern void CRIWARED389B244(int voice_pool_id, out int num_used_voices, out int num_pool_voices); // 0x00000001868F09B0-0x00000001868F0A44
		private static extern void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices); // 0x00000001868F0CF4-0x00000001868F0D88
		public static extern void criAtomExVoicePool_Free(IntPtr pool); // 0x00000001868F0CC0-0x00000001868F0CF4
		private static extern void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref ExTimeStretchConfig config, IntPtr work, int work_size); // 0x00000001868F0BE8-0x00000001868F0C8C
		private static extern void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref ExPitchShifterConfig config, IntPtr work, int work_size); // 0x00000001868F0B44-0x00000001868F0BE8
		private static extern void criAtomExVoicePool_DetachDsp(IntPtr pool); // 0x00000001868F0C8C-0x00000001868F0CC0
	}

	public class CriAtomExStandardVoicePool : CriAtomExVoicePool // TypeDefIndex: 57814
	{
		// Constructors
		public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x0234B9CF */); // 0x00000001868F01B8-0x00000001868F02E4
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x00000001868F02E4-0x00000001868F03E8
	}

	public class CriAtomExWaveVoicePool : CriAtomExVoicePool // TypeDefIndex: 57815
	{
		// Constructors
		public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x0234B9D0 */); // 0x00000001868F0D88-0x00000001868F0EB4
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x00000001868F0EB4-0x00000001868F0FB8
	}

	public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool // TypeDefIndex: 57819
	{
		// Nested types
		public enum RawPcmFormat // TypeDefIndex: 57816
		{
			Sint16 = 0,
			Float32 = 1
		}
	
		protected struct RawPcmPlayerConfig // TypeDefIndex: 57817
		{
			// Fields
			public RawPcmFormat format; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public int soundRendererType; // 0x0C
			public int decodeLatency; // 0x10
			private IntPtr context; // 0x18
		}
	
		protected struct RawPcmVoicePoolConfig // TypeDefIndex: 57818
		{
			// Fields
			public uint identifier; // 0x00
			public int numVoices; // 0x04
			public RawPcmPlayerConfig playerConfig; // 0x08
		}
	
		// Constructors
		public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, RawPcmFormat format, uint identifier = 0 /* Metadata: 0x0234B9D1 */); // 0x00000001868EFBF4-0x00000001868EFD1C
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref RawPcmVoicePoolConfig config, IntPtr work, int work_size); // 0x00000001868EFD1C-0x00000001868EFDAC
	}

	public class CriAudioReadStream // TypeDefIndex: 57823
	{
		// Fields
		private InternalDelegate internalDelegate; // 0x10
		[CompilerGenerated]
		private IntPtr _callbackFunction_k__BackingField; // 0x18
		[CompilerGenerated]
		private IntPtr _callbackPointer_k__BackingField; // 0x20
	
		// Properties
		public IntPtr callbackFunction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
		public IntPtr callbackPointer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000184D86500-0x0000000184D86510
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 57820; 0x00000001814F3120-0x00000001814F3140
	
		public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 57821; 0x00000001815802E0-0x00000001815802F0
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 57822
		{
			// Fields
			public int bufferSize; // 0x10
			public CriWare.CriAudioReadStream.Delegate callback; // 0x18
			public int numChannels; // 0x20
			public float[][] buffer; // 0x28
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal uint _.ctor_b__0(IntPtr cbobj, IntPtr data, uint numSamples); // 0x00000001868FF0B8-0x00000001868FF1A8
		}
	
		// Constructors
		public CriAudioReadStream(IntPtr callbackFunction, IntPtr callbackPointer); // 0x0000000184D88FE0-0x0000000184D88FF0
		public CriAudioReadStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x0234B9D4 */); // 0x00000001868F0FB8-0x00000001868F1138
	}

	public class CriAudioWriteStream // TypeDefIndex: 57827
	{
		// Fields
		private InternalDelegate internalDelegate; // 0x10
		[CompilerGenerated]
		private IntPtr _callbackFunction_k__BackingField; // 0x18
		[CompilerGenerated]
		private IntPtr _callbackPointer_k__BackingField; // 0x20
	
		// Properties
		public IntPtr callbackFunction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
		public IntPtr callbackPointer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000184D86500-0x0000000184D86510
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 57824; 0x00000001814F3120-0x00000001814F3140
	
		public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 57825; 0x00000001815802E0-0x00000001815802F0
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 57826
		{
			// Fields
			public int bufferSize; // 0x10
			public int numChannels; // 0x14
			public CriWare.CriAudioWriteStream.Delegate callback; // 0x18
			public float[][] buffer; // 0x20
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal uint _.ctor_b__0(IntPtr cbobj, IntPtr data, uint numSamples); // 0x00000001868FEFDC-0x00000001868FF0B8
		}
	
		// Constructors
		public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer); // 0x0000000184D88FE0-0x0000000184D88FF0
		public CriAudioWriteStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x0234B9D6 */); // 0x00000001868F1138-0x00000001868F12B8
	}

	public class CriFsLoader : CriDisposable // TypeDefIndex: 57829
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle dstGch; // 0x28
		private GCHandle srcGch; // 0x30
	
		// Nested types
		public enum Status // TypeDefIndex: 57828
		{
			Stop = 0,
			Loading = 1,
			Complete = 2,
			Error = 3
		}
	
		// Constructors
		public CriFsLoader(); // 0x00000001868F4D94-0x00000001868F4EC4
	
		// Methods
		public override void Dispose(); // 0x00000001868F4988-0x00000001868F49D8
		private void Dispose(bool disposing); // 0x00000001868F48F8-0x00000001868F4988
		public void Load(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer); // 0x00000001868F4CB8-0x00000001868F4D68
		public void LoadById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer); // 0x00000001868F4AA8-0x00000001868F4B58
		public void LoadWithoutDecompression(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer); // 0x00000001868F4C08-0x00000001868F4CB8
		public void LoadWithoutDecompressionById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer); // 0x00000001868F4B58-0x00000001868F4C08
		public void DecompressData(long srcSize, byte[] srcBuffer, long dstSize, byte[] dstBuffer); // 0x00000001868F4854-0x00000001868F48F8
		public void Stop(); // 0x00000001868F4D80-0x00000001868F4D94
		public Status GetStatus(); // 0x00000001868F4A4C-0x00000001868F4AA8
		public void SetReadUnitSize(int unit_size); // 0x00000001868F4D68-0x00000001868F4D80
		~CriFsLoader(); // 0x00000001868F49D8-0x00000001868F4A4C
		private static extern int criFsLoader_Create(out IntPtr loader); // 0x00000001868F4EC4-0x00000001868F4F3C
		private static extern int criFsLoader_Destroy(IntPtr loader); // 0x00000001868F4FE0-0x00000001868F5014
		private static extern int criFsLoader_Load(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x00000001868F52C8-0x00000001868F53B0
		private static extern int criFsLoader_LoadById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x00000001868F5098-0x00000001868F513C
		private static extern int criFsLoader_Stop(IntPtr loader); // 0x00000001868F5434-0x00000001868F54AC
		private static extern int criFsLoader_GetStatus(IntPtr loader, out Status status); // 0x00000001868F5014-0x00000001868F5098
		private static extern int criFsLoader_SetReadUnitSize(IntPtr loader, long unit_size); // 0x00000001868F53B0-0x00000001868F5434
		private static extern int criFsLoader_LoadWithoutDecompression(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x00000001868F51E0-0x00000001868F52C8
		private static extern int criFsLoader_LoadWithoutDecompressionById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x00000001868F513C-0x00000001868F51E0
		private static extern int criFsLoader_DecompressData(IntPtr loader, IntPtr src, long src_size, IntPtr dst, long dst_size); // 0x00000001868F4F3C-0x00000001868F4FE0
	}

	public class CriFsInstaller : CriDisposable // TypeDefIndex: 57832
	{
		// Fields
		private byte[] installBuffer; // 0x20
		private GCHandle installBufferGch; // 0x28
		private IntPtr handle; // 0x30
	
		// Nested types
		public enum Status // TypeDefIndex: 57830
		{
			Stop = 0,
			Busy = 1,
			Complete = 2,
			Error = 3
		}
	
		private enum CopyPolicy // TypeDefIndex: 57831
		{
			Always = 0
		}
	
		// Constructors
		public CriFsInstaller(); // 0x00000001868F3CFC-0x00000001868F3E30
	
		// Methods
		public override void Dispose(); // 0x00000001868F3B34-0x00000001868F3B84
		private void Dispose(bool disposing); // 0x00000001868F3B84-0x00000001868F3C10
		public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize); // 0x00000001868F3904-0x00000001868F3B34
		public void Stop(); // 0x00000001868F3CE8-0x00000001868F3CFC
		public Status GetStatus(); // 0x00000001868F3CBC-0x00000001868F3CE8
		public float GetProgress(); // 0x00000001868F3C8C-0x00000001868F3CBC
		public static void ExecuteMain(); // 0x00000001868F3C10-0x00000001868F3C18
		~CriFsInstaller(); // 0x00000001868F3C18-0x00000001868F3C8C
		private static extern int criFsInstaller_ExecuteMain(); // 0x00000001868F3FE0-0x00000001868F400C
		private static extern int criFsInstaller_Create(out IntPtr installer, CopyPolicy option); // 0x00000001868F3F28-0x00000001868F3FAC
		private static extern int criFsInstaller_Destroy(IntPtr installer); // 0x00000001868F3FAC-0x00000001868F3FE0
		private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size); // 0x00000001868F3E30-0x00000001868F3F28
		private static extern int criFsInstaller_Stop(IntPtr installer); // 0x00000001868F4114-0x00000001868F4148
		private static extern int criFsInstaller_GetStatus(IntPtr installer, out Status status); // 0x00000001868F4090-0x00000001868F4114
		private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress); // 0x00000001868F400C-0x00000001868F4090
	}

	public class CriFsBinder : CriDisposable // TypeDefIndex: 57835
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		public enum Status // TypeDefIndex: 57833
		{
			None = 0,
			Analyze = 1,
			Complete = 2,
			Unbind = 3,
			Removed = 4,
			Invalid = 5,
			Error = 6
		}
	
		public struct ContentsFileInfo // TypeDefIndex: 57834
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
			public ContentsFileInfo(byte[] data, int startIndex); // 0x00000001868EA738-0x00000001868EA850
		}
	
		// Constructors
		public CriFsBinder(); // 0x00000001868F2C48-0x00000001868F2D78
	
		// Methods
		public override void Dispose(); // 0x00000001868F228C-0x00000001868F22DC
		private void Dispose(bool disposing); // 0x00000001868F22DC-0x00000001868F2334
		public uint BindCpk(CriFsBinder srcBinder, string path); // 0x00000001868F20E4-0x00000001868F212C
		public uint BindDirectory(CriFsBinder srcBinder, string path); // 0x00000001868F212C-0x00000001868F2174
		public uint BindFile(CriFsBinder srcBinder, string path); // 0x00000001868F21D4-0x00000001868F2214
		public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName); // 0x00000001868F2174-0x00000001868F21D4
		public static void Unbind(uint bindId); // 0x00000001868F2BFC-0x00000001868F2C48
		public static Status GetStatus(uint bindId); // 0x00000001868F2B48-0x00000001868F2BA4
		public long GetFileSize(string path); // 0x00000001868F2B04-0x00000001868F2B40
		public long GetFileSize(int id); // 0x00000001868F2AC8-0x00000001868F2B04
		public bool GetContentsFileInfo(string path, out ContentsFileInfo info); // 0x00000001868F26E8-0x00000001868F28D8
		public bool GetContentsFileInfo(int id, out ContentsFileInfo info); // 0x00000001868F28D8-0x00000001868F2AC8
		public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info); // 0x00000001868F23A8-0x00000001868F26E8
		public static int GetNumContentsFiles(uint bindId); // 0x00000001868F2B40-0x00000001868F2B48
		public static void SetPriority(uint bindId, int priority); // 0x00000001868F2BA4-0x00000001868F2BFC
		~CriFsBinder(); // 0x00000001868F2334-0x00000001868F23A8
		private static extern uint criFsBinder_Create(out IntPtr binder); // 0x00000001868F3120-0x00000001868F3198
		private static extern uint criFsBinder_Destroy(IntPtr binder); // 0x00000001868F3198-0x00000001868F3210
		private static extern uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x00000001868F2D78-0x00000001868F2E50
		private static extern uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x00000001868F2E50-0x00000001868F2F28
		private static extern uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x00000001868F3048-0x00000001868F3120
		private static extern uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId); // 0x00000001868F2F28-0x00000001868F3048
		private static extern int criFsBinder_Unbind(uint bindId); // 0x00000001868F363C-0x00000001868F36B4
		private static extern int criFsBinder_GetStatus(uint bindId, out Status status); // 0x00000001868F3538-0x00000001868F35BC
		private static extern int criFsBinder_GetFileSize(IntPtr binder, string path, out long size); // 0x00000001868F3488-0x00000001868F3538
		private static extern int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size); // 0x00000001868F33F4-0x00000001868F3488
		private static extern int criFsBinder_SetPriority(uint bindId, int priority); // 0x00000001868F35BC-0x00000001868F363C
		private static extern int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info); // 0x00000001868F3344-0x00000001868F33F4
		private static extern int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info); // 0x00000001868F3210-0x00000001868F32A4
		private static extern int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num); // 0x00000001868F32A4-0x00000001868F3344
		private static extern int CRIWAREF02BA103(uint id); // 0x00000001868F2214-0x00000001868F228C
	}

	public class CriFsRequest : CriDisposable // TypeDefIndex: 57838
	{
		// Fields
		[CompilerGenerated]
		private DoneDelegate _doneDelegate_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _isDone_k__BackingField; // 0x28
		[CompilerGenerated]
		private string _error_k__BackingField; // 0x30
		[CompilerGenerated]
		private bool _isDisposed_k__BackingField; // 0x38
	
		// Properties
		public DoneDelegate doneDelegate { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool isDone { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public string error { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
	
		// Nested types
		public delegate void DoneDelegate(CriFsRequest request); // TypeDefIndex: 57836; 0x0000000182B46B90-0x0000000182B46BA0
	
		[CompilerGenerated]
		private sealed class _CheckDone_d__23 : IEnumerator<object> // TypeDefIndex: 57837
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriFsRequest __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CheckDone_d__23(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001868FEE14-0x00000001868FEE5C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001868FEE5C-0x00000001868FEEA8
		}
	
		// Constructors
		public CriFsRequest(); // 0x00000001868F38FC-0x00000001868F3904
	
		// Methods
		public override void Dispose(); // 0x00000001868F59C4-0x00000001868F5A20
		public virtual void Stop(); // 0x00000001841E1670-0x00000001841E1680
		public YieldInstruction WaitForDone(MonoBehaviour mb); // 0x00000001868F5AC4-0x00000001868F5AF4
		protected virtual void Dispose(bool disposing); // 0x00000001841E1670-0x00000001841E1680
		public virtual void Update(); // 0x00000001841E1670-0x00000001841E1680
		protected void Done(); // 0x00000001868F5A20-0x00000001868F5A40
		[IteratorStateMachine(typeof(_CheckDone_d__23))]
		private IEnumerator CheckDone(); // 0x00000001868F5968-0x00000001868F59C4
		~CriFsRequest(); // 0x00000001868F5A40-0x00000001868F5AC4
	}

	public class CriFsLoadFileRequest : CriFsRequest // TypeDefIndex: 57840
	{
		// Fields
		[CompilerGenerated]
		private string _path_k__BackingField; // 0x40
		[CompilerGenerated]
		private byte[] _bytes_k__BackingField; // 0x48
		private Phase phase; // 0x50
		private CriFsBinder refBinder; // 0x58
		private CriFsBinder newBinder; // 0x60
		private uint bindId; // 0x68
		private CriFsLoader loader; // 0x70
		private int readUnitSize; // 0x78
		private long fileSize; // 0x80
	
		// Properties
		public string path { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public byte[] bytes { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
	
		// Nested types
		private enum Phase // TypeDefIndex: 57839
		{
			Stop = 0,
			Bind = 1,
			Load = 2,
			Done = 3,
			Error = 4
		}
	
		// Constructors
		public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize); // 0x00000001868F4708-0x00000001868F4854
	
		// Methods
		protected override void Dispose(bool disposing); // 0x00000001868F4368-0x00000001868F43FC
		public override void Stop(); // 0x00000001868F44B0-0x00000001868F44DC
		public override void Update(); // 0x00000001868F46CC-0x00000001868F4708
		private void UpdateBinder(); // 0x00000001868F44DC-0x00000001868F4544
		private void UpdateLoader(); // 0x00000001868F4544-0x00000001868F46CC
		private void OnError(); // 0x00000001868F43FC-0x00000001868F44B0
	}

	public class CriFsLoadAssetBundleRequest : CriFsRequest // TypeDefIndex: 57841
	{
		// Fields
		[CompilerGenerated]
		private string _path_k__BackingField; // 0x40
		[CompilerGenerated]
		private AssetBundle _assetBundle_k__BackingField; // 0x48
		private CriFsLoadFileRequest loadFileReq; // 0x50
		private AssetBundleCreateRequest assetBundleReq; // 0x58
	
		// Properties
		public string path { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public AssetBundle assetBundle { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
	
		// Constructors
		public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize); // 0x00000001868F42C8-0x00000001868F4368
	
		// Methods
		public override void Update(); // 0x00000001868F41AC-0x00000001868F42C8
		protected override void Dispose(bool disposing); // 0x00000001868F4148-0x00000001868F41AC
	}

	public class CriFsInstallRequest : CriFsRequest // TypeDefIndex: 57842
	{
		// Fields
		[CompilerGenerated]
		private string _sourcePath_k__BackingField; // 0x40
		[CompilerGenerated]
		private string _destinationPath_k__BackingField; // 0x48
		[CompilerGenerated]
		private float _progress_k__BackingField; // 0x50
	
		// Properties
		public string sourcePath { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public string destinationPath { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public float progress { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
	
		// Constructors
		public CriFsInstallRequest(); // 0x00000001868F38FC-0x00000001868F3904
	}

	public class CriFsInstallRequestLegacy : CriFsInstallRequest // TypeDefIndex: 57843
	{
		// Fields
		private CriFsInstaller installer; // 0x58
	
		// Constructors
		public CriFsInstallRequestLegacy(CriFsBinder srcBinder, string srcPath, string dstPath, DoneDelegate doneDelegate, int installBufferSize); // 0x00000001868F37E8-0x00000001868F38FC
	
		// Methods
		public override void Stop(); // 0x00000001868F3718-0x00000001868F3740
		public override void Update(); // 0x00000001868F3740-0x00000001868F37E8
		protected override void Dispose(bool disposing); // 0x00000001868F36B4-0x00000001868F3718
	}

	public class CriFsWebInstallRequest : CriFsInstallRequest // TypeDefIndex: 57844
	{
		// Fields
		private CriFsWebInstaller installer; // 0x58
		private uint crc32; // 0x60
		private bool crc32_set; // 0x64
	
		// Constructors
		public CriFsWebInstallRequest(string srcPath, string dstPath, DoneDelegate doneDelegate); // 0x00000001868F6DCC-0x00000001868F6ED0
	
		// Methods
		public override void Stop(); // 0x00000001868F6C2C-0x00000001868F6C54
		public bool GetCRC32(out uint ret_val); // 0x0000000184D89000-0x0000000184D89010
		public override void Update(); // 0x00000001868F6C54-0x00000001868F6DCC
		protected override void Dispose(bool disposing); // 0x00000001868F6BC8-0x00000001868F6C2C
	}

	public class CriFsBindRequest : CriFsRequest // TypeDefIndex: 57846
	{
		// Fields
		[CompilerGenerated]
		private string _path_k__BackingField; // 0x40
		[CompilerGenerated]
		private uint _bindId_k__BackingField; // 0x48
	
		// Properties
		public string path { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public uint bindId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
	
		// Nested types
		public enum BindType // TypeDefIndex: 57845
		{
			Cpk = 0,
			Directory = 1,
			File = 2
		}
	
		// Constructors
		public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path); // 0x00000001868F1FAC-0x00000001868F20E4
	
		// Methods
		public override void Stop(); // 0x00000001841E1670-0x00000001841E1680
		public override void Update(); // 0x00000001868F1F48-0x00000001868F1FAC
		protected override void Dispose(bool disposing); // 0x00000001868F1EFC-0x00000001868F1F48
	}

	public static class CriFsUtility // TypeDefIndex: 57847
	{
		// Fields
		public const int DefaultReadUnitSize = 1048576; // Metadata: 0x0234BA04
	
		// Methods
		public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576 /* Metadata: 0x0234B9F0 */); // 0x00000001868F6B10-0x00000001868F6B5C
		public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576 /* Metadata: 0x0234B9F4 */); // 0x00000001868F6A64-0x00000001868F6AB8
		public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x0234B9F8 */); // 0x00000001868F6AB8-0x00000001868F6B10
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576 /* Metadata: 0x0234B9FC */); // 0x00000001868F6A54-0x00000001868F6A64
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x0234BA00 */); // 0x00000001868F6A00-0x00000001868F6A54
		public static CriFsInstallRequest Install(string srcPath, string dstPath); // 0x00000001868F6978-0x00000001868F699C
		public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate); // 0x00000001868F68FC-0x00000001868F6920
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath); // 0x00000001868F6920-0x00000001868F6978
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate); // 0x00000001868F699C-0x00000001868F6A00
		public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate); // 0x00000001868F6B74-0x00000001868F6BC8
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath); // 0x00000001868F6604-0x00000001868F6614
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath); // 0x00000001868F6614-0x00000001868F6668
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath); // 0x00000001868F6668-0x00000001868F66B0
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath); // 0x00000001868F66B0-0x00000001868F6704
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath); // 0x00000001868F6758-0x00000001868F67A0
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath); // 0x00000001868F6704-0x00000001868F6758
		public static void SetUserAgentString(string userAgentString); // 0x00000001868F6B6C-0x00000001868F6B74
		public static void SetProxyServer(string proxyPath, ushort proxyPort); // 0x00000001868F6B64-0x00000001868F6B6C
		public static void SetPathSeparator(string filter); // 0x00000001868F6B5C-0x00000001868F6B64
		private static extern bool CRIWARECD0DC04A(string userAgentString); // 0x00000001868F68A0-0x00000001868F68FC
		private static extern bool CRIWARE48E31D64(string proxyPath, ushort proxyPort); // 0x00000001868F67FC-0x00000001868F68A0
		private static extern bool CRIWARE0C80F382(string filter); // 0x00000001868F67A0-0x00000001868F67FC
	}

	public static class CriFsPlugin // TypeDefIndex: 57848
	{
		// Fields
		private static int initializationCount; // 0x00
		private static bool isConfigured; // 0x04
		public static int defaultInstallBufferSize; // 0x08
		public static int installBufferSize; // 0x0C
	
		// Properties
		public static bool isInitialized { get; } // 0x00000001868F5920-0x00000001868F5968 
	
		// Constructors
		static CriFsPlugin(); // 0x0000000184D34720-0x0000000184D347A0
	
		// Methods
		public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check); // 0x0000000183A080E0-0x0000000183A081A0
		public static void SetReadDeviceEnabled(int deviceId, bool enabled); // 0x00000001868F55EC-0x00000001868F5678
		public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps); // 0x00000001841E1670-0x00000001841E1680
		public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio); // 0x00000001841E1670-0x00000001841E1680
		public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio); // 0x00000001841E1670-0x00000001841E1680
		public static void InitializeLibrary(); // 0x0000000183A07B60-0x0000000183A07C50
		public static bool IsLibraryInitialized(); // 0x0000000183A07FC0-0x0000000183A08010
		public static void FinalizeLibrary(); // 0x00000001868F5504-0x00000001868F55EC
		private static extern void CRIWARE8451156E(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check); // 0x0000000183827280-0x0000000183827340
		private static extern void CRIWARE601ABE43(); // 0x0000000183A07C50-0x0000000183A07C80
		public static extern bool CRIWARE1012AF20(); // 0x0000000183A08010-0x0000000183A08050
		private static extern void CRIWARE74A6103A(); // 0x00000001868F54AC-0x00000001868F54D8
		public static extern uint CRIWARE785081A5(); // 0x00000001868F54D8-0x00000001868F5504
		public static extern uint criFsLoader_GetRetryCount(); // 0x00000001868F5678-0x00000001868F56E0
		public static extern int criFs_GetNumBinds(ref int cur, ref int max, ref int limit); // 0x00000001868F56E0-0x00000001868F5774
		public static extern int criFs_GetNumUsedLoaders(ref int cur, ref int max, ref int limit); // 0x00000001868F5808-0x00000001868F589C
		public static extern int criFs_GetNumUsedInstallers(ref int cur, ref int max, ref int limit); // 0x00000001868F5774-0x00000001868F5808
		private static extern int criFs_SetReadDeviceEnabled(int device_id, bool enabled); // 0x00000001868F589C-0x00000001868F5920
	}

	public class CriFsServer : CriMonoBehaviour // TypeDefIndex: 57849
	{
		// Fields
		private static CriFsServer _instance; // 0x00
		private List<CriFsRequest> requestList; // 0x28
		[CompilerGenerated]
		private int _installBufferSize_k__BackingField; // 0x30
	
		// Properties
		public static CriFsServer instance { get; } // 0x00000001868F65C4-0x00000001868F6604 
		public int installBufferSize { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
	
		// Constructors
		public CriFsServer(); // 0x00000001846D88E0-0x00000001846D88F0
	
		// Methods
		public static void CreateInstance(); // 0x00000001868F5EA8-0x00000001868F5F7C
		public static void DestroyInstance(); // 0x00000001868F60AC-0x00000001868F6138
		private void Awake(); // 0x00000001868F5B48-0x00000001868F5CB4
		private void OnDestroy(); // 0x00000001868F6348-0x00000001868F6510
		public override void CriInternalUpdate(); // 0x00000001868F5F7C-0x00000001868F60AC
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public void AddRequest(CriFsRequest request); // 0x00000001868F5AF4-0x00000001868F5B48
		public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize); // 0x00000001868F62A0-0x00000001868F6348
		public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize); // 0x00000001868F6200-0x00000001868F62A0
		public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate); // 0x00000001868F6138-0x00000001868F6200
		public CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate); // 0x00000001868F6510-0x00000001868F65C4
		public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path); // 0x00000001868F5CB4-0x00000001868F5D58
		public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path); // 0x00000001868F5D58-0x00000001868F5E00
		public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path); // 0x00000001868F5E00-0x00000001868F5EA8
	}

	public class CriFsWebInstaller : CriDisposable // TypeDefIndex: 57855
	{
		// Fields
		[CompilerGenerated]
		private static bool _isInitialized_k__BackingField; // 0x00
		[CompilerGenerated]
		private static bool _isCrcEnabled_k__BackingField; // 0x01
		public const int InvalidHttpStatusCode = -1; // Metadata: 0x0234BA08
		public const long InvalidContentsSize = -1; // Metadata: 0x0234BA09
		private IntPtr handle; // 0x20
	
		// Properties
		public static bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001868F79AC-0x00000001868F79E4 0x00000001868F7A20-0x00000001868F7A5C
		public static bool isCrcEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001868F7974-0x00000001868F79AC 0x00000001868F79E4-0x00000001868F7A20
		public static ModuleConfig defaultModuleConfig { get; } // 0x00000001868F791C-0x00000001868F7974 
	
		// Nested types
		public enum Status // TypeDefIndex: 57850
		{
			Stop = 0,
			Busy = 1,
			Complete = 2,
			Error = 3
		}
	
		public enum Error // TypeDefIndex: 57851
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
	
		public struct StatusInfo // TypeDefIndex: 57852
		{
			// Fields
			public Status status; // 0x00
			public Error error; // 0x04
			public int httpStatusCode; // 0x08
			public long contentsSize; // 0x10
			public long receivedSize; // 0x18
		}
	
		public struct ModuleConfig // TypeDefIndex: 57853
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
	
		public struct ModulePlatformConfig // TypeDefIndex: 57854
		{
			// Fields
			public byte reserved; // 0x00
	
			// Properties
			public static ModulePlatformConfig defaultConfig { get; } // 0x00000001812081B0-0x0000000181208610 
		}
	
		// Constructors
		public CriFsWebInstaller(); // 0x00000001868F73EC-0x00000001868F74A8
	
		// Methods
		~CriFsWebInstaller(); // 0x00000001868F709C-0x00000001868F7110
		public override void Dispose(); // 0x00000001868F6EDC-0x00000001868F6F2C
		public void Copy(string url, string dstPath); // 0x00000001868F6ED0-0x00000001868F6EDC
		public void Stop(); // 0x00000001868F73D8-0x00000001868F73EC
		public StatusInfo GetStatusInfo(); // 0x00000001868F7194-0x00000001868F71E4
		public bool GetCRC32(out uint ret_val); // 0x00000001868F7110-0x00000001868F712C
		public static void InitializeModule(ModuleConfig config); // 0x00000001868F71E4-0x00000001868F73C0
		private static System.Type GetCriFsWebInstallerCurlExpansionClass(); // 0x00000001868F712C-0x00000001868F7194
		public static void FinalizeModule(); // 0x00000001868F6FF4-0x00000001868F709C
		public static void ExecuteMain(); // 0x00000001868F6FEC-0x00000001868F6FF4
		public static bool SetRequestHeader(string field, string value); // 0x00000001868F73C0-0x00000001868F73D8
		private void Dispose(bool disposing); // 0x00000001868F6F2C-0x00000001868F6FEC
		private static extern int criFsWebInstaller_Initialize(in ModuleConfig config); // 0x00000001868F7780-0x00000001868F7828
		private static extern int criFsWebInstaller_Finalize(); // 0x00000001868F764C-0x00000001868F7678
		private static extern int criFsWebInstaller_ExecuteMain(); // 0x00000001868F7620-0x00000001868F764C
		private static extern int criFsWebInstaller_Create(out IntPtr installer); // 0x00000001868F7574-0x00000001868F75EC
		private static extern int criFsWebInstaller_Destroy(IntPtr installer); // 0x00000001868F75EC-0x00000001868F7620
		private static extern int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath); // 0x00000001868F74A8-0x00000001868F7574
		private static extern int criFsWebInstaller_Stop(IntPtr installer); // 0x00000001868F78E8-0x00000001868F791C
		private static extern int criFsWebInstaller_GetStatusInfo(IntPtr installer, out StatusInfo status); // 0x00000001868F76FC-0x00000001868F7780
		private static extern int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32); // 0x00000001868F7678-0x00000001868F76FC
		private static extern int criFsWebInstaller_SetRequestHeader(string field, string value); // 0x00000001868F7828-0x00000001868F78E8
	}

	public class CriManaPlugin // TypeDefIndex: 57856
	{
		// Fields
		private static int initializationCount; // 0x00
		private static bool isConfigured; // 0x04
		private static bool enabledMultithreadedRendering; // 0x05
		public static int renderingEventOffset; // 0x08
	
		// Properties
		public static bool isInitialized { get; } // 0x00000001868FCEB4-0x00000001868FCEFC 
		public static bool isMultithreadedRenderingEnabled { get; } // 0x00000001868FCEFC-0x00000001868FCF4C 
	
		// Constructors
		public CriManaPlugin(); // 0x00000001841E1670-0x00000001841E1680
		static CriManaPlugin(); // 0x0000000184D36030-0x0000000184D360B0
	
		// Methods
		public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries); // 0x0000000183A06D70-0x0000000183A06E40
		private static void SetupVp9(); // 0x0000000183A05CE0-0x0000000183A05DE0
		[Obsolete("Use CriWareVITA.EnableH264Playback and CriWareVITA.SetH264DecoderMaxSize instead.")]
		public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height); // 0x00000001841E1670-0x00000001841E1680
		public static void SetConfigAdditonalParameters_PC(bool use_h264_playback); // 0x0000000183A08050-0x0000000183A080A0
		public static void SetConfigAdditonalParameters_ANDROID(bool enable_buffer_output_for_h264, bool enable_buffer_output_for_vp9); // 0x00000001841E1670-0x00000001841E1680
		public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize); // 0x00000001841E1670-0x00000001841E1680
		public static void InitializeLibrary(); // 0x0000000183A06160-0x0000000183A062B0
		public static bool IsLibraryInitialized(); // 0x0000000183A06980-0x0000000183A069D0
		public static void FinalizeLibrary(); // 0x00000001868FCAC8-0x00000001868FCBF8
		public static bool IsCodecSupported(CodecType codecType); // 0x00000001868FCC38-0x00000001868FCD24
		private static System.Type GetVp9ExpansionClass(); // 0x0000000183A05ED0-0x0000000183A05F80
		private static bool IsVp9CodecSupported(); // 0x0000000183A05DE0-0x0000000183A05ED0
		private static bool IsH264CodecSupported(); // 0x0000000182FFF600-0x0000000182FFF610
		public static void SetDecodeThreadPriorityAndroidExperimental(int prio); // 0x00000001841E1670-0x00000001841E1680
		public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr); // 0x00000001812081B0-0x0000000181208610
		public static void Lock(); // 0x00000001868FCD24-0x00000001868FCD64
		public static void Unlock(); // 0x00000001868FCD64-0x00000001868FCDA4
		public static uint GetPrimeBufferAlignmentSize(); // 0x00000001868FCBF8-0x00000001868FCC38
		private static extern void CRIWARECFA78B41(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries); // 0x00000001838271E0-0x0000000183827280
		private static extern void CRIWARE7BFC56AA(); // 0x0000000183A062B0-0x0000000183A062E0
		public static extern bool CRIWARE611B78A5(); // 0x0000000183A069D0-0x0000000183A06A10
		private static extern void CRIWARED672C36F(); // 0x00000001868FCA9C-0x00000001868FCAC8
		public static extern void CRIWARE9F182D39(bool flag); // 0x00000001868FCA68-0x00000001868FCA9C
		public static extern void CRIWARE06C87176(); // 0x00000001868FC9E4-0x00000001868FCA10
		public static extern void CRIWARE46E1A37B(); // 0x00000001868FCA3C-0x00000001868FCA68
		private static extern uint criManaUnity_GetPrimeBufferAlignmentSize(); // 0x00000001868FCDA4-0x00000001868FCE0C
		public static extern void criMana_UseStreamerManager(bool flag); // 0x00000001868FCE3C-0x00000001868FCEB4
		public static extern bool criMana_IsStreamerManagerUsed(); // 0x00000001868FCE0C-0x00000001868FCE3C
		public static extern uint CRIWARE257CA763(); // 0x00000001868FCA10-0x00000001868FCA3C
		public static extern void CRIWARE62B7B053(bool enable); // 0x0000000183A080A0-0x0000000183A080E0
	}

	public class CriManaAmbisonicSource : CriMonoBehaviour // TypeDefIndex: 57857
	{
		// Fields
		private CriAtomEx3dSource atomEx3DsourceForAmbisonics; // 0x28
		private Vector3 ambisonicSourceOrientationFront; // 0x30
		private Vector3 ambisonicSourceOrientationTop; // 0x3C
		private Vector3 lastEulerOfAmbisonicSource; // 0x48
	
		// Constructors
		public CriManaAmbisonicSource(); // 0x00000001846D88E0-0x00000001846D88F0
	
		// Methods
		public override void CriInternalUpdate(); // 0x00000001868F7A5C-0x00000001868F7A64
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnEnable(); // 0x00000001868F7B0C-0x00000001868F7BF0
		private void ForceUpdateAmbisonicSourceOrientation(); // 0x00000001868F7A64-0x00000001868F7B0C
		private void UpdateAmbisonicSourceOrientation(); // 0x00000001868F7FFC-0x00000001868F809C
		private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler); // 0x00000001868F7BF0-0x00000001868F7FFC
	}

	[AddComponentMenu("CRIWARE/CriManaMovieController")]
	public class CriManaMovieController : CriManaMovieMaterial // TypeDefIndex: 57858
	{
		// Fields
		public Renderer target; // 0x98
		public bool useOriginalMaterial; // 0xA0
		private Material originalMaterial; // 0xA8
	
		// Constructors
		public CriManaMovieController(); // 0x00000001868FB434-0x00000001868FB43C
	
		// Methods
		public override void CriInternalUpdate(); // 0x00000001868FB43C-0x00000001868FB4DC
		public override bool RenderTargetManualSetup(); // 0x00000001868FB64C-0x00000001868FB78C
		public override void RenderTargetManualFinalize(); // 0x00000001868FB5A0-0x00000001868FB64C
		protected override void OnMaterialAvailableChanged(); // 0x00000001868FB4DC-0x00000001868FB5A0
	}

	[AddComponentMenu("CRIWARE/CriManaMovieControllerForUI")]
	public class CriManaMovieControllerForUI : CriManaMovieMaterial // TypeDefIndex: 57859
	{
		// Fields
		public Graphic target; // 0x98
		public bool useOriginalMaterial; // 0xA0
		private Material originalMaterial; // 0xA8
	
		// Constructors
		public CriManaMovieControllerForUI(); // 0x00000001868FB434-0x00000001868FB43C
	
		// Methods
		protected override void Awake(); // 0x00000001868FB0B0-0x00000001868FB0D4
		public override void CriInternalUpdate(); // 0x00000001868FB0D4-0x00000001868FB178
		public override bool RenderTargetManualSetup(); // 0x00000001868FB2F0-0x00000001868FB434
		public override void RenderTargetManualFinalize(); // 0x00000001868FB240-0x00000001868FB2F0
		protected override void OnMaterialAvailableChanged(); // 0x00000001868FB178-0x00000001868FB240
	}

	[AddComponentMenu("CRIWARE/CriManaMovieMaterial")]
	public class CriManaMovieMaterial : CriManaMovieMaterialBase // TypeDefIndex: 57860
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
		public string moviePath { get; set; } // 0x0000000184D86260-0x0000000184D86270 0x00000001868FC848-0x00000001868FC8C0
		public bool loop { get; set; } // 0x00000001811F2750-0x00000001811F2760 0x00000001868FC7DC-0x00000001868FC848
		public bool advancedAudio { get; set; } // 0x0000000184D89070-0x0000000184D89080 0x00000001868FC274-0x00000001868FC2F4
		public bool ambisonics { get; set; } // 0x0000000184D89080-0x0000000184D89090 0x00000001868FC2F4-0x00000001868FC770
		public bool additiveMode { get; set; } // 0x0000000184D89060-0x0000000184D89070 0x00000001868FC208-0x00000001868FC274
		public bool useMaterialBlendMode { get; set; } // 0x0000000184D890B0-0x0000000184D890C0 0x00000001868FC92C-0x00000001868FC998
		public bool applyTargetAlpha { get; set; } // 0x0000000184D89090-0x0000000184D890A0 0x00000001868FC770-0x00000001868FC7DC
		public bool uiRenderMode { get; set; } // 0x0000000184D890A0-0x0000000184D890B0 0x00000001868FC8C0-0x00000001868FC92C
		protected override uint FilePathLength { get; } // 0x00000001868FC1B8-0x00000001868FC208 
		protected override bool initializeWithAdvancedAudio { get; } // 0x0000000184D89070-0x0000000184D89080 
		protected override bool initializeWithAmbisonics { get; } // 0x0000000184D89080-0x0000000184D89090 
	
		// Constructors
		public CriManaMovieMaterial(); // 0x00000001868FB434-0x00000001868FB43C
	
		// Methods
		protected override void SetDataToPlayer(); // 0x00000001868FC0F4-0x00000001868FC1B8
	}

	public abstract class CriManaMovieMaterialBase : CriMonoBehaviour // TypeDefIndex: 57866
	{
		// Fields
		public bool playOnStart; // 0x28
		public bool restartOnEnable; // 0x29
		[CompilerGenerated]
		private bool _isMaterialAvailable_k__BackingField; // 0x2A
		[CompilerGenerated]
		private Player _player_k__BackingField; // 0x30
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
		[CompilerGenerated]
		private bool _HaveRendererOwner_k__BackingField; // 0x71
		private CriManaMoviePlayerHolder playerHolder; // 0x78
	
		// Properties
		public MaxFrameDrop maxFrameDrop { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x00000001868FC0BC-0x00000001868FC0D4
		protected abstract bool initializeWithAdvancedAudio { get; }
		protected abstract bool initializeWithAmbisonics { get; }
		public bool isMaterialAvailable { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86CA0-0x0000000184D86CB0 0x0000000184D86CD0-0x0000000184D86CE0
		public Player player { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public Material material { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x00000001868FC024-0x00000001868FC0BC
		public Player.TimerType timerType { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x00000001868FC0D4-0x00000001868FC0F4
		protected abstract uint FilePathLength { get; }
		protected bool HaveRendererOwner { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D89040-0x0000000184D89050 0x0000000184D89050-0x0000000184D89060
	
		// Nested types
		public enum MaxFrameDrop // TypeDefIndex: 57861
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
	
		public enum RenderMode // TypeDefIndex: 57862
		{
			Always = 0,
			OnVisibility = 1,
			Never = 2
		}
	
		public delegate void OnApplicationPauseCallback(CriManaMovieMaterialBase manaMovieMaterial, bool appPause); // TypeDefIndex: 57863; 0x00000001838E1420-0x00000001838E1430
	
		[CompilerGenerated]
		private struct _AsyncDispose_d__53 : IAsyncStateMachine // TypeDefIndex: 57864
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public Player player; // 0x28
			private TaskAwaiter __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001868FEC94-0x00000001868FEE14
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001853982D4-0x00000001853982E0
		}
	
		[CompilerGenerated]
		private sealed class _RestartPlayerRoutine_d__60 : IEnumerator<object> // TypeDefIndex: 57865
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriManaMovieMaterialBase __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _RestartPlayerRoutine_d__60(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001868FEEA8-0x00000001868FEF90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001868FEF90-0x00000001868FEFDC
		}
	
		// Constructors
		protected CriManaMovieMaterialBase(); // 0x00000001868FBFC4-0x00000001868FC024
	
		// Methods
		protected abstract void SetDataToPlayer();
		public void Play(); // 0x00000001868FBA6C-0x00000001868FBAA0
		public void Stop(); // 0x00000001868FBF8C-0x00000001868FBFC4
		public void Pause(bool sw); // 0x00000001868FBA38-0x00000001868FBA6C
		protected virtual void OnMaterialAvailableChanged(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnMaterialUpdated(); // 0x00000001841E1670-0x00000001841E1680
		public void PlayerManualInitialize(); // 0x00000001868FBAE0-0x00000001868FBC80
		public void PlayerManualFinalize(); // 0x00000001868FBAA0-0x00000001868FBAE0
		private async void AsyncDispose(Player player); // 0x00000001868FB78C-0x00000001868FB82C
		public void PlayerManualSetup(); // 0x00000001868FBC80-0x00000001868FBD34
		public virtual bool RenderTargetManualSetup(); // 0x0000000182FFF600-0x0000000182FFF610
		public virtual void RenderTargetManualFinalize(); // 0x00000001841E1670-0x00000001841E1680
		public void PlayerManualUpdate(); // 0x00000001868FBD34-0x00000001868FBE0C
		protected virtual void Awake(); // 0x00000001868FB82C-0x00000001868FB834
		protected override void OnEnable(); // 0x00000001868FB9A8-0x00000001868FBA08
		[IteratorStateMachine(typeof(_RestartPlayerRoutine_d__60))]
		private IEnumerator RestartPlayerRoutine(); // 0x00000001868FBED0-0x00000001868FBF2C
		protected override void OnDisable(); // 0x00000001868FB954-0x00000001868FB9A8
		protected virtual void OnDestroy(); // 0x00000001868FB92C-0x00000001868FB954
		protected virtual void Start(); // 0x00000001868FBF2C-0x00000001868FBF8C
		public override void CriInternalUpdate(); // 0x00000001868FB91C-0x00000001868FB924
		public virtual void RenderMovie(); // 0x00000001868FBEA8-0x00000001868FBED0
		public override void CriInternalLateUpdate(); // 0x00000001868FB8EC-0x00000001868FB91C
		protected virtual void OnWillRenderObject(); // 0x00000001868FBA08-0x00000001868FBA38
		private void OnApplicationPause(bool appPause); // 0x00000001868FB924-0x00000001868FB92C
		private void ProcessApplicationPause(bool appPause); // 0x00000001868FBE0C-0x00000001868FBEA8
		private void CreateMaterial(); // 0x00000001868FB834-0x00000001868FB8EC
	}

	public class CriManaMoviePlayerHolder : CriMonoBehaviour // TypeDefIndex: 57867
	{
		// Fields
		private Player _player; // 0x28
	
		// Properties
		public Player player { set; } // 0x0000000182FDB880-0x0000000182FDB890
	
		// Constructors
		public CriManaMoviePlayerHolder(); // 0x00000001846D88E0-0x00000001846D88F0
	
		// Methods
		private void Awake(); // 0x00000001868FC998-0x00000001868FC9E4
		public override void CriInternalUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
		private void Start(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class Common // TypeDefIndex: 57869
	{
		// Fields
		private const string scriptVersionString = "1.0.6(2.40.31_PS5SDKUpdate)"; // Metadata: 0x0234BA2D
		public const bool supportsCriFsInstaller = true; // Metadata: 0x0234BA49
		public const bool supportsCriFsWebInstaller = true; // Metadata: 0x0234BA4A
		public const string pluginName = "cri_ware_unity"; // Metadata: 0x0234BA4B
		public const CallingConvention pluginCallingConvention = CallingConvention.Cdecl; // Metadata: 0x0234BA5A
		private static GameObject _managerObject; // 0x00
	
		// Properties
		public static string streamingAssetsPath { get; } // 0x0000000183828730-0x0000000183828780 
		public static string installTargetPath { get; } // 0x00000001868EA730-0x00000001868EA738 
		public static string installCachePath { get; } // 0x00000001868EA708-0x00000001868EA730 
		public static GameObject managerObject { get; } // 0x0000000183A078A0-0x0000000183A07A80 
	
		// Nested types
		public struct CpuUsage // TypeDefIndex: 57868
		{
			// Fields
			public float last; // 0x00
			public float average; // 0x04
			public float peak; // 0x08
		}
	
		// Constructors
		public Common(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool IsStreamingAssetsPath(string path); // 0x0000000184D231A0-0x0000000184D23220
		public static string GetScriptVersionString(); // 0x00000001868EA6DC-0x00000001868EA708
		public static int GetBinaryVersionNumber(); // 0x0000000185394810-0x0000000185394818
		public static int GetRequiredBinaryVersionNumber(); // 0x0000000184D88FD0-0x0000000184D88FE0
		public static bool CheckBinaryVersionCompatibility(); // 0x0000000183A09410-0x0000000183A09460
		public static uint GetFsMemoryUsage(); // 0x00000001868EA65C-0x00000001868EA69C
		public static uint GetAtomMemoryUsage(); // 0x00000001868EA61C-0x00000001868EA65C
		public static uint GetManaMemoryUsage(); // 0x00000001868EA69C-0x00000001868EA6DC
		public static CpuUsage GetAtomCpuUsage(); // 0x00000001868EA5C8-0x00000001868EA61C
		public static extern int CRIWAREC8077C29(); // 0x0000000184D30EE0-0x0000000184D30F10
		public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset); // 0x0000000183827CD0-0x0000000183827D50
	}

	public static class CriWareDecrypter // TypeDefIndex: 57871
	{
		// Fields
		private static ulong temporalStorage; // 0x00
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 57870; 0x00000001814E2060-0x00000001814E2070
	
		// Methods
		public static bool Initialize(CriWareDecrypterConfig config); // 0x00000001868FD118-0x00000001868FD148
		public static bool Initialize(string key, string authenticationFile, bool enableAtomDecryption, bool enableManaDecryption); // 0x0000000183828430-0x00000001838285F0
		[AOT.MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
		private static ulong CallbackFromNative(IntPtr ptr1); // 0x00000001868FD0E0-0x00000001868FD118
		public static extern int CRIWARE05CA8EB2(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj); // 0x0000000183827130-0x00000001838271E0
	}

	[AddComponentMenu("CRIWARE/Error Handler")]
	public class CriWareErrorHandler : CriMonoBehaviour // TypeDefIndex: 57873
	{
		// Fields
		public bool enableDebugPrintOnTerminal; // 0x28
		public bool enableForceCrashOnError; // 0x29
		public bool dontDestroyOnLoad; // 0x2A
		[CompilerGenerated]
		private static string _errorMessage_k__BackingField; // 0x00
		public static readonly string logPrefix; // 0x08
		[CompilerGenerated]
		private static Callback OnCallback; // 0x10
		[Obsolete("CriWareErrorHandler.callback is deprecated. Use CriWareErrorHandler.OnCallback event", false)]
		public static Callback callback; // 0x18
		public uint messageBufferCounts; // 0x2C
		private ConcurrentQueue<string> unThreadSafeMessages; // 0x30
		private static int initializationCount; // 0x20
	
		// Properties
		public static string errorMessage { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001868FDC00-0x00000001868FDC50 0x00000001868FDD24-0x00000001868FDD80
	
		// Events
		public static event Callback OnCallback {
			add; // 0x00000001868FDB2C-0x00000001868FDC00
			remove; // 0x00000001868FDC50-0x00000001868FDD24
		}
	
		// Nested types
		public delegate void Callback(string message); // TypeDefIndex: 57872; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public CriWareErrorHandler(); // 0x00000001868FDAA0-0x00000001868FDB2C
		static CriWareErrorHandler(); // 0x00000001868FD9D8-0x00000001868FDAA0
	
		// Methods
		private void Awake(); // 0x00000001868FD148-0x00000001868FD2C4
		protected override void OnEnable(); // 0x00000001868FD6C4-0x00000001868FD7A4
		protected override void OnDisable(); // 0x00000001868FD5E4-0x00000001868FD6C4
		public override void CriInternalUpdate(); // 0x00000001868FD2C4-0x00000001868FD2CC
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDestroy(); // 0x00000001868FD4C8-0x00000001868FD5E4
		private void DequeueErrorMessages(); // 0x00000001868FD2CC-0x00000001868FD404
		private void HandleMessage(string errmsg); // 0x00000001868FD404-0x00000001868FD4C8
		private static void OutputDefaultLog(string errmsg); // 0x00000001868FD7A4-0x00000001868FD9D8
	}

	public static class CriErrorNotifier // TypeDefIndex: 57877
	{
		// Fields
		[CompilerGenerated]
		private static Callback _onCallbackThreadUnsafe; // 0x00
		private static object objectLock; // 0x08
	
		// Events
		private static event Callback _onCallbackThreadUnsafe {
			add; // 0x00000001868F1C20-0x00000001868F1CEC
			remove; // 0x00000001868F1E30-0x00000001868F1EFC
		}
		public static event Callback OnCallbackThreadUnsafe {
			add; // 0x00000001868F1A70-0x00000001868F1C20
			remove; // 0x00000001868F1CEC-0x00000001868F1E30
		}
	
		// Nested types
		public delegate void Callback(string message); // TypeDefIndex: 57874; 0x0000000182B46B90-0x0000000182B46BA0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void ErrorCallbackFunc(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray); // TypeDefIndex: 57875; 0x00000001815547C0-0x00000001815547E0
	
		public static class NativeMethod // TypeDefIndex: 57876
		{
			// Methods
			internal static extern void criErr_SetCallback(ErrorCallbackFunc callback); // 0x00000001868FE85C-0x00000001868FE8DC
			internal static extern IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2); // 0x00000001868FE7C8-0x00000001868FE85C
		}
	
		// Constructors
		static CriErrorNotifier(); // 0x00000001868F19D8-0x00000001868F1A70
	
		// Methods
		public static bool IsRegistered(Callback target); // 0x00000001868F18F8-0x00000001868F19D8
		public static void CallEvent(string message); // 0x00000001868F17EC-0x00000001868F1868
		[AOT.MonoPInvokeCallback(typeof(ErrorCallbackFunc))]
		private static void ErrorCallbackFromNative(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray); // 0x00000001868F1868-0x00000001868F18F8
	}

	[Serializable]
	public class CriFsConfig // TypeDefIndex: 57878
	{
		// Fields
		public const int defaultAndroidDeviceReadBitrate = 50000000; // Metadata: 0x0234BA5B
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
		public CriFsConfig(); // 0x00000001846D8B10-0x00000001846D8BC0
	}

	[Serializable]
	public class CriAtomConfig // TypeDefIndex: 57894
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
		public class StandardVoicePoolConfig // TypeDefIndex: 57879
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public StandardVoicePoolConfig(); // 0x0000000184D89120-0x0000000184D89130
		}
	
		[Serializable]
		public class HcaMxVoicePoolConfig // TypeDefIndex: 57880
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public HcaMxVoicePoolConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public enum InGamePreviewSwitchMode // TypeDefIndex: 57881
		{
			Disable = 0,
			Enable = 1,
			FollowBuildSetting = 2,
			Default = 3
		}
	
		[Serializable]
		public class InGamePreviewConfig // TypeDefIndex: 57882
		{
			// Fields
			public int maxPreviewObjects; // 0x10
			public int communicationBufferSize; // 0x14
			public int playbackPositionUpdateInterval; // 0x18
	
			// Constructors
			public InGamePreviewConfig(); // 0x0000000184D890F0-0x0000000184D89110
		}
	
		[Serializable]
		public class EditorPcmOutputConfig // TypeDefIndex: 57883
		{
			// Fields
			public bool enable; // 0x10
			public int bufferLength; // 0x14
	
			// Constructors
			public EditorPcmOutputConfig(); // 0x0000000184D890E0-0x0000000184D890F0
		}
	
		public enum LinuxOutput // TypeDefIndex: 57884
		{
			Default = 0,
			PulseAudio = 1,
			ALSA = 2
		}
	
		[Serializable]
		public class AndroidLowLatencyStandardVoicePoolConfig // TypeDefIndex: 57885
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public AndroidLowLatencyStandardVoicePoolConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class VitaManaVoicePoolConfig // TypeDefIndex: 57886
		{
			// Fields
			public int numberOfManaDecoders; // 0x10
	
			// Constructors
			public VitaManaVoicePoolConfig(); // 0x0000000184D89140-0x0000000184D89150
		}
	
		[Serializable]
		public class VitaAtrac9VoicePoolConfig // TypeDefIndex: 57887
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public VitaAtrac9VoicePoolConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class Ps4Atrac9VoicePoolConfig // TypeDefIndex: 57888
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public Ps4Atrac9VoicePoolConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class Ps5PortConfig // TypeDefIndex: 57889
		{
			// Fields
			public int maxChannelPorts; // 0x10
			public int maxObjectPorts; // 0x14
	
			// Constructors
			public Ps5PortConfig(); // 0x0000000184D89110-0x0000000184D89120
		}
	
		[Serializable]
		public class SwitchOpusVoicePoolConfig // TypeDefIndex: 57890
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public SwitchOpusVoicePoolConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class Ps4Audio3dConfig // TypeDefIndex: 57892
		{
			// Fields
			public bool useAudio3D; // 0x10
			public VoicePoolConfig voicePoolConfig; // 0x18
	
			// Nested types
			[Serializable]
			public class VoicePoolConfig // TypeDefIndex: 57891
			{
				// Fields
				public int memoryVoices; // 0x10
				public int streamingVoices; // 0x14
	
				// Constructors
				public VoicePoolConfig(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public Ps4Audio3dConfig(); // 0x00000001846D9090-0x00000001846D90E0
		}
	
		[Serializable]
		public class WebGLWebAudioVoicePoolConfig // TypeDefIndex: 57893
		{
			// Fields
			public int voices; // 0x10
	
			// Constructors
			public WebGLWebAudioVoicePoolConfig(); // 0x0000000184D89150-0x0000000184D89160
		}
	
		// Constructors
		public CriAtomConfig(); // 0x00000001846D8CF0-0x00000001846D9090
	}

	[Serializable]
	public class CriManaConfig // TypeDefIndex: 57898
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
		public class PCH264PlaybackConfig // TypeDefIndex: 57895
		{
			// Fields
			public bool useH264Playback; // 0x10
	
			// Constructors
			public PCH264PlaybackConfig(); // 0x00000001815EFCD0-0x00000001815EFCE0
		}
	
		[Serializable]
		public class VitaH264PlaybackConfig // TypeDefIndex: 57896
		{
			// Fields
			public bool useH264Playback; // 0x10
			public int maxWidth; // 0x14
			public int maxHeight; // 0x18
			public bool getMemoryFromTexture; // 0x1C
	
			// Constructors
			public VitaH264PlaybackConfig(); // 0x0000000184D89130-0x0000000184D89140
		}
	
		[Serializable]
		public class WebGLConfig // TypeDefIndex: 57897
		{
			// Fields
			public string webworkerPath; // 0x10
			public int heapSize; // 0x18
	
			// Constructors
			public WebGLConfig(); // 0x00000001846D8CA0-0x00000001846D8CF0
		}
	
		// Constructors
		public CriManaConfig(); // 0x00000001846D8BC0-0x00000001846D8CA0
	}

	[Serializable]
	public class CriWareDecrypterConfig // TypeDefIndex: 57899
	{
		// Fields
		public string key; // 0x10
		public string authenticationFile; // 0x18
		public bool enableAtomDecryption; // 0x20
		public bool enableManaDecryption; // 0x21
	
		// Constructors
		public CriWareDecrypterConfig(); // 0x00000001846D8A20-0x00000001846D8A80
	}

	[AddComponentMenu("CRIWARE/Library Initializer")]
	public class CriWareInitializer : CriMonoBehaviour // TypeDefIndex: 57900
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
		public CriWareInitializer(); // 0x00000001846D88F0-0x00000001846D8A20
	
		// Methods
		private void Awake(); // 0x0000000183A08340-0x0000000183A08360
		protected override void OnEnable(); // 0x0000000183A06E40-0x0000000183A06E50
		private void Start(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDestroy(); // 0x00000001868FDE00-0x00000001868FDE08
		public override void CriInternalUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public override void CriInternalLateUpdate(); // 0x00000001841E1670-0x00000001841E1680
		public void Initialize(); // 0x0000000183A07DD0-0x0000000183A07FC0
		public void Shutdown(); // 0x00000001868FDE08-0x00000001868FDED8
		public static bool IsInitialized(); // 0x0000000183A093C0-0x0000000183A09410
		public static void AddAudioEffectInterface(IntPtr effect_interface); // 0x00000001868FDD80-0x00000001868FDDF8
		public static bool InitializeFileSystem(CriFsConfig config); // 0x0000000183A07C80-0x0000000183A07DD0
		public static bool InitializeAtom(CriAtomConfig config); // 0x0000000183A062E0-0x0000000183A06790
		public static bool InitializeMana(CriManaConfig config); // 0x0000000183A06820-0x0000000183A06940
		[Obsolete("Use CriWareDecypter.Initialize")]
		public static bool InitializeDecrypter(CriWareDecrypterConfig config); // 0x00000001868FDDF8-0x00000001868FDE00
	}

	public static class CriAtomExDebug // TypeDefIndex: 57902
	{
		// Nested types
		public struct ResourcesInfo // TypeDefIndex: 57901
		{
			// Fields
			public CriAtomEx.ResourceUsage virtualVoiceUsage; // 0x00
			public CriAtomEx.ResourceUsage sequenceUsage; // 0x08
			public CriAtomEx.ResourceUsage sequenceTrackUsage; // 0x10
			public CriAtomEx.ResourceUsage sequenceTrackItemUsage; // 0x18
		}
	
		// Methods
		public static void GetResourcesInfo(out ResourcesInfo resourcesInfo); // 0x00000001868EB438-0x00000001868EB440
		private static extern void criAtomExDebug_GetResourcesInfo(out ResourcesInfo resourcesInfo); // 0x00000001868EB440-0x00000001868EB4B8
	}

	public static class CriAtomExAcfDebug // TypeDefIndex: 57916
	{
		// Nested types
		public struct CategoryInfo // TypeDefIndex: 57903
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public string name; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
		}
	
		public struct DspBusInfo // TypeDefIndex: 57904
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
	
		public struct AisacControlInfo // TypeDefIndex: 57905
		{
			// Fields
			public string name; // 0x00
			public uint id; // 0x08
		}
	
		public enum AisacType // TypeDefIndex: 57906
		{
			Normal = 0,
			AutoModulation = 1
		}
	
		public struct GlobalAisacInfo // TypeDefIndex: 57907
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numGraphs; // 0x0A
			public AisacType type; // 0x0C
			public float randomRange; // 0x10
			public ushort controlId; // 0x14
		}
	
		public struct SelectorInfo // TypeDefIndex: 57908
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
		}
	
		public struct SelectorLabelInfo // TypeDefIndex: 57909
		{
			// Fields
			public string selectorName; // 0x00
			public string labelName; // 0x08
		}
	
		private struct CategoryInfoForMarshaling // TypeDefIndex: 57910
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public IntPtr namePtr; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
	
			// Methods
			public void Convert(out CategoryInfo x); // 0x00000001868EA57C-0x00000001868EA5C8
		}
	
		private struct DspBusInfoForMarshaling // TypeDefIndex: 57911
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
			public void Convert(out DspBusInfo x); // 0x00000001868FE1D0-0x00000001868FE258
		}
	
		private struct AisacControlInfoForMarshaling // TypeDefIndex: 57912
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public uint id; // 0x08
	
			// Methods
			public void Convert(out AisacControlInfo x); // 0x00000001868EA4CC-0x00000001868EA504
		}
	
		private struct GlobalAisacInfoForMarshaling // TypeDefIndex: 57913
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
			public void Convert(out GlobalAisacInfo x); // 0x00000001868FE3DC-0x00000001868FE434
		}
	
		private struct SelectorInfoForMarshaling // TypeDefIndex: 57914
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
	
			// Methods
			public void Convert(out SelectorInfo x); // 0x00000001868FEC00-0x00000001868FEC4C
		}
	
		private struct SelectorLabelInfoForMarshaling // TypeDefIndex: 57915
		{
			// Fields
			public IntPtr selectorNamePtr; // 0x00
			public IntPtr labelNamePtr; // 0x08
	
			// Methods
			public void Convert(out SelectorLabelInfo x); // 0x00000001868FEC4C-0x00000001868FEC94
		}
	
		// Methods
		public static int GetNumCategories(); // 0x00000001868EAB7C-0x00000001868EAB84
		public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo); // 0x00000001868EA9E4-0x00000001868EAA30
		public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo); // 0x00000001868EAA30-0x00000001868EAA7C
		public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo); // 0x00000001868EA998-0x00000001868EA9E4
		public static int GetNumBuses(); // 0x00000001868EAB74-0x00000001868EAB7C
		public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo); // 0x00000001868EAA7C-0x00000001868EAAD4
		public static int GetNumAisacControls(); // 0x00000001868EAB6C-0x00000001868EAB74
		public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info); // 0x00000001868EA938-0x00000001868EA97C
		public static uint GetAisacControlIdByName(string name); // 0x00000001868EA930-0x00000001868EA938
		public static string GetAisacControlNameById(uint id); // 0x00000001868EA97C-0x00000001868EA998
		public static int GetNumGlobalAisacs(); // 0x00000001868EAB84-0x00000001868EAB8C
		public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info); // 0x00000001868EAB20-0x00000001868EAB6C
		public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info); // 0x00000001868EAAD4-0x00000001868EAB20
		public static int GetNumSelectors(); // 0x00000001868EAB8C-0x00000001868EAB94
		public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info); // 0x00000001868EAB94-0x00000001868EABD8
		public static bool GetSelectorInfoByName(string name, out SelectorInfo info); // 0x00000001868EABD8-0x00000001868EAC1C
		public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo); // 0x00000001868EAC1C-0x00000001868EAC80
		private static extern int criAtomExAcf_GetNumCategories(); // 0x00000001868EB208-0x00000001868EB234
		private static extern int criAtomExAcf_GetCategoryInfo(ushort index, out CategoryInfoForMarshaling categoryInfo); // 0x00000001868EAEF8-0x00000001868EAF7C
		private static extern int criAtomExAcf_GetCategoryInfoByName(string name, out CategoryInfoForMarshaling categoryInfo); // 0x00000001868EAE54-0x00000001868EAEF8
		private static extern int criAtomExAcf_GetCategoryInfoById(uint id, out CategoryInfoForMarshaling categoryInfo); // 0x00000001868EADD0-0x00000001868EAE54
		private static extern int criAtomExAcf_GetNumBuses(); // 0x00000001868EB1DC-0x00000001868EB208
		private static extern int criAtomExAcf_GetDspBusInformation(ushort index, out DspBusInfoForMarshaling dspBusInfo); // 0x00000001868EAF7C-0x00000001868EB090
		private static extern int criAtomExAcf_GetNumAisacControls(); // 0x00000001868EB1B8-0x00000001868EB1DC
		private static extern int criAtomExAcf_GetAisacControlInfo(ushort index, out AisacControlInfoForMarshaling info); // 0x00000001868EACD4-0x00000001868EAD58
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x00000001868EAC80-0x00000001868EACD4
		private static extern IntPtr criAtomExAcf_GetAisacControlNameById(uint id); // 0x00000001868EAD58-0x00000001868EADD0
		private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x00000001868EB234-0x00000001868EB258
		private static extern int criAtomExAcf_GetGlobalAisacInfo(ushort index, out GlobalAisacInfoForMarshaling info); // 0x00000001868EB134-0x00000001868EB1B8
		private static extern int criAtomExAcf_GetGlobalAisacInfoByName(string name, out GlobalAisacInfoForMarshaling info); // 0x00000001868EB090-0x00000001868EB134
		private static extern int criAtomExAcf_GetNumSelectors(); // 0x00000001868EB258-0x00000001868EB27C
		private static extern int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out SelectorInfoForMarshaling info); // 0x00000001868EB27C-0x00000001868EB300
		private static extern int criAtomExAcf_GetSelectorInfoByName(string name, out SelectorInfoForMarshaling info); // 0x00000001868EB300-0x00000001868EB3A4
		private static extern int criAtomExAcf_GetSelectorLabelInfo(ref SelectorInfoForMarshaling info, ushort labelIndex, out SelectorLabelInfoForMarshaling label_info); // 0x00000001868EB3A4-0x00000001868EB438
	}

	public static class CriAtomExAcbDebug // TypeDefIndex: 57919
	{
		// Nested types
		public struct AcbInfo // TypeDefIndex: 57917
		{
			// Fields
			public string name; // 0x00
			public uint size; // 0x08
			public uint version; // 0x0C
			public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
			public float volume; // 0x14
			public int numCues; // 0x18
		}
	
		private struct AcbInfoForMarshaling // TypeDefIndex: 57918
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public uint size; // 0x08
			public uint version; // 0x0C
			public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
			public float volume; // 0x14
			public int numCues; // 0x18
	
			// Methods
			public void Convert(out AcbInfo x); // 0x00000001868EA47C-0x00000001868EA4CC
		}
	
		// Methods
		public static bool GetAcbInfo(CriAtomExAcb acb, out AcbInfo acbInfo); // 0x00000001868EA850-0x00000001868EA8AC
		private static extern int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out AcbInfoForMarshaling acbInfo); // 0x00000001868EA8AC-0x00000001868EA930
	}

	public static class CriAtomExPlaybackDebug // TypeDefIndex: 57920
	{
		// Methods
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value); // 0x00000001868EB500-0x00000001868EB518
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value); // 0x00000001868EB518-0x00000001868EB530
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value); // 0x00000001868EB4E8-0x00000001868EB500
		public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value); // 0x00000001868EB4B8-0x00000001868EB4D0
		public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value); // 0x00000001868EB4D0-0x00000001868EB4E8
		private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value); // 0x00000001868EB670-0x00000001868EB700
		private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value); // 0x00000001868EB790-0x00000001868EB820
		private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value); // 0x00000001868EB700-0x00000001868EB790
		private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value); // 0x00000001868EB530-0x00000001868EB5C0
		private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value); // 0x00000001868EB5C0-0x00000001868EB670
	}

	public abstract class CriDisposable : IDisposable // TypeDefIndex: 57921
	{
		// Fields
		public Guid guid; // 0x10
	
		// Constructors
		public CriDisposable(); // 0x0000000184D80980-0x0000000184D809F0
	
		// Methods
		public abstract void Dispose();
	}

	public static class CriDisposableObjectManager // TypeDefIndex: 57924
	{
		// Fields
		private static List<ObjectRef> refList; // 0x00
	
		// Nested types
		public enum ModuleType // TypeDefIndex: 57922
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
	
		public struct ObjectRef // TypeDefIndex: 57923
		{
			// Fields
			public Guid guid; // 0x00
			public ModuleType type; // 0x10
			public CriDisposable disposable; // 0x18
	
			// Constructors
			public ObjectRef(Guid _guid, CriDisposable _disposable, ModuleType _type); // 0x0000000185397DE4-0x0000000185397DFC
		}
	
		// Constructors
		static CriDisposableObjectManager(); // 0x0000000184D18600-0x0000000184D18690
	
		// Methods
		private static int SearchForDisposable(CriDisposable disposable); // 0x00000001848DF4D0-0x00000001848DF790
		public static void Register(CriDisposable disposable, ModuleType type); // 0x00000001848DF120-0x00000001848DF4D0
		public static bool Unregister(CriDisposable disposable); // 0x00000001868F16A8-0x00000001868F17EC
		public static bool IsDisposed(CriDisposable disposable); // 0x00000001868F1664-0x00000001868F16A8
		public static void CallOnModuleFinalization(ModuleType type); // 0x00000001868F12B8-0x00000001868F1300
		private static int GetNextWithType(ModuleType type); // 0x00000001868F159C-0x00000001868F1664
		public static void DisposeAll(ModuleType type); // 0x00000001868F1300-0x00000001868F159C
	}

	public abstract class CriMonoBehaviour : MonoBehaviour // TypeDefIndex: 57925
	{
		// Fields
		[CompilerGenerated]
		private Guid _guid_k__BackingField; // 0x18
	
		// Properties
		public Guid guid { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D890C0-0x0000000184D890D0 0x0000000184D890D0-0x0000000184D890E0
	
		// Constructors
		public CriMonoBehaviour(); // 0x00000001846D8A80-0x00000001846D8B10
	
		// Methods
		protected virtual void OnEnable(); // 0x0000000183A06F30-0x0000000183A06F90
		protected virtual void OnDisable(); // 0x00000001868FD094-0x00000001868FD0E0
		public abstract void CriInternalUpdate();
		public abstract void CriInternalLateUpdate();
	}

	public class CriMonoBehaviourManager : MonoBehaviour // TypeDefIndex: 57926
	{
		// Fields
		private static CriMonoBehaviourManager _instance; // 0x00
		private static List<CriMonoBehaviour> criMonoBehaviourList; // 0x08
	
		// Properties
		public static CriMonoBehaviourManager instance { get; } // 0x0000000183A06F90-0x0000000183A06FF0 
	
		// Constructors
		public CriMonoBehaviourManager(); // 0x0000000185393520-0x0000000185393538
		static CriMonoBehaviourManager(); // 0x0000000184CDF490-0x0000000184CDF550
	
		// Methods
		public static void CreateInstance(); // 0x0000000183A06FF0-0x0000000183A070D0
		private static int GetIndex(CriMonoBehaviour criMonoBehaviour); // 0x0000000183A07310-0x0000000183A07440
		public bool Register(CriMonoBehaviour criMonoBehaviour); // 0x0000000183A070D0-0x0000000183A07310
		public static bool UnRegister(CriMonoBehaviour criMonoBehaviour); // 0x00000001868FCF4C-0x00000001868FD094
		private void Awake(); // 0x0000000184CE6540-0x0000000184CE6640
		private void Update(); // 0x0000000183A07670-0x0000000183A078A0
		private void LateUpdate(); // 0x0000000183A07440-0x0000000183A07670
	}
}

namespace CriWare.CriAtomDebugDetail
{
	public class Utility // TypeDefIndex: 57927
	{
		// Constructors
		public Utility(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static string PtrToStringAutoOrNull(IntPtr stringPtr); // 0x00000001868FF1A8-0x00000001868FF1F4
	}
}

namespace CriWare.CriMana
{
	public enum CodecType // TypeDefIndex: 57946
	{
		Unknown = 0,
		SofdecPrime = 1,
		H264 = 5,
		VP9 = 9
	}

	public enum AlphaType // TypeDefIndex: 57947
	{
		CompoOpaq = 0,
		CompoAlphaFull = 1,
		CompoAlpha3Step = 2,
		CompoAlpha32Bit = 3
	}

	public struct AudioInfo // TypeDefIndex: 57948
	{
		// Fields
		public uint samplingRate; // 0x00
		public uint numChannels; // 0x04
		public uint totalSamples; // 0x08
	}

	[Serializable]
	public class MovieInfo // TypeDefIndex: 57949
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
		public bool hasAlpha { get; internal set; } // 0x00000001869029DC-0x00000001869029E4 0x00000001869029E4-0x0000000186902A00
	
		// Constructors
		public MovieInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class FrameInfo // TypeDefIndex: 57950
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
		public FrameInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct EventPoint // TypeDefIndex: 57951
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

	public static class Settings // TypeDefIndex: 57952
	{
		// Methods
		public static void SetDecodeSkippingEnabled(bool enabled); // 0x0000000186909390-0x00000001869093DC
	}

	public class Player : CriDisposable // TypeDefIndex: 57967
	{
		// Fields
		private const int InvalidPlayerId = -1; // Metadata: 0x0234BA92
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
		[CompilerGenerated]
		private SubtitleChangeCallback OnSubtitleChanged; // 0xA8
		[CompilerGenerated]
		private bool _additiveMode_k__BackingField; // 0xB0
		[CompilerGenerated]
		private bool _useMaterialBlendMode_k__BackingField; // 0xB1
		[CompilerGenerated]
		private int _maxFrameDrop_k__BackingField; // 0xB4
		[CompilerGenerated]
		private bool _applyTargetAlpha_k__BackingField; // 0xB8
		[CompilerGenerated]
		private bool _uiRenderMode_k__BackingField; // 0xB9
		[CompilerGenerated]
		private IntPtr _subtitleBuffer_k__BackingField; // 0xC0
		[CompilerGenerated]
		private int _subtitleSize_k__BackingField; // 0xC8
		[CompilerGenerated]
		private CriManaMoviePlayerHolder _playerHolder_k__BackingField; // 0xD0
		protected Queue<Operation> operationQueue; // 0xD8
		protected Operation? cntOperation; // 0xE0
	
		// Properties
		private Status requiredStatus { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x0000000186906788-0x00000001869067A8
		public bool additiveMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88CC0-0x0000000184D88CD0 0x0000000184D88D20-0x0000000184D88D30
		public bool useMaterialBlendMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88CB0-0x0000000184D88CC0 0x0000000184D88D10-0x0000000184D88D20
		public int maxFrameDrop { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D892E0-0x0000000184D892F0 0x0000000184D89330-0x0000000184D89340
		public bool applyTargetAlpha { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D892C0-0x0000000184D892D0 0x0000000184D89320-0x0000000184D89330
		public bool uiRenderMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D89310-0x0000000184D89320 0x0000000184D89360-0x0000000184D89370
		public bool isFrameAvailable { get; } // 0x0000000184D892D0-0x0000000184D892E0 
		public MovieInfo movieInfo { get; } // 0x0000000186906660-0x0000000186906670 
		public FrameInfo frameInfo { get; } // 0x0000000186906648-0x0000000186906658 
		public Status status { get; } // 0x000000018690667C-0x00000001869066F0 
		public Status nativeStatus { get; } // 0x0000000184D86710-0x0000000184D86720 
		public int numberOfEntries { get; } // 0x0000000186906670-0x000000018690667C 
		public IntPtr subtitleBuffer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000184D89340-0x0000000184D89350
		public int subtitleSize { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D89300-0x0000000184D89310 0x0000000184D89350-0x0000000184D89360
		public CriAtomExPlayer atomExPlayer { get; } // 0x0000000184D86260-0x0000000184D86270 
		public CriAtomEx3dSource atomEx3DsourceForAmbisonics { get; } // 0x0000000184D861F0-0x0000000184D86200 
		public TimerType timerType { get; } // 0x0000000184D86B60-0x0000000184D86B70 
		public CriManaMoviePlayerHolder playerHolder { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D876B0-0x0000000184D876C0 0x000000018678D7BC-0x000000018678D7D0
		public bool isAlive { get; } // 0x0000000186906658-0x0000000186906660 
	
		// Events
		public event SubtitleChangeCallback OnSubtitleChanged {
			add; // 0x0000000186906448-0x00000001869064E0
			remove; // 0x00000001869066F0-0x0000000186906788
		}
	
		// Nested types
		public enum Status // TypeDefIndex: 57953
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
	
		public enum SetMode // TypeDefIndex: 57954
		{
			New = 0,
			Append = 1,
			AppendRepeatedly = 2
		}
	
		public enum MovieEventSyncMode // TypeDefIndex: 57955
		{
			FrameTime = 0,
			PlayBackTime = 1
		}
	
		public enum AudioTrack // TypeDefIndex: 57956
		{
			Off = 0,
			Auto = 1
		}
	
		public enum TimerType // TypeDefIndex: 57957
		{
			None = 0,
			System = 1,
			Audio = 2,
			User = 3,
			Manual = 4
		}
	
		public delegate void CuePointCallback(ref EventPoint eventPoint); // TypeDefIndex: 57958; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void StatusChangeCallback(Status status); // TypeDefIndex: 57959; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void SubtitleChangeCallback(IntPtr subtitleBuffer); // TypeDefIndex: 57960; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode); // TypeDefIndex: 57961; 0x00000001815802E0-0x00000001815802F0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint); // TypeDefIndex: 57962; 0x0000000181546280-0x00000001815462A0
	
		public enum CriManaUnityPlayer_RenderEventAction // TypeDefIndex: 57963
		{
			UPDATE = 0,
			INITIALIZE = 256,
			RENDER = 512,
			DESTROY = 768
		}
	
		protected enum OperationType // TypeDefIndex: 57964
		{
			Normal = 0,
			SetFile = 1,
			SeekToTime = 2,
			Pause = 3
		}
	
		protected struct Operation // TypeDefIndex: 57965
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
			public static Operation Start(); // 0x0000000184D89250-0x0000000184D89280
			public static Operation Pause(bool sw); // 0x0000000184D891A0-0x0000000184D891C0
			public static Operation Stop(); // 0x0000000184D892A0-0x0000000184D892C0
			public static Operation StopForSeek(); // 0x0000000184D89280-0x0000000184D892A0
			public static Operation Prepare(); // 0x0000000184D891F0-0x0000000184D89220
			public static Operation PrepareForRendering(); // 0x0000000184D891C0-0x0000000184D891F0
			public static Operation SetFile(CriFsBinder binder, string moviePath, SetMode setMode); // 0x0000000186902A00-0x0000000186902A44
			public static Operation SeekToTime(float time); // 0x0000000184D89220-0x0000000184D89250
		}
	
		[CompilerGenerated]
		private sealed class _IssuePluginUpdatesForFrames_d__152 : IEnumerator<object> // TypeDefIndex: 57966
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _IssuePluginUpdatesForFrames_d__152(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186909804-0x00000001869098B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869098B0-0x00000001869098FC
		}
	
		// Constructors
		public Player(); // 0x00000001869062A4-0x0000000186906448
		public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length); // 0x0000000186905FB4-0x00000001869062A4
	
		// Methods
		~Player(); // 0x0000000186904E64-0x0000000186904ED8
		public override void Dispose(); // 0x00000001869045C8-0x0000000186904618
		public void CreateRendererResource(int width, int height, bool alpha); // 0x00000001869040C0-0x000000018690423C
		public void DisposeRendererResource(); // 0x0000000186904338-0x0000000186904370
		public void Prepare(); // 0x00000001869056E0-0x0000000186905720
		public void PrepareForRendering(); // 0x0000000186905600-0x0000000186905644
		public void Start(); // 0x0000000186905B68-0x0000000186905BC8
		public void Stop(); // 0x0000000186905C7C-0x0000000186905CC4
		public void StopForSeek(); // 0x0000000186905BC8-0x0000000186905C7C
		public void Pause(bool sw); // 0x00000001869055E8-0x0000000186905600
		public bool IsPaused(); // 0x000000018690547C-0x0000000186905488
		public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x0234BA8B */); // 0x000000018690590C-0x00000001869059D4
		public bool SetData(IntPtr data, long dataSize, SetMode setMode = SetMode.New /* Metadata: 0x0234BA8C */); // 0x0000000186905850-0x0000000186905880
		[Obsolete("Use SetData(IntPtr, Int64, SetMode) instead")]
		public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New /* Metadata: 0x0234BA8D */); // 0x0000000186905820-0x0000000186905850
		public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New /* Metadata: 0x0234BA8E */); // 0x0000000186905774-0x0000000186905820
		public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New /* Metadata: 0x0234BA8F */); // 0x00000001869058D4-0x000000018690590C
		public void Loop(bool sw); // 0x000000018690559C-0x00000001869055AC
		public void SetMasterTimerType(TimerType timerType); // 0x0000000186905A58-0x0000000186905A6C
		public void SetSeekPosition(int frameNumber); // 0x0000000186905A90-0x0000000186905A9C
		public void SetMovieEventSyncMode(MovieEventSyncMode mode); // 0x0000000186905A84-0x0000000186905A90
		public void SetSpeed(float speed); // 0x0000000186905A9C-0x0000000186905AA8
		public void SetMaxPictureDataSize(uint maxDataSize); // 0x0000000186905A6C-0x0000000186905A78
		public void SetBufferingTime(float sec); // 0x000000018690575C-0x0000000186905768
		public void SetMinBufferSize(int min_buffer_size); // 0x0000000186905A78-0x0000000186905A84
		public void SetAudioTrack(int track); // 0x0000000186905750-0x000000018690575C
		public void SetAudioTrack(AudioTrack track); // 0x000000018690572C-0x0000000186905750
		public void SetSubAudioTrack(int track); // 0x0000000186905AB4-0x0000000186905AC0
		public void SetSubAudioTrack(AudioTrack track); // 0x0000000186905AC0-0x0000000186905AE4
		public void SetExtraAudioTrack(int track); // 0x000000018690588C-0x0000000186905898
		public void SetExtraAudioTrack(AudioTrack track); // 0x0000000186905898-0x00000001869058BC
		public void SetVolume(float volume); // 0x0000000186905B5C-0x0000000186905B68
		public float GetVolume(); // 0x0000000186904F90-0x0000000186904F9C
		public void SetSubAudioVolume(float volume); // 0x0000000186905AE4-0x0000000186905AF0
		public float GetSubAudioVolume(); // 0x0000000186904EF0-0x0000000186904EFC
		public void SetExtraAudioVolume(float volume); // 0x00000001869058BC-0x00000001869058C8
		public float GetExtraAudioVolume(); // 0x0000000186904EE4-0x0000000186904EF0
		public void SetBusSendLevel(string bus_name, float level); // 0x0000000186905768-0x0000000186905774
		public void SetSubAudioBusSendLevel(string bus_name, float volume); // 0x0000000186905AA8-0x0000000186905AB4
		public void SetExtraAudioBusSendLevel(string bus_name, float volume); // 0x0000000186905880-0x000000018690588C
		public void SetSubtitleChannel(int channel); // 0x0000000186905AF0-0x0000000186905B50
		public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback); // 0x000000018485F170-0x000000018485F180
		public long GetTime(); // 0x0000000186904EFC-0x0000000186904F08
		public int GetDisplayedFrameNo(); // 0x0000000186904ED8-0x0000000186904EE4
		public bool HasRenderedNewFrame(); // 0x0000000186904F9C-0x0000000186904FC4
		public void SetAsrRackId(int asrRackId); // 0x0000000186905720-0x000000018690572C
		public void SetUserTimeCorrectionThreshold(uint threshold_msec); // 0x0000000186905B50-0x0000000186905B5C
		public void SetExtraFramePoolSize(uint size); // 0x00000001869058C8-0x00000001869058D4
		public void UpdateWithUserTime(ulong timeCount, ulong timeUnit); // 0x0000000186905F08-0x0000000186905F98
		public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD); // 0x00000001869059D4-0x0000000186905A58
		public void UpdateWithManualTimeAdvanced(); // 0x0000000186905E98-0x0000000186905F08
		public void Update(); // 0x0000000186905F98-0x0000000186905FB4
		public void OnWillRenderObject(CriManaMovieMaterialBase sender); // 0x00000001869055AC-0x00000001869055E8
		public bool UpdateMaterial(Material material); // 0x0000000186905CC4-0x0000000186905D2C
		public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction); // 0x0000000186905488-0x0000000186905500
		private void Dispose(bool disposing); // 0x0000000186904370-0x00000001869045C8
		private void InternalUpdate(); // 0x0000000186904FC4-0x00000001869053C0
		[IteratorStateMachine(typeof(_IssuePluginUpdatesForFrames_d__152))]
		private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy, int playerId); // 0x0000000186905500-0x000000018690559C
		private void DisableInfos(bool keepFrameInfo = false /* Metadata: 0x0234BA90 */); // 0x000000018690431C-0x0000000186904338
		private void PrepareNativePlayer(); // 0x0000000186905644-0x00000001869056E0
		private void UpdateNativePlayer(); // 0x0000000186905D2C-0x0000000186905E98
		private void InvokePlayerStatusCheck(); // 0x00000001869053C0-0x000000018690547C
		private void AllocateSubtitleBuffer(int size); // 0x0000000186902B64-0x0000000186902C28
		private void DeallocateSubtitleBuffer(); // 0x00000001869042A4-0x000000018690431C
		internal void PauseOnApplicationPause(bool sw); // 0x00000001869055E8-0x0000000186905600
		[AOT.MonoPInvokeCallback(typeof(CuePointCallbackFromNativeDelegate))]
		private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint); // 0x000000018690423C-0x00000001869042A4
		private static extern int CRIWAREFD186F02(); // 0x000000018690404C-0x0000000186904078
		private static extern int CRIWARE72A5B8BF(); // 0x0000000186903574-0x00000001869035A0
		private static extern int CRIWARE95A85424(bool useAtomExPlayer, uint maxPathLength); // 0x00000001869037B0-0x0000000186903834
		private static extern void CRIWAREABF659EC(int player_id); // 0x000000018690393C-0x0000000186903970
		private static extern void CRIWAREEDB46019(int player_id, IntPtr binder, string path); // 0x0000000186903F08-0x0000000186903FB0
		private static extern void CRIWAREB28B5D50(int player_id, IntPtr binder, int content_id); // 0x00000001869039D4-0x0000000186903A68
		private static extern void CRIWARE65553651(int player_id, string path, ulong offset, long range); // 0x00000001869033D4-0x0000000186903488
		private static extern void CRIWARE7C753A2E(int player_id, IntPtr data, long datasize); // 0x0000000186903608-0x000000018690369C
		private static extern void CRIWARE7C753A2E(int player_id, byte[] data, long datasize); // 0x000000018690369C-0x0000000186903738
		private static extern bool CRIWARE328F2911(int player_id, IntPtr binder, string path, bool repeat); // 0x00000001869030B8-0x000000018690317C
		private static extern bool CRIWAREDA0693CD(int player_id, IntPtr binder, int content_id, bool repeat); // 0x0000000186903DEC-0x0000000186903E94
		private static extern bool CRIWARE162DD162(int player_id, string path, ulong offset, long range, bool repeat); // 0x0000000186902CAC-0x0000000186902D7C
		private static extern bool CRIWAREC35C3DC3(int player_id, IntPtr data, long datasize, bool repeat); // 0x0000000186903ADC-0x0000000186903B84
		private static extern bool CRIWAREC35C3DC3(int player_id, byte[] data, long datasize, bool repeat); // 0x0000000186903B84-0x0000000186903C34
		private static extern void CRIWARE66A63134(int player_id); // 0x0000000186903488-0x00000001869034BC
		private static extern int CRIWARE88D04318(int player_id); // 0x0000000186903738-0x000000018690376C
		private static extern void CRIWARED9F7168D(int player_id, CuePointCallbackFromNativeDelegate cbfunc); // 0x0000000186903D60-0x0000000186903DEC
		private static extern void CRIWARE1E785A43(int player_id, out MovieInfo movie_info); // 0x0000000186902DF0-0x0000000186902ECC
		private static extern int CRIWARE3CE8CE6A(int player_id, IntPtr subtitle_buffer, ref uint subtitle_size); // 0x00000001869031E4-0x0000000186903278
		private static extern void CRIWARE362A826C(int player_id); // 0x00000001869031B0-0x00000001869031E4
		private static extern void CRIWARE61523A0C(int player_id); // 0x00000001869033A0-0x00000001869033D4
		private static extern void CRIWAREBB898C91(int player_id); // 0x0000000186903A68-0x0000000186903A9C
		private static extern void CRIWARE705B8C6D(int player_id, int seek_frame_no); // 0x00000001869034FC-0x000000018690353C
		private static extern void CRIWAREEB32FC73(int player_id, MovieEventSyncMode mode); // 0x0000000186903EC8-0x0000000186903F08
		private static extern void CRIWARE18BFCB88(int player_id, int sw); // 0x0000000186902DB0-0x0000000186902DF0
		private static extern bool CRIWAREEFA5210A(int player_id); // 0x0000000186903FB0-0x0000000186903FE8
		private static extern void CRIWARE4331E077(int player_id, int sw); // 0x000000018690332C-0x000000018690336C
		private static extern long CRIWARE7779586C(int player_id); // 0x00000001869035D4-0x0000000186903608
		private static extern int CRIWARE33981CC9(int player_id); // 0x000000018690317C-0x00000001869031B0
		private static extern IntPtr CRIWARE165B6B70(int player_id); // 0x0000000186902D7C-0x0000000186902DB0
		private static extern int CRIWARE7500F0DD(int player_id); // 0x00000001869035A0-0x00000001869035D4
		private static extern void CRIWARED99932F6(int player_id, int track); // 0x0000000186903D20-0x0000000186903D60
		private static extern void CRIWARE1FF2F5BE(int player_id, float vol); // 0x0000000186902F10-0x0000000186902F54
		private static extern float CRIWARED30C9C6F(int player_id); // 0x0000000186903CEC-0x0000000186903D20
		private static extern void CRIWARE0EA59F65(int player_id, int track); // 0x0000000186902C6C-0x0000000186902CAC
		private static extern void CRIWARE1EBB12C5(int player_id, float vol); // 0x0000000186902ECC-0x0000000186902F10
		private static extern float CRIWARE966C4BA9(int player_id); // 0x0000000186903834-0x0000000186903868
		private static extern void CRIWARE213452EF(int player_id, int track); // 0x0000000186902F54-0x0000000186902F94
		private static extern void CRIWARE0348BF1B(int player_id, float vol); // 0x0000000186902C28-0x0000000186902C6C
		private static extern float CRIWAREC5A3A88D(int player_id); // 0x0000000186903C34-0x0000000186903C68
		private static extern void CRIWARE31668293(int player_id, string bus_name, float level); // 0x0000000186903054-0x00000001869030B8
		private static extern void CRIWAREB2460D7A(int player_id, string bus_name, float level); // 0x0000000186903970-0x00000001869039D4
		private static extern void CRIWAREF4B0CC4E(int player_id, string bus_name, float level); // 0x0000000186903FE8-0x000000018690404C
		private static extern void CRIWARE2C8FF595(int player_id, int channel); // 0x0000000186903014-0x0000000186903054
		private static extern void CRIWAREAB576D15(int player_id, float speed); // 0x00000001869038F8-0x000000018690393C
		private static extern void CRIWARE3F9C5D06(int player_id, uint max_data_size); // 0x0000000186903278-0x00000001869032F8
		public static extern void CRIWARE8A87737B(int player_id, float sec); // 0x000000018690376C-0x00000001869037B0
		public static extern void CRIWARE6756AE56(int player_id, int min_buffer_size); // 0x00000001869034BC-0x00000001869034FC
		public static extern void CRIWAREA7F6DE6B(int player_id, int asr_rack_id); // 0x00000001869038B8-0x00000001869038F8
		private static extern void CRIWAREE2DF1163(int player_id); // 0x0000000186903E94-0x0000000186903EC8
		private static extern void CRIWAREBD24DE27(int player_id, TimerType timer_type); // 0x0000000186903A9C-0x0000000186903ADC
		private static extern void CRIWAREC7C5CC77(int player_id, ulong user_count, ulong user_unit); // 0x0000000186903C68-0x0000000186903CB8
		private static extern void CRIWAREA59E0F01(int player_id, ulong timer_unit_n, ulong timer_unit_d); // 0x0000000186903868-0x00000001869038B8
		private static extern void CRIWARE55ECC3E4(int player_id); // 0x000000018690336C-0x00000001869033A0
		private static extern void CRIWARECEA2FA98(int player_id); // 0x0000000186903CB8-0x0000000186903CEC
		private static extern IntPtr CRIWARE27ED314F(int player_id, int bufferSize); // 0x0000000186902F94-0x0000000186903014
		private static extern bool CRIWARE725ED4B4(int player_id); // 0x000000018690353C-0x0000000186903574
		private static extern void CRIWARE419ECAF8(int player_id); // 0x00000001869032F8-0x000000018690332C
		private static extern IntPtr criWareUnity_GetRenderEventFunc(); // 0x00000001869065E0-0x0000000186906648
		private static extern void criManaUnityPlayer_SetUserTimeCorrectionThreshold(int player_id, uint threshold_msec); // 0x0000000186906560-0x00000001869065E0
		private static extern void criManaUnityPlayer_SetExtraFramePoolSize(int player_id, uint size); // 0x00000001869064E0-0x0000000186906560
		public void ClearAllOperation(); // 0x0000000186904078-0x00000001869040C0
		protected void ExecuteOperation(); // 0x0000000186904BA8-0x0000000186904E64
		public void EasyPrepare(); // 0x0000000186904724-0x0000000186904798
		public void EasyPrepareForRendering(); // 0x00000001869046B0-0x0000000186904724
		public void EasyStart(); // 0x0000000186904A5C-0x0000000186904AD0
		public void EasyPause(bool sw); // 0x0000000186904618-0x00000001869046B0
		public void EasyStop(); // 0x0000000186904B44-0x0000000186904BA8
		public void EasyStopForSeek(); // 0x0000000186904AD0-0x0000000186904B44
		public void EasySetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x0234BA91 */); // 0x0000000186904798-0x0000000186904884
		public void EasySetSeekTime(float time); // 0x0000000186904884-0x0000000186904920
		public void EasyStartAtTime(float time); // 0x0000000186904920-0x0000000186904A5C
		public float GetVideoLength(); // 0x0000000186904F08-0x0000000186904F90
	}
}

namespace CriWare.CriMana.Detail
{
	public static class AutoResisterRendererResourceFactories // TypeDefIndex: 57971
	{
		// Nested types
		[RendererResourceFactoryPriority(7050)]
		public class RendererResourceFactoryH264Yuv : RendererResourceFactory // TypeDefIndex: 57968
		{
			// Constructors
			public RendererResourceFactoryH264Yuv(); // 0x0000000184D7BFB0-0x0000000184D7BFF0
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x00000001869067A8-0x0000000186906844
			protected override void OnDisposeManaged(); // 0x00000001841E1670-0x00000001841E1680
			protected override void OnDisposeUnmanaged(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[RendererResourceFactoryPriority(5000)]
		public class RendererResourceFactorySofdecPrimeYuv : RendererResourceFactory // TypeDefIndex: 57969
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuv(); // 0x0000000184D7BF30-0x0000000184D7BF70
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x00000001869068F0-0x000000018690699C
			protected override void OnDisposeManaged(); // 0x00000001841E1670-0x00000001841E1680
			protected override void OnDisposeUnmanaged(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[RendererResourceFactoryPriority(10000)]
		public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory // TypeDefIndex: 57970
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuvRawData(); // 0x0000000184D7BF70-0x0000000184D7BFB0
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000186906844-0x00000001869068F0
			protected override void OnDisposeManaged(); // 0x00000001841E1670-0x00000001841E1680
			protected override void OnDisposeUnmanaged(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Methods
		public static void InvokeAutoRegister(); // 0x00000001839EC640-0x00000001839EC880
	}

	public class RendererResourceH264Yuv : RendererResourceSofdecPrimeYuv // TypeDefIndex: 57972
	{
		// Constructors
		public RendererResourceH264Yuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000186906EB4-0x0000000186906EC4
	}

	public abstract class RendererResource : IDisposable // TypeDefIndex: 57973
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
		public bool useMaterialBlendMode { get; set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
	
		// Constructors
		protected RendererResource(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		~RendererResource(); // 0x0000000186909078-0x00000001869090EC
		public void Dispose(); // 0x0000000186908FF0-0x0000000186909040
		private void Dispose(bool disposing); // 0x0000000186909040-0x0000000186909078
		public int GetNumberOfFrameBeforeDestroy(int playerId); // 0x0000000186909120-0x0000000186909138
		protected void SetupStaticMaterialProperties(); // 0x000000018690918C-0x0000000186909390
		private void GetBlendModes(out int srcBlendMode, out int dstBlendMode); // 0x00000001869090EC-0x0000000186909120
		public virtual void SetApplyTargetAlpha(bool flag); // 0x0000000186909140-0x000000018690914C
		public virtual void SetUiRenderMode(bool flag); // 0x0000000186909180-0x000000018690918C
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract bool IsPrepared();
		public abstract bool ContinuePreparing();
		public abstract void AttachToPlayer(int playerId);
		public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);
		public abstract bool UpdateMaterial(Material material);
		public abstract void UpdateTextures();
		public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
		public virtual void OnPlayerPause(bool pauseStatus, bool triggredFromApplciationPause); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnPlayerStop(); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool OnPlayerStopForSeek(); // 0x00000001812081B0-0x0000000181208610
		public virtual void OnPlayerStart(); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool ShouldSkipDestroyOnStopForSeek(); // 0x00000001812081B0-0x0000000181208610
		public virtual bool HasRenderedNewFrame(); // 0x0000000182FFF600-0x0000000182FFF610
		public static uint NextPowerOfTwo(uint x); // 0x0000000184D89420-0x0000000184D89450
		public static int NextPowerOfTwo(int x); // 0x0000000186909138-0x0000000186909140
		public static int CeilingWith(int x, int ceilingValue); // 0x0000000184D89410-0x0000000184D89420
		public static int Ceiling16(int x); // 0x0000000184D893D0-0x0000000184D893E0
		public static int Ceiling32(int x); // 0x0000000184D893F0-0x0000000184D89400
		public static int Ceiling64(int x); // 0x0000000184D89400-0x0000000184D89410
		public static int Ceiling256(int x); // 0x0000000184D893E0-0x0000000184D893F0
		protected static void DisposeTextures(Texture[] textures); // 0x0000000186908F44-0x0000000186908FF0
		protected static void SetKeyword(Material material, string keyword, bool flag); // 0x000000018690914C-0x0000000186909180
		protected static extern bool CRIWARE98318E69(int player_id, int num_textures, IntPtr[] tex_ptrs, [In, Out] FrameInfo frame_info, ref bool frame_drop); // 0x0000000186908D2C-0x0000000186908E0C
		protected static extern bool CRIWARED618B369(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x0000000186908E0C-0x0000000186908E6C
		protected static extern bool CRIWARE5267266A(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x0000000186908CCC-0x0000000186908D2C
		protected static extern bool CRIWAREE519EFD4(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x0000000186908E6C-0x0000000186908ECC
		protected static extern sbyte CRIWAREF14F77D8(int player_id); // 0x0000000186908ECC-0x0000000186908F44
	}

	public abstract class RendererResourceFactory : IDisposable // TypeDefIndex: 57974
	{
		// Fields
		private static SortedList<int, RendererResourceFactory> factoryList; // 0x00
		private bool disposed; // 0x10
	
		// Constructors
		protected RendererResourceFactory(); // 0x00000001841E1670-0x00000001841E1680
		static RendererResourceFactory(); // 0x0000000184D16F80-0x0000000184D17010
	
		// Methods
		public static void RegisterFactory(RendererResourceFactory factory, int priority); // 0x00000001839EC5B0-0x00000001839EC640
		public static void DisposeAllFactories(); // 0x0000000186906C20-0x0000000186906DB8
		public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x000000018690699C-0x0000000186906C20
		~RendererResourceFactory(); // 0x0000000186906E40-0x0000000186906EB4
		public void Dispose(); // 0x0000000186906DF0-0x0000000186906E40
		private void Dispose(bool disposing); // 0x0000000186906DB8-0x0000000186906DF0
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class RendererResourceFactoryPriorityAttribute : Attribute // TypeDefIndex: 57975
	{
		// Fields
		public readonly int priority; // 0x10
	
		// Constructors
		public RendererResourceFactoryPriorityAttribute(int priority); // 0x00000001814F51F0-0x00000001814F5220
	}

	public class RendererResourceSofdecPrimeYuv : RendererResource // TypeDefIndex: 57976
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
		private static int NumTextureSets { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		private static bool IsEditor { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public RendererResourceSofdecPrimeYuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000186908764-0x0000000186908CCC
	
		// Methods
		protected override void OnDisposeManaged(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnDisposeUnmanaged(); // 0x0000000186907F84-0x0000000186908200
		public override bool IsPrepared(); // 0x0000000184D893B0-0x0000000184D893C0
		public override bool ContinuePreparing(); // 0x0000000182FFF600-0x0000000182FFF610
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000186907E94-0x0000000186907F84
		public override bool OnPlayerStopForSeek(); // 0x0000000184D893C0-0x0000000184D893D0
		public override bool HasRenderedNewFrame(); // 0x0000000184D893A0-0x0000000184D893B0
		public override void AttachToPlayer(int playerId); // 0x0000000186907E28-0x0000000186907E94
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop); // 0x0000000186908200-0x000000018690829C
		public override bool UpdateMaterial(Material material); // 0x000000018690829C-0x00000001869084C4
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight); // 0x00000001869084C4-0x00000001869085D0
		public override void UpdateTextures(); // 0x00000001869085D0-0x0000000186908764
	}

	public class RendererResourceSofdecPrimeYuvRawData : RendererResource // TypeDefIndex: 57977
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
		private static int NumTextureSets { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	
		// Constructors
		public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x00000001869078FC-0x0000000186907E28
	
		// Methods
		protected override void OnDisposeManaged(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnDisposeUnmanaged(); // 0x0000000186907148-0x00000001869071B4
		public override bool IsPrepared(); // 0x0000000184D89370-0x0000000184D89380
		public override bool ContinuePreparing(); // 0x0000000182FFF600-0x0000000182FFF610
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000186907058-0x0000000186907148
		public override bool OnPlayerStopForSeek(); // 0x0000000184D89380-0x0000000184D893A0
		public override bool HasRenderedNewFrame(); // 0x0000000184D88E70-0x0000000184D88E80
		public override void AttachToPlayer(int playerId); // 0x0000000186906EC4-0x0000000186906F30
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop); // 0x00000001869071B4-0x0000000186907248
		public override bool UpdateMaterial(Material material); // 0x0000000186907248-0x00000001869074B8
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight); // 0x00000001869074B8-0x00000001869075D4
		public override void UpdateTextures(); // 0x00000001869075D4-0x00000001869078FC
		private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma); // 0x0000000186906F30-0x0000000186907058
	}
}

namespace CriWare.CriTimeline.Atom
{
	public struct CriAtomClipPlayConfig // TypeDefIndex: 57938
	{
		// Fields
		public readonly CriAtomClipBase clip; // 0x00
		public readonly long startTimeMs; // 0x08
		public readonly double speedRate; // 0x10
		public readonly bool loop; // 0x18
	
		// Constructors
		public CriAtomClipPlayConfig(CriAtomClipBase clip, long startTimeMs, double speedRate, bool loop); // 0x00000001868FF974-0x00000001868FF9A0
	}

	[Serializable]
	public class CriAtomBehaviour : PlayableBehaviour // TypeDefIndex: 57939
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
		[CompilerGenerated]
		private CriAtomExPlayback _playback_k__BackingField; // 0x30
		private bool _IsClipPlaying; // 0x34
		private double _CueLength; // 0x38
	
		// Properties
		public CriAtomExPlayback playback { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public bool IsClipPlaying { get; private set; } // 0x0000000184D86A90-0x0000000184D86AA0 0x0000000184D86AA0-0x0000000184D86AB0
		public double CueLength { get; private set; } // 0x0000000184D869C0-0x0000000184D869D0 0x0000000184D869E0-0x0000000184D869F0
	
		// Constructors
		public CriAtomBehaviour(); // 0x0000000184D87330-0x0000000184D87340
		static CriAtomBehaviour(); // 0x00000001868FF7F4-0x00000001868FF830
	
		// Methods
		public override void OnGraphStop(Playable playable); // 0x0000000184D89160-0x0000000184D89170
		public void Play(CriAtomSourceBase atomSource, CriAtomClipPlayConfig config); // 0x00000001868FF250-0x00000001868FF434
		public void PreviewPlay(Guid trackId, bool instantStop, CriAtomClipPlayConfig config); // 0x00000001868FF434-0x00000001868FF6C4
		private void WaitAndStop(); // 0x00000001868FF748-0x00000001868FF7F4
		public void Stop(bool noReleaseTime = false /* Metadata: 0x0234BA7E */); // 0x00000001868FF6C4-0x00000001868FF6EC
		private double GetCueLengthSec(CriAtomExAcb acb, string cueName); // 0x00000001868FF1F4-0x00000001868FF250
		[CompilerGenerated]
		private void _WaitAndStop_b__21_0(); // 0x00000001868FF6EC-0x00000001868FF748
	}

	public class CriAtomClip : CriAtomClipBase // TypeDefIndex: 57940
	{
		// Fields
		public string cueSheet; // 0x30
		public string cueName; // 0x38
	
		// Properties
		public override string CueName { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public override string AcbPath { get; } // 0x00000001868FFAA4-0x00000001868FFB2C 
		public override string AwbPath { get; } // 0x00000001868FFB2C-0x00000001868FFBB4 
	
		// Constructors
		public CriAtomClip(); // 0x00000001868FFA9C-0x00000001868FFAA4
	
		// Methods
		public override CriAtomExAcb GetAcb(); // 0x00000001868FF9A0-0x00000001868FF9AC
		private CriAtomCueSheet GetCueSheet(); // 0x00000001868FF9AC-0x00000001868FF9B8
		public override void SetCueFromAtomSource(CriAtomSourceBase atomSource); // 0x00000001868FF9B8-0x00000001868FFA9C
	}

	public abstract class CriAtomClipBase : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57941
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
		public ClipCaps clipCaps { get; } // 0x0000000184D89170-0x0000000184D89180 
		public override double duration { get; } // 0x00000001868FF958-0x00000001868FF974 
		public abstract string CueName { get; }
		public abstract string AcbPath { get; }
		public abstract string AwbPath { get; }
	
		// Constructors
		protected CriAtomClipBase(); // 0x00000001868FF8F4-0x00000001868FF958
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x00000001868FF830-0x00000001868FF8F4
		public void SetClipDuration(double clipDuration); // 0x0000000184D86D70-0x0000000184D86D80
		public abstract CriAtomExAcb GetAcb();
		public abstract void SetCueFromAtomSource(CriAtomSourceBase atomSource);
	}

	[Serializable]
	public class CriAtomMixerBehaviour : PlayableBehaviour // TypeDefIndex: 57942
	{
		// Fields
		internal PlayableDirector m_Director; // 0x10
		internal IEnumerable<TimelineClip> m_Clips; // 0x18
		internal CriAtomSourceBase m_Bind; // 0x20
		internal string m_AisacControls; // 0x28
		internal bool m_StopOnWrapping; // 0x30
		internal bool m_StopAtGraphEnd; // 0x31
		[CompilerGenerated]
		private Guid _m_Guid_k__BackingField; // 0x34
		private const int cScratchTimeIntervalMs = 200; // Metadata: 0x0234BA7F
		private System.DateTime m_lastScrubTime; // 0x48
		private double m_lastDirectorTime; // 0x50
	
		// Properties
		public Guid m_Guid { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D89180-0x0000000184D89190 0x0000000184D89190-0x0000000184D891A0
		private static bool IsEditor { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public CriAtomMixerBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void OnPlayableCreate(Playable playable); // 0x00000001868FFC2C-0x00000001868FFCAC
		public override void OnGraphStop(Playable playable); // 0x00000001868FFBB4-0x00000001868FFC2C
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x00000001868FFCAC-0x00000001869002C8
	}

	public class CriAtomTimelinePreviewer : IDisposable // TypeDefIndex: 57944
	{
		// Fields
		private static CriAtomTimelinePreviewer instance; // 0x00
		private CriAtom atom; // 0x10
		private string lastAcfFile; // 0x18
		private Dictionary<string, CriAtomExAcb> acbTable; // 0x20
		private Dictionary<Guid, PlayerSource> playerTable; // 0x28
		private CriAtomEx3dListener listener3d; // 0x30
	
		// Properties
		public static CriAtomTimelinePreviewer Instance { get; } // 0x00000001869012B0-0x0000000186901340 
		public static bool IsInitialized { get; } // 0x0000000186901340-0x000000018690137C 
	
		// Nested types
		private struct PlayerSource // TypeDefIndex: 57943
		{
			// Fields
			public readonly CriAtomExPlayer player; // 0x00
			public readonly CriAtomEx3dSource source3d; // 0x08
	
			// Constructors
			public PlayerSource(CriAtomEx3dListener listener); // 0x0000000186902A44-0x0000000186902B64
		}
	
		// Constructors
		public CriAtomTimelinePreviewer(); // 0x000000018690115C-0x00000001869012B0
	
		// Methods
		public static void InstanceDispose(); // 0x0000000186900CB0-0x0000000186900D18
		public CriAtomExPlayer GetPlayer(Guid trackId); // 0x0000000186900AD4-0x0000000186900CB0
		public void SetCue(Guid trackId, CriAtomExAcb acb, string cueName); // 0x0000000186900DD8-0x0000000186900E98
		public CriAtomExAcb GetAcb(string acbPath, string awbPath); // 0x0000000186900714-0x0000000186900AD4
		public CriAtomExPlayback Play(Guid trackId); // 0x0000000186900D18-0x0000000186900D4C
		public void StopTrack(Guid trackId, bool stopWithoutRelease = true /* Metadata: 0x0234BA81 */); // 0x0000000186901108-0x000000018690115C
		public void StopAllTracks(bool stopWithoutRelease = true /* Metadata: 0x0234BA82 */); // 0x0000000186900FA0-0x0000000186901108
		public void SetStartTime(Guid trackId, long startTimeMs); // 0x0000000186900F1C-0x0000000186900F5C
		public void SetLoop(Guid trackId, bool sw); // 0x0000000186900E98-0x0000000186900ED8
		public void SetVolume(Guid trackId, float volume); // 0x0000000186900F5C-0x0000000186900FA0
		public void SetPitch(Guid trackId, float pitch); // 0x0000000186900ED8-0x0000000186900F1C
		public void SetAISAC(Guid trackId, string controlName, float value); // 0x0000000186900D88-0x0000000186900DD8
		public void PlayerUpdateParameter(Guid trackId, CriAtomExPlayback atomExPlayback); // 0x0000000186900D4C-0x0000000186900D88
		~CriAtomTimelinePreviewer(); // 0x00000001869006A0-0x0000000186900714
		public void Dispose(); // 0x00000001869002C8-0x0000000186900318
		private void Dispose(bool disposing); // 0x0000000186900318-0x00000001869006A0
	}

	[TrackBindingType(typeof(CriAtomSourceBase))]
	[TrackClipType(typeof(CriAtomClipBase))]
	[TrackColor(0.3317462f, 0.6611561f, 0.990566f)]
	public class CriAtomTrack : TrackAsset // TypeDefIndex: 57945
	{
		// Fields
		public string m_AisacControls; // 0xC0
		public bool m_StopOnWrapping; // 0xC8
		public bool m_StopAtGraphEnd; // 0xC9
	
		// Constructors
		public CriAtomTrack(); // 0x00000001869017E8-0x000000018690183C
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject owner, int inputCount); // 0x000000018690137C-0x00000001869017E8
	}
}

namespace CriWare.CriTimeline.Mana
{
	[Serializable]
	public class CriManaBehaviour : PlayableBehaviour // TypeDefIndex: 57928
	{
		// Constructors
		public CriManaBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class CriManaClip : CriManaClipBase // TypeDefIndex: 57929
	{
		// Fields
		public string m_moviePath; // 0xA8
		public TextAsset m_movieData; // 0xB0
	
		// Properties
		public override string MoviePath { get; } // 0x0000000184D86290-0x0000000184D862A0 
		public override byte[] MovieData { get; } // 0x00000001868F87A0-0x00000001868F8818 
		public override string MovieName { get; } // 0x00000001868F8818-0x00000001868F88B4 
		public override int DataId { get; } // 0x00000001868F86F8-0x00000001868F87A0 
	
		// Constructors
		public CriManaClip(); // 0x00000001868F86A8-0x00000001868F86F8
	}

	public abstract class CriManaClipBase : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57931
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
		public ClipCaps clipCaps { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public bool IsMovieInfoReady { get; } // 0x00000001868F8650-0x00000001868F868C 
		public override double duration { get; } // 0x00000001868F868C-0x00000001868F86A8 
	
		// Nested types
		private struct MovieInfoStruct // TypeDefIndex: 57930
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
		protected CriManaClipBase(); // 0x00000001868F858C-0x00000001868F8650
	
		// Methods
		private MovieInfoStruct? StructToMovieInfo(MovieInfo movieInfo); // 0x00000001868F84B4-0x00000001868F858C
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x00000001868F809C-0x00000001868F8160
		public void ReplaceMovieInfo(MovieInfo movieInfo); // 0x00000001868F8308-0x00000001868F84B4
		public bool IsSameMovie(MovieInfo movieInfo); // 0x00000001868F822C-0x00000001868F8308
		public int GetSeekFrame(double seekTimeSec, bool loop); // 0x00000001868F8160-0x00000001868F822C
	}

	[Serializable]
	public class CriManaMixerBehaviour : PlayableBehaviour // TypeDefIndex: 57936
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
		private static bool IsEditMode { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Nested types
		private enum MovieMixerState // TypeDefIndex: 57932
		{
			Preloading = 0,
			Ready = 1,
			Playing = 2,
			Stopping = 3,
			Stopped = 4
		}
	
		private enum ClipState // TypeDefIndex: 57933
		{
			Idle = 0,
			Prepare = 1,
			Play = 2,
			Seek = 3
		}
	
		[CompilerGenerated]
		private struct _ProcessFrameOnSeeking_d__31 : IAsyncStateMachine // TypeDefIndex: 57934
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
			private void MoveNext(); // 0x00000001869098FC-0x000000018690A044
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001853982D4-0x00000001853982E0
		}
	
		[CompilerGenerated]
		private sealed class _seekPlaybackEnumerator_d__35 : IEnumerator<object> // TypeDefIndex: 57935
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriManaMixerBehaviour __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _seekPlaybackEnumerator_d__35(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018690A044-0x000000018690A108
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018690A108-0x000000018690A154
		}
	
		// Constructors
		public CriManaMixerBehaviour(); // 0x0000000184D89010-0x0000000184D89040
		static CriManaMixerBehaviour(); // 0x00000001868FB014-0x00000001868FB054
	
		// Methods
		private void KeepAudioVolume(bool fadeAudio); // 0x00000001868F8BA4-0x00000001868F8C60
		private bool PlayMovie(CriManaClipBase clipAsset, int startFrame, double startTime); // 0x00000001868F9228-0x00000001868F95EC
		private bool PrepareMovie(CriManaClipBase clipAsset); // 0x00000001868F95EC-0x00000001868F9844
		private bool StopMovie(); // 0x00000001868FAD60-0x00000001868FAE68
		private bool StopForSeekMovie(); // 0x00000001868FACE4-0x00000001868FAD60
		private static bool IsPlayerPreparing(Player player); // 0x00000001868F8B08-0x00000001868F8B38
		private static bool IsPlayerStopped(Player player); // 0x00000001868F8B84-0x00000001868F8BA4
		private static bool IsPlayerError(Player player); // 0x00000001868F8AE4-0x00000001868F8B08
		private static bool IsPlayerReadyOrPlaying(Player player); // 0x00000001868F8B38-0x00000001868F8B84
		private async void ProcessFrameOnSeeking(TimelineClip activeClip, CriManaClipBase clip, double frameTime); // 0x00000001868F9844-0x00000001868F9920
		private void ForceSyncedStop(bool keepLastFrame = false /* Metadata: 0x0234BA70 */); // 0x00000001868F88B4-0x00000001868F8964
		private void ToggleFMVNode(FrameData info, bool isOn, float weight = 1f /* Metadata: 0x0234BA71 */); // 0x00000001868FAE68-0x00000001868FB014
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x00000001868F9920-0x00000001868FACE4
		[IteratorStateMachine(typeof(_seekPlaybackEnumerator_d__35))]
		private IEnumerator seekPlaybackEnumerator(); // 0x00000001868FB054-0x00000001868FB0B0
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x00000001868F8C6C-0x00000001868F8C78
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x00000001868F8C60-0x00000001868F8C6C
		private void PausePlayer(bool pause); // 0x00000001868F91A0-0x00000001868F9228
		public override void OnGraphStart(Playable playable); // 0x00000001868F8C78-0x00000001868F8F54
		public override void OnGraphStop(Playable playable); // 0x00000001868F8F54-0x00000001868F90BC
		public override void OnPlayableCreate(Playable playable); // 0x00000001868F90BC-0x00000001868F9154
		public override void OnPlayableDestroy(Playable playable); // 0x00000001868F9154-0x00000001868F91A0
		public void InitMovieMixerState(); // 0x00000001868F8964-0x00000001868F8AE4
	}

	[TrackBindingType(typeof(CriManaMovieMaterialBase))]
	[TrackClipType(typeof(CriManaClipBase))]
	[TrackColor(0.15f, 0.5f, 1f)]
	public class CriManaTrack : TrackAsset // TypeDefIndex: 57937
	{
		// Fields
		[Tooltip("\u9ED8\u8BA4\u662FTrue\uFF0C\u4E0D\u5141\u8BB8\u4FEE\u6539")]
		public bool frameSync; // 0xC0
		public readonly Guid guid; // 0xC4
		private static Dictionary<int, Guid> bindDict; // 0x00
		[CompilerGenerated]
		private CriManaMixerBehaviour _MixerBehaviour_k__BackingField; // 0xD8
	
		// Properties
		public CriManaMixerBehaviour MixerBehaviour { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88EF0-0x0000000184D88F00 0x0000000186902698-0x00000001869026AC
	
		// Constructors
		public CriManaTrack(); // 0x0000000186902638-0x0000000186902698
		static CriManaTrack(); // 0x00000001869025AC-0x0000000186902638
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x0000000186901CB0-0x000000018690212C
		public void BindBehaviourMovieMaterial(PlayableDirector director, CriManaMovieMaterialBase boundMovieMaterial); // 0x000000018690183C-0x0000000186901CB0
		private void OnDestroy(); // 0x000000018690212C-0x0000000186902180
		private static void RemoveTrackFromBindDict(CriManaTrack trackAsset); // 0x0000000186902180-0x00000001869025AC
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 57654
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 57980
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x00000001869028A0-0x0000000186902904
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 57981
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000186902948-0x00000001869029DC
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186902904-0x0000000186902948
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 57982
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018690A33C-0x000000018690A3A0
		public static bool IsPatched(int id); // 0x000000018690A42C-0x000000018690A4C4
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018690A1F8-0x000000018690A2C4
		public object CreateWrapper(int id); // 0x000000018690A2C4-0x000000018690A33C
		public object InitWrapperArray(int len); // 0x000000018690A3A0-0x000000018690A42C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018690A154-0x000000018690A1F8
	}
}
