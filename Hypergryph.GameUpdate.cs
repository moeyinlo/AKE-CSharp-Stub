/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Threading;
using UnityEngine;

// Image 147: Hypergryph.GameUpdate.dll - Assembly: Hypergryph.GameUpdate, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61233-61241

namespace Hypergryph.SDK
{
	public class HGGameUpdateCallback : MonoBehaviour // TypeDefIndex: 61236
	{
		// Fields
		private static IHGGameUpdateSDKCallback m_callback; // 0x00
		private const string gameObjectName = "(hggameupdate_callback)"; // Metadata: 0x02083A28
		private static SynchronizationContext mainThreadContext; // 0x08
		public static HGGameUpdateCallback s_instance; // 0x10
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 61234
		{
			// Fields
			public string data; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x000000018A980EB4-0x000000018A980F18
	
			// Methods
			internal void _onLatestGame_b__0() {} // 0x000000018A980CF8-0x000000018A980EB4
		}
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 61235
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018A980F18-0x000000018A980FD0
	
			// Methods
			internal void _runInMainTread_b__0(object p) {} // 0x000000018A980FD0-0x000000018A9810C8
		}
	
		// Constructors
		public HGGameUpdateCallback() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void Init(IHGGameUpdateSDKCallback callback) {} // 0x000000018A981EF4-0x000000018A981F44
		public void onLatestGame(string data) {} // 0x0000000185492010-0x0000000185492020
		private void runInMainTread(Action action) {} // 0x0000000188052F20-0x0000000188052F3C
	}

	public interface IHGGameUpdateSDKCallback // TypeDefIndex: 61237
	{
		// Methods
		void onLatestGame(string data);
	}

	public interface IHGGameUpdateSDK // TypeDefIndex: 61238
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

	public static class HGGameUpdateSDK // TypeDefIndex: 61240
	{
		// Fields
		private static IHGGameUpdateSDK s_gu; // 0x00
		private static IHGGameUpdateSDKCallback m_callback; // 0x08
		private static SynchronizationContext mainThreadContext; // 0x10
	
		// Properties
		private static IHGGameUpdateSDK gameUpdateSDK { get; } // 0x000000018A981D30-0x000000018A981DC4 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 61239
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<string> __9__6_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018A981DC4-0x000000018A981E58
			public __c() {} // 0x000000018A981AB0-0x000000018A981BB0
	
			// Methods
			internal void _GetLatestGame_b__6_0(string result) {} // 0x000000018A981870-0x000000018A9819B0
		}
	
		// Methods
		public static int Init(string config, IHGGameUpdateSDKCallback callback) => default; // 0x000000018A981670-0x000000018A9816F0
		public static void GetLatestGame() {} // 0x000000018A9819B0-0x000000018A981A30
		public static long Update(int updateType, bool useMobileData) => default; // 0x000000018A981C30-0x000000018A981CB0
		public static int EnableMobileData(long taskId) => default; // 0x000000018A981570-0x000000018A9815F0
		public static int GetTaskState(long taskId) => default; // 0x000000018A9815F0-0x000000018A981670
		public static int Resume(long taskId) => default; // 0x000000018A981BB0-0x000000018A981C30
		public static int CancelAndClear(long taskId) => default; // 0x000000018A9816F0-0x000000018A981770
		public static int Cancel(long taskId) => default; // 0x000000018A981770-0x000000018A9817F0
		public static int Install(long taskId) => default; // 0x000000018A981A30-0x000000018A981AB0
		public static long GetDownloadSpeed(long taskId) => default; // 0x000000018A9817F0-0x000000018A981870
		public static long GetDownloadedSize(long taskId) => default; // 0x000000018A981CB0-0x000000018A981D30
		public static long GetTotalDownloadSize(long taskId) => default; // 0x000000018A981F44-0x000000018A981FF8
		public static long GetEstimatedDownloadSize(int updateType) => default; // 0x0000000185492010-0x0000000185492020
		public static int SetNotificationTitle(string titleConfig) => default; // 0x000000018A981E58-0x000000018A981EF4
	}

	public class HGGameUpdateSDKPluginDefault : IHGGameUpdateSDK // TypeDefIndex: 61241
	{
		// Constructors
		public HGGameUpdateSDKPluginDefault() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public int Init(string config) => default; // 0x000000018A9813D8-0x000000018A981428
		public void GetLatestGame(Action<string> onResult) {} // 0x000000018A9812A8-0x000000018A981338
		public long Update(int updateType, bool useMobileData) => default; // 0x000000018A981518-0x000000018A981570
		public int EnableMobileData(long taskId) => default; // 0x000000018A981168-0x000000018A9811B8
		public int GetTaskState(long taskId) => default; // 0x000000018A981338-0x000000018A981388
		public int Resume(long taskId) => default; // 0x000000018A981478-0x000000018A9814C8
		public int CancelAndClear(long taskId) => default; // 0x000000018A9810C8-0x000000018A981118
		public int Cancel(long taskId) => default; // 0x000000018A981118-0x000000018A981168
		public int Install(long taskId) => default; // 0x000000018A981428-0x000000018A981478
		public long GetDownloadSpeed(long taskId) => default; // 0x000000018A9811B8-0x000000018A981208
		public long GetDownloadedSize(long taskId) => default; // 0x000000018A981208-0x000000018A981258
		public long GetTotalDownloadSize(long taskId) => default; // 0x000000018A981388-0x000000018A9813D8
		public long GetEstimatedDownloadSize(int updateType) => default; // 0x000000018A981258-0x000000018A9812A8
		public int SetNotificationTitle(string titleConfig) => default; // 0x000000018A9814C8-0x000000018A981518
	}
}
