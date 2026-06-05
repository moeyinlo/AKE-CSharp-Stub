/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Hypergryph.CloudClientBridge;
using Newtonsoft.Json.Linq;
using UnityEngine;

// Image 61: Hypergryph.OneChannel.dll - Assembly: Hypergryph.OneChannel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59052-59194

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 59194
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_72 C8939CFEA086350CA0F084D5A8FFA18BE802D605B6111130EB5143B5882250C4; // 0x00 // Static value (base64): YQBiAGMAZABlAGYAZwBoAGkAZwBrAGwAbQBuAG8AcABxAHIAcwB0AHUAdgB3AHgAeQB6ADEAMgAzADQANQA2ADcAOAA5ADAA - Metadata: 0x0208044C
	internal static readonly __StaticArrayInitTypeSize_24 C9A1311D05AB372579F6B92A220603EAB8191E15071784A11774A076DC45320B; // 0x48 // Static value (base64): AgAAAAMAAAAFAAAACgAAAA8AAAAPAAAA - Metadata: 0x0208049C

	// Nested types
	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 59192
	{
	}

	private struct __StaticArrayInitTypeSize_72 // TypeDefIndex: 59193
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Hypergryph.PlatformFacade
{
	public class PlatformFacade // TypeDefIndex: 59190
	{
		// Constructors
		public PlatformFacade() {} // Dummy constructor
	
		// Methods
		public static void SetupPlatformFont(IPlatformFont iFont) {} // 0x0000000185492010-0x0000000185492020
	}

	public interface IPlatformFont // TypeDefIndex: 59191
	{
	}
}

namespace U8.SDK
{
	public struct ExternalPluginLoginParams // TypeDefIndex: 59053
	{
		// Fields
		public Action nativeLogin; // 0x00
		public Action<string> nativeLoginCustom; // 0x08
		public Action<string> nativeOnLoginSuc; // 0x10
		public Action<string> nativeOnLoginFail; // 0x18
		public Action<U8MockLogin> markMockLogin; // 0x20
	}

	public struct ExternalPluginLogoutParams // TypeDefIndex: 59054
	{
		// Fields
		public Action nativeLogout; // 0x00
		public Action nativeOnLogoutSuc; // 0x08
		public Action nativeOnLogoutFail; // 0x10
	}

	public struct ExternalPluginPayParams // TypeDefIndex: 59055
	{
		// Fields
		public U8PayParams payParams; // 0x00
		public Func<U8PayParams, SDKPromise<U8PayResult>> nativePay; // 0x08
		public Action<U8PayResult> onPaySuc; // 0x10
		public Action<object> onPayFail; // 0x18
	}

	public interface IExternalPlugin // TypeDefIndex: 59056
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

	public abstract class SDKCaptchaHandler // TypeDefIndex: 59059
	{
		// Nested types
		public enum Status // TypeDefIndex: 59057
		{
			SUC = 0,
			SYS_BUSY = 1,
			USER_CANCEL = 2,
			NOT_SUPPORT = 50,
			INVALID_PARAM = 51,
			UNKNOWN = 99
		}
	
		public class Result // TypeDefIndex: 59058
		{
			// Fields
			private Status _status_k__BackingField; // 0x10
			private int _errorCode_k__BackingField; // 0x14
			private string _captcha_k__BackingField; // 0x18
	
			// Properties
			public Status status { get; private set; } // 0x0000000185492010-0x0000000185492020
			private int errorCode { get; set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0
			public string captcha { get; private set; } // 0x0000000181378230-0x0000000181378240 0x0000000185FBB0B0-0x0000000185FBB0C0
	
			// Constructors
			private Result() {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			public static Result CreateForOutput() => default; // 0x0000000184088E70-0x0000000184088E80
			public void MarkSucceed(string captcha) {} // 0x0000000185492010-0x0000000185492020
			public void MarkFailed(Status status, int errorCode) {} // 0x000000018A984A5C-0x000000018A984AA0
			public void MarkFailed(Status status) {} // 0x000000018A984AF4-0x000000018A984B14
		}
	
		// Constructors
		protected SDKCaptchaHandler() {} // 0x000000018A984AA0-0x000000018A984AC8
	
		// Methods
		public abstract IEnumerator FetchCaptchaCoroutine(string captchaParams, Result outResult); // 0x000000018A984AC8-0x000000018A984AF4
	}

	public abstract class SDKExternalTools // TypeDefIndex: 59093
	{
		// Fields
		private static readonly char[] RANDOM_CHAR_MAP; // 0x00
		protected static readonly int[] PAY_CONFIRM_RETRY_INTERVALS; // 0x08
		private static SDKExternalTools s_instance; // 0x10
		private static IExternalPlugin s_plugin; // 0x18
		private bool _inited_k__BackingField; // 0x10
		private CaptchaMgr _captchaMgr_k__BackingField; // 0x18
		private string _subChannel_k__BackingField; // 0x20
		private static int U8_SDK_SET_DATA_SET_SERVER; // 0x20
	
		// Properties
		protected bool inited { get; private set; } // 0x000000018A982730-0x000000018A9829BC 0x000000018A9829BC-0x000000018A982AD4
		protected IExternalPlugin plugin { get; } // 0x0000000185492010-0x0000000185492020 
		protected CaptchaMgr captchaMgr { get; private set; } // 0x0000000185F6CDF0-0x0000000185F6CE50 0x0000000185492010-0x0000000185492020
		protected string subChannel { get; set; } // 0x0000000185F52720-0x0000000185F527A0
	
		// Nested types
		protected interface IFromJSON // TypeDefIndex: 59060
		{
			// Methods
			bool LoadFromJSON(string json); // 0x0000000181C2FD60-0x0000000181C2FD70
		}
	
		protected enum POSTStatus // TypeDefIndex: 59061
		{
			NONE = 0,
			SUC = 1,
			TIMEOUT = 2,
			ERROR = 3
		}
	
		protected enum BusType // TypeDefIndex: 59062
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
	
		protected enum ErrorType // TypeDefIndex: 59063
		{
			NONE = 0,
			TIMEOUT = 1,
			NETWORK_ERROR = 2,
			DESERIALIZE_FAILED = 3,
			BUSINESS_ERROR = 4
		}
	
		protected struct POSTRequest // TypeDefIndex: 59064
		{
			// Fields
			public string url; // 0x00
			public string body; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> nullableHeaders; // 0x18
		}
	
		protected struct POSTResult // TypeDefIndex: 59065
		{
			// Fields
			public POSTStatus status; // 0x00
			public int httpCode; // 0x04
			public string response; // 0x08
			public string error; // 0x10
	
			// Methods
			public bool ServiceFailed() => default; // 0x000000018184FBD0-0x000000018184FBE0
		}
	
		protected struct ErrMsgMeta // TypeDefIndex: 59066
		{
			// Fields
			public static readonly ErrMsgMeta EMPTY; // 0x00
			public BusType busType; // 0x00
			public ErrorType errorType; // 0x04
			public int errorCode; // 0x08
			public string alertFromServer; // 0x10
			public object meta; // 0x18
	
			// Methods
			public bool IsEmpty() => default; // 0x000000018A986F98-0x000000018A986FE8
			public static ErrMsgMeta FromPOSTResult(BusType busType, POSTResult postRet) => default; // 0x0000000181377E40-0x0000000181377E50
		}
	
		protected class CaptchaMgr // TypeDefIndex: 59068
		{
			// Fields
			private SDKExternalTools m_host; // 0x10
			private SDKCaptchaHandler _activeHandler_k__BackingField; // 0x18
	
			// Properties
			public SDKCaptchaHandler activeHandler { get; private set; } // 0x000000018A9857F4-0x000000018A985870 0x000000018A986300-0x000000018A9863AC
	
			// Nested types
			private sealed class _FetchCaptchaCoroutine_d__6 : IEnumerator<object> // TypeDefIndex: 59067
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public CaptchaMgr __4__this; // 0x20
				public SDKCaptchaHandler.Result outResult; // 0x28
				public Dictionary<string, object> captchaParams; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x000000018A985310-0x000000018A985358 
				object IEnumerator.Current { get => default; } // 0x000000018A986258-0x000000018A986300 
	
				// Constructors
				public _FetchCaptchaCoroutine_d__6() {} // Dummy constructor
				public _FetchCaptchaCoroutine_d__6(int __1__state) {} // 0x0000000184088E70-0x0000000184088E80
	
				// Methods
				void IDisposable.Dispose() {} // 0x000000018646EE40-0x000000018646EE50
				private bool MoveNext() => default;
				private void __m__Finally1() {} // 0x000000018458D4F0-0x000000018458D570
				void IEnumerator.Reset() {} // 0x000000018A985870-0x000000018A9858BC
			}
	
			// Constructors
			public CaptchaMgr() {} // Dummy constructor
			public CaptchaMgr(SDKExternalTools host) {} // 0x000000018647434C-0x0000000186474354
	
			// Methods
			public IEnumerator FetchCaptchaCoroutine(Dictionary<string, object> captchaParams, SDKCaptchaHandler.Result outResult) => default; // 0x0000000184B93770-0x0000000184B93AA0
		}
	
		protected class POSTProcedure // TypeDefIndex: 59071
		{
			// Fields
			private Builder _builder_k__BackingField; // 0x10
			private bool _isServiceFinished_k__BackingField; // 0x38
			private ErrMsgMeta _serviceError_k__BackingField; // 0x40
			private string _rawResponse_k__BackingField; // 0x60
	
			// Properties
			protected Builder builder { get; private set; } // 0x000000018A986574-0x000000018A986618 0x000000018A986618-0x000000018A986710
			public bool isServiceFinished { get; private set; } // 0x000000018A98524C-0x000000018A985310
			public ErrMsgMeta serviceError { get; protected set; } // 0x000000018A985358-0x000000018A9853B4 0x000000018A9853B4-0x000000018A985440
			private string rawResponse { get; set; } // 0x000000018A986E24-0x000000018A986E80
	
			// Nested types
			public struct Builder // TypeDefIndex: 59069
			{
				// Fields
				public POSTRequest request; // 0x00
				public BusType busType; // 0x20
	
				// Methods
				public POSTProcedure Build() => default; // 0x000000018A985568-0x000000018A9857F4
				public POSTProcedure<TResp> TypedBuild<TResp>()
					where TResp : class, IFromJSON, new() => default; // 0x000000018A9860FC-0x000000018A986258
			}
	
			private sealed class _POST_d__18 : IEnumerator<object> // TypeDefIndex: 59070
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public SDKExternalTools host; // 0x20
				public POSTProcedure __4__this; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x000000018A9863AC-0x000000018A986444 
				object IEnumerator.Current { get => default; }
	
				// Constructors
				public _POST_d__18() {} // Dummy constructor
				public _POST_d__18(int __1__state) {} // 0x000000018A986028-0x000000018A9860FC
	
				// Methods
				void IDisposable.Dispose() {} // 0x000000018A9864DC-0x000000018A986574
				private bool MoveNext() => default; // 0x000000018A986444-0x000000018A9864DC
				void IEnumerator.Reset() {} // 0x000000018458A410-0x000000018458A550
			}
	
			// Constructors
			public POSTProcedure() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public ErrMsgMeta MakeBusinessError(int errorCode) => default; // 0x000000018458A580-0x000000018458A630
			public IEnumerator POST(SDKExternalTools host) => default; // 0x0000000185492010-0x0000000185492020
			private void _OnServiceFinished(POSTResult postRet) {} // 0x0000000185492010-0x0000000185492020
			protected virtual void HandleServiceResponse(POSTResult postRet) {} // 0x0000000185492010-0x0000000185492020
		}
	
		protected class POSTProcedure<TResp> : POSTProcedure // TypeDefIndex: 59072
			where TResp : class, IFromJSON, new()
		{
			// Fields
			private TResp _response_k__BackingField;
	
			// Properties
			public TResp response { get; private set; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public POSTProcedure() {} // 0x00000001813AE580-0x00000001813AE590
	
			// Methods
			protected override void HandleServiceResponse(POSTResult postRet) {}
		}
	
		protected class AuthV2SessionTokenResp : IFromJSON // TypeDefIndex: 59073
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public string token; // 0x28
			public string uid; // 0x30
			public bool isNew; // 0x38
	
			// Constructors
			public AuthV2SessionTokenResp() {}
	
			// Methods
			public bool LoadFromJSON(string json) => default;
		}
	
		public class GetProductLsitResp : IFromJSON // TypeDefIndex: 59074
		{
			// Fields
			public int flag; // 0x10
			public Dictionary<string, object> desc; // 0x18
	
			// Constructors
			public GetProductLsitResp() {}
	
			// Methods
			public bool LoadFromDictionary(Dictionary<string, object> dict) => default;
			public bool LoadFromJSON(string json) => default;
		}
	
		protected class AuthV2GrantResp : IFromJSON // TypeDefIndex: 59075
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
			public AuthV2GrantResp() {}
	
			// Methods
			public bool LoadFromJSON(string json) => default;
		}
	
		protected class ServerListResp : IFromJSON // TypeDefIndex: 59077
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public List<ServerData> data; // 0x20
	
			// Nested types
			public struct ServerData // TypeDefIndex: 59076
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
			public ServerListResp() {} // 0x0000000184B92810-0x0000000184B92880
	
			// Methods
			public bool LoadFromJSON(string json) => default;
			public List<U8ServerInfo> ToServerInfo() => default;
		}
	
		protected class ConfirmServerResp : IFromJSON // TypeDefIndex: 59078
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
	
			// Constructors
			public ConfirmServerResp() {} // 0x000000018A986B48-0x000000018A986C70
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x00000001839B1EC0-0x00000001839B2770
		}
	
		protected class ConfirmOrderU1Resp : IFromJSON // TypeDefIndex: 59079
		{
			// Fields
			public int status; // 0x10
	
			// Constructors
			public ConfirmOrderU1Resp() {} // 0x000000018A985B2C-0x000000018A985BD4
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018A985BD4-0x000000018A985C7C
		}
	
		protected class CreateOrderU1Resp : IFromJSON // TypeDefIndex: 59081
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public Data data; // 0x28
	
			// Nested types
			public struct Data // TypeDefIndex: 59080
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
			public CreateOrderU1Resp() {} // 0x000000018A9858BC-0x000000018A985A10
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018A985C7C-0x000000018A985D30
			public U8OrderInfo ToOrderInfo() => default; // 0x000000018A985A10-0x000000018A985B2C
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 59082
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<string> __9__43_0; // 0x08
			public static Action<string> __9__43_1; // 0x10
			public static Action __9__44_0; // 0x18
			public static Action __9__44_1; // 0x20
	
			// Constructors
			static __c() {} // 0x000000018A985D30-0x000000018A986028
			public __c() {} // 0x000000018A986C70-0x000000018A986E24
	
			// Methods
			internal void _LoginWithPlugin_b__43_0(string extension) {} // 0x000000018A986710-0x000000018A9867B8
			internal void _LoginWithPlugin_b__43_1(string message) {} // 0x000000018A986994-0x000000018A986A8C
			internal void _LogoutWithPlugin_b__44_0() {} // 0x000000018A986A8C-0x000000018A986B48
			internal void _LogoutWithPlugin_b__44_1() {} // 0x000000018A9867B8-0x000000018A986860
		}
	
		private sealed class __NextFrameCoroutine_d__61 : IEnumerator<object> // TypeDefIndex: 59083
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action action; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018A986F0C-0x000000018A986F98 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __NextFrameCoroutine_d__61() {} // Dummy constructor
			public __NextFrameCoroutine_d__61(int __1__state) {} // 0x000000018A986E80-0x000000018A986F0C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018A986908-0x000000018A986994
			private bool MoveNext() => default; // 0x000000018A986860-0x000000018A986908
			void IEnumerator.Reset() {} // 0x00000001839B2770-0x00000001839B2AD0
		}
	
		private sealed class _SDKInterfaceAuthV2SessionToken_d__114 : IEnumerator<object> // TypeDefIndex: 59084
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001840066E0-0x00000001840066F0 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public _SDKInterfaceAuthV2SessionToken_d__114() {} // Dummy constructor
			public _SDKInterfaceAuthV2SessionToken_d__114(int __1__state) {} // 0x0000000185D6C270-0x0000000185D6C3B0
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default; // 0x000000018A984930-0x000000018A984938
			void IEnumerator.Reset() {} // 0x000000018A982AD4-0x000000018A982B14
		}
	
		private sealed class _SDKInterfaceAuthV2OAuth2Code_d__115 : IEnumerator<object> // TypeDefIndex: 59085
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string sessionToken; // 0x28
			public SDKPromiseWithResult<U8GrantResult> promise; // 0x30
			public Action onSessionInvalid; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x000000018A9888A4-0x000000018A988C40 
	
			// Constructors
			public _SDKInterfaceAuthV2OAuth2Code_d__115() {} // Dummy constructor
			public _SDKInterfaceAuthV2OAuth2Code_d__115(int __1__state) {} // 0x0000000184088E70-0x0000000184088E80
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184096E30-0x0000000184096EF0
			private bool MoveNext() => default; // 0x000000018A98252C-0x000000018A9825B8
			void IEnumerator.Reset() {} // 0x000000018A988C8C-0x000000018A988D04
		}
	
		private sealed class __AuthV2GrantImpl_d__121 : IEnumerator<object> // TypeDefIndex: 59086
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x000000018A9747FC-0x000000018A974820 
	
			// Constructors
			public __AuthV2GrantImpl_d__121() {} // Dummy constructor
			public __AuthV2GrantImpl_d__121(int __1__state) {} // 0x000000018A988D04-0x000000018A988D34
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018A988C40-0x000000018A988C8C
			void IEnumerator.Reset() {} // 0x00000001834A5990-0x00000001834A59B0
		}
	
		private sealed class __ConfirmOrderU1Coroutine_d__124 : IEnumerator<object> // TypeDefIndex: 59087
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string orderId; // 0x28
			public string extension; // 0x30
			public SDKPromise<U8ConfirmOrderResult> promise; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018A984918-0x000000018A984930 
			object IEnumerator.Current { get => default; } // 0x0000000185FCE6D0-0x0000000185FCE710 
	
			// Constructors
			public __ConfirmOrderU1Coroutine_d__124() {} // Dummy constructor
			public __ConfirmOrderU1Coroutine_d__124(int __1__state) {} // 0x0000000185FB0700-0x0000000185FB0710
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FAFE20-0x0000000185FAFE30
			private bool MoveNext() => default; // 0x0000000185FCE710-0x0000000185FCE730
			void IEnumerator.Reset() {} // 0x0000000185AE8FE0-0x0000000185AE8FF0
		}
	
		private sealed class __PollOrderStatusCoroutine_d__125 : IEnumerator<object> // TypeDefIndex: 59088
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public __PollOrderStatusCoroutine_d__125() {} // Dummy constructor
			public __PollOrderStatusCoroutine_d__125(int __1__state) {} // 0x000000018A984794-0x000000018A984808
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018A984808-0x000000018A984918
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x000000018A9824B8-0x000000018A98252C
		}
	
		private sealed class __GetServerListCoroutine_d__126 : IEnumerator<object> // TypeDefIndex: 59089
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string paramStr; // 0x28
			public SDKPromise<List<U8ServerInfo>> promise; // 0x30
			private POSTProcedure<ServerListResp> _postImpl_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __GetServerListCoroutine_d__126() {} // Dummy constructor
			public __GetServerListCoroutine_d__126(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018A988D34-0x000000018A988E58
			void IEnumerator.Reset() {} // 0x000000018A988E58-0x000000018A988EA4
		}
	
		private sealed class __ConfirmServerListCoroutine_d__128 : IEnumerator<object> // TypeDefIndex: 59090
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
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __ConfirmServerListCoroutine_d__128() {} // Dummy constructor
			public __ConfirmServerListCoroutine_d__128(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {} // 0x000000018A9822C4-0x000000018A9824B8
		}
	
		private sealed class __SendCreateOrderU1Coroutine_d__129 : IEnumerator<object> // TypeDefIndex: 59091
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKExternalTools __4__this; // 0x20
			public string paramStr; // 0x28
			public SDKPromise<U8OrderInfo> promise; // 0x30
			private POSTProcedure<CreateOrderU1Resp> _postImpl_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018A981FF8-0x000000018A9822C4 
			object IEnumerator.Current { get => default; } // 0x000000018A988134-0x000000018A98862C 
	
			// Constructors
			public __SendCreateOrderU1Coroutine_d__129() {} // Dummy constructor
			public __SendCreateOrderU1Coroutine_d__129(int __1__state) {} // 0x000000018A982B14-0x000000018A982D78
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018A982D78-0x000000018A982E58
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __SendCreateOrderFailCoroutine_d__130 : IEnumerator<object> // TypeDefIndex: 59092
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SDKPromise<U8OrderInfo> promise; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __SendCreateOrderFailCoroutine_d__130() {} // Dummy constructor
			public __SendCreateOrderFailCoroutine_d__130(int __1__state) {} // 0x000000018A98862C-0x000000018A9888A4
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018A982654-0x000000018A982730
			void IEnumerator.Reset() {} // 0x000000018A9825B8-0x000000018A982654
		}
	
		// Constructors
		protected SDKExternalTools() {} // 0x00000001839F7450-0x00000001839F74A0
		static SDKExternalTools() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static bool SDKInterfaceInitExternalTools<ConcreteType>()
			where ConcreteType : SDKExternalTools => default; // 0x000000018A989320-0x000000018A98938C
		public static SDKExternalTools GetInstance() => default; // 0x000000018A98938C-0x000000018A98940C
		public static bool HasInstance() => default; // 0x000000018A98940C-0x000000018A98948C
		public string PublicServiceSignKey() => default; // 0x0000000181378230-0x0000000181378240
		public SDKPromise<List<U8ProductInfo>> SDKInterfaceProductListV2() => default; // 0x0000000185492010-0x0000000185492020
		public void NotifyProductListUpdated(List<U8ProductInfo> productList) {} // 0x000000018A98AE80-0x000000018A98AED0
		public string SDKInterfaceSDKToken() => default; // 0x0000000181377E40-0x0000000181377E50
		public static string MakeHttpPostParam(Dictionary<string, object> param) => default; // 0x000000018A98AED0-0x000000018A98AF1C
		public void LoginWithPlugin(Action nativeLogin, Action<string> nativeLoginCustom, Action<U8MockLogin> markMockLogin) {} // 0x0000000181377E40-0x0000000181377E50
		public void LogoutWithPlugin(Action nativeLogout) {} // 0x0000000181378230-0x0000000181378240
		public void SDKInterfacePayWithPlugin(U8PayParams payParams, Func<U8PayParams, SDKPromise<U8PayResult>> nativePay, Action<U8PayResult> onSuc, Action<object> onFail) {} // 0x0000000185492010-0x0000000185492020
		public string SDKInterfaceGetPayAddition() => default; // 0x00000001839DFFC0-0x00000001839E2460
		public static void StaticLog(string content) {} // 0x0000000181377E40-0x0000000181377E50
		public static void StaticLogWarning(string content) {} // 0x00000001839E2460-0x00000001839E24B0
		public static void StaticLogError(string content) {} // 0x0000000181377E40-0x0000000181377E50
		public static void RegisterPlugin(IExternalPlugin plugin) {} // 0x0000000181378230-0x0000000181378240
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default) => default; // 0x0000000185492010-0x0000000185492020
		protected string U8Url(string routeUrl) => default; // 0x00000001839DFA60-0x00000001839DFF70
		protected string U8urlWithoutU8(string routeUrl) => default; // 0x0000000181377E40-0x0000000181377E50
		protected static ErrMsgMeta HandleResponseFromU8<TResp>(BusType busType, POSTResult postRet, out ref TResp resp)
			where TResp : IFromJSON, new() {
			resp = default;
			return default;
		} // 0x00000001839DFF70-0x00000001839DFFC0
		protected static Dictionary<string, object> FromMiniJSON(string json) => default; // 0x0000000181377E40-0x0000000181377E50
		protected static void InternalInvokeCoroutine(IEnumerator coroutine) {} // 0x0000000181378230-0x0000000181378240
		protected static void InternalInvokeNextFrame(Action action) {} // 0x0000000185492010-0x0000000185492020
		private static IEnumerator _NextFrameCoroutine(Action action) => default; // 0x00000001839EC880-0x00000001839EF9D0
		public void InitIfNot() {} // 0x0000000181377E40-0x0000000181377E50
		protected virtual void Init() {} // 0x00000001839EF9D0-0x00000001839EFA20
		public virtual void SwitchAccount() {} // 0x0000000181377E40-0x0000000181377E50
		public virtual void OnSDKError(SDKError error) {} // 0x0000000181378230-0x0000000181378240
		public virtual void OnInvalidProduct(int storeId) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnSDKExtraInfo(string jsonData) {} // 0x00000001839EFA20-0x00000001839F1770
		public virtual SDKMeta LoadSDKMetaFromPlugin(Func<SDKMeta> nativeLoadMeta) => default; // 0x0000000181377E40-0x0000000181377E50
		protected abstract SDKCaptchaHandler CreateCaptchaHandler(); // 0x00000001839F1770-0x00000001839F17C0
		protected virtual string GetSignKey() => default; // 0x0000000181377E40-0x0000000181377E50
		public abstract Dictionary<string, string> GetDeviceIDs(); // 0x0000000181378230-0x0000000181378240
		protected abstract SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr); // 0x0000000185492010-0x0000000185492020
		protected abstract int GetPlatformKey(); // 0x00000001839F4B10-0x00000001839F7080
		protected abstract void POSTImplementation(POSTRequest request, Action<POSTResult> callback); // 0x0000000181377E40-0x0000000181377E50
		protected abstract string U8RootUrl(); // 0x00000001839F7080-0x00000001839F70D0
		protected abstract string GetErrorMessage(ErrMsgMeta meta); // 0x0000000181377E40-0x0000000181377E50
		protected abstract void Log(string content); // 0x0000000181378230-0x0000000181378240
		protected abstract void LogWarning(string content); // 0x0000000185492010-0x0000000185492020
		protected abstract void LogError(string content); // 0x00000001839F37C0-0x00000001839F4AC0
		private bool _ValidatePlugin() => default; // 0x0000000181377E40-0x0000000181377E50
		private static void _AddAppIdOrAppCode(Dictionary<string, object> paramDict, SDKMeta meta) {} // 0x00000001839F4AC0-0x00000001839F4B10
		private static string _MakeGetProductListV2Param(SDKMeta meta) => default; // 0x0000000181377E40-0x0000000181377E50
		public IEnumerator SDKInterfaceAuthV2SessionToken(SDKMeta meta, string channelToken, SDKPromiseWithResult<U8LoginV2Result> promise) => default; // 0x0000000181378230-0x0000000181378240
		public IEnumerator SDKInterfaceAuthV2OAuth2Code(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid) => default; // 0x0000000185492010-0x0000000185492020
		public SDKPromise<U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(string orderId, string extension) => default; // 0x00000001839F17C0-0x00000001839F3770
		public SDKPromise<List<U8ServerInfo>> SDKInterFaceGetServerList(string sessionToken) => default; // 0x0000000181377E40-0x0000000181377E50
		public SDKPromise<U8ConfirmServerResult> SDKInterFaceConfirmServer(string sessionToken, string serverId) => default; // 0x00000001839F3770-0x00000001839F37C0
		public SDKPromise<U8OrderInfo> SDKInterfaceCreateOrderU1(string sessionToken, string productId, string signParams) => default; // 0x0000000181377E40-0x0000000181377E50
		private static string _MakeGrantParam(string sessionToken, int type, string captcha) => default; // 0x0000000181378230-0x0000000181378240
		private IEnumerator _AuthV2GrantImpl(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid) => default; // 0x0000000185492010-0x0000000185492020
		private static string _MakeCheckOrderV1Param(string orderId, string extension) => default; // 0x00000001839F74A0-0x00000001839F9180
		private static string _MakeConfirmOrderV1Param(string orderId) => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _ConfirmOrderU1Coroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise) => default; // 0x00000001839F9180-0x00000001839F9720
		private IEnumerator _PollOrderStatusCoroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise) => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _GetServerListCoroutine(string paramStr, SDKPromise<List<U8ServerInfo>> promise) => default; // 0x0000000181378230-0x0000000181378240
		private IEnumerator _ConfirmServerListCoroutine(string paramStr, string serverId, SDKPromise<U8ConfirmServerResult> promise) => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerator _SendCreateOrderU1Coroutine(string paramStr, SDKPromise<U8OrderInfo> promise) => default; // 0x00000001839F70D0-0x00000001839F7450
		private IEnumerator _SendCreateOrderFailCoroutine(SDKPromise<U8OrderInfo> promise) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public struct SDKExtraData // TypeDefIndex: 59094
	{
		// Fields
		public static readonly SDKExtraData EMPTY; // 0x00
		public int code; // 0x00
		public Dictionary<string, object> msg; // 0x08
	
		// Constructors
		static SDKExtraData() {
			EMPTY = default;
		} // 0x0000000185F7A4E0-0x0000000185F7A530
	
		// Methods
		public static SDKExtraData FromJson(string jsonStr) => default; // 0x0000000185839F60-0x000000018583A0D0
	}

	public abstract class SDKExternalToolsShortcut : SDKExternalTools // TypeDefIndex: 59099
	{
		// Nested types
		protected struct U8ProductListDataV2 : SDKExternalTools.IFromJSON // TypeDefIndex: 59095
		{
			// Fields
			public List<U8ProductInfo> productList; // 0x00
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018A985040-0x000000018A985210
			private static bool _BuildProductInfo(U8ProductInfo outInfo, Dictionary<string, object> dict) => default; // 0x000000018A984D3C-0x000000018A984E48
		}
	
		public enum RequestConnPolicy // TypeDefIndex: 59096
		{
			DEFAULT = 0,
			CLOSE_EACH_CON = 1
		}
	
		public struct RequestHeaderInjectOptions // TypeDefIndex: 59097
		{
			// Fields
			public RequestConnPolicy policy; // 0x00
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 59098
		{
			// Fields
			public SDKPromise<List<U8ProductInfo>> promise; // 0x10
			public SDKExternalToolsShortcut __4__this; // 0x18
			public SDKExternalTools.POSTRequest request; // 0x20
			public Action<SDKExternalTools.POSTResult> callback; // 0x40
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018A984E48-0x000000018A984F68
	
			// Methods
			internal void _SendGetProductListRequestV2_b__0(SDKExternalTools.POSTResult postRet) {} // 0x000000018A984F68-0x000000018A985040
			internal void _SendGetProductListRequestV2_b__1() {} // 0x000000018A985210-0x000000018A98524C
		}
	
		// Constructors
		protected SDKExternalToolsShortcut() {} // 0x000000018A9896A8-0x000000018A9896E0
	
		// Methods
		protected sealed override SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr) => default; // 0x0000000185FA2A90-0x0000000185FA2AD0
		public override Dictionary<string, string> GetDeviceIDs() => default; // 0x000000018A98BB00-0x000000018A98BDA8
		public static string GetU8DeviceID() => default; // 0x000000018A98BDA8-0x000000018A98BF70
		public static void InjectRequestHeaders(ref Dictionary<string, string> headers, RequestHeaderInjectOptions policy) {} // 0x0000000185492010-0x0000000185492020
		private string _GetProductListV1Url() => default; // 0x000000018A989564-0x000000018A9896A8
	}

	public abstract class U8SDKInterface // TypeDefIndex: 59115
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
		private static ReceiverProductListResult onReceiverProductlist; // 0x10
		private GameServerTimeCache m_gameServerTimeCache; // 0xB8
	
		// Properties
		public static U8SDKInterface Instance { get; }
		public bool isNativePlugin { get; }
		public string uid { get; } // 0x000000018A98D920-0x000000018A98D9F4 
		public string cachedUid { get; set; } // 0x000000018346D8F0-0x000000018346D900 0x0000000185FCE730-0x0000000185FCE750
		public string oauth2token { get; } // 0x0000000185FCE750-0x0000000185FCE770 
		public string oauth2code { get; } // 0x000000018525BCA0-0x000000018525BD20 
		public static bool isInterfaceDisabled { get; } // 0x0000000184EE7C50-0x0000000184EE7CB0 
		public string sessionToken { get; } // 0x0000000185B6D0D0-0x0000000185B6D130 
		public GameServerTimeCache serverCacheTime { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x000000018A98AE34-0x000000018A98AE80
	
		// Events
		private static event ReceiverProductListResult onReceiverProductlist;
	
		// Nested types
		public struct AuthStatus // TypeDefIndex: 59100
		{
			// Fields
			public static readonly AuthStatus EMPTY; // 0x00
			public string uid; // 0x00
			public string oauth2code; // 0x08
			public string oauth2token; // 0x10
			public string sessionToken; // 0x18
		}
	
		private struct V2LoginStatus // TypeDefIndex: 59101
		{
			// Fields
			public string sessionToken; // 0x00
		}
	
		public delegate void ReceiverProductListResult(Dictionary<string, object> msg); // TypeDefIndex: 59102; 0x0000000184F667F0-0x0000000184F66870
	
		public struct GameServerTimeCache // TypeDefIndex: 59103
		{
			// Fields
			public long cacheTime; // 0x00
			public long maintainEndTs; // 0x08
			public long maintainStartTs; // 0x10
		}
	
		private sealed class __c__DisplayClass51_0<ToolType> // TypeDefIndex: 59104
			where ToolType : SDKExternalTools
		{
			// Fields
			public SDKPromise<string> delegatePromise;
			public U8SDKInterface __4__this;
			public string env;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass51_0() {} // 0x0000000185BA7B40-0x0000000185BA7B60
	
			// Methods
			internal void _V2PublicInit_b__0(string obj) {} // 0x000000018A98C21C-0x000000018A98C23C
			internal void _V2PublicInit_b__3() {}
			internal void _V2PublicInit_b__1(object info) {} // 0x000000018A98C23C-0x000000018A98C25C
			internal void _V2PublicInit_b__2() {} // 0x000000018A98C25C-0x000000018A98C280
		}
	
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 59105
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public string uid; // 0x18
			public bool isNew; // 0x20
	
			// Constructors
			public __c__DisplayClass55_0() {} // 0x000000018A98C3A8-0x000000018A98C3F4
	
			// Methods
			internal void __onLoginSuc_b__0() {} // 0x000000018A98C314-0x000000018A98C3A8
		}
	
		private sealed class __c__DisplayClass57_0 // TypeDefIndex: 59106
		{
			// Fields
			public SDKExternalTools externalTools; // 0x10
			public U8SDKInterface __4__this; // 0x18
			public SDKPromise<U8ProductsResult> delegatePromise; // 0x20
			public Action<List<U8ProductInfo>> __9__1; // 0x28
			public Action<object> __9__2; // 0x30
	
			// Constructors
			public __c__DisplayClass57_0() {} // 0x000000018A98C280-0x000000018A98C314
	
			// Methods
			internal void _PublicGetProductListV2_b__0() {} // 0x00000001813AC280-0x00000001813AC290
			internal void _PublicGetProductListV2_b__1(List<U8ProductInfo> productList) {} // 0x000000018525C180-0x000000018525C1C0
			internal void _PublicGetProductListV2_b__2(object rejectObj) {} // 0x00000001855A65B0-0x00000001855A6610
		}
	
		private sealed class __c__DisplayClass57_1 // TypeDefIndex: 59107
		{
			// Fields
			public List<U8ProductInfo> productList; // 0x10
			public ReceiverProductListResult receiver; // 0x18
			public __c__DisplayClass57_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass57_1() {} // 0x0000000183060C50-0x0000000183060C60
	
			// Methods
			internal void _PublicGetProductListV2_b__3(Dictionary<string, object> msg) {} // 0x0000000181460F70-0x0000000181460F80
		}
	
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 59108
		{
			// Fields
			public U8PayParams payParams; // 0x10
			public U8SDKInterface __4__this; // 0x18
			public SDKPromise<U8PayResult> wrappedPromise; // 0x20
			public U8ProductInfo productInfo; // 0x28
			public Action<U8PayResult> __9__1; // 0x30
			public Action<object> __9__2; // 0x38
	
			// Constructors
			public __c__DisplayClass69_0() {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			internal void _PublicPay_b__0() {} // 0x00000001864738F0-0x0000000186473900
			internal void _PublicPay_b__1(U8PayResult payResult) {} // 0x0000000186475390-0x00000001864753A4
			internal void _PublicPay_b__2(object payFailMsg) {} // 0x000000018A98D8D0-0x000000018A98D920
			internal void _PublicPay_b__3(U8PayResult payResult) {}
			internal void _PublicPay_b__4(object payFailMsg) {} // 0x0000000185FAF260-0x0000000185FAF280
		}
	
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 59109
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public long revenue; // 0x18
	
			// Constructors
			public __c__DisplayClass70_0() {} // 0x0000000185EB81B0-0x0000000185EB8290
	
			// Methods
			internal void __OnNativePayFulfilled_b__0() {} // 0x000000018A98C838-0x000000018A98C958
		}
	
		private sealed class __c__DisplayClass78_0 // TypeDefIndex: 59110
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public U8PayParams payParams; // 0x18
	
			// Constructors
			public __c__DisplayClass78_0() {} // 0x000000018A98C3F4-0x000000018A98C450
	
			// Methods
			internal void __NativePay_b__0() {} // 0x000000018A98C450-0x000000018A98C47C
		}
	
		private sealed class __NextFrameCoroutine_d__105 : IEnumerator<object> // TypeDefIndex: 59111
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action call; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018A98CD24-0x000000018A98CD2C 
			object IEnumerator.Current { get => default; } // 0x000000018A98D650-0x000000018A98D70C 
	
			// Constructors
			public __NextFrameCoroutine_d__105() {} // Dummy constructor
			public __NextFrameCoroutine_d__105(int __1__state) {} // 0x00000001855A6570-0x00000001855A65B0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018A98CA3C-0x000000018A98CADC
			private bool MoveNext() => default; // 0x000000018A98C958-0x000000018A98C960
			void IEnumerator.Reset() {} // 0x000000018A98CADC-0x000000018A98CD24
		}
	
		private sealed class __c__DisplayClass131_0 // TypeDefIndex: 59112
		{
			// Fields
			public U8SDKInterface __4__this; // 0x10
			public SDKPromise<U8AuthV2Result> promise; // 0x18
	
			// Constructors
			public __c__DisplayClass131_0() {} // 0x000000018A98D72C-0x000000018A98D7FC
	
			// Methods
			internal void __DoMockAuthV2_b__0() {} // 0x000000018A98D1DC-0x000000018A98D56C
		}
	
		private sealed class __LoginV2Coroutine_d__132 : IEnumerator<object> // TypeDefIndex: 59113
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8SDKInterface __4__this; // 0x20
			public SDKPromise<string> promise; // 0x28
			private SDKPromiseEnumerator<string> _loginEnumerator_5__2; // 0x30
			private SDKPromiseWithResult<U8LoginV2Result> _sessionTokenPromise_5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public __LoginV2Coroutine_d__132() {} // Dummy constructor
			public __LoginV2Coroutine_d__132(int __1__state) {} // 0x000000018A98D56C-0x000000018A98D650
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default; // 0x000000018A98C960-0x000000018A98CA3C
			void IEnumerator.Reset() {}
		}
	
		private sealed class __AuthV2Coroutine_d__134 : IEnumerator<object> // TypeDefIndex: 59114
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8SDKInterface __4__this; // 0x20
			public SDKPromise<U8AuthV2Result> promise; // 0x28
			private SDKPromiseWithResult<U8GrantResult> _oauth2codePromise_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public __AuthV2Coroutine_d__134() {} // Dummy constructor
			public __AuthV2Coroutine_d__134(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		protected U8SDKInterface() {} // 0x0000000185492010-0x0000000185492020
		static U8SDKInterface() {} // 0x000000018A98AAD0-0x000000018A98AD9C
	
		// Methods
		public void CallbackInitSuc(string extConfigs) {}
		public void CallbackInitFail(string info) {}
		public void CallbackLoginSuc(string extension) {} // 0x0000000184EE8230-0x0000000184EE8290
		public void CallbackLoginFail(string info) {} // 0x0000000184EE81A0-0x0000000184EE8230
		public void CallbackLogout() {} // 0x0000000185F65870-0x0000000185F658D0
		public void CallbackSwitchAccount() {} // 0x00000001856F8F80-0x00000001856FB4C0
		public void CallbackPaySuc(string jsonData) {} // 0x000000018A98C47C-0x000000018A98C838
		public void CallbackPayFail(string failMsg) {} // 0x000000018A98D7FC-0x000000018A98D8D0
		public string PublicLoadExtraConfig() => default; // 0x000000018A98CE00-0x000000018A98CE80
		public void PublicSetGameVersion(string version) {} // 0x000000018A98CE80-0x000000018A98CEDC
		public ReceiverProductListResult getOnReceiverProductlist() => default; // 0x000000018A98CD94-0x000000018A98CE00
		public SDKPromise<string> V2PublicInit<ToolType>(string env)
			where ToolType : SDKExternalTools => default; // 0x000000018A98CD2C-0x000000018A98CD94
		private void _MarkMockLogin(U8MockLogin mockLogin) {} // 0x0000000184EE7CB0-0x0000000184EE7DA0
		private void _onLoginSuc(string uid, bool isNew) {} // 0x000000018525BD20-0x000000018525BDA0
		public SDKPromise<U8ProductsResult> PublicGetProductListV2() => default; // 0x000000018A98D70C-0x000000018A98D72C
		public void ClearAuthStatus() {} // 0x000000018A98D168-0x000000018A98D1DC
		public void ClearLoginStatus() {} // 0x0000000185C65120-0x0000000185C65270
		private void _ConfirmAuthResult(AuthStatus result) {} // 0x0000000185F8AD30-0x0000000185F8AD80
		public SDKPromise<object> PublicLogout() => default; // 0x000000018A98CEDC-0x000000018A98D000
		public SDKPromise<List<U8ServerInfo>> PublicGetServerList() => default; // 0x000000018A98D000-0x000000018A98D010
		public SDKPromise<U8ConfirmServerResult> PubliceConfirmServer(string serverId) => default; // 0x000000018A98D010-0x000000018A98D168
		public SDKPromise<U8PayResult> PublicPay(int storeId, U8OrderInfo orderInfo) => default; // 0x0000000187893E40-0x0000000187893F64
		private void _OnNativePayFulfilled(long revenue) {} // 0x00000001833EEC70-0x00000001833EEC80
		private bool _TryGetProduct(int storeId, out U8ProductInfo productInfo) {
			productInfo = default;
			return default;
		}
		private U8PayParams _GeneratePayParams(U8ProductInfo productInfo, U8OrderInfo orderInfo) => default;
		private SDKPromise<U8PayResult> _NativePay(U8PayParams payParams) => default;
		private static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default) => default;
		public SDKMeta PublicLoadSDKMeta() => default;
		protected abstract string LoadExtraConfig(); // 0x0000000185492010-0x0000000185492020
		protected abstract void V2Init(string env); // 0x00000001856F8B20-0x00000001856F8EB0
		protected abstract void Login(); // 0x0000000185492010-0x0000000185492020
		protected abstract void LoginCustom(string customData); // 0x000000018A9896E0-0x000000018A989800
		protected abstract bool Logout(); // 0x000000018A989800-0x000000018A989AD4
		public abstract bool ShowAccountCenter(); // 0x000000018A989AD4-0x000000018A989AF8
		public abstract void SubmitGameData(U8ExtraGameData data); // 0x0000000185492010-0x0000000185492020
		protected abstract void Pay(U8PayParams data); // 0x000000018A989AF8-0x000000018A98A60C
		public abstract void SetData(int type, string paramJson); // 0x0000000185492010-0x0000000185492020
		public abstract string GetData(int type, string paramJson); // 0x000000018A98A60C-0x000000018A98A798
		protected abstract SDKMeta LoadSDKMeta(); // 0x000000018A98A798-0x000000018A98A83C
		protected abstract bool IsNativePlugin(); // 0x000000018A989AD4-0x000000018A989AF8
		public abstract void SetGameVersion(string version); // 0x000000018A98A83C-0x000000018A98A8E0
		private IEnumerator _NextFrameCoroutine(Action call) => default; // 0x000000018A989AD4-0x000000018A989AF8
		protected void InvokeNextFrame(Action action) {} // 0x0000000185492010-0x0000000185492020
		protected void InvokeCoroutine(IEnumerator coroutine) {} // 0x000000018A98A8E0-0x000000018A98AA24
		protected string EncodeGameData(U8ExtraGameData data) => default; // 0x0000000185492010-0x0000000185492020
		protected string EncodePayParams(U8PayParams data) => default; // 0x000000018A98AA24-0x000000018A98AA6C
		public SDKPromise<string> V2PublicLogin() => default; // 0x0000000181377E40-0x0000000181377E50
		public SDKPromise<U8AuthV2Result> V2PublicAuth() => default; // 0x0000000185492010-0x0000000185492020
		public SDKPromise<U8OrderInfo> U1PublicCreateOrder(string productId, string signParams) => default; // 0x00000001855A63C0-0x00000001855A6570
		public SDKPromise<List<U8ServerInfo>> U1PublicGetServerList() => default; // 0x0000000181378230-0x0000000181378240
		public SDKPromise<U8ConfirmServerResult> U1PublicConfirmServer(string serverId) => default; // 0x0000000185492010-0x0000000185492020
		public SDKPromise<U8ConfirmOrderResult> U1PublicConfirmOrder(string orderId, string extension) => default; // 0x0000000184B94B00-0x0000000184B97E20
		private SDKPromise<U8AuthV2Result> _DoMockAuthV2() => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _LoginV2Coroutine(SDKPromise<string> promise) => default; // 0x000000018A98ADE8-0x000000018A98AE34
		private void _OnSessionTokenInvalid() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _AuthV2Coroutine(SDKPromise<U8AuthV2Result> promise) => default; // 0x0000000181378230-0x0000000181378240
		private void _PublicLogout_b__65_0() {} // 0x0000000181377E40-0x0000000181377E50
		private void _PublicLogout_b__65_1() {} // 0x000000018A98AD9C-0x000000018A98ADE8
		private void _PublicLogout_b__65_2() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public struct SDKError // TypeDefIndex: 59116
	{
		// Fields
		private string _code_k__BackingField; // 0x00
		private string _msg_k__BackingField; // 0x08
	
		// Properties
		private string code { get; set; } // 0x000000018646FE2C-0x000000018646FE34
		private string msg { get; set; } // 0x00000001877900A4-0x00000001877900B4
	
		// Constructors
		public SDKError(string content) : this() {
			<code>k__BackingField = default;
			<msg>k__BackingField = default;
		} // 0x000000018A984B14-0x000000018A984D3C
	}

	public struct U8MockLogin // TypeDefIndex: 59117
	{
		// Fields
		public static readonly U8MockLogin EMPTY; // 0x00
		public string uid; // 0x00
		public string token; // 0x08
	
		// Methods
		public bool IsEmpty() => default; // 0x0000000186472A1C-0x0000000186472A34
	}

	public class U8ProductInfo // TypeDefIndex: 59118
	{
		// Fields
		public int store_id; // 0x10
		public string product_id; // 0x18
		public string desc; // 0x20
		public string name; // 0x28
		public long price; // 0x30
		public string channel_product_id; // 0x38
		public string display_price; // 0x40
	
		// Constructors
		public U8ProductInfo() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8ProductsResult // TypeDefIndex: 59119
	{
		// Fields
		public int status; // 0x10
		public List<U8ProductInfo> u8Products; // 0x18
	
		// Constructors
		public U8ProductsResult() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8ServerInfo // TypeDefIndex: 59120
	{
		// Fields
		public string serverId; // 0x10
		public string serverName; // 0x18
		public string serverDomain; // 0x20
		public bool defaultChoose; // 0x28
		public string roleId; // 0x30
		public string nickName; // 0x38
		public long level; // 0x40
		public string extension; // 0x48
	
		// Constructors
		public U8ServerInfo() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8ServerErrorInfo // TypeDefIndex: 59121
	{
		// Fields
		public int status; // 0x10
		public int errorCode; // 0x14
	
		// Constructors
		public U8ServerErrorInfo() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8OrderInfo // TypeDefIndex: 59122
	{
		// Fields
		public string orderId; // 0x10
		public string channelProductCode; // 0x18
		public string productName; // 0x20
		public string productDesc; // 0x28
		public long amount; // 0x30
		public string extension; // 0x38
	
		// Constructors
		public U8OrderInfo() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8PayParams // TypeDefIndex: 59123
	{
		// Fields
		public string productId; // 0x10
		public string productName; // 0x18
		public string productDesc; // 0x20
		public long price; // 0x28
		public int buyNum; // 0x30
		public int coinNum; // 0x34
		public string serverId; // 0x38
		public string serverName; // 0x40
		public string roleId; // 0x48
		public string roleName; // 0x50
		public int roleLevel; // 0x58
		public string vip; // 0x60
		public string orderID; // 0x68
		public string worldID; // 0x70
		public string token; // 0x78
		public string appKey; // 0x80
		public string extension; // 0x88
		public string addition; // 0x90
	
		// Constructors
		public U8PayParams() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8ExtraGameData // TypeDefIndex: 59124
	{
		// Fields
		public int dataType; // 0x10
		public string uid; // 0x18
		public string roleID; // 0x20
		public string roleName; // 0x28
		public string roleLevel; // 0x30
		public int serverID; // 0x38
		public string serverName; // 0x40
		public string channel; // 0x48
		public string subChannel; // 0x50
		public bool isNewUser; // 0x58
		public long revenue; // 0x60
		public string customEventName; // 0x68
		public string customEventParams; // 0x70
	
		// Constructors
		public U8ExtraGameData() {} // 0x0000000185492010-0x0000000185492020
	}

	public struct U8LoginResult // TypeDefIndex: 59125
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
		public override string ToString() => default; // 0x000000018A98B174-0x000000018A98B348
	}

	public struct U8ProductError // TypeDefIndex: 59126
	{
		// Fields
		public int status; // 0x00
		public int errorCode; // 0x04
	}

	public enum PayResultStatus // TypeDefIndex: 59127
	{
		SUCCEED = 0,
		PENDING = 1
	}

	public enum PayFailStatus // TypeDefIndex: 59128
	{
		UNKNOWN = 0,
		CANCELED = 1,
		ERROR = 2,
		HALT = 3
	}

	public class U8ConfirmServerResult // TypeDefIndex: 59129
	{
		// Fields
		public int status; // 0x10
		public string message; // 0x18
	
		// Constructors
		public U8ConfirmServerResult() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum U8ConfirmOrderStatus // TypeDefIndex: 59130
	{
		NONE = 0,
		INTERNAL_ERROR = 1,
		TIMEOUT = 2,
		INVALID_ORDER = 3,
		SUCCEED = 4
	}

	public class U8ConfirmOrderResult // TypeDefIndex: 59131
	{
		// Fields
		public U8ConfirmOrderStatus status; // 0x10
		public string message; // 0x18
	
		// Constructors
		public U8ConfirmOrderResult() {} // 0x0000000185492010-0x0000000185492020
	}

	public struct U8PayFailMsg // TypeDefIndex: 59132
	{
		// Fields
		public static U8PayFailMsg EMPTY; // 0x00
		public PayFailStatus status; // 0x00
		public string message; // 0x08
		public string extension; // 0x10
	
		// Constructors
		static U8PayFailMsg() {
			EMPTY = default;
		} // 0x000000018A98B6BC-0x000000018A98B720
	
		// Methods
		public static U8PayFailMsg FromJson(string jsonStr) => default; // 0x000000018A98B3BC-0x000000018A98B6BC
	}

	public struct U8PayResult // TypeDefIndex: 59133
	{
		// Fields
		public static readonly U8PayResult EMPTY; // 0x00
		public PayResultStatus status; // 0x00
		public string outTradeNo; // 0x08
		public string extension; // 0x10
	
		// Constructors
		static U8PayResult() {
			EMPTY = default;
		} // 0x000000018A98BA8C-0x000000018A98BB00
	
		// Methods
		public static U8PayResult FromJson(string jsonData) => default; // 0x000000018A98B720-0x000000018A98B9A0
		public override string ToString() => default; // 0x000000018A98B9A0-0x000000018A98BA8C
	}

	public class SDKInterfaceCloud : U8SDKInterface // TypeDefIndex: 59148
	{
		// Fields
		private int actionIndex; // 0xD0
		private static Dictionary<int, Action<string>> dictAction; // 0x00
	
		// Nested types
		public delegate void DataCallback(int index, string paramValue); // TypeDefIndex: 59134; 0x00000001839BAB20-0x00000001839BB9D0
	
		public delegate void U8SDKSendMessageCallback(string methodName, string paramValue); // TypeDefIndex: 59135; 0x00000001839B9D90-0x00000001839BAB20
	
		public class LoginResult // TypeDefIndex: 59136
		{
			// Fields
			public LoginResultCode code; // 0x10
			public JToken msg; // 0x18
	
			// Constructors
			public LoginResult() {} // 0x00000001839B2AD0-0x00000001839B3860
		}
	
		public enum LoginResultCode // TypeDefIndex: 59137
		{
			Success = 0,
			Canceled = 1,
			Failed = 2
		}
	
		public class PaymentResult // TypeDefIndex: 59138
		{
			// Fields
			public PaymentResultCode code; // 0x10
			public JToken msg; // 0x18
	
			// Constructors
			public PaymentResult() {} // 0x00000001839DCC70-0x00000001839DCFE0
		}
	
		public enum PaymentResultCode // TypeDefIndex: 59139
		{
			Success = 0,
			Failed = 1
		}
	
		private enum SetDataCode // TypeDefIndex: 59140
		{
			CustomerServiceCenter = 6,
			QueryProductList = 17,
			SplashProtocol = 29,
			CloudShareEvent = 36,
			ShowGameProtocol = 41,
			CustomerUnreadMsgCount = 1003,
			SetU8Token = 2002
		}
	
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 59141
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0() {} // 0x00000001839BE9C0-0x00000001839BEAE0
	
			// Methods
			internal void _LoadExtraConfig_b__0(string data) {} // 0x00000001839BEE10-0x00000001839BEF30
		}
	
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 59142
		{
			// Fields
			public string defaultValue; // 0x10
			public int type; // 0x18
	
			// Constructors
			public __c__DisplayClass44_0() {} // 0x00000001839BEF30-0x00000001839BEF60
	
			// Methods
			internal void _GetData_b__0(string data) {} // 0x00000001839BE970-0x00000001839BE9C0
		}
	
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 59143
		{
			// Fields
			public string json; // 0x10
	
			// Constructors
			public __c__DisplayClass54_0() {} // 0x00000001839BEAE0-0x00000001839BEB70
	
			// Methods
			internal void _LoadSDKMeta_b__0(string data) {} // 0x00000001839BEF60-0x00000001839BF060
		}
	
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 59145
		{
			// Fields
			public SDKInterfaceCloud __4__this; // 0x10
			public string jsonData; // 0x18
	
			// Nested types
			private struct __HandleCloudShareEvent_b__0_d : IAsyncStateMachine // TypeDefIndex: 59144
			{
				// Fields
				public int __1__state; // 0x00
				public AsyncTaskMethodBuilder __t__builder; // 0x08
				public __c__DisplayClass71_0 __4__this; // 0x20
				private TaskAwaiter __u__1; // 0x28
	
				// Methods
				private void MoveNext() {} // 0x00000001839BE940-0x00000001839BE970
				private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x00000001839BEBA0-0x00000001839BECC0
			}
	
			// Constructors
			public __c__DisplayClass71_0() {} // 0x00000001839BE810-0x00000001839BE940
	
			// Methods
			internal System.Threading.Tasks.Task _HandleCloudShareEvent_b__0() => default; // 0x00000001839BEB70-0x00000001839BEBA0
		}
	
		private struct _SaveImageToTargetFolder_d__72 : IAsyncStateMachine // TypeDefIndex: 59146
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public string jsonData; // 0x20
			public SDKInterfaceCloud __4__this; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext() {} // 0x00000001839BECC0-0x00000001839BEE10
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x00000001839C9640-0x00000001839CA470
		}
	
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 59147
		{
			// Fields
			public string methodName; // 0x10
			public string paramValue; // 0x18
	
			// Constructors
			public __c__DisplayClass74_0() {} // 0x00000001839DCFE0-0x00000001839DDE80
	
			// Methods
			internal void _SendMessageInMain_b__0() {} // 0x00000001839CCD50-0x00000001839CE040
		}
	
		// Constructors
		public SDKInterfaceCloud() {} // 0x00000001839CB420-0x00000001839CCD40
		static SDKInterfaceCloud() {} // 0x00000001839EC520-0x00000001839EC880
	
		// Methods
		~SDKInterfaceCloud() {} // 0x00000001839CE040-0x00000001839CEBB0
		public int AddAction(Action<string> action) => default; // 0x00000001839CCD40-0x00000001839CCD50
		public static void DataActionCallback(int index, string paramValue) {} // 0x00000001839DBE60-0x00000001839DCC70
		public static void ASyncDataActionCallback(int index, string paramValue) {} // 0x00000001839D5720-0x00000001839D6A40
		public static void U8SDKSendMessage(string methodName, string paramValue) {} // 0x00000001839BB9D0-0x00000001839BC810
		public static extern void HGU8SDKInitLibrary(string windowText, long windowHandle); // 0x00000001839D8EA0-0x00000001839DA030
		public static extern int HGU8SDKSetUserDataPath(string path); // 0x00000001839D6F10-0x00000001839D8EA0
		public static extern void HGU8SDKUnInitLibrary(); // 0x00000001839D1F70-0x00000001839D3120
		public static extern void HGU8SDKInitDatacallback(DataCallback Callback, DataCallback asyncCallback); // 0x00000001839D0650-0x00000001839D1F70
		public static extern void HGU8SDKInitSendMessage(U8SDKSendMessageCallback callback); // 0x00000001839CA470-0x00000001839CB420
		public static extern void HGU8SDKV2Init(string env); // 0x00000001840A27C0-0x00000001840A27D0
		public static extern void HGU8SDKGetSDKMeta(int index); // 0x00000001839D6A40-0x00000001839D6F10
		public static extern void HGU8SDKSetData(int code, string paramJson); // 0x00000001839C8AD0-0x00000001839C9640
		public static extern void HGU8SDKGetData(int code, string paramJson, int index); // 0x00000001839C6260-0x00000001839C75D0
		public static extern void HGU8SDKLoadExtraConfig(int index); // 0x00000001839C75D0-0x00000001839C8AD0
		public static extern void HGU8SDKSetGameVersion(string version); // 0x00000001839DA030-0x00000001839DBE60
		protected override string LoadExtraConfig() => default; // 0x00000001839C41C0-0x00000001839C6260
		protected override void V2Init(string env) {} // 0x00000001839C17C0-0x00000001839C2CC0
		protected override void Login() {} // 0x00000001839B5FF0-0x00000001839B7E20
		private void LoginCallback(CloudCallResult result) {} // 0x00000001839C2CC0-0x00000001839C41C0
		protected override bool Logout() => default; // 0x00000001839B7E20-0x00000001839B9D90
		protected override void LoginCustom(string customData) {} // 0x00000001839BF060-0x00000001839C17C0
		public override void SubmitGameData(U8ExtraGameData data) {} // 0x00000001839D4140-0x00000001839D4840
		public override void SetData(int type, string paramJson) {} // 0x00000001839B4080-0x00000001839B5FF0
		public override string GetData(int type, string paramJson) => default; // 0x00000001839D4840-0x00000001839D5720
		public override bool ShowAccountCenter() => default; // 0x00000001839CEBB0-0x00000001839D0650
		private void ShowAccountCenterCallback(CloudCallResult result) {} // 0x00000001839D3120-0x00000001839D4140
		protected override void Pay(U8PayParams data) {} // 0x00000001839BC810-0x00000001839BE810
		private void PayCallback(CloudCallResult result) {} // 0x00000001839DDE80-0x00000001839DE740
		protected override SDKMeta LoadSDKMeta() => default; // 0x00000001839B0780-0x00000001839B08B0
		protected override bool IsNativePlugin() => default; // 0x00000001831C5680-0x00000001831C5690
		public override void SetGameVersion(string version) {} // 0x000000018376DAC0-0x000000018376DC00
		private void HandleSplashProtocol(string paramJson) {} // 0x00000001831C5680-0x00000001831C5690
		private void HandleSetU8Token(string paramJson) {} // 0x0000000185492010-0x0000000185492020
		private void HandleShowGameProtocol(string paramJson) {} // 0x0000000185492010-0x0000000185492020
		private void ShowGameProtocolCallback(CloudCallResult result) {} // 0x0000000185492010-0x0000000185492020
		private void HandleQueryProductList(string paramJson) {} // 0x0000000182F85E60-0x0000000182F85EC0
		private void HandleCustomerServiceCenter(string paramJson) {} // 0x0000000185492010-0x0000000185492020
		private void CustomerServiceCenterCallback(CloudCallResult result) {} // 0x00000001839EBAD0-0x00000001839EBE80
		private void HandleCustomerUnreadMsgCount(string paramJson) {} // 0x0000000185492010-0x0000000185492020
		private void CustomerUnreadMsgCountCallback(CloudCallResult result) {} // 0x0000000182F85E60-0x0000000182F85EC0
		private void HandleCloudShareEvent(string paramJson, string fileNamePrefix = null) {} // 0x0000000185492010-0x0000000185492020
		private System.Threading.Tasks.Task SaveImageToTargetFolder(string jsonData) => default; // 0x00000001839EBE80-0x00000001839EC520
		private void CloudShareEventCallback(CloudCallResult result) {} // 0x00000001839E9340-0x00000001839EA3C0
		private void SendMessageInMain(string methodName, string paramValue) {} // 0x00000001839EA3C0-0x00000001839EA6E0
		private static void OnPipelineConnected(CloudCallResult result) {} // 0x00000001839E7160-0x00000001839E9020
		private static void RequestLaunchInfoCallback(CloudCallResult result) {} // 0x00000001839E9020-0x00000001839E9340
		private static void GetThinClientDeviceInfo(string jsonData) {} // 0x0000000185492010-0x0000000185492020
	}

	public class SDKInterfaceWIN : U8SDKInterface // TypeDefIndex: 59155
	{
		// Fields
		private int actionIndex; // 0xD0
		private static Dictionary<int, Action<string>> dictAction; // 0x00
	
		// Nested types
		public delegate void DataCallback(int index, string paramValue); // TypeDefIndex: 59149; 0x000000018A9871D4-0x000000018A9872A0
	
		public delegate void U8SDKSendMessageCallback(string methodName, string paramValue); // TypeDefIndex: 59150; 0x0000000184EE7DA0-0x0000000184EE8050
	
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 59151
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0() {} // 0x000000018A986FE8-0x000000018A9871D4
	
			// Methods
			internal void _LoadExtraConfig_b__0(string data) {} // 0x0000000184EE8120-0x0000000184EE81A0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 59152
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<System.Threading.Tasks.Task> __9__42_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018476C4D0-0x000000018476C6A0
			public __c() {} // 0x000000018476C6A0-0x000000018476C700
	
			// Methods
			internal void _SetData_b__42_0(System.Threading.Tasks.Task task) {} // 0x000000018A987514-0x000000018A987538
		}
	
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 59153
		{
			// Fields
			public string defaultValue; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0() {} // 0x00000001844CE310-0x00000001844CE360
	
			// Methods
			internal void _GetData_b__0(string data) {} // 0x00000001844CE070-0x00000001844CE100
		}
	
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 59154
		{
			// Fields
			public string json; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0() {} // 0x0000000185A61AF0-0x0000000185A61B40
	
			// Methods
			internal void _LoadSDKMeta_b__0(string data) {} // 0x000000018A987354-0x000000018A9873BC
		}
	
		// Constructors
		public SDKInterfaceWIN() {} // 0x000000018A9872CC-0x000000018A987354
		static SDKInterfaceWIN() {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		~SDKInterfaceWIN() {} // 0x000000018A9873BC-0x000000018A987424
		public int AddAction(Action<string> action) => default; // 0x000000018A9874AC-0x000000018A987514
		public static void DataActionCallback(int index, string paramValue) {} // 0x000000018A987424-0x000000018A9874AC
		public static void ASyncDataActionCallback(int index, string paramValue) {} // 0x00000001856F8EB0-0x00000001856F8F10
		public static void U8SDKSendMessage(string methodName, string paramValue) {} // 0x000000018A9872A0-0x000000018A9872CC
		public static extern void HGU8SDKInitLibrary(string windowText, long windowHandle); // 0x0000000184D18F00-0x0000000184D18F60
		public static extern int HGU8SDKSetUserDataPath(string path); // 0x0000000184B941C0-0x0000000184B94230
		public static extern void HGU8SDKUnInitLibrary(); // 0x00000001844CE100-0x00000001844CE170
		public static extern void HGU8SDKInitDatacallback(DataCallback Callback, DataCallback asyncCallback); // 0x0000000184B94230-0x0000000184B94260
		public static extern void HGU8SDKInitSendMessage(U8SDKSendMessageCallback callback); // 0x0000000185EE0340-0x0000000185EE03A0
		public static extern void HGU8SDKV2Init(string env); // 0x0000000184B93AA0-0x0000000184B93BC0
		public static extern void HGU8SDKLogin(); // 0x0000000185A61980-0x0000000185A61A10
		public static extern void HGU8SDKLoginCustom(string json); // 0x000000018A9876B4-0x000000018A9876F4
		public static extern int HGU8SDKLogout(); // 0x000000018A9876F4-0x000000018A98773C
		public static extern int HGU8SDKShowAccountCenter(); // 0x000000018A987668-0x000000018A9876B4
		public static extern void HGU8SDKPay(string json); // 0x00000001856F8F10-0x00000001856F8F80
		public static extern void HGU8SDKSubmitGameData(string json); // 0x0000000184D18E50-0x0000000184D18F00
		public static extern void HGU8SDKGetSDKMeta(int index); // 0x0000000184B93E70-0x0000000184B93FB0
		public static extern void HGU8SDKSetData(int code, string paramJson); // 0x000000018A98779C-0x000000018A9877E4
		public static extern void HGU8SDKGetData(int code, string paramJson, int index); // 0x000000018A98773C-0x000000018A98779C
		public static extern int HGU8SDKIsNativePlugin(); // 0x000000018A987538-0x000000018A987668
		public static extern void HGU8SDKLoadExtraConfig(int index); // 0x0000000185F89A70-0x0000000185F89AC0
		public static extern void HGU8SDKSetGameVersion(string version); // 0x0000000185EE02F0-0x0000000185EE0340
		protected override string LoadExtraConfig() => default; // 0x0000000185F3ECB0-0x0000000185F3ED40
		protected override void V2Init(string env) {} // 0x000000018476D7A0-0x000000018476D830
		protected override void Login() {} // 0x00000001831C5680-0x00000001831C5690
		protected override bool Logout() => default; // 0x0000000185573210-0x00000001855732A0
		protected override void LoginCustom(string customData) {} // 0x00000001831C5680-0x00000001831C5690
		public override void SubmitGameData(U8ExtraGameData data) {} // 0x0000000185492010-0x0000000185492020
		public override void SetData(int type, string paramJson) {} // 0x0000000184096E30-0x0000000184096EF0
		public override string GetData(int type, string paramJson) => default; // 0x000000018A98AA6C-0x000000018A98AAD0
		public override bool ShowAccountCenter() => default; // 0x0000000185492010-0x0000000185492020
		protected override void Pay(U8PayParams data) {} // 0x000000018A98948C-0x000000018A989564
		protected override SDKMeta LoadSDKMeta() => default; // 0x0000000185492010-0x0000000185492020
		protected override bool IsNativePlugin() => default; // 0x0000000184096E30-0x0000000184096EF0
		public override void SetGameVersion(string version) {} // 0x0000000185492010-0x0000000185492020
	}

	public class SDKMeta // TypeDefIndex: 59156
	{
		// Fields
		public string appID; // 0x10
		public string appKey; // 0x18
		public string channel; // 0x20
		public string worldId; // 0x28
		public string extension; // 0x30
		public string appCode; // 0x38
	
		// Constructors
		public SDKMeta() {} // 0x0000000185492010-0x0000000185492020
		public SDKMeta(string jsonData) {} // 0x000000018A987948-0x000000018A987C74
	
		// Methods
		public override string ToString() => default; // 0x000000018A9877E4-0x000000018A987948
	}

	public interface ISDKPromise // TypeDefIndex: 59157
	{
		// Methods
		void Fulfill(object param);
		void Reject(object reason);
	}

	public class SDKPromise<Param> : ISDKPromise // TypeDefIndex: 59158
	{
		// Fields
		public Action<Param> onFulfilled;
		public Action<object> onRejected;
	
		// Constructors
		public SDKPromise() {}
	
		// Methods
		public virtual void Fulfill(object param) {}
		public virtual void Reject(object reason) {}
	}

	public class SDKPromiseWithResult<Param> : SDKPromise<Param> // TypeDefIndex: 59159
		where Param : class
	{
		// Fields
		private Param _result_k__BackingField;
		private object _rejectInfo_k__BackingField;
	
		// Properties
		public Param result { get; private set; }
		public object rejectInfo { get; private set; }
	
		// Constructors
		public SDKPromiseWithResult() {}
	
		// Methods
		public override void Fulfill(object param) {}
		public override void Reject(object reason) {}
	}

	public class SDKPromiseEnumerator<T> // TypeDefIndex: 59162
	{
		// Fields
		private State m_state;
		private T _result_k__BackingField;
		private object _reject_k__BackingField;
	
		// Properties
		public bool isFulfilled { get => default; }
		public T result { get; private set; }
		public object reject { get; private set; }
	
		// Nested types
		private enum State // TypeDefIndex: 59160
		{
			NONE = 0,
			FULFILL = 1,
			REJECT = 2
		}
	
		private sealed class _Yield_d__12 : IEnumerator<object> // TypeDefIndex: 59161
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SDKPromiseEnumerator<T> __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _Yield_d__12() {} // Dummy constructor
			public _Yield_d__12(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public SDKPromiseEnumerator() {} // Dummy constructor
		public SDKPromiseEnumerator(SDKPromise<T> promise) {}
	
		// Methods
		public IEnumerator Yield() => default;
		private void _OnFulfilled(T result) {}
		private void _OnRejected(object rejectInfo) {}
	}

	public class SDKPromiseWrapper // TypeDefIndex: 59163
	{
		// Fields
		private ISDKPromise m_promise; // 0x10
	
		// Constructors
		public SDKPromiseWrapper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public T EnsurePromise<T>()
			where T : ISDKPromise, new() => default;
		public void Fulfill(object param) {} // 0x0000000185BA7BE0-0x0000000185BA7CA0
		public void Reject(object reason) {} // 0x000000018A987C8C-0x000000018A987CBC
		private void _Clear() {} // 0x0000000185633D30-0x0000000185633D50
	}

	public static class SDKPromiseExtensions // TypeDefIndex: 59164
	{
		// Methods
		public static void RejectWithString(ISDKPromise promise, string errorInfo) {} // 0x000000018A987C74-0x000000018A987C8C
		public static void FulfillWithType<T>(SDKPromise<T> promise, T param)
			where T : class {}
	}

	public class U8SDKTickEvent : MonoBehaviour // TypeDefIndex: 59165
	{
		// Constructors
		public U8SDKTickEvent() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Update() {} // 0x000000018512D960-0x000000018512D970
		public static extern void HGU8SDKTickEvent(); // 0x000000018512D970-0x000000018512D9A0
	}

	public class U8TickEventManager // TypeDefIndex: 59166
	{
		// Fields
		private GameObject tickGameObject; // 0x10
		private U8SDKTickEvent tickEvent; // 0x18
		private static U8TickEventManager instanceManager; // 0x00
		private static readonly object lockObject; // 0x08
	
		// Properties
		public static U8TickEventManager InstanceManager { get => default; } // 0x0000000185A61A10-0x0000000185A61AF0 
	
		// Constructors
		public U8TickEventManager() {} // 0x0000000185492010-0x0000000185492020
		static U8TickEventManager() {} // 0x0000000185F59EE0-0x0000000185F59F50
	
		// Methods
		public void InitTickEvent() {} // 0x0000000185A61B40-0x0000000185A62090
		public void UnInitTickEvent() {} // 0x000000018A98D9F4-0x000000018A98DBBC
	}

	public class U8LoginV2Result // TypeDefIndex: 59167
	{
		// Fields
		public string token; // 0x10
		public string uid; // 0x18
		public bool isNew; // 0x20
	
		// Constructors
		public U8LoginV2Result() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8AuthV2Result // TypeDefIndex: 59168
	{
		// Fields
		public string uid; // 0x10
		public string oauth2Code; // 0x18
		public string oauth2Token; // 0x20
	
		// Constructors
		public U8AuthV2Result() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8GrantResult // TypeDefIndex: 59169
	{
		// Fields
		public string uid; // 0x10
		public string code; // 0x18
		public string token; // 0x20
	
		// Constructors
		public U8GrantResult() {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8SDKCallback : MonoBehaviour // TypeDefIndex: 59171
	{
		// Fields
		private static U8SDKCallback m_instance; // 0x00
		private static object m_lock; // 0x08
	
		// Nested types
		private sealed class __onLogoutNextFrameCoroutine_d__13 : IEnumerator<object> // TypeDefIndex: 59170
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185BA7B60-0x0000000185BA7BC0 
			object IEnumerator.Current { get => default; } // 0x000000018A98C020-0x000000018A98C06C 
	
			// Constructors
			public __onLogoutNextFrameCoroutine_d__13() {} // Dummy constructor
			public __onLogoutNextFrameCoroutine_d__13(int __1__state) {} // 0x0000000184EE8290-0x0000000184EE89A0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185BA7AE0-0x0000000185BA7B40
			private bool MoveNext() => default; // 0x000000018A98BF70-0x000000018A98BFC8
			void IEnumerator.Reset() {} // 0x000000018A98BFC8-0x000000018A98C020
		}
	
		// Constructors
		public U8SDKCallback() {} // 0x000000018A98B128-0x000000018A98B174
		static U8SDKCallback() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static U8SDKCallback InitCallback() => default; // 0x000000018A98C18C-0x000000018A98C1D8
		public void OnInitSuc(string extConfigs) {} // 0x000000018A98C0C4-0x000000018A98C11C
		public void OnInitFail(string info) {} // 0x000000018A98C06C-0x000000018A98C0C4
		public void OnLoginSuc(string extension) {} // 0x000000018A98C11C-0x000000018A98C18C
		public void OnLoginFail(string info) {} // 0x000000018458D7F0-0x000000018458D960
		public void OnLogout(string info) {} // 0x000000018A98C1D8-0x000000018A98C21C
		public void OnSwitchAccount() {}
		public void OnPaySuc(string jsonData) {} // 0x000000018646DB20-0x000000018646DB28
		public void OnPayFail(string failMsg) {} // 0x0000000185F59F50-0x0000000185F59FC0
		public void OnSDKError(string jsonData) {} // 0x0000000181378230-0x0000000181378240
		public void OnExtraInfo(string jsonData) {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator _onLogoutNextFrameCoroutine() => default; // 0x000000018A98AF1C-0x000000018A98B128
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public static class OneChannelSDKVersion // TypeDefIndex: 59172
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static OneChannelSDKVersion() {} // 0x00000001839B18B0-0x00000001839B1EC0
	}

	public enum GameType // TypeDefIndex: 59173
	{
		Local = 0,
		Cloud = 1
	}

	public class CloudGameUtil // TypeDefIndex: 59174
	{
		// Fields
		private static int m_thinClientPlatform; // 0x00
		private static string m_thinClientDeviceProperties; // 0x08
	
		// Properties
		public static int ThinClientPlatform { get => default; set {} } // 0x00000001839AFDE0-0x00000001839B00F0 0x00000001839B0470-0x00000001839B0780
		public static string ThinClientDeviceProperties { get => default; set {} } // 0x00000001839AFAD0-0x00000001839AFDE0 0x00000001839B00F0-0x00000001839B0470
	
		// Constructors
		public CloudGameUtil() {} // Dummy constructor
		static CloudGameUtil() {} // 0x00000001839AF760-0x00000001839AFAD0
	
		// Methods
		public static bool IsCloudGame() => default; // 0x00000001839AE4A0-0x00000001839AF760
	}

	public class ImageSaver // TypeDefIndex: 59184
	{
		// Nested types
		private enum FolderType // TypeDefIndex: 59175
		{
			UserPicturesFolder = 0,
			GameInstalledFolder = 1
		}
	
		private enum ErrorCode // TypeDefIndex: 59176
		{
			UnknowError = -1,
			NotInited = 0,
			ParamsError = 1,
			ImageNotFound = 3,
			ShareChannelError = 6,
			SaveFailed = 8
		}
	
		private enum CallbackResult : byte // TypeDefIndex: 59177
		{
			Success = 0,
			Cancelled = 1,
			Failed = 2
		}
	
		public class ImageShareInfo // TypeDefIndex: 59178
		{
			// Fields
			public int shareChannel; // 0x10
			public string extraData; // 0x18
			public string imgPath; // 0x20
			public string relativePath; // 0x28
			public int folderType; // 0x30
			public string title; // 0x38
			public string desc; // 0x40
	
			// Constructors
			public ImageShareInfo() {} // 0x000000018A983C08-0x000000018A983CD8
		}
	
		private struct _SaveImage_d__5 : IAsyncStateMachine // TypeDefIndex: 59179
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public ImageSaver __4__this; // 0x20
			public string paramJson; // 0x28
			private string _targetPath_5__2; // 0x30
			private TaskAwaiter<bool> __u__1; // 0x38
	
			// Methods
			private void MoveNext() {} // 0x00000001839B08B0-0x00000001839B18B0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018A9843F0-0x000000018A9845BC
		}
	
		private struct _SaveCloudGameImage_d__6 : IAsyncStateMachine // TypeDefIndex: 59180
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<bool> __t__builder; // 0x08
			public ImageSaver __4__this; // 0x20
			public string paramJson; // 0x28
			private TaskAwaiter<bool> __u__1; // 0x30
	
			// Methods
			private void MoveNext() {} // 0x000000018A9838B8-0x000000018A983A2C
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018A983A2C-0x000000018A983AE8
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 59181
		{
			// Fields
			public ImageSaver __4__this; // 0x10
			public string sourcePath; // 0x18
			public string targetPath; // 0x20
			public string imgFolder; // 0x28
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x000000018A982F84-0x000000018A9830B0
	
			// Methods
			internal bool _SaveImageToPathAsync_b__0() => default; // 0x000000018A9834D8-0x000000018A98358C
		}
	
		private struct _SaveImageToPathAsync_d__13 : IAsyncStateMachine // TypeDefIndex: 59182
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
			private void MoveNext() {} // 0x000000018A982E58-0x000000018A982F84
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018A983AE8-0x000000018A983C08
		}
	
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 59183
		{
			// Fields
			public string methodName; // 0x10
			public string paramValue; // 0x18
	
			// Constructors
			public __c__DisplayClass24_0() {} // 0x000000018A98358C-0x000000018A983660
	
			// Methods
			internal void _SendMessageInMain_b__0() {} // 0x000000018A9845BC-0x000000018A984794
		}
	
		// Constructors
		public ImageSaver() {} // 0x00000001839EB770-0x00000001839EBAD0
	
		// Methods
		public System.Threading.Tasks.Task SaveImage(string paramJson) => default; // 0x000000018A9830B0-0x000000018A983118
		public Task<bool> SaveCloudGameImage(string paramJson) => default; // 0x000000018A983660-0x000000018A9838B8
		private bool ValidateInput(string paramJson, out ImageShareInfo shareInfo) {
			shareInfo = default;
			return default;
		} // 0x000000018A9832C4-0x000000018A983378
		private string NormalizeSourcePath(string imgPath) => default; // 0x000000018A983378-0x000000018A9834D8
		private FolderType ParseFolderType(int folderType) => default; // 0x000000018A983118-0x000000018A9832C4
		private string BuildTargetPath(string sourcePath, string relativePath, string baseFolder) => default; // 0x000000018A9842FC-0x000000018A9843F0
		private bool IsDirectoryPath(string path) => default; // 0x000000018A983CD8-0x000000018A983DB0
		private string BuildPathForDirectory(string sourcePath, string relativeDirPath, string baseFolder) => default; // 0x000000018A983E88-0x000000018A9842FC
		private Task<bool> SaveImageToPathAsync(string sourcePath, string targetPath, string imgFolder) => default; // 0x000000018A983DB0-0x000000018A983E88
		private bool IsSamePath(string sourcePath, string targetPath) => default; // 0x0000000185492010-0x0000000185492020
		private bool ValidateMove(string sourcePath, string targetPath, string rootDir, out string error) {
			error = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		private void EnsureDirectoryExists(string filePath) {} // 0x000000018A988EA4-0x000000018A9892C4
		private bool MoveFile(string sourcePath, string targetPath) => default; // 0x000000018A9892C4-0x000000018A989320
		private string GetImageSaveFolder(FolderType folderType) => default; // 0x00000001839E24B0-0x00000001839E3EF0
		private string GetWindowsPicturePath() => default; // 0x00000001839E3EF0-0x00000001839E45C0
		private string GetGameInstalledFolder() => default; // 0x0000000185492010-0x0000000185492020
		private void SendSuccessResponse(string targetPath) {} // 0x00000001839EA6E0-0x00000001839EB770
		private void SendErrorResponse(ErrorCode errorCode) {} // 0x00000001839E45C0-0x00000001839E6A90
		private void SendResponse(CallbackResult code, Dictionary<string, object> extraMsg = null) {} // 0x00000001839E6A90-0x00000001839E7160
		private void SendMessageInMain(string methodName, string paramValue) {} // 0x0000000185492010-0x0000000185492020
	}

	public class U8MainThreadDispatcher : MonoBehaviour // TypeDefIndex: 59185
	{
		// Fields
		private static readonly ConcurrentQueue<Action> _queue; // 0x00
		private static U8MainThreadDispatcher _instance; // 0x08
		private static int _initialized; // 0x10
	
		// Constructors
		public U8MainThreadDispatcher() {} // 0x000000018646DB20-0x000000018646DB28
		static U8MainThreadDispatcher() {} // 0x0000000185C1FAD0-0x0000000185C1FB80
	
		// Methods
		private static void Initialize() {} // 0x0000000185D6BC50-0x0000000185D6BE00
		public static void RunOnMainThread(Action action) {} // 0x000000018A98B348-0x000000018A98B3BC
		private void Update() {} // 0x0000000183F9E3A0-0x0000000183F9E4E0
	}
}

namespace U8.SDK.MiniJSON
{
	public static class Json // TypeDefIndex: 59189
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 59187
		{
			// Fields
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get => default; } // 0x000000018458E8D0-0x000000018458E980 
			private char NextChar { get => default; } // 0x000000018458E360-0x000000018458E3F0 
			private string NextWord { get => default; } // 0x000000018458E5B0-0x000000018458E620 
			private TOKEN NextToken { get => default; } // 0x000000018458E790-0x000000018458E800 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 59186
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
			public Parser() {} // Dummy constructor
			private Parser(string jsonString) {} // 0x000000018647434C-0x0000000186474354
	
			// Methods
			public static bool IsWordBreak(char c) => default; // 0x000000018458DF30-0x000000018458DF50
			public static object Parse(string jsonString) => default; // 0x000000018458E840-0x000000018458E8D0
			public void Dispose() {} // 0x000000018458EE20-0x000000018458EEA0
			private Dictionary<string, object> ParseObject() => default; // 0x000000018458DF50-0x000000018458E050
			private List<object> ParseArray() => default; // 0x0000000185993C70-0x0000000185993CB0
			private object ParseValue() => default; // 0x000000018458E230-0x000000018458E360
			private object ParseByToken(TOKEN token) => default; // 0x000000018A984938-0x000000018A984A5C
			private string ParseString() => default; // 0x000000018458E050-0x000000018458E080
			private object ParseNumber() => default; // 0x000000018458E080-0x000000018458E170
			private void EatWhitespace() {} // 0x000000018458E620-0x000000018458E790
		}
	
		private sealed class Serializer // TypeDefIndex: 59188
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer() {} // 0x000000018458E170-0x000000018458E230
	
			// Methods
			public static string Serialize(object obj) => default; // 0x000000018458E3F0-0x000000018458E5B0
			private void SerializeValue(object value) {} // 0x00000001851676D0-0x0000000185167740
			private void SerializeObject(IDictionary obj) {} // 0x0000000185167650-0x00000001851676D0
			private void SerializeArray(IList anArray) {} // 0x00000001851678E0-0x0000000185167AA0
			private void SerializeString(string str) {} // 0x0000000185167CE0-0x000000018516F330
			private void SerializeOther(object value) {} // 0x000000018A987CBC-0x000000018A988134
		}
	
		// Methods
		public static object Deserialize(string json) => default; // 0x0000000185167AA0-0x0000000185167C50
		public static string Serialize(object obj) => default; // 0x0000000185167740-0x00000001851678A0
	}
}
