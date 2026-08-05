/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 124: UnityWebSocket.Runtime.dll - Assembly: UnityWebSocket.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63686-63701
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace UnityWebSocket
{
	public class CloseEventArgs : EventArgs // TypeDefIndex: 63687
	{
		// Fields
		[CompilerGenerated]
		private ushort _Code_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Reason_k__BackingField; // 0x18
		[CompilerGenerated]
		private bool _WasClean_k__BackingField; // 0x20
	
		// Properties
		public ushort Code { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D96190-0x0000000184D961A0 0x0000000184D94F60-0x0000000184D94F70
		public string Reason { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool WasClean { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public CloseStatusCode StatusCode { get; } // 0x000000018B5915F8-0x000000018B5916C0 
	
		// Constructors
		internal CloseEventArgs(); // 0x000000018B5915B8-0x000000018B5915F8
		internal CloseEventArgs(ushort code); // 0x000000018B5915A4-0x000000018B5915B0
		internal CloseEventArgs(CloseStatusCode code); // 0x000000018B5915A4-0x000000018B5915B0
		internal CloseEventArgs(CloseStatusCode code, string reason); // 0x000000018B5915B0-0x000000018B5915B8
		internal CloseEventArgs(ushort code, string reason); // 0x000000018B591544-0x000000018B5915A4
	}

	public enum CloseStatusCode : ushort // TypeDefIndex: 63688
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

	public class ErrorEventArgs : EventArgs // TypeDefIndex: 63689
	{
		// Fields
		[CompilerGenerated]
		private Exception _Exception_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Message_k__BackingField; // 0x18
	
		// Properties
		public Exception Exception { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string Message { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		internal ErrorEventArgs(string message); // 0x000000018B59172C-0x000000018B591738
		internal ErrorEventArgs(string message, Exception exception); // 0x000000018B5916C0-0x000000018B59172C
	}

	public interface IWebSocket // TypeDefIndex: 63690
	{
		// Properties
		string Address { get; }
		string[] SubProtocols { get; }
		WebSocketState ReadyState { get; }
		string BinaryType { get; set; }
	
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

	public class MessageEventArgs : EventArgs // TypeDefIndex: 63691
	{
		// Fields
		private byte[] _rawData; // 0x10
		private string _data; // 0x18
		[CompilerGenerated]
		private Opcode _Opcode_k__BackingField; // 0x20
	
		// Properties
		internal Opcode Opcode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public string Data { get; } // 0x000000018B5918B0-0x000000018B5918CC 
		public byte[] RawData { get; } // 0x000000018B5918DC-0x000000018B5918F8 
		public bool IsBinary { get; } // 0x000000018B5918CC-0x000000018B5918D4 
		public bool IsText { get; } // 0x000000018B5918D4-0x000000018B5918DC 
	
		// Constructors
		internal MessageEventArgs(Opcode opcode, byte[] rawData); // 0x000000018B5917F0-0x000000018B591850
		internal MessageEventArgs(Opcode opcode, string data); // 0x000000018B591850-0x000000018B5918B0
	
		// Methods
		private void SetData(); // 0x000000018B591738-0x000000018B5917A0
		private void SetRawData(); // 0x000000018B5917A0-0x000000018B5917F0
	}

	public enum Opcode : byte // TypeDefIndex: 63692
	{
		Text = 1,
		Binary = 2,
		Close = 8
	}

	public class OpenEventArgs : EventArgs // TypeDefIndex: 63693
	{
		// Constructors
		internal OpenEventArgs(); // 0x000000018B5918F8-0x000000018B591938
	}

	public static class Settings // TypeDefIndex: 63694
	{
		// Fields
		public const string GITHUB = "https://github.com/psygames/UnityWebSocket"; // Metadata: 0x02352A50
		public const string QQ_GROUP = "1126457634"; // Metadata: 0x02352A7B
		public const string QQ_GROUP_LINK = "https://qm.qq.com/cgi-bin/qm/qr?k=KcexYJ9aYwogFXbj2aN0XHH5b2G7ICmd"; // Metadata: 0x02352A86
		public const string EMAIL = "799329256@qq.com"; // Metadata: 0x02352ACA
		public const string AUHTOR = "psygames"; // Metadata: 0x02352ADB
		public const string VERSION = "2.7.0"; // Metadata: 0x02352AE4
	}

	public enum WebSocketState : ushort // TypeDefIndex: 63695
	{
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3
	}

	public class WebSocket : IWebSocket // TypeDefIndex: 63700
	{
		// Fields
		[CompilerGenerated]
		private string _Address_k__BackingField; // 0x10
		[CompilerGenerated]
		private string[] _SubProtocols_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _BinaryType_k__BackingField; // 0x20
		[CompilerGenerated]
		private EventHandler<OpenEventArgs> OnOpen; // 0x28
		[CompilerGenerated]
		private EventHandler<CloseEventArgs> OnClose; // 0x30
		[CompilerGenerated]
		private EventHandler<ErrorEventArgs> OnError; // 0x38
		[CompilerGenerated]
		private EventHandler<MessageEventArgs> OnMessage; // 0x40
		private ClientWebSocket socket; // 0x48
		private object sendQueueLock; // 0x50
		private Queue<SendBuffer> sendQueue; // 0x58
		private bool isSendTaskRunning; // 0x60
		private readonly Queue<EventArgs> eventQueue; // 0x68
		private readonly object eventQueueLock; // 0x70
	
		// Properties
		public string Address { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string[] SubProtocols { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public WebSocketState ReadyState { get; } // 0x000000018B594828-0x000000018B594880 
		public string BinaryType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		private bool isOpening { get; } // 0x000000018B594880-0x000000018B5948AC 
	
		// Events
		public event EventHandler<OpenEventArgs> OnOpen {
			add; // 0x000000018B59479C-0x000000018B594828
			remove; // 0x000000018B594A50-0x000000018B594B48
		}
		public event EventHandler<CloseEventArgs> OnClose {
			add; // 0x000000018B5945F8-0x000000018B594684
			remove; // 0x000000018B5948AC-0x000000018B594938
		}
		public event EventHandler<ErrorEventArgs> OnError {
			add; // 0x000000018B594684-0x000000018B594710
			remove; // 0x000000018B594938-0x000000018B5949C4
		}
		public event EventHandler<MessageEventArgs> OnMessage {
			add; // 0x000000018B594710-0x000000018B59479C
			remove; // 0x000000018B5949C4-0x000000018B594A50
		}
	
		// Nested types
		private class SendBuffer // TypeDefIndex: 63696
		{
			// Fields
			public byte[] data; // 0x10
			public WebSocketMessageType type; // 0x18
	
			// Constructors
			public SendBuffer(byte[] data, WebSocketMessageType type); // 0x0000000183B46FF0-0x0000000183B47040
		}
	
		[CompilerGenerated]
		private struct _ConnectTask_d__36 : IAsyncStateMachine // TypeDefIndex: 63697
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public WebSocket __4__this; // 0x20
			private TaskAwaiter __u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018B591938-0x000000018B591D04
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018B591D04-0x000000018B591D60
		}
	
		[CompilerGenerated]
		private struct _SendTask_d__42 : IAsyncStateMachine // TypeDefIndex: 63698
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public WebSocket __4__this; // 0x20
			private TaskAwaiter __u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018B592760-0x000000018B592E38
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018B592E38-0x000000018B592E94
		}
	
		[CompilerGenerated]
		private struct _ReceiveTask_d__43 : IAsyncStateMachine // TypeDefIndex: 63699
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public WebSocket __4__this; // 0x20
			private string _closeReason_5__2; // 0x28
			private ushort _closeCode_5__3; // 0x30
			private bool _isClosed_5__4; // 0x32
			private ArraySegment<byte> _segment_5__5; // 0x38
			private MemoryStream _ms_5__6; // 0x48
			private TaskAwaiter<WebSocketReceiveResult> __u__1; // 0x50
	
			// Methods
			private void MoveNext(); // 0x000000018B591D60-0x000000018B592704
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018B592704-0x000000018B592760
		}
	
		// Constructors
		public WebSocket(string address); // 0x000000018B5944B0-0x000000018B5945F8
		public WebSocket(string address, string subProtocol); // 0x000000018B5941B4-0x000000018B59434C
		public WebSocket(string address, string[] subProtocols); // 0x000000018B59434C-0x000000018B5944B0
	
		// Methods
		public void ConnectAsync(); // 0x000000018B593354-0x000000018B5934F4
		public void CloseAsync(); // 0x000000018B5932D8-0x000000018B593354
		public void SendAsync(byte[] data); // 0x000000018B593B0C-0x000000018B593B98
		public void SendAsync(string text); // 0x000000018B593B98-0x000000018B593C40
		private async System.Threading.Tasks.Task ConnectTask(); // 0x000000018B5934F4-0x000000018B5935A4
		private void SendBufferAsync(SendBuffer buffer); // 0x000000018B593C40-0x000000018B593E20
		private async System.Threading.Tasks.Task SendTask(); // 0x000000018B593E20-0x000000018B593ED0
		private async System.Threading.Tasks.Task ReceiveTask(); // 0x000000018B593A50-0x000000018B593B0C
		private void SocketDispose(); // 0x000000018B593ED0-0x000000018B593F38
		private void HandleOpen(); // 0x000000018B59382C-0x000000018B593894
		private void HandleMessage(Opcode opcode, byte[] rawData); // 0x000000018B5937A4-0x000000018B59382C
		private void HandleClose(ushort code, string reason); // 0x000000018B5935A4-0x000000018B59362C
		private void HandleError(Exception exception); // 0x000000018B59362C-0x000000018B5936BC
		private void HandleEventSync(EventArgs eventArgs); // 0x000000018B5936BC-0x000000018B5937A4
		internal void Update(); // 0x000000018B593F38-0x000000018B5941B4
		[Conditional("UNITY_WEB_SOCKET_LOG")]
		private static void Log(string msg); // 0x000000018B593894-0x000000018B593A50
	}

	[DefaultExecutionOrder(-10000)]
	internal class WebSocketManager : MonoBehaviour // TypeDefIndex: 63701
	{
		// Fields
		private const string rootName = "[UnityWebSocket]"; // Metadata: 0x02352AF2
		private static WebSocketManager _instance; // 0x00
		private readonly List<WebSocket> sockets; // 0x18
	
		// Properties
		public static WebSocketManager Instance { get; } // 0x000000018B593260-0x000000018B5932D8 
	
		// Constructors
		public WebSocketManager(); // 0x000000018B5931E0-0x000000018B593260
	
		// Methods
		private void Awake(); // 0x000000018B592F14-0x000000018B592F64
		public static void CreateInstance(); // 0x000000018B592F64-0x000000018B5930D8
		public void Add(WebSocket socket); // 0x000000018B592E94-0x000000018B592F14
		public void Remove(WebSocket socket); // 0x000000018B5930D8-0x000000018B593158
		private void Update(); // 0x000000018B593158-0x000000018B5931E0
	}
}
