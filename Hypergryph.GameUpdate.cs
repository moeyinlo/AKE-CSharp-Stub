/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 149: Hypergryph.GameUpdate.dll - Assembly: Hypergryph.GameUpdate, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91343-91351

namespace Hypergryph.SDK
{
	public class HGGameUpdateCallback : MonoBehaviour // TypeDefIndex: 91346
	{
		// Fields
		private static IHGGameUpdateSDKCallback m_callback; // 0x00
		private const string gameObjectName = "(hggameupdate_callback)"; // Metadata: 0x0264C032
		private static SynchronizationContext mainThreadContext; // 0x08
		public static HGGameUpdateCallback s_instance; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 91344
		{
			// Fields
			public string data; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _onLatestGame_b__0(); // 0x000000018C22B650-0x000000018C22B6A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 91345
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _runInMainTread_b__0(object p); // 0x00000001890ADBF0-0x00000001890ADC0C
		}
	
		// Constructors
		public HGGameUpdateCallback(); // 0x000000018C22A388-0x000000018C22A3EC
	
		// Methods
		public static void Init(IHGGameUpdateSDKCallback callback); // 0x000000018C22A1CC-0x000000018C22A388
		public void onLatestGame(string data); // 0x000000018C22A3EC-0x000000018C22A4A4
		private void runInMainTread(Action action); // 0x000000018C22A4A4-0x000000018C22A59C
	}

	public interface IHGGameUpdateSDKCallback // TypeDefIndex: 91347
	{
		// Methods
		void onLatestGame(string data);
	}

	public interface IHGGameUpdateSDK // TypeDefIndex: 91348
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
		long Preload(bool useMobileData);
		long ApplyPreload(string baseFilePathList, string desPath);
		long GetEstimatedPreloadDownloadSize();
		int GetApplyPreloadProgress(long taskId);
		int Finish(long taskId);
	}

	public static class HGGameUpdateSDK // TypeDefIndex: 91350
	{
		// Fields
		private static IHGGameUpdateSDK s_gu; // 0x00
		private static IHGGameUpdateSDKCallback m_callback; // 0x08
		private static SynchronizationContext mainThreadContext; // 0x10
	
		// Properties
		private static IHGGameUpdateSDK gameUpdateSDK { get; } // 0x000000018C22B520-0x000000018C22B5B4 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 91349
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<string> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C22B6A0-0x000000018C22B754
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetLatestGame_b__6_0(string result); // 0x000000018C22B5B4-0x000000018C22B650
		}
	
		// Methods
		public static int Init(string config, IHGGameUpdateSDKCallback callback); // 0x000000018C22B250-0x000000018C22B334
		public static void GetLatestGame(); // 0x000000018C22B070-0x000000018C22B190
		public static long Update(int updateType, bool useMobileData); // 0x000000018C22B4B4-0x000000018C22B520
		public static int EnableMobileData(long taskId); // 0x000000018C22ADE0-0x000000018C22AE40
		public static int GetTaskState(long taskId); // 0x000000018C22B190-0x000000018C22B1F0
		public static int Resume(long taskId); // 0x000000018C22B3F4-0x000000018C22B454
		public static int CancelAndClear(long taskId); // 0x000000018C22AD20-0x000000018C22AD80
		public static int Cancel(long taskId); // 0x000000018C22AD80-0x000000018C22ADE0
		public static int Install(long taskId); // 0x000000018C22B334-0x000000018C22B394
		public static long GetDownloadSpeed(long taskId); // 0x000000018C22AF00-0x000000018C22AF60
		public static long GetDownloadedSize(long taskId); // 0x000000018C22AF60-0x000000018C22AFC0
		public static long GetTotalDownloadSize(long taskId); // 0x000000018C22B1F0-0x000000018C22B250
		public static long GetEstimatedDownloadSize(int updateType); // 0x000000018C22AFC0-0x000000018C22B020
		public static int SetNotificationTitle(string titleConfig); // 0x000000018C22B454-0x000000018C22B4B4
		public static long Preload(bool useMobileData); // 0x000000018C22B394-0x000000018C22B3F4
		public static long ApplyPreload(string baseFilePathList, string desPath); // 0x000000018C22ACB0-0x000000018C22AD20
		public static long GetEstimatedPreloadDownloadSize(); // 0x000000018C22B020-0x000000018C22B070
		public static int GetApplyPreloadProgress(long taskId); // 0x000000018C22AEA0-0x000000018C22AF00
		public static int Finish(long taskId); // 0x000000018C22AE40-0x000000018C22AEA0
	}

	public class HGGameUpdateSDKPluginDefault : IHGGameUpdateSDK // TypeDefIndex: 91351
	{
		// Constructors
		public HGGameUpdateSDKPluginDefault(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public int Init(string config); // 0x000000018C22AA9C-0x000000018C22AAEC
		public void GetLatestGame(Action<string> onResult); // 0x000000018C22A96C-0x000000018C22A9FC
		public long Update(int updateType, bool useMobileData); // 0x000000018C22AC58-0x000000018C22ACB0
		public int EnableMobileData(long taskId); // 0x000000018C22A6B8-0x000000018C22A708
		public int GetTaskState(long taskId); // 0x000000018C22A9FC-0x000000018C22AA4C
		public int Resume(long taskId); // 0x000000018C22ABB8-0x000000018C22AC08
		public int CancelAndClear(long taskId); // 0x000000018C22A618-0x000000018C22A668
		public int Cancel(long taskId); // 0x000000018C22A668-0x000000018C22A6B8
		public int Install(long taskId); // 0x000000018C22AAEC-0x000000018C22AB3C
		public long GetDownloadSpeed(long taskId); // 0x000000018C22A800-0x000000018C22A850
		public long GetDownloadedSize(long taskId); // 0x000000018C22A850-0x000000018C22A8A0
		public long GetTotalDownloadSize(long taskId); // 0x000000018C22AA4C-0x000000018C22AA9C
		public long GetEstimatedDownloadSize(int updateType); // 0x000000018C22A8A0-0x000000018C22A8F0
		public int SetNotificationTitle(string titleConfig); // 0x000000018C22AC08-0x000000018C22AC58
		public long Preload(bool useMobileData); // 0x000000018C22AB3C-0x000000018C22ABB8
		public long ApplyPreload(string baseFilePathList, string desPath); // 0x000000018C22A59C-0x000000018C22A618
		public long GetEstimatedPreloadDownloadSize(); // 0x000000018C22A8F0-0x000000018C22A96C
		public int GetApplyPreloadProgress(long taskId); // 0x000000018C22A784-0x000000018C22A800
		public int Finish(long taskId); // 0x000000018C22A708-0x000000018C22A784
	}
}
