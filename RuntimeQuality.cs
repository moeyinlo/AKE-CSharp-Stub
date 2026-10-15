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

// Image 55: RuntimeQuality.dll - Assembly: RuntimeQuality, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88231-88387

namespace Beyond.Gameplay.BeyondPerformance
{
	public enum LogicQualityLevel : byte // TypeDefIndex: 88241
	{
		Economy = 0,
		Balanced = 1,
		Performance = 2,
		Max = 3
	}

	public enum ThermalState : byte // TypeDefIndex: 88242
	{
		GameNormal = 0,
		GameFair = 1,
		GameSerious = 2
	}

	public static class LogicQualityConst // TypeDefIndex: 88243
	{
		// Fields
		public static float s_reduceQualityLevelFPSThresholdRatio; // 0x00
		public static float s_recoverQualityLevelFPSThresholdRatio; // 0x04
	
		// Constructors
		static LogicQualityConst(); // 0x00000001871FC250-0x00000001871FC2A0
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_RuntimeQuality // TypeDefIndex: 88233
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime(); // 0x000000018710D1D0-0x000000018710D200
		private static void Initialize(); // 0x000000018710D200-0x000000018710D290
	}
}

namespace Beyond.Scripts.Quality
{
	public class DeviceInfo // TypeDefIndex: 88245
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
		public readonly string m_physicalDeviceTypeName; // 0x40
		public readonly int m_systemMemorySize; // 0x48
		public readonly int m_GPUMemorySize; // 0x4C
		public readonly int m_processorCount; // 0x50
		public readonly GraphicsDeviceType m_graphicsDeviceType; // 0x54
		public DeviceMatchRules m_matchRules; // 0x58
		public DeviceMatchResult m_matchResult; // 0x60
		public bool bEditorSimulator; // 0x80
		public readonly string m_SystemInfo; // 0x88
		public GraphicsPhysicalDeviceType m_physicalDeviceType; // 0x90
		private const string ADRENO_KEY = "Adreno"; // Metadata: 0x02648027
		private const string ADRENO_PATTERN = "Adreno\\D*(?<Model>\\d+)\\W*(?<Extra>l?)"; // Metadata: 0x0264802E
		private const string ADRENO_STANDARD_FORMAT = "Adreno {0}{1}"; // Metadata: 0x02648054
		private const string MALI_KEY = "Mali"; // Metadata: 0x02648062
		private const string MALI_PATTERN = "Mali[-|\\s](?<Prefix>[A-Za-z]?)(?<Model>\\d+)\\W*(?<Rare>(3EE|Immortalis|Ultra)?)\\W*(?<CoreType>(MC|MP)?)\\W*(?<CoreCount>\\d*)"; // Metadata: 0x02648067
		private const string MALI_STANDARD_FORMAT = "Mali-{0}{1}{2}{3}{4}"; // Metadata: 0x026480E3
		private const string POWER_VR_KEY = "PowerVR"; // Metadata: 0x026480F8
		private const string POWER_VR_PATTERN = "PowerVR[-|\\s](?<Prefix>[A-Za-z]*)(?<Model>\\d+)"; // Metadata: 0x02648100
		private const string POWER_VR_STANDARD_FORMAT = "PowerVR {0}{1}"; // Metadata: 0x0264812F
		private const string NVIDIA_KEY = "(NVIDIA|GTX|RTX|Quadro|GeForce)"; // Metadata: 0x0264813E
		private const string NVIDIA_PATTERN = "(?<Prefix>RTX|GTX)\\s+(?![A-Z])(?<Model>\\d+)\\W*(?<Extra>\\w+)?"; // Metadata: 0x0264815E
		private const string NVIDIA_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x0264819B
		private const string TITAN_PATTERN = "(?<Prefix>RTX|GTX)?\\D*(?<Model>TITAN)\\W*(?<Extra>\\w+)?"; // Metadata: 0x026481A3
		private const string NVIDIA_FALLBACK = "\\bNVIDIA\\b[\\s:-]*(?<rest>.+)$"; // Metadata: 0x026481DA
		private const string AMD_KEY = "(AMD|ATI|Radeon)"; // Metadata: 0x026481F8
		private const string AMD_PATTERN = "Radeon\\s?(\\(TM\\))?\\s?(?<Prefix>R9|RX|HD)?\\W*(?<Model>\\d+)?\\W*(?<Extra>\\w+)?"; // Metadata: 0x02648209
		private const string AMD_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x02648256
		private const string AMD_FALLBACK = "\\bAMD\\b[\\s:-]*(?<rest>.+)$"; // Metadata: 0x0264825E
		private const string INTEL_KEY = "Intel"; // Metadata: 0x02648279
		private const string INTEL_PATTERN = "Intel\\S+[-|\\s](?<Model>Arc)\\S+[-|\\s](?<Extra>[A-Za-z]\\d+)?"; // Metadata: 0x0264827F
		private const string INTEL_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x026482BA
		private const string INTEL_PATTERN_2 = "Intel\\S+[-|\\s](?<Model>HD)[-|\\s](?<Extra>Graphics)"; // Metadata: 0x026482C2
		private const string INTEL_FALLBACK = "Intel\\s*(?:\\(R\\)\\s*)?(?<rest>.+)$"; // Metadata: 0x026482F5
	
		// Properties
		public int DevicesScore { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public static string cpuName { get; } // 0x0000000185DE42D0-0x0000000185DE4300 
	
		// Nested types
		public enum MatchType // TypeDefIndex: 88244
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
		public DeviceInfo(string remoteJson = null); // 0x0000000185DE34A0-0x0000000185DE42D0
		public DeviceInfo(RuntimePlatform platform, string deviceName, string deviceModel, string graphicsDeviceName, string graphicsDeviceVersion, string systemMemorySize, string processorName, string processorCount, string processorFrequency); // 0x000000018CE33740-0x000000018CE339C8
	
		// Methods
		public void SupplementFromRemote(string json); // 0x0000000185DE3410-0x0000000185DE34A0
		public sealed override string ToString(); // 0x0000000186146740-0x0000000186148680
		public bool IsNoMatchDevice(); // 0x000000018CE32E0C-0x000000018CE32E54
		public bool IsZeroDevices(); // 0x0000000186C9D1F0-0x0000000186C9D220
		public bool IsHUAWEIDevice(); // 0x000000018CE32D48-0x000000018CE32E0C
		public bool IsQualcommDevice(); // 0x000000018CE32E54-0x000000018CE32EE4
		public DeviceMatchRules LoadingSettingRules(); // 0x0000000185DE5C30-0x0000000185DE5CC0
		public int GetDeviceScore(string remoteJson = null); // 0x0000000185DE48D0-0x0000000185DE5C30
		public int EditorSimulateGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018CE31E30-0x000000018CE31F88
		public int IOSGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018CE32A20-0x000000018CE32D48
		public int AndroidGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018CE3196C-0x000000018CE31D0C
		public int StandaloneGetMatchedRule(DeviceInfo deviceInfo); // 0x0000000185DE5CC0-0x0000000185DE7820
		public int StandaloneOSXGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018CE333DC-0x000000018CE33414
		public int CloudGameGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018CE31D0C-0x000000018CE31DF8
		public int SteamDeckGetMatchedRule(DeviceInfo deviceInfo, ESteamHardwareType type); // 0x0000000184E251C0-0x0000000184E25370
		public int StandalonePS5GetMatchedRule(DeviceInfo deviceInfo); // 0x000000018CE33414-0x000000018CE33570
		public int DefaultGetMatchedRule(DeviceInfo deviceInfo); // 0x000000018CE31DF8-0x000000018CE31E30
		public bool RuleSuffixMatch(List<RankingRule> list, string name, ref RankingRule matchedRule); // 0x0000000185DE7BA0-0x0000000185DE80D0
		public static bool RuleFullNameMatch(List<RankingRule> list, string name, ref RankingRule matchedRule); // 0x000000018CE331F0-0x000000018CE333DC
		public bool MatchDeviceModeRule(List<RankingRule> list, string deviceModel, ref RankingRule rule); // 0x000000018CE32EE4-0x000000018CE32F90
		public bool MatchGPURule(DeviceMatchRules rules, string gpu, ref RankingRule rule, out string standardName); // 0x000000018CE32F90-0x000000018CE331F0
		private bool StandaloneMatchGPURule(DeviceMatchRules rules, string gpu, ref RankingRule rule, out string standardName); // 0x0000000185DE7850-0x0000000185DE7990
		private string GetNvidiaStandardGPUName(string gpu); // 0x0000000185DE7990-0x0000000185DE7B10
		private string GetAmdStandardGPUName(string gpu); // 0x000000018CE320D4-0x000000018CE3237C
		private string GetIntelStandardGPUName(string gpu); // 0x000000018CE3237C-0x000000018CE325EC
		private string GetAdrenoStandardGPUName(string gpu); // 0x000000018CE31F88-0x000000018CE320D4
		private string GetMaliStandardGPUName(string gpu); // 0x000000018CE325EC-0x000000018CE328D4
		private string GetPowerVRStandardGPUName(string gpu); // 0x000000018CE328D4-0x000000018CE32A20
		private static void _ReportMatchRuleFailed(DeviceInfo deviceModel); // 0x000000018CE33570-0x000000018CE33740
		public string __iFixBaseProxy_ToString(); // 0x0000000188ABB3B8-0x0000000188ABB3C0
	}

	[Serializable]
	public struct RankingRule : IEquatable<RankingRule> // TypeDefIndex: 88246
	{
		// Fields
		public string regexPattern; // 0x00
		public int targetScore; // 0x08
	
		// Methods
		public bool Equals(RankingRule other); // 0x000000018CE37950-0x000000018CE379B8
		public override string ToString(); // 0x0000000186148810-0x00000001861488A0
		public string __iFixBaseProxy_ToString(); // 0x000000018CE379B8-0x000000018CE37A08
	}

	[Serializable]
	public struct MemoryRule : IEquatable<MemoryRule> // TypeDefIndex: 88247
	{
		// Fields
		public Vector2 range; // 0x00
		public int targetScore; // 0x08
	
		// Methods
		public override string ToString(); // 0x000000018CE358F4-0x000000018CE359C0
		public bool Equals(MemoryRule other); // 0x000000018CE35880-0x000000018CE358F4
		public string __iFixBaseProxy_ToString(); // 0x000000018CE359C0-0x000000018CE35A18
	}

	public static class ListUtils // TypeDefIndex: 88248
	{
		// Methods
		public static void AddOrReplace<TItem>(List<TItem> source, List<TItem> remote)
			where TItem : IEquatable<TItem>;
	}

	public class DeviceMatchRules // TypeDefIndex: 88249
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
		public DeviceMatchRules(); // 0x00000001872210E0-0x0000000187221100
	
		// Methods
		public void Combine(DeviceMatchRules other); // 0x000000018CE33A58-0x000000018CE33C40
	}

	public struct DeviceMatchResult // TypeDefIndex: 88250
	{
		// Fields
		private RankingRule m_rule; // 0x00
		private Beyond.Scripts.Quality.DeviceInfo.MatchType m_matchType; // 0x10
		private string gpuStandardName; // 0x18
	
		// Constructors
		public DeviceMatchResult(RankingRule r, Beyond.Scripts.Quality.DeviceInfo.MatchType type, string gpuStandardName); // 0x0000000185DE7820-0x0000000185DE7850
	
		// Methods
		public override string ToString(); // 0x0000000186148680-0x0000000186148810
		public bool IsNoMatch(); // 0x000000018CE339C8-0x000000018CE33A00
		public string __iFixBaseProxy_ToString(); // 0x000000018CE33A00-0x000000018CE33A58
	}

	[Serializable]
	public struct DeviceQualityMapItem // TypeDefIndex: 88251
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
		public override string ToString(); // 0x000000018CE33C40-0x000000018CE33E74
		private UnityEngine.Color getColor(int level); // 0x000000018CE33ED8-0x000000018CE33F58
		private UnityEngine.Color getVeryLowColor(); // 0x000000018CE340F8-0x000000018CE34160
		private UnityEngine.Color getLowColor(); // 0x000000018CE33FC0-0x000000018CE34028
		private UnityEngine.Color getMiddleColor(); // 0x000000018CE34028-0x000000018CE34090
		private UnityEngine.Color getHighColor(); // 0x000000018CE33F58-0x000000018CE33FC0
		private UnityEngine.Color getVeryHighColor(); // 0x000000018CE34090-0x000000018CE340F8
		public string __iFixBaseProxy_ToString(); // 0x000000018CE33E74-0x000000018CE33ED8
	}

	[Serializable]
	public class DeviceQualityMap // TypeDefIndex: 88252
	{
		// Fields
		public RuntimePlatform m_platform; // 0x10
		public List<DeviceQualityMapItem> items; // 0x18
	
		// Constructors
		public DeviceQualityMap(); // 0x00000001870EEC40-0x00000001870EECC0
	}

	public static class QualityConst // TypeDefIndex: 88253
	{
		// Fields
		public const string SIMULATE_DEVICE_LIST = "Assets/Beyond/InitialAssets/Settings/Quality/DeviceList_zip.bytes"; // Metadata: 0x0264831E
		public const string SETTING_RULES = "Assets/Beyond/InitialAssets/Settings/Quality/SettingRules.json"; // Metadata: 0x02648361
		public const string QUALITY_MAP = "Assets/Beyond/InitialAssets/Settings/Quality/{0}_QualityMap.json"; // Metadata: 0x026483A0
		public const string QUALITY_TIER_COMPONENTS = "Assets/Beyond/InitialAssets/Settings/Quality/{0}_QualityTierComponent.json"; // Metadata: 0x026483E2
	}

	public class QualityManager : Singleton<QualityManager>, IDisposable // TypeDefIndex: 88255
	{
		// Fields
		private Beyond.Scripts.Quality.DeviceInfo m_deviceInfo; // 0x10
		private DeviceQualityMap m_qualityMap; // 0x18
		private DeviceQualityMapItem m_matchedConfig; // 0x20
		private Dictionary<Beyond.GameSetting.GameSettingVideoQuality, int> m_qualityScoreMap; // 0x48
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
		public DeviceQualityMapItem Config { get; } // 0x000000018CE3740C-0x000000018CE3747C 
		public int currentTier { get; } // 0x000000018CE3747C-0x000000018CE374C0 
		public int defaultTier { get; } // 0x00000001872258C0-0x00000001872258F0 
		public Beyond.Scripts.Quality.DeviceInfo device { get; } // 0x0000000186E65D70-0x0000000186E65DA0 
		public bool isInitializing { get; } // 0x0000000186B65690-0x0000000186B656C0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88254
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
			static __c(); // 0x00000001871E6EC0-0x00000001871E6F20
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _LoadQualityTier_b__29_0(QualityTierLevel s); // 0x00000001860B50D0-0x00000001860B50F0
			internal int _setQualityTier_b__30_0(QualityTierComponentMatch x); // 0x0000000186CD1FA0-0x0000000186CD1FC0
			internal int _ApplyQualityScore_b__31_0(DeviceQualityMapItem s); // 0x0000000187257B60-0x0000000187257B70
			internal int _ApplyShaderTier_b__32_0(DeviceQualityMapItem s); // 0x0000000187257B60-0x0000000187257B70
			internal int _GetQualityComponentDefaultTier_b__66_0(int a, int b); // 0x0000000186ADDFD0-0x0000000186ADDFF0
			internal int _GetQualityComponentTier_b__67_0(int a, int b); // 0x0000000186C242F0-0x0000000186C24310
			internal int _SetQualityComponentTier_b__68_0(int a, int b); // 0x000000018CE3811C-0x000000018CE38138
			internal int __GetCurrentComponentTierIndex_b__70_0(QualityTierComponentMatch a, QualityTierComponentMatch b); // 0x000000018CE38138-0x000000018CE38150
		}
	
		// Constructors
		[UnityEngine.Scripting.Preserve]
		private QualityManager(); // 0x0000000186E4FC40-0x0000000186E50BA0
		static QualityManager(); // 0x0000000187082900-0x00000001870829F0
	
		// Methods
		public void Init(string remoteJson = null); // 0x0000000185DE1360-0x0000000185DE2490
		public void InitOnlyDevice(string remoteJson = null); // 0x0000000185DE2730-0x0000000185DE28B0
		public void InitShaderLod(); // 0x0000000185DE2490-0x0000000185DE2730
		public void FinishInit(); // 0x00000001863CF750-0x00000001863CF790
		public void Dispose(); // 0x0000000186B8E910-0x0000000186B8FC70
		public void LoadQualityTier(string overridePlatform = null); // 0x0000000184FCDC60-0x0000000184FCE7E0
		private void setQualityTier(int qualityTier); // 0x00000001867F1950-0x00000001867F2630
		public void ApplyQualityScore(); // 0x00000001861EA920-0x00000001861EAF00
		public void ApplyShaderTier(); // 0x00000001861EAF00-0x00000001861EB590
		private System.Type _GetQualityComponentByName(string typeName); // 0x00000001854F8D30-0x00000001854F8EE0
		public void SetQualityTierByVideoQuality(Beyond.GameSetting.GameSettingVideoQuality VideoQuality); // 0x00000001867F18B0-0x00000001867F1950
		public Beyond.GameSetting.GameSettingVideoQuality GetDefaultVideoQuality(); // 0x0000000185DE2920-0x0000000185DE2AC0
		public bool NoMatchDeviceOrZeroScore(); // 0x0000000186C9D1B0-0x0000000186C9D1F0
		[UnityEngine.Scripting.Preserve]
		public bool IsQualcommDevice(); // 0x000000018CE36590-0x000000018CE365E4
		[UnityEngine.Scripting.Preserve]
		public bool IsHUAWEIDevice(); // 0x000000018CE364BC-0x000000018CE36510
		[UnityEngine.Scripting.Preserve]
		public static bool IsIpadDevice(); // 0x000000018CE36510-0x000000018CE36590
		public bool IsVideoQualityEnable(Beyond.GameSetting.GameSettingVideoQuality VideoQuality); // 0x000000018CE365E4-0x000000018CE36640
		public void InitResetQualityTierComponentFunction(Func<System.Type, bool> func); // 0x00000001870A8430-0x00000001870A8520
		public bool ResetQualityTierComponentValue(System.Type type); // 0x0000000185473C00-0x0000000185473C50
		private QualityTierComponentMatch _SetQualityTierComponentLevel(System.Type type, int level); // 0x0000000184FCD830-0x0000000184FCDC60
		public void _ForceSetQualityTierComponentLevel(string type, int level); // 0x0000000184E3C4C0-0x0000000184E3E5C0
		public void RevertSetQualityTierComponentLevel(string type); // 0x000000018CE36848-0x000000018CE369D4
		public bool NeedRestart(); // 0x000000018CE36640-0x000000018CE36848
		public void ApplyCallBack(); // 0x00000001863D0B70-0x00000001863D0C30
		private QualityTierComponentMatch _GetOverrideQualityTierComponentLevel(System.Type type); // 0x00000001854F7580-0x00000001854F7640
		public QualityTierType GetQualityTierComponentTierType(string type); // 0x0000000184FD0670-0x0000000184FD0860
		public int GetQualityTierComponentTierVersion(string type); // 0x00000001869E2A20-0x00000001869E2AE0
		private bool _IsToggleQualityTierComponent(string type); // 0x0000000184FD0300-0x0000000184FD0400
		private void _ToggleQualityTierComponentLevel(string type, int index); // 0x000000018CE372B4-0x000000018CE3740C
		public bool IsEnumQualityTierComponent(string type); // 0x0000000184FD0400-0x0000000184FD0500
		public int GetEnumQualityTierComponentCount(string type); // 0x0000000184FCADA0-0x0000000184FCAE80
		public void SetEnumQualityTierComponentCount(string type, int index); // 0x00000001863D1EC0-0x00000001863D2080
		public bool IsSliderQualityTierComponent(string type); // 0x0000000184FD0500-0x0000000184FD0600
		public void SetSliderQualityTierComponentCount(string type, float value); // 0x000000018CE369D4-0x000000018CE36B20
		public Vector3 GetSliderQualityTierComponent(string type); // 0x0000000185473790-0x00000001854738B0
		public bool InvokeQualityTierComponent(string type, string functionName, params object[] parameters); // 0x0000000184FD0AD0-0x0000000184FD0C30
		public void RegisterQualityTierComponentChange<T>(System.Type tierType, Action<QualityTierComponent> cb);
		internal void InvokeChangeCallBack(System.Type type, QualityTierComponent qualityTierComponent); // 0x000000018685C8D0-0x000000018685CB80
		public ValueTuple<float, float> GetQualityTierComponentTierCount(string type); // 0x0000000184FCAF70-0x0000000184FCB5F0
		public float GetQualityComponentDefaultTier(string type); // 0x0000000184FCCBA0-0x0000000184FCD830
		public float GetQualityComponentTier(string type); // 0x0000000184FCBE30-0x0000000184FCCBA0
		public void SetQualityComponentTier(string type, float index); // 0x00000001863D0C30-0x00000001863D1880
		public bool IsQualitySubSettingTierValid(string type, int tier); // 0x0000000184FD08E0-0x0000000184FD09C0
		private void _GetCurrentComponentTierIndex(QualityTierComponent qualityTierComponent, out int index, out int defaultTierIndex); // 0x000000018CE36D88-0x000000018CE372B4
		public override string ToString(); // 0x000000018CE36B20-0x000000018CE36D88
		public string DebugQualityTierComponentInfo(); // 0x000000018CE35E98-0x000000018CE362C0
		private static void _ReportQuality(); // 0x0000000184FCEF00-0x0000000184FD0300
		private void _DynamicInitQualitySetting(); // 0x0000000186B8FF50-0x0000000186B90190
		private void _DynamicReleaseQualitySetting(); // 0x0000000186B8FDE0-0x0000000186B8FF50
		internal void DynamicQualityChange([IsReadOnly] in EventData<LogicQualityLevel, LogicQualityLevel> data); // 0x00000001854F8940-0x00000001854F8D30
		internal void DynamicThermalChange([IsReadOnly] in EventData<ThermalState, ThermalState> data); // 0x000000018CE362C0-0x000000018CE364BC
		public string __iFixBaseProxy_ToString(); // 0x0000000188ABB3B8-0x0000000188ABB3C0
	}

	public static class QualityUtility // TypeDefIndex: 88256
	{
		// Fields
		private static JsonSerializerSettings s_settings; // 0x00
	
		// Properties
		public static JsonSerializerSettings JsonSerializerSettings { get; } // 0x0000000185CFA6E0-0x0000000185CFA7F0 
	
		// Methods
		public static T LoadFromCompressedJson<T>();
		public static T LoadingQualityJson<T>(string path)
			where T : class;
		public static T LoadingQualityJsonFromString<T>(string value)
			where T : class;
		private static byte[] Decompress(byte[] data); // 0x000000018CE37678-0x000000018CE37950
	}
}

namespace Beyond.Scripts.Quality.Components
{
	[Serializable]
	public class AntiAliasingQuality : EnumQualityComponent<AntiAliasingQuality.AntiAliasing> // TypeDefIndex: 88258
	{
		// Nested types
		public enum AntiAliasing // TypeDefIndex: 88257
		{
			None = 0,
			CSAA = 1,
			FXAA = 2,
			MSAA = 3
		}
	
		// Constructors
		public AntiAliasingQuality(); // 0x000000018CE31820-0x000000018CE31848
	
		// Methods
		protected override void Apply(); // 0x000000018CE317EC-0x000000018CE31820
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	public interface IEnumQualityComponent // TypeDefIndex: 88259
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
	public class EnumQualityComponent<T> : QualityTierComponent, IEnumQualityComponent, IQualityComponentExtension<T> // TypeDefIndex: 88260
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
		protected void OverrideDefaultValue(T value);
	}

	public enum QualityTierType // TypeDefIndex: 88261
	{
		Quality = 0,
		ToggleQuality = 1,
		EnumQuality = 2,
		SliderQuality = 3
	}

	public interface IQualityComponentExtension<T> // TypeDefIndex: 88262
	{
		// Methods
		T GetValue();
		T GetDefaultValue();
	}

	[Serializable]
	public abstract class QualityTierComponent // TypeDefIndex: 88263
	{
		// Fields
		public static Action<string, int> s_removeRegisterKeyAction; // 0x00
		internal bool isNeedStartDirty; // 0x10
	
		// Constructors
		protected QualityTierComponent(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected virtual void Apply(); // 0x0000000186FB5380-0x0000000186FB53B0
		protected virtual void InitApply(); // 0x0000000186BFB840-0x0000000186BFB880
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context); // 0x0000000184E3E5C0-0x0000000184E3E620
		protected virtual void PreInit(); // 0x0000000184E3E620-0x0000000184E3E660
		protected virtual void LowMemory(); // 0x000000018CE37560-0x000000018CE37594
		protected virtual void DynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last); // 0x000000018674A040-0x000000018674A070
		protected virtual void DynamicThermalChange(ThermalState current, ThermalState last); // 0x000000018CE3751C-0x000000018CE37560
		public virtual int Version(); // 0x0000000186CFBF30-0x0000000186CFBF60
		public virtual bool TierLimit(); // 0x0000000186BC3110-0x0000000186BC3140
		internal virtual int ApplyOrder(); // 0x0000000186C80430-0x0000000186C80460
		internal void RemoveQualitySettingSaveValue(string settingId); // 0x000000018CE37594-0x000000018CE37678
		internal void SafeApply(); // 0x0000000184FCE880-0x0000000184FCE9A0
		internal void RemoveRegisterKey(); // 0x0000000185471E90-0x0000000185471F50
		internal void SafeLowMemory(bool init = false /* Metadata: 0x02648436 */); // 0x00000001867F2630-0x00000001867F26C0
		internal void CallDynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last); // 0x00000001854F8EE0-0x00000001854F8F20
		internal virtual void CallDynamicThermalChange(ThermalState current, ThermalState last); // 0x000000018CE374C0-0x000000018CE3751C
	}

	public struct QualityTierComponentMatch // TypeDefIndex: 88265
	{
		// Fields
		public QualityTierComponent component; // 0x00
		public MatchSource matchSource; // 0x08
		public int matchQualityTier; // 0x0C
	
		// Nested types
		public enum MatchSource // TypeDefIndex: 88264
		{
			UpClosest = 0,
			DownClosest = 1,
			Matched = 2,
			Override = 3
		}
	}

	[Serializable]
	public class QualityTierLevel // TypeDefIndex: 88266
	{
		// Fields
		public int qualityTier; // 0x10
		[HideInInspector]
		public List<QualityTierComponent> qualityTierComponents; // 0x18
	
		// Constructors
		public QualityTierLevel(); // 0x0000000186D425C0-0x0000000186D42640
	}

	[Serializable]
	public class SliderQualityComponent : QualityTierComponent // TypeDefIndex: 88267
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
		public SliderQualityComponent(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public float GetValue(); // 0x00000001854738F0-0x0000000185473970
		public float GetDefaultValue(); // 0x000000018CE37E98-0x000000018CE37EDC
		public Vector2 GetRange(); // 0x00000001854738B0-0x00000001854738F0
		public void SetValue(float value); // 0x000000018CE37EDC-0x000000018CE37F94
	}

	[Serializable]
	public class ToggleQualityComponent : QualityTierComponent, IQualityComponentExtension<bool> // TypeDefIndex: 88268
	{
		// Fields
		[FormerlySerializedAs("defaultVal")]
		[JsonProperty]
		[SerializeField]
		private bool toggleVal; // 0x18
		[NonSerialized]
		private bool? m_currentValue; // 0x19
	
		// Constructors
		public ToggleQualityComponent(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x0000000186BEC110-0x0000000186BEC160
		protected virtual void Toggle(bool value); // 0x000000018CE380E4-0x000000018CE3811C
		public void ChangeToggle(int index); // 0x00000001870E8F10-0x00000001870E8FA0
		public bool GetValue(); // 0x0000000186BEC160-0x0000000186BEC1E0
		public bool GetDefaultValue(); // 0x000000018CE38018-0x000000018CE3805C
		protected void SetToggleWithoutApply(bool value); // 0x000000018CE3805C-0x000000018CE380E4
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class CharacterRenderFeatureQuality : QualityTierComponent // TypeDefIndex: 88269
	{
		// Fields
		public int characterSelfShadowOffLodQuality; // 0x18
		public int characterShadowTierLevel; // 0x1C
		public int characterOutlineTierLevel; // 0x20
	
		// Constructors
		public CharacterRenderFeatureQuality(); // 0x000000018722B530-0x000000018722B550
	
		// Methods
		protected override void Apply(); // 0x00000001871759E0-0x0000000187175A90
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class ChromaticAberrationQuality : ToggleQualityComponent // TypeDefIndex: 88270
	{
		// Fields
		private const int ENABLE_TIER = 2000; // Metadata: 0x0264843B
		private const int DISABLE_TIER = 1000; // Metadata: 0x0264843D
	
		// Constructors
		public ChromaticAberrationQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Toggle(bool value); // 0x00000001850CB9F0-0x00000001850CBA90
		public void __iFixBaseProxy_Toggle(bool P0); // 0x000000018CE31848-0x000000018CE31850
	}

	[Serializable]
	public class DLSSFrameGenQuality : EnumQualityComponent<DLSSFrameGenQuality.DLSSFrameGenQualityEnum> // TypeDefIndex: 88272
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Nested types
		public enum DLSSFrameGenQualityEnum // TypeDefIndex: 88271
		{
			Auto = 0,
			X1 = 1,
			X2 = 2,
			X3 = 3
		}
	
		// Constructors
		public DLSSFrameGenQuality(); // 0x0000000187222C90-0x0000000187222CC0
	
		// Methods
		protected override void Apply(); // 0x0000000185474A80-0x0000000185474D20
		protected override void PreInit(); // 0x0000000184E244F0-0x0000000184E24B40
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x0000000185474250-0x0000000185474320
		public bool ShouldShowAuto(); // 0x000000018CE31850-0x000000018CE31890
		public bool ShouldShowX1(); // 0x000000018CE31890-0x000000018CE318D0
		public bool ShouldShowX2(); // 0x00000001854722C0-0x0000000185472300
		public bool ShouldShowX3(); // 0x0000000185472300-0x0000000185472340
		public bool ShouldShow(); // 0x0000000185472000-0x00000001854720B0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
	}

	[Serializable]
	[Obsolete]
	public class DLSSUpscalerModel : EnumQualityComponent<DLSSModel> // TypeDefIndex: 88273
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public DLSSUpscalerModel(); // 0x000000018CE31944-0x000000018CE3196C
	
		// Methods
		protected override void Apply(); // 0x000000018CE318D0-0x000000018CE31904
		public bool ShouldShow(); // 0x000000018CE31904-0x000000018CE31944
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class DLSSUpscalerQuality : EnumQualityComponent<DLSSQuality> // TypeDefIndex: 88274
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public DLSSUpscalerQuality(); // 0x0000000187222C60-0x0000000187222C90
	
		// Methods
		protected override void Apply(); // 0x0000000185474520-0x0000000185474720
		public bool ShouldShow(); // 0x00000001854720B0-0x0000000185472160
		protected override void PreInit(); // 0x0000000184E24B70-0x0000000184E251C0
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x0000000185474320-0x0000000185474450
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
	}

	[Serializable]
	public class EnvironmentRenderingFeatureQuality : QualityTierComponent // TypeDefIndex: 88275
	{
		// Fields
		public int environmentRenderingFeatureQualityTier; // 0x18
	
		// Constructors
		public EnvironmentRenderingFeatureQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001850CBF40-0x00000001850CBFF0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class FrameGenQuality : EnumQualityComponent<FrameGenQuality.FrameGenMode> // TypeDefIndex: 88277
	{
		// Nested types
		public enum FrameGenMode // TypeDefIndex: 88276
		{
			None = 0,
			DLSS = 1,
			FSR3 = 2
		}
	
		// Constructors
		public FrameGenQuality(); // 0x0000000187222B10-0x0000000187222B40
	
		// Methods
		protected override void Apply(); // 0x0000000185474E70-0x00000001854751A0
		public bool ShouldShow(); // 0x0000000185473750-0x0000000185473790
		public bool ShouldShowDLSS(); // 0x0000000185473F40-0x0000000185473F70
		public bool ShouldShowFSR3(); // 0x0000000185473720-0x0000000185473750
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class FrameGenQualityMobile : ToggleQualityComponent // TypeDefIndex: 88278
	{
		// Constructors
		public FrameGenQualityMobile(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x000000018CE34160-0x000000018CE34268
		public bool ShouldShow(); // 0x000000018CE34268-0x000000018CE34334
		public void __iFixBaseProxy_Apply(); // 0x000000018CE34334-0x000000018CE3433C
	}

	[Serializable]
	public class FrameRateQuality : EnumQualityComponent<FrameRateQuality.FrameRateQualityEnum> // TypeDefIndex: 88280
	{
		// Properties
		private int frameRate { get; } // 0x000000018686C140-0x000000018686C1B0 
	
		// Nested types
		public enum FrameRateQualityEnum : byte // TypeDefIndex: 88279
		{
			FPS120 = 0,
			FPS60 = 1,
			FPS30 = 2
		}
	
		// Constructors
		public FrameRateQuality(); // 0x0000000187222AE0-0x0000000187222B10
	
		// Methods
		public static int GetFrameRateFromEnum(FrameRateQualityEnum enumValue); // 0x000000018686C1B0-0x000000018686C1F0
		public override int Version(); // 0x00000001871FDE00-0x00000001871FDE30
		public bool ShouldShow(); // 0x000000018CE3467C-0x000000018CE3472C
		protected override void Apply(); // 0x000000018686C0C0-0x000000018686C140
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x000000018CE34510-0x000000018CE3467C
		protected override void PreInit(); // 0x0000000184E26830-0x0000000184E27150
		private bool _FPS30Enabled(); // 0x00000001854736F0-0x0000000185473720
		private bool _FPS60Enabled(); // 0x0000000185473630-0x0000000185473660
		private bool _FPSBNoLimitEnabled(); // 0x000000018CE3472C-0x000000018CE3476C
		private bool _IsGDLSSGDisable(); // 0x000000018CE3476C-0x000000018CE3481C
		public int __iFixBaseProxy_Version(); // 0x0000000189738B9C-0x0000000189738BA4
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
	}

	public class HgFrameRateControl // TypeDefIndex: 88282
	{
		// Fields
		public static int s_cinematicFrameRate; // 0x00
		public static Stack<ValueTuple<int, int, ReasonEnum>> s_rateStack; // 0x08
		public static Action<int, int> s_OnFrameRateChanged; // 0x10
	
		// Nested types
		public enum ReasonEnum // TypeDefIndex: 88281
		{
			Default = 0,
			Init = 1,
			Quality = 2,
			Dialog = 3,
			Cutscene = 4,
			GMCommand = 5
		}
	
		// Constructors
		public HgFrameRateControl(); // 0x0000000186805BA0-0x0000000186805BB0
		static HgFrameRateControl(); // 0x000000018686BFE0-0x000000018686C090
	
		// Methods
		public static int GetDefaultFrameRate(); // 0x000000018686C090-0x000000018686C0C0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init(); // 0x000000018686BF60-0x000000018686BFE0
		public static void SetFrameRateOverrider(int frameRate, ReasonEnum reason); // 0x000000018CE34FC4-0x000000018CE350B8
		public static int GetFrameRate(); // 0x000000018CE34B7C-0x000000018CE34BC0
		public static bool IsHighFrameRate(); // 0x000000018CE34CF4-0x000000018CE34D18
		public static int RecommendedDefaultFrameRate(); // 0x000000018CE34D18-0x000000018CE34E4C
		public static int GetUserSettingFrameRate(); // 0x000000018CE34BC0-0x000000018CE34CF4
		public static void __ForceSetFrameRate(int frameRate, ReasonEnum reason); // 0x000000018686C1F0-0x000000018686C320
		public static void ResetFrameRate(); // 0x000000018CE34E4C-0x000000018CE34FC4
	}

	[Serializable]
	public class FrameRateQualityMobile : EnumQualityComponent<FrameRateQualityMobile.FrameRateQualityMobileEnum> // TypeDefIndex: 88284
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Properties
		private int frameRate { get; } // 0x000000018CE34490-0x000000018CE34510 
	
		// Nested types
		public enum FrameRateQualityMobileEnum : byte // TypeDefIndex: 88283
		{
			FPS60 = 0,
			FPS45 = 1,
			FPS30 = 2
		}
	
		// Constructors
		public FrameRateQualityMobile(); // 0x000000018CE34468-0x000000018CE34490
	
		// Methods
		public static int GetFrameRateFromEnum(FrameRateQualityMobileEnum enumValue); // 0x000000018CE343CC-0x000000018CE34424
		public override int Version(); // 0x000000018CE34424-0x000000018CE34468
		protected override void Apply(); // 0x000000018CE3433C-0x000000018CE343CC
		protected override void PreInit(); // 0x0000000184E25F10-0x0000000184E26830
		public int __iFixBaseProxy_Version(); // 0x0000000189738B9C-0x0000000189738BA4
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
	}

	[Serializable]
	public class FSR3UpscalerQuality : EnumQualityComponent<FSR3Quality> // TypeDefIndex: 88285
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public FSR3UpscalerQuality(); // 0x0000000187222B40-0x0000000187222B70
	
		// Methods
		protected override void Apply(); // 0x0000000186D4EBD0-0x0000000186D4ED90
		public bool ShouldShow(); // 0x0000000185472410-0x00000001854724C0
		protected override void PreInit(); // 0x0000000184E25370-0x0000000184E25F10
		internal void FSR3Change(QualityTierComponent qualityTierComponent); // 0x0000000185474450-0x0000000185474520
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
	}

	[Serializable]
	public class GrassSparsityQuality : QualityTierComponent // TypeDefIndex: 88286
	{
		// Fields
		public int grassSparsityQualityTier; // 0x18
	
		// Constructors
		public GrassSparsityQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001850CBA90-0x00000001850CBB10
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class HGAmbientOcclusionQuality : QualityTierComponent // TypeDefIndex: 88287
	{
		// Fields
		public int aoQualityTier; // 0x18
	
		// Constructors
		public HGAmbientOcclusionQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001850CBFF0-0x00000001850CC0A0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class HGAnisoLevelQuality : EnumQualityComponent<HGAnisoLevelQuality.HGAnisoLevel> // TypeDefIndex: 88289
	{
		// Nested types
		public enum HGAnisoLevel // TypeDefIndex: 88288
		{
			X1 = 1,
			X2 = 2,
			X4 = 4,
			X8 = 8
		}
	
		// Constructors
		public HGAnisoLevelQuality(); // 0x0000000187222A50-0x0000000187222A80
	
		// Methods
		protected override void InitApply(); // 0x000000018716C450-0x000000018716C4C0
		protected override void Apply(); // 0x000000018CE3481C-0x000000018CE3491C
		public void __iFixBaseProxy_InitApply(); // 0x000000018CE3491C-0x000000018CE34924
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class HGContactShadowQuality : ToggleQualityComponent // TypeDefIndex: 88290
	{
		// Fields
		private const int ENABLE_TIER = 2000; // Metadata: 0x02648456
		private const int DISABLE_TIER = 1000; // Metadata: 0x02648458
	
		// Constructors
		public HGContactShadowQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Toggle(bool value); // 0x00000001850CBB10-0x00000001850CBBB0
		public void __iFixBaseProxy_Toggle(bool P0); // 0x000000018CE31848-0x000000018CE31850
	}

	[Serializable]
	public class HGIrradianceVolumeQuality : QualityTierComponent // TypeDefIndex: 88291
	{
		// Constructors
		public HGIrradianceVolumeQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void LowMemory(); // 0x000000018CE34924-0x000000018CE34958
		public void __iFixBaseProxy_LowMemory(); // 0x0000000188F2AEA8-0x0000000188F2AEB0
	}

	[Serializable]
	public class HGLODStreamingComponent : QualityTierComponent // TypeDefIndex: 88292
	{
		// Fields
		public bool enableLODStreaming; // 0x18
	
		// Constructors
		public HGLODStreamingComponent(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001871DE500-0x00000001871DE530
		protected override void LowMemory(); // 0x000000018CE34958-0x000000018CE34A5C
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_LowMemory(); // 0x0000000188F2AEA8-0x0000000188F2AEB0
	}

	[Serializable]
	public class HGReflectionProbeBinningQuality : QualityTierComponent // TypeDefIndex: 88293
	{
		// Constructors
		public HGReflectionProbeBinningQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void LowMemory(); // 0x000000018CE34A5C-0x000000018CE34AE4
		public void __iFixBaseProxy_LowMemory(); // 0x0000000188F2AEA8-0x0000000188F2AEB0
	}

	[Serializable]
	public class HGRPTierQuality : QualityTierComponent // TypeDefIndex: 88294
	{
		// Fields
		public int HGRP_QualityTier; // 0x18
	
		// Constructors
		public HGRPTierQuality(); // 0x000000018721F370-0x000000018721F3F0
	
		// Methods
		protected override void Apply(); // 0x00000001850CBE60-0x00000001850CBEB0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class HGScreenSpaceReflectionQuality : QualityTierComponent // TypeDefIndex: 88295
	{
		// Fields
		public int ssrQualityTier; // 0x18
	
		// Constructors
		public HGScreenSpaceReflectionQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001850CBBB0-0x00000001850CBC30
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class HGShadowQuality : QualityTierComponent // TypeDefIndex: 88296
	{
		// Fields
		public int shadowQualityTier; // 0x18
	
		// Constructors
		public HGShadowQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001850CBC30-0x00000001850CBCB0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class HGTextureQuality : EnumQualityComponent<HGTextureQuality.TextureQualityEnum> // TypeDefIndex: 88298
	{
		// Properties
		private int textureQualityTier { get; } // 0x00000001850CBD70-0x00000001850CBDE0 
	
		// Nested types
		public enum TextureQualityEnum : byte // TypeDefIndex: 88297
		{
			High = 0,
			Medium = 1,
			Low = 2
		}
	
		// Constructors
		public HGTextureQuality(); // 0x00000001872229F0-0x0000000187222A20
	
		// Methods
		protected override void Apply(); // 0x00000001850CBCB0-0x00000001850CBD70
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class HGVolumetricCloudQuality : QualityTierComponent // TypeDefIndex: 88299
	{
		// Fields
		public int volumetricCloudQualityTier; // 0x18
	
		// Constructors
		public HGVolumetricCloudQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private int GetShaderLod(); // 0x00000001850CC370-0x00000001850CC3A0
		protected override void Apply(); // 0x00000001850CC2E0-0x00000001850CC370
		public bool ShouldShowNoExLow(); // 0x000000018CE34B30-0x000000018CE34B7C
		public bool ShouldShowExLow(); // 0x000000018CE34AE4-0x000000018CE34B30
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class HGVolumetricFogQuality : QualityTierComponent // TypeDefIndex: 88300
	{
		// Fields
		public int volumetricFogQualityTier; // 0x18
	
		// Constructors
		public HGVolumetricFogQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001850CBDE0-0x00000001850CBE60
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class LODGroupQuality : QualityTierComponent // TypeDefIndex: 88301
	{
		// Fields
		public float lodBias; // 0x18
		public int lodOffset; // 0x1C
	
		// Constructors
		public LODGroupQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x000000018CE35828-0x000000018CE35880
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class MemoryReleaseIntervalQuality : QualityTierComponent // TypeDefIndex: 88302
	{
		// Fields
		private const float DEFAULT_SHRINK_MEMORY_INTERVAL_SECONDS = 600f; // Metadata: 0x0264845D
		private const float DEFAULT_PSO_RELEASE_INTERVAL_SECONDS = 1200f; // Metadata: 0x02648461
		private const float DEFAULT_LOW_MEMORY_PROCESS_INTERVAL_SECONDS = 180f; // Metadata: 0x02648465
		private static float s_currentShrinkMemoryIntervalSeconds; // 0x00
		private static float s_currentPsoReleaseIntervalSeconds; // 0x04
		private static float s_lastShrinkMemoryTimestamp; // 0x08
		private static float s_lastPsoReleaseTimestamp; // 0x0C
		public float shrinkMemoryIntervalSeconds; // 0x18
		public float psoReleaseIntervalSeconds; // 0x1C
		public float lowMemoryProcessIntervalSeconds; // 0x20
	
		// Constructors
		public MemoryReleaseIntervalQuality(); // 0x0000000184E39D20-0x0000000184E39D40
		static MemoryReleaseIntervalQuality(); // 0x0000000184E399F0-0x0000000184E39D20
	
		// Methods
		public static bool TryStartShrinkMemory(); // 0x0000000184E39250-0x0000000184E395A0
		public static bool TryStartPsoRelease(); // 0x0000000184E38EF0-0x0000000184E39250
		protected override void Apply(); // 0x0000000184E38870-0x0000000184E38EF0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void _Reset(); // 0x0000000184E395A0-0x0000000184E39930
		private static bool _TryStartInterval(ref float lastTimestamp, float intervalSeconds); // 0x0000000184E39930-0x0000000184E399F0
		public void __iFixBaseProxy_Apply(); // 0x0000000182985080-0x00000001829850B0
	}

	[Serializable]
	public class PhysicsClothQuality : QualityTierComponent // TypeDefIndex: 88303
	{
		// Fields
		public bool UsePhysicCloth; // 0x18
		public bool UseCrossFrameJob; // 0x19
	
		// Constructors
		public PhysicsClothQuality(); // 0x0000000187257B10-0x0000000187257B20
	
		// Methods
		protected override void Apply(); // 0x000000018CE35A18-0x000000018CE35AC8
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class PrefabInstantiateQuality : QualityTierComponent // TypeDefIndex: 88304
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
		public PrefabInstantiateQuality(); // 0x0000000187257B20-0x0000000187257B60
	
		// Methods
		protected override void Apply(); // 0x000000018CE35AC8-0x000000018CE35C44
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class PreloadLoadSettingQuality : QualityTierComponent // TypeDefIndex: 88305
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
		public PreloadLoadSettingQuality(); // 0x00000001871EBF20-0x00000001871EBF60
	
		// Methods
		protected override void Apply(); // 0x0000000186F8E0D0-0x0000000186F8E240
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class QNSSFrameGenQuality : ToggleQualityComponent // TypeDefIndex: 88306
	{
		// Fields
		private const int QNSS_DEFAULT_LEVEL = 3; // Metadata: 0x02648469
	
		// Constructors
		public QNSSFrameGenQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static bool _GetToggleFromUDSClient(); // 0x000000018CE35CE0-0x000000018CE35D28
		protected override void PreInit(); // 0x0000000184E39D40-0x0000000184E3B100
		protected override void Toggle(bool value); // 0x000000018CE35C80-0x000000018CE35CE0
		public bool ShouldShow(); // 0x000000018CE35C44-0x000000018CE35C80
		private void _OnServerFILevelChanged(int newFILevel); // 0x000000018CE35D28-0x000000018CE35D70
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
		public void __iFixBaseProxy_Toggle(bool P0); // 0x000000018CE31848-0x000000018CE31850
	}

	[Serializable]
	public class QNSSUpscalerQuality : ToggleQualityComponent // TypeDefIndex: 88307
	{
		// Fields
		private const int QNSS_DEFAULT_LEVEL = 2; // Metadata: 0x0264846A
	
		// Constructors
		public QNSSUpscalerQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static bool _GetToggleFromUDSClient(); // 0x000000018CE35E08-0x000000018CE35E50
		protected override void PreInit(); // 0x0000000184E3B100-0x0000000184E3C4C0
		protected override void Toggle(bool value); // 0x000000018CE35DAC-0x000000018CE35E08
		public bool ShouldShow(); // 0x000000018CE35D70-0x000000018CE35DAC
		private void _OnServerSRLevelChanged(int newSRLevel); // 0x000000018CE35E50-0x000000018CE35E98
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
		public void __iFixBaseProxy_Toggle(bool P0); // 0x000000018CE31848-0x000000018CE31850
	}

	[Serializable]
	public class RayTracingQuality : ToggleQualityComponent // TypeDefIndex: 88308
	{
		// Properties
		public static bool supportsRayTracing { get; } // 0x00000001854725A0-0x00000001854725E0 
	
		// Constructors
		public RayTracingQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void InitApply(); // 0x00000001854724C0-0x0000000185472520
		protected override void Apply(); // 0x000000018CE37A08-0x000000018CE37AF8
		public bool ShouldShow(); // 0x00000001854736C0-0x00000001854736F0
		internal override int ApplyOrder(); // 0x0000000187225890-0x00000001872258C0
		public void __iFixBaseProxy_InitApply(); // 0x000000018CE3491C-0x000000018CE34924
		public void __iFixBaseProxy_Apply(); // 0x000000018CE34334-0x000000018CE3433C
		public int __iFixBaseProxy_ApplyOrder(); // 0x000000018CE37AF8-0x000000018CE37B00
	}

	[Serializable]
	public class ReflexQuality : EnumQualityComponent<StreamlineReflexMode> // TypeDefIndex: 88309
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public ReflexQuality(); // 0x0000000187222690-0x00000001872226C0
	
		// Methods
		protected override void Apply(); // 0x0000000185473F70-0x00000001854740F0
		public bool ShouldShow(); // 0x00000001854725E0-0x00000001854726A0
		protected override void PreInit(); // 0x0000000184E3E660-0x0000000184E3ECB0
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x0000000185473970-0x0000000185473A70
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
	}

	[Serializable]
	public class RenderingScaleQualityMobile : EnumQualityComponent<RenderingScaleQualityMobile.RenderingScaleMode> // TypeDefIndex: 88311
	{
		// Properties
		public float renderingScaleFactor { get; } // 0x000000018CE37C38-0x000000018CE37CF8 
	
		// Nested types
		public enum RenderingScaleMode // TypeDefIndex: 88310
		{
			ExHigh = 0,
			High = 1,
			Medium = 2,
			Low = 3,
			ExLow = 4
		}
	
		// Constructors
		public RenderingScaleQualityMobile(); // 0x000000018CE37C10-0x000000018CE37C38
	
		// Methods
		protected override void Apply(); // 0x000000018CE37B00-0x000000018CE37C10
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class RenderingScaleQualityPC : EnumQualityComponent<RenderingScaleQualityPC.RenderingScaleMode> // TypeDefIndex: 88313
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Properties
		public float renderingScale { get; } // 0x00000001854749B0-0x0000000185474A20 
	
		// Nested types
		public enum RenderingScaleMode // TypeDefIndex: 88312
		{
			Percent100 = 0,
			Percent90 = 1,
			Percent80 = 2,
			Percent70 = 3,
			Percent60 = 4
		}
	
		// Constructors
		public RenderingScaleQualityPC(); // 0x0000000187222660-0x0000000187222690
	
		// Methods
		protected override void Apply(); // 0x0000000185474840-0x00000001854749B0
		public bool ShouldShow(); // 0x0000000185472160-0x0000000185472210
		protected override void PreInit(); // 0x0000000184E3ECB0-0x0000000184E3F300
		internal void DlSSChange(QualityTierComponent qualityTierComponent); // 0x0000000185474D20-0x0000000185474E70
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
	}

	[Serializable]
	public class ResLoadSettingQuality : QualityTierComponent // TypeDefIndex: 88314
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
		public ResLoadSettingQuality(); // 0x000000018716CBD0-0x000000018716CC30
	
		// Methods
		protected override void Apply(); // 0x0000000186F833D0-0x0000000186F83580
		protected override void LowMemory(); // 0x000000018CE37CF8-0x000000018CE37DC8
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_LowMemory(); // 0x0000000188F2AEA8-0x0000000188F2AEB0
	}

	[Serializable]
	public class SceneDetailQuality : QualityTierComponent // TypeDefIndex: 88315
	{
		// Fields
		public int sceneDetailQualityTier; // 0x18
	
		// Constructors
		public SceneDetailQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001850CC0A0-0x00000001850CC150
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class ShaderLodQuality : QualityTierComponent // TypeDefIndex: 88317
	{
		// Fields
		public ShaderLodEnum ShaderLod; // 0x18
	
		// Nested types
		public enum ShaderLodEnum // TypeDefIndex: 88316
		{
			Mobile100 = 100,
			Mobile200 = 200,
			Mobile300 = 300,
			Mobile400 = 400,
			Mobile500 = 500,
			PC600 = 600
		}
	
		// Constructors
		public ShaderLodQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void InitApply(); // 0x0000000187105560-0x0000000187105590
		protected override void Apply(); // 0x000000018CE37DC8-0x000000018CE37E98
		public void __iFixBaseProxy_InitApply(); // 0x000000018CE3491C-0x000000018CE34924
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class SharpnessQuality : SliderQualityComponent // TypeDefIndex: 88318
	{
		// Constructors
		public SharpnessQuality(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x00000001854740F0-0x0000000185474250
		public bool ShouldShow(); // 0x0000000185472210-0x00000001854722C0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class SliderTestComponent : SliderQualityComponent // TypeDefIndex: 88319
	{
		// Constructors
		public SliderTestComponent(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Apply(); // 0x000000018CE37F94-0x000000018CE37FC8
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class TickExclusiveQuality : QualityTierComponent // TypeDefIndex: 88320
	{
		// Fields
		public TickExclusiveMode quality; // 0x18
		private LogicQualityLevel m_currentQuality; // 0x1C
		private ThermalState m_currentThermalState; // 0x1D
	
		// Constructors
		public TickExclusiveQuality(); // 0x000000018722E950-0x000000018722E960
	
		// Methods
		protected override void Apply(); // 0x00000001867C4390-0x00000001867C4400
		protected override void DynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last); // 0x00000001867C4400-0x00000001867C4430
		protected override void DynamicThermalChange(ThermalState current, ThermalState last); // 0x000000018CE37FC8-0x000000018CE38018
		private void _OnQualityOrThermalChanged(); // 0x00000001867C4430-0x00000001867C44E0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_DynamicQualityChange(LogicQualityLevel P0, LogicQualityLevel P1); // 0x000000018926BDC4-0x000000018926BDCC
		public void __iFixBaseProxy_DynamicThermalChange(ThermalState P0, ThermalState P1); // 0x000000018926BDCC-0x000000018926BDD4
	}

	[Serializable]
	public class UpscalerQuality : EnumQualityComponent<UpscalerQuality.UpscalerMode> // TypeDefIndex: 88322
	{
		// Nested types
		public enum UpscalerMode // TypeDefIndex: 88321
		{
			DLSS = 0,
			TAAU = 1,
			FSR3 = 2
		}
	
		// Constructors
		public UpscalerQuality(); // 0x0000000187222420-0x0000000187222450
	
		// Methods
		protected override void Apply(); // 0x00000001854751A0-0x0000000185475630
		protected override void PreInit(); // 0x0000000184E3F300-0x0000000184E3F910
		public bool ShouldShow(); // 0x000000018CE38150-0x000000018CE3818C
		public bool ShouldShowDLSS(); // 0x0000000185473690-0x00000001854736C0
		public bool ShouldShowFSR3(); // 0x0000000185473660-0x0000000185473690
		public override int Version(); // 0x00000001871FD290-0x00000001871FD2C0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
		public int __iFixBaseProxy_Version(); // 0x0000000189738B9C-0x0000000189738BA4
	}

	[Serializable]
	[Obsolete]
	public class VSyncQuality : QualityTierComponent // TypeDefIndex: 88323
	{
		// Fields
		public bool bVSync; // 0x18
	
		// Constructors
		public VSyncQuality(); // 0x0000000187233970-0x0000000187233980
	
		// Methods
		protected override void Apply(); // 0x000000018CE3818C-0x000000018CE381D0
		protected void Remove(); // 0x000000018CE381D0-0x000000018CE3820C
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init(); // 0x00000001871054C0-0x00000001871054F0
		public void __iFixBaseProxy_Apply(); // 0x0000000188F2AEA0-0x0000000188F2AEA8
	}

	[Serializable]
	public class VSyncQualityV2 : ToggleQualityComponent // TypeDefIndex: 88324
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x20
	
		// Constructors
		public VSyncQualityV2(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void Toggle(bool value); // 0x0000000186E78000-0x0000000186E780F0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init(); // 0x00000001871054F0-0x0000000187105520
		public override int Version(); // 0x0000000187225020-0x0000000187225050
		protected override void PreInit(); // 0x0000000184E3F910-0x0000000184E3FF60
		internal void FrameGenChange(QualityTierComponent qualityTierComponent); // 0x0000000185473A70-0x0000000185473B40
		public bool ShouldShow(); // 0x0000000185471DD0-0x0000000185471E90
		public void __iFixBaseProxy_Toggle(bool P0); // 0x000000018CE31848-0x000000018CE31850
		public int __iFixBaseProxy_Version(); // 0x0000000189738B9C-0x0000000189738BA4
		public void __iFixBaseProxy_PreInit(); // 0x0000000184E24B40-0x0000000184E24B70
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 88234
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 88235
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 88236
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 88237
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 88238
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 88239
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 88240
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 88232
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 88325
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018CE3572C-0x000000018CE35790
	
		// Methods
		public void __Gen_Wrap_0(); // 0x00000001887ED074-0x00000001887ED104
		public void __Gen_Wrap_1(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public string __Gen_Wrap_2(ref RankingRule P0); // 0x000000018CE350B8-0x000000018CE35208
		public string __Gen_Wrap_3(ref DeviceMatchResult P0); // 0x000000018CE35208-0x000000018CE35364
		public string __Gen_Wrap_4(object P0); // 0x000000018CE35364-0x000000018CE35444
		public bool __Gen_Wrap_5(ref DeviceMatchResult P0); // 0x000000018CE35444-0x000000018CE35590
		public bool __Gen_Wrap_6(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public string __Gen_Wrap_7(); // 0x000000018CE35590-0x000000018CE3564C
		public DeviceMatchRules __Gen_Wrap_8(object P0); // 0x000000018CE3564C-0x000000018CE3572C
		public int __Gen_Wrap_9(object P0, object P1); // 0x0000000188B4BB74-0x0000000188B4BC54
		public int __Gen_Wrap_10(object P0, object P1, ESteamHardwareType P2); // 0x0000000182CD0600-0x0000000182CD09A0
		public string __Gen_Wrap_11(object P0, object P1); // 0x0000000184E27150-0x0000000184E27B50
		public bool __Gen_Wrap_12(object P0, object P1, object P2, ref RankingRule P3); // 0x0000000184E27B50-0x0000000184E28990
		public bool __Gen_Wrap_13(object P0, object P1, object P2, ref RankingRule P3, out string P4); // 0x0000000184E28990-0x0000000184E29A60
		public void __Gen_Wrap_14(object P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_15(object P0, object P1, ref RankingRule P2); // 0x0000000184E29A60-0x0000000184E2A820
		public bool __Gen_Wrap_16(ref RankingRule P0, RankingRule P1); // 0x0000000184E2A820-0x0000000184E2B510
		public string __Gen_Wrap_17(ref MemoryRule P0); // 0x0000000184E2B510-0x0000000184E2C3B0
		public bool __Gen_Wrap_18(ref MemoryRule P0, MemoryRule P1); // 0x0000000184E2C3B0-0x0000000184E2D060
		public string __Gen_Wrap_19(ref DeviceQualityMapItem P0); // 0x0000000184E2D060-0x0000000184E2DF80
		public UnityEngine.Color __Gen_Wrap_20(ref DeviceQualityMapItem P0, int P1); // 0x0000000184E2DF80-0x0000000184E2EED0
		public UnityEngine.Color __Gen_Wrap_21(ref DeviceQualityMapItem P0); // 0x0000000184E2EED0-0x0000000184E2FE20
		public DeviceQualityMapItem __Gen_Wrap_22(object P0); // 0x0000000184E2FE20-0x0000000184E30710
		public int __Gen_Wrap_23(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public Beyond.Scripts.Quality.DeviceInfo __Gen_Wrap_24(object P0); // 0x0000000184E30710-0x0000000184E31030
		public int __Gen_Wrap_25(QualityTierLevel P0); // 0x000000018246EB30-0x000000018246EDF0
		public int __Gen_Wrap_26(DeviceQualityMapItem P0); // 0x0000000184E31030-0x0000000184E315F0
		public QualityTierComponentMatch __Gen_Wrap_27(object P0, object P1, int P2); // 0x0000000184E315F0-0x0000000184E31FD0
		public int __Gen_Wrap_28(QualityTierComponentMatch P0); // 0x0000000184E31FD0-0x0000000184E32580
		public void __Gen_Wrap_29(object P0, object P1, object P2); // 0x0000000182532090-0x00000001825324E0
		public void __Gen_Wrap_30(object P0, bool P1); // 0x000000018253E590-0x000000018253E870
		public QualityTierComponentMatch __Gen_Wrap_31(object P0, object P1); // 0x0000000184E32580-0x0000000184E32F40
		public void __Gen_Wrap_32(object P0, int P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_33(object P0, LogicQualityLevel P1, LogicQualityLevel P2); // 0x0000000183B534B0-0x0000000183B537A0
		public void __Gen_Wrap_34(object P0, in EventData<LogicQualityLevel, LogicQualityLevel> P1); // 0x0000000184E32F40-0x0000000184E335C0
		public void __Gen_Wrap_35(object P0, ThermalState P1, ThermalState P2); // 0x0000000183B534B0-0x0000000183B537A0
		public void __Gen_Wrap_36(object P0, in EventData<ThermalState, ThermalState> P1); // 0x0000000184E335C0-0x0000000184E33C40
		public System.Type __Gen_Wrap_37(object P0, object P1); // 0x0000000184E33C40-0x0000000184E34640
		public void __Gen_Wrap_38(object P0, object P1, int P2); // 0x0000000182528040-0x00000001825283D0
		public void __Gen_Wrap_39(object P0, Beyond.GameSetting.GameSettingVideoQuality P1); // 0x00000001824828A0-0x0000000182482B70
		public Beyond.GameSetting.GameSettingVideoQuality __Gen_Wrap_40(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public bool __Gen_Wrap_41(); // 0x0000000182541760-0x0000000182541930
		public bool __Gen_Wrap_42(object P0, object P1); // 0x00000001827B9DC0-0x00000001827BA150
		public QualityTierType __Gen_Wrap_43(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public void __Gen_Wrap_44(object P0, float P1); // 0x0000000182659420-0x0000000182659700
		public void __Gen_Wrap_45(object P0, object P1, float P2); // 0x00000001827B9100-0x00000001827B94A0
		public Vector2 __Gen_Wrap_46(object P0); // 0x0000000184E34640-0x0000000184E34F30
		public float __Gen_Wrap_47(object P0); // 0x00000001826A2110-0x00000001826A23D0
		public Vector3 __Gen_Wrap_48(object P0, object P1); // 0x0000000184E34F30-0x0000000184E358F0
		public bool __Gen_Wrap_49(object P0, object P1, object P2, object P3); // 0x0000000184E358F0-0x0000000184E35E20
		public ValueTuple<float, float> __Gen_Wrap_50(object P0, object P1); // 0x0000000184E35E20-0x0000000184E367D0
		public int __Gen_Wrap_51(int P0, int P1); // 0x00000001825DB8C0-0x00000001825DBAD0
		public float __Gen_Wrap_52(object P0, object P1); // 0x0000000182E04540-0x0000000182E048D0
		public int __Gen_Wrap_53(QualityTierComponentMatch P0, QualityTierComponentMatch P1); // 0x0000000184E367D0-0x0000000184E36E70
		public void __Gen_Wrap_54(object P0, object P1, out int P2, out int P3); // 0x000000018362BD20-0x000000018362C110
		public bool __Gen_Wrap_55(object P0, object P1, int P2); // 0x00000001824E73F0-0x00000001824E7790
		public byte[] __Gen_Wrap_56(object P0); // 0x0000000184E36E70-0x0000000184E37790
		public JsonSerializerSettings __Gen_Wrap_57(); // 0x0000000184E37790-0x0000000184E37FB0
		public void __Gen_Wrap_58(object P0, StreamingContext P1); // 0x0000000184E37FB0-0x0000000184E38620
		public int __Gen_Wrap_59(FrameRateQuality.FrameRateQualityEnum P0); // 0x0000000182655FC0-0x00000001826561C0
		public void __Gen_Wrap_60(int P0, HgFrameRateControl.ReasonEnum P1); // 0x0000000182522690-0x0000000182522890
		public int __Gen_Wrap_61(); // 0x00000001825212D0-0x00000001825214A0
		public int __Gen_Wrap_62(FrameRateQualityMobile.FrameRateQualityMobileEnum P0); // 0x0000000182655FC0-0x00000001826561C0
		public bool __Gen_Wrap_63(ref float P0, float P1); // 0x0000000184E38620-0x0000000184E38870
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 88326
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018CE35790-0x000000018CE35828
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 88327
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018CE383F8-0x000000018CE3845C
		public static bool IsPatched(int id); // 0x000000018CE384E8-0x000000018CE38564
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018CE382B0-0x000000018CE3837C
		public object CreateWrapper(int id); // 0x000000018CE3837C-0x000000018CE383F8
		public object InitWrapperArray(int len); // 0x000000018CE3845C-0x000000018CE384E8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018CE3820C-0x000000018CE382B0
	}

	public delegate void __HotPatchDelegate_0(); // TypeDefIndex: 88328; 0x0000000185B44B70-0x0000000185B44B80

	public enum HotPatchIDMAP0 // TypeDefIndex: 88329
	{
		Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-Initialize0 = 0,
		Beyond-PoolCore-ListPoolInitializer_RuntimeQuality-InitializeAtRuntime0 = 0,
		Beyond-Scripts-Quality-QualityManager-_ReportQuality0 = 0,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-Init0 = 0,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-ResetFrameRate0 = 0,
		Beyond-Scripts-Quality-Components-MemoryReleaseIntervalQuality-_Reset0 = 0,
		Beyond-Scripts-Quality-Components-VSyncQuality-Init0 = 0,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Init0 = 0,
		Beyond-Scripts-Quality-DeviceMatchRules-Combine0 = 1,
		Beyond-Scripts-Quality-DeviceInfo-SupplementFromRemote0 = 1,
		Beyond-Scripts-Quality-QualityManager-LoadQualityTier0 = 1,
		Beyond-Scripts-Quality-QualityManager-Init0 = 1,
		Beyond-Scripts-Quality-QualityManager-InitOnlyDevice0 = 1,
		Beyond-Scripts-Quality-QualityManager-InitResetQualityTierComponentFunction0 = 1,
		Beyond-Scripts-Quality-QualityManager-RevertSetQualityTierComponentLevel0 = 1,
		Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveQualitySettingSaveValue0 = 1,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-DlSSChange0 = 1,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-DlSSChange0 = 1,
		Beyond-Scripts-Quality-Components-FrameRateQuality-DlSSChange0 = 1,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-FSR3Change0 = 1,
		Beyond-Scripts-Quality-Components-ReflexQuality-DlSSChange0 = 1,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-DlSSChange0 = 1,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-FrameGenChange0 = 1,
		Beyond-Scripts-Quality-RankingRule-ToString0 = 2,
		Beyond-Scripts-Quality-DeviceMatchResult-ToString0 = 3,
		Beyond-Scripts-Quality-DeviceInfo-ToString0 = 4,
		Beyond-Scripts-Quality-QualityManager-ToString0 = 4,
		Beyond-Scripts-Quality-QualityManager-DebugQualityTierComponentInfo0 = 4,
		Beyond-Scripts-Quality-DeviceMatchResult-IsNoMatch0 = 5,
		Beyond-Scripts-Quality-DeviceInfo-IsNoMatchDevice0 = 6,
		Beyond-Scripts-Quality-DeviceInfo-IsZeroDevices0 = 6,
		Beyond-Scripts-Quality-DeviceInfo-IsHUAWEIDevice0 = 6,
		Beyond-Scripts-Quality-DeviceInfo-IsQualcommDevice0 = 6,
		Beyond-Scripts-Quality-QualityManager-get_isInitializing0 = 6,
		Beyond-Scripts-Quality-QualityManager-NoMatchDeviceOrZeroScore0 = 6,
		Beyond-Scripts-Quality-QualityManager-IsQualcommDevice0 = 6,
		Beyond-Scripts-Quality-QualityManager-IsHUAWEIDevice0 = 6,
		Beyond-Scripts-Quality-QualityManager-NeedRestart0 = 6,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetValue0 = 6,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetDefaultValue0 = 6,
		Beyond-Scripts-Quality-Components-QualityTierComponent-TierLimit0 = 6,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowAuto0 = 6,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX10 = 6,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX20 = 6,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX30 = 6,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-DLSSUpscalerModel-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowDLSS0 = 6,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowFSR30 = 6,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-FrameGenQualityMobile-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-FrameRateQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS30Enabled0 = 6,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS60Enabled0 = 6,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPSBNoLimitEnabled0 = 6,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_IsGDLSSGDisable0 = 6,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-ShouldShowNoExLow0 = 6,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-ShouldShowExLow0 = 6,
		Beyond-Scripts-Quality-Components-QNSSFrameGenQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-QNSSUpscalerQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-RayTracingQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-ReflexQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-SharpnessQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowDLSS0 = 6,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShow0 = 6,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowFSR30 = 6,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-ShouldShow0 = 6,
		Beyond-Scripts-Quality-DeviceInfo-get_cpuName0 = 7,
		Beyond-Scripts-Quality-DeviceInfo-LoadingSettingRules0 = 8,
		Beyond-Scripts-Quality-DeviceInfo-CloudGameGetMatchedRule0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneGetMatchedRule0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-GetDeviceScore0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-AndroidGetMatchedRule0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-IOSGetMatchedRule0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-DefaultGetMatchedRule0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-EditorSimulateGetMatchedRule0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneOSXGetMatchedRule0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-StandalonePS5GetMatchedRule0 = 9,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierVersion0 = 9,
		Beyond-Scripts-Quality-QualityManager-GetEnumQualityTierComponentCount0 = 9,
		Beyond-Scripts-Quality-DeviceInfo-SteamDeckGetMatchedRule0 = 10,
		Beyond-Scripts-Quality-DeviceInfo-GetNvidiaStandardGPUName0 = 11,
		Beyond-Scripts-Quality-DeviceInfo-GetAmdStandardGPUName0 = 11,
		Beyond-Scripts-Quality-DeviceInfo-GetIntelStandardGPUName0 = 11,
		Beyond-Scripts-Quality-DeviceInfo-GetAdrenoStandardGPUName0 = 11,
		Beyond-Scripts-Quality-DeviceInfo-GetMaliStandardGPUName0 = 11,
		Beyond-Scripts-Quality-DeviceInfo-GetPowerVRStandardGPUName0 = 11,
		Beyond-Scripts-Quality-DeviceInfo-RuleSuffixMatch0 = 12,
		Beyond-Scripts-Quality-DeviceInfo-MatchDeviceModeRule0 = 12,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneMatchGPURule0 = 13,
		Beyond-Scripts-Quality-DeviceInfo-MatchGPURule0 = 13,
		Beyond-Scripts-Quality-DeviceInfo-_ReportMatchRuleFailed0 = 14,
		Beyond-Scripts-Quality-Components-QualityTierComponent-Apply0 = 14,
		Beyond-Scripts-Quality-Components-QualityTierComponent-InitApply0 = 14,
		Beyond-Scripts-Quality-Components-QualityTierComponent-LowMemory0 = 14,
		Beyond-Scripts-Quality-Components-QualityTierComponent-SafeApply0 = 14,
		Beyond-Scripts-Quality-QualityManager-ApplyCallBack0 = 14,
		Beyond-Scripts-Quality-QualityManager-ApplyQualityScore0 = 14,
		Beyond-Scripts-Quality-QualityManager-_DynamicInitQualitySetting0 = 14,
		Beyond-Scripts-Quality-QualityManager-FinishInit0 = 14,
		Beyond-Scripts-Quality-QualityManager-ApplyShaderTier0 = 14,
		Beyond-Scripts-Quality-QualityManager-InitShaderLod0 = 14,
		Beyond-Scripts-Quality-QualityManager-_DynamicReleaseQualitySetting0 = 14,
		Beyond-Scripts-Quality-QualityManager-Dispose0 = 14,
		Beyond-Scripts-Quality-Components-AntiAliasingQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-QualityTierComponent-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveRegisterKey0 = 14,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-Apply0 = 14,
		Beyond-Scripts-Quality-Components-CharacterRenderFeatureQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-DLSSUpscalerModel-Apply0 = 14,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-EnvironmentRenderingFeatureQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-FrameGenQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-FrameGenQualityMobile-Apply0 = 14,
		Beyond-Scripts-Quality-Components-FrameRateQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-FrameRateQuality-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Apply0 = 14,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-GrassSparsityQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGAmbientOcclusionQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-InitApply0 = 14,
		Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGIrradianceVolumeQuality-LowMemory0 = 14,
		Beyond-Scripts-Quality-Components-HGLODStreamingComponent-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGLODStreamingComponent-LowMemory0 = 14,
		Beyond-Scripts-Quality-Components-HGReflectionProbeBinningQuality-LowMemory0 = 14,
		Beyond-Scripts-Quality-Components-HGRPTierQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGScreenSpaceReflectionQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGShadowQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGTextureQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-HGVolumetricFogQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-LODGroupQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-MemoryReleaseIntervalQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-PhysicsClothQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-PrefabInstantiateQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-PreloadLoadSettingQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-QNSSFrameGenQuality-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-QNSSUpscalerQuality-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-RayTracingQuality-InitApply0 = 14,
		Beyond-Scripts-Quality-Components-RayTracingQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-ReflexQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-ReflexQuality-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-Apply0 = 14,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-Apply0 = 14,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-ResLoadSettingQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-ResLoadSettingQuality-LowMemory0 = 14,
		Beyond-Scripts-Quality-Components-SceneDetailQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-ShaderLodQuality-InitApply0 = 14,
		Beyond-Scripts-Quality-Components-ShaderLodQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-SharpnessQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-SliderTestComponent-Apply0 = 14,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-_OnQualityOrThermalChanged0 = 14,
		Beyond-Scripts-Quality-Components-UpscalerQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-UpscalerQuality-PreInit0 = 14,
		Beyond-Scripts-Quality-Components-VSyncQuality-Apply0 = 14,
		Beyond-Scripts-Quality-Components-VSyncQuality-Remove0 = 14,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-PreInit0 = 14,
		Beyond-Scripts-Quality-DeviceInfo-RuleFullNameMatch0 = 15,
		Beyond-Scripts-Quality-RankingRule-Equals0 = 16,
		Beyond-Scripts-Quality-MemoryRule-ToString0 = 17,
		Beyond-Scripts-Quality-MemoryRule-Equals0 = 18,
		Beyond-Scripts-Quality-DeviceQualityMapItem-ToString0 = 19,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getColor0 = 20,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryLowColor0 = 21,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getLowColor0 = 21,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getMiddleColor0 = 21,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getHighColor0 = 21,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryHighColor0 = 21,
		Beyond-Scripts-Quality-QualityManager-get_Config0 = 22,
		Beyond-Scripts-Quality-QualityManager-get_currentTier0 = 23,
		Beyond-Scripts-Quality-QualityManager-get_defaultTier0 = 23,
		Beyond-Scripts-Quality-Components-QualityTierComponent-ApplyOrder0 = 23,
		Beyond-Scripts-Quality-Components-QualityTierComponent-Version0 = 23,
		Beyond-Scripts-Quality-Components-FrameRateQuality-get_frameRate0 = 23,
		Beyond-Scripts-Quality-Components-FrameRateQuality-Version0 = 23,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-get_frameRate0 = 23,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Version0 = 23,
		Beyond-Scripts-Quality-Components-HGTextureQuality-get_textureQualityTier0 = 23,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-GetShaderLod0 = 23,
		Beyond-Scripts-Quality-Components-RayTracingQuality-ApplyOrder0 = 23,
		Beyond-Scripts-Quality-Components-UpscalerQuality-Version0 = 23,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Version0 = 23,
		Beyond-Scripts-Quality-QualityManager-get_device0 = 24,
		Beyond-Scripts-Quality-QualityManager-_SetQualityTierComponentLevel0 = 25,
		Beyond-Scripts-Quality-QualityManager-InvokeChangeCallBack0 = 26,
		Beyond-Scripts-Quality-Components-QualityTierComponent-SafeLowMemory0 = 27,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-Toggle0 = 27,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-SetToggleWithoutApply0 = 27,
		Beyond-Scripts-Quality-Components-ChromaticAberrationQuality-Toggle0 = 27,
		Beyond-Scripts-Quality-Components-HGContactShadowQuality-Toggle0 = 27,
		Beyond-Scripts-Quality-Components-QNSSFrameGenQuality-Toggle0 = 27,
		Beyond-Scripts-Quality-Components-QNSSUpscalerQuality-Toggle0 = 27,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Toggle0 = 27,
		Beyond-Scripts-Quality-QualityManager-_GetOverrideQualityTierComponentLevel0 = 28,
		Beyond-Scripts-Quality-QualityManager-setQualityTier0 = 29,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-ChangeToggle0 = 29,
		Beyond-Scripts-Quality-Components-QNSSFrameGenQuality-_OnServerFILevelChanged0 = 29,
		Beyond-Scripts-Quality-Components-QNSSUpscalerQuality-_OnServerSRLevelChanged0 = 29,
		Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicQualityChange0 = 30,
		Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicQualityChange0 = 30,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicQualityChange0 = 30,
		Beyond-Scripts-Quality-QualityManager-DynamicQualityChange0 = 31,
		Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicThermalChange0 = 32,
		Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicThermalChange0 = 32,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicThermalChange0 = 32,
		Beyond-Scripts-Quality-QualityManager-DynamicThermalChange0 = 33,
		Beyond-Scripts-Quality-QualityManager-_GetQualityComponentByName0 = 34,
		Beyond-Scripts-Quality-QualityManager-_ForceSetQualityTierComponentLevel0 = 35,
		Beyond-Scripts-Quality-QualityManager-_ToggleQualityTierComponentLevel0 = 35,
		Beyond-Scripts-Quality-QualityManager-SetEnumQualityTierComponentCount0 = 35,
		Beyond-Scripts-Quality-QualityManager-SetQualityTierByVideoQuality0 = 36,
		Beyond-Scripts-Quality-QualityManager-GetDefaultVideoQuality0 = 37,
		Beyond-Scripts-Quality-QualityManager-IsIpadDevice0 = 38,
		Beyond-Scripts-Quality-Components-MemoryReleaseIntervalQuality-TryStartShrinkMemory0 = 38,
		Beyond-Scripts-Quality-Components-MemoryReleaseIntervalQuality-TryStartPsoRelease0 = 38,
		Beyond-Scripts-Quality-Components-QNSSFrameGenQuality-_GetToggleFromUDSClient0 = 38,
		Beyond-Scripts-Quality-Components-QNSSUpscalerQuality-_GetToggleFromUDSClient0 = 38,
		Beyond-Scripts-Quality-Components-RayTracingQuality-get_supportsRayTracing0 = 38,
		Beyond-Scripts-Quality-QualityManager-ResetQualityTierComponentValue0 = 39,
		Beyond-Scripts-Quality-QualityManager-_IsToggleQualityTierComponent0 = 39,
		Beyond-Scripts-Quality-QualityManager-IsEnumQualityTierComponent0 = 39,
		Beyond-Scripts-Quality-QualityManager-IsSliderQualityTierComponent0 = 39,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierType0 = 40,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-SetValue0 = 41,
		Beyond-Scripts-Quality-QualityManager-SetSliderQualityTierComponentCount0 = 42,
		Beyond-Scripts-Quality-QualityManager-SetQualityComponentTier0 = 42,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetRange0 = 43,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetValue0 = 44,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetDefaultValue0 = 44,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-get_renderingScaleFactor0 = 44,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-get_renderingScale0 = 44,
		Beyond-Scripts-Quality-QualityManager-GetSliderQualityTierComponent0 = 45,
		Beyond-Scripts-Quality-QualityManager-InvokeQualityTierComponent0 = 46,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierCount0 = 47,
		Beyond-Scripts-Quality-QualityManager-GetQualityComponentDefaultTier0 = 48,
		Beyond-Scripts-Quality-QualityManager-GetQualityComponentTier0 = 48,
		Beyond-Scripts-Quality-QualityManager-_GetCurrentComponentTierIndex0 = 49,
		Beyond-Scripts-Quality-QualityManager-IsQualitySubSettingTierValid0 = 50,
		Beyond-Scripts-Quality-QualityUtility-Decompress0 = 51,
		Beyond-Scripts-Quality-QualityUtility-get_JsonSerializerSettings0 = 52,
		Beyond-Scripts-Quality-Components-QualityTierComponent-OnDeserialized0 = 53,
		Beyond-Scripts-Quality-Components-FrameRateQuality-GetFrameRateFromEnum0 = 54,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-__ForceSetFrameRate0 = 55,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-SetFrameRateOverrider0 = 55,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetDefaultFrameRate0 = 56,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetFrameRate0 = 56,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-RecommendedDefaultFrameRate0 = 56,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetUserSettingFrameRate0 = 56,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-GetFrameRateFromEnum0 = 57,
		Beyond-Scripts-Quality-Components-MemoryReleaseIntervalQuality-_TryStartInterval0 = 58
	}

	public delegate void __HotPatchDelegate_1(object P0, object P1); // TypeDefIndex: 88330; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_2(ref RankingRule P0); // TypeDefIndex: 88331; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_3(ref DeviceMatchResult P0); // TypeDefIndex: 88332; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_4(object P0); // TypeDefIndex: 88333; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_5(ref DeviceMatchResult P0); // TypeDefIndex: 88334; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_6(object P0); // TypeDefIndex: 88335; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_7(); // TypeDefIndex: 88336; 0x0000000185B44B70-0x0000000185B44B80

	public delegate DeviceMatchRules __HotPatchDelegate_8(object P0); // TypeDefIndex: 88337; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_9(object P0, object P1); // TypeDefIndex: 88338; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_10(object P0, object P1, ESteamHardwareType P2); // TypeDefIndex: 88339; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_11(object P0, object P1); // TypeDefIndex: 88340; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_12(object P0, object P1, object P2, ref RankingRule P3); // TypeDefIndex: 88341; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_13(object P0, object P1, object P2, ref RankingRule P3, out string P4); // TypeDefIndex: 88342; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_14(object P0); // TypeDefIndex: 88343; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_15(object P0, object P1, ref RankingRule P2); // TypeDefIndex: 88344; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_16(ref RankingRule P0, RankingRule P1); // TypeDefIndex: 88345; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate string __HotPatchDelegate_17(ref MemoryRule P0); // TypeDefIndex: 88346; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_18(ref MemoryRule P0, MemoryRule P1); // TypeDefIndex: 88347; 0x0000000186036470-0x00000001860364A0

	public delegate string __HotPatchDelegate_19(ref DeviceQualityMapItem P0); // TypeDefIndex: 88348; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UnityEngine.Color __HotPatchDelegate_20(ref DeviceQualityMapItem P0, int P1); // TypeDefIndex: 88349; 0x00000001812C43A0-0x00000001812C43E0

	public delegate UnityEngine.Color __HotPatchDelegate_21(ref DeviceQualityMapItem P0); // TypeDefIndex: 88350; 0x0000000186464680-0x00000001864646B0

	public delegate DeviceQualityMapItem __HotPatchDelegate_22(object P0); // TypeDefIndex: 88351; 0x00000001811C4340-0x00000001811C4380

	public delegate int __HotPatchDelegate_23(object P0); // TypeDefIndex: 88352; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Beyond.Scripts.Quality.DeviceInfo __HotPatchDelegate_24(object P0); // TypeDefIndex: 88353; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate QualityTierComponentMatch __HotPatchDelegate_25(object P0, object P1, int P2); // TypeDefIndex: 88354; 0x00000001812D51A0-0x00000001812D51E0

	public delegate void __HotPatchDelegate_26(object P0, object P1, object P2); // TypeDefIndex: 88355; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_27(object P0, bool P1); // TypeDefIndex: 88356; 0x00000001859B7730-0x00000001859B7740

	public delegate QualityTierComponentMatch __HotPatchDelegate_28(object P0, object P1); // TypeDefIndex: 88357; 0x00000001812C43A0-0x00000001812C43E0

	public delegate void __HotPatchDelegate_29(object P0, int P1); // TypeDefIndex: 88358; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_30(object P0, LogicQualityLevel P1, LogicQualityLevel P2); // TypeDefIndex: 88359; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_31(object P0, in EventData<LogicQualityLevel, LogicQualityLevel> P1); // TypeDefIndex: 88360; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_32(object P0, ThermalState P1, ThermalState P2); // TypeDefIndex: 88361; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_33(object P0, in EventData<ThermalState, ThermalState> P1); // TypeDefIndex: 88362; 0x00000001859B7730-0x00000001859B7740

	public delegate System.Type __HotPatchDelegate_34(object P0, object P1); // TypeDefIndex: 88363; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_35(object P0, object P1, int P2); // TypeDefIndex: 88364; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_36(object P0, Beyond.GameSetting.GameSettingVideoQuality P1); // TypeDefIndex: 88365; 0x00000001859B7730-0x00000001859B7740

	public delegate Beyond.GameSetting.GameSettingVideoQuality __HotPatchDelegate_37(object P0); // TypeDefIndex: 88366; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_38(); // TypeDefIndex: 88367; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_39(object P0, object P1); // TypeDefIndex: 88368; 0x00000001859B7730-0x00000001859B7740

	public delegate QualityTierType __HotPatchDelegate_40(object P0, object P1); // TypeDefIndex: 88369; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_41(object P0, float P1); // TypeDefIndex: 88370; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_42(object P0, object P1, float P2); // TypeDefIndex: 88371; 0x000000018124EAD0-0x000000018124EAF0

	public delegate Vector2 __HotPatchDelegate_43(object P0); // TypeDefIndex: 88372; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_44(object P0); // TypeDefIndex: 88373; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Vector3 __HotPatchDelegate_45(object P0, object P1); // TypeDefIndex: 88374; 0x0000000186AEB300-0x0000000186AEB340

	public delegate bool __HotPatchDelegate_46(object P0, object P1, object P2, object P3); // TypeDefIndex: 88375; 0x00000001811CDB70-0x00000001811CDB90

	public delegate ValueTuple<float, float> __HotPatchDelegate_47(object P0, object P1); // TypeDefIndex: 88376; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_48(object P0, object P1); // TypeDefIndex: 88377; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_49(object P0, object P1, out int P2, out int P3); // TypeDefIndex: 88378; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_50(object P0, object P1, int P2); // TypeDefIndex: 88379; 0x00000001811DF7F0-0x00000001811DF810

	public delegate byte[] __HotPatchDelegate_51(object P0); // TypeDefIndex: 88380; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate JsonSerializerSettings __HotPatchDelegate_52(); // TypeDefIndex: 88381; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_53(object P0, StreamingContext P1); // TypeDefIndex: 88382; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate int __HotPatchDelegate_54(FrameRateQuality.FrameRateQualityEnum P0); // TypeDefIndex: 88383; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_55(int P0, HgFrameRateControl.ReasonEnum P1); // TypeDefIndex: 88384; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_56(); // TypeDefIndex: 88385; 0x0000000185B44B70-0x0000000185B44B80

	public delegate int __HotPatchDelegate_57(FrameRateQualityMobile.FrameRateQualityMobileEnum P0); // TypeDefIndex: 88386; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_58(ref float P0, float P1); // TypeDefIndex: 88387; 0x00000001859B7730-0x00000001859B7740
}
