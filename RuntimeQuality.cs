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

// Image 57: RuntimeQuality.dll - Assembly: RuntimeQuality, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57702-57792
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Gameplay.BeyondPerformance
{
	public enum LogicQualityLevel : byte // TypeDefIndex: 57710
	{
		Economy = 0,
		Balanced = 1,
		Performance = 2,
		Max = 3
	}

	public enum ThermalState : byte // TypeDefIndex: 57711
	{
		GameNormal = 0,
		GameFair = 1,
		GameSerious = 2
	}

	public static class LogicQualityConst // TypeDefIndex: 57712
	{
		// Fields
		public static float s_reduceQualityLevelFPSThresholdRatio; // 0x00
		public static float s_recoverQualityLevelFPSThresholdRatio; // 0x04
	
		// Constructors
		static LogicQualityConst() {} // 0x0000000183D2C030-0x0000000183D2C080
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_RuntimeQuality // TypeDefIndex: 57704
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime() {} // 0x0000000183CB2BE0-0x0000000183CB2C10
		private static void Initialize() {} // 0x0000000183CB2C10-0x0000000183CB2C90
	}
}

namespace Beyond.Scripts.Quality
{
	public class DeviceInfo // TypeDefIndex: 57714
	{
		// Fields
		public RuntimePlatform m_platform; // 0x10
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
		private const string ADRENO_KEY = "Adreno"; // Metadata: 0x01FDA07A
		private const string ADRENO_PATTERN = "Adreno\\D*(?<Model>\\d+)\\W*(?<Extra>l?)"; // Metadata: 0x01FDA081
		private const string ADRENO_STANDARD_FORMAT = "Adreno {0}{1}"; // Metadata: 0x01FDA0A7
		private const string MALI_KEY = "Mali"; // Metadata: 0x01FDA0B5
		private const string MALI_PATTERN = "Mali[-|\\s](?<Prefix>[A-Za-z]?)(?<Model>\\d+)\\W*(?<Rare>(3EE|Immortalis|Ultra)?)\\W*(?<CoreType>(MC|MP)?)\\W*(?<CoreCount>\\d*)"; // Metadata: 0x01FDA0BA
		private const string MALI_STANDARD_FORMAT = "Mali-{0}{1}{2}{3}{4}"; // Metadata: 0x01FDA136
		private const string POWER_VR_KEY = "PowerVR"; // Metadata: 0x01FDA14B
		private const string POWER_VR_PATTERN = "PowerVR[-|\\s](?<Prefix>[A-Za-z]*)(?<Model>\\d+)"; // Metadata: 0x01FDA153
		private const string POWER_VR_STANDARD_FORMAT = "PowerVR {0}{1}"; // Metadata: 0x01FDA182
		private const string NVIDIA_KEY = "(NVIDIA|GTX|RTX|Quadro|GeForce)"; // Metadata: 0x01FDA191
		private const string NVIDIA_PATTERN = "(?<Prefix>RTX|GTX)\\s+(?![A-Z])(?<Model>\\d+)\\W*(?<Extra>\\w+)?"; // Metadata: 0x01FDA1B1
		private const string NVIDIA_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x01FDA1EE
		private const string TITAN_PATTERN = "(?<Prefix>RTX|GTX)?\\D*(?<Model>TITAN)\\W*(?<Extra>\\w+)?"; // Metadata: 0x01FDA1F6
		private const string NVIDIA_FALLBACK = "\\bNVIDIA\\b[\\s:-]*(?<rest>.+)$"; // Metadata: 0x01FDA22D
		private const string AMD_KEY = "(AMD|ATI|Radeon)"; // Metadata: 0x01FDA24B
		private const string AMD_PATTERN = "Radeon\\s?(\\(TM\\))?\\s?(?<Prefix>R9|RX|HD)?\\W*(?<Model>\\d+)?\\W*(?<Extra>\\w+)?"; // Metadata: 0x01FDA25C
		private const string AMD_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x01FDA2A9
		private const string AMD_FALLBACK = "\\bAMD\\b[\\s:-]*(?<rest>.+)$"; // Metadata: 0x01FDA2B1
		private const string INTEL_KEY = "Intel"; // Metadata: 0x01FDA2CC
		private const string INTEL_PATTERN = "Intel\\S+[-|\\s](?<Model>Arc)\\S+[-|\\s](?<Extra>[A-Za-z]\\d+)?"; // Metadata: 0x01FDA2D2
		private const string INTEL_STANDARD_FORMAT = "{0} {1}"; // Metadata: 0x01FDA30D
		private const string INTEL_PATTERN_2 = "Intel\\S+[-|\\s](?<Model>HD)[-|\\s](?<Extra>Graphics)"; // Metadata: 0x01FDA315
		private const string INTEL_FALLBACK = "Intel\\s*(?:\\(R\\)\\s*)?(?<rest>.+)$"; // Metadata: 0x01FDA348
	
		// Properties
		public int DevicesScore { get; private set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public static string cpuName { get => default; } // 0x0000000184273158-0x0000000184273164 
	
		// Nested types
		public enum MatchType // TypeDefIndex: 57713
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
		public DeviceInfo(string remoteJson = null) {} // 0x0000000182CDA040-0x0000000182CDA180
		public DeviceInfo(RuntimePlatform platform, string deviceName, string deviceModel, string graphicsDeviceName, string graphicsDeviceVersion, string systemMemorySize, string processorName, string processorCount, string processorFrequency) {} // 0x000000018965EAD4-0x000000018965EB6C
	
		// Methods
		public void SupplementFromRemote(string json) {} // 0x0000000182CDC4F0-0x0000000182CDC5A0
		public sealed override string ToString() => default; // 0x000000018363B2A0-0x000000018363B640
		public bool IsNoMatchDevice() => default; // 0x000000018965E248-0x000000018965E2A4
		public bool IsZeroDevices() => default; // 0x0000000183B315F0-0x0000000183B31620
		public bool IsHUAWEIDevice() => default; // 0x000000018965E18C-0x000000018965E248
		public bool IsQualcommDevice() => default; // 0x000000018965E2A4-0x000000018965E328
		public DeviceMatchRules LoadingSettingRules() => default; // 0x0000000182CDBF90-0x0000000182CDC020
		public int GetDeviceScore(string remoteJson = null) => default; // 0x0000000182CDBF20-0x0000000182CDBF90
		public int EditorSimulateGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018965D380-0x000000018965D444
		public int IOSGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018965DE4C-0x000000018965E18C
		public int AndroidGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018965D184-0x000000018965D32C
		public int StandaloneGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x0000000182CDC020-0x0000000182CDC4C0
		public int StandaloneOSXGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018965E804-0x000000018965E858
		public int StandalonePS5GetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018965E858-0x000000018965E908
		public int DefaultGetMatchedRule(DeviceInfo deviceInfo) => default; // 0x000000018965D32C-0x000000018965D380
		public bool RuleSuffixMatch(List<RankingRule> list, string name, ref RankingRule matchedRule) => default; // 0x0000000182CDCF70-0x0000000182CDD600
		public static bool RuleFullNameMatch(List<RankingRule> list, string name, ref RankingRule matchedRule) => default; // 0x000000018965E624-0x000000018965E804
		public bool MatchDeviceModeRule(List<RankingRule> list, string deviceModel, ref RankingRule rule) => default; // 0x000000018965E328-0x000000018965E3D0
		public bool MatchGPURule(DeviceMatchRules rules, string gpu, ref RankingRule rule, out string standardName) {
			standardName = default;
			return default;
		} // 0x000000018965E3D0-0x000000018965E624
		private bool StandaloneMatchGPURule(DeviceMatchRules rules, string gpu, ref RankingRule rule, out string standardName) {
			standardName = default;
			return default;
		} // 0x0000000182CDC5A0-0x0000000182CDC720
		private string GetNvidiaStandardGPUName(string gpu) => default; // 0x000000018965DAC8-0x000000018965DD10
		private string GetAmdStandardGPUName(string gpu) => default; // 0x0000000182CDC720-0x0000000182CDC8F0
		private string GetIntelStandardGPUName(string gpu) => default; // 0x000000018965D580-0x000000018965D7E0
		private string GetAdrenoStandardGPUName(string gpu) => default; // 0x000000018965D444-0x000000018965D580
		private string GetMaliStandardGPUName(string gpu) => default; // 0x000000018965D7E0-0x000000018965DAC8
		private string GetPowerVRStandardGPUName(string gpu) => default; // 0x000000018965DD10-0x000000018965DE4C
		private static void _ReportMatchRuleFailed(DeviceInfo deviceModel) {} // 0x000000018965E908-0x000000018965EAD4
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	[Serializable]
	public struct RankingRule : IEquatable<RankingRule> // TypeDefIndex: 57715
	{
		// Fields
		public string regexPattern; // 0x00
		public int targetScore; // 0x08
	
		// Methods
		public bool Equals(RankingRule other) => default; // 0x0000000182AB5050-0x0000000182AB50A0
		public override string ToString() => default; // 0x000000018363B7D0-0x000000018363B860
		public string __iFixBaseProxy_ToString() => default; // 0x0000000189665EAC-0x0000000189665EFC
	}

	[Serializable]
	public struct MemoryRule : IEquatable<MemoryRule> // TypeDefIndex: 57716
	{
		// Fields
		public Vector2 range; // 0x00
		public int targetScore; // 0x08
	
		// Methods
		public override string ToString() => default; // 0x0000000189662A4C-0x0000000189662B18
		public bool Equals(MemoryRule other) => default; // 0x00000001896629DC-0x0000000189662A4C
		public string __iFixBaseProxy_ToString() => default; // 0x0000000189662B18-0x0000000189662B70
	}

	public static class ListUtils // TypeDefIndex: 57717
	{
		// Methods
		public static void AddOrReplace<TItem>(List<TItem> source, List<TItem> remote)
			where TItem : IEquatable<TItem> {}
	}

	public class DeviceMatchRules // TypeDefIndex: 57718
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
		public DeviceMatchRules() {} // 0x0000000183D23720-0x0000000183D23740
	
		// Methods
		public void Combine(DeviceMatchRules other) {} // 0x0000000182CDD7A0-0x0000000182CDD960
	}

	public struct DeviceMatchResult // TypeDefIndex: 57719
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
		} // 0x0000000182CDC4C0-0x0000000182CDC4F0
	
		// Methods
		public override string ToString() => default; // 0x000000018363B640-0x000000018363B7D0
		public bool IsNoMatch() => default; // 0x000000018965EB6C-0x000000018965EBB8
		public string __iFixBaseProxy_ToString() => default; // 0x000000018965EBB8-0x000000018965EC10
	}

	[Serializable]
	public struct DeviceQualityMapItem // TypeDefIndex: 57720
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
		public override string ToString() => default; // 0x000000018965EC10-0x000000018965EE44
		private UnityEngine.Color getColor(int level) => default; // 0x000000018965EEA8-0x000000018965EF40
		private UnityEngine.Color getVeryLowColor() => default; // 0x000000018965F110-0x000000018965F184
		private UnityEngine.Color getLowColor() => default; // 0x000000018965EFB4-0x000000018965F028
		private UnityEngine.Color getMiddleColor() => default; // 0x000000018965F028-0x000000018965F09C
		private UnityEngine.Color getHighColor() => default; // 0x000000018965EF40-0x000000018965EFB4
		private UnityEngine.Color getVeryHighColor() => default; // 0x000000018965F09C-0x000000018965F110
		public string __iFixBaseProxy_ToString() => default; // 0x000000018965EE44-0x000000018965EEA8
	}

	[Serializable]
	public class DeviceQualityMap // TypeDefIndex: 57721
	{
		// Fields
		public RuntimePlatform m_platform; // 0x10
		public List<DeviceQualityMapItem> items; // 0x18
	
		// Constructors
		public DeviceQualityMap() {} // 0x0000000183CA7500-0x0000000183CA7580
	}

	public static class QualityConst // TypeDefIndex: 57722
	{
		// Fields
		public const string SIMULATE_DEVICE_LIST = "Assets/Beyond/InitialAssets/Settings/Quality/DeviceList_zip.bytes"; // Metadata: 0x01FDA370
		public const string SETTING_RULES = "Assets/Beyond/InitialAssets/Settings/Quality/SettingRules.json"; // Metadata: 0x01FDA3B3
		public const string QUALITY_MAP = "Assets/Beyond/InitialAssets/Settings/Quality/{0}_QualityMap.json"; // Metadata: 0x01FDA3F2
		public const string QUALITY_TIER_COMPONENTS = "Assets/Beyond/InitialAssets/Settings/Quality/{0}_QualityTierComponent.json"; // Metadata: 0x01FDA434
	}

	public class QualityManager : Singleton<QualityManager>, IDisposable // TypeDefIndex: 57724
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
		public DeviceQualityMapItem Config { get => default; } // 0x0000000183D581B0-0x0000000183D581D0 
		public int currentTier { get => default; } // 0x0000000183D4F370-0x0000000183D4F380 
		public int defaultTier { get => default; } // 0x0000000183D4EC20-0x0000000183D4EC30 
		public Beyond.Scripts.Quality.DeviceInfo device { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public bool isInitializing { get => default; } // 0x0000000182AB2090-0x0000000182AB20A0 
	
		// Constructors
		[UnityEngine.Scripting.Preserve]
		private QualityManager() {} // 0x0000000183A26670-0x0000000183A26810
		static QualityManager() {} // 0x0000000183C7A9D0-0x0000000183C7AAC0
	
		// Methods
		public void Init(string remoteJson = null) {} // 0x0000000183100CE0-0x00000001831010C0
		public void InitOnlyDevice(string remoteJson = null) {} // 0x0000000183B34E20-0x0000000183B35080
		public void InitShaderLod() {} // 0x00000001831010C0-0x0000000183101470
		public void FinishInit() {} // 0x0000000182AB7210-0x0000000182AB7250
		public void Dispose() {} // 0x0000000183103210-0x0000000183103250
		public void LoadQualityTier(string overridePlatform = null) {} // 0x000000018283C160-0x000000018283CCE0
		private void setQualityTier(int qualityTier) {} // 0x0000000182AB5120-0x0000000182AB61F0
		public void ApplyQualityScore() {} // 0x00000001830FF830-0x0000000183100280
		public void ApplyShaderTier() {} // 0x0000000183100280-0x0000000183100AB0
		private System.Type _GetQualityComponentByName(string typeName) => default; // 0x000000018283F990-0x000000018283FB40
		public void SetQualityTierByVideoQuality(GameSetting.GameSettingVideoQuality VideoQuality) {} // 0x0000000189665048-0x00000001896650E8
		public GameSetting.GameSettingVideoQuality GetDefaultVideoQuality() => default; // 0x00000001896633C8-0x0000000189663534
		public bool NoMatchDeviceOrZeroScore() => default; // 0x0000000183B315B0-0x0000000183B315F0
		[UnityEngine.Scripting.Preserve]
		public bool IsQualcommDevice() => default; // 0x0000000189664B04-0x0000000189664B58
		[UnityEngine.Scripting.Preserve]
		public bool IsHUAWEIDevice() => default; // 0x0000000189664A3C-0x0000000189664A90
		[UnityEngine.Scripting.Preserve]
		public static bool IsIpadDevice() => default; // 0x0000000189664A90-0x0000000189664B04
		public bool IsVideoQualityEnable(GameSetting.GameSettingVideoQuality VideoQuality) => default; // 0x0000000189664C68-0x0000000189664CC4
		public void InitResetQualityTierComponentFunction(Func<System.Type, bool> func) {} // 0x0000000183C84EC0-0x0000000183C84FB0
		public bool ResetQualityTierComponentValue(System.Type type) => default; // 0x0000000182AB0C60-0x0000000182AB0CE0
		private QualityTierComponentMatch _SetQualityTierComponentLevel(System.Type type, int level) => default; // 0x000000018283CCE0-0x000000018283D120
		public void ForceSetQualityTierComponentLevel(string type, int level) {} // 0x0000000183100B70-0x0000000183100CE0
		public void RevertSetQualityTierComponentLevel(string type) {} // 0x0000000189664EBC-0x0000000189665048
		public bool NeedRestart() => default; // 0x0000000189664CC4-0x0000000189664EBC
		public void ApplyCallBack() {} // 0x0000000182AB7150-0x0000000182AB7210
		private QualityTierComponentMatch _GetOverrideQualityTierComponentLevel(System.Type type) => default; // 0x0000000182AB3D80-0x0000000182AB3E40
		public QualityTierType GetQualityTierComponentTierType(string type) => default; // 0x0000000182AB6FF0-0x0000000182AB7150
		public int GetQualityTierComponentTierVersion(string type) => default; // 0x0000000182AB6260-0x0000000182AB6320
		private bool _IsToggleQualityTierComponent(string type) => default; // 0x0000000182AB3C60-0x0000000182AB3D40
		private void _ToggleQualityTierComponentLevel(string type, int index) {} // 0x00000001839C4C10-0x00000001839C4D50
		public bool IsEnumQualityTierComponent(string type) => default; // 0x0000000182AB48D0-0x0000000182AB49B0
		public int GetEnumQualityTierComponentCount(string type) => default; // 0x0000000189663534-0x0000000189663608
		public void SetEnumQualityTierComponentCount(string type, int index) {} // 0x0000000183A20110-0x0000000183A20290
		public bool IsSliderQualityTierComponent(string type) => default; // 0x0000000182AB49B0-0x0000000182AB4A90
		public void SetSliderQualityTierComponentCount(string type, float value) {} // 0x00000001896650E8-0x0000000189665238
		public Vector3 GetSliderQualityTierComponent(string type) => default; // 0x0000000189664778-0x00000001896648AC
		public bool InvokeQualityTierComponent(string type, string functionName, params object[] parameters) => default; // 0x00000001896648AC-0x0000000189664A3C
		public void RegisterQualityTierComponentChange<T>(System.Type tierType, Action<QualityTierComponent> cb) {}
		internal void InvokeChangeCallBack(System.Type type, QualityTierComponent qualityTierComponent) {} // 0x0000000182AB4A90-0x0000000182AB4FA0
		public ValueTuple<float, float> GetQualityTierComponentTierCount(string type) => default; // 0x0000000189664408-0x0000000189664778
		public float GetQualityComponentDefaultTier(string type) => default; // 0x0000000189663608-0x0000000189663D0C
		public float GetQualityComponentTier(string type) => default; // 0x0000000189663D0C-0x0000000189664408
		public void SetQualityComponentTier(string type, float index) {} // 0x00000001828F43E0-0x00000001828F56B0
		public bool IsQualitySubSettingTierValid(string type, int tier) => default; // 0x0000000189664B58-0x0000000189664C68
		private void _GetCurrentComponentTierIndex(QualityTierComponent qualityTierComponent, out int index, out int defaultTierIndex) {
			index = default;
			defaultTierIndex = default;
		} // 0x0000000189665498-0x00000001896659A8
		public override string ToString() => default; // 0x0000000189665238-0x0000000189665498
		public string DebugQualityTierComponentInfo() => default; // 0x0000000189662D9C-0x00000001896631C8
		private static void _ReportQuality() {} // 0x0000000182AB21C0-0x0000000182AB3C60
		private void _DynamicInitQualitySetting() {} // 0x0000000183102880-0x0000000183102AC0
		private void _DynamicReleaseQualitySetting() {} // 0x0000000183102710-0x0000000183102880
		internal void DynamicQualityChange([IsReadOnly] in EventData<LogicQualityLevel, LogicQualityLevel> data) {} // 0x0000000182AB3E40-0x0000000182AB4800
		internal void DynamicThermalChange([IsReadOnly] in EventData<ThermalState, ThermalState> data) {} // 0x00000001896631C8-0x00000001896633C8
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public static class QualityUtility // TypeDefIndex: 57725
	{
		// Fields
		private static JsonSerializerSettings s_settings; // 0x00
	
		// Properties
		public static JsonSerializerSettings JsonSerializerSettings { get; } // 0x0000000182AB6440-0x0000000182AB6550 
	
		// Methods
		public static T LoadFromCompressedJson<T>() => default;
		public static T LoadingQualityJson<T>(string path)
			where T : class => default;
		public static T LoadingQualityJsonFromString<T>(string value)
			where T : class => default;
		private static byte[] Decompress(byte[] data) => default; // 0x0000000189665BEC-0x0000000189665EAC
	}
}

namespace Beyond.Scripts.Quality.Components
{
	[Serializable]
	public class AntiAliasingQuality : EnumQualityComponent<AntiAliasingQuality.AntiAliasing> // TypeDefIndex: 57727
	{
		// Nested types
		public enum AntiAliasing // TypeDefIndex: 57726
		{
			None = 0,
			CSAA = 1,
			FXAA = 2,
			MSAA = 3
		}
	
		// Constructors
		public AntiAliasingQuality() {} // 0x000000018965CEA4-0x000000018965CECC
	
		// Methods
		protected override void Apply() {} // 0x000000018965CE64-0x000000018965CEA4
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	public interface IEnumQualityComponent // TypeDefIndex: 57728
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
	public class EnumQualityComponent<T> : QualityTierComponent, IEnumQualityComponent, IQualityComponentExtension<T> // TypeDefIndex: 57729
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

	public enum QualityTierType // TypeDefIndex: 57730
	{
		Quality = 0,
		ToggleQuality = 1,
		EnumQuality = 2,
		SliderQuality = 3
	}

	public interface IQualityComponentExtension<T> // TypeDefIndex: 57731
	{
		// Methods
		T GetValue();
		T GetDefaultValue();
	}

	[Serializable]
	public abstract class QualityTierComponent // TypeDefIndex: 57732
	{
		// Fields
		public static Action<string, int> s_removeRegisterKeyAction; // 0x00
		internal bool isNeedStartDirty; // 0x10
	
		// Constructors
		protected QualityTierComponent() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected virtual void Apply() {} // 0x0000000183B2EA60-0x0000000183B2EA90
		protected virtual void InitApply() {} // 0x0000000182AB6220-0x0000000182AB6260
		protected virtual void LowMemory() {} // 0x0000000189665A84-0x0000000189665AC4
		protected virtual void DynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last) {} // 0x0000000182AB3D40-0x0000000182AB3D80
		protected virtual void DynamicThermalChange(ThermalState current, ThermalState last) {} // 0x0000000189665A20-0x0000000189665A84
		public virtual int Version() => default; // 0x0000000182AB63A0-0x0000000182AB63D0
		public virtual bool TierLimit() => default; // 0x0000000189665BA4-0x0000000189665BEC
		internal virtual int ApplyOrder() => default; // 0x0000000182AB61F0-0x0000000182AB6220
		internal void RemoveQualitySettingSaveValue(string settingId) {} // 0x0000000189665AC4-0x0000000189665BA4
		internal void SafeApply() {} // 0x0000000182AB20A0-0x0000000182AB21C0
		internal void RemoveRegisterKey() {} // 0x0000000183A2D0F0-0x0000000183A2D1A0
		internal void SafeLowMemory(bool init = false /* Metadata: 0x01FDA488 */) {} // 0x0000000182AB50A0-0x0000000182AB5120
		internal void CallDynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last) {} // 0x0000000182AB4800-0x0000000182AB4860
		internal virtual void CallDynamicThermalChange(ThermalState current, ThermalState last) {} // 0x00000001896659A8-0x0000000189665A20
	}

	public struct QualityTierComponentMatch // TypeDefIndex: 57734
	{
		// Fields
		public QualityTierComponent component; // 0x00
		public MatchSource matchSource; // 0x08
		public int matchQualityTier; // 0x0C
	
		// Nested types
		public enum MatchSource // TypeDefIndex: 57733
		{
			UpClosest = 0,
			DownClosest = 1,
			Matched = 2,
			Override = 3
		}
	}

	[Serializable]
	public class QualityTierLevel // TypeDefIndex: 57735
	{
		// Fields
		public int qualityTier; // 0x10
		[HideInInspector]
		public List<QualityTierComponent> qualityTierComponents; // 0x18
	
		// Constructors
		public QualityTierLevel() {} // 0x0000000183915F20-0x0000000183915FA0
	}

	[Serializable]
	public class SliderQualityComponent : QualityTierComponent // TypeDefIndex: 57736
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
		public SliderQualityComponent() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public float GetValue() => default; // 0x0000000182AB1BB0-0x0000000182AB1C20
		public float GetDefaultValue() => default; // 0x0000000182AB1C20-0x0000000182AB1C50
		public Vector2 GetRange() => default; // 0x00000001896667C8-0x0000000189666820
		public void SetValue(float value) {} // 0x0000000189666820-0x00000001896668CC
	}

	[Serializable]
	public class ToggleQualityComponent : QualityTierComponent, IQualityComponentExtension<bool> // TypeDefIndex: 57737
	{
		// Fields
		[FormerlySerializedAs("defaultVal")]
		[JsonProperty]
		[SerializeField]
		private bool toggleVal; // 0x18
		[NonSerialized]
		private bool? m_currentValue; // 0x19
	
		// Constructors
		public ToggleQualityComponent() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x0000000182AB6B20-0x0000000182AB6B70
		protected virtual void Toggle(bool value) {} // 0x0000000189666984-0x00000001896669D8
		public void ChangeToggle(int index) {} // 0x00000001839C4D50-0x00000001839C4DD0
		public bool GetValue() => default; // 0x0000000182AB63D0-0x0000000182AB6440
		public bool GetDefaultValue() => default; // 0x0000000182AB1C50-0x0000000182AB1E60
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class CharacterRenderFeatureQuality : QualityTierComponent // TypeDefIndex: 57738
	{
		// Fields
		public int characterSelfShadowOffLodQuality; // 0x18
		public int characterShadowTierLevel; // 0x1C
		public int characterOutlineTierLevel; // 0x20
	
		// Constructors
		public CharacterRenderFeatureQuality() {} // 0x0000000183D4B940-0x0000000183D4B960
	
		// Methods
		protected override void Apply() {} // 0x0000000183CE0400-0x0000000183CE04A0
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class ChromaticAberrationQuality : ToggleQualityComponent // TypeDefIndex: 57739
	{
		// Fields
		private const int ENABLE_TIER = 2000; // Metadata: 0x01FDA48D
		private const int DISABLE_TIER = 1000; // Metadata: 0x01FDA48F
	
		// Constructors
		public ChromaticAberrationQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Toggle(bool value) {} // 0x00000001835A5650-0x00000001835A56E0
		public void __iFixBaseProxy_Toggle(bool P0) {} // 0x000000018965CECC-0x000000018965CED4
	}

	[Serializable]
	public class DLSSFrameGenQuality : EnumQualityComponent<DLSSFrameGenQuality.DLSSFrameGenQualityEnum> // TypeDefIndex: 57741
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Nested types
		public enum DLSSFrameGenQualityEnum // TypeDefIndex: 57740
		{
			Auto = 0,
			X1 = 1,
			X2 = 2,
			X3 = 3
		}
	
		// Constructors
		public DLSSFrameGenQuality() {} // 0x0000000183D47AA0-0x0000000183D47AD0
	
		// Methods
		protected override void Apply() {} // 0x0000000183B0DD70-0x0000000183B0DE90
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000182C99490-0x0000000182C99530
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x0000000182AB1070-0x0000000182AB1110
		public bool ShouldShowAuto() => default; // 0x000000018965CED4-0x000000018965CF20
		public bool ShouldShowX1() => default; // 0x000000018965CF20-0x000000018965CF6C
		public bool ShouldShowX2() => default; // 0x000000018965CF6C-0x000000018965CFC8
		public bool ShouldShowX3() => default; // 0x000000018965CFC8-0x000000018965D024
		public bool ShouldShow() => default; // 0x000000018965D024-0x000000018965D0CC
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class DLSSUpscalerQuality : EnumQualityComponent<DLSSQuality> // TypeDefIndex: 57742
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public DLSSUpscalerQuality() {} // 0x0000000183D47A70-0x0000000183D47AA0
	
		// Methods
		protected override void Apply() {} // 0x0000000183B212A0-0x0000000183B214F0
		public bool ShouldShow() => default; // 0x000000018965D0CC-0x000000018965D184
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000182C99530-0x0000000182C995D0
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x0000000182AB1110-0x0000000182AB11E0
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class EnvironmentRenderingFeatureQuality : QualityTierComponent // TypeDefIndex: 57743
	{
		// Fields
		public int environmentRenderingFeatureQualityTier; // 0x18
	
		// Constructors
		public EnvironmentRenderingFeatureQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x00000001835A5B50-0x00000001835A5BF0
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class FrameGenQuality : EnumQualityComponent<FrameGenQuality.FrameGenMode> // TypeDefIndex: 57745
	{
		// Nested types
		public enum FrameGenMode // TypeDefIndex: 57744
		{
			None = 0,
			DLSS = 1
		}
	
		// Constructors
		public FrameGenQuality() {} // 0x0000000183D479E0-0x0000000183D47A10
	
		// Methods
		protected override void Apply() {} // 0x0000000182AB13E0-0x0000000182AB1580
		public bool ShouldShow() => default; // 0x000000018965F46C-0x000000018965F4BC
		public bool ShouldShowDLSS() => default; // 0x000000018965F41C-0x000000018965F46C
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class FrameGenQualityMobile : ToggleQualityComponent // TypeDefIndex: 57746
	{
		// Constructors
		public FrameGenQualityMobile() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x000000018965F23C-0x000000018965F348
		public bool ShouldShow() => default; // 0x000000018965F348-0x000000018965F414
		public void __iFixBaseProxy_Apply() {} // 0x000000018965F414-0x000000018965F41C
	}

	[Serializable]
	public class FrameRateQuality : EnumQualityComponent<FrameRateQuality.FrameRateQualityEnum> // TypeDefIndex: 57748
	{
		// Properties
		private int frameRate { get => default; } // 0x00000001837FF410-0x00000001837FF460 
	
		// Nested types
		public enum FrameRateQualityEnum : byte // TypeDefIndex: 57747
		{
			FPS120 = 0,
			FPS60 = 1,
			FPS30 = 2
		}
	
		// Constructors
		public FrameRateQuality() {} // 0x0000000183D479B0-0x0000000183D479E0
	
		// Methods
		public static int GetFrameRateFromEnum(FrameRateQualityEnum enumValue) => default; // 0x00000001837FF460-0x00000001837FF4A0
		public override int Version() => default; // 0x0000000183D1F290-0x0000000183D1F2C0
		public bool ShouldShow() => default; // 0x000000018965F9C4-0x000000018965FA6C
		protected override void Apply() {} // 0x00000001837FF390-0x00000001837FF410
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x000000018965F854-0x000000018965F9C4
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000182C9A3E0-0x0000000182C9A560
		private bool _FPS30Enabled() => default; // 0x000000018965FA6C-0x000000018965FAB8
		private bool _FPS60Enabled() => default; // 0x000000018965FAB8-0x000000018965FB04
		private bool _FPSBNoLimitEnabled() => default; // 0x000000018965FB04-0x000000018965FB50
		private bool _IsGDLSSGDisable() => default; // 0x000000018965FB50-0x000000018965FBF8
		public int __iFixBaseProxy_Version() => default; // 0x00000001860BBCC0-0x00000001860BBCC8
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	public class HgFrameRateControl // TypeDefIndex: 57750
	{
		// Fields
		public static int s_cinematicFrameRate; // 0x00
		public static Stack<ValueTuple<int, int, ReasonEnum>> s_rateStack; // 0x08
		public static Action<int, int> s_OnFrameRateChanged; // 0x10
	
		// Nested types
		public enum ReasonEnum // TypeDefIndex: 57749
		{
			Default = 0,
			Init = 1,
			Quality = 2,
			Dialog = 3,
			Cutscene = 4,
			GMCommand = 5
		}
	
		// Constructors
		public HgFrameRateControl() {} // 0x000000018350B670-0x000000018350B680
		static HgFrameRateControl() {} // 0x00000001837FF2B0-0x00000001837FF360
	
		// Methods
		public static int GetDefaultFrameRate() => default; // 0x00000001837FF360-0x00000001837FF390
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init() {} // 0x00000001837FF240-0x00000001837FF2B0
		public static void SetFrameRateOverrider(int frameRate, ReasonEnum reason) {} // 0x0000000189660320-0x0000000189660410
		public static int GetFrameRate() => default; // 0x000000018965FED8-0x000000018965FF1C
		public static bool IsHighFrameRate() => default; // 0x0000000189660050-0x0000000189660074
		public static int RecommendedDefaultFrameRate() => default; // 0x0000000189660074-0x00000001896601A8
		public static int GetUserSettingFrameRate() => default; // 0x000000018965FF1C-0x0000000189660050
		public static void __ForceSetFrameRate(int frameRate, ReasonEnum reason) {} // 0x00000001837FF4A0-0x00000001837FF580
		public static void ResetFrameRate() {} // 0x00000001896601A8-0x0000000189660320
	}

	[Serializable]
	public class FrameRateQualityMobile : EnumQualityComponent<FrameRateQualityMobile.FrameRateQualityMobileEnum> // TypeDefIndex: 57752
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Properties
		private int frameRate { get => default; } // 0x000000018965F810-0x000000018965F854 
	
		// Nested types
		public enum FrameRateQualityMobileEnum : byte // TypeDefIndex: 57751
		{
			FPS60 = 0,
			FPS45 = 1,
			FPS30 = 2
		}
	
		// Constructors
		public FrameRateQualityMobile() {} // 0x000000018965F7E8-0x000000018965F810
	
		// Methods
		public static int GetFrameRateFromEnum(FrameRateQualityMobileEnum enumValue) => default; // 0x000000018965F544-0x000000018965F5B8
		public override int Version() => default; // 0x000000018965F798-0x000000018965F7E8
		protected override void Apply() {} // 0x000000018965F4BC-0x000000018965F544
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context) {} // 0x000000018965F5B8-0x000000018965F798
		public int __iFixBaseProxy_Version() => default; // 0x00000001860BBCC0-0x00000001860BBCC8
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class FSR3UpscalerQuality : EnumQualityComponent<FSR3Quality> // TypeDefIndex: 57753
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public FSR3UpscalerQuality() {} // 0x0000000183D47A40-0x0000000183D47A70
	
		// Methods
		protected override void Apply() {} // 0x0000000183B21160-0x0000000183B212A0
		public bool ShouldShow() => default; // 0x000000018965F184-0x000000018965F23C
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000182C995D0-0x0000000182C99670
		internal void FSR3Change(QualityTierComponent qualityTierComponent) {} // 0x0000000182AB11E0-0x0000000182AB12B0
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class GrassSparsityQuality : QualityTierComponent // TypeDefIndex: 57754
	{
		// Fields
		public int grassSparsityQualityTier; // 0x18
	
		// Constructors
		public GrassSparsityQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x00000001835A56E0-0x00000001835A5750
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class HGAmbientOcclusionQuality : QualityTierComponent // TypeDefIndex: 57755
	{
		// Fields
		public int aoQualityTier; // 0x18
	
		// Constructors
		public HGAmbientOcclusionQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x00000001835A5BF0-0x00000001835A5C90
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class HGAnisoLevelQuality : EnumQualityComponent<HGAnisoLevelQuality.HGAnisoLevel> // TypeDefIndex: 57757
	{
		// Nested types
		public enum HGAnisoLevel // TypeDefIndex: 57756
		{
			X1 = 1,
			X2 = 2,
			X4 = 4,
			X8 = 8
		}
	
		// Constructors
		public HGAnisoLevelQuality() {} // 0x0000000183D47980-0x0000000183D479B0
	
		// Methods
		protected override void InitApply() {} // 0x0000000183CC45A0-0x0000000183CC4600
		protected override void Apply() {} // 0x000000018965FBF8-0x000000018965FCFC
		public void __iFixBaseProxy_InitApply() {} // 0x000000018965FCFC-0x000000018965FD04
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class HGContactShadowQuality : ToggleQualityComponent // TypeDefIndex: 57758
	{
		// Fields
		private const int ENABLE_TIER = 2000; // Metadata: 0x01FDA4A7
		private const int DISABLE_TIER = 1000; // Metadata: 0x01FDA4A9
	
		// Constructors
		public HGContactShadowQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Toggle(bool value) {} // 0x00000001835A5750-0x00000001835A57E0
		public void __iFixBaseProxy_Toggle(bool P0) {} // 0x000000018965CECC-0x000000018965CED4
	}

	[Serializable]
	public class HGIrradianceVolumeQuality : QualityTierComponent // TypeDefIndex: 57759
	{
		// Constructors
		public HGIrradianceVolumeQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void LowMemory() {} // 0x000000018965FD04-0x000000018965FD48
		public void __iFixBaseProxy_LowMemory() {} // 0x0000000185A73D2C-0x0000000185A73D34
	}

	[Serializable]
	public class HGLODStreamingComponent : QualityTierComponent // TypeDefIndex: 57760
	{
		// Fields
		public bool enableLODStreaming; // 0x18
	
		// Constructors
		public HGLODStreamingComponent() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x0000000183D00F70-0x0000000183D00FB0
		protected override void LowMemory() {} // 0x000000018965FD48-0x000000018965FE50
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
		public void __iFixBaseProxy_LowMemory() {} // 0x0000000185A73D2C-0x0000000185A73D34
	}

	[Serializable]
	public class HGReflectionProbeBinningQuality : QualityTierComponent // TypeDefIndex: 57761
	{
		// Constructors
		public HGReflectionProbeBinningQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void LowMemory() {} // 0x000000018965FE50-0x000000018965FED8
		public void __iFixBaseProxy_LowMemory() {} // 0x0000000185A73D2C-0x0000000185A73D34
	}

	[Serializable]
	public class HGRPTierQuality : QualityTierComponent // TypeDefIndex: 57762
	{
		// Fields
		public int HGRP_QualityTier; // 0x18
	
		// Constructors
		public HGRPTierQuality() {} // 0x0000000183D42BD0-0x0000000183D42BE0
	
		// Methods
		protected override void Apply() {} // 0x00000001835A5A40-0x00000001835A5A90
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class HGScreenSpaceReflectionQuality : QualityTierComponent // TypeDefIndex: 57763
	{
		// Fields
		public int ssrQualityTier; // 0x18
	
		// Constructors
		public HGScreenSpaceReflectionQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x00000001835A57E0-0x00000001835A5850
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class HGShadowQuality : QualityTierComponent // TypeDefIndex: 57764
	{
		// Fields
		public int shadowQualityTier; // 0x18
	
		// Constructors
		public HGShadowQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x00000001835A5850-0x00000001835A58C0
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class HGTextureQuality : EnumQualityComponent<HGTextureQuality.TextureQualityEnum> // TypeDefIndex: 57766
	{
		// Properties
		private int textureQualityTier { get => default; } // 0x00000001835A5970-0x00000001835A59D0 
	
		// Nested types
		public enum TextureQualityEnum : byte // TypeDefIndex: 57765
		{
			High = 0,
			Medium = 1,
			Low = 2
		}
	
		// Constructors
		public HGTextureQuality() {} // 0x0000000183D47950-0x0000000183D47980
	
		// Methods
		protected override void Apply() {} // 0x00000001835A58C0-0x00000001835A5970
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class HGVolumetricFogQuality : QualityTierComponent // TypeDefIndex: 57767
	{
		// Fields
		public int volumetricFogQualityTier; // 0x18
	
		// Constructors
		public HGVolumetricFogQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x00000001835A59D0-0x00000001835A5A40
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class LODGroupQuality : QualityTierComponent // TypeDefIndex: 57768
	{
		// Fields
		public float lodBias; // 0x18
		public int lodOffset; // 0x1C
	
		// Constructors
		public LODGroupQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x0000000189662980-0x00000001896629DC
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class PhysicsClothQuality : QualityTierComponent // TypeDefIndex: 57769
	{
		// Fields
		public bool UsePhysicCloth; // 0x18
		public bool UseCrossFrameJob; // 0x19
	
		// Constructors
		public PhysicsClothQuality() {} // 0x0000000183D74E40-0x0000000183D74E50
	
		// Methods
		protected override void Apply() {} // 0x0000000189662B70-0x0000000189662C20
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class PrefabInstantiateQuality : QualityTierComponent // TypeDefIndex: 57770
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
		public PrefabInstantiateQuality() {} // 0x0000000183D74E50-0x0000000183D74E90
	
		// Methods
		protected override void Apply() {} // 0x0000000189662C20-0x0000000189662D9C
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class PreloadLoadSettingQuality : QualityTierComponent // TypeDefIndex: 57771
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
		public PreloadLoadSettingQuality() {} // 0x0000000183D1EDE0-0x0000000183D1EE20
	
		// Methods
		protected override void Apply() {} // 0x0000000183B122E0-0x0000000183B12440
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class RayTracingQuality : ToggleQualityComponent // TypeDefIndex: 57772
	{
		// Properties
		public static bool supportsRayTracing { get => default; } // 0x0000000183A2D050-0x0000000183A2D070 
	
		// Constructors
		public RayTracingQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void InitApply() {} // 0x0000000183A2CFF0-0x0000000183A2D050
		protected override void Apply() {} // 0x0000000189665EFC-0x0000000189665FF0
		public bool ShouldShow() => default; // 0x0000000189665FF0-0x0000000189666040
		internal override int ApplyOrder() => default; // 0x0000000183D47590-0x0000000183D475C0
		public void __iFixBaseProxy_InitApply() {} // 0x000000018965FCFC-0x000000018965FD04
		public void __iFixBaseProxy_Apply() {} // 0x000000018965F414-0x000000018965F41C
		public int __iFixBaseProxy_ApplyOrder() => default; // 0x0000000189666040-0x0000000189666048
	}

	[Serializable]
	public class ReflexQuality : EnumQualityComponent<StreamlineReflexMode> // TypeDefIndex: 57773
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Constructors
		public ReflexQuality() {} // 0x0000000183D47560-0x0000000183D47590
	
		// Methods
		protected override void Apply() {} // 0x0000000182AB0EF0-0x0000000182AB1070
		public bool ShouldShow() => default; // 0x00000001896661A8-0x0000000189666268
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000182C99670-0x0000000182C99710
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x0000000189666048-0x00000001896661A8
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class RenderingScaleQualityMobile : EnumQualityComponent<RenderingScaleQualityMobile.RenderingScaleMode> // TypeDefIndex: 57775
	{
		// Properties
		public float renderingScaleFactor { get => default; } // 0x000000018966639C-0x0000000189666468 
	
		// Nested types
		public enum RenderingScaleMode // TypeDefIndex: 57774
		{
			ExHigh = 0,
			High = 1,
			Medium = 2,
			Low = 3,
			ExLow = 4
		}
	
		// Constructors
		public RenderingScaleQualityMobile() {} // 0x0000000189666374-0x000000018966639C
	
		// Methods
		protected override void Apply() {} // 0x0000000189666268-0x0000000189666374
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class RenderingScaleQualityPC : EnumQualityComponent<RenderingScaleQualityPC.RenderingScaleMode> // TypeDefIndex: 57777
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x30
	
		// Properties
		public float renderingScale { get => default; } // 0x0000000182AB16E0-0x0000000182AB1740 
	
		// Nested types
		public enum RenderingScaleMode // TypeDefIndex: 57776
		{
			Percent100 = 0,
			Percent90 = 1,
			Percent80 = 2,
			Percent70 = 3,
			Percent60 = 4
		}
	
		// Constructors
		public RenderingScaleQualityPC() {} // 0x0000000183D47530-0x0000000183D47560
	
		// Methods
		protected override void Apply() {} // 0x0000000182AB1580-0x0000000182AB16E0
		public bool ShouldShow() => default; // 0x0000000189666468-0x0000000189666550
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000182C99710-0x0000000182C997B0
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x0000000182AB12B0-0x0000000182AB13E0
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class ResLoadSettingQuality : QualityTierComponent // TypeDefIndex: 57778
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
		public ResLoadSettingQuality() {} // 0x0000000183CDD770-0x0000000183CDD7D0
	
		// Methods
		protected override void Apply() {} // 0x0000000183A92FF0-0x0000000183A93170
		protected override void LowMemory() {} // 0x0000000189666550-0x0000000189666614
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
		public void __iFixBaseProxy_LowMemory() {} // 0x0000000185A73D2C-0x0000000185A73D34
	}

	[Serializable]
	public class SceneDetailQuality : QualityTierComponent // TypeDefIndex: 57779
	{
		// Fields
		public int sceneDetailQualityTier; // 0x18
	
		// Constructors
		public SceneDetailQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x00000001835A5C90-0x00000001835A5D30
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class ShaderLodQuality : QualityTierComponent // TypeDefIndex: 57781
	{
		// Fields
		public ShaderLodEnum ShaderLod; // 0x18
	
		// Nested types
		public enum ShaderLodEnum // TypeDefIndex: 57780
		{
			Mobile100 = 100,
			Mobile200 = 200,
			Mobile300 = 300,
			Mobile400 = 400,
			Mobile500 = 500,
			PC600 = 600
		}
	
		// Constructors
		public ShaderLodQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void InitApply() {} // 0x0000000183CA43C0-0x0000000183CA4400
		protected override void Apply() {} // 0x0000000189666614-0x00000001896666E4
		public void __iFixBaseProxy_InitApply() {} // 0x000000018965FCFC-0x000000018965FD04
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class SharpnessQuality : SliderQualityComponent // TypeDefIndex: 57782
	{
		// Constructors
		public SharpnessQuality() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x0000000182AB1740-0x0000000182AB1890
		public bool ShouldShow() => default; // 0x00000001896666E4-0x00000001896667C8
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class SliderTestComponent : SliderQualityComponent // TypeDefIndex: 57783
	{
		// Constructors
		public SliderTestComponent() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Apply() {} // 0x00000001896668CC-0x0000000189666910
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class TickExclusiveQuality : QualityTierComponent // TypeDefIndex: 57784
	{
		// Fields
		public TickExclusiveMode quality; // 0x18
		private LogicQualityLevel m_currentQuality; // 0x1C
		private ThermalState m_currentThermalState; // 0x1D
	
		// Constructors
		public TickExclusiveQuality() {} // 0x0000000183D4CD80-0x0000000183D4CD90
	
		// Methods
		protected override void Apply() {} // 0x0000000183CFE3F0-0x0000000183CFE450
		protected override void DynamicQualityChange(LogicQualityLevel current, LogicQualityLevel last) {} // 0x0000000182AB66C0-0x0000000182AB6710
		protected override void DynamicThermalChange(ThermalState current, ThermalState last) {} // 0x0000000189666910-0x0000000189666984
		private void _OnQualityOrThermalChanged() {} // 0x0000000182AB6760-0x0000000182AB6800
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
		public void __iFixBaseProxy_DynamicQualityChange(LogicQualityLevel P0, LogicQualityLevel P1) {} // 0x0000000185D6EA20-0x0000000185D6EA28
		public void __iFixBaseProxy_DynamicThermalChange(ThermalState P0, ThermalState P1) {} // 0x0000000185D6EA28-0x0000000185D6EA30
	}

	[Serializable]
	public class UpscalerQuality : EnumQualityComponent<UpscalerQuality.UpscalerMode> // TypeDefIndex: 57786
	{
		// Nested types
		public enum UpscalerMode // TypeDefIndex: 57785
		{
			DLSS = 0,
			TAAU = 1,
			FSR3 = 2
		}
	
		// Constructors
		public UpscalerQuality() {} // 0x0000000183D47350-0x0000000183D47380
	
		// Methods
		protected override void Apply() {} // 0x0000000182AB1890-0x0000000182AB1AF0
		public bool ShouldShow() => default; // 0x0000000189666AAC-0x0000000189666AFC
		public bool ShouldShowDLSS() => default; // 0x0000000189666A0C-0x0000000189666A5C
		public bool ShouldShowFSR3() => default; // 0x0000000189666A5C-0x0000000189666AAC
		public override int Version() => default; // 0x0000000183D47380-0x0000000183D473B0
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
		public int __iFixBaseProxy_Version() => default; // 0x00000001860BBCC0-0x00000001860BBCC8
	}

	[Serializable]
	[Obsolete]
	public class VSyncQuality : QualityTierComponent // TypeDefIndex: 57787
	{
		// Fields
		public bool bVSync; // 0x18
	
		// Constructors
		public VSyncQuality() {} // 0x0000000183D587A0-0x0000000183D587B0
	
		// Methods
		protected override void Apply() {} // 0x0000000189666CF0-0x0000000189666D48
		protected void Remove() {} // 0x0000000189666D48-0x0000000189666D98
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init() {} // 0x0000000183CAB5A0-0x0000000183CAB5D0
		public void __iFixBaseProxy_Apply() {} // 0x0000000185A73D24-0x0000000185A73D2C
	}

	[Serializable]
	public class VSyncQualityV2 : ToggleQualityComponent // TypeDefIndex: 57788
	{
		// Fields
		private Action<QualityTierComponent> callback; // 0x20
	
		// Constructors
		public VSyncQualityV2() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void Toggle(bool value) {} // 0x00000001839E1EB0-0x00000001839E1FA0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		public static void Init() {} // 0x0000000183CAB5D0-0x0000000183CAB600
		public override int Version() => default; // 0x0000000183D1F1D0-0x0000000183D1F200
		[OnDeserialized]
		protected void OnDeserialized(StreamingContext context) {} // 0x0000000182C997B0-0x0000000182C99850
		internal void DlSSChange(QualityTierComponent qualityTierComponent) {} // 0x0000000189666AFC-0x0000000189666C48
		public bool ShouldShow() => default; // 0x0000000189666C48-0x0000000189666CF0
		public void __iFixBaseProxy_Toggle(bool P0) {} // 0x000000018965CECC-0x000000018965CED4
		public int __iFixBaseProxy_Version() => default; // 0x00000001860BBCC0-0x00000001860BBCC8
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 57705
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 57706
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 57707
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 57708
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 57709
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 57703
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 57789
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D056B0-0x0000000183D05720
	
		// Methods
		public void __Gen_Wrap_0() {} // 0x00000001850F3444-0x00000001850F34E0
		public void __Gen_Wrap_1(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public string __Gen_Wrap_2(ref RankingRule P0) => default; // 0x000000018966149C-0x00000001896615F8
		public string __Gen_Wrap_3(ref DeviceMatchResult P0) => default; // 0x0000000189661940-0x0000000189661AAC
		public string __Gen_Wrap_4(object P0) => default; // 0x0000000189661FD0-0x00000001896620C0
		public bool __Gen_Wrap_5(ref DeviceMatchResult P0) => default; // 0x00000001896624A4-0x00000001896625EC
		public bool __Gen_Wrap_6(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public DeviceMatchRules __Gen_Wrap_7(object P0) => default; // 0x00000001896625EC-0x00000001896626DC
		public string __Gen_Wrap_8(object P0, object P1) => default; // 0x00000001896626DC-0x00000001896627E8
		public bool __Gen_Wrap_9(object P0, object P1, object P2, ref RankingRule P3) => default; // 0x00000001896627E8-0x0000000189662980
		public bool __Gen_Wrap_10(object P0, object P1, object P2, ref RankingRule P3, out string P4) {
			P4 = default;
			return default;
		} // 0x0000000189660410-0x00000001896605F0
		public void __Gen_Wrap_11(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public int __Gen_Wrap_12(object P0, object P1) => default; // 0x0000000185152714-0x0000000185152800
		public bool __Gen_Wrap_13(object P0, object P1, ref RankingRule P2) => default; // 0x00000001896605F0-0x0000000189660760
		public bool __Gen_Wrap_14(ref RankingRule P0, RankingRule P1) => default; // 0x0000000189660760-0x00000001896608E0
		public string __Gen_Wrap_15(ref MemoryRule P0) => default; // 0x00000001896608E0-0x0000000189660A34
		public bool __Gen_Wrap_16(ref MemoryRule P0, MemoryRule P1) => default; // 0x0000000189660A34-0x0000000189660BB0
		public string __Gen_Wrap_17(ref DeviceQualityMapItem P0) => default; // 0x0000000189660BB0-0x0000000189660D1C
		public UnityEngine.Color __Gen_Wrap_18(ref DeviceQualityMapItem P0, int P1) => default; // 0x0000000189660D1C-0x0000000189660EC0
		public UnityEngine.Color __Gen_Wrap_19(ref DeviceQualityMapItem P0) => default; // 0x0000000189660EC0-0x0000000189661048
		public int __Gen_Wrap_20(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public int __Gen_Wrap_21(QualityTierLevel P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public int __Gen_Wrap_22(DeviceQualityMapItem P0) => default; // 0x0000000189661048-0x000000018966114C
		public QualityTierComponentMatch __Gen_Wrap_23(object P0, object P1, int P2) => default; // 0x000000018966114C-0x0000000189661284
		public int __Gen_Wrap_24(QualityTierComponentMatch P0) => default; // 0x0000000189661284-0x0000000189661374
		public void __Gen_Wrap_25(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public void __Gen_Wrap_26(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public QualityTierComponentMatch __Gen_Wrap_27(object P0, object P1) => default; // 0x0000000189661374-0x000000018966149C
		public void __Gen_Wrap_28(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_29(object P0, LogicQualityLevel P1, LogicQualityLevel P2) {} // 0x0000000185E5E690-0x0000000185E5E788
		public void __Gen_Wrap_30(object P0, in EventData<LogicQualityLevel, LogicQualityLevel> P1) {} // 0x00000001896615F8-0x000000018966171C
		public void __Gen_Wrap_31(object P0, ThermalState P1, ThermalState P2) {} // 0x0000000185E5E788-0x0000000185E5E86C
		public void __Gen_Wrap_32(object P0, in EventData<ThermalState, ThermalState> P1) {} // 0x000000018966171C-0x0000000189661834
		public System.Type __Gen_Wrap_33(object P0, object P1) => default; // 0x0000000189661834-0x0000000189661940
		public void __Gen_Wrap_34(object P0, object P1, int P2) {} // 0x00000001854A1028-0x00000001854A1120
		public void __Gen_Wrap_35(object P0, GameSetting.GameSettingVideoQuality P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public GameSetting.GameSettingVideoQuality __Gen_Wrap_36(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public bool __Gen_Wrap_37() => default; // 0x00000001850F1D3C-0x00000001850F1DD4
		public bool __Gen_Wrap_38(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
		public QualityTierType __Gen_Wrap_39(object P0, object P1) => default; // 0x0000000185152714-0x0000000185152800
		public void __Gen_Wrap_40(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public void __Gen_Wrap_41(object P0, object P1, float P2) {} // 0x0000000185E7B3B0-0x0000000185E7B4AC
		public Vector2 __Gen_Wrap_42(object P0) => default; // 0x0000000189661AAC-0x0000000189661B88
		public float __Gen_Wrap_43(object P0) => default; // 0x00000001854AB08C-0x00000001854AB15C
		public Vector3 __Gen_Wrap_44(object P0, object P1) => default; // 0x0000000189661B88-0x0000000189661CA8
		public bool __Gen_Wrap_45(object P0, object P1, object P2, object P3) => default; // 0x0000000189661CA8-0x0000000189661DB0
		public ValueTuple<float, float> __Gen_Wrap_46(object P0, object P1) => default; // 0x0000000189661DB0-0x0000000189661EA8
		public int __Gen_Wrap_47(int P0, int P1) => default; // 0x000000018871E788-0x000000018871E85C
		public float __Gen_Wrap_48(object P0, object P1) => default; // 0x00000001854AB15C-0x00000001854AB248
		public int __Gen_Wrap_49(QualityTierComponentMatch P0, QualityTierComponentMatch P1) => default; // 0x0000000189661EA8-0x0000000189661FD0
		public void __Gen_Wrap_50(object P0, object P1, out int P2, out int P3) {
			P2 = default;
			P3 = default;
		} // 0x00000001896620C0-0x00000001896621FC
		public bool __Gen_Wrap_51(object P0, object P1, int P2) => default; // 0x0000000185646730-0x0000000185646824
		public byte[] __Gen_Wrap_52(object P0) => default; // 0x00000001896621FC-0x00000001896622D8
		public JsonSerializerSettings __Gen_Wrap_53() => default; // 0x00000001896622D8-0x00000001896623A4
		public void __Gen_Wrap_54(object P0, StreamingContext P1) {} // 0x00000001896623A4-0x00000001896624A4
		public int __Gen_Wrap_55(FrameRateQuality.FrameRateQualityEnum P0) => default; // 0x00000001856280E8-0x00000001856281B8
		public void __Gen_Wrap_56(int P0, HgFrameRateControl.ReasonEnum P1) {} // 0x00000001856458FC-0x00000001856459D4
		public int __Gen_Wrap_57() => default; // 0x00000001850F1DD4-0x00000001850F1E6C
		public int __Gen_Wrap_58(FrameRateQualityMobile.FrameRateQualityMobileEnum P0) => default; // 0x000000018562802C-0x00000001856280E8
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 57790
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000189666D98-0x0000000189666E2C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 57791
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000189667014-0x0000000189667078
		public static bool IsPatched(int id) => default; // 0x0000000182AB4860-0x0000000182AB48D0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000189666ED0-0x0000000189666F9C
		public object CreateWrapper(int id) => default; // 0x0000000189666F9C-0x0000000189667014
		public object InitWrapperArray(int len) => default; // 0x0000000189667078-0x0000000189667104
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000189666E2C-0x0000000189666ED0
	}

	public enum IDMAP0 // TypeDefIndex: 57792
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
		Beyond-Scripts-Quality-DeviceInfo-StandaloneGetMatchedRule0 = 15,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneMatchGPURule0 = 16,
		Beyond-Scripts-Quality-DeviceInfo-GetNvidiaStandardGPUName0 = 17,
		Beyond-Scripts-Quality-DeviceInfo-RuleSuffixMatch0 = 18,
		Beyond-Scripts-Quality-DeviceInfo-GetAmdStandardGPUName0 = 19,
		Beyond-Scripts-Quality-DeviceInfo-GetIntelStandardGPUName0 = 20,
		Beyond-Scripts-Quality-DeviceInfo-_ReportMatchRuleFailed0 = 21,
		Beyond-Scripts-Quality-DeviceInfo-EditorSimulateGetMatchedRule0 = 22,
		Beyond-Scripts-Quality-DeviceInfo-AndroidGetMatchedRule0 = 23,
		Beyond-Scripts-Quality-DeviceInfo-MatchDeviceModeRule0 = 24,
		Beyond-Scripts-Quality-DeviceInfo-RuleFullNameMatch0 = 25,
		Beyond-Scripts-Quality-DeviceInfo-MatchGPURule0 = 26,
		Beyond-Scripts-Quality-DeviceInfo-GetAdrenoStandardGPUName0 = 27,
		Beyond-Scripts-Quality-DeviceInfo-GetMaliStandardGPUName0 = 28,
		Beyond-Scripts-Quality-DeviceInfo-IOSGetMatchedRule0 = 29,
		Beyond-Scripts-Quality-DeviceInfo-DefaultGetMatchedRule0 = 30,
		Beyond-Scripts-Quality-DeviceInfo-StandaloneOSXGetMatchedRule0 = 31,
		Beyond-Scripts-Quality-DeviceInfo-StandalonePS5GetMatchedRule0 = 32,
		Beyond-Scripts-Quality-DeviceInfo-GetPowerVRStandardGPUName0 = 33,
		Beyond-Scripts-Quality-RankingRule-Equals0 = 34,
		Beyond-Scripts-Quality-MemoryRule-ToString0 = 35,
		Beyond-Scripts-Quality-MemoryRule-Equals0 = 36,
		Beyond-Scripts-Quality-DeviceQualityMapItem-ToString0 = 37,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getColor0 = 38,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryLowColor0 = 39,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getLowColor0 = 40,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getMiddleColor0 = 41,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getHighColor0 = 42,
		Beyond-Scripts-Quality-DeviceQualityMapItem-getVeryHighColor0 = 43,
		Beyond-Scripts-Quality-QualityManager-Init0 = 44,
		Beyond-Scripts-Quality-QualityManager-LoadQualityTier0 = 45,
		Beyond-Scripts-Quality-Components-QualityTierComponent-ApplyOrder0 = 50,
		Beyond-Scripts-Quality-QualityManager-ApplyQualityScore0 = 57,
		Beyond-Scripts-Quality-QualityManager-setQualityTier0 = 58,
		Beyond-Scripts-Quality-QualityManager-_SetQualityTierComponentLevel0 = 59,
		Beyond-Scripts-Quality-Components-QualityTierComponent-SafeApply0 = 60,
		Beyond-Scripts-Quality-Components-QualityTierComponent-InitApply0 = 61,
		Beyond-Scripts-Quality-Components-QualityTierComponent-Apply0 = 62,
		Beyond-Scripts-Quality-Components-QualityTierComponent-LowMemory0 = 63,
		Beyond-Scripts-Quality-QualityManager-InvokeChangeCallBack0 = 64,
		Beyond-Scripts-Quality-Components-QualityTierComponent-SafeLowMemory0 = 65,
		Beyond-Scripts-Quality-QualityManager-ApplyCallBack0 = 66,
		Beyond-Scripts-Quality-QualityManager-_GetOverrideQualityTierComponentLevel0 = 67,
		Beyond-Scripts-Quality-QualityManager-_DynamicInitQualitySetting0 = 68,
		Beyond-Scripts-Quality-QualityManager-DynamicQualityChange0 = 69,
		Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicQualityChange0 = 70,
		Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicQualityChange0 = 71,
		Beyond-Scripts-Quality-QualityManager-DynamicThermalChange0 = 72,
		Beyond-Scripts-Quality-Components-QualityTierComponent-CallDynamicThermalChange0 = 73,
		Beyond-Scripts-Quality-Components-QualityTierComponent-DynamicThermalChange0 = 74,
		Beyond-Scripts-Quality-QualityManager-InitOnlyDevice0 = 75,
		Beyond-Scripts-Quality-QualityManager-InitShaderLod0 = 76,
		Beyond-Scripts-Quality-QualityManager-ApplyShaderTier0 = 77,
		Beyond-Scripts-Quality-QualityManager-ForceSetQualityTierComponentLevel0 = 78,
		Beyond-Scripts-Quality-QualityManager-_GetQualityComponentByName0 = 79,
		Beyond-Scripts-Quality-QualityManager-FinishInit0 = 80,
		Beyond-Scripts-Quality-QualityManager-Dispose0 = 81,
		Beyond-Scripts-Quality-QualityManager-_DynamicReleaseQualitySetting0 = 82,
		Beyond-Scripts-Quality-QualityManager-SetQualityTierByVideoQuality0 = 83,
		Beyond-Scripts-Quality-QualityManager-GetDefaultVideoQuality0 = 84,
		Beyond-Scripts-Quality-QualityManager-NoMatchDeviceOrZeroScore0 = 85,
		Beyond-Scripts-Quality-QualityManager-IsQualcommDevice0 = 86,
		Beyond-Scripts-Quality-QualityManager-IsHUAWEIDevice0 = 87,
		Beyond-Scripts-Quality-QualityManager-IsIpadDevice0 = 88,
		Beyond-Scripts-Quality-QualityManager-InitResetQualityTierComponentFunction0 = 89,
		Beyond-Scripts-Quality-QualityManager-ResetQualityTierComponentValue0 = 90,
		Beyond-Scripts-Quality-QualityManager-RevertSetQualityTierComponentLevel0 = 91,
		Beyond-Scripts-Quality-QualityManager-NeedRestart0 = 92,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierType0 = 93,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierVersion0 = 94,
		Beyond-Scripts-Quality-Components-QualityTierComponent-Version0 = 95,
		Beyond-Scripts-Quality-QualityManager-_IsToggleQualityTierComponent0 = 96,
		Beyond-Scripts-Quality-QualityManager-_ToggleQualityTierComponentLevel0 = 97,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-ChangeToggle0 = 98,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetValue0 = 99,
		Beyond-Scripts-Quality-QualityManager-IsEnumQualityTierComponent0 = 100,
		Beyond-Scripts-Quality-QualityManager-GetEnumQualityTierComponentCount0 = 101,
		Beyond-Scripts-Quality-QualityManager-SetEnumQualityTierComponentCount0 = 102,
		Beyond-Scripts-Quality-QualityManager-IsSliderQualityTierComponent0 = 103,
		Beyond-Scripts-Quality-QualityManager-SetSliderQualityTierComponentCount0 = 104,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-SetValue0 = 105,
		Beyond-Scripts-Quality-QualityManager-GetSliderQualityTierComponent0 = 106,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetRange0 = 107,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetValue0 = 108,
		Beyond-Scripts-Quality-QualityManager-InvokeQualityTierComponent0 = 109,
		Beyond-Scripts-Quality-QualityManager-GetQualityTierComponentTierCount0 = 110,
		Beyond-Scripts-Quality-QualityManager-GetQualityComponentDefaultTier0 = 111,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-GetDefaultValue0 = 112,
		Beyond-Scripts-Quality-Components-SliderQualityComponent-GetDefaultValue0 = 113,
		Beyond-Scripts-Quality-QualityManager-GetQualityComponentTier0 = 114,
		Beyond-Scripts-Quality-QualityManager-SetQualityComponentTier0 = 115,
		Beyond-Scripts-Quality-QualityManager-_ReportQuality0 = 116,
		Beyond-Scripts-Quality-QualityManager-IsQualitySubSettingTierValid0 = 117,
		Beyond-Scripts-Quality-Components-QualityTierComponent-TierLimit0 = 118,
		Beyond-Scripts-Quality-QualityManager-_GetCurrentComponentTierIndex0 = 119,
		Beyond-Scripts-Quality-QualityManager-ToString0 = 120,
		Beyond-Scripts-Quality-QualityManager-DebugQualityTierComponentInfo0 = 121,
		Beyond-Scripts-Quality-QualityUtility-Decompress0 = 122,
		Beyond-Scripts-Quality-QualityUtility-get_JsonSerializerSettings0 = 123,
		Beyond-Scripts-Quality-Components-AntiAliasingQuality-Apply0 = 124,
		Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveQualitySettingSaveValue0 = 125,
		Beyond-Scripts-Quality-Components-QualityTierComponent-RemoveRegisterKey0 = 126,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-Apply0 = 127,
		Beyond-Scripts-Quality-Components-ToggleQualityComponent-Toggle0 = 128,
		Beyond-Scripts-Quality-Components-CharacterRenderFeatureQuality-Apply0 = 129,
		Beyond-Scripts-Quality-Components-ChromaticAberrationQuality-Toggle0 = 130,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-Apply0 = 131,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-OnDeserialized0 = 132,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-DlSSChange0 = 133,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowAuto0 = 134,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX10 = 135,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX20 = 136,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShowX30 = 137,
		Beyond-Scripts-Quality-Components-DLSSFrameGenQuality-ShouldShow0 = 138,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-Apply0 = 139,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-ShouldShow0 = 140,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-OnDeserialized0 = 141,
		Beyond-Scripts-Quality-Components-DLSSUpscalerQuality-DlSSChange0 = 142,
		Beyond-Scripts-Quality-Components-EnvironmentRenderingFeatureQuality-Apply0 = 143,
		Beyond-Scripts-Quality-Components-FrameGenQuality-Apply0 = 144,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShow0 = 145,
		Beyond-Scripts-Quality-Components-FrameGenQuality-ShouldShowDLSS0 = 146,
		Beyond-Scripts-Quality-Components-FrameGenQualityMobile-Apply0 = 147,
		Beyond-Scripts-Quality-Components-FrameGenQualityMobile-ShouldShow0 = 148,
		Beyond-Scripts-Quality-Components-FrameRateQuality-GetFrameRateFromEnum0 = 149,
		Beyond-Scripts-Quality-Components-FrameRateQuality-Version0 = 150,
		Beyond-Scripts-Quality-Components-FrameRateQuality-ShouldShow0 = 151,
		Beyond-Scripts-Quality-Components-FrameRateQuality-Apply0 = 152,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-__ForceSetFrameRate0 = 153,
		Beyond-Scripts-Quality-Components-FrameRateQuality-DlSSChange0 = 154,
		Beyond-Scripts-Quality-Components-FrameRateQuality-OnDeserialized0 = 155,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS30Enabled0 = 156,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPS60Enabled0 = 157,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_FPSBNoLimitEnabled0 = 158,
		Beyond-Scripts-Quality-Components-FrameRateQuality-_IsGDLSSGDisable0 = 159,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetDefaultFrameRate0 = 160,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-Init0 = 161,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-SetFrameRateOverrider0 = 162,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetFrameRate0 = 163,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-RecommendedDefaultFrameRate0 = 164,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-GetUserSettingFrameRate0 = 165,
		Beyond-Scripts-Quality-Components-HgFrameRateControl-ResetFrameRate0 = 166,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-GetFrameRateFromEnum0 = 167,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Version0 = 168,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-Apply0 = 169,
		Beyond-Scripts-Quality-Components-FrameRateQualityMobile-OnDeserialized0 = 170,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-Apply0 = 171,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-ShouldShow0 = 172,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-OnDeserialized0 = 173,
		Beyond-Scripts-Quality-Components-FSR3UpscalerQuality-FSR3Change0 = 174,
		Beyond-Scripts-Quality-Components-GrassSparsityQuality-Apply0 = 175,
		Beyond-Scripts-Quality-Components-HGAmbientOcclusionQuality-Apply0 = 176,
		Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-InitApply0 = 177,
		Beyond-Scripts-Quality-Components-HGAnisoLevelQuality-Apply0 = 178,
		Beyond-Scripts-Quality-Components-HGContactShadowQuality-Toggle0 = 179,
		Beyond-Scripts-Quality-Components-HGIrradianceVolumeQuality-LowMemory0 = 180,
		Beyond-Scripts-Quality-Components-HGLODStreamingComponent-Apply0 = 181,
		Beyond-Scripts-Quality-Components-HGLODStreamingComponent-LowMemory0 = 182,
		Beyond-Scripts-Quality-Components-HGReflectionProbeBinningQuality-LowMemory0 = 183,
		Beyond-Scripts-Quality-Components-HGRPTierQuality-Apply0 = 184,
		Beyond-Scripts-Quality-Components-HGScreenSpaceReflectionQuality-Apply0 = 185,
		Beyond-Scripts-Quality-Components-HGShadowQuality-Apply0 = 186,
		Beyond-Scripts-Quality-Components-HGTextureQuality-get_textureQualityTier0 = 187,
		Beyond-Scripts-Quality-Components-HGTextureQuality-Apply0 = 188,
		Beyond-Scripts-Quality-Components-HGVolumetricFogQuality-Apply0 = 189,
		Beyond-Scripts-Quality-Components-LODGroupQuality-Apply0 = 190,
		Beyond-Scripts-Quality-Components-PhysicsClothQuality-Apply0 = 191,
		Beyond-Scripts-Quality-Components-PrefabInstantiateQuality-Apply0 = 192,
		Beyond-Scripts-Quality-Components-PreloadLoadSettingQuality-Apply0 = 193,
		Beyond-Scripts-Quality-Components-RayTracingQuality-InitApply0 = 194,
		Beyond-Scripts-Quality-Components-RayTracingQuality-Apply0 = 195,
		Beyond-Scripts-Quality-Components-RayTracingQuality-ShouldShow0 = 196,
		Beyond-Scripts-Quality-Components-RayTracingQuality-ApplyOrder0 = 197,
		Beyond-Scripts-Quality-Components-ReflexQuality-Apply0 = 198,
		Beyond-Scripts-Quality-Components-ReflexQuality-ShouldShow0 = 199,
		Beyond-Scripts-Quality-Components-ReflexQuality-OnDeserialized0 = 200,
		Beyond-Scripts-Quality-Components-ReflexQuality-DlSSChange0 = 201,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-get_renderingScaleFactor0 = 202,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityMobile-Apply0 = 203,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-get_renderingScale0 = 204,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-Apply0 = 205,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-ShouldShow0 = 206,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-OnDeserialized0 = 207,
		Beyond-Scripts-Quality-Components-RenderingScaleQualityPC-DlSSChange0 = 208,
		Beyond-Scripts-Quality-Components-ResLoadSettingQuality-Apply0 = 209,
		Beyond-Scripts-Quality-Components-ResLoadSettingQuality-LowMemory0 = 210,
		Beyond-Scripts-Quality-Components-SceneDetailQuality-Apply0 = 211,
		Beyond-Scripts-Quality-Components-ShaderLodQuality-InitApply0 = 212,
		Beyond-Scripts-Quality-Components-ShaderLodQuality-Apply0 = 213,
		Beyond-Scripts-Quality-Components-SharpnessQuality-Apply0 = 214,
		Beyond-Scripts-Quality-Components-SharpnessQuality-ShouldShow0 = 215,
		Beyond-Scripts-Quality-Components-SliderTestComponent-Apply0 = 216,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-Apply0 = 217,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicQualityChange0 = 218,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-_OnQualityOrThermalChanged0 = 219,
		Beyond-Scripts-Quality-Components-TickExclusiveQuality-DynamicThermalChange0 = 220,
		Beyond-Scripts-Quality-Components-UpscalerQuality-Apply0 = 221,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShow0 = 222,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowDLSS0 = 223,
		Beyond-Scripts-Quality-Components-UpscalerQuality-ShouldShowFSR30 = 224,
		Beyond-Scripts-Quality-Components-UpscalerQuality-Version0 = 225,
		Beyond-Scripts-Quality-Components-VSyncQuality-Apply0 = 226,
		Beyond-Scripts-Quality-Components-VSyncQuality-Remove0 = 227,
		Beyond-Scripts-Quality-Components-VSyncQuality-Init0 = 228,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Toggle0 = 229,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Init0 = 230,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-Version0 = 231,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-OnDeserialized0 = 232,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-DlSSChange0 = 233,
		Beyond-Scripts-Quality-Components-VSyncQualityV2-ShouldShow0 = 234
	}
}
