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

// Image 98: Hypergryph.Browser.dll - Assembly: Hypergryph.Browser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63133-63175
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.SDK
{
	public interface IHGBulletinSDK // TypeDefIndex: 63134
	{
		// Methods
		void Open(string type, Action<string> onResult, Action<string> eventListener);
		void Close();
		string GetRedDotState(string type);
		void RegisterBulletinEventListener(Action<string> eventListener);
	}

	public class HGBulletinSDK // TypeDefIndex: 63135
	{
		// Fields
		private static IHGBulletinSDK s_bulletin; // 0x00
	
		// Properties
		private static IHGBulletinSDK bulletinSdk { get; } // 0x00000001840BD300-0x00000001840BD460 
	
		// Methods
		public static void Open(string type, Action<string> onResult, Action<string> eventListener = null); // 0x0000000189DCE324-0x0000000189DCE3C4
		public static void Close(); // 0x0000000189DCE2C0-0x0000000189DCE324
		public static string GetRedDotState(string type); // 0x00000001840BD600-0x00000001840BD660
		public static void RegisterBulletinEventListener(Action<string> eventListener); // 0x00000001840BD2A0-0x00000001840BD300
	}

	public class HGBulletinSDKPluginCloud : IHGBulletinSDK // TypeDefIndex: 63139
	{
		// Fields
		private static Action<string> outerEventCallback; // 0x00
		private static Dictionary<string, RedDotEventData> _redDotStateDict; // 0x08
	
		// Nested types
		[UnityEngine.Scripting.Preserve]
		private class BulletinEventData // TypeDefIndex: 63136
		{
			// Fields
			[JsonProperty("eventCode")]
			public int eventCode; // 0x10
			[JsonProperty("data")]
			public JObject data; // 0x18
	
			// Constructors
			public BulletinEventData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[UnityEngine.Scripting.Preserve]
		private class RedDotEventData // TypeDefIndex: 63137
		{
			// Fields
			[JsonProperty("target")]
			public string target; // 0x10
			[JsonProperty("showRedDot")]
			public bool showRedDot; // 0x18
			[JsonProperty("showPopup")]
			public bool showPopup; // 0x19
	
			// Constructors
			public RedDotEventData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 63138
		{
			// Fields
			public Action<string> eventListener; // 0x10
			public Action<string> onResult; // 0x18
			public Action<CloudCallResult> eventCallback; // 0x20
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Open_b__0(CloudCallResult result); // 0x0000000189DD1234-0x0000000189DD1438
			internal void _Open_b__1(CloudCallResult result); // 0x0000000189DD1438-0x0000000189DD16D8
		}
	
		// Constructors
		public HGBulletinSDKPluginCloud(); // 0x0000000189DCDD78-0x0000000189DCDE64
		static HGBulletinSDKPluginCloud(); // 0x0000000189DCDCE4-0x0000000189DCDD78
	
		// Methods
		~HGBulletinSDKPluginCloud(); // 0x0000000189DCCF34-0x0000000189DCD070
		public static void InnerEventCallBack(CloudCallResult result); // 0x0000000189DCD18C-0x0000000189DCD424
		public void Open(string type, Action<string> onResult, Action<string> eventListener); // 0x0000000189DCD534-0x0000000189DCDA94
		public void Close(); // 0x0000000189DCCA88-0x0000000189DCCCC8
		public string GetRedDotState(string type); // 0x0000000189DCD070-0x0000000189DCD18C
		public void RegisterBulletinEventListener(Action<string> eventListener); // 0x0000000189DCDA94-0x0000000189DCDB20
		private void NotifySDKInstantiated(); // 0x0000000189DCD424-0x0000000189DCD534
		private static void UpdateRedDotState(string target, RedDotEventData data); // 0x0000000189DCDB20-0x0000000189DCDCE4
		private string CreateRedDotStateJson(string type, bool showRedDot, bool showPopup); // 0x0000000189DCCCC8-0x0000000189DCCF34
	}

	public class HGBulletinSDKPluginWindows : IHGBulletinSDK // TypeDefIndex: 63143
	{
		// Fields
		private static Action<string> outerOpenCallback; // 0x00
		private static Action<string> outerEventCallback; // 0x08
		private static Action<string> outerEventListener; // 0x10
	
		// Nested types
		public delegate void OpenCallback(string jsonData); // TypeDefIndex: 63140; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void EventCallback(string jsonData); // TypeDefIndex: 63141; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void EventListener(string jsonData); // TypeDefIndex: 63142; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public HGBulletinSDKPluginWindows(); // 0x00000001840BD1E0-0x00000001840BD210
	
		// Methods
		private static extern void BulletinSDK_OpenBulletin(string type, OpenCallback callback, EventListener eventListener); // 0x0000000189DCDECC-0x0000000189DCDF80
		private static extern void BulletinSDK_CloseBulletin(); // 0x0000000189DCDE64-0x0000000189DCDECC
		private static extern IntPtr BulletinSDK_GetRedDotState(string type); // 0x00000001840BD5A0-0x00000001840BD600
		private static extern void BulletinSDK_RegisterBulletinEventListener(EventCallback callback); // 0x0000000183827010-0x00000001838270A0
		[AOT.MonoPInvokeCallback(typeof(OpenCallback))]
		public static void InnerOpenCallBack(string jsonData); // 0x0000000189DCE094-0x0000000189DCE130
		[AOT.MonoPInvokeCallback(typeof(EventCallback))]
		public static void InnerEventCallBack(string jsonData); // 0x0000000189DCDFF4-0x0000000189DCE044
		[AOT.MonoPInvokeCallback(typeof(EventListener))]
		public static void InnerEventListener(string jsonData); // 0x0000000189DCE044-0x0000000189DCE094
		~HGBulletinSDKPluginWindows(); // 0x0000000189DCC5E8-0x0000000189DCC66C
		public void Open(string type, Action<string> onResult, Action<string> eventListener); // 0x0000000189DCE130-0x0000000189DCE2C0
		public void Close(); // 0x0000000189DCDF80-0x0000000189DCDFF4
		public string GetRedDotState(string type); // 0x00000001840BD460-0x00000001840BD5A0
		public void RegisterBulletinEventListener(Action<string> eventListener); // 0x0000000184A78730-0x0000000184A787E0
	}

	public class CloudGameUtil // TypeDefIndex: 63144
	{
		// Methods
		public static bool IsCloudGame(); // 0x00000001840BCB50-0x00000001840BCCE0
	}

	[UnityEngine.Scripting.Preserve]
	public static class HGBroserSDKConstants // TypeDefIndex: 63146
	{
		// Nested types
		public static class StatusCode // TypeDefIndex: 63145
		{
		}
	}

	public interface IHGBrowserSDKCallback // TypeDefIndex: 63147
	{
		// Methods
		void onBrowserEvent(string data);
	}

	public interface IHGBrowserSDK // TypeDefIndex: 63148
	{
		// Methods
		void Open(string url, string styleConfig, Action<string> onResult);
		void Close();
		void SetAudioConfig(string config);
	}

	public class HGBrowserSDK // TypeDefIndex: 63150
	{
		// Fields
		private static IHGBrowserSDK s_browser; // 0x00
	
		// Properties
		private static IHGBrowserSDK browserSDK { get; } // 0x00000001840BCEE0-0x00000001840BD030 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 63149
		{
			// Fields
			public IHGBrowserSDKCallback callback; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Open_b__0(string data); // 0x0000000189DD0AC0-0x0000000189DD0B0C
		}
	
		// Methods
		public static void Open(string url, string styleConfig, IHGBrowserSDKCallback callback); // 0x0000000189DCC954-0x0000000189DCCA88
		public static void Close(); // 0x0000000189DCC8F0-0x0000000189DCC954
		public static void SetAudioConfig(string config); // 0x00000001840BCE80-0x00000001840BCEE0
	}

	public class HGBrowserSDKPluginCloud : IHGBrowserSDK // TypeDefIndex: 63152
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 63151
		{
			// Fields
			public Action<string> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Open_b__0(CloudCallResult result); // 0x0000000189DD0884-0x0000000189DD0AC0
		}
	
		// Constructors
		public HGBrowserSDKPluginCloud(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Open(string url, string styleConfig, Action<string> onResult); // 0x0000000189DCBE7C-0x0000000189DCC2D0
		public void Close(); // 0x0000000189DCBC3C-0x0000000189DCBE7C
		public void SetAudioConfig(string config); // 0x0000000189DCC2D0-0x0000000189DCC574
	}

	public class HGBrowserSDKPluginWindows : IHGBrowserSDK // TypeDefIndex: 63154
	{
		// Fields
		private static Action<string> outerCallback; // 0x00
	
		// Nested types
		public delegate void ExtraInfoCallback(string jsonData); // TypeDefIndex: 63153; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public HGBrowserSDKPluginWindows(); // 0x00000001840BD1E0-0x00000001840BD210
	
		// Methods
		private static extern void MiniWebViewSDKLoad(string url, string styleConfig, ExtraInfoCallback callback); // 0x0000000189DCC70C-0x0000000189DCC7CC
		private static extern void MiniWebViewSDKClose(); // 0x0000000189DCC6E0-0x0000000189DCC70C
		private static extern void WebViewSDKSetAudioConfig(string config); // 0x0000000183827900-0x00000001838279A0
		[AOT.MonoPInvokeCallback(typeof(ExtraInfoCallback))]
		public static void InnerCallBack(string jsonData); // 0x0000000189DCC66C-0x0000000189DCC6E0
		~HGBrowserSDKPluginWindows(); // 0x0000000189DCC5E8-0x0000000189DCC66C
		public void Open(string url, string styleConfig, Action<string> onResult); // 0x0000000189DCC7CC-0x0000000189DCC8F0
		public void Close(); // 0x0000000189DCC574-0x0000000189DCC5E8
		public void SetAudioConfig(string config); // 0x00000001840BCE60-0x00000001840BCE80
	}

	public class HGBrowerSDKTickEvent : MonoBehaviour // TypeDefIndex: 63155
	{
		// Constructors
		public HGBrowerSDKTickEvent(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Update(); // 0x0000000183827D80-0x0000000183827DB0
		private static extern void WebViewSDKTickEvent(); // 0x0000000183827D80-0x0000000183827DB0
	}

	public class HGBrowerSDKTickEventManager // TypeDefIndex: 63156
	{
		// Fields
		private GameObject tickGameObject; // 0x10
		private HGBrowerSDKTickEvent tickEvent; // 0x18
		private static HGBrowerSDKTickEventManager instanceMangaer; // 0x00
	
		// Properties
		public static HGBrowerSDKTickEventManager InstanceMangaer { get; } // 0x00000001840BD210-0x00000001840BD2A0 
	
		// Constructors
		public HGBrowerSDKTickEventManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void InitTickEvent(); // 0x0000000184A3C610-0x0000000184A3C760
		public void UnInitTickEvent(); // 0x0000000189DCBBB0-0x0000000189DCBC3C
	}

	public static class HGBrowserSDKVersion // TypeDefIndex: 63157
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGBrowserSDKVersion(); // 0x0000000184D506E0-0x0000000184D50740
	}

	[UnityEngine.Scripting.Preserve]
	public class HGWebPortalState // TypeDefIndex: 63158
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("redDot")]
		public bool redDot; // 0x14
	
		// Constructors
		public HGWebPortalState(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class HGWebPortalMetadata // TypeDefIndex: 63159
	{
		// Constructors
		public HGWebPortalMetadata(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class SurveyState // TypeDefIndex: 63160
	{
		// Fields
		[JsonProperty("surveyId")]
		public string surveyId; // 0x10
		[JsonProperty("isAnswered")]
		public bool isAnswered; // 0x18
	
		// Constructors
		public SurveyState(); // 0x00000001841E1670-0x00000001841E1680
	}

	[UnityEngine.Scripting.Preserve]
	public class SurveyStateResult // TypeDefIndex: 63161
	{
		// Fields
		[JsonProperty("status")]
		public int status; // 0x10
		[JsonProperty("stateList")]
		public SurveyState[] stateList; // 0x18
	
		// Constructors
		public SurveyStateResult(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface IHGWebPortalSDK // TypeDefIndex: 63162
	{
		// Methods
		void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener);
		void OpenBrowser(string url, string styleConfig, Action<string> onResult);
		void GetWebPortalState(string target, Action<HGWebPortalState> onResult);
		void GetSurveyStatus(string surveyIds, Action<string> onResult);
	}

	public class HGWebPortalSDK // TypeDefIndex: 63164
	{
		// Fields
		private static IHGWebPortalSDK s_webportal; // 0x00
	
		// Properties
		private static IHGWebPortalSDK webportalSdk { get; } // 0x00000001840BD090-0x00000001840BD1E0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 63163
		{
			// Fields
			public Action<SurveyStateResult> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetSurveyStatus_b__0(string jsonData); // 0x0000000189DD1924-0x0000000189DD19C0
		}
	
		// Methods
		public static void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener = null); // 0x0000000189DD003C-0x0000000189DD00F0
		public static void OpenBrowser(string url, string styleConfig, Action<string> onResult); // 0x0000000189DCFF90-0x0000000189DD003C
		public static void GetWebPortalState(string target, Action<HGWebPortalState> onResult); // 0x00000001840BD030-0x00000001840BD090
		public static void GetSurveyStatus(string surveyIds, Action<SurveyStateResult> onResult); // 0x0000000189DCFE78-0x0000000189DCFF90
		private static SurveyStateResult ParseSurveyStateResult(string jsonData); // 0x0000000189DD00F0-0x0000000189DD0884
	}

	public class HGWebPortalSDKPluginCloud : IHGWebPortalSDK // TypeDefIndex: 63169
	{
		// Fields
		private static Action<string> outerSchemeJumpCallback; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 63165
		{
			// Fields
			public Action<string> eventListener; // 0x10
			public Action<string> onResult; // 0x18
			public Action<CloudCallResult> eventCallback; // 0x20
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Open_b__0(CloudCallResult result); // 0x0000000189DD0B0C-0x0000000189DD0D10
			internal void _Open_b__1(CloudCallResult result); // 0x0000000189DD0D10-0x0000000189DD0FB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 63166
		{
			// Fields
			public Action<HGWebPortalState> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetWebPortalState_b__0(CloudCallResult result); // 0x0000000189DD0FB0-0x0000000189DD1234
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 63167
		{
			// Fields
			public Action<string> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetSurveyStatus_b__0(CloudCallResult result); // 0x0000000189DD16D8-0x0000000189DD1924
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 63168
		{
			// Fields
			public Action<string> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OpenBrowser_b__0(CloudCallResult result); // 0x0000000189DD19C0-0x0000000189DD1D04
		}
	
		// Constructors
		public HGWebPortalSDKPluginCloud(); // 0x0000000189DCF548-0x0000000189DCF620
	
		// Methods
		~HGWebPortalSDKPluginCloud(); // 0x0000000189DCE3C4-0x0000000189DCE500
		public static void InnerSchemeJumpCallBack(CloudCallResult result); // 0x0000000189DCEB50-0x0000000189DCEC74
		public void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener); // 0x0000000189DCEFBC-0x0000000189DCF548
		public void GetWebPortalState(string target, Action<HGWebPortalState> onResult); // 0x0000000189DCE828-0x0000000189DCEB50
		public void GetSurveyStatus(string surveyIds, Action<string> onResult); // 0x0000000189DCE500-0x0000000189DCE828
		public void OpenBrowser(string url, string styleConfig, Action<string> onResult); // 0x0000000189DCEC74-0x0000000189DCEFBC
	}

	public class HGWebPortalSDKPluginWindows : IHGWebPortalSDK // TypeDefIndex: 63175
	{
		// Fields
		private static Action<string> outerOpenCallback; // 0x00
		private static Action<string> outerEventListener; // 0x08
		private static Action<string> outerOpenBrowserCallback; // 0x10
		private static Action<HGWebPortalState> outerWebPortalStateCallback; // 0x18
		private static Action<string> outerWebPortalSurveyStatusCallback; // 0x20
	
		// Nested types
		public delegate void OpenCallback(string jsonData); // TypeDefIndex: 63170; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void EventListener(string jsonData); // TypeDefIndex: 63171; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void OpenBrowserCallback(string jsonData); // TypeDefIndex: 63172; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void WebPortalStateCallback(string jsonData); // TypeDefIndex: 63173; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void WebProtalSurveyStatusCallback(string jsonData); // TypeDefIndex: 63174; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public HGWebPortalSDKPluginWindows(); // 0x00000001840BD1E0-0x00000001840BD210
	
		// Methods
		private static extern void WebPortalSDK_Open(string target, string urlParams, OpenCallback callback, EventListener eventListener); // 0x0000000189DCFDA0-0x0000000189DCFE78
		private static extern void WebPortalSDK_OpenBrowser(string url, string styleConfig, OpenBrowserCallback callback); // 0x0000000189DCFCE4-0x0000000189DCFDA0
		private static extern void WebPortalSDK_GetWebPortalState(string target, WebPortalStateCallback callback); // 0x0000000183826F60-0x0000000183827010
		private static extern IntPtr WebPortalSDK_GetSurveyStatus(string surveyIds, WebProtalSurveyStatusCallback callback); // 0x0000000189DCFC3C-0x0000000189DCFCE4
		[AOT.MonoPInvokeCallback(typeof(OpenCallback))]
		public static void InnerOpenCallBack(string jsonData); // 0x0000000189DCF854-0x0000000189DCF8F0
		[AOT.MonoPInvokeCallback(typeof(EventListener))]
		public static void InnerEventListener(string jsonData); // 0x0000000189DCF788-0x0000000189DCF7D8
		[AOT.MonoPInvokeCallback(typeof(OpenCallback))]
		public static void InnerOpenBrowserCallback(string jsonData); // 0x0000000189DCF7D8-0x0000000189DCF854
		[AOT.MonoPInvokeCallback(typeof(WebPortalStateCallback))]
		public static void InnerWebPortalStateCallback(string jsonData); // 0x0000000184B6B510-0x0000000184B6B5E0
		[AOT.MonoPInvokeCallback(typeof(WebProtalSurveyStatusCallback))]
		public static void InnerWebPortaSurveyStatusCallback(string jsonData); // 0x0000000189DCF8F0-0x0000000189DCF96C
		~HGWebPortalSDKPluginWindows(); // 0x0000000189DCC5E8-0x0000000189DCC66C
		public void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener); // 0x0000000189DCFA94-0x0000000189DCFC3C
		public void OpenBrowser(string url, string styleConfig, Action<string> onResult); // 0x0000000189DCF96C-0x0000000189DCFA94
		public void GetWebPortalState(string target, Action<HGWebPortalState> onResult); // 0x0000000184A425F0-0x0000000184A426B0
		public void GetSurveyStatus(string surveyIds, Action<string> onResult); // 0x0000000189DCF620-0x0000000189DCF788
	}
}
