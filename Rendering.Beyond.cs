/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Beyond;
using Beyond.PoolCore;
using Beyond.Rendering;
using Beyond.Rendering.ECS;
using Beyond.Resource;
using HG.Rendering.Runtime;
using IFix.Core;
using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.Splines;
using UnityEngine.UI;

// Image 33: Rendering.Beyond.dll - Assembly: Rendering.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57500-57652
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DisallowMultipleComponent]
[ExecuteInEditMode]
public class LDstaticObjectLightmappingDataLoader : MonoBehaviour // TypeDefIndex: 57501
{
	// Fields
	public bool test; // 0x18
	public bool recover; // 0x19
	public Renderer[] ldLightmappedRenderer; // 0x20
	public int[] ldLightmappedRendererLightmapIndex; // 0x28
	public Vector4[] ldLightmappedRendererLightmapUvScale; // 0x30

	// Constructors
	public LDstaticObjectLightmappingDataLoader(); // 0x0000000185393520-0x0000000185393538

	// Methods
	public void RecoverLightmapdata(); // 0x000000018A9AD448-0x000000018A9AD5DC
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 57648
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_20 _7848C87B1819709EC2A0D678BCD530B3C49CA3BB2F61B8FCEF827B64DE251E15; // 0x00 // Static value (base64): mpkZPs3MTD6amZk+zcxMPpqZGT4= - Metadata: 0x0234B3FC

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 57647
	{
	}
}

namespace Beyond.Rendering
{
	public class CustomPerDrawDataChannelUtils // TypeDefIndex: 57510
	{
		// Fields
		public const int HOUDINI_VAT_INDEX = 3; // Metadata: 0x0234B130
		public const int HOUDINI_VAT_CHANNEL = 0; // Metadata: 0x0234B131
		public const int LIT_EMISSIVE_INDEX = 2; // Metadata: 0x0234B132
		public const int LIT_EMISSIVE_ANIMATION_SWEEP_INDEX = 3; // Metadata: 0x0234B133
		public const int LIT_EMISSIVE_ALBEDO_INDEX = 4; // Metadata: 0x0234B134
		public const int UV_ANIMATION_INDEX = 3; // Metadata: 0x0234B135
		public const int MOVING_BAMBOO_CUR_PARAM_INDEX = 2; // Metadata: 0x0234B136
		public const int MOVING_BAMBOO_LAST_PARAM_INDEX = 3; // Metadata: 0x0234B137
		public const int LIT_DISSOLVE_INDEX = 4; // Metadata: 0x0234B138
		public const int LIT_DISSOLVE_CHANNEL = 0; // Metadata: 0x0234B139
		public const int CHARACTER_PARAMS_INDEX = 2; // Metadata: 0x0234B13A
		public const int CHARACTER_ENVIRONMENT_EFFECT_INTENSITY_CHANNEL = 0; // Metadata: 0x0234B13B
		public const int CHARACTER_WET_EFFECT_WORLD_SPACE_HEIGHT_CHANNEL = 1; // Metadata: 0x0234B13C
		public const int CHARACTER_DISSOLVE_SCHEDULE_OFFSET_CHANNEL = 3; // Metadata: 0x0234B13D
		public const int CHARACTER_RAIN_EFFECT_INTENSITY_CHANNEL_BIT = 8; // Metadata: 0x0234B13E
		public const int CHARACTER_WET_EFFECT_INTENSITY_CHANNEL_BIT = 16; // Metadata: 0x0234B13F
		public const int CHARACTER_WET_EFFECT_GLOBAL_INTENSITY_CHANNEL_BIT = 24; // Metadata: 0x0234B140
		public const int CHARACTER_SNOW_EFFECT_INTENSITY_CHANNEL_BIT = 32; // Metadata: 0x0234B141
		public const int CHARACTER_PARAMS_CHANNEL_BIT_BIAS = 8; // Metadata: 0x0234B142
		public const int CHANNELS_PER_PARAM = 4; // Metadata: 0x0234B143
		public const int VFX_ALPHA_INDEX = 4; // Metadata: 0x0234B144
		public const int VFX_ALPHA_DEFAULT_CHANNEL = 0; // Metadata: 0x0234B145
		public const int TRAIL_EFFECT_DISPLAY_INDEX = 2; // Metadata: 0x0234B146
		public const int TRAIL_EFFECT_SCAN_INDEX = 3; // Metadata: 0x0234B147
	
		// Constructors
		public CustomPerDrawDataChannelUtils(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void SetPerDrawData_LitDissolve(Renderer affectRenderer, float dissolve); // 0x000000018A9AB688-0x000000018A9AB720
		public static void SetPerDrawData_HoudiniVAT(Renderer affectRenderer, int displayFrame); // 0x000000018A9AB5EC-0x000000018A9AB688
		public static void SetPerDrawData_MovingBamboo(Renderer affectRenderer, Vector4 curParam, Vector4 lastParam); // 0x000000018A9AB720-0x000000018A9AB7E0
		public static void SetPerDrawData_EmissiveColor(Renderer affectRenderer, Vector4 emissive); // 0x0000000183F26D20-0x0000000183F26D90
		public static void SetPerDrawData_EmissiveAlbedoColor(Renderer affectRenderer, Vector4 emissiveAlbedo); // 0x0000000183F26D90-0x0000000183F26E00
		public static void SetPerDrawData_SweepLightIntensity(Renderer affectRenderer, float intensity); // 0x0000000183F26F90-0x0000000183F27070
		public static void SetPerDrawData_SweepBreathing(Renderer affectRenderer, float frequency, float intensity, float timeOffset = 0f /* Metadata: 0x0234B12C */); // 0x0000000183F26E00-0x0000000183F26EE0
		public static void SetPerDrawData_UVAnimation(Renderer affectRenderer, float animationEnable, float customAddTime); // 0x000000018A9AB95C-0x000000018A9ABA0C
		public static void SetPerDrawData_CharacterParams(Renderer affectRenderer, Vector4 param0); // 0x000000018323AF00-0x000000018323AF90
		public static void SetPerDrawData_VFXAlpha0(Renderer affectRenderer, float alpha); // 0x000000018A9ABA0C-0x000000018A9ABAB0
		public static void SetPerDrawData_TrailDisplayArea(Renderer affectRenderer, float displayDistanceStart1, float displayDistanceEnd1, float displayDistanceStart2, float displayDistanceEnd2); // 0x000000018A9AB7E0-0x000000018A9AB8BC
		public static void SetPerDrawData_TrailScanCircle(Renderer affectRenderer, float scanRadiusStart, float scanRadiusEnd); // 0x000000018A9AB8BC-0x000000018A9AB95C
	}

	public static class PipelineSettingHelper // TypeDefIndex: 57511
	{
		// Fields
		public const string SETTING_FOLDER = "Settings/"; // Metadata: 0x0234B148
		public const string SETTING_FILE_LIST = "SettingFiles.txt"; // Metadata: 0x0234B152
	
		// Methods
		public static void LoadPipelineSettings(); // 0x0000000183583870-0x00000001835841A0
		private static string _LoadSetting(string settingName); // 0x00000001835850E0-0x00000001835855B0
		private static string _GetFullSettingPath(string settingName); // 0x0000000183584E30-0x0000000183584E90
	}

	public static class ResourceRouter // TypeDefIndex: 57512
	{
		// Fields
		private const string DYNAMIC_ENVIRONMENTS_FOLDER = "Gameplay/Environments/"; // Metadata: 0x0234B167
	
		// Methods
		private static string _GetCategoryFolder(RootCategory category); // 0x000000018A9AD718-0x000000018A9AD784
		public static string GetEnvironmentsFullPath(RootCategory category = RootCategory.Main /* Metadata: 0x0234B163 */, bool isDevOnly = false /* Metadata: 0x0234B164 */); // 0x000000018A9AD69C-0x000000018A9AD718
		public static string GetDecalResourcesPath(); // 0x000000018A9AD658-0x000000018A9AD69C
		public static string GetDecalResourcesFullPath(RootCategory category = RootCategory.Main /* Metadata: 0x0234B165 */, bool isDevOnly = false /* Metadata: 0x0234B166 */); // 0x000000018A9AD5DC-0x000000018A9AD658
	}

	public class ShaderWarmupManager // TypeDefIndex: 57524
	{
		// Fields
		public static readonly string RUNTIME_PSO_COLLECTION_FOLDER; // 0x00
		private const string WARM_UP_KEY_WORD = "hg_warm_up_once"; // Metadata: 0x0234B181
		private const string WARM_UP_API_KEY_WORD = "hg_warm_up_graphics"; // Metadata: 0x0234B191
		private const string WARM_UP_DRIVER_KEY_WORD = "hg_warm_up_graphics_drivers"; // Metadata: 0x0234B1A5
		private const string WARM_UP_REASON_KEY_WORD = "hg_warm_up_reason"; // Metadata: 0x0234B1C1
		private const string WARMUP_RETRY_COUNT = "hg_warmup_retry_count"; // Metadata: 0x0234B1D3
		private const string WARMUP_UNFINISHED_COUNT = "hg_warmup_unfinished_count"; // Metadata: 0x0234B1E9
		private const string DOWNLOADING_WARMUP_UNFINISHED_COUNT = "hg_warmup_down_unfinished_count"; // Metadata: 0x0234B204
		private const string FEATURE_RAYTRACING = "raytracing"; // Metadata: 0x0234B224
		private const string FEATURE_ONE_PASS = "onepass"; // Metadata: 0x0234B22F
		private const int SHADER_COMPILE_WEIGHT = 2; // Metadata: 0x0234B237
		public static readonly int UNFINISHED_RETRY_COUNT_LIMIT; // 0x08
		public static readonly int DOWNLOADING_UNFINISHED_RETRY_COUNT_LIMIT; // 0x0C
		public static readonly int CACHE_FAILED_RETRY_COUNT_LIMIT; // 0x10
		public static bool s_shouldUseOverride; // 0x14
		public static bool s_needWarmupOverride; // 0x15
		public static int s_forceLoginWarmupStartIndex; // 0x18
		public static int s_forceLoginWarmupCount; // 0x1C
		public static int s_forceSceneWarmupStartIndex; // 0x20
		public static int s_forceSceneWarmupCount; // 0x24
		private static string s_disabledFeature; // 0x28
		private static bool s_warmupByCacheLoadChecked; // 0x30
		private static bool s_isDeviceInBlackList; // 0x31
		private static bool s_isDx11DriverCheck; // 0x32
		public static int s_warmupTotalCount; // 0x34
		public static int s_warmupTotalCountWeighted; // 0x38
		public static int s_warmupRemainCountWeighted; // 0x3C
		private static int s_warmupFinishedCount; // 0x40
		private static int s_cacheFileSizeBefore; // 0x44
		private static int s_compileTotalCount; // 0x48
		public static float s_loginWarmUpTime; // 0x4C
		public static WarmUpReason s_loginWarmUpReason; // 0x50
		public static float s_downloadWarmupPercent; // 0x54
		private static WarmupRunType s_lastWarmupRunType; // 0x58
		private static bool s_isDownloadingWarmupRunning; // 0x5C
		private static bool s_shouldStopDownloadingWarmup; // 0x5D
		public static long s_cacheSizeRecompileThreshold; // 0x60
		public static int s_warmupCountPerWorkerMainJobCompile; // 0x68
		public static int s_warmupCountPerStepBackJobCompile; // 0x6C
		public static int s_warmupCountPerStepMainJob; // 0x70
		public static int s_warmupCountPerStepBackJob; // 0x74
		public static int s_warmupCountPerStepBackDispatchLimit; // 0x78
		public static int s_warmupCountToClean; // 0x7C
		public static int s_warmupTimeLimitMobile; // 0x80
		public static int s_warmupTimeLimitPC; // 0x84
		public static string s_vulkanCacheFileName; // 0x88
		public static string s_iosCacheFileName; // 0x90
	
		// Properties
		public static bool isWarming { get; } // 0x0000000183EBBA10-0x0000000183EBBA90 
	
		// Nested types
		public enum WarmUpReason // TypeDefIndex: 57513
		{
			NoReason = 0,
			FirstEntryGame = 1,
			LodChange = 2,
			AssetUpdate = 3,
			AppUpdate = 4,
			GraphicsAPIChange = 5,
			ShaderCacheSmall = 6,
			ShaderCacheIOInvalid = 7,
			DevOverride = 8,
			CrashRetry = 9,
			PsoCacheCorrupted = 10,
			ShaderCacheApiInvalid = 11,
			DriverVersionUpdate = 12,
			RemoteCtrlRetry = 13
		}
	
		private enum WarmupRunType // TypeDefIndex: 57514
		{
			None = 0,
			Login = 1,
			Download = 2
		}
	
		private class TimeCostCounter // TypeDefIndex: 57515
		{
			// Fields
			private const float MAX_DELTA_TIME = 5f; // Metadata: 0x0234B249
			private const float MAX_DELTA_TIME_FIX = 1f; // Metadata: 0x0234B24D
			[CompilerGenerated]
			private float _duration_k__BackingField; // 0x10
			private float m_lastRealTime; // 0x14
			private float m_maxDurationSecond; // 0x18
	
			// Properties
			public float duration { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
			public bool isTimeOut { get; } // 0x000000018A9AF2B8-0x000000018A9AF30C 
	
			// Constructors
			public TimeCostCounter(float maxDurationMilliSecond); // 0x000000018A9AF2A4-0x000000018A9AF2B8
	
			// Methods
			public void Begin(); // 0x000000018A9AF1D4-0x000000018A9AF230
			public void Tick(); // 0x000000018A9AF230-0x000000018A9AF2A4
		}
	
		[CompilerGenerated]
		private sealed class _WarmupShadersLogin_d__63 : IEnumerator<object> // TypeDefIndex: 57516
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool supportsRaytracing; // 0x20
			private List<FAssetProxyHandle> _assetProxyHandles_5__2; // 0x28
			private List<HGPsoWarmupCollection> _loadedAssets_5__3; // 0x30
			private int _unfinishedCount_5__4; // 0x38
			private TimeCostCounter _timeCostCounter_5__5; // 0x40
			private int _i_5__6; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WarmupShadersLogin_d__63(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000182E5AD40-0x0000000182E5ADC0
			private bool MoveNext(); // 0x0000000182E58FD0-0x0000000182E5ACF0
			private void __m__Finally1(); // 0x0000000182E5ADC0-0x0000000182E5AFD0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E5ACF0-0x0000000182E5AD40
		}
	
		[CompilerGenerated]
		private sealed class _WarmupShadersDownloading_d__64 : IEnumerator<object> // TypeDefIndex: 57517
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool supportsRaytracing; // 0x20
			private List<FAssetProxyHandle> _assetProxyHandles_5__2; // 0x28
			private List<HGPsoWarmupCollection> _loadedAssets_5__3; // 0x30
			private int _i_5__4; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WarmupShadersDownloading_d__64(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000182E58B60-0x0000000182E58BE0
			private bool MoveNext(); // 0x0000000182E57FD0-0x0000000182E58B10
			private void __m__Finally1(); // 0x0000000182E58BE0-0x0000000182E58FD0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E58B10-0x0000000182E58B60
		}
	
		[CompilerGenerated]
		private sealed class __StopDownloadingWarmupAndWait_d__66 : IEnumerator<object> // TypeDefIndex: 57518
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __StopDownloadingWarmupAndWait_d__66(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000182E5CBC0-0x0000000182E5CDC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E5CDC0-0x0000000182E5CE10
		}
	
		[CompilerGenerated]
		private sealed class __LoadPsoAssets_d__71 : IEnumerator<object> // TypeDefIndex: 57519
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public List<StringPathHash> resPathList; // 0x20
			public List<FAssetProxyHandle> assetProxyHandles; // 0x28
			public List<HGPsoWarmupCollection> loadedAssets; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __LoadPsoAssets_d__71(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000182E5C460-0x0000000182E5CB70
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E5CB70-0x0000000182E5CBC0
		}
	
		[CompilerGenerated]
		private sealed class _WarmupShadersScene_d__72 : IEnumerator<object> // TypeDefIndex: 57520
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string scene; // 0x20
			private string _path_5__2; // 0x28
			private FAssetProxyHandle _assetHandle_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WarmupShadersScene_d__72(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000182E5AFD0-0x0000000182E5C410
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E5C410-0x0000000182E5C460
		}
	
		[CompilerGenerated]
		private sealed class _WarmupOnePso_d__73 : IEnumerator<object> // TypeDefIndex: 57521
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public HGPsoWarmupCollection psoC; // 0x20
			public int startIndex; // 0x28
			public int warmupCount; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WarmupOnePso_d__73(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000182E57AB0-0x0000000182E57F80
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E57F80-0x0000000182E57FD0
		}
	
		[CompilerGenerated]
		private sealed class __WarmupOnePsoTimeLimited_d__74 : IEnumerator<object> // TypeDefIndex: 57522
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public HGPsoWarmupCollection psoC; // 0x20
			public int startIndex; // 0x28
			public int desiredWarmupCount; // 0x2C
			public TimeCostCounter timeStart; // 0x30
			private int _totalCount_5__2; // 0x38
			private int _computeShaderCount_5__3; // 0x3C
			private int _warmupCountPerStepMainJobCompile_5__4; // 0x40
			private int _compileTotalCount_5__5; // 0x44
			private int _countToCleanUp_5__6; // 0x48
			private int _backJobLastLeftCount_5__7; // 0x4C
			private int _leftBackJobCount_5__8; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __WarmupOnePsoTimeLimited_d__74(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000182E5D750-0x0000000182E5E2C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E5E2C0-0x0000000182E5E3A0
		}
	
		[CompilerGenerated]
		private sealed class __WarmupOnePsoBackgroundOnly_d__75 : IEnumerator<object> // TypeDefIndex: 57523
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public HGPsoWarmupCollection psoC; // 0x20
			public int startIndex; // 0x28
			public int desiredWarmupCount; // 0x2C
			private int _totalCount_5__2; // 0x30
			private int _compileTotalCount_5__3; // 0x34
			private int _countToCleanUp_5__4; // 0x38
			private int _backJobLastLeftCount_5__5; // 0x3C
			private int _currentIndex_5__6; // 0x40
			private int _leftBackJobCount_5__7; // 0x44
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __WarmupOnePsoBackgroundOnly_d__75(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000182E5CE10-0x0000000182E5D700
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E5D700-0x0000000182E5D750
		}
	
		// Constructors
		public ShaderWarmupManager(); // 0x00000001841E1670-0x00000001841E1680
		static ShaderWarmupManager(); // 0x00000001849916A0-0x0000000184991B10
	
		// Methods
		[IDTag(0)]
		public static string GetPsoPathName(RuntimePlatform platform, GraphicsDeviceType graphicsDeviceType, int shaderLod, string levelId); // 0x000000018A9ADE68-0x000000018A9ADF3C
		[IDTag(1)]
		public static string GetPsoPathName(RuntimePlatform platform, GraphicsDeviceType graphicsDeviceType, int shaderLod, string levelId, string feature); // 0x000000018A9ADF3C-0x000000018A9AE024
		public static string GetLoginWarmupDetail(); // 0x0000000184D537E0-0x0000000184D53840
		private static long _GetCacheFileSize(); // 0x000000018A9AE6EC-0x000000018A9AE7F4
		public static void ProcessRemoteConfig(string remoteConfigStr); // 0x0000000183C8F850-0x0000000183C8F910
		public static void MarkNeedShaderWarmUp(WarmUpReason reason); // 0x000000018A9AE024-0x000000018A9AE08C
		public static void MarkWarmUpLoginFinish(); // 0x000000018A9AE08C-0x000000018A9AE0E8
		public static void CleanLoadedPso(); // 0x000000018A9ADE0C-0x000000018A9ADE68
		private static void _MarkWarmUpLoginFinish(); // 0x000000018A9AEAFC-0x000000018A9AEB78
		public static void TryRepairPsoCacheAfterCorruptCheck(); // 0x000000018A9AE0E8-0x000000018A9AE150
		private static bool _TryDeleteVulkanPsoCacheFile(); // 0x000000018A9AEEF4-0x000000018A9AF088
		public static bool CheckNeedWarmUpLogin(bool stateless = false /* Metadata: 0x0234B17E */); // 0x0000000183C90DA0-0x0000000183C90EF0
		[IteratorStateMachine(typeof(_WarmupShadersLogin_d__63))]
		public static IEnumerator WarmupShadersLogin(bool supportsRaytracing); // 0x000000018A9AE244-0x000000018A9AE2A0
		[IteratorStateMachine(typeof(_WarmupShadersDownloading_d__64))]
		public static IEnumerator WarmupShadersDownloading(bool supportsRaytracing); // 0x000000018A9AE1E8-0x000000018A9AE244
		public static void StopWarmupShadersDownloading(); // 0x00000001846DD340-0x00000001846DD390
		[IteratorStateMachine(typeof(__StopDownloadingWarmupAndWait_d__66))]
		private static IEnumerator _StopDownloadingWarmupAndWait(); // 0x000000018A9AEEA4-0x000000018A9AEEF4
		private static List<StringPathHash> _BuildLoginWarmupPaths(bool supportsRaytracing); // 0x000000018A9AE314-0x000000018A9AE514
		private static void _InitWarmupStats(List<HGPsoWarmupCollection> loadedAssets, bool isBackgroundWarmup = false /* Metadata: 0x0234B17F */, bool updateCacheFileSizeBefore = true /* Metadata: 0x0234B180 */); // 0x0000000182E574D0-0x0000000182E57820
		private static void _UpdateDownloadWarmupPercent(); // 0x0000000182E578F0-0x0000000182E57AB0
		private static void _DisposeWarmupAssetHandles(List<FAssetProxyHandle> assetProxyHandles); // 0x000000018A9AE514-0x000000018A9AE660
		[IteratorStateMachine(typeof(__LoadPsoAssets_d__71))]
		private static IEnumerator _LoadPsoAssets(List<StringPathHash> resPathList, List<FAssetProxyHandle> assetProxyHandles, List<HGPsoWarmupCollection> loadedAssets); // 0x000000018A9AEA54-0x000000018A9AEAFC
		[IteratorStateMachine(typeof(_WarmupShadersScene_d__72))]
		[Obsolete]
		public static IEnumerator WarmupShadersScene(string scene); // 0x000000018A9AE2A0-0x000000018A9AE314
		[IteratorStateMachine(typeof(_WarmupOnePso_d__73))]
		[Obsolete]
		public static IEnumerator WarmupOnePso(HGPsoWarmupCollection psoC, int startIndex, int warmupCount); // 0x000000018A9AE150-0x000000018A9AE1E8
		[IteratorStateMachine(typeof(__WarmupOnePsoTimeLimited_d__74))]
		private static IEnumerator _WarmupOnePsoTimeLimited(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount, TimeCostCounter timeStart); // 0x000000018A9AF120-0x000000018A9AF1D4
		[IteratorStateMachine(typeof(__WarmupOnePsoBackgroundOnly_d__75))]
		private static IEnumerator _WarmupOnePsoBackgroundOnly(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount); // 0x000000018A9AF088-0x000000018A9AF120
		private static void _StepProgress(int newFinishedCount, ref int compileTotalCount); // 0x000000018A9AEDE8-0x000000018A9AEEA4
		private static bool _CheckNeedWarmUpByFirstEntry(); // 0x0000000183811960-0x0000000183811A00
		private static bool _CheckNeedWarmUpByDeviceState(bool stateless); // 0x0000000183C91110-0x0000000183C911E0
		private static bool _IsNeedWarmupByGraphicsChange(); // 0x0000000183C905A0-0x0000000183C906A0
		private static bool _IsNeedWarmupByCacheOutdated(); // 0x0000000183C91030-0x0000000183C910D0
		private static void _SetWarmupRetryCount(int count); // 0x000000018A9AED30-0x000000018A9AED8C
		private static void _SetWarmupUnfinishedCount(int count); // 0x000000018A9AED8C-0x000000018A9AEDE8
		private static int _GetDownloadingWarmupUnfinishedCount(); // 0x000000018A9AE89C-0x000000018A9AE8EC
		private static void _SetDownloadingWarmupUnfinishedCount(int count); // 0x000000018A9AECD4-0x000000018A9AED30
		private static void _MarkWarmupFinishAPI(); // 0x000000018A9AEC48-0x000000018A9AECD4
		private static bool _IsNeedWarmupDx11Driver(); // 0x0000000183C92470-0x0000000183C92510
		private static void _MarkWarmupDx11Driver(); // 0x000000018A9AEB78-0x000000018A9AEC48
		private static void _ResetWarmUpStatsIfNeed(); // 0x0000000183C90F40-0x0000000183C90FA0
		private static bool _IsDeviceSupportWarmUp(); // 0x0000000183C90EF0-0x0000000183C90F40
		private static bool _IsDeviceSupportDownloadWarmUp(); // 0x0000000182E57820-0x0000000182E578F0
		private static bool _IsFeatureEnabled(string featureKeyword); // 0x000000018A9AE9E8-0x000000018A9AEA54
		private static bool _CheckWarmUpUnfinishedOften(); // 0x0000000183C90FA0-0x0000000183C91030
		private static int _GetLoginTimeLimit(); // 0x000000018A9AE8EC-0x000000018A9AE948
		private static int _GetWarmupEndIndexExclusive(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount); // 0x000000018A9AE948-0x000000018A9AE9E8
		private static int _GetCompileCountForRange(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount); // 0x000000018A9AE7F4-0x000000018A9AE89C
		private static int _GetBackgroundWarmupStartIndex(HGPsoWarmupCollection psoC, int startIndex, int endIndexExclusive); // 0x000000018A9AE660-0x000000018A9AE6EC
	}

	public class ShaderWarmupManagerRemoteCfg // TypeDefIndex: 57528
	{
		// Fields
		[CanBeNull]
		private ShaderWarmupRemoteBlacklist m_blacklist; // 0x10
	
		// Properties
		private static string cpuNameForWarmUp { get; } // 0x000000018A9ADDCC-0x000000018A9ADE0C 
	
		// Nested types
		[Serializable]
		private class ShaderWarmupRemoteBlackDevice // TypeDefIndex: 57525
		{
			// Fields
			public string deviceModel; // 0x10
			public string graphicsDeviceName; // 0x18
			public string graphicsDeviceVersion; // 0x20
			public string os; // 0x28
			public string cpuName; // 0x30
			public string disableFeature; // 0x38
	
			// Constructors
			public ShaderWarmupRemoteBlackDevice(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		private class ShaderWarmupGlobalConfig // TypeDefIndex: 57526
		{
			// Fields
			public bool enableDriverVerDetect; // 0x10
	
			// Constructors
			public ShaderWarmupGlobalConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		private class ShaderWarmupRemoteBlacklist // TypeDefIndex: 57527
		{
			// Fields
			public List<ShaderWarmupRemoteBlackDevice> devices; // 0x10
			public ShaderWarmupGlobalConfig config; // 0x18
	
			// Constructors
			public ShaderWarmupRemoteBlacklist(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public ShaderWarmupManagerRemoteCfg(string blackListStr); // 0x0000000183C8F940-0x0000000183C8F990
	
		// Methods
		public bool IsEnableDx11DriverVersionDetect(); // 0x0000000183C8F910-0x0000000183C8F940
		public bool IsDeviceInBlackList(out string disabledFeature); // 0x0000000183C8F3C0-0x0000000183C8F590
		private static bool _CheckDeviceMatch(ShaderWarmupRemoteBlackDevice blacklistDevice, string currentDeviceModel, string currentGraphicsDeviceName, string currentGraphicsDeviceVersion, string currentProcessorType, string currentOS); // 0x000000018A9ADB54-0x000000018A9ADDCC
	}

	public static class WindowsGpuDriverVersion // TypeDefIndex: 57534
	{
		// Fields
		private static readonly Guid GUID_DEVCLASS_DISPLAY; // 0x00
		private const uint DIGCF_PRESENT = 2; // Metadata: 0x0234B251
		private const uint SPDRP_DEVICEDESC = 0; // Metadata: 0x0234B252
		private const uint SPDRP_MFG = 11; // Metadata: 0x0234B253
		private const uint SPDRP_FRIENDLYNAME = 12; // Metadata: 0x0234B254
		private const uint SPDRP_DRIVER = 9; // Metadata: 0x0234B255
		private const uint DICS_FLAG_GLOBAL = 1; // Metadata: 0x0234B256
		private const uint DIREG_DRV = 2; // Metadata: 0x0234B257
		private static readonly IntPtr INVALID_HANDLE_VALUE; // 0x10
		private const int ERROR_SUCCESS = 0; // Metadata: 0x0234B258
		private const int ERROR_NO_MORE_ITEMS = 259; // Metadata: 0x0234B259
		private const int ERROR_INSUFFICIENT_BUFFER = 122; // Metadata: 0x0234B25B
		private const int ERROR_MORE_DATA = 234; // Metadata: 0x0234B25D
		private const uint REG_SZ = 1; // Metadata: 0x0234B25F
		private const uint REG_EXPAND_SZ = 2; // Metadata: 0x0234B260
	
		// Nested types
		public sealed class Result // TypeDefIndex: 57529
		{
			// Fields
			public string driverVersion; // 0x10
			public string deviceName; // 0x18
			public string deviceDesc; // 0x20
			public string mfg; // 0x28
			public int score; // 0x30
			public string driverKey; // 0x38
			public string keyId; // 0x40
	
			// Constructors
			public Result(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public override string ToString(); // 0x000000018A9AD784-0x000000018A9AD8FC
			public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
		}
	
		private sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 57530
		{
			// Constructors
			internal SafeRegistryHandle(); // 0x00000001853948D4-0x00000001853948E4
			internal SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle); // 0x00000001839B85E0-0x00000001839B8610
	
			// Methods
			protected override bool ReleaseHandle(); // 0x000000018A9AD91C-0x000000018A9AD984
		}
	
		[Flags]
		private enum RegistryRights // TypeDefIndex: 57531
		{
			KEY_QUERY_VALUE = 1
		}
	
		private struct SP_DEVINFO_DATA // TypeDefIndex: 57532
		{
			// Fields
			public uint cbSize; // 0x00
			public Guid classGuid; // 0x04
			public uint devInst; // 0x14
			public IntPtr reserved; // 0x18
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57533
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Result> __9__18_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A9AF334-0x000000018A9AF37C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetAllDisplayDriverVersions_b__18_0(Result a, Result b); // 0x000000018A9AF30C-0x000000018A9AF334
		}
	
		// Constructors
		static WindowsGpuDriverVersion(); // 0x000000018A9B12D4-0x000000018A9B16B0
	
		// Methods
		public static string GetCurrentDriverVersion(); // 0x000000018A9B0168-0x000000018A9B01DC
		public static Result GetBestMatch(); // 0x000000018A9AFBAC-0x000000018A9B0168
		public static List<Result> GetAllDisplayDriverVersions(); // 0x000000018A9AF37C-0x000000018A9AFBAC
		public static string SerializeAllResults(List<Result> results); // 0x000000018A9B0470-0x000000018A9B0620
		public static string SerializeAllCurrentResults(); // 0x000000018A9B0414-0x000000018A9B0470
		public static bool IsBestMatchDriverVersionChanged(string serialized); // 0x000000018A9B01DC-0x000000018A9B02C4
		private static bool _TryGetDriverVersionByKeyId(string serialized, string keyId, out string driverVersion); // 0x000000018A9B116C-0x000000018A9B12D4
		private static int _ScoreAgainstUnityCurrentGpu(string friendlyName, string deviceDesc, string mfg); // 0x000000018A9B0ED8-0x000000018A9B116C
		private static bool _ContainsIgnoreCase(string a, string b); // 0x000000018A9B0954-0x000000018A9B09D8
		private static string _GetDeviceRegistryPropertyString(IntPtr infoSet, ref SP_DEVINFO_DATA devInfo, uint prop); // 0x000000018A9B09D8-0x000000018A9B0C20
		private static string _GetDriverKeySuffix(string driverKey); // 0x000000018A9B0C20-0x000000018A9B0CB4
		private static string _ReadRegistrySz(SafeRegistryHandle hKey, string valueName); // 0x000000018A9B0CB4-0x000000018A9B0ED8
		private static extern int RegCloseKey(IntPtr hKey); // 0x000000018A9B02C4-0x000000018A9B0308
		private static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, IntPtr enumerator, IntPtr hwndParent, uint flags); // 0x000000018A9B06F4-0x000000018A9B07A0
		private static extern bool SetupDiEnumDeviceInfo(IntPtr deviceInfoSet, uint memberIndex, ref SP_DEVINFO_DATA deviceInfoData); // 0x000000018A9B0658-0x000000018A9B06F4
		private static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint property, out uint propertyRegDataType, IntPtr propertyBuffer, uint propertyBufferSize, out uint requiredSize); // 0x000000018A9B07A0-0x000000018A9B0874
		private static extern SafeRegistryHandle SetupDiOpenDevRegKey(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint scope, uint hwProfile, uint keyType, int samDesired); // 0x000000018A9B0874-0x000000018A9B0954
		private static extern bool SetupDiDestroyDeviceInfoList(IntPtr deviceInfoSet); // 0x000000018A9B0620-0x000000018A9B0658
		private static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, IntPtr lpReserved, out uint lpType, IntPtr lpData, ref uint lpcbData); // 0x000000018A9B0308-0x000000018A9B0414
	}

	public static class SOCHelper // TypeDefIndex: 57535
	{
		// Fields
		public static readonly int CHUNK_SIZE; // 0x00
		public const string SOC_FOLDER_NAME = "OcclusionCulling"; // Metadata: 0x0234B262
		public const string SOC_INTERMEDIATE_FILE_NAME = "[x]HGSOCChunkData.asset"; // Metadata: 0x0234B273
	
		// Constructors
		static SOCHelper(); // 0x000000018A9AD8FC-0x000000018A9AD91C
	}

	[Serializable]
	public struct SceneStateAreaKey : IEquatable<SceneStateAreaKey> // TypeDefIndex: 57536
	{
		// Fields
		public uint sceneStateMask; // 0x00
		public int areaId; // 0x04
		public static readonly SceneStateAreaKey DEFAULT; // 0x00
	
		// Constructors
		public SceneStateAreaKey(uint sceneStateMask, int areaId); // 0x0000000184D85C40-0x0000000184D85C50
		static SceneStateAreaKey(); // 0x0000000184DA6BD0-0x0000000184DA6BF0
	
		// Methods
		[IDTag(0)]
		public bool Equals(SceneStateAreaKey other); // 0x000000018A9AD984-0x000000018A9AD9F0
		[IDTag(1)]
		public override bool Equals(object obj); // 0x000000018A9AD9F0-0x000000018A9ADA80
		public override int GetHashCode(); // 0x000000018A9ADA80-0x000000018A9ADAF0
		public bool __iFixBaseProxy_Equals(object P0); // 0x000000018A9ADAF0-0x000000018A9ADB28
		public int __iFixBaseProxy_GetHashCode(); // 0x000000018A9ADB28-0x000000018A9ADB54
	}

	public class HGSOCSubSceneData : ScriptableObject // TypeDefIndex: 57539
	{
		// Fields
		public SceneStateAreaKey[] keyArray; // 0x18
		[FormerlySerializedAs("stateDataArray")]
		public SubSceneDataPerSceneStateArea[] dataArray; // 0x20
	
		// Nested types
		[Serializable]
		public struct ChunkData // TypeDefIndex: 57537
		{
			// Fields
			public Vector3[] centers; // 0x00
			public Vector3[] extents; // 0x08
			public Vector3[] vertexData; // 0x10
			public float[] areas; // 0x18
		}
	
		[Serializable]
		public struct SubSceneDataPerSceneStateArea // TypeDefIndex: 57538
		{
			// Fields
			public Vector2Int[] chunkCoords; // 0x00
			public ChunkData[] chunkDataArray; // 0x08
			public int[] explicitLayers; // 0x10
		}
	
		// Constructors
		public HGSOCSubSceneData(); // 0x0000000183573370-0x0000000183573380
	}

	[ExecuteInEditMode]
	public class HGSOCDataHelper : MonoBehaviour // TypeDefIndex: 57540
	{
		// Fields
		[Header("OC\u6321\u7247\u968F\u8DDD\u79BB\u8870\u51CF\u7A0B\u5EA6(\u4EC5\u751F\u6548LA\u6321\u7247)")]
		[Range(0f, 1f)]
		public float fallOffStrength; // 0x18
		[Header("\u88AB\u906E\u6321OC\u6321\u7247\u7684\u663E\u793A\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float innerBlendWeight; // 0x1C
		[CompilerGenerated]
		private bool _displayQuadOccluders_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _displayHGOccluders_k__BackingField; // 0x21
		[NonSerialized]
		public Material material; // 0x28
		[NonSerialized]
		public HGOccluder[] occluders; // 0x30
	
		// Properties
		public bool displayQuadOccluders { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public bool displayHGOccluders { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86850-0x0000000184D86860 0x0000000184D86860-0x0000000184D86870
	
		// Constructors
		public HGSOCDataHelper(); // 0x000000018A9AD424-0x000000018A9AD448
	}

	public class EntityRenderAlphaDitherController // TypeDefIndex: 57541
	{
		// Fields
		private IRendererHelper m_owner; // 0x10
		private float m_ditherAlpha; // 0x18
		private static int s_CharDitherFade; // 0x00
		private static int s_DitherTransparentAlpha; // 0x04
		private Dictionary<int, float> m_alphaPerHandles; // 0x20
		private bool m_lastSetAllRendererEnabled; // 0x28
	
		// Constructors
		public EntityRenderAlphaDitherController(IRendererHelper owner); // 0x0000000183699720-0x0000000183699790
		static EntityRenderAlphaDitherController(); // 0x0000000184D5E130-0x0000000184D5E180
	
		// Methods
		public void ResetDitherAlpha(); // 0x000000018369BA90-0x000000018369BAE0
		public bool SetDitherAlpha(float alpha, int handle); // 0x000000018302E760-0x000000018302E850
		public float GetDitherAlpha(); // 0x000000018302EB90-0x000000018302EBF0
		public void Reset(); // 0x0000000183699CD0-0x0000000183699D10
		private bool _ApplyNewAlpha(); // 0x000000018302E370-0x000000018302E480
		private float _GetCurMinAlpha(); // 0x000000018302E480-0x000000018302E760
		public Dictionary<int, float> GetAlphaDictionary(); // 0x0000000183B970B0-0x0000000183B970E0
		private void _SetMaterialDitherAlpha(float value); // 0x0000000183F2FF40-0x0000000183F30030
		private bool _SetMaterialDitherEnabled(bool enabled); // 0x0000000183F2F9D0-0x0000000183F2FA80
	}

	public class EntityRenderCapturedEntity // TypeDefIndex: 57542
	{
		// Fields
		public GameObject rootGameObject; // 0x10
		public List<MeshRenderer> meshRenderers; // 0x18
		public List<MeshRenderer> capturedRenderers; // 0x20
	
		// Constructors
		public EntityRenderCapturedEntity(); // 0x000000018A9ACCC8-0x000000018A9ACD48
	}

	public class EntityRenderCaptureMeshController // TypeDefIndex: 57545
	{
		// Fields
		private IRendererHelper m_owner; // 0x10
		private GameObject m_gameObject; // 0x18
		private LODGroup m_lodGroup; // 0x20
		private List<EntityRenderCapturedEntity> m_capturedEntities; // 0x28
		private int m_meshRendererToSyncFrame; // 0x30
		private List<MeshRendererToSync> m_meshRendererToSync; // 0x38
		private Dictionary<Renderer, EntityVFXRendererMask> m_rendererTypeMasks; // 0x40
	
		// Nested types
		private struct MeshRendererToSync // TypeDefIndex: 57543
		{
			// Fields
			public Transform captureTransform; // 0x00
			public Renderer captureRenderer; // 0x08
			public Transform followTransform; // 0x10
			public Renderer followRenderer; // 0x18
		}
	
		private class CaptureRenderGameObject // TypeDefIndex: 57544
		{
			// Fields
			public GameObject gameObject; // 0x10
			public MeshRenderer meshRenderer; // 0x18
			public MeshFilter meshFilter; // 0x20
	
			// Constructors
			public CaptureRenderGameObject(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public EntityRenderCaptureMeshController(IRendererHelper owner, GameObject gameObject); // 0x0000000183699570-0x0000000183699650
	
		// Methods
		public void Reset(); // 0x0000000183699D50-0x0000000183699DB0
		public void LateTick(); // 0x00000001840FB920-0x00000001840FB960
		public void InitRendererTypeMasks(Dictionary<Renderer, EntityVFXRendererMask> masks); // 0x000000018A9AC9B4-0x000000018A9ACA18
		public EntityRenderCapturedEntity Capture(GameObject root, EntityVFXRendererMask rendererMask); // 0x000000018A9ABAB0-0x000000018A9AC9B4
		private bool _PassRendererMaskFilter(Renderer renderer, EntityVFXRendererMask rendererMask); // 0x000000018A9A76BC-0x000000018A9A7704
		private void _SyncTransformInRenderPipeline(); // 0x00000001840FB960-0x00000001840FBC40
		public void Release(EntityRenderCapturedEntity mesh); // 0x000000018A9ACA18-0x000000018A9ACCC8
	}

	public class EntityRendererTypeConfig // TypeDefIndex: 57546
	{
		// Fields
		public bool useRegex; // 0x10
		public string regexString; // 0x18
		public Regex regex; // 0x20
		public EntityVFXRendererType type; // 0x28
	
		// Constructors
		public EntityRendererTypeConfig(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class EntityRenderHelperMaterialController // TypeDefIndex: 57554
	{
		// Fields
		private static List<Material> s_cachedMaterialList; // 0x00
		private List<RendererInfo> m_rendererInfos; // 0x10
		private AddedMaterialController m_addedMaterialController; // 0x18
		private MeshMaterialController m_meshMaterialController; // 0x20
		private Dictionary<EntityVFXRendererMask, List<RendererInfo>> m_renderInfoIndexPerMask; // 0x28
		private CustomPerDrawDataController m_customPerDrawDataController; // 0x30
		private bool m_calculateBoundsWithTransform; // 0x38
		private static ObjectPool<RendererInfo> s_rendererInfoPool; // 0x08
		private static ObjectPool<List<RendererInfo>> s_rendererInfoListPool; // 0x10
		private static int s_ZTestGBuffer; // 0x18
		private static int s_OutlineZTest; // 0x1C
		private static string s_AlphaBlendOnKeyword; // 0x20
	
		// Nested types
		public class RendererInfo // TypeDefIndex: 57547
		{
			// Fields
			private Renderer m_renderer; // 0x10
			private string m_rendererName; // 0x18
			public EntityVFXRendererMask typeMask; // 0x20
			public int subMeshCount; // 0x24
			public ShadowCastingMode oriShadowCastingMode; // 0x28
			public RayTracingMode oriRayTracingMode; // 0x2C
			public Material[] sourceMaterials; // 0x30
			public bool materialReplacing; // 0x38
			public Material[] replacingMaterials; // 0x40
			public Vector4 customPerDrawData0; // 0x48
	
			// Properties
			public Material[] currentMeshMaterials { get; } // 0x000000018302F140-0x000000018302F1B0 
			private bool rendererValid { get; } // 0x0000000182E61B10-0x0000000182E61C50 
			public string rendererName { get; } // 0x0000000182E61800-0x0000000182E619D0 
	
			// Constructors
			public RendererInfo(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool IsRendererValid(); // 0x0000000182E5E700-0x0000000182E5E7E0
			public bool TryBeginMaterialUpdate(); // 0x0000000182E5E910-0x0000000182E5E9F0
			public bool TryInit(Renderer renderer, List<EntityRendererTypeConfig> configs); // 0x0000000182E5F1C0-0x0000000182E5F360
			private void _Init(Renderer renderer, List<EntityRendererTypeConfig> configs); // 0x0000000182E60FB0-0x0000000182E61800
			public bool TryStopShadowCasting(bool stopRayTracing); // 0x0000000182E60840-0x0000000182E609F0
			public bool TryRevertShadowCastingMode(); // 0x0000000182E5F7F0-0x0000000182E5F980
			public bool TryFillRendererTypeMask(Dictionary<Renderer, EntityVFXRendererMask> target); // 0x0000000182E5EB90-0x0000000182E5ECC0
			public bool TrySetManualDitherAlphaValue(float value); // 0x0000000182E5FE60-0x0000000182E5FFE0
			public bool TrySetManualDitherEnable(bool enable, ref bool allRendererEnabled); // 0x0000000182E5FFE0-0x0000000182E60260
			public bool TrySetSharedMaterial(Material material); // 0x0000000182E60260-0x0000000182E603D0
			public bool TrySetSharedMaterials(Material[] materials); // 0x0000000182E603D0-0x0000000182E60540
			public bool TryReplaceSharedMaterials(Material[] newMaterials); // 0x0000000182E5F360-0x0000000182E5F6D0
			public bool TryGetRendererPosition(out Vector3 position); // 0x0000000182E5EE60-0x0000000182E5F050
			public bool TryGetRendererBounds(out Bounds bounds); // 0x0000000182E5ECC0-0x0000000182E5EE60
			public bool TryEncapsulateBounds(ref Bounds bounds); // 0x0000000182E5E9F0-0x0000000182E5EB90
			public bool TrySetCharacterPerDrawData(Vector4 value); // 0x0000000182E5F980-0x0000000182E5FBF0
			public bool TrySetEmissiveColor(Vector4 value); // 0x0000000182E5FBF0-0x0000000182E5FE60
			private static int _GetSubMeshCount(Renderer renderer); // 0x0000000182E609F0-0x0000000182E60D40
		}
	
		public struct AddedMaterialInfo // TypeDefIndex: 57548
		{
			// Fields
			public int handle; // 0x00
			public Material material; // 0x08
			public EntityVFXRendererMask mask; // 0x10
			public AddMaterialConfig config; // 0x18
			public Dictionary<Material, Material> customizeMaterialDict; // 0x28
		}
	
		public struct SourceMaterialCustomizeData // TypeDefIndex: 57549
		{
			// Fields
			public Texture colorTexture; // 0x00
		}
	
		public class AddedMaterialController // TypeDefIndex: 57550
		{
			// Fields
			public const int MAX_ACTIVE_ADDED_MATERIAL = 4; // Metadata: 0x0234B294
			public List<AddedMaterialInfo> addedMaterialInfos; // 0x10
			private Dictionary<int, float> m_addictiveFloatProperties; // 0x18
			private Dictionary<int, Vector4> m_addictiveVectorProperties; // 0x20
			private Dictionary<int, Texture> m_addictiveTextureProperties; // 0x28
			private bool m_useCustomizeRendererProperty; // 0x30
			private EntityCustomizeRendererPropertyConfig m_customizeRendererPropertyConfig; // 0x38
			private bool m_initedCustomizeRendererPropertyConfig; // 0x40
			private Dictionary<Material, SourceMaterialCustomizeData> m_sourceMaterialCustomizeDatas; // 0x48
			private List<RendererInfo> m_rendererInfos; // 0x50
			private static int s_handleCount; // 0x00
	
			// Constructors
			public AddedMaterialController(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Init(List<RendererInfo> rendererInfos, EntityCustomizeRendererPropertyConfig customizeRendererPropertyConfig); // 0x00000001846B5900-0x00000001846B5970
			private void _InitCustomizeRendererProperty(); // 0x000000018A9B1F7C-0x000000018A9B2218
			public void Reset(); // 0x00000001846E8E80-0x00000001846E8EC0
			public int RequireAddMaterial(Material material, EntityVFXRendererMask mask, AddMaterialConfig config = default); // 0x0000000183578AF0-0x0000000183578C80
			public EntityVFXRendererMask RequireRemoveMaterial(int handle); // 0x0000000183577020-0x00000001835773C0
			private Material _GetCustomizePropertyMaterial(AddedMaterialInfo addedMaterialInfo, Material material); // 0x000000018A9B1DF8-0x000000018A9B1F7C
			public void ApplySharedMaterialArray(RendererInfo rendererInfo); // 0x000000018302EBF0-0x000000018302F140
			public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result); // 0x000000018A9B16B0-0x000000018A9B1994
			public void SetAddictiveFloatProperty(int propertyId, float value); // 0x000000018A9B1B98-0x000000018A9B1C5C
			public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x0234B290 */); // 0x000000018A9B1994-0x000000018A9B1A30
			public void SetAddictiveVectorProperty(int propertyId, Vector4 value); // 0x000000018A9B1D20-0x000000018A9B1DF8
			public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default); // 0x000000018A9B1ACC-0x000000018A9B1B98
			public void SetAddictiveTextureProperty(int propertyId, Texture value); // 0x000000018A9B1C5C-0x000000018A9B1D20
			public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null); // 0x000000018A9B1A30-0x000000018A9B1ACC
		}
	
		public class CustomPerDrawDataController // TypeDefIndex: 57551
		{
			// Fields
			private List<RendererInfo> m_rendererInfos; // 0x10
			private float m_characterEnvironmentEffectPackedValue; // 0x18
	
			// Constructors
			public CustomPerDrawDataController(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			private float _PackUNorm8ToFloat(float packed, float value, int bitShift); // 0x0000000183522FF0-0x0000000183523090
			public void Init(List<RendererInfo> allRendererInfos); // 0x0000000184825740-0x0000000184825790
			public void Reset(); // 0x000000018415F9E0-0x000000018415FC30
			public void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask); // 0x000000018323AF90-0x000000018323B370
			public void SetVectorToCustomPerDraw(EntityRenderHelperVectorCustomPerDrawType type, Vector4 value, EntityVFXRendererMask rendererMask); // 0x000000018A9B2B98-0x000000018A9B2D2C
		}
	
		public class MeshMaterialGroupData // TypeDefIndex: 57552
		{
			// Fields
			public EntityVFXRendererMask mask; // 0x10
			public List<RendererInfo> rendererInfos; // 0x18
			public Dictionary<int, float> floatProperties; // 0x20
			public Dictionary<int, Vector4> vectorProperties; // 0x28
			public Dictionary<int, Texture> textureProperties; // 0x30
			public Dictionary<string, bool> keywordStates; // 0x38
			public bool depthOnlyPassControlling; // 0x40
			public Dictionary<Material, Material> src2dstMaterialDict; // 0x48
	
			// Constructors
			public MeshMaterialGroupData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void CopyFrom(MeshMaterialGroupData src); // 0x0000000184770870-0x0000000184770A20
			public void Clear(); // 0x000000018369B780-0x000000018369B810
		}
	
		public class MeshMaterialController // TypeDefIndex: 57553
		{
			// Fields
			private List<MeshMaterialGroupData> m_meshMaterialDatas; // 0x10
			private static List<MeshMaterialGroupData> s_cacheMeshMaterialDatas; // 0x00
			private static readonly string VFX_MATERIAL_POSTFIX; // 0x08
	
			// Constructors
			public MeshMaterialController(); // 0x00000001841E1670-0x00000001841E1680
			static MeshMaterialController(); // 0x0000000184D27FD0-0x0000000184D28060
	
			// Methods
			public void Init(List<RendererInfo> allRendererInfos); // 0x0000000183699A70-0x0000000183699B60
			public void Reset(); // 0x000000018369AED0-0x000000018369B2A0
			public void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask); // 0x00000001835758F0-0x00000001835760D0
			public void SetDepthOnlyPassEnableToAllMaterial(bool enable, EntityVFXRendererMask rendererMask); // 0x000000018A9B70F4-0x000000018A9B79D4
			public void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask); // 0x00000001834DFDA0-0x00000001834E0330
			public void ReleaseFloatToAllMaterial(int nameId, EntityVFXRendererMask rendererMask); // 0x000000018A9B6C5C-0x000000018A9B6DE4
			public void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask); // 0x000000018357B570-0x000000018357BB90
			public void ReleaseVectorToAllMaterial(int nameId, EntityVFXRendererMask rendererMask); // 0x000000018A9B6F6C-0x000000018A9B70F4
			public void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask); // 0x00000001839411C0-0x00000001839416D0
			public void ReleaseTextureToAllMaterial(int nameId, EntityVFXRendererMask rendererMask); // 0x000000018A9B6DE4-0x000000018A9B6F6C
			private void _CreateReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData); // 0x0000000183574C40-0x00000001835751C0
			private bool _TryEnsureReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData); // 0x0000000182E5E5A0-0x0000000182E5E700
			private void _CopyReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData); // 0x0000000184656720-0x0000000184656940
			private void _ReleaseAllReplaceMaterial(MeshMaterialGroupData groupData); // 0x000000018369B370-0x000000018369B780
			private void _ReplaceSharedMaterial(RendererInfo rendererInfo, Material[] newMaterials); // 0x00000001835751C0-0x00000001835752F0
			private void _GetAffectGroupData(EntityVFXRendererMask rendererMask, List<MeshMaterialGroupData> result); // 0x000000018369B2A0-0x000000018369B370
			private void _SplitRenderers(int oldStateIndex, EntityVFXRendererMask newMask); // 0x00000001832C5570-0x00000001832C56C0
			public void SetZTestInMaterial(string shaderName, bool enable); // 0x000000018A9B79D4-0x000000018A9B7D48
		}
	
		// Constructors
		public EntityRenderHelperMaterialController(); // 0x0000000184D919E0-0x0000000184D919F0
		static EntityRenderHelperMaterialController(); // 0x0000000184A3A560-0x0000000184A3A700
	
		// Methods
		public void Init(List<Renderer> allRenderers, List<EntityRendererTypeConfig> configs, EntityCustomizeRendererPropertyConfig customRendererPropertyConfig, bool calculateBoundsWithTransform = true /* Metadata: 0x0234B28B */); // 0x000000018302D300-0x000000018302DC00
		public void OnRelease(); // 0x00000001831DB150-0x00000001831DB330
		public void Reset(); // 0x0000000183699DB0-0x0000000183699F00
		public bool IsAllRendererValid(); // 0x000000018369ABF0-0x000000018369AED0
		public void StopShadowCasting(bool stopRayTracing); // 0x00000001832C5D00-0x00000001832C5FF0
		public virtual void RevertShadowCastingMode(); // 0x00000001832C5FF0-0x00000001832C62B0
		public int AddMaterialToAllRenderer(Material material, EntityVFXRendererMask rendererMask, AddMaterialConfig config = default); // 0x0000000183578690-0x0000000183578850
		public void SetAddictiveFloatProperty(int propertyId, float value); // 0x000000018A9AD0AC-0x000000018A9AD12C
		public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x0234B28C */); // 0x000000018A9ACEEC-0x000000018A9ACF6C
		public void SetAddictiveVectorProperty(int propertyId, Vector4 value); // 0x000000018A9AD1AC-0x000000018A9AD240
		public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default); // 0x000000018A9ACFEC-0x000000018A9AD0AC
		public void SetAddictiveTextureProperty(int propertyId, Texture value); // 0x000000018A9AD12C-0x000000018A9AD1AC
		public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null); // 0x000000018A9ACF6C-0x000000018A9ACFEC
		public void RemoveMaterialFromAllRenderer(int handle); // 0x00000001835773C0-0x0000000183577520
		public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result); // 0x000000018A9ACE68-0x000000018A9ACEEC
		public void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask); // 0x0000000184502C00-0x0000000184502C80
		public void SetDepthOnlyPassEnableToAllMaterial(bool enable, EntityVFXRendererMask rendererMask); // 0x000000018A9AD240-0x000000018A9AD2C0
		public void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask); // 0x000000018357A6A0-0x000000018357A790
		public void SetVectorToCustomPerDraw(EntityRenderHelperVectorCustomPerDrawType type, Vector4 value, EntityVFXRendererMask rendererMask); // 0x000000018A9AD2C0-0x000000018A9AD3A4
		public void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask); // 0x000000018357A800-0x000000018357A870
		public void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask); // 0x000000018357B4F0-0x000000018357B570
		public void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask); // 0x0000000183941150-0x00000001839411C0
		public void FillRendererTypeMasks(Dictionary<Renderer, EntityVFXRendererMask> target); // 0x000000018A9ACD48-0x000000018A9ACE68
		private List<RendererInfo> _GetRenderersOfRendererMask(EntityVFXRendererMask rendererMask, bool affectAll); // 0x0000000183578850-0x0000000183578AF0
		public void SetManualDitherAlphaValue(float value); // 0x0000000183103EB0-0x0000000183104230
		public bool SetManualDitherEnable(bool enable); // 0x0000000183104230-0x0000000183104440
		public Bounds GetRendererBounds(); // 0x00000001832C56C0-0x00000001832C5D00
		public void SetZTestInMaterial(string shaderName, bool enable); // 0x000000018A9AD3A4-0x000000018A9AD424
		public RenderHelperType GetRenderHelperType(); // 0x000000018411B870-0x000000018411BD90
	}

	public enum EntityRenderHelperCustomPerDrawType // TypeDefIndex: 57555
	{
		WetEffectWorldSpaceHeight = 1,
		CharacterDissolveScheduleOffset = 3,
		RainEffectIntensity = 8,
		WetEffectIntensity = 16,
		WetEffectGlobalIntensity = 24,
		SnowEffectIntensity = 32
	}

	public enum EntityRenderHelperVectorCustomPerDrawType // TypeDefIndex: 57556
	{
		Emissive = 1
	}

	public class EntityRenderHelperVisibleController // TypeDefIndex: 57558
	{
		// Fields
		private List<RendererInfo> m_rendererInfos; // 0x10
		private Dictionary<Renderer, RendererInfo> m_dictionary; // 0x18
		private static ObjectPool<List<RendererInfo>> s_rendererInfoListPool; // 0x00
		private static ObjectPool<Dictionary<Renderer, RendererInfo>> s_rendererInfoDictPool; // 0x08
	
		// Nested types
		public class RendererInfo // TypeDefIndex: 57557
		{
			// Fields
			private Renderer m_renderer; // 0x10
			[CompilerGenerated]
			private string _rendererName_k__BackingField; // 0x18
			public bool oriVisible; // 0x20
			public bool curVisible; // 0x21
	
			// Properties
			public string rendererName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000182E61C50-0x0000000182E61CB0
			private bool rendererValid { get; } // 0x0000000182E619D0-0x0000000182E61B10 
	
			// Constructors
			public RendererInfo(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool TryInit(Renderer renderer); // 0x0000000182E5F050-0x0000000182E5F1C0
			private void _Init(Renderer renderer); // 0x0000000182E60D40-0x0000000182E60FB0
			public bool TryAddToDictionary(Dictionary<Renderer, RendererInfo> dictionary); // 0x0000000182E5E7E0-0x0000000182E5E910
			public bool TrySetVisible(bool visible); // 0x0000000182E606B0-0x0000000182E60840
			public bool TrySetVisibleByRenderer(bool visible); // 0x0000000182E60540-0x0000000182E606B0
			public bool TryResetVisible(); // 0x0000000182E5F6D0-0x0000000182E5F7F0
		}
	
		// Constructors
		public EntityRenderHelperVisibleController(); // 0x00000001841E1670-0x00000001841E1680
		static EntityRenderHelperVisibleController(); // 0x0000000184CB0FC0-0x0000000184CB10B0
	
		// Methods
		public void Init(List<Renderer> allRenderers); // 0x000000018302B800-0x000000018302BB70
		private void _InitDictionary(); // 0x000000018A9B2EE4-0x000000018A9B3098
		private bool _TryGetRendererInfo(Renderer renderer, bool initDictionary, out RendererInfo rendererInfo); // 0x0000000182E5E3A0-0x0000000182E5E5A0
		public void Release(); // 0x00000001831DB0B0-0x00000001831DB150
		public void SetVisibleByNameContainsStr(string name, bool visible); // 0x000000018385AEA0-0x000000018385B100
		public void SetVisibleByRenderer(Renderer renderer, bool visible); // 0x000000018A9B2E44-0x000000018A9B2EE4
		public void ResetVisibleByNameContainsStr(string name); // 0x000000018385AC60-0x000000018385AEA0
		public void ResetVisibleByRenderer(Renderer renderer); // 0x000000018A9B2DB8-0x000000018A9B2E44
		public void Reset(); // 0x0000000183699F00-0x000000018369A190
	}

	public class EntityRenderMaterialManager // TypeDefIndex: 57559
	{
		// Fields
		private Dictionary<int, float> m_floatProperties; // 0x10
		private Dictionary<int, Texture> m_textureProperties; // 0x18
		private Dictionary<int, Vector4> m_vectorProperties; // 0x20
		private HashSet<string> m_EnabledKeyWords; // 0x28
		private HashSet<string> m_DisabledKeyWords; // 0x30
		private bool m_shaderPassEnabled; // 0x38
		private Dictionary<Material, bool> m_oriMaterialShaderPassEnabled; // 0x40
		private static int s_ZTestGBuffer; // 0x00
		private List<Material> m_materials; // 0x48
	
		// Constructors
		public EntityRenderMaterialManager(); // 0x000000018A9B4294-0x000000018A9B4418
		static EntityRenderMaterialManager(); // 0x000000018A9B426C-0x000000018A9B4294
	
		// Methods
		public void SetFloat(int nameID, float value); // 0x000000018A9B3AE8-0x000000018A9B3BAC
		public void SetTexture(int nameID, Texture value); // 0x000000018A9B3D6C-0x000000018A9B3E30
		public void SetVector(int nameID, Vector4 value); // 0x000000018A9B3E30-0x000000018A9B3F14
		public void AddMaterial(Material material); // 0x000000018A9B3098-0x000000018A9B35FC
		public void RemoveMaterial(Material material); // 0x000000018A9B3754-0x000000018A9B37D0
		public void ClearMaterials(); // 0x000000018A9B35FC-0x000000018A9B3754
		public void SetKeywordEnable(string keyword, bool enable); // 0x000000018A9B3BAC-0x000000018A9B3D6C
		public void SetDepthOnlyEnabled(bool enable); // 0x000000018A9B37D0-0x000000018A9B3AE8
		public void SetZTestInMaterial(string shaderName, bool enable); // 0x000000018A9B3F14-0x000000018A9B4060
		private void _RevertMaterial(Material material); // 0x000000018A9B4060-0x000000018A9B426C
	}

	[Serializable]
	public class EntityVFXCurve // TypeDefIndex: 57560
	{
		// Fields
		public AnimationCurve curve; // 0x10
		public Vector2 rangeEdit; // 0x18
		public Vector2 rangeLimit; // 0x20
	
		// Constructors
		public EntityVFXCurve(AnimationCurve curve); // 0x00000001853908C0-0x00000001853908D0
	}

	public struct EntityVFXCurveEvaluateResult // TypeDefIndex: 57561
	{
		// Fields
		public ShaderPropertyType propertyType; // 0x00
		public string propertyName; // 0x08
		public int propertyId; // 0x10
		public float floatValue; // 0x14
		public Vector4 vectorValue; // 0x18
		public Vector4 textureScaleOffset; // 0x28
	}

	public struct AddMaterialConfig // TypeDefIndex: 57562
	{
		// Fields
		public bool useColorTexture; // 0x00
		public string colorTextureName; // 0x08
	
		// Properties
		public bool useCustomizeProperty { get; } // 0x0000000183578C80-0x0000000183578CB0 
	}

	[Serializable]
	public class EntityVFXCurveData // TypeDefIndex: 57563
	{
		// Fields
		public string propertyName; // 0x10
		public ShaderPropertyType propertyType; // 0x18
		public EntityVFXCurve curve; // 0x20
		public EntityVFXCurve curveX; // 0x28
		public EntityVFXCurve curveY; // 0x30
		public EntityVFXCurve curveZ; // 0x38
		public EntityVFXCurve curveW; // 0x40
		public Gradient gradient; // 0x48
		[Range(1f, 100f)]
		public float colorIntensity; // 0x50
	
		// Constructors
		public EntityVFXCurveData(); // 0x0000000184CAE4C0-0x0000000184CAE4D0
	}

	[Serializable]
	public class EntityVFXAddictiveMaterialData // TypeDefIndex: 57564
	{
		// Fields
		public EntityVFXPriorityType priorityType; // 0x10
		public EntityVFXRendererMask rendererMask; // 0x14
		public bool useScaledTime; // 0x18
		public bool enableVertColorIfMeshHasVFXVertColor; // 0x19
		public Material material; // 0x20
		public bool loop; // 0x28
		public bool useDissolveCurve; // 0x29
		public bool useScanCurve; // 0x2A
		public bool useCutoffPosY; // 0x2B
		public bool useCutoffPosYAutoBounds; // 0x2C
		public float cutoffPosYAbsoluteBounds; // 0x30
		public bool useCutoffLocalDirection; // 0x34
		public Vector3 cutoffDirection; // 0x38
		public float duration; // 0x44
		public bool useStartCurve; // 0x48
		public AnimationCurve opacityCurve; // 0x50
		public AnimationCurve dissolveCurve; // 0x58
		public AnimationCurve scanCurve; // 0x60
		public AnimationCurve cutoffPosYCurve; // 0x68
		public List<EntityVFXCurveData> customCurves; // 0x70
		public bool useLoopCurve; // 0x78
		[Min(0.001f)]
		public float loopDuration; // 0x7C
		public AnimationCurve loopCurve; // 0x80
		public AnimationCurve dissolveLoopCurve; // 0x88
		public List<EntityVFXCurveData> customLoopCurves; // 0x90
		public bool useEndCurve; // 0x98
		[Min(0.001f)]
		public float endDuration; // 0x9C
		public AnimationCurve endCurve; // 0xA0
		public AnimationCurve dissolveEndCurve; // 0xA8
		public List<EntityVFXCurveData> customEndCurves; // 0xB0
		public bool useAddictiveProperties; // 0xB8
		public bool useAddictivePropertiesUpdate; // 0xB9
		public List<string> addictiveVectorProperties; // 0xC0
		public bool useColorTexture; // 0xC8
		public string colorTextureName; // 0xD0
	
		// Constructors
		public EntityVFXAddictiveMaterialData(); // 0x00000001845DF500-0x00000001845DF550
	}

	public class EntityVFXAddictiveMaterialAsset : EntityVFXAssetBase // TypeDefIndex: 57565
	{
		// Fields
		public EntityVFXAddictiveMaterialData data; // 0x30
	
		// Constructors
		public EntityVFXAddictiveMaterialAsset(); // 0x00000001846EA7B0-0x00000001846EA7C0
	}

	[Serializable]
	public class EntityVFXAfterImageData // TypeDefIndex: 57567
	{
		// Fields
		public EntityVFXRendererMask rendererMask; // 0x10
		public bool useScaledTime; // 0x14
		public TimeMode timeMode; // 0x18
		public bool loop; // 0x1C
		public float duration; // 0x20
		[Min(0.1f)]
		public float timeInterval; // 0x24
		public List<float> timeBurst; // 0x28
		public Material depthOnlyMaterial; // 0x30
		public Material material; // 0x38
		public Material materialOutline; // 0x40
		[Min(0.01f)]
		public float lifeTime; // 0x48
		public AnimationCurve opacityCurve; // 0x50
		public AnimationCurve dissolveCurve; // 0x58
		public List<EntityVFXCurveData> customCurves; // 0x60
		public AnimationCurve opacityCurveOutline; // 0x68
		public List<EntityVFXCurveData> customCurvesOutline; // 0x70
	
		// Nested types
		public enum TimeMode // TypeDefIndex: 57566
		{
			Interval = 0,
			Burst = 1
		}
	
		// Constructors
		public EntityVFXAfterImageData(); // 0x0000000184D39C30-0x0000000184D39C50
	}

	public class EntityVFXAfterImageAsset : EntityVFXAssetBase // TypeDefIndex: 57568
	{
		// Fields
		[SerializeField]
		public EntityVFXAfterImageData data; // 0x30
	
		// Constructors
		public EntityVFXAfterImageAsset(); // 0x00000001846EA7B0-0x00000001846EA7C0
	}

	[Serializable]
	public struct EntityCustomizeRendererType // TypeDefIndex: 57569
	{
		// Fields
		public bool useContainStr; // 0x00
		public string rendererNameRegex; // 0x08
		public EntityVFXRendererType type; // 0x10
	}

	public class EntityVFXAsset : ScriptableObject // TypeDefIndex: 57570
	{
		// Fields
		public RenderHelperType renderHelperType; // 0x18
		public bool useCustomRenderer; // 0x1C
		public List<EntityCustomizeRendererType> customRenderers; // 0x20
		public bool meshHasVFXVertColor; // 0x28
		public bool useCustomRendererProperty; // 0x29
		public EntityCustomizeRendererPropertyConfig customRendererPropertyConfig; // 0x30
		private List<EntityRendererTypeConfig> m_rendererTypeConfigs; // 0x38
	
		// Constructors
		public EntityVFXAsset(); // 0x000000018495D100-0x000000018495D160
	
		// Methods
		public List<EntityRendererTypeConfig> GetRendererTypeConfigs(bool forceUpdate); // 0x000000018432BAC0-0x000000018432BCD0
	}

	public enum EntityVFXRendererType // TypeDefIndex: 57571
	{
		Normal = 0,
		Body = 1,
		Cloth = 2,
		Eyebrow = 3,
		EyeShadow = 4,
		Face = 5,
		Hair = 6,
		HairShadow = 7,
		Iris = 8,
		Weapon1 = 9,
		Weapon2 = 10,
		Part1 = 11,
		Part2 = 12,
		Part3 = 13,
		Part4 = 14,
		Part5 = 15,
		Part6 = 16,
		Part7 = 17,
		Part8 = 18,
		Part9 = 19,
		Part10 = 20,
		Part11 = 21,
		Part12 = 22,
		Part13 = 23,
		Part14 = 24,
		Part15 = 25,
		AlphaQuadAvoidAddMaterial = 26,
		Count = 27
	}

	[Flags]
	public enum EntityVFXRendererMask // TypeDefIndex: 57572
	{
		AllWithoutAlphaQuad = -67108865,
		All = -1,
		Normal = 1,
		Body = 2,
		Cloth = 4,
		Eyebrow = 8,
		EyeShadow = 16,
		Face = 32,
		Hair = 64,
		HairShadow = 128,
		Iris = 256,
		Weapon1 = 512,
		Weapon2 = 1024,
		Part1 = 2048,
		Part2 = 4096,
		Part3 = 8192,
		Part4 = 16384,
		Part5 = 32768,
		Part6 = 65536,
		Part7 = 131072,
		Part8 = 262144,
		Part9 = 524288,
		Part10 = 1048576,
		Part11 = 2097152,
		Part12 = 4194304,
		Part13 = 8388608,
		Part14 = 16777216,
		Part15 = 33554432,
		AlphaQuadAvoidAddMaterial = 67108864
	}

	public enum EntityVFXPriorityType // TypeDefIndex: 57573
	{
		Normal = 0,
		UltiSkillTimeline = 1
	}

	[Flags]
	public enum SettingLodLevel // TypeDefIndex: 57574
	{
		None = 0,
		Low = 1,
		Mid = 2,
		High = 4,
		Highest = 8
	}

	[Flags]
	public enum AssetPlatformLayers // TypeDefIndex: 57575
	{
		PC = 1,
		Mobile = 2,
		Other = 4
	}

	[Flags]
	public enum EffectTargetLayers // TypeDefIndex: 57576
	{
		Main = 1,
		Guard = 2
	}

	public class EntityVFXAssetBase : ScriptableObject // TypeDefIndex: 57577
	{
		// Fields
		[SerializeField]
		public bool useECSRenderer; // 0x18
		public SettingLodLevel settingLodLevel; // 0x1C
		public AssetPlatformLayers platformLayer; // 0x20
		public EffectTargetLayers targetLayer; // 0x24
		private string m_assetName; // 0x28
	
		// Properties
		public string assetName { get; } // 0x000000018A9B4418-0x000000018A9B4484 
	
		// Constructors
		public EntityVFXAssetBase(); // 0x0000000185397B78-0x0000000185397B94
	}

	public enum VFXType // TypeDefIndex: 57578
	{
		Addictive = 0,
		Dissolve = 1,
		Max = 2
	}

	public class EntityVFXControllerBase // TypeDefIndex: 57579
	{
		// Fields
		public SettingLodLevel settingLodLevel; // 0x10
		public AssetPlatformLayers platformLayer; // 0x14
		public EffectTargetLayers targetLayer; // 0x18
		protected IRendererHelper m_owner; // 0x20
		protected bool m_isPlaying; // 0x28
		private bool m_isHiding; // 0x29
		protected bool m_isKeyword; // 0x2A
		private string m_vfxName; // 0x30
		private float m_destroyTime; // 0x38
		private float m_lastTickTime; // 0x3C
		public bool preload; // 0x40
		public bool fromTimeline; // 0x41
	
		// Properties
		public bool isPlaying { get; } // 0x000000018402AB10-0x000000018402AB40 
		public virtual bool isStopping { get; } // 0x000000018A9B49B0-0x000000018A9B49FC 
		public bool isHiding { get; } // 0x0000000183099050-0x0000000183099080 
		public bool isKeyword { get; } // 0x0000000183098E80-0x0000000183098EB0 
		public string vfxName { get; } // 0x00000001831DA370-0x00000001831DA3A0 
		public float destroyTime { get; set; } // 0x000000018302E1E0-0x000000018302E240 0x00000001831DA450-0x00000001831DA490
		public float lastTickTime { get; set; } // 0x0000000183577E70-0x0000000183577EA0 0x0000000183577EA0-0x0000000183577F10
	
		// Constructors
		public EntityVFXControllerBase(); // 0x0000000184D8E730-0x0000000184D8E750
	
		// Methods
		public void SetOwner(string name, IRendererHelper owner); // 0x00000001831DA620-0x00000001831DA680
		public void InitLOD(EntityVFXAssetBase vfxAssetBase); // 0x00000001831D9B60-0x00000001831D9BB0
		public void SetName(string name); // 0x00000001831DA3A0-0x00000001831DA3E0
		public bool PoolTick(); // 0x000000018A9B47FC-0x000000018A9B4848
		public void Destroy(); // 0x000000018A9B4484-0x000000018A9B4554
		protected virtual void OnDestroy(); // 0x000000018A9B4684-0x000000018A9B46C8
		public virtual void Play(); // 0x000000018A9B47B8-0x000000018A9B47FC
		public virtual void Stop(bool forceStop); // 0x000000018A9B4908-0x000000018A9B495C
		public virtual void Replay(); // 0x000000018A9B4848-0x000000018A9B488C
		public virtual void Tick(float logicDeltaTime); // 0x000000018A9B495C-0x000000018A9B49B0
		protected void RefreshLastTickTime(); // 0x0000000183577B00-0x0000000183577B40
		protected float GetDeltaTimeFromLastTick(bool useScaledTime); // 0x0000000183577DE0-0x0000000183577E70
		public virtual EntityVFXPriorityType GetPriorityType(); // 0x000000018A9B45EC-0x000000018A9B4638
		public virtual EntityVFXRendererMask GetRendererMask(); // 0x000000018A9B4638-0x000000018A9B4684
		public virtual bool GetAllowSimultaneousKeyword(); // 0x000000018A9B4554-0x000000018A9B45A0
		public virtual bool GetNeedTick(); // 0x000000018A9B45A0-0x000000018A9B45EC
		public void Hide(); // 0x000000018485AEF0-0x000000018485AF30
		protected virtual void OnHide(); // 0x000000018A9B46C8-0x000000018A9B470C
		public void Show(); // 0x00000001849AFA80-0x00000001849AFAC0
		protected virtual void OnShow(); // 0x000000018A9B4774-0x000000018A9B47B8
		public void Sample(float time, bool ending = false /* Metadata: 0x0234B31A */); // 0x000000018A9B488C-0x000000018A9B4908
		protected virtual void OnSample(float time, bool ending); // 0x000000018A9B470C-0x000000018A9B4774
	}

	public abstract class EntityVFXControllerStateBase : EntityVFXControllerBase // TypeDefIndex: 57581
	{
		// Fields
		[CompilerGenerated]
		private float _m_passTime_k__BackingField; // 0x48
		[CompilerGenerated]
		private float _m_loopPassTime_k__BackingField; // 0x4C
		[CompilerGenerated]
		private float _m_endPassTime_k__BackingField; // 0x50
		private State m_curState; // 0x54
	
		// Properties
		protected float m_passTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		protected float m_loopPassTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		protected float m_endPassTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public override bool isStopping { get; } // 0x000000018A9B4C04-0x000000018A9B4C54 
		protected virtual bool useScaledTime { get; } // 0x000000018A9B4D8C-0x000000018A9B4DD8 
		protected virtual bool useStartCurve { get; } // 0x000000018A9B4DD8-0x000000018A9B4E24 
		protected virtual bool useLoopCurve { get; } // 0x000000018A9B4D40-0x000000018A9B4D8C 
		protected virtual bool useEndCurve { get; } // 0x000000018A9B4CF4-0x000000018A9B4D40 
		protected virtual bool loop { get; } // 0x000000018A9B4CA8-0x000000018A9B4CF4 
		protected virtual float duration { get; } // 0x000000018A9B4B64-0x000000018A9B4BB8 
		protected virtual float loopDuration { get; } // 0x000000018A9B4C54-0x000000018A9B4CA8 
		protected virtual float endDuration { get; } // 0x000000018A9B4BB8-0x000000018A9B4C04 
	
		// Nested types
		private enum State // TypeDefIndex: 57580
		{
			End = 0,
			Start = 1,
			Loop = 2,
			Ending = 3
		}
	
		// Constructors
		protected EntityVFXControllerStateBase(); // 0x0000000184D8E730-0x0000000184D8E750
	
		// Methods
		public override void Play(); // 0x000000018455A2A0-0x000000018455A300
		public override void Replay(); // 0x000000018A9B4B00-0x000000018A9B4B64
		public override void Stop(bool forceStop); // 0x00000001845DFBB0-0x00000001845DFC10
		public override bool GetNeedTick(); // 0x000000018402AA60-0x000000018402AAB0
		public override void Tick(float logicDeltaTime); // 0x0000000183577B40-0x0000000183577C10
		protected override void OnSample(float time, bool ending); // 0x000000018A9B49FC-0x000000018A9B4B00
		protected abstract void UpdateStart();
		protected abstract void UpdateLoop();
		protected abstract void UpdateStop();
		private void _FinalStop(); // 0x00000001845DFC10-0x00000001845DFC50
		protected abstract void OnFinalStop();
		public bool __iFixBaseProxy_get_isStopping(); // 0x0000000186C1D558-0x0000000186C1D560
		public void __iFixBaseProxy_Play(); // 0x0000000186C1D538-0x0000000186C1D540
		public void __iFixBaseProxy_Replay(); // 0x0000000186C1D540-0x0000000186C1D548
		public void __iFixBaseProxy_Stop(bool P0); // 0x0000000186C1D548-0x0000000186C1D550
		public bool __iFixBaseProxy_GetNeedTick(); // 0x0000000186C1E0F8-0x0000000186C1E100
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000186C1D550-0x0000000186C1D558
		public void __iFixBaseProxy_OnSample(float P0, bool P1); // 0x0000000186C1D528-0x0000000186C1D530
	}

	public enum EntityCustomizePropertyName // TypeDefIndex: 57582
	{
		None = 0,
		AlphaTex = 1,
		NormalTex = 2
	}

	public enum EntityCustomizeMatchMethod // TypeDefIndex: 57583
	{
		None = 0,
		All = 1,
		RendererName = 2,
		SourceMaterial0 = 3,
		SourceMesh = 4
	}

	[Serializable]
	public class EntityCustomizeRendererPropertyConfig // TypeDefIndex: 57584
	{
		// Fields
		public bool useColorTexture; // 0x10
		public bool useAutoFindColorTexture; // 0x11
		public string autoFindColorTextureName; // 0x18
		public SerializeFieldDictionary<Material, Texture> preConfigColorTextureDict; // 0x20
	
		// Constructors
		public EntityCustomizeRendererPropertyConfig(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public Texture GetColorTexture(Material material); // 0x000000018A9B2D2C-0x000000018A9B2DB8
	}

	public enum EntityVFXKeywordEnum // TypeDefIndex: 57585
	{
		None = 0,
		Dissolve = 1
	}

	[Serializable]
	public class EntityVFXDissolveData // TypeDefIndex: 57587
	{
		// Fields
		public EntityVFXPriorityType priorityType; // 0x10
		public EntityVFXRendererMask rendererMask; // 0x14
		public bool useScaledTime; // 0x18
		public bool allowSimultaneous; // 0x19
		public bool loop; // 0x1A
		public float duration; // 0x1C
		public UVSet uvSet; // 0x20
		public bool useCutoffPosY; // 0x24
		public bool useCutoffPosYAutoBounds; // 0x25
		public float cutoffPosYAbsoluteBounds; // 0x28
		public bool useCutoffLocalDirection; // 0x2C
		public Vector3 cutoffDirection; // 0x30
		[Range(0f, 1f)]
		public float cutoffUseDissolve; // 0x3C
		public bool stopShadowCasting; // 0x40
		public bool stopRayTracingMeanTime; // 0x41
		public float stopShadowCastingDelay; // 0x44
		public float revertShadowCastingDelay; // 0x48
		public Texture2D dissolveTexture; // 0x50
		public Vector4 dissolveTextureTillingOffset; // 0x58
		public float dissolveEdgeSharp; // 0x68
		[ColorUsage(true, true)]
		public UnityEngine.Color dissolveEmissiveColor; // 0x6C
		public float dissolveEmissiveEdge; // 0x7C
		public bool useLocalScreenUV; // 0x80
		public AnimationCurve dissolveValueCurve; // 0x88
		public AnimationCurve cutoffPosYCurve; // 0x90
		public bool useLoopCurve; // 0x98
		public float loopDuration; // 0x9C
		public AnimationCurve dissolveValueLoopCurve; // 0xA0
		public AnimationCurve cutoffPosYLoopCurve; // 0xA8
		public bool useEndCurve; // 0xB0
		[Min(0.001f)]
		public float endDuration; // 0xB4
		public AnimationCurve dissolveValueEndCurve; // 0xB8
		public AnimationCurve cutoffPosYEndCurve; // 0xC0
	
		// Nested types
		public enum UVSet // TypeDefIndex: 57586
		{
			UV = 0,
			UV2 = 1
		}
	
		// Constructors
		public EntityVFXDissolveData(); // 0x00000001847A0220-0x00000001847A0280
	}

	public class EntityVFXDissolveAsset : EntityVFXAssetBase // TypeDefIndex: 57588
	{
		// Fields
		[SerializeField]
		public EntityVFXDissolveData data; // 0x30
	
		// Constructors
		public EntityVFXDissolveAsset(); // 0x00000001846EA7B0-0x00000001846EA7C0
	}

	public class EntityFactoryRendererInfo // TypeDefIndex: 57589
	{
		// Fields
		public int subMeshCount; // 0x10
		public bool enableVAT; // 0x14
		public int vatIndex; // 0x18
		public int initMaterialsCount; // 0x1C
	
		// Constructors
		public EntityFactoryRendererInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class EntityVFXFactoryAddedMaterialManager // TypeDefIndex: 57594
	{
		// Fields
		private static readonly int S_ENABLE_FACTORY_VAT; // 0x00
		private static readonly int S_FACTORY_VAT_MAP; // 0x04
		private static readonly int S_FACTORY_VAT_MAP_PARAMS; // 0x08
		private List<EntityFactoryRendererInfo> m_factoryRendererInfos; // 0x10
		private List<VATData> m_vatDatas; // 0x18
		private List<AddedMaterialData> m_addedMaterialDatas; // 0x20
		private Dictionary<Material, AddedMaterialData> m_addedMaterialDataDict; // 0x28
	
		// Nested types
		public class VATData // TypeDefIndex: 57590
		{
			// Fields
			public Texture factoryVATMap; // 0x10
			public Vector4 factoryVATMapParams; // 0x18
	
			// Constructors
			public VATData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class AddedMaterialData // TypeDefIndex: 57591
		{
			// Fields
			public Material srcMaterial; // 0x10
			public Material[] materialInstancesOfEachVAT; // 0x18
			public Dictionary<int, float> savedFloatProperties; // 0x20
			public Dictionary<int, Vector4> savedVectorProperties; // 0x28
	
			// Constructors
			public AddedMaterialData(); // 0x000000018A9B2218-0x000000018A9B2298
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 57592
		{
			// Fields
			public Material src; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool __GetAddedMaterialIndex_b__0(AddedMaterialData data); // 0x0000000186C8C288-0x0000000186C8C2DC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 57593
		{
			// Fields
			public Material src; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool __RemoveVATMaterial_b__0(AddedMaterialData data); // 0x0000000186C8C288-0x0000000186C8C2DC
		}
	
		// Constructors
		public EntityVFXFactoryAddedMaterialManager(); // 0x000000018A9B58C8-0x000000018A9B59B0
		static EntityVFXFactoryAddedMaterialManager(); // 0x000000018A9B5860-0x000000018A9B58C8
	
		// Methods
		public void Init(List<EntityFactoryRendererInfo> factoryRendererInfos); // 0x000000018A9B4EA8-0x000000018A9B4FBC
		private void _AddVATMaterial(Material src); // 0x000000018A9B52F8-0x000000018A9B55C0
		private Material _GetVATMaterial(EntityFactoryRendererInfo rendererInfo, Material src); // 0x000000018A9B56A4-0x000000018A9B5758
		private int _GetAddedMaterialIndex(EntityFactoryRendererInfo rendererInfo, Material src); // 0x000000018A9B55C0-0x000000018A9B56A4
		private void _RemoveVATMaterial(Material src); // 0x000000018A9B5758-0x000000018A9B5860
		public void AddMaterialToAllRenderer(Material material); // 0x000000018A9B4E24-0x000000018A9B4EA8
		public void RemoveMaterialFromAllRenderer(Material material); // 0x000000018A9B4FBC-0x000000018A9B50EC
		public void SetFloatToFactoryMaterial(Material material, int nameId, float value); // 0x000000018A9B50EC-0x000000018A9B51E0
		public void SetVectorToFactoryMaterial(Material material, int nameId, Vector4 value); // 0x000000018A9B51E0-0x000000018A9B52F8
	}

	public static class EntityVFXFactoryMaterialCache // TypeDefIndex: 57596
	{
		// Fields
		private static readonly int S_FACTORY_VAT_MAP; // 0x00
		private static readonly int S_FACTORY_VAT_MAP_PARAMS; // 0x04
		private static Dictionary<int, Dictionary<int, VATMaterialData>> s_cachedMaterials; // 0x08
	
		// Nested types
		public class VATMaterialData // TypeDefIndex: 57595
		{
			// Fields
			public int refCount; // 0x10
			public Material vatMaterial; // 0x18
	
			// Constructors
			public VATMaterialData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		static EntityVFXFactoryMaterialCache(); // 0x000000018A9B5DE4-0x000000018A9B5E80
	
		// Methods
		public static Material GetVATMaterial(Material srcMaterial, Texture factoryVATMap, Vector4 factoryVATMapParams); // 0x000000018A9B59B0-0x000000018A9B5C2C
		public static void ReleaseVATMaterial(Material srcMaterial, Texture factoryVATMap); // 0x000000018A9B5C2C-0x000000018A9B5DE4
	}

	[Serializable]
	public class EntityVFXSetParamsData // TypeDefIndex: 57598
	{
		// Fields
		public EntityVFXPriorityType priorityType; // 0x10
		public EntityVFXRendererMask rendererMask; // 0x14
		public bool useScaledTime; // 0x18
		public bool loop; // 0x19
		public Type type; // 0x1C
		public float duration; // 0x20
		public List<EntityVFXCurveData> customCurves; // 0x28
		public bool useLoopCurve; // 0x30
		public float loopDuration; // 0x34
		public List<EntityVFXCurveData> customLoopCurves; // 0x38
		[Min(0.001f)]
		public float endDuration; // 0x40
		public List<EntityVFXCurveData> customEndCurves; // 0x48
	
		// Nested types
		public enum Type // TypeDefIndex: 57597
		{
			Character = 0,
			VFX = 1,
			Lit = 2
		}
	
		// Constructors
		public EntityVFXSetParamsData(); // 0x0000000184DA6BF0-0x0000000184DA6C10
	}

	public class EntityVFXSetParamsAsset : EntityVFXAssetBase // TypeDefIndex: 57599
	{
		// Fields
		[SerializeField]
		public EntityVFXSetParamsData data; // 0x30
	
		// Constructors
		public EntityVFXSetParamsAsset(); // 0x00000001846EA7B0-0x00000001846EA7C0
	}

	public static class EntityVFXUtils // TypeDefIndex: 57600
	{
		// Methods
		public static void CalculateCutOffBounds(IRendererHelper owner, bool useCutoffLocalDirection, Vector3 cutoffDirectionData, bool useCutoffPosYAutoBounds, float cutoffPosYAbsoluteBounds, out float cutoffMin, out float cutoffMax, out Vector3 cutoffDirection); // 0x00000001832C5080-0x00000001832C5290
		public static ValueTuple<float, float> GetBoundsMinMaxOfDirection(Bounds bounds, Vector3 direction); // 0x00000001832C4EA0-0x00000001832C5080
		public static void ApplyEntityVFXCurves(Material material, List<EntityVFXCurveData> curveDataList, float schedule); // 0x0000000183578D40-0x0000000183579450
		public static EntityVFXCurveEvaluateResult Evaluate(EntityVFXCurveData curveData, float schedule); // 0x0000000183579520-0x0000000183579660
		private static void _UpdateCurve(Material material, EntityVFXCurveData curveData, float schedule); // 0x0000000183579450-0x0000000183579520
		public static bool IsCharacterShader(string name); // 0x000000018A9B5E80-0x000000018A9B5EFC
		public static bool IsLitShader(string name); // 0x000000018A9A7704-0x000000018A9A8334
	
		// Extension methods
		public static EntityVFXRendererMask ToMask(this EntityVFXRendererType type); // 0x000000018302DC00-0x000000018302E1E0
	}

	public interface ICaptureMesh // TypeDefIndex: 57601
	{
		// Methods
		EntityRenderCapturedEntity Capture(GameObject placeRoot, EntityVFXRendererMask rendererMask);
		void Release(EntityRenderCapturedEntity mesh);
	}

	public interface IEntityVFXTimelineHost // TypeDefIndex: 57602
	{
		// Properties
		GameObject gameObject { get; }
		bool inited { get; }
	
		// Methods
		void InitAll();
		void ResetAll();
		void SampleVFX(string assetName, bool playing, float time, bool ending);
		void AddTimelineEffect(EntityVFXAssetBase asset);
	}

	public enum RenderHelperType // TypeDefIndex: 57603
	{
		Unknown = 0,
		Character = 1,
		Lit = 2,
		Mix = 4
	}

	public interface IRendererHelper // TypeDefIndex: 57604
	{
		// Methods
		void Reset();
		void Play(string vfxName);
		void Stop(string vfxName);
		void ShowAll();
		void HideAll();
		void SetDitherAlpha(float ditherAlpha, int handle = 0 /* Metadata: 0x0234B332 */);
		float GetDitherAlpha();
		void ResetAllDitherAlpha();
		void ClearEffectCache(string name);
		void OnEntityVFXControllerDestroying(EntityVFXControllerBase controller);
		void SetVisibleByNameContainsStr(string name, bool visible);
		void SetVisibleByRenderer(Renderer renderer, bool visible);
		int AddMaterialToAllRenderer(Material material, EntityVFXRendererMask rendererMask, AddMaterialConfig config = default);
		void RemoveMaterialFromAllRenderer(int handle);
		bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result);
		void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask);
		void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask);
		void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask);
		void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask);
		void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask);
		void SetFloatToFactoryMaterial(Material material, int nameId, float value);
		void SetVectorToFactoryMaterial(Material material, int nameId, Vector4 value);
		void SetAddictiveFloatProperty(int propertyId, float value);
		float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x0234B333 */);
		void SetAddictiveVectorProperty(int propertyId, Vector4 value);
		Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default);
		void SetAddictiveTextureProperty(int propertyId, Texture value);
		Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null);
		void StopShadowCasting(bool stopRayTracing = false /* Metadata: 0x0234B337 */);
		void RevertShadowCastingMode();
		void SetDepthOnlyEnabledToAllMaterial(bool enable, EntityVFXRendererMask rendererMask);
		bool SetManualDitherEnable(bool enable);
		void SetManualDitherAlphaValue(float value);
		Bounds GetRendererBounds();
		Matrix4x4 GetTransform();
		bool IsFactory();
		RenderHelperType GetRenderHelperType(bool forceCalculate = true /* Metadata: 0x0234B338 */);
		void SetTimeScale(float timeScale);
		float GetTimeScale();
		bool GetMeshHasVFXVertColor();
		bool CanPlay(SettingLodLevel settingLodLevel, AssetPlatformLayers platformLayer, EffectTargetLayers targetLayer);
	}

	public class CommonVAT : MonoBehaviour // TypeDefIndex: 57605
	{
		// Fields
		private static readonly int S_COMMON_VAT_PLAY_PARAMS; // 0x00
		public RuntimeVATData data; // 0x18
		private Dictionary<string, List<RuntimeVATAnimationClip>> m_animDic; // 0x20
		private List<RuntimeVATAnimationClip> m_curClips; // 0x28
		private VATPropertySetter m_propertySetter; // 0x30
		private int m_curIndex; // 0x38
		private int m_nextPlayTimerId; // 0x3C
		private bool m_hasNextAnimToPlay; // 0x40
		private string m_nextAnimName; // 0x48
	
		// Properties
		public string PropertySetterType { get; } // 0x000000018A9B2B1C-0x000000018A9B2B98 
	
		// Constructors
		public CommonVAT(); // 0x000000018A9B2A88-0x000000018A9B2B1C
		static CommonVAT(); // 0x000000018A9B2A60-0x000000018A9B2A88
	
		// Methods
		private void Start(); // 0x000000018A9B2330-0x000000018A9B2534
		public void Play(string name, bool playWhenComplete = false /* Metadata: 0x0234B339 */); // 0x000000018A9B2298-0x000000018A9B2330
		private void _DoPlay(string name); // 0x000000018A9B2674-0x000000018A9B27F4
		private void _NextPlay(); // 0x000000018A9B27F4-0x000000018A9B2964
		private void _CreateTimer(float time, Action func, string funcName); // 0x000000018A9B25A8-0x000000018A9B2674
		private void _ClearTimer(); // 0x000000018A9B2534-0x000000018A9B25A8
		private void _UpdateProperty(RuntimeVATAnimationClip runtimeVatAnimationClip); // 0x000000018A9B2964-0x000000018A9B2A60
	}

	public class FactoryVAT : MonoBehaviour // TypeDefIndex: 57606
	{
		// Fields
		public RuntimeVATData data; // 0x18
		public float speed; // 0x20
		public float passTime; // 0x24
		public int lastFrame; // 0x28
		public int curFrame; // 0x2C
		public bool preview; // 0x30
		private MaterialPropertyBlock m_materialPropertyBlock; // 0x38
		private Dictionary<string, List<RuntimeVATAnimationClip>> m_animDic; // 0x40
		private List<RuntimeVATAnimationClip> m_curClips; // 0x48
		private int m_curIndex; // 0x50
		private Action m_callBack; // 0x58
		private bool m_hasNextAnimToPlay; // 0x60
		private string m_nextAnimName; // 0x68
		private Action m_nextAnimCallBack; // 0x70
		private static readonly int S_FACTORY_VAT_FRAME; // 0x00
		private static readonly int S_FACTORY_VAT_LAST_FRAME; // 0x04
		private List<Renderer> m_allRenderers; // 0x78
		private List<Renderer> m_dynamicRenders; // 0x80
		private List<Renderer> m_staticRenders; // 0x88
	
		// Constructors
		public FactoryVAT(); // 0x000000018A9B6B20-0x000000018A9B6C5C
		static FactoryVAT(); // 0x000000018A9B6AD8-0x000000018A9B6B20
	
		// Methods
		private void Start(); // 0x000000018A9B6058-0x000000018A9B61DC
		public void Reset(); // 0x000000018A9B6008-0x000000018A9B6058
		private void _UpdateAnim(); // 0x000000018A9B691C-0x000000018A9B6AD8
		public void OnUpdate(); // 0x000000018A9B5EFC-0x000000018A9B5F4C
		public void Play(string name, Action callBack = null, bool whenComplete = false /* Metadata: 0x0234B33A */); // 0x000000018A9B5F4C-0x000000018A9B6008
		private void _DoPlay(string name, Action callBack); // 0x000000018A9B61DC-0x000000018A9B62C8
		private void _InitRenderer(); // 0x000000018A9B64D4-0x000000018A9B6590
		private void _InitRenderer_MeshRender(LODGroup lodGroup); // 0x000000018A9B62C8-0x000000018A9B64D4
		private void _SetParamsToRenderer(); // 0x000000018A9B68CC-0x000000018A9B691C
		private void _SetParamsToRenderer_MeshRender(); // 0x000000018A9B67D8-0x000000018A9B68CC
		private void _ReSetParamsToRenderer(); // 0x000000018A9B6788-0x000000018A9B67D8
		private void _ReSetParamsToRenderer_MeshRender(); // 0x000000018A9B6590-0x000000018A9B6788
	}

	[Serializable]
	public class RuntimeVATAnimationClip // TypeDefIndex: 57607
	{
		// Fields
		public string stateName; // 0x10
		public string name; // 0x18
		public bool loop; // 0x20
		public int startFrame; // 0x24
		public int endFrame; // 0x28
	
		// Constructors
		public RuntimeVATAnimationClip(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class RuntimeVATData // TypeDefIndex: 57608
	{
		// Fields
		public Texture vatMap; // 0x10
		public bool fullRigidBody; // 0x18
		public List<Matrix4x4> bonePoses; // 0x20
		public float frameRate; // 0x28
		public List<RuntimeVATAnimationClip> animationClips; // 0x30
	
		// Constructors
		public RuntimeVATData(); // 0x000000018A9B8640-0x000000018A9B8690
	}

	public abstract class VATPropertySetter // TypeDefIndex: 57609
	{
		// Constructors
		protected VATPropertySetter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void Init(GameObject gameObject);
		public abstract void SetFloat(int id, float value);
		public abstract void SetVector(int id, Vector4 value);
	}

	public class VATRendererPropertySetter : VATPropertySetter // TypeDefIndex: 57610
	{
		// Fields
		private List<Renderer> m_allRenderers; // 0x10
		private List<Material> m_allMaterials; // 0x18
	
		// Constructors
		public VATRendererPropertySetter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Init(GameObject gameObject); // 0x000000018A9B87F8-0x000000018A9B89F0
		public override void SetFloat(int id, float value); // 0x000000018A9B89F0-0x000000018A9B8B38
		public override void SetVector(int id, Vector4 value); // 0x000000018A9B8B38-0x000000018A9B8CA0
	}

	public class VATEntityRendererHelperPropertySetter : VATPropertySetter // TypeDefIndex: 57611
	{
		// Fields
		private IRendererHelper m_rendererHelper; // 0x10
	
		// Constructors
		public VATEntityRendererHelperPropertySetter(IRendererHelper rendererHelper); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void Init(GameObject gameObject); // 0x000000018A9B8690-0x000000018A9B86E4
		public override void SetFloat(int id, float value); // 0x000000018A9B86E4-0x000000018A9B8764
		public override void SetVector(int id, Vector4 value); // 0x000000018A9B8764-0x000000018A9B87F8
	}

	public class PsoCreateUploadHelper // TypeDefIndex: 57619
	{
		// Fields
		protected const int PSO_UPLOAD_INFO_VERSION = 1; // Metadata: 0x0234B33B
		protected const int MAX_UPLOAD_COUNT_PER_LOOP = 128; // Metadata: 0x0234B33C
		protected const int MAX_UPLOAD_COUNT_PER_LOOP_LARGE = 256; // Metadata: 0x0234B33E
		protected const int MAX_UPLOAD_SIZE_PER_LOOP = 786432; // Metadata: 0x0234B340
		protected const int MAX_UPLOAD_SIZE_PER_LOOP_LARGE = 5242880; // Metadata: 0x0234B344
		protected const float TICK_INTERVAL = 0.55f; // Metadata: 0x0234B348
		protected const int TICK_UPLOAD_INTERVAL = 60; // Metadata: 0x0234B34C
		protected const float CREATE_TIME_SMALL_DROP = 0.5f; // Metadata: 0x0234B34D
		protected static PsoCreateUploadHelper s_instance; // 0x00
		public static int s_enabled; // 0x08
		protected static int s_tickCount; // 0x0C
		public static bool s_skipUploadFile; // 0x10
		public static bool s_isShaderWarming; // 0x11
		public static bool s_enableTimeLimit; // 0x12
		private static readonly Action<bool, string, string> s_uploadFileCallback; // 0x18
		private static string s_persistentDataPath; // 0x20
		private static ConcurrentQueue<ValueTuple<string, float, int, bool, string>> s_concurrentQueue; // 0x28
		private TickFunction m_timerId; // 0x10
		private const string URL = "http://beyondtools.int.hypergryph.com:42422"; // Metadata: 0x0234B351
		private const string TOKEN = "fhlasdfu8731fqa"; // Metadata: 0x0234B37D
		private static SynchronizationContext s_mainSyncContext; // 0x30
		private static int s_mainThreadId; // 0x38
	
		// Properties
		public static PsoCreateUploadHelper instance { get; } // 0x0000000184CEC1A0-0x0000000184CEC270 
		private static string persistentDataPath { get; } // 0x0000000183828780-0x00000001838288B0 
	
		// Nested types
		[Serializable]
		private class PsoInfoWrapperItem // TypeDefIndex: 57612
		{
			// Fields
			public string infoJson; // 0x10
			public float time; // 0x18
			public int codeSize; // 0x1C
			public bool isMissing; // 0x20
			public string levelId; // 0x28
	
			// Constructors
			public PsoInfoWrapperItem(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		private class PsoInfoWrapper // TypeDefIndex: 57613
		{
			// Fields
			public RuntimePlatform platform; // 0x10
			public string lastCL; // 0x18
			public string lastEngineCl; // 0x20
			public string deviceModel; // 0x28
			public string devVersion; // 0x30
			public string branch; // 0x38
			public GraphicsDeviceType graphicsDeviceType; // 0x40
			public int shaderLod; // 0x44
			public int infoVersion; // 0x48
			public bool isDebug; // 0x4C
			public List<PsoInfoWrapperItem> psoInfoWrapperItems; // 0x50
	
			// Constructors
			public PsoInfoWrapper(); // 0x000000018A9B85F0-0x000000018A9B8640
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0 // TypeDefIndex: 57614
		{
			// Fields
			public string path; // 0x10
			public string serverFileName; // 0x18
			public PsoInfoWrapper psoInfoWrapper; // 0x20
	
			// Constructors
			public __c__DisplayClass36_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __CreateAndUploadFinalJson_b__0(object param); // 0x0000000182E61CB0-0x0000000182E61D00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 57615
		{
			// Fields
			public string urlPath; // 0x10
			public string rawFilePath; // 0x18
			public string serverFileNameOverride; // 0x20
			public Action<bool, string, string> callback; // 0x28
	
			// Constructors
			public __c__DisplayClass42_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __UploadFile_b__0(object param); // 0x0000000182E61D00-0x0000000182E61D70
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 57616
		{
			// Fields
			public Action<bool, string, string> callback; // 0x10
			public string fileServerUrl; // 0x18
			public string errorMessage; // 0x20
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __UploadFileToServer_b__1(object _); // 0x0000000182E61D70-0x0000000182E61DB0
			internal void __UploadFileToServer_b__2(object _); // 0x0000000182E61D70-0x0000000182E61DB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_1 // TypeDefIndex: 57617
		{
			// Fields
			public string result; // 0x10
			public __c__DisplayClass43_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass43_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __UploadFileToServer_b__0(object _); // 0x0000000182E61DB0-0x0000000182E61DF0
		}
	
		[CompilerGenerated]
		private struct __UploadFileToServer_d__43 : IAsyncStateMachine // TypeDefIndex: 57618
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public Action<bool, string, string> callback; // 0x28
			public string urlPath; // 0x30
			public string serverFileNameOverride; // 0x38
			public string rawFilePath; // 0x40
			private __c__DisplayClass43_1 __8__1; // 0x48
			private __c__DisplayClass43_0 __8__2; // 0x50
			private string _filePathServerUrl_5__2; // 0x58
			private Stream _fileStream_5__3; // 0x60
			private HttpClient _httpClient_5__4; // 0x68
			private MultipartFormDataContent _content_5__5; // 0x70
			private HttpResponseMessage _response_5__6; // 0x78
			private TaskAwaiter<HttpResponseMessage> __u__1; // 0x80
			private TaskAwaiter<string> __u__2; // 0x88
	
			// Methods
			private void MoveNext(); // 0x0000000182E61DF0-0x0000000182E65CB0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000182A58B10-0x0000000182A58C30
		}
	
		// Constructors
		static PsoCreateUploadHelper(); // 0x0000000184B83810-0x0000000184B84050
		public PsoCreateUploadHelper(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void Initialize(); // 0x0000000184848BE0-0x0000000184848CE0
		public void Init(); // 0x0000000183829F90-0x000000018382A190
		private void _SceneLoadStartHandler([IsReadOnly] in EventData<string, string> args); // 0x0000000183F84BC0-0x0000000183F84C20
		public void Dispose(); // 0x000000018A9B7E34-0x000000018A9B7F28
		public static bool IsPsoRecordEnabled(); // 0x0000000183F84D60-0x0000000183F851E0
		public static void BeforeWarmUpBegin(); // 0x000000018A9B7DC4-0x000000018A9B7E34
		public static void AfterWarmUpFinish(); // 0x000000018A9B7D48-0x000000018A9B7DC4
		private static void _Tick(float deltaTime); // 0x0000000183F84C20-0x0000000183F84D20
		private static void _PsoUploadProcessOneCallBack(string infoJson, HGPsoExtInfo info); // 0x0000000183EBB900-0x0000000183EBBA10
		private static string _PsoUpdateGameInfoCallBack(); // 0x000000018A9B8350-0x000000018A9B83BC
		private static void _UploadPipelineCreatedInfo(bool timeLimit); // 0x0000000183F84D20-0x0000000183F84D60
		private static void _CreateAndUploadFinalJson(bool timeLimit); // 0x0000000183F851E0-0x0000000183F85280
		private static void _CreateAndUploadFileToServer(string path, string serverFileName, PsoInfoWrapper psoInfoWrapper); // 0x000000018A9B7F90-0x000000018A9B8350
		private static void _UploadFile(string urlPath, string rawFilePath, string serverFileNameOverride, Action<bool, string, string> callback); // 0x000000018A9B84C8-0x000000018A9B85F0
		private static async void _UploadFileToServer(string urlPath, string rawFilePath, string serverFileNameOverride, Action<bool, string, string> callback); // 0x000000018A9B83BC-0x000000018A9B84C8
		private static void _Callback(bool success, string msg, string url); // 0x000000018A9B7F28-0x000000018A9B7F90
	}

	public class VFXSludgeBaker // TypeDefIndex: 57622
	{
		// Fields
		public SplineContainer splineContainer; // 0x10
		public Transform rootTransform; // 0x18
		public float thickness; // 0x20
		public float density; // 0x24
		public float maxHeight; // 0x28
		public float blurIntensity; // 0x2C
		public float gridHeightOffset; // 0x30
		public float topLimit; // 0x34
		public float bottomLimit; // 0x38
		public Texture2D bakedTexture1; // 0x40
		public Bounds localBounds; // 0x48
		public float maxHighPowerZoneSignedDistance; // 0x60
		public float maxEdgeToHighPowerZoneSignedDistance; // 0x64
		private List<Vector3> m_localPolygon; // 0x68
		private int m_xCount; // 0x70
		private int m_zCount; // 0x74
		private float[,] m_raycastHeights; // 0x78
		private float[,] m_topHeights; // 0x80
		private Vector3[,] m_normals; // 0x88
		private float[,] m_edgeSignedDistance; // 0x90
		private float[,] m_highPowerZoneSignedDistance; // 0x98
		private bool[,] m_inPolygon; // 0xA0
		private bool[,] m_inHighPowerZone; // 0xA8
		private const float EXTEND_SIZE = 2f; // Metadata: 0x0234B38D
		public float rayCastPosY; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 57620
		{
			// Fields
			public float[,] sdf; // 0x10
			public HashSet<int> hashList; // 0x18
			public int xCount; // 0x20
			public Queue<Vector2Int> pendingList; // 0x28
			public Action<int, int> __9__0; // 0x30
	
			// Constructors
			public __c__DisplayClass41_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __CalculateEdgeSignedDistance_b__0(int tx, int tz); // 0x000000018A9C5BE8-0x000000018A9C5C8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_1 // TypeDefIndex: 57621
		{
			// Fields
			public int ix; // 0x10
			public int iz; // 0x14
			public float minDistance; // 0x18
			public __c__DisplayClass41_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass41_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __CalculateEdgeSignedDistance_b__1(int tx, int tz); // 0x000000018A9C5C8C-0x000000018A9C5DCC
		}
	
		// Constructors
		public VFXSludgeBaker(SplineContainer splineContainer, Transform target, float density, float thickness, float maxHeight, float blurIntensity, float gridHeightOffset); // 0x000000018A9BBB74-0x000000018A9BBBE4
	
		// Methods
		public void Bake(); // 0x000000018A9B8CA0-0x000000018A9B8D38
		private void _CalculatePolygonAndBounds(); // 0x000000018A9BA178-0x000000018A9BA49C
		public Vector2Int GetLocalIndex(Vector3 localPosition); // 0x000000018A9B8D38-0x000000018A9B8E1C
		public Vector3 GetLocalPosition(Vector2Int index); // 0x000000018A9B8E1C-0x000000018A9B8F40
		private void _RaycastSceneObjectsHeight(); // 0x000000018A9BB350-0x000000018A9BBB74
		private void _CalculateInPolygon(); // 0x000000018A9B9C8C-0x000000018A9B9E70
		private void _CalculateInHighPowerZone(); // 0x000000018A9B98DC-0x000000018A9B9C8C
		private static float[] _CreateGaussianKernel(int size, float sigma); // 0x000000018A9BAB84-0x000000018A9BACBC
		private static float[,] _Convolution(float[,] src, float[] kernel, Vector2Int offsetDir); // 0x000000018A9BA978-0x000000018A9BAB84
		private void _BlurTopHeight(); // 0x000000018A9B8F40-0x000000018A9B9104
		private void _CalculateThicknessAndTopHeight(); // 0x000000018A9BA49C-0x000000018A9BA978
		private void _CalculateNormals(); // 0x000000018A9B9E70-0x000000018A9BA178
		private static void _ForAround(int ix, int iz, int xCount, int zCount, Action<int, int> callback); // 0x000000018A9BAE28-0x000000018A9BAF24
		[IDTag(1)]
		private int _GetHash(int ix, int iz); // 0x000000018A9BAF90-0x000000018A9BB000
		[IDTag(0)]
		private static int _GetHash(int ix, int iz, int xCount); // 0x000000018A9BAF24-0x000000018A9BAF90
		[IDTag(0)]
		private static void _CalculateEdgeSignedDistance(float[,] sdf); // 0x000000018A9B9104-0x000000018A9B9418
		[IDTag(1)]
		private void _CalculateEdgeSignedDistance(); // 0x000000018A9B9418-0x000000018A9B98DC
		private UnityEngine.Color _GetTextureColor1(int ix, int iz); // 0x000000018A9BB000-0x000000018A9BB200
		private UnityEngine.Color _GetTextureColor2(int ix, int iz); // 0x000000018A9BB200-0x000000018A9BB350
		private void _CreateTexture(); // 0x000000018A9BACBC-0x000000018A9BAE28
	}

	public class VFXSludgeNavUtils // TypeDefIndex: 57632
	{
		// Nested types
		public static class BoundsUtil // TypeDefIndex: 57623
		{
			// Methods
			public static void GetTopBottomPoints(Bounds bounds, Transform t, out Vector3 topPoint, out Vector3 bottomPoint, Vector3? upDir = default); // 0x000000018A9BBBE4-0x000000018A9BBF38
		}
	
		public static class Spline2DProjectAndSimplify // TypeDefIndex: 57628
		{
			// Nested types
			public struct Frame // TypeDefIndex: 57624
			{
				// Fields
				public Vector3 origin; // 0x00
				public Quaternion rot; // 0x0C
	
				// Constructors
				public Frame(Vector3 origin, Quaternion rot); // 0x0000000184D91FA0-0x0000000184D91FC0
	
				// Methods
				public Vector3 WorldToFrame(Vector3 pWorld); // 0x000000018A9BC02C-0x000000018A9BC144
				public Vector3 FrameToWorld(Vector3 pFrame); // 0x000000018A9BBF38-0x000000018A9BC02C
			}
	
			public enum EdgeMode // TypeDefIndex: 57625
			{
				UseSplineOrder = 0,
				ConvexHull = 1
			}
	
			public class ProcessResult // TypeDefIndex: 57626
			{
				// Fields
				public List<Vector3> samples3D; // 0x10
				public List<Vector2> projected2D; // 0x18
				public List<int> edgeIndices; // 0x20
				public List<int> simplifiedIndices; // 0x28
				public float worldMinY; // 0x30
				public float worldMaxY; // 0x34
				public float frameMinY; // 0x38
				public float frameMaxY; // 0x3C
	
				// Constructors
				public ProcessResult(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass6_0 // TypeDefIndex: 57627
			{
				// Fields
				public List<Vector2> pts; // 0x10
	
				// Constructors
				public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal int _ConvexHullIndices_b__0(int i, int j); // 0x000000018A9C5DCC-0x000000018A9C5E9C
			}
	
			// Methods
			public static Frame MakeFrameFromPlaneNormal(Vector3 planeOrigin, Vector3 planeNormal); // 0x000000018A9C3A88-0x000000018A9C3BB0
			public static Frame MakeFrameByYaw(Vector3 origin, float yawDeg); // 0x000000018A9C39C4-0x000000018A9C3A88
			public static List<Vector3> SampleUniformByArcLength(SplineContainer container, float stepMeters = 0.1f /* Metadata: 0x0234B391 */, int splineIndex = 0 /* Metadata: 0x0234B395 */, bool closed = true /* Metadata: 0x0234B396 */, float oversample = 0.02f /* Metadata: 0x0234B397 */); // 0x000000018A9C42FC-0x000000018A9C4834
			public static void ProjectWorldToFrameXZ(List<Vector3> worldPts, Frame frame, out List<Vector2> projected2D, out List<float> frameYs, out float worldMinY, out float worldMaxY, out float frameMinY, out float frameMaxY); // 0x000000018A9C4088-0x000000018A9C42FC
			public static List<int> ConvexHullIndices(List<Vector2> pts); // 0x000000018A9C347C-0x000000018A9C39C4
			private static float _AngleDegAt(List<Vector2> p, int i, bool closed); // 0x000000018A9C4C64-0x000000018A9C4E98
			private static float _CurvatureAt(List<Vector2> p, int i, bool closed); // 0x000000018A9C4E98-0x000000018A9C5178
			private static float _PointToSegmentDistance2D(Vector2 a, Vector2 b, Vector2 p); // 0x000000018A9C5178-0x000000018A9C52A8
			public static List<int> Simplify2D_ByCurvatureAngleDeviation(List<Vector2> poly, bool closed, float angleDegThresh, float deltaKappaThresh, float devEps); // 0x000000018A9C4834-0x000000018A9C4C0C
			public static ProcessResult Process(SplineContainer container, Frame frame, float stepMeters = 0.1f /* Metadata: 0x0234B39B */, int splineIndex = 0 /* Metadata: 0x0234B39F */, bool splineClosed = true /* Metadata: 0x0234B3A0 */, EdgeMode edgeMode = EdgeMode.UseSplineOrder /* Metadata: 0x0234B3A1 */, float angleDegThresh = 3f /* Metadata: 0x0234B3A2 */, float deltaKappaThresh = 0.1f /* Metadata: 0x0234B3A6 */, float devEpsFactor = 0.2f /* Metadata: 0x0234B3AA */); // 0x000000018A9C3BB0-0x000000018A9C4088
			[CompilerGenerated]
			internal static float _ConvexHullIndices_g__Cross_6_1(Vector2 a, Vector2 b, Vector2 c); // 0x000000018A9C4C0C-0x000000018A9C4C64
		}
	
		public static class SplineSamplingUtils // TypeDefIndex: 57630
		{
			// Nested types
			[CompilerGenerated]
			private struct __c__DisplayClass0_0 // TypeDefIndex: 57629
			{
				// Fields
				public int lutResolution; // 0x00
				public SplineContainer container; // 0x08
				public int splineIndex; // 0x10
				public bool worldSpace; // 0x14
				public bool closed; // 0x15
				public float totalLen; // 0x18
			}
	
			// Methods
			public static List<Vector2> SampleByArcLength(SplineContainer container, float step, int splineIndex = 0 /* Metadata: 0x0234B3B0 */, int lutResolution = 1024 /* Metadata: 0x0234B3B1 */, bool closed = true /* Metadata: 0x0234B3B3 */, bool worldSpace = true /* Metadata: 0x0234B3B4 */); // 0x000000018A9C52A8-0x000000018A9C5AA0
			[CompilerGenerated]
			internal static Vector3 _SampleByArcLength_g__P_0_0(int i, ref __c__DisplayClass0_0 param_0007be33); // 0x000000018A9C5AA0-0x000000018A9C5BB8
			[CompilerGenerated]
			internal static float _SampleByArcLength_g__WrapLen_0_1(float s, ref __c__DisplayClass0_0 param_0007be35); // 0x000000018A9C5BB8-0x000000018A9C5BE8
		}
	
		public static class PolySimplify // TypeDefIndex: 57631
		{
			// Methods
			public static List<Vector3> SimplifyByAngle(List<Vector3> pts, float maxTurnDeg = 3f /* Metadata: 0x0234B3B5 */, float minEdgeLen = 0.05f /* Metadata: 0x0234B3B9 */, bool closed = true /* Metadata: 0x0234B3BD */); // 0x000000018A9C2ECC-0x000000018A9C347C
		}
	
		// Constructors
		public VFXSludgeNavUtils(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class VFXSludgeUtils // TypeDefIndex: 57633
	{
		// Methods
		public static List<Vector3> GetPolygonOffSpline(SplineContainer splineContainer, float splitDistance, int splineIndex = 0 /* Metadata: 0x0234B3BE */); // 0x000000018A9C689C-0x000000018A9C6A98
		public static void GetPolygonOffSplineWithSimplify(SplineContainer container, ref List<Vector2> points, int splineIndex = 0 /* Metadata: 0x0234B3BF */, bool closed = true /* Metadata: 0x0234B3C0 */, bool isDebug = false /* Metadata: 0x0234B3C1 */, bool isConvexHull = false /* Metadata: 0x0234B3C2 */); // 0x000000018A9C6350-0x000000018A9C689C
		public static List<Vector3> GetPolygonOffByPolyLine(List<Vector2> polylinePoints, Transform transform, float splitDistance); // 0x000000018A9C6010-0x000000018A9C6350
		public static List<Vector3> CalculatePointPolygonHorizonRayCross(List<Vector3> polygon, Vector3 point); // 0x000000018A9C5E9C-0x000000018A9C6010
	}

	public class HGTerrain : MonoBehaviour // TypeDefIndex: 57634
	{
		// Constructors
		public HGTerrain(); // 0x0000000185393520-0x0000000185393538
	}

	public delegate void ToggleFunc(HGTerrainHelper terrainHelper); // TypeDefIndex: 57635; 0x0000000182B46B90-0x0000000182B46BA0

	[ExecuteInEditMode]
	[RequireComponent(typeof(Terrain))]
	public class HGTerrainHelper : MonoBehaviour // TypeDefIndex: 57636
	{
		// Constructors
		public HGTerrainHelper(); // 0x0000000185393520-0x0000000185393538
	}
}

namespace Beyond.Rendering.ECS
{
	public class HGAddedMaterialController // TypeDefIndex: 57642
	{
		// Fields
		public const int MAX_ACTIVE_ADDED_MATERIAL = 4; // Metadata: 0x0234B3CA
		private HGMeshRenderer m_sourceRenderer; // 0x10
		private HGMeshRendererData m_sourceData; // 0x18
		private Transform m_overlayParent; // 0x20
		private int m_sourceMaterialSlotCount; // 0x28
		private readonly Dictionary<int, OverlayLayer> m_activeLayers; // 0x30
		private readonly Stack<OverlayLayer> m_pool; // 0x38
		private int m_nextHandle; // 0x40
		private int m_layerCreateCounter; // 0x44
		private readonly List<int> m_handlesScratch; // 0x48
		public Action<HGMeshRenderer> onLayerActivated; // 0x50
		private Dictionary<int, float> m_addictiveFloatProperties; // 0x58
		private Dictionary<int, Vector4> m_addictiveVectorProperties; // 0x60
		private Dictionary<int, Texture> m_addictiveTextureProperties; // 0x68
	
		// Properties
		public int activeLayerCount { get; } // 0x000000018A9BD844-0x000000018A9BD89C 
	
		// Nested types
		private class OverlayLayer // TypeDefIndex: 57641
		{
			// Fields
			public int handle; // 0x10
			public GameObject overlayGO; // 0x18
			public HGMeshRenderer overlayRenderer; // 0x20
			public HGMeshRendererData clonedData; // 0x28
			public Material currentMaterial; // 0x30
			public Material[] materialsScratch; // 0x38
	
			// Constructors
			public OverlayLayer(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public HGAddedMaterialController(); // 0x000000018A9BD784-0x000000018A9BD844
	
		// Methods
		public void Init(HGMeshRenderer sourceRenderer, HGMeshRendererData sourceData, Transform overlayParent, int sourceMaterialSlotCount); // 0x000000018A9BC61C-0x000000018A9BC6D0
		public int RequireAddMaterial(Material material); // 0x000000018A9BCABC-0x000000018A9BCD88
		public void RequireRemoveMaterial(int handle); // 0x000000018A9BCD88-0x000000018A9BCF44
		public int GetActiveOverlayRenderers(List<HGMeshRenderer> result); // 0x000000018A9BC144-0x000000018A9BC324
		public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result); // 0x000000018A9BC324-0x000000018A9BC41C
		public void SetAddictiveFloatProperty(int propertyId, float value); // 0x000000018A9BD174-0x000000018A9BD238
		public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x0234B3C6 */); // 0x000000018A9BC41C-0x000000018A9BC4B8
		public void SetAddictiveVectorProperty(int propertyId, Vector4 value); // 0x000000018A9BD2FC-0x000000018A9BD3D4
		public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default); // 0x000000018A9BC554-0x000000018A9BC61C
		public void SetAddictiveTextureProperty(int propertyId, Texture value); // 0x000000018A9BD238-0x000000018A9BD2FC
		public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null); // 0x000000018A9BC4B8-0x000000018A9BC554
		private OverlayLayer _CreateNewLayer(); // 0x000000018A9BD3D4-0x000000018A9BD634
		public void Reset(); // 0x000000018A9BCF44-0x000000018A9BD174
		public void Release(); // 0x000000018A9BC6D0-0x000000018A9BCABC
		private static void _DestroyLayer(OverlayLayer layer); // 0x000000018A9BD634-0x000000018A9BD784
	}

	public class HGMaterialCommitter // TypeDefIndex: 57644
	{
		// Fields
		private HGMeshRenderer m_hgRenderer; // 0x10
		private HGMeshRendererData m_sourceData; // 0x18
		private HGMeshRendererData m_clonedData; // 0x20
		private MaterialsProvider m_materialsProvider; // 0x28
		private Action m_onDirty; // 0x30
		private Action m_onCommitted; // 0x38
		private bool m_dirtyMaterialsArray; // 0x40
	
		// Properties
		public HGMeshRendererData clonedData { get; } // 0x000000018A9BDEB0-0x000000018A9BDF00 
	
		// Nested types
		public delegate Material[] MaterialsProvider(); // TypeDefIndex: 57643; 0x0000000187378308-0x0000000187378318
	
		// Constructors
		public HGMaterialCommitter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Init(HGMeshRenderer renderer, HGMeshRendererData sourceData, MaterialsProvider materialsProvider, Action onDirty = null, Action onCommitted = null); // 0x000000018A9BD8EC-0x000000018A9BD9D8
		public void MarkMaterialsArrayDirty(); // 0x000000018A9BDA24-0x000000018A9BDA84
		public bool IsDirty(); // 0x000000018A9BD9D8-0x000000018A9BDA24
		public void TryCommit(); // 0x000000018A9BDC8C-0x000000018A9BDCE4
		public void ForceCommit(); // 0x000000018A9BD89C-0x000000018A9BD8EC
		private void _Commit(); // 0x000000018A9BDCE4-0x000000018A9BDEB0
		public void Reset(); // 0x000000018A9BDBE0-0x000000018A9BDC8C
		public void Release(); // 0x000000018A9BDA84-0x000000018A9BDBE0
	}

	public class HGMaterialController // TypeDefIndex: 57645
	{
		// Fields
		private const string VFX_MATERIAL_POSTFIX = "_VFXInstance"; // Metadata: 0x0234B3CB
		private const string ALPHA_BLEND_ON_KEYWORD = "_ALPHABLEND_ON"; // Metadata: 0x0234B3D8
		private const string DEPTH_ONLY_PASS = "DepthOnly"; // Metadata: 0x0234B3E7
		private const string DITHER_KEYWORD = "DITHER"; // Metadata: 0x0234B3F1
		private static int s_zTestGBuffer; // 0x00
		private static int s_outlineZTest; // 0x04
		private static int s_ditherTransparentAlpha; // 0x08
		private HGMeshRenderer m_hgRenderer; // 0x10
		private HGMeshRendererData m_sourceData; // 0x18
		private HGMaterialCommitter m_committer; // 0x20
		private Material[] m_sourceMaterials; // 0x28
		private Material[] m_currentMaterials; // 0x30
		private List<Material> m_instancedMaterials; // 0x38
		private Dictionary<Material, Material> m_src2dstMaterialDict; // 0x40
		private Dictionary<int, float> m_floatProperties; // 0x48
		private Dictionary<int, Vector4> m_vectorProperties; // 0x50
		private Dictionary<int, Texture> m_textureProperties; // 0x58
		private Dictionary<string, bool> m_keywordStates; // 0x60
		private bool m_depthOnlyPassEnabled; // 0x68
		private bool m_depthOnlyPassControlling; // 0x69
	
		// Properties
		public Material[] currentMeshMaterials { get; } // 0x000000018A9BF764-0x000000018A9BF7B4 
	
		// Constructors
		public HGMaterialController(); // 0x00000001841E1670-0x00000001841E1680
		static HGMaterialController(); // 0x000000018A9BF6FC-0x000000018A9BF764
	
		// Methods
		public void Init(HGMeshRenderer renderer, HGMeshRendererData sourceData, Material[] sourceMaterials, HGMaterialCommitter committer); // 0x000000018A9BDF00-0x000000018A9BE060
		private Material _GetOrCreateInstancedMaterial(int slot); // 0x000000018A9BF454-0x000000018A9BF6FC
		private void _ApplyAllPropertiesToOneMaterial(Material mat); // 0x000000018A9BEDCC-0x000000018A9BF2B4
		private void _ApplyDepthOnlyPassToMaterial(Material mat, bool enable); // 0x000000018A9BF2B4-0x000000018A9BF454
		public void SetFloatToAllMaterial(int nameId, float value); // 0x000000018A9BE684-0x000000018A9BE7FC
		public void SetVectorToAllMaterial(int nameId, Vector4 value); // 0x000000018A9BEBD0-0x000000018A9BEDCC
		public void SetTextureToAllMaterial(int nameId, Texture value); // 0x000000018A9BEA8C-0x000000018A9BEBD0
		public void SetKeywordEnableToAllMaterial(string keyword, bool enable); // 0x000000018A9BE7FC-0x000000018A9BE990
		public void SetDepthOnlyPassEnableToAllMaterial(bool enable); // 0x000000018A9BE5D4-0x000000018A9BE684
		public bool SetManualDitherEnable(bool enable); // 0x000000018A9BEA14-0x000000018A9BEA8C
		public void SetManualDitherAlphaValue(float value); // 0x000000018A9BE990-0x000000018A9BEA14
		public void ReplaceAllMaterials(Material replacement); // 0x000000018A9BE254-0x000000018A9BE32C
		public void ReplaceMaterialBySource(Material srcMat, Material replacement); // 0x000000018A9BE32C-0x000000018A9BE4C4
		public void Reset(); // 0x000000018A9BE4C4-0x000000018A9BE5D4
		public void Release(); // 0x000000018A9BE060-0x000000018A9BE254
	}

	public class HGRendererStateController // TypeDefIndex: 57646
	{
		// Fields
		private HGMeshRenderer m_hgRenderer; // 0x10
		private bool m_oriEnabled; // 0x18
		private bool m_warnedNoMeshes; // 0x19
		private Bounds[] m_meshLocalBounds; // 0x20
		private Matrix4x4 m_cachedL2W; // 0x28
		private Bounds m_cachedWorldBounds; // 0x68
		private bool m_hasCachedWorldBounds; // 0x80
	
		// Properties
		public HGMeshRenderer hgRenderer { get; } // 0x000000018A9C0780-0x000000018A9C07D0 
	
		// Constructors
		public HGRendererStateController(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Init(HGMeshRenderer renderer); // 0x000000018A9BFB54-0x000000018A9BFC00
		public bool IsValid(); // 0x000000018A9BFC60-0x000000018A9BFCC8
		public void SetVisible(bool visible); // 0x000000018A9BFE38-0x000000018A9BFECC
		public void Reset(); // 0x000000018A9BFD70-0x000000018A9BFDF4
		public Bounds GetBounds(); // 0x000000018A9BF7B4-0x000000018A9BFB54
		public void InvalidateMeshCache(); // 0x000000018A9BFC00-0x000000018A9BFC60
		private void _EnsureMeshLocalBoundsCached(); // 0x000000018A9BFF20-0x000000018A9C0118
		private static Bounds _LocalBoundsToWorld(Bounds local, Matrix4x4 l2w); // 0x000000018A9C0118-0x000000018A9C06B4
		private void _WarnNoMeshes(); // 0x000000018A9C06B4-0x000000018A9C0780
		public void StopShadowCasting(bool stopRayTracing); // 0x000000018A9BFECC-0x000000018A9BFF20
		public void RevertShadowCastingMode(); // 0x000000018A9BFDF4-0x000000018A9BFE38
		public void Release(); // 0x000000018A9BFCC8-0x000000018A9BFD70
	}
}

namespace Beyond.Rendering.LODLightmapping
{
	[ExecuteInEditMode]
	public class LightmapInfoTransfer : MonoBehaviour // TypeDefIndex: 57638
	{
		// Fields
		[SerializeField]
		private MeshRenderer _lightmappedRenderer; // 0x18
		private MeshRenderer m_currentRenderer; // 0x20
	
		// Constructors
		public LightmapInfoTransfer(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnEnable(); // 0x000000018A9C2CE4-0x000000018A9C2D34
		private void Awake(); // 0x000000018A9C2C68-0x000000018A9C2CE4
		private void _RendererInfoTransfer(); // 0x000000018A9C2D34-0x000000018A9C2ECC
	}

	public enum LodLightmappingMode // TypeDefIndex: 57639
	{
		AllFromLightProbe = 0,
		AllFromLOD0 = 1,
		UseDifferentLightmapAreaForLODs = 2
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class LODLightmapping : MonoBehaviour // TypeDefIndex: 57640
	{
		// Fields
		public LodLightmappingMode mode; // 0x18
		[SerializeField]
		public Vector4 lightmapScaleOffset; // 0x1C
		[SerializeField]
		public int lightmapIndex; // 0x2C
	
		// Constructors
		public LODLightmapping(); // 0x0000000184A39E70-0x0000000184A39EC0
	
		// Methods
		public void RendererInfoTransfer(); // 0x000000018A9C28EC-0x000000018A9C2C68
	}
}

namespace Beyond.Rendering.SplineMovingObjects
{
	[ExecuteAlways]
	[RequireComponent(typeof(SplineContainer))]
	public class HGSplineMovingObjects : MonoBehaviour, IVFXPlayable // TypeDefIndex: 57637
	{
		// Fields
		[SerializeField]
		private SplineObjectsDesc desc; // 0x18
		[HideInInspector]
		[SerializeField]
		private SplineObjectsKnotData[] knotData; // 0x258
		[SerializeField]
		private bool fixedPostion; // 0x260
		[SerializeField]
		private bool optimizeCurve; // 0x261
		private uint m_instanceHandle; // 0x264
		private NativeArray<SplineObjectsKnotData> m_stonesKnotDataNativeArray; // 0x268
	
		// Constructors
		public HGSplineMovingObjects(); // 0x000000018A9C1174-0x000000018A9C1378
	
		// Methods
		private void _CreateInstance(); // 0x000000018A9C0C00-0x000000018A9C0E34
		private void _ExtractSplineData(); // 0x000000018A9C0E9C-0x000000018A9C10F8
		private void _DestroyInstance(); // 0x000000018A9C0E34-0x000000018A9C0E9C
		private void _Release(); // 0x000000018A9C10F8-0x000000018A9C1174
		private void Update(); // 0x000000018A9C0B48-0x000000018A9C0C00
		private void OnEnable(); // 0x000000018A9C0A04-0x000000018A9C0A54
		private void OnDisable(); // 0x000000018A9C0820-0x000000018A9C0870
		private void OnDestroy(); // 0x000000018A9C07D0-0x000000018A9C0820
		private void OnDrawGizmosSelected(); // 0x000000018A9C0870-0x000000018A9C0A04
		public void Pause(); // 0x000000018A9C0A54-0x000000018A9C0AA8
		public void Play(); // 0x000000018A9C0AA8-0x000000018A9C0AF8
		public void Stop(); // 0x000000018A9C0AF8-0x000000018A9C0B48
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 57505
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 57506
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 57507
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 57508
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 57509
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class ContainerWaterManager : MonoBehaviour // TypeDefIndex: 57502
	{
		// Fields
		private static readonly int DISPLACEMENT_TEX; // 0x00
		private static readonly int DISPLACEMENT_TEX_ST; // 0x04
		private static readonly int WATER_MENISCUS_WIDTH; // 0x08
		private static readonly int ICE_POSITION; // 0x0C
		public Material waveMaterial; // 0x18
		public Texture2D waveTexture; // 0x20
		public Transform iceBall; // 0x28
		public Renderer liquidRenderer; // 0x30
		private float[][] m_waveN; // 0x38
		private float[][] m_waveNm1; // 0x40
		private float[][] m_waveNp1; // 0x48
		private readonly float m_cylinderRadius; // 0x50
		[FormerlySerializedAs("dx")]
		[Header("\u57FA\u7840\u6A21\u62DF\u53C2\u6570")]
		[Range(0.001f, 0.1f)]
		[SerializeField]
		[Tooltip("\u7F51\u683C\u5BC6\u5EA6\uFF0C\u5F71\u54CD\u6CE2\u6D6A\u6A21\u62DF\u7684\u7CBE\u5EA6\u3002\u503C\u8D8A\u5C0F\u7CBE\u5EA6\u8D8A\u9AD8\u4F46\u6027\u80FD\u6D88\u8017\u8D8A\u5927")]
		private float _dx; // 0x54
		private int m_nx; // 0x58
		private int m_ny; // 0x5C
		[Tooltip("\u6761\u4EF6\u6570\uFF0C\u5F71\u54CD\u6A21\u62DF\u7A33\u5B9A\u6027")]
		public float CFL; // 0x60
		[Tooltip("\u6CE2\u5728\u4ECB\u8D28\u4E2D\u7684\u4F20\u64AD\u901F\u5EA6")]
		public float c; // 0x64
		private float m_dt; // 0x68
		private float m_t; // 0x6C
		public bool reflectiveBoundary; // 0x70
		[FormerlySerializedAs("waveMultiplier")]
		[Header("\u6CE2\u6D6A\u6548\u679C\u53C2\u6570")]
		[SerializeField]
		[Space(10f)]
		private float _waveMultiplier; // 0x74
		[FormerlySerializedAs("pulseFrequency")]
		[SerializeField]
		private float _pulseFrequency; // 0x78
		[FormerlySerializedAs("pulseMagnitude")]
		[SerializeField]
		private float _pulseMagnitude; // 0x7C
		[FormerlySerializedAs("elasticity")]
		[Header("\u6DB2\u4F53\u7269\u7406\u7279\u6027")]
		[Range(0.8f, 0.99f)]
		[SerializeField]
		[Space(10f)]
		[Tooltip("\u6DB2\u4F53\u5F39\u6027\u7CFB\u6570\uFF0C\u5F71\u54CD\u6CE2\u6D6A\u7684\u6301\u7EED\u6027\u3002\u5A01\u58EB\u5FCC\u5EFA\u8BAE0.85-0.9")]
		private float _elasticity; // 0x80
		[Range(0.01f, 0.5f)]
		[SerializeField]
		[Tooltip("\u6DB2\u4F53\u7C98\u7A20\u5EA6\uFF0C\u503C\u8D8A\u5927\u6DB2\u4F53\u8D8A\u7C98\u7A20\uFF0C\u6CE2\u52A8\u8870\u51CF\u8D8A\u5FEB\u3002\u5EFA\u8BAE0.15-0.25")]
		private float _viscosity; // 0x84
		[Range(0.1f, 2f)]
		[SerializeField]
		[Tooltip("\u8868\u9762\u5F20\u529B\u7CFB\u6570\uFF0C\u5F71\u54CD\u5C0F\u6CE2\u7EB9\u7684\u5E73\u6ED1\u7A0B\u5EA6\u3002\u5EFA\u8BAE0.3-0.6")]
		private float _surfaceTension; // 0x88
		[FormerlySerializedAs("adaptiveQuality")]
		[Header("\u6027\u80FD\u4E0E\u8C03\u8BD5\uFF08\u7F8E\u672F\u4FA7\u4E0D\u5EFA\u8BAE\u8C03\u6574\uFF09")]
		[SerializeField]
		[Space(10f)]
		private bool _adaptiveQuality; // 0x8C
		[FormerlySerializedAs("targetFrameTime")]
		[SerializeField]
		private float _targetFrameTime; // 0x90
		private float m_lastFrameTime; // 0x94
		[FormerlySerializedAs("debugDisplay")]
		[SerializeField]
		private RawImage _debugDisplay; // 0x98
		[FormerlySerializedAs("updateFrequency")]
		[Header("\u66F4\u65B0\u9891\u7387\u63A7\u5236\uFF08\u7F8E\u672F\u4FA7\u4E0D\u5EFA\u8BAE\u8C03\u6574\uFF09")]
		[SerializeField]
		[Space(10f)]
		private int _updateFrequency; // 0xA0
		private int m_frameCounter; // 0xA4
		private float m_currentYRotationSpeed; // 0xA8
		private bool m_needsTextureUpdate; // 0xAC
		private Vector3 m_lastIceBallPosition; // 0xB0
		private Quaternion m_lastIceBallRotation; // 0xBC
		private readonly float m_iceBallRadius; // 0xCC
		[FormerlySerializedAs("rippleUpdateInterval")]
		[Header("\u51B0\u5757\u878D\u5316\u6D9F\u6F2A\u53C2\u6570")]
		[Range(0.05f, 3f)]
		[SerializeField]
		[Space(10f)]
		[Tooltip("\u6D9F\u6F2A\u66F4\u65B0\u95F4\u9694\u65F6\u95F4\uFF08\u79D2\uFF09- \u5EFA\u8BAE\u503C: 0.3-0.5f")]
		private float _rippleUpdateInterval; // 0xD0
		[FormerlySerializedAs("rippleBaseStrength")]
		[Range(0.005f, 0.2f)]
		[SerializeField]
		[Tooltip("\u6D9F\u6F2A\u57FA\u7840\u5F3A\u5EA6 - \u5EFA\u8BAE\u503C: 0.02-0.05f")]
		private float _rippleBaseStrength; // 0xD4
		[FormerlySerializedAs("rippleRadius")]
		[Range(1.5f, 5f)]
		[SerializeField]
		[Tooltip("\u6D9F\u6F2A\u5F71\u54CD\u8303\u56F4\uFF08\u76F8\u5BF9\u4E8E\u51B0\u7403\u534A\u5F84\u7684\u500D\u6570\uFF09- \u5EFA\u8BAE\u503C: 3-4f")]
		private float _rippleRadius; // 0xD8
		[FormerlySerializedAs("rippleWaveLength")]
		[Range(1f, 5f)]
		[SerializeField]
		[Tooltip("\u6D9F\u6F2A\u6CE2\u957F\uFF08\u63A7\u5236\u6D9F\u6F2A\u7684\u5BC6\u5EA6\uFF0C\u503C\u8D8A\u5927\u5468\u671F\u8D8A\u957F\uFF09- \u5EFA\u8BAE\u503C: 2.5-4f")]
		private float _rippleWaveLength; // 0xDC
		[FormerlySerializedAs("rippleSpeed")]
		[Range(0.01f, 1.5f)]
		[SerializeField]
		[Tooltip("\u6D9F\u6F2A\u6269\u6563\u901F\u5EA6\uFF08\u503C\u8D8A\u5C0F\u5468\u671F\u8D8A\u957F\uFF09- \u5EFA\u8BAE\u503C: 0.2-0.4f")]
		private float _rippleSpeed; // 0xE0
		[FormerlySerializedAs("distanceDecayPower")]
		[Range(1f, 4f)]
		[SerializeField]
		[Tooltip("\u8DDD\u79BB\u8870\u51CF\u5F3A\u5EA6\uFF08\u503C\u8D8A\u5927\uFF0C\u5468\u8FB9\u6CE2\u52A8\u8D8A\u5C0F\uFF09- \u5EFA\u8BAE\u503C: 1.5-2.5f")]
		private float _distanceDecayPower; // 0xE4
		[Range(0.1f, 1f)]
		[SerializeField]
		[Tooltip("\u878D\u5316\u6D9F\u6F2A\u7684\u5747\u5300\u6027\uFF08\u503C\u8D8A\u5927\u8D8A\u5747\u5300\uFF09- \u5EFA\u8BAE\u503C: 0.7-0.9f")]
		private float _meltingUniformity; // 0xE8
		[Range(0.01f, 0.3f)]
		[SerializeField]
		[Tooltip("\u878D\u5316\u6D9F\u6F2A\u7684\u968F\u673A\u53D8\u5316\u5F3A\u5EA6 - \u5EFA\u8BAE\u503C: 0.05-0.1f")]
		private float _meltingVariation; // 0xEC
		private float m_lastRippleUpdateTime; // 0xF0
		private float m_ripplePhase; // 0xF4
		[FormerlySerializedAs("rotationWaveMultiplier")]
		[Header("\u51B0\u7403\u65CB\u8F6C\u6D9F\u6F2A\u53C2\u6570")]
		[Range(0.01f, 10f)]
		[SerializeField]
		[Space(10f)]
		[Tooltip("\u65CB\u8F6C\u4EA7\u751F\u6CE2\u7EB9\u7684\u5F3A\u5EA6\u500D\u6570\u3002\u5EFA\u8BAE0.5-1.2")]
		private float _rotationWaveMultiplier; // 0xF8
		[FormerlySerializedAs("rotationSensitivity")]
		[Range(0.5f, 15f)]
		[SerializeField]
		[Tooltip("\u68C0\u6D4B\u65CB\u8F6C\u53D8\u5316\u7684\u654F\u611F\u5EA6\uFF08\u5EA6\u6570\uFF09\u3002\u5EFA\u8BAE8-12\u5EA6")]
		private float _rotationSensitivity; // 0xFC
		private bool[,] m_cylinderMask; // 0x100
		private List<Vector2Int> m_activePoints; // 0x108
		private Color32[] m_cachedPixels; // 0x110
		[Header("\u6F29\u6DA1\u6548\u679C\u63A7\u5236")]
		[Range(0f, 0.1f)]
		[SerializeField]
		[Space(10f)]
		[Tooltip("\u6B63\u5E38\u72B6\u6001\u4E0B\u7684meniscusWidth\u503C")]
		private float _normalMeniscusWidth; // 0x118
		[Range(0.1f, 5f)]
		[SerializeField]
		[Tooltip("\u68C0\u6D4B\u6F29\u6DA1\u7684\u65CB\u8F6C\u901F\u5EA6\u9608\u503C\uFF08\u5EA6/\u79D2\uFF09")]
		private float _vortexDetectionThreshold; // 0x11C
		[Range(0.1f, 2f)]
		[SerializeField]
		[Tooltip("\u6F29\u6DA1\u6548\u679C\u7684\u5E73\u6ED1\u8FC7\u6E21\u65F6\u95F4\uFF08\u79D2\uFF09")]
		private float _vortexTransitionTime; // 0x120
		private bool m_isVortexActive; // 0x124
		private float m_vortexTransitionProgress; // 0x128
		private float m_lastVortexCheckTime; // 0x12C
		private float m_lastYAxisStopTime; // 0x130
		private bool m_wasYAxisRotating; // 0x134
		private readonly float m_yAxisStopDelay; // 0x138
		private const float VORTEX_CHECK_INTERVAL = 0.1f; // Metadata: 0x0234B128
		[Header("\u51B0\u7403\u79FB\u52A8\u8DDD\u79BB\u68C0\u6D4B")]
		[Range(0.001f, 0.1f)]
		[SerializeField]
		[Space(10f)]
		[Tooltip("\u51B0\u7403\u79FB\u52A8\u8DDD\u79BB\u9608\u503C\uFF0C\u8D85\u8FC7\u6B64\u503C\u5C06\u8BBE\u7F6E_WaterMeniscusWidth\u4E3A0")]
		private float _movementDistanceThreshold; // 0x13C
		[Range(0.5f, 5f)]
		[SerializeField]
		[Tooltip("\u79FB\u52A8\u505C\u6B62\u540E\u6062\u590D_WaterMeniscusWidth\u7684\u5EF6\u8FDF\u65F6\u95F4\uFF08\u79D2\uFF09")]
		private float _movementRecoveryDelay; // 0x140
		private bool m_isMovementActive; // 0x144
		private float m_lastMovementStopTime; // 0x148
		private bool m_wasMoving; // 0x14C
		private float m_currentMeniscusWidth; // 0x150
		private bool m_isMeniscusTransitioning; // 0x154
		private float m_meniscusTransitionStartTime; // 0x158
		private float m_meniscusTransitionStartValue; // 0x15C
		private Vector2Int m_tempTexturePos; // 0x160
		private Vector2Int m_tempNearestPoint; // 0x168
	
		// Properties
		private float dy { get; } // 0x000000018A9AB5A4-0x000000018A9AB5EC 
	
		// Constructors
		public ContainerWaterManager(); // 0x000000018A9AB4A0-0x000000018A9AB5A4
		static ContainerWaterManager(); // 0x000000018A9AB41C-0x000000018A9AB4A0
	
		// Methods
		private void Start(); // 0x000000018A9A84C0-0x000000018A9A8544
		private void _InitializeWaveSystem(); // 0x000000018A9A8FE8-0x000000018A9A945C
		private void _PrecomputeCylinderMask(); // 0x000000018A9A956C-0x000000018A9A975C
		private void _UnifiedWaveStep(bool isEditorUpdate); // 0x000000018A9A975C-0x000000018A9AAFB4
		private bool _WorldToTextureCoords(Vector3 worldPos, ref Vector2Int texturePos); // 0x000000018A9AB32C-0x000000018A9AB41C
		private bool _IsInsideCylinder(int i, int j); // 0x000000018A9A945C-0x000000018A9A94F0
		private bool _IsValidPosition(int x, int y); // 0x000000018A9A94F0-0x000000018A9A956C
		private void _ApplyMatrixToTexture(float[][] state, ref Texture2D tex, float waveMultiplier); // 0x000000018A9A894C-0x000000018A9A8DCC
		private void _ApplyReflectiveBoundary(); // 0x000000018A9A8DCC-0x000000018A9A8E80
		private void _ApplyAbsorptiveBoundary(); // 0x000000018A9A87F8-0x000000018A9A894C
		private Vector2Int _FindNearestInsidePoint(int x, int y); // 0x000000018A9A8E80-0x000000018A9A8FE8
		private void _UpdateVortexState(bool isEditorUpdate); // 0x000000018A9AAFB4-0x000000018A9AB32C
		[ContextMenu("\u91CD\u7F6E\u6C34\u6CE2\u7EB9\u7406")]
		public void ResetWaveTexture(); // 0x000000018A9A8334-0x000000018A9A84C0
		private void Update(); // 0x000000018A9A8544-0x000000018A9A87F8
	}

	[AddComponentMenu("HG/Effect/VFXLockTransform(\u9501\u7F29\u653E)")]
	[ExecuteAlways]
	public class VFXLockTransform : MonoBehaviour // TypeDefIndex: 57503
	{
		// Constructors
		public VFXLockTransform(); // 0x0000000185393520-0x0000000185393538
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 57504
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 57649
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D7A3D0-0x0000000184D7A410
	
		// Methods
		public float __Gen_Wrap_0(object P0); // 0x00000001866C0730-0x00000001866C0800
		public void __Gen_Wrap_1(object P0); // 0x00000001863633B4-0x0000000186363474
		public bool __Gen_Wrap_2(object P0, int P1, int P2); // 0x0000000189CA9454-0x0000000189CA9544
		public Vector2Int __Gen_Wrap_3(object P0, int P1, int P2); // 0x000000018A9C2474-0x000000018A9C2568
		public bool __Gen_Wrap_4(object P0, Vector3 P1, ref Vector2Int P2); // 0x000000018A9C2568-0x000000018A9C26B0
		public void __Gen_Wrap_5(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public void __Gen_Wrap_6(object P0, object P1, ref Texture2D P2, float P3); // 0x000000018A9C26B0-0x000000018A9C27D4
		public void __Gen_Wrap_7(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public void __Gen_Wrap_8(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_9(object P0, Vector4 P1, Vector4 P2); // 0x000000018A9C27D4-0x000000018A9C28EC
		public void __Gen_Wrap_10(object P0, Vector4 P1); // 0x000000018A9C1378-0x000000018A9C1470
		public void __Gen_Wrap_11(object P0, float P1, float P2, float P3); // 0x000000018A9C1470-0x000000018A9C157C
		public void __Gen_Wrap_12(object P0, float P1, float P2); // 0x000000018A9C157C-0x000000018A9C1664
		public void __Gen_Wrap_13(object P0, float P1, float P2, float P3, float P4); // 0x0000000189CD8CC0-0x0000000189CD8DD4
		public string __Gen_Wrap_14(object P0); // 0x0000000186366CB0-0x0000000186366D84
		public void __Gen_Wrap_15(); // 0x00000001863625A4-0x0000000186362640
		public string __Gen_Wrap_16(RootCategory P0); // 0x000000018A9C1664-0x000000018A9C1724
		public string __Gen_Wrap_17(RootCategory P0, bool P1); // 0x000000018A9C1724-0x000000018A9C1800
		public string __Gen_Wrap_18(); // 0x000000018A9C1800-0x000000018A9C18B0
		public bool __Gen_Wrap_19(); // 0x00000001863623A8-0x0000000186362454
		public string __Gen_Wrap_20(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3); // 0x000000018A9C18B0-0x000000018A9C19B8
		public string __Gen_Wrap_21(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3, object P4); // 0x000000018A9C19B8-0x000000018A9C1AD0
		public long __Gen_Wrap_22(); // 0x000000018635FE78-0x000000018635FF24
		public bool __Gen_Wrap_23(object P0, object P1, object P2, object P3, object P4, object P5); // 0x000000018A9C1AD0-0x000000018A9C1C08
		public bool __Gen_Wrap_24(object P0, out string P1); // 0x000000018A9C1C08-0x000000018A9C1D24
		public bool __Gen_Wrap_25(object P0); // 0x00000001863632E4-0x00000001863633B4
		public void __Gen_Wrap_26(ShaderWarmupManager.WarmUpReason P0); // 0x0000000186301ED4-0x0000000186301F80
		public string __Gen_Wrap_27(IntPtr P0, ref WindowsGpuDriverVersion.SP_DEVINFO_DATA P1, uint P2); // 0x000000018A9C1D24-0x000000018A9C1E84
		public bool __Gen_Wrap_28(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public int __Gen_Wrap_29(object P0, object P1, object P2); // 0x000000018A9C1E84-0x000000018A9C1F8C
		public string __Gen_Wrap_30(object P0, object P1); // 0x0000000186366900-0x00000001863669F0
		public int __Gen_Wrap_31(WindowsGpuDriverVersion.Result P0, WindowsGpuDriverVersion.Result P1); // 0x00000001871AD678-0x00000001871AD750
		public List<WindowsGpuDriverVersion.Result> __Gen_Wrap_32(); // 0x000000018A9C1F8C-0x000000018A9C203C
		public void __Gen_Wrap_33(int P0); // 0x000000018635FF24-0x000000018635FFE4
		public WindowsGpuDriverVersion.Result __Gen_Wrap_34(); // 0x000000018A9C203C-0x000000018A9C20EC
		public bool __Gen_Wrap_35(object P0, object P1, out string P2); // 0x000000018A9C20EC-0x000000018A9C2220
		public bool __Gen_Wrap_36(bool P0); // 0x0000000186363D30-0x0000000186363E00
		public IEnumerator __Gen_Wrap_37(); // 0x000000018A9C2220-0x000000018A9C22BC
		public List<StringPathHash> __Gen_Wrap_38(bool P0); // 0x000000018A9C22BC-0x000000018A9C237C
		public IEnumerator __Gen_Wrap_39(object P0, object P1, object P2); // 0x000000018A9C237C-0x000000018A9C2474
		public int __Gen_Wrap_40(object P0, int P1, int P2); // 0x00000001871AFE44-0x00000001871AFF34
		public void __Gen_Wrap_41(object P0, bool P1, bool P2); // 0x0000000181282570-0x0000000181282870
		public int __Gen_Wrap_42(); // 0x00000001812B9870-0x00000001812B9A40
		public void __Gen_Wrap_43(int P0, ref int P1); // 0x0000000182E762E0-0x0000000182E76510
		public IEnumerator __Gen_Wrap_44(object P0, int P1, int P2, object P3); // 0x0000000182E76510-0x0000000182E76C70
		public IEnumerator __Gen_Wrap_45(bool P0); // 0x0000000182E76C70-0x0000000182E77220
		public IEnumerator __Gen_Wrap_46(object P0, int P1, int P2); // 0x0000000182E77220-0x0000000182E778C0
		public IEnumerator __Gen_Wrap_47(object P0); // 0x0000000182E778C0-0x0000000182E77F20
		public bool __Gen_Wrap_48(ref SceneStateAreaKey P0, SceneStateAreaKey P1); // 0x0000000182E77F20-0x0000000182E78660
		public bool __Gen_Wrap_49(ref SceneStateAreaKey P0, object P1); // 0x0000000182E78660-0x0000000182E78D80
		public int __Gen_Wrap_50(ref SceneStateAreaKey P0); // 0x0000000182E78D80-0x0000000182E793C0
		public bool __Gen_Wrap_51(object P0, bool P1); // 0x00000001812B6D00-0x00000001812B6FF0
		public bool __Gen_Wrap_52(object P0, float P1, int P2); // 0x0000000182E793C0-0x0000000182E796E0
		public Dictionary<int, float> __Gen_Wrap_53(object P0); // 0x0000000182E796E0-0x0000000182E79D50
		public void __Gen_Wrap_54(object P0, object P1); // 0x0000000182E79D50-0x0000000182E7A100
		public EntityRenderCapturedEntity __Gen_Wrap_55(object P0, object P1, EntityVFXRendererMask P2); // 0x0000000182E7A100-0x0000000182E7A840
		public int __Gen_Wrap_56(object P0); // 0x000000018125D2B0-0x000000018125D570
		public EntityVFXRendererMask __Gen_Wrap_57(EntityVFXRendererType P0); // 0x000000018127B070-0x000000018127B270
		public void __Gen_Wrap_58(object P0, object P1, object P2); // 0x0000000182E7A840-0x0000000182E7ACD0
		public bool __Gen_Wrap_59(object P0, object P1, object P2); // 0x0000000181416100-0x00000001814165A0
		public void __Gen_Wrap_60(object P0, object P1, object P2, object P3, bool P4); // 0x0000000181CB9BE0-0x0000000181CBA170
		public Material[] __Gen_Wrap_61(object P0); // 0x0000000182E7ACD0-0x0000000182E7B340
		public bool __Gen_Wrap_62(ref AddMaterialConfig P0); // 0x0000000182E7B340-0x0000000182E7BA00
		public Material __Gen_Wrap_63(object P0, EntityRenderHelperMaterialController.AddedMaterialInfo P1, object P2); // 0x0000000182E7BA00-0x0000000182E7C270
		public bool __Gen_Wrap_64(object P0, Vector4 P1); // 0x0000000182E7C270-0x0000000182E7C640
		public Texture __Gen_Wrap_65(object P0, object P1); // 0x0000000182E7C640-0x0000000182E7CDA0
		public int __Gen_Wrap_66(object P0, object P1, EntityVFXRendererMask P2, AddMaterialConfig P3); // 0x0000000182E7CDA0-0x0000000182E7D280
		public List<EntityRenderHelperMaterialController.RendererInfo> __Gen_Wrap_67(object P0, EntityVFXRendererMask P1, bool P2); // 0x0000000182E7D280-0x0000000182E7D940
		public void __Gen_Wrap_68(object P0, int P1, float P2); // 0x00000001819531C0-0x00000001819534D0
		public float __Gen_Wrap_69(object P0, int P1, float P2); // 0x0000000182474C00-0x0000000182474F00
		public void __Gen_Wrap_70(object P0, int P1, Vector4 P2); // 0x0000000182E7D940-0x0000000182E7DD20
		public Vector4 __Gen_Wrap_71(object P0, int P1, Vector4 P2); // 0x0000000182E7DD20-0x0000000182E7E470
		public void __Gen_Wrap_72(object P0, int P1, object P2); // 0x00000001811C8780-0x00000001811C8B50
		public Texture __Gen_Wrap_73(object P0, int P1, object P2); // 0x0000000182E7E470-0x0000000182E7EBB0
		public EntityVFXRendererMask __Gen_Wrap_74(object P0, int P1); // 0x00000001812F6B10-0x00000001812F6E00
		public bool __Gen_Wrap_75(object P0, int P1, object P2); // 0x00000001819DF960-0x00000001819DFD40
		public void __Gen_Wrap_76(object P0, int P1, EntityVFXRendererMask P2); // 0x000000018128FA90-0x000000018128FD80
		public void __Gen_Wrap_77(object P0, EntityVFXRendererMask P1, object P2); // 0x00000001811C8780-0x00000001811C8B50
		public void __Gen_Wrap_78(object P0, object P1, bool P2, EntityVFXRendererMask P3); // 0x0000000181847510-0x00000001818478F0
		public void __Gen_Wrap_79(object P0, bool P1, EntityVFXRendererMask P2); // 0x0000000181921E20-0x0000000181922110
		public float __Gen_Wrap_80(object P0, float P1, float P2, int P3); // 0x0000000182E7EBB0-0x0000000182E7EF00
		public void __Gen_Wrap_81(object P0, EntityRenderHelperCustomPerDrawType P1, float P2, EntityVFXRendererMask P3); // 0x0000000181753E10-0x0000000181754140
		public void __Gen_Wrap_82(object P0, EntityRenderHelperVectorCustomPerDrawType P1, Vector4 P2, EntityVFXRendererMask P3); // 0x0000000182E7EF00-0x0000000182E7F2E0
		public void __Gen_Wrap_83(object P0, int P1, float P2, EntityVFXRendererMask P3); // 0x0000000181753E10-0x0000000181754140
		public void __Gen_Wrap_84(object P0, int P1, Vector4 P2, EntityVFXRendererMask P3); // 0x0000000182E7F2E0-0x0000000182E7F6E0
		public void __Gen_Wrap_85(object P0, int P1, object P2, EntityVFXRendererMask P3); // 0x0000000181E4DC00-0x0000000181E4DFF0
		public bool __Gen_Wrap_86(object P0, float P1); // 0x00000001817F4E90-0x00000001817F5190
		public bool __Gen_Wrap_87(object P0, bool P1, ref bool P2); // 0x0000000182E7F6E0-0x0000000182E7FA30
		public bool __Gen_Wrap_88(object P0, out Vector3 P1); // 0x0000000182E7FA30-0x0000000182E80100
		public bool __Gen_Wrap_89(object P0, out Bounds P1); // 0x0000000182E80100-0x0000000182E807D0
		public bool __Gen_Wrap_90(object P0, ref Bounds P1); // 0x0000000182E807D0-0x0000000182E80F40
		public Bounds __Gen_Wrap_91(object P0); // 0x0000000182E80F40-0x0000000182E81570
		public void __Gen_Wrap_92(object P0, object P1, bool P2); // 0x00000001812C0160-0x00000001812C0520
		public RenderHelperType __Gen_Wrap_93(object P0); // 0x000000018125D2B0-0x000000018125D570
		public bool __Gen_Wrap_94(object P0, object P1, bool P2, out EntityRenderHelperVisibleController.RendererInfo P3); // 0x0000000182E81570-0x0000000182E81D70
		public List<EntityRendererTypeConfig> __Gen_Wrap_95(object P0, bool P1); // 0x0000000182E81D70-0x0000000182E82400
		public float __Gen_Wrap_96(object P0, bool P1); // 0x00000001817AD6A0-0x00000001817AD990
		public EntityVFXPriorityType __Gen_Wrap_97(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public EntityVFXRendererMask __Gen_Wrap_98(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public void __Gen_Wrap_99(object P0, float P1, bool P2); // 0x0000000182E82400-0x0000000182E85650
		public Material __Gen_Wrap_100(object P0, object P1, object P2); // 0x0000000182E65CB0-0x0000000182E664B0
		public bool __Gen_Wrap_101(EntityVFXFactoryAddedMaterialManager.AddedMaterialData P0); // 0x0000000181738AF0-0x0000000181738DC0
		public void __Gen_Wrap_102(object P0, object P1, int P2, float P3); // 0x0000000182214660-0x0000000182214A10
		public void __Gen_Wrap_103(object P0, object P1, int P2, Vector4 P3); // 0x0000000182E664B0-0x0000000182E66940
		public Material __Gen_Wrap_104(object P0, object P1, Vector4 P2); // 0x0000000182E66940-0x0000000182E67150
		public ValueTuple<float, float> __Gen_Wrap_105(Bounds P0, Vector3 P1); // 0x0000000182E67150-0x0000000182E67880
		public void __Gen_Wrap_106(object P0, bool P1, Vector3 P2, bool P3, float P4, out float P5, out float P6, out Vector3 P7); // 0x0000000182E67880-0x0000000182E681B0
		public EntityVFXCurveEvaluateResult __Gen_Wrap_107(object P0, float P1); // 0x0000000182E681B0-0x0000000182E68830
		public void __Gen_Wrap_108(object P0, object P1, float P2); // 0x0000000182E68830-0x0000000182E68C00
		public void __Gen_Wrap_109(object P0, float P1, object P2, object P3); // 0x000000018259F9D0-0x000000018259FE40
		public void __Gen_Wrap_110(object P0, object P1, object P2, bool P3); // 0x0000000181527A20-0x0000000181527E90
		public PsoCreateUploadHelper __Gen_Wrap_111(); // 0x0000000182E68C00-0x0000000182E69160
		public void __Gen_Wrap_112(object P0, HGPsoExtInfo P1); // 0x0000000182E69160-0x0000000182E69500
		public void __Gen_Wrap_113(bool P0); // 0x00000001811C7C80-0x00000001811C7E70
		public void __Gen_Wrap_114(object P0, object P1, object P2, object P3); // 0x0000000182CBB8F0-0x0000000182CBBE10
		public void __Gen_Wrap_115(float P0); // 0x000000018181A080-0x000000018181A270
		public void __Gen_Wrap_116(object P0, in EventData<string, string> P1); // 0x0000000182E69500-0x0000000182E698D0
		public void __Gen_Wrap_117(bool P0, object P1, object P2); // 0x0000000182E698D0-0x0000000182E69C70
		public List<Vector3> __Gen_Wrap_118(object P0, float P1, int P2); // 0x0000000182E69C70-0x0000000182E6A320
		public Vector3 __Gen_Wrap_119(object P0, Vector2Int P1); // 0x0000000182E6A320-0x0000000182E6AA30
		public List<Vector3> __Gen_Wrap_120(object P0, Vector3 P1); // 0x0000000182E6AA30-0x0000000182E6B180
		public Vector2Int __Gen_Wrap_121(object P0, Vector3 P1); // 0x0000000182E6B180-0x0000000182E6B890
		public int __Gen_Wrap_122(int P0, int P1, int P2); // 0x0000000181F50410-0x0000000181F50640
		public void __Gen_Wrap_123(int P0, int P1); // 0x00000001817F2A10-0x00000001817F2C10
		public void __Gen_Wrap_124(int P0, int P1, int P2, int P3, object P4); // 0x0000000182E6B890-0x0000000182E6BBB0
		public UnityEngine.Color __Gen_Wrap_125(object P0, int P1, int P2); // 0x0000000182E6BBB0-0x0000000182E6C200
		public float[] __Gen_Wrap_126(int P0, float P1); // 0x0000000182E6C200-0x0000000182E6C7E0
		public float[,] __Gen_Wrap_127(object P0, object P1, Vector2Int P2); // 0x0000000182E6C7E0-0x0000000182E6CFF0
		public void __Gen_Wrap_128(Bounds P0, object P1, out Vector3 P2, out Vector3 P3, Vector3? P4); // 0x0000000182E6CFF0-0x0000000182E6DB70
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_129(Vector3 P0, Vector3 P1); // 0x0000000182E6DB70-0x0000000182E6E2B0
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_130(Vector3 P0, float P1); // 0x0000000182E6E2B0-0x0000000182E6E930
		public List<Vector3> __Gen_Wrap_131(object P0, float P1, int P2, bool P3, float P4); // 0x0000000182E6E930-0x0000000182E6F010
		public Vector3 __Gen_Wrap_132(ref VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P0, Vector3 P1); // 0x0000000182E6F010-0x0000000182E6FAE0
		public void __Gen_Wrap_133(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, out List<Vector2> P2, out List<float> P3, out float P4, out float P5, out float P6, out float P7); // 0x0000000182E6FAE0-0x0000000182E70730
		public int __Gen_Wrap_134(int P0, int P1); // 0x0000000181D41D40-0x0000000181D41F50
		public List<int> __Gen_Wrap_135(object P0); // 0x0000000182E70730-0x0000000182E70D90
		public float __Gen_Wrap_136(object P0, int P1, bool P2); // 0x0000000182E70D90-0x0000000182E71090
		public float __Gen_Wrap_137(Vector2 P0, Vector2 P1, Vector2 P2); // 0x0000000182E71090-0x0000000182E71560
		public List<int> __Gen_Wrap_138(object P0, bool P1, float P2, float P3, float P4); // 0x0000000182E71560-0x0000000182E71C50
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult __Gen_Wrap_139(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, float P2, int P3, bool P4, VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode P5, float P6, float P7, float P8); // 0x0000000182E71C50-0x0000000182E72480
		public List<Vector2> __Gen_Wrap_140(object P0, float P1, int P2, int P3, bool P4, bool P5); // 0x0000000182E72480-0x0000000182E72B80
		public List<Vector3> __Gen_Wrap_141(object P0, float P1, float P2, bool P3); // 0x0000000182E72B80-0x0000000182E73260
		public void __Gen_Wrap_142(object P0, ref List<Vector2> P1, int P2, bool P3, bool P4, bool P5); // 0x0000000182E73260-0x0000000182E73A70
		public List<Vector3> __Gen_Wrap_143(object P0, object P1, float P2); // 0x0000000182E73A70-0x0000000182E741D0
		public void __Gen_Wrap_144(object P0, object P1, object P2, object P3, int P4); // 0x0000000181294170-0x00000001812946A0
		public HGAddedMaterialController.OverlayLayer __Gen_Wrap_145(object P0); // 0x0000000182E741D0-0x0000000182E74840
		public int __Gen_Wrap_146(object P0, object P1); // 0x000000018137AF60-0x000000018137B310
		public HGMeshRendererData __Gen_Wrap_147(object P0); // 0x0000000182E74840-0x0000000182E74EA0
		public void __Gen_Wrap_148(object P0, object P1, object P2, object P3, object P4, object P5); // 0x0000000181293280-0x0000000181293930
		public void __Gen_Wrap_149(object P0, object P1, object P2, object P3, object P4); // 0x0000000181363040-0x0000000181363620
		public Material __Gen_Wrap_150(object P0, int P1); // 0x0000000182E74EA0-0x0000000182E75530
		public HGMeshRenderer __Gen_Wrap_151(object P0); // 0x0000000182E75530-0x0000000182E75B90
		public Bounds __Gen_Wrap_152(Bounds P0, Matrix4x4 P1); // 0x0000000182E75B90-0x0000000182E762E0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object>, IAsyncStateMachine // TypeDefIndex: 57650
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
		private int methodId_5; // 0x54
		private int methodId_6; // 0x58
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x000000018A9C6B24-0x000000018A9C6BB4 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x000000018A9C6BB4-0x000000018A9C6C44 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018A9C6C44-0x000000018A9C6D38
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x0000000186365FC0-0x000000018636603C
		[IDTag(1)]
		private bool MoveNext(); // 0x0000000186365D60-0x0000000186365DEC
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x0000000186365E98-0x0000000186365F14
		[IDTag(5)]
		private void MoveNext(); // 0x000000018A8A5D4C-0x000000018A8A5DDC
		[IDTag(6)]
		private void SetStateMachine(IAsyncStateMachine P0); // 0x000000018A8A5FAC-0x000000018A8A605C
		public void RefAwaitUnsafeOnCompleteMethod(); // 0x000000018A9C6AC0-0x000000018A9C6B24
		public void RefAsyncBuilderStartMethod(); // 0x000000018A9C6A98-0x000000018A9C6AC0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 57651
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018A9C6EB0-0x000000018A9C6F04
		public static bool IsPatched(int id); // 0x000000018302E240-0x000000018302E290
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018A9C6DC0-0x000000018A9C6E54
		public object CreateWrapper(int id); // 0x000000018A9C6E54-0x000000018A9C6EB0
		public object InitWrapperArray(int len); // 0x000000018A9C6F04-0x000000018A9C74C8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018A9C6D38-0x000000018A9C6DC0
	}

	public enum IDMAP0 // TypeDefIndex: 57652
	{
		HG-Rendering-Runtime-ContainerWaterManager-get_dy0 = 0,
		HG-Rendering-Runtime-ContainerWaterManager-Start0 = 1,
		HG-Rendering-Runtime-ContainerWaterManager-_InitializeWaveSystem0 = 2,
		HG-Rendering-Runtime-ContainerWaterManager-_PrecomputeCylinderMask0 = 3,
		HG-Rendering-Runtime-ContainerWaterManager-_UnifiedWaveStep0 = 4,
		HG-Rendering-Runtime-ContainerWaterManager-_ApplyReflectiveBoundary0 = 5,
		HG-Rendering-Runtime-ContainerWaterManager-_IsInsideCylinder0 = 6,
		HG-Rendering-Runtime-ContainerWaterManager-_ApplyAbsorptiveBoundary0 = 7,
		HG-Rendering-Runtime-ContainerWaterManager-_FindNearestInsidePoint0 = 8,
		HG-Rendering-Runtime-ContainerWaterManager-_WorldToTextureCoords0 = 9,
		HG-Rendering-Runtime-ContainerWaterManager-_IsValidPosition0 = 10,
		HG-Rendering-Runtime-ContainerWaterManager-_ApplyMatrixToTexture0 = 11,
		HG-Rendering-Runtime-ContainerWaterManager-_UpdateVortexState0 = 12,
		HG-Rendering-Runtime-ContainerWaterManager-ResetWaveTexture0 = 13,
		HG-Rendering-Runtime-ContainerWaterManager-Update0 = 14,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_LitDissolve0 = 15,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_HoudiniVAT0 = 16,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_MovingBamboo0 = 17,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveColor0 = 18,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveAlbedoColor0 = 19,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_SweepLightIntensity0 = 20,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_SweepBreathing0 = 21,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_UVAnimation0 = 22,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_CharacterParams0 = 23,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_VFXAlpha00 = 24,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_TrailDisplayArea0 = 25,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_TrailScanCircle0 = 26,
		Beyond-Rendering-PipelineSettingHelper-LoadPipelineSettings0 = 27,
		Beyond-Rendering-PipelineSettingHelper-_GetFullSettingPath0 = 28,
		Beyond-Rendering-PipelineSettingHelper-_LoadSetting0 = 29,
		Beyond-Rendering-ResourceRouter-_GetCategoryFolder0 = 30,
		Beyond-Rendering-ResourceRouter-GetEnvironmentsFullPath0 = 31,
		Beyond-Rendering-ResourceRouter-GetDecalResourcesPath0 = 32,
		Beyond-Rendering-ResourceRouter-GetDecalResourcesFullPath0 = 33,
		Beyond-Rendering-ShaderWarmupManager-get_isWarming0 = 34,
		Beyond-Rendering-ShaderWarmupManager-GetPsoPathName0 = 35,
		Beyond-Rendering-ShaderWarmupManager-GetPsoPathName1 = 36,
		Beyond-Rendering-ShaderWarmupManager-GetLoginWarmupDetail0 = 37,
		Beyond-Rendering-ShaderWarmupManager-_GetCacheFileSize0 = 38,
		Beyond-Rendering-ShaderWarmupManager-ProcessRemoteConfig0 = 39,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsDeviceInBlackList0 = 40,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-get_cpuNameForWarmUp0 = 41,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-_CheckDeviceMatch0 = 42,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsEnableDx11DriverVersionDetect0 = 43,
		Beyond-Rendering-ShaderWarmupManager-MarkNeedShaderWarmUp0 = 44,
		Beyond-Rendering-ShaderWarmupManager-MarkWarmUpLoginFinish0 = 45,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmupFinishAPI0 = 46,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmUpLoginFinish0 = 47,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmupDx11Driver0 = 48,
		Beyond-Rendering-WindowsGpuDriverVersion-GetAllDisplayDriverVersions0 = 49,
		Beyond-Rendering-WindowsGpuDriverVersion-_GetDeviceRegistryPropertyString0 = 50,
		Beyond-Rendering-WindowsGpuDriverVersion-_ScoreAgainstUnityCurrentGpu0 = 51,
		Beyond-Rendering-WindowsGpuDriverVersion-_ContainsIgnoreCase0 = 52,
		Beyond-Rendering-WindowsGpuDriverVersion-_GetDriverKeySuffix0 = 53,
		Beyond-Rendering-WindowsGpuDriverVersion-_ReadRegistrySz0 = 54,
		Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllResults0 = 58,
		Beyond-Rendering-ShaderWarmupManager-CleanLoadedPso0 = 59,
		Beyond-Rendering-ShaderWarmupManager-TryRepairPsoCacheAfterCorruptCheck0 = 60,
		Beyond-Rendering-ShaderWarmupManager-_TryDeleteVulkanPsoCacheFile0 = 61,
		Beyond-Rendering-ShaderWarmupManager-CheckNeedWarmUpLogin0 = 62,
		Beyond-Rendering-ShaderWarmupManager-_ResetWarmUpStatsIfNeed0 = 63,
		Beyond-Rendering-ShaderWarmupManager-_IsDeviceSupportWarmUp0 = 64,
		Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByFirstEntry0 = 65,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByGraphicsChange0 = 66,
		Beyond-Rendering-ShaderWarmupManager-_SetWarmupRetryCount0 = 67,
		Beyond-Rendering-ShaderWarmupManager-_SetWarmupUnfinishedCount0 = 68,
		Beyond-Rendering-ShaderWarmupManager-_CheckWarmUpUnfinishedOften0 = 69,
		Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByDeviceState0 = 70,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupDx11Driver0 = 71,
		Beyond-Rendering-WindowsGpuDriverVersion-IsBestMatchDriverVersionChanged0 = 72,
		Beyond-Rendering-WindowsGpuDriverVersion-GetBestMatch0 = 73,
		Beyond-Rendering-WindowsGpuDriverVersion-_TryGetDriverVersionByKeyId0 = 74,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByCacheOutdated0 = 75,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersLogin0 = 76,
		Beyond-Rendering-ShaderWarmupManager-_DisposeWarmupAssetHandles0 = 80,
		Beyond-Rendering-ShaderWarmupManager-_StopDownloadingWarmupAndWait0 = 82,
		Beyond-Rendering-ShaderWarmupManager-StopWarmupShadersDownloading0 = 86,
		Beyond-Rendering-ShaderWarmupManager-_BuildLoginWarmupPaths0 = 90,
		Beyond-Rendering-ShaderWarmupManager-_LoadPsoAssets0 = 91,
		Beyond-Rendering-ShaderWarmupManager-_InitWarmupStats0 = 98,
		Beyond-Rendering-ShaderWarmupManager-_GetBackgroundWarmupStartIndex0 = 99,
		Beyond-Rendering-ShaderWarmupManager-_GetCompileCountForRange0 = 100,
		Beyond-Rendering-ShaderWarmupManager-_GetLoginTimeLimit0 = 101,
		Beyond-Rendering-ShaderWarmupManager-_WarmupOnePsoTimeLimited0 = 102,
		Beyond-Rendering-ShaderWarmupManager-_GetWarmupEndIndexExclusive0 = 106,
		Beyond-Rendering-PsoCreateUploadHelper-BeforeWarmUpBegin0 = 107,
		Beyond-Rendering-PsoCreateUploadHelper-IsPsoRecordEnabled0 = 108,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Tick0 = 109,
		Beyond-Rendering-ShaderWarmupManager-_StepProgress0 = 112,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-get_isTimeOut0 = 113,
		Beyond-Rendering-PsoCreateUploadHelper-AfterWarmUpFinish0 = 114,
		Beyond-Rendering-ShaderWarmupManager-_SetDownloadingWarmupUnfinishedCount0 = 118,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersDownloading0 = 122,
		Beyond-Rendering-ShaderWarmupManager-_UpdateDownloadWarmupPercent0 = 126,
		Beyond-Rendering-ShaderWarmupManager-_IsDeviceSupportDownloadWarmUp0 = 128,
		Beyond-Rendering-ShaderWarmupManager-_GetDownloadingWarmupUnfinishedCount0 = 129,
		Beyond-Rendering-ShaderWarmupManager-_WarmupOnePsoBackgroundOnly0 = 130,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersScene0 = 140,
		Beyond-Rendering-ShaderWarmupManager-WarmupOnePso0 = 144,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Begin0 = 154,
		Beyond-Rendering-WindowsGpuDriverVersion-GetCurrentDriverVersion0 = 155,
		Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllCurrentResults0 = 156,
		Beyond-Rendering-WindowsGpuDriverVersion-Result-ToString0 = 157,
		Beyond-Rendering-WindowsGpuDriverVersion-SafeRegistryHandle-ReleaseHandle0 = 158,
		Beyond-Rendering-SceneStateAreaKey-Equals0 = 159,
		Beyond-Rendering-SceneStateAreaKey-Equals1 = 160,
		Beyond-Rendering-SceneStateAreaKey-GetHashCode0 = 161,
		Beyond-Rendering-EntityRenderAlphaDitherController-ResetDitherAlpha0 = 162,
		Beyond-Rendering-EntityRenderAlphaDitherController-_ApplyNewAlpha0 = 163,
		Beyond-Rendering-EntityRenderAlphaDitherController-_GetCurMinAlpha0 = 164,
		Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherEnabled0 = 165,
		Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherAlpha0 = 166,
		Beyond-Rendering-EntityRenderAlphaDitherController-SetDitherAlpha0 = 167,
		Beyond-Rendering-EntityRenderAlphaDitherController-GetDitherAlpha0 = 168,
		Beyond-Rendering-EntityRenderAlphaDitherController-Reset0 = 169,
		Beyond-Rendering-EntityRenderAlphaDitherController-GetAlphaDictionary0 = 170,
		Beyond-Rendering-EntityRenderCaptureMeshController-Reset0 = 171,
		Beyond-Rendering-EntityRenderCaptureMeshController-Release0 = 172,
		Beyond-Rendering-EntityRenderCaptureMeshController-LateTick0 = 173,
		Beyond-Rendering-EntityRenderCaptureMeshController-_SyncTransformInRenderPipeline0 = 174,
		Beyond-Rendering-EntityRenderCaptureMeshController-InitRendererTypeMasks0 = 175,
		Beyond-Rendering-EntityRenderCaptureMeshController-Capture0 = 176,
		Beyond-Rendering-EntityRenderHelperMaterialController-Init0 = 177,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryInit0 = 178,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-_Init0 = 179,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-_GetSubMeshCount0 = 180,
		Beyond-Rendering-EntityVFXUtils-ToMask0 = 181,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Init0 = 182,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Init0 = 183,
		Beyond-Rendering-EntityRenderHelperMaterialController-OnRelease0 = 184,
		Beyond-Rendering-EntityRenderHelperMaterialController-Reset0 = 185,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Reset0 = 186,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-ApplySharedMaterialArray0 = 187,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryBeginMaterialUpdate0 = 188,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-get_rendererValid0 = 189,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-get_currentMeshMaterials0 = 190,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetSharedMaterials0 = 191,
		Beyond-Rendering-AddMaterialConfig-get_useCustomizeProperty0 = 192,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_GetCustomizePropertyMaterial0 = 193,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Reset0 = 194,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReleaseAllReplaceMaterial0 = 195,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReplaceSharedMaterial0 = 196,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryReplaceSharedMaterials0 = 197,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-Clear0 = 198,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Reset0 = 199,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetCharacterPerDrawData0 = 200,
		Beyond-Rendering-EntityRenderHelperMaterialController-IsAllRendererValid0 = 201,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-IsRendererValid0 = 202,
		Beyond-Rendering-EntityRenderHelperMaterialController-StopShadowCasting0 = 203,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryStopShadowCasting0 = 204,
		Beyond-Rendering-EntityRenderHelperMaterialController-RevertShadowCastingMode0 = 205,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryRevertShadowCastingMode0 = 206,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddMaterialToAllRenderer0 = 207,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireAddMaterial0 = 208,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_InitCustomizeRendererProperty0 = 209,
		Beyond-Rendering-EntityCustomizeRendererPropertyConfig-GetColorTexture0 = 210,
		Beyond-Rendering-EntityRenderHelperMaterialController-_GetRenderersOfRendererMask0 = 211,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveFloatProperty0 = 212,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveFloatProperty0 = 213,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveFloatProperty0 = 214,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveFloatProperty0 = 215,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveVectorProperty0 = 216,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveVectorProperty0 = 217,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveVectorProperty0 = 218,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveVectorProperty0 = 219,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveTextureProperty0 = 220,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveTextureProperty0 = 221,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveTextureProperty0 = 222,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveTextureProperty0 = 223,
		Beyond-Rendering-EntityRenderHelperMaterialController-RemoveMaterialFromAllRenderer0 = 224,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireRemoveMaterial0 = 225,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 226,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 227,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetKeywordEnableToAllMaterial0 = 228,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetKeywordEnableToAllMaterial0 = 229,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_GetAffectGroupData0 = 230,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_SplitRenderers0 = 231,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-CopyFrom0 = 232,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CopyReplaceMaterial0 = 233,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-get_rendererName0 = 234,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_TryEnsureReplaceMaterial0 = 235,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CreateReplaceMaterial0 = 236,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetSharedMaterial0 = 237,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 238,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 239,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToCustomPerDraw0 = 240,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Init0 = 241,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetFloatToCustomPerDraw0 = 242,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-_PackUNorm8ToFloat0 = 243,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToCustomPerDraw0 = 244,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetVectorToCustomPerDraw0 = 245,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetEmissiveColor0 = 246,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToAllMaterial0 = 247,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetFloatToAllMaterial0 = 248,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToAllMaterial0 = 249,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetVectorToAllMaterial0 = 250,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetTextureToAllMaterial0 = 251,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetTextureToAllMaterial0 = 252,
		Beyond-Rendering-EntityRenderHelperMaterialController-FillRendererTypeMasks0 = 253,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryFillRendererTypeMask0 = 254,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherAlphaValue0 = 255,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetManualDitherAlphaValue0 = 256,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherEnable0 = 257,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetManualDitherEnable0 = 258,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetRendererBounds0 = 259,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryGetRendererPosition0 = 260,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryGetRendererBounds0 = 261,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryEncapsulateBounds0 = 262,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetZTestInMaterial0 = 263,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetZTestInMaterial0 = 264,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetRenderHelperType0 = 265,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseFloatToAllMaterial0 = 266,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseVectorToAllMaterial0 = 267,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseTextureToAllMaterial0 = 268,
		Beyond-Rendering-EntityRenderHelperVisibleController-Init0 = 269,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TryInit0 = 270,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-_Init0 = 271,
		Beyond-Rendering-EntityRenderHelperVisibleController-_InitDictionary0 = 273,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TryAddToDictionary0 = 274,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-get_rendererValid0 = 275,
		Beyond-Rendering-EntityRenderHelperVisibleController-_TryGetRendererInfo0 = 276,
		Beyond-Rendering-EntityRenderHelperVisibleController-Release0 = 277,
		Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByNameContainsStr0 = 278,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TrySetVisible0 = 280,
		Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByRenderer0 = 281,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TrySetVisibleByRenderer0 = 282,
		Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByNameContainsStr0 = 283,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TryResetVisible0 = 284,
		Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByRenderer0 = 285,
		Beyond-Rendering-EntityRenderHelperVisibleController-Reset0 = 286,
		Beyond-Rendering-EntityRenderMaterialManager-SetFloat0 = 287,
		Beyond-Rendering-EntityRenderMaterialManager-SetTexture0 = 288,
		Beyond-Rendering-EntityRenderMaterialManager-SetVector0 = 289,
		Beyond-Rendering-EntityRenderMaterialManager-AddMaterial0 = 290,
		Beyond-Rendering-EntityRenderMaterialManager-RemoveMaterial0 = 291,
		Beyond-Rendering-EntityRenderMaterialManager-_RevertMaterial0 = 292,
		Beyond-Rendering-EntityRenderMaterialManager-ClearMaterials0 = 293,
		Beyond-Rendering-EntityRenderMaterialManager-SetKeywordEnable0 = 294,
		Beyond-Rendering-EntityRenderMaterialManager-SetDepthOnlyEnabled0 = 295,
		Beyond-Rendering-EntityRenderMaterialManager-SetZTestInMaterial0 = 296,
		Beyond-Rendering-EntityVFXAsset-GetRendererTypeConfigs0 = 297,
		Beyond-Rendering-EntityVFXAssetBase-get_assetName0 = 298,
		Beyond-Rendering-EntityVFXControllerBase-get_isPlaying0 = 299,
		Beyond-Rendering-EntityVFXControllerBase-get_isStopping0 = 300,
		Beyond-Rendering-EntityVFXControllerBase-get_isHiding0 = 301,
		Beyond-Rendering-EntityVFXControllerBase-get_isKeyword0 = 302,
		Beyond-Rendering-EntityVFXControllerBase-get_vfxName0 = 303,
		Beyond-Rendering-EntityVFXControllerBase-get_destroyTime0 = 304,
		Beyond-Rendering-EntityVFXControllerBase-set_destroyTime0 = 305,
		Beyond-Rendering-EntityVFXControllerBase-get_lastTickTime0 = 306,
		Beyond-Rendering-EntityVFXControllerBase-set_lastTickTime0 = 307,
		Beyond-Rendering-EntityVFXControllerBase-SetOwner0 = 308,
		Beyond-Rendering-EntityVFXControllerBase-InitLOD0 = 309,
		Beyond-Rendering-EntityVFXControllerBase-SetName0 = 310,
		Beyond-Rendering-EntityVFXControllerBase-Destroy0 = 311,
		Beyond-Rendering-EntityVFXControllerBase-Stop0 = 312,
		Beyond-Rendering-EntityVFXControllerBase-OnDestroy0 = 313,
		Beyond-Rendering-EntityVFXControllerBase-Play0 = 314,
		Beyond-Rendering-EntityVFXControllerBase-Replay0 = 315,
		Beyond-Rendering-EntityVFXControllerBase-Tick0 = 316,
		Beyond-Rendering-EntityVFXControllerBase-RefreshLastTickTime0 = 317,
		Beyond-Rendering-EntityVFXControllerBase-GetDeltaTimeFromLastTick0 = 318,
		Beyond-Rendering-EntityVFXControllerBase-GetPriorityType0 = 319,
		Beyond-Rendering-EntityVFXControllerBase-GetRendererMask0 = 320,
		Beyond-Rendering-EntityVFXControllerBase-GetAllowSimultaneousKeyword0 = 321,
		Beyond-Rendering-EntityVFXControllerBase-GetNeedTick0 = 322,
		Beyond-Rendering-EntityVFXControllerBase-Hide0 = 323,
		Beyond-Rendering-EntityVFXControllerBase-OnHide0 = 324,
		Beyond-Rendering-EntityVFXControllerBase-Show0 = 325,
		Beyond-Rendering-EntityVFXControllerBase-OnShow0 = 326,
		Beyond-Rendering-EntityVFXControllerBase-Sample0 = 327,
		Beyond-Rendering-EntityVFXControllerBase-OnSample0 = 328,
		Beyond-Rendering-EntityVFXControllerStateBase-get_isStopping0 = 329,
		Beyond-Rendering-EntityVFXControllerStateBase-Play0 = 330,
		Beyond-Rendering-EntityVFXControllerStateBase-Replay0 = 334,
		Beyond-Rendering-EntityVFXControllerStateBase-Stop0 = 335,
		Beyond-Rendering-EntityVFXControllerStateBase-_FinalStop0 = 336,
		Beyond-Rendering-EntityVFXControllerStateBase-get_useEndCurve0 = 337,
		Beyond-Rendering-EntityVFXControllerStateBase-get_endDuration0 = 338,
		Beyond-Rendering-EntityVFXControllerStateBase-GetNeedTick0 = 339,
		Beyond-Rendering-EntityVFXControllerStateBase-get_useLoopCurve0 = 340,
		Beyond-Rendering-EntityVFXControllerStateBase-Tick0 = 341,
		Beyond-Rendering-EntityVFXControllerStateBase-get_useScaledTime0 = 342,
		Beyond-Rendering-EntityVFXControllerStateBase-get_duration0 = 344,
		Beyond-Rendering-EntityVFXControllerStateBase-get_loop0 = 345,
		Beyond-Rendering-EntityVFXControllerStateBase-get_useStartCurve0 = 346,
		Beyond-Rendering-EntityVFXControllerStateBase-get_loopDuration0 = 347,
		Beyond-Rendering-EntityVFXControllerStateBase-OnSample0 = 350,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-Init0 = 351,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_AddVATMaterial0 = 352,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetVATMaterial0 = 353,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetAddedMaterialIndex0 = 354,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_RemoveVATMaterial0 = 357,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-AddMaterialToAllRenderer0 = 360,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-RemoveMaterialFromAllRenderer0 = 361,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetFloatToFactoryMaterial0 = 362,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetVectorToFactoryMaterial0 = 363,
		Beyond-Rendering-EntityVFXFactoryMaterialCache-GetVATMaterial0 = 364,
		Beyond-Rendering-EntityVFXFactoryMaterialCache-ReleaseVATMaterial0 = 365,
		Beyond-Rendering-EntityVFXUtils-CalculateCutOffBounds0 = 366,
		Beyond-Rendering-EntityVFXUtils-GetBoundsMinMaxOfDirection0 = 367,
		Beyond-Rendering-EntityVFXUtils-ApplyEntityVFXCurves0 = 368,
		Beyond-Rendering-EntityVFXUtils-_UpdateCurve0 = 369,
		Beyond-Rendering-EntityVFXUtils-Evaluate0 = 370,
		Beyond-Rendering-CommonVAT-get_PropertySetterType0 = 371,
		Beyond-Rendering-CommonVAT-Start0 = 372,
		Beyond-Rendering-CommonVAT-Play0 = 373,
		Beyond-Rendering-CommonVAT-_DoPlay0 = 374,
		Beyond-Rendering-CommonVAT-_ClearTimer0 = 375,
		Beyond-Rendering-CommonVAT-_UpdateProperty0 = 376,
		Beyond-Rendering-CommonVAT-_NextPlay0 = 377,
		Beyond-Rendering-CommonVAT-_CreateTimer0 = 378,
		Beyond-Rendering-FactoryVAT-Start0 = 379,
		Beyond-Rendering-FactoryVAT-_InitRenderer0 = 380,
		Beyond-Rendering-FactoryVAT-_InitRenderer_MeshRender0 = 381,
		Beyond-Rendering-FactoryVAT-Reset0 = 382,
		Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer0 = 383,
		Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer_MeshRender0 = 384,
		Beyond-Rendering-FactoryVAT-_UpdateAnim0 = 385,
		Beyond-Rendering-FactoryVAT-_SetParamsToRenderer0 = 386,
		Beyond-Rendering-FactoryVAT-_SetParamsToRenderer_MeshRender0 = 387,
		Beyond-Rendering-FactoryVAT-_DoPlay0 = 388,
		Beyond-Rendering-FactoryVAT-OnUpdate0 = 389,
		Beyond-Rendering-FactoryVAT-Play0 = 390,
		Beyond-Rendering-VATRendererPropertySetter-Init0 = 391,
		Beyond-Rendering-VATRendererPropertySetter-SetFloat0 = 392,
		Beyond-Rendering-VATRendererPropertySetter-SetVector0 = 393,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-Init0 = 394,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetFloat0 = 395,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetVector0 = 396,
		Beyond-Rendering-PsoCreateUploadHelper-get_instance0 = 397,
		Beyond-Rendering-PsoCreateUploadHelper-get_persistentDataPath0 = 398,
		Beyond-Rendering-PsoCreateUploadHelper-Initialize0 = 399,
		Beyond-Rendering-PsoCreateUploadHelper-_PsoUploadProcessOneCallBack0 = 400,
		Beyond-Rendering-PsoCreateUploadHelper-_PsoUpdateGameInfoCallBack0 = 401,
		Beyond-Rendering-PsoCreateUploadHelper-Init0 = 402,
		Beyond-Rendering-PsoCreateUploadHelper-_Tick0 = 403,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadPipelineCreatedInfo0 = 404,
		Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFinalJson0 = 405,
		Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFileToServer0 = 408,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadFileToServer0 = 409,
		Beyond-Rendering-PsoCreateUploadHelper-_SceneLoadStartHandler0 = 417,
		Beyond-Rendering-PsoCreateUploadHelper-Dispose0 = 418,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadFile0 = 419,
		Beyond-Rendering-PsoCreateUploadHelper-_Callback0 = 422,
		Beyond-Rendering-VFXSludgeBaker-Bake0 = 423,
		Beyond-Rendering-VFXSludgeBaker-_CalculatePolygonAndBounds0 = 424,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSpline0 = 425,
		Beyond-Rendering-VFXSludgeBaker-_RaycastSceneObjectsHeight0 = 426,
		Beyond-Rendering-VFXSludgeBaker-GetLocalPosition0 = 427,
		Beyond-Rendering-VFXSludgeBaker-_CalculateInPolygon0 = 428,
		Beyond-Rendering-VFXSludgeUtils-CalculatePointPolygonHorizonRayCross0 = 429,
		Beyond-Rendering-VFXSludgeBaker-GetLocalIndex0 = 430,
		Beyond-Rendering-VFXSludgeBaker-_CalculateInHighPowerZone0 = 431,
		Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance1 = 432,
		Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance0 = 433,
		Beyond-Rendering-VFXSludgeBaker-_GetHash0 = 436,
		Beyond-Rendering-VFXSludgeBaker-_ForAround0 = 437,
		Beyond-Rendering-VFXSludgeBaker-_CalculateThicknessAndTopHeight0 = 440,
		Beyond-Rendering-VFXSludgeBaker-_BlurTopHeight0 = 441,
		Beyond-Rendering-VFXSludgeBaker-_CalculateNormals0 = 442,
		Beyond-Rendering-VFXSludgeBaker-_CreateTexture0 = 443,
		Beyond-Rendering-VFXSludgeBaker-_GetTextureColor10 = 444,
		Beyond-Rendering-VFXSludgeBaker-_CreateGaussianKernel0 = 445,
		Beyond-Rendering-VFXSludgeBaker-_Convolution0 = 446,
		Beyond-Rendering-VFXSludgeBaker-_GetHash1 = 447,
		Beyond-Rendering-VFXSludgeBaker-_GetTextureColor20 = 448,
		Beyond-Rendering-VFXSludgeNavUtils-BoundsUtil-GetTopBottomPoints0 = 449,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameFromPlaneNormal0 = 450,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameByYaw0 = 451,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-SampleUniformByArcLength0 = 452,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ProjectWorldToFrameXZ0 = 453,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-WorldToFrame0 = 454,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ConvexHullIndices0 = 455,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_AngleDegAt0 = 459,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_CurvatureAt0 = 460,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_PointToSegmentDistance2D0 = 461,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Simplify2D_ByCurvatureAngleDeviation0 = 462,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Process0 = 463,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-FrameToWorld0 = 464,
		Beyond-Rendering-VFXSludgeNavUtils-SplineSamplingUtils-SampleByArcLength0 = 465,
		Beyond-Rendering-VFXSludgeNavUtils-PolySimplify-SimplifyByAngle0 = 466,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSplineWithSimplify0 = 467,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffByPolyLine0 = 468,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_CreateInstance0 = 469,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_ExtractSplineData0 = 470,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_DestroyInstance0 = 471,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_Release0 = 472,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Update0 = 473,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnEnable0 = 474,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDisable0 = 475,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDestroy0 = 476,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDrawGizmosSelected0 = 477,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Pause0 = 478,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Play0 = 479,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Stop0 = 480,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-OnEnable0 = 481,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-Awake0 = 482,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-_RendererInfoTransfer0 = 483,
		Beyond-Rendering-LODLightmapping-LODLightmapping-RendererInfoTransfer0 = 484,
		Beyond-Rendering-ECS-HGAddedMaterialController-Init0 = 485,
		Beyond-Rendering-ECS-HGAddedMaterialController-RequireAddMaterial0 = 486,
		Beyond-Rendering-ECS-HGAddedMaterialController-_CreateNewLayer0 = 487,
		Beyond-Rendering-ECS-HGAddedMaterialController-RequireRemoveMaterial0 = 488,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetActiveOverlayRenderers0 = 489,
		Beyond-Rendering-ECS-HGAddedMaterialController-get_activeLayerCount0 = 490,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 491,
		Beyond-Rendering-ECS-HGAddedMaterialController-SetAddictiveFloatProperty0 = 492,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetAddictiveFloatProperty0 = 493,
		Beyond-Rendering-ECS-HGAddedMaterialController-SetAddictiveVectorProperty0 = 494,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetAddictiveVectorProperty0 = 495,
		Beyond-Rendering-ECS-HGAddedMaterialController-SetAddictiveTextureProperty0 = 496,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetAddictiveTextureProperty0 = 497,
		Beyond-Rendering-ECS-HGAddedMaterialController-Reset0 = 498,
		Beyond-Rendering-ECS-HGAddedMaterialController-Release0 = 499,
		Beyond-Rendering-ECS-HGAddedMaterialController-_DestroyLayer0 = 500,
		Beyond-Rendering-ECS-HGMaterialCommitter-get_clonedData0 = 501,
		Beyond-Rendering-ECS-HGMaterialCommitter-Init0 = 502,
		Beyond-Rendering-ECS-HGMaterialCommitter-MarkMaterialsArrayDirty0 = 503,
		Beyond-Rendering-ECS-HGMaterialCommitter-IsDirty0 = 504,
		Beyond-Rendering-ECS-HGMaterialCommitter-TryCommit0 = 505,
		Beyond-Rendering-ECS-HGMaterialCommitter-_Commit0 = 506,
		Beyond-Rendering-ECS-HGMaterialCommitter-ForceCommit0 = 507,
		Beyond-Rendering-ECS-HGMaterialCommitter-Reset0 = 508,
		Beyond-Rendering-ECS-HGMaterialCommitter-Release0 = 509,
		Beyond-Rendering-ECS-HGMaterialController-get_currentMeshMaterials0 = 510,
		Beyond-Rendering-ECS-HGMaterialController-Init0 = 511,
		Beyond-Rendering-ECS-HGMaterialController-_GetOrCreateInstancedMaterial0 = 512,
		Beyond-Rendering-ECS-HGMaterialController-_ApplyAllPropertiesToOneMaterial0 = 513,
		Beyond-Rendering-ECS-HGMaterialController-_ApplyDepthOnlyPassToMaterial0 = 514,
		Beyond-Rendering-ECS-HGMaterialController-SetFloatToAllMaterial0 = 515,
		Beyond-Rendering-ECS-HGMaterialController-SetVectorToAllMaterial0 = 516,
		Beyond-Rendering-ECS-HGMaterialController-SetTextureToAllMaterial0 = 517,
		Beyond-Rendering-ECS-HGMaterialController-SetKeywordEnableToAllMaterial0 = 518,
		Beyond-Rendering-ECS-HGMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 519,
		Beyond-Rendering-ECS-HGMaterialController-SetManualDitherEnable0 = 520,
		Beyond-Rendering-ECS-HGMaterialController-SetManualDitherAlphaValue0 = 521,
		Beyond-Rendering-ECS-HGMaterialController-ReplaceAllMaterials0 = 522,
		Beyond-Rendering-ECS-HGMaterialController-ReplaceMaterialBySource0 = 523,
		Beyond-Rendering-ECS-HGMaterialController-Reset0 = 524,
		Beyond-Rendering-ECS-HGMaterialController-Release0 = 525,
		Beyond-Rendering-ECS-HGRendererStateController-Init0 = 526,
		Beyond-Rendering-ECS-HGRendererStateController-IsValid0 = 527,
		Beyond-Rendering-ECS-HGRendererStateController-get_hgRenderer0 = 528,
		Beyond-Rendering-ECS-HGRendererStateController-SetVisible0 = 529,
		Beyond-Rendering-ECS-HGRendererStateController-Reset0 = 530,
		Beyond-Rendering-ECS-HGRendererStateController-GetBounds0 = 531,
		Beyond-Rendering-ECS-HGRendererStateController-_EnsureMeshLocalBoundsCached0 = 532,
		Beyond-Rendering-ECS-HGRendererStateController-_WarnNoMeshes0 = 533,
		Beyond-Rendering-ECS-HGRendererStateController-_LocalBoundsToWorld0 = 534,
		Beyond-Rendering-ECS-HGRendererStateController-InvalidateMeshCache0 = 535,
		Beyond-Rendering-ECS-HGRendererStateController-StopShadowCasting0 = 536,
		Beyond-Rendering-ECS-HGRendererStateController-RevertShadowCastingMode0 = 537,
		Beyond-Rendering-ECS-HGRendererStateController-Release0 = 538
	}
}
