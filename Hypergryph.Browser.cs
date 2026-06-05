/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Hypergryph.CloudClientBridge;
using Newtonsoft.Json.Linq;
using UnityEngine;

// Image 96: Hypergryph.Browser.dll - Assembly: Hypergryph.Browser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60519-60556

namespace Hypergryph.SDK
{
	public interface IHGBulletinSDK // TypeDefIndex: 60520
	{
		// Methods
		void Open(string type, Action<string> onResult, Action<string> eventListener);
		void Close();
		string GetRedDotState(string type);
		void RegisterBulletinEventListener(Action<string> eventListener);
	}

	public class HGBulletinSDK // TypeDefIndex: 60521
	{
		// Fields
		private static IHGBulletinSDK s_bulletin; // 0x00
	
		// Properties
		private static IHGBulletinSDK bulletinSdk { get => default; } // 0x000000018458C1C0-0x000000018458D4F0 
	
		// Constructors
		public HGBulletinSDK() {} // Dummy constructor
	
		// Methods
		public static void Open(string type, Action<string> onResult, Action<string> eventListener = null) {} // 0x0000000185C3C840-0x0000000185C3CC50
		public static void Close() {} // 0x000000018A97B458-0x000000018A97B4DC
		public static string GetRedDotState(string type) => default; // 0x000000018458D570-0x000000018458D5A0
		public static void RegisterBulletinEventListener(Action<string> eventListener) {} // 0x000000018458B8B0-0x000000018458B8E0
	}

	public class HGBulletinSDKPluginCloud : IHGBulletinSDK // TypeDefIndex: 60525
	{
		// Fields
		private static Action<string> outerEventCallback; // 0x00
		private static Dictionary<string, RedDotEventData> _redDotStateDict; // 0x08
	
		// Nested types
		private class BulletinEventData // TypeDefIndex: 60522
		{
			// Fields
			public int eventCode; // 0x10
			public JObject data; // 0x18
	
			// Constructors
			public BulletinEventData() {} // 0x00000001839262F0-0x0000000183927330
		}
	
		private class RedDotEventData // TypeDefIndex: 60523
		{
			// Fields
			public string target; // 0x10
			public bool showRedDot; // 0x18
			public bool showPopup; // 0x19
	
			// Constructors
			public RedDotEventData() {} // 0x000000018391C2C0-0x000000018391D350
		}
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 60524
		{
			// Fields
			public Action<string> eventListener; // 0x10
			public Action<string> onResult; // 0x18
			public Action<CloudCallResult> eventCallback; // 0x20
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018391E2B0-0x000000018391F8C0
	
			// Methods
			internal void _Open_b__0(CloudCallResult result) {} // 0x0000000183920C90-0x00000001839237E0
			internal void _Open_b__1(CloudCallResult result) {} // 0x0000000183918A70-0x000000018391A880
		}
	
		// Constructors
		public HGBulletinSDKPluginCloud() {} // 0x000000018391D350-0x000000018391E2B0
		static HGBulletinSDKPluginCloud() {} // 0x000000018393C640-0x000000018393E6F0
	
		// Methods
		~HGBulletinSDKPluginCloud() {} // 0x00000001839237E0-0x0000000183924650
		public static void InnerEventCallBack(CloudCallResult result) {} // 0x000000018391F8C0-0x0000000183920C90
		public void Open(string type, Action<string> onResult, Action<string> eventListener) {} // 0x0000000183924650-0x0000000183925A30
		public void Close() {} // 0x000000018391A880-0x000000018391C2C0
		public string GetRedDotState(string type) => default; // 0x0000000183925A30-0x00000001839262F0
		public void RegisterBulletinEventListener(Action<string> eventListener) {} // 0x0000000185492010-0x0000000185492020
		private void NotifySDKInstantiated() {} // 0x0000000185492010-0x0000000185492020
		private static void UpdateRedDotState(string target, RedDotEventData data) {} // 0x0000000185492010-0x0000000185492020
		private string CreateRedDotStateJson(string type, bool showRedDot, bool showPopup) => default; // 0x000000018393AD50-0x000000018393C640
	}

	public class HGBulletinSDKPluginWindows : IHGBulletinSDK // TypeDefIndex: 60529
	{
		// Fields
		private static Action<string> outerOpenCallback; // 0x00
		private static Action<string> outerEventCallback; // 0x08
		private static Action<string> outerEventListener; // 0x10
	
		// Nested types
		public delegate void OpenCallback(string jsonData); // TypeDefIndex: 60526; 0x000000018A97B37C-0x000000018A97B3E4
	
		public delegate void EventCallback(string jsonData); // TypeDefIndex: 60527; 0x00000001844CE410-0x00000001844CE4A0
	
		public delegate void EventListener(string jsonData); // TypeDefIndex: 60528; 0x0000000185F7E7E0-0x0000000185F7E840
	
		// Constructors
		public HGBulletinSDKPluginWindows() {} // 0x0000000185C3CD80-0x0000000185C3CE00
	
		// Methods
		private static extern void BulletinSDK_OpenBulletin(string type, OpenCallback callback, EventListener eventListener); // 0x0000000184EE5980-0x0000000184EE59E0
		private static extern void BulletinSDK_CloseBulletin(); // 0x000000018458B7F0-0x000000018458B820
		private static extern IntPtr BulletinSDK_GetRedDotState(string type); // 0x000000018A97AEE0-0x000000018A97AF64
		private static extern void BulletinSDK_RegisterBulletinEventListener(EventCallback callback); // 0x0000000185C3CC50-0x0000000185C3CD80
		public static void InnerOpenCallBack(string jsonData) {} // 0x000000018A97B3E4-0x000000018A97B458
		public static void InnerEventCallBack(string jsonData) {} // 0x0000000184B4A350-0x0000000184B4A490
		public static void InnerEventListener(string jsonData) {} // 0x000000018458A1C0-0x000000018458A270
		~HGBulletinSDKPluginWindows() {} // 0x00000001833EEC70-0x00000001833EEC80
		public void Open(string type, Action<string> onResult, Action<string> eventListener) {} // 0x000000018458A270-0x000000018458A300
		public void Close() {} // 0x00000001833EEC70-0x00000001833EEC80
		public string GetRedDotState(string type) => default; // 0x0000000185C3CD80-0x0000000185C3CE00
		public void RegisterBulletinEventListener(Action<string> eventListener) {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public class CloudGameUtil // TypeDefIndex: 60530
	{
		// Constructors
		public CloudGameUtil() {} // Dummy constructor
	
		// Methods
		public static bool IsCloudGame() => default; // 0x0000000183910FA0-0x0000000183912260
	}

	public static class HGBroserSDKConstants // TypeDefIndex: 60532
	{
		// Nested types
		public static class StatusCode // TypeDefIndex: 60531
		{
		}
	}

	public interface IHGBrowserSDKCallback // TypeDefIndex: 60533
	{
		// Methods
		void onBrowserEvent(string data);
	}

	public interface IHGBrowserSDK // TypeDefIndex: 60534
	{
		// Methods
		void Open(string url, string styleConfig, Action<string> onResult);
		void Close();
		void SetAudioConfig(string config);
	}

	public class HGBrowserSDK // TypeDefIndex: 60536
	{
		// Fields
		private static IHGBrowserSDK s_browser; // 0x00
	
		// Properties
		private static IHGBrowserSDK browserSDK { get => default; } // 0x000000018A97B224-0x000000018A97B2A8 
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 60535
		{
			// Fields
			public IHGBrowserSDKCallback callback; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018458A810-0x000000018458B7F0
	
			// Methods
			internal void _Open_b__0(string data) {} // 0x000000018A97B2A8-0x000000018A97B37C
		}
	
		// Constructors
		public HGBrowserSDK() {} // Dummy constructor
	
		// Methods
		public static void Open(string url, string styleConfig, IHGBrowserSDKCallback callback) {} // 0x000000018458A7E0-0x000000018458A810
		public static void Close() {} // 0x0000000185492010-0x0000000185492020
		public static void SetAudioConfig(string config) {} // 0x000000018A97BCE8-0x000000018A97C050
	}

	public class HGBrowserSDKPluginCloud : IHGBrowserSDK // TypeDefIndex: 60538
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 60537
		{
			// Fields
			public Action<string> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x0000000183914070-0x00000001839165F0
	
			// Methods
			internal void _Open_b__0(CloudCallResult result) {} // 0x0000000183912260-0x0000000183914070
		}
	
		// Constructors
		public HGBrowserSDKPluginCloud() {} // 0x0000000183934340-0x0000000183935F10
	
		// Methods
		public void Open(string url, string styleConfig, Action<string> onResult) {} // 0x00000001839165F0-0x0000000183918460
		public void Close() {} // 0x0000000185492010-0x0000000185492020
		public void SetAudioConfig(string config) {} // 0x0000000185492010-0x0000000185492020
	}

	public class HGBrowserSDKPluginWindows : IHGBrowserSDK // TypeDefIndex: 60540
	{
		// Fields
		private static Action<string> outerCallback; // 0x00
	
		// Nested types
		public delegate void ExtraInfoCallback(string jsonData); // TypeDefIndex: 60539; 0x000000018A97B014-0x000000018A97B040
	
		// Constructors
		public HGBrowserSDKPluginWindows() {} // 0x000000018A97B100-0x000000018A97B224
	
		// Methods
		private static extern void MiniWebViewSDKLoad(string url, string styleConfig, ExtraInfoCallback callback); // 0x00000001844CEDD0-0x00000001844CEE70
		private static extern void MiniWebViewSDKClose(); // 0x000000018A97AF64-0x000000018A97B014
		private static extern void WebViewSDKSetAudioConfig(string config); // 0x000000018458B7F0-0x000000018458B820
		public static void InnerCallBack(string jsonData) {} // 0x000000018A97AEE0-0x000000018A97AF64
		~HGBrowserSDKPluginWindows() {} // 0x000000018A97AE6C-0x000000018A97AEE0
		public void Open(string url, string styleConfig, Action<string> onResult) {} // 0x0000000184589E50-0x000000018458A1C0
		public void Close() {} // 0x0000000187759874-0x0000000187759948
		public void SetAudioConfig(string config) {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public class HGBrowerSDKTickEvent : MonoBehaviour // TypeDefIndex: 60541
	{
		// Constructors
		public HGBrowerSDKTickEvent() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Update() {} // 0x00000001844CF250-0x00000001844CF260
		private static extern void WebViewSDKTickEvent(); // 0x00000001844CF260-0x00000001844CF290
	}

	public class HGBrowerSDKTickEventManager // TypeDefIndex: 60542
	{
		// Fields
		private GameObject tickGameObject; // 0x10
		private HGBrowerSDKTickEvent tickEvent; // 0x18
		private static HGBrowerSDKTickEventManager instanceMangaer; // 0x00
	
		// Properties
		public static HGBrowerSDKTickEventManager InstanceMangaer { get => default; } // 0x000000018458B820-0x000000018458B8B0 
	
		// Constructors
		public HGBrowerSDKTickEventManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void InitTickEvent() {} // 0x000000018458A300-0x000000018458A410
		public void UnInitTickEvent() {} // 0x000000018A97ADE0-0x000000018A97AE6C
	}

	public static class HGBrowserSDKVersion // TypeDefIndex: 60543
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGBrowserSDKVersion() {} // 0x0000000183918460-0x0000000183918A70
	}

	public class HGWebPortalState // TypeDefIndex: 60544
	{
		// Fields
		public int status; // 0x10
		public bool redDot; // 0x14
	
		// Constructors
		public HGWebPortalState() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HGWebPortalMetadata // TypeDefIndex: 60545
	{
		// Constructors
		public HGWebPortalMetadata() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface IHGWebPortalSDK // TypeDefIndex: 60546
	{
		// Methods
		void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener);
		void OpenBrowser(string url, string styleConfig, Action<string> onResult);
		void GetWebPortalState(string target, Action<HGWebPortalState> onResult);
	}

	public class HGWebPortalSDK // TypeDefIndex: 60547
	{
		// Fields
		private static IHGWebPortalSDK s_webportal; // 0x00
	
		// Properties
		private static IHGWebPortalSDK webportalSdk { get => default; } // 0x000000018A97B930-0x000000018A97BCE8 
	
		// Constructors
		public HGWebPortalSDK() {} // Dummy constructor
	
		// Methods
		public static void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener = null) {} // 0x000000018A97B8D0-0x000000018A97B930
		public static void OpenBrowser(string url, string styleConfig, Action<string> onResult) {} // 0x00000001839342F0-0x0000000183934340
		public static void GetWebPortalState(string target, Action<HGWebPortalState> onResult) {} // 0x00000001839342B0-0x00000001839342F0
	}

	public class HGWebPortalSDKPluginCloud : IHGWebPortalSDK // TypeDefIndex: 60551
	{
		// Fields
		private static Action<string> outerSchemeJumpCallback; // 0x00
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 60548
		{
			// Fields
			public Action<string> eventListener; // 0x10
			public Action<string> onResult; // 0x18
			public Action<CloudCallResult> eventCallback; // 0x20
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x0000000183930830-0x0000000183931860
	
			// Methods
			internal void _Open_b__0(CloudCallResult result) {} // 0x0000000183927330-0x00000001839283C0
			internal void _Open_b__1(CloudCallResult result) {} // 0x000000018392A6D0-0x000000018392B6F0
		}
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 60549
		{
			// Fields
			public Action<HGWebPortalState> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018392DB60-0x0000000183930830
	
			// Methods
			internal void _GetWebPortalState_b__0(CloudCallResult result) {} // 0x00000001839283C0-0x000000018392A6D0
		}
	
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 60550
		{
			// Fields
			public Action<string> onResult; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018392B6F0-0x000000018392DB60
	
			// Methods
			internal void _OpenBrowser_b__0(CloudCallResult result) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public HGWebPortalSDKPluginCloud() {} // 0x0000000183935F10-0x0000000183937800
	
		// Methods
		~HGWebPortalSDKPluginCloud() {} // 0x0000000183937800-0x00000001839398B0
		public static void InnerSchemeJumpCallBack(CloudCallResult result) {} // 0x0000000185492010-0x0000000185492020
		public void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener) {} // 0x00000001839398B0-0x000000018393AD50
		public void GetWebPortalState(string target, Action<HGWebPortalState> onResult) {} // 0x0000000185492010-0x0000000185492020
		public void OpenBrowser(string url, string styleConfig, Action<string> onResult) {} // 0x000000018393E6F0-0x0000000183940B40
	}

	public class HGWebPortalSDKPluginWindows : IHGWebPortalSDK // TypeDefIndex: 60556
	{
		// Fields
		private static Action<string> outerOpenCallback; // 0x00
		private static Action<string> outerEventListener; // 0x08
		private static Action<string> outerOpenBrowserCallback; // 0x10
		private static Action<HGWebPortalState> outerWebPortalStateCallback; // 0x18
	
		// Nested types
		public delegate void OpenCallback(string jsonData); // TypeDefIndex: 60552; 0x0000000183934080-0x00000001839342B0
	
		public delegate void EventListener(string jsonData); // TypeDefIndex: 60553; 0x000000018A97B52C-0x000000018A97B650
	
		public delegate void OpenBrowserCallback(string jsonData); // TypeDefIndex: 60554; 0x0000000183932470-0x00000001839327F0
	
		public delegate void WebPortalStateCallback(string jsonData); // TypeDefIndex: 60555; 0x000000018458B7F0-0x000000018458B820
	
		// Constructors
		public HGWebPortalSDKPluginWindows() {} // 0x00000001833EEC70-0x00000001833EEC80
	
		// Methods
		private static extern void WebPortalSDK_Open(string target, string urlParams, OpenCallback callback, EventListener eventListener); // 0x000000018A97AEE0-0x000000018A97AF64
		private static extern void WebPortalSDK_OpenBrowser(string url, string styleConfig, OpenBrowserCallback callback); // 0x000000018A97B650-0x000000018A97B7F8
		private static extern void WebPortalSDK_GetWebPortalState(string target, WebPortalStateCallback callback); // 0x0000000183933450-0x0000000183933F00
		public static void InnerOpenCallBack(string jsonData) {} // 0x0000000183931860-0x0000000183932470
		public static void InnerEventListener(string jsonData) {} // 0x0000000187759874-0x0000000187759948
		public static void InnerOpenBrowserCallback(string jsonData) {} // 0x00000001833EEC70-0x00000001833EEC80
		public static void InnerWebPortalStateCallback(string jsonData) {} // 0x0000000187759874-0x0000000187759948
		~HGWebPortalSDKPluginWindows() {} // 0x00000001834FEF90-0x00000001834FF0D0
		public void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener) {} // 0x00000001833EEC70-0x00000001833EEC80
		public void OpenBrowser(string url, string styleConfig, Action<string> onResult) {} // 0x00000001834FEF90-0x00000001834FF0D0
		public void GetWebPortalState(string target, Action<HGWebPortalState> onResult) {} // 0x00000001833EEC70-0x00000001833EEC80
	}
}
