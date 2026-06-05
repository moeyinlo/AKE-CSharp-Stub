/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;

// Image 86: Hypergryph.CloudClientBridge.dll - Assembly: Hypergryph.CloudClientBridge, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60250-60280

namespace Hypergryph.CloudClientBridge
{
	public class CloudClientManager : MonoBehaviour // TypeDefIndex: 60257
	{
		// Fields
		private static CloudClientManager _instance; // 0x00
		private static readonly object _instanceLock; // 0x08
		private bool isPipeConnected; // 0x18
		private bool isInitDone; // 0x19
	
		// Constructors
		public CloudClientManager() {} // 0x000000018317B060-0x000000018317B360
		static CloudClientManager() {} // 0x00000001839457B0-0x0000000183945DE0
	
		// Methods
		public static HGCloudClientBridge GetBridge() => default; // 0x0000000183944390-0x0000000183944690
		private static void AutoInitialize() {} // 0x00000001839417E0-0x0000000183942640
		private static void CreateInstance() {} // 0x0000000183942C90-0x0000000183944390
		private void Awake() {} // 0x0000000183942640-0x0000000183942C90
		private void Start() {} // 0x0000000183944C70-0x00000001839457B0
		private void OnDestroy() {} // 0x0000000183944690-0x0000000183944C70
	}

	public class CloudGameUtils // TypeDefIndex: 60258
	{
		// Constructors
		public CloudGameUtils() {} // Dummy constructor
	
		// Methods
		public static bool IsCloudGame() => default; // 0x0000000183946170-0x0000000183947430
	}

	public class CloudCallResult // TypeDefIndex: 60259
	{
		// Fields
		public string data; // 0x10
		public int code; // 0x18
		public string message; // 0x20
	
		// Constructors
		public CloudCallResult() {} // 0x0000000183941190-0x00000001839417E0
	}

	internal class ClientPipeMessage // TypeDefIndex: 60260
	{
		// Fields
		public bool isGlobalEvent; // 0x10
		public int eventId; // 0x14
		public string key; // 0x18
		public JToken data; // 0x20
		public int code; // 0x28
		public string message; // 0x30
	
		// Constructors
		public ClientPipeMessage() {} // 0x0000000183940B40-0x0000000183941190
	}

	public enum CloudGameGlobalEvent // TypeDefIndex: 60261
	{
		RESOLUTON_CHANGE = 0,
		BULLETIN_EVENT = 1,
		BULLETIN_OPEN_EVENT = 2,
		WEBPORTAL_SCHEME_JUMP = 3,
		WEBPORTAL_OPEN_EVENT = 4,
		PIPELINE_CONNECTED = 5,
		GAMEPAD_CHANGE = 6
	}

	public class StringValueAttribute : Attribute // TypeDefIndex: 60262
	{
		// Fields
		private readonly string _Value_k__BackingField; // 0x10
	
		// Properties
		public string Value { get; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public StringValueAttribute() {} // Dummy constructor
		public StringValueAttribute(string value) {} // 0x0000000182F85E60-0x0000000182F85EC0
	}

	public static class EnumExtensions // TypeDefIndex: 60263
	{
		// Methods
		public static string GetStringValue(Enum value) => default; // 0x0000000183947430-0x00000001839477A0
	}

	public class CloudGameEvent // TypeDefIndex: 60264
	{
		// Fields
		public int eventId; // 0x10
		public string key; // 0x18
		public string data; // 0x20
		public Action<CloudCallResult> callback; // 0x28
	
		// Constructors
		public CloudGameEvent() {} // 0x0000000183945DE0-0x0000000183946170
	}

	internal interface IEventReceiver // TypeDefIndex: 60265
	{
		// Methods
		void OnReceiveData(string dataString);
		void OnReceiveDataWithKey(string key, string dataString);
		void OnChangeResolutionEvent(int width, int height);
	}

	internal class EventQueueProcessor // TypeDefIndex: 60267
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
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 60266
		{
			// Fields
			public IEventReceiver receiver; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x00000001839516F0-0x0000000183952B30
	
			// Methods
			internal void _SetCallbacks_b__0(byte[] data, int size) {} // 0x000000018394DB10-0x000000018394F010
			internal void _SetCallbacks_b__1(string key, byte[] data, int size) {} // 0x000000018394F010-0x0000000183950140
			internal void _SetCallbacks_b__2(int width, int height) {} // 0x0000000183950140-0x00000001839516F0
		}
	
		// Constructors
		public EventQueueProcessor() {} // Dummy constructor
		public EventQueueProcessor(IEventReceiver eventReceiver) {} // 0x0000000183948280-0x0000000183948900
	
		// Methods
		private void SetCallbacks() {} // 0x000000018394ACC0-0x000000018394C930
		public void Start() {} // 0x0000000183949FE0-0x000000018394ACC0
		public void Stop() {} // 0x000000018394C930-0x000000018394DB10
		public void EnqueueEvent(CloudGameEvent cloudEvent) {} // 0x00000001839477A0-0x0000000183948280
		private void ProcessEventQueue() {} // 0x0000000183948900-0x0000000183949FE0
		private void InitPipeLine() {} // 0x0000000185492010-0x0000000185492020
		private void SendPendingEvents() {} // 0x0000000183974FC0-0x00000001839753E0
		private void CleanUp() {} // 0x00000001839753E0-0x0000000183976090
		private string GetErrorResultJson(string key, int eventId, int code, string message, JObject data) => default; // 0x0000000183976090-0x0000000183976AE0
	}

	public class FocusMessageSender : MonoBehaviour // TypeDefIndex: 60268
	{
		// Fields
		private TMP_InputField tmpInput; // 0x18
		private const uint WM_USER_FOCUS_GAINED = 1160; // Metadata: 0x020827A6
		private const uint WM_USER_FOCUS_LOST = 1161; // Metadata: 0x020827A8
		private IntPtr mainWindowHandle; // 0x20
	
		// Constructors
		public FocusMessageSender() {} // 0x000000018317B060-0x000000018317B360
	
		// Methods
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam); // 0x0000000183956080-0x0000000183956120
		private void SendWindowsMessage(IntPtr targetWindow, uint message, string text) {} // 0x0000000183956120-0x0000000183957850
		private static extern IntPtr FindWindow(string className, string windowName); // 0x0000000183952B30-0x0000000183952BD0
		private static extern IntPtr GetActiveWindow(); // 0x0000000183952BD0-0x0000000183952C40
		private static extern IntPtr GetForegroundWindow(); // 0x0000000183952C40-0x0000000183952CB0
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount); // 0x0000000183953ED0-0x00000001839540E0
		private static extern bool IsWindow(IntPtr hWnd); // 0x00000001839540E0-0x0000000183954120
		private IntPtr GetMainWindowHandle() => default; // 0x0000000183952CB0-0x0000000183953ED0
		private void Start() {} // 0x0000000183957850-0x0000000183958EA0
		private void OnFocusGained(string text) {} // 0x0000000183954120-0x0000000183955020
		private void OnFocusLost(string text) {} // 0x0000000183955020-0x0000000183956080
	}

	public class HGCloudClientBridge : IEventReceiver // TypeDefIndex: 60276
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
	
		// Properties
		internal static HGCloudClientBridge Instance { get => default; } // 0x0000000183965A60-0x00000001839675D0 
		internal static HGCloudClientBridge ExistingInstance { get => default; } // 0x0000000183969D70-0x000000018396BFD0 
	
		// Nested types
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 60269
		{
			// Fields
			public ConcurrentDictionary<int, Action<CloudCallResult>> keyCallbacks; // 0x10
			public HGCloudClientBridge __4__this; // 0x18
			public CloudCallResult result; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x000000018396DC10-0x000000018396E190
	
			// Methods
			internal void _HandleCommandNotSupported_b__0() {} // 0x000000018396D770-0x000000018396DC10
		}
	
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 60270
		{
			// Fields
			public HGCloudClientBridge __4__this; // 0x10
			public CloudCallResult result; // 0x18
			public string key; // 0x20
			public ConcurrentDictionary<int, Action<CloudCallResult>> callbacks; // 0x28
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x000000018396C600-0x000000018396D770
	
			// Methods
			internal void _HandleGlobalEvent_b__0() {} // 0x0000000183963050-0x0000000183963CB0
		}
	
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 60271
		{
			// Fields
			public int width; // 0x10
			public int height; // 0x14
			public ConcurrentDictionary<int, Action<CloudCallResult>> callbacks; // 0x18
			public HGCloudClientBridge __4__this; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass23_0() {} // 0x0000000183962A10-0x0000000183963050
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__0(CloudCallResult result) {} // 0x0000000183962000-0x0000000183962A10
		}
	
		private sealed class __c__DisplayClass23_1 // TypeDefIndex: 60272
		{
			// Fields
			public CloudCallResult callResult; // 0x10
			public __c__DisplayClass23_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass23_1() {} // 0x000000018395B630-0x000000018395D770
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__1() {} // 0x000000018395D770-0x000000018395F720
		}
	
		private sealed class __c__DisplayClass23_2 // TypeDefIndex: 60273
		{
			// Fields
			public CloudCallResult callResult; // 0x10
			public __c__DisplayClass23_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass23_2() {} // 0x000000018395F720-0x00000001839607C0
	
			// Methods
			internal void _Hypergryph.CloudClientBridge.IEventReceiver.OnChangeResolutionEvent_b__2() {} // 0x00000001839607C0-0x0000000183962000
		}
	
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 60274
		{
			// Fields
			public HGCloudClientBridge __4__this; // 0x10
			public Action<CloudCallResult> callback; // 0x18
			public CloudCallResult result; // 0x20
			public string key; // 0x28
	
			// Constructors
			public __c__DisplayClass24_0() {} // 0x0000000183963DB0-0x0000000183965090
	
			// Methods
			internal void _InvokeCallback_b__0() {} // 0x0000000183963CB0-0x0000000183963DB0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 60275
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, ConcurrentDictionary<int, Action<CloudCallResult>>> __9__29_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000183965090-0x0000000183965A60
			public __c() {} // 0x00000001839675D0-0x0000000183968980
	
			// Methods
			internal ConcurrentDictionary<int, Action<CloudCallResult>> _RegisterGlobalCallback_b__29_0(string _) => default; // 0x0000000183958EA0-0x000000018395A080
		}
	
		// Constructors
		private HGCloudClientBridge() {} // 0x000000018395A080-0x000000018395B630
		static HGCloudClientBridge() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void InitOnUI() {} // 0x000000018396BFD0-0x000000018396C600
		void IEventReceiver.OnReceiveData(string dataString) {} // 0x0000000183968980-0x0000000183969D70
		void IEventReceiver.OnReceiveDataWithKey(string key, string dataString) {} // 0x0000000185492010-0x0000000185492020
		private void HandleCommandNotSupported(ClientPipeMessage pipeMessage) {} // 0x0000000183976AE0-0x0000000183977A10
		private void HandleGlobalEvent(ClientPipeMessage pipeMessage) {} // 0x0000000185492010-0x0000000185492020
		private void HandleNormalEvent(ClientPipeMessage pipeMessage) {} // 0x0000000183977A10-0x0000000183978940
		void IEventReceiver.OnChangeResolutionEvent(int width, int height) {} // 0x0000000185492010-0x0000000185492020
		private void InvokeCallback(Action<CloudCallResult> callback, string key, int code, string message, string data, bool isGlobalEvent) {} // 0x0000000183978940-0x000000018397ACB0
		private void InvokeCallbackDirect(Action<CloudCallResult> callback, CloudCallResult result, string key) {} // 0x0000000185492010-0x0000000185492020
		private ClientPipeMessage ParseClientPipeMessage(string jsonString) => default; // 0x000000018397ACB0-0x000000018397BC00
		public void SendDataWithKey(string key, string data, Action<CloudCallResult> callback) {} // 0x0000000185492010-0x0000000185492020
		private string BuildCloudEventData(int eventId, string key, string userData) => default; // 0x000000018397BC00-0x000000018397CB50
		public int RegisterGlobalCallback(CloudGameGlobalEvent globalEvent, Action<CloudCallResult> callback) => default; // 0x0000000185492010-0x0000000185492020
		public void UnRegisterGlobalCallback(CloudGameGlobalEvent globalEvent, Action<CloudCallResult> callback) {} // 0x000000018397CB50-0x000000018397CB90
		public void Cleanup() {} // 0x000000018397E140-0x000000018397E4A0
		private void _Cleanup_b__31_0() {} // 0x00000001839749F0-0x0000000183974FC0
	}

	public class Logger // TypeDefIndex: 60278
	{
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 60277
		{
			// Fields
			public string logInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018396E190-0x000000018396EA40
	
			// Methods
			internal void _PrintLogToView_b__0() {} // 0x000000018396EA40-0x000000018396F030
		}
	
		// Constructors
		public Logger() {} // Dummy constructor
	
		// Methods
		public static void Debug(string message) {} // 0x000000018396F030-0x000000018396FBA0
		public static void Error(string message) {} // 0x0000000185492010-0x0000000185492020
		public static void PrintLogToView(string logInfo) {} // 0x000000018397CB90-0x000000018397E140
	}

	internal class UnityMainThread // TypeDefIndex: 60280
	{
		// Fields
		private static SynchronizationContext MainContext; // 0x00
		public static bool isDebug; // 0x08
		private static readonly object initLock; // 0x10
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 60279
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018397E4A0-0x000000018397ED40
	
			// Methods
			internal void _RunOnMainThread_b__0(object _) {} // 0x000000018397ED40-0x000000018397FAD0
		}
	
		// Constructors
		public UnityMainThread() {} // Dummy constructor
		static UnityMainThread() {} // 0x0000000181C4EF00-0x0000000181C4F5B0
	
		// Methods
		public static void InitOnUI() {} // 0x000000018397FAD0-0x0000000183980110
		public static void RunOnMainThread(Action action) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace WeLing.SDK
{
	public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 60251
	{
		// Constructors
		public MonoPInvokeCallbackAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class PipeWrapper // TypeDefIndex: 60256
	{
		// Fields
		public static string version; // 0x00
		public static Action<byte[], int> OnReceiveDataEvent; // 0x08
		public static Action<string, byte[], int> OnReceiveDataWithKeyEvent; // 0x10
		public static Action<string, byte[], int, string> OnReceiveDataWithKeyExEvent; // 0x18
		public static Action<int, int> OnChangeResolutionEvent; // 0x20
	
		// Nested types
		private delegate void _OnReceiveData(IntPtr data, ref int size); // TypeDefIndex: 60252; 0x0000000183973EF0-0x0000000183973F60
	
		private delegate void _OnReceiveDataWithKey(string key, IntPtr data, ref int size); // TypeDefIndex: 60253; 0x0000000183973F60-0x0000000183974100
	
		private delegate void _OnReceiveDataWithKeyEx(string key, IntPtr data, ref int size, string userID); // TypeDefIndex: 60254; 0x0000000183974230-0x00000001839742C0
	
		private delegate void _OnChangeResolution(int width, int height); // TypeDefIndex: 60255; 0x00000001839741A0-0x0000000183974230
	
		// Constructors
		public PipeWrapper() {} // Dummy constructor
		static PipeWrapper() {} // 0x00000001831C5680-0x00000001831C5690
	
		// Methods
		private static extern bool _InitEx(); // 0x0000000183971EC0-0x0000000183972790
		private static extern bool _Release(); // 0x0000000183972C90-0x0000000183973580
		private static extern bool _SendData(byte[] data, int size); // 0x0000000183973580-0x0000000183973E80
		private static extern bool _SendDataWithKey(string key, byte[] data, int size); // 0x000000018396FBA0-0x000000018396FF00
		private static extern bool _SetOnRecieveDataCallback(_OnReceiveData cb); // 0x000000018396FF00-0x00000001839716E0
		private static extern bool _SetOnDataWithKeyCallback(_OnReceiveDataWithKey cb); // 0x0000000183972790-0x0000000183972C90
		private static extern bool _SetOnDataWithKeyExCallback(_OnReceiveDataWithKeyEx cb); // 0x0000000183971B40-0x0000000183971EC0
		private static extern bool _SetOnChangeResolutionCallback(_OnChangeResolution cb); // 0x00000001839716E0-0x0000000183971B40
		private static void SimpleCallBackImp(IntPtr data, ref int size) {} // 0x00000001839743E0-0x00000001839749F0
		private static void WithKeyCallBackImp(string key, IntPtr data, ref int size) {} // 0x00000001839804C0-0x00000001839805F0
		private static void WithKeyExCallBackImp(string key, IntPtr data, ref int size, string userID) {} // 0x00000001831C5680-0x00000001831C5690
		private static void ChangeResolutionCallBackImp(int width, int height) {} // 0x0000000183980380-0x00000001839804C0
		public static bool Init() => default; // 0x0000000181A578C0-0x0000000181A578E0
		public static void Uninit() {} // 0x0000000183980240-0x0000000183980380
		public static bool SendData(byte[] data, int size) => default; // 0x00000001832D8120-0x00000001832D8140
		public static bool SendDataWithKey(string key, byte[] data, int size) => default; // 0x0000000183980110-0x0000000183980240
	}
}
