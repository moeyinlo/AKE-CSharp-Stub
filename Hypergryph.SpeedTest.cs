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

// Image 90: Hypergryph.SpeedTest.dll - Assembly: Hypergryph.SpeedTest, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59330-59362
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.SpeedTest
{
	public class EventLogWrapper // TypeDefIndex: 59337
	{
		// Fields
		private static readonly EventLogWrapper _instance; // 0x00
		private string _appId; // 0x10
		private string _gameVersion; // 0x18
	
		// Properties
		public static EventLogWrapper Instance { get => default; } // 0x000000018887C208-0x000000018887C258 
	
		// Constructors
		private EventLogWrapper() {} // 0x0000000183CA7860-0x0000000183CA78C0
		static EventLogWrapper() {} // 0x0000000183CA77F0-0x0000000183CA7860
	
		// Methods
		public async void init() {} // 0x0000000182D90E40-0x0000000182D90EF0
		public void EventTrack(string name, Dictionary<string, object> data) {} // 0x000000018887C030-0x000000018887C11C
		private async System.Threading.Tasks.Task ExecuteEventTrackSafely(string name, Dictionary<string, object> data) => default; // 0x000000018887C11C-0x000000018887C208
	}

	public static class HGSpeedTestSDKVersion // TypeDefIndex: 59338
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGSpeedTestSDKVersion() {} // 0x000000018887C258-0x000000018887C2B4
	}

	public class SpeedTestServerInfo // TypeDefIndex: 59339
	{
		// Fields
		public string host; // 0x10
		public string name; // 0x18
	
		// Constructors
		public SpeedTestServerInfo() {} // Dummy constructor
		public SpeedTestServerInfo(string host, string name) {} // 0x0000000182676770-0x00000001826767A0
	}

	public class TaskResult // TypeDefIndex: 59340
	{
		// Fields
		public int taskCode; // 0x10
		public string message; // 0x18
	
		// Constructors
		public TaskResult() {} // Dummy constructor
		public TaskResult(int code, string message) {} // 0x0000000184270E40-0x0000000184270E50
	}

	public class SpeedTestResult // TypeDefIndex: 59341
	{
		// Fields
		public string host; // 0x10
		public string name; // 0x18
		public int latency; // 0x20
		public int resultCode; // 0x24
	
		// Constructors
		public SpeedTestResult() {} // Dummy constructor
		public SpeedTestResult(int resultCode, int latency, SpeedTestServerInfo server) {} // 0x000000018887E6EC-0x000000018887E72C
	}

	public enum SpeedTestProtocol // TypeDefIndex: 59342
	{
		TCP = 0,
		UDP = 1
	}

	public class HGSpeedTestSDK // TypeDefIndex: 59349
	{
		// Fields
		private static readonly HGSpeedTestSDK _instance; // 0x00
		private readonly Dictionary<string, TcpClient> _connections; // 0x10
		private readonly Dictionary<string, NetworkStream> _streams; // 0x18
		private readonly object _lockObject; // 0x20
		private CancellationTokenSource cts; // 0x28
		private long _packetIndex; // 0x30
		private bool _isInSpeedTest; // 0x38
	
		// Constructors
		private HGSpeedTestSDK() {} // 0x0000000182D90CD0-0x0000000182D90E40
		static HGSpeedTestSDK() {} // 0x0000000182D90C60-0x0000000182D90CD0
	
		// Methods
		public static HGSpeedTestSDK GetInstance() => default; // 0x000000018887CE48-0x000000018887CE98
		public async System.Threading.Tasks.Task OnApplicationPause(bool pauseStatus) => default; // 0x0000000183134EB0-0x0000000183134F90
		public async Task<TaskResult> StartSpeedTest(List<SpeedTestServerInfo> serverList, Action<SpeedTestResult> callback, int round = 1 /* Metadata: 0x01FDCFF1 */, SpeedTestProtocol protocol = SpeedTestProtocol.TCP /* Metadata: 0x01FDCFF2 */) => default; // 0x000000018887D93C-0x000000018887DA58
		private void OnSpeedTestStart() {} // 0x000000018887D5A4-0x000000018887D70C
		private TaskResult OnSpeedTaskResult(int code, string message) => default; // 0x000000018887D384-0x000000018887D5A4
		private void NotifyRoundResult(Action<SpeedTestResult> callback, int code, int latency, SpeedTestServerInfo server) {} // 0x000000018887D04C-0x000000018887D384
		private void CleanupConnections() {} // 0x000000018887C2B4-0x000000018887C74C
		private void TestServerLatency(SpeedTestServerInfo server, Action<SpeedTestResult> callback, int round, SpeedTestProtocol protocol, CancellationToken cancellationToken) {} // 0x000000018887DA58-0x000000018887E07C
		private int EstablishConnection(SpeedTestServerInfo server) => default; // 0x000000018887C84C-0x000000018887CE48
		private SpeedTestResult TestTcpLatency(SpeedTestServerInfo server, List<long> serverLatencyList, CancellationToken cancellationToken) => default; // 0x000000018887E07C-0x000000018887E630
		private long SendTcpPackage(NetworkStream stream) => default; // 0x000000018887D70C-0x000000018887D93C
		private byte[] CreateTcpPacket() => default; // 0x000000018887C74C-0x000000018887C84C
		public long GetP50(List<long> latencies) => default; // 0x000000018887CE98-0x000000018887D04C
	}

	internal class NativeConfigLoader // TypeDefIndex: 59351
	{
		// Fields
		private static NativeConfigLoader instance; // 0x00
		private string region; // 0x10
		private string appDataPath; // 0x18
		private string _gameVersion; // 0x20
	
		// Constructors
		private NativeConfigLoader() {} // 0x0000000183CB7840-0x0000000183CB7880
		static NativeConfigLoader() {} // 0x0000000183CB77D0-0x0000000183CB7840
	
		// Methods
		public async System.Threading.Tasks.Task init() => default; // 0x00000001832F7CB0-0x00000001832F7D70
		public static NativeConfigLoader GetInstance() => default; // 0x000000018887E630-0x000000018887E680
		public string GetGameVersion() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public string GetRegion() => default; // 0x00000001832F7AE0-0x00000001832F7B20
		private string GetRegionFromConfig() => default; // 0x00000001832F7B20-0x00000001832F7BD0
		public string ReadWinConfig() => default; // 0x0000000182D7A560-0x0000000182D7A6C0
	}

	public class SpeedTestLogger // TypeDefIndex: 59353
	{
		// Constructors
		public SpeedTestLogger() {} // Dummy constructor
	
		// Methods
		public static void Debug(string message) {} // 0x0000000183158B70-0x0000000183158BF0
		public static void Error(string message) {} // 0x000000018887E680-0x000000018887E6EC
		public static void PrintLogToView(string logInfo) {} // 0x0000000183158BF0-0x0000000183158CA0
	}

	internal class UnityMainThread // TypeDefIndex: 59358
	{
		// Fields
		private static SynchronizationContext MainContext; // 0x00
		public static bool isDebug; // 0x08
	
		// Constructors
		public UnityMainThread() {} // Dummy constructor
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		public static void Init() {} // 0x000000018316FE90-0x000000018316FF30
		public static void RunOnMainThread(Action action) {} // 0x0000000183158CA0-0x0000000183158D90
		public static Task<T> RunOnMainThread<T>(Func<T> func) => default;
		public static async Task<bool> isAppFocused() => default; // 0x00000001832F7EA0-0x00000001832F7F60
	}

	public class WinConfigParser // TypeDefIndex: 59359
	{
		// Fields
		private static readonly byte[] iv; // 0x00
		private static readonly byte[] aes_key; // 0x08
		private static readonly string public_key_str; // 0x10
	
		// Constructors
		public WinConfigParser() {} // Dummy constructor
		static WinConfigParser() {} // 0x0000000183B3E930-0x0000000183B3EA50
	
		// Methods
		public static string ParseEncryptionFile(string encryptionfile, string verifyfile) => default; // 0x0000000183157C50-0x0000000183157DD0
		private static string DecryptConfig(byte[] encryptedData, byte[] key, byte[] iv) => default; // 0x0000000183188DE0-0x0000000183189470
		private static bool VerifySignature(string data, string sign) => default; // 0x0000000183188250-0x0000000183188C90
		private static void ImportRsaPublicKeyManually(RSACryptoServiceProvider rsa, byte[] publicKeyBytes) {} // 0x00000001823B04E0-0x00000001823B06F0
		private static byte[] ExtractPublicKeyFromPem(string pemString) => default; // 0x0000000183188C90-0x0000000183188DE0
	}
}
