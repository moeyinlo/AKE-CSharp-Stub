/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Beyond;
using Beyond.Log;
using Beyond.Network;
using Beyond.Network.HGNetLogger;
using Beyond.Resource;
using Beyond.XXEnc;
using Google.Protobuf;
using Google.Protobuf.Collections;
using IFix.Core;
using Proto;
using UnityEngine;
using UnityEngine.Networking;

// Image 44: Network.Beyond.dll - Assembly: Network.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57120-57219

namespace Beyond.Network
{
	public class DoubleQueue<T> // TypeDefIndex: 57127
	{
		// Fields
		private Queue<T> m_readQueue;
		private Queue<T> m_writeQueue;
	
		// Constructors
		public DoubleQueue() {}
	
		// Methods
		public void LockingSwap() {}
		public void TryLockingSwap() {}
		public void Enqueue(T item) {}
		public bool TryDequeue(out ref T item) {
			item = default;
			return default;
		}
		public void EnqueueRange(List<T> list) {}
	}

	public class HGTcpClient : IDisposable // TypeDefIndex: 57128
	{
		// Fields
		private Socket m_ClientSocket; // 0x10
		private bool m_Active; // 0x18
		private NetworkStream m_DataStream; // 0x20
		private AddressFamily m_Family; // 0x28
		private bool m_CleanedUp; // 0x2C
	
		// Properties
		public Socket Client { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		protected bool Active { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public int Available { get => default; } // 0x00000001843C7F00-0x00000001843C7F90 
		public bool Connected { get => default; } // 0x00000001843C7B70-0x00000001843C7D60 
		public bool ExclusiveAddressUse { get => default; set {} } // 0x000000018B3CB124-0x000000018B3CB144 0x000000018B3CB1B8-0x000000018B3CB1D8
		public int ReceiveBufferSize { get => default; set {} } // 0x000000018B3CB168-0x000000018B3CB17C 0x0000000183FBDC30-0x0000000183FBDC70
		public int SendBufferSize { get => default; set {} } // 0x000000018B3CB190-0x000000018B3CB1A4 0x0000000183FBDC70-0x0000000183FBDCB0
		public int ReceiveTimeout { get => default; set {} } // 0x000000018B3CB17C-0x000000018B3CB190 0x000000018B3CB20C-0x000000018B3CB240
		public int SendTimeout { get => default; set {} } // 0x000000018B3CB1A4-0x000000018B3CB1B8 0x0000000183FBDCB0-0x0000000183FBDCF0
		public LingerOption LingerState { get => default; set {} } // 0x0000000183FBCA20-0x0000000183FBCAA0 0x000000018B3CB1D8-0x000000018B3CB20C
		public bool NoDelay { get => default; set {} } // 0x000000018B3CB144-0x000000018B3CB168 0x0000000183FBDCF0-0x0000000183FBDD30
	
		// Constructors
		public HGTcpClient() {} // 0x0000000183FBDB70-0x0000000183FBDB80
		public HGTcpClient(string hostname, int port) {} // 0x000000018B3CAF90-0x000000018B3CB0FC
		internal HGTcpClient(Socket acceptedSocket) {} // 0x000000018B3CB0FC-0x000000018B3CB124
	
		// Methods
		public void Connect(string hostname, int port) {} // 0x0000000183FBD290-0x0000000183FBDB70
		public void Connect(IPAddress address, int port) {} // 0x000000018B3CACE8-0x000000018B3CAE74
		public void Connect(IPEndPoint remoteEP) {} // 0x0000000183FBC780-0x0000000183FBC7E0
		public void Connect(IPAddress[] ipAddresses, int port) {} // 0x000000018B3CAC68-0x000000018B3CACE8
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) => default; // 0x0000000184FA49E0-0x0000000184FA4A60
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) => default; // 0x000000018B3CA8F0-0x000000018B3CA998
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state) => default; // 0x000000018B3CA848-0x000000018B3CA8F0
		public void EndConnect(IAsyncResult asyncResult) {} // 0x0000000185A32F00-0x0000000185A32F50
		public System.Threading.Tasks.Task ConnectAsync(IPAddress address, int port) => default; // 0x000000018B3CA998-0x000000018B3CAB00
		public System.Threading.Tasks.Task ConnectAsync(string host, int port) => default; // 0x0000000183FBBC90-0x0000000183FBBE60
		public System.Threading.Tasks.Task ConnectAsync(IPAddress[] addresses, int port) => default; // 0x000000018B3CAB00-0x000000018B3CAC68
		public NetworkStream GetStream() => default; // 0x00000001843CE2F0-0x00000001843CE4E0
		public void Close() {} // 0x0000000184A93E30-0x0000000184A93E90
		protected virtual void Dispose(bool disposing) {} // 0x0000000184A938A0-0x0000000184A93E30
		public void Dispose() {} // 0x0000000184A93860-0x0000000184A938A0
		~HGTcpClient() {} // 0x000000018B3CAE74-0x000000018B3CAEE8
		private void _Initialize() {} // 0x0000000183FBDB80-0x0000000183FBDC30
		private int _NumericOption(SocketOptionLevel optionLevel, SocketOptionName optionName) => default; // 0x000000018B3CAEE8-0x000000018B3CAF90
	}

	public interface INetIO : IDisposable // TypeDefIndex: 57129
	{
		// Methods
		void Connect(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize);
		System.Threading.Tasks.Task ConnectAsync(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize);
		void Close();
		void TestCloseNetIO(bool bIsTestReconnectFailed);
		void TestDropNetIO(bool bIsTestDropSC, bool bIsTestDropCS);
		bool IsConnected();
		int ReadData(byte[] buffer, int offset, int len);
		void WriteData(byte[] data, int offset, int len);
		bool IsAuthed();
		void MarkAuthed();
		void EnableCryptStream(byte[] key, byte[] iv);
		int ReadCryptoData(byte[] buffer, int offset, int len);
		void WriteCryptoData(byte[] data, int offset, int len);
		byte[] GetSendHeadBuffer();
		byte[] GetSendBuffer();
		byte[] GetReceiveBuffer();
		int GetReceiveBufferOffset();
		void ClearReceiveBufferOffset();
		void SkipReceiveBufferOffset(int len);
		EndPoint GetEndPoint();
		int Available();
	}

	public class NetMsgHandlerAttribute : Attribute // TypeDefIndex: 57130
	{
		// Fields
		public readonly System.Type msgType; // 0x10
	
		// Constructors
		public NetMsgHandlerAttribute(System.Type t) {} // 0x0000000184096E30-0x0000000184096EF0
		public NetMsgHandlerAttribute() {} // 0x0000000185633D30-0x0000000185633D50
	
		// Methods
		public System.Type GetMsgType(MethodInfo annotatedMethod) => default; // 0x0000000184B05080-0x0000000184B05170
	}

	public delegate void NetResponseHandler(in NetResponse msg); // TypeDefIndex: 57131; 0x00000001833EEC70-0x00000001833EEC80

	public delegate void NetMessageHandle<in T>(T message); // TypeDefIndex: 57132; 0x00000000-0x00000000

	public interface INetBusResponseListener // TypeDefIndex: 57133
	{
		// Methods
		void UpdateMsgTime(NetResponse resp);
	}

	public struct NetRequest // TypeDefIndex: 57134
	{
		// Fields
		public ulong csSeqID; // 0x00
		public int mergeNum; // 0x08
		public IMessage msg; // 0x10
	}

	public struct NetResponse // TypeDefIndex: 57135
	{
		// Fields
		public static NetResponse EMPTY; // 0x00
		public IMessage headMsg; // 0x00
		public IMessage msgBody; // 0x08
		public bool isPacked; // 0x10
		public long recvTimestamp; // 0x18
	
		// Properties
		public Header logHead { get => default; set {} } // 0x00000001843C3200-0x00000001843C32A0 0x000000018646FE2C-0x000000018646FE34
		public CSHead csHead { get => default; set {} } // 0x00000001843C4690-0x00000001843C48E0 0x000000018646FE2C-0x000000018646FE34
		public int msgId { get => default; } // 0x00000001843C4610-0x00000001843C4690 
		public ulong csSeqId { get => default; } // 0x00000001843C38B0-0x00000001843C3CB0 
		public ulong scSeqId { get => default; } // 0x00000001843C3830-0x00000001843C38B0 
	
		// Constructors
		static NetResponse() {
			EMPTY = default;
		} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class MessageHandleWrapper // TypeDefIndex: 57136
	{
		// Constructors
		protected MessageHandleWrapper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract void HandleMessage(IMessage msg);
	}

	public class MessageHandleWrapper<T> : MessageHandleWrapper // TypeDefIndex: 57137
		where T : class, IMessage
	{
		// Fields
		private readonly NetMessageHandle<T> m_handle;
	
		// Constructors
		public MessageHandleWrapper() {} // Dummy constructor
		public MessageHandleWrapper(NetMessageHandle<T> handle) {}
	
		// Methods
		public override void HandleMessage(IMessage msg) {}
	}

	public class NetBus : ExplicitSingleton<NetBus> // TypeDefIndex: 57141
	{
		// Fields
		private readonly Dictionary<int, NetResponseHandler> m_msgHandlers; // 0x10
		private readonly Dictionary<int, List<HandlerEntry>> m_msgWithSeqNumHandlers; // 0x18
		private readonly Dictionary<int, MessageHandleWrapper> m_msgHdlWrappers; // 0x20
		private HGNetSession m_netSession; // 0x28
		private static List<NetResponseHandler> s_handlersToCall; // 0x00
		private readonly UIBusSender _uiSender_k__BackingField; // 0x30
		private readonly TeleportMaskSender _teleportMaskSender_k__BackingField; // 0x38
		private readonly DisposableBusSender _defaultSender_k__BackingField; // 0x40
		private readonly Special2BusSender _s2Sender_k__BackingField; // 0x48
		private readonly InteractiveBusSender _interactiveSender_k__BackingField; // 0x50
		private readonly FrequencyControlBusSender _frequencyControlSender_k__BackingField; // 0x58
	
		// Properties
		public UIBusSender uiSender { get; } // 0x000000018B3CBF90-0x000000018B3CC0BC 
		public TeleportMaskSender teleportMaskSender { get; } // 0x000000018B3CBD28-0x000000018B3CBE5C 
		public DisposableBusSender defaultSender { get; } // 0x00000001843C1B70-0x00000001843C1E20 
		public Special2BusSender s2Sender { get; } // 0x0000000185F3F370-0x0000000185F3F400 
		public InteractiveBusSender interactiveSender { get; } // 0x0000000185492010-0x0000000185492020 
		public FrequencyControlBusSender frequencyControlSender { get; } // 0x00000001813B31B0-0x00000001813B31C0 
		public int currentSessionID { get => default; } // 0x00000001813B4840-0x00000001813B4850 
	
		// Nested types
		private class HandlerEntry // TypeDefIndex: 57138
		{
			// Fields
			public NetResponseHandler handler; // 0x10
	
			// Constructors
			public HandlerEntry() {} // 0x00000001813B51D0-0x00000001813B51E0
		}
	
		public class ResultHandler : IDisposable // TypeDefIndex: 57139
		{
			// Fields
			private bool m_ignoreSeq; // 0x10
			private ListDict<SCMessageID, object> m_responseTokens; // 0x18
			private ListDict<SCMessageID, NetResponseHandler> m_responseHandlers; // 0x20
			private bool _isDisposed_k__BackingField; // 0x28
			private ulong _cachedSeqNum_k__BackingField; // 0x30
			private int _sessionID_k__BackingField; // 0x38
	
			// Properties
			public bool isDisposed { get; private set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x00000001813FF010-0x00000001813FF020
			internal ulong cachedSeqNum { get; set; } // 0x00000001813ECF20-0x00000001813ECF30 0x0000000181460F60-0x0000000181460F70
			public int sessionID { get; internal set; } // 0x00000001813F1630-0x00000001813F1640 0x000000018B3CC0BC-0x000000018B3CC158
	
			// Constructors
			public ResultHandler() {} // 0x000000018B3CBCA4-0x000000018B3CBD28
	
			// Methods
			public void SetIgnoreSeq(bool ignoreSeq) {} // 0x00000001852F5960-0x00000001852F5BE0
			public ResultHandler OnResponse(SCMessageID msgId, NetResponseHandler handler) => default; // 0x000000018B3CBC5C-0x000000018B3CBCA4
			public void Dispose() {} // 0x0000000184CBA000-0x0000000184CBA040
			private bool _CheckSessionIDValid() => default; // 0x0000000184262330-0x0000000184262390
			private void _HandleMessage(in NetResponse msg) {} // 0x00000001843DF6B0-0x00000001843DF790
		}
	
		public abstract class Sender // TypeDefIndex: 57140
		{
			// Constructors
			protected Sender() {} // 0x000000018B3CBE5C-0x000000018B3CBF90
	
			// Methods
			public abstract ResultHandler Send(IMessage msg); // 0x000000018B3CB8F4-0x000000018B3CB96C
			public abstract void OnNetShutDown(); // 0x000000018B3CB96C-0x000000018B3CBC5C
			protected ResultHandler DoSend(IMessage message) => default; // 0x00000001842622F0-0x0000000184262330
			protected void DoListen(SCMessageID msgId, NetResponseHandler handler) {} // 0x0000000184CB9C60-0x0000000184CB9D00
			protected void DoUnListen(SCMessageID msgId, NetResponseHandler handler) {} // 0x0000000184262230-0x00000001842622F0
		}
	
		// Constructors
		public NetBus() {} // 0x00000001813B51D0-0x00000001813B51E0
		static NetBus() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsBusBusy() => default; // 0x00000001813B51E0-0x00000001813B51F0
		public void Setup(HGNetSession session) {} // 0x00000001813E5E30-0x00000001813E5E40
		public void Send(IMessage msg) {} // 0x00000001813E6F50-0x00000001813E6F60
		public void RegisterMessageHandler(int msgId, MessageHandleWrapper handler) {} // 0x000000018B3CEB80-0x000000018B3CEBD4
		public void UnRegisterMessageHandler(int msgId) {} // 0x00000001843C17F0-0x00000001843C1B70
		public void HandleMessageTime(NetResponse response) {} // 0x00000001843C0E50-0x00000001843C17F0
		public void HandleMessage(NetResponse response) {} // 0x0000000183E36860-0x0000000183E374D0
		private bool _ValidateSession() => default; // 0x00000001843C1E20-0x00000001843C2EF0
		public void OnNetClientShutDown() {} // 0x0000000185492010-0x0000000185492020
		private ResultHandler _SendWithResult(IMessage msg) => default;
		private void _Listen(int msgId, NetResponseHandler handler) {}
		private void _UnListen(int msgId, NetResponseHandler handler) {} // 0x00000001842621A0-0x0000000184262230
		private object _ListenWithSeqNum(int msgId, NetResponseHandler callback) => default; // 0x000000018B3CEBD4-0x000000018B3CEC74
		private void _UnListenWithSeqNum(int msgId, object token) {} // 0x000000018B3CEC74-0x000000018B3CED14
	}

	public class Special2BusSender : DisposableBusSender, INetBusResponseListener // TypeDefIndex: 57142
	{
		// Fields
		public Dictionary<ulong, double> sendedMsgWithTime; // 0x20
		public double minSendTime; // 0x28
		private float m_maxWaitTime; // 0x30
	
		// Properties
		public virtual bool isBusBusy { get => default; } // 0x00000001841CDBB0-0x00000001841CDBE0 
	
		// Constructors
		public Special2BusSender() {} // 0x00000001852F5DB0-0x00000001852F5E50
	
		// Methods
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x0000000185AE6A00-0x0000000185AE70D0
		public void UpdateStartBlockTime() {} // 0x000000018B3CEEA0-0x000000018B3CEFD8
		public override void OnNetShutDown() {} // 0x00000001843C0710-0x00000001843C0750
		public override void Dispose() {} // 0x000000018B3CED94-0x000000018B3CEDEC
		private void _ClearSendTime() {} // 0x00000001843C06A0-0x00000001843C0710
		public void UpdateMsgTime(NetResponse resp) {} // 0x000000018B3CEDF4-0x000000018B3CEEA0
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0) => default; // 0x000000018B3CA434-0x000000018B3CA43C
		public void __iFixBaseProxy_OnNetShutDown() {} // 0x000000018B3CEDEC-0x000000018B3CEDF4
		public void __iFixBaseProxy_Dispose() {} // 0x000000018B3CA42C-0x000000018B3CA434
	}

	public class InteractiveBusSender : Special2BusSender // TypeDefIndex: 57143
	{
		// Fields
		private float m_maxWaitTime; // 0x38
	
		// Properties
		public override bool isBusBusy { get => default; } // 0x00000001841CDB80-0x00000001841CDBB0 
	
		// Constructors
		public InteractiveBusSender() {} // 0x0000000186473AF4-0x0000000186473B04
	}

	public class DisposableBusSender : NetBus.Sender, IDisposable // TypeDefIndex: 57144
	{
		// Fields
		private readonly HashSet<NetBus.ResultHandler> m_resultHandlers; // 0x10
		private bool _isDisposed_k__BackingField; // 0x18
	
		// Properties
		public bool isDisposed { get; private set; } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
	
		// Constructors
		public DisposableBusSender() {} // 0x00000001852F5E50-0x00000001852F5ED0
	
		// Methods
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x0000000184262100-0x00000001842621A0
		public override void OnNetShutDown() {} // 0x00000001843C0C70-0x00000001843C0CB0
		public virtual void Dispose() {} // 0x000000018B3C98B0-0x000000018B3C9904
		private void _Clear() {} // 0x00000001843C0CB0-0x00000001843C0E50
	}

	public class NetworkMaskConfigHolder // TypeDefIndex: 57145
	{
		// Fields
		public Dictionary<CSMessageID, SCMessageID> msgs; // 0x10
	
		// Constructors
		public NetworkMaskConfigHolder() {} // 0x00000001852F5CB0-0x00000001852F5D30
	
		// Methods
		public void Init() {} // 0x00000001852F4E10-0x00000001852F5600
		public void Dispose() {} // 0x000000018B3CE2E4-0x000000018B3CE35C
	}

	public class UIBusSender : DisposableBusSender // TypeDefIndex: 57147
	{
		// Fields
		private NetworkMaskConfigHolder _config_k__BackingField; // 0x20
		private HashSet<int> m_maskKeys; // 0x28
	
		// Properties
		public NetworkMaskConfigHolder config { get; private set; } // 0x000000018B3CFCC8-0x000000018B3D0110 0x0000000184CBA040-0x0000000184CBA320
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 57146
		{
			// Fields
			public int key; // 0x10
			public UIBusSender __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal void _Send_b__0(in NetResponse resp) {} // 0x000000018646EE40-0x000000018646EE50
			internal void _Send_b__1(in NetResponse resp) {} // 0x00000001852F5BE0-0x00000001852F5CB0
			internal void _Send_b__2(in NetResponse resp) {} // 0x000000018B3CFAD4-0x000000018B3CFCC8
		}
	
		// Constructors
		public UIBusSender() {} // 0x000000018B3CA42C-0x000000018B3CA434
	
		// Methods
		public override void Dispose() {} // 0x000000018B3CA434-0x000000018B3CA43C
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x000000018B3CEDEC-0x000000018B3CEDF4
		public override void OnNetShutDown() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_Dispose() {} // 0x000000018B3CF504-0x000000018B3CF580
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0) => default; // 0x000000018B3CF5F0-0x000000018B3CF66C
		public void __iFixBaseProxy_OnNetShutDown() {} // 0x000000018B3CF74C-0x000000018B3CF7C8
	}

	public class TeleportMaskSender : DisposableBusSender // TypeDefIndex: 57149
	{
		// Fields
		private HashSet<int> m_maskKeys; // 0x20
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 57148
		{
			// Fields
			public int key; // 0x10
			public TeleportMaskSender __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018B3CF124-0x000000018B3CF2FC
	
			// Methods
			internal void _Send_b__0(in NetResponse resp) {} // 0x0000000183E374D0-0x0000000183E39040
			internal void _Send_b__1(in NetResponse resp) {} // 0x0000000184CBA320-0x0000000184CBA600
			internal void _Send_b__2(in NetResponse resp) {} // 0x00000001852F5D30-0x00000001852F5DB0
			internal void _Send_b__3(in NetResponse resp) {} // 0x000000018B3CA42C-0x000000018B3CA434
		}
	
		// Constructors
		public TeleportMaskSender() {} // 0x0000000184CB94D0-0x0000000184CB9550
	
		// Methods
		public override void Dispose() {} // 0x000000018B3CEDEC-0x000000018B3CEDF4
		public NetBus.ResultHandler Send(IMessage msg, float delay) => default; // 0x0000000185492010-0x0000000185492020
		public override void OnNetShutDown() {} // 0x000000018B3CF370-0x000000018B3CF3EC
		public void __iFixBaseProxy_Dispose() {} // 0x000000018B3CF3EC-0x000000018B3CF468
		public void __iFixBaseProxy_OnNetShutDown() {} // 0x000000018B3CF468-0x000000018B3CF4E4
	}

	public class FrequencyControlBusSender : DisposableBusSender // TypeDefIndex: 57151
	{
		// Fields
		private readonly Dictionary<CSMessageID, Queue<double>> m_lastSendTime; // 0x20
		private List<IMessage> m_waitingSendMsgs; // 0x28
		private List<Action<int>> m_onError; // 0x30
		private TickFunction m_loopId; // 0x38
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 57150
		{
			// Fields
			public Action<int> onError; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x00000001852F7160-0x00000001852F87B0
	
			// Methods
			internal void _Send_b__0(in NetResponse errorMsg) {} // 0x0000000183E359A0-0x0000000183E36860
			internal void _Send_b__1(in NetResponse errorMsg) {} // 0x000000018B3C9A90-0x000000018B3C9B00
			internal void _Send_b__2(in NetResponse errorMsg) {} // 0x000000018B3C9B00-0x000000018B3CA42C
		}
	
		// Constructors
		public FrequencyControlBusSender() {} // 0x000000018B3C99B8-0x000000018B3C9A90
	
		// Methods
		private void _TrySendWaitingMsg(float deltaTime) {} // 0x000000018B3CA434-0x000000018B3CA43C
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x000000018B3CA42C-0x000000018B3CA434
		public NetBus.ResultHandler Send(IMessage msg, bool needAddToWaitingList, Action<int> onError = null, Action onWait = null) => default; // 0x0000000185492010-0x0000000185492020
		public override void Dispose() {} // 0x000000018B3CF580-0x000000018B3CF5F0
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0) => default; // 0x000000018B3CF66C-0x000000018B3CF6DC
		public void __iFixBaseProxy_Dispose() {} // 0x000000018B3CF6DC-0x000000018B3CF74C
	}

	[Serializable]
	public class ServerDesc // TypeDefIndex: 57152
	{
		// Fields
		public string name; // 0x10
		public string addr; // 0x18
		public int port; // 0x20
	
		// Constructors
		public ServerDesc() {} // 0x00000001852BCEC0-0x00000001852BCF20
	}

	[Serializable]
	public class ServerList // TypeDefIndex: 57153
	{
		// Fields
		public List<ServerDesc> servers; // 0x10
	
		// Constructors
		public ServerList() {} // 0x0000000185F584F0-0x0000000185F58570
	}

	public class ServerConfig // TypeDefIndex: 57154
	{
		// Fields
		public string serverName; // 0x10
		public string uid; // 0x18
		public bool checkDev; // 0x20
	
		// Constructors
		public ServerConfig() {} // 0x0000000185F804C0-0x0000000185F80520
	
		// Methods
		public bool IsSame(ServerConfig other) => default; // 0x000000018B3CED14-0x000000018B3CED94
	}

	public class HostData // TypeDefIndex: 57155
	{
		// Fields
		public string host; // 0x10
		public int port; // 0x18
		public double delay; // 0x20
	
		// Constructors
		public HostData() {} // 0x000000018504A9C0-0x000000018504AA10
	}

	public class NetConfig // TypeDefIndex: 57156
	{
		// Fields
		public List<HostData> hosts; // 0x10
	
		// Constructors
		public NetConfig() {} // Dummy constructor
		public NetConfig(List<HostData> hosts) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public static class NetConsts // TypeDefIndex: 57157
	{
		// Fields
		public static readonly string NETMASK_CONFIG_PATH; // 0x00
		public static readonly string NETMASK_PREFAB_PATH; // 0x08
	
		// Constructors
		static NetConsts() {} // 0x0000000185F3A730-0x0000000185F3A7D0
	}

	public interface INetworkSystem : ILuaCallCSharp // TypeDefIndex: 57158
	{
		// Methods
		void OnReConnect();
		void SendMsg(IMessage msg, Action<int> onError);
	}

	public static class NetUtil // TypeDefIndex: 57161
	{
		// Fields
		private static bool s_isRegistedAllMessages; // 0x00
		public static readonly int MAX_RECEIVE_PACK_BODY_SIZE; // 0x04
		public static readonly int MAX_MERGE_PACK_BODY_SIZE; // 0x08
		public static readonly int MAX_SEND_PACK_BODY_SIZE; // 0x0C
		private static Dictionary<int, System.Type> s_sc_id2MessageType; // 0x10
		private static Dictionary<System.Type, int> s_sc_messageType2Id; // 0x18
		private static Dictionary<System.Type, int> s_cs_messageType2Id; // 0x20
		private static byte[] s_decompressedBuffer; // 0x28
	
		// Nested types
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 57159
		{
			// Fields
			public object target; // 0x10
	
			// Constructors
			public __c__DisplayClass18_0() {} // 0x0000000184A8BF30-0x0000000184A8C0C0
	
			// Methods
			internal void _AutoRegisterMessageHandlers_b__0(System.Type msgType, MethodInfo methodInfo) {} // 0x0000000184A8BA10-0x0000000184A8BB40
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 57160
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<System.Type, MethodInfo> __9__19_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001843DF790-0x00000001843DF840
			public __c() {} // 0x000000018B3CC318-0x000000018B3CC3C8
	
			// Methods
			internal void _AutoUnRegisterMessageHandlers_b__19_0(System.Type msgType, MethodInfo methodInfo) {} // 0x00000001843D0E80-0x00000001843D0F30
		}
	
		// Constructors
		static NetUtil() {} // 0x000000018B3CF2FC-0x000000018B3CF370
	
		// Methods
		public static void RegisterSCMessage(int msgId, System.Type msgType) {}
		public static void RegisterCSMessage(int msgId, System.Type msgType) {} // 0x0000000184A8BB40-0x0000000184A8BF30
		public static int GetSCMsgIdByType(System.Type msgType) => default; // 0x0000000184904D40-0x0000000184905F10
		public static System.Type GetSCMsgTypeById(int msgId) => default; // 0x00000001843D0350-0x00000001843D0540
		public static int GetCSMsgIdByType(System.Type msgType) => default; // 0x000000018B3CC3C8-0x000000018B3CC5B8
		private static void _GenMessageName2ValuePair<T>(Dictionary<string, int> dic)
			where T : Enum {} // 0x0000000184B04E40-0x0000000184B04F40
		public static void FastRegisterMessage() {} // 0x000000018B3CC1D8-0x000000018B3CC318
		public static bool GetNetMessageFromDataBytes(Span<byte> headBytes, byte[] bodyBuffer, int offset, int bodyLen, byte[] packedbuffer, out NetResponse response) {
			response = default;
			return default;
		} // 0x0000000184B04F40-0x0000000184B05080
		public static int SerializeHeadMessage(IMessage msg, ulong upSeqid, int bodyLen, int crc32, byte[] buffer, int offset = 0 /* Metadata: 0x0207D5BD */) => default; // 0x0000000185801430-0x0000000185801620
		public static int SerializeBodyMessage(IMessage msg, byte[] buffer, out int crc32, int offset = 0 /* Metadata: 0x0207D5BE */) {
			crc32 = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public static void AutoRegisterMessageHandlers(object target) {} // 0x00000001843DF990-0x00000001843DFC40
		public static void AutoUnRegisterMessageHandlers(object target) {} // 0x000000018B3CF7C8-0x000000018B3CF82C
		private static void _ForeachMessageHandlers(object target, Action<System.Type, MethodInfo> doFunc) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class NetworkFrequencyConfig // TypeDefIndex: 57163
	{
		// Fields
		public static SerializeFieldDictionary<int, NetworkFrequency> msgs; // 0x00
	
		// Nested types
		public class NetworkFrequency // TypeDefIndex: 57162
		{
			// Fields
			public System.Type type; // 0x10
			public float second; // 0x18
			public int maxCount; // 0x1C
	
			// Constructors
			public NetworkFrequency() {} // 0x000000018B3CC5B8-0x000000018B3CE2E4
		}
	
		// Constructors
		static NetworkFrequencyConfig() {} // 0x0000000185492010-0x0000000185492020
	}

	public class NetworkMask : Singleton<NetworkMask> // TypeDefIndex: 57165
	{
		// Fields
		private TickFunction m_preTickFunction; // 0x10
		private int m_nextKey; // 0x18
		public GameObject maskObj; // 0x20
		public GameObject decoObj; // 0x28
		private FAssetProxyHandle m_handle; // 0x30
		private Action<bool> m_onNetMaskChanged; // 0x48
		private bool _showingMask_k__BackingField; // 0x50
		private bool _showingDeco_k__BackingField; // 0x51
		private bool m_isNetReconnecting; // 0x52
		private const string DECO_NAME = "Deco"; // Metadata: 0x0207D5CB
		private List<MaskInfo> m_masks; // 0x58
	
		// Properties
		public bool showingMask { get; private set; } // 0x00000001813AF350-0x00000001813AF360 0x000000018596F4A0-0x000000018596F540
		public bool showingDeco { get; private set; } // 0x000000018596F540-0x000000018596F880 0x000000018B3CE41C-0x000000018B3CE4B4
	
		// Nested types
		public class MaskInfo // TypeDefIndex: 57164
		{
			// Fields
			public int key; // 0x10
			public string name; // 0x18
			public float startTime; // 0x20
			public float delayTime; // 0x24
			public float timeoutTime; // 0x28
	
			// Properties
			public float endTime { get => default; } // 0x00000001813ECBE0-0x00000001813ECBF0 
			public float showDecoTime { get => default; } // 0x00000001813EE9A0-0x00000001813EE9B0 
	
			// Constructors
			public MaskInfo() {} // 0x00000001813AF340-0x00000001813AF350
		}
	
		// Constructors
		private NetworkMask() {} // 0x000000018B3CE4B4-0x000000018B3CE5C4
	
		// Methods
		protected void OnInit() {} // 0x000000018B3CE6DC-0x000000018B3CE9B4
		protected void OnUnInit() {} // 0x000000018596F880-0x000000018596F960
		public void Release() {} // 0x000000018B3CE678-0x000000018B3CE6DC
		private void _OnSwitchLanguage() {} // 0x0000000184CB9200-0x0000000184CB92D0
		private void _CreateTickFunction() {} // 0x0000000184CB9100-0x0000000184CB9130
		private void _ClearTickFunction() {} // 0x000000018B3CE35C-0x000000018B3CE41C
		public void PreTick(float deltaTime) {} // 0x0000000184CB9000-0x0000000184CB9100
		private int _GetKey() => default; // 0x0000000184CB9130-0x0000000184CB9200
		public int AddMask(CSMessageID msgId, float timeoutTime = 10f /* Metadata: 0x0207D5BF */) => default; // 0x0000000185FD2040-0x0000000185FD2050
		public int AddMask(string name, float timeoutTime = 10f /* Metadata: 0x0207D5C3 */, float delayTime = 0.5f /* Metadata: 0x0207D5C7 */) => default; // 0x0000000184CB92D0-0x0000000184CB94D0
		public void RemoveMask(int key) {} // 0x0000000184CB9D00-0x0000000184CB9D70
		public void SetIsNetReconnecting(bool isReconnecting) {} // 0x000000018B3CE5C4-0x000000018B3CE678
		private void _UpdateMaskState() {} // 0x0000000185FD2020-0x0000000185FD2030
		public void ListenOnNetMaskChanged(Action<bool> action) {} // 0x0000000185FD2030-0x0000000185FD2040
		public void UnListenOnNetMaskChanged(Action<bool> action) {} // 0x0000000185FD2010-0x0000000185FD2020
	}

	public class NetworkMaskConfig : ScriptableObject // TypeDefIndex: 57167
	{
		// Fields
		public SerializeFieldDictionary<CSMessageID, SCMessageID> msgs; // 0x18
		public List<Config> configs; // 0x20
	
		// Nested types
		[Serializable]
		public class Config // TypeDefIndex: 57166
		{
			// Fields
			public string key; // 0x10
			public SerializeFieldDictionaryPaired<CSMessageID, SCMessageID> messages; // 0x18
	
			// Constructors
			public Config() {} // 0x0000000185ECA150-0x0000000185ECA220
		}
	
		// Constructors
		public NetworkMaskConfig() {} // 0x0000000185EF8810-0x0000000185EF8890
	}

	public static class NetworkUrls // TypeDefIndex: 57169
	{
		// Fields
		public const string URL_GET_SPLIT = "/"; // Metadata: 0x0207D5D0
	
		// Nested types
		private enum EUrlType // TypeDefIndex: 57168
		{
			ServerList = 0,
			GameLicense = 1,
			AgeTips = 2,
			GateBulletin = 3,
			GameBulletin = 4,
			Launcher = 5,
			Gov = 6
		}
	
		// Methods
		public static string RemoteConfigUrl() => default; // 0x00000001855EDBC0-0x00000001855EDC20
		public static string ResourceRootUrlDev(string version) => default; // 0x000000018B3CEADC-0x000000018B3CEB80
		public static string ServerListUrl() => default; // 0x00000001855ED890-0x00000001855ED8C0
		public static string AgeTipsUrl() => default; // 0x000000018B3CE9B4-0x000000018B3CEA48
		public static string GovUrl() => default; // 0x000000018B3CEA48-0x000000018B3CEADC
		public static string LauncherUrl() => default; // 0x000000018425F7F0-0x000000018425F870
		private static string _SelectUrl(string urlInConfig, EUrlType urlType) => default; // 0x000000018425F870-0x000000018425F900
		private static string _GetUrlFromLocal(EUrlType type) => default; // 0x00000001855ED8C0-0x00000001855ED970
	}

	public class TcpIO : INetIO // TypeDefIndex: 57170
	{
		// Fields
		private HGTcpClient m_tcpClient; // 0x10
		protected byte[] m_recvBuffer; // 0x18
		protected byte[] m_sendHeadBuffer; // 0x20
		protected byte[] m_sendBuffer; // 0x28
		protected int m_recvBufferOffset; // 0x30
		private XXE1 m_encryptor; // 0x38
		private XXE1 m_decryptor; // 0x40
		protected bool m_isAuthed; // 0x48
		private bool m_bIsTestDropSC; // 0x49
		private bool m_bIsTestDropCS; // 0x4A
		private bool m_bIsTestReconnectFailed; // 0x4B
		public const int SEND_HEAD_BUFFER_LENGTH = 256; // Metadata: 0x0207D5D9
		public static int s_MAX_SEND_SIZE; // 0x00
	
		// Constructors
		public TcpIO() {} // 0x0000000185492010-0x0000000185492020
		static TcpIO() {} // 0x0000000185FA3EA0-0x0000000185FA3EE0
	
		// Methods
		public void Connect(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize) {} // 0x0000000183FBC860-0x0000000183FBCA20
		public System.Threading.Tasks.Task ConnectAsync(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize) => default; // 0x0000000183FBBE60-0x0000000183FBC070
		public bool IsAuthed() => default; // 0x00000001843C87A0-0x00000001843C8860
		public void MarkAuthed() {} // 0x00000001843C32A0-0x00000001843C32D0
		public void EnableCryptStream(byte[] key, byte[] iv) {} // 0x0000000185B96A40-0x0000000185B96C80
		public EndPoint GetEndPoint() => default; // 0x000000018B3CEFD8-0x000000018B3CF048
		public void Close() {} // 0x0000000184A933A0-0x0000000184A93860
		public void TestCloseNetIO(bool bIsTestReconnectFailed) {} // 0x000000018B3CF048-0x000000018B3CF0B4
		public void TestDropNetIO(bool bIsTestDropSC, bool bIsTestDropCS) {} // 0x000000018B3CF0B4-0x000000018B3CF124
		public bool IsConnected() => default; // 0x00000001843C77F0-0x00000001843C7A00
		public void WriteData(byte[] data, int offset, int len) {} // 0x00000001843CDDC0-0x00000001843CE060
		public void WriteCryptoData(byte[] data, int offset, int len) {} // 0x00000001843D0980-0x00000001843D0A20
		public byte[] GetSendHeadBuffer() => default; // 0x00000001843D08D0-0x00000001843D0980
		public byte[] GetSendBuffer() => default; // 0x00000001843CEFF0-0x00000001843CF020
		public byte[] GetReceiveBuffer() => default; // 0x00000001843C85E0-0x00000001843C87A0
		public void ClearReceiveBufferOffset() {} // 0x00000001851120E0-0x0000000185112110
		public int GetReceiveBufferOffset() => default; // 0x00000001843C7A00-0x00000001843C7AC0
		public void SkipReceiveBufferOffset(int len) {} // 0x00000001850CBFC0-0x00000001850CC000
		public int ReadData(byte[] buffer, int offset, int len) => default; // 0x00000001843CE190-0x00000001843CE2F0
		public int ReadCryptoData(byte[] buffer, int offset, int len) => default; // 0x00000001843CE060-0x00000001843CE190
		public int Available() => default; // 0x00000001843C7D60-0x00000001843C7F00
		public void Dispose() {} // 0x0000000184A932F0-0x0000000184A93330
		~TcpIO() {} // 0x0000000184A93160-0x0000000184A932F0
	}

	public static class HttpSender // TypeDefIndex: 57189
	{
		// Fields
		public const string CONTENT_TYPE_JSON = "application/json"; // Metadata: 0x0207D5DB
		public const string CONTENT_ENCODING_GZIP = "gzip"; // Metadata: 0x0207D5EC
		public const int ERROR_CODE_TIMEOUT = 10000; // Metadata: 0x0207D5F1
		public const int ERROR_CODE_DNS_FAILED = 11000; // Metadata: 0x0207D5F5
		public const int ERROR_CODE_DESERIALIZE = 20000; // Metadata: 0x0207D5F9
		public const float TIMEOUT_DEFAULT = 20f; // Metadata: 0x0207D5FD
		private const int OPT_GET = 1; // Metadata: 0x0207D601
		private const int OPT_POST = 2; // Metadata: 0x0207D602
	
		// Nested types
		public enum ErrorType // TypeDefIndex: 57171
		{
			NONE = 0,
			TIMEOUT = 1,
			DNS_FAILED = 2,
			CANCELED = 3,
			INTERNAL = 4
		}
	
		public class Cancellation // TypeDefIndex: 57172
		{
			// Fields
			private bool m_isCancelled; // 0x10
			private Action OnCancelInvoked; // 0x18
	
			// Events
			public event Action OnCancelInvoked;
	
			// Constructors
			public Cancellation() {}
	
			// Methods
			public void Cancel() {} // 0x00000001855ED4F0-0x00000001855ED5D0
			public bool IsCanceled() => default; // 0x000000018B3CB4D8-0x000000018B3CB5C0
		}
	
		public struct FGetOptions // TypeDefIndex: 57173
		{
			// Fields
			public static readonly FGetOptions DEFAULT; // 0x00
			public Dictionary<string, string> headers; // 0x00
			public string contentType; // 0x08
			public bool headOnly; // 0x10
			public Cancellation cancellation; // 0x18
	
			// Constructors
			static FGetOptions() {
				DEFAULT = default;
			} // 0x0000000185BC5130-0x0000000185BC5200
		}
	
		public struct FPostOptions // TypeDefIndex: 57174
		{
			// Fields
			public static readonly FPostOptions DEFAULT; // 0x00
			public Dictionary<string, string> headers; // 0x00
			public string textBody; // 0x08
			public string contentType; // 0x10
			public Cancellation cancellation; // 0x18
	
			// Constructors
			static FPostOptions() {
				DEFAULT = default;
			} // 0x000000018B3CB3DC-0x000000018B3CB4D8
		}
	
		private struct FSendFunc // TypeDefIndex: 57175
		{
			// Fields
			public string url; // 0x00
			public int opt; // 0x08
			public FGetOptions optionsGET; // 0x10
			public FPostOptions optionsPOST; // 0x30
			public bool editorOnly; // 0x50
	
			// Methods
			public UnityWebRequest Invoke() => default; // 0x000000018B3CB240-0x000000018B3CB2E0
			public Cancellation GetCancellation() => default; // 0x000000018B3CB2E0-0x000000018B3CB3DC
			public string GetOptMethod() => default;
		}
	
		public class Result // TypeDefIndex: 57176
		{
			// Fields
			public int respCode; // 0x10
			public ErrorType errorType; // 0x14
			public bool isError; // 0x18
			public Exception exception; // 0x20
			public string respText; // 0x28
			public byte[] respData; // 0x30
			public string respError; // 0x38
			public bool isServiceDone; // 0x40
	
			// Constructors
			public Result() {}
		}
	
		public class TypedResult : Result // TypeDefIndex: 57177
		{
			// Fields
			private System.Type _respType_k__BackingField; // 0x48
			public object respObject; // 0x50
			public bool isDeserializeFailed; // 0x58
	
			// Properties
			public System.Type respType { get; private set; } // 0x00000001855ED970-0x00000001855ED9E0 0x000000018571FDE0-0x000000018571FEC0
	
			// Constructors
			public TypedResult() {} // Dummy constructor
			public TypedResult(System.Type respType) {} // 0x000000018587AB50-0x000000018587AC40
		}
	
		public class Result<TResp> : TypedResult // TypeDefIndex: 57178
			where TResp : class
		{
			// Constructors
			public Result() {} // 0x000000018B3CB72C-0x000000018B3CB8F4
	
			// Methods
			public TResp GetRespObject() => default;
		}
	
		private sealed class _YieldSendGet_d__16 : IEnumerator<object> // TypeDefIndex: 57179
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string url; // 0x20
			public FGetOptions options; // 0x28
			public Misc.ObjectRef resultRef; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184F38C50-0x0000000184F39350 
			object IEnumerator.Current { get => default; } // 0x000000018571FED0-0x000000018571FF80 
	
			// Constructors
			public _YieldSendGet_d__16() {} // Dummy constructor
			public _YieldSendGet_d__16(int __1__state) {} // 0x000000018571FAA0-0x000000018571FC10
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018571F9E0-0x000000018571FA30
			private bool MoveNext() => default; // 0x0000000184F38520-0x0000000184F38B10
			void IEnumerator.Reset() {} // 0x0000000184F38330-0x0000000184F38440
		}
	
		private sealed class _YieldSendGet_d__17<TResp> : IEnumerator<object> // TypeDefIndex: 57180
			where TResp : class
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string url;
			public FGetOptions options;
			public Misc.ObjectRef resultRef;
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B3C981C-0x000000018B3C98B0 
			object IEnumerator.Current { get => default; } // 0x000000018B3C9734-0x000000018B3C9788 
	
			// Constructors
			public _YieldSendGet_d__17() {} // Dummy constructor
			public _YieldSendGet_d__17(int __1__state) {} // 0x000000018B3CB5C0-0x000000018B3CB658
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B3CB658-0x000000018B3CB72C
			private bool MoveNext() => default; // 0x000000018B3C9788-0x000000018B3C981C
			void IEnumerator.Reset() {} // 0x000000018B3C96D4-0x000000018B3C9734
		}
	
		private sealed class _YieldSendGet_d__18 : IEnumerator<object> // TypeDefIndex: 57181
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FGetOptions options; // 0x20
			public string url; // 0x40
			public Misc.ObjectRef resultRef; // 0x48
			public System.Type respType; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184F38230-0x0000000184F382B0 
			object IEnumerator.Current { get => default; } // 0x000000018B3C9904-0x000000018B3C99B8 
	
			// Constructors
			public _YieldSendGet_d__18() {} // Dummy constructor
			public _YieldSendGet_d__18(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000184F381E0-0x0000000184F38230
		}
	
		private sealed class _YieldSendPost_d__19 : IEnumerator<object> // TypeDefIndex: 57182
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string url; // 0x20
			public FPostOptions options; // 0x28
			public Misc.ObjectRef resultRef; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018571FEC0-0x000000018571FED0 
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _YieldSendPost_d__19() {} // Dummy constructor
			public _YieldSendPost_d__19(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001813ECF20-0x00000001813ECF30
			private bool MoveNext() => default; // 0x000000018571FEC0-0x000000018571FED0
			void IEnumerator.Reset() {}
		}
	
		private sealed class _YieldSendPost_d__20<TResp> : IEnumerator<object> // TypeDefIndex: 57183
			where TResp : class
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string url;
			public FPostOptions options;
			public Misc.ObjectRef resultRef;
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public _YieldSendPost_d__20() {} // Dummy constructor
			public _YieldSendPost_d__20(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x00000001855ED470-0x00000001855ED4F0
			void IEnumerator.Reset() {} // 0x000000018B3CF82C-0x000000018B3CF878
		}
	
		private sealed class _YieldSendPost_d__21 : IEnumerator<object> // TypeDefIndex: 57184
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FPostOptions options; // 0x20
			public string url; // 0x40
			public Misc.ObjectRef resultRef; // 0x48
			public System.Type respType; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _YieldSendPost_d__21() {} // Dummy constructor
			public _YieldSendPost_d__21(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		private sealed class __YieldSendHttpRequest_d__28 : IEnumerator<object> // TypeDefIndex: 57185
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FSendFunc sendFunc; // 0x20
			public Result result; // 0x78
			private Cancellation _cancelation_5__2; // 0x80
			private bool _isCanceled_5__3; // 0x88
			private UnityWebRequest _request_5__4; // 0x90
			private UnityWebRequestAsyncOperation _sendOpt_5__5; // 0x98
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B3CF878-0x000000018B3CF8C4 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public __YieldSendHttpRequest_d__28() {} // Dummy constructor
			public __YieldSendHttpRequest_d__28(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018587AA60-0x000000018587AB50
			private void __m__Finally1() {} // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __YieldSendHttpRequest_d__29 : IEnumerator<object> // TypeDefIndex: 57186
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Misc.ObjectRef resultRef; // 0x20
			public System.Type respType; // 0x28
			public FSendFunc sendFunc; // 0x30
			private Result _result_5__2; // 0x88
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B3CF92C-0x000000018B3CF978 
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public __YieldSendHttpRequest_d__29() {} // Dummy constructor
			public __YieldSendHttpRequest_d__29(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B3CF8C4-0x000000018B3CF92C
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 57187
		{
			// Fields
			public Result result; // 0x10
	
			// Constructors
			public __c__DisplayClass30_0() {}
	
			// Methods
			internal Result __WaitForSendHttpRequest_b__0() => default;
		}
	
		private sealed class __c__DisplayClass31_0<TResp> // TypeDefIndex: 57188
			where TResp : class
		{
			// Fields
			public Result<TResp> result;
	
			// Constructors
			public __c__DisplayClass31_0() {}
	
			// Methods
			internal Result<TResp> __WaitForSendHttpRequest_b__0() => default;
		}
	
		// Methods
		public static IEnumerator YieldSendGet(string url, FGetOptions options, Misc.ObjectRef resultRef) => default;
		public static IEnumerator YieldSendGet<TResp>(string url, FGetOptions options, Misc.ObjectRef resultRef)
			where TResp : class => default; // 0x0000000181378230-0x0000000181378240
		public static IEnumerator YieldSendGet(string url, FGetOptions options, System.Type respType, Misc.ObjectRef resultRef) => default; // 0x0000000185492010-0x0000000185492020
		public static IEnumerator YieldSendPost(string url, FPostOptions options, Misc.ObjectRef resultRef) => default; // 0x000000018587A970-0x000000018587AA60
		public static IEnumerator YieldSendPost<TResp>(string url, FPostOptions options, Misc.ObjectRef resultRef)
			where TResp : class => default; // 0x0000000181377E40-0x0000000181377E50
		public static IEnumerator YieldSendPost(string url, FPostOptions options, System.Type respType, Misc.ObjectRef resultRef) => default; // 0x000000018B3CF978-0x000000018B3CF9C4
		public static WaitForAsyncTask<Result> WaitForSendPost(string url, FPostOptions options) => default; // 0x0000000181377E40-0x0000000181377E50
		public static WaitForAsyncTask<Result> WaitForSendGet(string url) => default; // 0x0000000181378230-0x0000000181378240
		public static WaitForAsyncTask<Result> WaitForSendGet(string url, FGetOptions options) => default; // 0x000000018B3CFA10-0x000000018B3CFA88
		public static WaitForAsyncTask<Result<TResp>> WaitForSendPost<TResp>(string url, FPostOptions options)
			where TResp : class => default; // 0x0000000184F37950-0x0000000184F38170
		public static WaitForAsyncTask<Result<TResp>> WaitForSendGet<TResp>(string url, FGetOptions options)
			where TResp : class => default; // 0x0000000184F382B0-0x0000000184F38310
		public static int GetGeneralErrorCode(Result result, out bool hasError) {
			hasError = default;
			return default;
		} // 0x0000000181377E40-0x0000000181377E50
		private static IEnumerator _YieldSendHttpRequest(Result result, FSendFunc sendFunc) => default; // 0x000000018B3CF9C4-0x000000018B3CFA10
		private static IEnumerator _YieldSendHttpRequest(Misc.ObjectRef resultRef, FSendFunc sendFunc, System.Type respType) => default; // 0x0000000181377E40-0x0000000181377E50
		private static WaitForAsyncTask<Result> _WaitForSendHttpRequest(FSendFunc sendFunc) => default; // 0x0000000181378230-0x0000000181378240
		private static WaitForAsyncTask<Result<TResp>> _WaitForSendHttpRequest<TResp>(FSendFunc sendFunc)
			where TResp : class => default; // 0x0000000185492010-0x0000000185492020
		private static void _StartWebRequestTask(Result result, FSendFunc sendFunc) {} // 0x000000018571FC10-0x000000018571FDE0
		private static void _WaitForServiceDone(Result result) {} // 0x0000000181377E40-0x0000000181377E50
		private static UnityWebRequest _CreateWebRequestGET(string url, FGetOptions options) => default; // 0x000000018B3CFA88-0x000000018B3CFAD4
		private static UnityWebRequest _CreateWebRequestPOST(string url, FPostOptions options) => default; // 0x0000000181377E40-0x0000000181377E50
		private static void _SetHttpResult(Result result, UnityWebRequest request) {} // 0x0000000185492010-0x0000000185492020
		private static void _DeserializeTypedResult(TypedResult result) {} // 0x000000018B3CF4E4-0x000000018B3CF504
		private static void _DebugOnlyProfileResult(Result result, FSendFunc sendFunc) {}
		private static void _MarkResultAsException(Result result, Exception ex) {}
	}

	public class CircularBuffer<T> : IReadOnlyList<T> // TypeDefIndex: 57191
	{
		// Fields
		private readonly T[] m_buffer;
		private int m_end;
		private int m_count;
		private int m_start;
	
		// Properties
		public int Capacity { get => default; }
		public bool IsFull { get => default; }
		public bool IsEmpty { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		private sealed class _GetEnumerator_d__18 : IEnumerator<T> // TypeDefIndex: 57190
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public CircularBuffer<T> __4__this;
			private ArraySegment<T>[] __7__wrap1;
			private int __7__wrap2;
			private ArraySegment<T> _segment_5__4;
			private int _i_5__5;
	
			// Properties
			T IEnumerator<T>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__18() {} // Dummy constructor
			public _GetEnumerator_d__18(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public CircularBuffer() {} // Dummy constructor
		public CircularBuffer(int capacity) {}
		public CircularBuffer(int capacity, T[] items) {}
	
		// Methods
		public void Clear() {}
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public T Front() => default;
		public bool TryFront(out ref T result) {
			result = default;
			return default;
		}
		public T Back() => default;
		public bool TryBack(out ref T result) {
			result = default;
			return default;
		}
		public void PushBack(T item) {}
		public void PushFront(T item) {}
		public void PopBack() {}
		public void PopFront() {}
		public bool TryPopFront(out ref T result) {
			result = default;
			return default;
		}
		public bool TryPopBack(out ref T result) {
			result = default;
			return default;
		}
		public T[] ToArray() => default;
		private void _ThrowIfEmpty(string message = "Cannot access an empty buffer." /* Metadata: 0x0207D608 */) {}
		private void _Increment(ref int index) {}
		private void _Decrement(ref int index) {}
		private int _InternalIndex(int index) => default;
		private ArraySegment<T> _ArrayOne() => default;
		private ArraySegment<T> _ArrayTwo() => default;
	}

	public abstract class HGNetBaseSession // TypeDefIndex: 57200
	{
		// Fields
		private INetIO m_tcpIO; // 0x10
		public static int s_recvBuffLen; // 0x00
		public static int s_tcpSendTimeout; // 0x04
		public static int s_sessionThreadSleepTimeMS; // 0x08
		public static int s_sessionThreadPauseSleepTimeMS; // 0x0C
		public int m_maxReconnectTimeout; // 0x18
		public int m_maxReconnectTimes; // 0x1C
		public int sendNumLimit; // 0x20
		protected readonly ConcurrentQueue<NetResponse> m_recvQueue; // 0x28
		protected readonly ConcurrentQueue<NetRequest> m_sendQueue; // 0x30
		private const int MAX_RECYCLE_QUEUE_COUNT = 1000; // Metadata: 0x0207D627
		protected CircularBuffer<NetRequest> m_circularBuffer; // 0x38
		private long m_csSeqId; // 0x40
		protected long m_scSeqId; // 0x48
		protected System.Threading.Tasks.Task m_threadTask; // 0x50
		protected int m_threadTaskSignalID; // 0x58
		protected ELogChannel m_logChannel; // 0x5C
		protected bool m_isSyncFullDataEnd; // 0x5D
		protected IMessage m_lastLoginMsg; // 0x60
		private string m_lastConnectServerIp; // 0x68
		private int m_lastConnectServerPort; // 0x70
		protected int m_tryReconnectTimes; // 0x74
		protected bool m_isAutoReconnect; // 0x78
		protected long m_startReconnectTimestampMS; // 0x80
		protected int m_closeNetMsgID; // 0x88
		public static int INVALID_SESSION_ID; // 0x10
		protected static int s_sessionIDGenerator; // 0x14
		private int _sessionID_k__BackingField; // 0x8C
		protected HGNetSessionConnectYield m_lastAsyncConnectHandle; // 0x90
		protected EHGNetSessionState m_state; // 0x98
		private EHGNetSessionReconnectState m_reconnectState; // 0x99
		protected double m_startReconnectTimeMS; // 0xA0
		protected int m_closeErrorCode; // 0xA8
		public static bool s_applicationIsPaused; // 0x18
		private long m_clientLastReceiveMsgMilliTs; // 0xB0
		private long m_clientLastSendMsgMilliTs; // 0xB8
	
		// Properties
		public int sessionID { get; protected set; } // 0x0000000183FBC1F0-0x0000000183FBC300 0x0000000184A91510-0x0000000184A91550
		protected EHGNetSessionReconnectState reconnectState { get; set; } // 0x000000018B3CA7C0-0x000000018B3CA83C 0x0000000184A91900-0x0000000184A93130
		public bool isRunning { get; } // 0x0000000184263110-0x0000000184263190 
		public bool isConnecting { get; } // 0x00000001843C9630-0x00000001843C9730 
		public bool isRunningAndConnected { get; } // 0x00000001842630D0-0x0000000184263110 
		public bool isReconnecting { get; } // 0x00000001850129F0-0x0000000185012A30 
		public int closeErrorCode { get; } // 0x000000018B3CA770-0x000000018B3CA7C0 
		public bool isAutoReconnect { get; } // 0x0000000185012990-0x00000001850129C0 
		public int maxRecycleQueueCount { get; } // 0x0000000183FBB990-0x0000000183FBBAC0 
	
		// Nested types
		private sealed class __c__DisplayClass56_0 // TypeDefIndex: 57192
		{
			// Fields
			public HGNetBaseSession __4__this; // 0x10
			public INetIO tcpIO; // 0x18
	
			// Constructors
			public __c__DisplayClass56_0() {} // 0x000000018349D720-0x000000018349D730
	
			// Methods
			internal void _ConnectAsync_b__0(Task<System.Threading.Tasks.Task> task) {} // 0x00000001834A21B0-0x00000001834A21C0
		}
	
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 57193
		{
			// Fields
			public HGNetBaseSession __4__this; // 0x10
			public INetIO tcp; // 0x18
			public int nextid; // 0x20
	
			// Constructors
			public __c__DisplayClass69_0() {} // 0x0000000185FCECB0-0x0000000185FCECC0
	
			// Methods
			internal System.Threading.Tasks.Task _StartTCPMsgLoopThreadTask_b__0() => default; // 0x00000001843C32D0-0x00000001843C3390
		}
	
		private struct __SessionThread_d__71 : IAsyncStateMachine // TypeDefIndex: 57194
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HGNetBaseSession __4__this; // 0x20
			public INetIO tcp; // 0x28
			public int threadID; // 0x30
			private TaskAwaiter __u__1; // 0x38
	
			// Methods
			private void MoveNext() {} // 0x00000001840D6A50-0x00000001840D6AE0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B3CA83C-0x000000018B3CA848
		}
	
		private struct __ReconnectCheckerTick_d__80 : IAsyncStateMachine // TypeDefIndex: 57195
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HGNetBaseSession __4__this; // 0x20
			public INetIO tcpIO; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext() {} // 0x00000001840D6AE0-0x00000001840D9520
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x0000000184CBA860-0x0000000184CBA870
		}
	
		private sealed class __c__DisplayClass81_0 // TypeDefIndex: 57196
		{
			// Fields
			public INetIO tcpIO; // 0x10
			public string ip; // 0x18
			public int port; // 0x20
			public int sendTimeout; // 0x24
			public int receiveBufferLen; // 0x28
	
			// Constructors
			public __c__DisplayClass81_0() {} // 0x0000000185FB2CD0-0x0000000185FB2CE0
	
			// Methods
			internal void _TryConnectWithTimeout_b__0() {} // 0x0000000185FB0DA0-0x0000000185FB0DB0
		}
	
		private struct _TryConnectWithTimeout_d__81 : IAsyncStateMachine // TypeDefIndex: 57197
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			public INetIO tcpIO; // 0x20
			public string ip; // 0x28
			public int port; // 0x30
			public int sendTimeout; // 0x34
			public int receiveBufferLen; // 0x38
			public int timeoutMilliseconds; // 0x3C
			public HGNetBaseSession __4__this; // 0x40
			private System.Threading.Tasks.Task _connectTask_5__2; // 0x48
			private TaskAwaiter<System.Threading.Tasks.Task> __u__1; // 0x50
	
			// Methods
			private void MoveNext() {} // 0x0000000185FBBF90-0x0000000185FBBFA0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x0000000183FC0D70-0x0000000183FC0F20
		}
	
		private sealed class __c__DisplayClass82_0 // TypeDefIndex: 57198
		{
			// Fields
			public INetIO tcpIO; // 0x10
	
			// Constructors
			public __c__DisplayClass82_0() {} // 0x000000018B3CA43C-0x000000018B3CA770
	
			// Methods
			internal void _TryCloseTcpIOWithTimeout_b__0() {} // 0x0000000183FBB3C0-0x0000000183FBB830
		}
	
		private struct _TryCloseTcpIOWithTimeout_d__82 : IAsyncStateMachine // TypeDefIndex: 57199
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			public INetIO tcpIO; // 0x20
			public int timeoutMilliseconds; // 0x28
			public HGNetBaseSession __4__this; // 0x30
			private System.Threading.Tasks.Task _closeTask_5__2; // 0x38
			private TaskAwaiter<System.Threading.Tasks.Task> __u__1; // 0x40
	
			// Methods
			private void MoveNext() {} // 0x0000000184F677A0-0x0000000184F678F0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {}
		}
	
		// Constructors
		protected HGNetBaseSession() {} // 0x0000000183FBAC00-0x0000000183FBAF10
		static HGNetBaseSession() {} // 0x0000000185A17640-0x0000000185A176B0
	
		// Methods
		public virtual void Start() {} // 0x0000000184A91840-0x0000000184A918A0
		public virtual bool Connect(string serverIp, int serverPort, bool forceReconnect) => default; // 0x0000000185B3E930-0x0000000185B3EA60
		public virtual bool ConnectAsync(string serverIp, int serverPort, bool forceReconnect, out HGNetSessionConnectYield yieldHandle) {
			yieldHandle = default;
			return default;
		} // 0x00000001843C8860-0x00000001843C8D80
		public void OnConnectAsyncEnd(System.Threading.Tasks.Task completedTask, INetIO tcpIO) {} // 0x00000001843C48E0-0x00000001843C53A0
		protected abstract void OnConnectedSucceed(INetIO tcpIO);
		private void _DNSCheck(string serverIp) {}
		public virtual void Close(ENetCloseReason netCloseReason) {}
		protected void InternalClose(INetIO tcpIO, ENetCloseReason netCloseReason) {} // 0x00000001843C7380-0x00000001843C7520
		protected void InternalClose(INetIO tcpIO, int netCloseReason) {} // 0x0000000185750870-0x00000001857508A0
		protected void EnqueueSendMsg(NetRequest msg) {} // 0x0000000184A93130-0x0000000184A93160
		public int GetSendQueueMsgCount() => default; // 0x00000001843C55F0-0x00000001843C5890
		protected long IncrementCSSeqID() => default; // 0x0000000185091320-0x0000000185091490
		protected void SetCSSeqID(long id) {} // 0x0000000185091490-0x00000001850915F0
		protected long GetCSSeqID() => default;
		protected INetIO GetIO() => default;
		protected void StartTCPMsgLoopThreadTask() {}
		protected void CloseTCPMsgThreadTask() {}
		private System.Threading.Tasks.Task _SessionThread(INetIO tcp, int threadID) => default;
		private bool _SendAndCheckMessage(INetIO tcp, int threadID) => default;
		private bool _ReadAndCheckMessageInSessionThread(INetIO tcp, int threadID) => default;
		protected abstract bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp); // 0x00000001843C53A0-0x00000001843C54F0
		protected abstract void CheckAndDealRespMessages(INetIO netIO, ref NetResponse m); // 0x00000001843C8D80-0x00000001843C8FF0
		protected abstract void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m);
		protected void SessionCheckSignalAndSleep(int threadID) {}
		protected void OpenAutoReconnect() {}
		protected void RemoveAutoReconnect() {}
		private System.Threading.Tasks.Task _ReconnectCheckerTick(INetIO tcpIO) => default; // 0x0000000184F307D0-0x0000000184F30930
		protected Task<bool> TryConnectWithTimeout(INetIO tcpIO, string ip, int port, int sendTimeout, int receiveBufferLen, int timeoutMilliseconds) => default; // 0x0000000185F1E9A0-0x0000000185F1EA60
		protected Task<bool> TryCloseTcpIOWithTimeout(INetIO tcpIO, int timeoutMilliseconds) => default; // 0x0000000185492010-0x0000000185492020
		protected abstract void OnReconnectTimesOver(INetIO tcpIO); // 0x0000000184F67770-0x0000000184F677A0
		protected abstract bool NeedKeepConnect(); // 0x0000000185492010-0x0000000185492020
		protected abstract void DoReconnectLogin(INetIO netIO); // 0x0000000185B3E900-0x0000000185B3E930
		protected abstract void InitClientRSAKey(); // 0x00000001843C58F0-0x00000001843C6CA0
		protected abstract void ClearRSAKey(); // 0x00000001857B8CE0-0x00000001857B8D40
		public abstract void ClearRecvQueue(); // 0x000000018469E8D0-0x000000018469F980
		public abstract void ClearSendQueue(); // 0x00000001857B8D40-0x00000001857B8DA0
		protected void NetStatusChecker_Receive(INetIO netIO, long scSeqId, int receiveCount) {} // 0x0000000185492010-0x0000000185492020
		protected void NetStatusChecker_Sender(INetIO netIO, long csSeqId, int sendCount) {} // 0x0000000183FBC6B0-0x0000000183FBC780
		protected abstract void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs); // 0x0000000183FBAF10-0x0000000183FBB240
		protected abstract void ClearPingWDG(); // 0x0000000185A176B0-0x0000000185A17720
		protected abstract bool IsPingOut(); // 0x0000000185492010-0x0000000185492020
		protected abstract void PingSenderTick(INetIO netIO, long upSeqId); // 0x0000000184A93330-0x0000000184A933A0
	}

	public class HGNetSession : HGNetBaseSession // TypeDefIndex: 57201
	{
		// Fields
		private string m_uid; // 0xC0
		private string m_token; // 0xC8
		private int m_channel; // 0xD0
		public static int LOGIN_TIMEOUT; // 0x00
		public static int MAX_CLIENT_RESEND_NUM; // 0x04
		public static float PER_FRAME_RECEIVED_MESSAGES_TIME_30FPS; // 0x08
		public static float PER_FRAME_RECEIVED_MESSAGES_TIME; // 0x0C
		public static float MESSAGE_MAX_DELAY_TIME; // 0x10
		protected int m_messageDelayCount; // 0xD4
		protected long m_logCDTimestamp; // 0xD8
		private static bool s_HGNetSessionBurst; // 0x14
		private readonly ConcurrentQueue<NetRequest> m_frameSendQueue; // 0xE0
		private Queue<NetRequest> m_mergeQueueCache; // 0xE8
		private object m_frameSendQueueLocker; // 0xF0
		private byte[] m_frameSendPacketBuffer; // 0xF8
		private byte[] m_frameSendPacketHeadBuffer; // 0x100
		private byte[] m_frameSendPacketTempBuffer; // 0x108
		private byte[] m_frameSendCryptoBuffer; // 0x110
		private byte[] m_frameReceivePacketBuffer; // 0x118
		public static long s_maxframeSendPacketBuffer; // 0x18
		public static long s_maxPackedMessageNum; // 0x20
		protected readonly Queue<NetResponse> m_callbackQueue; // 0x120
		private HGNetSessionLoginYield m_currLoginHandle; // 0x128
		private const int SEND_PING_DELTA_TICK_TIME_MS = 2000; // Metadata: 0x0207D62B
		private static int s_pingWdgOutTimes; // 0x28
		private static int s_pingSyncFullEndBeforeTimes; // 0x2C
		private long m_needSendPingTimer; // 0x130
		private int m_pingWDG; // 0x138
		private long m_clientTsDelayms; // 0x140
		private int m_pingValue; // 0x148
		private bool m_isPingInProgress; // 0x14C
		private long m_isPingInProgressStartTime; // 0x150
		private static readonly string CLIENT_NET_PEM_PUBLIC_KEY_HEAD_FORMAT; // 0x30
		private static readonly string CLIENT_NET_RSA_PUBLIC_KEY; // 0x38
		private static readonly string CLIENT_NET_RSA_PRIVATE_KEY; // 0x40
		private static byte[] s_clientPublicKeyBytes; // 0x48
		private RSA m_rsaClientPrivateProvider; // 0x158
		private static readonly byte[] EMPTY_BYTES; // 0x50
		private static int s_CacheLogLength; // 0x58
		private StringBuilder m_sbCache; // 0x160
	
		// Constructors
		public HGNetSession() {} // 0x0000000184F30560-0x0000000184F307D0
		static HGNetSession() {} // 0x0000000185C2B770-0x0000000185C2B980
	
		// Methods
		public void SetAutoReconnectToken(string uid, string token, int channel) {} // 0x0000000184CB9BE0-0x0000000184CB9C60
		protected override void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs) {} // 0x0000000184E12FA0-0x0000000184E13090
		protected override void DoReconnectLogin(INetIO netIO) {} // 0x000000018B3D2988-0x000000018B3D306C
		public override void Start() {} // 0x0000000185C6D6B0-0x0000000185C6D820
		public void OnApplicationPause(bool pause) {} // 0x000000018B3D30BC-0x000000018B3D31A4
		public ulong SendMessage(IMessage msg) => default; // 0x0000000184262390-0x0000000184262700
		protected void PackMessageToSendQueue() {} // 0x000000018B3D3210-0x000000018B3D38C0
		private void _FlushMergeQueueToSendQueue() {} // 0x0000000183E39040-0x0000000183E39EB0
		public void UpdateInGameThread() {} // 0x000000018B3D392C-0x000000018B3D3990
		public void TailLateUpdateInGameThread() {} // 0x000000018B3D3914-0x000000018B3D392C
		private float _GetMessageTimeLimit() => default; // 0x000000018B3D3990-0x000000018B3D3A10
		private void _ProcessReceivedMessagesInGameThread(bool flushAll) {} // 0x000000018B3D43D4-0x000000018B3D4764
		public HGNetSessionLoginYield LoginAsync(string uid, string token, int channel) => default; // 0x0000000184260490-0x00000001842608A0
		private static void _CSLoginHelper_UpdateAppInfo(MSG_A1 msg) {} // 0x00000001855ECF00-0x00000001855ECFB0
		private static string _GetOnlineResVersion() => default; // 0x00000001855ED080-0x00000001855ED130
		private static ENV_TYPE _GetSDKEnv() => default; // 0x00000001855ECB80-0x00000001855ECC40
		private static CLIENT_PLATFORM_TYPE _GetPlatformID() => default; // 0x00000001855ED5D0-0x00000001855ED600
		private static int _GetPayPlatform() => default; // 0x00000001855ED600-0x00000001855ED660
		private void _SessionLoginThreadTask(object handle) {} // 0x0000000185011260-0x0000000185012990
		public void StartMsgLoop() {} // 0x00000001857507C0-0x0000000185750810
		protected override void OnConnectedSucceed(INetIO tcpIO) {} // 0x0000000185FA9210-0x0000000185FA9240
		protected override void OnReconnectTimesOver(INetIO tcpIO) {} // 0x000000018B3D31A4-0x000000018B3D3210
		protected override bool NeedKeepConnect() => default; // 0x0000000184E13090-0x0000000184E13150
		protected override void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest req) {} // 0x00000001843D0D10-0x00000001843D0E80
		private void _WriteMessageInSessionThread(INetIO netIO, ref NetRequest request, bool useSRSA = false /* Metadata: 0x0207D629 */) {} // 0x00000001843D0540-0x00000001843D08D0
		protected override bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp) {
			resp = default;
			return default;
		} // 0x00000001843C9900-0x00000001843C9A00
		private bool _ReadMessageInSessionThread(INetIO netIO, out NetResponse resp, bool useSRSA = false /* Metadata: 0x0207D62A */) {
			resp = default;
			return default;
		} // 0x00000001843C6D70-0x00000001843C7380
		public override void ClearRecvQueue() {} // 0x0000000185099E90-0x0000000185099F00
		public override void ClearSendQueue() {} // 0x0000000185F5F1E0-0x0000000185F5F240
		public static void SetBurstMode(bool val) {} // 0x000000018B3D38C0-0x000000018B3D3914
		~HGNetSession() {} // 0x0000000185F56B60-0x0000000185F56BA0
		public int GetPing() => default; // 0x00000001840D6940-0x00000001840D6A50
		public bool IsPingInProgress() => default; // 0x000000018B3D306C-0x000000018B3D30BC
		public long GetPingPassedTime() => default; // 0x00000001855C17D0-0x00000001855C1870
		protected override void ClearPingWDG() {} // 0x000000018543A330-0x000000018543A3C0
		private void _ApproximateLoginServerTime(long serverTimeMS, int serverZone) {} // 0x0000000185012A30-0x0000000185012AB0
		private bool _HandleSpecialMessagePing(NetResponse m) => default; // 0x00000001843C3390-0x00000001843C3580
		protected override bool IsPingOut() => default; // 0x00000001843C94C0-0x00000001843C9630
		protected override void PingSenderTick(INetIO netIO, long upSeqId) {} // 0x00000001843C9A00-0x00000001843C9F00
		public static byte[] GetClientPublicKey() => default; // 0x0000000185F4B2F0-0x0000000185F4B390
		protected override void InitClientRSAKey() {} // 0x000000018418D1F0-0x000000018418D300
		private byte[] _RSADecrypt(byte[] data) => default; // 0x0000000184F782E0-0x0000000184F783E0
		protected override void ClearRSAKey() {} // 0x000000018B3D28C0-0x000000018B3D2988
		protected override void CheckAndDealRespMessages(INetIO netIO, ref NetResponse msg) {} // 0x00000001843C3CB0-0x00000001843C4610
		private bool _HandleSpecialMessageReconnectIncr(INetIO netIO, NetResponse m) => default; // 0x000000018B3D3C98-0x000000018B3D41F0
		private bool _HandleSpecialMessageReconnectFull(INetIO netIO, NetResponse m) => default; // 0x000000018B3D3AF0-0x000000018B3D3C98
		private bool _HandleSpecialMessageErrorCode(INetIO netIO, NetResponse m) => default; // 0x000000018B3D3A10-0x000000018B3D3AF0
		private bool _HandleSpecialMessageReconnectLogin(INetIO netIO, NetResponse m) => default; // 0x000000018B3D41F0-0x000000018B3D43D4
		private bool _HandleLoginEncryp(INetIO netIO, MSG_B1 msg) => default; // 0x0000000183E39EB0-0x0000000183E3B440
		public void __iFixBaseProxy_Start() {} // 0x000000018B3D2384-0x000000018B3D238C
	}

	public enum EHGNetSessionState : byte // TypeDefIndex: 57202
	{
		Closed = 0,
		Opened = 1,
		Connecting = 2,
		SessionRunning = 3
	}

	public enum EHGNetSessionReconnectState : byte // TypeDefIndex: 57203
	{
		None = 0,
		ReconnectingTcp = 1,
		SendLogin = 2,
		ResendPack = 3
	}

	public enum ENetCloseReason // TypeDefIndex: 57204
	{
		Invalid = -1,
		None = 0,
		ForServerErrorMax = 100000,
		ConnectFailed = 700002,
		ServerReconnectFailed = 700003,
		TooMuchClientReconnectPack = 700004,
		ServerReconnectFullPack = 700005,
		ClientShutDown = 700010,
		ClientLaunch = 700011,
		ClientReconnectTooMuchTimes = 700013
	}

	public static class HGNetSessionUtils // TypeDefIndex: 57205
	{
		// Methods
		public static bool CheckErrorNeedsDisconnect(CODE errorCode) => default; // 0x000000018B3D2858-0x000000018B3D28C0
	}

	public static class HGNetSessionConstant // TypeDefIndex: 57206
	{
		// Fields
		public const int CODE_SUC = 0; // Metadata: 0x0207D657
		public const int CODE_CONN_FAILED = 1; // Metadata: 0x0207D658
		public const int CODE_CONN_WAIT = -1; // Metadata: 0x0207D659
	}

	public enum ENetConnectErrorCode // TypeDefIndex: 57207
	{
		Invalid = -1,
		None = 0,
		ForServerErrorMax = 100000,
		ConnectError = 800001,
		TimeOut = 800002
	}

	public class HGNetSessionLoginYield : CustomYieldInstruction // TypeDefIndex: 57209
	{
		// Fields
		internal LoginErrorInfo m_loginErrorInfo; // 0x10
		internal bool m_bIsFinish; // 0x18
		internal MSG_A1 m_request; // 0x20
		internal MSG_B1 m_resp; // 0x28
		private object m_locker; // 0x30
	
		// Properties
		public bool isSucceed { get => default; } // 0x000000018B3D5500-0x000000018B3D5578 
		public override bool keepWaiting { get => default; } // 0x0000000184F309E0-0x0000000184F30A30 
	
		// Nested types
		internal class LoginErrorInfo // TypeDefIndex: 57208
		{
			// Fields
			private int _code_k__BackingField; // 0x10
			private string _details_k__BackingField; // 0x18
	
			// Properties
			internal int code { get; private set; } // 0x0000000184F30930-0x0000000184F309E0 0x0000000184F2FD50-0x0000000184F2FE10
			internal string details { get; private set; } // 0x00000001850129C0-0x00000001850129F0 0x0000000184CB9890-0x0000000184CB98C0
	
			// Constructors
			public LoginErrorInfo() {} // 0x000000018B3D2760-0x000000018B3D2858
	
			// Methods
			public void SetErrorInvaild() {} // 0x000000018B3D2490-0x000000018B3D24E8
			public void SetErrorConnectError() {} // 0x000000018B3D24E8-0x000000018B3D2540
			public void SetErrorConnectTimeOut() {} // 0x0000000184F2F930-0x0000000184F2FB20
			public void Clear() {} // 0x000000018B3D2638-0x000000018B3D2760
			public void Set(int code, string details) {} // 0x000000018B3D2540-0x000000018B3D2638
		}
	
		// Constructors
		public HGNetSessionLoginYield() {} // 0x0000000184CB9B40-0x0000000184CB9B70
		public HGNetSessionLoginYield(MSG_A1 req) {} // 0x0000000185F61D60-0x0000000185F61D70
	
		// Methods
		public MSG_A1 GetRequest() => default; // 0x0000000181C0BBD0-0x0000000181C0BBE0
		public MSG_B1 GetResponse() => default; // 0x0000000181378230-0x0000000181378240
		public int GetErrorCode() => default; // 0x0000000181377E40-0x0000000181377E50
		public string GetErrorDetails() => default; // 0x0000000184088E70-0x0000000184088E80
		public void SetSucceed(MSG_B1 sc) {} // 0x0000000184F30A30-0x0000000184F30AA0
		public void SetNtfError(int ntfErrorCode, string ntfErrorDetails) {} // 0x000000018B3D53E8-0x000000018B3D5474
		public void SetConnectErrorError() {} // 0x000000018B3D5474-0x000000018B3D5500
		public void SetTimeOutError() {} // 0x0000000184F304F0-0x0000000184F30560
	}

	public class HGNetSessionConnectYield : CustomYieldInstruction // TypeDefIndex: 57210
	{
		// Fields
		internal System.Threading.Tasks.Task m_connectTask; // 0x10
		internal ENetConnectErrorCode connectErrorCode; // 0x18
	
		// Properties
		public bool isSucceed { get => default; } // 0x0000000184CB9880-0x0000000184CB9890 
		public override bool keepWaiting { get => default; } // 0x0000000185F081E0-0x0000000185F08230 
	
		// Constructors
		public HGNetSessionConnectYield() {} // 0x0000000185FB1880-0x0000000185FB1890
		public HGNetSessionConnectYield(System.Threading.Tasks.Task connectTask) {} // 0x000000018504FE80-0x000000018504FEB0
	
		// Methods
		public int GetCode() => default; // 0x000000018B3D2444-0x000000018B3D2490
		public void SetFinish(ENetConnectErrorCode code) {} // 0x0000000184F678F0-0x0000000184F67930
	}
}

namespace Beyond.Network.HGNetLogger
{
	public abstract class HGNetLogBaseSession // TypeDefIndex: 57211
	{
		// Fields
		private readonly INetIO m_tcpIO; // 0x10
		public static int s_recvBuffLen; // 0x00
		public static int s_tcpSendTimeout; // 0x04
		public static int s_sessionThreadSleepTimeMS; // 0x08
		public static int s_sessionThreadPauseSleepTimeMS; // 0x0C
		public static int s_maxReconnectTimeout; // 0x10
		public static int s_maxReconnectTimes; // 0x14
		protected int m_sendNumLimit; // 0x18
		protected readonly ConcurrentQueue<NetResponse> m_recvQueue; // 0x20
		private readonly ConcurrentQueue<NetRequest> m_sendQueue; // 0x28
		private const int MAX_RECYCLE_QUEUE_COUNT = 1000; // Metadata: 0x0207D668
		protected CircularBuffer<NetRequest> m_circularBuffer; // 0x30
		private long m_csSeqId; // 0x38
		protected long m_scSeqId; // 0x40
		protected System.Threading.Tasks.Task m_threadTask; // 0x48
		protected int m_threadTaskSignal; // 0x50
		protected ELogChannel m_logChannel; // 0x54
		private string m_lastConnectServerIp; // 0x58
		private int m_lastConnectServerPort; // 0x60
		protected int m_tryReconnectTimes; // 0x64
		protected long m_startReconnectTimestampMS; // 0x68
		protected bool m_isAutoReconnect; // 0x70
		protected HGNetSessionConnectYield m_lastAsyncConnectHandle; // 0x78
		protected EHGNetSessionState m_state; // 0x80
		protected EHGNetSessionReconnectState m_reconnectState; // 0x81
		protected int m_closeErrorCode; // 0x84
		public static bool s_applicationIsPaused; // 0x18
		private long m_clientLastReceiveMsgMilliTs; // 0x88
		private long m_clientLastSendMsgMilliTs; // 0x90
	
		// Properties
		public bool isRunning { get; } // 0x000000018B3D1ECC-0x000000018B3D1ED8 
		public bool isConnecting { get; } // 0x000000018B3D1EB4-0x000000018B3D1EC0 
		public bool isRunningAndConnected { get; } // 0x000000018B3D1EC0-0x000000018B3D1ECC 
		public int closeErrorCode { get; } // 0x0000000182FB0000-0x0000000182FB0010 
		public bool isAutoReconnect { get; } // 0x0000000185FB0950-0x0000000185FB0960 
	
		// Constructors
		protected HGNetLogBaseSession() {} // 0x000000018B3D1D6C-0x000000018B3D1EB4
		static HGNetLogBaseSession() {} // 0x000000018B3D1CB8-0x000000018B3D1D6C
	
		// Methods
		public virtual void Start() {} // 0x000000018B3D1334-0x000000018B3D1478
		public virtual bool Connect(string serverIp, int serverPort, bool forceReconnect) => default; // 0x000000018B3D07EC-0x000000018B3D0AD0
		public virtual bool ConnectAsync(string serverIp, int serverPort, bool forceReconnect, out HGNetSessionConnectYield yieldHandle) {
			yieldHandle = default;
			return default;
		} // 0x000000018B3D0454-0x000000018B3D07EC
		public void OnConnectAsyncEnd(System.Threading.Tasks.Task continuationAction) {} // 0x000000018B3D0E78-0x000000018B3D0FB0
		protected abstract void OnConnectedSucceed(INetIO tcpIO);
		private void _DNSCheck(string serverIp) {} // 0x000000018B3D1478-0x000000018B3D1634
		public virtual void Close(ENetCloseReason netCloseReason) {} // 0x000000018B3D01F0-0x000000018B3D0254
		public virtual void Close(int netCloseReason) {} // 0x000000018B3D0254-0x000000018B3D0454
		protected void EnqueueSendMsg(NetRequest msg) {} // 0x000000018B3D0AD0-0x000000018B3D0B84
		public int GetSendQueueMsgCount() => default; // 0x000000018B3D0C24-0x000000018B3D0CA0
		protected long IncrementCSSeqID() => default; // 0x000000018B3D0CA0-0x000000018B3D0CF8
		protected void SetCSSeqID(long id) {} // 0x000000018B3D1114-0x000000018B3D1170
		protected long GetCSSeqID() => default; // 0x000000018B3D0B84-0x000000018B3D0BD4
		protected INetIO GetIO() => default; // 0x000000018B3D0BD4-0x000000018B3D0C24
		protected void StartTCPMsgLoopThreadTask() {} // 0x000000018B3D1170-0x000000018B3D1334
		protected void CloseTCPMsgThreadTask() {} // 0x000000018B3D0110-0x000000018B3D01F0
		private void _SessionThread() {} // 0x000000018B3D18F8-0x000000018B3D1CB8
		protected abstract bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp);
		protected abstract void CheckAndDealRespMessages(INetIO netIO, ref NetResponse m);
		protected abstract void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m);
		protected void SessionCheckSignalAndSleep() {} // 0x000000018B3D104C-0x000000018B3D1114
		protected void OpenAutoReconnect() {} // 0x000000018B3D0FB0-0x000000018B3D1000
		protected void RemoveAutoReconnect() {} // 0x000000018B3D1000-0x000000018B3D104C
		private void _ReconnectCheckerTick() {} // 0x000000018B3D1634-0x000000018B3D18F8
		protected abstract void OnReconnectTimesOver();
		protected abstract bool NeedKeepConnect();
		protected abstract void DoReconnectLogin(INetIO netIO);
		protected abstract void InitClientRSAKey();
		protected abstract void ClearRSAKey();
		protected void NetStatusChecker_Receive(INetIO netIO, long scSeqId, int receiveCount) {} // 0x000000018B3D0CF8-0x000000018B3D0DAC
		protected void NetStatusChecker_Sender(INetIO netIO, long csSeqId, int sendCount) {} // 0x000000018B3D0DAC-0x000000018B3D0E78
		protected abstract void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs);
		protected abstract void ClearPingWDG();
		protected abstract bool IsPingOut();
		protected abstract void PingSenderTick(INetIO netIO, long upSeqId);
	}

	public class HGNetLogger : Beyond.Log.ILogger // TypeDefIndex: 57212
	{
		// Fields
		private BitArray256 m_enabledLogChannel; // 0x10
		private ConcurrentQueue<FLogMessage> m_logMessagesQueue; // 0x30
		public static int s_maxLogQueueSize; // 0x00
		public static int s_maxRepeatedMsgMs; // 0x04
		public static int s_maxRepeatedMsgCount; // 0x08
	
		// Constructors
		public HGNetLogger() {} // 0x0000000184F30F10-0x0000000184F30FA0
		static HGNetLogger() {} // 0x0000000185F7FED0-0x0000000185F7FF40
	
		// Methods
		public void Log(ref FLogMessage msg) {} // 0x00000001841534A0-0x0000000184154890
		public static LogLevel ConvertFromDLogger(ELogLevel level) => default; // 0x0000000185251A70-0x0000000185251AD0
		public static NativeLogLevel ConvertFromDLoggerV2(ELogLevel level) => default; // 0x0000000185251AD0-0x0000000185251B30
		public bool CheckLog(ref FLogMessage msg) => default; // 0x00000001851E81D0-0x00000001851E8230
		public void Clear() {} // 0x0000000185A12DF0-0x0000000185A12E50
		public void SetLogChannel(ulong channel1, ulong channel2, ulong channel3, ulong channel4) {} // 0x000000018B3D238C-0x000000018B3D2444
		public static int ConvertFromDLogger(ELogChannel channel) => default; // 0x000000018531B320-0x000000018531B350
	}

	public class HGNetLoggerClient // TypeDefIndex: 57213
	{
		// Fields
		private static HGNetLoggerClient s_instance; // 0x00
		private static long _s_roleID_k__BackingField; // 0x08
		public HGNetLoggerSession m_logsession; // 0x10
		private HGNetLogger m_netLogger; // 0x18
		public static readonly int MAX_LOG_SEND_QUEUE_SIZE; // 0x10
		private const int MAX_LOCAL_LOG_QUEUE_SIZE = 200; // Metadata: 0x0207D66B
		private readonly Queue<FLogMessage> m_localLogQueue; // 0x20
		private readonly object m_queueLock; // 0x28
		public static Beyond.Network.HGNetLogger.Version s_usedVersion; // 0x14
	
		// Properties
		public static HGNetLoggerClient instance { get => default; } // 0x0000000184261530-0x00000001842616B0 
		public static long s_roleID { get; private set; } // 0x000000018B3D1FA0-0x000000018B3D1FF0 0x000000018B3D1FF0-0x000000018B3D2048
	
		// Constructors
		protected HGNetLoggerClient() {} // 0x0000000185EFEFE0-0x0000000185EFF0B0
		static HGNetLoggerClient() {} // 0x0000000185F8B5A0-0x0000000185F8B5F0
	
		// Methods
		public void Init(string uid, string token, string env, string roleId = "" /* Metadata: 0x0207D66A */) {} // 0x0000000184F310B0-0x0000000184F31580
		public void AddLog(string message, string stacktrace, UnityEngine.LogType type) {} // 0x0000000184F2F090-0x0000000184F2F670
		private void _FlushLocalLogQueue() {} // 0x0000000184F2FE10-0x0000000184F304F0
		public static void OnApplicationPause(bool pauseStatus) {} // 0x000000018B3D1ED8-0x000000018B3D1FA0
		public void ShutDown() {} // 0x00000001852D3180-0x00000001852D31C0
		private void _CloseAndClear(ENetCloseReason reason) {} // 0x0000000184A90CE0-0x0000000184A90F70
		public void WriteNetLog(ref LogMessage log) {} // 0x0000000184262700-0x0000000184262850
		public static void SetRoleID(ulong roleID) {} // 0x00000001855A75A0-0x00000001855A7640
		public void SetNetLogMaskFromServer(RepeatedField<ulong> masks) {} // 0x0000000185FA9240-0x0000000185FA9270
		private void _Init_b__15_0() {} // 0x0000000185A12DD0-0x0000000185A12DF0
	}

	public class HGNetLoggerCloudSettings // TypeDefIndex: 57214
	{
		// Fields
		public static readonly HGNetLoggerCloudSettings instance; // 0x00
		private LogControl m_cloudLogControl; // 0x10
		private Dictionary<int, int> m_cloudChannelLevelMaskTables; // 0x18
		private LogControl m_localLogControl; // 0x20
		private Dictionary<int, int> m_localChannelLevelMaskTables; // 0x28
		private static List<NativeLogLevel> s_allLevels; // 0x08
	
		// Constructors
		public HGNetLoggerCloudSettings() {} // 0x0000000185BA4700-0x0000000185BA47B0
		static HGNetLoggerCloudSettings() {} // 0x0000000185BA45A0-0x0000000185BA4700
	
		// Methods
		public static void SetCloudLogControl(AuthResponse control, HGNetBaseSession session) {} // 0x0000000184263360-0x0000000184264790
		public static bool IsNetLogLevelEnabled(ELogLevel elevel, ELogChannel channel) => default; // 0x0000000184F2F860-0x0000000184F2F8E0
		public static bool IsNetLogLevelEnabled(NativeLogLevel level, int channel) => default; // 0x0000000184263190-0x0000000184263360
		public static bool IsLocalLogLevelEnabled(ELogLevel elevel, ELogChannel channel) => default; // 0x000000018B3D2048-0x000000018B3D2184
		public static NativeLogLevel ConvertFromDLogger(ELogLevel level) => default; // 0x0000000184F2F8E0-0x0000000184F2F930
	}

	public class HGNetLoggerSession : HGNetBaseSession // TypeDefIndex: 57215
	{
		// Fields
		private byte[] m_keyBytes; // 0xC0
		private Dictionary<string, int> m_templeCRCDict; // 0xC8
		private Action m_onReconnectSuccess; // 0xD0
		private string m_uid; // 0xD8
		private string m_roleId; // 0xE0
		private string m_token; // 0xE8
		private string m_env; // 0xF0
		private static Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> s_m_messageType2Id; // 0x00
		private static Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> s_m_messageId2Type; // 0x08
	
		// Properties
		public string uid { get => default; } // 0x0000000185FB02F0-0x0000000185FB0300 
		public string roleId { get => default; } // 0x0000000185FB25D0-0x0000000185FB25E0 
		private static Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> s_messageType2Id { get => default; } // 0x00000001843CF400-0x00000001843CF640 
		private static Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> s_messageId2Type { get => default; } // 0x000000018599B560-0x000000018599B7B0 
	
		// Constructors
		public HGNetLoggerSession() {} // 0x0000000184F30CF0-0x0000000184F30DA0
	
		// Methods
		public static bool TryGetMsgTypeByID(System.Type msgType, out Beyond.Network.HGNetLogger.MessageType type) {
			type = default;
			return default;
		} // 0x00000001843CF380-0x00000001843CF400
		public override void Start() {} // 0x0000000183FC0F60-0x0000000183FC0FB0
		public void SetReconnectSuccessCallback(Action onReconnectSuccess) {} // 0x0000000184F31000-0x0000000184F31050
		public void OnApplicationPause(bool pause) {} // 0x000000018B3D21C8-0x000000018B3D22C8
		protected override void OnConnectedSucceed(INetIO tcpIO) {} // 0x0000000185750810-0x0000000185750870
		protected override bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp) {
			resp = default;
			return default;
		} // 0x00000001843C8FF0-0x00000001843C94C0
		protected override void CheckAndDealRespMessages(INetIO netIO, ref NetResponse resp) {} // 0x00000001843C2FE0-0x00000001843C3200
		protected override void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m) {} // 0x00000001843CF640-0x00000001843CF6B0
		private void _WriteMessageInSessionThread(INetIO netIO, NetRequest request) {} // 0x00000001843CE830-0x00000001843CEB70
		public ulong SendMessage(IMessage msg) => default; // 0x0000000184262850-0x00000001842630D0
		public void SetAutoReconnectToken(string uid, string token, string env, string roleId) {} // 0x0000000184F30DA0-0x0000000184F30E40
		protected override bool NeedKeepConnect() => default; // 0x00000001843C9730-0x00000001843C9900
		protected override void DoReconnectLogin(INetIO netIO) {} // 0x00000001843C2EF0-0x00000001843C2FE0
		private int _GetConnectTimeoutTime() => default; // 0x00000001843CA270-0x00000001843CA4F0
		protected override void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs) {} // 0x00000001843C9FE0-0x00000001843CA270
		protected override void ClearPingWDG() {} // 0x0000000185DA9C00-0x0000000185DA9C30
		public void SendLogin(INetIO netIO) {} // 0x0000000184261CD0-0x0000000184262100
		protected override bool IsPingOut() => default; // 0x00000001854BFDD0-0x00000001854BFE00
		protected override void PingSenderTick(INetIO netIO, long upSeqId) {} // 0x0000000184F3AC10-0x0000000184F3ACF0
		protected override void InitClientRSAKey() {} // 0x0000000185FA5490-0x0000000185FA54C0
		protected override void ClearRSAKey() {} // 0x000000018B3D2184-0x000000018B3D21C8
		public override void ClearRecvQueue() {} // 0x0000000185FA54F0-0x0000000185FA5520
		public override void ClearSendQueue() {} // 0x0000000185FA54C0-0x0000000185FA54F0
		protected override void OnReconnectTimesOver(INetIO tcpIO) {} // 0x000000018B3D22C8-0x000000018B3D2384
		public void __iFixBaseProxy_Start() {} // 0x000000018B3D2384-0x000000018B3D238C
	}
}

namespace Beyond.SourceGenerator
{
	internal class DataNAttribute : Attribute // TypeDefIndex: 57122
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 57123
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 57124
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 57125
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 57126
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 57121
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 57216
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64550-0x0000000185F645C0
	
		// Methods
		public void __Gen_Wrap_0(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public void __Gen_Wrap_1(object P0, object P1, int P2) {} // 0x00000001876A23EC-0x00000001876A24E4
		public IAsyncResult __Gen_Wrap_2(object P0, object P1, int P2, object P3, object P4) => default; // 0x000000018B3D4FA0-0x000000018B3D50E4
		public System.Threading.Tasks.Task __Gen_Wrap_3(object P0, object P1, int P2) => default; // 0x000000018B3D50E4-0x000000018B3D5208
		public NetworkStream __Gen_Wrap_4(object P0) => default; // 0x000000018B3D5208-0x000000018B3D52F8
		public void __Gen_Wrap_5(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public void __Gen_Wrap_6(object P0, bool P1) {} // 0x0000000187678A10-0x0000000187678AEC
		public LingerOption __Gen_Wrap_7(object P0) => default; // 0x000000018B3D52F8-0x000000018B3D53E8
		public int __Gen_Wrap_8(object P0, SocketOptionLevel P1, SocketOptionName P2) => default; // 0x000000018A816DC0-0x000000018A816EB0
		public int __Gen_Wrap_9(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public bool __Gen_Wrap_10(object P0) => default; // 0x000000018735B960-0x000000018735BA30
		public long __Gen_Wrap_11(object P0) => default; // 0x000000018735B890-0x000000018735B960
		public ulong __Gen_Wrap_12(object P0, object P1) => default; // 0x000000018B3D4764-0x000000018B3D4850
		public System.Type __Gen_Wrap_13(int P0) => default; // 0x000000018B3D4850-0x000000018B3D493C
		public void __Gen_Wrap_14(object P0, int P1, object P2) {} // 0x00000001876A5764-0x00000001876A585C
		public void __Gen_Wrap_15(object P0, int P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public NetBus.ResultHandler __Gen_Wrap_16(object P0, object P1) => default; // 0x000000018B3D493C-0x000000018B3D4A48
		public void __Gen_Wrap_17(object P0, in NetResponse P1) {} // 0x000000018B3D4A48-0x000000018B3D4B74
		public NetBus.ResultHandler __Gen_Wrap_18(object P0, SCMessageID P1, object P2) => default; // 0x000000018B3D4B74-0x000000018B3D4C98
		public void __Gen_Wrap_19(object P0, SCMessageID P1, object P2) {} // 0x000000018A81C9C4-0x000000018A81CAA8
		public int __Gen_Wrap_20(object P0, object P1, float P2, float P3) => default; // 0x000000018B3D4C98-0x000000018B3D4DB0
		public int __Gen_Wrap_21(object P0, CSMessageID P1, float P2) => default; // 0x000000018B3D4DB0-0x000000018B3D4EA4
		public void __Gen_Wrap_22(in NetResponse P0) {} // 0x000000018B3D4EA4-0x000000018B3D4FA0
		public NetBus.ResultHandler __Gen_Wrap_23(object P0, object P1, float P2) => default; // 0x0000000183E3EF70-0x0000000183E3F9C0
		public NetBus.ResultHandler __Gen_Wrap_24(object P0, object P1, bool P2, object P3, object P4) => default; // 0x0000000183E3F9C0-0x0000000183E40580
		public void __Gen_Wrap_25(object P0, float P1) {} // 0x0000000181362020-0x0000000181362300
		public bool __Gen_Wrap_26(object P0, object P1) => default; // 0x0000000183E40580-0x0000000183E40920
		public void __Gen_Wrap_27(int P0, object P1) {} // 0x0000000181563F30-0x0000000181564220
		public void __Gen_Wrap_28() {} // 0x000000018136DA00-0x000000018136DBB0
		public bool __Gen_Wrap_29(Span<byte> P0, object P1, int P2, int P3, object P4, out NetResponse P5) {
			P5 = default;
			return default;
		} // 0x0000000183E40920-0x0000000183E415D0
		public int __Gen_Wrap_30(object P0, ulong P1, int P2, int P3, object P4, int P5) => default; // 0x0000000183E415D0-0x0000000183E41A20
		public void __Gen_Wrap_31(System.Type P0, MethodInfo P1) {} // 0x000000018135AD00-0x000000018135B080
		public string __Gen_Wrap_32() => default; // 0x0000000183E41A20-0x0000000183E42260
		public string __Gen_Wrap_33(object P0) => default; // 0x0000000183E42260-0x0000000183E42BA0
		public string __Gen_Wrap_34(NetworkUrls.EUrlType P0) => default; // 0x0000000183E42BA0-0x0000000183E43420
		public string __Gen_Wrap_35(object P0, NetworkUrls.EUrlType P1) => default; // 0x0000000183E43420-0x0000000183E43D80
		public void __Gen_Wrap_36(object P0, object P1, int P2, int P3, int P4, int P5) {} // 0x0000000183E43D80-0x0000000183E441B0
		public System.Threading.Tasks.Task __Gen_Wrap_37(object P0, object P1, int P2, int P3, int P4, int P5) => default; // 0x0000000183E441B0-0x0000000183E44C80
		public void __Gen_Wrap_38(object P0, object P1, object P2) {} // 0x00000001816167B0-0x0000000181616C40
		public EndPoint __Gen_Wrap_39(object P0) => default; // 0x0000000183E44C80-0x0000000183E455B0
		public void __Gen_Wrap_40(object P0, bool P1, bool P2) {} // 0x0000000181545370-0x0000000181545670
		public void __Gen_Wrap_41(object P0, object P1, int P2, int P3) {} // 0x000000018218D760-0x000000018218DB40
		public byte[] __Gen_Wrap_42(object P0) => default; // 0x0000000183E455B0-0x0000000183E45EF0
		public int __Gen_Wrap_43(object P0, object P1, int P2, int P3) => default; // 0x000000018169F230-0x000000018169F620
		public HttpSender.Cancellation __Gen_Wrap_44(ref HttpSender.FSendFunc P0) => default; // 0x0000000183E45EF0-0x0000000183E46E70
		public UnityWebRequest __Gen_Wrap_45(object P0, HttpSender.FGetOptions P1) => default; // 0x0000000183E46E70-0x0000000183E47B60
		public UnityWebRequest __Gen_Wrap_46(object P0, HttpSender.FPostOptions P1) => default; // 0x0000000183E47B60-0x0000000183E48850
		public UnityWebRequest __Gen_Wrap_47(ref HttpSender.FSendFunc P0) => default; // 0x0000000183E48850-0x0000000183E497D0
		public IEnumerator __Gen_Wrap_48(object P0, HttpSender.FSendFunc P1) => default; // 0x0000000183E497D0-0x0000000183E4A4F0
		public IEnumerator __Gen_Wrap_49(object P0, HttpSender.FSendFunc P1, object P2) => default; // 0x0000000183E4A4F0-0x0000000183E4B300
		public IEnumerator __Gen_Wrap_50(object P0, HttpSender.FGetOptions P1, object P2, object P3) => default; // 0x0000000183E4B300-0x0000000183E4C1C0
		public IEnumerator __Gen_Wrap_51(object P0, HttpSender.FGetOptions P1, object P2) => default; // 0x0000000183E4C1C0-0x0000000183E4CF90
		public IEnumerator __Gen_Wrap_52(object P0, HttpSender.FPostOptions P1, object P2, object P3) => default; // 0x0000000183E4CF90-0x0000000183E4DE50
		public IEnumerator __Gen_Wrap_53(object P0, HttpSender.FPostOptions P1, object P2) => default; // 0x0000000183E4DE50-0x0000000183E4EBD0
		public void __Gen_Wrap_54(object P0, HttpSender.FSendFunc P1) {} // 0x0000000183E4EBD0-0x0000000183E4F2A0
		public HttpSender.Result __Gen_Wrap_55() => default; // 0x0000000183E4F2A0-0x0000000183E4FAE0
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_56(HttpSender.FSendFunc P0) => default; // 0x0000000183E4FAE0-0x0000000183E50720
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_57(object P0, HttpSender.FPostOptions P1) => default; // 0x0000000183E50720-0x0000000183E51400
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_58(object P0, HttpSender.FGetOptions P1) => default; // 0x0000000183E51400-0x0000000183E520E0
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_59(object P0) => default; // 0x0000000183E520E0-0x0000000183E52A10
		public int __Gen_Wrap_60(object P0, out bool P1) {
			P1 = default;
			return default;
		} // 0x0000000183E52A10-0x0000000183E52D30
		public string __Gen_Wrap_61(ref HttpSender.FSendFunc P0) => default; // 0x0000000183E52D30-0x0000000183E53C90
		public void __Gen_Wrap_62(object P0, EHGNetSessionReconnectState P1) {} // 0x0000000181570FE0-0x00000001815712C0
		public void __Gen_Wrap_63(object P0, object P1, ENetCloseReason P2) {} // 0x0000000181570120-0x00000001815704E0
		public bool __Gen_Wrap_64(object P0, object P1, int P2, bool P3) => default; // 0x00000001825AA5E0-0x00000001825AA9B0
		public void __Gen_Wrap_65(object P0, ENetConnectErrorCode P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public void __Gen_Wrap_66(object P0, ENetCloseReason P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public void __Gen_Wrap_67(Task<System.Threading.Tasks.Task> P0) {} // 0x0000000181354D40-0x0000000181355000
		public bool __Gen_Wrap_68(object P0, object P1, int P2, bool P3, out HGNetSessionConnectYield P4) {
			P4 = default;
			return default;
		} // 0x0000000183E53C90-0x0000000183E54800
		public void __Gen_Wrap_69(object P0, NetRequest P1) {} // 0x0000000183E54800-0x0000000183E54E90
		public void __Gen_Wrap_70(object P0, long P1) {} // 0x00000001815A4720-0x00000001815A4A00
		public INetIO __Gen_Wrap_71(object P0) => default; // 0x0000000183E54E90-0x0000000183E557D0
		public Task<bool> __Gen_Wrap_72(object P0, object P1, int P2) => default; // 0x0000000183E557D0-0x0000000183E56230
		public Task<bool> __Gen_Wrap_73(object P0, object P1, object P2, int P3, int P4, int P5, int P6) => default; // 0x0000000183E56230-0x0000000183E56DF0
		public System.Threading.Tasks.Task __Gen_Wrap_74(object P0, object P1) => default; // 0x0000000183E56DF0-0x0000000183E57820
		public void __Gen_Wrap_75(object P0, object P1, long P2, int P3) {} // 0x00000001823C75D0-0x00000001823C79B0
		public bool __Gen_Wrap_76(object P0, object P1, int P2) => default; // 0x0000000181F508D0-0x0000000181F50CA0
		public System.Threading.Tasks.Task __Gen_Wrap_77() => default; // 0x0000000183E57820-0x0000000183E58060
		public void __Gen_Wrap_78(object P0, object P1, object P2, int P3) {} // 0x0000000181FDB6A0-0x0000000181FDBB50
		public void __Gen_Wrap_79(object P0, object P1, long P2, long P3) {} // 0x00000001821EF040-0x00000001821EF430
		public byte[] __Gen_Wrap_80() => default; // 0x0000000183E58060-0x0000000183E588A0
		public CLIENT_PLATFORM_TYPE __Gen_Wrap_81() => default; // 0x0000000181361E60-0x0000000181362020
		public ENV_TYPE __Gen_Wrap_82() => default; // 0x0000000181361E60-0x0000000181362020
		public int __Gen_Wrap_83() => default; // 0x0000000181361E60-0x0000000181362020
		public void __Gen_Wrap_84(object P0, object P1, ref NetRequest P2, bool P3) {} // 0x0000000183E588A0-0x0000000183E596B0
		public bool __Gen_Wrap_85(object P0, object P1, out NetResponse P2, bool P3) {
			P2 = default;
			return default;
		} // 0x0000000183E596B0-0x0000000183E5A1B0
		public void __Gen_Wrap_86(object P0, long P1, int P2) {} // 0x00000001821E13E0-0x00000001821E16E0
		public byte[] __Gen_Wrap_87(object P0, object P1) => default; // 0x0000000183E5A1B0-0x0000000183E5ABE0
		public bool __Gen_Wrap_88(object P0, object P1, object P2) => default; // 0x00000001816ADC00-0x00000001816AE0A0
		public MSG_A1 __Gen_Wrap_89(object P0) => default; // 0x0000000183E5ABE0-0x0000000183E5B520
		public HGNetSessionLoginYield __Gen_Wrap_90(object P0, object P1, object P2, int P3) => default; // 0x0000000183E5B520-0x0000000183E5C070
		public void __Gen_Wrap_91(object P0, object P1, ref NetRequest P2) {} // 0x0000000183E5C070-0x0000000183E5CE60
		public bool __Gen_Wrap_92(object P0, object P1, out NetResponse P2) {
			P2 = default;
			return default;
		} // 0x0000000183E5CE60-0x0000000183E5D940
		public bool __Gen_Wrap_93(object P0, NetResponse P1) => default; // 0x0000000183E5D940-0x0000000183E5DFE0
		public void __Gen_Wrap_94(object P0, object P1, long P2) {} // 0x0000000182240E60-0x0000000182241220
		public bool __Gen_Wrap_95(CODE P0) => default; // 0x0000000181388120-0x0000000181388320
		public bool __Gen_Wrap_96(object P0, object P1, NetResponse P2) => default; // 0x0000000183E5DFE0-0x0000000183E5E770
		public void __Gen_Wrap_97(object P0, object P1, ref NetResponse P2) {} // 0x0000000183E5E770-0x0000000183E5F570
		public MSG_B1 __Gen_Wrap_98(object P0) => default; // 0x0000000183E5F570-0x0000000183E5FEB0
		public bool __Gen_Wrap_99(object P0, ref FLogMessage P1) => default; // 0x0000000183E5FEB0-0x0000000183E60BE0
		public LogLevel __Gen_Wrap_100(ELogLevel P0) => default; // 0x00000001816A2820-0x00000001816A2A20
		public NativeLogLevel __Gen_Wrap_101(ELogLevel P0) => default; // 0x00000001816A2A20-0x00000001816A2C20
		public int __Gen_Wrap_102(ELogChannel P0) => default; // 0x00000001816A2820-0x00000001816A2A20
		public bool __Gen_Wrap_103(NativeLogLevel P0, int P1) => default; // 0x000000018156F210-0x000000018156F430
		public bool __Gen_Wrap_104(ELogLevel P0, ELogChannel P1) => default; // 0x0000000181678660-0x0000000181678890
		public void __Gen_Wrap_105(object P0, object P1, object P2, UnityEngine.LogType P3) {} // 0x0000000181549A10-0x0000000181549E70
		public HGNetLoggerClient __Gen_Wrap_106() => default; // 0x0000000183E3B440-0x0000000183E3BC80
		public void __Gen_Wrap_107(object P0, ref LogMessage P1) {} // 0x0000000183E3BC80-0x0000000183E3C720
		public void __Gen_Wrap_108(object P0, ref FLogMessage P1) {} // 0x0000000183E3C720-0x0000000183E3D440
		public void __Gen_Wrap_109(object P0, ulong P1, ulong P2, ulong P3, ulong P4) {} // 0x0000000183E3D440-0x0000000183E3D770
		public void __Gen_Wrap_110(object P0, object P1, object P2, object P3, object P4) {} // 0x000000018213E910-0x000000018213EF70
		public void __Gen_Wrap_111(bool P0) {} // 0x00000001813641A0-0x0000000181364390
		public void __Gen_Wrap_112(ulong P0) {} // 0x000000018138ABD0-0x000000018138ADC0
		public Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> __Gen_Wrap_113() => default; // 0x0000000183E3D770-0x0000000183E3DFB0
		public Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> __Gen_Wrap_114() => default; // 0x0000000183E3DFB0-0x0000000183E3E7F0
		public bool __Gen_Wrap_115(object P0, out Beyond.Network.HGNetLogger.MessageType P1) {
			P1 = default;
			return default;
		} // 0x0000000181897FA0-0x00000001818982C0
		public void __Gen_Wrap_116(object P0, object P1, NetRequest P2) {} // 0x0000000183E3E7F0-0x0000000183E3EF70
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object>, IAsyncStateMachine // TypeDefIndex: 57217
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
		private int methodId_5; // 0x54
		private int methodId_6; // 0x58
	
		// Properties
		object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B3D5888-0x000000018B3D5934 
		object IEnumerator.Current { get => default; } // 0x000000018B3D5934-0x000000018B3D59E0 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018B3D59E0-0x000000018B3D5AD4
	
		// Methods
		void IDisposable.Dispose() {} // 0x00000001873416FC-0x0000000187341778
		private bool MoveNext() => default; // 0x0000000187341518-0x00000001873415A4
		void IEnumerator.Reset() {} // 0x00000001872E7280-0x00000001872E72FC
		private void MoveNext() {} // 0x000000018B3D5578-0x000000018B3D5608
		private void SetStateMachine(IAsyncStateMachine P0) {} // 0x000000018B3D57D8-0x000000018B3D5888
		public void RefAwaitUnsafeOnCompleteMethod() {} // 0x000000018B3D569C-0x000000018B3D57D8
		public void RefAsyncBuilderStartMethod() {} // 0x000000018B3D5608-0x000000018B3D569C
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 57218
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018B3D5CBC-0x000000018B3D5D20
		public static bool IsPatched(int id) => default; // 0x00000001843C7AC0-0x00000001843C7B70
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018B3D5B78-0x000000018B3D5C44
		public object CreateWrapper(int id) => default; // 0x000000018B3D5C44-0x000000018B3D5CBC
		public object InitWrapperArray(int len) => default; // 0x000000018B3D5D20-0x000000018B3D5DAC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018B3D5AD4-0x000000018B3D5B78
	}

	public enum IDMAP0 // TypeDefIndex: 57219
	{
		Beyond-Network-HGTcpClient-Connect1 = 0,
		Beyond-Network-HGTcpClient-Connect0 = 1,
		Beyond-Network-HGTcpClient-Connect2 = 2,
		Beyond-Network-HGTcpClient-Connect3 = 3,
		Beyond-Network-HGTcpClient-BeginConnect0 = 4,
		Beyond-Network-HGTcpClient-BeginConnect1 = 5,
		Beyond-Network-HGTcpClient-BeginConnect2 = 6,
		Beyond-Network-HGTcpClient-EndConnect0 = 7,
		Beyond-Network-HGTcpClient-ConnectAsync0 = 8,
		Beyond-Network-HGTcpClient-ConnectAsync1 = 9,
		Beyond-Network-HGTcpClient-ConnectAsync2 = 10,
		Beyond-Network-HGTcpClient-GetStream0 = 11,
		Beyond-Network-HGTcpClient-Close0 = 12,
		Beyond-Network-HGTcpClient-Dispose0 = 13,
		Beyond-Network-HGTcpClient-Dispose1 = 14,
		Beyond-Network-HGTcpClient-get_LingerState0 = 15,
		Beyond-Network-HGTcpClient-_Initialize0 = 16,
		Beyond-Network-HGTcpClient-_NumericOption0 = 17,
		Beyond-Network-NetBus-get_currentSessionID0 = 18,
		Beyond-Network-NetBus-Setup0 = 20,
		Beyond-Network-NetBus-Send0 = 21,
		Beyond-Network-NetBus-_ValidateSession0 = 22,
		Beyond-Network-HGNetSession-SendMessage0 = 23,
		Beyond-Network-HGNetBaseSession-IncrementCSSeqID0 = 24,
		Beyond-Network-NetBus-RegisterMessageHandler0 = 25,
		Beyond-Network-NetUtil-GetSCMsgTypeById0 = 26,
		Beyond-Network-NetBus-UnRegisterMessageHandler0 = 27,
		Beyond-Network-NetBus-OnNetClientShutDown0 = 28,
		Beyond-Network-NetBus-_SendWithResult0 = 34,
		Beyond-Network-NetBus-_Listen0 = 37,
		Beyond-Network-NetBus-_UnListen0 = 38,
		Beyond-Network-NetBus-_UnListenWithSeqNum0 = 39,
		Beyond-Network-NetBus-ResultHandler-SetIgnoreSeq0 = 40,
		Beyond-Network-NetBus-ResultHandler-OnResponse0 = 41,
		Beyond-Network-NetBus-ResultHandler-_HandleMessage0 = 42,
		Beyond-Network-NetBus-ResultHandler-_CheckSessionIDValid0 = 43,
		Beyond-Network-NetBus-ResultHandler-Dispose0 = 45,
		Beyond-Network-NetBus-Sender-DoSend0 = 49,
		Beyond-Network-NetBus-Sender-DoListen0 = 50,
		Beyond-Network-NetBus-Sender-DoUnListen0 = 51,
		Beyond-Network-Special2BusSender-Send0 = 52,
		Beyond-Network-DisposableBusSender-Send0 = 53,
		Beyond-Network-Special2BusSender-OnNetShutDown0 = 55,
		Beyond-Network-DisposableBusSender-OnNetShutDown0 = 56,
		Beyond-Network-DisposableBusSender-_Clear0 = 57,
		Beyond-Network-Special2BusSender-_ClearSendTime0 = 58,
		Beyond-Network-Special2BusSender-Dispose0 = 59,
		Beyond-Network-DisposableBusSender-Dispose0 = 60,
		Beyond-Network-NetworkMaskConfigHolder-Init0 = 62,
		Beyond-Network-NetworkMaskConfigHolder-Dispose0 = 63,
		Beyond-Network-UIBusSender-Dispose0 = 64,
		Beyond-Network-NetworkMask-RemoveMask0 = 66,
		Beyond-Network-NetworkMask-_UpdateMaskState0 = 67,
		Beyond-Network-UIBusSender-Send0 = 72,
		Beyond-Network-NetUtil-GetCSMsgIdByType0 = 77,
		Beyond-Network-NetworkMask-AddMask1 = 78,
		Beyond-Network-NetworkMask-AddMask0 = 79,
		Beyond-Network-NetworkMask-_GetKey0 = 80,
		Beyond-Network-UIBusSender-OnNetShutDown0 = 81,
		Beyond-Network-TeleportMaskSender-Dispose0 = 82,
		Beyond-Network-TeleportMaskSender-Send0 = 83,
		Beyond-Network-TeleportMaskSender-OnNetShutDown0 = 89,
		Beyond-Network-FrequencyControlBusSender-_TrySendWaitingMsg0 = 90,
		Beyond-Network-FrequencyControlBusSender-Send0 = 91,
		Beyond-Network-FrequencyControlBusSender-Send1 = 96,
		Beyond-Network-FrequencyControlBusSender-Dispose0 = 97,
		Beyond-Network-ServerConfig-IsSame0 = 98,
		Beyond-Network-NetUtil-RegisterSCMessage0 = 99,
		Beyond-Network-NetUtil-RegisterCSMessage0 = 100,
		Beyond-Network-NetUtil-GetSCMsgIdByType0 = 101,
		Beyond-Network-NetUtil-FastRegisterMessage0 = 102,
		Beyond-Network-NetUtil-GetNetMessageFromDataBytes0 = 103,
		Beyond-Network-NetUtil-SerializeHeadMessage0 = 104,
		Beyond-Network-NetUtil-AutoRegisterMessageHandlers0 = 105,
		Beyond-Network-NetUtil-AutoUnRegisterMessageHandlers0 = 106,
		Beyond-Network-NetUtil-_ForeachMessageHandlers0 = 110,
		Beyond-Network-NetworkMask-OnInit0 = 111,
		Beyond-Network-NetworkMask-_CreateTickFunction0 = 112,
		Beyond-Network-NetworkMask-PreTick0 = 113,
		Beyond-Network-NetworkMask-_OnSwitchLanguage0 = 114,
		Beyond-Network-NetworkMask-OnUnInit0 = 115,
		Beyond-Network-NetworkMask-_ClearTickFunction0 = 116,
		Beyond-Network-NetworkMask-Release0 = 117,
		Beyond-Network-NetworkMask-ListenOnNetMaskChanged0 = 118,
		Beyond-Network-NetworkMask-UnListenOnNetMaskChanged0 = 119,
		Beyond-Network-NetworkUrls-RemoteConfigUrl0 = 120,
		Beyond-Network-NetworkUrls-ResourceRootUrlDev0 = 121,
		Beyond-Network-NetworkUrls-ServerListUrl0 = 122,
		Beyond-Network-NetworkUrls-_GetUrlFromLocal0 = 123,
		Beyond-Network-NetworkUrls-AgeTipsUrl0 = 124,
		Beyond-Network-NetworkUrls-_SelectUrl0 = 125,
		Beyond-Network-NetworkUrls-GovUrl0 = 126,
		Beyond-Network-NetworkUrls-LauncherUrl0 = 127,
		Beyond-Network-TcpIO-Connect0 = 128,
		Beyond-Network-TcpIO-IsConnected0 = 129,
		Beyond-Network-TcpIO-Close0 = 130,
		Beyond-Network-TcpIO-ConnectAsync0 = 131,
		Beyond-Network-TcpIO-IsAuthed0 = 132,
		Beyond-Network-TcpIO-MarkAuthed0 = 133,
		Beyond-Network-TcpIO-EnableCryptStream0 = 134,
		Beyond-Network-TcpIO-GetEndPoint0 = 135,
		Beyond-Network-TcpIO-TestCloseNetIO0 = 136,
		Beyond-Network-TcpIO-TestDropNetIO0 = 137,
		Beyond-Network-TcpIO-WriteData0 = 138,
		Beyond-Network-TcpIO-WriteCryptoData0 = 139,
		Beyond-Network-TcpIO-GetSendHeadBuffer0 = 140,
		Beyond-Network-TcpIO-GetSendBuffer0 = 141,
		Beyond-Network-TcpIO-GetReceiveBuffer0 = 142,
		Beyond-Network-TcpIO-ClearReceiveBufferOffset0 = 143,
		Beyond-Network-TcpIO-GetReceiveBufferOffset0 = 144,
		Beyond-Network-TcpIO-SkipReceiveBufferOffset0 = 145,
		Beyond-Network-TcpIO-ReadData0 = 146,
		Beyond-Network-TcpIO-ReadCryptoData0 = 147,
		Beyond-Network-TcpIO-Available0 = 148,
		Beyond-Network-TcpIO-Dispose0 = 149,
		Beyond-Network-HttpSender-YieldSendGet1 = 150,
		Beyond-Network-HttpSender-YieldSendGet0 = 154,
		Beyond-Network-HttpSender-_YieldSendHttpRequest1 = 158,
		Beyond-Network-HttpSender-_YieldSendHttpRequest0 = 162,
		Beyond-Network-HttpSender-FSendFunc-GetCancellation0 = 167,
		Beyond-Network-HttpSender-FSendFunc-Invoke0 = 168,
		Beyond-Network-HttpSender-_CreateWebRequestGET0 = 169,
		Beyond-Network-HttpSender-_CreateWebRequestPOST0 = 170,
		Beyond-Network-HttpSender-Cancellation-IsCanceled0 = 171,
		Beyond-Network-HttpSender-_SetHttpResult0 = 172,
		Beyond-Network-HttpSender-_MarkResultAsException0 = 173,
		Beyond-Network-HttpSender-_DeserializeTypedResult0 = 177,
		Beyond-Network-HttpSender-YieldSendPost1 = 188,
		Beyond-Network-HttpSender-YieldSendPost0 = 192,
		Beyond-Network-HttpSender-WaitForSendPost0 = 202,
		Beyond-Network-HttpSender-_WaitForSendHttpRequest0 = 203,
		Beyond-Network-HttpSender-_WaitForServiceDone0 = 206,
		Beyond-Network-HttpSender-_StartWebRequestTask0 = 207,
		Beyond-Network-HttpSender-WaitForSendGet1 = 208,
		Beyond-Network-HttpSender-WaitForSendGet0 = 209,
		Beyond-Network-HttpSender-GetGeneralErrorCode0 = 210,
		Beyond-Network-HttpSender-_DebugOnlyProfileResult0 = 211,
		Beyond-Network-HttpSender-Cancellation-Cancel0 = 212,
		Beyond-Network-HttpSender-FSendFunc-GetOptMethod0 = 213,
		Beyond-Network-HGNetBaseSession-set_reconnectState0 = 214,
		Beyond-Network-HGNetBaseSession-Start0 = 215,
		Beyond-Network-HGNetBaseSession-Connect0 = 217,
		Beyond-Network-HGNetBaseSession-_DNSCheck0 = 218,
		Beyond-Network-HGNetBaseSession-InternalClose1 = 219,
		Beyond-Network-HGNetBaseSession-InternalClose0 = 220,
		Beyond-Network-HGNetBaseSession-RemoveAutoReconnect0 = 221,
		Beyond-Network-HGNetBaseSession-CloseTCPMsgThreadTask0 = 222,
		Beyond-Network-HGNetBaseSession-ConnectAsync0 = 223,
		Beyond-Network-HGNetBaseSession-OnConnectAsyncEnd0 = 226,
		Beyond-Network-HGNetSessionConnectYield-SetFinish0 = 227,
		Beyond-Network-HGNetBaseSession-Close0 = 228,
		Beyond-Network-HGNetBaseSession-EnqueueSendMsg0 = 229,
		Beyond-Network-HGNetBaseSession-GetSendQueueMsgCount0 = 230,
		Beyond-Network-HGNetBaseSession-SetCSSeqID0 = 231,
		Beyond-Network-HGNetBaseSession-GetCSSeqID0 = 232,
		Beyond-Network-HGNetBaseSession-GetIO0 = 233,
		Beyond-Network-HGNetBaseSession-StartTCPMsgLoopThreadTask0 = 234,
		Beyond-Network-HGNetBaseSession-_SessionThread0 = 237,
		Beyond-Network-HGNetBaseSession-_ReconnectCheckerTick0 = 239,
		Beyond-Network-HGNetBaseSession-TryCloseTcpIOWithTimeout0 = 241,
		Beyond-Network-HGNetBaseSession-TryConnectWithTimeout0 = 246,
		Beyond-Network-HGNetBaseSession-SessionCheckSignalAndSleep0 = 252,
		Beyond-Network-HGNetBaseSession-_ReadAndCheckMessageInSessionThread0 = 253,
		Beyond-Network-HGNetBaseSession-NetStatusChecker_Receive0 = 254,
		Beyond-Network-HGNetBaseSession-_SendAndCheckMessage0 = 255,
		Beyond-Network-HGNetBaseSession-NetStatusChecker_Sender0 = 256,
		Beyond-Network-HGNetBaseSession-OpenAutoReconnect0 = 258,
		Beyond-Network-HGNetSession-SetAutoReconnectToken0 = 259,
		Beyond-Network-HGNetSession-SessionConnectTimeoutCheckerTick0 = 260,
		Beyond-Network-HGNetSession-DoReconnectLogin0 = 261,
		Beyond-Network-HGNetSession-GetClientPublicKey0 = 262,
		Beyond-Network-HGNetSession-_CSLoginHelper_UpdateAppInfo0 = 263,
		Beyond-Network-HGNetSession-_GetOnlineResVersion0 = 264,
		Beyond-Network-HGNetSession-_GetPlatformID0 = 265,
		Beyond-Network-HGNetSession-_GetSDKEnv0 = 266,
		Beyond-Network-HGNetSession-_GetPayPlatform0 = 267,
		Beyond-Network-HGNetSession-_WriteMessageInSessionThread0 = 268,
		Beyond-Network-HGNetSession-_ReadMessageInSessionThread0 = 269,
		Beyond-Network-HGNetSession-_ApproximateLoginServerTime0 = 270,
		Beyond-Network-HGNetSession-_HandleLoginEncryp0 = 271,
		Beyond-Network-HGNetSession-_RSADecrypt0 = 272,
		Beyond-Network-HGNetSession-Start0 = 273,
		Beyond-Network-HGNetSession-OnApplicationPause0 = 274,
		Beyond-Network-HGNetSession-_FlushMergeQueueToSendQueue0 = 275,
		Beyond-Network-HGNetSession-LoginAsync0 = 276,
		Beyond-Network-HGNetSession-_SessionLoginThreadTask0 = 277,
		Beyond-Network-HGNetSessionLoginYield-GetRequest0 = 278,
		Beyond-Network-HGNetSessionLoginYield-SetConnectErrorError0 = 279,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectError0 = 280,
		Beyond-Network-HGNetSessionLoginYield-SetSucceed0 = 283,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Clear0 = 284,
		Beyond-Network-HGNetSessionLoginYield-SetNtfError0 = 285,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Set0 = 286,
		Beyond-Network-HGNetSessionLoginYield-SetTimeOutError0 = 287,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectTimeOut0 = 288,
		Beyond-Network-HGNetSession-StartMsgLoop0 = 289,
		Beyond-Network-HGNetSession-OnConnectedSucceed0 = 290,
		Beyond-Network-HGNetSession-OnReconnectTimesOver0 = 291,
		Beyond-Network-HGNetSession-NeedKeepConnect0 = 292,
		Beyond-Network-HGNetSession-CheckAndWriteReqMsg0 = 293,
		Beyond-Network-HGNetSession-ReadMessageInSessionThread0 = 294,
		Beyond-Network-HGNetSession-ClearRecvQueue0 = 295,
		Beyond-Network-HGNetSession-ClearSendQueue0 = 296,
		Beyond-Network-HGNetSession-GetPing0 = 297,
		Beyond-Network-HGNetSession-GetPingPassedTime0 = 298,
		Beyond-Network-HGNetSession-IsPingInProgress0 = 299,
		Beyond-Network-HGNetSession-ClearPingWDG0 = 300,
		Beyond-Network-HGNetSession-_HandleSpecialMessagePing0 = 301,
		Beyond-Network-HGNetSession-IsPingOut0 = 302,
		Beyond-Network-HGNetSession-PingSenderTick0 = 303,
		Beyond-Network-HGNetSession-InitClientRSAKey0 = 304,
		Beyond-Network-HGNetSession-ClearRSAKey0 = 305,
		Beyond-Network-HGNetSession-CheckAndDealRespMessages0 = 306,
		Beyond-Network-HGNetSession-_HandleSpecialMessageErrorCode0 = 307,
		Beyond-Network-HGNetSessionUtils-CheckErrorNeedsDisconnect0 = 308,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectIncr0 = 309,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectFull0 = 310,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectLogin0 = 311,
		Beyond-Network-HGNetSessionLoginYield-GetResponse0 = 312,
		Beyond-Network-HGNetSessionLoginYield-GetErrorCode0 = 313,
		Beyond-Network-HGNetSessionLoginYield-GetErrorDetails0 = 315,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorInvaild0 = 317,
		Beyond-Network-HGNetSessionConnectYield-GetCode0 = 318,
		Beyond-Network-HGNetSessionConnectYield-get_keepWaiting0 = 319,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Start0 = 320,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Connect0 = 321,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DNSCheck0 = 322,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close1 = 323,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close0 = 324,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-RemoveAutoReconnect0 = 325,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-CloseTCPMsgThreadTask0 = 326,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-ConnectAsync0 = 327,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-OnConnectAsyncEnd0 = 328,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-EnqueueSendMsg0 = 329,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetSendQueueMsgCount0 = 330,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-IncrementCSSeqID0 = 331,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-SetCSSeqID0 = 332,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetCSSeqID0 = 333,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetIO0 = 334,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-StartTCPMsgLoopThreadTask0 = 335,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_SessionThread0 = 336,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_ReconnectCheckerTick0 = 337,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-SessionCheckSignalAndSleep0 = 338,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Receive0 = 339,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Sender0 = 340,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-OpenAutoReconnect0 = 341,
		Beyond-Network-HGNetLogger-HGNetLogger-Log0 = 342,
		Beyond-Network-HGNetLogger-HGNetLogger-CheckLog0 = 343,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger0 = 344,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLoggerV20 = 345,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger1 = 346,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-get_instance0 = 347,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-ShutDown0 = 348,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-_CloseAndClear0 = 349,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-AddLog0 = 350,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-_FlushLocalLogQueue0 = 351,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled1 = 352,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-ConvertFromDLogger0 = 353,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled0 = 354,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-WriteNetLog0 = 355,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SendMessage0 = 356,
		Beyond-Network-HGNetLogger-HGNetLogger-Clear0 = 357,
		Beyond-Network-HGNetLogger-HGNetLogger-SetLogChannel0 = 358,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-Init0 = 359,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SetAutoReconnectToken0 = 360,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SetReconnectSuccessCallback0 = 362,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-OnApplicationPause0 = 363,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnApplicationPause0 = 364,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-SetRoleID0 = 365,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-SetNetLogMaskFromServer0 = 367,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-SetCloudLogControl0 = 368,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsLocalLogLevelEnabled0 = 369,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageType2Id0 = 370,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageId2Type0 = 371,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-TryGetMsgTypeByID0 = 372,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-Start0 = 373,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnConnectedSucceed0 = 374,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SendLogin0 = 375,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_WriteMessageInSessionThread0 = 377,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ReadMessageInSessionThread0 = 378,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndDealRespMessages0 = 379,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndWriteReqMsg0 = 380,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-NeedKeepConnect0 = 381,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-DoReconnectLogin0 = 382,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_GetConnectTimeoutTime0 = 383,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SessionConnectTimeoutCheckerTick0 = 384,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearPingWDG0 = 385,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-IsPingOut0 = 386,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-PingSenderTick0 = 387,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-InitClientRSAKey0 = 388,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRSAKey0 = 389,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRecvQueue0 = 390,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearSendQueue0 = 391,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnReconnectTimesOver0 = 392
	}
}
