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

// Image 74: Hypergryph.CloudClientBridge.dll - Assembly: Hypergryph.CloudClientBridge, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89675-89715

namespace Hypergryph.CloudClientBridge
{
	public class CloudClientManager : MonoBehaviour // TypeDefIndex: 89682
	{
		// Fields
		private static CloudClientManager _instance; // 0x00
		private static readonly object _instanceLock; // 0x08
		private bool isPipeConnected; // 0x18
		private bool isInitDone; // 0x19
	
		// Constructors
		public CloudClientManager(); // 0x00000001878364A0-0x00000001878364B8
		static CloudClientManager(); // 0x00000001871C6D80-0x00000001871C6DF0
	
		// Methods
		public static HGCloudClientBridge GetBridge(); // 0x000000018C218C98-0x000000018C218CD8
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoInitialize(); // 0x0000000186143900-0x00000001861439B0
		private static void CreateInstance(); // 0x000000018C21897C-0x000000018C218C98
		private void Awake(); // 0x000000018C218914-0x000000018C21897C
		private void Start(); // 0x000000018C218D38-0x000000018C218DF8
		private void OnDestroy(); // 0x000000018C218CD8-0x000000018C218D38
	}

	public class CloudGameUtils // TypeDefIndex: 89683
	{
		// Fields
		private static readonly object _lock; // 0x00
		private static string _gameVersion; // 0x08
		private static string _launchId; // 0x10
	
		// Constructors
		static CloudGameUtils(); // 0x00000001870BE210-0x00000001870BE2F0
	
		// Methods
		public static bool IsCloudGame(); // 0x0000000186144090-0x0000000186144200
		public static void InitGameVersionOnUI(); // 0x000000018C218EEC-0x000000018C218F54
		public static string GetGameVersion(); // 0x000000018C218E4C-0x000000018C218E9C
		public static void InitLaunchIdOnUI(); // 0x000000018C218F54-0x000000018C218FF8
		public static string GetLaunchId(); // 0x000000018C218E9C-0x000000018C218EEC
	}

	public class CloudCallResult // TypeDefIndex: 89684
	{
		// Fields
		public string data; // 0x10
		public int code; // 0x18
		public string message; // 0x20
	
		// Constructors
		public CloudCallResult(); // 0x000000018C218858-0x000000018C2188B8
	}

	internal class ClientPipeMessage // TypeDefIndex: 89685
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
		public ClientPipeMessage(); // 0x000000018C2187F8-0x000000018C218858
	}

	public enum CloudGameGlobalEvent // TypeDefIndex: 89686
	{
		RESOLUTON_CHANGE = 0,
		BULLETIN_EVENT = 1,
		BULLETIN_OPEN_EVENT = 2,
		WEBPORTAL_SCHEME_JUMP = 3,
		WEBPORTAL_OPEN_EVENT = 4,
		PIPELINE_CONNECTED = 5,
		GAMEPAD_CHANGE = 6,
		SENSOR_EVENT = 7,
		BACK_KEY_EVENT = 8
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class StringValueAttribute : Attribute // TypeDefIndex: 89687
	{
		// Fields
		[CompilerGenerated]
		private readonly string _Value_k__BackingField; // 0x10
	
		// Properties
		public string Value { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public StringValueAttribute(string value); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public static class EnumExtensions // TypeDefIndex: 89688
	{
		// Extension methods
		public static string GetStringValue(this Enum value); // 0x000000018C218FF8-0x000000018C219094
	}

	public class EventLogWrapper // TypeDefIndex: 89694
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
		private string AppId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		private string Region { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		private string SdkVersion { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		private string GameVersion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		private string LaunchId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		private long TsMs { get; } // 0x000000018C219B88-0x000000018C219BC8 
		public long Platform { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x00000001855D8A50-0x00000001855D8A60
		public bool IsWeb { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public static EventLogWrapper Instance { get; } // 0x000000018C219B38-0x000000018C219B88 
	
		// Nested types
		[CompilerGenerated]
		private struct _init_d__37 : IAsyncStateMachine // TypeDefIndex: 89689
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public EventLogWrapper __4__this; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x000000018C223384-0x000000018C223718
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018783BAEC-0x000000018783BAF8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 89691
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public Dictionary<string, object> data; // 0x20
	
			// Nested types
			private struct __EventTrack_b__0_d : IAsyncStateMachine // TypeDefIndex: 89690
			{
				// Fields
				public int __1__state; // 0x00
				public AsyncTaskMethodBuilder __t__builder; // 0x08
				public __c__DisplayClass38_0 __4__this; // 0x20
				private TaskAwaiter __u__1; // 0x28
	
				// Methods
				private void MoveNext(); // 0x000000018C221E10-0x000000018C2220A8
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C2220A8-0x000000018C222104
			}
	
			// Constructors
			public __c__DisplayClass38_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal async System.Threading.Tasks.Task _EventTrack_b__0(); // 0x000000018C223048-0x000000018C2230FC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 89692
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public JObject properties; // 0x20
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ExecuteEventTrackSafely_b__0(); // 0x000000018C2230FC-0x000000018C223320
		}
	
		[CompilerGenerated]
		private struct _ExecuteEventTrackSafely_d__43 : IAsyncStateMachine // TypeDefIndex: 89693
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
			private void MoveNext(); // 0x000000018C22177C-0x000000018C221DB4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C221DB4-0x000000018C221E10
		}
	
		// Constructors
		private EventLogWrapper(); // 0x000000018C219A70-0x000000018C219B38
		static EventLogWrapper(); // 0x000000018C219A00-0x000000018C219A70
	
		// Methods
		public static long GetCurrentTimeMs(); // 0x000000018C219288-0x000000018C2192DC
		public async void init(); // 0x000000018C219BC8-0x000000018C219C68
		public void EventTrack(string name, Dictionary<string, object> data); // 0x000000018C219094-0x000000018C219198
		public void TrackPipelineInit(bool isSuccess, long times, long duration); // 0x000000018C21962C-0x000000018C2197B4
		public void TrackSendDataCall(string eventName, long eventId, string data); // 0x000000018C2197B4-0x000000018C219928
		public void TrackClientEvent(string eventName, long eventId, long code, string message, bool isGlobal, string data); // 0x000000018C2192DC-0x000000018C21950C
		public void TrackException(string methodName, string extra); // 0x000000018C21950C-0x000000018C21962C
		private async System.Threading.Tasks.Task ExecuteEventTrackSafely(string name, Dictionary<string, object> data); // 0x000000018C219198-0x000000018C219288
		[CompilerGenerated]
		private bool _init_b__37_0(); // 0x000000018C219928-0x000000018C219A00
	}

	public class CloudGameEvent // TypeDefIndex: 89695
	{
		// Fields
		public int eventId; // 0x10
		public string key; // 0x18
		public string data; // 0x20
		public Action<CloudCallResult> callback; // 0x28
	
		// Constructors
		public CloudGameEvent(); // 0x000000018C218DF8-0x000000018C218E4C
	}

	internal interface IEventReceiver // TypeDefIndex: 89696
	{
		// Methods
		void OnReceiveData(string dataString);
		void OnReceiveDataWithKey(string key, string dataString);
		void OnReceiveDataWithKeyEx(string key, string dataString, string userID);
		void OnChangeResolutionEvent(int width, int height);
	}

	internal class EventQueueProcessor // TypeDefIndex: 89698
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
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 89697
		{
			// Fields
			public IEventReceiver receiver; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SetCallbacks_b__0(byte[] data, int size); // 0x000000018C222164-0x000000018C2222D0
			internal void _SetCallbacks_b__1(string key, byte[] data, int size); // 0x000000018C2222D0-0x000000018C2224B8
			internal void _SetCallbacks_b__2(string key, byte[] data, int size, string userID); // 0x0000000184919B10-0x000000018491AB40
			internal void _SetCallbacks_b__3(int width, int height); // 0x000000018491AB40-0x000000018491B180
		}
	
		// Constructors
		public EventQueueProcessor(IEventReceiver eventReceiver); // 0x000000018C21C318-0x000000018C21C474
	
		// Methods
		private void SetCallbacks(); // 0x000000018C21B898-0x000000018C21BC0C
		public void Start(); // 0x000000018C21BC0C-0x000000018C21BD40
		public void Stop(); // 0x000000018C21BD40-0x000000018C21C318
		public void EnqueueEvent(CloudGameEvent cloudEvent); // 0x000000018C21A360-0x000000018C21A574
		private void ProcessEventQueue(); // 0x000000018C21AB54-0x000000018C21B340
		private void InitPipeLine(); // 0x000000018C21A9CC-0x000000018C21AB54
		private void DoInitPipeLine(); // 0x000000018C21A08C-0x000000018C21A360
		private static void ReportException(string methodName, Exception ex, JObject extraInfo = null); // 0x000000018C21B340-0x000000018C21B614
		private void SendPendingEvents(); // 0x000000018C21B614-0x000000018C21B898
		private void CleanUp(); // 0x000000018C219C68-0x000000018C21A08C
		private string GetErrorResultJson(string key, int eventId, int code, string message, JObject data); // 0x000000018C21A574-0x000000018C21A9CC
	}

	internal class ExEventQueueProcessor // TypeDefIndex: 89700
	{
		// Fields
		private readonly Queue<ExEventPayload> _queue; // 0x10
		private readonly object _queueLock; // 0x18
		private readonly AutoResetEvent _signal; // 0x20
		private Thread _thread; // 0x28
		private bool _isRunning; // 0x30
		private readonly Action<string, string, string> _handler; // 0x38
	
		// Nested types
		private class ExEventPayload // TypeDefIndex: 89699
		{
			// Fields
			public string key; // 0x10
			public string dataString; // 0x18
			public string userID; // 0x20
	
			// Constructors
			public ExEventPayload(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public ExEventQueueProcessor(Action<string, string, string> handler); // 0x0000000184917190-0x00000001849182E0
	
		// Methods
		public void Start(); // 0x00000001849149A0-0x0000000184915DA0
		public void Stop(); // 0x0000000184915DA0-0x0000000184917190
		public void Enqueue(string key, string dataString, string userID); // 0x0000000184910C10-0x00000001849120A0
		private void ProcessLoop(); // 0x00000001849120A0-0x0000000184912DC0
		private static void ReportException(string methodName, Exception ex, JObject extraInfo = null); // 0x0000000184912DC0-0x00000001849149A0
	}

	public class FocusMessageSender : MonoBehaviour // TypeDefIndex: 89701
	{
		// Fields
		private TMP_InputField tmpInput; // 0x18
		private const uint WM_USER_FOCUS_GAINED = 1160; // Metadata: 0x0264A2E3
		private const uint WM_USER_FOCUS_LOST = 1161; // Metadata: 0x0264A2E5
		private IntPtr mainWindowHandle; // 0x20
	
		// Constructors
		public FocusMessageSender(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam); // 0x000000018C21C9D8-0x000000018C21CA78
		private void SendWindowsMessage(IntPtr targetWindow, uint message, string text); // 0x000000018C21CA78-0x000000018C21CD70
		private static extern IntPtr FindWindow(string className, string windowName); // 0x000000018C21C474-0x000000018C21C50C
		private static extern IntPtr GetActiveWindow(); // 0x000000018C21C50C-0x000000018C21C534
		private static extern IntPtr GetForegroundWindow(); // 0x000000018C21C534-0x000000018C21C55C
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount); // 0x000000018C21C66C-0x000000018C21C72C
		private static extern bool IsWindow(IntPtr hWnd); // 0x000000018C21C72C-0x000000018C21C760
		private IntPtr GetMainWindowHandle(); // 0x000000018C21C55C-0x000000018C21C66C
		private void Start(); // 0x000000018C21CD70-0x000000018C21CF04
		private void OnFocusGained(string text); // 0x000000018C21C760-0x000000018C21C894
		private void OnFocusLost(string text); // 0x000000018C21C894-0x000000018C21C9D8
	}

	public class HGCloudClientBridge : IEventReceiver // TypeDefIndex: 89709
	{
		// Fields
		private static HGCloudClientBridge _instance; // 0x00
		private static readonly object _lock; // 0x08
		private bool isInitialized; // 0x10
		private EventQueueProcessor eventQueueProcessor; // 0x18
		private int nextEventIndex; // 0x20
		private readonly ConcurrentDictionary<int, Action<CloudCallResult>> _eventCallbacks; // 0x28
		private readonly ConcurrentDictionary<string, ConcurrentDictionary<int, Action<CloudCallResult>>> _globalCallbacks; // 0x30
		private readonly ConcurrentDictionary<int, Tuple<string, Action<CloudCallResult>>> _globalEventIdMap; // 0x38
		private CloudCallResult _cacheLaunchInfo; // 0x40
		private int _cachedScreenWidth; // 0x48
		private int _cachedScreenHeight; // 0x4C
		private ExEventQueueProcessor _exEventQueueProcessor; // 0x50
	
		// Properties
		internal static HGCloudClientBridge Instance { get; } // 0x000000018C220A84-0x000000018C220C44 
		internal static HGCloudClientBridge ExistingInstance { get; } // 0x000000018C220984-0x000000018C220A84 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 89702
		{
			// Fields
			public ConcurrentDictionary<int, Action<CloudCallResult>> keyCallbacks; // 0x10
			public HGCloudClientBridge __4__this; // 0x18
			public CloudCallResult result; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _HandleCommandNotSupported_b__0(); // 0x000000018C2224B8-0x000000018C222620
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 89703
		{
			// Fields
			public HGCloudClientBridge __4__this; // 0x10
			public CloudCallResult result; // 0x18
			public string key; // 0x20
			public ConcurrentDictionary<int, Action<CloudCallResult>> callbacks; // 0x28
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _HandleGlobalEvent_b__0(); // 0x000000018C222620-0x000000018C222788
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 89704
		{
			// Fields
			public int width; // 0x10
			public int height; // 0x14
			public ConcurrentDictionary<int, Action<CloudCallResult>> callbacks; // 0x18
			public HGCloudClientBridge __4__this; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__0(CloudCallResult result); // 0x000000018C222788-0x000000018C222D00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_1 // TypeDefIndex: 89705
		{
			// Fields
			public CloudCallResult callResult; // 0x10
			public __c__DisplayClass26_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass26_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__1(); // 0x000000018C222D00-0x000000018C222E88
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_2 // TypeDefIndex: 89706
		{
			// Fields
			public CloudCallResult callResult; // 0x10
			public __c__DisplayClass26_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass26_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__2(); // 0x000000018C222E88-0x000000018C223010
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 89707
		{
			// Fields
			public HGCloudClientBridge __4__this; // 0x10
			public Action<CloudCallResult> callback; // 0x18
			public CloudCallResult result; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _InvokeCallback_b__0(); // 0x000000018C223010-0x000000018C223048
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89708
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, ConcurrentDictionary<int, Action<CloudCallResult>>> __9__34_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C223320-0x000000018C223384
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ConcurrentDictionary<int, Action<CloudCallResult>> _RegisterGlobalCallback_b__34_0(string _); // 0x000000018C222104-0x000000018C222164
		}
	
		// Constructors
		private HGCloudClientBridge(); // 0x000000018C220860-0x000000018C220984
		static HGCloudClientBridge(); // 0x000000018C2207EC-0x000000018C220860
	
		// Methods
		public void InitOnUI(); // 0x000000018C21EA10-0x000000018C21ED58
		void IEventReceiver.OnReceiveData(string dataString); // 0x000000018C21E9B4-0x000000018C21EA10
		void IEventReceiver.OnReceiveDataWithKey(string key, string dataString); // 0x000000018C21E6F4-0x000000018C21E9B4
		void IEventReceiver.OnReceiveDataWithKeyEx(string key, string dataString, string userID); // 0x00000001849192C0-0x0000000184919B10
		private void HandleExPipeMessage(string key, string dataString, string userID); // 0x00000001849182E0-0x00000001849192C0
		private void HandleCommandNotSupported(ClientPipeMessage pipeMessage); // 0x000000018C21D7B8-0x000000018C21DBBC
		private void HandleGlobalEvent(ClientPipeMessage pipeMessage); // 0x000000018C21DBBC-0x000000018C21DFC0
		private void HandleNormalEvent(ClientPipeMessage pipeMessage); // 0x000000018C21DFC0-0x000000018C21E2F8
		private void UpdateEventLogPlatformInfo(JToken data); // 0x000000018C2203D8-0x000000018C2207EC
		void IEventReceiver.OnChangeResolutionEvent(int width, int height); // 0x000000018C21E2F8-0x000000018C21E6F4
		private void InvokeCallback(Action<CloudCallResult> callback, string key, int code, string message, string data, bool isGlobalEvent); // 0x000000018C21EF1C-0x000000018C21F0C4
		private void InvokeCallbackDirect(Action<CloudCallResult> callback, CloudCallResult result, string key); // 0x000000018C21ED58-0x000000018C21EF1C
		private ClientPipeMessage ParseClientPipeMessage(string jsonString); // 0x000000018C21F0C4-0x000000018C21F320
		private static void TrackClientEventSafe(ClientPipeMessage pipeMessage, string originalData); // 0x000000018C21FBE8-0x000000018C21FD94
		private static void ReportException(string methodName, Exception ex, JObject extraInfo = null); // 0x000000018C21F5D8-0x000000018C21F8AC
		public void SendDataWithKey(string key, string data, Action<CloudCallResult> callback); // 0x000000018C21F8AC-0x000000018C21FBE8
		private string BuildCloudEventData(int eventId, string key, string userData); // 0x000000018C21CF04-0x000000018C21D298
		public int RegisterGlobalCallback(CloudGameGlobalEvent globalEvent, Action<CloudCallResult> callback); // 0x000000018C21F320-0x000000018C21F5D8
		private void DispatchCachedGlobalEventOnRegister(CloudGameGlobalEvent globalEvent, string key, Action<CloudCallResult> callback); // 0x000000018C21D6F0-0x000000018C21D7B8
		public void UnRegisterGlobalCallback(CloudGameGlobalEvent globalEvent, Action<CloudCallResult> callback); // 0x000000018C21FF80-0x000000018C2203D8
		public void Cleanup(); // 0x000000018C21D298-0x000000018C21D6F0
		[CompilerGenerated]
		private void _Cleanup_b__37_0(); // 0x000000018C21FD94-0x000000018C21FF80
	}

	public static class CloudClientBridgeVersion // TypeDefIndex: 89710
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static CloudClientBridgeVersion(); // 0x000000018C2188B8-0x000000018C218914
	}

	public class Logger // TypeDefIndex: 89712
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 89711
		{
			// Fields
			public string logInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PrintLogToView_b__0(); // 0x00000001850D0530-0x00000001850D0620
		}
	
		// Methods
		public static void Debug(string message); // 0x00000001861439B0-0x0000000186143A40
		public static void Error(string message); // 0x000000018C220C44-0x000000018C220CB0
		public static void PrintLogToView(string logInfo); // 0x0000000186143A40-0x0000000186143B10
	}

	internal class UnityMainThread // TypeDefIndex: 89715
	{
		// Fields
		private static SynchronizationContext MainContext; // 0x00
		public static bool isDebug; // 0x08
		private static readonly object initLock; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 89713
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RunOnMainThread_b__0(object _); // 0x00000001890ADBF0-0x00000001890ADC0C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0<T> // TypeDefIndex: 89714
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
		static UnityMainThread(); // 0x000000018717F730-0x000000018717F7C0
	
		// Methods
		public static void InitOnUI(); // 0x00000001861B38F0-0x00000001861B3B30
		public static void RunOnMainThread(Action action); // 0x0000000186143B10-0x0000000186143C20
		public static Task<T> RunOnMainThread<T>(Func<T> func);
	}
}

namespace WeLing.SDK
{
	public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 89676
	{
		// Constructors
		public MonoPInvokeCallbackAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class PipeWrapper // TypeDefIndex: 89681
	{
		// Fields
		public static string version; // 0x00
		public static Action<byte[], int> OnReceiveDataEvent; // 0x08
		public static Action<string, byte[], int> OnReceiveDataWithKeyEvent; // 0x10
		public static Action<string, byte[], int, string> OnReceiveDataWithKeyExEvent; // 0x18
		public static Action<int, int> OnChangeResolutionEvent; // 0x20
	
		// Nested types
		private delegate void _OnReceiveData(IntPtr data, ref int size); // TypeDefIndex: 89677; 0x00000001859B7730-0x00000001859B7740
	
		private delegate void _OnReceiveDataWithKey(string key, IntPtr data, ref int size); // TypeDefIndex: 89678; 0x00000001811DF7F0-0x00000001811DF810
	
		private delegate void _OnReceiveDataWithKeyEx(string key, IntPtr data, ref int size, string userID); // TypeDefIndex: 89679; 0x00000001811CDB70-0x00000001811CDB90
	
		private delegate void _OnChangeResolution(int width, int height); // TypeDefIndex: 89680; 0x00000001859B7730-0x00000001859B7740
	
		// Constructors
		static PipeWrapper(); // 0x000000018C221720-0x000000018C22177C
	
		// Methods
		private static extern bool _InitEx(); // 0x000000018C221368-0x000000018C2213D4
		private static extern bool _Release(); // 0x000000018C2213D4-0x000000018C221440
		private static extern bool _SendData(byte[] data, int size); // 0x000000018C2214FC-0x000000018C221590
		private static extern bool _SendDataWithKey(string key, byte[] data, int size); // 0x000000018C221440-0x000000018C2214FC
		private static extern bool _SetOnRecieveDataCallback(_OnReceiveData cb); // 0x000000018C2216DC-0x000000018C221720
		private static extern bool _SetOnDataWithKeyCallback(_OnReceiveDataWithKey cb); // 0x000000018C221614-0x000000018C221658
		private static extern bool _SetOnDataWithKeyExCallback(_OnReceiveDataWithKeyEx cb); // 0x000000018C221658-0x000000018C2216DC
		private static extern bool _SetOnChangeResolutionCallback(_OnChangeResolution cb); // 0x000000018C221590-0x000000018C221614
		[MonoPInvokeCallback]
		private static void SimpleCallBackImp(IntPtr data, ref int size); // 0x000000018C220F60-0x000000018C221054
		[MonoPInvokeCallback]
		private static void WithKeyCallBackImp(string key, IntPtr data, ref int size); // 0x000000018C221140-0x000000018C22124C
		[MonoPInvokeCallback]
		private static void WithKeyExCallBackImp(string key, IntPtr data, ref int size, string userID); // 0x000000018C22124C-0x000000018C221368
		[MonoPInvokeCallback]
		private static void ChangeResolutionCallBackImp(int width, int height); // 0x000000018C220CB0-0x000000018C220D38
		public static bool Init(); // 0x000000018C220D38-0x000000018C220EA8
		public static void Uninit(); // 0x000000018C221054-0x000000018C221140
		public static bool SendData(byte[] data, int size); // 0x000000018C220F08-0x000000018C220F60
		public static bool SendDataWithKey(string key, byte[] data, int size); // 0x000000018C220EA8-0x000000018C220F08
	}
}
