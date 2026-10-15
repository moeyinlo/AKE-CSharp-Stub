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

// Image 60: Hypergryph.OneChannel.dll - Assembly: Hypergryph.OneChannel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88681-88824

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 88824
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_72 C8939CFEA086350CA0F084D5A8FFA18BE802D605B6111130EB5143B5882250C4; // 0x00 // Static value (base64): YQBiAGMAZABlAGYAZwBoAGkAZwBrAGwAbQBuAG8AcABxAHIAcwB0AHUAdgB3AHgAeQB6ADEAMgAzADQANQA2ADcAOAA5ADAA - Metadata: 0x02648720
	internal static readonly __StaticArrayInitTypeSize_24 C9A1311D05AB372579F6B92A220603EAB8191E15071784A11774A076DC45320B; // 0x48 // Static value (base64): AgAAAAMAAAAFAAAACgAAAA8AAAAPAAAA - Metadata: 0x02648770

	// Nested types
	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 88822
	{
	}

	private struct __StaticArrayInitTypeSize_72 // TypeDefIndex: 88823
	{
	}
}

namespace Hypergryph.PlatformFacade
{
	public class PlatformFacade // TypeDefIndex: 88820
	{
		// Methods
		public static void SetupPlatformFont(IPlatformFont iFont); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface IPlatformFont // TypeDefIndex: 88821
	{
	}
}

namespace U8.SDK
{
	public struct ExternalPluginLoginParams // TypeDefIndex: 88682
	{
		// Fields
		public Action nativeLogin; // 0x00
		public Action<string> nativeLoginCustom; // 0x08
		public Action<string> nativeOnLoginSuc; // 0x10
		public Action<string> nativeOnLoginFail; // 0x18
		public Action<U8MockLogin> markMockLogin; // 0x20
	}

	public struct ExternalPluginLogoutParams // TypeDefIndex: 88683
	{
		// Fields
		public Action nativeLogout; // 0x00
		public Action nativeOnLogoutSuc; // 0x08
		public Action nativeOnLogoutFail; // 0x10
	}

	public struct ExternalPluginPayParams // TypeDefIndex: 88684
	{
		// Fields
		public U8PayParams payParams; // 0x00
		public Func<U8PayParams, SDKPromise<U8PayResult>> nativePay; // 0x08
		public Action<U8PayResult> onPaySuc; // 0x10
		public Action<object> onPayFail; // 0x18
	}

	public interface IExternalPlugin // TypeDefIndex: 88685
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
		bool TrySetData(int type, string paramJson); // 0x00000001843FFFF0-0x0000000184400000
		bool TryGetData(int type, string paramJson, out string data); // 0x0000000187099E40-0x0000000187099E70
		bool TrySubmitGameData(U8ExtraGameData data); // 0x00000001843FFFF0-0x0000000184400000
	}

	public abstract class SDKCaptchaHandler // TypeDefIndex: 88688
	{
		// Nested types
		public enum Status // TypeDefIndex: 88686
		{
			SUC = 0,
			SYS_BUSY = 1,
			USER_CANCEL = 2,
			NOT_SUPPORT = 50,
			INVALID_PARAM = 51,
			UNKNOWN = 99
		}
	
		public class Result // TypeDefIndex: 88687
		{
			// Fields
			[CompilerGenerated]
			private Status _status_k__BackingField; // 0x10
			[CompilerGenerated]
			private int _errorCode_k__BackingField; // 0x14
			[CompilerGenerated]
			private string _captcha_k__BackingField; // 0x18
	
			// Properties
			public Status status { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
			private int errorCode { [CompilerGenerated] set; } // 0x000000018275FD70-0x000000018275FD80
			public string captcha { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
			// Constructors
			private Result(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public static Result CreateForOutput(); // 0x000000018C22DF9C-0x000000018C22DFE0
			public void MarkSucceed(string captcha); // 0x000000018C22E034-0x000000018C22E054
			public void MarkFailed(Status status, int errorCode); // 0x000000018C22E008-0x000000018C22E034
			public void MarkFailed(Status status); // 0x000000018C22DFE0-0x000000018C22E008
		}
	
		// Constructors
		protected SDKCaptchaHandler(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract IEnumerator FetchCaptchaCoroutine(string captchaParams, Result outResult);
	}

	public abstract class SDKExternalTools // TypeDefIndex: 88722
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
		protected bool inited { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		protected IExternalPlugin plugin { get; } // 0x000000018C22FC08-0x000000018C22FC58 
		protected CaptchaMgr captchaMgr { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		protected string subChannel { [CompilerGenerated] set; } // 0x0000000187835950-0x0000000187835960
	
		// Nested types
		protected interface IFromJSON // TypeDefIndex: 88689
		{
			// Methods
			bool LoadFromJSON(string json);
		}
	
		protected enum POSTStatus // TypeDefIndex: 88690
		{
			NONE = 0,
			SUC = 1,
			TIMEOUT = 2,
			ERROR = 3
		}
	
		protected enum BusType // TypeDefIndex: 88691
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
	
		protected enum ErrorType // TypeDefIndex: 88692
		{
			NONE = 0,
			TIMEOUT = 1,
			NETWORK_ERROR = 2,
			DESERIALIZE_FAILED = 3,
			BUSINESS_ERROR = 4
		}
	
		protected struct POSTRequest // TypeDefIndex: 88693
		{
			// Fields
			public string url; // 0x00
			public string body; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> nullableHeaders; // 0x18
		}
	
		protected struct POSTResult // TypeDefIndex: 88694
		{
			// Fields
			public POSTStatus status; // 0x00
			public int httpCode; // 0x04
			public string response; // 0x08
			public string error; // 0x10
	
			// Methods
			public bool ServiceFailed(); // 0x0000000186DBC8F0-0x0000000186DBC900
		}
	
		protected struct ErrMsgMeta // TypeDefIndex: 88695
		{
			// Fields
			public static readonly ErrMsgMeta EMPTY; // 0x00
			public BusType busType; // 0x00
			public ErrorType errorType; // 0x04
			public int errorCode; // 0x08
			public string alertFromServer; // 0x10
			public object meta; // 0x18
	
			// Methods
			public bool IsEmpty(); // 0x0000000186DBC900-0x0000000186DBC910
			public static ErrMsgMeta FromPOSTResult(BusType busType, POSTResult postRet); // 0x000000018C22C388-0x000000018C22C3C8
		}
	
		protected class CaptchaMgr // TypeDefIndex: 88697
		{
			// Fields
			private SDKExternalTools m_host; // 0x10
			[CompilerGenerated]
			private SDKCaptchaHandler _activeHandler_k__BackingField; // 0x18
	
			// Properties
			public SDKCaptchaHandler activeHandler { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
			// Nested types
			[CompilerGenerated]
			private sealed class _FetchCaptchaCoroutine_d__6 : IEnumerator<object> // TypeDefIndex: 88696
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public CaptchaMgr __4__this; // 0x20
				public SDKCaptchaHandler.Result outResult; // 0x28
				public Dictionary<string, object> captchaParams; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public _FetchCaptchaCoroutine_d__6(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x000000018C23561C-0x000000018C235694
				private bool MoveNext(); // 0x000000018C235240-0x000000018C2355D0
				private void __m__Finally1(); // 0x000000018C235694-0x000000018C2356C4
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018C2355D0-0x000000018C23561C
			}
	
			// Constructors
			public CaptchaMgr(SDKExternalTools host); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			[IteratorStateMachine(typeof(_FetchCaptchaCoroutine_d__6))]
			public IEnumerator FetchCaptchaCoroutine(Dictionary<string, object> captchaParams, SDKCaptchaHandler.Result outResult); // 0x000000018C22BC88-0x000000018C22BD18
		}
	
		protected class POSTProcedure // TypeDefIndex: 88700
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
			protected Builder builder { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184434430-0x0000000184434450 0x000000018C20D198-0x000000018C20D1BC
			public bool isServiceFinished { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
			public ErrMsgMeta serviceError { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187250AA0-0x0000000187250AC0 0x000000018C22DF84-0x000000018C22DF9C
			private string rawResponse { [CompilerGenerated] set; } // 0x0000000188800CB0-0x0000000188800CC0
	
			// Nested types
			public struct Builder // TypeDefIndex: 88698
			{
				// Fields
				public POSTRequest request; // 0x00
				public BusType busType; // 0x20
	
				// Methods
				public POSTProcedure Build(); // 0x000000018C22BC14-0x000000018C22BC88
				public POSTProcedure<TResp> TypedBuild<TResp>()
					where TResp : class, IFromJSON, new();
			}
	
			[CompilerGenerated]
			private sealed class _POST_d__18 : IEnumerator<object> // TypeDefIndex: 88699
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public SDKExternalTools host; // 0x20
				public POSTProcedure __4__this; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public _POST_d__18(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x000000018C2356C4-0x000000018C2357F0
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018C2357F0-0x000000018C23583C
			}
	
			// Constructors
			public POSTProcedure(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public ErrMsgMeta MakeBusinessError(int errorCode); // 0x0000000187250A60-0x0000000187250AA0
			[IteratorStateMachine(typeof(_POST_d__18))]
			public IEnumerator POST(SDKExternalTools host); // 0x000000018C22DDF8-0x000000018C22DE70
			private void _OnServiceFinished(POSTResult postRet); // 0x000000018C22DE70-0x000000018C22DF84
			protected virtual void HandleServiceResponse(POSTResult postRet); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		protected class POSTProcedure<TResp> : POSTProcedure // TypeDefIndex: 88701
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
	
		protected class AuthV2SessionTokenResp : IFromJSON // TypeDefIndex: 88702
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public string token; // 0x28
			public string uid; // 0x30
			public bool isNew; // 0x38
	
			// Constructors
			public AuthV2SessionTokenResp(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool LoadFromJSON(string json); // 0x000000018C22BA20-0x000000018C22BC14
		}
	
		public class GetProductLsitResp : IFromJSON // TypeDefIndex: 88703
		{
			// Fields
			public int flag; // 0x10
			public Dictionary<string, object> desc; // 0x18
	
			// Constructors
			public GetProductLsitResp(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool LoadFromDictionary(Dictionary<string, object> dict); // 0x0000000186145230-0x00000001861455D0
			public bool LoadFromJSON(string json); // 0x000000018C22C3C8-0x000000018C22C4A8
		}
	
		protected class AuthV2GrantResp : IFromJSON // TypeDefIndex: 88704
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
			public AuthV2GrantResp(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool LoadFromJSON(string json); // 0x000000018C22B754-0x000000018C22BA20
		}
	
		protected class ServerListResp : IFromJSON // TypeDefIndex: 88706
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public List<ServerData> data; // 0x20
	
			// Nested types
			public struct ServerData // TypeDefIndex: 88705
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
			public ServerListResp(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool LoadFromJSON(string json); // 0x000000018C234AD0-0x000000018C234FC8
			public List<U8ServerInfo> ToServerInfo(); // 0x000000018C234FC8-0x000000018C235240
		}
	
		protected class ConfirmServerResp : IFromJSON // TypeDefIndex: 88707
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
	
			// Constructors
			public ConfirmServerResp(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool LoadFromJSON(string json); // 0x000000018C22BF08-0x000000018C22BFE4
		}
	
		protected class ConfirmOrderU1Resp : IFromJSON // TypeDefIndex: 88708
		{
			// Fields
			public int status; // 0x10
	
			// Constructors
			public ConfirmOrderU1Resp(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool LoadFromJSON(string json); // 0x000000018C22BE6C-0x000000018C22BF08
		}
	
		protected class CreateOrderU1Resp : IFromJSON // TypeDefIndex: 88710
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public Data data; // 0x28
	
			// Nested types
			public struct Data // TypeDefIndex: 88709
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
			public CreateOrderU1Resp(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool LoadFromJSON(string json); // 0x000000018C22BFE4-0x000000018C22C270
			public U8OrderInfo ToOrderInfo(); // 0x000000018C22C270-0x000000018C22C388
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88711
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<string> __9__46_0; // 0x08
			public static Action<string> __9__46_1; // 0x10
			public static Action __9__47_0; // 0x18
			public static Action __9__47_1; // 0x20
	
			// Constructors
			static __c(); // 0x00000001871E4BE0-0x00000001871E4C40
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoginWithPlugin_b__46_0(string extension); // 0x0000000187187450-0x00000001871874D0
			internal void _LoginWithPlugin_b__46_1(string message); // 0x000000018C2370B4-0x000000018C237120
			internal void _LogoutWithPlugin_b__47_0(); // 0x000000018C237120-0x000000018C2371A0
			internal void _LogoutWithPlugin_b__47_1(); // 0x000000018C2371A0-0x000000018C237220
		}
	
		[CompilerGenerated]
		private sealed class __NextFrameCoroutine_d__64 : IEnumerator<object> // TypeDefIndex: 88712
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action action; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __NextFrameCoroutine_d__64(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000187066840-0x00000001870668A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C238830-0x000000018C23887C
		}
	
		[CompilerGenerated]
		private sealed class _SDKInterfaceAuthV2SessionToken_d__117 : IEnumerator<object> // TypeDefIndex: 88713
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _SDKInterfaceAuthV2SessionToken_d__117(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C2358F4-0x000000018C235DAC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C235DAC-0x000000018C235DF8
		}
	
		[CompilerGenerated]
		private sealed class _SDKInterfaceAuthV2OAuth2Code_d__118 : IEnumerator<object> // TypeDefIndex: 88714
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string sessionToken; // 0x28
			public SDKPromiseWithResult<U8GrantResult> promise; // 0x30
			public Action onSessionInvalid; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _SDKInterfaceAuthV2OAuth2Code_d__118(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C23583C-0x000000018C2358A8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C2358A8-0x000000018C2358F4
		}
	
		[CompilerGenerated]
		private sealed class __AuthV2GrantImpl_d__124 : IEnumerator<object> // TypeDefIndex: 88715
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __AuthV2GrantImpl_d__124(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C2376E4-0x000000018C237E74
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C237E74-0x000000018C237EC0
		}
	
		[CompilerGenerated]
		private sealed class __ConfirmOrderU1Coroutine_d__127 : IEnumerator<object> // TypeDefIndex: 88716
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string orderId; // 0x28
			public string extension; // 0x30
			public SDKPromise<U8ConfirmOrderResult> promise; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ConfirmOrderU1Coroutine_d__127(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C237EC0-0x000000018C2380D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C2380D0-0x000000018C23811C
		}
	
		[CompilerGenerated]
		private sealed class __PollOrderStatusCoroutine_d__128 : IEnumerator<object> // TypeDefIndex: 88717
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __PollOrderStatusCoroutine_d__128(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C23887C-0x000000018C238D54
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C238D54-0x000000018C238DA0
		}
	
		[CompilerGenerated]
		private sealed class __GetServerListCoroutine_d__129 : IEnumerator<object> // TypeDefIndex: 88718
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string paramStr; // 0x28
			public SDKPromise<List<U8ServerInfo>> promise; // 0x30
			private POSTProcedure<ServerListResp> _postImpl_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GetServerListCoroutine_d__129(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C23852C-0x000000018C2387E4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C2387E4-0x000000018C238830
		}
	
		[CompilerGenerated]
		private sealed class __ConfirmServerListCoroutine_d__131 : IEnumerator<object> // TypeDefIndex: 88719
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ConfirmServerListCoroutine_d__131(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C23811C-0x000000018C2384E0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C2384E0-0x000000018C23852C
		}
	
		[CompilerGenerated]
		private sealed class __SendCreateOrderU1Coroutine_d__132 : IEnumerator<object> // TypeDefIndex: 88720
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string paramStr; // 0x28
			public SDKPromise<U8OrderInfo> promise; // 0x30
			private POSTProcedure<CreateOrderU1Resp> _postImpl_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __SendCreateOrderU1Coroutine_d__132(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C238E64-0x000000018C23910C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C23910C-0x000000018C239158
		}
	
		[CompilerGenerated]
		private sealed class __SendCreateOrderFailCoroutine_d__133 : IEnumerator<object> // TypeDefIndex: 88721
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKPromise<U8OrderInfo> promise; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __SendCreateOrderFailCoroutine_d__133(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C238DA0-0x000000018C238E18
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C238E18-0x000000018C238E64
		}
	
		// Constructors
		protected SDKExternalTools(); // 0x0000000186805BA0-0x0000000186805BB0
		static SDKExternalTools(); // 0x0000000186FC0D90-0x0000000186FC0ED0
	
		// Methods
		public static bool SDKInterfaceInitExternalTools<ConcreteType>()
			where ConcreteType : SDKExternalTools;
		public static SDKExternalTools GetInstance(); // 0x00000001859C1B80-0x00000001859C1C00
		public static bool HasInstance(); // 0x00000001859C2770-0x00000001859C27D0
		public string PublicServiceSignKey(); // 0x000000018C22E764-0x000000018C22E7B0
		public SDKPromise<List<U8ProductInfo>> SDKInterfaceProductListV2(); // 0x00000001859BD110-0x00000001859BD1B0
		public void NotifyProductListUpdated(List<U8ProductInfo> productList); // 0x0000000186ECFAF0-0x0000000186ECFBA0
		public string SDKInterfaceSDKToken(); // 0x000000018C22F14C-0x000000018C22F1D4
		public static string MakeHttpPostParam(Dictionary<string, object> param); // 0x0000000187838CDC-0x0000000187838CE4
		public bool TrySetDataWithPlugin(int type, string paramJson); // 0x00000001859C14D0-0x00000001859C1580
		public bool TryGetDataWithPlugin(int type, string paramJson, out string data); // 0x0000000187099D60-0x0000000187099E40
		public bool TrySubmitGameDataWithPlugin(U8ExtraGameData data); // 0x00000001859BF920-0x00000001859BF9D0
		public void LoginWithPlugin(Action nativeLogin, Action<string> nativeLoginCustom, Action<U8MockLogin> markMockLogin); // 0x00000001859BDDF0-0x00000001859BE0C0
		public void LogoutWithPlugin(Action nativeLogout); // 0x000000018C22E504-0x000000018C22E764
		public void SDKInterfacePayWithPlugin(U8PayParams payParams, Func<U8PayParams, SDKPromise<U8PayResult>> nativePay, Action<U8PayResult> onSuc, Action<object> onFail); // 0x000000018C22F018-0x000000018C22F14C
		public string SDKInterfaceGetPayAddition(); // 0x000000018C22EF64-0x000000018C22F018
		public static void StaticLog(string content); // 0x000000018C22F304-0x000000018C22F39C
		public static void StaticLogWarning(string content); // 0x000000018C22F26C-0x000000018C22F304
		public static void StaticLogError(string content); // 0x000000018C22F1D4-0x000000018C22F26C
		public static void RegisterPlugin(IExternalPlugin plugin); // 0x0000000186E61A20-0x0000000186E61B40
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default);
		protected string U8Url(string routeUrl); // 0x00000001850CE2C0-0x00000001850CE370
		protected string U8urlWithoutU8(string routeUrl); // 0x000000018C22F39C-0x000000018C22F490
		protected static ErrMsgMeta HandleResponseFromU8<TResp>(BusType busType, POSTResult postRet, out ref TResp resp)
			where TResp : IFromJSON, new();
		protected static Dictionary<string, object> FromMiniJSON(string json); // 0x0000000185BEBCD0-0x0000000185BEBD30
		protected static void InternalInvokeCoroutine(IEnumerator coroutine); // 0x000000018C22E4A8-0x000000018C22E504
		protected static void InternalInvokeNextFrame(Action action); // 0x00000001850CEC80-0x00000001850CED20
		[IteratorStateMachine(typeof(__NextFrameCoroutine_d__64))]
		private static IEnumerator _NextFrameCoroutine(Action action); // 0x00000001850CED20-0x00000001850CED80
		public void InitIfNot(); // 0x00000001870F18A0-0x00000001870F1950
		protected virtual void Init(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void SwitchAccount(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnSDKError(SDKError error); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnInvalidProduct(int storeId); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnSDKExtraInfo(string jsonData); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual SDKMeta LoadSDKMetaFromPlugin(Func<SDKMeta> nativeLoadMeta); // 0x00000001859BD280-0x00000001859BD340
		protected abstract SDKCaptchaHandler CreateCaptchaHandler();
		protected virtual string GetSignKey(); // 0x0000000185829EC0-0x0000000185829ED0
		public abstract Dictionary<string, string> GetDeviceIDs();
		protected abstract SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr);
		protected abstract int GetPlatformKey();
		protected abstract void POSTImplementation(POSTRequest request, Action<POSTResult> callback);
		protected abstract string U8RootUrl();
		protected abstract string GetErrorMessage(ErrMsgMeta meta);
		protected abstract void Log(string content);
		protected abstract void LogWarning(string content);
		protected abstract void LogError(string content);
		private bool _ValidatePlugin(); // 0x00000001859BD480-0x00000001859BD4F0
		private static void _AddAppIdOrAppCode(Dictionary<string, object> paramDict, SDKMeta meta); // 0x00000001859BED10-0x00000001859BEDA0
		private static string _MakeGetProductListV2Param(SDKMeta meta); // 0x00000001859BD340-0x00000001859BD480
		[IteratorStateMachine(typeof(_SDKInterfaceAuthV2SessionToken_d__117))]
		public IEnumerator SDKInterfaceAuthV2SessionToken(SDKMeta meta, string channelToken, SDKPromiseWithResult<U8LoginV2Result> promise); // 0x000000018C22EAD0-0x000000018C22EB7C
		[IteratorStateMachine(typeof(_SDKInterfaceAuthV2OAuth2Code_d__118))]
		public IEnumerator SDKInterfaceAuthV2OAuth2Code(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid); // 0x000000018C22EA24-0x000000018C22EAD0
		public SDKPromise<U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(string orderId, string extension); // 0x000000018C22EB7C-0x000000018C22EC34
		public SDKPromise<List<U8ServerInfo>> SDKInterFaceGetServerList(string sessionToken); // 0x000000018C22E908-0x000000018C22EA24
		public SDKPromise<U8ConfirmServerResult> SDKInterFaceConfirmServer(string sessionToken, string serverId); // 0x000000018C22E7B0-0x000000018C22E908
		public SDKPromise<U8OrderInfo> SDKInterfaceCreateOrderU1(string sessionToken, string productId, string signParams); // 0x000000018C22EC34-0x000000018C22EF64
		private static string _MakeGrantParam(string sessionToken, int type, string captcha); // 0x000000018C22F8D8-0x000000018C22FA8C
		[IteratorStateMachine(typeof(__AuthV2GrantImpl_d__124))]
		private IEnumerator _AuthV2GrantImpl(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid); // 0x000000018C22F490-0x000000018C22F53C
		private static string _MakeCheckOrderV1Param(string orderId, string extension); // 0x000000018C22F724-0x000000018C22F81C
		private static string _MakeConfirmOrderV1Param(string orderId); // 0x000000018C22F81C-0x000000018C22F8D8
		[IteratorStateMachine(typeof(__ConfirmOrderU1Coroutine_d__127))]
		private IEnumerator _ConfirmOrderU1Coroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise); // 0x000000018C22F53C-0x000000018C22F5E8
		[IteratorStateMachine(typeof(__PollOrderStatusCoroutine_d__128))]
		private IEnumerator _PollOrderStatusCoroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise); // 0x000000018C22FA8C-0x000000018C22FB1C
		[IteratorStateMachine(typeof(__GetServerListCoroutine_d__129))]
		private IEnumerator _GetServerListCoroutine(string paramStr, SDKPromise<List<U8ServerInfo>> promise); // 0x000000018C22F694-0x000000018C22F724
		[IteratorStateMachine(typeof(__ConfirmServerListCoroutine_d__131))]
		private IEnumerator _ConfirmServerListCoroutine(string paramStr, string serverId, SDKPromise<U8ConfirmServerResult> promise); // 0x000000018C22F5E8-0x000000018C22F694
		[IteratorStateMachine(typeof(__SendCreateOrderU1Coroutine_d__132))]
		private IEnumerator _SendCreateOrderU1Coroutine(string paramStr, SDKPromise<U8OrderInfo> promise); // 0x000000018C22FB78-0x000000018C22FC08
		[IteratorStateMachine(typeof(__SendCreateOrderFailCoroutine_d__133))]
		private IEnumerator _SendCreateOrderFailCoroutine(SDKPromise<U8OrderInfo> promise); // 0x000000018C22FB1C-0x000000018C22FB78
	}

	public struct SDKExtraData // TypeDefIndex: 88723
	{
		// Fields
		public static readonly SDKExtraData EMPTY; // 0x00
		public int code; // 0x00
		public Dictionary<string, object> msg; // 0x08
	
		// Constructors
		static SDKExtraData(); // 0x00000001871E8550-0x00000001871E85A0
	
		// Methods
		public static SDKExtraData FromJson(string jsonStr); // 0x00000001859BF1F0-0x00000001859BF370
	}

	public abstract class SDKExternalToolsShortcut : SDKExternalTools // TypeDefIndex: 88728
	{
		// Nested types
		protected struct U8ProductListDataV2 : SDKExternalTools.IFromJSON // TypeDefIndex: 88724
		{
			// Fields
			public List<U8ProductInfo> productList; // 0x00
	
			// Methods
			public bool LoadFromJSON(string json); // 0x0000000185BEC1F0-0x0000000185BEC4B0
			private static bool _BuildProductInfo(U8ProductInfo outInfo, Dictionary<string, object> dict); // 0x0000000185BEC000-0x0000000185BEC1F0
		}
	
		public enum RequestConnPolicy // TypeDefIndex: 88725
		{
			DEFAULT = 0,
			CLOSE_EACH_CON = 1
		}
	
		public struct RequestHeaderInjectOptions // TypeDefIndex: 88726
		{
			// Fields
			public RequestConnPolicy policy; // 0x00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 88727
		{
			// Fields
			public SDKPromise<List<U8ProductInfo>> promise; // 0x10
			public SDKExternalToolsShortcut __4__this; // 0x18
			public SDKExternalTools.POSTRequest request; // 0x20
			public Action<SDKExternalTools.POSTResult> callback; // 0x40
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SendGetProductListRequestV2_b__0(SDKExternalTools.POSTResult postRet); // 0x0000000186DBC800-0x0000000186DBC8F0
			internal void _SendGetProductListRequestV2_b__1(); // 0x00000001856B7B20-0x00000001856B7B60
		}
	
		// Constructors
		protected SDKExternalToolsShortcut(); // 0x000000018721F320-0x000000018721F360
	
		// Methods
		protected sealed override SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr); // 0x00000001850CE090-0x00000001850CE280
		public override Dictionary<string, string> GetDeviceIDs(); // 0x000000018C22E27C-0x000000018C22E388
		public static string GetU8DeviceID(); // 0x000000018C22E388-0x000000018C22E4A8
		public static void InjectRequestHeaders(ref Dictionary<string, string> headers, RequestHeaderInjectOptions policy); // 0x00000001856B7B60-0x00000001856B7C40
		private string _GetProductListV1Url(); // 0x00000001850CE280-0x00000001850CE2C0
	}

	public abstract class U8SDKInterface // TypeDefIndex: 88744
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
		private U8UserInfo? m_cachedUserInfo; // 0xA0
		private List<U8ProductInfo> m_productList; // 0xB0
		private bool? m_isNativePlugin; // 0xB8
		private V2LoginStatus m_loginStatusV2; // 0xC0
		private static int U8_SDK_SET_DATA_SET_SESSION_TOKEN; // 0x08
		private static int U8_SDK_SET_DATA_GET_PRODUCT_LIST; // 0x0C
		[CompilerGenerated]
		private static ReceiverProductListResult onReceiverProductlist; // 0x10
		private GameServerTimeCache m_gameServerTimeCache; // 0xC8
	
		// Properties
		public static U8SDKInterface Instance { get; } // 0x0000000185BC5B00-0x0000000185BC5CD0 
		public bool isNativePlugin { get; } // 0x00000001859C27D0-0x00000001859C2860 
		public string uid { get; } // 0x0000000187232F80-0x0000000187232F90 
		public string cachedUid { get; set; } // 0x0000000185753250-0x0000000185753290 0x000000018611EBF0-0x000000018611EC50
		public string oauth2token { get; } // 0x00000001829CD170-0x00000001829CD180 
		public string oauth2code { get; } // 0x0000000187232FC0-0x0000000187232FD0 
		public static bool isInterfaceDisabled { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public string sessionToken { get; } // 0x0000000187236200-0x0000000187236210 
		public GameServerTimeCache serverCacheTime { get; set; } // 0x0000000187250AC0-0x0000000187250AE0 0x0000000187250AE0-0x0000000187250B00
	
		// Events
		private static event ReceiverProductListResult onReceiverProductlist {
			add; // 0x0000000186DF8F20-0x0000000186DF9010
			remove; // 0x0000000186DF9010-0x0000000186DF9100
		}
	
		// Nested types
		public struct AuthStatus // TypeDefIndex: 88729
		{
			// Fields
			public static readonly AuthStatus EMPTY; // 0x00
			public string uid; // 0x00
			public string oauth2code; // 0x08
			public string oauth2token; // 0x10
			public string sessionToken; // 0x18
		}
	
		private struct V2LoginStatus // TypeDefIndex: 88730
		{
			// Fields
			public string sessionToken; // 0x00
		}
	
		public delegate void ReceiverProductListResult(Dictionary<string, object> msg); // TypeDefIndex: 88731; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public struct GameServerTimeCache // TypeDefIndex: 88732
		{
			// Fields
			public long cacheTime; // 0x00
			public long maintainEndTs; // 0x08
			public long maintainStartTs; // 0x10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0<ToolType> // TypeDefIndex: 88733
			where ToolType : SDKExternalTools
		{
			// Fields
			public SDKPromise<string> delegatePromise;
			public U8SDKInterface __4__this;
			public string env;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _V2PublicInit_b__0(string obj);
			internal void _V2PublicInit_b__3();
			internal void _V2PublicInit_b__1(object info);
			internal void _V2PublicInit_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0 // TypeDefIndex: 88734
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public string uid; // 0x18
			public bool isNew; // 0x20
	
			// Constructors
			public __c__DisplayClass56_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __onLoginSuc_b__0(); // 0x000000018491D520-0x000000018491D890
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 88735
		{
			// Fields
			public SDKExternalTools externalTools; // 0x10
			public U8SDKInterface __4__this; // 0x18
			public SDKPromise<U8ProductsResult> delegatePromise; // 0x20
			public Action<List<U8ProductInfo>> __9__1; // 0x28
			public Action<object> __9__2; // 0x30
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PublicGetProductListV2_b__0(); // 0x000000018491D890-0x000000018491F9A0
			internal void _PublicGetProductListV2_b__1(List<U8ProductInfo> productList); // 0x000000018491F9A0-0x0000000184921C00
			internal void _PublicGetProductListV2_b__2(object rejectObj); // 0x0000000184921C00-0x0000000184921C30
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_1 // TypeDefIndex: 88736
		{
			// Fields
			public List<U8ProductInfo> productList; // 0x10
			public ReceiverProductListResult receiver; // 0x18
			public __c__DisplayClass58_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass58_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PublicGetProductListV2_b__3(Dictionary<string, object> msg); // 0x0000000184921C30-0x00000001849249E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0 // TypeDefIndex: 88737
		{
			// Fields
			public U8PayParams payParams; // 0x10
			public U8SDKInterface __4__this; // 0x18
			public SDKPromise<U8PayResult> wrappedPromise; // 0x20
			public U8ProductInfo productInfo; // 0x28
			public Action<U8PayResult> __9__1; // 0x30
			public Action<object> __9__2; // 0x38
	
			// Constructors
			public __c__DisplayClass73_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PublicPay_b__0(); // 0x00000001849249E0-0x0000000184925E60
			internal void _PublicPay_b__1(U8PayResult payResult); // 0x0000000184925E60-0x00000001849261C0
			internal void _PublicPay_b__2(object payFailMsg); // 0x0000000184921C00-0x0000000184921C30
			internal void _PublicPay_b__3(U8PayResult payResult); // 0x00000001849261C0-0x0000000184926520
			internal void _PublicPay_b__4(object payFailMsg); // 0x0000000184921C00-0x0000000184921C30
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 88738
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public long revenue; // 0x18
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnNativePayFulfilled_b__0(); // 0x0000000184926520-0x0000000184926840
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0 // TypeDefIndex: 88739
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public U8PayParams payParams; // 0x18
	
			// Constructors
			public __c__DisplayClass82_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __NativePay_b__0(); // 0x0000000184926840-0x0000000184926890
		}
	
		[CompilerGenerated]
		private sealed class __NextFrameCoroutine_d__112 : IEnumerator<object> // TypeDefIndex: 88740
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action call; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __NextFrameCoroutine_d__112(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018492B7C0-0x000000018492B860
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018492B860-0x000000018492B8B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass138_0 // TypeDefIndex: 88741
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public SDKPromise<U8AuthV2Result> promise; // 0x18
	
			// Constructors
			public __c__DisplayClass138_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DoMockAuthV2_b__0(); // 0x000000018491C640-0x000000018491D520
		}
	
		[CompilerGenerated]
		private sealed class __LoginV2Coroutine_d__139 : IEnumerator<object> // TypeDefIndex: 88742
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8SDKInterface __4__this; // 0x20
			public SDKPromise<string> promise; // 0x28
			private SDKPromiseEnumerator<string> _loginEnumerator_5__2; // 0x30
			private SDKPromiseWithResult<U8LoginV2Result> _sessionTokenPromise_5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __LoginV2Coroutine_d__139(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001849286D0-0x000000018492B770
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018492B770-0x000000018492B7C0
		}
	
		[CompilerGenerated]
		private sealed class __AuthV2Coroutine_d__141 : IEnumerator<object> // TypeDefIndex: 88743
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8SDKInterface __4__this; // 0x20
			public SDKPromise<U8AuthV2Result> promise; // 0x28
			private SDKPromiseWithResult<U8GrantResult> _oauth2codePromise_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __AuthV2Coroutine_d__141(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184926890-0x0000000184928680
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184928680-0x00000001849286D0
		}
	
		// Constructors
		protected U8SDKInterface(); // 0x0000000186ABBD00-0x0000000186ABBE50
		static U8SDKInterface(); // 0x00000001871FB8F0-0x00000001871FB940
	
		// Methods
		public void CallbackInitSuc(string extConfigs); // 0x0000000186E54320-0x0000000186E54340
		public void CallbackInitFail(string info); // 0x000000018C23A0B4-0x000000018C23A0D4
		public void CallbackLoginSuc(string extension); // 0x0000000186E543A0-0x0000000186E543C0
		public void CallbackLoginFail(string info); // 0x000000018C23A0D4-0x000000018C23A0F4
		public void CallbackLogout(); // 0x000000018C23A0F4-0x000000018C23A118
		public void CallbackSwitchAccount(); // 0x000000018C23A240-0x000000018C23A28C
		public void CallbackPaySuc(string jsonData); // 0x000000018C23A1AC-0x000000018C23A240
		public void CallbackPayFail(string failMsg); // 0x000000018C23A118-0x000000018C23A1AC
		public string PublicLoadExtraConfig(); // 0x000000018783B1B4-0x000000018783B1C4
		public void PublicSetGameVersion(string version); // 0x0000000187835AE0-0x0000000187835AF4
		public ReceiverProductListResult getOnReceiverProductlist(); // 0x000000018C23B074-0x000000018C23B0C4
		public SDKPromise<string> V2PublicInit<ToolType>(string env)
			where ToolType : SDKExternalTools;
		private void _MarkMockLogin(U8MockLogin mockLogin); // 0x00000001872313C0-0x00000001872313E0
		private void _onLoginSuc(string uid, bool isNew); // 0x0000000187080370-0x0000000187080D10
		public SDKPromise<U8ProductsResult> PublicGetProductListV2(); // 0x00000001850CEA00-0x00000001850CEB30
		public void ClearAuthStatus(); // 0x000000018C23A28C-0x000000018C23A2F0
		public void ClearLoginStatus(); // 0x000000018C23A2F0-0x000000018C23A368
		private void _ConfirmAuthResult(AuthStatus result); // 0x000000018611EA60-0x000000018611EAA0
		public U8UserInfo? PublicGetUserInfo(); // 0x000000018492B8B0-0x000000018492B8F0
		private void _CacheUserInfo(); // 0x000000018492CC00-0x000000018492CC70
		private U8UserInfo? _ReadUserInfoFromNative(); // 0x000000018492CC70-0x000000018492DDA0
		public SDKPromise<object> PublicLogout(); // 0x000000018C23A72C-0x000000018C23A7CC
		public SDKPromise<List<U8ServerInfo>> PublicGetServerList(); // 0x000000018C23A724-0x000000018C23A72C
		public SDKPromise<U8ConfirmServerResult> PubliceConfirmServer(string serverId); // 0x000000018C23AA18-0x000000018C23AA20
		public SDKPromise<U8PayResult> PublicPay(int storeId, U8OrderInfo orderInfo); // 0x000000018C23A7CC-0x000000018C23AA18
		private void _OnNativePayFulfilled(long revenue); // 0x000000018C23AEC8-0x000000018C23AF84
		private bool _TryGetProduct(int storeId, out U8ProductInfo productInfo); // 0x000000018C23AFA4-0x000000018C23B074
		private U8PayParams _GeneratePayParams(U8ProductInfo productInfo, U8OrderInfo orderInfo); // 0x000000018C23AC48-0x000000018C23ADE4
		private SDKPromise<U8PayResult> _NativePay(U8PayParams payParams); // 0x000000018C23ADE4-0x000000018C23AEC8
		private static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default);
		public SDKMeta PublicLoadSDKMeta(); // 0x00000001859BD1B0-0x00000001859BD280
		protected abstract string LoadExtraConfig();
		protected abstract void V2Init(string env);
		protected abstract void Login();
		protected abstract void LoginCustom(string customData);
		protected abstract bool Logout();
		public abstract bool ShowAccountCenter();
		public void SubmitGameData(U8ExtraGameData data); // 0x00000001859C0D10-0x00000001859C0DE0
		public abstract void SubmitGameDataNative(U8ExtraGameData data);
		protected abstract void Pay(U8PayParams data);
		public void SetData(int type, string paramJson); // 0x00000001859C26A0-0x00000001859C2770
		public abstract void SetDataNative(int type, string paramJson);
		public string GetData(int type, string paramJson); // 0x00000001859C0C30-0x00000001859C0D10
		public abstract string GetDataNative(int type, string paramJson);
		protected abstract SDKMeta LoadSDKMeta();
		protected abstract bool IsNativePlugin();
		public abstract void SetGameVersion(string version);
		[IteratorStateMachine(typeof(__NextFrameCoroutine_d__112))]
		private IEnumerator _NextFrameCoroutine(Action call); // 0x00000001850CF1E0-0x00000001850CF240
		protected void InvokeNextFrame(Action action); // 0x00000001850CF150-0x00000001850CF1E0
		protected void InvokeCoroutine(IEnumerator coroutine); // 0x00000001859BC390-0x00000001859BC3F0
		protected string EncodeGameData(U8ExtraGameData data); // 0x00000001859C08C0-0x00000001859C0BD0
		protected string EncodePayParams(U8PayParams data); // 0x000000018C23A368-0x000000018C23A724
		public SDKPromise<string> V2PublicLogin(); // 0x00000001859BC290-0x00000001859BC310
		public SDKPromise<U8AuthV2Result> V2PublicAuth(); // 0x00000001850CEB30-0x00000001850CEB90
		public SDKPromise<U8OrderInfo> U1PublicCreateOrder(string productId, string signParams); // 0x000000018C23AAF4-0x000000018C23AB74
		public SDKPromise<List<U8ServerInfo>> U1PublicGetServerList(); // 0x000000018C23AB74-0x000000018C23ABD0
		public SDKPromise<U8ConfirmServerResult> U1PublicConfirmServer(string serverId); // 0x000000018C23AA88-0x000000018C23AAF4
		public SDKPromise<U8ConfirmOrderResult> U1PublicConfirmOrder(string orderId, string extension); // 0x000000018C23AA20-0x000000018C23AA88
		private SDKPromise<U8AuthV2Result> _DoMockAuthV2(); // 0x00000001850CEB90-0x00000001850CEC80
		[IteratorStateMachine(typeof(__LoginV2Coroutine_d__139))]
		private IEnumerator _LoginV2Coroutine(SDKPromise<string> promise); // 0x00000001859BC310-0x00000001859BC390
		private void _OnSessionTokenInvalid(); // 0x000000018C23AF84-0x000000018C23AFA4
		[IteratorStateMachine(typeof(__AuthV2Coroutine_d__141))]
		private IEnumerator _AuthV2Coroutine(SDKPromise<U8AuthV2Result> promise); // 0x000000018C23ABD0-0x000000018C23AC48
		[CompilerGenerated]
		private void _PublicLogout_b__69_0(); // 0x000000018492B8F0-0x000000018492C8E0
		[CompilerGenerated]
		private void _PublicLogout_b__69_1(); // 0x000000018492C8E0-0x000000018492C8F0
		[CompilerGenerated]
		private void _PublicLogout_b__69_2(); // 0x000000018492C8F0-0x000000018492CC00
	}

	public struct SDKError // TypeDefIndex: 88745
	{
		// Fields
		[CompilerGenerated]
		private string _code_k__BackingField; // 0x00
		[CompilerGenerated]
		private string _msg_k__BackingField; // 0x08
	
		// Properties
		private string code { [CompilerGenerated] set; } // 0x00000001878380EC-0x00000001878380F4
		private string msg { [CompilerGenerated] set; } // 0x0000000188AC06FC-0x0000000188AC070C
	
		// Constructors
		public SDKError(string content); // 0x000000018C22E054-0x000000018C22E27C
	}

	public struct U8MockLogin // TypeDefIndex: 88746
	{
		// Fields
		public static readonly U8MockLogin EMPTY; // 0x00
		public string uid; // 0x00
		public string token; // 0x08
	
		// Methods
		public bool IsEmpty(); // 0x0000000187834AF8-0x0000000187834B10
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ProductInfo // TypeDefIndex: 88747
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
		public U8ProductInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ProductsResult // TypeDefIndex: 88748
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("u8Products")]
		public List<U8ProductInfo> u8Products; // 0x18
	
		// Constructors
		public U8ProductsResult(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ServerInfo // TypeDefIndex: 88749
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
		public U8ServerInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ServerErrorInfo // TypeDefIndex: 88750
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("errorCode")]
		public int errorCode; // 0x14
	
		// Constructors
		public U8ServerErrorInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class U8OrderInfo // TypeDefIndex: 88751
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
		public U8OrderInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class U8PayParams // TypeDefIndex: 88752
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
		public U8PayParams(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ExtraGameData // TypeDefIndex: 88753
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
		public U8ExtraGameData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct U8LoginResult // TypeDefIndex: 88754
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
		public override string ToString(); // 0x000000018C239288-0x000000018C23945C
	}

	public struct U8UserInfo // TypeDefIndex: 88755
	{
		// Fields
		public string account; // 0x00
	}

	public struct U8ProductError // TypeDefIndex: 88756
	{
		// Fields
		public int status; // 0x00
		public int errorCode; // 0x04
	}

	public enum PayResultStatus // TypeDefIndex: 88757
	{
		SUCCEED = 0,
		PENDING = 1
	}

	public enum PayFailStatus // TypeDefIndex: 88758
	{
		UNKNOWN = 0,
		CANCELED = 1,
		ERROR = 2,
		HALT = 3
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ConfirmServerResult // TypeDefIndex: 88759
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("message")]
		public string message; // 0x18
	
		// Constructors
		public U8ConfirmServerResult(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum U8ConfirmOrderStatus // TypeDefIndex: 88760
	{
		NONE = 0,
		INTERNAL_ERROR = 1,
		TIMEOUT = 2,
		INVALID_ORDER = 3,
		SUCCEED = 4
	}

	[UnityEngine.Scripting.Preserve]
	public class U8ConfirmOrderResult // TypeDefIndex: 88761
	{
		// Fields
		[JsonProperty("status")]
		public U8ConfirmOrderStatus status; // 0x10
		[JsonProperty("message")]
		public string message; // 0x18
	
		// Constructors
		public U8ConfirmOrderResult(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct U8PayFailMsg // TypeDefIndex: 88762
	{
		// Fields
		public static U8PayFailMsg EMPTY; // 0x00
		public PayFailStatus status; // 0x00
		public string message; // 0x08
		public string extension; // 0x10
	
		// Constructors
		static U8PayFailMsg(); // 0x000000018C2398C0-0x000000018C239924
	
		// Methods
		public static U8PayFailMsg FromJson(string jsonStr); // 0x000000018C2394D0-0x000000018C2398C0
	}

	public struct U8PayResult // TypeDefIndex: 88763
	{
		// Fields
		public static readonly U8PayResult EMPTY; // 0x00
		public PayResultStatus status; // 0x00
		public string outTradeNo; // 0x08
		public string extension; // 0x10
	
		// Constructors
		static U8PayResult(); // 0x000000018C239D94-0x000000018C239E08
	
		// Methods
		public static U8PayResult FromJson(string jsonData); // 0x000000018C239924-0x000000018C239CA8
		public override string ToString(); // 0x000000018C239CA8-0x000000018C239D94
	}

	public class SDKInterfaceCloud : U8SDKInterface // TypeDefIndex: 88778
	{
		// Fields
		private int actionIndex; // 0xE0
		private static Dictionary<int, Action<string>> dictAction; // 0x00
		private string languageParam; // 0xE8
	
		// Nested types
		public delegate void DataCallback(int index, string paramValue); // TypeDefIndex: 88764; 0x00000001859B7730-0x00000001859B7740
	
		public delegate void U8SDKSendMessageCallback(string methodName, string paramValue); // TypeDefIndex: 88765; 0x00000001859B7730-0x00000001859B7740
	
		[UnityEngine.Scripting.Preserve]
		public class LoginResult // TypeDefIndex: 88766
		{
			// Fields
			[JsonProperty("code")]
			public LoginResultCode code; // 0x10
			[JsonProperty("msg")]
			public JToken msg; // 0x18
	
			// Constructors
			public LoginResult(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public enum LoginResultCode // TypeDefIndex: 88767
		{
			Success = 0,
			Canceled = 1,
			Failed = 2
		}
	
		[UnityEngine.Scripting.Preserve]
		public class PaymentResult // TypeDefIndex: 88768
		{
			// Fields
			[JsonProperty("code")]
			public PaymentResultCode code; // 0x10
			[JsonProperty("msg")]
			public JToken msg; // 0x18
	
			// Constructors
			public PaymentResult(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public enum PaymentResultCode // TypeDefIndex: 88769
		{
			Success = 0,
			Failed = 1
		}
	
		private enum SetDataCode // TypeDefIndex: 88770
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
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 88771
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoadExtraConfig_b__0(string data); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 88772
		{
			// Fields
			public string defaultValue; // 0x10
			public int type; // 0x18
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetDataNative_b__0(string data); // 0x000000018C237510-0x000000018C237570
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 88773
		{
			// Fields
			public string json; // 0x10
	
			// Constructors
			public __c__DisplayClass55_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoadSDKMeta_b__0(string data); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 88775
		{
			// Fields
			public SDKInterfaceCloud __4__this; // 0x10
			public string jsonData; // 0x18
	
			// Nested types
			private struct __HandleCloudShareEvent_b__0_d : IAsyncStateMachine // TypeDefIndex: 88774
			{
				// Fields
				public int __1__state; // 0x00
				public AsyncTaskMethodBuilder __t__builder; // 0x08
				public __c__DisplayClass74_0 __4__this; // 0x20
				private TaskAwaiter __u__1; // 0x28
	
				// Methods
				private void MoveNext(); // 0x000000018C236D7C-0x000000018C237058
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C237058-0x000000018C2370B4
			}
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal async System.Threading.Tasks.Task _HandleCloudShareEvent_b__0(); // 0x000000018C237570-0x000000018C237624
		}
	
		[CompilerGenerated]
		private struct _SaveImageToTargetFolder_d__75 : IAsyncStateMachine // TypeDefIndex: 88776
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public string jsonData; // 0x20
			public SDKInterfaceCloud __4__this; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x000000018C2365B4-0x000000018C2368A4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C2368A4-0x000000018C236900
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0 // TypeDefIndex: 88777
		{
			// Fields
			public string methodName; // 0x10
			public string paramValue; // 0x18
	
			// Constructors
			public __c__DisplayClass77_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SendMessageInMain_b__0(); // 0x000000018C237624-0x000000018C237680
		}
	
		// Constructors
		public SDKInterfaceCloud(); // 0x000000018C233C48-0x000000018C233DF4
		static SDKInterfaceCloud(); // 0x000000018C233BBC-0x000000018C233C48
	
		// Methods
		~SDKInterfaceCloud(); // 0x000000018C2309CC-0x000000018C230B2C
		public int AddAction(Action<string> action); // 0x000000018C22FE48-0x000000018C22FFA0
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void DataActionCallback(int index, string paramValue); // 0x000000018C2307DC-0x000000018C2309CC
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void ASyncDataActionCallback(int index, string paramValue); // 0x000000018C22FC58-0x000000018C22FE48
		[AOT.MonoPInvokeCallback(typeof(U8SDKSendMessageCallback))]
		public static void U8SDKSendMessage(string methodName, string paramValue); // 0x000000018C233A44-0x000000018C233AAC
		public static extern void HGU8SDKInitLibrary(string windowText, long windowHandle); // 0x000000018C231024-0x000000018C231074
		public static extern int HGU8SDKSetUserDataPath(string path); // 0x000000018C231180-0x000000018C2311D4
		public static extern void HGU8SDKUnInitLibrary(); // 0x000000018C2311D4-0x000000018C2311F8
		public static extern void HGU8SDKInitDatacallback(DataCallback Callback, DataCallback asyncCallback); // 0x000000018C230FD4-0x000000018C231024
		public static extern void HGU8SDKInitSendMessage(U8SDKSendMessageCallback callback); // 0x000000018C231074-0x000000018C2310BC
		public static extern void HGU8SDKV2Init(string env); // 0x000000018C2311F8-0x000000018C231238
		public static extern void HGU8SDKGetSDKMeta(int index); // 0x000000018C230FA8-0x000000018C230FD4
		public static extern void HGU8SDKSetData(int code, string paramJson); // 0x000000018C2310E8-0x000000018C231138
		public static extern void HGU8SDKGetData(int code, string paramJson, int index); // 0x000000018C230F48-0x000000018C230FA8
		public static extern void HGU8SDKLoadExtraConfig(int index); // 0x000000018C2310BC-0x000000018C2310E8
		public static extern void HGU8SDKSetGameVersion(string version); // 0x000000018C231138-0x000000018C231180
		protected override string LoadExtraConfig(); // 0x000000018C232158-0x000000018C232254
		protected override void V2Init(string env); // 0x000000018C233AAC-0x000000018C233BBC
		protected override void Login(); // 0x000000018C2326B0-0x000000018C2327D4
		private void LoginCallback(CloudCallResult result); // 0x000000018C232384-0x000000018C2326A0
		protected override bool Logout(); // 0x000000018C2327D4-0x000000018C232824
		protected override void LoginCustom(string customData); // 0x000000018C2326A0-0x000000018C2326B0
		public override void SubmitGameDataNative(U8ExtraGameData data); // 0x000000018C233970-0x000000018C233A44
		public override void SetDataNative(int type, string paramJson); // 0x000000018C233100-0x000000018C2332CC
		public override string GetDataNative(int type, string paramJson); // 0x000000018C230B2C-0x000000018C230C50
		public override bool ShowAccountCenter(); // 0x000000018C23360C-0x000000018C23370C
		private void ShowAccountCenterCallback(CloudCallResult result); // 0x000000018C23339C-0x000000018C23360C
		protected override void Pay(U8PayParams data); // 0x000000018C232D1C-0x000000018C232E38
		private void PayCallback(CloudCallResult result); // 0x000000018C232A00-0x000000018C232D1C
		protected override SDKMeta LoadSDKMeta(); // 0x000000018C232254-0x000000018C232384
		protected override bool IsNativePlugin(); // 0x00000001851A4410-0x00000001851A4420
		public override void SetGameVersion(string version); // 0x000000018C2332CC-0x000000018C23339C
		private void HandleSplashProtocol(string paramJson); // 0x000000018C232104-0x000000018C232158
		private void HandleGameAgreement(string paramJson); // 0x000000018C231944-0x000000018C231B1C
		private void HandleSetLanguage(string paramJson); // 0x000000018C231D78-0x000000018C231EB0
		private void HandleSetU8Token(string paramJson); // 0x000000018C231EB0-0x000000018C231FC0
		private void HandleShowGameProtocol(string paramJson); // 0x000000018C231FC0-0x000000018C232104
		private void ShowGameProtocolCallback(CloudCallResult result); // 0x000000018C23370C-0x000000018C233970
		private void HandleQueryProductList(string paramJson); // 0x000000018C231B1C-0x000000018C231D78
		private void HandleCustomerServiceCenter(string paramJson); // 0x000000018C2316BC-0x000000018C231800
		private void CustomerServiceCenterCallback(CloudCallResult result); // 0x000000018C23028C-0x000000018C2304F0
		private void HandleCustomerUnreadMsgCount(string paramJson); // 0x000000018C231800-0x000000018C231944
		private void CustomerUnreadMsgCountCallback(CloudCallResult result); // 0x000000018C2304F0-0x000000018C2307DC
		private void HandleCloudShareEvent(string paramJson, string fileNamePrefix = null); // 0x000000018C231238-0x000000018C2316BC
		private async System.Threading.Tasks.Task SaveImageToTargetFolder(string jsonData); // 0x000000018C232F54-0x000000018C233028
		private void CloudShareEventCallback(CloudCallResult result); // 0x000000018C22FFA0-0x000000018C23028C
		private void SendMessageInMain(string methodName, string paramValue); // 0x000000018C233028-0x000000018C233100
		private static void OnPipelineConnected(CloudCallResult result); // 0x000000018C232824-0x000000018C232A00
		private static void RequestLaunchInfoCallback(CloudCallResult result); // 0x000000018C232E38-0x000000018C232F54
		private static void GetThinClientDeviceInfo(string jsonData); // 0x000000018C230C50-0x000000018C230F48
	}

	public class SDKInterfaceWIN : U8SDKInterface // TypeDefIndex: 88785
	{
		// Fields
		private int actionIndex; // 0xE0
		private static Dictionary<int, Action<string>> dictAction; // 0x00
	
		// Nested types
		public delegate void DataCallback(int index, string paramValue); // TypeDefIndex: 88779; 0x00000001859B7730-0x00000001859B7740
	
		public delegate void U8SDKSendMessageCallback(string methodName, string paramValue); // TypeDefIndex: 88780; 0x00000001859B7730-0x00000001859B7740
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 88781
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoadExtraConfig_b__0(string data); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88782
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<System.Threading.Tasks.Task> __9__42_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C237680-0x000000018C2376E4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SetDataNative_b__42_0(System.Threading.Tasks.Task task); // 0x000000018C237220-0x000000018C2372DC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 88783
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetDataNative_b__0(string data); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 88784
		{
			// Fields
			public string json; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoadSDKMeta_b__0(string data); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		// Constructors
		public SDKInterfaceWIN(); // 0x0000000186ABB420-0x0000000186ABB5C0
		static SDKInterfaceWIN(); // 0x0000000187176DF0-0x0000000187176E80
	
		// Methods
		~SDKInterfaceWIN(); // 0x000000018C233FE4-0x000000018C2340B0
		public int AddAction(Action<string> action); // 0x00000001859BE310-0x00000001859BE4E0
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void DataActionCallback(int index, string paramValue); // 0x00000001850CEE50-0x00000001850CF0D0
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void ASyncDataActionCallback(int index, string paramValue); // 0x000000018C233DF4-0x000000018C233FE4
		[AOT.MonoPInvokeCallback(typeof(U8SDKSendMessageCallback))]
		public static void U8SDKSendMessage(string methodName, string paramValue); // 0x00000001850CF0D0-0x00000001850CF150
		public static extern void HGU8SDKInitLibrary(string windowText, long windowHandle); // 0x0000000186ABB6F0-0x0000000186ABB750
		public static extern int HGU8SDKSetUserDataPath(string path); // 0x0000000186ABB690-0x0000000186ABB6F0
		public static extern void HGU8SDKUnInitLibrary(); // 0x000000018C234324-0x000000018C234348
		public static extern void HGU8SDKInitDatacallback(DataCallback Callback, DataCallback asyncCallback); // 0x0000000185AFC7A0-0x0000000185AFC7F0
		public static extern void HGU8SDKInitSendMessage(U8SDKSendMessageCallback callback); // 0x0000000185AFCD40-0x0000000185AFCDD0
		public static extern void HGU8SDKV2Init(string env); // 0x0000000186D12190-0x0000000186D121E0
		public static extern void HGU8SDKLogin(); // 0x000000018C234164-0x000000018C2341CC
		public static extern void HGU8SDKLoginCustom(string json); // 0x000000018C2340DC-0x000000018C234164
		public static extern int HGU8SDKLogout(); // 0x000000018C2341CC-0x000000018C234234
		public static extern int HGU8SDKShowAccountCenter(); // 0x000000018C2342BC-0x000000018C234324
		public static extern void HGU8SDKPay(string json); // 0x000000018C234234-0x000000018C2342BC
		public static extern void HGU8SDKSubmitGameData(string json); // 0x00000001859C0BD0-0x00000001859C0C30
		public static extern void HGU8SDKGetSDKMeta(int index); // 0x000000018C2340B0-0x000000018C2340DC
		public static extern void HGU8SDKSetData(int code, string paramJson); // 0x00000001859C2910-0x00000001859C2970
		public static extern void HGU8SDKGetData(int code, string paramJson, int index); // 0x00000001859BE790-0x00000001859BE800
		public static extern int HGU8SDKIsNativePlugin(); // 0x0000000185AFCDD0-0x0000000185AFCE40
		public static extern void HGU8SDKLoadExtraConfig(int index); // 0x00000001859BE800-0x00000001859BE830
		public static extern void HGU8SDKSetGameVersion(string version); // 0x00000001870C00F0-0x00000001870C0150
		protected override string LoadExtraConfig(); // 0x00000001859BE0C0-0x00000001859BE1D0
		protected override void V2Init(string env); // 0x0000000186D12020-0x0000000186D120B0
		protected override void Login(); // 0x000000018C2344C4-0x000000018C234504
		protected override bool Logout(); // 0x000000018C234504-0x000000018C23454C
		protected override void LoginCustom(string customData); // 0x000000018C234478-0x000000018C2344C4
		public override void SubmitGameDataNative(U8ExtraGameData data); // 0x00000001859C0850-0x00000001859C08C0
		public override void SetDataNative(int type, string paramJson); // 0x00000001859C2860-0x00000001859C2910
		public override string GetDataNative(int type, string paramJson); // 0x00000001859BE1D0-0x00000001859BE310
		public override bool ShowAccountCenter(); // 0x000000018C2345AC-0x000000018C2345F4
		protected override void Pay(U8PayParams data); // 0x000000018C23454C-0x000000018C2345AC
		protected override SDKMeta LoadSDKMeta(); // 0x000000018C234348-0x000000018C234478
		protected override bool IsNativePlugin(); // 0x00000001871F9D40-0x00000001871F9D90
		public override void SetGameVersion(string version); // 0x00000001870C00A0-0x00000001870C00F0
	}

	public class SDKMeta // TypeDefIndex: 88786
	{
		// Fields
		public string appID; // 0x10
		public string appKey; // 0x18
		public string channel; // 0x20
		public string worldId; // 0x28
		public string extension; // 0x30
		public string appCode; // 0x38
	
		// Constructors
		public SDKMeta(); // 0x0000000186805BA0-0x0000000186805BB0
		public SDKMeta(string jsonData); // 0x000000018C234758-0x000000018C234A88
	
		// Methods
		public override string ToString(); // 0x000000018C2345F4-0x000000018C234758
	}

	public interface ISDKPromise // TypeDefIndex: 88787
	{
		// Methods
		void Fulfill(object param);
		void Reject(object reason);
	}

	public class SDKPromise<Param> : ISDKPromise // TypeDefIndex: 88788
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

	public class SDKPromiseWithResult<Param> : SDKPromise<Param> // TypeDefIndex: 88789
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

	public class SDKPromiseEnumerator<T> // TypeDefIndex: 88792
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
		private enum State // TypeDefIndex: 88790
		{
			NONE = 0,
			FULFILL = 1,
			REJECT = 2
		}
	
		[CompilerGenerated]
		private sealed class _Yield_d__12 : IEnumerator<object> // TypeDefIndex: 88791
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

	public class SDKPromiseWrapper // TypeDefIndex: 88793
	{
		// Fields
		private ISDKPromise m_promise; // 0x10
	
		// Constructors
		public SDKPromiseWrapper(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public T EnsurePromise<T>()
			where T : ISDKPromise, new();
		public void Fulfill(object param); // 0x0000000186E543C0-0x0000000186E54450
		public void Reject(object reason); // 0x000000018C234AA0-0x000000018C234AD0
		private void _Clear(); // 0x00000001863017D0-0x00000001863017F0
	}

	public static class SDKPromiseExtensions // TypeDefIndex: 88794
	{
		// Extension methods
		public static void RejectWithString(this ISDKPromise promise, string errorInfo); // 0x000000018C234A88-0x000000018C234AA0
		public static void FulfillWithType<T>(this SDKPromise<T> promise, T param)
			where T : class;
	}

	public class U8SDKTickEvent : MonoBehaviour // TypeDefIndex: 88795
	{
		// Constructors
		public U8SDKTickEvent(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Update(); // 0x0000000186245BF0-0x0000000186245C20
		public static extern void HGU8SDKTickEvent(); // 0x0000000186245BF0-0x0000000186245C20
	}

	public class U8TickEventManager // TypeDefIndex: 88796
	{
		// Fields
		private GameObject tickGameObject; // 0x10
		private U8SDKTickEvent tickEvent; // 0x18
		private static U8TickEventManager instanceManager; // 0x00
		private static readonly object lockObject; // 0x08
	
		// Properties
		public static U8TickEventManager InstanceManager { get; } // 0x0000000186D120B0-0x0000000186D12190 
	
		// Constructors
		public U8TickEventManager(); // 0x0000000186805BA0-0x0000000186805BB0
		static U8TickEventManager(); // 0x00000001871C5650-0x00000001871C56C0
	
		// Methods
		public void InitTickEvent(); // 0x0000000186D121E0-0x0000000186D12550
		public void UnInitTickEvent(); // 0x000000018C23B0C4-0x000000018C23B298
	}

	[UnityEngine.Scripting.Preserve]
	public class U8LoginV2Result // TypeDefIndex: 88797
	{
		// Fields
		[JsonProperty("token")]
		public string token; // 0x10
		[JsonProperty("uid")]
		public string uid; // 0x18
		[JsonProperty("isNew")]
		public bool isNew; // 0x20
	
		// Constructors
		public U8LoginV2Result(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class U8AuthV2Result // TypeDefIndex: 88798
	{
		// Fields
		[JsonProperty("uid")]
		public string uid; // 0x10
		[JsonProperty("oauth2Code")]
		public string oauth2Code; // 0x18
		[JsonProperty("oauth2Token")]
		public string oauth2Token; // 0x20
	
		// Constructors
		public U8AuthV2Result(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class U8GrantResult // TypeDefIndex: 88799
	{
		// Fields
		[JsonProperty("uid")]
		public string uid; // 0x10
		[JsonProperty("code")]
		public string code; // 0x18
		[JsonProperty("token")]
		public string token; // 0x20
	
		// Constructors
		public U8GrantResult(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class U8SDKCallback : MonoBehaviour // TypeDefIndex: 88801
	{
		// Fields
		private static U8SDKCallback m_instance; // 0x00
		private static object m_lock; // 0x08
	
		// Nested types
		[CompilerGenerated]
		private sealed class __onLogoutNextFrameCoroutine_d__13 : IEnumerator<object> // TypeDefIndex: 88800
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __onLogoutNextFrameCoroutine_d__13(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C239158-0x000000018C23923C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C23923C-0x000000018C239288
		}
	
		// Constructors
		public U8SDKCallback(); // 0x00000001878364A0-0x00000001878364B8
		static U8SDKCallback(); // 0x00000001871C56C0-0x00000001871C5730
	
		// Methods
		public static U8SDKCallback InitCallback(); // 0x00000001850CF240-0x00000001850CF620
		public void OnInitSuc(string extConfigs); // 0x0000000186E542C0-0x0000000186E54320
		public void OnInitFail(string info); // 0x000000018C239E08-0x000000018C239E60
		public void OnLoginSuc(string extension); // 0x0000000186E54340-0x0000000186E543A0
		public void OnLoginFail(string info); // 0x000000018C239E60-0x000000018C239EB8
		public void OnLogout(string info); // 0x000000018C239EB8-0x000000018C239F04
		public void OnSwitchAccount(); // 0x000000018C23A024-0x000000018C23A070
		public void OnPaySuc(string jsonData); // 0x000000018C239F5C-0x000000018C239FB4
		public void OnPayFail(string failMsg); // 0x000000018C239F04-0x000000018C239F5C
		public void OnSDKError(string jsonData); // 0x000000018C239FB4-0x000000018C23A024
		public void OnExtraInfo(string jsonData); // 0x0000000185784D30-0x0000000185784F70
		[IteratorStateMachine(typeof(__onLogoutNextFrameCoroutine_d__13))]
		private IEnumerator _onLogoutNextFrameCoroutine(); // 0x000000018C23A070-0x000000018C23A0B4
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default);
	}

	public static class OneChannelSDKVersion // TypeDefIndex: 88802
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static OneChannelSDKVersion(); // 0x00000001871E9A10-0x00000001871E9A70
	}

	public enum GameType // TypeDefIndex: 88803
	{
		Local = 0,
		Cloud = 1
	}

	public class CloudGameUtil // TypeDefIndex: 88804
	{
		// Fields
		private static int m_thinClientPlatform; // 0x00
		private static string m_thinClientDeviceProperties; // 0x08
	
		// Properties
		public static int ThinClientPlatform { get; set; } // 0x000000018C22BD68-0x000000018C22BDB8 0x000000018C22BE18-0x000000018C22BE6C
		public static string ThinClientDeviceProperties { get; set; } // 0x000000018C22BD18-0x000000018C22BD68 0x000000018C22BDB8-0x000000018C22BE18
	
		// Constructors
		static CloudGameUtil(); // 0x00000001871E9330-0x00000001871E93A0
	
		// Methods
		public static bool IsCloudGame(); // 0x0000000186144370-0x00000001861444E0
	}

	public class ImageSaver // TypeDefIndex: 88814
	{
		// Nested types
		private enum FolderType // TypeDefIndex: 88805
		{
			UserPicturesFolder = 0,
			GameInstalledFolder = 1
		}
	
		private enum ErrorCode // TypeDefIndex: 88806
		{
			UnknowError = -1,
			NotInited = 0,
			ParamsError = 1,
			ImageNotFound = 3,
			ShareChannelError = 6,
			SaveFailed = 8
		}
	
		private enum CallbackResult : byte // TypeDefIndex: 88807
		{
			Success = 0,
			Cancelled = 1,
			Failed = 2
		}
	
		[UnityEngine.Scripting.Preserve]
		public class ImageShareInfo // TypeDefIndex: 88808
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
			public ImageShareInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private struct _SaveImage_d__5 : IAsyncStateMachine // TypeDefIndex: 88809
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public ImageSaver __4__this; // 0x20
			public string paramJson; // 0x28
			private string _targetPath_5__2; // 0x30
			private TaskAwaiter<bool> __u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x000000018C236900-0x000000018C236D20
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C236D20-0x000000018C236D7C
		}
	
		[CompilerGenerated]
		private struct _SaveCloudGameImage_d__6 : IAsyncStateMachine // TypeDefIndex: 88810
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			public ImageSaver __4__this; // 0x20
			public string paramJson; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x000000018C235DF8-0x000000018C23622C
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C23622C-0x000000018C23628C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 88811
		{
			// Fields
			public ImageSaver __4__this; // 0x10
			public string sourcePath; // 0x18
			public string targetPath; // 0x20
			public string imgFolder; // 0x28
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _SaveImageToPathAsync_b__0(); // 0x000000018C2372DC-0x000000018C2374B4
		}
	
		[CompilerGenerated]
		private struct _SaveImageToPathAsync_d__13 : IAsyncStateMachine // TypeDefIndex: 88812
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
			private void MoveNext(); // 0x000000018C23628C-0x000000018C236554
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C236554-0x000000018C2365B4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 88813
		{
			// Fields
			public string methodName; // 0x10
			public string paramValue; // 0x18
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SendMessageInMain_b__0(); // 0x000000018C2374B4-0x000000018C237510
		}
	
		// Constructors
		public ImageSaver(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public async System.Threading.Tasks.Task SaveImage(string paramJson); // 0x000000018C22D350-0x000000018C22D424
		public async Task<bool> SaveCloudGameImage(string paramJson); // 0x000000018C22D13C-0x000000018C22D22C
		private bool ValidateInput(string paramJson, out ImageShareInfo shareInfo); // 0x000000018C22DB08-0x000000018C22DC20
		private string NormalizeSourcePath(string imgPath); // 0x000000018C22CF0C-0x000000018C22D080
		private FolderType ParseFolderType(int folderType); // 0x000000018C22D080-0x000000018C22D13C
		private string BuildTargetPath(string sourcePath, string relativePath, string baseFolder); // 0x000000018C22C5D4-0x000000018C22C704
		private bool IsDirectoryPath(string path); // 0x000000018C22CB2C-0x000000018C22CBE0
		private string BuildPathForDirectory(string sourcePath, string relativeDirPath, string baseFolder); // 0x000000018C22C4A8-0x000000018C22C5D4
		private async Task<bool> SaveImageToPathAsync(string sourcePath, string targetPath, string imgFolder); // 0x000000018C22D22C-0x000000018C22D350
		private bool IsSamePath(string sourcePath, string targetPath); // 0x000000018C22CBE0-0x000000018C22CCB4
		private bool ValidateMove(string sourcePath, string targetPath, string rootDir, out string error); // 0x000000018C22DC20-0x000000018C22DDF8
		private void EnsureDirectoryExists(string filePath); // 0x000000018C22C704-0x000000018C22C76C
		private bool MoveFile(string sourcePath, string targetPath); // 0x000000018C22CCB4-0x000000018C22CF0C
		private string GetImageSaveFolder(FolderType folderType); // 0x000000018C22C918-0x000000018C22C9CC
		private string GetWindowsPicturePath(); // 0x000000018C22C9CC-0x000000018C22CB2C
		private string GetGameInstalledFolder(); // 0x000000018C22C76C-0x000000018C22C918
		private void SendSuccessResponse(string targetPath); // 0x000000018C22DA14-0x000000018C22DB08
		private void SendErrorResponse(ErrorCode errorCode); // 0x000000018C22D424-0x000000018C22D4FC
		private void SendResponse(CallbackResult code, Dictionary<string, object> extraMsg = null); // 0x000000018C22D5D4-0x000000018C22DA14
		private void SendMessageInMain(string methodName, string paramValue); // 0x000000018C22D4FC-0x000000018C22D5D4
	}

	public class U8MainThreadDispatcher : MonoBehaviour // TypeDefIndex: 88815
	{
		// Fields
		private static readonly ConcurrentQueue<Action> _queue; // 0x00
		private static U8MainThreadDispatcher _instance; // 0x08
		private static int _initialized; // 0x10
	
		// Constructors
		public U8MainThreadDispatcher(); // 0x00000001878364A0-0x00000001878364B8
		static U8MainThreadDispatcher(); // 0x0000000186EA9870-0x0000000186EA9920
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Initialize(); // 0x0000000186FC0720-0x0000000186FC0930
		public static void RunOnMainThread(Action action); // 0x000000018C23945C-0x000000018C2394D0
		private void Update(); // 0x000000018508D580-0x000000018508D690
	}
}

namespace U8.SDK.MiniJSON
{
	public static class Json // TypeDefIndex: 88819
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 88817
		{
			// Fields
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get; } // 0x00000001857C2740-0x00000001857C27A0 
			private char NextChar { get; } // 0x00000001857C2970-0x00000001857C29D0 
			private string NextWord { get; } // 0x00000001857C21A0-0x00000001857C2260 
			private TOKEN NextToken { get; } // 0x00000001857C2510-0x00000001857C2740 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 88816
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
			private Parser(string jsonString); // 0x0000000185786BC0-0x0000000185786C40
	
			// Methods
			public static bool IsWordBreak(char c); // 0x00000001857C2A30-0x00000001857C2AA0
			public static object Parse(string jsonString); // 0x0000000185786AB0-0x0000000185786BC0
			public void Dispose(); // 0x0000000186B80740-0x0000000186B80780
			private Dictionary<string, object> ParseObject(); // 0x00000001857C2340-0x00000001857C2470
			private List<object> ParseArray(); // 0x00000001857C19E0-0x00000001857C1B10
			private object ParseValue(); // 0x00000001857C2260-0x00000001857C2290
			private object ParseByToken(TOKEN token); // 0x00000001857C2290-0x00000001857C2340
			private string ParseString(); // 0x00000001857C27A0-0x00000001857C2970
			private object ParseNumber(); // 0x00000001857C2DA0-0x00000001857C2E50
			private void EatWhitespace(); // 0x00000001857C2470-0x00000001857C2510
		}
	
		private sealed class Serializer // TypeDefIndex: 88818
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer(); // 0x0000000186BB4F80-0x0000000186BB4FF0
	
			// Methods
			public static string Serialize(object obj); // 0x0000000186BB4F00-0x0000000186BB4F80
			private void SerializeValue(object value); // 0x00000001861768A0-0x0000000186176A60
			private void SerializeObject(IDictionary obj); // 0x0000000186176C70-0x000000018617FAD0
			private void SerializeArray(IList anArray); // 0x000000018C23B298-0x000000018C23B70C
			private void SerializeString(string str); // 0x0000000186176A60-0x0000000186176C10
			private void SerializeOther(object value); // 0x0000000186174950-0x0000000186174AB0
		}
	
		// Methods
		public static object Deserialize(string json); // 0x0000000185786A90-0x0000000185786AB0
		public static string Serialize(object obj); // 0x0000000187838CDC-0x0000000187838CE4
	}
}
