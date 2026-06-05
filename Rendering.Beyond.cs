/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Beyond;
using Beyond.PoolCore;
using Beyond.Rendering;
using Beyond.Resource;
using HG.Rendering.Runtime;
using IFix.Core;
using Microsoft.Win32.SafeHandles;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;
using UnityEngine.Splines;
using UnityEngine.UI;

// Image 38: Rendering.Beyond.dll - Assembly: Rendering.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56215-56356

public class LDstaticObjectLightmappingDataLoader : MonoBehaviour // TypeDefIndex: 56216
{
	// Fields
	public bool test; // 0x18
	public bool recover; // 0x19
	public Renderer[] ldLightmappedRenderer; // 0x20
	public int[] ldLightmappedRendererLightmapIndex; // 0x28
	public Vector4[] ldLightmappedRendererLightmapUvScale; // 0x30

	// Constructors
	public LDstaticObjectLightmappingDataLoader() {} // 0x000000018646DB20-0x000000018646DB28

	// Methods
	public void RecoverLightmapdata() {} // 0x000000018B4F10D8-0x000000018B4F126C
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 56352
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_20 _7848C87B1819709EC2A0D678BCD530B3C49CA3BB2F61B8FCEF827B64DE251E15; // 0x00 // Static value (base64): mpkZPs3MTD6amZk+zcxMPpqZGT4= - Metadata: 0x0207C544

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 56351
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond.Rendering
{
	public class CustomPerDrawDataChannelUtils // TypeDefIndex: 56225
	{
		// Fields
		public const int HOUDINI_VAT_INDEX = 3; // Metadata: 0x0207C2D4
		public const int HOUDINI_VAT_CHANNEL = 0; // Metadata: 0x0207C2D5
		public const int LIT_EMISSIVE_INDEX = 2; // Metadata: 0x0207C2D6
		public const int LIT_EMISSIVE_ANIMATION_SWEEP_INDEX = 3; // Metadata: 0x0207C2D7
		public const int LIT_EMISSIVE_ALBEDO_INDEX = 4; // Metadata: 0x0207C2D8
		public const int UV_ANIMATION_INDEX = 3; // Metadata: 0x0207C2D9
		public const int MOVING_BAMBOO_CUR_PARAM_INDEX = 2; // Metadata: 0x0207C2DA
		public const int MOVING_BAMBOO_LAST_PARAM_INDEX = 3; // Metadata: 0x0207C2DB
		public const int LIT_DISSOLVE_INDEX = 4; // Metadata: 0x0207C2DC
		public const int LIT_DISSOLVE_CHANNEL = 0; // Metadata: 0x0207C2DD
		public const int CHARACTER_PARAMS_INDEX = 2; // Metadata: 0x0207C2DE
		public const int CHARACTER_ENVIRONMENT_EFFECT_INTENSITY_CHANNEL = 0; // Metadata: 0x0207C2DF
		public const int CHARACTER_WET_EFFECT_WORLD_SPACE_HEIGHT_CHANNEL = 1; // Metadata: 0x0207C2E0
		public const int CHARACTER_DISSOLVE_SCHEDULE_OFFSET_CHANNEL = 3; // Metadata: 0x0207C2E1
		public const int CHARACTER_RAIN_EFFECT_INTENSITY_CHANNEL_BIT = 8; // Metadata: 0x0207C2E2
		public const int CHARACTER_WET_EFFECT_INTENSITY_CHANNEL_BIT = 16; // Metadata: 0x0207C2E3
		public const int CHARACTER_WET_EFFECT_GLOBAL_INTENSITY_CHANNEL_BIT = 24; // Metadata: 0x0207C2E4
		public const int CHARACTER_SNOW_EFFECT_INTENSITY_CHANNEL_BIT = 32; // Metadata: 0x0207C2E5
		public const int CHARACTER_PARAMS_CHANNEL_BIT_BIAS = 8; // Metadata: 0x0207C2E6
		public const int CHANNELS_PER_PARAM = 4; // Metadata: 0x0207C2E7
		public const int VFX_ALPHA_INDEX = 4; // Metadata: 0x0207C2E8
		public const int VFX_ALPHA_DEFAULT_CHANNEL = 0; // Metadata: 0x0207C2E9
	
		// Constructors
		public CustomPerDrawDataChannelUtils() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void SetPerDrawData_LitDissolve(Renderer affectRenderer, float dissolve) {} // 0x000000018B4EEEE8-0x000000018B4EEF80
		public static void SetPerDrawData_HoudiniVAT(Renderer affectRenderer, int displayFrame) {} // 0x000000018B4EEE4C-0x000000018B4EEEE8
		public static void SetPerDrawData_MovingBamboo(Renderer affectRenderer, Vector4 curParam, Vector4 lastParam) {} // 0x000000018B4EEF80-0x000000018B4EF040
		public static void SetPerDrawData_EmissiveColor(Renderer affectRenderer, Vector4 emissive) {} // 0x00000001851225C0-0x0000000185122630
		public static void SetPerDrawData_EmissiveAlbedoColor(Renderer affectRenderer, Vector4 emissiveAlbedo) {} // 0x0000000185122630-0x00000001851226A0
		public static void SetPerDrawData_SweepLightIntensity(Renderer affectRenderer, float intensity) {} // 0x00000001853E2900-0x00000001853E2980
		public static void SetPerDrawData_UVAnimation(Renderer affectRenderer, float animationEnable, float customAddTime) {} // 0x000000018B4EF040-0x000000018B4EF0F0
		public static void SetPerDrawData_CharacterParams(Renderer affectRenderer, Vector4 param0) {} // 0x000000018421EEE0-0x000000018421EFA0
		public static void SetPerDrawData_VFXAlpha0(Renderer affectRenderer, float alpha) {} // 0x000000018B4EF0F0-0x000000018B4EF194
	}

	public static class PipelineSettingHelper // TypeDefIndex: 56226
	{
		// Fields
		public const string SETTING_FOLDER = "Settings/"; // Metadata: 0x0207C2EA
		public const string SETTING_FILE_LIST = "SettingFiles.txt"; // Metadata: 0x0207C2F4
	
		// Methods
		public static void LoadPipelineSettings() {} // 0x0000000184F1A2F0-0x0000000184F1CB80
		private static string _LoadSetting(string settingName) => default; // 0x0000000184579FC0-0x000000018457A4E0
		private static string _GetFullSettingPath(string settingName) => default; // 0x0000000184F1A240-0x0000000184F1A2F0
	}

	public static class ResourceRouter // TypeDefIndex: 56227
	{
		// Fields
		private const string DYNAMIC_ENVIRONMENTS_FOLDER = "Gameplay/Environments/"; // Metadata: 0x0207C309
	
		// Methods
		private static string _GetCategoryFolder(RootCategory category) => default; // 0x000000018B4F1414-0x000000018B4F149C
		public static string GetEnvironmentsFullPath(RootCategory category = RootCategory.Main /* Metadata: 0x0207C305 */, bool isDevOnly = false /* Metadata: 0x0207C306 */) => default; // 0x000000018B4F1370-0x000000018B4F1414
		public static string GetDecalResourcesPath() => default; // 0x000000018B4F1310-0x000000018B4F1370
		public static string GetDecalResourcesFullPath(RootCategory category = RootCategory.Main /* Metadata: 0x0207C307 */, bool isDevOnly = false /* Metadata: 0x0207C308 */) => default; // 0x000000018B4F126C-0x000000018B4F1310
	}

	public class ShaderWarmupManager // TypeDefIndex: 56235
	{
		// Fields
		public static readonly string RUNTIME_PSO_COLLECTION_FOLDER; // 0x00
		private const string WARM_UP_KEY_WORD = "hg_warm_up_once"; // Metadata: 0x0207C320
		private const string WARM_UP_API_KEY_WORD = "hg_warm_up_graphics"; // Metadata: 0x0207C330
		private const string WARM_UP_DRIVER_KEY_WORD = "hg_warm_up_graphics_drivers"; // Metadata: 0x0207C344
		private const string WARM_UP_REASON_KEY_WORD = "hg_warm_up_reason"; // Metadata: 0x0207C360
		private const string WARMUP_RETRY_COUNT = "hg_warmup_retry_count"; // Metadata: 0x0207C372
		private const string WARMUP_UNFINISHED_COUNT = "hg_warmup_unfinished_count"; // Metadata: 0x0207C388
		private const string FEATURE_RAYTRACING = "raytracing"; // Metadata: 0x0207C3A3
		private const string FEATURE_ONE_PASS = "onepass"; // Metadata: 0x0207C3AE
		private const int SHADER_COMPILE_WEIGHT = 2; // Metadata: 0x0207C3B6
		public static readonly int UNFINISHED_RETRY_COUNT_LIMIT; // 0x08
		public static readonly int CACHE_FAILED_RETRY_COUNT_LIMIT; // 0x0C
		public static bool s_shouldUseOverride; // 0x10
		public static bool s_needWarmupOverride; // 0x11
		public static int s_forceLoginWarmupStartIndex; // 0x14
		public static int s_forceLoginWarmupCount; // 0x18
		public static int s_forceSceneWarmupStartIndex; // 0x1C
		public static int s_forceSceneWarmupCount; // 0x20
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
		public static long s_cacheSizeRecompileThreshold; // 0x58
		public static int s_warmupCountPerWorkerMainJobCompile; // 0x60
		public static int s_warmupCountPerStepBackJobCompile; // 0x64
		public static int s_warmupCountPerStepMainJob; // 0x68
		public static int s_warmupCountPerStepBackJob; // 0x6C
		public static int s_warmupCountPerStepBackDispatchLimit; // 0x70
		public static int s_warmupCountToClean; // 0x74
		public static int s_warmupTimeLimitMobile; // 0x78
		public static int s_warmupTimeLimitPC; // 0x7C
		public static string s_vulkanCacheFileName; // 0x80
		public static string s_iosCacheFileName; // 0x88
	
		// Properties
		public static bool isWarming { get => default; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 
	
		// Nested types
		public enum WarmUpReason // TypeDefIndex: 56228
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
	
		private class TimeCostCounter // TypeDefIndex: 56229
		{
			// Fields
			private const float MAX_DELTA_TIME = 5f; // Metadata: 0x0207C3C5
			private const float MAX_DELTA_TIME_FIX = 1f; // Metadata: 0x0207C3C9
			private float _duration_k__BackingField; // 0x10
			private float m_lastRealTime; // 0x14
			private float m_maxDurationSecond; // 0x18
	
			// Properties
			public float duration { get; set; } // 0x0000000185195F90-0x0000000185195FF0 0x000000018B4F1B50-0x000000018B4F1C28
			public bool isTimeOut { get => default; } // 0x000000018B4F1A64-0x000000018B4F1B50 
	
			// Constructors
			public TimeCostCounter() {} // Dummy constructor
			public TimeCostCounter(float maxDurationMilliSecond) {} // 0x000000018B4F1C28-0x000000018B4F1CF8
	
			// Methods
			public void Begin() {} // 0x0000000184E75060-0x0000000184E75110
			public void Tick() {} // 0x000000018B4F1FB4-0x000000018B4F20FC
		}
	
		private sealed class _WarmupShadersLogin_d__57 : IEnumerator<object> // TypeDefIndex: 56230
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4F1A08-0x000000018B4F1A64 
			object IEnumerator.Current { get => default; } // 0x0000000183E66520-0x0000000183E66B60 
	
			// Constructors
			public _WarmupShadersLogin_d__57() {} // Dummy constructor
			public _WarmupShadersLogin_d__57(int __1__state) {} // 0x000000018584F2B0-0x000000018584FBD0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4F1CF8-0x000000018B4F1D88
			private bool MoveNext() => default; // 0x000000018B4F1D88-0x000000018B4F1E00
			void IEnumerator.Reset() {} // 0x000000018B4F22BC-0x000000018B4F2364
		}
	
		private sealed class __LoadPsoAssets_d__58 : IEnumerator<object> // TypeDefIndex: 56231
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public List<StringPathHash> resPathList; // 0x20
			public List<FAssetProxyHandle> assetProxyHandles; // 0x28
			public List<HGPsoWarmupCollection> loadedAssets; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4F21F8-0x000000018B4F22BC 
			object IEnumerator.Current { get => default; } // 0x000000018B4F1E00-0x000000018B4F1EB0 
	
			// Constructors
			public __LoadPsoAssets_d__58() {} // Dummy constructor
			public __LoadPsoAssets_d__58(int __1__state) {} // 0x0000000183E686B0-0x0000000183E69810
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018584EFA0-0x000000018584F100
			private bool MoveNext() => default; // 0x000000018B4F1EB0-0x000000018B4F1F28
			void IEnumerator.Reset() {} // 0x000000018B4F1F28-0x000000018B4F1FB4
		}
	
		private sealed class _WarmupShadersScene_d__59 : IEnumerator<object> // TypeDefIndex: 56232
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string scene; // 0x20
			private string _path_5__2; // 0x28
			private FAssetProxyHandle _assetHandle_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018584FE50-0x0000000185851DF0 
			object IEnumerator.Current { get => default; } // 0x0000000185851DF0-0x0000000185851EF0 
	
			// Constructors
			public _WarmupShadersScene_d__59() {} // Dummy constructor
			public _WarmupShadersScene_d__59(int __1__state) {} // 0x000000018B4F25F8-0x000000018B4F26C8
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4F2514-0x000000018B4F25F8
			private bool MoveNext() => default; // 0x000000018525C1C0-0x000000018525C290
			void IEnumerator.Reset() {} // 0x000000018525BFE0-0x000000018525C110
		}
	
		private sealed class _WarmupOnePso_d__60 : IEnumerator<object> // TypeDefIndex: 56233
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public HGPsoWarmupCollection psoC; // 0x20
			public int startIndex; // 0x28
			public int warmupCount; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000183E66B60-0x0000000183E679D0 
			object IEnumerator.Current { get => default; } // 0x000000018584F170-0x000000018584F1F0 
	
			// Constructors
			public _WarmupOnePso_d__60() {} // Dummy constructor
			public _WarmupOnePso_d__60(int __1__state) {} // 0x000000018B4F2424-0x000000018B4F249C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4F249C-0x000000018B4F2514
			private bool MoveNext() => default; // 0x000000018B4F2364-0x000000018B4F2424
			void IEnumerator.Reset() {} // 0x0000000183E679D0-0x0000000183E686B0
		}
	
		private sealed class __WarmupOnePsoTimeLimited_d__61 : IEnumerator<object> // TypeDefIndex: 56234
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public HGPsoWarmupCollection psoC; // 0x20
			public int desiredWarmupCount; // 0x28
			public TimeCostCounter timeStart; // 0x30
			public int startIndex; // 0x38
			private int _warmupCountPerStepMainJobCompile_5__2; // 0x3C
			private int _totalCount_5__3; // 0x40
			private int _compileTotalCount_5__4; // 0x44
			private int _countToCleanUp_5__5; // 0x48
			private int _backJobLastLeftCount_5__6; // 0x4C
			private int _leftBackJobCount_5__7; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B4F20FC-0x000000018B4F2170 
			object IEnumerator.Current { get => default; } // 0x0000000185B59FF0-0x0000000185B5AEA0 
	
			// Constructors
			public __WarmupOnePsoTimeLimited_d__61() {} // Dummy constructor
			public __WarmupOnePsoTimeLimited_d__61(int __1__state) {} // 0x000000018584F100-0x000000018584F170
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B4F2170-0x000000018B4F21F8
			private bool MoveNext() => default; // 0x000000018584F1F0-0x000000018584F2B0
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public ShaderWarmupManager() {} // 0x0000000183E73F50-0x0000000183E73FA0
		static ShaderWarmupManager() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static string GetPsoName(RuntimePlatform platform, GraphicsDeviceType graphicsDeviceType, int shaderLod, string levelId) => default; // 0x0000000181A6E380-0x0000000181A6E390
		public static string GetPsoName(RuntimePlatform platform, GraphicsDeviceType graphicsDeviceType, int shaderLod, string levelId, string feature) => default; // 0x000000018B4F27A8-0x000000018B4F2B38
		public static string GetPsoPath(string psoName) => default; // 0x000000018B4F2794-0x000000018B4F27A8
		public static string GetLoginWarmupDetail() => default; // 0x000000018B4F26C8-0x000000018B4F2720
		private static long _GetCacheFileSize() => default; // 0x000000018B4F2720-0x000000018B4F2794
		public static void ProcessRemoteConfig(string remoteConfigStr) {} // 0x0000000181378230-0x0000000181378240
		public static void MarkNeedShaderWarmUp(WarmUpReason reason) {} // 0x0000000185492010-0x0000000185492020
		public static void MarkWarmUpLoginFinish() {} // 0x0000000183E6A8E0-0x0000000183E6E200
		public static void CleanLoadedPso() {} // 0x0000000181377E40-0x0000000181377E50
		private static void _MarkWarmUpLoginFinish() {} // 0x0000000183E6E200-0x0000000183E6E250
		public static void TryRepairPsoCacheAfterCorruptCheck() {} // 0x0000000181377E40-0x0000000181377E50
		private static bool _TryDeleteVulkanPsoCacheFile() => default; // 0x0000000181378230-0x0000000181378240
		public static bool CheckNeedWarmUpLogin() => default; // 0x0000000185492010-0x0000000185492020
		public static IEnumerator WarmupShadersLogin(bool supportsRaytracing) => default; // 0x0000000183E704C0-0x0000000183E72540
		private static IEnumerator _LoadPsoAssets(List<StringPathHash> resPathList, List<FAssetProxyHandle> assetProxyHandles, List<HGPsoWarmupCollection> loadedAssets) => default; // 0x0000000181377E40-0x0000000181377E50
		public static IEnumerator WarmupShadersScene(string scene) => default; // 0x0000000183E72540-0x0000000183E72590
		public static IEnumerator WarmupOnePso(HGPsoWarmupCollection psoC, int startIndex, int warmupCount) => default; // 0x0000000181377E40-0x0000000181377E50
		private static IEnumerator _WarmupOnePsoTimeLimited(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount, TimeCostCounter timeStart) => default; // 0x0000000181378230-0x0000000181378240
		private static void _StepProgress(int newFinishedCount, ref int compileTotalCount) {} // 0x0000000185492010-0x0000000185492020
		private static bool _CheckNeedWarmUpByFirstEntry() => default; // 0x0000000183E6E250-0x0000000183E70470
		private static bool _CheckNeedWarmUpByDeviceState() => default; // 0x0000000181377E40-0x0000000181377E50
		private static bool _IsNeedWarmupByGraphicsChange() => default; // 0x0000000183E70470-0x0000000183E704C0
		private static bool _IsNeedWarmupByCacheOutdated() => default; // 0x0000000181377E40-0x0000000181377E50
		private static void _SetWarmupRetryCount(int count) {} // 0x0000000181378230-0x0000000181378240
		private static void _SetWarmupUnfinishedCount(int count) {} // 0x0000000185492010-0x0000000185492020
		private static void _MarkWarmupFinishAPI() {} // 0x0000000183E69BB0-0x0000000183E6A890
		private static bool _IsNeedWarmupDx11Driver() => default; // 0x0000000181377E40-0x0000000181377E50
		private static void _MarkWarmupDx11Driver() {} // 0x0000000183E6A890-0x0000000183E6A8E0
		private static void _ResetWarmUpStats() {} // 0x0000000181377E40-0x0000000181377E50
		private static bool _IsDeviceSupportWarmUp() => default; // 0x0000000181378230-0x0000000181378240
		private static bool _IsFeatureEnabled(string featureKeyword) => default; // 0x0000000185492010-0x0000000185492020
		private static bool _CheckWarmUpUnfinishedOften() => default; // 0x0000000183E72590-0x0000000183E73F50
		private static int _GetLoginTimeLimit() => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class ShaderWarmupManagerRemoteCfg // TypeDefIndex: 56239
	{
		// Fields
		private ShaderWarmupRemoteBlacklist m_blacklist; // 0x10
	
		// Properties
		private static string cpuNameForWarmUp { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		[Serializable]
		private class ShaderWarmupRemoteBlackDevice // TypeDefIndex: 56236
		{
			// Fields
			public string deviceModel; // 0x10
			public string graphicsDeviceName; // 0x18
			public string graphicsDeviceVersion; // 0x20
			public string os; // 0x28
			public string cpuName; // 0x30
			public string disableFeature; // 0x38
	
			// Constructors
			public ShaderWarmupRemoteBlackDevice() {} // 0x000000018584FBD0-0x000000018584FC40
		}
	
		[Serializable]
		private class ShaderWarmupGlobalConfig // TypeDefIndex: 56237
		{
			// Fields
			public bool disableDriverVerDetect; // 0x10
	
			// Constructors
			public ShaderWarmupGlobalConfig() {} // 0x0000000183E659B0-0x0000000183E66520
		}
	
		[Serializable]
		private class ShaderWarmupRemoteBlacklist // TypeDefIndex: 56238
		{
			// Fields
			public List<ShaderWarmupRemoteBlackDevice> devices; // 0x10
			public ShaderWarmupGlobalConfig config; // 0x18
	
			// Constructors
			public ShaderWarmupRemoteBlacklist() {} // 0x000000018584FC40-0x000000018584FE50
		}
	
		// Constructors
		public ShaderWarmupManagerRemoteCfg() {} // Dummy constructor
		public ShaderWarmupManagerRemoteCfg(string blackListStr) {} // 0x000000018646D4CC-0x000000018646D4D8
	
		// Methods
		public bool IsEnableDx11DriverVersionDetect() => default; // 0x000000018B4F1774-0x000000018B4F1A08
		public bool IsDeviceInBlackList(out string disabledFeature) {
			disabledFeature = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		private static bool _CheckDeviceMatch(ShaderWarmupRemoteBlackDevice blacklistDevice, string currentDeviceModel, string currentGraphicsDeviceName, string currentGraphicsDeviceVersion, string currentProcessorType, string currentOS) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class WindowsGpuDriverVersion // TypeDefIndex: 56245
	{
		// Fields
		private static readonly Guid GUID_DEVCLASS_DISPLAY; // 0x00
		private const uint DIGCF_PRESENT = 2; // Metadata: 0x0207C3CD
		private const uint SPDRP_DEVICEDESC = 0; // Metadata: 0x0207C3CE
		private const uint SPDRP_MFG = 11; // Metadata: 0x0207C3CF
		private const uint SPDRP_FRIENDLYNAME = 12; // Metadata: 0x0207C3D0
		private const uint SPDRP_DRIVER = 9; // Metadata: 0x0207C3D1
		private const uint DICS_FLAG_GLOBAL = 1; // Metadata: 0x0207C3D2
		private const uint DIREG_DRV = 2; // Metadata: 0x0207C3D3
		private static readonly IntPtr INVALID_HANDLE_VALUE; // 0x10
		private const int ERROR_SUCCESS = 0; // Metadata: 0x0207C3D4
		private const int ERROR_NO_MORE_ITEMS = 259; // Metadata: 0x0207C3D5
		private const int ERROR_INSUFFICIENT_BUFFER = 122; // Metadata: 0x0207C3D7
		private const int ERROR_MORE_DATA = 234; // Metadata: 0x0207C3D9
		private const uint REG_SZ = 1; // Metadata: 0x0207C3DB
		private const uint REG_EXPAND_SZ = 2; // Metadata: 0x0207C3DC
	
		// Nested types
		public sealed class Result // TypeDefIndex: 56240
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
			public Result() {} // 0x0000000183E75F60-0x0000000183E77460
	
			// Methods
			public override string ToString() => default; // 0x0000000183E77460-0x0000000183E77D30
			public string __iFixBaseProxy_ToString() => default; // 0x0000000183E73FA0-0x0000000183E75F60
		}
	
		private sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 56241
		{
			// Constructors
			internal SafeRegistryHandle() {} // 0x0000000183E78C10-0x0000000183E79CD0
			internal SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle) {} // 0x0000000183E785E0-0x0000000183E78C10
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000183E77D30-0x0000000183E78400
		}
	
		private enum RegistryRights // TypeDefIndex: 56242
		{
			KEY_QUERY_VALUE = 1
		}
	
		private struct SP_DEVINFO_DATA // TypeDefIndex: 56243
		{
			// Fields
			public uint cbSize; // 0x00
			public Guid classGuid; // 0x04
			public uint devInst; // 0x14
			public IntPtr reserved; // 0x18
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56244
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Result> __9__18_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000183E7EAC0-0x0000000183E7F210
			public __c() {} // 0x0000000183E7D890-0x0000000183E7EAC0
	
			// Methods
			internal int _GetAllDisplayDriverVersions_b__18_0(Result a, Result b) => default; // 0x0000000183E7A6F0-0x0000000183E7B130
		}
	
		// Constructors
		static WindowsGpuDriverVersion() {} // 0x0000000183E69810-0x0000000183E69850
	
		// Methods
		public static string GetCurrentDriverVersion() => default; // 0x0000000183E7B130-0x0000000183E7C240
		public static Result GetBestMatch() => default; // 0x0000000183E7C240-0x0000000183E7C8A0
		public static List<Result> GetAllDisplayDriverVersions() => default; // 0x0000000183E7C8A0-0x0000000183E7D890
		public static string SerializeAllResults(List<Result> results) => default; // 0x0000000183E78400-0x0000000183E78480
		public static string SerializeAllCurrentResults() => default; // 0x0000000183E79E40-0x0000000183E79F30
		public static bool IsBestMatchDriverVersionChanged(string serialized) => default; // 0x0000000183E79D60-0x0000000183E79E40
		private static bool _TryGetDriverVersionByKeyId(string serialized, string keyId, out string driverVersion) {
			driverVersion = default;
			return default;
		} // 0x0000000183E79F30-0x0000000183E7A040
		private static int _ScoreAgainstUnityCurrentGpu(string friendlyName, string deviceDesc, string mfg) => default; // 0x0000000183E7A040-0x0000000183E7A6F0
		private static bool _ContainsIgnoreCase(string a, string b) => default; // 0x0000000183E79CD0-0x0000000183E79D60
		private static string _GetDeviceRegistryPropertyString(IntPtr infoSet, ref SP_DEVINFO_DATA devInfo, uint prop) => default; // 0x0000000183E78480-0x0000000183E785E0
		private static string _GetDriverKeySuffix(string driverKey) => default; // 0x0000000183E7F210-0x0000000183E7FF50
		private static string _ReadRegistrySz(SafeRegistryHandle hKey, string valueName) => default; // 0x0000000183E64050-0x0000000183E65010
		private static extern int RegCloseKey(IntPtr hKey); // 0x0000000185492010-0x0000000185492020
		private static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, IntPtr enumerator, IntPtr hwndParent, uint flags); // 0x00000001831D66C0-0x00000001831D66F0
		private static extern bool SetupDiEnumDeviceInfo(IntPtr deviceInfoSet, uint memberIndex, ref SP_DEVINFO_DATA deviceInfoData); // 0x0000000183E656B0-0x0000000183E659B0
		private static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint property, out uint propertyRegDataType, IntPtr propertyBuffer, uint propertyBufferSize, out uint requiredSize); // 0x000000018646E620-0x000000018646E64C
		private static extern SafeRegistryHandle SetupDiOpenDevRegKey(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint scope, uint hwProfile, uint keyType, int samDesired); // 0x0000000183E65010-0x0000000183E656B0
		private static extern bool SetupDiDestroyDeviceInfoList(IntPtr deviceInfoSet); // 0x0000000183E69850-0x0000000183E69BB0
		private static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, IntPtr lpReserved, out uint lpType, IntPtr lpData, ref uint lpcbData); // 0x0000000185492010-0x0000000185492020
	}

	public static class SOCHelper // TypeDefIndex: 56246
	{
		// Fields
		public static readonly int CHUNK_SIZE; // 0x00
		public const string SOC_FOLDER_NAME = "OcclusionCulling"; // Metadata: 0x0207C3DE
		public const string SOC_INTERMEDIATE_FILE_NAME = "[x]HGSOCChunkData.asset"; // Metadata: 0x0207C3EF
	
		// Constructors
		static SOCHelper() {} // 0x000000018B4F149C-0x000000018B4F14D8
	}

	[Serializable]
	public struct SceneStateAreaKey : IEquatable<SceneStateAreaKey> // TypeDefIndex: 56247
	{
		// Fields
		public uint sceneStateMask; // 0x00
		public int areaId; // 0x04
		public static readonly SceneStateAreaKey DEFAULT; // 0x00
	
		// Constructors
		public SceneStateAreaKey(uint sceneStateMask, int areaId) {
			this.sceneStateMask = default;
			this.areaId = default;
		} // 0x000000018357CB90-0x000000018357CBA0
		static SceneStateAreaKey() {
			DEFAULT = default;
		} // 0x000000018B4F1730-0x000000018B4F1774
	
		// Methods
		public bool Equals(SceneStateAreaKey other) => default; // 0x000000018B4F14D8-0x000000018B4F1540
		public override bool Equals(object obj) => default; // 0x000000018B4F1540-0x000000018B4F15E8
		public override int GetHashCode() => default; // 0x000000018B4F15E8-0x000000018B4F1680
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018B4F1680-0x000000018B4F16E0
		public int __iFixBaseProxy_GetHashCode() => default; // 0x000000018B4F16E0-0x000000018B4F1730
	}

	public class HGSOCSubSceneData : ScriptableObject // TypeDefIndex: 56250
	{
		// Fields
		public SceneStateAreaKey[] keyArray; // 0x18
		public SubSceneDataPerSceneStateArea[] dataArray; // 0x20
	
		// Nested types
		[Serializable]
		public struct ChunkData // TypeDefIndex: 56248
		{
			// Fields
			public Vector3[] centers; // 0x00
			public Vector3[] extents; // 0x08
			public Vector3[] vertexData; // 0x10
			public float[] areas; // 0x18
		}
	
		[Serializable]
		public struct SubSceneDataPerSceneStateArea // TypeDefIndex: 56249
		{
			// Fields
			public Vector2Int[] chunkCoords; // 0x00
			public ChunkData[] chunkDataArray; // 0x08
		}
	
		// Constructors
		public HGSOCSubSceneData() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	public class HGSOCDataHelper : MonoBehaviour // TypeDefIndex: 56251
	{
		// Fields
		public float fallOffStrength; // 0x18
		public float innerBlendWeight; // 0x1C
		private bool _displayQuadOccluders_k__BackingField; // 0x20
		private bool _displayHGOccluders_k__BackingField; // 0x21
		[NonSerialized]
		public Material material; // 0x28
		[NonSerialized]
		public HGOccluder[] occluders; // 0x30
	
		// Properties
		public bool displayQuadOccluders { get; set; } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public bool displayHGOccluders { get; set; } // 0x00000001813ECBD0-0x00000001813ECBE0 0x00000001813EE990-0x00000001813EE9A0
	
		// Constructors
		public HGSOCDataHelper() {} // 0x000000018B4F10C0-0x000000018B4F10D8
	}

	public class EntityRenderAlphaDitherController // TypeDefIndex: 56252
	{
		// Fields
		private IRendererHelper m_owner; // 0x10
		private float m_ditherAlpha; // 0x18
		private static int s_CharDitherFade; // 0x00
		private static int s_DitherTransparentAlpha; // 0x04
		private Dictionary<int, float> m_alphaPerHandles; // 0x20
		private bool m_lastSetAllRendererEnabled; // 0x28
	
		// Constructors
		public EntityRenderAlphaDitherController() {} // Dummy constructor
		public EntityRenderAlphaDitherController(IRendererHelper owner) {} // 0x0000000184892420-0x00000001848924C0
		static EntityRenderAlphaDitherController() {} // 0x0000000185F4EFB0-0x0000000185F4F030
	
		// Methods
		public void ResetDitherAlpha() {} // 0x0000000184890D80-0x0000000184890DF0
		public bool SetDitherAlpha(float alpha, int handle) => default; // 0x00000001848907F0-0x0000000184890940
		public float GetDitherAlpha() => default; // 0x0000000184890760-0x00000001848907F0
		public void Reset() {} // 0x00000001855D3890-0x00000001855D38D0
		private bool _ApplyNewAlpha() => default; // 0x0000000184890940-0x0000000184890AA0
		private float _GetCurMinAlpha() => default; // 0x00000001842DC150-0x00000001842DC4A0
		public Dictionary<int, float> GetAlphaDictionary() => default; // 0x0000000184896200-0x0000000184896230
		private void _SetMaterialDitherAlpha(float value) {} // 0x0000000184890AF0-0x0000000184890BB0
		private bool _SetMaterialDitherEnabled(bool enabled) => default; // 0x0000000184890AA0-0x0000000184890AF0
	}

	public class EntityRenderCapturedEntity // TypeDefIndex: 56253
	{
		// Fields
		public GameObject rootGameObject; // 0x10
		public List<MeshRenderer> meshRenderers; // 0x18
		public List<MeshRenderer> capturedRenderers; // 0x20
	
		// Constructors
		public EntityRenderCapturedEntity() {} // 0x000000018B4F05F8-0x000000018B4F06A0
	}

	public class EntityRenderCaptureMeshController // TypeDefIndex: 56256
	{
		// Fields
		private IRendererHelper m_owner; // 0x10
		private GameObject m_gameObject; // 0x18
		private LODGroup m_lodGroup; // 0x20
		private List<EntityRenderCapturedEntity> m_capturedEntities; // 0x28
		private int m_meshRendererToSyncFrame; // 0x30
		private List<MeshRendererToSync> m_meshRendererToSync; // 0x38
	
		// Nested types
		private struct MeshRendererToSync // TypeDefIndex: 56254
		{
			// Fields
			public Transform captureTransform; // 0x00
			public Renderer captureRenderer; // 0x08
			public Transform followTransform; // 0x10
			public Renderer followRenderer; // 0x18
		}
	
		private class CaptureRenderGameObject // TypeDefIndex: 56255
		{
			// Fields
			public GameObject gameObject; // 0x10
			public MeshRenderer meshRenderer; // 0x18
			public MeshFilter meshFilter; // 0x20
	
			// Constructors
			public CaptureRenderGameObject() {} // 0x0000000184892670-0x00000001848927B0
		}
	
		// Constructors
		public EntityRenderCaptureMeshController() {} // Dummy constructor
		public EntityRenderCaptureMeshController(IRendererHelper owner, GameObject gameObject) {} // 0x00000001854DBB90-0x00000001854DBC30
	
		// Methods
		public void Reset() {} // 0x000000018527CB90-0x000000018527CBD0
		public void LateTick() {} // 0x000000018B4EF3B8-0x000000018B4F02FC
		public EntityRenderCapturedEntity Capture(GameObject root) => default; // 0x000000018527CBD0-0x000000018527CF10
		private void _SyncTransformInRenderPipeline() {} // 0x000000018B4F02FC-0x000000018B4F05F8
		public void Release(EntityRenderCapturedEntity mesh) {} // 0x0000000185492010-0x0000000185492020
	}

	public class EntityRendererTypeConfig // TypeDefIndex: 56257
	{
		// Fields
		public bool useRegex; // 0x10
		public string regexString; // 0x18
		public Regex regex; // 0x20
		public EntityVFXRendererType type; // 0x28
	
		// Constructors
		public EntityRendererTypeConfig() {} // 0x0000000185492010-0x0000000185492020
	}

	public class EntityRenderHelperMaterialController // TypeDefIndex: 56265
	{
		// Fields
		private static List<Material> s_cachedMaterialList; // 0x00
		private List<RendererInfo> m_rendererInfos; // 0x10
		private AddedMaterialController m_addedMaterialController; // 0x18
		private MeshMaterialController m_meshMaterialController; // 0x20
		private Dictionary<EntityVFXRendererMask, List<RendererInfo>> m_renderInfoIndexPerMask; // 0x28
		private CustomPerDrawDataController m_customPerDrawDataController; // 0x30
		private static ObjectPool<RendererInfo> s_rendererInfoPool; // 0x08
		private static ObjectPool<List<RendererInfo>> s_rendererInfoListPool; // 0x10
		private static int s_ZTestGBuffer; // 0x18
		private static int s_OutlineZTest; // 0x1C
		private static string s_AlphaBlendOnKeyword; // 0x20
	
		// Nested types
		public class RendererInfo // TypeDefIndex: 56258
		{
			// Fields
			public Renderer renderer; // 0x10
			public EntityVFXRendererMask typeMask; // 0x18
			public int subMeshCount; // 0x1C
			public ShadowCastingMode oriShadowCastingMode; // 0x20
			public RayTracingMode oriRayTracingMode; // 0x24
			public Material[] sourceMaterials; // 0x28
			public bool materialReplacing; // 0x30
			public Material[] replacingMaterials; // 0x38
			public Vector4 customPerDrawData0; // 0x40
	
			// Properties
			public Material[] currentMeshMaterials { get => default; } // 0x0000000183F9A480-0x0000000183F9A970 
	
			// Constructors
			public RendererInfo() {} // 0x0000000184A73410-0x0000000184A73660
		}
	
		public struct AddedMaterialInfo // TypeDefIndex: 56259
		{
			// Fields
			public int handle; // 0x00
			public Material material; // 0x08
			public EntityVFXRendererMask mask; // 0x10
			public AddMaterialConfig config; // 0x18
			public Dictionary<Material, Material> customizeMaterialDict; // 0x28
		}
	
		public struct SourceMaterialCustomizeData // TypeDefIndex: 56260
		{
			// Fields
			public Texture colorTexture; // 0x00
		}
	
		public class AddedMaterialController // TypeDefIndex: 56261
		{
			// Fields
			public const int MAX_ACTIVE_ADDED_MATERIAL = 4; // Metadata: 0x0207C40F
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
			public AddedMaterialController() {} // 0x000000018B4F0D94-0x000000018B4F0E14
	
			// Methods
			public void Init(List<RendererInfo> rendererInfos, EntityCustomizeRendererPropertyConfig customizeRendererPropertyConfig) {} // 0x0000000184A6FD20-0x0000000184A6FEB0
			private void _InitCustomizeRendererProperty() {} // 0x0000000184A71B20-0x0000000184A72210
			public void Reset() {} // 0x0000000184130D30-0x0000000184130E30
			public int RequireAddMaterial(Material material, EntityVFXRendererMask mask, AddMaterialConfig config = default) => default; // 0x0000000184130E30-0x0000000184130FA0
			public EntityVFXRendererMask RequireRemoveMaterial(int handle) => default; // 0x00000001857ECC80-0x00000001857ECE90
			private Material _GetCustomizePropertyMaterial(AddedMaterialInfo addedMaterialInfo, Material material) => default; // 0x000000018B4F0C00-0x000000018B4F0C80
			public void ApplySharedMaterialArray(RendererInfo rendererInfo) {} // 0x000000018B4F0724-0x000000018B4F07A4
			public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result) => default; // 0x000000018B4F0D00-0x000000018B4F0D94
			public void SetAddictiveFloatProperty(int propertyId, float value) {} // 0x000000018B4F0824-0x000000018B4F08E4
			public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x0207C40B */) => default; // 0x000000018B4F0C80-0x000000018B4F0D00
			public void SetAddictiveVectorProperty(int propertyId, Vector4 value) {} // 0x000000018B4F07A4-0x000000018B4F0824
			public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default) => default; // 0x00000001857ECB10-0x00000001857ECC80
			public void SetAddictiveTextureProperty(int propertyId, Texture value) {} // 0x000000018B4F06A0-0x000000018B4F0724
			public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null) => default; // 0x000000018B4F0E14-0x000000018B4F0EAC
		}
	
		public class CustomPerDrawDataController // TypeDefIndex: 56262
		{
			// Fields
			private List<RendererInfo> m_rendererInfos; // 0x10
			private float m_characterEnvironmentEffectPackedValue; // 0x18
	
			// Constructors
			public CustomPerDrawDataController() {} // 0x00000001857ECE90-0x00000001857ED1E0
	
			// Methods
			private float _PackUNorm8ToFloat(float packed, float value, int bitShift) => default; // 0x0000000184603A50-0x0000000184603B20
			public void Init(List<RendererInfo> allRendererInfos) {} // 0x000000018B4F0F40-0x000000018B4F1040
			public void Reset() {} // 0x0000000184A73960-0x0000000184A739D0
			public void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask) {} // 0x0000000184A6FCA0-0x0000000184A6FD20
			public void SetVectorToCustomPerDraw(EntityRenderHelperVectorCustomPerDrawType type, Vector4 value, EntityVFXRendererMask rendererMask) {} // 0x000000018B4F0EAC-0x000000018B4F0F40
		}
	
		public class MeshMaterialGroupData // TypeDefIndex: 56263
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
			public MeshMaterialGroupData() {} // 0x000000018421D940-0x000000018421E1F0
	
			// Methods
			public void CopyFrom(MeshMaterialGroupData src) {} // 0x0000000183F99F40-0x0000000183F9A2C0
			public void Clear() {} // 0x000000018421D1A0-0x000000018421D940
		}
	
		public class MeshMaterialController // TypeDefIndex: 56264
		{
			// Fields
			private List<MeshMaterialGroupData> m_meshMaterialDatas; // 0x10
			private static List<MeshMaterialGroupData> s_cacheMeshMaterialDatas; // 0x00
			private static readonly string VFX_MATERIAL_POSTFIX; // 0x08
	
			// Constructors
			public MeshMaterialController() {} // 0x000000018B4EB4CC-0x000000018B4EB5D8
			static MeshMaterialController() {} // 0x000000018B4EB1F4-0x000000018B4EB2DC
	
			// Methods
			public void Init(List<RendererInfo> allRendererInfos) {} // 0x0000000184132E60-0x0000000184133240
			public void Reset() {} // 0x000000018B4F1040-0x000000018B4F10C0
			public void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask) {} // 0x000000018B4F08E4-0x000000018B4F0C00
			public void SetDepthOnlyPassEnableToAllMaterial(bool enable, EntityVFXRendererMask rendererMask) {} // 0x0000000185492010-0x0000000185492020
			public void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask) {} // 0x0000000185BA8570-0x0000000185BA87A0
			public void ReleaseFloatToAllMaterial(int nameId, EntityVFXRendererMask rendererMask) {} // 0x0000000184A6ED60-0x0000000184A6ED70
			public void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask) {} // 0x0000000185492010-0x0000000185492020
			public void ReleaseVectorToAllMaterial(int nameId, EntityVFXRendererMask rendererMask) {} // 0x00000001858A3E10-0x00000001858A3E80
			public void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask) {} // 0x000000018B4EB76C-0x000000018B4EBA88
			public void ReleaseTextureToAllMaterial(int nameId, EntityVFXRendererMask rendererMask) {} // 0x0000000184A6EBA0-0x0000000184A6EBF0
			private void _CreateReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData) {} // 0x00000001857ED1E0-0x00000001857ED3C0
			private void _CopyReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData) {} // 0x00000001857ED3C0-0x00000001857ED8A0
			private void _ReleaseAllReplaceMaterial(MeshMaterialGroupData groupData) {} // 0x000000018B4EB5D8-0x000000018B4EB76C
			private void _ReplaceSharedMaterial(RendererInfo rendererInfo, Material[] newMaterials) {} // 0x0000000184A6EBF0-0x0000000184A6ED60
			private void _GetAffectGroupData(EntityVFXRendererMask rendererMask, List<MeshMaterialGroupData> result) {} // 0x000000018B4EAD6C-0x000000018B4EB084
			private void _SplitRenderers(int oldStateIndex, EntityVFXRendererMask newMask) {} // 0x000000018B4EB2DC-0x000000018B4EB3D4
			public void SetZTestInMaterial(string shaderName, bool enable) {} // 0x000000018B4EB084-0x000000018B4EB13C
		}
	
		// Constructors
		public EntityRenderHelperMaterialController() {} // 0x0000000185492010-0x0000000185492020
		static EntityRenderHelperMaterialController() {} // 0x0000000185EE9B90-0x0000000185EE9C60
	
		// Methods
		public void Init(List<Renderer> allRenderers, List<EntityRendererTypeConfig> configs, EntityCustomizeRendererPropertyConfig customRendererPropertyConfig) {} // 0x000000018B4EB3D4-0x000000018B4EB4CC
		public void OnRelease() {} // 0x000000018B4EB13C-0x000000018B4EB1F4
		public void Reset() {} // 0x0000000185492010-0x0000000185492020
		public bool IsAllRendererValid() => default; // 0x000000018527F7D0-0x000000018527F890
		public void StopShadowCasting(bool stopRayTracing) {} // 0x0000000185D65860-0x0000000185D658B0
		public virtual void RevertShadowCastingMode() {} // 0x0000000184A6E7A0-0x0000000184A6EB60
		public int AddMaterialToAllRenderer(Material material, EntityVFXRendererMask rendererMask, AddMaterialConfig config = default) => default; // 0x000000018421E1F0-0x000000018421EE40
		public void SetAddictiveFloatProperty(int propertyId, float value) {} // 0x000000018B4EF194-0x000000018B4EF3B8
		public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x0207C407 */) => default; // 0x0000000185492010-0x0000000185492020
		public void SetAddictiveVectorProperty(int propertyId, Vector4 value) {} // 0x0000000184130770-0x00000001841308F0
		public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default) => default; // 0x0000000184A71A60-0x0000000184A71B20
		public void SetAddictiveTextureProperty(int propertyId, Texture value) {} // 0x0000000185492010-0x0000000185492020
		public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null) => default; // 0x0000000184A71910-0x0000000184A71A60
		public void RemoveMaterialFromAllRenderer(int handle) {} // 0x0000000184A70760-0x0000000184A71800
		public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result) => default; // 0x000000018B4F9BEC-0x000000018B4FA334
		public void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask) {} // 0x000000018B4F9254-0x000000018B4F9BEC
		public void SetDepthOnlyPassEnableToAllMaterial(bool enable, EntityVFXRendererMask rendererMask) {} // 0x0000000184A72BC0-0x0000000184A73410
		public void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask) {} // 0x000000018B4F8CB4-0x000000018B4F8E94
		public void SetVectorToCustomPerDraw(EntityRenderHelperVectorCustomPerDrawType type, Vector4 value, EntityVFXRendererMask rendererMask) {} // 0x0000000184A6FEB0-0x0000000184A70760
		public void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask) {} // 0x000000018B4F9074-0x000000018B4F9254
		public void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask) {} // 0x000000018B4FA334-0x000000018B4FA794
		public void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask) {} // 0x000000018B4F8E94-0x000000018B4F9074
		private List<RendererInfo> _GetRenderersOfRendererMask(EntityVFXRendererMask rendererMask, bool affectAll) => default; // 0x0000000184A74E30-0x0000000184A75140
		private int _GetSubMeshCount(Renderer renderer) => default; // 0x000000018B4FABB0-0x000000018B4FAE90
		public void SetManualDitherAlphaValue(float value) {} // 0x0000000184A72210-0x0000000184A72BC0
		public bool SetManualDitherEnable(bool enable) => default; // 0x0000000184A75140-0x0000000184A751E0
		public Bounds GetRendererBounds() => default; // 0x0000000184A71800-0x0000000184A71910
		public void SetZTestInMaterial(string shaderName, bool enable) {} // 0x0000000184130B80-0x0000000184130D30
		public RenderHelperType GetRenderHelperType() => default; // 0x000000018B4FA794-0x000000018B4FABB0
	}

	public enum EntityRenderHelperCustomPerDrawType // TypeDefIndex: 56266
	{
		WetEffectWorldSpaceHeight = 1,
		CharacterDissolveScheduleOffset = 3,
		RainEffectIntensity = 8,
		WetEffectIntensity = 16,
		WetEffectGlobalIntensity = 24,
		SnowEffectIntensity = 32
	}

	public enum EntityRenderHelperVectorCustomPerDrawType // TypeDefIndex: 56267
	{
		Emissive = 1
	}

	public class EntityRenderHelperVisibleController // TypeDefIndex: 56269
	{
		// Fields
		private List<RendererInfo> m_rendererInfos; // 0x10
		private Dictionary<Renderer, RendererInfo> m_dictionary; // 0x18
		private static ObjectPool<List<RendererInfo>> s_rendererInfoListPool; // 0x00
		private static ObjectPool<Dictionary<Renderer, RendererInfo>> s_rendererInfoDictPool; // 0x08
	
		// Nested types
		public class RendererInfo // TypeDefIndex: 56268
		{
			// Fields
			public Renderer renderer; // 0x10
			private string m_rendererName; // 0x18
			public bool oriVisible; // 0x20
			public bool curVisible; // 0x21
	
			// Properties
			public string rendererName { get => default; } // 0x0000000183F9A2C0-0x0000000183F9A480 
	
			// Constructors
			public RendererInfo() {} // 0x000000018B4F3EDC-0x000000018B4F40E4
		}
	
		// Constructors
		public EntityRenderHelperVisibleController() {} // 0x0000000185445410-0x0000000185445470
		static EntityRenderHelperVisibleController() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Init(List<Renderer> allRenderers) {} // 0x0000000184A737F0-0x0000000184A738F0
		private void _InitDictionary() {} // 0x00000001854452E0-0x0000000185445410
		public void Release() {} // 0x000000018B4F3E14-0x000000018B4F3EDC
		public void SetVisibleByNameContainsStr(string name, bool visible) {} // 0x000000018B4F3B60-0x000000018B4F3D44
		public void SetVisibleByRenderer(Renderer renderer, bool visible) {} // 0x000000018B4F3D44-0x000000018B4F3E14
		public void ResetVisibleByNameContainsStr(string name) {} // 0x0000000185096900-0x0000000185096BE0
		public void ResetVisibleByRenderer(Renderer renderer) {} // 0x0000000185492010-0x0000000185492020
		public void Reset() {} // 0x0000000185D64C40-0x0000000185D64D70
	}

	public class EntityRenderMaterialManager // TypeDefIndex: 56270
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
		public EntityRenderMaterialManager() {} // 0x000000018B4F5684-0x000000018B4F58AC
		static EntityRenderMaterialManager() {} // 0x000000018B4F5634-0x000000018B4F5684
	
		// Methods
		public void SetFloat(int nameID, float value) {} // 0x000000018B4F4D44-0x000000018B4F4E3C
		public void SetTexture(int nameID, Texture value) {} // 0x000000018B4F5048-0x000000018B4F5140
		public void SetVector(int nameID, Vector4 value) {} // 0x000000018B4F5140-0x000000018B4F5258
		public void AddMaterial(Material material) {} // 0x000000018B4F40E4-0x000000018B4F4780
		public void RemoveMaterial(Material material) {} // 0x000000018B4F4930-0x000000018B4F49C8
		public void ClearMaterials() {} // 0x000000018B4F4780-0x000000018B4F4930
		public void SetKeywordEnable(string keyword, bool enable) {} // 0x000000018B4F4E3C-0x000000018B4F5048
		public void SetDepthOnlyEnabled(bool enable) {} // 0x000000018B4F49C8-0x000000018B4F4D44
		public void SetZTestInMaterial(string shaderName, bool enable) {} // 0x000000018B4F5258-0x000000018B4F53E4
		private void _RevertMaterial(Material material) {} // 0x000000018B4F53E4-0x000000018B4F5634
	}

	[Serializable]
	public class EntityVFXCurve // TypeDefIndex: 56271
	{
		// Fields
		public AnimationCurve curve; // 0x10
		public Vector2 rangeEdit; // 0x18
		public Vector2 rangeLimit; // 0x20
	
		// Constructors
		public EntityVFXCurve() {} // Dummy constructor
		public EntityVFXCurve(AnimationCurve curve) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public struct EntityVFXCurveEvaluateResult // TypeDefIndex: 56272
	{
		// Fields
		public ShaderPropertyType propertyType; // 0x00
		public string propertyName; // 0x08
		public int propertyId; // 0x10
		public float floatValue; // 0x14
		public Vector4 vectorValue; // 0x18
		public Vector4 textureScaleOffset; // 0x28
	}

	public struct AddMaterialConfig // TypeDefIndex: 56273
	{
		// Fields
		public bool useColorTexture; // 0x00
		public string colorTextureName; // 0x08
	
		// Properties
		public bool useCustomizeProperty { get => default; } // 0x00000001835E3010-0x00000001835E3020 
	}

	[Serializable]
	public class EntityVFXCurveData // TypeDefIndex: 56274
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
		public float colorIntensity; // 0x50
	
		// Constructors
		public EntityVFXCurveData() {} // 0x0000000185F66740-0x0000000185F668A0
	}

	[Serializable]
	public class EntityVFXAddictiveMaterialData // TypeDefIndex: 56275
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
		public float loopDuration; // 0x7C
		public AnimationCurve loopCurve; // 0x80
		public AnimationCurve dissolveLoopCurve; // 0x88
		public List<EntityVFXCurveData> customLoopCurves; // 0x90
		public bool useEndCurve; // 0x98
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
		public EntityVFXAddictiveMaterialData() {} // 0x000000018598A7C0-0x000000018598A810
	}

	public class EntityVFXAddictiveMaterialAsset : EntityVFXAssetBase // TypeDefIndex: 56276
	{
		// Fields
		public EntityVFXAddictiveMaterialData data; // 0x30
	
		// Constructors
		public EntityVFXAddictiveMaterialAsset() {} // 0x0000000185A70430-0x0000000185A70440
	}

	[Serializable]
	public class EntityVFXAfterImageData // TypeDefIndex: 56278
	{
		// Fields
		public bool useScaledTime; // 0x10
		public TimeMode timeMode; // 0x14
		public bool loop; // 0x18
		public float duration; // 0x1C
		public float timeInterval; // 0x20
		public List<float> timeBurst; // 0x28
		public Material depthOnlyMaterial; // 0x30
		public Material material; // 0x38
		public Material materialOutline; // 0x40
		public float lifeTime; // 0x48
		public AnimationCurve opacityCurve; // 0x50
		public AnimationCurve dissolveCurve; // 0x58
		public List<EntityVFXCurveData> customCurves; // 0x60
		public AnimationCurve opacityCurveOutline; // 0x68
		public List<EntityVFXCurveData> customCurvesOutline; // 0x70
	
		// Nested types
		public enum TimeMode // TypeDefIndex: 56277
		{
			Interval = 0,
			Burst = 1
		}
	
		// Constructors
		public EntityVFXAfterImageData() {} // 0x0000000185FA2AF0-0x0000000185FA2B00
	}

	public class EntityVFXAfterImageAsset : EntityVFXAssetBase // TypeDefIndex: 56279
	{
		// Fields
		public EntityVFXAfterImageData data; // 0x30
	
		// Constructors
		public EntityVFXAfterImageAsset() {} // 0x0000000185A70430-0x0000000185A70440
	}

	[Serializable]
	public struct EntityCustomizeRendererType // TypeDefIndex: 56280
	{
		// Fields
		public bool useContainStr; // 0x00
		public string rendererNameRegex; // 0x08
		public EntityVFXRendererType type; // 0x10
	}

	public class EntityVFXAsset : ScriptableObject // TypeDefIndex: 56281
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
		public EntityVFXAsset() {} // 0x0000000185B68C50-0x0000000185B68CE0
	
		// Methods
		public List<EntityRendererTypeConfig> GetRendererTypeConfigs(bool forceUpdate) => default; // 0x000000018549AAC0-0x000000018549AD30
	}

	public enum EntityVFXRendererType // TypeDefIndex: 56282
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

	public enum EntityVFXRendererMask // TypeDefIndex: 56283
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

	public enum EntityVFXPriorityType // TypeDefIndex: 56284
	{
		Normal = 0,
		UltiSkillTimeline = 1
	}

	public enum SettingLodLevel // TypeDefIndex: 56285
	{
		None = 0,
		Low = 1,
		Mid = 2,
		High = 4,
		Highest = 8
	}

	public enum AssetPlatformLayers // TypeDefIndex: 56286
	{
		PC = 1,
		Mobile = 2,
		Other = 4
	}

	public enum EffectTargetLayers // TypeDefIndex: 56287
	{
		Main = 1,
		Guard = 2
	}

	public class EntityVFXAssetBase : ScriptableObject // TypeDefIndex: 56288
	{
		// Fields
		public bool useECSRenderer; // 0x18
		public SettingLodLevel settingLodLevel; // 0x1C
		public AssetPlatformLayers platformLayer; // 0x20
		public EffectTargetLayers targetLayer; // 0x24
		private string m_assetName; // 0x28
	
		// Properties
		public string assetName { get => default; } // 0x000000018B4F58AC-0x000000018B4F5918 
	
		// Constructors
		public EntityVFXAssetBase() {} // 0x0000000186474F6C-0x0000000186474F88
	}

	public enum VFXType // TypeDefIndex: 56289
	{
		Addictive = 0,
		Dissolve = 1,
		Max = 2
	}

	public class EntityVFXControllerBase // TypeDefIndex: 56290
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
		public bool isPlaying { get => default; } // 0x00000001813B31B0-0x00000001813B31C0 
		public bool isHiding { get => default; } // 0x00000001813B34D0-0x00000001813B34E0 
		public bool isKeyword { get => default; } // 0x0000000181E2DB70-0x0000000181E2DB80 
		public string vfxName { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public float destroyTime { get => default; set {} } // 0x0000000185FB24B0-0x0000000185FB24C0 0x0000000185FB24C0-0x0000000185FB24D0
		public float lastTickTime { get => default; set {} } // 0x0000000185FB0580-0x0000000185FB0590 0x0000000185FB05E0-0x0000000185FB05F0
	
		// Constructors
		public EntityVFXControllerBase() {} // 0x0000000185FB9750-0x0000000185FB9770
	
		// Methods
		public void SetOwner(string name, IRendererHelper owner) {} // 0x0000000185F539F0-0x0000000185F53A50
		public void InitLOD(EntityVFXAssetBase vfxAssetBase) {} // 0x000000018519C450-0x000000018519C4A0
		public void SetName(string name) {} // 0x000000018519A410-0x000000018519A450
		public bool PoolTick() => default; // 0x000000018B4F5C6C-0x000000018B4F5CBC
		public void Destroy() {} // 0x000000018B4F5918-0x000000018B4F5A00
		protected virtual void OnDestroy() {} // 0x000000018B4F5AF4-0x000000018B4F5B38
		public virtual void Play() {} // 0x000000018B4F5C28-0x000000018B4F5C6C
		public virtual void Stop(bool forceStop) {} // 0x000000018B4F5DD4-0x000000018B4F5E28
		public virtual void Replay() {} // 0x000000018B4F5CBC-0x000000018B4F5D00
		public virtual void Tick(float logicDeltaTime) {} // 0x000000018B4F5E28-0x000000018B4F5E7C
		protected void RefreshLastTickTime() {} // 0x00000001857EC770-0x00000001857EC800
		protected float GetDeltaTimeFromLastTick(bool useScaledTime) => default; // 0x0000000185346DA0-0x0000000185346E80
		public virtual EntityVFXPriorityType GetPriorityType() => default; // 0x000000018B4F5A4C-0x000000018B4F5A98
		public virtual bool GetNeedTick() => default; // 0x000000018B4F5A00-0x000000018B4F5A4C
		public void Hide() {} // 0x000000018B4F5A98-0x000000018B4F5AF4
		protected virtual void OnHide() {} // 0x000000018B4F5B38-0x000000018B4F5B7C
		public void Show() {} // 0x000000018B4F5D7C-0x000000018B4F5DD4
		protected virtual void OnShow() {} // 0x000000018B4F5BE4-0x000000018B4F5C28
		public void Sample(float time, bool ending = false /* Metadata: 0x0207C495 */) {} // 0x000000018B4F5D00-0x000000018B4F5D7C
		protected virtual void OnSample(float time, bool ending) {} // 0x000000018B4F5B7C-0x000000018B4F5BE4
	}

	public abstract class EntityVFXControllerStateBase : EntityVFXControllerBase // TypeDefIndex: 56292
	{
		// Fields
		private float _m_passTime_k__BackingField; // 0x48
		private float _m_loopPassTime_k__BackingField; // 0x4C
		private float _m_endPassTime_k__BackingField; // 0x50
		private State m_curState; // 0x54
	
		// Properties
		protected float m_passTime { get; private set; } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		protected float m_loopPassTime { get; private set; } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		protected float m_endPassTime { get; private set; } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		protected virtual bool useScaledTime { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		protected virtual bool useStartCurve { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		protected virtual bool useLoopCurve { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		protected virtual bool useEndCurve { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		protected virtual bool loop { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		protected virtual float duration { get; } // 0x0000000185FB2DD0-0x0000000185FB2DE0 
		protected virtual float loopDuration { get; } // 0x0000000185FB2DD0-0x0000000185FB2DE0 
		protected virtual float endDuration { get; } // 0x0000000183908D00-0x0000000183908D10 
	
		// Nested types
		private enum State // TypeDefIndex: 56291
		{
			End = 0,
			Start = 1,
			Loop = 2,
			Ending = 3
		}
	
		// Constructors
		protected EntityVFXControllerStateBase() {} // 0x0000000185FB9750-0x0000000185FB9770
	
		// Methods
		public override void Play() {} // 0x00000001857EC710-0x00000001857EC770
		public override void Replay() {} // 0x000000018B4F5F80-0x000000018B4F5FE4
		public override void Stop(bool forceStop) {} // 0x0000000185F61B20-0x0000000185F61B70
		public override bool GetNeedTick() => default; // 0x000000018562A150-0x000000018562A190
		public override void Tick(float logicDeltaTime) {} // 0x0000000185346CF0-0x0000000185346DA0
		protected override void OnSample(float time, bool ending) {} // 0x000000018B4F5E7C-0x000000018B4F5F80
		protected abstract void UpdateStart();
		protected abstract void UpdateLoop();
		protected abstract void UpdateStop();
		private void _FinalStop() {} // 0x0000000185F61B70-0x0000000185F61BB0
		protected abstract void OnFinalStop();
		public void __iFixBaseProxy_Play() {} // 0x0000000187AA48FC-0x0000000187AA4904
		public void __iFixBaseProxy_Replay() {} // 0x0000000187AA4904-0x0000000187AA490C
		public void __iFixBaseProxy_Stop(bool P0) {} // 0x0000000187AA490C-0x0000000187AA4914
		public bool __iFixBaseProxy_GetNeedTick() => default; // 0x0000000187AA55B4-0x0000000187AA55BC
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000187AA4914-0x0000000187AA491C
		public void __iFixBaseProxy_OnSample(float P0, bool P1) {} // 0x0000000187AA48EC-0x0000000187AA48F4
	}

	public enum EntityCustomizePropertyName // TypeDefIndex: 56293
	{
		None = 0,
		AlphaTex = 1,
		NormalTex = 2
	}

	public enum EntityCustomizeMatchMethod // TypeDefIndex: 56294
	{
		None = 0,
		All = 1,
		RendererName = 2,
		SourceMaterial0 = 3,
		SourceMesh = 4
	}

	[Serializable]
	public class EntityCustomizeRendererPropertyConfig // TypeDefIndex: 56295
	{
		// Fields
		public bool useColorTexture; // 0x10
		public bool useAutoFindColorTexture; // 0x11
		public string autoFindColorTextureName; // 0x18
		public SerializeFieldDictionary<Material, Texture> preConfigColorTextureDict; // 0x20
	
		// Constructors
		public EntityCustomizeRendererPropertyConfig() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public Texture GetColorTexture(Material material) => default; // 0x000000018B4F3AB8-0x000000018B4F3B60
	}

	public enum EntityVFXKeywordEnum // TypeDefIndex: 56296
	{
		None = 0,
		Dissolve = 1
	}

	[Serializable]
	public class EntityVFXDissolveData // TypeDefIndex: 56298
	{
		// Fields
		public EntityVFXPriorityType priorityType; // 0x10
		public EntityVFXRendererMask rendererMask; // 0x14
		public bool useScaledTime; // 0x18
		public bool loop; // 0x19
		public float duration; // 0x1C
		public UVSet uvSet; // 0x20
		public bool useCutoffPosY; // 0x24
		public bool useCutoffPosYAutoBounds; // 0x25
		public float cutoffPosYAbsoluteBounds; // 0x28
		public bool useCutoffLocalDirection; // 0x2C
		public Vector3 cutoffDirection; // 0x30
		public float cutoffUseDissolve; // 0x3C
		public bool stopShadowCasting; // 0x40
		public bool stopRayTracingMeanTime; // 0x41
		public float stopShadowCastingDelay; // 0x44
		public float revertShadowCastingDelay; // 0x48
		public Texture2D dissolveTexture; // 0x50
		public Vector4 dissolveTextureTillingOffset; // 0x58
		public float dissolveEdgeSharp; // 0x68
		public UnityEngine.Color dissolveEmissiveColor; // 0x6C
		public float dissolveEmissiveEdge; // 0x7C
		public bool useLocalScreenUV; // 0x80
		public AnimationCurve dissolveValueCurve; // 0x88
		public AnimationCurve cutoffPosYCurve; // 0x90
	
		// Nested types
		public enum UVSet // TypeDefIndex: 56297
		{
			UV = 0,
			UV2 = 1
		}
	
		// Constructors
		public EntityVFXDissolveData() {} // 0x0000000185C1E2F0-0x0000000185C1E340
	}

	public class EntityVFXDissolveAsset : EntityVFXAssetBase // TypeDefIndex: 56299
	{
		// Fields
		public EntityVFXDissolveData data; // 0x30
	
		// Constructors
		public EntityVFXDissolveAsset() {} // 0x0000000185A70430-0x0000000185A70440
	}

	public class EntityFactoryRendererInfo // TypeDefIndex: 56300
	{
		// Fields
		public int subMeshCount; // 0x10
		public bool enableVAT; // 0x14
		public int vatIndex; // 0x18
		public int initMaterialsCount; // 0x1C
	
		// Constructors
		public EntityFactoryRendererInfo() {} // 0x0000000185492010-0x0000000185492020
	}

	public class EntityVFXFactoryAddedMaterialManager // TypeDefIndex: 56305
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
		public class VATData // TypeDefIndex: 56301
		{
			// Fields
			public Texture factoryVATMap; // 0x10
			public Vector4 factoryVATMapParams; // 0x18
	
			// Constructors
			public VATData() {} // 0x000000018B4F6068-0x000000018B4F61BC
		}
	
		public class AddedMaterialData // TypeDefIndex: 56302
		{
			// Fields
			public Material srcMaterial; // 0x10
			public Material[] materialInstancesOfEachVAT; // 0x18
			public Dictionary<int, float> savedFloatProperties; // 0x20
			public Dictionary<int, Vector4> savedVectorProperties; // 0x28
	
			// Constructors
			public AddedMaterialData() {} // 0x000000018B4F65B8-0x000000018B4F68FC
		}
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 56303
		{
			// Fields
			public Material src; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x000000018B4F6A20-0x000000018B4F6AF0
	
			// Methods
			internal bool __GetAddedMaterialIndex_b__0(AddedMaterialData data) => default; // 0x000000018B4F68FC-0x000000018B4F6A20
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 56304
		{
			// Fields
			public Material src; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x000000018B4F6AF0-0x000000018B4F6C50
	
			// Methods
			internal bool __RemoveVATMaterial_b__0(AddedMaterialData data) => default; // 0x000000018B4F5FE4-0x000000018B4F6068
		}
	
		// Constructors
		public EntityVFXFactoryAddedMaterialManager() {} // 0x0000000185492010-0x0000000185492020
		static EntityVFXFactoryAddedMaterialManager() {} // 0x000000018B4FDC3C-0x000000018B4FDCA0
	
		// Methods
		public void Init(List<EntityFactoryRendererInfo> factoryRendererInfos) {} // 0x000000018B4F61BC-0x000000018B4F632C
		private void _AddVATMaterial(Material src) {} // 0x000000018B4F632C-0x000000018B4F6460
		private Material _GetVATMaterial(EntityFactoryRendererInfo rendererInfo, Material src) => default; // 0x000000018B4F6460-0x000000018B4F65B8
		private int _GetAddedMaterialIndex(EntityFactoryRendererInfo rendererInfo, Material src) => default; // 0x000000018B4F6CF8-0x000000018B4F6E50
		private void _RemoveVATMaterial(Material src) {} // 0x000000018B4F6C50-0x000000018B4F6CF8
		public void AddMaterialToAllRenderer(Material material) {} // 0x0000000185492010-0x0000000185492020
		public void RemoveMaterialFromAllRenderer(Material material) {} // 0x000000018B4F2B38-0x000000018B4F2BF8
		public void SetFloatToFactoryMaterial(Material material, int nameId, float value) {} // 0x0000000185492010-0x0000000185492020
		public void SetVectorToFactoryMaterial(Material material, int nameId, Vector4 value) {} // 0x000000018B4FDBD8-0x000000018B4FDC3C
	}

	public static class EntityVFXFactoryMaterialCache // TypeDefIndex: 56307
	{
		// Fields
		private static readonly int S_FACTORY_VAT_MAP; // 0x00
		private static readonly int S_FACTORY_VAT_MAP_PARAMS; // 0x04
		private static Dictionary<int, Dictionary<int, VATMaterialData>> s_cachedMaterials; // 0x08
	
		// Nested types
		public class VATMaterialData // TypeDefIndex: 56306
		{
			// Fields
			public int refCount; // 0x10
			public Material vatMaterial; // 0x18
	
			// Constructors
			public VATMaterialData() {} // 0x000000018B4F6E50-0x000000018B4F7164
		}
	
		// Constructors
		static EntityVFXFactoryMaterialCache() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static Material GetVATMaterial(Material srcMaterial, Texture factoryVATMap, Vector4 factoryVATMapParams) => default; // 0x000000018B4F7164-0x000000018B4F7398
		public static void ReleaseVATMaterial(Material srcMaterial, Texture factoryVATMap) {} // 0x000000018B4F7398-0x000000018B4F7480
	}

	[Serializable]
	public class EntityVFXSetParamsData // TypeDefIndex: 56309
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
		public float endDuration; // 0x40
		public List<EntityVFXCurveData> customEndCurves; // 0x48
	
		// Nested types
		public enum Type // TypeDefIndex: 56308
		{
			Character = 0,
			VFX = 1,
			Lit = 2
		}
	
		// Constructors
		public EntityVFXSetParamsData() {} // 0x0000000185FAEAC0-0x0000000185FAEAE0
	}

	public class EntityVFXSetParamsAsset : EntityVFXAssetBase // TypeDefIndex: 56310
	{
		// Fields
		public EntityVFXSetParamsData data; // 0x30
	
		// Constructors
		public EntityVFXSetParamsAsset() {} // 0x0000000185A70430-0x0000000185A70440
	}

	public static class EntityVFXUtils // TypeDefIndex: 56311
	{
		// Methods
		public static EntityVFXRendererMask ToMask(EntityVFXRendererType type) => default; // 0x0000000183F9A970-0x0000000183F9AA00
		public static void CalculateCutOffBounds(IRendererHelper owner, bool useCutoffLocalDirection, Vector3 cutoffDirectionData, bool useCutoffPosYAutoBounds, float cutoffPosYAbsoluteBounds, out float cutoffMin, out float cutoffMax, out Vector3 cutoffDirection) {
			cutoffMin = default;
			cutoffMax = default;
			cutoffDirection = default;
		} // 0x000000018B4F75F0-0x000000018B4F782C
		public static ValueTuple<float, float> GetBoundsMinMaxOfDirection(Bounds bounds, Vector3 direction) => default; // 0x000000018B4F782C-0x000000018B4F7A3C
		public static void ApplyEntityVFXCurves(Material material, List<EntityVFXCurveData> curveDataList, float schedule) {} // 0x000000018B4F7480-0x000000018B4F75F0
		public static EntityVFXCurveEvaluateResult Evaluate(EntityVFXCurveData curveData, float schedule) => default; // 0x0000000184A6F980-0x0000000184A6FB00
		private static void _UpdateCurve(Material material, EntityVFXCurveData curveData, float schedule) {} // 0x000000018B4F7B7C-0x000000018B4F7D10
		public static bool IsCharacterShader(string name) => default; // 0x000000018B4F7A3C-0x000000018B4F7ADC
		public static bool IsLitShader(string name) => default; // 0x000000018B4F7ADC-0x000000018B4F7B7C
	}

	public interface ICaptureMesh // TypeDefIndex: 56312
	{
		// Methods
		EntityRenderCapturedEntity Capture(GameObject placeRoot);
		void Release(EntityRenderCapturedEntity mesh);
	}

	public enum RenderHelperType // TypeDefIndex: 56313
	{
		Unknown = 0,
		Character = 1,
		Lit = 2,
		Mix = 4
	}

	public interface IRendererHelper // TypeDefIndex: 56314
	{
		// Methods
		void Reset();
		void Play(string vfxName);
		void Stop(string vfxName);
		void ShowAll();
		void HideAll();
		void SetDitherAlpha(float ditherAlpha, int handle = 0 /* Metadata: 0x0207C4AD */);
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
		float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x0207C4AE */);
		void SetAddictiveVectorProperty(int propertyId, Vector4 value);
		Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default);
		void SetAddictiveTextureProperty(int propertyId, Texture value);
		Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null);
		void StopShadowCasting(bool stopRayTracing = false /* Metadata: 0x0207C4B2 */);
		void RevertShadowCastingMode();
		void SetDepthOnlyEnabledToAllMaterial(bool enable, EntityVFXRendererMask rendererMask);
		bool SetManualDitherEnable(bool enable);
		void SetManualDitherAlphaValue(float value);
		Bounds GetRendererBounds();
		Matrix4x4 GetTransform();
		bool IsFactory();
		RenderHelperType GetRenderHelperType(bool forceCalculate = true /* Metadata: 0x0207C4B3 */);
		void SetTimeScale(float timeScale);
		float GetTimeScale();
		bool GetMeshHasVFXVertColor();
		bool CanPlay(SettingLodLevel settingLodLevel, AssetPlatformLayers platformLayer, EffectTargetLayers targetLayer);
	}

	public class CommonVAT : MonoBehaviour // TypeDefIndex: 56315
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
		public string PropertySetterType { get => default; } // 0x000000018B4F3A20-0x000000018B4F3AB8 
	
		// Constructors
		public CommonVAT() {} // 0x000000018B4F394C-0x000000018B4F3A20
		static CommonVAT() {} // 0x000000018B4F38FC-0x000000018B4F394C
	
		// Methods
		private void Start() {} // 0x000000018B4F300C-0x000000018B4F32B4
		public void Play(string name, bool playWhenComplete = false /* Metadata: 0x0207C4B4 */) {} // 0x000000018B4F2F74-0x000000018B4F300C
		private void _DoPlay(string name) {} // 0x000000018B4F342C-0x000000018B4F3610
		private void _NextPlay() {} // 0x000000018B4F3610-0x000000018B4F37D8
		private void _CreateTimer(float time, Action func, string funcName) {} // 0x000000018B4F3344-0x000000018B4F342C
		private void _ClearTimer() {} // 0x000000018B4F32B4-0x000000018B4F3344
		private void _UpdateProperty(RuntimeVATAnimationClip runtimeVatAnimationClip) {} // 0x000000018B4F37D8-0x000000018B4F38FC
	}

	public class FactoryVAT : MonoBehaviour // TypeDefIndex: 56316
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
		public FactoryVAT() {} // 0x000000018B4F8B20-0x000000018B4F8CB4
		static FactoryVAT() {} // 0x000000018B4F8AA4-0x000000018B4F8B20
	
		// Methods
		private void Start() {} // 0x000000018B4F7E6C-0x000000018B4F806C
		public void Reset() {} // 0x000000018B4F7E1C-0x000000018B4F7E6C
		private void _UpdateAnim() {} // 0x000000018B4F88C8-0x000000018B4F8AA4
		public void OnUpdate() {} // 0x000000018B4F7D10-0x000000018B4F7D60
		public void Play(string name, Action callBack = null, bool whenComplete = false /* Metadata: 0x0207C4B5 */) {} // 0x000000018B4F7D60-0x000000018B4F7E1C
		private void _DoPlay(string name, Action callBack) {} // 0x000000018B4F806C-0x000000018B4F818C
		private void _InitRenderer() {} // 0x000000018B4F83E4-0x000000018B4F84C8
		private void _InitRenderer_MeshRender(LODGroup lodGroup) {} // 0x000000018B4F818C-0x000000018B4F83E4
		private void _SetParamsToRenderer() {} // 0x000000018B4F8878-0x000000018B4F88C8
		private void _SetParamsToRenderer_MeshRender() {} // 0x000000018B4F8750-0x000000018B4F8878
		private void _ReSetParamsToRenderer() {} // 0x000000018B4F8700-0x000000018B4F8750
		private void _ReSetParamsToRenderer_MeshRender() {} // 0x000000018B4F84C8-0x000000018B4F8700
	}

	[Serializable]
	public class RuntimeVATAnimationClip // TypeDefIndex: 56317
	{
		// Fields
		public string stateName; // 0x10
		public string name; // 0x18
		public bool loop; // 0x20
		public int startFrame; // 0x24
		public int endFrame; // 0x28
	
		// Constructors
		public RuntimeVATAnimationClip() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class RuntimeVATData // TypeDefIndex: 56318
	{
		// Fields
		public Texture vatMap; // 0x10
		public bool fullRigidBody; // 0x18
		public List<Matrix4x4> bonePoses; // 0x20
		public float frameRate; // 0x28
		public List<RuntimeVATAnimationClip> animationClips; // 0x30
	
		// Constructors
		public RuntimeVATData() {} // 0x000000018B4FB9F8-0x000000018B4FBA70
	}

	public abstract class VATPropertySetter // TypeDefIndex: 56319
	{
		// Constructors
		protected VATPropertySetter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract void Init(GameObject gameObject);
		public abstract void SetFloat(int id, float value);
		public abstract void SetVector(int id, Vector4 value);
	}

	public class VATRendererPropertySetter : VATPropertySetter // TypeDefIndex: 56320
	{
		// Fields
		private List<Renderer> m_allRenderers; // 0x10
		private List<Material> m_allMaterials; // 0x18
	
		// Constructors
		public VATRendererPropertySetter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override void Init(GameObject gameObject) {} // 0x000000018B4FFCA0-0x000000018B4FFF20
		public override void SetFloat(int id, float value) {} // 0x000000018B4FFF20-0x000000018B5000A8
		public override void SetVector(int id, Vector4 value) {} // 0x000000018B5000A8-0x000000018B500254
	}

	public class VATEntityRendererHelperPropertySetter : VATPropertySetter // TypeDefIndex: 56321
	{
		// Fields
		private IRendererHelper m_rendererHelper; // 0x10
	
		// Constructors
		public VATEntityRendererHelperPropertySetter() {} // Dummy constructor
		public VATEntityRendererHelperPropertySetter(IRendererHelper rendererHelper) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void Init(GameObject gameObject) {} // 0x000000018B4FFB38-0x000000018B4FFB8C
		public override void SetFloat(int id, float value) {} // 0x000000018B4FFB8C-0x000000018B4FFC0C
		public override void SetVector(int id, Vector4 value) {} // 0x000000018B4FFC0C-0x000000018B4FFCA0
	}

	public class PsoCreateUploadHelper // TypeDefIndex: 56329
	{
		// Fields
		protected const int PSO_UPLOAD_INFO_VERSION = 1; // Metadata: 0x0207C4B6
		protected const int MAX_UPLOAD_COUNT_PER_LOOP = 128; // Metadata: 0x0207C4B7
		protected const int MAX_UPLOAD_COUNT_PER_LOOP_LARGE = 256; // Metadata: 0x0207C4B9
		protected const int MAX_UPLOAD_SIZE_PER_LOOP = 786432; // Metadata: 0x0207C4BB
		protected const int MAX_UPLOAD_SIZE_PER_LOOP_LARGE = 5242880; // Metadata: 0x0207C4BF
		protected const float TICK_INTERVAL = 0.55f; // Metadata: 0x0207C4C3
		protected const int TICK_UPLOAD_INTERVAL = 60; // Metadata: 0x0207C4C7
		protected const float CREATE_TIME_SMALL_DROP = 0.5f; // Metadata: 0x0207C4C8
		protected static PsoCreateUploadHelper s_instance; // 0x00
		public static int s_enabled; // 0x08
		protected static int s_tickCount; // 0x0C
		public static bool s_skipUploadFile; // 0x10
		public static bool s_isShaderWarming; // 0x11
		public static bool s_enableTimeLimit; // 0x12
		private static string s_persistentDataPath; // 0x18
		private static ConcurrentQueue<ValueTuple<string, float, int, bool, string>> s_concurrentQueue; // 0x20
		private TickFunction m_timerId; // 0x10
		private const string URL = "http://beyondtools.int.hypergryph.com:42422"; // Metadata: 0x0207C4CC
		private const string TOKEN = "fhlasdfu8731fqa"; // Metadata: 0x0207C4F8
		private static SynchronizationContext s_mainSyncContext; // 0x28
		private static int s_mainThreadId; // 0x30
	
		// Properties
		public static PsoCreateUploadHelper instance { get => default; } // 0x0000000185393C00-0x0000000185393C40 
		private static string persistentDataPath { get => default; } // 0x000000018B4FB26C-0x000000018B4FB6F0 
	
		// Nested types
		[Serializable]
		private class PsoInfoWrapperItem // TypeDefIndex: 56322
		{
			// Fields
			public string infoJson; // 0x10
			public float time; // 0x18
			public int codeSize; // 0x1C
			public bool isMissing; // 0x20
			public string levelId; // 0x28
	
			// Constructors
			public PsoInfoWrapperItem() {} // 0x00000001852D57B0-0x00000001852D5890
		}
	
		[Serializable]
		private class PsoInfoWrapper // TypeDefIndex: 56323
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
			public PsoInfoWrapper() {} // 0x0000000185D5BA00-0x0000000185D5BB50
		}
	
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 56324
		{
			// Fields
			public string path; // 0x10
			public string serverFileName; // 0x18
			public PsoInfoWrapper psoInfoWrapper; // 0x20
	
			// Constructors
			public __c__DisplayClass35_0() {} // 0x00000001844CFCE0-0x00000001844CFE30
	
			// Methods
			internal void __CreateAndUploadFinalJson_b__0(object param) {} // 0x0000000185991470-0x00000001859915C0
		}
	
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 56325
		{
			// Fields
			public string urlPath; // 0x10
			public string rawFilePath; // 0x18
			public string serverFileNameOverride; // 0x20
			public Action<bool, string, string> callback; // 0x28
	
			// Constructors
			public __c__DisplayClass41_0() {} // 0x00000001844D0EE0-0x00000001844D3400
	
			// Methods
			internal void __UploadFile_b__0(object param) {} // 0x0000000185393260-0x0000000185393C00
		}
	
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 56326
		{
			// Fields
			public Action<bool, string, string> callback; // 0x10
			public string fileServerUrl; // 0x18
			public string errorMessage; // 0x20
	
			// Constructors
			public __c__DisplayClass42_0() {} // 0x000000018B4FAFB4-0x000000018B4FB204
	
			// Methods
			internal void __UploadFileToServer_b__1(object _) {} // 0x00000001852973B0-0x0000000185297FF0
			internal void __UploadFileToServer_b__2(object _) {} // 0x000000018B4FAF28-0x000000018B4FAFB4
		}
	
		private sealed class __c__DisplayClass42_1 // TypeDefIndex: 56327
		{
			// Fields
			public string result; // 0x10
			public __c__DisplayClass42_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass42_1() {} // 0x000000018B4FAE90-0x000000018B4FAF28
	
			// Methods
			internal void __UploadFileToServer_b__0(object _) {} // 0x0000000183E7FF50-0x0000000183E80B20
		}
	
		private struct __UploadFileToServer_d__42 : IAsyncStateMachine // TypeDefIndex: 56328
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public Action<bool, string, string> callback; // 0x28
			public string urlPath; // 0x30
			public string serverFileNameOverride; // 0x38
			public string rawFilePath; // 0x40
			private __c__DisplayClass42_1 __8__1; // 0x48
			private __c__DisplayClass42_0 __8__2; // 0x50
			private string _filePathServerUrl_5__2; // 0x58
			private Stream _fileStream_5__3; // 0x60
			private HttpClient _httpClient_5__4; // 0x68
			private MultipartFormDataContent _content_5__5; // 0x70
			private HttpResponseMessage _response_5__6; // 0x78
			private TaskAwaiter<HttpResponseMessage> __u__1; // 0x80
			private TaskAwaiter<string> __u__2; // 0x88
	
			// Methods
			private void MoveNext() {} // 0x0000000185195E40-0x0000000185195F90
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x00000001852152B0-0x00000001852153C0
		}
	
		// Constructors
		static PsoCreateUploadHelper() {} // 0x0000000185393D90-0x0000000185393F40
		public PsoCreateUploadHelper() {} // 0x0000000186475504-0x0000000186475510
	
		// Methods
		public static void Initialize() {} // 0x000000018B4FB818-0x000000018B4FB980
		public void Init() {} // 0x000000018B4FB6F0-0x000000018B4FB818
		private void _SceneLoadStartHandler(in EventData<string, string> args) {} // 0x000000018B4FB204-0x000000018B4FB26C
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
		public static bool IsPsoRecordEnabled() => default; // 0x0000000185492010-0x0000000185492020
		public static void BeforeWarmUpBegin() {} // 0x000000018B4FB980-0x000000018B4FB9F8
		public static void AfterWarmUpFinish() {} // 0x0000000185492010-0x0000000185492020
		private static void _Tick(float deltaTime) {} // 0x000000018B4FDCA0-0x000000018B4FDD08
		private static void _PsoUploadProcessOneCallBack(string infoJson, HGPsoExtInfo info) {} // 0x0000000185492010-0x0000000185492020
		private static string _PsoUpdateGameInfoCallBack() => default; // 0x000000018B4FDDD4-0x000000018B4FDE50
		private static void _UploadPipelineCreatedInfo(bool timeLimit) {} // 0x0000000185492010-0x0000000185492020
		private static void _CreateAndUploadFinalJson(bool timeLimit) {} // 0x000000018B4FDFB8-0x000000018B4FDFEC
		private static void _CreateAndUploadFileToServer(string path, string serverFileName, PsoInfoWrapper psoInfoWrapper) {} // 0x000000018B4FDFB8-0x000000018B4FDFEC
		private static void _UploadFile(string urlPath, string rawFilePath, string serverFileNameOverride, Action<bool, string, string> callback) {} // 0x0000000185492010-0x0000000185492020
		private static void _UploadFileToServer(string urlPath, string rawFilePath, string serverFileNameOverride, Action<bool, string, string> callback) {} // 0x000000018B4FDFEC-0x000000018B4FE02C
		private static void _Callback(bool success, string msg, string url) {} // 0x000000018B4FE02C-0x000000018B4FFB38
	}

	public class VFXSludgeBaker // TypeDefIndex: 56332
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
		private const float EXTEND_SIZE = 2f; // Metadata: 0x0207C508
		public float rayCastPosY; // 0xB0
	
		// Nested types
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 56330
		{
			// Fields
			public float[,] sdf; // 0x10
			public HashSet<int> hashList; // 0x18
			public int xCount; // 0x20
			public Queue<Vector2Int> pendingList; // 0x28
			public Action<int, int> __9__0; // 0x30
	
			// Constructors
			public __c__DisplayClass41_0() {} // 0x000000018B5033EC-0x000000018B50345C
	
			// Methods
			internal void __CalculateEdgeSignedDistance_b__0(int tx, int tz) {} // 0x000000018B500254-0x000000018B5002EC
		}
	
		private sealed class __c__DisplayClass41_1 // TypeDefIndex: 56331
		{
			// Fields
			public int ix; // 0x10
			public int iz; // 0x14
			public float minDistance; // 0x18
			public __c__DisplayClass41_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass41_1() {} // 0x000000018B5018E4-0x000000018B501C54
	
			// Methods
			internal void __CalculateEdgeSignedDistance_b__1(int tx, int tz) {} // 0x000000018B5002EC-0x000000018B5003D0
		}
	
		// Constructors
		public VFXSludgeBaker() {} // Dummy constructor
		public VFXSludgeBaker(SplineContainer splineContainer, Transform target, float density, float thickness, float maxHeight, float blurIntensity, float gridHeightOffset) {} // 0x000000018B5003D0-0x000000018B5004F4
	
		// Methods
		public void Bake() {} // 0x000000018B502BA0-0x000000018B5033EC
		private void _CalculatePolygonAndBounds() {} // 0x000000018B501398-0x000000018B5015BC
		public Vector2Int GetLocalIndex(Vector3 localPosition) => default; // 0x000000018B500F78-0x000000018B501398
		public Vector3 GetLocalPosition(Vector2Int index) => default; // 0x000000018B502380-0x000000018B5024E4
		private void _RaycastSceneObjectsHeight() {} // 0x000000018B50214C-0x000000018B502380
		private void _CalculateInPolygon() {} // 0x000000018B5004F4-0x000000018B5006E0
		private void _CalculateInHighPowerZone() {} // 0x000000018B501C54-0x000000018B50214C
		private static float[] _CreateGaussianKernel(int size, float sigma) => default; // 0x000000018B5015BC-0x000000018B5018E4
		private static float[,] _Convolution(float[,] src, float[] kernel, Vector2Int offsetDir) => default; // 0x000000018B502678-0x000000018B502774
		private void _BlurTopHeight() {} // 0x000000018B5027E0-0x000000018B502850
		private void _CalculateThicknessAndTopHeight() {} // 0x000000018B502774-0x000000018B5027E0
		private void _CalculateNormals() {} // 0x000000018B5006E0-0x000000018B500A98
		private static void _ForAround(int ix, int iz, int xCount, int zCount, Action<int, int> callback) {} // 0x000000018B500A98-0x000000018B500F78
		private int _GetHash(int ix, int iz) => default; // 0x000000018B502850-0x000000018B502A50
		private static int _GetHash(int ix, int iz, int xCount) => default; // 0x000000018B502A50-0x000000018B502BA0
		private static void _CalculateEdgeSignedDistance(float[,] sdf) {} // 0x000000018B5024E4-0x000000018B502678
		private void _CalculateEdgeSignedDistance() {} // 0x0000000185492010-0x0000000185492020
		private UnityEngine.Color _GetTextureColor1(int ix, int iz) => default; // 0x000000018B4FDD08-0x000000018B4FDDD4
		private UnityEngine.Color _GetTextureColor2(int ix, int iz) => default; // 0x0000000185492010-0x0000000185492020
		private void _CreateTexture() {} // 0x000000018B4FDE50-0x000000018B4FDFB8
	}

	public class VFXSludgeNavUtils // TypeDefIndex: 56342
	{
		// Nested types
		public static class BoundsUtil // TypeDefIndex: 56333
		{
			// Methods
			public static void GetTopBottomPoints(Bounds bounds, Transform t, out Vector3 topPoint, out Vector3 bottomPoint, Vector3? upDir = default) {
				topPoint = default;
				bottomPoint = default;
			} // 0x0000000185492010-0x0000000185492020
		}
	
		public static class Spline2DProjectAndSimplify // TypeDefIndex: 56338
		{
			// Nested types
			public struct Frame // TypeDefIndex: 56334
			{
				// Fields
				public Vector3 origin; // 0x00
				public Quaternion rot; // 0x0C
	
				// Constructors
				public Frame(Vector3 origin, Quaternion rot) {
					this.origin = default;
					this.rot = default;
				} // 0x000000018B4F2BF8-0x000000018B4F2F74
	
				// Methods
				public Vector3 WorldToFrame(Vector3 pWorld) => default; // 0x000000018B4FC168-0x000000018B4FC290
				public Vector3 FrameToWorld(Vector3 pFrame) => default; // 0x000000018B4FC0A4-0x000000018B4FC168
			}
	
			public enum EdgeMode // TypeDefIndex: 56335
			{
				UseSplineOrder = 0,
				ConvexHull = 1
			}
	
			public class ProcessResult // TypeDefIndex: 56336
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
				public ProcessResult() {} // 0x000000018B4FCB10-0x000000018B4FD0A0
			}
	
			private sealed class __c__DisplayClass6_0 // TypeDefIndex: 56337
			{
				// Fields
				public List<Vector2> pts; // 0x10
	
				// Constructors
				public __c__DisplayClass6_0() {} // 0x000000018B4FC82C-0x000000018B4FCB10
	
				// Methods
				internal int _ConvexHullIndices_b__0(int i, int j) => default; // 0x000000018B4FBA70-0x000000018B4FC0A4
			}
	
			// Methods
			public static Frame MakeFrameFromPlaneNormal(Vector3 planeOrigin, Vector3 planeNormal) => default; // 0x000000018B4FD544-0x000000018B4FD7A0
			public static Frame MakeFrameByYaw(Vector3 origin, float yawDeg) => default; // 0x000000018B4FD7A0-0x000000018B4FDAA8
			public static List<Vector3> SampleUniformByArcLength(SplineContainer container, float stepMeters = 0.1f /* Metadata: 0x0207C50C */, int splineIndex = 0 /* Metadata: 0x0207C510 */, bool closed = true /* Metadata: 0x0207C511 */, float oversample = 0.02f /* Metadata: 0x0207C512 */) => default; // 0x000000018B4FDAA8-0x000000018B4FDBD8
			public static void ProjectWorldToFrameXZ(List<Vector3> worldPts, Frame frame, out List<Vector2> projected2D, out List<float> frameYs, out float worldMinY, out float worldMaxY, out float frameMinY, out float frameMaxY) {
				projected2D = default;
				frameYs = default;
				worldMinY = default;
				worldMaxY = default;
				frameMinY = default;
				frameMaxY = default;
			} // 0x000000018B4FD0A0-0x000000018B4FD4EC
			public static List<int> ConvexHullIndices(List<Vector2> pts) => default; // 0x000000018B4FC290-0x000000018B4FC82C
			private static float _AngleDegAt(List<Vector2> p, int i, bool closed) => default; // 0x000000018B4FD4EC-0x000000018B4FD544
			private static float _CurvatureAt(List<Vector2> p, int i, bool closed) => default; // 0x0000000185FBDA20-0x0000000185FBDA40
			private static float _PointToSegmentDistance2D(Vector2 a, Vector2 b, Vector2 p) => default; // 0x000000018B503550-0x000000018B503668
			public static List<int> Simplify2D_ByCurvatureAngleDeviation(List<Vector2> poly, bool closed, float angleDegThresh, float deltaKappaThresh, float devEps) => default; // 0x000000018B50345C-0x000000018B503550
			public static ProcessResult Process(SplineContainer container, Frame frame, float stepMeters = 0.1f /* Metadata: 0x0207C516 */, int splineIndex = 0 /* Metadata: 0x0207C51A */, bool splineClosed = true /* Metadata: 0x0207C51B */, EdgeMode edgeMode = EdgeMode.UseSplineOrder /* Metadata: 0x0207C51C */, float angleDegThresh = 3f /* Metadata: 0x0207C51D */, float deltaKappaThresh = 0.1f /* Metadata: 0x0207C521 */, float devEpsFactor = 0.2f /* Metadata: 0x0207C525 */) => default; // 0x0000000185492010-0x0000000185492020
			internal static float _ConvexHullIndices_g__Cross_6_1(Vector2 a, Vector2 b, Vector2 c) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		public static class SplineSamplingUtils // TypeDefIndex: 56340
		{
			// Nested types
			private struct __c__DisplayClass0_0 // TypeDefIndex: 56339
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
			public static List<Vector2> SampleByArcLength(SplineContainer container, float step, int splineIndex = 0 /* Metadata: 0x0207C52B */, int lutResolution = 1024 /* Metadata: 0x0207C52C */, bool closed = true /* Metadata: 0x0207C52E */, bool worldSpace = true /* Metadata: 0x0207C52F */) => default; // 0x000000018B506A7C-0x000000018B506B68
			internal static Vector3 _SampleByArcLength_g__P_0_0(int i, ref __c__DisplayClass0_0 param_00076f16) => default; // 0x000000018B506110-0x000000018B506934
			internal static float _SampleByArcLength_g__WrapLen_0_1(float s, ref __c__DisplayClass0_0 param_00076f18) => default; // 0x000000018B506934-0x000000018B506A4C
		}
	
		public static class PolySimplify // TypeDefIndex: 56341
		{
			// Methods
			public static List<Vector3> SimplifyByAngle(List<Vector3> pts, float maxTurnDeg = 3f /* Metadata: 0x0207C530 */, float minEdgeLen = 0.05f /* Metadata: 0x0207C534 */, bool closed = true /* Metadata: 0x0207C538 */) => default; // 0x000000018B506A4C-0x000000018B506A7C
		}
	
		// Constructors
		public VFXSludgeNavUtils() {} // 0x000000018B505ABC-0x000000018B506110
	}

	public static class VFXSludgeUtils // TypeDefIndex: 56343
	{
		// Methods
		public static List<Vector3> GetPolygonOffSpline(SplineContainer splineContainer, float splitDistance, int splineIndex = 0 /* Metadata: 0x0207C539 */) => default; // 0x000000018B5076C8-0x000000018B507910
		public static void GetPolygonOffSplineWithSimplify(SplineContainer container, ref List<Vector2> points, int splineIndex = 0 /* Metadata: 0x0207C53A */, bool closed = true /* Metadata: 0x0207C53B */, bool isDebug = false /* Metadata: 0x0207C53C */, bool isConvexHull = false /* Metadata: 0x0207C53D */) {} // 0x000000018B5070B0-0x000000018B5076C8
		public static List<Vector3> GetPolygonOffByPolyLine(List<Vector2> polylinePoints, Transform transform, float splitDistance) => default; // 0x000000018B506D24-0x000000018B5070B0
		public static List<Vector3> CalculatePointPolygonHorizonRayCross(List<Vector3> polygon, Vector3 point) => default; // 0x000000018B506B68-0x000000018B506D24
	}

	public class HGTerrain : MonoBehaviour // TypeDefIndex: 56344
	{
		// Constructors
		public HGTerrain() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public delegate void ToggleFunc(HGTerrainHelper terrainHelper); // TypeDefIndex: 56345; 0x00000001833EEC70-0x00000001833EEC80

	public class HGTerrainHelper : MonoBehaviour // TypeDefIndex: 56346
	{
		// Constructors
		public HGTerrainHelper() {} // 0x000000018646DB20-0x000000018646DB28
	}
}

namespace Beyond.Rendering.LODLightmapping
{
	public class LightmapInfoTransfer : MonoBehaviour // TypeDefIndex: 56348
	{
		// Fields
		private MeshRenderer _lightmappedRenderer; // 0x18
		private MeshRenderer m_currentRenderer; // 0x20
	
		// Constructors
		public LightmapInfoTransfer() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnEnable() {} // 0x000000018B5058B8-0x000000018B505908
		private void Awake() {} // 0x000000018B505820-0x000000018B5058B8
		private void _RendererInfoTransfer() {} // 0x000000018B505908-0x000000018B505ABC
	}

	public enum LodLightmappingMode // TypeDefIndex: 56349
	{
		AllFromLightProbe = 0,
		AllFromLOD0 = 1,
		UseDifferentLightmapAreaForLODs = 2
	}

	public class LODLightmapping : MonoBehaviour // TypeDefIndex: 56350
	{
		// Fields
		public LodLightmappingMode mode; // 0x18
		public Vector4 lightmapScaleOffset; // 0x1C
		public int lightmapIndex; // 0x2C
	
		// Constructors
		public LODLightmapping() {} // 0x0000000185EE13E0-0x0000000185EE1420
	
		// Methods
		public void RendererInfoTransfer() {} // 0x000000018B50544C-0x000000018B505820
	}
}

namespace Beyond.Rendering.SplineMovingObjects
{
	public class HGSplineMovingObjects : MonoBehaviour, IVFXPlayable // TypeDefIndex: 56347
	{
		// Fields
		private SplineObjectsDesc desc; // 0x18
		private SplineObjectsKnotData[] knotData; // 0x258
		private bool fixedPostion; // 0x260
		private bool optimizeCurve; // 0x261
		private uint m_instanceHandle; // 0x264
		private NativeArray<SplineObjectsKnotData> m_stonesKnotDataNativeArray; // 0x268
	
		// Constructors
		public HGSplineMovingObjects() {} // 0x000000018B5040B8-0x000000018B5042BC
	
		// Methods
		private void _CreateInstance() {} // 0x000000018B503AB4-0x000000018B503D28
		private void _ExtractSplineData() {} // 0x000000018B503D90-0x000000018B504014
		private void _DestroyInstance() {} // 0x000000018B503D28-0x000000018B503D90
		private void _Release() {} // 0x000000018B504014-0x000000018B5040B8
		private void Update() {} // 0x000000018B5039FC-0x000000018B503AB4
		private void OnEnable() {} // 0x000000018B5038B8-0x000000018B503908
		private void OnDisable() {} // 0x000000018B5036B8-0x000000018B503708
		private void OnDestroy() {} // 0x000000018B503668-0x000000018B5036B8
		private void OnDrawGizmosSelected() {} // 0x000000018B503708-0x000000018B5038B8
		public void Pause() {} // 0x000000018B503908-0x000000018B50395C
		public void Play() {} // 0x000000018B50395C-0x000000018B5039AC
		public void Stop() {} // 0x000000018B5039AC-0x000000018B5039FC
	}
}

namespace Beyond.SourceGenerator
{
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 56220
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 56221
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 56222
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 56223
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 56224
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	public class ContainerWaterManager : MonoBehaviour // TypeDefIndex: 56217
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
		private float _dx; // 0x54
		private int m_nx; // 0x58
		private int m_ny; // 0x5C
		public float CFL; // 0x60
		public float c; // 0x64
		private float m_dt; // 0x68
		private float m_t; // 0x6C
		public bool reflectiveBoundary; // 0x70
		private float _waveMultiplier; // 0x74
		private float _pulseFrequency; // 0x78
		private float _pulseMagnitude; // 0x7C
		private float _elasticity; // 0x80
		private float _viscosity; // 0x84
		private float _surfaceTension; // 0x88
		private bool _adaptiveQuality; // 0x8C
		private float _targetFrameTime; // 0x90
		private float m_lastFrameTime; // 0x94
		private RawImage _debugDisplay; // 0x98
		private int _updateFrequency; // 0xA0
		private int m_frameCounter; // 0xA4
		private float m_currentYRotationSpeed; // 0xA8
		private bool m_needsTextureUpdate; // 0xAC
		private Vector3 m_lastIceBallPosition; // 0xB0
		private Quaternion m_lastIceBallRotation; // 0xBC
		private readonly float m_iceBallRadius; // 0xCC
		private float _rippleUpdateInterval; // 0xD0
		private float _rippleBaseStrength; // 0xD4
		private float _rippleRadius; // 0xD8
		private float _rippleWaveLength; // 0xDC
		private float _rippleSpeed; // 0xE0
		private float _distanceDecayPower; // 0xE4
		private float _meltingUniformity; // 0xE8
		private float _meltingVariation; // 0xEC
		private float m_lastRippleUpdateTime; // 0xF0
		private float m_ripplePhase; // 0xF4
		private float _rotationWaveMultiplier; // 0xF8
		private float _rotationSensitivity; // 0xFC
		private bool[,] m_cylinderMask; // 0x100
		private List<Vector2Int> m_activePoints; // 0x108
		private Color32[] m_cachedPixels; // 0x110
		private float _normalMeniscusWidth; // 0x118
		private float _vortexDetectionThreshold; // 0x11C
		private float _vortexTransitionTime; // 0x120
		private bool m_isVortexActive; // 0x124
		private float m_vortexTransitionProgress; // 0x128
		private float m_lastVortexCheckTime; // 0x12C
		private float m_lastYAxisStopTime; // 0x130
		private bool m_wasYAxisRotating; // 0x134
		private readonly float m_yAxisStopDelay; // 0x138
		private const float VORTEX_CHECK_INTERVAL = 0.1f; // Metadata: 0x0207C2D0
		private float _movementDistanceThreshold; // 0x13C
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
		private float dy { get => default; } // 0x0000000183F80440-0x0000000183F80450 
	
		// Constructors
		public ContainerWaterManager() {} // 0x000000018B4EED48-0x000000018B4EEE4C
		static ContainerWaterManager() {} // 0x000000018B4EEC78-0x000000018B4EED48
	
		// Methods
		private void Start() {} // 0x000000018B4EBC30-0x000000018B4EBCB0
		private void _InitializeWaveSystem() {} // 0x000000018B4EC764-0x000000018B4ECC28
		private void _PrecomputeCylinderMask() {} // 0x000000018B4ECD38-0x000000018B4ECF68
		private void _UnifiedWaveStep(bool isEditorUpdate) {} // 0x000000018B4ECF68-0x000000018B4EE7F4
		private bool _WorldToTextureCoords(Vector3 worldPos, ref Vector2Int texturePos) => default; // 0x000000018B4EEB94-0x000000018B4EEC78
		private bool _IsInsideCylinder(int i, int j) => default; // 0x000000018B4ECC28-0x000000018B4ECCBC
		private bool _IsValidPosition(int x, int y) => default; // 0x000000018B4ECCBC-0x000000018B4ECD38
		private void _ApplyMatrixToTexture(float[][] state, ref Texture2D tex, float waveMultiplier) {} // 0x000000018B4EC0E4-0x000000018B4EC548
		private void _ApplyReflectiveBoundary() {} // 0x000000018B4EC548-0x000000018B4EC5FC
		private void _ApplyAbsorptiveBoundary() {} // 0x000000018B4EBF90-0x000000018B4EC0E4
		private Vector2Int _FindNearestInsidePoint(int x, int y) => default; // 0x000000018B4EC5FC-0x000000018B4EC764
		private void _UpdateVortexState(bool isEditorUpdate) {} // 0x000000018B4EE7F4-0x000000018B4EEB94
		public void ResetWaveTexture() {} // 0x000000018B4EBA88-0x000000018B4EBC30
		private void Update() {} // 0x000000018B4EBCB0-0x000000018B4EBF90
	}

	public class VFXLockTransform : MonoBehaviour // TypeDefIndex: 56218
	{
		// Constructors
		public VFXLockTransform() {} // 0x000000018646DB20-0x000000018646DB28
	}

	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 56219
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 56353
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F63E50-0x0000000185F63EC0
	
		// Methods
		public void __Gen_Wrap_0(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public bool __Gen_Wrap_1(object P0, int P1, int P2) => default; // 0x000000018A833B44-0x000000018A833C34
		public Vector2Int __Gen_Wrap_2(object P0, int P1, int P2) => default; // 0x000000018B504B14-0x000000018B504C28
		public bool __Gen_Wrap_3(object P0, Vector3 P1, ref Vector2Int P2) => default; // 0x000000018B504C28-0x000000018B504DA8
		public void __Gen_Wrap_4(object P0, bool P1) {} // 0x0000000187678A10-0x0000000187678AEC
		public void __Gen_Wrap_5(object P0, object P1, ref Texture2D P2, float P3) {} // 0x000000018B504DA8-0x000000018B504EE8
		public void __Gen_Wrap_6(object P0, float P1) {} // 0x0000000187678884-0x0000000187678964
		public void __Gen_Wrap_7(object P0, int P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public void __Gen_Wrap_8(object P0, Vector4 P1, Vector4 P2) {} // 0x000000018B504EE8-0x000000018B50501C
		public void __Gen_Wrap_9(object P0, Vector4 P1) {} // 0x000000018B50501C-0x000000018B505130
		public void __Gen_Wrap_10(object P0, float P1, float P2) {} // 0x00000001876A24E4-0x00000001876A25CC
		public string __Gen_Wrap_11(object P0) => default; // 0x000000018B5042BC-0x000000018B5043AC
		public void __Gen_Wrap_12() {} // 0x0000000187678160-0x00000001876781FC
		public string __Gen_Wrap_13(RootCategory P0) => default; // 0x000000018B5043AC-0x000000018B504488
		public string __Gen_Wrap_14(RootCategory P0, bool P1) => default; // 0x000000018B504488-0x000000018B504580
		public string __Gen_Wrap_15() => default; // 0x000000018B504580-0x000000018B50464C
		public string __Gen_Wrap_16(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3) => default; // 0x000000018B50464C-0x000000018B504770
		public string __Gen_Wrap_17(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3, object P4) => default; // 0x000000018B504770-0x000000018B5048A4
		public long __Gen_Wrap_18() => default; // 0x000000018735B4A4-0x000000018735B550
		public bool __Gen_Wrap_19(object P0, object P1, object P2, object P3, object P4, object P5) => default; // 0x000000018B5048A4-0x000000018B5049DC
		public bool __Gen_Wrap_20(object P0, out string P1) {
			P1 = default;
			return default;
		} // 0x000000018B5049DC-0x000000018B504B14
		public bool __Gen_Wrap_21(object P0) => default; // 0x0000000181370BF0-0x0000000181370EB0
		public void __Gen_Wrap_22(ShaderWarmupManager.WarmUpReason P0) {} // 0x0000000181355200-0x00000001813553F0
		public string __Gen_Wrap_23(IntPtr P0, ref WindowsGpuDriverVersion.SP_DEVINFO_DATA P1, uint P2) => default; // 0x0000000183E8ECC0-0x0000000183E8FBE0
		public bool __Gen_Wrap_24(object P0, object P1) => default; // 0x00000001815D5950-0x00000001815D5D10
		public int __Gen_Wrap_25(object P0, object P1, object P2) => default; // 0x0000000181F364F0-0x0000000181F36990
		public string __Gen_Wrap_26(object P0, object P1) => default; // 0x0000000183E8FBE0-0x0000000183E90610
		public int __Gen_Wrap_27(WindowsGpuDriverVersion.Result P0, WindowsGpuDriverVersion.Result P1) => default; // 0x000000018135A390-0x000000018135A720
		public List<WindowsGpuDriverVersion.Result> __Gen_Wrap_28() => default; // 0x0000000183E90610-0x0000000183E90E50
		public bool __Gen_Wrap_29() => default; // 0x000000018138FF00-0x00000001813900C0
		public void __Gen_Wrap_30(int P0) {} // 0x0000000181389D90-0x0000000181389F80
		public WindowsGpuDriverVersion.Result __Gen_Wrap_31() => default; // 0x0000000183E90E50-0x0000000183E91690
		public bool __Gen_Wrap_32(object P0, object P1, out string P2) {
			P2 = default;
			return default;
		} // 0x0000000183E91690-0x0000000183E921D0
		public IEnumerator __Gen_Wrap_33(object P0, object P1, object P2) => default; // 0x0000000183E921D0-0x0000000183E92CD0
		public int __Gen_Wrap_34() => default; // 0x000000018136ACA0-0x000000018136AE70
		public void __Gen_Wrap_35(int P0, ref int P1) {} // 0x0000000183E92CD0-0x0000000183E92F00
		public IEnumerator __Gen_Wrap_36(object P0, int P1, int P2, object P3) => default; // 0x0000000183E92F00-0x0000000183E93950
		public IEnumerator __Gen_Wrap_37(bool P0) => default; // 0x0000000183E93950-0x0000000183E941D0
		public IEnumerator __Gen_Wrap_38(object P0, int P1, int P2) => default; // 0x0000000183E941D0-0x0000000183E94B40
		public IEnumerator __Gen_Wrap_39(object P0) => default; // 0x0000000183E94B40-0x0000000183E95470
		public bool __Gen_Wrap_40(ref SceneStateAreaKey P0, SceneStateAreaKey P1) => default; // 0x0000000183E95470-0x0000000183E96110
		public bool __Gen_Wrap_41(ref SceneStateAreaKey P0, object P1) => default; // 0x0000000183E96110-0x0000000183E96DB0
		public int __Gen_Wrap_42(ref SceneStateAreaKey P0) => default; // 0x0000000183E96DB0-0x0000000183E97960
		public float __Gen_Wrap_43(object P0) => default; // 0x00000001816A5430-0x00000001816A56F0
		public bool __Gen_Wrap_44(object P0, bool P1) => default; // 0x0000000181545670-0x0000000181545960
		public bool __Gen_Wrap_45(object P0, float P1, int P2) => default; // 0x0000000183E97960-0x0000000183E97C80
		public Dictionary<int, float> __Gen_Wrap_46(object P0) => default; // 0x0000000183E97C80-0x0000000183E985C0
		public void __Gen_Wrap_47(object P0, object P1) {} // 0x00000001815704E0-0x0000000181570890
		public EntityRenderCapturedEntity __Gen_Wrap_48(object P0, object P1) => default; // 0x0000000183E985C0-0x0000000183E98FE0
		public int __Gen_Wrap_49(object P0, object P1) => default; // 0x0000000181385520-0x00000001813858D0
		public EntityVFXRendererMask __Gen_Wrap_50(EntityVFXRendererType P0) => default; // 0x000000018179F480-0x000000018179F680
		public void __Gen_Wrap_51(object P0, object P1, object P2) {} // 0x00000001816167B0-0x0000000181616C40
		public void __Gen_Wrap_52(object P0, object P1, object P2, object P3) {} // 0x00000001815B7830-0x00000001815B7DA0
		public Material __Gen_Wrap_53(object P0, EntityRenderHelperMaterialController.AddedMaterialInfo P1, object P2) => default; // 0x0000000183E98FE0-0x0000000183E99DB0
		public Texture __Gen_Wrap_54(object P0, object P1) => default; // 0x0000000183E99DB0-0x0000000183E9A7E0
		public int __Gen_Wrap_55(object P0, object P1, EntityVFXRendererMask P2, AddMaterialConfig P3) => default; // 0x0000000183E9A7E0-0x0000000183E9AFB0
		public List<EntityRenderHelperMaterialController.RendererInfo> __Gen_Wrap_56(object P0, EntityVFXRendererMask P1, bool P2) => default; // 0x0000000183E9AFB0-0x0000000183E9B940
		public void __Gen_Wrap_57(object P0, int P1, float P2) {} // 0x00000001821E10F0-0x00000001821E13E0
		public float __Gen_Wrap_58(object P0, int P1, float P2) => default; // 0x000000018293AF90-0x000000018293B290
		public void __Gen_Wrap_59(object P0, int P1, Vector4 P2) {} // 0x0000000183E9B940-0x0000000183E9BFB0
		public Vector4 __Gen_Wrap_60(object P0, int P1, Vector4 P2) => default; // 0x0000000183E9BFB0-0x0000000183E9CC70
		public void __Gen_Wrap_61(object P0, int P1, object P2) {} // 0x000000018156A670-0x000000018156AA00
		public Texture __Gen_Wrap_62(object P0, int P1, object P2) => default; // 0x0000000183E9CC70-0x0000000183E9D6A0
		public EntityVFXRendererMask __Gen_Wrap_63(object P0, int P1) => default; // 0x00000001815A3640-0x00000001815A3930
		public bool __Gen_Wrap_64(object P0, int P1, object P2) => default; // 0x0000000181361A80-0x0000000181361E60
		public void __Gen_Wrap_65(object P0, int P1, EntityVFXRendererMask P2) {} // 0x0000000181550090-0x0000000181550380
		public void __Gen_Wrap_66(object P0, EntityVFXRendererMask P1, object P2) {} // 0x0000000181391570-0x0000000181391940
		public void __Gen_Wrap_67(object P0, object P1, bool P2, EntityVFXRendererMask P3) {} // 0x00000001823B3E70-0x00000001823B4220
		public void __Gen_Wrap_68(object P0, bool P1, EntityVFXRendererMask P2) {} // 0x00000001821369B0-0x0000000182136CA0
		public float __Gen_Wrap_69(object P0, float P1, float P2, int P3) => default; // 0x0000000183E9D6A0-0x0000000183E9D9F0
		public void __Gen_Wrap_70(object P0, EntityRenderHelperCustomPerDrawType P1, float P2, EntityVFXRendererMask P3) {} // 0x0000000181F478A0-0x0000000181F47BD0
		public void __Gen_Wrap_71(object P0, EntityRenderHelperVectorCustomPerDrawType P1, Vector4 P2, EntityVFXRendererMask P3) {} // 0x0000000183E9D9F0-0x0000000183E9E0A0
		public void __Gen_Wrap_72(object P0, int P1, float P2, EntityVFXRendererMask P3) {} // 0x0000000181F478A0-0x0000000181F47BD0
		public void __Gen_Wrap_73(object P0, int P1, Vector4 P2, EntityVFXRendererMask P3) {} // 0x0000000183E9E0A0-0x0000000183E9E770
		public void __Gen_Wrap_74(object P0, int P1, object P2, EntityVFXRendererMask P3) {} // 0x0000000182312640-0x00000001823129F0
		public Bounds __Gen_Wrap_75(object P0) => default; // 0x0000000183E9E770-0x0000000183E9F060
		public void __Gen_Wrap_76(object P0, object P1, bool P2) {} // 0x0000000181570C20-0x0000000181570FE0
		public RenderHelperType __Gen_Wrap_77(object P0) => default; // 0x00000001815570F0-0x00000001815573B0
		public List<EntityRendererTypeConfig> __Gen_Wrap_78(object P0, bool P1) => default; // 0x0000000183E9F060-0x0000000183E9F9C0
		public float __Gen_Wrap_79(object P0, bool P1) => default; // 0x0000000183A505A0-0x0000000183A50890
		public EntityVFXPriorityType __Gen_Wrap_80(object P0) => default; // 0x00000001815570F0-0x00000001815573B0
		public void __Gen_Wrap_81(object P0, float P1, bool P2) {} // 0x0000000183E9F9C0-0x0000000183E9FCC0
		public Material __Gen_Wrap_82(object P0, object P1, object P2) => default; // 0x0000000183E9FCC0-0x0000000183EA07C0
		public bool __Gen_Wrap_83(EntityVFXFactoryAddedMaterialManager.AddedMaterialData P0) => default; // 0x00000001813541F0-0x00000001813544C0
		public void __Gen_Wrap_84(object P0, object P1, int P2, float P3) {} // 0x0000000182918100-0x00000001829184B0
		public void __Gen_Wrap_85(object P0, object P1, int P2, Vector4 P3) {} // 0x0000000183EA07C0-0x0000000183EA0F20
		public Material __Gen_Wrap_86(object P0, object P1, Vector4 P2) => default; // 0x0000000183EA0F20-0x0000000183EA1CD0
		public ValueTuple<float, float> __Gen_Wrap_87(Bounds P0, Vector3 P1) => default; // 0x0000000183EA1CD0-0x0000000183EA2C30
		public void __Gen_Wrap_88(object P0, bool P1, Vector3 P2, bool P3, float P4, out float P5, out float P6, out Vector3 P7) {
			P5 = default;
			P6 = default;
			P7 = default;
		} // 0x0000000183EA2C30-0x0000000183EA38B0
		public EntityVFXCurveEvaluateResult __Gen_Wrap_89(object P0, float P1) => default; // 0x0000000183EA38B0-0x0000000183EA4210
		public void __Gen_Wrap_90(object P0, object P1, float P2) {} // 0x0000000183EA4210-0x0000000183EA45E0
		public void __Gen_Wrap_91(object P0, float P1, object P2, object P3) {} // 0x0000000183EA45E0-0x0000000183EA4A50
		public void __Gen_Wrap_92(object P0, object P1, object P2, bool P3) {} // 0x000000018154F3D0-0x000000018154F840
		public void __Gen_Wrap_93(object P0, HGPsoExtInfo P1) {} // 0x0000000183EA4A50-0x0000000183EA50D0
		public void __Gen_Wrap_94(bool P0) {} // 0x0000000181390A70-0x0000000181390C60
		public void __Gen_Wrap_95(bool P0, object P1, object P2) {} // 0x00000001813671E0-0x0000000181367580
		public void __Gen_Wrap_96(float P0) {} // 0x0000000181363FB0-0x00000001813641A0
		public void __Gen_Wrap_97(object P0, in EventData<string, string> P1) {} // 0x0000000183EA50D0-0x0000000183EA5770
		public List<Vector3> __Gen_Wrap_98(object P0, float P1, int P2) => default; // 0x0000000183EA5770-0x0000000183EA60F0
		public Vector3 __Gen_Wrap_99(object P0, Vector2Int P1) => default; // 0x0000000183EA60F0-0x0000000183EAA150
		public List<Vector3> __Gen_Wrap_100(object P0, Vector3 P1) => default; // 0x0000000183E80B20-0x0000000183E81800
		public Vector2Int __Gen_Wrap_101(object P0, Vector3 P1) => default; // 0x0000000183E81800-0x0000000183E82450
		public int __Gen_Wrap_102(int P0, int P1, int P2) => default; // 0x00000001826DBE30-0x00000001826DC060
		public void __Gen_Wrap_103(int P0, int P1) {} // 0x0000000181355000-0x0000000181355200
		public void __Gen_Wrap_104(int P0, int P1, int P2, int P3, object P4) {} // 0x0000000183E82450-0x0000000183E82770
		public UnityEngine.Color __Gen_Wrap_105(object P0, int P1, int P2) => default; // 0x0000000183E82770-0x0000000183E83090
		public float[] __Gen_Wrap_106(int P0, float P1) => default; // 0x0000000183E83090-0x0000000183E83920
		public float[,] __Gen_Wrap_107(object P0, object P1, Vector2Int P2) => default; // 0x0000000183E83920-0x0000000183E84700
		public int __Gen_Wrap_108(object P0, int P1, int P2) => default; // 0x000000018163A7A0-0x000000018163AA90
		public void __Gen_Wrap_109(Bounds P0, object P1, out Vector3 P2, out Vector3 P3, Vector3? P4) {
			P2 = default;
			P3 = default;
		} // 0x0000000183E84700-0x0000000183E85690
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_110(Vector3 P0, Vector3 P1) => default; // 0x0000000183E85690-0x0000000183E86330
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_111(Vector3 P0, float P1) => default; // 0x0000000183E86330-0x0000000183E86F10
		public List<Vector3> __Gen_Wrap_112(object P0, float P1, int P2, bool P3, float P4) => default; // 0x0000000183E86F10-0x0000000183E878D0
		public Vector3 __Gen_Wrap_113(ref VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P0, Vector3 P1) => default; // 0x0000000183E878D0-0x0000000183E88870
		public void __Gen_Wrap_114(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, out List<Vector2> P2, out List<float> P3, out float P4, out float P5, out float P6, out float P7) {
			P2 = default;
			P3 = default;
			P4 = default;
			P5 = default;
			P6 = default;
			P7 = default;
		} // 0x0000000183E88870-0x0000000183E898F0
		public int __Gen_Wrap_115(int P0, int P1) => default; // 0x00000001822A4B50-0x00000001822A4D60
		public List<int> __Gen_Wrap_116(object P0) => default; // 0x0000000183E898F0-0x0000000183E8A220
		public float __Gen_Wrap_117(object P0, int P1, bool P2) => default; // 0x0000000183E8A220-0x0000000183E8A520
		public float __Gen_Wrap_118(Vector2 P0, Vector2 P1, Vector2 P2) => default; // 0x0000000183E8A520-0x0000000183E8ACC0
		public List<int> __Gen_Wrap_119(object P0, bool P1, float P2, float P3, float P4) => default; // 0x0000000183E8ACC0-0x0000000183E8B6C0
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult __Gen_Wrap_120(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, float P2, int P3, bool P4, VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode P5, float P6, float P7, float P8) => default; // 0x0000000183E8B6C0-0x0000000183E8C390
		public List<Vector2> __Gen_Wrap_121(object P0, float P1, int P2, int P3, bool P4, bool P5) => default; // 0x0000000183E8C390-0x0000000183E8CD70
		public List<Vector3> __Gen_Wrap_122(object P0, float P1, float P2, bool P3) => default; // 0x0000000183E8CD70-0x0000000183E8D760
		public void __Gen_Wrap_123(object P0, ref List<Vector2> P1, int P2, bool P3, bool P4, bool P5) {} // 0x0000000183E8D760-0x0000000183E8E270
		public List<Vector3> __Gen_Wrap_124(object P0, object P1, float P2) => default; // 0x0000000183E8E270-0x0000000183E8ECC0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object>, IAsyncStateMachine // TypeDefIndex: 56354
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
		object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B505200-0x000000018B5052AC 
		object IEnumerator.Current { get => default; } // 0x000000018B5052AC-0x000000018B505358 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018B505358-0x000000018B50544C
	
		// Methods
		void IDisposable.Dispose() {} // 0x00000001873416FC-0x0000000187341778
		private bool MoveNext() => default; // 0x0000000187341518-0x00000001873415A4
		void IEnumerator.Reset() {} // 0x00000001872E7280-0x00000001872E72FC
		private void MoveNext() {} // 0x000000018B3D5578-0x000000018B3D5608
		private void SetStateMachine(IAsyncStateMachine P0) {} // 0x000000018B3D57D8-0x000000018B3D5888
		public void RefAwaitUnsafeOnCompleteMethod() {} // 0x000000018B505174-0x000000018B505200
		public void RefAsyncBuilderStartMethod() {} // 0x000000018B505130-0x000000018B505174
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 56355
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018B507AF8-0x000000018B507B5C
		public static bool IsPatched(int id) => default; // 0x000000018421EE40-0x000000018421EEE0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018B5079B4-0x000000018B507A80
		public object CreateWrapper(int id) => default; // 0x000000018B507A80-0x000000018B507AF8
		public object InitWrapperArray(int len) => default; // 0x000000018B507B5C-0x000000018B5083FC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018B507910-0x000000018B5079B4
	}

	public enum IDMAP0 // TypeDefIndex: 56356
	{
		HG-Rendering-Runtime-ContainerWaterManager-Start0 = 0,
		HG-Rendering-Runtime-ContainerWaterManager-_InitializeWaveSystem0 = 1,
		HG-Rendering-Runtime-ContainerWaterManager-_PrecomputeCylinderMask0 = 2,
		HG-Rendering-Runtime-ContainerWaterManager-_UnifiedWaveStep0 = 3,
		HG-Rendering-Runtime-ContainerWaterManager-_ApplyReflectiveBoundary0 = 4,
		HG-Rendering-Runtime-ContainerWaterManager-_IsInsideCylinder0 = 5,
		HG-Rendering-Runtime-ContainerWaterManager-_ApplyAbsorptiveBoundary0 = 6,
		HG-Rendering-Runtime-ContainerWaterManager-_FindNearestInsidePoint0 = 7,
		HG-Rendering-Runtime-ContainerWaterManager-_WorldToTextureCoords0 = 8,
		HG-Rendering-Runtime-ContainerWaterManager-_IsValidPosition0 = 9,
		HG-Rendering-Runtime-ContainerWaterManager-_ApplyMatrixToTexture0 = 10,
		HG-Rendering-Runtime-ContainerWaterManager-_UpdateVortexState0 = 11,
		HG-Rendering-Runtime-ContainerWaterManager-ResetWaveTexture0 = 12,
		HG-Rendering-Runtime-ContainerWaterManager-Update0 = 13,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_LitDissolve0 = 14,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_HoudiniVAT0 = 15,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_MovingBamboo0 = 16,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveColor0 = 17,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_EmissiveAlbedoColor0 = 18,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_SweepLightIntensity0 = 19,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_UVAnimation0 = 20,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_CharacterParams0 = 21,
		Beyond-Rendering-CustomPerDrawDataChannelUtils-SetPerDrawData_VFXAlpha00 = 22,
		Beyond-Rendering-PipelineSettingHelper-LoadPipelineSettings0 = 23,
		Beyond-Rendering-PipelineSettingHelper-_GetFullSettingPath0 = 24,
		Beyond-Rendering-PipelineSettingHelper-_LoadSetting0 = 25,
		Beyond-Rendering-ResourceRouter-_GetCategoryFolder0 = 26,
		Beyond-Rendering-ResourceRouter-GetEnvironmentsFullPath0 = 27,
		Beyond-Rendering-ResourceRouter-GetDecalResourcesPath0 = 28,
		Beyond-Rendering-ResourceRouter-GetDecalResourcesFullPath0 = 29,
		Beyond-Rendering-ShaderWarmupManager-GetPsoName0 = 30,
		Beyond-Rendering-ShaderWarmupManager-GetPsoName1 = 31,
		Beyond-Rendering-ShaderWarmupManager-GetPsoPath0 = 32,
		Beyond-Rendering-ShaderWarmupManager-GetLoginWarmupDetail0 = 33,
		Beyond-Rendering-ShaderWarmupManager-_GetCacheFileSize0 = 34,
		Beyond-Rendering-ShaderWarmupManager-ProcessRemoteConfig0 = 35,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsDeviceInBlackList0 = 36,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-_CheckDeviceMatch0 = 37,
		Beyond-Rendering-ShaderWarmupManagerRemoteCfg-IsEnableDx11DriverVersionDetect0 = 38,
		Beyond-Rendering-ShaderWarmupManager-MarkNeedShaderWarmUp0 = 39,
		Beyond-Rendering-ShaderWarmupManager-MarkWarmUpLoginFinish0 = 40,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmupFinishAPI0 = 41,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmUpLoginFinish0 = 42,
		Beyond-Rendering-ShaderWarmupManager-_MarkWarmupDx11Driver0 = 43,
		Beyond-Rendering-WindowsGpuDriverVersion-GetAllDisplayDriverVersions0 = 44,
		Beyond-Rendering-WindowsGpuDriverVersion-_GetDeviceRegistryPropertyString0 = 45,
		Beyond-Rendering-WindowsGpuDriverVersion-_ScoreAgainstUnityCurrentGpu0 = 46,
		Beyond-Rendering-WindowsGpuDriverVersion-_ContainsIgnoreCase0 = 47,
		Beyond-Rendering-WindowsGpuDriverVersion-_GetDriverKeySuffix0 = 48,
		Beyond-Rendering-WindowsGpuDriverVersion-_ReadRegistrySz0 = 49,
		Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllResults0 = 53,
		Beyond-Rendering-ShaderWarmupManager-CleanLoadedPso0 = 54,
		Beyond-Rendering-ShaderWarmupManager-TryRepairPsoCacheAfterCorruptCheck0 = 55,
		Beyond-Rendering-ShaderWarmupManager-_TryDeleteVulkanPsoCacheFile0 = 56,
		Beyond-Rendering-ShaderWarmupManager-CheckNeedWarmUpLogin0 = 57,
		Beyond-Rendering-ShaderWarmupManager-_ResetWarmUpStats0 = 58,
		Beyond-Rendering-ShaderWarmupManager-_IsDeviceSupportWarmUp0 = 59,
		Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByFirstEntry0 = 60,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByGraphicsChange0 = 61,
		Beyond-Rendering-ShaderWarmupManager-_SetWarmupRetryCount0 = 62,
		Beyond-Rendering-ShaderWarmupManager-_SetWarmupUnfinishedCount0 = 63,
		Beyond-Rendering-ShaderWarmupManager-_CheckWarmUpUnfinishedOften0 = 64,
		Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByDeviceState0 = 65,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupDx11Driver0 = 66,
		Beyond-Rendering-WindowsGpuDriverVersion-IsBestMatchDriverVersionChanged0 = 67,
		Beyond-Rendering-WindowsGpuDriverVersion-GetBestMatch0 = 68,
		Beyond-Rendering-WindowsGpuDriverVersion-_TryGetDriverVersionByKeyId0 = 69,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByCacheOutdated0 = 70,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersLogin0 = 71,
		Beyond-Rendering-ShaderWarmupManager-_LoadPsoAssets0 = 75,
		Beyond-Rendering-ShaderWarmupManager-_GetLoginTimeLimit0 = 82,
		Beyond-Rendering-ShaderWarmupManager-_WarmupOnePsoTimeLimited0 = 83,
		Beyond-Rendering-PsoCreateUploadHelper-BeforeWarmUpBegin0 = 87,
		Beyond-Rendering-PsoCreateUploadHelper-IsPsoRecordEnabled0 = 88,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Tick0 = 89,
		Beyond-Rendering-ShaderWarmupManager-_StepProgress0 = 92,
		Beyond-Rendering-PsoCreateUploadHelper-AfterWarmUpFinish0 = 93,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersScene0 = 100,
		Beyond-Rendering-ShaderWarmupManager-WarmupOnePso0 = 104,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Begin0 = 114,
		Beyond-Rendering-WindowsGpuDriverVersion-GetCurrentDriverVersion0 = 115,
		Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllCurrentResults0 = 116,
		Beyond-Rendering-WindowsGpuDriverVersion-Result-ToString0 = 117,
		Beyond-Rendering-WindowsGpuDriverVersion-SafeRegistryHandle-ReleaseHandle0 = 118,
		Beyond-Rendering-SceneStateAreaKey-Equals0 = 119,
		Beyond-Rendering-SceneStateAreaKey-Equals1 = 120,
		Beyond-Rendering-SceneStateAreaKey-GetHashCode0 = 121,
		Beyond-Rendering-EntityRenderAlphaDitherController-ResetDitherAlpha0 = 122,
		Beyond-Rendering-EntityRenderAlphaDitherController-_ApplyNewAlpha0 = 123,
		Beyond-Rendering-EntityRenderAlphaDitherController-_GetCurMinAlpha0 = 124,
		Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherEnabled0 = 125,
		Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherAlpha0 = 126,
		Beyond-Rendering-EntityRenderAlphaDitherController-SetDitherAlpha0 = 127,
		Beyond-Rendering-EntityRenderAlphaDitherController-GetDitherAlpha0 = 128,
		Beyond-Rendering-EntityRenderAlphaDitherController-Reset0 = 129,
		Beyond-Rendering-EntityRenderAlphaDitherController-GetAlphaDictionary0 = 130,
		Beyond-Rendering-EntityRenderCaptureMeshController-Reset0 = 131,
		Beyond-Rendering-EntityRenderCaptureMeshController-Release0 = 132,
		Beyond-Rendering-EntityRenderCaptureMeshController-LateTick0 = 133,
		Beyond-Rendering-EntityRenderCaptureMeshController-_SyncTransformInRenderPipeline0 = 134,
		Beyond-Rendering-EntityRenderCaptureMeshController-Capture0 = 135,
		Beyond-Rendering-EntityRenderHelperMaterialController-Init0 = 136,
		Beyond-Rendering-EntityRenderHelperMaterialController-_GetSubMeshCount0 = 137,
		Beyond-Rendering-EntityVFXUtils-ToMask0 = 138,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Init0 = 139,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Init0 = 140,
		Beyond-Rendering-EntityRenderHelperMaterialController-OnRelease0 = 141,
		Beyond-Rendering-EntityRenderHelperMaterialController-Reset0 = 142,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Reset0 = 143,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-ApplySharedMaterialArray0 = 144,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_GetCustomizePropertyMaterial0 = 145,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Reset0 = 146,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReleaseAllReplaceMaterial0 = 147,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReplaceSharedMaterial0 = 148,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-Clear0 = 149,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Reset0 = 150,
		Beyond-Rendering-EntityRenderHelperMaterialController-IsAllRendererValid0 = 151,
		Beyond-Rendering-EntityRenderHelperMaterialController-StopShadowCasting0 = 152,
		Beyond-Rendering-EntityRenderHelperMaterialController-RevertShadowCastingMode0 = 153,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddMaterialToAllRenderer0 = 154,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireAddMaterial0 = 155,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_InitCustomizeRendererProperty0 = 156,
		Beyond-Rendering-EntityCustomizeRendererPropertyConfig-GetColorTexture0 = 157,
		Beyond-Rendering-EntityRenderHelperMaterialController-_GetRenderersOfRendererMask0 = 158,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveFloatProperty0 = 159,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveFloatProperty0 = 160,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveFloatProperty0 = 161,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveFloatProperty0 = 162,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveVectorProperty0 = 163,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveVectorProperty0 = 164,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveVectorProperty0 = 165,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveVectorProperty0 = 166,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveTextureProperty0 = 167,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveTextureProperty0 = 168,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveTextureProperty0 = 169,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveTextureProperty0 = 170,
		Beyond-Rendering-EntityRenderHelperMaterialController-RemoveMaterialFromAllRenderer0 = 171,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireRemoveMaterial0 = 172,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 173,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 174,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetKeywordEnableToAllMaterial0 = 175,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetKeywordEnableToAllMaterial0 = 176,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_GetAffectGroupData0 = 177,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_SplitRenderers0 = 178,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-CopyFrom0 = 179,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CopyReplaceMaterial0 = 180,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CreateReplaceMaterial0 = 181,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 182,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 183,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToCustomPerDraw0 = 184,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Init0 = 185,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetFloatToCustomPerDraw0 = 186,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-_PackUNorm8ToFloat0 = 187,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToCustomPerDraw0 = 188,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetVectorToCustomPerDraw0 = 189,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToAllMaterial0 = 190,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetFloatToAllMaterial0 = 191,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToAllMaterial0 = 192,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetVectorToAllMaterial0 = 193,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetTextureToAllMaterial0 = 194,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetTextureToAllMaterial0 = 195,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherAlphaValue0 = 196,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherEnable0 = 197,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetRendererBounds0 = 198,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetZTestInMaterial0 = 199,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetZTestInMaterial0 = 200,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetRenderHelperType0 = 201,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseFloatToAllMaterial0 = 202,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseVectorToAllMaterial0 = 203,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseTextureToAllMaterial0 = 204,
		Beyond-Rendering-EntityRenderHelperVisibleController-Init0 = 205,
		Beyond-Rendering-EntityRenderHelperVisibleController-_InitDictionary0 = 206,
		Beyond-Rendering-EntityRenderHelperVisibleController-Release0 = 207,
		Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByNameContainsStr0 = 208,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-get_rendererName0 = 209,
		Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByRenderer0 = 210,
		Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByNameContainsStr0 = 211,
		Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByRenderer0 = 212,
		Beyond-Rendering-EntityRenderHelperVisibleController-Reset0 = 213,
		Beyond-Rendering-EntityRenderMaterialManager-SetFloat0 = 214,
		Beyond-Rendering-EntityRenderMaterialManager-SetTexture0 = 215,
		Beyond-Rendering-EntityRenderMaterialManager-SetVector0 = 216,
		Beyond-Rendering-EntityRenderMaterialManager-AddMaterial0 = 217,
		Beyond-Rendering-EntityRenderMaterialManager-RemoveMaterial0 = 218,
		Beyond-Rendering-EntityRenderMaterialManager-_RevertMaterial0 = 219,
		Beyond-Rendering-EntityRenderMaterialManager-ClearMaterials0 = 220,
		Beyond-Rendering-EntityRenderMaterialManager-SetKeywordEnable0 = 221,
		Beyond-Rendering-EntityRenderMaterialManager-SetDepthOnlyEnabled0 = 222,
		Beyond-Rendering-EntityRenderMaterialManager-SetZTestInMaterial0 = 223,
		Beyond-Rendering-EntityVFXAsset-GetRendererTypeConfigs0 = 224,
		Beyond-Rendering-EntityVFXAssetBase-get_assetName0 = 225,
		Beyond-Rendering-EntityVFXControllerBase-SetOwner0 = 226,
		Beyond-Rendering-EntityVFXControllerBase-InitLOD0 = 227,
		Beyond-Rendering-EntityVFXControllerBase-SetName0 = 228,
		Beyond-Rendering-EntityVFXControllerBase-Destroy0 = 229,
		Beyond-Rendering-EntityVFXControllerBase-Stop0 = 230,
		Beyond-Rendering-EntityVFXControllerBase-OnDestroy0 = 231,
		Beyond-Rendering-EntityVFXControllerBase-Play0 = 232,
		Beyond-Rendering-EntityVFXControllerBase-Replay0 = 233,
		Beyond-Rendering-EntityVFXControllerBase-Tick0 = 234,
		Beyond-Rendering-EntityVFXControllerBase-RefreshLastTickTime0 = 235,
		Beyond-Rendering-EntityVFXControllerBase-GetDeltaTimeFromLastTick0 = 236,
		Beyond-Rendering-EntityVFXControllerBase-GetPriorityType0 = 237,
		Beyond-Rendering-EntityVFXControllerBase-GetNeedTick0 = 238,
		Beyond-Rendering-EntityVFXControllerBase-Hide0 = 239,
		Beyond-Rendering-EntityVFXControllerBase-OnHide0 = 240,
		Beyond-Rendering-EntityVFXControllerBase-Show0 = 241,
		Beyond-Rendering-EntityVFXControllerBase-OnShow0 = 242,
		Beyond-Rendering-EntityVFXControllerBase-Sample0 = 243,
		Beyond-Rendering-EntityVFXControllerBase-OnSample0 = 244,
		Beyond-Rendering-EntityVFXControllerStateBase-Play0 = 245,
		Beyond-Rendering-EntityVFXControllerStateBase-Replay0 = 249,
		Beyond-Rendering-EntityVFXControllerStateBase-Stop0 = 250,
		Beyond-Rendering-EntityVFXControllerStateBase-_FinalStop0 = 251,
		Beyond-Rendering-EntityVFXControllerStateBase-GetNeedTick0 = 252,
		Beyond-Rendering-EntityVFXControllerStateBase-Tick0 = 253,
		Beyond-Rendering-EntityVFXControllerStateBase-OnSample0 = 257,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-Init0 = 258,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_AddVATMaterial0 = 259,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetVATMaterial0 = 260,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetAddedMaterialIndex0 = 261,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_RemoveVATMaterial0 = 264,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-AddMaterialToAllRenderer0 = 267,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-RemoveMaterialFromAllRenderer0 = 268,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetFloatToFactoryMaterial0 = 269,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetVectorToFactoryMaterial0 = 270,
		Beyond-Rendering-EntityVFXFactoryMaterialCache-GetVATMaterial0 = 271,
		Beyond-Rendering-EntityVFXFactoryMaterialCache-ReleaseVATMaterial0 = 272,
		Beyond-Rendering-EntityVFXUtils-CalculateCutOffBounds0 = 273,
		Beyond-Rendering-EntityVFXUtils-GetBoundsMinMaxOfDirection0 = 274,
		Beyond-Rendering-EntityVFXUtils-ApplyEntityVFXCurves0 = 275,
		Beyond-Rendering-EntityVFXUtils-_UpdateCurve0 = 276,
		Beyond-Rendering-EntityVFXUtils-Evaluate0 = 277,
		Beyond-Rendering-CommonVAT-get_PropertySetterType0 = 278,
		Beyond-Rendering-CommonVAT-Start0 = 279,
		Beyond-Rendering-CommonVAT-Play0 = 280,
		Beyond-Rendering-CommonVAT-_DoPlay0 = 281,
		Beyond-Rendering-CommonVAT-_ClearTimer0 = 282,
		Beyond-Rendering-CommonVAT-_UpdateProperty0 = 283,
		Beyond-Rendering-CommonVAT-_NextPlay0 = 284,
		Beyond-Rendering-CommonVAT-_CreateTimer0 = 285,
		Beyond-Rendering-FactoryVAT-Start0 = 286,
		Beyond-Rendering-FactoryVAT-_InitRenderer0 = 287,
		Beyond-Rendering-FactoryVAT-_InitRenderer_MeshRender0 = 288,
		Beyond-Rendering-FactoryVAT-Reset0 = 289,
		Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer0 = 290,
		Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer_MeshRender0 = 291,
		Beyond-Rendering-FactoryVAT-_UpdateAnim0 = 292,
		Beyond-Rendering-FactoryVAT-_SetParamsToRenderer0 = 293,
		Beyond-Rendering-FactoryVAT-_SetParamsToRenderer_MeshRender0 = 294,
		Beyond-Rendering-FactoryVAT-_DoPlay0 = 295,
		Beyond-Rendering-FactoryVAT-OnUpdate0 = 296,
		Beyond-Rendering-FactoryVAT-Play0 = 297,
		Beyond-Rendering-VATRendererPropertySetter-Init0 = 298,
		Beyond-Rendering-VATRendererPropertySetter-SetFloat0 = 299,
		Beyond-Rendering-VATRendererPropertySetter-SetVector0 = 300,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-Init0 = 301,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetFloat0 = 302,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetVector0 = 303,
		Beyond-Rendering-PsoCreateUploadHelper-Initialize0 = 304,
		Beyond-Rendering-PsoCreateUploadHelper-_PsoUploadProcessOneCallBack0 = 305,
		Beyond-Rendering-PsoCreateUploadHelper-_PsoUpdateGameInfoCallBack0 = 306,
		Beyond-Rendering-PsoCreateUploadHelper-Init0 = 307,
		Beyond-Rendering-PsoCreateUploadHelper-_Tick0 = 308,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadPipelineCreatedInfo0 = 309,
		Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFinalJson0 = 310,
		Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFileToServer0 = 313,
		Beyond-Rendering-PsoCreateUploadHelper-_Callback0 = 314,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadFileToServer0 = 315,
		Beyond-Rendering-PsoCreateUploadHelper-_SceneLoadStartHandler0 = 323,
		Beyond-Rendering-PsoCreateUploadHelper-Dispose0 = 324,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadFile0 = 325,
		Beyond-Rendering-VFXSludgeBaker-Bake0 = 328,
		Beyond-Rendering-VFXSludgeBaker-_CalculatePolygonAndBounds0 = 329,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSpline0 = 330,
		Beyond-Rendering-VFXSludgeBaker-_RaycastSceneObjectsHeight0 = 331,
		Beyond-Rendering-VFXSludgeBaker-GetLocalPosition0 = 332,
		Beyond-Rendering-VFXSludgeBaker-_CalculateInPolygon0 = 333,
		Beyond-Rendering-VFXSludgeUtils-CalculatePointPolygonHorizonRayCross0 = 334,
		Beyond-Rendering-VFXSludgeBaker-GetLocalIndex0 = 335,
		Beyond-Rendering-VFXSludgeBaker-_CalculateInHighPowerZone0 = 336,
		Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance1 = 337,
		Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance0 = 338,
		Beyond-Rendering-VFXSludgeBaker-_GetHash0 = 341,
		Beyond-Rendering-VFXSludgeBaker-_ForAround0 = 342,
		Beyond-Rendering-VFXSludgeBaker-_CalculateThicknessAndTopHeight0 = 345,
		Beyond-Rendering-VFXSludgeBaker-_BlurTopHeight0 = 346,
		Beyond-Rendering-VFXSludgeBaker-_CalculateNormals0 = 347,
		Beyond-Rendering-VFXSludgeBaker-_CreateTexture0 = 348,
		Beyond-Rendering-VFXSludgeBaker-_GetTextureColor10 = 349,
		Beyond-Rendering-VFXSludgeBaker-_CreateGaussianKernel0 = 350,
		Beyond-Rendering-VFXSludgeBaker-_Convolution0 = 351,
		Beyond-Rendering-VFXSludgeBaker-_GetHash1 = 352,
		Beyond-Rendering-VFXSludgeBaker-_GetTextureColor20 = 353,
		Beyond-Rendering-VFXSludgeNavUtils-BoundsUtil-GetTopBottomPoints0 = 354,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameFromPlaneNormal0 = 355,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameByYaw0 = 356,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-SampleUniformByArcLength0 = 357,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ProjectWorldToFrameXZ0 = 358,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-WorldToFrame0 = 359,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ConvexHullIndices0 = 360,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_AngleDegAt0 = 364,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_CurvatureAt0 = 365,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_PointToSegmentDistance2D0 = 366,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Simplify2D_ByCurvatureAngleDeviation0 = 367,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Process0 = 368,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-FrameToWorld0 = 369,
		Beyond-Rendering-VFXSludgeNavUtils-SplineSamplingUtils-SampleByArcLength0 = 370,
		Beyond-Rendering-VFXSludgeNavUtils-PolySimplify-SimplifyByAngle0 = 371,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSplineWithSimplify0 = 372,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffByPolyLine0 = 373,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_CreateInstance0 = 374,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_ExtractSplineData0 = 375,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_DestroyInstance0 = 376,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_Release0 = 377,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Update0 = 378,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnEnable0 = 379,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDisable0 = 380,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDestroy0 = 381,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDrawGizmosSelected0 = 382,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Pause0 = 383,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Play0 = 384,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Stop0 = 385,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-OnEnable0 = 386,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-Awake0 = 387,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-_RendererInfoTransfer0 = 388,
		Beyond-Rendering-LODLightmapping-LODLightmapping-RendererInfoTransfer0 = 389
	}
}
