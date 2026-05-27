/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
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

// Image 44: Network.Beyond.dll - Assembly: Network.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56119-56218
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Network
{
	public class DoubleQueue<T> // TypeDefIndex: 56126
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

	public class HGTcpClient : IDisposable // TypeDefIndex: 56127
	{
		// Fields
		private Socket m_ClientSocket; // 0x10
		private bool m_Active; // 0x18
		private NetworkStream m_DataStream; // 0x20
		private AddressFamily m_Family; // 0x28
		private bool m_CleanedUp; // 0x2C
	
		// Properties
		public Socket Client { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		protected bool Active { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public int Available { get => default; } // 0x00000001824CB8A0-0x00000001824CB930 
		public bool Connected { get => default; } // 0x00000001824CB510-0x00000001824CB700 
		public bool ExclusiveAddressUse { get => default; set {} } // 0x00000001892A28D0-0x00000001892A28F0 0x00000001892A2964-0x00000001892A2984
		public int ReceiveBufferSize { get => default; set {} } // 0x00000001892A2914-0x00000001892A2928 0x000000018293FA20-0x000000018293FA60
		public int SendBufferSize { get => default; set {} } // 0x00000001892A293C-0x00000001892A2950 0x000000018293FA60-0x000000018293FAA0
		public int ReceiveTimeout { get => default; set {} } // 0x00000001892A2928-0x00000001892A293C 0x00000001892A29B8-0x00000001892A29EC
		public int SendTimeout { get => default; set {} } // 0x00000001892A2950-0x00000001892A2964 0x000000018293FAA0-0x000000018293FAE0
		public LingerOption LingerState { get => default; set {} } // 0x000000018293E810-0x000000018293E890 0x00000001892A2984-0x00000001892A29B8
		public bool NoDelay { get => default; set {} } // 0x00000001892A28F0-0x00000001892A2914 0x000000018293FAE0-0x000000018293FB20
	
		// Constructors
		public HGTcpClient() {} // 0x000000018293F960-0x000000018293F970
		public HGTcpClient(string hostname, int port) {} // 0x00000001892A273C-0x00000001892A28A8
		internal HGTcpClient(Socket acceptedSocket) {} // 0x00000001892A28A8-0x00000001892A28D0
	
		// Methods
		[IDTag(1)]
		public void Connect(string hostname, int port) {} // 0x000000018293F080-0x000000018293F960
		[IDTag(2)]
		public void Connect(IPAddress address, int port) {} // 0x00000001892A2494-0x00000001892A2620
		[IDTag(0)]
		public void Connect(IPEndPoint remoteEP) {} // 0x000000018293E570-0x000000018293E5D0
		[IDTag(3)]
		public void Connect(IPAddress[] ipAddresses, int port) {} // 0x00000001892A2414-0x00000001892A2494
		[IDTag(0)]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) => default; // 0x000000018295A810-0x000000018295A890
		[IDTag(1)]
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) => default; // 0x00000001892A209C-0x00000001892A2144
		[IDTag(2)]
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state) => default; // 0x00000001892A1FF4-0x00000001892A209C
		public void EndConnect(IAsyncResult asyncResult) {} // 0x00000001838A6D30-0x00000001838A6D80
		[IDTag(0)]
		public System.Threading.Tasks.Task ConnectAsync(IPAddress address, int port) => default; // 0x00000001892A2144-0x00000001892A22AC
		[IDTag(1)]
		public System.Threading.Tasks.Task ConnectAsync(string host, int port) => default; // 0x000000018293DA80-0x000000018293DC50
		[IDTag(2)]
		public System.Threading.Tasks.Task ConnectAsync(IPAddress[] addresses, int port) => default; // 0x00000001892A22AC-0x00000001892A2414
		public NetworkStream GetStream() => default; // 0x00000001824D1590-0x00000001824D1780
		public void Close() {} // 0x0000000182944150-0x00000001829441B0
		[IDTag(0)]
		protected virtual void Dispose(bool disposing) {} // 0x0000000182943BC0-0x0000000182944150
		[IDTag(1)]
		public void Dispose() {} // 0x0000000182943B80-0x0000000182943BC0
		~HGTcpClient() {} // 0x00000001892A2620-0x00000001892A2694
		private void _Initialize() {} // 0x000000018293F970-0x000000018293FA20
		private int _NumericOption(SocketOptionLevel optionLevel, SocketOptionName optionName) => default; // 0x00000001892A2694-0x00000001892A273C
	}

	public interface INetIO : IDisposable // TypeDefIndex: 56128
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

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class NetMsgHandlerAttribute : Attribute // TypeDefIndex: 56129
	{
		// Fields
		public readonly System.Type msgType; // 0x10
	
		// Constructors
		public NetMsgHandlerAttribute(System.Type t) {} // 0x000000018426FEE0-0x000000018426FEF0
		public NetMsgHandlerAttribute() {} // 0x00000001835ACAA0-0x00000001835ACAC0
	
		// Methods
		public System.Type GetMsgType(MethodInfo annotatedMethod) => default; // 0x0000000182D5B4A0-0x0000000182D5B590
	}

	public delegate void NetResponseHandler([IsReadOnly] in NetResponse msg); // TypeDefIndex: 56130; 0x0000000182149960-0x0000000182149970

	public delegate void NetMessageHandle<in T>(T message); // TypeDefIndex: 56131; 0x00000000-0x00000000

	public interface INetBusResponseListener // TypeDefIndex: 56132
	{
		// Methods
		void UpdateMsgTime(NetResponse resp);
	}

	public struct NetRequest // TypeDefIndex: 56133
	{
		// Fields
		public ulong csSeqID; // 0x00
		public int mergeNum; // 0x08
		public IMessage msg; // 0x10
	}

	public struct NetResponse // TypeDefIndex: 56134
	{
		// Fields
		public static NetResponse EMPTY; // 0x00
		public IMessage headMsg; // 0x00
		public IMessage msgBody; // 0x08
		public bool isPacked; // 0x10
		public long recvTimestamp; // 0x18
	
		// Properties
		public Header logHead { get => default; set {} } // 0x0000000182944C20-0x0000000182944CC0 0x00000001842715A0-0x00000001842715A8
		public CSHead csHead { get => default; set {} } // 0x00000001824C8040-0x00000001824C8290 0x00000001842715A0-0x00000001842715A8
		public int msgId { get => default; } // 0x00000001824C7FC0-0x00000001824C8040 
		public ulong csSeqId { get => default; } // 0x00000001824C7260-0x00000001824C7660 
		public ulong scSeqId { get => default; } // 0x00000001824C71E0-0x00000001824C7260 
	
		// Constructors
		static NetResponse() {
			EMPTY = default;
		} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class MessageHandleWrapper // TypeDefIndex: 56135
	{
		// Constructors
		protected MessageHandleWrapper() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void HandleMessage(IMessage msg);
	}

	public class MessageHandleWrapper<T> : MessageHandleWrapper // TypeDefIndex: 56136
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

	public class NetBus : ExplicitSingleton<NetBus> // TypeDefIndex: 56140
	{
		// Fields
		private readonly Dictionary<int, NetResponseHandler> m_msgHandlers; // 0x10
		private readonly Dictionary<int, List<HandlerEntry>> m_msgWithSeqNumHandlers; // 0x18
		private readonly Dictionary<int, MessageHandleWrapper> m_msgHdlWrappers; // 0x20
		private HGNetSession m_netSession; // 0x28
		private static List<NetResponseHandler> s_handlersToCall; // 0x00
	
		// Properties
		public UIBusSender uiSender { get; } // 0x0000000181003830-0x0000000181003840 
		public TeleportMaskSender teleportMaskSender { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public DisposableBusSender defaultSender { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public Special2BusSender s2Sender { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public InteractiveBusSender interactiveSender { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public FrequencyControlBusSender frequencyControlSender { get; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public int currentSessionID { get => default; } // 0x00000001892A3868-0x00000001892A3904 
	
		// Nested types
		private class HandlerEntry // TypeDefIndex: 56137
		{
			// Fields
			public NetResponseHandler handler; // 0x10
	
			// Constructors
			public HandlerEntry() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class ResultHandler : IDisposable // TypeDefIndex: 56138
		{
			// Fields
			private bool m_ignoreSeq; // 0x10
			private ListDict<SCMessageID, object> m_responseTokens; // 0x18
			private ListDict<SCMessageID, NetResponseHandler> m_responseHandlers; // 0x20
	
			// Properties
			public bool isDisposed { get; private set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
			internal ulong cachedSeqNum { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000181003840-0x0000000181003850
			public int sessionID { get; internal set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
	
			// Constructors
			public ResultHandler() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void SetIgnoreSeq(bool ignoreSeq) {} // 0x00000001892A6330-0x00000001892A6384
			public ResultHandler OnResponse(SCMessageID msgId, NetResponseHandler handler) => default; // 0x0000000182F113B0-0x0000000182F11730
			public void Dispose() {} // 0x0000000182F10A10-0x0000000182F113B0
			private void _HandleMessage([IsReadOnly] in NetResponse msg) {} // 0x0000000182F106E0-0x0000000182F10830
		}
	
		public abstract class Sender // TypeDefIndex: 56139
		{
			// Constructors
			protected Sender() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public abstract ResultHandler Send(IMessage msg);
			public abstract void OnNetShutDown();
			protected ResultHandler DoSend(IMessage message) => default; // 0x0000000182946310-0x00000001829463A0
			protected void DoListen(SCMessageID msgId, NetResponseHandler handler) {} // 0x00000001892A6384-0x00000001892A6424
			protected void DoUnListen(SCMessageID msgId, NetResponseHandler handler) {} // 0x00000001892A6424-0x00000001892A64C4
		}
	
		// Constructors
		public NetBus() {} // 0x000000018345E390-0x000000018345E610
		static NetBus() {} // 0x0000000183CE3790-0x0000000183CE3820
	
		// Methods
		public bool IsBusBusy() => default; // 0x00000001892A3408-0x00000001892A3450
		public void Setup(HGNetSession session) {} // 0x0000000182F0F3C0-0x0000000182F0F400
		public void Send(IMessage msg) {} // 0x00000001829464A0-0x0000000182946500
		public void RegisterMessageHandler(int msgId, MessageHandleWrapper handler) {} // 0x00000001826AD5F0-0x00000001826AD6D0
		public void UnRegisterMessageHandler(int msgId) {} // 0x00000001892A3450-0x00000001892A34D4
		public void HandleMessageTime(NetResponse response) {} // 0x00000001892A30A0-0x00000001892A3118
		public void HandleMessage(NetResponse response) {} // 0x00000001892A3118-0x00000001892A3408
		private bool _ValidateSession() => default; // 0x0000000182946460-0x00000001829464A0
		public void OnNetClientShutDown() {} // 0x0000000182F0F090-0x0000000182F0F130
		private ResultHandler _SendWithResult(IMessage msg) => default; // 0x00000001829463A0-0x0000000182946460
		private void _Listen(int msgId, NetResponseHandler handler) {} // 0x00000001892A3608-0x00000001892A373C
		private void _UnListen(int msgId, NetResponseHandler handler) {} // 0x00000001892A373C-0x00000001892A3868
		private object _ListenWithSeqNum(int msgId, NetResponseHandler callback) => default; // 0x00000001892A34D4-0x00000001892A3608
		private void _UnListenWithSeqNum(int msgId, object token) {} // 0x0000000182F11730-0x0000000182F11860
	}

	public class Special2BusSender : DisposableBusSender, INetBusResponseListener // TypeDefIndex: 56141
	{
		// Fields
		public Dictionary<ulong, double> sendedMsgWithTime; // 0x20
		public double minSendTime; // 0x28
		private float m_maxWaitTime; // 0x30
	
		// Properties
		public virtual bool isBusBusy { get => default; } // 0x0000000182998950-0x0000000182998980 
	
		// Constructors
		public Special2BusSender() {} // 0x0000000182DF5160-0x0000000182DF5200
	
		// Methods
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x0000000183924E20-0x00000001839254F0
		public void UpdateStartBlockTime() {} // 0x00000001892A6650-0x00000001892A6788
		public override void OnNetShutDown() {} // 0x0000000182F0FC70-0x0000000182F0FCB0
		public override void Dispose() {} // 0x00000001892A6544-0x00000001892A659C
		private void _ClearSendTime() {} // 0x0000000182F11860-0x0000000182F118D0
		public void UpdateMsgTime(NetResponse resp) {} // 0x00000001892A65A4-0x00000001892A6650
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0) => default; // 0x000000018929FD28-0x000000018929FD30
		public void __iFixBaseProxy_OnNetShutDown() {} // 0x00000001892A659C-0x00000001892A65A4
		public void __iFixBaseProxy_Dispose() {} // 0x000000018929FD20-0x000000018929FD28
	}

	public class InteractiveBusSender : Special2BusSender // TypeDefIndex: 56142
	{
		// Fields
		private float m_maxWaitTime; // 0x38
	
		// Properties
		public override bool isBusBusy { get => default; } // 0x0000000182998920-0x0000000182998950 
	
		// Constructors
		public InteractiveBusSender() {} // 0x0000000184276358-0x0000000184276368
	}

	public class DisposableBusSender : NetBus.Sender, IDisposable // TypeDefIndex: 56143
	{
		// Fields
		private readonly HashSet<NetBus.ResultHandler> m_resultHandlers; // 0x10
	
		// Properties
		public bool isDisposed { get; private set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
	
		// Constructors
		public DisposableBusSender() {} // 0x0000000182DF53B0-0x0000000182DF5430
	
		// Methods
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x0000000182946270-0x0000000182946310
		public override void OnNetShutDown() {} // 0x0000000182F10830-0x0000000182F10870
		public virtual void Dispose() {} // 0x000000018929F5F0-0x000000018929F644
		private void _Clear() {} // 0x0000000182F10870-0x0000000182F10A10
	}

	public class NetworkMaskConfigHolder // TypeDefIndex: 56144
	{
		// Fields
		public Dictionary<CSMessageID, SCMessageID> msgs; // 0x10
	
		// Constructors
		public NetworkMaskConfigHolder() {} // 0x000000018345E760-0x000000018345E7E0
	
		// Methods
		public void Init() {} // 0x000000018345E7E0-0x000000018345EFD0
		public void Dispose() {} // 0x00000001892A5A90-0x00000001892A5B08
	}

	public class UIBusSender : DisposableBusSender // TypeDefIndex: 56146
	{
		// Fields
		private HashSet<int> m_maskKeys; // 0x28
	
		// Properties
		public NetworkMaskConfigHolder config { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public UIBusSender() {} // 0x000000018345E690-0x000000018345E760
	
		// Methods
		public override void Dispose() {} // 0x00000001892A7284-0x00000001892A7478
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x00000001892A7478-0x00000001892A77C8
		public override void OnNetShutDown() {} // 0x0000000182F0F540-0x0000000182F0F820
		public void __iFixBaseProxy_Dispose() {} // 0x000000018929FD20-0x000000018929FD28
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0) => default; // 0x000000018929FD28-0x000000018929FD30
		public void __iFixBaseProxy_OnNetShutDown() {} // 0x00000001892A659C-0x00000001892A65A4
	}

	public class TeleportMaskSender : DisposableBusSender // TypeDefIndex: 56148
	{
		// Fields
		private HashSet<int> m_maskKeys; // 0x20
	
		// Constructors
		public TeleportMaskSender() {} // 0x000000018345E610-0x000000018345E690
	
		// Methods
		public override void Dispose() {} // 0x00000001892A68D4-0x00000001892A6AAC
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x0000000182F0FF40-0x0000000182F10250
		public override void OnNetShutDown() {} // 0x0000000182F0F820-0x0000000182F0FB00
		public void __iFixBaseProxy_Dispose() {} // 0x000000018929FD20-0x000000018929FD28
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0) => default; // 0x000000018929FD28-0x000000018929FD30
		public void __iFixBaseProxy_OnNetShutDown() {} // 0x00000001892A659C-0x00000001892A65A4
	}

	public class FrequencyControlBusSender : DisposableBusSender // TypeDefIndex: 56150
	{
		// Fields
		private readonly Dictionary<CSMessageID, Queue<double>> m_lastSendTime; // 0x20
		private List<IMessage> m_waitingSendMsgs; // 0x28
		private List<Action<int>> m_onError; // 0x30
		private int m_loopId; // 0x38
	
		// Constructors
		public FrequencyControlBusSender() {} // 0x0000000183238050-0x0000000183238220
	
		// Methods
		private void _TrySendWaitingMsg() {} // 0x0000000183456440-0x00000001834564F0
		[IDTag(1)]
		public override NetBus.ResultHandler Send(IMessage msg) => default; // 0x000000018929F7B0-0x000000018929F820
		[IDTag(0)]
		public NetBus.ResultHandler Send(IMessage msg, bool needAddToWaitingList, Action<int> onError = null, Action onWait = null) => default; // 0x000000018929F820-0x000000018929FD20
		public override void Dispose() {} // 0x000000018929F6F8-0x000000018929F7B0
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0) => default; // 0x000000018929FD28-0x000000018929FD30
		public void __iFixBaseProxy_Dispose() {} // 0x000000018929FD20-0x000000018929FD28
	}

	[Serializable]
	public class ServerDesc // TypeDefIndex: 56151
	{
		// Fields
		public string name; // 0x10
		public string addr; // 0x18
		public int port; // 0x20
	
		// Constructors
		public ServerDesc() {} // 0x000000018333BE60-0x000000018333BEC0
	}

	[Serializable]
	public class ServerList // TypeDefIndex: 56152
	{
		// Fields
		public List<ServerDesc> servers; // 0x10
	
		// Constructors
		public ServerList() {} // 0x0000000183CFC3F0-0x0000000183CFC470
	}

	public class ServerConfig // TypeDefIndex: 56153
	{
		// Fields
		public string serverName; // 0x10
		public string uid; // 0x18
		public bool checkDev; // 0x20
	
		// Constructors
		public ServerConfig() {} // 0x0000000183D21020-0x0000000183D21080
	
		// Methods
		public bool IsSame(ServerConfig other) => default; // 0x00000001892A64C4-0x00000001892A6544
	}

	public class HostData // TypeDefIndex: 56154
	{
		// Fields
		public string host; // 0x10
		public int port; // 0x18
		public double delay; // 0x20
	
		// Constructors
		public HostData() {} // 0x000000018315C2B0-0x000000018315C300
	}

	public class NetConfig // TypeDefIndex: 56155
	{
		// Fields
		public List<HostData> hosts; // 0x10
	
		// Constructors
		public NetConfig() {} // Dummy constructor
		public NetConfig(List<HostData> hosts) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public static class NetConsts // TypeDefIndex: 56156
	{
		// Fields
		public static readonly string NETMASK_CONFIG_PATH; // 0x00
		public static readonly string NETMASK_PREFAB_PATH; // 0x08
	
		// Constructors
		static NetConsts() {} // 0x0000000183CDF500-0x0000000183CDF5A0
	}

	public interface INetworkSystem : ILuaCallCSharp // TypeDefIndex: 56157
	{
		// Methods
		void OnReConnect();
		void SendMsg(IMessage msg, Action<int> onError);
	}

	public class NetUtil // TypeDefIndex: 56160
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
	
		// Constructors
		public NetUtil() {} // 0x000000018350B670-0x000000018350B680
		static NetUtil() {} // 0x00000001837063D0-0x00000001837065C0
	
		// Methods
		public static void RegisterSCMessage(int msgId, System.Type msgType) {} // 0x0000000182C34270-0x0000000182C34400
		public static void RegisterCSMessage(int msgId, System.Type msgType) {} // 0x0000000182C33D50-0x0000000182C33E80
		public static int GetSCMsgIdByType(System.Type msgType) => default; // 0x00000001826AD6D0-0x00000001826AD780
		public static System.Type GetSCMsgTypeById(int msgId) => default; // 0x00000001892A3AC4-0x00000001892A3B74
		public static int GetCSMsgIdByType(System.Type msgType) => default; // 0x00000001832BA2C0-0x00000001832BA370
		private static void _GenMessageName2ValuePair<T>(Dictionary<string, int> dic)
			where T : Enum {}
		public static void FastRegisterMessage() {} // 0x0000000182C33E80-0x0000000182C34270
		public static bool GetNetMessageFromDataBytes(Span<byte> headBytes, byte[] bodyBuffer, int offset, int bodyLen, byte[] packedbuffer, out NetResponse response) {
			response = default;
			return default;
		} // 0x00000001829D2940-0x00000001829D3B10
		public static int SerializeHeadMessage(IMessage msg, ulong upSeqid, int bodyLen, int crc32, byte[] buffer, int offset = 0 /* Metadata: 0x01FD7D19 */) => default; // 0x00000001824D2BE0-0x00000001824D2DD0
		public static int SerializeBodyMessage(IMessage msg, byte[] buffer, out int crc32, int offset = 0 /* Metadata: 0x01FD7D1A */) {
			crc32 = default;
			return default;
		} // 0x00000001892A3B74-0x00000001892A3D64
		public static void AutoRegisterMessageHandlers(object target) {} // 0x0000000182D5B260-0x0000000182D5B360
		public static void AutoUnRegisterMessageHandlers(object target) {} // 0x00000001892A3984-0x00000001892A3AC4
		private static void _ForeachMessageHandlers(object target, Action<System.Type, MethodInfo> doFunc) {} // 0x0000000182D5B360-0x0000000182D5B4A0
	}

	public static class NetworkFrequencyConfig // TypeDefIndex: 56162
	{
		// Fields
		public static SerializeFieldDictionary<int, NetworkFrequency> msgs; // 0x00
	
		// Nested types
		public class NetworkFrequency // TypeDefIndex: 56161
		{
			// Fields
			public System.Type type; // 0x10
			public float second; // 0x18
			public int maxCount; // 0x1C
	
			// Constructors
			public NetworkFrequency() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		static NetworkFrequencyConfig() {} // 0x00000001892A3D64-0x00000001892A5A90
	}

	public class NetworkMask : Singleton<NetworkMask> // TypeDefIndex: 56164
	{
		// Fields
		private TickFunction m_preTickFunction; // 0x10
		private int m_nextKey; // 0x18
		public GameObject maskObj; // 0x20
		public GameObject decoObj; // 0x28
		private FAssetProxyHandle m_handle; // 0x30
		private Action<bool> m_onNetMaskChanged; // 0x48
		private bool m_isNetReconnecting; // 0x52
		private const string DECO_NAME = "Deco"; // Metadata: 0x01FD7D27
		private List<MaskInfo> m_masks; // 0x58
	
		// Properties
		public bool showingMask { get; private set; } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
		public bool showingDeco { get; private set; } // 0x0000000183D518F0-0x0000000183D51900 0x0000000183D51900-0x0000000183D51910
	
		// Nested types
		public class MaskInfo // TypeDefIndex: 56163
		{
			// Fields
			public int key; // 0x10
			public string name; // 0x18
			public float startTime; // 0x20
			public float delayTime; // 0x24
			public float timeoutTime; // 0x28
	
			// Properties
			public float endTime { get => default; } // 0x0000000183D713D0-0x0000000183D713E0 
			public float showDecoTime { get => default; } // 0x0000000183D713E0-0x0000000183D713F0 
	
			// Constructors
			public MaskInfo() {} // 0x0000000183D713C0-0x0000000183D713D0
		}
	
		// Constructors
		private NetworkMask() {} // 0x0000000183807DC0-0x0000000183807E60
	
		// Methods
		protected void OnInit() {} // 0x0000000183807E60-0x00000001838081A0
		protected void OnUnInit() {} // 0x00000001892A5BC8-0x00000001892A5C60
		public void Release() {} // 0x00000001892A5C60-0x00000001892A5D70
		private void _OnSwitchLanguage() {} // 0x00000001892A5E88-0x00000001892A6160
		private void _CreateTickFunction() {} // 0x00000001838081A0-0x0000000183808280
		private void _ClearTickFunction() {} // 0x00000001892A5E24-0x00000001892A5E88
		public void PreTick(float deltaTime) {} // 0x0000000183017340-0x0000000183017410
		private int _GetKey() => default; // 0x00000001830171C0-0x00000001830171F0
		[IDTag(1)]
		public int AddMask(CSMessageID msgId, float timeoutTime = 10f /* Metadata: 0x01FD7D1B */) => default; // 0x00000001892A5B08-0x00000001892A5BC8
		[IDTag(0)]
		public int AddMask(string name, float timeoutTime = 10f /* Metadata: 0x01FD7D1F */, float delayTime = 0.5f /* Metadata: 0x01FD7D23 */) => default; // 0x00000001830170C0-0x00000001830171C0
		public void RemoveMask(int key) {} // 0x0000000183017270-0x0000000183017340
		public void SetIsNetReconnecting(bool isReconnecting) {} // 0x0000000183D713F0-0x0000000183D71400
		private void _UpdateMaskState() {} // 0x0000000183017410-0x0000000183017610
		public void ListenOnNetMaskChanged(Action<bool> action) {} // 0x0000000183A2FE20-0x0000000183A2FE90
		public void UnListenOnNetMaskChanged(Action<bool> action) {} // 0x00000001892A5D70-0x00000001892A5E24
	}

	[CreateAssetMenu(fileName = "NetworkMaskConfig", menuName = "Beyond/Network/NetworkMaskConfig", order = 1)]
	public class NetworkMaskConfig : ScriptableObject // TypeDefIndex: 56166
	{
		// Fields
		[SerializeField]
		public SerializeFieldDictionary<CSMessageID, SCMessageID> msgs; // 0x18
		[SerializeField]
		public List<Config> configs; // 0x20
	
		// Nested types
		[Serializable]
		public class Config // TypeDefIndex: 56165
		{
			// Fields
			[SerializeField]
			public string key; // 0x10
			[SerializeField]
			public SerializeFieldDictionaryPaired<CSMessageID, SCMessageID> messages; // 0x18
	
			// Constructors
			public Config() {} // 0x0000000183CA7600-0x0000000183CA7680
		}
	
		// Constructors
		public NetworkMaskConfig() {} // 0x0000000183C8A0F0-0x0000000183C8A1C0
	}

	public static class NetworkUrls // TypeDefIndex: 56168
	{
		// Fields
		public const string URL_GET_SPLIT = "/"; // Metadata: 0x01FD7D2C
	
		// Nested types
		private enum EUrlType // TypeDefIndex: 56167
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
		public static string RemoteConfigUrl() => default; // 0x0000000182C37520-0x0000000182C37580
		public static string ResourceRootUrlDev(string version) => default; // 0x00000001892A6288-0x00000001892A6330
		public static string ServerListUrl() => default; // 0x0000000182F42910-0x0000000182F42940
		public static string AgeTipsUrl() => default; // 0x00000001892A6160-0x00000001892A61F4
		public static string GovUrl() => default; // 0x00000001892A61F4-0x00000001892A6288
		public static string LauncherUrl() => default; // 0x0000000182C3DFE0-0x0000000182C3E060
		private static string _SelectUrl(string urlInConfig, EUrlType urlType) => default; // 0x0000000182C3F990-0x0000000182C3FA20
		private static string _GetUrlFromLocal(EUrlType type) => default; // 0x0000000182F42940-0x0000000182F429F0
	}

	public class TcpIO : INetIO // TypeDefIndex: 56169
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
		public const int SEND_HEAD_BUFFER_LENGTH = 256; // Metadata: 0x01FD7D35
		public static int s_MAX_SEND_SIZE; // 0x00
	
		// Constructors
		public TcpIO() {} // 0x000000018350B670-0x000000018350B680
		static TcpIO() {} // 0x0000000183D43AA0-0x0000000183D43AE0
	
		// Methods
		public void Connect(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize) {} // 0x000000018293E650-0x000000018293E810
		public System.Threading.Tasks.Task ConnectAsync(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize) => default; // 0x000000018293DC50-0x000000018293DE60
		public bool IsAuthed() => default; // 0x00000001824CC140-0x00000001824CC200
		public void MarkAuthed() {} // 0x0000000182944CC0-0x0000000182944CF0
		public void EnableCryptStream(byte[] key, byte[] iv) {} // 0x00000001839B3E60-0x00000001839B40A0
		public EndPoint GetEndPoint() => default; // 0x00000001892A6788-0x00000001892A67F8
		public void Close() {} // 0x00000001829436C0-0x0000000182943B80
		public void TestCloseNetIO(bool bIsTestReconnectFailed) {} // 0x00000001892A67F8-0x00000001892A6864
		public void TestDropNetIO(bool bIsTestDropSC, bool bIsTestDropCS) {} // 0x00000001892A6864-0x00000001892A68D4
		public bool IsConnected() => default; // 0x00000001824CB1A0-0x00000001824CB3A0
		public void WriteData(byte[] data, int offset, int len) {} // 0x00000001824D1080-0x00000001824D1320
		public void WriteCryptoData(byte[] data, int offset, int len) {} // 0x00000001824D3190-0x00000001824D32B0
		public byte[] GetSendHeadBuffer() => default; // 0x00000001824D3160-0x00000001824D3190
		public byte[] GetSendBuffer() => default; // 0x00000001824D2290-0x00000001824D22C0
		public byte[] GetReceiveBuffer() => default; // 0x00000001824CBF80-0x00000001824CC140
		public void ClearReceiveBufferOffset() {} // 0x0000000183199FF0-0x000000018319A020
		public int GetReceiveBufferOffset() => default; // 0x00000001824CB3A0-0x00000001824CB460
		public void SkipReceiveBufferOffset(int len) {} // 0x00000001831681D0-0x0000000183168210
		public int ReadData(byte[] buffer, int offset, int len) => default; // 0x00000001824D1450-0x00000001824D1590
		public int ReadCryptoData(byte[] buffer, int offset, int len) => default; // 0x00000001824D1320-0x00000001824D1450
		public int Available() => default; // 0x00000001824CB700-0x00000001824CB8A0
		public void Dispose() {} // 0x0000000182943610-0x0000000182943650
		~TcpIO() {} // 0x0000000182943480-0x0000000182943610
	}

	public static class HttpSender // TypeDefIndex: 56188
	{
		// Fields
		public const string CONTENT_TYPE_JSON = "application/json"; // Metadata: 0x01FD7D37
		public const string CONTENT_ENCODING_GZIP = "gzip"; // Metadata: 0x01FD7D48
		public const int ERROR_CODE_TIMEOUT = 10000; // Metadata: 0x01FD7D4D
		public const int ERROR_CODE_DNS_FAILED = 11000; // Metadata: 0x01FD7D51
		public const int ERROR_CODE_DESERIALIZE = 20000; // Metadata: 0x01FD7D55
		public const float TIMEOUT_DEFAULT = 20f; // Metadata: 0x01FD7D59
		private const int OPT_GET = 1; // Metadata: 0x01FD7D5D
		private const int OPT_POST = 2; // Metadata: 0x01FD7D5E
	
		// Nested types
		public enum ErrorType // TypeDefIndex: 56170
		{
			NONE = 0,
			TIMEOUT = 1,
			DNS_FAILED = 2,
			CANCELED = 3,
			INTERNAL = 4
		}
	
		public class Cancellation // TypeDefIndex: 56171
		{
			// Fields
			private bool m_isCancelled; // 0x10
	
			// Events
			public event Action OnCancelInvoked;
	
			// Constructors
			public Cancellation() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Cancel() {} // 0x000000018929F414-0x000000018929F474
			public bool IsCanceled() => default; // 0x000000018929F474-0x000000018929F4C8
		}
	
		public struct FGetOptions // TypeDefIndex: 56172
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
			} // 0x000000018350B670-0x000000018350B680
		}
	
		public struct FPostOptions // TypeDefIndex: 56173
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
			} // 0x000000018350B670-0x000000018350B680
		}
	
		private struct FSendFunc // TypeDefIndex: 56174
		{
			// Fields
			public string url; // 0x00
			public int opt; // 0x08
			public FGetOptions optionsGET; // 0x10
			public FPostOptions optionsPOST; // 0x30
			public bool editorOnly; // 0x50
	
			// Methods
			public UnityWebRequest Invoke() => default; // 0x0000000182C47510-0x0000000182C47590
			public Cancellation GetCancellation() => default; // 0x0000000182C474C0-0x0000000182C47510
			public string GetOptMethod() => default; // 0x000000018929F644-0x000000018929F6F8
		}
	
		public class Result // TypeDefIndex: 56175
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
			public Result() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class TypedResult : Result // TypeDefIndex: 56176
		{
			// Fields
			public object respObject; // 0x50
			public bool isDeserializeFailed; // 0x58
	
			// Properties
			public System.Type respType { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
			// Constructors
			public TypedResult() {} // Dummy constructor
			public TypedResult(System.Type respType) {} // 0x0000000182692290-0x00000001826922A0
		}
	
		public class Result<TResp> : TypedResult // TypeDefIndex: 56177
			where TResp : class
		{
			// Constructors
			public Result() {}
	
			// Methods
			public TResp GetRespObject() => default;
		}
	
		// Methods
		[IDTag(1)]
		[IteratorStateMachine(typeof(_YieldSendGet_d__16))]
		public static IEnumerator YieldSendGet(string url, FGetOptions options, Misc.ObjectRef resultRef) => default; // 0x0000000182C36C00-0x0000000182C36CB0
		[IteratorStateMachine(typeof(_YieldSendGet_d__17<TResp>))]
		public static IEnumerator YieldSendGet<TResp>(string url, FGetOptions options, Misc.ObjectRef resultRef)
			where TResp : class => default;
		[IDTag(0)]
		[IteratorStateMachine(typeof(_YieldSendGet_d__18))]
		public static IEnumerator YieldSendGet(string url, FGetOptions options, System.Type respType, Misc.ObjectRef resultRef) => default; // 0x0000000182F42BA0-0x0000000182F42C80
		[IDTag(1)]
		[IteratorStateMachine(typeof(_YieldSendPost_d__19))]
		public static IEnumerator YieldSendPost(string url, FPostOptions options, Misc.ObjectRef resultRef) => default; // 0x00000001892A2C84-0x00000001892A2D6C
		[IteratorStateMachine(typeof(_YieldSendPost_d__20<TResp>))]
		public static IEnumerator YieldSendPost<TResp>(string url, FPostOptions options, Misc.ObjectRef resultRef)
			where TResp : class => default;
		[IDTag(0)]
		[IteratorStateMachine(typeof(_YieldSendPost_d__21))]
		public static IEnumerator YieldSendPost(string url, FPostOptions options, System.Type respType, Misc.ObjectRef resultRef) => default; // 0x00000001839DC990-0x00000001839DCA60
		public static WaitForAsyncTask<Result> WaitForSendPost(string url, FPostOptions options) => default; // 0x00000001892A2B88-0x00000001892A2C84
		[IDTag(1)]
		public static WaitForAsyncTask<Result> WaitForSendGet(string url) => default; // 0x00000001892A29EC-0x00000001892A2A8C
		[IDTag(0)]
		public static WaitForAsyncTask<Result> WaitForSendGet(string url, FGetOptions options) => default; // 0x00000001892A2A8C-0x00000001892A2B88
		public static WaitForAsyncTask<Result<TResp>> WaitForSendPost<TResp>(string url, FPostOptions options)
			where TResp : class => default;
		public static WaitForAsyncTask<Result<TResp>> WaitForSendGet<TResp>(string url, FGetOptions options)
			where TResp : class => default;
		public static int GetGeneralErrorCode(Result result, out bool hasError) {
			hasError = default;
			return default;
		} // 0x0000000182F429F0-0x0000000182F42A60
		[IDTag(0)]
		[IteratorStateMachine(typeof(__YieldSendHttpRequest_d__28))]
		private static IEnumerator _YieldSendHttpRequest(Result result, FSendFunc sendFunc) => default; // 0x00000001826921B0-0x0000000182692290
		[IDTag(1)]
		[IteratorStateMachine(typeof(__YieldSendHttpRequest_d__29))]
		private static IEnumerator _YieldSendHttpRequest(Misc.ObjectRef resultRef, FSendFunc sendFunc, System.Type respType) => default; // 0x0000000183765670-0x0000000183765760
		private static WaitForAsyncTask<Result> _WaitForSendHttpRequest(FSendFunc sendFunc) => default; // 0x00000001892A2ED8-0x00000001892A30A0
		private static WaitForAsyncTask<Result<TResp>> _WaitForSendHttpRequest<TResp>(FSendFunc sendFunc)
			where TResp : class => default;
		private static void _StartWebRequestTask(Result result, FSendFunc sendFunc) {} // 0x00000001838CEAA0-0x00000001838CEC10
		private static void _WaitForServiceDone(Result result) {} // 0x0000000183C90670-0x0000000183C906C0
		private static UnityWebRequest _CreateWebRequestGET(string url, FGetOptions options) => default; // 0x0000000182C47800-0x0000000182C47DF0
		private static UnityWebRequest _CreateWebRequestPOST(string url, FPostOptions options) => default; // 0x0000000182C47F30-0x0000000182C48630
		private static void _SetHttpResult(Result result, UnityWebRequest request) {} // 0x0000000182C47610-0x0000000182C47720
		private static void _DeserializeTypedResult(TypedResult result) {} // 0x0000000182692ED0-0x0000000182692F80
		private static void _DebugOnlyProfileResult(Result result, FSendFunc sendFunc) {} // 0x00000001892A2D6C-0x00000001892A2E04
		private static void _MarkResultAsException(Result result, Exception ex) {} // 0x00000001892A2E04-0x00000001892A2ED8
	}

	public class CircularBuffer<T> : IReadOnlyList<T> // TypeDefIndex: 56190
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
	
		// Constructors
		public CircularBuffer() {} // Dummy constructor
		public CircularBuffer(int capacity) {}
		public CircularBuffer(int capacity, T[] items) {}
	
		// Methods
		public void Clear() {}
		[IteratorStateMachine(typeof(_GetEnumerator_d__18))]
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
		private void _ThrowIfEmpty(string message = "Cannot access an empty buffer." /* Metadata: 0x01FD7D64 */) {}
		private void _Increment(ref int index) {}
		private void _Decrement(ref int index) {}
		private int _InternalIndex(int index) => default;
		private ArraySegment<T> _ArrayOne() => default;
		private ArraySegment<T> _ArrayTwo() => default;
	}

	public abstract class HGNetBaseSession // TypeDefIndex: 56199
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
		private const int MAX_RECYCLE_QUEUE_COUNT = 1000; // Metadata: 0x01FD7D83
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
		protected HGNetSessionConnectYield m_lastAsyncConnectHandle; // 0x90
		protected EHGNetSessionState m_state; // 0x98
		private EHGNetSessionReconnectState m_reconnectState; // 0x99
		protected double m_startReconnectTimeMS; // 0xA0
		protected int m_closeErrorCode; // 0xA8
		public static bool s_applicationIsPaused; // 0x18
		private long m_clientLastReceiveMsgMilliTs; // 0xB0
		private long m_clientLastSendMsgMilliTs; // 0xB8
	
		// Properties
		public int sessionID { get; protected set; } // 0x0000000183D4F3D0-0x0000000183D4F3E0 0x0000000183D4F420-0x0000000183D4F430
		protected EHGNetSessionReconnectState reconnectState { get; set; } // 0x0000000183D6E080-0x0000000183D6E090 0x0000000182944CF0-0x0000000182944DB0
		public bool isRunning { get; } // 0x00000001824C6600-0x00000001824C6690 
		public bool isConnecting { get; } // 0x00000001892A0130-0x00000001892A013C 
		public bool isRunningAndConnected { get; } // 0x00000001824C6690-0x00000001824C6D80 
		public bool isReconnecting { get; } // 0x00000001824C6FA0-0x00000001824C6FB0 
		public int closeErrorCode { get; } // 0x0000000183D51860-0x0000000183D51870 
		public bool isAutoReconnect { get; } // 0x0000000183D4F800-0x0000000183D4F810 
		public int maxRecycleQueueCount { get; } // 0x0000000183D5A950-0x0000000183D5A960 
	
		// Constructors
		protected HGNetBaseSession() {} // 0x0000000182F0EDC0-0x0000000182F0EF20
		static HGNetBaseSession() {} // 0x0000000183CC52F0-0x0000000183CC53A0
	
		// Methods
		public virtual void Start() {} // 0x00000001829430F0-0x00000001829432A0
		public virtual bool Connect(string serverIp, int serverPort, bool forceReconnect) => default; // 0x000000018929FD30-0x00000001892A0064
		public virtual bool ConnectAsync(string serverIp, int serverPort, bool forceReconnect, out HGNetSessionConnectYield yieldHandle) {
			yieldHandle = default;
			return default;
		} // 0x000000018293D1B0-0x000000018293D620
		public void OnConnectAsyncEnd(System.Threading.Tasks.Task completedTask, INetIO tcpIO) {} // 0x00000001838A22D0-0x00000001838A2420
		protected abstract void OnConnectedSucceed(INetIO tcpIO);
		private void _DNSCheck(string serverIp) {} // 0x000000018293DFE0-0x000000018293E0F0
		public virtual void Close(ENetCloseReason netCloseReason) {} // 0x000000018267B3E0-0x000000018267B420
		[IDTag(1)]
		protected void InternalClose(INetIO tcpIO, ENetCloseReason netCloseReason) {} // 0x00000001892A00B4-0x00000001892A0130
		[IDTag(0)]
		protected void InternalClose(INetIO tcpIO, int netCloseReason) {} // 0x00000001829432A0-0x0000000182943450
		protected void EnqueueSendMsg(NetRequest msg) {} // 0x0000000182947280-0x0000000182947300
		public int GetSendQueueMsgCount() => default; // 0x00000001824CCFD0-0x00000001824CD0D0
		protected long IncrementCSSeqID() => default; // 0x0000000182947240-0x0000000182947280
		protected void SetCSSeqID(long id) {} // 0x0000000182F0D690-0x0000000182F0D6D0
		protected long GetCSSeqID() => default; // 0x00000001892A0064-0x00000001892A00B4
		protected INetIO GetIO() => default; // 0x0000000182F0D630-0x0000000182F0D660
		protected void StartTCPMsgLoopThreadTask() {} // 0x000000018293D780-0x000000018293D8B0
		protected void CloseTCPMsgThreadTask() {} // 0x00000001829441B0-0x0000000182944210
		private async System.Threading.Tasks.Task _SessionThread(INetIO tcp, int threadID) => default; // 0x000000018397CF20-0x000000018397D050
		private bool _SendAndCheckMessage(INetIO tcp, int threadID) => default; // 0x00000001824CC200-0x00000001824CC720
		private bool _ReadAndCheckMessageInSessionThread(INetIO tcp, int threadID) => default; // 0x00000001824C8290-0x00000001824C8D50
		protected abstract bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp);
		protected abstract void CheckAndDealRespMessages(INetIO netIO, ref NetResponse m);
		protected abstract void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m);
		protected void SessionCheckSignalAndSleep(int threadID) {} // 0x00000001824CAD30-0x00000001824CAED0
		protected void OpenAutoReconnect() {} // 0x0000000182D75B70-0x0000000182D75BA0
		protected void RemoveAutoReconnect() {} // 0x0000000182943450-0x0000000182943480
		private async System.Threading.Tasks.Task _ReconnectCheckerTick(INetIO tcpIO) => default; // 0x00000001824C8FA0-0x00000001824C9240
		protected async Task<bool> TryConnectWithTimeout(INetIO tcpIO, string ip, int port, int sendTimeout, int receiveBufferLen, int timeoutMilliseconds) => default; // 0x00000001832F8460-0x00000001832F85D0
		protected async Task<bool> TryCloseTcpIOWithTimeout(INetIO tcpIO, int timeoutMilliseconds) => default; // 0x00000001832F85D0-0x00000001832F8730
		protected abstract void OnReconnectTimesOver(INetIO tcpIO);
		protected abstract bool NeedKeepConnect();
		protected abstract void DoReconnectLogin(INetIO netIO);
		protected abstract void InitClientRSAKey();
		protected abstract void ClearRSAKey();
		public abstract void ClearRecvQueue();
		public abstract void ClearSendQueue();
		protected void NetStatusChecker_Receive(INetIO netIO, long scSeqId, int receiveCount) {} // 0x00000001824C8D50-0x00000001824C8EA0
		protected void NetStatusChecker_Sender(INetIO netIO, long csSeqId, int sendCount) {} // 0x00000001824CC720-0x00000001824CC990
		protected abstract void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs);
		protected abstract void ClearPingWDG();
		protected abstract bool IsPingOut();
		protected abstract void PingSenderTick(INetIO netIO, long upSeqId);
	}

	public class HGNetSession : HGNetBaseSession // TypeDefIndex: 56200
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
		private const int SEND_PING_DELTA_TICK_TIME_MS = 2000; // Metadata: 0x01FD7D87
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
		public HGNetSession() {} // 0x0000000182F0EB50-0x0000000182F0EDC0
		static HGNetSession() {} // 0x0000000183A27930-0x0000000183A27B40
	
		// Methods
		public void SetAutoReconnectToken(string uid, string token, int channel) {} // 0x000000018229B650-0x000000018229B6D0
		protected override void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs) {} // 0x0000000182FCABF0-0x0000000182FCACE0
		protected override void DoReconnectLogin(INetIO netIO) {} // 0x00000001892A0204-0x00000001892A08E8
		public override void Start() {} // 0x0000000183A614C0-0x0000000183A61630
		public void OnApplicationPause(bool pause) {} // 0x00000001892A0938-0x00000001892A0A20
		public ulong SendMessage(IMessage msg) => default; // 0x0000000182946500-0x0000000182946870
		protected void PackMessageToSendQueue() {} // 0x00000001892A0A8C-0x00000001892A1190
		public void UpdateInGameThread() {} // 0x00000001892A1204-0x00000001892A1268
		public void TailLateUpdateInGameThread() {} // 0x00000001892A11E4-0x00000001892A11FC
		private float _GetMessageTimeLimit() => default; // 0x00000001892A1268-0x00000001892A12E8
		private void _ProcessReceivedMessagesInGameThread(bool flushAll) {} // 0x00000001892A1C64-0x00000001892A1FF4
		public HGNetSessionLoginYield LoginAsync(string uid, string token, int channel) => default; // 0x000000018229CE50-0x000000018229D260
		private static void _CSLoginHelper_UpdateAppInfo(MSG_A1 msg) {} // 0x0000000182F42E90-0x0000000182F42F40
		private static string _GetOnlineResVersion() => default; // 0x0000000182F432D0-0x0000000182F43380
		private static ENV_TYPE _GetSDKEnv() => default; // 0x0000000182F42650-0x0000000182F42710
		private static CLIENT_PLATFORM_TYPE _GetPlatformID() => default; // 0x0000000182F42AF0-0x0000000182F42B20
		private static int _GetPayPlatform() => default; // 0x0000000182F42A60-0x0000000182F42AC0
		private void _SessionLoginThreadTask(object handle) {} // 0x0000000182F0D2B0-0x0000000182F0D630
		public void StartMsgLoop() {} // 0x0000000182D75AC0-0x0000000182D75B10
		protected override void OnConnectedSucceed(INetIO tcpIO) {} // 0x0000000183D48E60-0x0000000183D48E90
		protected override void OnReconnectTimesOver(INetIO tcpIO) {} // 0x00000001892A0A20-0x00000001892A0A8C
		protected override bool NeedKeepConnect() => default; // 0x0000000182FCACE0-0x0000000182FCADA0
		protected override void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest req) {} // 0x00000001832BA150-0x00000001832BA2C0
		private void _WriteMessageInSessionThread(INetIO netIO, ref NetRequest request, bool useSRSA = false /* Metadata: 0x01FD7D85 */) {} // 0x00000001824D2DD0-0x00000001824D3160
		protected override bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp) {
			resp = default;
			return default;
		} // 0x00000001824CD2A0-0x00000001824CD3A0
		private bool _ReadMessageInSessionThread(INetIO netIO, out NetResponse resp, bool useSRSA = false /* Metadata: 0x01FD7D86 */) {
			resp = default;
			return default;
		} // 0x00000001824CA720-0x00000001824CAD30
		public override void ClearRecvQueue() {} // 0x00000001824C6FB0-0x00000001824C71E0
		public override void ClearSendQueue() {} // 0x0000000183D00680-0x0000000183D006E0
		public static void SetBurstMode(bool val) {} // 0x00000001892A1190-0x00000001892A11E4
		~HGNetSession() {} // 0x0000000183CFA670-0x0000000183CFA6B0
		public int GetPing() => default; // 0x00000001824C64F0-0x00000001824C6600
		public bool IsPingInProgress() => default; // 0x00000001892A08E8-0x00000001892A0938
		public long GetPingPassedTime() => default; // 0x0000000183559D50-0x0000000183559DF0
		protected override void ClearPingWDG() {} // 0x00000001834564F0-0x0000000183456580
		private void _ApproximateLoginServerTime(long serverTimeMS, int serverZone) {} // 0x0000000182F0D6D0-0x0000000182F0D750
		private bool _HandleSpecialMessagePing(NetResponse m) => default; // 0x00000001831DA430-0x00000001831DA620
		protected override bool IsPingOut() => default; // 0x00000001824CCE60-0x00000001824CCFD0
		protected override void PingSenderTick(INetIO netIO, long upSeqId) {} // 0x00000001824CD3A0-0x00000001824CD8A0
		public static byte[] GetClientPublicKey() => default; // 0x000000018229D780-0x000000018229D820
		protected override void InitClientRSAKey() {} // 0x00000001831854A0-0x00000001831855B0
		private byte[] _RSADecrypt(byte[] data) => default; // 0x0000000183187930-0x0000000183187A30
		protected override void ClearRSAKey() {} // 0x00000001892A013C-0x00000001892A0204
		protected override void CheckAndDealRespMessages(INetIO netIO, ref NetResponse msg) {} // 0x00000001824C7660-0x00000001824C7FC0
		private bool _HandleSpecialMessageReconnectIncr(INetIO netIO, NetResponse m) => default; // 0x00000001892A1570-0x00000001892A1AC8
		private bool _HandleSpecialMessageReconnectFull(INetIO netIO, NetResponse m) => default; // 0x00000001892A13C8-0x00000001892A1570
		private bool _HandleSpecialMessageErrorCode(INetIO netIO, NetResponse m) => default; // 0x00000001892A12E8-0x00000001892A13C8
		private bool _HandleSpecialMessageReconnectLogin(INetIO netIO, NetResponse m) => default; // 0x00000001892A1AC8-0x00000001892A1C64
		private void _HandleLoginEncryp(INetIO netIO, MSG_B1 msg) {} // 0x0000000183187610-0x0000000183187700
		public void __iFixBaseProxy_Start() {} // 0x00000001892A11FC-0x00000001892A1204
	}

	public enum EHGNetSessionState : byte // TypeDefIndex: 56201
	{
		Closed = 0,
		Opened = 1,
		Connecting = 2,
		SessionRunning = 3
	}

	public enum EHGNetSessionReconnectState : byte // TypeDefIndex: 56202
	{
		None = 0,
		ReconnectingTcp = 1,
		SendLogin = 2,
		ResendPack = 3
	}

	public enum ENetCloseReason // TypeDefIndex: 56203
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

	public static class HGNetSessionUtils // TypeDefIndex: 56204
	{
		// Methods
		public static bool CheckErrorNeedsDisconnect(CODE errorCode) => default; // 0x00000001892A9F08-0x00000001892A9F70
	}

	public static class HGNetSessionConstant // TypeDefIndex: 56205
	{
		// Fields
		public const int CODE_SUC = 0; // Metadata: 0x01FD7DB3
		public const int CODE_CONN_FAILED = 1; // Metadata: 0x01FD7DB4
		public const int CODE_CONN_WAIT = -1; // Metadata: 0x01FD7DB5
	}

	public enum ENetConnectErrorCode // TypeDefIndex: 56206
	{
		Invalid = -1,
		None = 0,
		ForServerErrorMax = 100000,
		ConnectError = 800001,
		TimeOut = 800002
	}

	public class HGNetSessionLoginYield : CustomYieldInstruction // TypeDefIndex: 56208
	{
		// Fields
		internal LoginErrorInfo m_loginErrorInfo; // 0x10
		internal bool m_bIsFinish; // 0x18
		internal MSG_A1 m_request; // 0x20
		internal MSG_B1 m_resp; // 0x28
		private object m_locker; // 0x30
	
		// Properties
		public bool isSucceed { get => default; } // 0x000000018229C1D0-0x000000018229C200 
		public override bool keepWaiting { get => default; } // 0x0000000183D032E0-0x0000000183D032F0 
	
		// Nested types
		internal class LoginErrorInfo // TypeDefIndex: 56207
		{
			// Properties
			internal int code { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
			internal string details { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
			// Constructors
			public LoginErrorInfo() {} // 0x0000000182F0EFD0-0x0000000182F0F020
	
			// Methods
			public void SetErrorInvaild() {} // 0x0000000182F0F020-0x0000000182F0F090
			public void SetErrorConnectError() {} // 0x00000001892AF990-0x00000001892AFA1C
			public void SetErrorConnectTimeOut() {} // 0x00000001892AFA1C-0x00000001892AFAA8
			public void Clear() {} // 0x0000000182F0EAE0-0x0000000182F0EB50
			public void Set(int code, string details) {} // 0x00000001892AFAA8-0x00000001892AFB20
		}
	
		// Constructors
		public HGNetSessionLoginYield() {} // 0x0000000182F0EF20-0x0000000182F0EFD0
		public HGNetSessionLoginYield(MSG_A1 req) {} // 0x0000000182F0E970-0x0000000182F0EA30
	
		// Methods
		public MSG_A1 GetRequest() => default; // 0x0000000182F0D660-0x0000000182F0D690
		public MSG_B1 GetResponse() => default; // 0x000000018229C5A0-0x000000018229C5D0
		public int GetErrorCode() => default; // 0x00000001892A9B40-0x00000001892A9B98
		public string GetErrorDetails() => default; // 0x00000001892A9B98-0x00000001892A9BF0
		public void SetSucceed(MSG_B1 sc) {} // 0x0000000182F0E780-0x0000000182F0E970
		public void SetNtfError(int ntfErrorCode, string ntfErrorDetails) {} // 0x00000001892A9CE8-0x00000001892A9E10
		public void SetConnectErrorError() {} // 0x00000001892A9BF0-0x00000001892A9CE8
		public void SetTimeOutError() {} // 0x00000001892A9E10-0x00000001892A9F08
	}

	public class HGNetSessionConnectYield : CustomYieldInstruction // TypeDefIndex: 56209
	{
		// Fields
		internal System.Threading.Tasks.Task m_connectTask; // 0x10
		internal ENetConnectErrorCode connectErrorCode; // 0x18
	
		// Properties
		public bool isSucceed { get => default; } // 0x000000018229C590-0x000000018229C5A0 
		public override bool keepWaiting { get => default; } // 0x0000000183CB5470-0x0000000183CB54C0 
	
		// Constructors
		public HGNetSessionConnectYield() {} // 0x0000000183D50330-0x0000000183D50340
		public HGNetSessionConnectYield(System.Threading.Tasks.Task connectTask) {} // 0x00000001830840F0-0x0000000183084120
	
		// Methods
		public int GetCode() => default; // 0x00000001892A9AF4-0x00000001892A9B40
		public void SetFinish(ENetConnectErrorCode code) {} // 0x00000001838A2420-0x00000001838A2460
	}
}

namespace Beyond.Network.HGNetLogger
{
	public abstract class HGNetLogBaseSession // TypeDefIndex: 56210
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
		private const int MAX_RECYCLE_QUEUE_COUNT = 1000; // Metadata: 0x01FD7DC4
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
		public bool isRunning { get; } // 0x00000001892A9584-0x00000001892A9590 
		public bool isConnecting { get; } // 0x00000001892A956C-0x00000001892A9578 
		public bool isRunningAndConnected { get; } // 0x00000001892A9578-0x00000001892A9584 
		public int closeErrorCode { get; } // 0x0000000183D4F370-0x0000000183D4F380 
		public bool isAutoReconnect { get; } // 0x0000000183D4F260-0x0000000183D4F270 
	
		// Constructors
		protected HGNetLogBaseSession() {} // 0x00000001892A9424-0x00000001892A956C
		static HGNetLogBaseSession() {} // 0x00000001892A9370-0x00000001892A9424
	
		// Methods
		public virtual void Start() {} // 0x00000001892A89EC-0x00000001892A8B30
		public virtual bool Connect(string serverIp, int serverPort, bool forceReconnect) => default; // 0x00000001892A7EA4-0x00000001892A8188
		public virtual bool ConnectAsync(string serverIp, int serverPort, bool forceReconnect, out HGNetSessionConnectYield yieldHandle) {
			yieldHandle = default;
			return default;
		} // 0x00000001892A7B0C-0x00000001892A7EA4
		public void OnConnectAsyncEnd(System.Threading.Tasks.Task continuationAction) {} // 0x00000001892A8530-0x00000001892A8668
		protected abstract void OnConnectedSucceed(INetIO tcpIO);
		private void _DNSCheck(string serverIp) {} // 0x00000001892A8B30-0x00000001892A8CEC
		[IDTag(1)]
		public virtual void Close(ENetCloseReason netCloseReason) {} // 0x00000001892A78A8-0x00000001892A790C
		[IDTag(0)]
		public virtual void Close(int netCloseReason) {} // 0x00000001892A790C-0x00000001892A7B0C
		protected void EnqueueSendMsg(NetRequest msg) {} // 0x00000001892A8188-0x00000001892A823C
		public int GetSendQueueMsgCount() => default; // 0x00000001892A82DC-0x00000001892A8358
		protected long IncrementCSSeqID() => default; // 0x00000001892A8358-0x00000001892A83B0
		protected void SetCSSeqID(long id) {} // 0x00000001892A87CC-0x00000001892A8828
		protected long GetCSSeqID() => default; // 0x00000001892A823C-0x00000001892A828C
		protected INetIO GetIO() => default; // 0x00000001892A828C-0x00000001892A82DC
		protected void StartTCPMsgLoopThreadTask() {} // 0x00000001892A8828-0x00000001892A89EC
		protected void CloseTCPMsgThreadTask() {} // 0x00000001892A77C8-0x00000001892A78A8
		private void _SessionThread() {} // 0x00000001892A8FB0-0x00000001892A9370
		protected abstract bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp);
		protected abstract void CheckAndDealRespMessages(INetIO netIO, ref NetResponse m);
		protected abstract void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m);
		protected void SessionCheckSignalAndSleep() {} // 0x00000001892A8704-0x00000001892A87CC
		protected void OpenAutoReconnect() {} // 0x00000001892A8668-0x00000001892A86B8
		protected void RemoveAutoReconnect() {} // 0x00000001892A86B8-0x00000001892A8704
		private void _ReconnectCheckerTick() {} // 0x00000001892A8CEC-0x00000001892A8FB0
		protected abstract void OnReconnectTimesOver();
		protected abstract bool NeedKeepConnect();
		protected abstract void DoReconnectLogin(INetIO netIO);
		protected abstract void InitClientRSAKey();
		protected abstract void ClearRSAKey();
		protected void NetStatusChecker_Receive(INetIO netIO, long scSeqId, int receiveCount) {} // 0x00000001892A83B0-0x00000001892A8464
		protected void NetStatusChecker_Sender(INetIO netIO, long csSeqId, int sendCount) {} // 0x00000001892A8464-0x00000001892A8530
		protected abstract void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs);
		protected abstract void ClearPingWDG();
		protected abstract bool IsPingOut();
		protected abstract void PingSenderTick(INetIO netIO, long upSeqId);
	}

	public class HGNetLogger : Beyond.Log.ILogger // TypeDefIndex: 56211
	{
		// Fields
		private BitArray256 m_enabledLogChannel; // 0x10
		private ConcurrentQueue<FLogMessage> m_logMessagesQueue; // 0x30
		public static int s_maxLogQueueSize; // 0x00
		public static int s_maxRepeatedMsgMs; // 0x04
		public static int s_maxRepeatedMsgCount; // 0x08
	
		// Constructors
		public HGNetLogger() {} // 0x0000000183B2C9E0-0x0000000183B2CA70
		static HGNetLogger() {} // 0x0000000183D20A30-0x0000000183D20AA0
	
		// Methods
		public void Log(ref FLogMessage msg) {} // 0x000000018261BA80-0x000000018261CE70
		[IDTag(0)]
		public static LogLevel ConvertFromDLogger(ELogLevel level) => default; // 0x00000001832F5020-0x00000001832F5080
		public static NativeLogLevel ConvertFromDLoggerV2(ELogLevel level) => default; // 0x00000001832F5080-0x00000001832F50E0
		public bool CheckLog(ref FLogMessage msg) => default; // 0x0000000183283950-0x00000001832839B0
		public void Clear() {} // 0x000000018388DD60-0x000000018388DDC0
		public void SetLogChannel(ulong channel1, ulong channel2, ulong channel3, ulong channel4) {} // 0x00000001892A9A3C-0x00000001892A9AF4
		[IDTag(1)]
		public static int ConvertFromDLogger(ELogChannel channel) => default; // 0x000000018335D9A0-0x000000018335D9D0
	}

	public class HGNetLoggerClient // TypeDefIndex: 56212
	{
		// Fields
		private static HGNetLoggerClient s_instance; // 0x00
		public HGNetLoggerSession m_logsession; // 0x10
		private HGNetLogger m_netLogger; // 0x18
		public static readonly int MAX_LOG_SEND_QUEUE_SIZE; // 0x10
		private const int MAX_LOCAL_LOG_QUEUE_SIZE = 200; // Metadata: 0x01FD7DC7
		private readonly Queue<FLogMessage> m_localLogQueue; // 0x20
		private readonly object m_queueLock; // 0x28
		public static Beyond.Network.HGNetLogger.Version s_usedVersion; // 0x14
	
		// Properties
		public static HGNetLoggerClient instance { get => default; } // 0x00000001829456A0-0x0000000182945820 
		public static long s_roleID { get; private set; } // 0x00000001892A9658-0x00000001892A96A8 0x00000001892A96A8-0x00000001892A9700
	
		// Constructors
		protected HGNetLoggerClient() {} // 0x0000000183CABDF0-0x0000000183CABEC0
		static HGNetLoggerClient() {} // 0x0000000183D2C2B0-0x0000000183D2C300
	
		// Methods
		public void Init(string uid, string token, string env, string roleId = "" /* Metadata: 0x01FD7DC6 */) {} // 0x0000000182C3FB70-0x0000000182C40040
		public void AddLog(string message, string stacktrace, UnityEngine.LogType type) {} // 0x000000018367C070-0x000000018367C650
		private void _FlushLocalLogQueue() {} // 0x000000018367C840-0x000000018367CF20
		public static void OnApplicationPause(bool pauseStatus) {} // 0x00000001892A9590-0x00000001892A9658
		public void ShutDown() {} // 0x0000000182C35120-0x0000000182C35160
		private void _CloseAndClear(ENetCloseReason reason) {} // 0x000000018267B150-0x000000018267B3E0
		public void WriteNetLog(ref LogMessage log) {} // 0x0000000182946870-0x00000001829469C0
		public static void SetRoleID(ulong roleID) {} // 0x00000001837601E0-0x0000000183760280
		public void SetNetLogMaskFromServer(RepeatedField<ulong> masks) {} // 0x0000000183D48E90-0x0000000183D48EC0
	}

	public class HGNetLoggerCloudSettings // TypeDefIndex: 56213
	{
		// Fields
		public static readonly HGNetLoggerCloudSettings instance; // 0x00
		private LogControl m_cloudLogControl; // 0x10
		private Dictionary<int, int> m_cloudChannelLevelMaskTables; // 0x18
		private LogControl m_localLogControl; // 0x20
		private Dictionary<int, int> m_localChannelLevelMaskTables; // 0x28
		private static List<NativeLogLevel> s_allLevels; // 0x08
	
		// Constructors
		public HGNetLoggerCloudSettings() {} // 0x00000001839C0490-0x00000001839C0540
		static HGNetLoggerCloudSettings() {} // 0x00000001839C0330-0x00000001839C0490
	
		// Methods
		public static void SetCloudLogControl(AuthResponse control, HGNetBaseSession session) {} // 0x00000001829474D0-0x0000000182948900
		[IDTag(1)]
		public static bool IsNetLogLevelEnabled(ELogLevel elevel, ELogChannel channel) => default; // 0x000000018367CF20-0x000000018367CFA0
		[IDTag(0)]
		public static bool IsNetLogLevelEnabled(NativeLogLevel level, int channel) => default; // 0x0000000182947300-0x00000001829474D0
		public static bool IsLocalLogLevelEnabled(ELogLevel elevel, ELogChannel channel) => default; // 0x00000001892A9700-0x00000001892A983C
		public static NativeLogLevel ConvertFromDLogger(ELogLevel level) => default; // 0x000000018367CFA0-0x000000018367D1F0
	}

	public class HGNetLoggerSession : HGNetBaseSession // TypeDefIndex: 56214
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
		public string uid { get => default; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 
		public string roleId { get => default; } // 0x0000000183D51140-0x0000000183D51150 
		private static Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> s_messageType2Id { get => default; } // 0x00000001824D26A0-0x00000001824D28E0 
		private static Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> s_messageId2Type { get => default; } // 0x0000000183828370-0x00000001838285C0 
	
		// Constructors
		public HGNetLoggerSession() {} // 0x0000000182F0EA30-0x0000000182F0EAE0
	
		// Methods
		public static bool TryGetMsgTypeByID(System.Type msgType, out Beyond.Network.HGNetLogger.MessageType type) {
			type = default;
			return default;
		} // 0x00000001824D2620-0x00000001824D26A0
		public override void Start() {} // 0x0000000183CFE560-0x0000000183CFE5B0
		public void SetReconnectSuccessCallback(Action onReconnectSuccess) {} // 0x0000000183D1C320-0x0000000183D1C370
		public void OnApplicationPause(bool pause) {} // 0x00000001892A9880-0x00000001892A9980
		protected override void OnConnectedSucceed(INetIO tcpIO) {} // 0x0000000182D75B10-0x0000000182D75B70
		protected override bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp) {
			resp = default;
			return default;
		} // 0x00000001824CC990-0x00000001824CCE60
		protected override void CheckAndDealRespMessages(INetIO netIO, ref NetResponse resp) {} // 0x0000000182944A00-0x0000000182944C20
		protected override void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m) {} // 0x00000001824D28E0-0x00000001824D2950
		private void _WriteMessageInSessionThread(INetIO netIO, NetRequest request) {} // 0x00000001824D1AD0-0x00000001824D1E10
		public ulong SendMessage(IMessage msg) => default; // 0x00000001829469C0-0x0000000182947240
		public void SetAutoReconnectToken(string uid, string token, string env, string roleId) {} // 0x0000000183CA8270-0x0000000183CA8310
		protected override bool NeedKeepConnect() => default; // 0x00000001824CD0D0-0x00000001824CD2A0
		protected override void DoReconnectLogin(INetIO netIO) {} // 0x0000000182944910-0x0000000182944A00
		private int _GetConnectTimeoutTime() => default; // 0x00000001824CDC10-0x00000001824CDE90
		protected override void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs) {} // 0x00000001824CD980-0x00000001824CDC10
		protected override void ClearPingWDG() {} // 0x0000000183B6CCC0-0x0000000183B6CCF0
		public void SendLogin(INetIO netIO) {} // 0x0000000182945E40-0x0000000182946270
		protected override bool IsPingOut() => default; // 0x00000001834A9C90-0x00000001834A9CC0
		protected override void PingSenderTick(INetIO netIO, long upSeqId) {} // 0x0000000183091F30-0x0000000183092010
		protected override void InitClientRSAKey() {} // 0x0000000183D45040-0x0000000183D45070
		protected override void ClearRSAKey() {} // 0x00000001892A983C-0x00000001892A9880
		public override void ClearRecvQueue() {} // 0x0000000183D450A0-0x0000000183D450D0
		public override void ClearSendQueue() {} // 0x0000000183D45070-0x0000000183D450A0
		protected override void OnReconnectTimesOver(INetIO tcpIO) {} // 0x00000001892A9980-0x00000001892A9A3C
		public void __iFixBaseProxy_Start() {} // 0x00000001892A11FC-0x00000001892A1204
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 56121
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 56122
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 56123
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 56124
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 56125
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 56120
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 56215
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05C60-0x0000000183D05CD0
	
		// Methods
		public void __Gen_Wrap_0(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public void __Gen_Wrap_1(object P0, object P1, int P2) {} // 0x00000001854A1028-0x00000001854A1120
		public IAsyncResult __Gen_Wrap_2(object P0, object P1, int P2, object P3, object P4) => default; // 0x00000001892AB3E4-0x00000001892AB528
		public System.Threading.Tasks.Task __Gen_Wrap_3(object P0, object P1, int P2) => default; // 0x00000001892ABC30-0x00000001892ABD54
		public NetworkStream __Gen_Wrap_4(object P0) => default; // 0x00000001892AC94C-0x00000001892ACA3C
		public void __Gen_Wrap_5(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public void __Gen_Wrap_6(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public LingerOption __Gen_Wrap_7(object P0) => default; // 0x00000001892AE2D4-0x00000001892AE3C4
		public int __Gen_Wrap_8(object P0, SocketOptionLevel P1, SocketOptionName P2) => default; // 0x000000018561B0C4-0x000000018561B1B4
		public int __Gen_Wrap_9(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public bool __Gen_Wrap_10(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public long __Gen_Wrap_11(object P0) => default; // 0x000000018516CA20-0x000000018516CAF0
		public ulong __Gen_Wrap_12(object P0, object P1) => default; // 0x00000001892AA6A0-0x00000001892AA78C
		public System.Type __Gen_Wrap_13(int P0) => default; // 0x00000001892AA78C-0x00000001892AA878
		public void __Gen_Wrap_14(object P0, int P1, object P2) {} // 0x000000018514F720-0x000000018514F818
		public void __Gen_Wrap_15(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public NetBus.ResultHandler __Gen_Wrap_16(object P0, object P1) => default; // 0x00000001892AA878-0x00000001892AA984
		public void __Gen_Wrap_17(object P0, in NetResponse P1) {} // 0x00000001892AA984-0x00000001892AAAB0
		public NetBus.ResultHandler __Gen_Wrap_18(object P0, SCMessageID P1, object P2) => default; // 0x00000001892AAAB0-0x00000001892AABD4
		public void __Gen_Wrap_19(object P0, SCMessageID P1, object P2) {} // 0x000000018560138C-0x0000000185601470
		public int __Gen_Wrap_20(object P0, object P1, float P2, float P3) => default; // 0x00000001892AABD4-0x00000001892AACEC
		public int __Gen_Wrap_21(object P0, CSMessageID P1, float P2) => default; // 0x00000001892AACEC-0x00000001892AADE0
		public void __Gen_Wrap_22(in NetResponse P0) {} // 0x00000001892AADE0-0x00000001892AAEDC
		public NetBus.ResultHandler __Gen_Wrap_23(object P0, object P1, bool P2, object P3, object P4) => default; // 0x00000001892AAEDC-0x00000001892AB024
		public bool __Gen_Wrap_24(object P0, object P1) => default; // 0x00000001892AB024-0x00000001892AB0FC
		public void __Gen_Wrap_25(int P0, object P1) {} // 0x0000000185161B54-0x0000000185161C30
		public void __Gen_Wrap_26() {} // 0x00000001850F3444-0x00000001850F34E0
		public bool __Gen_Wrap_27(Span<byte> P0, object P1, int P2, int P3, object P4, out NetResponse P5) {
			P5 = default;
			return default;
		} // 0x00000001892AB0FC-0x00000001892AB2B0
		public int __Gen_Wrap_28(object P0, ulong P1, int P2, int P3, object P4, int P5) => default; // 0x00000001892AB2B0-0x00000001892AB3E4
		public void __Gen_Wrap_29(System.Type P0, MethodInfo P1) {} // 0x00000001850EF54C-0x00000001850EF614
		public void __Gen_Wrap_30(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public string __Gen_Wrap_31() => default; // 0x00000001892AB528-0x00000001892AB5F4
		public string __Gen_Wrap_32(object P0) => default; // 0x00000001892AB5F4-0x00000001892AB6E4
		public string __Gen_Wrap_33(NetworkUrls.EUrlType P0) => default; // 0x00000001892AB6E4-0x00000001892AB7D0
		public string __Gen_Wrap_34(object P0, NetworkUrls.EUrlType P1) => default; // 0x00000001892AB7D0-0x00000001892AB8DC
		public void __Gen_Wrap_35(object P0, object P1, int P2, int P3, int P4, int P5) {} // 0x00000001892AB8DC-0x00000001892ABA00
		public System.Threading.Tasks.Task __Gen_Wrap_36(object P0, object P1, int P2, int P3, int P4, int P5) => default; // 0x00000001892ABA00-0x00000001892ABB54
		public void __Gen_Wrap_37(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public EndPoint __Gen_Wrap_38(object P0) => default; // 0x00000001892ABB54-0x00000001892ABC30
		public void __Gen_Wrap_39(object P0, bool P1, bool P2) {} // 0x0000000185646F78-0x000000018564705C
		public void __Gen_Wrap_40(object P0, object P1, int P2, int P3) {} // 0x00000001892ABD54-0x00000001892ABE5C
		public byte[] __Gen_Wrap_41(object P0) => default; // 0x00000001892ABE5C-0x00000001892ABF4C
		public int __Gen_Wrap_42(object P0, object P1, int P2, int P3) => default; // 0x00000001856275C8-0x00000001856276DC
		public HttpSender.Cancellation __Gen_Wrap_43(ref HttpSender.FSendFunc P0) => default; // 0x00000001892ABF4C-0x00000001892AC0FC
		public UnityWebRequest __Gen_Wrap_44(object P0, HttpSender.FGetOptions P1) => default; // 0x00000001892AC0FC-0x00000001892AC234
		public UnityWebRequest __Gen_Wrap_45(object P0, HttpSender.FPostOptions P1) => default; // 0x00000001892AC234-0x00000001892AC36C
		public UnityWebRequest __Gen_Wrap_46(ref HttpSender.FSendFunc P0) => default; // 0x00000001892AC36C-0x00000001892AC51C
		public IEnumerator __Gen_Wrap_47(object P0, HttpSender.FSendFunc P1) => default; // 0x00000001892AC51C-0x00000001892AC678
		public IEnumerator __Gen_Wrap_48(object P0, HttpSender.FSendFunc P1, object P2) => default; // 0x00000001892AC678-0x00000001892AC7EC
		public IEnumerator __Gen_Wrap_49(object P0, HttpSender.FGetOptions P1, object P2, object P3) => default; // 0x00000001892AC7EC-0x00000001892AC94C
		public IEnumerator __Gen_Wrap_50(object P0, HttpSender.FGetOptions P1, object P2) => default; // 0x00000001892ACA3C-0x00000001892ACB8C
		public IEnumerator __Gen_Wrap_51(object P0, HttpSender.FPostOptions P1, object P2, object P3) => default; // 0x00000001892ACB8C-0x00000001892ACCEC
		public IEnumerator __Gen_Wrap_52(object P0, HttpSender.FPostOptions P1, object P2) => default; // 0x00000001892ACCEC-0x00000001892ACE2C
		public void __Gen_Wrap_53(object P0, HttpSender.FSendFunc P1) {} // 0x00000001892ACE2C-0x00000001892ACF68
		public HttpSender.Result __Gen_Wrap_54() => default; // 0x00000001892ACF68-0x00000001892AD020
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_55(HttpSender.FSendFunc P0) => default; // 0x00000001892AD020-0x00000001892AD150
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_56(object P0, HttpSender.FPostOptions P1) => default; // 0x00000001892AD150-0x00000001892AD278
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_57(object P0, HttpSender.FGetOptions P1) => default; // 0x00000001892AD278-0x00000001892AD3A0
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_58(object P0) => default; // 0x00000001892AD3A0-0x00000001892AD47C
		public int __Gen_Wrap_59(object P0, out bool P1) {
			P1 = default;
			return default;
		} // 0x00000001892AD47C-0x00000001892AD588
		public string __Gen_Wrap_60(ref HttpSender.FSendFunc P0) => default; // 0x00000001892AD588-0x00000001892AD728
		public void __Gen_Wrap_61(object P0, EHGNetSessionReconnectState P1) {} // 0x000000018563E0E0-0x000000018563E1BC
		public void __Gen_Wrap_62(object P0, object P1, ENetCloseReason P2) {} // 0x00000001854A1028-0x00000001854A1120
		public bool __Gen_Wrap_63(object P0, object P1, int P2, bool P3) => default; // 0x00000001892AD728-0x00000001892AD830
		public void __Gen_Wrap_64(object P0, ENetConnectErrorCode P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_65(object P0, ENetCloseReason P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_66(Task<System.Threading.Tasks.Task> P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public bool __Gen_Wrap_67(object P0, object P1, int P2, bool P3, out HGNetSessionConnectYield P4) {
			P4 = default;
			return default;
		} // 0x00000001892AD830-0x00000001892AD9A0
		public void __Gen_Wrap_68(object P0, NetRequest P1) {} // 0x00000001892AD9A0-0x00000001892ADABC
		public void __Gen_Wrap_69(object P0, long P1) {} // 0x0000000185606CE4-0x0000000185606DC0
		public INetIO __Gen_Wrap_70(object P0) => default; // 0x00000001892ADABC-0x00000001892ADBAC
		public Task<bool> __Gen_Wrap_71(object P0, object P1, int P2) => default; // 0x00000001892ADBAC-0x00000001892ADCD0
		public Task<bool> __Gen_Wrap_72(object P0, object P1, object P2, int P3, int P4, int P5, int P6) => default; // 0x00000001892ADCD0-0x00000001892ADE34
		public System.Threading.Tasks.Task __Gen_Wrap_73(object P0, object P1) => default; // 0x00000001892ADE34-0x00000001892ADF40
		public void __Gen_Wrap_74(object P0, object P1, long P2, int P3) {} // 0x00000001892ADF40-0x00000001892AE048
		public bool __Gen_Wrap_75(object P0, object P1, int P2) => default; // 0x0000000185E685F4-0x0000000185E686F8
		public System.Threading.Tasks.Task __Gen_Wrap_76() => default; // 0x00000001892AE048-0x00000001892AE100
		public void __Gen_Wrap_77(object P0, object P1, object P2, int P3) {} // 0x0000000185E3E6A8-0x0000000185E3E7B0
		public void __Gen_Wrap_78(object P0, object P1, long P2, long P3) {} // 0x00000001892AE100-0x00000001892AE208
		public byte[] __Gen_Wrap_79() => default; // 0x00000001892AE208-0x00000001892AE2D4
		public CLIENT_PLATFORM_TYPE __Gen_Wrap_80() => default; // 0x00000001850EF068-0x00000001850EF114
		public ENV_TYPE __Gen_Wrap_81() => default; // 0x00000001850EF068-0x00000001850EF114
		public int __Gen_Wrap_82() => default; // 0x00000001850EF068-0x00000001850EF114
		public void __Gen_Wrap_83(object P0, object P1, ref NetRequest P2, bool P3) {} // 0x00000001892AE3C4-0x00000001892AE558
		public bool __Gen_Wrap_84(object P0, object P1, out NetResponse P2, bool P3) {
			P2 = default;
			return default;
		} // 0x00000001892AE558-0x00000001892AE6C8
		public void __Gen_Wrap_85(object P0, long P1, int P2) {} // 0x00000001892AE6C8-0x00000001892AE7C0
		public byte[] __Gen_Wrap_86(object P0, object P1) => default; // 0x00000001892AE7C0-0x00000001892AE8CC
		public MSG_A1 __Gen_Wrap_87(object P0) => default; // 0x00000001892AE8CC-0x00000001892AE9BC
		public HGNetSessionLoginYield __Gen_Wrap_88(object P0, object P1, object P2, int P3) => default; // 0x00000001892AE9BC-0x00000001892AEAF0
		public void __Gen_Wrap_89(object P0, object P1, ref NetRequest P2) {} // 0x00000001892AEAF0-0x00000001892AEC74
		public bool __Gen_Wrap_90(object P0, object P1, out NetResponse P2) {
			P2 = default;
			return default;
		} // 0x00000001892AEC74-0x00000001892AEDD8
		public bool __Gen_Wrap_91(object P0, NetResponse P1) => default; // 0x00000001892AEDD8-0x00000001892AEF00
		public void __Gen_Wrap_92(object P0, object P1, long P2) {} // 0x0000000188706E14-0x0000000188706F0C
		public bool __Gen_Wrap_93(CODE P0) => default; // 0x000000018514DE88-0x000000018514DF54
		public bool __Gen_Wrap_94(object P0, object P1, NetResponse P2) => default; // 0x00000001892AEF00-0x00000001892AF040
		public void __Gen_Wrap_95(object P0, object P1, ref NetResponse P2) {} // 0x00000001892AF040-0x00000001892AF1C0
		public MSG_B1 __Gen_Wrap_96(object P0) => default; // 0x00000001892AF1C0-0x00000001892AF2B0
		public bool __Gen_Wrap_97(object P0, ref FLogMessage P1) => default; // 0x00000001892AF2B0-0x00000001892AF434
		public LogLevel __Gen_Wrap_98(ELogLevel P0) => default; // 0x000000018562802C-0x00000001856280E8
		public NativeLogLevel __Gen_Wrap_99(ELogLevel P0) => default; // 0x00000001856280E8-0x00000001856281B8
		public int __Gen_Wrap_100(ELogChannel P0) => default; // 0x000000018562802C-0x00000001856280E8
		public bool __Gen_Wrap_101(NativeLogLevel P0, int P1) => default; // 0x000000018560DC74-0x000000018560DD5C
		public bool __Gen_Wrap_102(ELogLevel P0, ELogChannel P1) => default; // 0x0000000185164540-0x000000018516462C
		public void __Gen_Wrap_103(object P0, object P1, object P2, UnityEngine.LogType P3) {} // 0x00000001856479C0-0x0000000185647AB8
		public HGNetLoggerClient __Gen_Wrap_104() => default; // 0x00000001892A9F70-0x00000001892AA03C
		public void __Gen_Wrap_105(object P0, ref LogMessage P1) {} // 0x00000001892AA03C-0x00000001892AA150
		public void __Gen_Wrap_106(object P0, ref FLogMessage P1) {} // 0x00000001892AA150-0x00000001892AA2C4
		public void __Gen_Wrap_107(object P0, ulong P1, ulong P2, ulong P3, ulong P4) {} // 0x00000001892AA2C4-0x00000001892AA3D4
		public void __Gen_Wrap_108(object P0, object P1, object P2, object P3, object P4) {} // 0x0000000185476DB4-0x0000000185476ECC
		public void __Gen_Wrap_109(bool P0) {} // 0x00000001850F0C14-0x00000001850F0CC0
		public void __Gen_Wrap_110(ulong P0) {} // 0x000000018514E6A4-0x000000018514E764
		public Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> __Gen_Wrap_111() => default; // 0x00000001892AA3D4-0x00000001892AA4A0
		public Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> __Gen_Wrap_112() => default; // 0x00000001892AA4A0-0x00000001892AA56C
		public bool __Gen_Wrap_113(object P0, out Beyond.Network.HGNetLogger.MessageType P1) {
			P1 = default;
			return default;
		} // 0x0000000185786028-0x0000000185786134
		public void __Gen_Wrap_114(object P0, object P1, NetRequest P2) {} // 0x00000001892AA56C-0x00000001892AA6A0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object>, IAsyncStateMachine // TypeDefIndex: 56216
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
		object IEnumerator<System.Object>.Current { [IDTag(2)] get => default; } // 0x00000001892AF744-0x00000001892AF7F0 
		object IEnumerator.Current { [IDTag(4)] get => default; } // 0x00000001892AF7F0-0x00000001892AF89C 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001892AF89C-0x00000001892AF990
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose() {} // 0x0000000185152EA8-0x0000000185152F24
		[IDTag(1)]
		private bool MoveNext() => default; // 0x0000000185152C48-0x0000000185152CD4
		[IDTag(3)]
		void IEnumerator.Reset() {} // 0x0000000185152D80-0x0000000185152DFC
		[IDTag(5)]
		private void MoveNext() {} // 0x00000001892AF434-0x00000001892AF4C4
		[IDTag(6)]
		private void SetStateMachine(IAsyncStateMachine P0) {} // 0x00000001892AF694-0x00000001892AF744
		public void RefAwaitUnsafeOnCompleteMethod() {} // 0x00000001892AF558-0x00000001892AF694
		public void RefAsyncBuilderStartMethod() {} // 0x00000001892AF4C4-0x00000001892AF558
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 56217
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001892AFD08-0x00000001892AFD6C
		public static bool IsPatched(int id) => default; // 0x00000001824CB460-0x00000001824CB510
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001892AFBC4-0x00000001892AFC90
		public object CreateWrapper(int id) => default; // 0x00000001892AFC90-0x00000001892AFD08
		public object InitWrapperArray(int len) => default; // 0x00000001892AFD6C-0x00000001892AFDF8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001892AFB20-0x00000001892AFBC4
	}

	public enum IDMAP0 // TypeDefIndex: 56218
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
		Beyond-Network-NetBus-ResultHandler-Dispose0 = 44,
		Beyond-Network-NetBus-Sender-DoSend0 = 47,
		Beyond-Network-NetBus-Sender-DoListen0 = 48,
		Beyond-Network-NetBus-Sender-DoUnListen0 = 49,
		Beyond-Network-Special2BusSender-Send0 = 50,
		Beyond-Network-DisposableBusSender-Send0 = 51,
		Beyond-Network-Special2BusSender-OnNetShutDown0 = 53,
		Beyond-Network-DisposableBusSender-OnNetShutDown0 = 54,
		Beyond-Network-DisposableBusSender-_Clear0 = 55,
		Beyond-Network-Special2BusSender-_ClearSendTime0 = 56,
		Beyond-Network-Special2BusSender-Dispose0 = 57,
		Beyond-Network-DisposableBusSender-Dispose0 = 58,
		Beyond-Network-NetworkMaskConfigHolder-Init0 = 60,
		Beyond-Network-NetworkMaskConfigHolder-Dispose0 = 61,
		Beyond-Network-UIBusSender-Dispose0 = 62,
		Beyond-Network-NetworkMask-RemoveMask0 = 64,
		Beyond-Network-NetworkMask-_UpdateMaskState0 = 65,
		Beyond-Network-UIBusSender-Send0 = 70,
		Beyond-Network-NetUtil-GetCSMsgIdByType0 = 75,
		Beyond-Network-NetworkMask-AddMask1 = 76,
		Beyond-Network-NetworkMask-AddMask0 = 77,
		Beyond-Network-NetworkMask-_GetKey0 = 78,
		Beyond-Network-UIBusSender-OnNetShutDown0 = 79,
		Beyond-Network-TeleportMaskSender-Dispose0 = 80,
		Beyond-Network-TeleportMaskSender-Send0 = 81,
		Beyond-Network-TeleportMaskSender-OnNetShutDown0 = 87,
		Beyond-Network-FrequencyControlBusSender-_TrySendWaitingMsg0 = 88,
		Beyond-Network-FrequencyControlBusSender-Send0 = 89,
		Beyond-Network-FrequencyControlBusSender-Send1 = 94,
		Beyond-Network-FrequencyControlBusSender-Dispose0 = 95,
		Beyond-Network-ServerConfig-IsSame0 = 96,
		Beyond-Network-NetUtil-RegisterSCMessage0 = 97,
		Beyond-Network-NetUtil-RegisterCSMessage0 = 98,
		Beyond-Network-NetUtil-GetSCMsgIdByType0 = 99,
		Beyond-Network-NetUtil-FastRegisterMessage0 = 100,
		Beyond-Network-NetUtil-GetNetMessageFromDataBytes0 = 101,
		Beyond-Network-NetUtil-SerializeHeadMessage0 = 102,
		Beyond-Network-NetUtil-AutoRegisterMessageHandlers0 = 103,
		Beyond-Network-NetUtil-AutoUnRegisterMessageHandlers0 = 104,
		Beyond-Network-NetUtil-_ForeachMessageHandlers0 = 108,
		Beyond-Network-NetworkMask-OnInit0 = 109,
		Beyond-Network-NetworkMask-_CreateTickFunction0 = 110,
		Beyond-Network-NetworkMask-PreTick0 = 111,
		Beyond-Network-NetworkMask-_OnSwitchLanguage0 = 112,
		Beyond-Network-NetworkMask-OnUnInit0 = 113,
		Beyond-Network-NetworkMask-_ClearTickFunction0 = 114,
		Beyond-Network-NetworkMask-Release0 = 115,
		Beyond-Network-NetworkMask-ListenOnNetMaskChanged0 = 116,
		Beyond-Network-NetworkMask-UnListenOnNetMaskChanged0 = 117,
		Beyond-Network-NetworkUrls-RemoteConfigUrl0 = 118,
		Beyond-Network-NetworkUrls-ResourceRootUrlDev0 = 119,
		Beyond-Network-NetworkUrls-ServerListUrl0 = 120,
		Beyond-Network-NetworkUrls-_GetUrlFromLocal0 = 121,
		Beyond-Network-NetworkUrls-AgeTipsUrl0 = 122,
		Beyond-Network-NetworkUrls-_SelectUrl0 = 123,
		Beyond-Network-NetworkUrls-GovUrl0 = 124,
		Beyond-Network-NetworkUrls-LauncherUrl0 = 125,
		Beyond-Network-TcpIO-Connect0 = 126,
		Beyond-Network-TcpIO-IsConnected0 = 127,
		Beyond-Network-TcpIO-Close0 = 128,
		Beyond-Network-TcpIO-ConnectAsync0 = 129,
		Beyond-Network-TcpIO-IsAuthed0 = 130,
		Beyond-Network-TcpIO-MarkAuthed0 = 131,
		Beyond-Network-TcpIO-EnableCryptStream0 = 132,
		Beyond-Network-TcpIO-GetEndPoint0 = 133,
		Beyond-Network-TcpIO-TestCloseNetIO0 = 134,
		Beyond-Network-TcpIO-TestDropNetIO0 = 135,
		Beyond-Network-TcpIO-WriteData0 = 136,
		Beyond-Network-TcpIO-WriteCryptoData0 = 137,
		Beyond-Network-TcpIO-GetSendHeadBuffer0 = 138,
		Beyond-Network-TcpIO-GetSendBuffer0 = 139,
		Beyond-Network-TcpIO-GetReceiveBuffer0 = 140,
		Beyond-Network-TcpIO-ClearReceiveBufferOffset0 = 141,
		Beyond-Network-TcpIO-GetReceiveBufferOffset0 = 142,
		Beyond-Network-TcpIO-SkipReceiveBufferOffset0 = 143,
		Beyond-Network-TcpIO-ReadData0 = 144,
		Beyond-Network-TcpIO-ReadCryptoData0 = 145,
		Beyond-Network-TcpIO-Available0 = 146,
		Beyond-Network-TcpIO-Dispose0 = 147,
		Beyond-Network-HttpSender-YieldSendGet1 = 148,
		Beyond-Network-HttpSender-YieldSendGet0 = 152,
		Beyond-Network-HttpSender-_YieldSendHttpRequest1 = 156,
		Beyond-Network-HttpSender-_YieldSendHttpRequest0 = 160,
		Beyond-Network-HttpSender-FSendFunc-GetCancellation0 = 165,
		Beyond-Network-HttpSender-FSendFunc-Invoke0 = 166,
		Beyond-Network-HttpSender-_CreateWebRequestGET0 = 167,
		Beyond-Network-HttpSender-_CreateWebRequestPOST0 = 168,
		Beyond-Network-HttpSender-Cancellation-IsCanceled0 = 169,
		Beyond-Network-HttpSender-_SetHttpResult0 = 170,
		Beyond-Network-HttpSender-_MarkResultAsException0 = 171,
		Beyond-Network-HttpSender-_DeserializeTypedResult0 = 175,
		Beyond-Network-HttpSender-YieldSendPost1 = 186,
		Beyond-Network-HttpSender-YieldSendPost0 = 190,
		Beyond-Network-HttpSender-WaitForSendPost0 = 200,
		Beyond-Network-HttpSender-_WaitForSendHttpRequest0 = 201,
		Beyond-Network-HttpSender-_WaitForServiceDone0 = 204,
		Beyond-Network-HttpSender-_StartWebRequestTask0 = 205,
		Beyond-Network-HttpSender-WaitForSendGet1 = 206,
		Beyond-Network-HttpSender-WaitForSendGet0 = 207,
		Beyond-Network-HttpSender-GetGeneralErrorCode0 = 208,
		Beyond-Network-HttpSender-_DebugOnlyProfileResult0 = 209,
		Beyond-Network-HttpSender-Cancellation-Cancel0 = 210,
		Beyond-Network-HttpSender-FSendFunc-GetOptMethod0 = 211,
		Beyond-Network-HGNetBaseSession-set_reconnectState0 = 212,
		Beyond-Network-HGNetBaseSession-Start0 = 213,
		Beyond-Network-HGNetBaseSession-Connect0 = 215,
		Beyond-Network-HGNetBaseSession-_DNSCheck0 = 216,
		Beyond-Network-HGNetBaseSession-InternalClose1 = 217,
		Beyond-Network-HGNetBaseSession-InternalClose0 = 218,
		Beyond-Network-HGNetBaseSession-RemoveAutoReconnect0 = 219,
		Beyond-Network-HGNetBaseSession-CloseTCPMsgThreadTask0 = 220,
		Beyond-Network-HGNetBaseSession-ConnectAsync0 = 221,
		Beyond-Network-HGNetBaseSession-OnConnectAsyncEnd0 = 224,
		Beyond-Network-HGNetSessionConnectYield-SetFinish0 = 225,
		Beyond-Network-HGNetBaseSession-Close0 = 226,
		Beyond-Network-HGNetBaseSession-EnqueueSendMsg0 = 227,
		Beyond-Network-HGNetBaseSession-GetSendQueueMsgCount0 = 228,
		Beyond-Network-HGNetBaseSession-SetCSSeqID0 = 229,
		Beyond-Network-HGNetBaseSession-GetCSSeqID0 = 230,
		Beyond-Network-HGNetBaseSession-GetIO0 = 231,
		Beyond-Network-HGNetBaseSession-StartTCPMsgLoopThreadTask0 = 232,
		Beyond-Network-HGNetBaseSession-_SessionThread0 = 235,
		Beyond-Network-HGNetBaseSession-_ReconnectCheckerTick0 = 237,
		Beyond-Network-HGNetBaseSession-TryCloseTcpIOWithTimeout0 = 239,
		Beyond-Network-HGNetBaseSession-TryConnectWithTimeout0 = 244,
		Beyond-Network-HGNetBaseSession-SessionCheckSignalAndSleep0 = 250,
		Beyond-Network-HGNetBaseSession-_ReadAndCheckMessageInSessionThread0 = 251,
		Beyond-Network-HGNetBaseSession-NetStatusChecker_Receive0 = 252,
		Beyond-Network-HGNetBaseSession-_SendAndCheckMessage0 = 253,
		Beyond-Network-HGNetBaseSession-NetStatusChecker_Sender0 = 254,
		Beyond-Network-HGNetBaseSession-OpenAutoReconnect0 = 256,
		Beyond-Network-HGNetSession-SetAutoReconnectToken0 = 257,
		Beyond-Network-HGNetSession-SessionConnectTimeoutCheckerTick0 = 258,
		Beyond-Network-HGNetSession-DoReconnectLogin0 = 259,
		Beyond-Network-HGNetSession-GetClientPublicKey0 = 260,
		Beyond-Network-HGNetSession-_CSLoginHelper_UpdateAppInfo0 = 261,
		Beyond-Network-HGNetSession-_GetOnlineResVersion0 = 262,
		Beyond-Network-HGNetSession-_GetPlatformID0 = 263,
		Beyond-Network-HGNetSession-_GetSDKEnv0 = 264,
		Beyond-Network-HGNetSession-_GetPayPlatform0 = 265,
		Beyond-Network-HGNetSession-_WriteMessageInSessionThread0 = 266,
		Beyond-Network-HGNetSession-_ReadMessageInSessionThread0 = 267,
		Beyond-Network-HGNetSession-_ApproximateLoginServerTime0 = 268,
		Beyond-Network-HGNetSession-_HandleLoginEncryp0 = 269,
		Beyond-Network-HGNetSession-_RSADecrypt0 = 270,
		Beyond-Network-HGNetSession-Start0 = 271,
		Beyond-Network-HGNetSession-OnApplicationPause0 = 272,
		Beyond-Network-HGNetSession-LoginAsync0 = 273,
		Beyond-Network-HGNetSession-_SessionLoginThreadTask0 = 274,
		Beyond-Network-HGNetSessionLoginYield-GetRequest0 = 275,
		Beyond-Network-HGNetSessionLoginYield-SetSucceed0 = 276,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Clear0 = 277,
		Beyond-Network-HGNetSessionLoginYield-SetNtfError0 = 280,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Set0 = 281,
		Beyond-Network-HGNetSessionLoginYield-SetConnectErrorError0 = 282,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectError0 = 283,
		Beyond-Network-HGNetSessionLoginYield-SetTimeOutError0 = 284,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectTimeOut0 = 285,
		Beyond-Network-HGNetSession-StartMsgLoop0 = 286,
		Beyond-Network-HGNetSession-OnConnectedSucceed0 = 287,
		Beyond-Network-HGNetSession-OnReconnectTimesOver0 = 288,
		Beyond-Network-HGNetSession-NeedKeepConnect0 = 289,
		Beyond-Network-HGNetSession-CheckAndWriteReqMsg0 = 290,
		Beyond-Network-HGNetSession-ReadMessageInSessionThread0 = 291,
		Beyond-Network-HGNetSession-ClearRecvQueue0 = 292,
		Beyond-Network-HGNetSession-ClearSendQueue0 = 293,
		Beyond-Network-HGNetSession-GetPing0 = 294,
		Beyond-Network-HGNetSession-GetPingPassedTime0 = 295,
		Beyond-Network-HGNetSession-IsPingInProgress0 = 296,
		Beyond-Network-HGNetSession-ClearPingWDG0 = 297,
		Beyond-Network-HGNetSession-_HandleSpecialMessagePing0 = 298,
		Beyond-Network-HGNetSession-IsPingOut0 = 299,
		Beyond-Network-HGNetSession-PingSenderTick0 = 300,
		Beyond-Network-HGNetSession-InitClientRSAKey0 = 301,
		Beyond-Network-HGNetSession-ClearRSAKey0 = 302,
		Beyond-Network-HGNetSession-CheckAndDealRespMessages0 = 303,
		Beyond-Network-HGNetSession-_HandleSpecialMessageErrorCode0 = 304,
		Beyond-Network-HGNetSessionUtils-CheckErrorNeedsDisconnect0 = 305,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectIncr0 = 306,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectFull0 = 307,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectLogin0 = 308,
		Beyond-Network-HGNetSessionLoginYield-GetResponse0 = 309,
		Beyond-Network-HGNetSessionLoginYield-GetErrorCode0 = 310,
		Beyond-Network-HGNetSessionLoginYield-GetErrorDetails0 = 312,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorInvaild0 = 314,
		Beyond-Network-HGNetSessionConnectYield-GetCode0 = 315,
		Beyond-Network-HGNetSessionConnectYield-get_keepWaiting0 = 316,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Start0 = 317,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Connect0 = 318,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DNSCheck0 = 319,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close1 = 320,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close0 = 321,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-RemoveAutoReconnect0 = 322,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-CloseTCPMsgThreadTask0 = 323,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-ConnectAsync0 = 324,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-OnConnectAsyncEnd0 = 325,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-EnqueueSendMsg0 = 326,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetSendQueueMsgCount0 = 327,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-IncrementCSSeqID0 = 328,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-SetCSSeqID0 = 329,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetCSSeqID0 = 330,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetIO0 = 331,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-StartTCPMsgLoopThreadTask0 = 332,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_SessionThread0 = 333,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_ReconnectCheckerTick0 = 334,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-SessionCheckSignalAndSleep0 = 335,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Receive0 = 336,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Sender0 = 337,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-OpenAutoReconnect0 = 338,
		Beyond-Network-HGNetLogger-HGNetLogger-Log0 = 339,
		Beyond-Network-HGNetLogger-HGNetLogger-CheckLog0 = 340,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger0 = 341,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLoggerV20 = 342,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger1 = 343,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-get_instance0 = 344,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-ShutDown0 = 345,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-_CloseAndClear0 = 346,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-AddLog0 = 347,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-_FlushLocalLogQueue0 = 348,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled1 = 349,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-ConvertFromDLogger0 = 350,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled0 = 351,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-WriteNetLog0 = 352,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SendMessage0 = 353,
		Beyond-Network-HGNetLogger-HGNetLogger-Clear0 = 354,
		Beyond-Network-HGNetLogger-HGNetLogger-SetLogChannel0 = 355,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-Init0 = 356,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SetAutoReconnectToken0 = 357,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SetReconnectSuccessCallback0 = 359,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-OnApplicationPause0 = 360,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnApplicationPause0 = 361,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-SetRoleID0 = 362,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-SetNetLogMaskFromServer0 = 364,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-SetCloudLogControl0 = 365,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsLocalLogLevelEnabled0 = 366,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageType2Id0 = 367,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageId2Type0 = 368,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-TryGetMsgTypeByID0 = 369,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-Start0 = 370,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnConnectedSucceed0 = 371,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SendLogin0 = 372,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_WriteMessageInSessionThread0 = 374,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ReadMessageInSessionThread0 = 375,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndDealRespMessages0 = 376,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndWriteReqMsg0 = 377,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-NeedKeepConnect0 = 378,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-DoReconnectLogin0 = 379,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_GetConnectTimeoutTime0 = 380,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SessionConnectTimeoutCheckerTick0 = 381,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearPingWDG0 = 382,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-IsPingOut0 = 383,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-PingSenderTick0 = 384,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-InitClientRSAKey0 = 385,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRSAKey0 = 386,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRecvQueue0 = 387,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearSendQueue0 = 388,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnReconnectTimesOver0 = 389
	}
}
