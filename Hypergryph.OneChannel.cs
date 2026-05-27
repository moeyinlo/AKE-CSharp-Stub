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
using UnityEngine;

// Image 67: Hypergryph.OneChannel.dll - Assembly: Hypergryph.OneChannel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58441-58563
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.PlatformFacade
{
	public class PlatformFacade // TypeDefIndex: 58559
	{
		// Constructors
		public PlatformFacade() {} // Dummy constructor
	
		// Methods
		public static void SetupPlatformFont(IPlatformFont iFont) {} // 0x000000018350B670-0x000000018350B680
	}

	public interface IPlatformFont // TypeDefIndex: 58560
	{
	}
}

namespace U8.SDK
{
	public struct ExternalPluginLoginParams // TypeDefIndex: 58442
	{
		// Fields
		public Action nativeLogin; // 0x00
		public Action<string> nativeLoginCustom; // 0x08
		public Action<string> nativeOnLoginSuc; // 0x10
		public Action<string> nativeOnLoginFail; // 0x18
		public Action<U8MockLogin> markMockLogin; // 0x20
	}

	public struct ExternalPluginLogoutParams // TypeDefIndex: 58443
	{
		// Fields
		public Action nativeLogout; // 0x00
		public Action nativeOnLogoutSuc; // 0x08
		public Action nativeOnLogoutFail; // 0x10
	}

	public struct ExternalPluginPayParams // TypeDefIndex: 58444
	{
		// Fields
		public U8PayParams payParams; // 0x00
		public Func<U8PayParams, SDKPromise<U8PayResult>> nativePay; // 0x08
		public Action<U8PayResult> onPaySuc; // 0x10
		public Action<object> onPayFail; // 0x18
	}

	public interface IExternalPlugin // TypeDefIndex: 58445
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

	public abstract class SDKCaptchaHandler // TypeDefIndex: 58448
	{
		// Nested types
		public enum Status // TypeDefIndex: 58446
		{
			SUC = 0,
			SYS_BUSY = 1,
			USER_CANCEL = 2,
			NOT_SUPPORT = 50,
			INVALID_PARAM = 51,
			UNKNOWN = 99
		}
	
		public class Result // TypeDefIndex: 58447
		{
			// Properties
			public Status status { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
			private int errorCode { get; set; } // 0x0000000183D595B0-0x0000000183D595C0
			public string captcha { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
			// Constructors
			private Result() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public static Result CreateForOutput() => default; // 0x0000000188870FBC-0x0000000188871000
			public void MarkSucceed(string captcha) {} // 0x0000000188871054-0x0000000188871074
			public void MarkFailed(Status status, int errorCode) {} // 0x0000000188871028-0x0000000188871054
			public void MarkFailed(Status status) {} // 0x0000000188871000-0x0000000188871028
		}
	
		// Constructors
		protected SDKCaptchaHandler() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract IEnumerator FetchCaptchaCoroutine(string captchaParams, Result outResult);
	}

	public abstract class SDKExternalTools // TypeDefIndex: 58481
	{
		// Fields
		private static readonly char[] RANDOM_CHAR_MAP; // 0x00
		protected static readonly int[] PAY_CONFIRM_RETRY_INTERVALS; // 0x08
		private static SDKExternalTools s_instance; // 0x10
		private static IExternalPlugin s_plugin; // 0x18
		private static int U8_SDK_SET_DATA_SET_SERVER; // 0x20
	
		// Properties
		protected bool inited { get; private set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		protected IExternalPlugin plugin { get; } // 0x0000000188873468-0x00000001888734B8 
		protected CaptchaMgr captchaMgr { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		protected string subChannel { get; set; } // 0x0000000184271930-0x0000000184271940
	
		// Nested types
		protected interface IFromJSON // TypeDefIndex: 58449
		{
			// Methods
			bool LoadFromJSON(string json);
		}
	
		protected enum POSTStatus // TypeDefIndex: 58450
		{
			NONE = 0,
			SUC = 1,
			TIMEOUT = 2,
			ERROR = 3
		}
	
		protected enum BusType // TypeDefIndex: 58451
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
	
		protected enum ErrorType // TypeDefIndex: 58452
		{
			NONE = 0,
			TIMEOUT = 1,
			NETWORK_ERROR = 2,
			DESERIALIZE_FAILED = 3,
			BUSINESS_ERROR = 4
		}
	
		protected struct POSTRequest // TypeDefIndex: 58453
		{
			// Fields
			public string url; // 0x00
			public string body; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> nullableHeaders; // 0x18
		}
	
		protected struct POSTResult // TypeDefIndex: 58454
		{
			// Fields
			public POSTStatus status; // 0x00
			public int httpCode; // 0x04
			public string response; // 0x08
			public string error; // 0x10
	
			// Methods
			public bool ServiceFailed() => default; // 0x0000000188870E90-0x0000000188870E98
		}
	
		protected struct ErrMsgMeta // TypeDefIndex: 58455
		{
			// Fields
			public static readonly ErrMsgMeta EMPTY; // 0x00
			public BusType busType; // 0x00
			public ErrorType errorType; // 0x04
			public int errorCode; // 0x08
			public string alertFromServer; // 0x10
			public object meta; // 0x18
	
			// Methods
			public bool IsEmpty() => default; // 0x00000001822FBAA0-0x00000001822FBAB0
			public static ErrMsgMeta FromPOSTResult(BusType busType, POSTResult postRet) => default; // 0x000000018886F124-0x000000018886F164
		}
	
		protected class CaptchaMgr // TypeDefIndex: 58457
		{
			// Fields
			private SDKExternalTools m_host; // 0x10
	
			// Properties
			public SDKCaptchaHandler activeHandler { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
			// Constructors
			public CaptchaMgr() {} // Dummy constructor
			public CaptchaMgr(SDKExternalTools host) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			[IteratorStateMachine(typeof(_FetchCaptchaCoroutine_d__6))]
			public IEnumerator FetchCaptchaCoroutine(Dictionary<string, object> captchaParams, SDKCaptchaHandler.Result outResult) => default; // 0x000000018886EB7C-0x000000018886EC08
		}
	
		protected class POSTProcedure // TypeDefIndex: 58460
		{
			// Properties
			protected Builder builder { get; private set; } // 0x00000001820B6ED0-0x00000001820B6EF0 0x0000000188861778-0x000000018886179C
			public bool isServiceFinished { get; private set; } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
			public ErrMsgMeta serviceError { get; protected set; } // 0x0000000183D6DAD0-0x0000000183D6DAF0 0x0000000188870E78-0x0000000188870E90
			private string rawResponse { get; set; } // 0x00000001839274B0-0x00000001839274C0
	
			// Nested types
			public struct Builder // TypeDefIndex: 58458
			{
				// Fields
				public POSTRequest request; // 0x00
				public BusType busType; // 0x20
	
				// Methods
				public POSTProcedure Build() => default; // 0x000000018886EB08-0x000000018886EB7C
				public POSTProcedure<TResp> TypedBuild<TResp>()
					where TResp : class, IFromJSON, new() => default;
			}
	
			// Constructors
			public POSTProcedure() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public ErrMsgMeta MakeBusinessError(int errorCode) => default; // 0x0000000183D6DA90-0x0000000183D6DAD0
			[IteratorStateMachine(typeof(_POST_d__18))]
			public IEnumerator POST(SDKExternalTools host) => default; // 0x0000000188870CF4-0x0000000188870D68
			private void _OnServiceFinished(POSTResult postRet) {} // 0x0000000188870D68-0x0000000188870E78
			protected virtual void HandleServiceResponse(POSTResult postRet) {} // 0x000000018350B670-0x000000018350B680
		}
	
		protected class POSTProcedure<TResp> : POSTProcedure // TypeDefIndex: 58461
			where TResp : class, IFromJSON, new()
		{
			// Properties
			public TResp response { get; private set; }
	
			// Constructors
			public POSTProcedure() {}
	
			// Methods
			protected override void HandleServiceResponse(POSTResult postRet) {}
		}
	
		protected class AuthV2SessionTokenResp : IFromJSON // TypeDefIndex: 58462
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public string token; // 0x28
			public string uid; // 0x30
			public bool isNew; // 0x38
	
			// Constructors
			public AuthV2SessionTokenResp() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018886E914-0x000000018886EB08
		}
	
		public class GetProductLsitResp : IFromJSON // TypeDefIndex: 58463
		{
			// Fields
			public int flag; // 0x10
			public Dictionary<string, object> desc; // 0x18
	
			// Constructors
			public GetProductLsitResp() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool LoadFromDictionary(Dictionary<string, object> dict) => default; // 0x000000018886F164-0x000000018886F3C8
			public bool LoadFromJSON(string json) => default; // 0x000000018886F3C8-0x000000018886F4A8
		}
	
		protected class AuthV2GrantResp : IFromJSON // TypeDefIndex: 58464
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
			public AuthV2GrantResp() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018886E648-0x000000018886E914
		}
	
		protected class ServerListResp : IFromJSON // TypeDefIndex: 58466
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public List<ServerData> data; // 0x20
	
			// Nested types
			public struct ServerData // TypeDefIndex: 58465
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
			public ServerListResp() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x0000000188874694-0x0000000188874B8C
			public List<U8ServerInfo> ToServerInfo() => default; // 0x0000000188874B8C-0x0000000188874E04
		}
	
		protected class ConfirmServerResp : IFromJSON // TypeDefIndex: 58467
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
	
			// Constructors
			public ConfirmServerResp() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018886ECA4-0x000000018886ED80
		}
	
		protected class ConfirmOrderU1Resp : IFromJSON // TypeDefIndex: 58468
		{
			// Fields
			public int status; // 0x10
	
			// Constructors
			public ConfirmOrderU1Resp() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018886EC08-0x000000018886ECA4
		}
	
		protected class CreateOrderU1Resp : IFromJSON // TypeDefIndex: 58470
		{
			// Fields
			public int status; // 0x10
			public string msg; // 0x18
			public string type; // 0x20
			public Data data; // 0x28
	
			// Nested types
			public struct Data // TypeDefIndex: 58469
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
			public CreateOrderU1Resp() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018886ED80-0x000000018886F00C
			public U8OrderInfo ToOrderInfo() => default; // 0x000000018886F00C-0x000000018886F124
		}
	
		// Constructors
		protected SDKExternalTools() {} // 0x000000018350B670-0x000000018350B680
		static SDKExternalTools() {} // 0x0000000183B39900-0x0000000183B39A40
	
		// Methods
		public static bool SDKInterfaceInitExternalTools<ConcreteType>()
			where ConcreteType : SDKExternalTools => default;
		public static SDKExternalTools GetInstance() => default; // 0x0000000182692650-0x00000001826926D0
		public static bool HasInstance() => default; // 0x0000000188871870-0x00000001888718B8
		public string PublicServiceSignKey() => default; // 0x0000000188871DD0-0x0000000188871E1C
		public SDKPromise<List<U8ProductInfo>> SDKInterfaceProductListV2() => default; // 0x00000001888726EC-0x0000000188872794
		public void NotifyProductListUpdated(List<U8ProductInfo> productList) {} // 0x0000000188871D54-0x0000000188871DD0
		public string SDKInterfaceSDKToken() => default; // 0x0000000188872794-0x0000000188872840
		public static string MakeHttpPostParam(Dictionary<string, object> param) => default; // 0x00000001842743D8-0x00000001842743E0
		public void LoginWithPlugin(Action nativeLogin, Action<string> nativeLoginCustom, Action<U8MockLogin> markMockLogin) {} // 0x0000000182E992F0-0x0000000182E99620
		public void LogoutWithPlugin(Action nativeLogout) {} // 0x0000000188871AC8-0x0000000188871D54
		public void SDKInterfacePayWithPlugin(U8PayParams payParams, Func<U8PayParams, SDKPromise<U8PayResult>> nativePay, Action<U8PayResult> onSuc, Action<object> onFail) {} // 0x0000000188872590-0x00000001888726EC
		public string SDKInterfaceGetPayAddition() => default; // 0x00000001888724BC-0x0000000188872590
		public static void StaticLog(string content) {} // 0x0000000188872970-0x0000000188872A08
		public static void StaticLogWarning(string content) {} // 0x00000001888728D8-0x0000000188872970
		public static void StaticLogError(string content) {} // 0x0000000188872840-0x00000001888728D8
		public static void RegisterPlugin(IExternalPlugin plugin) {} // 0x00000001839CAC00-0x00000001839CAD40
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default) => default;
		protected string U8Url(string routeUrl) => default; // 0x0000000188872A08-0x0000000188872AAC
		protected string U8urlWithoutU8(string routeUrl) => default; // 0x0000000188872AAC-0x0000000188872BA4
		protected static ErrMsgMeta HandleResponseFromU8<TResp>(BusType busType, POSTResult postRet, out ref TResp resp)
			where TResp : IFromJSON, new() {
			resp = default;
			return default;
		}
		protected static Dictionary<string, object> FromMiniJSON(string json) => default; // 0x00000001888717AC-0x0000000188871870
		protected static void InternalInvokeCoroutine(IEnumerator coroutine) {} // 0x00000001888718B8-0x0000000188871914
		protected static void InternalInvokeNextFrame(Action action) {} // 0x0000000188871914-0x00000001888719A0
		[IteratorStateMachine(typeof(__NextFrameCoroutine_d__61))]
		private static IEnumerator _NextFrameCoroutine(Action action) => default; // 0x00000001888732F4-0x0000000188873350
		public void InitIfNot() {} // 0x0000000183B36670-0x0000000183B36720
		protected virtual void Init() {} // 0x000000018350B670-0x000000018350B680
		public virtual void SwitchAccount() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnSDKError(SDKError error) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnInvalidProduct(int storeId) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnSDKExtraInfo(string jsonData) {} // 0x000000018350B670-0x000000018350B680
		public virtual SDKMeta LoadSDKMetaFromPlugin(Func<SDKMeta> nativeLoadMeta) => default; // 0x00000001888719A0-0x0000000188871AC8
		protected abstract SDKCaptchaHandler CreateCaptchaHandler();
		protected virtual string GetSignKey() => default; // 0x0000000181002730-0x0000000181002740
		public abstract Dictionary<string, string> GetDeviceIDs();
		protected abstract SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr);
		protected abstract int GetPlatformKey();
		protected abstract void POSTImplementation(POSTRequest request, Action<POSTResult> callback);
		protected abstract string U8RootUrl();
		protected abstract string GetErrorMessage(ErrMsgMeta meta);
		protected abstract void Log(string content);
		protected abstract void LogWarning(string content);
		protected abstract void LogError(string content);
		private bool _ValidatePlugin() => default; // 0x0000000182E97CC0-0x0000000182E97D30
		private static string _MakeGetProductListV2Param(SDKMeta meta) => default; // 0x0000000188872FDC-0x0000000188873140
		[IteratorStateMachine(typeof(_SDKInterfaceAuthV2SessionToken_d__113))]
		public IEnumerator SDKInterfaceAuthV2SessionToken(SDKMeta meta, string channelToken, SDKPromiseWithResult<U8LoginV2Result> promise) => default; // 0x0000000188872134-0x00000001888721DC
		[IteratorStateMachine(typeof(_SDKInterfaceAuthV2OAuth2Code_d__114))]
		public IEnumerator SDKInterfaceAuthV2OAuth2Code(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid) => default; // 0x000000018887208C-0x0000000188872134
		public SDKPromise<U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(string orderId, string extension) => default; // 0x00000001888721DC-0x0000000188872290
		public SDKPromise<List<U8ServerInfo>> SDKInterFaceGetServerList(string sessionToken) => default; // 0x0000000188871F70-0x000000018887208C
		public SDKPromise<U8ConfirmServerResult> SDKInterFaceConfirmServer(string sessionToken, string serverId) => default; // 0x0000000188871E1C-0x0000000188871F70
		public SDKPromise<U8OrderInfo> SDKInterfaceCreateOrderU1(string sessionToken, string productId, string signParams) => default; // 0x0000000188872290-0x00000001888724BC
		private static string _MakeGrantParam(string sessionToken, int type, string captcha) => default; // 0x0000000188873140-0x00000001888732F4
		[IteratorStateMachine(typeof(__AuthV2GrantImpl_d__120))]
		private IEnumerator _AuthV2GrantImpl(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid) => default; // 0x0000000188872BA4-0x0000000188872C4C
		private static string _MakeCheckOrderV1Param(string orderId, string extension) => default; // 0x0000000188872E28-0x0000000188872F20
		private static string _MakeConfirmOrderV1Param(string orderId) => default; // 0x0000000188872F20-0x0000000188872FDC
		[IteratorStateMachine(typeof(__ConfirmOrderU1Coroutine_d__123))]
		private IEnumerator _ConfirmOrderU1Coroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise) => default; // 0x0000000188872C4C-0x0000000188872CF4
		[IteratorStateMachine(typeof(__PollOrderStatusCoroutine_d__124))]
		private IEnumerator _PollOrderStatusCoroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise) => default; // 0x0000000188873350-0x00000001888733DC
		[IteratorStateMachine(typeof(__GetServerListCoroutine_d__125))]
		private IEnumerator _GetServerListCoroutine(string paramStr, SDKPromise<List<U8ServerInfo>> promise) => default; // 0x0000000188872D9C-0x0000000188872E28
		[IteratorStateMachine(typeof(__ConfirmServerListCoroutine_d__127))]
		private IEnumerator _ConfirmServerListCoroutine(string paramStr, string serverId, SDKPromise<U8ConfirmServerResult> promise) => default; // 0x0000000188872CF4-0x0000000188872D9C
		[IteratorStateMachine(typeof(__SendCreateOrderU1Coroutine_d__128))]
		private IEnumerator _SendCreateOrderU1Coroutine(string paramStr, SDKPromise<U8OrderInfo> promise) => default; // 0x00000001888733DC-0x0000000188873468
	}

	public struct SDKExtraData // TypeDefIndex: 58482
	{
		// Fields
		public static readonly SDKExtraData EMPTY; // 0x00
		public int code; // 0x00
		public Dictionary<string, object> msg; // 0x08
	
		// Constructors
		static SDKExtraData() {
			EMPTY = default;
		} // 0x0000000183D1BA30-0x0000000183D1BA80
	
		// Methods
		public static SDKExtraData FromJson(string jsonStr) => default; // 0x0000000182692BF0-0x0000000182692D60
	}

	public abstract class SDKExternalToolsShortcut : SDKExternalTools // TypeDefIndex: 58487
	{
		// Nested types
		protected struct U8ProductListDataV2 : SDKExternalTools.IFromJSON // TypeDefIndex: 58483
		{
			// Fields
			public List<U8ProductInfo> productList; // 0x00
	
			// Methods
			public bool LoadFromJSON(string json) => default; // 0x000000018887A26C-0x000000018887A514
			private static bool _BuildProductInfo(U8ProductInfo outInfo, Dictionary<string, object> dict) => default; // 0x000000018887A514-0x000000018887A6DC
		}
	
		public enum RequestConnPolicy // TypeDefIndex: 58484
		{
			DEFAULT = 0,
			CLOSE_EACH_CON = 1
		}
	
		public struct RequestHeaderInjectOptions // TypeDefIndex: 58485
		{
			// Fields
			public RequestConnPolicy policy; // 0x00
		}
	
		// Constructors
		protected SDKExternalToolsShortcut() {} // 0x0000000183D42B80-0x0000000183D42BC0
	
		// Methods
		protected sealed override SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr) => default; // 0x00000001888715A0-0x0000000188871770
		public override Dictionary<string, string> GetDeviceIDs() => default; // 0x000000018887129C-0x00000001888713A8
		public static string GetU8DeviceID() => default; // 0x00000001888713A8-0x00000001888714C8
		public static void InjectRequestHeaders(ref Dictionary<string, string> headers, RequestHeaderInjectOptions policy) {} // 0x00000001888714C8-0x00000001888715A0
		private string _GetProductListV1Url() => default; // 0x0000000188871770-0x00000001888717AC
	}

	public abstract class U8SDKInterface // TypeDefIndex: 58503
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
		private GameServerTimeCache m_gameServerTimeCache; // 0xB8
	
		// Properties
		public static U8SDKInterface Instance { get; } // 0x0000000182D7A390-0x0000000182D7A4A0 
		public bool isNativePlugin { get; } // 0x0000000182E97C40-0x0000000182E97CC0 
		public string uid { get; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public string cachedUid { get; set; } // 0x0000000182D780F0-0x0000000182D78130 0x0000000183777270-0x00000001837772D0
		public string oauth2token { get; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public string oauth2code { get; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public static bool isInterfaceDisabled { get; } // 0x000000018115F4C0-0x000000018115F530 
		public string sessionToken { get; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
		public GameServerTimeCache serverCacheTime { get; set; } // 0x0000000183D6DAF0-0x0000000183D6DB10 0x0000000183D6DB10-0x0000000183D6DB30
	
		// Events
		private static event ReceiverProductListResult onReceiverProductlist;
	
		// Nested types
		public struct AuthStatus // TypeDefIndex: 58488
		{
			// Fields
			public static readonly AuthStatus EMPTY; // 0x00
			public string uid; // 0x00
			public string oauth2code; // 0x08
			public string oauth2token; // 0x10
			public string sessionToken; // 0x18
		}
	
		private struct V2LoginStatus // TypeDefIndex: 58489
		{
			// Fields
			public string sessionToken; // 0x00
		}
	
		public delegate void ReceiverProductListResult(Dictionary<string, object> msg); // TypeDefIndex: 58490; 0x0000000182149960-0x0000000182149970
	
		public struct GameServerTimeCache // TypeDefIndex: 58491
		{
			// Fields
			public long cacheTime; // 0x00
			public long maintainEndTs; // 0x08
			public long maintainStartTs; // 0x10
		}
	
		// Constructors
		protected U8SDKInterface() {} // 0x0000000183A597D0-0x0000000183A59920
		static U8SDKInterface() {} // 0x0000000183D2B9A0-0x0000000183D2B9F0
	
		// Methods
		public void CallbackInitSuc(string extConfigs) {} // 0x00000001839C3170-0x00000001839C3190
		public void CallbackInitFail(string info) {} // 0x000000018887A988-0x000000018887A9A8
		public void CallbackLoginSuc(string extension) {} // 0x00000001839C31F0-0x00000001839C3210
		public void CallbackLoginFail(string info) {} // 0x000000018887A9A8-0x000000018887A9C8
		public void CallbackLogout() {} // 0x000000018887A9C8-0x000000018887A9EC
		public void CallbackSwitchAccount() {} // 0x000000018887AB14-0x000000018887AB60
		public void CallbackPaySuc(string jsonData) {} // 0x000000018887AA80-0x000000018887AB14
		public void CallbackPayFail(string failMsg) {} // 0x000000018887A9EC-0x000000018887AA80
		public string PublicLoadExtraConfig() => default; // 0x0000000184273A44-0x0000000184273A54
		public void PublicSetGameVersion(string version) {} // 0x00000001842770BC-0x00000001842770D0
		public ReceiverProductListResult getOnReceiverProductlist() => default; // 0x000000018887BD44-0x000000018887BD94
		public SDKPromise<string> V2PublicInit<ToolType>(string env)
			where ToolType : SDKExternalTools => default;
		private void _MarkMockLogin(U8MockLogin mockLogin) {} // 0x0000000183D4D850-0x0000000183D4D870
		private void _onLoginSuc(string uid, bool isNew) {} // 0x0000000182E97B60-0x0000000182E97C40
		public SDKPromise<U8ProductsResult> PublicGetProductListV2() => default; // 0x000000018887AFA4-0x000000018887B0C4
		public void ClearAuthStatus() {} // 0x000000018887AB60-0x000000018887ABBC
		public void ClearLoginStatus() {} // 0x000000018887ABBC-0x000000018887ABE8
		private void _ConfirmAuthResult(AuthStatus result) {} // 0x0000000183777230-0x0000000183777270
		public SDKPromise<object> PublicLogout() => default; // 0x000000018887B1A8-0x000000018887B248
		public SDKPromise<List<U8ServerInfo>> PublicGetServerList() => default; // 0x000000018887B0C4-0x000000018887B0CC
		public SDKPromise<U8ConfirmServerResult> PubliceConfirmServer(string serverId) => default; // 0x000000018887B490-0x000000018887B498
		public SDKPromise<U8PayResult> PublicPay(int storeId, U8OrderInfo orderInfo) => default; // 0x000000018887B248-0x000000018887B490
		private void _OnNativePayFulfilled(long revenue) {} // 0x000000018887BAC4-0x000000018887BB80
		private bool _TryGetProduct(int storeId, out U8ProductInfo productInfo) {
			productInfo = default;
			return default;
		} // 0x000000018887BBA0-0x000000018887BC70
		private U8PayParams _GeneratePayParams(U8ProductInfo productInfo, U8OrderInfo orderInfo) => default; // 0x000000018887B844-0x000000018887B9E0
		private SDKPromise<U8PayResult> _NativePay(U8PayParams payParams) => default; // 0x000000018887B9E0-0x000000018887BAC4
		private static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default) => default;
		public SDKMeta PublicLoadSDKMeta() => default; // 0x000000018887B0CC-0x000000018887B1A8
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
		private IEnumerator _NextFrameCoroutine(Action call) => default; // 0x0000000182690B40-0x0000000182690BA0
		protected void InvokeNextFrame(Action action) {} // 0x0000000182690AB0-0x0000000182690B40
		protected void InvokeCoroutine(IEnumerator coroutine) {} // 0x0000000183D06B90-0x0000000183D06BF0
		protected string EncodeGameData(U8ExtraGameData data) => default; // 0x0000000182E985D0-0x0000000182E988E0
		protected string EncodePayParams(U8PayParams data) => default; // 0x000000018887ABE8-0x000000018887AFA4
		public SDKPromise<string> V2PublicLogin() => default; // 0x0000000182C36FB0-0x0000000182C37030
		public SDKPromise<U8AuthV2Result> V2PublicAuth() => default; // 0x0000000182690560-0x00000001826905C0
		public SDKPromise<U8OrderInfo> U1PublicCreateOrder(string productId, string signParams) => default; // 0x000000018887B56C-0x000000018887B5EC
		public SDKPromise<List<U8ServerInfo>> U1PublicGetServerList() => default; // 0x000000018887B5EC-0x000000018887B648
		public SDKPromise<U8ConfirmServerResult> U1PublicConfirmServer(string serverId) => default; // 0x000000018887B500-0x000000018887B56C
		public SDKPromise<U8ConfirmOrderResult> U1PublicConfirmOrder(string orderId, string extension) => default; // 0x000000018887B498-0x000000018887B500
		private SDKPromise<U8AuthV2Result> _DoMockAuthV2() => default; // 0x00000001826905C0-0x00000001826906B0
		[IteratorStateMachine(typeof(__LoginV2Coroutine_d__132))]
		private IEnumerator _LoginV2Coroutine(SDKPromise<string> promise) => default; // 0x0000000182C37030-0x0000000182C370B0
		private void _OnSessionTokenInvalid() {} // 0x000000018887BB80-0x000000018887BBA0
		[IteratorStateMachine(typeof(__AuthV2Coroutine_d__134))]
		private IEnumerator _AuthV2Coroutine(SDKPromise<U8AuthV2Result> promise) => default; // 0x000000018887B7D0-0x000000018887B844
	}

	public struct SDKError // TypeDefIndex: 58504
	{
		// Properties
		private string code { get; set; } // 0x00000001842715A0-0x00000001842715A8
		private string msg { get; set; } // 0x000000018558FF08-0x000000018558FF18
	
		// Constructors
		public SDKError(string content) : this() {} // 0x0000000188871074-0x000000018887129C
	}

	public struct U8MockLogin // TypeDefIndex: 58505
	{
		// Fields
		public static readonly U8MockLogin EMPTY; // 0x00
		public string uid; // 0x00
		public string token; // 0x08
	
		// Methods
		public bool IsEmpty() => default; // 0x00000001842710A8-0x00000001842710C0
	}

	public class U8ProductInfo // TypeDefIndex: 58506
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
		public U8ProductInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8ProductsResult // TypeDefIndex: 58507
	{
		// Fields
		public int status; // 0x10
		public List<U8ProductInfo> u8Products; // 0x18
	
		// Constructors
		public U8ProductsResult() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8ServerInfo // TypeDefIndex: 58508
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
		public U8ServerInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8ServerErrorInfo // TypeDefIndex: 58509
	{
		// Fields
		public int status; // 0x10
		public int errorCode; // 0x14
	
		// Constructors
		public U8ServerErrorInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8OrderInfo // TypeDefIndex: 58510
	{
		// Fields
		public string orderId; // 0x10
		public string channelProductCode; // 0x18
		public string productName; // 0x20
		public string productDesc; // 0x28
		public long amount; // 0x30
		public string extension; // 0x38
	
		// Constructors
		public U8OrderInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8PayParams // TypeDefIndex: 58511
	{
		// Properties
		public string productId { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string productName { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string productDesc { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public long price { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000183D4ED70-0x0000000183D4ED80
		public int buyNum { get; set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public int coinNum { get; } // 0x0000000183D4EE00-0x0000000183D4EE10 
		public string serverId { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public string serverName { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public string roleId { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public string roleName { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public int roleLevel { get; } // 0x0000000183D4EF00-0x0000000183D4EF10 
		public string vip { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public string orderID { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public string worldID { get; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public string token { get; set; } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		public string appKey { get; set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public string extension { get; set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		public string addition { get; set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
	
		// Constructors
		public U8PayParams() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8ExtraGameData // TypeDefIndex: 58512
	{
		// Properties
		public int dataType { get; set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public string uid { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string roleID { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string roleName { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public string roleLevel { get; } // 0x0000000181003830-0x0000000181003840 
		public int serverID { get; set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public string serverName { get; set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public string channel { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public string subChannel { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public bool isNewUser { get; set; } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
		public long revenue { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x0000000183D4EE20-0x0000000183D4EE30
		public string customEventName { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public string customEventParams { get; } // 0x0000000183D4EB30-0x0000000183D4EB40 
	
		// Constructors
		public U8ExtraGameData() {} // 0x000000018350B670-0x000000018350B680
	}

	public struct U8LoginResult // TypeDefIndex: 58513
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
		public override string ToString() => default; // 0x00000001888798E0-0x0000000188879AB4
	}

	public struct U8ProductError // TypeDefIndex: 58514
	{
		// Fields
		public int status; // 0x00
		public int errorCode; // 0x04
	}

	public enum PayResultStatus // TypeDefIndex: 58515
	{
		SUCCEED = 0,
		PENDING = 1
	}

	public enum PayFailStatus // TypeDefIndex: 58516
	{
		UNKNOWN = 0,
		CANCELED = 1,
		ERROR = 2,
		HALT = 3
	}

	public class U8ConfirmServerResult // TypeDefIndex: 58517
	{
		// Fields
		public int status; // 0x10
		public string message; // 0x18
	
		// Constructors
		public U8ConfirmServerResult() {} // 0x000000018350B670-0x000000018350B680
	}

	public enum U8ConfirmOrderStatus // TypeDefIndex: 58518
	{
		NONE = 0,
		INTERNAL_ERROR = 1,
		TIMEOUT = 2,
		INVALID_ORDER = 3,
		SUCCEED = 4
	}

	public class U8ConfirmOrderResult // TypeDefIndex: 58519
	{
		// Fields
		public U8ConfirmOrderStatus status; // 0x10
		public string message; // 0x18
	
		// Constructors
		public U8ConfirmOrderResult() {} // 0x000000018350B670-0x000000018350B680
	}

	public struct U8PayFailMsg // TypeDefIndex: 58520
	{
		// Fields
		public static U8PayFailMsg EMPTY; // 0x00
		public PayFailStatus status; // 0x00
		public string message; // 0x08
		public string extension; // 0x10
	
		// Constructors
		static U8PayFailMsg() {
			EMPTY = default;
		} // 0x0000000188879E28-0x0000000188879E8C
	
		// Methods
		public static U8PayFailMsg FromJson(string jsonStr) => default; // 0x0000000188879B28-0x0000000188879E28
	}

	public struct U8PayResult // TypeDefIndex: 58521
	{
		// Fields
		public static readonly U8PayResult EMPTY; // 0x00
		public PayResultStatus status; // 0x00
		public string outTradeNo; // 0x08
		public string extension; // 0x10
	
		// Constructors
		static U8PayResult() {
			EMPTY = default;
		} // 0x000000018887A1F8-0x000000018887A26C
	
		// Methods
		public static U8PayResult FromJson(string jsonData) => default; // 0x0000000188879E8C-0x000000018887A10C
		public override string ToString() => default; // 0x000000018887A10C-0x000000018887A1F8
	}

	public class SDKInterfaceWIN : U8SDKInterface // TypeDefIndex: 58528
	{
		// Fields
		private int actionIndex; // 0xD0
		private static Dictionary<int, Action<string>> dictAction; // 0x00
	
		// Nested types
		public delegate void DataCallback(int index, string paramValue); // TypeDefIndex: 58522; 0x0000000182065C10-0x0000000182065C20
	
		public delegate void U8SDKSendMessageCallback(string methodName, string paramValue); // TypeDefIndex: 58523; 0x0000000182065C10-0x0000000182065C20
	
		// Constructors
		public SDKInterfaceWIN() {} // 0x0000000182D787D0-0x0000000182D78970
		static SDKInterfaceWIN() {} // 0x0000000183CE30D0-0x0000000183CE3160
	
		// Methods
		~SDKInterfaceWIN() {} // 0x00000001888736A4-0x0000000188873770
		public int AddAction(Action<string> action) => default; // 0x0000000182E99B30-0x0000000182E99D40
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void DataActionCallback(int index, string paramValue) {} // 0x00000001826906B0-0x0000000182690960
		[AOT.MonoPInvokeCallback(typeof(DataCallback))]
		public static void ASyncDataActionCallback(int index, string paramValue) {} // 0x00000001888734B8-0x00000001888736A4
		[AOT.MonoPInvokeCallback(typeof(U8SDKSendMessageCallback))]
		public static void U8SDKSendMessage(string methodName, string paramValue) {} // 0x0000000182690A30-0x0000000182690AB0
		public static extern void HGU8SDKInitLibrary(string windowText, long windowHandle); // 0x00000001822C71F0-0x00000001822C72A0
		public static extern int HGU8SDKSetUserDataPath(string path); // 0x00000001822C72A0-0x00000001822C7350
		public static extern void HGU8SDKUnInitLibrary(); // 0x0000000188873A30-0x0000000188873A98
		public static extern void HGU8SDKInitDatacallback(DataCallback Callback, DataCallback asyncCallback); // 0x00000001822C7350-0x00000001822C73F0
		public static extern void HGU8SDKInitSendMessage(U8SDKSendMessageCallback callback); // 0x00000001822C73F0-0x00000001822C7480
		public static extern void HGU8SDKV2Init(string env); // 0x00000001822C7480-0x00000001822C7520
		public static extern void HGU8SDKLogin(); // 0x0000000188873870-0x00000001888738D8
		public static extern void HGU8SDKLoginCustom(string json); // 0x00000001888737E8-0x0000000188873870
		public static extern int HGU8SDKLogout(); // 0x00000001888738D8-0x0000000188873940
		public static extern int HGU8SDKShowAccountCenter(); // 0x00000001888739C8-0x0000000188873A30
		public static extern void HGU8SDKPay(string json); // 0x0000000188873940-0x00000001888739C8
		public static extern void HGU8SDKSubmitGameData(string json); // 0x0000000182E988E0-0x0000000182E98940
		public static extern void HGU8SDKGetSDKMeta(int index); // 0x0000000188873770-0x00000001888737E8
		public static extern void HGU8SDKSetData(int code, string paramJson); // 0x0000000182E5B410-0x0000000182E5B470
		public static extern void HGU8SDKGetData(int code, string paramJson, int index); // 0x0000000182E99D40-0x0000000182E99DB0
		public static extern int HGU8SDKIsNativePlugin(); // 0x00000001822C7520-0x00000001822C7590
		public static extern void HGU8SDKLoadExtraConfig(int index); // 0x0000000182E99DB0-0x0000000182E99DE0
		public static extern void HGU8SDKSetGameVersion(string version); // 0x0000000183C94670-0x0000000183C946D0
		protected override string LoadExtraConfig() => default; // 0x0000000182E99620-0x0000000182E99740
		protected override void V2Init(string env) {} // 0x00000001838E8A60-0x00000001838E8AF0
		protected override void Login() {} // 0x0000000188873C14-0x0000000188873C54
		protected override bool Logout() => default; // 0x0000000188873C54-0x0000000188873C9C
		protected override void LoginCustom(string customData) {} // 0x0000000188873BC8-0x0000000188873C14
		public override void SubmitGameData(U8ExtraGameData data) {} // 0x0000000182E98560-0x0000000182E985D0
		public override void SetData(int type, string paramJson) {} // 0x0000000182E5B360-0x0000000182E5B410
		public override string GetData(int type, string paramJson) => default; // 0x0000000182E999F0-0x0000000182E99B30
		public override bool ShowAccountCenter() => default; // 0x0000000188873CFC-0x0000000188873D44
		protected override void Pay(U8PayParams data) {} // 0x0000000188873C9C-0x0000000188873CFC
		protected override SDKMeta LoadSDKMeta() => default; // 0x0000000188873A98-0x0000000188873BC8
		protected override bool IsNativePlugin() => default; // 0x0000000183D2A480-0x0000000183D2A4D0
		public override void SetGameVersion(string version) {} // 0x0000000183C94620-0x0000000183C94670
	}

	public class ImageSaver // TypeDefIndex: 58537
	{
		// Nested types
		private enum FolderType // TypeDefIndex: 58529
		{
			UserPicturesFolder = 0,
			GameInstalledFolder = 1
		}
	
		private enum ErrorCode // TypeDefIndex: 58530
		{
			UnknowError = -1,
			NotInited = 0,
			ParamsError = 1,
			ImageNotFound = 3,
			ShareChannelError = 6,
			SaveFailed = 8
		}
	
		private enum CallbackResult : byte // TypeDefIndex: 58531
		{
			Success = 0,
			Cancelled = 1,
			Failed = 2
		}
	
		[Serializable]
		public class ImageShareInfo // TypeDefIndex: 58532
		{
			// Fields
			public string shareChannel; // 0x10
			public string imgPath; // 0x18
			public string relativePath; // 0x20
			public int folderType; // 0x28
	
			// Constructors
			public ImageShareInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public ImageSaver() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public async System.Threading.Tasks.Task SaveImage(string paramJson) => default; // 0x0000000188870258-0x0000000188870328
		private bool ValidateInput(string paramJson, out ImageShareInfo shareInfo) {
			shareInfo = default;
			return default;
		} // 0x0000000188870A40-0x0000000188870B1C
		private string NormalizeSourcePath(string imgPath) => default; // 0x000000018886FF08-0x000000018887007C
		private FolderType ParseFolderType(int folderType) => default; // 0x000000018887007C-0x0000000188870138
		private string BuildTargetPath(string sourcePath, string relativePath, string baseFolder) => default; // 0x000000018886F5D4-0x000000018886F700
		private bool IsDirectoryPath(string path) => default; // 0x000000018886FB28-0x000000018886FBDC
		private string BuildPathForDirectory(string sourcePath, string relativeDirPath, string baseFolder) => default; // 0x000000018886F4A8-0x000000018886F5D4
		private async Task<bool> SaveImageToPathAsync(string sourcePath, string targetPath, string imgFolder) => default; // 0x0000000188870138-0x0000000188870258
		private bool IsSamePath(string sourcePath, string targetPath) => default; // 0x000000018886FBDC-0x000000018886FCB0
		private bool ValidateMove(string sourcePath, string targetPath, string rootDir, out string error) {
			error = default;
			return default;
		} // 0x0000000188870B1C-0x0000000188870CF4
		private void EnsureDirectoryExists(string filePath) {} // 0x000000018886F700-0x000000018886F768
		private bool MoveFile(string sourcePath, string targetPath) => default; // 0x000000018886FCB0-0x000000018886FF08
		private string GetImageSaveFolder(FolderType folderType) => default; // 0x000000018886F914-0x000000018886F9C8
		private string GetWindowsPicturePath() => default; // 0x000000018886F9C8-0x000000018886FB28
		private string GetGameInstalledFolder() => default; // 0x000000018886F768-0x000000018886F914
		private void SendSuccessResponse(string targetPath) {} // 0x000000018887094C-0x0000000188870A40
		private void SendErrorResponse(ErrorCode errorCode) {} // 0x0000000188870328-0x0000000188870400
		private void SendResponse(CallbackResult code, Dictionary<string, object> extraMsg = null) {} // 0x00000001888704D8-0x000000018887094C
		private void SendMessageInMain(string methodName, string paramValue) {} // 0x0000000188870400-0x00000001888704D8
	}

	public class U8MainThreadDispatcher : MonoBehaviour // TypeDefIndex: 58538
	{
		// Fields
		private static readonly ConcurrentQueue<Action> _queue; // 0x00
		private static U8MainThreadDispatcher _instance; // 0x08
		private static int _initialized; // 0x10
	
		// Constructors
		public U8MainThreadDispatcher() {} // 0x000000018426FE60-0x000000018426FE68
		static U8MainThreadDispatcher() {} // 0x0000000183A1DEE0-0x0000000183A1DF90
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Initialize() {} // 0x0000000183B392E0-0x0000000183B39490
		public static void RunOnMainThread(Action action) {} // 0x0000000188879AB4-0x0000000188879B28
		private void Update() {} // 0x0000000182339FE0-0x000000018233A120
	}

	public class SDKMeta // TypeDefIndex: 58539
	{
		// Fields
		public string appID; // 0x10
		public string appKey; // 0x18
		public string channel; // 0x20
		public string worldId; // 0x28
		public string extension; // 0x30
		public string appCode; // 0x38
	
		// Constructors
		public SDKMeta() {} // 0x000000018350B670-0x000000018350B680
		public SDKMeta(string jsonData) {} // 0x0000000188873EA8-0x00000001888741D4
	
		// Methods
		public override string ToString() => default; // 0x0000000188873D44-0x0000000188873EA8
	}

	public interface ISDKPromise // TypeDefIndex: 58540
	{
		// Methods
		void Fulfill(object param);
		void Reject(object reason);
	}

	public class SDKPromise<Param> : ISDKPromise // TypeDefIndex: 58541
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

	public class SDKPromiseWithResult<Param> : SDKPromise<Param> // TypeDefIndex: 58542
		where Param : class
	{
		// Properties
		public Param result { get; private set; }
		public object rejectInfo { get; private set; }
	
		// Constructors
		public SDKPromiseWithResult() {}
	
		// Methods
		public override void Fulfill(object param) {}
		public override void Reject(object reason) {}
	}

	public class SDKPromiseEnumerator<T> // TypeDefIndex: 58545
	{
		// Fields
		private State m_state;
	
		// Properties
		public bool isFulfilled { get => default; }
		public T result { get; private set; }
		public object reject { get; private set; }
	
		// Nested types
		private enum State // TypeDefIndex: 58543
		{
			NONE = 0,
			FULFILL = 1,
			REJECT = 2
		}
	
		// Constructors
		public SDKPromiseEnumerator() {} // Dummy constructor
		public SDKPromiseEnumerator(SDKPromise<T> promise) {}
	
		// Methods
		[IteratorStateMachine(typeof(_Yield_d__12))]
		public IEnumerator Yield() => default;
		private void _OnFulfilled(T result) {}
		private void _OnRejected(object rejectInfo) {}
	}

	public class SDKPromiseWrapper // TypeDefIndex: 58546
	{
		// Fields
		private ISDKPromise m_promise; // 0x10
	
		// Constructors
		public SDKPromiseWrapper() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public T EnsurePromise<T>()
			where T : ISDKPromise, new() => default;
		public void Fulfill(object param) {} // 0x00000001839C3210-0x00000001839C32D0
		public void Reject(object reason) {} // 0x00000001888741EC-0x000000018887421C
		private void _Clear() {} // 0x00000001835ACAA0-0x00000001835ACAC0
	}

	public static class SDKPromiseExtensions // TypeDefIndex: 58547
	{
		// Extension methods
		public static void RejectWithString(this ISDKPromise promise, string errorInfo) {} // 0x00000001888741D4-0x00000001888741EC
		public static void FulfillWithType<T>(this SDKPromise<T> promise, T param)
			where T : class {}
	}

	public class U8SDKTickEvent : MonoBehaviour // TypeDefIndex: 58548
	{
		// Constructors
		public U8SDKTickEvent() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Update() {} // 0x00000001831B4EF0-0x00000001831B4F00
		public static extern void HGU8SDKTickEvent(); // 0x00000001831B4F00-0x00000001831B4F30
	}

	public class U8TickEventManager // TypeDefIndex: 58549
	{
		// Fields
		private GameObject tickGameObject; // 0x10
		private U8SDKTickEvent tickEvent; // 0x18
		private static U8TickEventManager instanceManager; // 0x00
		private static readonly object lockObject; // 0x08
	
		// Properties
		public static U8TickEventManager InstanceManager { get => default; } // 0x00000001838E8AF0-0x00000001838E8BD0 
	
		// Constructors
		public U8TickEventManager() {} // 0x000000018350B670-0x000000018350B680
		static U8TickEventManager() {} // 0x0000000183CFDD60-0x0000000183CFDDD0
	
		// Methods
		public void InitTickEvent() {} // 0x00000001838E8BD0-0x00000001838E90A0
		public void UnInitTickEvent() {} // 0x000000018887BE68-0x000000018887C030
	}

	public class U8LoginV2Result // TypeDefIndex: 58550
	{
		// Fields
		public string token; // 0x10
		public string uid; // 0x18
		public bool isNew; // 0x20
	
		// Constructors
		public U8LoginV2Result() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8AuthV2Result // TypeDefIndex: 58551
	{
		// Fields
		public string uid; // 0x10
		public string oauth2Code; // 0x18
		public string oauth2Token; // 0x20
	
		// Constructors
		public U8AuthV2Result() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8GrantResult // TypeDefIndex: 58552
	{
		// Fields
		public string uid; // 0x10
		public string code; // 0x18
		public string token; // 0x20
	
		// Constructors
		public U8GrantResult() {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8SDKCallback : MonoBehaviour // TypeDefIndex: 58554
	{
		// Fields
		private static U8SDKCallback m_instance; // 0x00
		private static object m_lock; // 0x08
	
		// Constructors
		public U8SDKCallback() {} // 0x000000018426FE60-0x000000018426FE68
		static U8SDKCallback() {} // 0x0000000183CFDDD0-0x0000000183CFDE40
	
		// Methods
		public static U8SDKCallback InitCallback() => default; // 0x0000000182690BA0-0x00000001826912B0
		public void OnInitSuc(string extConfigs) {} // 0x00000001839C3110-0x00000001839C3170
		public void OnInitFail(string info) {} // 0x000000018887A6DC-0x000000018887A734
		public void OnLoginSuc(string extension) {} // 0x00000001839C3190-0x00000001839C31F0
		public void OnLoginFail(string info) {} // 0x000000018887A734-0x000000018887A78C
		public void OnLogout(string info) {} // 0x000000018887A78C-0x000000018887A7D8
		public void OnSwitchAccount() {} // 0x000000018887A8F8-0x000000018887A944
		public void OnPaySuc(string jsonData) {} // 0x000000018887A830-0x000000018887A888
		public void OnPayFail(string failMsg) {} // 0x000000018887A7D8-0x000000018887A830
		public void OnSDKError(string jsonData) {} // 0x000000018887A888-0x000000018887A8F8
		public void OnExtraInfo(string jsonData) {} // 0x0000000182692D60-0x0000000182692ED0
		[IteratorStateMachine(typeof(__onLogoutNextFrameCoroutine_d__13))]
		private IEnumerator _onLogoutNextFrameCoroutine() => default; // 0x000000018887A944-0x000000018887A988
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, T defVal = default) => default;
	}
}

namespace U8.SDK.MiniJSON
{
	public static class Json // TypeDefIndex: 58558
	{
		// Nested types
		private sealed class Parser : IDisposable // TypeDefIndex: 58556
		{
			// Fields
			private StringReader json; // 0x10
	
			// Properties
			private char PeekChar { get => default; } // 0x00000001826950A0-0x0000000182695110 
			private char NextChar { get => default; } // 0x0000000182695280-0x00000001826952F0 
			private string NextWord { get => default; } // 0x0000000182694C60-0x0000000182694D20 
			private TOKEN NextToken { get => default; } // 0x0000000182694EE0-0x00000001826950A0 
	
			// Nested types
			private enum TOKEN // TypeDefIndex: 58555
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
			private Parser(string jsonString) {} // 0x0000000182695910-0x0000000182695990
	
			// Methods
			public static bool IsWordBreak(char c) => default; // 0x0000000182695330-0x00000001826953C0
			public static object Parse(string jsonString) => default; // 0x0000000182694A40-0x0000000182694B40
			public void Dispose() {} // 0x0000000183823730-0x0000000183823770
			private Dictionary<string, object> ParseObject() => default; // 0x0000000182694D20-0x0000000182694E50
			private List<object> ParseArray() => default; // 0x0000000188870E98-0x0000000188870FBC
			private object ParseValue() => default; // 0x0000000182694B40-0x0000000182694B70
			private object ParseByToken(TOKEN token) => default; // 0x0000000182694B70-0x0000000182694C60
			private string ParseString() => default; // 0x0000000182695110-0x0000000182695280
			private object ParseNumber() => default; // 0x00000001826953C0-0x0000000182695470
			private void EatWhitespace() {} // 0x0000000182694E50-0x0000000182694EE0
		}
	
		private sealed class Serializer // TypeDefIndex: 58557
		{
			// Fields
			private StringBuilder builder; // 0x10
	
			// Constructors
			private Serializer() {} // 0x00000001831EDCB0-0x00000001831EDD20
	
			// Methods
			public static string Serialize(object obj) => default; // 0x00000001831EDC30-0x00000001831EDCB0
			private void SerializeValue(object value) {} // 0x00000001831EDEC0-0x00000001831EE080
			private void SerializeObject(IDictionary obj) {} // 0x00000001831EE2C0-0x00000001831F9EA0
			private void SerializeArray(IList anArray) {} // 0x000000018887421C-0x0000000188874694
			private void SerializeString(string str) {} // 0x00000001831EE080-0x00000001831EE230
			private void SerializeOther(object value) {} // 0x00000001831EDD20-0x00000001831EDE80
		}
	
		// Methods
		public static object Deserialize(string json) => default; // 0x0000000182694A20-0x0000000182694A40
		public static string Serialize(object obj) => default; // 0x00000001842743D8-0x00000001842743E0
	}
}
