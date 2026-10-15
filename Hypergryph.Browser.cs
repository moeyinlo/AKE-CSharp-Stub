/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Hypergryph.CloudClientBridge;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Scripting;

// Image 97: Hypergryph.Browser.dll - Assembly: Hypergryph.Browser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90497-90539

namespace Hypergryph.SDK
{
	public interface IHGBulletinSDK // TypeDefIndex: 90498
	{
		// Methods
		void Open(string type, Action<string> onResult, Action<string> eventListener);
		void Close();
		string GetRedDotState(string type);
		void RegisterBulletinEventListener(Action<string> eventListener);
	}

	public class HGBulletinSDK // TypeDefIndex: 90499
	{
		// Fields
		private static IHGBulletinSDK s_bulletin; // 0x00
	
		// Properties
		private static IHGBulletinSDK bulletinSdk { get; } // 0x00000001859BF370-0x00000001859BF4D0 
	
		// Methods
		public static void Open(string type, Action<string> onResult, Action<string> eventListener = null); // 0x00000001859BEDA0-0x00000001859BEE20
		public static void Close(); // 0x000000018C2159FC-0x000000018C215A60
		public static string GetRedDotState(string type); // 0x00000001859BF8C0-0x00000001859BF920
		public static void RegisterBulletinEventListener(Action<string> eventListener); // 0x0000000186816DB0-0x0000000186816E10
	}

	public class HGBulletinSDKPluginCloud : IHGBulletinSDK // TypeDefIndex: 90503
	{
		// Fields
		private static Action<string> outerEventCallback; // 0x00
		private static Dictionary<string, RedDotEventData> _redDotStateDict; // 0x08
	
		// Nested types
		[UnityEngine.Scripting.Preserve]
		private class BulletinEventData // TypeDefIndex: 90500
		{
			// Fields
			[JsonProperty("eventCode")]
			public int eventCode; // 0x10
			[JsonProperty("data")]
			public JObject data; // 0x18
	
			// Constructors
			public BulletinEventData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[UnityEngine.Scripting.Preserve]
		private class RedDotEventData // TypeDefIndex: 90501
		{
			// Fields
			[JsonProperty("target")]
			public string target; // 0x10
			[JsonProperty("showRedDot")]
			public bool showRedDot; // 0x18
			[JsonProperty("showPopup")]
			public bool showPopup; // 0x19
	
			// Constructors
			public RedDotEventData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 90502
		{
			// Fields
			public Action<string> eventListener; // 0x10
			public Action<string> onResult; // 0x18
			public Action<CloudCallResult> eventCallback; // 0x20
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Open_b__0(CloudCallResult result); // 0x000000018C217DA8-0x000000018C217FB0
			internal void _Open_b__1(CloudCallResult result); // 0x000000018C217FB0-0x000000018C218258
		}
	
		// Constructors
		public HGBulletinSDKPluginCloud(); // 0x000000018C215834-0x000000018C215920
		static HGBulletinSDKPluginCloud(); // 0x000000018C2157A0-0x000000018C215834
	
		// Methods
		~HGBulletinSDKPluginCloud(); // 0x000000018C2149D8-0x000000018C214B14
		public static void InnerEventCallBack(CloudCallResult result); // 0x000000018C214C38-0x000000018C214ED0
		public void Open(string type, Action<string> onResult, Action<string> eventListener); // 0x000000018C214FE8-0x000000018C21554C
		public void Close(); // 0x000000018C214524-0x000000018C214768
		public string GetRedDotState(string type); // 0x000000018C214B14-0x000000018C214C38
		public void RegisterBulletinEventListener(Action<string> eventListener); // 0x000000018C21554C-0x000000018C2155D8
		private void NotifySDKInstantiated(); // 0x000000018C214ED0-0x000000018C214FE8
		private static void UpdateRedDotState(string target, RedDotEventData data); // 0x000000018C2155D8-0x000000018C2157A0
		private string CreateRedDotStateJson(string type, bool showRedDot, bool showPopup); // 0x000000018C214768-0x000000018C2149D8
	}

	public class HGBulletinSDKPluginWindows : IHGBulletinSDK // TypeDefIndex: 90507
	{
		// Fields
		private static Action<string> outerOpenCallback; // 0x00
		private static Action<string> outerEventCallback; // 0x08
		private static Action<string> outerEventListener; // 0x10
	
		// Nested types
		public delegate void OpenCallback(string jsonData); // TypeDefIndex: 90504; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void EventCallback(string jsonData); // TypeDefIndex: 90505; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void EventListener(string jsonData); // TypeDefIndex: 90506; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public HGBulletinSDKPluginWindows(); // 0x00000001861436C0-0x00000001861436F0
	
		// Methods
		private static extern void BulletinSDK_OpenBulletin(string type, OpenCallback callback, EventListener eventListener); // 0x0000000185AFC7F0-0x0000000185AFC870
		private static extern void BulletinSDK_CloseBulletin(); // 0x000000018C215920-0x000000018C215988
		private static extern IntPtr BulletinSDK_GetRedDotState(string type); // 0x00000001859BF620-0x00000001859BF680
		private static extern void BulletinSDK_RegisterBulletinEventListener(EventCallback callback); // 0x0000000185AFBBF0-0x0000000185AFBC80
		[AOT.MonoPInvokeCallback(typeof(OpenCallback))]
		public static void InnerOpenCallBack(string jsonData); // 0x00000001850CF740-0x00000001850CF7F0
		[AOT.MonoPInvokeCallback(typeof(EventCallback))]
		public static void InnerEventCallBack(string jsonData); // 0x00000001850CF6E0-0x00000001850CF740
		[AOT.MonoPInvokeCallback(typeof(EventListener))]
		public static void InnerEventListener(string jsonData); // 0x00000001850CF620-0x00000001850CF680
		~HGBulletinSDKPluginWindows(); // 0x000000018C214074-0x000000018C2140F8
		public void Open(string type, Action<string> onResult, Action<string> eventListener); // 0x0000000185AFBDB0-0x0000000185AFBEE0
		public void Close(); // 0x000000018C215988-0x000000018C2159FC
		public string GetRedDotState(string type); // 0x00000001859BF4D0-0x00000001859BF620
		public void RegisterBulletinEventListener(Action<string> eventListener); // 0x0000000186816E10-0x0000000186816EC0
	}

	public class CloudGameUtil // TypeDefIndex: 90508
	{
		// Methods
		public static bool IsCloudGame(); // 0x00000001861450A0-0x0000000186145230
	}

	[UnityEngine.Scripting.Preserve]
	public static class HGBroserSDKConstants // TypeDefIndex: 90510
	{
		// Nested types
		public static class StatusCode // TypeDefIndex: 90509
		{
		}
	}

	public interface IHGBrowserSDKCallback // TypeDefIndex: 90511
	{
		// Methods
		void onBrowserEvent(string data);
	}

	public interface IHGBrowserSDK // TypeDefIndex: 90512
	{
		// Methods
		void Open(string url, string styleConfig, Action<string> onResult);
		void Close();
		void SetAudioConfig(string config);
	}

	public class HGBrowserSDK // TypeDefIndex: 90514
	{
		// Fields
		private static IHGBrowserSDK s_browser; // 0x00
	
		// Properties
		private static IHGBrowserSDK browserSDK { get; } // 0x0000000186143570-0x00000001861436C0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 90513
		{
			// Fields
			public IHGBrowserSDKCallback callback; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Open_b__0(string data); // 0x000000018C217620-0x000000018C21766C
		}
	
		// Methods
		public static void Open(string url, string styleConfig, IHGBrowserSDKCallback callback); // 0x000000018C2143E4-0x000000018C214524
		public static void Close(); // 0x000000018C214380-0x000000018C2143E4
		public static void SetAudioConfig(string config); // 0x0000000186143510-0x0000000186143570
	}

	public class HGBrowserSDKPluginCloud : IHGBrowserSDK // TypeDefIndex: 90516
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 90515
		{
			// Fields
			public Action<string> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Open_b__0(CloudCallResult result); // 0x000000018C2173E0-0x000000018C217620
		}
	
		// Constructors
		public HGBrowserSDKPluginCloud(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Open(string url, string styleConfig, Action<string> onResult); // 0x000000018C213900-0x000000018C213D58
		public void Close(); // 0x000000018C2136BC-0x000000018C213900
		public void SetAudioConfig(string config); // 0x000000018C213D58-0x000000018C214000
	}

	public class HGBrowserSDKPluginWindows : IHGBrowserSDK // TypeDefIndex: 90518
	{
		// Fields
		private static Action<string> outerCallback; // 0x00
	
		// Nested types
		public delegate void ExtraInfoCallback(string jsonData); // TypeDefIndex: 90517; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public HGBrowserSDKPluginWindows(); // 0x00000001861436C0-0x00000001861436F0
	
		// Methods
		private static extern void MiniWebViewSDKLoad(string url, string styleConfig, ExtraInfoCallback callback); // 0x000000018C21419C-0x000000018C21425C
		private static extern void MiniWebViewSDKClose(); // 0x000000018C214170-0x000000018C21419C
		private static extern void WebViewSDKSetAudioConfig(string config); // 0x0000000185AFD5A0-0x0000000185AFD640
		[AOT.MonoPInvokeCallback(typeof(ExtraInfoCallback))]
		public static void InnerCallBack(string jsonData); // 0x000000018C2140F8-0x000000018C214170
		~HGBrowserSDKPluginWindows(); // 0x000000018C214074-0x000000018C2140F8
		public void Open(string url, string styleConfig, Action<string> onResult); // 0x000000018C21425C-0x000000018C214380
		public void Close(); // 0x000000018C214000-0x000000018C214074
		public void SetAudioConfig(string config); // 0x0000000186143780-0x00000001861437A0
	}

	public class HGBrowerSDKTickEvent : MonoBehaviour // TypeDefIndex: 90519
	{
		// Constructors
		public HGBrowerSDKTickEvent(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Update(); // 0x0000000185AFDC30-0x0000000185AFDC60
		private static extern void WebViewSDKTickEvent(); // 0x0000000185AFDC30-0x0000000185AFDC60
	}

	public class HGBrowerSDKTickEventManager // TypeDefIndex: 90520
	{
		// Fields
		private GameObject tickGameObject; // 0x10
		private HGBrowerSDKTickEvent tickEvent; // 0x18
		private static HGBrowerSDKTickEventManager instanceMangaer; // 0x00
	
		// Properties
		public static HGBrowerSDKTickEventManager InstanceMangaer { get; } // 0x00000001861436F0-0x0000000186143780 
	
		// Constructors
		public HGBrowerSDKTickEventManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void InitTickEvent(); // 0x00000001861437A0-0x0000000186143900
		public void UnInitTickEvent(); // 0x000000018C213628-0x000000018C2136BC
	}

	public static class HGBrowserSDKVersion // TypeDefIndex: 90521
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGBrowserSDKVersion(); // 0x00000001871EA190-0x00000001871EA1F0
	}

	[UnityEngine.Scripting.Preserve]
	public class HGWebPortalState // TypeDefIndex: 90522
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("redDot")]
		public bool redDot; // 0x14
		[JsonProperty("redDotCount")]
		public int redDotCount; // 0x18
	
		// Constructors
		public HGWebPortalState(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class HGWebPortalMetadata // TypeDefIndex: 90523
	{
		// Constructors
		public HGWebPortalMetadata(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class SurveyState // TypeDefIndex: 90524
	{
		// Fields
		[JsonProperty("surveyId")]
		public string surveyId; // 0x10
		[JsonProperty("isAnswered")]
		public bool isAnswered; // 0x18
	
		// Constructors
		public SurveyState(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[UnityEngine.Scripting.Preserve]
	public class SurveyStateResult // TypeDefIndex: 90525
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("stateList")]
		public SurveyState[] stateList; // 0x18
	
		// Constructors
		public SurveyStateResult(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface IHGWebPortalSDK // TypeDefIndex: 90526
	{
		// Methods
		void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener);
		void Close();
		void OpenBrowser(string url, string styleConfig, Action<string> onResult);
		void GetWebPortalState(string target, Action<HGWebPortalState> onResult);
		void GetSurveyStatus(string surveyIds, Action<string> onResult);
	}

	public class HGWebPortalSDK // TypeDefIndex: 90528
	{
		// Fields
		private static IHGWebPortalSDK s_webportal; // 0x00
	
		// Properties
		private static IHGWebPortalSDK webportalSdk { get; } // 0x0000000185AFC9B0-0x0000000185AFCB10 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 90527
		{
			// Fields
			public Action<SurveyStateResult> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetSurveyStatus_b__0(string jsonData); // 0x00000001849105C0-0x0000000184910C10
		}
	
		// Methods
		public static void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener = null); // 0x00000001859BC710-0x00000001859BC7A0
		public static void Close(); // 0x000000018C2172D0-0x000000018C217334
		public static void OpenBrowser(string url, string styleConfig, Action<string> onResult); // 0x000000018C217334-0x000000018C2173E0
		public static void GetWebPortalState(string target, Action<HGWebPortalState> onResult); // 0x0000000185AFC950-0x0000000185AFC9B0
		public static void GetSurveyStatus(string surveyIds, Action<SurveyStateResult> onResult); // 0x0000000186CDA210-0x0000000186CDA310
		private static SurveyStateResult ParseSurveyStateResult(string jsonData); // 0x00000001861B4C80-0x00000001861B5280
	}

	public class HGWebPortalSDKPluginCloud : IHGWebPortalSDK // TypeDefIndex: 90533
	{
		// Fields
		private static Action<string> outerSchemeJumpCallback; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 90529
		{
			// Fields
			public Action<string> eventListener; // 0x10
			public Action<string> onResult; // 0x18
			public Action<CloudCallResult> eventCallback; // 0x20
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Open_b__0(CloudCallResult result); // 0x000000018C21766C-0x000000018C217874
			internal void _Open_b__1(CloudCallResult result); // 0x000000018C217874-0x000000018C217B1C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 90530
		{
			// Fields
			public Action<HGWebPortalState> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetWebPortalState_b__0(CloudCallResult result); // 0x000000018C217B1C-0x000000018C217DA8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 90531
		{
			// Fields
			public Action<string> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetSurveyStatus_b__0(CloudCallResult result); // 0x000000018C218258-0x000000018C2184AC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 90532
		{
			// Fields
			public Action<string> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OpenBrowser_b__0(CloudCallResult result); // 0x000000018C2184AC-0x000000018C2187F8
		}
	
		// Constructors
		public HGWebPortalSDKPluginCloud(); // 0x000000018C216EBC-0x000000018C216F94
	
		// Methods
		~HGWebPortalSDKPluginCloud(); // 0x000000018C215CA4-0x000000018C215DE0
		public static void InnerSchemeJumpCallBack(CloudCallResult result); // 0x000000018C2164B8-0x000000018C2165E4
		public void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener); // 0x000000018C21692C-0x000000018C216EBC
		public void Close(); // 0x000000018C215A60-0x000000018C215CA4
		public void GetWebPortalState(string target, Action<HGWebPortalState> onResult); // 0x000000018C216108-0x000000018C2164B8
		public void GetSurveyStatus(string surveyIds, Action<string> onResult); // 0x000000018C215DE0-0x000000018C216108
		public void OpenBrowser(string url, string styleConfig, Action<string> onResult); // 0x000000018C2165E4-0x000000018C21692C
	}

	public class HGWebPortalSDKPluginWindows : IHGWebPortalSDK // TypeDefIndex: 90539
	{
		// Fields
		private static Action<string> outerOpenCallback; // 0x00
		private static Action<string> outerEventListener; // 0x08
		private static Action<string> outerOpenBrowserCallback; // 0x10
		private static Action<HGWebPortalState> outerWebPortalStateCallback; // 0x18
		private static Action<string> outerWebPortalSurveyStatusCallback; // 0x20
	
		// Nested types
		public delegate void OpenCallback(string jsonData); // TypeDefIndex: 90534; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void EventListener(string jsonData); // TypeDefIndex: 90535; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void OpenBrowserCallback(string jsonData); // TypeDefIndex: 90536; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void WebPortalStateCallback(string jsonData); // TypeDefIndex: 90537; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void WebProtalSurveyStatusCallback(string jsonData); // TypeDefIndex: 90538; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public HGWebPortalSDKPluginWindows(); // 0x00000001861436C0-0x00000001861436F0
	
		// Methods
		private static extern void WebPortalSDK_Open(string target, string urlParams, OpenCallback callback, EventListener eventListener); // 0x0000000185AFC6B0-0x0000000185AFC7A0
		private static extern void WebPortalSDK_Close(); // 0x000000018C2171AC-0x000000018C217214
		private static extern void WebPortalSDK_OpenBrowser(string url, string styleConfig, OpenBrowserCallback callback); // 0x000000018C217214-0x000000018C2172D0
		private static extern void WebPortalSDK_GetWebPortalState(string target, WebPortalStateCallback callback); // 0x0000000185AFCBD0-0x0000000185AFCC30
		private static extern IntPtr WebPortalSDK_GetSurveyStatus(string surveyIds, WebProtalSurveyStatusCallback callback); // 0x0000000185AFBC80-0x0000000185AFBD40
		[AOT.MonoPInvokeCallback(typeof(OpenCallback))]
		public static void InnerOpenCallBack(string jsonData); // 0x0000000187103600-0x00000001871036B0
		[AOT.MonoPInvokeCallback(typeof(EventListener))]
		public static void InnerEventListener(string jsonData); // 0x00000001850CF680-0x00000001850CF6E0
		[AOT.MonoPInvokeCallback(typeof(OpenCallback))]
		public static void InnerOpenBrowserCallback(string jsonData); // 0x000000018C217008-0x000000018C217084
		[AOT.MonoPInvokeCallback(typeof(WebPortalStateCallback))]
		public static void InnerWebPortalStateCallback(string jsonData); // 0x00000001850CED80-0x00000001850CEE50
		[AOT.MonoPInvokeCallback(typeof(WebProtalSurveyStatusCallback))]
		public static void InnerWebPortaSurveyStatusCallback(string jsonData); // 0x000000018717CA50-0x000000018717CAE0
		~HGWebPortalSDKPluginWindows(); // 0x000000018C214074-0x000000018C2140F8
		public void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener); // 0x00000001859BAF90-0x00000001859BB0E0
		public void Close(); // 0x000000018C216F94-0x000000018C217008
		public void OpenBrowser(string url, string styleConfig, Action<string> onResult); // 0x000000018C217084-0x000000018C2171AC
		public void GetWebPortalState(string target, Action<HGWebPortalState> onResult); // 0x0000000185AFCB10-0x0000000185AFCBD0
		public void GetSurveyStatus(string surveyIds, Action<string> onResult); // 0x0000000186CDA310-0x0000000186CDA420
	}
}
