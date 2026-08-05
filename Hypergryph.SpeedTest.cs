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

// Image 93: Hypergryph.SpeedTest.dll - Assembly: Hypergryph.SpeedTest, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62970-63002
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 63002
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_32 _4DAABD10C615552E680FD1F3F9C9E1B1C74413B5F519EDE1335CD44C46B11EC8; // 0x00 // Static value (base64): wPMOHOdju8Icw1WjQwOsUDmURL/2jEoirzmMChZu4UM= - Metadata: 0x0235242C
	internal static readonly __StaticArrayInitTypeSize_16 _701AA427DC569405D7608BAD336BBED96E382E97EE07C02CFED96D856E313AE5; // 0x20 // Static value (base64): M0Z4YRknUGSVAZNyZGCEAA== - Metadata: 0x02352454

	// Nested types
	private struct __StaticArrayInitTypeSize_16 // TypeDefIndex: 63000
	{
	}

	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 63001
	{
	}
}

namespace Hypergryph.SpeedTest
{
	public class EventLogWrapper // TypeDefIndex: 62977
	{
		// Fields
		private static readonly EventLogWrapper _instance; // 0x00
		private string _appId; // 0x10
		private string _gameVersion; // 0x18
	
		// Properties
		public static EventLogWrapper Instance { get; } // 0x0000000189DF6434-0x0000000189DF6484 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 62971
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string region; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _init_b__0(); // 0x00000001840BA980-0x00000001840BA9B0
		}
	
		[CompilerGenerated]
		private struct _init_d__11 : IAsyncStateMachine // TypeDefIndex: 62972
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public EventLogWrapper __4__this; // 0x28
			private __c__DisplayClass11_0 __8__1; // 0x30
			private TaskAwaiter __u__1; // 0x38
			private TaskAwaiter<bool> __u__2; // 0x40
	
			// Methods
			private void MoveNext(); // 0x0000000183811CC0-0x00000001838121F0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001853982D4-0x00000001853982E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 62974
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public Dictionary<string, object> data; // 0x20
	
			// Nested types
			private struct __EventTrack_b__0_d : IAsyncStateMachine // TypeDefIndex: 62973
			{
				// Fields
				public int __1__state; // 0x00
				public AsyncTaskMethodBuilder __t__builder; // 0x08
				public __c__DisplayClass12_0 __4__this; // 0x20
				private TaskAwaiter __u__1; // 0x28
	
				// Methods
				private void MoveNext(); // 0x0000000189DF9A98-0x0000000189DF9D28
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189DF9D28-0x0000000189DF9D84
			}
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal async System.Threading.Tasks.Task _EventTrack_b__0(); // 0x0000000189DF9D84-0x0000000189DF9E34
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 62975
		{
			// Fields
			public EventLogWrapper __4__this; // 0x10
			public string name; // 0x18
			public JObject properties; // 0x20
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ExecuteEventTrackSafely_b__0(); // 0x0000000189DF9E34-0x0000000189DF9F44
		}
	
		[CompilerGenerated]
		private struct _ExecuteEventTrackSafely_d__13 : IAsyncStateMachine // TypeDefIndex: 62976
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
			private void MoveNext(); // 0x0000000189DF8968-0x0000000189DF8E54
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189DF8E54-0x0000000189DF8EB0
		}
	
		// Constructors
		private EventLogWrapper(); // 0x0000000184CDB9D0-0x0000000184CDBAA0
		static EventLogWrapper(); // 0x0000000184CDB960-0x0000000184CDB9D0
	
		// Methods
		public async void init(); // 0x00000001830749A0-0x0000000183074A50
		public void EventTrack(string name, Dictionary<string, object> data); // 0x0000000189DF625C-0x0000000189DF6348
		private async System.Threading.Tasks.Task ExecuteEventTrackSafely(string name, Dictionary<string, object> data); // 0x0000000189DF6348-0x0000000189DF6434
	}

	public static class HGSpeedTestSDKVersion // TypeDefIndex: 62978
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGSpeedTestSDKVersion(); // 0x0000000189DF6484-0x0000000189DF64E0
	}

	public class SpeedTestServerInfo // TypeDefIndex: 62979
	{
		// Fields
		public string host; // 0x10
		public string name; // 0x18
	
		// Constructors
		public SpeedTestServerInfo(string host, string name); // 0x00000001832AF420-0x00000001832AF450
	}

	public class TaskResult // TypeDefIndex: 62980
	{
		// Fields
		public int taskCode; // 0x10
		public string message; // 0x18
	
		// Constructors
		public TaskResult(int code, string message); // 0x0000000185391D70-0x0000000185391D80
	}

	public class SpeedTestResult // TypeDefIndex: 62981
	{
		// Fields
		public string host; // 0x10
		public string name; // 0x18
		public int latency; // 0x20
		public int resultCode; // 0x24
	
		// Constructors
		public SpeedTestResult(int resultCode, int latency, SpeedTestServerInfo server); // 0x0000000189DF8928-0x0000000189DF8968
	}

	public enum SpeedTestProtocol // TypeDefIndex: 62982
	{
		TCP = 0,
		UDP = 1
	}

	public class HGSpeedTestSDK // TypeDefIndex: 62989
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
		private struct _OnApplicationPause_d__16 : IAsyncStateMachine // TypeDefIndex: 62983
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public bool pauseStatus; // 0x20
			public HGSpeedTestSDK __4__this; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001838121F0-0x00000001838123D0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018459AD30-0x000000018459AD90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 62984
		{
			// Fields
			public HGSpeedTestSDK __4__this; // 0x10
			public Action<SpeedTestResult> callback; // 0x18
			public int round; // 0x20
			public SpeedTestProtocol protocol; // 0x24
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1 // TypeDefIndex: 62985
		{
			// Fields
			public SpeedTestServerInfo server; // 0x10
			public __c__DisplayClass17_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass17_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _StartSpeedTest_b__0(); // 0x0000000189DF9F44-0x0000000189DF9FD0
		}
	
		[CompilerGenerated]
		private struct _StartSpeedTest_d__17 : IAsyncStateMachine // TypeDefIndex: 62986
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
			private void MoveNext(); // 0x0000000189DF8EB0-0x0000000189DF9A38
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189DF9A38-0x0000000189DF9A98
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 62987
		{
			// Fields
			public Action<SpeedTestResult> callback; // 0x10
			public SpeedTestResult result; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _NotifyRoundResult_b__0(); // 0x0000000189DF9FD0-0x0000000189DFA0A4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62988
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<long, long> __9__27_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189DFA0A4-0x0000000189DFAAD8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal long _GetP50_b__27_0(long x); // 0x0000000184D88C30-0x0000000184D88C40
		}
	
		// Constructors
		private HGSpeedTestSDK(); // 0x0000000184A14000-0x0000000184A14170
		static HGSpeedTestSDK(); // 0x0000000184A13F90-0x0000000184A14000
	
		// Methods
		public static HGSpeedTestSDK GetInstance(); // 0x0000000189DF7074-0x0000000189DF70C4
		public async System.Threading.Tasks.Task OnApplicationPause(bool pauseStatus); // 0x0000000183F266A0-0x0000000183F26780
		public async Task<TaskResult> StartSpeedTest(List<SpeedTestServerInfo> serverList, Action<SpeedTestResult> callback, int round = 1 /* Metadata: 0x02352427 */, SpeedTestProtocol protocol = SpeedTestProtocol.TCP /* Metadata: 0x02352428 */); // 0x0000000189DF7B78-0x0000000189DF7C94
		private void OnSpeedTestStart(); // 0x0000000189DF77D0-0x0000000189DF7938
		private TaskResult OnSpeedTaskResult(int code, string message); // 0x0000000189DF75B0-0x0000000189DF77D0
		private void NotifyRoundResult(Action<SpeedTestResult> callback, int code, int latency, SpeedTestServerInfo server); // 0x0000000189DF7278-0x0000000189DF75B0
		private void CleanupConnections(); // 0x0000000189DF64E0-0x0000000189DF6978
		private void TestServerLatency(SpeedTestServerInfo server, Action<SpeedTestResult> callback, int round, SpeedTestProtocol protocol, CancellationToken cancellationToken); // 0x0000000189DF7C94-0x0000000189DF82B8
		private int EstablishConnection(SpeedTestServerInfo server); // 0x0000000189DF6A78-0x0000000189DF7074
		private SpeedTestResult TestTcpLatency(SpeedTestServerInfo server, List<long> serverLatencyList, CancellationToken cancellationToken); // 0x0000000189DF82B8-0x0000000189DF886C
		private long SendTcpPackage(NetworkStream stream); // 0x0000000189DF7938-0x0000000189DF7B78
		private byte[] CreateTcpPacket(); // 0x0000000189DF6978-0x0000000189DF6A78
		public long GetP50(List<long> latencies); // 0x0000000189DF70C4-0x0000000189DF7278
	}

	internal class NativeConfigLoader // TypeDefIndex: 62991
	{
		// Fields
		private static NativeConfigLoader instance; // 0x00
		private string region; // 0x10
		private string appDataPath; // 0x18
		private string _gameVersion; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private struct _init_d__7 : IAsyncStateMachine // TypeDefIndex: 62990
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public NativeConfigLoader __4__this; // 0x20
			private TaskAwaiter<string> __u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x0000000184863740-0x0000000184863950
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018459AD90-0x000000018459ADF0
		}
	
		// Constructors
		private NativeConfigLoader(); // 0x0000000184CE7FF0-0x0000000184CE8030
		static NativeConfigLoader(); // 0x0000000184CE7F80-0x0000000184CE7FF0
	
		// Methods
		public async System.Threading.Tasks.Task init(); // 0x0000000184CDA8D0-0x0000000184CDA990
		public static NativeConfigLoader GetInstance(); // 0x0000000189DF886C-0x0000000189DF88BC
		public string GetGameVersion(); // 0x0000000184D862C0-0x0000000184D862D0
		public string GetRegion(); // 0x00000001838115F0-0x0000000183811630
		private string GetRegionFromConfig(); // 0x0000000183F4DB30-0x0000000183F4DBE0
		public string ReadWinConfig(); // 0x0000000183F4D9D0-0x0000000183F4DB30
		[CompilerGenerated]
		private string _init_b__7_0(); // 0x00000001841A7470-0x00000001841A74A0
	}

	public class SpeedTestLogger // TypeDefIndex: 62993
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 62992
		{
			// Fields
			public string logInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PrintLogToView_b__0(); // 0x0000000183AC6D90-0x0000000183AC6EA0
		}
	
		// Methods
		public static void Debug(string message); // 0x0000000183073F00-0x0000000183073F80
		public static void Error(string message); // 0x0000000189DF88BC-0x0000000189DF8928
		public static void PrintLogToView(string logInfo); // 0x0000000183073F80-0x0000000183074030
	}

	internal class UnityMainThread // TypeDefIndex: 62998
	{
		// Fields
		private static SynchronizationContext MainContext; // 0x00
		public static bool isDebug; // 0x08
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 62994
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RunOnMainThread_b__0(object _); // 0x0000000184CC60B0-0x0000000184CC60D0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0<T> // TypeDefIndex: 62995
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
		private sealed class __c // TypeDefIndex: 62996
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<bool> __9__5_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D41EF0-0x0000000184D41F50
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _isAppFocused_b__5_0(); // 0x0000000185396550-0x0000000185396560
		}
	
		[CompilerGenerated]
		private struct _isAppFocused_d__5 : IAsyncStateMachine // TypeDefIndex: 62997
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			private TaskAwaiter<bool> __u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x0000000183811A60-0x0000000183811CC0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001848BB2C0-0x00000001848BB330
		}
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		public static void Init(); // 0x0000000183FCE3F0-0x0000000183FCE490
		public static void RunOnMainThread(Action action); // 0x0000000183074030-0x0000000183074120
		public static Task<T> RunOnMainThread<T>(Func<T> func);
		public static async Task<bool> isAppFocused(); // 0x0000000183812500-0x00000001838125C0
	}

	public class WinConfigParser // TypeDefIndex: 62999
	{
		// Fields
		private static readonly byte[] iv; // 0x00
		private static readonly byte[] aes_key; // 0x08
		private static readonly string public_key_str; // 0x10
	
		// Constructors
		static WinConfigParser(); // 0x0000000184B4BB30-0x0000000184B4BC50
	
		// Methods
		public static string ParseEncryptionFile(string encryptionfile, string verifyfile); // 0x00000001830757F0-0x0000000183075970
		private static string DecryptConfig(byte[] encryptedData, byte[] key, byte[] iv); // 0x0000000183C0D7B0-0x0000000183C0DDD0
		private static bool VerifySignature(string data, string sign); // 0x0000000183C0A840-0x0000000183C0B260
		private static void ImportRsaPublicKeyManually(RSACryptoServiceProvider rsa, byte[] publicKeyBytes); // 0x0000000183FE4EF0-0x0000000183FE5100
		private static byte[] ExtractPublicKeyFromPem(string pemString); // 0x0000000183C0B260-0x0000000183C0B3B0
	}
}
