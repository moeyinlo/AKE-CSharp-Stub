/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Image 149: Hypergryph.GameUpdate.dll - Assembly: Hypergryph.GameUpdate, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63872-63880
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.SDK
{
	public class HGGameUpdateCallback : MonoBehaviour // TypeDefIndex: 63875
	{
		// Fields
		private static IHGGameUpdateSDKCallback m_callback; // 0x00
		private const string gameObjectName = "(hggameupdate_callback)"; // Metadata: 0x023536A8
		private static SynchronizationContext mainThreadContext; // 0x08
		public static HGGameUpdateCallback s_instance; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 63873
		{
			// Fields
			public string data; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _onLatestGame_b__0(); // 0x0000000189DE40F0-0x0000000189DE4140
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 63874
		{
			// Fields
			public Action action; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _runInMainTread_b__0(object p); // 0x0000000186DFA030-0x0000000186DFA04C
		}
	
		// Constructors
		public HGGameUpdateCallback(); // 0x0000000189DE3274-0x0000000189DE32D8
	
		// Methods
		public static void Init(IHGGameUpdateSDKCallback callback); // 0x0000000189DE30B8-0x0000000189DE3274
		public void onLatestGame(string data); // 0x0000000189DE32D8-0x0000000189DE3390
		private void runInMainTread(Action action); // 0x0000000189DE3390-0x0000000189DE3488
	}

	public interface IHGGameUpdateSDKCallback // TypeDefIndex: 63876
	{
		// Methods
		void onLatestGame(string data);
	}

	public interface IHGGameUpdateSDK // TypeDefIndex: 63877
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

	public static class HGGameUpdateSDK // TypeDefIndex: 63879
	{
		// Fields
		private static IHGGameUpdateSDK s_gu; // 0x00
		private static IHGGameUpdateSDKCallback m_callback; // 0x08
		private static SynchronizationContext mainThreadContext; // 0x10
	
		// Properties
		private static IHGGameUpdateSDK gameUpdateSDK { get; } // 0x0000000189DE3FC0-0x0000000189DE4054 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 63878
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<string> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189DE4140-0x0000000189DE4244
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetLatestGame_b__6_0(string result); // 0x0000000189DE4054-0x0000000189DE40F0
		}
	
		// Methods
		public static int Init(string config, IHGGameUpdateSDKCallback callback); // 0x0000000189DE3D50-0x0000000189DE3E34
		public static void GetLatestGame(); // 0x0000000189DE3B70-0x0000000189DE3C90
		public static long Update(int updateType, bool useMobileData); // 0x0000000189DE3F54-0x0000000189DE3FC0
		public static int EnableMobileData(long taskId); // 0x0000000189DE39F0-0x0000000189DE3A50
		public static int GetTaskState(long taskId); // 0x0000000189DE3C90-0x0000000189DE3CF0
		public static int Resume(long taskId); // 0x0000000189DE3E94-0x0000000189DE3EF4
		public static int CancelAndClear(long taskId); // 0x0000000189DE3930-0x0000000189DE3990
		public static int Cancel(long taskId); // 0x0000000189DE3990-0x0000000189DE39F0
		public static int Install(long taskId); // 0x0000000189DE3E34-0x0000000189DE3E94
		public static long GetDownloadSpeed(long taskId); // 0x0000000189DE3A50-0x0000000189DE3AB0
		public static long GetDownloadedSize(long taskId); // 0x0000000189DE3AB0-0x0000000189DE3B10
		public static long GetTotalDownloadSize(long taskId); // 0x0000000189DE3CF0-0x0000000189DE3D50
		public static long GetEstimatedDownloadSize(int updateType); // 0x0000000189DE3B10-0x0000000189DE3B70
		public static int SetNotificationTitle(string titleConfig); // 0x0000000189DE3EF4-0x0000000189DE3F54
	}

	public class HGGameUpdateSDKPluginDefault : IHGGameUpdateSDK // TypeDefIndex: 63880
	{
		// Constructors
		public HGGameUpdateSDKPluginDefault(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public int Init(string config); // 0x0000000189DE3798-0x0000000189DE37E8
		public void GetLatestGame(Action<string> onResult); // 0x0000000189DE3668-0x0000000189DE36F8
		public long Update(int updateType, bool useMobileData); // 0x0000000189DE38D8-0x0000000189DE3930
		public int EnableMobileData(long taskId); // 0x0000000189DE3528-0x0000000189DE3578
		public int GetTaskState(long taskId); // 0x0000000189DE36F8-0x0000000189DE3748
		public int Resume(long taskId); // 0x0000000189DE3838-0x0000000189DE3888
		public int CancelAndClear(long taskId); // 0x0000000189DE3488-0x0000000189DE34D8
		public int Cancel(long taskId); // 0x0000000189DE34D8-0x0000000189DE3528
		public int Install(long taskId); // 0x0000000189DE37E8-0x0000000189DE3838
		public long GetDownloadSpeed(long taskId); // 0x0000000189DE3578-0x0000000189DE35C8
		public long GetDownloadedSize(long taskId); // 0x0000000189DE35C8-0x0000000189DE3618
		public long GetTotalDownloadSize(long taskId); // 0x0000000189DE3748-0x0000000189DE3798
		public long GetEstimatedDownloadSize(int updateType); // 0x0000000189DE3618-0x0000000189DE3668
		public int SetNotificationTitle(string titleConfig); // 0x0000000189DE3888-0x0000000189DE38D8
	}
}
