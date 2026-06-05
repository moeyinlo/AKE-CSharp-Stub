/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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

// Image 56: RuntimeQuality.dll - Assembly: RuntimeQuality, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58605-58696

namespace Beyond.Gameplay.BeyondPerformance
{
	public enum LogicQualityLevel : byte // TypeDefIndex: 58613
	{
		Economy = 0,
		Balanced = 1,
		Performance = 2,
		Max = 3
	}

	public enum ThermalState : byte // TypeDefIndex: 58614
	{
		GameNormal = 0,
		GameFair = 1,
		GameSerious = 2
	}

	public static class LogicQualityConst // TypeDefIndex: 58615
	{
		// Fields
		public static float s_reduceQualityLevelFPSThresholdRatio; // 0x00
		public static float s_recoverQualityLevelFPSThresholdRatio; // 0x04
	
		// Constructors
		static LogicQualityConst() {} // 0x0000000185F8B370-0x0000000185F8B3C0
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_RuntimeQuality // TypeDefIndex: 58612
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		private static void InitializeAtRuntime() {} // 0x0000000185F05AB0-0x0000000185F05AE0
		private static void Initialize() {} // 0x0000000185F05AE0-0x0000000185F05B60
	}
}

namespace Beyond.Scripts.Quality
{
	public class DeviceInfo // TypeDefIndex: 58617
	{
		// Fields
		public RuntimePlatform m_platform; // 0x10
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
		private const string ADRENO_KEY = "Adreno"; // Metadata: 0x0207F8F9
		private const string ADRENO_PATTERN = "Adreno\\D*(?<Model>\\d+)\\W*(?<Extra>l?)"; // Metadata: 0x0207F900
		private const string ADRENO_STANDARD_FORMAT = "Adreno {0}{1}"; // Metadata: 0x0207F926
		private const string MALI_KEY = "Mali"; // Metadata: 0x0207F934
		private const string MALI_PATTERN = "Mali[-|\\s](?<Prefix>[A-Za-z]?)(?<Model>\\d+)\\W*(?<Rare>(3EE|Immortalis|Ultra)?)\\W*(?<CoreType>(MC|MP)?)\\W*(?<CoreCount>\\d*)"; // Metadata: 0x0207F939
		private const string MALI_STANDARD_FORMAT = "Mali-{0}{1}{2}{3}{4}"; // Metadata: 0x0207F9B5
		private const string POWER_VR_KEY = "PowerVR"; // Metadata: 0x0207F9CA
		private const string POWER_VR_PATTERN = "PowerVR[-|\\s](?<Prefix>[A-Za-z]*)(?<Model>\\d+)"; // Metadata: 0x0207F9D2
		private const string POWER_VR_STANDARD_FORMAT = "PowerVR {0}{1}"; // Metadata: 0x0207FA01
		private const string NVIDIA_KEY = "(NVIDIA|GTX|RTX|Quadro|GeForce)"; // Metadata: 0x0207FA10
		private const string NVIDIA_PATTERN = "(?<Prefix>RTX|GTX)\\s+(?![A-Z])(?<Model>\\d+)\\W*(?<Extra>\\w+)?"; // Metadata: 0x0207FA30
		private const string NVIDIA_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x0207FA6D
		private const string TITAN_PATTERN = "(?<Prefix>RTX|GTX)?\\D*(?<Model>TITAN)\\W*(?<Extra>\\w+)?"; // Metadata: 0x0207FA75
		private const string NVIDIA_FALLBACK = "\\bNVIDIA\\b[\\s:-]*(?<rest>.+)$"; // Metadata: 0x0207FAAC
		private const string AMD_KEY = "(AMD|ATI|Radeon)"; // Metadata: 0x0207FACA
		private const string AMD_PATTERN = "Radeon\\s?(\\(TM\\))?\\s?(?<Prefix>R9|RX|HD)?\\W*(?<Model>\\d+)?\\W*(?<Extra>\\w+)?"; // Metadata: 0x0207FADB
		private const string AMD_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x0207FB28
		private const string AMD_FALLBACK = "\\bAMD\\b[\\s:-]*(?<rest>.+)$"; // Metadata: 0x0207FB30
		private const string INTEL_KEY = "Intel"; // Metadata: 0x0207FB4B
		private const string INTEL_PATTERN = "Intel\\S+[-|\\s](?<Model>Arc)\\S+[-|\\s](?<Extra>[A-Za-z]\\d+)?"; // Metadata: 0x0207FB51
		private const string INTEL_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x0207FB8C
		private const string INTEL_PATTERN_2 = "Intel\\S+[-|\\s](?<Model>HD)[-|\\s](?<Extra>Graphics)"; // Metadata: 0x0207FB94
		private const string INTEL_FALLBACK = "Intel\\s*(?:\\(R\\)\\s*)?(?<rest>.+)$"; // Metadata: 0x0207FBC7
	
		// Properties
		public int DevicesScore { get; private set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public static string cpuName { get => default; } // 0x000000018646D4CC-0x000000018646D4D8 
	
		// Nested types
		public enum MatchType // TypeDefIndex: 58616
		{
			WhiteList = 0,
			SystemVersion = 1,
			GPU = 2,
			CPU = 3,
			DefaultScore = 4,
			MemoryCorrection = 5
		}
	
		// Constructors
		public DeviceInfo() {} // Dummy constructor
		public DeviceInfo(string remoteJson = null) {} // 0x0000000184A18AB0-0x0000000184A19530
		public DeviceInfo(RuntimePlatform platform, string deviceName, string deviceModel, string graphicsDeviceName, string graphicsDeviceVersion, string systemMemorySize, string processorName, string processorCount, string processorFrequency) {} // 0x000000018B784B40-0x000000018B784BD8
	
		// Methods
		public void SupplementFromRemote(string json) {} // 0x0000000184A1B3D0-0x0000000184A1B480
		public sealed override string ToString() => default; // 0x00000001856F5820-0x00000001856F5BC0
		public bool IsNoMatchDevice() => default; // 0x000000018B7842B4-0x000000018B784310
		public bool IsZeroDevices() => default; // 0x0000000185D631B0-0x0000000185D631E0
		public bool IsHUAWEIDevice() => default; // 0x000000018B7841F8-0x000000018B7842B4
		public bool IsQualcommDevice() => default; // 0x000000018B784310-0x000000018B784394
		public DeviceMatchRules LoadingSettingRules() => default; // 0x0000000184A1AE70-0x0000000184A1AF00
		public int GetDeviceScore(string remoteJson = null) => default; // 0x0000000184A19C10-0x0000000184A1AE70
		public int EditorSimulateGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018B7833C4-0x000000018B7834B0
		public int IOSGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018B783EB8-0x000000018B7841F8
		public int AndroidGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018B7831C8-0x000000018B783370
		public int StandaloneGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x0000000184A1AF00-0x0000000184A1B3A0
		public int StandaloneOSXGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018B784870-0x000000018B7848C4
		public int CloudGameGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x0000000183EAA160-0x0000000183EAA7F0
		public int StandalonePS5GetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018B7848C4-0x000000018B784974
		public int DefaultGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018B783370-0x000000018B7833C4
		public bool RuleSuffixMatch(List<RankingRule> list, string name, ref RankingRule matchedRule) => default; // 0x0000000184A1C290-0x0000000184A1C920
		public static bool RuleFullNameMatch(List<RankingRule> list, string name, ref RankingRule matchedRule) => default; // 0x000000018B784690-0x000000018B784870
		public bool MatchDeviceModeRule(List<RankingRule> list, string deviceModel, ref RankingRule rule) => default; // 0x000000018B784394-0x000000018B78443C
		public bool MatchGPURule(DeviceMatchRules rules, string gpu, ref RankingRule rule, out string standardName) {
			standardName = default;
			return default;
		} // 0x000000018B78443C-0x000000018B784690
		private bool StandaloneMatchGPURule(DeviceMatchRules rules, string gpu, ref RankingRule rule, out string standardName) {
			standardName = default;
			return default;
		} // 0x0000000184A1B480-0x0000000184A1B600
		private string GetNvidiaStandardGPUName(string gpu) => default; // 0x000000018B783B34-0x000000018B783D7C
		private string GetAmdStandardGPUName(string gpu) => default; // 0x0000000184A1B600-0x0000000184A1B7D0
		private string GetIntelStandardGPUName(string gpu) => default; // 0x000000018B7835EC-0x000000018B78384C
		private string GetAdrenoStandardGPUName(string gpu) => default; // 0x000000018B7834B0-0x000000018B7835EC
		private string GetMaliStandardGPUName(string gpu) => default; // 0x000000018B78384C-0x000000018B783B34
		private string GetPowerVRStandardGPUName(string gpu) => default; // 0x000000018B783D7C-0x000000018B783EB8
		private static void _ReportMatchRuleFailed(DeviceInfo deviceModel) {} // 0x000000018B784974-0x000000018B784B40
		public string __iFixBaseProxy_ToString() => default; // 0x000000018765AF34-0x000000018765AF3C
	}

	[Serializable]
	public struct RankingRule : IEquatable<RankingRule> // TypeDefIndex: 58618
	{
		// Fields
		public string regexPattern; // 0x00
		public int targetScore; // 0x08
	
		// Methods
		public bool Equals(RankingRule other) => default; // 0x0000000184F16190-0x0000000184F161E0
		public override string ToString() => default; // 0x00000001856F5D50-0x00000001856F5DE0
		public string __iFixBaseProxy_ToString() => default; // 0x000000018B78BFC8-0x000000018B78C018
	}

	[Serializable]
	public struct MemoryRule : IEquatable<MemoryRule> // TypeDefIndex: 58619
	{
		// Fields
		public Vector2 range; // 0x00
		public int targetScore; // 0x08
	
		// Methods
		public override string ToString() => default; // 0x000000018B788B68-0x000000018B788C34
		public bool Equals(MemoryRule other) => default; // 0x000000018B788AF8-0x000000018B788B68
		public string __iFixBaseProxy_ToString() => default; // 0x000000018B788C34-0x000000018B788C8C
	}

	public static class ListUtils // TypeDefIndex: 58620
	{
		// Methods
		public static void AddOrReplace<TItem>(List<TItem> source, List<TItem> remote)
			where TItem : IEquatable<TItem> {}
	}

	public class DeviceMatchRules // TypeDefIndex: 58621
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
		public DeviceMatchRules() {} // 0x0000000185F82B10-0x0000000185F82B30
	
		// Methods
		public void Combine(DeviceMatchRules other) {} // 0x0000000184A1C920-0x0000000184A1CAE0
	}

	public struct DeviceMatchResult // TypeDefIndex: 58622
	{
		// Fields
		private RankingRule m_rule; // 0x00
		private Beyond.Scripts.Quality.DeviceInfo.MatchType m_matchType; // 0x10
		private string gpuStandardName; // 0x18
	
		// Constructors
		public DeviceMatchResult(RankingRule r, Beyond.Scripts.Quality.DeviceInfo.MatchType type, string gpuStandardName) {
			m_rule = default;
			m_matchType = default;
			this.gpuStandardName = default;
		} // 0x0000000184A1B3A0-0x0000000184A1B3D0
	
		// Methods
		public override string ToString() => default; // 0x00000001856F5BC0-0x00000001856F5D50
		public bool IsNoMatch() => default; // 0x000000018B784BD8-0x000000018B784C24
		public string __iFixBaseProxy_ToString() => default; // 0x000000018B784C24-0x000000018B784C7C
	}

	[Serializable]
	public struct DeviceQualityMapItem // TypeDefIndex: 58623
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
		public override string ToString() => default; // 0x000000018B784C7C-0x000000018B784EB0
		private UnityEngine.Color getColor(int level) => default; // 0x000000018B784F14-0x000000018B784FAC
		private UnityEngine.Color getVeryLowColor() => default; // 0x000000018B78517C-0x000000018B7851F0
		private UnityEngine.Color getLowColor() => default; // 0x000000018B785020-0x000000018B785094
		private UnityEngine.Color getMiddleColor() => default; // 0x000000018B785094-0x000000018B785108
		private UnityEngine.Color getHighColor() => default; // 0x000000018B784FAC-0x000000018B785020
		private UnityEngine.Color getVeryHighColor() => default; // 0x000000018B785108-0x000000018B78517C
		public string __iFixBaseProxy_ToString() => default; // 0x000000018B784EB0-0x000000018B784F14
	}

	[Serializable]
	public class DeviceQualityMap // TypeDefIndex: 58624
	{
		// Fields
		public RuntimePlatform m_platform; // 0x10
		public List<DeviceQualityMapItem> items; // 0x18
	
		// Constructors
		public DeviceQualityMap() {} // 0x0000000185EF8710-0x0000000185EF8790
	}

	public static class QualityConst // TypeDefIndex: 58625
	{
		// Fields
		public const string SIMULATE_DEVICE_LIST = "Assets/Beyond/InitialAssets/Settings/Quality/DeviceList_zip.bytes"; // Metadata: 0x0207FBEF
		public const string SETTING_RULES = "Assets/Beyond/InitialAssets/Settings/Quality/SettingRules.json"; // Metadata: 0x0207FC32
		public const string QUALITY_MAP = "Assets/Beyond/InitialAssets/Settings/Quality/{0}_QualityMap.json"; // Metadata: 0x0207FC71
		public const string QUALITY_TIER_COMPONENTS = "Assets/Beyond/InitialAssets/Settings/Quality/{0}_QualityTierComponent.json"; // Metadata: 0x0207FCB3
	}

	public class QualityManager : Singleton<QualityManager>, IDisposable // TypeDefIndex: 58627
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
		public DeviceQualityMapItem Config { get => default; } // 0x00000001859EBF30-0x00000001859EBF70 
		public int currentTier { get => default; } // 0x000000018480A310-0x000000018480AE90 
		public int defaultTier { get => default; } // 0x0000000184F16260-0x0000000184F17330 
		public Beyond.Scripts.Quality.DeviceInfo device { get => default; } // 0x0000000185771C70-0x0000000185773FC0 
		public bool isInitializing { get => default; } // 0x000000018B78AC20-0x000000018B78AC74 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 58626
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
			static __c() {} // 0x0000000185FB9A00-0x0000000185FB9A20
			public __c() {} // 0x0000000182FB0000-0x0000000182FB0010
	
			// Methods
			internal int _LoadQualityTier_b__29_0(QualityTierLevel s) => default; // 0x000000018140C930-0x000000018140C940
			internal int _setQualityTier_b__30_0(QualityTierComponentMatch x) => default; // 0x000000018346D130-0x000000018346D140
			internal int _ApplyQualityScore_b__31_0(DeviceQualityMapItem s) => default; // 0x0000000185C2A550-0x0000000185C2A6F0
			internal int _ApplyShaderTier_b__32_0(DeviceQualityMapItem s) => default; // 0x00000001846B0CF0-0x00000001846B10D0
			internal int _GetQualityComponentDefaultTier_b__66_0(int a, int b) => default; // 0x0000000185D66B80-0x0000000185D66DE0
			internal int _GetQualityComponentTier_b__67_0(int a, int b) => default; // 0x00000001846B10D0-0x00000001846B1480
			internal int _SetQualityComponentTier_b__68_0(int a, int b) => default; // 0x0000000184F18100-0x0000000184F18140
			internal int __GetCurrentComponentTierIndex_b__70_0(QualityTierComponentMatch a, QualityTierComponentMatch b) => default; // 0x0000000184F131D0-0x0000000184F131E0
		}
	
		// Constructors
		private QualityManager() {} // 0x0000000185771440-0x0000000185771C70
		static QualityManager() {} // 0x000000018B78CAF4-0x000000018B78CB10
	
		// Methods
		public void Init(string remoteJson = null) {} // 0x000000018480D700-0x000000018480D8B0
		public void InitOnlyDevice(string remoteJson = null) {} // 0x000000018B78B164-0x000000018B78B204
		public void InitShaderLod() {} // 0x000000018B7894E4-0x000000018B789650
		public void FinishInit() {} // 0x0000000185D63170-0x0000000185D631B0
		public void Dispose() {} // 0x000000018B78AB58-0x000000018B78ABAC
		public void LoadQualityTier(string overridePlatform = null) {} // 0x000000018B78ABAC-0x000000018B78AC20
		private void setQualityTier(int qualityTier) {} // 0x000000018B78AD84-0x000000018B78ADE0
		public void ApplyQualityScore() {} // 0x0000000185EC2DB0-0x0000000185EC2EA0
		public void ApplyShaderTier() {} // 0x0000000184F10B50-0x0000000184F10BA0
		private System.Type _GetQualityComponentByName(string typeName) => default; // 0x000000018480AE90-0x000000018480B330
		public void SetQualityTierByVideoQuality(GameSetting.GameSettingVideoQuality VideoQuality) {} // 0x0000000185771210-0x0000000185771380
		public GameSetting.GameSettingVideoQuality GetDefaultVideoQuality() => default; // 0x000000018B78AFD8-0x000000018B78B164
		public bool NoMatchDeviceOrZeroScore() => default; // 0x000000018B78ADE0-0x000000018B78AFD8
		public bool IsQualcommDevice() => default; // 0x0000000184F18040-0x0000000184F18100
		public bool IsHUAWEIDevice() => default; // 0x0000000184F14EC0-0x0000000184F14F80
		public static bool IsIpadDevice() => default; // 0x0000000184F17EE0-0x0000000184F18040
		public bool IsVideoQualityEnable(GameSetting.GameSettingVideoQuality VideoQuality) => default; // 0x0000000184F173A0-0x0000000184F17460
		public void InitResetQualityTierComponentFunction(Func<System.Type, bool> func) {} // 0x0000000184F14DA0-0x0000000184F14E80
		public bool ResetQualityTierComponentValue(System.Type type) => default; // 0x0000000185BAAD30-0x0000000185BAAE70
		private QualityTierComponentMatch _SetQualityTierComponentLevel(System.Type type, int level) => default; // 0x0000000184F15A10-0x0000000184F15AF0
		public void ForceSetQualityTierComponentLevel(string type, int level) {} // 0x000000018B789650-0x000000018B789724
		public void RevertSetQualityTierComponentLevel(string type) {} // 0x0000000185C243B0-0x0000000185C24530
		public bool NeedRestart() => default; // 0x0000000184F15AF0-0x0000000184F15BD0
		public void ApplyCallBack() {} // 0x000000018B78B204-0x000000018B78B354
		private QualityTierComponentMatch _GetOverrideQualityTierComponentLevel(System.Type type) => default; // 0x000000018B78A894-0x000000018B78A9C8
		public QualityTierType GetQualityTierComponentTierType(string type) => default; // 0x000000018B78A9C8-0x000000018B78AB58
		public int GetQualityTierComponentTierVersion(string type) => default;
		private bool _IsToggleQualityTierComponent(string type) => default; // 0x0000000184F15BD0-0x0000000184F160E0
		private void _ToggleQualityTierComponentLevel(string type, int index) {} // 0x000000018B78A524-0x000000018B78A894
		public bool IsEnumQualityTierComponent(string type) => default; // 0x000000018B789724-0x000000018B789E28
		public int GetEnumQualityTierComponentCount(string type) => default; // 0x000000018B789E28-0x000000018B78A524
		public void SetEnumQualityTierComponentCount(string type, int index) {} // 0x0000000184F18140-0x0000000184F19410
		public bool IsSliderQualityTierComponent(string type) => default; // 0x000000018B78AC74-0x000000018B78AD84
		public void SetSliderQualityTierComponentCount(string type, float value) {} // 0x000000018B78B5B4-0x000000018B78BAC4
		public Vector3 GetSliderQualityTierComponent(string type) => default; // 0x000000018B78B354-0x000000018B78B5B4
		public bool InvokeQualityTierComponent(string type, string functionName, object[] parameters) => default; // 0x000000018B788EB8-0x000000018B7892E4
		public void RegisterQualityTierComponentChange<T>(System.Type tierType, Action<QualityTierComponent> cb) {} // 0x0000000184F13300-0x0000000184F14DA0
		internal void InvokeChangeCallBack(System.Type type, QualityTierComponent qualityTierComponent) {} // 0x00000001846B19A0-0x00000001846B1BE0
		public ValueTuple<float, float> GetQualityTierComponentTierCount(string type) => default; // 0x00000001846B1830-0x00000001846B19A0
		public float GetQualityComponentDefaultTier(string type) => default; // 0x0000000184F14F80-0x0000000184F15940
		public float GetQualityComponentTier(string type) => default; // 0x000000018B7892E4-0x000000018B7894E4
		public void SetQualityComponentTier(string type, float index) {} // 0x0000000185EB7760-0x0000000185EB7850
		public bool IsQualitySubSettingTierValid(string type, int tier) => default; // 0x000000018765AF34-0x000000018765AF3C
		private void _GetCurrentComponentTierIndex(QualityTierComponent qualityTierComponent, out int index, out int defaultTierIndex) {
			index = default;
			defaultTierIndex = default;
		} // 0x0000000185F76E70-0x0000000185F76ED0
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
		public string DebugQualityTierComponentInfo() => default; // 0x0000000185EDC230-0x0000000185EDC250
		private static void _ReportQuality() {} // 0x0000000185A20170-0x0000000185A20190
		private void _DynamicInitQualitySetting() {} // 0x0000000185FC1A60-0x0000000185FC1A70
		private void _DynamicReleaseQualitySetting() {} // 0x0000000185FC1A60-0x0000000185FC1A70
		internal void DynamicQualityChange(in EventData<LogicQualityLevel, LogicQualityLevel> data) {} // 0x000000018B78CAF4-0x000000018B78CB10
		internal void DynamicThermalChange(in EventData<ThermalState, ThermalState> data) {} // 0x000000018B78CAF4-0x000000018B78CB10
		public string __iFixBaseProxy_ToString() => default; // 0x000000018B78CB10-0x000000018B78CB28
	}

	public static class QualityUtility // TypeDefIndex: 58628
	{
		// Fields
		private static JsonSerializerSettings s_settings; // 0x00
	
		// Properties
		public static JsonSerializerSettings JsonSerializerSettings { get; } // 0x0000000184F17500-0x0000000184F17610 
	
		// Methods
		public static T LoadFromCompressedJson<T>() => default;
		public static T LoadingQualityJson<T>(string path)
			where T : class => default;
		public static T LoadingQualityJsonFromString<T>(string value)
			where T : class => default;
		private static byte[] Decompress(byte[] data) => default; // 0x000000018B78BD08-0x000000018B78BFC8
	}
}

namespace Beyond.Scripts.Quality.Components
{
	[Serializable]
	public class AntiAliasingQuality : EnumQualityComponent<AntiAliasingQuality.AntiAliasing> // TypeDefIndex: 58630
	{
		// Nested types
		public enum AntiAliasing // TypeDefIndex: 58629
		{
			None = 0,
			CSAA = 1,
			FXAA = 2,
			MSAA = 3
		}
	
		// Constructors
		public AntiAliasingQuality() {} // 0x000000018B782EE8-0x000000018B782F10
	
		// Methods
		protected override void Apply() {} // 0x000000018B782EA8-0x000000018B782EE8
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	public interface IEnumQualityComponent // TypeDefIndex: 58631
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
	public class EnumQualityComponent<T> : QualityTierComponent, IEnumQualityComponent, IQualityComponentExtension<T> // TypeDefIndex: 58632
		where T : Enum
	{
		// Fields
		private T enumValue;
		[NonSerialized]
		private int? m_currentValue;
		[NonSerialized]
		private string[] m_strings;
	
		// Constructors
		public EnumQualityComponent() {}
	
		// Methods
		public int GetEnumIndex(Enum enumValue) => default;
		public int GetEnumIndex() => default;
		public int GetDefaultEnumIndex() => default;
		public int GetEnumCount() => default;
		public void SetEnumIndex(int value) {}
		public string GetEnumName(int index) => default;
		public void SetEnum(T value) {}
		public T GetValue() => default;
		public T GetDefaultValue() => default;
		public void SetEnumWithOutApply(T value) {}
	}

	public enum QualityTierType // TypeDefIndex: 58633
	{
		Quality = 0,
		ToggleQuality = 1,
		EnumQuality = 2,
		SliderQuality = 3
	}

	public interface IQualityComponentExtension<T> // TypeDefIndex: 58634
	{
		// Methods
		T GetValue();
		T GetDefaultValue();
	}

	[Serializable]
	public abstract class QualityTierComponent // TypeDefIndex: 58635
	{
		// Fields
		public static Action<string, int> s_removeRegisterKeyAction; // 0x00
		internal bool isNeedStartDirty; // 0x10
	
		// Constructors
		protected QualityTierComponent() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected virtual void Apply() {} // 0x0000000185D5C830-0x0000000185D5C860
		protected virtual void InitApply() {} // 0x0000000184F17360-0x0000000184F173A0
		protected virtual void LowMemory() {} // 0x000000018B78BBA0-0x000000018B78BBE0
		protected virtual void DynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last) {} // 0x0000000184F14E80-0x0000000184F14EC0
		protected virtual void DynamicThermalChange(ThermalState current, ThermalState last) {} // 0x000000018B78BB3C-0x000000018B78BBA0
		public virtual int Version() => default; // 0x0000000184F17460-0x0000000184F17490
		public virtual bool TierLimit() => default; // 0x000000018B78BCC0-0x000000018B78BD08
		internal virtual int ApplyOrder() => default; // 0x0000000184F17330-0x0000000184F17360
		internal void RemoveQualitySettingSaveValue(string settingId) {} // 0x000000018B78BBE0-0x000000018B78BCC0
		internal void SafeApply() {} // 0x0000000184F131E0-0x0000000184F13300
		internal void RemoveRegisterKey() {} // 0x0000000185C31940-0x0000000185C319F0
		internal void SafeLowMemory(bool init = false /* Metadata: 0x0207FD07 */) {} // 0x0000000184F161E0-0x0000000184F16260
		internal void CallDynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last) {} // 0x0000000184F15940-0x0000000184F159A0
		internal virtual void CallDynamicThermalChange(ThermalState current, ThermalState last) {} // 0x000000018B78BAC4-0x000000018B78BB3C
	}

	public struct QualityTierComponentMatch // TypeDefIndex: 58637
	{
		// Fields
		public QualityTierComponent component; // 0x00
		public MatchSource matchSource; // 0x08
		public int matchQualityTier; // 0x0C
	
		// Nested types
		public enum MatchSource // TypeDefIndex: 58636
		{
			UpClosest = 0,
			DownClosest = 1,
			Matched = 2,
			Override = 3
		}
	}

	[Serializable]
	public class QualityTierLevel // TypeDefIndex: 58638
	{
		// Fields
		public int qualityTier; // 0x10
		public List<QualityTierComponent> qualityTierComponents; // 0x18
	
		// Constructors
		public QualityTierLevel() {} // 0x0000000185AD4B20-0x0000000185AD4BA0
	}

	[Serializable]
	public class SliderQualityComponent : QualityTierComponent // TypeDefIndex: 58639
	{
		// Fields
		private float sliderValue; // 0x18
		private float MaxSliderValue; // 0x1C
		private float MinSliderValue; // 0x20
		[NonSerialized]
		private float? m_currentSliderValue; // 0x24
	
		// Constructors
		public SliderQualityComponent() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public float GetValue() => default; // 0x0000000184F12CF0-0x0000000184F12D60
		public float GetDefaultValue() => default; // 0x0000000184F12D60-0x0000000184F12D90
		public Vector2 GetRange() => default; // 0x000000018B78C8E4-0x000000018B78C93C
		public void SetValue(float value) {} // 0x000000018B78C93C-0x000000018B78C9E8
	}

	[Serializable]
	public class ToggleQualityComponent : QualityTierComponent, IQualityComponentExtension<bool> // TypeDefIndex: 58640
	{
		// Fields
		private bool toggleVal; // 0x18
		[NonSerialized]
		private bool? m_currentValue; // 0x19
	
		// Constructors
		public ToggleQualityComponent() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x0000000184F17A00-0x0000000184F17A50
		protected virtual void Toggle(bool value) {} // 0x000000018B78CAA0-0x000000018B78CAF4
		public void ChangeToggle(int index) {} // 0x0000000185BAAE70-0x0000000185BAAEF0
		public bool GetValue() => default; // 0x0000000184F17490-0x0000000184F17500
		public bool GetDefaultValue() => default; // 0x0000000184F12D90-0x0000000184F12FA0
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class CharacterRenderFeatureQuality : QualityTierComponent // TypeDefIndex: 58641
	{
		// Fields
		public int characterSelfShadowOffLodQuality; // 0x18
		public int characterShadowTierLevel; // 0x1C
		public int characterOutlineTierLevel; // 0x20
	
		// Constructors
		public CharacterRenderFeatureQuality() {} // 0x0000000185FACD90-0x0000000185FACDB0
	
		// Methods
		protected override void Apply() {} // 0x0000000185F3B4F0-0x0000000185F3B590
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class ChromaticAberrationQuality : ToggleQualityComponent // TypeDefIndex: 58642
	{
		// Fields
		private const int ENABLE_TIER = 2000; // Metadata: 0x0207FD0C
		private const int DISABLE_TIER = 1000; // Metadata: 0x0207FD0E
	
		// Constructors
		public ChromaticAberrationQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Toggle(bool value) {} // 0x00000001856290E0-0x0000000185629170
		public void __iFixBaseProxy_Toggle(bool P0) {} // 0x000000018B782F10-0x000000018B782F18
	}

	[Serializable]
	public class DLSSFrameGenQuality : EnumQualityComponent<DLSSFrameGenQuality.DLSSFrameGenQualityEnum> // TypeDefIndex: 58644
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Nested types
		public enum DLSSFrameGenQualityEnum // TypeDefIndex: 58643
		{
			Auto = 0,
			X1 = 1,
			X2 = 2,
			X3 = 3
		}
	
		// Constructors
		public DLSSFrameGenQuality() {} // 0x0000000185FA7EA0-0x0000000185FA7ED0
	
		// Methods
		protected override void Apply() {} // 0x0000000184E74200-0x0000000184E74320
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000184FE4320-0x0000000184FE43C0
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x0000000184F10D20-0x0000000184F10DC0
		public bool ShouldShowAuto() => default; // 0x000000018B782F18-0x000000018B782F64
		public bool ShouldShowX1() => default; // 0x000000018B782F64-0x000000018B782FB0
		public bool ShouldShowX2() => default; // 0x000000018B782FB0-0x000000018B78300C
		public bool ShouldShowX3() => default; // 0x000000018B78300C-0x000000018B783068
		public bool ShouldShow() => default; // 0x000000018B783068-0x000000018B783110
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class DLSSUpscalerQuality : EnumQualityComponent<DLSSQuality> // TypeDefIndex: 58645
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public DLSSUpscalerQuality() {} // 0x0000000185FA7E70-0x0000000185FA7EA0
	
		// Methods
		protected override void Apply() {} // 0x0000000185D485C0-0x0000000185D498C0
		public bool ShouldShow() => default; // 0x000000018B783110-0x000000018B7831C8
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000184FE43C0-0x0000000184FE4460
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x0000000184F10DC0-0x0000000184F10E90
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class EnvironmentRenderingFeatureQuality : QualityTierComponent // TypeDefIndex: 58646
	{
		// Fields
		public int environmentRenderingFeatureQualityTier; // 0x18
	
		// Constructors
		public EnvironmentRenderingFeatureQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x00000001856295E0-0x0000000185629680
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class FrameGenQuality : EnumQualityComponent<FrameGenQuality.FrameGenMode> // TypeDefIndex: 58648
	{
		// Nested types
		public enum FrameGenMode // TypeDefIndex: 58647
		{
			None = 0,
			DLSS = 1
		}
	
		// Constructors
		public FrameGenQuality() {} // 0x0000000185FA7DE0-0x0000000185FA7E10
	
		// Methods
		protected override void Apply() {} // 0x0000000184F11090-0x0000000184F11230
		public bool ShouldShow() => default; // 0x000000018B7854D8-0x000000018B785528
		public bool ShouldShowDLSS() => default; // 0x000000018B785488-0x000000018B7854D8
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class FrameGenQualityMobile : ToggleQualityComponent // TypeDefIndex: 58649
	{
		// Constructors
		public FrameGenQualityMobile() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x000000018B7852A8-0x000000018B7853B4
		public bool ShouldShow() => default; // 0x000000018B7853B4-0x000000018B785480
		public void __iFixBaseProxy_Apply() {} // 0x000000018B785480-0x000000018B785488
	}

	[Serializable]
	public class FrameRateQuality : EnumQualityComponent<FrameRateQuality.FrameRateQualityEnum> // TypeDefIndex: 58651
	{
		// Properties
		private int frameRate { get => default; } // 0x000000018595B410-0x000000018595B460 
	
		// Nested types
		public enum FrameRateQualityEnum : byte // TypeDefIndex: 58650
		{
			FPS120 = 0,
			FPS60 = 1,
			FPS30 = 2
		}
	
		// Constructors
		public FrameRateQuality() {} // 0x0000000185FA7DB0-0x0000000185FA7DE0
	
		// Methods
		public static int GetFrameRateFromEnum(FrameRateQualityEnum enumValue) => default; // 0x000000018595B460-0x000000018595B4A0
		public override int Version() => default; // 0x0000000185F7E120-0x0000000185F7E150
		public bool ShouldShow() => default; // 0x000000018B785A30-0x000000018B785AD8
		protected override void Apply() {} // 0x000000018595B390-0x000000018595B410
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x000000018B7858C0-0x000000018B785A30
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000184880610-0x0000000184880790
		private bool _FPS30Enabled() => default; // 0x000000018B785AD8-0x000000018B785B24
		private bool _FPS60Enabled() => default; // 0x000000018B785B24-0x000000018B785B70
		private bool _FPSBNoLimitEnabled() => default; // 0x000000018B785B70-0x000000018B785BBC
		private bool _IsGDLSSGDisable() => default; // 0x000000018B785BBC-0x000000018B785C64
		public int __iFixBaseProxy_Version() => default; // 0x00000001882375C4-0x00000001882375CC
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	public class HgFrameRateControl // TypeDefIndex: 58653
	{
		// Fields
		public static int s_cinematicFrameRate; // 0x00
		public static Stack<ValueTuple<int, int, ReasonEnum>> s_rateStack; // 0x08
		public static Action<int, int> s_OnFrameRateChanged; // 0x10
	
		// Nested types
		public enum ReasonEnum // TypeDefIndex: 58652
		{
			Default = 0,
			Init = 1,
			Quality = 2,
			Dialog = 3,
			Cutscene = 4,
			GMCommand = 5
		}
	
		// Constructors
		public HgFrameRateControl() {} // 0x0000000185492010-0x0000000185492020
		static HgFrameRateControl() {} // 0x000000018595B2B0-0x000000018595B360
	
		// Methods
		public static int GetDefaultFrameRate() => default; // 0x000000018595B360-0x000000018595B390
		public static void Init() {} // 0x000000018595B240-0x000000018595B2B0
		public static void SetFrameRateOverrider(int frameRate, ReasonEnum reason) {} // 0x000000018B78638C-0x000000018B78647C
		public static int GetFrameRate() => default; // 0x000000018B785F44-0x000000018B785F88
		public static bool IsHighFrameRate() => default; // 0x000000018B7860BC-0x000000018B7860E0
		public static int RecommendedDefaultFrameRate() => default; // 0x000000018B7860E0-0x000000018B786214
		public static int GetUserSettingFrameRate() => default; // 0x000000018B785F88-0x000000018B7860BC
		public static void __ForceSetFrameRate(int frameRate, ReasonEnum reason) {} // 0x000000018595B4A0-0x000000018595B580
		public static void ResetFrameRate() {} // 0x000000018B786214-0x000000018B78638C
	}

	[Serializable]
	public class FrameRateQualityMobile : EnumQualityComponent<FrameRateQualityMobile.FrameRateQualityMobileEnum> // TypeDefIndex: 58655
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Properties
		private int frameRate { get => default; } // 0x000000018B78587C-0x000000018B7858C0 
	
		// Nested types
		public enum FrameRateQualityMobileEnum : byte // TypeDefIndex: 58654
		{
			FPS60 = 0,
			FPS45 = 1,
			FPS30 = 2
		}
	
		// Constructors
		public FrameRateQualityMobile() {} // 0x000000018B785854-0x000000018B78587C
	
		// Methods
		public static int GetFrameRateFromEnum(FrameRateQualityMobileEnum enumValue) => default; // 0x000000018B7855B0-0x000000018B785624
		public override int Version() => default; // 0x000000018B785804-0x000000018B785854
		protected override void Apply() {} // 0x000000018B785528-0x000000018B7855B0
		protected void OnDeserialized(StreamingContext context) {} // 0x000000018B785624-0x000000018B785804
		public int __iFixBaseProxy_Version() => default; // 0x00000001882375C4-0x00000001882375CC
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class FSR3UpscalerQuality : EnumQualityComponent<FSR3Quality> // TypeDefIndex: 58656
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public FSR3UpscalerQuality() {} // 0x0000000185FA7E40-0x0000000185FA7E70
	
		// Methods
		protected override void Apply() {} // 0x0000000185D472C0-0x0000000185D485C0
		public bool ShouldShow() => default; // 0x000000018B7851F0-0x000000018B7852A8
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000184FE4460-0x0000000184FE4500
		internal void FSR3Change(QualityTierComponent qualityTierComponent) {} // 0x0000000184F10E90-0x0000000184F10F60
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class GrassSparsityQuality : QualityTierComponent // TypeDefIndex: 58657
	{
		// Fields
		public int grassSparsityQualityTier; // 0x18
	
		// Constructors
		public GrassSparsityQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x0000000185629170-0x00000001856291E0
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class HGAmbientOcclusionQuality : QualityTierComponent // TypeDefIndex: 58658
	{
		// Fields
		public int aoQualityTier; // 0x18
	
		// Constructors
		public HGAmbientOcclusionQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x0000000185629680-0x0000000185629720
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class HGAnisoLevelQuality : EnumQualityComponent<HGAnisoLevelQuality.HGAnisoLevel> // TypeDefIndex: 58660
	{
		// Nested types
		public enum HGAnisoLevel // TypeDefIndex: 58659
		{
			X1 = 1,
			X2 = 2,
			X4 = 4,
			X8 = 8
		}
	
		// Constructors
		public HGAnisoLevelQuality() {} // 0x0000000185FA7D80-0x0000000185FA7DB0
	
		// Methods
		protected override void InitApply() {} // 0x0000000185F1D160-0x0000000185F1D1C0
		protected override void Apply() {} // 0x000000018B785C64-0x000000018B785D68
		public void __iFixBaseProxy_InitApply() {} // 0x000000018B785D68-0x000000018B785D70
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class HGContactShadowQuality : ToggleQualityComponent // TypeDefIndex: 58661
	{
		// Fields
		private const int ENABLE_TIER = 2000; // Metadata: 0x0207FD26
		private const int DISABLE_TIER = 1000; // Metadata: 0x0207FD28
	
		// Constructors
		public HGContactShadowQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Toggle(bool value) {} // 0x00000001856291E0-0x0000000185629270
		public void __iFixBaseProxy_Toggle(bool P0) {} // 0x000000018B782F10-0x000000018B782F18
	}

	[Serializable]
	public class HGIrradianceVolumeQuality : QualityTierComponent // TypeDefIndex: 58662
	{
		// Constructors
		public HGIrradianceVolumeQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void LowMemory() {} // 0x000000018B785D70-0x000000018B785DB4
		public void __iFixBaseProxy_LowMemory() {} // 0x0000000187C27144-0x0000000187C2714C
	}

	[Serializable]
	public class HGLODStreamingComponent : QualityTierComponent // TypeDefIndex: 58663
	{
		// Fields
		public bool enableLODStreaming; // 0x18
	
		// Constructors
		public HGLODStreamingComponent() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x0000000185F5FC40-0x0000000185F5FC80
		protected override void LowMemory() {} // 0x000000018B785DB4-0x000000018B785EBC
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
		public void __iFixBaseProxy_LowMemory() {} // 0x0000000187C27144-0x0000000187C2714C
	}

	[Serializable]
	public class HGReflectionProbeBinningQuality : QualityTierComponent // TypeDefIndex: 58664
	{
		// Constructors
		public HGReflectionProbeBinningQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void LowMemory() {} // 0x000000018B785EBC-0x000000018B785F44
		public void __iFixBaseProxy_LowMemory() {} // 0x0000000187C27144-0x0000000187C2714C
	}

	[Serializable]
	public class HGRPTierQuality : QualityTierComponent // TypeDefIndex: 58665
	{
		// Fields
		public int HGRP_QualityTier; // 0x18
	
		// Constructors
		public HGRPTierQuality() {} // 0x0000000185FA2AE0-0x0000000185FA2AF0
	
		// Methods
		protected override void Apply() {} // 0x00000001856294D0-0x0000000185629520
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class HGScreenSpaceReflectionQuality : QualityTierComponent // TypeDefIndex: 58666
	{
		// Fields
		public int ssrQualityTier; // 0x18
	
		// Constructors
		public HGScreenSpaceReflectionQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x0000000185629270-0x00000001856292E0
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class HGShadowQuality : QualityTierComponent // TypeDefIndex: 58667
	{
		// Fields
		public int shadowQualityTier; // 0x18
	
		// Constructors
		public HGShadowQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x00000001856292E0-0x0000000185629350
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class HGTextureQuality : EnumQualityComponent<HGTextureQuality.TextureQualityEnum> // TypeDefIndex: 58669
	{
		// Properties
		private int textureQualityTier { get => default; } // 0x0000000185629400-0x0000000185629460 
	
		// Nested types
		public enum TextureQualityEnum : byte // TypeDefIndex: 58668
		{
			High = 0,
			Medium = 1,
			Low = 2
		}
	
		// Constructors
		public HGTextureQuality() {} // 0x0000000185FA7D50-0x0000000185FA7D80
	
		// Methods
		protected override void Apply() {} // 0x0000000185629350-0x0000000185629400
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class HGVolumetricCloudQuality : QualityTierComponent // TypeDefIndex: 58670
	{
		// Fields
		public int volumetricCloudQualityTier; // 0x18
	
		// Constructors
		public HGVolumetricCloudQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private int GetShaderLod() => default; // 0x0000000183EAB180-0x0000000183EAB7F0
		protected override void Apply() {} // 0x0000000183EAA7F0-0x0000000183EAB180
		public bool ShouldShowNoExLow() => default; // 0x0000000183EABEA0-0x0000000183EAC550
		public bool ShouldShowExLow() => default; // 0x0000000183EAB7F0-0x0000000183EABEA0
		public void __iFixBaseProxy_Apply() {} // 0x0000000183EAC550-0x0000000183EACBB0
	}

	[Serializable]
	public class HGVolumetricFogQuality : QualityTierComponent // TypeDefIndex: 58671
	{
		// Fields
		public int volumetricFogQualityTier; // 0x18
	
		// Constructors
		public HGVolumetricFogQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x0000000185629460-0x00000001856294D0
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class LODGroupQuality : QualityTierComponent // TypeDefIndex: 58672
	{
		// Fields
		public float lodBias; // 0x18
		public int lodOffset; // 0x1C
	
		// Constructors
		public LODGroupQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x000000018B788A9C-0x000000018B788AF8
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class PhysicsClothQuality : QualityTierComponent // TypeDefIndex: 58673
	{
		// Fields
		public bool UsePhysicCloth; // 0x18
		public bool UseCrossFrameJob; // 0x19
	
		// Constructors
		public PhysicsClothQuality() {} // 0x0000000185FD5AA0-0x0000000185FD5AB0
	
		// Methods
		protected override void Apply() {} // 0x000000018B788C8C-0x000000018B788D3C
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class PrefabInstantiateQuality : QualityTierComponent // TypeDefIndex: 58674
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
		public PrefabInstantiateQuality() {} // 0x0000000185FD5AB0-0x0000000185FD5AF0
	
		// Methods
		protected override void Apply() {} // 0x000000018B788D3C-0x000000018B788EB8
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class PreloadLoadSettingQuality : QualityTierComponent // TypeDefIndex: 58675
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
		public PreloadLoadSettingQuality() {} // 0x0000000185F7DCB0-0x0000000185F7DCF0
	
		// Methods
		protected override void Apply() {} // 0x0000000185D293D0-0x0000000185D29530
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class RayTracingQuality : ToggleQualityComponent // TypeDefIndex: 58676
	{
		// Properties
		public static bool supportsRayTracing { get => default; } // 0x0000000185C318A0-0x0000000185C318C0 
	
		// Constructors
		public RayTracingQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void InitApply() {} // 0x0000000185C31840-0x0000000185C318A0
		protected override void Apply() {} // 0x000000018B78C018-0x000000018B78C10C
		public bool ShouldShow() => default; // 0x000000018B78C10C-0x000000018B78C15C
		internal override int ApplyOrder() => default; // 0x0000000185FA79F0-0x0000000185FA7A20
		public void __iFixBaseProxy_InitApply() {} // 0x000000018B785D68-0x000000018B785D70
		public void __iFixBaseProxy_Apply() {} // 0x000000018B785480-0x000000018B785488
		public int __iFixBaseProxy_ApplyOrder() => default; // 0x000000018B78C15C-0x000000018B78C164
	}

	[Serializable]
	public class ReflexQuality : EnumQualityComponent<StreamlineReflexMode> // TypeDefIndex: 58677
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public ReflexQuality() {} // 0x0000000185FA79C0-0x0000000185FA79F0
	
		// Methods
		protected override void Apply() {} // 0x0000000184F10BA0-0x0000000184F10D20
		public bool ShouldShow() => default; // 0x000000018B78C2C4-0x000000018B78C384
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000184FE4500-0x0000000184FE45A0
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x000000018B78C164-0x000000018B78C2C4
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class RenderingScaleQualityMobile : EnumQualityComponent<RenderingScaleQualityMobile.RenderingScaleMode> // TypeDefIndex: 58679
	{
		// Properties
		public float renderingScaleFactor { get => default; } // 0x000000018B78C4B8-0x000000018B78C584 
	
		// Nested types
		public enum RenderingScaleMode // TypeDefIndex: 58678
		{
			ExHigh = 0,
			High = 1,
			Medium = 2,
			Low = 3,
			ExLow = 4
		}
	
		// Constructors
		public RenderingScaleQualityMobile() {} // 0x000000018B78C490-0x000000018B78C4B8
	
		// Methods
		protected override void Apply() {} // 0x000000018B78C384-0x000000018B78C490
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class RenderingScaleQualityPC : EnumQualityComponent<RenderingScaleQualityPC.RenderingScaleMode> // TypeDefIndex: 58681
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Properties
		public float renderingScale { get => default; } // 0x0000000184F11390-0x0000000184F113F0 
	
		// Nested types
		public enum RenderingScaleMode // TypeDefIndex: 58680
		{
			Percent100 = 0,
			Percent90 = 1,
			Percent80 = 2,
			Percent70 = 3,
			Percent60 = 4
		}
	
		// Constructors
		public RenderingScaleQualityPC() {} // 0x0000000185FA7990-0x0000000185FA79C0
	
		// Methods
		protected override void Apply() {} // 0x0000000184F11230-0x0000000184F11390
		public bool ShouldShow() => default; // 0x000000018B78C584-0x000000018B78C66C
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000184FE45A0-0x0000000184FE4640
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x0000000184F10F60-0x0000000184F11090
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class ResLoadSettingQuality : QualityTierComponent // TypeDefIndex: 58682
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
		public ResLoadSettingQuality() {} // 0x0000000185F37080-0x0000000185F370E0
	
		// Methods
		protected override void Apply() {} // 0x0000000185CA7050-0x0000000185CA71D0
		protected override void LowMemory() {} // 0x000000018B78C66C-0x000000018B78C730
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
		public void __iFixBaseProxy_LowMemory() {} // 0x0000000187C27144-0x0000000187C2714C
	}

	[Serializable]
	public class SceneDetailQuality : QualityTierComponent // TypeDefIndex: 58683
	{
		// Fields
		public int sceneDetailQualityTier; // 0x18
	
		// Constructors
		public SceneDetailQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x0000000185629720-0x00000001856297C0
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class ShaderLodQuality : QualityTierComponent // TypeDefIndex: 58685
	{
		// Fields
		public ShaderLodEnum ShaderLod; // 0x18
	
		// Nested types
		public enum ShaderLodEnum // TypeDefIndex: 58684
		{
			Mobile100 = 100,
			Mobile200 = 200,
			Mobile300 = 300,
			Mobile400 = 400,
			Mobile500 = 500,
			PC600 = 600
		}
	
		// Constructors
		public ShaderLodQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void InitApply() {} // 0x0000000185EF5920-0x0000000185EF5960
		protected override void Apply() {} // 0x000000018B78C730-0x000000018B78C800
		public void __iFixBaseProxy_InitApply() {} // 0x000000018B785D68-0x000000018B785D70
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class SharpnessQuality : SliderQualityComponent // TypeDefIndex: 58686
	{
		// Constructors
		public SharpnessQuality() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x0000000184F113F0-0x0000000184F11540
		public bool ShouldShow() => default; // 0x000000018B78C800-0x000000018B78C8E4
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class SliderTestComponent : SliderQualityComponent // TypeDefIndex: 58687
	{
		// Constructors
		public SliderTestComponent() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Apply() {} // 0x000000018B78C9E8-0x000000018B78CA2C
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class TickExclusiveQuality : QualityTierComponent // TypeDefIndex: 58688
	{
		// Fields
		public TickExclusiveMode quality; // 0x18
		private LogicQualityLevel m_currentQuality; // 0x1C
		private ThermalState m_currentThermalState; // 0x1D
	
		// Constructors
		public TickExclusiveQuality() {} // 0x0000000185FAE7C0-0x0000000185FAE7D0
	
		// Methods
		protected override void Apply() {} // 0x000000018556BB30-0x000000018556BB90
		protected override void DynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last) {} // 0x000000018556BB90-0x000000018556BBE0
		protected override void DynamicThermalChange(ThermalState current, ThermalState last) {} // 0x000000018B78CA2C-0x000000018B78CAA0
		private void _OnQualityOrThermalChanged() {} // 0x000000018556BBE0-0x000000018556BC80
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
		public void __iFixBaseProxy_DynamicQualityChange(LogicQualityLevel P0, LogicQualityLevel P1) {} // 0x0000000187F3D350-0x0000000187F3D358
		public void __iFixBaseProxy_DynamicThermalChange(ThermalState P0, ThermalState P1) {} // 0x0000000187F3D358-0x0000000187F3D360
	}

	[Serializable]
	public class UpscalerQuality : EnumQualityComponent<UpscalerQuality.UpscalerMode> // TypeDefIndex: 58690
	{
		// Nested types
		public enum UpscalerMode // TypeDefIndex: 58689
		{
			DLSS = 0,
			TAAU = 1,
			FSR3 = 2
		}
	
		// Constructors
		public UpscalerQuality() {} // 0x0000000185FA7780-0x0000000185FA77B0
	
		// Methods
		protected override void Apply() {} // 0x0000000184F11540-0x0000000184F12C30
		public bool ShouldShow() => default; // 0x000000018B78CBC8-0x000000018B78CC18
		public bool ShouldShowDLSS() => default; // 0x000000018B78CB28-0x000000018B78CB78
		public bool ShouldShowFSR3() => default; // 0x000000018B78CB78-0x000000018B78CBC8
		public override int Version() => default; // 0x0000000185FA77B0-0x0000000185FA77E0
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
		public int __iFixBaseProxy_Version() => default; // 0x00000001882375C4-0x00000001882375CC
	}

	[Serializable]
	public class VSyncQuality : QualityTierComponent // TypeDefIndex: 58691
	{
		// Fields
		public bool bVSync; // 0x18
	
		// Constructors
		public VSyncQuality() {} // 0x0000000181B75280-0x0000000181B75290
	
		// Methods
		protected override void Apply() {} // 0x000000018B78CE0C-0x000000018B78CE64
		protected void Remove() {} // 0x000000018B78CE64-0x000000018B78CEB4
		public static void Init() {} // 0x0000000185EFC4E0-0x0000000185EFC510
		public void __iFixBaseProxy_Apply() {} // 0x0000000187C2713C-0x0000000187C27144
	}

	[Serializable]
	public class VSyncQualityV2 : ToggleQualityComponent // TypeDefIndex: 58692
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x20
	
		// Constructors
		public VSyncQualityV2() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Toggle(bool value) {} // 0x0000000185BCA6C0-0x0000000185BCA7B0
		public static void Init() {} // 0x0000000185EFC510-0x0000000185EFC540
		public override int Version() => default; // 0x0000000185F7E060-0x0000000185F7E090
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000184FE4640-0x0000000184FE46E0
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x000000018B78CC18-0x000000018B78CD64
		public bool ShouldShow() => default; // 0x000000018B78CD64-0x000000018B78CE0C
		public void __iFixBaseProxy_Toggle(bool P0) {} // 0x000000018B782F10-0x000000018B782F18
		public int __iFixBaseProxy_Version() => default; // 0x00000001882375C4-0x00000001882375CC
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 58607
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 58608
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 58609
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 58610
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 58611
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 58606
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58693
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F63FA0-0x0000000185F64010
	
		// Methods
		public void __Gen_Wrap_0() {} // 0x0000000187678160-0x00000001876781FC
		public void __Gen_Wrap_1(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public string __Gen_Wrap_2(ref RankingRule P0) => default; // 0x000000018B787420-0x000000018B78757C
		public string __Gen_Wrap_3(ref DeviceMatchResult P0) => default; // 0x000000018B7879A8-0x000000018B787B14
		public string __Gen_Wrap_4(object P0) => default; // 0x000000018B788038-0x000000018B788128
		public bool __Gen_Wrap_5(ref DeviceMatchResult P0) => default; // 0x000000018B788864-0x000000018B7889AC
		public bool __Gen_Wrap_6(object P0) => default; // 0x000000018735B960-0x000000018735BA30
		public DeviceMatchRules __Gen_Wrap_7(object P0) => default; // 0x000000018B7889AC-0x000000018B788A9C
		public int __Gen_Wrap_8(object P0, object P1) => default; // 0x0000000181385520-0x00000001813858D0
		public string __Gen_Wrap_9(object P0, object P1) => default; // 0x0000000183EAE890-0x0000000183EAF2C0
		public bool __Gen_Wrap_10(object P0, object P1, object P2, ref RankingRule P3) => default; // 0x0000000183EACBB0-0x0000000183EAD870
		public bool __Gen_Wrap_11(object P0, object P1, object P2, ref RankingRule P3, out string P4) {
			P4 = default;
			return default;
		} // 0x0000000183EAD870-0x0000000183EAE890
		public void __Gen_Wrap_12(object P0) {} // 0x000000018135B620-0x000000018135B8D0
		public bool __Gen_Wrap_13(object P0, object P1, ref RankingRule P2) => default; // 0x000000018B78647C-0x000000018B7865EC
		public bool __Gen_Wrap_14(ref RankingRule P0, RankingRule P1) => default; // 0x000000018B7865EC-0x000000018B78676C
		public string __Gen_Wrap_15(ref MemoryRule P0) => default; // 0x000000018B78676C-0x000000018B7868C0
		public bool __Gen_Wrap_16(ref MemoryRule P0, MemoryRule P1) => default; // 0x000000018B7868C0-0x000000018B786A3C
		public string __Gen_Wrap_17(ref DeviceQualityMapItem P0) => default; // 0x000000018B786A3C-0x000000018B786BA8
		public UnityEngine.Color __Gen_Wrap_18(ref DeviceQualityMapItem P0, int P1) => default; // 0x000000018B786BA8-0x000000018B786D4C
		public UnityEngine.Color __Gen_Wrap_19(ref DeviceQualityMapItem P0) => default; // 0x000000018B786D4C-0x000000018B786ED4
		public int __Gen_Wrap_20(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public int __Gen_Wrap_21(QualityTierLevel P0) => default; // 0x000000018767917C-0x0000000187679238
		public int __Gen_Wrap_22(DeviceQualityMapItem P0) => default; // 0x000000018B786ED4-0x000000018B786FD8
		public QualityTierComponentMatch __Gen_Wrap_23(object P0, object P1, int P2) => default; // 0x000000018B786FD8-0x000000018B787110
		public int __Gen_Wrap_24(QualityTierComponentMatch P0) => default; // 0x000000018B787110-0x000000018B787200
		public void __Gen_Wrap_25(object P0, object P1, object P2) {} // 0x0000000187340E48-0x0000000187340F40
		public void __Gen_Wrap_26(object P0, bool P1) {} // 0x0000000187678A10-0x0000000187678AEC
		public QualityTierComponentMatch __Gen_Wrap_27(object P0, object P1) => default; // 0x000000018B787200-0x000000018B787328
		public void __Gen_Wrap_28(object P0, int P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public void __Gen_Wrap_29(object P0, LogicQualityLevel P1, LogicQualityLevel P2) {} // 0x000000018B787328-0x000000018B787420
		public void __Gen_Wrap_30(object P0, in EventData<LogicQualityLevel, LogicQualityLevel> P1) {} // 0x000000018B78757C-0x000000018B7876A0
		public void __Gen_Wrap_31(object P0, ThermalState P1, ThermalState P2) {} // 0x000000018B7876A0-0x000000018B787784
		public void __Gen_Wrap_32(object P0, in EventData<ThermalState, ThermalState> P1) {} // 0x000000018B787784-0x000000018B78789C
		public System.Type __Gen_Wrap_33(object P0, object P1) => default; // 0x000000018B78789C-0x000000018B7879A8
		public void __Gen_Wrap_34(object P0, object P1, int P2) {} // 0x00000001876A23EC-0x00000001876A24E4
		public void __Gen_Wrap_35(object P0, GameSetting.GameSettingVideoQuality P1) {} // 0x000000018A80A9F8-0x000000018A80AAC0
		public GameSetting.GameSettingVideoQuality __Gen_Wrap_36(object P0) => default; // 0x000000018767917C-0x0000000187679238
		public bool __Gen_Wrap_37() => default; // 0x0000000187352600-0x0000000187352698
		public bool __Gen_Wrap_38(object P0, object P1) => default; // 0x0000000187342174-0x0000000187342260
		public QualityTierType __Gen_Wrap_39(object P0, object P1) => default; // 0x00000001876A48A4-0x00000001876A4990
		public void __Gen_Wrap_40(object P0, float P1) {} // 0x0000000187678884-0x0000000187678964
		public void __Gen_Wrap_41(object P0, object P1, float P2) {} // 0x0000000188011018-0x0000000188011114
		public Vector2 __Gen_Wrap_42(object P0) => default; // 0x000000018B787B14-0x000000018B787BF0
		public float __Gen_Wrap_43(object P0) => default; // 0x00000001876AC634-0x00000001876AC704
		public Vector3 __Gen_Wrap_44(object P0, object P1) => default; // 0x000000018B787BF0-0x000000018B787D10
		public bool __Gen_Wrap_45(object P0, object P1, object P2, object P3) => default; // 0x000000018B787D10-0x000000018B787E18
		public ValueTuple<float, float> __Gen_Wrap_46(object P0, object P1) => default; // 0x000000018B787E18-0x000000018B787F10
		public int __Gen_Wrap_47(int P0, int P1) => default; // 0x000000018A831F10-0x000000018A831FE4
		public float __Gen_Wrap_48(object P0, object P1) => default; // 0x00000001876AC704-0x00000001876AC7F0
		public int __Gen_Wrap_49(QualityTierComponentMatch P0, QualityTierComponentMatch P1) => default; // 0x000000018B787F10-0x000000018B788038
		public void __Gen_Wrap_50(object P0, object P1, out int P2, out int P3) {
			P2 = default;
			P3 = default;
		} // 0x000000018B788128-0x000000018B788264
		public bool __Gen_Wrap_51(object P0, object P1, int P2) => default; // 0x000000018B788264-0x000000018B788358
		public byte[] __Gen_Wrap_52(object P0) => default; // 0x000000018B788358-0x000000018B788434
		public JsonSerializerSettings __Gen_Wrap_53() => default; // 0x000000018B788434-0x000000018B788500
		public void __Gen_Wrap_54(object P0, StreamingContext P1) {} // 0x000000018B788500-0x000000018B788600
		public int __Gen_Wrap_55(FrameRateQuality.FrameRateQualityEnum P0) => default; // 0x000000018B788600-0x000000018B7886D0
		public void __Gen_Wrap_56(int P0, HgFrameRateControl.ReasonEnum P1) {} // 0x000000018B7886D0-0x000000018B7887A8
		public int __Gen_Wrap_57() => default; // 0x0000000187352750-0x00000001873527E8
		public int __Gen_Wrap_58(FrameRateQualityMobile.FrameRateQualityMobileEnum P0) => default; // 0x000000018B7887A8-0x000000018B788864
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 58694
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018B78CEB4-0x000000018B78CF48
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 58695
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018B78D130-0x000000018B78D194
		public static bool IsPatched(int id) => default; // 0x0000000184F159A0-0x0000000184F15A10
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018B78CFEC-0x000000018B78D0B8
		public object CreateWrapper(int id) => default; // 0x000000018B78D0B8-0x000000018B78D130
		public object InitWrapperArray(int len) => default; // 0x000000018B78D194-0x000000018B78D220
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018B78CF48-0x000000018B78CFEC
	}

	public enum IDMAP0 // TypeDefIndex: 58696
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
		Beyond-Scripts-Quality-DeviceInfo-IsHUAWEIDevice0 = 11,
		Beyond-Scripts-Quality-DeviceInfo-IsQualcommDevice0 = 12,
		Beyond-Scripts-Quality-DeviceInfo-LoadingSettingRules0 = 13,
		Beyond-Scripts-Quality-DeviceInfo-GetDeviceScore0 = 14,
		Beyond-Scripts-Quality-DeviceInfo-CloudGameGetMatchedRule0 = 15,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneGetMatchedRule0 = 16,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneMatchGPURule0 = 17,
		Beyond-Scripts-Quality-DeviceInfo-GetNvidiaStandardGPUName0 = 18,
		Beyond-Scripts-Quality-DeviceInfo-RuleSuffixMatch0 = 19,
		Beyond-Scripts-Quality-DeviceInfo-GetAmdStandardGPUName0 = 20,
		Beyond-Scripts-Quality-DeviceInfo-GetIntelStandardGPUName0 = 21,
		Beyond-Scripts-Quality-DeviceInfo-_ReportMatchRuleFailed0 = 22,
		Beyond-Scripts-Quality-DeviceInfo-EditorSimulateGetMatchedRule0 = 23,
		Beyond-Scripts-Quality-DeviceInfo-AndroidGetMatchedRule0 = 24,
		Beyond-Scripts-Quality-DeviceInfo-MatchDeviceModeRule0 = 25,
		Beyond-Scripts-Quality-DeviceInfo-RuleFullNameMatch0 = 26,
		Beyond-Scripts-Quality-DeviceInfo-MatchGPURule0 = 27,
		Beyond-Scripts-Quality-DeviceInfo-GetAdrenoStandardGPUName0 = 28,
		Beyond-Scripts-Quality-DeviceInfo-GetMaliStandardGPUName0 = 29,
		Beyond-Scripts-Quality-DeviceInfo-IOSGetMatchedRule0 = 30,
		Beyond-Scripts-Quality-DeviceInfo-DefaultGetMatchedRule0 = 31,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneOSXGetMatchedRule0 = 32,
		Beyond-Scripts-Quality-DeviceInfo-StandalonePS5GetMatchedRule0 = 33,
		Beyond-Scripts-Quality-DeviceInfo-GetPowerVRStandardGPUName0 = 34,
		Beyond-Scripts-Quality-RankingRule-Equals0 = 35,
		Beyond-Scripts-Quality-MemoryRule-ToString0 = 36,
		Beyond-Scripts-Quality-MemoryRule-Equals0 = 37,
		Beyond-Scripts-Quality-DeviceQualityMapItem-ToString0 = 38,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getColor0 = 39,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryLowColor0 = 40,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getLowColor0 = 41,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getMiddleColor0 = 42,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getHighColor0 = 43,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryHighColor0 = 44,
		Beyond-Scripts-Quality-QualityManager-Init0 = 45,
		Beyond-Scripts-Quality-QualityManager-LoadQualityTier0 = 46,
		Beyond-Scripts-Quality-Components-QualityTierComponent-ApplyOrder0 = 51,
		Beyond-Scripts-Quality-QualityManager-ApplyQualityScore0 = 58,
		Beyond-Scripts-Quality-QualityManager-setQualityTier0 = 59,
		Beyond-Scripts-Quality-QualityManager-_SetQualityTierComponentLevel0 = 60,
		Beyond-Scripts-Quality-Components-QualityTierComponent-SafeApply0 = 61,
		Beyond-Scripts-Quality-Components-QualityTierComponent-InitApply0 = 62,
		Beyond-Scripts-Quality-Components-QualityTierComponent-Apply0 = 63,
		Beyond-Scripts-Quality-Components-QualityTierComponent-LowMemory0 = 64,
		Beyond-Scripts-Quality-QualityManager-InvokeChangeCallBack0 = 65,
		Beyond-Scripts-Quality-Components-QualityTierComponent-SafeLowMemory0 = 66,
		Beyond-Scripts-Quality-QualityManager-ApplyCallBack0 = 67,
		Beyond-Scripts-Quality-QualityManager-_GetOverrideQualityTierComponentLevel0 = 68,
		Beyond-Scripts-Quality-QualityManager-_DynamicInitQualitySetting0 = 69,
		Beyond-Scripts-Quality-QualityManager-DynamicQualityChange0 = 70,
		Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicQualityChange0 = 71,
		Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicQualityChange0 = 72,
		Beyond-Scripts-Quality-QualityManager-DynamicThermalChange0 = 73,
		Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicThermalChange0 = 74,
		Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicThermalChange0 = 75,
		Beyond-Scripts-Quality-QualityManager-InitOnlyDevice0 = 76,
		Beyond-Scripts-Quality-QualityManager-InitShaderLod0 = 77,
		Beyond-Scripts-Quality-QualityManager-ApplyShaderTier0 = 78,
		Beyond-Scripts-Quality-QualityManager-ForceSetQualityTierComponentLevel0 = 79,
		Beyond-Scripts-Quality-QualityManager-_GetQualityComponentByName0 = 80,
		Beyond-Scripts-Quality-QualityManager-FinishInit0 = 81,
		Beyond-Scripts-Quality-QualityManager-Dispose0 = 82,
		Beyond-Scripts-Quality-QualityManager-_DynamicReleaseQualitySetting0 = 83,
		Beyond-Scripts-Quality-QualityManager-SetQualityTierByVideoQuality0 = 84,
		Beyond-Scripts-Quality-QualityManager-GetDefaultVideoQuality0 = 85,
		Beyond-Scripts-Quality-QualityManager-NoMatchDeviceOrZeroScore0 = 86,
		Beyond-Scripts-Quality-QualityManager-IsQualcommDevice0 = 87,
		Beyond-Scripts-Quality-QualityManager-IsHUAWEIDevice0 = 88,
		Beyond-Scripts-Quality-QualityManager-IsIpadDevice0 = 89,
		Beyond-Scripts-Quality-QualityManager-InitResetQualityTierComponentFunction0 = 90,
		Beyond-Scripts-Quality-QualityManager-ResetQualityTierComponentValue0 = 91,
		Beyond-Scripts-Quality-QualityManager-RevertSetQualityTierComponentLevel0 = 92,
		Beyond-Scripts-Quality-QualityManager-NeedRestart0 = 93,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierType0 = 94,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierVersion0 = 95,
		Beyond-Scripts-Quality-Components-QualityTierComponent-Version0 = 96,
		Beyond-Scripts-Quality-QualityManager-_IsToggleQualityTierComponent0 = 97,
		Beyond-Scripts-Quality-QualityManager-_ToggleQualityTierComponentLevel0 = 98,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-ChangeToggle0 = 99,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetValue0 = 100,
		Beyond-Scripts-Quality-QualityManager-IsEnumQualityTierComponent0 = 101,
		Beyond-Scripts-Quality-QualityManager-GetEnumQualityTierComponentCount0 = 102,
		Beyond-Scripts-Quality-QualityManager-SetEnumQualityTierComponentCount0 = 103,
		Beyond-Scripts-Quality-QualityManager-IsSliderQualityTierComponent0 = 104,
		Beyond-Scripts-Quality-QualityManager-SetSliderQualityTierComponentCount0 = 105,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-SetValue0 = 106,
		Beyond-Scripts-Quality-QualityManager-GetSliderQualityTierComponent0 = 107,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetRange0 = 108,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetValue0 = 109,
		Beyond-Scripts-Quality-QualityManager-InvokeQualityTierComponent0 = 110,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierCount0 = 111,
		Beyond-Scripts-Quality-QualityManager-GetQualityComponentDefaultTier0 = 112,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetDefaultValue0 = 113,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetDefaultValue0 = 114,
		Beyond-Scripts-Quality-QualityManager-GetQualityComponentTier0 = 115,
		Beyond-Scripts-Quality-QualityManager-SetQualityComponentTier0 = 116,
		Beyond-Scripts-Quality-QualityManager-_ReportQuality0 = 117,
		Beyond-Scripts-Quality-QualityManager-IsQualitySubSettingTierValid0 = 118,
		Beyond-Scripts-Quality-Components-QualityTierComponent-TierLimit0 = 119,
		Beyond-Scripts-Quality-QualityManager-_GetCurrentComponentTierIndex0 = 120,
		Beyond-Scripts-Quality-QualityManager-ToString0 = 121,
		Beyond-Scripts-Quality-QualityManager-DebugQualityTierComponentInfo0 = 122,
		Beyond-Scripts-Quality-QualityUtility-Decompress0 = 123,
		Beyond-Scripts-Quality-QualityUtility-get_JsonSerializerSettings0 = 124,
		Beyond-Scripts-Quality-Components-AntiAliasingQuality-Apply0 = 125,
		Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveQualitySettingSaveValue0 = 126,
		Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveRegisterKey0 = 127,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-Apply0 = 128,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-Toggle0 = 129,
		Beyond-Scripts-Quality-Components-CharacterRenderFeatureQuality-Apply0 = 130,
		Beyond-Scripts-Quality-Components-ChromaticAberrationQuality-Toggle0 = 131,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-Apply0 = 132,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-OnDeserialized0 = 133,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-DlSSChange0 = 134,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowAuto0 = 135,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX10 = 136,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX20 = 137,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX30 = 138,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShow0 = 139,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-Apply0 = 140,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-ShouldShow0 = 141,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-OnDeserialized0 = 142,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-DlSSChange0 = 143,
		Beyond-Scripts-Quality-Components-EnvironmentRenderingFeatureQuality-Apply0 = 144,
		Beyond-Scripts-Quality-Components-FrameGenQuality-Apply0 = 145,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShow0 = 146,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowDLSS0 = 147,
		Beyond-Scripts-Quality-Components-FrameGenQualityMobile-Apply0 = 148,
		Beyond-Scripts-Quality-Components-FrameGenQualityMobile-ShouldShow0 = 149,
		Beyond-Scripts-Quality-Components-FrameRateQuality-GetFrameRateFromEnum0 = 150,
		Beyond-Scripts-Quality-Components-FrameRateQuality-Version0 = 151,
		Beyond-Scripts-Quality-Components-FrameRateQuality-ShouldShow0 = 152,
		Beyond-Scripts-Quality-Components-FrameRateQuality-Apply0 = 153,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-__ForceSetFrameRate0 = 154,
		Beyond-Scripts-Quality-Components-FrameRateQuality-DlSSChange0 = 155,
		Beyond-Scripts-Quality-Components-FrameRateQuality-OnDeserialized0 = 156,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS30Enabled0 = 157,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS60Enabled0 = 158,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPSBNoLimitEnabled0 = 159,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_IsGDLSSGDisable0 = 160,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetDefaultFrameRate0 = 161,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-Init0 = 162,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-SetFrameRateOverrider0 = 163,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetFrameRate0 = 164,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-RecommendedDefaultFrameRate0 = 165,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetUserSettingFrameRate0 = 166,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-ResetFrameRate0 = 167,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-GetFrameRateFromEnum0 = 168,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Version0 = 169,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Apply0 = 170,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-OnDeserialized0 = 171,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-Apply0 = 172,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-ShouldShow0 = 173,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-OnDeserialized0 = 174,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-FSR3Change0 = 175,
		Beyond-Scripts-Quality-Components-GrassSparsityQuality-Apply0 = 176,
		Beyond-Scripts-Quality-Components-HGAmbientOcclusionQuality-Apply0 = 177,
		Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-InitApply0 = 178,
		Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-Apply0 = 179,
		Beyond-Scripts-Quality-Components-HGContactShadowQuality-Toggle0 = 180,
		Beyond-Scripts-Quality-Components-HGIrradianceVolumeQuality-LowMemory0 = 181,
		Beyond-Scripts-Quality-Components-HGLODStreamingComponent-Apply0 = 182,
		Beyond-Scripts-Quality-Components-HGLODStreamingComponent-LowMemory0 = 183,
		Beyond-Scripts-Quality-Components-HGReflectionProbeBinningQuality-LowMemory0 = 184,
		Beyond-Scripts-Quality-Components-HGRPTierQuality-Apply0 = 185,
		Beyond-Scripts-Quality-Components-HGScreenSpaceReflectionQuality-Apply0 = 186,
		Beyond-Scripts-Quality-Components-HGShadowQuality-Apply0 = 187,
		Beyond-Scripts-Quality-Components-HGTextureQuality-get_textureQualityTier0 = 188,
		Beyond-Scripts-Quality-Components-HGTextureQuality-Apply0 = 189,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-GetShaderLod0 = 190,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-Apply0 = 191,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-ShouldShowNoExLow0 = 192,
		Beyond-Scripts-Quality-Components-HGVolumetricCloudQuality-ShouldShowExLow0 = 193,
		Beyond-Scripts-Quality-Components-HGVolumetricFogQuality-Apply0 = 194,
		Beyond-Scripts-Quality-Components-LODGroupQuality-Apply0 = 195,
		Beyond-Scripts-Quality-Components-PhysicsClothQuality-Apply0 = 196,
		Beyond-Scripts-Quality-Components-PrefabInstantiateQuality-Apply0 = 197,
		Beyond-Scripts-Quality-Components-PreloadLoadSettingQuality-Apply0 = 198,
		Beyond-Scripts-Quality-Components-RayTracingQuality-InitApply0 = 199,
		Beyond-Scripts-Quality-Components-RayTracingQuality-Apply0 = 200,
		Beyond-Scripts-Quality-Components-RayTracingQuality-ShouldShow0 = 201,
		Beyond-Scripts-Quality-Components-RayTracingQuality-ApplyOrder0 = 202,
		Beyond-Scripts-Quality-Components-ReflexQuality-Apply0 = 203,
		Beyond-Scripts-Quality-Components-ReflexQuality-ShouldShow0 = 204,
		Beyond-Scripts-Quality-Components-ReflexQuality-OnDeserialized0 = 205,
		Beyond-Scripts-Quality-Components-ReflexQuality-DlSSChange0 = 206,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-get_renderingScaleFactor0 = 207,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-Apply0 = 208,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-get_renderingScale0 = 209,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-Apply0 = 210,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-ShouldShow0 = 211,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-OnDeserialized0 = 212,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-DlSSChange0 = 213,
		Beyond-Scripts-Quality-Components-ResLoadSettingQuality-Apply0 = 214,
		Beyond-Scripts-Quality-Components-ResLoadSettingQuality-LowMemory0 = 215,
		Beyond-Scripts-Quality-Components-SceneDetailQuality-Apply0 = 216,
		Beyond-Scripts-Quality-Components-ShaderLodQuality-InitApply0 = 217,
		Beyond-Scripts-Quality-Components-ShaderLodQuality-Apply0 = 218,
		Beyond-Scripts-Quality-Components-SharpnessQuality-Apply0 = 219,
		Beyond-Scripts-Quality-Components-SharpnessQuality-ShouldShow0 = 220,
		Beyond-Scripts-Quality-Components-SliderTestComponent-Apply0 = 221,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-Apply0 = 222,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicQualityChange0 = 223,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-_OnQualityOrThermalChanged0 = 224,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicThermalChange0 = 225,
		Beyond-Scripts-Quality-Components-UpscalerQuality-Apply0 = 226,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShow0 = 227,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowDLSS0 = 228,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowFSR30 = 229,
		Beyond-Scripts-Quality-Components-UpscalerQuality-Version0 = 230,
		Beyond-Scripts-Quality-Components-VSyncQuality-Apply0 = 231,
		Beyond-Scripts-Quality-Components-VSyncQuality-Remove0 = 232,
		Beyond-Scripts-Quality-Components-VSyncQuality-Init0 = 233,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Toggle0 = 234,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Init0 = 235,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Version0 = 236,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-OnDeserialized0 = 237,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-DlSSChange0 = 238,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-ShouldShow0 = 239
	}
}
