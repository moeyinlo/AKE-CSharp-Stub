/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Beyond;
using Beyond.Gameplay.BeyondPerformance;
using Beyond.Scripts.Quality;
using Beyond.Scripts.Quality.Components;
using IFix.Core;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

// Image 56: RuntimeQuality.dll - Assembly: RuntimeQuality, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61125-61217
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Gameplay.BeyondPerformance
{
	public enum LogicQualityLevel : byte // TypeDefIndex: 61133
	{
		Economy = 0,
		Balanced = 1,
		Performance = 2,
		Max = 3
	}

	public enum ThermalState : byte // TypeDefIndex: 61134
	{
		GameNormal = 0,
		GameFair = 1,
		GameSerious = 2
	}

	public static class LogicQualityConst // TypeDefIndex: 61135
	{
		// Fields
		public static float s_reduceQualityLevelFPSThresholdRatio; // 0x00
		public static float s_recoverQualityLevelFPSThresholdRatio; // 0x04
	
		// Constructors
		static LogicQualityConst(); // 0x0000000184D5DAF0-0x0000000184D5DB40
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_RuntimeQuality // TypeDefIndex: 61127
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime(); // 0x0000000184CE21B0-0x0000000184CE21E0
		private static void Initialize(); // 0x0000000184CE21E0-0x0000000184CE2260
	}
}

namespace Beyond.Scripts.Quality
{
	public class DeviceInfo // TypeDefIndex: 61137
	{
		// Fields
		public RuntimePlatform m_platform; // 0x10
		[CompilerGenerated]
		private int _DevicesScore_k__BackingField; // 0x14
		public readonly string m_deviceModel; // 0x18
		public readonly string m_deviceName; // 0x20
		public readonly string m_graphicsDeviceName; // 0x28
		public readonly string m_graphicsDeviceVersion; // 0x30
		public readonly string m_cpuDeviceName; // 0x38
		public readonly int m_systemMemorySize; // 0x40
		public readonly int m_GPUMemorySize; // 0x44
		public readonly int m_processorCount; // 0x48
		public readonly GraphicsDeviceType m_graphicsDeviceType; // 0x4C
		public DeviceMatchRules m_matchRules; // 0x50
		public DeviceMatchResult m_matchResult; // 0x58
		public bool bEditorSimulator; // 0x78
		public readonly string m_SystemInfo; // 0x80
		private const string ADRENO_KEY = "Adreno"; // Metadata: 0x0234F1E2
		private const string ADRENO_PATTERN = "Adreno\\D*(?<Model>\\d+)\\W*(?<Extra>l?)"; // Metadata: 0x0234F1E9
		private const string ADRENO_STANDARD_FORMAT = "Adreno {0}{1}"; // Metadata: 0x0234F20F
		private const string MALI_KEY = "Mali"; // Metadata: 0x0234F21D
		private const string MALI_PATTERN = "Mali[-|\\s](?<Prefix>[A-Za-z]?)(?<Model>\\d+)\\W*(?<Rare>(3EE|Immortalis|Ultra)?)\\W*(?<CoreType>(MC|MP)?)\\W*(?<CoreCount>\\d*)"; // Metadata: 0x0234F222
		private const string MALI_STANDARD_FORMAT = "Mali-{0}{1}{2}{3}{4}"; // Metadata: 0x0234F29E
		private const string POWER_VR_KEY = "PowerVR"; // Metadata: 0x0234F2B3
		private const string POWER_VR_PATTERN = "PowerVR[-|\\s](?<Prefix>[A-Za-z]*)(?<Model>\\d+)"; // Metadata: 0x0234F2BB
		private const string POWER_VR_STANDARD_FORMAT = "PowerVR {0}{1}"; // Metadata: 0x0234F2EA
		private const string NVIDIA_KEY = "(NVIDIA|GTX|RTX|Quadro|GeForce)"; // Metadata: 0x0234F2F9
		private const string NVIDIA_PATTERN = "(?<Prefix>RTX|GTX)\\s+(?![A-Z])(?<Model>\\d+)\\W*(?<Extra>\\w+)?"; // Metadata: 0x0234F319
		private const string NVIDIA_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x0234F356
		private const string TITAN_PATTERN = "(?<Prefix>RTX|GTX)?\\D*(?<Model>TITAN)\\W*(?<Extra>\\w+)?"; // Metadata: 0x0234F35E
		private const string NVIDIA_FALLBACK = "\\bNVIDIA\\b[\\s:-]*(?<rest>.+)$"; // Metadata: 0x0234F395
		private const string AMD_KEY = "(AMD|ATI|Radeon)"; // Metadata: 0x0234F3B3
		private const string AMD_PATTERN = "Radeon\\s?(\\(TM\\))?\\s?(?<Prefix>R9|RX|HD)?\\W*(?<Model>\\d+)?\\W*(?<Extra>\\w+)?"; // Metadata: 0x0234F3C4
		private const string AMD_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x0234F411
		private const string AMD_FALLBACK = "\\bAMD\\b[\\s:-]*(?<rest>.+)$"; // Metadata: 0x0234F419
		private const string INTEL_KEY = "Intel"; // Metadata: 0x0234F434
		private const string INTEL_PATTERN = "Intel\\S+[-|\\s](?<Model>Arc)\\S+[-|\\s](?<Extra>[A-Za-z]\\d+)?"; // Metadata: 0x0234F43A
		private const string INTEL_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x0234F475
		private const string INTEL_PATTERN_2 = "Intel\\S+[-|\\s](?<Model>HD)[-|\\s](?<Extra>Graphics)"; // Metadata: 0x0234F47D
		private const string INTEL_FALLBACK = "Intel\\s*(?:\\(R\\)\\s*)?(?<rest>.+)$"; // Metadata: 0x0234F4B0
	
		// Properties
		public int DevicesScore { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		public static string cpuName { get; } // 0x000000018350CDE0-0x000000018350CE10 
	
		// Nested types
		public enum MatchType // TypeDefIndex: 61136
		{
			WhiteList = 0,
			SystemVersion = 1,
			GPU = 2,
			CPU = 3,
			DefaultScore = 4,
			MemoryCorrection = 5,
			HardCode = 6
		}
	
		// Constructors
		public DeviceInfo(string remoteJson = null); // 0x000000018350CC90-0x000000018350CDE0
		public DeviceInfo(RuntimePlatform platform, string deviceName, string deviceModel, string graphicsDeviceName, string graphicsDeviceVersion, string systemMemorySize, string processorName, string processorCount, string processorFrequency); // 0x000000018AC3DCF4-0x000000018AC3DD8C
	
		// Methods
		public void SupplementFromRemote(string json); // 0x000000018350AE10-0x000000018350AE90
		public sealed override string ToString(); // 0x000000018454FCA0-0x0000000184550040
		public bool IsNoMatchDevice(); // 0x000000018AC3D450-0x000000018AC3D4AC
		public bool IsZeroDevices(); // 0x0000000184854560-0x0000000184854590
		public bool IsHUAWEIDevice(); // 0x000000018AC3D394-0x000000018AC3D450
		public bool IsQualcommDevice(); // 0x000000018AC3D4AC-0x000000018AC3D530
		public DeviceMatchRules LoadingSettingRules(); // 0x000000018350C760-0x000000018350C7F0
		public int GetDeviceScore(string remoteJson = null); // 0x000000018350AEC0-0x000000018350C760
		public int EditorSimulateGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018AC3C560-0x000000018AC3C64C
		public int IOSGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018AC3D054-0x000000018AC3D394
		public int AndroidGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018AC3C2F8-0x000000018AC3C4B4
		public int StandaloneGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018350C7F0-0x000000018350CC90
		public int StandaloneOSXGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018AC3DA0C-0x000000018AC3DA60
		public int CloudGameGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018AC3C4B4-0x000000018AC3C50C
		public int StandalonePS5GetMatchedRule(DeviceInfo deviceInfo); // 0x000000018AC3DA60-0x000000018AC3DB10
		public int DefaultGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018AC3C50C-0x000000018AC3C560
		public bool RuleSuffixMatch(List<RankingRule> list, string name, ref RankingRule matchedRule); // 0x00000001841297C0-0x0000000184129CE0
		public static bool RuleFullNameMatch(List<RankingRule> list, string name, ref RankingRule matchedRule); // 0x000000018AC3D82C-0x000000018AC3DA0C
		public bool MatchDeviceModeRule(List<RankingRule> list, string deviceModel, ref RankingRule rule); // 0x000000018AC3D530-0x000000018AC3D5D8
		public bool MatchGPURule(DeviceMatchRules rules, string gpu, ref RankingRule rule, out string standardName); // 0x000000018AC3D5D8-0x000000018AC3D82C
		private bool StandaloneMatchGPURule(DeviceMatchRules rules, string gpu, ref RankingRule rule, out string standardName); // 0x00000001841291C0-0x0000000184129340
		private string GetNvidiaStandardGPUName(string gpu); // 0x000000018AC3CCD0-0x000000018AC3CF18
		private string GetAmdStandardGPUName(string gpu); // 0x0000000184129440-0x0000000184129610
		private string GetIntelStandardGPUName(string gpu); // 0x000000018AC3C788-0x000000018AC3C9E8
		private string GetAdrenoStandardGPUName(string gpu); // 0x000000018AC3C64C-0x000000018AC3C788
		private string GetMaliStandardGPUName(string gpu); // 0x000000018AC3C9E8-0x000000018AC3CCD0
		private string GetPowerVRStandardGPUName(string gpu); // 0x000000018AC3CF18-0x000000018AC3D054
		private static void _ReportMatchRuleFailed(DeviceInfo deviceModel); // 0x000000018AC3DB10-0x000000018AC3DCF4
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	[Serializable]
	public struct RankingRule : IEquatable<RankingRule> // TypeDefIndex: 61138
	{
		// Fields
		public string regexPattern; // 0x00
		public int targetScore; // 0x08
	
		// Methods
		public bool Equals(RankingRule other); // 0x000000018AC45920-0x000000018AC45990
		public override string ToString(); // 0x00000001845501D0-0x0000000184550260
		public string __iFixBaseProxy_ToString(); // 0x000000018AC45990-0x000000018AC459E0
	}

	[Serializable]
	public struct MemoryRule : IEquatable<MemoryRule> // TypeDefIndex: 61139
	{
		// Fields
		public Vector2 range; // 0x00
		public int targetScore; // 0x08
	
		// Methods
		public override string ToString(); // 0x000000018AC425D0-0x000000018AC4269C
		public bool Equals(MemoryRule other); // 0x000000018AC42560-0x000000018AC425D0
		public string __iFixBaseProxy_ToString(); // 0x000000018AC4269C-0x000000018AC426F4
	}

	public static class ListUtils // TypeDefIndex: 61140
	{
		// Methods
		public static void AddOrReplace<TItem>(List<TItem> source, List<TItem> remote)
			where TItem : IEquatable<TItem>;
	}

	public class DeviceMatchRules // TypeDefIndex: 61141
	{
		// Fields
		public int DefaultIOSRankingRule; // 0x10
		public int DefaultAndroidScore; // 0x14
		public int DefaultStandAloneScore; // 0x18
		public int DefaultPowerVRScore; // 0x1C
		public List<RankingRule> appleWhiteList; // 0x20
		public List<RankingRule> appleGPUList; // 0x28
		public List<RankingRule> androidWhiteList; // 0x30
		public List<RankingRule> adrenoRulesList; // 0x38
		public List<RankingRule> maliRulesList; // 0x40
		public List<RankingRule> powerVRRulesList; // 0x48
		public List<RankingRule> androidGPUWhiteList; // 0x50
		public List<RankingRule> androidCPUWhiteList; // 0x58
		public List<MemoryRule> iOSMemoryRules; // 0x60
		public List<MemoryRule> androidMemoryRules; // 0x68
		public List<RankingRule> nvidiaRulesList; // 0x70
		public List<RankingRule> amdRulesList; // 0x78
		public List<RankingRule> intelRulesList; // 0x80
		public List<MemoryRule> standaloneMemoryRules; // 0x88
		public List<RankingRule> macSocRulesList; // 0x90
	
		// Constructors
		public DeviceMatchRules(); // 0x0000000184D7B090-0x0000000184D7B0B0
	
		// Methods
		public void Combine(DeviceMatchRules other); // 0x000000018AC3DE30-0x000000018AC3E00C
	}

	public struct DeviceMatchResult // TypeDefIndex: 61142
	{
		// Fields
		private RankingRule m_rule; // 0x00
		private Beyond.Scripts.Quality.DeviceInfo.MatchType m_matchType; // 0x10
		private string gpuStandardName; // 0x18
	
		// Constructors
		public DeviceMatchResult(RankingRule r, Beyond.Scripts.Quality.DeviceInfo.MatchType type, string gpuStandardName); // 0x000000018350AE90-0x000000018350AEC0
	
		// Methods
		public override string ToString(); // 0x0000000184550040-0x00000001845501D0
		public bool IsNoMatch(); // 0x000000018AC3DD8C-0x000000018AC3DDD8
		public string __iFixBaseProxy_ToString(); // 0x000000018AC3DDD8-0x000000018AC3DE30
	}

	[Serializable]
	public struct DeviceQualityMapItem // TypeDefIndex: 61143
	{
		// Fields
		public string name; // 0x00
		public int deviceScore; // 0x08
		public int defaultLevel; // 0x0C
		public int veryLowLevel; // 0x10
		public int lowLevel; // 0x14
		public int middleLevel; // 0x18
		public int highLevel; // 0x1C
		public int veryHighLevel; // 0x20
	
		// Methods
		public override string ToString(); // 0x000000018AC3E00C-0x000000018AC3E240
		private UnityEngine.Color getColor(int level); // 0x000000018AC3E2A4-0x000000018AC3E33C
		private UnityEngine.Color getVeryLowColor(); // 0x000000018AC3E50C-0x000000018AC3E580
		private UnityEngine.Color getLowColor(); // 0x000000018AC3E3B0-0x000000018AC3E424
		private UnityEngine.Color getMiddleColor(); // 0x000000018AC3E424-0x000000018AC3E498
		private UnityEngine.Color getHighColor(); // 0x000000018AC3E33C-0x000000018AC3E3B0
		private UnityEngine.Color getVeryHighColor(); // 0x000000018AC3E498-0x000000018AC3E50C
		public string __iFixBaseProxy_ToString(); // 0x000000018AC3E240-0x000000018AC3E2A4
	}

	[Serializable]
	public class DeviceQualityMap // TypeDefIndex: 61144
	{
		// Fields
		public RuntimePlatform m_platform; // 0x10
		public List<DeviceQualityMapItem> items; // 0x18
	
		// Constructors
		public DeviceQualityMap(); // 0x0000000184CDB860-0x0000000184CDB8E0
	}

	public static class QualityConst // TypeDefIndex: 61145
	{
		// Fields
		public const string SIMULATE_DEVICE_LIST = "Assets/Beyond/InitialAssets/Settings/Quality/DeviceList_zip.bytes"; // Metadata: 0x0234F4D9
		public const string SETTING_RULES = "Assets/Beyond/InitialAssets/Settings/Quality/SettingRules.json"; // Metadata: 0x0234F51C
		public const string QUALITY_MAP = "Assets/Beyond/InitialAssets/Settings/Quality/{0}_QualityMap.json"; // Metadata: 0x0234F55B
		public const string QUALITY_TIER_COMPONENTS = "Assets/Beyond/InitialAssets/Settings/Quality/{0}_QualityTierComponent.json"; // Metadata: 0x0234F59D
	}

	public class QualityManager : Singleton<QualityManager>, IDisposable // TypeDefIndex: 61147
	{
		// Fields
		private Beyond.Scripts.Quality.DeviceInfo m_deviceInfo; // 0x10
		private DeviceQualityMap m_qualityMap; // 0x18
		private DeviceQualityMapItem m_matchedConfig; // 0x20
		private Dictionary<GameSetting.GameSettingVideoQuality, int> m_qualityScoreMap; // 0x48
		private List<QualityTierLevel> m_qualityTiers; // 0x50
		private HashSet<System.Type> m_qualityTierTypes; // 0x58
		private Dictionary<System.Type, QualityTierComponentMatch> m_currentQualityTierComponent; // 0x60
		private Dictionary<System.Type, QualityTierComponentMatch> m_overrideQualityTierComponent; // 0x68
		private Dictionary<System.Type, Dictionary<System.Type, Action<QualityTierComponent>>> m_qualityTierComponentChangeCallBack; // 0x70
		private Queue<ValueTuple<System.Type, Action<QualityTierComponent>>> m_queue; // 0x78
		private int m_defaultTier; // 0x80
		private int m_currentTier; // 0x84
		private bool m_overrideFinish; // 0x88
		internal Func<System.Type, bool> resetSaveQualityTier; // 0x90
		private static HashSet<int> s_matchCount; // 0x00
		private static HashSet<QualityTierComponentMatch> s_matchQuality; // 0x08
	
		// Properties
		public DeviceQualityMapItem Config { get; } // 0x000000018AC45394-0x000000018AC45414 
		public int currentTier { get; } // 0x0000000184B4B340-0x0000000184B4B370 
		public int defaultTier { get; } // 0x0000000184B4B310-0x0000000184B4B340 
		public Beyond.Scripts.Quality.DeviceInfo device { get; } // 0x0000000183690520-0x0000000183690550 
		public bool isInitializing { get; } // 0x00000001836904F0-0x0000000183690520 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61146
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<QualityTierLevel, int> __9__29_0; // 0x08
			public static Func<QualityTierComponentMatch, int> __9__30_0; // 0x10
			public static Func<DeviceQualityMapItem, int> __9__31_0; // 0x18
			public static Func<DeviceQualityMapItem, int> __9__32_0; // 0x20
			public static Comparison<int> __9__66_0; // 0x28
			public static Comparison<int> __9__67_0; // 0x30
			public static Comparison<int> __9__68_0; // 0x38
			public static Comparison<QualityTierComponentMatch> __9__70_0; // 0x40
	
			// Constructors
			static __c(); // 0x0000000184D4AD70-0x0000000184D4ADD0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _LoadQualityTier_b__29_0(QualityTierLevel s); // 0x0000000183E647B0-0x0000000183E647D0
			internal int _setQualityTier_b__30_0(QualityTierComponentMatch x); // 0x00000001848467E0-0x0000000184846800
			internal int _ApplyQualityScore_b__31_0(DeviceQualityMapItem s); // 0x0000000184D94D70-0x0000000184D94D80
			internal int _ApplyShaderTier_b__32_0(DeviceQualityMapItem s); // 0x0000000184D94D70-0x0000000184D94D80
			internal int _GetQualityComponentDefaultTier_b__66_0(int a, int b); // 0x000000018AC4664C-0x000000018AC46668
			internal int _GetQualityComponentTier_b__67_0(int a, int b); // 0x000000018AC4664C-0x000000018AC46668
			internal int _SetQualityComponentTier_b__68_0(int a, int b); // 0x000000018AC4664C-0x000000018AC46668
			internal int __GetCurrentComponentTierIndex_b__70_0(QualityTierComponentMatch a, QualityTierComponentMatch b); // 0x000000018AC46668-0x000000018AC46680
		}
	
		// Constructors
		[UnityEngine.Scripting.Preserve]
		private QualityManager(); // 0x0000000184A233A0-0x0000000184A23540
		static QualityManager(); // 0x0000000184CA3B10-0x0000000184CA3C00
	
		// Methods
		public void Init(string remoteJson = null); // 0x00000001841E3220-0x00000001841E3500
		public void InitOnlyDevice(string remoteJson = null); // 0x0000000184B40C00-0x0000000184B40E50
		public void InitShaderLod(); // 0x00000001841E3500-0x00000001841E37C0
		public void FinishInit(); // 0x0000000184151520-0x0000000184151560
		public void Dispose(); // 0x00000001841E47F0-0x00000001841E4830
		public void LoadQualityTier(string overridePlatform = null); // 0x0000000183899090-0x0000000183899A80
		private void setQualityTier(int qualityTier); // 0x000000018368D6B0-0x000000018368E500
		public void ApplyQualityScore(); // 0x000000018366FDA0-0x00000001836705F0
		public void ApplyShaderTier(); // 0x00000001836705F0-0x0000000183670CC0
		private System.Type _GetQualityComponentByName(string typeName); // 0x00000001836921B0-0x0000000183692360
		public void SetQualityTierByVideoQuality(GameSetting.GameSettingVideoQuality VideoQuality); // 0x0000000184B89CD0-0x0000000184B89D60
		public GameSetting.GameSettingVideoQuality GetDefaultVideoQuality(); // 0x0000000184991510-0x00000001849916A0
		public bool NoMatchDeviceOrZeroScore(); // 0x0000000184854520-0x0000000184854560
		[UnityEngine.Scripting.Preserve]
		public bool IsQualcommDevice(); // 0x000000018AC44430-0x000000018AC44484
		[UnityEngine.Scripting.Preserve]
		public bool IsHUAWEIDevice(); // 0x000000018AC44368-0x000000018AC443BC
		[UnityEngine.Scripting.Preserve]
		public static bool IsIpadDevice(); // 0x000000018AC443BC-0x000000018AC44430
		public bool IsVideoQualityEnable(GameSetting.GameSettingVideoQuality VideoQuality); // 0x000000018AC44594-0x000000018AC445F0
		public void InitResetQualityTierComponentFunction(Func<System.Type, bool> func); // 0x0000000184150EE0-0x0000000184150FD0
		public bool ResetQualityTierComponentValue(System.Type type); // 0x0000000184485530-0x0000000184485580
		private QualityTierComponentMatch _SetQualityTierComponentLevel(System.Type type, int level); // 0x0000000183899A80-0x0000000183899EC0
		public void ForceSetQualityTierComponentLevel(string type, int level); // 0x0000000184A3C4A0-0x0000000184A3C610
		public void RevertSetQualityTierComponentLevel(string type); // 0x000000018AC447E8-0x000000018AC44974
		public bool NeedRestart(); // 0x000000018AC445F0-0x000000018AC447E8
		public void ApplyCallBack(); // 0x0000000184151560-0x0000000184151620
		private QualityTierComponentMatch _GetOverrideQualityTierComponentLevel(System.Type type); // 0x0000000183690550-0x0000000183690610
		public QualityTierType GetQualityTierComponentTierType(string type); // 0x0000000184151260-0x00000001841513A0
		public int GetQualityTierComponentTierVersion(string type); // 0x00000001841519F0-0x0000000184151AB0
		private bool _IsToggleQualityTierComponent(string type); // 0x000000018368E580-0x000000018368E660
		private void _ToggleQualityTierComponentLevel(string type, int index); // 0x000000018AC45234-0x000000018AC45394
		public bool IsEnumQualityTierComponent(string type); // 0x000000018368D5D0-0x000000018368D6B0
		public int GetEnumQualityTierComponentCount(string type); // 0x000000018AC42F4C-0x000000018AC43020
		public void SetEnumQualityTierComponentCount(string type, int index); // 0x0000000184A2FD80-0x0000000184A2FEE0
		public bool IsSliderQualityTierComponent(string type); // 0x000000018368D4F0-0x000000018368D5D0
		public void SetSliderQualityTierComponentCount(string type, float value); // 0x000000018AC44974-0x000000018AC44AC4
		public Vector3 GetSliderQualityTierComponent(string type); // 0x000000018AC440A4-0x000000018AC441D8
		public bool InvokeQualityTierComponent(string type, string functionName, params object[] parameters); // 0x000000018AC441D8-0x000000018AC44368
		public void RegisterQualityTierComponentChange<T>(System.Type tierType, Action<QualityTierComponent> cb);
		internal void InvokeChangeCallBack(System.Type type, QualityTierComponent qualityTierComponent); // 0x000000018368E660-0x000000018368EB70
		public ValueTuple<float, float> GetQualityTierComponentTierCount(string type); // 0x000000018AC43D34-0x000000018AC440A4
		public float GetQualityComponentDefaultTier(string type); // 0x000000018AC43020-0x000000018AC43638
		public float GetQualityComponentTier(string type); // 0x000000018AC43638-0x000000018AC43D34
		public void SetQualityComponentTier(string type, float index); // 0x000000018368C030-0x000000018368CC80
		public bool IsQualitySubSettingTierValid(string type, int tier); // 0x000000018AC44484-0x000000018AC44594
		private void _GetCurrentComponentTierIndex(QualityTierComponent qualityTierComponent, out int index, out int defaultTierIndex); // 0x000000018AC44D24-0x000000018AC45234
		public override string ToString(); // 0x000000018AC44AC4-0x000000018AC44D24
		public string DebugQualityTierComponentInfo(); // 0x000000018AC42920-0x000000018AC42D4C
		private static void _ReportQuality(); // 0x000000018368EC90-0x00000001836904F0
		private void _DynamicInitQualitySetting(); // 0x00000001841E3CE0-0x00000001841E3F20
		private void _DynamicReleaseQualitySetting(); // 0x00000001841E3B70-0x00000001841E3CE0
		internal void DynamicQualityChange([IsReadOnly] in EventData<LogicQualityLevel, LogicQualityLevel> data); // 0x0000000183690650-0x0000000183690D70
		internal void DynamicThermalChange([IsReadOnly] in EventData<ThermalState, ThermalState> data); // 0x000000018AC42D4C-0x000000018AC42F4C
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public static class QualityUtility // TypeDefIndex: 61148
	{
		// Fields
		private static JsonSerializerSettings s_settings; // 0x00
	
		// Properties
		public static JsonSerializerSettings JsonSerializerSettings { get; } // 0x00000001835831A0-0x00000001835832B0 
	
		// Methods
		public static T LoadFromCompressedJson<T>();
		public static T LoadingQualityJson<T>(string path)
			where T : class;
		public static T LoadingQualityJsonFromString<T>(string value)
			where T : class;
		private static byte[] Decompress(byte[] data); // 0x000000018AC45660-0x000000018AC45920
	}
}

namespace Beyond.Scripts.Quality.Components
{
	[Serializable]
	public class AntiAliasingQuality : EnumQualityComponent<AntiAliasingQuality.AntiAliasing> // TypeDefIndex: 61150
	{
		// Nested types
		public enum AntiAliasing // TypeDefIndex: 61149
		{
			None = 0,
			CSAA = 1,
			FXAA = 2,
			MSAA = 3
		}
	
		// Constructors
		public AntiAliasingQuality(); // 0x000000018AC3BFCC-0x000000018AC3BFF4
	
		// Methods
		protected override void Apply(); // 0x000000018AC3BF88-0x000000018AC3BFCC
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	public interface IEnumQualityComponent // TypeDefIndex: 61151
	{
		// Methods
		int GetEnumIndex(Enum enumValue);
		int GetEnumIndex();
		int GetDefaultEnumIndex();
		int GetEnumCount();
		void SetEnumIndex(int value);
		string GetEnumName(int index);
	}

	[Serializable]
	public class EnumQualityComponent<T> : QualityTierComponent, IEnumQualityComponent, IQualityComponentExtension<T> // TypeDefIndex: 61152
		where T : Enum
	{
		// Fields
		[JsonProperty]
		[SerializeField]
		private T enumValue;
		[NonSerialized]
		private int? m_currentValue;
		[NonSerialized]
		private string[] m_strings;
	
		// Constructors
		public EnumQualityComponent();
	
		// Methods
		public int GetEnumIndex(Enum enumValue);
		public int GetEnumIndex();
		public int GetDefaultEnumIndex();
		public int GetEnumCount();
		public void SetEnumIndex(int value);
		public string GetEnumName(int index);
		public void SetEnum(T value);
		public T GetValue();
		public T GetDefaultValue();
		public void SetEnumWithOutApply(T value);
	}

	public enum QualityTierType // TypeDefIndex: 61153
	{
		Quality = 0,
		ToggleQuality = 1,
		EnumQuality = 2,
		SliderQuality = 3
	}

	public interface IQualityComponentExtension<T> // TypeDefIndex: 61154
	{
		// Methods
		T GetValue();
		T GetDefaultValue();
	}

	[Serializable]
	public abstract class QualityTierComponent // TypeDefIndex: 61155
	{
		// Fields
		public static Action<string, int> s_removeRegisterKeyAction; // 0x00
		internal bool isNeedStartDirty; // 0x10
	
		// Constructors
		protected QualityTierComponent(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected virtual void Apply(); // 0x0000000184B33480-0x0000000184B334B0
		protected virtual void InitApply(); // 0x00000001846DEB70-0x00000001846DEBB0
		protected virtual void LowMemory(); // 0x000000018AC454F0-0x000000018AC45530
		protected virtual void DynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last); // 0x0000000183690610-0x0000000183690650
		protected virtual void DynamicThermalChange(ThermalState current, ThermalState last); // 0x000000018AC4548C-0x000000018AC454F0
		public virtual int Version(); // 0x000000018480ED30-0x000000018480ED60
		public virtual bool TierLimit(); // 0x000000018AC45618-0x000000018AC45660
		internal virtual int ApplyOrder(); // 0x000000018473B2C0-0x000000018473B2F0
		internal void RemoveQualitySettingSaveValue(string settingId); // 0x000000018AC45530-0x000000018AC45618
		internal void SafeApply(); // 0x000000018368EB70-0x000000018368EC90
		internal void RemoveRegisterKey(); // 0x0000000184A1EC10-0x0000000184A1ECC0
		internal void SafeLowMemory(bool init = false /* Metadata: 0x0234F5F1 */); // 0x000000018368E500-0x000000018368E580
		internal void CallDynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last); // 0x0000000183692360-0x00000001836923C0
		internal virtual void CallDynamicThermalChange(ThermalState current, ThermalState last); // 0x000000018AC45414-0x000000018AC4548C
	}

	public struct QualityTierComponentMatch // TypeDefIndex: 61157
	{
		// Fields
		public QualityTierComponent component; // 0x00
		public MatchSource matchSource; // 0x08
		public int matchQualityTier; // 0x0C
	
		// Nested types
		public enum MatchSource // TypeDefIndex: 61156
		{
			UpClosest = 0,
			DownClosest = 1,
			Matched = 2,
			Override = 3
		}
	}

	[Serializable]
	public class QualityTierLevel // TypeDefIndex: 61158
	{
		// Fields
		public int qualityTier; // 0x10
		[HideInInspector]
		public List<QualityTierComponent> qualityTierComponents; // 0x18
	
		// Constructors
		public QualityTierLevel(); // 0x00000001848E2CA0-0x00000001848E2D20
	}

	[Serializable]
	public class SliderQualityComponent : QualityTierComponent // TypeDefIndex: 61159
	{
		// Fields
		[JsonProperty]
		[SerializeField]
		private float sliderValue; // 0x18
		[JsonProperty]
		[SerializeField]
		private float MaxSliderValue; // 0x1C
		[JsonProperty]
		[SerializeField]
		private float MinSliderValue; // 0x20
		[NonSerialized]
		private float? m_currentSliderValue; // 0x24
	
		// Constructors
		public SliderQualityComponent(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public float GetValue(); // 0x0000000184485340-0x00000001844853B0
		public float GetDefaultValue(); // 0x0000000184D7CA10-0x0000000184D7CA40
		public Vector2 GetRange(); // 0x000000018AC462B0-0x000000018AC46308
		public void SetValue(float value); // 0x000000018AC46308-0x000000018AC463B4
	}

	[Serializable]
	public class ToggleQualityComponent : QualityTierComponent, IQualityComponentExtension<bool> // TypeDefIndex: 61160
	{
		// Fields
		[FormerlySerializedAs("defaultVal")]
		[JsonProperty]
		[SerializeField]
		private bool toggleVal; // 0x18
		[NonSerialized]
		private bool? m_currentValue; // 0x19
	
		// Constructors
		public ToggleQualityComponent(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x000000018368D100-0x000000018368D150
		protected virtual void Toggle(bool value); // 0x000000018AC465F8-0x000000018AC4664C
		public void ChangeToggle(int index); // 0x000000018AC4646C-0x000000018AC465F8
		public bool GetValue(); // 0x000000018368D150-0x000000018368D1B0
		public bool GetDefaultValue(); // 0x000000018368D1B0-0x000000018368D1E0
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class CharacterRenderFeatureQuality : QualityTierComponent // TypeDefIndex: 61161
	{
		// Fields
		public int characterSelfShadowOffLodQuality; // 0x18
		public int characterShadowTierLevel; // 0x1C
		public int characterOutlineTierLevel; // 0x20
	
		// Constructors
		public CharacterRenderFeatureQuality(); // 0x0000000184D83190-0x0000000184D831B0
	
		// Methods
		protected override void Apply(); // 0x0000000184D13B70-0x0000000184D13C10
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class ChromaticAberrationQuality : ToggleQualityComponent // TypeDefIndex: 61162
	{
		// Fields
		private const int ENABLE_TIER = 2000; // Metadata: 0x0234F5F6
		private const int DISABLE_TIER = 1000; // Metadata: 0x0234F5F8
	
		// Constructors
		public ChromaticAberrationQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Toggle(bool value); // 0x0000000183C8F990-0x0000000183C8FA20
		public void __iFixBaseProxy_Toggle(bool P0); // 0x000000018AC3BFF4-0x000000018AC3BFFC
	}

	[Serializable]
	public class DLSSFrameGenQuality : EnumQualityComponent<DLSSFrameGenQuality.DLSSFrameGenQualityEnum> // TypeDefIndex: 61164
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Nested types
		public enum DLSSFrameGenQualityEnum // TypeDefIndex: 61163
		{
			Auto = 0,
			X1 = 1,
			X2 = 2,
			X3 = 3
		}
	
		// Constructors
		public DLSSFrameGenQuality(); // 0x0000000184D7EB70-0x0000000184D7EBA0
	
		// Methods
		protected override void Apply(); // 0x0000000184B08A20-0x0000000184B08B40
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context); // 0x0000000183E514D0-0x0000000183E51570
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x00000001844846F0-0x0000000184484790
		public bool ShouldShowAuto(); // 0x000000018AC3BFFC-0x000000018AC3C048
		public bool ShouldShowX1(); // 0x000000018AC3C048-0x000000018AC3C094
		public bool ShouldShowX2(); // 0x000000018AC3C094-0x000000018AC3C0F0
		public bool ShouldShowX3(); // 0x000000018AC3C0F0-0x000000018AC3C14C
		public bool ShouldShow(); // 0x000000018AC3C14C-0x000000018AC3C1F4
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	[Obsolete]
	public class DLSSUpscalerModel : EnumQualityComponent<DLSSModel> // TypeDefIndex: 61165
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public DLSSUpscalerModel(); // 0x0000000184D7EB40-0x0000000184D7EB70
	
		// Methods
		protected override void Apply(); // 0x0000000184484330-0x00000001844846F0
		public bool ShouldShow(); // 0x000000018AC3C1F4-0x000000018AC3C240
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class DLSSUpscalerQuality : EnumQualityComponent<DLSSQuality> // TypeDefIndex: 61166
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public DLSSUpscalerQuality(); // 0x0000000184D7EB10-0x0000000184D7EB40
	
		// Methods
		protected override void Apply(); // 0x0000000184483DB0-0x0000000184483F70
		public bool ShouldShow(); // 0x000000018AC3C240-0x000000018AC3C2F8
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context); // 0x0000000183E51570-0x0000000183E51610
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x0000000184484790-0x0000000184484860
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class EnvironmentRenderingFeatureQuality : QualityTierComponent // TypeDefIndex: 61167
	{
		// Fields
		public int environmentRenderingFeatureQualityTier; // 0x18
	
		// Constructors
		public EnvironmentRenderingFeatureQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000183C90950-0x0000000183C909F0
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class FrameGenQuality : EnumQualityComponent<FrameGenQuality.FrameGenMode> // TypeDefIndex: 61169
	{
		// Nested types
		public enum FrameGenMode // TypeDefIndex: 61168
		{
			None = 0,
			DLSS = 1,
			FSR3 = 2
		}
	
		// Constructors
		public FrameGenQuality(); // 0x0000000184D7DC10-0x0000000184D7DC40
	
		// Methods
		protected override void Apply(); // 0x0000000184484D60-0x0000000184484FB0
		public bool ShouldShow(); // 0x000000018AC3E8B8-0x000000018AC3E920
		public bool ShouldShowDLSS(); // 0x000000018AC3E818-0x000000018AC3E868
		public bool ShouldShowFSR3(); // 0x000000018AC3E868-0x000000018AC3E8B8
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class FrameGenQualityMobile : ToggleQualityComponent // TypeDefIndex: 61170
	{
		// Constructors
		public FrameGenQualityMobile(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x000000018AC3E638-0x000000018AC3E744
		public bool ShouldShow(); // 0x000000018AC3E744-0x000000018AC3E810
		public void __iFixBaseProxy_Apply(); // 0x000000018AC3E810-0x000000018AC3E818
	}

	[Serializable]
	public class FrameRateQuality : EnumQualityComponent<FrameRateQuality.FrameRateQualityEnum> // TypeDefIndex: 61172
	{
		// Properties
		private int frameRate { get; } // 0x00000001848223B0-0x0000000184822410 
	
		// Nested types
		public enum FrameRateQualityEnum : byte // TypeDefIndex: 61171
		{
			FPS120 = 0,
			FPS60 = 1,
			FPS30 = 2
		}
	
		// Constructors
		public FrameRateQuality(); // 0x0000000184D7DBB0-0x0000000184D7DBE0
	
		// Methods
		public static int GetFrameRateFromEnum(FrameRateQualityEnum enumValue); // 0x0000000184822410-0x0000000184822450
		public override int Version(); // 0x0000000184D7DBE0-0x0000000184D7DC10
		public bool ShouldShow(); // 0x000000018AC3EE64-0x000000018AC3EF0C
		protected override void Apply(); // 0x0000000184822330-0x00000001848223B0
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x000000018AC3ECF4-0x000000018AC3EE64
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context); // 0x00000001839BA9A0-0x00000001839BAB20
		private bool _FPS30Enabled(); // 0x000000018AC3EF0C-0x000000018AC3EF58
		private bool _FPS60Enabled(); // 0x000000018AC3EF58-0x000000018AC3EFA4
		private bool _FPSBNoLimitEnabled(); // 0x000000018AC3EFA4-0x000000018AC3EFF0
		private bool _IsGDLSSGDisable(); // 0x000000018AC3EFF0-0x000000018AC3F098
		public int __iFixBaseProxy_Version(); // 0x00000001874559DC-0x00000001874559E4
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	public class HgFrameRateControl // TypeDefIndex: 61174
	{
		// Fields
		public static int s_cinematicFrameRate; // 0x00
		public static Stack<ValueTuple<int, int, ReasonEnum>> s_rateStack; // 0x08
		public static Action<int, int> s_OnFrameRateChanged; // 0x10
	
		// Nested types
		public enum ReasonEnum // TypeDefIndex: 61173
		{
			Default = 0,
			Init = 1,
			Quality = 2,
			Dialog = 3,
			Cutscene = 4,
			GMCommand = 5
		}
	
		// Constructors
		public HgFrameRateControl(); // 0x00000001841E1670-0x00000001841E1680
		static HgFrameRateControl(); // 0x00000001848224C0-0x0000000184822570
	
		// Methods
		public static int GetDefaultFrameRate(); // 0x0000000184822570-0x00000001848225A0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init(); // 0x0000000184822450-0x00000001848224C0
		public static void SetFrameRateOverrider(int frameRate, ReasonEnum reason); // 0x000000018AC3F864-0x000000018AC3F954
		public static int GetFrameRate(); // 0x000000018AC3F41C-0x000000018AC3F460
		public static bool IsHighFrameRate(); // 0x000000018AC3F594-0x000000018AC3F5B8
		public static int RecommendedDefaultFrameRate(); // 0x000000018AC3F5B8-0x000000018AC3F6EC
		public static int GetUserSettingFrameRate(); // 0x000000018AC3F460-0x000000018AC3F594
		public static void __ForceSetFrameRate(int frameRate, ReasonEnum reason); // 0x00000001848225A0-0x0000000184822670
		public static void ResetFrameRate(); // 0x000000018AC3F6EC-0x000000018AC3F864
	}

	[Serializable]
	public class FrameRateQualityMobile : EnumQualityComponent<FrameRateQualityMobile.FrameRateQualityMobileEnum> // TypeDefIndex: 61176
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Properties
		private int frameRate { get; } // 0x000000018AC3EC78-0x000000018AC3ECF4 
	
		// Nested types
		public enum FrameRateQualityMobileEnum : byte // TypeDefIndex: 61175
		{
			FPS60 = 0,
			FPS45 = 1,
			FPS30 = 2
		}
	
		// Constructors
		public FrameRateQualityMobile(); // 0x000000018AC3EC50-0x000000018AC3EC78
	
		// Methods
		public static int GetFrameRateFromEnum(FrameRateQualityMobileEnum enumValue); // 0x000000018AC3E9A8-0x000000018AC3EA1C
		public override int Version(); // 0x000000018AC3EC00-0x000000018AC3EC50
		protected override void Apply(); // 0x000000018AC3E920-0x000000018AC3E9A8
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context); // 0x000000018AC3EA1C-0x000000018AC3EC00
		public int __iFixBaseProxy_Version(); // 0x00000001874559DC-0x00000001874559E4
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class FSR3UpscalerQuality : EnumQualityComponent<FSR3Quality> // TypeDefIndex: 61177
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public FSR3UpscalerQuality(); // 0x0000000184D7DD90-0x0000000184D7DDC0
	
		// Methods
		protected override void Apply(); // 0x0000000184483F70-0x0000000184484130
		public bool ShouldShow(); // 0x000000018AC3E580-0x000000018AC3E638
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context); // 0x0000000183E51610-0x0000000183E516B0
		internal void FSR3Change(QualityTierComponent qualityTierComponent); // 0x0000000184484860-0x0000000184484930
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class GrassSparsityQuality : QualityTierComponent // TypeDefIndex: 61178
	{
		// Fields
		public int grassSparsityQualityTier; // 0x18
	
		// Constructors
		public GrassSparsityQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000183C8FA20-0x0000000183C8FA90
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class HGAmbientOcclusionQuality : QualityTierComponent // TypeDefIndex: 61179
	{
		// Fields
		public int aoQualityTier; // 0x18
	
		// Constructors
		public HGAmbientOcclusionQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000183C909F0-0x0000000183C90A90
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class HGAnisoLevelQuality : EnumQualityComponent<HGAnisoLevelQuality.HGAnisoLevel> // TypeDefIndex: 61181
	{
		// Nested types
		public enum HGAnisoLevel // TypeDefIndex: 61180
		{
			X1 = 1,
			X2 = 2,
			X4 = 4,
			X8 = 8
		}
	
		// Constructors
		public HGAnisoLevelQuality(); // 0x0000000184D7D9A0-0x0000000184D7D9D0
	
		// Methods
		protected override void InitApply(); // 0x0000000184B87D30-0x0000000184B87D90
		protected override void Apply(); // 0x000000018AC3F098-0x000000018AC3F19C
		public void __iFixBaseProxy_InitApply(); // 0x000000018AC3F19C-0x000000018AC3F1A4
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class HGContactShadowQuality : ToggleQualityComponent // TypeDefIndex: 61182
	{
		// Fields
		private const int ENABLE_TIER = 2000; // Metadata: 0x0234F611
		private const int DISABLE_TIER = 1000; // Metadata: 0x0234F613
	
		// Constructors
		public HGContactShadowQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Toggle(bool value); // 0x0000000183C8FA90-0x0000000183C8FB20
		public void __iFixBaseProxy_Toggle(bool P0); // 0x000000018AC3BFF4-0x000000018AC3BFFC
	}

	[Serializable]
	public class HGIrradianceVolumeQuality : QualityTierComponent // TypeDefIndex: 61183
	{
		// Constructors
		public HGIrradianceVolumeQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void LowMemory(); // 0x000000018AC3F1A4-0x000000018AC3F1E8
		public void __iFixBaseProxy_LowMemory(); // 0x0000000186D66024-0x0000000186D6602C
	}

	[Serializable]
	public class HGLODStreamingComponent : QualityTierComponent // TypeDefIndex: 61184
	{
		// Fields
		public bool enableLODStreaming; // 0x18
	
		// Constructors
		public HGLODStreamingComponent(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000184D33920-0x0000000184D33960
		protected override void LowMemory(); // 0x000000018AC3F1E8-0x000000018AC3F2E4
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
		public void __iFixBaseProxy_LowMemory(); // 0x0000000186D66024-0x0000000186D6602C
	}

	[Serializable]
	public class HGReflectionProbeBinningQuality : QualityTierComponent // TypeDefIndex: 61185
	{
		// Constructors
		public HGReflectionProbeBinningQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void LowMemory(); // 0x000000018AC3F2E4-0x000000018AC3F36C
		public void __iFixBaseProxy_LowMemory(); // 0x0000000186D66024-0x0000000186D6602C
	}

	[Serializable]
	public class HGRPTierQuality : QualityTierComponent // TypeDefIndex: 61186
	{
		// Fields
		public int HGRP_QualityTier; // 0x18
	
		// Constructors
		public HGRPTierQuality(); // 0x0000000184D77930-0x0000000184D77940
	
		// Methods
		protected override void Apply(); // 0x0000000183C90860-0x0000000183C908B0
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class HGScreenSpaceReflectionQuality : QualityTierComponent // TypeDefIndex: 61187
	{
		// Fields
		public int ssrQualityTier; // 0x18
	
		// Constructors
		public HGScreenSpaceReflectionQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000183C8FB20-0x0000000183C8FB90
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class HGShadowQuality : QualityTierComponent // TypeDefIndex: 61188
	{
		// Fields
		public int shadowQualityTier; // 0x18
	
		// Constructors
		public HGShadowQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000183C8FB90-0x0000000183C8FC00
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class HGTextureQuality : EnumQualityComponent<HGTextureQuality.TextureQualityEnum> // TypeDefIndex: 61190
	{
		// Properties
		private int textureQualityTier { get; } // 0x0000000183C8FCB0-0x0000000183C8FD10 
	
		// Nested types
		public enum TextureQualityEnum : byte // TypeDefIndex: 61189
		{
			High = 0,
			Medium = 1,
			Low = 2
		}
	
		// Constructors
		public HGTextureQuality(); // 0x0000000184D7D8E0-0x0000000184D7D910
	
		// Methods
		protected override void Apply(); // 0x0000000183C8FC00-0x0000000183C8FCB0
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class HGVolumetricCloudQuality : QualityTierComponent // TypeDefIndex: 61191
	{
		// Fields
		public int volumetricCloudQualityTier; // 0x18
	
		// Constructors
		public HGVolumetricCloudQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private int GetShaderLod(); // 0x0000000183C90780-0x0000000183C907B0
		protected override void Apply(); // 0x0000000183C906F0-0x0000000183C90780
		public bool ShouldShowNoExLow(); // 0x000000018AC3F3C4-0x000000018AC3F41C
		public bool ShouldShowExLow(); // 0x000000018AC3F36C-0x000000018AC3F3C4
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class HGVolumetricFogQuality : QualityTierComponent // TypeDefIndex: 61192
	{
		// Fields
		public int volumetricFogQualityTier; // 0x18
	
		// Constructors
		public HGVolumetricFogQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000183C907F0-0x0000000183C90860
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class LODGroupQuality : QualityTierComponent // TypeDefIndex: 61193
	{
		// Fields
		public float lodBias; // 0x18
		public int lodOffset; // 0x1C
	
		// Constructors
		public LODGroupQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x000000018AC42504-0x000000018AC42560
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class PhysicsClothQuality : QualityTierComponent // TypeDefIndex: 61194
	{
		// Fields
		public bool UsePhysicCloth; // 0x18
		public bool UseCrossFrameJob; // 0x19
	
		// Constructors
		public PhysicsClothQuality(); // 0x0000000184DA9A50-0x0000000184DA9A60
	
		// Methods
		protected override void Apply(); // 0x000000018AC426F4-0x000000018AC427A4
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class PrefabInstantiateQuality : QualityTierComponent // TypeDefIndex: 61195
	{
		// Fields
		public float normalMaxUpdateTimeInMsThreshold; // 0x18
		public float busyMaxUpdateTimeInMsThreshold; // 0x1C
		public float burstMaxUpdateTimeInMsThreshold; // 0x20
		public float normalUnloadMaxUpdateTimeInMsThreshold; // 0x24
		public float burstUnloadMaxUpdateTimeInMsThreshold; // 0x28
		public float normalCallbackMaxUpdateTimeInMsThreshold; // 0x2C
		public float burstCallbackMaxUpdateTimeInMsThreshold; // 0x30
		public int normalMaxDestroyCount; // 0x34
	
		// Constructors
		public PrefabInstantiateQuality(); // 0x0000000184DA9A60-0x0000000184DA9AA0
	
		// Methods
		protected override void Apply(); // 0x000000018AC427A4-0x000000018AC42920
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class PreloadLoadSettingQuality : QualityTierComponent // TypeDefIndex: 61196
	{
		// Fields
		public float normalMaxUpdateTimeInMsThreshold; // 0x18
		public float busyMaxUpdateTimeInMsThreshold; // 0x1C
		public float burstMaxUpdateTimeInMsThreshold; // 0x20
		public float normalUnloadMaxUpdateTimeInMsThreshold; // 0x24
		public float burstUnloadMaxUpdateTimeInMsThreshold; // 0x28
		public float normalCallbackMaxUpdateTimeInMsThreshold; // 0x2C
		public float burstCallbackMaxUpdateTimeInMsThreshold; // 0x30
		public float preloadManagerUnloadKeepTime; // 0x34
	
		// Constructors
		public PreloadLoadSettingQuality(); // 0x0000000184D51130-0x0000000184D51170
	
		// Methods
		protected override void Apply(); // 0x0000000184B0D360-0x0000000184B0D4C0
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class RayTracingQuality : ToggleQualityComponent // TypeDefIndex: 61197
	{
		// Properties
		public static bool supportsRayTracing { get; } // 0x0000000184A1EB60-0x0000000184A1EB90 
	
		// Constructors
		public RayTracingQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void InitApply(); // 0x0000000184A1EB00-0x0000000184A1EB60
		protected override void Apply(); // 0x000000018AC459E0-0x000000018AC45AD4
		public bool ShouldShow(); // 0x000000018AC45AD4-0x000000018AC45B24
		internal override int ApplyOrder(); // 0x0000000184D7CBF0-0x0000000184D7CC20
		public void __iFixBaseProxy_InitApply(); // 0x000000018AC3F19C-0x000000018AC3F1A4
		public void __iFixBaseProxy_Apply(); // 0x000000018AC3E810-0x000000018AC3E818
		public int __iFixBaseProxy_ApplyOrder(); // 0x000000018AC45B24-0x000000018AC45B2C
	}

	[Serializable]
	public class ReflexQuality : EnumQualityComponent<StreamlineReflexMode> // TypeDefIndex: 61198
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public ReflexQuality(); // 0x0000000184D7CBC0-0x0000000184D7CBF0
	
		// Methods
		protected override void Apply(); // 0x00000001844853B0-0x0000000184485530
		public bool ShouldShow(); // 0x000000018AC45C8C-0x000000018AC45D4C
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context); // 0x0000000183E516B0-0x0000000183E51750
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x000000018AC45B2C-0x000000018AC45C8C
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class RenderingScaleQualityMobile : EnumQualityComponent<RenderingScaleQualityMobile.RenderingScaleMode> // TypeDefIndex: 61200
	{
		// Properties
		public float renderingScaleFactor { get; } // 0x000000018AC45E80-0x000000018AC45F4C 
	
		// Nested types
		public enum RenderingScaleMode // TypeDefIndex: 61199
		{
			ExHigh = 0,
			High = 1,
			Medium = 2,
			Low = 3,
			ExLow = 4
		}
	
		// Constructors
		public RenderingScaleQualityMobile(); // 0x000000018AC45E58-0x000000018AC45E80
	
		// Methods
		protected override void Apply(); // 0x000000018AC45D4C-0x000000018AC45E58
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class RenderingScaleQualityPC : EnumQualityComponent<RenderingScaleQualityPC.RenderingScaleMode> // TypeDefIndex: 61202
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Properties
		public float renderingScale { get; } // 0x0000000184484BB0-0x0000000184484C10 
	
		// Nested types
		public enum RenderingScaleMode // TypeDefIndex: 61201
		{
			Percent100 = 0,
			Percent90 = 1,
			Percent80 = 2,
			Percent70 = 3,
			Percent60 = 4
		}
	
		// Constructors
		public RenderingScaleQualityPC(); // 0x0000000184D7CB30-0x0000000184D7CB60
	
		// Methods
		protected override void Apply(); // 0x0000000184484A60-0x0000000184484BB0
		public bool ShouldShow(); // 0x000000018AC45F4C-0x000000018AC46034
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context); // 0x0000000183E51750-0x0000000183E517F0
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x0000000184484930-0x0000000184484A60
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class ResLoadSettingQuality : QualityTierComponent // TypeDefIndex: 61203
	{
		// Fields
		public bool debugCloseBundleUnload; // 0x18
		public bool debugCloseBundleUnloadUntilBurstMode; // 0x19
		public bool enableForceSyncUnload; // 0x1A
		public bool enableUnloadLocker; // 0x1B
		public int enableUnloadLockerBundleNum; // 0x1C
		public int maxUnloadOpNum_Normal; // 0x20
		public int maxUnloadOpNum_BusyMode; // 0x24
		public int bundleFrameDelayToUnload_NormalMode; // 0x28
		public int bundleFrameDelayToUnload_BusyMode; // 0x2C
		public int bundleFrameDelayToUnload_BurstMode; // 0x30
		public int bundleFrameDelayToUnload_SwitchScene; // 0x34
		public int bundleFrameDelayToUnload_Fast; // 0x38
		public int enterBusyOperationNum; // 0x3C
		public int exitBusyOperationNum; // 0x40
		public float unloadBudgetFloatingCoefficient; // 0x44
		public float unloadMaxFloatingBudget; // 0x48
	
		// Constructors
		public ResLoadSettingQuality(); // 0x0000000184D10F30-0x0000000184D10F90
	
		// Methods
		protected override void Apply(); // 0x0000000184A7D020-0x0000000184A7D1B0
		protected override void LowMemory(); // 0x000000018AC46034-0x000000018AC460FC
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
		public void __iFixBaseProxy_LowMemory(); // 0x0000000186D66024-0x0000000186D6602C
	}

	[Serializable]
	public class SceneDetailQuality : QualityTierComponent // TypeDefIndex: 61204
	{
		// Fields
		public int sceneDetailQualityTier; // 0x18
	
		// Constructors
		public SceneDetailQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000183C90A90-0x0000000183C90B30
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class ShaderLodQuality : QualityTierComponent // TypeDefIndex: 61206
	{
		// Fields
		public ShaderLodEnum ShaderLod; // 0x18
	
		// Nested types
		public enum ShaderLodEnum // TypeDefIndex: 61205
		{
			Mobile100 = 100,
			Mobile200 = 200,
			Mobile300 = 300,
			Mobile400 = 400,
			Mobile500 = 500,
			PC600 = 600
		}
	
		// Constructors
		public ShaderLodQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void InitApply(); // 0x0000000184CD9040-0x0000000184CD9080
		protected override void Apply(); // 0x000000018AC460FC-0x000000018AC461CC
		public void __iFixBaseProxy_InitApply(); // 0x000000018AC3F19C-0x000000018AC3F1A4
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class SharpnessQuality : SliderQualityComponent // TypeDefIndex: 61207
	{
		// Constructors
		public SharpnessQuality(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x0000000184484C10-0x0000000184484D60
		public bool ShouldShow(); // 0x000000018AC461CC-0x000000018AC462B0
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class SliderTestComponent : SliderQualityComponent // TypeDefIndex: 61208
	{
		// Constructors
		public SliderTestComponent(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Apply(); // 0x000000018AC463B4-0x000000018AC463F8
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class TickExclusiveQuality : QualityTierComponent // TypeDefIndex: 61209
	{
		// Fields
		public TickExclusiveMode quality; // 0x18
		private LogicQualityLevel m_currentQuality; // 0x1C
		private ThermalState m_currentThermalState; // 0x1D
	
		// Constructors
		public TickExclusiveQuality(); // 0x0000000184D84AB0-0x0000000184D84AC0
	
		// Methods
		protected override void Apply(); // 0x00000001843ECE90-0x00000001843ECEF0
		protected override void DynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last); // 0x00000001843ECEF0-0x00000001843ECF40
		protected override void DynamicThermalChange(ThermalState current, ThermalState last); // 0x000000018AC463F8-0x000000018AC4646C
		private void _OnQualityOrThermalChanged(); // 0x00000001843ECF40-0x00000001843ECFE0
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
		public void __iFixBaseProxy_DynamicQualityChange(LogicQualityLevel P0, LogicQualityLevel P1); // 0x00000001870A9134-0x00000001870A913C
		public void __iFixBaseProxy_DynamicThermalChange(ThermalState P0, ThermalState P1); // 0x00000001870A913C-0x00000001870A9144
	}

	[Serializable]
	public class UpscalerQuality : EnumQualityComponent<UpscalerQuality.UpscalerMode> // TypeDefIndex: 61211
	{
		// Nested types
		public enum UpscalerMode // TypeDefIndex: 61210
		{
			DLSS = 0,
			TAAU = 1,
			FSR3 = 2
		}
	
		// Constructors
		public UpscalerQuality(); // 0x0000000184D7C620-0x0000000184D7C650
	
		// Methods
		protected override void Apply(); // 0x0000000184484FB0-0x00000001844852A0
		public bool ShouldShow(); // 0x000000018AC46720-0x000000018AC46770
		public bool ShouldShowDLSS(); // 0x000000018AC46680-0x000000018AC466D0
		public bool ShouldShowFSR3(); // 0x000000018AC466D0-0x000000018AC46720
		public override int Version(); // 0x0000000184D7C650-0x0000000184D7C680
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
		public int __iFixBaseProxy_Version(); // 0x00000001874559DC-0x00000001874559E4
	}

	[Serializable]
	[Obsolete]
	public class VSyncQuality : QualityTierComponent // TypeDefIndex: 61212
	{
		// Fields
		public bool bVSync; // 0x18
	
		// Constructors
		public VSyncQuality(); // 0x0000000184D8EB60-0x0000000184D8EB70
	
		// Methods
		protected override void Apply(); // 0x000000018AC46864-0x000000018AC468BC
		protected void Remove(); // 0x000000018AC468BC-0x000000018AC4690C
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init(); // 0x0000000184CDE570-0x0000000184CDE5A0
		public void __iFixBaseProxy_Apply(); // 0x0000000186D6601C-0x0000000186D66024
	}

	[Serializable]
	public class VSyncQualityV2 : ToggleQualityComponent // TypeDefIndex: 61213
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x20
	
		// Constructors
		public VSyncQualityV2(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void Toggle(bool value); // 0x0000000184B4A190-0x0000000184B4A270
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init(); // 0x0000000184CDE5A0-0x0000000184CDE5D0
		public override int Version(); // 0x0000000184D7C5C0-0x0000000184D7C5F0
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context); // 0x0000000183E517F0-0x0000000183E51890
		internal void FrameGenChange(QualityTierComponent qualityTierComponent); // 0x0000000182E85650-0x0000000182E86550
		public bool ShouldShow(); // 0x000000018AC46770-0x000000018AC46864
		public void __iFixBaseProxy_Toggle(bool P0); // 0x000000018AC3BFF4-0x000000018AC3BFFC
		public int __iFixBaseProxy_Version(); // 0x00000001874559DC-0x00000001874559E4
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 61128
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 61129
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 61130
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 61131
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 61132
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 61126
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61214
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37020-0x0000000184D37090
	
		// Methods
		public void __Gen_Wrap_0(); // 0x00000001863625A4-0x0000000186362640
		public void __Gen_Wrap_1(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public string __Gen_Wrap_2(ref RankingRule P0); // 0x000000018AC40D48-0x000000018AC40EA4
		public string __Gen_Wrap_3(ref DeviceMatchResult P0); // 0x000000018AC414F0-0x000000018AC41658
		public string __Gen_Wrap_4(object P0); // 0x000000018AC41A54-0x000000018AC41B44
		public bool __Gen_Wrap_5(ref DeviceMatchResult P0); // 0x000000018AC42144-0x000000018AC4228C
		public bool __Gen_Wrap_6(object P0); // 0x00000001863632E4-0x00000001863633B4
		public string __Gen_Wrap_7(); // 0x000000018AC42348-0x000000018AC42414
		public DeviceMatchRules __Gen_Wrap_8(object P0); // 0x000000018AC42414-0x000000018AC42504
		public int __Gen_Wrap_9(object P0, object P1); // 0x0000000186360610-0x00000001863606FC
		public string __Gen_Wrap_10(object P0, object P1); // 0x000000018AC3F954-0x000000018AC3FA60
		public bool __Gen_Wrap_11(object P0, object P1, object P2, ref RankingRule P3); // 0x000000018AC3FA60-0x000000018AC3FBF8
		public bool __Gen_Wrap_12(object P0, object P1, object P2, ref RankingRule P3, out string P4); // 0x000000018AC3FBF8-0x000000018AC3FDD8
		public void __Gen_Wrap_13(object P0); // 0x00000001863633B4-0x0000000186363474
		public bool __Gen_Wrap_14(object P0, object P1, ref RankingRule P2); // 0x000000018AC3FDD8-0x000000018AC3FF48
		public bool __Gen_Wrap_15(ref RankingRule P0, RankingRule P1); // 0x000000018AC3FF48-0x000000018AC400B8
		public string __Gen_Wrap_16(ref MemoryRule P0); // 0x000000018AC400B8-0x000000018AC4020C
		public bool __Gen_Wrap_17(ref MemoryRule P0, MemoryRule P1); // 0x000000018AC4020C-0x000000018AC40388
		public string __Gen_Wrap_18(ref DeviceQualityMapItem P0); // 0x000000018AC40388-0x000000018AC404F4
		public UnityEngine.Color __Gen_Wrap_19(ref DeviceQualityMapItem P0, int P1); // 0x000000018AC404F4-0x000000018AC40698
		public UnityEngine.Color __Gen_Wrap_20(ref DeviceQualityMapItem P0); // 0x000000018AC40698-0x000000018AC40820
		public DeviceQualityMapItem __Gen_Wrap_21(object P0); // 0x000000018AC40820-0x000000018AC4092C
		public int __Gen_Wrap_22(object P0); // 0x0000000186360E84-0x0000000186360F54
		public Beyond.Scripts.Quality.DeviceInfo __Gen_Wrap_23(object P0); // 0x000000018AC4092C-0x000000018AC40A1C
		public int __Gen_Wrap_24(QualityTierLevel P0); // 0x0000000186366E40-0x0000000186366EFC
		public int __Gen_Wrap_25(DeviceQualityMapItem P0); // 0x000000018AC40A1C-0x000000018AC40B20
		public QualityTierComponentMatch __Gen_Wrap_26(object P0, object P1, int P2); // 0x000000018AC40B20-0x000000018AC40C58
		public int __Gen_Wrap_27(QualityTierComponentMatch P0); // 0x000000018AC40C58-0x000000018AC40D48
		public void __Gen_Wrap_28(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public void __Gen_Wrap_29(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public QualityTierComponentMatch __Gen_Wrap_30(object P0, object P1); // 0x000000018AC40EA4-0x000000018AC40FCC
		public void __Gen_Wrap_31(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_32(object P0, LogicQualityLevel P1, LogicQualityLevel P2); // 0x000000018AC40FCC-0x000000018AC410C4
		public void __Gen_Wrap_33(object P0, in EventData<LogicQualityLevel, LogicQualityLevel> P1); // 0x000000018AC410C4-0x000000018AC411E8
		public void __Gen_Wrap_34(object P0, ThermalState P1, ThermalState P2); // 0x000000018AC411E8-0x000000018AC412CC
		public void __Gen_Wrap_35(object P0, in EventData<ThermalState, ThermalState> P1); // 0x000000018AC412CC-0x000000018AC413E4
		public System.Type __Gen_Wrap_36(object P0, object P1); // 0x000000018AC413E4-0x000000018AC414F0
		public void __Gen_Wrap_37(object P0, object P1, int P2); // 0x00000001866F4838-0x00000001866F4930
		public void __Gen_Wrap_38(object P0, GameSetting.GameSettingVideoQuality P1); // 0x00000001866F3838-0x00000001866F3914
		public GameSetting.GameSettingVideoQuality __Gen_Wrap_39(object P0); // 0x0000000186360E84-0x0000000186360F54
		public bool __Gen_Wrap_40(); // 0x00000001863623A8-0x0000000186362454
		public bool __Gen_Wrap_41(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public QualityTierType __Gen_Wrap_42(object P0, object P1); // 0x0000000186360610-0x00000001863606FC
		public void __Gen_Wrap_43(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public void __Gen_Wrap_44(object P0, object P1, float P2); // 0x00000001871C15C8-0x00000001871C16C4
		public Vector2 __Gen_Wrap_45(object P0); // 0x000000018AC41658-0x000000018AC41734
		public float __Gen_Wrap_46(object P0); // 0x00000001866C0730-0x00000001866C0800
		public Vector3 __Gen_Wrap_47(object P0, object P1); // 0x000000018AC41734-0x000000018AC41854
		public bool __Gen_Wrap_48(object P0, object P1, object P2, object P3); // 0x000000018AC41854-0x000000018AC4195C
		public ValueTuple<float, float> __Gen_Wrap_49(object P0, object P1); // 0x000000018AC4195C-0x000000018AC41A54
		public int __Gen_Wrap_50(int P0, int P1); // 0x0000000189C88C8C-0x0000000189C88D60
		public float __Gen_Wrap_51(object P0, object P1); // 0x00000001866C0800-0x00000001866C08EC
		public int __Gen_Wrap_52(QualityTierComponentMatch P0, QualityTierComponentMatch P1); // 0x000000018AC41B44-0x000000018AC41C6C
		public void __Gen_Wrap_53(object P0, object P1, out int P2, out int P3); // 0x000000018AC41C6C-0x000000018AC41DA8
		public bool __Gen_Wrap_54(object P0, object P1, int P2); // 0x000000018AC41DA8-0x000000018AC41E9C
		public byte[] __Gen_Wrap_55(object P0); // 0x000000018AC41E9C-0x000000018AC41F78
		public JsonSerializerSettings __Gen_Wrap_56(); // 0x000000018AC41F78-0x000000018AC42044
		public void __Gen_Wrap_57(object P0, StreamingContext P1); // 0x000000018AC42044-0x000000018AC42144
		public int __Gen_Wrap_58(FrameRateQuality.FrameRateQualityEnum P0); // 0x000000018A8A0364-0x000000018A8A0434
		public void __Gen_Wrap_59(int P0, HgFrameRateControl.ReasonEnum P1); // 0x0000000187199E0C-0x0000000187199EE4
		public int __Gen_Wrap_60(); // 0x0000000186377214-0x00000001863772AC
		public int __Gen_Wrap_61(FrameRateQualityMobile.FrameRateQualityMobileEnum P0); // 0x000000018AC4228C-0x000000018AC42348
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61215
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018AC4690C-0x000000018AC469A0
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61216
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018AC46B88-0x000000018AC46BEC
		public static bool IsPatched(int id); // 0x00000001836923C0-0x0000000183692410
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018AC46A44-0x000000018AC46B10
		public object CreateWrapper(int id); // 0x000000018AC46B10-0x000000018AC46B88
		public object InitWrapperArray(int len); // 0x000000018AC46BEC-0x000000018AC46C78
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018AC469A0-0x000000018AC46A44
	}

	public enum IDMAP0 // TypeDefIndex: 61217
	{
		Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-InitializeAtRuntime0 = 0,
		Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-Initialize0 = 1,
		Beyond-Scripts-Quality-DeviceInfo-SupplementFromRemote0 = 2,
		Beyond-Scripts-Quality-DeviceMatchRules-Combine0 = 3,
		Beyond-Scripts-Quality-DeviceInfo-ToString0 = 4,
		Beyond-Scripts-Quality-DeviceMatchResult-ToString0 = 5,
		Beyond-Scripts-Quality-RankingRule-ToString0 = 6,
		Beyond-Scripts-Quality-DeviceInfo-IsNoMatchDevice0 = 8,
		Beyond-Scripts-Quality-DeviceMatchResult-IsNoMatch0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-IsZeroDevices0 = 10,
		Beyond-Scripts-Quality-DeviceInfo-get_cpuName0 = 11,
		Beyond-Scripts-Quality-DeviceInfo-IsHUAWEIDevice0 = 12,
		Beyond-Scripts-Quality-DeviceInfo-IsQualcommDevice0 = 13,
		Beyond-Scripts-Quality-DeviceInfo-LoadingSettingRules0 = 14,
		Beyond-Scripts-Quality-DeviceInfo-GetDeviceScore0 = 15,
		Beyond-Scripts-Quality-DeviceInfo-CloudGameGetMatchedRule0 = 16,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneGetMatchedRule0 = 17,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneMatchGPURule0 = 18,
		Beyond-Scripts-Quality-DeviceInfo-GetNvidiaStandardGPUName0 = 19,
		Beyond-Scripts-Quality-DeviceInfo-RuleSuffixMatch0 = 20,
		Beyond-Scripts-Quality-DeviceInfo-GetAmdStandardGPUName0 = 21,
		Beyond-Scripts-Quality-DeviceInfo-GetIntelStandardGPUName0 = 22,
		Beyond-Scripts-Quality-DeviceInfo-_ReportMatchRuleFailed0 = 23,
		Beyond-Scripts-Quality-DeviceInfo-EditorSimulateGetMatchedRule0 = 24,
		Beyond-Scripts-Quality-DeviceInfo-AndroidGetMatchedRule0 = 25,
		Beyond-Scripts-Quality-DeviceInfo-MatchDeviceModeRule0 = 26,
		Beyond-Scripts-Quality-DeviceInfo-RuleFullNameMatch0 = 27,
		Beyond-Scripts-Quality-DeviceInfo-MatchGPURule0 = 28,
		Beyond-Scripts-Quality-DeviceInfo-GetAdrenoStandardGPUName0 = 29,
		Beyond-Scripts-Quality-DeviceInfo-GetMaliStandardGPUName0 = 30,
		Beyond-Scripts-Quality-DeviceInfo-IOSGetMatchedRule0 = 31,
		Beyond-Scripts-Quality-DeviceInfo-DefaultGetMatchedRule0 = 32,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneOSXGetMatchedRule0 = 33,
		Beyond-Scripts-Quality-DeviceInfo-StandalonePS5GetMatchedRule0 = 34,
		Beyond-Scripts-Quality-DeviceInfo-GetPowerVRStandardGPUName0 = 35,
		Beyond-Scripts-Quality-RankingRule-Equals0 = 36,
		Beyond-Scripts-Quality-MemoryRule-ToString0 = 37,
		Beyond-Scripts-Quality-MemoryRule-Equals0 = 38,
		Beyond-Scripts-Quality-DeviceQualityMapItem-ToString0 = 39,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getColor0 = 40,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryLowColor0 = 41,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getLowColor0 = 42,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getMiddleColor0 = 43,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getHighColor0 = 44,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryHighColor0 = 45,
		Beyond-Scripts-Quality-QualityManager-get_Config0 = 46,
		Beyond-Scripts-Quality-QualityManager-get_currentTier0 = 47,
		Beyond-Scripts-Quality-QualityManager-get_defaultTier0 = 48,
		Beyond-Scripts-Quality-QualityManager-get_device0 = 49,
		Beyond-Scripts-Quality-QualityManager-Init0 = 50,
		Beyond-Scripts-Quality-QualityManager-LoadQualityTier0 = 51,
		Beyond-Scripts-Quality-Components-QualityTierComponent-ApplyOrder0 = 56,
		Beyond-Scripts-Quality-QualityManager-ApplyQualityScore0 = 63,
		Beyond-Scripts-Quality-QualityManager-setQualityTier0 = 64,
		Beyond-Scripts-Quality-QualityManager-_SetQualityTierComponentLevel0 = 65,
		Beyond-Scripts-Quality-Components-QualityTierComponent-SafeApply0 = 66,
		Beyond-Scripts-Quality-QualityManager-get_isInitializing0 = 67,
		Beyond-Scripts-Quality-Components-QualityTierComponent-InitApply0 = 68,
		Beyond-Scripts-Quality-Components-QualityTierComponent-Apply0 = 69,
		Beyond-Scripts-Quality-Components-QualityTierComponent-LowMemory0 = 70,
		Beyond-Scripts-Quality-QualityManager-InvokeChangeCallBack0 = 71,
		Beyond-Scripts-Quality-Components-QualityTierComponent-SafeLowMemory0 = 72,
		Beyond-Scripts-Quality-QualityManager-ApplyCallBack0 = 73,
		Beyond-Scripts-Quality-QualityManager-_GetOverrideQualityTierComponentLevel0 = 74,
		Beyond-Scripts-Quality-QualityManager-_DynamicInitQualitySetting0 = 75,
		Beyond-Scripts-Quality-QualityManager-DynamicQualityChange0 = 76,
		Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicQualityChange0 = 77,
		Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicQualityChange0 = 78,
		Beyond-Scripts-Quality-QualityManager-DynamicThermalChange0 = 79,
		Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicThermalChange0 = 80,
		Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicThermalChange0 = 81,
		Beyond-Scripts-Quality-QualityManager-InitOnlyDevice0 = 82,
		Beyond-Scripts-Quality-QualityManager-InitShaderLod0 = 83,
		Beyond-Scripts-Quality-QualityManager-ApplyShaderTier0 = 84,
		Beyond-Scripts-Quality-QualityManager-ForceSetQualityTierComponentLevel0 = 85,
		Beyond-Scripts-Quality-QualityManager-_GetQualityComponentByName0 = 86,
		Beyond-Scripts-Quality-QualityManager-FinishInit0 = 87,
		Beyond-Scripts-Quality-QualityManager-Dispose0 = 88,
		Beyond-Scripts-Quality-QualityManager-_DynamicReleaseQualitySetting0 = 89,
		Beyond-Scripts-Quality-QualityManager-SetQualityTierByVideoQuality0 = 90,
		Beyond-Scripts-Quality-QualityManager-GetDefaultVideoQuality0 = 91,
		Beyond-Scripts-Quality-QualityManager-NoMatchDeviceOrZeroScore0 = 92,
		Beyond-Scripts-Quality-QualityManager-IsQualcommDevice0 = 93,
		Beyond-Scripts-Quality-QualityManager-IsHUAWEIDevice0 = 94,
		Beyond-Scripts-Quality-QualityManager-IsIpadDevice0 = 95,
		Beyond-Scripts-Quality-QualityManager-InitResetQualityTierComponentFunction0 = 96,
		Beyond-Scripts-Quality-QualityManager-ResetQualityTierComponentValue0 = 97,
		Beyond-Scripts-Quality-QualityManager-RevertSetQualityTierComponentLevel0 = 98,
		Beyond-Scripts-Quality-QualityManager-NeedRestart0 = 99,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierType0 = 100,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierVersion0 = 101,
		Beyond-Scripts-Quality-Components-QualityTierComponent-Version0 = 102,
		Beyond-Scripts-Quality-QualityManager-_IsToggleQualityTierComponent0 = 103,
		Beyond-Scripts-Quality-QualityManager-_ToggleQualityTierComponentLevel0 = 104,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-ChangeToggle0 = 105,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetValue0 = 106,
		Beyond-Scripts-Quality-QualityManager-IsEnumQualityTierComponent0 = 107,
		Beyond-Scripts-Quality-QualityManager-GetEnumQualityTierComponentCount0 = 108,
		Beyond-Scripts-Quality-QualityManager-SetEnumQualityTierComponentCount0 = 109,
		Beyond-Scripts-Quality-QualityManager-IsSliderQualityTierComponent0 = 110,
		Beyond-Scripts-Quality-QualityManager-SetSliderQualityTierComponentCount0 = 111,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-SetValue0 = 112,
		Beyond-Scripts-Quality-QualityManager-GetSliderQualityTierComponent0 = 113,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetRange0 = 114,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetValue0 = 115,
		Beyond-Scripts-Quality-QualityManager-InvokeQualityTierComponent0 = 116,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierCount0 = 117,
		Beyond-Scripts-Quality-QualityManager-GetQualityComponentDefaultTier0 = 118,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetDefaultValue0 = 119,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetDefaultValue0 = 120,
		Beyond-Scripts-Quality-QualityManager-GetQualityComponentTier0 = 121,
		Beyond-Scripts-Quality-QualityManager-SetQualityComponentTier0 = 122,
		Beyond-Scripts-Quality-QualityManager-_ReportQuality0 = 123,
		Beyond-Scripts-Quality-QualityManager-IsQualitySubSettingTierValid0 = 124,
		Beyond-Scripts-Quality-Components-QualityTierComponent-TierLimit0 = 125,
		Beyond-Scripts-Quality-QualityManager-_GetCurrentComponentTierIndex0 = 126,
		Beyond-Scripts-Quality-QualityManager-ToString0 = 127,
		Beyond-Scripts-Quality-QualityManager-DebugQualityTierComponentInfo0 = 128,
		Beyond-Scripts-Quality-QualityUtility-Decompress0 = 129,
		Beyond-Scripts-Quality-QualityUtility-get_JsonSerializerSettings0 = 130,
		Beyond-Scripts-Quality-Components-AntiAliasingQuality-Apply0 = 131,
		Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveQualitySettingSaveValue0 = 132,
		Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveRegisterKey0 = 133,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-Apply0 = 134,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-Toggle0 = 135,
		Beyond-Scripts-Quality-Components-CharacterRenderFeatureQuality-Apply0 = 136,
		Beyond-Scripts-Quality-Components-ChromaticAberrationQuality-Toggle0 = 137,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-Apply0 = 138,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-OnDeserialized0 = 139,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-DlSSChange0 = 140,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowAuto0 = 141,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX10 = 142,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX20 = 143,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX30 = 144,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShow0 = 145,
		Beyond-Scripts-Quality-Components-DLSSUpscalerModel-Apply0 = 146,
		Beyond-Scripts-Quality-Components-DLSSUpscalerModel-ShouldShow0 = 147,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-Apply0 = 148,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-ShouldShow0 = 149,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-OnDeserialized0 = 150,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-DlSSChange0 = 151,
		Beyond-Scripts-Quality-Components-EnvironmentRenderingFeatureQuality-Apply0 = 152,
		Beyond-Scripts-Quality-Components-FrameGenQuality-Apply0 = 153,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShow0 = 154,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowDLSS0 = 155,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowFSR30 = 156,
		Beyond-Scripts-Quality-Components-FrameGenQualityMobile-Apply0 = 157,
		Beyond-Scripts-Quality-Components-FrameGenQualityMobile-ShouldShow0 = 158,
		Beyond-Scripts-Quality-Components-FrameRateQuality-get_frameRate0 = 159,
		Beyond-Scripts-Quality-Components-FrameRateQuality-GetFrameRateFromEnum0 = 160,
		Beyond-Scripts-Quality-Components-FrameRateQuality-Version0 = 161,
		Beyond-Scripts-Quality-Components-FrameRateQuality-ShouldShow0 = 162,
		Beyond-Scripts-Quality-Components-FrameRateQuality-Apply0 = 163,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-__ForceSetFrameRate0 = 164,
		Beyond-Scripts-Quality-Components-FrameRateQuality-DlSSChange0 = 165,
		Beyond-Scripts-Quality-Components-FrameRateQuality-OnDeserialized0 = 166,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS30Enabled0 = 167,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS60Enabled0 = 168,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPSBNoLimitEnabled0 = 169,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_IsGDLSSGDisable0 = 170,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetDefaultFrameRate0 = 171,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-Init0 = 172,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-SetFrameRateOverrider0 = 173,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetFrameRate0 = 174,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-RecommendedDefaultFrameRate0 = 175,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetUserSettingFrameRate0 = 176,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-ResetFrameRate0 = 177,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-get_frameRate0 = 178,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-GetFrameRateFromEnum0 = 179,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Version0 = 180,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Apply0 = 181,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-OnDeserialized0 = 182,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-Apply0 = 183,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-ShouldShow0 = 184,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-OnDeserialized0 = 185,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-FSR3Change0 = 186,
		Beyond-Scripts-Quality-Components-GrassSparsityQuality-Apply0 = 187,
		Beyond-Scripts-Quality-Components-HGAmbientOcclusionQuality-Apply0 = 188,
		Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-InitApply0 = 189,
		Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-Apply0 = 190,
		Beyond-Scripts-Quality-Components-HGContactShadowQuality-Toggle0 = 191,
		Beyond-Scripts-Quality-Components-HGIrradianceVolumeQuality-LowMemory0 = 192,
		Beyond-Scripts-Quality-Components-HGLODStreamingComponent-Apply0 = 193,
		Beyond-Scripts-Quality-Components-HGLODStreamingComponent-LowMemory0 = 194,
		Beyond-Scripts-Quality-Components-HGReflectionProbeBinningQuality-LowMemory0 = 195,
		Beyond-Scripts-Quality-Components-HGRPTierQuality-Apply0 = 196,
		Beyond-Scripts-Quality-Components-HGScreenSpaceReflectionQuality-Apply0 = 197,
		Beyond-Scripts-Quality-Components-HGShadowQuality-Apply0 = 198,
		Beyond-Scripts-Quality-Components-HGTextureQuality-get_textureQualityTier0 = 199,
		Beyond-Scripts-Quality-Components-HGTextureQuality-Apply0 = 200,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-GetShaderLod0 = 201,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-Apply0 = 202,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-ShouldShowNoExLow0 = 203,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-ShouldShowExLow0 = 204,
		Beyond-Scripts-Quality-Components-HGVolumetricFogQuality-Apply0 = 205,
		Beyond-Scripts-Quality-Components-LODGroupQuality-Apply0 = 206,
		Beyond-Scripts-Quality-Components-PhysicsClothQuality-Apply0 = 207,
		Beyond-Scripts-Quality-Components-PrefabInstantiateQuality-Apply0 = 208,
		Beyond-Scripts-Quality-Components-PreloadLoadSettingQuality-Apply0 = 209,
		Beyond-Scripts-Quality-Components-RayTracingQuality-get_supportsRayTracing0 = 210,
		Beyond-Scripts-Quality-Components-RayTracingQuality-InitApply0 = 211,
		Beyond-Scripts-Quality-Components-RayTracingQuality-Apply0 = 212,
		Beyond-Scripts-Quality-Components-RayTracingQuality-ShouldShow0 = 213,
		Beyond-Scripts-Quality-Components-RayTracingQuality-ApplyOrder0 = 214,
		Beyond-Scripts-Quality-Components-ReflexQuality-Apply0 = 215,
		Beyond-Scripts-Quality-Components-ReflexQuality-ShouldShow0 = 216,
		Beyond-Scripts-Quality-Components-ReflexQuality-OnDeserialized0 = 217,
		Beyond-Scripts-Quality-Components-ReflexQuality-DlSSChange0 = 218,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-get_renderingScaleFactor0 = 219,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-Apply0 = 220,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-get_renderingScale0 = 221,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-Apply0 = 222,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-ShouldShow0 = 223,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-OnDeserialized0 = 224,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-DlSSChange0 = 225,
		Beyond-Scripts-Quality-Components-ResLoadSettingQuality-Apply0 = 226,
		Beyond-Scripts-Quality-Components-ResLoadSettingQuality-LowMemory0 = 227,
		Beyond-Scripts-Quality-Components-SceneDetailQuality-Apply0 = 228,
		Beyond-Scripts-Quality-Components-ShaderLodQuality-InitApply0 = 229,
		Beyond-Scripts-Quality-Components-ShaderLodQuality-Apply0 = 230,
		Beyond-Scripts-Quality-Components-SharpnessQuality-Apply0 = 231,
		Beyond-Scripts-Quality-Components-SharpnessQuality-ShouldShow0 = 232,
		Beyond-Scripts-Quality-Components-SliderTestComponent-Apply0 = 233,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-Apply0 = 234,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicQualityChange0 = 235,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-_OnQualityOrThermalChanged0 = 236,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicThermalChange0 = 237,
		Beyond-Scripts-Quality-Components-UpscalerQuality-Apply0 = 238,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShow0 = 239,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowDLSS0 = 240,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowFSR30 = 241,
		Beyond-Scripts-Quality-Components-UpscalerQuality-Version0 = 242,
		Beyond-Scripts-Quality-Components-VSyncQuality-Apply0 = 243,
		Beyond-Scripts-Quality-Components-VSyncQuality-Remove0 = 244,
		Beyond-Scripts-Quality-Components-VSyncQuality-Init0 = 245,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Toggle0 = 246,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Init0 = 247,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Version0 = 248,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-OnDeserialized0 = 249,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-FrameGenChange0 = 250,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-ShouldShow0 = 251
	}
}
