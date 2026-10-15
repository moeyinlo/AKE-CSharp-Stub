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

// Image 32: Rendering.Beyond.dll - Assembly: Rendering.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 83853-84167

[DisallowMultipleComponent]
[ExecuteInEditMode]
public class LDstaticObjectLightmappingDataLoader : MonoBehaviour // TypeDefIndex: 83854
{
	// Fields
	public bool test; // 0x18
	public bool recover; // 0x19
	public Renderer[] ldLightmappedRenderer; // 0x20
	public int[] ldLightmappedRendererLightmapIndex; // 0x28
	public Vector4[] ldLightmappedRendererLightmapUvScale; // 0x30

	// Constructors
	public LDstaticObjectLightmappingDataLoader(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	public void RecoverLightmapdata(); // 0x000000018CB9A1E8-0x000000018CB9A378
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 84008
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_20 _7848C87B1819709EC2A0D678BCD530B3C49CA3BB2F61B8FCEF827B64DE251E15; // 0x00 // Static value (base64): mpkZPs3MTD6amZk+zcxMPpqZGT4= - Metadata: 0x02643FA8

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 84007
	{
	}
}

namespace Beyond.Rendering
{
	public class CustomPerDrawDataChannelUtils // TypeDefIndex: 83865
	{
		// Fields
		public const int HOUDINI_VAT_INDEX = 3; // Metadata: 0x02643C7C
		public const int HOUDINI_VAT_CHANNEL = 0; // Metadata: 0x02643C7D
		public const int LIT_EMISSIVE_INDEX = 2; // Metadata: 0x02643C7E
		public const int LIT_EMISSIVE_ANIMATION_SWEEP_INDEX = 3; // Metadata: 0x02643C7F
		public const int LIT_EMISSIVE_ALBEDO_INDEX = 4; // Metadata: 0x02643C80
		public const int UV_ANIMATION_INDEX = 3; // Metadata: 0x02643C81
		public const int MOVING_BAMBOO_CUR_PARAM_INDEX = 2; // Metadata: 0x02643C82
		public const int MOVING_BAMBOO_LAST_PARAM_INDEX = 3; // Metadata: 0x02643C83
		public const int LIT_DISSOLVE_INDEX = 4; // Metadata: 0x02643C84
		public const int LIT_DISSOLVE_CHANNEL = 0; // Metadata: 0x02643C85
		public const int CHARACTER_PARAMS_INDEX = 2; // Metadata: 0x02643C86
		public const int CHARACTER_ENVIRONMENT_EFFECT_INTENSITY_CHANNEL = 0; // Metadata: 0x02643C87
		public const int CHARACTER_WET_EFFECT_WORLD_SPACE_HEIGHT_CHANNEL = 1; // Metadata: 0x02643C88
		public const int CHARACTER_DISSOLVE_SCHEDULE_OFFSET_CHANNEL = 3; // Metadata: 0x02643C89
		public const int CHARACTER_RAIN_EFFECT_INTENSITY_CHANNEL_BIT = 8; // Metadata: 0x02643C8A
		public const int CHARACTER_WET_EFFECT_INTENSITY_CHANNEL_BIT = 16; // Metadata: 0x02643C8B
		public const int CHARACTER_WET_EFFECT_GLOBAL_INTENSITY_CHANNEL_BIT = 24; // Metadata: 0x02643C8C
		public const int CHARACTER_SNOW_EFFECT_INTENSITY_CHANNEL_BIT = 32; // Metadata: 0x02643C8D
		public const int CHARACTER_PARAMS_CHANNEL_BIT_BIAS = 8; // Metadata: 0x02643C8E
		public const int CHANNELS_PER_PARAM = 4; // Metadata: 0x02643C8F
		public const int VFX_ALPHA_INDEX = 4; // Metadata: 0x02643C90
		public const int VFX_ALPHA_DEFAULT_CHANNEL = 0; // Metadata: 0x02643C91
		public const int TRAIL_EFFECT_DISPLAY_INDEX = 2; // Metadata: 0x02643C92
		public const int TRAIL_EFFECT_SCAN_INDEX = 3; // Metadata: 0x02643C93
	
		// Constructors
		public CustomPerDrawDataChannelUtils(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void SetPerDrawData_LitDissolve(Renderer affectRenderer, float dissolve); // 0x000000018CB99428-0x000000018CB994B0
		public static void SetPerDrawData_HoudiniVAT(Renderer affectRenderer, int displayFrame); // 0x000000018CB9939C-0x000000018CB99428
		public static void SetPerDrawData_MovingBamboo(Renderer affectRenderer, Vector4 curParam, Vector4 lastParam); // 0x000000018CB994B0-0x000000018CB99560
		public static void SetPerDrawData_EmissiveColor(Renderer affectRenderer, Vector4 emissive); // 0x0000000185C67A60-0x0000000185C67AC0
		public static void SetPerDrawData_EmissiveAlbedoColor(Renderer affectRenderer, Vector4 emissiveAlbedo); // 0x0000000185C67AC0-0x0000000185C67B20
		public static void SetPerDrawData_SweepLightIntensity(Renderer affectRenderer, float intensity); // 0x0000000185C67CB0-0x0000000185C67D90
		public static void SetPerDrawData_SweepBreathing(Renderer affectRenderer, float frequency, float intensity, float timeOffset = 0f /* Metadata: 0x02643C78 */); // 0x0000000185C67B20-0x0000000185C67C00
		public static void SetPerDrawData_UVAnimation(Renderer affectRenderer, float animationEnable, float customAddTime); // 0x000000018CB99678-0x000000018CB99700
		public static void SetPerDrawData_CharacterParams(Renderer affectRenderer, Vector4 param0); // 0x000000018567A050-0x000000018567A0D0
		public static void SetPerDrawData_VFXAlpha0(Renderer affectRenderer, float alpha); // 0x000000018CB99700-0x000000018CB99794
		public static void SetPerDrawData_TrailDisplayArea(Renderer affectRenderer, float displayDistanceStart1, float displayDistanceEnd1, float displayDistanceStart2, float displayDistanceEnd2); // 0x000000018CB99560-0x000000018CB99600
		public static void SetPerDrawData_TrailScanCircle(Renderer affectRenderer, float scanRadiusStart, float scanRadiusEnd); // 0x000000018CB99600-0x000000018CB99678
	}

	public static class PipelineSettingHelper // TypeDefIndex: 83866
	{
		// Fields
		public const string SETTING_FOLDER = "Settings/"; // Metadata: 0x02643C94
		public const string SETTING_FILE_LIST = "SettingFiles.txt"; // Metadata: 0x02643C9E
	
		// Methods
		public static void LoadPipelineSettings(); // 0x000000018521BC80-0x000000018521C360
		private static string _LoadSetting(string settingName); // 0x000000018521B550-0x000000018521B780
		private static string _GetFullSettingPath(string settingName); // 0x0000000185391A00-0x0000000185391A60
	}

	public static class ResourceRouter // TypeDefIndex: 83867
	{
		// Fields
		private const string DYNAMIC_ENVIRONMENTS_FOLDER = "Gameplay/Environments/"; // Metadata: 0x02643CB3
	
		// Methods
		private static string _GetCategoryFolder(RootCategory category); // 0x000000018CB9BB00-0x000000018CB9BB70
		public static string GetEnvironmentsFullPath(RootCategory category = RootCategory.Main /* Metadata: 0x02643CAF */, bool isDevOnly = false /* Metadata: 0x02643CB0 */); // 0x000000018CB9BA90-0x000000018CB9BB00
		public static string GetDecalResourcesPath(); // 0x000000018CB9BA50-0x000000018CB9BA90
		public static string GetDecalResourcesFullPath(RootCategory category = RootCategory.Main /* Metadata: 0x02643CB1 */, bool isDevOnly = false /* Metadata: 0x02643CB2 */); // 0x000000018CB9B9E0-0x000000018CB9BA50
	}

	public class ShaderWarmupManager // TypeDefIndex: 83880
	{
		// Fields
		public static readonly string RUNTIME_PSO_COLLECTION_FOLDER; // 0x00
		public const string LOCAL_SHADER_WARMUP_CFG_PATH = "Assets/Beyond/InitialAssets/Settings/ShaderWarmupSettings.json"; // Metadata: 0x02643CCD
		private const string WARM_UP_KEY_WORD = "hg_warm_up_once"; // Metadata: 0x02643D0C
		private const string WARM_UP_API_KEY_WORD = "hg_warm_up_graphics"; // Metadata: 0x02643D1C
		private const string WARM_UP_DRIVER_KEY_WORD = "hg_warm_up_graphics_drivers"; // Metadata: 0x02643D30
		private const string WARM_UP_REASON_KEY_WORD = "hg_warm_up_reason"; // Metadata: 0x02643D4C
		private const string WARMUP_RETRY_COUNT = "hg_warmup_retry_count"; // Metadata: 0x02643D5E
		private const string WARMUP_UNFINISHED_COUNT = "hg_warmup_unfinished_count"; // Metadata: 0x02643D74
		private const string DOWNLOADING_WARMUP_UNFINISHED_COUNT = "hg_warmup_down_unfinished_count"; // Metadata: 0x02643D8F
		private const string FEATURE_RAYTRACING = "raytracing"; // Metadata: 0x02643DAF
		private const string FEATURE_ONE_PASS = "onepass"; // Metadata: 0x02643DBA
		private const string FEATURE_MULTITHREAD_COMPILE = "jobcompile"; // Metadata: 0x02643DC2
		private const long PSO_BACKUP_FULL_SIZE_LIMIT = 1073741824; // Metadata: 0x02643DCD
		private const long PSO_BACKUP_PREFIX_SIZE = 209715200; // Metadata: 0x02643DD5
		private const int SHADER_COMPILE_WEIGHT = 2; // Metadata: 0x02643DDD
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
		private static bool s_enablePsoCacheBackup; // 0x33
		private static int s_psoCacheBackupInProgress; // 0x34
		public static int s_warmupTotalCount; // 0x38
		public static int s_warmupTotalCountWeighted; // 0x3C
		public static int s_warmupRemainCountWeighted; // 0x40
		private static int s_warmupFinishedCount; // 0x44
		private static int s_cacheFileSizeBefore; // 0x48
		private static int s_compileTotalCount; // 0x4C
		public static float s_loginWarmUpTime; // 0x50
		public static WarmUpReason s_loginWarmUpReason; // 0x54
		public static float s_downloadWarmupPercent; // 0x58
		private static WarmupRunType s_lastWarmupRunType; // 0x5C
		private static bool s_isDownloadingWarmupRunning; // 0x60
		private static bool s_shouldStopDownloadingWarmup; // 0x61
		public static long s_cacheSizeRecompileThreshold; // 0x68
		public static int s_warmupCountPerWorkerMainJobCompile; // 0x70
		public static int s_warmupCountPerStepBackJobCompile; // 0x74
		public static int s_warmupCountPerStepMainJob; // 0x78
		public static int s_warmupCountPerStepBackJob; // 0x7C
		public static int s_warmupCountPerStepBackDispatchLimit; // 0x80
		public static int s_warmupCountToClean; // 0x84
		public static int s_warmupTimeLimitMobile; // 0x88
		public static int s_warmupTimeLimitPC; // 0x8C
		public static string s_vulkanCacheFileName; // 0x90
		public static string s_iosCacheFileName; // 0x98
	
		// Properties
		public static bool isWarming { get; } // 0x000000018CB9D938-0x000000018CB9D994 
	
		// Nested types
		public enum WarmUpReason // TypeDefIndex: 83868
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
	
		private enum WarmupRunType // TypeDefIndex: 83869
		{
			None = 0,
			Login = 1,
			Download = 2
		}
	
		private class TimeCostCounter // TypeDefIndex: 83870
		{
			// Fields
			private const float MAX_DELTA_TIME = 5f; // Metadata: 0x02643DEF
			private const float MAX_DELTA_TIME_FIX = 1f; // Metadata: 0x02643DF3
			[CompilerGenerated]
			private float _duration_k__BackingField; // 0x10
			private float m_lastRealTime; // 0x14
			private float m_maxDurationSecond; // 0x18
	
			// Properties
			public float duration { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
			public bool isTimeOut { get; } // 0x000000018CB9DA74-0x000000018CB9DAB0 
	
			// Constructors
			public TimeCostCounter(float maxDurationMilliSecond); // 0x000000018CB9DA60-0x000000018CB9DA74
	
			// Methods
			public void Begin(); // 0x000000018CB9D994-0x000000018CB9D9EC
			public void Tick(); // 0x000000018CB9D9EC-0x000000018CB9DA60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0 // TypeDefIndex: 83871
		{
			// Fields
			public string stagedFilePath; // 0x10
			public string backupPath; // 0x18
			public long fileSize; // 0x20
	
			// Constructors
			public __c__DisplayClass68_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __TryBackupVulkanPsoCacheFile_b__0(object _); // 0x0000000184DFA9A0-0x0000000184DFA9F0
		}
	
		[CompilerGenerated]
		private sealed class _WarmupShadersLogin_d__73 : IEnumerator<object> // TypeDefIndex: 83872
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WarmupShadersLogin_d__73(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000184DFD6E0-0x0000000184DFD780
			private bool MoveNext(); // 0x0000000184DFBAC0-0x0000000184DFD690
			private void __m__Finally1(); // 0x0000000184DFD780-0x0000000184DFD7C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DFD690-0x0000000184DFD6E0
		}
	
		[CompilerGenerated]
		private sealed class _WarmupShadersDownloading_d__74 : IEnumerator<object> // TypeDefIndex: 83873
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool supportsRaytracing; // 0x20
			private List<FAssetProxyHandle> _assetProxyHandles_5__2; // 0x28
			private List<HGPsoWarmupCollection> _loadedAssets_5__3; // 0x30
			private int _i_5__4; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WarmupShadersDownloading_d__74(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000184DFB8C0-0x0000000184DFB940
			private bool MoveNext(); // 0x0000000184DFAFA0-0x0000000184DFB870
			private void __m__Finally1(); // 0x0000000184DFB940-0x0000000184DFBAC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DFB870-0x0000000184DFB8C0
		}
	
		[CompilerGenerated]
		private sealed class __StopDownloadingWarmupAndWait_d__76 : IEnumerator<object> // TypeDefIndex: 83874
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __StopDownloadingWarmupAndWait_d__76(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184DFF340-0x0000000184DFF440
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DFF440-0x0000000184DFF490
		}
	
		[CompilerGenerated]
		private sealed class __LoadPsoAssets_d__81 : IEnumerator<object> // TypeDefIndex: 83875
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public List<StringPathHash> resPathList; // 0x20
			public List<FAssetProxyHandle> assetProxyHandles; // 0x28
			public List<HGPsoWarmupCollection> loadedAssets; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __LoadPsoAssets_d__81(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184DFEB80-0x0000000184DFF2F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DFF2F0-0x0000000184DFF340
		}
	
		[CompilerGenerated]
		private sealed class _WarmupShadersScene_d__82 : IEnumerator<object> // TypeDefIndex: 83876
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string scene; // 0x20
			private string _path_5__2; // 0x28
			private FAssetProxyHandle _assetHandle_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WarmupShadersScene_d__82(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184DFD7C0-0x0000000184DFEB30
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DFEB30-0x0000000184DFEB80
		}
	
		[CompilerGenerated]
		private sealed class _WarmupOnePso_d__83 : IEnumerator<object> // TypeDefIndex: 83877
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public HGPsoWarmupCollection psoC; // 0x20
			public int startIndex; // 0x28
			public int warmupCount; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WarmupOnePso_d__83(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184DFA9F0-0x0000000184DFAF50
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DFAF50-0x0000000184DFAFA0
		}
	
		[CompilerGenerated]
		private sealed class __WarmupOnePsoTimeLimited_d__84 : IEnumerator<object> // TypeDefIndex: 83878
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public HGPsoWarmupCollection psoC; // 0x20
			public int startIndex; // 0x28
			public int desiredWarmupCount; // 0x2C
			public TimeCostCounter timeStart; // 0x30
			private int _totalCount_5__2; // 0x38
			private bool _doSingleThreadCompile_5__3; // 0x3C
			private int _computeShaderCount_5__4; // 0x40
			private int _warmupCountPerStepMainJobCompile_5__5; // 0x44
			private int _compileTotalCount_5__6; // 0x48
			private int _countToCleanUp_5__7; // 0x4C
			private int _backJobLastLeftCount_5__8; // 0x50
			private int _leftBackJobCount_5__9; // 0x54
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __WarmupOnePsoTimeLimited_d__84(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184DFFDE0-0x0000000184E008B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184E008B0-0x0000000184E00960
		}
	
		[CompilerGenerated]
		private sealed class __WarmupOnePsoBackgroundOnly_d__85 : IEnumerator<object> // TypeDefIndex: 83879
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __WarmupOnePsoBackgroundOnly_d__85(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184DFF490-0x0000000184DFFD90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DFFD90-0x0000000184DFFDE0
		}
	
		// Constructors
		public ShaderWarmupManager(); // 0x0000000186805BA0-0x0000000186805BB0
		static ShaderWarmupManager(); // 0x0000000186DDB570-0x0000000186DDBA00
	
		// Methods
		[IDTag(0)]
		public static string GetPsoPathName(RuntimePlatform platform, GraphicsDeviceType graphicsDeviceType, int shaderLod, string levelId); // 0x000000018CB9C54C-0x000000018CB9C620
		[IDTag(1)]
		public static string GetPsoPathName(RuntimePlatform platform, GraphicsDeviceType graphicsDeviceType, int shaderLod, string levelId, string feature); // 0x000000018CB9C620-0x000000018CB9C708
		public static string GetLoginWarmupDetail(); // 0x000000018672CF60-0x000000018672CFD0
		private static long _GetCacheFileSize(); // 0x000000018CB9CD80-0x000000018CB9CE8C
		public static void ProcessRemoteConfig(string localConfigStr, string remoteConfigStr); // 0x0000000184DF5FF0-0x0000000184DF6390
		public static void MarkNeedShaderWarmUp(WarmUpReason reason); // 0x000000018CB9C708-0x000000018CB9C770
		public static void MarkWarmUpLoginFinish(); // 0x000000018CB9C770-0x000000018CB9C7CC
		public static void CleanLoadedPso(); // 0x000000018CB9C4E8-0x000000018CB9C54C
		private static void _MarkWarmUpLoginFinish(); // 0x000000018CB9D35C-0x000000018CB9D3D4
		public static void TryRepairPsoCacheAfterCorruptCheck(); // 0x000000018CB9C7CC-0x000000018CB9C834
		private static bool _TryBackupAndDeleteVulkanPsoCacheFile(); // 0x0000000184DF7FB0-0x0000000184DF8150
		private static bool _TryBackupVulkanPsoCacheFile(string cacheFilePath); // 0x0000000184DF8150-0x0000000184DF99B0
		private static string _PreparePsoCacheBackupPath(string cacheFilePath); // 0x0000000184DF68D0-0x0000000184DF7FB0
		private static void _FinishPsoCacheBackup(string stagedFilePath, string backupPath, long fileSize); // 0x0000000184DF6390-0x0000000184DF68D0
		private static bool _TryDeletePsoCacheFile(string cacheFilePath); // 0x0000000184DF99B0-0x0000000184DFA9A0
		public static bool CheckNeedWarmUpLogin(bool stateless = false /* Metadata: 0x02643CCA */); // 0x00000001850CAF30-0x00000001850CB080
		[IteratorStateMachine(typeof(_WarmupShadersLogin_d__73))]
		public static IEnumerator WarmupShadersLogin(bool supportsRaytracing); // 0x000000018CB9C930-0x000000018CB9C994
		[IteratorStateMachine(typeof(_WarmupShadersDownloading_d__74))]
		public static IEnumerator WarmupShadersDownloading(bool supportsRaytracing); // 0x000000018CB9C8CC-0x000000018CB9C930
		public static void StopWarmupShadersDownloading(); // 0x0000000186BBC950-0x0000000186BBC9A0
		[IteratorStateMachine(typeof(__StopDownloadingWarmupAndWait_d__76))]
		private static IEnumerator _StopDownloadingWarmupAndWait(); // 0x000000018CB9D6C8-0x000000018CB9D720
		private static List<StringPathHash> _BuildLoginWarmupPaths(bool supportsRaytracing); // 0x000000018CB9CA08-0x000000018CB9CBB8
		private static void _InitWarmupStats(List<HGPsoWarmupCollection> loadedAssets, bool isBackgroundWarmup = false /* Metadata: 0x02643CCB */, bool updateCacheFileSizeBefore = true /* Metadata: 0x02643CCC */); // 0x000000018CB9D06C-0x000000018CB9D278
		private static void _UpdateDownloadWarmupPercent(); // 0x000000018CB9D720-0x000000018CB9D7E4
		private static void _DisposeWarmupAssetHandles(List<FAssetProxyHandle> assetProxyHandles); // 0x000000018CB9CBB8-0x000000018CB9CCF8
		[IteratorStateMachine(typeof(__LoadPsoAssets_d__81))]
		private static IEnumerator _LoadPsoAssets(List<StringPathHash> resPathList, List<FAssetProxyHandle> assetProxyHandles, List<HGPsoWarmupCollection> loadedAssets); // 0x000000018CB9D2B0-0x000000018CB9D35C
		[IteratorStateMachine(typeof(_WarmupShadersScene_d__82))]
		[Obsolete]
		public static IEnumerator WarmupShadersScene(string scene); // 0x000000018CB9C994-0x000000018CB9CA08
		[IteratorStateMachine(typeof(_WarmupOnePso_d__83))]
		[Obsolete]
		public static IEnumerator WarmupOnePso(HGPsoWarmupCollection psoC, int startIndex, int warmupCount); // 0x000000018CB9C834-0x000000018CB9C8CC
		[IteratorStateMachine(typeof(__WarmupOnePsoTimeLimited_d__84))]
		private static IEnumerator _WarmupOnePsoTimeLimited(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount, TimeCostCounter timeStart); // 0x000000018CB9D87C-0x000000018CB9D938
		[IteratorStateMachine(typeof(__WarmupOnePsoBackgroundOnly_d__85))]
		private static IEnumerator _WarmupOnePsoBackgroundOnly(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount); // 0x000000018CB9D7E4-0x000000018CB9D87C
		private static void _StepProgress(int newFinishedCount, ref int compileTotalCount); // 0x000000018CB9D614-0x000000018CB9D6C8
		private static bool _CheckNeedWarmUpByFirstEntry(); // 0x0000000185753290-0x0000000185753330
		private static bool _CheckNeedWarmUpByDeviceState(bool stateless); // 0x0000000186F9F990-0x0000000186FA1080
		private static bool _IsNeedWarmupByGraphicsChange(); // 0x00000001850CC600-0x00000001850CC700
		private static bool _IsNeedWarmupByCacheOutdated(); // 0x0000000186FA1080-0x0000000186FA1130
		private static void _SetWarmupRetryCount(int count); // 0x000000018CB9D574-0x000000018CB9D5C4
		private static void _SetWarmupUnfinishedCount(int count); // 0x000000018CB9D5C4-0x000000018CB9D614
		private static int _GetDownloadingWarmupUnfinishedCount(); // 0x000000018CB9CF30-0x000000018CB9CF70
		private static void _SetDownloadingWarmupUnfinishedCount(int count); // 0x000000018CB9D524-0x000000018CB9D574
		private static void _MarkWarmupFinishAPI(); // 0x000000018CB9D49C-0x000000018CB9D524
		private static bool _IsNeedWarmupDx11Driver(); // 0x0000000185753050-0x00000001857530F0
		private static void _MarkWarmupDx11Driver(); // 0x000000018CB9D3D4-0x000000018CB9D49C
		private static void _ResetWarmUpStatsIfNeed(); // 0x00000001850CB0E0-0x00000001850CB140
		private static bool _IsDeviceSupportWarmUp(); // 0x00000001850CB080-0x00000001850CB0E0
		private static bool _IsDeviceSupportDownloadWarmUp(); // 0x000000018CB9D278-0x000000018CB9D2B0
		private static bool _IsFeatureEnabled(string featureKeyword); // 0x000000018CB97B88-0x000000018CB987C8
		private static bool _CheckWarmUpUnfinishedOften(); // 0x0000000185752D20-0x0000000185752DC0
		private static int _GetLoginTimeLimit(); // 0x000000018CB9CF70-0x000000018CB9CFCC
		private static int _GetWarmupEndIndexExclusive(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount); // 0x000000018CB9CFCC-0x000000018CB9D06C
		private static int _GetCompileCountForRange(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount); // 0x000000018CB9CE8C-0x000000018CB9CF30
		private static int _GetBackgroundWarmupStartIndex(HGPsoWarmupCollection psoC, int startIndex, int endIndexExclusive); // 0x000000018CB9CCF8-0x000000018CB9CD80
	}

	public class ShaderWarmupManagerRemoteCfg // TypeDefIndex: 83884
	{
		// Fields
		[CanBeNull]
		private ShaderWarmupRemoteBlacklist m_blacklist; // 0x10
	
		// Properties
		private static string cpuNameForWarmUp { get; } // 0x000000018CB9C4A4-0x000000018CB9C4E8 
	
		// Nested types
		[Serializable]
		private class ShaderWarmupRemoteBlackDevice // TypeDefIndex: 83881
		{
			// Fields
			public string deviceModel; // 0x10
			public string graphicsDeviceName; // 0x18
			public string graphicsDeviceVersion; // 0x20
			public string os; // 0x28
			public string cpuName; // 0x30
			public string disableFeature; // 0x38
	
			// Constructors
			public ShaderWarmupRemoteBlackDevice(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		private class ShaderWarmupGlobalConfig // TypeDefIndex: 83882
		{
			// Fields
			public bool enableDriverVerDetect; // 0x10
			public bool disablePsoCacheBackup; // 0x11
	
			// Constructors
			public ShaderWarmupGlobalConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		private class ShaderWarmupRemoteBlacklist // TypeDefIndex: 83883
		{
			// Fields
			public List<ShaderWarmupRemoteBlackDevice> devices; // 0x10
			public ShaderWarmupGlobalConfig config; // 0x18
	
			// Constructors
			public ShaderWarmupRemoteBlacklist(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public ShaderWarmupManagerRemoteCfg(string blackListStr); // 0x0000000187224260-0x0000000187224300
	
		// Methods
		public bool IsEnablePsoCacheBackup(); // 0x0000000184DF5B40-0x0000000184DF5BB0
		public bool IsEnableDx11DriverVersionDetect(); // 0x0000000187220D60-0x0000000187220D90
		public bool IsDeviceInBlackList(out string disabledFeature); // 0x00000001871E9830-0x00000001871E9890
		public bool TryMatchDevice(out bool isInBlackList, out string disabledFeature); // 0x0000000184DF5BB0-0x0000000184DF5FF0
		private static bool _CheckDeviceMatch(ShaderWarmupRemoteBlackDevice blacklistDevice, string currentDeviceModel, string currentGraphicsDeviceName, string currentGraphicsDeviceVersion, string currentProcessorType, string currentOS); // 0x000000018CB9C224-0x000000018CB9C4A4
	}

	public static class WindowsGpuDriverVersion // TypeDefIndex: 83890
	{
		// Fields
		private static readonly Guid GUID_DEVCLASS_DISPLAY; // 0x00
		private const uint DIGCF_PRESENT = 2; // Metadata: 0x02643DF7
		private const uint SPDRP_DEVICEDESC = 0; // Metadata: 0x02643DF8
		private const uint SPDRP_MFG = 11; // Metadata: 0x02643DF9
		private const uint SPDRP_FRIENDLYNAME = 12; // Metadata: 0x02643DFA
		private const uint SPDRP_DRIVER = 9; // Metadata: 0x02643DFB
		private const uint DICS_FLAG_GLOBAL = 1; // Metadata: 0x02643DFC
		private const uint DIREG_DRV = 2; // Metadata: 0x02643DFD
		private static readonly IntPtr INVALID_HANDLE_VALUE; // 0x10
		private const int ERROR_SUCCESS = 0; // Metadata: 0x02643DFE
		private const int ERROR_NO_MORE_ITEMS = 259; // Metadata: 0x02643DFF
		private const int ERROR_INSUFFICIENT_BUFFER = 122; // Metadata: 0x02643E01
		private const int ERROR_MORE_DATA = 234; // Metadata: 0x02643E03
		private const uint REG_SZ = 1; // Metadata: 0x02643E05
		private const uint REG_EXPAND_SZ = 2; // Metadata: 0x02643E06
	
		// Nested types
		public sealed class Result // TypeDefIndex: 83885
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
			public Result(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public override string ToString(); // 0x000000018CB9BB70-0x000000018CB9BCE4
			public string __iFixBaseProxy_ToString(); // 0x0000000188ABB3B8-0x0000000188ABB3C0
		}
	
		private sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 83886
		{
			// Constructors
			internal SafeRegistryHandle(); // 0x0000000187835F00-0x0000000187835F10
			internal SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle); // 0x0000000185443DA0-0x0000000185443DD0
	
			// Methods
			protected override bool ReleaseHandle(); // 0x000000018CB9BD04-0x000000018CB9BD68
		}
	
		[Flags]
		private enum RegistryRights // TypeDefIndex: 83887
		{
			KEY_QUERY_VALUE = 1
		}
	
		private struct SP_DEVINFO_DATA // TypeDefIndex: 83888
		{
			// Fields
			public uint cbSize; // 0x00
			public Guid classGuid; // 0x04
			public uint devInst; // 0x14
			public IntPtr reserved; // 0x18
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83889
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Result> __9__18_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB9DAD8-0x000000018CB9DB20
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetAllDisplayDriverVersions_b__18_0(Result a, Result b); // 0x000000018CB9DAB0-0x000000018CB9DAD8
		}
	
		// Constructors
		static WindowsGpuDriverVersion(); // 0x000000018CB9F9D8-0x000000018CB9FDBC
	
		// Methods
		public static string GetCurrentDriverVersion(); // 0x000000018CB9E854-0x000000018CB9E8C0
		public static Result GetBestMatch(); // 0x000000018CB9E264-0x000000018CB9E854
		public static List<Result> GetAllDisplayDriverVersions(); // 0x000000018CB9DB20-0x000000018CB9E264
		public static string SerializeAllResults(List<Result> results); // 0x000000018CB9EB4C-0x000000018CB9ECFC
		public static string SerializeAllCurrentResults(); // 0x000000018CB9EAF4-0x000000018CB9EB4C
		public static bool IsBestMatchDriverVersionChanged(string serialized); // 0x000000018CB9E8C0-0x000000018CB9E9A4
		private static bool _TryGetDriverVersionByKeyId(string serialized, string keyId, out string driverVersion); // 0x000000018CB9F86C-0x000000018CB9F9D8
		private static int _ScoreAgainstUnityCurrentGpu(string friendlyName, string deviceDesc, string mfg); // 0x000000018CB9F5DC-0x000000018CB9F86C
		private static bool _ContainsIgnoreCase(string a, string b); // 0x000000018CB9F03C-0x000000018CB9F0A8
		private static string _GetDeviceRegistryPropertyString(IntPtr infoSet, ref SP_DEVINFO_DATA devInfo, uint prop); // 0x000000018CB9F0A8-0x000000018CB9F310
		private static string _GetDriverKeySuffix(string driverKey); // 0x000000018CB9F310-0x000000018CB9F39C
		private static string _ReadRegistrySz(SafeRegistryHandle hKey, string valueName); // 0x000000018CB9F39C-0x000000018CB9F5DC
		private static extern int RegCloseKey(IntPtr hKey); // 0x000000018CB9E9A4-0x000000018CB9E9E8
		private static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, IntPtr enumerator, IntPtr hwndParent, uint flags); // 0x000000018CB9EDD4-0x000000018CB9EE84
		private static extern bool SetupDiEnumDeviceInfo(IntPtr deviceInfoSet, uint memberIndex, ref SP_DEVINFO_DATA deviceInfoData); // 0x000000018CB9ED34-0x000000018CB9EDD4
		private static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint property, out uint propertyRegDataType, IntPtr propertyBuffer, uint propertyBufferSize, out uint requiredSize); // 0x000000018CB9EE84-0x000000018CB9EF58
		private static extern SafeRegistryHandle SetupDiOpenDevRegKey(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint scope, uint hwProfile, uint keyType, int samDesired); // 0x000000018CB9EF58-0x000000018CB9F03C
		private static extern bool SetupDiDestroyDeviceInfoList(IntPtr deviceInfoSet); // 0x000000018CB9ECFC-0x000000018CB9ED34
		private static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, IntPtr lpReserved, out uint lpType, IntPtr lpData, ref uint lpcbData); // 0x000000018CB9E9E8-0x000000018CB9EAF4
	}

	public static class SOCHelper // TypeDefIndex: 83891
	{
		// Fields
		public static readonly int CHUNK_SIZE; // 0x00
		public const string SOC_FOLDER_NAME = "OcclusionCulling"; // Metadata: 0x02643E08
		public const string SOC_INTERMEDIATE_FILE_NAME = "[x]HGSOCChunkData.asset"; // Metadata: 0x02643E19
	
		// Constructors
		static SOCHelper(); // 0x000000018CB9BCE4-0x000000018CB9BD04
	}

	[Serializable]
	public struct SceneStateAreaKey : IEquatable<SceneStateAreaKey> // TypeDefIndex: 83892
	{
		// Fields
		public int[] sceneStateIds; // 0x00
		public int areaId; // 0x08
		public uint sceneStateMask; // 0x0C
		public static readonly SceneStateAreaKey DEFAULT; // 0x00
	
		// Constructors
		public SceneStateAreaKey(ICollection<int> sceneStateIds, int areaId); // 0x000000018CB9C1C8-0x000000018CB9C224
		static SceneStateAreaKey(); // 0x000000018CB9C16C-0x000000018CB9C1C8
	
		// Methods
		[IDTag(0)]
		public bool Equals(SceneStateAreaKey other); // 0x000000018CB9BD68-0x000000018CB9BDE8
		[IDTag(1)]
		public override bool Equals(object obj); // 0x000000018CB9BDE8-0x000000018CB9BE7C
		public override int GetHashCode(); // 0x000000018CB9BE7C-0x000000018CB9BEE4
		private static int[] _Normalize(ICollection<int> ids); // 0x000000018CB9BF48-0x000000018CB9C0B0
		private static bool _SequenceEqual(int[] a, int[] b); // 0x000000018CB9C0B0-0x000000018CB9C16C
		public bool __iFixBaseProxy_Equals(object P0); // 0x000000018CB9BEE4-0x000000018CB9BF1C
		public int __iFixBaseProxy_GetHashCode(); // 0x000000018CB9BF1C-0x000000018CB9BF48
	}

	public class HGSOCSubSceneData : ScriptableObject // TypeDefIndex: 83895
	{
		// Fields
		public SceneStateAreaKey[] keyArray; // 0x18
		[FormerlySerializedAs("stateDataArray")]
		public SubSceneDataPerSceneStateArea[] dataArray; // 0x20
	
		// Nested types
		[Serializable]
		public struct ChunkData // TypeDefIndex: 83893
		{
			// Fields
			public Vector3[] centers; // 0x00
			public Vector3[] extents; // 0x08
			public Vector3[] vertexData; // 0x10
			public float[] areas; // 0x18
		}
	
		[Serializable]
		public struct SubSceneDataPerSceneStateArea // TypeDefIndex: 83894
		{
			// Fields
			public Vector2Int[] chunkCoords; // 0x00
			public ChunkData[] chunkDataArray; // 0x08
			public int[] explicitLayers; // 0x10
		}
	
		// Constructors
		public HGSOCSubSceneData(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	[ExecuteInEditMode]
	public class HGSOCDataHelper : MonoBehaviour // TypeDefIndex: 83896
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
		public bool displayQuadOccluders { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public bool displayHGOccluders { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E090-0x000000018225E0A0 0x000000018225E0A0-0x000000018225E0B0
	
		// Constructors
		public HGSOCDataHelper(); // 0x000000018CB9A1C4-0x000000018CB9A1E8
	}

	public class EntityRenderAlphaDitherController // TypeDefIndex: 83897
	{
		// Fields
		private IRendererHelper m_owner; // 0x10
		private float m_ditherAlpha; // 0x18
		private static int s_CharDitherFade; // 0x00
		private static int s_DitherTransparentAlpha; // 0x04
		private Dictionary<int, float> m_alphaPerHandles; // 0x20
		private bool m_lastSetAllRendererEnabled; // 0x28
	
		// Constructors
		public EntityRenderAlphaDitherController(IRendererHelper owner); // 0x0000000185322120-0x0000000185322190
		static EntityRenderAlphaDitherController(); // 0x00000001871FC840-0x00000001871FC890
	
		// Methods
		public void ResetDitherAlpha(); // 0x0000000186404CB0-0x0000000186404D00
		public bool SetDitherAlpha(float alpha, int handle); // 0x00000001853269B0-0x0000000185326A70
		public float GetDitherAlpha(); // 0x000000018CB99968-0x000000018CB999AC
		public void Reset(); // 0x0000000185322AF0-0x0000000185322B30
		private bool _ApplyNewAlpha(); // 0x0000000185326A70-0x0000000185326C50
		private float _GetCurMinAlpha(); // 0x0000000185326C50-0x0000000185326EC0
		public Dictionary<int, float> GetAlphaDictionary(); // 0x000000018CB99928-0x000000018CB99968
		private void _SetMaterialDitherAlpha(float value); // 0x0000000185326EC0-0x0000000185326F40
		private bool _SetMaterialDitherEnabled(bool enabled); // 0x0000000185326F80-0x0000000185327090
	}

	public class EntityRenderCapturedEntity // TypeDefIndex: 83898
	{
		// Fields
		public GameObject rootGameObject; // 0x10
		public List<MeshRenderer> meshRenderers; // 0x18
		public List<MeshRenderer> capturedRenderers; // 0x20
	
		// Constructors
		public EntityRenderCapturedEntity(); // 0x00000001855A27A0-0x00000001855A2820
	}

	public class EntityRenderCaptureMeshController // TypeDefIndex: 83901
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
		private struct MeshRendererToSync // TypeDefIndex: 83899
		{
			// Fields
			public Transform captureTransform; // 0x00
			public Renderer captureRenderer; // 0x08
			public Transform followTransform; // 0x10
			public Renderer followRenderer; // 0x18
		}
	
		private class CaptureRenderGameObject // TypeDefIndex: 83900
		{
			// Fields
			public GameObject gameObject; // 0x10
			public MeshRenderer meshRenderer; // 0x18
			public MeshFilter meshFilter; // 0x20
	
			// Constructors
			public CaptureRenderGameObject(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public EntityRenderCaptureMeshController(IRendererHelper owner, GameObject gameObject); // 0x0000000185321AE0-0x0000000185321BC0
	
		// Methods
		public void Reset(); // 0x0000000185322B70-0x0000000185322BD0
		public void LateTick(); // 0x00000001863254B0-0x00000001863254E0
		public void InitRendererTypeMasks(Dictionary<Renderer, EntityVFXRendererMask> masks); // 0x000000018CB999AC-0x000000018CB999EC
		public EntityRenderCapturedEntity Capture(GameObject root, EntityVFXRendererMask rendererMask); // 0x00000001855A2F40-0x00000001855A41D0
		private bool _PassRendererMaskFilter(Renderer renderer, EntityVFXRendererMask rendererMask); // 0x000000018CB97AC4-0x000000018CB97B0C
		private void _SyncTransformInRenderPipeline(); // 0x00000001863254E0-0x00000001863257D0
		public void Release(EntityRenderCapturedEntity mesh); // 0x0000000185CCDFD0-0x0000000185CCE270
	}

	public class EntityRendererTypeConfig // TypeDefIndex: 83902
	{
		// Fields
		public bool useRegex; // 0x10
		public string regexString; // 0x18
		public Regex regex; // 0x20
		public EntityVFXRendererType type; // 0x28
	
		// Constructors
		public EntityRendererTypeConfig(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class EntityRenderHelperMaterialController // TypeDefIndex: 83910
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
		public class RendererInfo // TypeDefIndex: 83903
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
			public Material[] currentMeshMaterials { get; } // 0x00000001852F2EE0-0x00000001852F2F20 
			private bool rendererValid { get; } // 0x00000001851CD5E0-0x00000001851CD970 
			public string rendererName { get; } // 0x000000018CB9B93C-0x000000018CB9B9E0 
	
			// Constructors
			public RendererInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool IsRendererValid(); // 0x0000000185322F40-0x0000000185322FC0
			public bool TryGetRenderer(out Renderer renderer); // 0x000000018CB9B7DC-0x000000018CB9B838
			public bool TryBeginMaterialUpdate(); // 0x00000001851CF370-0x00000001851CF3F0
			public bool TryInit(Renderer renderer, List<EntityRendererTypeConfig> configs); // 0x00000001855AB3F0-0x00000001855AB4A0
			private void _Init(Renderer renderer, List<EntityRendererTypeConfig> configs); // 0x00000001855AB4F0-0x00000001855AB750
			public bool TryStopShadowCasting(bool stopRayTracing); // 0x00000001855AB040-0x00000001855AB110
			public bool TryRevertShadowCastingMode(); // 0x00000001855AAF40-0x00000001855AAFF0
			public bool TryFillRendererTypeMask(Dictionary<Renderer, EntityVFXRendererMask> target); // 0x000000018CB9B6C0-0x000000018CB9B744
			public bool TrySetManualDitherAlphaValue(float value); // 0x00000001851CD270-0x00000001851CD380
			public bool TrySetManualDitherEnable(bool enable, ref bool allRendererEnabled); // 0x00000001851CD3D0-0x00000001851CD590
			public bool TrySetSharedMaterial(Material material); // 0x000000018CB9B8C0-0x000000018CB9B93C
			public bool TrySetSharedMaterials(Material[] materials); // 0x00000001852F2F20-0x00000001852F3000
			public bool TryReplaceSharedMaterials(Material[] newMaterials); // 0x00000001852DEF40-0x00000001852DF040
			public bool TryGetRendererPosition(out Vector3 position); // 0x00000001855AA720-0x00000001855AA7E0
			public bool TryGetRendererBounds(out Bounds bounds); // 0x000000018CB9B744-0x000000018CB9B7DC
			public bool TryEncapsulateBounds(ref Bounds bounds); // 0x00000001855AAE20-0x00000001855AAF40
			public bool TrySetCharacterPerDrawData(Vector4 value); // 0x0000000185679F20-0x000000018567A050
			public bool TrySetEmissiveColor(Vector4 value); // 0x000000018CB9B838-0x000000018CB9B8C0
			private static int _GetSubMeshCount(Renderer renderer); // 0x00000001855AB800-0x00000001855ABAB0
		}
	
		public struct AddedMaterialInfo // TypeDefIndex: 83904
		{
			// Fields
			public int handle; // 0x00
			public Material material; // 0x08
			public EntityVFXRendererMask mask; // 0x10
			public AddMaterialConfig config; // 0x18
			public Dictionary<Material, Material> customizeMaterialDict; // 0x28
		}
	
		public struct SourceMaterialCustomizeData // TypeDefIndex: 83905
		{
			// Fields
			public Texture colorTexture; // 0x00
		}
	
		public class AddedMaterialController // TypeDefIndex: 83906
		{
			// Fields
			public const int MAX_ACTIVE_ADDED_MATERIAL = 4; // Metadata: 0x02643E3B
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
			public AddedMaterialController(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Init(List<RendererInfo> rendererInfos, EntityCustomizeRendererPropertyConfig customizeRendererPropertyConfig); // 0x0000000186AB4F10-0x0000000186AB4F70
			private void _InitCustomizeRendererProperty(); // 0x000000018CB98FC0-0x000000018CB99258
			public void Reset(); // 0x0000000186BA9990-0x0000000186BA99D0
			public int RequireAddMaterial(Material material, EntityVFXRendererMask mask, AddMaterialConfig config = default); // 0x0000000186500E40-0x0000000186500FB0
			public EntityVFXRendererMask RequireRemoveMaterial(int handle); // 0x00000001864D99C0-0x00000001864D9D40
			private Material _GetCustomizePropertyMaterial(AddedMaterialInfo addedMaterialInfo, Material material); // 0x000000018CB98E6C-0x000000018CB98FC0
			public void ApplySharedMaterialArray(RendererInfo rendererInfo); // 0x00000001852F2AC0-0x00000001852F2EE0
			public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result); // 0x000000018CB987C8-0x000000018CB98A54
			public void SetAddictiveFloatProperty(int propertyId, float value); // 0x000000018CB98C14-0x000000018CB98CD4
			public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x02643E37 */); // 0x000000018CB98A54-0x000000018CB98AD8
			public void SetAddictiveVectorProperty(int propertyId, Vector4 value); // 0x000000018CB98D94-0x000000018CB98E6C
			public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default); // 0x000000018CB98B50-0x000000018CB98C14
			public void SetAddictiveTextureProperty(int propertyId, Texture value); // 0x000000018CB98CD4-0x000000018CB98D94
			public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null); // 0x000000018CB98AD8-0x000000018CB98B50
		}
	
		public class CustomPerDrawDataController // TypeDefIndex: 83907
		{
			// Fields
			private List<RendererInfo> m_rendererInfos; // 0x10
			private float m_characterEnvironmentEffectPackedValue; // 0x18
	
			// Constructors
			public CustomPerDrawDataController(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			private float _PackUNorm8ToFloat(float packed, float value, int bitShift); // 0x00000001866B8810-0x00000001866B88A0
			public void Init(List<RendererInfo> allRendererInfos); // 0x00000001855A7800-0x00000001855A7840
			public void Reset(); // 0x00000001862F2610-0x00000001862F2760
			public void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask); // 0x000000018567A0D0-0x000000018567A310
			public void SetVectorToCustomPerDraw(EntityRenderHelperVectorCustomPerDrawType type, Vector4 value, EntityVFXRendererMask rendererMask); // 0x000000018CB99794-0x000000018CB99928
		}
	
		public class MeshMaterialGroupData // TypeDefIndex: 83908
		{
			// Fields
			public EntityVFXRendererMask mask; // 0x10
			public List<RendererInfo> rendererInfos; // 0x18
			public Dictionary<int, float> floatProperties; // 0x20
			[TupleElementNames(new string[2] {"value", "multiplyFromSource" })]
			public Dictionary<int, ValueTuple<Vector4, bool>> vectorProperties; // 0x28
			public Dictionary<int, Texture> textureProperties; // 0x30
			public Dictionary<string, bool> keywordStates; // 0x38
			public bool depthOnlyPassControlling; // 0x40
			public Dictionary<Material, Material> src2dstMaterialDict; // 0x48
	
			// Constructors
			public MeshMaterialGroupData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void CopyFrom(MeshMaterialGroupData src); // 0x00000001866CC7C0-0x00000001866CC9A0
			public void Clear(); // 0x0000000185322930-0x00000001853229C0
		}
	
		public class MeshMaterialController // TypeDefIndex: 83909
		{
			// Fields
			private List<MeshMaterialGroupData> m_meshMaterialDatas; // 0x10
			private static List<MeshMaterialGroupData> s_cacheMeshMaterialDatas; // 0x00
			private static readonly string VFX_MATERIAL_POSTFIX; // 0x08
	
			// Constructors
			public MeshMaterialController(); // 0x0000000186805BA0-0x0000000186805BB0
			static MeshMaterialController(); // 0x000000018718D830-0x000000018718D8C0
	
			// Methods
			public void Init(List<RendererInfo> allRendererInfos); // 0x0000000185322430-0x0000000185322520
			public void Reset(); // 0x0000000185322520-0x0000000185322840
			public void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask); // 0x00000001852DFA10-0x00000001852E00F0
			public void SetDepthOnlyPassEnableToAllMaterial(bool enable, EntityVFXRendererMask rendererMask); // 0x000000018CB9A7EC-0x000000018CB9B0B8
			public void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask); // 0x00000001852F48D0-0x00000001852F4F10
			public void ReleaseFloatToAllMaterial(int nameId, EntityVFXRendererMask rendererMask); // 0x000000018CB9A378-0x000000018CB9A4F4
			public void RestoreFloatPropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask); // 0x0000000184DF4220-0x0000000184DF4420
			public void RestoreVectorPropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask); // 0x0000000184DF4620-0x0000000184DF4820
			public void RestoreTexturePropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask); // 0x0000000184DF4420-0x0000000184DF4620
			private static void _RestoreFloatPropertiesFromSource(MeshMaterialGroupData groupData, IReadOnlyList<int> nameIds); // 0x0000000184DF4EB0-0x0000000184DF5280
			private static void _RestoreVectorPropertiesFromSource(MeshMaterialGroupData groupData, IReadOnlyList<int> nameIds); // 0x0000000184DF56C0-0x0000000184DF5B00
			private static void _RestoreTexturePropertiesFromSource(MeshMaterialGroupData groupData, IReadOnlyList<int> nameIds); // 0x0000000184DF5280-0x0000000184DF56C0
			private static bool _HasAnyProperty<T>(Dictionary<int, T> properties, IReadOnlyList<int> nameIds);
			private static void _RemoveProperties<T>(Dictionary<int, T> properties, IReadOnlyList<int> nameIds);
			public void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask, bool multiplyFromSource = false /* Metadata: 0x02643E3C */); // 0x0000000184DF4820-0x0000000184DF4EB0
			public void ReleaseVectorToAllMaterial(int nameId, EntityVFXRendererMask rendererMask); // 0x000000018CB9A670-0x000000018CB9A7EC
			public void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask); // 0x00000001855A5040-0x00000001855A5440
			public void ReleaseTextureToAllMaterial(int nameId, EntityVFXRendererMask rendererMask); // 0x000000018CB9A4F4-0x000000018CB9A670
			[Conditional("UNITY_EDITOR")]
			private void _TryReleaseAllReplaceMaterial(MeshMaterialGroupData groupData); // 0x0000000184DF5B00-0x0000000184DF5B40
			private void _CreateReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData); // 0x00000001852DF040-0x00000001852DF2C0
			private bool _TryEnsureReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData); // 0x00000001852F4F10-0x00000001852F4FF0
			private void _CopyReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData); // 0x000000018CB9B428-0x000000018CB9B6C0
			private void _ReleaseAllReplaceMaterial(MeshMaterialGroupData groupData); // 0x0000000185322FC0-0x0000000185323670
			private void _ReplaceSharedMaterial(RendererInfo rendererInfo, Material[] newMaterials); // 0x00000001852DEEF0-0x00000001852DEF40
			private void _GetAffectGroupData(EntityVFXRendererMask rendererMask, List<MeshMaterialGroupData> result); // 0x0000000185322840-0x0000000185322930
			private void _SplitRenderers(int oldStateIndex, EntityVFXRendererMask newMask); // 0x00000001866CC680-0x00000001866CC7C0
			public void SetZTestInMaterial(string shaderName, bool enable); // 0x000000018CB9B0B8-0x000000018CB9B428
		}
	
		// Constructors
		public EntityRenderHelperMaterialController(); // 0x000000018723F910-0x000000018723F920
		static EntityRenderHelperMaterialController(); // 0x0000000186ED5E10-0x0000000186ED5FB0
	
		// Methods
		public void Init(List<Renderer> allRenderers, List<EntityRendererTypeConfig> configs, EntityCustomizeRendererPropertyConfig customRendererPropertyConfig, bool calculateBoundsWithTransform = true /* Metadata: 0x02643E31 */); // 0x00000001855AB150-0x00000001855AB3F0
		public void OnRelease(); // 0x00000001855A7EC0-0x00000001855A8250
		public void Reset(); // 0x0000000185323670-0x00000001853237B0
		public bool IsAllRendererValid(); // 0x0000000185322E10-0x0000000185322F40
		public void StopShadowCasting(bool stopRayTracing); // 0x00000001855AAAF0-0x00000001855AAB70
		public virtual void RevertShadowCastingMode(); // 0x00000001855AAA80-0x00000001855AAAF0
		public int AddMaterialToAllRenderer(Material material, EntityVFXRendererMask rendererMask, AddMaterialConfig config = default); // 0x00000001852F2900-0x00000001852F2AC0
		public void SetAddictiveFloatProperty(int propertyId, float value); // 0x000000018CB99EF8-0x000000018CB99F50
		public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x02643E32 */); // 0x000000018CB99D94-0x000000018CB99DF4
		public void SetAddictiveVectorProperty(int propertyId, Vector4 value); // 0x000000018CB99FA8-0x000000018CB9A018
		public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default); // 0x000000018CB99E54-0x000000018CB99EF8
		public void SetAddictiveTextureProperty(int propertyId, Texture value); // 0x000000018CB99F50-0x000000018CB99FA8
		public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null); // 0x000000018CB99DF4-0x000000018CB99E54
		public void RemoveMaterialFromAllRenderer(int handle); // 0x00000001852F27E0-0x00000001852F2900
		public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result); // 0x000000018CB99D38-0x000000018CB99D94
		public void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask); // 0x00000001855A6170-0x00000001855A61C0
		public void SetDepthOnlyPassEnableToAllMaterial(bool enable, EntityVFXRendererMask rendererMask); // 0x000000018CB9A018-0x000000018CB9A078
		public void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask); // 0x00000001855A8CC0-0x00000001855A8DB0
		public void SetVectorToCustomPerDraw(EntityRenderHelperVectorCustomPerDrawType type, Vector4 value, EntityVFXRendererMask rendererMask); // 0x000000018CB9A078-0x000000018CB9A164
		public void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask); // 0x00000001855A8E20-0x00000001855A8E70
		public void RestoreFloatPropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask); // 0x0000000184DF4050-0x0000000184DF40B0
		public void RestoreVectorPropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask); // 0x0000000184DF4110-0x0000000184DF4170
		public void RestoreTexturePropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask); // 0x0000000184DF40B0-0x0000000184DF4110
		public void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask, bool multiplyFromSource = false /* Metadata: 0x02643E36 */); // 0x0000000184DF4170-0x0000000184DF4220
		public void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask); // 0x00000001855A4FF0-0x00000001855A5040
		public void FillRendererTypeMasks(Dictionary<Renderer, EntityVFXRendererMask> target); // 0x000000018CB99C18-0x000000018CB99D38
		public void CollectRenderers(EntityVFXRendererMask rendererMask, List<EntityVFXRendererInfo> result); // 0x000000018CB999EC-0x000000018CB99C18
		private List<RendererInfo> _GetRenderersOfRendererMask(EntityVFXRendererMask rendererMask, bool affectAll); // 0x00000001865DEC00-0x00000001865DEEA0
		public void SetManualDitherAlphaValue(float value); // 0x00000001851CCF40-0x00000001851CD130
		public bool SetManualDitherEnable(bool enable); // 0x00000001851CD130-0x00000001851CD270
		public Bounds GetRendererBounds(); // 0x00000001855AAB70-0x00000001855AAE20
		public void SetZTestInMaterial(string shaderName, bool enable); // 0x000000018CB9A164-0x000000018CB9A1C4
		public RenderHelperType GetRenderHelperType(); // 0x00000001859DEC80-0x00000001859DF150
	}

	public enum EntityRenderHelperCustomPerDrawType // TypeDefIndex: 83911
	{
		WetEffectWorldSpaceHeight = 1,
		CharacterDissolveScheduleOffset = 3,
		RainEffectIntensity = 8,
		WetEffectIntensity = 16,
		WetEffectGlobalIntensity = 24,
		SnowEffectIntensity = 32
	}

	public enum EntityRenderHelperVectorCustomPerDrawType // TypeDefIndex: 83912
	{
		Emissive = 1
	}

	public class EntityRenderHelperVisibleController // TypeDefIndex: 83914
	{
		// Fields
		private List<RendererInfo> m_rendererInfos; // 0x10
		private Dictionary<Renderer, RendererInfo> m_dictionary; // 0x18
		private static ObjectPool<List<RendererInfo>> s_rendererInfoListPool; // 0x00
		private static ObjectPool<Dictionary<Renderer, RendererInfo>> s_rendererInfoDictPool; // 0x08
	
		// Nested types
		public class RendererInfo // TypeDefIndex: 83913
		{
			// Fields
			private Renderer m_renderer; // 0x10
			[CompilerGenerated]
			private string _rendererName_k__BackingField; // 0x18
			public bool oriVisible; // 0x20
			public bool curVisible; // 0x21
	
			// Properties
			public string rendererName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			private bool rendererValid { get; } // 0x0000000185322D80-0x0000000185322E10 
	
			// Constructors
			public RendererInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool TryInit(Renderer renderer); // 0x00000001851043E0-0x0000000185104520
			private void _Init(Renderer renderer); // 0x0000000185104520-0x00000001851045C0
			public bool TryAddToDictionary(Dictionary<Renderer, RendererInfo> dictionary); // 0x000000018CBA940C-0x000000018CBA9490
			public bool TrySetVisible(bool visible); // 0x0000000185982230-0x00000001859822A0
			public bool TrySetVisibleByRenderer(bool visible); // 0x000000018CBA9554-0x000000018CBA95D4
			public bool TryResetVisible(); // 0x0000000185322CE0-0x0000000185322D80
			public bool TryOverrideOriginalVisible(Renderer[] disabledRenderers, bool reset); // 0x000000018CBA9490-0x000000018CBA9554
		}
	
		// Constructors
		public EntityRenderHelperVisibleController(); // 0x0000000186805BA0-0x0000000186805BB0
		static EntityRenderHelperVisibleController(); // 0x00000001870A2370-0x00000001870A2460
	
		// Methods
		public void Init(List<Renderer> allRenderers); // 0x00000001851042C0-0x00000001851043E0
		private void _InitDictionary(); // 0x000000018CBA0D80-0x000000018CBA0F14
		private bool _TryGetRendererInfo(Renderer renderer, bool initDictionary, out RendererInfo rendererInfo); // 0x000000018CBA0F14-0x000000018CBA0FF4
		public void Release(); // 0x00000001855A7AB0-0x00000001855A7B50
		public void SetVisibleByNameContainsStr(string name, bool visible); // 0x0000000185982140-0x0000000185982230
		public void SetVisibleByRenderer(Renderer renderer, bool visible); // 0x000000018CBA0CF4-0x000000018CBA0D80
		public void ResetVisibleByNameContainsStr(string name); // 0x000000018CBA0BB4-0x000000018CBA0C78
		public void ResetVisibleByRenderer(Renderer renderer); // 0x000000018CBA0C78-0x000000018CBA0CF4
		public void Reset(); // 0x0000000185322BD0-0x0000000185322CE0
		public void OverrideOriginalVisibleByDisabledRenderers(Renderer[] disabledRenderers, bool reset); // 0x000000018CBA0B0C-0x000000018CBA0BB4
	}

	public class EntityRenderMaterialManager // TypeDefIndex: 83915
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
		public EntityRenderMaterialManager(); // 0x000000018CBA21B0-0x000000018CBA2334
		static EntityRenderMaterialManager(); // 0x000000018CBA2188-0x000000018CBA21B0
	
		// Methods
		public void SetFloat(int nameID, float value); // 0x000000018CBA1A3C-0x000000018CBA1AF8
		public void SetTexture(int nameID, Texture value); // 0x000000018CBA1CA0-0x000000018CBA1D5C
		public void SetVector(int nameID, Vector4 value); // 0x000000018CBA1D5C-0x000000018CBA1E3C
		public void AddMaterial(Material material); // 0x000000018CBA0FF4-0x000000018CBA1568
		public void RemoveMaterial(Material material); // 0x000000018CBA16BC-0x000000018CBA1734
		public void ClearMaterials(); // 0x000000018CBA1568-0x000000018CBA16BC
		public void SetKeywordEnable(string keyword, bool enable); // 0x000000018CBA1AF8-0x000000018CBA1CA0
		public void SetDepthOnlyEnabled(bool enable); // 0x000000018CBA1734-0x000000018CBA1A3C
		public void SetZTestInMaterial(string shaderName, bool enable); // 0x000000018CBA1E3C-0x000000018CBA1F7C
		private void _RevertMaterial(Material material); // 0x000000018CBA1F7C-0x000000018CBA2188
	}

	[Serializable]
	public class EntityVFXCurve // TypeDefIndex: 83916
	{
		// Fields
		public AnimationCurve curve; // 0x10
		public Vector2 rangeEdit; // 0x18
		public Vector2 rangeLimit; // 0x20
	
		// Constructors
		public EntityVFXCurve(AnimationCurve curve); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public struct EntityVFXCurveEvaluateResult // TypeDefIndex: 83917
	{
		// Fields
		public ShaderPropertyType propertyType; // 0x00
		public string propertyName; // 0x08
		public int propertyId; // 0x10
		public float floatValue; // 0x14
		public Vector4 vectorValue; // 0x18
		public Vector4 textureScaleOffset; // 0x28
	}

	public struct AddMaterialConfig // TypeDefIndex: 83918
	{
		// Fields
		public bool useColorTexture; // 0x00
		public string colorTextureName; // 0x08
	
		// Properties
		public bool useCustomizeProperty { get; } // 0x000000018CB9FDBC-0x000000018CB9FDFC 
	}

	public enum EEntityVFXColorMode // TypeDefIndex: 83919
	{
		Override = 0,
		Multiply = 1
	}

	[Serializable]
	public class EntityVFXCurveData // TypeDefIndex: 83920
	{
		// Fields
		[NonSerialized]
		private string m_cachedPropertyName; // 0x10
		[NonSerialized]
		private int m_cachedPropertyId; // 0x18
		public string propertyName; // 0x20
		public ShaderPropertyType propertyType; // 0x28
		public EntityVFXCurve curve; // 0x30
		public EntityVFXCurve curveX; // 0x38
		public EntityVFXCurve curveY; // 0x40
		public EntityVFXCurve curveZ; // 0x48
		public EntityVFXCurve curveW; // 0x50
		public Gradient gradient; // 0x58
		[Tooltip("\u4EC5 SetParams \u751F\u6548\u3002\u4E58\u6CD5\u4F7F\u7528\u5404\u6750\u8D28\u539F\u59CB\u989C\u8272\u4E58\u4EE5\u6E10\u53D8\u91C7\u6837\u503C\uFF08\u542B\u989C\u8272\u5F3A\u5EA6\uFF09\uFF0C\u4E0D\u4F1A\u9010\u5E27\u7D2F\u4E58\u3002")]
		public EEntityVFXColorMode colorMode; // 0x60
		[Range(1f, 100f)]
		public float colorIntensity; // 0x64
	
		// Properties
		public int propertyId { get; } // 0x000000018CBA2E0C-0x000000018CBA2E88 
	
		// Constructors
		public EntityVFXCurveData(); // 0x0000000187105730-0x0000000187105740
	}

	[Serializable]
	public class EntityVFXAddictiveMaterialData // TypeDefIndex: 83921
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
		public EntityVFXAddictiveMaterialData(); // 0x0000000186ADFB60-0x0000000186ADFBB0
	}

	public class EntityVFXAddictiveMaterialAsset : EntityVFXAssetBase // TypeDefIndex: 83922
	{
		// Fields
		public EntityVFXAddictiveMaterialData data; // 0x30
	
		// Constructors
		public EntityVFXAddictiveMaterialAsset(); // 0x0000000186BA7740-0x0000000186BA7750
	}

	[Serializable]
	public class EntityVFXAfterImageData // TypeDefIndex: 83924
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
		public enum TimeMode // TypeDefIndex: 83923
		{
			Interval = 0,
			Burst = 1
		}
	
		// Constructors
		public EntityVFXAfterImageData(); // 0x00000001871F2A00-0x00000001871F2A20
	}

	public class EntityVFXAfterImageAsset : EntityVFXAssetBase // TypeDefIndex: 83925
	{
		// Fields
		[SerializeField]
		public EntityVFXAfterImageData data; // 0x30
	
		// Constructors
		public EntityVFXAfterImageAsset(); // 0x0000000186BA7740-0x0000000186BA7750
	}

	[Serializable]
	public struct EntityCustomizeRendererType // TypeDefIndex: 83926
	{
		// Fields
		public bool useContainStr; // 0x00
		public string rendererNameRegex; // 0x08
		public EntityVFXRendererType type; // 0x10
	}

	public class EntityVFXAsset : ScriptableObject // TypeDefIndex: 83927
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
		public EntityVFXAsset(); // 0x0000000186D22BE0-0x0000000186D22C40
	
		// Methods
		public List<EntityRendererTypeConfig> GetRendererTypeConfigs(bool forceUpdate); // 0x0000000185A0AEC0-0x0000000185A0B0D0
	}

	public enum EntityVFXRendererType // TypeDefIndex: 83928
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
	public enum EntityVFXRendererMask // TypeDefIndex: 83929
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

	public enum EntityVFXPriorityType // TypeDefIndex: 83930
	{
		Normal = 0,
		UltiSkillTimeline = 1
	}

	[Flags]
	public enum SettingLodLevel // TypeDefIndex: 83931
	{
		None = 0,
		Low = 1,
		Mid = 2,
		High = 4,
		Highest = 8
	}

	[Flags]
	public enum AssetPlatformLayers // TypeDefIndex: 83932
	{
		PC = 1,
		Mobile = 2,
		Other = 4
	}

	[Flags]
	public enum EffectTargetLayers // TypeDefIndex: 83933
	{
		Main = 1,
		Guard = 2
	}

	public class EntityVFXAssetBase : ScriptableObject // TypeDefIndex: 83934
	{
		// Fields
		[SerializeField]
		public bool useECSRenderer; // 0x18
		public SettingLodLevel settingLodLevel; // 0x1C
		public AssetPlatformLayers platformLayer; // 0x20
		public EffectTargetLayers targetLayer; // 0x24
		private string m_assetName; // 0x28
	
		// Properties
		public string assetName { get; } // 0x000000018CBA2334-0x000000018CBA239C 
	
		// Constructors
		public EntityVFXAssetBase(); // 0x000000018783D234-0x000000018783D250
	}

	public enum VFXType // TypeDefIndex: 83935
	{
		Addictive = 0,
		Dissolve = 1,
		Max = 2
	}

	public class EntityVFXControllerBase // TypeDefIndex: 83936
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
		public bool isPlaying { get; } // 0x000000018CBA28F8-0x000000018CBA293C 
		public virtual bool isStopping { get; } // 0x000000018CBA293C-0x000000018CBA297C 
		public bool isHiding { get; } // 0x000000018CBA2870-0x000000018CBA28B4 
		public bool isKeyword { get; } // 0x000000018CBA28B4-0x000000018CBA28F8 
		public string vfxName { get; } // 0x000000018CBA29C0-0x000000018CBA2A00 
		public float destroyTime { get; set; } // 0x000000018CBA282C-0x000000018CBA2870 0x000000018CBA2A00-0x000000018CBA2A44
		public float lastTickTime { get; set; } // 0x000000018CBA297C-0x000000018CBA29C0 0x000000018CBA2A44-0x000000018CBA2A88
	
		// Constructors
		public EntityVFXControllerBase(); // 0x000000018723BB70-0x000000018723BB90
	
		// Methods
		public void SetOwner(string name, IRendererHelper owner); // 0x0000000186890880-0x00000001868908D0
		public void InitLOD(EntityVFXAssetBase vfxAssetBase); // 0x0000000186213840-0x0000000186213880
		public void SetName(string name); // 0x000000018CBA2740-0x000000018CBA2780
		public bool PoolTick(); // 0x000000018CBA267C-0x000000018CBA26B8
		public void Destroy(); // 0x000000018CBA239C-0x000000018CBA2468
		protected virtual void OnDestroy(); // 0x000000018CBA256C-0x000000018CBA25A0
		public virtual void Play(); // 0x000000018CBA2648-0x000000018CBA267C
		public virtual void Stop(bool forceStop); // 0x000000018CBA27C0-0x000000018CBA27F8
		public virtual void Replay(); // 0x000000018CBA26B8-0x000000018CBA26EC
		public virtual void Tick(float logicDeltaTime); // 0x000000018CBA27F8-0x000000018CBA282C
		protected void RefreshLastTickTime(); // 0x00000001855A6A50-0x00000001855A6A90
		protected float GetDeltaTimeFromLastTick(bool useScaledTime); // 0x00000001855A6FD0-0x00000001855A7090
		public virtual EntityVFXPriorityType GetPriorityType(); // 0x000000018CBA24A8-0x000000018CBA24E8
		public virtual EntityVFXRendererMask GetRendererMask(); // 0x000000018CBA24E8-0x000000018CBA252C
		public virtual bool GetAllowSimultaneousKeyword(); // 0x000000018CBA2468-0x000000018CBA24A8
		public virtual bool GetNeedTick(); // 0x00000001868526A0-0x00000001868526D0
		public void Hide(); // 0x000000018CBA252C-0x000000018CBA256C
		protected virtual void OnHide(); // 0x000000018CBA25A0-0x000000018CBA25D4
		public void Show(); // 0x000000018CBA2780-0x000000018CBA27C0
		protected virtual void OnShow(); // 0x000000018CBA2614-0x000000018CBA2648
		public void Sample(float time, bool ending = false /* Metadata: 0x02643EC4 */); // 0x000000018CBA26EC-0x000000018CBA2740
		protected virtual void OnSample(float time, bool ending); // 0x000000018CBA25D4-0x000000018CBA2614
	}

	public abstract class EntityVFXControllerStateBase : EntityVFXControllerBase // TypeDefIndex: 83938
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
		protected float m_passTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		protected float m_loopPassTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		protected float m_endPassTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public override bool isStopping { get; } // 0x000000018CBA2C50-0x000000018CBA2C88 
		protected virtual bool useScaledTime { get; } // 0x000000018CBA2D8C-0x000000018CBA2DCC 
		protected virtual bool useStartCurve { get; } // 0x000000018CBA2DCC-0x000000018CBA2E0C 
		protected virtual bool useLoopCurve { get; } // 0x000000018CBA2D4C-0x000000018CBA2D8C 
		protected virtual bool useEndCurve { get; } // 0x000000018CBA2D0C-0x000000018CBA2D4C 
		protected virtual bool loop { get; } // 0x000000018CBA2CCC-0x000000018CBA2D0C 
		protected virtual float duration { get; } // 0x000000018CBA2BCC-0x000000018CBA2C10 
		protected virtual float loopDuration { get; } // 0x000000018CBA2C88-0x000000018CBA2CCC 
		protected virtual float endDuration { get; } // 0x000000018CBA2C10-0x000000018CBA2C50 
	
		// Nested types
		private enum State // TypeDefIndex: 83937
		{
			End = 0,
			Start = 1,
			Loop = 2,
			Ending = 3
		}
	
		// Constructors
		protected EntityVFXControllerStateBase(); // 0x000000018723BB70-0x000000018723BB90
	
		// Methods
		public override void Play(); // 0x00000001855A5840-0x00000001855A58A0
		public override void Replay(); // 0x000000018CBA2B80-0x000000018CBA2BCC
		public override void Stop(bool forceStop); // 0x0000000186978100-0x0000000186978160
		public override bool GetNeedTick(); // 0x00000001865D0AF0-0x00000001865D0B40
		public override void Tick(float logicDeltaTime); // 0x00000001855A6E40-0x00000001855A6FD0
		protected override void OnSample(float time, bool ending); // 0x000000018CBA2A88-0x000000018CBA2B80
		protected abstract void UpdateStart();
		protected abstract void UpdateLoop();
		protected abstract void UpdateStop();
		private void _FinalStop(); // 0x0000000186978160-0x00000001869781A0
		protected abstract void OnFinalStop();
		public bool __iFixBaseProxy_get_isStopping(); // 0x0000000188D9D818-0x0000000188D9D820
		public void __iFixBaseProxy_Play(); // 0x0000000188D9D7F8-0x0000000188D9D800
		public void __iFixBaseProxy_Replay(); // 0x0000000188D9D800-0x0000000188D9D808
		public void __iFixBaseProxy_Stop(bool P0); // 0x0000000188D9D808-0x0000000188D9D810
		public bool __iFixBaseProxy_GetNeedTick(); // 0x000000018225DF70-0x000000018225DF80
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188D9D810-0x0000000188D9D818
		public void __iFixBaseProxy_OnSample(float P0, bool P1); // 0x0000000188D9D7E8-0x0000000188D9D7F0
	}

	public enum EntityCustomizePropertyName // TypeDefIndex: 83939
	{
		None = 0,
		AlphaTex = 1,
		NormalTex = 2
	}

	public enum EntityCustomizeMatchMethod // TypeDefIndex: 83940
	{
		None = 0,
		All = 1,
		RendererName = 2,
		SourceMaterial0 = 3,
		SourceMesh = 4
	}

	[Serializable]
	public class EntityCustomizeRendererPropertyConfig // TypeDefIndex: 83941
	{
		// Fields
		public bool useColorTexture; // 0x10
		public bool useAutoFindColorTexture; // 0x11
		public string autoFindColorTextureName; // 0x18
		public SerializeFieldDictionary<Material, Texture> preConfigColorTextureDict; // 0x20
	
		// Constructors
		public EntityCustomizeRendererPropertyConfig(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public Texture GetColorTexture(Material material); // 0x000000018CBA0A88-0x000000018CBA0B0C
	}

	public enum EntityVFXKeywordEnum // TypeDefIndex: 83942
	{
		None = 0,
		Dissolve = 1
	}

	[Serializable]
	public class EntityVFXDissolveData // TypeDefIndex: 83944
	{
		// Fields
		public EntityVFXPriorityType priorityType; // 0x10
		public EntityVFXRendererMask rendererMask; // 0x14
		public bool useScaledTime; // 0x18
		public bool allowSimultaneous; // 0x19
		public bool loop; // 0x1A
		public float duration; // 0x1C
		public UVSet uvSet; // 0x20
		public bool restoreMaterialPropertiesOnStop; // 0x24
		public bool useCutoffPosY; // 0x25
		public bool useCutoffPosYAutoBounds; // 0x26
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
		public enum UVSet // TypeDefIndex: 83943
		{
			UV = 0,
			UV2 = 1
		}
	
		// Constructors
		public EntityVFXDissolveData(); // 0x0000000186C05980-0x0000000186C059E0
	}

	public class EntityVFXDissolveAsset : EntityVFXAssetBase // TypeDefIndex: 83945
	{
		// Fields
		[SerializeField]
		public EntityVFXDissolveData data; // 0x30
	
		// Constructors
		public EntityVFXDissolveAsset(); // 0x0000000186BA7740-0x0000000186BA7750
	}

	public class EntityFactoryRendererInfo // TypeDefIndex: 83946
	{
		// Fields
		public int subMeshCount; // 0x10
		public bool enableVAT; // 0x14
		public int vatIndex; // 0x18
		public int initMaterialsCount; // 0x1C
	
		// Constructors
		public EntityFactoryRendererInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class EntityVFXFactoryAddedMaterialManager // TypeDefIndex: 83951
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
		public class VATData // TypeDefIndex: 83947
		{
			// Fields
			public Texture factoryVATMap; // 0x10
			public Vector4 factoryVATMapParams; // 0x18
	
			// Constructors
			public VATData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class AddedMaterialData // TypeDefIndex: 83948
		{
			// Fields
			public Material srcMaterial; // 0x10
			public Material[] materialInstancesOfEachVAT; // 0x18
			public Dictionary<int, float> savedFloatProperties; // 0x20
			public Dictionary<int, Vector4> savedVectorProperties; // 0x28
	
			// Constructors
			public AddedMaterialData(); // 0x000000018CB9FDFC-0x000000018CB9FE7C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 83949
		{
			// Fields
			public Material src; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool __GetAddedMaterialIndex_b__0(AddedMaterialData data); // 0x0000000188E1793C-0x0000000188E17990
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 83950
		{
			// Fields
			public Material src; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool __RemoveVATMaterial_b__0(AddedMaterialData data); // 0x0000000188E1793C-0x0000000188E17990
		}
	
		// Constructors
		public EntityVFXFactoryAddedMaterialManager(); // 0x000000018CBA38FC-0x000000018CBA39E4
		static EntityVFXFactoryAddedMaterialManager(); // 0x000000018CBA3894-0x000000018CBA38FC
	
		// Methods
		public void Init(List<EntityFactoryRendererInfo> factoryRendererInfos); // 0x000000018CBA2F0C-0x000000018CBA3014
		private void _AddVATMaterial(Material src); // 0x000000018CBA3354-0x000000018CBA3610
		private Material _GetVATMaterial(EntityFactoryRendererInfo rendererInfo, Material src); // 0x000000018CBA36F4-0x000000018CBA3790
		private int _GetAddedMaterialIndex(EntityFactoryRendererInfo rendererInfo, Material src); // 0x000000018CBA3610-0x000000018CBA36F4
		private void _RemoveVATMaterial(Material src); // 0x000000018CBA3790-0x000000018CBA3894
		public void AddMaterialToAllRenderer(Material material); // 0x000000018CBA2E88-0x000000018CBA2F0C
		public void RemoveMaterialFromAllRenderer(Material material); // 0x000000018CBA3014-0x000000018CBA3150
		public void SetFloatToFactoryMaterial(Material material, int nameId, float value); // 0x000000018CBA3150-0x000000018CBA3244
		public void SetVectorToFactoryMaterial(Material material, int nameId, Vector4 value); // 0x000000018CBA3244-0x000000018CBA3354
	}

	public static class EntityVFXFactoryMaterialCache // TypeDefIndex: 83953
	{
		// Fields
		private static readonly int S_FACTORY_VAT_MAP; // 0x00
		private static readonly int S_FACTORY_VAT_MAP_PARAMS; // 0x04
		private static Dictionary<int, Dictionary<int, VATMaterialData>> s_cachedMaterials; // 0x08
	
		// Nested types
		public class VATMaterialData // TypeDefIndex: 83952
		{
			// Fields
			public int refCount; // 0x10
			public Material vatMaterial; // 0x18
	
			// Constructors
			public VATMaterialData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		static EntityVFXFactoryMaterialCache(); // 0x000000018CBA3E08-0x000000018CBA3EA4
	
		// Methods
		public static Material GetVATMaterial(Material srcMaterial, Texture factoryVATMap, Vector4 factoryVATMapParams); // 0x000000018CBA39E4-0x000000018CBA3C5C
		public static void ReleaseVATMaterial(Material srcMaterial, Texture factoryVATMap); // 0x000000018CBA3C5C-0x000000018CBA3E08
	}

	[Serializable]
	public class EntityVFXScreenParticleEmitData // TypeDefIndex: 83954
	{
		// Fields
		public EntityVFXPriorityType priorityType; // 0x10
		public EntityVFXRendererMask rendererMask; // 0x14
		public bool useScaledTime; // 0x18
		public HGMaterial material; // 0x20
		[Min(1f)]
		public int maxEmitCountPerCamera; // 0x28
		public HGMaterial computeMaterial; // 0x30
		public HGMaterial renderMaterial; // 0x38
		public Mesh mesh; // 0x40
		[Min(1f)]
		public int maxParticleCount; // 0x48
		public ShadowCastingMode castShadows; // 0x4C
		public bool loop; // 0x50
		[Min(0.001f)]
		public float duration; // 0x54
		public bool useIntensityCurve; // 0x58
		public AnimationCurve intensityCurve; // 0x60
	
		// Constructors
		public EntityVFXScreenParticleEmitData(); // 0x000000018CBA3EA4-0x000000018CBA3F00
	}

	public class EntityVFXScreenParticleEmitAsset : EntityVFXAssetBase // TypeDefIndex: 83955
	{
		// Fields
		[SerializeField]
		public EntityVFXScreenParticleEmitData data; // 0x30
	
		// Constructors
		public EntityVFXScreenParticleEmitAsset(); // 0x0000000186BA7740-0x0000000186BA7750
	}

	[Serializable]
	public class EntityVFXSetParamsData // TypeDefIndex: 83957
	{
		// Fields
		public EntityVFXPriorityType priorityType; // 0x10
		public EntityVFXRendererMask rendererMask; // 0x14
		public bool useScaledTime; // 0x18
		public bool loop; // 0x19
		public bool useDitherAlphaCurve; // 0x1A
		public Type type; // 0x1C
		[Min(0f)]
		public float duration; // 0x20
		public List<EntityVFXCurveData> customCurves; // 0x28
		public AnimationCurve ditherAlphaCurve; // 0x30
		public bool useLoopCurve; // 0x38
		[Min(0.001f)]
		public float loopDuration; // 0x3C
		public List<EntityVFXCurveData> customLoopCurves; // 0x40
		public AnimationCurve ditherAlphaLoopCurve; // 0x48
		[Min(0.001f)]
		public float endDuration; // 0x50
		public bool restoreMaterialPropertiesOnStop; // 0x54
		public List<EntityVFXCurveData> customEndCurves; // 0x58
		public AnimationCurve ditherAlphaEndCurve; // 0x60
	
		// Nested types
		public enum Type // TypeDefIndex: 83956
		{
			Character = 0,
			VFX = 1,
			Lit = 2
		}
	
		// Constructors
		public EntityVFXSetParamsData(); // 0x00000001872302B0-0x00000001872302D0
	}

	public class EntityVFXSetParamsAsset : EntityVFXAssetBase // TypeDefIndex: 83958
	{
		// Fields
		[SerializeField]
		public EntityVFXSetParamsData data; // 0x30
	
		// Constructors
		public EntityVFXSetParamsAsset(); // 0x0000000186BA7740-0x0000000186BA7750
	}

	public static class EntityVFXUtils // TypeDefIndex: 83959
	{
		// Methods
		public static void CalculateCutOffBounds(IRendererHelper owner, bool useCutoffLocalDirection, Vector3 cutoffDirectionData, bool useCutoffPosYAutoBounds, float cutoffPosYAbsoluteBounds, out float cutoffMin, out float cutoffMax, out Vector3 cutoffDirection); // 0x00000001855A9270-0x00000001855A94E0
		public static ValueTuple<float, float> GetBoundsMinMaxOfDirection(Bounds bounds, Vector3 direction); // 0x00000001855A8E70-0x00000001855A91E0
		public static void ApplyEntityVFXCurves(Material material, List<EntityVFXCurveData> curveDataList, float schedule); // 0x000000018CBA3F00-0x000000018CBA4020
		public static EntityVFXCurveEvaluateResult Evaluate(EntityVFXCurveData curveData, float schedule); // 0x000000018CBA4020-0x000000018CBA43A4
		private static void _UpdateCurve(Material material, EntityVFXCurveData curveData, float schedule); // 0x000000018CBA4420-0x000000018CBA45A0
		public static bool IsCharacterShader(string name); // 0x000000018CBA43A4-0x000000018CBA4420
		public static bool IsLitShader(string name); // 0x000000018CB97B0C-0x000000018CB97B88
	
		// Extension methods
		public static EntityVFXRendererMask ToMask(this EntityVFXRendererType type); // 0x00000001855AB750-0x00000001855AB780
	}

	public interface ICaptureMesh // TypeDefIndex: 83960
	{
		// Methods
		EntityRenderCapturedEntity Capture(GameObject placeRoot, EntityVFXRendererMask rendererMask);
		void Release(EntityRenderCapturedEntity mesh);
	}

	public interface IEntityVFXTimelineHost // TypeDefIndex: 83961
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

	public enum RenderHelperType // TypeDefIndex: 83962
	{
		Unknown = 0,
		Character = 1,
		Lit = 2,
		Mix = 4
	}

	public struct EntityVFXRendererInfo // TypeDefIndex: 83963
	{
		// Fields
		public Renderer renderer; // 0x00
		public EntityVFXRendererMask typeMask; // 0x08
		public int subMeshCount; // 0x0C
	}

	public interface IRendererHelper // TypeDefIndex: 83964
	{
		// Methods
		void Reset();
		void Play(string vfxName);
		void Stop(string vfxName);
		void ShowAll();
		void HideAll();
		void SetDitherAlpha(float ditherAlpha, int handle = 0 /* Metadata: 0x02643EDC */);
		float GetDitherAlpha();
		void ResetAllDitherAlpha();
		void ClearEffectCache(string name);
		void OnEntityVFXControllerDestroying(EntityVFXControllerBase controller);
		void SetVisibleByNameContainsStr(string name, bool visible);
		void SetVisibleByRenderer(Renderer renderer, bool visible);
		void CollectRenderers(EntityVFXRendererMask rendererMask, List<EntityVFXRendererInfo> result);
		int AddMaterialToAllRenderer(Material material, EntityVFXRendererMask rendererMask, AddMaterialConfig config = default);
		void RemoveMaterialFromAllRenderer(int handle);
		bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result);
		void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask);
		void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask);
		void RestoreFloatPropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask);
		void RestoreVectorPropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask);
		void RestoreTexturePropertiesFromSource(IReadOnlyList<int> nameIds, EntityVFXRendererMask rendererMask);
		void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask);
		void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask);
		void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask, bool multiplyFromSource = false /* Metadata: 0x02643EDD */);
		void SetFloatToFactoryMaterial(Material material, int nameId, float value);
		void SetVectorToFactoryMaterial(Material material, int nameId, Vector4 value);
		void SetAddictiveFloatProperty(int propertyId, float value);
		float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x02643EDE */);
		void SetAddictiveVectorProperty(int propertyId, Vector4 value);
		Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default);
		void SetAddictiveTextureProperty(int propertyId, Texture value);
		Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null);
		void StopShadowCasting(bool stopRayTracing = false /* Metadata: 0x02643EE2 */);
		void RevertShadowCastingMode();
		void SetDepthOnlyEnabledToAllMaterial(bool enable, EntityVFXRendererMask rendererMask);
		bool SetManualDitherEnable(bool enable);
		void SetManualDitherAlphaValue(float value);
		Bounds GetRendererBounds();
		Matrix4x4 GetTransform();
		bool IsFactory();
		RenderHelperType GetRenderHelperType(bool forceCalculate = true /* Metadata: 0x02643EE3 */);
		void SetTimeScale(float timeScale);
		float GetTimeScale();
		bool GetMeshHasVFXVertColor();
		bool CanPlay(SettingLodLevel settingLodLevel, AssetPlatformLayers platformLayer, EffectTargetLayers targetLayer);
	}

	public class CommonVAT : MonoBehaviour // TypeDefIndex: 83965
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
		public string PropertySetterType { get; } // 0x000000018CBA0A14-0x000000018CBA0A88 
	
		// Constructors
		public CommonVAT(); // 0x000000018CBA0980-0x000000018CBA0A14
		static CommonVAT(); // 0x000000018CBA0958-0x000000018CBA0980
	
		// Methods
		private void Start(); // 0x000000018CBA0240-0x000000018CBA0440
		public void Play(string name, bool playWhenComplete = false /* Metadata: 0x02643EE4 */); // 0x000000018CBA01D0-0x000000018CBA0240
		private void _DoPlay(string name); // 0x000000018CBA0588-0x000000018CBA0700
		private void _NextPlay(); // 0x000000018CBA0700-0x000000018CBA086C
		private void _CreateTimer(float time, Action func, string funcName); // 0x000000018CBA04B8-0x000000018CBA0588
		private void _ClearTimer(); // 0x000000018CBA0440-0x000000018CBA04B8
		private void _UpdateProperty(RuntimeVATAnimationClip runtimeVatAnimationClip); // 0x000000018CBA086C-0x000000018CBA0958
	}

	public class FactoryVAT : MonoBehaviour // TypeDefIndex: 83966
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
		public FactoryVAT(); // 0x000000018CBA5158-0x000000018CBA5298
		static FactoryVAT(); // 0x000000018CBA5110-0x000000018CBA5158
	
		// Methods
		private void Start(); // 0x000000018CBA46A8-0x000000018CBA4820
		public void Reset(); // 0x000000018CBA4670-0x000000018CBA46A8
		private void _UpdateAnim(); // 0x000000018CBA4F44-0x000000018CBA5110
		public void OnUpdate(); // 0x000000018CBA45A0-0x000000018CBA45D8
		public void Play(string name, Action callBack = null, bool whenComplete = false /* Metadata: 0x02643EE5 */); // 0x000000018CBA45D8-0x000000018CBA4670
		private void _DoPlay(string name, Action callBack); // 0x000000018CBA4820-0x000000018CBA4904
		private void _InitRenderer(); // 0x000000018CBA4B34-0x000000018CBA4BF0
		private void _InitRenderer_MeshRender(LODGroup lodGroup); // 0x000000018CBA4904-0x000000018CBA4B34
		private void _SetParamsToRenderer(); // 0x000000018CBA4F0C-0x000000018CBA4F44
		private void _SetParamsToRenderer_MeshRender(); // 0x000000018CBA4E20-0x000000018CBA4F0C
		private void _ReSetParamsToRenderer(); // 0x000000018CBA4DE8-0x000000018CBA4E20
		private void _ReSetParamsToRenderer_MeshRender(); // 0x000000018CBA4BF0-0x000000018CBA4DE8
	}

	[Serializable]
	public class RuntimeVATAnimationClip // TypeDefIndex: 83967
	{
		// Fields
		public string stateName; // 0x10
		public string name; // 0x18
		public bool loop; // 0x20
		public int startFrame; // 0x24
		public int endFrame; // 0x28
	
		// Constructors
		public RuntimeVATAnimationClip(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class RuntimeVATData // TypeDefIndex: 83968
	{
		// Fields
		public Texture vatMap; // 0x10
		public bool fullRigidBody; // 0x18
		public List<Matrix4x4> bonePoses; // 0x20
		public float frameRate; // 0x28
		public List<RuntimeVATAnimationClip> animationClips; // 0x30
	
		// Constructors
		public RuntimeVATData(); // 0x000000018CBA95D4-0x000000018CBA9624
	}

	public abstract class VATPropertySetter // TypeDefIndex: 83969
	{
		// Constructors
		protected VATPropertySetter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract void Init(GameObject gameObject);
		public abstract void SetFloat(int id, float value);
		public abstract void SetVector(int id, Vector4 value);
	}

	public class VATRendererPropertySetter : VATPropertySetter // TypeDefIndex: 83970
	{
		// Fields
		private List<Renderer> m_allRenderers; // 0x10
		private List<Material> m_allMaterials; // 0x18
	
		// Constructors
		public VATRendererPropertySetter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Init(GameObject gameObject); // 0x000000018CBAD964-0x000000018CBADB58
		public override void SetFloat(int id, float value); // 0x000000018CBADB58-0x000000018CBADC94
		public override void SetVector(int id, Vector4 value); // 0x000000018CBADC94-0x000000018CBADDF0
	}

	public class VATEntityRendererHelperPropertySetter : VATPropertySetter // TypeDefIndex: 83971
	{
		// Fields
		private IRendererHelper m_rendererHelper; // 0x10
	
		// Constructors
		public VATEntityRendererHelperPropertySetter(IRendererHelper rendererHelper); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void Init(GameObject gameObject); // 0x000000018CBAD854-0x000000018CBAD88C
		public override void SetFloat(int id, float value); // 0x000000018CBAD88C-0x000000018CBAD8E8
		public override void SetVector(int id, Vector4 value); // 0x000000018CBAD8E8-0x000000018CBAD964
	}

	public class PsoCreateUploadHelper // TypeDefIndex: 83979
	{
		// Fields
		protected const int PSO_UPLOAD_INFO_VERSION = 1; // Metadata: 0x02643EE6
		protected const int MAX_UPLOAD_COUNT_PER_LOOP = 128; // Metadata: 0x02643EE7
		protected const int MAX_UPLOAD_COUNT_PER_LOOP_LARGE = 256; // Metadata: 0x02643EE9
		protected const int MAX_UPLOAD_SIZE_PER_LOOP = 786432; // Metadata: 0x02643EEB
		protected const int MAX_UPLOAD_SIZE_PER_LOOP_LARGE = 5242880; // Metadata: 0x02643EEF
		protected const float TICK_INTERVAL = 0.55f; // Metadata: 0x02643EF3
		protected const int TICK_UPLOAD_INTERVAL = 60; // Metadata: 0x02643EF7
		protected const float CREATE_TIME_SMALL_DROP = 0.5f; // Metadata: 0x02643EF8
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
		private const string URL = "http://beyondtools.int.hypergryph.com:42422"; // Metadata: 0x02643EFC
		private const string TOKEN = "fhlasdfu8731fqa"; // Metadata: 0x02643F28
		private static SynchronizationContext s_mainSyncContext; // 0x30
		private static int s_mainThreadId; // 0x38
	
		// Properties
		public static PsoCreateUploadHelper instance { get; } // 0x00000001862B3320-0x00000001862B3400 
		private static string persistentDataPath { get; } // 0x000000018CBA921C-0x000000018CBA93BC 
	
		// Nested types
		[Serializable]
		private class PsoInfoWrapperItem // TypeDefIndex: 83972
		{
			// Fields
			public string infoJson; // 0x10
			public float time; // 0x18
			public int codeSize; // 0x1C
			public bool isMissing; // 0x20
			public string levelId; // 0x28
	
			// Constructors
			public PsoInfoWrapperItem(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		private class PsoInfoWrapper // TypeDefIndex: 83973
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
			public PsoInfoWrapper(); // 0x000000018CBA93BC-0x000000018CBA940C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0 // TypeDefIndex: 83974
		{
			// Fields
			public string path; // 0x10
			public string serverFileName; // 0x18
			public PsoInfoWrapper psoInfoWrapper; // 0x20
	
			// Constructors
			public __c__DisplayClass36_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __CreateAndUploadFinalJson_b__0(object param); // 0x000000018CBABD68-0x000000018CBABDB8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 83975
		{
			// Fields
			public string urlPath; // 0x10
			public string rawFilePath; // 0x18
			public string serverFileNameOverride; // 0x20
			public Action<bool, string, string> callback; // 0x28
	
			// Constructors
			public __c__DisplayClass42_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __UploadFile_b__0(object param); // 0x000000018CBABF98-0x000000018CBAC000
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 83976
		{
			// Fields
			public Action<bool, string, string> callback; // 0x10
			public string fileServerUrl; // 0x18
			public string errorMessage; // 0x20
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __UploadFileToServer_b__1(object _); // 0x000000018CBAC000-0x000000018CBAC038
			internal void __UploadFileToServer_b__2(object _); // 0x000000018CBAC000-0x000000018CBAC038
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_1 // TypeDefIndex: 83977
		{
			// Fields
			public string result; // 0x10
			public __c__DisplayClass43_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass43_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __UploadFileToServer_b__0(object _); // 0x000000018CBAC038-0x000000018CBAC07C
		}
	
		[CompilerGenerated]
		private struct __UploadFileToServer_d__43 : IAsyncStateMachine // TypeDefIndex: 83978
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
			private void MoveNext(); // 0x000000018CBAC14C-0x000000018CBAD854
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018783BAEC-0x000000018783BAF8
		}
	
		// Constructors
		static PsoCreateUploadHelper(); // 0x0000000186F8DF60-0x0000000186F8E0D0
		public PsoCreateUploadHelper(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void Initialize(); // 0x0000000186CCD6F0-0x0000000186CCD800
		public void Init(); // 0x00000001862B2F00-0x00000001862B2F80
		private void _SceneLoadStartHandler([IsReadOnly] in EventData<string, string> args); // 0x000000018CBA8E60-0x000000018CBA8EC0
		public void Dispose(); // 0x000000018CBA82B0-0x000000018CBA83A0
		public static bool IsPsoRecordEnabled(); // 0x00000001870D08D0-0x00000001870D0A40
		public static void BeforeWarmUpBegin(); // 0x000000018CBA8240-0x000000018CBA82B0
		public static void AfterWarmUpFinish(); // 0x000000018CBA81C8-0x000000018CBA8240
		private static void _Tick(float deltaTime); // 0x000000018CBA8EC0-0x000000018CBA8F98
		private static void _PsoUploadProcessOneCallBack(string infoJson, HGPsoExtInfo info); // 0x000000018CBA8C98-0x000000018CBA8E60
		private static string _PsoUpdateGameInfoCallBack(); // 0x000000018CBA8C34-0x000000018CBA8C98
		private static void _UploadPipelineCreatedInfo(bool timeLimit); // 0x000000018CBA91D8-0x000000018CBA921C
		private static void _CreateAndUploadFinalJson(bool timeLimit); // 0x000000018CBA87A8-0x000000018CBA8C34
		private static void _CreateAndUploadFileToServer(string path, string serverFileName, PsoInfoWrapper psoInfoWrapper); // 0x000000018CBA83E4-0x000000018CBA87A8
		private static void _UploadFile(string urlPath, string rawFilePath, string serverFileNameOverride, Action<bool, string, string> callback); // 0x000000018CBA90A8-0x000000018CBA91D8
		private static async void _UploadFileToServer(string urlPath, string rawFilePath, string serverFileNameOverride, Action<bool, string, string> callback); // 0x000000018CBA8F98-0x000000018CBA90A8
		private static void _Callback(bool success, string msg, string url); // 0x000000018CBA83A0-0x000000018CBA83E4
	}

	public class VFXSludgeBaker // TypeDefIndex: 83982
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
		private const float EXTEND_SIZE = 2f; // Metadata: 0x02643F38
		public float rayCastPosY; // 0xB0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 83980
		{
			// Fields
			public float[,] sdf; // 0x10
			public HashSet<int> hashList; // 0x18
			public int xCount; // 0x20
			public Queue<Vector2Int> pendingList; // 0x28
			public Action<int, int> __9__0; // 0x30
	
			// Constructors
			public __c__DisplayClass41_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __CalculateEdgeSignedDistance_b__0(int tx, int tz); // 0x000000018CBABDB8-0x000000018CBABE5C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_1 // TypeDefIndex: 83981
		{
			// Fields
			public int ix; // 0x10
			public int iz; // 0x14
			public float minDistance; // 0x18
			public __c__DisplayClass41_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass41_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __CalculateEdgeSignedDistance_b__1(int tx, int tz); // 0x000000018CBABE5C-0x000000018CBABF98
		}
	
		// Constructors
		public VFXSludgeBaker(SplineContainer splineContainer, Transform target, float density, float thickness, float maxHeight, float blurIntensity, float gridHeightOffset); // 0x000000018CBB0C98-0x000000018CBB0D08
	
		// Methods
		public void Bake(); // 0x000000018CBADDF0-0x000000018CBADE84
		private void _CalculatePolygonAndBounds(); // 0x000000018CBAF29C-0x000000018CBAF5C0
		public Vector2Int GetLocalIndex(Vector3 localPosition); // 0x000000018CBADE84-0x000000018CBADF64
		public Vector3 GetLocalPosition(Vector2Int index); // 0x000000018CBADF64-0x000000018CBAE06C
		private void _RaycastSceneObjectsHeight(); // 0x000000018CBB046C-0x000000018CBB0C98
		private void _CalculateInPolygon(); // 0x000000018CBAEDB4-0x000000018CBAEF94
		private void _CalculateInHighPowerZone(); // 0x000000018CBAEA08-0x000000018CBAEDB4
		private static float[] _CreateGaussianKernel(int size, float sigma); // 0x000000018CBAFCB8-0x000000018CBAFE08
		private static float[,] _Convolution(float[,] src, float[] kernel, Vector2Int offsetDir); // 0x000000018CBAFAA0-0x000000018CBAFCB8
		private void _BlurTopHeight(); // 0x000000018CBAE06C-0x000000018CBAE22C
		private void _CalculateThicknessAndTopHeight(); // 0x000000018CBAF5C0-0x000000018CBAFAA0
		private void _CalculateNormals(); // 0x000000018CBAEF94-0x000000018CBAF29C
		private static void _ForAround(int ix, int iz, int xCount, int zCount, Action<int, int> callback); // 0x000000018CBAFF78-0x000000018CBB007C
		[IDTag(1)]
		private int _GetHash(int ix, int iz); // 0x000000018CBB00C8-0x000000018CBB0118
		[IDTag(0)]
		private static int _GetHash(int ix, int iz, int xCount); // 0x000000018CBB007C-0x000000018CBB00C8
		[IDTag(0)]
		private static void _CalculateEdgeSignedDistance(float[,] sdf); // 0x000000018CBAE22C-0x000000018CBAE540
		[IDTag(1)]
		private void _CalculateEdgeSignedDistance(); // 0x000000018CBAE540-0x000000018CBAEA08
		private UnityEngine.Color _GetTextureColor1(int ix, int iz); // 0x000000018CBB0118-0x000000018CBB0318
		private UnityEngine.Color _GetTextureColor2(int ix, int iz); // 0x000000018CBB0318-0x000000018CBB046C
		private void _CreateTexture(); // 0x000000018CBAFE08-0x000000018CBAFF78
	}

	public class VFXSludgeNavUtils // TypeDefIndex: 83992
	{
		// Nested types
		public static class BoundsUtil // TypeDefIndex: 83983
		{
			// Methods
			public static void GetTopBottomPoints(Bounds bounds, Transform t, out Vector3 topPoint, out Vector3 bottomPoint, Vector3? upDir = default); // 0x000000018CB9FE7C-0x000000018CBA01D0
		}
	
		public static class Spline2DProjectAndSimplify // TypeDefIndex: 83988
		{
			// Nested types
			public struct Frame // TypeDefIndex: 83984
			{
				// Fields
				public Vector3 origin; // 0x00
				public Quaternion rot; // 0x0C
	
				// Constructors
				public Frame(Vector3 origin, Quaternion rot); // 0x000000018723FF60-0x000000018723FF80
	
				// Methods
				public Vector3 WorldToFrame(Vector3 pWorld); // 0x000000018CBA537C-0x000000018CBA548C
				public Vector3 FrameToWorld(Vector3 pFrame); // 0x000000018CBA5298-0x000000018CBA537C
			}
	
			public enum EdgeMode // TypeDefIndex: 83985
			{
				UseSplineOrder = 0,
				ConvexHull = 1
			}
	
			public class ProcessResult // TypeDefIndex: 83986
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
				public ProcessResult(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass6_0 // TypeDefIndex: 83987
			{
				// Fields
				public List<Vector2> pts; // 0x10
	
				// Constructors
				public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal int _ConvexHullIndices_b__0(int i, int j); // 0x000000018CBAC07C-0x000000018CBAC14C
			}
	
			// Methods
			public static Frame MakeFrameFromPlaneNormal(Vector3 planeOrigin, Vector3 planeNormal); // 0x000000018CBA9C0C-0x000000018CBA9D20
			public static Frame MakeFrameByYaw(Vector3 origin, float yawDeg); // 0x000000018CBA9B64-0x000000018CBA9C0C
			public static List<Vector3> SampleUniformByArcLength(SplineContainer container, float stepMeters = 0.1f /* Metadata: 0x02643F3C */, int splineIndex = 0 /* Metadata: 0x02643F40 */, bool closed = true /* Metadata: 0x02643F41 */, float oversample = 0.02f /* Metadata: 0x02643F42 */); // 0x000000018CBAA484-0x000000018CBAA9C8
			public static void ProjectWorldToFrameXZ(List<Vector3> worldPts, Frame frame, out List<Vector2> projected2D, out List<float> frameYs, out float worldMinY, out float worldMaxY, out float frameMinY, out float frameMaxY); // 0x000000018CBAA208-0x000000018CBAA484
			public static List<int> ConvexHullIndices(List<Vector2> pts); // 0x000000018CBA9624-0x000000018CBA9B64
			private static float _AngleDegAt(List<Vector2> p, int i, bool closed); // 0x000000018CBAAE14-0x000000018CBAB038
			private static float _CurvatureAt(List<Vector2> p, int i, bool closed); // 0x000000018CBAB038-0x000000018CBAB310
			private static float _PointToSegmentDistance2D(Vector2 a, Vector2 b, Vector2 p); // 0x000000018CBAB310-0x000000018CBAB420
			public static List<int> Simplify2D_ByCurvatureAngleDeviation(List<Vector2> poly, bool closed, float angleDegThresh, float deltaKappaThresh, float devEps); // 0x000000018CBAA9C8-0x000000018CBAADBC
			public static ProcessResult Process(SplineContainer container, Frame frame, float stepMeters = 0.1f /* Metadata: 0x02643F46 */, int splineIndex = 0 /* Metadata: 0x02643F4A */, bool splineClosed = true /* Metadata: 0x02643F4B */, EdgeMode edgeMode = EdgeMode.UseSplineOrder /* Metadata: 0x02643F4C */, float angleDegThresh = 3f /* Metadata: 0x02643F4D */, float deltaKappaThresh = 0.1f /* Metadata: 0x02643F51 */, float devEpsFactor = 0.2f /* Metadata: 0x02643F55 */); // 0x000000018CBA9D20-0x000000018CBAA208
			[CompilerGenerated]
			internal static float _ConvexHullIndices_g__Cross_6_1(Vector2 a, Vector2 b, Vector2 c); // 0x000000018CBAADBC-0x000000018CBAAE14
		}
	
		public static class SplineSamplingUtils // TypeDefIndex: 83990
		{
			// Nested types
			[CompilerGenerated]
			private struct __c__DisplayClass0_0 // TypeDefIndex: 83989
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
			public static List<Vector2> SampleByArcLength(SplineContainer container, float step, int splineIndex = 0 /* Metadata: 0x02643F5B */, int lutResolution = 1024 /* Metadata: 0x02643F5C */, bool closed = true /* Metadata: 0x02643F5E */, bool worldSpace = true /* Metadata: 0x02643F5F */); // 0x000000018CBAB420-0x000000018CBABC20
			[CompilerGenerated]
			internal static Vector3 _SampleByArcLength_g__P_0_0(int i, ref __c__DisplayClass0_0 param_000b3750); // 0x000000018CBABC20-0x000000018CBABD38
			[CompilerGenerated]
			internal static float _SampleByArcLength_g__WrapLen_0_1(float s, ref __c__DisplayClass0_0 param_000b3752); // 0x000000018CBABD38-0x000000018CBABD68
		}
	
		public static class PolySimplify // TypeDefIndex: 83991
		{
			// Methods
			public static List<Vector3> SimplifyByAngle(List<Vector3> pts, float maxTurnDeg = 3f /* Metadata: 0x02643F60 */, float minEdgeLen = 0.05f /* Metadata: 0x02643F64 */, bool closed = true /* Metadata: 0x02643F68 */); // 0x000000018CBA7C10-0x000000018CBA81C8
		}
	
		// Constructors
		public VFXSludgeNavUtils(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class VFXSludgeUtils // TypeDefIndex: 83993
	{
		// Methods
		public static List<Vector3> GetPolygonOffSpline(SplineContainer splineContainer, float splitDistance, int splineIndex = 0 /* Metadata: 0x02643F69 */); // 0x000000018CBB1708-0x000000018CBB1908
		public static void GetPolygonOffSplineWithSimplify(SplineContainer container, ref List<Vector2> points, int splineIndex = 0 /* Metadata: 0x02643F6A */, bool closed = true /* Metadata: 0x02643F6B */, bool isDebug = false /* Metadata: 0x02643F6C */, bool isConvexHull = false /* Metadata: 0x02643F6D */); // 0x000000018CBB11BC-0x000000018CBB1708
		public static List<Vector3> GetPolygonOffByPolyLine(List<Vector2> polylinePoints, Transform transform, float splitDistance); // 0x000000018CBB0E7C-0x000000018CBB11BC
		public static List<Vector3> CalculatePointPolygonHorizonRayCross(List<Vector3> polygon, Vector3 point); // 0x000000018CBB0D08-0x000000018CBB0E7C
	}

	public class HGTerrain : MonoBehaviour // TypeDefIndex: 83994
	{
		// Constructors
		public HGTerrain(); // 0x00000001878364A0-0x00000001878364B8
	}

	public delegate void ToggleFunc(HGTerrainHelper terrainHelper); // TypeDefIndex: 83995; 0x0000000185B78EA0-0x0000000185B78EB0

	[ExecuteInEditMode]
	[RequireComponent(typeof(Terrain))]
	public class HGTerrainHelper : MonoBehaviour // TypeDefIndex: 83996
	{
		// Constructors
		public HGTerrainHelper(); // 0x00000001878364A0-0x00000001878364B8
	}
}

namespace Beyond.Rendering.ECS
{
	public class HGAddedMaterialController // TypeDefIndex: 84002
	{
		// Fields
		public const int MAX_ACTIVE_ADDED_MATERIAL = 4; // Metadata: 0x02643F75
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
		public int activeLayerCount { get; } // 0x000000018CBA6B60-0x000000018CBA6BB4 
	
		// Nested types
		private class OverlayLayer // TypeDefIndex: 84001
		{
			// Fields
			public int handle; // 0x10
			public GameObject overlayGO; // 0x18
			public HGMeshRenderer overlayRenderer; // 0x20
			public HGMeshRendererData clonedData; // 0x28
			public Material currentMaterial; // 0x30
			public Material[] materialsScratch; // 0x38
	
			// Constructors
			public OverlayLayer(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public HGAddedMaterialController(); // 0x000000018CBA6AA0-0x000000018CBA6B60
	
		// Methods
		public void Init(HGMeshRenderer sourceRenderer, HGMeshRendererData sourceData, Transform overlayParent, int sourceMaterialSlotCount); // 0x000000018CBA5934-0x000000018CBA59C4
		public int RequireAddMaterial(Material material); // 0x000000018CBA5DC8-0x000000018CBA6090
		public void RequireRemoveMaterial(int handle); // 0x000000018CBA6090-0x000000018CBA6244
		public int GetActiveOverlayRenderers(List<HGMeshRenderer> result); // 0x000000018CBA548C-0x000000018CBA567C
		public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result); // 0x000000018CBA567C-0x000000018CBA5778
		public void SetAddictiveFloatProperty(int propertyId, float value); // 0x000000018CBA648C-0x000000018CBA654C
		public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x02643F71 */); // 0x000000018CBA5778-0x000000018CBA57FC
		public void SetAddictiveVectorProperty(int propertyId, Vector4 value); // 0x000000018CBA660C-0x000000018CBA66E4
		public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default); // 0x000000018CBA5874-0x000000018CBA5934
		public void SetAddictiveTextureProperty(int propertyId, Texture value); // 0x000000018CBA654C-0x000000018CBA660C
		public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null); // 0x000000018CBA57FC-0x000000018CBA5874
		private OverlayLayer _CreateNewLayer(); // 0x000000018CBA66E4-0x000000018CBA6948
		public void Reset(); // 0x000000018CBA6244-0x000000018CBA648C
		public void Release(); // 0x000000018CBA59C4-0x000000018CBA5DC8
		private static void _DestroyLayer(OverlayLayer layer); // 0x000000018CBA6948-0x000000018CBA6AA0
	}

	public class HGMaterialCommitter // TypeDefIndex: 84004
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
		public HGMeshRendererData clonedData { get; } // 0x000000018CBA7184-0x000000018CBA71C4 
	
		// Nested types
		public delegate Material[] MaterialsProvider(); // TypeDefIndex: 84003; 0x0000000185B44B70-0x0000000185B44B80
	
		// Constructors
		public HGMaterialCommitter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Init(HGMeshRenderer renderer, HGMeshRendererData sourceData, MaterialsProvider materialsProvider, Action onDirty = null, Action onCommitted = null); // 0x000000018CBA6BEC-0x000000018CBA6CBC
		public void MarkMaterialsArrayDirty(); // 0x000000018CBA6D00-0x000000018CBA6D54
		public bool IsDirty(); // 0x000000018CBA6CBC-0x000000018CBA6D00
		public void TryCommit(); // 0x000000018CBA6F6C-0x000000018CBA6FB8
		public void ForceCommit(); // 0x000000018CBA6BB4-0x000000018CBA6BEC
		private void _Commit(); // 0x000000018CBA6FB8-0x000000018CBA7184
		public void Reset(); // 0x000000018CBA6EC0-0x000000018CBA6F6C
		public void Release(); // 0x000000018CBA6D54-0x000000018CBA6EC0
	}

	public class HGMaterialController // TypeDefIndex: 84005
	{
		// Fields
		private const string VFX_MATERIAL_POSTFIX = "_VFXInstance"; // Metadata: 0x02643F77
		private const string ALPHA_BLEND_ON_KEYWORD = "_ALPHABLEND_ON"; // Metadata: 0x02643F84
		private const string DEPTH_ONLY_PASS = "DepthOnly"; // Metadata: 0x02643F93
		private const string DITHER_KEYWORD = "DITHER"; // Metadata: 0x02643F9D
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
		[TupleElementNames(new string[2] {"value", "multiplyFromSource" })]
		private Dictionary<int, ValueTuple<Vector4, bool>> m_vectorProperties; // 0x50
		private Dictionary<int, Texture> m_textureProperties; // 0x58
		private Dictionary<string, bool> m_keywordStates; // 0x60
		private bool m_depthOnlyPassEnabled; // 0x68
		private bool m_depthOnlyPassControlling; // 0x69
	
		// Properties
		public Material[] currentMeshMaterials { get; } // 0x000000018CBB2BC8-0x000000018CBB2C08 
	
		// Constructors
		public HGMaterialController(); // 0x0000000186805BA0-0x0000000186805BB0
		static HGMaterialController(); // 0x000000018CBB2B60-0x000000018CBB2BC8
	
		// Methods
		public void Init(HGMeshRenderer renderer, HGMeshRendererData sourceData, Material[] sourceMaterials, HGMaterialCommitter committer); // 0x000000018CBB1908-0x000000018CBB1A80
		private Material _GetOrCreateInstancedMaterial(int slot); // 0x000000018CBB28B4-0x000000018CBB2B60
		private void _ApplyAllPropertiesToOneMaterial(Material mat, Material sourceMaterial); // 0x0000000184E01B40-0x0000000184E025C0
		private void _ApplyDepthOnlyPassToMaterial(Material mat, bool enable); // 0x000000018CBB272C-0x000000018CBB28B4
		public void SetFloatToAllMaterial(int nameId, float value); // 0x000000018CBB21F0-0x000000018CBB236C
		public void RestoreFloatPropertiesFromSource(IReadOnlyList<int> nameIds); // 0x0000000184E00960-0x0000000184E00D40
		public void RestoreVectorPropertiesFromSource(IReadOnlyList<int> nameIds); // 0x0000000184E01180-0x0000000184E015B0
		public void RestoreTexturePropertiesFromSource(IReadOnlyList<int> nameIds); // 0x0000000184E00D40-0x0000000184E01180
		private static bool _HasAnyProperty<T>(Dictionary<int, T> properties, IReadOnlyList<int> nameIds);
		private static void _RemoveProperties<T>(Dictionary<int, T> properties, IReadOnlyList<int> nameIds);
		public void SetVectorToAllMaterial(int nameId, Vector4 value, bool multiplyFromSource = false /* Metadata: 0x02643F76 */); // 0x0000000184E015B0-0x0000000184E01B40
		public void SetTextureToAllMaterial(int nameId, Texture value); // 0x000000018CBB25E8-0x000000018CBB272C
		public void SetKeywordEnableToAllMaterial(string keyword, bool enable); // 0x000000018CBB236C-0x000000018CBB24F8
		public void SetDepthOnlyPassEnableToAllMaterial(bool enable); // 0x000000018CBB2140-0x000000018CBB21F0
		public bool SetManualDitherEnable(bool enable); // 0x000000018CBB2574-0x000000018CBB25E8
		public void SetManualDitherAlphaValue(float value); // 0x000000018CBB24F8-0x000000018CBB2574
		public void ReplaceAllMaterials(Material replacement); // 0x000000018CBB1DB8-0x000000018CBB1E90
		public void ReplaceMaterialBySource(Material srcMat, Material replacement); // 0x000000018CBB1E90-0x000000018CBB2030
		public void Reset(); // 0x000000018CBB2030-0x000000018CBB2140
		public void Release(); // 0x000000018CBB1A80-0x000000018CBB1DB8
		private void _DestroyInstancedMaterials(); // 0x0000000184E025C0-0x0000000184E02820
	}

	public class HGRendererStateController // TypeDefIndex: 84006
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
		public HGMeshRenderer hgRenderer { get; } // 0x000000018CBB3AF8-0x000000018CBB3B38 
	
		// Constructors
		public HGRendererStateController(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Init(HGMeshRenderer renderer); // 0x000000018CBB2FA0-0x000000018CBB304C
		public bool IsValid(); // 0x000000018CBB30A4-0x000000018CBB3104
		public void SetVisible(bool visible); // 0x000000018CBB3268-0x000000018CBB32FC
		public void Reset(); // 0x000000018CBB31B0-0x000000018CBB3234
		public Bounds GetBounds(); // 0x000000018CBB2C08-0x000000018CBB2FA0
		public void InvalidateMeshCache(); // 0x000000018CBB304C-0x000000018CBB30A4
		private void _EnsureMeshLocalBoundsCached(); // 0x000000018CBB3334-0x000000018CBB352C
		private static Bounds _LocalBoundsToWorld(Bounds local, Matrix4x4 l2w); // 0x000000018CBB352C-0x000000018CBB3A2C
		private void _WarnNoMeshes(); // 0x000000018CBB3A2C-0x000000018CBB3AF8
		public void StopShadowCasting(bool stopRayTracing); // 0x000000018CBB32FC-0x000000018CBB3334
		public void RevertShadowCastingMode(); // 0x000000018CBB3234-0x000000018CBB3268
		public void Release(); // 0x000000018CBB3104-0x000000018CBB31B0
	}
}

namespace Beyond.Rendering.LODLightmapping
{
	[ExecuteInEditMode]
	public class LightmapInfoTransfer : MonoBehaviour // TypeDefIndex: 83998
	{
		// Fields
		[SerializeField]
		private MeshRenderer _lightmappedRenderer; // 0x18
		private MeshRenderer m_currentRenderer; // 0x20
	
		// Constructors
		public LightmapInfoTransfer(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnEnable(); // 0x000000018CBA7A50-0x000000018CBA7A88
		private void Awake(); // 0x000000018CBA79D0-0x000000018CBA7A50
		private void _RendererInfoTransfer(); // 0x000000018CBA7A88-0x000000018CBA7C10
	}

	public enum LodLightmappingMode // TypeDefIndex: 83999
	{
		AllFromLightProbe = 0,
		AllFromLOD0 = 1,
		UseDifferentLightmapAreaForLODs = 2
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class LODLightmapping : MonoBehaviour // TypeDefIndex: 84000
	{
		// Fields
		public LodLightmappingMode mode; // 0x18
		[SerializeField]
		public Vector4 lightmapScaleOffset; // 0x1C
		[SerializeField]
		public int lightmapIndex; // 0x2C
	
		// Constructors
		public LODLightmapping(); // 0x0000000186ECFC20-0x0000000186ECFC70
	
		// Methods
		public void RendererInfoTransfer(); // 0x000000018CBA7664-0x000000018CBA79D0
	}
}

namespace Beyond.Rendering.SplineMovingObjects
{
	[ExecuteAlways]
	[RequireComponent(typeof(SplineContainer))]
	public class HGSplineMovingObjects : MonoBehaviour, IVFXPlayable // TypeDefIndex: 83997
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
		public HGSplineMovingObjects(); // 0x000000018563B8F0-0x000000018563BB20
	
		// Methods
		private void _CreateInstance(); // 0x0000000186ADA750-0x0000000186ADA970
		private void _ExtractSplineData(); // 0x000000018CBA7404-0x000000018CBA7664
		private void _DestroyInstance(); // 0x0000000186BB1A60-0x0000000186BB1AB0
		private void _Release(); // 0x0000000186BB19D0-0x0000000186BB1A30
		private void Update(); // 0x0000000185FAC170-0x0000000185FAC280
		private void OnEnable(); // 0x0000000186ADA720-0x0000000186ADA750
		private void OnDisable(); // 0x0000000186BB1A30-0x0000000186BB1A60
		private void OnDestroy(); // 0x0000000186BB19A0-0x0000000186BB19D0
		private void OnDrawGizmosSelected(); // 0x000000018CBA71C4-0x000000018CBA7358
		public void Pause(); // 0x000000018CBA7358-0x000000018CBA7394
		public void Play(); // 0x000000018CBA7394-0x000000018CBA73CC
		public void Stop(); // 0x000000018CBA73CC-0x000000018CBA7404
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 83858
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 83859
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 83860
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 83861
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 83862
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 83863
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 83864
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class ContainerWaterManager : MonoBehaviour // TypeDefIndex: 83855
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
		private float[] m_waveN; // 0x38
		private float[] m_waveNm1; // 0x40
		private float[] m_waveNp1; // 0x48
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
		private float m_nextRippleIntervalScale; // 0xF8
		[FormerlySerializedAs("rotationWaveMultiplier")]
		[Header("\u51B0\u7403\u65CB\u8F6C\u6D9F\u6F2A\u53C2\u6570")]
		[Range(0.01f, 10f)]
		[SerializeField]
		[Space(10f)]
		[Tooltip("\u65CB\u8F6C\u4EA7\u751F\u6CE2\u7EB9\u7684\u5F3A\u5EA6\u500D\u6570\u3002\u5EFA\u8BAE0.5-1.2")]
		private float _rotationWaveMultiplier; // 0xFC
		[FormerlySerializedAs("rotationSensitivity")]
		[Range(0.5f, 15f)]
		[SerializeField]
		[Tooltip("\u68C0\u6D4B\u65CB\u8F6C\u53D8\u5316\u7684\u654F\u611F\u5EA6\uFF08\u5EA6\u6570\uFF09\u3002\u5EFA\u8BAE8-12\u5EA6")]
		private float _rotationSensitivity; // 0x100
		private bool[] m_cylinderMask; // 0x108
		private int[] m_activeIndices; // 0x110
		private int[] m_edgeInsideIndices; // 0x118
		private Vector2Int[] m_insidePoints; // 0x120
		private Color32[] m_cachedPixels; // 0x128
		[Header("\u6F29\u6DA1\u6548\u679C\u63A7\u5236")]
		[Range(0f, 0.1f)]
		[SerializeField]
		[Space(10f)]
		[Tooltip("\u6B63\u5E38\u72B6\u6001\u4E0B\u7684meniscusWidth\u503C")]
		private float _normalMeniscusWidth; // 0x130
		[Range(0.1f, 5f)]
		[SerializeField]
		[Tooltip("\u68C0\u6D4B\u6F29\u6DA1\u7684\u65CB\u8F6C\u901F\u5EA6\u9608\u503C\uFF08\u5EA6/\u79D2\uFF09")]
		private float _vortexDetectionThreshold; // 0x134
		[Range(0.1f, 2f)]
		[SerializeField]
		[Tooltip("\u6F29\u6DA1\u6548\u679C\u7684\u5E73\u6ED1\u8FC7\u6E21\u65F6\u95F4\uFF08\u79D2\uFF09")]
		private float _vortexTransitionTime; // 0x138
		private bool m_isVortexActive; // 0x13C
		private float m_vortexTransitionProgress; // 0x140
		private float m_lastVortexCheckTime; // 0x144
		private float m_lastYAxisStopTime; // 0x148
		private bool m_wasYAxisRotating; // 0x14C
		private readonly float m_yAxisStopDelay; // 0x150
		private const float VORTEX_CHECK_INTERVAL = 0.1f; // Metadata: 0x02643C74
		[Header("\u51B0\u7403\u79FB\u52A8\u8DDD\u79BB\u68C0\u6D4B")]
		[Range(0.001f, 0.1f)]
		[SerializeField]
		[Space(10f)]
		[Tooltip("\u51B0\u7403\u79FB\u52A8\u8DDD\u79BB\u9608\u503C\uFF0C\u8D85\u8FC7\u6B64\u503C\u5C06\u8BBE\u7F6E_WaterMeniscusWidth\u4E3A0")]
		private float _movementDistanceThreshold; // 0x154
		[Range(0.5f, 5f)]
		[SerializeField]
		[Tooltip("\u79FB\u52A8\u505C\u6B62\u540E\u6062\u590D_WaterMeniscusWidth\u7684\u5EF6\u8FDF\u65F6\u95F4\uFF08\u79D2\uFF09")]
		private float _movementRecoveryDelay; // 0x158
		private bool m_isMovementActive; // 0x15C
		private float m_lastMovementStopTime; // 0x160
		private bool m_wasMoving; // 0x164
		private float m_currentMeniscusWidth; // 0x168
		private bool m_isMeniscusTransitioning; // 0x16C
		private float m_meniscusTransitionStartTime; // 0x170
		private float m_meniscusTransitionStartValue; // 0x174
		private float m_lastAppliedMeniscusWidth; // 0x178
		private Vector4 m_lastAppliedIcePosition; // 0x17C
		private bool m_hasAppliedIcePosition; // 0x18C
		private Vector2Int m_tempTexturePos; // 0x190
	
		// Properties
		private float dy { get; } // 0x000000018CB99358-0x000000018CB9939C 
	
		// Constructors
		public ContainerWaterManager(); // 0x0000000186F8A5B0-0x0000000186F8A6F0
		static ContainerWaterManager(); // 0x0000000187180390-0x0000000187180420
	
		// Methods
		private void Start(); // 0x00000001856B95B0-0x00000001856B9610
		private void _InitializeWaveSystem(); // 0x00000001862ACB70-0x00000001862AD0A0
		private void _PrecomputeCylinderMask(); // 0x00000001857DF780-0x00000001857DFA50
		private void _UnifiedWaveStep(bool isEditorUpdate); // 0x0000000185022B20-0x00000001850238A0
		private bool _WorldToTextureCoords(Vector3 worldPos, ref Vector2Int texturePos); // 0x0000000185F15320-0x0000000185F153C0
		private bool _IsInsideCylinder(int i, int j); // 0x0000000185F153C0-0x0000000185F15430
		private bool _IsValidPosition(int x, int y); // 0x0000000186EBF740-0x0000000186EBF780
		private void _ApplyMatrixToTexture(float[] state, ref Texture2D tex, float waveMultiplier); // 0x00000001850238E0-0x0000000185023E60
		private void _UpdateVortexState(bool isEditorUpdate); // 0x00000001865F16C0-0x00000001865F1970
		[ContextMenu("\u91CD\u7F6E\u6C34\u6CE2\u7EB9\u7406")]
		public void ResetWaveTexture(); // 0x000000018CB99258-0x000000018CB99358
		private void Update(); // 0x00000001865F12A0-0x00000001865F15E0
		private void _SetIcePositionIfChanged(Vector4 icePosition); // 0x00000001865F15E0-0x00000001865F16C0
	}

	[AddComponentMenu("HG/Effect/VFXLockTransform(\u9501\u7F29\u653E)")]
	[ExecuteAlways]
	public class VFXLockTransform : MonoBehaviour // TypeDefIndex: 83856
	{
		// Constructors
		public VFXLockTransform(); // 0x00000001878364A0-0x00000001878364B8
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 83857
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 84009
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018CBB472C-0x000000018CBB4768
	
		// Methods
		public float __Gen_Wrap_0(object P0); // 0x000000018936AA54-0x000000018936AB14
		public void __Gen_Wrap_1(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public void __Gen_Wrap_2(object P0, object P1, ref Texture2D P2, float P3); // 0x000000018CBB42B0-0x000000018CBB43D8
		public bool __Gen_Wrap_3(object P0, int P1, int P2); // 0x000000018C0CACAC-0x000000018C0CADA4
		public bool __Gen_Wrap_4(object P0, Vector3 P1, ref Vector2Int P2); // 0x000000018CBB43D8-0x000000018CBB4524
		public void __Gen_Wrap_5(object P0, bool P1); // 0x000000018936C508-0x000000018936C5D8
		public void __Gen_Wrap_6(object P0, Vector4 P1); // 0x000000018CBB4524-0x000000018CBB460C
		public void __Gen_Wrap_7(object P0, float P1); // 0x000000018936ABF4-0x000000018936ACC4
		public void __Gen_Wrap_8(object P0, int P1); // 0x0000000188B4D6D0-0x0000000188B4D7A0
		public void __Gen_Wrap_9(object P0, Vector4 P1, Vector4 P2); // 0x000000018CBB460C-0x000000018CBB472C
		public void __Gen_Wrap_10(object P0, float P1, float P2, float P3); // 0x000000018CBB3B38-0x000000018CBB3C3C
		public void __Gen_Wrap_11(object P0, float P1, float P2); // 0x000000018CBB3C3C-0x000000018CBB3D28
		public void __Gen_Wrap_12(object P0, float P1, float P2, float P3, float P4); // 0x000000018CBB3D28-0x000000018CBB3E40
		public string __Gen_Wrap_13(object P0); // 0x00000001887F3094-0x00000001887F3158
		public void __Gen_Wrap_14(); // 0x00000001887ED074-0x00000001887ED104
		public string __Gen_Wrap_15(RootCategory P0); // 0x000000018CBB3E40-0x000000018CBB3F04
		public string __Gen_Wrap_16(RootCategory P0, bool P1); // 0x000000018CBB3F04-0x000000018CBB3FE4
		public string __Gen_Wrap_17(); // 0x000000018CBB3FE4-0x000000018CBB4084
		public bool __Gen_Wrap_18(); // 0x00000001887ECE94-0x00000001887ECF30
		public string __Gen_Wrap_19(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3); // 0x000000018CBB4084-0x000000018CBB4194
		public string __Gen_Wrap_20(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3, object P4); // 0x000000018CBB4194-0x000000018CBB42B0
		public long __Gen_Wrap_21(); // 0x00000001887EB7A4-0x00000001887EB840
		public bool __Gen_Wrap_22(object P0); // 0x00000001822262C0-0x0000000182226590
		public bool __Gen_Wrap_23(object P0, object P1, object P2, object P3, object P4, object P5); // 0x0000000183B60C50-0x0000000183B61310
		public bool __Gen_Wrap_24(object P0, out bool P1, out string P2); // 0x0000000184E11460-0x0000000184E11BB0
		public void __Gen_Wrap_25(object P0, object P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_26(ShaderWarmupManager.WarmUpReason P0); // 0x0000000182220CF0-0x0000000182220EE0
		public string __Gen_Wrap_27(IntPtr P0, ref WindowsGpuDriverVersion.SP_DEVINFO_DATA P1, uint P2); // 0x0000000184E11BB0-0x0000000184E125D0
		public bool __Gen_Wrap_28(object P0, object P1); // 0x00000001827B9DC0-0x00000001827BA150
		public int __Gen_Wrap_29(object P0, object P1, object P2); // 0x0000000182BBDB10-0x0000000182BBDF70
		public string __Gen_Wrap_30(object P0, object P1); // 0x0000000184E125D0-0x0000000184E12D00
		public int __Gen_Wrap_31(WindowsGpuDriverVersion.Result P0, WindowsGpuDriverVersion.Result P1); // 0x0000000182224290-0x0000000182224620
		public List<WindowsGpuDriverVersion.Result> __Gen_Wrap_32(); // 0x0000000184E12D00-0x0000000184E13280
		public void __Gen_Wrap_33(object P0, object P1, long P2); // 0x0000000182480C90-0x0000000182481030
		public void __Gen_Wrap_34(int P0); // 0x0000000182220CF0-0x0000000182220EE0
		public WindowsGpuDriverVersion.Result __Gen_Wrap_35(); // 0x0000000184E13280-0x0000000184E13800
		public bool __Gen_Wrap_36(object P0, object P1, out string P2); // 0x0000000184E13800-0x0000000184E13FE0
		public bool __Gen_Wrap_37(bool P0); // 0x00000001822291E0-0x00000001822293E0
		public IEnumerator __Gen_Wrap_38(); // 0x0000000184E13FE0-0x0000000184E14560
		public List<StringPathHash> __Gen_Wrap_39(bool P0); // 0x0000000184E14560-0x0000000184E14B10
		public IEnumerator __Gen_Wrap_40(object P0, object P1, object P2); // 0x0000000184E14B10-0x0000000184E15300
		public int __Gen_Wrap_41(object P0, int P1, int P2); // 0x00000001824DFEA0-0x00000001824E0190
		public void __Gen_Wrap_42(object P0, bool P1, bool P2); // 0x00000001824EC140-0x00000001824EC440
		public int __Gen_Wrap_43(); // 0x00000001825212D0-0x00000001825214A0
		public void __Gen_Wrap_44(int P0, ref int P1); // 0x0000000184E15300-0x0000000184E15530
		public IEnumerator __Gen_Wrap_45(object P0, int P1, int P2, object P3); // 0x0000000184E15530-0x0000000184E15CA0
		public IEnumerator __Gen_Wrap_46(bool P0); // 0x0000000184E15CA0-0x0000000184E16250
		public IEnumerator __Gen_Wrap_47(object P0, int P1, int P2); // 0x0000000184E16250-0x0000000184E168F0
		public IEnumerator __Gen_Wrap_48(object P0); // 0x0000000184E168F0-0x0000000184E16F50
		public bool __Gen_Wrap_49(object P0, out string P1); // 0x0000000184E16F50-0x0000000184E17660
		public bool __Gen_Wrap_50(ref SceneStateAreaKey P0, SceneStateAreaKey P1); // 0x0000000184E17660-0x0000000184E17DE0
		public bool __Gen_Wrap_51(ref SceneStateAreaKey P0, object P1); // 0x0000000184E17DE0-0x0000000184E18550
		public int __Gen_Wrap_52(ref SceneStateAreaKey P0); // 0x0000000184E18550-0x0000000184E18BF0
		public int[] __Gen_Wrap_53(object P0); // 0x00000001847FB9E0-0x00000001847FC040
		public bool __Gen_Wrap_54(object P0, bool P1); // 0x000000018251D250-0x000000018251D540
		public bool __Gen_Wrap_55(object P0, float P1, int P2); // 0x0000000184E18BF0-0x0000000184E18EF0
		public Dictionary<int, float> __Gen_Wrap_56(object P0); // 0x0000000184E18EF0-0x0000000184E19550
		public EntityRenderCapturedEntity __Gen_Wrap_57(object P0, object P1, EntityVFXRendererMask P2); // 0x0000000184E19550-0x0000000184E19C90
		public int __Gen_Wrap_58(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public EntityVFXRendererMask __Gen_Wrap_59(EntityVFXRendererType P0); // 0x00000001824E3DB0-0x00000001824E3FB0
		public void __Gen_Wrap_60(object P0, object P1, object P2); // 0x0000000182532090-0x00000001825324E0
		public bool __Gen_Wrap_61(object P0, object P1, object P2); // 0x000000018252A430-0x000000018252A890
		public void __Gen_Wrap_62(object P0, object P1, object P2, object P3, bool P4); // 0x00000001824EBC00-0x00000001824EC140
		public Material[] __Gen_Wrap_63(object P0); // 0x0000000184E19C90-0x0000000184E1A2F0
		public bool __Gen_Wrap_64(ref AddMaterialConfig P0); // 0x0000000184E1A2F0-0x0000000184E1A970
		public Material __Gen_Wrap_65(object P0, EntityRenderHelperMaterialController.AddedMaterialInfo P1, object P2); // 0x0000000184E1A970-0x0000000184E1B1A0
		public bool __Gen_Wrap_66(object P0, Vector4 P1); // 0x0000000184E1B1A0-0x0000000184E1B550
		public Texture __Gen_Wrap_67(object P0, object P1); // 0x0000000184E1B550-0x0000000184E1BC80
		public int __Gen_Wrap_68(object P0, object P1, EntityVFXRendererMask P2, AddMaterialConfig P3); // 0x0000000184E1BC80-0x0000000184E1C110
		public List<EntityRenderHelperMaterialController.RendererInfo> __Gen_Wrap_69(object P0, EntityVFXRendererMask P1, bool P2); // 0x0000000184E1C110-0x0000000184E1C7C0
		public void __Gen_Wrap_70(object P0, int P1, float P2); // 0x0000000182EEEE90-0x0000000182EEF180
		public float __Gen_Wrap_71(object P0, int P1, float P2); // 0x0000000182DF45F0-0x0000000182DF48F0
		public void __Gen_Wrap_72(object P0, int P1, Vector4 P2); // 0x0000000184E1C7C0-0x0000000184E1CB70
		public Vector4 __Gen_Wrap_73(object P0, int P1, Vector4 P2); // 0x0000000184E1CB70-0x0000000184E1D2A0
		public void __Gen_Wrap_74(object P0, int P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public Texture __Gen_Wrap_75(object P0, int P1, object P2); // 0x0000000184E1D2A0-0x0000000184E1D9F0
		public EntityVFXRendererMask __Gen_Wrap_76(object P0, int P1); // 0x00000001824748D0-0x0000000182474BB0
		public bool __Gen_Wrap_77(object P0, int P1, object P2); // 0x00000001827BAA70-0x00000001827BAE20
		public void __Gen_Wrap_78(object P0, int P1, EntityVFXRendererMask P2); // 0x00000001824F9690-0x00000001824F9980
		public void __Gen_Wrap_79(object P0, EntityVFXRendererMask P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public void __Gen_Wrap_80(object P0, object P1, bool P2, EntityVFXRendererMask P3); // 0x00000001830B3610-0x00000001830B39C0
		public void __Gen_Wrap_81(object P0, bool P1, EntityVFXRendererMask P2); // 0x0000000183041590-0x0000000183041880
		public float __Gen_Wrap_82(object P0, float P1, float P2, int P3); // 0x0000000184E1D9F0-0x0000000184E1DD20
		public void __Gen_Wrap_83(object P0, EntityRenderHelperCustomPerDrawType P1, float P2, EntityVFXRendererMask P3); // 0x0000000182E7A890-0x0000000182E7ABA0
		public void __Gen_Wrap_84(object P0, EntityRenderHelperVectorCustomPerDrawType P1, Vector4 P2, EntityVFXRendererMask P3); // 0x0000000184E1DD20-0x0000000184E1E100
		public void __Gen_Wrap_85(object P0, int P1, float P2, EntityVFXRendererMask P3); // 0x0000000182E7A890-0x0000000182E7ABA0
		public void __Gen_Wrap_86(object P0, object P1, EntityVFXRendererMask P2); // 0x0000000182528040-0x00000001825283D0
		public void __Gen_Wrap_87(object P0, int P1, Vector4 P2, EntityVFXRendererMask P3, bool P4); // 0x0000000184E1E100-0x0000000184E1E500
		public void __Gen_Wrap_88(object P0, int P1, object P2, EntityVFXRendererMask P3); // 0x0000000182DF56A0-0x0000000182DF5A60
		public bool __Gen_Wrap_89(object P0, out Renderer P1); // 0x0000000184E1E500-0x0000000184E1EC10
		public bool __Gen_Wrap_90(object P0, float P1); // 0x000000018251F450-0x000000018251F740
		public bool __Gen_Wrap_91(object P0, bool P1, ref bool P2); // 0x0000000184E1EC10-0x0000000184E1EF30
		public bool __Gen_Wrap_92(object P0, out Vector3 P1); // 0x0000000184E1EF30-0x0000000184E1F5C0
		public bool __Gen_Wrap_93(object P0, out Bounds P1); // 0x0000000184E1F5C0-0x0000000184E1FC50
		public bool __Gen_Wrap_94(object P0, ref Bounds P1); // 0x0000000184E1FC50-0x0000000184E20390
		public Bounds __Gen_Wrap_95(object P0); // 0x0000000184E20390-0x0000000184E209C0
		public void __Gen_Wrap_96(object P0, object P1, bool P2); // 0x00000001825283D0-0x0000000182528770
		public RenderHelperType __Gen_Wrap_97(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public bool __Gen_Wrap_98(object P0, object P1, bool P2, out EntityRenderHelperVisibleController.RendererInfo P3); // 0x0000000184E209C0-0x0000000184E211B0
		public bool __Gen_Wrap_99(object P0, object P1, bool P2); // 0x00000001826B7CB0-0x00000001826B8050
		public List<EntityRendererTypeConfig> __Gen_Wrap_100(object P0, bool P1); // 0x0000000184E02820-0x0000000184E02EB0
		public float __Gen_Wrap_101(object P0, bool P1); // 0x0000000182652990-0x0000000182652C80
		public EntityVFXPriorityType __Gen_Wrap_102(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public EntityVFXRendererMask __Gen_Wrap_103(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_104(object P0, float P1, bool P2); // 0x0000000183F97130-0x0000000183F97430
		public Material __Gen_Wrap_105(object P0, object P1, object P2); // 0x0000000184E02EB0-0x0000000184E036A0
		public bool __Gen_Wrap_106(EntityVFXFactoryAddedMaterialManager.AddedMaterialData P0); // 0x00000001822262C0-0x0000000182226590
		public void __Gen_Wrap_107(object P0, object P1, int P2, float P3); // 0x0000000182DA54C0-0x0000000182DA5870
		public void __Gen_Wrap_108(object P0, object P1, int P2, Vector4 P3); // 0x0000000184E036A0-0x0000000184E03B30
		public Material __Gen_Wrap_109(object P0, object P1, Vector4 P2); // 0x0000000184E03B30-0x0000000184E04340
		public ValueTuple<float, float> __Gen_Wrap_110(Bounds P0, Vector3 P1); // 0x0000000184E04340-0x0000000184E04A70
		public void __Gen_Wrap_111(object P0, bool P1, Vector3 P2, bool P3, float P4, out float P5, out float P6, out Vector3 P7); // 0x0000000184E04A70-0x0000000184E052C0
		public EntityVFXCurveEvaluateResult __Gen_Wrap_112(object P0, float P1); // 0x0000000184E052C0-0x0000000184E05930
		public void __Gen_Wrap_113(object P0, object P1, float P2); // 0x00000001827B9100-0x00000001827B94A0
		public void __Gen_Wrap_114(object P0, float P1, object P2, object P3); // 0x0000000183F01880-0x0000000183F01D00
		public void __Gen_Wrap_115(object P0, object P1, object P2, bool P3); // 0x00000001827A62D0-0x00000001827A6740
		public PsoCreateUploadHelper __Gen_Wrap_116(); // 0x0000000184E05930-0x0000000184E05EB0
		public void __Gen_Wrap_117(object P0, HGPsoExtInfo P1); // 0x0000000184E05EB0-0x0000000184E06250
		public void __Gen_Wrap_118(bool P0); // 0x0000000182521C80-0x0000000182521E70
		public void __Gen_Wrap_119(object P0, object P1, object P2, object P3); // 0x0000000182558BB0-0x00000001825590D0
		public void __Gen_Wrap_120(float P0); // 0x0000000182541570-0x0000000182541760
		public void __Gen_Wrap_121(object P0, in EventData<string, string> P1); // 0x0000000184E06250-0x0000000184E06610
		public void __Gen_Wrap_122(bool P0, object P1, object P2); // 0x00000001825A9F60-0x00000001825AA300
		public List<Vector3> __Gen_Wrap_123(object P0, float P1, int P2); // 0x0000000184E06610-0x0000000184E06CB0
		public Vector3 __Gen_Wrap_124(object P0, Vector2Int P1); // 0x0000000184E06CB0-0x0000000184E073C0
		public List<Vector3> __Gen_Wrap_125(object P0, Vector3 P1); // 0x0000000184E073C0-0x0000000184E07B10
		public Vector2Int __Gen_Wrap_126(object P0, Vector3 P1); // 0x0000000184E07B10-0x0000000184E08220
		public int __Gen_Wrap_127(int P0, int P1, int P2); // 0x0000000183008B30-0x0000000183008D60
		public void __Gen_Wrap_128(int P0, int P1); // 0x0000000182522690-0x0000000182522890
		public void __Gen_Wrap_129(int P0, int P1, int P2, int P3, object P4); // 0x00000001848E80F0-0x00000001848E8410
		public UnityEngine.Color __Gen_Wrap_130(object P0, int P1, int P2); // 0x0000000184E08220-0x0000000184E08870
		public float[] __Gen_Wrap_131(int P0, float P1); // 0x0000000184E08870-0x0000000184E08E50
		public float[,] __Gen_Wrap_132(object P0, object P1, Vector2Int P2); // 0x00000001848E8410-0x00000001848E8C20
		public void __Gen_Wrap_133(Bounds P0, object P1, out Vector3 P2, out Vector3 P3, Vector3? P4); // 0x0000000184E08E50-0x0000000184E099C0
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_134(Vector3 P0, Vector3 P1); // 0x0000000184E099C0-0x0000000184E0A100
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_135(Vector3 P0, float P1); // 0x0000000184E0A100-0x0000000184E0A780
		public List<Vector3> __Gen_Wrap_136(object P0, float P1, int P2, bool P3, float P4); // 0x0000000184E0A780-0x0000000184E0AE70
		public Vector3 __Gen_Wrap_137(ref VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P0, Vector3 P1); // 0x0000000184E0AE70-0x0000000184E0B930
		public void __Gen_Wrap_138(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, out List<Vector2> P2, out List<float> P3, out float P4, out float P5, out float P6, out float P7); // 0x0000000184E0B930-0x0000000184E0C590
		public int __Gen_Wrap_139(int P0, int P1); // 0x00000001825DB8C0-0x00000001825DBAD0
		public List<int> __Gen_Wrap_140(object P0); // 0x00000001847F5680-0x00000001847F5CE0
		public float __Gen_Wrap_141(object P0, int P1, bool P2); // 0x00000001837EF080-0x00000001837EF380
		public float __Gen_Wrap_142(Vector2 P0, Vector2 P1, Vector2 P2); // 0x0000000184E0C590-0x0000000184E0CA60
		public List<int> __Gen_Wrap_143(object P0, bool P1, float P2, float P3, float P4); // 0x0000000184E0CA60-0x0000000184E0D150
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult __Gen_Wrap_144(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, float P2, int P3, bool P4, VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode P5, float P6, float P7, float P8); // 0x0000000184E0D150-0x0000000184E0D990
		public List<Vector2> __Gen_Wrap_145(object P0, float P1, int P2, int P3, bool P4, bool P5); // 0x0000000184E0D990-0x0000000184E0E090
		public List<Vector3> __Gen_Wrap_146(object P0, float P1, float P2, bool P3); // 0x0000000184E0E090-0x0000000184E0E770
		public void __Gen_Wrap_147(object P0, ref List<Vector2> P1, int P2, bool P3, bool P4, bool P5); // 0x0000000184E0E770-0x0000000184E0EF80
		public List<Vector3> __Gen_Wrap_148(object P0, object P1, float P2); // 0x0000000184E0EF80-0x0000000184E0F6E0
		public void __Gen_Wrap_149(object P0, object P1, object P2, object P3, int P4); // 0x00000001824FD4E0-0x00000001824FDA20
		public HGAddedMaterialController.OverlayLayer __Gen_Wrap_150(object P0); // 0x0000000184E0F6E0-0x0000000184E0FD40
		public int __Gen_Wrap_151(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public HGMeshRendererData __Gen_Wrap_152(object P0); // 0x0000000184E0FD40-0x0000000184E103A0
		public void __Gen_Wrap_153(object P0, object P1, object P2, object P3, object P4, object P5); // 0x00000001825AC720-0x00000001825ACDD0
		public void __Gen_Wrap_154(object P0, object P1, object P2, object P3, object P4); // 0x00000001825AC140-0x00000001825AC720
		public Material __Gen_Wrap_155(object P0, int P1); // 0x0000000184E103A0-0x0000000184E10A20
		public void __Gen_Wrap_156(object P0, int P1, Vector4 P2, bool P3); // 0x0000000184E10A20-0x0000000184E10E00
		public HGMeshRenderer __Gen_Wrap_157(object P0); // 0x0000000184E10E00-0x0000000184E11460
		public Bounds __Gen_Wrap_158(Bounds P0, Matrix4x4 P1); // 0x0000000184836950-0x00000001848370B0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object>, IAsyncStateMachine // TypeDefIndex: 84010
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
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x000000018CBB4894-0x000000018CBB4928 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x000000018CBB4928-0x000000018CBB49BC 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018CBB49BC-0x000000018CBB4AB4
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x00000001887F0184-0x00000001887F0204
		[IDTag(1)]
		private bool MoveNext(); // 0x00000001887EFF14-0x00000001887EFFA4
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x00000001887F0054-0x00000001887F00D4
		[IDTag(5)]
		private void MoveNext(); // 0x000000018C0E2378-0x000000018C0E23F8
		[IDTag(6)]
		private void SetStateMachine(IAsyncStateMachine P0); // 0x000000018CBB47F4-0x000000018CBB4894
		public void RefAwaitUnsafeOnCompleteMethod(); // 0x000000018CBB4790-0x000000018CBB47F4
		public void RefAsyncBuilderStartMethod(); // 0x000000018CBB4768-0x000000018CBB4790
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 84011
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018CBB4C30-0x000000018CBB4C84
		public static bool IsPatched(int id); // 0x000000018CBB4CE4-0x000000018CBB4D60
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018CBB4B3C-0x000000018CBB4BD4
		public object CreateWrapper(int id); // 0x000000018CBB4BD4-0x000000018CBB4C30
		public object InitWrapperArray(int len); // 0x000000018CBB4C84-0x000000018CBB4CE4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018CBB4AB4-0x000000018CBB4B3C
	}

	public delegate float __HotPatchDelegate_0(object P0); // TypeDefIndex: 84012; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum HotPatchIDMAP0 // TypeDefIndex: 84013
	{
		HG-Rendering-Runtime-ContainerWaterManager-get_dy0 = 0,
		Beyond-Rendering-EntityRenderAlphaDitherController-_GetCurMinAlpha0 = 0,
		Beyond-Rendering-EntityRenderAlphaDitherController-GetDitherAlpha0 = 0,
		Beyond-Rendering-EntityVFXControllerBase-get_destroyTime0 = 0,
		Beyond-Rendering-EntityVFXControllerBase-get_lastTickTime0 = 0,
		Beyond-Rendering-EntityVFXControllerStateBase-get_endDuration0 = 0,
		Beyond-Rendering-EntityVFXControllerStateBase-get_duration0 = 0,
		Beyond-Rendering-EntityVFXControllerStateBase-get_loopDuration0 = 0,
		HG-Rendering-Runtime-ContainerWaterManager-_PrecomputeCylinderMask0 = 1,
		HG-Rendering-Runtime-ContainerWaterManager-_InitializeWaveSystem0 = 1,
		HG-Rendering-Runtime-ContainerWaterManager-Start0 = 1,
		HG-Rendering-Runtime-ContainerWaterManager-ResetWaveTexture0 = 1,
		HG-Rendering-Runtime-ContainerWaterManager-Update0 = 1,
		Beyond-Rendering-ShaderWarmupManager-_DisposeWarmupAssetHandles0 = 1,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Tick0 = 1,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Begin0 = 1,
		Beyond-Rendering-EntityRenderAlphaDitherController-ResetDitherAlpha0 = 1,
		Beyond-Rendering-EntityRenderAlphaDitherController-Reset0 = 1,
		Beyond-Rendering-EntityRenderCaptureMeshController-Reset0 = 1,
		Beyond-Rendering-EntityRenderCaptureMeshController-_SyncTransformInRenderPipeline0 = 1,
		Beyond-Rendering-EntityRenderCaptureMeshController-LateTick0 = 1,
		Beyond-Rendering-EntityRenderHelperMaterialController-OnRelease0 = 1,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Reset0 = 1,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-Clear0 = 1,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Reset0 = 1,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Reset0 = 1,
		Beyond-Rendering-EntityRenderHelperMaterialController-Reset0 = 1,
		Beyond-Rendering-EntityRenderHelperMaterialController-RevertShadowCastingMode0 = 1,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_InitCustomizeRendererProperty0 = 1,
		Beyond-Rendering-EntityRenderHelperVisibleController-_InitDictionary0 = 1,
		Beyond-Rendering-EntityRenderHelperVisibleController-Release0 = 1,
		Beyond-Rendering-EntityRenderHelperVisibleController-Reset0 = 1,
		Beyond-Rendering-EntityRenderMaterialManager-ClearMaterials0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-OnDestroy0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-Destroy0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-Play0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-Replay0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-RefreshLastTickTime0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-OnHide0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-Hide0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-OnShow0 = 1,
		Beyond-Rendering-EntityVFXControllerBase-Show0 = 1,
		Beyond-Rendering-EntityVFXControllerStateBase-Play0 = 1,
		Beyond-Rendering-EntityVFXControllerStateBase-Replay0 = 1,
		Beyond-Rendering-EntityVFXControllerStateBase-_FinalStop0 = 1,
		Beyond-Rendering-CommonVAT-Start0 = 1,
		Beyond-Rendering-CommonVAT-_ClearTimer0 = 1,
		Beyond-Rendering-CommonVAT-_NextPlay0 = 1,
		Beyond-Rendering-FactoryVAT-_InitRenderer0 = 1,
		Beyond-Rendering-FactoryVAT-Start0 = 1,
		Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer_MeshRender0 = 1,
		Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer0 = 1,
		Beyond-Rendering-FactoryVAT-Reset0 = 1,
		Beyond-Rendering-FactoryVAT-_SetParamsToRenderer_MeshRender0 = 1,
		Beyond-Rendering-FactoryVAT-_SetParamsToRenderer0 = 1,
		Beyond-Rendering-FactoryVAT-_UpdateAnim0 = 1,
		Beyond-Rendering-FactoryVAT-OnUpdate0 = 1,
		Beyond-Rendering-PsoCreateUploadHelper-Init0 = 1,
		Beyond-Rendering-PsoCreateUploadHelper-Dispose0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_CalculatePolygonAndBounds0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_RaycastSceneObjectsHeight0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_CalculateInPolygon0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_CalculateInHighPowerZone0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance1 = 1,
		Beyond-Rendering-VFXSludgeBaker-_BlurTopHeight0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_CalculateThicknessAndTopHeight0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_CalculateNormals0 = 1,
		Beyond-Rendering-VFXSludgeBaker-_CreateTexture0 = 1,
		Beyond-Rendering-VFXSludgeBaker-Bake0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_CreateInstance0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_ExtractSplineData0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_DestroyInstance0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_Release0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Update0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnEnable0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDisable0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDestroy0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDrawGizmosSelected0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Pause0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Play0 = 1,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Stop0 = 1,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-_RendererInfoTransfer0 = 1,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-Awake0 = 1,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-OnEnable0 = 1,
		Beyond-Rendering-LODLightmapping-LODLightmapping-RendererInfoTransfer0 = 1,
		Beyond-Rendering-ECS-HGAddedMaterialController-Reset0 = 1,
		Beyond-Rendering-ECS-HGAddedMaterialController-_DestroyLayer0 = 1,
		Beyond-Rendering-ECS-HGAddedMaterialController-Release0 = 1,
		Beyond-Rendering-ECS-HGMaterialCommitter-MarkMaterialsArrayDirty0 = 1,
		Beyond-Rendering-ECS-HGMaterialCommitter-_Commit0 = 1,
		Beyond-Rendering-ECS-HGMaterialCommitter-TryCommit0 = 1,
		Beyond-Rendering-ECS-HGMaterialCommitter-ForceCommit0 = 1,
		Beyond-Rendering-ECS-HGMaterialCommitter-Reset0 = 1,
		Beyond-Rendering-ECS-HGMaterialCommitter-Release0 = 1,
		Beyond-Rendering-ECS-HGMaterialController-Reset0 = 1,
		Beyond-Rendering-ECS-HGMaterialController-_DestroyInstancedMaterials0 = 1,
		Beyond-Rendering-ECS-HGMaterialController-Release0 = 1,
		Beyond-Rendering-ECS-HGRendererStateController-Reset0 = 1,
		Beyond-Rendering-ECS-HGRendererStateController-_WarnNoMeshes0 = 1,
		Beyond-Rendering-ECS-HGRendererStateController-_EnsureMeshLocalBoundsCached0 = 1,
		Beyond-Rendering-ECS-HGRendererStateController-InvalidateMeshCache0 = 1,
		Beyond-Rendering-ECS-HGRendererStateController-RevertShadowCastingMode0 = 1,
		Beyond-Rendering-ECS-HGRendererStateController-Release0 = 1,
		HG-Rendering-Runtime-ContainerWaterManager-_ApplyMatrixToTexture0 = 2,
		HG-Rendering-Runtime-ContainerWaterManager-_IsInsideCylinder0 = 3,
		HG-Rendering-Runtime-ContainerWaterManager-_IsValidPosition0 = 3,
		HG-Rendering-Runtime-ContainerWaterManager-_WorldToTextureCoords0 = 4,
		HG-Rendering-Runtime-ContainerWaterManager-_UnifiedWaveStep0 = 5,
		HG-Rendering-Runtime-ContainerWaterManager-_UpdateVortexState0 = 5,
		Beyond-Rendering-EntityRenderHelperMaterialController-StopShadowCasting0 = 5,
		Beyond-Rendering-EntityRenderMaterialManager-SetDepthOnlyEnabled0 = 5,
		Beyond-Rendering-EntityVFXControllerBase-Stop0 = 5,
		Beyond-Rendering-EntityVFXControllerStateBase-Stop0 = 5,
		Beyond-Rendering-ECS-HGMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 5,
		Beyond-Rendering-ECS-HGRendererStateController-SetVisible0 = 5,
		Beyond-Rendering-ECS-HGRendererStateController-StopShadowCasting0 = 5,
		HG-Rendering-Runtime-ContainerWaterManager-_SetIcePositionIfChanged0 = 6,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveColor0 = 6,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveAlbedoColor0 = 6,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_CharacterParams0 = 6,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_LitDissolve0 = 7,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_SweepLightIntensity0 = 7,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_VFXAlpha00 = 7,
		Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherAlpha0 = 7,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherAlphaValue0 = 7,
		Beyond-Rendering-EntityVFXControllerBase-set_destroyTime0 = 7,
		Beyond-Rendering-EntityVFXControllerBase-set_lastTickTime0 = 7,
		Beyond-Rendering-EntityVFXControllerBase-Tick0 = 7,
		Beyond-Rendering-EntityVFXControllerStateBase-Tick0 = 7,
		Beyond-Rendering-ECS-HGMaterialController-SetManualDitherAlphaValue0 = 7,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_HoudiniVAT0 = 8,
		Beyond-Rendering-EntityRenderHelperMaterialController-RemoveMaterialFromAllRenderer0 = 8,
		Beyond-Rendering-ECS-HGAddedMaterialController-RequireRemoveMaterial0 = 8,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_MovingBamboo0 = 9,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_SweepBreathing0 = 10,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_UVAnimation0 = 11,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_TrailScanCircle0 = 11,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_TrailDisplayArea0 = 12,
		Beyond-Rendering-PipelineSettingHelper-_GetFullSettingPath0 = 13,
		Beyond-Rendering-PipelineSettingHelper-_LoadSetting0 = 13,
		Beyond-Rendering-WindowsGpuDriverVersion-_GetDriverKeySuffix0 = 13,
		Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllResults0 = 13,
		Beyond-Rendering-ShaderWarmupManager-_PreparePsoCacheBackupPath0 = 13,
		Beyond-Rendering-WindowsGpuDriverVersion-Result-ToString0 = 13,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-get_rendererName0 = 13,
		Beyond-Rendering-EntityVFXAssetBase-get_assetName0 = 13,
		Beyond-Rendering-EntityVFXControllerBase-get_vfxName0 = 13,
		Beyond-Rendering-CommonVAT-get_PropertySetterType0 = 13,
		Beyond-Rendering-PipelineSettingHelper-LoadPipelineSettings0 = 14,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmupFinishAPI0 = 14,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmUpLoginFinish0 = 14,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmupDx11Driver0 = 14,
		Beyond-Rendering-ShaderWarmupManager-MarkWarmUpLoginFinish0 = 14,
		Beyond-Rendering-ShaderWarmupManager-CleanLoadedPso0 = 14,
		Beyond-Rendering-ShaderWarmupManager-TryRepairPsoCacheAfterCorruptCheck0 = 14,
		Beyond-Rendering-ShaderWarmupManager-_ResetWarmUpStatsIfNeed0 = 14,
		Beyond-Rendering-ShaderWarmupManager-StopWarmupShadersDownloading0 = 14,
		Beyond-Rendering-PsoCreateUploadHelper-BeforeWarmUpBegin0 = 14,
		Beyond-Rendering-PsoCreateUploadHelper-AfterWarmUpFinish0 = 14,
		Beyond-Rendering-ShaderWarmupManager-_UpdateDownloadWarmupPercent0 = 14,
		Beyond-Rendering-PsoCreateUploadHelper-Initialize0 = 14,
		Beyond-Rendering-ResourceRouter-_GetCategoryFolder0 = 15,
		Beyond-Rendering-ResourceRouter-GetEnvironmentsFullPath0 = 16,
		Beyond-Rendering-ResourceRouter-GetDecalResourcesFullPath0 = 16,
		Beyond-Rendering-ResourceRouter-GetDecalResourcesPath0 = 17,
		Beyond-Rendering-ShaderWarmupManager-GetLoginWarmupDetail0 = 17,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-get_cpuNameForWarmUp0 = 17,
		Beyond-Rendering-WindowsGpuDriverVersion-GetCurrentDriverVersion0 = 17,
		Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllCurrentResults0 = 17,
		Beyond-Rendering-PsoCreateUploadHelper-get_persistentDataPath0 = 17,
		Beyond-Rendering-PsoCreateUploadHelper-_PsoUpdateGameInfoCallBack0 = 17,
		Beyond-Rendering-ShaderWarmupManager-get_isWarming0 = 18,
		Beyond-Rendering-ShaderWarmupManager-_TryBackupAndDeleteVulkanPsoCacheFile0 = 18,
		Beyond-Rendering-ShaderWarmupManager-_IsDeviceSupportWarmUp0 = 18,
		Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByFirstEntry0 = 18,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByGraphicsChange0 = 18,
		Beyond-Rendering-ShaderWarmupManager-_CheckWarmUpUnfinishedOften0 = 18,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupDx11Driver0 = 18,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByCacheOutdated0 = 18,
		Beyond-Rendering-PsoCreateUploadHelper-IsPsoRecordEnabled0 = 18,
		Beyond-Rendering-ShaderWarmupManager-_IsDeviceSupportDownloadWarmUp0 = 18,
		Beyond-Rendering-ShaderWarmupManager-GetPsoPathName0 = 19,
		Beyond-Rendering-ShaderWarmupManager-GetPsoPathName1 = 20,
		Beyond-Rendering-ShaderWarmupManager-_GetCacheFileSize0 = 21,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsEnablePsoCacheBackup0 = 22,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsEnableDx11DriverVersionDetect0 = 22,
		Beyond-Rendering-ShaderWarmupManager-_TryDeletePsoCacheFile0 = 22,
		Beyond-Rendering-ShaderWarmupManager-_TryBackupVulkanPsoCacheFile0 = 22,
		Beyond-Rendering-WindowsGpuDriverVersion-IsBestMatchDriverVersionChanged0 = 22,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-get_isTimeOut0 = 22,
		Beyond-Rendering-WindowsGpuDriverVersion-SafeRegistryHandle-ReleaseHandle0 = 22,
		Beyond-Rendering-EntityRenderAlphaDitherController-_ApplyNewAlpha0 = 22,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-get_rendererValid0 = 22,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryBeginMaterialUpdate0 = 22,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-IsRendererValid0 = 22,
		Beyond-Rendering-EntityRenderHelperMaterialController-IsAllRendererValid0 = 22,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryRevertShadowCastingMode0 = 22,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-get_rendererValid0 = 22,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TryResetVisible0 = 22,
		Beyond-Rendering-EntityVFXControllerBase-get_isPlaying0 = 22,
		Beyond-Rendering-EntityVFXControllerBase-get_isStopping0 = 22,
		Beyond-Rendering-EntityVFXControllerBase-get_isHiding0 = 22,
		Beyond-Rendering-EntityVFXControllerBase-get_isKeyword0 = 22,
		Beyond-Rendering-EntityVFXControllerBase-GetAllowSimultaneousKeyword0 = 22,
		Beyond-Rendering-EntityVFXControllerBase-GetNeedTick0 = 22,
		Beyond-Rendering-EntityVFXControllerStateBase-get_isStopping0 = 22,
		Beyond-Rendering-EntityVFXControllerStateBase-get_useEndCurve0 = 22,
		Beyond-Rendering-EntityVFXControllerStateBase-get_useLoopCurve0 = 22,
		Beyond-Rendering-EntityVFXControllerStateBase-GetNeedTick0 = 22,
		Beyond-Rendering-EntityVFXControllerStateBase-get_useScaledTime0 = 22,
		Beyond-Rendering-EntityVFXControllerStateBase-get_loop0 = 22,
		Beyond-Rendering-EntityVFXControllerStateBase-get_useStartCurve0 = 22,
		Beyond-Rendering-ECS-HGMaterialCommitter-IsDirty0 = 22,
		Beyond-Rendering-ECS-HGRendererStateController-IsValid0 = 22,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-_CheckDeviceMatch0 = 23,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-TryMatchDevice0 = 24,
		Beyond-Rendering-ShaderWarmupManager-ProcessRemoteConfig0 = 25,
		Beyond-Rendering-EntityRenderCaptureMeshController-Release0 = 25,
		Beyond-Rendering-EntityRenderCaptureMeshController-InitRendererTypeMasks0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Init0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-ApplySharedMaterialArray0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReleaseAllReplaceMaterial0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-CopyFrom0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Init0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_RestoreFloatPropertiesFromSource0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_RestoreVectorPropertiesFromSource0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_RestoreTexturePropertiesFromSource0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-FillRendererTypeMasks0 = 25,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_TryReleaseAllReplaceMaterial0 = 25,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-_Init0 = 25,
		Beyond-Rendering-EntityRenderHelperVisibleController-Init0 = 25,
		Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByNameContainsStr0 = 25,
		Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByRenderer0 = 25,
		Beyond-Rendering-EntityRenderMaterialManager-AddMaterial0 = 25,
		Beyond-Rendering-EntityRenderMaterialManager-_RevertMaterial0 = 25,
		Beyond-Rendering-EntityRenderMaterialManager-RemoveMaterial0 = 25,
		Beyond-Rendering-EntityVFXControllerBase-InitLOD0 = 25,
		Beyond-Rendering-EntityVFXControllerBase-SetName0 = 25,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-Init0 = 25,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_AddVATMaterial0 = 25,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_RemoveVATMaterial0 = 25,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-AddMaterialToAllRenderer0 = 25,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-RemoveMaterialFromAllRenderer0 = 25,
		Beyond-Rendering-EntityVFXFactoryMaterialCache-ReleaseVATMaterial0 = 25,
		Beyond-Rendering-CommonVAT-_UpdateProperty0 = 25,
		Beyond-Rendering-CommonVAT-_DoPlay0 = 25,
		Beyond-Rendering-FactoryVAT-_InitRenderer_MeshRender0 = 25,
		Beyond-Rendering-VATRendererPropertySetter-Init0 = 25,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-Init0 = 25,
		Beyond-Rendering-ECS-HGMaterialController-RestoreFloatPropertiesFromSource0 = 25,
		Beyond-Rendering-ECS-HGMaterialController-RestoreVectorPropertiesFromSource0 = 25,
		Beyond-Rendering-ECS-HGMaterialController-RestoreTexturePropertiesFromSource0 = 25,
		Beyond-Rendering-ECS-HGMaterialController-ReplaceAllMaterials0 = 25,
		Beyond-Rendering-ECS-HGRendererStateController-Init0 = 25,
		Beyond-Rendering-ShaderWarmupManager-MarkNeedShaderWarmUp0 = 26,
		Beyond-Rendering-WindowsGpuDriverVersion-_GetDeviceRegistryPropertyString0 = 27,
		Beyond-Rendering-WindowsGpuDriverVersion-_ContainsIgnoreCase0 = 28,
		Beyond-Rendering-SceneStateAreaKey-_SequenceEqual0 = 28,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetSharedMaterials0 = 28,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryReplaceSharedMaterials0 = 28,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetSharedMaterial0 = 28,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryFillRendererTypeMask0 = 28,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TryInit0 = 28,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TryAddToDictionary0 = 28,
		Beyond-Rendering-WindowsGpuDriverVersion-_ScoreAgainstUnityCurrentGpu0 = 29,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetAddedMaterialIndex0 = 29,
		Beyond-Rendering-WindowsGpuDriverVersion-_ReadRegistrySz0 = 30,
		Beyond-Rendering-WindowsGpuDriverVersion-GetAllDisplayDriverVersions0 = 31,
		Beyond-Rendering-ShaderWarmupManager-_FinishPsoCacheBackup0 = 32,
		Beyond-Rendering-ShaderWarmupManager-_SetWarmupRetryCount0 = 33,
		Beyond-Rendering-ShaderWarmupManager-_SetWarmupUnfinishedCount0 = 33,
		Beyond-Rendering-ShaderWarmupManager-_SetDownloadingWarmupUnfinishedCount0 = 33,
		Beyond-Rendering-WindowsGpuDriverVersion-GetBestMatch0 = 34,
		Beyond-Rendering-WindowsGpuDriverVersion-_TryGetDriverVersionByKeyId0 = 35,
		Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByDeviceState0 = 36,
		Beyond-Rendering-ShaderWarmupManager-CheckNeedWarmUpLogin0 = 36,
		Beyond-Rendering-ShaderWarmupManager-_StopDownloadingWarmupAndWait0 = 37,
		Beyond-Rendering-ShaderWarmupManager-_BuildLoginWarmupPaths0 = 38,
		Beyond-Rendering-ShaderWarmupManager-_LoadPsoAssets0 = 39,
		Beyond-Rendering-ShaderWarmupManager-_GetBackgroundWarmupStartIndex0 = 40,
		Beyond-Rendering-ShaderWarmupManager-_GetCompileCountForRange0 = 40,
		Beyond-Rendering-ShaderWarmupManager-_GetWarmupEndIndexExclusive0 = 40,
		Beyond-Rendering-VFXSludgeBaker-_GetHash1 = 40,
		Beyond-Rendering-ShaderWarmupManager-_InitWarmupStats0 = 41,
		Beyond-Rendering-ShaderWarmupManager-_GetLoginTimeLimit0 = 42,
		Beyond-Rendering-ShaderWarmupManager-_GetDownloadingWarmupUnfinishedCount0 = 42,
		Beyond-Rendering-ShaderWarmupManager-_StepProgress0 = 43,
		Beyond-Rendering-ShaderWarmupManager-_WarmupOnePsoTimeLimited0 = 44,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersLogin0 = 45,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersDownloading0 = 45,
		Beyond-Rendering-ShaderWarmupManager-_WarmupOnePsoBackgroundOnly0 = 46,
		Beyond-Rendering-ShaderWarmupManager-WarmupOnePso0 = 46,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersScene0 = 47,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsDeviceInBlackList0 = 48,
		Beyond-Rendering-SceneStateAreaKey-Equals0 = 49,
		Beyond-Rendering-SceneStateAreaKey-Equals1 = 50,
		Beyond-Rendering-SceneStateAreaKey-GetHashCode0 = 51,
		Beyond-Rendering-SceneStateAreaKey-_Normalize0 = 52,
		Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherEnabled0 = 53,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryStopShadowCasting0 = 53,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherEnable0 = 53,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TrySetVisible0 = 53,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TrySetVisibleByRenderer0 = 53,
		Beyond-Rendering-ECS-HGMaterialController-SetManualDitherEnable0 = 53,
		Beyond-Rendering-EntityRenderAlphaDitherController-SetDitherAlpha0 = 54,
		Beyond-Rendering-EntityRenderAlphaDitherController-GetAlphaDictionary0 = 55,
		Beyond-Rendering-EntityRenderCaptureMeshController-Capture0 = 56,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-_GetSubMeshCount0 = 57,
		Beyond-Rendering-EntityVFXCurveData-get_propertyId0 = 57,
		Beyond-Rendering-ECS-HGAddedMaterialController-get_activeLayerCount0 = 57,
		Beyond-Rendering-EntityVFXUtils-ToMask0 = 58,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-_Init0 = 59,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Init0 = 59,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReplaceSharedMaterial0 = 59,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CopyReplaceMaterial0 = 59,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CreateReplaceMaterial0 = 59,
		Beyond-Rendering-EntityVFXControllerBase-SetOwner0 = 59,
		Beyond-Rendering-FactoryVAT-_DoPlay0 = 59,
		Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFileToServer0 = 59,
		Beyond-Rendering-ECS-HGMaterialController-_ApplyAllPropertiesToOneMaterial0 = 59,
		Beyond-Rendering-ECS-HGMaterialController-ReplaceMaterialBySource0 = 59,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryInit0 = 60,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_TryEnsureReplaceMaterial0 = 60,
		Beyond-Rendering-EntityRenderHelperMaterialController-Init0 = 61,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-get_currentMeshMaterials0 = 62,
		Beyond-Rendering-ECS-HGMaterialController-get_currentMeshMaterials0 = 62,
		Beyond-Rendering-AddMaterialConfig-get_useCustomizeProperty0 = 63,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_GetCustomizePropertyMaterial0 = 64,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetCharacterPerDrawData0 = 65,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetEmissiveColor0 = 65,
		Beyond-Rendering-EntityCustomizeRendererPropertyConfig-GetColorTexture0 = 66,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireAddMaterial0 = 67,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddMaterialToAllRenderer0 = 67,
		Beyond-Rendering-EntityRenderHelperMaterialController-_GetRenderersOfRendererMask0 = 68,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveFloatProperty0 = 69,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveFloatProperty0 = 69,
		Beyond-Rendering-EntityRenderMaterialManager-SetFloat0 = 69,
		Beyond-Rendering-VATRendererPropertySetter-SetFloat0 = 69,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetFloat0 = 69,
		Beyond-Rendering-ECS-HGAddedMaterialController-SetAddictiveFloatProperty0 = 69,
		Beyond-Rendering-ECS-HGMaterialController-SetFloatToAllMaterial0 = 69,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveFloatProperty0 = 70,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveFloatProperty0 = 70,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetAddictiveFloatProperty0 = 70,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveVectorProperty0 = 71,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveVectorProperty0 = 71,
		Beyond-Rendering-EntityRenderMaterialManager-SetVector0 = 71,
		Beyond-Rendering-VATRendererPropertySetter-SetVector0 = 71,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetVector0 = 71,
		Beyond-Rendering-ECS-HGAddedMaterialController-SetAddictiveVectorProperty0 = 71,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveVectorProperty0 = 72,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveVectorProperty0 = 72,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetAddictiveVectorProperty0 = 72,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveTextureProperty0 = 73,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveTextureProperty0 = 73,
		Beyond-Rendering-EntityRenderMaterialManager-SetTexture0 = 73,
		Beyond-Rendering-ECS-HGAddedMaterialController-SetAddictiveTextureProperty0 = 73,
		Beyond-Rendering-ECS-HGMaterialController-SetTextureToAllMaterial0 = 73,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveTextureProperty0 = 74,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveTextureProperty0 = 74,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetAddictiveTextureProperty0 = 74,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireRemoveMaterial0 = 75,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 76,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 76,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 76,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_SplitRenderers0 = 77,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseFloatToAllMaterial0 = 77,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseVectorToAllMaterial0 = 77,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseTextureToAllMaterial0 = 77,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_GetAffectGroupData0 = 78,
		Beyond-Rendering-EntityRenderHelperMaterialController-CollectRenderers0 = 78,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetKeywordEnableToAllMaterial0 = 79,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetKeywordEnableToAllMaterial0 = 79,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 80,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 80,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-_PackUNorm8ToFloat0 = 81,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetFloatToCustomPerDraw0 = 82,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToCustomPerDraw0 = 82,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetVectorToCustomPerDraw0 = 83,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToCustomPerDraw0 = 83,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetFloatToAllMaterial0 = 84,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToAllMaterial0 = 84,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-RestoreFloatPropertiesFromSource0 = 85,
		Beyond-Rendering-EntityRenderHelperMaterialController-RestoreFloatPropertiesFromSource0 = 85,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-RestoreVectorPropertiesFromSource0 = 85,
		Beyond-Rendering-EntityRenderHelperMaterialController-RestoreVectorPropertiesFromSource0 = 85,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-RestoreTexturePropertiesFromSource0 = 85,
		Beyond-Rendering-EntityRenderHelperMaterialController-RestoreTexturePropertiesFromSource0 = 85,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetVectorToAllMaterial0 = 86,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToAllMaterial0 = 86,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetTextureToAllMaterial0 = 87,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetTextureToAllMaterial0 = 87,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryGetRenderer0 = 88,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetManualDitherAlphaValue0 = 89,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TrySetManualDitherEnable0 = 90,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryGetRendererPosition0 = 91,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryGetRendererBounds0 = 92,
		Beyond-Rendering-EntityRenderHelperMaterialController-RendererInfo-TryEncapsulateBounds0 = 93,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetRendererBounds0 = 94,
		Beyond-Rendering-ECS-HGRendererStateController-GetBounds0 = 94,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetZTestInMaterial0 = 95,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetZTestInMaterial0 = 95,
		Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByNameContainsStr0 = 95,
		Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByRenderer0 = 95,
		Beyond-Rendering-EntityRenderHelperVisibleController-OverrideOriginalVisibleByDisabledRenderers0 = 95,
		Beyond-Rendering-EntityRenderMaterialManager-SetKeywordEnable0 = 95,
		Beyond-Rendering-EntityRenderMaterialManager-SetZTestInMaterial0 = 95,
		Beyond-Rendering-CommonVAT-Play0 = 95,
		Beyond-Rendering-ECS-HGMaterialController-_ApplyDepthOnlyPassToMaterial0 = 95,
		Beyond-Rendering-ECS-HGMaterialController-SetKeywordEnableToAllMaterial0 = 95,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetRenderHelperType0 = 96,
		Beyond-Rendering-EntityRenderHelperVisibleController-_TryGetRendererInfo0 = 97,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-TryOverrideOriginalVisible0 = 98,
		Beyond-Rendering-EntityVFXAsset-GetRendererTypeConfigs0 = 99,
		Beyond-Rendering-EntityVFXControllerBase-GetDeltaTimeFromLastTick0 = 100,
		Beyond-Rendering-EntityVFXControllerBase-GetPriorityType0 = 101,
		Beyond-Rendering-EntityVFXControllerBase-GetRendererMask0 = 102,
		Beyond-Rendering-EntityVFXControllerBase-OnSample0 = 103,
		Beyond-Rendering-EntityVFXControllerBase-Sample0 = 103,
		Beyond-Rendering-EntityVFXControllerStateBase-OnSample0 = 103,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetVATMaterial0 = 104,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetFloatToFactoryMaterial0 = 105,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetVectorToFactoryMaterial0 = 106,
		Beyond-Rendering-EntityVFXFactoryMaterialCache-GetVATMaterial0 = 107,
		Beyond-Rendering-EntityVFXUtils-GetBoundsMinMaxOfDirection0 = 108,
		Beyond-Rendering-EntityVFXUtils-CalculateCutOffBounds0 = 109,
		Beyond-Rendering-EntityVFXUtils-Evaluate0 = 110,
		Beyond-Rendering-EntityVFXUtils-_UpdateCurve0 = 111,
		Beyond-Rendering-EntityVFXUtils-ApplyEntityVFXCurves0 = 111,
		Beyond-Rendering-CommonVAT-_CreateTimer0 = 112,
		Beyond-Rendering-FactoryVAT-Play0 = 113,
		Beyond-Rendering-PsoCreateUploadHelper-get_instance0 = 114,
		Beyond-Rendering-PsoCreateUploadHelper-_PsoUploadProcessOneCallBack0 = 115,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadPipelineCreatedInfo0 = 116,
		Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFinalJson0 = 116,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadFileToServer0 = 117,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadFile0 = 117,
		Beyond-Rendering-PsoCreateUploadHelper-_Tick0 = 118,
		Beyond-Rendering-PsoCreateUploadHelper-_SceneLoadStartHandler0 = 119,
		Beyond-Rendering-PsoCreateUploadHelper-_Callback0 = 120,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSpline0 = 121,
		Beyond-Rendering-VFXSludgeBaker-GetLocalPosition0 = 122,
		Beyond-Rendering-VFXSludgeUtils-CalculatePointPolygonHorizonRayCross0 = 123,
		Beyond-Rendering-VFXSludgeBaker-GetLocalIndex0 = 124,
		Beyond-Rendering-VFXSludgeBaker-_GetHash0 = 125,
		Beyond-Rendering-VFXSludgeBaker-_ForAround0 = 126,
		Beyond-Rendering-VFXSludgeBaker-_GetTextureColor10 = 127,
		Beyond-Rendering-VFXSludgeBaker-_GetTextureColor20 = 127,
		Beyond-Rendering-VFXSludgeBaker-_CreateGaussianKernel0 = 128,
		Beyond-Rendering-VFXSludgeBaker-_Convolution0 = 129,
		Beyond-Rendering-VFXSludgeNavUtils-BoundsUtil-GetTopBottomPoints0 = 130,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameFromPlaneNormal0 = 131,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameByYaw0 = 132,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-SampleUniformByArcLength0 = 133,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-WorldToFrame0 = 134,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-FrameToWorld0 = 134,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ProjectWorldToFrameXZ0 = 135,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ConvexHullIndices0 = 136,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_AngleDegAt0 = 137,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_CurvatureAt0 = 137,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_PointToSegmentDistance2D0 = 138,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Simplify2D_ByCurvatureAngleDeviation0 = 139,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Process0 = 140,
		Beyond-Rendering-VFXSludgeNavUtils-SplineSamplingUtils-SampleByArcLength0 = 141,
		Beyond-Rendering-VFXSludgeNavUtils-PolySimplify-SimplifyByAngle0 = 142,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSplineWithSimplify0 = 143,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffByPolyLine0 = 144,
		Beyond-Rendering-ECS-HGAddedMaterialController-Init0 = 145,
		Beyond-Rendering-ECS-HGAddedMaterialController-_CreateNewLayer0 = 146,
		Beyond-Rendering-ECS-HGAddedMaterialController-RequireAddMaterial0 = 147,
		Beyond-Rendering-ECS-HGAddedMaterialController-GetActiveOverlayRenderers0 = 147,
		Beyond-Rendering-ECS-HGMaterialCommitter-get_clonedData0 = 148,
		Beyond-Rendering-ECS-HGMaterialCommitter-Init0 = 149,
		Beyond-Rendering-ECS-HGMaterialController-Init0 = 150,
		Beyond-Rendering-ECS-HGMaterialController-_GetOrCreateInstancedMaterial0 = 151,
		Beyond-Rendering-ECS-HGMaterialController-SetVectorToAllMaterial0 = 152,
		Beyond-Rendering-ECS-HGRendererStateController-get_hgRenderer0 = 153,
		Beyond-Rendering-ECS-HGRendererStateController-_LocalBoundsToWorld0 = 154
	}

	public delegate void __HotPatchDelegate_1(object P0); // TypeDefIndex: 84014; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_2(object P0, object P1, ref Texture2D P2, float P3); // TypeDefIndex: 84015; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_3(object P0, int P1, int P2); // TypeDefIndex: 84016; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_4(object P0, Vector3 P1, ref Vector2Int P2); // TypeDefIndex: 84017; 0x0000000181289520-0x0000000181289560

	public delegate void __HotPatchDelegate_5(object P0, bool P1); // TypeDefIndex: 84018; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_6(object P0, Vector4 P1); // TypeDefIndex: 84019; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate void __HotPatchDelegate_7(object P0, float P1); // TypeDefIndex: 84020; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_8(object P0, int P1); // TypeDefIndex: 84021; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_9(object P0, Vector4 P1, Vector4 P2); // TypeDefIndex: 84022; 0x000000018416ED10-0x000000018416ED50

	public delegate void __HotPatchDelegate_10(object P0, float P1, float P2, float P3); // TypeDefIndex: 84023; 0x00000001812250A0-0x00000001812250C0

	public delegate void __HotPatchDelegate_11(object P0, float P1, float P2); // TypeDefIndex: 84024; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_12(object P0, float P1, float P2, float P3, float P4); // TypeDefIndex: 84025; 0x000000018415EF40-0x000000018415EF60

	public delegate string __HotPatchDelegate_13(object P0); // TypeDefIndex: 84026; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_14(); // TypeDefIndex: 84027; 0x0000000185B44B70-0x0000000185B44B80

	public delegate string __HotPatchDelegate_15(RootCategory P0); // TypeDefIndex: 84028; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_16(RootCategory P0, bool P1); // TypeDefIndex: 84029; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_17(); // TypeDefIndex: 84030; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_18(); // TypeDefIndex: 84031; 0x0000000185B44B70-0x0000000185B44B80

	public delegate string __HotPatchDelegate_19(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3); // TypeDefIndex: 84032; 0x00000001811CDB70-0x00000001811CDB90

	public delegate string __HotPatchDelegate_20(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3, object P4); // TypeDefIndex: 84033; 0x00000001812083C0-0x00000001812083E0

	public delegate long __HotPatchDelegate_21(); // TypeDefIndex: 84034; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_22(object P0); // TypeDefIndex: 84035; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_23(object P0, object P1, object P2, object P3, object P4, object P5); // TypeDefIndex: 84036; 0x0000000181256340-0x0000000181256360

	public delegate bool __HotPatchDelegate_24(object P0, out bool P1, out string P2); // TypeDefIndex: 84037; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_25(object P0, object P1); // TypeDefIndex: 84038; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_26(ShaderWarmupManager.WarmUpReason P0); // TypeDefIndex: 84039; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_27(IntPtr P0, ref WindowsGpuDriverVersion.SP_DEVINFO_DATA P1, uint P2); // TypeDefIndex: 84040; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_28(object P0, object P1); // TypeDefIndex: 84041; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_29(object P0, object P1, object P2); // TypeDefIndex: 84042; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_30(object P0, object P1); // TypeDefIndex: 84043; 0x00000001859B7730-0x00000001859B7740

	public delegate List<WindowsGpuDriverVersion.Result> __HotPatchDelegate_31(); // TypeDefIndex: 84044; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_32(object P0, object P1, long P2); // TypeDefIndex: 84045; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_33(int P0); // TypeDefIndex: 84046; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate WindowsGpuDriverVersion.Result __HotPatchDelegate_34(); // TypeDefIndex: 84047; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_35(object P0, object P1, out string P2); // TypeDefIndex: 84048; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_36(bool P0); // TypeDefIndex: 84049; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_37(); // TypeDefIndex: 84050; 0x0000000185B44B70-0x0000000185B44B80

	public delegate List<StringPathHash> __HotPatchDelegate_38(bool P0); // TypeDefIndex: 84051; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_39(object P0, object P1, object P2); // TypeDefIndex: 84052; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_40(object P0, int P1, int P2); // TypeDefIndex: 84053; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_41(object P0, bool P1, bool P2); // TypeDefIndex: 84054; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_42(); // TypeDefIndex: 84055; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_43(int P0, ref int P1); // TypeDefIndex: 84056; 0x00000001859B7730-0x00000001859B7740

	public delegate IEnumerator __HotPatchDelegate_44(object P0, int P1, int P2, object P3); // TypeDefIndex: 84057; 0x00000001811CDB70-0x00000001811CDB90

	public delegate IEnumerator __HotPatchDelegate_45(bool P0); // TypeDefIndex: 84058; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_46(object P0, int P1, int P2); // TypeDefIndex: 84059; 0x00000001811DF7F0-0x00000001811DF810

	public delegate IEnumerator __HotPatchDelegate_47(object P0); // TypeDefIndex: 84060; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_48(object P0, out string P1); // TypeDefIndex: 84061; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_49(ref SceneStateAreaKey P0, SceneStateAreaKey P1); // TypeDefIndex: 84062; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate bool __HotPatchDelegate_50(ref SceneStateAreaKey P0, object P1); // TypeDefIndex: 84063; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_51(ref SceneStateAreaKey P0); // TypeDefIndex: 84064; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int[] __HotPatchDelegate_52(object P0); // TypeDefIndex: 84065; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_53(object P0, bool P1); // TypeDefIndex: 84066; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_54(object P0, float P1, int P2); // TypeDefIndex: 84067; 0x000000018238E680-0x000000018238E6A0

	public delegate Dictionary<int, float> __HotPatchDelegate_55(object P0); // TypeDefIndex: 84068; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate EntityRenderCapturedEntity __HotPatchDelegate_56(object P0, object P1, EntityVFXRendererMask P2); // TypeDefIndex: 84069; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_57(object P0); // TypeDefIndex: 84070; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate EntityVFXRendererMask __HotPatchDelegate_58(EntityVFXRendererType P0); // TypeDefIndex: 84071; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_59(object P0, object P1, object P2); // TypeDefIndex: 84072; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_60(object P0, object P1, object P2); // TypeDefIndex: 84073; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_61(object P0, object P1, object P2, object P3, bool P4); // TypeDefIndex: 84074; 0x000000018129F400-0x000000018129F420

	public delegate Material[] __HotPatchDelegate_62(object P0); // TypeDefIndex: 84075; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_63(ref AddMaterialConfig P0); // TypeDefIndex: 84076; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Material __HotPatchDelegate_64(object P0, EntityRenderHelperMaterialController.AddedMaterialInfo P1, object P2); // TypeDefIndex: 84077; 0x000000018417A420-0x000000018417A460

	public delegate bool __HotPatchDelegate_65(object P0, Vector4 P1); // TypeDefIndex: 84078; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate Texture __HotPatchDelegate_66(object P0, object P1); // TypeDefIndex: 84079; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_67(object P0, object P1, EntityVFXRendererMask P2, AddMaterialConfig P3); // TypeDefIndex: 84080; 0x000000018415EC50-0x000000018415EC90

	public delegate List<EntityRenderHelperMaterialController.RendererInfo> __HotPatchDelegate_68(object P0, EntityVFXRendererMask P1, bool P2); // TypeDefIndex: 84081; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_69(object P0, int P1, float P2); // TypeDefIndex: 84082; 0x000000018124EAD0-0x000000018124EAF0

	public delegate float __HotPatchDelegate_70(object P0, int P1, float P2); // TypeDefIndex: 84083; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_71(object P0, int P1, Vector4 P2); // TypeDefIndex: 84084; 0x0000000181499900-0x0000000181499930

	public delegate Vector4 __HotPatchDelegate_72(object P0, int P1, Vector4 P2); // TypeDefIndex: 84085; 0x00000001841608E0-0x0000000184160930

	public delegate void __HotPatchDelegate_73(object P0, int P1, object P2); // TypeDefIndex: 84086; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Texture __HotPatchDelegate_74(object P0, int P1, object P2); // TypeDefIndex: 84087; 0x00000001811DF7F0-0x00000001811DF810

	public delegate EntityVFXRendererMask __HotPatchDelegate_75(object P0, int P1); // TypeDefIndex: 84088; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_76(object P0, int P1, object P2); // TypeDefIndex: 84089; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_77(object P0, int P1, EntityVFXRendererMask P2); // TypeDefIndex: 84090; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_78(object P0, EntityVFXRendererMask P1, object P2); // TypeDefIndex: 84091; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_79(object P0, object P1, bool P2, EntityVFXRendererMask P3); // TypeDefIndex: 84092; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_80(object P0, bool P1, EntityVFXRendererMask P2); // TypeDefIndex: 84093; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_81(object P0, float P1, float P2, int P3); // TypeDefIndex: 84094; 0x00000001812250A0-0x00000001812250C0

	public delegate void __HotPatchDelegate_82(object P0, EntityRenderHelperCustomPerDrawType P1, float P2, EntityVFXRendererMask P3); // TypeDefIndex: 84095; 0x000000018129E8F0-0x000000018129E910

	public delegate void __HotPatchDelegate_83(object P0, EntityRenderHelperVectorCustomPerDrawType P1, Vector4 P2, EntityVFXRendererMask P3); // TypeDefIndex: 84096; 0x0000000184170110-0x0000000184170150

	public delegate void __HotPatchDelegate_84(object P0, int P1, float P2, EntityVFXRendererMask P3); // TypeDefIndex: 84097; 0x000000018129E8F0-0x000000018129E910

	public delegate void __HotPatchDelegate_85(object P0, object P1, EntityVFXRendererMask P2); // TypeDefIndex: 84098; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_86(object P0, int P1, Vector4 P2, EntityVFXRendererMask P3, bool P4); // TypeDefIndex: 84099; 0x0000000181269250-0x00000001812692A0

	public delegate void __HotPatchDelegate_87(object P0, int P1, object P2, EntityVFXRendererMask P3); // TypeDefIndex: 84100; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_88(object P0, out Renderer P1); // TypeDefIndex: 84101; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_89(object P0, float P1); // TypeDefIndex: 84102; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_90(object P0, bool P1, ref bool P2); // TypeDefIndex: 84103; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_91(object P0, out Vector3 P1); // TypeDefIndex: 84104; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_92(object P0, out Bounds P1); // TypeDefIndex: 84105; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_93(object P0, ref Bounds P1); // TypeDefIndex: 84106; 0x00000001859B7730-0x00000001859B7740

	public delegate Bounds __HotPatchDelegate_94(object P0); // TypeDefIndex: 84107; 0x00000001811D4E00-0x00000001811D4E40

	public delegate void __HotPatchDelegate_95(object P0, object P1, bool P2); // TypeDefIndex: 84108; 0x00000001811DF7F0-0x00000001811DF810

	public delegate RenderHelperType __HotPatchDelegate_96(object P0); // TypeDefIndex: 84109; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_97(object P0, object P1, bool P2, out EntityRenderHelperVisibleController.RendererInfo P3); // TypeDefIndex: 84110; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_98(object P0, object P1, bool P2); // TypeDefIndex: 84111; 0x00000001811DF7F0-0x00000001811DF810

	public delegate List<EntityRendererTypeConfig> __HotPatchDelegate_99(object P0, bool P1); // TypeDefIndex: 84112; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_100(object P0, bool P1); // TypeDefIndex: 84113; 0x00000001859B7730-0x00000001859B7740

	public delegate EntityVFXPriorityType __HotPatchDelegate_101(object P0); // TypeDefIndex: 84114; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate EntityVFXRendererMask __HotPatchDelegate_102(object P0); // TypeDefIndex: 84115; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_103(object P0, float P1, bool P2); // TypeDefIndex: 84116; 0x000000018238E680-0x000000018238E6A0

	public delegate Material __HotPatchDelegate_104(object P0, object P1, object P2); // TypeDefIndex: 84117; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_105(object P0, object P1, int P2, float P3); // TypeDefIndex: 84118; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_106(object P0, object P1, int P2, Vector4 P3); // TypeDefIndex: 84119; 0x000000018415EC50-0x000000018415EC90

	public delegate Material __HotPatchDelegate_107(object P0, object P1, Vector4 P2); // TypeDefIndex: 84120; 0x0000000181499900-0x0000000181499930

	public delegate ValueTuple<float, float> __HotPatchDelegate_108(Bounds P0, Vector3 P1); // TypeDefIndex: 84121; 0x000000018416D0A0-0x000000018416D0F0

	public delegate void __HotPatchDelegate_109(object P0, bool P1, Vector3 P2, bool P3, float P4, out float P5, out float P6, out Vector3 P7); // TypeDefIndex: 84122; 0x0000000184E211B0-0x0000000184E21230

	public delegate EntityVFXCurveEvaluateResult __HotPatchDelegate_110(object P0, float P1); // TypeDefIndex: 84123; 0x0000000184E21230-0x0000000184E21280

	public delegate void __HotPatchDelegate_111(object P0, object P1, float P2); // TypeDefIndex: 84124; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_112(object P0, float P1, object P2, object P3); // TypeDefIndex: 84125; 0x00000001812250A0-0x00000001812250C0

	public delegate void __HotPatchDelegate_113(object P0, object P1, object P2, bool P3); // TypeDefIndex: 84126; 0x0000000181217F60-0x0000000181217F80

	public delegate PsoCreateUploadHelper __HotPatchDelegate_114(); // TypeDefIndex: 84127; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_115(object P0, HGPsoExtInfo P1); // TypeDefIndex: 84128; 0x00000001826DF780-0x00000001826DF7C0

	public delegate void __HotPatchDelegate_116(bool P0); // TypeDefIndex: 84129; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_117(object P0, object P1, object P2, object P3); // TypeDefIndex: 84130; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_118(float P0); // TypeDefIndex: 84131; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_119(object P0, in EventData<string, string> P1); // TypeDefIndex: 84132; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_120(bool P0, object P1, object P2); // TypeDefIndex: 84133; 0x00000001811DF7F0-0x00000001811DF810

	public delegate List<Vector3> __HotPatchDelegate_121(object P0, float P1, int P2); // TypeDefIndex: 84134; 0x000000018238E680-0x000000018238E6A0

	public delegate Vector3 __HotPatchDelegate_122(object P0, Vector2Int P1); // TypeDefIndex: 84135; 0x0000000186AEB300-0x0000000186AEB340

	public delegate List<Vector3> __HotPatchDelegate_123(object P0, Vector3 P1); // TypeDefIndex: 84136; 0x0000000186036470-0x00000001860364A0

	public delegate Vector2Int __HotPatchDelegate_124(object P0, Vector3 P1); // TypeDefIndex: 84137; 0x0000000184178290-0x00000001841782C0

	public delegate int __HotPatchDelegate_125(int P0, int P1, int P2); // TypeDefIndex: 84138; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_126(int P0, int P1, int P2, int P3, object P4); // TypeDefIndex: 84139; 0x00000001812083C0-0x00000001812083E0

	public delegate UnityEngine.Color __HotPatchDelegate_127(object P0, int P1, int P2); // TypeDefIndex: 84140; 0x00000001812D51A0-0x00000001812D51E0

	public delegate float[] __HotPatchDelegate_128(int P0, float P1); // TypeDefIndex: 84141; 0x00000001859B7730-0x00000001859B7740

	public delegate float[,] __HotPatchDelegate_129(object P0, object P1, Vector2Int P2); // TypeDefIndex: 84142; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_130(Bounds P0, object P1, out Vector3 P2, out Vector3 P3, Vector3? P4); // TypeDefIndex: 84143; 0x0000000184E21280-0x0000000184E212E0

	public delegate VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __HotPatchDelegate_131(Vector3 P0, Vector3 P1); // TypeDefIndex: 84144; 0x0000000184E212E0-0x0000000184E21360

	public delegate VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __HotPatchDelegate_132(Vector3 P0, float P1); // TypeDefIndex: 84145; 0x0000000184E21360-0x0000000184E213C0

	public delegate List<Vector3> __HotPatchDelegate_133(object P0, float P1, int P2, bool P3, float P4); // TypeDefIndex: 84146; 0x000000018415ECF0-0x000000018415ED10

	public delegate Vector3 __HotPatchDelegate_134(ref VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P0, Vector3 P1); // TypeDefIndex: 84147; 0x00000001826E9AE0-0x00000001826E9B40

	public delegate void __HotPatchDelegate_135(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, out List<Vector2> P2, out List<float> P3, out float P4, out float P5, out float P6, out float P7); // TypeDefIndex: 84148; 0x0000000184E213C0-0x0000000184E21440

	public delegate List<int> __HotPatchDelegate_136(object P0); // TypeDefIndex: 84149; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_137(object P0, int P1, bool P2); // TypeDefIndex: 84150; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_138(Vector2 P0, Vector2 P1, Vector2 P2); // TypeDefIndex: 84151; 0x00000001811DF7F0-0x00000001811DF810

	public delegate List<int> __HotPatchDelegate_139(object P0, bool P1, float P2, float P3, float P4); // TypeDefIndex: 84152; 0x00000001811DB3F0-0x00000001811DB410

	public delegate VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult __HotPatchDelegate_140(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, float P2, int P3, bool P4, VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode P5, float P6, float P7, float P8); // TypeDefIndex: 84153; 0x0000000184E21440-0x0000000184E214E0

	public delegate List<Vector2> __HotPatchDelegate_141(object P0, float P1, int P2, int P3, bool P4, bool P5); // TypeDefIndex: 84154; 0x000000018417F700-0x000000018417F730

	public delegate List<Vector3> __HotPatchDelegate_142(object P0, float P1, float P2, bool P3); // TypeDefIndex: 84155; 0x00000001826DFD20-0x00000001826DFD40

	public delegate void __HotPatchDelegate_143(object P0, ref List<Vector2> P1, int P2, bool P3, bool P4, bool P5); // TypeDefIndex: 84156; 0x00000001812864A0-0x00000001812864D0

	public delegate List<Vector3> __HotPatchDelegate_144(object P0, object P1, float P2); // TypeDefIndex: 84157; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_145(object P0, object P1, object P2, object P3, int P4); // TypeDefIndex: 84158; 0x00000001812083C0-0x00000001812083E0

	public delegate HGAddedMaterialController.OverlayLayer __HotPatchDelegate_146(object P0); // TypeDefIndex: 84159; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_147(object P0, object P1); // TypeDefIndex: 84160; 0x00000001859B7730-0x00000001859B7740

	public delegate HGMeshRendererData __HotPatchDelegate_148(object P0); // TypeDefIndex: 84161; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_149(object P0, object P1, object P2, object P3, object P4, object P5); // TypeDefIndex: 84162; 0x0000000181256340-0x0000000181256360

	public delegate void __HotPatchDelegate_150(object P0, object P1, object P2, object P3, object P4); // TypeDefIndex: 84163; 0x00000001812083C0-0x00000001812083E0

	public delegate Material __HotPatchDelegate_151(object P0, int P1); // TypeDefIndex: 84164; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_152(object P0, int P1, Vector4 P2, bool P3); // TypeDefIndex: 84165; 0x00000001812674E0-0x0000000181267520

	public delegate HGMeshRenderer __HotPatchDelegate_153(object P0); // TypeDefIndex: 84166; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Bounds __HotPatchDelegate_154(Bounds P0, Matrix4x4 P1); // TypeDefIndex: 84167; 0x0000000184902590-0x0000000184902620
}
