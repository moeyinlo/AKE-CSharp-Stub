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
using System.Text.RegularExpressions;
using System.Threading;
using AOT;
using UnityEngine;

// Image 71: HGSDKInterfaces.dll - Assembly: HGSDKInterfaces, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89562-89595

public enum CSLogSeverity // TypeDefIndex: 89563
{
	LogSilent = 0,
	LogError = 1,
	LogWarning = 2,
	LogInfo = 3,
	LogDebug = 4,
	LogVerbose = 5
}

public enum CSReportType // TypeDefIndex: 89564
{
	InterfaceReport = 0,
	LogCallback = 1,
	LogCallbackThreaded = 2
}

public enum JankReportInfoOption // TypeDefIndex: 89565
{
	JankOnlyBasicInfo = 0,
	JankSystemLog = 1,
	JankCustomLog = 2,
	JankCustomKv = 4,
	JankCallbackInfo = 8,
	JankAutoDumpStack = 16,
	JankAndroidAllJavaStack = 32
}

public sealed class CrashSightAgent // TypeDefIndex: 89570
{
	// Fields
	private static HGCrashSightCallback _crashSightCallback; // 0x00
	private static HGCrashSightLogCallback _crashSightLogCallback; // 0x08
	private static string crashUploadUrl; // 0x10
	private const int MaxCustomAttachPathCount = 3; // Metadata: 0x026494AF
	private static readonly List<string> _customAttachPaths; // 0x18
	public static List<int> callbackThreads; // 0x20
	public static object callbackThreadsLock; // 0x28
	[CompilerGenerated]
	private static LogCallbackDelegate _LogCallbackEventHandler; // 0x30
	private static LogFilterDelegate s_logFilter; // 0x38
	private static bool _isInitialized; // 0x40
	private static UnityEngine.LogType _autoReportLogLevel; // 0x44
	private static bool _debugMode; // 0x48
	private static bool _autoQuitApplicationAfterReport; // 0x49
	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler; // 0x50
	private static bool _uncaughtAutoReportOnce; // 0x58
	private static readonly string[] s_skipFramePatterns; // 0x60
	private static readonly Regex s_exceptionMessageRegex; // 0x68
	private static readonly Regex s_unhandledExceptionRegex; // 0x70
	public static readonly string s_UnityBuildVersion; // 0x78
	public static readonly string s_CommandLine; // 0x80
	public static readonly string s_UserName; // 0x88
	public static readonly string s_UserDomainName; // 0x90
	public static readonly string s_DeviceModel; // 0x98
	public static readonly string s_DeviceName; // 0xA0
	public static readonly string s_DeviceUniqueIdentifier; // 0xA8
	public static readonly string s_DeviceType; // 0xB0
	public static readonly string s_GraphicsDeviceName; // 0xB8
	public static readonly string s_GraphicsDeviceType; // 0xC0
	public static readonly string s_GraphicsDeviceVersion; // 0xC8
	public static readonly string s_GraphicsDeviceVendor; // 0xD0
	public static readonly int s_GraphicsMemorySize; // 0xD8
	public static readonly string s_NvidiaDriverVersion; // 0xE0
	public static readonly string s_hgShaderFeatureProfile; // 0xE8
	public static readonly string[] s_BootParams; // 0xF0
	public static string[] s_vmas; // 0xF8

	// Properties
	public static bool AutoQuitApplicationAfterReport { get; } // 0x000000018C171780-0x000000018C1717D0 
	public static bool IsInitialized { get; } // 0x000000018C1717D0-0x000000018C171804 

	// Events
	private static event LogCallbackDelegate _LogCallbackEventHandler {
		add; // 0x000000018C171588-0x000000018C17165C
		remove; // 0x000000018C171804-0x000000018C1718D8
	}

	// Nested types
	private class HGCrashSightCallback : CrashSightCallback // TypeDefIndex: 89566
	{
		// Constructors
		public HGCrashSightCallback(); // 0x0000000186A76580-0x0000000186A765C0

		// Methods
		public override string OnCrashBaseRetEvent(int methodId, int crashType); // 0x00000001869F8910-0x00000001869FA570
	}

	private class HGCrashSightLogCallback : CrashSightLogCallback // TypeDefIndex: 89567
	{
		// Constructors
		public HGCrashSightLogCallback(); // 0x0000000186A765C0-0x0000000186A76600

		// Methods
		public override string OnSetLogPathEvent(int methodId, int crashType); // 0x000000018C172F9C-0x000000018C173020
		public override void OnLogUploadResultEvent(int methodId, int crashType, int result); // 0x000000018C172E3C-0x000000018C172F9C
	}

	public delegate void LogCallbackDelegate(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 89568; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool LogFilterDelegate(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 89569; 0x00000001811DF7F0-0x00000001811DF810

	// Constructors
	public CrashSightAgent(); // 0x0000000186805BA0-0x0000000186805BB0
	static CrashSightAgent(); // 0x0000000186A76680-0x0000000186A79890

	// Methods
	public static void SetLogFilter(LogFilterDelegate filter); // 0x000000018C170360-0x000000018C1703C0
	public static void InitWithAppId(string appId, bool forceOnUiThread = false /* Metadata: 0x026494A8 */); // 0x0000000186ACFC30-0x0000000186AD28E0
	public static void ReportException(Exception e, string message); // 0x000000018C16FC48-0x000000018C16FDA4
	public static void ReportException(string name, string message, string stackTrace); // 0x000000018C16FA20-0x000000018C16FB90
	public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0 /* Metadata: 0x026494A9 */, string errorAttachmentPath = "" /* Metadata: 0x026494AA */); // 0x000000018C16FB90-0x000000018C16FC48
	public static void SetUserId(string userId); // 0x00000001850CDBB0-0x00000001850CDC90
	public static void AddSceneData(string key, string value); // 0x00000001854BE7E0-0x00000001854BE950
	public static void SetUserValue(string key, int value); // 0x0000000186A25530-0x0000000186A255E0
	public static void SetUserValue(string key, string value); // 0x00000001854BE780-0x00000001854BE7E0
	public static void SetUserValue(string key, string[] value); // 0x0000000185EB9890-0x0000000185EB9950
	public static void SetAppVersion(string appVersion); // 0x0000000186EB75D0-0x0000000186EB7680
	public static void ConfigCrashServerUrl(string crashServerUrl); // 0x0000000186F8B470-0x0000000186F8B520
	public static void SetLogPath(string logPath); // 0x000000018C1703C0-0x000000018C17040C
	public static void ConfigDebugMode(bool enable); // 0x000000018709E7F0-0x000000018709E8E0
	public static void SetDeviceId(string deviceId); // 0x000000018C170020-0x000000018C17006C
	public static void ConfigCrashReporter(int logLevel); // 0x000000018C16EEE8-0x000000018C16EF30
	public static void ConfigCrashReporter(CSLogSeverity logLevel); // 0x000000018C16EEA0-0x000000018C16EEE8
	public static void PrintLog(CSLogSeverity level, string format, params object[] args); // 0x00000001854C1DE0-0x00000001854C1E40
	public static void TestNativeCrash(); // 0x000000018C170970-0x000000018C1709F4
	public static void SetEnvironmentName(string serverEnv); // 0x000000018C170100-0x000000018C17014C
	public static void EnableAnrMonitor(int timeoutMs = 5000 /* Metadata: 0x026494AB */); // 0x000000018C16F110-0x000000018C16F158
	public static void DisableAnrMonitor(); // 0x000000018C16F0D0-0x000000018C16F110
	public static void RegisterCrashCallback(CrashSightCallback callback); // 0x0000000186ACF680-0x0000000186ACF740
	public static void UnregisterCrashCallback(); // 0x000000018C170B80-0x000000018C170BC0
	public static void RegisterCrashLogCallback(CrashSightLogCallback callback); // 0x0000000186ACF740-0x0000000186ACF850
	public static void EnableExceptionHandler(); // 0x000000018C16F158-0x000000018C16F1E8
	public static void RegisterLogCallback(LogCallbackDelegate handler); // 0x000000018C16F8A0-0x000000018C16F930
	public static void UnregisterLogCallback(LogCallbackDelegate handler); // 0x000000018C170BC0-0x000000018C170C24
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler); // 0x000000018C1702A8-0x000000018C170360
	public static void ConfigAutoQuitApplication(bool autoQuit); // 0x000000018C16EE04-0x000000018C16EE58
	public static void DebugLog(string tag, string format); // 0x00000001854BE950-0x00000001854BE9A0
	public static void _RegisterExceptionHandler(); // 0x0000000185B82E60-0x0000000185B83120
	public static void _UnregisterExceptionHandler(); // 0x000000018C1713B8-0x000000018C171588
	public static void SetCrashSightStackTraceEnable(bool enable); // 0x0000000186805BA0-0x0000000186805BB0
	public static void ConfigCallbackType(int callbackType); // 0x000000018C16EE58-0x000000018C16EEA0
	public static void SetDeviceModel(string deviceModel); // 0x000000018C17006C-0x000000018C1700B8
	public static void ReportLogInfo(string msgType, string msg); // 0x000000018C16FE1C-0x000000018C16FE78
	public static void SetScene(string sceneId, bool upload = false /* Metadata: 0x026494AD */); // 0x000000018C170518-0x000000018C170614
	public static void SetScene(int sceneId, bool upload = false /* Metadata: 0x026494AE */); // 0x000000018C170614-0x000000018C170674
	public static long GetCrashThreadId(); // 0x000000018C16F1E8-0x000000018C16F274
	public static void SetCustomizedDeviceID(string deviceId); // 0x000000018C16FF88-0x000000018C16FFD4
	public static string GetSDKDefinedDeviceID(); // 0x000000018C16F350-0x000000018C16F390
	public static void SetCustomizedMatchID(string matchId); // 0x000000018C16FFD4-0x000000018C170020
	public static string GetSDKSessionID(); // 0x000000018C16F390-0x000000018C16F3D0
	public static void TestOomCrash(); // 0x000000018C170A78-0x000000018C170AFC
	public static void TestJavaCrash(); // 0x000000018C1708EC-0x000000018C170970
	public static void TestANR(); // 0x000000018C170868-0x000000018C1708EC
	public static string GetCrashUuid(); // 0x000000018C16F274-0x000000018C16F2B4
	public static void SetLogcatBufferSize(int size); // 0x000000018C17040C-0x000000018C170454
	public static void TestOcCrash(); // 0x000000018C1709F4-0x000000018C170A78
	public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath); // 0x000000018C170734-0x000000018C1707E8
	public static void StartMonitorFdCount(int interval, int limit, int dumpType); // 0x000000018C1707E8-0x000000018C170868
	public static int getExceptionType(string name); // 0x000000018C171714-0x000000018C171780
	public static void TestUseAfterFree(); // 0x000000018C170AFC-0x000000018C170B80
	public static void ReRegistAllMonitors(); // 0x000000018C16F820-0x000000018C16F8A0
	public static void CloseAllMonitors(); // 0x000000018C16ED98-0x000000018C16EE04
	public static void setEnableGetPackageInfo(bool enable); // 0x000000018C171990-0x000000018C171A48
	public static void setCatchMultiSignal(bool enable); // 0x000000018C1718D8-0x000000018C171990
	public static void enableDetailedPageTracing(bool enable); // 0x000000018C17165C-0x000000018C171714
	public static bool IsLastSessionCrash(); // 0x000000018C16F798-0x000000018C16F820
	public static string GetLastSessionUserId(); // 0x000000018C16F2B4-0x000000018C16F350
	public static bool CheckFdCount(int limit, int dumpType, bool upload); // 0x000000018C16ED14-0x000000018C16ED98
	public static void SetOomLogPath(string logPath); // 0x000000018C170454-0x000000018C1704A0
	public static void ReportJank(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int reportInfoOption, string jankAttachmentPath); // 0x000000018C16FDA4-0x000000018C16FE1C
	public static void ReportStuck(int threadId, int maxChecks, long checkInterval, string name, string message, Dictionary<string, string> extInfo, int dumpNativeType, string attachPath); // 0x000000018C16FE78-0x000000018C16FEF0
	public static void SetVehEnable(bool enable); // 0x000000018C170674-0x000000018C1706E8
	public static void ReportCrash(); // 0x000000018C16F930-0x000000018C16F99C
	public static void ReportDump(string dump_path, bool is_async); // 0x000000018C16F99C-0x000000018C16FA20
	public static void SetExtraHandler(bool extra_handle_enable); // 0x000000018C170234-0x000000018C1702A8
	public static void UploadGivenPathDump(string dump_dir, bool is_extra_check); // 0x000000018C170C70-0x000000018C170CF4
	public static void SetDumpType(int dump_type); // 0x000000018C1700B8-0x000000018C170100
	public static void AddValidExpCode(ulong exp_code); // 0x000000018C16ECC8-0x000000018C16ED14
	public static void UploadCrashWithGuid(string guid); // 0x000000018C170C24-0x000000018C170C70
	public static void SetCrashUploadEnable(bool enable); // 0x000000018C16FEF0-0x000000018C16FF3C
	public static void SetWorkSpace(string workspace); // 0x000000018C1706E8-0x000000018C170734
	public static void SetCustomAttachDir(string path); // 0x000000018C16FF3C-0x000000018C16FF88
	public static void SetErrorUploadInterval(int interval); // 0x000000018C1701C0-0x000000018C170234
	public static void SetErrorUploadEnable(bool enable); // 0x000000018C17014C-0x000000018C1701C0
	public static void SetRecordFileDir(string record_dir); // 0x000000018C1704A0-0x000000018C170518
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03\uFF0C\u8BF7\u4F7F\u7528 InitWithAppId \u8FDB\u884C\u521D\u59CB\u5316")]
	public static void InitContext(string userId, string version, string key); // 0x000000018C16F3D0-0x000000018C16F5B0
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03\uFF0C\u8BF7\u4F7F\u7528 InitWithAppId \u8FDB\u884C\u521D\u59CB\u5316")]
	public static void Init(string app_id, string app_key, string app_version); // 0x000000018C16F5B0-0x000000018C16F798
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03")]
	public static void ConfigDefault(string channel, string version, string user, long delay); // 0x000000018C16EF30-0x000000018C16F0D0
	private static void _OnLogCallbackHandlerMain(string condition, string stackTrace, UnityEngine.LogType type); // 0x00000001854BCD80-0x00000001854BCDE0
	private static void _OnLogCallbackHandlerThreaded(string condition, string stackTrace, UnityEngine.LogType type); // 0x00000001854BCDE0-0x00000001854BCE40
	private static void _OnLogCallbackHandler(string condition, string stackTrace, UnityEngine.LogType type, CSReportType rType); // 0x00000001854BD080-0x00000001854BD2F0
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args); // 0x000000018C1711FC-0x000000018C1713B8
	private static void _HandleException(Exception e, string message, bool uncaught); // 0x000000018C170CF4-0x000000018C1711FC
	private static bool ShouldSkipFrame(string frame); // 0x0000000185F1DF30-0x0000000185F1E060
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace); // 0x00000001852FA290-0x00000001852FD5A0
	private static void InitCustomAttachPaths(); // 0x000000018490F1F0-0x00000001849105C0
	private static void AddVmaAllocationFailureInfo(); // 0x000000018490E4F0-0x000000018490F1F0
	private static void AddGpuMemorySupplementInfo(); // 0x000000018490C5F0-0x000000018490E4F0
	private static void AddTrackCustomData(); // 0x00000001854BE3F0-0x00000001854BE780
	private static int valueOf(UnityEngine.LogType logLevel); // 0x00000001854BD030-0x00000001854BD080
	private static bool isEnableAutoReport(UnityEngine.LogType logLevel); // 0x00000001854BCFD0-0x00000001854BD030
	private static void _HandleException(UnityEngine.LogType logLevel, string name, string message, string stackTrace, bool uncaught, CSReportType rType); // 0x00000001854BD2F0-0x00000001854BE3F0
}

public class CrashSightAnrMonitor // TypeDefIndex: 89573
{
	// Fields
	private static CrashSightMonoBehaviour monoBehaviour; // 0x00
	private static int anrTimeoutMs; // 0x08
	private static int detectionTimeoutMs; // 0x0C
	[CompilerGenerated]
	private static bool _Paused_k__BackingField; // 0x10
	private static int ticksSinceUiUpdate; // 0x14
	private static bool reported; // 0x18
	private static bool running; // 0x19
	private static Thread thread; // 0x20

	// Properties
	protected static bool Paused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018C172360-0x000000018C1723B0 0x000000018C1723B0-0x000000018C172404

	// Nested types
	[Serializable]
	[CompilerGenerated]
	private sealed class __c // TypeDefIndex: 89571
	{
		// Fields
		public static readonly __c __9; // 0x00
		public static Action __9__11_0; // 0x08
		public static Action __9__11_1; // 0x10
		public static Action __9__11_2; // 0x18

		// Constructors
		static __c(); // 0x000000018C174D80-0x000000018C174DE4
		public __c(); // 0x0000000186805BA0-0x0000000186805BB0

		// Methods
		internal void _Start_b__11_0(); // 0x000000018C174CC0-0x000000018C174D00
		internal void _Start_b__11_1(); // 0x000000018C174D00-0x000000018C174D40
		internal void _Start_b__11_2(); // 0x000000018C174D40-0x000000018C174D80
	}

	[CompilerGenerated]
	private sealed class _UpdateUiStatus_d__13 : IEnumerator<object> // TypeDefIndex: 89572
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		private WaitForSecondsRealtime _waitForSeconds_5__2; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
		object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 

		// Constructors
		[DebuggerHidden]
		public _UpdateUiStatus_d__13(int __1__state); // 0x0000000182234E90-0x0000000182234EA0

		// Methods
		[DebuggerHidden]
		void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		private bool MoveNext(); // 0x000000018C174DE4-0x000000018C174F4C
		[DebuggerHidden]
		void IEnumerator.Reset(); // 0x000000018C174F4C-0x000000018C174F98
	}

	// Constructors
	public CrashSightAnrMonitor(); // 0x0000000186805BA0-0x0000000186805BB0
	static CrashSightAnrMonitor(); // 0x000000018C1722A0-0x000000018C172360

	// Methods
	public static void Start(int timeoutMs = 5000 /* Metadata: 0x026494B0 */); // 0x000000018C171D74-0x000000018C17220C
	public static void Stop(); // 0x000000018C17220C-0x000000018C17225C
	[IteratorStateMachine(typeof(_UpdateUiStatus_d__13))]
	private static IEnumerator UpdateUiStatus(); // 0x000000018C17225C-0x000000018C1722A0
	private static void Run(); // 0x000000018C171B14-0x000000018C171D74
	private static void Report(); // 0x000000018C171A48-0x000000018C171B14
}

public class UnityAnrException : Exception // TypeDefIndex: 89574
{
	// Constructors
	internal UnityAnrException(); // 0x000000018C17CB34-0x000000018C17CB80
	internal UnityAnrException(string message); // 0x000000018C17CAD8-0x000000018C17CB34
	internal UnityAnrException(string message, Exception innerException); // 0x000000018C17CB80-0x000000018C17CC30
}

public abstract class CrashSightCallback // TypeDefIndex: 89575
{
	// Fields
	private static bool isQuitting; // 0x00
	private static object quitLocker; // 0x08

	// Constructors
	static CrashSightCallback(); // 0x0000000185BC0700-0x0000000185BC07E0
	protected CrashSightCallback(); // 0x0000000186805BA0-0x0000000186805BB0

	// Methods
	private static void OnApplicationQuitting(); // 0x000000018C17250C-0x000000018C172604
	public static bool IsQuitting(); // 0x000000018C172404-0x000000018C17250C
	public abstract string OnCrashBaseRetEvent(int methodId, int crashType);
}

public abstract class CrashSightLogCallback // TypeDefIndex: 89576
{
	// Fields
	private static bool isQuitting; // 0x00
	private static object quitLocker; // 0x08

	// Constructors
	static CrashSightLogCallback(); // 0x0000000185BC07E0-0x0000000185BC08C0
	protected CrashSightLogCallback(); // 0x0000000186805BA0-0x0000000186805BB0

	// Methods
	private static void OnApplicationQuitting(); // 0x000000018C17270C-0x000000018C172804
	public static bool IsQuitting(); // 0x000000018C172604-0x000000018C17270C
	public abstract string OnSetLogPathEvent(int methodId, int crashType);
	public abstract void OnLogUploadResultEvent(int methodId, int crashType, int result);
}

[AddComponentMenu("")]
public class CrashSightMonoBehaviour : MonoBehaviour // TypeDefIndex: 89577
{
	// Fields
	private static CrashSightMonoBehaviour _instance; // 0x00
	[CompilerGenerated]
	private Action ApplicationResuming; // 0x18
	[CompilerGenerated]
	private Action ApplicationPausing; // 0x20
	[CompilerGenerated]
	private Action ApplicationQuitting; // 0x28
	internal bool _isRunning; // 0x30

	// Properties
	public static CrashSightMonoBehaviour Instance { get; } // 0x000000018C172AB4-0x000000018C172BD4 

	// Events
	public event Action ApplicationResuming {
		add; // 0x000000018C172A20-0x000000018C172AB4
		remove; // 0x000000018C172CFC-0x000000018C172D90
	}
	public event Action ApplicationPausing {
		add; // 0x000000018C1728F8-0x000000018C17298C
		remove; // 0x000000018C172BD4-0x000000018C172C68
	}
	public event Action ApplicationQuitting {
		add; // 0x000000018C17298C-0x000000018C172A20
		remove; // 0x000000018C172C68-0x000000018C172CFC
	}

	// Constructors
	public CrashSightMonoBehaviour(); // 0x0000000188DACB74-0x0000000188DACB90

	// Methods
	public void UpdatePauseStatus(bool paused); // 0x000000018C1728C4-0x000000018C1728F8
	internal void OnApplicationPause(bool pauseStatus); // 0x000000018C172860-0x000000018C172868
	internal void OnApplicationFocus(bool hasFocus); // 0x000000018C172854-0x000000018C172860
	private void OnApplicationQuit(); // 0x000000018C172868-0x000000018C1728C4
	private void Awake(); // 0x000000018C172804-0x000000018C172854
}

public class CrashSightStackTrace // TypeDefIndex: 89578
{
	// Fields
	public static bool enable; // 0x00
	private static string stackTrace; // 0x08

	// Constructors
	public CrashSightStackTrace(); // 0x0000000186805BA0-0x0000000186805BB0

	// Methods
	public static void setEnable(bool enable); // 0x0000000186805BA0-0x0000000186805BB0
	public static string ExtractStackTrace(); // 0x000000018C172D90-0x000000018C172E3C
}

namespace GCloud.UQM
{
	public delegate void OnUQMRetEventHandler<T>(T ret); // TypeDefIndex: 89579; 0x00000000-0x00000000

	public delegate string OnUQMStringRetEventHandler<T>(T ret, T crashType); // TypeDefIndex: 89580; 0x00000000-0x00000000

	public delegate string OnUQMStringRetSetLogPathEventHandler<T>(T ret, T crashType); // TypeDefIndex: 89581; 0x00000000-0x00000000

	public delegate void OnUQMRetLogUploadEventHandler<T>(T ret, T crashType, T result); // TypeDefIndex: 89582; 0x00000000-0x00000000

	public class UQM // TypeDefIndex: 89583
	{
		// Fields
		public const string LibName = "CrashSight64"; // Metadata: 0x026494B2
		private static bool initialized; // 0x00
		public static bool isDebug; // 0x01
	
		// Constructors
		public UQM(); // 0x0000000186805BA0-0x0000000186805BB0
		static UQM(); // 0x000000018C17CAA0-0x000000018C17CAD8
	
		// Methods
		public static void Init(); // 0x000000018C17C9DC-0x000000018C17CAA0
	}

	public enum UQMCrashLevel // TypeDefIndex: 89584
	{
		CSLogLevelSilent = 0,
		CSLogLevelError = 1,
		CSLogLevelWarn = 2,
		CSLogLevelInfo = 3,
		CSLogLevelDebug = 4,
		CSLogLevelVerbose = 5
	}

	public static class UQMCrash // TypeDefIndex: 89585
	{
		// Fields
		[CompilerGenerated]
		private static OnUQMStringRetEventHandler<int> CrashBaseRetEvent; // 0x00
		[CompilerGenerated]
		private static OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent; // 0x08
		[CompilerGenerated]
		private static OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent; // 0x10
		private static AndroidJavaClass _gameAgentClass; // 0x18
		private static bool _isLoadedSo; // 0x20
		private static int _gameType; // 0x24
		private static readonly string GAME_AGENT_CLASS; // 0x28
	
		// Properties
		public static AndroidJavaClass CrashSightPlatform { get; } // 0x000000018C17BDD4-0x000000018C17BEB8 
	
		// Events
		public static event OnUQMStringRetEventHandler<int> CrashBaseRetEvent {
			add; // 0x0000000186ACF3E0-0x0000000186ACF4C0
			remove; // 0x000000018C17BEB8-0x000000018C17BF7C
		}
		public static event OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent {
			add; // 0x0000000186ACF4C0-0x0000000186ACF5A0
			remove; // 0x000000018C17C044-0x000000018C17C10C
		}
		public static event OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent {
			add; // 0x0000000186ACF5A0-0x0000000186ACF680
			remove; // 0x000000018C17BF7C-0x000000018C17C044
		}
	
		// Constructors
		static UQMCrash(); // 0x000000018710F290-0x000000018710F340
	
		// Methods
		private static extern void CS_InitContext(string id, string version, string key); // 0x000000018C175224-0x000000018C1752F4
		private static extern void CS_ReportExceptionW(int type, string name, string message, string stack_trace, string extras, bool is_async, string attachmentPath = "" /* Metadata: 0x026494C5 */); // 0x00000001854C0F90-0x00000001854C1090
		private static extern void CS_SetUserValue(string key, string value); // 0x00000001854BF6D0-0x00000001854BF750
		private static extern void CS_SetVehEnable(bool enable); // 0x000000018C1758D0-0x000000018C175948
		private static extern void CS_SetExtraHandler(bool extra_handle_enable); // 0x000000018C17589C-0x000000018C1758D0
		private static extern void CS_SetCustomLogDirW(string log_path); // 0x000000018C17568C-0x000000018C17570C
		private static extern void CS_SetUserId(string user_id); // 0x00000001850CDD50-0x00000001850CDDA0
		private static extern void CS_MonitorEnable(bool enable); // 0x000000018C1752F4-0x000000018C17536C
		private static extern void CS_PrintLog(int level, string tag, string format, string arg); // 0x00000001854C1090-0x00000001854C1140
		private static extern void CS_UploadGivenPathDump(string dump_dir, bool is_extra_check); // 0x000000018C175ABC-0x000000018C175B50
		private static extern void CS_ReportCrash(); // 0x000000018C17536C-0x000000018C1753D4
		private static extern void CS_ReportDump(string dump_dir, bool is_async); // 0x000000018C1753D4-0x000000018C175468
		private static extern void CS_SetEnvironmentName(string name); // 0x000000018C175810-0x000000018C17589C
		private static extern void CS_InitWithAppId(string app_id); // 0x0000000186ACF140-0x0000000186ACF1A0
		private static extern void CS_SetAppVersion(string app_version); // 0x0000000186EB7730-0x0000000186EB7790
		private static extern void CS_ConfigCrashServerUrl(string crash_server_url); // 0x0000000185AFD500-0x0000000185AFD5A0
		private static extern void CS_ConfigDebugMode(bool enable); // 0x0000000185AFDD00-0x0000000185AFDD40
		private static extern void CS_SetDeviceId(string device_id); // 0x000000018C17570C-0x000000018C175798
		private static extern void CS_ConfigCrashReporter(int log_level); // 0x000000018C1751AC-0x000000018C175224
		private static extern void CS_TestNativeCrash(); // 0x000000018C1759C8-0x000000018C175A30
		private static extern void CS_SetDumpType(int dump_type); // 0x000000018C175798-0x000000018C175810
		private static extern void CS_AddValidExpCode(ulong exp_code); // 0x000000018C175134-0x000000018C1751AC
		private static extern void CS_UploadCrashWithGuid(string guid); // 0x000000018C175A30-0x000000018C175ABC
		private static extern void CS_SetCrashUploadEnable(bool enable); // 0x000000018C175594-0x000000018C17560C
		private static extern void CS_SetWorkSpaceW(string workspace); // 0x000000018C175948-0x000000018C1759C8
		private static extern void CS_SetEngineInfo(string version, string buildConfig, string language, string locale); // 0x0000000185AFD240-0x0000000185AFD350
		private static extern void CS_SetCustomAttachDirW(string log_path); // 0x000000018C17560C-0x000000018C17568C
		private static extern void CS_UseSavedUserId(bool enable); // 0x000000018C175B50-0x000000018C175BC8
		private static extern void CS_ReportStuck(int threadId, int maxChecks, int checkInterval, string name, string message, string extraInfo, int dumpNativeType, string attachPath); // 0x000000018C175468-0x000000018C175594
		private static void LoadCrashSightCoreSo(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void ConfigCallbackType(int callbackType); // 0x000000018C176138-0x000000018C1762C4
		public static void ConfigGameType(int gameType); // 0x0000000186ACF1A0-0x0000000186ACF270
		public static void ConfigAutoReportLogLevel(int level); // 0x000000018C175FA0-0x000000018C176138
		public static void ConfigCrashServerUrl(string serverUrl); // 0x0000000186F8B520-0x0000000186F8B5D0
		public static void ConfigDebugMode(bool enable); // 0x0000000185AFE280-0x0000000185AFE370
		public static void ConfigDefault(string channel, string version, string user, long delay); // 0x000000018C1762C4-0x000000018C176538
		public static void InitWithAppId(string appId, bool forceOnUiThread); // 0x0000000186ACF050-0x0000000186ACF140
		public static void InitContext(string userId, string version, string key); // 0x000000018C176C90-0x000000018C176E3C
		public static void LogRecord(int level, string message); // 0x00000001854C1350-0x00000001854C1410
		public static void AddSceneData(string k, string v); // 0x00000001854BE9A0-0x00000001854BEA40
		public static void ReportException(int type, string name, string message, string stackTrace, string extras, bool quitProgram); // 0x00000001854BCE40-0x00000001854BCFB0
		public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0 /* Metadata: 0x026494C6 */, string errorAttachmentPath = "" /* Metadata: 0x026494C7 */); // 0x000000018C177F94-0x000000018C1781A0
		public static void SetUserId(string userId); // 0x00000001850CDC90-0x00000001850CDD50
		public static void SetScene(string sceneId, bool upload); // 0x000000018C17A100-0x000000018C17A2C4
		public static void ReRegistAllMonitors(); // 0x000000018C177AE4-0x000000018C177C50
		public static void CloseAllMonitors(); // 0x000000018C175E34-0x000000018C175FA0
		public static void ReportLogInfo(string msgType, string msg); // 0x000000018C1784BC-0x000000018C178628
		public static void SetAppVersion(string appVersion); // 0x0000000186EB7680-0x0000000186EB7730
		public static void SetDeviceId(string deviceId); // 0x000000018C179064-0x000000018C1791EC
		public static void SetCustomizedDeviceID(string deviceId); // 0x000000018C178D64-0x000000018C178EE4
		public static string GetSDKDefinedDeviceID(); // 0x000000018C176990-0x000000018C176B10
		public static void SetCustomizedMatchID(string matchId); // 0x000000018C178EE4-0x000000018C179064
		public static string GetSDKSessionID(); // 0x000000018C176B10-0x000000018C176C90
		public static string GetCrashUuid(); // 0x000000018C176690-0x000000018C176810
		public static void SetDeviceModel(string deviceModel); // 0x000000018C1791EC-0x000000018C17936C
		public static void SetLogPath(string logPath); // 0x000000018C179B1C-0x000000018C179CA4
		public static void SetCrashCallback(); // 0x0000000186ACFBC0-0x0000000186ACFC30
		public static void UnsetCrashCallback(); // 0x000000018C17B604-0x000000018C17B758
		public static void SetCrashLogCallback(); // 0x0000000186ACFB50-0x0000000186ACFBC0
		internal static string OnCrashCallbackMessage(int methodId, int crashType); // 0x00000001854BC3E0-0x00000001854BC560
		internal static string OnCrashCallbackData(int methodId, int crashType); // 0x000000018C1771AC-0x000000018C177390
		internal static string OnCrashSetLogPathMessage(int methodId, int crashType); // 0x000000018C177774-0x000000018C177958
		internal static string OnCrashLogUploadMessage(int methodId, int crashType, int result); // 0x000000018C177574-0x000000018C177774
		internal static string OnCrashCallbackNoRet(int methodId, int crashType); // 0x000000018C177390-0x000000018C177574
		public static void ConfigCallBack(); // 0x0000000186ACF850-0x0000000186ACF8B0
		public static void UnregisterCallBack(); // 0x000000018C17B5B0-0x000000018C17B604
		public static void ConfigLogCallBack(); // 0x0000000186ACF8B0-0x0000000186ACF910
		public static void TestOomCrash(); // 0x000000018C17B2D8-0x000000018C17B444
		public static void TestJavaCrash(); // 0x000000018C17AE8C-0x000000018C17AFF8
		public static void TestOcCrash(); // 0x000000018C17B16C-0x000000018C17B2D8
		public static void TestNativeCrash(); // 0x000000018C17AFF8-0x000000018C17B16C
		public static void TestANR(); // 0x000000018C17AD20-0x000000018C17AE8C
		public static long GetCrashThreadId(); // 0x000000018C176538-0x000000018C176690
		public static void SetLogcatBufferSize(int size); // 0x000000018C179CA4-0x000000018C179E18
		public static void SetCallbackMsg(string data); // 0x000000018C1789EC-0x000000018C178B6C
		public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath); // 0x000000018C17A780-0x000000018C17AADC
		public static void StartMonitorFdCount(int interval, int limit, int dumpType); // 0x000000018C17AADC-0x000000018C17AD20
		public static int getExceptionType(string name); // 0x000000018C17BC54-0x000000018C17BDD4
		public static void TestUseAfterFree(); // 0x000000018C17B444-0x000000018C17B5B0
		public static void SetServerEnv(string serverEnv); // 0x000000018C17A2C4-0x000000018C17A44C
		public static void SetVehEnable(bool enable); // 0x000000018C17A44C-0x000000018C17A5F8
		public static void ReportCrash(); // 0x000000018C177C50-0x000000018C177DC4
		public static void ReportDump(string dump_path, bool is_async); // 0x000000018C177DC4-0x000000018C177F94
		public static void SetExtraHandler(bool extra_handle_enable); // 0x000000018C179970-0x000000018C179B1C
		public static void UploadGivenPathDump(string dump_dir, bool is_extra_check); // 0x000000018C17B8E0-0x000000018C17BAB0
		public static void SetErrorUploadInterval(int interval); // 0x000000018C1797FC-0x000000018C179970
		public static void SetErrorUploadEnable(bool enable); // 0x000000018C179670-0x000000018C1797FC
		public static void SetRecordFileDir(string record_dir); // 0x000000018C179F98-0x000000018C17A100
		public static void Init(string app_id, string app_key, string app_version); // 0x000000018C176E3C-0x000000018C177058
		public static void setEnableGetPackageInfo(bool enable); // 0x000000018C17C2B0-0x000000018C17C454
		public static void SetDumpType(int dump_type); // 0x000000018C17936C-0x000000018C179504
		public static void AddValidExpCode(ulong exp_code); // 0x000000018C174F98-0x000000018C175134
		public static void UploadCrashWithGuid(string guid); // 0x000000018C17B758-0x000000018C17B8E0
		public static void SetCrashUploadEnable(bool enable); // 0x000000018C178B6C-0x000000018C178D18
		public static void SetWorkSpace(string workspace); // 0x000000018C17A5F8-0x000000018C17A780
		public static void SetEngineInfo(string version, string buildConfig, string language, string locale); // 0x0000000186DFBD90-0x0000000186DFBF50
		public static void setCatchMultiSignal(bool enable); // 0x000000018C17C10C-0x000000018C17C2B0
		public static void enableDetailedPageTracing(bool enable); // 0x000000018C17BAB0-0x000000018C17BC54
		public static void useSavedUserId(bool enable); // 0x000000018C17C454-0x000000018C17C600
		public static void SetCustomAttachDir(string path); // 0x000000018C178D18-0x000000018C178D64
		public static bool IsLastSessionCrash(); // 0x000000018C177058-0x000000018C1771AC
		public static string GetLastSessionUserId(); // 0x000000018C176810-0x000000018C176990
		public static bool CheckFdCount(int limit, int dumpType, bool upload); // 0x000000018C175BC8-0x000000018C175E34
		public static void SetOomLogPath(string logPath); // 0x000000018C179E18-0x000000018C179F98
		public static void ReportJank(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int reportInfoOption, string jankAttachmentPath); // 0x000000018C1781A0-0x000000018C1784BC
		public static void ProcessEngineAnr(int type); // 0x000000018C177958-0x000000018C177AE4
		public static void SetEngineMainThread(); // 0x000000018C179504-0x000000018C179670
		public static void ReportStuck(int threadId, int maxChecks, long checkInterval, string name, string message, Dictionary<string, string> extInfo, int dumpNativeType, string attachPath); // 0x000000018C178628-0x000000018C1789EC
	}

	public enum UQMMethodNameID // TypeDefIndex: 89586
	{
		UQM_CRASH_CALLBACK_EXTRA_DATA = 1011,
		UQM_CRASH_CALLBACK_EXTRA_MESSAGE = 1012,
		UQM_CRASH_CALLBACK_SET_LOG_PATH = 1013,
		UQM_CRASH_CALLBACK_LOG_UPLOAD_RESULT = 1014
	}

	internal class UQMLog // TypeDefIndex: 89588
	{
		// Fields
		private static Level level; // 0x00
		private const string header = "[CrashSightPlugin-Unity]"; // Metadata: 0x026494D0
	
		// Nested types
		public enum Level // TypeDefIndex: 89587
		{
			None = 0,
			Log = 1,
			Warning = 2,
			Error = 3
		}
	
		// Constructors
		public UQMLog(); // 0x0000000186805BA0-0x0000000186805BB0
		static UQMLog(); // 0x000000018721F730-0x000000018721F770
	
		// Methods
		public static void SetLevel(Level l); // 0x000000018C17C898-0x000000018C17C8EC
		public static void Log(string message); // 0x00000001854BEB50-0x00000001854BEB90
		public static void LogWarning(string message); // 0x000000018C17C808-0x000000018C17C898
		public static void LogError(string message); // 0x000000018C17C778-0x000000018C17C808
		public static void FullLog(string message); // 0x000000018C17C600-0x000000018C17C778
	}

	public class RetArgsWrapper // TypeDefIndex: 89589
	{
		// Fields
		private readonly int methodId; // 0x10
		private readonly int crashType; // 0x14
		private readonly int logUploadResult; // 0x18
	
		// Properties
		public int MethodId { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public int CrashType { get; } // 0x0000000182971EE0-0x0000000182971EF0 
		public int LogUploadResult { get; } // 0x00000001844AF510-0x00000001844AF520 
	
		// Constructors
		public RetArgsWrapper(int _methodId, int _crashType, int _logUploadResult); // 0x0000000187235470-0x0000000187235480
	}

	public class UQMMessageCenter : MonoBehaviour // TypeDefIndex: 89591
	{
		// Fields
		private static bool initialzed; // 0x00
		private static UQMMessageCenter instance; // 0x08
	
		// Properties
		public static UQMMessageCenter Instance { get; } // 0x0000000186ACF910-0x0000000186ACFB50 
	
		// Nested types
		private delegate string UQMRetJsonEventHandler(int methodId, int callType, int logUploadResult); // TypeDefIndex: 89590; 0x00000001811DF7F0-0x00000001811DF810
	
		// Constructors
		public UQMMessageCenter(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[AOT.MonoPInvokeCallback(typeof(UQMRetJsonEventHandler))]
		public static string OnUQMRet(int methodId, int crashType, int logUploadResult); // 0x00000001854BC560-0x00000001854BCC20
		private static extern void cs_setUnityCallback(UQMRetJsonEventHandler eventHandler); // 0x0000000185AFBB60-0x0000000185AFBBF0
		public void Init(); // 0x0000000186ACF270-0x0000000186ACF360
		public void Uninit(); // 0x000000018C17C8EC-0x000000018C17C940
		private static string SynchronousDelegate(object arg); // 0x00000001854BCC20-0x00000001854BCD80
	}
}

namespace GCloud.UQM.MiniJSON
{
	public static class Json // TypeDefIndex: 89595
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 89593
		{
			// Fields
			private const string WORD_BREAK = "{}[],:\""; // Metadata: 0x026494ED
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get; } // 0x000000018C173DD8-0x000000018C173E34 
			private char NextChar { get; } // 0x000000018C173A98-0x000000018C173AF4 
			private string NextWord { get; } // 0x000000018C173D28-0x000000018C173DD8 
			private TOKEN NextToken { get; } // 0x000000018C173AF4-0x000000018C173D28 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 89592
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
			private Parser(string jsonString); // 0x000000018C173A20-0x000000018C173A98
	
			// Methods
			public static bool IsWordBreak(char c); // 0x000000018C1732E4-0x000000018C17335C
			public static object Parse(string jsonString); // 0x000000018C173918-0x000000018C173A20
			public void Dispose(); // 0x000000018C17321C-0x000000018C173254
			private Dictionary<string, object> ParseObject(); // 0x000000018C1735A8-0x000000018C1736B4
			private List<object> ParseArray(); // 0x000000018C17335C-0x000000018C173424
			private object ParseValue(); // 0x000000018C1738F4-0x000000018C173918
			private object ParseByToken(TOKEN token); // 0x000000018C173424-0x000000018C1734E0
			private string ParseString(); // 0x000000018C1736B4-0x000000018C1738F4
			private object ParseNumber(); // 0x000000018C1734E0-0x000000018C1735A8
			private void EatWhitespace(); // 0x000000018C173254-0x000000018C1732E4
		}
	
		private sealed class Serializer // TypeDefIndex: 89594
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer(); // 0x000000018C174C5C-0x000000018C174CC0
	
			// Methods
			public static string Serialize(object obj); // 0x000000018C174BE4-0x000000018C174C5C
			private void SerializeValue(object value); // 0x000000018C174A60-0x000000018C174BE4
			private void SerializeObject(IDictionary obj); // 0x000000018C1741B0-0x000000018C1745AC
			private void SerializeArray(IList anArray); // 0x000000018C173E34-0x000000018C1741B0
			private void SerializeString(string str); // 0x000000018C1747D4-0x000000018C174A60
			private void SerializeOther(object value); // 0x000000018C1745AC-0x000000018C1747D4
		}
	
		// Methods
		public static object Deserialize(string json); // 0x000000018C173020-0x000000018C17303C
		public static string Serialize(object obj); // 0x000000018C17303C-0x000000018C173044
	}
}
