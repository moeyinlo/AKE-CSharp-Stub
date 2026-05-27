/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;
using UnityEngine.Scripting;

// Image 142: Hypergryph.Browser.dll - Assembly: Hypergryph.Browser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60113-60136
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.SDK
{
	public interface IHGBulletinSDK // TypeDefIndex: 60114
	{
		// Methods
		void Open(string type, Action<string> onResult, Action<string> eventListener);
		void Close();
		string GetRedDotState(string type);
		void RegisterBulletinEventListener(Action<string> eventListener);
	}

	public class HGBulletinSDK // TypeDefIndex: 60115
	{
		// Fields
		private static IHGBulletinSDK s_bulletin; // 0x00
	
		// Properties
		private static IHGBulletinSDK bulletinSdk { get => default; } // 0x0000000182EABD60-0x0000000182EABE20 
	
		// Constructors
		public HGBulletinSDK() {} // Dummy constructor
	
		// Methods
		public static void Open(string type, Action<string> onResult, Action<string> eventListener = null) {} // 0x00000001839A23D0-0x00000001839A2460
		public static void Close() {} // 0x00000001888682D4-0x0000000188868348
		public static string GetRedDotState(string type) => default; // 0x0000000182EABCF0-0x0000000182EABD60
		public static void RegisterBulletinEventListener(Action<string> eventListener) {} // 0x0000000182EAB610-0x0000000182EAB680
	}

	public class HGBulletinSDKPluginWindows : IHGBulletinSDK // TypeDefIndex: 60119
	{
		// Fields
		private static Action<string> outerOpenCallback; // 0x00
		private static Action<string> outerEventCallback; // 0x08
		private static Action<string> outerEventListener; // 0x10
	
		// Nested types
		public delegate void OpenCallback(string jsonData); // TypeDefIndex: 60116; 0x0000000182149960-0x0000000182149970
	
		public delegate void EventCallback(string jsonData); // TypeDefIndex: 60117; 0x0000000182149960-0x0000000182149970
	
		public delegate void EventListener(string jsonData); // TypeDefIndex: 60118; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public HGBulletinSDKPluginWindows() {} // 0x0000000182EAB390-0x0000000182EAB3C0
	
		// Methods
		private static extern void BulletinSDK_OpenBulletin(string type, OpenCallback callback, EventListener eventListener); // 0x00000001822C6FA0-0x00000001822C7070
		private static extern void BulletinSDK_CloseBulletin(); // 0x00000001888681F8-0x0000000188868260
		private static extern IntPtr BulletinSDK_GetRedDotState(string type); // 0x0000000182EABE20-0x0000000182EABE80
		private static extern void BulletinSDK_RegisterBulletinEventListener(EventCallback callback); // 0x00000001822C7070-0x00000001822C7100
		[AOT.MonoPInvokeCallback(typeof(OpenCallback))]
		public static void InnerOpenCallBack(string jsonData) {} // 0x0000000183D1F5E0-0x0000000183D1F640
		[AOT.MonoPInvokeCallback(typeof(EventCallback))]
		public static void InnerEventCallBack(string jsonData) {} // 0x0000000183D1F640-0x0000000183D1F6A0
		[AOT.MonoPInvokeCallback(typeof(EventListener))]
		public static void InnerEventListener(string jsonData) {} // 0x0000000183D1E500-0x0000000183D1E560
		~HGBulletinSDKPluginWindows() {} // 0x0000000188867D78-0x0000000188867DFC
		public void Open(string type, Action<string> onResult, Action<string> eventListener) {} // 0x00000001839A2460-0x00000001839A2590
		public void Close() {} // 0x0000000188868260-0x00000001888682D4
		public string GetRedDotState(string type) => default; // 0x0000000182EAC1F0-0x0000000182EAC330
		public void RegisterBulletinEventListener(Action<string> eventListener) {} // 0x0000000182EAAE10-0x0000000182EAAEC0
	}

	[UnityEngine.Scripting.Preserve]
	public static class HGBroserSDKConstants // TypeDefIndex: 60121
	{
		// Nested types
		public static class StatusCode // TypeDefIndex: 60120
		{
		}
	}

	public interface IHGBrowserSDKCallback // TypeDefIndex: 60122
	{
		// Methods
		void onBrowserEvent(string data);
	}

	public interface IHGBrowserSDK // TypeDefIndex: 60123
	{
		// Methods
		void Open(string url, string styleConfig, Action<string> onResult);
		void Close();
		void SetAudioConfig(string config);
	}

	public class HGBrowserSDK // TypeDefIndex: 60125
	{
		// Fields
		private static IHGBrowserSDK s_browser; // 0x00
	
		// Properties
		private static IHGBrowserSDK browserSDK { get => default; } // 0x0000000182EAB2E0-0x0000000182EAB390 
	
		// Constructors
		public HGBrowserSDK() {} // Dummy constructor
	
		// Methods
		public static void Open(string url, string styleConfig, IHGBrowserSDKCallback callback) {} // 0x00000001888680D0-0x00000001888681F8
		public static void Close() {} // 0x000000018886805C-0x00000001888680D0
		public static void SetAudioConfig(string config) {} // 0x0000000182EAB270-0x0000000182EAB2E0
	}

	public class HGBrowserSDKPluginWindows : IHGBrowserSDK // TypeDefIndex: 60127
	{
		// Fields
		private static Action<string> outerCallback; // 0x00
	
		// Nested types
		public delegate void ExtraInfoCallback(string jsonData); // TypeDefIndex: 60126; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public HGBrowserSDKPluginWindows() {} // 0x0000000182EAB390-0x0000000182EAB3C0
	
		// Methods
		private static extern void MiniWebViewSDKLoad(string url, string styleConfig, ExtraInfoCallback callback); // 0x0000000188867E78-0x0000000188867F38
		private static extern void MiniWebViewSDKClose(); // 0x0000000188867E4C-0x0000000188867E78
		private static extern void WebViewSDKSetAudioConfig(string config); // 0x00000001822C80A0-0x00000001822C8140
		[AOT.MonoPInvokeCallback(typeof(ExtraInfoCallback))]
		public static void InnerCallBack(string jsonData) {} // 0x0000000188867DFC-0x0000000188867E4C
		~HGBrowserSDKPluginWindows() {} // 0x0000000188867D78-0x0000000188867DFC
		public void Open(string url, string styleConfig, Action<string> onResult) {} // 0x0000000188867F38-0x000000018886805C
		public void Close() {} // 0x0000000188867D04-0x0000000188867D78
		public void SetAudioConfig(string config) {} // 0x0000000182EAB250-0x0000000182EAB270
	}

	public class HGBrowerSDKTickEvent : MonoBehaviour // TypeDefIndex: 60128
	{
		// Constructors
		public HGBrowerSDKTickEvent() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Update() {} // 0x00000001822C84F0-0x00000001822C8500
		private static extern void WebViewSDKTickEvent(); // 0x00000001822C8500-0x00000001822C8530
	}

	public class HGBrowerSDKTickEventManager // TypeDefIndex: 60129
	{
		// Fields
		private GameObject tickGameObject; // 0x10
		private HGBrowerSDKTickEvent tickEvent; // 0x18
		private static HGBrowerSDKTickEventManager instanceMangaer; // 0x00
	
		// Properties
		public static HGBrowerSDKTickEventManager InstanceMangaer { get => default; } // 0x0000000182EAB3C0-0x0000000182EAB450 
	
		// Constructors
		public HGBrowerSDKTickEventManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void InitTickEvent() {} // 0x0000000182EAAD00-0x0000000182EAAE10
		public void UnInitTickEvent() {} // 0x0000000188867C78-0x0000000188867D04
	}

	[UnityEngine.Scripting.Preserve]
	public class HGWebPortalState // TypeDefIndex: 60130
	{
		// Constructors
		public HGWebPortalState() {} // 0x000000018350B670-0x000000018350B680
	}

	[UnityEngine.Scripting.Preserve]
	public class HGWebPortalMetadata // TypeDefIndex: 60131
	{
		// Constructors
		public HGWebPortalMetadata() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface IHGWebPortalSDK // TypeDefIndex: 60132
	{
		// Methods
		void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener);
	}

	public class HGWebPortalSDK // TypeDefIndex: 60133
	{
		// Fields
		private static IHGWebPortalSDK s_webportal; // 0x00
	
		// Properties
		private static IHGWebPortalSDK webportalSdk { get => default; } // 0x00000001888686C8-0x000000018886876C 
	
		// Constructors
		public HGWebPortalSDK() {} // Dummy constructor
	
		// Methods
		public static void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener = null) {} // 0x0000000188868668-0x00000001888686C8
	}

	public class HGWebPortalSDKPluginWindows : IHGWebPortalSDK // TypeDefIndex: 60136
	{
		// Fields
		private static Action<string> outerOpenCallback; // 0x00
		private static Action<string> outerEventListener; // 0x08
	
		// Nested types
		public delegate void OpenCallback(string jsonData); // TypeDefIndex: 60134; 0x0000000182149960-0x0000000182149970
	
		public delegate void EventListener(string jsonData); // TypeDefIndex: 60135; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public HGWebPortalSDKPluginWindows() {} // 0x0000000182EAB390-0x0000000182EAB3C0
	
		// Methods
		private static extern void WebPortalSDK_Open(string target, string urlParams, OpenCallback callback, EventListener eventListener); // 0x0000000188868590-0x0000000188868668
		[AOT.MonoPInvokeCallback(typeof(OpenCallback))]
		public static void InnerOpenCallBack(string jsonData) {} // 0x0000000188868398-0x00000001888683E8
		[AOT.MonoPInvokeCallback(typeof(EventListener))]
		public static void InnerEventListener(string jsonData) {} // 0x0000000188868348-0x0000000188868398
		~HGWebPortalSDKPluginWindows() {} // 0x0000000188867D78-0x0000000188867DFC
		public void Open(string target, string urlParams, Action<string> onResult, Action<string> eventListener) {} // 0x00000001888683E8-0x0000000188868590
	}
}
