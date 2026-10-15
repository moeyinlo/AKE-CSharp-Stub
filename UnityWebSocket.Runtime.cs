/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

// Image 124: UnityWebSocket.Runtime.dll - Assembly: UnityWebSocket.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91132-91147

namespace UnityWebSocket
{
	public class CloseEventArgs : EventArgs // TypeDefIndex: 91133
	{
		// Fields
		[CompilerGenerated]
		private ushort _Code_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Reason_k__BackingField; // 0x18
		[CompilerGenerated]
		private bool _WasClean_k__BackingField; // 0x20
	
		// Properties
		public ushort Code { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184434E50-0x0000000184434E60 0x0000000187243130-0x0000000187243140
		public string Reason { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public bool WasClean { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public CloseStatusCode StatusCode { get; } // 0x000000018D6BB17C-0x000000018D6BB244 
	
		// Constructors
		internal CloseEventArgs(); // 0x000000018D6BB13C-0x000000018D6BB17C
		internal CloseEventArgs(ushort code); // 0x000000018D6BB128-0x000000018D6BB134
		internal CloseEventArgs(CloseStatusCode code); // 0x000000018D6BB128-0x000000018D6BB134
		internal CloseEventArgs(CloseStatusCode code, string reason); // 0x000000018D6BB134-0x000000018D6BB13C
		internal CloseEventArgs(ushort code, string reason); // 0x000000018D6BB0C8-0x000000018D6BB128
	}

	public enum CloseStatusCode : ushort // TypeDefIndex: 91134
	{
		Normal = 1000,
		Away = 1001,
		ProtocolError = 1002,
		UnsupportedData = 1003,
		Undefined = 1004,
		NoStatus = 1005,
		Abnormal = 1006,
		InvalidData = 1007,
		PolicyViolation = 1008,
		TooBig = 1009,
		MandatoryExtension = 1010,
		ServerError = 1011,
		TlsHandshakeFailure = 1015,
		Unknown = 65534
	}

	public class ErrorEventArgs : EventArgs // TypeDefIndex: 91135
	{
		// Fields
		[CompilerGenerated]
		private Exception _Exception_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Message_k__BackingField; // 0x18
	
		// Properties
		public Exception Exception { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string Message { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		internal ErrorEventArgs(string message); // 0x000000018D6BB2B0-0x000000018D6BB2BC
		internal ErrorEventArgs(string message, Exception exception); // 0x000000018D6BB244-0x000000018D6BB2B0
	}

	public interface IWebSocket // TypeDefIndex: 91136
	{
		// Properties
		string Address { get; }
		string[] SubProtocols { get; }
		WebSocketState ReadyState { get; }
	
		// Events
		event EventHandler<OpenEventArgs> OnOpen {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event EventHandler<CloseEventArgs> OnClose {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event EventHandler<ErrorEventArgs> OnError {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event EventHandler<MessageEventArgs> OnMessage {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void ConnectAsync();
		void CloseAsync();
		void SendAsync(byte[] data);
		void SendAsync(string text);
	}

	public class MessageEventArgs : EventArgs // TypeDefIndex: 91137
	{
		// Fields
		private byte[] _rawData; // 0x10
		private string _data; // 0x18
		[CompilerGenerated]
		private Opcode _Opcode_k__BackingField; // 0x20
	
		// Properties
		internal Opcode Opcode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public string Data { get; } // 0x000000018D6BB434-0x000000018D6BB450 
		public byte[] RawData { get; } // 0x000000018D6BB460-0x000000018D6BB47C 
		public bool IsBinary { get; } // 0x000000018D6BB450-0x000000018D6BB458 
		public bool IsText { get; } // 0x000000018D6BB458-0x000000018D6BB460 
	
		// Constructors
		internal MessageEventArgs(Opcode opcode, byte[] rawData); // 0x000000018D6BB374-0x000000018D6BB3D4
		internal MessageEventArgs(Opcode opcode, string data); // 0x000000018D6BB3D4-0x000000018D6BB434
	
		// Methods
		private void SetData(); // 0x000000018D6BB2BC-0x000000018D6BB324
		private void SetRawData(); // 0x000000018D6BB324-0x000000018D6BB374
	}

	public enum Opcode : byte // TypeDefIndex: 91138
	{
		Text = 1,
		Binary = 2,
		Close = 8
	}

	public class OpenEventArgs : EventArgs // TypeDefIndex: 91139
	{
		// Constructors
		internal OpenEventArgs(); // 0x000000018D6BB47C-0x000000018D6BB4BC
	}

	public static class Settings // TypeDefIndex: 91140
	{
		// Fields
		public const string GITHUB = "https://github.com/psygames/UnityWebSocket"; // Metadata: 0x0264B3D4
		public const string QQ_GROUP = "1126457634"; // Metadata: 0x0264B3FF
		public const string QQ_GROUP_LINK = "https://qm.qq.com/cgi-bin/qm/qr?k=KcexYJ9aYwogFXbj2aN0XHH5b2G7ICmd"; // Metadata: 0x0264B40A
		public const string EMAIL = "799329256@qq.com"; // Metadata: 0x0264B44E
		public const string AUHTOR = "psygames"; // Metadata: 0x0264B45F
		public const string VERSION = "2.8.6"; // Metadata: 0x0264B468
	}

	public enum WebSocketState : ushort // TypeDefIndex: 91141
	{
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3
	}

	public class WebSocket : IWebSocket // TypeDefIndex: 91146
	{
		// Fields
		[CompilerGenerated]
		private string _Address_k__BackingField; // 0x10
		[CompilerGenerated]
		private string[] _SubProtocols_k__BackingField; // 0x18
		[CompilerGenerated]
		private EventHandler<OpenEventArgs> OnOpen; // 0x20
		[CompilerGenerated]
		private EventHandler<CloseEventArgs> OnClose; // 0x28
		[CompilerGenerated]
		private EventHandler<ErrorEventArgs> OnError; // 0x30
		[CompilerGenerated]
		private EventHandler<MessageEventArgs> OnMessage; // 0x38
		private ClientWebSocket socket; // 0x40
		private ConcurrentQueue<SendBuffer> sendQueue; // 0x48
		private ConcurrentQueue<EventArgs> eventQueue; // 0x50
		private bool closeProcessing; // 0x58
		private CancellationTokenSource cts; // 0x60
	
		// Properties
		public string Address { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string[] SubProtocols { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public WebSocketState ReadyState { get; } // 0x000000018D6BCC78-0x000000018D6BCCD0 
		private bool isOpening { get; } // 0x000000018D6BCCD0-0x000000018D6BCCFC 
	
		// Events
		public event EventHandler<OpenEventArgs> OnOpen {
			add; // 0x000000018D6BCBEC-0x000000018D6BCC78
			remove; // 0x000000018D6BCEA0-0x000000018D6BCF2C
		}
		public event EventHandler<CloseEventArgs> OnClose {
			add; // 0x000000018D6BCA48-0x000000018D6BCAD4
			remove; // 0x000000018D6BCCFC-0x000000018D6BCD88
		}
		public event EventHandler<ErrorEventArgs> OnError {
			add; // 0x000000018D6BCAD4-0x000000018D6BCB60
			remove; // 0x000000018D6BCD88-0x000000018D6BCE14
		}
		public event EventHandler<MessageEventArgs> OnMessage {
			add; // 0x000000018D6BCB60-0x000000018D6BCBEC
			remove; // 0x000000018D6BCE14-0x000000018D6BCEA0
		}
	
		// Nested types
		private class SendBuffer // TypeDefIndex: 91142
		{
			// Fields
			public byte[] data; // 0x10
			public WebSocketMessageType type; // 0x18
	
			// Constructors
			public SendBuffer(byte[] data, WebSocketMessageType type); // 0x00000001856B50C0-0x00000001856B50E0
		}
	
		[CompilerGenerated]
		private struct _ConnectTask_d__39 : IAsyncStateMachine // TypeDefIndex: 91143
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public WebSocket __4__this; // 0x20
			private TaskAwaiter __u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x0000000184F729C0-0x0000000184F74130
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000184F74130-0x0000000184F74550
		}
	
		[CompilerGenerated]
		private struct _StartSendTask_d__40 : IAsyncStateMachine // TypeDefIndex: 91144
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public WebSocket __4__this; // 0x28
			private TaskAwaiter __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000184F76900-0x0000000184F78670
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001841B3CD0-0x00000001841B5700
		}
	
		[CompilerGenerated]
		private struct _StartReceiveTask_d__41 : IAsyncStateMachine // TypeDefIndex: 91145
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncVoidMethodBuilder __t__builder; // 0x08
			public WebSocket __4__this; // 0x28
			private string _closeReason_5__2; // 0x30
			private ushort _closeCode_5__3; // 0x38
			private bool _isClosed_5__4; // 0x3A
			private ArraySegment<byte> _segment_5__5; // 0x40
			private MemoryStream _ms_5__6; // 0x50
			private TaskAwaiter<WebSocketReceiveResult> __u__1; // 0x58
	
			// Methods
			private void MoveNext(); // 0x0000000184F74550-0x0000000184F76900
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001841B3CD0-0x00000001841B5700
		}
	
		// Constructors
		public WebSocket(string address); // 0x000000018D6BC8A8-0x000000018D6BCA48
		public WebSocket(string address, string subProtocol); // 0x000000018D6BC488-0x000000018D6BC6B0
		public WebSocket(string address, string[] subProtocols); // 0x000000018D6BC6B0-0x000000018D6BC8A8
	
		// Methods
		public void ConnectAsync(); // 0x000000018D6BB920-0x000000018D6BBBA0
		public void CloseAsync(); // 0x000000018D6BB900-0x000000018D6BB920
		public void SendAsync(byte[] data); // 0x000000018D6BBFC8-0x000000018D6BC068
		public void SendAsync(string text); // 0x000000018D6BC068-0x000000018D6BC128
		private void CleanSendQueue(); // 0x0000000184F79000-0x0000000184F79320
		private void CleanEventQueue(); // 0x0000000184F78CE0-0x0000000184F79000
		private async System.Threading.Tasks.Task ConnectTask(); // 0x000000018D6BBBA0-0x000000018D6BBC54
		private async void StartSendTask(); // 0x0000000184F797F0-0x0000000184F79F80
		private async void StartReceiveTask(); // 0x0000000184F79320-0x0000000184F797F0
		private void SocketDispose(); // 0x000000018D6BC128-0x000000018D6BC240
		private void HandleOpen(); // 0x000000018D6BBE4C-0x000000018D6BBECC
		private void HandleMessage(Opcode opcode, byte[] rawData); // 0x000000018D6BBDAC-0x000000018D6BBE4C
		private void HandleClose(ushort code, string reason); // 0x000000018D6BBC54-0x000000018D6BBCF4
		private void HandleError(Exception exception); // 0x000000018D6BBCF4-0x000000018D6BBDAC
		internal void Update(); // 0x000000018D6BC240-0x000000018D6BC488
		internal void Abort(); // 0x0000000184F78CA0-0x0000000184F78CE0
		[Conditional("UNITY_WEB_SOCKET_LOG")]
		private static void Log(string msg); // 0x000000018D6BBECC-0x000000018D6BBFC8
	}

	[DefaultExecutionOrder(-10000)]
	[DisallowMultipleComponent]
	internal class WebSocketManager : MonoBehaviour // TypeDefIndex: 91147
	{
		// Fields
		private const string rootName = "[UnityWebSocket]"; // Metadata: 0x0264B476
		private static WebSocketManager _instance; // 0x00
		private readonly List<WebSocket> sockets; // 0x18
	
		// Properties
		public static WebSocketManager Instance { get; } // 0x000000018D6BB888-0x000000018D6BB900 
	
		// Constructors
		public WebSocketManager(); // 0x000000018D6BB808-0x000000018D6BB888
	
		// Methods
		private void Awake(); // 0x000000018D6BB53C-0x000000018D6BB58C
		public static void CreateInstance(); // 0x000000018D6BB58C-0x000000018D6BB700
		public void Add(WebSocket socket); // 0x000000018D6BB4BC-0x000000018D6BB53C
		public void Remove(WebSocket socket); // 0x000000018D6BB700-0x000000018D6BB780
		private void Update(); // 0x000000018D6BB780-0x000000018D6BB808
		private void OnDisable(); // 0x0000000184F78670-0x0000000184F78680
		private void SocketAbort(); // 0x0000000184F78680-0x0000000184F78CA0
	}
}
