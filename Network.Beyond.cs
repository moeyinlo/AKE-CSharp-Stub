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
using IFix;
using IFix.Core;
using Proto;
using ProtoBuf;
using UnityEngine;
using UnityEngine.Networking;

// Image 39: Network.Beyond.dll - Assembly: Network.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 85627-85894

namespace Beyond.Network
{
	public class DoubleQueue<T> // TypeDefIndex: 85636
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

	public enum ENetWeakNetPreset // TypeDefIndex: 85637
	{
		Disabled = 0,
		LightJitter = 1,
		NormalWifiLag = 2,
		PoorMobileNetwork = 3,
		SevereLag = 4
	}

	public class HGTcpClient : IDisposable // TypeDefIndex: 85638
	{
		// Fields
		private Socket m_ClientSocket; // 0x10
		private bool m_Active; // 0x18
		private NetworkStream m_DataStream; // 0x20
		private AddressFamily m_Family; // 0x28
		private bool m_CleanedUp; // 0x2C
	
		// Properties
		public Socket Client { get; set; } // 0x000000018CA4DEA8-0x000000018CA4DEE8 0x000000018CA4E0EC-0x000000018CA4E12C
		protected bool Active { get; set; } // 0x000000018CA4DE64-0x000000018CA4DEA8 0x000000018CA4E0B4-0x000000018CA4E0EC
		public int Available { get; } // 0x000000018571E4F0-0x000000018571E580 
		public bool Connected { get; } // 0x000000018578AA90-0x000000018578AAD0 
		public bool ExclusiveAddressUse { get; set; } // 0x000000018CA4DEE8-0x000000018CA4DF3C 0x000000018CA4E12C-0x000000018CA4E184
		public int ReceiveBufferSize { get; set; } // 0x000000018CA4DF94-0x000000018CA4DFDC 0x0000000185ADEF70-0x0000000185ADEFC0
		public int SendBufferSize { get; set; } // 0x000000018CA4E024-0x000000018CA4E06C 0x0000000185ADEFC0-0x0000000185ADF010
		public int ReceiveTimeout { get; set; } // 0x000000018CA4DFDC-0x000000018CA4E024 0x000000018CA4E1F4-0x000000018CA4E264
		public int SendTimeout { get; set; } // 0x000000018CA4E06C-0x000000018CA4E0B4 0x0000000185ADF010-0x0000000185ADF060
		public LingerOption LingerState { get; set; } // 0x0000000185ADDEC0-0x0000000185ADDF50 0x000000018CA4E184-0x000000018CA4E1F4
		public bool NoDelay { get; set; } // 0x000000018CA4DF3C-0x000000018CA4DF94 0x0000000185ADF060-0x0000000185ADF0C0
	
		// Constructors
		public HGTcpClient(); // 0x0000000185ADEEB0-0x0000000185ADEEC0
		public HGTcpClient(string hostname, int port); // 0x000000018CA4DCD0-0x000000018CA4DE3C
		internal HGTcpClient(Socket acceptedSocket); // 0x000000018CA4DE3C-0x000000018CA4DE64
	
		// Methods
		[IDTag(1)]
		public void Connect(string hostname, int port); // 0x0000000185ADE740-0x0000000185ADEEB0
		[IDTag(2)]
		public void Connect(IPAddress address, int port); // 0x000000018CA4DA18-0x000000018CA4DBA0
		[IDTag(0)]
		public void Connect(IPEndPoint remoteEP); // 0x0000000185ADDC70-0x0000000185ADDCD0
		[IDTag(3)]
		public void Connect(IPAddress[] ipAddresses, int port); // 0x000000018CA4D9B4-0x000000018CA4DA18
		[IDTag(0)]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state); // 0x0000000185ADB930-0x0000000185ADB980
		[IDTag(1)]
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state); // 0x000000018CA4D664-0x000000018CA4D6DC
		[IDTag(2)]
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state); // 0x000000018CA4D5EC-0x000000018CA4D664
		public void EndConnect(IAsyncResult asyncResult); // 0x0000000185FD86A0-0x0000000185FD86F0
		[IDTag(0)]
		public System.Threading.Tasks.Task ConnectAsync(IPAddress address, int port); // 0x000000018CA4D6DC-0x000000018CA4D848
		[IDTag(1)]
		public System.Threading.Tasks.Task ConnectAsync(string host, int port); // 0x00000001863D2280-0x00000001863D23F0
		[IDTag(2)]
		public System.Threading.Tasks.Task ConnectAsync(IPAddress[] addresses, int port); // 0x000000018CA4D848-0x000000018CA4D9B4
		public NetworkStream GetStream(); // 0x000000018571F6D0-0x000000018571F780
		public void Close(); // 0x0000000185B6A0E0-0x0000000185B6A150
		[IDTag(0)]
		protected virtual void Dispose(bool disposing); // 0x0000000185B69F00-0x0000000185B6A0E0
		[IDTag(1)]
		public void Dispose(); // 0x0000000185B69ED0-0x0000000185B69F00
		~HGTcpClient(); // 0x000000018CA4DBA0-0x000000018CA4DC18
		private void _Initialize(); // 0x0000000185ADEEC0-0x0000000185ADEF70
		private int _NumericOption(SocketOptionLevel optionLevel, SocketOptionName optionName); // 0x000000018CA4DC18-0x000000018CA4DCD0
	}

	public interface INetIO : IDisposable // TypeDefIndex: 85639
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

	public sealed class LuaProtoUtil : ILuaCallCSharp // TypeDefIndex: 85640
	{
		// Constructors
		private LuaProtoUtil(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static CS_GM_COMMAND AllocateCSGMCommand(); // 0x000000018CA4E5F4-0x000000018CA4E674
		public static CS_DUNGEON_RECOVER_AP AllocateCSDungeonRecoverAP(); // 0x000000018CA4E574-0x000000018CA4E5F4
		public static ITEM_BUNDLE AllocateItemBundle(); // 0x000000018CA4E6F4-0x000000018CA4E774
		public static INST_ITEM_BUNDLE AllocateInstItemBundle(); // 0x000000018CA4E674-0x000000018CA4E6F4
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class NetMsgHandlerAttribute : Attribute // TypeDefIndex: 85641
	{
		// Fields
		public readonly System.Type msgType; // 0x10
	
		// Properties
		internal virtual bool disposeAfterInvoke { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public NetMsgHandlerAttribute(System.Type t); // 0x0000000184FD2410-0x0000000184FD2420
		public NetMsgHandlerAttribute(); // 0x00000001863017D0-0x00000001863017F0
	
		// Methods
		public System.Type GetMsgType(MethodInfo annotatedMethod); // 0x0000000186404E20-0x0000000186404EE0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class NetMsgAndDisposeHandlerAttribute : NetMsgHandlerAttribute // TypeDefIndex: 85642
	{
		// Properties
		internal override bool disposeAfterInvoke { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public NetMsgAndDisposeHandlerAttribute(System.Type t); // 0x0000000184FD2410-0x0000000184FD2420
		public NetMsgAndDisposeHandlerAttribute(); // 0x00000001863017D0-0x00000001863017F0
	}

	public delegate void NetResponseHandler([IsReadOnly] in NetResponse msg); // TypeDefIndex: 85643; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void NetMessageHandle<in T>(T message); // TypeDefIndex: 85644; 0x00000000-0x00000000

	public interface INetBusResponseListener // TypeDefIndex: 85645
	{
		// Methods
		void UpdateMsgTime(NetResponse resp);
	}

	public struct NetRequest // TypeDefIndex: 85646
	{
		// Fields
		public ulong csSeqID; // 0x00
		public int mergeNum; // 0x08
		public IExtensible msg; // 0x10
	}

	public class NetBus : ExplicitSingleton<NetBus> // TypeDefIndex: 85650
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
		public UIBusSender uiSender { [CompilerGenerated] get; } // 0x00000001829600D0-0x00000001829600E0 
		public TeleportMaskSender teleportMaskSender { [CompilerGenerated] get; } // 0x0000000182986470-0x0000000182986480 
		public DisposableBusSender defaultSender { [CompilerGenerated] get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public Special2BusSender s2Sender { [CompilerGenerated] get; } // 0x000000018226EE80-0x000000018226EE90 
		public InteractiveBusSender interactiveSender { [CompilerGenerated] get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public FrequencyControlBusSender frequencyControlSender { [CompilerGenerated] get; } // 0x0000000187232F70-0x0000000187232F80 
		public int currentSessionID { get; } // 0x0000000185D99770-0x0000000185D997E0 
	
		// Nested types
		private class HandlerEntry // TypeDefIndex: 85647
		{
			// Fields
			public NetResponseHandler handler; // 0x10
	
			// Constructors
			public HandlerEntry(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class ResultHandler : IDisposable // TypeDefIndex: 85648
		{
			// Fields
			private bool m_ignoreSeq; // 0x10
			private ListDict<SCMessageID, object> m_responseTokens; // 0x18
			private ListDict<SCMessageID, NetResponseHandler> m_responseHandlers; // 0x20
			private Action<ResultHandler> m_onDisposed; // 0x28
			[CompilerGenerated]
			private bool _isDisposed_k__BackingField; // 0x30
			[CompilerGenerated]
			private ulong _cachedSeqNum_k__BackingField; // 0x38
			[CompilerGenerated]
			private int _sessionID_k__BackingField; // 0x40
	
			// Properties
			public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
			internal ulong cachedSeqNum { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x00000001855D8A50-0x00000001855D8A60
			public int sessionID { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
	
			// Constructors
			public ResultHandler(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void SetDisposeCallback(Action<ResultHandler> onDisposed); // 0x000000018CA51788-0x000000018CA517C8
			public void SetIgnoreSeq(bool ignoreSeq); // 0x000000018CA517C8-0x000000018CA51800
			public ResultHandler OnResponse(SCMessageID msgId, NetResponseHandler handler); // 0x0000000185D9A070-0x0000000185D9A430
			public void Dispose(); // 0x0000000185D997E0-0x0000000185D9A070
			private bool _CheckSessionIDValid(); // 0x0000000185D996F0-0x0000000185D99770
			private void _HandleMessage([IsReadOnly] in NetResponse msg); // 0x0000000185D99500-0x0000000185D996F0
		}
	
		public abstract class Sender // TypeDefIndex: 85649
		{
			// Constructors
			protected Sender(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public abstract ResultHandler Send(IExtensible msg);
			public abstract void OnNetShutDown();
			public ResultHandler SendAndDispose(IExtensible msg); // 0x00000001855EF7A0-0x00000001855EF8A0
			protected ResultHandler DoSend(IExtensible message); // 0x0000000185D98CC0-0x0000000185D98D60
			protected void DoListen(SCMessageID msgId, NetResponseHandler handler); // 0x000000018CA51800-0x000000018CA518B0
			protected void DoUnListen(SCMessageID msgId, NetResponseHandler handler); // 0x000000018CA518B0-0x000000018CA51960
		}
	
		// Constructors
		public NetBus(); // 0x00000001865E17B0-0x00000001865E1A30
		static NetBus(); // 0x00000001871775D0-0x0000000187177660
	
		// Methods
		internal static IExtensible CloneMessageForSendOwner(IExtensible msg); // 0x000000018CA4E774-0x000000018CA4E818
		internal static void DisposeSentMessage(IExtensible msg); // 0x000000018671D400-0x000000018671D4A0
		public bool IsBusBusy(); // 0x000000018CA4E8D4-0x000000018CA4E91C
		public void Setup(HGNetSession session); // 0x000000018CA4E9C4-0x000000018CA4EA04
		public void Send(IExtensible msg); // 0x000000018583F700-0x000000018583F760
		public void SendAndDispose(IExtensible msg); // 0x0000000185D385C0-0x0000000185D38720
		public void RegisterMessageHandler(int msgId, MessageHandleWrapper handler); // 0x000000018650E3E0-0x000000018650E460
		public void UnRegisterMessageHandler(int msgId); // 0x000000018CA4EA04-0x000000018CA4EA60
		public void HandleMessageTime(NetResponse response); // 0x000000018CA4E818-0x000000018CA4E8D4
		[IFixIgnore]
		public void HandleMessage(ref NetResponse response); // 0x00000001856AE120-0x00000001856AE610
		private bool _ValidateSession(); // 0x0000000185840CA0-0x0000000185840CF0
		public void OnNetClientShutDown(); // 0x000000018CA4E91C-0x000000018CA4E9C4
		private ResultHandler _SendWithResult(IExtensible msg); // 0x0000000185D98D60-0x0000000185D98E20
		private void _Listen(int msgId, NetResponseHandler handler); // 0x000000018CA4EB94-0x000000018CA4ECD0
		private void _UnListen(int msgId, NetResponseHandler handler); // 0x000000018CA4ECD0-0x000000018CA4EE08
		private object _ListenWithSeqNum(int msgId, NetResponseHandler callback); // 0x000000018CA4EA60-0x000000018CA4EB94
		private void _UnListenWithSeqNum(int msgId, object token); // 0x0000000185D9A430-0x0000000185D9A570
	}

	public struct NetResponse : IDisposable // TypeDefIndex: 85651
	{
		// Fields
		public static NetResponse EMPTY; // 0x00
		private object m_headMsg; // 0x00
		private bool m_hasCSHeadSnapshot; // 0x08
		private int m_msgId; // 0x0C
		private ulong m_upSeqId; // 0x10
		private ulong m_downSeqId; // 0x18
		public IExtensible msgBody; // 0x20
		public bool isPacked; // 0x28
		public long recvTimestamp; // 0x30
		public bool deserializeSucceeded; // 0x38
		public string decodeError; // 0x40
	
		// Properties
		public object headMsg { get; set; } // 0x00000001857898F0-0x0000000185789980 0x0000000186972940-0x00000001869729E0
		public Header logHead { get; set; } // 0x0000000185789860-0x00000001857898F0 0x00000001869728B0-0x0000000186972940
		public CSHead csHead { get; set; } // 0x000000018CA4EF40-0x000000018CA4EFC8 0x000000018CA4EFC8-0x000000018CA4F030
		public int msgId { get; } // 0x00000001856AE610-0x00000001856AE9B0 
		public ulong csSeqId { get; } // 0x00000001856AE9B0-0x00000001856AEC70 
		public ulong scSeqId { get; } // 0x00000001856AE0E0-0x00000001856AE120 
	
		// Constructors
		static NetResponse(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void SetCSHeadSnapshot(CSHead head); // 0x000000018571A720-0x000000018571A7E0
		public void DisposeHeadMessage(); // 0x0000000185E76BA0-0x0000000185E76C70
		public void DisposeOwnedMessages(); // 0x0000000185E769B0-0x0000000185E76BA0
		public void Dispose(); // 0x0000000185E76930-0x0000000185E769B0
		private void _CopyCSHeadSnapshot(CSHead head); // 0x000000018571A7E0-0x000000018571B950
		private CSHead _CreateCSHeadSnapshot(); // 0x000000018CA4EE8C-0x000000018CA4EF40
	}

	public abstract class MessageHandleWrapper // TypeDefIndex: 85652
	{
		// Constructors
		protected MessageHandleWrapper(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract void HandleMessage(IExtensible msg);
	}

	public class MessageHandleWrapper<T> : MessageHandleWrapper // TypeDefIndex: 85653
		where T : class, IExtensible, IProtoPooledMessage, new()
	{
		// Fields
		private readonly NetMessageHandle<T> m_handle;
		private readonly bool m_disposeAfterInvoke;
	
		// Constructors
		public MessageHandleWrapper(NetMessageHandle<T> handle);
		public MessageHandleWrapper(NetMessageHandle<T> handle, bool disposeAfterInvoke);
	
		// Methods
		public override void HandleMessage(IExtensible msg);
		private static T _CopyMessageForBusiness(IExtensible msg);
	}

	public class Special2BusSender : DisposableBusSender, INetBusResponseListener // TypeDefIndex: 85654
	{
		// Fields
		public Dictionary<ulong, double> sendedMsgWithTime; // 0x20
		public double minSendTime; // 0x28
		private float m_maxWaitTime; // 0x30
	
		// Properties
		public virtual bool isBusBusy { get; } // 0x00000001850892C0-0x0000000185089310 
	
		// Constructors
		public Special2BusSender(); // 0x0000000185C2B980-0x0000000185C2BA20
	
		// Methods
		public override NetBus.ResultHandler Send(IExtensible msg); // 0x0000000185D98AF0-0x0000000185D98BC0
		public void UpdateStartBlockTime(); // 0x000000018CA51B40-0x000000018CA51C90
		public override void OnNetShutDown(); // 0x000000018CA51A34-0x000000018CA51A8C
		public override void Dispose(); // 0x000000018CA519DC-0x000000018CA51A34
		private void _ClearSendTime(); // 0x000000018CA51C90-0x000000018CA51D1C
		public void UpdateMsgTime(NetResponse resp); // 0x000000018CA51A94-0x000000018CA51B40
		public NetBus.ResultHandler __iFixBaseProxy_Send(IExtensible P0); // 0x000000018CA4CECC-0x000000018CA4CED4
		public void __iFixBaseProxy_OnNetShutDown(); // 0x000000018CA51A8C-0x000000018CA51A94
		public void __iFixBaseProxy_Dispose(); // 0x000000018CA4CEC4-0x000000018CA4CECC
	}

	public class InteractiveBusSender : Special2BusSender // TypeDefIndex: 85655
	{
		// Fields
		private float m_maxWaitTime; // 0x38
	
		// Properties
		public override bool isBusBusy { get; } // 0x0000000185089270-0x00000001850892C0 
	
		// Constructors
		public InteractiveBusSender(); // 0x000000018783C4D4-0x000000018783C4E4
	
		// Methods
		public bool __iFixBaseProxy_get_isBusBusy(); // 0x000000018CA4E56C-0x000000018CA4E574
	}

	public class DisposableBusSender : NetBus.Sender, IDisposable // TypeDefIndex: 85656
	{
		// Fields
		private readonly HashSet<NetBus.ResultHandler> m_resultHandlers; // 0x10
		[CompilerGenerated]
		private bool _isDisposed_k__BackingField; // 0x18
	
		// Properties
		public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
	
		// Constructors
		public DisposableBusSender(); // 0x0000000185C2BA20-0x0000000185C2BAA0
	
		// Methods
		public override NetBus.ResultHandler Send(IExtensible msg); // 0x0000000185D98BC0-0x0000000185D98CC0
		public override void OnNetShutDown(); // 0x000000018CA4C980-0x000000018CA4C9B8
		public virtual void Dispose(); // 0x000000018CA4C92C-0x000000018CA4C980
		private void _Clear(); // 0x000000018CA4C9B8-0x000000018CA4CBB4
		private void _RemoveResultHandler(NetBus.ResultHandler resultHandler); // 0x0000000186BA1490-0x0000000186BA1510
	}

	public class NetworkMaskConfigHolder // TypeDefIndex: 85657
	{
		// Fields
		public Dictionary<CSMessageID, SCMessageID> msgs; // 0x10
	
		// Constructors
		public NetworkMaskConfigHolder(); // 0x00000001865E1B80-0x00000001865E1C00
	
		// Methods
		public void Init(); // 0x00000001865E1C00-0x00000001865E1D20
		private void _LoadJsonConfig(StringPathHash jsonHash); // 0x00000001865E1D20-0x00000001865E2570
		private void _LoadScriptableObjectConfig(); // 0x000000018CA50B74-0x000000018CA51150
		public void Dispose(); // 0x000000018CA50AF0-0x000000018CA50B74
	}

	public class UIBusSender : DisposableBusSender // TypeDefIndex: 85659
	{
		// Fields
		[CompilerGenerated]
		private NetworkMaskConfigHolder _config_k__BackingField; // 0x20
		private HashSet<int> m_maskKeys; // 0x28
	
		// Properties
		public NetworkMaskConfigHolder config { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 85658
		{
			// Fields
			public int key; // 0x10
			public UIBusSender __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Send_b__0([IsReadOnly] in NetResponse resp); // 0x0000000185D98110-0x0000000185D98190
			internal void _Send_b__1([IsReadOnly] in NetResponse resp); // 0x000000018CA52720-0x000000018CA5279C
			internal void _Send_b__2([IsReadOnly] in NetResponse resp); // 0x000000018CA5279C-0x000000018CA52818
		}
	
		// Constructors
		public UIBusSender(); // 0x00000001865E1AB0-0x00000001865E1B80
	
		// Methods
		public override void Dispose(); // 0x000000018CA52B30-0x000000018CA52D28
		public override NetBus.ResultHandler Send(IExtensible msg); // 0x0000000185D98E60-0x0000000185D99500
		public override void OnNetShutDown(); // 0x000000018CA52D28-0x000000018CA52F04
		public void __iFixBaseProxy_Dispose(); // 0x000000018CA4CEC4-0x000000018CA4CECC
		public NetBus.ResultHandler __iFixBaseProxy_Send(IExtensible P0); // 0x000000018CA4CECC-0x000000018CA4CED4
		public void __iFixBaseProxy_OnNetShutDown(); // 0x000000018CA51A8C-0x000000018CA51A94
	}

	public class TeleportMaskSender : DisposableBusSender // TypeDefIndex: 85661
	{
		// Fields
		private HashSet<int> m_maskKeys; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 85660
		{
			// Fields
			public int key; // 0x10
			public TeleportMaskSender __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Send_b__0([IsReadOnly] in NetResponse resp); // 0x000000018CA525AC-0x000000018CA52628
			internal void _Send_b__1([IsReadOnly] in NetResponse resp); // 0x0000000185D97860-0x0000000185D978E0
			internal void _Send_b__2([IsReadOnly] in NetResponse resp); // 0x000000018CA52628-0x000000018CA526A4
			internal void _Send_b__3([IsReadOnly] in NetResponse resp); // 0x000000018CA526A4-0x000000018CA52720
		}
	
		// Constructors
		public TeleportMaskSender(); // 0x00000001865E1A30-0x00000001865E1AB0
	
		// Methods
		public override void Dispose(); // 0x000000018CA5218C-0x000000018CA52368
		public NetBus.ResultHandler Send(IExtensible msg, float delay); // 0x0000000185D97DF0-0x0000000185D98110
		public NetBus.ResultHandler SendAndDispose(IExtensible msg, float delay); // 0x0000000185D388F0-0x0000000185D389F0
		public override void OnNetShutDown(); // 0x000000018CA52368-0x000000018CA52544
		public void __iFixBaseProxy_Dispose(); // 0x000000018CA4CEC4-0x000000018CA4CECC
		public void __iFixBaseProxy_OnNetShutDown(); // 0x000000018CA51A8C-0x000000018CA51A94
	}

	public class FrequencyControlBusSender : DisposableBusSender // TypeDefIndex: 85663
	{
		// Fields
		private readonly Dictionary<CSMessageID, Queue<double>> m_lastSendTime; // 0x20
		private List<IExtensible> m_waitingSendMsgs; // 0x28
		private List<Action<int>> m_onError; // 0x30
		private TickFunction m_loopId; // 0x38
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 85662
		{
			// Fields
			public Action<int> onError; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DoSendNow_b__0([IsReadOnly] in NetResponse errorMsg); // 0x000000018CA52544-0x000000018CA525AC
		}
	
		// Constructors
		public FrequencyControlBusSender(); // 0x0000000185C2CED0-0x0000000185C2D0C0
	
		// Methods
		private void _TrySendWaitingMsg(float deltaTime); // 0x00000001870BE630-0x00000001870BE700
		[IDTag(1)]
		public override NetBus.ResultHandler Send(IExtensible msg); // 0x000000018CA4CE60-0x000000018CA4CEC4
		[IDTag(0)]
		public NetBus.ResultHandler Send(IExtensible msg, bool needAddToWaitingList, Action<int> onError = null, Action onWait = null); // 0x0000000185D97990-0x0000000185D979D0
		public NetBus.ResultHandler SendAndDispose(IExtensible msg, bool needAddToWaitingList, Action<int> onError = null, Action onWait = null); // 0x000000018CA4CD1C-0x000000018CA4CE60
		private NetBus.ResultHandler _Send(IExtensible sendMsg, bool needAddToWaitingList, Action<int> onError, Action onWait); // 0x0000000185D979D0-0x0000000185D97CB0
		private NetBus.ResultHandler _DoSendNow(IExtensible msg, CSMessageID msgId, Action<int> onError); // 0x0000000185D97CB0-0x0000000185D97DF0
		public override void Dispose(); // 0x000000018CA4CC64-0x000000018CA4CD1C
		private void _ClearWaitingSendMsgs(); // 0x000000018CA4CED4-0x000000018CA4CFFC
		public NetBus.ResultHandler __iFixBaseProxy_Send(IExtensible P0); // 0x000000018CA4CECC-0x000000018CA4CED4
		public void __iFixBaseProxy_Dispose(); // 0x000000018CA4CEC4-0x000000018CA4CECC
	}

	[Serializable]
	public class ServerDesc // TypeDefIndex: 85664
	{
		// Fields
		public string name; // 0x10
		public string addr; // 0x18
		public int port; // 0x20
	
		// Constructors
		public ServerDesc(); // 0x0000000186539360-0x00000001865393A0
	}

	[Serializable]
	public class ServerList // TypeDefIndex: 85665
	{
		// Fields
		public List<ServerDesc> servers; // 0x10
	
		// Constructors
		public ServerList(); // 0x0000000186F9EF10-0x0000000186F9EF90
	}

	public class ServerConfig // TypeDefIndex: 85666
	{
		// Fields
		public string serverName; // 0x10
		public string uid; // 0x18
		public bool checkDev; // 0x20
	
		// Constructors
		public ServerConfig(); // 0x00000001871EE5B0-0x00000001871EE610
	
		// Methods
		public bool IsSame(ServerConfig other); // 0x000000018CA51960-0x000000018CA519DC
	}

	public class HostData // TypeDefIndex: 85667
	{
		// Fields
		public string host; // 0x10
		public int port; // 0x18
		public double delay; // 0x20
	
		// Constructors
		public HostData(); // 0x0000000186120780-0x00000001861207D0
	}

	public class NetConfig // TypeDefIndex: 85668
	{
		// Fields
		public List<HostData> hosts; // 0x10
	
		// Constructors
		public NetConfig(List<HostData> hosts); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public static class NetConsts // TypeDefIndex: 85669
	{
		// Fields
		public static readonly string NETMASK_CONFIG_PATH; // 0x00
		public static readonly string NETMASK_CONFIG_JSON_PATH; // 0x08
		public static readonly string NETMASK_PREFAB_PATH; // 0x10
	
		// Constructors
		static NetConsts(); // 0x00000001870D0E30-0x00000001870D0F10
	}

	public interface INetworkSystem : ILuaCallCSharp // TypeDefIndex: 85670
	{
		// Methods
		void OnReConnect();
		void SendMsg(IExtensible msg, Action<int> onError);
	}

	[Serializable]
	public class NetMaskConfig // TypeDefIndex: 85672
	{
		// Fields
		public Dictionary<string, Config> configs; // 0x10
	
		// Nested types
		[Serializable]
		public class Config // TypeDefIndex: 85671
		{
			// Fields
			public Dictionary<int, SCMessageID> messages; // 0x10
	
			// Constructors
			public Config(); // 0x0000000186E48570-0x0000000186E485F0
		}
	
		// Constructors
		public NetMaskConfig(); // 0x00000001871C3070-0x00000001871C30F0
	}

	public struct TcpIOProfilerSnapshot // TypeDefIndex: 85673
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

	public struct NetSessionProfilerSnapshot // TypeDefIndex: 85674
	{
		// Fields
		public long logicalSendPacketCount; // 0x00
		public long logicalSendPacketCountPerSecond; // 0x08
		public long actualSendPacketCount; // 0x10
		public long actualSendPacketCountPerSecond; // 0x18
		public long receivePacketCount; // 0x20
		public long receivePacketCountPerSecond; // 0x28
	}

	public struct NetDevProfilerSnapshot // TypeDefIndex: 85675
	{
		// Fields
		public TcpIOProfilerSnapshot tcpIO; // 0x00
		public NetSessionProfilerSnapshot session; // 0x40
	}

	internal static class NetProtoCodec // TypeDefIndex: 85676
	{
		// Methods
		public static IExtensible MergeSC(int msgId, IExtensible msg, byte[] buffer, int offset, int length); // 0x0000000185E5A450-0x0000000185E5A540
		public static int Write<T>(T msg, byte[] buffer, int offset)
			where T : class, IExtensible;
		public static bool TryWriteCS(System.Type messageType, IExtensible msg, byte[] buffer, int offset, out int endOffset); // 0x0000000185725330-0x00000001857253E0
	}

	public static class NetUtil // TypeDefIndex: 85685
	{
		// Fields
		private static bool s_isRegistedAllMessages; // 0x00
		private const long DEFAULT_PROTO_AOT_WARMUP_FRAME_BUDGET_MS = 20; // Metadata: 0x02645086
		private static long s_protoAotWarmupFrameBudgetMs; // 0x08
		private static bool s_protoAotWarmupStarted; // 0x10
		private static bool s_enableProtoMainThreadPrewarm; // 0x11
		private static bool s_protoClassWarmupFinished; // 0x12
		private static WaitForAsyncTask<long> s_protoAotWarmupTask; // 0x18
		private static Exception s_protoAotWarmupException; // 0x20
		private static long s_protoAotWarmupElapsedMilliseconds; // 0x28
		private static bool s_hasLoggedProtoAotWarmup; // 0x30
		private static bool s_hasPrewarmedFactoryProtoPools; // 0x31
		private static readonly object FACTORY_HS_STATS_LOCK; // 0x38
		private static FFactoryHsPoolStats s_factoryHsPoolStats; // 0x40
		public static readonly int MAX_RECEIVE_PACK_BODY_SIZE; // 0x80
		public static readonly int MAX_MERGE_PACK_BODY_SIZE; // 0x84
		public static readonly int MAX_SEND_PACK_BODY_SIZE; // 0x88
		private static Dictionary<int, System.Type> s_sc_id2MessageType; // 0x90
		private static Dictionary<System.Type, int> s_sc_messageType2Id; // 0x98
		private static Dictionary<System.Type, int> s_cs_messageType2Id; // 0xA0
		private static byte[] s_decompressedBuffer; // 0xA8
		[ThreadStatic]
		private static CSHead s_recvHead; // 0x80000000
		[ThreadStatic]
		private static CSHead s_sendHead; // 0x80000008
	
		// Nested types
		public struct FFactoryHsPoolStats // TypeDefIndex: 85677
		{
			// Fields
			public long packets; // 0x00
			public long decodedBytes; // 0x08
			public long ctItems; // 0x10
			public long ceItems; // 0x18
			public int maxCtPerPacket; // 0x20
			public int maxCePerPacket; // 0x24
			public int maxScalarListCount; // 0x28
			public long firstTimestamp; // 0x30
			public long lastTimestamp; // 0x38
		}
	
		[CompilerGenerated]
		private sealed class __PrewarmProtoClassesOnMainThread_d__32 : IEnumerator<object> // TypeDefIndex: 85678
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private Stopwatch _stopwatch_5__2; // 0x20
			private IEnumerator<object> _steps_5__3; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __PrewarmProtoClassesOnMainThread_d__32(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000184DA3570-0x0000000184DA3680
			private bool MoveNext(); // 0x0000000184DA1D70-0x0000000184DA3520
			private void __m__Finally1(); // 0x0000000184DA3680-0x0000000184DA41A0
			private void __m__Finally2(); // 0x0000000184DA41A0-0x0000000184DA54F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DA3520-0x0000000184DA3570
		}
	
		[CompilerGenerated]
		private sealed class __GetProtoClassWarmupSteps_d__34 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 85679
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private IEnumerator<object> _poolSteps_5__2; // 0x28
			private IEnumerator<object> __7__wrap2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GetProtoClassWarmupSteps_d__34(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000184D991A0-0x0000000184D992C0
			private bool MoveNext(); // 0x0000000184D97A60-0x0000000184D98E00
			private void __m__Finally1(); // 0x0000000184D992C0-0x0000000184D995D0
			private void __m__Finally2(); // 0x0000000184D995D0-0x0000000184D998E0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184D99150-0x0000000184D991A0
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator(); // 0x0000000184D98E00-0x0000000184D99140
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000184D99140-0x0000000184D99150
		}
	
		[CompilerGenerated]
		private sealed class __PrewarmFactoryProtoPools_d__35 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 85680
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private bool classesOnly; // 0x24
			public bool __3__classesOnly; // 0x25
			private IEnumerator<object> __7__wrap1; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __PrewarmFactoryProtoPools_d__35(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000184DA19E0-0x0000000184DA1A60
			private bool MoveNext(); // 0x0000000184D9C730-0x0000000184DA1640
			private void __m__Finally1(); // 0x0000000184DA1A60-0x0000000184DA1D70
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184DA1990-0x0000000184DA19E0
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator(); // 0x0000000184DA1640-0x0000000184DA1980
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000184DA1980-0x0000000184DA1990
		}
	
		[CompilerGenerated]
		private sealed class __PrewarmFactoryContent_d__36 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 85681
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private bool classesOnly; // 0x24
			public bool __3__classesOnly; // 0x25
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __PrewarmFactoryContent_d__36(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184D998E0-0x0000000184D9C390
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184D9C6E0-0x0000000184D9C730
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator(); // 0x0000000184D9C390-0x0000000184D9C6D0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000184D9C6D0-0x0000000184D9C6E0
		}
	
		[CompilerGenerated]
		private sealed class _WaitForProtoAotWarmup_d__39 : IEnumerator<object> // TypeDefIndex: 85682
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForProtoAotWarmup_d__39(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184D97290-0x0000000184D97A10
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184D97A10-0x0000000184D97A60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 85683
		{
			// Fields
			public object target; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _AutoRegisterMessageHandlers_b__0(System.Type msgType, MethodInfo methodInfo, bool disposeAfterInvoke); // 0x0000000184D954A0-0x0000000184D97290
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85684
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<System.Type, MethodInfo, bool> __9__53_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CA52818-0x000000018CA5287C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _AutoUnRegisterMessageHandlers_b__53_0(System.Type msgType, MethodInfo methodInfo, bool _); // 0x0000000184D94E50-0x0000000184D954A0
		}
	
		// Constructors
		static NetUtil(); // 0x0000000186B3F3A0-0x0000000186B405F0
	
		// Methods
		public static FFactoryHsPoolStats GetFactoryHsPoolStats(); // 0x0000000184D8E8B0-0x0000000184D8EE60
		public static void ResetFactoryHsPoolStats(); // 0x0000000184D8EE60-0x0000000184D8F320
		private static void _RecordFactoryHsPoolStats(SC_FACTORY_HS msg, int decodedBytes); // 0x0000000184D923D0-0x0000000184D93920
		public static void RegisterSCMessage(int msgId, System.Type msgType); // 0x00000001861F23B0-0x00000001861F24F0
		public static void RegisterCSMessage(int msgId, System.Type msgType); // 0x00000001861F0CC0-0x00000001861F0DA0
		public static int GetSCMsgIdByType(System.Type msgType); // 0x00000001854C1230-0x00000001854C12C0
		public static System.Type GetSCMsgTypeById(int msgId); // 0x000000018CA502C4-0x000000018CA50388
		public static int GetCSMsgIdByType(System.Type msgType); // 0x00000001854BF640-0x00000001854BF6D0
		public static void StartProtoAotWarmupInBackground(); // 0x0000000184D8F320-0x0000000184D90CE0
		[IteratorStateMachine(typeof(__PrewarmProtoClassesOnMainThread_d__32))]
		private static IEnumerator _PrewarmProtoClassesOnMainThread(); // 0x0000000184D920A0-0x0000000184D923D0
		private static long _WarmupProtoAotInBackground(); // 0x0000000184D93920-0x0000000184D94E50
		[IteratorStateMachine(typeof(__GetProtoClassWarmupSteps_d__34))]
		private static IEnumerable<object> _GetProtoClassWarmupSteps(); // 0x0000000184D91690-0x0000000184D919E0
		[IteratorStateMachine(typeof(__PrewarmFactoryProtoPools_d__35))]
		private static IEnumerable<object> _PrewarmFactoryProtoPools(bool classesOnly); // 0x0000000184D91D40-0x0000000184D920A0
		[IteratorStateMachine(typeof(__PrewarmFactoryContent_d__36))]
		private static IEnumerable<object> _PrewarmFactoryContent(bool classesOnly); // 0x0000000184D919E0-0x0000000184D91D40
		private static void _PrewarmFactorySerialization<T>(T source)
			where T : class, IProtoPooledMessage, new();
		private static void _PrewarmFactoryRepeated<T>(int count, int maxCapacity, bool classesOnly);
		[IteratorStateMachine(typeof(_WaitForProtoAotWarmup_d__39))]
		public static IEnumerator WaitForProtoAotWarmup(); // 0x0000000184D91360-0x0000000184D91690
		public static bool TryGetProtoAotWarmupException(out Exception exception); // 0x0000000184D90CE0-0x0000000184D91360
		public static void FastRegisterMessage(); // 0x00000001861F0DA0-0x00000001861F23B0
		public static bool GetNetMessageFromDataBytes(Span<byte> headBytes, byte[] bodyBuffer, int offset, int bodyLen, byte[] packedbuffer, out NetResponse response); // 0x000000018571B950-0x000000018571C870
		private static void _LogDeserializeError(System.Type msgType, CSHead head, int bodyLen, int payloadLen, Exception e); // 0x000000018CA5080C-0x000000018CA50AF0
		private static string _BuildExceptionSummary(Exception e); // 0x000000018CA50614-0x000000018CA50774
		private static void _DisposeMessage(IExtensible msg); // 0x000000018CA50774-0x000000018CA5080C
		public static IExtensible DeserializeBodyMessage(int msgId, IExtensible msg, byte[] buffer, int offset, int length); // 0x000000018CA4F174-0x000000018CA502C4
		public static int SerializeHeadMessage(IExtensible msg, ulong upSeqid, int bodyLen, int crc32, byte[] buffer, int offset = 0 /* Metadata: 0x02645084 */); // 0x0000000185724AA0-0x0000000185724D20
		public static int SerializeBodyMessage(IExtensible msg, byte[] buffer, out int crc32, int offset = 0 /* Metadata: 0x02645085 */); // 0x000000018CA50388-0x000000018CA50614
		private static CSHead _GetRecvHead(); // 0x000000018571C870-0x000000018571C9E0
		private static CSHead _GetSendHead(); // 0x0000000185724D20-0x0000000185725330
		private static void _ResetHead(CSHead head); // 0x000000018571C9E0-0x000000018571CA70
		public static void AutoRegisterMessageHandlers(object target); // 0x0000000185AC8F30-0x0000000185AC9030
		public static void AutoUnRegisterMessageHandlers(object target); // 0x000000018CA4F030-0x000000018CA4F174
		private static void _ForeachMessageHandlers(object target, Action<System.Type, MethodInfo, bool> doFunc); // 0x00000001858CB7A0-0x00000001858CBB30
	}

	public static class NetworkFrequencyConfig // TypeDefIndex: 85687
	{
		// Fields
		public static SerializeFieldDictionary<int, NetworkFrequency> msgs; // 0x00
	
		// Nested types
		public class NetworkFrequency // TypeDefIndex: 85686
		{
			// Fields
			public System.Type type; // 0x10
			public float second; // 0x18
			public int maxCount; // 0x1C
	
			// Constructors
			public NetworkFrequency(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		static NetworkFrequencyConfig(); // 0x0000000186888DD0-0x000000018688AC20
	}

	public class NetworkMask : Singleton<NetworkMask> // TypeDefIndex: 85689
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
		private const string DECO_NAME = "Deco"; // Metadata: 0x0264509A
		private List<MaskInfo> m_masks; // 0x58
	
		// Properties
		public bool showingMask { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
		public bool showingDeco { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226ECC0-0x000000018226ECD0 0x000000018226ECD0-0x000000018226ECE0
	
		// Nested types
		public class MaskInfo // TypeDefIndex: 85688
		{
			// Fields
			public int key; // 0x10
			public string name; // 0x18
			public float startTime; // 0x20
			public float delayTime; // 0x24
			public float timeoutTime; // 0x28
	
			// Properties
			public float endTime { get; } // 0x0000000185D98550-0x0000000185D98580 
			public float showDecoTime { get; } // 0x0000000185D98520-0x0000000185D98550 
	
			// Constructors
			public MaskInfo(); // 0x0000000187253870-0x0000000187253880
		}
	
		// Constructors
		private NetworkMask(); // 0x0000000186C2FF70-0x0000000186C30010
	
		// Methods
		protected void OnInit(); // 0x0000000186C30010-0x0000000186C30120
		protected void OnUnInit(); // 0x000000018CA51218-0x000000018CA512B4
		public void Release(); // 0x000000018CA512B4-0x000000018CA513CC
		private void _OnSwitchLanguage(); // 0x000000018CA514EC-0x000000018CA515A0
		private void _CreateMaskObject(); // 0x0000000186C30240-0x0000000186C304E0
		private void _CreateTickFunction(); // 0x0000000186C30120-0x0000000186C30240
		private void _ClearTickFunction(); // 0x000000018CA51488-0x000000018CA514EC
		public void PreTick(float deltaTime); // 0x0000000185D983A0-0x0000000185D983D0
		private int _GetKey(); // 0x0000000185D982A0-0x0000000185D982D0
		[IDTag(1)]
		public int AddMask(CSMessageID msgId, float timeoutTime = 600f /* Metadata: 0x0264508E */); // 0x0000000185D98580-0x0000000185D98630
		[IDTag(0)]
		public int AddMask(string name, float timeoutTime = 600f /* Metadata: 0x02645092 */, float delayTime = 0.5f /* Metadata: 0x02645096 */); // 0x0000000185D98190-0x0000000185D982A0
		public void RemoveMask(int key); // 0x0000000185D982D0-0x0000000185D983A0
		public void SetIsNetReconnecting(bool isReconnecting); // 0x0000000187253880-0x0000000187253890
		private void _UpdateMaskState(); // 0x0000000185D983D0-0x0000000185D98520
		public void ListenOnNetMaskChanged(Action<bool> action); // 0x0000000186EC4220-0x0000000186EC42A0
		public void UnListenOnNetMaskChanged(Action<bool> action); // 0x000000018CA513CC-0x000000018CA51488
	}

	public class NetworkMaskConfig : ScriptableObject // TypeDefIndex: 85691
	{
		// Fields
		[SerializeField]
		public SerializeFieldDictionary<CSMessageID, SCMessageID> msgs; // 0x18
		[SerializeField]
		public List<Config> configs; // 0x20
	
		// Nested types
		[Serializable]
		public class Config // TypeDefIndex: 85690
		{
			// Fields
			[SerializeField]
			public string key; // 0x10
			[SerializeField]
			public SerializeFieldDictionaryPaired<CSMessageID, SCMessageID> messages; // 0x18
	
			// Constructors
			public Config(); // 0x000000018CA4C8B4-0x000000018CA4C92C
		}
	
		// Constructors
		public NetworkMaskConfig(); // 0x000000018CA51150-0x000000018CA51218
	}

	public static class NetworkUrls // TypeDefIndex: 85693
	{
		// Fields
		public const string URL_GET_SPLIT = "/"; // Metadata: 0x0264509F
	
		// Nested types
		private enum EUrlType // TypeDefIndex: 85692
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
		public static string RemoteConfigUrl(); // 0x0000000185ED6660-0x0000000185ED66D0
		public static string ResourceRootUrlDev(string version); // 0x000000018CA516D8-0x000000018CA51788
		public static string ServerListUrl(); // 0x0000000186D189E0-0x0000000186D18A10
		public static string AgeTipsUrl(); // 0x000000018CA515A0-0x000000018CA5163C
		public static string GovUrl(); // 0x000000018CA5163C-0x000000018CA516D8
		public static string LauncherUrl(); // 0x00000001867A1240-0x00000001867A12D0
		private static string _SelectUrl(string urlInConfig, EUrlType urlType); // 0x0000000186F9EAA0-0x0000000186F9EB40
		private static string _GetUrlFromLocal(EUrlType type); // 0x0000000186D18A10-0x0000000186D18AD0
	}

	public class TcpIO : INetIO // TypeDefIndex: 85695
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
		public const int SEND_HEAD_BUFFER_LENGTH = 256; // Metadata: 0x026450A8
		public static int s_MAX_SEND_SIZE; // 0x00
		private static readonly System.Random s_random; // 0x08
	
		// Nested types
		private struct WeakNetDelayConfig // TypeDefIndex: 85694
		{
			// Fields
			public bool enabled; // 0x00
			public int minDelayMs; // 0x04
			public int maxDelayMs; // 0x08
			public int maxTriggerCountPerSecond; // 0x0C
		}
	
		// Constructors
		public TcpIO(); // 0x00000001863D1B00-0x00000001863D1BB0
		static TcpIO(); // 0x0000000185EBE1F0-0x0000000185EBE290
	
		// Methods
		public void Connect(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize); // 0x0000000185ADDD10-0x0000000185ADDEC0
		public System.Threading.Tasks.Task ConnectAsync(string serverIp, int serverPort, int sendTimeout, int receiveBufferSize, int sendBufferSize); // 0x00000001863D2080-0x00000001863D2280
		public bool IsAuthed(); // 0x000000018CA51EE0-0x000000018CA51F24
		public void MarkAuthed(); // 0x0000000185789980-0x00000001857899B0
		public void EnableCryptStream(byte[] key, byte[] iv); // 0x0000000186B29880-0x0000000186B29AA0
		public EndPoint GetEndPoint(); // 0x000000018CA51D1C-0x000000018CA51D6C
		public void Close(); // 0x0000000185B69DD0-0x0000000185B69ED0
		public void TestCloseNetIO(bool bIsTestReconnectFailed); // 0x000000018CA51F24-0x000000018CA51F88
		public void TestDropNetIO(bool bIsTestDropSC, bool bIsTestDropCS); // 0x000000018CA51F88-0x000000018CA51FD0
		public void SetWeakNetPreset(ENetWeakNetPreset preset); // 0x00000001863D1C10-0x00000001863D1C60
		public void SetWeakNetCustom(int readMinDelayMs, int readMaxDelayMs, int readMaxTriggerCountPerSecond, int writeMinDelayMs, int writeMaxDelayMs, int writeMaxTriggerCountPerSecond); // 0x00000001863D1C60-0x00000001863D1D70
		public bool IsConnected(); // 0x000000018578AA40-0x000000018578AA90
		public TcpIOProfilerSnapshot GetProfilerSnapshot(); // 0x000000018CA51D6C-0x000000018CA51DE0
		public void WriteData(byte[] data, int offset, int len); // 0x0000000185723E80-0x0000000185724130
		public void WriteCryptoData(byte[] data, int offset, int len); // 0x0000000186245780-0x0000000186245820
		public byte[] GetSendHeadBuffer(); // 0x000000018CA51EA0-0x000000018CA51EE0
		public byte[] GetSendBuffer(); // 0x000000018CA51E60-0x000000018CA51EA0
		public byte[] GetReceiveBuffer(); // 0x000000018CA51E20-0x000000018CA51E60
		public void ClearReceiveBufferOffset(); // 0x000000018571CAE0-0x000000018571CB10
		public int GetReceiveBufferOffset(); // 0x000000018CA51DE0-0x000000018CA51E20
		public void SkipReceiveBufferOffset(int len); // 0x000000018571CA70-0x000000018571CAE0
		public int ReadData(byte[] buffer, int offset, int len); // 0x000000018571F530-0x000000018571F6D0
		public int ReadCryptoData(byte[] buffer, int offset, int len); // 0x000000018571F180-0x000000018571F530
		public int Available(); // 0x000000018571E440-0x000000018571E4F0
		public void Dispose(); // 0x0000000185B69D70-0x0000000185B69DD0
		private static void _ResetWeakNetWindow(ref long windowStartMs, ref int triggerCount); // 0x00000001863D1E30-0x00000001863D1EC0
		private static WeakNetDelayConfig _CreateWeakNetDelayConfig(int minDelayMs, int maxDelayMs, int maxTriggerCountPerSecond); // 0x00000001863D1D70-0x00000001863D1E30
		private static int _NextDelayMs(WeakNetDelayConfig config); // 0x000000018CA51FD0-0x000000018CA5218C
		private static void _ApplyWeakNetDelay(object delayLock, WeakNetDelayConfig config, ref long windowStartMs, ref int triggerCount); // 0x000000018571F780-0x000000018571FBE0
		~TcpIO(); // 0x0000000185B69CF0-0x0000000185B69D70
	}

	public static class HttpSender // TypeDefIndex: 85714
	{
		// Fields
		public const string CONTENT_TYPE_JSON = "application/json"; // Metadata: 0x026450AA
		public const string CONTENT_ENCODING_GZIP = "gzip"; // Metadata: 0x026450BB
		public const int ERROR_CODE_TIMEOUT = 10000; // Metadata: 0x026450C0
		public const int ERROR_CODE_DNS_FAILED = 11000; // Metadata: 0x026450C4
		public const int ERROR_CODE_DESERIALIZE = 20000; // Metadata: 0x026450C8
		public const float TIMEOUT_DEFAULT = 20f; // Metadata: 0x026450CC
		private const int OPT_GET = 1; // Metadata: 0x026450D0
		private const int OPT_POST = 2; // Metadata: 0x026450D1
	
		// Nested types
		public enum ErrorType // TypeDefIndex: 85696
		{
			NONE = 0,
			TIMEOUT = 1,
			DNS_FAILED = 2,
			CANCELED = 3,
			INTERNAL = 4
		}
	
		public class Cancellation // TypeDefIndex: 85697
		{
			// Fields
			private bool m_isCancelled; // 0x10
			[CompilerGenerated]
			private Action OnCancelInvoked; // 0x18
	
			// Events
			public event Action OnCancelInvoked {
				add; // 0x000000018CA4C78C-0x000000018CA4C820
				remove; // 0x000000018CA4C820-0x000000018CA4C8B4
			}
	
			// Constructors
			public Cancellation(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Cancel(); // 0x000000018CA4C6F0-0x000000018CA4C744
			public bool IsCanceled(); // 0x000000018CA4C744-0x000000018CA4C78C
		}
	
		public struct FGetOptions // TypeDefIndex: 85698
		{
			// Fields
			public static readonly FGetOptions DEFAULT; // 0x00
			public Dictionary<string, string> headers; // 0x00
			public string contentType; // 0x08
			public bool headOnly; // 0x10
			public Cancellation cancellation; // 0x18
	
			// Constructors
			static FGetOptions(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public struct FPostOptions // TypeDefIndex: 85699
		{
			// Fields
			public static readonly FPostOptions DEFAULT; // 0x00
			public Dictionary<string, string> headers; // 0x00
			public string textBody; // 0x08
			public string contentType; // 0x10
			public Cancellation cancellation; // 0x18
	
			// Constructors
			static FPostOptions(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private struct FSendFunc // TypeDefIndex: 85700
		{
			// Fields
			public string url; // 0x00
			public int opt; // 0x08
			public FGetOptions optionsGET; // 0x10
			public FPostOptions optionsPOST; // 0x30
			public bool editorOnly; // 0x50
	
			// Methods
			public UnityWebRequest Invoke(); // 0x00000001863A02F0-0x00000001863A0370
			public Cancellation GetCancellation(); // 0x00000001863A02B0-0x00000001863A02F0
			public string GetOptMethod(); // 0x000000018CA4CBB4-0x000000018CA4CC64
		}
	
		public class Result // TypeDefIndex: 85701
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
			public Result(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class TypedResult : Result // TypeDefIndex: 85702
		{
			// Fields
			[CompilerGenerated]
			private System.Type _respType_k__BackingField; // 0x48
			public object respObject; // 0x50
			public bool isDeserializeFailed; // 0x58
	
			// Properties
			public System.Type respType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
			// Constructors
			public TypedResult(System.Type respType); // 0x0000000185B68F50-0x0000000185B68F60
		}
	
		public class Result<TResp> : TypedResult // TypeDefIndex: 85703
			where TResp : class
		{
			// Constructors
			public Result();
	
			// Methods
			public TResp GetRespObject();
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendGet_d__16 : IEnumerator<object> // TypeDefIndex: 85704
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string url; // 0x20
			public FGetOptions options; // 0x28
			public Misc.ObjectRef resultRef; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendGet_d__16(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186A4A5F0-0x0000000186A4A670
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CA5287C-0x000000018CA528C8
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendGet_d__17<TResp> : IEnumerator<object> // TypeDefIndex: 85705
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
		private sealed class _YieldSendGet_d__18 : IEnumerator<object> // TypeDefIndex: 85706
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FGetOptions options; // 0x20
			public string url; // 0x40
			public Misc.ObjectRef resultRef; // 0x48
			public System.Type respType; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendGet_d__18(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186AF7390-0x0000000186AF7480
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CA528C8-0x000000018CA52914
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendPost_d__19 : IEnumerator<object> // TypeDefIndex: 85707
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string url; // 0x20
			public FPostOptions options; // 0x28
			public Misc.ObjectRef resultRef; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendPost_d__19(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CA52914-0x000000018CA52988
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CA52988-0x000000018CA529D4
		}
	
		[CompilerGenerated]
		private sealed class _YieldSendPost_d__20<TResp> : IEnumerator<object> // TypeDefIndex: 85708
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
		private sealed class _YieldSendPost_d__21 : IEnumerator<object> // TypeDefIndex: 85709
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public FPostOptions options; // 0x20
			public string url; // 0x40
			public Misc.ObjectRef resultRef; // 0x48
			public System.Type respType; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _YieldSendPost_d__21(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186AF72A0-0x0000000186AF7390
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CA529D4-0x000000018CA52A20
		}
	
		[CompilerGenerated]
		private sealed class __YieldSendHttpRequest_d__28 : IEnumerator<object> // TypeDefIndex: 85710
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __YieldSendHttpRequest_d__28(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018CA52A6C-0x000000018CA52AE4
			private bool MoveNext(); // 0x000000018639FB30-0x00000001863A0240
			private void __m__Finally1(); // 0x00000001863A0370-0x00000001863A03D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CA52A20-0x000000018CA52A6C
		}
	
		[CompilerGenerated]
		private sealed class __YieldSendHttpRequest_d__29 : IEnumerator<object> // TypeDefIndex: 85711
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Misc.ObjectRef resultRef; // 0x20
			public System.Type respType; // 0x28
			public FSendFunc sendFunc; // 0x30
			private Result _result_5__2; // 0x88
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __YieldSendHttpRequest_d__29(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000185B68C10-0x0000000185B68DE0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CA52AE4-0x000000018CA52B30
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 85712
		{
			// Fields
			public Result result; // 0x10
	
			// Constructors
			public __c__DisplayClass30_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Result __WaitForSendHttpRequest_b__0(); // 0x0000000185B68F60-0x0000000185B68F80
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0<TResp> // TypeDefIndex: 85713
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
		public static IEnumerator YieldSendGet(string url, FGetOptions options, Misc.ObjectRef resultRef); // 0x00000001858D9010-0x00000001858D90E0
		[IteratorStateMachine(typeof(_YieldSendGet_d__17<TResp>))]
		public static IEnumerator YieldSendGet<TResp>(string url, FGetOptions options, Misc.ObjectRef resultRef)
			where TResp : class;
		[IDTag(0)]
		[IteratorStateMachine(typeof(_YieldSendGet_d__18))]
		public static IEnumerator YieldSendGet(string url, FGetOptions options, System.Type respType, Misc.ObjectRef resultRef); // 0x0000000186A4A670-0x0000000186A4A750
		[IDTag(1)]
		[IteratorStateMachine(typeof(_YieldSendPost_d__19))]
		public static IEnumerator YieldSendPost(string url, FPostOptions options, Misc.ObjectRef resultRef); // 0x000000018CA4E3FC-0x000000018CA4E4F0
		[IteratorStateMachine(typeof(_YieldSendPost_d__20<TResp>))]
		public static IEnumerator YieldSendPost<TResp>(string url, FPostOptions options, Misc.ObjectRef resultRef)
			where TResp : class;
		[IDTag(0)]
		[IteratorStateMachine(typeof(_YieldSendPost_d__21))]
		public static IEnumerator YieldSendPost(string url, FPostOptions options, System.Type respType, Misc.ObjectRef resultRef); // 0x0000000186E62C00-0x0000000186E62CD0
		public static WaitForAsyncTask<Result> WaitForSendPost(string url, FPostOptions options); // 0x0000000185B673A0-0x0000000185B67460
		[IDTag(1)]
		public static WaitForAsyncTask<Result> WaitForSendGet(string url); // 0x000000018CA4E264-0x000000018CA4E308
		[IDTag(0)]
		public static WaitForAsyncTask<Result> WaitForSendGet(string url, FGetOptions options); // 0x000000018CA4E308-0x000000018CA4E3FC
		public static WaitForAsyncTask<Result<TResp>> WaitForSendPost<TResp>(string url, FPostOptions options)
			where TResp : class;
		public static WaitForAsyncTask<Result<TResp>> WaitForSendGet<TResp>(string url, FGetOptions options)
			where TResp : class;
		public static int GetGeneralErrorCode(Result result, out bool hasError); // 0x00000001858D8CA0-0x00000001858D8D70
		[IDTag(0)]
		[IteratorStateMachine(typeof(__YieldSendHttpRequest_d__28))]
		private static IEnumerator _YieldSendHttpRequest(Result result, FSendFunc sendFunc); // 0x0000000185B68DE0-0x0000000185B68ED0
		[IDTag(1)]
		[IteratorStateMachine(typeof(__YieldSendHttpRequest_d__29))]
		private static IEnumerator _YieldSendHttpRequest(Misc.ObjectRef resultRef, FSendFunc sendFunc, System.Type respType); // 0x0000000186AF7480-0x0000000186AF7580
		private static WaitForAsyncTask<Result> _WaitForSendHttpRequest(FSendFunc sendFunc); // 0x0000000185B67460-0x0000000185B675D0
		private static WaitForAsyncTask<Result<TResp>> _WaitForSendHttpRequest<TResp>(FSendFunc sendFunc)
			where TResp : class;
		private static void _StartWebRequestTask(Result result, FSendFunc sendFunc); // 0x0000000185B67790-0x0000000185B68C10
		private static void _WaitForServiceDone(Result result); // 0x0000000185B69470-0x0000000185B694C0
		private static UnityWebRequest _CreateWebRequestGET(string url, FGetOptions options); // 0x00000001863A0690-0x00000001863A0C80
		private static UnityWebRequest _CreateWebRequestPOST(string url, FPostOptions options); // 0x00000001863A0CC0-0x00000001863A1430
		private static void _SetHttpResult(Result result, UnityWebRequest request); // 0x00000001863A03D0-0x00000001863A0520
		private static void _DeserializeTypedResult(TypedResult result); // 0x0000000185B69890-0x0000000185B69940
		private static void _DebugOnlyProfileResult(Result result, FSendFunc sendFunc); // 0x000000018CA4E4F0-0x000000018CA4E56C
		private static void _MarkResultAsException(Result result, Exception ex); // 0x000000018639ED50-0x000000018639EE20
	}

	public class CircularBuffer<T> : IReadOnlyList<T> // TypeDefIndex: 85716
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
		private sealed class _GetEnumerator_d__18 : IEnumerator<T> // TypeDefIndex: 85715
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
		private void _ThrowIfEmpty(string message = "Cannot access an empty buffer." /* Metadata: 0x026450D7 */);
		private void _Increment(ref int index);
		private void _Decrement(ref int index);
		private int _InternalIndex(int index);
		private ArraySegment<T> _ArrayOne();
		private ArraySegment<T> _ArrayTwo();
	}

	public abstract class HGNetBaseSession // TypeDefIndex: 85725
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
		private const int MAX_RECYCLE_QUEUE_COUNT = 1000; // Metadata: 0x026450F6
		protected CircularBuffer<NetRequest> m_circularBuffer; // 0x58
		private long m_csSeqId; // 0x60
		protected long m_scSeqId; // 0x68
		protected System.Threading.Tasks.Task m_threadTask; // 0x70
		protected int m_threadTaskSignalID; // 0x78
		protected ELogChannel m_logChannel; // 0x7C
		[CompilerGenerated]
		private bool _isSyncFullDataEnd_k__BackingField; // 0x7D
		protected IExtensible m_lastLoginMsg; // 0x80
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
		public bool isSyncFullDataEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8E890-0x0000000184D8E8A0 0x0000000184D8E8A0-0x0000000184D8E8B0
		public int sessionID { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187235BF0-0x0000000187235C00 0x0000000187235C40-0x0000000187235C50
		protected EHGNetSessionReconnectState reconnectState { get; set; } // 0x000000018CA4D5A8-0x000000018CA4D5EC 0x00000001857899B0-0x0000000185789A70
		public bool isRunning { get; } // 0x00000001858412A0-0x00000001858414D0 
		public bool isConnecting { get; } // 0x000000018CA4D56C-0x000000018CA4D5A8 
		public bool isRunningAndConnected { get; } // 0x00000001858414D0-0x00000001858415B0 
		public bool isReconnecting { get; } // 0x00000001858427F0-0x0000000185842820 
		public int closeErrorCode { get; } // 0x000000018CA4D4E4-0x000000018CA4D528 
		public bool isAutoReconnect { get; } // 0x000000018CA4D528-0x000000018CA4D56C 
		public int maxRecycleQueueCount { get; } // 0x00000001854BF610-0x00000001854BF640 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 85717
		{
			// Fields
			public HGNetBaseSession __4__this; // 0x10
			public INetIO tcpIO; // 0x18
	
			// Constructors
			public __c__DisplayClass67_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _ConnectAsync_b__0(Task<System.Threading.Tasks.Task> task); // 0x0000000184DE0C90-0x0000000184DE1640
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_0 // TypeDefIndex: 85718
		{
			// Fields
			public HGNetBaseSession __4__this; // 0x10
			public INetIO tcp; // 0x18
			public int nextid; // 0x20
	
			// Constructors
			public __c__DisplayClass86_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal System.Threading.Tasks.Task _StartTCPMsgLoopThreadTask_b__0(); // 0x0000000184DE1640-0x0000000184DE1670
		}
	
		[CompilerGenerated]
		private struct __SessionThread_d__88 : IAsyncStateMachine // TypeDefIndex: 85719
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HGNetBaseSession __4__this; // 0x20
			public INetIO tcp; // 0x28
			public int threadID; // 0x30
			private TaskAwaiter __u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x0000000184DE4250-0x0000000184DE5870
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000184DE5870-0x0000000184DE5C90
		}
	
		[CompilerGenerated]
		private struct __DoReconnectAsync_d__98 : IAsyncStateMachine // TypeDefIndex: 85720
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HGNetBaseSession __4__this; // 0x20
			public INetIO tcpIO; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000184DE1790-0x0000000184DE3E30
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000184DE3E30-0x0000000184DE4250
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass99_0 // TypeDefIndex: 85721
		{
			// Fields
			public INetIO tcpIO; // 0x10
			public string ip; // 0x18
			public int port; // 0x20
			public int sendTimeout; // 0x24
			public int receiveBufferLen; // 0x28
	
			// Constructors
			public __c__DisplayClass99_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _TryConnectWithTimeout_b__0(); // 0x0000000184DE1670-0x0000000184DE1790
		}
	
		[CompilerGenerated]
		private struct _TryConnectWithTimeout_d__99 : IAsyncStateMachine // TypeDefIndex: 85722
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
			private void MoveNext(); // 0x0000000184DDE0B0-0x0000000184DE0570
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000184DE0570-0x0000000184DE0C40
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass100_0 // TypeDefIndex: 85723
		{
			// Fields
			public INetIO tcpIO; // 0x10
	
			// Constructors
			public __c__DisplayClass100_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _TryCloseTcpIOWithTimeout_b__0(); // 0x0000000184DE0C40-0x0000000184DE0C90
		}
	
		[CompilerGenerated]
		private struct _TryCloseTcpIOWithTimeout_d__100 : IAsyncStateMachine // TypeDefIndex: 85724
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
			private void MoveNext(); // 0x0000000184DDB580-0x0000000184DDD9E0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000184DDD9E0-0x0000000184DDE0B0
		}
	
		// Constructors
		protected HGNetBaseSession(); // 0x00000001863D1990-0x00000001863D1B00
		static HGNetBaseSession(); // 0x000000018716E460-0x000000018716E520
	
		// Methods
		public virtual void Start(); // 0x0000000186C378C0-0x0000000186C37A70
		public virtual bool Connect(string serverIp, int serverPort, bool forceReconnect); // 0x000000018CA4CFFC-0x000000018CA4D364
		public virtual bool ConnectAsync(string serverIp, int serverPort, bool forceReconnect, out HGNetSessionConnectYield yieldHandle); // 0x00000001863D2CE0-0x00000001863D30F0
		public void OnConnectAsyncEnd(System.Threading.Tasks.Task completedTask, INetIO tcpIO); // 0x0000000186D3B490-0x0000000186D3B5E0
		protected abstract void OnConnectedSucceed(INetIO tcpIO);
		private void _DNSCheck(string serverIp); // 0x00000001863D1880-0x00000001863D1990
		public virtual void Close(ENetCloseReason netCloseReason); // 0x0000000185B6B690-0x0000000185B6B6D0
		[IDTag(1)]
		protected void InternalClose(INetIO tcpIO, ENetCloseReason netCloseReason); // 0x000000018CA4D3E4-0x000000018CA4D438
		[IDTag(0)]
		protected void InternalClose(INetIO tcpIO, int netCloseReason); // 0x0000000185B69B80-0x0000000185B69CF0
		protected void EnqueueSendMsg(NetRequest msg); // 0x0000000185840C40-0x0000000185840CA0
		protected static IExtensible CloneRequestMessageForSend(IExtensible msg); // 0x0000000185840B50-0x0000000185840BF0
		protected static void DisposeRequestMessage(ref NetRequest request); // 0x00000001858428E0-0x0000000185842970
		protected static void DisposeMessage(IExtensible msg); // 0x0000000185842970-0x0000000185842A10
		protected void DisposeSendQueue(); // 0x0000000185B6B210-0x0000000185B6B2B0
		protected void DisposeCircularBuffer(); // 0x0000000185B6B170-0x0000000185B6B210
		protected void DisposeLastLoginMessage(); // 0x0000000185B69AF0-0x0000000185B69B80
		public int GetSendQueueMsgCount(); // 0x00000001858427B0-0x00000001858427F0
		protected long IncrementCSSeqID(); // 0x0000000185840B20-0x0000000185840B50
		protected void SetCSSeqID(long id); // 0x0000000185B699A0-0x0000000185B699D0
		protected long GetCSSeqID(); // 0x000000018CA4D364-0x000000018CA4D3A4
		protected INetIO GetIO(); // 0x000000018CA4D3A4-0x000000018CA4D3E4
		protected void StartTCPMsgLoopThreadTask(); // 0x00000001863D23F0-0x00000001863D2530
		protected void CloseTCPMsgThreadTask(); // 0x0000000185B6A1C0-0x0000000185B6A220
		private async System.Threading.Tasks.Task _SessionThread(INetIO tcp, int threadID); // 0x0000000186DE78C0-0x0000000186DE7B40
		private bool _SendAndCheckMessage(INetIO tcp, int threadID); // 0x0000000185839520-0x0000000185839820
		private bool _ReadAndCheckMessageInSessionThread(INetIO tcp, int threadID); // 0x000000018571CB10-0x000000018571CE40
		protected abstract bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp);
		protected abstract void CheckAndDealRespMessages(INetIO netIO, ref NetResponse m);
		protected abstract void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m);
		protected void SessionCheckSignalAndSleep(int threadID); // 0x0000000185B694C0-0x0000000185B69700
		protected void OpenAutoReconnect(); // 0x00000001850CB4D0-0x00000001850CB500
		protected void RemoveAutoReconnect(); // 0x0000000185B6A150-0x0000000185B6A180
		private System.Threading.Tasks.Task _ReconnectCheckerTick(INetIO tcpIO); // 0x000000018578A7C0-0x000000018578AA40
		private async System.Threading.Tasks.Task _DoReconnectAsync(INetIO tcpIO); // 0x000000018578AAD0-0x000000018578AD30
		protected async Task<bool> TryConnectWithTimeout(INetIO tcpIO, string ip, int port, int sendTimeout, int receiveBufferLen, int timeoutMilliseconds); // 0x00000001861CB410-0x00000001861CB6D0
		protected async Task<bool> TryCloseTcpIOWithTimeout(INetIO tcpIO, int timeoutMilliseconds); // 0x00000001861CB6D0-0x00000001861CB960
		public void SetWeakNetPreset(ENetWeakNetPreset preset); // 0x00000001867D5330-0x00000001867D5370
		public void SetWeakNetCustom(int readMinDelayMs, int readMaxDelayMs, int readMaxTriggerCountPerSecond, int writeMinDelayMs, int writeMaxDelayMs, int writeMaxTriggerCountPerSecond); // 0x000000018CA4D438-0x000000018CA4D4E4
		private void _ApplyWeakNetConfigToTcpIO(INetIO tcpIO); // 0x00000001863D1BB0-0x00000001863D1C10
		protected abstract void OnReconnectTimesOver(INetIO tcpIO);
		protected abstract bool NeedKeepConnect();
		protected abstract void DoReconnectLogin(INetIO netIO);
		protected abstract void InitClientRSAKey();
		protected abstract void ClearRSAKey();
		public abstract void ClearRecvQueue();
		public abstract void ClearSendQueue();
		protected void NetStatusChecker_Receive(INetIO netIO, long scSeqId, int receiveCount); // 0x000000018571CE40-0x000000018571CE90
		protected void NetStatusChecker_Sender(INetIO netIO, long csSeqId, int sendCount); // 0x0000000185839820-0x00000001858398E0
		protected abstract void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs);
		protected abstract void ClearPingWDG();
		public abstract bool IsPingOut();
		protected abstract void PingSenderTick(INetIO netIO, long upSeqId);
	}

	public class HGNetSession : HGNetBaseSession // TypeDefIndex: 85727
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
		private byte[] m_rsaSendPacketBuffer; // 0x130
		private byte[] m_frameSendCryptoBuffer; // 0x138
		private byte[] m_frameReceivePacketBuffer; // 0x140
		public static long s_maxframeSendPacketBuffer; // 0x18
		public static long s_maxPackedMessageNum; // 0x20
		protected readonly Queue<NetResponse> m_callbackQueue; // 0x148
		private HGNetSessionLoginYield m_currLoginHandle; // 0x150
		private const int SEND_PING_DELTA_TICK_TIME_MS = 2000; // Metadata: 0x026450FA
		private const long SERVER_TIME_CALIBRATION_LARGE_DELTA_MS = 300000; // Metadata: 0x026450FC
		private const int IN_PING_PROGRESS_MAX_TIME = 999; // Metadata: 0x02645104
		public static int s_pingWdgOutTimes; // 0x28
		private static int s_pingSyncFullEndBeforeTimes; // 0x2C
		private long m_needSendPingTimer; // 0x158
		private int m_pingWDG; // 0x160
		private long m_clientTsDelayms; // 0x168
		private int m_pingValue; // 0x170
		private bool m_isPingInProgress; // 0x174
		private long m_isPingInProgressStartTime; // 0x178
		private readonly ConcurrentQueue<FServerTimeCalibrationChange> m_serverTimeCalibrationChangeQueue; // 0x180
		private static readonly string CLIENT_NET_PEM_PUBLIC_KEY_HEAD_FORMAT; // 0x30
		private static readonly string CLIENT_NET_RSA_PUBLIC_KEY; // 0x38
		private static readonly string CLIENT_NET_RSA_PRIVATE_KEY; // 0x40
		private static byte[] s_clientPublicKeyBytes; // 0x48
		private RSA m_rsaClientPrivateProvider; // 0x188
		private static readonly byte[] EMPTY_BYTES; // 0x50
		private static int s_CacheLogLength; // 0x58
		private StringBuilder m_sbCache; // 0x190
	
		// Nested types
		[IsReadOnly]
		private struct FServerTimeCalibrationChange // TypeDefIndex: 85726
		{
			// Fields
			public readonly long previousBiasMs; // 0x00
			public readonly long currentBiasMs; // 0x08
	
			// Constructors
			public FServerTimeCalibrationChange(long previousBiasMs, long currentBiasMs); // 0x0000000187232F10-0x0000000187232F20
		}
	
		// Constructors
		public HGNetSession(); // 0x00000001867D3610-0x00000001867D38D0
		static HGNetSession(); // 0x0000000186EBA9B0-0x0000000186EBABC0
	
		// Methods
		public void SetAutoReconnectToken(string uid, string token, int channel); // 0x000000018710D0D0-0x000000018710D130
		protected override void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs); // 0x000000018600CEB0-0x000000018600CEE0
		protected override void DoReconnectLogin(INetIO netIO); // 0x000000018CA56098-0x000000018CA56B8C
		public override void Start(); // 0x0000000186C36D40-0x0000000186C37870
		public void OnApplicationPause(bool pause); // 0x000000018CA56C64-0x000000018CA56D68
		public void OnApplicationFocus(bool hasFocus); // 0x00000001869AE320-0x00000001869AE360
		private void _RequestTimeCalibration(); // 0x00000001869AE360-0x00000001869AE390
		public ulong SendMessage(IExtensible msg); // 0x000000018583FAD0-0x0000000185840B20
		[IFixIgnore]
		protected void PackMessageToSendQueue(); // 0x0000000185841700-0x0000000185842760
		private void _FlushMergeQueueToSendQueue(); // 0x000000018CA56F70-0x000000018CA57054
		private void _DisposeMergeQueueCache(); // 0x0000000185842820-0x00000001858428E0
		private void _DisposeFrameSendQueue(); // 0x000000018CA56EAC-0x000000018CA56F70
		public void UpdateInGameThread(); // 0x000000018CA56E38-0x000000018CA56EAC
		public void TailLateUpdateInGameThread(); // 0x000000018CA56E04-0x000000018CA56E38
		private float _GetMessageTimeLimit(); // 0x000000018CA57054-0x000000018CA570D4
		[IFixIgnore]
		private void _ProcessReceivedMessagesInGameThread(bool flushAll); // 0x00000001856AEC70-0x00000001856B0E30
		public HGNetSessionLoginYield LoginAsync(string uid, string token, int channel); // 0x00000001867D82A0-0x00000001867DAC50
		private static void _CSLoginHelper_UpdateAppInfo(MSG_A1 msg); // 0x0000000186D31130-0x0000000186D311E0
		private static string _GetOnlineResVersion(); // 0x0000000186D311E0-0x0000000186D312A0
		private static ENV_TYPE _GetSDKEnv(); // 0x0000000186D31370-0x0000000186D31420
		private static CLIENT_PLATFORM_TYPE _GetPlatformID(); // 0x0000000186D312A0-0x0000000186D312D0
		private static int _GetPayPlatform(); // 0x0000000186D312D0-0x0000000186D31340
		private void _SessionLoginThreadTask(object handle); // 0x0000000185B690D0-0x0000000185B69470
		public void StartMsgLoop(); // 0x00000001850CB430-0x00000001850CB480
		protected override void OnConnectedSucceed(INetIO tcpIO); // 0x000000018722CB90-0x000000018722CBC0
		protected override void OnReconnectTimesOver(INetIO tcpIO); // 0x000000018CA56D68-0x000000018CA56DB0
		protected override bool NeedKeepConnect(); // 0x0000000185F5BFE0-0x0000000185F5C010
		protected override void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest req); // 0x00000001854BEB90-0x00000001854BF610
		private void _WriteMessageInSessionThread(INetIO netIO, ref NetRequest request, bool useSRSA = false /* Metadata: 0x026450F8 */); // 0x0000000185724760-0x0000000185724AA0
		protected override bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp); // 0x000000018571CE90-0x000000018571CED0
		private bool _ReadMessageInSessionThread(INetIO netIO, out NetResponse resp, bool useSRSA = false /* Metadata: 0x026450F9 */); // 0x000000018571D5B0-0x000000018571E440
		public override void ClearRecvQueue(); // 0x0000000185840CF0-0x0000000185840D60
		public override void ClearSendQueue(); // 0x0000000187217F60-0x0000000187217FA0
		public static void SetBurstMode(bool val); // 0x000000018CA56DB0-0x000000018CA56E04
		public NetDevProfilerSnapshot GetNetDevProfilerSnapshot(); // 0x000000018CA56B8C-0x000000018CA56C20
		~HGNetSession(); // 0x0000000185B6A180-0x0000000185B6A1C0
		public int GetPing(); // 0x0000000185841220-0x00000001858412A0
		public bool IsPingInProgress(); // 0x000000018CA56C20-0x000000018CA56C64
		public long GetPingPassedTime(); // 0x00000001866738D0-0x0000000186673950
		protected override void ClearPingWDG(); // 0x00000001864D44F0-0x00000001864D4560
		private void _ApproximateLoginServerTime(long serverTimeMS, int serverZone); // 0x0000000185B699D0-0x0000000185B69A60
		private bool _HandleSpecialMessagePing(NetResponse m); // 0x000000018583F830-0x000000018583FAD0
		private void _DispatchServerTimeCalibrationEventsInGameThread(); // 0x00000001858415B0-0x0000000185841700
		public override bool IsPingOut(); // 0x0000000185CEAE40-0x0000000185CEAEF0
		protected override void PingSenderTick(INetIO netIO, long upSeqId); // 0x00000001858398E0-0x0000000185839F90
		public static byte[] GetClientPublicKey(); // 0x00000001867D7CE0-0x00000001867D7D90
		protected override void InitClientRSAKey(); // 0x00000001860282E0-0x00000001860283F0
		private byte[] _RSADecrypt(byte[] data); // 0x0000000186B29620-0x0000000186B29730
		protected override void ClearRSAKey(); // 0x000000018CA55FC8-0x000000018CA56098
		protected override void CheckAndDealRespMessages(INetIO netIO, ref NetResponse msg); // 0x00000001856AC630-0x00000001856AE0E0
		private bool _HandleSpecialMessageReconnectIncr(INetIO netIO, NetResponse m); // 0x000000018CA57388-0x000000018CA578C8
		private bool _HandleSpecialMessageReconnectFull(INetIO netIO, NetResponse m); // 0x000000018CA571D8-0x000000018CA57388
		private bool _HandleSpecialMessageErrorCode(INetIO netIO, NetResponse m); // 0x000000018CA570D4-0x000000018CA571D8
		private bool _HandleSpecialMessageReconnectLogin(INetIO netIO, NetResponse m); // 0x000000018CA578C8-0x000000018CA57A78
		private bool _HandleLoginEncryp(INetIO netIO, MSG_B1 msg); // 0x0000000186B29210-0x0000000186B29390
		public void __iFixBaseProxy_Start(); // 0x000000018CA557A8-0x000000018CA557B0
	}

	public enum EHGNetSessionState : byte // TypeDefIndex: 85728
	{
		Closed = 0,
		Opened = 1,
		Connecting = 2,
		SessionRunning = 3
	}

	public enum EHGNetSessionReconnectState : byte // TypeDefIndex: 85729
	{
		None = 0,
		ReconnectingTcp = 1,
		SendLogin = 2,
		ResendPack = 3
	}

	public enum ENetCloseReason // TypeDefIndex: 85730
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

	public static class HGNetSessionUtils // TypeDefIndex: 85731
	{
		// Methods
		public static bool CheckErrorNeedsDisconnect(CODE errorCode); // 0x000000018CA55F80-0x000000018CA55FC8
	}

	public static class HGNetSessionConstant // TypeDefIndex: 85732
	{
		// Fields
		public const int CODE_SUC = 0; // Metadata: 0x02645130
		public const int CODE_CONN_FAILED = 1; // Metadata: 0x02645131
		public const int CODE_CONN_WAIT = -1; // Metadata: 0x02645132
	}

	public enum ENetConnectErrorCode // TypeDefIndex: 85733
	{
		Invalid = -1,
		None = 0,
		ForServerErrorMax = 100000,
		ConnectError = 800001,
		TimeOut = 800002
	}

	public class HGNetSessionLoginYield : CustomYieldInstruction // TypeDefIndex: 85735
	{
		// Fields
		internal LoginErrorInfo m_loginErrorInfo; // 0x10
		internal bool m_bIsFinish; // 0x18
		internal MSG_A1 m_request; // 0x20
		internal MSG_B1 m_resp; // 0x28
		private object m_locker; // 0x30
	
		// Properties
		public bool isSucceed { get; } // 0x00000001867D59B0-0x00000001867D5A00 
		public override bool keepWaiting { get; } // 0x00000001870F0830-0x00000001870F0860 
	
		// Nested types
		internal class LoginErrorInfo // TypeDefIndex: 85734
		{
			// Fields
			[CompilerGenerated]
			private int _code_k__BackingField; // 0x10
			[CompilerGenerated]
			private string _details_k__BackingField; // 0x18
	
			// Properties
			internal int code { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
			internal string details { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
			// Constructors
			public LoginErrorInfo(); // 0x00000001867D3980-0x00000001867D39D0
	
			// Methods
			public void SetErrorInvaild(); // 0x00000001867D39D0-0x00000001867D3A50
			public void SetErrorConnectError(); // 0x000000018CA583A0-0x000000018CA5842C
			public void SetErrorConnectTimeOut(); // 0x000000018CA5842C-0x000000018CA584B8
			public void Clear(); // 0x00000001867D3A50-0x00000001867D3AD0
			public void Set(int code, string details); // 0x000000018CA584B8-0x000000018CA5850C
		}
	
		// Constructors
		public HGNetSessionLoginYield(); // 0x00000001867D38D0-0x00000001867D3980
		public HGNetSessionLoginYield(MSG_A1 req); // 0x00000001867D3550-0x00000001867D3610
	
		// Methods
		public MSG_A1 GetRequest(); // 0x000000018CA55C30-0x000000018CA55C70
		public MSG_B1 GetResponse(); // 0x000000018CA55C70-0x000000018CA55CB0
		public int GetErrorCode(); // 0x000000018CA55B88-0x000000018CA55BDC
		public string GetErrorDetails(); // 0x000000018CA55BDC-0x000000018CA55C30
		public void SetSucceed(MSG_B1 sc); // 0x00000001867D33C0-0x00000001867D3550
		public void SetNtfError(int ntfErrorCode, string ntfErrorDetails); // 0x000000018CA55D94-0x000000018CA55E9C
		public void SetConnectErrorError(); // 0x000000018CA55CB0-0x000000018CA55D94
		public void SetTimeOutError(); // 0x000000018CA55E9C-0x000000018CA55F80
	}

	public class HGNetSessionConnectYield : CustomYieldInstruction // TypeDefIndex: 85736
	{
		// Fields
		internal System.Threading.Tasks.Task m_connectTask; // 0x10
		internal ENetConnectErrorCode connectErrorCode; // 0x18
	
		// Properties
		public bool isSucceed { get; } // 0x00000001867D7A50-0x00000001867D7A80 
		public override bool keepWaiting { get; } // 0x000000018716D160-0x000000018716D1B0 
	
		// Constructors
		public HGNetSessionConnectYield(); // 0x0000000187234900-0x0000000187234910
		public HGNetSessionConnectYield(System.Threading.Tasks.Task connectTask); // 0x0000000185A0AB60-0x0000000185A0AB90
	
		// Methods
		public int GetCode(); // 0x000000018CA55B10-0x000000018CA55B50
		public void SetFinish(ENetConnectErrorCode code); // 0x000000018CA55B50-0x000000018CA55B88
	}
}

namespace Beyond.Network.HGNetLogger
{
	public abstract class HGNetLogBaseSession // TypeDefIndex: 85737
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
		private const int MAX_RECYCLE_QUEUE_COUNT = 1000; // Metadata: 0x02645141
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
		public bool isRunning { get; } // 0x000000018CA55100-0x000000018CA55140 
		public bool isConnecting { get; } // 0x000000018CA55088-0x000000018CA550C4 
		public bool isRunningAndConnected { get; } // 0x000000018CA550C4-0x000000018CA55100 
		public int closeErrorCode { get; } // 0x000000018CA55000-0x000000018CA55044 
		public bool isAutoReconnect { get; } // 0x000000018CA55044-0x000000018CA55088 
	
		// Constructors
		protected HGNetLogBaseSession(); // 0x000000018CA54EA8-0x000000018CA55000
		static HGNetLogBaseSession(); // 0x000000018CA54DF4-0x000000018CA54EA8
	
		// Methods
		public virtual void Start(); // 0x000000018CA540A4-0x000000018CA541EC
		public virtual bool Connect(string serverIp, int serverPort, bool forceReconnect); // 0x000000018CA535AC-0x000000018CA53898
		public virtual bool ConnectAsync(string serverIp, int serverPort, bool forceReconnect, out HGNetSessionConnectYield yieldHandle); // 0x000000018CA5320C-0x000000018CA535AC
		public void OnConnectAsyncEnd(System.Threading.Tasks.Task continuationAction); // 0x000000018CA53C14-0x000000018CA53D50
		protected abstract void OnConnectedSucceed(INetIO tcpIO);
		private void _DNSCheck(string serverIp); // 0x000000018CA541EC-0x000000018CA543A4
		[IDTag(1)]
		public virtual void Close(ENetCloseReason netCloseReason); // 0x000000018CA52FDC-0x000000018CA5301C
		[IDTag(0)]
		public virtual void Close(int netCloseReason); // 0x000000018CA5301C-0x000000018CA5320C
		protected void EnqueueSendMsg(NetRequest msg); // 0x000000018CA53898-0x000000018CA53958
		public int GetSendQueueMsgCount(); // 0x000000018CA539D8-0x000000018CA53A5C
		protected long IncrementCSSeqID(); // 0x000000018CA53A5C-0x000000018CA53A9C
		protected void SetCSSeqID(long id); // 0x000000018CA53E98-0x000000018CA53ED8
		protected long GetCSSeqID(); // 0x000000018CA53958-0x000000018CA53998
		protected INetIO GetIO(); // 0x000000018CA53998-0x000000018CA539D8
		protected void StartTCPMsgLoopThreadTask(); // 0x000000018CA53ED8-0x000000018CA540A4
		protected void CloseTCPMsgThreadTask(); // 0x000000018CA52F04-0x000000018CA52FDC
		private void _SessionThread(); // 0x000000018CA5490C-0x000000018CA54DF4
		protected abstract bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp);
		protected abstract void CheckAndDealRespMessages(INetIO netIO, ref NetResponse m);
		protected abstract void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m);
		private static void _DisposeRequestMessage(ref NetRequest msg); // 0x000000018CA54464-0x000000018CA54510
		private void _DisposeSendQueue(); // 0x000000018CA54590-0x000000018CA54650
		private void _DisposeCircularBuffer(); // 0x000000018CA543A4-0x000000018CA54464
		private static void _DisposeResponseMessage(ref NetResponse resp); // 0x000000018CA54510-0x000000018CA54590
		protected void SessionCheckSignalAndSleep(); // 0x000000018CA53DD0-0x000000018CA53E98
		protected void OpenAutoReconnect(); // 0x000000018CA53D50-0x000000018CA53D90
		protected void RemoveAutoReconnect(); // 0x000000018CA53D90-0x000000018CA53DD0
		private void _ReconnectCheckerTick(); // 0x000000018CA54650-0x000000018CA5490C
		protected abstract void OnReconnectTimesOver();
		protected abstract bool NeedKeepConnect();
		protected abstract void DoReconnectLogin(INetIO netIO);
		protected abstract void InitClientRSAKey();
		protected abstract void ClearRSAKey();
		protected void NetStatusChecker_Receive(INetIO netIO, long scSeqId, int receiveCount); // 0x000000018CA53A9C-0x000000018CA53B4C
		protected void NetStatusChecker_Sender(INetIO netIO, long csSeqId, int sendCount); // 0x000000018CA53B4C-0x000000018CA53C14
		protected abstract void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs);
		protected abstract void ClearPingWDG();
		public abstract bool IsPingOut();
		protected abstract void PingSenderTick(INetIO netIO, long upSeqId);
	}

	public class HGNetLogger : Beyond.Log.ILogger // TypeDefIndex: 85738
	{
		// Fields
		private BitArray256 m_enabledLogChannel; // 0x10
		private ConcurrentQueue<FLogMessage> m_logMessagesQueue; // 0x30
		public static int s_maxLogQueueSize; // 0x00
		public static int s_maxRepeatedMsgMs; // 0x04
		public static int s_maxRepeatedMsgCount; // 0x08
	
		// Constructors
		public HGNetLogger(); // 0x0000000185B823C0-0x0000000185B82490
		static HGNetLogger(); // 0x00000001871EDD20-0x00000001871EDD90
	
		// Methods
		public void Log(ref FLogMessage msg); // 0x000000018583C680-0x000000018583DAF0
		[IDTag(0)]
		public static LogLevel ConvertFromDLogger(ELogLevel level); // 0x000000018583E1D0-0x000000018583E230
		public static NativeLogLevel ConvertFromDLoggerV2(ELogLevel level); // 0x000000018583E170-0x000000018583E1D0
		public bool CheckLog(ref FLogMessage msg); // 0x000000018583E230-0x000000018583E280
		public void Clear(); // 0x0000000186BA1510-0x0000000186BA1580
		public void SetLogChannel(ulong channel1, ulong channel2, ulong channel3, ulong channel4); // 0x000000018CA55A84-0x000000018CA55B10
		[IDTag(1)]
		public static int ConvertFromDLogger(ELogChannel channel); // 0x000000018583E140-0x000000018583E170
	}

	public class HGNetLoggerClient // TypeDefIndex: 85739
	{
		// Fields
		private static HGNetLoggerClient s_instance; // 0x00
		[CompilerGenerated]
		private static long _s_roleID_k__BackingField; // 0x08
		public HGNetLoggerSession m_logsession; // 0x10
		private HGNetLogger m_netLogger; // 0x18
		public static readonly int MAX_LOG_SEND_QUEUE_SIZE; // 0x10
		private const int MAX_LOCAL_LOG_QUEUE_SIZE = 200; // Metadata: 0x02645144
		private readonly Queue<FLogMessage> m_localLogQueue; // 0x20
		private readonly object m_queueLock; // 0x28
		private bool m_sendQueueOverflowReported; // 0x30
		public static Beyond.Network.HGNetLogger.Version s_usedVersion; // 0x14
	
		// Properties
		public static HGNetLoggerClient instance { get; } // 0x000000018583E280-0x000000018583E3D0 
		public static long s_roleID { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018CA55254-0x000000018CA552A4 0x000000018CA552A4-0x000000018CA552FC
	
		// Constructors
		protected HGNetLoggerClient(); // 0x00000001870F5340-0x00000001870F5410
		static HGNetLoggerClient(); // 0x00000001871FC4D0-0x00000001871FC520
	
		// Methods
		public void Init(string uid, string token, string env, string roleId = "" /* Metadata: 0x02645143 */); // 0x0000000185B82800-0x0000000185B82C80
		public void AddLog(string message, string stacktrace, UnityEngine.LogType type); // 0x00000001863278B0-0x0000000186327BC0
		private void _FlushLocalLogQueue(); // 0x0000000185B81BD0-0x0000000185B81E50
		public static void OnApplicationPause(bool pauseStatus); // 0x000000018CA55140-0x000000018CA55210
		public void ShutDown(); // 0x000000018CA55210-0x000000018CA55254
		private void _CloseAndClear(ENetCloseReason reason); // 0x0000000185B6B450-0x0000000185B6B690
		public bool WriteNetLog(ref LogMessage log); // 0x000000018583E4F0-0x000000018583F3D0
		public static void SetRoleID(ulong roleID); // 0x00000001850CB5B0-0x00000001850CB660
		public void SetNetLogMaskFromServer(RepeatedField<ulong> masks); // 0x000000018722CBC0-0x000000018722CBF0
		[CompilerGenerated]
		private void _Init_b__16_0(); // 0x0000000184DA54F0-0x0000000184DA5840
	}

	public class HGNetLoggerCloudSettings // TypeDefIndex: 85740
	{
		// Fields
		public static readonly HGNetLoggerCloudSettings instance; // 0x00
		private LogControl m_cloudLogControl; // 0x10
		private Dictionary<int, int> m_cloudChannelLevelMaskTables; // 0x18
		private LogControl m_localLogControl; // 0x20
		private Dictionary<int, int> m_localChannelLevelMaskTables; // 0x28
		private static List<NativeLogLevel> s_allLevels; // 0x08
	
		// Constructors
		public HGNetLoggerCloudSettings(); // 0x0000000186E23530-0x0000000186E23730
		static HGNetLoggerCloudSettings(); // 0x0000000186E233D0-0x0000000186E23530
	
		// Methods
		public static void SetCloudLogControl(AuthResponse control, HGNetBaseSession session); // 0x00000001852D05A0-0x00000001852D10F0
		[IDTag(1)]
		public static bool IsNetLogLevelEnabled(ELogLevel elevel, ELogChannel channel); // 0x000000018CA554C8-0x000000018CA55564
		[IDTag(0)]
		public static bool IsNetLogLevelEnabled(NativeLogLevel level, int channel); // 0x000000018583E3D0-0x000000018583E4F0
		public static bool IsLocalLogLevelEnabled(ELogLevel elevel, ELogChannel channel); // 0x000000018CA55380-0x000000018CA554C8
		public static NativeLogLevel ConvertFromDLogger(ELogLevel level); // 0x000000018CA552FC-0x000000018CA55380
	}

	public class HGNetLoggerSession : HGNetBaseSession // TypeDefIndex: 85741
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
		public string uid { get; } // 0x000000018CA55A40-0x000000018CA55A84 
		public string roleId { get; } // 0x000000018CA557B0-0x000000018CA557F4 
		private static Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> s_messageType2Id { get; } // 0x000000018578A600-0x000000018578A7C0 
		private static Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> s_messageId2Type { get; } // 0x000000018CA557F4-0x000000018CA55A40 
	
		// Constructors
		public HGNetLoggerSession(); // 0x0000000185B824E0-0x0000000185B82590
	
		// Methods
		public static bool TryGetMsgTypeByID(System.Type msgType, out Beyond.Network.HGNetLogger.MessageType type); // 0x000000018578A5A0-0x000000018578A600
		public override void Start(); // 0x0000000186C37870-0x0000000186C378C0
		public void SetReconnectSuccessCallback(Action onReconnectSuccess); // 0x000000018CA55760-0x000000018CA557A8
		public void OnApplicationPause(bool pause); // 0x000000018CA55598-0x000000018CA556A4
		protected override void OnConnectedSucceed(INetIO tcpIO); // 0x00000001850CB480-0x00000001850CB4D0
		protected override bool ReadMessageInSessionThread(INetIO netIO, out NetResponse resp); // 0x000000018571CED0-0x000000018571D5B0
		protected override void CheckAndDealRespMessages(INetIO netIO, ref NetResponse resp); // 0x0000000185789610-0x0000000185789860
		protected override void CheckAndWriteReqMsg(INetIO netIO, ref NetRequest m); // 0x0000000185789E10-0x0000000185789E60
		private void _WriteMessageInSessionThread(INetIO netIO, NetRequest request); // 0x0000000185789E60-0x000000018578A450
		public ulong SendMessage(IExtensible msg); // 0x000000018583F470-0x000000018583F700
		private static IExtensible _CloneMessage(IExtensible msg); // 0x000000018583F3D0-0x000000018583F470
		public void SetAutoReconnectToken(string uid, string token, string env, string roleId); // 0x0000000185B82D40-0x0000000185B82DD0
		protected override bool NeedKeepConnect(); // 0x0000000185842760-0x00000001858427B0
		protected override void DoReconnectLogin(INetIO netIO); // 0x0000000185789B00-0x0000000185789C00
		private int _GetConnectTimeoutTime(); // 0x000000018583A030-0x000000018583A0C0
		protected override void SessionConnectTimeoutCheckerTick(INetIO netIO, long clientLastReceiveMsgMilliTs, long clientLastSendMsgMilliTs); // 0x0000000185839420-0x0000000185839520
		protected override void ClearPingWDG(); // 0x0000000186E080B0-0x0000000186E080E0
		public void SendLogin(INetIO netIO); // 0x000000018578B020-0x000000018578C990
		public override bool IsPingOut(); // 0x000000018674BFB0-0x000000018674BFE0
		protected override void PingSenderTick(INetIO netIO, long upSeqId); // 0x000000018613B070-0x000000018613B0A0
		protected override void InitClientRSAKey(); // 0x000000018721E5A0-0x000000018721E5D0
		protected override void ClearRSAKey(); // 0x000000018CA55564-0x000000018CA55598
		public override void ClearRecvQueue(); // 0x000000018721E5D0-0x000000018721E600
		public override void ClearSendQueue(); // 0x00000001871F28A0-0x00000001871F28D0
		private static IExtensible _CreateLoggerMessage(Beyond.Network.HGNetLogger.MessageType msgType); // 0x0000000186ACE6A0-0x0000000186ACE7A0
		protected override void OnReconnectTimesOver(INetIO tcpIO); // 0x000000018CA556A4-0x000000018CA55760
		public void __iFixBaseProxy_Start(); // 0x000000018CA557A8-0x000000018CA557B0
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 85629
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 85630
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 85631
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 85632
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 85633
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 85634
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 85635
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 85628
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 85742
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018CA5833C-0x000000018CA583A0
	
		// Methods
		public Socket __Gen_Wrap_0(object P0); // 0x000000018CA57A78-0x000000018CA57B58
		public void __Gen_Wrap_1(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public bool __Gen_Wrap_2(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public void __Gen_Wrap_3(object P0, bool P1); // 0x000000018936C508-0x000000018936C5D8
		public int __Gen_Wrap_4(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public void __Gen_Wrap_5(object P0, object P1, int P2); // 0x000000018C0C2668-0x000000018C0C2750
		public IAsyncResult __Gen_Wrap_6(object P0, object P1, int P2, object P3, object P4); // 0x000000018CA58008-0x000000018CA58144
		public System.Threading.Tasks.Task __Gen_Wrap_7(object P0, object P1, int P2); // 0x000000018CA58144-0x000000018CA5825C
		public NetworkStream __Gen_Wrap_8(object P0); // 0x000000018CA5825C-0x000000018CA5833C
		public void __Gen_Wrap_9(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public int __Gen_Wrap_10(object P0, SocketOptionLevel P1, SocketOptionName P2); // 0x0000000188CAC050-0x0000000188CAC148
		public void __Gen_Wrap_11(object P0, int P1); // 0x0000000188B4D6D0-0x0000000188B4D7A0
		public LingerOption __Gen_Wrap_12(object P0); // 0x000000018CA57B58-0x000000018CA57C38
		public CS_GM_COMMAND __Gen_Wrap_13(); // 0x000000018CA57C38-0x000000018CA57CF4
		public CS_DUNGEON_RECOVER_AP __Gen_Wrap_14(); // 0x000000018CA57CF4-0x000000018CA57DB0
		public ITEM_BUNDLE __Gen_Wrap_15(); // 0x000000018CA57DB0-0x000000018CA57E6C
		public INST_ITEM_BUNDLE __Gen_Wrap_16(); // 0x000000018CA57E6C-0x000000018CA57F28
		public IExtensible __Gen_Wrap_17(object P0); // 0x000000018CA57F28-0x000000018CA58008
		public long __Gen_Wrap_18(object P0); // 0x0000000188AB6D9C-0x0000000188AB6E5C
		public ulong __Gen_Wrap_19(object P0, object P1); // 0x00000001831240C0-0x0000000183124450
		public System.Type __Gen_Wrap_20(int P0); // 0x0000000184DB7080-0x0000000184DB78E0
		public void __Gen_Wrap_21(object P0, int P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public NetBus.ResultHandler __Gen_Wrap_22(object P0, object P1); // 0x0000000184DB78E0-0x0000000184DB82E0
		public CSHead __Gen_Wrap_23(ref NetResponse P0); // 0x0000000184DB82E0-0x0000000184DB9220
		public ulong __Gen_Wrap_24(ref NetResponse P0); // 0x0000000184DB9220-0x0000000184DB9E60
		public int __Gen_Wrap_25(ref NetResponse P0); // 0x0000000184DB9E60-0x0000000184DBAAA0
		public void __Gen_Wrap_26(object P0, in NetResponse P1); // 0x0000000184DBAAA0-0x0000000184DBB150
		public NetBus.ResultHandler __Gen_Wrap_27(object P0, SCMessageID P1, object P2); // 0x0000000184DBB150-0x0000000184DBBB70
		public void __Gen_Wrap_28(object P0, SCMessageID P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public object __Gen_Wrap_29(ref NetResponse P0); // 0x0000000184DBBB70-0x0000000184DBCAB0
		public void __Gen_Wrap_30(ref NetResponse P0, object P1); // 0x0000000184DBCAB0-0x0000000184DBD7D0
		public Header __Gen_Wrap_31(ref NetResponse P0); // 0x0000000184DBD7D0-0x0000000184DBE710
		public void __Gen_Wrap_32(ref NetResponse P0); // 0x0000000184DBE710-0x0000000184DBF340
		public void __Gen_Wrap_33(object P0, StringPathHash P1); // 0x0000000184DBF340-0x0000000184DBF9D0
		public float __Gen_Wrap_34(object P0); // 0x00000001826A2110-0x00000001826A23D0
		public int __Gen_Wrap_35(object P0, object P1, float P2, float P3); // 0x000000018378C4B0-0x000000018378C880
		public int __Gen_Wrap_36(object P0, CSMessageID P1, float P2); // 0x000000018256A110-0x000000018256A400
		public void __Gen_Wrap_37(in NetResponse P0); // 0x0000000184DBF9D0-0x0000000184DBFFA0
		public NetBus.ResultHandler __Gen_Wrap_38(object P0, object P1, float P2); // 0x0000000184DBFFA0-0x0000000184DC09E0
		public NetBus.ResultHandler __Gen_Wrap_39(object P0, object P1, CSMessageID P2, object P3); // 0x0000000184DC09E0-0x0000000184DC14E0
		public NetBus.ResultHandler __Gen_Wrap_40(object P0, object P1, bool P2, object P3, object P4); // 0x0000000184DC14E0-0x0000000184DC20B0
		public void __Gen_Wrap_41(object P0, float P1); // 0x0000000182659420-0x0000000182659700
		public bool __Gen_Wrap_42(object P0, object P1); // 0x00000001827B9DC0-0x00000001827BA150
		public IExtensible __Gen_Wrap_43(int P0, object P1, object P2, int P3, int P4); // 0x0000000184DC20B0-0x0000000184DC2B20
		public bool __Gen_Wrap_44(object P0, object P1, object P2, int P3, out int P4); // 0x0000000184DC2B20-0x0000000184DC2FD0
		public NetUtil.FFactoryHsPoolStats __Gen_Wrap_45(); // 0x0000000184DC2FD0-0x0000000184DC37F0
		public void __Gen_Wrap_46(); // 0x000000018253FC00-0x000000018253FDD0
		public void __Gen_Wrap_47(int P0, object P1); // 0x0000000182220EE0-0x00000001822211B0
		public IEnumerable<object> __Gen_Wrap_48(bool P0); // 0x0000000184DC37F0-0x0000000184DC4050
		public IEnumerable<object> __Gen_Wrap_49(); // 0x0000000184DC4050-0x0000000184DC4870
		public long __Gen_Wrap_50(); // 0x00000001821F27C0-0x00000001821F2990
		public IEnumerator __Gen_Wrap_51(); // 0x0000000184DC4870-0x0000000184DC5090
		public bool __Gen_Wrap_52(out Exception P0); // 0x0000000184DC5090-0x0000000184DC5990
		public CSHead __Gen_Wrap_53(); // 0x0000000184DC5990-0x0000000184DC61B0
		public string __Gen_Wrap_54(object P0); // 0x0000000184DC61B0-0x0000000184DC6AD0
		public void __Gen_Wrap_55(object P0, object P1, int P2, int P3, object P4); // 0x00000001824FE440-0x00000001824FE8D0
		public bool __Gen_Wrap_56(Span<byte> P0, object P1, int P2, int P3, object P4, out NetResponse P5); // 0x0000000184DC6AD0-0x0000000184DC7840
		public int __Gen_Wrap_57(object P0, ulong P1, int P2, int P3, object P4, int P5); // 0x0000000184DC7840-0x0000000184DC7C40
		public void __Gen_Wrap_58(System.Type P0, MethodInfo P1, bool P2); // 0x00000001825283D0-0x0000000182528770
		public string __Gen_Wrap_59(); // 0x0000000184DC7C40-0x0000000184DC8460
		public string __Gen_Wrap_60(NetworkUrls.EUrlType P0); // 0x0000000184DC8460-0x0000000184DC8CC0
		public string __Gen_Wrap_61(object P0, NetworkUrls.EUrlType P1); // 0x0000000184DC8CC0-0x0000000184DC9610
		public void __Gen_Wrap_62(object P0, object P1, int P2, int P3, int P4, int P5); // 0x00000001824F4750-0x00000001824F4B30
		public System.Threading.Tasks.Task __Gen_Wrap_63(object P0, object P1, int P2, int P3, int P4, int P5); // 0x0000000184DC9610-0x0000000184DCA090
		public void __Gen_Wrap_64(object P0, object P1, object P2); // 0x0000000182532090-0x00000001825324E0
		public EndPoint __Gen_Wrap_65(object P0); // 0x0000000184DCA090-0x0000000184DCA9B0
		public void __Gen_Wrap_66(object P0, bool P1, bool P2); // 0x00000001824EC140-0x00000001824EC440
		public TcpIO.WeakNetDelayConfig __Gen_Wrap_67(int P0, int P1, int P2); // 0x0000000184DCA9B0-0x0000000184DCB200
		public void __Gen_Wrap_68(ref long P0, ref int P1); // 0x0000000184DCB200-0x0000000184DCB460
		public void __Gen_Wrap_69(object P0, int P1, int P2, int P3, int P4, int P5, int P6); // 0x0000000182F8BF80-0x0000000182F8C2C0
		public void __Gen_Wrap_70(object P0, ENetWeakNetPreset P1); // 0x00000001824828A0-0x0000000182482B70
		public TcpIOProfilerSnapshot __Gen_Wrap_71(object P0); // 0x0000000184DCB460-0x0000000184DCBD60
		public int __Gen_Wrap_72(TcpIO.WeakNetDelayConfig P0); // 0x0000000184DCBD60-0x0000000184DCC310
		public void __Gen_Wrap_73(object P0, TcpIO.WeakNetDelayConfig P1, ref long P2, ref int P3); // 0x0000000184DCC310-0x0000000184DCCA40
		public void __Gen_Wrap_74(object P0, object P1, int P2, int P3); // 0x00000001826538B0-0x0000000182653C60
		public byte[] __Gen_Wrap_75(object P0); // 0x0000000184DCCA40-0x0000000184DCD360
		public int __Gen_Wrap_76(object P0, object P1, int P2, int P3); // 0x0000000182652E70-0x0000000182653230
		public HttpSender.Cancellation __Gen_Wrap_77(ref HttpSender.FSendFunc P0); // 0x0000000184DCD360-0x0000000184DCE2B0
		public UnityWebRequest __Gen_Wrap_78(object P0, HttpSender.FGetOptions P1); // 0x0000000184DCE2B0-0x0000000184DCEF70
		public UnityWebRequest __Gen_Wrap_79(object P0, HttpSender.FPostOptions P1); // 0x0000000184DCEF70-0x0000000184DCFC30
		public UnityWebRequest __Gen_Wrap_80(ref HttpSender.FSendFunc P0); // 0x0000000184DCFC30-0x0000000184DD0B80
		public IEnumerator __Gen_Wrap_81(object P0, HttpSender.FSendFunc P1); // 0x0000000184DD0B80-0x0000000184DD1880
		public IEnumerator __Gen_Wrap_82(object P0, HttpSender.FSendFunc P1, object P2); // 0x0000000184DD1880-0x0000000184DD2630
		public IEnumerator __Gen_Wrap_83(object P0, HttpSender.FGetOptions P1, object P2, object P3); // 0x0000000184DD2630-0x0000000184DD3400
		public IEnumerator __Gen_Wrap_84(object P0, HttpSender.FGetOptions P1, object P2); // 0x0000000184DD3400-0x0000000184DD4170
		public IEnumerator __Gen_Wrap_85(object P0, HttpSender.FPostOptions P1, object P2, object P3); // 0x0000000184DD4170-0x0000000184DD4F40
		public IEnumerator __Gen_Wrap_86(object P0, HttpSender.FPostOptions P1, object P2); // 0x0000000184DD4F40-0x0000000184DD5CB0
		public void __Gen_Wrap_87(object P0, HttpSender.FSendFunc P1); // 0x0000000184DD5CB0-0x0000000184DD6360
		public HttpSender.Result __Gen_Wrap_88(); // 0x0000000184DD6360-0x0000000184DD6B80
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_89(HttpSender.FSendFunc P0); // 0x0000000184DD6B80-0x0000000184DD7790
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_90(object P0, HttpSender.FPostOptions P1); // 0x0000000184DD7790-0x0000000184DD8450
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_91(object P0, HttpSender.FGetOptions P1); // 0x0000000184DD8450-0x0000000184DD9110
		public WaitForAsyncTask<HttpSender.Result> __Gen_Wrap_92(object P0); // 0x0000000184DD9110-0x0000000184DD9A30
		public int __Gen_Wrap_93(object P0, out bool P1); // 0x00000001836AC960-0x00000001836ACC60
		public string __Gen_Wrap_94(ref HttpSender.FSendFunc P0); // 0x0000000184DD9A30-0x0000000184DDA980
		public EHGNetSessionReconnectState __Gen_Wrap_95(object P0); // 0x0000000182226590-0x0000000182226850
		public void __Gen_Wrap_96(object P0, EHGNetSessionReconnectState P1); // 0x0000000182494990-0x0000000182494C60
		public void __Gen_Wrap_97(ref NetRequest P0); // 0x0000000184DDA980-0x0000000184DDB580
		public void __Gen_Wrap_98(object P0, object P1, ENetCloseReason P2); // 0x0000000182528040-0x00000001825283D0
		public bool __Gen_Wrap_99(object P0, object P1, int P2, bool P3); // 0x00000001836A93B0-0x00000001836A9770
		public void __Gen_Wrap_100(object P0, ENetConnectErrorCode P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_101(object P0, ENetCloseReason P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_102(Task<System.Threading.Tasks.Task> P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_103(object P0, object P1, int P2, bool P3, out HGNetSessionConnectYield P4); // 0x0000000184DA5840-0x0000000184DA6330
		public void __Gen_Wrap_104(object P0, NetRequest P1); // 0x0000000184DA6330-0x0000000184DA69A0
		public void __Gen_Wrap_105(object P0, long P1); // 0x0000000182618CC0-0x0000000182618F90
		public INetIO __Gen_Wrap_106(object P0); // 0x0000000184DA69A0-0x0000000184DA72C0
		public Task<bool> __Gen_Wrap_107(object P0, object P1, int P2); // 0x0000000184DA72C0-0x0000000184DA7D00
		public Task<bool> __Gen_Wrap_108(object P0, object P1, object P2, int P3, int P4, int P5, int P6); // 0x0000000184DA7D00-0x0000000184DA8850
		public System.Threading.Tasks.Task __Gen_Wrap_109(object P0, object P1); // 0x0000000184DA8850-0x0000000184DA9250
		public void __Gen_Wrap_110(object P0, object P1, long P2, int P3); // 0x000000018346F080-0x000000018346F430
		public bool __Gen_Wrap_111(object P0, object P1, int P2); // 0x00000001824E73F0-0x00000001824E7790
		public System.Threading.Tasks.Task __Gen_Wrap_112(); // 0x0000000184DA9250-0x0000000184DA9A70
		public void __Gen_Wrap_113(object P0, object P1, object P2, int P3); // 0x0000000182661FF0-0x0000000182662450
		public void __Gen_Wrap_114(object P0, object P1, long P2, long P3); // 0x000000018323CBC0-0x000000018323CF80
		public byte[] __Gen_Wrap_115(); // 0x0000000184DA9A70-0x0000000184DAA290
		public CLIENT_PLATFORM_TYPE __Gen_Wrap_116(); // 0x00000001825212D0-0x00000001825214A0
		public ENV_TYPE __Gen_Wrap_117(); // 0x00000001825212D0-0x00000001825214A0
		public int __Gen_Wrap_118(); // 0x00000001825212D0-0x00000001825214A0
		public void __Gen_Wrap_119(object P0, object P1, ref NetRequest P2, bool P3); // 0x0000000184DAA290-0x0000000184DAB060
		public bool __Gen_Wrap_120(object P0, object P1, out NetResponse P2, bool P3); // 0x0000000184DAB060-0x0000000184DABB20
		public void __Gen_Wrap_121(object P0, long P1, int P2); // 0x0000000182B98520-0x0000000182B98810
		public byte[] __Gen_Wrap_122(object P0, object P1); // 0x0000000184DABB20-0x0000000184DAC520
		public bool __Gen_Wrap_123(object P0, object P1, object P2); // 0x000000018252A430-0x000000018252A890
		public MSG_A1 __Gen_Wrap_124(object P0); // 0x0000000184DAC520-0x0000000184DACE40
		public HGNetSessionLoginYield __Gen_Wrap_125(object P0, object P1, object P2, int P3); // 0x0000000184DACE40-0x0000000184DAD960
		public void __Gen_Wrap_126(object P0, object P1, ref NetRequest P2); // 0x0000000184DAD960-0x0000000184DAE710
		public bool __Gen_Wrap_127(object P0, object P1, out NetResponse P2); // 0x0000000184DAE710-0x0000000184DAF1B0
		public NetDevProfilerSnapshot __Gen_Wrap_128(object P0); // 0x0000000184DAF1B0-0x0000000184DAFAD0
		public bool __Gen_Wrap_129(object P0, NetResponse P1); // 0x0000000184DAFAD0-0x0000000184DB0180
		public void __Gen_Wrap_130(object P0, object P1, long P2); // 0x0000000182480C90-0x0000000182481030
		public bool __Gen_Wrap_131(CODE P0); // 0x0000000182220AF0-0x0000000182220CF0
		public bool __Gen_Wrap_132(object P0, object P1, NetResponse P2); // 0x0000000184DB0180-0x0000000184DB0910
		public void __Gen_Wrap_133(object P0, object P1, ref NetResponse P2); // 0x0000000184DB0910-0x0000000184DB1720
		public MSG_B1 __Gen_Wrap_134(object P0); // 0x0000000184DB1720-0x0000000184DB2040
		public bool __Gen_Wrap_135(object P0, ref FLogMessage P1); // 0x0000000184DB2040-0x0000000184DB2D60
		public LogLevel __Gen_Wrap_136(ELogLevel P0); // 0x0000000182655FC0-0x00000001826561C0
		public NativeLogLevel __Gen_Wrap_137(ELogLevel P0); // 0x0000000182655FC0-0x00000001826561C0
		public int __Gen_Wrap_138(ELogChannel P0); // 0x0000000182655FC0-0x00000001826561C0
		public bool __Gen_Wrap_139(NativeLogLevel P0, int P1); // 0x0000000182522890-0x0000000182522AA0
		public bool __Gen_Wrap_140(ELogLevel P0, ELogChannel P1); // 0x0000000184985670-0x0000000184985890
		public void __Gen_Wrap_141(object P0, object P1, object P2, UnityEngine.LogType P3); // 0x0000000182661FF0-0x0000000182662450
		public HGNetLoggerClient __Gen_Wrap_142(); // 0x0000000184DB2D60-0x0000000184DB3580
		public bool __Gen_Wrap_143(object P0, ref LogMessage P1); // 0x0000000184DB3580-0x0000000184DB4050
		public void __Gen_Wrap_144(object P0, ref FLogMessage P1); // 0x0000000184DB4050-0x0000000184DB4D60
		public void __Gen_Wrap_145(object P0, ulong P1, ulong P2, ulong P3, ulong P4); // 0x0000000184DB4D60-0x0000000184DB5090
		public void __Gen_Wrap_146(object P0, object P1, object P2, object P3, object P4); // 0x00000001825AC140-0x00000001825AC720
		public void __Gen_Wrap_147(bool P0); // 0x0000000182521C80-0x0000000182521E70
		public void __Gen_Wrap_148(ulong P0); // 0x0000000182232C20-0x0000000182232E10
		public Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> __Gen_Wrap_149(); // 0x0000000184DB5090-0x0000000184DB58B0
		public Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> __Gen_Wrap_150(); // 0x0000000184DB58B0-0x0000000184DB60D0
		public bool __Gen_Wrap_151(object P0, out Beyond.Network.HGNetLogger.MessageType P1); // 0x00000001827B7BC0-0x00000001827B7EC0
		public void __Gen_Wrap_152(object P0, object P1, NetRequest P2); // 0x0000000184DB60D0-0x0000000184DB6820
		public IExtensible __Gen_Wrap_153(Beyond.Network.HGNetLogger.MessageType P0); // 0x0000000184DB6820-0x0000000184DB7080
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object>, IEnumerable<object>, IAsyncStateMachine // TypeDefIndex: 85743
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
		private int methodId_5; // 0x54
		private int methodId_6; // 0x58
		private int methodId_7; // 0x5C
		private int methodId_8; // 0x60
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x000000018CA58804-0x000000018CA588B4 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x000000018CA588B4-0x000000018CA58964 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018CA58964-0x000000018CA58A74
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x00000001887F0184-0x00000001887F0204
		[IDTag(1)]
		private bool MoveNext(); // 0x00000001887EFF14-0x00000001887EFFA4
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x00000001887F0054-0x00000001887F00D4
		[IDTag(5)]
		IEnumerator<object> IEnumerable<object>.GetEnumerator(); // 0x0000000184DE5C90-0x0000000184DE64A0
		[IDTag(6)]
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000184DE64A0-0x0000000184DE6CB0
		[IDTag(7)]
		private void MoveNext(); // 0x000000018CA5850C-0x000000018CA5858C
		[IDTag(8)]
		private void SetStateMachine(IAsyncStateMachine P0); // 0x000000018CA58764-0x000000018CA58804
		public void RefAwaitUnsafeOnCompleteMethod(); // 0x000000018CA58624-0x000000018CA58764
		public void RefAsyncBuilderStartMethod(); // 0x000000018CA5858C-0x000000018CA58624
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 85744
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018CA58C60-0x000000018CA58CC4
		public static bool IsPatched(int id); // 0x000000018CA58D50-0x000000018CA58DCC
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018CA58B18-0x000000018CA58BE4
		public object CreateWrapper(int id); // 0x000000018CA58BE4-0x000000018CA58C60
		public object InitWrapperArray(int len); // 0x000000018CA58CC4-0x000000018CA58D50
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018CA58A74-0x000000018CA58B18
	}

	public delegate Socket __HotPatchDelegate_0(object P0); // TypeDefIndex: 85745; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum HotPatchIDMAP0 // TypeDefIndex: 85746
	{
		Beyond-Network-HGTcpClient-get_Client0 = 0,
		Beyond-Network-HGTcpClient-set_Client0 = 1,
		Beyond-Network-HGTcpClient-Connect0 = 1,
		Beyond-Network-HGTcpClient-EndConnect0 = 1,
		Beyond-Network-HGTcpClient-set_LingerState0 = 1,
		Beyond-Network-NetBus-Setup0 = 1,
		Beyond-Network-NetBus-Send0 = 1,
		Beyond-Network-NetBus-SendAndDispose0 = 1,
		Beyond-Network-NetBus-ResultHandler-SetDisposeCallback0 = 1,
		Beyond-Network-DisposableBusSender-_RemoveResultHandler0 = 1,
		Beyond-Network-NetUtil-_ForeachMessageHandlers0 = 1,
		Beyond-Network-NetworkMask-ListenOnNetMaskChanged0 = 1,
		Beyond-Network-NetworkMask-UnListenOnNetMaskChanged0 = 1,
		Beyond-Network-HttpSender-_SetHttpResult0 = 1,
		Beyond-Network-HttpSender-_MarkResultAsException0 = 1,
		Beyond-Network-HGNetBaseSession-_ApplyWeakNetConfigToTcpIO0 = 1,
		Beyond-Network-HGNetBaseSession-_DNSCheck0 = 1,
		Beyond-Network-HGNetSession-DoReconnectLogin0 = 1,
		Beyond-Network-HGNetSessionLoginYield-SetSucceed0 = 1,
		Beyond-Network-HGNetSession-_SessionLoginThreadTask0 = 1,
		Beyond-Network-HGNetSession-OnConnectedSucceed0 = 1,
		Beyond-Network-HGNetSession-OnReconnectTimesOver0 = 1,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DNSCheck0 = 1,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-OnConnectAsyncEnd0 = 1,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SetReconnectSuccessCallback0 = 1,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-SetNetLogMaskFromServer0 = 1,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-SetCloudLogControl0 = 1,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SendLogin0 = 1,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnConnectedSucceed0 = 1,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-DoReconnectLogin0 = 1,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnReconnectTimesOver0 = 1,
		Beyond-Network-HGTcpClient-get_Active0 = 2,
		Beyond-Network-HGTcpClient-get_Connected0 = 2,
		Beyond-Network-HGTcpClient-get_ExclusiveAddressUse0 = 2,
		Beyond-Network-HGTcpClient-get_NoDelay0 = 2,
		Beyond-Network-HGNetBaseSession-get_isRunning0 = 2,
		Beyond-Network-NetBus-_ValidateSession0 = 2,
		Beyond-Network-NetBus-ResultHandler-_CheckSessionIDValid0 = 2,
		Beyond-Network-Special2BusSender-get_isBusBusy0 = 2,
		Beyond-Network-InteractiveBusSender-get_isBusBusy0 = 2,
		Beyond-Network-TcpIO-IsConnected0 = 2,
		Beyond-Network-TcpIO-IsAuthed0 = 2,
		Beyond-Network-HttpSender-Cancellation-IsCanceled0 = 2,
		Beyond-Network-HGNetBaseSession-get_isConnecting0 = 2,
		Beyond-Network-HGNetBaseSession-get_isRunningAndConnected0 = 2,
		Beyond-Network-HGNetBaseSession-get_isReconnecting0 = 2,
		Beyond-Network-HGNetBaseSession-get_isAutoReconnect0 = 2,
		Beyond-Network-HGNetSession-NeedKeepConnect0 = 2,
		Beyond-Network-HGNetSession-IsPingInProgress0 = 2,
		Beyond-Network-HGNetSession-IsPingOut0 = 2,
		Beyond-Network-HGNetSessionLoginYield-get_isSucceed0 = 2,
		Beyond-Network-HGNetSessionLoginYield-get_keepWaiting0 = 2,
		Beyond-Network-HGNetSessionConnectYield-get_isSucceed0 = 2,
		Beyond-Network-HGNetSessionConnectYield-get_keepWaiting0 = 2,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_isRunning0 = 2,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_isConnecting0 = 2,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_isRunningAndConnected0 = 2,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_isAutoReconnect0 = 2,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-NeedKeepConnect0 = 2,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-IsPingOut0 = 2,
		Beyond-Network-HGTcpClient-set_Active0 = 3,
		Beyond-Network-HGTcpClient-set_ExclusiveAddressUse0 = 3,
		Beyond-Network-HGTcpClient-Dispose0 = 3,
		Beyond-Network-HGTcpClient-set_NoDelay0 = 3,
		Beyond-Network-NetBus-ResultHandler-SetIgnoreSeq0 = 3,
		Beyond-Network-TcpIO-TestCloseNetIO0 = 3,
		Beyond-Network-HGNetSession-OnApplicationPause0 = 3,
		Beyond-Network-HGNetSession-OnApplicationFocus0 = 3,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-OnApplicationPause0 = 3,
		Beyond-Network-HGTcpClient-get_Available0 = 4,
		Beyond-Network-HGTcpClient-get_ReceiveBufferSize0 = 4,
		Beyond-Network-HGTcpClient-get_SendBufferSize0 = 4,
		Beyond-Network-HGTcpClient-get_ReceiveTimeout0 = 4,
		Beyond-Network-HGTcpClient-get_SendTimeout0 = 4,
		Beyond-Network-NetBus-get_currentSessionID0 = 4,
		Beyond-Network-NetUtil-GetCSMsgIdByType0 = 4,
		Beyond-Network-NetworkMask-_GetKey0 = 4,
		Beyond-Network-NetUtil-GetSCMsgIdByType0 = 4,
		Beyond-Network-TcpIO-GetReceiveBufferOffset0 = 4,
		Beyond-Network-TcpIO-Available0 = 4,
		Beyond-Network-HGNetBaseSession-get_closeErrorCode0 = 4,
		Beyond-Network-HGNetBaseSession-get_maxRecycleQueueCount0 = 4,
		Beyond-Network-HGNetBaseSession-GetSendQueueMsgCount0 = 4,
		Beyond-Network-HGNetSession-GetPing0 = 4,
		Beyond-Network-HGNetSessionLoginYield-GetErrorCode0 = 4,
		Beyond-Network-HGNetSessionConnectYield-GetCode0 = 4,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-get_closeErrorCode0 = 4,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetSendQueueMsgCount0 = 4,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_GetConnectTimeoutTime0 = 4,
		Beyond-Network-HGTcpClient-Connect1 = 5,
		Beyond-Network-HGTcpClient-Connect2 = 5,
		Beyond-Network-HGTcpClient-Connect3 = 5,
		Beyond-Network-HGNetBaseSession-InternalClose0 = 5,
		Beyond-Network-HGTcpClient-BeginConnect0 = 6,
		Beyond-Network-HGTcpClient-BeginConnect1 = 6,
		Beyond-Network-HGTcpClient-BeginConnect2 = 6,
		Beyond-Network-HGTcpClient-ConnectAsync0 = 7,
		Beyond-Network-HGTcpClient-ConnectAsync1 = 7,
		Beyond-Network-HGTcpClient-ConnectAsync2 = 7,
		Beyond-Network-HGNetBaseSession-_SessionThread0 = 7,
		Beyond-Network-HGTcpClient-GetStream0 = 8,
		Beyond-Network-HGTcpClient-Close0 = 9,
		Beyond-Network-HGTcpClient-Dispose1 = 9,
		Beyond-Network-HGTcpClient-_Initialize0 = 9,
		Beyond-Network-NetBus-DisposeSentMessage0 = 9,
		Beyond-Network-NetBus-OnNetClientShutDown0 = 9,
		Beyond-Network-NetBus-ResultHandler-Dispose0 = 9,
		Beyond-Network-DisposableBusSender-_Clear0 = 9,
		Beyond-Network-DisposableBusSender-OnNetShutDown0 = 9,
		Beyond-Network-Special2BusSender-_ClearSendTime0 = 9,
		Beyond-Network-Special2BusSender-OnNetShutDown0 = 9,
		Beyond-Network-DisposableBusSender-Dispose0 = 9,
		Beyond-Network-Special2BusSender-Dispose0 = 9,
		Beyond-Network-NetworkMaskConfigHolder-_LoadScriptableObjectConfig0 = 9,
		Beyond-Network-NetworkMaskConfigHolder-Init0 = 9,
		Beyond-Network-NetworkMaskConfigHolder-Dispose0 = 9,
		Beyond-Network-NetworkMask-_UpdateMaskState0 = 9,
		Beyond-Network-UIBusSender-Dispose0 = 9,
		Beyond-Network-UIBusSender-OnNetShutDown0 = 9,
		Beyond-Network-TeleportMaskSender-Dispose0 = 9,
		Beyond-Network-TeleportMaskSender-OnNetShutDown0 = 9,
		Beyond-Network-FrequencyControlBusSender-_ClearWaitingSendMsgs0 = 9,
		Beyond-Network-FrequencyControlBusSender-Dispose0 = 9,
		Beyond-Network-NetUtil-_ResetHead0 = 9,
		Beyond-Network-NetUtil-_DisposeMessage0 = 9,
		Beyond-Network-NetUtil-AutoRegisterMessageHandlers0 = 9,
		Beyond-Network-NetUtil-AutoUnRegisterMessageHandlers0 = 9,
		Beyond-Network-NetworkMask-_CreateMaskObject0 = 9,
		Beyond-Network-NetworkMask-_CreateTickFunction0 = 9,
		Beyond-Network-NetworkMask-_OnSwitchLanguage0 = 9,
		Beyond-Network-NetworkMask-OnInit0 = 9,
		Beyond-Network-NetworkMask-_ClearTickFunction0 = 9,
		Beyond-Network-NetworkMask-OnUnInit0 = 9,
		Beyond-Network-NetworkMask-Release0 = 9,
		Beyond-Network-TcpIO-Close0 = 9,
		Beyond-Network-TcpIO-MarkAuthed0 = 9,
		Beyond-Network-TcpIO-ClearReceiveBufferOffset0 = 9,
		Beyond-Network-TcpIO-Dispose0 = 9,
		Beyond-Network-HttpSender-_DeserializeTypedResult0 = 9,
		Beyond-Network-HttpSender-_WaitForServiceDone0 = 9,
		Beyond-Network-HttpSender-Cancellation-Cancel0 = 9,
		Beyond-Network-HGNetBaseSession-Start0 = 9,
		Beyond-Network-HGNetBaseSession-DisposeMessage0 = 9,
		Beyond-Network-HGNetBaseSession-DisposeLastLoginMessage0 = 9,
		Beyond-Network-HGNetBaseSession-RemoveAutoReconnect0 = 9,
		Beyond-Network-HGNetBaseSession-CloseTCPMsgThreadTask0 = 9,
		Beyond-Network-HGNetBaseSession-DisposeCircularBuffer0 = 9,
		Beyond-Network-HGNetBaseSession-DisposeSendQueue0 = 9,
		Beyond-Network-HGNetBaseSession-StartTCPMsgLoopThreadTask0 = 9,
		Beyond-Network-HGNetBaseSession-OpenAutoReconnect0 = 9,
		Beyond-Network-HGNetSession-_CSLoginHelper_UpdateAppInfo0 = 9,
		Beyond-Network-HGNetSession-Start0 = 9,
		Beyond-Network-HGNetSession-_RequestTimeCalibration0 = 9,
		Beyond-Network-HGNetSession-_FlushMergeQueueToSendQueue0 = 9,
		Beyond-Network-HGNetSession-_DisposeMergeQueueCache0 = 9,
		Beyond-Network-HGNetSession-_DisposeFrameSendQueue0 = 9,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectError0 = 9,
		Beyond-Network-HGNetSessionLoginYield-SetConnectErrorError0 = 9,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Clear0 = 9,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorConnectTimeOut0 = 9,
		Beyond-Network-HGNetSessionLoginYield-SetTimeOutError0 = 9,
		Beyond-Network-HGNetSession-StartMsgLoop0 = 9,
		Beyond-Network-HGNetSession-ClearRecvQueue0 = 9,
		Beyond-Network-HGNetSession-ClearSendQueue0 = 9,
		Beyond-Network-HGNetSession-ClearPingWDG0 = 9,
		Beyond-Network-HGNetSession-_DispatchServerTimeCalibrationEventsInGameThread0 = 9,
		Beyond-Network-HGNetSession-InitClientRSAKey0 = 9,
		Beyond-Network-HGNetSession-ClearRSAKey0 = 9,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-SetErrorInvaild0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Start0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-RemoveAutoReconnect0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-CloseTCPMsgThreadTask0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DisposeSendQueue0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DisposeCircularBuffer0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_ReconnectCheckerTick0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-SessionCheckSignalAndSleep0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_SessionThread0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-StartTCPMsgLoopThreadTask0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-OpenAutoReconnect0 = 9,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-_FlushLocalLogQueue0 = 9,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-ShutDown0 = 9,
		Beyond-Network-HGNetLogger-HGNetLogger-Clear0 = 9,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-Start0 = 9,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearPingWDG0 = 9,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-InitClientRSAKey0 = 9,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRSAKey0 = 9,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearRecvQueue0 = 9,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ClearSendQueue0 = 9,
		Beyond-Network-HGTcpClient-_NumericOption0 = 10,
		Beyond-Network-HGTcpClient-set_ReceiveBufferSize0 = 11,
		Beyond-Network-HGTcpClient-set_SendBufferSize0 = 11,
		Beyond-Network-HGTcpClient-set_ReceiveTimeout0 = 11,
		Beyond-Network-HGTcpClient-set_SendTimeout0 = 11,
		Beyond-Network-NetBus-UnRegisterMessageHandler0 = 11,
		Beyond-Network-NetworkMask-RemoveMask0 = 11,
		Beyond-Network-NetUtil-_RecordFactoryHsPoolStats0 = 11,
		Beyond-Network-TcpIO-SkipReceiveBufferOffset0 = 11,
		Beyond-Network-HGNetBaseSession-SessionCheckSignalAndSleep0 = 11,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close0 = 11,
		Beyond-Network-HGTcpClient-get_LingerState0 = 12,
		Beyond-Network-LuaProtoUtil-AllocateCSGMCommand0 = 13,
		Beyond-Network-LuaProtoUtil-AllocateCSDungeonRecoverAP0 = 14,
		Beyond-Network-LuaProtoUtil-AllocateItemBundle0 = 15,
		Beyond-Network-LuaProtoUtil-AllocateInstItemBundle0 = 16,
		Beyond-Network-NetBus-CloneMessageForSendOwner0 = 17,
		Beyond-Network-HGNetBaseSession-CloneRequestMessageForSend0 = 17,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_CloneMessage0 = 17,
		Beyond-Network-HGNetBaseSession-IncrementCSSeqID0 = 18,
		Beyond-Network-HGNetBaseSession-GetCSSeqID0 = 18,
		Beyond-Network-HGNetSession-GetPingPassedTime0 = 18,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-IncrementCSSeqID0 = 18,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetCSSeqID0 = 18,
		Beyond-Network-HGNetSession-SendMessage0 = 19,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SendMessage0 = 19,
		Beyond-Network-NetUtil-GetSCMsgTypeById0 = 20,
		Beyond-Network-NetBus-RegisterMessageHandler0 = 21,
		Beyond-Network-NetBus-_Listen0 = 21,
		Beyond-Network-NetBus-_UnListen0 = 21,
		Beyond-Network-NetBus-_UnListenWithSeqNum0 = 21,
		Beyond-Network-HGNetSessionLoginYield-LoginErrorInfo-Set0 = 21,
		Beyond-Network-HGNetSessionLoginYield-SetNtfError0 = 21,
		Beyond-Network-NetBus-_SendWithResult0 = 22,
		Beyond-Network-NetBus-Sender-SendAndDispose0 = 22,
		Beyond-Network-NetBus-Sender-DoSend0 = 22,
		Beyond-Network-DisposableBusSender-Send0 = 22,
		Beyond-Network-Special2BusSender-Send0 = 22,
		Beyond-Network-UIBusSender-Send0 = 22,
		Beyond-Network-FrequencyControlBusSender-Send1 = 22,
		Beyond-Network-NetResponse-_CreateCSHeadSnapshot0 = 23,
		Beyond-Network-NetResponse-get_csHead0 = 23,
		Beyond-Network-NetResponse-get_csSeqId0 = 24,
		Beyond-Network-NetResponse-get_scSeqId0 = 24,
		Beyond-Network-NetResponse-get_msgId0 = 25,
		Beyond-Network-NetBus-ResultHandler-_HandleMessage0 = 26,
		Beyond-Network-NetBus-ResultHandler-OnResponse0 = 27,
		Beyond-Network-NetBus-Sender-DoListen0 = 28,
		Beyond-Network-NetBus-Sender-DoUnListen0 = 28,
		Beyond-Network-NetResponse-get_headMsg0 = 29,
		Beyond-Network-NetResponse-_CopyCSHeadSnapshot0 = 30,
		Beyond-Network-NetResponse-set_headMsg0 = 30,
		Beyond-Network-NetResponse-set_logHead0 = 30,
		Beyond-Network-NetResponse-set_csHead0 = 30,
		Beyond-Network-NetResponse-SetCSHeadSnapshot0 = 30,
		Beyond-Network-NetResponse-get_logHead0 = 31,
		Beyond-Network-NetResponse-DisposeHeadMessage0 = 32,
		Beyond-Network-NetResponse-DisposeOwnedMessages0 = 32,
		Beyond-Network-NetResponse-Dispose0 = 32,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DisposeResponseMessage0 = 32,
		Beyond-Network-NetworkMaskConfigHolder-_LoadJsonConfig0 = 33,
		Beyond-Network-NetworkMask-MaskInfo-get_endTime0 = 34,
		Beyond-Network-NetworkMask-MaskInfo-get_showDecoTime0 = 34,
		Beyond-Network-NetworkMask-AddMask0 = 35,
		Beyond-Network-NetworkMask-AddMask1 = 36,
		Beyond-Network-TeleportMaskSender-Send0 = 37,
		Beyond-Network-TeleportMaskSender-SendAndDispose0 = 37,
		Beyond-Network-FrequencyControlBusSender-_DoSendNow0 = 38,
		Beyond-Network-FrequencyControlBusSender-_Send0 = 39,
		Beyond-Network-FrequencyControlBusSender-Send0 = 39,
		Beyond-Network-FrequencyControlBusSender-SendAndDispose0 = 39,
		Beyond-Network-FrequencyControlBusSender-_TrySendWaitingMsg0 = 40,
		Beyond-Network-NetworkMask-PreTick0 = 40,
		Beyond-Network-ServerConfig-IsSame0 = 41,
		Beyond-Network-NetProtoCodec-MergeSC0 = 42,
		Beyond-Network-NetProtoCodec-TryWriteCS0 = 43,
		Beyond-Network-NetUtil-GetFactoryHsPoolStats0 = 44,
		Beyond-Network-NetUtil-ResetFactoryHsPoolStats0 = 45,
		Beyond-Network-NetUtil-StartProtoAotWarmupInBackground0 = 45,
		Beyond-Network-NetUtil-FastRegisterMessage0 = 45,
		Beyond-Network-NetUtil-RegisterSCMessage0 = 46,
		Beyond-Network-NetUtil-RegisterCSMessage0 = 46,
		Beyond-Network-NetUtil-_PrewarmFactoryContent0 = 47,
		Beyond-Network-NetUtil-_PrewarmFactoryProtoPools0 = 47,
		Beyond-Network-NetUtil-_GetProtoClassWarmupSteps0 = 48,
		Beyond-Network-NetUtil-_WarmupProtoAotInBackground0 = 49,
		Beyond-Network-NetUtil-_PrewarmProtoClassesOnMainThread0 = 50,
		Beyond-Network-NetUtil-WaitForProtoAotWarmup0 = 50,
		Beyond-Network-NetUtil-TryGetProtoAotWarmupException0 = 51,
		Beyond-Network-NetUtil-_GetRecvHead0 = 52,
		Beyond-Network-NetUtil-_GetSendHead0 = 52,
		Beyond-Network-NetUtil-_BuildExceptionSummary0 = 53,
		Beyond-Network-NetworkUrls-ResourceRootUrlDev0 = 53,
		Beyond-Network-HGNetSessionLoginYield-GetErrorDetails0 = 53,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_uid0 = 53,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_roleId0 = 53,
		Beyond-Network-NetUtil-_LogDeserializeError0 = 54,
		Beyond-Network-NetUtil-GetNetMessageFromDataBytes0 = 55,
		Beyond-Network-NetUtil-SerializeHeadMessage0 = 56,
		Beyond-Network-NetworkUrls-RemoteConfigUrl0 = 57,
		Beyond-Network-NetworkUrls-ServerListUrl0 = 57,
		Beyond-Network-NetworkUrls-AgeTipsUrl0 = 57,
		Beyond-Network-NetworkUrls-GovUrl0 = 57,
		Beyond-Network-NetworkUrls-LauncherUrl0 = 57,
		Beyond-Network-HGNetSession-_GetOnlineResVersion0 = 57,
		Beyond-Network-NetworkUrls-_GetUrlFromLocal0 = 58,
		Beyond-Network-NetworkUrls-_SelectUrl0 = 59,
		Beyond-Network-TcpIO-Connect0 = 60,
		Beyond-Network-TcpIO-ConnectAsync0 = 61,
		Beyond-Network-TcpIO-EnableCryptStream0 = 62,
		Beyond-Network-HGNetBaseSession-OnConnectAsyncEnd0 = 62,
		Beyond-Network-TcpIO-GetEndPoint0 = 63,
		Beyond-Network-TcpIO-TestDropNetIO0 = 64,
		Beyond-Network-TcpIO-_CreateWeakNetDelayConfig0 = 65,
		Beyond-Network-TcpIO-_ResetWeakNetWindow0 = 66,
		Beyond-Network-TcpIO-SetWeakNetCustom0 = 67,
		Beyond-Network-HGNetBaseSession-SetWeakNetCustom0 = 67,
		Beyond-Network-TcpIO-SetWeakNetPreset0 = 68,
		Beyond-Network-HGNetBaseSession-SetWeakNetPreset0 = 68,
		Beyond-Network-TcpIO-GetProfilerSnapshot0 = 69,
		Beyond-Network-TcpIO-_NextDelayMs0 = 70,
		Beyond-Network-TcpIO-_ApplyWeakNetDelay0 = 71,
		Beyond-Network-TcpIO-WriteData0 = 72,
		Beyond-Network-TcpIO-WriteCryptoData0 = 72,
		Beyond-Network-TcpIO-GetSendHeadBuffer0 = 73,
		Beyond-Network-TcpIO-GetSendBuffer0 = 73,
		Beyond-Network-TcpIO-GetReceiveBuffer0 = 73,
		Beyond-Network-TcpIO-ReadData0 = 74,
		Beyond-Network-TcpIO-ReadCryptoData0 = 74,
		Beyond-Network-HttpSender-FSendFunc-GetCancellation0 = 75,
		Beyond-Network-HttpSender-_CreateWebRequestGET0 = 76,
		Beyond-Network-HttpSender-_CreateWebRequestPOST0 = 77,
		Beyond-Network-HttpSender-FSendFunc-Invoke0 = 78,
		Beyond-Network-HttpSender-_YieldSendHttpRequest0 = 79,
		Beyond-Network-HttpSender-_YieldSendHttpRequest1 = 80,
		Beyond-Network-HttpSender-YieldSendGet0 = 81,
		Beyond-Network-HttpSender-YieldSendGet1 = 82,
		Beyond-Network-HttpSender-YieldSendPost0 = 83,
		Beyond-Network-HttpSender-YieldSendPost1 = 84,
		Beyond-Network-HttpSender-_StartWebRequestTask0 = 85,
		Beyond-Network-HttpSender-_DebugOnlyProfileResult0 = 85,
		Beyond-Network-HttpSender-_WaitForSendHttpRequest0 = 86,
		Beyond-Network-HttpSender-WaitForSendPost0 = 87,
		Beyond-Network-HttpSender-WaitForSendGet0 = 88,
		Beyond-Network-HttpSender-WaitForSendGet1 = 89,
		Beyond-Network-HttpSender-GetGeneralErrorCode0 = 90,
		Beyond-Network-HttpSender-FSendFunc-GetOptMethod0 = 91,
		Beyond-Network-HGNetBaseSession-get_reconnectState0 = 92,
		Beyond-Network-HGNetBaseSession-set_reconnectState0 = 93,
		Beyond-Network-HGNetBaseSession-DisposeRequestMessage0 = 94,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-_DisposeRequestMessage0 = 94,
		Beyond-Network-HGNetBaseSession-InternalClose1 = 95,
		Beyond-Network-HGNetBaseSession-Connect0 = 96,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Connect0 = 96,
		Beyond-Network-HGNetSessionConnectYield-SetFinish0 = 97,
		Beyond-Network-HGNetBaseSession-Close0 = 98,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-Close1 = 98,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-_CloseAndClear0 = 98,
		Beyond-Network-HGNetBaseSession-ConnectAsync0 = 99,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-ConnectAsync0 = 99,
		Beyond-Network-HGNetBaseSession-EnqueueSendMsg0 = 100,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-EnqueueSendMsg0 = 100,
		Beyond-Network-HGNetBaseSession-SetCSSeqID0 = 101,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-SetCSSeqID0 = 101,
		Beyond-Network-HGNetBaseSession-GetIO0 = 102,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-GetIO0 = 102,
		Beyond-Network-HGNetBaseSession-TryCloseTcpIOWithTimeout0 = 103,
		Beyond-Network-HGNetBaseSession-TryConnectWithTimeout0 = 104,
		Beyond-Network-HGNetBaseSession-_DoReconnectAsync0 = 105,
		Beyond-Network-HGNetBaseSession-_ReconnectCheckerTick0 = 105,
		Beyond-Network-HGNetBaseSession-NetStatusChecker_Receive0 = 106,
		Beyond-Network-HGNetBaseSession-NetStatusChecker_Sender0 = 106,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Receive0 = 106,
		Beyond-Network-HGNetLogger-HGNetLogBaseSession-NetStatusChecker_Sender0 = 106,
		Beyond-Network-HGNetBaseSession-_ReadAndCheckMessageInSessionThread0 = 107,
		Beyond-Network-HGNetBaseSession-_SendAndCheckMessage0 = 107,
		Beyond-Network-HGNetSession-SetAutoReconnectToken0 = 108,
		Beyond-Network-HGNetSession-SessionConnectTimeoutCheckerTick0 = 109,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SessionConnectTimeoutCheckerTick0 = 109,
		Beyond-Network-HGNetSession-GetClientPublicKey0 = 110,
		Beyond-Network-HGNetSession-_GetPlatformID0 = 111,
		Beyond-Network-HGNetSession-_GetSDKEnv0 = 112,
		Beyond-Network-HGNetSession-_GetPayPlatform0 = 113,
		Beyond-Network-HGNetSession-_WriteMessageInSessionThread0 = 114,
		Beyond-Network-HGNetSession-_ReadMessageInSessionThread0 = 115,
		Beyond-Network-HGNetSession-_ApproximateLoginServerTime0 = 116,
		Beyond-Network-HGNetSession-_RSADecrypt0 = 117,
		Beyond-Network-HGNetSession-_HandleLoginEncryp0 = 118,
		Beyond-Network-HGNetSessionLoginYield-GetRequest0 = 119,
		Beyond-Network-HGNetSession-LoginAsync0 = 120,
		Beyond-Network-HGNetSession-CheckAndWriteReqMsg0 = 121,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndWriteReqMsg0 = 121,
		Beyond-Network-HGNetSession-ReadMessageInSessionThread0 = 122,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-ReadMessageInSessionThread0 = 122,
		Beyond-Network-HGNetSession-GetNetDevProfilerSnapshot0 = 123,
		Beyond-Network-HGNetSession-_HandleSpecialMessagePing0 = 124,
		Beyond-Network-HGNetSession-PingSenderTick0 = 125,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-PingSenderTick0 = 125,
		Beyond-Network-HGNetSessionUtils-CheckErrorNeedsDisconnect0 = 126,
		Beyond-Network-HGNetSession-_HandleSpecialMessageErrorCode0 = 127,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectIncr0 = 127,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectFull0 = 127,
		Beyond-Network-HGNetSession-_HandleSpecialMessageReconnectLogin0 = 127,
		Beyond-Network-HGNetSession-CheckAndDealRespMessages0 = 128,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-CheckAndDealRespMessages0 = 128,
		Beyond-Network-HGNetSessionLoginYield-GetResponse0 = 129,
		Beyond-Network-HGNetLogger-HGNetLogger-CheckLog0 = 130,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger0 = 131,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLoggerV20 = 132,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-ConvertFromDLogger0 = 132,
		Beyond-Network-HGNetLogger-HGNetLogger-ConvertFromDLogger1 = 133,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled0 = 134,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsNetLogLevelEnabled1 = 135,
		Beyond-Network-HGNetLogger-HGNetLoggerCloudSettings-IsLocalLogLevelEnabled0 = 135,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-AddLog0 = 136,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-get_instance0 = 137,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-WriteNetLog0 = 138,
		Beyond-Network-HGNetLogger-HGNetLogger-Log0 = 139,
		Beyond-Network-HGNetLogger-HGNetLogger-SetLogChannel0 = 140,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-SetAutoReconnectToken0 = 141,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-Init0 = 141,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-OnApplicationPause0 = 142,
		Beyond-Network-HGNetLogger-HGNetLoggerClient-SetRoleID0 = 143,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageType2Id0 = 144,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-get_s_messageId2Type0 = 145,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-TryGetMsgTypeByID0 = 146,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_WriteMessageInSessionThread0 = 147,
		Beyond-Network-HGNetLogger-HGNetLoggerSession-_CreateLoggerMessage0 = 148
	}

	public delegate void __HotPatchDelegate_1(object P0, object P1); // TypeDefIndex: 85747; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_2(object P0); // TypeDefIndex: 85748; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_3(object P0, bool P1); // TypeDefIndex: 85749; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_4(object P0); // TypeDefIndex: 85750; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_5(object P0, object P1, int P2); // TypeDefIndex: 85751; 0x00000001811DF7F0-0x00000001811DF810

	public delegate IAsyncResult __HotPatchDelegate_6(object P0, object P1, int P2, object P3, object P4); // TypeDefIndex: 85752; 0x00000001812083C0-0x00000001812083E0

	public delegate System.Threading.Tasks.Task __HotPatchDelegate_7(object P0, object P1, int P2); // TypeDefIndex: 85753; 0x00000001811DF7F0-0x00000001811DF810

	public delegate NetworkStream __HotPatchDelegate_8(object P0); // TypeDefIndex: 85754; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_9(object P0); // TypeDefIndex: 85755; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_10(object P0, SocketOptionLevel P1, SocketOptionName P2); // TypeDefIndex: 85756; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_11(object P0, int P1); // TypeDefIndex: 85757; 0x00000001859B7730-0x00000001859B7740

	public delegate LingerOption __HotPatchDelegate_12(object P0); // TypeDefIndex: 85758; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate CS_GM_COMMAND __HotPatchDelegate_13(); // TypeDefIndex: 85759; 0x0000000185B44B70-0x0000000185B44B80

	public delegate CS_DUNGEON_RECOVER_AP __HotPatchDelegate_14(); // TypeDefIndex: 85760; 0x0000000185B44B70-0x0000000185B44B80

	public delegate ITEM_BUNDLE __HotPatchDelegate_15(); // TypeDefIndex: 85761; 0x0000000185B44B70-0x0000000185B44B80

	public delegate INST_ITEM_BUNDLE __HotPatchDelegate_16(); // TypeDefIndex: 85762; 0x0000000185B44B70-0x0000000185B44B80

	public delegate IExtensible __HotPatchDelegate_17(object P0); // TypeDefIndex: 85763; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate long __HotPatchDelegate_18(object P0); // TypeDefIndex: 85764; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ulong __HotPatchDelegate_19(object P0, object P1); // TypeDefIndex: 85765; 0x00000001859B7730-0x00000001859B7740

	public delegate System.Type __HotPatchDelegate_20(int P0); // TypeDefIndex: 85766; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_21(object P0, int P1, object P2); // TypeDefIndex: 85767; 0x00000001811DF7F0-0x00000001811DF810

	public delegate NetBus.ResultHandler __HotPatchDelegate_22(object P0, object P1); // TypeDefIndex: 85768; 0x00000001859B7730-0x00000001859B7740

	public delegate CSHead __HotPatchDelegate_23(ref NetResponse P0); // TypeDefIndex: 85769; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ulong __HotPatchDelegate_24(ref NetResponse P0); // TypeDefIndex: 85770; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_25(ref NetResponse P0); // TypeDefIndex: 85771; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_26(object P0, in NetResponse P1); // TypeDefIndex: 85772; 0x00000001859B7730-0x00000001859B7740

	public delegate NetBus.ResultHandler __HotPatchDelegate_27(object P0, SCMessageID P1, object P2); // TypeDefIndex: 85773; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_28(object P0, SCMessageID P1, object P2); // TypeDefIndex: 85774; 0x00000001811DF7F0-0x00000001811DF810

	public delegate object __HotPatchDelegate_29(ref NetResponse P0); // TypeDefIndex: 85775; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_30(ref NetResponse P0, object P1); // TypeDefIndex: 85776; 0x00000001859B7730-0x00000001859B7740

	public delegate Header __HotPatchDelegate_31(ref NetResponse P0); // TypeDefIndex: 85777; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_32(ref NetResponse P0); // TypeDefIndex: 85778; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_33(object P0, StringPathHash P1); // TypeDefIndex: 85779; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_34(object P0); // TypeDefIndex: 85780; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_35(object P0, object P1, float P2, float P3); // TypeDefIndex: 85781; 0x000000018129E8F0-0x000000018129E910

	public delegate int __HotPatchDelegate_36(object P0, CSMessageID P1, float P2); // TypeDefIndex: 85782; 0x000000018124EAD0-0x000000018124EAF0

	public delegate NetBus.ResultHandler __HotPatchDelegate_37(object P0, object P1, float P2); // TypeDefIndex: 85783; 0x000000018124EAD0-0x000000018124EAF0

	public delegate NetBus.ResultHandler __HotPatchDelegate_38(object P0, object P1, CSMessageID P2, object P3); // TypeDefIndex: 85784; 0x00000001811CDB70-0x00000001811CDB90

	public delegate NetBus.ResultHandler __HotPatchDelegate_39(object P0, object P1, bool P2, object P3, object P4); // TypeDefIndex: 85785; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_40(object P0, float P1); // TypeDefIndex: 85786; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_41(object P0, object P1); // TypeDefIndex: 85787; 0x00000001859B7730-0x00000001859B7740

	public delegate IExtensible __HotPatchDelegate_42(int P0, object P1, object P2, int P3, int P4); // TypeDefIndex: 85788; 0x00000001812083C0-0x00000001812083E0

	public delegate bool __HotPatchDelegate_43(object P0, object P1, object P2, int P3, out int P4); // TypeDefIndex: 85789; 0x00000001812083C0-0x00000001812083E0

	public delegate NetUtil.FFactoryHsPoolStats __HotPatchDelegate_44(); // TypeDefIndex: 85790; 0x0000000181216FA0-0x0000000181216FF0

	public delegate void __HotPatchDelegate_45(); // TypeDefIndex: 85791; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_46(int P0, object P1); // TypeDefIndex: 85792; 0x00000001859B7730-0x00000001859B7740

	public delegate IEnumerable<object> __HotPatchDelegate_47(bool P0); // TypeDefIndex: 85793; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerable<object> __HotPatchDelegate_48(); // TypeDefIndex: 85794; 0x0000000185B44B70-0x0000000185B44B80

	public delegate long __HotPatchDelegate_49(); // TypeDefIndex: 85795; 0x0000000185B44B70-0x0000000185B44B80

	public delegate IEnumerator __HotPatchDelegate_50(); // TypeDefIndex: 85796; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_51(out Exception P0); // TypeDefIndex: 85797; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate CSHead __HotPatchDelegate_52(); // TypeDefIndex: 85798; 0x0000000185B44B70-0x0000000185B44B80

	public delegate string __HotPatchDelegate_53(object P0); // TypeDefIndex: 85799; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_54(object P0, object P1, int P2, int P3, object P4); // TypeDefIndex: 85800; 0x00000001812083C0-0x00000001812083E0

	public delegate bool __HotPatchDelegate_55(Span<byte> P0, object P1, int P2, int P3, object P4, out NetResponse P5); // TypeDefIndex: 85801; 0x0000000184DE6E80-0x0000000184DE6ED0

	public delegate int __HotPatchDelegate_56(object P0, ulong P1, int P2, int P3, object P4, int P5); // TypeDefIndex: 85802; 0x0000000181256340-0x0000000181256360

	public delegate string __HotPatchDelegate_57(); // TypeDefIndex: 85803; 0x0000000185B44B70-0x0000000185B44B80

	public delegate string __HotPatchDelegate_58(NetworkUrls.EUrlType P0); // TypeDefIndex: 85804; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_59(object P0, NetworkUrls.EUrlType P1); // TypeDefIndex: 85805; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_60(object P0, object P1, int P2, int P3, int P4, int P5); // TypeDefIndex: 85806; 0x0000000181256340-0x0000000181256360

	public delegate System.Threading.Tasks.Task __HotPatchDelegate_61(object P0, object P1, int P2, int P3, int P4, int P5); // TypeDefIndex: 85807; 0x0000000181256340-0x0000000181256360

	public delegate void __HotPatchDelegate_62(object P0, object P1, object P2); // TypeDefIndex: 85808; 0x00000001811DF7F0-0x00000001811DF810

	public delegate EndPoint __HotPatchDelegate_63(object P0); // TypeDefIndex: 85809; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_64(object P0, bool P1, bool P2); // TypeDefIndex: 85810; 0x00000001811DF7F0-0x00000001811DF810

	public delegate TcpIO.WeakNetDelayConfig __HotPatchDelegate_65(int P0, int P1, int P2); // TypeDefIndex: 85811; 0x00000001812D51A0-0x00000001812D51E0

	public delegate void __HotPatchDelegate_66(ref long P0, ref int P1); // TypeDefIndex: 85812; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_67(object P0, int P1, int P2, int P3, int P4, int P5, int P6); // TypeDefIndex: 85813; 0x00000001811C5A40-0x00000001811C5A60

	public delegate void __HotPatchDelegate_68(object P0, ENetWeakNetPreset P1); // TypeDefIndex: 85814; 0x00000001859B7730-0x00000001859B7740

	public delegate TcpIOProfilerSnapshot __HotPatchDelegate_69(object P0); // TypeDefIndex: 85815; 0x00000001826DF910-0x00000001826DF960

	public delegate int __HotPatchDelegate_70(TcpIO.WeakNetDelayConfig P0); // TypeDefIndex: 85816; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate void __HotPatchDelegate_71(object P0, TcpIO.WeakNetDelayConfig P1, ref long P2, ref int P3); // TypeDefIndex: 85817; 0x00000001826E9F90-0x00000001826E9FD0

	public delegate void __HotPatchDelegate_72(object P0, object P1, int P2, int P3); // TypeDefIndex: 85818; 0x00000001811CDB70-0x00000001811CDB90

	public delegate byte[] __HotPatchDelegate_73(object P0); // TypeDefIndex: 85819; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_74(object P0, object P1, int P2, int P3); // TypeDefIndex: 85820; 0x00000001811CDB70-0x00000001811CDB90

	public delegate HttpSender.Cancellation __HotPatchDelegate_75(ref HttpSender.FSendFunc P0); // TypeDefIndex: 85821; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UnityWebRequest __HotPatchDelegate_76(object P0, HttpSender.FGetOptions P1); // TypeDefIndex: 85822; 0x00000001827C6B90-0x00000001827C6BC0

	public delegate UnityWebRequest __HotPatchDelegate_77(object P0, HttpSender.FPostOptions P1); // TypeDefIndex: 85823; 0x00000001827C6B90-0x00000001827C6BC0

	public delegate UnityWebRequest __HotPatchDelegate_78(ref HttpSender.FSendFunc P0); // TypeDefIndex: 85824; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_79(object P0, HttpSender.FSendFunc P1); // TypeDefIndex: 85825; 0x000000018417E440-0x000000018417E4A0

	public delegate IEnumerator __HotPatchDelegate_80(object P0, HttpSender.FSendFunc P1, object P2); // TypeDefIndex: 85826; 0x0000000184DE6ED0-0x0000000184DE6F40

	public delegate IEnumerator __HotPatchDelegate_81(object P0, HttpSender.FGetOptions P1, object P2, object P3); // TypeDefIndex: 85827; 0x0000000184DE6F40-0x0000000184DE6F90

	public delegate IEnumerator __HotPatchDelegate_82(object P0, HttpSender.FGetOptions P1, object P2); // TypeDefIndex: 85828; 0x00000001827C6B50-0x00000001827C6B90

	public delegate IEnumerator __HotPatchDelegate_83(object P0, HttpSender.FPostOptions P1, object P2, object P3); // TypeDefIndex: 85829; 0x0000000184DE6F40-0x0000000184DE6F90

	public delegate IEnumerator __HotPatchDelegate_84(object P0, HttpSender.FPostOptions P1, object P2); // TypeDefIndex: 85830; 0x00000001827C6B50-0x00000001827C6B90

	public delegate void __HotPatchDelegate_85(object P0, HttpSender.FSendFunc P1); // TypeDefIndex: 85831; 0x000000018417E440-0x000000018417E4A0

	public delegate WaitForAsyncTask<HttpSender.Result> __HotPatchDelegate_86(HttpSender.FSendFunc P0); // TypeDefIndex: 85832; 0x0000000184DE6F90-0x0000000184DE8170

	public delegate WaitForAsyncTask<HttpSender.Result> __HotPatchDelegate_87(object P0, HttpSender.FPostOptions P1); // TypeDefIndex: 85833; 0x00000001827C6B90-0x00000001827C6BC0

	public delegate WaitForAsyncTask<HttpSender.Result> __HotPatchDelegate_88(object P0, HttpSender.FGetOptions P1); // TypeDefIndex: 85834; 0x00000001827C6B90-0x00000001827C6BC0

	public delegate WaitForAsyncTask<HttpSender.Result> __HotPatchDelegate_89(object P0); // TypeDefIndex: 85835; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_90(object P0, out bool P1); // TypeDefIndex: 85836; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_91(ref HttpSender.FSendFunc P0); // TypeDefIndex: 85837; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate EHGNetSessionReconnectState __HotPatchDelegate_92(object P0); // TypeDefIndex: 85838; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_93(object P0, EHGNetSessionReconnectState P1); // TypeDefIndex: 85839; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_94(ref NetRequest P0); // TypeDefIndex: 85840; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_95(object P0, object P1, ENetCloseReason P2); // TypeDefIndex: 85841; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_96(object P0, object P1, int P2, bool P3); // TypeDefIndex: 85842; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_97(object P0, ENetConnectErrorCode P1); // TypeDefIndex: 85843; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_98(object P0, ENetCloseReason P1); // TypeDefIndex: 85844; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_99(object P0, object P1, int P2, bool P3, out HGNetSessionConnectYield P4); // TypeDefIndex: 85845; 0x00000001826EA060-0x00000001826EA080

	public delegate void __HotPatchDelegate_100(object P0, NetRequest P1); // TypeDefIndex: 85846; 0x00000001826DF780-0x00000001826DF7C0

	public delegate void __HotPatchDelegate_101(object P0, long P1); // TypeDefIndex: 85847; 0x00000001859B7730-0x00000001859B7740

	public delegate INetIO __HotPatchDelegate_102(object P0); // TypeDefIndex: 85848; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Task<bool> __HotPatchDelegate_103(object P0, object P1, int P2); // TypeDefIndex: 85849; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Task<bool> __HotPatchDelegate_104(object P0, object P1, object P2, int P3, int P4, int P5, int P6); // TypeDefIndex: 85850; 0x00000001811C5A40-0x00000001811C5A60

	public delegate System.Threading.Tasks.Task __HotPatchDelegate_105(object P0, object P1); // TypeDefIndex: 85851; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_106(object P0, object P1, long P2, int P3); // TypeDefIndex: 85852; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_107(object P0, object P1, int P2); // TypeDefIndex: 85853; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_108(object P0, object P1, object P2, int P3); // TypeDefIndex: 85854; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_109(object P0, object P1, long P2, long P3); // TypeDefIndex: 85855; 0x00000001811CDB70-0x00000001811CDB90

	public delegate byte[] __HotPatchDelegate_110(); // TypeDefIndex: 85856; 0x0000000185B44B70-0x0000000185B44B80

	public delegate CLIENT_PLATFORM_TYPE __HotPatchDelegate_111(); // TypeDefIndex: 85857; 0x0000000185B44B70-0x0000000185B44B80

	public delegate ENV_TYPE __HotPatchDelegate_112(); // TypeDefIndex: 85858; 0x0000000185B44B70-0x0000000185B44B80

	public delegate int __HotPatchDelegate_113(); // TypeDefIndex: 85859; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_114(object P0, object P1, ref NetRequest P2, bool P3); // TypeDefIndex: 85860; 0x0000000181217F60-0x0000000181217F80

	public delegate bool __HotPatchDelegate_115(object P0, object P1, out NetResponse P2, bool P3); // TypeDefIndex: 85861; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_116(object P0, long P1, int P2); // TypeDefIndex: 85862; 0x00000001811DF7F0-0x00000001811DF810

	public delegate byte[] __HotPatchDelegate_117(object P0, object P1); // TypeDefIndex: 85863; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_118(object P0, object P1, object P2); // TypeDefIndex: 85864; 0x00000001811DF7F0-0x00000001811DF810

	public delegate MSG_A1 __HotPatchDelegate_119(object P0); // TypeDefIndex: 85865; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate HGNetSessionLoginYield __HotPatchDelegate_120(object P0, object P1, object P2, int P3); // TypeDefIndex: 85866; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_121(object P0, object P1, ref NetRequest P2); // TypeDefIndex: 85867; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_122(object P0, object P1, out NetResponse P2); // TypeDefIndex: 85868; 0x00000001811DF7F0-0x00000001811DF810

	public delegate NetDevProfilerSnapshot __HotPatchDelegate_123(object P0); // TypeDefIndex: 85869; 0x000000018415E4E0-0x000000018415E550

	public delegate bool __HotPatchDelegate_124(object P0, NetResponse P1); // TypeDefIndex: 85870; 0x00000001826EA220-0x00000001826EA270

	public delegate void __HotPatchDelegate_125(object P0, object P1, long P2); // TypeDefIndex: 85871; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_126(CODE P0); // TypeDefIndex: 85872; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_127(object P0, object P1, NetResponse P2); // TypeDefIndex: 85873; 0x000000018416C820-0x000000018416C880

	public delegate void __HotPatchDelegate_128(object P0, object P1, ref NetResponse P2); // TypeDefIndex: 85874; 0x00000001811DF7F0-0x00000001811DF810

	public delegate MSG_B1 __HotPatchDelegate_129(object P0); // TypeDefIndex: 85875; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_130(object P0, ref FLogMessage P1); // TypeDefIndex: 85876; 0x00000001859B7730-0x00000001859B7740

	public delegate LogLevel __HotPatchDelegate_131(ELogLevel P0); // TypeDefIndex: 85877; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate NativeLogLevel __HotPatchDelegate_132(ELogLevel P0); // TypeDefIndex: 85878; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_133(ELogChannel P0); // TypeDefIndex: 85879; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_134(NativeLogLevel P0, int P1); // TypeDefIndex: 85880; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_135(ELogLevel P0, ELogChannel P1); // TypeDefIndex: 85881; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_136(object P0, object P1, object P2, UnityEngine.LogType P3); // TypeDefIndex: 85882; 0x00000001811CDB70-0x00000001811CDB90

	public delegate HGNetLoggerClient __HotPatchDelegate_137(); // TypeDefIndex: 85883; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_138(object P0, ref LogMessage P1); // TypeDefIndex: 85884; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_139(object P0, ref FLogMessage P1); // TypeDefIndex: 85885; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_140(object P0, ulong P1, ulong P2, ulong P3, ulong P4); // TypeDefIndex: 85886; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_141(object P0, object P1, object P2, object P3, object P4); // TypeDefIndex: 85887; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_142(bool P0); // TypeDefIndex: 85888; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_143(ulong P0); // TypeDefIndex: 85889; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Dictionary<System.Type, Beyond.Network.HGNetLogger.MessageType> __HotPatchDelegate_144(); // TypeDefIndex: 85890; 0x0000000185B44B70-0x0000000185B44B80

	public delegate Dictionary<Beyond.Network.HGNetLogger.MessageType, System.Type> __HotPatchDelegate_145(); // TypeDefIndex: 85891; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_146(object P0, out Beyond.Network.HGNetLogger.MessageType P1); // TypeDefIndex: 85892; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_147(object P0, object P1, NetRequest P2); // TypeDefIndex: 85893; 0x00000001826EAF30-0x00000001826EAF70

	public delegate IExtensible __HotPatchDelegate_148(Beyond.Network.HGNetLogger.MessageType P0); // TypeDefIndex: 85894; 0x0000000185B78EA0-0x0000000185B78EB0
}
