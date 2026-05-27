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

// Image 118: UnityWebSocket.Runtime.dll - Assembly: UnityWebSocket.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59929-59944
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace UnityWebSocket
{
	public class CloseEventArgs : EventArgs // TypeDefIndex: 59930
	{
		// Properties
		public ushort Code { get; private set; } // 0x0000000183D61390-0x0000000183D613A0 0x0000000183D60960-0x0000000183D60970
		public string Reason { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public bool WasClean { get; internal set; } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public CloseStatusCode StatusCode { get => default; } // 0x0000000189F8CEC0-0x0000000189F8CF88 
	
		// Constructors
		internal CloseEventArgs() {} // 0x0000000189F8CE80-0x0000000189F8CEC0
		internal CloseEventArgs(ushort code) {} // 0x0000000189F8CE6C-0x0000000189F8CE78
		internal CloseEventArgs(CloseStatusCode code) {} // 0x0000000189F8CE6C-0x0000000189F8CE78
		internal CloseEventArgs(CloseStatusCode code, string reason) {} // 0x0000000189F8CE78-0x0000000189F8CE80
		internal CloseEventArgs(ushort code, string reason) {} // 0x0000000189F8CE0C-0x0000000189F8CE6C
	}

	public enum CloseStatusCode : ushort // TypeDefIndex: 59931
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

	public class ErrorEventArgs : EventArgs // TypeDefIndex: 59932
	{
		// Properties
		public Exception Exception { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string Message { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public ErrorEventArgs() {} // Dummy constructor
		internal ErrorEventArgs(string message) {} // 0x0000000189F8CFF4-0x0000000189F8D000
		internal ErrorEventArgs(string message, Exception exception) {} // 0x0000000189F8CF88-0x0000000189F8CFF4
	}

	public interface IWebSocket // TypeDefIndex: 59933
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

	public class MessageEventArgs : EventArgs // TypeDefIndex: 59934
	{
		// Fields
		private byte[] _rawData; // 0x10
		private string _data; // 0x18
	
		// Properties
		internal Opcode Opcode { get; private set; } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public string Data { get => default; } // 0x0000000189F8D178-0x0000000189F8D194 
		public byte[] RawData { get => default; } // 0x0000000189F8D1A4-0x0000000189F8D1C0 
		public bool IsBinary { get => default; } // 0x0000000189F8D194-0x0000000189F8D19C 
		public bool IsText { get => default; } // 0x0000000189F8D19C-0x0000000189F8D1A4 
	
		// Constructors
		public MessageEventArgs() {} // Dummy constructor
		internal MessageEventArgs(Opcode opcode, byte[] rawData) {} // 0x0000000189F8D0B8-0x0000000189F8D118
		internal MessageEventArgs(Opcode opcode, string data) {} // 0x0000000189F8D118-0x0000000189F8D178
	
		// Methods
		private void SetData() {} // 0x0000000189F8D000-0x0000000189F8D068
		private void SetRawData() {} // 0x0000000189F8D068-0x0000000189F8D0B8
	}

	public enum Opcode : byte // TypeDefIndex: 59935
	{
		Text = 1,
		Binary = 2,
		Close = 8
	}

	public class OpenEventArgs : EventArgs // TypeDefIndex: 59936
	{
		// Constructors
		internal OpenEventArgs() {} // 0x0000000189F8D1C0-0x0000000189F8D200
	}

	public static class Settings // TypeDefIndex: 59937
	{
		// Fields
		public const string GITHUB = "https://github.com/psygames/UnityWebSocket"; // Metadata: 0x01FDD47C
		public const string QQ_GROUP = "1126457634"; // Metadata: 0x01FDD4A7
		public const string QQ_GROUP_LINK = "https://qm.qq.com/cgi-bin/qm/qr?k=KcexYJ9aYwogFXbj2aN0XHH5b2G7ICmd"; // Metadata: 0x01FDD4B2
		public const string EMAIL = "799329256@qq.com"; // Metadata: 0x01FDD4F6
		public const string AUHTOR = "psygames"; // Metadata: 0x01FDD507
		public const string VERSION = "2.7.0"; // Metadata: 0x01FDD510
	}

	public enum WebSocketState : ushort // TypeDefIndex: 59938
	{
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3
	}

	public class WebSocket : IWebSocket // TypeDefIndex: 59943
	{
		// Fields
		private ClientWebSocket socket; // 0x48
		private object sendQueueLock; // 0x50
		private Queue<SendBuffer> sendQueue; // 0x58
		private bool isSendTaskRunning; // 0x60
		private readonly Queue<EventArgs> eventQueue; // 0x68
		private readonly object eventQueueLock; // 0x70
	
		// Properties
		public string Address { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string[] SubProtocols { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public WebSocketState ReadyState { get => default; } // 0x0000000189F90250-0x0000000189F902A8 
		public string BinaryType { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		private bool isOpening { get => default; } // 0x0000000189F902A8-0x0000000189F902D4 
	
		// Events
		public event EventHandler<OpenEventArgs> OnOpen;
		public event EventHandler<CloseEventArgs> OnClose;
		public event EventHandler<ErrorEventArgs> OnError;
		public event EventHandler<MessageEventArgs> OnMessage;
	
		// Nested types
		private class SendBuffer // TypeDefIndex: 59939
		{
			// Fields
			public byte[] data; // 0x10
			public WebSocketMessageType type; // 0x18
	
			// Constructors
			public SendBuffer() {} // Dummy constructor
			public SendBuffer(byte[] data, WebSocketMessageType type) {} // 0x0000000182738A30-0x0000000182738A50
		}
	
		// Constructors
		public WebSocket() {} // Dummy constructor
		public WebSocket(string address) {} // 0x0000000189F8FED8-0x0000000189F90020
		public WebSocket(string address, string subProtocol) {} // 0x0000000189F8FBDC-0x0000000189F8FD74
		public WebSocket(string address, string[] subProtocols) {} // 0x0000000189F8FD74-0x0000000189F8FED8
	
		// Methods
		public void ConnectAsync() {} // 0x0000000189F8EC7C-0x0000000189F8EE1C
		public void CloseAsync() {} // 0x0000000189F8EC00-0x0000000189F8EC7C
		public void SendAsync(byte[] data) {} // 0x0000000189F8F434-0x0000000189F8F4C0
		public void SendAsync(string text) {} // 0x0000000189F8F4C0-0x0000000189F8F568
		private async System.Threading.Tasks.Task ConnectTask() => default; // 0x0000000189F8EE1C-0x0000000189F8EECC
		private void SendBufferAsync(SendBuffer buffer) {} // 0x0000000189F8F568-0x0000000189F8F848
		private async System.Threading.Tasks.Task SendTask() => default; // 0x0000000189F8F848-0x0000000189F8F8F8
		private async System.Threading.Tasks.Task ReceiveTask() => default; // 0x0000000189F8F378-0x0000000189F8F434
		private void SocketDispose() {} // 0x0000000189F8F8F8-0x0000000189F8F960
		private void HandleOpen() {} // 0x0000000189F8F154-0x0000000189F8F1BC
		private void HandleMessage(Opcode opcode, byte[] rawData) {} // 0x0000000189F8F0CC-0x0000000189F8F154
		private void HandleClose(ushort code, string reason) {} // 0x0000000189F8EECC-0x0000000189F8EF54
		private void HandleError(Exception exception) {} // 0x0000000189F8EF54-0x0000000189F8EFE4
		private void HandleEventSync(EventArgs eventArgs) {} // 0x0000000189F8EFE4-0x0000000189F8F0CC
		internal void Update() {} // 0x0000000189F8F960-0x0000000189F8FBDC
		[Conditional("UNITY_WEB_SOCKET_LOG")]
		private static void Log(string msg) {} // 0x0000000189F8F1BC-0x0000000189F8F378
	}

	[DefaultExecutionOrder(-10000)]
	internal class WebSocketManager : MonoBehaviour // TypeDefIndex: 59944
	{
		// Fields
		private const string rootName = "[UnityWebSocket]"; // Metadata: 0x01FDD51E
		private static WebSocketManager _instance; // 0x00
		private readonly List<WebSocket> sockets; // 0x18
	
		// Properties
		public static WebSocketManager Instance { get => default; } // 0x0000000189F8EB88-0x0000000189F8EC00 
	
		// Constructors
		public WebSocketManager() {} // 0x0000000189F8EB08-0x0000000189F8EB88
	
		// Methods
		private void Awake() {} // 0x0000000189F8E83C-0x0000000189F8E88C
		public static void CreateInstance() {} // 0x0000000189F8E88C-0x0000000189F8EA00
		public void Add(WebSocket socket) {} // 0x0000000189F8E7BC-0x0000000189F8E83C
		public void Remove(WebSocket socket) {} // 0x0000000189F8EA00-0x0000000189F8EA80
		private void Update() {} // 0x0000000189F8EA80-0x0000000189F8EB08
	}
}
