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

// Image 33: CriMw.CriWare.Runtime.dll - Assembly: CriMw.CriWare.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 84168-84499

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 84496
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D; // 0x00 // Static value (base64): AQAAAAIAAAADAAAA - Metadata: 0x02644588

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 84495
	{
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 84170
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 84171
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 84172
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 84173
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 84174
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 84175
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 84176
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace CriWare
{
	public class CriWarePS5 // TypeDefIndex: 84181
	{
		// Fields
		public const int SystemUserID = 255; // Metadata: 0x02644232
	
		// Nested types
		public enum AudioPortType : ushort // TypeDefIndex: 84177
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
	
		public enum AttributeId // TypeDefIndex: 84178
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
	
		public enum PortFlag : uint // TypeDefIndex: 84179
		{
			Restricted = 1,
			Passthrough = 2
		}
	
		internal static class SafeNativeMethods // TypeDefIndex: 84180
		{
			// Methods
			public static void criFsUnity_Setup_PS5(bool enable_apr_direct_mode); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CriWarePS5(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal static void SetupFileSystem(bool enableAprDirectMode); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class CriAtomPlugin // TypeDefIndex: 84183
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
		public static bool isInitialized { get; } // 0x0000000188C06B88-0x0000000188C06BD0 
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 84182; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		static CriAtomPlugin(); // 0x00000001870EC120-0x00000001870EC1F0
	
		// Methods
		public static void Log(string log); // 0x0000000186805BA0-0x0000000186805BB0
		public static void ExecuteQueuedCueLinkCallbacks(); // 0x0000000185FED0B0-0x0000000185FED100
		public static void ExecuteQueuedEventCallbacks(); // 0x0000000185FED030-0x0000000185FED080
		public static void ExecuteQueuedBeatSyncCallbacks(); // 0x0000000185FECFB0-0x0000000185FED000
		public static bool GetAudioEffectInterfaceList(out List<IntPtr> effect_interface_list); // 0x0000000188C0652C-0x0000000188C06650
		private static IntPtr GetSpatializerCoreInterfaceFromAtomOculusAudioBridge(); // 0x0000000188C06940-0x0000000188C06AD8
		public static void SetConfigParameters(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_aisacs, int max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, bool vr_mode); // 0x0000000186DDFDD0-0x0000000186DDFF70
		public static void SetConfigMonitorParametes(int max_preview_objects, int communication_buffer_size, int playback_position_update_interval); // 0x0000000185AFFF10-0x0000000185AFFF80
		public static void SetConfigAdditionalParameters_EDITOR(bool enable_user_pcm_output, int user_pcm_buffer_length); // 0x0000000185AFF910-0x0000000185AFF960
		public static void SetConfigAdditionalParameters_PC(long buffering_time_pc); // 0x0000000185AFF880-0x0000000185AFF8D0
		public static void SetConfigAdditionalParameters_LINUX(CriAtomConfig.LinuxOutput output, int pulse_latency_usec); // 0x0000000185AFFE00-0x0000000185AFFE60
		public static void SetConfigAdditionalParameters_IOS(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios); // 0x0000000185AFFEA0-0x0000000185AFFF10
		public static void SetConfigAdditionalParameters_ANDROID(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool use_fast_mixer, bool use_aaudio, int stream_type); // 0x0000000185B00130-0x0000000185B001E0
		public static void SetConfigAdditionalParameters_VITA(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, int num_mana_decoders); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetConfigAdditionalParameters_PS4(int num_atrac9_memory_voices, int num_atrac9_streaming_voices, bool use_audio3d, int num_audio3d_memory_voices, int num_audio3d_streaming_voices); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetConfigAdditionalParameters_PS5(int max_channel_ports, int max_object_ports); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetConfigAdditionalParameters_SWITCH(bool enable_sonicsync, int num_opus_memory_voices, int num_opus_streaming_voices, bool init_socket); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetConfigAdditionalParameters_WEBGL(int num_webaudio_voices); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetMaxSamplingRateForStandardVoicePool(int sampling_rate_for_memory, int sampling_rate_for_streaming); // 0x0000000188C06B30-0x0000000188C06B88
		public static int GetRequiredMaxVirtualVoices(CriAtomConfig atomConfig); // 0x0000000185AFF7F0-0x0000000185AFF830
		public static void InitializeLibrary(); // 0x0000000185AFFB50-0x0000000185AFFD00
		public static bool IsLibraryInitialized(); // 0x0000000185AFF2D0-0x0000000185AFF320
		public static void FinalizeLibrary(); // 0x0000000188C06370-0x0000000188C0652C
		public static void Pause(bool pause); // 0x0000000188C06AD8-0x0000000188C06B30
		public static Common.CpuUsage GetCpuUsage(); // 0x0000000188C06650-0x0000000188C0680C
		public static int GetOutputSamplingRate(); // 0x0000000188C06900-0x0000000188C06940
		public static int GetOutputChannels(); // 0x0000000188C068C0-0x0000000188C06900
		public static bool IsInitializedForPcmOutput(); // 0x00000001843FFFF0-0x0000000184400000
		public static ushort GetLoopCountParameterId(); // 0x0000000188C0680C-0x0000000188C068C0
		public static void DecryptAcb(IntPtr acb_hn, ulong key, ulong nonce); // 0x0000000188C062A0-0x0000000188C06370
		[AOT.MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
		private static ulong CallbackFromNative(IntPtr ptr1); // 0x0000000188C06250-0x0000000188C062A0
		private static extern void CRIWARE009CE561(int max_virtual_voices, int max_voice_limit_groups, int max_categories, int max_aisacs, int max_bus_sends, int max_sequence_events_per_frame, int max_beatsync_callbacks_per_frame, int max_cuelink_callbacks_per_frame, int num_standard_memory_voices, int num_standard_streaming_voices, int num_hca_mx_memory_voices, int num_hca_mx_streaming_voices, int output_sampling_rate, int num_asr_output_channels, bool uses_in_game_preview, float server_frequency, int max_parameter_blocks, int categories_per_playback, int max_faders, int num_buses, bool use_ambisonics, IntPtr spatializer_core_interface); // 0x0000000186DDFF70-0x0000000186DE00C0
		private static extern void CRIWARE8384362B(uint max_preivew_objects, uint communication_buffer_size, int playback_position_update_interval); // 0x0000000185B00000-0x0000000185B00090
		private static extern void CRIWARE237CA5E3(bool enable_user_pcm_out_mode); // 0x0000000185AFF960-0x0000000185AFF9A0
		private static extern void CRIWARE780E6ED2(long buffering_time_pc); // 0x0000000185AFF8D0-0x0000000185AFF910
		private static extern void CRIWAREE996B258(int output, int pulse_latency_usec); // 0x0000000185AFFE60-0x0000000185AFFEA0
		private static extern void CRIWARE2F034134(bool enable_sonicsync, uint buffering_time_ios, bool override_ipod_music_ios); // 0x0000000185B00090-0x0000000185B00130
		private static extern void CRIWARE70981A20(bool enable_sonicsync, int num_low_delay_memory_voices, int num_low_delay_streaming_voices, int sound_buffering_time, int sound_start_buffering_time, bool apply_hw_property, int stream_type); // 0x0000000185B003F0-0x0000000185B004B0
		private static extern void CRIWARE2626EF5B(); // 0x0000000185AFFD00-0x0000000185AFFD30
		public static extern bool CRIWAREC176B113(); // 0x0000000185AFF320-0x0000000185AFF360
		private static extern void CRIWARE63E1F278(); // 0x0000000188C0607C-0x0000000188C060A8
		private static extern void CRIWAREB64E0C3B(bool pause); // 0x0000000188C06160-0x0000000188C06194
		public static extern uint CRIWAREA703719E(); // 0x0000000188C06134-0x0000000188C06160
		public static extern void CRIWAREBF97E87F(int code); // 0x0000000188C06194-0x0000000188C061C8
		public static extern void CRIWARE15B0037A(IntPtr cbfunc, string separator_string); // 0x0000000188C05E24-0x0000000188C05EBC
		public static extern void CRIWARE28E5ABA4(IntPtr cbfunc); // 0x0000000188C05EF0-0x0000000188C05F24
		private static extern void CRIWARECCA1268B(); // 0x0000000185FED080-0x0000000185FED0B0
		public static extern void CRIWARE88175F19(IntPtr cbfunc); // 0x0000000188C060D4-0x0000000188C06108
		private static extern void CRIWARE7581CF8C(); // 0x0000000185FED000-0x0000000185FED030
		public static extern void CRIWARE15F30D07(IntPtr cbfunc); // 0x0000000188C05EBC-0x0000000188C05EF0
		private static extern void CRIWARED1FD92AA(); // 0x0000000185FED100-0x0000000185FED130
		private static extern void CRIWARE2CFF30B7(int sampling_rate_for_memory, int sampling_rate_for_streaming); // 0x0000000188C05F24-0x0000000188C05F64
		public static extern void CRIWARE797E0462(); // 0x0000000188C060A8-0x0000000188C060D4
		public static extern void CRIWAREC54D0552(); // 0x0000000188C061C8-0x0000000188C061F4
		public static extern void CRIWARE5BC8942D(IntPtr acb_hn, CallbackFromNativeDelegate func, IntPtr obj); // 0x0000000188C05FDC-0x0000000188C0607C
		public static extern ushort CRIWARE5B1C5B3B(int id); // 0x0000000188C05F64-0x0000000188C05FDC
		private static extern bool CRIWAREE097EA6E(); // 0x0000000188C061F4-0x0000000188C06224
		private static extern int CRIWAREE320F01B(); // 0x0000000188C06224-0x0000000188C06250
		private static extern int CRIWARE98A6BE5C(); // 0x0000000188C06108-0x0000000188C06134
	}

	[Serializable]
	public class CriAtomCueSheet // TypeDefIndex: 84184
	{
		// Fields
		public string name; // 0x10
		public string acbFile; // 0x18
		public string awbFile; // 0x20
		public CriAtomExAcb acb; // 0x28
		public CriAtomExAcbLoader.Status loaderStatus; // 0x30
	
		// Properties
		public bool IsLoading { get; } // 0x0000000188BF639C-0x0000000188BF63A4 
		public bool IsError { get; } // 0x0000000188BF6380-0x0000000188BF639C 
	
		// Constructors
		public CriAtomCueSheet(); // 0x0000000188BF6318-0x0000000188BF6380
	}

	[AddComponentMenu("CRIWARE/CRI Atom")]
	public class CriAtom : CriMonoBehaviour // TypeDefIndex: 84188
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
		private static CriAtom instance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000188C0AF84-0x0000000188C0AFBC 0x0000000188C0B11C-0x0000000188C0B170
		public static bool CueSheetsAreLoading { get; } // 0x0000000188C0AEEC-0x0000000188C0AF84 
	
		// Events
		internal static event CriAtomExSequencer.EventCallback OnEventSequencerCallback {
			add; // 0x0000000188C0354C-0x0000000188C03554
			remove; // 0x0000000188C03554-0x0000000188C0355C
		}
		private static event CriAtomExBeatSync.CbFunc beatsyncUserCbFunc {
			add; // 0x0000000188C0AD8C-0x0000000188C0AE3C
			remove; // 0x0000000188C0AFBC-0x0000000188C0B06C
		}
		internal static event CriAtomExBeatSync.CbFunc OnBeatSyncCallback {
			add; // 0x0000000188BFFBC0-0x0000000188BFFBC8
			remove; // 0x0000000188BFFBC8-0x0000000188BFFBD0
		}
		private static event CriAtomEx.CueLinkCbFunc cueLinkUserCbFunc {
			add; // 0x0000000188C0AE3C-0x0000000188C0AEEC
			remove; // 0x0000000188C0B06C-0x0000000188C0B11C
		}
		internal static event CriAtomEx.CueLinkCbFunc OnCueLinkCallback {
			add; // 0x0000000188C040F0-0x0000000188C040F8
			remove; // 0x0000000188C04FBC-0x0000000188C04FC4
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 84185
		{
			// Fields
			public CriAtom __4__this; // 0x10
			public int i; // 0x18
			public Predicate<CriAtomCueSheet> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _MargeCueSheet_b__0(CriAtomCueSheet sheet); // 0x0000000188C0D114-0x0000000188C0D168
		}
	
		[CompilerGenerated]
		private sealed class _LoadAcbFileCoroutine_d__62 : IEnumerator<object> // TypeDefIndex: 84186
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _LoadAcbFileCoroutine_d__62(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000188C0CF08-0x0000000188C0CF80
			private bool MoveNext(); // 0x0000000188C0C8F4-0x0000000188C0CEBC
			private void __m__Finally1(); // 0x0000000188C0CF80-0x0000000188C0CFCC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188C0CEBC-0x0000000188C0CF08
		}
	
		[CompilerGenerated]
		private sealed class _LoadAcbDataCoroutine_d__64 : IEnumerator<object> // TypeDefIndex: 84187
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _LoadAcbDataCoroutine_d__64(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000188C0C830-0x0000000188C0C8A8
			private bool MoveNext(); // 0x0000000188C0C324-0x0000000188C0C7E4
			private void __m__Finally1(); // 0x0000000188C0C8A8-0x0000000188C0C8F4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188C0C7E4-0x0000000188C0C830
		}
	
		// Constructors
		public CriAtom(); // 0x0000000188C0AD08-0x0000000188C0AD8C
	
		// Methods
		public static void AttachDspBusSetting(string settingName); // 0x0000000188C093CC-0x0000000188C0944C
		public static void DetachDspBusSetting(); // 0x0000000188C09668-0x0000000188C096D4
		public static CriAtomCueSheet GetCueSheet(string name); // 0x0000000188C098B4-0x0000000188C098E0
		public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, CriFsBinder binder = null); // 0x0000000188C09320-0x0000000188C093CC
		public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, CriFsBinder binder = null, bool loadAwbOnMemory = false /* Metadata: 0x02644257 */); // 0x0000000188C09040-0x0000000188C090E8
		public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null); // 0x0000000188C09254-0x0000000188C09320
		public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null, bool loadAwbOnMemory = false /* Metadata: 0x02644258 */); // 0x0000000188C08F78-0x0000000188C09040
		public static void RemoveCueSheet(string name); // 0x0000000188C0A470-0x0000000188C0A4E8
		public static CriAtomExAcb GetAcb(string cueSheetName); // 0x0000000188C096D4-0x0000000188C097D0
		public static void SetCategoryVolume(string name, float volume); // 0x0000000188C00064-0x0000000188C0006C
		public static void SetCategoryVolume(int id, float volume); // 0x0000000188C0005C-0x0000000188C00064
		public static float GetCategoryVolume(string name); // 0x0000000188BFFFD8-0x0000000188BFFFE0
		public static float GetCategoryVolume(int id); // 0x0000000188BFFFE0-0x0000000188BFFFE8
		public static void SetBusAnalyzer(string busName, bool sw); // 0x0000000188C0A6A4-0x0000000188C0A6D4
		public static void SetBusAnalyzer(bool sw); // 0x0000000188C0A6D4-0x0000000188C0A700
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName); // 0x0000000188C097D0-0x0000000188C09800
		[Obsolete("Use CriAtom.GetBusAnalyzerInfo(string busName)")]
		public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId); // 0x0000000188C09800-0x0000000188C0982C
		public void Setup(); // 0x0000000188C0A814-0x0000000188C0AA44
		public void Shutdown(); // 0x0000000188C0AA44-0x0000000188C0AB44
		private void Awake(); // 0x0000000188C0944C-0x0000000188C095B8
		protected override void OnEnable(); // 0x0000000188C09F40-0x0000000188C09FB0
		private void OnDestroy(); // 0x0000000188C09E48-0x0000000188C09F40
		public override void CriInternalUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public CriAtomCueSheet GetCueSheetInternal(string name); // 0x0000000188C0982C-0x0000000188C098B4
		public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder); // 0x0000000188C090E8-0x0000000188C09254
		public void RemoveCueSheetInternal(string name); // 0x0000000188C0A2F4-0x0000000188C0A470
		private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet); // 0x0000000188C09C98-0x0000000188C09E48
		private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile); // 0x0000000188C09BA0-0x0000000188C09C98
		private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile); // 0x0000000188C099E4-0x0000000188C09A94
		private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory); // 0x0000000188C09A94-0x0000000188C09ADC
		[IteratorStateMachine(typeof(_LoadAcbFileCoroutine_d__62))]
		private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory); // 0x0000000188C09ADC-0x0000000188C09BA0
		private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory); // 0x0000000188C098E0-0x0000000188C09920
		[IteratorStateMachine(typeof(_LoadAcbDataCoroutine_d__64))]
		private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory); // 0x0000000188C09920-0x0000000188C099E4
		[AOT.MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCbFunc))]
		public static void SequenceEventCallbackFromNative(string eventString); // 0x0000000188C0A53C-0x0000000188C0A594
		[AOT.MonoPInvokeCallback(typeof(CriAtomExSequencer.EventCallback))]
		private static void SequenceCallbackFromNative(ref CriAtomExSequencer.CriAtomExSequenceEventInfo criAtomExSequenceInfo); // 0x0000000188C0A4E8-0x0000000188C0A53C
		[AOT.MonoPInvokeCallback(typeof(CriAtomExBeatSync.CbFunc))]
		public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info); // 0x0000000188C095B8-0x0000000188C09610
		[AOT.MonoPInvokeCallback(typeof(CriAtomEx.CueLinkCbFunc))]
		public static void CueLinkCallbackFromNative(ref CriAtomEx.CueLinkInfo info); // 0x0000000188C09610-0x0000000188C09668
		public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator); // 0x0000000188C0A700-0x0000000188C0A814
		private static void RegisterEventCallbackChain(CriAtomExSequencer.EventCallback func); // 0x0000000188C0A190-0x0000000188C0A2F4
		private static void UnregisterEventCallbackChain(CriAtomExSequencer.EventCallback func); // 0x0000000188C0AC1C-0x0000000188C0AD08
		public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func); // 0x0000000188C0A594-0x0000000188C0A6A4
		private static void RegisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func); // 0x0000000188C09FB0-0x0000000188C0A0A0
		private static void UnregisterBeatSyncCallbackChain(CriAtomExBeatSync.CbFunc func); // 0x0000000188C0AB44-0x0000000188C0ABB0
		private static void RegisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func); // 0x0000000188C0A0A0-0x0000000188C0A190
		private static void UnregisterCueLinkCallbackChain(CriAtomEx.CueLinkCbFunc func); // 0x0000000188C0ABB0-0x0000000188C0AC1C
	}

	[AddComponentMenu("CRIWARE/CRI Atom Listener")]
	public class CriAtomListener : CriMonoBehaviour // TypeDefIndex: 84189
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
		public CriAtomEx3dListener nativeListener { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public bool isActive { get; set; } // 0x000000018225DFF0-0x000000018225E000 0x0000000188C056C4-0x0000000188C05728
		public CriAtomRegion region3d { get; set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000188C05728-0x0000000188C058E4
	
		// Constructors
		public CriAtomListener(); // 0x0000000188C056B8-0x0000000188C056C4
		static CriAtomListener(); // 0x0000000187178D70-0x0000000187178E00
	
		// Methods
		public static void CreateDummyNativeListener(); // 0x0000000185B001E0-0x0000000185B002C0
		public static void DestroyDummyNativeListener(); // 0x0000000188C05294-0x0000000188C05334
		private void Awake(); // 0x0000000188C05168-0x0000000188C05284
		private void Start(); // 0x0000000188C0545C-0x0000000188C054C0
		protected override void OnEnable(); // 0x0000000188C05438-0x0000000188C0545C
		protected override void OnDisable(); // 0x0000000188C05414-0x0000000188C05438
		private void OnDestroy(); // 0x0000000188C05334-0x0000000188C05414
		public override void CriInternalUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void CriInternalLateUpdate(); // 0x0000000188C05284-0x0000000188C05294
		private void UpdatePosition(); // 0x0000000188C054C0-0x0000000188C056B8
		public void ActivateListener(bool exclusive = true /* Metadata: 0x02644259 */); // 0x0000000188C04FC4-0x0000000188C05168
	}

	public class CriAtomOutputDeviceObserver : CriMonoBehaviour // TypeDefIndex: 84193
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
		public static bool IsDeviceConnected { get; } // 0x0000000188C05D0C-0x0000000188C05D6C 
		public static OutputDeviceType DeviceType { get; } // 0x0000000188C05CAC-0x0000000188C05D0C 
	
		// Events
		public static event DeviceConnectionChangeCallback OnDeviceConnectionChanged {
			add; // 0x0000000188C05B58-0x0000000188C05BFC
			remove; // 0x0000000188C05D6C-0x0000000188C05D74
		}
		private static event DeviceConnectionChangeCallback _onDeviceConnectionChanged {
			add; // 0x0000000188C05BFC-0x0000000188C05CAC
			remove; // 0x0000000188C05D74-0x0000000188C05E24
		}
	
		// Nested types
		public enum OutputDeviceType // TypeDefIndex: 84190
		{
			BuiltinSpeaker = 0,
			WiredDevice = 1,
			WirelessDevice = 2
		}
	
		public delegate void DeviceConnectionChangeCallback(bool isConnected, OutputDeviceType deviceType); // TypeDefIndex: 84191; 0x00000001859B7730-0x00000001859B7740
	
		private static class UnsafeNativeMethods // TypeDefIndex: 84192
		{
		}
	
		// Constructors
		public CriAtomOutputDeviceObserver(); // 0x000000018722E9C0-0x000000018722E9D0
	
		// Methods
		private void Awake(); // 0x0000000188C058E4-0x0000000188C05A38
		private void OnDestroy(); // 0x0000000188C05AC0-0x0000000188C05B58
		public override void CriInternalUpdate(); // 0x0000000188C05A38-0x0000000188C05AC0
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("CRIWARE/CRI Atom Region")]
	[DisallowMultipleComponent]
	public class CriAtomRegion : CriMonoBehaviour // TypeDefIndex: 84194
	{
		// Fields
		[CompilerGenerated]
		private CriAtomEx3dRegion _region3dHn_k__BackingField; // 0x28
		internal List<CriAtomSourceBase> referringSources; // 0x30
		internal List<CriAtomListener> referringListeners; // 0x38
		internal List<CriAtomTransceiver> referringTransceivers; // 0x40
	
		// Properties
		public CriAtomEx3dRegion region3dHn { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
		// Constructors
		public CriAtomRegion(); // 0x0000000188C06E84-0x0000000188C06F98
	
		// Methods
		private void Awake(); // 0x0000000188C06BD0-0x0000000188C06BD8
		protected override void OnEnable(); // 0x0000000188C06E64-0x0000000188C06E84
		private void OnDestroy(); // 0x0000000188C06E5C-0x0000000188C06E64
		protected virtual void InternalInitialize(); // 0x0000000188C06DD8-0x0000000188C06E5C
		protected virtual void InternalFinalize(); // 0x0000000188C06C34-0x0000000188C06DD8
		protected virtual void InitializeParameters(); // 0x0000000188C06BD8-0x0000000188C06C34
		public override void CriInternalUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class CriAtomServer : CriMonoBehaviour // TypeDefIndex: 84195
	{
		// Fields
		private static CriAtomServer _instance; // 0x00
		public Action<bool> onApplicationPausePreProcess; // 0x28
		public Action<bool> onApplicationPausePostProcess; // 0x30
		public static bool KeepPlayingSoundOnPause; // 0x08
		public static bool EnableAutoConsumePcmOutput; // 0x09
	
		// Properties
		public static CriAtomServer instance { get; } // 0x0000000188C071A8-0x0000000188C071FC 
	
		// Constructors
		public CriAtomServer(); // 0x000000018722E9C0-0x000000018722E9D0
		static CriAtomServer(); // 0x00000001871D7650-0x00000001871D76D0
	
		// Methods
		public static void CreateInstance(); // 0x0000000185B012D0-0x0000000185B013B0
		public static void DestroyInstance(); // 0x0000000188C06F98-0x0000000188C0703C
		private void Awake(); // 0x0000000187105840-0x0000000187105940
		protected override void OnEnable(); // 0x0000000185B00980-0x0000000185B00990
		protected override void OnDisable(); // 0x0000000188C07044-0x0000000188C07100
		public override void CriInternalUpdate(); // 0x0000000185FECF60-0x0000000185FECFB0
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		private void ConsumePcmOutput(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnApplicationPause(bool appPause); // 0x0000000188C0703C-0x0000000188C07044
		private void ProcessApplicationPause(bool appPause); // 0x0000000188C07100-0x0000000188C071A8
	}

	[AddComponentMenu("CRIWARE/CRI Atom Source")]
	public class CriAtomSource : CriAtomSourceBase // TypeDefIndex: 84197
	{
		// Fields
		[SerializeField]
		private string _cueName; // 0xA0
		[SerializeField]
		private string _cueSheet; // 0xA8
	
		// Properties
		public string cueName { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public string cueSheet { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayAsync_d__11 : IEnumerator<object> // TypeDefIndex: 84196
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriAtomSource __4__this; // 0x20
			public string cueName; // 0x28
			private CriAtomExAcb _acb_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _PlayAsync_d__11(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188C0CFCC-0x0000000188C0D0C8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188C0D0C8-0x0000000188C0D114
		}
	
		// Constructors
		public CriAtomSource(); // 0x0000000188C08268-0x0000000188C082D0
	
		// Methods
		public override CriAtomExPlayback Play(); // 0x0000000188C08258-0x0000000188C08268
		protected override CriAtomExAcb GetAcb(); // 0x0000000188C08174-0x0000000188C081A0
		protected override void PlayOnStart(); // 0x0000000188C08218-0x0000000188C08258
		[IteratorStateMachine(typeof(_PlayAsync_d__11))]
		private IEnumerator PlayAsync(string cueName); // 0x0000000188C081A0-0x0000000188C08218
	}

	public abstract class CriAtomSourceBase : CriMonoBehaviour // TypeDefIndex: 84199
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
		public CriAtomExPlayer player { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public CriAtomEx3dSource source { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public bool playOnStart { get; set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018226ED70-0x000000018226ED80
		public bool use3dPositioning { get; set; } // 0x000000018226EFA0-0x000000018226EFB0 0x0000000188C0804C-0x0000000188C08084
		public bool freezeOrientation { get; set; } // 0x0000000187235D90-0x0000000187235DA0 0x0000000187235DE0-0x0000000187235DF0
		public bool use3dRandomization { get; set; } // 0x0000000187235DC0-0x0000000187235DD0 0x0000000188C08084-0x0000000188C08140
		public uint randomPositionListMaxLength { get; set; } // 0x0000000187233450-0x0000000187233460 0x0000000188C07DB8-0x0000000188C07E28
		public CriAtomRegion region3d { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x0000000188C07E28-0x0000000188C0801C
		public CriAtomListener listener { get; set; } // 0x0000000187232F70-0x0000000187232F80 0x0000000188C07C5C-0x0000000188C07D20
		public CriAtomRegion regionOnStart { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public CriAtomListener listenerOnStart { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public bool loop { get; set; } // 0x0000000187235DA0-0x0000000187235DB0 0x0000000187235DF0-0x0000000187235E00
		public float volume { get; set; } // 0x0000000187235DD0-0x0000000187235DE0 0x0000000188C08140-0x0000000188C08174
		public float pitch { get; set; } // 0x0000000187235DB0-0x0000000187235DC0 0x0000000188C07D80-0x0000000188C07DB8
		public float pan3dAngle { get; set; } // 0x0000000188C07B58-0x0000000188C07B80 0x0000000188C07D20-0x0000000188C07D50
		public float pan3dDistance { get; set; } // 0x0000000188C07B80-0x0000000188C07BA8 0x0000000188C07D50-0x0000000188C07D80
		public int startTime { get; set; } // 0x0000000188C07BA8-0x0000000188C07BD4 0x0000000188C0801C-0x0000000188C0804C
		public long time { get; } // 0x0000000188C07BFC-0x0000000188C07C20 
		public Status status { get; } // 0x0000000188C07BD4-0x0000000188C07BFC 
		public bool attenuationDistanceSetting { get; set; } // 0x0000000188C07B34-0x0000000188C07B58 0x0000000188C07C20-0x0000000188C07C5C
		public bool androidUseLowLatencyVoicePool { get; set; } // 0x000000018224EFC0-0x000000018224EFD0 0x000000018224EFD0-0x000000018224EFE0
	
		// Nested types
		public enum Status // TypeDefIndex: 84198
		{
			Stop = 0,
			Prep = 1,
			Playing = 2,
			PlayEnd = 3,
			Error = 4
		}
	
		// Constructors
		protected CriAtomSourceBase(); // 0x0000000188C07AD8-0x0000000188C07B34
	
		// Methods
		protected void SetNeedToPlayerUpdateAll(); // 0x0000000187235D80-0x0000000187235D90
		protected virtual void InternalInitialize(); // 0x0000000188C0733C-0x0000000188C07414
		protected virtual void InternalFinalize(); // 0x0000000188C072A0-0x0000000188C0733C
		private void Awake(); // 0x0000000188C07230-0x0000000188C07238
		protected override void OnEnable(); // 0x0000000188C07498-0x0000000188C074C4
		private void OnDestroy(); // 0x0000000188C07490-0x0000000188C07498
		protected bool SetInitialSourcePosition(); // 0x0000000188C077C0-0x0000000188C0784C
		protected virtual void SetInitialParameters(); // 0x0000000188C07708-0x0000000188C077C0
		protected virtual void UpdatePosition(); // 0x0000000188C0790C-0x0000000188C07AD8
		private void Start(); // 0x0000000188C0784C-0x0000000188C078F8
		public override void CriInternalUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void CriInternalLateUpdate(); // 0x0000000188C07238-0x0000000188C07280
		public abstract CriAtomExPlayback Play();
		protected abstract CriAtomExAcb GetAcb();
		protected abstract void PlayOnStart();
		public CriAtomExPlayback Play(string cueName); // 0x0000000188C074F4-0x0000000188C07568
		public CriAtomExPlayback Play(int cueId); // 0x0000000188C07568-0x0000000188C075D8
		protected CriAtomExPlayback InternalPlayCue(); // 0x0000000188C07414-0x0000000188C0746C
		public void Stop(); // 0x0000000188C078F8-0x0000000188C0790C
		public void Pause(bool sw); // 0x0000000188C074C4-0x0000000188C074F4
		public bool IsPaused(); // 0x0000000188C0746C-0x0000000188C07490
		public void SetBusSendLevel(string busName, float level); // 0x0000000188C076D8-0x0000000188C07708
		[Obsolete("Use CriAtomSource.SetBusSendLevel(string, float)")]
		public void SetBusSendLevel(int busId, float level); // 0x0000000188C076A8-0x0000000188C076D8
		public void SetBusSendLevelOffset(string busName, float levelOffset); // 0x0000000188C07678-0x0000000188C076A8
		[Obsolete("Use CriAtomSource.SetBusSendLevelOffset(string, float)")]
		public void SetBusSendLevelOffset(int busId, float levelOffset); // 0x0000000188C07648-0x0000000188C07678
		public void SetAisacControl(string controlName, float value); // 0x0000000188C075D8-0x0000000188C07608
		[Obsolete("Use CriAtomSource.SetAisacControl")]
		public void SetAisac(string controlName, float value); // 0x0000000188C07640-0x0000000188C07648
		public void SetAisacControl(uint controlId, float value); // 0x0000000188C07608-0x0000000188C07638
		[Obsolete("Use CriAtomSource.SetAisacControl")]
		public void SetAisac(uint controlId, float value); // 0x0000000188C07638-0x0000000188C07640
		public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer); // 0x0000000188C071FC-0x0000000188C07230
		public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer); // 0x0000000188C07280-0x0000000188C072A0
	}

	[AddComponentMenu("CRIWARE/CRI Atom Transceiver")]
	[DisallowMultipleComponent]
	public class CriAtomTransceiver : CriMonoBehaviour // TypeDefIndex: 84201
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
		public CriAtomEx3dTransceiver transceiverHn { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public Vector3 inputPos { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235E20-0x0000000187235E40 0x0000000187235E60-0x0000000187235E70
		public Vector3 inputFront { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235E00-0x0000000187235E20 0x0000000187235E50-0x0000000187235E60
		public Vector3 inputUp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234550-0x0000000187234570 0x0000000187234570-0x0000000187234580
		public CriAtomRegion region3d { get; set; } // 0x0000000187235E40-0x0000000187235E50 0x0000000188C08D9C-0x0000000188C08F78
	
		// Nested types
		private delegate void SetControlIdMethod(ushort id); // TypeDefIndex: 84200; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public CriAtomTransceiver(); // 0x0000000188C08C48-0x0000000188C08D9C
	
		// Methods
		private void Awake(); // 0x0000000188C08928-0x0000000188C08930
		private void Start(); // 0x0000000188C08ADC-0x0000000188C08B40
		protected override void OnEnable(); // 0x0000000188C08ABC-0x0000000188C08ADC
		private void OnDestroy(); // 0x0000000188C08AB4-0x0000000188C08ABC
		protected virtual void InternalInitialize(); // 0x0000000188C08A28-0x0000000188C08AB4
		protected virtual void InternalFinalize(); // 0x0000000188C089AC-0x0000000188C08A28
		protected virtual void InitializeParameters(); // 0x0000000188C08938-0x0000000188C089AC
		public override void CriInternalUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void CriInternalLateUpdate(); // 0x0000000188C08930-0x0000000188C08938
		private void ApplyCurrentPosition(); // 0x0000000188C082D0-0x0000000188C08608
		private void ApplyParameters(); // 0x0000000188C08608-0x0000000188C08928
		private void TrySetAisacControlId(string strId, SetControlIdMethod callback); // 0x0000000188C08B40-0x0000000188C08C48
	}

	public class CriStructMemory<Type> : IDisposable // TypeDefIndex: 84202
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

	public static class CriAtomEx // TypeDefIndex: 84232
	{
		// Fields
		public const uint InvalidAisacControlId = 4294967295; // Metadata: 0x02644262
		public static readonly Dictionary<Randomize3dCalcType, Randomize3dParamType[]> randomize3dParamTable; // 0x00
	
		// Events
		public static event CueLinkCbFunc OnCueLinkCallback {
			add; // 0x0000000188C040F0-0x0000000188C040F8
			remove; // 0x0000000188C04FBC-0x0000000188C04FC4
		}
	
		// Nested types
		public enum CharacterEncoding // TypeDefIndex: 84203
		{
			Utf8 = 0,
			Sjis = 1
		}
	
		public enum SoundRendererType // TypeDefIndex: 84204
		{
			Default = 0,
			Native = 1,
			Hw1 = 1,
			Asr = 2,
			Haptic = 3,
			Hw2 = 9
		}
	
		public enum VoiceAllocationMethod // TypeDefIndex: 84205
		{
			Once = 0,
			Retry = 1
		}
	
		public enum BiquadFilterType // TypeDefIndex: 84206
		{
			Off = 0,
			LowPass = 1,
			HighPass = 2,
			Notch = 3,
			LowShelf = 4,
			HighShelf = 5,
			Peaking = 6
		}
	
		public enum ResumeMode // TypeDefIndex: 84207
		{
			AllPlayback = 0,
			PausedPlayback = 1,
			PreparedPlayback = 2
		}
	
		public enum PanType // TypeDefIndex: 84208
		{
			Unknown = -1,
			Pan3d = 0,
			Pos3d = 1,
			Auto = 2
		}
	
		public enum VoiceControlMethod // TypeDefIndex: 84209
		{
			PreferLast = 0,
			PreferFirst = 1
		}
	
		public enum Parameter // TypeDefIndex: 84210
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
	
		public enum Speaker // TypeDefIndex: 84211
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
	
		public enum Format : uint // TypeDefIndex: 84212
		{
			ADX = 1,
			HCA = 3,
			HCA_MX = 4,
			WAVE = 5,
			RAW_PCM = 6,
			AUDIO_BUFFER = 9
		}
	
		private enum SpeakerSystem : uint // TypeDefIndex: 84213
		{
			Surround_5_1 = 0,
			Surround_7_1 = 1
		}
	
		public struct SpeakerAngles6ch // TypeDefIndex: 84214
		{
			// Fields
			public float frontLeft; // 0x00
			public float frontRight; // 0x04
			public float frontCenter; // 0x08
			public float lowFrequency; // 0x0C
			public float surroundLeft; // 0x10
			public float surroundRight; // 0x14
	
			// Methods
			public static SpeakerAngles6ch Default(); // 0x0000000187235EB0-0x0000000187235EE0
		}
	
		public struct SpeakerAngles8ch // TypeDefIndex: 84215
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
			public static SpeakerAngles8ch Default(); // 0x0000000187235EE0-0x0000000187235F20
		}
	
		public struct FormatInfo // TypeDefIndex: 84216
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
	
		public struct AisacControlInfo // TypeDefIndex: 84217
		{
			// Fields
			public readonly string name; // 0x00
			public uint id; // 0x08
	
			// Constructors
			public AisacControlInfo(byte[] data, int startIndex); // 0x0000000188BF5C20-0x0000000188BF5CC8
		}
	
		public enum Randomize3dCalcType // TypeDefIndex: 84218
		{
			None = -1,
			Rectangle = 0,
			Cuboid = 1,
			Circle = 2,
			Cylinder = 3,
			Sphere = 4,
			List = 6
		}
	
		public enum Randomize3dParamType // TypeDefIndex: 84219
		{
			None = 0,
			Width = 1,
			Depth = 2,
			Height = 3,
			Radius = 4
		}
	
		[Serializable]
		public struct Randomize3dConfig // TypeDefIndex: 84220
		{
			// Fields
			public const int NumOfCalcParams = 3; // Metadata: 0x026442C3
			[SerializeField]
			private bool followsOriginalSource; // 0x00
			[SerializeField]
			private Randomize3dCalcType calculationType; // 0x04
			[SerializeField]
			private float[] calculationParameters; // 0x08
	
			// Properties
			public bool FollowsOriginalSource { get; } // 0x00000001844AD2A0-0x00000001844AD2B0 
			public Randomize3dCalcType CalculationType { get; } // 0x00000001872342E0-0x00000001872342F0 
			public float CalculationParameter1 { get; } // 0x0000000188C0BFE0-0x0000000188C0C00C 
			public float CalculationParameter2 { get; } // 0x0000000188C0C00C-0x0000000188C0C038 
			public float CalculationParameter3 { get; } // 0x0000000188C0C038-0x0000000188C0C064 
	
			// Constructors
			internal Randomize3dConfig(byte[] data, int startIndex); // 0x0000000188C0BE7C-0x0000000188C0BF80
			public Randomize3dConfig(bool followsOriginalSource, Randomize3dCalcType calculationType, float param1 = 0f /* Metadata: 0x026442B3 */, float param2 = 0f /* Metadata: 0x026442B7 */, float param3 = 0f /* Metadata: 0x026442BB */); // 0x0000000188C0BDB0-0x0000000188C0BE7C
			public Randomize3dConfig(int dummy); // 0x0000000188C0BF80-0x0000000188C0BFE0
	
			// Methods
			public void ClearCalcParams(float initVal = 0f /* Metadata: 0x026442BF */); // 0x0000000188C0B9B8-0x0000000188C0BA00
			public bool GetParamByType(Randomize3dParamType paramType, ref float paramVal); // 0x0000000188C0BA00-0x0000000188C0BBD4
			public bool SetParamByType(Randomize3dParamType paramType, float paramVal); // 0x0000000188C0BBD4-0x0000000188C0BDB0
		}
	
		public struct CuePos3dInfo // TypeDefIndex: 84221
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
			public CuePos3dInfo(byte[] data, int startIndex); // 0x0000000188C0B4DC-0x0000000188C0B634
		}
	
		public struct GameVariableInfo // TypeDefIndex: 84222
		{
			// Fields
			public readonly string name; // 0x00
			public uint id; // 0x08
			public float gameValue; // 0x0C
	
			// Constructors
			public GameVariableInfo(byte[] data, int startIndex); // 0x0000000188C0B750-0x0000000188C0B80C
			public GameVariableInfo(string name, uint id, float gameValue); // 0x0000000188C0B80C-0x0000000188C0B830
		}
	
		public enum CueType // TypeDefIndex: 84223
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
	
		public struct CueInfo // TypeDefIndex: 84224
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
			public CueInfo(byte[] data, int startIndex); // 0x0000000188C0B170-0x0000000188C0B458
		}
	
		public struct WaveformInfo // TypeDefIndex: 84225
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
			public WaveformInfo(byte[] data, int startIndex); // 0x0000000188C0DAE8-0x0000000188C0DCA4
		}
	
		public struct AisacInfo // TypeDefIndex: 84226
		{
			// Fields
			public readonly string name; // 0x00
			public bool defaultControlFlag; // 0x08
			public float defaultControlValue; // 0x0C
			public uint controlId; // 0x10
			public readonly string controlName; // 0x18
	
			// Constructors
			public AisacInfo(byte[] data, int startIndex); // 0x0000000188BF5DBC-0x0000000188BF5EB0
		}
	
		public struct PerformanceInfo // TypeDefIndex: 84227
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
	
		public struct ResourceUsage // TypeDefIndex: 84228
		{
			// Fields
			public uint useCount; // 0x00
			public uint limit; // 0x04
		}
	
		public struct NativeVector // TypeDefIndex: 84229
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float z; // 0x08
	
			// Constructors
			public NativeVector(float x, float y, float z); // 0x0000000187235E80-0x0000000187235E90
			public NativeVector(Vector3 vector); // 0x0000000187235E90-0x0000000187235EB0
		}
	
		public struct CueLinkInfo // TypeDefIndex: 84230
		{
			// Fields
			public IntPtr nativePlayerHn; // 0x00
			public uint basePlaybackId; // 0x08
			public uint targetPlaybackId; // 0x0C
			public int cueLinkType; // 0x10
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void CueLinkCbFunc(ref CueLinkInfo info); // TypeDefIndex: 84231; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		static CriAtomEx(); // 0x0000000186D114C0-0x0000000186D11730
	
		// Methods
		public static void SetSpeakerAngle(SpeakerAngles6ch speakerAngle); // 0x0000000188C03F30-0x0000000188C03F80
		public static void SetSpeakerAngle(SpeakerAngles8ch speakerAngle); // 0x0000000188C03F80-0x0000000188C03FD0
		public static void SetVirtualSpeakerAngle(SpeakerAngles6ch speakerAngle); // 0x0000000188C03FD0-0x0000000188C04020
		public static void SetVirtualSpeakerAngle(SpeakerAngles8ch speakerAngle); // 0x0000000188C04020-0x0000000188C04070
		public static void ControlVirtualSpeakerSetting(bool sw); // 0x0000000188C03604-0x0000000188C03650
		public static void RegisterAcf(CriFsBinder binder, string acfPath); // 0x0000000188C03BC8-0x0000000188C03C30
		public static void RegisterAcf(IntPtr acfData, int dataSize); // 0x0000000188C03C30-0x0000000188C03C8C
		[Obsolete("Use RegisterAcf(IntPtr) instead")]
		public static void RegisterAcf(byte[] acfData); // 0x0000000188C03B6C-0x0000000188C03BC8
		public static void UnregisterAcf(); // 0x0000000188C040B0-0x0000000188C040F0
		public static string GetAppliedDspBusSnapshotName(); // 0x0000000188C036DC-0x0000000188C03744
		public static void AttachDspBusSetting(string settingName); // 0x0000000188C035B4-0x0000000188C03604
		public static void DetachDspBusSetting(); // 0x0000000188C03650-0x0000000188C03690
		public static void ApplyDspBusSnapshot(string snapshot_name, int time_ms); // 0x0000000188C0355C-0x0000000188C035B4
		public static int GetNumGameVariables(); // 0x0000000188C03A60-0x0000000188C03AA0
		public static bool GetGameVariableInfo(ushort index, out GameVariableInfo info); // 0x0000000188C037B0-0x0000000188C0398C
		public static float GetGameVariable(uint game_variable_id); // 0x0000000188C039D8-0x0000000188C03A20
		public static float GetGameVariable(string game_variable_name); // 0x0000000188C0398C-0x0000000188C039D8
		public static void SetGameVariable(uint game_variable_id, float game_variable_value); // 0x0000000188C03D28-0x0000000188C03D80
		public static void SetGameVariable(string game_variable_name, float game_variable_value); // 0x0000000188C03CCC-0x0000000188C03D28
		public static void SetRandomSeed(uint seed); // 0x0000000185AFF830-0x0000000185AFF880
		public static void ResetPerformanceMonitor(); // 0x0000000188C03C8C-0x0000000188C03CCC
		public static void GetPerformanceInfo(out PerformanceInfo info); // 0x0000000188C03AA0-0x0000000188C03AEC
		public static void SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index); // 0x0000000188C03D80-0x0000000188C03DDC
		public static void SetGlobalLabelToSelectorByName(string selector_name, string label_name); // 0x0000000188C03DDC-0x0000000188C03E38
		public static void Lock(); // 0x0000000188C03B2C-0x0000000188C03B6C
		public static void Unlock(); // 0x0000000188C04070-0x0000000188C040B0
		public static void SetOutputAudioDevice_PC(string deviceId); // 0x0000000188C03E38-0x0000000188C03EE0
		public static bool LoadAudioDeviceList_PC(); // 0x0000000188C03AEC-0x0000000188C03B2C
		public static int GetNumAudioDevices_PC(); // 0x0000000188C03A20-0x0000000188C03A60
		public static string GetAudioDeviceName_PC(int index); // 0x0000000188C03744-0x0000000188C037B0
		public static void SetOutputAudioDevice_PC(int index); // 0x0000000188C03EE0-0x0000000188C03F30
		public static void SetOutputVolume_VITA(float volume); // 0x0000000186805BA0-0x0000000186805BB0
		public static bool IsBgmPortAcquired_VITA(); // 0x00000001851A4410-0x00000001851A4420
		public static bool IsSoundStopped_IOS(); // 0x00000001843FFFF0-0x0000000184400000
		public static void EnableAudioSessionRestoration_IOS(bool flag); // 0x0000000186805BA0-0x0000000186805BB0
		public static void EnableBusSendOffsetWhenLevelNotExist(bool enable); // 0x0000000188C03690-0x0000000188C036DC
		private static extern bool criAtomEx_RegisterAcfFile(IntPtr binder, string path, IntPtr work, int workSize); // 0x0000000188C047D0-0x0000000188C04894
		private static extern void criAtomEx_RegisterAcfData(IntPtr acfData, int acfDataSize, IntPtr work, int workSize); // 0x0000000188C04684-0x0000000188C04724
		private static extern void criAtomEx_RegisterAcfData(byte[] acfData, int acfDataSize, IntPtr work, int workSize); // 0x0000000188C04724-0x0000000188C047D0
		private static extern void criAtomEx_UnregisterAcf(); // 0x0000000188C04BA0-0x0000000188C04C08
		private static extern void criAtomEx_AttachDspBusSetting(string settingName, IntPtr work, int workSize); // 0x0000000188C0427C-0x0000000188C04324
		private static extern void criAtomEx_DetachDspBusSetting(); // 0x0000000188C0439C-0x0000000188C04404
		private static extern void criAtomEx_ApplyDspBusSnapshot(string snapshot_name, int time_ms); // 0x0000000188C04228-0x0000000188C0427C
		private static extern IntPtr criAtomEx_GetAppliedDspBusSnapshotName(); // 0x0000000188C0447C-0x0000000188C044E4
		private static extern int criAtomEx_GetNumGameVariables(); // 0x0000000188C045F0-0x0000000188C0461C
		private static extern bool criAtomEx_GetGameVariableInfo(ushort index, IntPtr game_variable_info); // 0x0000000188C04564-0x0000000188C045F0
		private static extern float criAtomEx_GetGameVariableById(uint game_variable_id); // 0x0000000188C044E4-0x0000000188C04510
		private static extern float criAtomEx_GetGameVariableByName(string game_variable_name); // 0x0000000188C04510-0x0000000188C04564
		private static extern void criAtomEx_SetGameVariableById(uint game_variable_id, float game_variable_value); // 0x0000000188C04894-0x0000000188C048D0
		private static extern void criAtomEx_SetGameVariableByName(string game_variable_name, float game_variable_value); // 0x0000000188C048D0-0x0000000188C04928
		private static extern void criAtomEx_SetRandomSeed(uint seed); // 0x0000000185AFFF80-0x0000000185B00000
		private static extern void criAtomEx_Lock(); // 0x0000000188C0461C-0x0000000188C04684
		private static extern void criAtomEx_Unlock(); // 0x0000000188C04B38-0x0000000188C04BA0
		private static extern void criAtom_ResetPerformanceMonitor(); // 0x0000000188C04E44-0x0000000188C04EAC
		private static extern void criAtom_GetPerformanceInfo(out PerformanceInfo info); // 0x0000000188C04DCC-0x0000000188C04E44
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByIndex(ushort selector_index, ushort label_index); // 0x0000000188C040F8-0x0000000188C0417C
		private static extern void criAtomExAcf_SetGlobalLabelToSelectorByName(string selector_name, string label_name); // 0x0000000188C0417C-0x0000000188C04228
		private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array); // 0x0000000188C04928-0x0000000188C049AC
		private static extern void criAtomEx_SetSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array); // 0x0000000188C049AC-0x0000000188C04A30
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles6ch angle_array); // 0x0000000188C04A30-0x0000000188C04AB4
		private static extern void criAtomEx_SetVirtualSpeakerAngleArray(SpeakerSystem speaker_system, ref SpeakerAngles8ch angle_array); // 0x0000000188C04AB4-0x0000000188C04B38
		private static extern void criAtomEx_ControlVirtualSpeakerSetting(bool sw); // 0x0000000188C04324-0x0000000188C0439C
		private static extern void criAtomEx_EnableBusSendOffsetWhenLevelNotExist(bool enable); // 0x0000000188C04404-0x0000000188C0447C
		private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType soundRendererType, string deviceId); // 0x0000000188C04F30-0x0000000188C04FBC
		private static extern void criAtom_SetDeviceId_WASAPI(SoundRendererType type, IntPtr deviceId); // 0x0000000188C04EAC-0x0000000188C04F30
		private static extern bool criAtomUnity_LoadAudioDeviceList_PC(); // 0x0000000188C04D60-0x0000000188C04DCC
		private static extern int criAtomUnity_GetNumAudioDevices_PC(); // 0x0000000188C04CF8-0x0000000188C04D60
		private static extern IntPtr criAtomUnity_GetAudioDeviceName_PC(int index); // 0x0000000188C04C80-0x0000000188C04CF8
		private static extern IntPtr criAtomUnity_GetAudioDeviceId_PC(int index); // 0x0000000188C04C08-0x0000000188C04C80
	}

	public static class CriAtomExCategory // TypeDefIndex: 84246
	{
		// Nested types
		public enum ReactType // TypeDefIndex: 84233
		{
			Ducker = 0,
			AisacModulationTrigger = 1
		}
	
		public enum ReactDuckerTargetType // TypeDefIndex: 84234
		{
			Volume = 0,
			AisacControlValue = 1
		}
	
		public enum ReactDuckerCurveType // TypeDefIndex: 84235
		{
			Linear = 0,
			Square = 1,
			SquareReverse = 2,
			SCurve = 3,
			FlatAtHalf = 4
		}
	
		public struct ReactFadeParameter // TypeDefIndex: 84236
		{
			// Fields
			public ReactDuckerCurveType curveType; // 0x00
			public float curveStrength; // 0x04
			public ushort fadeTimeMs; // 0x08
		}
	
		public enum ReactHoldType // TypeDefIndex: 84237
		{
			WhilePlaying = 0,
			FixedTime = 1
		}
	
		public struct ReactDuckerParameter // TypeDefIndex: 84241
		{
			// Fields
			public Target target; // 0x00
			public ReactDuckerTargetType targetType; // 0x08
			public ReactFadeParameter entry; // 0x0C
			public ReactFadeParameter exit; // 0x18
			public ReactHoldType holdType; // 0x24
			public ushort holdTimeMs; // 0x28
	
			// Nested types
			public struct Volume // TypeDefIndex: 84238
			{
				// Fields
				public float level; // 0x00
			}
	
			public struct AisacControl // TypeDefIndex: 84239
			{
				// Fields
				public uint id; // 0x00
				public float value; // 0x04
			}
	
			public struct Target // TypeDefIndex: 84240
			{
				// Fields
				public CriWare.CriAtomExCategory.ReactDuckerParameter.Volume volume; // 0x00
				public AisacControl aisacControl; // 0x00
			}
		}
	
		public struct ReactAisacModulationParameter // TypeDefIndex: 84242
		{
			// Fields
			private int _enableDecrementAisacModulationKey; // 0x00
			public uint decrementAisacModulationKey; // 0x04
			private int _enableIncrementAisacModulationKey; // 0x08
			public uint incrementAisacModulationKey; // 0x0C
	
			// Properties
			public bool enableDecrementAisacModulationKey { get; } // 0x0000000188C0C064-0x0000000188C0C06C 
			public bool enableIncrementAisacModulationKey { get; } // 0x0000000188C0C06C-0x0000000188C0C074 
		}
	
		public struct ReactParameter // TypeDefIndex: 84244
		{
			// Fields
			public Parameter parameter; // 0x00
			public ReactType type; // 0x2C
			public bool enablePausingCue; // 0x30
	
			// Nested types
			public struct Parameter // TypeDefIndex: 84243
			{
				// Fields
				public ReactDuckerParameter ducker; // 0x00
				public ReactAisacModulationParameter aisacModulation; // 0x00
			}
		}
	
		public enum ReactStatus // TypeDefIndex: 84245
		{
			Stop = 0,
			FadeOut = 1,
			Hold = 2,
			FadeIn = 3,
			Error = 4
		}
	
		// Methods
		public static void SetVolume(string name, float volume); // 0x0000000188C00064-0x0000000188C0006C
		public static void SetVolume(int id, float volume); // 0x0000000188C0005C-0x0000000188C00064
		public static float GetVolume(string name); // 0x0000000188BFFFD8-0x0000000188BFFFE0
		public static float GetVolume(int id); // 0x0000000188BFFFE0-0x0000000188BFFFE8
		public static void Mute(string name, bool mute); // 0x0000000188C00018-0x0000000188C00020
		public static void Mute(int id, bool mute); // 0x0000000188C00020-0x0000000188C00028
		public static bool IsMuted(string name); // 0x0000000188BFFFF0-0x0000000188BFFFF8
		public static bool IsMuted(int id); // 0x0000000188BFFFE8-0x0000000188BFFFF0
		public static void Solo(string name, bool solo, float muteVolume); // 0x0000000188C00074-0x0000000188C0007C
		public static void Solo(int id, bool solo, float muteVolume); // 0x0000000188C0006C-0x0000000188C00074
		public static bool IsSoloed(string name); // 0x0000000188C00010-0x0000000188C00018
		public static bool IsSoloed(int id); // 0x0000000188C00008-0x0000000188C00010
		public static void Pause(string name, bool pause); // 0x0000000188C00028-0x0000000188C00030
		public static void Pause(int id, bool pause); // 0x0000000188C00030-0x0000000188C00038
		public static bool IsPaused(string name); // 0x0000000188BFFFF8-0x0000000188C00000
		public static bool IsPaused(int id); // 0x0000000188C00000-0x0000000188C00008
		public static void SetAisacControl(string name, string controlName, float value); // 0x0000000188C00040-0x0000000188C00048
		[Obsolete("Use CriAtomExCategory.SetAisacControl")]
		public static void SetAisac(string name, string controlName, float value); // 0x0000000188C00040-0x0000000188C00048
		public static void SetAisacControl(int id, int controlId, float value); // 0x0000000188C00038-0x0000000188C00040
		[Obsolete("Use CriAtomExCategory.SetAisacControl")]
		public static void SetAisac(int id, int controlId, float value); // 0x0000000188C00038-0x0000000188C00040
		public static void SetReactParameter(string name, ReactParameter parameter); // 0x0000000188C00048-0x0000000188C0005C
		public static bool GetReactParameter(string name, out ReactParameter parameter); // 0x0000000188BFFFC8-0x0000000188BFFFD0
		public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo); // 0x0000000188BFFBD0-0x0000000188BFFDC0
		public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo); // 0x0000000188BFFDC0-0x0000000188BFFFC0
		public static bool GetCurrentAisacControlValue(string categoryName, string aisacControlName, out float controlValue); // 0x0000000188BFFFC0-0x0000000188BFFFC8
		public static ReactStatus GetReactStatus(string reactName); // 0x0000000188BFFFD0-0x0000000188BFFFD8
		private static extern void criAtomExCategory_SetVolumeByName(string name, float volume); // 0x0000000188C00AE4-0x0000000188C00B34
		private static extern float criAtomExCategory_GetVolumeByName(string name); // 0x0000000188C00430-0x0000000188C00484
		private static extern void criAtomExCategory_SetVolumeById(int id, float volume); // 0x0000000188C00AA8-0x0000000188C00AE4
		private static extern float criAtomExCategory_GetVolumeById(int id); // 0x0000000188C00404-0x0000000188C00430
		private static extern void criAtomExCategory_MuteById(int id, bool mute); // 0x0000000188C006C4-0x0000000188C00748
		private static extern bool criAtomExCategory_IsMutedById(int id); // 0x0000000188C00484-0x0000000188C004FC
		private static extern void criAtomExCategory_MuteByName(string name, bool mute); // 0x0000000188C00748-0x0000000188C007E0
		private static extern bool criAtomExCategory_IsMutedByName(string name); // 0x0000000188C004FC-0x0000000188C0059C
		private static extern void criAtomExCategory_SoloById(int id, bool solo, float volume); // 0x0000000188C00B34-0x0000000188C00B7C
		private static extern bool criAtomExCategory_IsSoloedById(int id); // 0x0000000188C00630-0x0000000188C00668
		private static extern void criAtomExCategory_SoloByName(string name, bool solo, float volume); // 0x0000000188C00B7C-0x0000000188C00BDC
		private static extern bool criAtomExCategory_IsSoloedByName(string name); // 0x0000000188C00668-0x0000000188C006C4
		private static extern void criAtomExCategory_PauseById(int id, bool pause); // 0x0000000188C007E0-0x0000000188C00864
		private static extern bool criAtomExCategory_IsPausedById(int id); // 0x0000000188C0059C-0x0000000188C005D4
		private static extern void criAtomExCategory_PauseByName(string name, bool pause); // 0x0000000188C00864-0x0000000188C008BC
		private static extern bool criAtomExCategory_IsPausedByName(string name); // 0x0000000188C005D4-0x0000000188C00630
		private static extern void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value); // 0x0000000188C008BC-0x0000000188C00908
		private static extern void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value); // 0x0000000188C00908-0x0000000188C0097C
		private static extern void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter); // 0x0000000188C0097C-0x0000000188C00AA8
		private static extern bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter); // 0x0000000188C0028C-0x0000000188C003AC
		private static extern bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo); // 0x0000000188C0007C-0x0000000188C00110
		private static extern bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo); // 0x0000000188C00110-0x0000000188C001C4
		private static extern bool criAtomExCategory_GetCurrentAisacControlValueByName(string category_name, string aisac_control_name, out float control_value); // 0x0000000188C001C4-0x0000000188C0028C
		private static extern ReactStatus criAtomExCategory_GetReactStatus(string react_name); // 0x0000000188C003AC-0x0000000188C00404
	}

	public static class CriAtomExSequencer // TypeDefIndex: 84250
	{
		// Events
		public static event EventCallback OnCallback {
			add; // 0x0000000188C0354C-0x0000000188C03554
			remove; // 0x0000000188C03554-0x0000000188C0355C
		}
	
		// Nested types
		public struct CriAtomExSequenceEventInfo // TypeDefIndex: 84247
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
		public delegate void EventCbFunc(string eventParamsString); // TypeDefIndex: 84248; 0x0000000185B78EA0-0x0000000185B78EB0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void EventCallback(ref CriAtomExSequenceEventInfo criAtomExSequenceInfo); // TypeDefIndex: 84249; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		[Obsolete("SetEventCallback is deprecated. Use CriAtomExSequencer.OnCallback event", false)]
		public static void SetEventCallback(EventCbFunc func, string separator = "\t" /* Metadata: 0x026442DD */); // 0x0000000188C03544-0x0000000188C0354C
	}

	public static class CriAtomExBeatSync // TypeDefIndex: 84253
	{
		// Events
		public static event CbFunc OnCallback {
			add; // 0x0000000188BFFBC0-0x0000000188BFFBC8
			remove; // 0x0000000188BFFBC8-0x0000000188BFFBD0
		}
	
		// Nested types
		public struct Info // TypeDefIndex: 84251
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
		public delegate void CbFunc(ref Info info); // TypeDefIndex: 84252; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		[Obsolete("SetCallback is deprecated. Use OnBeatSyncCallback event", false)]
		public static void SetCallback(CbFunc func); // 0x0000000188BFFBB8-0x0000000188BFFBC0
	}

	public class CriAtomExAsr // TypeDefIndex: 84256
	{
		// Nested types
		private struct BusAnalyzerConfig // TypeDefIndex: 84254
		{
			// Fields
			public int interval; // 0x00
			public int peakHoldTime; // 0x04
		}
	
		public struct BusAnalyzerInfo // TypeDefIndex: 84255
		{
			// Fields
			public int numChannels; // 0x00
			public float[] rmsLevels; // 0x08
			public float[] peakLevels; // 0x10
			public float[] peakHoldLevels; // 0x18
	
			// Constructors
			public BusAnalyzerInfo(byte[] data); // 0x0000000188BF5EB0-0x0000000188BF60E0
		}
	
		// Constructors
		public CriAtomExAsr(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void AttachBusAnalyzer(string busName, int interval, int peakHoldTime); // 0x0000000188BFE820-0x0000000188BFE840
		public static void AttachBusAnalyzer(int interval, int peakHoldTime); // 0x0000000188BFE7F4-0x0000000188BFE820
		public static void DetachBusAnalyzer(string busName); // 0x0000000188BFE840-0x0000000188BFE848
		public static void DetachBusAnalyzer(); // 0x0000000188BFE848-0x0000000188BFE868
		public static void GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info); // 0x0000000188BFEA30-0x0000000188BFEBF0
		[Obsolete("Use CriAtomExAsr.GetBusAnalyzerInfo(string busName, out BusAnalyzerInfo info)")]
		public static void GetBusAnalyzerInfo(int busId, out BusAnalyzerInfo info); // 0x0000000188BFE868-0x0000000188BFEA30
		public static void SetBusVolume(string busName, float volume); // 0x0000000188BFEC38-0x0000000188BFEC40
		[Obsolete("Use CriAtomExAsr.SetBusVolume(string busName, float volume)")]
		public static void SetBusVolume(int busId, float volume); // 0x0000000188BFEC40-0x0000000188BFEC48
		public static void SetBusSendLevel(string busName, string sendTo, float level); // 0x0000000188BFEC30-0x0000000188BFEC38
		[Obsolete("Use CriAtomExAsr.SetBusSendLevel(string busName, string sendTo, float level)")]
		public static void SetBusSendLevel(int busId, int sendTo, float level); // 0x0000000188BFEC28-0x0000000188BFEC30
		public static void SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix); // 0x0000000188BFEC18-0x0000000188BFEC28
		[Obsolete("Use CriAtomExAsr.SetBusMatrix(string busName, int inputChannels, int outputChannels, float[] matrix)")]
		public static void SetBusMatrix(int busId, int inputChannels, int outputChannels, float[] matrix); // 0x0000000188BFEC08-0x0000000188BFEC18
		public static void SetEffectBypass(string busName, string effectName, bool bypass); // 0x0000000188BFEC48-0x0000000188BFEC50
		public static void SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue); // 0x0000000188BFEC50-0x0000000188BFEC88
		public static float GetEffectParameter(string busName, string effectName, uint parameterIndex); // 0x0000000188BFEBF8-0x0000000188BFEC00
		public static bool RegisterEffectInterface(IntPtr afx_interface); // 0x0000000188BFEC00-0x0000000188BFEC08
		public static void UnregisterEffectInterface(IntPtr afx_interface); // 0x0000000188BFEC88-0x0000000188BFEC90
		public static void GetBusVolume(string busName, out float volume); // 0x0000000188BFEBF0-0x0000000188BFEBF8
		public static int GetPcmOutput(int outputChannels, int outputSamples, float[][] buffer); // 0x0000000185829EC0-0x0000000185829ED0
		public static int GetNumBufferedPcmOutputSamples(); // 0x0000000185829EC0-0x0000000185829ED0
		public static void SetPcmBufferSize(int numSamples); // 0x0000000186805BA0-0x0000000186805BB0
		private static extern void criAtomExAsr_AttachBusAnalyzerByName(string busName, ref BusAnalyzerConfig config); // 0x0000000188BFEC90-0x0000000188BFED28
		private static extern void criAtomExAsr_AttachBusAnalyzer(int busNo, ref BusAnalyzerConfig config); // 0x0000000188BFED28-0x0000000188BFEDAC
		private static extern void criAtomExAsr_DetachBusAnalyzerByName(string busName); // 0x0000000188BFEDAC-0x0000000188BFEE38
		private static extern void criAtomExAsr_DetachBusAnalyzer(int busNo); // 0x0000000188BFEE38-0x0000000188BFEEB0
		private static extern void criAtomExAsr_GetBusAnalyzerInfoByName(string busName, IntPtr info); // 0x0000000188BFEEB0-0x0000000188BFEF48
		private static extern void criAtomExAsr_GetBusAnalyzerInfo(int busNo, IntPtr info); // 0x0000000188BFEF48-0x0000000188BFEFCC
		private static extern void criAtomExAsr_SetBusVolumeByName(string busName, float volume); // 0x0000000188BFF348-0x0000000188BFF3A0
		private static extern void criAtomExAsr_SetBusVolume(int busNo, float volume); // 0x0000000188BFF3A0-0x0000000188BFF3DC
		private static extern void criAtomExAsr_SetBusSendLevelByName(string busName, string sendtoName, float level); // 0x0000000188BFF28C-0x0000000188BFF300
		private static extern void criAtomExAsr_SetBusSendLevel(int busNo, int sendtoNo, float level); // 0x0000000188BFF300-0x0000000188BFF348
		private static extern void criAtomExAsr_SetBusMatrixByName(string busName, int inputChannels, int outputChannels, float[] matrix); // 0x0000000188BFF124-0x0000000188BFF1E4
		private static extern void criAtomExAsr_SetBusMatrix(int busNo, int inputChannels, int outputChannels, float[] matrix); // 0x0000000188BFF1E4-0x0000000188BFF28C
		private static extern void criAtomExAsr_SetEffectBypass(string busName, string effectName, bool bypass); // 0x0000000188BFF3DC-0x0000000188BFF498
		private static extern void criAtomExAsr_UpdateEffectParameters(string busName, string effectName); // 0x0000000188BFF550-0x0000000188BFF5FC
		private static extern void criAtomExAsr_SetEffectParameter(string busName, string effectName, uint parameterIndex, float parameterValue); // 0x0000000188BFF498-0x0000000188BFF51C
		private static extern float criAtomExAsr_GetEffectParameter(string busName, string effectName, uint parameterIndex); // 0x0000000188BFF064-0x0000000188BFF0EC
		private static extern bool criAtomExAsr_RegisterEffectInterface(IntPtr afx_interface); // 0x0000000188BFF0EC-0x0000000188BFF124
		private static extern void criAtomExAsr_UnregisterEffectInterface(IntPtr afx_interface); // 0x0000000188BFF51C-0x0000000188BFF550
		private static extern void criAtomExAsr_GetBusVolumeByName(string busName, out float volume); // 0x0000000188BFEFCC-0x0000000188BFF064
	}

	public static class CriAtomExLatencyEstimator // TypeDefIndex: 84259
	{
		// Nested types
		public enum Status // TypeDefIndex: 84257
		{
			Stop = 0,
			Processing = 1,
			Done = 2,
			Error = 3
		}
	
		public struct EstimatorInfo // TypeDefIndex: 84258
		{
			// Fields
			public Status status; // 0x00
			public uint estimated_latency; // 0x04
		}
	
		// Methods
		public static void InitializeModule(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void FinalizeModule(); // 0x0000000186805BA0-0x0000000186805BB0
		public static EstimatorInfo GetCurrentInfo(); // 0x0000000187235D70-0x0000000187235D80
	}

	public class CriAtomEx3dListener : CriDisposable // TypeDefIndex: 84261
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		public struct Config // TypeDefIndex: 84260
		{
			// Fields
			public int reserved; // 0x00
		}
	
		// Constructors
		public CriAtomEx3dListener(); // 0x0000000185B002C0-0x0000000185B00350
	
		// Methods
		public override void Dispose(); // 0x0000000188BF63A4-0x0000000188BF63B0
		private void Dispose(bool disposing); // 0x0000000188BF63B0-0x0000000188BF6440
		public void Update(); // 0x0000000188BF6734-0x0000000188BF6748
		public void ResetParameters(); // 0x0000000188BF64C4-0x0000000188BF64D8
		public void SetPosition(float x, float y, float z); // 0x0000000188BF66CC-0x0000000188BF6700
		public void SetVelocity(float x, float y, float z); // 0x0000000188BF6700-0x0000000188BF6734
		public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz); // 0x0000000188BF6670-0x0000000188BF66CC
		[Obsolete("Use SetDopplerMultiplier instead")]
		public void SetDistanceFactor(float distanceFactor); // 0x0000000188BF6518-0x0000000188BF65A8
		public void SetDopplerMultiplier(float dopplerMultiplier); // 0x0000000188BF65BC-0x0000000188BF663C
		public void SetFocusPoint(float x, float y, float z); // 0x0000000188BF663C-0x0000000188BF6670
		public void SetDistanceFocusLevel(float distanceFocusLevel); // 0x0000000188BF65A8-0x0000000188BF65BC
		public void SetDirectionFocusLevel(float directionFocusLevel); // 0x0000000188BF6504-0x0000000188BF6518
		public void Set3dRegion(CriAtomEx3dRegion region3d); // 0x0000000188BF64D8-0x0000000188BF6504
		public bool IsDestroyable(); // 0x0000000188BF64B8-0x0000000188BF64C4
		~CriAtomEx3dListener(); // 0x0000000188BF6440-0x0000000188BF64B8
		private static extern IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size); // 0x0000000185B00350-0x0000000185B003F0
		private static extern void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener); // 0x0000000188BF6748-0x0000000188BF677C
		private static extern void criAtomEx3dListener_Update(IntPtr ex_3d_listener); // 0x0000000188BF6B10-0x0000000188BF6B44
		private static extern void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener); // 0x0000000188BF67F8-0x0000000188BF682C
		private static extern void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector position); // 0x0000000188BF6A88-0x0000000188BF6ACC
		private static extern void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector velocity); // 0x0000000188BF6ACC-0x0000000188BF6B10
		private static extern void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x0000000188BF69F4-0x0000000188BF6A88
		private static extern void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor); // 0x0000000188BF68AC-0x0000000188BF68F0
		private static extern void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier); // 0x0000000188BF692C-0x0000000188BF6970
		private static extern void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomEx.NativeVector focus_point); // 0x0000000188BF6970-0x0000000188BF69F4
		private static extern void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level); // 0x0000000188BF68F0-0x0000000188BF692C
		private static extern void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level); // 0x0000000188BF6870-0x0000000188BF68AC
		private static extern bool criAtomEx3dListener_IsDestroyable(IntPtr ex_3d_listener); // 0x0000000188BF677C-0x0000000188BF67F8
		private static extern void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region); // 0x0000000188BF682C-0x0000000188BF6870
	}

	public class CriAtomEx3dSource : CriDisposable // TypeDefIndex: 84263
	{
		// Fields
		private uint currentRandomPositionListMaxLength; // 0x20
		private IntPtr handle; // 0x28
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Nested types
		public struct Config // TypeDefIndex: 84262
		{
			// Fields
			public bool enableVoicePriorityDecay; // 0x00
			public uint randomPositionListMaxLength; // 0x04
	
			// Constructors
			public Config(bool enableVoicePriorityDecay, uint randomPositionListMaxLength); // 0x0000000187235CF0-0x0000000187235D00
		}
	
		// Constructors
		public CriAtomEx3dSource(bool enableVoicePriorityDecay = false /* Metadata: 0x026442E3 */, uint randomPositionListMaxLength = 0 /* Metadata: 0x026442E4 */); // 0x0000000188BF71C4-0x0000000188BF7260
	
		// Methods
		public override void Dispose(); // 0x0000000188BF6CD4-0x0000000188BF6CE0
		private void Dispose(bool disposing); // 0x0000000188BF6CE0-0x0000000188BF6D70
		public void Update(); // 0x0000000188BF71B8-0x0000000188BF71C4
		public void ResetParameters(); // 0x0000000188BF6E34-0x0000000188BF6E40
		public void SetPosition(float x, float y, float z); // 0x0000000188BF6F4C-0x0000000188BF6F78
		public void SetVelocity(float x, float y, float z); // 0x0000000188BF7180-0x0000000188BF71AC
		public void SetOrientation(Vector3 front, Vector3 top); // 0x0000000188BF6EEC-0x0000000188BF6F4C
		[Obsolete("Use CriAtomEx3dSource.SetOrientation instead")]
		public void SetConeOrientation(float x, float y, float z); // 0x0000000188BF6E64-0x0000000188BF6E90
		public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume); // 0x0000000188BF6E90-0x0000000188BF6EA4
		public void SetMinMaxDistance(float minDistance, float maxDistance); // 0x0000000188BF6EE0-0x0000000188BF6EEC
		public void SetInteriorPanField(float sourceRadius, float interiorDistance); // 0x0000000188BF6EBC-0x0000000188BF6EC8
		public void SetDopplerFactor(float dopplerFactor); // 0x0000000188BF6EB0-0x0000000188BF6EBC
		public void SetVolume(float volume); // 0x0000000188BF71AC-0x0000000188BF71B8
		public void SetMaxAngleAisacDelta(float maxDelta); // 0x0000000188BF6ED4-0x0000000188BF6EE0
		public void SetAttenuationDistanceSetting(bool flag); // 0x0000000188BF6E58-0x0000000188BF6E64
		public bool GetAttenuationDistanceSetting(); // 0x0000000188BF6DE8-0x0000000188BF6DF4
		public void SetRandomPositionConfig(CriAtomEx.Randomize3dConfig? config); // 0x0000000188BF6F78-0x0000000188BF702C
		public void SetRandomPositionList(Vector3[] positionList); // 0x0000000188BF702C-0x0000000188BF7174
		public void Set3dRegion(CriAtomEx3dRegion region3d); // 0x0000000188BF6E40-0x0000000188BF6E58
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId); // 0x0000000188BF6EC8-0x0000000188BF6ED4
		public void SetSourceBasedElevationAngleAisacControlId(ushort aisacControlId); // 0x0000000188BF7174-0x0000000188BF7180
		public void SetDistanceAisacControlId(ushort aisacControlId); // 0x0000000188BF6EA4-0x0000000188BF6EB0
		public bool IsDestroyable(); // 0x0000000188BF6E28-0x0000000188BF6E34
		public CriAtomEx.NativeVector GetPosition(); // 0x0000000188BF6DF4-0x0000000188BF6E28
		~CriAtomEx3dSource(); // 0x0000000188BF6D70-0x0000000188BF6DE8
		private static extern IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size); // 0x0000000188BF7260-0x0000000188BF7328
		private static extern void criAtomEx3dSource_Destroy(IntPtr ex_3d_source); // 0x0000000188BF7328-0x0000000188BF735C
		private static extern void criAtomEx3dSource_Update(IntPtr ex_3d_source); // 0x0000000188BF7D04-0x0000000188BF7D7C
		private static extern void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source); // 0x0000000188BF74EC-0x0000000188BF7564
		private static extern void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomEx.NativeVector position); // 0x0000000188BF79C4-0x0000000188BF7A08
		private static extern void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomEx.NativeVector velocity); // 0x0000000188BF7C84-0x0000000188BF7CC8
		private static extern void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x0000000188BF7930-0x0000000188BF79C4
		private static extern void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomEx.NativeVector cone_orient); // 0x0000000188BF762C-0x0000000188BF76B0
		private static extern void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume); // 0x0000000188BF76B0-0x0000000188BF7710
		private static extern void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance); // 0x0000000188BF78E4-0x0000000188BF7930
		private static extern void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance); // 0x0000000188BF77D0-0x0000000188BF781C
		private static extern void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor); // 0x0000000188BF7794-0x0000000188BF77D0
		private static extern void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume); // 0x0000000188BF7CC8-0x0000000188BF7D04
		private static extern void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta); // 0x0000000188BF78A0-0x0000000188BF78E4
		private static extern void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag); // 0x0000000188BF75A8-0x0000000188BF762C
		private static extern bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source); // 0x0000000188BF735C-0x0000000188BF73D8
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref CriAtomEx.Randomize3dConfig config); // 0x0000000188BF7A8C-0x0000000188BF7B60
		private static extern void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config); // 0x0000000188BF7A08-0x0000000188BF7A8C
		private static extern void criAtomEx3dSource_SetRandomPositionList(IntPtr ex_3d_source, CriAtomEx.NativeVector[] position_list, uint length); // 0x0000000188BF7B60-0x0000000188BF7C00
		private static extern void criAtomEx3dSource_SetDistanceAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x0000000188BF7710-0x0000000188BF7794
		private static extern bool criAtomEx3dSource_IsDestroyable(IntPtr ex_3d_source); // 0x0000000188BF7470-0x0000000188BF74EC
		private static extern CriAtomEx.NativeVector criAtomEx3dSource_GetPosition(IntPtr ex_3d_source); // 0x0000000188BF73D8-0x0000000188BF7470
		private static extern void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region); // 0x0000000188BF7564-0x0000000188BF75A8
		private static extern void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x0000000188BF781C-0x0000000188BF78A0
		private static extern void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id); // 0x0000000188BF7C00-0x0000000188BF7C84
	}

	public class CriAtomEx3dTransceiver : CriDisposable // TypeDefIndex: 84266
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		public struct Config // TypeDefIndex: 84264
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private static class UnsafeNativeMethods // TypeDefIndex: 84265
		{
			// Methods
			internal static extern IntPtr criAtomEx3dTransceiver_Create(ref Config config, IntPtr work, int work_size); // 0x0000000188C0D288-0x0000000188C0D31C
			internal static extern void criAtomEx3dTransceiver_Destroy(IntPtr ex_3d_transceiver); // 0x0000000188C0D31C-0x0000000188C0D350
			internal static extern void criAtomEx3dTransceiver_Update(IntPtr ex_3d_transceiver); // 0x0000000188C0DAB4-0x0000000188C0DAE8
			internal static extern void criAtomEx3dTransceiver_SetInputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x0000000188C0D590-0x0000000188C0D614
			internal static extern void criAtomEx3dTransceiver_SetOutputPosition(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector position); // 0x0000000188C0D8E4-0x0000000188C0D968
			internal static extern void criAtomEx3dTransceiver_SetInputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x0000000188C0D4FC-0x0000000188C0D590
			internal static extern void criAtomEx3dTransceiver_SetOutputOrientation(IntPtr ex_3d_transceiver, ref CriAtomEx.NativeVector front, ref CriAtomEx.NativeVector top); // 0x0000000188C0D850-0x0000000188C0D8E4
			internal static extern void criAtomEx3dTransceiver_SetOutputConeParameter(IntPtr ex_3d_transceiver, float inside_angle, float outside_angle, float outside_volume); // 0x0000000188C0D758-0x0000000188C0D7B8
			internal static extern void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(IntPtr ex_3d_transceiver, float min_attenuation_distance, float max_attenuation_distance); // 0x0000000188C0D804-0x0000000188C0D850
			internal static extern void criAtomEx3dTransceiver_SetOutputInteriorPanField(IntPtr ex_3d_transceiver, float transceiver_radius, float interior_distance); // 0x0000000188C0D7B8-0x0000000188C0D804
			internal static extern void criAtomEx3dTransceiver_SetInputCrossFadeField(IntPtr ex_3d_transceiver, float direct_audio_radius, float crossfade_distance); // 0x0000000188C0D4B0-0x0000000188C0D4FC
			internal static extern void criAtomEx3dTransceiver_SetOutputVolume(IntPtr ex_3d_transceiver, float volume); // 0x0000000188C0D968-0x0000000188C0D9AC
			internal static extern void criAtomEx3dTransceiver_AttachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x0000000188C0D230-0x0000000188C0D288
			internal static extern void criAtomEx3dTransceiver_DetachAisac(IntPtr ex_3d_transceiver, string global_aisac_name); // 0x0000000188C0D350-0x0000000188C0D3A8
			internal static extern void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(IntPtr ex_3d_transceiver, float max_delta); // 0x0000000188C0D71C-0x0000000188C0D758
			internal static extern void criAtomEx3dTransceiver_SetDistanceAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x0000000188C0D42C-0x0000000188C0D4B0
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x0000000188C0D614-0x0000000188C0D698
			internal static extern void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x0000000188C0D698-0x0000000188C0D71C
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x0000000188C0D9AC-0x0000000188C0DA30
			internal static extern void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id); // 0x0000000188C0DA30-0x0000000188C0DAB4
			internal static extern void criAtomEx3dTransceiver_Set3dRegionHn(IntPtr ex_3d_transceiver, IntPtr ex_3d_region); // 0x0000000188C0D3A8-0x0000000188C0D42C
		}
	
		// Constructors
		public CriAtomEx3dTransceiver(); // 0x0000000188BF80B8-0x0000000188BF8134
	
		// Methods
		public override void Dispose(); // 0x0000000188BF7E24-0x0000000188BF7E30
		private void Dispose(bool disposing); // 0x0000000188BF7D94-0x0000000188BF7E24
		public void Update(); // 0x0000000188BF80AC-0x0000000188BF80B8
		public void SetInputPosition(Vector3 position); // 0x0000000188BF7F4C-0x0000000188BF7F88
		public void SetOutputPosition(Vector3 position); // 0x0000000188BF804C-0x0000000188BF8088
		public void SetInputOrientation(Vector3 front, Vector3 top); // 0x0000000188BF7ED8-0x0000000188BF7F4C
		public void SetOutputOrientation(Vector3 front, Vector3 top); // 0x0000000188BF7FD8-0x0000000188BF804C
		public void SetOutputConeParameter(float insideAngle, float outsideAngle, float outsideVolume); // 0x0000000188BF7FAC-0x0000000188BF7FC0
		public void SetOutputMinMaxDistance(float minDistance, float maxDistance); // 0x0000000188BF7FCC-0x0000000188BF7FD8
		public void SetOutputInteriorPanField(float radius, float interiorDistance); // 0x0000000188BF7FC0-0x0000000188BF7FCC
		public void SetInputCrossFadeField(float directAudioRadius, float crossfadeDistance); // 0x0000000188BF7ECC-0x0000000188BF7ED8
		public void SetOutputVolume(float volume); // 0x0000000188BF8088-0x0000000188BF8094
		public void AttachAisac(string globalAisacName); // 0x0000000188BF7D7C-0x0000000188BF7D88
		public void DetachAisac(string globalAisacName); // 0x0000000188BF7D88-0x0000000188BF7D94
		public void SetMaxAngleAisacDelta(float maxDelta); // 0x0000000188BF7FA0-0x0000000188BF7FAC
		public void SetDistanceAisacControlId(ushort aisacControlId); // 0x0000000188BF7EC0-0x0000000188BF7ECC
		public void SetListenerBasedAzimuthAngleAisacControlId(ushort aisacControlId); // 0x0000000188BF7F88-0x0000000188BF7F94
		public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId); // 0x0000000188BF7F94-0x0000000188BF7FA0
		public void SetTransceiverOutputBasedAzimuthAngleAisacControlId(ushort aisacControlId); // 0x0000000188BF8094-0x0000000188BF80A0
		public void SetTransceiverOutputBasedElevationAngleAisacControlId(ushort aisacControlId); // 0x0000000188BF80A0-0x0000000188BF80AC
		public void Set3dRegion(CriAtomEx3dRegion region3d); // 0x0000000188BF7EA8-0x0000000188BF7EC0
		~CriAtomEx3dTransceiver(); // 0x0000000188BF7E30-0x0000000188BF7EA8
	}

	public class CriAtomEx3dRegion : CriDisposable // TypeDefIndex: 84269
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		public struct Config // TypeDefIndex: 84267
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private static class UnsafeNativeMethods // TypeDefIndex: 84268
		{
			// Methods
			internal static extern IntPtr criAtomEx3dRegion_Create(ref Config config, IntPtr work, int work_size); // 0x0000000188C0D168-0x0000000188C0D1FC
			internal static extern void criAtomEx3dRegion_Destroy(IntPtr ex_3d_region); // 0x0000000188C0D1FC-0x0000000188C0D230
		}
	
		// Constructors
		public CriAtomEx3dRegion(); // 0x0000000188BF6C58-0x0000000188BF6CD4
	
		// Methods
		public override void Dispose(); // 0x0000000188BF6B44-0x0000000188BF6B50
		private void Dispose(bool disposing); // 0x0000000188BF6B50-0x0000000188BF6BE0
		~CriAtomEx3dRegion(); // 0x0000000188BF6BE0-0x0000000188BF6C58
	}

	public class CriAtomExAcb : CriDisposable // TypeDefIndex: 84270
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle dataHandle; // 0x28
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
		public bool isAvailable { get; } // 0x0000000188BFAEF4-0x0000000188BFAF00 
	
		// Constructors
		internal CriAtomExAcb(IntPtr handle, GCHandle? dataHandle); // 0x0000000188BF9F84-0x0000000188BFA028
	
		// Methods
		public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath); // 0x0000000188BF9E98-0x0000000188BF9F6C
		public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath); // 0x0000000188BF9D74-0x0000000188BF9E98
		public override void Dispose(); // 0x0000000188BF8AC4-0x0000000188BF8B14
		private void Dispose(bool disposing); // 0x0000000188BF8B14-0x0000000188BF8B94
		public bool Exists(string cueName); // 0x0000000188BF8B94-0x0000000188BF8BA0
		public bool Exists(int cueId); // 0x0000000188BF8BA0-0x0000000188BF8BAC
		public bool GetCueInfo(string cueName, out CriAtomEx.CueInfo info); // 0x0000000188BF9170-0x0000000188BF93B4
		public bool GetCueInfo(int cueId, out CriAtomEx.CueInfo info); // 0x0000000188BF8F2C-0x0000000188BF9170
		public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info); // 0x0000000188BF8C3C-0x0000000188BF8E80
		public CriAtomEx.CueInfo[] GetCueInfoList(); // 0x0000000188BF8E80-0x0000000188BF8F2C
		public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info); // 0x0000000188BF9954-0x0000000188BF9B58
		public bool GetWaveFormInfo(int cueId, out CriAtomEx.WaveformInfo info); // 0x0000000188BF9B58-0x0000000188BF9D5C
		public int GetNumCuePlaying(string name); // 0x0000000188BF93C0-0x0000000188BF93CC
		public int GetNumCuePlaying(int id); // 0x0000000188BF93B4-0x0000000188BF93C0
		public int GetBlockIndex(string cueName, string blockName); // 0x0000000188BF8C30-0x0000000188BF8C3C
		public int GetBlockIndex(int cueId, string blockName); // 0x0000000188BF8C24-0x0000000188BF8C30
		public int GetNumUsableAisacControls(string cueName); // 0x0000000188BF93CC-0x0000000188BF93D8
		public int GetNumUsableAisacControls(int cueId); // 0x0000000188BF93D8-0x0000000188BF93E4
		public bool GetUsableAisacControl(string cueName, int index, out CriAtomEx.AisacControlInfo info); // 0x0000000188BF9768-0x0000000188BF9954
		public bool GetUsableAisacControl(int cueId, int index, out CriAtomEx.AisacControlInfo info); // 0x0000000188BF956C-0x0000000188BF9768
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(string cueName); // 0x0000000188BF93E4-0x0000000188BF94A8
		public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(int cueId); // 0x0000000188BF94A8-0x0000000188BF956C
		public void ResetCueTypeState(string cueName); // 0x0000000188BF9F78-0x0000000188BF9F84
		public void ResetCueTypeState(int cueId); // 0x0000000188BF9F6C-0x0000000188BF9F78
		public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name); // 0x0000000188BF8A0C-0x0000000188BF8A44
		public void DetachAwbFile(string awb_name); // 0x0000000188BF8AB0-0x0000000188BF8AC4
		public bool IsReadyToRelease(); // 0x0000000188BF9D5C-0x0000000188BF9D74
		public float GetLoadProgress(); // 0x0000000187235D20-0x0000000187235D30
		public void Decrypt(ulong key, ulong nonce); // 0x0000000188BF8A44-0x0000000188BF8AB0
		~CriAtomExAcb(); // 0x0000000188BF8BAC-0x0000000188BF8C24
		private static extern IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x0000000188BFACF0-0x0000000188BFADE8
		private static extern IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x0000000188BFAC0C-0x0000000188BFACF0
		private static extern void criAtomExAcb_Release(IntPtr acb_hn); // 0x0000000188BFADE8-0x0000000188BFAE1C
		private static extern int criAtomExAcb_GetNumCues(IntPtr acb_hn); // 0x0000000188BFA774-0x0000000188BFA7A8
		private static extern bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id); // 0x0000000188BFA1A4-0x0000000188BFA22C
		private static extern bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name); // 0x0000000188BFA22C-0x0000000188BFA2DC
		private static extern int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id); // 0x0000000188BFA7A8-0x0000000188BFA82C
		private static extern int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name); // 0x0000000188BFA82C-0x0000000188BFA8D8
		private static extern bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info); // 0x0000000188BFA8D8-0x0000000188BFA980
		private static extern bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info); // 0x0000000188BFA980-0x0000000188BFAA44
		private static extern bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info); // 0x0000000188BFAA44-0x0000000188BFAADC
		private static extern bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info); // 0x0000000188BFAADC-0x0000000188BFAB90
		private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info); // 0x0000000188BFA590-0x0000000188BFA644
		private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info); // 0x0000000188BFA460-0x0000000188BFA4F8
		private static extern bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info); // 0x0000000188BFA4F8-0x0000000188BFA590
		private static extern int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name); // 0x0000000188BFA6C8-0x0000000188BFA774
		private static extern int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id); // 0x0000000188BFA644-0x0000000188BFA6C8
		private static extern int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name); // 0x0000000188BFA2DC-0x0000000188BFA394
		private static extern int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name); // 0x0000000188BFA394-0x0000000188BFA460
		private static extern void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name); // 0x0000000188BFAE5C-0x0000000188BFAEF4
		private static extern void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id); // 0x0000000188BFAE1C-0x0000000188BFAE5C
		private static extern void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size); // 0x0000000188BFA028-0x0000000188BFA10C
		private static extern void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name); // 0x0000000188BFA10C-0x0000000188BFA1A4
		private static extern bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn); // 0x0000000188BFAB90-0x0000000188BFAC0C
	}

	public class CriAtomExAcbLoader : CriDisposable // TypeDefIndex: 84273
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle? gch; // 0x28
	
		// Nested types
		public enum Status // TypeDefIndex: 84271
		{
			Stop = 0,
			Loading = 1,
			Complete = 2,
			Error = 3
		}
	
		private struct LoaderConfig // TypeDefIndex: 84272
		{
			// Fields
			public bool shouldLoadAwbOnMemory; // 0x00
		}
	
		// Constructors
		private CriAtomExAcbLoader(IntPtr handle, GCHandle? dataHandle); // 0x0000000188BF85A4-0x0000000188BF866C
	
		// Methods
		public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x026442E5 */); // 0x0000000188BF8418-0x0000000188BF8504
		public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false /* Metadata: 0x026442E6 */); // 0x0000000188BF82D8-0x0000000188BF8418
		public Status GetStatus(); // 0x0000000188BF82CC-0x0000000188BF82D8
		public CriAtomExAcb MoveAcb(); // 0x0000000188BF8504-0x0000000188BF85A4
		public override void Dispose(); // 0x0000000188BF8134-0x0000000188BF8184
		private void Dispose(bool disposing); // 0x0000000188BF8184-0x0000000188BF8254
		~CriAtomExAcbLoader(); // 0x0000000188BF8254-0x0000000188BF82CC
		private static extern IntPtr criAtomExAcbLoader_Create(in LoaderConfig config); // 0x0000000188BF866C-0x0000000188BF86EC
		private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader); // 0x0000000188BF86EC-0x0000000188BF8720
		private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path); // 0x0000000188BF8870-0x0000000188BF895C
		private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path); // 0x0000000188BF8798-0x0000000188BF8870
		private static extern Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader); // 0x0000000188BF8720-0x0000000188BF8798
		private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader); // 0x0000000188BF89D4-0x0000000188BF8A0C
		private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader); // 0x0000000188BF895C-0x0000000188BF89D4
	}

	public class CriAtomExAcf // TypeDefIndex: 84288
	{
		// Nested types
		public struct AcfDspSettingInfo // TypeDefIndex: 84274
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
			public AcfDspSettingInfo(byte[] data, int startIndex); // 0x0000000188BF5588-0x0000000188BF57D8
		}
	
		public struct AcfDspSettingSnapshotInfo // TypeDefIndex: 84275
		{
			// Fields
			public string name; // 0x00
			public byte numBuses; // 0x08
			public byte numExtendBuses; // 0x09
			public byte[] reserved; // 0x10
			public ushort[] busIndexes; // 0x18
			public ushort[] extendBusIndexes; // 0x20
	
			// Constructors
			public AcfDspSettingSnapshotInfo(byte[] data, int startIndex); // 0x0000000188BF57D8-0x0000000188BF5A14
		}
	
		public struct AcfDspBusInfo // TypeDefIndex: 84276
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
			public AcfDspBusInfo(byte[] data, int startIndex); // 0x0000000188BF5210-0x0000000188BF545C
		}
	
		public enum AcfDspBusLinkType : uint // TypeDefIndex: 84277
		{
			preVolume = 0,
			postVolume = 1,
			postPan = 2
		}
	
		public struct AcfDspBusLinkInfo // TypeDefIndex: 84278
		{
			// Fields
			public AcfDspBusLinkType type; // 0x00
			public float sendLevel; // 0x04
			public ushort busNo; // 0x08
			public ushort busId; // 0x0A
	
			// Constructors
			public AcfDspBusLinkInfo(byte[] data, int startIndex); // 0x0000000188BF545C-0x0000000188BF5588
		}
	
		public struct CategoryInfo // TypeDefIndex: 84279
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public string name; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
	
			// Constructors
			public CategoryInfo(byte[] data, int startIndex); // 0x0000000188BF615C-0x0000000188BF6244
		}
	
		public enum AcfAisacType : uint // TypeDefIndex: 84280
		{
			normal = 0,
			autoModulation = 1
		}
	
		public struct GlobalAisacInfo // TypeDefIndex: 84281
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
			public GlobalAisacInfo(byte[] data, int startIndex); // 0x0000000188C0B830-0x0000000188C0B9B8
		}
	
		public enum AisacGraphType // TypeDefIndex: 84282
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
	
		public struct AisacGraphInfo // TypeDefIndex: 84283
		{
			// Fields
			public AisacGraphType type; // 0x00
	
			// Constructors
			public AisacGraphInfo(byte[] data, int startIndex); // 0x0000000188BF5CC8-0x0000000188BF5DBC
		}
	
		public enum CharacterEncoding : uint // TypeDefIndex: 84284
		{
			utf8 = 0,
			sjis = 1
		}
	
		public struct AcfInfo // TypeDefIndex: 84285
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
			public AcfInfo(byte[] data, int startIndex); // 0x0000000188BF5A14-0x0000000188BF5C20
		}
	
		public struct SelectorInfo // TypeDefIndex: 84286
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
	
			// Constructors
			public SelectorInfo(byte[] data, int startIndex); // 0x0000000188C0C074-0x0000000188C0C140
		}
	
		public struct SelectorLabelInfo // TypeDefIndex: 84287
		{
			// Fields
			public string selectorName; // 0x00
			public string labelName; // 0x08
	
			// Constructors
			public SelectorLabelInfo(byte[] data, int startIndex); // 0x0000000188C0C140-0x0000000188C0C1F8
		}
	
		// Constructors
		public CriAtomExAcf(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static int GetNumAisacControls(); // 0x0000000188BFC7E4-0x0000000188BFC7EC
		public static bool GetAisacControlInfo(ushort index, out CriAtomEx.AisacControlInfo info); // 0x0000000188BFB108-0x0000000188BFB2CC
		public static int GetNumDspSettings(); // 0x0000000188BFC80C-0x0000000188BFC814
		public static int GetNumDspSettings(IntPtr acfData, int size); // 0x0000000188BFC804-0x0000000188BFC80C
		public static string GetDspSettingNameByIndex(ushort index); // 0x0000000188BFBDF8-0x0000000188BFBE50
		public static string GetDspSettingNameByIndex(IntPtr acfData, int size, ushort index); // 0x0000000188BFBE50-0x0000000188BFBEC4
		public static bool GetDspSettingInformation(string name, out AcfDspSettingInfo info); // 0x0000000188BFBC04-0x0000000188BFBDF8
		public static bool GetDspSettingSnapshotInformation(ushort index, out AcfDspSettingSnapshotInfo info); // 0x0000000188BFBEC4-0x0000000188BFC0C0
		public static bool GetDspBusInformation(ushort index, out AcfDspBusInfo info); // 0x0000000188BFB868-0x0000000188BFBA78
		public static bool GetDspBusLinkInformation(ushort index, out AcfDspBusLinkInfo info); // 0x0000000188BFBA78-0x0000000188BFBC04
		public static int GetNumCategories(); // 0x0000000188BFC7FC-0x0000000188BFC804
		public static int GetNumCategoriesPerPlayback(); // 0x0000000188BFC7F4-0x0000000188BFC7FC
		public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo info); // 0x0000000188BFB4B0-0x0000000188BFB694
		public static bool GetCategoryInfoByName(string name, out CategoryInfo info); // 0x0000000188BFB694-0x0000000188BFB868
		public static bool GetCategoryInfoById(uint id, out CategoryInfo info); // 0x0000000188BFB2CC-0x0000000188BFB4B0
		public static int GetNumGlobalAisacs(); // 0x0000000188BFC814-0x0000000188BFC81C
		public static bool GetGlobalAisacInfoByIndex(ushort index, out GlobalAisacInfo info); // 0x0000000188BFC314-0x0000000188BFC4F8
		public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info); // 0x0000000188BFC4F8-0x0000000188BFC6CC
		public static bool GetGlobalAisacGraphInfo(GlobalAisacInfo aisacInfo, ushort graphIndex, out AisacGraphInfo graphInfo); // 0x0000000188BFC0C0-0x0000000188BFC314
		public static bool GetGlobalAisacValue(GlobalAisacInfo aisacInfo, float control, AisacGraphType type, out float value); // 0x0000000188BFC6CC-0x0000000188BFC7DC
		public static bool GetAcfInfo(out AcfInfo acfInfo); // 0x0000000188BFAF08-0x0000000188BFB108
		public static int GetNumSelectors(); // 0x0000000188BFC81C-0x0000000188BFC824
		public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info); // 0x0000000188BFC824-0x0000000188BFC9E8
		public static bool GetSelectorInfoByName(string name, out SelectorInfo info); // 0x0000000188BFC9E8-0x0000000188BFCBAC
		public static bool GetSelectorLabelInfo(SelectorInfo selectorInfo, ushort labelIndex, out SelectorLabelInfo info); // 0x0000000188BFCBAC-0x0000000188BFCE44
		public static int GetNumBuses(); // 0x0000000188BFC7EC-0x0000000188BFC7F4
		public static int GetMaxBusesOfDspBusSettings(); // 0x0000000188BFC7DC-0x0000000188BFC7E4
		public static string FindBusName(string busName); // 0x0000000188BFAF00-0x0000000188BFAF08
		private static extern int criAtomExAcf_GetNumAisacControls(); // 0x0000000188BFD9CC-0x0000000188BFD9F0
		private static extern bool criAtomExAcf_GetAisacControlInfo(ushort index, IntPtr info); // 0x0000000188BFD020-0x0000000188BFD0AC
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x0000000188BFCFCC-0x0000000188BFD020
		private static extern string criAtomExAcf_GetAisacControlNameById(uint id); // 0x0000000188BFD0AC-0x0000000188BFD144
		private static extern int criAtomExAcf_GetNumDspSettings(); // 0x0000000188BFDC40-0x0000000188BFDCA8
		private static extern int criAtomExAcf_GetNumDspSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x0000000188BFDBBC-0x0000000188BFDC40
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndex(ushort index); // 0x0000000188BFD674-0x0000000188BFD6EC
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(IntPtr acf_data, int acf_data_size, ushort index); // 0x0000000188BFD5E0-0x0000000188BFD674
		private static extern bool criAtomExAcf_GetDspSettingInformation(string name, IntPtr info); // 0x0000000188BFD57C-0x0000000188BFD5E0
		private static extern bool criAtomExAcf_GetDspSettingSnapshotInformation(ushort index, IntPtr info); // 0x0000000188BFD6EC-0x0000000188BFD778
		private static extern bool criAtomExAcf_GetDspBusInformation(ushort index, IntPtr info); // 0x0000000188BFD2BC-0x0000000188BFD348
		private static extern int criAtomExAcf_GetDspFxType(ushort index); // 0x0000000188BFD504-0x0000000188BFD57C
		private static extern string criAtomExAcf_GetDspFxName(ushort index); // 0x0000000188BFD3D4-0x0000000188BFD46C
		private static extern bool criAtomExAcf_GetDspFxParameters(ushort index, IntPtr parameters, int size); // 0x0000000188BFD46C-0x0000000188BFD504
		private static extern bool criAtomExAcf_GetDspBusLinkInformation(ushort index, IntPtr info); // 0x0000000188BFD348-0x0000000188BFD3D4
		private static extern int criAtomExAcf_GetNumCategoriesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x0000000188BFDAA0-0x0000000188BFDB24
		private static extern int criAtomExAcf_GetNumCategories(); // 0x0000000188BFDB90-0x0000000188BFDBBC
		private static extern int criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(IntPtr acf_data, int acf_data_size); // 0x0000000188BFDB24-0x0000000188BFDB64
		private static extern int criAtomExAcf_GetNumCategoriesPerPlayback(); // 0x0000000188BFDB64-0x0000000188BFDB90
		private static extern bool criAtomExAcf_GetCategoryInfo(ushort index, IntPtr info); // 0x0000000188BFD230-0x0000000188BFD2BC
		private static extern bool criAtomExAcf_GetCategoryInfoByName(string name, IntPtr info); // 0x0000000188BFD1CC-0x0000000188BFD230
		private static extern bool criAtomExAcf_GetCategoryInfoById(uint id, IntPtr info); // 0x0000000188BFD144-0x0000000188BFD1CC
		private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x0000000188BFDCA8-0x0000000188BFDCCC
		private static extern bool criAtomExAcf_GetGlobalAisacInfo(ushort index, IntPtr info); // 0x0000000188BFD874-0x0000000188BFD900
		private static extern bool criAtomExAcf_GetGlobalAisacInfoByName(string name, IntPtr info); // 0x0000000188BFD810-0x0000000188BFD874
		private static extern bool criAtomExAcf_GetGlobalAisacGraphInfo(IntPtr aisac_info, ushort graph_index, IntPtr graph_info); // 0x0000000188BFD778-0x0000000188BFD810
		private static extern bool criAtomExAcf_GetGlobalAisacValue(IntPtr aisac_info, float control, AisacGraphType type, out float value); // 0x0000000188BFD900-0x0000000188BFD960
		private static extern bool criAtomExAcf_GetAcfInfo(IntPtr acf_info); // 0x0000000188BFCF94-0x0000000188BFCFCC
		private static extern bool criAtomExAcf_GetAcfInfoFromAcfData(IntPtr acf_data, int acf_data_size, IntPtr acf_info); // 0x0000000188BFCEFC-0x0000000188BFCF94
		private static extern int criAtomExAcf_GetNumSelectors(); // 0x0000000188BFDCCC-0x0000000188BFDCF0
		private static extern bool criAtomExAcf_GetSelectorInfoByIndex(ushort index, IntPtr info); // 0x0000000188BFDCF0-0x0000000188BFDD7C
		private static extern bool criAtomExAcf_GetSelectorInfoByName(string name, IntPtr info); // 0x0000000188BFDD7C-0x0000000188BFDDE0
		private static extern bool criAtomExAcf_GetSelectorLabelInfo(IntPtr selector_info, ushort label_index, IntPtr info); // 0x0000000188BFDDE0-0x0000000188BFDE78
		private static extern int criAtomExAcf_GetNumBusesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x0000000188BFD9F0-0x0000000188BFDA74
		private static extern int criAtomExAcf_GetNumBuses(); // 0x0000000188BFDA74-0x0000000188BFDAA0
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x0000000188BFD960-0x0000000188BFD9A0
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettings(); // 0x0000000188BFD9A0-0x0000000188BFD9CC
		private static extern string criAtomExAcf_FindBusName(string bus_name); // 0x0000000188BFCE44-0x0000000188BFCEFC
	}

	public class CriAtomExAsrRack : CriDisposable // TypeDefIndex: 84293
	{
		// Fields
		public const int defaultRackId = 0; // Metadata: 0x02644329
		private int _rackId; // 0x20
		private bool hasExistingRackId; // 0x24
	
		// Properties
		public int rackId { get; } // 0x000000018226A850-0x000000018226A860 
		public static Config defaultConfig { get; } // 0x0000000187235D30-0x0000000187235D70 
	
		// Nested types
		public enum SpeakerMapping // TypeDefIndex: 84289
		{
			Auto = 0,
			Monaural = 1,
			Stereo = 2,
			Ch5_1 = 3,
			Ch7_1 = 4,
			Ch5_1_2 = 5,
			Ch7_1_4 = 6
		}
	
		public struct Config // TypeDefIndex: 84290
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
	
		public struct PlatformConfig // TypeDefIndex: 84291
		{
			// Fields
			public byte reserved; // 0x00
		}
	
		public struct PerformanceInfo // TypeDefIndex: 84292
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
		public CriAtomExAsrRack(Config config, PlatformConfig platformConfig); // 0x0000000188BFE1B8-0x0000000188BFE2C8
		public CriAtomExAsrRack(int existingRackId); // 0x0000000188BFE2C8-0x0000000188BFE388
	
		// Methods
		public void AttachDspBusSetting(string settingName); // 0x0000000188BFDE84-0x0000000188BFDEA4
		public void DetachDspBusSetting(); // 0x0000000188BFDF28-0x0000000188BFDF34
		public void ApplyDspBusSnapshot(string snapshotName, int timeMs); // 0x0000000188BFDE78-0x0000000188BFDE84
		public static string GetAppliedDspBusSnapshotName(int rackId); // 0x0000000188BFE084-0x0000000188BFE0D8
		public string GetAppliedDspBusSnapshotName(); // 0x0000000188BFE02C-0x0000000188BFE084
		public PerformanceInfo GetPerformanceInfo(); // 0x0000000188BFE10C-0x0000000188BFE194
		public static PerformanceInfo GetPerformanceInfoByRackId(int rackId = 0 /* Metadata: 0x02644327 */); // 0x0000000188BFE0D8-0x0000000188BFE10C
		public void ResetPerformanceMonitor(); // 0x0000000188BFE19C-0x0000000188BFE1A8
		public static void ResetPerformanceMonitorByRackId(int rackId = 0 /* Metadata: 0x02644328 */); // 0x0000000188BFE194-0x0000000188BFE19C
		public static void SetAisacControl(int rackId, string controlName, float value); // 0x0000000188BFE1A8-0x0000000188BFE1B0
		public static void SetAisacControl(int rackId, int controlId, float value); // 0x0000000188BFE1B0-0x0000000188BFE1B8
		public override void Dispose(); // 0x0000000188BFDF34-0x0000000188BFDFB4
		~CriAtomExAsrRack(); // 0x0000000188BFDFB4-0x0000000188BFE02C
		private static extern int CRIWARE6158351D(in Config config, in PlatformConfig platformConfig); // 0x0000000188BFDEA4-0x0000000188BFDF28
		private static extern void criAtomExAsrRack_Destroy(int rackId); // 0x0000000188BFE4E4-0x0000000188BFE55C
		private static extern void criAtomExAsrRack_AttachDspBusSetting(int rackId, string setting, IntPtr work, int workSize); // 0x0000000188BFE430-0x0000000188BFE4E4
		private static extern void criAtomExAsrRack_DetachDspBusSetting(int rackId); // 0x0000000188BFE55C-0x0000000188BFE5D4
		private static extern IntPtr criAtomExAsrRack_GetAppliedDspBusSnapshotName(int rackId); // 0x0000000188BFE5D4-0x0000000188BFE64C
		private static extern void criAtomExAsrRack_ApplyDspBusSnapshot(int rackId, string snapshotName, int timeMs); // 0x0000000188BFE388-0x0000000188BFE430
		private static extern void criAtomExAsrRack_GetPerformanceInfo(int rackId, out PerformanceInfo perfInfo); // 0x0000000188BFE64C-0x0000000188BFE6D0
		private static extern void criAtomExAsrRack_ResetPerformanceMonitor(int rackId); // 0x0000000188BFE6D0-0x0000000188BFE748
		private static extern void criAtomExAsrRack_SetAisacControlById(int rackId, ushort controlId, float value); // 0x0000000188BFE748-0x0000000188BFE794
		private static extern void criAtomExAsrRack_SetAisacControlByName(int rackId, string controlName, float value); // 0x0000000188BFE794-0x0000000188BFE7F4
	}

	public class CriAtomExAuxIn : CriDisposable // TypeDefIndex: 84295
	{
		// Fields
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomExAuxIn."; // Metadata: 0x02644331
		private IntPtr handle; // 0x20
		private CriAudioReadStream inputReadStream; // 0x28
	
		// Nested types
		public struct Config // TypeDefIndex: 84294
		{
			// Fields
			public int maxChannels; // 0x00
			public int maxSamplingRate; // 0x04
			public CriAtomEx.SoundRendererType soundRendererType; // 0x08
	
			// Properties
			public static Config Default { get; } // 0x0000000187235D00-0x0000000187235D20 
		}
	
		// Constructors
		public CriAtomExAuxIn(Config? config = default); // 0x0000000188BFF710-0x0000000188BFF7E8
	
		// Methods
		~CriAtomExAuxIn(); // 0x0000000188BFDFB4-0x0000000188BFE02C
		public override void Dispose(); // 0x0000000188BFF5FC-0x0000000188BFF678
		public void Start(); // 0x0000000188BFF6F0-0x0000000188BFF6FC
		public void Stop(); // 0x0000000188BFF6FC-0x0000000188BFF710
		public void SetFormat(int numChannels, int samplingRate); // 0x0000000188BFF690-0x0000000188BFF69C
		public void GetFormat(out int numChannels, out int samplingRate); // 0x0000000188BFF678-0x0000000188BFF684
		public void SetVolume(float volume); // 0x0000000188BFF6E4-0x0000000188BFF6F0
		public void SetFrequencyRatio(float frequencyRatio); // 0x0000000188BFF69C-0x0000000188BFF6A8
		public void SetBusSendLevel(string busName, float level); // 0x0000000188BFF684-0x0000000188BFF690
		public void SetInputReadStream(CriAudioReadStream stream); // 0x0000000188BFF6A8-0x0000000188BFF6E4
		private static extern IntPtr criAtomAuxIn_Create(in Config config, IntPtr work, int work_size); // 0x0000000188BFF7E8-0x0000000188BFF87C
		private static extern void criAtomAuxIn_Destroy(IntPtr aux_in); // 0x0000000188BFF87C-0x0000000188BFF8B0
		private static extern void criAtomAuxIn_Start(IntPtr aux_in); // 0x0000000188BFFB0C-0x0000000188BFFB40
		private static extern void criAtomAuxIn_Stop(IntPtr aux_in); // 0x0000000188BFFB40-0x0000000188BFFBB8
		private static extern void criAtomAuxIn_SetVolume(IntPtr aux_in, float volume); // 0x0000000188BFFAD0-0x0000000188BFFB0C
		private static extern void criAtomAuxIn_SetFrequencyRatio(IntPtr aux_in, float ratio); // 0x0000000188BFFA38-0x0000000188BFFA7C
		private static extern void criAtomAuxIn_SetBusSendLevelByName(IntPtr aux_in, string bus_name, float level); // 0x0000000188BFF944-0x0000000188BFF9A4
		private static extern void criAtomAuxIn_SetFormat(IntPtr aux_in, int num_channels, int sampling_rate); // 0x0000000188BFF9A4-0x0000000188BFFA38
		private static extern void criAtomAuxIn_GetFormat(IntPtr aux_in, out int num_channels, out int sampling_rate); // 0x0000000188BFF8B0-0x0000000188BFF944
		private static extern void criAtomAuxIn_SetInputReadStream(IntPtr aux_in, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x0000000188BFFA7C-0x0000000188BFFAD0
	}

	public class CriAtomExMic : CriDisposable // TypeDefIndex: 84299
	{
		// Fields
		private const string errorInvalidHandle = "[CRIWARE] Invalid native handle of CriAtomMic."; // Metadata: 0x02644364
		private const string errorInvalidBufferLength = "[CRIWARE] Invalid buffer length for CriAtomMic.ReadData."; // Metadata: 0x02644393
		private const string errorInvalidNumBuffers = "[CRIWARE] Number of buffers are not same with channels of CriAtomMic."; // Metadata: 0x026443CC
		private const string errorAlreadyInitialized = "[CRIWARE] CriAtomMic module is already initialized."; // Metadata: 0x02644413
		private const string errorNotInitialized = "[CRIWARE] CriAtomMic module is not initialized."; // Metadata: 0x02644447
		[CompilerGenerated]
		private static bool _isInitialized_k__BackingField; // 0x00
		private IntPtr handle; // 0x20
		private IntPtr[] bufferPointers; // 0x28
		private GCHandle[] gcHandles; // 0x30
		private CriAudioWriteStream outputWriteStream; // 0x38
		private static int _initializationCount; // 0x04
	
		// Properties
		public static bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000188C023EC-0x0000000188C02424 0x0000000188C02424-0x0000000188C02460
	
		// Nested types
		public struct DeviceInfo // TypeDefIndex: 84296
		{
			// Fields
			public string deviceId; // 0x00
			public string deviceName; // 0x08
			public uint deviceFlags; // 0x10
			public int maxChannels; // 0x14
			public int maxSamplingRate; // 0x18
		}
	
		public struct Config // TypeDefIndex: 84297
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
			public static Config Default { get; } // 0x0000000188BF62C8-0x0000000188BF6318 
		}
	
		public class Effect // TypeDefIndex: 84298
		{
			// Fields
			[CompilerGenerated]
			private IntPtr _handle_k__BackingField; // 0x10
			[CompilerGenerated]
			private IntPtr _afxInstance_k__BackingField; // 0x18
	
			// Properties
			public IntPtr handle { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x000000018561B5A0-0x000000018561B5B0
			public IntPtr afxInstance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018561CBD0-0x000000018561CBE0
	
			// Constructors
			public Effect(IntPtr handle, IntPtr afxInstance); // 0x0000000187235E70-0x0000000187235E80
		}
	
		// Constructors
		private CriAtomExMic(IntPtr handle); // 0x0000000188C0178C-0x0000000188C01850
	
		// Methods
		public static void InitializeModule(); // 0x0000000188C01200-0x0000000188C0129C
		public static void FinalizeModule(); // 0x0000000188C00EAC-0x0000000188C00F74
		public static void SetupOutputCategoryForMic_IOS(bool enable); // 0x0000000186805BA0-0x0000000186805BB0
		public static DeviceInfo[] GetDevices(); // 0x0000000188C0107C-0x0000000188C0114C
		public static int GetNumDevices(); // 0x0000000188C01188-0x0000000188C01190
		public static DeviceInfo? GetDefaultDevice(); // 0x0000000188C00F74-0x0000000188C0107C
		public static bool IsFormatSupported(Config config); // 0x0000000188C01364-0x0000000188C01374
		public static CriAtomExMic Create(Config? config = default); // 0x0000000188C00C90-0x0000000188C00DDC
		~CriAtomExMic(); // 0x0000000188BFDFB4-0x0000000188BFE02C
		public override void Dispose(); // 0x0000000188C00E5C-0x0000000188C00EAC
		private void Dispose(bool disposing); // 0x0000000188C00E00-0x0000000188C00E5C
		public void Start(); // 0x0000000188C01750-0x0000000188C0175C
		public void Stop(); // 0x0000000188C0175C-0x0000000188C01768
		public int GetNumChannels(); // 0x0000000188C0117C-0x0000000188C01188
		public int GetSamplingRate(); // 0x0000000188C011F4-0x0000000188C01200
		public uint GetNumBufferedSamples(); // 0x0000000188C01170-0x0000000188C0117C
		[Obsolete("Use CriAtomExMic.GetNumBufferedSamples")]
		public uint GetNumBufferredSamples(); // 0x0000000188C01170-0x0000000188C0117C
		public bool IsAvailable(); // 0x0000000188C01344-0x0000000188C01364
		public uint ReadData(float[] bufferMono); // 0x0000000188C013D8-0x0000000188C013F8
		public uint ReadData(float[] bufferMono, uint numToRead); // 0x0000000188C01534-0x0000000188C015C4
		public uint ReadData(float[] bufferL, float[] bufferR); // 0x0000000188C01374-0x0000000188C0139C
		public uint ReadData(float[] bufferL, float[] bufferR, uint numToRead); // 0x0000000188C013F8-0x0000000188C01534
		public uint ReadData(float[][] buffers); // 0x0000000188C0139C-0x0000000188C013D8
		public uint ReadData(float[][] buffers, uint numToRead); // 0x0000000188C015C4-0x0000000188C016C0
		public void SetOutputWriteStream(CriAudioWriteStream stream); // 0x0000000188C01710-0x0000000188C01750
		public CriAudioReadStream GetOutputReadStream(); // 0x0000000188C01190-0x0000000188C011F4
		public Effect AttachEffect(IntPtr afxInterface, float[] configParameters); // 0x0000000188C00BDC-0x0000000188C00C90
		public void DetachEffect(Effect effect); // 0x0000000188C00DDC-0x0000000188C00E00
		public void SetEffectParameter(Effect effect, int parameterIndex, float parameterValue); // 0x0000000188C016E4-0x0000000188C01710
		public float GetEffectParameter(Effect effect, int parameterIndex); // 0x0000000188C0114C-0x0000000188C01170
		public void SetEffectBypass(Effect effect, bool bypass); // 0x0000000188C016C0-0x0000000188C016E4
		public void UpdateEffectParameters(Effect effect); // 0x0000000188C01768-0x0000000188C0178C
		private uint InternalReadDataFromBufferPointers(uint numToRead); // 0x0000000188C01330-0x0000000188C01344
		private void InternalClearBuffers(); // 0x0000000188C0129C-0x0000000188C01330
		private static extern void criAtomMicUnity_Initialize(); // 0x0000000188C018B8-0x0000000188C01920
		private static extern void criAtomMicUnity_Finalize(); // 0x0000000188C01850-0x0000000188C018B8
		private static extern int criAtomMic_GetNumDevices(); // 0x0000000188C01F64-0x0000000188C01F90
		private static extern bool criAtomMic_GetDevice(int index, out DeviceInfo info); // 0x0000000188C01CEC-0x0000000188C01DE8
		private static extern bool criAtomMic_GetDefaultDevice(out DeviceInfo info); // 0x0000000188C01BFC-0x0000000188C01CEC
		private static extern bool criAtomMic_IsFormatSupported(in Config config); // 0x0000000188C0206C-0x0000000188C02118
		private static extern IntPtr criAtomMic_Create(in Config config, IntPtr work, int work_size); // 0x0000000188C01A7C-0x0000000188C01B44
		private static extern void criAtomMic_Destroy(IntPtr mic); // 0x0000000188C01B44-0x0000000188C01B78
		private static extern void criAtomMic_Start(IntPtr mic); // 0x0000000188C022FC-0x0000000188C02374
		private static extern void criAtomMic_Stop(IntPtr mic); // 0x0000000188C02374-0x0000000188C023A8
		private static extern int criAtomMic_GetNumChannels(IntPtr mic); // 0x0000000188C01F30-0x0000000188C01F64
		private static extern int criAtomMic_GetSamplingRate(IntPtr mic); // 0x0000000188C01FBC-0x0000000188C02034
		private static extern uint criAtomMic_GetNumBufferedSamples(IntPtr mic); // 0x0000000188C01EB8-0x0000000188C01F30
		private static extern bool criAtomMic_IsAvailable(IntPtr mic); // 0x0000000188C02034-0x0000000188C0206C
		private static extern uint criAtomMic_ReadData(IntPtr mic, IntPtr[] data, uint num_samples); // 0x0000000188C02118-0x0000000188C021B8
		private static extern void criAtomMic_SetOutputWriteStream(IntPtr mic, IntPtr stream_cbfunc, IntPtr stream_ptr); // 0x0000000188C022A8-0x0000000188C022FC
		private static extern IntPtr criAtomMic_GetOutputReadStream(); // 0x0000000188C01F90-0x0000000188C01FBC
		private static extern int criAtomMic_CalculateWorkSizeForEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters); // 0x0000000188C019D0-0x0000000188C01A7C
		private static extern IntPtr criAtomMic_AttachEffect(IntPtr mic, IntPtr afx_interface, float[] config_parameters, uint num_config_parameters, IntPtr work, int work_size); // 0x0000000188C01920-0x0000000188C019D0
		private static extern void criAtomMic_DetachEffect(IntPtr mic, IntPtr effect); // 0x0000000188C01B78-0x0000000188C01BFC
		private static extern IntPtr criAtomMic_GetEffectInstance(IntPtr mic, IntPtr effect); // 0x0000000188C01DE8-0x0000000188C01E6C
		private static extern void criAtomMic_SetEffectBypass(IntPtr mic, IntPtr effect, bool bypass); // 0x0000000188C021B8-0x0000000188C0224C
		private static extern void criAtomMic_SetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index, float parameter_value); // 0x0000000188C0224C-0x0000000188C022A8
		private static extern float criAtomMic_GetEffectParameter(IntPtr mic, IntPtr effect, uint parameter_index); // 0x0000000188C01E6C-0x0000000188C01EB8
		private static extern void criAtomMic_UpdateEffectParameters(IntPtr mic, IntPtr effect); // 0x0000000188C023A8-0x0000000188C023EC
	}

	public class CriAtomExOutputAnalyzer : CriDisposable // TypeDefIndex: 84303
	{
		// Fields
		public const int MaximumSpectrumBands = 512; // Metadata: 0x02644477
		protected IntPtr handle; // 0x20
		protected CriAtomExPlayer player; // 0x28
		protected string busName; // 0x30
		protected int numBands; // 0x38
		protected int numCapturedPcmSamples; // 0x3C
		protected PcmCaptureCallback userPcmCaptureCallback; // 0x40
		protected float[] dataL; // 0x48
		protected float[] dataR; // 0x50
		protected const int pcmCapturerNumMaxData = 512; // Metadata: 0x02644479
		protected static IntPtr InternalCallbackFunctionPointer; // 0x00
		protected static InternalPcmCaptureCallback DelegateObject; // 0x08
		protected static float[] DataL; // 0x10
		protected static float[] DataR; // 0x18
		protected static PcmCaptureCallback UserPcmCaptureCallback; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		public delegate void PcmCaptureCallback(float[] dataL, float[] dataR, int numChannels, int numData); // TypeDefIndex: 84300; 0x00000001811CDB70-0x00000001811CDB90
	
		public struct Config // TypeDefIndex: 84301
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
		protected delegate void InternalPcmCaptureCallback(IntPtr dataL, IntPtr dataR, int numChannels, int numData); // TypeDefIndex: 84302; 0x00000001811CDB70-0x00000001811CDB90
	
		// Constructors
		public CriAtomExOutputAnalyzer(Config config); // 0x0000000188C030D4-0x0000000188C03164
		protected CriAtomExOutputAnalyzer(); // 0x0000000188C03070-0x0000000188C030D4
		static CriAtomExOutputAnalyzer(); // 0x0000000188C03008-0x0000000188C03070
	
		// Methods
		public override void Dispose(); // 0x0000000188C0289C-0x0000000188C028A8
		protected void Dispose(bool disposing); // 0x0000000188C028A8-0x0000000188C02970
		public bool AttachExPlayer(CriAtomExPlayer player); // 0x0000000188C024F4-0x0000000188C025AC
		public void DetachExPlayer(); // 0x0000000188C027A8-0x0000000188C0289C
		public bool AttachDspBus(string busName); // 0x0000000188C02460-0x0000000188C024F4
		public void DetachDspBus(); // 0x0000000188C02728-0x0000000188C027A8
		public float GetRms(int channel); // 0x0000000188C02D68-0x0000000188C02E10
		public void GetSpectrumLevels(ref float[] levels); // 0x0000000188C02E10-0x0000000188C02EFC
		public void GetPcmData(ref float[] data, int ch); // 0x0000000188C02C6C-0x0000000188C02D68
		public void SetPcmCaptureCallback(PcmCaptureCallback callback); // 0x00000001870EAAD0-0x00000001870EAAE0
		public void ExecutePcmCaptureCallback(); // 0x0000000188C02994-0x0000000188C02BF4
		[Obsolete("Use SetPcmCaptureCallback(PcmCaptureCallback) and ExecutePcmCaptureCallback()")]
		public void ExecutePcmCaptureCallback(PcmCaptureCallback callback); // 0x0000000188C02970-0x0000000188C02994
		~CriAtomExOutputAnalyzer(); // 0x0000000188C02BF4-0x0000000188C02C6C
		protected void InitializeWithConfig(Config config); // 0x0000000188C02EFC-0x0000000188C03008
		[AOT.MonoPInvokeCallback(typeof(InternalPcmCaptureCallback))]
		private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData); // 0x0000000188C025AC-0x0000000188C02728
		protected static extern IntPtr criAtomExOutputAnalyzer_Create(in Config config); // 0x0000000188C03200-0x0000000188C032B8
		protected static extern void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer); // 0x0000000188C032B8-0x0000000188C032EC
		protected static extern void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player); // 0x0000000188C031BC-0x0000000188C03200
		protected static extern void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player); // 0x0000000188C03344-0x0000000188C03388
		protected static extern void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName); // 0x0000000188C03164-0x0000000188C031BC
		protected static extern void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName); // 0x0000000188C032EC-0x0000000188C03344
		protected static extern float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel); // 0x0000000188C03490-0x0000000188C034CC
		protected static extern IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer); // 0x0000000188C034CC-0x0000000188C03544
		protected static extern IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch); // 0x0000000188C0340C-0x0000000188C03490
		protected static extern void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback); // 0x0000000188C03388-0x0000000188C0340C
	}

	public struct CriAtomExPlayback // TypeDefIndex: 84306
	{
		// Fields
		[CompilerGenerated]
		private uint _id_k__BackingField; // 0x00
		public const uint invalidId = 4294967295; // Metadata: 0x0264447B
	
		// Properties
		public uint id { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public Status status { get; } // 0x0000000188C0F120-0x0000000188C0F12C 
		public long time { get; } // 0x0000000188C0F138-0x0000000188C0F144 
		public long timeSyncedWithAudio { get; } // 0x0000000188C0F12C-0x0000000188C0F138 
	
		// Nested types
		public enum Status // TypeDefIndex: 84304
		{
			Prep = 1,
			Playing = 2,
			Removed = 3
		}
	
		public struct TrackInfo // TypeDefIndex: 84305
		{
			// Fields
			public uint id; // 0x00
			public CriAtomEx.CueType sequenceType; // 0x04
			public IntPtr playerHn; // 0x08
			public ushort trackNo; // 0x10
			public ushort reserved; // 0x12
		}
	
		// Constructors
		public CriAtomExPlayback(uint id); // 0x0000000184547F40-0x0000000184547F50
	
		// Methods
		public void Stop(bool ignoresReleaseTime); // 0x0000000188C0F1E4-0x0000000188C0F248
		public void Pause(); // 0x0000000188C0F168-0x0000000188C0F174
		public void Resume(CriAtomEx.ResumeMode mode); // 0x0000000188C0F174-0x0000000188C0F180
		public bool IsPaused(); // 0x0000000188C0F150-0x0000000188C0F15C
		public bool GetFormatInfo(out CriAtomEx.FormatInfo info); // 0x0000000188C0F0FC-0x0000000188C0F108
		public Status GetStatus(); // 0x0000000188C0F120-0x0000000188C0F12C
		public long GetTime(); // 0x0000000188C0F138-0x0000000188C0F144
		public long GetTimeSyncedWithAudio(); // 0x0000000188C0F12C-0x0000000188C0F138
		public bool GetNumPlayedSamples(out long numSamples, out int samplingRate); // 0x0000000188C0F108-0x0000000188C0F114
		public long GetSequencePosition(); // 0x0000000188C0F114-0x0000000188C0F120
		public int GetCurrentBlockIndex(); // 0x0000000188C0F0F0-0x0000000188C0F0FC
		public bool GetTrackInfo(out TrackInfo info); // 0x0000000188C0F144-0x0000000188C0F150
		public bool GetBeatSyncInfo(out CriAtomExBeatSync.Info info); // 0x0000000188C0F0E4-0x0000000188C0F0F0
		public void SetNextBlockIndex(int index); // 0x0000000188C0F18C-0x0000000188C0F198
		public bool SetBeatSyncOffset(short timeMs); // 0x0000000188C0F180-0x0000000188C0F18C
		public void Stop(); // 0x0000000188C0F248-0x0000000188C0F294
		public void StopWithoutReleaseTime(); // 0x0000000188C0F198-0x0000000188C0F1E4
		public void Pause(bool sw); // 0x0000000188C0F15C-0x0000000188C0F168
		private static extern void criAtomExPlayback_Stop(uint id); // 0x0000000188C0FA18-0x0000000188C0FA90
		private static extern void criAtomExPlayback_StopWithoutReleaseTime(uint id); // 0x0000000188C0F9A0-0x0000000188C0FA18
		private static extern void criAtomExPlayback_Pause(uint id, bool sw); // 0x0000000188C0F794-0x0000000188C0F818
		private static extern void criAtomExPlayback_Resume(uint id, CriAtomEx.ResumeMode mode); // 0x0000000188C0F818-0x0000000188C0F898
		private static extern bool criAtomExPlayback_IsPaused(uint id); // 0x0000000188C0F71C-0x0000000188C0F794
		private static extern Status criAtomExPlayback_GetStatus(uint id); // 0x0000000188C0F5B4-0x0000000188C0F62C
		private static extern bool criAtomExPlayback_GetFormatInfo(uint id, out CriAtomEx.FormatInfo info); // 0x0000000188C0F394-0x0000000188C0F41C
		private static extern long criAtomExPlayback_GetTime(uint id); // 0x0000000188C0F6A4-0x0000000188C0F71C
		private static extern long criAtomExPlayback_GetTimeSyncedWithAudio(uint id); // 0x0000000188C0F62C-0x0000000188C0F6A4
		private static extern bool criAtomExPlayback_GetNumPlayedSamples(uint id, out long num_samples, out int sampling_rate); // 0x0000000188C0F41C-0x0000000188C0F4B4
		private static extern long criAtomExPlayback_GetSequencePosition(uint id); // 0x0000000188C0F53C-0x0000000188C0F5B4
		private static extern void criAtomExPlayback_SetNextBlockIndex(uint id, int index); // 0x0000000188C0F920-0x0000000188C0F9A0
		private static extern int criAtomExPlayback_GetCurrentBlockIndex(uint id); // 0x0000000188C0F31C-0x0000000188C0F394
		private static extern bool criAtomExPlayback_GetPlaybackTrackInfo(uint id, out TrackInfo info); // 0x0000000188C0F4B4-0x0000000188C0F53C
		private static extern bool criAtomExPlayback_GetBeatSyncInfo(uint id, out CriAtomExBeatSync.Info info); // 0x0000000188C0F294-0x0000000188C0F31C
		private static extern bool criAtomExPlayback_SetBeatSyncOffset(uint id, short timeMs); // 0x0000000188C0F898-0x0000000188C0F920
	}

	public class CriAtomExPlayer : CriDisposable // TypeDefIndex: 84311
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
		public IntPtr nativeHandle { get; } // 0x000000018226EE80-0x000000018226EE90 
		public bool isAvailable { get; } // 0x0000000184930A60-0x0000000184930A70 
		public int entryPoolCapacity { get; } // 0x0000000182271C50-0x0000000182271C60 
	
		// Events
		private event CriAtomExBeatSync.CbFunc _onBeatSyncCallback {
			add; // 0x0000000188C10F34-0x0000000188C10FC8
			remove; // 0x0000000188C13398-0x0000000188C1342C
		}
		public event CriAtomExBeatSync.CbFunc OnBeatSyncCallback {
			add; // 0x0000000188C10DFC-0x0000000188C10E98
			remove; // 0x0000000188C13270-0x0000000188C13304
		}
		private event CriAtomExSequencer.EventCallback _onSequenceCallback {
			add; // 0x0000000188C10FC8-0x0000000188C1105C
			remove; // 0x0000000188C1342C-0x0000000188C134C0
		}
		public event CriAtomExSequencer.EventCallback OnSequenceCallback {
			add; // 0x0000000188C10E98-0x0000000188C10F34
			remove; // 0x0000000188C13304-0x0000000188C13398
		}
	
		// Nested types
		public enum Status // TypeDefIndex: 84307
		{
			Stop = 0,
			Prep = 1,
			Playing = 2,
			PlayEnd = 3,
			Error = 4
		}
	
		private struct Config // TypeDefIndex: 84308
		{
			// Fields
			public CriAtomEx.VoiceAllocationMethod voiceAllocationMethod; // 0x00
			public int maxPathStrings; // 0x04
			public int maxPath; // 0x08
			public int maxAisacs; // 0x0C
			public bool updatesTime; // 0x10
			public bool enableAudioSyncedTimer; // 0x11
		}
	
		public enum TimeStretchParameterId // TypeDefIndex: 84309
		{
			Ratio = 0,
			FrameTime = 1,
			Quality = 2
		}
	
		public enum PitchShifterParameterId // TypeDefIndex: 84310
		{
			Pitch = 0,
			Formant = 1,
			Mode = 2
		}
	
		// Constructors
		public CriAtomExPlayer(); // 0x0000000188C10C7C-0x0000000188C10CA0
		public CriAtomExPlayer(int maxPath, int maxPathStrings); // 0x0000000188C10C5C-0x0000000188C10C7C
		public CriAtomExPlayer(bool enableAudioSyncedTimer); // 0x0000000188C10C38-0x0000000188C10C5C
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer); // 0x0000000188C10C1C-0x0000000188C10C38
		public CriAtomExPlayer(IntPtr existingNativeHandle); // 0x0000000188C10BF8-0x0000000188C10C1C
		public CriAtomExPlayer(int maxPath, int maxPathStrings, bool enableAudioSyncedTimer, IntPtr existingNativeHandle); // 0x0000000188C10CA0-0x0000000188C10DFC
	
		// Methods
		public override void Dispose(); // 0x0000000188C101A4-0x0000000188C102C4
		public void SetCue(CriAtomExAcb acb, string name); // 0x0000000188C108D4-0x0000000188C108EC
		public void SetCue(CriAtomExAcb acb, int id); // 0x0000000188C108EC-0x0000000188C10904
		public void SetCueIndex(CriAtomExAcb acb, int index); // 0x0000000188C108B0-0x0000000188C108C8
		public void SetContentId(CriFsBinder binder, int contentId); // 0x0000000188C10898-0x0000000188C108B0
		public void SetFile(CriFsBinder binder, string path); // 0x0000000188C109CC-0x0000000188C109E4
		public void SetData(byte[] buffer, int size); // 0x0000000188C10910-0x0000000188C1091C
		public void SetData(IntPtr buffer, int size); // 0x0000000188C10904-0x0000000188C10910
		public void SetFormat(CriAtomEx.Format format); // 0x0000000188C109F0-0x0000000188C109FC
		public void SetNumChannels(int numChannels); // 0x0000000188C10A08-0x0000000188C10A14
		public void SetSamplingRate(int samplingRate); // 0x0000000188C10A74-0x0000000188C10A80
		public void PrepareEntryPool(int capacity, bool stopOnEmpty); // 0x0000000188C10738-0x0000000188C107AC
		public int GetNumEntries(); // 0x0000000188C105C0-0x0000000188C105E0
		public int GetNumConsumedEntries(); // 0x0000000188C105A0-0x0000000188C105C0
		public bool EntryFile(CriFsBinder binder, string path, bool repeat); // 0x0000000188C1034C-0x0000000188C10384
		public bool EntryContentId(CriFsBinder binder, int contentId, bool repeat); // 0x0000000188C102C4-0x0000000188C102EC
		public bool EntryData(byte[] buffer, int size, bool repeat); // 0x0000000188C10330-0x0000000188C1034C
		public bool EntryData(IntPtr buffer, int size, bool repeat); // 0x0000000188C10314-0x0000000188C10330
		public bool EntryCue(CriAtomExAcb acb, string name, bool repeat); // 0x0000000188C102EC-0x0000000188C10314
		public CriAtomExPlayback Start(); // 0x0000000188C10AF4-0x0000000188C10B20
		public CriAtomExPlayback Prepare(); // 0x0000000188C107AC-0x0000000188C107B8
		public void Stop(bool ignoresReleaseTime); // 0x0000000188C10B54-0x0000000188C10B94
		public void Pause(); // 0x0000000188C1071C-0x0000000188C1072C
		public void Resume(CriAtomEx.ResumeMode mode); // 0x0000000188C107D0-0x0000000188C107DC
		public bool IsPaused(); // 0x0000000188C10628-0x0000000188C10634
		public void SetVolume(float volume); // 0x0000000188C10AE8-0x0000000188C10AF4
		public void SetPitch(float pitch); // 0x0000000188C10A44-0x0000000188C10A50
		public void SetPlaybackRatio(float ratio); // 0x0000000188C10A50-0x0000000188C10A5C
		public void SetPan3dAngle(float angle); // 0x0000000188C10A14-0x0000000188C10A20
		public void SetPan3dInteriorDistance(float distance); // 0x0000000188C10A20-0x0000000188C10A2C
		public void SetPan3dVolume(float volume); // 0x0000000188C10A2C-0x0000000188C10A38
		public void SetPanType(CriAtomEx.PanType panType); // 0x0000000188C10A38-0x0000000188C10A44
		public void SetSendLevel(int channel, CriAtomEx.Speaker id, float level); // 0x0000000188C10A8C-0x0000000188C10AA0
		public void SetBiquadFilterParameters(CriAtomEx.BiquadFilterType type, float frequency, float gain, float q); // 0x0000000188C1083C-0x0000000188C10850
		public void SetBandpassFilterParameters(float cofLow, float cofHigh); // 0x0000000188C10830-0x0000000188C1083C
		public void SetBusSendLevel(string busName, float level); // 0x0000000188C10868-0x0000000188C10874
		public bool GetBusSendLevel(string busName, out float level); // 0x0000000188C10594-0x0000000188C105A0
		[Obsolete("Use CriAtomExPlayer.SetBusSendLevel(string busName, float level)")]
		public void SetBusSendLevel(int busId, float level); // 0x0000000188C10874-0x0000000188C10880
		public void SetBusSendLevelOffset(string busName, float levelOffset); // 0x0000000188C10850-0x0000000188C1085C
		public bool GetBusSendLevelOffset(string busName, out float level); // 0x0000000188C10588-0x0000000188C10594
		[Obsolete("Use CriAtomExPlayer.SetBusSendLevelOffset(int busId, float levelOffset)")]
		public void SetBusSendLevelOffset(int busId, float levelOffset); // 0x0000000188C1085C-0x0000000188C10868
		public void AttachAisac(string globalAisacName); // 0x0000000188C0FBB8-0x0000000188C0FBC4
		public void DetachAisac(string globalAisacName); // 0x0000000188C1015C-0x0000000188C10168
		public void SetAisacControl(string controlName, float value); // 0x0000000188C1080C-0x0000000188C10818
		[Obsolete("Use CriAtomExPlayer.SetAisacControl")]
		public void SetAisac(string controlName, float value); // 0x0000000188C1080C-0x0000000188C10818
		public void SetAisacControl(uint controlId, float value); // 0x0000000188C10818-0x0000000188C10824
		[Obsolete("Use SetAisacControl")]
		public void SetAisac(uint controlId, float value); // 0x0000000188C10818-0x0000000188C10824
		public bool GetAttachedAisacInfo(int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo); // 0x0000000188C10384-0x0000000188C10588
		public void Set3dSource(CriAtomEx3dSource source); // 0x0000000188C107F4-0x0000000188C1080C
		public void Set3dListener(CriAtomEx3dListener listener); // 0x0000000188C107DC-0x0000000188C107F4
		public void SetStartTime(long startTimeMs); // 0x0000000188C10AB8-0x0000000188C10AC4
		public void SetFirstBlockIndex(int index); // 0x0000000188C109E4-0x0000000188C109F0
		public void SetSelectorLabel(string selector, string label); // 0x0000000188C10A80-0x0000000188C10A8C
		public void UnsetSelectorLabel(string selector); // 0x0000000188C10BD4-0x0000000188C10BE0
		public void ClearSelectorLabels(); // 0x0000000188C10150-0x0000000188C1015C
		public void SetCategory(int categoryId); // 0x0000000188C10880-0x0000000188C1088C
		public void SetCategory(string categoryName); // 0x0000000188C1088C-0x0000000188C10898
		public void UnsetCategory(); // 0x0000000188C10BC8-0x0000000188C10BD4
		public void SetCuePriority(int priority); // 0x0000000188C108C8-0x0000000188C108D4
		public void SetVoicePriority(int priority); // 0x0000000188C10ADC-0x0000000188C10AE8
		public void SetVoiceControlMethod(CriAtomEx.VoiceControlMethod method); // 0x0000000188C10AC4-0x0000000188C10AD0
		public void SetPreDelayTime(float time); // 0x0000000188C10A5C-0x0000000188C10A68
		public void SetEnvelopeAttackTime(float time); // 0x0000000188C10960-0x0000000188C1096C
		public void SetEnvelopeHoldTime(float time); // 0x0000000188C10978-0x0000000188C10984
		public void SetEnvelopeDecayTime(float time); // 0x0000000188C1096C-0x0000000188C10978
		public void SetEnvelopeReleaseTime(float time); // 0x0000000188C10984-0x0000000188C10990
		public void SetEnvelopeSustainLevel(float level); // 0x0000000188C10990-0x0000000188C1099C
		public void AttachFader(); // 0x0000000188C0FBC4-0x0000000188C0FBE8
		public void DetachFader(); // 0x0000000188C10168-0x0000000188C10174
		public void SetFadeOutTime(int ms); // 0x0000000188C109C0-0x0000000188C109CC
		public void SetFadeInTime(int ms); // 0x0000000188C109A8-0x0000000188C109B4
		public void SetFadeInStartOffset(int ms); // 0x0000000188C1099C-0x0000000188C109A8
		public void SetFadeOutEndDelay(int ms); // 0x0000000188C109B4-0x0000000188C109C0
		public bool IsFading(); // 0x0000000188C1061C-0x0000000188C10628
		public void ResetFaderParameters(); // 0x0000000188C107B8-0x0000000188C107C4
		public void SetGroupNumber(int group_no); // 0x0000000188C109FC-0x0000000188C10A08
		public void Update(CriAtomExPlayback playback); // 0x0000000188C10BEC-0x0000000188C10BF8
		public void UpdateAll(); // 0x0000000188C10BE0-0x0000000188C10BEC
		public void ResetParameters(); // 0x0000000188C107C4-0x0000000188C107D0
		public long GetTime(); // 0x0000000188C10610-0x0000000188C1061C
		public Status GetStatus(); // 0x0000000188C10604-0x0000000188C10610
		public float GetParameterFloat32(CriAtomEx.Parameter id); // 0x0000000188C105E0-0x0000000188C105EC
		public uint GetParameterUint32(CriAtomEx.Parameter id); // 0x0000000188C105F8-0x0000000188C10604
		public int GetParameterSint32(CriAtomEx.Parameter id); // 0x0000000188C105EC-0x0000000188C105F8
		public void SetSoundRendererType(CriAtomEx.SoundRendererType type); // 0x0000000188C10AAC-0x0000000188C10AB8
		public void SetRandomSeed(uint seed); // 0x0000000188C10A68-0x0000000188C10A74
		public void Loop(bool sw); // 0x0000000188C10634-0x0000000188C106B0
		public void SetAsrRackId(int asr_rack_id); // 0x0000000188C10824-0x0000000188C10830
		public void SetVoicePoolIdentifier(uint identifier); // 0x0000000188C10AD0-0x0000000188C10ADC
		public void SetDspTimeStretchRatio(float ratio); // 0x0000000188C1094C-0x0000000188C10960
		public void SetDspPitchShifterPitch(float pitch); // 0x0000000188C10928-0x0000000188C1094C
		public void SetDspParameter(int id, float value); // 0x0000000188C1091C-0x0000000188C10928
		public void SetSequencePrepareTime(uint ms); // 0x0000000188C10AA0-0x0000000188C10AAC
		public void AttachTween(CriAtomExTween tween); // 0x0000000188C0FBE8-0x0000000188C0FC0C
		public void DetachTween(CriAtomExTween tween); // 0x0000000188C10180-0x0000000188C101A4
		public void DetachTweenAll(); // 0x0000000188C10174-0x0000000188C10180
		public void Stop(); // 0x0000000188C10B94-0x0000000188C10BC8
		public void StopWithoutReleaseTime(); // 0x0000000188C10B20-0x0000000188C10B54
		public void Pause(bool sw); // 0x0000000188C1072C-0x0000000188C10738
		~CriAtomExPlayer(); // 0x0000000188BFDFB4-0x0000000188BFE02C
		private void OnBeatSyncCallbackChainInternal(ref CriAtomExBeatSync.Info info); // 0x0000000188C106B0-0x0000000188C106E4
		private void OnSequenceCallbackChainInternal(ref CriAtomExSequencer.CriAtomExSequenceEventInfo info); // 0x0000000188C106E4-0x0000000188C1071C
		private static extern IntPtr criAtomExPlayer_Create(ref Config config, IntPtr work, int work_size); // 0x0000000188C11254-0x0000000188C11368
		private static extern void criAtomExPlayer_Destroy(IntPtr player); // 0x0000000188C11368-0x0000000188C1139C
		private static extern void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id); // 0x0000000188C121A0-0x0000000188C12234
		private static extern void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name); // 0x0000000188C122C8-0x0000000188C12370
		private static extern void criAtomExPlayer_SetCueIndex(IntPtr player, IntPtr acb_hn, int index); // 0x0000000188C12234-0x0000000188C122C8
		private static extern void criAtomExPlayer_SetFile(IntPtr player, IntPtr binder, string path); // 0x0000000188C127BC-0x0000000188C12864
		private static extern void criAtomExPlayer_SetData(IntPtr player, byte[] buffer, int size); // 0x0000000188C12444-0x0000000188C124E4
		private static extern void criAtomExPlayer_SetData(IntPtr player, IntPtr buffer, int size); // 0x0000000188C123B0-0x0000000188C12444
		private static extern void criAtomExPlayer_SetContentId(IntPtr player, IntPtr binder, int id); // 0x0000000188C1210C-0x0000000188C121A0
		private static extern void criAtomExPlayer_SetVoicePoolIdentifier(IntPtr player, uint identifier); // 0x0000000188C12F4C-0x0000000188C12F8C
		private static extern uint criAtomExPlayer_Start(IntPtr player); // 0x0000000188C1304C-0x0000000188C130C4
		private static extern uint criAtomExPlayer_Prepare(IntPtr player); // 0x0000000188C11A3C-0x0000000188C11AB4
		private static extern void criAtomExPlayer_Stop(IntPtr player); // 0x0000000188C130F8-0x0000000188C1312C
		private static extern void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player); // 0x0000000188C130C4-0x0000000188C130F8
		private static extern void criAtomExPlayer_Pause(IntPtr player, bool sw); // 0x0000000188C119B8-0x0000000188C11A3C
		private static extern void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode); // 0x0000000188C11B60-0x0000000188C11BE4
		private static extern bool criAtomExPlayer_IsPaused(IntPtr player); // 0x0000000188C11940-0x0000000188C11978
		private static extern Status criAtomExPlayer_GetStatus(IntPtr player); // 0x0000000188C1185C-0x0000000188C11890
		private static extern long criAtomExPlayer_GetTime(IntPtr player); // 0x0000000188C11890-0x0000000188C11908
		private static extern void criAtomExPlayer_SetFormat(IntPtr player, CriAtomEx.Format format); // 0x0000000188C128A4-0x0000000188C12928
		private static extern void criAtomExPlayer_SetNumChannels(IntPtr player, int num_channels); // 0x0000000188C12968-0x0000000188C129A8
		private static extern void criAtomExPlayer_SetSamplingRate(IntPtr player, int sampling_rate); // 0x0000000188C12C28-0x0000000188C12CAC
		private static extern IntPtr CRIWAREF1DB6C3C(IntPtr player, int capacity, int max_path, bool stopOnEmpty); // 0x0000000188C0FFF4-0x0000000188C10098
		private static extern void CRIWARE348B99F2(IntPtr pool); // 0x0000000188C0FD28-0x0000000188C0FD5C
		private static extern int CRIWAREB0CA8CB3(IntPtr pool); // 0x0000000188C0FF8C-0x0000000188C0FFC0
		private static extern int CRIWAREF2104D05(IntPtr pool); // 0x0000000188C10098-0x0000000188C100CC
		private static extern void CRIWAREBAFBC575(IntPtr pool); // 0x0000000188C0FFC0-0x0000000188C0FFF4
		private static extern bool CRIWARE5277731E(IntPtr pool, IntPtr binder, string path, bool repeat, int max_path); // 0x0000000188C0FD5C-0x0000000188C0FE2C
		private static extern bool CRIWARE78E74FE0(IntPtr pool, IntPtr binder, int id, bool repeat); // 0x0000000188C0FEF0-0x0000000188C0FF58
		private static extern bool CRIWARE10CB0D07(IntPtr pool, byte[] buffer, int size, bool repeat); // 0x0000000188C0FC0C-0x0000000188C0FCC0
		private static extern bool CRIWARE10CB0D07(IntPtr pool, IntPtr buffer, int size, bool repeat); // 0x0000000188C0FCC0-0x0000000188C0FD28
		private static extern bool CRIWARE59CCEB17(IntPtr pool, IntPtr acbhn, string name, bool repeat); // 0x0000000188C0FE2C-0x0000000188C0FEF0
		private static extern void CRIWARE94DBB2A3(IntPtr pool); // 0x0000000188C0FF58-0x0000000188C0FF8C
		private static extern void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms); // 0x0000000188C12E44-0x0000000188C12EC8
		private static extern void criAtomExPlayer_SetSequencePrepareTime(IntPtr player, uint seq_prep_time_ms); // 0x0000000188C12DC4-0x0000000188C12E04
		private static extern void criAtomExPlayer_LimitLoopCount(IntPtr player, int count); // 0x0000000188C11978-0x0000000188C119B8
		private static extern void criAtomExPlayer_Update(IntPtr player, uint id); // 0x0000000188C131EC-0x0000000188C13270
		private static extern void criAtomExPlayer_UpdateAll(IntPtr player); // 0x0000000188C131B8-0x0000000188C131EC
		private static extern void criAtomExPlayer_ResetParameters(IntPtr player); // 0x0000000188C11B2C-0x0000000188C11B60
		private static extern float criAtomExPlayer_GetParameterFloat32(IntPtr player, CriAtomEx.Parameter id); // 0x0000000188C116A0-0x0000000188C116DC
		private static extern uint criAtomExPlayer_GetParameterUint32(IntPtr player, CriAtomEx.Parameter id); // 0x0000000188C11760-0x0000000188C117E4
		private static extern int criAtomExPlayer_GetParameterSint32(IntPtr player, CriAtomEx.Parameter id); // 0x0000000188C116DC-0x0000000188C11760
		private static extern IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player); // 0x0000000188C117E4-0x0000000188C1185C
		private static extern void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, ushort id); // 0x0000000188C1105C-0x0000000188C110E0
		private static extern void criAtomExPlayer_SetVolume(IntPtr player, float volume); // 0x0000000188C13010-0x0000000188C1304C
		private static extern void criAtomExPlayer_SetPitch(IntPtr player, float pitch); // 0x0000000188C12AF0-0x0000000188C12B2C
		private static extern void criAtomExPlayer_SetPlaybackRatio(IntPtr player, float playback_ratio); // 0x0000000188C12B2C-0x0000000188C12B68
		private static extern void criAtomExPlayer_SetPan3dAngle(IntPtr player, float pan3d_angle); // 0x0000000188C129A8-0x0000000188C129E4
		private static extern void criAtomExPlayer_SetPan3dInteriorDistance(IntPtr player, float pan3d_interior_distance); // 0x0000000188C129E4-0x0000000188C12A28
		private static extern void criAtomExPlayer_SetPan3dVolume(IntPtr player, float pan3d_volume); // 0x0000000188C12A28-0x0000000188C12A6C
		private static extern void criAtomExPlayer_SetPanType(IntPtr player, CriAtomEx.PanType panType); // 0x0000000188C12A6C-0x0000000188C12AF0
		private static extern void criAtomExPlayer_SetSendLevel(IntPtr player, int channel, CriAtomEx.Speaker id, float level); // 0x0000000188C12D68-0x0000000188C12DC4
		private static extern void criAtomExPlayer_SetBusSendLevel(IntPtr player, int bus_id, float level); // 0x0000000188C11FA0-0x0000000188C11FF0
		private static extern void criAtomExPlayer_SetBusSendLevelByName(IntPtr player, string bus_name, float level); // 0x0000000188C11E8C-0x0000000188C11EF4
		private static extern bool criAtomExPlayer_GetBusSendLevelByName(IntPtr player, string bus_name, out float level); // 0x0000000188C11538-0x0000000188C115EC
		private static extern void criAtomExPlayer_SetBusSendLevelOffset(IntPtr player, int bus_id, float level_offset); // 0x0000000188C11F54-0x0000000188C11FA0
		private static extern void criAtomExPlayer_SetBusSendLevelOffsetByName(IntPtr player, string bus_name, float level_offset); // 0x0000000188C11EF4-0x0000000188C11F54
		private static extern bool criAtomExPlayer_GetBusSendLevelOffsetByName(IntPtr player, string bus_name, out float level_offset); // 0x0000000188C115EC-0x0000000188C116A0
		private static extern void criAtomExPlayer_SetBandpassFilterParameters(IntPtr player, float cof_low, float cof_high); // 0x0000000188C11DE4-0x0000000188C11E30
		private static extern void criAtomExPlayer_SetBiquadFilterParameters(IntPtr player, CriAtomEx.BiquadFilterType type, float frequency, float gain, float q); // 0x0000000188C11E30-0x0000000188C11E8C
		private static extern void criAtomExPlayer_SetVoicePriority(IntPtr player, int priority); // 0x0000000188C12F8C-0x0000000188C13010
		private static extern void criAtomExPlayer_SetVoiceControlMethod(IntPtr player, CriAtomEx.VoiceControlMethod method); // 0x0000000188C12EC8-0x0000000188C12F4C
		private static extern void criAtomExPlayer_SetAisacControlById(IntPtr player, ushort control_id, float control_value); // 0x0000000188C11CAC-0x0000000188C11CF8
		private static extern void criAtomExPlayer_SetAisacControlByName(IntPtr player, string control_name, float control_value); // 0x0000000188C11CF8-0x0000000188C11D60
		private static extern void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source); // 0x0000000188C11C28-0x0000000188C11CAC
		private static extern void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener); // 0x0000000188C11BE4-0x0000000188C11C28
		private static extern void criAtomExPlayer_SetCategoryById(IntPtr player, uint category_id); // 0x0000000188C11FF0-0x0000000188C12074
		private static extern void criAtomExPlayer_SetCategoryByName(IntPtr player, string category_name); // 0x0000000188C12074-0x0000000188C1210C
		private static extern void criAtomExPlayer_UnsetCategory(IntPtr player); // 0x0000000188C1312C-0x0000000188C13160
		private static extern void criAtomExPlayer_SetCuePriority(IntPtr player, int cue_priority); // 0x0000000188C12370-0x0000000188C123B0
		private static extern void criAtomExPlayer_SetPreDelayTime(IntPtr player, float predelay_time_ms); // 0x0000000188C12B68-0x0000000188C12BA4
		private static extern void criAtomExPlayer_SetEnvelopeAttackTime(IntPtr player, float attack_time_ms); // 0x0000000188C12534-0x0000000188C12578
		private static extern void criAtomExPlayer_SetEnvelopeHoldTime(IntPtr player, float hold_time_ms); // 0x0000000188C125B4-0x0000000188C125F0
		private static extern void criAtomExPlayer_SetEnvelopeDecayTime(IntPtr player, float decay_time_ms); // 0x0000000188C12578-0x0000000188C125B4
		private static extern void criAtomExPlayer_SetEnvelopeReleaseTime(IntPtr player, float release_time_ms); // 0x0000000188C125F0-0x0000000188C12634
		private static extern void criAtomExPlayer_SetEnvelopeSustainLevel(IntPtr player, float susutain_level); // 0x0000000188C12634-0x0000000188C12678
		private static extern void criAtomExPlayer_AttachFader(IntPtr player, IntPtr config, IntPtr work, int work_size); // 0x0000000188C11138-0x0000000188C111DC
		private static extern void criAtomExPlayer_AttachAisac(IntPtr player, string globalAisacName); // 0x0000000188C110E0-0x0000000188C11138
		private static extern void criAtomExPlayer_DetachAisac(IntPtr player, string globalAisacName); // 0x0000000188C1139C-0x0000000188C113F4
		private static extern void criAtomExPlayer_DetachFader(IntPtr player); // 0x0000000188C113F4-0x0000000188C11428
		private static extern void criAtomExPlayer_SetFadeOutTime(IntPtr player, int ms); // 0x0000000188C1277C-0x0000000188C127BC
		private static extern void criAtomExPlayer_SetFadeInTime(IntPtr player, int ms); // 0x0000000188C126B8-0x0000000188C1273C
		private static extern void criAtomExPlayer_SetFadeInStartOffset(IntPtr player, int ms); // 0x0000000188C12678-0x0000000188C126B8
		private static extern void criAtomExPlayer_SetFadeOutEndDelay(IntPtr player, int ms); // 0x0000000188C1273C-0x0000000188C1277C
		private static extern bool criAtomExPlayer_IsFading(IntPtr player); // 0x0000000188C11908-0x0000000188C11940
		private static extern void criAtomExPlayer_ResetFaderParameters(IntPtr player); // 0x0000000188C11AB4-0x0000000188C11B2C
		private static extern void criAtomExPlayer_SetGroupNumber(IntPtr player, int group_no); // 0x0000000188C12928-0x0000000188C12968
		private static extern bool criAtomExPlayer_GetAttachedAisacInfo(IntPtr player, int aisac_attached_index, IntPtr aisac_info); // 0x0000000188C114A0-0x0000000188C11538
		private static extern void criAtomExPlayer_SetFirstBlockIndex(IntPtr player, int index); // 0x0000000188C12864-0x0000000188C128A4
		private static extern void criAtomExPlayer_SetSelectorLabel(IntPtr player, string selector, string label); // 0x0000000188C12CAC-0x0000000188C12D68
		private static extern void criAtomExPlayer_UnsetSelectorLabel(IntPtr player, string selector); // 0x0000000188C13160-0x0000000188C131B8
		private static extern void criAtomExPlayer_ClearSelectorLabels(IntPtr player); // 0x0000000188C11220-0x0000000188C11254
		private static extern void criAtomExPlayer_SetSoundRendererType(IntPtr player, CriAtomEx.SoundRendererType type); // 0x0000000188C12E04-0x0000000188C12E44
		private static extern void criAtomExPlayer_SetRandomSeed(IntPtr player, uint seed); // 0x0000000188C12BA4-0x0000000188C12C28
		private static extern void CRIWAREF466419F(IntPtr player, bool sw); // 0x0000000188C100CC-0x0000000188C10150
		private static extern void criAtomExPlayer_SetAsrRackId(IntPtr player, int asr_rack_id); // 0x0000000188C11D60-0x0000000188C11DE4
		private static extern void criAtomExPlayer_SetDspParameter(IntPtr player, int id, float value); // 0x0000000188C124E4-0x0000000188C12534
		private static extern void criAtomExPlayer_AttachTween(IntPtr player, IntPtr tween); // 0x0000000188C111DC-0x0000000188C11220
		private static extern void criAtomExPlayer_DetachTween(IntPtr player, IntPtr tween); // 0x0000000188C1145C-0x0000000188C114A0
		private static extern void criAtomExPlayer_DetachTweenAll(IntPtr player); // 0x0000000188C11428-0x0000000188C1145C
	}

	[Obsolete("Use CriAtomExOutputAnalyzer")]
	public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer // TypeDefIndex: 84314
	{
		// Nested types
		public enum Type // TypeDefIndex: 84312
		{
			LevelMeter = 0,
			SpectrumAnalyzer = 1,
			PcmCapture = 2
		}
	
		public struct Config // TypeDefIndex: 84313
		{
			// Fields
			public int num_spectrum_analyzer_bands; // 0x00
			public int num_stored_output_data; // 0x04
	
			// Constructors
			public Config(int num_spectrum_analyzer_bands = 8 /* Metadata: 0x0264448D */, int num_stored_output_data = 4096 /* Metadata: 0x0264448E */); // 0x00000001827241A0-0x00000001827241B0
		}
	
		// Constructors
		public CriAtomExPlayerOutputAnalyzer(Type[] types, Config[] configs = null); // 0x0000000188C0FA90-0x0000000188C0FBB8
	}

	public class CriAtomExSoundObject : CriDisposable // TypeDefIndex: 84316
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		private struct Config // TypeDefIndex: 84315
		{
			// Fields
			public bool enableVoiceLimitScope; // 0x00
			public bool enableCategoryCueLimitScope; // 0x01
		}
	
		// Constructors
		public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope); // 0x0000000188C13760-0x0000000188C13868
	
		// Methods
		public override void Dispose(); // 0x0000000188C136E4-0x0000000188C13760
		public void AddPlayer(CriAtomExPlayer player); // 0x0000000188C13690-0x0000000188C136B4
		public void DeletePlayer(CriAtomExPlayer player); // 0x0000000188C136C0-0x0000000188C136E4
		public void DeleteAllPlayers(); // 0x0000000188C136B4-0x0000000188C136C0
		~CriAtomExSoundObject(); // 0x0000000188BFDFB4-0x0000000188BFE02C
		private static extern IntPtr criAtomExSoundObject_Create(ref Config config, IntPtr work, int work_size); // 0x0000000188C138EC-0x0000000188C139B0
		private static extern void criAtomExSoundObject_Destroy(IntPtr soundObject); // 0x0000000188C13A6C-0x0000000188C13AA0
		private static extern void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player); // 0x0000000188C13868-0x0000000188C138EC
		private static extern void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player); // 0x0000000188C13A28-0x0000000188C13A6C
		private static extern void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject); // 0x0000000188C139B0-0x0000000188C13A28
	}

	public class CriAtomExTween : CriDisposable // TypeDefIndex: 84320
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		internal IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
		public float Value { get; } // 0x0000000188C14210-0x0000000188C1421C 
		public bool IsActive { get; } // 0x0000000188C14204-0x0000000188C14210 
	
		// Nested types
		public enum ParameterType // TypeDefIndex: 84317
		{
			Basic = 0,
			Aisac = 1
		}
	
		private struct Config // TypeDefIndex: 84319
		{
			// Fields
			public Target target; // 0x00
			public ParameterType parameterType; // 0x04
	
			// Nested types
			public struct Target // TypeDefIndex: 84318
			{
				// Fields
				public CriAtomEx.Parameter parameterId; // 0x00
				public uint aisacIds; // 0x00
			}
		}
	
		// Constructors
		public CriAtomExTween(); // 0x0000000188C13E14-0x0000000188C13E24
		public CriAtomExTween(CriAtomEx.Parameter parameterId); // 0x0000000188C13F40-0x0000000188C13F50
		public CriAtomExTween(uint aisacId); // 0x0000000188C13F30-0x0000000188C13F40
		public CriAtomExTween(ParameterType parameterType, uint targetId); // 0x0000000188C13E24-0x0000000188C13F30
	
		// Methods
		public override void Dispose(); // 0x0000000188C13CD0-0x0000000188C13CDC
		public void MoveTo(ushort durationMs, float value); // 0x0000000188C13DF0-0x0000000188C13DFC
		public void MoveFrom(ushort durationMs, float value); // 0x0000000188C13DE4-0x0000000188C13DF0
		public void Stop(); // 0x0000000188C13E08-0x0000000188C13E14
		public void Reset(); // 0x0000000188C13DFC-0x0000000188C13E08
		~CriAtomExTween(); // 0x0000000188C13D6C-0x0000000188C13DE4
		protected virtual void Dispose(bool disposing); // 0x0000000188C13CDC-0x0000000188C13D6C
		private static extern IntPtr criAtomExTween_Create(ref Config config, IntPtr work, int work_size); // 0x0000000188C13F50-0x0000000188C13FE4
		private static extern void criAtomExTween_Destroy(IntPtr tween); // 0x0000000188C13FE4-0x0000000188C1405C
		private static extern float criAtomExTween_GetValue(IntPtr tween); // 0x0000000188C1405C-0x0000000188C14088
		private static extern void criAtomExTween_MoveTo(IntPtr tween, ushort time_ms, float value); // 0x0000000188C1410C-0x0000000188C14158
		private static extern void criAtomExTween_MoveFrom(IntPtr tween, ushort time_ms, float value); // 0x0000000188C140C0-0x0000000188C1410C
		private static extern void criAtomExTween_Stop(IntPtr tween); // 0x0000000188C1418C-0x0000000188C14204
		private static extern void criAtomExTween_Reset(IntPtr tween); // 0x0000000188C14158-0x0000000188C1418C
		private static extern bool criAtomExTween_IsActive(IntPtr tween); // 0x0000000188C14088-0x0000000188C140C0
	}

	public abstract class CriAtomExVoicePool : CriDisposable // TypeDefIndex: 84330
	{
		// Fields
		public const int StandardMemoryAsrVoicePoolId = 0; // Metadata: 0x02644496
		public const int StandardStreamingAsrVoicePoolId = 1; // Metadata: 0x02644497
		public const int StandardMemoryNsrVoicePoolId = 2; // Metadata: 0x02644498
		public const int StandardStreamingNsrVoicePoolId = 3; // Metadata: 0x02644499
		protected IntPtr _handle; // 0x20
		protected uint _identifier; // 0x28
		protected int _numVoices; // 0x2C
		protected int _maxChannels; // 0x30
		protected int _maxSamplingRate; // 0x34
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
		public uint identifier { get; } // 0x0000000182271A60-0x0000000182271A70 
		public int numVoices { get; } // 0x0000000182271A80-0x0000000182271A90 
		public int maxChannels { get; } // 0x000000018226EBA0-0x000000018226EBB0 
		public int maxSamplingRate { get; } // 0x0000000182271A70-0x0000000182271A80 
	
		// Nested types
		public enum VoicePoolId // TypeDefIndex: 84321
		{
			StandardMemory = 0,
			StandardStreaming = 1,
			HcaMxMemory = 4,
			HcaMxStreaming = 5
		}
	
		public enum PitchShifterMode // TypeDefIndex: 84322
		{
			Music = 0,
			Vocal = 1,
			SoundEffect = 2,
			Speech = 3
		}
	
		public struct UsedVoicesInfo // TypeDefIndex: 84323
		{
			// Fields
			public int numUsedVoices; // 0x00
			public int numPoolVoices; // 0x04
		}
	
		protected struct PlayerConfig // TypeDefIndex: 84324
		{
			// Fields
			public int maxChannels; // 0x00
			public int maxSamplingRate; // 0x04
			public bool streamingFlag; // 0x08
			public int soundRendererType; // 0x0C
			public int decodeLatency; // 0x10
			private IntPtr context; // 0x18
		}
	
		protected struct VoicePoolConfig // TypeDefIndex: 84325
		{
			// Fields
			public uint identifier; // 0x00
			public int numVoices; // 0x04
			public PlayerConfig playerConfig; // 0x08
		}
	
		private struct PitchShifterConfig // TypeDefIndex: 84326
		{
			// Fields
			public int mode; // 0x00
			public int windowSize; // 0x04
			public int overlapTimes; // 0x08
		}
	
		private struct ExPitchShifterConfig // TypeDefIndex: 84327
		{
			// Fields
			public int numDsp; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public PitchShifterConfig config; // 0x0C
		}
	
		private struct TimeStretchConfig // TypeDefIndex: 84328
		{
			// Fields
			public int reserved; // 0x00
		}
	
		private struct ExTimeStretchConfig // TypeDefIndex: 84329
		{
			// Fields
			public int numDsp; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public TimeStretchConfig config; // 0x0C
		}
	
		// Constructors
		protected CriAtomExVoicePool(); // 0x0000000188C14434-0x0000000188C14444
	
		// Methods
		public static UsedVoicesInfo GetNumUsedVoices(VoicePoolId voicePoolId); // 0x0000000188C143D4-0x0000000188C14400
		public override void Dispose(); // 0x0000000188C14358-0x0000000188C143D4
		public UsedVoicesInfo GetNumUsedVoices(); // 0x0000000188C14400-0x0000000188C14434
		public void AttachDspTimeStretch(); // 0x0000000188C1426C-0x0000000188C142B0
		public void AttachDspPitchShifter(PitchShifterMode mode = PitchShifterMode.Music /* Metadata: 0x02644492 */, int windosSize = 1024 /* Metadata: 0x02644493 */, int overlapTimes = 4 /* Metadata: 0x02644495 */); // 0x0000000188C1421C-0x0000000188C1426C
		public void DetachDsp(); // 0x0000000188C14344-0x0000000188C14358
		~CriAtomExVoicePool(); // 0x0000000188BFDFB4-0x0000000188BFE02C
		private static extern void CRIWARED389B244(int voice_pool_id, out int num_used_voices, out int num_pool_voices); // 0x0000000188C142B0-0x0000000188C14344
		private static extern void criAtomExVoicePool_GetNumUsedVoices(IntPtr pool, out int num_used_voices, out int num_pool_voices); // 0x0000000188C145F4-0x0000000188C14688
		public static extern void criAtomExVoicePool_Free(IntPtr pool); // 0x0000000188C145C0-0x0000000188C145F4
		private static extern void criAtomExVoicePool_AttachDspTimeStretch(IntPtr pool, ref ExTimeStretchConfig config, IntPtr work, int work_size); // 0x0000000188C144E8-0x0000000188C1458C
		private static extern void criAtomExVoicePool_AttachDspPitchShifter(IntPtr pool, ref ExPitchShifterConfig config, IntPtr work, int work_size); // 0x0000000188C14444-0x0000000188C144E8
		private static extern void criAtomExVoicePool_DetachDsp(IntPtr pool); // 0x0000000188C1458C-0x0000000188C145C0
	}

	public class CriAtomExStandardVoicePool : CriAtomExVoicePool // TypeDefIndex: 84331
	{
		// Constructors
		public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x026444A2 */); // 0x0000000188C13AA0-0x0000000188C13BCC
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x0000000188C13BCC-0x0000000188C13CD0
	}

	public class CriAtomExWaveVoicePool : CriAtomExVoicePool // TypeDefIndex: 84332
	{
		// Constructors
		public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0 /* Metadata: 0x026444A3 */); // 0x0000000188C14688-0x0000000188C147B4
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size); // 0x0000000188C147B4-0x0000000188C148B8
	}

	public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool // TypeDefIndex: 84336
	{
		// Nested types
		public enum RawPcmFormat // TypeDefIndex: 84333
		{
			Sint16 = 0,
			Float32 = 1
		}
	
		protected struct RawPcmPlayerConfig // TypeDefIndex: 84334
		{
			// Fields
			public RawPcmFormat format; // 0x00
			public int maxChannels; // 0x04
			public int maxSamplingRate; // 0x08
			public int soundRendererType; // 0x0C
			public int decodeLatency; // 0x10
			private IntPtr context; // 0x18
		}
	
		protected struct RawPcmVoicePoolConfig // TypeDefIndex: 84335
		{
			// Fields
			public uint identifier; // 0x00
			public int numVoices; // 0x04
			public RawPcmPlayerConfig playerConfig; // 0x08
		}
	
		// Constructors
		public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, RawPcmFormat format, uint identifier = 0 /* Metadata: 0x026444A4 */); // 0x0000000188C134C0-0x0000000188C135FC
	
		// Methods
		private static extern IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref RawPcmVoicePoolConfig config, IntPtr work, int work_size); // 0x0000000188C135FC-0x0000000188C13690
	}

	public class CriAudioReadStream // TypeDefIndex: 84340
	{
		// Fields
		private InternalDelegate internalDelegate; // 0x10
		[CompilerGenerated]
		private IntPtr _callbackFunction_k__BackingField; // 0x18
		[CompilerGenerated]
		private IntPtr _callbackPointer_k__BackingField; // 0x20
	
		// Properties
		public IntPtr callbackFunction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018561CBD0-0x000000018561CBE0
		public IntPtr callbackPointer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x000000018561BB30-0x000000018561BB40
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 84337; 0x00000001811DF7F0-0x00000001811DF810
	
		public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 84338; 0x00000001859B7730-0x00000001859B7740
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 84339
		{
			// Fields
			public int bufferSize; // 0x10
			public CriWare.CriAudioReadStream.Delegate callback; // 0x18
			public int numChannels; // 0x20
			public float[][] buffer; // 0x28
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _.ctor_b__0(IntPtr cbobj, IntPtr data, uint numSamples); // 0x0000000188C210C8-0x0000000188C211BC
		}
	
		// Constructors
		public CriAudioReadStream(IntPtr callbackFunction, IntPtr callbackPointer); // 0x0000000187235F30-0x0000000187235F40
		public CriAudioReadStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x026444A7 */); // 0x0000000188C148B8-0x0000000188C14A38
	}

	public class CriAudioWriteStream // TypeDefIndex: 84344
	{
		// Fields
		private InternalDelegate internalDelegate; // 0x10
		[CompilerGenerated]
		private IntPtr _callbackFunction_k__BackingField; // 0x18
		[CompilerGenerated]
		private IntPtr _callbackPointer_k__BackingField; // 0x20
	
		// Properties
		public IntPtr callbackFunction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018561CBD0-0x000000018561CBE0
		public IntPtr callbackPointer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x000000018561BB30-0x000000018561BB40
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples); // TypeDefIndex: 84341; 0x00000001811DF7F0-0x00000001811DF810
	
		public delegate uint Delegate(float[][] buffer, uint numSamples); // TypeDefIndex: 84342; 0x00000001859B7730-0x00000001859B7740
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 84343
		{
			// Fields
			public int bufferSize; // 0x10
			public int numChannels; // 0x14
			public CriWare.CriAudioWriteStream.Delegate callback; // 0x18
			public float[][] buffer; // 0x20
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _.ctor_b__0(IntPtr cbobj, IntPtr data, uint numSamples); // 0x0000000188C20FDC-0x0000000188C210C8
		}
	
		// Constructors
		public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer); // 0x0000000187235F30-0x0000000187235F40
		public CriAudioWriteStream(Delegate callback, int numChannels, int bufferSize = 256 /* Metadata: 0x026444A9 */); // 0x0000000188C14A38-0x0000000188C14BB8
	}

	public class CriFsLoader : CriDisposable // TypeDefIndex: 84346
	{
		// Fields
		private IntPtr handle; // 0x20
		private GCHandle dstGch; // 0x28
		private GCHandle srcGch; // 0x30
	
		// Nested types
		public enum Status // TypeDefIndex: 84345
		{
			Stop = 0,
			Loading = 1,
			Complete = 2,
			Error = 3
		}
	
		// Constructors
		public CriFsLoader(); // 0x0000000188C18214-0x0000000188C18348
	
		// Methods
		public override void Dispose(); // 0x0000000188C17DF0-0x0000000188C17E40
		private void Dispose(bool disposing); // 0x0000000188C17D60-0x0000000188C17DF0
		public void Load(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer); // 0x0000000188C18134-0x0000000188C181E8
		public void LoadById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer); // 0x0000000188C17F18-0x0000000188C17FCC
		public void LoadWithoutDecompression(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer); // 0x0000000188C18080-0x0000000188C18134
		public void LoadWithoutDecompressionById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer); // 0x0000000188C17FCC-0x0000000188C18080
		public void DecompressData(long srcSize, byte[] srcBuffer, long dstSize, byte[] dstBuffer); // 0x0000000188C17CBC-0x0000000188C17D60
		public void Stop(); // 0x0000000188C18200-0x0000000188C18214
		public Status GetStatus(); // 0x0000000188C17EB8-0x0000000188C17F18
		public void SetReadUnitSize(int unit_size); // 0x0000000188C181E8-0x0000000188C18200
		~CriFsLoader(); // 0x0000000188C17E40-0x0000000188C17EB8
		private static extern int criFsLoader_Create(out IntPtr loader); // 0x0000000188C18348-0x0000000188C183C0
		private static extern int criFsLoader_Destroy(IntPtr loader); // 0x0000000188C18464-0x0000000188C18498
		private static extern int criFsLoader_Load(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x0000000188C1874C-0x0000000188C18834
		private static extern int criFsLoader_LoadById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x0000000188C1851C-0x0000000188C185C0
		private static extern int criFsLoader_Stop(IntPtr loader); // 0x0000000188C188B8-0x0000000188C18930
		private static extern int criFsLoader_GetStatus(IntPtr loader, out Status status); // 0x0000000188C18498-0x0000000188C1851C
		private static extern int criFsLoader_SetReadUnitSize(IntPtr loader, long unit_size); // 0x0000000188C18834-0x0000000188C188B8
		private static extern int criFsLoader_LoadWithoutDecompression(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x0000000188C18664-0x0000000188C1874C
		private static extern int criFsLoader_LoadWithoutDecompressionById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size); // 0x0000000188C185C0-0x0000000188C18664
		private static extern int criFsLoader_DecompressData(IntPtr loader, IntPtr src, long src_size, IntPtr dst, long dst_size); // 0x0000000188C183C0-0x0000000188C18464
	}

	public class CriFsInstaller : CriDisposable // TypeDefIndex: 84349
	{
		// Fields
		private byte[] installBuffer; // 0x20
		private GCHandle installBufferGch; // 0x28
		private IntPtr handle; // 0x30
	
		// Nested types
		public enum Status // TypeDefIndex: 84347
		{
			Stop = 0,
			Busy = 1,
			Complete = 2,
			Error = 3
		}
	
		private enum CopyPolicy // TypeDefIndex: 84348
		{
			Always = 0
		}
	
		// Constructors
		public CriFsInstaller(); // 0x0000000188C17130-0x0000000188C17268
	
		// Methods
		public override void Dispose(); // 0x0000000188C16F60-0x0000000188C16FB0
		private void Dispose(bool disposing); // 0x0000000188C16FB0-0x0000000188C17040
		public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize); // 0x0000000188C16D24-0x0000000188C16F60
		public void Stop(); // 0x0000000188C1711C-0x0000000188C17130
		public Status GetStatus(); // 0x0000000188C170F0-0x0000000188C1711C
		public float GetProgress(); // 0x0000000188C170C0-0x0000000188C170F0
		public static void ExecuteMain(); // 0x0000000188C17040-0x0000000188C17048
		~CriFsInstaller(); // 0x0000000188C17048-0x0000000188C170C0
		private static extern int criFsInstaller_ExecuteMain(); // 0x0000000188C17418-0x0000000188C17444
		private static extern int criFsInstaller_Create(out IntPtr installer, CopyPolicy option); // 0x0000000188C17360-0x0000000188C173E4
		private static extern int criFsInstaller_Destroy(IntPtr installer); // 0x0000000188C173E4-0x0000000188C17418
		private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size); // 0x0000000188C17268-0x0000000188C17360
		private static extern int criFsInstaller_Stop(IntPtr installer); // 0x0000000188C1754C-0x0000000188C17580
		private static extern int criFsInstaller_GetStatus(IntPtr installer, out Status status); // 0x0000000188C174C8-0x0000000188C1754C
		private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress); // 0x0000000188C17444-0x0000000188C174C8
	}

	public class CriFsBinder : CriDisposable // TypeDefIndex: 84352
	{
		// Fields
		private IntPtr handle; // 0x20
	
		// Properties
		public IntPtr nativeHandle { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		public enum Status // TypeDefIndex: 84350
		{
			None = 0,
			Analyze = 1,
			Complete = 2,
			Unbind = 3,
			Removed = 4,
			Invalid = 5,
			Error = 6
		}
	
		public struct ContentsFileInfo // TypeDefIndex: 84351
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
			public ContentsFileInfo(byte[] data, int startIndex); // 0x0000000188C0E004-0x0000000188C0E114
		}
	
		// Constructors
		public CriFsBinder(); // 0x0000000188C16058-0x0000000188C1618C
	
		// Methods
		public override void Dispose(); // 0x0000000188C1566C-0x0000000188C156BC
		private void Dispose(bool disposing); // 0x0000000188C156BC-0x0000000188C15718
		public uint BindCpk(CriFsBinder srcBinder, string path); // 0x0000000188C154C4-0x0000000188C1550C
		public uint BindDirectory(CriFsBinder srcBinder, string path); // 0x0000000188C1550C-0x0000000188C15554
		public uint BindFile(CriFsBinder srcBinder, string path); // 0x0000000188C155B4-0x0000000188C155F4
		public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName); // 0x0000000188C15554-0x0000000188C155B4
		public static void Unbind(uint bindId); // 0x0000000188C1600C-0x0000000188C16058
		public static Status GetStatus(uint bindId); // 0x0000000188C15F58-0x0000000188C15FB4
		public long GetFileSize(string path); // 0x0000000188C15F14-0x0000000188C15F50
		public long GetFileSize(int id); // 0x0000000188C15ED8-0x0000000188C15F14
		public bool GetContentsFileInfo(string path, out ContentsFileInfo info); // 0x0000000188C15AD8-0x0000000188C15CD8
		public bool GetContentsFileInfo(int id, out ContentsFileInfo info); // 0x0000000188C15CD8-0x0000000188C15ED8
		public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info); // 0x0000000188C15790-0x0000000188C15AD8
		public static int GetNumContentsFiles(uint bindId); // 0x0000000188C15F50-0x0000000188C15F58
		public static void SetPriority(uint bindId, int priority); // 0x0000000188C15FB4-0x0000000188C1600C
		~CriFsBinder(); // 0x0000000188C15718-0x0000000188C15790
		private static extern uint criFsBinder_Create(out IntPtr binder); // 0x0000000188C16534-0x0000000188C165AC
		private static extern uint criFsBinder_Destroy(IntPtr binder); // 0x0000000188C165AC-0x0000000188C16624
		private static extern uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x0000000188C1618C-0x0000000188C16264
		private static extern uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x0000000188C16264-0x0000000188C1633C
		private static extern uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId); // 0x0000000188C1645C-0x0000000188C16534
		private static extern uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId); // 0x0000000188C1633C-0x0000000188C1645C
		private static extern int criFsBinder_Unbind(uint bindId); // 0x0000000188C16A50-0x0000000188C16AC8
		private static extern int criFsBinder_GetStatus(uint bindId, out Status status); // 0x0000000188C1694C-0x0000000188C169D0
		private static extern int criFsBinder_GetFileSize(IntPtr binder, string path, out long size); // 0x0000000188C1689C-0x0000000188C1694C
		private static extern int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size); // 0x0000000188C16808-0x0000000188C1689C
		private static extern int criFsBinder_SetPriority(uint bindId, int priority); // 0x0000000188C169D0-0x0000000188C16A50
		private static extern int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info); // 0x0000000188C16758-0x0000000188C16808
		private static extern int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info); // 0x0000000188C16624-0x0000000188C166B8
		private static extern int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num); // 0x0000000188C166B8-0x0000000188C16758
		private static extern int CRIWAREF02BA103(uint id); // 0x0000000188C155F4-0x0000000188C1566C
	}

	public class CriFsRequest : CriDisposable // TypeDefIndex: 84355
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
		public DoneDelegate doneDelegate { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool isDone { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public string error { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
	
		// Nested types
		public delegate void DoneDelegate(CriFsRequest request); // TypeDefIndex: 84353; 0x0000000185B78EA0-0x0000000185B78EB0
	
		[CompilerGenerated]
		private sealed class _CheckDone_d__23 : IEnumerator<object> // TypeDefIndex: 84354
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriFsRequest __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _CheckDone_d__23(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188C20DFC-0x0000000188C20E50
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188C20E50-0x0000000188C20E9C
		}
	
		// Constructors
		public CriFsRequest(); // 0x0000000188C16D1C-0x0000000188C16D24
	
		// Methods
		public override void Dispose(); // 0x0000000188C18E4C-0x0000000188C18EA8
		public virtual void Stop(); // 0x0000000186805BA0-0x0000000186805BB0
		public YieldInstruction WaitForDone(MonoBehaviour mb); // 0x0000000188C18F54-0x0000000188C18F84
		protected virtual void Dispose(bool disposing); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void Update(); // 0x0000000186805BA0-0x0000000186805BB0
		protected void Done(); // 0x0000000188C18EA8-0x0000000188C18ECC
		[IteratorStateMachine(typeof(_CheckDone_d__23))]
		private IEnumerator CheckDone(); // 0x0000000188C18DF0-0x0000000188C18E4C
		~CriFsRequest(); // 0x0000000188C18ECC-0x0000000188C18F54
	}

	public class CriFsLoadFileRequest : CriFsRequest // TypeDefIndex: 84357
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
		public string path { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public byte[] bytes { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
		// Nested types
		private enum Phase // TypeDefIndex: 84356
		{
			Stop = 0,
			Bind = 1,
			Load = 2,
			Done = 3,
			Error = 4
		}
	
		// Constructors
		public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize); // 0x0000000188C17B6C-0x0000000188C17CBC
	
		// Methods
		protected override void Dispose(bool disposing); // 0x0000000188C177A8-0x0000000188C17848
		public override void Stop(); // 0x0000000188C17908-0x0000000188C17934
		public override void Update(); // 0x0000000188C17B30-0x0000000188C17B6C
		private void UpdateBinder(); // 0x0000000188C17934-0x0000000188C1799C
		private void UpdateLoader(); // 0x0000000188C1799C-0x0000000188C17B30
		private void OnError(); // 0x0000000188C17848-0x0000000188C17908
	}

	public class CriFsLoadAssetBundleRequest : CriFsRequest // TypeDefIndex: 84358
	{
		// Fields
		[CompilerGenerated]
		private string _path_k__BackingField; // 0x40
		[CompilerGenerated]
		private AssetBundle _assetBundle_k__BackingField; // 0x48
		private CriFsLoadFileRequest loadFileReq; // 0x50
		private AssetBundleCreateRequest assetBundleReq; // 0x58
	
		// Properties
		public string path { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public AssetBundle assetBundle { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
		// Constructors
		public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize); // 0x0000000188C17708-0x0000000188C177A8
	
		// Methods
		public override void Update(); // 0x0000000188C175E8-0x0000000188C17708
		protected override void Dispose(bool disposing); // 0x0000000188C17580-0x0000000188C175E8
	}

	public class CriFsInstallRequest : CriFsRequest // TypeDefIndex: 84359
	{
		// Fields
		[CompilerGenerated]
		private string _sourcePath_k__BackingField; // 0x40
		[CompilerGenerated]
		private string _destinationPath_k__BackingField; // 0x48
		[CompilerGenerated]
		private float _progress_k__BackingField; // 0x50
	
		// Properties
		public string sourcePath { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public string destinationPath { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public float progress { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
	
		// Constructors
		public CriFsInstallRequest(); // 0x0000000188C16D1C-0x0000000188C16D24
	}

	public class CriFsInstallRequestLegacy : CriFsInstallRequest // TypeDefIndex: 84360
	{
		// Fields
		private CriFsInstaller installer; // 0x58
	
		// Constructors
		public CriFsInstallRequestLegacy(CriFsBinder srcBinder, string srcPath, string dstPath, DoneDelegate doneDelegate, int installBufferSize); // 0x0000000188C16C04-0x0000000188C16D1C
	
		// Methods
		public override void Stop(); // 0x0000000188C16B30-0x0000000188C16B58
		public override void Update(); // 0x0000000188C16B58-0x0000000188C16C04
		protected override void Dispose(bool disposing); // 0x0000000188C16AC8-0x0000000188C16B30
	}

	public class CriFsWebInstallRequest : CriFsInstallRequest // TypeDefIndex: 84361
	{
		// Fields
		private CriFsWebInstaller installer; // 0x58
		private uint crc32; // 0x60
		private bool crc32_set; // 0x64
	
		// Constructors
		public CriFsWebInstallRequest(string srcPath, string dstPath, DoneDelegate doneDelegate); // 0x0000000188C1A29C-0x0000000188C1A3A4
	
		// Methods
		public override void Stop(); // 0x0000000188C1A0F8-0x0000000188C1A120
		public bool GetCRC32(out uint ret_val); // 0x0000000187235F40-0x0000000187235F50
		public override void Update(); // 0x0000000188C1A120-0x0000000188C1A29C
		protected override void Dispose(bool disposing); // 0x0000000188C1A090-0x0000000188C1A0F8
	}

	public class CriFsBindRequest : CriFsRequest // TypeDefIndex: 84363
	{
		// Fields
		[CompilerGenerated]
		private string _path_k__BackingField; // 0x40
		[CompilerGenerated]
		private uint _bindId_k__BackingField; // 0x48
	
		// Properties
		public string path { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public uint bindId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
	
		// Nested types
		public enum BindType // TypeDefIndex: 84362
		{
			Cpk = 0,
			Directory = 1,
			File = 2
		}
	
		// Constructors
		public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path); // 0x0000000188C1538C-0x0000000188C154C4
	
		// Methods
		public override void Stop(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Update(); // 0x0000000188C15328-0x0000000188C1538C
		protected override void Dispose(bool disposing); // 0x0000000188C152DC-0x0000000188C15328
	}

	public static class CriFsUtility // TypeDefIndex: 84364
	{
		// Fields
		public const int DefaultReadUnitSize = 1048576; // Metadata: 0x026444D7
	
		// Methods
		public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576 /* Metadata: 0x026444C3 */); // 0x0000000188C19FD8-0x0000000188C1A024
		public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576 /* Metadata: 0x026444C7 */); // 0x0000000188C19F28-0x0000000188C19F80
		public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x026444CB */); // 0x0000000188C19F80-0x0000000188C19FD8
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576 /* Metadata: 0x026444CF */); // 0x0000000188C19F18-0x0000000188C19F28
		public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576 /* Metadata: 0x026444D3 */); // 0x0000000188C19EC4-0x0000000188C19F18
		public static CriFsInstallRequest Install(string srcPath, string dstPath); // 0x0000000188C19E38-0x0000000188C19E5C
		public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate); // 0x0000000188C19DB4-0x0000000188C19DD8
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath); // 0x0000000188C19DD8-0x0000000188C19E38
		public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate); // 0x0000000188C19E5C-0x0000000188C19EC4
		public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate); // 0x0000000188C1A03C-0x0000000188C1A090
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath); // 0x0000000188C19ABC-0x0000000188C19ACC
		public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath); // 0x0000000188C19ACC-0x0000000188C19B20
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath); // 0x0000000188C19B20-0x0000000188C19B68
		public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath); // 0x0000000188C19B68-0x0000000188C19BBC
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath); // 0x0000000188C19C10-0x0000000188C19C58
		public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath); // 0x0000000188C19BBC-0x0000000188C19C10
		public static void SetUserAgentString(string userAgentString); // 0x0000000188C1A034-0x0000000188C1A03C
		public static void SetProxyServer(string proxyPath, ushort proxyPort); // 0x0000000188C1A02C-0x0000000188C1A034
		public static void SetPathSeparator(string filter); // 0x0000000188C1A024-0x0000000188C1A02C
		private static extern bool CRIWARECD0DC04A(string userAgentString); // 0x0000000188C19D58-0x0000000188C19DB4
		private static extern bool CRIWARE48E31D64(string proxyPath, ushort proxyPort); // 0x0000000188C19CB4-0x0000000188C19D58
		private static extern bool CRIWARE0C80F382(string filter); // 0x0000000188C19C58-0x0000000188C19CB4
	}

	public static class CriFsPlugin // TypeDefIndex: 84365
	{
		// Fields
		private static int initializationCount; // 0x00
		private static bool isConfigured; // 0x04
		public static int defaultInstallBufferSize; // 0x08
		public static int installBufferSize; // 0x0C
	
		// Properties
		public static bool isInitialized { get; } // 0x0000000188C18DA8-0x0000000188C18DF0 
	
		// Constructors
		static CriFsPlugin(); // 0x00000001871D17C0-0x00000001871D1840
	
		// Methods
		public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check); // 0x0000000186648620-0x00000001866486E0
		public static void SetReadDeviceEnabled(int deviceId, bool enabled); // 0x0000000188C18A74-0x0000000188C18B00
		public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio); // 0x0000000186805BA0-0x0000000186805BB0
		public static void InitializeLibrary(); // 0x00000001866480E0-0x00000001866481D0
		public static bool IsLibraryInitialized(); // 0x0000000186647F00-0x0000000186647F50
		public static void FinalizeLibrary(); // 0x0000000188C18988-0x0000000188C18A74
		private static extern void CRIWARE8451156E(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check); // 0x00000001866486E0-0x00000001866487A0
		private static extern void CRIWARE601ABE43(); // 0x00000001866481D0-0x0000000186648200
		public static extern bool CRIWARE1012AF20(); // 0x0000000186647F50-0x0000000186647F90
		private static extern void CRIWARE74A6103A(); // 0x0000000188C18930-0x0000000188C1895C
		public static extern uint CRIWARE785081A5(); // 0x0000000188C1895C-0x0000000188C18988
		public static extern uint criFsLoader_GetRetryCount(); // 0x0000000188C18B00-0x0000000188C18B68
		public static extern int criFs_GetNumBinds(ref int cur, ref int max, ref int limit); // 0x0000000188C18B68-0x0000000188C18BFC
		public static extern int criFs_GetNumUsedLoaders(ref int cur, ref int max, ref int limit); // 0x0000000188C18C90-0x0000000188C18D24
		public static extern int criFs_GetNumUsedInstallers(ref int cur, ref int max, ref int limit); // 0x0000000188C18BFC-0x0000000188C18C90
		private static extern int criFs_SetReadDeviceEnabled(int device_id, bool enabled); // 0x0000000188C18D24-0x0000000188C18DA8
	}

	public class CriFsServer : CriMonoBehaviour // TypeDefIndex: 84366
	{
		// Fields
		private static CriFsServer _instance; // 0x00
		private List<CriFsRequest> requestList; // 0x28
		[CompilerGenerated]
		private int _installBufferSize_k__BackingField; // 0x30
	
		// Properties
		public static CriFsServer instance { get; } // 0x0000000188C19A7C-0x0000000188C19ABC 
		public int installBufferSize { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
	
		// Constructors
		public CriFsServer(); // 0x000000018722E9C0-0x000000018722E9D0
	
		// Methods
		public static void CreateInstance(); // 0x0000000188C1933C-0x0000000188C19410
		public static void DestroyInstance(); // 0x0000000188C19540-0x0000000188C195CC
		private void Awake(); // 0x0000000188C18FD8-0x0000000188C19144
		private void OnDestroy(); // 0x0000000188C197E4-0x0000000188C199C4
		public override void CriInternalUpdate(); // 0x0000000188C19410-0x0000000188C19540
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public void AddRequest(CriFsRequest request); // 0x0000000188C18F84-0x0000000188C18FD8
		public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize); // 0x0000000188C19738-0x0000000188C197E4
		public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize); // 0x0000000188C19694-0x0000000188C19738
		public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate); // 0x0000000188C195CC-0x0000000188C19694
		public CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate); // 0x0000000188C199C4-0x0000000188C19A7C
		public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path); // 0x0000000188C19144-0x0000000188C191EC
		public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path); // 0x0000000188C191EC-0x0000000188C19294
		public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path); // 0x0000000188C19294-0x0000000188C1933C
	}

	public class CriFsWebInstaller : CriDisposable // TypeDefIndex: 84372
	{
		// Fields
		[CompilerGenerated]
		private static bool _isInitialized_k__BackingField; // 0x00
		[CompilerGenerated]
		private static bool _isCrcEnabled_k__BackingField; // 0x01
		public const int InvalidHttpStatusCode = -1; // Metadata: 0x026444DB
		public const long InvalidContentsSize = -1; // Metadata: 0x026444DC
		private IntPtr handle; // 0x20
	
		// Properties
		public static bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000188C1AE84-0x0000000188C1AEBC 0x0000000188C1AEF8-0x0000000188C1AF34
		public static bool isCrcEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000188C1AE4C-0x0000000188C1AE84 0x0000000188C1AEBC-0x0000000188C1AEF8
		public static ModuleConfig defaultModuleConfig { get; } // 0x0000000188C1ADF4-0x0000000188C1AE4C 
	
		// Nested types
		public enum Status // TypeDefIndex: 84367
		{
			Stop = 0,
			Busy = 1,
			Complete = 2,
			Error = 3
		}
	
		public enum Error // TypeDefIndex: 84368
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
	
		public struct StatusInfo // TypeDefIndex: 84369
		{
			// Fields
			public Status status; // 0x00
			public Error error; // 0x04
			public int httpStatusCode; // 0x08
			public long contentsSize; // 0x10
			public long receivedSize; // 0x18
		}
	
		public struct ModuleConfig // TypeDefIndex: 84370
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
	
		public struct ModulePlatformConfig // TypeDefIndex: 84371
		{
			// Fields
			public byte reserved; // 0x00
	
			// Properties
			public static ModulePlatformConfig defaultConfig { get; } // 0x00000001843FFFF0-0x0000000184400000 
		}
	
		// Constructors
		public CriFsWebInstaller(); // 0x0000000188C1A8C0-0x0000000188C1A980
	
		// Methods
		~CriFsWebInstaller(); // 0x0000000188C1A570-0x0000000188C1A5E8
		public override void Dispose(); // 0x0000000188C1A3B0-0x0000000188C1A400
		public void Copy(string url, string dstPath); // 0x0000000188C1A3A4-0x0000000188C1A3B0
		public void Stop(); // 0x0000000188C1A8AC-0x0000000188C1A8C0
		public StatusInfo GetStatusInfo(); // 0x0000000188C1A66C-0x0000000188C1A6B8
		public bool GetCRC32(out uint ret_val); // 0x0000000188C1A5E8-0x0000000188C1A604
		public static void InitializeModule(ModuleConfig config); // 0x0000000188C1A6B8-0x0000000188C1A894
		private static System.Type GetCriFsWebInstallerCurlExpansionClass(); // 0x0000000188C1A604-0x0000000188C1A66C
		public static void FinalizeModule(); // 0x0000000188C1A4C8-0x0000000188C1A570
		public static void ExecuteMain(); // 0x0000000188C1A4C0-0x0000000188C1A4C8
		public static bool SetRequestHeader(string field, string value); // 0x0000000188C1A894-0x0000000188C1A8AC
		private void Dispose(bool disposing); // 0x0000000188C1A400-0x0000000188C1A4C0
		private static extern int criFsWebInstaller_Initialize(in ModuleConfig config); // 0x0000000188C1AC58-0x0000000188C1AD00
		private static extern int criFsWebInstaller_Finalize(); // 0x0000000188C1AB24-0x0000000188C1AB50
		private static extern int criFsWebInstaller_ExecuteMain(); // 0x0000000188C1AAF8-0x0000000188C1AB24
		private static extern int criFsWebInstaller_Create(out IntPtr installer); // 0x0000000188C1AA4C-0x0000000188C1AAC4
		private static extern int criFsWebInstaller_Destroy(IntPtr installer); // 0x0000000188C1AAC4-0x0000000188C1AAF8
		private static extern int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath); // 0x0000000188C1A980-0x0000000188C1AA4C
		private static extern int criFsWebInstaller_Stop(IntPtr installer); // 0x0000000188C1ADC0-0x0000000188C1ADF4
		private static extern int criFsWebInstaller_GetStatusInfo(IntPtr installer, out StatusInfo status); // 0x0000000188C1ABD4-0x0000000188C1AC58
		private static extern int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32); // 0x0000000188C1AB50-0x0000000188C1ABD4
		private static extern int criFsWebInstaller_SetRequestHeader(string field, string value); // 0x0000000188C1AD00-0x0000000188C1ADC0
	}

	public class CriManaPlugin // TypeDefIndex: 84373
	{
		// Fields
		private static int initializationCount; // 0x00
		private static bool isConfigured; // 0x04
		private static bool enabledMultithreadedRendering; // 0x05
		public static int renderingEventOffset; // 0x08
	
		// Properties
		public static bool isInitialized { get; } // 0x0000000188C1F850-0x0000000188C1F898 
		public static bool isMultithreadedRenderingEnabled { get; } // 0x0000000188C1F898-0x0000000188C1F8E8 
	
		// Constructors
		public CriManaPlugin(); // 0x0000000186805BA0-0x0000000186805BB0
		static CriManaPlugin(); // 0x00000001871D75D0-0x00000001871D7650
	
		// Methods
		public static void SetConfigParameters(bool graphicsMultiThreaded, int num_decoders, int max_num_of_entries); // 0x0000000185B004B0-0x0000000185B00580
		private static void SetupVp9(); // 0x0000000186DDC600-0x0000000186DDC700
		[Obsolete("Use CriWareVITA.EnableH264Playback and CriWareVITA.SetH264DecoderMaxSize instead.")]
		public static void SetConfigAdditonalParameters_VITA(bool use_h264_playback, int width, int height); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetConfigAdditonalParameters_PC(bool use_h264_playback); // 0x0000000186647F90-0x0000000186647FE0
		public static void SetConfigAdditonalParameters_ANDROID(bool enable_buffer_output_for_h264, bool enable_buffer_output_for_vp9); // 0x0000000186805BA0-0x0000000186805BB0
		public static void SetConfigAdditonalParameters_WEBGL(string webworkerPath, uint heapSize); // 0x0000000186805BA0-0x0000000186805BB0
		public static void InitializeLibrary(); // 0x0000000185AFF9D0-0x0000000185AFFB20
		public static bool IsLibraryInitialized(); // 0x0000000185AFE9B0-0x0000000185AFEA00
		public static void FinalizeLibrary(); // 0x0000000188C1F45C-0x0000000188C1F590
		public static bool IsCodecSupported(CodecType codecType); // 0x0000000188C1F5D0-0x0000000188C1F6C0
		private static System.Type GetVp9ExpansionClass(); // 0x00000001858DE990-0x00000001858DEA40
		private static bool IsVp9CodecSupported(); // 0x0000000186DDC700-0x0000000186DDC7F0
		private static bool IsH264CodecSupported(); // 0x00000001851A4410-0x00000001851A4420
		public static void SetDecodeThreadPriorityAndroidExperimental(int prio); // 0x0000000186805BA0-0x0000000186805BB0
		public static bool ShouldSampleRed(GraphicsDeviceType type, IntPtr tex_ptr); // 0x00000001843FFFF0-0x0000000184400000
		public static void Lock(); // 0x0000000188C1F6C0-0x0000000188C1F700
		public static void Unlock(); // 0x0000000188C1F700-0x0000000188C1F740
		public static uint GetPrimeBufferAlignmentSize(); // 0x0000000188C1F590-0x0000000188C1F5D0
		private static extern void CRIWARECFA78B41(int graphics_api, bool graphics_multi_threaded, int num_decoders, int num_of_max_entries); // 0x0000000185B00600-0x0000000185B006A0
		private static extern void CRIWARE7BFC56AA(); // 0x0000000185AFFB20-0x0000000185AFFB50
		public static extern bool CRIWARE611B78A5(); // 0x0000000185AFEA00-0x0000000185AFEA40
		private static extern void CRIWARED672C36F(); // 0x0000000188C1F430-0x0000000188C1F45C
		public static extern void CRIWARE9F182D39(bool flag); // 0x0000000188C1F3FC-0x0000000188C1F430
		public static extern void CRIWARE06C87176(); // 0x0000000188C1F378-0x0000000188C1F3A4
		public static extern void CRIWARE46E1A37B(); // 0x0000000188C1F3D0-0x0000000188C1F3FC
		private static extern uint criManaUnity_GetPrimeBufferAlignmentSize(); // 0x0000000188C1F740-0x0000000188C1F7A8
		public static extern void criMana_UseStreamerManager(bool flag); // 0x0000000188C1F7D8-0x0000000188C1F850
		public static extern bool criMana_IsStreamerManagerUsed(); // 0x0000000188C1F7A8-0x0000000188C1F7D8
		public static extern uint CRIWARE257CA763(); // 0x0000000188C1F3A4-0x0000000188C1F3D0
		public static extern void CRIWARE62B7B053(bool enable); // 0x0000000186647FE0-0x0000000186648020
	}

	public class CriManaAmbisonicSource : CriMonoBehaviour // TypeDefIndex: 84374
	{
		// Fields
		private CriAtomEx3dSource atomEx3DsourceForAmbisonics; // 0x28
		private Vector3 ambisonicSourceOrientationFront; // 0x30
		private Vector3 ambisonicSourceOrientationTop; // 0x3C
		private Vector3 lastEulerOfAmbisonicSource; // 0x48
	
		// Constructors
		public CriManaAmbisonicSource(); // 0x000000018722E9C0-0x000000018722E9D0
	
		// Methods
		public override void CriInternalUpdate(); // 0x0000000188C1AF34-0x0000000188C1AF3C
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnEnable(); // 0x0000000188C1AFE4-0x0000000188C1B0C8
		private void ForceUpdateAmbisonicSourceOrientation(); // 0x0000000188C1AF3C-0x0000000188C1AFE4
		private void UpdateAmbisonicSourceOrientation(); // 0x0000000188C1B4D4-0x0000000188C1B574
		private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler); // 0x0000000188C1B0C8-0x0000000188C1B4D4
	}

	[AddComponentMenu("CRIWARE/CriManaMovieController")]
	public class CriManaMovieController : CriManaMovieMaterial // TypeDefIndex: 84375
	{
		// Fields
		public Renderer target; // 0x98
		public bool useOriginalMaterial; // 0xA0
		private Material originalMaterial; // 0xA8
	
		// Constructors
		public CriManaMovieController(); // 0x0000000187190910-0x0000000187190920
	
		// Methods
		public override void CriInternalUpdate(); // 0x0000000188C1E650-0x0000000188C1E6F0
		public override bool RenderTargetManualSetup(); // 0x0000000188C1E864-0x0000000188C1E9A4
		public override void RenderTargetManualFinalize(); // 0x0000000188C1E7B4-0x0000000188C1E864
		protected override void OnMaterialAvailableChanged(); // 0x0000000188C1E6F0-0x0000000188C1E7B4
	}

	[AddComponentMenu("CRIWARE/CriManaMovieControllerForUI")]
	public class CriManaMovieControllerForUI : CriManaMovieMaterial // TypeDefIndex: 84376
	{
		// Fields
		public Graphic target; // 0x98
		public bool useOriginalMaterial; // 0xA0
		private Material originalMaterial; // 0xA8
	
		// Constructors
		public CriManaMovieControllerForUI(); // 0x0000000187190910-0x0000000187190920
	
		// Methods
		protected override void Awake(); // 0x00000001870DCFB0-0x00000001870DCFE0
		public override void CriInternalUpdate(); // 0x00000001869A7F80-0x00000001869A7FD0
		public override bool RenderTargetManualSetup(); // 0x0000000186FCEEC0-0x0000000186FCF030
		public override void RenderTargetManualFinalize(); // 0x00000001852DCF20-0x00000001852DD010
		protected override void OnMaterialAvailableChanged(); // 0x00000001852DD010-0x00000001852DD130
	}

	[AddComponentMenu("CRIWARE/CriManaMovieMaterial")]
	public class CriManaMovieMaterial : CriManaMovieMaterialBase // TypeDefIndex: 84377
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
		public string moviePath { get; set; } // 0x00000001828D49D0-0x00000001828D49E0 0x0000000188C1F294-0x0000000188C1F30C
		public bool loop { get; set; } // 0x000000018236FC60-0x000000018236FC70 0x0000000188C1F228-0x0000000188C1F294
		public bool advancedAudio { get; set; } // 0x0000000187235FB0-0x0000000187235FC0 0x0000000188C1ED28-0x0000000188C1EDA8
		public bool ambisonics { get; set; } // 0x000000018236FC80-0x000000018236FC90 0x0000000188C1EDA8-0x0000000188C1F1BC
		public bool additiveMode { get; set; } // 0x0000000187235FA0-0x0000000187235FB0 0x0000000188C1ECBC-0x0000000188C1ED28
		public bool useMaterialBlendMode { get; set; } // 0x0000000187235FE0-0x0000000187235FF0 0x0000000188C1F30C-0x0000000188C1F378
		public bool applyTargetAlpha { get; set; } // 0x0000000187235FC0-0x0000000187235FD0 0x0000000188C1F1BC-0x0000000188C1F228
		public bool uiRenderMode { get; set; } // 0x0000000187235FD0-0x0000000187235FE0 0x00000001870DCFE0-0x00000001870DD040
		protected override uint FilePathLength { get; } // 0x00000001871EC8A0-0x00000001871EC8D0 
		protected override bool initializeWithAdvancedAudio { get; } // 0x0000000187235FB0-0x0000000187235FC0 
		protected override bool initializeWithAmbisonics { get; } // 0x000000018236FC80-0x000000018236FC90 
	
		// Constructors
		public CriManaMovieMaterial(); // 0x0000000187190910-0x0000000187190920
	
		// Methods
		protected override void SetDataToPlayer(); // 0x0000000186FACA50-0x0000000186FACB00
	}

	public abstract class CriManaMovieMaterialBase : CriMonoBehaviour // TypeDefIndex: 84383
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
		public MaxFrameDrop maxFrameDrop { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000188C1EC84-0x0000000188C1EC9C
		protected abstract bool initializeWithAdvancedAudio { get; }
		protected abstract bool initializeWithAmbisonics { get; }
		public bool isMaterialAvailable { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE00-0x000000018226EE10 0x000000018226EE10-0x000000018226EE20
		public Player player { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public Material material { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x0000000187186FA0-0x0000000187187030
		public Player.TimerType timerType { get; set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000188C1EC9C-0x0000000188C1ECBC
		protected abstract uint FilePathLength { get; }
		protected bool HaveRendererOwner { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235F80-0x0000000187235F90 0x0000000187235F90-0x0000000187235FA0
	
		// Nested types
		public enum MaxFrameDrop // TypeDefIndex: 84378
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
	
		public enum RenderMode // TypeDefIndex: 84379
		{
			Always = 0,
			OnVisibility = 1,
			Never = 2
		}
	
		public delegate void OnApplicationPauseCallback(CriManaMovieMaterialBase manaMovieMaterial, bool appPause); // TypeDefIndex: 84380; 0x00000001859B7730-0x00000001859B7740
	
		[CompilerGenerated]
		private struct _AsyncDispose_d__53 : IAsyncStateMachine // TypeDefIndex: 84381
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public Player player; // 0x28
			private TaskAwaiter __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000188C20C74-0x0000000188C20DFC
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018783BAEC-0x000000018783BAF8
		}
	
		[CompilerGenerated]
		private sealed class _RestartPlayerRoutine_d__60 : IEnumerator<object> // TypeDefIndex: 84382
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriManaMovieMaterialBase __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _RestartPlayerRoutine_d__60(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188C20E9C-0x0000000188C20F90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188C20F90-0x0000000188C20FDC
		}
	
		// Constructors
		protected CriManaMovieMaterialBase(); // 0x0000000185958F30-0x0000000185958FA0
	
		// Methods
		protected abstract void SetDataToPlayer();
		public void Play(); // 0x00000001852D8410-0x00000001852D8450
		public void Stop(); // 0x00000001852D8170-0x00000001852D81B0
		public void Pause(bool sw); // 0x0000000188C1EB34-0x0000000188C1EB60
		protected virtual void OnMaterialAvailableChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnMaterialUpdated(); // 0x0000000186805BA0-0x0000000186805BB0
		public void PlayerManualInitialize(); // 0x0000000185AFE610-0x0000000185AFE7C0
		public void PlayerManualFinalize(); // 0x0000000185AFE370-0x0000000185AFE3C0
		private async void AsyncDispose(Player player); // 0x0000000188C1E9A4-0x0000000188C1EA44
		public void PlayerManualSetup(); // 0x000000018707E7C0-0x000000018707E8D0
		public virtual bool RenderTargetManualSetup(); // 0x00000001851A4410-0x00000001851A4420
		public virtual void RenderTargetManualFinalize(); // 0x0000000186805BA0-0x0000000186805BB0
		public void PlayerManualUpdate(); // 0x00000001852DA160-0x00000001852DA260
		protected virtual void Awake(); // 0x000000018783D914-0x000000018783D91C
		protected override void OnEnable(); // 0x0000000185B015A0-0x0000000185B015D0
		[IteratorStateMachine(typeof(_RestartPlayerRoutine_d__60))]
		private IEnumerator RestartPlayerRoutine(); // 0x0000000188C1EC28-0x0000000188C1EC84
		protected override void OnDisable(); // 0x0000000186C1A640-0x0000000186C1A6A0
		protected virtual void OnDestroy(); // 0x0000000185AFF9A0-0x0000000185AFF9D0
		protected virtual void Start(); // 0x000000018707E770-0x000000018707E7C0
		public override void CriInternalUpdate(); // 0x000000018783CCF8-0x000000018783CD00
		public virtual void RenderMovie(); // 0x0000000188C1EC00-0x0000000188C1EC28
		public override void CriInternalLateUpdate(); // 0x00000001852DA0F0-0x00000001852DA120
		protected virtual void OnWillRenderObject(); // 0x0000000188C1EB04-0x0000000188C1EB34
		private void OnApplicationPause(bool appPause); // 0x0000000188C1EAFC-0x0000000188C1EB04
		private void ProcessApplicationPause(bool appPause); // 0x0000000188C1EB60-0x0000000188C1EC00
		private void CreateMaterial(); // 0x0000000188C1EA44-0x0000000188C1EAFC
	}

	public class CriManaMoviePlayerHolder : CriMonoBehaviour // TypeDefIndex: 84384
	{
		// Fields
		private Player _player; // 0x28
	
		// Properties
		public Player player { set; } // 0x0000000185CA30F0-0x0000000185CA3100
	
		// Constructors
		public CriManaMoviePlayerHolder(); // 0x000000018722E9C0-0x000000018722E9D0
	
		// Methods
		private void Awake(); // 0x00000001871CB320-0x00000001871CB370
		public override void CriInternalUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		private void Start(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class Common // TypeDefIndex: 84386
	{
		// Fields
		private const string scriptVersionString = "1.0.9(2.40.31_PS5SDKUpdate)"; // Metadata: 0x02644500
		public const bool supportsCriFsInstaller = true; // Metadata: 0x0264451C
		public const bool supportsCriFsWebInstaller = true; // Metadata: 0x0264451D
		public const string pluginName = "cri_ware_unity"; // Metadata: 0x0264451E
		public const CallingConvention pluginCallingConvention = CallingConvention.Cdecl; // Metadata: 0x0264452D
		private static GameObject _managerObject; // 0x00
	
		// Properties
		public static string streamingAssetsPath { get; } // 0x00000001866475D0-0x0000000186647620 
		public static string installTargetPath { get; } // 0x0000000188C0DFFC-0x0000000188C0E004 
		public static string installCachePath { get; } // 0x0000000188C0DFD4-0x0000000188C0DFFC 
		public static GameObject managerObject { get; } // 0x0000000185B013B0-0x0000000185B015A0 
	
		// Nested types
		public struct CpuUsage // TypeDefIndex: 84385
		{
			// Fields
			public float last; // 0x00
			public float average; // 0x04
			public float peak; // 0x08
		}
	
		// Constructors
		public Common(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static bool IsStreamingAssetsPath(string path); // 0x0000000186648280-0x0000000186648300
		public static string GetScriptVersionString(); // 0x0000000188C0DFA8-0x0000000188C0DFD4
		public static int GetBinaryVersionNumber(); // 0x000000018783C580-0x000000018783C588
		public static int GetRequiredBinaryVersionNumber(); // 0x0000000187235F20-0x0000000187235F30
		public static bool CheckBinaryVersionCompatibility(); // 0x0000000186648090-0x00000001866480E0
		public static uint GetFsMemoryUsage(); // 0x0000000188C0DF28-0x0000000188C0DF68
		public static uint GetAtomMemoryUsage(); // 0x0000000188C0DEE8-0x0000000188C0DF28
		public static uint GetManaMemoryUsage(); // 0x0000000188C0DF68-0x0000000188C0DFA8
		public static CpuUsage GetAtomCpuUsage(); // 0x0000000188C0DE94-0x0000000188C0DEE8
		public static extern int CRIWAREC8077C29(); // 0x00000001871C75E0-0x00000001871C7610
		public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset); // 0x0000000185B00580-0x0000000185B00600
	}

	public static class CriWareDecrypter // TypeDefIndex: 84388
	{
		// Fields
		private static ulong temporalStorage; // 0x00
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate ulong CallbackFromNativeDelegate(IntPtr ptr1); // TypeDefIndex: 84387; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		public static bool Initialize(CriWareDecrypterConfig config); // 0x0000000188C1F920-0x0000000188C1F954
		public static bool Initialize(string key, string authenticationFile, bool enableAtomDecryption, bool enableManaDecryption); // 0x0000000186647760-0x0000000186647920
		[AOT.MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
		private static ulong CallbackFromNative(IntPtr ptr1); // 0x0000000188C1F8E8-0x0000000188C1F920
		public static extern int CRIWARE05CA8EB2(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj); // 0x0000000185AFBAB0-0x0000000185AFBB60
	}

	[AddComponentMenu("CRIWARE/Error Handler")]
	public class CriWareErrorHandler : CriMonoBehaviour // TypeDefIndex: 84390
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
		public static string errorMessage { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000188C1FE48-0x0000000188C1FE98 0x0000000188C1FE98-0x0000000188C1FEF4
	
		// Events
		public static event Callback OnCallback {
			add; // 0x0000000186C59990-0x0000000186C59A80
			remove; // 0x0000000186C59A80-0x0000000186C59B70
		}
	
		// Nested types
		public delegate void Callback(string message); // TypeDefIndex: 84389; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public CriWareErrorHandler(); // 0x0000000187178C50-0x0000000187178CE0
		static CriWareErrorHandler(); // 0x00000001870F1270-0x00000001870F1340
	
		// Methods
		private void Awake(); // 0x0000000185B00770-0x0000000185B00900
		protected override void OnEnable(); // 0x0000000185B00990-0x0000000185B00A40
		protected override void OnDisable(); // 0x0000000188C1FB34-0x0000000188C1FC14
		public override void CriInternalUpdate(); // 0x000000018611B850-0x000000018611B8D0
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDestroy(); // 0x0000000188C1FA18-0x0000000188C1FB34
		private void DequeueErrorMessages(); // 0x000000018611B850-0x000000018611B8D0
		private void HandleMessage(string errmsg); // 0x0000000188C1F954-0x0000000188C1FA18
		private static void OutputDefaultLog(string errmsg); // 0x0000000188C1FC14-0x0000000188C1FE48
	}

	public static class CriErrorNotifier // TypeDefIndex: 84394
	{
		// Fields
		[CompilerGenerated]
		private static Callback _onCallbackThreadUnsafe; // 0x00
		private static object objectLock; // 0x08
	
		// Events
		private static event Callback _onCallbackThreadUnsafe {
			add; // 0x00000001870F0D50-0x00000001870F0E40
			remove; // 0x0000000188C15210-0x0000000188C152DC
		}
		public static event Callback OnCallbackThreadUnsafe {
			add; // 0x0000000185AFBEE0-0x0000000185AFC670
			remove; // 0x0000000188C150C8-0x0000000188C15210
		}
	
		// Nested types
		public delegate void Callback(string message); // TypeDefIndex: 84391; 0x0000000185B78EA0-0x0000000185B78EB0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void ErrorCallbackFunc(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray); // TypeDefIndex: 84392; 0x00000001811CDB70-0x00000001811CDB90
	
		public static class NativeMethod // TypeDefIndex: 84393
		{
			// Methods
			internal static extern void criErr_SetCallback(ErrorCallbackFunc callback); // 0x0000000185AFC670-0x0000000185AFC6B0
			internal static extern IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2); // 0x0000000188C20844-0x0000000188C208D8
		}
	
		// Constructors
		static CriErrorNotifier(); // 0x0000000187170A30-0x0000000187170AD0
	
		// Methods
		public static bool IsRegistered(Callback target); // 0x0000000186ADE9A0-0x0000000186ADEAB0
		public static void CallEvent(string message); // 0x0000000188C14FB8-0x0000000188C15038
		[AOT.MonoPInvokeCallback(typeof(ErrorCallbackFunc))]
		private static void ErrorCallbackFromNative(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray); // 0x0000000188C15038-0x0000000188C150C8
	}

	[Serializable]
	public class CriFsConfig // TypeDefIndex: 84395
	{
		// Fields
		public const int defaultAndroidDeviceReadBitrate = 50000000; // Metadata: 0x0264452E
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
		public CriFsConfig(); // 0x0000000186BAECA0-0x0000000186BAED50
	}

	[Serializable]
	public class CriAtomConfig // TypeDefIndex: 84411
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
		public class StandardVoicePoolConfig // TypeDefIndex: 84396
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public StandardVoicePoolConfig(); // 0x0000000187236040-0x0000000187236050
		}
	
		[Serializable]
		public class HcaMxVoicePoolConfig // TypeDefIndex: 84397
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public HcaMxVoicePoolConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public enum InGamePreviewSwitchMode // TypeDefIndex: 84398
		{
			Disable = 0,
			Enable = 1,
			FollowBuildSetting = 2,
			Default = 3
		}
	
		[Serializable]
		public class InGamePreviewConfig // TypeDefIndex: 84399
		{
			// Fields
			public int maxPreviewObjects; // 0x10
			public int communicationBufferSize; // 0x14
			public int playbackPositionUpdateInterval; // 0x18
	
			// Constructors
			public InGamePreviewConfig(); // 0x0000000187236010-0x0000000187236030
		}
	
		[Serializable]
		public class EditorPcmOutputConfig // TypeDefIndex: 84400
		{
			// Fields
			public bool enable; // 0x10
			public int bufferLength; // 0x14
	
			// Constructors
			public EditorPcmOutputConfig(); // 0x0000000187236000-0x0000000187236010
		}
	
		public enum LinuxOutput // TypeDefIndex: 84401
		{
			Default = 0,
			PulseAudio = 1,
			ALSA = 2
		}
	
		[Serializable]
		public class AndroidLowLatencyStandardVoicePoolConfig // TypeDefIndex: 84402
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public AndroidLowLatencyStandardVoicePoolConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class VitaManaVoicePoolConfig // TypeDefIndex: 84403
		{
			// Fields
			public int numberOfManaDecoders; // 0x10
	
			// Constructors
			public VitaManaVoicePoolConfig(); // 0x0000000187236060-0x0000000187236070
		}
	
		[Serializable]
		public class VitaAtrac9VoicePoolConfig // TypeDefIndex: 84404
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public VitaAtrac9VoicePoolConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class Ps4Atrac9VoicePoolConfig // TypeDefIndex: 84405
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public Ps4Atrac9VoicePoolConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class Ps5PortConfig // TypeDefIndex: 84406
		{
			// Fields
			public int maxChannelPorts; // 0x10
			public int maxObjectPorts; // 0x14
	
			// Constructors
			public Ps5PortConfig(); // 0x0000000187236030-0x0000000187236040
		}
	
		[Serializable]
		public class SwitchOpusVoicePoolConfig // TypeDefIndex: 84407
		{
			// Fields
			public int memoryVoices; // 0x10
			public int streamingVoices; // 0x14
	
			// Constructors
			public SwitchOpusVoicePoolConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class Ps4Audio3dConfig // TypeDefIndex: 84409
		{
			// Fields
			public bool useAudio3D; // 0x10
			public VoicePoolConfig voicePoolConfig; // 0x18
	
			// Nested types
			[Serializable]
			public class VoicePoolConfig // TypeDefIndex: 84408
			{
				// Fields
				public int memoryVoices; // 0x10
				public int streamingVoices; // 0x14
	
				// Constructors
				public VoicePoolConfig(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public Ps4Audio3dConfig(); // 0x0000000186BAF220-0x0000000186BAF270
		}
	
		[Serializable]
		public class WebGLWebAudioVoicePoolConfig // TypeDefIndex: 84410
		{
			// Fields
			public int voices; // 0x10
	
			// Constructors
			public WebGLWebAudioVoicePoolConfig(); // 0x0000000187236070-0x0000000187236080
		}
	
		// Constructors
		public CriAtomConfig(); // 0x0000000186BAEE80-0x0000000186BAF220
	}

	[Serializable]
	public class CriManaConfig // TypeDefIndex: 84415
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
		public class PCH264PlaybackConfig // TypeDefIndex: 84412
		{
			// Fields
			public bool useH264Playback; // 0x10
	
			// Constructors
			public PCH264PlaybackConfig(); // 0x00000001829D07F0-0x00000001829D0800
		}
	
		[Serializable]
		public class VitaH264PlaybackConfig // TypeDefIndex: 84413
		{
			// Fields
			public bool useH264Playback; // 0x10
			public int maxWidth; // 0x14
			public int maxHeight; // 0x18
			public bool getMemoryFromTexture; // 0x1C
	
			// Constructors
			public VitaH264PlaybackConfig(); // 0x0000000187236050-0x0000000187236060
		}
	
		[Serializable]
		public class WebGLConfig // TypeDefIndex: 84414
		{
			// Fields
			public string webworkerPath; // 0x10
			public int heapSize; // 0x18
	
			// Constructors
			public WebGLConfig(); // 0x0000000186BAEE30-0x0000000186BAEE80
		}
	
		// Constructors
		public CriManaConfig(); // 0x0000000186BAED50-0x0000000186BAEE30
	}

	[Serializable]
	public class CriWareDecrypterConfig // TypeDefIndex: 84416
	{
		// Fields
		public string key; // 0x10
		public string authenticationFile; // 0x18
		public bool enableAtomDecryption; // 0x20
		public bool enableManaDecryption; // 0x21
	
		// Constructors
		public CriWareDecrypterConfig(); // 0x0000000186BAEC40-0x0000000186BAECA0
	}

	[AddComponentMenu("CRIWARE/Library Initializer")]
	public class CriWareInitializer : CriMonoBehaviour // TypeDefIndex: 84417
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
		public CriWareInitializer(); // 0x0000000186BAEB10-0x0000000186BAEC40
	
		// Methods
		private void Awake(); // 0x0000000186648020-0x0000000186648040
		protected override void OnEnable(); // 0x0000000185B00980-0x0000000185B00990
		private void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDestroy(); // 0x0000000188C1FF78-0x0000000188C1FF80
		public override void CriInternalUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void CriInternalLateUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		public void Initialize(); // 0x0000000186647D10-0x0000000186647F00
		public void Shutdown(); // 0x0000000188C1FF80-0x0000000188C20050
		public static bool IsInitialized(); // 0x0000000186648040-0x0000000186648090
		public static void AddAudioEffectInterface(IntPtr effect_interface); // 0x0000000188C1FEF4-0x0000000188C1FF70
		public static bool InitializeFileSystem(CriFsConfig config); // 0x0000000186647BC0-0x0000000186647D10
		public static bool InitializeAtom(CriAtomConfig config); // 0x0000000185AFF360-0x0000000185AFF7F0
		public static bool InitializeMana(CriManaConfig config); // 0x0000000185AFF170-0x0000000185AFF290
		[Obsolete("Use CriWareDecypter.Initialize")]
		public static bool InitializeDecrypter(CriWareDecrypterConfig config); // 0x0000000188C1FF70-0x0000000188C1FF78
	}

	public static class CriAtomExDebug // TypeDefIndex: 84419
	{
		// Nested types
		public struct ResourcesInfo // TypeDefIndex: 84418
		{
			// Fields
			public CriAtomEx.ResourceUsage virtualVoiceUsage; // 0x00
			public CriAtomEx.ResourceUsage sequenceUsage; // 0x08
			public CriAtomEx.ResourceUsage sequenceTrackUsage; // 0x10
			public CriAtomEx.ResourceUsage sequenceTrackItemUsage; // 0x18
		}
	
		// Methods
		public static void GetResourcesInfo(out ResourcesInfo resourcesInfo); // 0x0000000188C0ECFC-0x0000000188C0ED04
		private static extern void criAtomExDebug_GetResourcesInfo(out ResourcesInfo resourcesInfo); // 0x0000000188C0ED04-0x0000000188C0ED7C
	}

	public static class CriAtomExAcfDebug // TypeDefIndex: 84433
	{
		// Nested types
		public struct CategoryInfo // TypeDefIndex: 84420
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public string name; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
		}
	
		public struct DspBusInfo // TypeDefIndex: 84421
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
	
		public struct AisacControlInfo // TypeDefIndex: 84422
		{
			// Fields
			public string name; // 0x00
			public uint id; // 0x08
		}
	
		public enum AisacType // TypeDefIndex: 84423
		{
			Normal = 0,
			AutoModulation = 1
		}
	
		public struct GlobalAisacInfo // TypeDefIndex: 84424
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numGraphs; // 0x0A
			public AisacType type; // 0x0C
			public float randomRange; // 0x10
			public ushort controlId; // 0x14
		}
	
		public struct SelectorInfo // TypeDefIndex: 84425
		{
			// Fields
			public string name; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
		}
	
		public struct SelectorLabelInfo // TypeDefIndex: 84426
		{
			// Fields
			public string selectorName; // 0x00
			public string labelName; // 0x08
		}
	
		private struct CategoryInfoForMarshaling // TypeDefIndex: 84427
		{
			// Fields
			public uint groupNo; // 0x00
			public uint id; // 0x04
			public IntPtr namePtr; // 0x08
			public uint numCueLimits; // 0x10
			public float volume; // 0x14
	
			// Methods
			public void Convert(out CategoryInfo x); // 0x0000000188C0DE48-0x0000000188C0DE94
		}
	
		private struct DspBusInfoForMarshaling // TypeDefIndex: 84428
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
			public void Convert(out DspBusInfo x); // 0x0000000188C20334-0x0000000188C203BC
		}
	
		private struct AisacControlInfoForMarshaling // TypeDefIndex: 84429
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public uint id; // 0x08
	
			// Methods
			public void Convert(out AisacControlInfo x); // 0x0000000188C0DD94-0x0000000188C0DDCC
		}
	
		private struct GlobalAisacInfoForMarshaling // TypeDefIndex: 84430
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
			public void Convert(out GlobalAisacInfo x); // 0x0000000188C2047C-0x0000000188C204D4
		}
	
		private struct SelectorInfoForMarshaling // TypeDefIndex: 84431
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public ushort index; // 0x08
			public ushort numLabels; // 0x0A
			public ushort globalLabelIndex; // 0x0C
	
			// Methods
			public void Convert(out SelectorInfo x); // 0x0000000188C20BE0-0x0000000188C20C2C
		}
	
		private struct SelectorLabelInfoForMarshaling // TypeDefIndex: 84432
		{
			// Fields
			public IntPtr selectorNamePtr; // 0x00
			public IntPtr labelNamePtr; // 0x08
	
			// Methods
			public void Convert(out SelectorLabelInfo x); // 0x0000000188C20C2C-0x0000000188C20C74
		}
	
		// Methods
		public static int GetNumCategories(); // 0x0000000188C0E440-0x0000000188C0E448
		public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo); // 0x0000000188C0E2A8-0x0000000188C0E2F4
		public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo); // 0x0000000188C0E2F4-0x0000000188C0E340
		public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo); // 0x0000000188C0E25C-0x0000000188C0E2A8
		public static int GetNumBuses(); // 0x0000000188C0E438-0x0000000188C0E440
		public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo); // 0x0000000188C0E340-0x0000000188C0E398
		public static int GetNumAisacControls(); // 0x0000000188C0E430-0x0000000188C0E438
		public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info); // 0x0000000188C0E1FC-0x0000000188C0E240
		public static uint GetAisacControlIdByName(string name); // 0x0000000188C0E1F4-0x0000000188C0E1FC
		public static string GetAisacControlNameById(uint id); // 0x0000000188C0E240-0x0000000188C0E25C
		public static int GetNumGlobalAisacs(); // 0x0000000188C0E448-0x0000000188C0E450
		public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info); // 0x0000000188C0E3E4-0x0000000188C0E430
		public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info); // 0x0000000188C0E398-0x0000000188C0E3E4
		public static int GetNumSelectors(); // 0x0000000188C0E450-0x0000000188C0E458
		public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info); // 0x0000000188C0E458-0x0000000188C0E49C
		public static bool GetSelectorInfoByName(string name, out SelectorInfo info); // 0x0000000188C0E49C-0x0000000188C0E4E0
		public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo); // 0x0000000188C0E4E0-0x0000000188C0E544
		private static extern int criAtomExAcf_GetNumCategories(); // 0x0000000188C0EACC-0x0000000188C0EAF8
		private static extern int criAtomExAcf_GetCategoryInfo(ushort index, out CategoryInfoForMarshaling categoryInfo); // 0x0000000188C0E7BC-0x0000000188C0E840
		private static extern int criAtomExAcf_GetCategoryInfoByName(string name, out CategoryInfoForMarshaling categoryInfo); // 0x0000000188C0E718-0x0000000188C0E7BC
		private static extern int criAtomExAcf_GetCategoryInfoById(uint id, out CategoryInfoForMarshaling categoryInfo); // 0x0000000188C0E694-0x0000000188C0E718
		private static extern int criAtomExAcf_GetNumBuses(); // 0x0000000188C0EAA0-0x0000000188C0EACC
		private static extern int criAtomExAcf_GetDspBusInformation(ushort index, out DspBusInfoForMarshaling dspBusInfo); // 0x0000000188C0E840-0x0000000188C0E954
		private static extern int criAtomExAcf_GetNumAisacControls(); // 0x0000000188C0EA7C-0x0000000188C0EAA0
		private static extern int criAtomExAcf_GetAisacControlInfo(ushort index, out AisacControlInfoForMarshaling info); // 0x0000000188C0E598-0x0000000188C0E61C
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x0000000188C0E544-0x0000000188C0E598
		private static extern IntPtr criAtomExAcf_GetAisacControlNameById(uint id); // 0x0000000188C0E61C-0x0000000188C0E694
		private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x0000000188C0EAF8-0x0000000188C0EB1C
		private static extern int criAtomExAcf_GetGlobalAisacInfo(ushort index, out GlobalAisacInfoForMarshaling info); // 0x0000000188C0E9F8-0x0000000188C0EA7C
		private static extern int criAtomExAcf_GetGlobalAisacInfoByName(string name, out GlobalAisacInfoForMarshaling info); // 0x0000000188C0E954-0x0000000188C0E9F8
		private static extern int criAtomExAcf_GetNumSelectors(); // 0x0000000188C0EB1C-0x0000000188C0EB40
		private static extern int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out SelectorInfoForMarshaling info); // 0x0000000188C0EB40-0x0000000188C0EBC4
		private static extern int criAtomExAcf_GetSelectorInfoByName(string name, out SelectorInfoForMarshaling info); // 0x0000000188C0EBC4-0x0000000188C0EC68
		private static extern int criAtomExAcf_GetSelectorLabelInfo(ref SelectorInfoForMarshaling info, ushort labelIndex, out SelectorLabelInfoForMarshaling label_info); // 0x0000000188C0EC68-0x0000000188C0ECFC
	}

	public static class CriAtomExAcbDebug // TypeDefIndex: 84436
	{
		// Nested types
		public struct AcbInfo // TypeDefIndex: 84434
		{
			// Fields
			public string name; // 0x00
			public uint size; // 0x08
			public uint version; // 0x0C
			public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
			public float volume; // 0x14
			public int numCues; // 0x18
		}
	
		private struct AcbInfoForMarshaling // TypeDefIndex: 84435
		{
			// Fields
			public IntPtr namePtr; // 0x00
			public uint size; // 0x08
			public uint version; // 0x0C
			public CriAtomEx.CharacterEncoding characterEncoding; // 0x10
			public float volume; // 0x14
			public int numCues; // 0x18
	
			// Methods
			public void Convert(out AcbInfo x); // 0x0000000188C0DD44-0x0000000188C0DD94
		}
	
		// Methods
		public static bool GetAcbInfo(CriAtomExAcb acb, out AcbInfo acbInfo); // 0x0000000188C0E114-0x0000000188C0E170
		private static extern int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out AcbInfoForMarshaling acbInfo); // 0x0000000188C0E170-0x0000000188C0E1F4
	}

	public static class CriAtomExPlaybackDebug // TypeDefIndex: 84437
	{
		// Methods
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value); // 0x0000000188C0EDC4-0x0000000188C0EDDC
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value); // 0x0000000188C0EDDC-0x0000000188C0EDF4
		public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value); // 0x0000000188C0EDAC-0x0000000188C0EDC4
		public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value); // 0x0000000188C0ED7C-0x0000000188C0ED94
		public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value); // 0x0000000188C0ED94-0x0000000188C0EDAC
		private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value); // 0x0000000188C0EF34-0x0000000188C0EFC4
		private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value); // 0x0000000188C0F054-0x0000000188C0F0E4
		private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value); // 0x0000000188C0EFC4-0x0000000188C0F054
		private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value); // 0x0000000188C0EDF4-0x0000000188C0EE84
		private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value); // 0x0000000188C0EE84-0x0000000188C0EF34
	}

	public abstract class CriDisposable : IDisposable // TypeDefIndex: 84438
	{
		// Fields
		public Guid guid; // 0x10
	
		// Constructors
		public CriDisposable(); // 0x0000000185AFEA40-0x0000000185AFEAF0
	
		// Methods
		public abstract void Dispose();
	}

	public static class CriDisposableObjectManager // TypeDefIndex: 84441
	{
		// Fields
		private static List<ObjectRef> refList; // 0x00
	
		// Nested types
		public enum ModuleType // TypeDefIndex: 84439
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
	
		public struct ObjectRef // TypeDefIndex: 84440
		{
			// Fields
			public Guid guid; // 0x00
			public ModuleType type; // 0x10
			public CriDisposable disposable; // 0x18
	
			// Constructors
			public ObjectRef(Guid _guid, CriDisposable _disposable, ModuleType _type); // 0x0000000187839854-0x000000018783986C
		}
	
		// Constructors
		static CriDisposableObjectManager(); // 0x0000000187178CE0-0x0000000187178D70
	
		// Methods
		private static int SearchForDisposable(CriDisposable disposable); // 0x0000000185AFEE80-0x0000000185AFF170
		public static void Register(CriDisposable disposable, ModuleType type); // 0x0000000185AFEAF0-0x0000000185AFEE80
		public static bool Unregister(CriDisposable disposable); // 0x0000000185AFE3C0-0x0000000185AFE610
		public static bool IsDisposed(CriDisposable disposable); // 0x0000000188C14F74-0x0000000188C14FB8
		public static void CallOnModuleFinalization(ModuleType type); // 0x0000000188C14BB8-0x0000000188C14C00
		private static int GetNextWithType(ModuleType type); // 0x0000000188C14EAC-0x0000000188C14F74
		public static void DisposeAll(ModuleType type); // 0x0000000188C14C00-0x0000000188C14EAC
	}

	public abstract class CriMonoBehaviour : MonoBehaviour // TypeDefIndex: 84442
	{
		// Fields
		[CompilerGenerated]
		private Guid _guid_k__BackingField; // 0x18
	
		// Properties
		public Guid guid { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001845C28E0-0x00000001845C28F0 0x0000000187235FF0-0x0000000187236000
	
		// Constructors
		public CriMonoBehaviour(); // 0x0000000185959070-0x0000000185959140
	
		// Methods
		protected virtual void OnEnable(); // 0x0000000185B021C0-0x0000000185B02230
		protected virtual void OnDisable(); // 0x0000000186C1A6A0-0x0000000186C1A6F0
		public abstract void CriInternalUpdate();
		public abstract void CriInternalLateUpdate();
	}

	public class CriMonoBehaviourManager : MonoBehaviour // TypeDefIndex: 84443
	{
		// Fields
		private static CriMonoBehaviourManager _instance; // 0x00
		private static List<CriMonoBehaviour> criMonoBehaviourList; // 0x08
	
		// Properties
		public static CriMonoBehaviourManager instance { get; } // 0x0000000185B02230-0x0000000185B02290 
	
		// Constructors
		public CriMonoBehaviourManager(); // 0x00000001878364A0-0x00000001878364B8
		static CriMonoBehaviourManager(); // 0x00000001870F5EE0-0x00000001870F5FA0
	
		// Methods
		public static void CreateInstance(); // 0x0000000185B02290-0x0000000185B02390
		private static int GetIndex(CriMonoBehaviour criMonoBehaviour); // 0x0000000185B03AA0-0x0000000185B03C30
		public bool Register(CriMonoBehaviour criMonoBehaviour); // 0x0000000185B031C0-0x0000000185B033E0
		public static bool UnRegister(CriMonoBehaviour criMonoBehaviour); // 0x0000000186C1A6F0-0x0000000186C1A8B0
		private void Awake(); // 0x0000000187105740-0x0000000187105840
		private void Update(); // 0x0000000185B03E30-0x0000000185B04030
		private void LateUpdate(); // 0x0000000185B03C30-0x0000000185B03E30
	}
}

namespace CriWare.CriAtomDebugDetail
{
	public class Utility // TypeDefIndex: 84444
	{
		// Constructors
		public Utility(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static string PtrToStringAutoOrNull(IntPtr stringPtr); // 0x0000000188C211BC-0x0000000188C21208
	}
}

namespace CriWare.CriMana
{
	public enum CodecType // TypeDefIndex: 84463
	{
		Unknown = 0,
		SofdecPrime = 1,
		H264 = 5,
		VP9 = 9
	}

	public enum AlphaType // TypeDefIndex: 84464
	{
		CompoOpaq = 0,
		CompoAlphaFull = 1,
		CompoAlpha3Step = 2,
		CompoAlpha32Bit = 3
	}

	public struct AudioInfo // TypeDefIndex: 84465
	{
		// Fields
		public uint samplingRate; // 0x00
		public uint numChannels; // 0x04
		public uint totalSamples; // 0x08
	}

	[Serializable]
	public class MovieInfo // TypeDefIndex: 84466
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
		public bool hasAlpha { get; internal set; } // 0x00000001852D85F0-0x00000001852D8640 0x0000000188C24B28-0x0000000188C24B44
	
		// Constructors
		public MovieInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class FrameInfo // TypeDefIndex: 84467
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
		public FrameInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct EventPoint // TypeDefIndex: 84468
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

	public static class Settings // TypeDefIndex: 84469
	{
		// Methods
		public static void SetDecodeSkippingEnabled(bool enabled); // 0x0000000188C28550-0x0000000188C2859C
	}

	public class Player : CriDisposable // TypeDefIndex: 84484
	{
		// Fields
		private const int InvalidPlayerId = -1; // Metadata: 0x02644565
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
		private Status requiredStatus { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x00000001852D95B0-0x00000001852D95E0
		public bool additiveMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E0F0-0x000000018225E100 0x000000018225E100-0x000000018225E110
		public bool useMaterialBlendMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235C00-0x0000000187235C10 0x0000000187235C50-0x0000000187235C60
		public int maxFrameDrop { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872361F0-0x0000000187236200 0x0000000185B8EB10-0x0000000185B8EB20
		public bool applyTargetAlpha { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018223B190-0x000000018223B1A0 0x000000018223B1A0-0x000000018223B1B0
		public bool uiRenderMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187236210-0x0000000187236220 0x0000000187236230-0x0000000187236240
		public bool isFrameAvailable { get; } // 0x00000001872361E0-0x00000001872361F0 
		public MovieInfo movieInfo { get; } // 0x00000001865861A0-0x0000000186586200 
		public FrameInfo frameInfo { get; } // 0x0000000186589910-0x0000000186589920 
		public Status status { get; } // 0x00000001852DB200-0x00000001852DB260 
		public Status nativeStatus { get; } // 0x0000000182271A80-0x0000000182271A90 
		public int numberOfEntries { get; } // 0x0000000188C26F08-0x0000000188C26F14 
		public IntPtr subtitleBuffer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236200-0x0000000187236210 0x0000000187236220-0x0000000187236230
		public int subtitleSize { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235AE0-0x0000000187235AF0 0x0000000187235AF0-0x0000000187235B00
		public CriAtomExPlayer atomExPlayer { get; } // 0x00000001828D49D0-0x00000001828D49E0 
		public CriAtomEx3dSource atomEx3DsourceForAmbisonics { get; } // 0x0000000187232F50-0x0000000187232F60 
		public TimerType timerType { get; } // 0x00000001872333B0-0x00000001872333C0 
		public CriManaMoviePlayerHolder playerHolder { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187234580-0x0000000187234590 0x0000000188A79A0C-0x0000000188A79A20
		public bool isAlive { get; } // 0x0000000186C1A8B0-0x0000000186C1A8C0 
	
		// Events
		public event SubtitleChangeCallback OnSubtitleChanged {
			add; // 0x0000000188C26D70-0x0000000188C26E08
			remove; // 0x0000000188C26F14-0x0000000188C26FAC
		}
	
		// Nested types
		public enum Status // TypeDefIndex: 84470
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
	
		public enum SetMode // TypeDefIndex: 84471
		{
			New = 0,
			Append = 1,
			AppendRepeatedly = 2
		}
	
		public enum MovieEventSyncMode // TypeDefIndex: 84472
		{
			FrameTime = 0,
			PlayBackTime = 1
		}
	
		public enum AudioTrack // TypeDefIndex: 84473
		{
			Off = 0,
			Auto = 1
		}
	
		public enum TimerType // TypeDefIndex: 84474
		{
			None = 0,
			System = 1,
			Audio = 2,
			User = 3,
			Manual = 4
		}
	
		public delegate void CuePointCallback(ref EventPoint eventPoint); // TypeDefIndex: 84475; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void StatusChangeCallback(Status status); // TypeDefIndex: 84476; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void SubtitleChangeCallback(IntPtr subtitleBuffer); // TypeDefIndex: 84477; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate Shader ShaderDispatchCallback(MovieInfo movieInfo, bool additiveMode); // TypeDefIndex: 84478; 0x00000001859B7730-0x00000001859B7740
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void CuePointCallbackFromNativeDelegate(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint); // TypeDefIndex: 84479; 0x00000001811DF7F0-0x00000001811DF810
	
		public enum CriManaUnityPlayer_RenderEventAction // TypeDefIndex: 84480
		{
			UPDATE = 0,
			INITIALIZE = 256,
			RENDER = 512,
			DESTROY = 768
		}
	
		protected enum OperationType // TypeDefIndex: 84481
		{
			Normal = 0,
			SetFile = 1,
			SeekToTime = 2,
			Pause = 3
		}
	
		protected struct Operation // TypeDefIndex: 84482
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
			public static Operation Start(); // 0x0000000187236170-0x00000001872361A0
			public static Operation Pause(bool sw); // 0x00000001872360C0-0x00000001872360E0
			public static Operation Stop(); // 0x00000001872361C0-0x00000001872361E0
			public static Operation StopForSeek(); // 0x00000001872361A0-0x00000001872361C0
			public static Operation Prepare(); // 0x0000000187236110-0x0000000187236140
			public static Operation PrepareForRendering(); // 0x00000001872360E0-0x0000000187236110
			public static Operation SetFile(CriFsBinder binder, string moviePath, SetMode setMode); // 0x0000000188C24B44-0x0000000188C24B88
			public static Operation SeekToTime(float time); // 0x0000000187236140-0x0000000187236170
		}
	
		[CompilerGenerated]
		private sealed class _IssuePluginUpdatesForFrames_d__154 : IEnumerator<object> // TypeDefIndex: 84483
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _IssuePluginUpdatesForFrames_d__154(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001827505E0-0x0000000182750A50
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182750A50-0x0000000182750AA0
		}
	
		// Constructors
		public Player(); // 0x0000000188C26BC4-0x0000000188C26D70
		public Player(bool advanced_audio_mode, bool ambisonics_mode, uint max_path_length); // 0x0000000185AFE7C0-0x0000000185AFE980
	
		// Methods
		~Player(); // 0x0000000188C264D0-0x0000000188C26548
		public override void Dispose(); // 0x0000000186ADE450-0x0000000186ADE4B0
		public void CreateRendererResource(int width, int height, bool alpha); // 0x0000000188C25D54-0x0000000188C25ED4
		public void DisposeRendererResource(); // 0x0000000186ADE750-0x0000000186ADE790
		public void Prepare(); // 0x00000001852D85A0-0x00000001852D85F0
		public void PrepareForRendering(); // 0x0000000188C2664C-0x0000000188C26690
		public void Start(); // 0x00000001852D8550-0x00000001852D85A0
		public void Stop(); // 0x00000001852D84D0-0x00000001852D8530
		public void StopForSeek(); // 0x0000000188C26A0C-0x0000000188C26AC4
		public void Pause(bool sw); // 0x0000000186C1A8C0-0x0000000186C1A8F0
		public bool IsPaused(); // 0x000000018783D348-0x000000018783D354
		public bool SetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x0264455E */); // 0x0000000186648300-0x0000000186648390
		public bool SetData(IntPtr data, long dataSize, SetMode setMode = SetMode.New /* Metadata: 0x0264455F */); // 0x0000000188C267CC-0x0000000188C26804
		[Obsolete("Use SetData(IntPtr, Int64, SetMode) instead")]
		public bool SetData(byte[] data, long datasize, SetMode setMode = SetMode.New /* Metadata: 0x02644560 */); // 0x0000000188C26794-0x0000000188C267CC
		public bool SetContentId(CriFsBinder binder, int contentId, SetMode setMode = SetMode.New /* Metadata: 0x02644561 */); // 0x0000000188C266E4-0x0000000188C26794
		public bool SetFileRange(string filePath, ulong offset, long range, SetMode setMode = SetMode.New /* Metadata: 0x02644562 */); // 0x0000000188C26858-0x0000000188C26898
		public void Loop(bool sw); // 0x0000000186FACB00-0x0000000186FACB20
		public void SetMasterTimerType(TimerType timerType); // 0x0000000187839840-0x0000000187839854
		public void SetSeekPosition(int frameNumber); // 0x0000000188C26940-0x0000000188C2694C
		public void SetMovieEventSyncMode(MovieEventSyncMode mode); // 0x0000000188C26934-0x0000000188C26940
		public void SetSpeed(float speed); // 0x0000000188C2694C-0x0000000188C26958
		public void SetMaxPictureDataSize(uint maxDataSize); // 0x0000000188C2691C-0x0000000188C26928
		public void SetBufferingTime(float sec); // 0x0000000188C266CC-0x0000000188C266D8
		public void SetMinBufferSize(int min_buffer_size); // 0x0000000188C26928-0x0000000188C26934
		public void SetAudioTrack(int track); // 0x0000000188C266C0-0x0000000188C266CC
		public void SetAudioTrack(AudioTrack track); // 0x0000000188C2669C-0x0000000188C266C0
		public void SetSubAudioTrack(int track); // 0x0000000188C26964-0x0000000188C26970
		public void SetSubAudioTrack(AudioTrack track); // 0x0000000188C26970-0x0000000188C26994
		public void SetExtraAudioTrack(int track); // 0x0000000188C26810-0x0000000188C2681C
		public void SetExtraAudioTrack(AudioTrack track); // 0x0000000188C2681C-0x0000000188C26840
		public void SetVolume(float volume); // 0x000000018783D708-0x000000018783D714
		public float GetVolume(); // 0x0000000188C26600-0x0000000188C2660C
		public void SetSubAudioVolume(float volume); // 0x0000000188C26994-0x0000000188C269A0
		public float GetSubAudioVolume(); // 0x0000000188C26560-0x0000000188C2656C
		public void SetExtraAudioVolume(float volume); // 0x0000000188C26840-0x0000000188C2684C
		public float GetExtraAudioVolume(); // 0x0000000188C26554-0x0000000188C26560
		public void SetBusSendLevel(string bus_name, float level); // 0x0000000188C266D8-0x0000000188C266E4
		public void SetSubAudioBusSendLevel(string bus_name, float volume); // 0x0000000188C26958-0x0000000188C26964
		public void SetExtraAudioBusSendLevel(string bus_name, float volume); // 0x0000000188C26804-0x0000000188C26810
		public void SetSubtitleChannel(int channel); // 0x0000000188C269A0-0x0000000188C26A00
		public void SetShaderDispatchCallback(ShaderDispatchCallback shaderDispatchCallback); // 0x0000000186B19440-0x0000000186B19450
		public long GetTime(); // 0x0000000188C2656C-0x0000000188C26578
		public int GetDisplayedFrameNo(); // 0x0000000188C26548-0x0000000188C26554
		public bool HasRenderedNewFrame(); // 0x0000000188C2660C-0x0000000188C26634
		public void SetAsrRackId(int asrRackId); // 0x0000000188C26690-0x0000000188C2669C
		public void SetDecryptionKey(ulong key); // 0x0000000182750550-0x00000001827505E0
		public void SetUserTimeCorrectionThreshold(uint threshold_msec); // 0x0000000188C26A00-0x0000000188C26A0C
		public void SetExtraFramePoolSize(uint size); // 0x0000000188C2684C-0x0000000188C26858
		public void UpdateWithUserTime(ulong timeCount, ulong timeUnit); // 0x0000000188C26B34-0x0000000188C26BC4
		public void SetManualTimerUnit(ulong timeUnitN, ulong timeUnitD); // 0x0000000188C26898-0x0000000188C2691C
		public void UpdateWithManualTimeAdvanced(); // 0x0000000188C26AC4-0x0000000188C26B34
		public void Update(); // 0x00000001852DA260-0x00000001852DA280
		public void OnWillRenderObject(CriManaMovieMaterialBase sender); // 0x00000001852DA120-0x00000001852DA160
		public bool UpdateMaterial(Material material); // 0x00000001852DA980-0x00000001852DA9F0
		public void IssuePluginEvent(CriManaUnityPlayer_RenderEventAction renderEventAction); // 0x00000001852DA850-0x00000001852DA8E0
		private void Dispose(bool disposing); // 0x0000000186ADE4B0-0x0000000186ADE670
		public void ClearStatusChangeCallback(); // 0x0000000186ADE8D0-0x0000000186ADE9A0
		private void InternalUpdate(); // 0x00000001852DA280-0x00000001852DA590
		[IteratorStateMachine(typeof(_IssuePluginUpdatesForFrames_d__154))]
		private IEnumerator IssuePluginUpdatesForFrames(int frameCount, MonoBehaviour playerHolder, bool destroy, int playerId); // 0x0000000186ADE670-0x0000000186ADE710
		private void DisableInfos(bool keepFrameInfo = false /* Metadata: 0x02644563 */); // 0x00000001852D8530-0x00000001852D8550
		private void PrepareNativePlayer(); // 0x00000001852D7F80-0x00000001852D7FF0
		private void UpdateNativePlayer(); // 0x00000001852DA690-0x00000001852DA800
		private void InvokePlayerStatusCheck(); // 0x00000001852DB140-0x00000001852DB200
		private void AllocateSubtitleBuffer(int size); // 0x0000000188C24CAC-0x0000000188C24D74
		private void DeallocateSubtitleBuffer(); // 0x0000000186ADE790-0x0000000186ADE7E0
		internal void PauseOnApplicationPause(bool sw); // 0x0000000188C26634-0x0000000188C2664C
		[AOT.MonoPInvokeCallback(typeof(CuePointCallbackFromNativeDelegate))]
		private static void CuePointCallbackFromNative(IntPtr ptr1, IntPtr ptr2, in EventPoint eventPoint); // 0x0000000188C25ED4-0x0000000188C25F40
		private static extern int CRIWAREFD186F02(); // 0x0000000185AFE980-0x0000000185AFE9B0
		private static extern int CRIWARE72A5B8BF(); // 0x0000000188C25424-0x0000000188C25450
		private static extern int CRIWARE95A85424(bool useAtomExPlayer, uint maxPathLength); // 0x0000000188C25660-0x0000000188C256E4
		private static extern void CRIWAREABF659EC(int player_id); // 0x0000000186ADE710-0x0000000186ADE750
		private static extern void CRIWAREEDB46019(int player_id, IntPtr binder, string path); // 0x0000000185AFD190-0x0000000185AFD240
		private static extern void CRIWAREB28B5D50(int player_id, IntPtr binder, int content_id); // 0x0000000188C25850-0x0000000188C258E4
		private static extern void CRIWARE65553651(int player_id, string path, ulong offset, long range); // 0x0000000188C25284-0x0000000188C25338
		private static extern void CRIWARE7C753A2E(int player_id, IntPtr data, long datasize); // 0x0000000188C254B8-0x0000000188C2554C
		private static extern void CRIWARE7C753A2E(int player_id, byte[] data, long datasize); // 0x0000000188C2554C-0x0000000188C255E8
		private static extern bool CRIWARE328F2911(int player_id, IntPtr binder, string path, bool repeat); // 0x0000000188C250A4-0x0000000188C25168
		private static extern bool CRIWAREDA0693CD(int player_id, IntPtr binder, int content_id, bool repeat); // 0x0000000188C25BC0-0x0000000188C25C68
		private static extern bool CRIWARE162DD162(int player_id, string path, ulong offset, long range, bool repeat); // 0x0000000188C24DF8-0x0000000188C24EC8
		private static extern bool CRIWAREC35C3DC3(int player_id, IntPtr data, long datasize, bool repeat); // 0x0000000188C258E4-0x0000000188C2598C
		private static extern bool CRIWAREC35C3DC3(int player_id, byte[] data, long datasize, bool repeat); // 0x0000000188C2598C-0x0000000188C25A3C
		private static extern void CRIWARE66A63134(int player_id); // 0x0000000188C25338-0x0000000188C2536C
		private static extern int CRIWARE88D04318(int player_id); // 0x0000000188C255E8-0x0000000188C2561C
		private static extern void CRIWARED9F7168D(int player_id, CuePointCallbackFromNativeDelegate cbfunc); // 0x0000000188C25B34-0x0000000188C25BC0
		private static extern void CRIWARE1E785A43(int player_id, out MovieInfo movie_info); // 0x0000000185AFD0C0-0x0000000185AFD190
		private static extern int CRIWARE3CE8CE6A(int player_id, IntPtr subtitle_buffer, ref uint subtitle_size); // 0x00000001852DA800-0x00000001852DA850
		private static extern void CRIWARE362A826C(int player_id); // 0x00000001852D7FF0-0x00000001852D8030
		private static extern void CRIWARE61523A0C(int player_id); // 0x00000001852D8490-0x00000001852D84D0
		private static extern void CRIWAREBB898C91(int player_id); // 0x00000001852D8450-0x00000001852D8490
		private static extern void CRIWARE705B8C6D(int player_id, int seek_frame_no); // 0x0000000188C253AC-0x0000000188C253EC
		private static extern void CRIWAREEB32FC73(int player_id, MovieEventSyncMode mode); // 0x0000000188C25C68-0x0000000188C25CA8
		private static extern void CRIWARE18BFCB88(int player_id, int sw); // 0x0000000186C1A8F0-0x0000000186C1A930
		private static extern bool CRIWAREEFA5210A(int player_id); // 0x0000000185AFDF90-0x0000000185AFDFD0
		private static extern void CRIWARE4331E077(int player_id, int sw); // 0x0000000186FACB20-0x0000000186FACB60
		private static extern long CRIWARE7779586C(int player_id); // 0x0000000188C25484-0x0000000188C254B8
		private static extern int CRIWARE33981CC9(int player_id); // 0x0000000188C25168-0x0000000188C2519C
		private static extern IntPtr CRIWARE165B6B70(int player_id); // 0x0000000188C24EC8-0x0000000188C24EFC
		private static extern int CRIWARE7500F0DD(int player_id); // 0x0000000188C25450-0x0000000188C25484
		private static extern void CRIWARED99932F6(int player_id, int track); // 0x0000000188C25AF4-0x0000000188C25B34
		private static extern void CRIWARE1FF2F5BE(int player_id, float vol); // 0x0000000185AFDF40-0x0000000185AFDF90
		private static extern float CRIWARED30C9C6F(int player_id); // 0x0000000188C25AC0-0x0000000188C25AF4
		private static extern void CRIWARE0EA59F65(int player_id, int track); // 0x0000000188C24DB8-0x0000000188C24DF8
		private static extern void CRIWARE1EBB12C5(int player_id, float vol); // 0x0000000188C24EFC-0x0000000188C24F40
		private static extern float CRIWARE966C4BA9(int player_id); // 0x0000000188C256E4-0x0000000188C25718
		private static extern void CRIWARE213452EF(int player_id, int track); // 0x0000000188C24F40-0x0000000188C24F80
		private static extern void CRIWARE0348BF1B(int player_id, float vol); // 0x0000000188C24D74-0x0000000188C24DB8
		private static extern float CRIWAREC5A3A88D(int player_id); // 0x0000000188C25A3C-0x0000000188C25A70
		private static extern void CRIWARE31668293(int player_id, string bus_name, float level); // 0x0000000188C25040-0x0000000188C250A4
		private static extern void CRIWAREB2460D7A(int player_id, string bus_name, float level); // 0x0000000188C257EC-0x0000000188C25850
		private static extern void CRIWAREF4B0CC4E(int player_id, string bus_name, float level); // 0x0000000188C25CA8-0x0000000188C25D0C
		private static extern void CRIWARE2C8FF595(int player_id, int channel); // 0x0000000188C25000-0x0000000188C25040
		private static extern void CRIWAREAB576D15(int player_id, float speed); // 0x0000000188C257A8-0x0000000188C257EC
		private static extern void CRIWARE3F9C5D06(int player_id, uint max_data_size); // 0x0000000188C2519C-0x0000000188C2521C
		public static extern void CRIWARE8A87737B(int player_id, float sec); // 0x0000000188C2561C-0x0000000188C25660
		public static extern void CRIWARE6756AE56(int player_id, int min_buffer_size); // 0x0000000188C2536C-0x0000000188C253AC
		public static extern void CRIWAREA7F6DE6B(int player_id, int asr_rack_id); // 0x0000000188C25768-0x0000000188C257A8
		private static extern void CRIWAREE2DF1163(int player_id); // 0x00000001852DA590-0x00000001852DA5D0
		private static extern void CRIWAREBD24DE27(int player_id, TimerType timer_type); // 0x000000018717DBA0-0x000000018717DBE0
		private static extern void CRIWAREC7C5CC77(int player_id, ulong user_count, ulong user_unit); // 0x0000000188C25A70-0x0000000188C25AC0
		private static extern void CRIWAREA59E0F01(int player_id, ulong timer_unit_n, ulong timer_unit_d); // 0x0000000188C25718-0x0000000188C25768
		private static extern void CRIWARE55ECC3E4(int player_id); // 0x0000000188C25250-0x0000000188C25284
		private static extern void CRIWARECEA2FA98(int player_id); // 0x0000000186ADE7E0-0x0000000186ADE820
		private static extern IntPtr CRIWARE27ED314F(int player_id, int bufferSize); // 0x0000000188C24F80-0x0000000188C25000
		private static extern bool CRIWARE725ED4B4(int player_id); // 0x0000000188C253EC-0x0000000188C25424
		private static extern void CRIWARE419ECAF8(int player_id); // 0x0000000188C2521C-0x0000000188C25250
		private static extern void CRIWARE662A91B8(int player_id, ulong key); // 0x00000001827504C0-0x0000000182750550
		private static extern IntPtr criWareUnity_GetRenderEventFunc(); // 0x00000001852DA8E0-0x00000001852DA910
		private static extern void criManaUnityPlayer_SetUserTimeCorrectionThreshold(int player_id, uint threshold_msec); // 0x0000000188C26E88-0x0000000188C26F08
		private static extern void criManaUnityPlayer_SetExtraFramePoolSize(int player_id, uint size); // 0x0000000188C26E08-0x0000000188C26E88
		public void ClearAllOperation(); // 0x0000000188C25D0C-0x0000000188C25D54
		protected void ExecuteOperation(); // 0x00000001852DA5D0-0x00000001852DA690
		public void EasyPrepare(); // 0x0000000188C2604C-0x0000000188C260C0
		public void EasyPrepareForRendering(); // 0x0000000188C25FD8-0x0000000188C2604C
		public void EasyStart(); // 0x0000000188C26384-0x0000000188C263F8
		public void EasyPause(bool sw); // 0x0000000188C25F40-0x0000000188C25FD8
		public void EasyStop(); // 0x0000000188C2646C-0x0000000188C264D0
		public void EasyStopForSeek(); // 0x0000000188C263F8-0x0000000188C2646C
		public void EasySetFile(CriFsBinder binder, string moviePath, SetMode setMode = SetMode.New /* Metadata: 0x02644564 */); // 0x0000000188C260C0-0x0000000188C261AC
		public void EasySetSeekTime(float time); // 0x0000000188C261AC-0x0000000188C26248
		public void EasyStartAtTime(float time); // 0x0000000188C26248-0x0000000188C26384
		public float GetVideoLength(); // 0x0000000188C26578-0x0000000188C26600
	}
}

namespace CriWare.CriMana.Detail
{
	public static class AutoResisterRendererResourceFactories // TypeDefIndex: 84488
	{
		// Nested types
		[RendererResourceFactoryPriority(7050)]
		public class RendererResourceFactoryH264Yuv : RendererResourceFactory // TypeDefIndex: 84485
		{
			// Constructors
			public RendererResourceFactoryH264Yuv(); // 0x0000000187221CF0-0x0000000187221D30
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000188C26FAC-0x0000000188C27048
			protected override void OnDisposeManaged(); // 0x0000000186805BA0-0x0000000186805BB0
			protected override void OnDisposeUnmanaged(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[RendererResourceFactoryPriority(5000)]
		public class RendererResourceFactorySofdecPrimeYuv : RendererResourceFactory // TypeDefIndex: 84486
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuv(); // 0x0000000187221C70-0x0000000187221CB0
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x00000001870E2C40-0x00000001870E2D00
			protected override void OnDisposeManaged(); // 0x0000000186805BA0-0x0000000186805BB0
			protected override void OnDisposeUnmanaged(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[RendererResourceFactoryPriority(10000)]
		public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory // TypeDefIndex: 84487
		{
			// Constructors
			public RendererResourceFactorySofdecPrimeYuvRawData(); // 0x0000000187221CB0-0x0000000187221CF0
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000188C27048-0x0000000188C270F4
			protected override void OnDisposeManaged(); // 0x0000000186805BA0-0x0000000186805BB0
			protected override void OnDisposeUnmanaged(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Methods
		public static void InvokeAutoRegister(); // 0x0000000186367370-0x00000001863675C0
	}

	public class RendererResourceH264Yuv : RendererResourceSofdecPrimeYuv // TypeDefIndex: 84489
	{
		// Constructors
		public RendererResourceH264Yuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000188C27398-0x0000000188C273A8
	}

	public abstract class RendererResource : IDisposable // TypeDefIndex: 84490
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
		public bool useMaterialBlendMode { get; set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
	
		// Constructors
		protected RendererResource(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		~RendererResource(); // 0x0000000188C284D0-0x0000000188C28548
		public void Dispose(); // 0x0000000186ADE820-0x0000000186ADE890
		private void Dispose(bool disposing); // 0x0000000186ADE890-0x0000000186ADE8D0
		public int GetNumberOfFrameBeforeDestroy(int playerId); // 0x000000018783CF0C-0x000000018783CF24
		protected void SetupStaticMaterialProperties(); // 0x00000001852DC9F0-0x00000001852DCC60
		private void GetBlendModes(out int srcBlendMode, out int dstBlendMode); // 0x00000001852DCC90-0x00000001852DCCC0
		public virtual void SetApplyTargetAlpha(bool flag); // 0x0000000187835984-0x0000000187835990
		public virtual void SetUiRenderMode(bool flag); // 0x0000000187835990-0x000000018783599C
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract bool IsPrepared();
		public abstract bool ContinuePreparing();
		public abstract void AttachToPlayer(int playerId);
		public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);
		public abstract bool UpdateMaterial(Material material);
		public abstract void UpdateTextures();
		public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
		public virtual void OnPlayerPause(bool pauseStatus, bool triggredFromApplciationPause); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnPlayerStop(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool OnPlayerStopForSeek(); // 0x00000001843FFFF0-0x0000000184400000
		public virtual void OnPlayerStart(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool ShouldSkipDestroyOnStopForSeek(); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool HasRenderedNewFrame(); // 0x00000001851A4410-0x00000001851A4420
		public static uint NextPowerOfTwo(uint x); // 0x00000001872362F0-0x0000000187236320
		public static int NextPowerOfTwo(int x); // 0x0000000188C28548-0x0000000188C28550
		public static int CeilingWith(int x, int ceilingValue); // 0x00000001872362E0-0x00000001872362F0
		public static int Ceiling16(int x); // 0x00000001872362A0-0x00000001872362B0
		public static int Ceiling32(int x); // 0x00000001872362C0-0x00000001872362D0
		public static int Ceiling64(int x); // 0x00000001872362D0-0x00000001872362E0
		public static int Ceiling256(int x); // 0x00000001872362B0-0x00000001872362C0
		protected static void DisposeTextures(Texture[] textures); // 0x0000000188C28418-0x0000000188C284D0
		protected static void SetKeyword(Material material, string keyword, bool flag); // 0x00000001852DCC60-0x00000001852DCC90
		protected static extern bool CRIWARE98318E69(int player_id, int num_textures, IntPtr[] tex_ptrs, [In, Out] FrameInfo frame_info, ref bool frame_drop); // 0x0000000185AFDE00-0x0000000185AFDEA0
		protected static extern bool CRIWARED618B369(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x00000001852DB0D0-0x00000001852DB140
		protected static extern bool CRIWARE5267266A(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x0000000187090490-0x0000000187090500
		protected static extern bool CRIWAREE519EFD4(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs); // 0x00000001852D8030-0x00000001852D80A0
		protected static extern sbyte CRIWAREF14F77D8(int player_id); // 0x0000000185AFD040-0x0000000185AFD0C0
	}

	public abstract class RendererResourceFactory : IDisposable // TypeDefIndex: 84491
	{
		// Fields
		private static SortedList<int, RendererResourceFactory> factoryList; // 0x00
		private bool disposed; // 0x10
	
		// Constructors
		protected RendererResourceFactory(); // 0x0000000186805BA0-0x0000000186805BB0
		static RendererResourceFactory(); // 0x0000000187176FA0-0x0000000187177030
	
		// Methods
		public static void RegisterFactory(RendererResourceFactory factory, int priority); // 0x00000001863676A0-0x0000000186367730
		public static void DisposeAllFactories(); // 0x0000000188C270F4-0x0000000188C27298
		public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000186DB6A80-0x0000000186DB6EF0
		~RendererResourceFactory(); // 0x0000000188C27320-0x0000000188C27398
		public void Dispose(); // 0x0000000188C272D0-0x0000000188C27320
		private void Dispose(bool disposing); // 0x0000000188C27298-0x0000000188C272D0
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class RendererResourceFactoryPriorityAttribute : Attribute // TypeDefIndex: 84492
	{
		// Fields
		public readonly int priority; // 0x10
	
		// Constructors
		public RendererResourceFactoryPriorityAttribute(int priority); // 0x0000000182234E90-0x0000000182234EA0
	}

	public class RendererResourceSofdecPrimeYuv : RendererResource // TypeDefIndex: 84493
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
		private static int NumTextureSets { get; } // 0x00000001872328C0-0x00000001872328D0 
		private static bool IsEditor { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public RendererResourceSofdecPrimeYuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x00000001852D9820-0x00000001852D9D80
	
		// Methods
		protected override void OnDisposeManaged(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnDisposeUnmanaged(); // 0x00000001852D9D80-0x00000001852DA0A0
		public override bool IsPrepared(); // 0x0000000187236280-0x0000000187236290
		public override bool ContinuePreparing(); // 0x00000001851A4410-0x00000001851A4420
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000188C2832C-0x0000000188C28418
		public override bool OnPlayerStopForSeek(); // 0x0000000187236290-0x00000001872362A0
		public override bool HasRenderedNewFrame(); // 0x0000000187236270-0x0000000187236280
		public override void AttachToPlayer(int playerId); // 0x0000000187090420-0x0000000187090490
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop); // 0x0000000185AFDD40-0x0000000185AFDE00
		public override bool UpdateMaterial(Material material); // 0x00000001852DAD60-0x00000001852DAF60
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight); // 0x0000000185AFDEA0-0x0000000185AFDF40
		public override void UpdateTextures(); // 0x00000001852DAC10-0x00000001852DAD60
	}

	public class RendererResourceSofdecPrimeYuvRawData : RendererResource // TypeDefIndex: 84494
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
		private static int NumTextureSets { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Constructors
		public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000188C27E00-0x0000000188C2832C
	
		// Methods
		protected override void OnDisposeManaged(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnDisposeUnmanaged(); // 0x0000000188C27628-0x0000000188C276A4
		public override bool IsPrepared(); // 0x0000000187236240-0x0000000187236250
		public override bool ContinuePreparing(); // 0x00000001851A4410-0x00000001851A4420
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader); // 0x0000000188C2753C-0x0000000188C27628
		public override bool OnPlayerStopForSeek(); // 0x0000000187236250-0x0000000187236270
		public override bool HasRenderedNewFrame(); // 0x0000000187235DC0-0x0000000187235DD0
		public override void AttachToPlayer(int playerId); // 0x0000000188C273A8-0x0000000188C27414
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop); // 0x0000000188C276A4-0x0000000188C27740
		public override bool UpdateMaterial(Material material); // 0x0000000188C27740-0x0000000188C279B0
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight); // 0x0000000188C279B0-0x0000000188C27AD4
		public override void UpdateTextures(); // 0x0000000188C27AD4-0x0000000188C27E00
		private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma); // 0x0000000188C27414-0x0000000188C2753C
	}
}

namespace CriWare.CriTimeline.Atom
{
	public struct CriAtomClipPlayConfig // TypeDefIndex: 84455
	{
		// Fields
		public readonly CriAtomClipBase clip; // 0x00
		public readonly long startTimeMs; // 0x08
		public readonly double speedRate; // 0x10
		public readonly bool loop; // 0x18
	
		// Constructors
		public CriAtomClipPlayConfig(CriAtomClipBase clip, long startTimeMs, double speedRate, bool loop); // 0x0000000188C21988-0x0000000188C219B4
	}

	[Serializable]
	public class CriAtomBehaviour : PlayableBehaviour // TypeDefIndex: 84456
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
		public CriAtomExPlayback playback { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public bool IsClipPlaying { get; private set; } // 0x000000018226EBB0-0x000000018226EBC0 0x000000018226EBC0-0x000000018226EBD0
		public double CueLength { get; private set; } // 0x00000001872331D0-0x00000001872331E0 0x00000001872331F0-0x0000000187233200
	
		// Constructors
		public CriAtomBehaviour(); // 0x0000000187233CE0-0x0000000187233CF0
		static CriAtomBehaviour(); // 0x0000000188C21808-0x0000000188C21844
	
		// Methods
		public override void OnGraphStop(Playable playable); // 0x0000000187233830-0x0000000187233840
		public void Play(CriAtomSourceBase atomSource, CriAtomClipPlayConfig config); // 0x0000000188C21264-0x0000000188C21448
		public void PreviewPlay(Guid trackId, bool instantStop, CriAtomClipPlayConfig config); // 0x0000000188C21448-0x0000000188C216D8
		private void WaitAndStop(); // 0x0000000188C2175C-0x0000000188C21808
		public void Stop(bool noReleaseTime = false /* Metadata: 0x02644551 */); // 0x0000000188C216D8-0x0000000188C21700
		private double GetCueLengthSec(CriAtomExAcb acb, string cueName); // 0x0000000188C21208-0x0000000188C21264
		[CompilerGenerated]
		private void _WaitAndStop_b__21_0(); // 0x0000000188C21700-0x0000000188C2175C
	}

	public class CriAtomClip : CriAtomClipBase // TypeDefIndex: 84457
	{
		// Fields
		public string cueSheet; // 0x30
		public string cueName; // 0x38
	
		// Properties
		public override string CueName { get; } // 0x0000000182986470-0x0000000182986480 
		public override string AcbPath { get; } // 0x0000000188C21AB8-0x0000000188C21B40 
		public override string AwbPath { get; } // 0x0000000188C21B40-0x0000000188C21BC8 
	
		// Constructors
		public CriAtomClip(); // 0x0000000188C21AB0-0x0000000188C21AB8
	
		// Methods
		public override CriAtomExAcb GetAcb(); // 0x0000000188C219B4-0x0000000188C219C0
		private CriAtomCueSheet GetCueSheet(); // 0x0000000188C219C0-0x0000000188C219CC
		public override void SetCueFromAtomSource(CriAtomSourceBase atomSource); // 0x0000000188C219CC-0x0000000188C21AB0
	}

	public abstract class CriAtomClipBase : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 84458
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
		public ClipCaps clipCaps { get; } // 0x0000000187236080-0x0000000187236090 
		public override double duration { get; } // 0x0000000188C2196C-0x0000000188C21988 
		public abstract string CueName { get; }
		public abstract string AcbPath { get; }
		public abstract string AwbPath { get; }
	
		// Constructors
		protected CriAtomClipBase(); // 0x0000000188C21908-0x0000000188C2196C
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x0000000188C21844-0x0000000188C21908
		public void SetClipDuration(double clipDuration); // 0x0000000187233250-0x0000000187233260
		public abstract CriAtomExAcb GetAcb();
		public abstract void SetCueFromAtomSource(CriAtomSourceBase atomSource);
	}

	[Serializable]
	public class CriAtomMixerBehaviour : PlayableBehaviour // TypeDefIndex: 84459
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
		private const int cScratchTimeIntervalMs = 200; // Metadata: 0x02644552
		private System.DateTime m_lastScrubTime; // 0x48
		private double m_lastDirectorTime; // 0x50
	
		// Properties
		public Guid m_Guid { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236090-0x00000001872360A0 0x00000001872360A0-0x00000001872360B0
		private static bool IsEditor { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public CriAtomMixerBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void OnPlayableCreate(Playable playable); // 0x0000000188C21C44-0x0000000188C21CE0
		public override void OnGraphStop(Playable playable); // 0x0000000188C21BC8-0x0000000188C21C44
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x0000000188C21CE0-0x0000000188C2230C
	}

	public class CriAtomTimelinePreviewer : IDisposable // TypeDefIndex: 84461
	{
		// Fields
		private static CriAtomTimelinePreviewer instance; // 0x00
		private CriAtom atom; // 0x10
		private string lastAcfFile; // 0x18
		private Dictionary<string, CriAtomExAcb> acbTable; // 0x20
		private Dictionary<Guid, PlayerSource> playerTable; // 0x28
		private CriAtomEx3dListener listener3d; // 0x30
	
		// Properties
		public static CriAtomTimelinePreviewer Instance { get; } // 0x0000000188C23328-0x0000000188C233B8 
		public static bool IsInitialized { get; } // 0x0000000188C233B8-0x0000000188C233F4 
	
		// Nested types
		private struct PlayerSource // TypeDefIndex: 84460
		{
			// Fields
			public readonly CriAtomExPlayer player; // 0x00
			public readonly CriAtomEx3dSource source3d; // 0x08
	
			// Constructors
			public PlayerSource(CriAtomEx3dListener listener); // 0x0000000188C24B88-0x0000000188C24CAC
		}
	
		// Constructors
		public CriAtomTimelinePreviewer(); // 0x0000000188C231D4-0x0000000188C23328
	
		// Methods
		public static void InstanceDispose(); // 0x0000000188C22D08-0x0000000188C22D74
		public CriAtomExPlayer GetPlayer(Guid trackId); // 0x0000000188C22B2C-0x0000000188C22D08
		public void SetCue(Guid trackId, CriAtomExAcb acb, string cueName); // 0x0000000188C22E34-0x0000000188C22EF4
		public CriAtomExAcb GetAcb(string acbPath, string awbPath); // 0x0000000188C2276C-0x0000000188C22B2C
		public CriAtomExPlayback Play(Guid trackId); // 0x0000000188C22D74-0x0000000188C22DA8
		public void StopTrack(Guid trackId, bool stopWithoutRelease = true /* Metadata: 0x02644554 */); // 0x0000000188C23180-0x0000000188C231D4
		public void StopAllTracks(bool stopWithoutRelease = true /* Metadata: 0x02644555 */); // 0x0000000188C22FFC-0x0000000188C23180
		public void SetStartTime(Guid trackId, long startTimeMs); // 0x0000000188C22F78-0x0000000188C22FB8
		public void SetLoop(Guid trackId, bool sw); // 0x0000000188C22EF4-0x0000000188C22F34
		public void SetVolume(Guid trackId, float volume); // 0x0000000188C22FB8-0x0000000188C22FFC
		public void SetPitch(Guid trackId, float pitch); // 0x0000000188C22F34-0x0000000188C22F78
		public void SetAISAC(Guid trackId, string controlName, float value); // 0x0000000188C22DE4-0x0000000188C22E34
		public void PlayerUpdateParameter(Guid trackId, CriAtomExPlayback atomExPlayback); // 0x0000000188C22DA8-0x0000000188C22DE4
		~CriAtomTimelinePreviewer(); // 0x0000000188C226F4-0x0000000188C2276C
		public void Dispose(); // 0x0000000188C2230C-0x0000000188C2235C
		private void Dispose(bool disposing); // 0x0000000188C2235C-0x0000000188C226F4
	}

	[TrackBindingType(typeof(CriAtomSourceBase))]
	[TrackClipType(typeof(CriAtomClipBase))]
	[TrackColor(0.3317462f, 0.6611561f, 0.990566f)]
	public class CriAtomTrack : TrackAsset // TypeDefIndex: 84462
	{
		// Fields
		public string m_AisacControls; // 0xC8
		public bool m_StopOnWrapping; // 0xD0
		public bool m_StopAtGraphEnd; // 0xD1
	
		// Constructors
		public CriAtomTrack(); // 0x0000000188C23878-0x0000000188C238CC
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject owner, int inputCount); // 0x0000000188C233F4-0x0000000188C23878
	}
}

namespace CriWare.CriTimeline.Mana
{
	[Serializable]
	public class CriManaBehaviour : PlayableBehaviour // TypeDefIndex: 84445
	{
		// Constructors
		public CriManaBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class CriManaClip : CriManaClipBase // TypeDefIndex: 84446
	{
		// Fields
		public string m_moviePath; // 0xA8
		public TextAsset m_movieData; // 0xB0
	
		// Properties
		public override string MoviePath { get; } // 0x0000000187232FB0-0x0000000187232FC0 
		public override byte[] MovieData { get; } // 0x0000000188C1BC94-0x0000000188C1BD0C 
		public override string MovieName { get; } // 0x0000000188C1BD0C-0x0000000188C1BDA8 
		public override int DataId { get; } // 0x0000000188C1BBEC-0x0000000188C1BC94 
	
		// Constructors
		public CriManaClip(); // 0x0000000188C1BB9C-0x0000000188C1BBEC
	}

	public abstract class CriManaClipBase : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 84448
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
		public ClipCaps clipCaps { get; } // 0x00000001872328C0-0x00000001872328D0 
		public bool IsMovieInfoReady { get; } // 0x0000000188C1BB44-0x0000000188C1BB80 
		public override double duration { get; } // 0x0000000188C1BB80-0x0000000188C1BB9C 
	
		// Nested types
		private struct MovieInfoStruct // TypeDefIndex: 84447
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
		protected CriManaClipBase(); // 0x0000000188C1BA64-0x0000000188C1BB44
	
		// Methods
		private MovieInfoStruct? StructToMovieInfo(MovieInfo movieInfo); // 0x0000000188C1B98C-0x0000000188C1BA64
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x0000000188C1B574-0x0000000188C1B638
		public void ReplaceMovieInfo(MovieInfo movieInfo); // 0x0000000188C1B7E0-0x0000000188C1B98C
		public bool IsSameMovie(MovieInfo movieInfo); // 0x0000000188C1B704-0x0000000188C1B7E0
		public int GetSeekFrame(double seekTimeSec, bool loop); // 0x0000000188C1B638-0x0000000188C1B704
	}

	[Serializable]
	public class CriManaMixerBehaviour : PlayableBehaviour // TypeDefIndex: 84453
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
		private static bool IsEditMode { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Nested types
		private enum MovieMixerState // TypeDefIndex: 84449
		{
			Preloading = 0,
			Ready = 1,
			Playing = 2,
			Stopping = 3,
			Stopped = 4
		}
	
		private enum ClipState // TypeDefIndex: 84450
		{
			Idle = 0,
			Prepare = 1,
			Play = 2,
			Seek = 3
		}
	
		[CompilerGenerated]
		private struct _ProcessFrameOnSeeking_d__31 : IAsyncStateMachine // TypeDefIndex: 84451
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
			private void MoveNext(); // 0x0000000188C28718-0x0000000188C28E58
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018783BAEC-0x000000018783BAF8
		}
	
		[CompilerGenerated]
		private sealed class _seekPlaybackEnumerator_d__35 : IEnumerator<object> // TypeDefIndex: 84452
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CriManaMixerBehaviour __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _seekPlaybackEnumerator_d__35(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188C28E58-0x0000000188C28F24
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188C28F24-0x0000000188C28F70
		}
	
		// Constructors
		public CriManaMixerBehaviour(); // 0x0000000187235F50-0x0000000187235F80
		static CriManaMixerBehaviour(); // 0x0000000188C1E5B4-0x0000000188C1E5F4
	
		// Methods
		private void KeepAudioVolume(bool fadeAudio); // 0x0000000188C1C090-0x0000000188C1C14C
		private bool PlayMovie(CriManaClipBase clipAsset, int startFrame, double startTime); // 0x0000000188C1C73C-0x0000000188C1CB24
		private bool PrepareMovie(CriManaClipBase clipAsset); // 0x0000000188C1CB24-0x0000000188C1CD84
		private bool StopMovie(); // 0x0000000188C1E2FC-0x0000000188C1E404
		private bool StopForSeekMovie(); // 0x0000000188C1E280-0x0000000188C1E2FC
		private static bool IsPlayerPreparing(Player player); // 0x0000000188C1BFF4-0x0000000188C1C024
		private static bool IsPlayerStopped(Player player); // 0x0000000188C1C070-0x0000000188C1C090
		private static bool IsPlayerError(Player player); // 0x0000000188C1BFD0-0x0000000188C1BFF4
		private static bool IsPlayerReadyOrPlaying(Player player); // 0x0000000188C1C024-0x0000000188C1C070
		private async void ProcessFrameOnSeeking(TimelineClip activeClip, CriManaClipBase clip, double frameTime); // 0x0000000188C1CD84-0x0000000188C1CE64
		private void ForceSyncedStop(bool keepLastFrame = false /* Metadata: 0x02644543 */); // 0x0000000188C1BDA8-0x0000000188C1BE50
		private void ToggleFMVNode(FrameData info, bool isOn, float weight = 1f /* Metadata: 0x02644544 */); // 0x0000000188C1E404-0x0000000188C1E5B4
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x0000000188C1CE64-0x0000000188C1E280
		[IteratorStateMachine(typeof(_seekPlaybackEnumerator_d__35))]
		private IEnumerator seekPlaybackEnumerator(); // 0x0000000188C1E5F4-0x0000000188C1E650
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x0000000188C1C158-0x0000000188C1C164
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x0000000188C1C14C-0x0000000188C1C158
		private void PausePlayer(bool pause); // 0x0000000188C1C6B4-0x0000000188C1C73C
		public override void OnGraphStart(Playable playable); // 0x0000000188C1C164-0x0000000188C1C454
		public override void OnGraphStop(Playable playable); // 0x0000000188C1C454-0x0000000188C1C5D0
		public override void OnPlayableCreate(Playable playable); // 0x0000000188C1C5D0-0x0000000188C1C668
		public override void OnPlayableDestroy(Playable playable); // 0x0000000188C1C668-0x0000000188C1C6B4
		public void InitMovieMixerState(); // 0x0000000188C1BE50-0x0000000188C1BFD0
	}

	[TrackBindingType(typeof(CriManaMovieMaterialBase))]
	[TrackClipType(typeof(CriManaClipBase))]
	[TrackColor(0.15f, 0.5f, 1f)]
	public class CriManaTrack : TrackAsset // TypeDefIndex: 84454
	{
		// Fields
		[Tooltip("\u9ED8\u8BA4\u662FTrue\uFF0C\u4E0D\u5141\u8BB8\u4FEE\u6539")]
		public bool frameSync; // 0xC8
		public readonly Guid guid; // 0xCC
		private static Dictionary<int, Guid> bindDict; // 0x00
		[CompilerGenerated]
		private CriManaMixerBehaviour _MixerBehaviour_k__BackingField; // 0xE0
	
		// Properties
		public CriManaMixerBehaviour MixerBehaviour { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872360B0-0x00000001872360C0 0x0000000188C247F0-0x0000000188C24804
	
		// Constructors
		public CriManaTrack(); // 0x0000000188C24778-0x0000000188C247F0
		static CriManaTrack(); // 0x0000000188C246EC-0x0000000188C24778
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x0000000188C23D68-0x0000000188C241FC
		public void BindBehaviourMovieMaterial(PlayableDirector director, CriManaMovieMaterialBase boundMovieMaterial); // 0x0000000188C238CC-0x0000000188C23D68
		private void OnDestroy(); // 0x0000000188C241FC-0x0000000188C24254
		private static void RemoveTrackFromBindDict(CriManaTrack trackAsset); // 0x0000000188C24254-0x0000000188C246EC
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 84169
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 84497
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x0000000188C249E8-0x0000000188C24A4C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 84498
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000188C24A90-0x0000000188C24B28
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000188C24A4C-0x0000000188C24A90
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 84499
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000188C2915C-0x0000000188C291C0
		public static bool IsPatched(int id); // 0x0000000188C2924C-0x0000000188C292E4
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000188C29014-0x0000000188C290E0
		public object CreateWrapper(int id); // 0x0000000188C290E0-0x0000000188C2915C
		public object InitWrapperArray(int len); // 0x0000000188C291C0-0x0000000188C2924C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000188C28F70-0x0000000188C29014
	}
}
