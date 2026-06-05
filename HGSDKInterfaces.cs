/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using UnityEngine;

// Image 71: HGSDKInterfaces.dll - Assembly: HGSDKInterfaces, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59705-59738

public enum CSLogSeverity // TypeDefIndex: 59706
{
	LogSilent = 0,
	LogError = 1,
	LogWarning = 2,
	LogInfo = 3,
	LogDebug = 4,
	LogVerbose = 5
}

public enum CSReportType // TypeDefIndex: 59707
{
	InterfaceReport = 0,
	LogCallback = 1,
	LogCallbackThreaded = 2
}

public enum JankReportInfoOption // TypeDefIndex: 59708
{
	JankOnlyBasicInfo = 0,
	JankSystemLog = 1,
	JankCustomLog = 2,
	JankCustomKv = 4,
	JankCallbackInfo = 8,
	JankAutoDumpStack = 16,
	JankAndroidAllJavaStack = 32
}

public sealed class CrashSightAgent // TypeDefIndex: 59713
{
	// Fields
	private static HGCrashSightCallback _crashSightCallback; // 0x00
	private static HGCrashSightLogCallback _crashSightLogCallback; // 0x08
	private static string crashUploadUrl; // 0x10
	public static List<int> callbackThreads; // 0x18
	public static object callbackThreadsLock; // 0x20
	private static LogCallbackDelegate _LogCallbackEventHandler; // 0x28
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
	public static string[] s_vmas; // 0xD0

	// Properties
	public static bool AutoQuitApplicationAfterReport { get => default; } // 0x000000018A8D8CCC-0x000000018A8D8D0C 
	public static bool IsInitialized { get => default; } // 0x000000018A8D8D0C-0x000000018A8D8D4C 

	// Events
	private static event LogCallbackDelegate _LogCallbackEventHandler;

	// Nested types
	private class HGCrashSightCallback : CrashSightCallback // TypeDefIndex: 59709
	{
		// Constructors
		public HGCrashSightCallback() {} // 0x000000018A8DB1A0-0x000000018A8DB274

		// Methods
		public override string OnCrashBaseRetEvent(int methodId, int crashType) => default; // 0x000000018A8DAF08-0x000000018A8DAFDC
	}

	private class HGCrashSightLogCallback : CrashSightLogCallback // TypeDefIndex: 59710
	{
		// Constructors
		public HGCrashSightLogCallback() {} // 0x000000018A8D95B8-0x000000018A8D9714

		// Methods
		public override string OnSetLogPathEvent(int methodId, int crashType) => default; // 0x000000018A8D9D18-0x000000018A8D9D78
		public override void OnLogUploadResultEvent(int methodId, int crashType, int result) {} // 0x0000000184A11A60-0x0000000184A11BB0
	}

	public delegate void LogCallbackDelegate(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 59711; 0x000000018A8D9504-0x000000018A8D95B8

	public delegate bool LogFilterDelegate(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 59712; 0x00000001843D5E90-0x00000001843D5F10

	// Constructors
	public CrashSightAgent() {} // 0x000000018A8DC698-0x000000018A8DC720
	static CrashSightAgent() {} // 0x00000001864BBBD0-0x00000001864BBD00

	// Methods
	public static void SetLogFilter(LogFilterDelegate filter) {} // 0x0000000185C05290-0x0000000185C05380
	public static void InitWithAppId(string appId, bool forceOnUiThread = false /* Metadata: 0x02081147 */) {} // 0x000000018A8D99D8-0x000000018A8D9A24
	public static void ReportException(Exception e, string message) {} // 0x000000018A8D8868-0x000000018A8D88B0
	public static void ReportException(string name, string message, string stackTrace) {} // 0x000000018A8D8820-0x000000018A8D8868
	public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0 /* Metadata: 0x02081148 */, string errorAttachmentPath = "" /* Metadata: 0x02081149 */) {} // 0x00000001843D5980-0x00000001843D5A10
	public static void SetUserId(string userId) {} // 0x000000018A8DA320-0x000000018A8DA3A4
	public static void AddSceneData(string key, string value) {} // 0x000000018A8D9AB8-0x000000018A8D9B04
	public static void SetUserValue(string key, int value) {} // 0x000000018A8D8A8C-0x000000018A8D8AD4
	public static void SetUserValue(string key, string value) {} // 0x000000018A8D8A4C-0x000000018A8D8A8C
	public static void SetUserValue(string key, string[] value) {} // 0x0000000184A11C90-0x0000000184A11D50
	public static void SetAppVersion(string appVersion) {} // 0x000000018A8DA530-0x000000018A8DA570
	public static void ConfigCrashServerUrl(string crashServerUrl) {} // 0x0000000184A11D50-0x0000000184A11E60
	public static void SetLogPath(string logPath) {} // 0x000000018A8D8AD4-0x000000018A8D8B64
	public static void ConfigDebugMode(bool enable) {} // 0x000000018A8D921C-0x000000018A8D92AC
	public static void SetDeviceId(string deviceId) {} // 0x000000018A8DA570-0x000000018A8DA5D4
	public static void ConfigCrashReporter(int logLevel) {} // 0x000000018A8D9C60-0x000000018A8D9D18
	public static void ConfigCrashReporter(CSLogSeverity logLevel) {} // 0x000000018A8D8784-0x000000018A8D87D8
	public static void PrintLog(CSLogSeverity level, string format, object[] args) {} // 0x000000018A8DB100-0x000000018A8DB150
	public static void TestNativeCrash() {} // 0x00000001843D6110-0x00000001843D61A0
	public static void SetEnvironmentName(string serverEnv) {} // 0x000000018A8DB150-0x000000018A8DB1A0
	public static void EnableAnrMonitor(int timeoutMs = 5000 /* Metadata: 0x0208114A */) {} // 0x0000000184A8F340-0x0000000184A8F5E0
	public static void DisableAnrMonitor() {} // 0x000000018A8DAD38-0x000000018A8DAF08
	public static void RegisterCrashCallback(CrashSightCallback callback) {} // 0x0000000185492010-0x0000000185492020
	public static void UnregisterCrashCallback() {} // 0x000000018A8D87D8-0x000000018A8D8820
	public static void RegisterCrashLogCallback(CrashSightLogCallback callback) {} // 0x000000018A8D9A24-0x000000018A8D9A70
	public static void EnableExceptionHandler() {} // 0x000000018A8D97A8-0x000000018A8D9804
	public static void RegisterLogCallback(LogCallbackDelegate handler) {} // 0x000000018A8D9ED0-0x000000018A8D9FC8
	public static void UnregisterLogCallback(LogCallbackDelegate handler) {} // 0x000000018A8D9FC8-0x000000018A8DA028
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler) {} // 0x000000018A8D8B64-0x000000018A8D8BF0
	public static void ConfigAutoQuitApplication(bool autoQuit) {} // 0x000000018A8D9940-0x000000018A8D998C
	public static void DebugLog(string tag, string format) {} // 0x000000018A8D998C-0x000000018A8D99D8
	public static void _RegisterExceptionHandler() {} // 0x000000018A8DA428-0x000000018A8DA4AC
	public static void _UnregisterExceptionHandler() {} // 0x000000018A8DA29C-0x000000018A8DA320
	public static void SetCrashSightStackTraceEnable(bool enable) {} // 0x000000018A8DA218-0x000000018A8DA29C
	public static void ConfigCallbackType(int callbackType) {} // 0x000000018A8D8BF0-0x000000018A8D8C30
	public static void SetDeviceModel(string deviceModel) {} // 0x000000018A8D9DC4-0x000000018A8D9E0C
	public static void ReportLogInfo(string msgType, string msg) {} // 0x000000018A8DA3A4-0x000000018A8DA428
	public static void SetScene(string sceneId, bool upload = false /* Metadata: 0x0208114C */) {} // 0x000000018A8DA0E8-0x000000018A8DA198
	public static void SetScene(int sceneId, bool upload = false /* Metadata: 0x0208114D */) {} // 0x000000018A8DA198-0x000000018A8DA218
	public static long GetCrashThreadId() => default; // 0x000000018A8DB094-0x000000018A8DB100
	public static void SetCustomizedDeviceID(string deviceId) {} // 0x000000018A8DA4AC-0x000000018A8DA530
	public static string GetSDKDefinedDeviceID() => default; // 0x000000018A8D919C-0x000000018A8D921C
	public static void SetCustomizedMatchID(string matchId) {} // 0x000000018A8D8718-0x000000018A8D8784
	public static string GetSDKSessionID() => default; // 0x000000018A8DB32C-0x000000018A8DB3E4
	public static void TestOomCrash() {} // 0x000000018A8DB274-0x000000018A8DB32C
	public static void TestJavaCrash() {} // 0x000000018A8DAFDC-0x000000018A8DB094
	public static void TestANR() {} // 0x000000018A8D9114-0x000000018A8D919C
	public static string GetCrashUuid() => default; // 0x000000018A8D8C30-0x000000018A8D8CCC
	public static void SetLogcatBufferSize(int size) {} // 0x000000018A8D8694-0x000000018A8D8718
	public static void TestOcCrash() {} // 0x000000018A8D9E0C-0x000000018A8D9E58
	public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath) {} // 0x000000018A8D9714-0x000000018A8D97A8
	public static void StartMonitorFdCount(int interval, int limit, int dumpType) {} // 0x000000018A8D9804-0x000000018A8D98A8
	public static int getExceptionType(string name) => default; // 0x000000018A8DA028-0x000000018A8DA09C
	public static void TestUseAfterFree() {} // 0x000000018A8D92AC-0x000000018A8D9318
	public static void ReRegistAllMonitors() {} // 0x000000018A8D9318-0x000000018A8D939C
	public static void CloseAllMonitors() {} // 0x000000018A8D9BEC-0x000000018A8D9C60
	public static void setEnableGetPackageInfo(bool enable) {} // 0x000000018A8DA620-0x000000018A8DA6A4
	public static void setCatchMultiSignal(bool enable) {} // 0x000000018A8D9A70-0x000000018A8D9AB8
	public static void enableDetailedPageTracing(bool enable) {} // 0x000000018A8D8648-0x000000018A8D8694
	public static bool IsLastSessionCrash() => default; // 0x000000018A8DA5D4-0x000000018A8DA620
	public static string GetLastSessionUserId() => default; // 0x000000018A8D98A8-0x000000018A8D98F4
	public static bool CheckFdCount(int limit, int dumpType, bool upload) => default; // 0x000000018A8DA09C-0x000000018A8DA0E8
	public static void SetOomLogPath(string logPath) {} // 0x000000018A8D98F4-0x000000018A8D9940
	public static void ReportJank(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int reportInfoOption, string jankAttachmentPath) {} // 0x000000018A8D9B78-0x000000018A8D9BEC
	public static void ReportStuck(int threadId, int maxChecks, long checkInterval, string name, string message, Dictionary<string, string> extInfo, int dumpNativeType, string attachPath) {} // 0x000000018A8D9B04-0x000000018A8D9B78
	public static void SetVehEnable(bool enable) {} // 0x000000018A8D9E58-0x000000018A8D9ED0
	public static void ReportCrash() {} // 0x000000018A8D8D4C-0x000000018A8D8F2C
	public static void ReportDump(string dump_path, bool is_async) {} // 0x000000018A8D8F2C-0x000000018A8D9114
	public static void SetExtraHandler(bool extra_handle_enable) {} // 0x000000018A8D88B0-0x000000018A8D8A4C
	public static void UploadGivenPathDump(string dump_dir, bool is_extra_check) {} // 0x0000000185F4F330-0x0000000185F4F3B0
	public static void SetDumpType(int dump_type) {} // 0x0000000185EFA420-0x0000000185EFA4A0
	public static void AddValidExpCode(ulong exp_code) {} // 0x00000001843D5360-0x00000001843D55D0
	public static void UploadCrashWithGuid(string guid) {} // 0x000000018A8DAB7C-0x000000018A8DAD38
	public static void SetCrashUploadEnable(bool enable) {} // 0x000000018A8DA6A4-0x000000018A8DAB7C
	public static void SetWorkSpace(string workspace) {} // 0x00000001843D7DE0-0x00000001843D7F00
	public static void SetCustomAttachDir(string path) {} // 0x00000001843D6640-0x00000001843D7DE0
	public static void SetErrorUploadInterval(int interval) {} // 0x00000001843D5B40-0x00000001843D5E90
	public static void SetErrorUploadEnable(bool enable) {} // 0x0000000185492010-0x0000000185492020
	public static void SetRecordFileDir(string record_dir) {} // 0x00000001843D64C0-0x00000001843D6580
	public static void InitContext(string userId, string version, string key) {} // 0x00000001843D6430-0x00000001843D64C0
	public static void Init(string app_id, string app_key, string app_version) {} // 0x00000001843D55D0-0x00000001843D5980
	public static void ConfigDefault(string channel, string version, string user, long delay) {} // 0x0000000185492010-0x0000000185492020
	private static void _OnLogCallbackHandlerMain(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x0000000183FC3200-0x0000000183FC5110
	private static void _OnLogCallbackHandlerThreaded(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x00000001843D6580-0x00000001843D6640
	private static void _OnLogCallbackHandler(string condition, string stackTrace, UnityEngine.LogType type, CSReportType rType) {} // 0x0000000185492010-0x0000000185492020
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args) {} // 0x000000018A8DC53C-0x000000018A8DC5EC
	private static void _HandleException(Exception e, string message, bool uncaught) {} // 0x000000018A8DC3DC-0x000000018A8DC53C
	private static bool ShouldSkipFrame(string frame) => default; // 0x0000000185492010-0x0000000185492020
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace) {} // 0x00000001876E3384-0x00000001876E3458
	private static void AddTrackCustomData() {} // 0x0000000181A578C0-0x0000000181A578E0
	private static void AddLocalLogFile() {} // 0x000000018A8DC610-0x000000018A8DC698
	private static int valueOf(UnityEngine.LogType logLevel) => default; // 0x00000001864BB614-0x00000001864BB734
	private static bool isEnableAutoReport(UnityEngine.LogType logLevel) => default; // 0x0000000185F19010-0x0000000185F190A0
	private static void _HandleException(UnityEngine.LogType logLevel, string name, string message, string stackTrace, bool uncaught, CSReportType rType) {} // 0x00000001817E31E0-0x00000001817E3200
}

public class CrashSightAnrMonitor // TypeDefIndex: 59716
{
	// Fields
	private static CrashSightMonoBehaviour monoBehaviour; // 0x00
	private static int anrTimeoutMs; // 0x08
	private static int detectionTimeoutMs; // 0x0C
	private static bool _Paused_k__BackingField; // 0x10
	private static int ticksSinceUiUpdate; // 0x14
	private static bool reported; // 0x18
	private static bool running; // 0x19
	private static Thread thread; // 0x20

	// Properties
	protected static bool Paused { get; private set; } // 0x000000018A8DE184-0x000000018A8DE1C4 0x000000018A8DE1C4-0x000000018A8DE204

	// Nested types
	[Serializable]
	private sealed class __c // TypeDefIndex: 59714
	{
		// Fields
		public static readonly __c __9; // 0x00
		public static Action __9__11_0; // 0x08
		public static Action __9__11_1; // 0x10
		public static Action __9__11_2; // 0x18

		// Constructors
		static __c() {} // 0x000000018A8DBCF4-0x000000018A8DBD44
		public __c() {} // 0x000000018A8DBD44-0x000000018A8DBD98

		// Methods
		internal void _Start_b__11_0() {} // 0x000000018A8DB70C-0x000000018A8DBBA4
		internal void _Start_b__11_1() {} // 0x000000018A8DBBA4-0x000000018A8DBBF4
		internal void _Start_b__11_2() {} // 0x000000018A8DBBF4-0x000000018A8DBC38
	}

	private sealed class _UpdateUiStatus_d__13 : IEnumerator<object> // TypeDefIndex: 59715
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		private WaitForSecondsRealtime _waitForSeconds_5__2; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { get => default; } // 0x000000018A8DBC38-0x000000018A8DBCF4 
		object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 

		// Constructors
		public _UpdateUiStatus_d__13() {} // Dummy constructor
		public _UpdateUiStatus_d__13(int __1__state) {} // 0x000000018A8DB4B0-0x000000018A8DB70C

		// Methods
		void IDisposable.Dispose() {} // 0x000000018A8DB3E4-0x000000018A8DB4B0
		private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
		void IEnumerator.Reset() {} // 0x000000018A8DE244-0x000000018A8DE2A8
	}

	// Constructors
	public CrashSightAnrMonitor() {} // 0x000000018A8DE404-0x000000018A8DE450
	static CrashSightAnrMonitor() {} // 0x0000000181377E40-0x0000000181377E50

	// Methods
	public static void Start(int timeoutMs = 5000 /* Metadata: 0x0208114E */) {} // 0x000000018A8DE204-0x000000018A8DE244
	public static void Stop() {} // 0x0000000181378230-0x0000000181378240
	private static IEnumerator UpdateUiStatus() => default; // 0x0000000185492010-0x0000000185492020
	private static void Run() {} // 0x000000018A8DE2A8-0x000000018A8DE404
	private static void Report() {} // 0x0000000181377E40-0x0000000181377E50
}

public class UnityAnrException : Exception // TypeDefIndex: 59717
{
	// Constructors
	internal UnityAnrException() {} // 0x000000018A8E5F08-0x000000018A8E5F54
	internal UnityAnrException(string message) {} // 0x000000018A8E5EAC-0x000000018A8E5F08
	internal UnityAnrException(string message, Exception innerException) {} // 0x000000018A8E5F54-0x000000018A8E6004
}

public abstract class CrashSightCallback // TypeDefIndex: 59718
{
	// Constructors
	protected CrashSightCallback() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public abstract string OnCrashBaseRetEvent(int methodId, int crashType);
}

public abstract class CrashSightLogCallback // TypeDefIndex: 59719
{
	// Constructors
	protected CrashSightLogCallback() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public abstract string OnSetLogPathEvent(int methodId, int crashType);
	public abstract void OnLogUploadResultEvent(int methodId, int crashType, int result);
}

public class CrashSightMonoBehaviour : MonoBehaviour // TypeDefIndex: 59720
{
	// Fields
	private static CrashSightMonoBehaviour _instance; // 0x00
	private Action ApplicationResuming; // 0x18
	private Action ApplicationPausing; // 0x20
	private Action ApplicationQuitting; // 0x28
	internal bool _isRunning; // 0x30

	// Properties
	public static CrashSightMonoBehaviour Instance { get => default; } // 0x000000018A8DC054-0x000000018A8DC174 

	// Events
	public event Action ApplicationResuming;
	public event Action ApplicationPausing;
	public event Action ApplicationQuitting;

	// Constructors
	public CrashSightMonoBehaviour() {} // 0x000000018A8DBE8C-0x000000018A8DBE98

	// Methods
	public void UpdatePauseStatus(bool paused) {} // 0x000000018A8DBE58-0x000000018A8DBE8C
	internal void OnApplicationPause(bool pauseStatus) {} // 0x000000018A8DBDF4-0x000000018A8DBDFC
	internal void OnApplicationFocus(bool hasFocus) {} // 0x000000018A8DBDE8-0x000000018A8DBDF4
	private void OnApplicationQuit() {} // 0x000000018A8DBDFC-0x000000018A8DBE58
	private void Awake() {} // 0x000000018A8DBD98-0x000000018A8DBDE8
}

public class CrashSightStackTrace // TypeDefIndex: 59721
{
	// Fields
	public static bool enable; // 0x00
	private static string stackTrace; // 0x08

	// Constructors
	public CrashSightStackTrace() {} // 0x0000000185492010-0x0000000185492020

	// Methods
	public static void setEnable(bool enable) {} // 0x0000000185492010-0x0000000185492020
	public static string ExtractStackTrace() => default; // 0x000000018A8DC330-0x000000018A8DC3DC
}

namespace GCloud.UQM
{
	public delegate void OnUQMRetEventHandler<T>(T ret); // TypeDefIndex: 59722; 0x00000000-0x00000000

	public delegate string OnUQMStringRetEventHandler<T>(T ret, T crashType); // TypeDefIndex: 59723; 0x00000000-0x00000000

	public delegate string OnUQMStringRetSetLogPathEventHandler<T>(T ret, T crashType); // TypeDefIndex: 59724; 0x00000000-0x00000000

	public delegate void OnUQMRetLogUploadEventHandler<T>(T ret, T crashType, T result); // TypeDefIndex: 59725; 0x00000000-0x00000000

	public class UQM // TypeDefIndex: 59726
	{
		// Fields
		public const string LibName = "CrashSight64"; // Metadata: 0x02081150
		private static bool initialized; // 0x00
		public static bool isDebug; // 0x01
	
		// Constructors
		public UQM() {} // 0x0000000185492010-0x0000000185492020
		static UQM() {} // 0x000000018A8E5E74-0x000000018A8E5EAC
	
		// Methods
		public static void Init() {} // 0x000000018A8E5DB0-0x000000018A8E5E74
	}

	public enum UQMCrashLevel // TypeDefIndex: 59727
	{
		CSLogLevelSilent = 0,
		CSLogLevelError = 1,
		CSLogLevelWarn = 2,
		CSLogLevelInfo = 3,
		CSLogLevelDebug = 4,
		CSLogLevelVerbose = 5
	}

	public static class UQMCrash // TypeDefIndex: 59728
	{
		// Fields
		private static OnUQMStringRetEventHandler<int> CrashBaseRetEvent; // 0x00
		private static OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent; // 0x08
		private static OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent; // 0x10
		private static AndroidJavaClass _gameAgentClass; // 0x18
		private static bool _isLoadedSo; // 0x20
		private static int _gameType; // 0x24
		private static readonly string GAME_AGENT_CLASS; // 0x28
	
		// Properties
		public static AndroidJavaClass CrashSightPlatform { get; } // 0x000000018A8E51B0-0x000000018A8E5294 
	
		// Events
		public static event OnUQMStringRetEventHandler<int> CrashBaseRetEvent;
		public static event OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent;
		public static event OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent;
	
		// Constructors
		static UQMCrash() {} // 0x0000000185F0DB40-0x0000000185F0DBF0
	
		// Methods
		private static extern void CS_InitContext(string id, string version, string key); // 0x000000018A8DE6D8-0x000000018A8DE7A8
		private static extern void CS_ReportExceptionW(int type, string name, string message, string stack_trace, string extras, bool is_async, string attachmentPath = "" /* Metadata: 0x02081163 */); // 0x00000001843D32F0-0x00000001843D33F0
		private static extern void CS_SetUserValue(string key, string value); // 0x00000001843D6300-0x00000001843D6380
		private static extern void CS_SetVehEnable(bool enable); // 0x000000018A8DED84-0x000000018A8DEDFC
		private static extern void CS_SetExtraHandler(bool extra_handle_enable); // 0x000000018A8DED50-0x000000018A8DED84
		private static extern void CS_SetCustomLogDirW(string log_path); // 0x000000018A8DEB40-0x000000018A8DEBC0
		private static extern void CS_SetUserId(string user_id); // 0x00000001843D48A0-0x00000001843D48F0
		private static extern void CS_MonitorEnable(bool enable); // 0x000000018A8DE7A8-0x000000018A8DE820
		private static extern void CS_PrintLog(int level, string tag, string format, string arg); // 0x00000001843D6380-0x00000001843D6430
		private static extern void CS_UploadGivenPathDump(string dump_dir, bool is_extra_check); // 0x000000018A8DEF70-0x000000018A8DF004
		private static extern void CS_ReportCrash(); // 0x000000018A8DE820-0x000000018A8DE888
		private static extern void CS_ReportDump(string dump_dir, bool is_async); // 0x000000018A8DE888-0x000000018A8DE91C
		private static extern void CS_SetEnvironmentName(string name); // 0x000000018A8DECC4-0x000000018A8DED50
		private static extern void CS_InitWithAppId(string app_id); // 0x0000000184A11510-0x0000000184A11570
		private static extern void CS_SetAppVersion(string app_version); // 0x0000000185C28AE0-0x0000000185C28B40
		private static extern void CS_ConfigCrashServerUrl(string crash_server_url); // 0x00000001844CECB0-0x00000001844CED50
		private static extern void CS_ConfigDebugMode(bool enable); // 0x00000001844CF3F0-0x00000001844CF430
		private static extern void CS_SetDeviceId(string device_id); // 0x000000018A8DEBC0-0x000000018A8DEC4C
		private static extern void CS_ConfigCrashReporter(int log_level); // 0x000000018A8DE660-0x000000018A8DE6D8
		private static extern void CS_TestNativeCrash(); // 0x000000018A8DEE7C-0x000000018A8DEEE4
		private static extern void CS_SetDumpType(int dump_type); // 0x000000018A8DEC4C-0x000000018A8DECC4
		private static extern void CS_AddValidExpCode(ulong exp_code); // 0x000000018A8DE5E8-0x000000018A8DE660
		private static extern void CS_UploadCrashWithGuid(string guid); // 0x000000018A8DEEE4-0x000000018A8DEF70
		private static extern void CS_SetCrashUploadEnable(bool enable); // 0x000000018A8DEA48-0x000000018A8DEAC0
		private static extern void CS_SetWorkSpaceW(string workspace); // 0x000000018A8DEDFC-0x000000018A8DEE7C
		private static extern void CS_SetEngineInfo(string version, string buildConfig, string language, string locale); // 0x00000001844CEA90-0x00000001844CEBA0
		private static extern void CS_SetCustomAttachDirW(string log_path); // 0x000000018A8DEAC0-0x000000018A8DEB40
		private static extern void CS_UseSavedUserId(bool enable); // 0x000000018A8DF004-0x000000018A8DF07C
		private static extern void CS_ReportStuck(int threadId, int maxChecks, int checkInterval, string name, string message, string extraInfo, int dumpNativeType, string attachPath); // 0x000000018A8DE91C-0x000000018A8DEA48
		private static void LoadCrashSightCoreSo() {} // 0x0000000185492010-0x0000000185492020
		public static void ConfigCallbackType(int callbackType) {} // 0x000000018A8DF5D4-0x000000018A8DF75C
		public static void ConfigGameType(int gameType) {} // 0x0000000184A11570-0x0000000184A11640
		public static void ConfigAutoReportLogLevel(int level) {} // 0x000000018A8DF440-0x000000018A8DF5D4
		public static void ConfigCrashServerUrl(string serverUrl) {} // 0x0000000185D29E80-0x0000000185D29F30
		public static void ConfigDebugMode(bool enable) {} // 0x0000000185C05380-0x0000000185C05470
		public static void ConfigDefault(string channel, string version, string user, long delay) {} // 0x000000018A8DF75C-0x000000018A8DF9CC
		public static void InitWithAppId(string appId, bool forceOnUiThread) {} // 0x0000000184A11420-0x0000000184A11510
		public static void InitContext(string userId, string version, string key) {} // 0x000000018A8E0110-0x000000018A8E02B8
		public static void LogRecord(int level, string message) {} // 0x00000001843D5A10-0x00000001843D5B40
		public static void AddSceneData(string k, string v) {} // 0x00000001843D61A0-0x00000001843D6280
		public static void ReportException(int type, string name, string message, string stackTrace, string extras, bool quitProgram) {} // 0x00000001843D45B0-0x00000001843D4720
		public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0 /* Metadata: 0x02081164 */, string errorAttachmentPath = "" /* Metadata: 0x02081165 */) {} // 0x000000018A8E13E8-0x000000018A8E15EC
		public static void SetUserId(string userId) {} // 0x00000001843D47E0-0x00000001843D48A0
		public static void SetScene(string sceneId, bool upload) {} // 0x000000018A8E3514-0x000000018A8E36D0
		public static void ReRegistAllMonitors() {} // 0x000000018A8E0F44-0x000000018A8E10AC
		public static void CloseAllMonitors() {} // 0x000000018A8DF2D8-0x000000018A8DF440
		public static void ReportLogInfo(string msgType, string msg) {} // 0x000000018A8E1904-0x000000018A8E1A6C
		public static void SetAppVersion(string appVersion) {} // 0x0000000185C28A30-0x0000000185C28AE0
		public static void SetDeviceId(string deviceId) {} // 0x000000018A8E2498-0x000000018A8E2620
		public static void SetCustomizedDeviceID(string deviceId) {} // 0x000000018A8E21A0-0x000000018A8E231C
		public static string GetSDKDefinedDeviceID() => default; // 0x000000018A8DFE18-0x000000018A8DFF94
		public static void SetCustomizedMatchID(string matchId) {} // 0x000000018A8E231C-0x000000018A8E2498
		public static string GetSDKSessionID() => default; // 0x000000018A8DFF94-0x000000018A8E0110
		public static string GetCrashUuid() => default; // 0x000000018A8DFB20-0x000000018A8DFC9C
		public static void SetDeviceModel(string deviceModel) {} // 0x000000018A8E2620-0x000000018A8E279C
		public static void SetLogPath(string logPath) {} // 0x000000018A8E2F3C-0x000000018A8E30C4
		public static void SetCrashCallback() {} // 0x0000000184A11BB0-0x0000000184A11C20
		public static void UnsetCrashCallback() {} // 0x000000018A8E49EC-0x000000018A8E4B3C
		public static void SetCrashLogCallback() {} // 0x0000000184A11C20-0x0000000184A11C90
		internal static string OnCrashCallbackMessage(int methodId, int crashType) => default; // 0x00000001843D5110-0x00000001843D5280
		internal static string OnCrashCallbackData(int methodId, int crashType) => default; // 0x000000018A8E0624-0x000000018A8E0800
		internal static string OnCrashSetLogPathMessage(int methodId, int crashType) => default; // 0x000000018A8E0BD8-0x000000018A8E0DBC
		internal static string OnCrashLogUploadMessage(int methodId, int crashType, int result) => default; // 0x000000018A8E09DC-0x000000018A8E0BD8
		internal static string OnCrashCallbackNoRet(int methodId, int crashType) => default; // 0x000000018A8E0800-0x000000018A8E09DC
		public static void ConfigCallBack() {} // 0x0000000184A11E60-0x0000000184A11EC0
		public static void UnregisterCallBack() {} // 0x000000018A8E4998-0x000000018A8E49EC
		public static void ConfigLogCallBack() {} // 0x0000000184A11EC0-0x0000000184A11F20
		public static void TestOomCrash() {} // 0x000000018A8E46C8-0x000000018A8E4830
		public static void TestJavaCrash() {} // 0x000000018A8E4288-0x000000018A8E43F0
		public static void TestOcCrash() {} // 0x000000018A8E4560-0x000000018A8E46C8
		public static void TestNativeCrash() {} // 0x000000018A8E43F0-0x000000018A8E4560
		public static void TestANR() {} // 0x000000018A8E4120-0x000000018A8E4288
		public static long GetCrashThreadId() => default; // 0x000000018A8DF9CC-0x000000018A8DFB20
		public static void SetLogcatBufferSize(int size) {} // 0x000000018A8E30C4-0x000000018A8E3234
		public static void SetCallbackMsg(string data) {} // 0x000000018A8E1E2C-0x000000018A8E1FA8
		public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath) {} // 0x000000018A8E3B8C-0x000000018A8E3EE0
		public static void StartMonitorFdCount(int interval, int limit, int dumpType) {} // 0x000000018A8E3EE0-0x000000018A8E4120
		public static int getExceptionType(string name) => default; // 0x000000018A8E5030-0x000000018A8E51B0
		public static void TestUseAfterFree() {} // 0x000000018A8E4830-0x000000018A8E4998
		public static void SetServerEnv(string serverEnv) {} // 0x000000018A8E36D0-0x000000018A8E3858
		public static void SetVehEnable(bool enable) {} // 0x000000018A8E3858-0x000000018A8E3A04
		public static void ReportCrash() {} // 0x000000018A8E10AC-0x000000018A8E121C
		public static void ReportDump(string dump_path, bool is_async) {} // 0x000000018A8E121C-0x000000018A8E13E8
		public static void SetExtraHandler(bool extra_handle_enable) {} // 0x000000018A8E2D90-0x000000018A8E2F3C
		public static void UploadGivenPathDump(string dump_dir, bool is_extra_check) {} // 0x000000018A8E4CC4-0x000000018A8E4E90
		public static void SetErrorUploadInterval(int interval) {} // 0x000000018A8E2C20-0x000000018A8E2D90
		public static void SetErrorUploadEnable(bool enable) {} // 0x000000018A8E2A98-0x000000018A8E2C20
		public static void SetRecordFileDir(string record_dir) {} // 0x000000018A8E33B0-0x000000018A8E3514
		public static void Init(string app_id, string app_key, string app_version) {} // 0x000000018A8E02B8-0x000000018A8E04D0
		public static void setEnableGetPackageInfo(bool enable) {} // 0x000000018A8E5688-0x000000018A8E5828
		public static void SetDumpType(int dump_type) {} // 0x000000018A8E279C-0x000000018A8E2930
		public static void AddValidExpCode(ulong exp_code) {} // 0x000000018A8DE450-0x000000018A8DE5E8
		public static void UploadCrashWithGuid(string guid) {} // 0x000000018A8E4B3C-0x000000018A8E4CC4
		public static void SetCrashUploadEnable(bool enable) {} // 0x000000018A8E1FA8-0x000000018A8E2154
		public static void SetWorkSpace(string workspace) {} // 0x000000018A8E3A04-0x000000018A8E3B8C
		public static void SetEngineInfo(string version, string buildConfig, string language, string locale) {} // 0x0000000185B6CAA0-0x0000000185B6CC60
		public static void setCatchMultiSignal(bool enable) {} // 0x000000018A8E54E8-0x000000018A8E5688
		public static void enableDetailedPageTracing(bool enable) {} // 0x000000018A8E4E90-0x000000018A8E5030
		public static void useSavedUserId(bool enable) {} // 0x000000018A8E5828-0x000000018A8E59D4
		public static void SetCustomAttachDir(string path) {} // 0x000000018A8E2154-0x000000018A8E21A0
		public static bool IsLastSessionCrash() => default; // 0x000000018A8E04D0-0x000000018A8E0624
		public static string GetLastSessionUserId() => default; // 0x000000018A8DFC9C-0x000000018A8DFE18
		public static bool CheckFdCount(int limit, int dumpType, bool upload) => default; // 0x000000018A8DF07C-0x000000018A8DF2D8
		public static void SetOomLogPath(string logPath) {} // 0x000000018A8E3234-0x000000018A8E33B0
		public static void ReportJank(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int reportInfoOption, string jankAttachmentPath) {} // 0x000000018A8E15EC-0x000000018A8E1904
		public static void ProcessEngineAnr(int type) {} // 0x000000018A8E0DBC-0x000000018A8E0F44
		public static void SetEngineMainThread() {} // 0x000000018A8E2930-0x000000018A8E2A98
		public static void ReportStuck(int threadId, int maxChecks, long checkInterval, string name, string message, Dictionary<string, string> extInfo, int dumpNativeType, string attachPath) {} // 0x000000018A8E1A6C-0x000000018A8E1E2C
	}

	public enum UQMMethodNameID // TypeDefIndex: 59729
	{
		UQM_CRASH_CALLBACK_EXTRA_DATA = 1011,
		UQM_CRASH_CALLBACK_EXTRA_MESSAGE = 1012,
		UQM_CRASH_CALLBACK_SET_LOG_PATH = 1013,
		UQM_CRASH_CALLBACK_LOG_UPLOAD_RESULT = 1014
	}

	internal class UQMLog // TypeDefIndex: 59731
	{
		// Fields
		private static Level level; // 0x00
		private const string header = "[CrashSightPlugin-Unity]"; // Metadata: 0x0208116E
	
		// Nested types
		public enum Level // TypeDefIndex: 59730
		{
			None = 0,
			Log = 1,
			Warning = 2,
			Error = 3
		}
	
		// Constructors
		public UQMLog() {} // 0x0000000185492010-0x0000000185492020
		static UQMLog() {} // 0x0000000185FA3CA0-0x0000000185FA3CE0
	
		// Methods
		public static void SetLevel(Level l) {} // 0x000000018A8E5C70-0x000000018A8E5CC4
		public static void Log(string message) {} // 0x00000001843D6280-0x00000001843D6300
		public static void LogWarning(string message) {} // 0x000000018A8E5BE0-0x000000018A8E5C70
		public static void LogError(string message) {} // 0x000000018A8E5B50-0x000000018A8E5BE0
		public static void FullLog(string message) {} // 0x000000018A8E59D4-0x000000018A8E5B50
	}

	public class RetArgsWrapper // TypeDefIndex: 59732
	{
		// Fields
		private readonly int methodId; // 0x10
		private readonly int crashType; // 0x14
		private readonly int logUploadResult; // 0x18
	
		// Properties
		public int MethodId { get => default; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		public int CrashType { get => default; } // 0x0000000185FB21A0-0x0000000185FB21B0 
		public int LogUploadResult { get => default; } // 0x00000001813AE560-0x00000001813AE570 
	
		// Constructors
		public RetArgsWrapper() {} // Dummy constructor
		public RetArgsWrapper(int _methodId, int _crashType, int _logUploadResult) {} // 0x0000000185FB25C0-0x0000000185FB25D0
	}

	public class UQMMessageCenter : MonoBehaviour // TypeDefIndex: 59734
	{
		// Fields
		private static bool initialzed; // 0x00
		private static UQMMessageCenter instance; // 0x08
	
		// Properties
		public static UQMMessageCenter Instance { get => default; } // 0x000000018646DB20-0x000000018646DB28 
	
		// Nested types
		private delegate string UQMRetJsonEventHandler(int methodId, int callType, int logUploadResult); // TypeDefIndex: 59733; 0x00000001844CE570-0x00000001844CE600
	
		// Constructors
		public UQMMessageCenter() {} // 0x00000001864750A8-0x00000001864751CC
	
		// Methods
		public static string OnUQMRet(int methodId, int crashType, int logUploadResult) => default; // 0x000000018A8E5CC4-0x000000018A8E5D18
		private static extern void cs_setUnityCallback(UQMRetJsonEventHandler eventHandler); // 0x00000001843D4FB0-0x00000001843D5110
		public void Init() {} // 0x0000000184A11730-0x0000000184A117C0
		public void Uninit() {} // 0x00000001817E31E0-0x00000001817E3200
		private static string SynchronousDelegate(object arg) => default; // 0x000000018A8E5D18-0x000000018A8E5DB0
	}
}

namespace GCloud.UQM.MiniJSON
{
	public static class Json // TypeDefIndex: 59738
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 59736
		{
			// Fields
			private const string WORD_BREAK = "{}[],:\""; // Metadata: 0x0208118B
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get => default; } // 0x000000018A8DC9DC-0x000000018A8DCAA0 
			private char NextChar { get => default; } // 0x000000018A8DC758-0x000000018A8DC7E8 
			private string NextWord { get => default; } // 0x000000018A8DD29C-0x000000018A8DD2F8 
			private TOKEN NextToken { get => default; } // 0x000000018A8DCF6C-0x000000018A8DCFC8 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 59735
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
			private Parser(string jsonString) {} // 0x000000018A8DC608-0x000000018A8DC610
	
			// Methods
			public static bool IsWordBreak(char c) => default; // 0x000000018A8DC5EC-0x000000018A8DC608
			public static object Parse(string jsonString) => default; // 0x000000018A8DC7E8-0x000000018A8DC860
			public void Dispose() {} // 0x000000018A8DCEF4-0x000000018A8DCF6C
			private Dictionary<string, object> ParseObject() => default; // 0x000000018A8DCDFC-0x000000018A8DCEF4
			private List<object> ParseArray() => default; // 0x000000018A8DC720-0x000000018A8DC758
			private object ParseValue() => default; // 0x000000018A8DCAA0-0x000000018A8DCBAC
			private object ParseByToken(TOKEN token) => default; // 0x000000018A8DC860-0x000000018A8DC928
			private string ParseString() => default; // 0x000000018A8DCDD8-0x000000018A8DCDFC
			private object ParseNumber() => default; // 0x000000018A8DC928-0x000000018A8DC9DC
			private void EatWhitespace() {} // 0x000000018A8DCBAC-0x000000018A8DCDD8
		}
	
		private sealed class Serializer // TypeDefIndex: 59737
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer() {} // 0x000000018A8DD1EC-0x000000018A8DD29C
	
			// Methods
			public static string Serialize(object obj) => default; // 0x000000018A8DCFC8-0x000000018A8DD1EC
			private void SerializeValue(object value) {} // 0x000000018A8DE120-0x000000018A8DE184
			private void SerializeObject(IDictionary obj) {} // 0x000000018A8DE0A8-0x000000018A8DE120
			private void SerializeArray(IList anArray) {} // 0x000000018A8DDF24-0x000000018A8DE0A8
			private void SerializeString(string str) {} // 0x000000018A8DD67C-0x000000018A8DDA84
			private void SerializeOther(object value) {} // 0x000000018A8DD2F8-0x000000018A8DD67C
		}
	
		// Methods
		public static object Deserialize(string json) => default; // 0x000000018A8DDCAC-0x000000018A8DDF24
		public static string Serialize(object obj) => default; // 0x000000018A8DDA84-0x000000018A8DDCAC
	}
}
