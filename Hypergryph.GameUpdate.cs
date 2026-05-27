/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 145: Hypergryph.GameUpdate.dll - Assembly: Hypergryph.GameUpdate, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60148-60156

namespace Hypergryph.SDK
{
	public class HGGameUpdateCallback : MonoBehaviour // TypeDefIndex: 60151
	{
		// Fields
		private static IHGGameUpdateSDKCallback m_callback; // 0x00
		private const string gameObjectName = "(hggameupdate_callback)"; // Metadata: 0x01FDE123
		private static SynchronizationContext mainThreadContext; // 0x08
		public static HGGameUpdateCallback s_instance; // 0x10
	
		// Constructors
		public HGGameUpdateCallback() {} // 0x000000018886D504-0x000000018886D568
	
		// Methods
		public static void Init(IHGGameUpdateSDKCallback callback) {} // 0x000000018886D348-0x000000018886D504
		public void onLatestGame(string data) {} // 0x000000018886D568-0x000000018886D620
		private void runInMainTread(Action action) {} // 0x000000018886D620-0x000000018886D718
	}

	public interface IHGGameUpdateSDKCallback // TypeDefIndex: 60152
	{
		// Methods
		void onLatestGame(string data);
	}

	public interface IHGGameUpdateSDK // TypeDefIndex: 60153
	{
		// Methods
		int Init(string config);
		void GetLatestGame(Action<string> onResult);
		long Update(int updateType, bool useMobileData);
		int EnableMobileData(long taskId);
		int GetTaskState(long taskId);
		int Resume(long taskId);
		int CancelAndClear(long taskId);
		int Cancel(long taskId);
		int Install(long taskId);
		long GetDownloadSpeed(long taskId);
		long GetDownloadedSize(long taskId);
		long GetTotalDownloadSize(long taskId);
		long GetEstimatedDownloadSize(int updateType);
		int SetNotificationTitle(string titleConfig);
	}

	public static class HGGameUpdateSDK // TypeDefIndex: 60155
	{
		// Fields
		private static IHGGameUpdateSDK s_gu; // 0x00
		private static IHGGameUpdateSDKCallback m_callback; // 0x08
		private static SynchronizationContext mainThreadContext; // 0x10
	
		// Properties
		private static IHGGameUpdateSDK gameUpdateSDK { get; } // 0x000000018886E414-0x000000018886E4A8 
	
		// Methods
		public static int Init(string config, IHGGameUpdateSDKCallback callback) => default; // 0x000000018886E100-0x000000018886E200
		public static void GetLatestGame() {} // 0x000000018886DEC0-0x000000018886E000
		public static long Update(int updateType, bool useMobileData) => default; // 0x000000018886E380-0x000000018886E414
		public static int EnableMobileData(long taskId) => default; // 0x000000018886DCC0-0x000000018886DD40
		public static int GetTaskState(long taskId) => default; // 0x000000018886E000-0x000000018886E080
		public static int Resume(long taskId) => default; // 0x000000018886E280-0x000000018886E300
		public static int CancelAndClear(long taskId) => default; // 0x000000018886DBC0-0x000000018886DC40
		public static int Cancel(long taskId) => default; // 0x000000018886DC40-0x000000018886DCC0
		public static int Install(long taskId) => default; // 0x000000018886E200-0x000000018886E280
		public static long GetDownloadSpeed(long taskId) => default; // 0x000000018886DD40-0x000000018886DDC0
		public static long GetDownloadedSize(long taskId) => default; // 0x000000018886DDC0-0x000000018886DE40
		public static long GetTotalDownloadSize(long taskId) => default; // 0x000000018886E080-0x000000018886E100
		public static long GetEstimatedDownloadSize(int updateType) => default; // 0x000000018886DE40-0x000000018886DEC0
		public static int SetNotificationTitle(string titleConfig) => default; // 0x000000018886E300-0x000000018886E380
	}

	public class HGGameUpdateSDKPluginDefault : IHGGameUpdateSDK // TypeDefIndex: 60156
	{
		// Constructors
		public HGGameUpdateSDKPluginDefault() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public int Init(string config) => default; // 0x000000018886DA28-0x000000018886DA78
		public void GetLatestGame(Action<string> onResult) {} // 0x000000018886D8F8-0x000000018886D988
		public long Update(int updateType, bool useMobileData) => default; // 0x000000018886DB68-0x000000018886DBC0
		public int EnableMobileData(long taskId) => default; // 0x000000018886D7B8-0x000000018886D808
		public int GetTaskState(long taskId) => default; // 0x000000018886D988-0x000000018886D9D8
		public int Resume(long taskId) => default; // 0x000000018886DAC8-0x000000018886DB18
		public int CancelAndClear(long taskId) => default; // 0x000000018886D718-0x000000018886D768
		public int Cancel(long taskId) => default; // 0x000000018886D768-0x000000018886D7B8
		public int Install(long taskId) => default; // 0x000000018886DA78-0x000000018886DAC8
		public long GetDownloadSpeed(long taskId) => default; // 0x000000018886D808-0x000000018886D858
		public long GetDownloadedSize(long taskId) => default; // 0x000000018886D858-0x000000018886D8A8
		public long GetTotalDownloadSize(long taskId) => default; // 0x000000018886D9D8-0x000000018886DA28
		public long GetEstimatedDownloadSize(int updateType) => default; // 0x000000018886D8A8-0x000000018886D8F8
		public int SetNotificationTitle(string titleConfig) => default; // 0x000000018886DB18-0x000000018886DB68
	}
}
