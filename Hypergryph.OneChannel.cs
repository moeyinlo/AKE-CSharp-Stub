/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AOT;
using Hypergryph.CloudClientBridge;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Scripting;

// Image 63: Hypergryph.OneChannel.dll - Assembly: Hypergryph.OneChannel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61602-61744
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 61744
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_72 C8939CFEA086350CA0F084D5A8FFA18BE802D605B6111130EB5143B5882250C4; // 0x00 // Static value (base64): YQBiAGMAZABlAGYAZwBoAGkAZwBrAGwAbQBuAG8AcABxAHIAcwB0AHUAdgB3AHgAeQB6ADEAMgAzADQANQA2ADcAOAA5ADAA - Metadata: 0x0234FE44
	internal static readonly __StaticArrayInitTypeSize_24 C9A1311D05AB372579F6B92A220603EAB8191E15071784A11774A076DC45320B; // 0x48 // Static value (base64): AgAAAAMAAAAFAAAACgAAAA8AAAAPAAAA - Metadata: 0x0234FE94

	// Nested types
	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 61742
	{
	}

	private struct __StaticArrayInitTypeSize_72 // TypeDefIndex: 61743
	{
	}
}

namespace Hypergryph.PlatformFacade
{
	public class PlatformFacade // TypeDefIndex: 61740
	{
		// Methods
		public static void SetupPlatformFont(IPlatformFont iFont); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface IPlatformFont // TypeDefIndex: 61741
	{
	}
}

namespace U8.SDK
{
	public struct ExternalPluginLoginParams // TypeDefIndex: 61603
	{
		// Fields
		public Action nativeLogin; // 0x00
		public Action<string> nativeLoginCustom; // 0x08
		public Action<string> nativeOnLoginSuc; // 0x10
		public Action<string> nativeOnLoginFail; // 0x18
		public Action<U8MockLogin> markMockLogin; // 0x20
	}

	public struct ExternalPluginLogoutParams // TypeDefIndex: 61604
	{
		// Fields
		public Action nativeLogout; // 0x00
		public Action nativeOnLogoutSuc; // 0x08
		public Action nativeOnLogoutFail; // 0x10
	}

	public struct ExternalPluginPayParams // TypeDefIndex: 61605
	{
		// Fields
		public U8PayParams payParams; // 0x00
		public Func<U8PayParams, SDKPromise<U8PayResult>> nativePay; // 0x08
		public Action<U8PayResult> onPaySuc; // 0x10
		public Action<object> onPayFail; // 0x18
	}

	public interface IExternalPlugin // TypeDefIndex: 61606
	{
		// Methods
		void Init();
		void Login(ExternalPluginLoginParams args);
		void Pay(ExternalPluginPayParams args);
		void Logout(ExternalPluginLogoutParams args);
		string GetSDKToken();
		bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta);
		void OnProductListChanged(List<U8ProductInfo> productList);
		string GetPayAddition();
	}

	public abstract class SDKCaptchaHandler // TypeDefIndex: 61609
	{
		// Nested types
		public enum Status // TypeDefIndex: 61607
		{
			SUC = 0,
			SYS_BUSY = 1,
			USER_CANCEL = 2,
			NOT_SUPPORT = 50,
			INVALID_PARAM = 51,
			UNKNOWN = 99
		}
	
		public class Result // TypeDefIndex: 61608
		{
			// Fields
			[CompilerGenerated]
			private Status _status_k__BackingField; // 0x10
			[CompilerGenerated]
			private int _errorCode_k__BackingField; // 0x14
			[CompilerGenerated]
			private string _captcha_k__BackingField; // 0x18
	
			// Properties
			public Status status { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
			private int errorCode { [CompilerGenerated] set; } // 0x0000000184D8F540-0x0000000184D8F550
			public string captcha { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
			// Constructors
			private Result(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public static Result CreateForOutput(); // 0x0000000189DE6E20-0x0000000189DE6E64
			public void MarkSucceed(string captcha); // 0x0000000189DE6EB8-0x0000000189DE6ED8
			public void MarkFailed(Status status, int errorCode); // 0x0000000189DE6E8C-0x0000000189DE6EB8
			public void MarkFailed(Status status); // 0x0000000189DE6E64-0x0000000189DE6E8C
		}
	
		// Constructors
		protected SDKCaptchaHandler(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract IEnumerator FetchCaptchaCoroutine(string captchaParams, Result outResult);
	}

	public abstract class SDKExternalTools // TypeDefIndex: 61643
	{
		// Fields
		private static readonly char[] RANDOM_CHAR_MAP; // 0x00
		protected static readonly int[] PAY_CONFIRM_RETRY_INTERVALS; // 0x08
		private static SDKExternalTools s_instance; // 0x10
		private static IExternalPlugin s_plugin; // 0x18
		[CompilerGenerated]
		private bool _inited_k__BackingField; // 0x10
		[CompilerGenerated]
		private CaptchaMgr _captchaMgr_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _subChannel_k__BackingField; // 0x20
		private static int U8_SDK_SET_DATA_SET_SERVER; // 0x20
	
		// Properties
		protected bool inited { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		protected IExternalPlugin plugin { get; } // 0x0000000189DE9390-0x0000000189DE93E0 
		protected CaptchaMgr captchaMgr { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		protected string subChannel { [CompilerGenerated] set; } // 0x0000000185390F40-0x0000000185390F50
	
		// Nested types
		protected interface IFromJSON // TypeDefIndex: 61610
		{
			// Methods
			bool LoadFromJSON(string json);
		}
	
		protected enum POSTStatus // TypeDefIndex: 61611
		{
			NONE = 0,
			SUC = 1,
			TIMEOUT = 2,
			ERROR = 3
		}
	
		protected enum BusType // TypeDefIndex: 61612
		{
			NONE = 0,
			GET_TOKEN = 1,
			GET_CAPTCHA = 2,
			CREATE_ORDER = 3,
			CONFIRM_ORDER = 4,
			VERIFY_ACCOUNT = 5,
			GET_PRODUCT_LIST = 6,
			AUTHV2_SESSION_TOKEN = 7,
			AUTHV2_OAUTH2CODE = 8,
			AUTHV2_OAUTH2TOKEN = 9,
			SERVER_LIST = 10,
			CONFIRM_SERVER = 11
		}
	
		protected enum ErrorType // TypeDefIndex: 61613
		{
			NONE = 0,
			TIMEOUT = 1,
			NETWORK_ERROR = 2,
			DESERIALIZE_FAILED = 3,
			BUSINESS_ERROR = 4
		}
	
		protected struct POSTRequest // TypeDefIndex: 61614
		{
			// Fields
			public string url; // 0x00
			public string body; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> nullableHeaders; // 0x18
		}
	
		protected struct POSTResult // TypeDefIndex: 61615
		{
			// Fields
			public POSTStatus status; // 0x00
			public int httpCode; // 0x04
			public string response; // 0x08
			public string error; // 0x10
	
			// Methods
			public bool ServiceFailed(); // 0x0000000189DE6CF4-0x0000000189DE6CFC
		}
	
		protected struct ErrMsgMeta // TypeDefIndex: 61616
		{
			// Fields
			public static readonly ErrMsgMeta EMPTY; // 0x00
			public BusType busType; // 0x00
			public ErrorType errorType; // 0x04
			public int errorCode; // 0x08
			public string alertFromServer; // 0x10
			public object meta; // 0x18
	
			// Methods
			public bool IsEmpty(); // 0x000000018426F6A0-0x000000018426F6B0
			public static ErrMsgMeta FromPOSTResult(BusType busType, POSTResult postRet); // 0x0000000189DE4E74-0x0000000189DE4EB4
		}
	
		protected class CaptchaMgr // TypeDefIndex: 61618
		{
			// Fields
			private SDKExternalTools m_host; // 0x10
			[CompilerGenerated]
			private SDKCaptchaHandler _activeHandler_k__BackingField; // 0x18
	
			// Properties
			public SDKCaptchaHandler activeHandler { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
			// Nested types
			[CompilerGenerated]
			private sealed class _FetchCaptchaCoroutine_d__6 : IEnumerator<object> // TypeDefIndex: 61617
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public CaptchaMgr __4__this; // 0x20
				public SDKCaptchaHandler.Result outResult; // 0x28
				public Dictionary<string, object> captchaParams; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public _FetchCaptchaCoroutine_d__6(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000189DEEEE4-0x0000000189DEEF5C
				private bool MoveNext(); // 0x0000000189DEEAFC-0x0000000189DEEE98
				private void __m__Finally1(); // 0x0000000189DEEF5C-0x0000000189DEEF8C
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000189DEEE98-0x0000000189DEEEE4
			}
	
			// Constructors
			public CaptchaMgr(SDKExternalTools host); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			[IteratorStateMachine(typeof(_FetchCaptchaCoroutine_d__6))]
			public IEnumerator FetchCaptchaCoroutine(Dictionary<string, object> captchaParams, SDKCaptchaHandler.Result outResult); // 0x0000000189DE4778-0x0000000189DE4804
		}
	
		protected class POSTProcedure // TypeDefIndex: 61621
		{
			// Fields
			[CompilerGenerated]
			private Builder _builder_k__BackingField; // 0x10
			[CompilerGenerated]
			private bool _isServiceFinished_k__BackingField; // 0x38
			[CompilerGenerated]
			private ErrMsgMeta _serviceError_k__BackingField; // 0x40
			[CompilerGenerated]
			private string _rawResponse_k__BackingField; // 0x60
	
			// Properties
			protected Builder builder { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2D2D0-0x0000000182B2D2F0 0x0000000189DC5750-0x0000000189DC5774
			public bool isServiceFinished { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
			public ErrMsgMeta serviceError { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184DA2E80-0x0000000184DA2EA0 0x0000000189DE6CDC-0x0000000189DE6CF4
			private string rawResponse { [CompilerGenerated] set; } // 0x00000001863CC164-0x00000001863CC174
	
			// Nested types
			public struct Builder // TypeDefIndex: 61619
			{
				// Fields
				public POSTRequest request; // 0x00
				public BusType busType; // 0x20
	
				// Methods
				public POSTProcedure Build(); // 0x0000000189DE4704-0x0000000189DE4778
				public POSTProcedure<TResp> TypedBuild<TResp>()
					where TResp : class, IFromJSON, new();
			}
	
			[CompilerGenerated]
			private sealed class _POST_d__18 : IEnumerator<object> // TypeDefIndex: 61620
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public SDKExternalTools host; // 0x20
				public POSTProcedure __4__this; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public _POST_d__18(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x0000000189DEEF8C-0x0000000189DEF0B0
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000189DEF0B0-0x0000000189DEF0FC
			}
	
			// Constructors
			public POSTProcedure(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public ErrMsgMeta MakeBusinessError(int errorCode); // 0x0000000184DA2E40-0x0000000184DA2E80
			[IteratorStateMachine(typeof(_POST_d__18))]
			public IEnumerator POST(SDKExternalTools host); // 0x0000000189DE6B58-0x0000000189DE6BCC
			private void _OnServiceFinished(POSTResult postRet); // 0x0000000189DE6BCC-0x0000000189DE6CDC
			protected virtual void HandleServiceResponse(POSTResult postRet); // 0x00000001841E1670-0x00000001841E1680
		}
	
		protected class POSTProcedure<TResp> : POSTProcedure // TypeDefIndex: 61622
			where TResp : class, IFromJSON, new()
		{
			// Fields
			[CompilerGenerated]
			private TResp _response_k__BackingField;
	
			// Properties
			public TResp response { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public POSTProcedure();
	
			// Methods
			protected override void HandleServiceResponse(POSTResult postRet);
		}
	
		protected class AuthV2SessionTokenResp : IFromJSON // TypeDefIndex: 61623
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public string token; // 0x28
			public string uid; // 0x30
			public bool isNew; // 0x38
	
			// Constructors
			public AuthV2SessionTokenResp(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool LoadFromJSON(string json); // 0x0000000189DE4510-0x0000000189DE4704
		}
	
		public class GetProductLsitResp : IFromJSON // TypeDefIndex: 61624
		{
			// Fields
			public int flag; // 0x10
			public Dictionary<string, object> desc; // 0x18
	
			// Constructors
			public GetProductLsitResp(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool LoadFromDictionary(Dictionary<string, object> dict); // 0x0000000189DE4EB4-0x0000000189DE5118
			public bool LoadFromJSON(string json); // 0x0000000189DE5118-0x0000000189DE51F8
		}
	
		protected class AuthV2GrantResp : IFromJSON // TypeDefIndex: 61625
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public string uid; // 0x28
			public string code; // 0x30
			public string token; // 0x38
			public long banStartTs; // 0x40
			public long banEndTs; // 0x48
			public long maintainStartTs; // 0x50
			public long maintainEndTs; // 0x58
			public Dictionary<string, object> captcha; // 0x60
	
			// Constructors
			public AuthV2GrantResp(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool LoadFromJSON(string json); // 0x0000000189DE4244-0x0000000189DE4510
		}
	
		protected class ServerListResp : IFromJSON // TypeDefIndex: 61627
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public List<ServerData> data; // 0x20
	
			// Nested types
			public struct ServerData // TypeDefIndex: 61626
			{
				// Fields
				public string serverId; // 0x00
				public string serverName; // 0x08
				public string serverDomain; // 0x10
				public bool defaultChoose; // 0x18
				public string roleId; // 0x20
				public string nickName; // 0x28
				public long level; // 0x30
				public string extension; // 0x38
			}
	
			// Constructors
			public ServerListResp(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool LoadFromJSON(string json); // 0x0000000189DEE38C-0x0000000189DEE884
			public List<U8ServerInfo> ToServerInfo(); // 0x0000000189DEE884-0x0000000189DEEAFC
		}
	
		protected class ConfirmServerResp : IFromJSON // TypeDefIndex: 61628
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
	
			// Constructors
			public ConfirmServerResp(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool LoadFromJSON(string json); // 0x0000000189DE49F4-0x0000000189DE4AD0
		}
	
		protected class ConfirmOrderU1Resp : IFromJSON // TypeDefIndex: 61629
		{
			// Fields
			public int status; // 0x10
	
			// Constructors
			public ConfirmOrderU1Resp(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool LoadFromJSON(string json); // 0x0000000189DE4958-0x0000000189DE49F4
		}
	
		protected class CreateOrderU1Resp : IFromJSON // TypeDefIndex: 61631
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public Data data; // 0x28
	
			// Nested types
			public struct Data // TypeDefIndex: 61630
			{
				// Fields
				public string orderId; // 0x00
				public string channelProductCode; // 0x08
				public string productName; // 0x10
				public string productDesc; // 0x18
				public long amount; // 0x20
				public Dictionary<string, object> extension; // 0x28
			}
	
			// Constructors
			public CreateOrderU1Resp(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool LoadFromJSON(string json); // 0x0000000189DE4AD0-0x0000000189DE4D5C
			public U8OrderInfo ToOrderInfo(); // 0x0000000189DE4D5C-0x0000000189DE4E74
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61632
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<string> __9__43_0; // 0x08
			public static Action<string> __9__43_1; // 0x10
			public static Action __9__44_0; // 0x18
			public static Action __9__44_1; // 0x20
	
			// Constructors
			static __c(); // 0x0000000184D40390-0x0000000184D403F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoginWithPlugin_b__43_0(string extension); // 0x0000000184D26E00-0x0000000184D26E80
			internal void _LoginWithPlugin_b__43_1(string message); // 0x0000000189DF02D4-0x0000000189DF0340
			internal void _LogoutWithPlugin_b__44_0(); // 0x0000000189DF0340-0x0000000189DF03C0
			internal void _LogoutWithPlugin_b__44_1(); // 0x0000000189DF03C0-0x0000000189DF0440
		}
	
		[CompilerGenerated]
		private sealed class __NextFrameCoroutine_d__61 : IEnumerator<object> // TypeDefIndex: 61633
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action action; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __NextFrameCoroutine_d__61(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF2EAC-0x0000000189DF2EFC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF2EFC-0x0000000189DF2F48
		}
	
		[CompilerGenerated]
		private sealed class _SDKInterfaceAuthV2SessionToken_d__114 : IEnumerator<object> // TypeDefIndex: 61634
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKPromiseWithResult<U8LoginV2Result> promise; // 0x20
			public SDKMeta meta; // 0x28
			public string channelToken; // 0x30
			public SDKExternalTools __4__this; // 0x38
			private POSTProcedure<AuthV2SessionTokenResp> _postImpl_5__2; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _SDKInterfaceAuthV2SessionToken_d__114(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DEF1AC-0x0000000189DEF650
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DEF650-0x0000000189DEF69C
		}
	
		[CompilerGenerated]
		private sealed class _SDKInterfaceAuthV2OAuth2Code_d__115 : IEnumerator<object> // TypeDefIndex: 61635
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string sessionToken; // 0x28
			public SDKPromiseWithResult<U8GrantResult> promise; // 0x30
			public Action onSessionInvalid; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _SDKInterfaceAuthV2OAuth2Code_d__115(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DEF0FC-0x0000000189DEF160
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DEF160-0x0000000189DEF1AC
		}
	
		[CompilerGenerated]
		private sealed class __AuthV2GrantImpl_d__121 : IEnumerator<object> // TypeDefIndex: 61636
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKPromiseWithResult<U8GrantResult> promise; // 0x20
			public SDKExternalTools __4__this; // 0x28
			public string sessionToken; // 0x30
			public Action onSessionInvalid; // 0x38
			private string _captcha_5__2; // 0x40
			private bool _needCaptcha_5__3; // 0x48
			private POSTProcedure<AuthV2GrantResp> _postImpl_5__4; // 0x50
			private SDKCaptchaHandler.Result _captchaRet_5__5; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __AuthV2GrantImpl_d__121(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF1D28-0x0000000189DF2484
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF2484-0x0000000189DF24D0
		}
	
		[CompilerGenerated]
		private sealed class __ConfirmOrderU1Coroutine_d__124 : IEnumerator<object> // TypeDefIndex: 61637
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string orderId; // 0x28
			public string extension; // 0x30
			public SDKPromise<U8ConfirmOrderResult> promise; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ConfirmOrderU1Coroutine_d__124(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF24D0-0x0000000189DF26D4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF26D4-0x0000000189DF2720
		}
	
		[CompilerGenerated]
		private sealed class __PollOrderStatusCoroutine_d__125 : IEnumerator<object> // TypeDefIndex: 61638
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string orderId; // 0x28
			public SDKPromise<U8ConfirmOrderResult> promise; // 0x30
			private int _tryCnt_5__2; // 0x38
			private int _maxTryCnt_5__3; // 0x3C
			private POSTProcedure.Builder _postBuilder_5__4; // 0x40
			private POSTProcedure<ConfirmOrderU1Resp> _postImpl_5__5; // 0x68
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __PollOrderStatusCoroutine_d__125(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF2F48-0x0000000189DF340C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF340C-0x0000000189DF3458
		}
	
		[CompilerGenerated]
		private sealed class __GetServerListCoroutine_d__126 : IEnumerator<object> // TypeDefIndex: 61639
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string paramStr; // 0x28
			public SDKPromise<List<U8ServerInfo>> promise; // 0x30
			private POSTProcedure<ServerListResp> _postImpl_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GetServerListCoroutine_d__126(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF2B20-0x0000000189DF2DC8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF2DC8-0x0000000189DF2E14
		}
	
		[CompilerGenerated]
		private sealed class __ConfirmServerListCoroutine_d__128 : IEnumerator<object> // TypeDefIndex: 61640
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string paramStr; // 0x28
			public SDKPromise<U8ConfirmServerResult> promise; // 0x30
			public string serverId; // 0x38
			private POSTProcedure<ConfirmServerResp> _postImpl_5__2; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ConfirmServerListCoroutine_d__128(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF2720-0x0000000189DF2AD4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF2AD4-0x0000000189DF2B20
		}
	
		[CompilerGenerated]
		private sealed class __SendCreateOrderU1Coroutine_d__129 : IEnumerator<object> // TypeDefIndex: 61641
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string paramStr; // 0x28
			public SDKPromise<U8OrderInfo> promise; // 0x30
			private POSTProcedure<CreateOrderU1Resp> _postImpl_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __SendCreateOrderU1Coroutine_d__129(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF3514-0x0000000189DF37AC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF37AC-0x0000000189DF37F8
		}
	
		[CompilerGenerated]
		private sealed class __SendCreateOrderFailCoroutine_d__130 : IEnumerator<object> // TypeDefIndex: 61642
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKPromise<U8OrderInfo> promise; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __SendCreateOrderFailCoroutine_d__130(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF3458-0x0000000189DF34C8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF34C8-0x0000000189DF3514
		}
	
		// Constructors
		protected SDKExternalTools(); // 0x00000001841E1670-0x00000001841E1680
		static SDKExternalTools(); // 0x0000000184B47280-0x0000000184B473C0
	
		// Methods
		public static bool SDKInterfaceInitExternalTools<ConcreteType>()
			where ConcreteType : SDKExternalTools;
		public static SDKExternalTools GetInstance(); // 0x00000001835A5050-0x00000001835A50D0
		public static bool HasInstance(); // 0x0000000189DE76D4-0x0000000189DE771C
		public string PublicServiceSignKey(); // 0x0000000189DE7BB4-0x0000000189DE7C00
		public SDKPromise<List<U8ProductInfo>> SDKInterfaceProductListV2(); // 0x0000000189DE8580-0x0000000189DE8628
		public void NotifyProductListUpdated(List<U8ProductInfo> productList); // 0x0000000189DE7B5C-0x0000000189DE7BB4
		public string SDKInterfaceSDKToken(); // 0x0000000189DE8628-0x0000000189DE86B0
		public static string MakeHttpPostParam(Dictionary<string, object> param); // 0x0000000185395194-0x000000018539519C
		public void LoginWithPlugin(Action nativeLogin, Action<string> nativeLoginCustom, Action<U8MockLogin> markMockLogin); // 0x0000000183AFA240-0x0000000183AFA500
		public void LogoutWithPlugin(Action nativeLogout); // 0x0000000189DE7908-0x0000000189DE7B5C
		public void SDKInterfacePayWithPlugin(U8PayParams payParams, Func<U8PayParams, SDKPromise<U8PayResult>> nativePay, Action<U8PayResult> onSuc, Action<object> onFail); // 0x0000000189DE8458-0x0000000189DE8580
		public string SDKInterfaceGetPayAddition(); // 0x0000000189DE83A4-0x0000000189DE8458
		public static void StaticLog(string content); // 0x0000000189DE87E0-0x0000000189DE8878
		public static void StaticLogWarning(string content); // 0x0000000189DE8748-0x0000000189DE87E0
		public static void StaticLogError(string content); // 0x0000000189DE86B0-0x0000000189DE8748
		public static void RegisterPlugin(IExternalPlugin plugin); // 0x00000001835A1FB0-0x00000001835A20D0
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default);
		protected string U8Url(string routeUrl); // 0x0000000189DE8878-0x0000000189DE891C
		protected string U8urlWithoutU8(string routeUrl); // 0x0000000189DE891C-0x0000000189DE8A14
		protected static ErrMsgMeta HandleResponseFromU8<TResp>(BusType busType, POSTResult postRet, out ref TResp resp)
			where TResp : IFromJSON, new();
		protected static Dictionary<string, object> FromMiniJSON(string json); // 0x0000000189DE7610-0x0000000189DE76D4
		protected static void InternalInvokeCoroutine(IEnumerator coroutine); // 0x0000000189DE771C-0x0000000189DE7778
		protected static void InternalInvokeNextFrame(Action action); // 0x0000000189DE7778-0x0000000189DE7804
		[IteratorStateMachine(typeof(__NextFrameCoroutine_d__61))]
		private static IEnumerator _NextFrameCoroutine(Action action); // 0x0000000189DE91C0-0x0000000189DE921C
		public void InitIfNot(); // 0x00000001835A2100-0x00000001835A21B0
		protected virtual void Init(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void SwitchAccount(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnSDKError(SDKError error); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnInvalidProduct(int storeId); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnSDKExtraInfo(string jsonData); // 0x00000001841E1670-0x00000001841E1680
		public virtual SDKMeta LoadSDKMetaFromPlugin(Func<SDKMeta> nativeLoadMeta); // 0x0000000189DE7804-0x0000000189DE7908
		protected abstract SDKCaptchaHandler CreateCaptchaHandler();
		protected virtual string GetSignKey(); // 0x00000001811EC580-0x00000001811EC590
		public abstract Dictionary<string, string> GetDeviceIDs();
		protected abstract SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr);
		protected abstract int GetPlatformKey();
		protected abstract void POSTImplementation(POSTRequest request, Action<POSTResult> callback);
		protected abstract string U8RootUrl();
		protected abstract string GetErrorMessage(ErrMsgMeta meta);
		protected abstract void Log(string content);
		protected abstract void LogWarning(string content);
		protected abstract void LogError(string content);
		private bool _ValidatePlugin(); // 0x0000000184D36530-0x0000000184D365A0
		private static void _AddAppIdOrAppCode(Dictionary<string, object> paramDict, SDKMeta meta); // 0x0000000189DE8A14-0x0000000189DE8AAC
		private static string _MakeGetProductListV2Param(SDKMeta meta); // 0x0000000189DE8EE4-0x0000000189DE900C
		[IteratorStateMachine(typeof(_SDKInterfaceAuthV2SessionToken_d__114))]
		public IEnumerator SDKInterfaceAuthV2SessionToken(SDKMeta meta, string channelToken, SDKPromiseWithResult<U8LoginV2Result> promise); // 0x0000000189DE7F18-0x0000000189DE7FC0
		[IteratorStateMachine(typeof(_SDKInterfaceAuthV2OAuth2Code_d__115))]
		public IEnumerator SDKInterfaceAuthV2OAuth2Code(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid); // 0x0000000189DE7E70-0x0000000189DE7F18
		public SDKPromise<U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(string orderId, string extension); // 0x0000000189DE7FC0-0x0000000189DE8074
		public SDKPromise<List<U8ServerInfo>> SDKInterFaceGetServerList(string sessionToken); // 0x0000000189DE7D54-0x0000000189DE7E70
		public SDKPromise<U8ConfirmServerResult> SDKInterFaceConfirmServer(string sessionToken, string serverId); // 0x0000000189DE7C00-0x0000000189DE7D54
		public SDKPromise<U8OrderInfo> SDKInterfaceCreateOrderU1(string sessionToken, string productId, string signParams); // 0x0000000189DE8074-0x0000000189DE83A4
		private static string _MakeGrantParam(string sessionToken, int type, string captcha); // 0x0000000189DE900C-0x0000000189DE91C0
		[IteratorStateMachine(typeof(__AuthV2GrantImpl_d__121))]
		private IEnumerator _AuthV2GrantImpl(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid); // 0x0000000189DE8AAC-0x0000000189DE8B54
		private static string _MakeCheckOrderV1Param(string orderId, string extension); // 0x0000000189DE8D30-0x0000000189DE8E28
		private static string _MakeConfirmOrderV1Param(string orderId); // 0x0000000189DE8E28-0x0000000189DE8EE4
		[IteratorStateMachine(typeof(__ConfirmOrderU1Coroutine_d__124))]
		private IEnumerator _ConfirmOrderU1Coroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise); // 0x0000000189DE8B54-0x0000000189DE8BFC
		[IteratorStateMachine(typeof(__PollOrderStatusCoroutine_d__125))]
		private IEnumerator _PollOrderStatusCoroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise); // 0x0000000189DE921C-0x0000000189DE92A8
		[IteratorStateMachine(typeof(__GetServerListCoroutine_d__126))]
		private IEnumerator _GetServerListCoroutine(string paramStr, SDKPromise<List<U8ServerInfo>> promise); // 0x0000000189DE8CA4-0x0000000189DE8D30
		[IteratorStateMachine(typeof(__ConfirmServerListCoroutine_d__128))]
		private IEnumerator _ConfirmServerListCoroutine(string paramStr, string serverId, SDKPromise<U8ConfirmServerResult> promise); // 0x0000000189DE8BFC-0x0000000189DE8CA4
		[IteratorStateMachine(typeof(__SendCreateOrderU1Coroutine_d__129))]
		private IEnumerator _SendCreateOrderU1Coroutine(string paramStr, SDKPromise<U8OrderInfo> promise); // 0x0000000189DE9304-0x0000000189DE9390
		[IteratorStateMachine(typeof(__SendCreateOrderFailCoroutine_d__130))]
		private IEnumerator _SendCreateOrderFailCoroutine(SDKPromise<U8OrderInfo> promise); // 0x0000000189DE92A8-0x0000000189DE9304
	}

	public struct SDKExtraData // TypeDefIndex: 61644
	{
		// Fields
		public static readonly SDKExtraData EMPTY; // 0x00
		public int code; // 0x00
		public Dictionary<string, object> msg; // 0x08
	
		// Constructors
		static SDKExtraData(); // 0x0000000184D4E810-0x0000000184D4E860
	
		// Methods
		public static SDKExtraData FromJson(string jsonStr); // 0x0000000184441A40-0x0000000184441BC0
	}

	public abstract class SDKExternalToolsShortcut : SDKExternalTools // TypeDefIndex: 61649
	{
		// Nested types
		protected struct U8ProductListDataV2 : SDKExternalTools.IFromJSON // TypeDefIndex: 61645
		{
			// Fields
			public List<U8ProductInfo> productList; // 0x00
	
			// Methods
			public bool LoadFromJSON(string json); // 0x0000000189DF4498-0x0000000189DF4740
			private static bool _BuildProductInfo(U8ProductInfo outInfo, Dictionary<string, object> dict); // 0x0000000189DF4740-0x0000000189DF4908
		}
	
		public enum RequestConnPolicy // TypeDefIndex: 61646
		{
			DEFAULT = 0,
			CLOSE_EACH_CON = 1
		}
	
		public struct RequestHeaderInjectOptions // TypeDefIndex: 61647
		{
			// Fields
			public RequestConnPolicy policy; // 0x00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 61648
		{
			// Fields
			public SDKPromise<List<U8ProductInfo>> promise; // 0x10
			public SDKExternalToolsShortcut __4__this; // 0x18
			public SDKExternalTools.POSTRequest request; // 0x20
			public Action<SDKExternalTools.POSTResult> callback; // 0x40
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SendGetProductListRequestV2_b__0(SDKExternalTools.POSTResult postRet); // 0x0000000189DF0518-0x0000000189DF065C
			internal void _SendGetProductListRequestV2_b__1(); // 0x0000000189DF065C-0x0000000189DF0694
		}
	
		// Constructors
		protected SDKExternalToolsShortcut(); // 0x0000000184D778E0-0x0000000184D77920
	
		// Methods
		protected sealed override SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr); // 0x0000000189DE7404-0x0000000189DE75D4
		public override Dictionary<string, string> GetDeviceIDs(); // 0x0000000189DE7100-0x0000000189DE720C
		public static string GetU8DeviceID(); // 0x0000000189DE720C-0x0000000189DE732C
		public static void InjectRequestHeaders(ref Dictionary<string, string> headers, RequestHeaderInjectOptions policy); // 0x0000000189DE732C-0x0000000189DE7404
		private string _GetProductListV1Url(); // 0x0000000189DE75D4-0x0000000189DE7610
	}

	public abstract class U8SDKInterface // TypeDefIndex: 61665
	{
		// Fields
		private static U8SDKInterface m_instance; // 0x00
		protected SDKPromiseWrapper m_initPromise; // 0x10
		protected SDKPromiseWrapper m_loginPromise; // 0x18
		protected SDKPromiseWrapper m_logoutPromise; // 0x20
		protected SDKPromiseWrapper m_payPromise; // 0x28
		private U8LoginResult m_loginResult; // 0x30
		private AuthStatus m_authStatus; // 0x68
		private string m_loginExtV1; // 0x88
		private U8MockLogin m_mockLogin; // 0x90
		private List<U8ProductInfo> m_productList; // 0xA0
		private bool? m_isNativePlugin; // 0xA8
		private V2LoginStatus m_loginStatusV2; // 0xB0
		private static int U8_SDK_SET_DATA_SET_SESSION_TOKEN; // 0x08
		private static int U8_SDK_SET_DATA_GET_PRODUCT_LIST; // 0x0C
		[CompilerGenerated]
		private static ReceiverProductListResult onReceiverProductlist; // 0x10
		private GameServerTimeCache m_gameServerTimeCache; // 0xB8
	
		// Properties
		public static U8SDKInterface Instance { get; } // 0x0000000183A72EC0-0x0000000183A73090 
		public bool isNativePlugin { get; } // 0x0000000183AF78D0-0x0000000183AF7950 
		public string uid { get; } // 0x0000000184D86230-0x0000000184D86240 
		public string cachedUid { get; set; } // 0x0000000183811920-0x0000000183811960 0x0000000183F4BAD0-0x0000000183F4BB30
		public string oauth2token { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public string oauth2code { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		public static bool isInterfaceDisabled { get; } // 0x00000001812081B0-0x0000000181208610 
		public string sessionToken { get; } // 0x0000000184D86250-0x0000000184D86260 
		public GameServerTimeCache serverCacheTime { get; set; } // 0x0000000184DA2EA0-0x0000000184DA2EC0 0x0000000184DA2EC0-0x0000000184DA2EE0
	
		// Events
		private static event ReceiverProductListResult onReceiverProductlist {
			add; // 0x0000000189DF5E9C-0x0000000189DF5F70
			remove; // 0x0000000189DF5FC0-0x0000000189DF6094
		}
	
		// Nested types
		public struct AuthStatus // TypeDefIndex: 61650
		{
			// Fields
			public static readonly AuthStatus EMPTY; // 0x00
			public string uid; // 0x00
			public string oauth2code; // 0x08
			public string oauth2token; // 0x10
			public string sessionToken; // 0x18
		}
	
		private struct V2LoginStatus // TypeDefIndex: 61651
		{
			// Fields
			public string sessionToken; // 0x00
		}
	
		public delegate void ReceiverProductListResult(Dictionary<string, object> msg); // TypeDefIndex: 61652; 0x0000000182B46B90-0x0000000182B46BA0
	
		public struct GameServerTimeCache // TypeDefIndex: 61653
		{
			// Fields
			public long cacheTime; // 0x00
			public long maintainEndTs; // 0x08
			public long maintainStartTs; // 0x10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0<ToolType> // TypeDefIndex: 61654
			where ToolType : SDKExternalTools
		{
			// Fields
			public SDKPromise<string> delegatePromise;
			public U8SDKInterface __4__this;
			public string env;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _V2PublicInit_b__0(string obj);
			internal void _V2PublicInit_b__3();
			internal void _V2PublicInit_b__1(object info);
			internal void _V2PublicInit_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 61655
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public string uid; // 0x18
			public bool isNew; // 0x20
	
			// Constructors
			public __c__DisplayClass55_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __onLoginSuc_b__0(); // 0x0000000184CE3A40-0x0000000184CE3AD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0 // TypeDefIndex: 61656
		{
			// Fields
			public SDKExternalTools externalTools; // 0x10
			public U8SDKInterface __4__this; // 0x18
			public SDKPromise<U8ProductsResult> delegatePromise; // 0x20
			public Action<List<U8ProductInfo>> __9__1; // 0x28
			public Action<object> __9__2; // 0x30
	
			// Constructors
			public __c__DisplayClass57_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PublicGetProductListV2_b__0(); // 0x0000000189DF08C8-0x0000000189DF09E8
			internal void _PublicGetProductListV2_b__1(List<U8ProductInfo> productList); // 0x0000000189DF09E8-0x0000000189DF0CBC
			internal void _PublicGetProductListV2_b__2(object rejectObj); // 0x0000000189DF0CBC-0x0000000189DF0CE0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_1 // TypeDefIndex: 61657
		{
			// Fields
			public List<U8ProductInfo> productList; // 0x10
			public ReceiverProductListResult receiver; // 0x18
			public __c__DisplayClass57_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass57_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PublicGetProductListV2_b__3(Dictionary<string, object> msg); // 0x0000000189DF0CE0-0x0000000189DF1620
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 61658
		{
			// Fields
			public U8PayParams payParams; // 0x10
			public U8SDKInterface __4__this; // 0x18
			public SDKPromise<U8PayResult> wrappedPromise; // 0x20
			public U8ProductInfo productInfo; // 0x28
			public Action<U8PayResult> __9__1; // 0x30
			public Action<object> __9__2; // 0x38
	
			// Constructors
			public __c__DisplayClass69_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PublicPay_b__0(); // 0x0000000189DF1620-0x0000000189DF17AC
			internal void _PublicPay_b__1(U8PayResult payResult); // 0x0000000189DF17AC-0x0000000189DF1850
			internal void _PublicPay_b__2(object payFailMsg); // 0x0000000189DF0CBC-0x0000000189DF0CE0
			internal void _PublicPay_b__3(U8PayResult payResult); // 0x0000000189DF1850-0x0000000189DF18F4
			internal void _PublicPay_b__4(object payFailMsg); // 0x0000000189DF0CBC-0x0000000189DF0CE0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 61659
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public long revenue; // 0x18
	
			// Constructors
			public __c__DisplayClass70_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnNativePayFulfilled_b__0(); // 0x0000000189DF18F4-0x0000000189DF1964
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0 // TypeDefIndex: 61660
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public U8PayParams payParams; // 0x18
	
			// Constructors
			public __c__DisplayClass78_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __NativePay_b__0(); // 0x0000000189DF1964-0x0000000189DF19AC
		}
	
		[CompilerGenerated]
		private sealed class __NextFrameCoroutine_d__105 : IEnumerator<object> // TypeDefIndex: 61661
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action call; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __NextFrameCoroutine_d__105(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184991450-0x00000001849914B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF2E60-0x0000000189DF2EAC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass131_0 // TypeDefIndex: 61662
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public SDKPromise<U8AuthV2Result> promise; // 0x18
	
			// Constructors
			public __c__DisplayClass131_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __DoMockAuthV2_b__0(); // 0x0000000183F4B8E0-0x0000000183F4BA90
		}
	
		[CompilerGenerated]
		private sealed class __LoginV2Coroutine_d__132 : IEnumerator<object> // TypeDefIndex: 61663
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8SDKInterface __4__this; // 0x20
			public SDKPromise<string> promise; // 0x28
			private SDKPromiseEnumerator<string> _loginEnumerator_5__2; // 0x30
			private SDKPromiseWithResult<U8LoginV2Result> _sessionTokenPromise_5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __LoginV2Coroutine_d__132(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183AF94D0-0x0000000183AF9950
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF2E14-0x0000000189DF2E60
		}
	
		[CompilerGenerated]
		private sealed class __AuthV2Coroutine_d__134 : IEnumerator<object> // TypeDefIndex: 61664
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8SDKInterface __4__this; // 0x20
			public SDKPromise<U8AuthV2Result> promise; // 0x28
			private SDKPromiseWithResult<U8GrantResult> _oauth2codePromise_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __AuthV2Coroutine_d__134(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF1A10-0x0000000189DF1CDC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF1CDC-0x0000000189DF1D28
		}
	
		// Constructors
		protected U8SDKInterface(); // 0x00000001847564D0-0x0000000184756620
		static U8SDKInterface(); // 0x0000000184D5D230-0x0000000184D5D280
	
		// Methods
		public void CallbackInitSuc(string extConfigs); // 0x00000001849DAA10-0x00000001849DAA30
		public void CallbackInitFail(string info); // 0x0000000189DF4BB4-0x0000000189DF4BD4
		public void CallbackLoginSuc(string extension); // 0x00000001849DAA90-0x00000001849DAAB0
		public void CallbackLoginFail(string info); // 0x0000000189DF4BD4-0x0000000189DF4BF4
		public void CallbackLogout(); // 0x0000000189DF4BF4-0x0000000189DF4C18
		public void CallbackSwitchAccount(); // 0x0000000189DF4D40-0x0000000189DF4D8C
		public void CallbackPaySuc(string jsonData); // 0x0000000189DF4CAC-0x0000000189DF4D40
		public void CallbackPayFail(string failMsg); // 0x0000000189DF4C18-0x0000000189DF4CAC
		public string PublicLoadExtraConfig(); // 0x0000000185395664-0x0000000185395674
		public void PublicSetGameVersion(string version); // 0x00000001853981E0-0x00000001853981F4
		public ReceiverProductListResult getOnReceiverProductlist(); // 0x0000000189DF5F70-0x0000000189DF5FC0
		public SDKPromise<string> V2PublicInit<ToolType>(string env)
			where ToolType : SDKExternalTools;
		private void _MarkMockLogin(U8MockLogin mockLogin); // 0x0000000184D84E50-0x0000000184D84E70
		private void _onLoginSuc(string uid, bool isNew); // 0x0000000184CA4650-0x0000000184CA4730
		public SDKPromise<U8ProductsResult> PublicGetProductListV2(); // 0x0000000189DF51D0-0x0000000189DF52F0
		public void ClearAuthStatus(); // 0x0000000189DF4D8C-0x0000000189DF4DE8
		public void ClearLoginStatus(); // 0x0000000189DF4DE8-0x0000000189DF4E14
		private void _ConfirmAuthResult(AuthStatus result); // 0x0000000183F4BA90-0x0000000183F4BAD0
		public SDKPromise<object> PublicLogout(); // 0x0000000189DF53D4-0x0000000189DF5474
		public SDKPromise<List<U8ServerInfo>> PublicGetServerList(); // 0x0000000189DF52F0-0x0000000189DF52F8
		public SDKPromise<U8ConfirmServerResult> PubliceConfirmServer(string serverId); // 0x0000000189DF56BC-0x0000000189DF56C4
		public SDKPromise<U8PayResult> PublicPay(int storeId, U8OrderInfo orderInfo); // 0x0000000189DF5474-0x0000000189DF56BC
		private void _OnNativePayFulfilled(long revenue); // 0x0000000189DF5CF0-0x0000000189DF5DAC
		private bool _TryGetProduct(int storeId, out U8ProductInfo productInfo); // 0x0000000189DF5DCC-0x0000000189DF5E9C
		private U8PayParams _GeneratePayParams(U8ProductInfo productInfo, U8OrderInfo orderInfo); // 0x0000000189DF5A70-0x0000000189DF5C0C
		private SDKPromise<U8PayResult> _NativePay(U8PayParams payParams); // 0x0000000189DF5C0C-0x0000000189DF5CF0
		private static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default);
		public SDKMeta PublicLoadSDKMeta(); // 0x0000000189DF52F8-0x0000000189DF53D4
		protected abstract string LoadExtraConfig();
		protected abstract void V2Init(string env);
		protected abstract void Login();
		protected abstract void LoginCustom(string customData);
		protected abstract bool Logout();
		public abstract bool ShowAccountCenter();
		public abstract void SubmitGameData(U8ExtraGameData data);
		protected abstract void Pay(U8PayParams data);
		public abstract void SetData(int type, string paramJson);
		public abstract string GetData(int type, string paramJson);
		protected abstract SDKMeta LoadSDKMeta();
		protected abstract bool IsNativePlugin();
		public abstract void SetGameVersion(string version);
		[IteratorStateMachine(typeof(__NextFrameCoroutine_d__105))]
		private IEnumerator _NextFrameCoroutine(Action call); // 0x0000000183A84D40-0x0000000183A84DA0
		protected void InvokeNextFrame(Action action); // 0x0000000183A84CB0-0x0000000183A84D40
		protected void InvokeCoroutine(IEnumerator coroutine); // 0x00000001840EB180-0x00000001840EB1E0
		protected string EncodeGameData(U8ExtraGameData data); // 0x0000000183AF99C0-0x0000000183AF9CD0
		protected string EncodePayParams(U8PayParams data); // 0x0000000189DF4E14-0x0000000189DF51D0
		public SDKPromise<string> V2PublicLogin(); // 0x00000001840EB080-0x00000001840EB100
		public SDKPromise<U8AuthV2Result> V2PublicAuth(); // 0x0000000183A84850-0x0000000183A848B0
		public SDKPromise<U8OrderInfo> U1PublicCreateOrder(string productId, string signParams); // 0x0000000189DF5798-0x0000000189DF5818
		public SDKPromise<List<U8ServerInfo>> U1PublicGetServerList(); // 0x0000000189DF5818-0x0000000189DF5874
		public SDKPromise<U8ConfirmServerResult> U1PublicConfirmServer(string serverId); // 0x0000000189DF572C-0x0000000189DF5798
		public SDKPromise<U8ConfirmOrderResult> U1PublicConfirmOrder(string orderId, string extension); // 0x0000000189DF56C4-0x0000000189DF572C
		private SDKPromise<U8AuthV2Result> _DoMockAuthV2(); // 0x0000000183A848B0-0x0000000183A849A0
		[IteratorStateMachine(typeof(__LoginV2Coroutine_d__132))]
		private IEnumerator _LoginV2Coroutine(SDKPromise<string> promise); // 0x00000001840EB100-0x00000001840EB180
		private void _OnSessionTokenInvalid(); // 0x0000000189DF5DAC-0x0000000189DF5DCC
		[IteratorStateMachine(typeof(__AuthV2Coroutine_d__134))]
		private IEnumerator _AuthV2Coroutine(SDKPromise<U8AuthV2Result> promise); // 0x0000000189DF59FC-0x0000000189DF5A70
		[CompilerGenerated]
		private void _PublicLogout_b__65_0(); // 0x0000000189DF5874-0x0000000189DF5998
		[CompilerGenerated]
		private void _PublicLogout_b__65_1(); // 0x0000000189DF5998-0x0000000189DF59A8
		[CompilerGenerated]
		private void _PublicLogout_b__65_2(); // 0x0000000189DF59A8-0x0000000189DF59FC
	}

	public struct SDKError // TypeDefIndex: 61666
	{
		// Fields
		[CompilerGenerated]
		private string _code_k__BackingField; // 0x00
		[CompilerGenerated]
		private string _msg_k__BackingField; // 0x08
	
		// Properties
		private string code { [CompilerGenerated] set; } // 0x0000000185392320-0x0000000185392328
		private string msg { [CompilerGenerated] set; } // 0x00000001867D5E9C-0x00000001867D5EAC
	
		// Constructors
		public SDKError(string content); // 0x0000000189DE6ED8-0x0000000189DE7100
	}

	public struct U8MockLogin // TypeDefIndex: 61667
	{
		// Fields
		public static readonly U8MockLogin EMPTY; // 0x00
		public string uid; // 0x00
		public string token; // 0x08
	
		// Methods
		public bool IsEmpty(); // 0x0000000185394A74-0x0000000185394A8C
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ProductInfo // TypeDefIndex: 61668
	{
		// Fields
		[JsonProperty("store_id")]
		public int store_id; // 0x10
		[JsonProperty("product_id")]
		public string product_id; // 0x18
		[JsonProperty("desc")]
		public string desc; // 0x20
		[JsonProperty("name")]
		public string name; // 0x28
		[JsonProperty("price")]
		public long price; // 0x30
		[JsonProperty("channel_product_id")]
		public string channel_product_id; // 0x38
		[JsonProperty("display_price")]
		public string display_price; // 0x40
	
		// Constructors
		public U8ProductInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ProductsResult // TypeDefIndex: 61669
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("u8Products")]
		public List<U8ProductInfo> u8Products; // 0x18
	
		// Constructors
		public U8ProductsResult(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ServerInfo // TypeDefIndex: 61670
	{
		// Fields
		[JsonProperty("serverId")]
		public string serverId; // 0x10
		[JsonProperty("serverName")]
		public string serverName; // 0x18
		[JsonProperty("serverDomain")]
		public string serverDomain; // 0x20
		[JsonProperty("defaultChoose")]
		public bool defaultChoose; // 0x28
		[JsonProperty("roleId")]
		public string roleId; // 0x30
		[JsonProperty("nickName")]
		public string nickName; // 0x38
		[JsonProperty("level")]
		public long level; // 0x40
		[JsonProperty("extension")]
		public string extension; // 0x48
	
		// Constructors
		public U8ServerInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ServerErrorInfo // TypeDefIndex: 61671
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("errorCode")]
		public int errorCode; // 0x14
	
		// Constructors
		public U8ServerErrorInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class U8OrderInfo // TypeDefIndex: 61672
	{
		// Fields
		[JsonProperty("orderId")]
		public string orderId; // 0x10
		[JsonProperty("channelProductCode")]
		public string channelProductCode; // 0x18
		[JsonProperty("productName")]
		public string productName; // 0x20
		[JsonProperty("productDesc")]
		public string productDesc; // 0x28
		[JsonProperty("amount")]
		public long amount; // 0x30
		[JsonProperty("extension")]
		public string extension; // 0x38
	
		// Constructors
		public U8OrderInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class U8PayParams // TypeDefIndex: 61673
	{
		// Fields
		[JsonProperty("productId")]
		public string productId; // 0x10
		[JsonProperty("productName")]
		public string productName; // 0x18
		[JsonProperty("productDesc")]
		public string productDesc; // 0x20
		[JsonProperty("price")]
		public long price; // 0x28
		[JsonProperty("buyNum")]
		public int buyNum; // 0x30
		[JsonProperty("coinNum")]
		public int coinNum; // 0x34
		[JsonProperty("serverId")]
		public string serverId; // 0x38
		[JsonProperty("serverName")]
		public string serverName; // 0x40
		[JsonProperty("roleId")]
		public string roleId; // 0x48
		[JsonProperty("roleName")]
		public string roleName; // 0x50
		[JsonProperty("roleLevel")]
		public int roleLevel; // 0x58
		[JsonProperty("vip")]
		public string vip; // 0x60
		[JsonProperty("orderID")]
		public string orderID; // 0x68
		[JsonProperty("worldID")]
		public string worldID; // 0x70
		[JsonProperty("token")]
		public string token; // 0x78
		[JsonProperty("appKey")]
		public string appKey; // 0x80
		[JsonProperty("extension")]
		public string extension; // 0x88
		[JsonProperty("addition")]
		public string addition; // 0x90
	
		// Constructors
		public U8PayParams(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ExtraGameData // TypeDefIndex: 61674
	{
		// Fields
		[JsonProperty("dataType")]
		public int dataType; // 0x10
		[JsonProperty("uid")]
		public string uid; // 0x18
		[JsonProperty("roleID")]
		public string roleID; // 0x20
		[JsonProperty("roleName")]
		public string roleName; // 0x28
		[JsonProperty("roleLevel")]
		public string roleLevel; // 0x30
		[JsonProperty("serverID")]
		public int serverID; // 0x38
		[JsonProperty("serverName")]
		public string serverName; // 0x40
		[JsonProperty("channel")]
		public string channel; // 0x48
		[JsonProperty("subChannel")]
		public string subChannel; // 0x50
		[JsonProperty("isNewUser")]
		public bool isNewUser; // 0x58
		[JsonProperty("revenue")]
		public long revenue; // 0x60
		[JsonProperty("customEventName")]
		public string customEventName; // 0x68
		[JsonProperty("customEventParams")]
		public string customEventParams; // 0x70
	
		// Constructors
		public U8ExtraGameData(); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct U8LoginResult // TypeDefIndex: 61675
	{
		// Fields
		public static readonly U8LoginResult EMPTY; // 0x00
		public int result; // 0x00
		public string uid; // 0x08
		public string channelUid; // 0x10
		public string token; // 0x18
		public string extension; // 0x20
		public bool isGuest; // 0x28
		public bool isNew; // 0x29
		public string error; // 0x30
	
		// Methods
		public override string ToString(); // 0x0000000189DF391C-0x0000000189DF3AF0
	}

	public struct U8ProductError // TypeDefIndex: 61676
	{
		// Fields
		public int status; // 0x00
		public int errorCode; // 0x04
	}

	public enum PayResultStatus // TypeDefIndex: 61677
	{
		SUCCEED = 0,
		PENDING = 1
	}

	public enum PayFailStatus // TypeDefIndex: 61678
	{
		UNKNOWN = 0,
		CANCELED = 1,
		ERROR = 2,
		HALT = 3
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ConfirmServerResult // TypeDefIndex: 61679
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("message")]
		public string message; // 0x18
	
		// Constructors
		public U8ConfirmServerResult(); // 0x00000001841E1670-0x00000001841E1680
	}

	public enum U8ConfirmOrderStatus // TypeDefIndex: 61680
	{
		NONE = 0,
		INTERNAL_ERROR = 1,
		TIMEOUT = 2,
		INVALID_ORDER = 3,
		SUCCEED = 4
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ConfirmOrderResult // TypeDefIndex: 61681
	{
		// Fields
		[JsonProperty("status")]
		public U8ConfirmOrderStatus status; // 0x10
		[JsonProperty("message")]
		public string message; // 0x18
	
		// Constructors
		public U8ConfirmOrderResult(); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct U8PayFailMsg // TypeDefIndex: 61682
	{
		// Fields
		public static U8PayFailMsg EMPTY; // 0x00
		public PayFailStatus status; // 0x00
		public string message; // 0x08
		public string extension; // 0x10
	
		// Constructors
		static U8PayFailMsg(); // 0x0000000189DF3F54-0x0000000189DF3FB8
	
		// Methods
		public static U8PayFailMsg FromJson(string jsonStr); // 0x0000000189DF3B64-0x0000000189DF3F54
	}

	public struct U8PayResult // TypeDefIndex: 61683
	{
		// Fields
		public static readonly U8PayResult EMPTY; // 0x00
		public PayResultStatus status; // 0x00
		public string outTradeNo; // 0x08
		public string extension; // 0x10
	
		// Constructors
		static U8PayResult(); // 0x0000000189DF4424-0x0000000189DF4498
	
		// Methods
		public static U8PayResult FromJson(string jsonData); // 0x0000000189DF3FB8-0x0000000189DF4338
		public override string ToString(); // 0x0000000189DF4338-0x0000000189DF4424
	}

	public class SDKInterfaceCloud : U8SDKInterface // TypeDefIndex: 61698
	{
		// Fields
		private int actionIndex; // 0xD0
		private static Dictionary<int, Action<string>> dictAction; // 0x00
		private string languageParam; // 0xD8
	
		// Nested types
		public delegate void DataCallback(int index, string paramValue); // TypeDefIndex: 61684; 0x00000001838E1420-0x00000001838E1430
	
		public delegate void U8SDKSendMessageCallback(string methodName, string paramValue); // TypeDefIndex: 61685; 0x00000001838E1420-0x00000001838E1430
	
		[UnityEngine.Scripting.Preserve]
		public class LoginResult // TypeDefIndex: 61686
		{
			// Fields
			[JsonProperty("code")]
			public LoginResultCode code; // 0x10
			[JsonProperty("msg")]
			public JToken msg; // 0x18
	
			// Constructors
			public LoginResult(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public enum LoginResultCode // TypeDefIndex: 61687
		{
			Success = 0,
			Canceled = 1,
			Failed = 2
		}
	
		[UnityEngine.Scripting.Preserve]
		public class PaymentResult // TypeDefIndex: 61688
		{
			// Fields
			[JsonProperty("code")]
			public PaymentResultCode code; // 0x10
			[JsonProperty("msg")]
			public JToken msg; // 0x18
	
			// Constructors
			public PaymentResult(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public enum PaymentResultCode // TypeDefIndex: 61689
		{
			Success = 0,
			Failed = 1
		}
	
		private enum SetDataCode // TypeDefIndex: 61690
		{
			CustomerServiceCenter = 6,
			QueryProductList = 17,
			SplashProtocol = 29,
			GameAgreement = 30,
			CloudShareEvent = 36,
			ShowGameProtocol = 41,
			CustomerUnreadMsgCount = 1003,
			SetLanguage = 2001,
			SetU8Token = 2002
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 61691
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoadExtraConfig_b__0(string data); // 0x0000000182D40530-0x0000000182D40590
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 61692
		{
			// Fields
			public string defaultValue; // 0x10
			public int type; // 0x18
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetData_b__0(string data); // 0x0000000182D40590-0x0000000182D40940
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 61693
		{
			// Fields
			public string json; // 0x10
	
			// Constructors
			public __c__DisplayClass55_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoadSDKMeta_b__0(string data); // 0x0000000182D40530-0x0000000182D40590
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 61695
		{
			// Fields
			public SDKInterfaceCloud __4__this; // 0x10
			public string jsonData; // 0x18
	
			// Nested types
			private struct __HandleCloudShareEvent_b__0_d : IAsyncStateMachine // TypeDefIndex: 61694
			{
				// Fields
				public int __1__state; // 0x00
				public AsyncTaskMethodBuilder __t__builder; // 0x08
				public __c__DisplayClass74_0 __4__this; // 0x20
				private TaskAwaiter __u__1; // 0x28
	
				// Methods
				private void MoveNext(); // 0x0000000182D3EC60-0x0000000182D40110
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000182D40110-0x0000000182D40530
			}
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal async System.Threading.Tasks.Task _HandleCloudShareEvent_b__0(); // 0x0000000182D40940-0x0000000182D41100
		}
	
		[CompilerGenerated]
		private struct _SaveImageToTargetFolder_d__75 : IAsyncStateMachine // TypeDefIndex: 61696
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public string jsonData; // 0x20
			public SDKInterfaceCloud __4__this; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000182D3C490-0x0000000182D3E840
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000182D3E840-0x0000000182D3EC60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0 // TypeDefIndex: 61697
		{
			// Fields
			public string methodName; // 0x10
			public string paramValue; // 0x18
	
			// Constructors
			public __c__DisplayClass77_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SendMessageInMain_b__0(); // 0x0000000182D41100-0x0000000182D41A30
		}
	
		// Constructors
		public SDKInterfaceCloud(); // 0x0000000189DED060-0x0000000189DED240
		static SDKInterfaceCloud(); // 0x0000000189DECFD4-0x0000000189DED060
	
		// Methods
		~SDKInterfaceCloud(); // 0x0000000189DEA138-0x0000000189DEA298
		public int AddAction(Action<string> action); // 0x0000000189DE95CC-0x0000000189DE9724
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void DataActionCallback(int index, string paramValue); // 0x0000000189DE9F4C-0x0000000189DEA138
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void ASyncDataActionCallback(int index, string paramValue); // 0x0000000189DE93E0-0x0000000189DE95CC
		[AOT.MonoPInvokeCallback(typeof(U8SDKSendMessageCallback))]
		public static void U8SDKSendMessage(string methodName, string paramValue); // 0x0000000189DECE5C-0x0000000189DECEC4
		public static extern void HGU8SDKInitLibrary(string windowText, long windowHandle); // 0x0000000189DEA790-0x0000000189DEA7E0
		public static extern int HGU8SDKSetUserDataPath(string path); // 0x0000000189DEA8EC-0x0000000189DEA940
		public static extern void HGU8SDKUnInitLibrary(); // 0x0000000189DEA940-0x0000000189DEA964
		public static extern void HGU8SDKInitDatacallback(DataCallback Callback, DataCallback asyncCallback); // 0x0000000189DEA740-0x0000000189DEA790
		public static extern void HGU8SDKInitSendMessage(U8SDKSendMessageCallback callback); // 0x0000000189DEA7E0-0x0000000189DEA828
		public static extern void HGU8SDKV2Init(string env); // 0x0000000189DEA964-0x0000000189DEA9A4
		public static extern void HGU8SDKGetSDKMeta(int index); // 0x0000000189DEA714-0x0000000189DEA740
		public static extern void HGU8SDKSetData(int code, string paramJson); // 0x0000000189DEA854-0x0000000189DEA8A4
		public static extern void HGU8SDKGetData(int code, string paramJson, int index); // 0x0000000189DEA6B4-0x0000000189DEA714
		public static extern void HGU8SDKLoadExtraConfig(int index); // 0x0000000189DEA828-0x0000000189DEA854
		public static extern void HGU8SDKSetGameVersion(string version); // 0x0000000189DEA8A4-0x0000000189DEA8EC
		protected override string LoadExtraConfig(); // 0x0000000189DEB5A4-0x0000000189DEB6A0
		protected override void V2Init(string env); // 0x0000000189DECEC4-0x0000000189DECFD4
		protected override void Login(); // 0x0000000189DEBAFC-0x0000000189DEBC1C
		private void LoginCallback(CloudCallResult result); // 0x0000000189DEB7D0-0x0000000189DEBAEC
		protected override bool Logout(); // 0x0000000189DEBC1C-0x0000000189DEBC6C
		protected override void LoginCustom(string customData); // 0x0000000189DEBAEC-0x0000000189DEBAFC
		public override void SubmitGameData(U8ExtraGameData data); // 0x0000000189DECD8C-0x0000000189DECE5C
		public override void SetData(int type, string paramJson); // 0x0000000189DEC530-0x0000000189DEC6FC
		public override string GetData(int type, string paramJson); // 0x0000000189DEA298-0x0000000189DEA3BC
		public override bool ShowAccountCenter(); // 0x0000000189DECA34-0x0000000189DECB30
		private void ShowAccountCenterCallback(CloudCallResult result); // 0x0000000189DEC7CC-0x0000000189DECA34
		protected override void Pay(U8PayParams data); // 0x0000000189DEC15C-0x0000000189DEC274
		private void PayCallback(CloudCallResult result); // 0x0000000189DEBE40-0x0000000189DEC15C
		protected override SDKMeta LoadSDKMeta(); // 0x0000000189DEB6A0-0x0000000189DEB7D0
		protected override bool IsNativePlugin(); // 0x0000000182FFF600-0x0000000182FFF610
		public override void SetGameVersion(string version); // 0x0000000189DEC6FC-0x0000000189DEC7CC
		private void HandleSplashProtocol(string paramJson); // 0x0000000189DEB550-0x0000000189DEB5A4
		private void HandleGameAgreement(string paramJson); // 0x0000000182D39980-0x0000000182D3B430
		private void HandleSetLanguage(string paramJson); // 0x0000000182D3B430-0x0000000182D3C490
		private void HandleSetU8Token(string paramJson); // 0x0000000189DEB304-0x0000000189DEB410
		private void HandleShowGameProtocol(string paramJson); // 0x0000000189DEB410-0x0000000189DEB550
		private void ShowGameProtocolCallback(CloudCallResult result); // 0x0000000189DECB30-0x0000000189DECD8C
		private void HandleQueryProductList(string paramJson); // 0x0000000189DEB0A8-0x0000000189DEB304
		private void HandleCustomerServiceCenter(string paramJson); // 0x0000000189DEAE28-0x0000000189DEAF68
		private void CustomerServiceCenterCallback(CloudCallResult result); // 0x0000000189DE9A0C-0x0000000189DE9C68
		private void HandleCustomerUnreadMsgCount(string paramJson); // 0x0000000189DEAF68-0x0000000189DEB0A8
		private void CustomerUnreadMsgCountCallback(CloudCallResult result); // 0x0000000189DE9C68-0x0000000189DE9F4C
		private void HandleCloudShareEvent(string paramJson, string fileNamePrefix = null); // 0x0000000189DEA9A4-0x0000000189DEAE28
		private async System.Threading.Tasks.Task SaveImageToTargetFolder(string jsonData); // 0x0000000189DEC388-0x0000000189DEC458
		private void CloudShareEventCallback(CloudCallResult result); // 0x0000000189DE9724-0x0000000189DE9A0C
		private void SendMessageInMain(string methodName, string paramValue); // 0x0000000189DEC458-0x0000000189DEC530
		private static void OnPipelineConnected(CloudCallResult result); // 0x0000000189DEBC6C-0x0000000189DEBE40
		private static void RequestLaunchInfoCallback(CloudCallResult result); // 0x0000000189DEC274-0x0000000189DEC388
		private static void GetThinClientDeviceInfo(string jsonData); // 0x0000000189DEA3BC-0x0000000189DEA6B4
	}

	public class SDKInterfaceWIN : U8SDKInterface // TypeDefIndex: 61705
	{
		// Fields
		private int actionIndex; // 0xD0
		private static Dictionary<int, Action<string>> dictAction; // 0x00
	
		// Nested types
		public delegate void DataCallback(int index, string paramValue); // TypeDefIndex: 61699; 0x00000001838E1420-0x00000001838E1430
	
		public delegate void U8SDKSendMessageCallback(string methodName, string paramValue); // TypeDefIndex: 61700; 0x00000001838E1420-0x00000001838E1430
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 61701
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoadExtraConfig_b__0(string data); // 0x00000001853908C0-0x00000001853908D0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61702
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<System.Threading.Tasks.Task> __9__42_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189DF19AC-0x0000000189DF1A10
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SetData_b__42_0(System.Threading.Tasks.Task task); // 0x0000000189DF0440-0x0000000189DF0518
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 61703
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetData_b__0(string data); // 0x00000001853908C0-0x00000001853908D0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 61704
		{
			// Fields
			public string json; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoadSDKMeta_b__0(string data); // 0x00000001853908C0-0x00000001853908D0
		}
	
		// Constructors
		public SDKInterfaceWIN(); // 0x0000000184756120-0x00000001847562C0
		static SDKInterfaceWIN(); // 0x0000000184D16E60-0x0000000184D16EF0
	
		// Methods
		~SDKInterfaceWIN(); // 0x0000000189DED42C-0x0000000189DED4F8
		public int AddAction(Action<string> action); // 0x0000000183AFA8E0-0x0000000183AFAAF0
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void DataActionCallback(int index, string paramValue); // 0x0000000183A849A0-0x0000000183A84C50
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void ASyncDataActionCallback(int index, string paramValue); // 0x0000000189DED240-0x0000000189DED42C
		[AOT.MonoPInvokeCallback(typeof(U8SDKSendMessageCallback))]
		public static void U8SDKSendMessage(string methodName, string paramValue); // 0x0000000183A84DA0-0x0000000183A84E20
		public static extern void HGU8SDKInitLibrary(string windowText, long windowHandle); // 0x00000001847563F0-0x0000000184756450
		public static extern int HGU8SDKSetUserDataPath(string path); // 0x0000000184756390-0x00000001847563F0
		public static extern void HGU8SDKUnInitLibrary(); // 0x0000000189DED76C-0x0000000189DED790
		public static extern void HGU8SDKInitDatacallback(DataCallback Callback, DataCallback asyncCallback); // 0x0000000183826E60-0x0000000183826EB0
		public static extern void HGU8SDKInitSendMessage(U8SDKSendMessageCallback callback); // 0x0000000183826BA0-0x0000000183826C30
		public static extern void HGU8SDKV2Init(string env); // 0x000000018488EC70-0x000000018488ECC0
		public static extern void HGU8SDKLogin(); // 0x0000000189DED5AC-0x0000000189DED614
		public static extern void HGU8SDKLoginCustom(string json); // 0x0000000189DED524-0x0000000189DED5AC
		public static extern int HGU8SDKLogout(); // 0x0000000189DED614-0x0000000189DED67C
		public static extern int HGU8SDKShowAccountCenter(); // 0x0000000189DED704-0x0000000189DED76C
		public static extern void HGU8SDKPay(string json); // 0x0000000189DED67C-0x0000000189DED704
		public static extern void HGU8SDKSubmitGameData(string json); // 0x0000000183AF9CD0-0x0000000183AF9D30
		public static extern void HGU8SDKGetSDKMeta(int index); // 0x0000000189DED4F8-0x0000000189DED524
		public static extern void HGU8SDKSetData(int code, string paramJson); // 0x0000000183A86A60-0x0000000183A86AC0
		public static extern void HGU8SDKGetData(int code, string paramJson, int index); // 0x0000000183AFAE80-0x0000000183AFAEF0
		public static extern int HGU8SDKIsNativePlugin(); // 0x0000000183826C30-0x0000000183826CA0
		public static extern void HGU8SDKLoadExtraConfig(int index); // 0x0000000183AFAEF0-0x0000000183AFAF20
		public static extern void HGU8SDKSetGameVersion(string version); // 0x0000000184CC88A0-0x0000000184CC8900
		protected override string LoadExtraConfig(); // 0x0000000183AFA690-0x0000000183AFA7A0
		protected override void V2Init(string env); // 0x000000018488EB00-0x000000018488EB90
		protected override void Login(); // 0x0000000189DED90C-0x0000000189DED94C
		protected override bool Logout(); // 0x0000000189DED94C-0x0000000189DED994
		protected override void LoginCustom(string customData); // 0x0000000189DED8C0-0x0000000189DED90C
		public override void SubmitGameData(U8ExtraGameData data); // 0x0000000183AF9950-0x0000000183AF99C0
		public override void SetData(int type, string paramJson); // 0x0000000183A869B0-0x0000000183A86A60
		public override string GetData(int type, string paramJson); // 0x0000000183AFA7A0-0x0000000183AFA8E0
		public override bool ShowAccountCenter(); // 0x0000000189DED9F4-0x0000000189DEDA3C
		protected override void Pay(U8PayParams data); // 0x0000000189DED994-0x0000000189DED9F4
		protected override SDKMeta LoadSDKMeta(); // 0x0000000189DED790-0x0000000189DED8C0
		protected override bool IsNativePlugin(); // 0x0000000184D59840-0x0000000184D59890
		public override void SetGameVersion(string version); // 0x0000000184CC8850-0x0000000184CC88A0
	}

	public class SDKMeta // TypeDefIndex: 61706
	{
		// Fields
		public string appID; // 0x10
		public string appKey; // 0x18
		public string channel; // 0x20
		public string worldId; // 0x28
		public string extension; // 0x30
		public string appCode; // 0x38
	
		// Constructors
		public SDKMeta(); // 0x00000001841E1670-0x00000001841E1680
		public SDKMeta(string jsonData); // 0x0000000189DEDBA0-0x0000000189DEDECC
	
		// Methods
		public override string ToString(); // 0x0000000189DEDA3C-0x0000000189DEDBA0
	}

	public interface ISDKPromise // TypeDefIndex: 61707
	{
		// Methods
		void Fulfill(object param);
		void Reject(object reason);
	}

	public class SDKPromise<Param> : ISDKPromise // TypeDefIndex: 61708
	{
		// Fields
		public Action<Param> onFulfilled;
		public Action<object> onRejected;
	
		// Constructors
		public SDKPromise();
	
		// Methods
		public virtual void Fulfill(object param);
		public virtual void Reject(object reason);
	}

	public class SDKPromiseWithResult<Param> : SDKPromise<Param> // TypeDefIndex: 61709
		where Param : class
	{
		// Fields
		[CompilerGenerated]
		private Param _result_k__BackingField;
		[CompilerGenerated]
		private object _rejectInfo_k__BackingField;
	
		// Properties
		public Param result { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public object rejectInfo { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public SDKPromiseWithResult();
	
		// Methods
		public override void Fulfill(object param);
		public override void Reject(object reason);
	}

	public class SDKPromiseEnumerator<T> // TypeDefIndex: 61712
	{
		// Fields
		private State m_state;
		[CompilerGenerated]
		private T _result_k__BackingField;
		[CompilerGenerated]
		private object _reject_k__BackingField;
	
		// Properties
		public bool isFulfilled { get; }
		public T result { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public object reject { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum State // TypeDefIndex: 61710
		{
			NONE = 0,
			FULFILL = 1,
			REJECT = 2
		}
	
		[CompilerGenerated]
		private sealed class _Yield_d__12 : IEnumerator<object> // TypeDefIndex: 61711
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SDKPromiseEnumerator<T> __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Yield_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SDKPromiseEnumerator(SDKPromise<T> promise);
	
		// Methods
		[IteratorStateMachine(typeof(_Yield_d__12))]
		public IEnumerator Yield();
		private void _OnFulfilled(T result);
		private void _OnRejected(object rejectInfo);
	}

	public class SDKPromiseWrapper // TypeDefIndex: 61713
	{
		// Fields
		private ISDKPromise m_promise; // 0x10
	
		// Constructors
		public SDKPromiseWrapper(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public T EnsurePromise<T>()
			where T : ISDKPromise, new();
		public void Fulfill(object param); // 0x00000001849DAAB0-0x00000001849DAB40
		public void Reject(object reason); // 0x0000000189DEDEE4-0x0000000189DEDF14
		private void _Clear(); // 0x00000001840E20A0-0x00000001840E20C0
	}

	public static class SDKPromiseExtensions // TypeDefIndex: 61714
	{
		// Extension methods
		public static void RejectWithString(this ISDKPromise promise, string errorInfo); // 0x0000000189DEDECC-0x0000000189DEDEE4
		public static void FulfillWithType<T>(this SDKPromise<T> promise, T param)
			where T : class;
	}

	public class U8SDKTickEvent : MonoBehaviour // TypeDefIndex: 61715
	{
		// Constructors
		public U8SDKTickEvent(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Update(); // 0x0000000183F31120-0x0000000183F31150
		public static extern void HGU8SDKTickEvent(); // 0x0000000183F31120-0x0000000183F31150
	}

	public class U8TickEventManager // TypeDefIndex: 61716
	{
		// Fields
		private GameObject tickGameObject; // 0x10
		private U8SDKTickEvent tickEvent; // 0x18
		private static U8TickEventManager instanceManager; // 0x00
		private static readonly object lockObject; // 0x08
	
		// Properties
		public static U8TickEventManager InstanceManager { get; } // 0x000000018488EB90-0x000000018488EC70 
	
		// Constructors
		public U8TickEventManager(); // 0x00000001841E1670-0x00000001841E1680
		static U8TickEventManager(); // 0x0000000184D30310-0x0000000184D30380
	
		// Methods
		public void InitTickEvent(); // 0x000000018488ECC0-0x000000018488F060
		public void UnInitTickEvent(); // 0x0000000189DF6094-0x0000000189DF625C
	}

	[UnityEngine.Scripting.Preserve]
	public class U8LoginV2Result // TypeDefIndex: 61717
	{
		// Fields
		[JsonProperty("token")]
		public string token; // 0x10
		[JsonProperty("uid")]
		public string uid; // 0x18
		[JsonProperty("isNew")]
		public bool isNew; // 0x20
	
		// Constructors
		public U8LoginV2Result(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class U8AuthV2Result // TypeDefIndex: 61718
	{
		// Fields
		[JsonProperty("uid")]
		public string uid; // 0x10
		[JsonProperty("oauth2Code")]
		public string oauth2Code; // 0x18
		[JsonProperty("oauth2Token")]
		public string oauth2Token; // 0x20
	
		// Constructors
		public U8AuthV2Result(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class U8GrantResult // TypeDefIndex: 61719
	{
		// Fields
		[JsonProperty("uid")]
		public string uid; // 0x10
		[JsonProperty("code")]
		public string code; // 0x18
		[JsonProperty("token")]
		public string token; // 0x20
	
		// Constructors
		public U8GrantResult(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class U8SDKCallback : MonoBehaviour // TypeDefIndex: 61721
	{
		// Fields
		private static U8SDKCallback m_instance; // 0x00
		private static object m_lock; // 0x08
	
		// Nested types
		[CompilerGenerated]
		private sealed class __onLogoutNextFrameCoroutine_d__13 : IEnumerator<object> // TypeDefIndex: 61720
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __onLogoutNextFrameCoroutine_d__13(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189DF37F8-0x0000000189DF38D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189DF38D0-0x0000000189DF391C
		}
	
		// Constructors
		public U8SDKCallback(); // 0x0000000185393520-0x0000000185393538
		static U8SDKCallback(); // 0x0000000184D30380-0x0000000184D303F0
	
		// Methods
		public static U8SDKCallback InitCallback(); // 0x0000000183A84E20-0x0000000183A85230
		public void OnInitSuc(string extConfigs); // 0x00000001849DA9B0-0x00000001849DAA10
		public void OnInitFail(string info); // 0x0000000189DF4908-0x0000000189DF4960
		public void OnLoginSuc(string extension); // 0x00000001849DAA30-0x00000001849DAA90
		public void OnLoginFail(string info); // 0x0000000189DF4960-0x0000000189DF49B8
		public void OnLogout(string info); // 0x0000000189DF49B8-0x0000000189DF4A04
		public void OnSwitchAccount(); // 0x0000000189DF4B24-0x0000000189DF4B70
		public void OnPaySuc(string jsonData); // 0x0000000189DF4A5C-0x0000000189DF4AB4
		public void OnPayFail(string failMsg); // 0x0000000189DF4A04-0x0000000189DF4A5C
		public void OnSDKError(string jsonData); // 0x0000000189DF4AB4-0x0000000189DF4B24
		public void OnExtraInfo(string jsonData); // 0x00000001835A5E80-0x00000001835A6000
		[IteratorStateMachine(typeof(__onLogoutNextFrameCoroutine_d__13))]
		private IEnumerator _onLogoutNextFrameCoroutine(); // 0x0000000189DF4B70-0x0000000189DF4BB4
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default);
	}

	public static class OneChannelSDKVersion // TypeDefIndex: 61722
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static OneChannelSDKVersion(); // 0x0000000184D4FF60-0x0000000184D4FFC0
	}

	public enum GameType // TypeDefIndex: 61723
	{
		Local = 0,
		Cloud = 1
	}

	public class CloudGameUtil // TypeDefIndex: 61724
	{
		// Fields
		private static int m_thinClientPlatform; // 0x00
		private static string m_thinClientDeviceProperties; // 0x08
	
		// Properties
		public static int ThinClientPlatform { get; set; } // 0x0000000189DE4854-0x0000000189DE48A4 0x0000000189DE4904-0x0000000189DE4958
		public static string ThinClientDeviceProperties { get; set; } // 0x0000000189DE4804-0x0000000189DE4854 0x0000000189DE48A4-0x0000000189DE4904
	
		// Constructors
		static CloudGameUtil(); // 0x0000000184D4FB30-0x0000000184D4FBA0
	
		// Methods
		public static bool IsCloudGame(); // 0x00000001840BC9E0-0x00000001840BCB50
	}

	public class ImageSaver // TypeDefIndex: 61734
	{
		// Nested types
		private enum FolderType // TypeDefIndex: 61725
		{
			UserPicturesFolder = 0,
			GameInstalledFolder = 1
		}
	
		private enum ErrorCode // TypeDefIndex: 61726
		{
			UnknowError = -1,
			NotInited = 0,
			ParamsError = 1,
			ImageNotFound = 3,
			ShareChannelError = 6,
			SaveFailed = 8
		}
	
		private enum CallbackResult : byte // TypeDefIndex: 61727
		{
			Success = 0,
			Cancelled = 1,
			Failed = 2
		}
	
		[UnityEngine.Scripting.Preserve]
		public class ImageShareInfo // TypeDefIndex: 61728
		{
			// Fields
			[JsonProperty("shareChannel")]
			public int shareChannel; // 0x10
			[JsonProperty("extraData")]
			public string extraData; // 0x18
			[JsonProperty("imgPath")]
			public string imgPath; // 0x20
			[JsonProperty("relativePath")]
			public string relativePath; // 0x28
			[JsonProperty("folderType")]
			public int folderType; // 0x30
			[JsonProperty("title")]
			public string title; // 0x38
			[JsonProperty("desc")]
			public string desc; // 0x40
	
			// Constructors
			public ImageShareInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private struct _SaveImage_d__5 : IAsyncStateMachine // TypeDefIndex: 61729
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public ImageSaver __4__this; // 0x20
			public string paramJson; // 0x28
			private string _targetPath_5__2; // 0x30
			private TaskAwaiter<bool> __u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x0000000189DEFE58-0x0000000189DF0278
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189DF0278-0x0000000189DF02D4
		}
	
		[CompilerGenerated]
		private struct _SaveCloudGameImage_d__6 : IAsyncStateMachine // TypeDefIndex: 61730
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			public ImageSaver __4__this; // 0x20
			public string paramJson; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000189DEF69C-0x0000000189DEFAD0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189DEFAD0-0x0000000189DEFB30
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 61731
		{
			// Fields
			public ImageSaver __4__this; // 0x10
			public string sourcePath; // 0x18
			public string targetPath; // 0x20
			public string imgFolder; // 0x28
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _SaveImageToPathAsync_b__0(); // 0x0000000189DF0694-0x0000000189DF086C
		}
	
		[CompilerGenerated]
		private struct _SaveImageToPathAsync_d__13 : IAsyncStateMachine // TypeDefIndex: 61732
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			public ImageSaver __4__this; // 0x20
			public string sourcePath; // 0x28
			public string targetPath; // 0x30
			public string imgFolder; // 0x38
			private TaskAwaiter<bool> __u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x0000000189DEFB30-0x0000000189DEFDF8
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189DEFDF8-0x0000000189DEFE58
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 61733
		{
			// Fields
			public string methodName; // 0x10
			public string paramValue; // 0x18
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SendMessageInMain_b__0(); // 0x0000000189DF086C-0x0000000189DF08C8
		}
	
		// Constructors
		public ImageSaver(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public async System.Threading.Tasks.Task SaveImage(string paramJson); // 0x0000000189DE6094-0x0000000189DE6164
		public async Task<bool> SaveCloudGameImage(string paramJson); // 0x0000000189DE5E88-0x0000000189DE5F74
		private bool ValidateInput(string paramJson, out ImageShareInfo shareInfo); // 0x0000000189DE687C-0x0000000189DE6980
		private string NormalizeSourcePath(string imgPath); // 0x0000000189DE5C58-0x0000000189DE5DCC
		private FolderType ParseFolderType(int folderType); // 0x0000000189DE5DCC-0x0000000189DE5E88
		private string BuildTargetPath(string sourcePath, string relativePath, string baseFolder); // 0x0000000189DE5324-0x0000000189DE5450
		private bool IsDirectoryPath(string path); // 0x0000000189DE5878-0x0000000189DE592C
		private string BuildPathForDirectory(string sourcePath, string relativeDirPath, string baseFolder); // 0x0000000189DE51F8-0x0000000189DE5324
		private async Task<bool> SaveImageToPathAsync(string sourcePath, string targetPath, string imgFolder); // 0x0000000189DE5F74-0x0000000189DE6094
		private bool IsSamePath(string sourcePath, string targetPath); // 0x0000000189DE592C-0x0000000189DE5A00
		private bool ValidateMove(string sourcePath, string targetPath, string rootDir, out string error); // 0x0000000189DE6980-0x0000000189DE6B58
		private void EnsureDirectoryExists(string filePath); // 0x0000000189DE5450-0x0000000189DE54B8
		private bool MoveFile(string sourcePath, string targetPath); // 0x0000000189DE5A00-0x0000000189DE5C58
		private string GetImageSaveFolder(FolderType folderType); // 0x0000000189DE5664-0x0000000189DE5718
		private string GetWindowsPicturePath(); // 0x0000000189DE5718-0x0000000189DE5878
		private string GetGameInstalledFolder(); // 0x0000000189DE54B8-0x0000000189DE5664
		private void SendSuccessResponse(string targetPath); // 0x0000000189DE6788-0x0000000189DE687C
		private void SendErrorResponse(ErrorCode errorCode); // 0x0000000189DE6164-0x0000000189DE623C
		private void SendResponse(CallbackResult code, Dictionary<string, object> extraMsg = null); // 0x0000000189DE6314-0x0000000189DE6788
		private void SendMessageInMain(string methodName, string paramValue); // 0x0000000189DE623C-0x0000000189DE6314
	}

	public class U8MainThreadDispatcher : MonoBehaviour // TypeDefIndex: 61735
	{
		// Fields
		private static readonly ConcurrentQueue<Action> _queue; // 0x00
		private static U8MainThreadDispatcher _instance; // 0x08
		private static int _initialized; // 0x10
	
		// Constructors
		public U8MainThreadDispatcher(); // 0x0000000185393520-0x0000000185393538
		static U8MainThreadDispatcher(); // 0x0000000184A1D370-0x0000000184A1D420
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Initialize(); // 0x0000000184B46C10-0x0000000184B46E20
		public static void RunOnMainThread(Action action); // 0x0000000189DF3AF0-0x0000000189DF3B64
		private void Update(); // 0x0000000183B643C0-0x0000000183B644D0
	}
}

namespace U8.SDK.MiniJSON
{
	public static class Json // TypeDefIndex: 61739
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 61737
		{
			// Fields
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get; } // 0x0000000183140ED0-0x0000000183140F30 
			private char NextChar { get; } // 0x0000000183141060-0x00000001831410C0 
			private string NextWord { get; } // 0x0000000183140AF0-0x0000000183140BB0 
			private TOKEN NextToken { get; } // 0x0000000183140D50-0x0000000183140ED0 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 61736
			{
				NONE = 0,
				CURLY_OPEN = 1,
				CURLY_CLOSE = 2,
				SQUARED_OPEN = 3,
				SQUARED_CLOSE = 4,
				COLON = 5,
				COMMA = 6,
				STRING = 7,
				NUMBER = 8,
				TRUE = 9,
				FALSE = 10,
				NULL = 11
			}
	
			// Constructors
			private Parser(string jsonString); // 0x00000001835A6570-0x00000001835A65F0
	
			// Methods
			public static bool IsWordBreak(char c); // 0x00000001831410E0-0x0000000183141150
			public static object Parse(string jsonString); // 0x00000001835A6470-0x00000001835A6570
			public void Dispose(); // 0x0000000184702E20-0x0000000184702E60
			private Dictionary<string, object> ParseObject(); // 0x0000000183140BB0-0x0000000183140CE0
			private List<object> ParseArray(); // 0x0000000189DE6CFC-0x0000000189DE6E20
			private object ParseValue(); // 0x0000000183141150-0x0000000183141180
			private object ParseByToken(TOKEN token); // 0x0000000183141180-0x0000000183141220
			private string ParseString(); // 0x0000000183140F30-0x0000000183141060
			private object ParseNumber(); // 0x000000018321A290-0x000000018321A340
			private void EatWhitespace(); // 0x0000000183140CE0-0x0000000183140D50
		}
	
		private sealed class Serializer // TypeDefIndex: 61738
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer(); // 0x000000018403C9D0-0x000000018403CA40
	
			// Methods
			public static string Serialize(object obj); // 0x000000018403C950-0x000000018403C9D0
			private void SerializeValue(object value); // 0x000000018403CBE0-0x000000018403CDA0
			private void SerializeObject(IDictionary obj); // 0x000000018403CFB0-0x0000000184044580
			private void SerializeArray(IList anArray); // 0x0000000189DEDF14-0x0000000189DEE38C
			private void SerializeString(string str); // 0x000000018403CDA0-0x000000018403CF50
			private void SerializeOther(object value); // 0x000000018403CA40-0x000000018403CBA0
		}
	
		// Methods
		public static object Deserialize(string json); // 0x00000001835A6450-0x00000001835A6470
		public static string Serialize(object obj); // 0x0000000185395194-0x000000018539519C
	}
}
