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

// Image 38: Rendering.Beyond.dll - Assembly: Rendering.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55221-55362
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DisallowMultipleComponent]
[ExecuteInEditMode]
public class LDstaticObjectLightmappingDataLoader : MonoBehaviour // TypeDefIndex: 55222
{
	// Fields
	public bool test; // 0x18
	public bool recover; // 0x19
	public Renderer[] ldLightmappedRenderer; // 0x20
	public int[] ldLightmappedRendererLightmapIndex; // 0x28
	public Vector4[] ldLightmappedRendererLightmapUvScale; // 0x30

	// Constructors
	public LDstaticObjectLightmappingDataLoader() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	public void RecoverLightmapdata() {} // 0x00000001893CB218-0x00000001893CB3AC
}

namespace Beyond.Rendering
{
	public class CustomPerDrawDataChannelUtils // TypeDefIndex: 55231
	{
		// Fields
		public const int HOUDINI_VAT_INDEX = 3; // Metadata: 0x01FD6AA8
		public const int HOUDINI_VAT_CHANNEL = 0; // Metadata: 0x01FD6AA9
		public const int LIT_EMISSIVE_INDEX = 2; // Metadata: 0x01FD6AAA
		public const int LIT_EMISSIVE_ANIMATION_SWEEP_INDEX = 3; // Metadata: 0x01FD6AAB
		public const int LIT_EMISSIVE_ALBEDO_INDEX = 4; // Metadata: 0x01FD6AAC
		public const int UV_ANIMATION_INDEX = 3; // Metadata: 0x01FD6AAD
		public const int MOVING_BAMBOO_CUR_PARAM_INDEX = 2; // Metadata: 0x01FD6AAE
		public const int MOVING_BAMBOO_LAST_PARAM_INDEX = 3; // Metadata: 0x01FD6AAF
		public const int LIT_DISSOLVE_INDEX = 4; // Metadata: 0x01FD6AB0
		public const int LIT_DISSOLVE_CHANNEL = 0; // Metadata: 0x01FD6AB1
		public const int CHARACTER_PARAMS_INDEX = 2; // Metadata: 0x01FD6AB2
		public const int CHARACTER_ENVIRONMENT_EFFECT_INTENSITY_CHANNEL = 0; // Metadata: 0x01FD6AB3
		public const int CHARACTER_WET_EFFECT_WORLD_SPACE_HEIGHT_CHANNEL = 1; // Metadata: 0x01FD6AB4
		public const int CHARACTER_DISSOLVE_SCHEDULE_OFFSET_CHANNEL = 3; // Metadata: 0x01FD6AB5
		public const int CHARACTER_RAIN_EFFECT_INTENSITY_CHANNEL_BIT = 8; // Metadata: 0x01FD6AB6
		public const int CHARACTER_WET_EFFECT_INTENSITY_CHANNEL_BIT = 16; // Metadata: 0x01FD6AB7
		public const int CHARACTER_WET_EFFECT_GLOBAL_INTENSITY_CHANNEL_BIT = 24; // Metadata: 0x01FD6AB8
		public const int CHARACTER_SNOW_EFFECT_INTENSITY_CHANNEL_BIT = 32; // Metadata: 0x01FD6AB9
		public const int CHARACTER_PARAMS_CHANNEL_BIT_BIAS = 8; // Metadata: 0x01FD6ABA
		public const int CHANNELS_PER_PARAM = 4; // Metadata: 0x01FD6ABB
		public const int VFX_ALPHA_INDEX = 4; // Metadata: 0x01FD6ABC
		public const int VFX_ALPHA_DEFAULT_CHANNEL = 0; // Metadata: 0x01FD6ABD
	
		// Constructors
		public CustomPerDrawDataChannelUtils() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void SetPerDrawData_LitDissolve(Renderer affectRenderer, float dissolve) {} // 0x00000001893C9028-0x00000001893C90C0
		public static void SetPerDrawData_HoudiniVAT(Renderer affectRenderer, int displayFrame) {} // 0x00000001893C8F8C-0x00000001893C9028
		public static void SetPerDrawData_MovingBamboo(Renderer affectRenderer, Vector4 curParam, Vector4 lastParam) {} // 0x00000001893C90C0-0x00000001893C9180
		public static void SetPerDrawData_EmissiveColor(Renderer affectRenderer, Vector4 emissive) {} // 0x00000001825AD010-0x00000001825AD080
		public static void SetPerDrawData_EmissiveAlbedoColor(Renderer affectRenderer, Vector4 emissiveAlbedo) {} // 0x00000001825AD080-0x00000001825AD0F0
		public static void SetPerDrawData_SweepLightIntensity(Renderer affectRenderer, float intensity) {} // 0x00000001834066A0-0x0000000183406720
		public static void SetPerDrawData_UVAnimation(Renderer affectRenderer, float animationEnable, float customAddTime) {} // 0x00000001893C9180-0x00000001893C9230
		public static void SetPerDrawData_CharacterParams(Renderer affectRenderer, Vector4 param0) {} // 0x0000000182718380-0x0000000182718440
		public static void SetPerDrawData_VFXAlpha0(Renderer affectRenderer, float alpha) {} // 0x00000001893C9230-0x00000001893C92D4
	}

	public static class PipelineSettingHelper // TypeDefIndex: 55232
	{
		// Fields
		public const string SETTING_FOLDER = "Settings/"; // Metadata: 0x01FD6ABE
		public const string SETTING_FILE_LIST = "SettingFiles.txt"; // Metadata: 0x01FD6AC8
	
		// Methods
		public static void LoadPipelineSettings() {} // 0x0000000182F44060-0x0000000182F44970
		private static string _LoadSetting(string settingName) => default; // 0x0000000182F44A20-0x0000000182F44DD0
		private static string _GetFullSettingPath(string settingName) => default; // 0x0000000182F44970-0x0000000182F44A20
	}

	public static class ResourceRouter // TypeDefIndex: 55233
	{
		// Fields
		private const string DYNAMIC_ENVIRONMENTS_FOLDER = "Gameplay/Environments/"; // Metadata: 0x01FD6ADD
	
		// Methods
		private static string _GetCategoryFolder(RootCategory category) => default; // 0x00000001893CB554-0x00000001893CB5DC
		public static string GetEnvironmentsFullPath(RootCategory category = RootCategory.Main /* Metadata: 0x01FD6AD9 */, bool isDevOnly = false /* Metadata: 0x01FD6ADA */) => default; // 0x00000001893CB4B0-0x00000001893CB554
		public static string GetDecalResourcesPath() => default; // 0x00000001893CB450-0x00000001893CB4B0
		public static string GetDecalResourcesFullPath(RootCategory category = RootCategory.Main /* Metadata: 0x01FD6ADB */, bool isDevOnly = false /* Metadata: 0x01FD6ADC */) => default; // 0x00000001893CB3AC-0x00000001893CB450
	}

	public class ShaderWarmupManager // TypeDefIndex: 55241
	{
		// Fields
		public static readonly string RUNTIME_PSO_COLLECTION_FOLDER; // 0x00
		private const string WARM_UP_KEY_WORD = "hg_warm_up_once"; // Metadata: 0x01FD6AF4
		private const string WARM_UP_API_KEY_WORD = "hg_warm_up_graphics"; // Metadata: 0x01FD6B04
		private const string WARM_UP_DRIVER_KEY_WORD = "hg_warm_up_graphics_drivers"; // Metadata: 0x01FD6B18
		private const string WARM_UP_REASON_KEY_WORD = "hg_warm_up_reason"; // Metadata: 0x01FD6B34
		private const string WARMUP_RETRY_COUNT = "hg_warmup_retry_count"; // Metadata: 0x01FD6B46
		private const string WARMUP_UNFINISHED_COUNT = "hg_warmup_unfinished_count"; // Metadata: 0x01FD6B5C
		private const string FEATURE_RAYTRACING = "raytracing"; // Metadata: 0x01FD6B77
		private const string FEATURE_ONE_PASS = "onepass"; // Metadata: 0x01FD6B82
		private const int SHADER_COMPILE_WEIGHT = 2; // Metadata: 0x01FD6B8A
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
		public static bool isWarming { get => default; } // 0x000000018323F060-0x000000018323F0C0 
	
		// Nested types
		public enum WarmUpReason // TypeDefIndex: 55234
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
			RemoteCtrlRetry = 10,
			ShaderCacheApiInvalid = 11,
			DriverVersionUpdate = 12
		}
	
		private class TimeCostCounter // TypeDefIndex: 55235
		{
			// Fields
			private const float MAX_DELTA_TIME = 5f; // Metadata: 0x01FD6B98
			private const float MAX_DELTA_TIME_FIX = 1f; // Metadata: 0x01FD6B9C
			private float m_lastRealTime; // 0x14
			private float m_maxDurationSecond; // 0x18
	
			// Properties
			public float duration { get; set; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
			public bool isTimeOut { get => default; } // 0x00000001893CC8E8-0x00000001893CCC78 
	
			// Constructors
			public TimeCostCounter() {} // Dummy constructor
			public TimeCostCounter(float maxDurationMilliSecond) {} // 0x00000001893CC8D4-0x00000001893CC8E8
	
			// Methods
			public void Begin() {} // 0x00000001893CC808-0x00000001893CC860
			public void Tick() {} // 0x00000001893CC860-0x00000001893CC8D4
		}
	
		// Constructors
		public ShaderWarmupManager() {} // 0x000000018350B670-0x000000018350B680
		static ShaderWarmupManager() {} // 0x000000018398F770-0x0000000183990620
	
		// Methods
		[IDTag(0)]
		public static string GetPsoName(RuntimePlatform platform, GraphicsDeviceType graphicsDeviceType, int shaderLod, string levelId) => default; // 0x00000001893CBC90-0x00000001893CBD68
		[IDTag(1)]
		public static string GetPsoName(RuntimePlatform platform, GraphicsDeviceType graphicsDeviceType, int shaderLod, string levelId, string feature) => default; // 0x00000001893CBBA4-0x00000001893CBC90
		public static string GetPsoPath(string psoName) => default; // 0x00000001893CBD68-0x00000001893CBE38
		public static string GetLoginWarmupDetail() => default; // 0x0000000183CAC710-0x0000000183CAC7C0
		private static long _GetCacheFileSize() => default; // 0x00000001893CC0F4-0x00000001893CC23C
		public static void ProcessRemoteConfig(string remoteConfigStr) {} // 0x0000000183746280-0x0000000183746BA0
		public static void MarkNeedShaderWarmUp(WarmUpReason reason) {} // 0x00000001893CBE38-0x00000001893CBEC8
		public static void MarkWarmUpLoginFinish() {} // 0x00000001893CBEC8-0x00000001893CBF40
		public static void CleanLoadedPso() {} // 0x00000001893CBB48-0x00000001893CBBA4
		private static void _MarkWarmUpLoginFinish() {} // 0x00000001893CC3FC-0x00000001893CC4A4
		public static bool CheckNeedWarmUpLogin() => default; // 0x0000000183745F70-0x00000001837460D0
		[IteratorStateMachine(typeof(_WarmupShadersLogin_d__55))]
		public static IEnumerator WarmupShadersLogin(bool supportsRaytracing) => default; // 0x00000001893CBFF0-0x00000001893CC068
		[IteratorStateMachine(typeof(__LoadPsoAssets_d__56))]
		private static IEnumerator _LoadPsoAssets(List<StringPathHash> resPathList, List<FAssetProxyHandle> assetProxyHandles, List<HGPsoWarmupCollection> loadedAssets) => default; // 0x00000001893CC338-0x00000001893CC3FC
		[IteratorStateMachine(typeof(_WarmupShadersScene_d__57))]
		[Obsolete]
		public static IEnumerator WarmupShadersScene(string scene) => default; // 0x00000001893CC068-0x00000001893CC0F4
		[IteratorStateMachine(typeof(_WarmupOnePso_d__58))]
		[Obsolete]
		public static IEnumerator WarmupOnePso(HGPsoWarmupCollection psoC, int startIndex, int warmupCount) => default; // 0x00000001893CBF40-0x00000001893CBFF0
		[IteratorStateMachine(typeof(__WarmupOnePsoTimeLimited_d__59))]
		private static IEnumerator _WarmupOnePsoTimeLimited(HGPsoWarmupCollection psoC, int startIndex, int desiredWarmupCount, TimeCostCounter timeStart) => default; // 0x00000001893CC738-0x00000001893CC808
		private static void _StepProgress(int newFinishedCount, ref int compileTotalCount) {} // 0x00000001893CC654-0x00000001893CC738
		private static bool _CheckNeedWarmUpByFirstEntry() => default; // 0x0000000182D78130-0x0000000182D78200
		private static bool _CheckNeedWarmUpByDeviceState() => default; // 0x0000000183746E20-0x0000000183748DC0
		private static bool _IsNeedWarmupByGraphicsChange() => default; // 0x0000000182D77F50-0x0000000182D78080
		private static bool _IsNeedWarmupByCacheOutdated() => default; // 0x0000000183748DC0-0x0000000183748EC0
		private static void _SetWarmupRetryCount(int count) {} // 0x00000001893CC564-0x00000001893CC5DC
		private static void _SetWarmupUnfinishedCount(int count) {} // 0x00000001893CC5DC-0x00000001893CC654
		private static void _MarkWarmupFinishAPI() {} // 0x00000001893CC4A4-0x00000001893CC564
		private static bool _IsNeedWarmupDx11Driver() => default; // 0x00000001822397F0-0x000000018223A660
		private static void _MarkWarmupDx11Driver() {} // 0x000000018223A660-0x000000018223B340
		private static void _ResetWarmUpStats() {} // 0x0000000183746140-0x00000001837461C0
		private static bool _IsDeviceSupportWarmUp() => default; // 0x00000001837460D0-0x0000000183746140
		private static bool _IsFeatureEnabled(string featureKeyword) => default; // 0x00000001893CC2B0-0x00000001893CC338
		private static bool _CheckWarmUpUnfinishedOften() => default; // 0x00000001837461C0-0x0000000183746280
		private static int _GetLoginTimeLimit() => default; // 0x00000001893CC23C-0x00000001893CC2B0
	}

	public class ShaderWarmupManagerRemoteCfg // TypeDefIndex: 55245
	{
		// Fields
		[CanBeNull]
		private ShaderWarmupRemoteBlacklist m_blacklist; // 0x10
	
		// Properties
		private static string cpuNameForWarmUp { get => default; } // 0x0000000184273158-0x0000000184273164 
	
		// Nested types
		[Serializable]
		private class ShaderWarmupRemoteBlackDevice // TypeDefIndex: 55242
		{
			// Fields
			public string deviceModel; // 0x10
			public string graphicsDeviceName; // 0x18
			public string graphicsDeviceVersion; // 0x20
			public string os; // 0x28
			public string cpuName; // 0x30
			public string disableFeature; // 0x38
	
			// Constructors
			public ShaderWarmupRemoteBlackDevice() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		private class ShaderWarmupGlobalConfig // TypeDefIndex: 55243
		{
			// Fields
			public bool disableDriverVerDetect; // 0x10
	
			// Constructors
			public ShaderWarmupGlobalConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		private class ShaderWarmupRemoteBlacklist // TypeDefIndex: 55244
		{
			// Fields
			public List<ShaderWarmupRemoteBlackDevice> devices; // 0x10
			public ShaderWarmupGlobalConfig config; // 0x18
	
			// Constructors
			public ShaderWarmupRemoteBlacklist() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public ShaderWarmupManagerRemoteCfg() {} // Dummy constructor
		public ShaderWarmupManagerRemoteCfg(string blackListStr) {} // 0x0000000183746BA0-0x0000000183746C10
	
		// Methods
		public bool IsEnableDx11DriverVersionDetect() => default; // 0x0000000182238C80-0x00000001822397F0
		public bool IsDeviceInBlackList(out string disabledFeature) {
			disabledFeature = default;
			return default;
		} // 0x0000000183746C10-0x0000000183746E20
		private static bool _CheckDeviceMatch(ShaderWarmupRemoteBlackDevice blacklistDevice, string currentDeviceModel, string currentGraphicsDeviceName, string currentGraphicsDeviceVersion, string currentProcessorType, string currentOS) => default; // 0x00000001893CB8B4-0x00000001893CBB48
	}

	public static class WindowsGpuDriverVersion // TypeDefIndex: 55251
	{
		// Fields
		private static readonly Guid GUID_DEVCLASS_DISPLAY; // 0x00
		private const uint DIGCF_PRESENT = 2; // Metadata: 0x01FD6BA0
		private const uint SPDRP_DEVICEDESC = 0; // Metadata: 0x01FD6BA1
		private const uint SPDRP_MFG = 11; // Metadata: 0x01FD6BA2
		private const uint SPDRP_FRIENDLYNAME = 12; // Metadata: 0x01FD6BA3
		private const uint SPDRP_DRIVER = 9; // Metadata: 0x01FD6BA4
		private const uint DICS_FLAG_GLOBAL = 1; // Metadata: 0x01FD6BA5
		private const uint DIREG_DRV = 2; // Metadata: 0x01FD6BA6
		private static readonly IntPtr INVALID_HANDLE_VALUE; // 0x10
		private const int ERROR_SUCCESS = 0; // Metadata: 0x01FD6BA7
		private const int ERROR_NO_MORE_ITEMS = 259; // Metadata: 0x01FD6BA8
		private const int ERROR_INSUFFICIENT_BUFFER = 122; // Metadata: 0x01FD6BAA
		private const int ERROR_MORE_DATA = 234; // Metadata: 0x01FD6BAC
		private const uint REG_SZ = 1; // Metadata: 0x01FD6BAE
		private const uint REG_EXPAND_SZ = 2; // Metadata: 0x01FD6BAF
	
		// Nested types
		public sealed class Result // TypeDefIndex: 55246
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
			public Result() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override string ToString() => default; // 0x00000001822372F0-0x00000001822382B0
			public string __iFixBaseProxy_ToString() => default; // 0x00000001822382B0-0x00000001822382E0
		}
	
		private sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 55247
		{
			// Constructors
			internal SafeRegistryHandle() {} // 0x0000000182238980-0x0000000182238C80
			internal SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle) {} // 0x0000000182C9C390-0x0000000182C9C3C0
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x00000001822382E0-0x0000000182238980
		}
	
		[Flags]
		private enum RegistryRights // TypeDefIndex: 55248
		{
			KEY_QUERY_VALUE = 1
		}
	
		private struct SP_DEVINFO_DATA // TypeDefIndex: 55249
		{
			// Fields
			public uint cbSize; // 0x00
			public Guid classGuid; // 0x04
			public uint devInst; // 0x14
			public IntPtr reserved; // 0x18
		}
	
		// Constructors
		static WindowsGpuDriverVersion() {} // 0x00000001822511F0-0x0000000182251B90
	
		// Methods
		public static string GetCurrentDriverVersion() => default; // 0x0000000182248F90-0x0000000182249860
		public static Result GetBestMatch() => default; // 0x0000000182247A90-0x0000000182248F90
		public static List<Result> GetAllDisplayDriverVersions() => default; // 0x0000000182245AD0-0x0000000182247A90
		public static string SerializeAllResults(List<Result> results) => default; // 0x000000018224ACD0-0x000000018224BD90
		public static string SerializeAllCurrentResults() => default; // 0x000000018224A6A0-0x000000018224ACD0
		public static bool IsBestMatchDriverVersionChanged(string serialized) => default; // 0x0000000182249860-0x000000018224A4C0
		private static bool _TryGetDriverVersionByKeyId(string serialized, string keyId, out string driverVersion) {
			driverVersion = default;
			return default;
		} // 0x00000001822504E0-0x00000001822511F0
		private static int _ScoreAgainstUnityCurrentGpu(string friendlyName, string deviceDesc, string mfg) => default; // 0x000000018224F2B0-0x00000001822504E0
		private static bool _ContainsIgnoreCase(string a, string b) => default; // 0x000000018224C7B0-0x000000018224CB50
		private static string _GetDeviceRegistryPropertyString(IntPtr infoSet, ref SP_DEVINFO_DATA devInfo, uint prop) => default; // 0x000000018224CB50-0x000000018224DC60
		private static string _GetDriverKeySuffix(string driverKey) => default; // 0x000000018224DC60-0x000000018224E2C0
		private static string _ReadRegistrySz(SafeRegistryHandle hKey, string valueName) => default; // 0x000000018224E2C0-0x000000018224F2B0
		private static extern int RegCloseKey(IntPtr hKey); // 0x000000018224A4C0-0x000000018224A540
		private static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, IntPtr enumerator, IntPtr hwndParent, uint flags); // 0x000000018224BF00-0x000000018224BFF0
		private static extern bool SetupDiEnumDeviceInfo(IntPtr deviceInfoSet, uint memberIndex, ref SP_DEVINFO_DATA deviceInfoData); // 0x000000018224BE20-0x000000018224BF00
		private static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint property, out uint propertyRegDataType, IntPtr propertyBuffer, uint propertyBufferSize, out uint requiredSize); // 0x000000018224BFF0-0x000000018224C100
		private static extern SafeRegistryHandle SetupDiOpenDevRegKey(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint scope, uint hwProfile, uint keyType, int samDesired); // 0x000000018224C100-0x000000018224C7B0
		private static extern bool SetupDiDestroyDeviceInfoList(IntPtr deviceInfoSet); // 0x000000018224BD90-0x000000018224BE20
		private static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, IntPtr lpReserved, out uint lpType, IntPtr lpData, ref uint lpcbData); // 0x000000018224A540-0x000000018224A6A0
	}

	public static class SOCHelper // TypeDefIndex: 55252
	{
		// Fields
		public static readonly int CHUNK_SIZE; // 0x00
		public const string SOC_FOLDER_NAME = "OcclusionCulling"; // Metadata: 0x01FD6BB1
		public const string SOC_INTERMEDIATE_FILE_NAME = "[x]HGSOCChunkData.asset"; // Metadata: 0x01FD6BC2
	
		// Constructors
		static SOCHelper() {} // 0x00000001893CB5DC-0x00000001893CB618
	}

	[Serializable]
	public struct SceneStateAreaKey : IEquatable<SceneStateAreaKey> // TypeDefIndex: 55253
	{
		// Fields
		public uint sceneStateMask; // 0x00
		public int areaId; // 0x04
		public static readonly SceneStateAreaKey DEFAULT; // 0x00
	
		// Constructors
		public SceneStateAreaKey(uint sceneStateMask, int areaId) {
			this.sceneStateMask = default;
			this.areaId = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		static SceneStateAreaKey() {
			DEFAULT = default;
		} // 0x00000001893CB870-0x00000001893CB8B4
	
		// Methods
		[IDTag(0)]
		public bool Equals(SceneStateAreaKey other) => default; // 0x00000001893CB618-0x00000001893CB680
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x00000001893CB680-0x00000001893CB728
		public override int GetHashCode() => default; // 0x00000001893CB728-0x00000001893CB7C0
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x00000001893CB7C0-0x00000001893CB820
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001893CB820-0x00000001893CB870
	}

	public class HGSOCSubSceneData : ScriptableObject // TypeDefIndex: 55256
	{
		// Fields
		public SceneStateAreaKey[] keyArray; // 0x18
		[FormerlySerializedAs("stateDataArray")]
		public SubSceneDataPerSceneStateArea[] dataArray; // 0x20
	
		// Nested types
		[Serializable]
		public struct ChunkData // TypeDefIndex: 55254
		{
			// Fields
			public Vector3[] centers; // 0x00
			public Vector3[] extents; // 0x08
			public Vector3[] vertexData; // 0x10
			public float[] areas; // 0x18
		}
	
		[Serializable]
		public struct SubSceneDataPerSceneStateArea // TypeDefIndex: 55255
		{
			// Fields
			public Vector2Int[] chunkCoords; // 0x00
			public ChunkData[] chunkDataArray; // 0x08
		}
	
		// Constructors
		public HGSOCSubSceneData() {} // 0x000000018286F540-0x000000018286F550
	}

	[ExecuteInEditMode]
	public class HGSOCDataHelper : MonoBehaviour // TypeDefIndex: 55257
	{
		// Fields
		[Header("OC\u6321\u7247\u968F\u8DDD\u79BB\u8870\u51CF\u7A0B\u5EA6(\u4EC5\u751F\u6548LA\u6321\u7247)")]
		[Range(0f, 1f)]
		public float fallOffStrength; // 0x18
		[Header("\u88AB\u906E\u6321OC\u6321\u7247\u7684\u663E\u793A\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float innerBlendWeight; // 0x1C
		[NonSerialized]
		public Material material; // 0x28
		[NonSerialized]
		public HGOccluder[] occluders; // 0x30
	
		// Properties
		public bool displayQuadOccluders { get; set; } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public bool displayHGOccluders { get; set; } // 0x0000000183D4F070-0x0000000183D4F080 0x0000000183D4F080-0x0000000183D4F090
	
		// Constructors
		public HGSOCDataHelper() {} // 0x00000001893CB200-0x00000001893CB218
	}

	public class EntityRenderAlphaDitherController // TypeDefIndex: 55258
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
		public EntityRenderAlphaDitherController(IRendererHelper owner) {} // 0x0000000182836EA0-0x0000000182836F40
		static EntityRenderAlphaDitherController() {} // 0x0000000183CF29E0-0x0000000183CF2A60
	
		// Methods
		public void ResetDitherAlpha() {} // 0x0000000182836990-0x0000000182836A00
		public bool SetDitherAlpha(float alpha, int handle) => default; // 0x00000001828364C0-0x0000000182836610
		public float GetDitherAlpha() => default; // 0x0000000182836440-0x00000001828364C0
		public void Reset() {} // 0x00000001835632F0-0x0000000183563330
		private bool _ApplyNewAlpha() => default; // 0x0000000182836610-0x0000000182836770
		private float _GetCurMinAlpha() => default; // 0x00000001823E9280-0x00000001823E95D0
		public Dictionary<int, float> GetAlphaDictionary() => default; // 0x0000000182C6AA70-0x0000000182C6AAA0
		private void _SetMaterialDitherAlpha(float value) {} // 0x00000001828367C0-0x0000000182836880
		private bool _SetMaterialDitherEnabled(bool enabled) => default; // 0x0000000182836770-0x00000001828367C0
	}

	public class EntityRenderCapturedEntity // TypeDefIndex: 55259
	{
		// Fields
		public GameObject rootGameObject; // 0x10
		public List<MeshRenderer> meshRenderers; // 0x18
		public List<MeshRenderer> capturedRenderers; // 0x20
	
		// Constructors
		public EntityRenderCapturedEntity() {} // 0x00000001893CA738-0x00000001893CA7E0
	}

	public class EntityRenderCaptureMeshController // TypeDefIndex: 55262
	{
		// Fields
		private IRendererHelper m_owner; // 0x10
		private GameObject m_gameObject; // 0x18
		private LODGroup m_lodGroup; // 0x20
		private List<EntityRenderCapturedEntity> m_capturedEntities; // 0x28
		private int m_meshRendererToSyncFrame; // 0x30
		private List<MeshRendererToSync> m_meshRendererToSync; // 0x38
	
		// Nested types
		private struct MeshRendererToSync // TypeDefIndex: 55260
		{
			// Fields
			public Transform captureTransform; // 0x00
			public Renderer captureRenderer; // 0x08
			public Transform followTransform; // 0x10
			public Renderer followRenderer; // 0x18
		}
	
		private class CaptureRenderGameObject // TypeDefIndex: 55261
		{
			// Fields
			public GameObject gameObject; // 0x10
			public MeshRenderer meshRenderer; // 0x18
			public MeshFilter meshFilter; // 0x20
	
			// Constructors
			public CaptureRenderGameObject() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public EntityRenderCaptureMeshController() {} // Dummy constructor
		public EntityRenderCaptureMeshController(IRendererHelper owner, GameObject gameObject) {} // 0x00000001828370F0-0x0000000182837230
	
		// Methods
		public void Reset() {} // 0x00000001834BEF70-0x00000001834BF010
		public void LateTick() {} // 0x0000000183316A80-0x0000000183316AC0
		public EntityRenderCapturedEntity Capture(GameObject root) => default; // 0x00000001893C94F8-0x00000001893CA43C
		private void _SyncTransformInRenderPipeline() {} // 0x0000000183316AC0-0x0000000183316E00
		public void Release(EntityRenderCapturedEntity mesh) {} // 0x00000001893CA43C-0x00000001893CA738
	}

	public class EntityRendererTypeConfig // TypeDefIndex: 55263
	{
		// Fields
		public bool useRegex; // 0x10
		public string regexString; // 0x18
		public Regex regex; // 0x20
		public EntityVFXRendererType type; // 0x28
	
		// Constructors
		public EntityRendererTypeConfig() {} // 0x000000018350B670-0x000000018350B680
	}

	public class EntityRenderHelperMaterialController // TypeDefIndex: 55271
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
		public class RendererInfo // TypeDefIndex: 55264
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
			public Material[] currentMeshMaterials { get => default; } // 0x00000001822CDC10-0x00000001822CDC20 
	
			// Constructors
			public RendererInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public struct AddedMaterialInfo // TypeDefIndex: 55265
		{
			// Fields
			public int handle; // 0x00
			public Material material; // 0x08
			public EntityVFXRendererMask mask; // 0x10
			public AddMaterialConfig config; // 0x18
			public Dictionary<Material, Material> customizeMaterialDict; // 0x28
		}
	
		public struct SourceMaterialCustomizeData // TypeDefIndex: 55266
		{
			// Fields
			public Texture colorTexture; // 0x00
		}
	
		public class AddedMaterialController // TypeDefIndex: 55267
		{
			// Fields
			public const int MAX_ACTIVE_ADDED_MATERIAL = 4; // Metadata: 0x01FD6BE2
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
			public AddedMaterialController() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Init(List<RendererInfo> rendererInfos, EntityCustomizeRendererPropertyConfig customizeRendererPropertyConfig) {} // 0x0000000183787550-0x00000001837875C0
			private void _InitCustomizeRendererProperty() {} // 0x00000001893C58AC-0x00000001893C5BC8
			public void Reset() {} // 0x00000001822CDA50-0x00000001822CDAA0
			public int RequireAddMaterial(Material material, EntityVFXRendererMask mask, AddMaterialConfig config = default) => default; // 0x00000001836F5FF0-0x00000001836F61D0
			public EntityVFXRendererMask RequireRemoveMaterial(int handle) => default; // 0x00000001836F61D0-0x00000001836F66B0
			private Material _GetCustomizePropertyMaterial(AddedMaterialInfo addedMaterialInfo, Material material) => default; // 0x00000001893C5718-0x00000001893C58AC
			public void ApplySharedMaterialArray(RendererInfo rendererInfo) {} // 0x00000001822CDAA0-0x00000001822CDC10
			public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result) => default; // 0x00000001893C4EAC-0x00000001893C51C4
			public void SetAddictiveFloatProperty(int propertyId, float value) {} // 0x00000001893C541C-0x00000001893C5514
			public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x01FD6BDE */) => default; // 0x00000001893C51C4-0x00000001893C527C
			public void SetAddictiveVectorProperty(int propertyId, Vector4 value) {} // 0x00000001893C560C-0x00000001893C5718
			public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default) => default; // 0x00000001893C5334-0x00000001893C541C
			public void SetAddictiveTextureProperty(int propertyId, Texture value) {} // 0x00000001893C5514-0x00000001893C560C
			public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null) => default; // 0x00000001893C527C-0x00000001893C5334
		}
	
		public class CustomPerDrawDataController // TypeDefIndex: 55268
		{
			// Fields
			private List<RendererInfo> m_rendererInfos; // 0x10
			private float m_characterEnvironmentEffectPackedValue; // 0x18
	
			// Constructors
			public CustomPerDrawDataController() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			private float _PackUNorm8ToFloat(float packed, float value, int bitShift) => default; // 0x0000000183318FF0-0x00000001833190B0
			public void Init(List<RendererInfo> allRendererInfos) {} // 0x0000000182CE2160-0x0000000182CE21B0
			public void Reset() {} // 0x00000001822CD650-0x00000001822CDA10
			public void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask) {} // 0x0000000182717690-0x00000001827182E0
			public void SetVectorToCustomPerDraw(EntityRenderHelperVectorCustomPerDrawType type, Vector4 value, EntityVFXRendererMask rendererMask) {} // 0x00000001893C92D4-0x00000001893C94F8
		}
	
		public class MeshMaterialGroupData // TypeDefIndex: 55269
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
			public MeshMaterialGroupData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void CopyFrom(MeshMaterialGroupData src) {} // 0x000000018341D870-0x000000018341D9F0
			public void Clear() {} // 0x00000001822D0F10-0x00000001822D0FD0
		}
	
		public class MeshMaterialController // TypeDefIndex: 55270
		{
			// Fields
			private List<MeshMaterialGroupData> m_meshMaterialDatas; // 0x10
			private static List<MeshMaterialGroupData> s_cacheMeshMaterialDatas; // 0x00
			private static readonly string VFX_MATERIAL_POSTFIX; // 0x08
	
			// Constructors
			public MeshMaterialController() {} // 0x000000018350B670-0x000000018350B680
			static MeshMaterialController() {} // 0x0000000183C9B320-0x0000000183C9B3F0
	
			// Methods
			public void Init(List<RendererInfo> allRendererInfos) {} // 0x00000001822D0DC0-0x00000001822D0F10
			public void Reset() {} // 0x00000001822CFC10-0x00000001822D0CB0
			public void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask) {} // 0x00000001893D3CA8-0x00000001893D43F0
			public void SetDepthOnlyPassEnableToAllMaterial(bool enable, EntityVFXRendererMask rendererMask) {} // 0x00000001893D3310-0x00000001893D3CA8
			public void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask) {} // 0x00000001822D2170-0x00000001822D29C0
			public void ReleaseFloatToAllMaterial(int nameId, EntityVFXRendererMask rendererMask) {} // 0x00000001893D2D70-0x00000001893D2F50
			public void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask) {} // 0x00000001822CF360-0x00000001822CFC10
			public void ReleaseVectorToAllMaterial(int nameId, EntityVFXRendererMask rendererMask) {} // 0x00000001893D3130-0x00000001893D3310
			public void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask) {} // 0x00000001893D43F0-0x00000001893D4850
			public void ReleaseTextureToAllMaterial(int nameId, EntityVFXRendererMask rendererMask) {} // 0x00000001893D2F50-0x00000001893D3130
			private void _CreateReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData) {} // 0x0000000182E7ED80-0x0000000182E7F090
			private void _CopyReplaceMaterial(RendererInfo rendererInfo, MeshMaterialGroupData groupData) {} // 0x00000001893D4C6C-0x00000001893D4F4C
			private void _ReleaseAllReplaceMaterial(MeshMaterialGroupData groupData) {} // 0x00000001822D16C0-0x00000001822D2070
			private void _ReplaceSharedMaterial(RendererInfo rendererInfo, Material[] newMaterials) {} // 0x0000000182E804F0-0x0000000182E80590
			private void _GetAffectGroupData(EntityVFXRendererMask rendererMask, List<MeshMaterialGroupData> result) {} // 0x00000001822D0CB0-0x00000001822D0DC0
			private void _SplitRenderers(int oldStateIndex, EntityVFXRendererMask newMask) {} // 0x000000018341D6C0-0x000000018341D870
			public void SetZTestInMaterial(string shaderName, bool enable) {} // 0x00000001893D4850-0x00000001893D4C6C
		}
	
		// Constructors
		public EntityRenderHelperMaterialController() {} // 0x000000018350B670-0x000000018350B680
		static EntityRenderHelperMaterialController() {} // 0x00000001839C38A0-0x00000001839C3AD0
	
		// Methods
		public void Init(List<Renderer> allRenderers, List<EntityRendererTypeConfig> configs, EntityCustomizeRendererPropertyConfig customRendererPropertyConfig) {} // 0x00000001825AA270-0x00000001825AA760
		public void OnRelease() {} // 0x0000000182839450-0x00000001828396A0
		public void Reset() {} // 0x00000001822CF1D0-0x00000001822CF360
		public bool IsAllRendererValid() => default; // 0x00000001822D0FD0-0x00000001822D16C0
		public void StopShadowCasting(bool stopRayTracing) {} // 0x00000001825ACD50-0x00000001825ACE50
		public virtual void RevertShadowCastingMode() {} // 0x00000001825ACE50-0x00000001825ACFC0
		public int AddMaterialToAllRenderer(Material material, EntityVFXRendererMask rendererMask, AddMaterialConfig config = default) => default; // 0x00000001836F5A90-0x00000001836F5CA0
		public void SetAddictiveFloatProperty(int propertyId, float value) {} // 0x00000001893CAD40-0x00000001893CADC0
		public float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x01FD6BDA */) => default; // 0x00000001893CA864-0x00000001893CA8E4
		public void SetAddictiveVectorProperty(int propertyId, Vector4 value) {} // 0x00000001893CAE40-0x00000001893CAED4
		public Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default) => default; // 0x00000001893CA964-0x00000001893CAA24
		public void SetAddictiveTextureProperty(int propertyId, Texture value) {} // 0x00000001893CADC0-0x00000001893CAE40
		public Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null) => default; // 0x00000001893CA8E4-0x00000001893CA964
		public void RemoveMaterialFromAllRenderer(int handle) {} // 0x00000001836F5920-0x00000001836F5A90
		public bool GetAddedMaterialsOfCustomizeProperties(int handle, List<Material> result) => default; // 0x00000001893CA7E0-0x00000001893CA864
		public void SetKeywordEnableToAllMaterial(string keyword, bool enable, EntityVFXRendererMask rendererMask) {} // 0x00000001893CAF54-0x00000001893CAFEC
		public void SetDepthOnlyPassEnableToAllMaterial(bool enable, EntityVFXRendererMask rendererMask) {} // 0x00000001893CAED4-0x00000001893CAF54
		public void SetFloatToCustomPerDraw(EntityRenderHelperCustomPerDrawType type, float value, EntityVFXRendererMask rendererMask) {} // 0x0000000182CE3950-0x0000000182CE3A20
		public void SetVectorToCustomPerDraw(EntityRenderHelperVectorCustomPerDrawType type, Vector4 value, EntityVFXRendererMask rendererMask) {} // 0x00000001893CB080-0x00000001893CB180
		public void SetFloatToAllMaterial(int nameId, float value, EntityVFXRendererMask rendererMask) {} // 0x00000001834DD9D0-0x00000001834DDA80
		public void SetVectorToAllMaterial(int nameId, Vector4 value, EntityVFXRendererMask rendererMask) {} // 0x00000001822CF150-0x00000001822CF1D0
		public void SetTextureToAllMaterial(int nameId, Texture value, EntityVFXRendererMask rendererMask) {} // 0x00000001893CAFEC-0x00000001893CB080
		private List<RendererInfo> _GetRenderersOfRendererMask(EntityVFXRendererMask rendererMask, bool affectAll) => default; // 0x00000001836F5CA0-0x00000001836F5FF0
		private int _GetSubMeshCount(Renderer renderer) => default; // 0x00000001825A9D30-0x00000001825AA0B0
		public void SetManualDitherAlphaValue(float value) {} // 0x0000000182716640-0x0000000182716DE0
		public bool SetManualDitherEnable(bool enable) => default; // 0x0000000182716DE0-0x0000000182717690
		public Bounds GetRendererBounds() => default; // 0x00000001824D9EF0-0x00000001824DA2D0
		public void SetZTestInMaterial(string shaderName, bool enable) {} // 0x00000001893CB180-0x00000001893CB200
		public RenderHelperType GetRenderHelperType() => default; // 0x00000001893CAA24-0x00000001893CAD40
	}

	public enum EntityRenderHelperCustomPerDrawType // TypeDefIndex: 55272
	{
		WetEffectWorldSpaceHeight = 1,
		CharacterDissolveScheduleOffset = 3,
		RainEffectIntensity = 8,
		WetEffectIntensity = 16,
		WetEffectGlobalIntensity = 24,
		SnowEffectIntensity = 32
	}

	public enum EntityRenderHelperVectorCustomPerDrawType // TypeDefIndex: 55273
	{
		Emissive = 1
	}

	public class EntityRenderHelperVisibleController // TypeDefIndex: 55275
	{
		// Fields
		private List<RendererInfo> m_rendererInfos; // 0x10
		private Dictionary<Renderer, RendererInfo> m_dictionary; // 0x18
		private static ObjectPool<List<RendererInfo>> s_rendererInfoListPool; // 0x00
		private static ObjectPool<Dictionary<Renderer, RendererInfo>> s_rendererInfoDictPool; // 0x08
	
		// Nested types
		public class RendererInfo // TypeDefIndex: 55274
		{
			// Fields
			public Renderer renderer; // 0x10
			private string m_rendererName; // 0x18
			public bool oriVisible; // 0x20
			public bool curVisible; // 0x21
	
			// Properties
			public string rendererName { get => default; } // 0x0000000182FB2A40-0x0000000182FB2AA0 
	
			// Constructors
			public RendererInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public EntityRenderHelperVisibleController() {} // 0x000000018350B670-0x000000018350B680
		static EntityRenderHelperVisibleController() {} // 0x0000000183B32C80-0x0000000183B32DB0
	
		// Methods
		public void Init(List<Renderer> allRenderers) {} // 0x00000001825AA0B0-0x00000001825AA270
		private void _InitDictionary() {} // 0x00000001893CE01C-0x00000001893CE224
		public void Release() {} // 0x0000000182839350-0x0000000182839450
		public void SetVisibleByNameContainsStr(string name, bool visible) {} // 0x0000000182FB2910-0x0000000182FB2A40
		public void SetVisibleByRenderer(Renderer renderer, bool visible) {} // 0x00000001893CDF54-0x00000001893CE01C
		public void ResetVisibleByNameContainsStr(string name) {} // 0x00000001893CDCA0-0x00000001893CDE84
		public void ResetVisibleByRenderer(Renderer renderer) {} // 0x00000001893CDE84-0x00000001893CDF54
		public void Reset() {} // 0x000000018312F070-0x000000018312F350
	}

	public class EntityRenderMaterialManager // TypeDefIndex: 55276
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
		public EntityRenderMaterialManager() {} // 0x00000001893CF7C4-0x00000001893CF9EC
		static EntityRenderMaterialManager() {} // 0x00000001893CF774-0x00000001893CF7C4
	
		// Methods
		public void SetFloat(int nameID, float value) {} // 0x00000001893CEE84-0x00000001893CEF7C
		public void SetTexture(int nameID, Texture value) {} // 0x00000001893CF188-0x00000001893CF280
		public void SetVector(int nameID, Vector4 value) {} // 0x00000001893CF280-0x00000001893CF398
		public void AddMaterial(Material material) {} // 0x00000001893CE224-0x00000001893CE8C0
		public void RemoveMaterial(Material material) {} // 0x00000001893CEA70-0x00000001893CEB08
		public void ClearMaterials() {} // 0x00000001893CE8C0-0x00000001893CEA70
		public void SetKeywordEnable(string keyword, bool enable) {} // 0x00000001893CEF7C-0x00000001893CF188
		public void SetDepthOnlyEnabled(bool enable) {} // 0x00000001893CEB08-0x00000001893CEE84
		public void SetZTestInMaterial(string shaderName, bool enable) {} // 0x00000001893CF398-0x00000001893CF524
		private void _RevertMaterial(Material material) {} // 0x00000001893CF524-0x00000001893CF774
	}

	[Serializable]
	public class EntityVFXCurve // TypeDefIndex: 55277
	{
		// Fields
		public AnimationCurve curve; // 0x10
		public Vector2 rangeEdit; // 0x18
		public Vector2 rangeLimit; // 0x20
	
		// Constructors
		public EntityVFXCurve() {} // Dummy constructor
		public EntityVFXCurve(AnimationCurve curve) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public struct EntityVFXCurveEvaluateResult // TypeDefIndex: 55278
	{
		// Fields
		public ShaderPropertyType propertyType; // 0x00
		public string propertyName; // 0x08
		public int propertyId; // 0x10
		public float floatValue; // 0x14
		public Vector4 vectorValue; // 0x18
		public Vector4 textureScaleOffset; // 0x28
	}

	public struct AddMaterialConfig // TypeDefIndex: 55279
	{
		// Fields
		public bool useColorTexture; // 0x00
		public string colorTextureName; // 0x08
	
		// Properties
		public bool useCustomizeProperty { get => default; } // 0x0000000183D51020-0x0000000183D51030 
	}

	[Serializable]
	public class EntityVFXCurveData // TypeDefIndex: 55280
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
		public EntityVFXCurveData() {} // 0x0000000183D07BD0-0x0000000183D07D30
	}

	[Serializable]
	public class EntityVFXAddictiveMaterialData // TypeDefIndex: 55281
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
		public EntityVFXAddictiveMaterialData() {} // 0x000000018381D2A0-0x000000018381D2F0
	}

	[CreateAssetMenu(fileName = "EntityVFXAsset", menuName = "ScriptableObjects/\u89D2\u8272\u7279\u6548/AddictiveMaterial")]
	public class EntityVFXAddictiveMaterialAsset : EntityVFXAssetBase // TypeDefIndex: 55282
	{
		// Fields
		public EntityVFXAddictiveMaterialData data; // 0x30
	
		// Constructors
		public EntityVFXAddictiveMaterialAsset() {} // 0x00000001838D01E0-0x00000001838D01F0
	}

	[Serializable]
	public class EntityVFXAfterImageData // TypeDefIndex: 55284
	{
		// Fields
		public bool useScaledTime; // 0x10
		public TimeMode timeMode; // 0x14
		public bool loop; // 0x18
		public float duration; // 0x1C
		[Min(0.1f)]
		public float timeInterval; // 0x20
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
		public enum TimeMode // TypeDefIndex: 55283
		{
			Interval = 0,
			Burst = 1
		}
	
		// Constructors
		public EntityVFXAfterImageData() {} // 0x0000000183D42BE0-0x0000000183D42BF0
	}

	[CreateAssetMenu(fileName = "EntityVFXAsset", menuName = "ScriptableObjects/\u89D2\u8272\u7279\u6548/\u6B8B\u5F71")]
	public class EntityVFXAfterImageAsset : EntityVFXAssetBase // TypeDefIndex: 55285
	{
		// Fields
		[SerializeField]
		public EntityVFXAfterImageData data; // 0x30
	
		// Constructors
		public EntityVFXAfterImageAsset() {} // 0x00000001838D01E0-0x00000001838D01F0
	}

	[Serializable]
	public struct EntityCustomizeRendererType // TypeDefIndex: 55286
	{
		// Fields
		public bool useContainStr; // 0x00
		public string rendererNameRegex; // 0x08
		public EntityVFXRendererType type; // 0x10
	}

	[CreateAssetMenu(fileName = "EntityVFXAsset", menuName = "ScriptableObjects/EntityVFXAsset")]
	public class EntityVFXAsset : ScriptableObject // TypeDefIndex: 55287
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
		public EntityVFXAsset() {} // 0x000000018399C530-0x000000018399C5C0
	
		// Methods
		public List<EntityRendererTypeConfig> GetRendererTypeConfigs(bool forceUpdate) => default; // 0x00000001834968A0-0x0000000183496B10
	}

	public enum EntityVFXRendererType // TypeDefIndex: 55288
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
	public enum EntityVFXRendererMask // TypeDefIndex: 55289
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

	public enum EntityVFXPriorityType // TypeDefIndex: 55290
	{
		Normal = 0,
		UltiSkillTimeline = 1
	}

	[Flags]
	public enum SettingLodLevel // TypeDefIndex: 55291
	{
		None = 0,
		Low = 1,
		Mid = 2,
		High = 4,
		Highest = 8
	}

	[Flags]
	public enum AssetPlatformLayers // TypeDefIndex: 55292
	{
		PC = 1,
		Mobile = 2,
		Other = 4
	}

	[Flags]
	public enum EffectTargetLayers // TypeDefIndex: 55293
	{
		Main = 1,
		Guard = 2
	}

	public class EntityVFXAssetBase : ScriptableObject // TypeDefIndex: 55294
	{
		// Fields
		[SerializeField]
		public bool useECSRenderer; // 0x18
		public SettingLodLevel settingLodLevel; // 0x1C
		public AssetPlatformLayers platformLayer; // 0x20
		public EffectTargetLayers targetLayer; // 0x24
		private string m_assetName; // 0x28
	
		// Properties
		public string assetName { get => default; } // 0x00000001893CF9EC-0x00000001893CFA58 
	
		// Constructors
		public EntityVFXAssetBase() {} // 0x0000000184276C40-0x0000000184276C5C
	}

	public enum VFXType // TypeDefIndex: 55295
	{
		Addictive = 0,
		Dissolve = 1,
		Max = 2
	}

	public class EntityVFXControllerBase // TypeDefIndex: 55296
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
		public bool isPlaying { get => default; } // 0x0000000183D4ED50-0x0000000183D4ED60 
		public bool isHiding { get => default; } // 0x0000000183D4F2A0-0x0000000183D4F2B0 
		public bool isKeyword { get => default; } // 0x0000000183D4F4B0-0x0000000183D4F4C0 
		public string vfxName { get => default; } // 0x0000000181003830-0x0000000181003840 
		public float destroyTime { get => default; set {} } // 0x0000000183D51000-0x0000000183D51010 0x0000000183D51010-0x0000000183D51020
		public float lastTickTime { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000183D4ECE0-0x0000000183D4ECF0
	
		// Constructors
		public EntityVFXControllerBase() {} // 0x0000000183D57FC0-0x0000000183D57FE0
	
		// Methods
		public void SetOwner(string name, IRendererHelper owner) {} // 0x000000018386BBC0-0x000000018386BC20
		public void InitLOD(EntityVFXAssetBase vfxAssetBase) {} // 0x0000000182DE0850-0x0000000182DE08A0
		public void SetName(string name) {} // 0x0000000182DE1130-0x0000000182DE1170
		public bool PoolTick() => default; // 0x00000001893CFD28-0x00000001893CFD78
		public void Destroy() {} // 0x00000001893CFA58-0x00000001893CFABC
		protected virtual void OnDestroy() {} // 0x00000001893CFBB0-0x00000001893CFBF4
		public virtual void Play() {} // 0x00000001893CFCE4-0x00000001893CFD28
		public virtual void Stop(bool forceStop) {} // 0x00000001893CFE90-0x00000001893CFEE4
		public virtual void Replay() {} // 0x00000001893CFD78-0x00000001893CFDBC
		public virtual void Tick(float logicDeltaTime) {} // 0x00000001893CFEE4-0x00000001893CFF38
		protected void RefreshLastTickTime() {} // 0x00000001836F5580-0x00000001836F5610
		protected float GetDeltaTimeFromLastTick(bool useScaledTime) => default; // 0x000000018338AC90-0x000000018338AD70
		public virtual EntityVFXPriorityType GetPriorityType() => default; // 0x00000001893CFB08-0x00000001893CFB54
		public virtual bool GetNeedTick() => default; // 0x00000001893CFABC-0x00000001893CFB08
		public void Hide() {} // 0x00000001893CFB54-0x00000001893CFBB0
		protected virtual void OnHide() {} // 0x00000001893CFBF4-0x00000001893CFC38
		public void Show() {} // 0x00000001893CFE38-0x00000001893CFE90
		protected virtual void OnShow() {} // 0x00000001893CFCA0-0x00000001893CFCE4
		public void Sample(float time, bool ending = false /* Metadata: 0x01FD6C68 */) {} // 0x00000001893CFDBC-0x00000001893CFE38
		protected virtual void OnSample(float time, bool ending) {} // 0x00000001893CFC38-0x00000001893CFCA0
	}

	public abstract class EntityVFXControllerStateBase : EntityVFXControllerBase // TypeDefIndex: 55298
	{
		// Fields
		private State m_curState; // 0x54
	
		// Properties
		protected float m_passTime { get; private set; } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		protected float m_loopPassTime { get; private set; } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		protected float m_endPassTime { get; private set; } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		protected virtual bool useScaledTime { get; } // 0x000000018115F4C0-0x000000018115F530 
		protected virtual bool useStartCurve { get; } // 0x000000018115F4C0-0x000000018115F530 
		protected virtual bool useLoopCurve { get; } // 0x000000018115F4C0-0x000000018115F530 
		protected virtual bool useEndCurve { get; } // 0x000000018115F4C0-0x000000018115F530 
		protected virtual bool loop { get; } // 0x000000018115F4C0-0x000000018115F530 
		protected virtual float duration { get; } // 0x0000000183D51A60-0x0000000183D51A70 
		protected virtual float loopDuration { get; } // 0x0000000183D51A60-0x0000000183D51A70 
		protected virtual float endDuration { get; } // 0x0000000183D503F0-0x0000000183D50400 
	
		// Nested types
		private enum State // TypeDefIndex: 55297
		{
			End = 0,
			Start = 1,
			Loop = 2,
			Ending = 3
		}
	
		// Constructors
		protected EntityVFXControllerStateBase() {} // 0x0000000183D57FC0-0x0000000183D57FE0
	
		// Methods
		public override void Play() {} // 0x00000001836F5520-0x00000001836F5580
		public override void Replay() {} // 0x00000001893D003C-0x00000001893D00A0
		public override void Stop(bool forceStop) {} // 0x0000000183D030A0-0x0000000183D030F0
		public override bool GetNeedTick() => default; // 0x00000001835A66C0-0x00000001835A6700
		public override void Tick(float logicDeltaTime) {} // 0x000000018338ABE0-0x000000018338AC90
		protected override void OnSample(float time, bool ending) {} // 0x00000001893CFF38-0x00000001893D003C
		protected abstract void UpdateStart();
		protected abstract void UpdateLoop();
		protected abstract void UpdateStop();
		private void _FinalStop() {} // 0x0000000183D030F0-0x0000000183D03130
		protected abstract void OnFinalStop();
		public void __iFixBaseProxy_Play() {} // 0x00000001858D7D9C-0x00000001858D7DA4
		public void __iFixBaseProxy_Replay() {} // 0x00000001858D7DA4-0x00000001858D7DAC
		public void __iFixBaseProxy_Stop(bool P0) {} // 0x00000001858D7DAC-0x00000001858D7DB4
		public bool __iFixBaseProxy_GetNeedTick() => default; // 0x00000001858D8A54-0x00000001858D8A5C
		public void __iFixBaseProxy_Tick(float P0) {} // 0x00000001858D7DB4-0x00000001858D7DBC
		public void __iFixBaseProxy_OnSample(float P0, bool P1) {} // 0x00000001858D7D8C-0x00000001858D7D94
	}

	public enum EntityCustomizePropertyName // TypeDefIndex: 55299
	{
		None = 0,
		AlphaTex = 1,
		NormalTex = 2
	}

	public enum EntityCustomizeMatchMethod // TypeDefIndex: 55300
	{
		None = 0,
		All = 1,
		RendererName = 2,
		SourceMaterial0 = 3,
		SourceMesh = 4
	}

	[Serializable]
	public class EntityCustomizeRendererPropertyConfig // TypeDefIndex: 55301
	{
		// Fields
		public bool useColorTexture; // 0x10
		public bool useAutoFindColorTexture; // 0x11
		public string autoFindColorTextureName; // 0x18
		public SerializeFieldDictionary<Material, Texture> preConfigColorTextureDict; // 0x20
	
		// Constructors
		public EntityCustomizeRendererPropertyConfig() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public Texture GetColorTexture(Material material) => default; // 0x00000001893CDBF8-0x00000001893CDCA0
	}

	public enum EntityVFXKeywordEnum // TypeDefIndex: 55302
	{
		None = 0,
		Dissolve = 1
	}

	[Serializable]
	public class EntityVFXDissolveData // TypeDefIndex: 55304
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
	
		// Nested types
		public enum UVSet // TypeDefIndex: 55303
		{
			UV = 0,
			UV2 = 1
		}
	
		// Constructors
		public EntityVFXDissolveData() {} // 0x0000000183A1C920-0x0000000183A1C970
	}

	[CreateAssetMenu(fileName = "EntityVFXAsset", menuName = "ScriptableObjects/\u89D2\u8272\u7279\u6548/Dissolve")]
	public class EntityVFXDissolveAsset : EntityVFXAssetBase // TypeDefIndex: 55305
	{
		// Fields
		[SerializeField]
		public EntityVFXDissolveData data; // 0x30
	
		// Constructors
		public EntityVFXDissolveAsset() {} // 0x00000001838D01E0-0x00000001838D01F0
	}

	public class EntityFactoryRendererInfo // TypeDefIndex: 55306
	{
		// Fields
		public int subMeshCount; // 0x10
		public bool enableVAT; // 0x14
		public int vatIndex; // 0x18
		public int initMaterialsCount; // 0x1C
	
		// Constructors
		public EntityFactoryRendererInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	public class EntityVFXFactoryAddedMaterialManager // TypeDefIndex: 55311
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
		public class VATData // TypeDefIndex: 55307
		{
			// Fields
			public Texture factoryVATMap; // 0x10
			public Vector4 factoryVATMapParams; // 0x18
	
			// Constructors
			public VATData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class AddedMaterialData // TypeDefIndex: 55308
		{
			// Fields
			public Material srcMaterial; // 0x10
			public Material[] materialInstancesOfEachVAT; // 0x18
			public Dictionary<int, float> savedFloatProperties; // 0x20
			public Dictionary<int, Vector4> savedVectorProperties; // 0x28
	
			// Constructors
			public AddedMaterialData() {} // 0x00000001893CCC78-0x00000001893CCD38
		}
	
		// Constructors
		public EntityVFXFactoryAddedMaterialManager() {} // 0x00000001893D0DB4-0x00000001893D0F0C
		static EntityVFXFactoryAddedMaterialManager() {} // 0x00000001893D0D0C-0x00000001893D0DB4
	
		// Methods
		public void Init(List<EntityFactoryRendererInfo> factoryRendererInfos) {} // 0x00000001893D0124-0x00000001893D0278
		private void _AddVATMaterial(Material src) {} // 0x00000001893D0674-0x00000001893D09B8
		private Material _GetVATMaterial(EntityFactoryRendererInfo rendererInfo, Material src) => default; // 0x00000001893D0ADC-0x00000001893D0BAC
		private int _GetAddedMaterialIndex(EntityFactoryRendererInfo rendererInfo, Material src) => default; // 0x00000001893D09B8-0x00000001893D0ADC
		private void _RemoveVATMaterial(Material src) {} // 0x00000001893D0BAC-0x00000001893D0D0C
		public void AddMaterialToAllRenderer(Material material) {} // 0x00000001893D00A0-0x00000001893D0124
		public void RemoveMaterialFromAllRenderer(Material material) {} // 0x00000001893D0278-0x00000001893D03E8
		public void SetFloatToFactoryMaterial(Material material, int nameId, float value) {} // 0x00000001893D03E8-0x00000001893D051C
		public void SetVectorToFactoryMaterial(Material material, int nameId, Vector4 value) {} // 0x00000001893D051C-0x00000001893D0674
	}

	public static class EntityVFXFactoryMaterialCache // TypeDefIndex: 55313
	{
		// Fields
		private static readonly int S_FACTORY_VAT_MAP; // 0x00
		private static readonly int S_FACTORY_VAT_MAP_PARAMS; // 0x04
		private static Dictionary<int, Dictionary<int, VATMaterialData>> s_cachedMaterials; // 0x08
	
		// Nested types
		public class VATMaterialData // TypeDefIndex: 55312
		{
			// Fields
			public int refCount; // 0x10
			public Material vatMaterial; // 0x18
	
			// Constructors
			public VATMaterialData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		static EntityVFXFactoryMaterialCache() {} // 0x00000001893D1454-0x00000001893D153C
	
		// Methods
		public static Material GetVATMaterial(Material srcMaterial, Texture factoryVATMap, Vector4 factoryVATMapParams) => default; // 0x00000001893D0F0C-0x00000001893D1220
		public static void ReleaseVATMaterial(Material srcMaterial, Texture factoryVATMap) {} // 0x00000001893D1220-0x00000001893D1454
	}

	[Serializable]
	public class EntityVFXSetParamsData // TypeDefIndex: 55315
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
		public enum Type // TypeDefIndex: 55314
		{
			Character = 0,
			VFX = 1,
			Lit = 2
		}
	
		// Constructors
		public EntityVFXSetParamsData() {} // 0x0000000183D4D0D0-0x0000000183D4D0F0
	}

	[CreateAssetMenu(fileName = "EntityVFXAsset", menuName = "ScriptableObjects/\u89D2\u8272\u7279\u6548/SetParams")]
	public class EntityVFXSetParamsAsset : EntityVFXAssetBase // TypeDefIndex: 55316
	{
		// Fields
		[SerializeField]
		public EntityVFXSetParamsData data; // 0x30
	
		// Constructors
		public EntityVFXSetParamsAsset() {} // 0x00000001838D01E0-0x00000001838D01F0
	}

	public static class EntityVFXUtils // TypeDefIndex: 55317
	{
		// Methods
		public static void CalculateCutOffBounds(IRendererHelper owner, bool useCutoffLocalDirection, Vector3 cutoffDirectionData, bool useCutoffPosYAutoBounds, float cutoffPosYAbsoluteBounds, out float cutoffMin, out float cutoffMax, out Vector3 cutoffDirection) {
			cutoffMin = default;
			cutoffMax = default;
			cutoffDirection = default;
		} // 0x00000001893D16AC-0x00000001893D18E8
		public static ValueTuple<float, float> GetBoundsMinMaxOfDirection(Bounds bounds, Vector3 direction) => default; // 0x00000001893D18E8-0x00000001893D1AF8
		public static void ApplyEntityVFXCurves(Material material, List<EntityVFXCurveData> curveDataList, float schedule) {} // 0x00000001893D153C-0x00000001893D16AC
		public static EntityVFXCurveEvaluateResult Evaluate(EntityVFXCurveData curveData, float schedule) => default; // 0x00000001822CEE30-0x00000001822CEFB0
		private static void _UpdateCurve(Material material, EntityVFXCurveData curveData, float schedule) {} // 0x00000001893D1C38-0x00000001893D1DCC
		public static bool IsCharacterShader(string name) => default; // 0x00000001893D1AF8-0x00000001893D1B98
		public static bool IsLitShader(string name) => default; // 0x00000001893D1B98-0x00000001893D1C38
	
		// Extension methods
		public static EntityVFXRendererMask ToMask(this EntityVFXRendererType type) => default; // 0x00000001825AA760-0x00000001825AA7F0
	}

	public interface ICaptureMesh // TypeDefIndex: 55318
	{
		// Methods
		EntityRenderCapturedEntity Capture(GameObject placeRoot);
		void Release(EntityRenderCapturedEntity mesh);
	}

	public enum RenderHelperType // TypeDefIndex: 55319
	{
		Unknown = 0,
		Character = 1,
		Lit = 2,
		Mix = 4
	}

	public interface IRendererHelper // TypeDefIndex: 55320
	{
		// Methods
		void Reset();
		void Play(string vfxName);
		void Stop(string vfxName);
		void ShowAll();
		void HideAll();
		void SetDitherAlpha(float ditherAlpha, int handle = 0 /* Metadata: 0x01FD6C80 */);
		float GetDitherAlpha();
		void ResetAllDitherAlpha();
		void ClearEffectCache(string name);
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
		float GetAddictiveFloatProperty(int propertyId, float defaultValue = 0f /* Metadata: 0x01FD6C81 */);
		void SetAddictiveVectorProperty(int propertyId, Vector4 value);
		Vector4 GetAddictiveVectorProperty(int propertyId, Vector4 defaultValue = default);
		void SetAddictiveTextureProperty(int propertyId, Texture value);
		Texture GetAddictiveTextureProperty(int propertyId, Texture defaultValue = null);
		void StopShadowCasting(bool stopRayTracing = false /* Metadata: 0x01FD6C85 */);
		void RevertShadowCastingMode();
		void SetDepthOnlyEnabledToAllMaterial(bool enable, EntityVFXRendererMask rendererMask);
		bool SetManualDitherEnable(bool enable);
		void SetManualDitherAlphaValue(float value);
		Bounds GetRendererBounds();
		Matrix4x4 GetTransform();
		bool IsFactory();
		RenderHelperType GetRenderHelperType(bool forceCalculate = true /* Metadata: 0x01FD6C86 */);
		void SetTimeScale(float timeScale);
		float GetTimeScale();
		bool GetMeshHasVFXVertColor();
		bool CanPlay(SettingLodLevel settingLodLevel, AssetPlatformLayers platformLayer, EffectTargetLayers targetLayer);
	}

	public class CommonVAT : MonoBehaviour // TypeDefIndex: 55321
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
		public string PropertySetterType { get => default; } // 0x00000001893CDB60-0x00000001893CDBF8 
	
		// Constructors
		public CommonVAT() {} // 0x00000001893CDA8C-0x00000001893CDB60
		static CommonVAT() {} // 0x00000001893CDA3C-0x00000001893CDA8C
	
		// Methods
		private void Start() {} // 0x00000001893CD14C-0x00000001893CD3F4
		public void Play(string name, bool playWhenComplete = false /* Metadata: 0x01FD6C87 */) {} // 0x00000001893CD0B4-0x00000001893CD14C
		private void _DoPlay(string name) {} // 0x00000001893CD56C-0x00000001893CD750
		private void _NextPlay() {} // 0x00000001893CD750-0x00000001893CD918
		private void _CreateTimer(float time, Action func, string funcName) {} // 0x00000001893CD484-0x00000001893CD56C
		private void _ClearTimer() {} // 0x00000001893CD3F4-0x00000001893CD484
		private void _UpdateProperty(RuntimeVATAnimationClip runtimeVatAnimationClip) {} // 0x00000001893CD918-0x00000001893CDA3C
	}

	public class FactoryVAT : MonoBehaviour // TypeDefIndex: 55322
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
		public FactoryVAT() {} // 0x00000001893D2BDC-0x00000001893D2D70
		static FactoryVAT() {} // 0x00000001893D2B60-0x00000001893D2BDC
	
		// Methods
		private void Start() {} // 0x00000001893D1F28-0x00000001893D2128
		public void Reset() {} // 0x00000001893D1ED8-0x00000001893D1F28
		private void _UpdateAnim() {} // 0x00000001893D2984-0x00000001893D2B60
		public void OnUpdate() {} // 0x00000001893D1DCC-0x00000001893D1E1C
		public void Play(string name, Action callBack = null, bool whenComplete = false /* Metadata: 0x01FD6C88 */) {} // 0x00000001893D1E1C-0x00000001893D1ED8
		private void _DoPlay(string name, Action callBack) {} // 0x00000001893D2128-0x00000001893D2248
		private void _InitRenderer() {} // 0x00000001893D24A0-0x00000001893D2584
		private void _InitRenderer_MeshRender(LODGroup lodGroup) {} // 0x00000001893D2248-0x00000001893D24A0
		private void _SetParamsToRenderer() {} // 0x00000001893D2934-0x00000001893D2984
		private void _SetParamsToRenderer_MeshRender() {} // 0x00000001893D280C-0x00000001893D2934
		private void _ReSetParamsToRenderer() {} // 0x00000001893D27BC-0x00000001893D280C
		private void _ReSetParamsToRenderer_MeshRender() {} // 0x00000001893D2584-0x00000001893D27BC
	}

	[Serializable]
	public class RuntimeVATAnimationClip // TypeDefIndex: 55323
	{
		// Fields
		public string stateName; // 0x10
		public string name; // 0x18
		public bool loop; // 0x20
		public int startFrame; // 0x24
		public int endFrame; // 0x28
	
		// Constructors
		public RuntimeVATAnimationClip() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class RuntimeVATData // TypeDefIndex: 55324
	{
		// Fields
		public Texture vatMap; // 0x10
		public bool fullRigidBody; // 0x18
		public List<Matrix4x4> bonePoses; // 0x20
		public float frameRate; // 0x28
		public List<RuntimeVATAnimationClip> animationClips; // 0x30
	
		// Constructors
		public RuntimeVATData() {} // 0x00000001893D59C0-0x00000001893D5A38
	}

	public abstract class VATPropertySetter // TypeDefIndex: 55325
	{
		// Constructors
		protected VATPropertySetter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void Init(GameObject gameObject);
		public abstract void SetFloat(int id, float value);
		public abstract void SetVector(int id, Vector4 value);
	}

	public class VATRendererPropertySetter : VATPropertySetter // TypeDefIndex: 55326
	{
		// Fields
		private List<Renderer> m_allRenderers; // 0x10
		private List<Material> m_allMaterials; // 0x18
	
		// Constructors
		public VATRendererPropertySetter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Init(GameObject gameObject) {} // 0x00000001893D9C68-0x00000001893D9EE8
		public override void SetFloat(int id, float value) {} // 0x00000001893D9EE8-0x00000001893DA070
		public override void SetVector(int id, Vector4 value) {} // 0x00000001893DA070-0x00000001893DA21C
	}

	public class VATEntityRendererHelperPropertySetter : VATPropertySetter // TypeDefIndex: 55327
	{
		// Fields
		private IRendererHelper m_rendererHelper; // 0x10
	
		// Constructors
		public VATEntityRendererHelperPropertySetter() {} // Dummy constructor
		public VATEntityRendererHelperPropertySetter(IRendererHelper rendererHelper) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void Init(GameObject gameObject) {} // 0x00000001893D9B00-0x00000001893D9B54
		public override void SetFloat(int id, float value) {} // 0x00000001893D9B54-0x00000001893D9BD4
		public override void SetVector(int id, Vector4 value) {} // 0x00000001893D9BD4-0x00000001893D9C68
	}

	public class PsoCreateUploadHelper // TypeDefIndex: 55335
	{
		// Fields
		protected const int PSO_UPLOAD_INFO_VERSION = 1; // Metadata: 0x01FD6C89
		protected const int MAX_UPLOAD_COUNT_PER_LOOP = 128; // Metadata: 0x01FD6C8A
		protected const int MAX_UPLOAD_COUNT_PER_LOOP_LARGE = 256; // Metadata: 0x01FD6C8C
		protected const int MAX_UPLOAD_SIZE_PER_LOOP = 786432; // Metadata: 0x01FD6C8E
		protected const int MAX_UPLOAD_SIZE_PER_LOOP_LARGE = 5242880; // Metadata: 0x01FD6C92
		protected const float TICK_INTERVAL = 0.55f; // Metadata: 0x01FD6C96
		protected const int TICK_UPLOAD_INTERVAL = 60; // Metadata: 0x01FD6C9A
		protected const float CREATE_TIME_SMALL_DROP = 0.5f; // Metadata: 0x01FD6C9B
		protected static PsoCreateUploadHelper s_instance; // 0x00
		public static int s_enabled; // 0x08
		protected static int s_tickCount; // 0x0C
		public static bool s_skipUploadFile; // 0x10
		public static bool s_isShaderWarming; // 0x11
		public static bool s_enableTimeLimit; // 0x12
		private static string s_persistentDataPath; // 0x18
		private static ConcurrentQueue<ValueTuple<string, float, int, bool, string>> s_concurrentQueue; // 0x20
		private int m_timerId; // 0x10
		private const string URL = "http://beyondtools.int.hypergryph.com:42422"; // Metadata: 0x01FD6C9F
		private const string TOKEN = "fhlasdfu8731fqa"; // Metadata: 0x01FD6CCB
		private static SynchronizationContext s_mainSyncContext; // 0x28
		private static int s_mainThreadId; // 0x30
	
		// Properties
		public static PsoCreateUploadHelper instance { get => default; } // 0x0000000182C35AD0-0x0000000182C35BB0 
		private static string persistentDataPath { get => default; } // 0x000000018268B5D0-0x000000018268B720 
	
		// Nested types
		[Serializable]
		private class PsoInfoWrapperItem // TypeDefIndex: 55328
		{
			// Fields
			public string infoJson; // 0x10
			public float time; // 0x18
			public int codeSize; // 0x1C
			public bool isMissing; // 0x20
			public string levelId; // 0x28
	
			// Constructors
			public PsoInfoWrapperItem() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		private class PsoInfoWrapper // TypeDefIndex: 55329
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
			public PsoInfoWrapper() {} // 0x00000001893D5948-0x00000001893D59C0
		}
	
		// Constructors
		static PsoCreateUploadHelper() {} // 0x0000000183B2DAE0-0x0000000183B2DC30
		public PsoCreateUploadHelper() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void Initialize() {} // 0x00000001838216F0-0x0000000183821840
		public void Init() {} // 0x00000001826898B0-0x0000000182689B40
		private void _SceneLoadStartHandler([IsReadOnly] in EventData<string, string> args) {} // 0x000000018319A020-0x000000018319A9C0
		public void Dispose() {} // 0x00000001893D5070-0x00000001893D51CC
		public static bool IsPsoRecordEnabled() => default; // 0x000000018319AB20-0x000000018319B760
		public static void BeforeWarmUpBegin() {} // 0x00000001893D4FE4-0x00000001893D5070
		public static void AfterWarmUpFinish() {} // 0x00000001893D4F4C-0x00000001893D4FE4
		private static void _Tick() {} // 0x000000018319A9C0-0x000000018319AAE0
		private static void _PsoUploadProcessOneCallBack(string infoJson, HGPsoExtInfo info) {} // 0x000000018323EF10-0x000000018323F060
		private static string _PsoUpdateGameInfoCallBack() => default; // 0x000000018328F6E0-0x000000018328F7F0
		private static void _UploadPipelineCreatedInfo(bool timeLimit) {} // 0x000000018319AAE0-0x000000018319AB20
		private static void _CreateAndUploadFinalJson(bool timeLimit) {} // 0x000000018319B760-0x000000018319B910
		private static void _CreateAndUploadFileToServer(string path, string serverFileName, PsoInfoWrapper psoInfoWrapper) {} // 0x00000001893D5234-0x00000001893D56B8
		private static void _UploadFile(string urlPath, string rawFilePath, string serverFileNameOverride, Action<bool, string, string> callback) {} // 0x00000001893D57E0-0x00000001893D5948
		private static async void _UploadFileToServer(string urlPath, string rawFilePath, string serverFileNameOverride, Action<bool, string, string> callback) {} // 0x00000001893D56B8-0x00000001893D57E0
		private static void _Callback(bool success, string msg, string url) {} // 0x00000001893D51CC-0x00000001893D5234
	}

	public class VFXSludgeBaker // TypeDefIndex: 55338
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
		private const float EXTEND_SIZE = 2f; // Metadata: 0x01FD6CDB
		public float rayCastPosY; // 0xB0
	
		// Constructors
		public VFXSludgeBaker() {} // Dummy constructor
		public VFXSludgeBaker(SplineContainer splineContainer, Transform target, float density, float thickness, float maxHeight, float blurIntensity, float gridHeightOffset) {} // 0x00000001893DD3B4-0x00000001893DD424
	
		// Methods
		public void Bake() {} // 0x00000001893DA21C-0x00000001893DA2B4
		private void _CalculatePolygonAndBounds() {} // 0x00000001893DB8AC-0x00000001893DBC1C
		public Vector2Int GetLocalIndex(Vector3 localPosition) => default; // 0x00000001893DA2B4-0x00000001893DA398
		public Vector3 GetLocalPosition(Vector2Int index) => default; // 0x00000001893DA398-0x00000001893DA4BC
		private void _RaycastSceneObjectsHeight() {} // 0x00000001893DCB68-0x00000001893DD3B4
		private void _CalculateInPolygon() {} // 0x00000001893DB360-0x00000001893DB584
		private void _CalculateInHighPowerZone() {} // 0x00000001893DAF40-0x00000001893DB360
		private static float[] _CreateGaussianKernel(int size, float sigma) => default; // 0x00000001893DC348-0x00000001893DC4AC
		private static float[,] _Convolution(float[,] src, float[] kernel, Vector2Int offsetDir) => default; // 0x00000001893DC114-0x00000001893DC348
		private void _BlurTopHeight() {} // 0x00000001893DA4BC-0x00000001893DA6A8
		private void _CalculateThicknessAndTopHeight() {} // 0x00000001893DBC1C-0x00000001893DC114
		private void _CalculateNormals() {} // 0x00000001893DB584-0x00000001893DB8AC
		private static void _ForAround(int ix, int iz, int xCount, int zCount, Action<int, int> callback) {} // 0x00000001893DC640-0x00000001893DC73C
		[IDTag(1)]
		private int _GetHash(int ix, int iz) => default; // 0x00000001893DC7A8-0x00000001893DC818
		[IDTag(0)]
		private static int _GetHash(int ix, int iz, int xCount) => default; // 0x00000001893DC73C-0x00000001893DC7A8
		[IDTag(0)]
		private static void _CalculateEdgeSignedDistance(float[,] sdf) {} // 0x00000001893DA6A8-0x00000001893DAA60
		[IDTag(1)]
		private void _CalculateEdgeSignedDistance() {} // 0x00000001893DAA60-0x00000001893DAF40
		private UnityEngine.Color _GetTextureColor1(int ix, int iz) => default; // 0x00000001893DC818-0x00000001893DCA18
		private UnityEngine.Color _GetTextureColor2(int ix, int iz) => default; // 0x00000001893DCA18-0x00000001893DCB68
		private void _CreateTexture() {} // 0x00000001893DC4AC-0x00000001893DC640
	}

	public class VFXSludgeNavUtils // TypeDefIndex: 55348
	{
		// Nested types
		public static class BoundsUtil // TypeDefIndex: 55339
		{
			// Methods
			public static void GetTopBottomPoints(Bounds bounds, Transform t, out Vector3 topPoint, out Vector3 bottomPoint, Vector3? upDir = default) {
				topPoint = default;
				bottomPoint = default;
			} // 0x00000001893CCD38-0x00000001893CD0B4
		}
	
		public static class Spline2DProjectAndSimplify // TypeDefIndex: 55344
		{
			// Nested types
			public struct Frame // TypeDefIndex: 55340
			{
				// Fields
				public Vector3 origin; // 0x00
				public Quaternion rot; // 0x0C
	
				// Constructors
				public Frame(Vector3 origin, Quaternion rot) {
					this.origin = default;
					this.rot = default;
				} // 0x0000000183D5C820-0x0000000183D5C840
	
				// Methods
				public Vector3 WorldToFrame(Vector3 pWorld) => default; // 0x00000001893DD518-0x00000001893DD630
				public Vector3 FrameToWorld(Vector3 pFrame) => default; // 0x00000001893DD424-0x00000001893DD518
			}
	
			public enum EdgeMode // TypeDefIndex: 55341
			{
				UseSplineOrder = 0,
				ConvexHull = 1
			}
	
			public class ProcessResult // TypeDefIndex: 55342
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
				public ProcessResult() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Methods
			public static Frame MakeFrameFromPlaneNormal(Vector3 planeOrigin, Vector3 planeNormal) => default; // 0x00000001893D6130-0x00000001893D6258
			public static Frame MakeFrameByYaw(Vector3 origin, float yawDeg) => default; // 0x00000001893D606C-0x00000001893D6130
			public static List<Vector3> SampleUniformByArcLength(SplineContainer container, float stepMeters = 0.1f /* Metadata: 0x01FD6CDF */, int splineIndex = 0 /* Metadata: 0x01FD6CE3 */, bool closed = true /* Metadata: 0x01FD6CE4 */, float oversample = 0.02f /* Metadata: 0x01FD6CE5 */) => default; // 0x00000001893D6AD8-0x00000001893D7068
			public static void ProjectWorldToFrameXZ(List<Vector3> worldPts, Frame frame, out List<Vector2> projected2D, out List<float> frameYs, out float worldMinY, out float worldMaxY, out float frameMinY, out float frameMaxY) {
				projected2D = default;
				frameYs = default;
				worldMinY = default;
				worldMaxY = default;
				frameMinY = default;
				frameMaxY = default;
			} // 0x00000001893D67F4-0x00000001893D6AD8
			public static List<int> ConvexHullIndices(List<Vector2> pts) => default; // 0x00000001893D5A38-0x00000001893D606C
			private static float _AngleDegAt(List<Vector2> p, int i, bool closed) => default; // 0x00000001893D750C-0x00000001893D7768
			private static float _CurvatureAt(List<Vector2> p, int i, bool closed) => default; // 0x00000001893D7768-0x00000001893D7A70
			private static float _PointToSegmentDistance2D(Vector2 a, Vector2 b, Vector2 p) => default; // 0x00000001893D7A70-0x00000001893D7BA0
			public static List<int> Simplify2D_ByCurvatureAngleDeviation(List<Vector2> poly, bool closed, float angleDegThresh, float deltaKappaThresh, float devEps) => default; // 0x00000001893D7068-0x00000001893D74B4
			public static ProcessResult Process(SplineContainer container, Frame frame, float stepMeters = 0.1f /* Metadata: 0x01FD6CE9 */, int splineIndex = 0 /* Metadata: 0x01FD6CED */, bool splineClosed = true /* Metadata: 0x01FD6CEE */, EdgeMode edgeMode = EdgeMode.UseSplineOrder /* Metadata: 0x01FD6CEF */, float angleDegThresh = 3f /* Metadata: 0x01FD6CF0 */, float deltaKappaThresh = 0.1f /* Metadata: 0x01FD6CF4 */, float devEpsFactor = 0.2f /* Metadata: 0x01FD6CF8 */) => default; // 0x00000001893D6258-0x00000001893D67F4
		}
	
		public static class SplineSamplingUtils // TypeDefIndex: 55346
		{
			// Methods
			public static List<Vector2> SampleByArcLength(SplineContainer container, float step, int splineIndex = 0 /* Metadata: 0x01FD6CFE */, int lutResolution = 1024 /* Metadata: 0x01FD6CFF */, bool closed = true /* Metadata: 0x01FD6D01 */, bool worldSpace = true /* Metadata: 0x01FD6D02 */) => default; // 0x00000001893E00D8-0x00000001893E08FC
		}
	
		public static class PolySimplify // TypeDefIndex: 55347
		{
			// Methods
			public static List<Vector3> SimplifyByAngle(List<Vector3> pts, float maxTurnDeg = 3f /* Metadata: 0x01FD6D03 */, float minEdgeLen = 0.05f /* Metadata: 0x01FD6D07 */, bool closed = true /* Metadata: 0x01FD6D0B */) => default; // 0x00000001893DFA84-0x00000001893E00D8
		}
	
		// Constructors
		public VFXSludgeNavUtils() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class VFXSludgeUtils // TypeDefIndex: 55349
	{
		// Methods
		public static List<Vector3> GetPolygonOffSpline(SplineContainer splineContainer, float splitDistance, int splineIndex = 0 /* Metadata: 0x01FD6D0C */) => default; // 0x00000001893E1690-0x00000001893E18D8
		public static void GetPolygonOffSplineWithSimplify(SplineContainer container, ref List<Vector2> points, int splineIndex = 0 /* Metadata: 0x01FD6D0D */, bool closed = true /* Metadata: 0x01FD6D0E */, bool isDebug = false /* Metadata: 0x01FD6D0F */, bool isConvexHull = false /* Metadata: 0x01FD6D10 */) {} // 0x00000001893E1078-0x00000001893E1690
		public static List<Vector3> GetPolygonOffByPolyLine(List<Vector2> polylinePoints, Transform transform, float splitDistance) => default; // 0x00000001893E0CEC-0x00000001893E1078
		public static List<Vector3> CalculatePointPolygonHorizonRayCross(List<Vector3> polygon, Vector3 point) => default; // 0x00000001893E0B30-0x00000001893E0CEC
	}

	public class HGTerrain : MonoBehaviour // TypeDefIndex: 55350
	{
		// Constructors
		public HGTerrain() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public delegate void ToggleFunc(HGTerrainHelper terrainHelper); // TypeDefIndex: 55351; 0x0000000182149960-0x0000000182149970

	[ExecuteInEditMode]
	[RequireComponent(typeof(Terrain))]
	public class HGTerrainHelper : MonoBehaviour // TypeDefIndex: 55352
	{
		// Constructors
		public HGTerrainHelper() {} // 0x000000018426FE60-0x000000018426FE68
	}
}

namespace Beyond.Rendering.LODLightmapping
{
	[ExecuteInEditMode]
	public class LightmapInfoTransfer : MonoBehaviour // TypeDefIndex: 55354
	{
		// Fields
		[SerializeField]
		private MeshRenderer _lightmappedRenderer; // 0x18
		private MeshRenderer m_currentRenderer; // 0x20
	
		// Constructors
		public LightmapInfoTransfer() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnEnable() {} // 0x00000001893DF880-0x00000001893DF8D0
		private void Awake() {} // 0x00000001893DF7E8-0x00000001893DF880
		private void _RendererInfoTransfer() {} // 0x00000001893DF8D0-0x00000001893DFA84
	}

	public enum LodLightmappingMode // TypeDefIndex: 55355
	{
		AllFromLightProbe = 0,
		AllFromLOD0 = 1,
		UseDifferentLightmapAreaForLODs = 2
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class LODLightmapping : MonoBehaviour // TypeDefIndex: 55356
	{
		// Fields
		public LodLightmappingMode mode; // 0x18
		[SerializeField]
		public Vector4 lightmapScaleOffset; // 0x1C
		[SerializeField]
		public int lightmapIndex; // 0x2C
	
		// Constructors
		public LODLightmapping() {} // 0x0000000183C94940-0x0000000183C94980
	
		// Methods
		public void RendererInfoTransfer() {} // 0x00000001893DF414-0x00000001893DF7E8
	}
}

namespace Beyond.Rendering.SplineMovingObjects
{
	[ExecuteAlways]
	[RequireComponent(typeof(SplineContainer))]
	public class HGSplineMovingObjects : MonoBehaviour, IVFXPlayable // TypeDefIndex: 55353
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
		public HGSplineMovingObjects() {} // 0x00000001893DE080-0x00000001893DE284
	
		// Methods
		private void _CreateInstance() {} // 0x00000001893DDA7C-0x00000001893DDCF0
		private void _ExtractSplineData() {} // 0x00000001893DDD58-0x00000001893DDFDC
		private void _DestroyInstance() {} // 0x00000001893DDCF0-0x00000001893DDD58
		private void _Release() {} // 0x00000001893DDFDC-0x00000001893DE080
		private void Update() {} // 0x00000001893DD9C4-0x00000001893DDA7C
		private void OnEnable() {} // 0x00000001893DD880-0x00000001893DD8D0
		private void OnDisable() {} // 0x00000001893DD680-0x00000001893DD6D0
		private void OnDestroy() {} // 0x00000001893DD630-0x00000001893DD680
		private void OnDrawGizmosSelected() {} // 0x00000001893DD6D0-0x00000001893DD880
		public void Pause() {} // 0x00000001893DD8D0-0x00000001893DD924
		public void Play() {} // 0x00000001893DD924-0x00000001893DD974
		public void Stop() {} // 0x00000001893DD974-0x00000001893DD9C4
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 55226
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 55227
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 55228
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 55229
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 55230
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class ContainerWaterManager : MonoBehaviour // TypeDefIndex: 55223
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
		private const float VORTEX_CHECK_INTERVAL = 0.1f; // Metadata: 0x01FD6AA4
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
		private float dy { get => default; } // 0x0000000183D4F670-0x0000000183D4F680 
	
		// Constructors
		public ContainerWaterManager() {} // 0x00000001893C8E88-0x00000001893C8F8C
		static ContainerWaterManager() {} // 0x00000001893C8DB8-0x00000001893C8E88
	
		// Methods
		private void Start() {} // 0x00000001893C5D70-0x00000001893C5DF0
		private void _InitializeWaveSystem() {} // 0x00000001893C68A4-0x00000001893C6D68
		private void _PrecomputeCylinderMask() {} // 0x00000001893C6E78-0x00000001893C70A8
		private void _UnifiedWaveStep(bool isEditorUpdate) {} // 0x00000001893C70A8-0x00000001893C8934
		private bool _WorldToTextureCoords(Vector3 worldPos, ref Vector2Int texturePos) => default; // 0x00000001893C8CD4-0x00000001893C8DB8
		private bool _IsInsideCylinder(int i, int j) => default; // 0x00000001893C6D68-0x00000001893C6DFC
		private bool _IsValidPosition(int x, int y) => default; // 0x00000001893C6DFC-0x00000001893C6E78
		private void _ApplyMatrixToTexture(float[][] state, ref Texture2D tex, float waveMultiplier) {} // 0x00000001893C6224-0x00000001893C6688
		private void _ApplyReflectiveBoundary() {} // 0x00000001893C6688-0x00000001893C673C
		private void _ApplyAbsorptiveBoundary() {} // 0x00000001893C60D0-0x00000001893C6224
		private Vector2Int _FindNearestInsidePoint(int x, int y) => default; // 0x00000001893C673C-0x00000001893C68A4
		private void _UpdateVortexState(bool isEditorUpdate) {} // 0x00000001893C8934-0x00000001893C8CD4
		[ContextMenu("\u91CD\u7F6E\u6C34\u6CE2\u7EB9\u7406")]
		public void ResetWaveTexture() {} // 0x00000001893C5BC8-0x00000001893C5D70
		private void Update() {} // 0x00000001893C5DF0-0x00000001893C60D0
	}

	[AddComponentMenu("HG/Effect/VFXLockTransform(\u9501\u7F29\u653E)")]
	[ExecuteAlways]
	public class VFXLockTransform : MonoBehaviour // TypeDefIndex: 55224
	{
		// Constructors
		public VFXLockTransform() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 55225
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 55359
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05560-0x0000000183D055D0
	
		// Methods
		public void __Gen_Wrap_0(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public bool __Gen_Wrap_1(object P0, int P1, int P2) => default; // 0x00000001855FF73C-0x00000001855FF82C
		public Vector2Int __Gen_Wrap_2(object P0, int P1, int P2) => default; // 0x00000001893DEADC-0x00000001893DEBF0
		public bool __Gen_Wrap_3(object P0, Vector3 P1, ref Vector2Int P2) => default; // 0x00000001893DEBF0-0x00000001893DED70
		public void __Gen_Wrap_4(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public void __Gen_Wrap_5(object P0, object P1, ref Texture2D P2, float P3) {} // 0x00000001893DED70-0x00000001893DEEB0
		public void __Gen_Wrap_6(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public void __Gen_Wrap_7(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_8(object P0, Vector4 P1, Vector4 P2) {} // 0x00000001893DEEB0-0x00000001893DEFE4
		public void __Gen_Wrap_9(object P0, Vector4 P1) {} // 0x00000001893DEFE4-0x00000001893DF0F8
		public void __Gen_Wrap_10(object P0, float P1, float P2) {} // 0x00000001854A1120-0x00000001854A1208
		public string __Gen_Wrap_11(object P0) => default; // 0x00000001893DE284-0x00000001893DE374
		public void __Gen_Wrap_12() {} // 0x00000001850F3444-0x00000001850F34E0
		public string __Gen_Wrap_13(RootCategory P0) => default; // 0x00000001893DE374-0x00000001893DE450
		public string __Gen_Wrap_14(RootCategory P0, bool P1) => default; // 0x00000001893DE450-0x00000001893DE548
		public string __Gen_Wrap_15() => default; // 0x00000001893DE548-0x00000001893DE614
		public string __Gen_Wrap_16(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3) => default; // 0x00000001893DE614-0x00000001893DE738
		public string __Gen_Wrap_17(RuntimePlatform P0, GraphicsDeviceType P1, int P2, object P3, object P4) => default; // 0x00000001893DE738-0x00000001893DE86C
		public long __Gen_Wrap_18() => default; // 0x000000018516C778-0x000000018516C824
		public bool __Gen_Wrap_19(object P0, object P1, object P2, object P3, object P4, object P5) => default; // 0x00000001893DE86C-0x00000001893DE9A4
		public bool __Gen_Wrap_20(object P0, out string P1) {
			P1 = default;
			return default;
		} // 0x00000001893DE9A4-0x00000001893DEADC
		public bool __Gen_Wrap_21(object P0) => default; // 0x000000018225F050-0x000000018225F310
		public void __Gen_Wrap_22(ShaderWarmupManager.WarmUpReason P0) {} // 0x0000000181414CE0-0x0000000181414ED0
		public string __Gen_Wrap_23(IntPtr P0, ref WindowsGpuDriverVersion.SP_DEVINFO_DATA P1, uint P2) => default; // 0x000000018225F310-0x0000000182260230
		public bool __Gen_Wrap_24(object P0, object P1) => default; // 0x0000000182260230-0x00000001822605F0
		public int __Gen_Wrap_25(object P0, object P1, object P2) => default; // 0x00000001811E6540-0x00000001811E69E0
		public string __Gen_Wrap_26(object P0, object P1) => default; // 0x00000001822605F0-0x0000000182261020
		public int __Gen_Wrap_27(WindowsGpuDriverVersion.Result P0, WindowsGpuDriverVersion.Result P1) => default; // 0x000000018131C100-0x000000018131C490
		public List<WindowsGpuDriverVersion.Result> __Gen_Wrap_28() => default; // 0x0000000182261020-0x0000000182261860
		public bool __Gen_Wrap_29() => default; // 0x0000000182261860-0x0000000182261A20
		public void __Gen_Wrap_30(int P0) {} // 0x00000001817AB0B0-0x00000001817AB2A0
		public WindowsGpuDriverVersion.Result __Gen_Wrap_31() => default; // 0x0000000182261A20-0x0000000182262260
		public bool __Gen_Wrap_32(object P0, object P1, out string P2) {
			P2 = default;
			return default;
		} // 0x0000000182262260-0x0000000182262DA0
		public IEnumerator __Gen_Wrap_33(object P0, object P1, object P2) => default; // 0x0000000182262DA0-0x00000001822638A0
		public int __Gen_Wrap_34() => default; // 0x00000001810E9170-0x00000001810E9340
		public void __Gen_Wrap_35(int P0, ref int P1) {} // 0x00000001822638A0-0x0000000182263AD0
		public IEnumerator __Gen_Wrap_36(object P0, int P1, int P2, object P3) => default; // 0x0000000182263AD0-0x0000000182264520
		public IEnumerator __Gen_Wrap_37(bool P0) => default; // 0x0000000182264520-0x0000000182264DA0
		public IEnumerator __Gen_Wrap_38(object P0, int P1, int P2) => default; // 0x0000000182264DA0-0x0000000182265710
		public IEnumerator __Gen_Wrap_39(object P0) => default; // 0x0000000182265710-0x0000000182266040
		public bool __Gen_Wrap_40(ref SceneStateAreaKey P0, SceneStateAreaKey P1) => default; // 0x0000000182266040-0x0000000182266CE0
		public bool __Gen_Wrap_41(ref SceneStateAreaKey P0, object P1) => default; // 0x0000000182266CE0-0x0000000182267980
		public int __Gen_Wrap_42(ref SceneStateAreaKey P0) => default; // 0x0000000182267980-0x0000000182268530
		public float __Gen_Wrap_43(object P0) => default; // 0x0000000182268530-0x00000001822687F0
		public bool __Gen_Wrap_44(object P0, bool P1) => default; // 0x00000001822687F0-0x0000000182268AE0
		public bool __Gen_Wrap_45(object P0, float P1, int P2) => default; // 0x0000000182268AE0-0x0000000182268E00
		public Dictionary<int, float> __Gen_Wrap_46(object P0) => default; // 0x0000000182268E00-0x0000000182269740
		public void __Gen_Wrap_47(object P0, object P1) {} // 0x0000000182269740-0x0000000182269AF0
		public EntityRenderCapturedEntity __Gen_Wrap_48(object P0, object P1) => default; // 0x0000000182269AF0-0x000000018226A510
		public int __Gen_Wrap_49(object P0, object P1) => default; // 0x0000000181367D80-0x0000000181368130
		public EntityVFXRendererMask __Gen_Wrap_50(EntityVFXRendererType P0) => default; // 0x000000018121B9D0-0x000000018121BBD0
		public void __Gen_Wrap_51(object P0, object P1, object P2) {} // 0x000000018226A510-0x000000018226A9A0
		public void __Gen_Wrap_52(object P0, object P1, object P2, object P3) {} // 0x000000018226A9A0-0x000000018226AF10
		public Material __Gen_Wrap_53(object P0, EntityRenderHelperMaterialController.AddedMaterialInfo P1, object P2) => default; // 0x000000018226AF10-0x000000018226BCE0
		public Texture __Gen_Wrap_54(object P0, object P1) => default; // 0x000000018226BCE0-0x000000018226C710
		public int __Gen_Wrap_55(object P0, object P1, EntityVFXRendererMask P2, AddMaterialConfig P3) => default; // 0x000000018226C710-0x000000018226CEE0
		public List<EntityRenderHelperMaterialController.RendererInfo> __Gen_Wrap_56(object P0, EntityVFXRendererMask P1, bool P2) => default; // 0x000000018226CEE0-0x000000018226D870
		public void __Gen_Wrap_57(object P0, int P1, float P2) {} // 0x0000000181449B10-0x0000000181449E00
		public float __Gen_Wrap_58(object P0, int P1, float P2) => default; // 0x0000000181AD4620-0x0000000181AD4920
		public void __Gen_Wrap_59(object P0, int P1, Vector4 P2) {} // 0x000000018226D870-0x000000018226DEE0
		public Vector4 __Gen_Wrap_60(object P0, int P1, Vector4 P2) => default; // 0x000000018226DEE0-0x000000018226EBA0
		public void __Gen_Wrap_61(object P0, int P1, object P2) {} // 0x0000000181062520-0x00000001810628B0
		public Texture __Gen_Wrap_62(object P0, int P1, object P2) => default; // 0x000000018226EBA0-0x000000018226F5D0
		public EntityVFXRendererMask __Gen_Wrap_63(object P0, int P1) => default; // 0x000000018120E440-0x000000018120E730
		public bool __Gen_Wrap_64(object P0, int P1, object P2) => default; // 0x0000000181470460-0x0000000181470840
		public void __Gen_Wrap_65(object P0, int P1, EntityVFXRendererMask P2) {} // 0x0000000181204510-0x0000000181204800
		public void __Gen_Wrap_66(object P0, EntityVFXRendererMask P1, object P2) {} // 0x00000001811C4DD0-0x00000001811C51A0
		public void __Gen_Wrap_67(object P0, object P1, bool P2, EntityVFXRendererMask P3) {} // 0x00000001815D2D40-0x00000001815D30F0
		public void __Gen_Wrap_68(object P0, bool P1, EntityVFXRendererMask P2) {} // 0x0000000181A83500-0x0000000181A837F0
		public float __Gen_Wrap_69(object P0, float P1, float P2, int P3) => default; // 0x000000018226F5D0-0x000000018226F920
		public void __Gen_Wrap_70(object P0, EntityRenderHelperCustomPerDrawType P1, float P2, EntityVFXRendererMask P3) {} // 0x00000001811F7520-0x00000001811F7850
		public void __Gen_Wrap_71(object P0, EntityRenderHelperVectorCustomPerDrawType P1, Vector4 P2, EntityVFXRendererMask P3) {} // 0x000000018226F920-0x000000018226FFD0
		public void __Gen_Wrap_72(object P0, int P1, float P2, EntityVFXRendererMask P3) {} // 0x00000001811F7520-0x00000001811F7850
		public void __Gen_Wrap_73(object P0, int P1, Vector4 P2, EntityVFXRendererMask P3) {} // 0x000000018226FFD0-0x00000001822706A0
		public void __Gen_Wrap_74(object P0, int P1, object P2, EntityVFXRendererMask P3) {} // 0x0000000181542D70-0x0000000181543120
		public Bounds __Gen_Wrap_75(object P0) => default; // 0x00000001822706A0-0x0000000182270F90
		public void __Gen_Wrap_76(object P0, object P1, bool P2) {} // 0x000000018180A7B0-0x000000018180AB70
		public RenderHelperType __Gen_Wrap_77(object P0) => default; // 0x000000018112C230-0x000000018112C4F0
		public List<EntityRendererTypeConfig> __Gen_Wrap_78(object P0, bool P1) => default; // 0x0000000182270F90-0x00000001822718F0
		public float __Gen_Wrap_79(object P0, bool P1) => default; // 0x00000001822718F0-0x0000000182271BE0
		public EntityVFXPriorityType __Gen_Wrap_80(object P0) => default; // 0x000000018112C230-0x000000018112C4F0
		public void __Gen_Wrap_81(object P0, float P1, bool P2) {} // 0x0000000182271BE0-0x0000000182271EE0
		public Material __Gen_Wrap_82(object P0, object P1, object P2) => default; // 0x0000000182271EE0-0x00000001822729E0
		public bool __Gen_Wrap_83(EntityVFXFactoryAddedMaterialManager.AddedMaterialData P0) => default; // 0x00000001811E77F0-0x00000001811E7AC0
		public void __Gen_Wrap_84(object P0, object P1, int P2, float P3) {} // 0x0000000181AB8A20-0x0000000181AB8DD0
		public void __Gen_Wrap_85(object P0, object P1, int P2, Vector4 P3) {} // 0x00000001822729E0-0x0000000182273140
		public Material __Gen_Wrap_86(object P0, object P1, Vector4 P2) => default; // 0x0000000182273140-0x0000000182273EF0
		public ValueTuple<float, float> __Gen_Wrap_87(Bounds P0, Vector3 P1) => default; // 0x0000000182273EF0-0x0000000182274E50
		public void __Gen_Wrap_88(object P0, bool P1, Vector3 P2, bool P3, float P4, out float P5, out float P6, out Vector3 P7) {
			P5 = default;
			P6 = default;
			P7 = default;
		} // 0x0000000182274E50-0x0000000182275AD0
		public EntityVFXCurveEvaluateResult __Gen_Wrap_89(object P0, float P1) => default; // 0x0000000182275AD0-0x0000000182276430
		public void __Gen_Wrap_90(object P0, object P1, float P2) {} // 0x0000000182276430-0x0000000182276800
		public void __Gen_Wrap_91(object P0, float P1, object P2, object P3) {} // 0x0000000182276800-0x0000000182276C70
		public void __Gen_Wrap_92(object P0, object P1, object P2, bool P3) {} // 0x0000000181061D10-0x0000000181062180
		public void __Gen_Wrap_93(object P0, HGPsoExtInfo P1) {} // 0x0000000182276C70-0x00000001822772F0
		public void __Gen_Wrap_94(bool P0) {} // 0x00000001822772F0-0x00000001822774E0
		public void __Gen_Wrap_95(bool P0, object P1, object P2) {} // 0x00000001822774E0-0x0000000182277880
		public void __Gen_Wrap_96(object P0, in EventData<string, string> P1) {} // 0x0000000182277880-0x0000000182277F20
		public List<Vector3> __Gen_Wrap_97(object P0, float P1, int P2) => default; // 0x0000000182277F20-0x00000001822788A0
		public Vector3 __Gen_Wrap_98(object P0, Vector2Int P1) => default; // 0x00000001822788A0-0x0000000182279530
		public List<Vector3> __Gen_Wrap_99(object P0, Vector3 P1) => default; // 0x0000000182279530-0x000000018227D630
		public Vector2Int __Gen_Wrap_100(object P0, Vector3 P1) => default; // 0x0000000182251B90-0x00000001822527E0
		public int __Gen_Wrap_101(int P0, int P1, int P2) => default; // 0x00000001818AAA70-0x00000001818AACA0
		public void __Gen_Wrap_102(int P0, int P1) {} // 0x000000018128D790-0x000000018128D990
		public void __Gen_Wrap_103(int P0, int P1, int P2, int P3, object P4) {} // 0x00000001822527E0-0x0000000182252B00
		public UnityEngine.Color __Gen_Wrap_104(object P0, int P1, int P2) => default; // 0x0000000182252B00-0x0000000182253420
		public float[] __Gen_Wrap_105(int P0, float P1) => default; // 0x0000000182253420-0x0000000182253CB0
		public float[,] __Gen_Wrap_106(object P0, object P1, Vector2Int P2) => default; // 0x0000000182253CB0-0x0000000182254A90
		public int __Gen_Wrap_107(object P0, int P1, int P2) => default; // 0x000000018132E5D0-0x000000018132E8C0
		public void __Gen_Wrap_108(Bounds P0, object P1, out Vector3 P2, out Vector3 P3, Vector3? P4) {
			P2 = default;
			P3 = default;
		} // 0x0000000182254A90-0x0000000182255A20
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_109(Vector3 P0, Vector3 P1) => default; // 0x0000000182255A20-0x00000001822566C0
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame __Gen_Wrap_110(Vector3 P0, float P1) => default; // 0x00000001822566C0-0x00000001822572A0
		public List<Vector3> __Gen_Wrap_111(object P0, float P1, int P2, bool P3, float P4) => default; // 0x00000001822572A0-0x0000000182257C60
		public Vector3 __Gen_Wrap_112(ref VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P0, Vector3 P1) => default; // 0x0000000182257C60-0x0000000182258C00
		public void __Gen_Wrap_113(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, out List<Vector2> P2, out List<float> P3, out float P4, out float P5, out float P6, out float P7) {
			P2 = default;
			P3 = default;
			P4 = default;
			P5 = default;
			P6 = default;
			P7 = default;
		} // 0x0000000182258C00-0x0000000182259C80
		public int __Gen_Wrap_114(int P0, int P1) => default; // 0x00000001814F7500-0x00000001814F7710
		public List<int> __Gen_Wrap_115(object P0) => default; // 0x0000000182259C80-0x000000018225A5B0
		public float __Gen_Wrap_116(object P0, int P1, bool P2) => default; // 0x000000018225A5B0-0x000000018225A8B0
		public float __Gen_Wrap_117(Vector2 P0, Vector2 P1, Vector2 P2) => default; // 0x000000018225A8B0-0x000000018225B050
		public List<int> __Gen_Wrap_118(object P0, bool P1, float P2, float P3, float P4) => default; // 0x000000018225B050-0x000000018225BA50
		public VFXSludgeNavUtils.Spline2DProjectAndSimplify.ProcessResult __Gen_Wrap_119(object P0, VFXSludgeNavUtils.Spline2DProjectAndSimplify.Frame P1, float P2, int P3, bool P4, VFXSludgeNavUtils.Spline2DProjectAndSimplify.EdgeMode P5, float P6, float P7, float P8) => default; // 0x000000018225BA50-0x000000018225C720
		public List<Vector2> __Gen_Wrap_120(object P0, float P1, int P2, int P3, bool P4, bool P5) => default; // 0x000000018225C720-0x000000018225D100
		public List<Vector3> __Gen_Wrap_121(object P0, float P1, float P2, bool P3) => default; // 0x000000018225D100-0x000000018225DAF0
		public void __Gen_Wrap_122(object P0, ref List<Vector2> P1, int P2, bool P3, bool P4, bool P5) {} // 0x000000018225DAF0-0x000000018225E600
		public List<Vector3> __Gen_Wrap_123(object P0, object P1, float P2) => default; // 0x000000018225E600-0x000000018225F050
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object>, IAsyncStateMachine // TypeDefIndex: 55360
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
		object IEnumerator<System.Object>.Current { [IDTag(2)] get => default; } // 0x00000001893DF1C8-0x00000001893DF274 
		object IEnumerator.Current { [IDTag(4)] get => default; } // 0x00000001893DF274-0x00000001893DF320 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001893DF320-0x00000001893DF414
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose() {} // 0x0000000185152EA8-0x0000000185152F24
		[IDTag(1)]
		private bool MoveNext() => default; // 0x0000000185152C48-0x0000000185152CD4
		[IDTag(3)]
		void IEnumerator.Reset() {} // 0x0000000185152D80-0x0000000185152DFC
		[IDTag(5)]
		private void MoveNext() {} // 0x00000001892AF434-0x00000001892AF4C4
		[IDTag(6)]
		private void SetStateMachine(IAsyncStateMachine P0) {} // 0x00000001892AF694-0x00000001892AF744
		public void RefAwaitUnsafeOnCompleteMethod() {} // 0x00000001893DF13C-0x00000001893DF1C8
		public void RefAsyncBuilderStartMethod() {} // 0x00000001893DF0F8-0x00000001893DF13C
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 55361
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001893E1AC0-0x00000001893E1B24
		public static bool IsPatched(int id) => default; // 0x00000001827182E0-0x0000000182718380
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001893E197C-0x00000001893E1A48
		public object CreateWrapper(int id) => default; // 0x00000001893E1A48-0x00000001893E1AC0
		public object InitWrapperArray(int len) => default; // 0x00000001893E1B24-0x00000001893E23C4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001893E18D8-0x00000001893E197C
	}

	public enum IDMAP0 // TypeDefIndex: 55362
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
		Beyond-Rendering-ShaderWarmupManager-CheckNeedWarmUpLogin0 = 55,
		Beyond-Rendering-ShaderWarmupManager-_ResetWarmUpStats0 = 56,
		Beyond-Rendering-ShaderWarmupManager-_IsDeviceSupportWarmUp0 = 57,
		Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByFirstEntry0 = 58,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByGraphicsChange0 = 59,
		Beyond-Rendering-ShaderWarmupManager-_SetWarmupRetryCount0 = 60,
		Beyond-Rendering-ShaderWarmupManager-_SetWarmupUnfinishedCount0 = 61,
		Beyond-Rendering-ShaderWarmupManager-_CheckWarmUpUnfinishedOften0 = 62,
		Beyond-Rendering-ShaderWarmupManager-_CheckNeedWarmUpByDeviceState0 = 63,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupDx11Driver0 = 64,
		Beyond-Rendering-WindowsGpuDriverVersion-IsBestMatchDriverVersionChanged0 = 65,
		Beyond-Rendering-WindowsGpuDriverVersion-GetBestMatch0 = 66,
		Beyond-Rendering-WindowsGpuDriverVersion-_TryGetDriverVersionByKeyId0 = 67,
		Beyond-Rendering-ShaderWarmupManager-_IsNeedWarmupByCacheOutdated0 = 68,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersLogin0 = 69,
		Beyond-Rendering-ShaderWarmupManager-_LoadPsoAssets0 = 73,
		Beyond-Rendering-ShaderWarmupManager-_GetLoginTimeLimit0 = 80,
		Beyond-Rendering-ShaderWarmupManager-_WarmupOnePsoTimeLimited0 = 81,
		Beyond-Rendering-PsoCreateUploadHelper-BeforeWarmUpBegin0 = 85,
		Beyond-Rendering-PsoCreateUploadHelper-IsPsoRecordEnabled0 = 86,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Tick0 = 87,
		Beyond-Rendering-ShaderWarmupManager-_StepProgress0 = 90,
		Beyond-Rendering-PsoCreateUploadHelper-AfterWarmUpFinish0 = 91,
		Beyond-Rendering-ShaderWarmupManager-WarmupShadersScene0 = 98,
		Beyond-Rendering-ShaderWarmupManager-WarmupOnePso0 = 102,
		Beyond-Rendering-ShaderWarmupManager-TimeCostCounter-Begin0 = 112,
		Beyond-Rendering-WindowsGpuDriverVersion-GetCurrentDriverVersion0 = 113,
		Beyond-Rendering-WindowsGpuDriverVersion-SerializeAllCurrentResults0 = 114,
		Beyond-Rendering-WindowsGpuDriverVersion-Result-ToString0 = 115,
		Beyond-Rendering-WindowsGpuDriverVersion-SafeRegistryHandle-ReleaseHandle0 = 116,
		Beyond-Rendering-SceneStateAreaKey-Equals0 = 117,
		Beyond-Rendering-SceneStateAreaKey-Equals1 = 118,
		Beyond-Rendering-SceneStateAreaKey-GetHashCode0 = 119,
		Beyond-Rendering-EntityRenderAlphaDitherController-ResetDitherAlpha0 = 120,
		Beyond-Rendering-EntityRenderAlphaDitherController-_ApplyNewAlpha0 = 121,
		Beyond-Rendering-EntityRenderAlphaDitherController-_GetCurMinAlpha0 = 122,
		Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherEnabled0 = 123,
		Beyond-Rendering-EntityRenderAlphaDitherController-_SetMaterialDitherAlpha0 = 124,
		Beyond-Rendering-EntityRenderAlphaDitherController-SetDitherAlpha0 = 125,
		Beyond-Rendering-EntityRenderAlphaDitherController-GetDitherAlpha0 = 126,
		Beyond-Rendering-EntityRenderAlphaDitherController-Reset0 = 127,
		Beyond-Rendering-EntityRenderAlphaDitherController-GetAlphaDictionary0 = 128,
		Beyond-Rendering-EntityRenderCaptureMeshController-Reset0 = 129,
		Beyond-Rendering-EntityRenderCaptureMeshController-Release0 = 130,
		Beyond-Rendering-EntityRenderCaptureMeshController-LateTick0 = 131,
		Beyond-Rendering-EntityRenderCaptureMeshController-_SyncTransformInRenderPipeline0 = 132,
		Beyond-Rendering-EntityRenderCaptureMeshController-Capture0 = 133,
		Beyond-Rendering-EntityRenderHelperMaterialController-Init0 = 134,
		Beyond-Rendering-EntityRenderHelperMaterialController-_GetSubMeshCount0 = 135,
		Beyond-Rendering-EntityVFXUtils-ToMask0 = 136,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Init0 = 137,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Init0 = 138,
		Beyond-Rendering-EntityRenderHelperMaterialController-OnRelease0 = 139,
		Beyond-Rendering-EntityRenderHelperMaterialController-Reset0 = 140,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-Reset0 = 141,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-ApplySharedMaterialArray0 = 142,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_GetCustomizePropertyMaterial0 = 143,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-Reset0 = 144,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReleaseAllReplaceMaterial0 = 145,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_ReplaceSharedMaterial0 = 146,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-Clear0 = 147,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Reset0 = 148,
		Beyond-Rendering-EntityRenderHelperMaterialController-IsAllRendererValid0 = 149,
		Beyond-Rendering-EntityRenderHelperMaterialController-StopShadowCasting0 = 150,
		Beyond-Rendering-EntityRenderHelperMaterialController-RevertShadowCastingMode0 = 151,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddMaterialToAllRenderer0 = 152,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireAddMaterial0 = 153,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-_InitCustomizeRendererProperty0 = 154,
		Beyond-Rendering-EntityCustomizeRendererPropertyConfig-GetColorTexture0 = 155,
		Beyond-Rendering-EntityRenderHelperMaterialController-_GetRenderersOfRendererMask0 = 156,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveFloatProperty0 = 157,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveFloatProperty0 = 158,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveFloatProperty0 = 159,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveFloatProperty0 = 160,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveVectorProperty0 = 161,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveVectorProperty0 = 162,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveVectorProperty0 = 163,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveVectorProperty0 = 164,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetAddictiveTextureProperty0 = 165,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-SetAddictiveTextureProperty0 = 166,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddictiveTextureProperty0 = 167,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddictiveTextureProperty0 = 168,
		Beyond-Rendering-EntityRenderHelperMaterialController-RemoveMaterialFromAllRenderer0 = 169,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-RequireRemoveMaterial0 = 170,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 171,
		Beyond-Rendering-EntityRenderHelperMaterialController-AddedMaterialController-GetAddedMaterialsOfCustomizeProperties0 = 172,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetKeywordEnableToAllMaterial0 = 173,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetKeywordEnableToAllMaterial0 = 174,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_GetAffectGroupData0 = 175,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_SplitRenderers0 = 176,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialGroupData-CopyFrom0 = 177,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CopyReplaceMaterial0 = 178,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-_CreateReplaceMaterial0 = 179,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 180,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetDepthOnlyPassEnableToAllMaterial0 = 181,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToCustomPerDraw0 = 182,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-Init0 = 183,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetFloatToCustomPerDraw0 = 184,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-_PackUNorm8ToFloat0 = 185,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToCustomPerDraw0 = 186,
		Beyond-Rendering-EntityRenderHelperMaterialController-CustomPerDrawDataController-SetVectorToCustomPerDraw0 = 187,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetFloatToAllMaterial0 = 188,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetFloatToAllMaterial0 = 189,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetVectorToAllMaterial0 = 190,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetVectorToAllMaterial0 = 191,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetTextureToAllMaterial0 = 192,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetTextureToAllMaterial0 = 193,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherAlphaValue0 = 194,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetManualDitherEnable0 = 195,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetRendererBounds0 = 196,
		Beyond-Rendering-EntityRenderHelperMaterialController-SetZTestInMaterial0 = 197,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-SetZTestInMaterial0 = 198,
		Beyond-Rendering-EntityRenderHelperMaterialController-GetRenderHelperType0 = 199,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseFloatToAllMaterial0 = 200,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseVectorToAllMaterial0 = 201,
		Beyond-Rendering-EntityRenderHelperMaterialController-MeshMaterialController-ReleaseTextureToAllMaterial0 = 202,
		Beyond-Rendering-EntityRenderHelperVisibleController-Init0 = 203,
		Beyond-Rendering-EntityRenderHelperVisibleController-_InitDictionary0 = 204,
		Beyond-Rendering-EntityRenderHelperVisibleController-Release0 = 205,
		Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByNameContainsStr0 = 206,
		Beyond-Rendering-EntityRenderHelperVisibleController-RendererInfo-get_rendererName0 = 207,
		Beyond-Rendering-EntityRenderHelperVisibleController-SetVisibleByRenderer0 = 208,
		Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByNameContainsStr0 = 209,
		Beyond-Rendering-EntityRenderHelperVisibleController-ResetVisibleByRenderer0 = 210,
		Beyond-Rendering-EntityRenderHelperVisibleController-Reset0 = 211,
		Beyond-Rendering-EntityRenderMaterialManager-SetFloat0 = 212,
		Beyond-Rendering-EntityRenderMaterialManager-SetTexture0 = 213,
		Beyond-Rendering-EntityRenderMaterialManager-SetVector0 = 214,
		Beyond-Rendering-EntityRenderMaterialManager-AddMaterial0 = 215,
		Beyond-Rendering-EntityRenderMaterialManager-RemoveMaterial0 = 216,
		Beyond-Rendering-EntityRenderMaterialManager-_RevertMaterial0 = 217,
		Beyond-Rendering-EntityRenderMaterialManager-ClearMaterials0 = 218,
		Beyond-Rendering-EntityRenderMaterialManager-SetKeywordEnable0 = 219,
		Beyond-Rendering-EntityRenderMaterialManager-SetDepthOnlyEnabled0 = 220,
		Beyond-Rendering-EntityRenderMaterialManager-SetZTestInMaterial0 = 221,
		Beyond-Rendering-EntityVFXAsset-GetRendererTypeConfigs0 = 222,
		Beyond-Rendering-EntityVFXAssetBase-get_assetName0 = 223,
		Beyond-Rendering-EntityVFXControllerBase-SetOwner0 = 224,
		Beyond-Rendering-EntityVFXControllerBase-InitLOD0 = 225,
		Beyond-Rendering-EntityVFXControllerBase-SetName0 = 226,
		Beyond-Rendering-EntityVFXControllerBase-Destroy0 = 227,
		Beyond-Rendering-EntityVFXControllerBase-OnDestroy0 = 228,
		Beyond-Rendering-EntityVFXControllerBase-Play0 = 229,
		Beyond-Rendering-EntityVFXControllerBase-Stop0 = 230,
		Beyond-Rendering-EntityVFXControllerBase-Replay0 = 231,
		Beyond-Rendering-EntityVFXControllerBase-Tick0 = 232,
		Beyond-Rendering-EntityVFXControllerBase-RefreshLastTickTime0 = 233,
		Beyond-Rendering-EntityVFXControllerBase-GetDeltaTimeFromLastTick0 = 234,
		Beyond-Rendering-EntityVFXControllerBase-GetPriorityType0 = 235,
		Beyond-Rendering-EntityVFXControllerBase-GetNeedTick0 = 236,
		Beyond-Rendering-EntityVFXControllerBase-Hide0 = 237,
		Beyond-Rendering-EntityVFXControllerBase-OnHide0 = 238,
		Beyond-Rendering-EntityVFXControllerBase-Show0 = 239,
		Beyond-Rendering-EntityVFXControllerBase-OnShow0 = 240,
		Beyond-Rendering-EntityVFXControllerBase-Sample0 = 241,
		Beyond-Rendering-EntityVFXControllerBase-OnSample0 = 242,
		Beyond-Rendering-EntityVFXControllerStateBase-Play0 = 243,
		Beyond-Rendering-EntityVFXControllerStateBase-Replay0 = 247,
		Beyond-Rendering-EntityVFXControllerStateBase-Stop0 = 248,
		Beyond-Rendering-EntityVFXControllerStateBase-_FinalStop0 = 249,
		Beyond-Rendering-EntityVFXControllerStateBase-GetNeedTick0 = 250,
		Beyond-Rendering-EntityVFXControllerStateBase-Tick0 = 251,
		Beyond-Rendering-EntityVFXControllerStateBase-OnSample0 = 255,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-Init0 = 256,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_AddVATMaterial0 = 257,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetVATMaterial0 = 258,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_GetAddedMaterialIndex0 = 259,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-_RemoveVATMaterial0 = 262,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-AddMaterialToAllRenderer0 = 265,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-RemoveMaterialFromAllRenderer0 = 266,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetFloatToFactoryMaterial0 = 267,
		Beyond-Rendering-EntityVFXFactoryAddedMaterialManager-SetVectorToFactoryMaterial0 = 268,
		Beyond-Rendering-EntityVFXFactoryMaterialCache-GetVATMaterial0 = 269,
		Beyond-Rendering-EntityVFXFactoryMaterialCache-ReleaseVATMaterial0 = 270,
		Beyond-Rendering-EntityVFXUtils-CalculateCutOffBounds0 = 271,
		Beyond-Rendering-EntityVFXUtils-GetBoundsMinMaxOfDirection0 = 272,
		Beyond-Rendering-EntityVFXUtils-ApplyEntityVFXCurves0 = 273,
		Beyond-Rendering-EntityVFXUtils-_UpdateCurve0 = 274,
		Beyond-Rendering-EntityVFXUtils-Evaluate0 = 275,
		Beyond-Rendering-CommonVAT-get_PropertySetterType0 = 276,
		Beyond-Rendering-CommonVAT-Start0 = 277,
		Beyond-Rendering-CommonVAT-Play0 = 278,
		Beyond-Rendering-CommonVAT-_DoPlay0 = 279,
		Beyond-Rendering-CommonVAT-_ClearTimer0 = 280,
		Beyond-Rendering-CommonVAT-_UpdateProperty0 = 281,
		Beyond-Rendering-CommonVAT-_NextPlay0 = 282,
		Beyond-Rendering-CommonVAT-_CreateTimer0 = 283,
		Beyond-Rendering-FactoryVAT-Start0 = 284,
		Beyond-Rendering-FactoryVAT-_InitRenderer0 = 285,
		Beyond-Rendering-FactoryVAT-_InitRenderer_MeshRender0 = 286,
		Beyond-Rendering-FactoryVAT-Reset0 = 287,
		Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer0 = 288,
		Beyond-Rendering-FactoryVAT-_ReSetParamsToRenderer_MeshRender0 = 289,
		Beyond-Rendering-FactoryVAT-_UpdateAnim0 = 290,
		Beyond-Rendering-FactoryVAT-_SetParamsToRenderer0 = 291,
		Beyond-Rendering-FactoryVAT-_SetParamsToRenderer_MeshRender0 = 292,
		Beyond-Rendering-FactoryVAT-_DoPlay0 = 293,
		Beyond-Rendering-FactoryVAT-OnUpdate0 = 294,
		Beyond-Rendering-FactoryVAT-Play0 = 295,
		Beyond-Rendering-VATRendererPropertySetter-Init0 = 296,
		Beyond-Rendering-VATRendererPropertySetter-SetFloat0 = 297,
		Beyond-Rendering-VATRendererPropertySetter-SetVector0 = 298,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-Init0 = 299,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetFloat0 = 300,
		Beyond-Rendering-VATEntityRendererHelperPropertySetter-SetVector0 = 301,
		Beyond-Rendering-PsoCreateUploadHelper-Initialize0 = 302,
		Beyond-Rendering-PsoCreateUploadHelper-_PsoUploadProcessOneCallBack0 = 303,
		Beyond-Rendering-PsoCreateUploadHelper-_PsoUpdateGameInfoCallBack0 = 304,
		Beyond-Rendering-PsoCreateUploadHelper-Init0 = 305,
		Beyond-Rendering-PsoCreateUploadHelper-_Tick0 = 306,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadPipelineCreatedInfo0 = 307,
		Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFinalJson0 = 308,
		Beyond-Rendering-PsoCreateUploadHelper-_CreateAndUploadFileToServer0 = 311,
		Beyond-Rendering-PsoCreateUploadHelper-_Callback0 = 312,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadFileToServer0 = 313,
		Beyond-Rendering-PsoCreateUploadHelper-_SceneLoadStartHandler0 = 321,
		Beyond-Rendering-PsoCreateUploadHelper-Dispose0 = 322,
		Beyond-Rendering-PsoCreateUploadHelper-_UploadFile0 = 323,
		Beyond-Rendering-VFXSludgeBaker-Bake0 = 326,
		Beyond-Rendering-VFXSludgeBaker-_CalculatePolygonAndBounds0 = 327,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSpline0 = 328,
		Beyond-Rendering-VFXSludgeBaker-_RaycastSceneObjectsHeight0 = 329,
		Beyond-Rendering-VFXSludgeBaker-GetLocalPosition0 = 330,
		Beyond-Rendering-VFXSludgeBaker-_CalculateInPolygon0 = 331,
		Beyond-Rendering-VFXSludgeUtils-CalculatePointPolygonHorizonRayCross0 = 332,
		Beyond-Rendering-VFXSludgeBaker-GetLocalIndex0 = 333,
		Beyond-Rendering-VFXSludgeBaker-_CalculateInHighPowerZone0 = 334,
		Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance1 = 335,
		Beyond-Rendering-VFXSludgeBaker-_CalculateEdgeSignedDistance0 = 336,
		Beyond-Rendering-VFXSludgeBaker-_GetHash0 = 339,
		Beyond-Rendering-VFXSludgeBaker-_ForAround0 = 340,
		Beyond-Rendering-VFXSludgeBaker-_CalculateThicknessAndTopHeight0 = 343,
		Beyond-Rendering-VFXSludgeBaker-_BlurTopHeight0 = 344,
		Beyond-Rendering-VFXSludgeBaker-_CalculateNormals0 = 345,
		Beyond-Rendering-VFXSludgeBaker-_CreateTexture0 = 346,
		Beyond-Rendering-VFXSludgeBaker-_GetTextureColor10 = 347,
		Beyond-Rendering-VFXSludgeBaker-_CreateGaussianKernel0 = 348,
		Beyond-Rendering-VFXSludgeBaker-_Convolution0 = 349,
		Beyond-Rendering-VFXSludgeBaker-_GetHash1 = 350,
		Beyond-Rendering-VFXSludgeBaker-_GetTextureColor20 = 351,
		Beyond-Rendering-VFXSludgeNavUtils-BoundsUtil-GetTopBottomPoints0 = 352,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameFromPlaneNormal0 = 353,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-MakeFrameByYaw0 = 354,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-SampleUniformByArcLength0 = 355,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ProjectWorldToFrameXZ0 = 356,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-WorldToFrame0 = 357,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-ConvexHullIndices0 = 358,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_AngleDegAt0 = 362,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_CurvatureAt0 = 363,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-_PointToSegmentDistance2D0 = 364,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Simplify2D_ByCurvatureAngleDeviation0 = 365,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Process0 = 366,
		Beyond-Rendering-VFXSludgeNavUtils-Spline2DProjectAndSimplify-Frame-FrameToWorld0 = 367,
		Beyond-Rendering-VFXSludgeNavUtils-SplineSamplingUtils-SampleByArcLength0 = 368,
		Beyond-Rendering-VFXSludgeNavUtils-PolySimplify-SimplifyByAngle0 = 369,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffSplineWithSimplify0 = 370,
		Beyond-Rendering-VFXSludgeUtils-GetPolygonOffByPolyLine0 = 371,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_CreateInstance0 = 372,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_ExtractSplineData0 = 373,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_DestroyInstance0 = 374,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-_Release0 = 375,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Update0 = 376,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnEnable0 = 377,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDisable0 = 378,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDestroy0 = 379,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-OnDrawGizmosSelected0 = 380,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Pause0 = 381,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Play0 = 382,
		Beyond-Rendering-SplineMovingObjects-HGSplineMovingObjects-Stop0 = 383,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-OnEnable0 = 384,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-Awake0 = 385,
		Beyond-Rendering-LODLightmapping-LightmapInfoTransfer-_RendererInfoTransfer0 = 386,
		Beyond-Rendering-LODLightmapping-LODLightmapping-RendererInfoTransfer0 = 387
	}
}
