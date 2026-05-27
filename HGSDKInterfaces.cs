/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using AOT;
using UnityEngine;

// Image 71: HGSDKInterfaces.dll - Assembly: HGSDKInterfaces, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58680-58713
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public enum CSLogSeverity // TypeDefIndex: 58681
{
	LogSilent = 0,
	LogError = 1,
	LogWarning = 2,
	LogInfo = 3,
	LogDebug = 4,
	LogVerbose = 5
}

public enum CSReportType // TypeDefIndex: 58682
{
	InterfaceReport = 0,
	LogCallback = 1,
	LogCallbackThreaded = 2
}

public enum JankReportInfoOption // TypeDefIndex: 58683
{
	JankOnlyBasicInfo = 0,
	JankSystemLog = 1,
	JankCustomLog = 2,
	JankCustomKv = 4,
	JankCallbackInfo = 8,
	JankAutoDumpStack = 16,
	JankAndroidAllJavaStack = 32
}

public sealed class CrashSightAgent // TypeDefIndex: 58688
{
	// Fields
	private static HGCrashSightCallback _crashSightCallback; // 0x00
	private static HGCrashSightLogCallback _crashSightLogCallback; // 0x08
	private static string crashUploadUrl; // 0x10
	public static List<int> callbackThreads; // 0x18
	public static object callbackThreadsLock; // 0x20
	private static LogFilterDelegate s_logFilter; // 0x30
	private static bool _isInitialized; // 0x38
	private static UnityEngine.LogType _autoReportLogLevel; // 0x3C
	private static bool _debugMode; // 0x40
	private static bool _autoQuitApplicationAfterReport; // 0x41
	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler; // 0x48
	private static bool _uncaughtAutoReportOnce; // 0x50
	public static readonly string s_UnityBuildVersion; // 0x58
	public static readonly string s_CommandLine; // 0x60
	public static readonly string s_UserName; // 0x68
	public static readonly string s_UserDomainName; // 0x70
	public static readonly string s_DeviceModel; // 0x78
	public static readonly string s_DeviceName; // 0x80
	public static readonly string s_DeviceUniqueIdentifier; // 0x88
	public static readonly string s_DeviceType; // 0x90
	public static readonly string s_GraphicsDeviceName; // 0x98
	public static readonly string s_GraphicsDeviceType; // 0xA0
	public static readonly string s_GraphicsDeviceVersion; // 0xA8
	public static readonly string s_GraphicsDeviceVendor; // 0xB0
	public static readonly int s_GraphicsMemorySize; // 0xB8
	public static readonly string s_NvidiaDriverVersion; // 0xC0
	public static readonly string[] s_BootParams; // 0xC8

	// Properties
	public static bool AutoQuitApplicationAfterReport { get => default; } // 0x00000001887C6D00-0x00000001887C6D50 
	public static bool IsInitialized { get => default; } // 0x00000001887C6D50-0x00000001887C6DA0 

	// Events
	private static event LogCallbackDelegate _LogCallbackEventHandler;

	// Nested types
	private class HGCrashSightCallback : CrashSightCallback // TypeDefIndex: 58684
	{
		// Constructors
		public HGCrashSightCallback() {} // 0x000000018350B670-0x000000018350B680

		// Methods
		public override string OnCrashBaseRetEvent(int methodId, int crashType) => default; // 0x0000000182D7B150-0x0000000182D7B210
	}

	private class HGCrashSightLogCallback : CrashSightLogCallback // TypeDefIndex: 58685
	{
		// Constructors
		public HGCrashSightLogCallback() {} // 0x000000018350B670-0x000000018350B680

		// Methods
		public override string OnSetLogPathEvent(int methodId, int crashType) => default; // 0x00000001887C813C-0x00000001887C81EC
		public override void OnLogUploadResultEvent(int methodId, int crashType, int result) {} // 0x00000001887C7FDC-0x00000001887C813C
	}

	public delegate void LogCallbackDelegate(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 58686; 0x00000001811360D0-0x00000001811360F0

	public delegate bool LogFilterDelegate(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 58687; 0x0000000181035ED0-0x0000000181035EF0

	// Constructors
	public CrashSightAgent() {} // 0x000000018350B670-0x000000018350B680
	static CrashSightAgent() {} // 0x000000018315CA60-0x000000018315D010

	// Methods
	public static void SetLogFilter(LogFilterDelegate filter) {} // 0x00000001887C5918-0x00000001887C5978
	public static void InitWithAppId(string appId, bool forceOnUiThread = false /* Metadata: 0x01FDB863 */) {} // 0x0000000182CD63A0-0x0000000182CD64F0
	public static void ReportException(Exception e, string message) {} // 0x00000001887C51B8-0x00000001887C5314
	public static void ReportException(string name, string message, string stackTrace) {} // 0x00000001887C4F9C-0x00000001887C5104
	public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0 /* Metadata: 0x01FDB864 */, string errorAttachmentPath = "" /* Metadata: 0x01FDB865 */) {} // 0x00000001887C5104-0x00000001887C51B8
	public static void SetUserId(string userId) {} // 0x0000000182D7BCB0-0x0000000182D7BD90
	public static void AddSceneData(string key, string value) {} // 0x0000000182D7C940-0x0000000182D7CB40
	public static void SetUserValue(string key, int value) {} // 0x0000000182D7B0A0-0x0000000182D7B150
	public static void SetUserValue(string key, string value) {} // 0x0000000182D7C8C0-0x0000000182D7C940
	public static void SetUserValue(string key, string[] value) {} // 0x0000000182D7AF10-0x0000000182D7AFD0
	public static void SetAppVersion(string appVersion) {} // 0x0000000183A24A00-0x0000000183A24AB0
	public static void ConfigCrashServerUrl(string crashServerUrl) {} // 0x0000000183B12E30-0x0000000183B12EE0
	public static void SetLogPath(string logPath) {} // 0x00000001887C5978-0x00000001887C59C4
	public static void ConfigDebugMode(bool enable) {} // 0x0000000183A06CF0-0x0000000183A06DE0
	public static void SetDeviceId(string deviceId) {} // 0x00000001887C55D8-0x00000001887C5624
	public static void ConfigCrashReporter(int logLevel) {} // 0x00000001887C4468-0x00000001887C44B0
	public static void ConfigCrashReporter(CSLogSeverity logLevel) {} // 0x00000001887C4420-0x00000001887C4468
	public static void PrintLog(CSLogSeverity level, string format, params object[] args) {} // 0x0000000182D7C3B0-0x0000000182D7C440
	public static void TestNativeCrash() {} // 0x00000001887C5F20-0x00000001887C5FA4
	public static void SetEnvironmentName(string serverEnv) {} // 0x00000001887C56B8-0x00000001887C5704
	public static void EnableAnrMonitor(int timeoutMs = 5000 /* Metadata: 0x01FDB866 */) {} // 0x00000001887C468C-0x00000001887C46D4
	public static void DisableAnrMonitor() {} // 0x00000001887C464C-0x00000001887C468C
	public static void RegisterCrashCallback(CrashSightCallback callback) {} // 0x0000000182CD65D0-0x0000000182CD6690
	public static void UnregisterCrashCallback() {} // 0x00000001887C6130-0x00000001887C6170
	public static void RegisterCrashLogCallback(CrashSightLogCallback callback) {} // 0x0000000182CD6690-0x0000000182CD67A0
	public static void EnableExceptionHandler() {} // 0x00000001887C46D4-0x00000001887C4764
	public static void RegisterLogCallback(LogCallbackDelegate handler) {} // 0x00000001887C4E1C-0x00000001887C4EAC
	public static void UnregisterLogCallback(LogCallbackDelegate handler) {} // 0x00000001887C6170-0x00000001887C61D4
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler) {} // 0x00000001887C5860-0x00000001887C5918
	public static void ConfigAutoQuitApplication(bool autoQuit) {} // 0x00000001887C4384-0x00000001887C43D8
	public static void DebugLog(string tag, string format) {} // 0x0000000182D7CB40-0x0000000182D7CBD0
	public static void _RegisterExceptionHandler() {} // 0x000000018267B420-0x000000018267B6C0
	public static void _UnregisterExceptionHandler() {} // 0x00000001887C6938-0x00000001887C6B08
	public static void SetCrashSightStackTraceEnable(bool enable) {} // 0x000000018350B670-0x000000018350B680
	public static void ConfigCallbackType(int callbackType) {} // 0x00000001887C43D8-0x00000001887C4420
	public static void SetDeviceModel(string deviceModel) {} // 0x00000001887C5624-0x00000001887C5670
	public static void ReportLogInfo(string msgType, string msg) {} // 0x00000001887C53A8-0x00000001887C5404
	public static void SetScene(string sceneId, bool upload = false /* Metadata: 0x01FDB868 */) {} // 0x00000001887C5AD0-0x00000001887C5BC8
	public static void SetScene(int sceneId, bool upload = false /* Metadata: 0x01FDB869 */) {} // 0x00000001887C5BC8-0x00000001887C5C28
	public static long GetCrashThreadId() => default; // 0x00000001887C4764-0x00000001887C47F0
	public static void SetCustomizedDeviceID(string deviceId) {} // 0x00000001887C5540-0x00000001887C558C
	public static string GetSDKDefinedDeviceID() => default; // 0x00000001887C48CC-0x00000001887C490C
	public static void SetCustomizedMatchID(string matchId) {} // 0x00000001887C558C-0x00000001887C55D8
	public static string GetSDKSessionID() => default; // 0x00000001887C490C-0x00000001887C494C
	public static void TestOomCrash() {} // 0x00000001887C6028-0x00000001887C60AC
	public static void TestJavaCrash() {} // 0x00000001887C5E9C-0x00000001887C5F20
	public static void TestANR() {} // 0x00000001887C5E18-0x00000001887C5E9C
	public static string GetCrashUuid() => default; // 0x00000001887C47F0-0x00000001887C4830
	public static void SetLogcatBufferSize(int size) {} // 0x00000001887C59C4-0x00000001887C5A0C
	public static void TestOcCrash() {} // 0x00000001887C5FA4-0x00000001887C6028
	public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath) {} // 0x00000001887C5CE8-0x00000001887C5D98
	public static void StartMonitorFdCount(int interval, int limit, int dumpType) {} // 0x00000001887C5D98-0x00000001887C5E18
	public static int getExceptionType(string name) => default; // 0x00000001887C6C94-0x00000001887C6D00
	public static void TestUseAfterFree() {} // 0x00000001887C60AC-0x00000001887C6130
	public static void ReRegistAllMonitors() {} // 0x00000001887C4D9C-0x00000001887C4E1C
	public static void CloseAllMonitors() {} // 0x00000001887C4318-0x00000001887C4384
	public static void setEnableGetPackageInfo(bool enable) {} // 0x00000001887C6F2C-0x00000001887C6FE4
	public static void setCatchMultiSignal(bool enable) {} // 0x00000001887C6E74-0x00000001887C6F2C
	public static void enableDetailedPageTracing(bool enable) {} // 0x00000001887C6BDC-0x00000001887C6C94
	public static bool IsLastSessionCrash() => default; // 0x00000001887C4D14-0x00000001887C4D9C
	public static string GetLastSessionUserId() => default; // 0x00000001887C4830-0x00000001887C48CC
	public static bool CheckFdCount(int limit, int dumpType, bool upload) => default; // 0x00000001887C4294-0x00000001887C4318
	public static void SetOomLogPath(string logPath) {} // 0x00000001887C5A0C-0x00000001887C5A58
	public static void ReportJank(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int reportInfoOption, string jankAttachmentPath) {} // 0x00000001887C5314-0x00000001887C53A8
	public static void ReportStuck(int threadId, int maxChecks, long checkInterval, string name, string message, Dictionary<string, string> extInfo, int dumpNativeType, string attachPath) {} // 0x00000001887C5404-0x00000001887C54A8
	public static void SetVehEnable(bool enable) {} // 0x00000001887C5C28-0x00000001887C5C9C
	public static void ReportCrash() {} // 0x00000001887C4EAC-0x00000001887C4F18
	public static void ReportDump(string dump_path, bool is_async) {} // 0x00000001887C4F18-0x00000001887C4F9C
	public static void SetExtraHandler(bool extra_handle_enable) {} // 0x00000001887C57EC-0x00000001887C5860
	public static void UploadGivenPathDump(string dump_dir, bool is_extra_check) {} // 0x00000001887C6220-0x00000001887C62A4
	public static void SetDumpType(int dump_type) {} // 0x00000001887C5670-0x00000001887C56B8
	public static void AddValidExpCode(ulong exp_code) {} // 0x00000001887C4248-0x00000001887C4294
	public static void UploadCrashWithGuid(string guid) {} // 0x00000001887C61D4-0x00000001887C6220
	public static void SetCrashUploadEnable(bool enable) {} // 0x00000001887C54A8-0x00000001887C54F4
	public static void SetWorkSpace(string workspace) {} // 0x00000001887C5C9C-0x00000001887C5CE8
	public static void SetCustomAttachDir(string path) {} // 0x00000001887C54F4-0x00000001887C5540
	public static void SetErrorUploadInterval(int interval) {} // 0x00000001887C5778-0x00000001887C57EC
	public static void SetErrorUploadEnable(bool enable) {} // 0x00000001887C5704-0x00000001887C5778
	public static void SetRecordFileDir(string record_dir) {} // 0x00000001887C5A58-0x00000001887C5AD0
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03\uFF0C\u8BF7\u4F7F\u7528 InitWithAppId \u8FDB\u884C\u521D\u59CB\u5316")]
	public static void InitContext(string userId, string version, string key) {} // 0x00000001887C494C-0x00000001887C4B2C
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03\uFF0C\u8BF7\u4F7F\u7528 InitWithAppId \u8FDB\u884C\u521D\u59CB\u5316")]
	public static void Init(string app_id, string app_key, string app_version) {} // 0x00000001887C4B2C-0x00000001887C4D14
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03")]
	public static void ConfigDefault(string channel, string version, string user, long delay) {} // 0x00000001887C44B0-0x00000001887C464C
	private static void _OnLogCallbackHandlerMain(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x0000000183CF2D60-0x0000000183CF2DE0
	private static void _OnLogCallbackHandlerThreaded(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x0000000182D7ACC0-0x0000000182D7AD40
	private static void _OnLogCallbackHandler(string condition, string stackTrace, UnityEngine.LogType type, CSReportType rType) {} // 0x0000000182D7BD90-0x0000000182D7C000
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args) {} // 0x00000001887C677C-0x00000001887C6938
	private static void _HandleException(Exception e, string message, bool uncaught) {} // 0x00000001887C62A4-0x00000001887C677C
	private static bool ShouldSkipFrame(string frame) => default; // 0x00000001832D9C00-0x00000001832D9D20
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace) {} // 0x00000001832D8460-0x00000001832D9C00
	private static void AddTrackCustomData() {} // 0x0000000182D7C570-0x0000000182D7C8C0
	private static void AddLocalLogFile() {} // 0x000000018350B670-0x000000018350B680
	private static int valueOf(UnityEngine.LogType logLevel) => default; // 0x0000000182D7CEF0-0x0000000182D7CFB0
	private static bool isEnableAutoReport(UnityEngine.LogType logLevel) => default; // 0x0000000182D7CE60-0x0000000182D7CEF0
	private static void _HandleException(UnityEngine.LogType logLevel, string name, string message, string stackTrace, bool uncaught, CSReportType rType) {} // 0x0000000182D7C000-0x0000000182D7C3B0
}

public class CrashSightAnrMonitor // TypeDefIndex: 58691
{
	// Fields
	private static CrashSightMonoBehaviour monoBehaviour; // 0x00
	private static int anrTimeoutMs; // 0x08
	private static int detectionTimeoutMs; // 0x0C
	private static int ticksSinceUiUpdate; // 0x14
	private static bool reported; // 0x18
	private static bool running; // 0x19
	private static Thread thread; // 0x20

	// Properties
	protected static bool Paused { get; private set; } // 0x00000001887C78F4-0x00000001887C7944 0x00000001887C7944-0x00000001887C7998

	// Constructors
	public CrashSightAnrMonitor() {} // 0x000000018350B670-0x000000018350B680
	static CrashSightAnrMonitor() {} // 0x00000001887C7838-0x00000001887C78F4

	// Methods
	public static void Start(int timeoutMs = 5000 /* Metadata: 0x01FDB86A */) {} // 0x00000001887C730C-0x00000001887C77A4
	public static void Stop() {} // 0x00000001887C77A4-0x00000001887C77F4
	[IteratorStateMachine(typeof(_UpdateUiStatus_d__13))]
	private static IEnumerator UpdateUiStatus() => default; // 0x00000001887C77F4-0x00000001887C7838
	private static void Run() {} // 0x00000001887C70B0-0x00000001887C730C
	private static void Report() {} // 0x00000001887C6FE4-0x00000001887C70B0
}

public class UnityAnrException : Exception // TypeDefIndex: 58692
{
	// Constructors
	internal UnityAnrException() {} // 0x00000001887D1B08-0x00000001887D1B54
	internal UnityAnrException(string message) {} // 0x00000001887D1AAC-0x00000001887D1B08
	internal UnityAnrException(string message, Exception innerException) {} // 0x00000001887D1B54-0x00000001887D1C04
}

public abstract class CrashSightCallback // TypeDefIndex: 58693
{
	// Constructors
	protected CrashSightCallback() {} // 0x000000018350B670-0x000000018350B680

	// Methods
	public abstract string OnCrashBaseRetEvent(int methodId, int crashType);
}

public abstract class CrashSightLogCallback // TypeDefIndex: 58694
{
	// Constructors
	protected CrashSightLogCallback() {} // 0x000000018350B670-0x000000018350B680

	// Methods
	public abstract string OnSetLogPathEvent(int methodId, int crashType);
	public abstract void OnLogUploadResultEvent(int methodId, int crashType, int result);
}

[AddComponentMenu("")]
public class CrashSightMonoBehaviour : MonoBehaviour // TypeDefIndex: 58695
{
	// Fields
	private static CrashSightMonoBehaviour _instance; // 0x00
	internal bool _isRunning; // 0x30

	// Properties
	public static CrashSightMonoBehaviour Instance { get => default; } // 0x00000001887C7C54-0x00000001887C7D74 

	// Events
	public event Action ApplicationResuming;
	public event Action ApplicationPausing;
	public event Action ApplicationQuitting;

	// Constructors
	public CrashSightMonoBehaviour() {} // 0x00000001887C7A8C-0x00000001887C7A98

	// Methods
	public void UpdatePauseStatus(bool paused) {} // 0x00000001887C7A58-0x00000001887C7A8C
	internal void OnApplicationPause(bool pauseStatus) {} // 0x00000001887C79F4-0x00000001887C79FC
	internal void OnApplicationFocus(bool hasFocus) {} // 0x00000001887C79E8-0x00000001887C79F4
	private void OnApplicationQuit() {} // 0x00000001887C79FC-0x00000001887C7A58
	private void Awake() {} // 0x00000001887C7998-0x00000001887C79E8
}

public class CrashSightStackTrace // TypeDefIndex: 58696
{
	// Fields
	public static bool enable; // 0x00
	private static string stackTrace; // 0x08

	// Constructors
	public CrashSightStackTrace() {} // 0x000000018350B670-0x000000018350B680

	// Methods
	public static void setEnable(bool enable) {} // 0x000000018350B670-0x000000018350B680
	public static string ExtractStackTrace() => default; // 0x00000001887C7F30-0x00000001887C7FDC
}

namespace GCloud.UQM
{
	public delegate void OnUQMRetEventHandler<T>(T ret); // TypeDefIndex: 58697; 0x00000000-0x00000000

	public delegate string OnUQMStringRetEventHandler<T>(T ret, T crashType); // TypeDefIndex: 58698; 0x00000000-0x00000000

	public delegate string OnUQMStringRetSetLogPathEventHandler<T>(T ret, T crashType); // TypeDefIndex: 58699; 0x00000000-0x00000000

	public delegate void OnUQMRetLogUploadEventHandler<T>(T ret, T crashType, T result); // TypeDefIndex: 58700; 0x00000000-0x00000000

	public class UQM // TypeDefIndex: 58701
	{
		// Fields
		public const string LibName = "CrashSight64"; // Metadata: 0x01FDB86C
		private static bool initialized; // 0x00
		public static bool isDebug; // 0x01
	
		// Constructors
		public UQM() {} // 0x000000018350B670-0x000000018350B680
		static UQM() {} // 0x00000001887D1A74-0x00000001887D1AAC
	
		// Methods
		public static void Init() {} // 0x00000001887D19B0-0x00000001887D1A74
	}

	public enum UQMCrashLevel // TypeDefIndex: 58702
	{
		CSLogLevelSilent = 0,
		CSLogLevelError = 1,
		CSLogLevelWarn = 2,
		CSLogLevelInfo = 3,
		CSLogLevelDebug = 4,
		CSLogLevelVerbose = 5
	}

	public static class UQMCrash // TypeDefIndex: 58703
	{
		// Fields
		private static AndroidJavaClass _gameAgentClass; // 0x18
		private static bool _isLoadedSo; // 0x20
		private static int _gameType; // 0x24
		private static readonly string GAME_AGENT_CLASS; // 0x28
	
		// Properties
		public static AndroidJavaClass CrashSightPlatform { get; } // 0x00000001887D0DB0-0x00000001887D0E94 
	
		// Events
		public static event OnUQMStringRetEventHandler<int> CrashBaseRetEvent;
		public static event OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent;
		public static event OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent;
	
		// Constructors
		static UQMCrash() {} // 0x0000000183CB9980-0x0000000183CB9A30
	
		// Methods
		private static extern void CS_InitContext(string id, string version, string key); // 0x00000001887CA2D8-0x00000001887CA3A8
		private static extern void CS_ReportExceptionW(int type, string name, string message, string stack_trace, string extras, bool is_async, string attachmentPath = "" /* Metadata: 0x01FDB87F */); // 0x00000001822C8670-0x00000001822C8770
		private static extern void CS_SetUserValue(string key, string value); // 0x0000000182D7CD30-0x0000000182D7CDB0
		private static extern void CS_SetVehEnable(bool enable); // 0x00000001887CA984-0x00000001887CA9FC
		private static extern void CS_SetExtraHandler(bool extra_handle_enable); // 0x00000001887CA950-0x00000001887CA984
		private static extern void CS_SetCustomLogDirW(string log_path); // 0x00000001887CA740-0x00000001887CA7C0
		private static extern void CS_SetUserId(string user_id); // 0x0000000182D7B2D0-0x0000000182D7B320
		private static extern void CS_MonitorEnable(bool enable); // 0x00000001887CA3A8-0x00000001887CA420
		private static extern void CS_PrintLog(int level, string tag, string format, string arg); // 0x0000000182D7CDB0-0x0000000182D7CE60
		private static extern void CS_UploadGivenPathDump(string dump_dir, bool is_extra_check); // 0x00000001887CAB70-0x00000001887CAC04
		private static extern void CS_ReportCrash(); // 0x00000001887CA420-0x00000001887CA488
		private static extern void CS_ReportDump(string dump_dir, bool is_async); // 0x00000001887CA488-0x00000001887CA51C
		private static extern void CS_SetEnvironmentName(string name); // 0x00000001887CA8C4-0x00000001887CA950
		private static extern void CS_InitWithAppId(string app_id); // 0x0000000182CD5E50-0x0000000182CD5EB0
		private static extern void CS_SetAppVersion(string app_version); // 0x0000000183A24B60-0x0000000183A24BC0
		private static extern void CS_ConfigCrashServerUrl(string crash_server_url); // 0x00000001822C7F80-0x00000001822C8020
		private static extern void CS_ConfigDebugMode(bool enable); // 0x00000001822C8630-0x00000001822C8670
		private static extern void CS_SetDeviceId(string device_id); // 0x00000001887CA7C0-0x00000001887CA84C
		private static extern void CS_ConfigCrashReporter(int log_level); // 0x00000001887CA260-0x00000001887CA2D8
		private static extern void CS_TestNativeCrash(); // 0x00000001887CAA7C-0x00000001887CAAE4
		private static extern void CS_SetDumpType(int dump_type); // 0x00000001887CA84C-0x00000001887CA8C4
		private static extern void CS_AddValidExpCode(ulong exp_code); // 0x00000001887CA1E8-0x00000001887CA260
		private static extern void CS_UploadCrashWithGuid(string guid); // 0x00000001887CAAE4-0x00000001887CAB70
		private static extern void CS_SetCrashUploadEnable(bool enable); // 0x00000001887CA648-0x00000001887CA6C0
		private static extern void CS_SetWorkSpaceW(string workspace); // 0x00000001887CA9FC-0x00000001887CAA7C
		private static extern void CS_SetEngineInfo(string version, string buildConfig, string language, string locale); // 0x00000001822C7BE0-0x00000001822C7CF0
		private static extern void CS_SetCustomAttachDirW(string log_path); // 0x00000001887CA6C0-0x00000001887CA740
		private static extern void CS_UseSavedUserId(bool enable); // 0x00000001887CAC04-0x00000001887CAC7C
		private static extern void CS_ReportStuck(int threadId, int maxChecks, int checkInterval, string name, string message, string extraInfo, int dumpNativeType, string attachPath); // 0x00000001887CA51C-0x00000001887CA648
		private static void LoadCrashSightCoreSo() {} // 0x000000018350B670-0x000000018350B680
		public static void ConfigCallbackType(int callbackType) {} // 0x00000001887CB1D4-0x00000001887CB35C
		public static void ConfigGameType(int gameType) {} // 0x0000000182CD5EB0-0x0000000182CD5F80
		public static void ConfigAutoReportLogLevel(int level) {} // 0x00000001887CB040-0x00000001887CB1D4
		public static void ConfigCrashServerUrl(string serverUrl) {} // 0x0000000183B12EE0-0x0000000183B12F90
		public static void ConfigDebugMode(bool enable) {} // 0x0000000183A06DE0-0x0000000183A06ED0
		public static void ConfigDefault(string channel, string version, string user, long delay) {} // 0x00000001887CB35C-0x00000001887CB5CC
		public static void InitWithAppId(string appId, bool forceOnUiThread) {} // 0x0000000182CD5D60-0x0000000182CD5E50
		public static void InitContext(string userId, string version, string key) {} // 0x00000001887CBD10-0x00000001887CBEB8
		public static void LogRecord(int level, string message) {} // 0x0000000182D7C440-0x0000000182D7C570
		public static void AddSceneData(string k, string v) {} // 0x0000000182D7CBD0-0x0000000182D7CCB0
		public static void ReportException(int type, string name, string message, string stackTrace, string extras, bool quitProgram) {} // 0x0000000182D7EAC0-0x0000000182D7EC30
		public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0 /* Metadata: 0x01FDB880 */, string errorAttachmentPath = "" /* Metadata: 0x01FDB881 */) {} // 0x00000001887CCFE8-0x00000001887CD1EC
		public static void SetUserId(string userId) {} // 0x0000000182D7B210-0x0000000182D7B2D0
		public static void SetScene(string sceneId, bool upload) {} // 0x00000001887CF114-0x00000001887CF2D0
		public static void ReRegistAllMonitors() {} // 0x00000001887CCB44-0x00000001887CCCAC
		public static void CloseAllMonitors() {} // 0x00000001887CAED8-0x00000001887CB040
		public static void ReportLogInfo(string msgType, string msg) {} // 0x00000001887CD504-0x00000001887CD66C
		public static void SetAppVersion(string appVersion) {} // 0x0000000183A24AB0-0x0000000183A24B60
		public static void SetDeviceId(string deviceId) {} // 0x00000001887CE098-0x00000001887CE220
		public static void SetCustomizedDeviceID(string deviceId) {} // 0x00000001887CDDA0-0x00000001887CDF1C
		public static string GetSDKDefinedDeviceID() => default; // 0x00000001887CBA18-0x00000001887CBB94
		public static void SetCustomizedMatchID(string matchId) {} // 0x00000001887CDF1C-0x00000001887CE098
		public static string GetSDKSessionID() => default; // 0x00000001887CBB94-0x00000001887CBD10
		public static string GetCrashUuid() => default; // 0x00000001887CB720-0x00000001887CB89C
		public static void SetDeviceModel(string deviceModel) {} // 0x00000001887CE220-0x00000001887CE39C
		public static void SetLogPath(string logPath) {} // 0x00000001887CEB3C-0x00000001887CECC4
		public static void SetCrashCallback() {} // 0x0000000182CD64F0-0x0000000182CD6560
		public static void UnsetCrashCallback() {} // 0x00000001887D05EC-0x00000001887D073C
		public static void SetCrashLogCallback() {} // 0x0000000182CD6560-0x0000000182CD65D0
		internal static string OnCrashCallbackMessage(int methodId, int crashType) => default; // 0x0000000182D7BB40-0x0000000182D7BCB0
		internal static string OnCrashCallbackData(int methodId, int crashType) => default; // 0x00000001887CC224-0x00000001887CC400
		internal static string OnCrashSetLogPathMessage(int methodId, int crashType) => default; // 0x00000001887CC7D8-0x00000001887CC9BC
		internal static string OnCrashLogUploadMessage(int methodId, int crashType, int result) => default; // 0x00000001887CC5DC-0x00000001887CC7D8
		internal static string OnCrashCallbackNoRet(int methodId, int crashType) => default; // 0x00000001887CC400-0x00000001887CC5DC
		public static void ConfigCallBack() {} // 0x0000000182CD67A0-0x0000000182CD6800
		public static void UnregisterCallBack() {} // 0x00000001887D0598-0x00000001887D05EC
		public static void ConfigLogCallBack() {} // 0x0000000182CD6800-0x0000000182CD6860
		public static void TestOomCrash() {} // 0x00000001887D02C8-0x00000001887D0430
		public static void TestJavaCrash() {} // 0x00000001887CFE88-0x00000001887CFFF0
		public static void TestOcCrash() {} // 0x00000001887D0160-0x00000001887D02C8
		public static void TestNativeCrash() {} // 0x00000001887CFFF0-0x00000001887D0160
		public static void TestANR() {} // 0x00000001887CFD20-0x00000001887CFE88
		public static long GetCrashThreadId() => default; // 0x00000001887CB5CC-0x00000001887CB720
		public static void SetLogcatBufferSize(int size) {} // 0x00000001887CECC4-0x00000001887CEE34
		public static void SetCallbackMsg(string data) {} // 0x00000001887CDA2C-0x00000001887CDBA8
		public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath) {} // 0x00000001887CF78C-0x00000001887CFAE0
		public static void StartMonitorFdCount(int interval, int limit, int dumpType) {} // 0x00000001887CFAE0-0x00000001887CFD20
		public static int getExceptionType(string name) => default; // 0x00000001887D0C30-0x00000001887D0DB0
		public static void TestUseAfterFree() {} // 0x00000001887D0430-0x00000001887D0598
		public static void SetServerEnv(string serverEnv) {} // 0x00000001887CF2D0-0x00000001887CF458
		public static void SetVehEnable(bool enable) {} // 0x00000001887CF458-0x00000001887CF604
		public static void ReportCrash() {} // 0x00000001887CCCAC-0x00000001887CCE1C
		public static void ReportDump(string dump_path, bool is_async) {} // 0x00000001887CCE1C-0x00000001887CCFE8
		public static void SetExtraHandler(bool extra_handle_enable) {} // 0x00000001887CE990-0x00000001887CEB3C
		public static void UploadGivenPathDump(string dump_dir, bool is_extra_check) {} // 0x00000001887D08C4-0x00000001887D0A90
		public static void SetErrorUploadInterval(int interval) {} // 0x00000001887CE820-0x00000001887CE990
		public static void SetErrorUploadEnable(bool enable) {} // 0x00000001887CE698-0x00000001887CE820
		public static void SetRecordFileDir(string record_dir) {} // 0x00000001887CEFB0-0x00000001887CF114
		public static void Init(string app_id, string app_key, string app_version) {} // 0x00000001887CBEB8-0x00000001887CC0D0
		public static void setEnableGetPackageInfo(bool enable) {} // 0x00000001887D1288-0x00000001887D1428
		public static void SetDumpType(int dump_type) {} // 0x00000001887CE39C-0x00000001887CE530
		public static void AddValidExpCode(ulong exp_code) {} // 0x00000001887CA050-0x00000001887CA1E8
		public static void UploadCrashWithGuid(string guid) {} // 0x00000001887D073C-0x00000001887D08C4
		public static void SetCrashUploadEnable(bool enable) {} // 0x00000001887CDBA8-0x00000001887CDD54
		public static void SetWorkSpace(string workspace) {} // 0x00000001887CF604-0x00000001887CF78C
		public static void SetEngineInfo(string version, string buildConfig, string language, string locale) {} // 0x000000018399E800-0x000000018399E9C0
		public static void setCatchMultiSignal(bool enable) {} // 0x00000001887D10E8-0x00000001887D1288
		public static void enableDetailedPageTracing(bool enable) {} // 0x00000001887D0A90-0x00000001887D0C30
		public static void useSavedUserId(bool enable) {} // 0x00000001887D1428-0x00000001887D15D4
		public static void SetCustomAttachDir(string path) {} // 0x00000001887CDD54-0x00000001887CDDA0
		public static bool IsLastSessionCrash() => default; // 0x00000001887CC0D0-0x00000001887CC224
		public static string GetLastSessionUserId() => default; // 0x00000001887CB89C-0x00000001887CBA18
		public static bool CheckFdCount(int limit, int dumpType, bool upload) => default; // 0x00000001887CAC7C-0x00000001887CAED8
		public static void SetOomLogPath(string logPath) {} // 0x00000001887CEE34-0x00000001887CEFB0
		public static void ReportJank(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int reportInfoOption, string jankAttachmentPath) {} // 0x00000001887CD1EC-0x00000001887CD504
		public static void ProcessEngineAnr(int type) {} // 0x00000001887CC9BC-0x00000001887CCB44
		public static void SetEngineMainThread() {} // 0x00000001887CE530-0x00000001887CE698
		public static void ReportStuck(int threadId, int maxChecks, long checkInterval, string name, string message, Dictionary<string, string> extInfo, int dumpNativeType, string attachPath) {} // 0x00000001887CD66C-0x00000001887CDA2C
	}

	public enum UQMMethodNameID // TypeDefIndex: 58704
	{
		UQM_CRASH_CALLBACK_EXTRA_DATA = 1011,
		UQM_CRASH_CALLBACK_EXTRA_MESSAGE = 1012,
		UQM_CRASH_CALLBACK_SET_LOG_PATH = 1013,
		UQM_CRASH_CALLBACK_LOG_UPLOAD_RESULT = 1014
	}

	internal class UQMLog // TypeDefIndex: 58706
	{
		// Fields
		private static Level level; // 0x00
		private const string header = "[CrashSightPlugin-Unity]"; // Metadata: 0x01FDB88A
	
		// Nested types
		public enum Level // TypeDefIndex: 58705
		{
			None = 0,
			Log = 1,
			Warning = 2,
			Error = 3
		}
	
		// Constructors
		public UQMLog() {} // 0x000000018350B670-0x000000018350B680
		static UQMLog() {} // 0x0000000183D438A0-0x0000000183D438E0
	
		// Methods
		public static void SetLevel(Level l) {} // 0x00000001887D1870-0x00000001887D18C4
		public static void Log(string message) {} // 0x0000000182D7CCB0-0x0000000182D7CD30
		public static void LogWarning(string message) {} // 0x00000001887D17E0-0x00000001887D1870
		public static void LogError(string message) {} // 0x00000001887D1750-0x00000001887D17E0
		public static void FullLog(string message) {} // 0x00000001887D15D4-0x00000001887D1750
	}

	public class RetArgsWrapper // TypeDefIndex: 58707
	{
		// Fields
		private readonly int methodId; // 0x10
		private readonly int crashType; // 0x14
		private readonly int logUploadResult; // 0x18
	
		// Properties
		public int MethodId { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public int CrashType { get => default; } // 0x0000000183D50CC0-0x0000000183D50CD0 
		public int LogUploadResult { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Constructors
		public RetArgsWrapper() {} // Dummy constructor
		public RetArgsWrapper(int _methodId, int _crashType, int _logUploadResult) {} // 0x0000000183D51130-0x0000000183D51140
	}

	public class UQMMessageCenter : MonoBehaviour // TypeDefIndex: 58709
	{
		// Fields
		private static bool initialzed; // 0x00
		private static UQMMessageCenter instance; // 0x08
	
		// Properties
		public static UQMMessageCenter Instance { get => default; } // 0x0000000182CD68B0-0x0000000182CD6AE0 
	
		// Nested types
		private delegate string UQMRetJsonEventHandler(int methodId, int callType, int logUploadResult); // TypeDefIndex: 58708; 0x0000000181035ED0-0x0000000181035EF0
	
		// Constructors
		public UQMMessageCenter() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[AOT.MonoPInvokeCallback(typeof(UQMRetJsonEventHandler))]
		public static string OnUQMRet(int methodId, int crashType, int logUploadResult) => default; // 0x0000000182D7B320-0x0000000182D7B9E0
		private static extern void cs_setUnityCallback(UQMRetJsonEventHandler eventHandler); // 0x00000001822C6F10-0x00000001822C6FA0
		public void Init() {} // 0x0000000182CD5F80-0x0000000182CD6070
		public void Uninit() {} // 0x00000001887D18C4-0x00000001887D1918
		private static string SynchronousDelegate(object arg) => default; // 0x0000000182D7B9E0-0x0000000182D7BB40
	}
}

namespace GCloud.UQM.MiniJSON
{
	public static class Json // TypeDefIndex: 58713
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 58711
		{
			// Fields
			private const string WORD_BREAK = "{}[],:\""; // Metadata: 0x01FDB8A7
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get => default; } // 0x00000001887C8E9C-0x00000001887C8EF8 
			private char NextChar { get => default; } // 0x00000001887C8B6C-0x00000001887C8BC8 
			private string NextWord { get => default; } // 0x00000001887C8DEC-0x00000001887C8E9C 
			private TOKEN NextToken { get => default; } // 0x00000001887C8BC8-0x00000001887C8DEC 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 58710
			{
				NONE = 0,
				CURLY_OPEN = 1,
				CURLY_CLOSE = 2,
				SQUARED_OPEN = 3,
				SQUARED_CLOSE = 4,
				COLON = 5,
				COMMA = 6,
				STRING = 7,
				NUMBER = 8,
				TRUE = 9,
				FALSE = 10,
				NULL = 11
			}
	
			// Constructors
			public Parser() {} // Dummy constructor
			private Parser(string jsonString) {} // 0x00000001887C8AF4-0x00000001887C8B6C
	
			// Methods
			public static bool IsWordBreak(char c) => default; // 0x00000001887C83E8-0x00000001887C8460
			public static object Parse(string jsonString) => default; // 0x00000001887C89FC-0x00000001887C8AF4
			public void Dispose() {} // 0x00000001887C8320-0x00000001887C8358
			private Dictionary<string, object> ParseObject() => default; // 0x00000001887C86A0-0x00000001887C87AC
			private List<object> ParseArray() => default; // 0x00000001887C8460-0x00000001887C8528
			private object ParseValue() => default; // 0x00000001887C89D8-0x00000001887C89FC
			private object ParseByToken(TOKEN token) => default; // 0x00000001887C8528-0x00000001887C85DC
			private string ParseString() => default; // 0x00000001887C87AC-0x00000001887C89D8
			private object ParseNumber() => default; // 0x00000001887C85DC-0x00000001887C86A0
			private void EatWhitespace() {} // 0x00000001887C8358-0x00000001887C83E8
		}
	
		private sealed class Serializer // TypeDefIndex: 58712
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer() {} // 0x00000001887C9D20-0x00000001887C9D84
	
			// Methods
			public static string Serialize(object obj) => default; // 0x00000001887C9CA8-0x00000001887C9D20
			private void SerializeValue(object value) {} // 0x00000001887C9B24-0x00000001887C9CA8
			private void SerializeObject(IDictionary obj) {} // 0x00000001887C927C-0x00000001887C9684
			private void SerializeArray(IList anArray) {} // 0x00000001887C8EF8-0x00000001887C927C
			private void SerializeString(string str) {} // 0x00000001887C98AC-0x00000001887C9B24
			private void SerializeOther(object value) {} // 0x00000001887C9684-0x00000001887C98AC
		}
	
		// Methods
		public static object Deserialize(string json) => default; // 0x00000001887C81EC-0x00000001887C8208
		public static string Serialize(object obj) => default; // 0x00000001887C8208-0x00000001887C8210
	}
}
