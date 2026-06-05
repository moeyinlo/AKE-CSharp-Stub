/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

// Image 91: Hypergryph.SpeedTest.dll - Assembly: Hypergryph.SpeedTest, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60386-60418

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 60418
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_32 _4DAABD10C615552E680FD1F3F9C9E1B1C74413B5F519EDE1335CD44C46B11EC8; // 0x00 // Static value (base64): wPMOHOdju8Icw1WjQwOsUDmURL/2jEoirzmMChZu4UM= - Metadata: 0x020828E4
	internal static readonly __StaticArrayInitTypeSize_16 _701AA427DC569405D7608BAD336BBED96E382E97EE07C02CFED96D856E313AE5; // 0x20 // Static value (base64): M0Z4YRknUGSVAZNyZGCEAA== - Metadata: 0x0208290C

	// Nested types
	private struct __StaticArrayInitTypeSize_16 // TypeDefIndex: 60416
	{
	}

	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 60417
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Hypergryph.SpeedTest
{
	public class EventLogWrapper // TypeDefIndex: 60393
	{
		// Fields
		private static readonly EventLogWrapper _instance; // 0x00
		private string _appId; // 0x10
		private string _gameVersion; // 0x18
	
		// Properties
		public static EventLogWrapper Instance { get => default; } // 0x000000018A99166C-0x000000018A9916C8 
	
		// Nested types
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 60387
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string region; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x0000000185EF89F0-0x0000000185EF8A50
	
			// Methods
			internal bool _init_b__0() => default; // 0x000000018A98DD94-0x000000018A98DDE4
		}
	
		private struct _init_d__11 : IAsyncStateMachine // TypeDefIndex: 60388
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public EventLogWrapper __4__this; // 0x28
			private __c__DisplayClass11_0 __8__1; // 0x30
			private TaskAwaiter __u__1; // 0x38
			private TaskAwaiter<bool> __u__2; // 0x40
	
			// Methods
			private void MoveNext() {} // 0x00000001850E13A0-0x00000001850E1450
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018A98DBBC-0x000000018A98DCA8
		}
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 60390
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public Dictionary<string, object> data; // 0x20
	
			// Nested types
			private struct __EventTrack_b__0_d : IAsyncStateMachine // TypeDefIndex: 60389
			{
				// Fields
				public int __1__state; // 0x00
				public AsyncTaskMethodBuilder __t__builder; // 0x08
				public __c__DisplayClass12_0 __4__this; // 0x20
				private TaskAwaiter __u__1; // 0x28
	
				// Methods
				private void MoveNext() {} // 0x000000018A98DCA8-0x000000018A98DD94
				private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x0000000185EF8980-0x0000000185EF89F0
			}
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal System.Threading.Tasks.Task _EventTrack_b__0() => default; // 0x0000000185C1E340-0x0000000185C1E370
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 60391
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public JObject properties; // 0x20
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x00000001850906A0-0x0000000185090BE0
	
			// Methods
			internal bool _ExecuteEventTrackSafely_b__0() => default; // 0x0000000186475504-0x0000000186475510
		}
	
		private struct _ExecuteEventTrackSafely_d__13 : IAsyncStateMachine // TypeDefIndex: 60392
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public EventLogWrapper __4__this; // 0x20
			public string name; // 0x28
			public Dictionary<string, object> data; // 0x30
			private __c__DisplayClass13_0 __8__1; // 0x38
			private TaskAwaiter<bool> __u__1; // 0x40
	
			// Methods
			private void MoveNext() {} // 0x0000000185492010-0x0000000185492020
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018A9916C8-0x000000018A991778
		}
	
		// Constructors
		private EventLogWrapper() {} // 0x000000018A9913DC-0x000000018A99166C
		static EventLogWrapper() {} // 0x000000018A990798-0x000000018A9907F4
	
		// Methods
		public void init() {} // 0x0000000185492010-0x0000000185492020
		public void EventTrack(string name, Dictionary<string, object> data) {} // 0x000000018A991778-0x000000018A991888
		private System.Threading.Tasks.Task ExecuteEventTrackSafely(string name, Dictionary<string, object> data) => default; // 0x000000018A9902B8-0x000000018A990798
	}

	public static class HGSpeedTestSDKVersion // TypeDefIndex: 60394
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGSpeedTestSDKVersion() {} // 0x000000018A98DDE4-0x000000018A98DE40
	}

	public class SpeedTestServerInfo // TypeDefIndex: 60395
	{
		// Fields
		public string host; // 0x10
		public string name; // 0x18
	
		// Constructors
		public SpeedTestServerInfo() {} // Dummy constructor
		public SpeedTestServerInfo(string host, string name) {} // 0x00000001841BC230-0x00000001841BC260
	}

	public class TaskResult // TypeDefIndex: 60396
	{
		// Fields
		public int taskCode; // 0x10
		public string message; // 0x18
	
		// Constructors
		public TaskResult() {} // Dummy constructor
		public TaskResult(int code, string message) {} // 0x000000018646E950-0x000000018646E960
	}

	public class SpeedTestResult // TypeDefIndex: 60397
	{
		// Fields
		public string host; // 0x10
		public string name; // 0x18
		public int latency; // 0x20
		public int resultCode; // 0x24
	
		// Constructors
		public SpeedTestResult() {} // Dummy constructor
		public SpeedTestResult(int resultCode, int latency, SpeedTestServerInfo server) {} // 0x000000018A990278-0x000000018A9902B8
	}

	public enum SpeedTestProtocol // TypeDefIndex: 60398
	{
		TCP = 0,
		UDP = 1
	}

	public class HGSpeedTestSDK // TypeDefIndex: 60405
	{
		// Fields
		private static readonly HGSpeedTestSDK _instance; // 0x00
		private readonly Dictionary<string, TcpClient> _connections; // 0x10
		private readonly Dictionary<string, NetworkStream> _streams; // 0x18
		private readonly object _lockObject; // 0x20
		private CancellationTokenSource cts; // 0x28
		private long _packetIndex; // 0x30
		private bool _isInSpeedTest; // 0x38
	
		// Nested types
		private struct _OnApplicationPause_d__16 : IAsyncStateMachine // TypeDefIndex: 60399
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public bool pauseStatus; // 0x20
			public HGSpeedTestSDK __4__this; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext() {} // 0x00000001850E1230-0x00000001850E13A0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018A98E9D4-0x000000018A98EA24
		}
	
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 60400
		{
			// Fields
			public HGSpeedTestSDK __4__this; // 0x10
			public Action<SpeedTestResult> callback; // 0x18
			public int round; // 0x20
			public SpeedTestProtocol protocol; // 0x24
	
			// Constructors
			public __c__DisplayClass17_0() {} // 0x000000018509BC10-0x000000018509BD40
		}
	
		private sealed class __c__DisplayClass17_1 // TypeDefIndex: 60401
		{
			// Fields
			public SpeedTestServerInfo server; // 0x10
			public __c__DisplayClass17_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass17_1() {} // 0x000000018A98F4C8-0x000000018A98F5E4
	
			// Methods
			internal void _StartSpeedTest_b__0() {} // 0x000000018A98F130-0x000000018A98F298
		}
	
		private struct _StartSpeedTest_d__17 : IAsyncStateMachine // TypeDefIndex: 60402
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<TaskResult> __t__builder; // 0x08
			public HGSpeedTestSDK __4__this; // 0x20
			public Action<SpeedTestResult> callback; // 0x28
			public int round; // 0x30
			public SpeedTestProtocol protocol; // 0x34
			public List<SpeedTestServerInfo> serverList; // 0x38
			private TaskAwaiter __u__1; // 0x40
	
			// Methods
			private void MoveNext() {} // 0x000000018A98EF10-0x000000018A98F130
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018A98EBD8-0x000000018A98EF10
		}
	
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 60403
		{
			// Fields
			public Action<SpeedTestResult> callback; // 0x10
			public SpeedTestResult result; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x000000018A98DE40-0x000000018A98E2D8
	
			// Methods
			internal void _NotifyRoundResult_b__0() {} // 0x000000018A98F5E4-0x000000018A98FC08
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 60404
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<long, long> __9__27_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018A98E3D8-0x000000018A98E9D4
			public __c() {} // 0x000000018A98FC08-0x000000018A9901BC
	
			// Methods
			internal long _GetP50_b__27_0(long x) => default; // 0x000000018A98F298-0x000000018A98F4C8
		}
	
		// Constructors
		private HGSpeedTestSDK() {} // 0x000000018A98E2D8-0x000000018A98E3D8
		static HGSpeedTestSDK() {} // 0x00000001834A4750-0x00000001834A4760
	
		// Methods
		public static HGSpeedTestSDK GetInstance() => default; // 0x000000018A98EA24-0x000000018A98EBD8
		public System.Threading.Tasks.Task OnApplicationPause(bool pauseStatus) => default; // 0x00000001850E11C0-0x00000001850E1230
		public Task<TaskResult> StartSpeedTest(List<SpeedTestServerInfo> serverList, Action<SpeedTestResult> callback, int round = 1 /* Metadata: 0x020828E0 */, SpeedTestProtocol protocol = SpeedTestProtocol.TCP /* Metadata: 0x020828E1 */) => default; // 0x0000000185090280-0x0000000185090450
		private void OnSpeedTestStart() {} // 0x00000001857B8C20-0x00000001857B8C80
		private TaskResult OnSpeedTaskResult(int code, string message) => default; // 0x0000000185492010-0x0000000185492020
		private void NotifyRoundResult(Action<SpeedTestResult> callback, int code, int latency, SpeedTestServerInfo server) {} // 0x0000000185492010-0x0000000185492020
		private void CleanupConnections() {} // 0x000000018A991888-0x000000018A991914
		private void TestServerLatency(SpeedTestServerInfo server, Action<SpeedTestResult> callback, int round, SpeedTestProtocol protocol, CancellationToken cancellationToken) {} // 0x000000018A9907F4-0x000000018A99137C
		private int EstablishConnection(SpeedTestServerInfo server) => default; // 0x000000018A99137C-0x000000018A9913DC
		private SpeedTestResult TestTcpLatency(SpeedTestServerInfo server, List<long> serverLatencyList, CancellationToken cancellationToken) => default; // 0x0000000185492010-0x0000000185492020
		private long SendTcpPackage(NetworkStream stream) => default; // 0x000000018A991914-0x000000018A9919E8
		private byte[] CreateTcpPacket() => default; // 0x000000018A9919E8-0x000000018A992714
		public long GetP50(List<long> latencies) => default; // 0x0000000185492010-0x0000000185492020
	}

	internal class NativeConfigLoader // TypeDefIndex: 60407
	{
		// Fields
		private static NativeConfigLoader instance; // 0x00
		private string region; // 0x10
		private string appDataPath; // 0x18
		private string _gameVersion; // 0x20
	
		// Nested types
		private struct _init_d__7 : IAsyncStateMachine // TypeDefIndex: 60406
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public NativeConfigLoader __4__this; // 0x20
			private TaskAwaiter<string> __u__1; // 0x28
	
			// Methods
			private void MoveNext() {} // 0x0000000185F0A630-0x0000000185F0A670
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x0000000185090DB0-0x0000000185090E70
		}
	
		// Constructors
		private NativeConfigLoader() {} // 0x000000018A9901BC-0x000000018A99020C
		static NativeConfigLoader() {} // 0x000000018476B1B0-0x000000018476B3C0
	
		// Methods
		public System.Threading.Tasks.Task init() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public static NativeConfigLoader GetInstance() => default; // 0x0000000185090BE0-0x0000000185090C20
		public string GetGameVersion() => default; // 0x0000000185090C20-0x0000000185090CD0
		public string GetRegion() => default; // 0x000000018476D9E0-0x000000018476DB40
		private string GetRegionFromConfig() => default; // 0x0000000185F0A5C0-0x0000000185F0A630
		public string ReadWinConfig() => default; // 0x00000001850494C0-0x00000001850494F0
		private string _init_b__7_0() => default; // 0x00000001857B8C80-0x00000001857B8CE0
	}

	public class SpeedTestLogger // TypeDefIndex: 60409
	{
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 60408
		{
			// Fields
			public string logInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018476B5D0-0x000000018476B650
	
			// Methods
			internal void _PrintLogToView_b__0() {} // 0x000000018A99020C-0x000000018A990278
		}
	
		// Constructors
		public SpeedTestLogger() {} // Dummy constructor
	
		// Methods
		public static void Debug(string message) {} // 0x000000018476B650-0x000000018476B700
		public static void Error(string message) {} // 0x0000000185492010-0x0000000185492020
		public static void PrintLogToView(string logInfo) {} // 0x0000000184A83E40-0x0000000184A83F20
	}

	internal class UnityMainThread // TypeDefIndex: 60414
	{
		// Fields
		private static SynchronizationContext MainContext; // 0x00
		public static bool isDebug; // 0x08
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 60410
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018508F870-0x000000018508F910
	
			// Methods
			internal void _RunOnMainThread_b__0(object _) {} // 0x000000018476B700-0x000000018476B7F0
		}
	
		private sealed class __c__DisplayClass4_0<T> // TypeDefIndex: 60411
		{
			// Fields
			public TaskCompletionSource<T> tcs;
			public Func<T> func;
	
			// Constructors
			public __c__DisplayClass4_0() {}
	
			// Methods
			internal void _RunOnMainThread_b__0() {} // 0x0000000185090FA0-0x0000000185091060
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 60412
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<bool> __9__5_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185492010-0x0000000185492020
			public __c() {} // 0x0000000185EDC210-0x0000000185EDC230
	
			// Methods
			internal bool _isAppFocused_b__5_0() => default;
		}
	
		private struct _isAppFocused_d__5 : IAsyncStateMachine // TypeDefIndex: 60413
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			private TaskAwaiter<bool> __u__1; // 0x20
	
			// Methods
			private void MoveNext() {}
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x0000000185F6E590-0x0000000185F6E5F0
		}
	
		// Constructors
		public UnityMainThread() {} // Dummy constructor
	
		// Methods
		public static void Init() {} // 0x0000000185492010-0x0000000185492020
		public static void RunOnMainThread(Action action) {} // 0x0000000186472690-0x0000000186472698
		public static Task<T> RunOnMainThread<T>(Func<T> func) => default; // 0x0000000185090450-0x00000001850906A0
		public static Task<bool> isAppFocused() => default; // 0x0000000185A175D0-0x0000000185A17640
	}

	public class WinConfigParser // TypeDefIndex: 60415
	{
		// Fields
		private static readonly byte[] iv; // 0x00
		private static readonly byte[] aes_key; // 0x08
		private static readonly string public_key_str; // 0x10
	
		// Constructors
		public WinConfigParser() {} // Dummy constructor
		static WinConfigParser() {} // 0x0000000185D71290-0x0000000185D713B0
	
		// Methods
		public static string ParseEncryptionFile(string encryptionfile, string verifyfile) => default; // 0x000000018476C730-0x000000018476C8B0
		private static string DecryptConfig(byte[] encryptedData, byte[] key, byte[] iv) => default; // 0x0000000184F78C00-0x0000000184F79250
		private static bool VerifySignature(string data, string sign) => default; // 0x0000000184F79250-0x0000000184F79C90
		private static void ImportRsaPublicKeyManually(RSACryptoServiceProvider rsa, byte[] publicKeyBytes) {} // 0x000000018418E3A0-0x000000018418E5B0
		private static byte[] ExtractPublicKeyFromPem(string pemString) => default; // 0x0000000184F79C90-0x0000000184F79E60
	}
}
