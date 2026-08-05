/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Beyond;
using Beyond.Audio;
using Beyond.Cfg;
using Beyond.Gameplay;
using Beyond.GEnums;
using Beyond.Input;
using Beyond.Login;
using Beyond.Network;
using Beyond.Resource;
using Beyond.Resource.HotUpdate;
using Beyond.SDK;
using Beyond.UI;
using Beyond.UI.UIState;
using Beyond.VFS;
using DG.Tweening;
using Hypergryph.PlatformFacade;
using Hypergryph.SpeedTest;
using IFix.Core;
using Proto;
using TMPro;
using U8.SDK;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 28: Entry.Beyond.dll - Assembly: Entry.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56294-56579
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class RenderSilhouetteRT : MonoBehaviour // TypeDefIndex: 56295
{
	// Fields
	public Camera cameraRT; // 0x18
	public Camera mainCamera; // 0x20
	public Material materialSilhouette; // 0x28
	private static Texture s_mSilhouetteRT; // 0x00
	private static RenderTexture s_mSilhouetteRth; // 0x08

	// Constructors
	public RenderSilhouetteRT(); // 0x0000000185393520-0x0000000185393538

	// Methods
	private void Update(); // 0x0000000183D76B40-0x0000000183D76EA0
	private void OnDestroy(); // 0x000000018484FD10-0x000000018484FEE0
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 56575
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_52 DF6EA5B59F0E6C03F390AD5FEA0BBC199EC3524C0A682913148FD071AF1898EC; // 0x00 // Static value (base64): AQAAAAIAAAADAAAABAAAAAUAAAAGAAAABwAAAAgAAAAJAAAACgAAAAsAAAAMAAAADQAAAA== - Metadata: 0x0234863C

	// Nested types
	private struct __StaticArrayInitTypeSize_52 // TypeDefIndex: 56574
	{
	}
}

namespace Beyond
{
	public class GameApp : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 56306
	{
		// Fields
		private GameStateMachine m_stateMachine; // 0x18
		[CompilerGenerated]
		private static GameApp _instance_k__BackingField; // 0x00
		private bool m_hasFocus; // 0x20
		private bool m_needCallLuaFocus; // 0x21
		private bool m_pauseStatus; // 0x22
		private bool m_needCallLuaPause; // 0x23
		private const uint FILE_ATTRIBUTE_DIRECTORY = 16; // Metadata: 0x02347985
		private const uint FILE_ATTRIBUTE_READONLY = 1; // Metadata: 0x02347986
		private const uint FILE_ATTRIBUTE_NORMAL = 128; // Metadata: 0x02347987
		private const uint FILE_ATTRIBUTE_REPARSE_POINT = 1024; // Metadata: 0x02347989
		private static readonly IntPtr INVALID_HANDLE_VALUE; // 0x08
		private const uint GENERIC_READ = 2147483648; // Metadata: 0x0234798B
		private const uint GENERIC_WRITE = 1073741824; // Metadata: 0x02347990
		private const uint FILE_SHARE_READ = 1; // Metadata: 0x02347995
		private const uint FILE_SHARE_WRITE = 2; // Metadata: 0x02347996
		private const uint FILE_SHARE_DELETE = 4; // Metadata: 0x02347997
		private const uint OPEN_EXISTING = 3; // Metadata: 0x02347998
		private const uint FILE_FLAG_SEQUENTIAL_SCAN = 134217728; // Metadata: 0x02347999
		private const int ERROR_FILE_NOT_FOUND = 2; // Metadata: 0x0234799D
		private const int ERROR_PATH_NOT_FOUND = 3; // Metadata: 0x0234799E
		private const int ERROR_NO_MORE_FILES = 18; // Metadata: 0x0234799F
		[ThreadStatic]
		private static byte[] s_md5Buffer; // 0x80000000
		private static int s_scanRunning; // 0x10
		private static string s_pendingScanOutput; // 0x18
	
		// Properties
		public static GameApp instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000186991E18-0x0000000186991E68 0x0000000186991E68-0x0000000186991EC4
		public GameState currentState { get; } // 0x00000001836A6260-0x00000001836A62B0 
		public static bool IsScanRunning { get; } // 0x0000000186991D98-0x0000000186991E18 
	
		// Nested types
		private struct WIN32_FIND_DATA // TypeDefIndex: 56297
		{
			// Fields
			public uint dwFileAttributes; // 0x00
			public FILETIME ftCreationTime; // 0x04
			public FILETIME ftLastAccessTime; // 0x0C
			public FILETIME ftLastWriteTime; // 0x14
			public uint nFileSizeHigh; // 0x1C
			public uint nFileSizeLow; // 0x20
			public uint dwReserved0; // 0x24
			public uint dwReserved1; // 0x28
			public string cFileName; // 0x30
			public string cAlternateFileName; // 0x38
		}
	
		private class FileEntry // TypeDefIndex: 56298
		{
			// Fields
			public string name; // 0x10
			public string fullPath; // 0x18
			public long size; // 0x20
			public string md5; // 0x28
			public int pathLength; // 0x30
			public bool readable; // 0x34
			public bool writable; // 0x35
			public bool readOnly; // 0x36
	
			// Constructors
			public FileEntry(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private struct PendingFile // TypeDefIndex: 56299
		{
			// Fields
			public string fullPath; // 0x00
			public long size; // 0x08
			public bool readOnlyAttr; // 0x10
		}
	
		private class ScanContext // TypeDefIndex: 56300
		{
			// Fields
			public readonly ConcurrentQueue<string> dirQueue; // 0x10
			public readonly ConcurrentQueue<PendingFile> fileQueue; // 0x18
			public readonly ConcurrentBag<FileEntry> results; // 0x20
			public int pendingDirs; // 0x28
			public int pendingFiles; // 0x2C
	
			// Constructors
			public ScanContext(); // 0x0000000186993CD0-0x0000000186993DDC
		}
	
		private class TreeNode // TypeDefIndex: 56301
		{
			// Fields
			public string name; // 0x10
			public FileEntry fileEntry; // 0x18
			public Dictionary<string, TreeNode> children; // 0x20
	
			// Constructors
			public TreeNode(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __DelayInit_d__14 : IEnumerator<object> // TypeDefIndex: 56302
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameApp __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DelayInit_d__14(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186994B48-0x0000000186994BF8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994BF8-0x0000000186994C44
		}
	
		[CompilerGenerated]
		private sealed class __InitSecuritySDK_d__35 : IEnumerator<object> // TypeDefIndex: 56303
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameApp __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __InitSecuritySDK_d__35(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018340BDA0-0x000000018340C0E0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994E0C-0x0000000186994E58
		}
	
		[CompilerGenerated]
		private sealed class __FetchRemoteConfigUtilSuc_d__37 : IEnumerator<object> // TypeDefIndex: 56304
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private RemoteNetworkCfg _config_5__2; // 0x20
			private Beyond.Misc.ObjectRef _resultRef_5__3; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __FetchRemoteConfigUtilSuc_d__37(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C09CD0-0x0000000183C0A020
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994D28-0x0000000186994D74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 56305
		{
			// Fields
			public string capturedRoot; // 0x10
			public int capturedThreads; // 0x18
			public string capturedOutput; // 0x20
			public string capturedSysInfo; // 0x28
	
			// Constructors
			public __c__DisplayClass71_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LaunchScanCoordinator_b__0(); // 0x00000001869943B4-0x00000001869946D0
		}
	
		// Constructors
		public GameApp(); // 0x0000000184D84C40-0x0000000184D84C60
		static GameApp(); // 0x0000000184D7A710-0x0000000184D7A750
	
		// Methods
		public void SwitchState(GameState state); // 0x0000000183C11BB0-0x0000000183C11C20
		private void Awake(); // 0x000000018380F1F0-0x000000018380F460
		private bool _NeedDeepProfilerMode(); // 0x00000001841A5BF0-0x00000001841A5CA0
		[IteratorStateMachine(typeof(__DelayInit_d__14))]
		private IEnumerator _DelayInit(); // 0x000000018698FB68-0x000000018698FBF4
		private void _RegisterLuaAfterGCEvent(); // 0x000000018488B500-0x000000018488B620
		private void _InitNotificationCenter(); // 0x000000018464E170-0x000000018464E1A0
		private void Update(); // 0x00000001832E1800-0x00000001832E1A70
		private void LateUpdate(); // 0x0000000182F5C730-0x0000000182F5C7A0
		private void OnApplicationQuit(); // 0x000000018698D850-0x000000018698DA78
		private void OnApplicationFocus(bool hasFocus); // 0x0000000183A73FA0-0x0000000183A740D0
		private void _OnApplicationFocusForLua(); // 0x0000000183820560-0x0000000183820620
		private void OnApplicationPause(bool pauseStatus); // 0x0000000183F26470-0x0000000183F266A0
		private void _OnApplicationPauseForLua(); // 0x0000000183F26780-0x0000000183F267E0
		private void OnDestroy(); // 0x000000018698DA78-0x000000018698DC9C
		private void _PreInitGameSetting(); // 0x00000001835C2290-0x00000001835C23E0
		private void _Init(); // 0x000000018464DC20-0x000000018464DE50
		private void _UnInit(); // 0x0000000186990FE4-0x0000000186991074
		private void _InitGameStateMachine(); // 0x000000018464E1A0-0x000000018464E240
		private void _UnInitGameStateMachine(); // 0x0000000186990F60-0x0000000186990FE4
		[IDTag(1)]
		public static void QuitGame(GameAppExitCode exitCode); // 0x000000018698DD34-0x000000018698DDA8
		[IDTag(0)]
		public static void QuitGame(int exitCode); // 0x000000018698DDA8-0x000000018698DE64
		public static void RefreshScreenResolution(); // 0x000000018698DE64-0x000000018698DF64
		private static void _OnSystemDisplaySizeChanged(); // 0x0000000186990210-0x000000018699029C
		private static void _OnSystemScreenSizeChanged([IsReadOnly] in EventData<bool, bool> data); // 0x000000018699029C-0x0000000186990358
		[IteratorStateMachine(typeof(__InitSecuritySDK_d__35))]
		private IEnumerator _InitSecuritySDK(); // 0x000000018464DE50-0x000000018464DEC0
		private void _OnApplicationPauseForSecurity(bool pauseStatus); // 0x000000018340DAF0-0x000000018340DB80
		[IteratorStateMachine(typeof(__FetchRemoteConfigUtilSuc_d__37))]
		private IEnumerator _FetchRemoteConfigUtilSuc(); // 0x0000000184D32D40-0x0000000184D32DA0
		private static extern IntPtr _FindFirstFileW(string lpFileName, out WIN32_FIND_DATA lpFindFileData); // 0x000000018698FC74-0x000000018698FD8C
		private static extern bool _FindNextFileW(IntPtr hFindFile, out WIN32_FIND_DATA lpFindFileData); // 0x000000018698FD8C-0x000000018698FE9C
		private static extern bool _FindClose(IntPtr hFindFile); // 0x000000018698FBF4-0x000000018698FC74
		private static extern IntPtr _CreateFileW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile); // 0x000000018698FA90-0x000000018698FB68
		private static extern bool _ReadFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped); // 0x0000000186990760-0x0000000186990824
		private static extern bool _CloseHandle(IntPtr hObject); // 0x000000018698E99C-0x000000018698E9EC
		public static bool PollScanResult(out string gzOutputPath); // 0x000000018698DC9C-0x000000018698DD34
		public static void ScanLocalFiles(string rootDir = null, string outputPath = null, int threadCount = 0 /* Metadata: 0x02347984 */); // 0x000000018698DF64-0x000000018698E160
		internal static void LaunchScanCoordinator(string rootDir, string outputPath, int threadCount, string systemInfo = null); // 0x000000018698D4A0-0x000000018698D850
		private static List<FileEntry> _ScanParallel(string root, int threadCount); // 0x0000000186990C04-0x0000000186990EB4
		private static void _WorkerLoop(object state); // 0x0000000186991074-0x0000000186991268
		private static void _ScanDirectory(ScanContext ctx, string dir); // 0x0000000186990824-0x0000000186990C04
		private static string _MakeLongPath(string path); // 0x0000000186990060-0x0000000186990210
		private static FileEntry _BuildEntry(PendingFile pf); // 0x000000018698E160-0x000000018698E3F0
		private static bool _CanAccess(string path, uint desiredAccess); // 0x000000018698E8C0-0x000000018698E99C
		private static string _CalculateMd5(string path); // 0x000000018698E3F0-0x000000018698E8C0
		private static string _CollectSystemInfo(); // 0x000000018698E9EC-0x000000018698FA90
		private static void _WriteTreeReport(List<FileEntry> entries, string root, System.DateTime scanStart, string outputPath, string systemInfo = null); // 0x0000000186991268-0x0000000186991D98
		private static void _PrintTreeNode(StringBuilder sb, TreeNode node, string prefix); // 0x0000000186990358-0x0000000186990760
		private static int _TreeNodeCompare(TreeNode a, TreeNode b); // 0x0000000186990EB4-0x0000000186990F60
		private static string _FormatSize(long bytes); // 0x000000018698FE9C-0x0000000186990060
	}

	public interface IMemoryPackProxy // TypeDefIndex: 56307
	{
		// Methods
		void Init();
	}

	public class MemoryPackProxyModule // TypeDefIndex: 56308
	{
		// Fields
		private static IMemoryPackProxy s_memoryPackProxy; // 0x00
	
		// Constructors
		public MemoryPackProxyModule(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void RegisterProxy(IMemoryPackProxy memoryPackProxy); // 0x0000000186993C80-0x0000000186993CD0
		public static IMemoryPackProxy GetMemoryPackProxy(); // 0x0000000186993C48-0x0000000186993C80
	}

	public class GameInitState : GameStateBase // TypeDefIndex: 56310
	{
		// Properties
		public override GameState stateId { get; } // 0x0000000184D261C0-0x0000000184D261F0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DoInit_d__5 : IEnumerator<object> // TypeDefIndex: 56309
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameInitState __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DoInit_d__5(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C11C20-0x0000000183C12270
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994C90-0x0000000186994CDC
		}
	
		// Constructors
		public GameInitState(GameStateMachine stateMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void OnEnter(GameState fromStateId); // 0x000000018380EA50-0x000000018380EB40
		public override void OnLeave(GameState toStateId); // 0x00000001841E4230-0x00000001841E42D0
		[IteratorStateMachine(typeof(__DoInit_d__5))]
		private IEnumerator _DoInit(); // 0x000000018380EB40-0x000000018380EBB0
		private void _InitInitialResourceManager(out VirtualFileSystem.BlockValidator blockValidator); // 0x0000000183DA3770-0x0000000183DA38E0
		private bool _CheckIfLocalInitialAssetsValid(out LocalResPref outputLocalResPref, out VirtualFileSystem.BlockValidator blockValidator); // 0x000000018332A050-0x000000018332A190
		private void _InitAPPDefaultCulture(); // 0x0000000183BA9CF0-0x0000000183BA9E80
		private void _InitGameSetting(); // 0x0000000183C91F20-0x0000000183C92000
		public void __iFixBaseProxy_OnEnter(GameState P0); // 0x0000000186991EC4-0x0000000186991ECC
		public void __iFixBaseProxy_OnLeave(GameState P0); // 0x0000000186991ECC-0x0000000186991ED4
	}

	public class GameLoginState : GameStateBase // TypeDefIndex: 56311
	{
		// Properties
		public override GameState stateId { get; } // 0x0000000184D51FE0-0x0000000184D52010 
	
		// Constructors
		public GameLoginState(GameStateMachine stateMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void OnEnter(GameState fromStateId); // 0x000000018380EBB0-0x000000018380ECC0
		public override void OnLeave(GameState toStateId); // 0x00000001841E4770-0x00000001841E47F0
		private static void _TryStartLoginWorkflow(); // 0x0000000184A20820-0x0000000184A20900
		public void __iFixBaseProxy_OnEnter(GameState P0); // 0x0000000186991EC4-0x0000000186991ECC
		public void __iFixBaseProxy_OnLeave(GameState P0); // 0x0000000186991ECC-0x0000000186991ED4
	}

	public class GameMainState : GameStateBase // TypeDefIndex: 56312
	{
		// Fields
		private bool m_isFirstEnter; // 0x18
	
		// Properties
		public override GameState stateId { get; } // 0x0000000184D51FB0-0x0000000184D51FE0 
	
		// Constructors
		public GameMainState(GameStateMachine stateMachine); // 0x0000000185397B28-0x0000000185397B3C
	
		// Methods
		public override void OnEnter(GameState fromStateId); // 0x000000018380E4E0-0x000000018380E5E0
		public override void OnLeave(GameState toStateId); // 0x00000001841E4830-0x00000001841E4880
		public static void ReleaseMainGame(GameState toStateId); // 0x0000000184816600-0x0000000184819810
		private static void _ClearUtils(); // 0x0000000186991ED4-0x0000000186991FBC
		public void __iFixBaseProxy_OnEnter(GameState P0); // 0x0000000186991EC4-0x0000000186991ECC
		public void __iFixBaseProxy_OnLeave(GameState P0); // 0x0000000186991ECC-0x0000000186991ED4
	}

	public class GamePreloadState : GameStateBase // TypeDefIndex: 56314
	{
		// Fields
		private Beyond.Cfg.Tables.AsyncLoadTask m_asyncTask; // 0x18
	
		// Properties
		public override GameState stateId { get; } // 0x0000000184D51F50-0x0000000184D51F80 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DoPreload_d__6 : IEnumerator<object> // TypeDefIndex: 56313
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GamePreloadState __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DoPreload_d__6(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018340DD90-0x00000001834110D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994CDC-0x0000000186994D28
		}
	
		// Constructors
		public GamePreloadState(GameStateMachine stateMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void OnEnter(GameState fromStateId); // 0x000000018380E620-0x000000018380E6C0
		public override void OnLeave(GameState toStateId); // 0x00000001841E4880-0x00000001841E48F0
		[IteratorStateMachine(typeof(__DoPreload_d__6))]
		private IEnumerator _DoPreload(); // 0x000000018380E6C0-0x000000018380E730
		private void _InitGameSettingStateInPreload(); // 0x0000000184151FC0-0x0000000184152BD0
		public void __iFixBaseProxy_OnEnter(GameState P0); // 0x0000000186991EC4-0x0000000186991ECC
		public void __iFixBaseProxy_OnLeave(GameState P0); // 0x0000000186991ECC-0x0000000186991ED4
	}

	public class GameQuitState : GameStateBase // TypeDefIndex: 56315
	{
		// Properties
		public override GameState stateId { get; } // 0x0000000184D51F20-0x0000000184D51F50 
	
		// Constructors
		public GameQuitState(GameStateMachine stateMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void OnEnter(GameState fromStateId); // 0x0000000186992410-0x0000000186992478
		public override void OnLeave(GameState toStateId); // 0x0000000186992478-0x00000001869924DC
		public static void DoQuit(); // 0x0000000186991FBC-0x0000000186992410
		public void __iFixBaseProxy_OnEnter(GameState P0); // 0x0000000186991EC4-0x0000000186991ECC
		public void __iFixBaseProxy_OnLeave(GameState P0); // 0x0000000186991ECC-0x0000000186991ED4
	}

	public class GameSoftRestartState : GameStateBase // TypeDefIndex: 56317
	{
		// Fields
		private const string CLEAR_SCENE_PATH = "Assets/Beyond/Scenes/BuildScenes/Clear.unity"; // Metadata: 0x023479A0
	
		// Properties
		public override GameState stateId { get; } // 0x0000000184D51EF0-0x0000000184D51F20 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __SoftRestart_d__5 : IEnumerator<object> // TypeDefIndex: 56316
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameSoftRestartState __4__this; // 0x20
			private AsyncOperation _clearSceneOp_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __SoftRestart_d__5(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186994EF0-0x00000001869957DC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869957DC-0x0000000186995828
		}
	
		// Constructors
		public GameSoftRestartState(GameStateMachine stateMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void OnEnter(GameState fromStateId); // 0x00000001869924DC-0x0000000186992594
		[IteratorStateMachine(typeof(__SoftRestart_d__5))]
		private IEnumerator _SoftRestart(); // 0x0000000186992594-0x0000000186992624
		public void __iFixBaseProxy_OnEnter(GameState P0); // 0x0000000186991EC4-0x0000000186991ECC
	}

	public class GameStartState : GameStateBase // TypeDefIndex: 56318
	{
		// Properties
		public override GameState stateId { get; } // 0x0000000184D51EC0-0x0000000184D51EF0 
	
		// Constructors
		public GameStartState(GameStateMachine stateMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void OnEnter(GameState fromStateId); // 0x000000018380E730-0x000000018380E880
		public override void OnLeave(GameState toStateId); // 0x00000001841E48F0-0x00000001841E49F0
		private void _OnEnterMainGame(); // 0x0000000184B52310-0x0000000184B523D0
		[CompilerGenerated]
		private void __OnEnterMainGame_b__5_0(); // 0x0000000183C123C0-0x0000000183C12410
		public void __iFixBaseProxy_OnEnter(GameState P0); // 0x0000000186991EC4-0x0000000186991ECC
		public void __iFixBaseProxy_OnLeave(GameState P0); // 0x0000000186991ECC-0x0000000186991ED4
	}

	public abstract class GameStateBase : ISimpleStateNode<GameState>, ILuaCallCSharp // TypeDefIndex: 56319
	{
		// Fields
		protected readonly GameStateMachine m_stateMachine; // 0x10
	
		// Properties
		public abstract GameState stateId { get; }
	
		// Constructors
		protected GameStateBase(GameStateMachine stateMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public virtual void OnEnter(GameState fromStateId); // 0x000000018380E880-0x000000018380E980
		public virtual void OnLeave(GameState toStateId); // 0x00000001841E49F0-0x00000001841E4A80
		public virtual void OnTick(float deltaTime); // 0x0000000186992624-0x0000000186992678
	}

	public class GameStateMachine : SimpleEnumStateMachine<GameState>, IGameStateMachine, ILuaCallCSharp // TypeDefIndex: 56321
	{
		// Fields
		[CompilerGenerated]
		private readonly GameApp _app_k__BackingField; // 0x30
	
		// Properties
		public GameApp app { [CompilerGenerated] get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public GameState curState { get; } // 0x000000018332C370-0x000000018332C3A0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ReturnToLoginState_d__8 : IEnumerator<object> // TypeDefIndex: 56320
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameStateMachine __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _ReturnToLoginState_d__8(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C12470-0x0000000183C14660
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699428C-0x00000001869942D8
		}
	
		// Constructors
		public GameStateMachine(GameApp gameApp); // 0x000000018464E240-0x000000018464E2A0
	
		// Methods
		private void _RegisterStates(); // 0x000000018464E2A0-0x000000018464E4D0
		public bool CheckCanReturnToLoginState(); // 0x0000000183C119D0-0x0000000183C11A30
		[IteratorStateMachine(typeof(_ReturnToLoginState_d__8))]
		public IEnumerator ReturnToLoginState(); // 0x0000000183C11960-0x0000000183C119D0
	}

	public static class GlobalInitializer // TypeDefIndex: 56322
	{
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void InitGlobalConfig(); // 0x0000000184D83BE0-0x0000000184D83C00
	}

	public interface IHotFixCommon // TypeDefIndex: 56323
	{
	}

	public interface IHotFixPatchManagerProxy : IHotFixCommon // TypeDefIndex: 56324
	{
		// Methods
		void InitManager();
		void ReleaseManager();
		void OnReturnToLogin();
		void RegisterHotfixSDKEvent();
		void UnregisterHotfixSDKEvent();
		bool TryProcessHotfixSDKExtraInfo(int code, Dictionary<string, object> msg);
		void PatchInitAssemble();
		void PatchRemoteInitAssemble();
		void PatchRemoteInjectedLua();
		void PatchMainAssemble();
		void PatchRemoteMainAssemble();
	}

	public class HotFixPatchModules // TypeDefIndex: 56325
	{
		// Fields
		private static Dictionary<System.Type, IHotFixCommon> s_hotFixModules; // 0x00
	
		// Constructors
		public HotFixPatchModules(); // 0x00000001841E1670-0x00000001841E1680
		static HotFixPatchModules(); // 0x0000000184D17E20-0x0000000184D17EB0
	
		// Methods
		public static void Register<T>(T module)
			where T : class, IHotFixCommon;
		public static void UnRegister<T>()
			where T : class, IHotFixCommon;
		public static T GetModule<T>()
			where T : class, IHotFixCommon;
		public static bool TryGetModule<T>(out ref T module)
			where T : class, IHotFixCommon;
	}

	public static class InitialPathDef // TypeDefIndex: 56326
	{
		// Fields
		public const string LOGIN_SCENE_PATH = "Assets/Beyond/InitialAssets/Scenes/Login.unity"; // Metadata: 0x023479CD
		public const string LOGIN_SK_ACTOR_M = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_male.prefab"; // Metadata: 0x023479FC
		public const string LOGIN_SK_ACTOR_F = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_female.prefab"; // Metadata: 0x02347A3A
		public const string LOGIN_SK_ACTOR_NO_GENDER = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_no_gender.prefab"; // Metadata: 0x02347A7A
		public const string LOGIN_MOCK_UID_PANEL = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginMockUIDPanel.prefab"; // Metadata: 0x02347ABE
		public const string LOGIN_CONTROLLER_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginController.prefab"; // Metadata: 0x02347B02
		public const string LOGIN_ROOT_PANEL_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginRootPanel.prefab"; // Metadata: 0x02347B44
		public const string LOGIN_ALERT_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginAlertDialog.prefab"; // Metadata: 0x02347B84
		public const string LOGIN_JUDGE_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginJudgeDialog.prefab"; // Metadata: 0x02347BC7
		public const string LOGIN_VOC_RES_SELECT_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginVocResSelDialog.prefab"; // Metadata: 0x02347C0A
	}

	public class LoginController : MonoBehaviour, ILoginBinder<LoginViewModel> // TypeDefIndex: 56342
	{
		// Fields
		[SerializeField]
		private Transform _uiFunc; // 0x18
		[SerializeField]
		private Transform _uiDialog; // 0x20
		[SerializeField]
		private UIButton _versionBtn; // 0x28
		[SerializeField]
		private LoginDecorateUI _uiDecorate; // 0x30
		[SerializeField]
		private MaskCfg _maskBlur; // 0x38
		[SerializeField]
		private MaskCfg _maskBlack; // 0x40
		[SerializeField]
		private MaskCfg _maskWhite; // 0x48
		[SerializeField]
		private float _enterGamePanelPredelay; // 0x50
		[SerializeField]
		private Canvas _uiRootCanvas; // 0x58
		[SerializeField]
		private UICanvasScaleHelper _uiRootCanvasScaleHelper; // 0x60
		[SerializeField]
		private Canvas _uiDecoCanvas; // 0x68
		[SerializeField]
		private UICanvasScaleHelper _uiDecoCanvasScaleHelper; // 0x70
		private bool m_isInited; // 0x78
		private FOptions m_options; // 0x80
		private LatchUtils.InvokeWhenUnlock m_startLatch; // 0x88
		private LatchUtils.InvokeWhenUnlock m_initLatch; // 0x90
		private LoginWorkFlow.ENode m_lastNode; // 0x98
		private MaskCtrl m_maskCtrl; // 0xA0
		private LoginRootPanel m_rootPanel; // 0xA8
		private IEnumerator m_mockLoginRoutine; // 0xB0
		[CompilerGenerated]
		private Action<string> m_onMockLogin; // 0xB8
	
		// Properties
		public MaskCtrl maskCtrl { get; } // 0x00000001841E6130-0x00000001841E61D0 
		public LoginRootPanel rootPanel { get; } // 0x00000001841E7A20-0x00000001841E7A50 
	
		// Events
		private event Action<string> m_onMockLogin {
			add; // 0x0000000183AF7400-0x0000000183AF7490
			remove; // 0x0000000183AF7490-0x0000000183AF7520
		}
	
		// Nested types
		public struct FOptions // TypeDefIndex: 56327
		{
			// Fields
			public LoginContext context; // 0x00
		}
	
		public abstract class Dialog : MonoBehaviour // TypeDefIndex: 56330
		{
			// Fields
			private UISwitchTween m_switchTween; // 0x18
			private LoginController m_controller; // 0x20
			[AudioString]
			public string showAudioEvent; // 0x28
			[AudioString]
			public string closeAudioEvent; // 0x30
	
			// Nested types
			[CompilerGenerated]
			private sealed class __CloseCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 56328
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public Dialog __4__this; // 0x20
				public Action callback; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public __CloseCoroutine_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x0000000186994A30-0x0000000186994AFC
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000186994AFC-0x0000000186994B48
			}
	
			[CompilerGenerated]
			private sealed class _Create_d__8<TDialog> : IEnumerator<object> // TypeDefIndex: 56329
				where TDialog : Dialog
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public Beyond.Misc.ObjectRef outRef;
				public LoginController controller;
				public string resPath;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public _Create_d__8(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			// Constructors
			protected Dialog(); // 0x0000000185393520-0x0000000185393538
	
			// Methods
			[IteratorStateMachine(typeof(__CloseCoroutine_d__4))]
			private IEnumerator _CloseCoroutine(Action callback); // 0x000000018698D340-0x000000018698D3E8
			public bool TryCloseWithCallback(Action callback); // 0x000000018698D1E4-0x000000018698D340
			public void Show(); // 0x000000018698D0F4-0x000000018698D1E4
			protected virtual void OnInit(); // 0x000000018698D0B0-0x000000018698D0F4
			[IteratorStateMachine(typeof(_Create_d__8<TDialog>))]
			public static IEnumerator Create<TDialog>(string resPath, LoginController controller, Beyond.Misc.ObjectRef outRef)
				where TDialog : Dialog;
		}
	
		public static class MaskConsts // TypeDefIndex: 56331
		{
			// Fields
			public const float DELAY_WAIT_NODE = 0.2f; // Metadata: 0x02347C51
			public const string INIT = "init"; // Metadata: 0x02347C55
			public const string U8_LOGIN = "u8_login"; // Metadata: 0x02347C5A
			public const string FROM_GS_LOGIN = "from_gs_login"; // Metadata: 0x02347C63
			public const string FROM_CREATE_ROLE = "from_create_role"; // Metadata: 0x02347C71
			public const string NET_AGE_TIPS = "age_tips"; // Metadata: 0x02347C82
		}
	
		public enum EMaskType // TypeDefIndex: 56332
		{
			None = 0,
			Black = 1,
			Blur = 2,
			White = 3
		}
	
		[Serializable]
		private class MaskCfg // TypeDefIndex: 56333
		{
			// Fields
			public CanvasGroup target; // 0x10
			public float showDuration; // 0x18
			public float hideDuration; // 0x1C
	
			// Constructors
			public MaskCfg(); // 0x0000000184D8CC90-0x0000000184D8CCA0
	
			// Methods
			public UISwitchTween CreateTweenAndHide(); // 0x0000000183F0F380-0x0000000183F0F420
		}
	
		public class MaskCtrl : IDisposable // TypeDefIndex: 56336
		{
			// Fields
			private static readonly int[] CROSS_SCENE_MASKS; // 0x00
			private ListDict<int, HashSet<string>> m_maskRefs; // 0x10
			private ListDict<int, UISwitchTween> m_maskTweens; // 0x18
			private ListDict<string, NetMaskRef> m_netMasks; // 0x20
	
			// Nested types
			private class NetMaskRef // TypeDefIndex: 56334
			{
				// Fields
				[CompilerGenerated]
				private string _key_k__BackingField; // 0x10
				public int maskId; // 0x18
				public bool isEnabled; // 0x1C
	
				// Properties
				public string key { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
				// Constructors
				public NetMaskRef(string key); // 0x00000001853908C0-0x00000001853908D0
			}
	
			[CompilerGenerated]
			private sealed class _WaitForCrossSceneMasks_d__10 : IEnumerator<object> // TypeDefIndex: 56335
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public MaskCtrl __4__this; // 0x20
				private int[] __7__wrap1; // 0x28
				private int __7__wrap2; // 0x30
				private UISwitchTween _mask_5__4; // 0x38
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public _WaitForCrossSceneMasks_d__10(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x00000001869948BC-0x00000001869949E4
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x00000001869949E4-0x0000000186994A30
			}
	
			// Constructors
			public MaskCtrl(LoginController controller); // 0x0000000183F0F180-0x0000000183F0F380
			static MaskCtrl(); // 0x0000000184CE79C0-0x0000000184CE7A50
	
			// Methods
			public void Dispose(); // 0x0000000183F0F600-0x0000000183F0FEA0
			public void EnableMask(string key, EMaskType type, bool enable, bool reset = false /* Metadata: 0x02347C8F */); // 0x00000001841E77B0-0x00000001841E7990
			public bool IsMaskTweening(EMaskType type); // 0x00000001841E7690-0x00000001841E76E0
			public bool IsCrossSceneMaskTweening(); // 0x00000001841E76E0-0x00000001841E77B0
			[IteratorStateMachine(typeof(_WaitForCrossSceneMasks_d__10))]
			public IEnumerator WaitForCrossSceneMasks(); // 0x0000000186993BB8-0x0000000186993C48
			public void EnableNetMask(string key, float timeoutSecs); // 0x00000001869939E0-0x0000000186993BB8
			public void DisableNetMask(string key); // 0x00000001869938F4-0x00000001869939E0
			private UISwitchTween _GetMaskByType(int type); // 0x00000001841E7990-0x00000001841E7A20
		}
	
		[CompilerGenerated]
		private sealed class _BeforeDestroy_d__35 : IEnumerator<object> // TypeDefIndex: 56337
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _BeforeDestroy_d__35(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001841E5D70-0x00000001841E5E00
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869941A8-0x00000001869941F4
		}
	
		[CompilerGenerated]
		private sealed class __InstantiateUIFromRes_d__36<T> : IEnumerator<object> // TypeDefIndex: 56338
			where T : Component
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Beyond.Misc.ObjectRef objRef;
			public LoginController __4__this;
			public string resPath;
			public Transform parent;
			private FAssetProxyHandle? _handle_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __InstantiateUIFromRes_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __InitCoroutine_d__38 : IEnumerator<object> // TypeDefIndex: 56339
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
			private LoginContext _context_5__2; // 0x28
			private Beyond.Misc.ObjectRef _panelRef_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __InitCoroutine_d__38(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001841E5520-0x00000001841E5760
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994DC0-0x0000000186994E0C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 56340
		{
			// Fields
			public Beyond.Misc.ObjectRef objRef; // 0x10
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __MockLoginCoroutine_b__0(string pUID); // 0x0000000183C8D270-0x0000000183C8D330
		}
	
		[CompilerGenerated]
		private sealed class __MockLoginCoroutine_d__45 : IEnumerator<object> // TypeDefIndex: 56341
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
			private __c__DisplayClass45_0 __8__1; // 0x28
			public string fixedUID; // 0x30
			private LoginMockUIDPanel _nullablePanel_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __MockLoginCoroutine_d__45(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183F0E1B0-0x0000000183F0E5A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994EA4-0x0000000186994EF0
		}
	
		// Constructors
		public LoginController(); // 0x00000001849C1650-0x00000001849C1790
	
		// Methods
		protected void Awake(); // 0x0000000184D2A8F0-0x0000000184D2A960
		protected void Start(); // 0x0000000184D59930-0x0000000184D59980
		public float GetEnterGamePanelPredelay(); // 0x00000001841E7A50-0x00000001841E7A80
		public void OnValueChanged(LoginViewModel viewModel); // 0x00000001834089F0-0x0000000183408A70
		public void InitUI(FOptions options); // 0x00000001841E51F0-0x00000001841E53A0
		public void InvokeWhenStart(Action callback); // 0x000000018380AB70-0x000000018380ABC0
		[IteratorStateMachine(typeof(_BeforeDestroy_d__35))]
		public IEnumerator BeforeDestroy(); // 0x0000000184A22370-0x0000000184A223E0
		[IteratorStateMachine(typeof(__InstantiateUIFromRes_d__36<T>))]
		private IEnumerator _InstantiateUIFromRes<T>(string resPath, Transform parent, Beyond.Misc.ObjectRef objRef)
			where T : Component;
		private void _InitImpl(); // 0x0000000184CB24C0-0x0000000184CB2510
		[IteratorStateMachine(typeof(__InitCoroutine_d__38))]
		private IEnumerator _InitCoroutine(); // 0x0000000184CB2510-0x0000000184CB2580
		private void _InitVersionBtn(); // 0x00000001841E4A80-0x00000001841E4B40
		public void MockLoginWithCallback(string fixedUID, Action<string> callback); // 0x0000000183AF7270-0x0000000183AF7370
		[IteratorStateMachine(typeof(__MockLoginCoroutine_d__45))]
		private IEnumerator _MockLoginCoroutine(string fixedUID); // 0x0000000183AF7370-0x0000000183AF7400
		[CompilerGenerated]
		private void _MockLoginWithCallback_b__44_0(); // 0x0000000184D84E00-0x0000000184D84E10
	}

	public class LoginContext : IDisposable // TypeDefIndex: 56344
	{
		// Fields
		private LoginController m_controller; // 0x10
		private bool m_isDisposed; // 0x18
		[CompilerGenerated]
		private bool _quickStart_k__BackingField; // 0x19
		[CompilerGenerated]
		private bool _firstLogin_k__BackingField; // 0x1A
		[CompilerGenerated]
		private LoginWorkFlow _workflow_k__BackingField; // 0x20
		[CompilerGenerated]
		private LoginViewProperty _viewProp_k__BackingField; // 0x28
		[CompilerGenerated]
		private LoginManager.AssetLoader _loader_k__BackingField; // 0x30
		[CompilerGenerated]
		private LoginManager.FlowWithMaskMgr _flowWithMask_k__BackingField; // 0x38
		[CompilerGenerated]
		private NetUsagePolicy _netUsagePolicy_k__BackingField; // 0x40
		[CompilerGenerated]
		private LoginGameUpdater _gameUpdater_k__BackingField; // 0x48
		[CompilerGenerated]
		private bool _startConnectServer_k__BackingField; // 0x50
	
		// Properties
		public bool quickStart { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D866A0-0x0000000184D866B0 0x0000000184D866C0-0x0000000184D866D0
		public bool firstLogin { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815AF940-0x00000001815AF950 0x0000000184D866E0-0x0000000184D866F0
		public LoginWorkFlow workflow { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public LoginViewProperty viewProp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public LoginManager.AssetLoader loader { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public LoginManager.FlowWithMaskMgr flowWithMask { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public NetUsagePolicy netUsagePolicy { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public LoginGameUpdater gameUpdater { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public bool startConnectServer { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DisposeCoroutine_d__48 : IEnumerator<object> // TypeDefIndex: 56343
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController legacyController; // 0x20
			public Action disposeAction; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DisposeCoroutine_d__48(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184A22250-0x0000000184A22370
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994C44-0x0000000186994C90
		}
	
		// Constructors
		public LoginContext(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public LoginController ViewOnlyController(); // 0x00000001841E6090-0x00000001841E60C0
		public void Init(bool quickStart, LoginController controller, LoginWorkFlow workflow, LoginViewProperty viewProp, LoginManager.AssetLoader loader, LoginManager.FlowWithMaskMgr flowWithMask, NetUsagePolicy netUsagePolicy, LoginGameUpdater gameUpdater); // 0x000000018380A3F0-0x000000018380A4D0
		public void StartCoroutine(IEnumerator routine); // 0x0000000183A82B00-0x0000000183A82B80
		public void StopCoroutine(IEnumerator routine); // 0x000000018699286C-0x00000001869928E8
		public void SendEvent(ELoginEvent evt, object param = null); // 0x0000000186992718-0x0000000186992798
		public void Dispose(); // 0x00000001841E3F20-0x00000001841E4070
		public void ShutDown(); // 0x0000000186992798-0x000000018699286C
		public bool IsWorkflowDisposed(); // 0x00000001869926C4-0x0000000186992718
		public bool IsDisposed(); // 0x0000000186992678-0x00000001869926C4
		private void _DisposeImpl(); // 0x000000018380A4D0-0x000000018380A530
		[IteratorStateMachine(typeof(__DisposeCoroutine_d__48))]
		private static IEnumerator _DisposeCoroutine(LoginController legacyController, Action disposeAction); // 0x00000001841E4070-0x00000001841E4100
	}

	public enum ELoginEvent // TypeDefIndex: 56345
	{
		None = 0,
		V2C_U8Login = 1,
		V2C_EnterGame = 2,
		V2C_Logout = 3,
		V2C_ResourceRepair = 4,
		V2C_OpenAgeTips = 5,
		V2C_CloseAgeTips = 6,
		V2C_OpenServerSelect = 7,
		V2C_CloseServerSelect = 8,
		V2C_SelectServer = 9,
		V2C_ConfirmServer = 10,
		V2C_Relogin = 11,
		V2C_ReplayGsLogin = 12,
		C2V_PrepareGsLogin = 13
	}

	public static class LoginTextDefines // TypeDefIndex: 56346
	{
		// Fields
		public const string CS_LOGIN_CONN_FAIL = "CS_LOGIN_CONN_FAIL"; // Metadata: 0x02347C9E
		public const string HOTUPDATE_INDEX_FAILED = "HOTUPDATE_INDEX_FAILED"; // Metadata: 0x02347CB1
		public const string HOTUPDATE_IO_FAILED = "HOTUPDATE_IO_FAILED"; // Metadata: 0x02347CC8
		public const string HOTUPDATE_CHECK_VERSION = "HOTUPDATE_CHECK_VERSION"; // Metadata: 0x02347CDC
		public const string HOTUPDATE_DOWNLOADING = "HOTUPDATE_DOWNLOADING"; // Metadata: 0x02347CF4
		public const string HOTUPDATE_DECOMPRESSING = "HOTUPDATE_DECOMPRESSING"; // Metadata: 0x02347D0A
		public const string HOTUPDATE_DOWNLOAD_ERROR = "HOTUPDATE_DOWNLOAD_ERROR"; // Metadata: 0x02347D22
		public const string HOTUPDATE_DOWNLOAD_DISKFULL = "HOTUPDATE_DOWNLOAD_DISKFULL"; // Metadata: 0x02347D3B
		public const string HOTUPDATE_LOCAL_RES_CHECK = "HOTUPDATE_LOCAL_RES_CHECK"; // Metadata: 0x02347D57
		public const string HOTUPDATE_PRELOAD_RES = "HOTUPDATE_PRELOAD_RES"; // Metadata: 0x02347D71
		public const string HOTUPDATE_INVALID_LOCAL_FILES = "HOTUPDATE_INVALID_LOCAL_FILES"; // Metadata: 0x02347D87
		public const string HOTUPDATE_INIT_RES_CHANGED = "HOTUPDATE_INIT_RES_CHANGED"; // Metadata: 0x02347DA5
		public const string HOTUPDATE_DOWNLOAD_IO_ERROR = "HOTUPDATE_DOWNLOAD_IO_ERROR"; // Metadata: 0x02347DC0
		public const string HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR = "HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR"; // Metadata: 0x02347DDC
		public const string HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR = "HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR"; // Metadata: 0x02347E00
		public const string HOTUPDATE_DECOMPRESS_ERROR = "HOTUPDATE_DECOMPRESS_ERROR"; // Metadata: 0x02347E28
		public const string REMOTE_CFG_GAME_CFG_ERROR = "REMOTE_CFG_GAME_CFG_ERROR"; // Metadata: 0x02347E43
		public const string REMOTE_CFG_GAME_CFG_TIMEOUT = "REMOTE_CFG_GAME_CFG_TIMEOUT"; // Metadata: 0x02347E5D
		public const string REMOTE_CFG_NETWORK_CFG_ERROR = "REMOTE_CFG_NETWORK_CFG_ERROR"; // Metadata: 0x02347E79
		public const string REMOTE_CFG_NETWORK_CFG_TIMEOUT = "REMOTE_CFG_NETWORK_CFG_TIMEOUT"; // Metadata: 0x02347E96
		public const string REMOTE_CFG_RES_VERSION_ERROR = "REMOTE_CFG_RES_VERSION_ERROR"; // Metadata: 0x02347EB5
		public const string REMOTE_CFG_RES_VERSION_TIMEOUT = "REMOTE_CFG_RES_VERSION_TIMEOUT"; // Metadata: 0x02347ED2
		public const string REMOTE_CFG_GAME_VERSION_ERROR = "REMOTE_CFG_GAME_VERSION_ERROR"; // Metadata: 0x02347EF1
		public const string REMOTE_CFG_GAME_VERSION_TIMEOUT = "REMOTE_CFG_GAME_VERSION_TIMEOUT"; // Metadata: 0x02347F0F
		public const string LOGIN_JUDGE_EXIT_GAME = "LOGIN_JUDGE_EXIT_GAME"; // Metadata: 0x02347F2F
		public const string LOGIN_JUDGE_LOGOUT = "LOGIN_JUDGE_LOGOUT"; // Metadata: 0x02347F45
		public const string LOGIN_JUDGE_RES_REPAIR = "LOGIN_JUDGE_RES_REPAIR"; // Metadata: 0x02347F58
		public const string LOGIN_AGE_TIPS_FAILED = "LOGIN_AGE_TIPS_FAILED"; // Metadata: 0x02347F6F
		public const string LOGIN_TXT_DIALOG_CONFIRM = "LOGIN_TXT_DIALOG_CONFIRM"; // Metadata: 0x02347F85
		public const string LOGIN_TXT_DIALOG_CANCEL = "LOGIN_TXT_DIALOG_CANCEL"; // Metadata: 0x02347F9E
		public const string LOGIN_AUDIO_LANG_CN = "UI_LOGIN_ROOT_VOICE_CN"; // Metadata: 0x02347FB6
		public const string LOGIN_AUDIO_LANG_JP = "UI_LOGIN_ROOT_VOICE_JP"; // Metadata: 0x02347FCD
		public const string LOGIN_AUDIO_LANG_EN = "UI_LOGIN_ROOT_VOICE_EN"; // Metadata: 0x02347FE4
		public const string LOGIN_AUDIO_LANG_KR = "UI_LOGIN_ROOT_VOICE_KR"; // Metadata: 0x02347FFB
		public const string LOGIN_TXT_NETWORK_ERROR = "LOGIN_TXT_NETWORK_ERROR"; // Metadata: 0x02348012
		public const string LOGIN_GAME_UPGRADED = "LOGIN_GAME_UPGRADED"; // Metadata: 0x0234802A
		public const string LOGIN_TXT_SERVER_CLOSED = "LOGIN_TXT_SERVER_CLOSED"; // Metadata: 0x0234803E
		public const string LOGIN_TXT_SERVER_CLOSED_DATETIME = "LOGIN_TXT_SERVER_CLOSED_DATETIME"; // Metadata: 0x02348056
		public const string LOGIN_TXT_USR_BAN_DATETIME = "LOGIN_TXT_USR_BAN_DATETIME"; // Metadata: 0x02348077
		public const string LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER = "LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER"; // Metadata: 0x02348092
		public const string LOGIN_GET_SERVER_LIST_FAILED = "LOGIN_GET_SERVER_LIST_FAILED"; // Metadata: 0x023480BC
		public const string LOGIN_TEXT_SERVER_ZONE_FAILED = "LOGIN_TEXT_SERVER_ZONE_FAILED"; // Metadata: 0x023480D9
		public const string LOGIN_TEXT_GET_APP_VERSION_FAILED = "LOGIN_TEXT_GET_APP_VERSION_FAILED"; // Metadata: 0x023480F7
		public const string LOGIN_TEXT_ALERT_CARRIER_NETWORK = "LOGIN_TEXT_ALERT_CARRIER_NETWORK"; // Metadata: 0x02348119
		public const string LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED = "LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED"; // Metadata: 0x0234813A
		public const string LOGIN_SHADER_WARM_UP_PRELOAD_RES = "LOGIN_SHADER_WARM_UP_PRELOAD_RES"; // Metadata: 0x02348169
		public const string LOGIN_GAME_UPDATE_TIPS_DOWNLOADING = "LOGIN_GAME_UPDATE_TIPS_DOWNLOADING"; // Metadata: 0x0234818A
		public const string LOGIN_GAME_UPDATE_TIPS_PAUSE = "LOGIN_GAME_UPDATE_TIPS_PAUSE"; // Metadata: 0x023481AD
		public const string LOGIN_GAME_UPDATE_ALERT_NEWER = "LOGIN_GAME_UPDATE_ALERT_NEWER"; // Metadata: 0x023481CA
		public const string LOGIN_GAME_UPDATE_ERROR_DISK_FULL = "LOGIN_GAME_UPDATE_ERROR_DISK_FULL"; // Metadata: 0x023481E8
		public const string LOGIN_GAME_UPDATE_ALERT_SUC = "LOGIN_GAME_UPDATE_ALERT_SUC"; // Metadata: 0x0234820A
		public const string LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON = "LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON"; // Metadata: 0x02348226
		public const string LOGIN_GAME_UPDATE_ERROR_COMMON = "LOGIN_GAME_UPDATE_ERROR_COMMON"; // Metadata: 0x02348256
		public const string LOGIN_GAME_UPDATE_TITLE = "LOGIN_GAME_UPDATE_TITLE"; // Metadata: 0x02348275
		public const string LOGIN_GOTO_SHOP_FOR_GAME_UPDATE = "LOGIN_GOTO_SHOP_FOR_GAME_UPDATE"; // Metadata: 0x0234828D
		public const string LOGIN_SDK_INIT_FAILED = "LOGIN_SDK_INIT_FAILED"; // Metadata: 0x023482AD
		public const string LOGIN_DOWNLOADING_SPEED_HINT = "LOGIN_DOWNLOADING_SPEED_HINT"; // Metadata: 0x023482C3
		public const string LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME = "LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME"; // Metadata: 0x023482E0
		public const string LOGIN_NETWORK_CONGESTION_TITLE = "LOGIN_NETWORK_CONGESTION_TITLE"; // Metadata: 0x02348305
		public const string LOGIN_LOW_SCORE_DEVICE_TIP = "LOGIN_LOW_SCORE_DEVICE_TIP"; // Metadata: 0x02348324
		public const string LOGIN_REGISTRY_WRITE_FAILED = "LOGIN_REGISTRY_WRITE_FAILED"; // Metadata: 0x0234833F
	}

	public class LoginManager : ExplicitSingleton<LoginManager> // TypeDefIndex: 56365
	{
		// Fields
		public const long MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI = 104857600; // Metadata: 0x0234835B
		private ISceneHandle m_sceneHandle; // 0x10
		private LoginContext m_context; // 0x18
		private LatchUtils.InvokeWhenUnlock m_workflowFinishLatch; // 0x20
		private LatchUtils.InvokeWhenUnlock m_workflowStartLatch; // 0x28
		private Queue<WeakReference<LoginSceneComponent>> m_pendingSceneComps; // 0x30
		private HashSet<LoginSceneComponent> m_sceneComps; // 0x38
		[CompilerGenerated]
		private bool _quickStart_k__BackingField; // 0x40
		private object m_dialogBlocker; // 0x48
	
		// Properties
		public bool quickStart { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
		public bool firstLogin { get; } // 0x0000000186993898-0x00000001869938F4 
	
		// Nested types
		public class AssetLoader : IDisposable // TypeDefIndex: 56347
		{
			// Fields
			private Dictionary<string, FAssetProxyHandle> m_assetHandles; // 0x10
	
			// Constructors
			public AssetLoader(); // 0x000000018380AA10-0x000000018380AA90
	
			// Methods
			public FAssetProxyHandle CachedLoad<T>(string path)
				where T : UnityEngine.Object;
			public FAssetProxyHandle CachedLoadAsync<T>(string path)
				where T : UnityEngine.Object;
			private bool _CheckDisposedBeforeLoad(string path); // 0x0000000184701C90-0x0000000184701D00
			public void Dispose(); // 0x00000001848E3130-0x00000001848E34D0
		}
	
		public class FlowWithMaskMgr // TypeDefIndex: 56349
		{
			// Fields
			private LoginContext m_context; // 0x10
			private HashSet<string> m_activeFlows; // 0x18
	
			// Nested types
			[CompilerGenerated]
			private sealed class __FlowCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 56348
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public FlowWithMaskMgr __4__this; // 0x20
				public FFlowWithMask flow; // 0x28
				private LoginController.MaskCtrl _maskCtrl_5__2; // 0x50
				private bool _isFlowSuc_5__3; // 0x58
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public __FlowCoroutine_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x00000001841E61D0-0x00000001841E7630
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000186994D74-0x0000000186994DC0
			}
	
			// Constructors
			public FlowWithMaskMgr(LoginContext context); // 0x000000018380A5D0-0x000000018380A660
	
			// Methods
			public void StartFlow(FFlowWithMask flow); // 0x0000000183A80DD0-0x0000000183A80F10
			[IteratorStateMachine(typeof(__FlowCoroutine_d__4))]
			private IEnumerator _FlowCoroutine(FFlowWithMask flow); // 0x0000000183A80F10-0x0000000183A80FC0
			private void _OnFlowFinished(FFlowWithMask flow); // 0x000000018698D3E8-0x000000018698D4A0
		}
	
		public struct FFlowWithMask // TypeDefIndex: 56350
		{
			// Fields
			public string key; // 0x00
			public LoginController.EMaskType maskType; // 0x08
			public Func<bool> flowAction; // 0x10
			public FFlowCondition condition; // 0x18
			public float disableDelay; // 0x20
		}
	
		public struct FFlowCondition // TypeDefIndex: 56351
		{
			// Fields
			[CompilerGenerated]
			private LoginWorkFlow.ENode _priTarget_k__BackingField; // 0x00
			[CompilerGenerated]
			private LoginWorkFlow.ENode _secTarget_k__BackingField; // 0x04
	
			// Properties
			public LoginWorkFlow.ENode priTarget { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
			public LoginWorkFlow.ENode secTarget { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
	
			// Constructors
			public FFlowCondition(LoginWorkFlow.ENode target); // 0x0000000184D8CC80-0x0000000184D8CC90
			public FFlowCondition(LoginWorkFlow.ENode first, LoginWorkFlow.ENode second); // 0x0000000184D85C40-0x0000000184D85C50
	
			// Methods
			public bool IsTargetMatch(LoginWorkFlow.ENode node); // 0x00000001841E7630-0x00000001841E7690
		}
	
		[CompilerGenerated]
		private sealed class _InitCoroutine_d__17 : IEnumerator<object> // TypeDefIndex: 56352
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public bool quickStart; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _InitCoroutine_d__17(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184D30A10-0x0000000184D30A70
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994240-0x000000018699428C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56353
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<LoginAlertDialog, LoginAlertDialog.FParams> __9__29_0; // 0x08
			public static Action<LoginVocResSelDialog, LoginVocResSelDialog.FParams> __9__30_0; // 0x10
			public static Action<LoginJudgeDialog, LoginJudgeDialog.FParams> __9__36_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001869946D0-0x0000000186994734
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _AlertDialog_b__29_0(LoginAlertDialog param1, LoginAlertDialog.FParams param2); // 0x00000001869942D8-0x0000000186994308
			internal void _VocResSelDialog_b__30_0(LoginVocResSelDialog param1, LoginVocResSelDialog.FParams param2); // 0x0000000186994308-0x0000000186994330
			internal void __StartShowJudgeDialogCoroutine_b__36_0(LoginJudgeDialog param1, LoginJudgeDialog.FParams param2); // 0x0000000186994330-0x0000000186994374
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 56354
		{
			// Fields
			public object wait; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _VocResSelDialogWithConfirm_b__0(); // 0x00000001840E20A0-0x00000001840E20C0
		}
	
		[CompilerGenerated]
		private sealed class _VocResSelDialogWithConfirm_d__31 : IEnumerator<object> // TypeDefIndex: 56355
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			private __c__DisplayClass31_0 __8__1; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _VocResSelDialogWithConfirm_d__31(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186994734-0x0000000186994870
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994870-0x00000001869948BC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 56356
		{
			// Fields
			public Beyond.Misc.ObjectRef outRef; // 0x10
			public Action<Beyond.Misc.ObjectRef> callback; // 0x18
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _AlertDialogWithResult_b__0(); // 0x0000000186994374-0x00000001869943B4
		}
	
		[CompilerGenerated]
		private sealed class _AlertDialogWithResult_d__32 : IEnumerator<object> // TypeDefIndex: 56357
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Beyond.Misc.ObjectRef outRef; // 0x20
			public Action<Beyond.Misc.ObjectRef> callback; // 0x28
			public LoginManager __4__this; // 0x30
			public string desc; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _AlertDialogWithResult_d__32(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186994004-0x000000018699415C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699415C-0x00000001869941A8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 56358
		{
			// Fields
			public object wait; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _AlertDialogWithConfirm_b__0(); // 0x00000001840E20A0-0x00000001840E20C0
		}
	
		[CompilerGenerated]
		private sealed class _AlertDialogWithConfirm_d__33 : IEnumerator<object> // TypeDefIndex: 56359
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public string desc; // 0x28
			private __c__DisplayClass33_0 __8__1; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _AlertDialogWithConfirm_d__33(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186993E68-0x0000000186993FB8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186993FB8-0x0000000186994004
		}
	
		[CompilerGenerated]
		private sealed class __ShowDialogCoroutine_d__37<TDialog, TParam> : IEnumerator<object> // TypeDefIndex: 56360
			where TDialog : LoginController.Dialog
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginManager __4__this;
			public string resPath;
			public Action<TDialog, TParam> setParamFunc;
			public TParam param;
			private Beyond.Misc.ObjectRef _outRef_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __ShowDialogCoroutine_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0 // TypeDefIndex: 56361
		{
			// Fields
			public Action callback; // 0x10
	
			// Constructors
			public __c__DisplayClass39_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _MockManualSelectServer_b__0(string _); // 0x0000000182A729E0-0x0000000182A729F0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0 // TypeDefIndex: 56362
		{
			// Fields
			public LoginController controller; // 0x10
			public LoginManager __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass40_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __Init_b__0(); // 0x0000000184CA7390-0x0000000184CA73D0
		}
	
		[CompilerGenerated]
		private sealed class __LoginWorkFlowCoroutine_d__43 : IEnumerator<object> // TypeDefIndex: 56363
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public LoginController nullableCtrl; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __LoginWorkFlowCoroutine_d__43(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001841E4CB0-0x00000001841E4DE0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186994E58-0x0000000186994EA4
		}
	
		[CompilerGenerated]
		private sealed class _FetchRemoteConfigUtilSuc_d__45 : IEnumerator<object> // TypeDefIndex: 56364
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public IRemoteConfig config; // 0x20
			public string configEnv; // 0x28
			public string keyErrorWithCode; // 0x30
			public string keyTimeout; // 0x38
			private FRemoteConfigRequest _request_5__2; // 0x40
			private bool _isServiceSuc_5__3; // 0x80
			private Beyond.Misc.ObjectRef _resultRef_5__4; // 0x88
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _FetchRemoteConfigUtilSuc_d__45(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C0A020-0x0000000183C0A3F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869941F4-0x0000000186994240
		}
	
		// Constructors
		public LoginManager(); // 0x0000000184A7D450-0x0000000184A7D590
	
		// Methods
		[IteratorStateMachine(typeof(_InitCoroutine_d__17))]
		public IEnumerator InitCoroutine(bool quickStart); // 0x0000000184A20900-0x0000000184A20980
		public bool IsReLoginInProgress(); // 0x0000000186992F48-0x0000000186993060
		public static void OnReleaseMainGame(); // 0x000000018699334C-0x00000001869933D8
		public bool IsWorkflowInProgress(); // 0x0000000184A20980-0x0000000184A209B0
		public void ClearSync(); // 0x0000000186992C60-0x0000000186992CC0
		public void Clear(); // 0x000000018380E5E0-0x000000018380E620
		private void _ReleaseLoginScene(); // 0x000000018380E1E0-0x000000018380E2C0
		public void InvokeWhenWorkFlowFinished(Action callback); // 0x0000000184B523D0-0x0000000184B52420
		public void SceneComponentOnly_Bind(LoginSceneComponent comp); // 0x000000018340BA80-0x000000018340BBB0
		private void _BindPendingComponents(); // 0x00000001841E5EA0-0x00000001841E6090
		public void ToggleLoginBindingGroup(bool enable); // 0x00000001869933D8-0x00000001869934A0
		public void AlertDialog(string desc, Action callback = null); // 0x0000000186992A78-0x0000000186992C60
		public void VocResSelDialog(Action callback = null); // 0x0000000186993530-0x00000001869936D0
		[IteratorStateMachine(typeof(_VocResSelDialogWithConfirm_d__31))]
		public IEnumerator VocResSelDialogWithConfirm(); // 0x00000001869934A0-0x0000000186993530
		[IteratorStateMachine(typeof(_AlertDialogWithResult_d__32))]
		public IEnumerator AlertDialogWithResult(string desc, Beyond.Misc.ObjectRef outRef, Action<Beyond.Misc.ObjectRef> callback = null); // 0x0000000186992990-0x0000000186992A78
		[IteratorStateMachine(typeof(_AlertDialogWithConfirm_d__33))]
		public IEnumerator AlertDialogWithConfirm(string desc); // 0x00000001869928E8-0x0000000186992990
		[IDTag(0)]
		public void JudgeDialog(string desc, Action onPositive, Action onNegative); // 0x00000001869930FC-0x00000001869931EC
		[IDTag(1)]
		public void JudgeDialog(LoginJudgeDialog.FParams param); // 0x0000000186993060-0x00000001869930FC
		private void _StartShowJudgeDialogCoroutine(LoginJudgeDialog.FParams param); // 0x00000001869936D0-0x0000000186993898
		[IteratorStateMachine(typeof(__ShowDialogCoroutine_d__37<TDialog, TParam>))]
		private IEnumerator _ShowDialogCoroutine<TDialog, TParam>(string resPath, TParam param, Action<TDialog, TParam> setParamFunc)
			where TDialog : LoginController.Dialog;
		public void MockLoginWithCallback(Action<string> callback); // 0x00000001841E5AD0-0x00000001841E5BC0
		public void MockManualSelectServer(string uid, Action callback); // 0x00000001869931EC-0x000000018699334C
		private void _Init(); // 0x000000018380AC70-0x000000018380B290
		public bool IsLoginSceneLoading(); // 0x000000018340B9B0-0x000000018340BA10
		private void _PrepareBeforeLoginProcess(); // 0x000000018380A660-0x000000018380A6E0
		[IteratorStateMachine(typeof(__LoginWorkFlowCoroutine_d__43))]
		private IEnumerator _LoginWorkFlowCoroutine(LoginController nullableCtrl); // 0x0000000184CA73D0-0x0000000184CA7460
		private void _ClearWorkflowAndContext(bool isShutDownMode); // 0x00000001841E5120-0x00000001841E51F0
		[IteratorStateMachine(typeof(_FetchRemoteConfigUtilSuc_d__45))]
		public static IEnumerator FetchRemoteConfigUtilSuc(IRemoteConfig config, string configEnv, string keyErrorWithCode, string keyTimeout); // 0x0000000184CAF5B0-0x0000000184CAF670
		private static string _ExtractErrorInfo(HttpSender.Result result, string keyErrorWithCode, string keyTimeout); // 0x0000000183C0A3F0-0x0000000183C0A480
		[Conditional("DEVELOPMENT_BUILD")]
		public static void DevOnlyCheckEnableLocalResMode(ref bool enable); // 0x0000000186992CC0-0x0000000186992D40
		[Conditional("DEVELOPMENT_BUILD")]
		public static void DevOnlyUseLocalResVersion(ResVersionDevCfg config, ref bool useLocalResVersion); // 0x0000000186992D40-0x0000000186992F48
	}

	public class VietnamLoginAgePanel : MonoBehaviour // TypeDefIndex: 56366
	{
		// Fields
		private const string PREFAB_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/AgeTipsPanel.prefab"; // Metadata: 0x02348363
		private static FAssetProxyHandle s_prefabAssetHandle; // 0x00
		public static GameObject instance; // 0x18
	
		// Constructors
		public VietnamLoginAgePanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static void Init(); // 0x00000001841E4E90-0x00000001841E4EF0
		public static void UnInit(); // 0x0000000186995914-0x000000018699598C
		private static void _Init(); // 0x000000018699598C-0x0000000186995C14
		private static void _UnInit(); // 0x0000000186995C14-0x0000000186995DB4
		private void OnApplicationQuit(); // 0x0000000186995828-0x0000000186995914
	}

	public class VietnamLoginAgeTipsPanelCtrl : MonoBehaviour // TypeDefIndex: 56367
	{
		// Fields
		[SerializeField]
		private UIDrag _UIDrag; // 0x18
		[SerializeField]
		private UIButton _tipsBtn; // 0x20
		[SerializeField]
		private UIButton _circleBtn; // 0x28
		[SerializeField]
		private UIStateController _stateController; // 0x30
	
		// Constructors
		public VietnamLoginAgeTipsPanelCtrl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Awake(); // 0x0000000186995DB4-0x0000000186995FF0
		private void _SetStateTips(PointerEventData eventData); // 0x000000018699608C-0x0000000186996128
		private void _SetStateCircle(PointerEventData eventData); // 0x0000000186995FF0-0x000000018699608C
	}

	public static class RenderPipelineDataLoader // TypeDefIndex: 56368
	{
		// Fields
		public static FAssetProxyHandle s_globalSettings; // 0x00
		public static FAssetProxyHandle s_pipelineAsset; // 0x14
	
		// Methods
		public static void LoadSimpleRpData(); // 0x00000001841E42D0-0x00000001841E43F0
		public static void PreloadFullRpResources(); // 0x000000018380ECC0-0x000000018380EE70
		public static bool IsPreLoadFinished(); // 0x0000000183C12270-0x0000000183C12330
		public static void LoadFullRpResources(); // 0x00000001841E44D0-0x00000001841E4640
	}

	[DefaultExecutionOrder(22000)]
	public class TailGameLoop : MonoBehaviour // TypeDefIndex: 56369
	{
		// Constructors
		public TailGameLoop(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Update(); // 0x0000000182F5C450-0x0000000182F5C4C0
		private void LateUpdate(); // 0x0000000182F5C8C0-0x0000000182F5C930
	}
}

namespace Beyond.Login
{
	public class LoginCheckForUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 56412
	{
		// Fields
		private LoginGameUpdater m_sdk; // 0x20
		private bool m_checkSuccess; // 0x28
		private const string REQUEST_API = "/api/game/get_latest"; // Metadata: 0x023484EB
		private const string REQUEST_PARAM_FORMAT = "appcode={0}&channel={1}&version={2}&platform={3}&sub_channel={4}&source={5}"; // Metadata: 0x02348500
		private const string REQUEST_URL_FORMAT = "{0}{1}?{2}"; // Metadata: 0x0234854D
		private const string PRAM_SOURCE = "game"; // Metadata: 0x02348558
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B1850-0x00000001849B1880 
	
		// Nested types
		private class AppVersionRespone // TypeDefIndex: 56404
		{
			// Fields
			public int action; // 0x10
			public int state; // 0x14
	
			// Constructors
			public AppVersionRespone(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __CheckForUpdateCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 56405
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __CheckForUpdateCoroutine_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018340A370-0x000000018340B960
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699C998-0x000000018699C9E4
		}
	
		[CompilerGenerated]
		private sealed class __AlertAndQuitForExtraConfigFatalError_d__5 : IEnumerator<object> // TypeDefIndex: 56406
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __AlertAndQuitForExtraConfigFatalError_d__5(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001814F7CD0-0x00000001814F90C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001814F90C0-0x00000001814F9110
		}
	
		[CompilerGenerated]
		private sealed class _AlertNoMatchDeviceBeforeLogin_d__6 : IEnumerator<object> // TypeDefIndex: 56407
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _AlertNoMatchDeviceBeforeLogin_d__6(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001814F60E0-0x00000001814F7C80
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001814F7C80-0x00000001814F7CD0
		}
	
		[CompilerGenerated]
		private sealed class __CheckForUpdateCoroutineMobile_d__7 : IEnumerator<object> // TypeDefIndex: 56408
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			private LoginGameUpdater.Result _result_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __CheckForUpdateCoroutineMobile_d__7(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001814F9110-0x00000001814FA7A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001814FA7A0-0x00000001814FA7F0
		}
	
		[CompilerGenerated]
		private sealed class __CheckForUpdateCoroutinePC_d__9 : IEnumerator<object> // TypeDefIndex: 56409
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __CheckForUpdateCoroutinePC_d__9(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001814FA7F0-0x00000001814FAF80
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001814FAF80-0x00000001814FAFD0
		}
	
		[CompilerGenerated]
		private sealed class __CheckForUpdatePC_d__10 : IEnumerator<object> // TypeDefIndex: 56410
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			private Beyond.Misc.ObjectRef _actionRef_5__2; // 0x28
			private string _errorInfo_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __CheckForUpdatePC_d__10(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001814FAFD0-0x00000001814FD090
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001814FD090-0x00000001814FD0E0
		}
	
		[CompilerGenerated]
		private sealed class __GetOnlineAppVersion_d__12 : IEnumerator<object> // TypeDefIndex: 56411
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			public Beyond.Misc.ObjectRef outRef; // 0x28
			private string _url_5__2; // 0x30
			private WaitForAsyncTask<HttpSender.Result<AppVersionRespone>> _httpResIndex_5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GetOnlineAppVersion_d__12(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001814FD0E0-0x00000001814FF2C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001814FF2C0-0x00000001814FF310
		}
	
		// Constructors
		public LoginCheckForUpdateNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x00000001845E8660-0x00000001845E8760
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutine_d__4))]
		private IEnumerator _CheckForUpdateCoroutine(); // 0x00000001845E8760-0x00000001845E87D0
		[IteratorStateMachine(typeof(__AlertAndQuitForExtraConfigFatalError_d__5))]
		private IEnumerator _AlertAndQuitForExtraConfigFatalError(); // 0x00000001814F5A60-0x00000001814F60E0
		[IteratorStateMachine(typeof(_AlertNoMatchDeviceBeforeLogin_d__6))]
		public static IEnumerator AlertNoMatchDeviceBeforeLogin(); // 0x0000000184D351D0-0x0000000184D35230
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutineMobile_d__7))]
		private IEnumerator _CheckForUpdateCoroutineMobile(); // 0x0000000186996F20-0x0000000186996FB0
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutinePC_d__9))]
		private IEnumerator _CheckForUpdateCoroutinePC(); // 0x0000000184D1F080-0x0000000184D1F0F0
		[IteratorStateMachine(typeof(__CheckForUpdatePC_d__10))]
		private IEnumerator _CheckForUpdatePC(); // 0x0000000184D1F010-0x0000000184D1F080
		[IteratorStateMachine(typeof(__GetOnlineAppVersion_d__12))]
		private IEnumerator _GetOnlineAppVersion(Beyond.Misc.ObjectRef outRef); // 0x0000000184CE7A50-0x0000000184CE7AE0
		private string _GetRequestPram(); // 0x00000001838128E0-0x0000000183812B00
	}

	public class LoginCreateRoleNode : LoginWorkFlow.Node // TypeDefIndex: 56414
	{
		// Fields
		public const string LUA_SYS_NAME = "LeadingCharacter"; // Metadata: 0x0234855D
		private WorkProcess m_activeProcess; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B1820-0x00000001849B1850 
	
		// Nested types
		private class WorkProcess : CustomYieldInstruction, IDisposable // TypeDefIndex: 56413
		{
			// Fields
			private LoginCreateRoleNode m_closure; // 0x10
			private bool m_isFinished; // 0x18
	
			// Properties
			public override bool keepWaiting { get; } // 0x00000001869A00CC-0x00000001869A011C 
	
			// Constructors
			public WorkProcess(LoginCreateRoleNode closure); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public void Dispose(); // 0x00000001869A0058-0x00000001869A00CC
		}
	
		// Constructors
		public LoginCreateRoleNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void OnDispose(); // 0x00000001846DD050-0x00000001846DD0A0
		public override bool CanCancel(); // 0x0000000186996FB0-0x0000000186996FFC
		public override CustomYieldInstruction Work(); // 0x0000000184CCA6C0-0x0000000184CCA760
		public void __iFixBaseProxy_OnDispose(); // 0x0000000186997004-0x000000018699700C
		public bool __iFixBaseProxy_CanCancel(); // 0x0000000186996FFC-0x0000000186997004
	}

	public class LoginDownloadTask : IDisposable // TypeDefIndex: 56417
	{
		// Fields
		private bool m_isDownloadFinished; // 0x10
		private HGDownloader.TaskHandler m_downloadTask; // 0x18
		private FResourceDiff m_resDiff; // 0x20
		private LocalResPref m_localResPref; // 0x60
		private string m_patchInfo; // 0x68
		private IEnumerator m_mockCoroutine; // 0x70
		private bool m_isInitial; // 0x78
		[CompilerGenerated]
		private string _vitalError_k__BackingField; // 0x80
		private NetUsagePolicy m_netUsagePolicy; // 0x88
	
		// Properties
		public string vitalError { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184CD9970-0x0000000184CD9980
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 56415
		{
			// Fields
			public LoginDownloadTask __4__this; // 0x10
			public HGDownloader.PauseReason reason; // 0x18
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnDownloadPaused_b__1(); // 0x000000018699C798-0x000000018699C7C0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56416
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__24_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018699C89C-0x000000018699C900
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnDownloadPaused_b__24_0(); // 0x000000018699C6E8-0x000000018699C70C
		}
	
		// Constructors
		public LoginDownloadTask(FResourceDiff resDiff, LocalResPref localResPref, string patchInfo, bool isInitial, NetUsagePolicy netUsagePolicy); // 0x00000001869984DC-0x0000000186998558
	
		// Methods
		public HGDownloader.DownloadProgress GetDownloadProgress(); // 0x00000001869970FC-0x0000000186997194
		public float GetDecompressProgress(); // 0x0000000186997098-0x00000001869970FC
		public HGDownloader.WorkState GetWorkState(); // 0x0000000186997194-0x00000001869971F4
		public bool Tick(); // 0x00000001869971F4-0x0000000186997260
		public void Dispose(); // 0x000000018699700C-0x0000000186997098
		private void _StartDownload(); // 0x00000001869981DC-0x00000001869984DC
		private void _StartDownloadImpl(); // 0x0000000186997E4C-0x00000001869981DC
		private List<HGFolder> _GetAllFileList(LocalResPref localResPref); // 0x0000000186997260-0x000000018699773C
		private List<HGFileInfo> _GetFileList(string rootUrl); // 0x000000018699773C-0x000000018699797C
		private void _OnDownloadFinish(); // 0x0000000186997B98-0x0000000186997BE8
		private bool _OnDownloadError(HGRetCodeType codeType, int errorCode); // 0x000000018699797C-0x0000000186997B98
		private void _OnDownloadPaused(HGDownloader.PauseReason reason); // 0x0000000186997BE8-0x0000000186997E4C
	}

	public class LoginGameSettingInitializer : MonoBehaviour // TypeDefIndex: 56418
	{
		// Fields
		private static bool s_isInitialized; // 0x00
		private RectTransform m_rectTransform; // 0x18
		private UICanvasScaleHelper m_canvasScaleHelper; // 0x20
	
		// Constructors
		public LoginGameSettingInitializer(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x0000000183BFCCE0-0x0000000183BFCD40
		private void OnEnable(); // 0x0000000183BFCD40-0x0000000183BFCDC0
		private void _TryInitializeComponents(); // 0x0000000183BFCE00-0x0000000183BFCEF0
		private void _InitGameSettingStateInLogin(); // 0x0000000183BFCDC0-0x0000000183BFCE00
		private void _InitGameSettingNotchPadding(); // 0x0000000183BFD130-0x0000000183BFD310
	}

	public class LoginGameUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 56421
	{
		// Fields
		private LoginGameUpdater m_sdk; // 0x20
		private NetUsagePolicy m_netUsagePolicy; // 0x28
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B17C0-0x00000001849B17F0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __GameUpdateCoroutine_d__5 : IEnumerator<object> // TypeDefIndex: 56419
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GameUpdateCoroutine_d__5(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184D83CA0-0x0000000184D83CB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699D2E4-0x000000018699D330
		}
	
		[CompilerGenerated]
		private sealed class __GameUpdateCoroutineMobileImpl_d__6 : IEnumerator<object> // TypeDefIndex: 56420
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdateNode __4__this; // 0x20
			private LoginGameUpdater.Result _result_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GameUpdateCoroutineMobileImpl_d__6(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699D0BC-0x000000018699D298
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699D298-0x000000018699D2E4
		}
	
		// Constructors
		public LoginGameUpdateNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x00000001845E87D0-0x00000001845E88E0
		[IteratorStateMachine(typeof(__GameUpdateCoroutine_d__5))]
		private IEnumerator _GameUpdateCoroutine(); // 0x00000001845E88E0-0x00000001845E8940
		[IteratorStateMachine(typeof(__GameUpdateCoroutineMobileImpl_d__6))]
		private IEnumerator _GameUpdateCoroutineMobileImpl(); // 0x0000000186998CC0-0x0000000186998D50
	}

	public class LoginGameUpdater // TypeDefIndex: 56443
	{
		// Fields
		private const float COOLDOWN_INSTALL = 1f; // Metadata: 0x0234856E
		private const int ERROR_CODE_NETWORK = 1103; // Metadata: 0x02348572
		private const int ERROR_INIT_FAILED = -11101; // Metadata: 0x02348574
		private const int ERROR_DESERIALIZE_FAILED = -10001; // Metadata: 0x02348578
		public const int ERROR_ACTION = -20000; // Metadata: 0x0234857C
		private const int WAIT_TIME_SECONDS_MIN = 5; // Metadata: 0x02348580
		private const int WAIT_TIME_SECONDS_MAX = 9; // Metadata: 0x02348581
		private Options m_options; // 0x10
		private IGameUpdateInterface m_sdkImpl; // 0x28
		private bool m_hasUpdateAlerted; // 0x30
		private Context m_context; // 0x38
		private LoginProgress m_progress; // 0x40
		private LoginHotUpdateProp m_hotUpdateProp; // 0x48
	
		// Nested types
		public enum CodeType // TypeDefIndex: 56422
		{
			CODE_2103 = 2103,
			CODE_2105 = 2105,
			CODE_2200 = 2200,
			CODE_2201 = 2201,
			CODE_2202 = 2202,
			CODE_2203 = 2203,
			CODE_2204 = 2204,
			CODE_2205 = 2205,
			CODE_2206 = 2206,
			CODE_2207 = 2207,
			CODE_2208 = 2208,
			CODE_2209 = 2209
		}
	
		public enum UpdateType // TypeDefIndex: 56423
		{
			FullUpdate = 0,
			IncrementalUpdate = 1,
			GoToBilibile = 3,
			GoToTaptap = 4,
			GoToAppStore = 5,
			GoToGooglePlay = 6,
			GoToSamsungStore = 7,
			GoToRustore = 8
		}
	
		public enum UpdateCode // TypeDefIndex: 56424
		{
			Success = 0
		}
	
		public enum UpdateAction // TypeDefIndex: 56425
		{
			Invalid = -1,
			Latest = 0,
			ForcedUpdate = 1,
			OptionalUpdate = 2,
			Error = 3,
			Congestion = 200
		}
	
		public class HGLatestGameInfo // TypeDefIndex: 56426
		{
			// Fields
			public int code; // 0x10
			public string version; // 0x18
			public int action; // 0x20
			public int updateType; // 0x24
			public string updateInfo; // 0x28
			public int state; // 0x30
	
			// Constructors
			public HGLatestGameInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class NotificationTitleConfig // TypeDefIndex: 56427
		{
			// Fields
			public string downloading; // 0x10
			public string pause; // 0x18
	
			// Constructors
			public NotificationTitleConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class HGUpdateConfig // TypeDefIndex: 56428
		{
			// Fields
			public string downloadPath; // 0x10
	
			// Constructors
			public HGUpdateConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public struct Options // TypeDefIndex: 56429
		{
			// Fields
			public NetUsagePolicy netUsagePolicy; // 0x00
			public Action<string, Action> alertDialog; // 0x08
			public LoginContext loginContext; // 0x10
		}
	
		public class Result // TypeDefIndex: 56430
		{
			// Fields
			public bool needRetry; // 0x10
			public string errorInfo; // 0x18
			public int code; // 0x20
			public bool auditing; // 0x24
	
			// Constructors
			public Result(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class Context // TypeDefIndex: 56431
		{
			// Fields
			public long taskId; // 0x10
			public string errorInfo; // 0x18
			public string logError; // 0x20
			public bool needClear; // 0x28
			public HGLatestGameInfo gameInfo; // 0x30
			[CompilerGenerated]
			private bool _complete_k__BackingField; // 0x38
			[CompilerGenerated]
			private int _code_k__BackingField; // 0x3C
	
			// Properties
			public bool complete { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
			public int code { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
	
			// Constructors
			public Context(); // 0x0000000186996808-0x0000000186996870
	
			// Methods
			public void CompleteWithCode(int pCode); // 0x0000000186996750-0x00000001869967AC
			public void UncompleteWithCode(int pCode); // 0x00000001869967AC-0x0000000186996808
		}
	
		[CompilerGenerated]
		private sealed class _CheckLastGameInfo_d__23 : IEnumerator<object> // TypeDefIndex: 56432
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Result result; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CheckLastGameInfo_d__23(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699BB30-0x000000018699BD74
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699BD74-0x000000018699BDC0
		}
	
		[CompilerGenerated]
		private sealed class _DoUpdate_d__24 : IEnumerator<object> // TypeDefIndex: 56433
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Result result; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DoUpdate_d__24(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699C0A8-0x000000018699C3B4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699C3B4-0x000000018699C400
		}
	
		[CompilerGenerated]
		private sealed class __GetLastGameInfo_d__25 : IEnumerator<object> // TypeDefIndex: 56434
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Context context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GetLastGameInfo_d__25(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699D330-0x000000018699D9A8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699D9A8-0x000000018699D9F4
		}
	
		[CompilerGenerated]
		private sealed class __UpdateGame_d__26 : IEnumerator<object> // TypeDefIndex: 56435
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Context context; // 0x28
			private HGLatestGameInfo _gameInfo_5__2; // 0x30
			private long _size_5__3; // 0x38
			private bool _enableMobileData_5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __UpdateGame_d__26(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699DDD4-0x000000018699E4A4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699E4A4-0x000000018699E4F0
		}
	
		[CompilerGenerated]
		private sealed class __DoTaskUpdating_d__27 : IEnumerator<object> // TypeDefIndex: 56436
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Context context; // 0x28
			private long _taskId_5__2; // 0x30
			private int _status_5__3; // 0x38
			private long _curSize_5__4; // 0x40
			private long _totalSize_5__5; // 0x48
			private long _speed_5__6; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DoTaskUpdating_d__27(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699CA30-0x000000018699D024
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699D024-0x000000018699D070
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 56437
		{
			// Fields
			public bool wait; // 0x10
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __YieldErrorAlert_b__0(); // 0x0000000184D8CCB0-0x0000000184D8CCC0
		}
	
		[CompilerGenerated]
		private sealed class __YieldErrorAlert_d__32 : IEnumerator<object> // TypeDefIndex: 56438
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public string desc; // 0x28
			private __c__DisplayClass32_0 __8__1; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __YieldErrorAlert_d__32(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699E99C-0x000000018699EAD8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699EAD8-0x000000018699EB24
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 56439
		{
			// Fields
			public bool rejected; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_1 // TypeDefIndex: 56440
		{
			// Fields
			public bool complete; // 0x10
			public __c__DisplayClass33_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass33_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __YieldCheckNetUsagePolicy_b__0(); // 0x00000001815EFCD0-0x00000001815EFCE0
			internal void __YieldCheckNetUsagePolicy_b__1(); // 0x000000018699C824-0x000000018699C844
			internal void __YieldCheckNetUsagePolicy_b__2(); // 0x00000001815EFCD0-0x00000001815EFCE0
		}
	
		[CompilerGenerated]
		private sealed class __YieldCheckNetUsagePolicy_d__33 : IEnumerator<object> // TypeDefIndex: 56441
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private __c__DisplayClass33_0 __8__1; // 0x20
			public LoginGameUpdater __4__this; // 0x28
			public long downloadSize; // 0x30
			private __c__DisplayClass33_1 __8__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __YieldCheckNetUsagePolicy_d__33(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699E6E4-0x000000018699E950
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699E950-0x000000018699E99C
		}
	
		[CompilerGenerated]
		private sealed class __WaitForTaskCancel_d__34 : IEnumerator<object> // TypeDefIndex: 56442
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public long taskId; // 0x28
			private bool _isCanceled_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __WaitForTaskCancel_d__34(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018699E4F0-0x000000018699E570
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699E570-0x000000018699E5BC
		}
	
		// Constructors
		public LoginGameUpdater(Options options); // 0x000000018380A530-0x000000018380A5D0
	
		// Methods
		public void Clear(); // 0x00000001845E8E10-0x00000001845E8E80
		[IteratorStateMachine(typeof(_CheckLastGameInfo_d__23))]
		public IEnumerator CheckLastGameInfo(Result result); // 0x0000000186998D50-0x0000000186998DF8
		[IteratorStateMachine(typeof(_DoUpdate_d__24))]
		public IEnumerator DoUpdate(Result result); // 0x0000000186998DF8-0x0000000186998EA0
		[IteratorStateMachine(typeof(__GetLastGameInfo_d__25))]
		private IEnumerator _GetLastGameInfo(Context context); // 0x000000018699929C-0x0000000186999344
		[IteratorStateMachine(typeof(__UpdateGame_d__26))]
		private IEnumerator _UpdateGame(Context context); // 0x000000018699958C-0x0000000186999634
		[IteratorStateMachine(typeof(__DoTaskUpdating_d__27))]
		private IEnumerator _DoTaskUpdating(Context context); // 0x00000001869991F4-0x000000018699929C
		private void _OnDownloadStart(); // 0x0000000186999444-0x000000018699958C
		private void _OnDownloadProgress(long curSize, long totalSize, long speed); // 0x0000000186999344-0x0000000186999444
		[IteratorStateMachine(typeof(__YieldErrorAlert_d__32))]
		private IEnumerator _YieldErrorAlert(string desc); // 0x0000000186999774-0x000000018699981C
		[IteratorStateMachine(typeof(__YieldCheckNetUsagePolicy_d__33))]
		private IEnumerator _YieldCheckNetUsagePolicy(long downloadSize); // 0x00000001869996D4-0x0000000186999774
		[IteratorStateMachine(typeof(__WaitForTaskCancel_d__34))]
		private IEnumerator _WaitForTaskCancel(long taskId); // 0x0000000186999634-0x00000001869996D4
		private static void _CreateDirectoryIfNotExists(string folderPath); // 0x0000000186999188-0x00000001869991F4
		public void ClearWaitProgress(); // 0x0000000183A80A00-0x0000000183A80AD0
		public void ShowWaitProgress(); // 0x0000000186999044-0x0000000186999188
		public int GetNoAlertCode(); // 0x0000000186998EA0-0x0000000186998EF0
		public float GetWaitTime(); // 0x0000000186998EF0-0x0000000186999044
	}

	public class LoginGSNode : LoginWorkFlow.Node // TypeDefIndex: 56453
	{
		// Fields
		private const int FLOW_NONE = 0; // Metadata: 0x023485AA
		private const int FLOW_WORKING = 1; // Metadata: 0x023485AB
		private const int FLOW_FINISH = 2; // Metadata: 0x023485AC
		private const int FLOW_ABORTING = 3; // Metadata: 0x023485AD
		private EnterGameServiceFlow m_flow; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B17F0-0x00000001849B1820 
	
		// Nested types
		private class EnterGameServiceFlow : CustomYieldInstruction // TypeDefIndex: 56451
		{
			// Fields
			private LoginContext m_context; // 0x10
			private LoginGSNode m_curNode; // 0x18
			private Beyond.Misc.ObjectRef m_dialogBlocker; // 0x20
			private int m_state; // 0x28
	
			// Properties
			public override bool keepWaiting { get; } // 0x000000018404E110-0x000000018404E170 
	
			// Nested types
			[CompilerGenerated]
			private sealed class __EnterGameCoroutine_d__11 : IEnumerator<object> // TypeDefIndex: 56444
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public EnterGameServiceFlow __4__this; // 0x20
				private SDKPromiseEnumerator<U8AuthV2Result> _authPromise_5__2; // 0x28
				private string _token_5__3; // 0x30
				private string _uid_5__4; // 0x38
				private Beyond.Misc.ObjectRef _loginRespRef_5__5; // 0x40
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public __EnterGameCoroutine_d__11(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x0000000183A853B0-0x0000000183A85DE0
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018699D070-0x000000018699D0BC
			}
	
			[CompilerGenerated]
			private sealed class __NetConnectAndGSLogin_d__12 : IEnumerator<object> // TypeDefIndex: 56445
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public Beyond.Misc.ObjectRef loginRespRef; // 0x20
				public EnterGameServiceFlow __4__this; // 0x28
				public string uid; // 0x30
				public string token; // 0x38
				private HGNetSessionConnectYield _connectTask_5__2; // 0x40
				private int _maxRetryCount_5__3; // 0x48
				private int _currentRetry_5__4; // 0x4C
				private HGNetSessionLoginYield _loginHandler_5__5; // 0x50
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public __NetConnectAndGSLogin_d__12(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x0000000183A4B510-0x0000000183A4B840
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018699DB98-0x000000018699DBE4
			}
	
			[CompilerGenerated]
			private sealed class __YieldAlertError_d__14 : IEnumerator<object> // TypeDefIndex: 56446
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string errorInfo; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public __YieldAlertError_d__14(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x000000018699E608-0x000000018699E698
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018699E698-0x000000018699E6E4
			}
	
			[CompilerGenerated]
			private sealed class __SaveCurrentUserToServerConfig_d__15 : IEnumerator<object> // TypeDefIndex: 56447
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public EnterGameServiceFlow __4__this; // 0x20
				public string uid; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public __SaveCurrentUserToServerConfig_d__15(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x0000000183DA3230-0x0000000183DA3310
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018699DD3C-0x000000018699DD88
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass16_0 // TypeDefIndex: 56448
			{
				// Fields
				public Beyond.Misc.ObjectRef waitForCallback; // 0x10
	
				// Constructors
				public __c__DisplayClass16_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal void __MockManualSelectServer_b__0(); // 0x000000018699C774-0x000000018699C798
			}
	
			[CompilerGenerated]
			private sealed class __MockManualSelectServer_d__16 : IEnumerator<object> // TypeDefIndex: 56449
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string uid; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public __MockManualSelectServer_d__16(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x000000018699D9F4-0x000000018699DB4C
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018699DB4C-0x000000018699DB98
			}
	
			[CompilerGenerated]
			private sealed class __OnAuthError_d__17 : IEnumerator<object> // TypeDefIndex: 56450
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public object rejectInfo; // 0x20
				public EnterGameServiceFlow __4__this; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public __OnAuthError_d__17(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x000000018699DBE4-0x000000018699DCA4
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018699DCA4-0x000000018699DCF0
			}
	
			// Constructors
			public EnterGameServiceFlow(LoginGSNode node); // 0x00000001849D6330-0x00000001849D63B0
	
			// Methods
			public void MarkAborting(); // 0x00000001869968D0-0x0000000186996928
			public void EnterGame(); // 0x0000000183A84270-0x0000000183A84390
			public bool IsInterruptable(); // 0x0000000186996870-0x00000001869968D0
			public bool TryInterrupt(); // 0x0000000186996928-0x0000000186996990
			[IteratorStateMachine(typeof(__EnterGameCoroutine_d__11))]
			private IEnumerator _EnterGameCoroutine(); // 0x0000000183A84390-0x0000000183A84400
			[IteratorStateMachine(typeof(__NetConnectAndGSLogin_d__12))]
			private IEnumerator _NetConnectAndGSLogin(string uid, string token, Beyond.Misc.ObjectRef loginRespRef); // 0x0000000183A84400-0x0000000183A844C0
			private static string _ExtractErrorInfo(HttpSender.Result result, string keyErrorWithCode, string keyTimeout); // 0x0000000186996990-0x0000000186996A8C
			[IteratorStateMachine(typeof(__YieldAlertError_d__14))]
			private IEnumerator _YieldAlertError(string errorInfo); // 0x0000000186996C34-0x0000000186996CD0
			[IteratorStateMachine(typeof(__SaveCurrentUserToServerConfig_d__15))]
			private IEnumerator _SaveCurrentUserToServerConfig(string uid); // 0x0000000183A4B930-0x0000000183A4B9C0
			[IteratorStateMachine(typeof(__MockManualSelectServer_d__16))]
			private IEnumerator _MockManualSelectServer(string uid); // 0x0000000186996A8C-0x0000000186996B28
			[IteratorStateMachine(typeof(__OnAuthError_d__17))]
			private IEnumerator _OnAuthError(object rejectInfo); // 0x0000000186996B28-0x0000000186996BD0
			private void _ReLoginWhenErrorEncountered(); // 0x0000000186996BD0-0x0000000186996C34
			private static void _GlobalLoginSucBusiness(MSG_B1 msg); // 0x00000001840EB370-0x00000001840EB430
			[CompilerGenerated]
			private bool __EnterGameCoroutine_b__11_0(); // 0x0000000184D84FC0-0x0000000184D84FD0
		}
	
		[CompilerGenerated]
		private sealed class __ConfirmServer_d__10 : IEnumerator<object> // TypeDefIndex: 56452
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private SDKPromiseEnumerator<U8ConfirmServerResult> _confirmPromise_5__2; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ConfirmServer_d__10(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001840E9A00-0x00000001840EA1F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699C9E4-0x000000018699CA30
		}
	
		// Constructors
		public LoginGSNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x00000001849D61A0-0x00000001849D62E0
		public override bool OnEvent(ELoginEvent evt, object param); // 0x000000018470B2D0-0x000000018470B370
		[IteratorStateMachine(typeof(__ConfirmServer_d__10))]
		private static IEnumerator _ConfirmServer(); // 0x0000000183A847F0-0x0000000183A84850
		private void _FallbackToInitWithMask(bool bLogoutAccount); // 0x0000000186998718-0x000000018699889C
		private void _OnEventLogout(); // 0x0000000186998A38-0x0000000186998B7C
		private void _OnEventResourceRepair(); // 0x0000000186998B7C-0x0000000186998CC0
		private bool _LogoutToInitNode(); // 0x000000018699897C-0x0000000186998A38
		private bool _FallbackToInitNodeImpl(); // 0x0000000186998698-0x0000000186998718
		private bool _FallbackToResRepairImpl(); // 0x000000018699889C-0x000000018699897C
		[CompilerGenerated]
		private void __OnEventLogout_b__12_0(); // 0x0000000186998560-0x000000018699856C
		[CompilerGenerated]
		private void __OnEventResourceRepair_b__13_0(); // 0x000000018699856C-0x0000000186998698
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1); // 0x0000000186998558-0x0000000186998560
	}

	public class LoginHotUpdateProp : LoginProperty<LoginHotUpdateModel> // TypeDefIndex: 56454
	{
		// Constructors
		public LoginHotUpdateProp(LoginWorkFlow workflow); // 0x0000000183A80AD0-0x0000000183A80B70
	}

	public class LoginHotUpdateModel // TypeDefIndex: 56457
	{
		// Fields
		public string title; // 0x10
		public string desc; // 0x18
		public IProgress progress; // 0x20
	
		// Nested types
		public interface IProgress // TypeDefIndex: 56455
		{
			// Methods
			double GetTotal();
			double GetCurrent();
			string GetInfo();
		}
	
		public class SimpleProgress : Beyond.Login.LoginHotUpdateModel.IProgress // TypeDefIndex: 56456
		{
			// Fields
			public double current; // 0x10
	
			// Constructors
			public SimpleProgress(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public double GetCurrent(); // 0x00000001839367C0-0x00000001839367F0
			public double GetTotal(); // 0x00000001839369B0-0x00000001839369E0
			public string GetInfo(); // 0x00000001839369E0-0x0000000183936A10
		}
	
		// Constructors
		public LoginHotUpdateModel(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class LoginHotUpdater : CustomYieldInstruction, IDisposable // TypeDefIndex: 56483
	{
		// Fields
		private const int MODE_SKIP = 0; // Metadata: 0x023485AE
		private const int MODE_DOWNLOAD = 1; // Metadata: 0x023485AF
		private const int MODE_LOCAL = 2; // Metadata: 0x023485B0
		private static bool s_hasInitialAssetChanged; // 0x00
		private static bool s_isNeedSoftRestart; // 0x01
		private LoginContext m_loginCxt; // 0x10
		private IEnumerator m_mainRoutine; // 0x18
		private LoginProgress m_progress; // 0x20
		private LoginHotUpdateProp m_hotupdateProp; // 0x28
		private LoginDownloadTask m_downloadTask; // 0x30
		private LoginLocalResTask m_localResTask; // 0x38
		private IEnumerator m_downloadingShaderWarmupRoutine; // 0x40
		private bool m_resRepairMode; // 0x48
		public const string URL_GET_SPLIT = "/"; // Metadata: 0x023485B1
	
		// Properties
		public override bool keepWaiting { get; } // 0x0000000184CEB9B0-0x0000000184CEB9E0 
	
		// Nested types
		public class HotUpdateInfo // TypeDefIndex: 56458
		{
			// Fields
			public FResourceDiff resDiff; // 0x10
			public LocalResPref localResPref; // 0x50
	
			// Constructors
			public HotUpdateInfo(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool CheckIfNeedReload(); // 0x0000000186996CD0-0x0000000186996E7C
			public bool HasChangedByType(EVFSBlockType type); // 0x0000000183DA4D90-0x0000000183DA4DF0
			public bool HasAssetsChanged(); // 0x0000000186996E7C-0x0000000186996F20
		}
	
		public class WorkContext // TypeDefIndex: 56459
		{
			// Fields
			public HotUpdateInfo updateInitial; // 0x10
			public HotUpdateInfo updateMain; // 0x18
			public string vitalError; // 0x20
			public bool reboot; // 0x28
			public NetUsagePolicy netUsagePolicy; // 0x30
			public ResourceIndex resIndex; // 0x38
			[CompilerGenerated]
			private bool _illegalItemsInLocalRes_k__BackingField; // 0x40
	
			// Properties
			public bool illegalItemsInLocalRes { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
	
			// Constructors
			public WorkContext(); // 0x0000000183C075E0-0x0000000183C07650
	
			// Methods
			public void MarkIllegalItemsInLocalRes(); // 0x00000001869A0008-0x00000001869A0058
			public HotUpdateInfo GetHotUpdateInfo(bool isInitial); // 0x000000018699FFA4-0x00000001869A0008
			public bool HasChangedByType(EVFSBlockType type); // 0x0000000183DA4D20-0x0000000183DA4D90
		}
	
		[CompilerGenerated]
		private sealed class __Work_d__28 : IEnumerator<object> // TypeDefIndex: 56460
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			private WorkContext _workContext_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __Work_d__28(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C07330-0x0000000183C074C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699E5BC-0x000000018699E608
		}
	
		[CompilerGenerated]
		private sealed class __CreateMainCoroutine_d__29 : IEnumerator<object> // TypeDefIndex: 56461
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext workContext; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __CreateMainCoroutine_d__29(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018455F6A0-0x000000018455F7A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A6914-0x00000001869A6960
		}
	
		[CompilerGenerated]
		private sealed class __MainCoroutineModeSkip_d__30 : IEnumerator<object> // TypeDefIndex: 56462
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __MainCoroutineModeSkip_d__30(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184B21A80-0x0000000184B21B20
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA11C-0x00000001869AA168
		}
	
		[CompilerGenerated]
		private sealed class __MainCoroutineModeLocal_d__31 : IEnumerator<object> // TypeDefIndex: 56463
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __MainCoroutineModeLocal_d__31(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A9F90-0x00000001869AA0D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA0D0-0x00000001869AA11C
		}
	
		[CompilerGenerated]
		private sealed class __UpdateResVersion_d__32 : IEnumerator<object> // TypeDefIndex: 56464
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext workContext; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __UpdateResVersion_d__32(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184B45BC0-0x0000000184B45C40
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA388-0x00000001869AA3D4
		}
	
		[CompilerGenerated]
		private sealed class __UpdateResVersionDev_d__36 : IEnumerator<object> // TypeDefIndex: 56465
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private ResVersionDevCfg _config_5__2; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __UpdateResVersionDev_d__36(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869AA200-0x00000001869AA2F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA2F0-0x00000001869AA33C
		}
	
		[CompilerGenerated]
		private sealed class __UpdateResVersionProd_d__38 : IEnumerator<object> // TypeDefIndex: 56466
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
			private ResVersionCfg _config_5__2; // 0x28
			private Beyond.Misc.ObjectRef _resultRef_5__3; // 0x30
			private string _url_5__4; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __UpdateResVersionProd_d__38(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C07B40-0x0000000183C07E30
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA33C-0x00000001869AA388
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 56467
		{
			// Fields
			public bool isInitial; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LocalResPref __MainCoroutineModeDownload_b__0(); // 0x00000001869A2ACC-0x00000001869A2B40
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56468
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__43_1; // 0x08
	
			// Constructors
			static __c(); // 0x00000001869A2C00-0x00000001869A2C64
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __MainCoroutineModeDownload_b__43_1(); // 0x00000001869A2640-0x00000001869A2698
		}
	
		[CompilerGenerated]
		private sealed class __MainCoroutineModeDownload_d__43 : IEnumerator<object> // TypeDefIndex: 56469
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext workContext; // 0x28
			private __c__DisplayClass43_0 __8__1; // 0x30
			private bool _initialDownloaded_5__2; // 0x38
			private bool _hasHotUpdateSucceeded_5__3; // 0x39
			private bool _needDeleteInitial_5__4; // 0x3A
			private bool _neewDeleteMain_5__5; // 0x3B
			private int _initialOrMain_5__6; // 0x3C
			private string _onlineResVersion_5__7; // 0x40
			private WaitForAsyncTask<LocalResPref> _waitForResPref_5__8; // 0x48
			private HotUpdateInfo _info_5__9; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __MainCoroutineModeDownload_d__43(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A89CC-0x00000001869A9F44
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A9F44-0x00000001869A9F90
		}
	
		[CompilerGenerated]
		private sealed class __ReloadResourceIndexes_d__46 : IEnumerator<object> // TypeDefIndex: 56470
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ReloadResourceIndexes_d__46(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183DA6720-0x0000000183DA6AC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA168-0x00000001869AA1B4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0 // TypeDefIndex: 56471
		{
			// Fields
			public string filePath; // 0x10
			public ResourceIndex resIndex; // 0x18
			public Func<ResourceIndex> __9__1; // 0x20
	
			// Constructors
			public __c__DisplayClass47_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ResourceIndex __LoadOrDownloadResIndex_b__1(); // 0x00000001869A2B7C-0x00000001869A2BDC
			internal object __LoadOrDownloadResIndex_b__0(); // 0x00000001869A2B40-0x00000001869A2B7C
		}
	
		[CompilerGenerated]
		private sealed class __LoadOrDownloadResIndex_d__47 : IEnumerator<object> // TypeDefIndex: 56472
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool isInitial; // 0x20
			private __c__DisplayClass47_0 __8__1; // 0x28
			public string onlineVer; // 0x30
			public Beyond.Misc.ObjectRef resIndexRef; // 0x38
			public LoginHotUpdater __4__this; // 0x40
			private string _indexUrl_5__2; // 0x48
			private Beyond.Misc.ObjectRef _resultRef_5__3; // 0x50
			private WaitForAsyncTask<ResourceIndex> _loadTask_5__4; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __LoadOrDownloadResIndex_d__47(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A7E48-0x00000001869A848C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A848C-0x00000001869A84D8
		}
	
		[CompilerGenerated]
		private sealed class __GenResIndex_d__48 : IEnumerator<object> // TypeDefIndex: 56473
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public string onlineVer; // 0x28
			public bool isInitial; // 0x30
			public WorkContext workContext; // 0x38
			private Beyond.Misc.ObjectRef _resIndexRef_5__2; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GenResIndex_d__48(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A715C-0x00000001869A7298
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A7298-0x00000001869A72E4
		}
	
		[CompilerGenerated]
		private sealed class __GenRiff_d__49 : IEnumerator<object> // TypeDefIndex: 56474
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
			public bool isInitial; // 0x28
			public LoginHotUpdater __4__this; // 0x30
			public string onlineVer; // 0x38
			private HotUpdateInfo _info_5__2; // 0x40
			private LocalResPref _localResPref_5__3; // 0x48
			private string _rootUrl_5__4; // 0x50
			private string _patchUrl_5__5; // 0x58
			private string _fileUrl_5__6; // 0x60
			private ResourceIndex _resIndex_5__7; // 0x68
			private Beyond.Misc.ObjectRef _streamingIndexRef_5__8; // 0x70
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GenRiff_d__49(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A72E4-0x00000001869A7698
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A7698-0x00000001869A76E4
		}
	
		[CompilerGenerated]
		private sealed class __GenLocalRef_d__51 : IEnumerator<object> // TypeDefIndex: 56475
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
			public bool isInitial; // 0x28
			public string onlineVer; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GenLocalRef_d__51(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A6FB0-0x00000001869A7110
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A7110-0x00000001869A715C
		}
	
		[CompilerGenerated]
		private sealed class __CheckAndDownloadResource_d__52 : IEnumerator<object> // TypeDefIndex: 56476
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
			public bool isInitial; // 0x28
			public LoginHotUpdater __4__this; // 0x30
			public string onlineVer; // 0x38
			private HotUpdateInfo _info_5__2; // 0x40
			private LoginHotUpdateModel _hotUpdateModel_5__3; // 0x48
			private string _patchInfo_5__4; // 0x50
			private LoginDownloadTask _downloadTask_5__5; // 0x58
			private HGDownloader.WorkState _lastWorkState_5__6; // 0x60
			private bool _progress5_5__7; // 0x64
			private bool _progress25_5__8; // 0x65
			private bool _progress50_5__9; // 0x66
			private bool _progress75_5__10; // 0x67
			private bool _progress90_5__11; // 0x68
			private bool _downloadingShaderWarmupStarted_5__12; // 0x69
			private Beyond.Misc.ObjectRef _patchInfoRef_5__13; // 0x70
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __CheckAndDownloadResource_d__52(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A3C84-0x00000001869A50E4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A50E4-0x00000001869A5130
		}
	
		[CompilerGenerated]
		private sealed class __DownloadPatchInfo_d__54 : IEnumerator<object> // TypeDefIndex: 56477
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public string onlineVer; // 0x28
			public bool isInitial; // 0x30
			public Beyond.Misc.ObjectRef patchInfoRef; // 0x38
			private string _patchInfoUrl_5__2; // 0x40
			private WaitForAsyncTask<HttpSender.Result<PatchInfo>> _httpResIndex_5__3; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DownloadPatchInfo_d__54(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A6960-0x00000001869A6C38
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A6C38-0x00000001869A6C84
		}
	
		[CompilerGenerated]
		private sealed class __ClearDownloadFolder_d__55 : IEnumerator<object> // TypeDefIndex: 56478
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public bool needDeleteInitial; // 0x28
			public bool needDeleteMain; // 0x29
			public WorkContext workContext; // 0x30
			private List<HGFolder> _folderList_5__2; // 0x38
			private int _initialOrMain_5__3; // 0x40
			private bool _isInitial_5__4; // 0x44
			private string _onlineVer_5__5; // 0x48
			private HotUpdateInfo _info_5__6; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ClearDownloadFolder_d__55(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A5C38-0x00000001869A68C8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A68C8-0x00000001869A6914
		}
	
		[CompilerGenerated]
		private sealed class __CheckLocalResConsistency_d__56 : IEnumerator<object> // TypeDefIndex: 56479
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext context; // 0x20
			public bool isInitial; // 0x28
			public LoginHotUpdater __4__this; // 0x30
			public string onlineVer; // 0x38
			private LocalResPref _localResInfo_5__2; // 0x40
			private Beyond.Misc.ObjectRef _resIndexRef_5__3; // 0x48
			private bool _showProgress_5__4; // 0x50
			private WaitForAsyncTask<object> _checkTask_5__5; // 0x58
			private LocalResChecker.CheckOutput _checkOutput_5__6; // 0x60
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __CheckLocalResConsistency_d__56(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A5130-0x00000001869A5BEC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A5BEC-0x00000001869A5C38
		}
	
		[CompilerGenerated]
		private sealed class __VitalError_d__57 : IEnumerator<object> // TypeDefIndex: 56480
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public string error; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __VitalError_d__57(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869AA3D4-0x00000001869AA528
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA528-0x00000001869AA574
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 56481
		{
			// Fields
			public RuntimeFileUtils.StreamingResult indexRet; // 0x10
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ResourceIndex __LoadStreamingIndex_b__0(); // 0x00000001869A2BDC-0x00000001869A2C00
		}
	
		[CompilerGenerated]
		private sealed class __LoadStreamingIndex_d__58 : IEnumerator<object> // TypeDefIndex: 56482
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool isInitial; // 0x20
			private __c__DisplayClass58_0 __8__1; // 0x28
			public Beyond.Misc.ObjectRef resultRef; // 0x30
			public WorkContext workContext; // 0x38
			private string _indexPath_5__2; // 0x40
			private WaitForAsyncTask<ResourceIndex> _waitForIndex_5__3; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __LoadStreamingIndex_d__58(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A84D8-0x00000001869A8934
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A8934-0x00000001869A8980
		}
	
		// Constructors
		private LoginHotUpdater(LoginContext context, bool resRepairMode); // 0x0000000183A80D30-0x0000000183A80DD0
	
		// Methods
		protected static void MarkInitialAssetChanged(); // 0x000000018699997C-0x00000001869999E8
		protected static bool CheckInitialAssetChanged(); // 0x000000018699981C-0x0000000186999888
		protected static void MarkNeedClearFolder(bool isInitial); // 0x00000001869999E8-0x0000000186999A70
		protected static bool NeedClearFolder(bool isInitial); // 0x0000000186999ADC-0x0000000186999B60
		protected static void MarkClearSuccessed(bool isInitial); // 0x00000001869998F4-0x000000018699997C
		public static void MarkSoftRestart(); // 0x0000000186999A70-0x0000000186999ADC
		public static void ClearSoftRestartFlag(); // 0x0000000186999888-0x00000001869998F4
		public static bool IsNeedSoftRestart(); // 0x0000000183406070-0x00000001834060C0
		public void Dispose(); // 0x00000001846DD1E0-0x00000001846DD340
		public static LoginHotUpdater StartHotUpdate(LoginContext context, bool resRepairMode); // 0x0000000183A81090-0x0000000183A81140
		[IteratorStateMachine(typeof(__Work_d__28))]
		private IEnumerator _Work(); // 0x0000000183A81140-0x0000000183A811B0
		[IteratorStateMachine(typeof(__CreateMainCoroutine_d__29))]
		private IEnumerator _CreateMainCoroutine(WorkContext workContext); // 0x0000000183C07550-0x0000000183C075E0
		[IteratorStateMachine(typeof(__MainCoroutineModeSkip_d__30))]
		private IEnumerator _MainCoroutineModeSkip(WorkContext context); // 0x000000018455F7A0-0x000000018455F830
		[IteratorStateMachine(typeof(__MainCoroutineModeLocal_d__31))]
		private IEnumerator _MainCoroutineModeLocal(WorkContext context); // 0x000000018699AEC0-0x000000018699AF68
		[IteratorStateMachine(typeof(__UpdateResVersion_d__32))]
		private IEnumerator _UpdateResVersion(WorkContext workContext); // 0x0000000183C074C0-0x0000000183C07550
		private static void _SetResVersionForLog(); // 0x0000000183C079C0-0x0000000183C07A90
		private string _GetOnlineResVersion(bool isInitial); // 0x000000018699ABA8-0x000000018699AC7C
		public string ResourceRootUrl(string version, bool isInitial); // 0x0000000186999B60-0x0000000186999C1C
		[IteratorStateMachine(typeof(__UpdateResVersionDev_d__36))]
		private IEnumerator _UpdateResVersionDev(WorkContext workContext); // 0x000000018699B5B4-0x000000018699B63C
		[IteratorStateMachine(typeof(__UpdateResVersionProd_d__38))]
		private IEnumerator _UpdateResVersionProd(WorkContext workContext); // 0x0000000184B45C40-0x0000000184B45CC0
		private string _ResourcePatchUrl(string version, bool isInitial); // 0x000000018699B1AC-0x000000018699B264
		private string _ResourceFileUrl(string version, bool isInitial); // 0x000000018699AF68-0x000000018699B020
		private string _ResourcePatchRootUrl(string version, bool isInitial); // 0x000000018699B0E8-0x000000018699B1AC
		private string _ResourceIndexUrl(string version, bool isInitial); // 0x000000018699B020-0x000000018699B0E8
		[IteratorStateMachine(typeof(__MainCoroutineModeDownload_d__43))]
		private IEnumerator _MainCoroutineModeDownload(WorkContext workContext); // 0x000000018699AE18-0x000000018699AEC0
		private void _StartDownloadingShaderWarmupIfNeeded(); // 0x000000018699B264-0x000000018699B524
		private void _StopDownloadingShaderWarmupIfNeeded(); // 0x000000018699B524-0x000000018699B5B4
		[IteratorStateMachine(typeof(__ReloadResourceIndexes_d__46))]
		private IEnumerator _ReloadResourceIndexes(WorkContext workContext); // 0x0000000184B21B20-0x0000000184B21BA0
		[IteratorStateMachine(typeof(__LoadOrDownloadResIndex_d__47))]
		private IEnumerator _LoadOrDownloadResIndex(string onlineVer, bool isInitial, Beyond.Misc.ObjectRef resIndexRef); // 0x000000018699AC7C-0x000000018699AD58
		[IteratorStateMachine(typeof(__GenResIndex_d__48))]
		private IEnumerator _GenResIndex(string onlineVer, bool isInitial, WorkContext workContext); // 0x000000018699A9F0-0x000000018699AACC
		[IteratorStateMachine(typeof(__GenRiff_d__49))]
		private IEnumerator _GenRiff(string onlineVer, bool isInitial, WorkContext workContext); // 0x000000018699AACC-0x000000018699ABA8
		private static LocalResPref _CreateUpdatedLocalResPref(string onlineVer, bool isInitial, LocalResPref oldLocalResPref, FResourceDiff resDiff, out int removedFileCount); // 0x000000018699A004-0x000000018699A72C
		[IteratorStateMachine(typeof(__GenLocalRef_d__51))]
		private IEnumerator _GenLocalRef(string onlineVer, bool isInitial, WorkContext workContext); // 0x000000018699A920-0x000000018699A9F0
		[IteratorStateMachine(typeof(__CheckAndDownloadResource_d__52))]
		private IEnumerator _CheckAndDownloadResource(string onlineVer, bool isInitial, WorkContext workContext); // 0x0000000186999D78-0x0000000186999E54
		private void _EventLogDownloadProgress(ref bool first, double current, double total, int target, bool isInitial); // 0x000000018699A808-0x000000018699A920
		[IteratorStateMachine(typeof(__DownloadPatchInfo_d__54))]
		private IEnumerator _DownloadPatchInfo(string onlineVer, bool isInitial, Beyond.Misc.ObjectRef patchInfoRef); // 0x000000018699A72C-0x000000018699A808
		[IteratorStateMachine(typeof(__ClearDownloadFolder_d__55))]
		private IEnumerator _ClearDownloadFolder(WorkContext workContext, bool needDeleteInitial, bool needDeleteMain); // 0x0000000186999F30-0x000000018699A004
		[IteratorStateMachine(typeof(__CheckLocalResConsistency_d__56))]
		private IEnumerator _CheckLocalResConsistency(string onlineVer, bool isInitial, WorkContext context); // 0x0000000186999E54-0x0000000186999F30
		[IteratorStateMachine(typeof(__VitalError_d__57))]
		private IEnumerator _VitalError(string error); // 0x000000018699B63C-0x000000018699B6E4
		[IteratorStateMachine(typeof(__LoadStreamingIndex_d__58))]
		private static IEnumerator _LoadStreamingIndex(bool isInitial, WorkContext workContext, Beyond.Misc.ObjectRef resultRef); // 0x000000018699AD58-0x000000018699AE18
		public static void WriteLocalResPrefToFile(LocalResPref localResPref, WorkContext workContext); // 0x0000000186999C1C-0x0000000186999D78
		private static int _CurrentWorkMode(LoginContext context); // 0x000000018455F830-0x000000018455F8F0
	}

	public class LoginProgress : LoginHotUpdateModel.IProgress // TypeDefIndex: 56486
	{
		// Fields
		public const int MODE_PROG = 0; // Metadata: 0x023485B3
		public const int MODE_SIZE = 1; // Metadata: 0x023485B4
		public const int MODE_IDEL = 2; // Metadata: 0x023485B5
		public int mode; // 0x10
		public double current; // 0x18
		public double total; // 0x20
		public double speed; // 0x28
		private FDownloadSize m_downloadSize; // 0x30
	
		// Nested types
		private struct FDownloadSize // TypeDefIndex: 56485
		{
			// Fields
			private const double MB = 1048576; // Metadata: 0x023485B6
			private const double KB = 1024; // Metadata: 0x023485BE
			private EUnit m_unit; // 0x00
			private float m_displayCurrent; // 0x04
			private float m_displayTotal; // 0x08
			private float m_displaySpeed; // 0x0C
			public string displayInfo; // 0x10
			private float m_current; // 0x18
			private float m_total; // 0x1C
	
			// Nested types
			private enum EUnit // TypeDefIndex: 56484
			{
				NONE = 0,
				B = 1,
				KB = 2,
				MB = 3
			}
	
			// Methods
			public void SetProgress(double current, double total); // 0x00000001869A08D4-0x00000001869A0A60
			public void SetIdle(); // 0x00000001869A0790-0x00000001869A08D4
			public void SetSize(double current, double total, double speed); // 0x00000001869A0A60-0x00000001869A0CF0
			private static EUnit _PickUnit(double number); // 0x00000001869A1094-0x00000001869A1118
			private static float _DisplayWithUnit(double number, EUnit unit); // 0x00000001869A0CF0-0x00000001869A0DC0
			private static string _FormatDisplayInfo(float current, float total, EUnit unit); // 0x00000001869A0DC0-0x00000001869A0EF4
			private static string _FormatSpeedInfo(float speed, EUnit unit); // 0x00000001869A0FA4-0x00000001869A1094
			private static string _FormatProgressInfo(float current, float total); // 0x00000001869A0EF4-0x00000001869A0FA4
		}
	
		// Constructors
		public LoginProgress(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public double GetCurrent(); // 0x00000001869A1480-0x00000001869A14D0
		public double GetTotal(); // 0x00000001869A157C-0x00000001869A15CC
		public string GetInfo(); // 0x00000001869A14D0-0x00000001869A157C
	}

	public class LoginInitNode : LoginWorkFlow.Node // TypeDefIndex: 56490
	{
		// Fields
		private bool m_isSDKInited; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B1790-0x00000001849B17C0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __InitCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 56487
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginInitNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __InitCoroutine_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018484D630-0x000000018484D6F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A7D64-0x00000001869A7DB0
		}
	
		[CompilerGenerated]
		private sealed class __InitRemoteConfigs_d__5 : IEnumerator<object> // TypeDefIndex: 56488
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginInitNode __4__this; // 0x20
			private NetConfigInterface.InitYiedInstruction _initNetConfig_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __InitRemoteConfigs_d__5(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183DA38E0-0x0000000183DA3B90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A7DB0-0x00000001869A7DFC
		}
	
		[CompilerGenerated]
		private sealed class __YieldAlertError_d__6 : IEnumerator<object> // TypeDefIndex: 56489
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string errorInfo; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __YieldAlertError_d__6(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869AA60C-0x00000001869AA69C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA69C-0x00000001869AA6E8
		}
	
		// Constructors
		public LoginInitNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x00000001845E8940-0x00000001845E8A20
		[IteratorStateMachine(typeof(__InitCoroutine_d__4))]
		private IEnumerator _InitCoroutine(); // 0x00000001845E8A20-0x00000001845E8A90
		[IteratorStateMachine(typeof(__InitRemoteConfigs_d__5))]
		private IEnumerator _InitRemoteConfigs(); // 0x000000018484D6F0-0x000000018484D760
		[IteratorStateMachine(typeof(__YieldAlertError_d__6))]
		private IEnumerator _YieldAlertError(string errorInfo); // 0x00000001869A1310-0x00000001869A13AC
	}

	public class LoginLocalResTask : IDisposable // TypeDefIndex: 56493
	{
		// Fields
		private LoginContext m_loginCxt; // 0x10
		private LoginHotUpdater.WorkContext m_workCxt; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 56491
		{
			// Fields
			public string indexPath; // 0x10
			public string prefPath; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ResourceIndex _Work_b__0(); // 0x00000001869A2A4C-0x00000001869A2A9C
			internal LocalResPref _Work_b__1(); // 0x00000001869A2A9C-0x00000001869A2ACC
		}
	
		[CompilerGenerated]
		private sealed class _Work_d__3 : IEnumerator<object> // TypeDefIndex: 56492
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginLocalResTask __4__this; // 0x20
			private __c__DisplayClass3_0 __8__1; // 0x28
			private LoginHotUpdater.WorkContext _workContext_5__2; // 0x30
			private LoginHotUpdateProp _viewProp_5__3; // 0x38
			private LoginHotUpdateModel _viewModel_5__4; // 0x40
			private ResourceIndex[] _resIndexList_5__5; // 0x48
			private int _initialOrMain_5__6; // 0x50
			private bool _isInitial_5__7; // 0x54
			private WaitForAsyncTask<ResourceIndex> _waitForResIndex_5__8; // 0x58
			private RootCategory _rootCategory_5__9; // 0x60
			private LoginHotUpdateModel.SimpleProgress _progress_5__10; // 0x68
			private WaitForAsyncTask<object> _checkTask_5__11; // 0x70
			private LocalResChecker.CheckOutput _checkOutput_5__12; // 0x78
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Work_d__3(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A2CB0-0x00000001869A3BEC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A3BEC-0x00000001869A3C38
		}
	
		// Constructors
		public LoginLocalResTask(LoginContext loginContext, LoginHotUpdater.WorkContext workContext); // 0x00000001832AF420-0x00000001832AF450
	
		// Methods
		[IteratorStateMachine(typeof(_Work_d__3))]
		public IEnumerator Work(); // 0x00000001869A13F0-0x00000001869A1480
		public void Dispose(); // 0x00000001869A13AC-0x00000001869A13F0
	}

	public class PreloadNode : LoginWorkFlow.Node // TypeDefIndex: 56501
	{
		// Fields
		private LoginHotUpdateModel.SimpleProgress m_progress; // 0x20
		private bool m_getServerListSuc; // 0x28
		private string m_errorMsg; // 0x30
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B16A0-0x00000001849B16D0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56494
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<bool> __9__5_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D4D2F0-0x0000000184D4D350
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Work_b__5_0(); // 0x00000001836A61A0-0x00000001836A6260
		}
	
		[CompilerGenerated]
		private sealed class __LoginPreLoad_d__7 : IEnumerator<object> // TypeDefIndex: 56495
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __LoginPreLoad_d__7(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018455F3A0-0x000000018455F4F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A8980-0x00000001869A89CC
		}
	
		[CompilerGenerated]
		private sealed class __WarmUp_d__9 : IEnumerator<object> // TypeDefIndex: 56496
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __WarmUp_d__9(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C8F5F0-0x0000000183C8F770
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA5C0-0x00000001869AA60C
		}
	
		[CompilerGenerated]
		private sealed class __GetServerList_d__10 : IEnumerator<object> // TypeDefIndex: 56497
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GetServerList_d__10(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001840EACC0-0x00000001840EADB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A7D18-0x00000001869A7D64
		}
	
		[CompilerGenerated]
		private sealed class __GetServerListInfoMock_d__12 : IEnumerator<object> // TypeDefIndex: 56498
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GetServerListInfoMock_d__12(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001840E9740-0x00000001840E9810
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A76E4-0x00000001869A7730
		}
	
		[CompilerGenerated]
		private sealed class __GetServerListInfo_d__13 : IEnumerator<object> // TypeDefIndex: 56499
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
			private SDKPromiseEnumerator<List<U8ServerInfo>> _getServerListPromise_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __GetServerListInfo_d__13(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A7730-0x00000001869A7CCC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A7CCC-0x00000001869A7D18
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 56500
		{
			// Fields
			public List<ServerZoneManager.ServerZoneData> serverZoneDataList; // 0x10
			public List<SpeedTestServerInfo> serverList; // 0x18
			public Action<SpeedTestResult> callback; // 0x20
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnGetServerListSuc_b__0(SpeedTestResult result); // 0x00000001869A2698-0x00000001869A29E4
			internal Task<Hypergryph.SpeedTest.TaskResult> __OnGetServerListSuc_b__1(); // 0x00000001869A29E4-0x00000001869A2A4C
		}
	
		// Constructors
		public PreloadNode(); // 0x00000001847318D0-0x0000000184731950
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000183A811B0-0x0000000183A81370
		private void _ShowPreloadResourcePanel(); // 0x0000000183A80B70-0x0000000183A80C70
		[IteratorStateMachine(typeof(__LoginPreLoad_d__7))]
		private IEnumerator _LoginPreLoad(); // 0x0000000183A81370-0x0000000183A813E0
		private void _QuitGame(GameAppExitCode exitCode); // 0x00000001869A2564-0x00000001869A25EC
		[IteratorStateMachine(typeof(__WarmUp_d__9))]
		private IEnumerator _WarmUp(); // 0x000000018455F560-0x000000018455F5D0
		[IteratorStateMachine(typeof(__GetServerList_d__10))]
		private IEnumerator _GetServerList(); // 0x000000018455F4F0-0x000000018455F560
		private void _EnterPreLoad(); // 0x0000000183C11630-0x0000000183C116B0
		[IteratorStateMachine(typeof(__GetServerListInfoMock_d__12))]
		private IEnumerator _GetServerListInfoMock(); // 0x00000001840EADB0-0x00000001840EAE20
		[IteratorStateMachine(typeof(__GetServerListInfo_d__13))]
		private IEnumerator _GetServerListInfo(); // 0x00000001869A2418-0x00000001869A24A8
		private void _OnGetServerListSuc(); // 0x00000001840EA1F0-0x00000001840EACC0
		private void _OnGetServerListFail(string errorInfo); // 0x00000001869A24A8-0x00000001869A2564
	}

	public class LoginSDKInitNode : LoginWorkFlow.Node // TypeDefIndex: 56505
	{
		// Fields
		private bool m_isSDKInited; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B1760-0x00000001849B1790 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __SDKInitCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 56502
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginSDKInitNode __4__this; // 0x20
			private string _env_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __SDKInitCoroutine_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183C8FD10-0x0000000183C90130
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA1B4-0x00000001869AA200
		}
	
		[CompilerGenerated]
		private sealed class __WaitForSDKInited_d__5 : IEnumerator<object> // TypeDefIndex: 56503
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __WaitForSDKInited_d__5(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184A426B0-0x0000000184A42760
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869AA574-0x00000001869AA5C0
		}
	
		[CompilerGenerated]
		private sealed class __InitSubSDKs_d__6 : IEnumerator<object> // TypeDefIndex: 56504
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string env; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __InitSubSDKs_d__6(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018332A190-0x000000018332A350
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A7DFC-0x00000001869A7E48
		}
	
		// Constructors
		public LoginSDKInitNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x00000001845E8A90-0x00000001845E8B70
		[IteratorStateMachine(typeof(__SDKInitCoroutine_d__4))]
		private IEnumerator _SDKInitCoroutine(); // 0x00000001845E8B70-0x00000001845E8BE0
		[IteratorStateMachine(typeof(__WaitForSDKInited_d__5))]
		private IEnumerator _WaitForSDKInited(); // 0x0000000183C90130-0x0000000183C90190
		[IteratorStateMachine(typeof(__InitSubSDKs_d__6))]
		private IEnumerator _InitSubSDKs(string env); // 0x0000000183C90200-0x0000000183C90280
	}

	public class U8LoginNode : LoginWorkFlow.Node // TypeDefIndex: 56508
	{
		// Fields
		private bool m_loginSuc; // 0x20
		private bool m_isSDKLoginFinished; // 0x21
		private bool m_isWaitingGameProtocolUpdateCheck; // 0x22
		private int m_rqstSkipLoginCache; // 0x24
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B1610-0x00000001849B1640 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __LoginCoroutine_d__7 : IEnumerator<object> // TypeDefIndex: 56506
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8LoginNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __LoginCoroutine_d__7(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001815043A0-0x0000000181505930
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000181505930-0x0000000181505980
		}
	
		[CompilerGenerated]
		private sealed class __FinishLogin_d__8 : IEnumerator<object> // TypeDefIndex: 56507
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private string _env_5__2; // 0x20
			private SDKPromiseEnumerator<U8AuthV2Result> _authPromise_5__3; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __FinishLogin_d__8(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000181502380-0x0000000181504350
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000181504350-0x00000001815043A0
		}
	
		// Constructors
		public U8LoginNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x00000001845E8BE0-0x00000001845E8CC0
		[IteratorStateMachine(typeof(__LoginCoroutine_d__7))]
		private IEnumerator _LoginCoroutine(); // 0x00000001845E8CC0-0x00000001845E8D30
		[IteratorStateMachine(typeof(__FinishLogin_d__8))]
		private IEnumerator _FinishLogin(); // 0x0000000184D32A40-0x0000000184D32AA0
		public override bool OnEvent(ELoginEvent evt, object param); // 0x00000001869AA6E8-0x00000001869AA76C
		private void _StartSDKLogin(); // 0x00000001840EAE20-0x00000001840EB080
		private void _SetCursorOnLoginStart(); // 0x00000001840EB1E0-0x00000001840EB260
		private void _SetCursorOnLoginFinish(); // 0x00000001840EB260-0x00000001840EB2E0
		private void _SkipSDKLogin(); // 0x00000001869AA940-0x00000001869AAA0C
		private void _ClearLoginCaches(); // 0x0000000183A7F950-0x0000000183A80950
		private void _StartGameProtocolUpdateCheck(); // 0x0000000181509B20-0x000000018150B3A0
		private void _OnGameProtocolUpdateCheckSucceeded(); // 0x0000000181509160-0x0000000181509B20
		private void _OnGameProtocolUpdateCheckFailed(); // 0x0000000181508230-0x0000000181509160
		private void _ClearGameProtocolUpdateCheckEvents(); // 0x0000000181507380-0x0000000181508230
		private void _OnLoginSuc(); // 0x00000001841E5BC0-0x00000001841E5CA0
		private void _OnLoginFail(object rawInfo); // 0x00000001869AA818-0x00000001869AA940
		private void _OnSDKViewDisabled(); // 0x00000001841E7AC0-0x00000001841E7B00
		private void _OnLoginCanceled(); // 0x00000001869AA76C-0x00000001869AA818
		private void _EnableBlurMask(bool enable); // 0x00000001841E5E00-0x00000001841E5EA0
		[CompilerGenerated]
		private void __StartSDKLogin_b__10_0(string sessionToken); // 0x0000000181505980-0x0000000181506540
		[CompilerGenerated]
		private void __StartSDKLogin_b__10_1(object pram); // 0x0000000181506540-0x0000000181507380
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1); // 0x0000000186998558-0x0000000186998560
	}

	public class LoginProperty<T> : LoginWorkFlow.IWorkerUpdateOnce // TypeDefIndex: 56509
		where T : class, new()
	{
		// Fields
		private T m_value;
		private HashSet<ILoginBinder<T>> m_binders;
		private LoginWorkFlow m_workflow;
		[CompilerGenerated]
		private bool _isDataChanged_k__BackingField;
	
		// Properties
		public bool isDataChanged { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public T value { get; }
	
		// Constructors
		public LoginProperty(LoginWorkFlow workflow);
	
		// Methods
		public void NotifyDataChanged();
		public void Bind(ILoginBinder<T> binder);
		public void Worker_UpdateOnce();
	}

	public interface ILoginBinder<T> // TypeDefIndex: 56510
	{
		// Methods
		void OnValueChanged(T value);
	}

	public interface ILoginContextReceiver // TypeDefIndex: 56511
	{
		// Methods
		void OnLoginContext(LoginContext context);
	}

	public class LoginViewModel // TypeDefIndex: 56513
	{
		// Fields
		public LoginWorkFlow.ENode workCachedCurNode; // 0x10
		public LoginWorkFlow.ENode workCurNode; // 0x14
		public bool isFirstLogin; // 0x18
		[CompilerGenerated]
		private int _rqstSkipU8Login_k__BackingField; // 0x1C
		public bool isU8LoginCancelled; // 0x20
		[CompilerGenerated]
		private int _rqstResRepairCode_k__BackingField; // 0x24
		public FAgeTipsPolicy ageTipsPolicy; // 0x28
	
		// Properties
		public int rqstSkipU8Login { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public int rqstResRepairCode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
	
		// Nested types
		public struct FAgeTipsPolicy // TypeDefIndex: 56512
		{
			// Fields
			public bool canOpenDetail; // 0x00
			public bool displayCN; // 0x01
			public bool displayKR; // 0x02
	
			// Properties
			public bool display { get; } // 0x0000000183408B80-0x0000000183408BB0 
		}
	
		// Constructors
		public LoginViewModel(); // 0x0000000184CD95A0-0x0000000184CD95D0
	
		// Methods
		public bool IsAgeTipsVisible(); // 0x0000000183408B00-0x0000000183408B80
		public bool IsGovTipsVisible(); // 0x00000001834089C0-0x00000001834089F0
		public bool IsMenuVisible(); // 0x0000000183407160-0x0000000183407230
		public void RequestResourceRepair(); // 0x00000001869A15CC-0x00000001869A1618
		public void RequestSkipU8Login(); // 0x00000001869A1618-0x00000001869A1664
		private static FAgeTipsPolicy _LoadAgeTipsPolicy(); // 0x0000000184CD95D0-0x0000000184CD9640
	}

	public class LoginViewProperty : LoginProperty<LoginViewModel> // TypeDefIndex: 56514
	{
		// Fields
		[CompilerGenerated]
		private LoginHotUpdateProp _hotUpdateProp_k__BackingField; // 0x30
		[CompilerGenerated]
		private LoginAgeTipsProp _ageTipsProp_k__BackingField; // 0x38
		[CompilerGenerated]
		private LoginServerSelectProp _serverSelectProp_k__BackingField; // 0x40
	
		// Properties
		public LoginHotUpdateProp hotUpdateProp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public LoginAgeTipsProp ageTipsProp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public LoginServerSelectProp serverSelectProp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
	
		// Constructors
		public LoginViewProperty(LoginWorkFlow workflow); // 0x0000000183A7F7F0-0x0000000183A7F900
	}

	public class LoginAgeTipsModel // TypeDefIndex: 56515
	{
		// Fields
		public string contentCache; // 0x10
		public bool isShow; // 0x18
		public bool isFetchingContent; // 0x19
	
		// Constructors
		public LoginAgeTipsModel(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool IsContentEmpty(); // 0x0000000183A809C0-0x0000000183A80A00
		public bool CanDisplay(); // 0x0000000184B480F0-0x0000000184B48120
	}

	public class LoginAgeTipsProp : LoginProperty<LoginAgeTipsModel> // TypeDefIndex: 56516
	{
		// Constructors
		public LoginAgeTipsProp(LoginWorkFlow workflow); // 0x0000000183A80950-0x0000000183A809C0
	
		// Methods
		public void ClearContentCache(); // 0x00000001869A119C-0x00000001869A1260
		public void UpdateContent(string content); // 0x00000001869A1260-0x00000001869A1310
	}

	public class LoginWorkFlow : IDisposable // TypeDefIndex: 56527
	{
		// Fields
		public const string CURSOR_KEY_LOGIN = "login"; // Metadata: 0x023485CC
		private static bool s_hasEnteredPreloadThisSession; // 0x00
		private static readonly ENode[] NODE_ORDER; // 0x08
		private const ENode NEED_GAME_LOGIN_STATE_BEFORE_NODE = ENode.Preload; // Metadata: 0x023485D2
		private readonly Node[] m_nodes; // 0x10
		private readonly LoginContext m_context; // 0x18
		private FWork m_work; // 0x20
		private Worker m_worker; // 0x30
		private HashSet<IEventReceiver> m_evtRecvrs; // 0x38
		private List<IEventReceiver> m_recvrBuffer; // 0x40
		[CompilerGenerated]
		private bool _isDisposed_k__BackingField; // 0x48
	
		// Properties
		public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
	
		// Nested types
		public abstract class Node // TypeDefIndex: 56517
		{
			// Fields
			[CompilerGenerated]
			private LoginContext _context_k__BackingField; // 0x10
			[CompilerGenerated]
			private LoginWorkFlow _workflow_k__BackingField; // 0x18
	
			// Properties
			protected LoginContext context { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
			protected LoginWorkFlow workflow { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public abstract ENode type { get; }
	
			// Constructors
			protected Node(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Init(LoginContext context, LoginWorkFlow workflow); // 0x0000000183405FE0-0x0000000183406040
			public void Dispose(); // 0x00000001834060C0-0x0000000183406100
			public abstract CustomYieldInstruction Work();
			public virtual bool CanCancel(); // 0x00000001869A2380-0x00000001869A23CC
			public virtual CustomYieldInstruction Cancel(); // 0x00000001869A23CC-0x00000001869A2418
			protected virtual void OnInit(); // 0x0000000183406040-0x0000000183406070
			public virtual void OnDispose(); // 0x00000001846DD140-0x00000001846DD170
			public virtual bool OnEvent(ELoginEvent evt, object param); // 0x000000018470B370-0x000000018470B450
		}
	
		public enum ENode // TypeDefIndex: 56518
		{
			None = 0,
			CheckForUpdate = 1,
			SDKInit = 2,
			GameUpdate = 3,
			Init = 4,
			U8Login = 5,
			HotUpdate = 6,
			ResCheck = 7,
			Preload = 8,
			PreloadPostDelay = 9,
			Trans2GsLogin = 10,
			GsLogin = 11,
			CreateRole = 12,
			Finish = 13
		}
	
		public interface IWorkerUpdateOnce // TypeDefIndex: 56519
		{
			// Methods
			void Worker_UpdateOnce();
		}
	
		public interface IEventReceiver // TypeDefIndex: 56520
		{
			// Methods
			void OnEvent(ELoginEvent evt, object param);
		}
	
		private class Worker : IDisposable // TypeDefIndex: 56522
		{
			// Fields
			private HashSet<IWorkerUpdateOnce> m_updateOnce; // 0x10
			private List<IWorkerUpdateOnce> m_buffer; // 0x18
			private CustomYieldInstruction m_curWork; // 0x20
			[CompilerGenerated]
			private bool _isCancelled_k__BackingField; // 0x28
			[CompilerGenerated]
			private bool _isDisposed_k__BackingField; // 0x29
			[CompilerGenerated]
			private Node _curNode_k__BackingField; // 0x30
	
			// Properties
			public bool isCancelled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
			public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D867B0-0x0000000184D867C0 0x0000000184D867C0-0x0000000184D867D0
			public Node curNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
			// Nested types
			[CompilerGenerated]
			private sealed class _Work_d__20 : IEnumerator<object> // TypeDefIndex: 56521
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public Worker __4__this; // 0x20
				public CustomYieldInstruction work; // 0x28
				private CustomYieldInstruction _cancelTask_5__2; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public _Work_d__20(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x0000000183D4ECE0-0x0000000183D4EE00
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x00000001869A2C64-0x00000001869A2CB0
			}
	
			// Constructors
			public Worker(); // 0x0000000184CC9AF0-0x0000000184CC9BB0
	
			// Methods
			public bool Cancel(); // 0x00000001869AAA0C-0x00000001869AAF5C
			public void Dispose(); // 0x0000000184D26A80-0x0000000184D26B00
			public void SetCurNode(Node node); // 0x0000000183405DE0-0x0000000183405E90
			public bool UpdateOnce(IWorkerUpdateOnce inst); // 0x000000018450CB50-0x000000018450CBD0
			public void TickInEmptyFrame(); // 0x0000000183D4ECA0-0x0000000183D4ECE0
			[IteratorStateMachine(typeof(_Work_d__20))]
			public IEnumerator Work(CustomYieldInstruction work); // 0x0000000183406100-0x0000000183406190
			private void _InternalTick(); // 0x0000000183D4EE00-0x0000000183D4F0D0
		}
	
		private struct FWork // TypeDefIndex: 56523
		{
			// Fields
			public static readonly FWork IDLE; // 0x00
			[CompilerGenerated]
			private bool _didFallback_k__BackingField; // 0x00
			[CompilerGenerated]
			private int _nodeIndex_k__BackingField; // 0x04
			[CompilerGenerated]
			private bool _isWorking_k__BackingField; // 0x08
	
			// Properties
			public bool didFallback { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D883E0-0x0000000184D883F0 0x0000000184D87180-0x0000000184D87190
			public int nodeIndex { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
			public bool isWorking { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8CCC0-0x0000000184D8CCD0 0x0000000184D8CCD0-0x0000000184D8CCE0
			public ENode curNode { get; } // 0x0000000183406B00-0x0000000183406BD0 
	
			// Constructors
			static FWork(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void MarkFallback(int newIndex); // 0x00000001869A1118-0x00000001869A119C
			public bool ConsumeFallback(); // 0x0000000183406C30-0x0000000183406C90
			public void MoveNextIndex(); // 0x0000000183406BD0-0x0000000183406C30
			public static FWork Start(); // 0x0000000184D18180-0x0000000184D18210
			public bool WorkEnd(); // 0x0000000183406C90-0x0000000183406D40
		}
	
		[CompilerGenerated]
		private sealed class _DoWorkFlow_d__25 : IEnumerator<object> // TypeDefIndex: 56524
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginWorkFlow __4__this; // 0x20
			private Worker _worker_5__2; // 0x28
			private LoginViewProperty _viewProp_5__3; // 0x30
			private ENode _cachedCurrent_5__4; // 0x38
			private bool _isEmptyFrame_5__5; // 0x3C
			private bool _isAbort_5__6; // 0x3D
			private Node[] __7__wrap6; // 0x40
			private int __7__wrap7; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DoWorkFlow_d__25(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001834064C0-0x0000000183406B00
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A25F4-0x00000001869A2640
		}
	
		[CompilerGenerated]
		private sealed class __FetchAgeTipsCoroutine_d__45 : IEnumerator<object> // TypeDefIndex: 56525
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginAgeTipsProp prop; // 0x20
			public LoginWorkFlow __4__this; // 0x28
			private LoginAgeTipsModel _model_5__2; // 0x30
			private LoginController.MaskCtrl _maskCtrl_5__3; // 0x38
			private Beyond.Misc.ObjectRef _httpRetRef_5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __FetchAgeTipsCoroutine_d__45(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869A6C84-0x00000001869A6F64
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A6F64-0x00000001869A6FB0
		}
	
		[CompilerGenerated]
		private sealed class __AdjustCurrentGameState_d__47 : IEnumerator<object> // TypeDefIndex: 56526
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ENode curNode; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __AdjustCurrentGameState_d__47(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001836A6080-0x00000001836A6140
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869A3C38-0x00000001869A3C84
		}
	
		// Constructors
		public LoginWorkFlow(LoginContext context); // 0x0000000183406190-0x0000000183406310
		static LoginWorkFlow(); // 0x0000000184CE9E50-0x0000000184CE9EF0
	
		// Methods
		public static void MarkEnteredPreloadThisSession(); // 0x0000000183A82A90-0x0000000183A82B00
		public static void ClearEnteredPreloadThisSession(); // 0x00000001869A1788-0x00000001869A1800
		public static bool HasEnteredPreloadThisSession(); // 0x00000001869A1A5C-0x00000001869A1AD4
		private Node[] _RegisterNodes(); // 0x0000000184731570-0x00000001847318D0
		[IteratorStateMachine(typeof(_DoWorkFlow_d__25))]
		public IEnumerator DoWorkFlow(); // 0x00000001841E4DE0-0x00000001841E4E50
		public void Dispose(); // 0x0000000183406310-0x00000001834064C0
		public bool PeekFallbackStatus(out ENode fallbackNode); // 0x00000001846DD390-0x00000001846DD440
		public bool Fallback(ENode target, bool validCheck = true /* Metadata: 0x023485CA */); // 0x00000001869A1800-0x00000001869A1A5C
		public bool CancelAndFallback(ENode target, bool validCheck = true /* Metadata: 0x023485CB */); // 0x00000001869A16F4-0x00000001869A1788
		public void SendEvent(ELoginEvent evt, object param = null); // 0x000000018470AF20-0x000000018470B260
		public void AddEventReceiver(IEventReceiver receiver); // 0x00000001869A1664-0x00000001869A16F4
		public bool UpdateOnce(IWorkerUpdateOnce inst); // 0x000000018450CAF0-0x000000018450CB50
		public static bool IsBeforeWork(ENode curNode, ENode check); // 0x00000001834077A0-0x0000000183407810
		public static bool IsOnOrAfterWork(ENode curNode, ENode check); // 0x00000001834088B0-0x0000000183408960
		public static bool IsAfterWork(ENode target, ENode check); // 0x00000001869A1AD4-0x00000001869A1B98
		private bool _HandleGlobalEvent(ELoginEvent evt, object param); // 0x000000018470B260-0x000000018470B2D0
		private void _EventOnOpenAgeTips(); // 0x00000001869A1E60-0x00000001869A1FE0
		private void _EventOnCloseAgeTips(); // 0x00000001869A1B98-0x00000001869A1CC4
		private void _EventOnOpenServerSelect(bool isOpen); // 0x00000001869A1FE0-0x00000001869A20B0
		private void _EventOnSelectServer(ServerZoneManager.ServerZoneData serverZoneData); // 0x00000001869A20B0-0x00000001869A2190
		private void _EventOnConfirmServer(); // 0x00000001869A1CC4-0x00000001869A1E60
		private void _EnableCursor(bool enabled); // 0x0000000184B2C680-0x0000000184B2C740
		private void _UpdateCursor([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input); // 0x00000001869A2238-0x00000001869A2380
		private void _EnbaleToggleGroup(); // 0x00000001849D6BB0-0x00000001849D6C20
		[IteratorStateMachine(typeof(__FetchAgeTipsCoroutine_d__45))]
		private IEnumerator _FetchAgeTipsCoroutine(LoginAgeTipsProp prop); // 0x00000001869A2190-0x00000001869A2238
		private static bool _CheckIfGameStateNotMatch(ENode curNode); // 0x0000000183406D40-0x0000000183406E00
		[IteratorStateMachine(typeof(__AdjustCurrentGameState_d__47))]
		private static IEnumerator _AdjustCurrentGameState(ENode curNode); // 0x00000001849B82F0-0x00000001849B8360
	}

	public class HotUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 56528
	{
		// Fields
		private LoginHotUpdater m_updater; // 0x20
		private int m_cachedResRepairCode; // 0x28
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B18E0-0x00000001849B1910 
	
		// Constructors
		public HotUpdateNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000183A80FC0-0x0000000183A81090
		public override void OnDispose(); // 0x00000001846DD0A0-0x00000001846DD100
		public void __iFixBaseProxy_OnDispose(); // 0x0000000186997004-0x000000018699700C
	}

	public abstract class WaitForSecondsNode : LoginWorkFlow.Node // TypeDefIndex: 56529
	{
		// Fields
		private int? m_timerId; // 0x20
	
		// Constructors
		protected WaitForSecondsNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000183A81490-0x0000000183A82A50
		private bool _IsTimeout(); // 0x00000001836A6140-0x00000001836A6190
		private void _NotifyTimeout(); // 0x0000000184D39810-0x0000000184D39840
		private void _DisposeTimer(); // 0x00000001846DD170-0x00000001846DD1E0
		protected abstract float WaitForSeconds(out bool unscaled);
		public override void OnDispose(); // 0x00000001846DD100-0x00000001846DD140
		public void __iFixBaseProxy_OnDispose(); // 0x0000000186997004-0x000000018699700C
	}

	public class PreloadPostDelayNode : WaitForSecondsNode // TypeDefIndex: 56530
	{
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B1670-0x00000001849B16A0 
	
		// Constructors
		public PreloadPostDelayNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override float WaitForSeconds(out bool unscaled); // 0x0000000184D79D50-0x0000000184D79D90
		public override CustomYieldInstruction Work(); // 0x0000000183A813E0-0x0000000183A81420
		private void _DisableLoadingPanel(); // 0x0000000183A80C70-0x0000000183A80D30
		public CustomYieldInstruction __iFixBaseProxy_Work(); // 0x00000001869A25EC-0x00000001869A25F4
	}

	public class Trans2GsLoginNode : WaitForSecondsNode // TypeDefIndex: 56531
	{
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B1640-0x00000001849B1670 
	
		// Constructors
		public Trans2GsLoginNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override float WaitForSeconds(out bool unscaled); // 0x00000001841E5CA0-0x00000001841E5D70
		public override CustomYieldInstruction Work(); // 0x0000000183A81420-0x0000000183A81490
		public CustomYieldInstruction __iFixBaseProxy_Work(); // 0x00000001869A25EC-0x00000001869A25F4
	}

	public class FinishNode : LoginWorkFlow.Node // TypeDefIndex: 56532
	{
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x00000001849B1940-0x00000001849B1970 
	
		// Constructors
		public FinishNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000184A31020-0x0000000184A310A0
	}

	public struct CarrierDownloadCache // TypeDefIndex: 56533
	{
		// Fields
		public static readonly CarrierDownloadCache EMPTY; // 0x00
		public long size; // 0x00
		public bool isAllowed; // 0x08
	
		// Constructors
		static CarrierDownloadCache(); // 0x0000000184D56A10-0x0000000184D56A70
	}

	public class NetUsagePolicy // TypeDefIndex: 56536
	{
		// Fields
		private const int NOT_REACHABLE_ERROR_CODE = 30000; // Metadata: 0x023485E1
		private CarrierDownloadCache m_mobileDataCache; // 0x10
		private NetworkReachability m_lastNetworkState; // 0x20
		private Options m_options; // 0x28
	
		// Nested types
		public struct Options // TypeDefIndex: 56534
		{
			// Fields
			public long minBytesToNotifyCarrier; // 0x00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 56535
		{
			// Fields
			public long downloadSize; // 0x10
			public NetUsagePolicy __4__this; // 0x18
			public Action onAllowed; // 0x20
			public Action onRejected; // 0x28
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CheckIfAllowDownload_b__0(); // 0x00000001869B4C50-0x00000001869B4CD0
			internal void _CheckIfAllowDownload_b__1(); // 0x00000001869B4CD0-0x00000001869B4D40
		}
	
		// Constructors
		public NetUsagePolicy(Options options); // 0x000000018380AB00-0x000000018380AB70
	
		// Methods
		public void CheckIfAllowDownload(long downloadSize, Action onAllowed, Action onRejected, Action onReachable = null); // 0x00000001869B43E4-0x00000001869B4734
		public bool AllowMobileDataInLastCheck(); // 0x00000001869B438C-0x00000001869B43E4
		private static string _GetPrettySizeStringUpToMB(double number); // 0x00000001869B4734-0x00000001869B47E4
	}

	public class LoginSceneAnimCtrl : LoginSceneComponent, ILoginBinder<LoginViewModel>, IAnimationClipSource // TypeDefIndex: 56538
	{
		// Fields
		private const float COUNT_DOWN_EMPTY = -1f; // Metadata: 0x023485E5
		[SerializeField]
		private Animator _target; // 0x78
		[SerializeField]
		[Tooltip("Nullable, \u9636\u6BB51\u5E38\u89C4\u52A8\u753B")]
		private AnimationClip _clipA1; // 0x80
		[SerializeField]
		[Tooltip("Nullable, \u9636\u6BB51\u7279\u6B8A\u52A8\u753B")]
		private AnimationClip _clipA1s; // 0x88
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("\u5E38\u89C4\u878D\u5408\u90E8\u957F\u5EA6")]
		private float _transA1; // 0x90
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("\u7279\u6B8A\u878D\u5408\u90E8\u957F\u5EA6")]
		private float _transA1s; // 0x94
		[SerializeField]
		[Tooltip("\u7279\u6B8A\u52A8\u4F5C\u95F4\u9694\u968F\u673A\u8303\u56F4")]
		private UnityEngine.Vector2 _randomRangeA1s; // 0x98
		[SerializeField]
		[Tooltip("NonNull, \u9636\u6BB51\u5230\u9636\u6BB52\u7684\u5207\u6362\u52A8\u753B")]
		private AnimationClip _clipA1A2; // 0xA0
		[SerializeField]
		[Tooltip("A1\u5230A2\u8F6C\u6362\u7684\u524D\u7F6EDelay")]
		private float _predelayA1A2; // 0xA8
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("A1A2\u878D\u5408\u90E8\u957F\u5EA6")]
		private float _transA1A2; // 0xAC
		[SerializeField]
		[Tooltip("Nullable, \u9636\u6BB52\u5E38\u89C4\u52A8\u753B")]
		private AnimationClip _clipA2; // 0xB0
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("A2\u878D\u5408\u90E8\u957F\u5EA6")]
		private float _transA2; // 0xB8
		private UIAnimationMixPlayer m_player; // 0xC0
		private EState m_state; // 0xC8
		private float m_countDownA1s; // 0xCC
		private float m_countDownA1A2; // 0xD0
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001847333E0-0x0000000184733410 
	
		// Nested types
		private enum EState // TypeDefIndex: 56537
		{
			NONE = 0,
			A1 = 1,
			A2 = 2
		}
	
		// Constructors
		public LoginSceneAnimCtrl(); // 0x0000000184B6CD40-0x0000000184B6CDA0
	
		// Methods
		protected override void OnBindToManager(); // 0x00000001841E5760-0x00000001841E57E0
		private UIAnimationMixPlayer _EnsurePlayer(); // 0x0000000183D4FF30-0x0000000183D50000
		private void _ChangeToState(EState target); // 0x0000000183408830-0x00000001834088B0
		private void _ResetToA1(); // 0x0000000183D4F930-0x0000000183D4FB60
		private void _TransitionToA2(); // 0x00000001849B8B60-0x00000001849B9AB0
		private void _PlayA1sAndTriggerNext(); // 0x0000000183D4FD90-0x0000000183D4FF30
		private float _RandomIntervalA1s(); // 0x0000000183D50000-0x0000000183D50170
		private void _PlayA1A2Impl(); // 0x0000000183D4FB60-0x0000000183D4FD90
		public void OnValueChanged(LoginViewModel value); // 0x0000000183408790-0x0000000183408830
		protected override void Start(); // 0x000000018340A1D0-0x000000018340A280
		public override void Tick(float deltaTime); // 0x0000000182F446B0-0x0000000182F44780
		protected override void OnRelease(); // 0x0000000184994870-0x00000001849948F0
		public void GetAnimationClips(List<AnimationClip> results); // 0x00000001869B1654-0x00000001869B16A8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869B16B8-0x00000001869B16C0
		public void __iFixBaseProxy_OnBindToManager(); // 0x00000001869B16A8-0x00000001869B16B0
		public void __iFixBaseProxy_Start(); // 0x00000001869B16B0-0x00000001869B16B8
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public abstract class LoginSceneComponent : TickableMono // TypeDefIndex: 56539
	{
		// Fields
		[CompilerGenerated]
		private LoginContext _context_k__BackingField; // 0x68
		[CompilerGenerated]
		private LoginController _controller_k__BackingField; // 0x70
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001869B16C0-0x00000001869B170C 
		protected LoginContext context { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		protected LoginController controller { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
	
		// Constructors
		protected LoginSceneComponent(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected virtual void Start(); // 0x000000018340A300-0x000000018340A370
		public void Bind(LoginContext context, LoginController controller); // 0x00000001841E60C0-0x00000001841E6130
		protected virtual void OnBindToManager(); // 0x00000001841E5AA0-0x00000001841E5AD0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
	}

	public class LoginSceneRoot : LoginSceneComponent // TypeDefIndex: 56540
	{
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184D51C40-0x0000000184D51C70 
	
		// Constructors
		public LoginSceneRoot(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected override void OnBindToManager(); // 0x000000018380F010-0x000000018380F1F0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869B16B8-0x00000001869B16C0
		public void __iFixBaseProxy_OnBindToManager(); // 0x00000001869B16A8-0x00000001869B16B0
	}

	public class LoginAgeTipsDetailPanel : MonoBehaviour, ILoginBinder<LoginAgeTipsModel> // TypeDefIndex: 56541
	{
		// Fields
		[SerializeField]
		private UIAnimationWrapper _anim; // 0x18
		[SerializeField]
		private RectTransform _content; // 0x20
		[SerializeField]
		private UIText _txtTitle; // 0x28
		[SerializeField]
		private UIText _lineTmpl; // 0x30
		[SerializeField]
		private UIButton _btnClose; // 0x38
		[SerializeField]
		private UIScrollRect _scroll; // 0x40
		[SerializeField]
		private InputBindingGroupMonoTarget _ageTipsBindingGroup; // 0x48
		private LoginContext m_context; // 0x50
		private UISwitchTween m_switchTween; // 0x58
		private DG.Tweening.Tween m_displayDelayTween; // 0x60
		private const int MAX_TEXT_STRLEN = 10000; // Metadata: 0x023485EC
		private const int MIN_TEXT_STRLEN = 1000; // Metadata: 0x023485F0
	
		// Constructors
		public LoginAgeTipsDetailPanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Init(LoginContext context); // 0x00000001842B6AA0-0x00000001842B6C40
		public void OnValueChanged(LoginAgeTipsModel value); // 0x0000000184B48030-0x0000000184B480F0
		private void _RenderContent(string contentStr); // 0x00000001869AF530-0x00000001869AF6A0
		private void _ShowContent(); // 0x00000001869AF6A0-0x00000001869AF6FC
		private void _EventOnCloseClicked(PointerEventData _); // 0x00000001869AF4B8-0x00000001869AF530
		private static List<string> _SplitLicenseToSegments(string content); // 0x00000001869AF6FC-0x00000001869AF9E0
		private static void _SplitLongString(string longStr, List<string> outputList); // 0x00000001869AF9E0-0x00000001869AFAAC
	}

	public class LoginAgeTipsPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 56542
	{
		// Fields
		[SerializeField]
		private LoginAgeTipsDetailPanel _detailPanel; // 0x28
		[SerializeField]
		private UIButton _ageTipsCN; // 0x30
		[SerializeField]
		private GameObject _ageTipsKR; // 0x38
		[SerializeField]
		private CanvasGroup _canvasVersionTop; // 0x40
	
		// Constructors
		public LoginAgeTipsPanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnInit(); // 0x00000001842B61D0-0x00000001842B62F0
		public void OnValueChanged(LoginViewModel value); // 0x0000000183408A70-0x0000000183408B00
		private void _UpdateAgeTipsPolicy(LoginViewModel.FAgeTipsPolicy policy); // 0x0000000183409910-0x0000000183409990
		private void _EventOnOpenAgeTipsClicked(PointerEventData _); // 0x00000001869AFAB4-0x00000001869AFB2C
		public void __iFixBaseProxy_OnInit(); // 0x00000001869AFAAC-0x00000001869AFAB4
	}

	public class LoginAlertDialog : LoginController.Dialog // TypeDefIndex: 56544
	{
		// Fields
		[SerializeField]
		private UIButton _btnConfirm; // 0x38
		[SerializeField]
		private UIText _text; // 0x40
		private FParams m_params; // 0x48
	
		// Nested types
		public struct FParams // TypeDefIndex: 56543
		{
			// Fields
			public string text; // 0x00
			public Action onConfirm; // 0x08
		}
	
		// Constructors
		public LoginAlertDialog(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnInit(); // 0x00000001869AFB2C-0x00000001869AFC10
		public void SetParams(FParams param); // 0x00000001869AFC10-0x00000001869AFC98
		private void _OnConfirmClicked(PointerEventData evt); // 0x00000001869AFCA0-0x00000001869AFD04
		public void __iFixBaseProxy_OnInit(); // 0x00000001869AFC98-0x00000001869AFCA0
	}

	public class LoginDecorateUI : TickableUIMono, ILoginBinder<LoginViewModel>, ILoginContextReceiver // TypeDefIndex: 56545
	{
		// Fields
		[SerializeField]
		private CanvasGroup _imgLogo; // 0x68
		[SerializeField]
		private float _durationLogo; // 0x70
		[SerializeField]
		private AnimationClip _clipLoopGlow; // 0x78
		[SerializeField]
		private AnimationClip _clipInGlow; // 0x80
		[SerializeField]
		private Animator _targetGlow; // 0x88
		[SerializeField]
		private float _delay; // 0x90
		private LoginContext m_context; // 0x98
		private bool m_isOnTransNode; // 0xA0
		private Interpolator.FLerpByTime m_hideLogoLerp; // 0xA8
		private UIAnimationLayerMixPlayer m_glowPlayer; // 0xC8
		private bool m_isGlowEnabled; // 0xD0
		private float m_countDownDelay; // 0xD4
		private float m_countDownDisableGlow; // 0xD8
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184A357C0-0x0000000184A357F0 
	
		// Constructors
		public LoginDecorateUI(); // 0x0000000184CB1AE0-0x0000000184CB1B80
	
		// Methods
		public void OnLoginContext(LoginContext context); // 0x00000001841E4C00-0x00000001841E4CB0
		public void OnValueChanged(LoginViewModel value); // 0x0000000183408BB0-0x0000000183409910
		private void _TriggerTrans2GSLoginImpl(); // 0x0000000183D4F5A0-0x0000000183D4F720
		private void _ToggleGlow(bool enable); // 0x0000000183409D20-0x0000000183409E30
		private UIAnimationLayerMixPlayer _EnsureGlowPlayer(); // 0x0000000183D4F720-0x0000000183D4F830
		public override void Tick(float deltaTime); // 0x0000000183D4F360-0x0000000183D4F3D0
		protected override void OnRelease(); // 0x00000001849947F0-0x0000000184994870
		private void _TimeManagerTick(float timeDelta); // 0x0000000183D4F3D0-0x0000000183D4F5A0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public class LoginEnterGamePanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 56546
	{
		// Fields
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x28
		[SerializeField]
		private UIButton _btnEnterGame; // 0x30
		[SerializeField]
		private UIText _textEnterGame; // 0x38
		[SerializeField]
		private float _delayEnterGame; // 0x40
		private bool m_isPanelActive; // 0x44
		private double m_panelActiveTime; // 0x48
		private bool m_isInited; // 0x50
	
		// Constructors
		public LoginEnterGamePanel(); // 0x0000000184D11A70-0x0000000184D11A90
	
		// Methods
		private void _InitIfNot(); // 0x0000000184B6B370-0x0000000184B6B440
		public void OnValueChanged(LoginViewModel value); // 0x0000000183406E00-0x0000000183406EF0
		private void _OnEnterGameClicked(PointerEventData evt); // 0x000000018470AE70-0x000000018470AF20
	}

	public class LoginGovTipsPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 56547
	{
		// Fields
		[SerializeField]
		private UIButton _btnOpen; // 0x28
	
		// Constructors
		public LoginGovTipsPanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnInit(); // 0x00000001842B6100-0x00000001842B61D0
		public void OnValueChanged(LoginViewModel value); // 0x0000000183408960-0x00000001834089C0
		private void _EventOnOpenAgeTipsClicked(PointerEventData _); // 0x00000001869AFD14-0x00000001869AFD7C
		public void __iFixBaseProxy_OnInit(); // 0x00000001869AFAAC-0x00000001869AFAB4
	}

	public class LoginJudgeDialog : LoginController.Dialog // TypeDefIndex: 56550
	{
		// Fields
		[SerializeField]
		private UIButton _btnPositive; // 0x38
		[SerializeField]
		private UIButton _btnNegative; // 0x40
		[SerializeField]
		private UIText _text; // 0x48
		[SerializeField]
		private UIText _text2; // 0x50
		[SerializeField]
		private UIText _textPositive; // 0x58
		[SerializeField]
		private UIText _textNegative; // 0x60
		private FParams m_params; // 0x68
	
		// Nested types
		public enum Style // TypeDefIndex: 56548
		{
			Center = 0,
			Left = 1
		}
	
		public struct FParams // TypeDefIndex: 56549
		{
			// Fields
			public string text; // 0x00
			public Action onPositive; // 0x08
			public Action onNegative; // 0x10
			public string btnPositive; // 0x18
			public string btnNegative; // 0x20
			public Style style; // 0x28
		}
	
		// Constructors
		public LoginJudgeDialog(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnInit(); // 0x00000001869AFD7C-0x00000001869AFEC8
		public void SetParams(FParams param); // 0x00000001869AFEC8-0x00000001869B010C
		private void _OnPositiveClicked(PointerEventData evt); // 0x00000001869B0170-0x00000001869B01D4
		private void _OnNegativeClicked(PointerEventData evt); // 0x00000001869B010C-0x00000001869B0170
		public void __iFixBaseProxy_OnInit(); // 0x00000001869AFC98-0x00000001869AFCA0
	}

	public class LoginMenuPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 56552
	{
		// Fields
		public const string CONTROLLER_STATE_NORMAL = "Normal"; // Metadata: 0x023485F4
		public const string CONTROLLER_STATE_SELECT = "Select"; // Metadata: 0x023485FB
		[SerializeField]
		private UIButton _btnAnnounce; // 0x28
		[SerializeField]
		private UIButton _btnSetting; // 0x30
		[SerializeField]
		private UIButton _btnResCheck; // 0x38
		[SerializeField]
		private UIButton _btnLogout; // 0x40
		[SerializeField]
		private UIButton _btnQuitGame; // 0x48
		[SerializeField]
		private UIButton _btnLogin; // 0x50
		[SerializeField]
		private UIButton _btnQR; // 0x58
		[SerializeField]
		private UIStateController _ctrlAnnounce; // 0x60
		[SerializeField]
		private UIStateController _ctrlSetting; // 0x68
		[SerializeField]
		private UIStateController _ctrlResCheck; // 0x70
		[SerializeField]
		private UIStateController _ctrlLogout; // 0x78
		[SerializeField]
		private UIStateController _ctrlQR; // 0x80
		[SerializeField]
		private UISimpleStateController _ctrlRight; // 0x88
		[SerializeField]
		private UISelectableNaviGroup _naviGroupRight; // 0x90
		[SerializeField]
		private InputBindingGroupMonoTarget _bindingGroupForKeyboard; // 0x98
		[SerializeField]
		private InputBindingGroupMonoTarget _rootPanelBindingGroup; // 0xA0
		[SerializeField]
		private CanvasGroup _alphaHandler; // 0xA8
		[SerializeField]
		private GameObject _redDotAnnounce; // 0xB0
		[SerializeField]
		private UIAnimationWrapper _transAnim; // 0xB8
		[SerializeField]
		private UIButton _serverZoneBtn; // 0xC0
		[SerializeField]
		private UIText _serverZoneName; // 0xC8
		[SerializeField]
		private GameObject _serverZonePS5; // 0xD0
		[SerializeField]
		private UIText _serverZoneNamePS5; // 0xD8
		private UIStateController m_curRightBtnCtrl; // 0xE0
		private bool m_hasRedDot; // 0xE8
		private int m_rootParentGroupId; // 0xEC
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56551
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__43_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001869B4D40-0x00000001869B4DA4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnQuitGameClicked_b__43_0(); // 0x00000001869B4830-0x00000001869B4874
		}
	
		// Constructors
		public LoginMenuPanel(); // 0x0000000184D11A90-0x0000000184D11AB0
	
		// Methods
		protected override void OnInit(); // 0x00000001839D2890-0x00000001839D2F90
		public void OnValueChanged(LoginViewModel value); // 0x0000000183407440-0x00000001834077A0
		public void InitBulletinAndRedAfterLoginSuc(); // 0x00000001841E7B00-0x00000001841E8990
		private static void _OnBulletinOpen(); // 0x00000001869B08EC-0x00000001869B096C
		private static void _OnBulletinClose(); // 0x00000001869B0854-0x00000001869B08EC
		private void Awake(); // 0x0000000184CAA620-0x0000000184CAA800
		private void OnEnable(); // 0x00000001840101A0-0x00000001840103A0
		private void OnDisable(); // 0x00000001840103A0-0x0000000184010590
		protected override void OnDestroy(); // 0x00000001848AB5F0-0x00000001848AB6E0
		private void _OnAnnounceClicked(PointerEventData _); // 0x00000001869B0604-0x00000001869B07B4
		private void _OnSettingClicked(PointerEventData _); // 0x00000001869B1168-0x00000001869B1254
		private void _OnResCheckClicked(PointerEventData _); // 0x00000001869B1034-0x00000001869B10FC
		private void _OnCustomServiceClicked(PointerEventData _); // 0x00000001869B096C-0x00000001869B0A1C
		private void _OnAccountCenterClicked(PointerEventData _); // 0x00000001869B053C-0x00000001869B0604
		private void _OnLogoutClicked(PointerEventData _); // 0x00000001869B0CB0-0x00000001869B0D78
		private void _OnQuitGameClicked(PointerEventData _); // 0x00000001869B0E28-0x00000001869B0FC8
		private void _OnLoginClicked(PointerEventData _); // 0x00000001869B0C38-0x00000001869B0CB0
		private void _OnQRClicked(PointerEventData _); // 0x00000001869B0D78-0x00000001869B0E28
		private void _OnRequestRelogin(); // 0x00000001869B0FC8-0x00000001869B1034
		private bool _CanQRLogin(); // 0x0000000184D576D0-0x0000000184D57700
		private void _UpdateAnnounceRedDot(); // 0x00000001841E9090-0x00000001841E99E0
		private void _UpdateServerZone(); // 0x0000000183A85290-0x0000000183A85380
		private void _OnServerZoneBtnClicked(); // 0x00000001869B10FC-0x00000001869B1168
		private void _OnFocusMenuGroup(bool isFocused); // 0x00000001869B0A1C-0x00000001869B0B0C
		private void _OnAnnounceClosed(); // 0x00000001869B07B4-0x00000001869B0854
		private void _OnReceiveRedDotAndPopup(bool showRedDot); // 0x00000001841E99E0-0x00000001841E9A90
		private void _OnUpdateRedDotForSDKListener([IsReadOnly] in EventData<bool> show); // 0x00000001869B1254-0x00000001869B12B8
		private void _OnInputChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input); // 0x00000001869B0B0C-0x00000001869B0C38
		[CompilerGenerated]
		private void _OnInit_b__28_0(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001869B01D4-0x00000001869B0260
		[CompilerGenerated]
		private void _OnInit_b__28_1(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001869B0260-0x00000001869B02EC
		[CompilerGenerated]
		private void _OnInit_b__28_2(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001869B02EC-0x00000001869B0378
		[CompilerGenerated]
		private void _OnInit_b__28_3(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001869B0378-0x00000001869B0404
		[CompilerGenerated]
		private void _OnInit_b__28_4(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001869B0404-0x00000001869B0498
		[CompilerGenerated]
		private void _OnInit_b__28_5(PointerEventData _); // 0x00000001869B0498-0x00000001869B04A0
		[CompilerGenerated]
		private void _OnInit_b__28_6(bool isFocused); // 0x00000001869B04A0-0x00000001869B04A8
		[CompilerGenerated]
		private void __OnAnnounceClicked_b__37_0(string s); // 0x00000001869B04B0-0x00000001869B053C
		public void __iFixBaseProxy_OnInit(); // 0x00000001869AFAAC-0x00000001869AFAB4
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001869B04A8-0x00000001869B04B0
	}

	public class LoginMockUIDPanel : MonoBehaviour // TypeDefIndex: 56555
	{
		// Fields
		[SerializeField]
		private CanvasGroup _canvas; // 0x18
		[SerializeField]
		private UIInputField _userIdInputField; // 0x20
		[SerializeField]
		private UIButton _btnEnterGame; // 0x28
		[SerializeField]
		private UIButton _btnDelLocalFile; // 0x30
		[SerializeField]
		private UIDropdown _serverDropdown; // 0x38
		[SerializeField]
		private GameObject _hintSelectServer; // 0x40
		[SerializeField]
		private UIButton _btnClose; // 0x48
		[SerializeField]
		private UIText _selectedServerLabel; // 0x50
		private bool m_isInited; // 0x58
		private UISwitchTween m_switchTween; // 0x60
		private List<ServerDesc> m_serverDescList; // 0x68
		private ServerList m_serverListObj; // 0x70
		private ServerConfig m_serverConfig; // 0x78
		private Action<string> m_callback; // 0x80
		private FOptions m_options; // 0x88
		private const string LAST_SELECTED_SERVER_PREF_KEY = "LoginMockUIDPanel.LastSelectedServer"; // Metadata: 0x02348602
		private static LoginMockUIDPanel s_instance; // 0x00
	
		// Properties
		public static LoginMockUIDPanel instance { get; } // 0x00000001869B14B0-0x00000001869B151C 
	
		// Nested types
		public struct FOptions // TypeDefIndex: 56553
		{
			// Fields
			public string fixedUID; // 0x00
			public LoginContext context; // 0x08
	
			// Methods
			public bool IsUIDFixed(); // 0x0000000183F10080-0x0000000183F100C0
		}
	
		[CompilerGenerated]
		private sealed class _HideAndDestroy_d__22 : IEnumerator<object> // TypeDefIndex: 56554
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginMockUIDPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _HideAndDestroy_d__22(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001849D1390-0x00000001849D14D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869B47E4-0x00000001869B4830
		}
	
		// Constructors
		public LoginMockUIDPanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void LoginWithCallback(FOptions options, Action<string> callback); // 0x0000000183F0EF20-0x0000000183F0F070
		public void Refresh(); // 0x00000001869B12B8-0x00000001869B1308
		[IteratorStateMachine(typeof(_HideAndDestroy_d__22))]
		public IEnumerator HideAndDestroy(); // 0x0000000183F0E5A0-0x0000000183F0E610
		private void _UpdateStatus(); // 0x0000000183F0FEA0-0x0000000183F10080
		private void _InitLoginInfo(); // 0x0000000183DA3B90-0x0000000183DA3EB0
		private void _MovePreferredServerToFront(ref int curServerIndex); // 0x0000000183F4A940-0x0000000183F4AB20
		private int _IndexOfServer(string serverName); // 0x0000000183DA4A40-0x0000000183DA4B40
		private void _SaveLastSelectedServer(string serverName); // 0x0000000183F4B630-0x0000000183F4B6C0
		private void _SaveConfig(); // 0x0000000183DA4240-0x0000000183DA42B0
		private void _OnBtnEnterGame(); // 0x0000000184CE84A0-0x0000000184CE8520
		private void _SmokeEnterGame(string serverName, string uid); // 0x00000001869B135C-0x00000001869B1414
		private void _OnBtnDelLocalFile(); // 0x00000001869B1318-0x00000001869B135C
		private void _TryClosePanel(); // 0x00000001869B1414-0x00000001869B14B0
		private void _OnSelectServer(int index); // 0x0000000183F4AB20-0x0000000183F4ABC0
		private void OnDestroy(); // 0x0000000184D51270-0x0000000184D512B0
		[CompilerGenerated]
		private void __UpdateStatus_b__23_0(PointerEventData _); // 0x0000000184CE8490-0x0000000184CE84A0
		[CompilerGenerated]
		private void __UpdateStatus_b__23_1(PointerEventData _); // 0x00000001869B1308-0x00000001869B1310
		[CompilerGenerated]
		private void __UpdateStatus_b__23_2(PointerEventData _); // 0x00000001869B1310-0x00000001869B1318
		[CompilerGenerated]
		private void __InitLoginInfo_b__24_0(int index, UIDropdownOption options, bool isSelected); // 0x0000000183F4ABC0-0x0000000183F4AC10
	}

	public class LoginResourcePanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginHotUpdateModel> // TypeDefIndex: 56556
	{
		// Fields
		private const float PROGRESS_LERP_DURATION = 0.2f; // Metadata: 0x02348627
		[SerializeField]
		private CanvasGroup _alphaHandler; // 0x28
		[SerializeField]
		private UISlider _progressBar; // 0x30
		[SerializeField]
		private UIText _textTitle; // 0x38
		[SerializeField]
		private UIText _textInfo; // 0x40
		private LoginHotUpdateModel.IProgress m_progress; // 0x48
		private TweenUtils.FLerpByTime m_progressLerper; // 0x50
		private string m_resInfoCache; // 0x80
	
		// Constructors
		public LoginResourcePanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void OnValueChanged(LoginHotUpdateModel value); // 0x00000001849C89F0-0x00000001849C8AA0
		private void _UpdateResourceInfo(); // 0x00000001839367F0-0x00000001839369B0
		private void Update(); // 0x0000000183935650-0x00000001839367C0
	}

	public class LoginRootPanel : MonoBehaviour // TypeDefIndex: 56558
	{
		// Fields
		[SerializeField]
		private NotchAdapter _notchAdapter; // 0x18
		[SerializeField]
		private LoginMenuPanel _menuPanel; // 0x20
		[SerializeField]
		private LoginAgeTipsPanel _ageTipsPanel; // 0x28
		[SerializeField]
		private LoginGovTipsPanel _govTipsPanel; // 0x30
		[SerializeField]
		private LoginResourcePanel _resPanel; // 0x38
		[SerializeField]
		private LoginEnterGamePanel _enterGamePanel; // 0x40
		[SerializeField]
		private LoginServerSelectPanel _serverSelectPanel; // 0x48
		[SerializeField]
		private InputBindingGroupMonoTarget _bindingGroup; // 0x50
		private int m_loginRootBindingGroupId; // 0x58
	
		// Nested types
		public abstract class ChildPanel : MonoBehaviour, ILoginContextReceiver // TypeDefIndex: 56557
		{
			// Fields
			[CompilerGenerated]
			private UISwitchTween _switchTween_k__BackingField; // 0x18
			[CompilerGenerated]
			private LoginContext _context_k__BackingField; // 0x20
	
			// Properties
			protected UISwitchTween switchTween { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			protected LoginContext context { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
			// Constructors
			protected ChildPanel(); // 0x0000000185393520-0x0000000185393538
	
			// Methods
			public void OnLoginContext(LoginContext context); // 0x00000001841E5A50-0x00000001841E5AA0
			protected virtual void OnInit(); // 0x00000001842B60D0-0x00000001842B6100
			protected virtual void OnDestroy(); // 0x00000001848AB6E0-0x00000001848AB730
			protected void SetPanelVisibleByAnimSwitchTween(UIAnimationWrapper anim, bool isVisible, bool forceReset = false /* Metadata: 0x0234862B */); // 0x00000001869AAF5C-0x00000001869AB054
			protected void SetPanelVisibleByFadeSwitchTween(CanvasGroup canvasGroup, bool isVisible, bool forceReset = false /* Metadata: 0x0234862C */); // 0x0000000183406EF0-0x0000000183406FE0
		}
	
		// Constructors
		public LoginRootPanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x0000000183CD3860-0x0000000183CD3960
		private void OnDestroy(); // 0x0000000183CD3960-0x0000000183CD3A50
		public void Init(LoginContext context); // 0x00000001841E57E0-0x00000001841E58D0
		private void _OnNotchPaddingChanged([IsReadOnly] in EventData<float> data); // 0x00000001869B15B0-0x00000001869B1654
		private void _InitController(); // 0x00000001841E4B40-0x00000001841E4C00
		public void ToggleLoginBindingGroup(bool enable); // 0x00000001869B151C-0x00000001869B15B0
		public void InitBulletinAndRedAfterLoginSuc(); // 0x00000001841E7A80-0x00000001841E7AC0
		private static void _InitChildPanel(ChildPanel childPanel, LoginContext context); // 0x00000001841E58D0-0x00000001841E5A50
	}

	public class LoginServerSelectItemView : MonoBehaviour // TypeDefIndex: 56560
	{
		// Fields
		[SerializeField]
		private UIText _serverName; // 0x18
		[SerializeField]
		private UIImage _playerIcon; // 0x20
		[SerializeField]
		private UIText _playerLevel; // 0x28
		[SerializeField]
		private UIImage[] _delayImages; // 0x30
		[SerializeField]
		private UIText _delayText; // 0x38
		[SerializeField]
		private UIButton _btnSelect; // 0x40
		[SerializeField]
		private UIStateController _stateController; // 0x48
		private static readonly UnityEngine.Color DEFAULT_COLOR; // 0x00
		private const string DEFAULT_TEXT = "--"; // Metadata: 0x0234862D
		private static readonly DelayInfo DEFAULT_SPEED_INFO; // 0x10
		private ServerZoneManager.ServerZoneData m_serverItem; // 0x50
		private LoginContext m_context; // 0x58
		private List<DelayInfo> m_speedInfos; // 0x60
	
		// Nested types
		private struct DelayInfo // TypeDefIndex: 56559
		{
			// Fields
			public UnityEngine.Color color; // 0x00
			public int colorCount; // 0x10
			public int delayMax; // 0x14
			public string text; // 0x18
		}
	
		// Constructors
		public LoginServerSelectItemView(); // 0x00000001846093D0-0x00000001846096E0
		static LoginServerSelectItemView(); // 0x0000000184CB5D40-0x0000000184CB5E10
	
		// Methods
		public void RefreshView(LoginContext context, ServerZoneManager.ServerZoneData serverItem, bool isSelected); // 0x00000001869B179C-0x00000001869B1CC4
		public void NaviToBtnTarget(); // 0x00000001869B170C-0x00000001869B179C
		public void SetSelected(bool isSelected); // 0x00000001869B1CC4-0x00000001869B1D68
		private void _OnClicked(PointerEventData _); // 0x00000001869B1D68-0x00000001869B1DE0
	}

	public class LoginServerSelectProp : LoginProperty<LoginServerSelectModel> // TypeDefIndex: 56561
	{
		// Constructors
		public LoginServerSelectProp(LoginWorkFlow workflow); // 0x0000000183A7F900-0x0000000183A7F950
	}

	public class LoginServerItem // TypeDefIndex: 56562
	{
		// Fields
		public ServerZoneManager.ServerZoneData serverZoneData; // 0x10
	
		// Constructors
		public LoginServerItem(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class LoginServerSelectModel // TypeDefIndex: 56563
	{
		// Fields
		public bool showPanel; // 0x10
		public int selectedIndex; // 0x14
	
		// Properties
		public List<ServerZoneManager.ServerZoneData> serverList { get; } // 0x00000001869B2050-0x00000001869B20E4 
		public ServerZoneManager.ServerZoneData curServerZoneData { get; } // 0x00000001869B1FBC-0x00000001869B2050 
	
		// Constructors
		public LoginServerSelectModel(); // 0x0000000184D8CCE0-0x0000000184D8CCF0
	
		// Methods
		public void InitData(); // 0x00000001869B1E64-0x00000001869B1ECC
		public ServerZoneManager.ServerZoneData GetSelectedServer(); // 0x00000001869B1DE0-0x00000001869B1E64
		public bool UpdateSelectedServer(ServerZoneManager.ServerZoneData selectedServer); // 0x00000001869B1ECC-0x00000001869B1FBC
	}

	public class LoginServerSelectPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginServerSelectModel> // TypeDefIndex: 56566
	{
		// Fields
		[SerializeField]
		private UIButton _btnBack; // 0x28
		[SerializeField]
		private UIButton _btnConfirm; // 0x30
		[SerializeField]
		private UIAnimationWrapper _showAnim; // 0x38
		[SerializeField]
		private UIScrollList _showList; // 0x40
		[SerializeField]
		private UISelectableNaviGroup _naviGroup; // 0x48
		[SerializeField]
		private InputBindingGroupMonoTarget _bindingGroup; // 0x50
		[SerializeField]
		private InputBindingGroupMonoTarget _rootPanelBindingGroup; // 0x58
		private LoginServerSelectModel m_viewModel; // 0x60
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 56564
		{
			// Fields
			public LoginServerSelectPanel __4__this; // 0x10
			public List<ServerZoneManager.ServerZoneData> serverZoneDataList; // 0x18
			public List<SpeedTestServerInfo> serverList; // 0x20
			public Action<SpeedTestResult> callback; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OnEnable_b__0(SpeedTestResult result); // 0x00000001869B4874-0x00000001869B4BE8
			internal Task<Hypergryph.SpeedTest.TaskResult> _OnEnable_b__1(); // 0x00000001869B4BE8-0x00000001869B4C50
		}
	
		[CompilerGenerated]
		private sealed class __WaitingForShowListAwake_d__11 : IEnumerator<object> // TypeDefIndex: 56565
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginServerSelectPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __WaitingForShowListAwake_d__11(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001869B4DA4-0x00000001869B4E94
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869B4E94-0x00000001869B4EE0
		}
	
		// Constructors
		public LoginServerSelectPanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnInit(); // 0x00000001842B4AF0-0x00000001842B4D70
		private void OnDisable(); // 0x00000001869B20E4-0x00000001869B21E8
		private void OnEnable(); // 0x00000001869B21E8-0x00000001869B28F4
		[IteratorStateMachine(typeof(__WaitingForShowListAwake_d__11))]
		private IEnumerator _WaitingForShowListAwake(); // 0x00000001869B2EB4-0x00000001869B2F44
		private void _UpdateServerCell(GameObject cell, int index); // 0x00000001869B2CE8-0x00000001869B2DF4
		private void _UpdateServerSelected(int index, GameObject cell); // 0x00000001869B2DF4-0x00000001869B2EB4
		public void OnValueChanged(LoginServerSelectModel value); // 0x00000001869B28F4-0x00000001869B2A4C
		private void _NaviToSelectedItem(); // 0x00000001869B2A4C-0x00000001869B2B94
		private void _OnInputChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input); // 0x00000001869B2C84-0x00000001869B2CE8
		private void _OnCloseClicked(PointerEventData _); // 0x00000001869B2B94-0x00000001869B2C0C
		private void _OnConfirmClicked(PointerEventData _); // 0x00000001869B2C0C-0x00000001869B2C84
		public void __iFixBaseProxy_OnInit(); // 0x00000001869AFAAC-0x00000001869AFAB4
	}

	public class LoginVersionPanel : MonoBehaviour // TypeDefIndex: 56567
	{
		// Fields
		[SerializeField]
		private UIText _textVersion; // 0x18
	
		// Properties
		public string displayGameVersion { get; } // 0x000000018368CED0-0x000000018368D070 
		private string versionZoneType { get; } // 0x000000018368CD50-0x000000018368CDC0 
		private string versionPlatform { get; } // 0x000000018368CE30-0x000000018368CE80 
		private string versionAppType { get; } // 0x000000018368CE80-0x000000018368CED0 
		private string versionVersionNum { get; } // 0x00000001838118B0-0x0000000183811920 
		private string versionProjectCL { get; } // 0x000000018368CDC0-0x000000018368CE30 
	
		// Constructors
		public LoginVersionPanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Start(); // 0x000000018368CC80-0x000000018368CD50
	}

	public class LoginVocResSelDialog : LoginController.Dialog // TypeDefIndex: 56570
	{
		// Fields
		private FParams m_params; // 0x38
		[SerializeField]
		private UIButton _btnConfirm; // 0x40
		[SerializeField]
		private UIScrollList _showList; // 0x48
		[SerializeField]
		private UISelectableNaviGroup _naviGroup; // 0x50
		[SerializeField]
		private InputBindingGroupMonoTarget _bindingGroup; // 0x58
		private List<VocResInfo> m_vocResInfos; // 0x60
		private int m_selectedIndex; // 0x68
	
		// Nested types
		public struct FParams // TypeDefIndex: 56568
		{
			// Fields
			public Action onConfirm; // 0x00
		}
	
		public class VocResInfo // TypeDefIndex: 56569
		{
			// Fields
			public string nameTextId; // 0x10
			public EVFSBlockType type; // 0x18
	
			// Constructors
			public VocResInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public LoginVocResSelDialog(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnInit(); // 0x00000001869B3150-0x00000001869B34E4
		private int _ResolveInitialSelectedIndex(); // 0x00000001869B3AC8-0x00000001869B3C0C
		private void _RefreshConfirmInteractable(); // 0x00000001869B3A64-0x00000001869B3AC8
		private void OnEnable(); // 0x00000001869B3048-0x00000001869B3150
		private void OnDisable(); // 0x00000001869B2F44-0x00000001869B3048
		public void SetParams(FParams param); // 0x00000001869B34E4-0x00000001869B3548
		public void UpdateSelected(EVFSBlockType type); // 0x00000001869B3548-0x00000001869B3644
		private void _UpdateList(); // 0x00000001869B3CEC-0x00000001869B3DAC
		private void _UpdateSelected(int index, GameObject cell); // 0x00000001869B3DAC-0x00000001869B3E5C
		private void _UpdateCell(GameObject cell, int index); // 0x00000001869B3C0C-0x00000001869B3CEC
		[IDTag(1)]
		private void _OnConfirmClicked(PointerEventData evt); // 0x00000001869B394C-0x00000001869B3A00
		[IDTag(0)]
		private void _OnConfirmClicked(); // 0x00000001869B3788-0x00000001869B394C
		private void _OnInputTypeChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> data); // 0x00000001869B3A00-0x00000001869B3A64
		private void _NaviToSelectedItem(); // 0x00000001869B3644-0x00000001869B3788
		public void __iFixBaseProxy_OnInit(); // 0x00000001869AFC98-0x00000001869AFCA0
	}

	public class LoginVocResSelItemView : MonoBehaviour // TypeDefIndex: 56571
	{
		// Fields
		[SerializeField]
		private UIText _name; // 0x18
		[SerializeField]
		private UIText _size; // 0x20
		[SerializeField]
		private UIButton _btnSelect; // 0x28
		[SerializeField]
		private UIStateController _stateController; // 0x30
		private LoginVocResSelDialog.VocResInfo m_info; // 0x38
		private LoginVocResSelDialog m_context; // 0x40
		private const double MB = 1048576; // Metadata: 0x02348630
	
		// Constructors
		public LoginVocResSelItemView(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void RefreshView(LoginVocResSelDialog context, LoginVocResSelDialog.VocResInfo info, bool isSelected); // 0x00000001869B3EEC-0x00000001869B4274
		public void NaviToBtnTarget(); // 0x00000001869B3E5C-0x00000001869B3EEC
		public void SetSelected(bool isSelected); // 0x00000001869B4274-0x00000001869B4318
		private void _OnClicked(PointerEventData _); // 0x00000001869B4318-0x00000001869B438C
	}
}

namespace Beyond.Scripts.Entry
{
	public static class GameSettingSetter // TypeDefIndex: 56572
	{
		// Methods
		public static void RegisterSettingCallbacks(); // 0x000000018366F370-0x000000018366FC60
		private static void _OnAudioGlobalVolumeChange(float volume); // 0x00000001843F3130-0x00000001843F31A0
		private static void _OnAudioMusicVolumeChange(float volume); // 0x0000000184D38130-0x0000000184D381A0
		private static void _OnAudioVoiceVolumeChange(float volume); // 0x0000000184D380C0-0x0000000184D38130
		private static void _OnAudioSfxVolumeChange(float volume); // 0x00000001843F30C0-0x00000001843F3130
		private static void _OnAudioSuspendUnfocusedChange(bool suspendUnfocused); // 0x0000000184CE1800-0x0000000184CE1890
		private static void _OnAudioBackgroundMusicChange(bool enable); // 0x00000001869AB054-0x00000001869AB0A4
		private static void _OnAudioSuiteModeChange(GameSetting.GameSettingAudioSuiteMode mode); // 0x0000000183F92AF0-0x0000000183F92B80
		private static void _OnAudioControllerChange(bool enable); // 0x0000000184D27280-0x0000000184D27300
		private static void _OnAudioSpatialAudioChange(bool enable); // 0x0000000184007320-0x0000000184007390
		private static void _OnCameraDistanceLevelChange(float distance); // 0x00000001843F3290-0x00000001843F3320
		private static void _OnControllerMotionChange(bool valid); // 0x0000000184D27200-0x0000000184D27280
		private static void _OnKeyboardTypeChange(GameSetting.KeyboardLayoutType value); // 0x0000000183F92A00-0x0000000183F92A70
		private static void _OnLanguageTextChange(EnvLang language); // 0x000000018332ADD0-0x000000018332AF90
		private static void _OnLanguageAudioChange(GameSetting.GameSettingLanguageAudio language); // 0x000000018366EE20-0x000000018366EF40
		private static void _OnVideoQualityChange(GameSetting.GameSettingVideoQuality quality); // 0x0000000184B89C60-0x0000000184B89CD0
		private static void _OnVideoFullScreenChange(bool fullScreen); // 0x00000001836A4280-0x00000001836A4300
		private static void _OnVideoResolutionChange(GameSetting.ScreenResolution newResolution); // 0x000000018366D880-0x000000018366DB90
		private static void _SetResolution(int width, int height, bool fullScreen); // 0x00000001836A4300-0x00000001836A44E0
		private static void _OnVideoNotchPaddingChange(float notchPadding); // 0x00000001869AB0A4-0x00000001869AB15C
		private static void _OnTeammateSkillEffectStrengthChange(GameSetting.TeammateSkillEffectStrength strength); // 0x0000000183F92820-0x0000000183F928C0
		private static void _OnTeammateSkillEffectOpacityChange(float opacity); // 0x00000001843F31A0-0x00000001843F3230
	}

	public class WarmUpProgress : LoginHotUpdateModel.IProgress // TypeDefIndex: 56573
	{
		// Constructors
		public WarmUpProgress(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public double GetTotal(); // 0x00000001869B4FDC-0x00000001869B5064
		public double GetCurrent(); // 0x00000001869B4EE0-0x00000001869B4F70
		public string GetInfo(); // 0x00000001869B4F70-0x00000001869B4FDC
	}
}

namespace Beyond.SDK
{
	public class PlatformFont : IPlatformFont // TypeDefIndex: 56382
	{
		// Fields
		private const int DEFAULT_FONT_ID = -430371804; // Metadata: 0x023483BB
		private readonly bool m_forceChineseFont; // 0x10
	
		// Constructors
		public PlatformFont(bool forceChineseFont = false /* Metadata: 0x023483BA */); // 0x0000000184D86130-0x0000000184D86140
	
		// Methods
		public TMP_FontAsset GetFont(); // 0x000000018699B6E4-0x000000018699B77C
	}

	public static class SDKNetUtils // TypeDefIndex: 56391
	{
		// Fields
		public const string CONTENT_TYPE_JSON = "application/json"; // Metadata: 0x023483C0
		private const int GENERAL_TIMEOUT = 30; // Metadata: 0x023483D1
		private static HTTPImpl s_HTTPImpl; // 0x00
	
		// Nested types
		public struct HttpPostRequest // TypeDefIndex: 56383
		{
			// Fields
			public string url; // 0x00
			public string param; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> header; // 0x18
			public Action<WebHttpResponse> callback; // 0x20
		}
	
		public struct HttpGetRequest // TypeDefIndex: 56384
		{
			// Fields
			public string url; // 0x00
			public Action<WebHttpResponse> callback; // 0x08
		}
	
		public struct WebHttpResponse // TypeDefIndex: 56385
		{
			// Fields
			public bool isTimeout; // 0x00
			public bool isError; // 0x01
			public long responseCode; // 0x08
			public Dictionary<string, string> header; // 0x10
			public string text; // 0x18
			public byte[] data; // 0x20
			public string error; // 0x28
		}
	
		private enum HTTPOptType // TypeDefIndex: 56386
		{
			GET = 0,
			POST = 1
		}
	
		private struct HTTPConfig // TypeDefIndex: 56387
		{
			// Fields
			public string url; // 0x00
			public string body; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> header; // 0x18
			public HTTPOptType optType; // 0x20
			public Action<WebHttpResponse> callback; // 0x28
		}
	
		private abstract class HTTPImpl // TypeDefIndex: 56388
		{
			// Constructors
			protected HTTPImpl(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public abstract IEnumerator DoHTTP(HTTPConfig config);
		}
	
		private class BeyondHttp : HTTPImpl // TypeDefIndex: 56390
		{
			// Nested types
			[CompilerGenerated]
			private sealed class _DoHTTP_d__0 : IEnumerator<object> // TypeDefIndex: 56389
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public HTTPConfig config; // 0x20
				private WaitForAsyncTask<HttpSender.Result> _sendTask_5__2; // 0x50
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public _DoHTTP_d__0(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x000000018699BDC0-0x000000018699C05C
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018699C05C-0x000000018699C0A8
			}
	
			// Constructors
			public BeyondHttp(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			[IteratorStateMachine(typeof(_DoHTTP_d__0))]
			public override IEnumerator DoHTTP(HTTPConfig config); // 0x00000001869964CC-0x0000000186996594
		}
	
		// Constructors
		static SDKNetUtils(); // 0x000000018699BAC0-0x000000018699BB30
	
		// Methods
		public static void HTTPPost(HttpPostRequest request); // 0x000000018699B8D4-0x000000018699BAC0
		public static void HTTPGet(HttpGetRequest request); // 0x000000018699B77C-0x000000018699B8D4
	}

	public static class SDKTextDefines // TypeDefIndex: 56392
	{
		// Fields
		public const string CS_SDK_STO_DESC = "CS_SDK_STO_DESC"; // Metadata: 0x023483D4
		public const string CS_SDK_COMMON_ERROR = "CS_SDK_COMMON_ERROR"; // Metadata: 0x023483E4
		public const string CS_SDK_CREATE_ORDER_ERROR = "CS_SDK_CREATE_ORDER_ERROR"; // Metadata: 0x023483F8
		public const string CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT = "CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT"; // Metadata: 0x02348412
		public const string CS_SDK_USR_BAN = "CS_SDK_USR_BAN"; // Metadata: 0x02348438
		public const string CS_SDK_USR_BAN_TIME = "CS_SDK_USR_BAN_TIME"; // Metadata: 0x02348447
		public const string CS_SDK_LOGIN_FORBID = "CS_SDK_LOGIN_FORBID"; // Metadata: 0x0234845B
		public const string CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT = "CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT"; // Metadata: 0x0234846F
		public const string CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR = "CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR"; // Metadata: 0x02348499
		public const string CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID = "CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID"; // Metadata: 0x023484C1
	}
}

namespace Beyond.SDK.Impl
{
	public class U8ExternalTools : SDKExternalToolsShortcut // TypeDefIndex: 56400
	{
		// Fields
		private static bool s_inited; // 0x00
		private static bool s_initing; // 0x01
		private static bool s_needRetry; // 0x02
		private static bool s_needQuitGame; // 0x03
		private static FHGSDKInit s_initHGSDK; // 0x04
	
		// Nested types
		private struct FHGSDKInit // TypeDefIndex: 56393
		{
			// Fields
			public bool isIniting; // 0x00
			public bool isInited; // 0x01
		}
	
		private class CaptchaHandler : SDKCaptchaHandler // TypeDefIndex: 56395
		{
			// Fields
			private const int FAILED = 1000; // Metadata: 0x023484E9
			private long m_flag; // 0x10
			private string m_desc; // 0x18
	
			// Nested types
			[CompilerGenerated]
			private sealed class _FetchCaptchaCoroutine_d__3 : IEnumerator<object> // TypeDefIndex: 56394
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string captchaParams; // 0x20
				public CaptchaHandler __4__this; // 0x28
				public SDKCaptchaHandler.Result outResult; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
				// Constructors
				[DebuggerHidden]
				public _FetchCaptchaCoroutine_d__3(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
				private bool MoveNext(); // 0x000000018699C400-0x000000018699C4F4
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x000000018699C4F4-0x000000018699C540
			}
	
			// Constructors
			public CaptchaHandler(); // 0x0000000184D8CCA0-0x0000000184D8CCB0
	
			// Methods
			[IteratorStateMachine(typeof(_FetchCaptchaCoroutine_d__3))]
			public override IEnumerator FetchCaptchaCoroutine(string captchaParams, Result outResult); // 0x0000000186996594-0x000000018699665C
			public void OnGT3Message(Dictionary<string, object> msg); // 0x000000018699665C-0x0000000186996750
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56396
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<object> __9__9_0; // 0x08
			public static Action<string> __9__9_1; // 0x10
			public static Action __9__27_0; // 0x18
	
			// Constructors
			static __c(); // 0x0000000184D4AF50-0x0000000184D4AFB0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _InitSDKSystem_b__9_0(object error); // 0x000000018699C540-0x000000018699C6E8
			internal void _InitSDKSystem_b__9_1(string rawExtConfig); // 0x00000001835A38E0-0x00000001835A39D0
			internal void __ProcessExtraInfo_b__27_0(); // 0x000000018699C70C-0x000000018699C774
		}
	
		[CompilerGenerated]
		private sealed class _WaitForInited_d__10 : IEnumerator<object> // TypeDefIndex: 56397
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForInited_d__10(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184B4A840-0x0000000184B4A8B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699C94C-0x000000018699C998
		}
	
		[CompilerGenerated]
		private sealed class _WaitForInitHGSDK_d__15 : IEnumerator<object> // TypeDefIndex: 56398
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForInitHGSDK_d__15(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184CD0580-0x0000000184CD05F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699C900-0x000000018699C94C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 56399
		{
			// Fields
			public Action<SDKExternalTools.POSTResult> callback; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _POSTImplementation_b__0(SDKNetUtils.WebHttpResponse webRequest); // 0x000000018699C7C0-0x000000018699C824
		}
	
		// Constructors
		public U8ExternalTools(); // 0x0000000184D778D0-0x0000000184D778E0
	
		// Methods
		public static bool IsInited(); // 0x000000018699EFE4-0x000000018699F050
		public static bool NeedRetryInit(); // 0x0000000183C90D50-0x0000000183C90DA0
		public static bool NeedQuitGame(); // 0x0000000184A427C0-0x0000000184A42810
		public static void RetryInitSDKSystem(string env); // 0x000000018699F3C4-0x000000018699F464
		public static void PublicSetGameVersion(string version); // 0x0000000184D225E0-0x0000000184D22660
		public static void InitSDKSystem(string env); // 0x0000000183C8F0A0-0x0000000183C8F3C0
		[IteratorStateMachine(typeof(_WaitForInited_d__10))]
		public static IEnumerator WaitForInited(); // 0x0000000184A42760-0x0000000184A427C0
		public static void InitHGSDK(string env); // 0x0000000183AF7760-0x0000000183AF78D0
		public static bool IsHGSDKInited(); // 0x000000018699EF78-0x000000018699EFE4
		[IteratorStateMachine(typeof(_WaitForInitHGSDK_d__15))]
		public static IEnumerator WaitForInitHGSDK(); // 0x000000018332A350-0x000000018332A3B0
		protected override void Log(string content); // 0x000000018699F130-0x000000018699F184
		protected override void LogError(string content); // 0x000000018699F050-0x000000018699F0DC
		protected override void LogWarning(string content); // 0x000000018699F0DC-0x000000018699F130
		protected override string GetSignKey(); // 0x000000018699EF0C-0x000000018699EF78
		public override Dictionary<string, string> GetDeviceIDs(); // 0x000000018699EBA0-0x000000018699ECD4
		public void SetSubChannel(string subChannel); // 0x000000018699F464-0x000000018699F4C8
		protected override int GetPlatformKey(); // 0x000000018699EE94-0x000000018699EF0C
		public override void OnSDKExtraInfo(string jsonData); // 0x00000001844419B0-0x0000000184441A40
		protected override string U8RootUrl(); // 0x000000018699F4D0-0x000000018699F560
		protected override void POSTImplementation(POSTRequest request, Action<POSTResult> callback); // 0x000000018699F184-0x000000018699F3C4
		private static POSTResult _ConvertToPOSTResult(SDKNetUtils.WebHttpResponse response); // 0x000000018699F560-0x000000018699F664
		private void _ProcessExtraInfo(SDKExtraData extraData); // 0x0000000184441BC0-0x0000000184445630
		private static void _ProcessGameProtocolUpdateCheck(Dictionary<string, object> msg); // 0x00000001814FF310-0x0000000181500F80
		private static long _TryGetGameProtocolUpdateCheckErrorCode(Dictionary<string, object> msg); // 0x0000000181500F80-0x0000000181502380
		private static void _OnRequestExitGame(); // 0x000000018699FA4C-0x000000018699FAE8
		private static void _OnFakeAccountCenter(); // 0x000000018699FA0C-0x000000018699FA4C
		protected override SDKCaptchaHandler CreateCaptchaHandler(); // 0x000000018699EB24-0x000000018699EBA0
		protected override string GetErrorMessage(ErrMsgMeta meta); // 0x000000018699ECD4-0x000000018699EE94
		private bool _ErrorMsg_GET_TOKEN(ErrMsgMeta meta, out string errorMsg); // 0x000000018699F804-0x000000018699FA0C
		private bool _ErrorMsg_CREATE_ORDER(ErrMsgMeta meta, out string errorMsg); // 0x000000018699F664-0x000000018699F804
		public string __iFixBaseProxy_GetSignKey(); // 0x00000001811EC580-0x00000001811EC590
		public Dictionary<string, string> __iFixBaseProxy_GetDeviceIDs(); // 0x000000018699F4C8-0x000000018699F4D0
		public void __iFixBaseProxy_OnSDKExtraInfo(string P0); // 0x00000001841E1670-0x00000001841E1680
	}

	public class U8Plugin : IExternalPlugin // TypeDefIndex: 56403
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 56401
		{
			// Fields
			public ExternalPluginPayParams args; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Pay_b__0(U8PayResult payResult); // 0x000000018699C844-0x000000018699C87C
			internal void _Pay_b__1(object failMsg); // 0x000000018699C87C-0x000000018699C89C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 56402
		{
			// Fields
			public ExternalPluginLoginParams args; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __MockLogin_b__0(string uid); // 0x0000000183074E90-0x0000000183074F90
		}
	
		// Constructors
		public U8Plugin(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public string GetPayAddition(); // 0x000000018699FAE8-0x000000018699FB34
		public string GetSDKToken(); // 0x000000018699FB34-0x000000018699FB80
		public string GetSDKUid(); // 0x000000018699FB80-0x000000018699FBCC
		public void Init(); // 0x00000001835A20D0-0x00000001835A2100
		public void Login(ExternalPluginLoginParams args); // 0x0000000183AF75B0-0x0000000183AF7680
		public void Logout(ExternalPluginLogoutParams args); // 0x000000018699FBCC-0x000000018699FC54
		public void OnProductListChanged(List<U8ProductInfo> productList); // 0x000000018699FC54-0x000000018699FCA8
		public void Pay(ExternalPluginPayParams args); // 0x000000018699FCA8-0x000000018699FE8C
		public bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta); // 0x000000018699FE8C-0x000000018699FFA4
		private static bool _UseMockVersion(); // 0x0000000183AF7680-0x0000000183AF76E0
		private void _MockLogin(ExternalPluginLoginParams args); // 0x0000000183AF90A0-0x0000000183AF91C0
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 56370
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 56371
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 56372
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 56373
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 56374
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Beyond.UI
{
	public class SplashController : MonoBehaviour // TypeDefIndex: 56381
	{
		// Fields
		private const string CURSOR_KEY_SPLASH = "SplashController"; // Metadata: 0x023483A2
		private const string SPLASH_RESOURCES_PATH = "Splash"; // Metadata: 0x023483B3
		[SerializeField]
		private float _initialFadeTime; // 0x18
		[SerializeField]
		private float _regularFadeTime; // 0x1C
		[SerializeField]
		private float _showTime; // 0x20
		[SerializeField]
		private Image _blackCoverImage; // 0x28
		[SerializeField]
		private Image _splashImage; // 0x30
		[SerializeField]
		private SplashConfigs _splashConfigsCN; // 0x38
		[SerializeField]
		private SplashConfigs _splashConfigsOS; // 0x50
		private DG.Tweening.Sequence m_tween; // 0x68
		private Action m_onComplete; // 0x70
		private bool m_skipLicense; // 0x78
		private static bool s_isPlaying; // 0x00
		private bool m_canBeHide; // 0x79
		[CompilerGenerated]
		private static SplashController _instance_k__BackingField; // 0x08
	
		// Properties
		public static SplashController instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000186993DDC-0x0000000186993E14 0x0000000186993E14-0x0000000186993E68
		public static bool isPlaying { get; } // 0x000000018340B960-0x000000018340B9B0 
	
		// Nested types
		[Serializable]
		private struct SplashConfig // TypeDefIndex: 56375
		{
			// Fields
			public Sprite sprite; // 0x00
			public bool blackCoverFadeOut; // 0x08
		}
	
		[Serializable]
		private struct SplashConfigOverride // TypeDefIndex: 56376
		{
			// Fields
			public EnvLang envLang; // 0x00
			public SplashConfig[] splashConfigs; // 0x08
		}
	
		[Serializable]
		private struct SplashConfigs // TypeDefIndex: 56377
		{
			// Fields
			public SplashConfig[] splashConfigs; // 0x00
			public SplashConfig[] splashConfigsVNMobile; // 0x08
			public SplashConfigOverride[] i18nSplashConfigOverrides; // 0x10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 56378
		{
			// Fields
			public SplashConfig config; // 0x10
			public SplashController __4__this; // 0x20
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __DoStartSplash_b__0(); // 0x0000000184D25EF0-0x0000000184D25F20
			internal void __DoStartSplash_b__2(); // 0x0000000184CF4D60-0x0000000184CF4DD0
		}
	
		[CompilerGenerated]
		private sealed class __OnSplashCompleteCoroutine_d__33 : IEnumerator<object> // TypeDefIndex: 56379
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SplashController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __OnSplashCompleteCoroutine_d__33(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183811690-0x00000001838118B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699DCF0-0x000000018699DD3C
		}
	
		[CompilerGenerated]
		private sealed class __StartLicenseCoroutine_d__34 : IEnumerator<object> // TypeDefIndex: 56380
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private bool _displayCursor_5__2; // 0x20
			private bool _usingController_5__3; // 0x21
			private bool _isGranted_5__4; // 0x22
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __StartLicenseCoroutine_d__34(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183A72270-0x0000000183A724C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018699DD88-0x000000018699DDD4
		}
	
		// Constructors
		public SplashController(); // 0x0000000184D5EC50-0x0000000184D5EC80
	
		// Methods
		public static SplashController Show(Action onComplete = null, bool skipLicense = false /* Metadata: 0x023483A1 */); // 0x000000018380F750-0x000000018380FA90
		public static void Hide(); // 0x000000018380F650-0x000000018380F750
		public static void CanFinished(); // 0x000000018380F5A0-0x000000018380F650
		private void Awake(); // 0x000000018380F460-0x000000018380F510
		private void OnDestroy(); // 0x000000018380F510-0x000000018380F5A0
		private void _Play(Action onComplete, bool skipLicense); // 0x00000001841E4EF0-0x00000001841E5000
		private void _Stop(); // 0x000000018380E980-0x000000018380EA50
		private SplashConfig[] _GetSplashConfigs(); // 0x00000001841E5000-0x00000001841E5100
		private void _DoStartSplash(SplashConfig[] splashConfigs); // 0x00000001845E2E10-0x00000001845E3170
		private void _OnTweenFinished(); // 0x0000000184CA7270-0x0000000184CA72D0
		[IteratorStateMachine(typeof(__OnSplashCompleteCoroutine_d__33))]
		private IEnumerator _OnSplashCompleteCoroutine(); // 0x0000000184CA72D0-0x0000000184CA7340
		[IteratorStateMachine(typeof(__StartLicenseCoroutine_d__34))]
		private IEnumerator _StartLicenseCoroutine(); // 0x0000000184D32AA0-0x0000000184D32B00
		[CompilerGenerated]
		private void __DoStartSplash_b__31_1(); // 0x0000000184D4E7C0-0x0000000184D4E810
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 56296
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 56576
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37790-0x0000000184D37800
	
		// Methods
		public GameState __Gen_Wrap_0(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_1(object P0, GameState P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_2(float P0); // 0x00000001869ABD7C-0x00000001869ABE3C
		public void __Gen_Wrap_3(bool P0); // 0x0000000186375088-0x0000000186375148
		public void __Gen_Wrap_4(GameSetting.GameSettingAudioSuiteMode P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_5(GameSetting.KeyboardLayoutType P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_6(EnvLang P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_7(GameSetting.GameSettingLanguageAudio P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_8(GameSetting.GameSettingVideoQuality P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_9(int P0, int P1, bool P2); // 0x00000001869AF3C0-0x00000001869AF4B8
		public void __Gen_Wrap_10(GameSetting.ScreenResolution P0); // 0x00000001869AB15C-0x00000001869AB250
		public void __Gen_Wrap_11(GameSetting.TeammateSkillEffectStrength P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_12(); // 0x00000001863625A4-0x0000000186362640
		public void __Gen_Wrap_13(object P0); // 0x00000001863633B4-0x0000000186363474
		public bool __Gen_Wrap_14(object P0); // 0x00000001863632E4-0x00000001863633B4
		public SplashController.SplashConfig[] __Gen_Wrap_15(object P0); // 0x00000001869AB250-0x00000001869AB32C
		public IEnumerator __Gen_Wrap_16(object P0); // 0x00000001869AB32C-0x00000001869AB41C
		public void __Gen_Wrap_17(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public void __Gen_Wrap_18(object P0, object P1, bool P2); // 0x00000001869AB41C-0x00000001869AB500
		public SplashController __Gen_Wrap_19(object P0, bool P1); // 0x00000001869AB500-0x00000001869AB5F8
		public void __Gen_Wrap_20(in EventData<bool, bool> P0); // 0x00000001869AB5F8-0x00000001869AB6F0
		public string __Gen_Wrap_21(); // 0x00000001869AB6F0-0x00000001869AB7A8
		public string __Gen_Wrap_22(object P0); // 0x00000001869AB7A8-0x00000001869AB898
		public bool __Gen_Wrap_23(object P0, uint P1); // 0x00000001869AB898-0x00000001869AB970
		public GameApp.FileEntry __Gen_Wrap_24(GameApp.PendingFile P0); // 0x00000001869AB970-0x00000001869ABA7C
		public List<GameApp.FileEntry> __Gen_Wrap_25(object P0, int P1); // 0x00000001869ABA7C-0x00000001869ABB74
		public int __Gen_Wrap_26(object P0, object P1); // 0x0000000186360610-0x00000001863606FC
		public string __Gen_Wrap_27(long P0); // 0x00000001869ABB74-0x00000001869ABC50
		public void __Gen_Wrap_28(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public void __Gen_Wrap_29(object P0, object P1, System.DateTime P2, object P3, object P4); // 0x00000001869ABC50-0x00000001869ABD7C
		public void __Gen_Wrap_30(object P0, object P1, int P2, object P3); // 0x00000001869ABE3C-0x00000001869ABF34
		public void __Gen_Wrap_31(object P0, object P1, int P2); // 0x00000001863778A4-0x0000000186377988
		public bool __Gen_Wrap_32(); // 0x00000001863623A8-0x0000000186362454
		public void __Gen_Wrap_33(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public void __Gen_Wrap_34(int P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_35(GameAppExitCode P0); // 0x000000018635FF24-0x000000018635FFE4
		public bool __Gen_Wrap_36(out string P0); // 0x00000001869ABF34-0x00000001869AC03C
		public bool __Gen_Wrap_37(object P0, out LocalResPref P1, out VirtualFileSystem.BlockValidator P2); // 0x00000001869AC03C-0x00000001869AC1C4
		public void __Gen_Wrap_38(object P0, out VirtualFileSystem.BlockValidator P1); // 0x00000001869AC1C4-0x00000001869AC2EC
		public void __Gen_Wrap_39(object P0, in EventData<Beyond.DeviceInfo.InputType> P1); // 0x00000001869AC2EC-0x00000001869AC400
		public LoginController.MaskCtrl __Gen_Wrap_40(object P0); // 0x00000001869AC400-0x00000001869AC4F0
		public UISwitchTween __Gen_Wrap_41(object P0, int P1); // 0x00000001869AC4F0-0x00000001869AC5FC
		public IEnumerator __Gen_Wrap_42(object P0, object P1); // 0x00000001869AC5FC-0x00000001869AC708
		public void __Gen_Wrap_43(object P0, object P1, LoginController.EMaskType P2, bool P3, bool P4); // 0x00000001869AC708-0x00000001869AC81C
		public UIAnimationLayerMixPlayer __Gen_Wrap_44(object P0); // 0x00000001869AC81C-0x00000001869AC90C
		public void __Gen_Wrap_45(object P0, LoginController.FOptions P1); // 0x00000001869AC90C-0x00000001869ACA1C
		public LoginWorkFlow.FWork __Gen_Wrap_46(); // 0x00000001869ACA1C-0x00000001869ACB10
		public LoginWorkFlow.ENode __Gen_Wrap_47(ref LoginWorkFlow.FWork P0); // 0x00000001869ACB10-0x00000001869ACC64
		public bool __Gen_Wrap_48(LoginWorkFlow.ENode P0, LoginWorkFlow.ENode P1); // 0x00000001869ACC64-0x00000001869ACD4C
		public bool __Gen_Wrap_49(LoginWorkFlow.ENode P0); // 0x0000000186361FA4-0x0000000186362070
		public IEnumerator __Gen_Wrap_50(LoginWorkFlow.ENode P0); // 0x00000001869ACD4C-0x00000001869ACE38
		public CustomYieldInstruction __Gen_Wrap_51(object P0); // 0x00000001869ACE38-0x00000001869ACF28
		public bool __Gen_Wrap_52(ref LoginWorkFlow.FWork P0); // 0x00000001869ACF28-0x00000001869AD07C
		public void __Gen_Wrap_53(ref LoginWorkFlow.FWork P0); // 0x00000001869AD07C-0x00000001869AD1C0
		public void __Gen_Wrap_54(object P0, LoginAlertDialog.FParams P1); // 0x00000001869AD1C0-0x00000001869AD2C0
		public void __Gen_Wrap_55(object P0, LoginVocResSelDialog.FParams P1); // 0x00000001869AD2C0-0x00000001869AD3C0
		public void __Gen_Wrap_56(object P0, LoginJudgeDialog.FParams P1); // 0x00000001869AD3C0-0x00000001869AD4E4
		public void __Gen_Wrap_57(LoginAlertDialog P0, LoginAlertDialog.FParams P1); // 0x00000001869AD4E4-0x00000001869AD5E4
		public void __Gen_Wrap_58(object P0, bool P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8); // 0x00000001869AD5E4-0x00000001869AD73C
		public IEnumerator __Gen_Wrap_59(object P0, bool P1); // 0x00000001869AD73C-0x00000001869AD848
		public bool __Gen_Wrap_60(object P0, out LoginWorkFlow.ENode P1); // 0x00000001869AD848-0x00000001869AD954
		public void __Gen_Wrap_61(GameState P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_62(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public LoginRootPanel __Gen_Wrap_63(object P0); // 0x00000001869AD954-0x00000001869ADA44
		public float __Gen_Wrap_64(object P0); // 0x00000001866C0730-0x00000001866C0800
		public LoginController __Gen_Wrap_65(object P0); // 0x00000001869ADA44-0x00000001869ADB34
		public void __Gen_Wrap_66(object P0, object P1, float P2); // 0x00000001869ADB34-0x00000001869ADC18
		public List<ServerZoneManager.ServerZoneData> __Gen_Wrap_67(object P0); // 0x00000001869ADC18-0x00000001869ADD08
		public bool __Gen_Wrap_68(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public ServerZoneManager.ServerZoneData __Gen_Wrap_69(object P0); // 0x00000001869ADD08-0x00000001869ADDF8
		public bool __Gen_Wrap_70(object P0, ELoginEvent P1, object P2); // 0x00000001869ADDF8-0x00000001869ADEFC
		public void __Gen_Wrap_71(object P0, ELoginEvent P1, object P2); // 0x00000001866F4C88-0x00000001866F4D80
		public void __Gen_Wrap_72(string P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_73(PointerEventData P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_74(ref LoginMockUIDPanel.FOptions P0); // 0x00000001869ADEFC-0x00000001869AE048
		public void __Gen_Wrap_75(object P0, ref int P1); // 0x00000001869AE048-0x00000001869AE148
		public void __Gen_Wrap_76(int P0, UIDropdownOption P1, bool P2); // 0x00000001869AE148-0x00000001869AE22C
		public void __Gen_Wrap_77(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_78(object P0, LoginMockUIDPanel.FOptions P1, object P2); // 0x00000001869AE22C-0x00000001869AE358
		public UISwitchTween __Gen_Wrap_79(object P0); // 0x00000001869AE358-0x00000001869AE448
		public bool __Gen_Wrap_80(object P0, LoginController.EMaskType P1); // 0x00000001866E0A9C-0x00000001866E0B88
		public void __Gen_Wrap_81(LoginVocResSelDialog P0, LoginVocResSelDialog.FParams P1); // 0x00000001869AE448-0x00000001869AE548
		public IEnumerator __Gen_Wrap_82(object P0, object P1, object P2, object P3); // 0x00000001869AE548-0x00000001869AE680
		public void __Gen_Wrap_83(LoginJudgeDialog P0, LoginJudgeDialog.FParams P1); // 0x00000001869AE680-0x00000001869AE790
		public void __Gen_Wrap_84(object P0, object P1, object P2, object P3); // 0x00000001866E8E30-0x00000001866E8F38
		public string __Gen_Wrap_85(object P0, object P1, object P2); // 0x00000001869AE790-0x00000001869AE8B8
		public void __Gen_Wrap_86(ref bool P0); // 0x00000001869AE8B8-0x00000001869AE98C
		public void __Gen_Wrap_87(object P0, ref bool P1); // 0x00000001869AE98C-0x00000001869AEA7C
		public void __Gen_Wrap_88(object P0, LoginManager.FFlowWithMask P1); // 0x00000001869AEA7C-0x00000001869AEBA0
		public bool __Gen_Wrap_89(ref LoginManager.FFlowCondition P0, LoginWorkFlow.ENode P1); // 0x00000001869AEBA0-0x00000001869AECF4
		public IEnumerator __Gen_Wrap_90(object P0, LoginManager.FFlowWithMask P1); // 0x00000001869AECF4-0x00000001869AEE34
		public TMP_FontAsset __Gen_Wrap_91(object P0); // 0x00000001869AEE34-0x00000001869AEF10
		public void __Gen_Wrap_92(SDKNetUtils.HttpPostRequest P0); // 0x00000001869AEF10-0x00000001869AF004
		public void __Gen_Wrap_93(SDKNetUtils.HttpGetRequest P0); // 0x00000001869AF004-0x00000001869AF0E8
		public IEnumerator __Gen_Wrap_94(object P0, SDKNetUtils.HTTPConfig P1); // 0x00000001869AF0E8-0x00000001869AF218
		public IEnumerator __Gen_Wrap_95(); // 0x00000001869AF218-0x00000001869AF2E4
		public Dictionary<string, string> __Gen_Wrap_96(object P0); // 0x00000001869AF2E4-0x00000001869AF3C0
		public int __Gen_Wrap_97(object P0); // 0x0000000186360E84-0x0000000186360F54
		public long __Gen_Wrap_98(object P0); // 0x00000001811D1C90-0x00000001811D1F50
		public void __Gen_Wrap_99(object P0, SDKExtraData P1); // 0x0000000181527E90-0x0000000181528510
		public SDKExternalTools.POSTResult __Gen_Wrap_100(SDKNetUtils.WebHttpResponse P0); // 0x000000018150B3A0-0x000000018150BF40
		public void __Gen_Wrap_101(SDKNetUtils.WebHttpResponse P0); // 0x000000018150BF40-0x000000018150C4F0
		public void __Gen_Wrap_102(object P0, SDKExternalTools.POSTRequest P1, object P2); // 0x000000018150C4F0-0x000000018150CC40
		public SDKCaptchaHandler __Gen_Wrap_103(object P0); // 0x000000018150CC40-0x000000018150D570
		public bool __Gen_Wrap_104(object P0, SDKExternalTools.ErrMsgMeta P1, out string P2); // 0x000000018150D570-0x000000018150E2F0
		public string __Gen_Wrap_105(object P0, SDKExternalTools.ErrMsgMeta P1); // 0x000000018150E2F0-0x000000018150EFD0
		public IEnumerator __Gen_Wrap_106(object P0, object P1, object P2); // 0x000000018150EFD0-0x000000018150FAD0
		public void __Gen_Wrap_107(object P0, ExternalPluginLoginParams P1); // 0x000000018150FAD0-0x0000000181510160
		public void __Gen_Wrap_108(object P0, ExternalPluginLogoutParams P1); // 0x0000000181510160-0x00000001815107D0
		public void __Gen_Wrap_109(U8PayResult P0); // 0x00000001815107D0-0x0000000181510D70
		public void __Gen_Wrap_110(object P0, ExternalPluginPayParams P1); // 0x0000000181510D70-0x00000001815113E0
		public bool __Gen_Wrap_111(object P0, object P1, out SDKMeta P2); // 0x00000001815113E0-0x0000000181511F20
		public LoginWorkFlow.ENode __Gen_Wrap_112(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public void __Gen_Wrap_113(ref LoginWorkFlow.FWork P0, int P1); // 0x0000000181511F20-0x0000000181512B10
		public bool __Gen_Wrap_114(object P0, LoginWorkFlow.ENode P1, bool P2); // 0x0000000181512B10-0x0000000181512E20
		public HGDownloader.DownloadProgress __Gen_Wrap_115(object P0); // 0x0000000181512E20-0x0000000181513720
		public HGDownloader.WorkState __Gen_Wrap_116(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public List<HGFileInfo> __Gen_Wrap_117(object P0, object P1); // 0x0000000181513720-0x0000000181514140
		public List<HGFolder> __Gen_Wrap_118(object P0, object P1); // 0x0000000181514140-0x0000000181514B60
		public bool __Gen_Wrap_119(object P0, HGRetCodeType P1, int P2); // 0x000000018129F0D0-0x000000018129F3D0
		public string __Gen_Wrap_120(double P0); // 0x0000000181514B60-0x00000001815153E0
		public void __Gen_Wrap_121(object P0, long P1, object P2, object P3, object P4); // 0x00000001815153E0-0x0000000181515910
		public void __Gen_Wrap_122(object P0, HGDownloader.PauseReason P1); // 0x00000001812A0D50-0x00000001812A1020
		public IEnumerator __Gen_Wrap_123(object P0, long P1); // 0x0000000181515910-0x00000001815162B0
		public void __Gen_Wrap_124(object P0, long P1, long P2, long P3); // 0x00000001815162B0-0x00000001815165C0
		public double __Gen_Wrap_125(object P0); // 0x000000018146E800-0x000000018146EAC0
		public bool __Gen_Wrap_126(bool P0); // 0x0000000181408E40-0x0000000181409040
		public string __Gen_Wrap_127(object P0, bool P1); // 0x00000001815165C0-0x0000000181516F60
		public LocalResPref __Gen_Wrap_128(); // 0x0000000181516F60-0x00000001815177A0
		public LoginHotUpdater.HotUpdateInfo __Gen_Wrap_129(object P0, bool P1); // 0x00000001815177A0-0x0000000181518140
		public ResourceIndex __Gen_Wrap_130(); // 0x0000000181518140-0x0000000181518980
		public string __Gen_Wrap_131(object P0, object P1, bool P2); // 0x0000000181518980-0x00000001815193D0
		public object __Gen_Wrap_132(); // 0x00000001815193D0-0x0000000181519C10
		public IEnumerator __Gen_Wrap_133(object P0, object P1, bool P2, object P3); // 0x0000000181519C10-0x000000018151A730
		public IEnumerator __Gen_Wrap_134(bool P0, object P1, object P2); // 0x000000018151A730-0x000000018151B170
		public LocalResPref __Gen_Wrap_135(object P0, bool P1, object P2, FResourceDiff P3, out int P4); // 0x000000018151B170-0x000000018151BED0
		public void __Gen_Wrap_136(object P0, ref bool P1, double P2, double P3, int P4, bool P5); // 0x000000018151BED0-0x000000018151C240
		public bool __Gen_Wrap_137(object P0, EVFSBlockType P1); // 0x000000018151C240-0x000000018151C530
		public IEnumerator __Gen_Wrap_138(object P0, object P1, bool P2, bool P3); // 0x000000018151C530-0x000000018151CFA0
		public LoginHotUpdater __Gen_Wrap_139(object P0, bool P1); // 0x000000018151CFA0-0x000000018151D900
		public LoginProgress.FDownloadSize.EUnit __Gen_Wrap_140(double P0); // 0x000000018151D900-0x000000018151DB00
		public float __Gen_Wrap_141(double P0, LoginProgress.FDownloadSize.EUnit P1); // 0x000000018151DB00-0x000000018151DD30
		public string __Gen_Wrap_142(float P0, float P1, LoginProgress.FDownloadSize.EUnit P2); // 0x000000018151DD30-0x000000018151E620
		public string __Gen_Wrap_143(float P0, LoginProgress.FDownloadSize.EUnit P1); // 0x000000018151E620-0x000000018151EED0
		public string __Gen_Wrap_144(float P0, float P1); // 0x000000018151EED0-0x000000018151F7A0
		public void __Gen_Wrap_145(ref LoginProgress.FDownloadSize P0, double P1, double P2, double P3); // 0x000000018151F7A0-0x0000000181520470
		public void __Gen_Wrap_146(ref LoginProgress.FDownloadSize P0, double P1, double P2); // 0x0000000181520470-0x0000000181521120
		public void __Gen_Wrap_147(ref LoginProgress.FDownloadSize P0); // 0x0000000181521120-0x0000000181521D30
		public void __Gen_Wrap_148(object P0, GameAppExitCode P1); // 0x000000018133CDE0-0x000000018133D0C0
		public void __Gen_Wrap_149(SpeedTestResult P0); // 0x00000001812A5970-0x00000001812A5C30
		public Task<Hypergryph.SpeedTest.TaskResult> __Gen_Wrap_150(); // 0x0000000181521D30-0x0000000181522570
		public bool __Gen_Wrap_151(ref LoginViewModel.FAgeTipsPolicy P0); // 0x0000000181522570-0x0000000181523140
		public LoginViewModel.FAgeTipsPolicy __Gen_Wrap_152(); // 0x0000000181523140-0x0000000181523950
		public LoginWorkFlow.Node[] __Gen_Wrap_153(object P0); // 0x0000000181523950-0x0000000181524290
		public float __Gen_Wrap_154(object P0, out bool P1); // 0x0000000181524290-0x00000001815245B0
		public TickType __Gen_Wrap_155(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public UIAnimationMixPlayer __Gen_Wrap_156(object P0); // 0x00000001815245B0-0x0000000181524EF0
		public void __Gen_Wrap_157(object P0, LoginSceneAnimCtrl.EState P1); // 0x000000018133CDE0-0x000000018133D0C0
		public List<string> __Gen_Wrap_158(object P0); // 0x0000000181524EF0-0x0000000181525830
		public void __Gen_Wrap_159(object P0, LoginViewModel.FAgeTipsPolicy P1); // 0x0000000181525830-0x0000000181525EC0
		public void __Gen_Wrap_160(object P0, object P1, bool P2, bool P3); // 0x0000000181525EC0-0x00000001815262A0
		public void __Gen_Wrap_161(bool P0, bool P1, bool P2); // 0x00000001815262A0-0x00000001815264D0
		public void __Gen_Wrap_162(object P0, in EventData<bool> P1); // 0x00000001815264D0-0x0000000181526B50
		public LoginMockUIDPanel __Gen_Wrap_163(); // 0x0000000181526B50-0x0000000181527390
		public void __Gen_Wrap_164(object P0, in EventData<float> P1); // 0x0000000181527390-0x0000000181527A20
		public void __Gen_Wrap_165(object P0, object P1, object P2, bool P3); // 0x0000000181527A20-0x0000000181527E90
		public void __Gen_Wrap_166(object P0, int P1, object P2); // 0x00000001812ABC50-0x00000001812ABFE0
		public void __Gen_Wrap_167(object P0, EVFSBlockType P1); // 0x000000018122AC70-0x000000018122AF40
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 56577
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x00000001869B5064-0x00000001869B5110 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x00000001869B5110-0x00000001869B51BC 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x00000001869B51BC-0x00000001869B5298
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x0000000186365FC0-0x000000018636603C
		[IDTag(1)]
		private bool MoveNext(); // 0x0000000186365D60-0x0000000186365DEC
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x0000000186365E98-0x0000000186365F14
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 56578
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x00000001869B5480-0x00000001869B54E4
		public static bool IsPatched(int id); // 0x0000000182F44DE0-0x0000000182F44E30
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x00000001869B533C-0x00000001869B5408
		public object CreateWrapper(int id); // 0x00000001869B5408-0x00000001869B5480
		public object InitWrapperArray(int len); // 0x00000001869B54E4-0x00000001869B58D8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x00000001869B5298-0x00000001869B533C
	}

	public enum IDMAP0 // TypeDefIndex: 56579
	{
		Beyond-GameApp-get_currentState0 = 0,
		Beyond-GameApp-SwitchState0 = 1,
		Beyond-GameApp-Awake0 = 2,
		Beyond-GameApp-_PreInitGameSetting0 = 3,
		Beyond-Scripts-Entry-GameSettingSetter-RegisterSettingCallbacks0 = 4,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioGlobalVolumeChange0 = 5,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioMusicVolumeChange0 = 6,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioVoiceVolumeChange0 = 7,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSfxVolumeChange0 = 8,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuspendUnfocusedChange0 = 9,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioBackgroundMusicChange0 = 10,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuiteModeChange0 = 11,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioControllerChange0 = 12,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSpatialAudioChange0 = 13,
		Beyond-Scripts-Entry-GameSettingSetter-_OnCameraDistanceLevelChange0 = 14,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerMotionChange0 = 15,
		Beyond-Scripts-Entry-GameSettingSetter-_OnKeyboardTypeChange0 = 16,
		Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageTextChange0 = 17,
		Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageAudioChange0 = 18,
		Beyond-Scripts-Entry-GameSettingSetter-_OnVideoQualityChange0 = 19,
		Beyond-Scripts-Entry-GameSettingSetter-_OnVideoFullScreenChange0 = 20,
		Beyond-Scripts-Entry-GameSettingSetter-_SetResolution0 = 21,
		Beyond-Scripts-Entry-GameSettingSetter-_OnVideoResolutionChange0 = 22,
		Beyond-Scripts-Entry-GameSettingSetter-_OnVideoNotchPaddingChange0 = 23,
		Beyond-Scripts-Entry-GameSettingSetter-_OnTeammateSkillEffectStrengthChange0 = 24,
		Beyond-Scripts-Entry-GameSettingSetter-_OnTeammateSkillEffectOpacityChange0 = 25,
		Beyond-GameApp-_NeedDeepProfilerMode0 = 26,
		Beyond-UI-SplashController-Show0 = 27,
		Beyond-RenderPipelineDataLoader-LoadSimpleRpData0 = 28,
		Beyond-UI-SplashController-_Play0 = 30,
		Beyond-UI-SplashController-_GetSplashConfigs0 = 31,
		Beyond-UI-SplashController-_DoStartSplash0 = 32,
		Beyond-UI-SplashController-_OnTweenFinished0 = 37,
		Beyond-UI-SplashController-_OnSplashCompleteCoroutine0 = 38,
		Beyond-SDK-Impl-U8ExternalTools-PublicSetGameVersion0 = 42,
		Beyond-UI-SplashController-_StartLicenseCoroutine0 = 43,
		Beyond-UI-SplashController-Hide0 = 50,
		Beyond-UI-SplashController-_Stop0 = 51,
		Beyond-GameApp-_Init0 = 58,
		Beyond-GameApp-_InitNotificationCenter0 = 59,
		Beyond-GameApp-_InitSecuritySDK0 = 60,
		Beyond-GameApp-_FetchRemoteConfigUtilSuc0 = 64,
		Beyond-GameApp-_InitGameStateMachine0 = 74,
		Beyond-GameApp-_RegisterLuaAfterGCEvent0 = 75,
		Beyond-GameApp-_OnApplicationFocusForLua0 = 76,
		Beyond-GameApp-_OnApplicationPauseForLua0 = 77,
		Beyond-GameApp-_OnSystemDisplaySizeChanged0 = 78,
		Beyond-GameApp-RefreshScreenResolution0 = 79,
		Beyond-GameApp-_OnSystemScreenSizeChanged0 = 80,
		Beyond-GameApp-ScanLocalFiles0 = 81,
		Beyond-GameApp-_CollectSystemInfo0 = 82,
		Beyond-GameApp-LaunchScanCoordinator0 = 83,
		Beyond-GameApp-_ScanParallel0 = 86,
		Beyond-GameApp-_WorkerLoop0 = 87,
		Beyond-GameApp-_ScanDirectory0 = 88,
		Beyond-GameApp-_MakeLongPath0 = 89,
		Beyond-GameApp-_BuildEntry0 = 90,
		Beyond-GameApp-_CanAccess0 = 91,
		Beyond-GameApp-_CalculateMd50 = 92,
		Beyond-GameApp-_WriteTreeReport0 = 93,
		Beyond-GameApp-_PrintTreeNode0 = 94,
		Beyond-GameApp-_TreeNodeCompare0 = 95,
		Beyond-GameApp-_FormatSize0 = 96,
		Beyond-GameApp-_DelayInit0 = 97,
		Beyond-GameApp-get_IsScanRunning0 = 101,
		Beyond-GameApp-Update0 = 105,
		Beyond-GameApp-LateUpdate0 = 106,
		Beyond-GameApp-OnApplicationQuit0 = 107,
		Beyond-GameApp-OnApplicationFocus0 = 108,
		Beyond-GameApp-OnApplicationPause0 = 109,
		Beyond-GameApp-_OnApplicationPauseForSecurity0 = 110,
		Beyond-GameApp-OnDestroy0 = 111,
		Beyond-GameApp-_UnInit0 = 112,
		Beyond-GameApp-_UnInitGameStateMachine0 = 113,
		Beyond-GameApp-QuitGame1 = 114,
		Beyond-GameApp-QuitGame0 = 115,
		Beyond-GameApp-PollScanResult0 = 116,
		Beyond-GameInitState-get_stateId0 = 117,
		Beyond-GameInitState-OnEnter0 = 118,
		Beyond-GameStateBase-OnEnter0 = 119,
		Beyond-GameInitState-_DoInit0 = 120,
		Beyond-GameInitState-_InitInitialResourceManager0 = 124,
		Beyond-GameInitState-_CheckIfLocalInitialAssetsValid0 = 125,
		Beyond-GameInitState-_InitAPPDefaultCulture0 = 126,
		Beyond-RenderPipelineDataLoader-PreloadFullRpResources0 = 127,
		Beyond-VietnamLoginAgePanel-Init0 = 128,
		Beyond-VietnamLoginAgePanel-_Init0 = 129,
		Beyond-VietnamLoginAgePanel-_UnInit0 = 130,
		Beyond-GameInitState-_InitGameSetting0 = 131,
		Beyond-RenderPipelineDataLoader-IsPreLoadFinished0 = 132,
		Beyond-GameInitState-OnLeave0 = 136,
		Beyond-GameStateBase-OnLeave0 = 137,
		Beyond-GameLoginState-get_stateId0 = 138,
		Beyond-GameLoginState-OnEnter0 = 139,
		Beyond-UI-SplashController-CanFinished0 = 140,
		Beyond-RenderPipelineDataLoader-LoadFullRpResources0 = 141,
		Beyond-GameLoginState-_TryStartLoginWorkflow0 = 142,
		Beyond-LoginManager-IsWorkflowInProgress0 = 143,
		Beyond-LoginContext-IsDisposed0 = 144,
		Beyond-LoginManager-InitCoroutine0 = 145,
		Beyond-LoginContext-Dispose0 = 149,
		Beyond-LoginContext-_DisposeImpl0 = 150,
		Beyond-Login-LoginWorkFlow-Dispose0 = 152,
		Beyond-Login-LoginWorkFlow-Node-Dispose0 = 155,
		Beyond-Login-LoginWorkFlow-Node-OnDispose0 = 156,
		Beyond-Login-LoginWorkFlow-_UpdateCursor0 = 157,
		Beyond-Login-LoginWorkFlow-_EnableCursor0 = 158,
		Beyond-Login-LoginWorkFlow-_EnbaleToggleGroup0 = 159,
		Beyond-Login-LoginWorkFlow-Worker-Dispose0 = 160,
		Beyond-LoginManager-AssetLoader-Dispose0 = 164,
		Beyond-LoginContext-_DisposeCoroutine0 = 165,
		Beyond-LoginController-BeforeDestroy0 = 169,
		Beyond-LoginController-get_maskCtrl0 = 173,
		Beyond-LoginController-MaskCtrl-IsCrossSceneMaskTweening0 = 174,
		Beyond-LoginController-MaskCtrl-_GetMaskByType0 = 175,
		Beyond-LoginController-MaskCtrl-WaitForCrossSceneMasks0 = 176,
		Beyond-LoginController-MaskCtrl-Dispose0 = 183,
		Beyond-LoginContext-IsWorkflowDisposed0 = 190,
		Beyond-LoginManager-_Init0 = 192,
		Beyond-LoginManager-_LoginWorkFlowCoroutine0 = 195,
		Beyond-LoginController-InitUI0 = 199,
		Beyond-LoginController-MaskCtrl-EnableMask0 = 200,
		Beyond-LoginController-_InitImpl0 = 201,
		Beyond-LoginController-_InitCoroutine0 = 202,
		Beyond-Login-LoginRootPanel-Init0 = 206,
		Beyond-Login-LoginRootPanel-_InitController0 = 208,
		Beyond-Login-LoginRootPanel-_InitChildPanel0 = 209,
		Beyond-Login-LoginRootPanel-ChildPanel-OnLoginContext0 = 210,
		Beyond-Login-LoginRootPanel-ChildPanel-OnInit0 = 212,
		Beyond-Login-LoginDecorateUI-OnLoginContext0 = 214,
		Beyond-Login-LoginDecorateUI-_ToggleGlow0 = 215,
		Beyond-Login-LoginDecorateUI-_EnsureGlowPlayer0 = 216,
		Beyond-LoginController-_InitVersionBtn0 = 217,
		Beyond-Login-LoginWorkFlow-DoWorkFlow0 = 221,
		Beyond-Login-LoginWorkFlow-FWork-Start0 = 226,
		Beyond-Login-LoginWorkFlow-FWork-get_curNode0 = 230,
		Beyond-Login-LoginWorkFlow-_CheckIfGameStateNotMatch0 = 232,
		Beyond-Login-LoginWorkFlow-IsBeforeWork0 = 233,
		Beyond-Login-LoginWorkFlow-IsOnOrAfterWork0 = 234,
		Beyond-Login-LoginWorkFlow-_AdjustCurrentGameState0 = 235,
		Beyond-Login-LoginWorkFlow-Worker-SetCurNode0 = 242,
		Beyond-Login-LoginWorkFlow-Worker-Work0 = 245,
		Beyond-Login-LoginWorkFlow-Worker-_InternalTick0 = 251,
		Beyond-Login-LoginWorkFlow-Node-Cancel0 = 253,
		Beyond-Login-LoginHotUpdater-IsNeedSoftRestart0 = 257,
		Beyond-Login-LoginWorkFlow-Worker-TickInEmptyFrame0 = 258,
		Beyond-Login-LoginWorkFlow-FWork-ConsumeFallback0 = 259,
		Beyond-Login-LoginWorkFlow-FWork-MoveNextIndex0 = 261,
		Beyond-Login-LoginWorkFlow-FWork-WorkEnd0 = 262,
		Beyond-LoginManager-_PrepareBeforeLoginProcess0 = 269,
		Beyond-LoginManager-AlertDialog0 = 271,
		Beyond-Login-LoginAlertDialog-SetParams0 = 275,
		Beyond-Login-LoginVocResSelDialog-SetParams0 = 277,
		Beyond-Login-LoginJudgeDialog-SetParams0 = 279,
		Beyond-LoginContext-StartCoroutine0 = 280,
		Beyond-LoginContext-Init0 = 282,
		Beyond-LoginController-InvokeWhenStart0 = 289,
		Beyond-GameLoginState-OnLeave0 = 293,
		Beyond-GameMainState-get_stateId0 = 294,
		Beyond-GameMainState-OnEnter0 = 295,
		Beyond-LoginManager-Clear0 = 296,
		Beyond-LoginManager-_ClearWorkflowAndContext0 = 297,
		Beyond-LoginContext-ShutDown0 = 298,
		Beyond-LoginManager-_ReleaseLoginScene0 = 299,
		Beyond-GameMainState-OnLeave0 = 300,
		Beyond-GameMainState-ReleaseMainGame0 = 301,
		Beyond-LoginManager-OnReleaseMainGame0 = 302,
		Beyond-LoginManager-IsReLoginInProgress0 = 303,
		Beyond-Login-LoginWorkFlow-IsAfterWork0 = 304,
		Beyond-Login-LoginWorkFlow-PeekFallbackStatus0 = 305,
		Beyond-GameMainState-_ClearUtils0 = 306,
		Beyond-GamePreloadState-get_stateId0 = 307,
		Beyond-GamePreloadState-OnEnter0 = 308,
		Beyond-GamePreloadState-_DoPreload0 = 309,
		Beyond-GamePreloadState-_InitGameSettingStateInPreload0 = 313,
		Beyond-GamePreloadState-OnLeave0 = 317,
		Beyond-GameQuitState-get_stateId0 = 318,
		Beyond-GameQuitState-OnEnter0 = 319,
		Beyond-GameQuitState-DoQuit0 = 320,
		Beyond-VietnamLoginAgePanel-UnInit0 = 321,
		Beyond-GameQuitState-OnLeave0 = 322,
		Beyond-GameSoftRestartState-get_stateId0 = 323,
		Beyond-GameSoftRestartState-OnEnter0 = 324,
		Beyond-GameSoftRestartState-_SoftRestart0 = 325,
		Beyond-LoginManager-ClearSync0 = 329,
		Beyond-Login-LoginWorkFlow-ClearEnteredPreloadThisSession0 = 330,
		Beyond-GameStartState-get_stateId0 = 334,
		Beyond-GameStartState-OnEnter0 = 335,
		Beyond-GameStartState-_OnEnterMainGame0 = 336,
		Beyond-LoginManager-InvokeWhenWorkFlowFinished0 = 338,
		Beyond-GameStartState-OnLeave0 = 339,
		Beyond-GameStateBase-OnTick0 = 340,
		Beyond-GameStateMachine-get_curState0 = 341,
		Beyond-GameStateMachine-_RegisterStates0 = 342,
		Beyond-GameStateMachine-CheckCanReturnToLoginState0 = 343,
		Beyond-GameStateMachine-ReturnToLoginState0 = 344,
		Beyond-GlobalInitializer-InitGlobalConfig0 = 351,
		Beyond-LoginController-get_rootPanel0 = 352,
		Beyond-LoginController-Awake0 = 353,
		Beyond-LoginController-Start0 = 354,
		Beyond-LoginController-GetEnterGamePanelPredelay0 = 355,
		Beyond-LoginController-OnValueChanged0 = 356,
		Beyond-Login-LoginWorkFlow-SendEvent0 = 357,
		Beyond-Login-LoginWorkFlow-_HandleGlobalEvent0 = 358,
		Beyond-Login-LoginWorkFlow-_EventOnOpenAgeTips0 = 359,
		Beyond-Login-LoginAgeTipsModel-IsContentEmpty0 = 361,
		Beyond-Login-LoginWorkFlow-_FetchAgeTipsCoroutine0 = 362,
		Beyond-LoginContext-ViewOnlyController0 = 366,
		Beyond-LoginController-MaskCtrl-EnableNetMask0 = 367,
		Beyond-LoginController-MaskCtrl-DisableNetMask0 = 368,
		Beyond-Login-LoginRootPanel-ToggleLoginBindingGroup0 = 372,
		Beyond-Login-LoginWorkFlow-_EventOnCloseAgeTips0 = 373,
		Beyond-Login-LoginWorkFlow-_EventOnOpenServerSelect0 = 374,
		Beyond-Login-LoginWorkFlow-_EventOnSelectServer0 = 377,
		Beyond-Login-LoginServerSelectModel-UpdateSelectedServer0 = 378,
		Beyond-Login-LoginServerSelectModel-get_serverList0 = 379,
		Beyond-Login-LoginWorkFlow-_EventOnConfirmServer0 = 380,
		Beyond-Login-LoginServerSelectModel-GetSelectedServer0 = 381,
		Beyond-Login-LoginWorkFlow-Node-OnEvent0 = 382,
		Beyond-LoginController-MockLoginWithCallback0 = 383,
		Beyond-LoginController-_MockLoginCoroutine0 = 386,
		Beyond-Login-LoginMockUIDPanel-LoginWithCallback0 = 392,
		Beyond-Login-LoginMockUIDPanel-_UpdateStatus0 = 393,
		Beyond-Login-LoginMockUIDPanel-_OnBtnEnterGame0 = 395,
		Beyond-Login-LoginMockUIDPanel-_SaveConfig0 = 396,
		Beyond-Login-LoginMockUIDPanel-_OnBtnDelLocalFile0 = 398,
		Beyond-Login-LoginMockUIDPanel-_TryClosePanel0 = 400,
		Beyond-Login-LoginMockUIDPanel-FOptions-IsUIDFixed0 = 401,
		Beyond-Login-LoginMockUIDPanel-_InitLoginInfo0 = 402,
		Beyond-Login-LoginMockUIDPanel-_MovePreferredServerToFront0 = 403,
		Beyond-Login-LoginMockUIDPanel-_IndexOfServer0 = 404,
		Beyond-Login-LoginMockUIDPanel-_OnSelectServer0 = 406,
		Beyond-Login-LoginMockUIDPanel-_SaveLastSelectedServer0 = 407,
		Beyond-Login-LoginMockUIDPanel-HideAndDestroy0 = 408,
		Beyond-LoginController-Dialog-_CloseCoroutine0 = 419,
		Beyond-LoginController-Dialog-TryCloseWithCallback0 = 426,
		Beyond-LoginController-Dialog-Show0 = 427,
		Beyond-LoginController-Dialog-OnInit0 = 428,
		Beyond-LoginController-MaskCfg-CreateTweenAndHide0 = 429,
		Beyond-LoginController-MaskCtrl-IsMaskTweening0 = 430,
		Beyond-LoginContext-StopCoroutine0 = 431,
		Beyond-LoginContext-SendEvent0 = 432,
		Beyond-LoginManager-get_firstLogin0 = 433,
		Beyond-LoginManager-SceneComponentOnly_Bind0 = 435,
		Beyond-LoginManager-_BindPendingComponents0 = 436,
		Beyond-Login-LoginSceneComponent-Bind0 = 437,
		Beyond-Login-LoginSceneComponent-OnBindToManager0 = 440,
		Beyond-LoginManager-ToggleLoginBindingGroup0 = 441,
		Beyond-LoginManager-VocResSelDialog0 = 442,
		Beyond-LoginManager-VocResSelDialogWithConfirm0 = 443,
		Beyond-LoginManager-AlertDialogWithResult0 = 452,
		Beyond-LoginManager-AlertDialogWithConfirm0 = 461,
		Beyond-LoginManager-JudgeDialog0 = 470,
		Beyond-LoginManager-_StartShowJudgeDialogCoroutine0 = 471,
		Beyond-LoginManager-JudgeDialog1 = 472,
		Beyond-LoginManager-MockLoginWithCallback0 = 473,
		Beyond-LoginManager-MockManualSelectServer0 = 474,
		Beyond-LoginManager-IsLoginSceneLoading0 = 477,
		Beyond-LoginManager-FetchRemoteConfigUtilSuc0 = 478,
		Beyond-LoginManager-_ExtractErrorInfo0 = 482,
		Beyond-LoginManager-DevOnlyCheckEnableLocalResMode0 = 486,
		Beyond-LoginManager-DevOnlyUseLocalResVersion0 = 487,
		Beyond-LoginManager-AssetLoader-_CheckDisposedBeforeLoad0 = 488,
		Beyond-LoginManager-FlowWithMaskMgr-StartFlow0 = 489,
		Beyond-LoginManager-FlowWithMaskMgr-_FlowCoroutine0 = 490,
		Beyond-LoginManager-FlowWithMaskMgr-_OnFlowFinished0 = 494,
		Beyond-LoginManager-FFlowCondition-IsTargetMatch0 = 495,
		Beyond-VietnamLoginAgePanel-OnApplicationQuit0 = 501,
		Beyond-VietnamLoginAgeTipsPanelCtrl-Awake0 = 502,
		Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateTips0 = 503,
		Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateCircle0 = 504,
		Beyond-TailGameLoop-Update0 = 505,
		Beyond-TailGameLoop-LateUpdate0 = 506,
		Beyond-UI-SplashController-get_isPlaying0 = 507,
		Beyond-UI-SplashController-Awake0 = 508,
		Beyond-UI-SplashController-OnDestroy0 = 509,
		Beyond-SDK-PlatformFont-GetFont0 = 510,
		Beyond-SDK-SDKNetUtils-HTTPPost0 = 511,
		Beyond-SDK-SDKNetUtils-HTTPGet0 = 512,
		Beyond-SDK-SDKNetUtils-BeyondHttp-DoHTTP0 = 513,
		Beyond-SDK-Impl-U8ExternalTools-IsInited0 = 520,
		Beyond-SDK-Impl-U8ExternalTools-NeedRetryInit0 = 521,
		Beyond-SDK-Impl-U8ExternalTools-NeedQuitGame0 = 522,
		Beyond-SDK-Impl-U8ExternalTools-RetryInitSDKSystem0 = 523,
		Beyond-SDK-Impl-U8ExternalTools-InitSDKSystem0 = 524,
		Beyond-SDK-Impl-U8ExternalTools-_OnRequestExitGame0 = 525,
		Beyond-SDK-Impl-U8ExternalTools-WaitForInited0 = 531,
		Beyond-SDK-Impl-U8ExternalTools-InitHGSDK0 = 538,
		Beyond-SDK-Impl-U8ExternalTools-IsHGSDKInited0 = 539,
		Beyond-SDK-Impl-U8ExternalTools-WaitForInitHGSDK0 = 540,
		Beyond-SDK-Impl-U8ExternalTools-Log0 = 547,
		Beyond-SDK-Impl-U8ExternalTools-LogError0 = 548,
		Beyond-SDK-Impl-U8ExternalTools-LogWarning0 = 549,
		Beyond-SDK-Impl-U8ExternalTools-GetSignKey0 = 550,
		Beyond-SDK-Impl-U8ExternalTools-GetDeviceIDs0 = 551,
		Beyond-SDK-Impl-U8ExternalTools-SetSubChannel0 = 552,
		Beyond-SDK-Impl-U8ExternalTools-GetPlatformKey0 = 553,
		Beyond-SDK-Impl-U8ExternalTools-OnSDKExtraInfo0 = 554,
		Beyond-SDK-Impl-U8ExternalTools-_ProcessExtraInfo0 = 555,
		Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-OnGT3Message0 = 556,
		Beyond-SDK-Impl-U8ExternalTools-_ProcessGameProtocolUpdateCheck0 = 557,
		Beyond-SDK-Impl-U8ExternalTools-_TryGetGameProtocolUpdateCheckErrorCode0 = 558,
		Beyond-SDK-Impl-U8ExternalTools-U8RootUrl0 = 559,
		Beyond-SDK-Impl-U8ExternalTools-POSTImplementation0 = 560,
		Beyond-SDK-Impl-U8ExternalTools-_ConvertToPOSTResult0 = 563,
		Beyond-SDK-Impl-U8ExternalTools-_OnFakeAccountCenter0 = 564,
		Beyond-SDK-Impl-U8ExternalTools-CreateCaptchaHandler0 = 565,
		Beyond-SDK-Impl-U8ExternalTools-GetErrorMessage0 = 566,
		Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_GET_TOKEN0 = 567,
		Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_CREATE_ORDER0 = 568,
		Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-FetchCaptchaCoroutine0 = 569,
		Beyond-SDK-Impl-U8Plugin-GetPayAddition0 = 576,
		Beyond-SDK-Impl-U8Plugin-GetSDKToken0 = 577,
		Beyond-SDK-Impl-U8Plugin-GetSDKUid0 = 578,
		Beyond-SDK-Impl-U8Plugin-Init0 = 579,
		Beyond-SDK-Impl-U8Plugin-Login0 = 580,
		Beyond-SDK-Impl-U8Plugin-_UseMockVersion0 = 581,
		Beyond-SDK-Impl-U8Plugin-_MockLogin0 = 582,
		Beyond-SDK-Impl-U8Plugin-Logout0 = 585,
		Beyond-SDK-Impl-U8Plugin-OnProductListChanged0 = 586,
		Beyond-SDK-Impl-U8Plugin-Pay0 = 587,
		Beyond-SDK-Impl-U8Plugin-TryLoadSDKMeta0 = 591,
		Beyond-Login-LoginCheckForUpdateNode-get_type0 = 592,
		Beyond-Login-LoginCheckForUpdateNode-Work0 = 593,
		Beyond-Login-LoginGameUpdater-Clear0 = 596,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutine0 = 597,
		Beyond-Login-LoginCheckForUpdateNode-_AlertAndQuitForExtraConfigFatalError0 = 601,
		Beyond-Login-LoginCheckForUpdateNode-AlertNoMatchDeviceBeforeLogin0 = 608,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutinePC0 = 615,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdatePC0 = 619,
		Beyond-Login-LoginCheckForUpdateNode-_GetOnlineAppVersion0 = 623,
		Beyond-Login-LoginCheckForUpdateNode-_GetRequestPram0 = 627,
		Beyond-Login-LoginGameUpdater-ShowWaitProgress0 = 631,
		Beyond-Login-LoginGameUpdater-GetWaitTime0 = 632,
		Beyond-Login-LoginGameUpdater-ClearWaitProgress0 = 639,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutineMobile0 = 643,
		Beyond-Login-LoginGameUpdater-CheckLastGameInfo0 = 647,
		Beyond-Login-LoginGameUpdater-_GetLastGameInfo0 = 651,
		Beyond-Login-LoginGameUpdater-_CreateDirectoryIfNotExists0 = 655,
		Beyond-Login-LoginGameUpdater-Context-CompleteWithCode0 = 656,
		Beyond-Login-LoginGameUpdater-Context-UncompleteWithCode0 = 659,
		Beyond-Login-LoginGameUpdater-GetNoAlertCode0 = 660,
		Beyond-Login-LoginWorkFlow-Fallback0 = 670,
		Beyond-Login-LoginWorkFlow-FWork-MarkFallback0 = 671,
		Beyond-Login-LoginCreateRoleNode-get_type0 = 675,
		Beyond-Login-LoginCreateRoleNode-OnDispose0 = 676,
		Beyond-Login-LoginCreateRoleNode-WorkProcess-Dispose0 = 677,
		Beyond-Login-LoginCreateRoleNode-CanCancel0 = 678,
		Beyond-Login-LoginCreateRoleNode-Work0 = 679,
		Beyond-Login-LoginCreateRoleNode-WorkProcess-get_keepWaiting0 = 680,
		Beyond-Login-LoginDownloadTask-GetDownloadProgress0 = 681,
		Beyond-Login-LoginDownloadTask-GetDecompressProgress0 = 682,
		Beyond-Login-LoginDownloadTask-GetWorkState0 = 683,
		Beyond-Login-LoginDownloadTask-Tick0 = 684,
		Beyond-Login-LoginDownloadTask-Dispose0 = 685,
		Beyond-Login-LoginDownloadTask-_StartDownload0 = 686,
		Beyond-Login-LoginDownloadTask-_GetFileList0 = 687,
		Beyond-Login-LoginDownloadTask-_StartDownloadImpl0 = 688,
		Beyond-Login-LoginDownloadTask-_GetAllFileList0 = 689,
		Beyond-Login-LoginWorkFlow-HasEnteredPreloadThisSession0 = 690,
		Beyond-Login-NetUsagePolicy-AllowMobileDataInLastCheck0 = 691,
		Beyond-Login-LoginDownloadTask-_OnDownloadFinish0 = 692,
		Beyond-Login-LoginDownloadTask-_OnDownloadError0 = 693,
		Beyond-Login-LoginDownloadTask-_OnDownloadPaused0 = 695,
		Beyond-Login-NetUsagePolicy-CheckIfAllowDownload0 = 701,
		Beyond-Login-NetUsagePolicy-_GetPrettySizeStringUpToMB0 = 705,
		Beyond-Login-LoginGameSettingInitializer-Awake0 = 706,
		Beyond-Login-LoginGameSettingInitializer-_TryInitializeComponents0 = 707,
		Beyond-Login-LoginGameSettingInitializer-OnEnable0 = 708,
		Beyond-Login-LoginGameSettingInitializer-_InitGameSettingStateInLogin0 = 709,
		Beyond-Login-LoginGameSettingInitializer-_InitGameSettingNotchPadding0 = 710,
		Beyond-Login-LoginGameUpdateNode-get_type0 = 711,
		Beyond-Login-LoginGameUpdateNode-Work0 = 712,
		Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutine0 = 714,
		Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutineMobileImpl0 = 721,
		Beyond-Login-LoginGameUpdater-DoUpdate0 = 725,
		Beyond-Login-LoginGameUpdater-_UpdateGame0 = 729,
		Beyond-Login-LoginGameUpdater-_YieldCheckNetUsagePolicy0 = 733,
		Beyond-Login-LoginGameUpdater-_YieldErrorAlert0 = 745,
		Beyond-Login-LoginGameUpdater-_DoTaskUpdating0 = 754,
		Beyond-Login-LoginGameUpdater-_OnDownloadStart0 = 758,
		Beyond-Login-LoginGameUpdater-_OnDownloadProgress0 = 759,
		Beyond-Login-LoginGameUpdater-_WaitForTaskCancel0 = 766,
		Beyond-Login-LoginGSNode-get_type0 = 779,
		Beyond-Login-LoginGSNode-Work0 = 780,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-EnterGame0 = 781,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_EnterGameCoroutine0 = 782,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_OnAuthError0 = 787,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ReLoginWhenErrorEncountered0 = 791,
		Beyond-Login-LoginGSNode-_FallbackToInitWithMask0 = 792,
		Beyond-Login-LoginGSNode-_FallbackToInitNodeImpl0 = 794,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-TryInterrupt0 = 795,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-IsInterruptable0 = 796,
		Beyond-Login-LoginGSNode-_LogoutToInitNode0 = 797,
		Beyond-Login-LoginGSNode-_ConfirmServer0 = 801,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_NetConnectAndGSLogin0 = 808,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_SaveCurrentUserToServerConfig0 = 812,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_MockManualSelectServer0 = 816,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_GlobalLoginSucBusiness0 = 831,
		Beyond-Login-LoginGSNode-OnEvent0 = 836,
		Beyond-Login-LoginGSNode-_OnEventLogout0 = 837,
		Beyond-Login-LoginGSNode-_OnEventResourceRepair0 = 839,
		Beyond-Login-LoginGSNode-_FallbackToResRepairImpl0 = 841,
		Beyond-Login-LoginViewModel-RequestResourceRepair0 = 842,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-get_keepWaiting0 = 845,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-MarkAborting0 = 846,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ExtractErrorInfo0 = 847,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_YieldAlertError0 = 848,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetCurrent0 = 855,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetTotal0 = 856,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetInfo0 = 857,
		Beyond-Login-LoginHotUpdater-MarkInitialAssetChanged0 = 858,
		Beyond-Login-LoginHotUpdater-CheckInitialAssetChanged0 = 859,
		Beyond-Login-LoginHotUpdater-MarkNeedClearFolder0 = 860,
		Beyond-Login-LoginHotUpdater-NeedClearFolder0 = 861,
		Beyond-Login-LoginHotUpdater-MarkClearSuccessed0 = 862,
		Beyond-Login-LoginHotUpdater-MarkSoftRestart0 = 863,
		Beyond-Login-LoginHotUpdater-ClearSoftRestartFlag0 = 864,
		Beyond-Login-LoginHotUpdater-get_keepWaiting0 = 865,
		Beyond-Login-LoginHotUpdater-Dispose0 = 866,
		Beyond-Login-LoginLocalResTask-Dispose0 = 867,
		Beyond-Login-LoginHotUpdater-StartHotUpdate0 = 868,
		Beyond-Login-LoginHotUpdater-_Work0 = 869,
		Beyond-Login-LoginHotUpdater-_UpdateResVersion0 = 873,
		Beyond-Login-LoginHotUpdater-_UpdateResVersionDev0 = 877,
		Beyond-Login-LoginHotUpdater-_UpdateResVersionProd0 = 884,
		Beyond-Login-LoginHotUpdater-_SetResVersionForLog0 = 894,
		Beyond-Login-LoginHotUpdater-_CreateMainCoroutine0 = 895,
		Beyond-Login-LoginHotUpdater-_CurrentWorkMode0 = 899,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeDownload0 = 900,
		Beyond-Login-LoginHotUpdater-_GetOnlineResVersion0 = 906,
		Beyond-Login-LoginHotUpdater-WorkContext-GetHotUpdateInfo0 = 907,
		Beyond-Login-LoginHotUpdater-_CheckAndDownloadResource0 = 908,
		Beyond-Login-LoginHotUpdater-_GenResIndex0 = 912,
		Beyond-Login-LoginHotUpdater-_LoadOrDownloadResIndex0 = 916,
		Beyond-Login-LoginHotUpdater-_ResourceIndexUrl0 = 923,
		Beyond-Login-LoginHotUpdater-ResourceRootUrl0 = 924,
		Beyond-Login-LoginHotUpdater-_GenRiff0 = 931,
		Beyond-Login-LoginHotUpdater-_ResourcePatchUrl0 = 935,
		Beyond-Login-LoginHotUpdater-_ResourceFileUrl0 = 936,
		Beyond-Login-LoginHotUpdater-_LoadStreamingIndex0 = 937,
		Beyond-Login-LoginHotUpdater-_DownloadPatchInfo0 = 949,
		Beyond-Login-LoginHotUpdater-_ResourcePatchRootUrl0 = 953,
		Beyond-Login-LoginHotUpdater-_CreateUpdatedLocalResPref0 = 957,
		Beyond-Login-LoginHotUpdater-_StartDownloadingShaderWarmupIfNeeded0 = 959,
		Beyond-Login-LoginHotUpdater-_EventLogDownloadProgress0 = 960,
		Beyond-Login-LoginHotUpdater-_GenLocalRef0 = 961,
		Beyond-Login-LoginHotUpdater-WriteLocalResPrefToFile0 = 965,
		Beyond-Login-LoginHotUpdater-_StopDownloadingShaderWarmupIfNeeded0 = 972,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-CheckIfNeedReload0 = 973,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasChangedByType0 = 974,
		Beyond-Login-LoginHotUpdater-_CheckLocalResConsistency0 = 975,
		Beyond-Login-LoginHotUpdater-WorkContext-MarkIllegalItemsInLocalRes0 = 979,
		Beyond-Login-LoginHotUpdater-_ClearDownloadFolder0 = 988,
		Beyond-Login-LoginHotUpdater-_ReloadResourceIndexes0 = 995,
		Beyond-Login-LoginHotUpdater-WorkContext-HasChangedByType0 = 999,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeLocal0 = 1006,
		Beyond-Login-LoginLocalResTask-Work0 = 1010,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeSkip0 = 1023,
		Beyond-Login-LoginHotUpdater-_VitalError0 = 1033,
		Beyond-Login-LoginViewModel-RequestSkipU8Login0 = 1037,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasAssetsChanged0 = 1046,
		Beyond-Login-LoginProgress-GetCurrent0 = 1047,
		Beyond-Login-LoginProgress-GetTotal0 = 1048,
		Beyond-Login-LoginProgress-GetInfo0 = 1049,
		Beyond-Login-LoginProgress-FDownloadSize-SetSize0 = 1050,
		Beyond-Login-LoginProgress-FDownloadSize-_PickUnit0 = 1051,
		Beyond-Login-LoginProgress-FDownloadSize-_DisplayWithUnit0 = 1052,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatDisplayInfo0 = 1053,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatSpeedInfo0 = 1054,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatProgressInfo0 = 1055,
		Beyond-Login-LoginProgress-FDownloadSize-SetProgress0 = 1056,
		Beyond-Login-LoginProgress-FDownloadSize-SetIdle0 = 1057,
		Beyond-Login-LoginInitNode-get_type0 = 1058,
		Beyond-Login-LoginInitNode-Work0 = 1059,
		Beyond-Login-LoginInitNode-_InitCoroutine0 = 1060,
		Beyond-Login-LoginInitNode-_InitRemoteConfigs0 = 1064,
		Beyond-Login-LoginInitNode-_YieldAlertError0 = 1068,
		Beyond-Login-PreloadNode-get_type0 = 1081,
		Beyond-Login-PreloadNode-Work0 = 1082,
		Beyond-Login-LoginWorkFlow-MarkEnteredPreloadThisSession0 = 1083,
		Beyond-Login-PreloadNode-_ShowPreloadResourcePanel0 = 1084,
		Beyond-Login-PreloadNode-_LoginPreLoad0 = 1085,
		Beyond-Login-PreloadNode-_QuitGame0 = 1089,
		Beyond-Login-PreloadNode-_WarmUp0 = 1090,
		Beyond-Login-PreloadNode-_GetServerList0 = 1097,
		Beyond-Login-PreloadNode-_GetServerListInfoMock0 = 1101,
		Beyond-Login-PreloadNode-_OnGetServerListSuc0 = 1105,
		Beyond-Login-PreloadNode-_GetServerListInfo0 = 1112,
		Beyond-Login-PreloadNode-_OnGetServerListFail0 = 1116,
		Beyond-Login-PreloadNode-_EnterPreLoad0 = 1123,
		Beyond-Login-LoginSDKInitNode-get_type0 = 1130,
		Beyond-Login-LoginSDKInitNode-Work0 = 1131,
		Beyond-Login-LoginSDKInitNode-_SDKInitCoroutine0 = 1132,
		Beyond-Login-LoginSDKInitNode-_WaitForSDKInited0 = 1136,
		Beyond-Login-LoginSDKInitNode-_InitSubSDKs0 = 1143,
		Beyond-Login-U8LoginNode-get_type0 = 1153,
		Beyond-Login-U8LoginNode-Work0 = 1154,
		Beyond-Login-U8LoginNode-_LoginCoroutine0 = 1155,
		Beyond-Login-U8LoginNode-_ClearLoginCaches0 = 1159,
		Beyond-Login-U8LoginNode-_ClearGameProtocolUpdateCheckEvents0 = 1160,
		Beyond-Login-U8LoginNode-_OnGameProtocolUpdateCheckSucceeded0 = 1161,
		Beyond-Login-U8LoginNode-_OnLoginSuc0 = 1162,
		Beyond-Login-U8LoginNode-_OnSDKViewDisabled0 = 1163,
		Beyond-Login-U8LoginNode-_EnableBlurMask0 = 1164,
		Beyond-Login-LoginRootPanel-InitBulletinAndRedAfterLoginSuc0 = 1165,
		Beyond-Login-LoginMenuPanel-InitBulletinAndRedAfterLoginSuc0 = 1166,
		Beyond-Login-LoginMenuPanel-_UpdateAnnounceRedDot0 = 1167,
		Beyond-Login-LoginMenuPanel-_OnReceiveRedDotAndPopup0 = 1168,
		Beyond-Login-LoginMenuPanel-_OnBulletinOpen0 = 1169,
		Beyond-Login-LoginMenuPanel-_OnBulletinClose0 = 1170,
		Beyond-Login-U8LoginNode-_OnGameProtocolUpdateCheckFailed0 = 1171,
		Beyond-Login-U8LoginNode-_OnLoginFail0 = 1172,
		Beyond-Login-U8LoginNode-_OnLoginCanceled0 = 1173,
		Beyond-Login-U8LoginNode-_StartSDKLogin0 = 1174,
		Beyond-Login-U8LoginNode-_SetCursorOnLoginStart0 = 1175,
		Beyond-Login-U8LoginNode-_SetCursorOnLoginFinish0 = 1177,
		Beyond-Login-U8LoginNode-_StartGameProtocolUpdateCheck0 = 1178,
		Beyond-Login-U8LoginNode-_SkipSDKLogin0 = 1180,
		Beyond-Login-U8LoginNode-_FinishLogin0 = 1181,
		Beyond-Login-U8LoginNode-OnEvent0 = 1191,
		Beyond-Login-LoginViewModel-IsAgeTipsVisible0 = 1192,
		Beyond-Login-LoginViewModel-FAgeTipsPolicy-get_display0 = 1193,
		Beyond-Login-LoginViewModel-IsGovTipsVisible0 = 1194,
		Beyond-Login-LoginViewModel-IsMenuVisible0 = 1195,
		Beyond-Login-LoginViewModel-_LoadAgeTipsPolicy0 = 1196,
		Beyond-Login-LoginAgeTipsModel-CanDisplay0 = 1197,
		Beyond-Login-LoginAgeTipsProp-ClearContentCache0 = 1198,
		Beyond-Login-LoginAgeTipsProp-UpdateContent0 = 1199,
		Beyond-Login-LoginWorkFlow-_RegisterNodes0 = 1200,
		Beyond-Login-LoginWorkFlow-CancelAndFallback0 = 1201,
		Beyond-Login-LoginWorkFlow-Worker-Cancel0 = 1202,
		Beyond-Login-LoginWorkFlow-Node-CanCancel0 = 1203,
		Beyond-Login-LoginWorkFlow-AddEventReceiver0 = 1204,
		Beyond-Login-LoginWorkFlow-UpdateOnce0 = 1205,
		Beyond-Login-LoginWorkFlow-Worker-UpdateOnce0 = 1206,
		Beyond-Login-LoginWorkFlow-Node-Init0 = 1207,
		Beyond-Login-LoginWorkFlow-Node-OnInit0 = 1210,
		Beyond-Login-HotUpdateNode-get_type0 = 1211,
		Beyond-Login-HotUpdateNode-Work0 = 1212,
		Beyond-Login-HotUpdateNode-OnDispose0 = 1213,
		Beyond-Login-WaitForSecondsNode-Work0 = 1214,
		Beyond-Login-WaitForSecondsNode-_NotifyTimeout0 = 1215,
		Beyond-Login-WaitForSecondsNode-_IsTimeout0 = 1216,
		Beyond-Login-WaitForSecondsNode-_DisposeTimer0 = 1217,
		Beyond-Login-WaitForSecondsNode-OnDispose0 = 1218,
		Beyond-Login-PreloadPostDelayNode-get_type0 = 1219,
		Beyond-Login-PreloadPostDelayNode-WaitForSeconds0 = 1220,
		Beyond-Login-PreloadPostDelayNode-Work0 = 1221,
		Beyond-Login-PreloadPostDelayNode-_DisableLoadingPanel0 = 1222,
		Beyond-Login-Trans2GsLoginNode-get_type0 = 1223,
		Beyond-Login-Trans2GsLoginNode-WaitForSeconds0 = 1224,
		Beyond-Login-Trans2GsLoginNode-Work0 = 1225,
		Beyond-Login-FinishNode-get_type0 = 1226,
		Beyond-Login-FinishNode-Work0 = 1227,
		Beyond-Login-LoginSceneAnimCtrl-get_tickOption0 = 1228,
		Beyond-Login-LoginSceneAnimCtrl-OnBindToManager0 = 1229,
		Beyond-Login-LoginSceneAnimCtrl-_EnsurePlayer0 = 1231,
		Beyond-Login-LoginSceneAnimCtrl-_ChangeToState0 = 1232,
		Beyond-Login-LoginSceneAnimCtrl-_ResetToA10 = 1233,
		Beyond-Login-LoginSceneAnimCtrl-_RandomIntervalA1s0 = 1234,
		Beyond-Login-LoginSceneAnimCtrl-_TransitionToA20 = 1235,
		Beyond-Login-LoginSceneAnimCtrl-_PlayA1A2Impl0 = 1236,
		Beyond-Login-LoginSceneAnimCtrl-_PlayA1sAndTriggerNext0 = 1237,
		Beyond-Login-LoginSceneAnimCtrl-OnValueChanged0 = 1238,
		Beyond-Login-LoginSceneAnimCtrl-Start0 = 1239,
		Beyond-Login-LoginSceneComponent-Start0 = 1240,
		Beyond-Login-LoginSceneAnimCtrl-Tick0 = 1241,
		Beyond-Login-LoginSceneAnimCtrl-OnRelease0 = 1242,
		Beyond-Login-LoginSceneAnimCtrl-GetAnimationClips0 = 1243,
		Beyond-Login-LoginSceneComponent-get_tickOption0 = 1244,
		Beyond-Login-LoginSceneRoot-get_tickOption0 = 1245,
		Beyond-Login-LoginSceneRoot-OnBindToManager0 = 1246,
		Beyond-Login-LoginAgeTipsDetailPanel-Init0 = 1247,
		Beyond-Login-LoginAgeTipsDetailPanel-_EventOnCloseClicked0 = 1248,
		Beyond-Login-LoginAgeTipsDetailPanel-OnValueChanged0 = 1249,
		Beyond-Login-LoginAgeTipsDetailPanel-_RenderContent0 = 1250,
		Beyond-Login-LoginAgeTipsDetailPanel-_SplitLicenseToSegments0 = 1251,
		Beyond-Login-LoginAgeTipsDetailPanel-_SplitLongString0 = 1252,
		Beyond-Login-LoginAgeTipsDetailPanel-_ShowContent0 = 1253,
		Beyond-Login-LoginAgeTipsPanel-OnInit0 = 1254,
		Beyond-Login-LoginAgeTipsPanel-_EventOnOpenAgeTipsClicked0 = 1256,
		Beyond-Login-LoginAgeTipsPanel-OnValueChanged0 = 1257,
		Beyond-Login-LoginAgeTipsPanel-_UpdateAgeTipsPolicy0 = 1258,
		Beyond-Login-LoginAlertDialog-OnInit0 = 1259,
		Beyond-Login-LoginAlertDialog-_OnConfirmClicked0 = 1260,
		Beyond-Login-LoginDecorateUI-get_tickOption0 = 1261,
		Beyond-Login-LoginDecorateUI-OnValueChanged0 = 1262,
		Beyond-Login-LoginDecorateUI-_TriggerTrans2GSLoginImpl0 = 1263,
		Beyond-Login-LoginDecorateUI-Tick0 = 1264,
		Beyond-Login-LoginDecorateUI-_TimeManagerTick0 = 1265,
		Beyond-Login-LoginDecorateUI-OnRelease0 = 1266,
		Beyond-Login-LoginEnterGamePanel-_InitIfNot0 = 1267,
		Beyond-Login-LoginEnterGamePanel-_OnEnterGameClicked0 = 1268,
		Beyond-Login-LoginEnterGamePanel-OnValueChanged0 = 1269,
		Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByFadeSwitchTween0 = 1270,
		Beyond-Login-LoginGovTipsPanel-OnInit0 = 1273,
		Beyond-Login-LoginGovTipsPanel-_EventOnOpenAgeTipsClicked0 = 1274,
		Beyond-Login-LoginGovTipsPanel-OnValueChanged0 = 1275,
		Beyond-Login-LoginJudgeDialog-OnInit0 = 1276,
		Beyond-Login-LoginJudgeDialog-_OnPositiveClicked0 = 1277,
		Beyond-Login-LoginJudgeDialog-_OnNegativeClicked0 = 1278,
		Beyond-Login-LoginMenuPanel-OnInit0 = 1279,
		Beyond-Login-LoginMenuPanel-_OnAnnounceClicked0 = 1280,
		Beyond-Login-LoginMenuPanel-_OnAnnounceClosed0 = 1282,
		Beyond-Login-LoginMenuPanel-_OnSettingClicked0 = 1284,
		Beyond-Login-LoginMenuPanel-_OnResCheckClicked0 = 1286,
		Beyond-Login-LoginMenuPanel-_OnLogoutClicked0 = 1288,
		Beyond-Login-LoginMenuPanel-_OnQuitGameClicked0 = 1290,
		Beyond-Login-LoginMenuPanel-_OnLoginClicked0 = 1294,
		Beyond-Login-LoginMenuPanel-_OnQRClicked0 = 1295,
		Beyond-Login-LoginMenuPanel-_OnServerZoneBtnClicked0 = 1298,
		Beyond-Login-LoginMenuPanel-_OnFocusMenuGroup0 = 1300,
		Beyond-Login-LoginMenuPanel-OnValueChanged0 = 1301,
		Beyond-Login-LoginMenuPanel-_CanQRLogin0 = 1302,
		Beyond-Login-LoginMenuPanel-Awake0 = 1303,
		Beyond-Login-LoginMenuPanel-_UpdateServerZone0 = 1304,
		Beyond-Login-LoginMenuPanel-OnEnable0 = 1305,
		Beyond-Login-LoginMenuPanel-_OnRequestRelogin0 = 1306,
		Beyond-Login-LoginMenuPanel-_OnInputChanged0 = 1307,
		Beyond-Login-LoginMenuPanel-_OnUpdateRedDotForSDKListener0 = 1308,
		Beyond-Login-LoginMenuPanel-OnDisable0 = 1309,
		Beyond-Login-LoginMenuPanel-OnDestroy0 = 1310,
		Beyond-Login-LoginRootPanel-ChildPanel-OnDestroy0 = 1311,
		Beyond-Login-LoginMenuPanel-_OnCustomServiceClicked0 = 1312,
		Beyond-Login-LoginMenuPanel-_OnAccountCenterClicked0 = 1313,
		Beyond-Login-LoginMockUIDPanel-get_instance0 = 1314,
		Beyond-Login-LoginMockUIDPanel-Refresh0 = 1315,
		Beyond-Login-LoginMockUIDPanel-_SmokeEnterGame0 = 1316,
		Beyond-Login-LoginMockUIDPanel-OnDestroy0 = 1317,
		Beyond-Login-LoginResourcePanel-OnValueChanged0 = 1318,
		Beyond-Login-LoginResourcePanel-_UpdateResourceInfo0 = 1319,
		Beyond-Login-LoginResourcePanel-Update0 = 1320,
		Beyond-Login-LoginRootPanel-Awake0 = 1321,
		Beyond-Login-LoginRootPanel-_OnNotchPaddingChanged0 = 1322,
		Beyond-Login-LoginRootPanel-OnDestroy0 = 1323,
		Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByAnimSwitchTween0 = 1324,
		Beyond-Login-LoginServerSelectItemView-RefreshView0 = 1325,
		Beyond-Login-LoginServerSelectItemView-_OnClicked0 = 1326,
		Beyond-Login-LoginServerSelectItemView-NaviToBtnTarget0 = 1327,
		Beyond-Login-LoginServerSelectItemView-SetSelected0 = 1328,
		Beyond-Login-LoginServerSelectModel-get_curServerZoneData0 = 1329,
		Beyond-Login-LoginServerSelectModel-InitData0 = 1330,
		Beyond-Login-LoginServerSelectPanel-OnInit0 = 1331,
		Beyond-Login-LoginServerSelectPanel-_OnConfirmClicked0 = 1332,
		Beyond-Login-LoginServerSelectPanel-_OnCloseClicked0 = 1333,
		Beyond-Login-LoginServerSelectPanel-_UpdateServerCell0 = 1334,
		Beyond-Login-LoginServerSelectPanel-OnDisable0 = 1335,
		Beyond-Login-LoginServerSelectPanel-_OnInputChanged0 = 1336,
		Beyond-Login-LoginServerSelectPanel-_NaviToSelectedItem0 = 1337,
		Beyond-Login-LoginServerSelectPanel-OnEnable0 = 1338,
		Beyond-Login-LoginServerSelectPanel-_WaitingForShowListAwake0 = 1342,
		Beyond-Login-LoginServerSelectPanel-_UpdateServerSelected0 = 1349,
		Beyond-Login-LoginServerSelectPanel-OnValueChanged0 = 1350,
		Beyond-Login-LoginVersionPanel-Start0 = 1351,
		Beyond-Login-LoginVersionPanel-get_displayGameVersion0 = 1352,
		Beyond-Login-LoginVersionPanel-get_versionZoneType0 = 1353,
		Beyond-Login-LoginVersionPanel-get_versionPlatform0 = 1354,
		Beyond-Login-LoginVersionPanel-get_versionAppType0 = 1355,
		Beyond-Login-LoginVersionPanel-get_versionVersionNum0 = 1356,
		Beyond-Login-LoginVersionPanel-get_versionProjectCL0 = 1357,
		Beyond-Login-LoginVocResSelDialog-OnInit0 = 1358,
		Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked1 = 1359,
		Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked0 = 1360,
		Beyond-Login-LoginVocResSelDialog-_UpdateCell0 = 1361,
		Beyond-Login-LoginVocResSelItemView-RefreshView0 = 1362,
		Beyond-Login-LoginVocResSelItemView-_OnClicked0 = 1363,
		Beyond-Login-LoginVocResSelDialog-UpdateSelected0 = 1364,
		Beyond-Login-LoginVocResSelDialog-_UpdateList0 = 1365,
		Beyond-Login-LoginVocResSelDialog-_UpdateSelected0 = 1366,
		Beyond-Login-LoginVocResSelItemView-SetSelected0 = 1367,
		Beyond-Login-LoginVocResSelDialog-_RefreshConfirmInteractable0 = 1368,
		Beyond-Login-LoginVocResSelDialog-_ResolveInitialSelectedIndex0 = 1369,
		Beyond-Login-LoginVocResSelDialog-_NaviToSelectedItem0 = 1370,
		Beyond-Login-LoginVocResSelItemView-NaviToBtnTarget0 = 1371,
		Beyond-Login-LoginVocResSelDialog-OnEnable0 = 1372,
		Beyond-Login-LoginVocResSelDialog-_OnInputTypeChanged0 = 1373,
		Beyond-Login-LoginVocResSelDialog-OnDisable0 = 1374,
		Beyond-Scripts-Entry-WarmUpProgress-GetTotal0 = 1375,
		Beyond-Scripts-Entry-WarmUpProgress-GetCurrent0 = 1376,
		Beyond-Scripts-Entry-WarmUpProgress-GetInfo0 = 1377
	}
}
