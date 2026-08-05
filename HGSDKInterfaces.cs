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

// Image 72: HGSDKInterfaces.dll - Assembly: HGSDKInterfaces, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62270-62303
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public enum CSLogSeverity // TypeDefIndex: 62271
{
	LogSilent = 0,
	LogError = 1,
	LogWarning = 2,
	LogInfo = 3,
	LogDebug = 4,
	LogVerbose = 5
}

public enum CSReportType // TypeDefIndex: 62272
{
	InterfaceReport = 0,
	LogCallback = 1,
	LogCallbackThreaded = 2
}

public enum JankReportInfoOption // TypeDefIndex: 62273
{
	JankOnlyBasicInfo = 0,
	JankSystemLog = 1,
	JankCustomLog = 2,
	JankCustomKv = 4,
	JankCallbackInfo = 8,
	JankAutoDumpStack = 16,
	JankAndroidAllJavaStack = 32
}

public sealed class CrashSightAgent // TypeDefIndex: 62278
{
	// Fields
	private static HGCrashSightCallback _crashSightCallback; // 0x00
	private static HGCrashSightLogCallback _crashSightLogCallback; // 0x08
	private static string crashUploadUrl; // 0x10
	public static List<int> callbackThreads; // 0x18
	public static object callbackThreadsLock; // 0x20
	[CompilerGenerated]
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
	public static bool AutoQuitApplicationAfterReport { get; } // 0x0000000189D2B4B0-0x0000000189D2B500 
	public static bool IsInitialized { get; } // 0x0000000189D2B500-0x0000000189D2B534 

	// Events
	private static event LogCallbackDelegate _LogCallbackEventHandler {
		add; // 0x0000000189D2B2B8-0x0000000189D2B38C
		remove; // 0x0000000189D2B534-0x0000000189D2B608
	}

	// Nested types
	private class HGCrashSightCallback : CrashSightCallback // TypeDefIndex: 62274
	{
		// Constructors
		public HGCrashSightCallback(); // 0x0000000184D7C2B0-0x0000000184D7C2F0

		// Methods
		public override string OnCrashBaseRetEvent(int methodId, int crashType); // 0x000000018321CB90-0x000000018321CC50
	}

	private class HGCrashSightLogCallback : CrashSightLogCallback // TypeDefIndex: 62275
	{
		// Constructors
		public HGCrashSightLogCallback(); // 0x0000000184D7C270-0x0000000184D7C2B0

		// Methods
		public override string OnSetLogPathEvent(int methodId, int crashType); // 0x0000000189D2CCD0-0x0000000189D2CD80
		public override void OnLogUploadResultEvent(int methodId, int crashType, int result); // 0x0000000189D2CB70-0x0000000189D2CCD0
	}

	public delegate void LogCallbackDelegate(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 62276; 0x0000000181546280-0x00000001815462A0

	public delegate bool LogFilterDelegate(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 62277; 0x00000001814F3120-0x00000001814F3140

	// Constructors
	public CrashSightAgent(); // 0x00000001841E1670-0x00000001841E1680
	static CrashSightAgent(); // 0x00000001841A7870-0x00000001841A7E60

	// Methods
	public static void SetLogFilter(LogFilterDelegate filter); // 0x0000000189D2A0C8-0x0000000189D2A128
	public static void InitWithAppId(string appId, bool forceOnUiThread = false /* Metadata: 0x02350B65 */); // 0x0000000183B11DF0-0x0000000183B11F70
	public static void ReportException(Exception e, string message); // 0x0000000189D29968-0x0000000189D29AC4
	public static void ReportException(string name, string message, string stackTrace); // 0x0000000189D2974C-0x0000000189D298B4
	public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0 /* Metadata: 0x02350B66 */, string errorAttachmentPath = "" /* Metadata: 0x02350B67 */); // 0x0000000189D298B4-0x0000000189D29968
	public static void SetUserId(string userId); // 0x0000000183A86070-0x0000000183A86150
	public static void AddSceneData(string key, string value); // 0x000000018321F280-0x000000018321F3D0
	public static void SetUserValue(string key, int value); // 0x00000001843A7E70-0x00000001843A7F20
	public static void SetUserValue(string key, string value); // 0x000000018321F110-0x000000018321F170
	public static void SetUserValue(string key, string[] value); // 0x0000000183B5BFD0-0x0000000183B5C090
	public static void SetAppVersion(string appVersion); // 0x0000000184A223E0-0x0000000184A22490
	public static void ConfigCrashServerUrl(string crashServerUrl); // 0x0000000184B0E060-0x0000000184B0E110
	public static void SetLogPath(string logPath); // 0x0000000189D2A128-0x0000000189D2A174
	public static void ConfigDebugMode(bool enable); // 0x0000000184A064E0-0x0000000184A065D0
	public static void SetDeviceId(string deviceId); // 0x0000000189D29D88-0x0000000189D29DD4
	public static void ConfigCrashReporter(int logLevel); // 0x0000000189D28C18-0x0000000189D28C60
	public static void ConfigCrashReporter(CSLogSeverity logLevel); // 0x0000000189D28BD0-0x0000000189D28C18
	public static void PrintLog(CSLogSeverity level, string format, params object[] args); // 0x0000000183608920-0x0000000183608980
	public static void TestNativeCrash(); // 0x0000000189D2A6D0-0x0000000189D2A754
	public static void SetEnvironmentName(string serverEnv); // 0x0000000189D29E68-0x0000000189D29EB4
	public static void EnableAnrMonitor(int timeoutMs = 5000 /* Metadata: 0x02350B68 */); // 0x0000000189D28E3C-0x0000000189D28E84
	public static void DisableAnrMonitor(); // 0x0000000189D28DFC-0x0000000189D28E3C
	public static void RegisterCrashCallback(CrashSightCallback callback); // 0x0000000183B11C50-0x0000000183B11D10
	public static void UnregisterCrashCallback(); // 0x0000000189D2A8E0-0x0000000189D2A920
	public static void RegisterCrashLogCallback(CrashSightLogCallback callback); // 0x0000000183B11B40-0x0000000183B11C50
	public static void EnableExceptionHandler(); // 0x0000000189D28E84-0x0000000189D28F14
	public static void RegisterLogCallback(LogCallbackDelegate handler); // 0x0000000189D295CC-0x0000000189D2965C
	public static void UnregisterLogCallback(LogCallbackDelegate handler); // 0x0000000189D2A920-0x0000000189D2A984
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler); // 0x0000000189D2A010-0x0000000189D2A0C8
	public static void ConfigAutoQuitApplication(bool autoQuit); // 0x0000000189D28B34-0x0000000189D28B88
	public static void DebugLog(string tag, string format); // 0x000000018321F230-0x000000018321F280
	public static void _RegisterExceptionHandler(); // 0x0000000183B0D1D0-0x0000000183B0D490
	public static void _UnregisterExceptionHandler(); // 0x0000000189D2B0E8-0x0000000189D2B2B8
	public static void SetCrashSightStackTraceEnable(bool enable); // 0x00000001841E1670-0x00000001841E1680
	public static void ConfigCallbackType(int callbackType); // 0x0000000189D28B88-0x0000000189D28BD0
	public static void SetDeviceModel(string deviceModel); // 0x0000000189D29DD4-0x0000000189D29E20
	public static void ReportLogInfo(string msgType, string msg); // 0x0000000189D29B58-0x0000000189D29BB4
	public static void SetScene(string sceneId, bool upload = false /* Metadata: 0x02350B6A */); // 0x0000000189D2A280-0x0000000189D2A378
	public static void SetScene(int sceneId, bool upload = false /* Metadata: 0x02350B6B */); // 0x0000000189D2A378-0x0000000189D2A3D8
	public static long GetCrashThreadId(); // 0x0000000189D28F14-0x0000000189D28FA0
	public static void SetCustomizedDeviceID(string deviceId); // 0x0000000189D29CF0-0x0000000189D29D3C
	public static string GetSDKDefinedDeviceID(); // 0x0000000189D2907C-0x0000000189D290BC
	public static void SetCustomizedMatchID(string matchId); // 0x0000000189D29D3C-0x0000000189D29D88
	public static string GetSDKSessionID(); // 0x0000000189D290BC-0x0000000189D290FC
	public static void TestOomCrash(); // 0x0000000189D2A7D8-0x0000000189D2A85C
	public static void TestJavaCrash(); // 0x0000000189D2A64C-0x0000000189D2A6D0
	public static void TestANR(); // 0x0000000189D2A5C8-0x0000000189D2A64C
	public static string GetCrashUuid(); // 0x0000000189D28FA0-0x0000000189D28FE0
	public static void SetLogcatBufferSize(int size); // 0x0000000189D2A174-0x0000000189D2A1BC
	public static void TestOcCrash(); // 0x0000000189D2A754-0x0000000189D2A7D8
	public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath); // 0x0000000189D2A498-0x0000000189D2A548
	public static void StartMonitorFdCount(int interval, int limit, int dumpType); // 0x0000000189D2A548-0x0000000189D2A5C8
	public static int getExceptionType(string name); // 0x0000000189D2B444-0x0000000189D2B4B0
	public static void TestUseAfterFree(); // 0x0000000189D2A85C-0x0000000189D2A8E0
	public static void ReRegistAllMonitors(); // 0x0000000189D2954C-0x0000000189D295CC
	public static void CloseAllMonitors(); // 0x0000000189D28AC8-0x0000000189D28B34
	public static void setEnableGetPackageInfo(bool enable); // 0x0000000189D2B6C0-0x0000000189D2B778
	public static void setCatchMultiSignal(bool enable); // 0x0000000189D2B608-0x0000000189D2B6C0
	public static void enableDetailedPageTracing(bool enable); // 0x0000000189D2B38C-0x0000000189D2B444
	public static bool IsLastSessionCrash(); // 0x0000000189D294C4-0x0000000189D2954C
	public static string GetLastSessionUserId(); // 0x0000000189D28FE0-0x0000000189D2907C
	public static bool CheckFdCount(int limit, int dumpType, bool upload); // 0x0000000189D28A44-0x0000000189D28AC8
	public static void SetOomLogPath(string logPath); // 0x0000000189D2A1BC-0x0000000189D2A208
	public static void ReportJank(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int reportInfoOption, string jankAttachmentPath); // 0x0000000189D29AC4-0x0000000189D29B58
	public static void ReportStuck(int threadId, int maxChecks, long checkInterval, string name, string message, Dictionary<string, string> extInfo, int dumpNativeType, string attachPath); // 0x0000000189D29BB4-0x0000000189D29C58
	public static void SetVehEnable(bool enable); // 0x0000000189D2A3D8-0x0000000189D2A44C
	public static void ReportCrash(); // 0x0000000189D2965C-0x0000000189D296C8
	public static void ReportDump(string dump_path, bool is_async); // 0x0000000189D296C8-0x0000000189D2974C
	public static void SetExtraHandler(bool extra_handle_enable); // 0x0000000189D29F9C-0x0000000189D2A010
	public static void UploadGivenPathDump(string dump_dir, bool is_extra_check); // 0x0000000189D2A9D0-0x0000000189D2AA54
	public static void SetDumpType(int dump_type); // 0x0000000189D29E20-0x0000000189D29E68
	public static void AddValidExpCode(ulong exp_code); // 0x0000000189D289F8-0x0000000189D28A44
	public static void UploadCrashWithGuid(string guid); // 0x0000000189D2A984-0x0000000189D2A9D0
	public static void SetCrashUploadEnable(bool enable); // 0x0000000189D29C58-0x0000000189D29CA4
	public static void SetWorkSpace(string workspace); // 0x0000000189D2A44C-0x0000000189D2A498
	public static void SetCustomAttachDir(string path); // 0x0000000189D29CA4-0x0000000189D29CF0
	public static void SetErrorUploadInterval(int interval); // 0x0000000189D29F28-0x0000000189D29F9C
	public static void SetErrorUploadEnable(bool enable); // 0x0000000189D29EB4-0x0000000189D29F28
	public static void SetRecordFileDir(string record_dir); // 0x0000000189D2A208-0x0000000189D2A280
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03\uFF0C\u8BF7\u4F7F\u7528 InitWithAppId \u8FDB\u884C\u521D\u59CB\u5316")]
	public static void InitContext(string userId, string version, string key); // 0x0000000189D290FC-0x0000000189D292DC
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03\uFF0C\u8BF7\u4F7F\u7528 InitWithAppId \u8FDB\u884C\u521D\u59CB\u5316")]
	public static void Init(string app_id, string app_key, string app_version); // 0x0000000189D292DC-0x0000000189D294C4
	[Obsolete("\u8BE5\u63A5\u53E3\u5DF2\u5E9F\u5F03")]
	public static void ConfigDefault(string channel, string version, string user, long delay); // 0x0000000189D28C60-0x0000000189D28DFC
	private static void _OnLogCallbackHandlerMain(string condition, string stackTrace, UnityEngine.LogType type); // 0x000000018321F3F0-0x000000018321F450
	private static void _OnLogCallbackHandlerThreaded(string condition, string stackTrace, UnityEngine.LogType type); // 0x000000018321F450-0x000000018321F4B0
	private static void _OnLogCallbackHandler(string condition, string stackTrace, UnityEngine.LogType type, CSReportType rType); // 0x000000018321F4B0-0x000000018321F7B0
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args); // 0x0000000189D2AF2C-0x0000000189D2B0E8
	private static void _HandleException(Exception e, string message, bool uncaught); // 0x0000000189D2AA54-0x0000000189D2AF2C
	private static bool ShouldSkipFrame(string frame); // 0x0000000182F0CE30-0x0000000182F0D270
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace); // 0x0000000182F0E3C0-0x0000000182F0F8B0
	private static void AddTrackCustomData(); // 0x000000018321EDC0-0x000000018321F110
	private static void AddLocalLogFile(); // 0x00000001841E1670-0x00000001841E1680
	private static int valueOf(UnityEngine.LogType logLevel); // 0x000000018321FBA0-0x000000018321FBF0
	private static bool isEnableAutoReport(UnityEngine.LogType logLevel); // 0x000000018321FAD0-0x000000018321FBA0
	private static void _HandleException(UnityEngine.LogType logLevel, string name, string message, string stackTrace, bool uncaught, CSReportType rType); // 0x000000018321F7B0-0x000000018321FAD0
}

public class CrashSightAnrMonitor // TypeDefIndex: 62281
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
	protected static bool Paused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000189D2C088-0x0000000189D2C0D8 0x0000000189D2C0D8-0x0000000189D2C12C

	// Nested types
	[Serializable]
	[CompilerGenerated]
	private sealed class __c // TypeDefIndex: 62279
	{
		// Fields
		public static readonly __c __9; // 0x00
		public static Action __9__11_0; // 0x08
		public static Action __9__11_1; // 0x10
		public static Action __9__11_2; // 0x18

		// Constructors
		static __c(); // 0x0000000189D2E9D8-0x0000000189D2EA3C
		public __c(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void _Start_b__11_0(); // 0x0000000189D2E918-0x0000000189D2E958
		internal void _Start_b__11_1(); // 0x0000000189D2E958-0x0000000189D2E998
		internal void _Start_b__11_2(); // 0x0000000189D2E998-0x0000000189D2E9D8
	}

	[CompilerGenerated]
	private sealed class _UpdateUiStatus_d__13 : IEnumerator<object> // TypeDefIndex: 62280
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		private WaitForSecondsRealtime _waitForSeconds_5__2; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
		object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 

		// Constructors
		[DebuggerHidden]
		public _UpdateUiStatus_d__13(int __1__state); // 0x00000001814F51F0-0x00000001814F5220

		// Methods
		[DebuggerHidden]
		void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
		private bool MoveNext(); // 0x0000000189D2EA3C-0x0000000189D2EB98
		[DebuggerHidden]
		void IEnumerator.Reset(); // 0x0000000189D2EB98-0x0000000189D2EBE4
	}

	// Constructors
	public CrashSightAnrMonitor(); // 0x00000001841E1670-0x00000001841E1680
	static CrashSightAnrMonitor(); // 0x0000000189D2BFCC-0x0000000189D2C088

	// Methods
	public static void Start(int timeoutMs = 5000 /* Metadata: 0x02350B6C */); // 0x0000000189D2BAA0-0x0000000189D2BF38
	public static void Stop(); // 0x0000000189D2BF38-0x0000000189D2BF88
	[IteratorStateMachine(typeof(_UpdateUiStatus_d__13))]
	private static IEnumerator UpdateUiStatus(); // 0x0000000189D2BF88-0x0000000189D2BFCC
	private static void Run(); // 0x0000000189D2B844-0x0000000189D2BAA0
	private static void Report(); // 0x0000000189D2B778-0x0000000189D2B844
}

public class UnityAnrException : Exception // TypeDefIndex: 62282
{
	// Constructors
	internal UnityAnrException(); // 0x0000000189D366AC-0x0000000189D366F8
	internal UnityAnrException(string message); // 0x0000000189D36650-0x0000000189D366AC
	internal UnityAnrException(string message, Exception innerException); // 0x0000000189D366F8-0x0000000189D367A8
}

public abstract class CrashSightCallback // TypeDefIndex: 62283
{
	// Fields
	private static bool isQuitting; // 0x00
	private static object quitLocker; // 0x08

	// Constructors
	static CrashSightCallback(); // 0x00000001833295B0-0x0000000183329690
	protected CrashSightCallback(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	private static void OnApplicationQuitting(); // 0x0000000189D2C230-0x0000000189D2C324
	public static bool IsQuitting(); // 0x0000000189D2C12C-0x0000000189D2C230
	public abstract string OnCrashBaseRetEvent(int methodId, int crashType);
}

public abstract class CrashSightLogCallback // TypeDefIndex: 62284
{
	// Fields
	private static bool isQuitting; // 0x00
	private static object quitLocker; // 0x08

	// Constructors
	static CrashSightLogCallback(); // 0x0000000183329690-0x0000000183329770
	protected CrashSightLogCallback(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	private static void OnApplicationQuitting(); // 0x0000000189D2C428-0x0000000189D2C51C
	public static bool IsQuitting(); // 0x0000000189D2C324-0x0000000189D2C428
	public abstract string OnSetLogPathEvent(int methodId, int crashType);
	public abstract void OnLogUploadResultEvent(int methodId, int crashType, int result);
}

[AddComponentMenu("")]
public class CrashSightMonoBehaviour : MonoBehaviour // TypeDefIndex: 62285
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
	public static CrashSightMonoBehaviour Instance { get; } // 0x0000000189D2C7E8-0x0000000189D2C908 

	// Events
	public event Action ApplicationResuming {
		add; // 0x0000000189D2C754-0x0000000189D2C7E8
		remove; // 0x0000000189D2CA30-0x0000000189D2CAC4
	}
	public event Action ApplicationPausing {
		add; // 0x0000000189D2C62C-0x0000000189D2C6C0
		remove; // 0x0000000189D2C908-0x0000000189D2C99C
	}
	public event Action ApplicationQuitting {
		add; // 0x0000000189D2C6C0-0x0000000189D2C754
		remove; // 0x0000000189D2C99C-0x0000000189D2CA30
	}

	// Constructors
	public CrashSightMonoBehaviour(); // 0x0000000189D2C610-0x0000000189D2C62C

	// Methods
	public void UpdatePauseStatus(bool paused); // 0x0000000189D2C5DC-0x0000000189D2C610
	internal void OnApplicationPause(bool pauseStatus); // 0x0000000189D2C578-0x0000000189D2C580
	internal void OnApplicationFocus(bool hasFocus); // 0x0000000189D2C56C-0x0000000189D2C578
	private void OnApplicationQuit(); // 0x0000000189D2C580-0x0000000189D2C5DC
	private void Awake(); // 0x0000000189D2C51C-0x0000000189D2C56C
}

public class CrashSightStackTrace // TypeDefIndex: 62286
{
	// Fields
	public static bool enable; // 0x00
	private static string stackTrace; // 0x08

	// Constructors
	public CrashSightStackTrace(); // 0x00000001841E1670-0x00000001841E1680

	// Methods
	public static void setEnable(bool enable); // 0x00000001841E1670-0x00000001841E1680
	public static string ExtractStackTrace(); // 0x0000000189D2CAC4-0x0000000189D2CB70
}

namespace GCloud.UQM
{
	public delegate void OnUQMRetEventHandler<T>(T ret); // TypeDefIndex: 62287; 0x00000000-0x00000000

	public delegate string OnUQMStringRetEventHandler<T>(T ret, T crashType); // TypeDefIndex: 62288; 0x00000000-0x00000000

	public delegate string OnUQMStringRetSetLogPathEventHandler<T>(T ret, T crashType); // TypeDefIndex: 62289; 0x00000000-0x00000000

	public delegate void OnUQMRetLogUploadEventHandler<T>(T ret, T crashType, T result); // TypeDefIndex: 62290; 0x00000000-0x00000000

	public class UQM // TypeDefIndex: 62291
	{
		// Fields
		public const string LibName = "CrashSight64"; // Metadata: 0x02350B6E
		private static bool initialized; // 0x00
		public static bool isDebug; // 0x01
	
		// Constructors
		public UQM(); // 0x00000001841E1670-0x00000001841E1680
		static UQM(); // 0x0000000189D36618-0x0000000189D36650
	
		// Methods
		public static void Init(); // 0x0000000189D36554-0x0000000189D36618
	}

	public enum UQMCrashLevel // TypeDefIndex: 62292
	{
		CSLogLevelSilent = 0,
		CSLogLevelError = 1,
		CSLogLevelWarn = 2,
		CSLogLevelInfo = 3,
		CSLogLevelDebug = 4,
		CSLogLevelVerbose = 5
	}

	public static class UQMCrash // TypeDefIndex: 62293
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
		public static AndroidJavaClass CrashSightPlatform { get; } // 0x0000000189D35954-0x0000000189D35A38 
	
		// Events
		public static event OnUQMStringRetEventHandler<int> CrashBaseRetEvent {
			add; // 0x0000000183B12130-0x0000000183B12210
			remove; // 0x0000000189D35A38-0x0000000189D35AFC
		}
		public static event OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent {
			add; // 0x0000000183B12050-0x0000000183B12130
			remove; // 0x0000000189D35BC4-0x0000000189D35C8C
		}
		public static event OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent {
			add; // 0x0000000183B11F70-0x0000000183B12050
			remove; // 0x0000000189D35AFC-0x0000000189D35BC4
		}
	
		// Constructors
		static UQMCrash(); // 0x0000000184CE9450-0x0000000184CE9500
	
		// Methods
		private static extern void CS_InitContext(string id, string version, string key); // 0x0000000189D2EE6C-0x0000000189D2EF3C
		private static extern void CS_ReportExceptionW(int type, string name, string message, string stack_trace, string extras, bool is_async, string attachmentPath = "" /* Metadata: 0x02350B81 */); // 0x0000000183608AB0-0x0000000183608BB0
		private static extern void CS_SetUserValue(string key, string value); // 0x0000000183608980-0x0000000183608A00
		private static extern void CS_SetVehEnable(bool enable); // 0x0000000189D2F518-0x0000000189D2F590
		private static extern void CS_SetExtraHandler(bool extra_handle_enable); // 0x0000000189D2F4E4-0x0000000189D2F518
		private static extern void CS_SetCustomLogDirW(string log_path); // 0x0000000189D2F2D4-0x0000000189D2F354
		private static extern void CS_SetUserId(string user_id); // 0x0000000183A86210-0x0000000183A86260
		private static extern void CS_MonitorEnable(bool enable); // 0x0000000189D2EF3C-0x0000000189D2EFB4
		private static extern void CS_PrintLog(int level, string tag, string format, string arg); // 0x0000000183608A00-0x0000000183608AB0
		private static extern void CS_UploadGivenPathDump(string dump_dir, bool is_extra_check); // 0x0000000189D2F704-0x0000000189D2F798
		private static extern void CS_ReportCrash(); // 0x0000000189D2EFB4-0x0000000189D2F01C
		private static extern void CS_ReportDump(string dump_dir, bool is_async); // 0x0000000189D2F01C-0x0000000189D2F0B0
		private static extern void CS_SetEnvironmentName(string name); // 0x0000000189D2F458-0x0000000189D2F4E4
		private static extern void CS_InitWithAppId(string app_id); // 0x0000000183B12470-0x0000000183B124D0
		private static extern void CS_SetAppVersion(string app_version); // 0x0000000184A22540-0x0000000184A225A0
		private static extern void CS_ConfigCrashServerUrl(string crash_server_url); // 0x00000001838277E0-0x0000000183827880
		private static extern void CS_ConfigDebugMode(bool enable); // 0x0000000183827EB0-0x0000000183827EF0
		private static extern void CS_SetDeviceId(string device_id); // 0x0000000189D2F354-0x0000000189D2F3E0
		private static extern void CS_ConfigCrashReporter(int log_level); // 0x0000000189D2EDF4-0x0000000189D2EE6C
		private static extern void CS_TestNativeCrash(); // 0x0000000189D2F610-0x0000000189D2F678
		private static extern void CS_SetDumpType(int dump_type); // 0x0000000189D2F3E0-0x0000000189D2F458
		private static extern void CS_AddValidExpCode(ulong exp_code); // 0x0000000189D2ED7C-0x0000000189D2EDF4
		private static extern void CS_UploadCrashWithGuid(string guid); // 0x0000000189D2F678-0x0000000189D2F704
		private static extern void CS_SetCrashUploadEnable(bool enable); // 0x0000000189D2F1DC-0x0000000189D2F254
		private static extern void CS_SetWorkSpaceW(string workspace); // 0x0000000189D2F590-0x0000000189D2F610
		private static extern void CS_SetEngineInfo(string version, string buildConfig, string language, string locale); // 0x00000001838275C0-0x00000001838276D0
		private static extern void CS_SetCustomAttachDirW(string log_path); // 0x0000000189D2F254-0x0000000189D2F2D4
		private static extern void CS_UseSavedUserId(bool enable); // 0x0000000189D2F798-0x0000000189D2F810
		private static extern void CS_ReportStuck(int threadId, int maxChecks, int checkInterval, string name, string message, string extraInfo, int dumpNativeType, string attachPath); // 0x0000000189D2F0B0-0x0000000189D2F1DC
		private static void LoadCrashSightCoreSo(); // 0x00000001841E1670-0x00000001841E1680
		public static void ConfigCallbackType(int callbackType); // 0x0000000189D2FD74-0x0000000189D2FEFC
		public static void ConfigGameType(int gameType); // 0x0000000183B124D0-0x0000000183B125A0
		public static void ConfigAutoReportLogLevel(int level); // 0x0000000189D2FBE0-0x0000000189D2FD74
		public static void ConfigCrashServerUrl(string serverUrl); // 0x0000000184B0E110-0x0000000184B0E1C0
		public static void ConfigDebugMode(bool enable); // 0x0000000184A065D0-0x0000000184A066C0
		public static void ConfigDefault(string channel, string version, string user, long delay); // 0x0000000189D2FEFC-0x0000000189D3016C
		public static void InitWithAppId(string appId, bool forceOnUiThread); // 0x0000000183B12380-0x0000000183B12470
		public static void InitContext(string userId, string version, string key); // 0x0000000189D308B0-0x0000000189D30A58
		public static void LogRecord(int level, string message); // 0x0000000183608BF0-0x0000000183608DA0
		public static void AddSceneData(string k, string v); // 0x000000018321F170-0x000000018321F230
		public static void ReportException(int type, string name, string message, string stackTrace, string extras, bool quitProgram); // 0x0000000183608620-0x0000000183608850
		public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0 /* Metadata: 0x02350B82 */, string errorAttachmentPath = "" /* Metadata: 0x02350B83 */); // 0x0000000189D31B88-0x0000000189D31D8C
		public static void SetUserId(string userId); // 0x0000000183A86150-0x0000000183A86210
		public static void SetScene(string sceneId, bool upload); // 0x0000000189D33CB4-0x0000000189D33E70
		public static void ReRegistAllMonitors(); // 0x0000000189D316E4-0x0000000189D3184C
		public static void CloseAllMonitors(); // 0x0000000189D2FA78-0x0000000189D2FBE0
		public static void ReportLogInfo(string msgType, string msg); // 0x0000000189D320A4-0x0000000189D3220C
		public static void SetAppVersion(string appVersion); // 0x0000000184A22490-0x0000000184A22540
		public static void SetDeviceId(string deviceId); // 0x0000000189D32C38-0x0000000189D32DC0
		public static void SetCustomizedDeviceID(string deviceId); // 0x0000000189D32940-0x0000000189D32ABC
		public static string GetSDKDefinedDeviceID(); // 0x0000000189D305B8-0x0000000189D30734
		public static void SetCustomizedMatchID(string matchId); // 0x0000000189D32ABC-0x0000000189D32C38
		public static string GetSDKSessionID(); // 0x0000000189D30734-0x0000000189D308B0
		public static string GetCrashUuid(); // 0x0000000189D302C0-0x0000000189D3043C
		public static void SetDeviceModel(string deviceModel); // 0x0000000189D32DC0-0x0000000189D32F3C
		public static void SetLogPath(string logPath); // 0x0000000189D336DC-0x0000000189D33864
		public static void SetCrashCallback(); // 0x0000000183B11D80-0x0000000183B11DF0
		public static void UnsetCrashCallback(); // 0x0000000189D35190-0x0000000189D352E0
		public static void SetCrashLogCallback(); // 0x0000000183B11D10-0x0000000183B11D80
		internal static string OnCrashCallbackMessage(int methodId, int crashType); // 0x0000000183F04C00-0x0000000183F04D70
		internal static string OnCrashCallbackData(int methodId, int crashType); // 0x0000000189D30DC4-0x0000000189D30FA0
		internal static string OnCrashSetLogPathMessage(int methodId, int crashType); // 0x0000000189D31378-0x0000000189D3155C
		internal static string OnCrashLogUploadMessage(int methodId, int crashType, int result); // 0x0000000189D3117C-0x0000000189D31378
		internal static string OnCrashCallbackNoRet(int methodId, int crashType); // 0x0000000189D30FA0-0x0000000189D3117C
		public static void ConfigCallBack(); // 0x0000000183B11A30-0x0000000183B11A90
		public static void UnregisterCallBack(); // 0x0000000189D3513C-0x0000000189D35190
		public static void ConfigLogCallBack(); // 0x0000000183B119D0-0x0000000183B11A30
		public static void TestOomCrash(); // 0x0000000189D34E6C-0x0000000189D34FD4
		public static void TestJavaCrash(); // 0x0000000189D34A2C-0x0000000189D34B94
		public static void TestOcCrash(); // 0x0000000189D34D04-0x0000000189D34E6C
		public static void TestNativeCrash(); // 0x0000000189D34B94-0x0000000189D34D04
		public static void TestANR(); // 0x0000000189D348C4-0x0000000189D34A2C
		public static long GetCrashThreadId(); // 0x0000000189D3016C-0x0000000189D302C0
		public static void SetLogcatBufferSize(int size); // 0x0000000189D33864-0x0000000189D339D4
		public static void SetCallbackMsg(string data); // 0x0000000189D325CC-0x0000000189D32748
		public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath); // 0x0000000189D3432C-0x0000000189D34684
		public static void StartMonitorFdCount(int interval, int limit, int dumpType); // 0x0000000189D34684-0x0000000189D348C4
		public static int getExceptionType(string name); // 0x0000000189D357D4-0x0000000189D35954
		public static void TestUseAfterFree(); // 0x0000000189D34FD4-0x0000000189D3513C
		public static void SetServerEnv(string serverEnv); // 0x0000000189D33E70-0x0000000189D33FF8
		public static void SetVehEnable(bool enable); // 0x0000000189D33FF8-0x0000000189D341A4
		public static void ReportCrash(); // 0x0000000189D3184C-0x0000000189D319BC
		public static void ReportDump(string dump_path, bool is_async); // 0x0000000189D319BC-0x0000000189D31B88
		public static void SetExtraHandler(bool extra_handle_enable); // 0x0000000189D33530-0x0000000189D336DC
		public static void UploadGivenPathDump(string dump_dir, bool is_extra_check); // 0x0000000189D35468-0x0000000189D35634
		public static void SetErrorUploadInterval(int interval); // 0x0000000189D333C0-0x0000000189D33530
		public static void SetErrorUploadEnable(bool enable); // 0x0000000189D33238-0x0000000189D333C0
		public static void SetRecordFileDir(string record_dir); // 0x0000000189D33B50-0x0000000189D33CB4
		public static void Init(string app_id, string app_key, string app_version); // 0x0000000189D30A58-0x0000000189D30C70
		public static void setEnableGetPackageInfo(bool enable); // 0x0000000189D35E2C-0x0000000189D35FCC
		public static void SetDumpType(int dump_type); // 0x0000000189D32F3C-0x0000000189D330D0
		public static void AddValidExpCode(ulong exp_code); // 0x0000000189D2EBE4-0x0000000189D2ED7C
		public static void UploadCrashWithGuid(string guid); // 0x0000000189D352E0-0x0000000189D35468
		public static void SetCrashUploadEnable(bool enable); // 0x0000000189D32748-0x0000000189D328F4
		public static void SetWorkSpace(string workspace); // 0x0000000189D341A4-0x0000000189D3432C
		public static void SetEngineInfo(string version, string buildConfig, string language, string locale); // 0x0000000183B0B510-0x0000000183B0B6D0
		public static void setCatchMultiSignal(bool enable); // 0x0000000189D35C8C-0x0000000189D35E2C
		public static void enableDetailedPageTracing(bool enable); // 0x0000000189D35634-0x0000000189D357D4
		public static void useSavedUserId(bool enable); // 0x0000000189D35FCC-0x0000000189D36178
		public static void SetCustomAttachDir(string path); // 0x0000000189D328F4-0x0000000189D32940
		public static bool IsLastSessionCrash(); // 0x0000000189D30C70-0x0000000189D30DC4
		public static string GetLastSessionUserId(); // 0x0000000189D3043C-0x0000000189D305B8
		public static bool CheckFdCount(int limit, int dumpType, bool upload); // 0x0000000189D2F810-0x0000000189D2FA78
		public static void SetOomLogPath(string logPath); // 0x0000000189D339D4-0x0000000189D33B50
		public static void ReportJank(int type, string exceptionName, string exceptionMsg, string exceptionStack, string paramsJson, int reportInfoOption, string jankAttachmentPath); // 0x0000000189D31D8C-0x0000000189D320A4
		public static void ProcessEngineAnr(int type); // 0x0000000189D3155C-0x0000000189D316E4
		public static void SetEngineMainThread(); // 0x0000000189D330D0-0x0000000189D33238
		public static void ReportStuck(int threadId, int maxChecks, long checkInterval, string name, string message, Dictionary<string, string> extInfo, int dumpNativeType, string attachPath); // 0x0000000189D3220C-0x0000000189D325CC
	}

	public enum UQMMethodNameID // TypeDefIndex: 62294
	{
		UQM_CRASH_CALLBACK_EXTRA_DATA = 1011,
		UQM_CRASH_CALLBACK_EXTRA_MESSAGE = 1012,
		UQM_CRASH_CALLBACK_SET_LOG_PATH = 1013,
		UQM_CRASH_CALLBACK_LOG_UPLOAD_RESULT = 1014
	}

	internal class UQMLog // TypeDefIndex: 62296
	{
		// Fields
		private static Level level; // 0x00
		private const string header = "[CrashSightPlugin-Unity]"; // Metadata: 0x02350B8C
	
		// Nested types
		public enum Level // TypeDefIndex: 62295
		{
			None = 0,
			Log = 1,
			Warning = 2,
			Error = 3
		}
	
		// Constructors
		public UQMLog(); // 0x00000001841E1670-0x00000001841E1680
		static UQMLog(); // 0x0000000184D79810-0x0000000184D79850
	
		// Methods
		public static void SetLevel(Level l); // 0x0000000189D36414-0x0000000189D36468
		public static void Log(string message); // 0x0000000183608BB0-0x0000000183608BF0
		public static void LogWarning(string message); // 0x0000000189D36384-0x0000000189D36414
		public static void LogError(string message); // 0x0000000189D362F4-0x0000000189D36384
		public static void FullLog(string message); // 0x0000000189D36178-0x0000000189D362F4
	}

	public class RetArgsWrapper // TypeDefIndex: 62297
	{
		// Fields
		private readonly int methodId; // 0x10
		private readonly int crashType; // 0x14
		private readonly int logUploadResult; // 0x18
	
		// Properties
		public int MethodId { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		public int CrashType { get; } // 0x0000000184D882A0-0x0000000184D882B0 
		public int LogUploadResult { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
	
		// Constructors
		public RetArgsWrapper(int _methodId, int _crashType, int _logUploadResult); // 0x0000000184D88580-0x0000000184D88590
	}

	public class UQMMessageCenter : MonoBehaviour // TypeDefIndex: 62299
	{
		// Fields
		private static bool initialzed; // 0x00
		private static UQMMessageCenter instance; // 0x08
	
		// Properties
		public static UQMMessageCenter Instance { get; } // 0x0000000183B11740-0x0000000183B11980 
	
		// Nested types
		private delegate string UQMRetJsonEventHandler(int methodId, int callType, int logUploadResult); // TypeDefIndex: 62298; 0x00000001814F3120-0x00000001814F3140
	
		// Constructors
		public UQMMessageCenter(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		[AOT.MonoPInvokeCallback(typeof(UQMRetJsonEventHandler))]
		public static string OnUQMRet(int methodId, int crashType, int logUploadResult); // 0x0000000183F043E0-0x0000000183F04AA0
		private static extern void cs_setUnityCallback(UQMRetJsonEventHandler eventHandler); // 0x00000001838270A0-0x0000000183827130
		public void Init(); // 0x0000000183B12210-0x0000000183B12300
		public void Uninit(); // 0x0000000189D36468-0x0000000189D364BC
		private static string SynchronousDelegate(object arg); // 0x0000000183F04AA0-0x0000000183F04C00
	}
}

namespace GCloud.UQM.MiniJSON
{
	public static class Json // TypeDefIndex: 62303
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 62301
		{
			// Fields
			private const string WORD_BREAK = "{}[],:\""; // Metadata: 0x02350BA9
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get; } // 0x0000000189D2DA30-0x0000000189D2DA8C 
			private char NextChar { get; } // 0x0000000189D2D700-0x0000000189D2D75C 
			private string NextWord { get; } // 0x0000000189D2D980-0x0000000189D2DA30 
			private TOKEN NextToken { get; } // 0x0000000189D2D75C-0x0000000189D2D980 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 62300
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
			private Parser(string jsonString); // 0x0000000189D2D688-0x0000000189D2D700
	
			// Methods
			public static bool IsWordBreak(char c); // 0x0000000189D2CF7C-0x0000000189D2CFF4
			public static object Parse(string jsonString); // 0x0000000189D2D590-0x0000000189D2D688
			public void Dispose(); // 0x0000000189D2CEB4-0x0000000189D2CEEC
			private Dictionary<string, object> ParseObject(); // 0x0000000189D2D234-0x0000000189D2D340
			private List<object> ParseArray(); // 0x0000000189D2CFF4-0x0000000189D2D0BC
			private object ParseValue(); // 0x0000000189D2D56C-0x0000000189D2D590
			private object ParseByToken(TOKEN token); // 0x0000000189D2D0BC-0x0000000189D2D170
			private string ParseString(); // 0x0000000189D2D340-0x0000000189D2D56C
			private object ParseNumber(); // 0x0000000189D2D170-0x0000000189D2D234
			private void EatWhitespace(); // 0x0000000189D2CEEC-0x0000000189D2CF7C
		}
	
		private sealed class Serializer // TypeDefIndex: 62302
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer(); // 0x0000000189D2E8B4-0x0000000189D2E918
	
			// Methods
			public static string Serialize(object obj); // 0x0000000189D2E83C-0x0000000189D2E8B4
			private void SerializeValue(object value); // 0x0000000189D2E6B8-0x0000000189D2E83C
			private void SerializeObject(IDictionary obj); // 0x0000000189D2DE10-0x0000000189D2E218
			private void SerializeArray(IList anArray); // 0x0000000189D2DA8C-0x0000000189D2DE10
			private void SerializeString(string str); // 0x0000000189D2E440-0x0000000189D2E6B8
			private void SerializeOther(object value); // 0x0000000189D2E218-0x0000000189D2E440
		}
	
		// Methods
		public static object Deserialize(string json); // 0x0000000189D2CD80-0x0000000189D2CD9C
		public static string Serialize(object obj); // 0x0000000189D2CD9C-0x0000000189D2CDA4
	}
}
