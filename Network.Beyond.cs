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

// Image 42: Network.Beyond.dll - Assembly: Network.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59396-59502
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Network
{
	public class DoubleQueue<T> // TypeDefIndex: 59403
	{
		// Fields
		private Queue<T> m_readQueue;
		private Queue<T> m_writeQueue;
	
		// Constructors
		public DoubleQueue();
	
		// Methods
		public void LockingSwap();
		public void TryLockingSwap();
		public void Enqueue(T item);
		public bool TryDequeue(out ref T item);
		public void EnqueueRange(List<T> list);
	}

	public enum ENetWeakNetPreset // TypeDefIndex: 59404
	{
		Disabled = 0,
		LightJitter = 1,
		NormalWifiLag = 2,
		PoorMobileNetwork = 3,
		SevereLag = 4
	}

	public class HGTcpClient : IDisposable // TypeDefIndex: 59405
	{
		// Fields
		private Socket m_ClientSocket; // 0x10
		private bool m_Active; // 0x18
		private NetworkStream m_DataStream; // 0x20
		private AddressFamily m_Family; // 0x28
		private bool m_CleanedUp; // 0x2C
	
		// Properties
		public Socket Client { get; set; } // 0x00000001831442C0-0x0000000183144350 0x00000001840EC940-0x00000001840EC980
		protected bool Active { get; set; } // 0x000000018A894B1C-0x000000018A894B64 0x000000018A894D88-0x000000018A894DDC
		public int Available { get; } // 0x000000018314B080-0x000000018314B170 
		public bool Connected { get; } // 0x000000018314AFE0-0x000000018314B080 
		public bool ExclusiveAddressUse { get; set; } // 0x000000018A894B64-0x000000018A894BB8 0x000000018A894DDC-0x000000018A894E44
		public int ReceiveBufferSize { get; set; } // 0x000000018A894C18-0x000000018A894C74 0x00000001840EC980-0x00000001840EC9F0
		public int SendBufferSize { get; set; } // 0x000000018A894CD0-0x000000018A894D2C 0x00000001840EC9F0-0x00000001840ECA60
		public int ReceiveTimeout { get; set; } // 0x000000018A894C74-0x000000018A894CD0 0x000000018A894EC0-0x000000018A894F3C
		public int SendTimeout { get; set; } // 0x000000018A894D2C-0x000000018A894D88 0x00000001840ECA60-0x00000001840ECAD0
		public LingerOption LingerState { get; set; } // 0x00000001840EC260-0x00000001840EC2E0 0x000000018A894E44-0x000000018A894EC0
		public bool NoDelay { get; set; } // 0x000000018A894BB8-0x000000018A894C18 0x00000001840ECAD0-0x00000001840ECB40
	
		// Constructors
		public HGTcpClient(); // 0x00000001840EC880-0x00000001840EC890
		public HGTcpClient(string hostname, int port); // 0x000000018A89498C-0x000000018A894AF8
		internal HGTcpClient(Socket acceptedSocket); // 0x000000018A894AF8-0x000000018A894B1C
	
		// Methods
		[IDTag(1)]
		public void Connect(string hostname, int port); // 0x00000001840ED980-0x00000001840EE260
		[IDTag(2)]
		public void Connect(IPAddress address, int port); // 0x000000018A8946DC-0x000000018A894868
		[IDTag(0)]
		public void Connect(IPEndPoint remoteEP); // 0x00000001840EE780-0x00000001840EE7F0
		[IDTag(3)]
		public void Connect(IPAddress[] ipAddresses, int port); // 0x000000018A894654-0x000000018A8946DC
		[IDTag(0)]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state); // 0x00000001840F20A0-0x00000001840F2130
		[IDTag(1)]
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state); // 0x000000018A8942D4-0x000000018A894384
		[IDTag(2)]
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state); // 0x000000018A894224-0x000000018A8942D4
		public void EndConnect(IAsyncResult asyncResult); // 0x000000018481CC90-0x000000018481CCF0
		[IDTag(0)]
		public System.Threading.Tasks.Task ConnectAsync(IPAddress address, int port); // 0x000000018A894384-0x000000018A8944EC
		[IDTag(1)]
		public System.Threading.Tasks.Task ConnectAsync(string host, int port); // 0x00000001840EBC70-0x00000001840EBE40
		[IDTag(2)]
		public System.Threading.Tasks.Task ConnectAsync(IPAddress[] addresses, int port); // 0x000000018A8944EC-0x000000018A894654
		public NetworkStream GetStream(); // 0x0000000183144110-0x00000001831442C0
		public void Close(); // 0x0000000183994EA0-0x0000000183994F00
		[IDTag(0)]
		protected virtual void Dispose(bool disposing); // 0x00000001839949E0-0x0000000183994EA0
		[IDTag(1)]
		public void Dispose(); // 0x00000001839949A0-0x00000001839949E0
		~HGTcpClient(); // 0x000000018A894868-0x000000018A8948DC
		private void _Initialize(); // 0x00000001840EC890-0x00000001840EC940
		private int _NumericOption(SocketOptionLevel optionLevel, SocketOptionName optionName); // 0x000000018A8948DC-0x000000018A89498C
	}

	public interface INetIO : IDisposable // TypeDefIndex: 59406
	{
		// Methods
		void Connect(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize);
		System.Threading.Tasks.Task ConnectAsync(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize);
		void Close();
		void TestCloseNetIO(bool bIsTestReconnectFailed);
		void TestDropNetIO(bool bIsTestDropSC, bool bIsTestDropCS);
		void SetWeakNetPreset(ENetWeakNetPreset preset);
		void SetWeakNetCustom(int readMinDelayMs, int readMaxDelayMs, int readMaxTriggerCountPerSecond, int writeMinDelayMs, int writeMaxDelayMs, int writeMaxTriggerCountPerSecond);
		TcpIOProfilerSnapshot GetProfilerSnapshot();
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
	public class NetMsgHandlerAttribute : Attribute // TypeDefIndex: 59407
	{
		// Fields
		public readonly System.Type msgType; // 0x10
	
		// Constructors
		public NetMsgHandlerAttribute(System.Type t); // 0x00000001853908C0-0x00000001853908D0
		public NetMsgHandlerAttribute(); // 0x00000001840E20A0-0x00000001840E20C0
	
		// Methods
		public System.Type GetMsgType(MethodInfo annotatedMethod); // 0x00000001840B71D0-0x00000001840B7290
	}

	public delegate void NetResponseHandler([IsReadOnly] in NetResponse msg); // TypeDefIndex: 59408; 0x0000000182B46B90-0x0000000182B46BA0

	public delegate void NetMessageHandle<in T>(T message); // TypeDefIndex: 59409; 0x00000000-0x00000000

	public interface INetBusResponseListener // TypeDefIndex: 59410
	{
		// Methods
		void UpdateMsgTime(NetResponse resp);
	}

	public struct NetRequest // TypeDefIndex: 59411
	{
		// Fields
		public ulong csSeqID; // 0x00
		public int mergeNum; // 0x08
		public IMessage msg; // 0x10
	}

	public struct NetResponse // TypeDefIndex: 59412
	{
		// Fields
		public static NetResponse EMPTY; // 0x00
		public IMessage headMsg; // 0x00
		public IMessage msgBody; // 0x08
		public bool isPacked; // 0x10
		public long recvTimestamp; // 0x18
	
		// Properties
		public Header logHead { get; set; } // 0x00000001836AF1E0-0x00000001836AF240 0x0000000184239180-0x00000001842391C0
		public CSHead csHead { get; set; } // 0x00000001836AE550-0x00000001836AE800 0x0000000183A1B170-0x0000000183A1B1B0
		public int msgId { get; } // 0x00000001836AE3F0-0x00000001836AE550 
		public ulong csSeqId { get; } // 0x00000001836ADB80-0x00000001836AE080 
		public ulong scSeqId { get; } // 0x00000001836ADA10-0x00000001836ADB80 
	
		// Constructors
		static NetResponse(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class MessageHandleWrapper // TypeDefIndex: 59413
	{
		// Constructors
		protected MessageHandleWrapper(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void HandleMessage(IMessage msg);
	}

	public class MessageHandleWrapper<T> : MessageHandleWrapper // TypeDefIndex: 59414
		where T : class, IMessage
	{
		// Fields
		private readonly NetMessageHandle<T> m_handle;
	
		// Constructors
		public MessageHandleWrapper(NetMessageHandle<T> handle);
	
		// Methods
		public override void HandleMessage(IMessage msg);
	}

	public class NetBus : ExplicitSingleton<NetBus> // TypeDefIndex: 59418
	{
		// Fields
		private readonly Dictionary<int, NetResponseHandler> m_msgHandlers; // 0x10
		private readonly Dictionary<int, List<HandlerEntry>> m_msgWithSeqNumHandlers; // 0x18
		private readonly Dictionary<int, MessageHandleWrapper> m_msgHdlWrappers; // 0x20
		private HGNetSession m_netSession; // 0x28
		private static List<NetResponseHandler> s_handlersToCall; // 0x00
		[CompilerGenerated]
		private readonly UIBusSender _uiSender_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly TeleportMaskSender _teleportMaskSender_k__BackingField; // 0x38
		[CompilerGenerated]
		private readonly DisposableBusSender _defaultSender_k__BackingField; // 0x40
		[CompilerGenerated]
		private readonly Special2BusSender _s2Sender_k__BackingField; // 0x48
		[CompilerGenerated]
		private readonly InteractiveBusSender _interactiveSender_k__BackingField; // 0x50
		[CompilerGenerated]
		private readonly FrequencyControlBusSender _frequencyControlSender_k__BackingField; // 0x58
	
		// Properties
		public UIBusSender uiSender { [CompilerGenerated] get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public TeleportMaskSender teleportMaskSender { [CompilerGenerated] get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public DisposableBusSender defaultSender { [CompilerGenerated] get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public Special2BusSender s2Sender { [CompilerGenerated] get; } // 0x0000000184D86200-0x0000000184D86210 
		public InteractiveBusSender interactiveSender { [CompilerGenerated] get; } // 0x0000000184D86270-0x0000000184D86280 
		public FrequencyControlBusSender frequencyControlSender { [CompilerGenerated] get; } // 0x0000000182E56440-0x0000000182E56460 
		public int currentSessionID { get; } // 0x0000000183A4E9C0-0x0000000183A4EA30 
	
		// Nested types
		private class HandlerEntry // TypeDefIndex: 59415
		{
			// Fields
			public NetResponseHandler handler; // 0x10
	
			// Constructors
			public HandlerEntry(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class ResultHandler : IDisposable // TypeDefIndex: 59416
		{
			// Fields
			private bool m_ignoreSeq; // 0x10
			private ListDict<SCMessageID, object> m_responseTokens; // 0x18
			private ListDict<SCMessageID, NetResponseHandler> m_responseHandlers; // 0x20
			[CompilerGenerated]
			private bool _isDisposed_k__BackingField; // 0x28
			[CompilerGenerated]
			private ulong _cachedSeqNum_k__BackingField; // 0x30
			[CompilerGenerated]
			private int _sessionID_k__BackingField; // 0x38
	
			// Properties
			public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
			internal ulong cachedSeqNum { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x00000001811F36F0-0x00000001811F3700
			public int sessionID { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
	
			// Constructors
			public ResultHandler(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void SetIgnoreSeq(bool ignoreSeq); // 0x000000018A898E20-0x000000018A898E74
			public ResultHandler OnResponse(SCMessageID msgId, NetResponseHandler handler); // 0x0000000183A4F4A0-0x0000000183A4F820
			public void Dispose(); // 0x0000000183A4EB80-0x0000000183A4F4A0
			private bool _CheckSessionIDValid(); // 0x0000000183A4E950-0x0000000183A4E9C0
			private void _HandleMessage([IsReadOnly] in NetResponse msg); // 0x0000000183A4E7E0-0x0000000183A4E950
		}
	
		public abstract class Sender // TypeDefIndex: 59417
		{
			// Constructors
			protected Sender(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public abstract ResultHandler Send(IMessage msg);
			public abstract void OnNetShutDown();
			protected ResultHandler DoSend(IMessage message); // 0x0000000183AC46C0-0x0000000183AC4730
			protected void DoListen(SCMessageID msgId, NetResponseHandler handler); // 0x000000018A898E74-0x000000018A898F14
			protected void DoUnListen(SCMessageID msgId, NetResponseHandler handler); // 0x000000018A898F14-0x000000018A898FB4
		}
	
		// Constructors
		public NetBus(); // 0x0000000183BA9780-0x0000000183BA9A00
		static NetBus(); // 0x0000000184D175B0-0x0000000184D17640
	
		// Methods
		public bool IsBusBusy(); // 0x000000018A895968-0x000000018A8959B0
		public void Setup(HGNetSession session); // 0x0000000183A4BFC0-0x0000000183A4C000
		public void Send(IMessage msg); // 0x00000001836AF5E0-0x00000001836AF640
		public void RegisterMessageHandler(int msgId, MessageHandleWrapper handler); // 0x0000000183895000-0x0000000183895080
		public void UnRegisterMessageHandler(int msgId); // 0x000000018A8959B0-0x000000018A895A18
		public void HandleMessageTime(NetResponse response); // 0x000000018A8955F8-0x000000018A895678
		public void HandleMessage(NetResponse response); // 0x000000018A895678-0x000000018A895968
		private bool _ValidateSession(); // 0x00000001836AF640-0x00000001836AF680
		public void OnNetClientShutDown(); // 0x0000000183A4BC60-0x0000000183A4BD00
		private ResultHandler _SendWithResult(IMessage msg); // 0x0000000183AC4730-0x0000000183AC47D0
		private void _Listen(int msgId, NetResponseHandler handler); // 0x000000018A895B4C-0x000000018A895C80
		private void _UnListen(int msgId, NetResponseHandler handler); // 0x000000018A895C80-0x000000018A895DAC
		private object _ListenWithSeqNum(int msgId, NetResponseHandler callback); // 0x000000018A895A18-0x000000018A895B4C
		private void _UnListenWithSeqNum(int msgId, object token); // 0x0000000183A4F820-0x0000000183A4F950
	}

	public class Special2BusSender : DisposableBusSender, INetBusResponseListener // TypeDefIndex: 59419
	{
		// Fields
		public Dictionary<ulong, double> sendedMsgWithTime; // 0x20
		public double minSendTime; // 0x28
		private float m_maxWaitTime; // 0x30
	
		// Properties
		public virtual bool isBusBusy { get; } // 0x0000000183231E70-0x0000000183231F20 
	
		// Constructors
		public Special2BusSender(); // 0x0000000183BA9BD0-0x0000000183BA9C70
	
		// Methods
		public override NetBus.ResultHandler Send(IMessage msg); // 0x0000000183AC4590-0x0000000183AC4650
		public void UpdateStartBlockTime(); // 0x000000018A899144-0x000000018A89927C
		public override void OnNetShutDown(); // 0x0000000183A4CA20-0x0000000183A4CA60
		public override void Dispose(); // 0x000000018A899038-0x000000018A899090
		private void _ClearSendTime(); // 0x0000000183A4C9B0-0x0000000183A4CA20
		public void UpdateMsgTime(NetResponse resp); // 0x000000018A899098-0x000000018A899144
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0); // 0x000000018A893C28-0x000000018A893C30
		public void __iFixBaseProxy_OnNetShutDown(); // 0x000000018A899090-0x000000018A899098
		public void __iFixBaseProxy_Dispose(); // 0x000000018A893C20-0x000000018A893C28
	}

	public class InteractiveBusSender : Special2BusSender // TypeDefIndex: 59420
	{
		// Fields
		private float m_maxWaitTime; // 0x38
	
		// Properties
		public override bool isBusBusy { get; } // 0x0000000183231DC0-0x0000000183231E70 
	
		// Constructors
		public InteractiveBusSender(); // 0x0000000185395568-0x0000000185395578
	
		// Methods
		public bool __iFixBaseProxy_get_isBusBusy(); // 0x000000018A8955F0-0x000000018A8955F8
	}

	public class DisposableBusSender : NetBus.Sender, IDisposable // TypeDefIndex: 59421
	{
		// Fields
		private readonly HashSet<NetBus.ResultHandler> m_resultHandlers; // 0x10
		[CompilerGenerated]
		private bool _isDisposed_k__BackingField; // 0x18
	
		// Properties
		public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
	
		// Constructors
		public DisposableBusSender(); // 0x0000000183BA9C70-0x0000000183BA9CF0
	
		// Methods
		public override NetBus.ResultHandler Send(IMessage msg); // 0x0000000183AC4650-0x0000000183AC46C0
		public override void OnNetShutDown(); // 0x0000000183A4D540-0x0000000183A4D580
		public virtual void Dispose(); // 0x000000018A893494-0x000000018A8934E8
		private void _Clear(); // 0x0000000183A4EA30-0x0000000183A4EB80
	}

	public class NetworkMaskConfigHolder // TypeDefIndex: 59422
	{
		// Fields
		public Dictionary<CSMessageID, SCMessageID> msgs; // 0x10
	
		// Constructors
		public NetworkMaskConfigHolder(); // 0x0000000183BA9AD0-0x0000000183BA9B50
	
		// Methods
		public void Init(); // 0x0000000183BA9110-0x0000000183BA9220
		private void _LoadJsonConfig(StringPathHash jsonHash); // 0x000000018A89802C-0x000000018A8985DC
		private void _LoadScriptableObjectConfig(); // 0x0000000183BAA9E0-0x0000000183BAB1A0
		public void Dispose(); // 0x000000018A897FB4-0x000000018A89802C
	}

	public class UIBusSender : DisposableBusSender // TypeDefIndex: 59424
	{
		// Fields
		[CompilerGenerated]
		private NetworkMaskConfigHolder _config_k__BackingField; // 0x20
		private HashSet<int> m_maskKeys; // 0x28
	
		// Properties
		public NetworkMaskConfigHolder config { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 59423
		{
			// Fields
			public int key; // 0x10
			public UIBusSender __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Send_b__0([IsReadOnly] in NetResponse resp); // 0x000000018A899A04-0x000000018A899A80
			internal void _Send_b__1([IsReadOnly] in NetResponse resp); // 0x000000018A899AF0-0x000000018A899B6C
			internal void _Send_b__2([IsReadOnly] in NetResponse resp); // 0x000000018A899C4C-0x000000018A899CC8
		}
	
		// Constructors
		public UIBusSender(); // 0x0000000183BA9A00-0x0000000183BA9AD0
	
		// Methods
		public override void Dispose(); // 0x000000018A899FD4-0x000000018A89A1C8
		public override NetBus.ResultHandler Send(IMessage msg); // 0x000000018A89A1C8-0x000000018A89A610
		public override void OnNetShutDown(); // 0x0000000183A4C140-0x0000000183A4C400
		public void __iFixBaseProxy_Dispose(); // 0x000000018A893C20-0x000000018A893C28
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0); // 0x000000018A893C28-0x000000018A893C30
		public void __iFixBaseProxy_OnNetShutDown(); // 0x000000018A899090-0x000000018A899098
	}

	public class TeleportMaskSender : DisposableBusSender // TypeDefIndex: 59426
	{
		// Fields
		private HashSet<int> m_maskKeys; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 59425
		{
			// Fields
			public int key; // 0x10
			public TeleportMaskSender __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Send_b__0([IsReadOnly] in NetResponse resp); // 0x000000018A899870-0x000000018A8998EC
			internal void _Send_b__1([IsReadOnly] in NetResponse resp); // 0x0000000183A4CE00-0x0000000183A4CE80
			internal void _Send_b__2([IsReadOnly] in NetResponse resp); // 0x000000018A8998EC-0x000000018A899968
			internal void _Send_b__3([IsReadOnly] in NetResponse resp); // 0x000000018A899968-0x000000018A8999E4
		}
	
		// Constructors
		public TeleportMaskSender(); // 0x0000000183BA9B50-0x0000000183BA9BD0
	
		// Methods
		public override void Dispose(); // 0x000000018A89964C-0x000000018A899824
		public NetBus.ResultHandler Send(IMessage msg, float delay); // 0x0000000183A4E360-0x0000000183A4E7E0
		public override void OnNetShutDown(); // 0x0000000183A4C400-0x0000000183A4C6C0
		public void __iFixBaseProxy_Dispose(); // 0x000000018A893C20-0x000000018A893C28
		public void __iFixBaseProxy_OnNetShutDown(); // 0x000000018A899090-0x000000018A899098
	}

	public class FrequencyControlBusSender : DisposableBusSender // TypeDefIndex: 59428
	{
		// Fields
		private readonly Dictionary<CSMessageID, Queue<double>> m_lastSendTime; // 0x20
		private List<IMessage> m_waitingSendMsgs; // 0x28
		private List<Action<int>> m_onError; // 0x30
		private TickFunction m_loopId; // 0x38
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 59427
		{
			// Fields
			public Action<int> onError; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Send_b__0([IsReadOnly] in NetResponse errorMsg); // 0x000000018A899A80-0x000000018A899AF0
			internal void _Send_b__1([IsReadOnly] in NetResponse errorMsg); // 0x000000018A899B6C-0x000000018A899BDC
			internal void _Send_b__2([IsReadOnly] in NetResponse errorMsg); // 0x000000018A899BDC-0x000000018A899C4C
		}
	
		// Constructors
		public FrequencyControlBusSender(); // 0x000000018382A7D0-0x000000018382A9A0
	
		// Methods
		private void _TrySendWaitingMsg(float deltaTime); // 0x0000000184CCF2E0-0x0000000184CCF3A0
		[IDTag(1)]
		public override NetBus.ResultHandler Send(IMessage msg); // 0x000000018A893640-0x000000018A8936B4
		[IDTag(0)]
		public NetBus.ResultHandler Send(IMessage msg, bool needAddToWaitingList, Action<int> onError = null, Action onWait = null); // 0x000000018A8936B4-0x000000018A893C20
		public override void Dispose(); // 0x000000018A89359C-0x000000018A893640
		public NetBus.ResultHandler __iFixBaseProxy_Send(IMessage P0); // 0x000000018A893C28-0x000000018A893C30
		public void __iFixBaseProxy_Dispose(); // 0x000000018A893C20-0x000000018A893C28
	}

	[Serializable]
	public class ServerDesc // TypeDefIndex: 59429
	{
		// Fields
		public string name; // 0x10
		public string addr; // 0x18
		public int port; // 0x20
	
		// Constructors
		public ServerDesc(); // 0x00000001841AB130-0x00000001841AB170
	}

	[Serializable]
	public class ServerList // TypeDefIndex: 59430
	{
		// Fields
		public List<ServerDesc> servers; // 0x10
	
		// Constructors
		public ServerList(); // 0x0000000184D2DF20-0x0000000184D2DFA0
	}

	public class ServerConfig // TypeDefIndex: 59431
	{
		// Fields
		public string serverName; // 0x10
		public string uid; // 0x18
		public bool checkDev; // 0x20
	
		// Constructors
		public ServerConfig(); // 0x0000000184D53840-0x0000000184D538A0
	
		// Methods
		public bool IsSame(ServerConfig other); // 0x000000018A898FB4-0x000000018A899038
	}

	public class HostData // TypeDefIndex: 59432
	{
		// Fields
		public string host; // 0x10
		public int port; // 0x18
		public double delay; // 0x20
	
		// Constructors
		public HostData(); // 0x0000000183DA4C40-0x0000000183DA4C90
	}

	public class NetConfig // TypeDefIndex: 59433
	{
		// Fields
		public List<HostData> hosts; // 0x10
	
		// Constructors
		public NetConfig(List<HostData> hosts); // 0x00000001853908C0-0x00000001853908D0
	}

	public static class NetConsts // TypeDefIndex: 59434
	{
		// Fields
		public static readonly string NETMASK_CONFIG_PATH; // 0x00
		public static readonly string NETMASK_CONFIG_JSON_PATH; // 0x08
		public static readonly string NETMASK_PREFAB_PATH; // 0x10
	
		// Constructors
		static NetConsts(); // 0x0000000184CC95D0-0x0000000184CC96B0
	}

	public interface INetworkSystem : ILuaCallCSharp // TypeDefIndex: 59435
	{
		// Methods
		void OnReConnect();
		void SendMsg(IMessage msg, Action<int> onError);
	}

	[Serializable]
	public class NetMaskConfig // TypeDefIndex: 59437
	{
		// Fields
		public Dictionary<string, Config> configs; // 0x10
	
		// Nested types
		[Serializable]
		public class Config // TypeDefIndex: 59436
		{
			// Fields
			public Dictionary<int, SCMessageID> messages; // 0x10
	
			// Constructors
			public Config(); // 0x000000018A89341C-0x000000018A893494
		}
	
		// Constructors
		public NetMaskConfig(); // 0x000000018A895DAC-0x000000018A895E24
	}

	public struct TcpIOProfilerSnapshot // TypeDefIndex: 59438
	{
		// Fields
		public long readApiCallCount; // 0x00
		public long readApiCallCountPerSecond; // 0x08
		public long writeApiCallCount; // 0x10
		public long writeApiCallCountPerSecond; // 0x18
		public long totalReadBytes; // 0x20
		public long totalWriteBytes; // 0x28
		public long readBytesPerSecond; // 0x30
		public long writeBytesPerSecond; // 0x38
	}

	public struct NetSessionProfilerSnapshot // TypeDefIndex: 59439
	{
		// Fields
		public long logicalSendPacketCount; // 0x00
		public long logicalSendPacketCountPerSecond; // 0x08
		public long actualSendPacketCount; // 0x10
		public long actualSendPacketCountPerSecond; // 0x18
		public long receivePacketCount; // 0x20
		public long receivePacketCountPerSecond; // 0x28
	}

	public struct NetDevProfilerSnapshot // TypeDefIndex: 59440
	{
		// Fields
		public TcpIOProfilerSnapshot tcpIO; // 0x00
		public NetSessionProfilerSnapshot session; // 0x40
	}

	public static class NetUtil // TypeDefIndex: 59443
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
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 59441
		{
			// Fields
			public object target; // 0x10
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _AutoRegisterMessageHandlers_b__0(System.Type msgType, MethodInfo methodInfo); // 0x0000000183895110-0x0000000183895320
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59442
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<System.Type, MethodInfo> __9__19_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018A899CC8-0x000000018A899D2C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _AutoUnRegisterMessageHandlers_b__19_0(System.Type msgType, MethodInfo methodInfo); // 0x000000018A899824-0x000000018A899870
		}
	
		// Constructors
		static NetUtil(); // 0x000000018404E310-0x000000018404E500
	
		// Methods
		public static void RegisterSCMessage(int msgId, System.Type msgType); // 0x0000000183693A30-0x0000000183693B60
		public static void RegisterCSMessage(int msgId, System.Type msgType); // 0x00000001836928F0-0x00000001836929C0
		public static int GetSCMsgIdByType(System.Type msgType); // 0x0000000183895080-0x0000000183895110
		public static System.Type GetSCMsgTypeById(int msgId); // 0x000000018A895FE8-0x000000018A896098
		public static int GetCSMsgIdByType(System.Type msgType); // 0x0000000183142260-0x00000001831422F0
		private static void _GenMessageName2ValuePair<T>(Dictionary<string, int> dic)
			where T : Enum;
		public static void FastRegisterMessage(); // 0x00000001836935C0-0x00000001836939B0
		public static bool GetNetMessageFromDataBytes(Span<byte> headBytes, byte[] bodyBuffer, int offset, int bodyLen, byte[] packedbuffer, out NetResponse response); // 0x0000000183A19EE0-0x0000000183A1B080
		public static int SerializeHeadMessage(IMessage msg, ulong upSeqid, int bodyLen, int crc32, byte[] buffer, int offset = 0 /* Metadata: 0x0234CA23 */); // 0x0000000183142960-0x0000000183142C70
		public static int SerializeBodyMessage(IMessage msg, byte[] buffer, out int crc32, int offset = 0 /* Metadata: 0x0234CA24 */); // 0x000000018A896098-0x000000018A896288
		public static void AutoRegisterMessageHandlers(object target); // 0x0000000184331FF0-0x00000001843320F0
		public static void AutoUnRegisterMessageHandlers(object target); // 0x000000018A895EA4-0x000000018A895FE8
		private static void _ForeachMessageHandlers(object target, Action<System.Type, MethodInfo> doFunc); // 0x0000000182F2F9F0-0x0000000182F2FB00
	}

	public static class NetworkFrequencyConfig // TypeDefIndex: 59445
	{
		// Fields
		public static SerializeFieldDictionary<int, NetworkFrequency> msgs; // 0x00
	
		// Nested types
		public class NetworkFrequency // TypeDefIndex: 59444
		{
			// Fields
			public System.Type type; // 0x10
			public float second; // 0x18
			public int maxCount; // 0x1C
	
			// Constructors
			public NetworkFrequency(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		static NetworkFrequencyConfig(); // 0x000000018A896288-0x000000018A897FB4
	}

	public class NetworkMask : Singleton<NetworkMask> // TypeDefIndex: 59447
	{
		// Fields
		private TickFunction m_preTickFunction; // 0x10
		private int m_nextKey; // 0x18
		public GameObject maskObj; // 0x20
		public GameObject decoObj; // 0x28
		private FAssetProxyHandle m_handle; // 0x30
		private Action<bool> m_onNetMaskChanged; // 0x48
		[CompilerGenerated]
		private bool _showingMask_k__BackingField; // 0x50
		[CompilerGenerated]
		private bool _showingDeco_k__BackingField; // 0x51
		private bool m_isNetReconnecting; // 0x52
		private const string DECO_NAME = "Deco"; // Metadata: 0x0234CA31
		private List<MaskInfo> m_masks; // 0x58
	
		// Properties
		public bool showingMask { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
		public bool showingDeco { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D867F0-0x0000000184D86800 0x0000000184D86830-0x0000000184D86840
	
		// Nested types
		public class MaskInfo // TypeDefIndex: 59446
		{
			// Fields
			public int key; // 0x10
			public string name; // 0x18
			public float startTime; // 0x20
			public float delayTime; // 0x24
			public float timeoutTime; // 0x28
	
			// Properties
			public float endTime { get; } // 0x0000000183A4CDD0-0x0000000183A4CE00 
			public float showDecoTime { get; } // 0x0000000183A4CDA0-0x0000000183A4CDD0 
	
			// Constructors
			public MaskInfo(); // 0x0000000184DA5BB0-0x0000000184DA5BC0
		}
	
		// Constructors
		private NetworkMask(); // 0x00000001847A6DA0-0x00000001847A6E40
	
		// Methods
		protected void OnInit(); // 0x00000001847A6E40-0x00000001847A71B0
		protected void OnUnInit(); // 0x000000018A89869C-0x000000018A898738
		public void Release(); // 0x000000018A898738-0x000000018A898848
		private void _OnSwitchLanguage(); // 0x000000018A898968-0x000000018A898C40
		private void _CreateTickFunction(); // 0x00000001847A71B0-0x00000001847A7290
		private void _ClearTickFunction(); // 0x000000018A898900-0x000000018A898968
		public void PreTick(float deltaTime); // 0x0000000183A4CB30-0x0000000183A4CBE0
		private int _GetKey(); // 0x0000000183A4CF90-0x0000000183A4CFC0
		[IDTag(1)]
		public int AddMask(CSMessageID msgId, float timeoutTime = 600f /* Metadata: 0x0234CA25 */); // 0x000000018A8985DC-0x000000018A89869C
		[IDTag(0)]
		public int AddMask(string name, float timeoutTime = 600f /* Metadata: 0x0234CA29 */, float delayTime = 0.5f /* Metadata: 0x0234CA2D */); // 0x0000000183A4CE80-0x0000000183A4CF90
		public void RemoveMask(int key); // 0x0000000183A4CA60-0x0000000183A4CB30
		public void SetIsNetReconnecting(bool isReconnecting); // 0x0000000184DA5BC0-0x0000000184DA5BD0
		private void _UpdateMaskState(); // 0x0000000183A4CBE0-0x0000000183A4CDA0
		public void ListenOnNetMaskChanged(Action<bool> action); // 0x0000000184A290A0-0x0000000184A29110
		public void UnListenOnNetMaskChanged(Action<bool> action); // 0x000000018A898848-0x000000018A898900
	}

	public class NetworkMaskConfig : ScriptableObject // TypeDefIndex: 59449
	{
		// Fields
		[SerializeField]
		public SerializeFieldDictionary<CSMessageID, SCMessageID> msgs; // 0x18
		[SerializeField]
		public List<Config> configs; // 0x20
	
		// Nested types
		[Serializable]
		public class Config // TypeDefIndex: 59448
		{
			// Fields
			[SerializeField]
			public string key; // 0x10
			[SerializeField]
			public SerializeFieldDictionaryPaired<CSMessageID, SCMessageID> messages; // 0x18
	
			// Constructors
			public Config(); // 0x0000000184B30D40-0x0000000184B30DC0
		}
	
		// Constructors
		public NetworkMaskConfig(); // 0x0000000184CB5BA0-0x0000000184CB5C70
	}

	public static class NetworkUrls // TypeDefIndex: 59451
	{
		// Fields
		public const string URL_GET_SPLIT = "/"; // Metadata: 0x0234CA36
	
		// Nested types
		private enum EUrlType // TypeDefIndex: 59450
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
		public static string RemoteConfigUrl(); // 0x0000000183C0DDD0-0x0000000183C0DE30
		public static string ResourceRootUrlDev(string version); // 0x000000018A898D70-0x000000018A898E20
		public static string ServerListUrl(); // 0x0000000183C082B0-0x0000000183C082E0
		public static string AgeTipsUrl(); // 0x000000018A898C40-0x000000018A898CD8
		public static string GovUrl(); // 0x000000018A898CD8-0x000000018A898D70
		public static string LauncherUrl(); // 0x000000018340BD20-0x000000018340BDA0
		private static string _SelectUrl(string urlInConfig, EUrlType urlType); // 0x000000018340DC70-0x000000018340DD00
		private static string _GetUrlFromLocal(EUrlType type); // 0x0000000183C082E0-0x0000000183C08390
	}

	public class TcpIO : INetIO // TypeDefIndex: 59453
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
		private readonly object m_readWeakNetLock; // 0x50
		private readonly object m_writeWeakNetLock; // 0x58
		private bool m_bIsTestReconnectFailed; // 0x60
		private long m_readWeakNetWindowStartMs; // 0x68
		private long m_writeWeakNetWindowStartMs; // 0x70
		private int m_readWeakNetTriggerCount; // 0x78
		private int m_writeWeakNetTriggerCount; // 0x7C
		private WeakNetDelayConfig m_readWeakNetConfig; // 0x80
		private WeakNetDelayConfig m_writeWeakNetConfig; // 0x90
		public const int SEND_HEAD_BUFFER_LENGTH = 256; // Metadata: 0x0234CA3F
		public static int s_MAX_SEND_SIZE; // 0x00
		private static readonly System.Random s_random; // 0x08
	
		// Nested types
		private struct WeakNetDelayConfig // TypeDefIndex: 59452
		{
			// Fields
			public bool enabled; // 0x00
			public int minDelayMs; // 0x04
			public int maxDelayMs; // 0x08
			public int maxTriggerCountPerSecond; // 0x0C
		}
	
		// Constructors
		public TcpIO(); // 0x0000000183A4B2F0-0x0000000183A4B3A0
		static TcpIO(); // 0x0000000184022150-0x00000001840221F0
	
		// Methods
		public void Connect(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize); // 0x00000001840EC0B0-0x00000001840EC260
		public System.Threading.Tasks.Task ConnectAsync(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize); // 0x00000001840EBE40-0x00000001840EC030
		public bool IsAuthed(); // 0x00000001831491C0-0x0000000183149260
		public void MarkAuthed(); // 0x0000000183219110-0x0000000183219140
		public void EnableCryptStream(byte[] key, byte[] iv); // 0x00000001849E1B50-0x00000001849E1D90
		public EndPoint GetEndPoint(); // 0x000000018A89927C-0x000000018A899304
		public void Close(); // 0x00000001839944E0-0x00000001839949A0
		public void TestCloseNetIO(bool bIsTestReconnectFailed); // 0x000000018A8993A8-0x000000018A899414
		public void TestDropNetIO(bool bIsTestDropSC, bool bIsTestDropCS); // 0x000000018A899414-0x000000018A899484
		public void SetWeakNetPreset(ENetWeakNetPreset preset); // 0x00000001838EA280-0x00000001838EA2E0
		public void SetWeakNetCustom(int readMinDelayMs, int readMaxDelayMs, int readMaxTriggerCountPerSecond, int writeMinDelayMs, int writeMaxDelayMs, int writeMaxTriggerCountPerSecond); // 0x00000001838EA2E0-0x00000001838EA3F0
		public bool IsConnected(); // 0x000000018314ACA0-0x000000018314AEB0
		public TcpIOProfilerSnapshot GetProfilerSnapshot(); // 0x000000018A899304-0x000000018A8993A8
		public void WriteData(byte[] data, int offset, int len); // 0x0000000183145500-0x0000000183145700
		public void WriteCryptoData(byte[] data, int offset, int len); // 0x0000000183142580-0x0000000183142620
		public byte[] GetSendHeadBuffer(); // 0x0000000183142620-0x0000000183142650
		public byte[] GetSendBuffer(); // 0x0000000183143910-0x0000000183143940
		public byte[] GetReceiveBuffer(); // 0x0000000183149B30-0x0000000183149BD0
		public void ClearReceiveBufferOffset(); // 0x0000000183F636B0-0x0000000183F63750
		public int GetReceiveBufferOffset(); // 0x000000018314AEB0-0x000000018314AF50
		public void SkipReceiveBufferOffset(int len); // 0x0000000183F2E980-0x0000000183F2EA20
		public int ReadData(byte[] buffer, int offset, int len); // 0x0000000183143E50-0x0000000183144110
		public int ReadCryptoData(byte[] buffer, int offset, int len); // 0x0000000183143CE0-0x0000000183143E50
		public int Available(); // 0x000000018314A480-0x000000018314A640
		public void Dispose(); // 0x0000000183994450-0x0000000183994490
		private static void _ResetWeakNetWindow(ref long windowStartMs, ref int triggerCount); // 0x00000001838EA4C0-0x00000001838EA540
		private static WeakNetDelayConfig _CreateWeakNetDelayConfig(int minDelayMs, int maxDelayMs, int maxTriggerCountPerSecond); // 0x00000001838EA3F0-0x00000001838EA4C0
		private static int _NextDelayMs(WeakNetDelayConfig config); // 0x000000018A899484-0x000000018A89964C
		private static void _ApplyWeakNetDelay(object delayLock, WeakNetDelayConfig config, ref long windowStartMs, ref int triggerCount); // 0x0000000183144350-0x00000001831445F0
		~TcpIO(); // 0x00000001839943D0-0x0000000183994450
	}

	public static class HttpSender // TypeDefIndex: 59472
	{
		// Fields
		public const string CONTENT_TYPE_JSON = "application/json"; // Metadata: 0x0234CA41
		public const string CONTENT_ENCODING_GZIP = "gzip"; // Metadata: 0x0234CA52
		public const int ERROR_CODE_TIMEOUT = 10000; // Metadata: 0x0234CA57
		public const int ERROR_CODE_DNS_FAILED = 11000; // Metadata: 0x0234CA5B
		public const int ERROR_CODE_DESERIALIZE = 20000; // Metadata: 0x0234CA5F
		public const float TIMEOUT_DEFAULT = 20f; // Metadata: 0x0234CA63
		private const int OPT_GET = 1; // Metadata: 0x0234CA67
		private const int OPT_POST = 2; // Metadata: 0x0234CA68
	
		// Nested types
		public enum ErrorType // TypeDefIndex: 59454
		{
			NONE = 0,
			TIMEOUT = 1,
			DNS_FAILED = 2,
			CANCELED = 3,
			INTERNAL = 4
		}
	
		public class Cancellation // TypeDefIndex: 59455
		{
			// Fields
			private bool m_isCancelled; // 0x10
			[CompilerGenerated]
			private Action OnCancelInvoked; // 0x18
	
			// Events
			public event Action OnCancelInvoked {
				add; // 0x000000018A8932F4-0x000000018A893388
				remove; // 0x000000018A893388-0x000000018A89341C
			}
	
			// Constructors
			public Cancellation(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Cancel(); // 0x000000018A893240-0x000000018A8932A0
			public bool IsCanceled(); // 0x000000018A8932A0-0x000000018A8932F4
		}
	
		public struct FGetOptions // TypeDefIndex: 59456
		{
			// Fields
			public static readonly FGetOptions DEFAULT; // 0x00
			public Dictionary<string, string> headers; // 0x00
			public string contentType; // 0x08
			public bool headOnly; // 0x10
			public Cancellation cancellation; // 0x18
	
			// Constructors
			static FGetOptions(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public struct FPostOptions // TypeDefIndex: 59457
		{
			// Fields
			public static readonly FPostOptions DEFAULT; // 0x00
			public Dictionary<string, string> headers; // 0x00
			public string textBody; // 0x08
			public string contentType; // 0x10
			public Cancellation cancellation; // 0x18
	
			// Constructors
			static FPostOptions(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private struct FSendFunc // TypeDefIndex: 59458
		{
			// Fields
			public string url; // 0x00
			public int opt; // 0x08
			public FGetOptions optionsGET; // 0x10
			public FPostOptions optionsPOST; // 0x30
			public bool editorOnly; // 0x50
	
			// Methods
			public UnityWebRequest Invoke(); // 0x0000000183E37380-0x0000000183E37400
			public Cancellation GetCancellation(); // 0x0000000183E37330-0x0000000183E37380
			public string GetOptMethod(); // 0x000000018A8934E8-0x000000018A89359C
		}
	
		public class Result // TypeDefIndex: 59459
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
			public Result(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class TypedResult : Result // TypeDefIndex: 59460
		{
			// Fields
			[CompilerGenerated]
			private System.Type _respType_k__BackingField; // 0x48
			public object respObject; // 0x50
			public bool isDeserializeFailed; // 0x58
	
			// Properties
			public System.Type respType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
	
			// Constructors
			public TypedResult(System.Type respType); // 0x00000001835A41A0-0x00000001835A41B0
		}
	
		public class Result<TResp> : TypedResult // TypeDefIndex: 59461
			where TResp : class
		{
			// Constructors
			public Result();
	
			// Methods
			public TResp GetRespObject();
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendGet_d__16 : IEnumerator<object> // TypeDefIndex: 59462
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string url; // 0x20
			public FGetOptions options; // 0x28
			public Misc.ObjectRef resultRef; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendGet_d__16(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C07E90-0x0000000183C07F10
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A899D2C-0x000000018A899D78
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendGet_d__17<TResp> : IEnumerator<object> // TypeDefIndex: 59463
			where TResp : class
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string url;
			public FGetOptions options;
			public Misc.ObjectRef resultRef;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendGet_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendGet_d__18 : IEnumerator<object> // TypeDefIndex: 59464
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FGetOptions options; // 0x20
			public string url; // 0x40
			public Misc.ObjectRef resultRef; // 0x48
			public System.Type respType; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendGet_d__18(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001846BACA0-0x00000001846BAD90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A899D78-0x000000018A899DC4
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendPost_d__19 : IEnumerator<object> // TypeDefIndex: 59465
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string url; // 0x20
			public FPostOptions options; // 0x28
			public Misc.ObjectRef resultRef; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendPost_d__19(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018A899DC4-0x000000018A899E2C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A899E2C-0x000000018A899E78
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendPost_d__20<TResp> : IEnumerator<object> // TypeDefIndex: 59466
			where TResp : class
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string url;
			public FPostOptions options;
			public Misc.ObjectRef resultRef;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendPost_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendPost_d__21 : IEnumerator<object> // TypeDefIndex: 59467
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FPostOptions options; // 0x20
			public string url; // 0x40
			public Misc.ObjectRef resultRef; // 0x48
			public System.Type respType; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendPost_d__21(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001846BABB0-0x00000001846BACA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A899E78-0x000000018A899EC4
		}
	
		[CompilerGenerated]
		private sealed class __YieldSendHttpRequest_d__28 : IEnumerator<object> // TypeDefIndex: 59468
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __YieldSendHttpRequest_d__28(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018A899F10-0x000000018A899F88
			private bool MoveNext(); // 0x0000000183E363C0-0x0000000183E372C0
			private void __m__Finally1(); // 0x0000000183E37400-0x0000000183E37460
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A899EC4-0x000000018A899F10
		}
	
		[CompilerGenerated]
		private sealed class __YieldSendHttpRequest_d__29 : IEnumerator<object> // TypeDefIndex: 59469
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Misc.ObjectRef resultRef; // 0x20
			public System.Type respType; // 0x28
			public FSendFunc sendFunc; // 0x30
			private Result _result_5__2; // 0x88
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __YieldSendHttpRequest_d__29(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001835A3EF0-0x00000001835A40C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018A899F88-0x000000018A899FD4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 59470
		{
			// Fields
			public Result result; // 0x10
	
			// Constructors
			public __c__DisplayClass30_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Result __WaitForSendHttpRequest_b__0(); // 0x000000018A8999E4-0x000000018A899A04
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0<TResp> // TypeDefIndex: 59471
			where TResp : class
		{
			// Fields
			public Result<TResp> result;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal Result<TResp> __WaitForSendHttpRequest_b__0();
		}
	
		// Methods
		[IDTag(1)]
		[IteratorStateMachine(typeof(_YieldSendGet_d__16))]
		public static IEnumerator YieldSendGet(string url, FGetOptions options, Misc.ObjectRef resultRef); // 0x0000000183C0A480-0x0000000183C0A530
		[IteratorStateMachine(typeof(_YieldSendGet_d__17<TResp>))]
		public static IEnumerator YieldSendGet<TResp>(string url, FGetOptions options, Misc.ObjectRef resultRef)
			where TResp : class;
		[IDTag(0)]
		[IteratorStateMachine(typeof(_YieldSendGet_d__18))]
		public static IEnumerator YieldSendGet(string url, FGetOptions options, System.Type respType, Misc.ObjectRef resultRef); // 0x0000000183C07F10-0x0000000183C07FF0
		[IDTag(1)]
		[IteratorStateMachine(typeof(_YieldSendPost_d__19))]
		public static IEnumerator YieldSendPost(string url, FPostOptions options, Misc.ObjectRef resultRef); // 0x000000018A8951D4-0x000000018A8952BC
		[IteratorStateMachine(typeof(_YieldSendPost_d__20<TResp>))]
		public static IEnumerator YieldSendPost<TResp>(string url, FPostOptions options, Misc.ObjectRef resultRef)
			where TResp : class;
		[IDTag(0)]
		[IteratorStateMachine(typeof(_YieldSendPost_d__21))]
		public static IEnumerator YieldSendPost(string url, FPostOptions options, System.Type respType, Misc.ObjectRef resultRef); // 0x00000001849E2670-0x00000001849E2740
		public static WaitForAsyncTask<Result> WaitForSendPost(string url, FPostOptions options); // 0x000000018A8950D8-0x000000018A8951D4
		[IDTag(1)]
		public static WaitForAsyncTask<Result> WaitForSendGet(string url); // 0x000000018A894F3C-0x000000018A894FDC
		[IDTag(0)]
		public static WaitForAsyncTask<Result> WaitForSendGet(string url, FGetOptions options); // 0x000000018A894FDC-0x000000018A8950D8
		public static WaitForAsyncTask<Result<TResp>> WaitForSendPost<TResp>(string url, FPostOptions options)
			where TResp : class;
		public static WaitForAsyncTask<Result<TResp>> WaitForSendGet<TResp>(string url, FGetOptions options)
			where TResp : class;
		public static int GetGeneralErrorCode(Result result, out bool hasError); // 0x0000000183C08390-0x0000000183C08400
		[IDTag(0)]
		[IteratorStateMachine(typeof(__YieldSendHttpRequest_d__28))]
		private static IEnumerator _YieldSendHttpRequest(Result result, FSendFunc sendFunc); // 0x00000001835A40C0-0x00000001835A41A0
		[IDTag(1)]
		[IteratorStateMachine(typeof(__YieldSendHttpRequest_d__29))]
		private static IEnumerator _YieldSendHttpRequest(Misc.ObjectRef resultRef, FSendFunc sendFunc, System.Type respType); // 0x00000001846BAD90-0x00000001846BAE80
		private static WaitForAsyncTask<Result> _WaitForSendHttpRequest(FSendFunc sendFunc); // 0x000000018A895428-0x000000018A8955F0
		private static WaitForAsyncTask<Result<TResp>> _WaitForSendHttpRequest<TResp>(FSendFunc sendFunc)
			where TResp : class;
		private static void _StartWebRequestTask(Result result, FSendFunc sendFunc); // 0x00000001835A3740-0x00000001835A38E0
		private static void _WaitForServiceDone(Result result); // 0x0000000184B88010-0x0000000184B88060
		private static UnityWebRequest _CreateWebRequestGET(string url, FGetOptions options); // 0x0000000183E37670-0x0000000183E37C60
		private static UnityWebRequest _CreateWebRequestPOST(string url, FPostOptions options); // 0x0000000183E34BA0-0x0000000183E352A0
		private static void _SetHttpResult(Result result, UnityWebRequest request); // 0x0000000183E37480-0x0000000183E37590
		private static void _DeserializeTypedResult(TypedResult result); // 0x00000001835A4580-0x00000001835A4630
		private static void _DebugOnlyProfileResult(Result result, FSendFunc sendFunc); // 0x000000018A8952BC-0x000000018A895354
		private static void _MarkResultAsException(Result result, Exception ex); // 0x000000018A895354-0x000000018A895428
	}

	public class CircularBuffer<T> : IReadOnlyList<T> // TypeDefIndex: 59474
	{
		// Fields
		private readonly T[] m_buffer;
		private int m_end;
		private int m_count;
		private int m_start;
	
		// Properties
		public int Capacity { get; }
		public bool IsFull { get; }
		public bool IsEmpty { get; }
		public int Count { get; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__18 : IEnumerator<T> // TypeDefIndex: 59473
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
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CircularBuffer(int capacity);
		public CircularBuffer(int capacity, T[] items);
	
		// Methods
		public void Clear();
		[IteratorStateMachine(typeof(_GetEnumerator_d__18))]
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public T Front();
		public bool TryFront(out ref T result);
		public T Back();
		public bool TryBack(out ref T result);
		public void PushBack(T item);
		public void PushFront(T item);
		public void PopBack();
		public void PopFront();
		public bool TryPopFront(out ref T result);
		public bool TryPopBack(out ref T result);
		public T[] ToArray();
		private void _ThrowIfEmpty(string message = "Cannot access an empty buffer." /* Metadata: 0x0234CA6E */);
		private void _Increment(ref int index);
		private void _Decrement(ref int index);
		private int _InternalIndex(int index);
		private ArraySegment<T> _ArrayOne();
		private ArraySegment<T> _ArrayTwo();
	}

	public abstract class HGNetBaseSession // TypeDefIndex: 59483
	{
		// Fields
		private INetIO m_tcpIO; // 0x10
		private ENetWeakNetPreset m_weakNetPreset; // 0x18
		private bool m_useCustomWeakNetConfig; // 0x1C
		private int m_readWeakNetMinDelayMs; // 0x20
		private int m_readWeakNetMaxDelayMs; // 0x24
		private int m_readWeakNetMaxTriggerCountPerSecond; // 0x28
		private int m_writeWeakNetMinDelayMs; // 0x2C
		private int m_writeWeakNetMaxDelayMs; // 0x30
		private int m_writeWeakNetMaxTriggerCountPerSecond; // 0x34
		public static int s_recvBuffLen; // 0x00
		public static int s_tcpSendTimeout; // 0x04
		public static int s_sessionThreadSleepTimeMS; // 0x08
		public static int s_sessionThreadPauseSleepTimeMS; // 0x0C
		public int m_maxReconnectTimeout; // 0x38
		public int m_maxReconnectTimes; // 0x3C
		public int sendNumLimit; // 0x40
		protected readonly ConcurrentQueue<NetResponse> m_recvQueue; // 0x48
		protected readonly ConcurrentQueue<NetRequest> m_sendQueue; // 0x50
		private const int MAX_RECYCLE_QUEUE_COUNT = 1000; // Metadata: 0x0234CA8D
		protected CircularBuffer<NetRequest> m_circularBuffer; // 0x58
		private long m_csSeqId; // 0x60
		protected long m_scSeqId; // 0x68
		protected System.Threading.Tasks.Task m_threadTask; // 0x70
		protected int m_threadTaskSignalID; // 0x78
		protected ELogChannel m_logChannel; // 0x7C
		protected bool m_isSyncFullDataEnd; // 0x7D
		protected IMessage m_lastLoginMsg; // 0x80
		private string m_lastConnectServerIp; // 0x88
		private int m_lastConnectServerPort; // 0x90
		protected int m_tryReconnectTimes; // 0x94
		protected bool m_isAutoReconnect; // 0x98
		protected long m_startReconnectTimestampMS; // 0xA0
		protected int m_closeNetMsgID; // 0xA8
		public static int INVALID_SESSION_ID; // 0x10
		protected static int s_sessionIDGenerator; // 0x14
		[CompilerGenerated]
		private int _sessionID_k__BackingField; // 0xAC
		protected HGNetSessionConnectYield m_lastAsyncConnectHandle; // 0xB0
		protected EHGNetSessionState m_state; // 0xB8
		private EHGNetSessionReconnectState m_reconnectState; // 0xB9
		protected double m_startReconnectTimeMS; // 0xC0
		protected int m_closeErrorCode; // 0xC8
		public static bool s_applicationIsPaused; // 0x18
		private long m_clientLastReceiveMsgMilliTs; // 0xD0
		private long m_clientLastSendMsgMilliTs; // 0xD8
	
		// Properties
		public int sessionID { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D88CA0-0x0000000184D88CB0 0x0000000184D88D00-0x0000000184D88D10
		protected EHGNetSessionReconnectState reconnectState { get; set; } // 0x000000018314AA90-0x000000018314ACA0 0x0000000183813C30-0x0000000183813CF0
		public bool isRunning { get; } // 0x00000001836AB820-0x00000001836AB8C0 
		public bool isConnecting { get; } // 0x000000018A8941D0-0x000000018A894224 
		public bool isRunningAndConnected { get; } // 0x00000001836AC050-0x00000001836ACBB0 
		public bool isReconnecting { get; } // 0x00000001836AB0B0-0x00000001836AB1F0 
		public int closeErrorCode { get; } // 0x000000018A894130-0x000000018A894180 
		public bool isAutoReconnect { get; } // 0x000000018A894180-0x000000018A8941D0 
		public int maxRecycleQueueCount { get; } // 0x0000000183142230-0x0000000183142260 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0 // TypeDefIndex: 59475
		{
			// Fields
			public HGNetBaseSession __4__this; // 0x10
			public INetIO tcpIO; // 0x18
	
			// Constructors
			public __c__DisplayClass64_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _ConnectAsync_b__0(Task<System.Threading.Tasks.Task> task); // 0x000000018480FC50-0x000000018480FC80
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0 // TypeDefIndex: 59476
		{
			// Fields
			public HGNetBaseSession __4__this; // 0x10
			public INetIO tcp; // 0x18
			public int nextid; // 0x20
	
			// Constructors
			public __c__DisplayClass77_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal System.Threading.Tasks.Task _StartTCPMsgLoopThreadTask_b__0(); // 0x00000001848AC9A0-0x00000001848AC9D0
		}
	
		[CompilerGenerated]
		private struct __SessionThread_d__79 : IAsyncStateMachine // TypeDefIndex: 59477
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HGNetBaseSession __4__this; // 0x20
			public INetIO tcp; // 0x28
			public int threadID; // 0x30
			private TaskAwaiter __u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x000000018314B1D0-0x000000018314C240
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018459ADF0-0x000000018459AE50
		}
	
		[CompilerGenerated]
		private struct __DoReconnectAsync_d__89 : IAsyncStateMachine // TypeDefIndex: 59478
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HGNetBaseSession __4__this; // 0x20
			public INetIO tcpIO; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000183813060-0x0000000183813540
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018459AE50-0x000000018459AEB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_0 // TypeDefIndex: 59479
		{
			// Fields
			public INetIO tcpIO; // 0x10
			public string ip; // 0x18
			public int port; // 0x20
			public int sendTimeout; // 0x24
			public int receiveBufferLen; // 0x28
	
			// Constructors
			public __c__DisplayClass90_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _TryConnectWithTimeout_b__0(); // 0x00000001840EC030-0x00000001840EC0B0
		}
	
		[CompilerGenerated]
		private struct _TryConnectWithTimeout_d__90 : IAsyncStateMachine // TypeDefIndex: 59480
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
			private void MoveNext(); // 0x00000001838EBD80-0x00000001838EC0B0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001848BB330-0x00000001848BB3A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass91_0 // TypeDefIndex: 59481
		{
			// Fields
			public INetIO tcpIO; // 0x10
	
			// Constructors
			public __c__DisplayClass91_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _TryCloseTcpIOWithTimeout_b__0(); // 0x0000000183994490-0x00000001839944E0
		}
	
		[CompilerGenerated]
		private struct _TryCloseTcpIOWithTimeout_d__91 : IAsyncStateMachine // TypeDefIndex: 59482
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
			private void MoveNext(); // 0x00000001838EC0B0-0x00000001838EC3C0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001848BB3A0-0x00000001848BB410
		}
	
		// Constructors
		protected HGNetBaseSession(); // 0x0000000183A4B180-0x0000000183A4B2F0
		static HGNetBaseSession(); // 0x0000000184D11BD0-0x0000000184D11C90
	
		// Methods
		public virtual void Start(); // 0x0000000183812B00-0x0000000183812CB0
		public virtual bool Connect(string serverIp, int serverPort, bool forceReconnect); // 0x000000018A893C30-0x000000018A893F90
		public virtual bool ConnectAsync(string serverIp, int serverPort, bool forceReconnect, out HGNetSessionConnectYield yieldHandle); // 0x00000001838EB980-0x00000001838EBD80
		public void OnConnectAsyncEnd(System.Threading.Tasks.Task completedTask, INetIO tcpIO); // 0x000000018480FC80-0x000000018480FDD0
		protected abstract void OnConnectedSucceed(INetIO tcpIO);
		private void _DNSCheck(string serverIp); // 0x00000001840EE260-0x00000001840EE370
		public virtual void Close(ENetCloseReason netCloseReason); // 0x00000001839941E0-0x0000000183994220
		[IDTag(1)]
		protected void InternalClose(INetIO tcpIO, ENetCloseReason netCloseReason); // 0x000000018A893FE0-0x000000018A89405C
		[IDTag(0)]
		protected void InternalClose(INetIO tcpIO, int netCloseReason); // 0x0000000183994220-0x00000001839943D0
		protected void EnqueueSendMsg(NetRequest msg); // 0x00000001836AEF10-0x00000001836AEF80
		public int GetSendQueueMsgCount(); // 0x00000001836AD6A0-0x00000001836AD750
		protected long IncrementCSSeqID(); // 0x00000001836AEED0-0x00000001836AEF10
		protected void SetCSSeqID(long id); // 0x0000000183219140-0x0000000183219180
		protected long GetCSSeqID(); // 0x000000018A893F90-0x000000018A893FE0
		protected INetIO GetIO(); // 0x0000000183219080-0x00000001832190B0
		protected void StartTCPMsgLoopThreadTask(); // 0x00000001840EB970-0x00000001840EBAA0
		protected void CloseTCPMsgThreadTask(); // 0x0000000183994F30-0x0000000183994F90
		private async System.Threading.Tasks.Task _SessionThread(INetIO tcp, int threadID); // 0x00000001848AC9D0-0x00000001848ACB00
		private bool _SendAndCheckMessage(INetIO tcp, int threadID); // 0x00000001831480E0-0x0000000183148680
		private bool _ReadAndCheckMessageInSessionThread(INetIO tcp, int threadID); // 0x0000000183148890-0x0000000183148FE0
		protected abstract bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp);
		protected abstract void CheckAndDealRespMessages(INetIO netIO, ref NetResponse m);
		protected abstract void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m);
		protected void SessionCheckSignalAndSleep(int threadID); // 0x000000018314A640-0x000000018314A900
		protected void OpenAutoReconnect(); // 0x00000001840EB530-0x00000001840EB560
		protected void RemoveAutoReconnect(); // 0x0000000183994F00-0x0000000183994F30
		private System.Threading.Tasks.Task _ReconnectCheckerTick(INetIO tcpIO); // 0x000000018314CF30-0x000000018314D180
		private async System.Threading.Tasks.Task _DoReconnectAsync(INetIO tcpIO); // 0x00000001847CEC70-0x00000001847CED80
		protected async Task<bool> TryConnectWithTimeout(INetIO tcpIO, string ip, int port, int sendTimeout, int receiveBufferLen, int timeoutMilliseconds); // 0x0000000183813800-0x0000000183813970
		protected async Task<bool> TryCloseTcpIOWithTimeout(INetIO tcpIO, int timeoutMilliseconds); // 0x0000000183813970-0x0000000183813AD0
		public void SetWeakNetPreset(ENetWeakNetPreset preset); // 0x00000001838EA1D0-0x00000001838EA220
		public void SetWeakNetCustom(int readMinDelayMs, int readMaxDelayMs, int readMaxTriggerCountPerSecond, int writeMinDelayMs, int writeMaxDelayMs, int writeMaxTriggerCountPerSecond); // 0x000000018A89405C-0x000000018A894130
		private void _ApplyWeakNetConfigToTcpIO(INetIO tcpIO); // 0x00000001838EA220-0x00000001838EA280
		protected abstract void OnReconnectTimesOver(INetIO tcpIO);
		protected abstract bool NeedKeepConnect();
		protected abstract void DoReconnectLogin(INetIO netIO);
		protected abstract void InitClientRSAKey();
		protected abstract void ClearRSAKey();
		public abstract void ClearRecvQueue();
		public abstract void ClearSendQueue();
		protected void NetStatusChecker_Receive(INetIO netIO, long scSeqId, int receiveCount); // 0x0000000183148FE0-0x00000001831491C0
		protected void NetStatusChecker_Sender(INetIO netIO, long csSeqId, int sendCount); // 0x0000000183148680-0x0000000183148890
		protected abstract void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs);
		protected abstract void ClearPingWDG();
		protected abstract bool IsPingOut();
		protected abstract void PingSenderTick(INetIO netIO, long upSeqId);
	}

	public class HGNetSession : HGNetBaseSession // TypeDefIndex: 59484
	{
		// Fields
		private string m_uid; // 0xE0
		private string m_token; // 0xE8
		private int m_channel; // 0xF0
		public static int LOGIN_TIMEOUT; // 0x00
		public static int MAX_CLIENT_RESEND_NUM; // 0x04
		public static float PER_FRAME_RECEIVED_MESSAGES_TIME_30FPS; // 0x08
		public static float PER_FRAME_RECEIVED_MESSAGES_TIME; // 0x0C
		public static float MESSAGE_MAX_DELAY_TIME; // 0x10
		protected int m_messageDelayCount; // 0xF4
		protected long m_logCDTimestamp; // 0xF8
		private static bool s_HGNetSessionBurst; // 0x14
		private readonly ConcurrentQueue<NetRequest> m_frameSendQueue; // 0x100
		private Queue<NetRequest> m_mergeQueueCache; // 0x108
		private object m_frameSendQueueLocker; // 0x110
		private byte[] m_frameSendPacketBuffer; // 0x118
		private byte[] m_frameSendPacketHeadBuffer; // 0x120
		private byte[] m_frameSendPacketTempBuffer; // 0x128
		private byte[] m_frameSendCryptoBuffer; // 0x130
		private byte[] m_frameReceivePacketBuffer; // 0x138
		public static long s_maxframeSendPacketBuffer; // 0x18
		public static long s_maxPackedMessageNum; // 0x20
		protected readonly Queue<NetResponse> m_callbackQueue; // 0x140
		private HGNetSessionLoginYield m_currLoginHandle; // 0x148
		private const int SEND_PING_DELTA_TICK_TIME_MS = 2000; // Metadata: 0x0234CA91
		private const int IN_PING_PROGRESS_MAX_TIME = 999; // Metadata: 0x0234CA93
		private static int s_pingWdgOutTimes; // 0x28
		private static int s_pingSyncFullEndBeforeTimes; // 0x2C
		private long m_needSendPingTimer; // 0x150
		private int m_pingWDG; // 0x158
		private long m_clientTsDelayms; // 0x160
		private int m_pingValue; // 0x168
		private bool m_isPingInProgress; // 0x16C
		private long m_isPingInProgressStartTime; // 0x170
		private static readonly string CLIENT_NET_PEM_PUBLIC_KEY_HEAD_FORMAT; // 0x30
		private static readonly string CLIENT_NET_RSA_PUBLIC_KEY; // 0x38
		private static readonly string CLIENT_NET_RSA_PRIVATE_KEY; // 0x40
		private static byte[] s_clientPublicKeyBytes; // 0x48
		private RSA m_rsaClientPrivateProvider; // 0x178
		private static readonly byte[] EMPTY_BYTES; // 0x50
		private static int s_CacheLogLength; // 0x58
		private StringBuilder m_sbCache; // 0x180
	
		// Constructors
		public HGNetSession(); // 0x0000000183A4AEF0-0x0000000183A4B180
		static HGNetSession(); // 0x0000000184A24C30-0x0000000184A24E40
	
		// Methods
		public void SetAutoReconnectToken(string uid, string token, int channel); // 0x0000000183A4BBE0-0x0000000183A4BC60
		protected override void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs); // 0x0000000183CCC6E0-0x0000000183CCC7A0
		protected override void DoReconnectLogin(INetIO netIO); // 0x000000018A89D01C-0x000000018A89D804
		public override void Start(); // 0x0000000184A42F40-0x0000000184A430B0
		public void OnApplicationPause(bool pause); // 0x000000018A89D938-0x000000018A89DA28
		public ulong SendMessage(IMessage msg); // 0x00000001836AF240-0x00000001836AF5E0
		protected void PackMessageToSendQueue(); // 0x000000018A89DA94-0x000000018A89E144
		private void _FlushMergeQueueToSendQueue(); // 0x000000018A89E23C-0x000000018A89E314
		public void UpdateInGameThread(); // 0x000000018A89E1D0-0x000000018A89E23C
		public void TailLateUpdateInGameThread(); // 0x000000018A89E198-0x000000018A89E1D0
		private float _GetMessageTimeLimit(); // 0x000000018A89E314-0x000000018A89E394
		private void _ProcessReceivedMessagesInGameThread(bool flushAll); // 0x000000018A89ED38-0x000000018A89F0C8
		public HGNetSessionLoginYield LoginAsync(string uid, string token, int channel); // 0x000000018379D830-0x00000001837A0150
		private static void _CSLoginHelper_UpdateAppInfo(MSG_A1 msg); // 0x0000000183C07910-0x0000000183C079C0
		private static string _GetOnlineResVersion(); // 0x0000000183C07A90-0x0000000183C07B40
		private static ENV_TYPE _GetSDKEnv(); // 0x0000000183C07850-0x0000000183C07910
		private static CLIENT_PLATFORM_TYPE _GetPlatformID(); // 0x0000000183C07FF0-0x0000000183C08020
		private static int _GetPayPlatform(); // 0x0000000183C08020-0x0000000183C08080
		private void _SessionLoginThreadTask(object handle); // 0x0000000183218D00-0x0000000183219080
		public void StartMsgLoop(); // 0x00000001840EB480-0x00000001840EB4D0
		protected override void OnConnectedSucceed(INetIO tcpIO); // 0x0000000184D802C0-0x0000000184D802F0
		protected override void OnReconnectTimesOver(INetIO tcpIO); // 0x000000018A89DA28-0x000000018A89DA94
		protected override bool NeedKeepConnect(); // 0x0000000183CCC7A0-0x0000000183CCC910
		protected override void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest req); // 0x0000000183142110-0x0000000183142230
		private void _WriteMessageInSessionThread(INetIO netIO, ref NetRequest request, bool useSRSA = false /* Metadata: 0x0234CA8F */); // 0x0000000183142650-0x0000000183142960
		protected override bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp); // 0x0000000183148010-0x00000001831480E0
		private bool _ReadMessageInSessionThread(INetIO netIO, out NetResponse resp, bool useSRSA = false /* Metadata: 0x0234CA90 */); // 0x0000000183149BD0-0x000000018314A480
		public override void ClearRecvQueue(); // 0x00000001836AB3C0-0x00000001836AB520
		public override void ClearSendQueue(); // 0x0000000184D32C80-0x0000000184D32CE0
		public static void SetBurstMode(bool val); // 0x000000018A89E144-0x000000018A89E198
		public NetDevProfilerSnapshot GetNetDevProfilerSnapshot(); // 0x000000018A89D804-0x000000018A89D8E8
		~HGNetSession(); // 0x0000000183993B40-0x0000000183993B80
		public int GetPing(); // 0x00000001836ABAA0-0x00000001836ABCC0
		public bool IsPingInProgress(); // 0x000000018A89D8E8-0x000000018A89D938
		public long GetPingPassedTime(); // 0x00000001839F3270-0x00000001839F32F0
		protected override void ClearPingWDG(); // 0x000000018425AD80-0x000000018425ADF0
		private void _ApproximateLoginServerTime(long serverTimeMS, int serverZone); // 0x0000000183219180-0x0000000183219200
		private bool _HandleSpecialMessagePing(NetResponse m); // 0x0000000183F7A520-0x0000000183F7A6B0
		protected override bool IsPingOut(); // 0x0000000183B27E90-0x0000000183B27FA0
		protected override void PingSenderTick(INetIO netIO, long upSeqId); // 0x0000000183147B20-0x0000000183147F70
		public static byte[] GetClientPublicKey(); // 0x0000000184D1E2F0-0x0000000184D1E390
		protected override void InitClientRSAKey(); // 0x0000000183FE3D40-0x0000000183FE3E50
		private byte[] _RSADecrypt(byte[] data); // 0x00000001832198D0-0x00000001832199D0
		protected override void ClearRSAKey(); // 0x000000018A89CF54-0x000000018A89D01C
		protected override void CheckAndDealRespMessages(INetIO netIO, ref NetResponse msg); // 0x00000001836AE080-0x00000001836AE3F0
		private bool _HandleSpecialMessageReconnectIncr(INetIO netIO, NetResponse m); // 0x000000018A89E624-0x000000018A89EB80
		private bool _HandleSpecialMessageReconnectFull(INetIO netIO, NetResponse m); // 0x000000018A89E474-0x000000018A89E624
		private bool _HandleSpecialMessageErrorCode(INetIO netIO, NetResponse m); // 0x000000018A89E394-0x000000018A89E474
		private bool _HandleSpecialMessageReconnectLogin(INetIO netIO, NetResponse m); // 0x000000018A89EB80-0x000000018A89ED38
		private bool _HandleLoginEncryp(INetIO netIO, MSG_B1 msg); // 0x00000001832195B0-0x00000001832196A0
		public void __iFixBaseProxy_Start(); // 0x000000018A89CA18-0x000000018A89CA20
	}

	public enum EHGNetSessionState : byte // TypeDefIndex: 59485
	{
		Closed = 0,
		Opened = 1,
		Connecting = 2,
		SessionRunning = 3
	}

	public enum EHGNetSessionReconnectState : byte // TypeDefIndex: 59486
	{
		None = 0,
		ReconnectingTcp = 1,
		SendLogin = 2,
		ResendPack = 3
	}

	public enum ENetCloseReason // TypeDefIndex: 59487
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

	public static class HGNetSessionUtils // TypeDefIndex: 59488
	{
		// Methods
		public static bool CheckErrorNeedsDisconnect(CODE errorCode); // 0x000000018A89CEEC-0x000000018A89CF54
	}

	public static class HGNetSessionConstant // TypeDefIndex: 59489
	{
		// Fields
		public const int CODE_SUC = 0; // Metadata: 0x0234CABF
		public const int CODE_CONN_FAILED = 1; // Metadata: 0x0234CAC0
		public const int CODE_CONN_WAIT = -1; // Metadata: 0x0234CAC1
	}

	public enum ENetConnectErrorCode // TypeDefIndex: 59490
	{
		Invalid = -1,
		None = 0,
		ForServerErrorMax = 100000,
		ConnectError = 800001,
		TimeOut = 800002
	}

	public class HGNetSessionLoginYield : CustomYieldInstruction // TypeDefIndex: 59492
	{
		// Fields
		internal LoginErrorInfo m_loginErrorInfo; // 0x10
		internal bool m_bIsFinish; // 0x18
		internal MSG_A1 m_request; // 0x20
		internal MSG_B1 m_resp; // 0x28
		private object m_locker; // 0x30
	
		// Properties
		public bool isSucceed { get; } // 0x0000000183A4BB20-0x0000000183A4BB70 
		public override bool keepWaiting { get; } // 0x0000000184CC5CD0-0x0000000184CC5D00 
	
		// Nested types
		internal class LoginErrorInfo // TypeDefIndex: 59491
		{
			// Fields
			[CompilerGenerated]
			private int _code_k__BackingField; // 0x10
			[CompilerGenerated]
			private string _details_k__BackingField; // 0x18
	
			// Properties
			internal int code { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
			internal string details { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
			// Constructors
			public LoginErrorInfo(); // 0x0000000183A4B450-0x0000000183A4B4A0
	
			// Methods
			public void SetErrorInvaild(); // 0x0000000183A4B4A0-0x0000000183A4B510
			public void SetErrorConnectError(); // 0x000000018A8A5BBC-0x000000018A8A5C48
			public void SetErrorConnectTimeOut(); // 0x000000018A8A5C48-0x000000018A8A5CD4
			public void Clear(); // 0x0000000183A4AE80-0x0000000183A4AEF0
			public void Set(int code, string details); // 0x000000018A8A5CD4-0x000000018A8A5D4C
		}
	
		// Constructors
		public HGNetSessionLoginYield(); // 0x0000000183A4B3A0-0x0000000183A4B450
		public HGNetSessionLoginYield(MSG_A1 req); // 0x0000000183A4ADC0-0x0000000183A4AE80
	
		// Methods
		public MSG_A1 GetRequest(); // 0x00000001832190B0-0x0000000183219110
		public MSG_B1 GetResponse(); // 0x0000000183A4B870-0x0000000183A4B8A0
		public int GetErrorCode(); // 0x000000018A89CB24-0x000000018A89CB7C
		public string GetErrorDetails(); // 0x000000018A89CB7C-0x000000018A89CBD4
		public void SetSucceed(MSG_B1 sc); // 0x0000000183A4ABD0-0x0000000183A4ADC0
		public void SetNtfError(int ntfErrorCode, string ntfErrorDetails); // 0x000000018A89CCCC-0x000000018A89CDF4
		public void SetConnectErrorError(); // 0x000000018A89CBD4-0x000000018A89CCCC
		public void SetTimeOutError(); // 0x000000018A89CDF4-0x000000018A89CEEC
	}

	public class HGNetSessionConnectYield : CustomYieldInstruction // TypeDefIndex: 59493
	{
		// Fields
		internal System.Threading.Tasks.Task m_connectTask; // 0x10
		internal ENetConnectErrorCode connectErrorCode; // 0x18
	
		// Properties
		public bool isSucceed { get; } // 0x0000000183A4B840-0x0000000183A4B870 
		public override bool keepWaiting { get; } // 0x0000000184CE44F0-0x0000000184CE4540 
	
		// Constructors
		public HGNetSessionConnectYield(); // 0x0000000184D87910-0x0000000184D87920
		public HGNetSessionConnectYield(System.Threading.Tasks.Task connectTask); // 0x00000001838EA930-0x00000001838EA960
	
		// Methods
		public int GetCode(); // 0x000000018A89CAD8-0x000000018A89CB24
		public void SetFinish(ENetConnectErrorCode code); // 0x000000018480FDD0-0x000000018480FE10
	}
}

namespace Beyond.Network.HGNetLogger
{
	public abstract class HGNetLogBaseSession // TypeDefIndex: 59494
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
		private const int MAX_RECYCLE_QUEUE_COUNT = 1000; // Metadata: 0x0234CAD0
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
		public bool isRunning { get; } // 0x000000018A89C518-0x000000018A89C56C 
		public bool isConnecting { get; } // 0x000000018A89C470-0x000000018A89C4C4 
		public bool isRunningAndConnected { get; } // 0x000000018A89C4C4-0x000000018A89C518 
		public int closeErrorCode { get; } // 0x000000018A89C3D4-0x000000018A89C424 
		public bool isAutoReconnect { get; } // 0x000000018A89C424-0x000000018A89C470 
	
		// Constructors
		protected HGNetLogBaseSession(); // 0x000000018A89C27C-0x000000018A89C3D4
		static HGNetLogBaseSession(); // 0x000000018A89C1C8-0x000000018A89C27C
	
		// Methods
		public virtual void Start(); // 0x000000018A89B840-0x000000018A89B988
		public virtual bool Connect(string serverIp, int serverPort, bool forceReconnect); // 0x000000018A89ACF0-0x000000018A89AFDC
		public virtual bool ConnectAsync(string serverIp, int serverPort, bool forceReconnect, out HGNetSessionConnectYield yieldHandle); // 0x000000018A89A954-0x000000018A89ACF0
		public void OnConnectAsyncEnd(System.Threading.Tasks.Task continuationAction); // 0x000000018A89B384-0x000000018A89B4BC
		protected abstract void OnConnectedSucceed(INetIO tcpIO);
		private void _DNSCheck(string serverIp); // 0x000000018A89B988-0x000000018A89BB44
		[IDTag(1)]
		public virtual void Close(ENetCloseReason netCloseReason); // 0x000000018A89A6F0-0x000000018A89A754
		[IDTag(0)]
		public virtual void Close(int netCloseReason); // 0x000000018A89A754-0x000000018A89A954
		protected void EnqueueSendMsg(NetRequest msg); // 0x000000018A89AFDC-0x000000018A89B090
		public int GetSendQueueMsgCount(); // 0x000000018A89B130-0x000000018A89B1AC
		protected long IncrementCSSeqID(); // 0x000000018A89B1AC-0x000000018A89B204
		protected void SetCSSeqID(long id); // 0x000000018A89B620-0x000000018A89B67C
		protected long GetCSSeqID(); // 0x000000018A89B090-0x000000018A89B0E0
		protected INetIO GetIO(); // 0x000000018A89B0E0-0x000000018A89B130
		protected void StartTCPMsgLoopThreadTask(); // 0x000000018A89B67C-0x000000018A89B840
		protected void CloseTCPMsgThreadTask(); // 0x000000018A89A610-0x000000018A89A6F0
		private void _SessionThread(); // 0x000000018A89BE08-0x000000018A89C1C8
		protected abstract bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp);
		protected abstract void CheckAndDealRespMessages(INetIO netIO, ref NetResponse m);
		protected abstract void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m);
		protected void SessionCheckSignalAndSleep(); // 0x000000018A89B558-0x000000018A89B620
		protected void OpenAutoReconnect(); // 0x000000018A89B4BC-0x000000018A89B50C
		protected void RemoveAutoReconnect(); // 0x000000018A89B50C-0x000000018A89B558
		private void _ReconnectCheckerTick(); // 0x000000018A89BB44-0x000000018A89BE08
		protected abstract void OnReconnectTimesOver();
		protected abstract bool NeedKeepConnect();
		protected abstract void DoReconnectLogin(INetIO netIO);
		protected abstract void InitClientRSAKey();
		protected abstract void ClearRSAKey();
		protected void NetStatusChecker_Receive(INetIO netIO, long scSeqId, int receiveCount); // 0x000000018A89B204-0x000000018A89B2B8
		protected void NetStatusChecker_Sender(INetIO netIO, long csSeqId, int sendCount); // 0x000000018A89B2B8-0x000000018A89B384
		protected abstract void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs);
		protected abstract void ClearPingWDG();
		protected abstract bool IsPingOut();
		protected abstract void PingSenderTick(INetIO netIO, long upSeqId);
	}

	public class HGNetLogger : Beyond.Log.ILogger // TypeDefIndex: 59495
	{
		// Fields
		private BitArray256 m_enabledLogChannel; // 0x10
		private ConcurrentQueue<FLogMessage> m_logMessagesQueue; // 0x30
		public static int s_maxLogQueueSize; // 0x00
		public static int s_maxRepeatedMsgMs; // 0x04
		public static int s_maxRepeatedMsgCount; // 0x08
	
		// Constructors
		public HGNetLogger(); // 0x0000000183E3E0C0-0x0000000183E3E150
		static HGNetLogger(); // 0x0000000184D53380-0x0000000184D533F0
	
		// Methods
		public void Log(ref FLogMessage msg); // 0x0000000183136140-0x0000000183137D00
		[IDTag(0)]
		public static LogLevel ConvertFromDLogger(ELogLevel level); // 0x0000000183F7B160-0x0000000183F7B260
		public static NativeLogLevel ConvertFromDLoggerV2(ELogLevel level); // 0x0000000183F7B050-0x0000000183F7B160
		public bool CheckLog(ref FLogMessage msg); // 0x0000000183F5AE50-0x0000000183F5AF20
		public void Clear(); // 0x00000001848FE070-0x00000001848FE0D0
		public void SetLogChannel(ulong channel1, ulong channel2, ulong channel3, ulong channel4); // 0x000000018A89CA20-0x000000018A89CAD8
		[IDTag(1)]
		public static int ConvertFromDLogger(ELogChannel channel); // 0x00000001840329F0-0x0000000184032A90
	}

	public class HGNetLoggerClient // TypeDefIndex: 59496
	{
		// Fields
		private static HGNetLoggerClient s_instance; // 0x00
		[CompilerGenerated]
		private static long _s_roleID_k__BackingField; // 0x08
		public HGNetLoggerSession m_logsession; // 0x10
		private HGNetLogger m_netLogger; // 0x18
		public static readonly int MAX_LOG_SEND_QUEUE_SIZE; // 0x10
		private const int MAX_LOCAL_LOG_QUEUE_SIZE = 200; // Metadata: 0x0234CAD3
		private readonly Queue<FLogMessage> m_localLogQueue; // 0x20
		private readonly object m_queueLock; // 0x28
		public static Beyond.Network.HGNetLogger.Version s_usedVersion; // 0x14
	
		// Properties
		public static HGNetLoggerClient instance { get; } // 0x0000000183A84130-0x0000000183A84270 
		public static long s_roleID { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018A89C634-0x000000018A89C684 0x000000018A89C684-0x000000018A89C6DC
	
		// Constructors
		protected HGNetLoggerClient(); // 0x0000000184CDEC20-0x0000000184CDECF0
		static HGNetLoggerClient(); // 0x0000000184D5DD70-0x0000000184D5DDC0
	
		// Methods
		public void Init(string uid, string token, string env, string roleId = "" /* Metadata: 0x0234CAD2 */); // 0x0000000183E3DA80-0x0000000183E3DF00
		public void AddLog(string message, string stacktrace, UnityEngine.LogType type); // 0x000000018313A4C0-0x000000018313AAA0
		private void _FlushLocalLogQueue(); // 0x0000000183139630-0x000000018313A3F0
		public static void OnApplicationPause(bool pauseStatus); // 0x000000018A89C56C-0x000000018A89C634
		public void ShutDown(); // 0x0000000183C11B10-0x0000000183C11B50
		private void _CloseAndClear(ENetCloseReason reason); // 0x0000000183993C20-0x00000001839940B0
		public void WriteNetLog(ref LogMessage log); // 0x00000001836AE800-0x00000001836AE900
		public static void SetRoleID(ulong roleID); // 0x0000000184CED270-0x0000000184CED310
		public void SetNetLogMaskFromServer(RepeatedField<ulong> masks); // 0x0000000184D802F0-0x0000000184D80320
		[CompilerGenerated]
		private void _Init_b__15_0(); // 0x00000001848FE050-0x00000001848FE070
	}

	public class HGNetLoggerCloudSettings // TypeDefIndex: 59497
	{
		// Fields
		public static readonly HGNetLoggerCloudSettings instance; // 0x00
		private LogControl m_cloudLogControl; // 0x10
		private Dictionary<int, int> m_cloudChannelLevelMaskTables; // 0x18
		private LogControl m_localLogControl; // 0x20
		private Dictionary<int, int> m_localChannelLevelMaskTables; // 0x28
		private static List<NativeLogLevel> s_allLevels; // 0x08
	
		// Constructors
		public HGNetLoggerCloudSettings(); // 0x00000001849C5F00-0x00000001849C6110
		static HGNetLoggerCloudSettings(); // 0x00000001849C5DA0-0x00000001849C5F00
	
		// Methods
		public static void SetCloudLogControl(AuthResponse control, HGNetBaseSession session); // 0x0000000183A82D30-0x0000000183A84130
		[IDTag(1)]
		public static bool IsNetLogLevelEnabled(ELogLevel elevel, ELogChannel channel); // 0x000000018313A3F0-0x000000018313A470
		[IDTag(0)]
		public static bool IsNetLogLevelEnabled(NativeLogLevel level, int channel); // 0x000000018333BE50-0x000000018333C050
		public static bool IsLocalLogLevelEnabled(ELogLevel elevel, ELogChannel channel); // 0x000000018A89C6DC-0x000000018A89C818
		public static NativeLogLevel ConvertFromDLogger(ELogLevel level); // 0x000000018313A470-0x000000018313A4C0
	}

	public class HGNetLoggerSession : HGNetBaseSession // TypeDefIndex: 59498
	{
		// Fields
		private byte[] m_keyBytes; // 0xE0
		private Dictionary<string, int> m_templeCRCDict; // 0xE8
		private Action m_onReconnectSuccess; // 0xF0
		private string m_uid; // 0xF8
		private string m_roleId; // 0x100
		private string m_token; // 0x108
		private string m_env; // 0x110
		private static Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> s_m_messageType2Id; // 0x00
		private static Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> s_m_messageId2Type; // 0x08
	
		// Properties
		public string uid { get; } // 0x0000000184D7D910-0x0000000184D7D940 
		public string roleId { get; } // 0x0000000184D7D940-0x0000000184D7D970 
		private static Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> s_messageType2Id { get; } // 0x0000000183142E60-0x0000000183143020 
		private static Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> s_messageId2Type { get; } // 0x00000001841CE8B0-0x00000001841CEB00 
	
		// Constructors
		public HGNetLoggerSession(); // 0x0000000183E3E320-0x0000000183E3E3D0
	
		// Methods
		public static bool TryGetMsgTypeByID(System.Type msgType, out Beyond.Network.HGNetLogger.MessageType type); // 0x0000000183142E00-0x0000000183142E60
		public override void Start(); // 0x00000001838125C0-0x0000000183812610
		public void SetReconnectSuccessCallback(Action onReconnectSuccess); // 0x0000000183E3E070-0x0000000183E3E0C0
		public void OnApplicationPause(bool pause); // 0x000000018A89C85C-0x000000018A89C95C
		protected override void OnConnectedSucceed(INetIO tcpIO); // 0x00000001840EB4D0-0x00000001840EB530
		protected override bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp); // 0x0000000183149260-0x0000000183149B30
		protected override void CheckAndDealRespMessages(INetIO netIO, ref NetResponse resp); // 0x00000001836AEF80-0x00000001836AF1E0
		protected override void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m); // 0x0000000183142D90-0x0000000183142E00
		private void _WriteMessageInSessionThread(INetIO netIO, NetRequest request); // 0x00000001831432B0-0x0000000183143590
		public ulong SendMessage(IMessage msg); // 0x00000001836AE900-0x00000001836AEED0
		public void SetAutoReconnectToken(string uid, string token, string env, string roleId); // 0x0000000183E3E280-0x0000000183E3E320
		protected override bool NeedKeepConnect(); // 0x00000001836AD550-0x00000001836AD6A0
		protected override void DoReconnectLogin(INetIO netIO); // 0x0000000183813B40-0x0000000183813C30
		private int _GetConnectTimeoutTime(); // 0x0000000183147870-0x0000000183147910
		protected override void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs); // 0x0000000183147910-0x0000000183147B20
		protected override void ClearPingWDG(); // 0x0000000184CD9730-0x0000000184CD9760
		public void SendLogin(INetIO netIO); // 0x0000000183813DF0-0x0000000183814220
		protected override bool IsPingOut(); // 0x000000018423B0F0-0x000000018423B120
		protected override void PingSenderTick(INetIO netIO, long upSeqId); // 0x0000000183DAE9A0-0x0000000183DAEA50
		protected override void InitClientRSAKey(); // 0x0000000184D5ED40-0x0000000184D5ED70
		protected override void ClearRSAKey(); // 0x000000018A89C818-0x000000018A89C85C
		public override void ClearRecvQueue(); // 0x0000000184D5EDA0-0x0000000184D5EDD0
		public override void ClearSendQueue(); // 0x0000000184D5ED70-0x0000000184D5EDA0
		protected override void OnReconnectTimesOver(INetIO tcpIO); // 0x000000018A89C95C-0x000000018A89CA18
		public void __iFixBaseProxy_Start(); // 0x000000018A89CA18-0x000000018A89CA20
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 59398
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 59399
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 59400
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 59401
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 59402
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 59397
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59499
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D375D0-0x0000000184D37640
	
		// Methods
		public Socket __Gen_Wrap_0(object P0); // 0x000000018A89F0C8-0x000000018A89F1B8
		public void __Gen_Wrap_1(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public bool __Gen_Wrap_2(object P0); // 0x00000001863632E4-0x00000001863633B4
		public void __Gen_Wrap_3(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public int __Gen_Wrap_4(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_5(object P0, object P1, int P2); // 0x00000001866F4838-0x00000001866F4930
		public IAsyncResult __Gen_Wrap_6(object P0, object P1, int P2, object P3, object P4); // 0x000000018A8A43F4-0x000000018A8A4538
		public System.Threading.Tasks.Task __Gen_Wrap_7(object P0, object P1, int P2); // 0x000000018A8A4CF8-0x000000018A8A4E1C
		public NetworkStream __Gen_Wrap_8(object P0); // 0x000000018A8A5528-0x000000018A8A5618
		public void __Gen_Wrap_9(object P0); // 0x00000001863633B4-0x0000000186363474
		public int __Gen_Wrap_10(object P0, SocketOptionLevel P1, SocketOptionName P2); // 0x00000001871AFE44-0x00000001871AFF34
		public void __Gen_Wrap_11(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public LingerOption __Gen_Wrap_12(object P0); // 0x000000018A8A08BC-0x000000018A8A09AC
		public Header __Gen_Wrap_13(ref NetResponse P0); // 0x000000018A8A0C78-0x000000018A8A0DE0
		public void __Gen_Wrap_14(ref NetResponse P0, object P1); // 0x000000018A8A0DE0-0x000000018A8A0F44
		public CSHead __Gen_Wrap_15(ref NetResponse P0); // 0x000000018A8A0F44-0x000000018A8A10AC
		public int __Gen_Wrap_16(ref NetResponse P0); // 0x000000018A8A10AC-0x000000018A8A1204
		public ulong __Gen_Wrap_17(ref NetResponse P0); // 0x000000018A8A1204-0x000000018A8A135C
		public long __Gen_Wrap_18(object P0); // 0x00000001867CDAC0-0x00000001867CDB90
		public ulong __Gen_Wrap_19(object P0, object P1); // 0x000000018A8A135C-0x000000018A8A1448
		public System.Type __Gen_Wrap_20(int P0); // 0x000000018A8A1448-0x000000018A8A1534
		public void __Gen_Wrap_21(object P0, int P1, object P2); // 0x00000001866F4C88-0x00000001866F4D80
		public NetBus.ResultHandler __Gen_Wrap_22(object P0, object P1); // 0x000000018A8A1534-0x000000018A8A1640
		public void __Gen_Wrap_23(object P0, in NetResponse P1); // 0x000000018A8A1640-0x000000018A8A176C
		public NetBus.ResultHandler __Gen_Wrap_24(object P0, SCMessageID P1, object P2); // 0x000000018A8A176C-0x000000018A8A1890
		public void __Gen_Wrap_25(object P0, SCMessageID P1, object P2); // 0x0000000189C81AB0-0x0000000189C81B94
		public void __Gen_Wrap_26(object P0, StringPathHash P1); // 0x000000018A8A1890-0x000000018A8A1990
		public float __Gen_Wrap_27(object P0); // 0x00000001866C0730-0x00000001866C0800
		public int __Gen_Wrap_28(object P0, object P1, float P2, float P3); // 0x000000018A8A1990-0x000000018A8A1AA8
		public int __Gen_Wrap_29(object P0, CSMessageID P1, float P2); // 0x000000018A8A1AA8-0x000000018A8A1B9C
		public void __Gen_Wrap_30(in NetResponse P0); // 0x000000018A8A1B9C-0x000000018A8A1C98
		public NetBus.ResultHandler __Gen_Wrap_31(object P0, object P1, float P2); // 0x000000018A8A1C98-0x000000018A8A1DAC
		public NetBus.ResultHandler __Gen_Wrap_32(object P0, object P1, bool P2, object P3, object P4); // 0x000000018A8A1DAC-0x000000018A8A1EF4
		public void __Gen_Wrap_33(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public bool __Gen_Wrap_34(object P0, object P1); // 0x000000018A8A1EF4-0x000000018A8A1FCC
		public void __Gen_Wrap_35(int P0, object P1); // 0x0000000186374CB0-0x0000000186374D8C
		public void __Gen_Wrap_36(); // 0x00000001863625A4-0x0000000186362640
		public bool __Gen_Wrap_37(Span<byte> P0, object P1, int P2, int P3, object P4, out NetResponse P5); // 0x000000018A8A1FCC-0x000000018A8A2180
		public int __Gen_Wrap_38(object P0, ulong P1, int P2, int P3, object P4, int P5); // 0x000000018A8A2180-0x000000018A8A22B4
		public void __Gen_Wrap_39(System.Type P0, MethodInfo P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public string __Gen_Wrap_40(); // 0x000000018A8A22B4-0x000000018A8A2380
		public string __Gen_Wrap_41(object P0); // 0x000000018A8A2380-0x000000018A8A2470
		public string __Gen_Wrap_42(NetworkUrls.EUrlType P0); // 0x000000018A8A2470-0x000000018A8A255C
		public string __Gen_Wrap_43(object P0, NetworkUrls.EUrlType P1); // 0x000000018A8A255C-0x000000018A8A2668
		public void __Gen_Wrap_44(object P0, object P1, int P2, int P3, int P4, int P5); // 0x000000018A8A2668-0x000000018A8A278C
		public System.Threading.Tasks.Task __Gen_Wrap_45(object P0, object P1, int P2, int P3, int P4, int P5); // 0x000000018A8A278C-0x000000018A8A28E0
		public void __Gen_Wrap_46(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public EndPoint __Gen_Wrap_47(object P0); // 0x000000018A8A28E0-0x000000018A8A29BC
		public void __Gen_Wrap_48(object P0, bool P1, bool P2); // 0x000000018A8A29BC-0x000000018A8A2AA0
		public TcpIO.WeakNetDelayConfig __Gen_Wrap_49(int P0, int P1, int P2); // 0x000000018A8A2AA0-0x000000018A8A2BD8
		public void __Gen_Wrap_50(ref long P0, ref int P1); // 0x000000018A8A2BD8-0x000000018A8A2CF8
		public void __Gen_Wrap_51(object P0, int P1, int P2, int P3, int P4, int P5, int P6); // 0x000000018A8A2CF8-0x000000018A8A2E2C
		public void __Gen_Wrap_52(object P0, ENetWeakNetPreset P1); // 0x00000001866F3838-0x00000001866F3914
		public TcpIOProfilerSnapshot __Gen_Wrap_53(object P0); // 0x000000018A8A2E2C-0x000000018A8A2F40
		public int __Gen_Wrap_54(TcpIO.WeakNetDelayConfig P0); // 0x000000018A8A2F40-0x000000018A8A3048
		public void __Gen_Wrap_55(object P0, TcpIO.WeakNetDelayConfig P1, ref long P2, ref int P3); // 0x000000018A8A3048-0x000000018A8A31CC
		public void __Gen_Wrap_56(object P0, object P1, int P2, int P3); // 0x000000018A8A31CC-0x000000018A8A32D4
		public byte[] __Gen_Wrap_57(object P0); // 0x000000018A8A32D4-0x000000018A8A33C4
		public int __Gen_Wrap_58(object P0, object P1, int P2, int P3); // 0x000000018A8A33C4-0x000000018A8A34D8
		public HttpSender.Cancellation __Gen_Wrap_59(ref HttpSender.FSendFunc P0); // 0x000000018A8A34D8-0x000000018A8A3688
		public UnityWebRequest __Gen_Wrap_60(object P0, HttpSender.FGetOptions P1); // 0x000000018A8A3688-0x000000018A8A37C0
		public UnityWebRequest __Gen_Wrap_61(object P0, HttpSender.FPostOptions P1); // 0x000000018A8A37C0-0x000000018A8A38F8
		public UnityWebRequest __Gen_Wrap_62(ref HttpSender.FSendFunc P0); // 0x000000018A8A38F8-0x000000018A8A3AA8
		public IEnumerator __Gen_Wrap_63(object P0, HttpSender.FSendFunc P1); // 0x000000018A8A3AA8-0x000000018A8A3C04
		public IEnumerator __Gen_Wrap_64(object P0, HttpSender.FSendFunc P1, object P2); // 0x000000018A8A3C04-0x000000018A8A3D78
		public IEnumerator __Gen_Wrap_65(object P0, HttpSender.FGetOptions P1, object P2, object P3); // 0x000000018A8A3D78-0x000000018A8A3ED8
		public IEnumerator __Gen_Wrap_66(object P0, HttpSender.FGetOptions P1, object P2); // 0x000000018A8A3ED8-0x000000018A8A4028
		public IEnumerator __Gen_Wrap_67(object P0, HttpSender.FPostOptions P1, object P2, object P3); // 0x000000018A8A4028-0x000000018A8A4188
		public IEnumerator __Gen_Wrap_68(object P0, HttpSender.FPostOptions P1, object P2); // 0x000000018A8A4188-0x000000018A8A42C8
		public void __Gen_Wrap_69(object P0, HttpSender.FSendFunc P1); // 0x000000018A8A42C8-0x000000018A8A43F4
		public HttpSender.Result __Gen_Wrap_70(); // 0x000000018A8A4538-0x000000018A8A45F0
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_71(HttpSender.FSendFunc P0); // 0x000000018A8A45F0-0x000000018A8A4720
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_72(object P0, HttpSender.FPostOptions P1); // 0x000000018A8A4720-0x000000018A8A4848
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_73(object P0, HttpSender.FGetOptions P1); // 0x000000018A8A4848-0x000000018A8A4970
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_74(object P0); // 0x000000018A8A4970-0x000000018A8A4A4C
		public int __Gen_Wrap_75(object P0, out bool P1); // 0x000000018A8A4A4C-0x000000018A8A4B58
		public string __Gen_Wrap_76(ref HttpSender.FSendFunc P0); // 0x000000018A8A4B58-0x000000018A8A4CF8
		public EHGNetSessionReconnectState __Gen_Wrap_77(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_78(object P0, EHGNetSessionReconnectState P1); // 0x0000000189E3EDF8-0x0000000189E3EED4
		public void __Gen_Wrap_79(object P0, object P1, ENetCloseReason P2); // 0x00000001866F4838-0x00000001866F4930
		public bool __Gen_Wrap_80(object P0, object P1, int P2, bool P3); // 0x000000018A8A4E1C-0x000000018A8A4F24
		public void __Gen_Wrap_81(object P0, ENetConnectErrorCode P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_82(object P0, ENetCloseReason P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_83(Task<System.Threading.Tasks.Task> P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_84(object P0, object P1, int P2, bool P3, out HGNetSessionConnectYield P4); // 0x000000018A8A4F24-0x000000018A8A5094
		public void __Gen_Wrap_85(object P0, NetRequest P1); // 0x000000018A8A5094-0x000000018A8A51B0
		public void __Gen_Wrap_86(object P0, long P1); // 0x0000000189CD5A30-0x0000000189CD5B0C
		public INetIO __Gen_Wrap_87(object P0); // 0x000000018A8A51B0-0x000000018A8A52A0
		public Task<bool> __Gen_Wrap_88(object P0, object P1, int P2); // 0x000000018A8A52A0-0x000000018A8A53C4
		public Task<bool> __Gen_Wrap_89(object P0, object P1, object P2, int P3, int P4, int P5, int P6); // 0x000000018A8A53C4-0x000000018A8A5528
		public System.Threading.Tasks.Task __Gen_Wrap_90(object P0, object P1); // 0x000000018A8A5618-0x000000018A8A5724
		public void __Gen_Wrap_91(object P0, object P1, long P2, int P3); // 0x000000018A8A5724-0x000000018A8A582C
		public bool __Gen_Wrap_92(object P0, object P1, int P2); // 0x000000018A8A582C-0x000000018A8A5930
		public System.Threading.Tasks.Task __Gen_Wrap_93(); // 0x000000018A8A5930-0x000000018A8A59E8
		public void __Gen_Wrap_94(object P0, object P1, object P2, int P3); // 0x000000018719F418-0x000000018719F520
		public void __Gen_Wrap_95(object P0, object P1, long P2, long P3); // 0x000000018A8A59E8-0x000000018A8A5AF0
		public byte[] __Gen_Wrap_96(); // 0x000000018A8A5AF0-0x000000018A8A5BBC
		public CLIENT_PLATFORM_TYPE __Gen_Wrap_97(); // 0x00000001863621C4-0x0000000186362270
		public ENV_TYPE __Gen_Wrap_98(); // 0x00000001863621C4-0x0000000186362270
		public int __Gen_Wrap_99(); // 0x00000001863621C4-0x0000000186362270
		public void __Gen_Wrap_100(object P0, object P1, ref NetRequest P2, bool P3); // 0x000000018A89F1B8-0x000000018A89F34C
		public bool __Gen_Wrap_101(object P0, object P1, out NetResponse P2, bool P3); // 0x000000018A89F34C-0x000000018A89F4BC
		public void __Gen_Wrap_102(object P0, long P1, int P2); // 0x000000018A89F4BC-0x000000018A89F5B4
		public byte[] __Gen_Wrap_103(object P0, object P1); // 0x000000018A89F5B4-0x000000018A89F6C0
		public bool __Gen_Wrap_104(object P0, object P1, object P2); // 0x0000000187195DFC-0x0000000187195F04
		public MSG_A1 __Gen_Wrap_105(object P0); // 0x000000018A89F6C0-0x000000018A89F7B0
		public HGNetSessionLoginYield __Gen_Wrap_106(object P0, object P1, object P2, int P3); // 0x000000018A89F7B0-0x000000018A89F8E4
		public void __Gen_Wrap_107(object P0, object P1, ref NetRequest P2); // 0x000000018A89F8E4-0x000000018A89FA68
		public bool __Gen_Wrap_108(object P0, object P1, out NetResponse P2); // 0x000000018A89FA68-0x000000018A89FBCC
		public NetDevProfilerSnapshot __Gen_Wrap_109(object P0); // 0x000000018A89FBCC-0x000000018A89FCF8
		public bool __Gen_Wrap_110(object P0, NetResponse P1); // 0x000000018A89FCF8-0x000000018A89FE20
		public void __Gen_Wrap_111(object P0, object P1, long P2); // 0x00000001871AEEA0-0x00000001871AEF98
		public bool __Gen_Wrap_112(CODE P0); // 0x0000000186361FA4-0x0000000186362070
		public bool __Gen_Wrap_113(object P0, object P1, NetResponse P2); // 0x000000018A89FE20-0x000000018A89FF60
		public void __Gen_Wrap_114(object P0, object P1, ref NetResponse P2); // 0x000000018A89FF60-0x000000018A8A00E0
		public MSG_B1 __Gen_Wrap_115(object P0); // 0x000000018A8A00E0-0x000000018A8A01D0
		public bool __Gen_Wrap_116(object P0, ref FLogMessage P1); // 0x000000018A8A01D0-0x000000018A8A0364
		public LogLevel __Gen_Wrap_117(ELogLevel P0); // 0x000000018A8A0364-0x000000018A8A0434
		public NativeLogLevel __Gen_Wrap_118(ELogLevel P0); // 0x000000018A8A0364-0x000000018A8A0434
		public int __Gen_Wrap_119(ELogChannel P0); // 0x000000018A8A0364-0x000000018A8A0434
		public bool __Gen_Wrap_120(NativeLogLevel P0, int P1); // 0x00000001869ACC64-0x00000001869ACD4C
		public bool __Gen_Wrap_121(ELogLevel P0, ELogChannel P1); // 0x0000000186373694-0x0000000186373780
		public void __Gen_Wrap_122(object P0, object P1, object P2, UnityEngine.LogType P3); // 0x000000018719F418-0x000000018719F520
		public HGNetLoggerClient __Gen_Wrap_123(); // 0x000000018A8A0434-0x000000018A8A0500
		public void __Gen_Wrap_124(object P0, ref LogMessage P1); // 0x000000018A8A0500-0x000000018A8A0628
		public void __Gen_Wrap_125(object P0, ref FLogMessage P1); // 0x000000018A8A0628-0x000000018A8A07AC
		public void __Gen_Wrap_126(object P0, ulong P1, ulong P2, ulong P3, ulong P4); // 0x000000018A8A07AC-0x000000018A8A08BC
		public void __Gen_Wrap_127(object P0, object P1, object P2, object P3, object P4); // 0x00000001866C1D88-0x00000001866C1EA0
		public void __Gen_Wrap_128(bool P0); // 0x00000001866DCC44-0x00000001866DCCF0
		public void __Gen_Wrap_129(ulong P0); // 0x0000000186362A48-0x0000000186362B08
		public Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> __Gen_Wrap_130(); // 0x000000018A8A09AC-0x000000018A8A0A78
		public Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> __Gen_Wrap_131(); // 0x000000018A8A0A78-0x000000018A8A0B44
		public bool __Gen_Wrap_132(object P0, out Beyond.Network.HGNetLogger.MessageType P1); // 0x00000001869AD848-0x00000001869AD954
		public void __Gen_Wrap_133(object P0, object P1, NetRequest P2); // 0x000000018A8A0B44-0x000000018A8A0C78
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object>, IAsyncStateMachine // TypeDefIndex: 59500
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
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x000000018A8A605C-0x000000018A8A6108 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x000000018A8A6108-0x000000018A8A61B4 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018A8A61B4-0x000000018A8A62A8
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x0000000186365FC0-0x000000018636603C
		[IDTag(1)]
		private bool MoveNext(); // 0x0000000186365D60-0x0000000186365DEC
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x0000000186365E98-0x0000000186365F14
		[IDTag(5)]
		private void MoveNext(); // 0x000000018A8A5D4C-0x000000018A8A5DDC
		[IDTag(6)]
		private void SetStateMachine(IAsyncStateMachine P0); // 0x000000018A8A5FAC-0x000000018A8A605C
		public void RefAwaitUnsafeOnCompleteMethod(); // 0x000000018A8A5E70-0x000000018A8A5FAC
		public void RefAsyncBuilderStartMethod(); // 0x000000018A8A5DDC-0x000000018A8A5E70
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59501
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018A8A6490-0x000000018A8A64F4
		public static bool IsPatched(int id); // 0x000000018314AF50-0x000000018314AFE0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018A8A634C-0x000000018A8A6418
		public object CreateWrapper(int id); // 0x000000018A8A6418-0x000000018A8A6490
		public object InitWrapperArray(int len); // 0x000000018A8A64F4-0x000000018A8A6580
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018A8A62A8-0x000000018A8A634C
	}

	public enum IDMAP0 // TypeDefIndex: 59502
	{
		Beyond-Network-HGTcpClient-get_Client0 = 0,
		Beyond-Network-HGTcpClient-set_Client0 = 1,
		Beyond-Network-HGTcpClient-get_Active0 = 2,
		Beyond-Network-HGTcpClient-set_Active0 = 3,
		Beyond-Network-HGTcpClient-get_Available0 = 4,
		Beyond-Network-HGTcpClient-get_Connected0 = 5,
		Beyond-Network-HGTcpClient-get_ExclusiveAddressUse0 = 6,
		Beyond-Network-HGTcpClient-set_ExclusiveAddressUse0 = 7,
		Beyond-Network-HGTcpClient-Connect1 = 8,
		Beyond-Network-HGTcpClient-Connect0 = 9,
		Beyond-Network-HGTcpClient-Connect2 = 10,
		Beyond-Network-HGTcpClient-Connect3 = 11,
		Beyond-Network-HGTcpClient-BeginConnect0 = 12,
		Beyond-Network-HGTcpClient-BeginConnect1 = 13,
		Beyond-Network-HGTcpClient-BeginConnect2 = 14,
		Beyond-Network-HGTcpClient-EndConnect0 = 15,
		Beyond-Network-HGTcpClient-ConnectAsync0 = 16,
		Beyond-Network-HGTcpClient-ConnectAsync1 = 17,
		Beyond-Network-HGTcpClient-ConnectAsync2 = 18,
		Beyond-Network-HGTcpClient-GetStream0 = 19,
		Beyond-Network-HGTcpClient-Close0 = 20,
		Beyond-Network-HGTcpClient-Dispose0 = 21,
		Beyond-Network-HGTcpClient-Dispose1 = 22,
		Beyond-Network-HGTcpClient-get_ReceiveBufferSize0 = 23,
		Beyond-Network-HGTcpClient-_NumericOption0 = 24,
		Beyond-Network-HGTcpClient-set_ReceiveBufferSize0 = 25,
		Beyond-Network-HGTcpClient-get_SendBufferSize0 = 26,
		Beyond-Network-HGTcpClient-set_SendBufferSize0 = 27,
		Beyond-Network-HGTcpClient-get_ReceiveTimeout0 = 28,
		Beyond-Network-HGTcpClient-set_ReceiveTimeout0 = 29,
		Beyond-Network-HGTcpClient-get_SendTimeout0 = 30,
		Beyond-Network-HGTcpClient-set_SendTimeout0 = 31,
		Beyond-Network-HGTcpClient-get_LingerState0 = 32,
		Beyond-Network-HGTcpClient-set_LingerState0 = 33,
		Beyond-Network-HGTcpClient-get_NoDelay0 = 34,
		Beyond-Network-HGTcpClient-set_NoDelay0 = 35,
		Beyond-Network-HGTcpClient-_Initialize0 = 36,
		Beyond-Network-NetResponse-get_logHead0 = 37,
		Beyond-Network-NetResponse-set_logHead0 = 38,
		Beyond-Network-NetResponse-get_csHead0 = 39,
		Beyond-Network-NetResponse-set_csHead0 = 40,
		Beyond-Network-NetResponse-get_msgId0 = 41,
		Beyond-Network-NetResponse-get_csSeqId0 = 42,
		Beyond-Network-NetResponse-get_scSeqId0 = 43,
		Beyond-Network-NetBus-get_currentSessionID0 = 44,
		Beyond-Network-NetBus-Setup0 = 46,
		Beyond-Network-NetBus-Send0 = 47,
		Beyond-Network-NetBus-_ValidateSession0 = 48,
		Beyond-Network-HGNetBaseSession-get_isRunning0 = 49,
		Beyond-Network-HGNetSession-SendMessage0 = 50,
		Beyond-Network-HGNetBaseSession-IncrementCSSeqID0 = 51,
		Beyond-Network-NetBus-RegisterMessageHandler0 = 52,
		Beyond-Network-NetUtil-GetSCMsgTypeById0 = 53,
		Beyond-Network-NetBus-UnRegisterMessageHandler0 = 54,
		Beyond-Network-NetBus-OnNetClientShutDown0 = 55,
		Beyond-Network-NetBus-_SendWithResult0 = 61,
		Beyond-Network-NetBus-_Listen0 = 64,
		Beyond-Network-NetBus-_UnListen0 = 65,
		Beyond-Network-NetBus-_UnListenWithSeqNum0 = 66,
		Beyond-Network-NetBus-ResultHandler-SetIgnoreSeq0 = 67,
		Beyond-Network-NetBus-ResultHandler-OnResponse0 = 68,
		Beyond-Network-NetBus-ResultHandler-_HandleMessage0 = 69,
		Beyond-Network-NetBus-ResultHandler-_CheckSessionIDValid0 = 70,
		Beyond-Network-NetBus-ResultHandler-Dispose0 = 72,
		Beyond-Network-NetBus-Sender-DoSend0 = 76,
		Beyond-Network-NetBus-Sender-DoListen0 = 77,
		Beyond-Network-NetBus-Sender-DoUnListen0 = 78,
		Beyond-Network-Special2BusSender-get_isBusBusy0 = 79,
		Beyond-Network-Special2BusSender-Send0 = 80,
		Beyond-Network-DisposableBusSender-Send0 = 81,
		Beyond-Network-Special2BusSender-OnNetShutDown0 = 83,
		Beyond-Network-DisposableBusSender-OnNetShutDown0 = 84,
		Beyond-Network-DisposableBusSender-_Clear0 = 85,
		Beyond-Network-Special2BusSender-_ClearSendTime0 = 86,
		Beyond-Network-Special2BusSender-Dispose0 = 87,
		Beyond-Network-DisposableBusSender-Dispose0 = 88,
		Beyond-Network-InteractiveBusSender-get_isBusBusy0 = 90,
		Beyond-Network-NetworkMaskConfigHolder-Init0 = 91,
		Beyond-Network-NetworkMaskConfigHolder-_LoadJsonConfig0 = 92,
		Beyond-Network-NetworkMaskConfigHolder-_LoadScriptableObjectConfig0 = 93,
		Beyond-Network-NetworkMaskConfigHolder-Dispose0 = 94,
		Beyond-Network-UIBusSender-Dispose0 = 95,
		Beyond-Network-NetworkMask-RemoveMask0 = 97,
		Beyond-Network-NetworkMask-_UpdateMaskState0 = 98,
		Beyond-Network-NetworkMask-MaskInfo-get_endTime0 = 99,
		Beyond-Network-NetworkMask-MaskInfo-get_showDecoTime0 = 100,
		Beyond-Network-UIBusSender-Send0 = 105,
		Beyond-Network-NetUtil-GetCSMsgIdByType0 = 110,
		Beyond-Network-NetworkMask-AddMask1 = 111,
		Beyond-Network-NetworkMask-AddMask0 = 112,
		Beyond-Network-NetworkMask-_GetKey0 = 113,
		Beyond-Network-UIBusSender-OnNetShutDown0 = 114,
		Beyond-Network-TeleportMaskSender-Dispose0 = 115,
		Beyond-Network-TeleportMaskSender-Send0 = 116,
		Beyond-Network-TeleportMaskSender-OnNetShutDown0 = 122,
		Beyond-Network-FrequencyControlBusSender-_TrySendWaitingMsg0 = 123,
		Beyond-Network-FrequencyControlBusSender-Send0 = 124,
		Beyond-Network-FrequencyControlBusSender-Send1 = 129,
		Beyond-Network-FrequencyControlBusSender-Dispose0 = 130,
		Beyond-Network-ServerConfig-IsSame0 = 131,
		Beyond-Network-NetUtil-RegisterSCMessage0 = 132,
		Beyond-Network-NetUtil-RegisterCSMessage0 = 133,
		Beyond-Network-NetUtil-GetSCMsgIdByType0 = 134,
		Beyond-Network-NetUtil-FastRegisterMessage0 = 135,
		Beyond-Network-NetUtil-GetNetMessageFromDataBytes0 = 136,
		Beyond-Network-NetUtil-SerializeHeadMessage0 = 137,
		Beyond-Network-NetUtil-AutoRegisterMessageHandlers0 = 138,
		Beyond-Network-NetUtil-AutoUnRegisterMessageHandlers0 = 139,
		Beyond-Network-NetUtil-_ForeachMessageHandlers0 = 143,
		Beyond-Network-NetworkMask-OnInit0 = 144,
		Beyond-Network-NetworkMask-_CreateTickFunction0 = 145,
		Beyond-Network-NetworkMask-PreTick0 = 146,
		Beyond-Network-NetworkMask-_OnSwitchLanguage0 = 147,
		Beyond-Network-NetworkMask-OnUnInit0 = 148,
		Beyond-Network-NetworkMask-_ClearTickFunction0 = 149,
		Beyond-Network-NetworkMask-Release0 = 150,
		Beyond-Network-NetworkMask-ListenOnNetMaskChanged0 = 151,
		Beyond-Network-NetworkMask-UnListenOnNetMaskChanged0 = 152,
		Beyond-Network-NetworkUrls-RemoteConfigUrl0 = 153,
		Beyond-Network-NetworkUrls-ResourceRootUrlDev0 = 154,
		Beyond-Network-NetworkUrls-ServerListUrl0 = 155,
		Beyond-Network-NetworkUrls-_GetUrlFromLocal0 = 156,
		Beyond-Network-NetworkUrls-AgeTipsUrl0 = 157,
		Beyond-Network-NetworkUrls-_SelectUrl0 = 158,
		Beyond-Network-NetworkUrls-GovUrl0 = 159,
		Beyond-Network-NetworkUrls-LauncherUrl0 = 160,
		Beyond-Network-TcpIO-Connect0 = 161,
		Beyond-Network-TcpIO-IsConnected0 = 162,
		Beyond-Network-TcpIO-Close0 = 163,
		Beyond-Network-TcpIO-ConnectAsync0 = 164,
		Beyond-Network-TcpIO-IsAuthed0 = 165,
		Beyond-Network-TcpIO-MarkAuthed0 = 166,
		Beyond-Network-TcpIO-EnableCryptStream0 = 167,
		Beyond-Network-TcpIO-GetEndPoint0 = 168,
		Beyond-Network-TcpIO-TestCloseNetIO0 = 169,
		Beyond-Network-TcpIO-TestDropNetIO0 = 170,
		Beyond-Network-TcpIO-SetWeakNetPreset0 = 171,
		Beyond-Network-TcpIO-SetWeakNetCustom0 = 172,
		Beyond-Network-TcpIO-_CreateWeakNetDelayConfig0 = 173,
		Beyond-Network-TcpIO-_ResetWeakNetWindow0 = 174,
		Beyond-Network-TcpIO-GetProfilerSnapshot0 = 175,
		Beyond-Network-TcpIO-WriteData0 = 176,
		Beyond-Network-TcpIO-_ApplyWeakNetDelay0 = 177,
		Beyond-Network-TcpIO-_NextDelayMs0 = 178,
		Beyond-Network-TcpIO-WriteCryptoData0 = 179,
		Beyond-Network-TcpIO-GetSendHeadBuffer0 = 180,
		Beyond-Network-TcpIO-GetSendBuffer0 = 181,
		Beyond-Network-TcpIO-GetReceiveBuffer0 = 182,
		Beyond-Network-TcpIO-ClearReceiveBufferOffset0 = 183,
		Beyond-Network-TcpIO-GetReceiveBufferOffset0 = 184,
		Beyond-Network-TcpIO-SkipReceiveBufferOffset0 = 185,
		Beyond-Network-TcpIO-ReadData0 = 186,
		Beyond-Network-TcpIO-ReadCryptoData0 = 187,
		Beyond-Network-TcpIO-Available0 = 188,
		Beyond-Network-TcpIO-Dispose0 = 189,
		Beyond-Network-HttpSender-YieldSendGet1 = 190,
		Beyond-Network-HttpSender-YieldSendGet0 = 194,
		Beyond-Network-HttpSender-_YieldSendHttpRequest1 = 198,
		Beyond-Network-HttpSender-_YieldSendHttpRequest0 = 202,
		Beyond-Network-HttpSender-FSendFunc-GetCancellation0 = 207,
		Beyond-Network-HttpSender-FSendFunc-Invoke0 = 208,
		Beyond-Network-HttpSender-_CreateWebRequestGET0 = 209,
		Beyond-Network-HttpSender-_CreateWebRequestPOST0 = 210,
		Beyond-Network-HttpSender-Cancellation-IsCanceled0 = 211,
		Beyond-Network-HttpSender-_SetHttpResult0 = 212,
		Beyond-Network-HttpSender-_MarkResultAsException0 = 213,
		Beyond-Network-HttpSender-_DeserializeTypedResult0 = 217,
		Beyond-Network-HttpSender-YieldSendPost1 = 228,
		Beyond-Network-HttpSender-YieldSendPost0 = 232,
		Beyond-Network-HttpSender-WaitForSendPost0 = 242,
		Beyond-Network-HttpSender-_WaitForSendHttpRequest0 = 243,
		Beyond-Network-HttpSender-_WaitForServiceDone0 = 246,
		Beyond-Network-HttpSender-_StartWebRequestTask0 = 247,
		Beyond-Network-HttpSender-WaitForSendGet1 = 248,
		Beyond-Network-HttpSender-WaitForSendGet0 = 249,
		Beyond-Network-HttpSender-GetGeneralErrorCode0 = 250,
		Beyond-Network-HttpSender-_DebugOnlyProfileResult0 = 251,
		Beyond-Network-HttpSender-Cancellation-Cancel0 = 252,
		Beyond-Network-HttpSender-FSendFunc-GetOptMethod0 = 253,
		Beyond-Network-HGNetBaseSession-get_reconnectState0 = 254,
		Beyond-Network-HGNetBaseSession-set_reconnectState0 = 255,
		Beyond-Network-HGNetBaseSession-get_isConnecting0 = 256,
		Beyond-Network-HGNetBaseSession-get_isRunningAndConnected0 = 257,
		Beyond-Network-HGNetBaseSession-get_isReconnecting0 = 258,
		Beyond-Network-HGNetBaseSession-get_closeErrorCode0 = 259,
		Beyond-Network-HGNetBaseSession-get_isAutoReconnect0 = 260,
		Beyond-Network-HGNetBaseSession-get_maxRecycleQueueCount0 = 261,
		Beyond-Network-HGNetBaseSession-Start0 = 262,
		Beyond-Network-HGNetBaseSession-Connect0 = 264,
		Beyond-Network-HGNetBaseSession-_ApplyWeakNetConfigToTcpIO0 = 265,
		Beyond-Network-HGNetBaseSession-_DNSCheck0 = 266,
		Beyond-Network-HGNetBaseSession-InternalClose1 = 267,
		Beyond-Network-HGNetBaseSession-InternalClose0 = 268,
		Beyond-Network-HGNetBaseSession-RemoveAutoReconnect0 = 269,
		Beyond-Network-HGNetBaseSession-CloseTCPMsgThreadTask0 = 270,
		Beyond-Network-HGNetBaseSession-ConnectAsync0 = 271,
		Beyond-Network-HGNetBaseSession-OnConnectAsyncEnd0 = 274,
		Beyond-Network-HGNetSessionConnectYield-SetFinish0 = 275,
		Beyond-Network-HGNetBaseSession-Close0 = 276,
		Beyond-Network-HGNetBaseSession-EnqueueSendMsg0 = 277,
		Beyond-Network-HGNetBaseSession-GetSendQueueMsgCount0 = 278,
		Beyond-Network-HGNetBaseSession-SetCSSeqID0 = 279,
		Beyond-Network-HGNetBaseSession-GetCSSeqID0 = 280,
		Beyond-Network-HGNetBaseSession-GetIO0 = 281,
		Beyond-Network-HGNetBaseSession-StartTCPMsgLoopThreadTask0 = 282,
		Beyond-Network-HGNetBaseSession-_SessionThread0 = 285,
		Beyond-Network-HGNetBaseSession-_ReconnectCheckerTick0 = 287,
		Beyond-Network-HGNetBaseSession-_DoReconnectAsync0 = 288,
		Beyond-Network-HGNetBaseSession-TryCloseTcpIOWithTimeout0 = 290,
		Beyond-Network-HGNetBaseSession-TryConnectWithTimeout0 = 295,
		Beyond-Network-HGNetBaseSession-SessionCheckSignalAndSleep0 = 301,
		Beyond-Network-HGNetBaseSession-_ReadAndCheckMessageInSessionThread0 = 302,
		Beyond-Network-HGNetBaseSession-NetStatusChecker_Receive0 = 303,
		Beyond-Network-HGNetBaseSession-_SendAndCheckMessage0 = 304,
		Beyond-Network-HGNetBaseSession-NetStatusChecker_Sender0 = 305,
		Beyond-Network-HGNetBaseSession-OpenAutoReconnect0 = 307,
		Beyond-Network-HGNetBaseSession-SetWeakNetPreset0 = 308,
		Beyond-Network-HGNetBaseSession-SetWeakNetCustom0 = 309,
		Beyond-Network-HGNetSession-SetAutoReconnectToken0 = 310,
		Beyond-Network-HGNetSession-SessionConnectTimeoutCheckerTick0 = 311,
		Beyond-Network-HGNetSession-DoReconnectLogin0 = 312,
		Beyond-Network-HGNetSession-GetClientPublicKey0 = 313,
		Beyond-Network-HGNetSession-_CSLoginHelper_UpdateAppInfo0 = 314,
		Beyond-Network-HGNetSession-_GetOnlineResVersion0 = 315,
		Beyond-Network-HGNetSession-_GetPlatformID0 = 316,
		Beyond-Network-HGNetSession-_GetSDKEnv0 = 317,
		Beyond-Network-HGNetSession-_GetPayPlatform0 = 318,
		Beyond-Network-HGNetSession-_WriteMessageInSessionThread0 = 319,
		Beyond-Network-HGNetSession-_ReadMessageInSessionThread0 = 320,
		Beyond-Network-HGNetSession-_ApproximateLoginServerTime0 = 321,
		Beyond-Network-HGNetSession-_HandleLoginEncryp0 = 322,
		Beyond-Network-HGNetSession-_RSADecrypt0 = 323,
		Beyond-Network-HGNetSession-Start0 = 324,
		Beyond-Network-HGNetSession-OnApplicationPause0 = 325,
		Beyond-Network-HGNetSession-_FlushMergeQueueToSendQueue0 = 326,
		Beyond-Network-HGNetSession-LoginAsync0 = 327,
		Beyond-Network-HGNetSession-_SessionLoginThreadTask0 = 328,
		Beyond-Network-HGNetSessionLoginYield-GetRequest0 = 329,
		Beyond-Network-HGNetSessionLoginYield-SetConnectErrorError0 = 330,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectError0 = 331,
		Beyond-Network-HGNetSessionLoginYield-SetSucceed0 = 334,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Clear0 = 335,
		Beyond-Network-HGNetSessionLoginYield-SetNtfError0 = 336,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Set0 = 337,
		Beyond-Network-HGNetSessionLoginYield-SetTimeOutError0 = 338,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectTimeOut0 = 339,
		Beyond-Network-HGNetSession-StartMsgLoop0 = 340,
		Beyond-Network-HGNetSession-OnConnectedSucceed0 = 341,
		Beyond-Network-HGNetSession-OnReconnectTimesOver0 = 342,
		Beyond-Network-HGNetSession-NeedKeepConnect0 = 343,
		Beyond-Network-HGNetSession-CheckAndWriteReqMsg0 = 344,
		Beyond-Network-HGNetSession-ReadMessageInSessionThread0 = 345,
		Beyond-Network-HGNetSession-ClearRecvQueue0 = 346,
		Beyond-Network-HGNetSession-ClearSendQueue0 = 347,
		Beyond-Network-HGNetSession-GetNetDevProfilerSnapshot0 = 348,
		Beyond-Network-HGNetSession-GetPing0 = 349,
		Beyond-Network-HGNetSession-GetPingPassedTime0 = 350,
		Beyond-Network-HGNetSession-IsPingInProgress0 = 351,
		Beyond-Network-HGNetSession-ClearPingWDG0 = 352,
		Beyond-Network-HGNetSession-_HandleSpecialMessagePing0 = 353,
		Beyond-Network-HGNetSession-IsPingOut0 = 354,
		Beyond-Network-HGNetSession-PingSenderTick0 = 355,
		Beyond-Network-HGNetSession-InitClientRSAKey0 = 356,
		Beyond-Network-HGNetSession-ClearRSAKey0 = 357,
		Beyond-Network-HGNetSession-CheckAndDealRespMessages0 = 358,
		Beyond-Network-HGNetSession-_HandleSpecialMessageErrorCode0 = 359,
		Beyond-Network-HGNetSessionUtils-CheckErrorNeedsDisconnect0 = 360,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectIncr0 = 361,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectFull0 = 362,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectLogin0 = 363,
		Beyond-Network-HGNetSessionLoginYield-GetResponse0 = 364,
		Beyond-Network-HGNetSessionLoginYield-GetErrorCode0 = 365,
		Beyond-Network-HGNetSessionLoginYield-GetErrorDetails0 = 367,
		Beyond-Network-HGNetSessionLoginYield-get_isSucceed0 = 369,
		Beyond-Network-HGNetSessionLoginYield-get_keepWaiting0 = 370,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorInvaild0 = 371,
		Beyond-Network-HGNetSessionConnectYield-GetCode0 = 372,
		Beyond-Network-HGNetSessionConnectYield-get_isSucceed0 = 373,
		Beyond-Network-HGNetSessionConnectYield-get_keepWaiting0 = 374,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_isRunning0 = 375,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_isConnecting0 = 376,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_isRunningAndConnected0 = 377,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_closeErrorCode0 = 378,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_isAutoReconnect0 = 379,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Start0 = 380,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Connect0 = 381,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DNSCheck0 = 382,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close1 = 383,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close0 = 384,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-RemoveAutoReconnect0 = 385,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-CloseTCPMsgThreadTask0 = 386,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-ConnectAsync0 = 387,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-OnConnectAsyncEnd0 = 388,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-EnqueueSendMsg0 = 389,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetSendQueueMsgCount0 = 390,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-IncrementCSSeqID0 = 391,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-SetCSSeqID0 = 392,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetCSSeqID0 = 393,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetIO0 = 394,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-StartTCPMsgLoopThreadTask0 = 395,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_SessionThread0 = 396,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_ReconnectCheckerTick0 = 397,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-SessionCheckSignalAndSleep0 = 398,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Receive0 = 399,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Sender0 = 400,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-OpenAutoReconnect0 = 401,
		Beyond-Network-HGNetLogger-HGNetLogger-Log0 = 402,
		Beyond-Network-HGNetLogger-HGNetLogger-CheckLog0 = 403,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger0 = 404,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLoggerV20 = 405,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger1 = 406,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-get_instance0 = 407,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-ShutDown0 = 408,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-_CloseAndClear0 = 409,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-AddLog0 = 410,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-_FlushLocalLogQueue0 = 411,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled1 = 412,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-ConvertFromDLogger0 = 413,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled0 = 414,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-WriteNetLog0 = 415,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SendMessage0 = 416,
		Beyond-Network-HGNetLogger-HGNetLogger-Clear0 = 417,
		Beyond-Network-HGNetLogger-HGNetLogger-SetLogChannel0 = 418,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-Init0 = 419,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_uid0 = 420,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_roleId0 = 421,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SetAutoReconnectToken0 = 422,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SetReconnectSuccessCallback0 = 424,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-OnApplicationPause0 = 425,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnApplicationPause0 = 426,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-SetRoleID0 = 427,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-SetNetLogMaskFromServer0 = 429,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-SetCloudLogControl0 = 430,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsLocalLogLevelEnabled0 = 431,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageType2Id0 = 432,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageId2Type0 = 433,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-TryGetMsgTypeByID0 = 434,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-Start0 = 435,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnConnectedSucceed0 = 436,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SendLogin0 = 437,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_WriteMessageInSessionThread0 = 439,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ReadMessageInSessionThread0 = 440,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndDealRespMessages0 = 441,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndWriteReqMsg0 = 442,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-NeedKeepConnect0 = 443,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-DoReconnectLogin0 = 444,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_GetConnectTimeoutTime0 = 445,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SessionConnectTimeoutCheckerTick0 = 446,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearPingWDG0 = 447,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-IsPingOut0 = 448,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-PingSenderTick0 = 449,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-InitClientRSAKey0 = 450,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRSAKey0 = 451,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRecvQueue0 = 452,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearSendQueue0 = 453,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnReconnectTimesOver0 = 454
	}
}
