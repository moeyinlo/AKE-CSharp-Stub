/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using UnityEngine;

// Image 94: Hypergryph.SpeedTest.dll - Assembly: Hypergryph.SpeedTest, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90353-90385

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 90385
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_32 _4DAABD10C615552E680FD1F3F9C9E1B1C74413B5F519EDE1335CD44C46B11EC8; // 0x00 // Static value (base64): wPMOHOdju8Icw1WjQwOsUDmURL/2jEoirzmMChZu4UM= - Metadata: 0x0264AE08
	internal static readonly __StaticArrayInitTypeSize_16 _701AA427DC569405D7608BAD336BBED96E382E97EE07C02CFED96D856E313AE5; // 0x20 // Static value (base64): M0Z4YRknUGSVAZNyZGCEAA== - Metadata: 0x0264AE30

	// Nested types
	private struct __StaticArrayInitTypeSize_16 // TypeDefIndex: 90383
	{
	}

	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 90384
	{
	}
}

namespace Hypergryph.SpeedTest
{
	public class EventLogWrapper // TypeDefIndex: 90360
	{
		// Fields
		private static readonly EventLogWrapper _instance; // 0x00
		private string _appId; // 0x10
		private string _gameVersion; // 0x18
	
		// Properties
		public static EventLogWrapper Instance { get; } // 0x000000018C23B8E8-0x000000018C23B938 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 90354
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string region; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _init_b__0(); // 0x00000001871E8660-0x00000001871E8690
		}
	
		[CompilerGenerated]
		private struct _init_d__11 : IAsyncStateMachine // TypeDefIndex: 90355
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public EventLogWrapper __4__this; // 0x28
			private __c__DisplayClass11_0 __8__1; // 0x30
			private TaskAwaiter __u__1; // 0x38
			private TaskAwaiter<bool> __u__2; // 0x40
	
			// Methods
			private void MoveNext(); // 0x00000001861B43A0-0x00000001861B48D0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018783BAEC-0x000000018783BAF8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 90357
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public Dictionary<string, object> data; // 0x20
	
			// Nested types
			private struct __EventTrack_b__0_d : IAsyncStateMachine // TypeDefIndex: 90356
			{
				// Fields
				public int __1__state; // 0x00
				public AsyncTaskMethodBuilder __t__builder; // 0x08
				public __c__DisplayClass12_0 __4__this; // 0x20
				private TaskAwaiter __u__1; // 0x28
	
				// Methods
				private void MoveNext(); // 0x000000018C23EFE0-0x000000018C23F278
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C23F278-0x000000018C23F2D4
			}
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal async System.Threading.Tasks.Task _EventTrack_b__0(); // 0x000000018C23F2D4-0x000000018C23F388
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 90358
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public JObject properties; // 0x20
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ExecuteEventTrackSafely_b__0(); // 0x000000018C23F388-0x000000018C23F498
		}
	
		[CompilerGenerated]
		private struct _ExecuteEventTrackSafely_d__13 : IAsyncStateMachine // TypeDefIndex: 90359
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
			private void MoveNext(); // 0x000000018C23DE4C-0x000000018C23E344
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C23E344-0x000000018C23E3A0
		}
	
		// Constructors
		private EventLogWrapper(); // 0x00000001870F02B0-0x00000001870F0310
		static EventLogWrapper(); // 0x00000001870F0240-0x00000001870F02B0
	
		// Methods
		public async void init(); // 0x0000000186DFFDD0-0x0000000186DFFE80
		public void EventTrack(string name, Dictionary<string, object> data); // 0x000000018C23B70C-0x000000018C23B7F8
		private async System.Threading.Tasks.Task ExecuteEventTrackSafely(string name, Dictionary<string, object> data); // 0x000000018C23B7F8-0x000000018C23B8E8
	}

	public static class HGSpeedTestSDKVersion // TypeDefIndex: 90361
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGSpeedTestSDKVersion(); // 0x000000018C23B938-0x000000018C23B994
	}

	public class SpeedTestServerInfo // TypeDefIndex: 90362
	{
		// Fields
		public string host; // 0x10
		public string name; // 0x18
	
		// Constructors
		public SpeedTestServerInfo(string host, string name); // 0x0000000185381AC0-0x0000000185381AF0
	}

	public class TaskResult // TypeDefIndex: 90363
	{
		// Fields
		public int taskCode; // 0x10
		public string message; // 0x18
	
		// Constructors
		public TaskResult(int code, string message); // 0x0000000185CF10D0-0x0000000185CF1300
	}

	public class SpeedTestResult // TypeDefIndex: 90364
	{
		// Fields
		public string host; // 0x10
		public string name; // 0x18
		public int latency; // 0x20
		public int resultCode; // 0x24
	
		// Constructors
		public SpeedTestResult(int resultCode, int latency, SpeedTestServerInfo server); // 0x000000018C23DE0C-0x000000018C23DE4C
	}

	public enum SpeedTestProtocol // TypeDefIndex: 90365
	{
		TCP = 0,
		UDP = 1
	}

	public class HGSpeedTestSDK // TypeDefIndex: 90372
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
		[CompilerGenerated]
		private struct _OnApplicationPause_d__16 : IAsyncStateMachine // TypeDefIndex: 90366
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public bool pauseStatus; // 0x20
			public HGSpeedTestSDK __4__this; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001861B48D0-0x00000001861B4AB0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000186517A10-0x0000000186517A70
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 90367
		{
			// Fields
			public HGSpeedTestSDK __4__this; // 0x10
			public Action<SpeedTestResult> callback; // 0x18
			public int round; // 0x20
			public SpeedTestProtocol protocol; // 0x24
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1 // TypeDefIndex: 90368
		{
			// Fields
			public SpeedTestServerInfo server; // 0x10
			public __c__DisplayClass17_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass17_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _StartSpeedTest_b__0(); // 0x000000018C23F498-0x000000018C23F528
		}
	
		[CompilerGenerated]
		private struct _StartSpeedTest_d__17 : IAsyncStateMachine // TypeDefIndex: 90369
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
			private void MoveNext(); // 0x000000018C23E3A0-0x000000018C23EF80
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C23EF80-0x000000018C23EFE0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 90370
		{
			// Fields
			public Action<SpeedTestResult> callback; // 0x10
			public SpeedTestResult result; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _NotifyRoundResult_b__0(); // 0x000000018C23F528-0x000000018C23F5FC
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90371
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<long, long> __9__27_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C23F5FC-0x000000018C23FCD0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal long _GetP50_b__27_0(long x); // 0x000000018459BB50-0x000000018459BB60
		}
	
		// Constructors
		private HGSpeedTestSDK(); // 0x0000000186DFFC60-0x0000000186DFFDD0
		static HGSpeedTestSDK(); // 0x0000000186DFFBF0-0x0000000186DFFC60
	
		// Methods
		public static HGSpeedTestSDK GetInstance(); // 0x000000018C23C530-0x000000018C23C580
		public async System.Threading.Tasks.Task OnApplicationPause(bool pauseStatus); // 0x000000018628A430-0x000000018628A510
		public async Task<TaskResult> StartSpeedTest(List<SpeedTestServerInfo> serverList, Action<SpeedTestResult> callback, int round = 1 /* Metadata: 0x0264AE02 */, SpeedTestProtocol protocol = SpeedTestProtocol.TCP /* Metadata: 0x0264AE03 */); // 0x000000018C23D048-0x000000018C23D168
		private void OnSpeedTestStart(); // 0x000000018C23CC90-0x000000018C23CDF8
		private TaskResult OnSpeedTaskResult(int code, string message); // 0x000000018C23CA70-0x000000018C23CC90
		private void NotifyRoundResult(Action<SpeedTestResult> callback, int code, int latency, SpeedTestServerInfo server); // 0x000000018C23C734-0x000000018C23CA70
		private void CleanupConnections(); // 0x000000018C23B994-0x000000018C23BE40
		private void TestServerLatency(SpeedTestServerInfo server, Action<SpeedTestResult> callback, int round, SpeedTestProtocol protocol, CancellationToken cancellationToken); // 0x000000018C23D168-0x000000018C23D788
		private int EstablishConnection(SpeedTestServerInfo server); // 0x000000018C23BF40-0x000000018C23C530
		private SpeedTestResult TestTcpLatency(SpeedTestServerInfo server, List<long> serverLatencyList, CancellationToken cancellationToken); // 0x000000018C23D788-0x000000018C23DD50
		private long SendTcpPackage(NetworkStream stream); // 0x000000018C23CDF8-0x000000018C23D048
		private byte[] CreateTcpPacket(); // 0x000000018C23BE40-0x000000018C23BF40
		public long GetP50(List<long> latencies); // 0x000000018C23C580-0x000000018C23C734
	}

	internal class NativeConfigLoader // TypeDefIndex: 90374
	{
		// Fields
		private static NativeConfigLoader instance; // 0x00
		private string region; // 0x10
		private string appDataPath; // 0x18
		private string _gameVersion; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private struct _init_d__7 : IAsyncStateMachine // TypeDefIndex: 90373
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public NativeConfigLoader __4__this; // 0x20
			private TaskAwaiter<string> __u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018611DB90-0x000000018611DDA0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000186517A70-0x0000000186517AD0
		}
	
		// Constructors
		private NativeConfigLoader(); // 0x000000018710C9B0-0x000000018710C9F0
		static NativeConfigLoader(); // 0x000000018710C940-0x000000018710C9B0
	
		// Methods
		public async System.Threading.Tasks.Task init(); // 0x00000001861B4AF0-0x00000001861B4BB0
		public static NativeConfigLoader GetInstance(); // 0x000000018C23DD50-0x000000018C23DDA0
		public string GetGameVersion(); // 0x000000018225E800-0x000000018225E810
		public string GetRegion(); // 0x00000001861B4AB0-0x00000001861B4AF0
		private string GetRegionFromConfig(); // 0x00000001861B5280-0x00000001861B5890
		private string GetRegionFromWIN(); // 0x000000018492DDA0-0x0000000184930A60
		[CompilerGenerated]
		private string _init_b__7_0(); // 0x000000018611E5C0-0x000000018611E5F0
	}

	public class SpeedTestLogger // TypeDefIndex: 90376
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 90375
		{
			// Fields
			public string logInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PrintLogToView_b__0(); // 0x00000001850D0BD0-0x00000001850D0CE0
		}
	
		// Methods
		public static void Debug(string message); // 0x000000018602AE60-0x000000018602AEE0
		public static void Error(string message); // 0x000000018C23DDA0-0x000000018C23DE0C
		public static void PrintLogToView(string logInfo); // 0x000000018602AEE0-0x000000018602AF90
	}

	internal class UnityMainThread // TypeDefIndex: 90381
	{
		// Fields
		private static SynchronizationContext MainContext; // 0x00
		public static bool isDebug; // 0x08
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 90377
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RunOnMainThread_b__0(object _); // 0x00000001870B4690-0x00000001870B46B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0<T> // TypeDefIndex: 90378
		{
			// Fields
			public TaskCompletionSource<T> tcs;
			public Func<T> func;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _RunOnMainThread_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90379
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<bool> __9__5_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E51E0-0x00000001871E5240
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _isAppFocused_b__5_0(); // 0x000000018783C5E0-0x000000018783C5E8
		}
	
		[CompilerGenerated]
		private struct _isAppFocused_d__5 : IAsyncStateMachine // TypeDefIndex: 90380
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			private TaskAwaiter<bool> __u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x00000001861B4150-0x00000001861B43A0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000186EE01F0-0x0000000186EE0260
		}
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		public static void Init(); // 0x00000001861B3B30-0x00000001861B3BD0
		public static void RunOnMainThread(Action action); // 0x000000018602B0E0-0x000000018602B1D0
		public static Task<T> RunOnMainThread<T>(Func<T> func);
		public static async Task<bool> isAppFocused(); // 0x00000001861B4BB0-0x00000001861B4C80
	}

	public class WinConfigParser // TypeDefIndex: 90382
	{
		// Fields
		private static readonly byte[] iv; // 0x00
		private static readonly byte[] aes_key; // 0x08
		private static readonly string public_key_str; // 0x10
	
		// Constructors
		static WinConfigParser(); // 0x0000000186FC9EE0-0x0000000186FCA000
	
		// Methods
		public static string ParseEncryptionFile(string encryptionfile, string verifyfile); // 0x0000000186029750-0x00000001860298D0
		private static string DecryptConfig(byte[] encryptedData, byte[] key, byte[] iv); // 0x00000001860298D0-0x0000000186029F20
		private static bool VerifySignature(string data, string sign); // 0x0000000186029F20-0x000000018602A970
		private static void ImportRsaPublicKeyManually(RSACryptoServiceProvider rsa, byte[] publicKeyBytes); // 0x0000000185BD38A0-0x0000000185BD3AD0
		private static byte[] ExtractPublicKeyFromPem(string pemString); // 0x000000018602A970-0x000000018602AAC0
	}
}
