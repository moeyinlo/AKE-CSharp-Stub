/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 122: UnityWebSocket.Runtime.dll - Assembly: UnityWebSocket.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61050-61065

namespace UnityWebSocket
{
	public class CloseEventArgs : EventArgs // TypeDefIndex: 61051
	{
		// Fields
		private ushort _Code_k__BackingField; // 0x10
		private string _Reason_k__BackingField; // 0x18
		private bool _WasClean_k__BackingField; // 0x20
	
		// Properties
		public ushort Code { get; private set; } // 0x0000000185FC2810-0x0000000185FC2820 0x0000000185FC1C30-0x0000000185FC1C40
		public string Reason { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public bool WasClean { get; internal set; } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public CloseStatusCode StatusCode { get => default; } // 0x000000018C0A4BAC-0x000000018C0A4C74 
	
		// Constructors
		internal CloseEventArgs() {} // 0x000000018C0A4B6C-0x000000018C0A4BAC
		internal CloseEventArgs(ushort code) {} // 0x000000018C0A4B58-0x000000018C0A4B64
		internal CloseEventArgs(CloseStatusCode code) {} // 0x000000018C0A4B58-0x000000018C0A4B64
		internal CloseEventArgs(CloseStatusCode code, string reason) {} // 0x000000018C0A4B64-0x000000018C0A4B6C
		internal CloseEventArgs(ushort code, string reason) {} // 0x000000018C0A4AF8-0x000000018C0A4B58
	}

	public enum CloseStatusCode : ushort // TypeDefIndex: 61052
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

	public class ErrorEventArgs : EventArgs // TypeDefIndex: 61053
	{
		// Fields
		private Exception _Exception_k__BackingField; // 0x10
		private string _Message_k__BackingField; // 0x18
	
		// Properties
		public Exception Exception { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string Message { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public ErrorEventArgs() {} // Dummy constructor
		internal ErrorEventArgs(string message) {} // 0x000000018C0A4CE0-0x000000018C0A4CEC
		internal ErrorEventArgs(string message, Exception exception) {} // 0x000000018C0A4C74-0x000000018C0A4CE0
	}

	public interface IWebSocket // TypeDefIndex: 61054
	{
		// Properties
		string Address { get; }
		string[] SubProtocols { get; }
		WebSocketState ReadyState { get; }
		string BinaryType { get; set; }
	
		// Events
		event EventHandler<OpenEventArgs> OnOpen;
		event EventHandler<CloseEventArgs> OnClose;
		event EventHandler<ErrorEventArgs> OnError;
		event EventHandler<MessageEventArgs> OnMessage;
	
		// Methods
		void ConnectAsync();
		void CloseAsync();
		void SendAsync(byte[] data);
		void SendAsync(string text);
	}

	public class MessageEventArgs : EventArgs // TypeDefIndex: 61055
	{
		// Fields
		private byte[] _rawData; // 0x10
		private string _data; // 0x18
		private Opcode _Opcode_k__BackingField; // 0x20
	
		// Properties
		internal Opcode Opcode { get; private set; } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public string Data { get => default; } // 0x000000018C0A4E64-0x000000018C0A4E80 
		public byte[] RawData { get => default; } // 0x000000018C0A4E90-0x000000018C0A4EAC 
		public bool IsBinary { get => default; } // 0x000000018C0A4E80-0x000000018C0A4E88 
		public bool IsText { get => default; } // 0x000000018C0A4E88-0x000000018C0A4E90 
	
		// Constructors
		public MessageEventArgs() {} // Dummy constructor
		internal MessageEventArgs(Opcode opcode, byte[] rawData) {} // 0x000000018C0A4DA4-0x000000018C0A4E04
		internal MessageEventArgs(Opcode opcode, string data) {} // 0x000000018C0A4E04-0x000000018C0A4E64
	
		// Methods
		private void SetData() {} // 0x000000018C0A4CEC-0x000000018C0A4D54
		private void SetRawData() {} // 0x000000018C0A4D54-0x000000018C0A4DA4
	}

	public enum Opcode : byte // TypeDefIndex: 61056
	{
		Text = 1,
		Binary = 2,
		Close = 8
	}

	public class OpenEventArgs : EventArgs // TypeDefIndex: 61057
	{
		// Constructors
		internal OpenEventArgs() {} // 0x000000018C0A4EAC-0x000000018C0A4EEC
	}

	public static class Settings // TypeDefIndex: 61058
	{
		// Fields
		public const string GITHUB = "https://github.com/psygames/UnityWebSocket"; // Metadata: 0x02082DD0
		public const string QQ_GROUP = "1126457634"; // Metadata: 0x02082DFB
		public const string QQ_GROUP_LINK = "https://qm.qq.com/cgi-bin/qm/qr?k=KcexYJ9aYwogFXbj2aN0XHH5b2G7ICmd"; // Metadata: 0x02082E06
		public const string EMAIL = "799329256@qq.com"; // Metadata: 0x02082E4A
		public const string AUHTOR = "psygames"; // Metadata: 0x02082E5B
		public const string VERSION = "2.7.0"; // Metadata: 0x02082E64
	}

	public enum WebSocketState : ushort // TypeDefIndex: 61059
	{
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3
	}

	public class WebSocket : IWebSocket // TypeDefIndex: 61064
	{
		// Fields
		private string _Address_k__BackingField; // 0x10
		private string[] _SubProtocols_k__BackingField; // 0x18
		private string _BinaryType_k__BackingField; // 0x20
		private EventHandler<OpenEventArgs> OnOpen; // 0x28
		private EventHandler<CloseEventArgs> OnClose; // 0x30
		private EventHandler<ErrorEventArgs> OnError; // 0x38
		private EventHandler<MessageEventArgs> OnMessage; // 0x40
		private ClientWebSocket socket; // 0x48
		private object sendQueueLock; // 0x50
		private Queue<SendBuffer> sendQueue; // 0x58
		private bool isSendTaskRunning; // 0x60
		private readonly Queue<EventArgs> eventQueue; // 0x68
		private readonly object eventQueueLock; // 0x70
	
		// Properties
		public string Address { get; private set; } // 0x000000018C0A7F28-0x000000018C0A7FB4 0x000000018C0A81DC-0x000000018C0A8268
		public string[] SubProtocols { get; private set; } // 0x000000018C0A7D84-0x000000018C0A7E10 0x000000018C0A8038-0x000000018C0A80C4
		public WebSocketState ReadyState { get => default; } // 0x000000018C0A7E10-0x000000018C0A7E9C 
		public string BinaryType { get; set; } // 0x000000018C0A80C4-0x000000018C0A8150 0x000000018C0A7E9C-0x000000018C0A7F28
		private bool isOpening { get => default; } // 0x000000018C0A7224-0x000000018C0A72CC 
	
		// Events
		public event EventHandler<OpenEventArgs> OnOpen;
		public event EventHandler<CloseEventArgs> OnClose;
		public event EventHandler<ErrorEventArgs> OnError;
		public event EventHandler<MessageEventArgs> OnMessage;
	
		// Nested types
		private class SendBuffer // TypeDefIndex: 61060
		{
			// Fields
			public byte[] data; // 0x10
			public WebSocketMessageType type; // 0x18
	
			// Constructors
			public SendBuffer() {} // Dummy constructor
			public SendBuffer(byte[] data, WebSocketMessageType type) {} // 0x000000018346D130-0x000000018346D140
		}
	
		private struct _ConnectTask_d__36 : IAsyncStateMachine // TypeDefIndex: 61061
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public WebSocket __4__this; // 0x20
			private TaskAwaiter __u__1; // 0x28
	
			// Methods
			private void MoveNext() {} // 0x0000000184096E30-0x0000000184096EF0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private struct _SendTask_d__42 : IAsyncStateMachine // TypeDefIndex: 61062
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public WebSocket __4__this; // 0x20
			private TaskAwaiter __u__1; // 0x28
	
			// Methods
			private void MoveNext() {} // 0x0000000184088E70-0x0000000184088E80
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018C0A7FB4-0x000000018C0A800C
		}
	
		private struct _ReceiveTask_d__43 : IAsyncStateMachine // TypeDefIndex: 61063
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
			private void MoveNext() {} // 0x00000001813B31A0-0x00000001813B31B0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018646EE40-0x000000018646EE50
		}
	
		// Constructors
		public WebSocket() {} // Dummy constructor
		public WebSocket(string address) {} // 0x000000018C0A6B80-0x000000018C0A6C30
		public WebSocket(string address, string subProtocol) {} // 0x000000018C0A72CC-0x000000018C0A75AC
		public WebSocket(string address, string[] subProtocols) {} // 0x000000018C0A75AC-0x000000018C0A765C
	
		// Methods
		public void ConnectAsync() {} // 0x000000018C0A70DC-0x000000018C0A7198
		public void CloseAsync() {} // 0x000000018C0A765C-0x000000018C0A76C4
		public void SendAsync(byte[] data) {} // 0x000000018C0A6EB8-0x000000018C0A6F20
		public void SendAsync(string text) {} // 0x000000018C0A6E30-0x000000018C0A6EB8
		private System.Threading.Tasks.Task ConnectTask() => default; // 0x000000018C0A6C30-0x000000018C0A6CB8
		private void SendBufferAsync(SendBuffer buffer) {} // 0x000000018C0A6CB8-0x000000018C0A6D48
		private System.Threading.Tasks.Task SendTask() => default; // 0x000000018C0A6D48-0x000000018C0A6E30
		private System.Threading.Tasks.Task ReceiveTask() => default; // 0x000000018C0A76C4-0x000000018C0A7940
		private void SocketDispose() {} // 0x000000018C0A6F20-0x000000018C0A70DC
		private void HandleOpen() {} // 0x00000001845D7850-0x00000001845D7870
		private void HandleMessage(Opcode opcode, byte[] rawData) {} // 0x000000018C0A4EEC-0x000000018C0A5318
		private void HandleClose(ushort code, string reason) {} // 0x000000018C0A5318-0x000000018C0A5374
		private void HandleError(Exception exception) {} // 0x000000018C0A5DA8-0x000000018C0A64C4
		private void HandleEventSync(EventArgs eventArgs) {} // 0x000000018C0A64C4-0x000000018C0A6520
		internal void Update() {} // 0x000000018C0A5374-0x000000018C0A5D4C
		private static void Log(string msg) {} // 0x000000018C0A5D4C-0x000000018C0A5DA8
	}

	internal class WebSocketManager : MonoBehaviour // TypeDefIndex: 61065
	{
		// Fields
		private const string rootName = "[UnityWebSocket]"; // Metadata: 0x02082E72
		private static WebSocketManager _instance; // 0x00
		private readonly List<WebSocket> sockets; // 0x18
	
		// Properties
		public static WebSocketManager Instance { get => default; } // 0x000000018C0A68EC-0x000000018C0A6964 
	
		// Constructors
		public WebSocketManager() {} // 0x000000018C0A686C-0x000000018C0A68EC
	
		// Methods
		private void Awake() {} // 0x000000018C0A65A0-0x000000018C0A65F0
		public static void CreateInstance() {} // 0x000000018C0A65F0-0x000000018C0A6764
		public void Add(WebSocket socket) {} // 0x000000018C0A6520-0x000000018C0A65A0
		public void Remove(WebSocket socket) {} // 0x000000018C0A6764-0x000000018C0A67E4
		private void Update() {} // 0x000000018C0A67E4-0x000000018C0A686C
	}
}
