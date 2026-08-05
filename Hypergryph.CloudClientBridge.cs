/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;

// Image 78: Hypergryph.CloudClientBridge.dll - Assembly: Hypergryph.CloudClientBridge, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62439-62477
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.CloudClientBridge
{
	public class CloudClientManager : MonoBehaviour // TypeDefIndex: 62446
	{
		// Fields
		private static CloudClientManager _instance; // 0x00
		private static readonly object _instanceLock; // 0x08
		private bool isPipeConnected; // 0x18
		private bool isInitDone; // 0x19
	
		// Constructors
		public CloudClientManager(); // 0x0000000185393520-0x0000000185393538
		static CloudClientManager(); // 0x0000000184D30850-0x0000000184D308C0
	
		// Methods
		public static HGCloudClientBridge GetBridge(); // 0x0000000189DD21A4-0x0000000189DD21E4
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoInitialize(); // 0x0000000183FCD5D0-0x0000000183FCD680
		private static void CreateInstance(); // 0x0000000189DD1E88-0x0000000189DD21A4
		private void Awake(); // 0x0000000189DD1E20-0x0000000189DD1E88
		private void Start(); // 0x0000000189DD2244-0x0000000189DD2304
		private void OnDestroy(); // 0x0000000189DD21E4-0x0000000189DD2244
	}

	public class CloudGameUtils // TypeDefIndex: 62447
	{
		// Fields
		private static readonly object _lock; // 0x00
		private static string _gameVersion; // 0x08
		private static string _launchId; // 0x10
	
		// Constructors
		static CloudGameUtils(); // 0x0000000184CC76D0-0x0000000184CC77B0
	
		// Methods
		public static bool IsCloudGame(); // 0x00000001840BC700-0x00000001840BC870
		public static void InitGameVersionOnUI(); // 0x0000000189DD23F8-0x0000000189DD2460
		public static string GetGameVersion(); // 0x0000000189DD2358-0x0000000189DD23A8
		public static void InitLaunchIdOnUI(); // 0x0000000189DD2460-0x0000000189DD24EC
		public static string GetLaunchId(); // 0x0000000189DD23A8-0x0000000189DD23F8
	}

	public class CloudCallResult // TypeDefIndex: 62448
	{
		// Fields
		public string data; // 0x10
		public int code; // 0x18
		public string message; // 0x20
	
		// Constructors
		public CloudCallResult(); // 0x0000000189DD1D64-0x0000000189DD1DC4
	}

	internal class ClientPipeMessage // TypeDefIndex: 62449
	{
		// Fields
		[JsonProperty("isGlobalEvent")]
		public bool isGlobalEvent; // 0x10
		[JsonProperty("eventId")]
		public int eventId; // 0x14
		[JsonProperty("key")]
		public string key; // 0x18
		[JsonProperty("data")]
		public JToken data; // 0x20
		[JsonProperty("code")]
		public int code; // 0x28
		[JsonProperty("message")]
		public string message; // 0x30
	
		// Constructors
		public ClientPipeMessage(); // 0x0000000189DD1D04-0x0000000189DD1D64
	}

	public enum CloudGameGlobalEvent // TypeDefIndex: 62450
	{
		RESOLUTON_CHANGE = 0,
		BULLETIN_EVENT = 1,
		BULLETIN_OPEN_EVENT = 2,
		WEBPORTAL_SCHEME_JUMP = 3,
		WEBPORTAL_OPEN_EVENT = 4,
		PIPELINE_CONNECTED = 5,
		GAMEPAD_CHANGE = 6
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class StringValueAttribute : Attribute // TypeDefIndex: 62451
	{
		// Fields
		[CompilerGenerated]
		private readonly string _Value_k__BackingField; // 0x10
	
		// Properties
		public string Value { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public StringValueAttribute(string value); // 0x00000001853908C0-0x00000001853908D0
	}

	public static class EnumExtensions // TypeDefIndex: 62452
	{
		// Extension methods
		public static string GetStringValue(this Enum value); // 0x0000000189DD24EC-0x0000000189DD2588
	}

	public class EventLogWrapper // TypeDefIndex: 62458
	{
		// Fields
		private static readonly EventLogWrapper _instance; // 0x00
		[CompilerGenerated]
		private string _AppId_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Region_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _SdkVersion_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _GameVersion_k__BackingField; // 0x28
		[CompilerGenerated]
		private string _LaunchId_k__BackingField; // 0x30
		[CompilerGenerated]
		private long _Platform_k__BackingField; // 0x38
		[CompilerGenerated]
		private bool _IsWeb_k__BackingField; // 0x40
	
		// Properties
		private string AppId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		private string Region { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		private string SdkVersion { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		private string GameVersion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		private string LaunchId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		private long TsMs { get; } // 0x0000000189DD3078-0x0000000189DD30B8 
		public long Platform { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x0000000184D865B0-0x0000000184D865C0
		public bool IsWeb { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
		public static EventLogWrapper Instance { get; } // 0x0000000189DD3028-0x0000000189DD3078 
	
		// Nested types
		[CompilerGenerated]
		private struct _init_d__37 : IAsyncStateMachine // TypeDefIndex: 62453
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public EventLogWrapper __4__this; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000189DDB660-0x0000000189DDB9F0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001853982D4-0x00000001853982E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 62455
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public Dictionary<string, object> data; // 0x20
	
			// Nested types
			private struct __EventTrack_b__0_d : IAsyncStateMachine // TypeDefIndex: 62454
			{
				// Fields
				public int __1__state; // 0x00
				public AsyncTaskMethodBuilder __t__builder; // 0x08
				public __c__DisplayClass38_0 __4__this; // 0x20
				private TaskAwaiter __u__1; // 0x28
	
				// Methods
				private void MoveNext(); // 0x0000000189DDAC30-0x0000000189DDAEC0
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189DDAEC0-0x0000000189DDAF1C
			}
	
			// Constructors
			public __c__DisplayClass38_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal async System.Threading.Tasks.Task _EventTrack_b__0(); // 0x0000000189DDB328-0x0000000189DDB3D8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 62456
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public JObject properties; // 0x20
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ExecuteEventTrackSafely_b__0(); // 0x0000000189DDB3D8-0x0000000189DDB5FC
		}
	
		[CompilerGenerated]
		private struct _ExecuteEventTrackSafely_d__43 : IAsyncStateMachine // TypeDefIndex: 62457
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public EventLogWrapper __4__this; // 0x20
			public string name; // 0x28
			public Dictionary<string, object> data; // 0x30
			private __c__DisplayClass43_0 __8__1; // 0x38
			private TaskAwaiter<bool> __u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x0000000189DDA5A8-0x0000000189DDABD4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189DDABD4-0x0000000189DDAC30
		}
	
		// Constructors
		private EventLogWrapper(); // 0x0000000189DD2F60-0x0000000189DD3028
		static EventLogWrapper(); // 0x0000000189DD2EF0-0x0000000189DD2F60
	
		// Methods
		public static long GetCurrentTimeMs(); // 0x0000000189DD2778-0x0000000189DD27CC
		public async void init(); // 0x0000000189DD30B8-0x0000000189DD3158
		public void EventTrack(string name, Dictionary<string, object> data); // 0x0000000189DD2588-0x0000000189DD268C
		public void TrackPipelineInit(bool isSuccess, long times, long duration); // 0x0000000189DD2B1C-0x0000000189DD2CA4
		public void TrackSendDataCall(string eventName, long eventId, string data); // 0x0000000189DD2CA4-0x0000000189DD2E18
		public void TrackClientEvent(string eventName, long eventId, long code, string message, bool isGlobal, string data); // 0x0000000189DD27CC-0x0000000189DD29FC
		public void TrackException(string methodName, string extra); // 0x0000000189DD29FC-0x0000000189DD2B1C
		private async System.Threading.Tasks.Task ExecuteEventTrackSafely(string name, Dictionary<string, object> data); // 0x0000000189DD268C-0x0000000189DD2778
		[CompilerGenerated]
		private bool _init_b__37_0(); // 0x0000000189DD2E18-0x0000000189DD2EF0
	}

	public class CloudGameEvent // TypeDefIndex: 62459
	{
		// Fields
		public int eventId; // 0x10
		public string key; // 0x18
		public string data; // 0x20
		public Action<CloudCallResult> callback; // 0x28
	
		// Constructors
		public CloudGameEvent(); // 0x0000000189DD2304-0x0000000189DD2358
	}

	internal interface IEventReceiver // TypeDefIndex: 62460
	{
		// Methods
		void OnReceiveData(string dataString);
		void OnReceiveDataWithKey(string key, string dataString);
		void OnChangeResolutionEvent(int width, int height);
	}

	internal class EventQueueProcessor // TypeDefIndex: 62462
	{
		// Fields
		private readonly Queue<CloudGameEvent> eventQueue; // 0x10
		private readonly object queueLock; // 0x18
		private readonly Queue<CloudGameEvent> pendingEventQueue; // 0x20
		private readonly object pendingQueueLock; // 0x28
		private readonly AutoResetEvent autoQueueEvent; // 0x30
		private Thread processThread; // 0x38
		private bool isThreadRunning; // 0x40
		private bool isPipeConnected; // 0x41
		private bool isInitDone; // 0x42
		private int initTryTimes; // 0x44
		private readonly IEventReceiver eventReceiver; // 0x48
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 62461
		{
			// Fields
			public IEventReceiver receiver; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SetCallbacks_b__0(byte[] data, int size); // 0x0000000189DDAF1C-0x0000000189DDB088
			internal void _SetCallbacks_b__1(string key, byte[] data, int size); // 0x0000000189DDB088-0x0000000189DDB270
			internal void _SetCallbacks_b__2(int width, int height); // 0x0000000189DDB270-0x0000000189DDB328
		}
	
		// Constructors
		public EventQueueProcessor(IEventReceiver eventReceiver); // 0x0000000189DD5400-0x0000000189DD555C
	
		// Methods
		private void SetCallbacks(); // 0x0000000189DD4C2C-0x0000000189DD4DEC
		public void Start(); // 0x0000000189DD4DEC-0x0000000189DD4F20
		public void Stop(); // 0x0000000189DD4F20-0x0000000189DD5400
		public void EnqueueEvent(CloudGameEvent cloudEvent); // 0x0000000189DD3734-0x0000000189DD3908
		private void ProcessEventQueue(); // 0x0000000189DD3EDC-0x0000000189DD46C4
		private void InitPipeLine(); // 0x0000000189DD3D58-0x0000000189DD3EDC
		private void DoInitPipeLine(); // 0x0000000189DD3460-0x0000000189DD3734
		private static void ReportException(string methodName, Exception ex, JObject extraInfo = null); // 0x0000000189DD46C4-0x0000000189DD4998
		private void SendPendingEvents(); // 0x0000000189DD4998-0x0000000189DD4C2C
		private void CleanUp(); // 0x0000000189DD3158-0x0000000189DD3460
		private string GetErrorResultJson(string key, int eventId, int code, string message, JObject data); // 0x0000000189DD3908-0x0000000189DD3D58
	}

	public class FocusMessageSender : MonoBehaviour // TypeDefIndex: 62463
	{
		// Fields
		private TMP_InputField tmpInput; // 0x18
		private const uint WM_USER_FOCUS_GAINED = 1160; // Metadata: 0x02351B2B
		private const uint WM_USER_FOCUS_LOST = 1161; // Metadata: 0x02351B2D
		private IntPtr mainWindowHandle; // 0x20
	
		// Constructors
		public FocusMessageSender(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam); // 0x0000000189DD5AAC-0x0000000189DD5B4C
		private void SendWindowsMessage(IntPtr targetWindow, uint message, string text); // 0x0000000189DD5B4C-0x0000000189DD5E40
		private static extern IntPtr FindWindow(string className, string windowName); // 0x0000000189DD555C-0x0000000189DD55F0
		private static extern IntPtr GetActiveWindow(); // 0x0000000189DD55F0-0x0000000189DD5618
		private static extern IntPtr GetForegroundWindow(); // 0x0000000189DD5618-0x0000000189DD5640
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount); // 0x0000000189DD5750-0x0000000189DD5810
		private static extern bool IsWindow(IntPtr hWnd); // 0x0000000189DD5810-0x0000000189DD5844
		private IntPtr GetMainWindowHandle(); // 0x0000000189DD5640-0x0000000189DD5750
		private void Start(); // 0x0000000189DD5E40-0x0000000189DD5FD4
		private void OnFocusGained(string text); // 0x0000000189DD5844-0x0000000189DD5970
		private void OnFocusLost(string text); // 0x0000000189DD5970-0x0000000189DD5AAC
	}

	public class HGCloudClientBridge : IEventReceiver // TypeDefIndex: 62471
	{
		// Fields
		private static HGCloudClientBridge _instance; // 0x00
		private static readonly object _lock; // 0x08
		private bool isInitialized; // 0x10
		private EventQueueProcessor eventQueueProcessor; // 0x18
		private bool isPipeConnected; // 0x20
		private bool isInitDone; // 0x21
		private int nextEventIndex; // 0x24
		private readonly ConcurrentDictionary<int, Action<CloudCallResult>> _eventCallbacks; // 0x28
		private readonly ConcurrentDictionary<string, ConcurrentDictionary<int, Action<CloudCallResult>>> _globalCallbacks; // 0x30
		private readonly ConcurrentDictionary<int, Tuple<string, Action<CloudCallResult>>> _globalEventIdMap; // 0x38
		private CloudCallResult _cacheLaunchInfo; // 0x40
		private int _cachedScreenWidth; // 0x48
		private int _cachedScreenHeight; // 0x4C
	
		// Properties
		internal static HGCloudClientBridge Instance { get; } // 0x0000000189DD98B4-0x0000000189DD9A7C 
		internal static HGCloudClientBridge ExistingInstance { get; } // 0x0000000189DD97B4-0x0000000189DD98B4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 62464
		{
			// Fields
			public ConcurrentDictionary<int, Action<CloudCallResult>> keyCallbacks; // 0x10
			public HGCloudClientBridge __4__this; // 0x18
			public CloudCallResult result; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _HandleCommandNotSupported_b__0(); // 0x0000000182D33780-0x0000000182D346B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 62465
		{
			// Fields
			public HGCloudClientBridge __4__this; // 0x10
			public CloudCallResult result; // 0x18
			public string key; // 0x20
			public ConcurrentDictionary<int, Action<CloudCallResult>> callbacks; // 0x28
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _HandleGlobalEvent_b__0(); // 0x0000000182D346B0-0x0000000182D355E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 62466
		{
			// Fields
			public int width; // 0x10
			public int height; // 0x14
			public ConcurrentDictionary<int, Action<CloudCallResult>> callbacks; // 0x18
			public HGCloudClientBridge __4__this; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__0(CloudCallResult result); // 0x0000000182D355E0-0x0000000182D37A90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_1 // TypeDefIndex: 62467
		{
			// Fields
			public CloudCallResult callResult; // 0x10
			public __c__DisplayClass26_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass26_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__1(); // 0x0000000182D37A90-0x0000000182D389E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_2 // TypeDefIndex: 62468
		{
			// Fields
			public CloudCallResult callResult; // 0x10
			public __c__DisplayClass26_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass26_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__2(); // 0x0000000182D389E0-0x0000000182D39930
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 62469
		{
			// Fields
			public HGCloudClientBridge __4__this; // 0x10
			public Action<CloudCallResult> callback; // 0x18
			public CloudCallResult result; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _InvokeCallback_b__0(); // 0x0000000182D39930-0x0000000182D39980
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62470
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, ConcurrentDictionary<int, Action<CloudCallResult>>> __9__34_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189DDB5FC-0x0000000189DDB660
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ConcurrentDictionary<int, Action<CloudCallResult>> _RegisterGlobalCallback_b__34_0(string _); // 0x0000000182D331B0-0x0000000182D33780
		}
	
		// Constructors
		private HGCloudClientBridge(); // 0x0000000189DD9690-0x0000000189DD97B4
		static HGCloudClientBridge(); // 0x0000000189DD961C-0x0000000189DD9690
	
		// Methods
		public void InitOnUI(); // 0x0000000189DD7A1C-0x0000000189DD7C20
		void IEventReceiver.OnReceiveData(string dataString); // 0x0000000189DD79C0-0x0000000189DD7A1C
		void IEventReceiver.OnReceiveDataWithKey(string key, string dataString); // 0x0000000189DD7704-0x0000000189DD79C0
		private void HandleCommandNotSupported(ClientPipeMessage pipeMessage); // 0x0000000189DD66AC-0x0000000189DD6A9C
		private void HandleGlobalEvent(ClientPipeMessage pipeMessage); // 0x0000000189DD6A9C-0x0000000189DD6E98
		private void HandleNormalEvent(ClientPipeMessage pipeMessage); // 0x0000000189DD6E98-0x0000000189DD71D4
		private void UpdateEventLogPlatformInfo(JToken data); // 0x0000000189DD9208-0x0000000189DD961C
		void IEventReceiver.OnChangeResolutionEvent(int width, int height); // 0x0000000189DD71D4-0x0000000189DD7704
		private void InvokeCallback(Action<CloudCallResult> callback, string key, int code, string message, string data, bool isGlobalEvent); // 0x0000000189DD7DE4-0x0000000189DD7F8C
		private void InvokeCallbackDirect(Action<CloudCallResult> callback, CloudCallResult result, string key); // 0x0000000189DD7C20-0x0000000189DD7DE4
		private ClientPipeMessage ParseClientPipeMessage(string jsonString); // 0x0000000189DD7F8C-0x0000000189DD81E8
		private static void TrackClientEventSafe(ClientPipeMessage pipeMessage, string originalData); // 0x0000000189DD8C08-0x0000000189DD8DB8
		private static void ReportException(string methodName, Exception ex, JObject extraInfo = null); // 0x0000000189DD85F8-0x0000000189DD88CC
		public void SendDataWithKey(string key, string data, Action<CloudCallResult> callback); // 0x0000000189DD88CC-0x0000000189DD8C08
		private string BuildCloudEventData(int eventId, string key, string userData); // 0x0000000189DD5FD4-0x0000000189DD6368
		public int RegisterGlobalCallback(CloudGameGlobalEvent globalEvent, Action<CloudCallResult> callback); // 0x0000000189DD81E8-0x0000000189DD85F8
		private void DispatchCachedGlobalEventOnRegister(CloudGameGlobalEvent globalEvent, string key, Action<CloudCallResult> callback); // 0x0000000182D315F0-0x0000000182D31980
		public void UnRegisterGlobalCallback(CloudGameGlobalEvent globalEvent, Action<CloudCallResult> callback); // 0x0000000189DD8DB8-0x0000000189DD9208
		public void Cleanup(); // 0x0000000189DD6368-0x0000000189DD66AC
		[CompilerGenerated]
		private void _Cleanup_b__37_0(); // 0x0000000182D31980-0x0000000182D331B0
	}

	public static class CloudClientBridgeVersion // TypeDefIndex: 62472
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static CloudClientBridgeVersion(); // 0x0000000189DD1DC4-0x0000000189DD1E20
	}

	public class Logger // TypeDefIndex: 62474
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 62473
		{
			// Fields
			public string logInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PrintLogToView_b__0(); // 0x0000000184CC3670-0x0000000184CC3760
		}
	
		// Methods
		public static void Debug(string message); // 0x0000000183FCD680-0x0000000183FCD710
		public static void Error(string message); // 0x0000000189DD9A7C-0x0000000189DD9AE8
		public static void PrintLogToView(string logInfo); // 0x0000000183FCD710-0x0000000183FCD7E0
	}

	internal class UnityMainThread // TypeDefIndex: 62477
	{
		// Fields
		private static SynchronizationContext MainContext; // 0x00
		public static bool isDebug; // 0x08
		private static readonly object initLock; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 62475
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RunOnMainThread_b__0(object _); // 0x0000000186DFA030-0x0000000186DFA04C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0<T> // TypeDefIndex: 62476
		{
			// Fields
			public TaskCompletionSource<T> tcs;
			public Func<T> func;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _RunOnMainThread_b__0();
		}
	
		// Constructors
		static UnityMainThread(); // 0x0000000184D21660-0x0000000184D216F0
	
		// Methods
		public static void InitOnUI(); // 0x0000000183FCE180-0x0000000183FCE3F0
		public static void RunOnMainThread(Action action); // 0x0000000183FCD7E0-0x0000000183FCD8F0
		public static Task<T> RunOnMainThread<T>(Func<T> func);
	}
}

namespace WeLing.SDK
{
	public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 62440
	{
		// Constructors
		public MonoPInvokeCallbackAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class PipeWrapper // TypeDefIndex: 62445
	{
		// Fields
		public static string version; // 0x00
		public static Action<byte[], int> OnReceiveDataEvent; // 0x08
		public static Action<string, byte[], int> OnReceiveDataWithKeyEvent; // 0x10
		public static Action<string, byte[], int, string> OnReceiveDataWithKeyExEvent; // 0x18
		public static Action<int, int> OnChangeResolutionEvent; // 0x20
	
		// Nested types
		private delegate void _OnReceiveData(IntPtr data, ref int size); // TypeDefIndex: 62441; 0x00000001838E1420-0x00000001838E1430
	
		private delegate void _OnReceiveDataWithKey(string key, IntPtr data, ref int size); // TypeDefIndex: 62442; 0x0000000181546280-0x00000001815462A0
	
		private delegate void _OnReceiveDataWithKeyEx(string key, IntPtr data, ref int size, string userID); // TypeDefIndex: 62443; 0x00000001815547C0-0x00000001815547E0
	
		private delegate void _OnChangeResolution(int width, int height); // TypeDefIndex: 62444; 0x00000001838E1420-0x00000001838E1430
	
		// Constructors
		static PipeWrapper(); // 0x0000000189DDA54C-0x0000000189DDA5A8
	
		// Methods
		private static extern bool _InitEx(); // 0x0000000189DDA18C-0x0000000189DDA1FC
		private static extern bool _Release(); // 0x0000000189DDA1FC-0x0000000189DDA26C
		private static extern bool _SendData(byte[] data, int size); // 0x0000000189DDA328-0x0000000189DDA3BC
		private static extern bool _SendDataWithKey(string key, byte[] data, int size); // 0x0000000189DDA26C-0x0000000189DDA328
		private static extern bool _SetOnRecieveDataCallback(_OnReceiveData cb); // 0x0000000189DDA508-0x0000000189DDA54C
		private static extern bool _SetOnDataWithKeyCallback(_OnReceiveDataWithKey cb); // 0x0000000189DDA440-0x0000000189DDA484
		private static extern bool _SetOnDataWithKeyExCallback(_OnReceiveDataWithKeyEx cb); // 0x0000000189DDA484-0x0000000189DDA508
		private static extern bool _SetOnChangeResolutionCallback(_OnChangeResolution cb); // 0x0000000189DDA3BC-0x0000000189DDA440
		[MonoPInvokeCallback]
		private static void SimpleCallBackImp(IntPtr data, ref int size); // 0x0000000189DD9D98-0x0000000189DD9E8C
		[MonoPInvokeCallback]
		private static void WithKeyCallBackImp(string key, IntPtr data, ref int size); // 0x0000000189DD9F6C-0x0000000189DDA074
		[MonoPInvokeCallback]
		private static void WithKeyExCallBackImp(string key, IntPtr data, ref int size, string userID); // 0x0000000189DDA074-0x0000000189DDA18C
		[MonoPInvokeCallback]
		private static void ChangeResolutionCallBackImp(int width, int height); // 0x0000000189DD9AE8-0x0000000189DD9B70
		public static bool Init(); // 0x0000000189DD9B70-0x0000000189DD9CE0
		public static void Uninit(); // 0x0000000189DD9E8C-0x0000000189DD9F6C
		public static bool SendData(byte[] data, int size); // 0x0000000189DD9D40-0x0000000189DD9D98
		public static bool SendDataWithKey(string key, byte[] data, int size); // 0x0000000189DD9CE0-0x0000000189DD9D40
	}
}
