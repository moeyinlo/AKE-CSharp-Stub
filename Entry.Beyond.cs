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

// Image 23: Entry.Beyond.dll - Assembly: Entry.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 80826-81319

public class RenderSilhouetteRT : MonoBehaviour // TypeDefIndex: 80827
{
	// Fields
	public Camera cameraRT; // 0x18
	public Camera mainCamera; // 0x20
	public Material materialSilhouette; // 0x28
	private static Texture s_mSilhouetteRT; // 0x00
	private static RenderTexture s_mSilhouetteRth; // 0x08

	// Constructors
	public RenderSilhouetteRT(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	private void Update(); // 0x0000000185E3A130-0x0000000185E3A4D0
	private void OnDestroy(); // 0x00000001852DC550-0x00000001852DC720
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 81136
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_56 DC2861C12B6449A074313F8A9D82F1C8C2F12AE967A20D4E854EC35783F0EB3D; // 0x00 // Static value (base64): AQAAAAIAAAADAAAABAAAAAUAAAAGAAAABwAAAAgAAAAJAAAACgAAAAsAAAAMAAAADQAAAA4AAAA= - Metadata: 0x0263E148

	// Nested types
	private struct __StaticArrayInitTypeSize_56 // TypeDefIndex: 81135
	{
	}
}

namespace Beyond
{
	public class GameApp : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 80838
	{
		// Fields
		private GameStateMachine m_stateMachine; // 0x18
		[CompilerGenerated]
		private static GameApp _instance_k__BackingField; // 0x00
		private bool m_hasFocus; // 0x20
		private bool m_needCallLuaFocus; // 0x21
		private bool m_pauseStatus; // 0x22
		private bool m_needCallLuaPause; // 0x23
		private const uint FILE_ATTRIBUTE_DIRECTORY = 16; // Metadata: 0x0263D1AA
		private const uint FILE_ATTRIBUTE_READONLY = 1; // Metadata: 0x0263D1AB
		private const uint FILE_ATTRIBUTE_NORMAL = 128; // Metadata: 0x0263D1AC
		private const uint FILE_ATTRIBUTE_REPARSE_POINT = 1024; // Metadata: 0x0263D1AE
		private static readonly IntPtr INVALID_HANDLE_VALUE; // 0x08
		private const uint GENERIC_READ = 2147483648; // Metadata: 0x0263D1B0
		private const uint GENERIC_WRITE = 1073741824; // Metadata: 0x0263D1B5
		private const uint FILE_SHARE_READ = 1; // Metadata: 0x0263D1BA
		private const uint FILE_SHARE_WRITE = 2; // Metadata: 0x0263D1BB
		private const uint FILE_SHARE_DELETE = 4; // Metadata: 0x0263D1BC
		private const uint OPEN_EXISTING = 3; // Metadata: 0x0263D1BD
		private const uint FILE_FLAG_SEQUENTIAL_SCAN = 134217728; // Metadata: 0x0263D1BE
		private const int ERROR_FILE_NOT_FOUND = 2; // Metadata: 0x0263D1C2
		private const int ERROR_PATH_NOT_FOUND = 3; // Metadata: 0x0263D1C3
		private const int ERROR_NO_MORE_FILES = 18; // Metadata: 0x0263D1C4
		[ThreadStatic]
		private static byte[] s_md5Buffer; // 0x80000000
		private static int s_scanRunning; // 0x10
		private static string s_pendingScanOutput; // 0x18
	
		// Properties
		public static GameApp instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000188CB1368-0x0000000188CB13B8 0x0000000188CB13B8-0x0000000188CB1414
		public Beyond.GameState currentState { get; } // 0x000000018521DBB0-0x000000018521DC20 
		public static bool IsScanRunning { get; } // 0x0000000188CB12E4-0x0000000188CB1368 
	
		// Nested types
		private struct WIN32_FIND_DATA // TypeDefIndex: 80829
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
	
		private class FileEntry // TypeDefIndex: 80830
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
			public FileEntry(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private struct PendingFile // TypeDefIndex: 80831
		{
			// Fields
			public string fullPath; // 0x00
			public long size; // 0x08
			public bool readOnlyAttr; // 0x10
		}
	
		private class ScanContext // TypeDefIndex: 80832
		{
			// Fields
			public readonly ConcurrentQueue<string> dirQueue; // 0x10
			public readonly ConcurrentQueue<PendingFile> fileQueue; // 0x18
			public readonly ConcurrentBag<FileEntry> results; // 0x20
			public int pendingDirs; // 0x28
			public int pendingFiles; // 0x2C
	
			// Constructors
			public ScanContext(); // 0x0000000188CB38B4-0x0000000188CB39C0
		}
	
		private class TreeNode // TypeDefIndex: 80833
		{
			// Fields
			public string name; // 0x10
			public FileEntry fileEntry; // 0x18
			public Dictionary<string, TreeNode> children; // 0x20
	
			// Constructors
			public TreeNode(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __DelayInit_d__14 : IEnumerator<object> // TypeDefIndex: 80834
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool needDeepProfilerMode; // 0x20
			public GameApp __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DelayInit_d__14(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CB4E94-0x0000000188CB5034
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB5034-0x0000000188CB5080
		}
	
		[CompilerGenerated]
		private sealed class __InitSecuritySDK_d__35 : IEnumerator<object> // TypeDefIndex: 80835
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameApp __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __InitSecuritySDK_d__35(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018679F350-0x00000001867A1240
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB51FC-0x0000000188CB5248
		}
	
		[CompilerGenerated]
		private sealed class _FetchRemoteNetworkCfg_d__37 : IEnumerator<object> // TypeDefIndex: 80836
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float timeoutSeconds; // 0x20
			private Beyond.Misc.ObjectRef _resultRef_5__2; // 0x28
			private RemoteNetworkCfg _config_5__3; // 0x30
			private IEnumerator _send_5__4; // 0x38
			private HttpSender.Cancellation _cancellation_5__5; // 0x40
			private float _start_5__6; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _FetchRemoteNetworkCfg_d__37(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182758E70-0x000000018275AF50
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018275AF50-0x000000018275AFA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 80837
		{
			// Fields
			public string capturedRoot; // 0x10
			public int capturedThreads; // 0x18
			public string capturedOutput; // 0x20
			public string capturedSysInfo; // 0x28
	
			// Constructors
			public __c__DisplayClass71_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LaunchScanCoordinator_b__0(); // 0x0000000188CB4690-0x0000000188CB49B0
		}
	
		// Constructors
		public GameApp(); // 0x00000001872301B0-0x00000001872301D0
		static GameApp(); // 0x0000000187220670-0x00000001872206B0
	
		// Methods
		public void SwitchState(Beyond.GameState state); // 0x00000001862B30D0-0x00000001862B3150
		private void Awake(); // 0x0000000186BDBA60-0x0000000186BDE9F0
		private bool _NeedDeepProfilerMode(); // 0x0000000186612630-0x00000001866126F0
		[IteratorStateMachine(typeof(__DelayInit_d__14))]
		private IEnumerator _DelayInit(bool needDeepProfilerMode); // 0x00000001827541A0-0x0000000182754550
		private void _RegisterLuaAfterGCEvent(); // 0x0000000186D2E080-0x0000000186D2E1A0
		private void _InitNotificationCenter(); // 0x000000018722CC20-0x000000018722CC50
		private void Update(); // 0x00000001856FA0C0-0x00000001856FA240
		private void LateUpdate(); // 0x0000000185E6B1D0-0x0000000185E6B260
		private void OnApplicationQuit(); // 0x0000000188CACD84-0x0000000188CACFAC
		private void OnApplicationFocus(bool hasFocus); // 0x0000000185A840A0-0x0000000185A84240
		private void _OnApplicationFocusForLua(); // 0x0000000186230810-0x00000001862308A0
		private void OnApplicationPause(bool pauseStatus); // 0x000000018628A1F0-0x000000018628A430
		private void _OnApplicationPauseForLua(); // 0x000000018628A510-0x000000018628A540
		private void OnDestroy(); // 0x0000000188CACFAC-0x0000000188CAD1D4
		private void _PreInitGameSetting(); // 0x00000001858D7220-0x00000001858D7370
		private void _Init(bool needDeepProfilerMode); // 0x0000000182754550-0x0000000182756870
		private void _UnInit(); // 0x0000000188CB0524-0x0000000188CB05BC
		private void _InitGameStateMachine(); // 0x0000000186CEB020-0x0000000186CEB0D0
		private void _UnInitGameStateMachine(); // 0x0000000188CB0490-0x0000000188CB0524
		[IDTag(1)]
		public static void QuitGame(GameAppExitCode exitCode); // 0x0000000188CAD278-0x0000000188CAD2F4
		[IDTag(0)]
		public static void QuitGame(int exitCode); // 0x0000000188CAD2F4-0x0000000188CAD3B8
		public static void RefreshScreenResolution(); // 0x0000000188CAD3B8-0x0000000188CAD4B8
		private static void _OnSystemDisplaySizeChanged(); // 0x0000000188CAF70C-0x0000000188CAF7A0
		private static void _OnSystemScreenSizeChanged([IsReadOnly] in EventData<bool, bool> data); // 0x0000000188CAF7A0-0x0000000188CAF86C
		[IteratorStateMachine(typeof(__InitSecuritySDK_d__35))]
		private IEnumerator _InitSecuritySDK(); // 0x0000000187181290-0x0000000187181310
		private void _OnApplicationPauseForSecurity(bool pauseStatus); // 0x000000018628A540-0x000000018628A5E0
		[IteratorStateMachine(typeof(_FetchRemoteNetworkCfg_d__37))]
		internal IEnumerator FetchRemoteNetworkCfg(float timeoutSeconds = 0f /* Metadata: 0x0263D1A5 */); // 0x0000000182753E40-0x00000001827541A0
		private static extern IntPtr _FindFirstFileW(string lpFileName, out WIN32_FIND_DATA lpFindFileData); // 0x0000000188CAF164-0x0000000188CAF27C
		private static extern bool _FindNextFileW(IntPtr hFindFile, out WIN32_FIND_DATA lpFindFileData); // 0x0000000188CAF27C-0x0000000188CAF38C
		private static extern bool _FindClose(IntPtr hFindFile); // 0x0000000188CAF0E0-0x0000000188CAF164
		private static extern IntPtr _CreateFileW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile); // 0x0000000188CAF004-0x0000000188CAF0E0
		private static extern bool _ReadFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped); // 0x0000000188CAFC6C-0x0000000188CAFD34
		private static extern bool _CloseHandle(IntPtr hObject); // 0x0000000188CADF0C-0x0000000188CADF5C
		public static bool PollScanResult(out string gzOutputPath); // 0x0000000188CAD1D4-0x0000000188CAD278
		public static void ScanLocalFiles(string rootDir = null, string outputPath = null, int threadCount = 0 /* Metadata: 0x0263D1A9 */); // 0x0000000188CAD4B8-0x0000000188CAD6B4
		internal static void LaunchScanCoordinator(string rootDir, string outputPath, int threadCount, string systemInfo = null); // 0x0000000188CACAAC-0x0000000188CACD84
		private static List<FileEntry> _ScanParallel(string root, int threadCount); // 0x0000000188CB0128-0x0000000188CB03E4
		private static void _WorkerLoop(object state); // 0x0000000188CB05BC-0x0000000188CB07BC
		private static void _ScanDirectory(ScanContext ctx, string dir); // 0x0000000188CAFD34-0x0000000188CB0128
		private static string _MakeLongPath(string path); // 0x0000000188CAF554-0x0000000188CAF70C
		private static FileEntry _BuildEntry(PendingFile pf); // 0x0000000188CAD6B4-0x0000000188CAD94C
		private static bool _CanAccess(string path, uint desiredAccess); // 0x0000000188CADE20-0x0000000188CADF0C
		private static string _CalculateMd5(string path); // 0x0000000188CAD94C-0x0000000188CADE20
		private static string _CollectSystemInfo(); // 0x0000000188CADF5C-0x0000000188CAF004
		private static void _WriteTreeReport(List<FileEntry> entries, string root, System.DateTime scanStart, string outputPath, string systemInfo = null); // 0x0000000188CB07BC-0x0000000188CB12E4
		private static void _PrintTreeNode(StringBuilder sb, TreeNode node, string prefix); // 0x0000000188CAF86C-0x0000000188CAFC6C
		private static int _TreeNodeCompare(TreeNode a, TreeNode b); // 0x0000000188CB03E4-0x0000000188CB0490
		private static string _FormatSize(long bytes); // 0x0000000188CAF38C-0x0000000188CAF554
	}

	public interface IMemoryPackProxy // TypeDefIndex: 80839
	{
		// Methods
		void Init();
	}

	public class MemoryPackProxyModule // TypeDefIndex: 80840
	{
		// Fields
		private static IMemoryPackProxy s_memoryPackProxy; // 0x00
	
		// Constructors
		public MemoryPackProxyModule(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void RegisterProxy(IMemoryPackProxy memoryPackProxy); // 0x0000000188CB35E0-0x0000000188CB3630
		public static IMemoryPackProxy GetMemoryPackProxy(); // 0x0000000188CB35A8-0x0000000188CB35E0
	}

	public class GameInitState : GameStateBase // TypeDefIndex: 80842
	{
		// Properties
		public override Beyond.GameState stateId { get; } // 0x00000001871DE5A0-0x00000001871DE5D0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DoInit_d__5 : IEnumerator<object> // TypeDefIndex: 80841
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameInitState __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DoInit_d__5(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001863F9290-0x00000001863FCEF0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB50CC-0x0000000188CB5118
		}
	
		// Constructors
		public GameInitState(GameStateMachine stateMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void OnEnter(Beyond.GameState fromStateId); // 0x0000000186BD9B80-0x0000000186BDA7E0
		public override void OnLeave(Beyond.GameState toStateId); // 0x0000000185319DA0-0x0000000185319E50
		[IteratorStateMachine(typeof(__DoInit_d__5))]
		private IEnumerator _DoInit(); // 0x0000000186BDA7E0-0x0000000186BDA860
		private void _InitInitialResourceManager(out VirtualFileSystem.BlockValidator blockValidator); // 0x00000001869C0890-0x00000001869C0A10
		private bool _CheckIfLocalInitialAssetsValid(out LocalResPref outputLocalResPref, out VirtualFileSystem.BlockValidator blockValidator); // 0x00000001858D8810-0x00000001858D8950
		private void _InitAPPDefaultCulture(); // 0x00000001869BEAD0-0x00000001869BEC60
		private void _InitGameSetting(); // 0x0000000185750E30-0x0000000185750F90
		public void __iFixBaseProxy_OnEnter(Beyond.GameState P0); // 0x0000000188CB1414-0x0000000188CB141C
		public void __iFixBaseProxy_OnLeave(Beyond.GameState P0); // 0x0000000188CB141C-0x0000000188CB1424
	}

	public class GameLoginState : GameStateBase // TypeDefIndex: 80843
	{
		// Properties
		public override Beyond.GameState stateId { get; } // 0x00000001871FDDA0-0x00000001871FDDD0 
	
		// Constructors
		public GameLoginState(GameStateMachine stateMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void OnEnter(Beyond.GameState fromStateId); // 0x0000000186BDA860-0x0000000186BDB8B0
		public override void OnLeave(Beyond.GameState toStateId); // 0x000000018614AE80-0x000000018614AF10
		private static void _TryStartLoginWorkflow(); // 0x00000001867A2E60-0x00000001867A3DB0
		public void __iFixBaseProxy_OnEnter(Beyond.GameState P0); // 0x0000000188CB1414-0x0000000188CB141C
		public void __iFixBaseProxy_OnLeave(Beyond.GameState P0); // 0x0000000188CB141C-0x0000000188CB1424
	}

	public class GameMainState : GameStateBase // TypeDefIndex: 80844
	{
		// Fields
		private bool m_isFirstEnter; // 0x18
	
		// Properties
		public override Beyond.GameState stateId { get; } // 0x00000001871FDD70-0x00000001871FDDA0 
	
		// Constructors
		public GameMainState(GameStateMachine stateMachine); // 0x000000018783D4EC-0x000000018783D500
	
		// Methods
		public override void OnEnter(Beyond.GameState fromStateId); // 0x00000001867A3FA0-0x00000001867A40B0
		public override void OnLeave(Beyond.GameState toStateId); // 0x0000000188CB1424-0x0000000188CB1480
		public static void ReleaseMainGame(Beyond.GameState toStateId); // 0x0000000188CB1480-0x0000000188CB16F4
		private static void _ClearUtils(); // 0x0000000188CB16F4-0x0000000188CB17E0
		public void __iFixBaseProxy_OnEnter(Beyond.GameState P0); // 0x0000000188CB1414-0x0000000188CB141C
		public void __iFixBaseProxy_OnLeave(Beyond.GameState P0); // 0x0000000188CB141C-0x0000000188CB1424
	}

	public class GamePreloadState : GameStateBase // TypeDefIndex: 80846
	{
		// Fields
		private Tables.AsyncLoadTask m_asyncTask; // 0x18
	
		// Properties
		public override Beyond.GameState stateId { get; } // 0x00000001871FDD10-0x00000001871FDD40 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DoPreload_d__6 : IEnumerator<object> // TypeDefIndex: 80845
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GamePreloadState __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DoPreload_d__6(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001862B3750-0x00000001862B6A60
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB5118-0x0000000188CB5164
		}
	
		// Constructors
		public GamePreloadState(GameStateMachine stateMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void OnEnter(Beyond.GameState fromStateId); // 0x000000018614AF10-0x000000018614B850
		public override void OnLeave(Beyond.GameState toStateId); // 0x000000018614B8D0-0x000000018614B940
		[IteratorStateMachine(typeof(__DoPreload_d__6))]
		private IEnumerator _DoPreload(); // 0x000000018614B850-0x000000018614B8D0
		private void _InitGameSettingStateInPreload(); // 0x00000001862D34E0-0x00000001862D3D40
		public void __iFixBaseProxy_OnEnter(Beyond.GameState P0); // 0x0000000188CB1414-0x0000000188CB141C
		public void __iFixBaseProxy_OnLeave(Beyond.GameState P0); // 0x0000000188CB141C-0x0000000188CB1424
	}

	public class GameQuitState : GameStateBase // TypeDefIndex: 80847
	{
		// Properties
		public override Beyond.GameState stateId { get; } // 0x00000001871FDCE0-0x00000001871FDD10 
	
		// Constructors
		public GameQuitState(GameStateMachine stateMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void OnEnter(Beyond.GameState fromStateId); // 0x0000000188CB1C38-0x0000000188CB1C8C
		public override void OnLeave(Beyond.GameState toStateId); // 0x0000000188CB1C8C-0x0000000188CB1CCC
		public static void DoQuit(); // 0x0000000188CB17E0-0x0000000188CB1C38
		public void __iFixBaseProxy_OnEnter(Beyond.GameState P0); // 0x0000000188CB1414-0x0000000188CB141C
		public void __iFixBaseProxy_OnLeave(Beyond.GameState P0); // 0x0000000188CB141C-0x0000000188CB1424
	}

	public class GameSoftRestartState : GameStateBase // TypeDefIndex: 80849
	{
		// Fields
		private const string CLEAR_SCENE_PATH = "Assets/Beyond/Scenes/BuildScenes/Clear.unity"; // Metadata: 0x0263D1C5
	
		// Properties
		public override Beyond.GameState stateId { get; } // 0x00000001871FDCB0-0x00000001871FDCE0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __SoftRestart_d__5 : IEnumerator<object> // TypeDefIndex: 80848
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameSoftRestartState __4__this; // 0x20
			private AsyncOperation _clearSceneOp_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __SoftRestart_d__5(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CB532C-0x0000000188CB5C4C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB5C4C-0x0000000188CB5C98
		}
	
		// Constructors
		public GameSoftRestartState(GameStateMachine stateMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void OnEnter(Beyond.GameState fromStateId); // 0x0000000188CB1CCC-0x0000000188CB1DB8
		[IteratorStateMachine(typeof(__SoftRestart_d__5))]
		private IEnumerator _SoftRestart(); // 0x0000000188CB1DB8-0x0000000188CB1E50
		public void __iFixBaseProxy_OnEnter(Beyond.GameState P0); // 0x0000000188CB1414-0x0000000188CB141C
	}

	public class GameStartState : GameStateBase // TypeDefIndex: 80850
	{
		// Properties
		public override Beyond.GameState stateId { get; } // 0x00000001871FDC80-0x00000001871FDCB0 
	
		// Constructors
		public GameStartState(GameStateMachine stateMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void OnEnter(Beyond.GameState fromStateId); // 0x000000018614B940-0x000000018614BA90
		public override void OnLeave(Beyond.GameState toStateId); // 0x000000018614BA90-0x000000018614BBA0
		private void _OnEnterMainGame(); // 0x00000001867A3ED0-0x00000001867A3FA0
		[CompilerGenerated]
		private void __OnEnterMainGame_b__5_0(); // 0x00000001862B3160-0x00000001862B31B0
		public void __iFixBaseProxy_OnEnter(Beyond.GameState P0); // 0x0000000188CB1414-0x0000000188CB141C
		public void __iFixBaseProxy_OnLeave(Beyond.GameState P0); // 0x0000000188CB141C-0x0000000188CB1424
	}

	public abstract class GameStateBase : ISimpleStateNode<Beyond.GameState>, ILuaCallCSharp // TypeDefIndex: 80851
	{
		// Fields
		protected readonly GameStateMachine m_stateMachine; // 0x10
	
		// Properties
		public abstract Beyond.GameState stateId { get; }
	
		// Constructors
		protected GameStateBase(GameStateMachine stateMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public virtual void OnEnter(Beyond.GameState fromStateId); // 0x000000018614CBB0-0x000000018614CC50
		public virtual void OnLeave(Beyond.GameState toStateId); // 0x000000018614CB10-0x000000018614CBB0
		public virtual void OnTick(float deltaTime); // 0x0000000188CB1E50-0x0000000188CB1E84
	}

	public class GameStateMachine : SimpleEnumStateMachine<Beyond.GameState>, IGameStateMachine, ILuaCallCSharp // TypeDefIndex: 80853
	{
		// Fields
		[CompilerGenerated]
		private readonly GameApp _app_k__BackingField; // 0x30
	
		// Properties
		public GameApp app { [CompilerGenerated] get; } // 0x00000001829600D0-0x00000001829600E0 
		public Beyond.GameState curState { get; } // 0x0000000185EAF320-0x0000000185EAF350 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ReturnToLoginState_d__8 : IEnumerator<object> // TypeDefIndex: 80852
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameStateMachine __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _ReturnToLoginState_d__8(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CB4080-0x0000000188CB435C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB435C-0x0000000188CB43A8
		}
	
		// Constructors
		public GameStateMachine(GameApp gameApp); // 0x0000000186CEB0D0-0x0000000186CEB130
	
		// Methods
		private void _RegisterStates(); // 0x0000000186CEB130-0x0000000186CEB370
		public bool CheckCanReturnToLoginState(); // 0x0000000188CB1E84-0x0000000188CB1EFC
		[IteratorStateMachine(typeof(_ReturnToLoginState_d__8))]
		public IEnumerator ReturnToLoginState(); // 0x0000000188CB1EFC-0x0000000188CB1F94
	}

	public static class GlobalInitializer // TypeDefIndex: 80854
	{
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void InitGlobalConfig(); // 0x000000018722B7A0-0x000000018722BCE0
	}

	public interface IHotFixCommon // TypeDefIndex: 80855
	{
	}

	public interface IHotFixPatchManagerProxy : IHotFixCommon // TypeDefIndex: 80856
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

	public class HotFixPatchModules // TypeDefIndex: 80857
	{
		// Fields
		private static Dictionary<System.Type, IHotFixCommon> s_hotFixModules; // 0x00
	
		// Constructors
		public HotFixPatchModules(); // 0x0000000186805BA0-0x0000000186805BB0
		static HotFixPatchModules(); // 0x0000000187178080-0x0000000187178110
	
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

	public static class InitialPathDef // TypeDefIndex: 80858
	{
		// Fields
		public const string LOGIN_SCENE_PATH = "Assets/Beyond/InitialAssets/Scenes/Login.unity"; // Metadata: 0x0263D1F2
		public const string LOGIN_SK_ACTOR_M = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_male.prefab"; // Metadata: 0x0263D221
		public const string LOGIN_SK_ACTOR_F = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_female.prefab"; // Metadata: 0x0263D25F
		public const string LOGIN_SK_ACTOR_NO_GENDER = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_no_gender.prefab"; // Metadata: 0x0263D29F
		public const string LOGIN_MOCK_UID_PANEL = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginMockUIDPanel.prefab"; // Metadata: 0x0263D2E3
		public const string LOGIN_CONTROLLER_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginController.prefab"; // Metadata: 0x0263D327
		public const string LOGIN_ROOT_PANEL_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginRootPanel.prefab"; // Metadata: 0x0263D369
		public const string LOGIN_ALERT_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginAlertDialog.prefab"; // Metadata: 0x0263D3A9
		public const string LOGIN_JUDGE_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginJudgeDialog.prefab"; // Metadata: 0x0263D3EC
		public const string LOGIN_VOC_RES_SELECT_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginVocResSelDialog.prefab"; // Metadata: 0x0263D42F
	}

	public class LoginController : MonoBehaviour, ILoginBinder<LoginViewModel> // TypeDefIndex: 80874
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
		public MaskCtrl maskCtrl { get; } // 0x00000001863F7D20-0x00000001863F7DC0 
		public LoginRootPanel rootPanel { get; } // 0x0000000188CB2230-0x0000000188CB2274 
	
		// Events
		private event Action<string> m_onMockLogin {
			add; // 0x00000001869497B0-0x0000000186949840
			remove; // 0x0000000186949840-0x00000001869498D0
		}
	
		// Nested types
		public struct FOptions // TypeDefIndex: 80859
		{
			// Fields
			public LoginContext context; // 0x00
		}
	
		public abstract class Dialog : MonoBehaviour // TypeDefIndex: 80862
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
			private sealed class __CloseCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 80860
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public Dialog __4__this; // 0x20
				public Action callback; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public __CloseCoroutine_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x0000000188CB4D78-0x0000000188CB4E48
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CB4E48-0x0000000188CB4E94
			}
	
			[CompilerGenerated]
			private sealed class _Create_d__8<TDialog> : IEnumerator<object> // TypeDefIndex: 80861
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
			protected Dialog(); // 0x00000001878364A0-0x00000001878364B8
	
			// Methods
			[IteratorStateMachine(typeof(__CloseCoroutine_d__4))]
			private IEnumerator _CloseCoroutine(Action callback); // 0x0000000188CAC9F4-0x0000000188CACAAC
			public bool TryCloseWithCallback(Action callback); // 0x0000000188CAC8AC-0x0000000188CAC9F4
			public void Show(); // 0x0000000188CAC7BC-0x0000000188CAC8AC
			protected virtual void OnInit(); // 0x0000000188CAC788-0x0000000188CAC7BC
			[IteratorStateMachine(typeof(_Create_d__8<TDialog>))]
			public static IEnumerator Create<TDialog>(string resPath, LoginController controller, Beyond.Misc.ObjectRef outRef)
				where TDialog : Dialog;
		}
	
		public static class MaskConsts // TypeDefIndex: 80863
		{
			// Fields
			public const float DELAY_WAIT_NODE = 0.2f; // Metadata: 0x0263D476
			public const string INIT = "init"; // Metadata: 0x0263D47A
			public const string U8_LOGIN = "u8_login"; // Metadata: 0x0263D47F
			public const string FROM_GS_LOGIN = "from_gs_login"; // Metadata: 0x0263D488
			public const string FROM_CREATE_ROLE = "from_create_role"; // Metadata: 0x0263D496
			public const string NET_AGE_TIPS = "age_tips"; // Metadata: 0x0263D4A7
		}
	
		public enum EMaskType // TypeDefIndex: 80864
		{
			None = 0,
			Black = 1,
			Blur = 2,
			White = 3
		}
	
		[Serializable]
		private class MaskCfg // TypeDefIndex: 80865
		{
			// Fields
			public CanvasGroup target; // 0x10
			public float showDuration; // 0x18
			public float hideDuration; // 0x1C
	
			// Constructors
			public MaskCfg(); // 0x0000000187239990-0x00000001872399A0
	
			// Methods
			public UISwitchTween CreateTweenAndHide(); // 0x00000001863F6800-0x00000001863F68C0
		}
	
		public class MaskCtrl : IDisposable // TypeDefIndex: 80868
		{
			// Fields
			private static readonly int[] CROSS_SCENE_MASKS; // 0x00
			private ListDict<int, HashSet<string>> m_maskRefs; // 0x10
			private ListDict<int, UISwitchTween> m_maskTweens; // 0x18
			private ListDict<string, NetMaskRef> m_netMasks; // 0x20
	
			// Nested types
			private class NetMaskRef // TypeDefIndex: 80866
			{
				// Fields
				[CompilerGenerated]
				private string _key_k__BackingField; // 0x10
				public int maskId; // 0x18
				public bool isEnabled; // 0x1C
	
				// Properties
				public string key { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
				// Constructors
				public NetMaskRef(string key); // 0x0000000184FD2410-0x0000000184FD2420
			}
	
			[CompilerGenerated]
			private sealed class _WaitForCrossSceneMasks_d__10 : IEnumerator<object> // TypeDefIndex: 80867
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public MaskCtrl __4__this; // 0x20
				private int[] __7__wrap1; // 0x28
				private int __7__wrap2; // 0x30
				private UISwitchTween _mask_5__4; // 0x38
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public _WaitForCrossSceneMasks_d__10(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x0000000188CB4BA4-0x0000000188CB4CE0
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CB4CE0-0x0000000188CB4D2C
			}
	
			// Constructors
			public MaskCtrl(LoginController controller); // 0x00000001863F6600-0x00000001863F6800
			static MaskCtrl(); // 0x0000000187109680-0x0000000187109710
	
			// Methods
			public void Dispose(); // 0x00000001863F6EC0-0x00000001863F76E0
			public void EnableMask(string key, EMaskType type, bool enable, bool reset = false /* Metadata: 0x0263D4B4 */); // 0x00000001861526F0-0x00000001861528E0
			public bool IsMaskTweening(EMaskType type); // 0x00000001863F7AC0-0x00000001863F7B00
			public bool IsCrossSceneMaskTweening(); // 0x00000001863F6DD0-0x00000001863F6EC0
			[IteratorStateMachine(typeof(_WaitForCrossSceneMasks_d__10))]
			public IEnumerator WaitForCrossSceneMasks(); // 0x0000000188CB3510-0x0000000188CB35A8
			public void EnableNetMask(string key, float timeoutSecs); // 0x0000000188CB333C-0x0000000188CB3510
			public void DisableNetMask(string key); // 0x0000000188CB323C-0x0000000188CB333C
			private UISwitchTween _GetMaskByType(int type); // 0x00000001861528E0-0x0000000186152980
		}
	
		[CompilerGenerated]
		private sealed class _BeforeDestroy_d__35 : IEnumerator<object> // TypeDefIndex: 80869
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _BeforeDestroy_d__35(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001863F7BE0-0x00000001863F7C70
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB3E08-0x0000000188CB3E54
		}
	
		[CompilerGenerated]
		private sealed class __InstantiateUIFromRes_d__36<T> : IEnumerator<object> // TypeDefIndex: 80870
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
		private sealed class __InitCoroutine_d__38 : IEnumerator<object> // TypeDefIndex: 80871
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
			private LoginContext _context_5__2; // 0x28
			private Beyond.Misc.ObjectRef _panelRef_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __InitCoroutine_d__38(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001863F7DC0-0x00000001863F8000
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB51B0-0x0000000188CB51FC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 80872
		{
			// Fields
			public Beyond.Misc.ObjectRef objRef; // 0x10
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __MockLoginCoroutine_b__0(string pUID); // 0x0000000185BA6CD0-0x0000000185BA6D00
		}
	
		[CompilerGenerated]
		private sealed class __MockLoginCoroutine_d__45 : IEnumerator<object> // TypeDefIndex: 80873
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
			private __c__DisplayClass45_0 __8__1; // 0x28
			public string fixedUID; // 0x30
			private LoginMockUIDPanel _nullablePanel_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __MockLoginCoroutine_d__45(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186B3B1A0-0x0000000186B3B590
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB5294-0x0000000188CB52E0
		}
	
		// Constructors
		public LoginController(); // 0x0000000186E1BF30-0x0000000186E1C070
	
		// Methods
		protected void Awake(); // 0x00000001871C33F0-0x00000001871C3470
		protected void Start(); // 0x0000000187206E20-0x0000000187206E60
		public float GetEnterGamePanelPredelay(); // 0x0000000188CB21EC-0x0000000188CB2230
		public void OnValueChanged(LoginViewModel viewModel); // 0x0000000186C5B9F0-0x0000000186C5BA80
		public void InitUI(FOptions options); // 0x00000001863F6AA0-0x00000001863F6C50
		public void InvokeWhenStart(Action callback); // 0x00000001867A4580-0x00000001867A45C0
		[IteratorStateMachine(typeof(_BeforeDestroy_d__35))]
		public IEnumerator BeforeDestroy(); // 0x0000000186EB9570-0x0000000186EB95F0
		[IteratorStateMachine(typeof(__InstantiateUIFromRes_d__36<T>))]
		private IEnumerator _InstantiateUIFromRes<T>(string resPath, Transform parent, Beyond.Misc.ObjectRef objRef)
			where T : Component;
		private void _InitImpl(); // 0x00000001870C01A0-0x00000001870C01F0
		[IteratorStateMachine(typeof(__InitCoroutine_d__38))]
		private IEnumerator _InitCoroutine(); // 0x00000001870C01F0-0x00000001870C0270
		private void _InitVersionBtn(); // 0x000000018710E970-0x000000018710EA40
		public void MockLoginWithCallback(string fixedUID, Action<string> callback); // 0x00000001867A43D0-0x00000001867A44E0
		[IteratorStateMachine(typeof(__MockLoginCoroutine_d__45))]
		private IEnumerator _MockLoginCoroutine(string fixedUID); // 0x00000001867A44E0-0x00000001867A4580
		[CompilerGenerated]
		private void _MockLoginWithCallback_b__44_0(); // 0x0000000187231390-0x00000001872313A0
	}

	public class LoginContext : IDisposable // TypeDefIndex: 80876
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
		public bool quickStart { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
		public bool firstLogin { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EDC0-0x000000018226EDD0 0x000000018226EDD0-0x000000018226EDE0
		public LoginWorkFlow workflow { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public LoginViewProperty viewProp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public LoginManager.AssetLoader loader { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public LoginManager.FlowWithMaskMgr flowWithMask { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public NetUsagePolicy netUsagePolicy { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public LoginGameUpdater gameUpdater { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public bool startConnectServer { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DisposeCoroutine_d__48 : IEnumerator<object> // TypeDefIndex: 80875
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController legacyController; // 0x20
			public Action disposeAction; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DisposeCoroutine_d__48(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186EB9450-0x0000000186EB9570
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB5080-0x0000000188CB50CC
		}
	
		// Constructors
		public LoginContext(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public LoginController ViewOnlyController(); // 0x0000000188CB21AC-0x0000000188CB21EC
		public void Init(bool quickStart, LoginController controller, LoginWorkFlow workflow, LoginViewProperty viewProp, LoginManager.AssetLoader loader, LoginManager.FlowWithMaskMgr flowWithMask, NetUsagePolicy netUsagePolicy, LoginGameUpdater gameUpdater); // 0x0000000186CBD120-0x0000000186CBD1D0
		public void StartCoroutine(IEnumerator routine); // 0x00000001862AFF00-0x00000001862B0600
		public void StopCoroutine(IEnumerator routine); // 0x0000000188CB2144-0x0000000188CB21AC
		public void SendEvent(ELoginEvent evt, object param = null); // 0x0000000188CB2014-0x0000000188CB206C
		public void Dispose(); // 0x0000000186EBB340-0x0000000186EBB4A0
		public void ShutDown(); // 0x0000000188CB206C-0x0000000188CB2144
		public bool IsWorkflowDisposed(); // 0x0000000188CB1FD8-0x0000000188CB2014
		public bool IsDisposed(); // 0x0000000188CB1F94-0x0000000188CB1FD8
		private void _DisposeImpl(); // 0x0000000186CBD1D0-0x0000000186CBD230
		[IteratorStateMachine(typeof(__DisposeCoroutine_d__48))]
		private static IEnumerator _DisposeCoroutine(LoginController legacyController, Action disposeAction); // 0x0000000186EBB4A0-0x0000000186EBB540
	}

	public enum ELoginEvent // TypeDefIndex: 80877
	{
		None = 0,
		V2C_U8Login = 1,
		V2C_EnterGame = 2,
		V2C_Logout = 3,
		V2C_ResourceRepair = 4,
		V2C_PreDownload = 5,
		V2C_OpenAgeTips = 6,
		V2C_CloseAgeTips = 7,
		V2C_OpenServerSelect = 8,
		V2C_CloseServerSelect = 9,
		V2C_SelectServer = 10,
		V2C_ConfirmServer = 11,
		V2C_Relogin = 12,
		V2C_ReplayGsLogin = 13,
		C2V_PrepareGsLogin = 14
	}

	public static class LoginTextDefines // TypeDefIndex: 80878
	{
		// Fields
		public const string CS_LOGIN_CONN_FAIL = "CS_LOGIN_CONN_FAIL"; // Metadata: 0x0263D4C4
		public const string HOTUPDATE_INDEX_FAILED = "HOTUPDATE_INDEX_FAILED"; // Metadata: 0x0263D4D7
		public const string HOTUPDATE_IO_FAILED = "HOTUPDATE_IO_FAILED"; // Metadata: 0x0263D4EE
		public const string HOTUPDATE_CHECK_VERSION = "HOTUPDATE_CHECK_VERSION"; // Metadata: 0x0263D502
		public const string HOTUPDATE_DOWNLOADING = "HOTUPDATE_DOWNLOADING"; // Metadata: 0x0263D51A
		public const string HOTUPDATE_DECOMPRESSING = "HOTUPDATE_DECOMPRESSING"; // Metadata: 0x0263D530
		public const string LOGIN_HOTUPDATE_CHECKING_LOCAL_RES = "LOGIN_HOTUPDATE_CHECKING_LOCAL_RES"; // Metadata: 0x0263D548
		public const string HOTUPDATE_DOWNLOAD_ERROR = "HOTUPDATE_DOWNLOAD_ERROR"; // Metadata: 0x0263D56B
		public const string HOTUPDATE_DOWNLOAD_DISKFULL = "HOTUPDATE_DOWNLOAD_DISKFULL"; // Metadata: 0x0263D584
		public const string HOTUPDATE_LOCAL_RES_CHECK = "HOTUPDATE_LOCAL_RES_CHECK"; // Metadata: 0x0263D5A0
		public const string HOTUPDATE_PRELOAD_RES = "HOTUPDATE_PRELOAD_RES"; // Metadata: 0x0263D5BA
		public const string HOTUPDATE_INVALID_LOCAL_FILES = "HOTUPDATE_INVALID_LOCAL_FILES"; // Metadata: 0x0263D5D0
		public const string HOTUPDATE_INIT_RES_CHANGED = "HOTUPDATE_INIT_RES_CHANGED"; // Metadata: 0x0263D5EE
		public const string HOTUPDATE_DOWNLOAD_IO_ERROR = "HOTUPDATE_DOWNLOAD_IO_ERROR"; // Metadata: 0x0263D609
		public const string HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR = "HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR"; // Metadata: 0x0263D625
		public const string HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR = "HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR"; // Metadata: 0x0263D649
		public const string HOTUPDATE_DECOMPRESS_ERROR = "HOTUPDATE_DECOMPRESS_ERROR"; // Metadata: 0x0263D671
		public const string REMOTE_CFG_GAME_CFG_ERROR = "REMOTE_CFG_GAME_CFG_ERROR"; // Metadata: 0x0263D68C
		public const string REMOTE_CFG_GAME_CFG_TIMEOUT = "REMOTE_CFG_GAME_CFG_TIMEOUT"; // Metadata: 0x0263D6A6
		public const string REMOTE_CFG_NETWORK_CFG_ERROR = "REMOTE_CFG_NETWORK_CFG_ERROR"; // Metadata: 0x0263D6C2
		public const string REMOTE_CFG_NETWORK_CFG_TIMEOUT = "REMOTE_CFG_NETWORK_CFG_TIMEOUT"; // Metadata: 0x0263D6DF
		public const string REMOTE_CFG_RES_VERSION_ERROR = "REMOTE_CFG_RES_VERSION_ERROR"; // Metadata: 0x0263D6FE
		public const string REMOTE_CFG_RES_VERSION_TIMEOUT = "REMOTE_CFG_RES_VERSION_TIMEOUT"; // Metadata: 0x0263D71B
		public const string REMOTE_CFG_GAME_VERSION_ERROR = "REMOTE_CFG_GAME_VERSION_ERROR"; // Metadata: 0x0263D73A
		public const string REMOTE_CFG_GAME_VERSION_TIMEOUT = "REMOTE_CFG_GAME_VERSION_TIMEOUT"; // Metadata: 0x0263D758
		public const string LOGIN_JUDGE_EXIT_GAME = "LOGIN_JUDGE_EXIT_GAME"; // Metadata: 0x0263D778
		public const string LOGIN_JUDGE_LOGOUT = "LOGIN_JUDGE_LOGOUT"; // Metadata: 0x0263D78E
		public const string LOGIN_JUDGE_RES_REPAIR = "LOGIN_JUDGE_RES_REPAIR"; // Metadata: 0x0263D7A1
		public const string LOGIN_AGE_TIPS_FAILED = "LOGIN_AGE_TIPS_FAILED"; // Metadata: 0x0263D7B8
		public const string LOGIN_TXT_DIALOG_CONFIRM = "LOGIN_TXT_DIALOG_CONFIRM"; // Metadata: 0x0263D7CE
		public const string LOGIN_TXT_DIALOG_CANCEL = "LOGIN_TXT_DIALOG_CANCEL"; // Metadata: 0x0263D7E7
		public const string LOGIN_AUDIO_LANG_CN = "UI_LOGIN_ROOT_VOICE_CN"; // Metadata: 0x0263D7FF
		public const string LOGIN_AUDIO_LANG_JP = "UI_LOGIN_ROOT_VOICE_JP"; // Metadata: 0x0263D816
		public const string LOGIN_AUDIO_LANG_EN = "UI_LOGIN_ROOT_VOICE_EN"; // Metadata: 0x0263D82D
		public const string LOGIN_AUDIO_LANG_KR = "UI_LOGIN_ROOT_VOICE_KR"; // Metadata: 0x0263D844
		public const string LOGIN_TXT_NETWORK_ERROR = "LOGIN_TXT_NETWORK_ERROR"; // Metadata: 0x0263D85B
		public const string LOGIN_GAME_UPGRADED = "LOGIN_GAME_UPGRADED"; // Metadata: 0x0263D873
		public const string LOGIN_TXT_SERVER_CLOSED = "LOGIN_TXT_SERVER_CLOSED"; // Metadata: 0x0263D887
		public const string LOGIN_TXT_SERVER_CLOSED_DATETIME = "LOGIN_TXT_SERVER_CLOSED_DATETIME"; // Metadata: 0x0263D89F
		public const string LOGIN_TXT_USR_BAN_DATETIME = "LOGIN_TXT_USR_BAN_DATETIME"; // Metadata: 0x0263D8C0
		public const string LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER = "LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER"; // Metadata: 0x0263D8DB
		public const string LOGIN_GET_SERVER_LIST_FAILED = "LOGIN_GET_SERVER_LIST_FAILED"; // Metadata: 0x0263D905
		public const string LOGIN_TEXT_SERVER_ZONE_FAILED = "LOGIN_TEXT_SERVER_ZONE_FAILED"; // Metadata: 0x0263D922
		public const string LOGIN_TEXT_GET_APP_VERSION_FAILED = "LOGIN_TEXT_GET_APP_VERSION_FAILED"; // Metadata: 0x0263D940
		public const string LOGIN_TEXT_ALERT_CARRIER_NETWORK = "LOGIN_TEXT_ALERT_CARRIER_NETWORK"; // Metadata: 0x0263D962
		public const string LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED = "LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED"; // Metadata: 0x0263D983
		public const string LOGIN_SHADER_WARM_UP_PRELOAD_RES = "LOGIN_SHADER_WARM_UP_PRELOAD_RES"; // Metadata: 0x0263D9B2
		public const string LOGIN_GAME_UPDATE_TIPS_DOWNLOADING = "LOGIN_GAME_UPDATE_TIPS_DOWNLOADING"; // Metadata: 0x0263D9D3
		public const string LOGIN_GAME_UPDATE_TIPS_PAUSE = "LOGIN_GAME_UPDATE_TIPS_PAUSE"; // Metadata: 0x0263D9F6
		public const string LOGIN_GAME_UPDATE_ALERT_NEWER = "LOGIN_GAME_UPDATE_ALERT_NEWER"; // Metadata: 0x0263DA13
		public const string LOGIN_GAME_UPDATE_ERROR_DISK_FULL = "LOGIN_GAME_UPDATE_ERROR_DISK_FULL"; // Metadata: 0x0263DA31
		public const string LOGIN_GAME_UPDATE_ALERT_SUC = "LOGIN_GAME_UPDATE_ALERT_SUC"; // Metadata: 0x0263DA53
		public const string LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON = "LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON"; // Metadata: 0x0263DA6F
		public const string LOGIN_GAME_UPDATE_ERROR_COMMON = "LOGIN_GAME_UPDATE_ERROR_COMMON"; // Metadata: 0x0263DA9F
		public const string LOGIN_GAME_UPDATE_TITLE = "LOGIN_GAME_UPDATE_TITLE"; // Metadata: 0x0263DABE
		public const string LOGIN_GOTO_SHOP_FOR_GAME_UPDATE = "LOGIN_GOTO_SHOP_FOR_GAME_UPDATE"; // Metadata: 0x0263DAD6
		public const string LOGIN_SDK_INIT_FAILED = "LOGIN_SDK_INIT_FAILED"; // Metadata: 0x0263DAF6
		public const string LOGIN_DOWNLOADING_SPEED_HINT = "LOGIN_DOWNLOADING_SPEED_HINT"; // Metadata: 0x0263DB0C
		public const string LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME = "LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME"; // Metadata: 0x0263DB29
		public const string LOGIN_NETWORK_CONGESTION_TITLE = "LOGIN_NETWORK_CONGESTION_TITLE"; // Metadata: 0x0263DB4E
		public const string LOGIN_LOW_SCORE_DEVICE_TIP = "LOGIN_LOW_SCORE_DEVICE_TIP"; // Metadata: 0x0263DB6D
		public const string LOGIN_LOW_SCORE_DEVICE_CLOUD_GAME_TIP = "LOGIN_LOW_SCORE_DEVICE_CLOUD_GAME_TIP"; // Metadata: 0x0263DB88
		public const string LOGIN_STARTUP_GPU_DRIVER_NEEDS_UPDATE = "LOGIN_STARTUP_GPU_DRIVER_NEEDS_UPDATE"; // Metadata: 0x0263DBAE
		public const string LOGIN_STARTUP_BIOS_NEEDS_UPDATE = "LOGIN_STARTUP_BIOS_NEEDS_UPDATE"; // Metadata: 0x0263DBD4
		public const string LOGIN_STARTUP_INSTALL_ON_HDD = "LOGIN_STARTUP_INSTALL_ON_HDD"; // Metadata: 0x0263DBF4
		public const string LOGIN_REGISTRY_WRITE_FAILED = "LOGIN_REGISTRY_WRITE_FAILED"; // Metadata: 0x0263DC11
		public const string LOGIN_PRE_DOWNLOAD_AVAILABLE = "LOGIN_PRE_DOWNLOAD_AVAILABLE"; // Metadata: 0x0263DC2D
		public const string LOGIN_PRE_DOWNLOAD_CONTINUE = "LOGIN_PRE_DOWNLOAD_CONTINUE"; // Metadata: 0x0263DC4A
		public const string LOGIN_PRE_DOWNLOAD_COMPLETED = "LOGIN_PRE_DOWNLOAD_COMPLETED"; // Metadata: 0x0263DC66
		public const string LOGIN_PRE_DOWNLOAD_PAUSE = "LOGIN_PRE_DOWNLOAD_PAUSE"; // Metadata: 0x0263DC83
		public const string LOGIN_PRE_DOWNLOAD_DOWNLOADING = "LOGIN_PRE_DOWNLOAD_DOWNLOADING"; // Metadata: 0x0263DC9C
		public const string LOGIN_PRE_DOWNLOAD_APPLYING = "LOGIN_PRE_DOWNLOAD_APPLYING"; // Metadata: 0x0263DCBB
		public const string LOGIN_PRE_DOWNLOAD_ERROR_COMMON = "LOGIN_PRE_DOWNLOAD_ERROR_COMMON"; // Metadata: 0x0263DCD7
		public const string LOGIN_PRE_DOWNLOAD_DISK_ERROR = "LOGIN_PRE_DOWNLOAD_DISK_ERROR"; // Metadata: 0x0263DCF7
		public const string LOGIN_PRE_DOWNLOAD_APPLY_ERROR_COMMON = "LOGIN_PRE_DOWNLOAD_APPLY_ERROR_COMMON"; // Metadata: 0x0263DD15
		public const string LOGIN_PRE_DOWNLOAD_CONFIRM_AVAILABLE = "LOGIN_PRE_DOWNLOAD_CONFIRM_AVAILABLE"; // Metadata: 0x0263DD3B
		public const string LOGIN_PRE_DOWNLOAD_CONFIRM_CONTINUE = "LOGIN_PRE_DOWNLOAD_CONFIRM_CONTINUE"; // Metadata: 0x0263DD60
		public const string LOGIN_PRE_DOWNLOAD_CONFIRM_PAUSE = "LOGIN_PRE_DOWNLOAD_CONFIRM_PAUSE"; // Metadata: 0x0263DD84
		public const string LOGIN_PRE_DOWNLOAD_TOAST_COMPLETED = "LOGIN_PRE_DOWNLOAD_TOAST_COMPLETED"; // Metadata: 0x0263DDA5
		public const string LOGIN_SUCCESS_TOAST = "LOGIN_SUCCESS_TOAST"; // Metadata: 0x0263DDC8
		public const string LOGIN_PRE_DOWNLOAD_RETRY = "LOGIN_PRE_DOWNLOAD_RETRY"; // Metadata: 0x0263DDDC
		public const string LOGIN_PRE_DOWNLOAD_GIVE_UP = "LOGIN_PRE_DOWNLOAD_GIVE_UP"; // Metadata: 0x0263DDF5
	}

	public class LoginManager : ExplicitSingleton<LoginManager> // TypeDefIndex: 80897
	{
		// Fields
		public const long MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI = 104857600; // Metadata: 0x0263DE10
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
		public bool quickStart { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public bool firstLogin { get; } // 0x0000000188CB31FC-0x0000000188CB323C 
	
		// Nested types
		public class AssetLoader : IDisposable // TypeDefIndex: 80879
		{
			// Fields
			private Dictionary<string, FAssetProxyHandle> m_assetHandles; // 0x10
	
			// Constructors
			public AssetLoader(); // 0x00000001871C5270-0x00000001871C52F0
	
			// Methods
			public FAssetProxyHandle CachedLoad<T>(string path)
				where T : UnityEngine.Object;
			public FAssetProxyHandle CachedLoadAsync<T>(string path)
				where T : UnityEngine.Object;
			private bool _CheckDisposedBeforeLoad(string path); // 0x0000000186BAB460-0x0000000186BAB4F0
			public void Dispose(); // 0x0000000186CBD230-0x0000000186CBD4A0
		}
	
		public class FlowWithMaskMgr // TypeDefIndex: 80881
		{
			// Fields
			private LoginContext m_context; // 0x10
			private HashSet<string> m_activeFlows; // 0x18
	
			// Nested types
			[CompilerGenerated]
			private sealed class __FlowCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 80880
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public FlowWithMaskMgr __4__this; // 0x20
				public FFlowWithMask flow; // 0x28
				private LoginController.MaskCtrl _maskCtrl_5__2; // 0x50
				private bool _isFlowSuc_5__3; // 0x58
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public __FlowCoroutine_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x00000001863F7810-0x00000001863F7AC0
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CB5164-0x0000000188CB51B0
			}
	
			// Constructors
			public FlowWithMaskMgr(LoginContext context); // 0x000000018717CC00-0x000000018717CC90
	
			// Methods
			public void StartFlow(FFlowWithMask flow); // 0x00000001862AFA50-0x00000001862AFB90
			[IteratorStateMachine(typeof(__FlowCoroutine_d__4))]
			private IEnumerator _FlowCoroutine(FFlowWithMask flow); // 0x00000001862AFB90-0x00000001862AFC50
			private void _OnFlowFinished(FFlowWithMask flow); // 0x00000001863F6570-0x00000001863F6600
		}
	
		public struct FFlowWithMask // TypeDefIndex: 80882
		{
			// Fields
			public string key; // 0x00
			public LoginController.EMaskType maskType; // 0x08
			public Func<bool> flowAction; // 0x10
			public FFlowCondition condition; // 0x18
			public float disableDelay; // 0x20
		}
	
		public struct FFlowCondition // TypeDefIndex: 80883
		{
			// Fields
			[CompilerGenerated]
			private LoginWorkFlow.ENode _priTarget_k__BackingField; // 0x00
			[CompilerGenerated]
			private LoginWorkFlow.ENode _secTarget_k__BackingField; // 0x04
	
			// Properties
			public LoginWorkFlow.ENode priTarget { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
			public LoginWorkFlow.ENode secTarget { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
	
			// Constructors
			public FFlowCondition(LoginWorkFlow.ENode target); // 0x0000000187239980-0x0000000187239990
			public FFlowCondition(LoginWorkFlow.ENode first, LoginWorkFlow.ENode second); // 0x00000001827241A0-0x00000001827241B0
	
			// Methods
			public bool IsTargetMatch(LoginWorkFlow.ENode node); // 0x00000001863F7BA0-0x00000001863F7BE0
		}
	
		[CompilerGenerated]
		private sealed class _InitCoroutine_d__17 : IEnumerator<object> // TypeDefIndex: 80884
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public bool quickStart; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _InitCoroutine_d__17(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001871C70F0-0x00000001871C7150
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB4034-0x0000000188CB4080
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80885
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<LoginAlertDialog, LoginAlertDialog.FParams> __9__29_0; // 0x08
			public static Action<LoginVocResSelDialog, LoginVocResSelDialog.FParams> __9__30_0; // 0x10
			public static Action<LoginJudgeDialog, LoginJudgeDialog.FParams> __9__36_0; // 0x18
	
			// Constructors
			static __c(); // 0x0000000188CB49B0-0x0000000188CB4A14
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _AlertDialog_b__29_0(LoginAlertDialog param1, LoginAlertDialog.FParams param2); // 0x0000000188CB43A8-0x0000000188CB43D8
			internal void _VocResSelDialog_b__30_0(LoginVocResSelDialog param1, LoginVocResSelDialog.FParams param2); // 0x0000000188CB4580-0x0000000188CB45A0
			internal void __StartShowJudgeDialogCoroutine_b__36_0(LoginJudgeDialog param1, LoginJudgeDialog.FParams param2); // 0x0000000188CB4608-0x0000000188CB464C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 80886
		{
			// Fields
			public object wait; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _VocResSelDialogWithConfirm_b__0(); // 0x00000001863017D0-0x00000001863017F0
		}
	
		[CompilerGenerated]
		private sealed class _VocResSelDialogWithConfirm_d__31 : IEnumerator<object> // TypeDefIndex: 80887
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			private __c__DisplayClass31_0 __8__1; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _VocResSelDialogWithConfirm_d__31(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CB4A14-0x0000000188CB4B58
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB4B58-0x0000000188CB4BA4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 80888
		{
			// Fields
			public Beyond.Misc.ObjectRef outRef; // 0x10
			public Action<Beyond.Misc.ObjectRef> callback; // 0x18
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _AlertDialogWithResult_b__0(); // 0x0000000188CB464C-0x0000000188CB4690
		}
	
		[CompilerGenerated]
		private sealed class _AlertDialogWithResult_d__32 : IEnumerator<object> // TypeDefIndex: 80889
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Beyond.Misc.ObjectRef outRef; // 0x20
			public Action<Beyond.Misc.ObjectRef> callback; // 0x28
			public LoginManager __4__this; // 0x30
			public string desc; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _AlertDialogWithResult_d__32(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CB3C5C-0x0000000188CB3DBC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB3DBC-0x0000000188CB3E08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 80890
		{
			// Fields
			public object wait; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _AlertDialogWithConfirm_b__0(); // 0x00000001863017D0-0x00000001863017F0
		}
	
		[CompilerGenerated]
		private sealed class _AlertDialogWithConfirm_d__33 : IEnumerator<object> // TypeDefIndex: 80891
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public string desc; // 0x28
			private __c__DisplayClass33_0 __8__1; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _AlertDialogWithConfirm_d__33(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CB3AB8-0x0000000188CB3C10
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB3C10-0x0000000188CB3C5C
		}
	
		[CompilerGenerated]
		private sealed class __ShowDialogCoroutine_d__37<TDialog, TParam> : IEnumerator<object> // TypeDefIndex: 80892
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
		private sealed class __c__DisplayClass39_0 // TypeDefIndex: 80893
		{
			// Fields
			public Action callback; // 0x10
	
			// Constructors
			public __c__DisplayClass39_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _MockManualSelectServer_b__0(string _); // 0x0000000184221010-0x0000000184221020
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0 // TypeDefIndex: 80894
		{
			// Fields
			public LoginController controller; // 0x10
			public LoginManager __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass40_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __Init_b__0(); // 0x0000000187090820-0x0000000187090860
		}
	
		[CompilerGenerated]
		private sealed class __LoginWorkFlowCoroutine_d__43 : IEnumerator<object> // TypeDefIndex: 80895
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public LoginController nullableCtrl; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __LoginWorkFlowCoroutine_d__43(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000185319960-0x0000000185319AA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB5248-0x0000000188CB5294
		}
	
		[CompilerGenerated]
		private sealed class _FetchRemoteConfigUtilSuc_d__45 : IEnumerator<object> // TypeDefIndex: 80896
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public IRemoteConfig config; // 0x20
			public string configEnv; // 0x28
			public string keyErrorWithCode; // 0x30
			public string keyTimeout; // 0x38
			private FRemoteConfigRequest _request_5__2; // 0x40
			private bool _isServiceSuc_5__3; // 0x88
			private Beyond.Misc.ObjectRef _resultRef_5__4; // 0x90
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _FetchRemoteConfigUtilSuc_d__45(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186A4A910-0x0000000186A4CA80
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB3FE8-0x0000000188CB4034
		}
	
		// Constructors
		public LoginManager(); // 0x0000000186F818D0-0x0000000186F81A10
	
		// Methods
		[IteratorStateMachine(typeof(_InitCoroutine_d__17))]
		public IEnumerator InitCoroutine(bool quickStart); // 0x00000001867A4190-0x00000001867A4220
		public bool IsReLoginInProgress(); // 0x0000000188CB28DC-0x0000000188CB29F8
		public static void OnReleaseMainGame(); // 0x0000000188CB2CAC-0x0000000188CB2D38
		public bool IsWorkflowInProgress(); // 0x00000001867A4360-0x00000001867A4390
		public void ClearSync(); // 0x0000000188CB2600-0x0000000188CB265C
		public void Clear(); // 0x00000001853195F0-0x0000000185319640
		private void _ReleaseLoginScene(); // 0x0000000185319300-0x00000001853193E0
		public void InvokeWhenWorkFlowFinished(Action callback); // 0x00000001867A4390-0x00000001867A43D0
		public void SceneComponentOnly_Bind(LoginSceneComponent comp); // 0x00000001867A2A60-0x00000001867A2B90
		private void _BindPendingComponents(); // 0x0000000185319720-0x0000000185319900
		public void ToggleLoginBindingGroup(bool enable); // 0x0000000188CB2D38-0x0000000188CB2DFC
		public void AlertDialog(string desc, Action callback = null); // 0x0000000188CB2418-0x0000000188CB2600
		public void VocResSelDialog(Action callback = null); // 0x0000000188CB2E94-0x0000000188CB3034
		[IteratorStateMachine(typeof(_VocResSelDialogWithConfirm_d__31))]
		public IEnumerator VocResSelDialogWithConfirm(); // 0x0000000188CB2DFC-0x0000000188CB2E94
		[IteratorStateMachine(typeof(_AlertDialogWithResult_d__32))]
		public IEnumerator AlertDialogWithResult(string desc, Beyond.Misc.ObjectRef outRef, Action<Beyond.Misc.ObjectRef> callback = null); // 0x0000000188CB232C-0x0000000188CB2418
		[IteratorStateMachine(typeof(_AlertDialogWithConfirm_d__33))]
		public IEnumerator AlertDialogWithConfirm(string desc); // 0x0000000188CB2274-0x0000000188CB232C
		[IDTag(0)]
		public void JudgeDialog(string desc, Action onPositive, Action onNegative); // 0x0000000188CB2A80-0x0000000188CB2B50
		[IDTag(1)]
		public void JudgeDialog(LoginJudgeDialog.FParams param); // 0x0000000188CB29F8-0x0000000188CB2A80
		private void _StartShowJudgeDialogCoroutine(LoginJudgeDialog.FParams param); // 0x0000000188CB3034-0x0000000188CB31FC
		[IteratorStateMachine(typeof(__ShowDialogCoroutine_d__37<TDialog, TParam>))]
		private IEnumerator _ShowDialogCoroutine<TDialog, TParam>(string resPath, TParam param, Action<TDialog, TParam> setParamFunc)
			where TDialog : LoginController.Dialog;
		public void MockLoginWithCallback(Action<string> callback); // 0x000000018709E160-0x000000018709E250
		public void MockManualSelectServer(string uid, Action callback); // 0x0000000188CB2B50-0x0000000188CB2CAC
		private void _Init(); // 0x00000001867A4920-0x00000001867A7CA0
		public bool IsLoginSceneLoading(); // 0x00000001867A2C70-0x00000001867A2CD0
		private void _PrepareBeforeLoginProcess(); // 0x00000001863E34F0-0x00000001863E3580
		[IteratorStateMachine(typeof(__LoginWorkFlowCoroutine_d__43))]
		private IEnumerator _LoginWorkFlowCoroutine(LoginController nullableCtrl); // 0x0000000187090860-0x0000000187090900
		private void _ClearWorkflowAndContext(bool isShutDownMode); // 0x0000000185319640-0x0000000185319720
		[IteratorStateMachine(typeof(_FetchRemoteConfigUtilSuc_d__45))]
		public static IEnumerator FetchRemoteConfigUtilSuc(IRemoteConfig config, string configEnv, string keyErrorWithCode, string keyTimeout); // 0x00000001869C07D0-0x00000001869C0890
		private static string _ExtractErrorInfo(HttpSender.Result result, string keyErrorWithCode, string keyTimeout); // 0x0000000186A4A870-0x0000000186A4A910
		[Conditional("DEVELOPMENT_BUILD")]
		public static void DevOnlyCheckEnableLocalResMode(ref bool enable); // 0x0000000188CB265C-0x0000000188CB26DC
		[Conditional("DEVELOPMENT_BUILD")]
		public static void DevOnlyUseLocalResVersion(ResVersionDevCfg config, ref bool useLocalResVersion); // 0x0000000188CB26DC-0x0000000188CB28DC
	}

	public class VietnamLoginAgePanel : MonoBehaviour // TypeDefIndex: 80898
	{
		// Fields
		private const string PREFAB_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/AgeTipsPanel.prefab"; // Metadata: 0x0263DE18
		private static FAssetProxyHandle s_prefabAssetHandle; // 0x00
		public static GameObject instance; // 0x18
	
		// Constructors
		public VietnamLoginAgePanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static void Init(); // 0x00000001863F9090-0x00000001863F9100
		public static void UnInit(); // 0x0000000188CB6E40-0x0000000188CB6EBC
		private static void _Init(); // 0x0000000188CB6EBC-0x0000000188CB7144
		private static void _UnInit(); // 0x0000000188CB7144-0x0000000188CB7230
		private void OnApplicationQuit(); // 0x0000000188CB6D4C-0x0000000188CB6E40
	}

	public class VietnamLoginAgeTipsPanelCtrl : MonoBehaviour // TypeDefIndex: 80899
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
		public VietnamLoginAgeTipsPanelCtrl(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void Awake(); // 0x0000000188CB7230-0x0000000188CB7464
		private void _SetStateTips(PointerEventData eventData); // 0x0000000188CB750C-0x0000000188CB7E2C
		private void _SetStateCircle(PointerEventData eventData); // 0x0000000188CB7464-0x0000000188CB750C
	}

	public static class RenderPipelineDataLoader // TypeDefIndex: 80900
	{
		// Fields
		public static FAssetProxyHandle s_globalSettings; // 0x00
		public static FAssetProxyHandle s_pipelineAsset; // 0x14
	
		// Methods
		public static void LoadSimpleRpData(); // 0x0000000185319E50-0x0000000185319F70
		public static void PreloadFullRpResources(); // 0x0000000186BDB8B0-0x0000000186BDBA60
		public static bool IsPreLoadFinished(); // 0x00000001863F91D0-0x00000001863F9290
		public static void LoadFullRpResources(); // 0x0000000185319F70-0x000000018531A0E0
	}

	[DefaultExecutionOrder(22000)]
	public class TailGameLoop : MonoBehaviour // TypeDefIndex: 80901
	{
		// Constructors
		public TailGameLoop(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Update(); // 0x0000000185F5C9F0-0x0000000185F5CA80
		private void LateUpdate(); // 0x00000001858FDC30-0x00000001858FDCC0
	}
}

namespace Beyond.Login
{
	public class LoginCheckForUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 80949
	{
		// Fields
		private LoginGameUpdater m_sdk; // 0x20
		private bool m_checkSuccess; // 0x28
		private const string REQUEST_API = "/api/game/get_latest"; // Metadata: 0x0263DFAC
		private const string REQUEST_PARAM_FORMAT = "appcode={0}&channel={1}&version={2}&platform={3}&sub_channel={4}&source={5}"; // Metadata: 0x0263DFC1
		private const string REQUEST_URL_FORMAT = "{0}{1}?{2}"; // Metadata: 0x0263E00E
		private const string PRAM_SOURCE = "game"; // Metadata: 0x0263E019
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65FE0-0x0000000186E66010 
	
		// Nested types
		private class AppVersionRespone // TypeDefIndex: 80940
		{
			// Fields
			public int action; // 0x10
			public int state; // 0x14
	
			// Constructors
			public AppVersionRespone(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __CheckForUpdateCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 80941
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CheckForUpdateCoroutine_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001867A1400-0x00000001867A29F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD5E0-0x0000000188CBD62C
		}
	
		[CompilerGenerated]
		private sealed class __AlertAndQuitForExtraConfigFatalError_d__5 : IEnumerator<object> // TypeDefIndex: 80942
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __AlertAndQuitForExtraConfigFatalError_d__5(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CBD3BC-0x0000000188CBD548
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD548-0x0000000188CBD594
		}
	
		[CompilerGenerated]
		private sealed class __AlertStartupHardwareCheckIfNeeded_d__6 : IEnumerator<object> // TypeDefIndex: 80943
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private HGStartupHardwareCheckResult _result_5__2; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __AlertStartupHardwareCheckIfNeeded_d__6(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001870BF220-0x00000001870BF2C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD594-0x0000000188CBD5E0
		}
	
		[CompilerGenerated]
		private sealed class _AlertNoMatchDeviceBeforeLogin_d__7 : IEnumerator<object> // TypeDefIndex: 80944
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _AlertNoMatchDeviceBeforeLogin_d__7(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186C9B580-0x0000000186C9D110
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBC1D4-0x0000000188CBC220
		}
	
		[CompilerGenerated]
		private sealed class __CheckForUpdateCoroutineMobile_d__9 : IEnumerator<object> // TypeDefIndex: 80945
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			private LoginGameUpdater.Result _result_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CheckForUpdateCoroutineMobile_d__9(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001827669E0-0x0000000182767F30
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182767F30-0x0000000182767F80
		}
	
		[CompilerGenerated]
		private sealed class __CheckForUpdateCoroutinePC_d__11 : IEnumerator<object> // TypeDefIndex: 80946
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CheckForUpdateCoroutinePC_d__11(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182767F80-0x00000001827683B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001827683B0-0x0000000182768400
		}
	
		[CompilerGenerated]
		private sealed class __CheckForUpdatePC_d__12 : IEnumerator<object> // TypeDefIndex: 80947
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			private Beyond.Misc.ObjectRef _actionRef_5__2; // 0x28
			private string _errorInfo_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CheckForUpdatePC_d__12(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182768400-0x000000018276A320
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018276A320-0x000000018276A370
		}
	
		[CompilerGenerated]
		private sealed class __GetOnlineAppVersion_d__14 : IEnumerator<object> // TypeDefIndex: 80948
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			public Beyond.Misc.ObjectRef outRef; // 0x28
			private string _url_5__2; // 0x30
			private WaitForAsyncTask<HttpSender.Result<AppVersionRespone>> _httpResIndex_5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GetOnlineAppVersion_d__14(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182773C00-0x0000000182775CA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182775CA0-0x0000000182775CF0
		}
	
		// Constructors
		public LoginCheckForUpdateNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000186AEC970-0x0000000186AECA80
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutine_d__4))]
		private IEnumerator _CheckForUpdateCoroutine(); // 0x0000000186AECA80-0x0000000186AECB00
		[IteratorStateMachine(typeof(__AlertAndQuitForExtraConfigFatalError_d__5))]
		private IEnumerator _AlertAndQuitForExtraConfigFatalError(); // 0x0000000188CB8320-0x0000000188CB83A8
		[IteratorStateMachine(typeof(__AlertStartupHardwareCheckIfNeeded_d__6))]
		private IEnumerator _AlertStartupHardwareCheckIfNeeded(); // 0x00000001871D4100-0x00000001871D4170
		[IteratorStateMachine(typeof(_AlertNoMatchDeviceBeforeLogin_d__7))]
		public static IEnumerator AlertNoMatchDeviceBeforeLogin(); // 0x00000001871DD010-0x00000001871DD070
		private static bool _ShouldUseCloudGameLowScoreTip(); // 0x000000018275F060-0x000000018275F090
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutineMobile_d__9))]
		private IEnumerator _CheckForUpdateCoroutineMobile(); // 0x0000000188CB83A8-0x0000000188CB8440
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutinePC_d__11))]
		private IEnumerator _CheckForUpdateCoroutinePC(); // 0x0000000187180F10-0x0000000187180F90
		[IteratorStateMachine(typeof(__CheckForUpdatePC_d__12))]
		private IEnumerator _CheckForUpdatePC(); // 0x0000000187180E90-0x0000000187180F10
		[IteratorStateMachine(typeof(__GetOnlineAppVersion_d__14))]
		private IEnumerator _GetOnlineAppVersion(Beyond.Misc.ObjectRef outRef); // 0x0000000187110080-0x0000000187110120
		private string _GetRequestPram(); // 0x00000001861449C0-0x0000000186144BD0
	}

	public class LoginCreateRoleNode : LoginWorkFlow.Node // TypeDefIndex: 80951
	{
		// Fields
		public const string LUA_SYS_NAME = "LeadingCharacter"; // Metadata: 0x0263E01E
		private WorkProcess m_activeProcess; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65FB0-0x0000000186E65FE0 
	
		// Nested types
		private class WorkProcess : CustomYieldInstruction, IDisposable // TypeDefIndex: 80950
		{
			// Fields
			private LoginCreateRoleNode m_closure; // 0x10
			private bool m_isFinished; // 0x18
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000188CBE458-0x0000000188CBE494 
	
			// Constructors
			public WorkProcess(LoginCreateRoleNode closure); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public void Dispose(); // 0x0000000188CBE3EC-0x0000000188CBE458
		}
	
		// Constructors
		public LoginCreateRoleNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void OnDispose(); // 0x0000000186BBC660-0x0000000186BBC6C0
		public override bool CanCancel(); // 0x0000000188CB8440-0x0000000188CB8480
		public override CustomYieldInstruction Work(); // 0x00000001870DB2B0-0x00000001870DB360
		public void __iFixBaseProxy_OnDispose(); // 0x0000000188CB8488-0x0000000188CB8490
		public bool __iFixBaseProxy_CanCancel(); // 0x0000000188CB8480-0x0000000188CB8488
	}

	public class LoginDownloadTask : IDisposable // TypeDefIndex: 80956
	{
		// Fields
		private bool m_isDownloadFinished; // 0x10
		private HGDownloader.TaskHandler m_downloadTask; // 0x18
		private FResourceDiff m_resDiff; // 0x20
		private LocalResPref m_localResPref; // 0x60
		private string m_patchInfo; // 0x68
		private IEnumerator m_mockCoroutine; // 0x70
		private bool m_isInitial; // 0x78
		private bool m_resRepairMode; // 0x79
		[CompilerGenerated]
		private string _vitalError_k__BackingField; // 0x80
		private NetUsagePolicy m_netUsagePolicy; // 0x88
	
		// Properties
		public string vitalError { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 80952
		{
			// Fields
			public long totalDownloadSize; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __StartDownload_b__0(bool accepted); // 0x0000000188CBD14C-0x0000000188CBD1BC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 80953
		{
			// Fields
			public LoginDownloadTask __4__this; // 0x10
			public HGDownloader.PauseReason reason; // 0x18
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnDownloadPaused_b__1(); // 0x0000000188CBD1BC-0x0000000188CBD1E4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_1 // TypeDefIndex: 80954
		{
			// Fields
			public long remainDownloadSize; // 0x10
	
			// Constructors
			public __c__DisplayClass26_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnDownloadPaused_b__2(bool accepted); // 0x0000000188CBD1E4-0x0000000188CBD254
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80955
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__26_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188CBD30C-0x0000000188CBD370
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnDownloadPaused_b__26_0(); // 0x0000000188CBD104-0x0000000188CBD128
		}
	
		// Constructors
		public LoginDownloadTask(FResourceDiff resDiff, LocalResPref localResPref, string patchInfo, bool isInitial, NetUsagePolicy netUsagePolicy, bool resRepairMode = false /* Metadata: 0x0263E02F */); // 0x000000018275F0E0-0x000000018275F270
	
		// Methods
		public HGDownloader.DownloadProgress GetDownloadProgress(); // 0x00000001868E30C0-0x00000001868E3110
		public float GetDecompressProgress(); // 0x0000000186C7BA90-0x0000000186C7BAD0
		public float GetCheckProgress(); // 0x000000018275F090-0x000000018275F0E0
		public HGDownloader.WorkState GetWorkState(); // 0x0000000186220CF0-0x0000000186220D40
		public bool Tick(); // 0x0000000186222B90-0x0000000186222BE0
		public void Dispose(); // 0x0000000186FCECE0-0x0000000186FCEE70
		private void _StartDownload(); // 0x000000018614CE70-0x000000018614D1F0
		private void _StartDownloadImpl(); // 0x0000000186C57810-0x0000000186C596A0
		private List<HGFolder> _GetAllFileList(LocalResPref localResPref); // 0x000000018614D380-0x000000018614D9A0
		private List<HGFileInfo> _GetFileList(string rootUrl); // 0x000000018614CC50-0x000000018614CE70
		private void _OnDownloadFinish(); // 0x0000000187226010-0x0000000187226040
		private bool _OnDownloadError(HGRetCodeType codeType, int errorCode); // 0x0000000188CB8490-0x0000000188CB86B0
		private void _OnDownloadPaused(HGDownloader.PauseReason reason); // 0x0000000188CB86B0-0x0000000188CB8994
	}

	public class LoginGameUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 80959
	{
		// Fields
		private LoginGameUpdater m_sdk; // 0x20
		private NetUsagePolicy m_netUsagePolicy; // 0x28
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65F50-0x0000000186E65F80 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __GameUpdateCoroutine_d__5 : IEnumerator<object> // TypeDefIndex: 80957
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GameUpdateCoroutine_d__5(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001870F8D80-0x00000001870F8D90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD944-0x0000000188CBD990
		}
	
		[CompilerGenerated]
		private sealed class __GameUpdateCoroutineMobileImpl_d__6 : IEnumerator<object> // TypeDefIndex: 80958
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdateNode __4__this; // 0x20
			private LoginGameUpdater.Result _result_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GameUpdateCoroutineMobileImpl_d__6(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CBD710-0x0000000188CBD8F8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD8F8-0x0000000188CBD944
		}
	
		// Constructors
		public LoginGameUpdateNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000186AECB00-0x0000000186AECC10
		[IteratorStateMachine(typeof(__GameUpdateCoroutine_d__5))]
		private IEnumerator _GameUpdateCoroutine(); // 0x0000000186AECC10-0x0000000186AECC80
		[IteratorStateMachine(typeof(__GameUpdateCoroutineMobileImpl_d__6))]
		private IEnumerator _GameUpdateCoroutineMobileImpl(); // 0x0000000188CB9370-0x0000000188CB9408
	}

	public class LoginGameUpdater // TypeDefIndex: 81000
	{
		// Fields
		private const float COOLDOWN_INSTALL = 1f; // Metadata: 0x0263E030
		private const int ERROR_CODE_NETWORK = 1103; // Metadata: 0x0263E034
		private const int ERROR_INIT_FAILED = -11101; // Metadata: 0x0263E036
		private const int ERROR_DESERIALIZE_FAILED = -10001; // Metadata: 0x0263E03A
		public const int ERROR_ACTION = -20000; // Metadata: 0x0263E03E
		private const int WAIT_TIME_SECONDS_MIN = 5; // Metadata: 0x0263E042
		private const int WAIT_TIME_SECONDS_MAX = 9; // Metadata: 0x0263E043
		private const int APPLY_PRELOAD_PROGRESS_MAX = 10000; // Metadata: 0x0263E044
		private Options m_options; // 0x10
		private IGameUpdateInterface m_sdkImpl; // 0x28
		private bool m_hasUpdateAlerted; // 0x30
		private HGLatestGameInfo m_latestGameInfo; // 0x38
		private long m_cachedEstimatedPreDownloadSize; // 0x40
		private LoginProgress m_progress; // 0x48
		private LoginHotUpdateProp m_hotUpdateProp; // 0x50
	
		// Nested types
		public enum CodeType // TypeDefIndex: 80960
		{
			CODE_2100 = 2100,
			CODE_2102 = 2102,
			CODE_2103 = 2103,
			CODE_2105 = 2105,
			CODE_2109 = 2109,
			CODE_2117 = 2117,
			CODE_2118 = 2118,
			CODE_2200 = 2200,
			CODE_2201 = 2201,
			CODE_2202 = 2202,
			CODE_2203 = 2203,
			CODE_2204 = 2204,
			CODE_2205 = 2205,
			CODE_2206 = 2206,
			CODE_2207 = 2207,
			CODE_2208 = 2208,
			CODE_2209 = 2209,
			CODE_2211 = 2211,
			CODE_2212 = 2212
		}
	
		public enum UpdateType // TypeDefIndex: 80961
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
	
		public enum UpdateCode // TypeDefIndex: 80962
		{
			Success = 0
		}
	
		public enum UpdateAction // TypeDefIndex: 80963
		{
			Invalid = -1,
			Latest = 0,
			ForcedUpdate = 1,
			OptionalUpdate = 2,
			Error = 3,
			Congestion = 200
		}
	
		public enum ResAction // TypeDefIndex: 80964
		{
			None = 0,
			Available = 1,
			CompletedOnOldPackage = 2,
			Applicable = 3,
			CreatedNotCompleted = 4
		}
	
		private enum PreDownloadErrorChoice // TypeDefIndex: 80965
		{
			Retry = 0,
			GiveUp = 1
		}
	
		public class HGLatestGameInfo // TypeDefIndex: 80966
		{
			// Fields
			public int code; // 0x10
			public string version; // 0x18
			public int action; // 0x20
			public int updateType; // 0x24
			public string updateInfo; // 0x28
			public int state; // 0x30
			public int resAction; // 0x34
	
			// Constructors
			public HGLatestGameInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class NotificationTitleConfig // TypeDefIndex: 80967
		{
			// Fields
			public string downloading; // 0x10
			public string pause; // 0x18
	
			// Constructors
			public NotificationTitleConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class HGUpdateConfig // TypeDefIndex: 80968
		{
			// Fields
			public string downloadPath; // 0x10
	
			// Constructors
			public HGUpdateConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public struct Options // TypeDefIndex: 80969
		{
			// Fields
			public NetUsagePolicy netUsagePolicy; // 0x00
			public Action<string, Action> alertDialog; // 0x08
			public LoginContext loginContext; // 0x10
		}
	
		public class Result // TypeDefIndex: 80970
		{
			// Fields
			public bool needRetry; // 0x10
			public string errorInfo; // 0x18
			public int code; // 0x20
			public bool auditing; // 0x24
	
			// Constructors
			public Result(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class PreDownloadResult // TypeDefIndex: 80971
		{
			// Fields
			public string errorInfo; // 0x10
	
			// Constructors
			public PreDownloadResult(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class OperationContext // TypeDefIndex: 80972
		{
			// Fields
			public long taskId; // 0x10
			public string errorInfo; // 0x18
			public string logError; // 0x20
			public bool needClear; // 0x28
			[CompilerGenerated]
			private bool _complete_k__BackingField; // 0x29
			[CompilerGenerated]
			private int _code_k__BackingField; // 0x2C
	
			// Properties
			public bool complete { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
			public int code { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
	
			// Constructors
			public OperationContext(); // 0x0000000188CBC0BC-0x0000000188CBC124
	
			// Methods
			public void CompleteWithCode(int pCode); // 0x0000000188CBC044-0x0000000188CBC080
			public void UncompleteWithCode(int pCode); // 0x0000000188CBC080-0x0000000188CBC0BC
		}
	
		private class PreDownloadDownloadContext : OperationContext // TypeDefIndex: 80973
		{
			// Fields
			public int lastStatus; // 0x30
			public int lastProgressStep; // 0x34
			public int observedCancelCode; // 0x38
			public int lastPauseStatus; // 0x3C
			public long lastDownloadedSize; // 0x40
			public long lastTotalSize; // 0x48
			public bool eventLogProgress5; // 0x50
			public bool eventLogProgress25; // 0x51
			public bool eventLogProgress50; // 0x52
			public bool eventLogProgress75; // 0x53
			public bool eventLogProgress90; // 0x54
	
			// Constructors
			public PreDownloadDownloadContext(); // 0x0000000188CBC178-0x0000000188CBC190
	
			// Methods
			public void ResetTaskTrackState(int realProgress, long curSize, long totalSize); // 0x000000018275F270-0x000000018275F660
			public void UpdateSizeTrackState(long curSize, long totalSize); // 0x000000018275F660-0x000000018275F6C0
		}
	
		private class PreDownloadApplyContext : OperationContext // TypeDefIndex: 80974
		{
			// Fields
			public int lastStatus; // 0x30
			public int lastProgressStep; // 0x34
			public bool eventLogProgress5; // 0x38
			public bool eventLogProgress25; // 0x39
			public bool eventLogProgress50; // 0x3A
			public bool eventLogProgress75; // 0x3B
			public bool eventLogProgress90; // 0x3C
	
			// Constructors
			public PreDownloadApplyContext(); // 0x0000000188CBC168-0x0000000188CBC178
	
			// Methods
			public void ResetTaskTrackState(); // 0x0000000188CBC124-0x0000000188CBC168
		}
	
		[CompilerGenerated]
		private sealed class _CheckLastGameInfo_d__30 : IEnumerator<object> // TypeDefIndex: 80975
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Result result; // 0x28
			private OperationContext _context_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _CheckLastGameInfo_d__30(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CBC5B0-0x0000000188CBC814
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBC814-0x0000000188CBC860
		}
	
		[CompilerGenerated]
		private sealed class _DoUpdate_d__36 : IEnumerator<object> // TypeDefIndex: 80976
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Result result; // 0x28
			private OperationContext _context_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DoUpdate_d__36(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CBC860-0x0000000188CBCC70
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBCC70-0x0000000188CBCCBC
		}
	
		[CompilerGenerated]
		private sealed class _ApplyPreDownload_d__37 : IEnumerator<object> // TypeDefIndex: 80977
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public PreDownloadResult result; // 0x28
			private PreDownloadApplyContext _context_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _ApplyPreDownload_d__37(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CBC220-0x0000000188CBC564
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBC564-0x0000000188CBC5B0
		}
	
		[CompilerGenerated]
		private sealed class _DownloadPreDownload_d__38 : IEnumerator<object> // TypeDefIndex: 80978
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public PreDownloadResult result; // 0x28
			private PreDownloadDownloadContext _context_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DownloadPreDownload_d__38(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CBCCBC-0x0000000188CBD0B8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD0B8-0x0000000188CBD104
		}
	
		[CompilerGenerated]
		private sealed class __GetLastGameInfo_d__39 : IEnumerator<object> // TypeDefIndex: 80979
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public OperationContext context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GetLastGameInfo_d__39(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001827712E0-0x0000000182773BB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182773BB0-0x0000000182773C00
		}
	
		[CompilerGenerated]
		private sealed class __UpdateGame_d__41 : IEnumerator<object> // TypeDefIndex: 80980
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public OperationContext context; // 0x28
			private HGLatestGameInfo _gameInfo_5__2; // 0x30
			private long _size_5__3; // 0x38
			private bool _enableMobileData_5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __UpdateGame_d__41(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182778CB0-0x000000018277BE00
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018277BE00-0x000000018277BE50
		}
	
		[CompilerGenerated]
		private sealed class __DoTaskUpdating_d__42 : IEnumerator<object> // TypeDefIndex: 80981
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public OperationContext context; // 0x28
			private long _taskId_5__2; // 0x30
			private int _status_5__3; // 0x38
			private long _curSize_5__4; // 0x40
			private long _totalSize_5__5; // 0x48
			private long _speed_5__6; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DoTaskUpdating_d__42(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018276A370-0x000000018276D130
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018276D130-0x000000018276D180
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 80982
		{
			// Fields
			public bool shouldRetryCreate; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DownloadPreDownload_b__1(PreDownloadErrorChoice outChoice); // 0x000000018275FD60-0x000000018275FD70
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_1 // TypeDefIndex: 80983
		{
			// Fields
			public int cancelResult; // 0x10
	
			// Constructors
			public __c__DisplayClass43_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DownloadPreDownload_b__2(int outResult); // 0x0000000182234E90-0x0000000182234EA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_2 // TypeDefIndex: 80984
		{
			// Fields
			public bool shouldRetry; // 0x10
			public int cancelResult; // 0x14
	
			// Constructors
			public __c__DisplayClass43_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DownloadPreDownload_b__4(PreDownloadErrorChoice outChoice); // 0x000000018275FD60-0x000000018275FD70
			internal void __DownloadPreDownload_b__5(int outResult); // 0x000000018275FD70-0x000000018275FD80
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80985
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<bool> __9__43_0; // 0x08
			public static Action<bool> __9__43_3; // 0x10
	
			// Constructors
			static __c(); // 0x0000000188CBD2A8-0x0000000188CBD30C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DownloadPreDownload_b__43_0(bool accepted); // 0x000000018275F6C0-0x000000018275FA10
			internal void __DownloadPreDownload_b__43_3(bool accepted); // 0x000000018275FA10-0x000000018275FD60
		}
	
		[CompilerGenerated]
		private sealed class __DownloadPreDownload_d__43 : IEnumerator<object> // TypeDefIndex: 80986
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreDownloadDownloadContext context; // 0x20
			public LoginGameUpdater __4__this; // 0x28
			private __c__DisplayClass43_0 __8__1; // 0x30
			private __c__DisplayClass43_1 __8__2; // 0x38
			private __c__DisplayClass43_2 __8__3; // 0x40
			private long _size_5__2; // 0x48
			private bool _enableMobileData_5__3; // 0x50
			private long _taskId_5__4; // 0x58
			private bool _shouldRecreateTask_5__5; // 0x60
			private int _status_5__6; // 0x64
			private long _curSize_5__7; // 0x68
			private long _totalSize_5__8; // 0x70
			private bool _shouldClear_5__9; // 0x78
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DownloadPreDownload_d__43(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018276D180-0x0000000182771290
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182771290-0x00000001827712E0
		}
	
		[CompilerGenerated]
		private sealed class __ApplyPreDownload_d__44 : IEnumerator<object> // TypeDefIndex: 80987
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public PreDownloadApplyContext context; // 0x28
			private string _rootPath_5__2; // 0x30
			private string _basePath_5__3; // 0x38
			private long _taskId_5__4; // 0x40
			private bool _shouldRecreateTask_5__5; // 0x48
			private int _status_5__6; // 0x4C
			private int _progress_5__7; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ApplyPreDownload_d__44(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182760DD0-0x0000000182764990
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182764990-0x00000001827649E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 80988
		{
			// Fields
			public bool wait; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __YieldErrorAlert_b__0(); // 0x000000018275FD80-0x000000018275FD90
		}
	
		[CompilerGenerated]
		private sealed class __YieldErrorAlert_d__52 : IEnumerator<object> // TypeDefIndex: 80989
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public string desc; // 0x28
			private __c__DisplayClass52_0 __8__1; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __YieldErrorAlert_d__52(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018277E7A0-0x000000018277F100
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018277F100-0x000000018277F150
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 80990
		{
			// Fields
			public int errorCode; // 0x10
			public Action<PreDownloadErrorChoice> onChoice; // 0x18
			public bool wait; // 0x20
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __YieldPreDownloadErrorDialog_b__0(); // 0x000000018275FD90-0x0000000182760360
			internal void __YieldPreDownloadErrorDialog_b__1(); // 0x0000000182760360-0x0000000182760930
		}
	
		[CompilerGenerated]
		private sealed class __YieldPreDownloadErrorDialog_d__53 : IEnumerator<object> // TypeDefIndex: 80991
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public int errorCode; // 0x20
			public Action<PreDownloadErrorChoice> onChoice; // 0x28
			private __c__DisplayClass53_0 __8__1; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __YieldPreDownloadErrorDialog_d__53(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018277FAA0-0x0000000182781C50
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182781C50-0x0000000182781FA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 80992
		{
			// Fields
			public long downloadSize; // 0x10
			public Action<bool> onCheckResult; // 0x18
			public bool rejected; // 0x20
			public Action<bool> onCarrierDecision; // 0x28
	
			// Constructors
			public __c__DisplayClass67_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __YieldCheckNetUsagePolicy_b__0(bool accepted); // 0x0000000182760930-0x0000000182760C60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_1 // TypeDefIndex: 80993
		{
			// Fields
			public bool checkResultReported; // 0x10
			public bool complete; // 0x11
			public __c__DisplayClass67_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass67_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __YieldCheckNetUsagePolicy_g__ReportCheckResult_1(bool accepted); // 0x0000000182760D80-0x0000000182760DD0
			internal void __YieldCheckNetUsagePolicy_b__2(); // 0x0000000182760C60-0x0000000182760CC0
			internal void __YieldCheckNetUsagePolicy_b__3(); // 0x0000000182760CC0-0x0000000182760D20
			internal void __YieldCheckNetUsagePolicy_b__4(); // 0x0000000182760C60-0x0000000182760CC0
			internal void __YieldCheckNetUsagePolicy_b__5(bool accepted); // 0x0000000182760D20-0x0000000182760D80
		}
	
		[CompilerGenerated]
		private sealed class __YieldCheckNetUsagePolicy_d__67 : IEnumerator<object> // TypeDefIndex: 80994
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public long downloadSize; // 0x20
			public Action<bool> onCheckResult; // 0x28
			private __c__DisplayClass67_0 __8__1; // 0x30
			public LoginGameUpdater __4__this; // 0x38
			private __c__DisplayClass67_1 __8__2; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __YieldCheckNetUsagePolicy_d__67(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018277CF20-0x000000018277E750
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018277E750-0x000000018277E7A0
		}
	
		[CompilerGenerated]
		private sealed class __WaitForTaskCancel_d__68 : IEnumerator<object> // TypeDefIndex: 80995
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public long taskId; // 0x20
			public LoginGameUpdater __4__this; // 0x28
			private int _status_5__2; // 0x30
			private bool _isCanceled_5__3; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __WaitForTaskCancel_d__68(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018277BE50-0x000000018277CED0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018277CED0-0x000000018277CF20
		}
	
		[CompilerGenerated]
		private sealed class __CancelAndClearTask_d__69 : IEnumerator<object> // TypeDefIndex: 80996
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public long taskId; // 0x20
			public LoginGameUpdater __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CancelAndClearTask_d__69(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001827649E0-0x0000000182765A60
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182765A60-0x0000000182765AB0
		}
	
		[CompilerGenerated]
		private sealed class __CancelPreDownloadTask_d__70 : IEnumerator<object> // TypeDefIndex: 80997
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public long taskId; // 0x20
			public bool shouldClear; // 0x28
			public LoginGameUpdater __4__this; // 0x30
			public Action<int> onResult; // 0x38
			private int _cancelResult_5__2; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CancelPreDownloadTask_d__70(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182765AB0-0x0000000182766990
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182766990-0x00000001827669E0
		}
	
		[CompilerGenerated]
		private sealed class __RefreshPreDownloadResAction_d__71 : IEnumerator<object> // TypeDefIndex: 80998
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public OperationContext context; // 0x28
			private HGLatestGameInfo _oldGameInfo_5__2; // 0x30
			private int _oldResAction_5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __RefreshPreDownloadResAction_d__71(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000182775CF0-0x0000000182778C60
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182778C60-0x0000000182778CB0
		}
	
		[CompilerGenerated]
		private sealed class __YieldGameUpdateInfoChangedAndQuit_d__73 : IEnumerator<object> // TypeDefIndex: 80999
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __YieldGameUpdateInfoChangedAndQuit_d__73(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018277F150-0x000000018277FA50
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018277FA50-0x000000018277FAA0
		}
	
		// Constructors
		public LoginGameUpdater(Options options); // 0x000000018710FFE0-0x0000000187110080
	
		// Methods
		public void Clear(); // 0x0000000186AED190-0x0000000186AED840
		[IteratorStateMachine(typeof(_CheckLastGameInfo_d__30))]
		public IEnumerator CheckLastGameInfo(Result result); // 0x0000000188CB94C0-0x0000000188CB9578
		public ResAction GetResAction(); // 0x000000018614E810-0x000000018614E8A0
		public void RefreshEstimatedPreDownloadSize(ResAction resAction); // 0x0000000188CB9910-0x0000000188CB9A7C
		public long GetCachedEstimatedPreDownloadSize(); // 0x0000000188CB96E8-0x0000000188CB9778
		public static bool IsPreDownloadEnabled(); // 0x000000018614E770-0x000000018614E7E0
		public static bool IsPreDownloadSupportedOnCurrentPlatform(); // 0x000000018614E7E0-0x000000018614E810
		[IteratorStateMachine(typeof(_DoUpdate_d__36))]
		public IEnumerator DoUpdate(Result result); // 0x0000000188CB9578-0x0000000188CB9630
		[IteratorStateMachine(typeof(_ApplyPreDownload_d__37))]
		public IEnumerator ApplyPreDownload(PreDownloadResult result); // 0x0000000188CB9408-0x0000000188CB94C0
		[IteratorStateMachine(typeof(_DownloadPreDownload_d__38))]
		public IEnumerator DownloadPreDownload(PreDownloadResult result); // 0x0000000188CB9630-0x0000000188CB96E8
		[IteratorStateMachine(typeof(__GetLastGameInfo_d__39))]
		private IEnumerator _GetLastGameInfo(OperationContext context); // 0x0000000188CBA730-0x0000000188CBA7E8
		private bool _TryGetLatestGameInfo(OperationContext context, out HGLatestGameInfo gameInfo); // 0x0000000188CBB6B4-0x0000000188CBB788
		[IteratorStateMachine(typeof(__UpdateGame_d__41))]
		private IEnumerator _UpdateGame(OperationContext context); // 0x0000000188CBB788-0x0000000188CBB840
		[IteratorStateMachine(typeof(__DoTaskUpdating_d__42))]
		private IEnumerator _DoTaskUpdating(OperationContext context); // 0x0000000188CB9FC0-0x0000000188CBA078
		[IteratorStateMachine(typeof(__DownloadPreDownload_d__43))]
		private IEnumerator _DownloadPreDownload(PreDownloadDownloadContext context); // 0x0000000188CBA078-0x0000000188CBA130
		[IteratorStateMachine(typeof(__ApplyPreDownload_d__44))]
		private IEnumerator _ApplyPreDownload(PreDownloadApplyContext context); // 0x0000000188CB9BBC-0x0000000188CB9C74
		private void _OnDownloadStart(); // 0x0000000188CBB2B4-0x0000000188CBB3FC
		private void _OnDownloadProgress(long curSize, long totalSize, long speed); // 0x0000000188CBB1B0-0x0000000188CBB2B4
		private void _OnPreDownloadDownloadStart(); // 0x0000000188CBB3FC-0x0000000188CBB594
		private void _OnApplyPreDownloadStart(); // 0x0000000188CBB010-0x0000000188CBB1B0
		private void _OnApplyPreDownloadProgress(int progress); // 0x0000000188CBAF18-0x0000000188CBB010
		[IteratorStateMachine(typeof(__YieldErrorAlert_d__52))]
		private IEnumerator _YieldErrorAlert(string desc); // 0x0000000188CBB9B8-0x0000000188CBBA70
		[IteratorStateMachine(typeof(__YieldPreDownloadErrorDialog_d__53))]
		private IEnumerator _YieldPreDownloadErrorDialog(int errorCode, Action<PreDownloadErrorChoice> onChoice); // 0x0000000188CBBB08-0x0000000188CBBBC4
		private static string _GetPreDownloadErrorInfo(int errorCode); // 0x0000000188CBA7E8-0x0000000188CBA924
		private static bool _ShouldClearPreDownloadTask(int errorCode); // 0x0000000188CBB64C-0x0000000188CBB6B4
		private static void _LogPreDownloadStatusChanged(string phase, long taskId, int status, ref int lastStatus); // 0x0000000188CBAE18-0x0000000188CBAF18
		private void _EventLogPreDownloadStart(PreDownloadDownloadContext context, long taskId, long fallbackTotalSize); // 0x0000000188CBA588-0x0000000188CBA6D8
		private static void _EventLogPreDownloadProgress(ref bool sent, long curSize, long totalSize, int target); // 0x0000000188CBA4A0-0x0000000188CBA588
		private static void _EventLogPreDownloadPause(PreDownloadDownloadContext context, long curSize, long totalSize, int statusCode); // 0x0000000188CBA2A8-0x0000000188CBA4A0
		private static void _EventLogPreDownloadFinish(long downloadedSize); // 0x0000000188CBA210-0x0000000188CBA2A8
		private static void _EventLogPreApplyProgress(ref bool sent, int progress, int target); // 0x0000000188CBA130-0x0000000188CBA210
		private static int _GetEventLogProgress(long curSize, long totalSize); // 0x0000000188CBA6D8-0x0000000188CBA730
		private static int _BytesToMB(long bytes); // 0x0000000188CB9C74-0x0000000188CB9CB4
		private static void _LogPreDownloadSizeProgress(long taskId, long curSize, long totalSize, long speed, ref int lastStep); // 0x0000000188CBAC64-0x0000000188CBAE18
		private static void _LogPreDownloadApplyProgress(long taskId, int progress, ref int lastStep); // 0x0000000188CBAAB0-0x0000000188CBAC64
		private bool _ConsumePreDownloadCancelRequest(PreDownloadDownloadContext context); // 0x0000000188CB9E3C-0x0000000188CB9F58
		[IteratorStateMachine(typeof(__YieldCheckNetUsagePolicy_d__67))]
		private IEnumerator _YieldCheckNetUsagePolicy(long downloadSize, Action<bool> onCheckResult = null); // 0x0000000188CBB8EC-0x0000000188CBB9B8
		[IteratorStateMachine(typeof(__WaitForTaskCancel_d__68))]
		private IEnumerator _WaitForTaskCancel(long taskId); // 0x0000000188CBB840-0x0000000188CBB8EC
		[IteratorStateMachine(typeof(__CancelAndClearTask_d__69))]
		private IEnumerator _CancelAndClearTask(long taskId); // 0x0000000188CB9CB4-0x0000000188CB9D60
		[IteratorStateMachine(typeof(__CancelPreDownloadTask_d__70))]
		private IEnumerator _CancelPreDownloadTask(long taskId, bool shouldClear, Action<int> onResult); // 0x0000000188CB9D60-0x0000000188CB9E3C
		[IteratorStateMachine(typeof(__RefreshPreDownloadResAction_d__71))]
		private IEnumerator _RefreshPreDownloadResAction(OperationContext context); // 0x0000000188CBB594-0x0000000188CBB64C
		private static bool _IsSameGameUpdateInfo(HGLatestGameInfo oldGameInfo, HGLatestGameInfo newGameInfo, out string changedField); // 0x0000000188CBA924-0x0000000188CBAAB0
		[IteratorStateMachine(typeof(__YieldGameUpdateInfoChangedAndQuit_d__73))]
		private IEnumerator _YieldGameUpdateInfoChangedAndQuit(); // 0x0000000188CBBA70-0x0000000188CBBB08
		private static void _CreateDirectoryIfNotExists(string folderPath); // 0x0000000188CB9F58-0x0000000188CB9FC0
		public void ClearWaitProgress(); // 0x000000018614C2A0-0x000000018614C370
		public void ShowWaitProgress(); // 0x0000000188CB9A7C-0x0000000188CB9BBC
		public int GetNoAlertCode(); // 0x0000000188CB9778-0x0000000188CB97BC
		public float GetWaitTime(); // 0x0000000188CB97BC-0x0000000188CB9910
	}

	public class LoginGSNode : LoginWorkFlow.Node // TypeDefIndex: 81010
	{
		// Fields
		private const int FLOW_NONE = 0; // Metadata: 0x0263E085
		private const int FLOW_WORKING = 1; // Metadata: 0x0263E086
		private const int FLOW_FINISH = 2; // Metadata: 0x0263E087
		private const int FLOW_ABORTING = 3; // Metadata: 0x0263E088
		private EnterGameServiceFlow m_flow; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65F80-0x0000000186E65FB0 
	
		// Nested types
		private class EnterGameServiceFlow : CustomYieldInstruction // TypeDefIndex: 81008
		{
			// Fields
			private LoginContext m_context; // 0x10
			private LoginGSNode m_curNode; // 0x18
			private Beyond.Misc.ObjectRef m_dialogBlocker; // 0x20
			private int m_state; // 0x28
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000186600E50-0x0000000186600E80 
	
			// Nested types
			[CompilerGenerated]
			private sealed class __EnterGameCoroutine_d__11 : IEnumerator<object> // TypeDefIndex: 81001
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
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public __EnterGameCoroutine_d__11(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x00000001850CCF50-0x00000001850CD960
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CBD6C4-0x0000000188CBD710
			}
	
			[CompilerGenerated]
			private sealed class __NetConnectAndGSLogin_d__12 : IEnumerator<object> // TypeDefIndex: 81002
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
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public __NetConnectAndGSLogin_d__12(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x00000001867D5B70-0x00000001867D7A50
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CBDDB0-0x0000000188CBDDFC
			}
	
			[CompilerGenerated]
			private sealed class __YieldAlertError_d__14 : IEnumerator<object> // TypeDefIndex: 81003
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string errorInfo; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public __YieldAlertError_d__14(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x0000000188CBDFA4-0x0000000188CBE038
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CBE038-0x0000000188CBE084
			}
	
			[CompilerGenerated]
			private sealed class __SaveCurrentUserToServerConfig_d__15 : IEnumerator<object> // TypeDefIndex: 81004
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public EnterGameServiceFlow __4__this; // 0x20
				public string uid; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public __SaveCurrentUserToServerConfig_d__15(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x000000018611E380-0x000000018611E460
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CBDF0C-0x0000000188CBDF58
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass16_0 // TypeDefIndex: 81005
			{
				// Fields
				public Beyond.Misc.ObjectRef waitForCallback; // 0x10
	
				// Constructors
				public __c__DisplayClass16_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal void __MockManualSelectServer_b__0(); // 0x0000000188CBD128-0x0000000188CBD14C
			}
	
			[CompilerGenerated]
			private sealed class __MockManualSelectServer_d__16 : IEnumerator<object> // TypeDefIndex: 81006
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string uid; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public __MockManualSelectServer_d__16(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x0000000188CBDC04-0x0000000188CBDD64
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CBDD64-0x0000000188CBDDB0
			}
	
			[CompilerGenerated]
			private sealed class __OnAuthError_d__17 : IEnumerator<object> // TypeDefIndex: 81007
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public object rejectInfo; // 0x20
				public EnterGameServiceFlow __4__this; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public __OnAuthError_d__17(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x0000000188CBDDFC-0x0000000188CBDEC0
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CBDEC0-0x0000000188CBDF0C
			}
	
			// Constructors
			public EnterGameServiceFlow(LoginGSNode node); // 0x0000000186E4B1E0-0x0000000186E4B260
	
			// Methods
			public void MarkAborting(); // 0x0000000188CB7E70-0x0000000188CB7EB0
			public void EnterGame(); // 0x00000001850CC870-0x00000001850CC990
			public bool IsInterruptable(); // 0x0000000188CB7E2C-0x0000000188CB7E70
			public bool TryInterrupt(); // 0x0000000188CB7EB0-0x0000000188CB7F10
			[IteratorStateMachine(typeof(__EnterGameCoroutine_d__11))]
			private IEnumerator _EnterGameCoroutine(); // 0x00000001850CC990-0x00000001850CCA10
			[IteratorStateMachine(typeof(__NetConnectAndGSLogin_d__12))]
			private IEnumerator _NetConnectAndGSLogin(string uid, string token, Beyond.Misc.ObjectRef loginRespRef); // 0x00000001850CC7B0-0x00000001850CC870
			private static string _ExtractErrorInfo(HttpSender.Result result, string keyErrorWithCode, string keyTimeout); // 0x0000000188CB7F10-0x0000000188CB8010
			[IteratorStateMachine(typeof(__YieldAlertError_d__14))]
			private IEnumerator _YieldAlertError(string errorInfo); // 0x0000000188CB81CC-0x0000000188CB8274
			[IteratorStateMachine(typeof(__SaveCurrentUserToServerConfig_d__15))]
			private IEnumerator _SaveCurrentUserToServerConfig(string uid); // 0x00000001867D7B10-0x00000001867D7BB0
			[IteratorStateMachine(typeof(__MockManualSelectServer_d__16))]
			private IEnumerator _MockManualSelectServer(string uid); // 0x0000000188CB8010-0x0000000188CB80B8
			[IteratorStateMachine(typeof(__OnAuthError_d__17))]
			private IEnumerator _OnAuthError(object rejectInfo); // 0x0000000188CB80B8-0x0000000188CB8170
			private void _ReLoginWhenErrorEncountered(); // 0x0000000188CB8170-0x0000000188CB81CC
			private static void _GlobalLoginSucBusiness(MSG_B1 msg); // 0x00000001850CB320-0x00000001850CB3F0
			[CompilerGenerated]
			private bool __EnterGameCoroutine_b__11_0(); // 0x00000001872314F0-0x0000000187231500
		}
	
		[CompilerGenerated]
		private sealed class __ConfirmServer_d__10 : IEnumerator<object> // TypeDefIndex: 81009
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private SDKPromiseEnumerator<U8ConfirmServerResult> _confirmPromise_5__2; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ConfirmServer_d__10(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001859BB160-0x00000001859BB8A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD62C-0x0000000188CBD678
		}
	
		// Constructors
		public LoginGSNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000186E4B040-0x0000000186E4B180
		public override bool OnEvent(ELoginEvent evt, object param); // 0x00000001850CAD50-0x00000001850CADE0
		[IteratorStateMachine(typeof(__ConfirmServer_d__10))]
		private static IEnumerator _ConfirmServer(); // 0x00000001850CCE00-0x00000001850CCE60
		private void _FallbackToInitWithMask(bool bLogoutAccount); // 0x0000000188CB8B50-0x0000000188CB8CD0
		private void _OnEventLogout(); // 0x0000000188CB8F5C-0x0000000188CB909C
		private void _OnEventResourceRepair(); // 0x0000000188CB9230-0x0000000188CB9370
		private void _OnEventPreDownload(); // 0x0000000188CB909C-0x0000000188CB9230
		private bool _LogoutToInitNode(); // 0x0000000188CB8E98-0x0000000188CB8F5C
		private bool _FallbackToInitNodeImpl(); // 0x0000000188CB8AD0-0x0000000188CB8B50
		private bool _FallbackToResRepairImpl(); // 0x0000000188CB8DB4-0x0000000188CB8E98
		private bool _FallbackToPreDownloadImpl(); // 0x0000000188CB8CD0-0x0000000188CB8DB4
		[CompilerGenerated]
		private void __OnEventLogout_b__12_0(); // 0x0000000188CB899C-0x0000000188CB89A8
		[CompilerGenerated]
		private void __OnEventResourceRepair_b__13_0(); // 0x0000000188CB89A8-0x0000000188CB8AD0
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1); // 0x0000000188CB8994-0x0000000188CB899C
	}

	public class LoginHotUpdateProp : LoginProperty<LoginHotUpdateModel> // TypeDefIndex: 81011
	{
		// Constructors
		public LoginHotUpdateProp(LoginWorkFlow workflow); // 0x000000018614C370-0x000000018614C410
	}

	public class LoginHotUpdateModel // TypeDefIndex: 81014
	{
		// Fields
		public string title; // 0x10
		public string desc; // 0x18
		public IProgress progress; // 0x20
	
		// Nested types
		public interface IProgress // TypeDefIndex: 81012
		{
			// Methods
			double GetTotal();
			double GetCurrent();
			string GetInfo();
		}
	
		public class SimpleProgress : Beyond.Login.LoginHotUpdateModel.IProgress // TypeDefIndex: 81013
		{
			// Fields
			public double current; // 0x10
	
			// Constructors
			public SimpleProgress(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public double GetCurrent(); // 0x0000000188CBC190-0x0000000188CBC1D4
			public double GetTotal(); // 0x000000018539A2E0-0x000000018539A310
			public string GetInfo(); // 0x0000000186B8C7E0-0x0000000186B8C810
		}
	
		// Constructors
		public LoginHotUpdateModel(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class LoginHotUpdater : CustomYieldInstruction, IDisposable // TypeDefIndex: 81040
	{
		// Fields
		private const int MODE_SKIP = 0; // Metadata: 0x0263E089
		private const int MODE_DOWNLOAD = 1; // Metadata: 0x0263E08A
		private const int MODE_LOCAL = 2; // Metadata: 0x0263E08B
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
		public const string URL_GET_SPLIT = "/"; // Metadata: 0x0263E08C
	
		// Properties
		public override bool keepWaiting { get; } // 0x000000018688BF30-0x000000018688BF60 
	
		// Nested types
		public class HotUpdateInfo // TypeDefIndex: 81015
		{
			// Fields
			public FResourceDiff resDiff; // 0x10
			public LocalResPref localResPref; // 0x50
	
			// Constructors
			public HotUpdateInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool CheckIfNeedReload(); // 0x00000001870F0A90-0x00000001870F0C20
			public bool HasChangedByType(EVFSBlockType type); // 0x000000018578DB20-0x000000018578DBA0
			public bool HasAssetsChanged(); // 0x0000000188CB8274-0x0000000188CB8320
		}
	
		public class WorkContext // TypeDefIndex: 81016
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
			public bool illegalItemsInLocalRes { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
	
			// Constructors
			public WorkContext(); // 0x0000000186C75730-0x0000000186C757A0
	
			// Methods
			public void MarkIllegalItemsInLocalRes(); // 0x0000000188CBE3AC-0x0000000188CBE3EC
			public HotUpdateInfo GetHotUpdateInfo(bool isInitial); // 0x0000000185F56330-0x0000000185F563D0
			public bool HasChangedByType(EVFSBlockType type); // 0x000000018578DAB0-0x000000018578DB20
		}
	
		[CompilerGenerated]
		private sealed class __Work_d__28 : IEnumerator<object> // TypeDefIndex: 81017
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			private WorkContext _workContext_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __Work_d__28(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186C75460-0x0000000186C755F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBDF58-0x0000000188CBDFA4
		}
	
		[CompilerGenerated]
		private sealed class __CreateMainCoroutine_d__29 : IEnumerator<object> // TypeDefIndex: 81018
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext workContext; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CreateMainCoroutine_d__29(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001862B0600-0x00000001862B0700
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD678-0x0000000188CBD6C4
		}
	
		[CompilerGenerated]
		private sealed class __MainCoroutineModeSkip_d__30 : IEnumerator<object> // TypeDefIndex: 81019
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __MainCoroutineModeSkip_d__30(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CBDB24-0x0000000188CBDBB8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBDBB8-0x0000000188CBDC04
		}
	
		[CompilerGenerated]
		private sealed class __MainCoroutineModeLocal_d__31 : IEnumerator<object> // TypeDefIndex: 81020
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __MainCoroutineModeLocal_d__31(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CBD990-0x0000000188CBDAD8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBDAD8-0x0000000188CBDB24
		}
	
		[CompilerGenerated]
		private sealed class __UpdateResVersion_d__32 : IEnumerator<object> // TypeDefIndex: 81021
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext workContext; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __UpdateResVersion_d__32(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186FC2A90-0x0000000186FC2B10
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3BA4-0x0000000188CC3BF0
		}
	
		[CompilerGenerated]
		private sealed class __UpdateResVersionDev_d__36 : IEnumerator<object> // TypeDefIndex: 81022
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private ResVersionDevCfg _config_5__2; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __UpdateResVersionDev_d__36(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC3988-0x0000000188CC3B0C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3B0C-0x0000000188CC3B58
		}
	
		[CompilerGenerated]
		private sealed class __UpdateResVersionProd_d__38 : IEnumerator<object> // TypeDefIndex: 81023
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
			private ResVersionCfg _config_5__2; // 0x28
			private Beyond.Misc.ObjectRef _resultRef_5__3; // 0x30
			private string _url_5__4; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __UpdateResVersionProd_d__38(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186A4A2A0-0x0000000186A4A590
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3B58-0x0000000188CC3BA4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 81024
		{
			// Fields
			public bool isInitial; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal LocalResPref __MainCoroutineModeDownload_b__1(); // 0x0000000182783B50-0x0000000182783E80
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 81025
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__43_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188CC0C68-0x0000000188CC0CCC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __MainCoroutineModeDownload_b__43_0(); // 0x0000000182783280-0x0000000182783B50
		}
	
		[CompilerGenerated]
		private sealed class __MainCoroutineModeDownload_d__43 : IEnumerator<object> // TypeDefIndex: 81026
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
			private HotUpdateInfo _info_5__8; // 0x48
			private WaitForAsyncTask<LocalResPref> _waitForResPref_5__9; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __MainCoroutineModeDownload_d__43(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018578DBA0-0x0000000185791C40
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3638-0x0000000188CC3684
		}
	
		[CompilerGenerated]
		private sealed class __ReloadResourceIndexes_d__46 : IEnumerator<object> // TypeDefIndex: 81027
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ReloadResourceIndexes_d__46(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000185F56F30-0x0000000185F5A0C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC38F0-0x0000000188CC393C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0 // TypeDefIndex: 81028
		{
			// Fields
			public string filePath; // 0x10
			public ResourceIndex resIndex; // 0x18
			public Func<ResourceIndex> __9__1; // 0x20
	
			// Constructors
			public __c__DisplayClass47_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ResourceIndex __LoadOrDownloadResIndex_b__1(); // 0x00000001858D90E0-0x00000001858D9130
			internal object __LoadOrDownloadResIndex_b__0(); // 0x00000001858D92B0-0x00000001858D92F0
		}
	
		[CompilerGenerated]
		private sealed class __LoadOrDownloadResIndex_d__47 : IEnumerator<object> // TypeDefIndex: 81029
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __LoadOrDownloadResIndex_d__47(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001858D9780-0x00000001858D9DA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3508-0x0000000188CC3554
		}
	
		[CompilerGenerated]
		private sealed class __GenResIndex_d__48 : IEnumerator<object> // TypeDefIndex: 81030
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GenResIndex_d__48(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001865AA360-0x00000001865AA4A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2D54-0x0000000188CC2DA0
		}
	
		[CompilerGenerated]
		private sealed class __GenRiff_d__49 : IEnumerator<object> // TypeDefIndex: 81031
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GenRiff_d__49(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000185F565C0-0x0000000185F569E0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2DA0-0x0000000188CC2DEC
		}
	
		[CompilerGenerated]
		private sealed class __GenLocalRef_d__51 : IEnumerator<object> // TypeDefIndex: 81032
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
			public bool isInitial; // 0x28
			public string onlineVer; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GenLocalRef_d__51(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000185F561A0-0x0000000185F56330
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2D08-0x0000000188CC2D54
		}
	
		[CompilerGenerated]
		private sealed class __CheckAndDownloadResource_d__52 : IEnumerator<object> // TypeDefIndex: 81033
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CheckAndDownloadResource_d__52(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186223930-0x0000000186227780
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC25C8-0x0000000188CC2614
		}
	
		[CompilerGenerated]
		private sealed class __DownloadPatchInfo_d__54 : IEnumerator<object> // TypeDefIndex: 81034
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DownloadPatchInfo_d__54(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001858D8950-0x00000001858D8BA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC26AC-0x0000000188CC26F8
		}
	
		[CompilerGenerated]
		private sealed class __ClearDownloadFolder_d__55 : IEnumerator<object> // TypeDefIndex: 81035
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ClearDownloadFolder_d__55(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018614D9A0-0x000000018614E770
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2660-0x0000000188CC26AC
		}
	
		[CompilerGenerated]
		private sealed class __CheckLocalResConsistency_d__56 : IEnumerator<object> // TypeDefIndex: 81036
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __CheckLocalResConsistency_d__56(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001865AAD10-0x00000001865AE4E0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2614-0x0000000188CC2660
		}
	
		[CompilerGenerated]
		private sealed class __VitalError_d__57 : IEnumerator<object> // TypeDefIndex: 81037
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public string error; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __VitalError_d__57(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC3BF0-0x0000000188CC3D48
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3D48-0x0000000188CC3D94
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 81038
		{
			// Fields
			public RuntimeFileUtils.StreamingResult indexRet; // 0x10
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ResourceIndex __LoadStreamingIndex_b__0(); // 0x00000001858DA990-0x00000001858DA9C0
		}
	
		[CompilerGenerated]
		private sealed class __LoadStreamingIndex_d__58 : IEnumerator<object> // TypeDefIndex: 81039
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __LoadStreamingIndex_d__58(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001858D9460-0x00000001858D9780
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3554-0x0000000188CC35A0
		}
	
		// Constructors
		private LoginHotUpdater(LoginContext context, bool resRepairMode); // 0x00000001862AFE60-0x00000001862AFF00
	
		// Methods
		protected static void MarkInitialAssetChanged(); // 0x0000000188CBBCA4-0x0000000188CBBD14
		protected static bool CheckInitialAssetChanged(); // 0x000000018578D2B0-0x000000018578D5E0
		protected static void MarkNeedClearFolder(bool isInitial); // 0x000000018611D060-0x000000018611D0F0
		protected static bool NeedClearFolder(bool isInitial); // 0x0000000186EB79F0-0x0000000186EB7A80
		protected static void MarkClearSuccessed(bool isInitial); // 0x000000018611D0F0-0x000000018611D170
		public static void MarkSoftRestart(); // 0x0000000188CBBD14-0x0000000188CBBD84
		public static void ClearSoftRestartFlag(); // 0x0000000188CBBBC4-0x0000000188CBBC34
		public static bool IsNeedSoftRestart(); // 0x0000000188CBBC34-0x0000000188CBBCA4
		public void Dispose(); // 0x0000000186BBC800-0x0000000186BBC950
		public static LoginHotUpdater StartHotUpdate(LoginContext context, bool resRepairMode); // 0x00000001862AFD20-0x00000001862AFDE0
		[IteratorStateMachine(typeof(__Work_d__28))]
		private IEnumerator _Work(); // 0x00000001862AFDE0-0x00000001862AFE60
		[IteratorStateMachine(typeof(__CreateMainCoroutine_d__29))]
		private IEnumerator _CreateMainCoroutine(WorkContext workContext); // 0x0000000186C75690-0x0000000186C75730
		[IteratorStateMachine(typeof(__MainCoroutineModeSkip_d__30))]
		private IEnumerator _MainCoroutineModeSkip(WorkContext context); // 0x0000000188CBBE3C-0x0000000188CBBEF4
		[IteratorStateMachine(typeof(__MainCoroutineModeLocal_d__31))]
		private IEnumerator _MainCoroutineModeLocal(WorkContext context); // 0x0000000188CBBD84-0x0000000188CBBE3C
		[IteratorStateMachine(typeof(__UpdateResVersion_d__32))]
		private IEnumerator _UpdateResVersion(WorkContext workContext); // 0x0000000186C755F0-0x0000000186C75690
		private static void _SetResVersionForLog(); // 0x0000000186C757A0-0x0000000186C75870
		private string _GetOnlineResVersion(bool isInitial); // 0x000000018614C140-0x000000018614C1F0
		public string ResourceRootUrl(string version, bool isInitial); // 0x000000018578D000-0x000000018578D0A0
		[IteratorStateMachine(typeof(__UpdateResVersionDev_d__36))]
		private IEnumerator _UpdateResVersionDev(WorkContext workContext); // 0x0000000188CBBEF4-0x0000000188CBBF8C
		[IteratorStateMachine(typeof(__UpdateResVersionProd_d__38))]
		private IEnumerator _UpdateResVersionProd(WorkContext workContext); // 0x0000000186FC2B10-0x0000000186FC2BA0
		private string _ResourcePatchUrl(string version, bool isInitial); // 0x0000000185F56060-0x0000000185F56100
		private string _ResourceFileUrl(string version, bool isInitial); // 0x0000000185F56100-0x0000000185F561A0
		private string _ResourcePatchRootUrl(string version, bool isInitial); // 0x00000001858D8BA0-0x00000001858D8C50
		private string _ResourceIndexUrl(string version, bool isInitial); // 0x00000001858D9200-0x00000001858D92B0
		[IteratorStateMachine(typeof(__MainCoroutineModeDownload_d__43))]
		private IEnumerator _MainCoroutineModeDownload(WorkContext workContext); // 0x00000001862B0700-0x00000001862B07A0
		private void _StartDownloadingShaderWarmupIfNeeded(); // 0x00000001862B18D0-0x00000001862B2F00
		private void _StopDownloadingShaderWarmupIfNeeded(); // 0x00000001871F4200-0x00000001871F4260
		[IteratorStateMachine(typeof(__ReloadResourceIndexes_d__46))]
		private IEnumerator _ReloadResourceIndexes(WorkContext workContext); // 0x000000018717C8A0-0x000000018717C930
		[IteratorStateMachine(typeof(__LoadOrDownloadResIndex_d__47))]
		private IEnumerator _LoadOrDownloadResIndex(string onlineVer, bool isInitial, Beyond.Misc.ObjectRef resIndexRef); // 0x00000001865AA4A0-0x00000001865AA560
		[IteratorStateMachine(typeof(__GenResIndex_d__48))]
		private IEnumerator _GenResIndex(string onlineVer, bool isInitial, WorkContext workContext); // 0x000000018614BF10-0x000000018614BFD0
		[IteratorStateMachine(typeof(__GenRiff_d__49))]
		private IEnumerator _GenRiff(string onlineVer, bool isInitial, WorkContext workContext); // 0x000000018614BFD0-0x000000018614C090
		private static LocalResPref _CreateUpdatedLocalResPref(string onlineVer, bool isInitial, LocalResPref oldLocalResPref, FResourceDiff resDiff, out int removedFileCount); // 0x0000000185F54650-0x0000000185F54ED0
		[IteratorStateMachine(typeof(__GenLocalRef_d__51))]
		private IEnumerator _GenLocalRef(string onlineVer, bool isInitial, WorkContext workContext); // 0x000000018614C1F0-0x000000018614C2A0
		[IteratorStateMachine(typeof(__CheckAndDownloadResource_d__52))]
		private IEnumerator _CheckAndDownloadResource(string onlineVer, bool isInitial, WorkContext workContext); // 0x0000000186EDFF40-0x0000000186EE0000
		private void _EventLogDownloadProgress(ref bool first, double current, double total, int target, bool isInitial); // 0x0000000186222BE0-0x0000000186223930
		[IteratorStateMachine(typeof(__DownloadPatchInfo_d__54))]
		private IEnumerator _DownloadPatchInfo(string onlineVer, bool isInitial, Beyond.Misc.ObjectRef patchInfoRef); // 0x0000000186EDFDC0-0x0000000186EDFE80
		[IteratorStateMachine(typeof(__ClearDownloadFolder_d__55))]
		private IEnumerator _ClearDownloadFolder(WorkContext workContext, bool needDeleteInitial, bool needDeleteMain); // 0x00000001870DB200-0x00000001870DB2B0
		[IteratorStateMachine(typeof(__CheckLocalResConsistency_d__56))]
		private IEnumerator _CheckLocalResConsistency(string onlineVer, bool isInitial, WorkContext context); // 0x0000000186EDFE80-0x0000000186EDFF40
		[IteratorStateMachine(typeof(__VitalError_d__57))]
		private IEnumerator _VitalError(string error); // 0x0000000188CBBF8C-0x0000000188CBC044
		[IteratorStateMachine(typeof(__LoadStreamingIndex_d__58))]
		private static IEnumerator _LoadStreamingIndex(bool isInitial, WorkContext workContext, Beyond.Misc.ObjectRef resultRef); // 0x0000000185F55FB0-0x0000000185F56060
		public static void WriteLocalResPrefToFile(LocalResPref localResPref, WorkContext workContext); // 0x00000001858D92F0-0x00000001858D93E0
		private static int _CurrentWorkMode(LoginContext context); // 0x00000001862B07A0-0x00000001862B1310
	}

	public class LoginProgress : LoginHotUpdateModel.IProgress // TypeDefIndex: 81043
	{
		// Fields
		public const int MODE_PROG = 0; // Metadata: 0x0263E08E
		public const int MODE_SIZE = 1; // Metadata: 0x0263E08F
		public const int MODE_IDEL = 2; // Metadata: 0x0263E090
		public int mode; // 0x10
		public double current; // 0x18
		public double total; // 0x20
		public double speed; // 0x28
		private FDownloadSize m_downloadSize; // 0x30
	
		// Nested types
		private struct FDownloadSize // TypeDefIndex: 81042
		{
			// Fields
			private const double MB = 1048576; // Metadata: 0x0263E091
			private const double KB = 1024; // Metadata: 0x0263E099
			private EUnit m_unit; // 0x00
			private float m_displayCurrent; // 0x04
			private float m_displayTotal; // 0x08
			private float m_displaySpeed; // 0x0C
			public string displayInfo; // 0x10
			private float m_current; // 0x18
			private float m_total; // 0x1C
	
			// Nested types
			private enum EUnit // TypeDefIndex: 81041
			{
				NONE = 0,
				B = 1,
				KB = 2,
				MB = 3
			}
	
			// Methods
			public void SetProgress(double current, double total); // 0x000000018539A310-0x000000018539A4A0
			public void SetIdle(); // 0x0000000188CBE494-0x0000000188CBE5C4
			public void SetSize(double current, double total, double speed); // 0x000000018539A4A0-0x000000018539A790
			private static EUnit _PickUnit(double number); // 0x000000018539AD50-0x000000018539ADB0
			private static float _DisplayWithUnit(double number, EUnit unit); // 0x000000018539A790-0x000000018539A850
			private static string _FormatDisplayInfo(float current, float total, EUnit unit); // 0x0000000186430B60-0x0000000186430C70
			private static string _FormatSpeedInfo(float speed, EUnit unit); // 0x000000018539CAE0-0x000000018539CBB0
			private static string _FormatProgressInfo(float current, float total); // 0x000000018539ADB0-0x000000018539AE50
		}
	
		// Constructors
		public LoginProgress(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public double GetCurrent(); // 0x0000000188CBF504-0x0000000188CBF548
		public double GetTotal(); // 0x0000000188CBF548-0x0000000188CBF58C
		public string GetInfo(); // 0x000000018539A260-0x000000018539A2E0
	}

	public class LoginInitNode : LoginWorkFlow.Node // TypeDefIndex: 81047
	{
		// Fields
		private bool m_isSDKInited; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65F20-0x0000000186E65F50 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __InitCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 81044
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginInitNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __InitCoroutine_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186644CE0-0x0000000186644DA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3470-0x0000000188CC34BC
		}
	
		[CompilerGenerated]
		private sealed class __InitRemoteConfigs_d__5 : IEnumerator<object> // TypeDefIndex: 81045
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginInitNode __4__this; // 0x20
			private NetConfigInterface.InitYiedInstruction _initNetConfig_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __InitRemoteConfigs_d__5(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001869C0A10-0x00000001869C27F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC34BC-0x0000000188CC3508
		}
	
		[CompilerGenerated]
		private sealed class __YieldAlertError_d__6 : IEnumerator<object> // TypeDefIndex: 81046
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string errorInfo; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __YieldAlertError_d__6(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC3E2C-0x0000000188CC3EC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3EC0-0x0000000188CC3F0C
		}
	
		// Constructors
		public LoginInitNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000186AECC80-0x0000000186AECD60
		[IteratorStateMachine(typeof(__InitCoroutine_d__4))]
		private IEnumerator _InitCoroutine(); // 0x0000000186AECD60-0x0000000186AECDE0
		[IteratorStateMachine(typeof(__InitRemoteConfigs_d__5))]
		private IEnumerator _InitRemoteConfigs(); // 0x0000000186644DA0-0x0000000186644E20
		[IteratorStateMachine(typeof(__YieldAlertError_d__6))]
		private IEnumerator _YieldAlertError(string errorInfo); // 0x0000000188CBEF30-0x0000000188CBEFD8
	}

	public class LoginLocalResTask : IDisposable // TypeDefIndex: 81050
	{
		// Fields
		private LoginContext m_loginCxt; // 0x10
		private LoginHotUpdater.WorkContext m_workCxt; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 81048
		{
			// Fields
			public string indexPath; // 0x10
			public string prefPath; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ResourceIndex _Work_b__0(); // 0x0000000188CC0B70-0x0000000188CC0BC4
			internal LocalResPref _Work_b__1(); // 0x0000000188CC0BC4-0x0000000188CC0BF4
		}
	
		[CompilerGenerated]
		private sealed class _Work_d__3 : IEnumerator<object> // TypeDefIndex: 81049
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
			private ResourceIndex _resIndex_5__9; // 0x60
			private WaitForAsyncTask<LocalResPref> _waitForResPref_5__10; // 0x68
			private RootCategory _rootCategory_5__11; // 0x70
			private LoginHotUpdateModel.SimpleProgress _progress_5__12; // 0x78
			private WaitForAsyncTask<object> _checkTask_5__13; // 0x80
			private LocalResChecker.CheckOutput _checkOutput_5__14; // 0x88
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Work_d__3(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC0D18-0x0000000188CC2380
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2380-0x0000000188CC23CC
		}
	
		// Constructors
		public LoginLocalResTask(LoginContext loginContext, LoginHotUpdater.WorkContext workContext); // 0x0000000185381AC0-0x0000000185381AF0
	
		// Methods
		[IteratorStateMachine(typeof(_Work_d__3))]
		public IEnumerator Work(); // 0x0000000188CBF00C-0x0000000188CBF0A4
		public void Dispose(); // 0x0000000188CBEFD8-0x0000000188CBF00C
	}

	public class LoginPreDownloadNode : LoginWorkFlow.Node // TypeDefIndex: 81054
	{
		// Fields
		private int m_cachedPreDownloadCode; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65EF0-0x0000000186E65F20 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __PreDownloadCoroutine_d__5 : IEnumerator<object> // TypeDefIndex: 81051
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginPreDownloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __PreDownloadCoroutine_d__5(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC3684-0x0000000188CC38A4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC38A4-0x0000000188CC38F0
		}
	
		[CompilerGenerated]
		private sealed class __ApplyPreDownloadCoroutine_d__7 : IEnumerator<object> // TypeDefIndex: 81052
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginPreDownloadNode __4__this; // 0x20
			private LoginGameUpdater.PreDownloadResult _result_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ApplyPreDownloadCoroutine_d__7(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC2418-0x0000000188CC257C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC257C-0x0000000188CC25C8
		}
	
		[CompilerGenerated]
		private sealed class __DownloadPreDownloadCoroutine_d__8 : IEnumerator<object> // TypeDefIndex: 81053
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginPreDownloadNode __4__this; // 0x20
			private LoginGameUpdater.PreDownloadResult _result_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DownloadPreDownloadCoroutine_d__8(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC26F8-0x0000000188CC2940
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2940-0x0000000188CC298C
		}
	
		// Constructors
		public LoginPreDownloadNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool OnEvent(ELoginEvent evt, object param); // 0x0000000188CBF0A4-0x0000000188CBF1E0
		public override CustomYieldInstruction Work(); // 0x000000018722CB00-0x000000018722CB30
		[IteratorStateMachine(typeof(__PreDownloadCoroutine_d__5))]
		private IEnumerator _PreDownloadCoroutine(); // 0x0000000188CBF46C-0x0000000188CBF504
		private bool _ConsumePreDownloadRequest(); // 0x0000000188CBF278-0x0000000188CBF3D4
		[IteratorStateMachine(typeof(__ApplyPreDownloadCoroutine_d__7))]
		private IEnumerator _ApplyPreDownloadCoroutine(); // 0x0000000188CBF1E0-0x0000000188CBF278
		[IteratorStateMachine(typeof(__DownloadPreDownloadCoroutine_d__8))]
		private IEnumerator _DownloadPreDownloadCoroutine(); // 0x0000000188CBF3D4-0x0000000188CBF46C
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1); // 0x0000000188CB8994-0x0000000188CB899C
	}

	public class PreloadNode : LoginWorkFlow.Node // TypeDefIndex: 81062
	{
		// Fields
		private LoginHotUpdateModel.SimpleProgress m_progress; // 0x20
		private bool m_getServerListSuc; // 0x28
		private string m_errorMsg; // 0x30
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65DD0-0x0000000186E65E00 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 81055
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<bool> __9__5_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E78E0-0x00000001871E7940
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Work_b__5_0(); // 0x000000018521DAF0-0x000000018521DBB0
		}
	
		[CompilerGenerated]
		private sealed class __LoginPreLoad_d__7 : IEnumerator<object> // TypeDefIndex: 81056
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __LoginPreLoad_d__7(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001862B1310-0x00000001862B1460
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC35EC-0x0000000188CC3638
		}
	
		[CompilerGenerated]
		private sealed class __WarmUp_d__9 : IEnumerator<object> // TypeDefIndex: 81057
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __WarmUp_d__9(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001860FF8E0-0x00000001861018A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3DE0-0x0000000188CC3E2C
		}
	
		[CompilerGenerated]
		private sealed class __GetServerList_d__10 : IEnumerator<object> // TypeDefIndex: 81058
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GetServerList_d__10(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001859BBEC0-0x00000001859BBFB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3424-0x0000000188CC3470
		}
	
		[CompilerGenerated]
		private sealed class __GetServerListInfoMock_d__12 : IEnumerator<object> // TypeDefIndex: 81059
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GetServerListInfoMock_d__12(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001859BAD40-0x00000001859BAE10
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2DEC-0x0000000188CC2E38
		}
	
		[CompilerGenerated]
		private sealed class __GetServerListInfo_d__13 : IEnumerator<object> // TypeDefIndex: 81060
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
			private SDKPromiseEnumerator<List<U8ServerInfo>> _getServerListPromise_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __GetServerListInfo_d__13(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC2E38-0x0000000188CC33D8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC33D8-0x0000000188CC3424
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 81061
		{
			// Fields
			public List<ServerZoneManager.ServerZoneData> serverZoneDataList; // 0x10
			public List<SpeedTestServerInfo> serverList; // 0x18
			public Action<SpeedTestResult> callback; // 0x20
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnGetServerListSuc_b__0(SpeedTestResult result); // 0x0000000188CC07D0-0x0000000188CC0B00
			internal Task<Hypergryph.SpeedTest.TaskResult> __OnGetServerListSuc_b__1(); // 0x0000000188CC0B00-0x0000000188CC0B70
		}
	
		// Constructors
		public PreloadNode(); // 0x0000000186BCADE0-0x0000000186BCAE60
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x000000018614A8F0-0x000000018614AAB0
		private void _ShowPreloadResourcePanel(); // 0x000000018614C410-0x000000018614C520
		[IteratorStateMachine(typeof(__LoginPreLoad_d__7))]
		private IEnumerator _LoginPreLoad(); // 0x000000018614AAB0-0x000000018614AB30
		private void _QuitGame(GameAppExitCode exitCode); // 0x0000000188CC06F0-0x0000000188CC077C
		[IteratorStateMachine(typeof(__WarmUp_d__9))]
		private IEnumerator _WarmUp(); // 0x00000001862B14E0-0x00000001862B1560
		[IteratorStateMachine(typeof(__GetServerList_d__10))]
		private IEnumerator _GetServerList(); // 0x00000001862B1460-0x00000001862B14E0
		private void _EnterPreLoad(); // 0x00000001862B2F80-0x00000001862B3010
		[IteratorStateMachine(typeof(__GetServerListInfoMock_d__12))]
		private IEnumerator _GetServerListInfoMock(); // 0x00000001859BBFB0-0x00000001859BC030
		[IteratorStateMachine(typeof(__GetServerListInfo_d__13))]
		private IEnumerator _GetServerListInfo(); // 0x0000000188CC0594-0x0000000188CC062C
		private void _OnGetServerListSuc(); // 0x00000001859BB8A0-0x00000001859BBEC0
		private void _OnGetServerListFail(string errorInfo); // 0x0000000188CC062C-0x0000000188CC06F0
	}

	public class LoginSDKInitNode : LoginWorkFlow.Node // TypeDefIndex: 81065
	{
		// Fields
		private bool m_isSDKInited; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65EC0-0x0000000186E65EF0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __SDKInitCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 81063
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginSDKInitNode __4__this; // 0x20
			private string _env_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __SDKInitCoroutine_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001857533A0-0x0000000185756090
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC393C-0x0000000188CC3988
		}
	
		[CompilerGenerated]
		private sealed class __WaitForSDKInited_d__5 : IEnumerator<object> // TypeDefIndex: 81064
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __WaitForSDKInited_d__5(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186F94370-0x0000000186F94440
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC3D94-0x0000000188CC3DE0
		}
	
		// Constructors
		public LoginSDKInitNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000186AECDE0-0x0000000186AECEC0
		[IteratorStateMachine(typeof(__SDKInitCoroutine_d__4))]
		private IEnumerator _SDKInitCoroutine(); // 0x0000000186AECEC0-0x0000000186AECF40
		[IteratorStateMachine(typeof(__WaitForSDKInited_d__5))]
		private IEnumerator _WaitForSDKInited(); // 0x0000000185753330-0x00000001857533A0
		private void _InitSubSDKs(); // 0x0000000182781FA0-0x0000000182783280
	}

	public class U8LoginNode : LoginWorkFlow.Node // TypeDefIndex: 81068
	{
		// Fields
		private bool m_loginSuc; // 0x20
		private bool m_isSDKLoginFinished; // 0x21
		private bool m_isWaitingGameProtocolUpdateCheck; // 0x22
		private int m_rqstSkipLoginCache; // 0x24
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65D10-0x0000000186E65D40 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __LoginCoroutine_d__7 : IEnumerator<object> // TypeDefIndex: 81066
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8LoginNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __LoginCoroutine_d__7(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001862B1560-0x00000001862B1780
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC35A0-0x0000000188CC35EC
		}
	
		[CompilerGenerated]
		private sealed class __FinishLogin_d__8 : IEnumerator<object> // TypeDefIndex: 81067
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private string _env_5__2; // 0x20
			private SDKPromiseEnumerator<U8AuthV2Result> _authPromise_5__3; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __FinishLogin_d__8(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001850CDDA0-0x00000001850CE090
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2CBC-0x0000000188CC2D08
		}
	
		// Constructors
		public U8LoginNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000186AECF40-0x0000000186AED020
		[IteratorStateMachine(typeof(__LoginCoroutine_d__7))]
		private IEnumerator _LoginCoroutine(); // 0x0000000186AED020-0x0000000186AED0A0
		[IteratorStateMachine(typeof(__FinishLogin_d__8))]
		private IEnumerator _FinishLogin(); // 0x00000001862B1780-0x00000001862B17F0
		public override bool OnEvent(ELoginEvent evt, object param); // 0x0000000188CC3F0C-0x0000000188CC3F68
		private void _StartSDKLogin(); // 0x00000001859BC030-0x00000001859BC290
		private void _SetCursorOnLoginStart(); // 0x00000001859BC3F0-0x00000001859BC480
		private void _SetCursorOnLoginFinish(); // 0x00000001859BC570-0x00000001859BC600
		private void _SkipSDKLogin(); // 0x0000000188CC439C-0x0000000188CC446C
		private void _ClearLoginCaches(); // 0x000000018614BD00-0x000000018614BDD0
		private void _StartGameProtocolUpdateCheck(); // 0x00000001859BC600-0x00000001859BC710
		private void _OnGameProtocolUpdateCheckSucceeded(); // 0x0000000188CC4128-0x0000000188CC41B8
		private void _OnGameProtocolUpdateCheckFailed(); // 0x0000000188CC4040-0x0000000188CC4128
		private void _ClearGameProtocolUpdateCheckEvents(); // 0x0000000186149F70-0x000000018614A0C0
		private void _OnLoginSuc(); // 0x00000001863F4580-0x00000001863F6500
		private void _OnLoginFail(object rawInfo); // 0x0000000188CC426C-0x0000000188CC439C
		private void _OnSDKViewDisabled(); // 0x00000001863F6500-0x00000001863F6530
		private void _OnLoginCanceled(); // 0x0000000188CC41B8-0x0000000188CC426C
		private void _EnableBlurMask(bool enable); // 0x00000001863F7C70-0x00000001863F7D20
		[CompilerGenerated]
		private void __StartSDKLogin_b__10_0(string sessionToken); // 0x00000001859BC480-0x00000001859BC530
		[CompilerGenerated]
		private void __StartSDKLogin_b__10_1(object pram); // 0x0000000188CC3F68-0x0000000188CC4040
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1); // 0x0000000188CB8994-0x0000000188CB899C
	}

	public class LoginProperty<T> : LoginWorkFlow.IWorkerUpdateOnce // TypeDefIndex: 81069
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

	public interface ILoginBinder<T> // TypeDefIndex: 81070
	{
		// Methods
		void OnValueChanged(T value);
	}

	public interface ILoginContextReceiver // TypeDefIndex: 81071
	{
		// Methods
		void OnLoginContext(LoginContext context);
	}

	public class LoginViewModel // TypeDefIndex: 81073
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
		[CompilerGenerated]
		private int _rqstPreDownloadCode_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _isPreDownloadDownloading_k__BackingField; // 0x2C
		[CompilerGenerated]
		private int _rqstCancelPreDownloadCode_k__BackingField; // 0x30
		public FAgeTipsPolicy ageTipsPolicy; // 0x34
	
		// Properties
		public int rqstSkipU8Login { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public int rqstResRepairCode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public int rqstPreDownloadCode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public bool isPreDownloadDownloading { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
		public int rqstCancelPreDownloadCode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
	
		// Nested types
		public struct FAgeTipsPolicy // TypeDefIndex: 81072
		{
			// Fields
			public bool canOpenDetail; // 0x00
			public bool displayCN; // 0x01
			public bool displayKR; // 0x02
	
			// Properties
			public bool display { get; } // 0x000000018614FBC0-0x000000018614FBF0 
		}
	
		// Constructors
		public LoginViewModel(); // 0x00000001870EA530-0x00000001870EA560
	
		// Methods
		public bool IsAgeTipsVisible(); // 0x000000018614FB30-0x000000018614FBC0
		public bool IsGovTipsVisible(); // 0x0000000186BB4580-0x0000000186BB45B0
		public bool IsMenuVisible(); // 0x0000000186151500-0x00000001861515D0
		public void RequestResourceRepair(); // 0x0000000188CBF694-0x0000000188CBF6D0
		public void RequestPreDownload(); // 0x0000000188CBF658-0x0000000188CBF694
		public void RequestCancelPreDownload(); // 0x0000000188CBF61C-0x0000000188CBF658
		public void SetPreDownloadDownloading(bool value); // 0x0000000188CBF70C-0x0000000188CBF744
		public void RequestSkipU8Login(); // 0x0000000188CBF6D0-0x0000000188CBF70C
		private static FAgeTipsPolicy _LoadAgeTipsPolicy(); // 0x00000001870EA560-0x00000001870EA5E0
	}

	public class LoginViewProperty : LoginProperty<LoginViewModel> // TypeDefIndex: 81074
	{
		// Fields
		[CompilerGenerated]
		private LoginHotUpdateProp _hotUpdateProp_k__BackingField; // 0x30
		[CompilerGenerated]
		private LoginAgeTipsProp _ageTipsProp_k__BackingField; // 0x38
		[CompilerGenerated]
		private LoginServerSelectProp _serverSelectProp_k__BackingField; // 0x40
	
		// Properties
		public LoginHotUpdateProp hotUpdateProp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public LoginAgeTipsProp ageTipsProp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public LoginServerSelectProp serverSelectProp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
	
		// Constructors
		public LoginViewProperty(LoginWorkFlow workflow); // 0x000000018614BBA0-0x000000018614BCB0
	}

	public class LoginAgeTipsModel // TypeDefIndex: 81075
	{
		// Fields
		public string contentCache; // 0x10
		public bool isShow; // 0x18
		public bool isFetchingContent; // 0x19
	
		// Constructors
		public LoginAgeTipsModel(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool IsContentEmpty(); // 0x000000018614BED0-0x000000018614BF10
		public bool CanDisplay(); // 0x000000018708F900-0x000000018708F930
	}

	public class LoginAgeTipsProp : LoginProperty<LoginAgeTipsModel> // TypeDefIndex: 81076
	{
		// Constructors
		public LoginAgeTipsProp(LoginWorkFlow workflow); // 0x000000018614BDD0-0x000000018614BE40
	
		// Methods
		public void ClearContentCache(); // 0x000000018614BE40-0x000000018614BED0
		public void UpdateContent(string content); // 0x0000000188CBECA8-0x0000000188CBED64
	}

	public class LoginWorkFlow : IDisposable // TypeDefIndex: 81087
	{
		// Fields
		public const string CURSOR_KEY_LOGIN = "login"; // Metadata: 0x0263E0A7
		private static bool s_hasEnteredPreloadThisSession; // 0x00
		private static readonly ENode[] NODE_ORDER; // 0x08
		private const ENode NEED_GAME_LOGIN_STATE_BEFORE_NODE = ENode.Preload; // Metadata: 0x0263E0AD
		private readonly Node[] m_nodes; // 0x10
		private readonly LoginContext m_context; // 0x18
		private FWork m_work; // 0x20
		private Worker m_worker; // 0x30
		private HashSet<IEventReceiver> m_evtRecvrs; // 0x38
		private List<IEventReceiver> m_recvrBuffer; // 0x40
		[CompilerGenerated]
		private bool _isDisposed_k__BackingField; // 0x48
	
		// Properties
		public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
	
		// Nested types
		public abstract class Node // TypeDefIndex: 81077
		{
			// Fields
			[CompilerGenerated]
			private LoginContext _context_k__BackingField; // 0x10
			[CompilerGenerated]
			private LoginWorkFlow _workflow_k__BackingField; // 0x18
	
			// Properties
			protected LoginContext context { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
			protected LoginWorkFlow workflow { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public abstract ENode type { get; }
	
			// Constructors
			protected Node(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Init(LoginContext context, LoginWorkFlow workflow); // 0x000000018614EB50-0x000000018614EBA0
			public void Dispose(); // 0x000000018614EBD0-0x000000018614EC10
			public abstract CustomYieldInstruction Work();
			public virtual bool CanCancel(); // 0x0000000188CC0514-0x0000000188CC0554
			public virtual CustomYieldInstruction Cancel(); // 0x0000000188CC0554-0x0000000188CC0594
			protected virtual void OnInit(); // 0x000000018614EBA0-0x000000018614EBD0
			public virtual void OnDispose(); // 0x0000000186BBC760-0x0000000186BBC790
			public virtual bool OnEvent(ELoginEvent evt, object param); // 0x00000001850CADE0-0x00000001850CAE10
		}
	
		public enum ENode // TypeDefIndex: 81078
		{
			None = 0,
			CheckForUpdate = 1,
			SDKInit = 2,
			GameUpdate = 3,
			Init = 4,
			U8Login = 5,
			PreDownload = 6,
			HotUpdate = 7,
			ResCheck = 8,
			Preload = 9,
			PreloadPostDelay = 10,
			Trans2GsLogin = 11,
			GsLogin = 12,
			CreateRole = 13,
			Finish = 14
		}
	
		public interface IWorkerUpdateOnce // TypeDefIndex: 81079
		{
			// Methods
			void Worker_UpdateOnce();
		}
	
		public interface IEventReceiver // TypeDefIndex: 81080
		{
			// Methods
			void OnEvent(ELoginEvent evt, object param);
		}
	
		private class Worker : IDisposable // TypeDefIndex: 81082
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
			public bool isCancelled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
			public bool isDisposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
			public Node curNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
			// Nested types
			[CompilerGenerated]
			private sealed class _Work_d__20 : IEnumerator<object> // TypeDefIndex: 81081
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public Worker __4__this; // 0x20
				public CustomYieldInstruction work; // 0x28
				private CustomYieldInstruction _cancelTask_5__2; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public _Work_d__20(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x0000000186163420-0x0000000186163540
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CC0CCC-0x0000000188CC0D18
			}
	
			// Constructors
			public Worker(); // 0x00000001870D1690-0x00000001870D1750
	
			// Methods
			public bool Cancel(); // 0x0000000188CC446C-0x0000000188CC49C0
			public void Dispose(); // 0x000000018718E110-0x000000018718E190
			public void SetCurNode(Node node); // 0x000000018614E8A0-0x000000018614E960
			public bool UpdateOnce(IWorkerUpdateOnce inst); // 0x0000000186942AE0-0x0000000186942B70
			public void TickInEmptyFrame(); // 0x00000001861633F0-0x0000000186163420
			[IteratorStateMachine(typeof(_Work_d__20))]
			public IEnumerator Work(CustomYieldInstruction work); // 0x000000018614EC10-0x000000018614ECB0
			private void _InternalTick(); // 0x0000000186163540-0x0000000186163840
		}
	
		private struct FWork // TypeDefIndex: 81083
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
			public bool didFallback { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD2A0-0x00000001844AD2B0 0x0000000187233BE0-0x0000000187233BF0
			public int nodeIndex { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
			public bool isWorking { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD2B0-0x00000001844AD2C0 0x00000001872399A0-0x00000001872399B0
			public ENode curNode { get; } // 0x000000018614F670-0x000000018614F740 
	
			// Constructors
			static FWork(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void MarkFallback(int newIndex); // 0x0000000188CBE5C4-0x0000000188CBE64C
			public bool ConsumeFallback(); // 0x000000018614F7B0-0x000000018614F820
			public void MoveNextIndex(); // 0x000000018614F740-0x000000018614F7B0
			public static FWork Start(); // 0x00000001871C3AF0-0x00000001871C3B70
			public bool WorkEnd(); // 0x000000018614F820-0x000000018614F8E0
		}
	
		[CompilerGenerated]
		private sealed class _DoWorkFlow_d__25 : IEnumerator<object> // TypeDefIndex: 81084
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DoWorkFlow_d__25(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018614F000-0x000000018614F670
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC0784-0x0000000188CC07D0
		}
	
		[CompilerGenerated]
		private sealed class __FetchAgeTipsCoroutine_d__45 : IEnumerator<object> // TypeDefIndex: 81085
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __FetchAgeTipsCoroutine_d__45(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CC298C-0x0000000188CC2C70
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC2C70-0x0000000188CC2CBC
		}
	
		[CompilerGenerated]
		private sealed class __AdjustCurrentGameState_d__47 : IEnumerator<object> // TypeDefIndex: 81086
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ENode curNode; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __AdjustCurrentGameState_d__47(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186152630-0x00000001861526F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CC23CC-0x0000000188CC2418
		}
	
		// Constructors
		public LoginWorkFlow(LoginContext context); // 0x000000018614ECB0-0x000000018614EE40
		static LoginWorkFlow(); // 0x000000018710FF40-0x000000018710FFE0
	
		// Methods
		public static void MarkEnteredPreloadThisSession(); // 0x000000018614AE10-0x000000018614AE80
		public static void ClearEnteredPreloadThisSession(); // 0x0000000188CBF850-0x0000000188CBF8CC
		public static bool HasEnteredPreloadThisSession(); // 0x0000000188CBFB3C-0x0000000188CBFBB4
		private Node[] _RegisterNodes(); // 0x0000000186BCAA30-0x0000000186BCADE0
		[IteratorStateMachine(typeof(_DoWorkFlow_d__25))]
		public IEnumerator DoWorkFlow(); // 0x0000000185319AA0-0x0000000185319B20
		public void Dispose(); // 0x000000018614EE40-0x000000018614F000
		public bool PeekFallbackStatus(out ENode fallbackNode); // 0x0000000186BBC9A0-0x0000000186BBCA60
		public bool Fallback(ENode target, bool validCheck = true /* Metadata: 0x0263E0A5 */); // 0x0000000188CBF8CC-0x0000000188CBFB3C
		public bool CancelAndFallback(ENode target, bool validCheck = true /* Metadata: 0x0263E0A6 */); // 0x0000000188CBF7E0-0x0000000188CBF850
		public void SendEvent(ELoginEvent evt, object param = null); // 0x00000001850CA940-0x00000001850CACD0
		public void AddEventReceiver(IEventReceiver receiver); // 0x0000000188CBF744-0x0000000188CBF7E0
		public bool UpdateOnce(IWorkerUpdateOnce inst); // 0x0000000186942AA0-0x0000000186942AE0
		public static bool IsBeforeWork(ENode curNode, ENode check); // 0x00000001861512A0-0x0000000186151320
		public static bool IsOnOrAfterWork(ENode curNode, ENode check); // 0x0000000186151450-0x0000000186151500
		public static bool IsAfterWork(ENode target, ENode check); // 0x0000000188CBFBB4-0x0000000188CBFC84
		private bool _HandleGlobalEvent(ELoginEvent evt, object param); // 0x00000001850CACD0-0x00000001850CAD50
		private void _EventOnOpenAgeTips(); // 0x0000000188CBFF38-0x0000000188CC00AC
		private void _EventOnCloseAgeTips(); // 0x0000000188CBFC84-0x0000000188CBFDA4
		private void _EventOnOpenServerSelect(bool isOpen); // 0x0000000188CC00AC-0x0000000188CC0188
		private void _EventOnSelectServer(ServerZoneManager.ServerZoneData serverZoneData); // 0x0000000188CC0188-0x0000000188CC0270
		private void _EventOnConfirmServer(); // 0x0000000188CBFDA4-0x0000000188CBFF38
		private void _EnableCursor(bool enabled); // 0x0000000185B0E5F0-0x0000000185B0E6C0
		private void _UpdateCursor([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input); // 0x0000000188CC0328-0x0000000188CC046C
		private void _EnbaleToggleGroup(); // 0x00000001859BE8A0-0x00000001859BE920
		[IteratorStateMachine(typeof(__FetchAgeTipsCoroutine_d__45))]
		private IEnumerator _FetchAgeTipsCoroutine(LoginAgeTipsProp prop); // 0x0000000188CC0270-0x0000000188CC0328
		private static bool _CheckIfGameStateNotMatch(ENode curNode); // 0x000000018614F8E0-0x000000018614F9B0
		[IteratorStateMachine(typeof(__AdjustCurrentGameState_d__47))]
		private static IEnumerator _AdjustCurrentGameState(ENode curNode); // 0x0000000186E24E00-0x0000000186E24E70
	}

	public class HotUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 81088
	{
		// Fields
		private LoginHotUpdater m_updater; // 0x20
		private int m_cachedResRepairCode; // 0x28
	
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E66010-0x0000000186E66040 
	
		// Constructors
		public HotUpdateNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x00000001862AFC50-0x00000001862AFD20
		public override void OnDispose(); // 0x0000000186BBC6C0-0x0000000186BBC720
		public void __iFixBaseProxy_OnDispose(); // 0x0000000188CB8488-0x0000000188CB8490
	}

	public abstract class WaitForSecondsNode : LoginWorkFlow.Node // TypeDefIndex: 81089
	{
		// Fields
		private int? m_timerId; // 0x20
	
		// Constructors
		protected WaitForSecondsNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x000000018614ABF0-0x000000018614ADD0
		private bool _IsTimeout(); // 0x000000018521CD90-0x000000018521CDF0
		private void _NotifyTimeout(); // 0x00000001871F5A60-0x00000001871F5A90
		private void _DisposeTimer(); // 0x0000000186BBC790-0x0000000186BBC800
		protected abstract float WaitForSeconds(out bool unscaled);
		public override void OnDispose(); // 0x0000000186BBC720-0x0000000186BBC760
		public void __iFixBaseProxy_OnDispose(); // 0x0000000188CB8488-0x0000000188CB8490
	}

	public class PreloadPostDelayNode : WaitForSecondsNode // TypeDefIndex: 81090
	{
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65DA0-0x0000000186E65DD0 
	
		// Constructors
		public PreloadPostDelayNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override float WaitForSeconds(out bool unscaled); // 0x0000000187225980-0x00000001872259B0
		public override CustomYieldInstruction Work(); // 0x000000018614AB30-0x000000018614AB70
		private void _DisableLoadingPanel(); // 0x000000018614C520-0x000000018614C5E0
		public CustomYieldInstruction __iFixBaseProxy_Work(); // 0x0000000188CC077C-0x0000000188CC0784
	}

	public class Trans2GsLoginNode : WaitForSecondsNode // TypeDefIndex: 81091
	{
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E65D40-0x0000000186E65D70 
	
		// Constructors
		public Trans2GsLoginNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override float WaitForSeconds(out bool unscaled); // 0x000000018714D3D0-0x000000018714D4A0
		public override CustomYieldInstruction Work(); // 0x000000018614AB70-0x000000018614ABF0
		public CustomYieldInstruction __iFixBaseProxy_Work(); // 0x0000000188CC077C-0x0000000188CC0784
	}

	public class FinishNode : LoginWorkFlow.Node // TypeDefIndex: 81092
	{
		// Properties
		public override LoginWorkFlow.ENode type { get; } // 0x0000000186E66070-0x0000000186E660A0 
	
		// Constructors
		public FinishNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override CustomYieldInstruction Work(); // 0x0000000186ECF680-0x0000000186ECF710
	}

	public struct CarrierDownloadCache // TypeDefIndex: 81093
	{
		// Fields
		public static readonly CarrierDownloadCache EMPTY; // 0x00
		public long size; // 0x00
		public bool isAllowed; // 0x08
	
		// Constructors
		static CarrierDownloadCache(); // 0x00000001871F4860-0x00000001871F48C0
	}

	public class NetUsagePolicy // TypeDefIndex: 81096
	{
		// Fields
		private const int NOT_REACHABLE_ERROR_CODE = 30000; // Metadata: 0x0263E0BD
		private CarrierDownloadCache m_mobileDataCache; // 0x10
		private NetworkReachability m_lastNetworkState; // 0x20
		private Options m_options; // 0x28
	
		// Nested types
		public struct Options // TypeDefIndex: 81094
		{
			// Fields
			public long minBytesToNotifyCarrier; // 0x00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 81095
		{
			// Fields
			public Action<bool> onCarrierDecision; // 0x10
			public NetUsagePolicy __4__this; // 0x18
			public Action onAllowed; // 0x20
			public Action onRejected; // 0x28
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _CheckIfAllowDownload_b__0(); // 0x0000000188CC0BF4-0x0000000188CC0C38
			internal void _CheckIfAllowDownload_b__1(); // 0x0000000188CC0C38-0x0000000188CC0C68
		}
	
		// Constructors
		public NetUsagePolicy(Options options); // 0x00000001871ED1C0-0x00000001871ED230
	
		// Methods
		public void CheckIfAllowDownload(long downloadSize, Action onAllowed, Action onRejected, Action onReachable = null, Action<bool> onCarrierDecision = null); // 0x000000018614C5E0-0x000000018614C7C0
		public bool AllowMobileDataInLastCheck(); // 0x0000000186C596A0-0x0000000186C596D0
		private static string _GetPrettySizeStringUpToMB(double number); // 0x0000000188CC046C-0x0000000188CC0514
	}

	public class LoginSceneAnimCtrl : LoginSceneComponent, ILoginBinder<LoginViewModel>, IAnimationClipSource // TypeDefIndex: 81098
	{
		// Fields
		private const float COUNT_DOWN_EMPTY = -1f; // Metadata: 0x0263E0C1
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
		protected override TickType tickOption { get; } // 0x0000000186C6BF90-0x0000000186C6BFC0 
	
		// Nested types
		private enum EState // TypeDefIndex: 81097
		{
			NONE = 0,
			A1 = 1,
			A2 = 2
		}
	
		// Constructors
		public LoginSceneAnimCtrl(); // 0x000000018702CDB0-0x000000018702CE10
	
		// Methods
		protected override void OnBindToManager(); // 0x00000001863F8000-0x00000001863F8090
		private UIAnimationMixPlayer _EnsurePlayer(); // 0x00000001867C7D40-0x00000001867C7E10
		private void _ChangeToState(EState target); // 0x00000001861513D0-0x0000000186151450
		private void _ResetToA1(); // 0x00000001867C7740-0x00000001867C7970
		private void _TransitionToA2(); // 0x0000000186DD7670-0x0000000186DD77D0
		private void _PlayA1sAndTriggerNext(); // 0x00000001867C7BA0-0x00000001867C7D40
		private float _RandomIntervalA1s(); // 0x00000001867C7E10-0x00000001867C7F90
		private void _PlayA1A2Impl(); // 0x00000001867C7970-0x00000001867C7BA0
		public void OnValueChanged(LoginViewModel value); // 0x0000000186151320-0x00000001861513D0
		protected override void Start(); // 0x00000001867A12D0-0x00000001867A1390
		public override void Tick(float deltaTime); // 0x000000018575CDF0-0x000000018575D030
		protected override void OnRelease(); // 0x0000000186E108D0-0x0000000186E10960
		public void GetAnimationClips(List<AnimationClip> results); // 0x0000000188CBF58C-0x0000000188CBF5C4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBF5D4-0x0000000188CBF5DC
		public void __iFixBaseProxy_OnBindToManager(); // 0x0000000188CBF5C4-0x0000000188CBF5CC
		public void __iFixBaseProxy_Start(); // 0x0000000188CBF5CC-0x0000000188CBF5D4
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public abstract class LoginSceneComponent : TickableMono // TypeDefIndex: 81099
	{
		// Fields
		[CompilerGenerated]
		private LoginContext _context_k__BackingField; // 0x68
		[CompilerGenerated]
		private LoginController _controller_k__BackingField; // 0x70
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000188CBF5DC-0x0000000188CBF61C 
		protected LoginContext context { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		protected LoginController controller { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
	
		// Constructors
		protected LoginSceneComponent(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected virtual void Start(); // 0x00000001867A29F0-0x00000001867A2A60
		public void Bind(LoginContext context, LoginController controller); // 0x0000000185319900-0x0000000185319960
		protected virtual void OnBindToManager(); // 0x00000001863F8E10-0x00000001863F8E40
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
	}

	public class LoginSceneRoot : LoginSceneComponent // TypeDefIndex: 81100
	{
		// Properties
		protected override TickType tickOption { get; } // 0x00000001871FD9E0-0x00000001871FDA10 
	
		// Constructors
		public LoginSceneRoot(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected override void OnBindToManager(); // 0x0000000185752DC0-0x0000000185752FB0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBF5D4-0x0000000188CBF5DC
		public void __iFixBaseProxy_OnBindToManager(); // 0x0000000188CBF5C4-0x0000000188CBF5CC
	}

	public class LoginAgeTipsDetailPanel : MonoBehaviour, ILoginBinder<LoginAgeTipsModel> // TypeDefIndex: 81101
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
		private const int MAX_TEXT_STRLEN = 10000; // Metadata: 0x0263E0C8
		private const int MIN_TEXT_STRLEN = 1000; // Metadata: 0x0263E0CC
	
		// Constructors
		public LoginAgeTipsDetailPanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void Init(LoginContext context); // 0x000000018663A560-0x000000018663A710
		public void OnValueChanged(LoginAgeTipsModel value); // 0x000000018708F840-0x000000018708F900
		private void _RenderContent(string contentStr); // 0x0000000188CBE6B4-0x0000000188CBE828
		private void _ShowContent(); // 0x0000000188CBE828-0x0000000188CBE878
		private void _EventOnCloseClicked(PointerEventData _); // 0x0000000188CBE64C-0x0000000188CBE6B4
		private static List<string> _SplitLicenseToSegments(string content); // 0x0000000188CBE878-0x0000000188CBEB70
		private static void _SplitLongString(string longStr, List<string> outputList); // 0x0000000188CBEB70-0x0000000188CBEC3C
	}

	public class LoginAgeTipsPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 81102
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
		public LoginAgeTipsPanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnInit(); // 0x000000018663AD20-0x000000018663AE40
		public void OnValueChanged(LoginViewModel value); // 0x000000018614FAA0-0x000000018614FB30
		private void _UpdateAgeTipsPolicy(LoginViewModel.FAgeTipsPolicy policy); // 0x0000000186151960-0x00000001861519E0
		private void _EventOnOpenAgeTipsClicked(PointerEventData _); // 0x0000000188CBEC44-0x0000000188CBECA8
		public void __iFixBaseProxy_OnInit(); // 0x0000000188CBEC3C-0x0000000188CBEC44
	}

	public class LoginAlertDialog : LoginController.Dialog // TypeDefIndex: 81104
	{
		// Fields
		[SerializeField]
		private UIButton _btnConfirm; // 0x38
		[SerializeField]
		private UIText _text; // 0x40
		private FParams m_params; // 0x48
	
		// Nested types
		public struct FParams // TypeDefIndex: 81103
		{
			// Fields
			public string text; // 0x00
			public Action onConfirm; // 0x08
		}
	
		// Constructors
		public LoginAlertDialog(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnInit(); // 0x0000000188CBED64-0x0000000188CBEE50
		public void SetParams(FParams param); // 0x0000000188CBEE50-0x0000000188CBEED0
		private void _OnConfirmClicked(PointerEventData evt); // 0x0000000188CBEED8-0x0000000188CBEF18
		public void __iFixBaseProxy_OnInit(); // 0x0000000188CBEED0-0x0000000188CBEED8
	}

	public class LoginDecorateUI : TickableUIMono, ILoginBinder<LoginViewModel>, ILoginContextReceiver // TypeDefIndex: 81105
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
		protected override TickType tickOption { get; } // 0x0000000186FB8790-0x0000000186FB87C0 
	
		// Constructors
		public LoginDecorateUI(); // 0x00000001870A3230-0x00000001870A32D0
	
		// Methods
		public void OnLoginContext(LoginContext context); // 0x00000001867C71B0-0x00000001867C7270
		public void OnValueChanged(LoginViewModel value); // 0x000000018614FBF0-0x000000018614FDE0
		private void _TriggerTrans2GSLoginImpl(); // 0x00000001867C7380-0x00000001867C7510
		private void _ToggleGlow(bool enable); // 0x00000001867C7510-0x00000001867C7620
		private UIAnimationLayerMixPlayer _EnsureGlowPlayer(); // 0x00000001867C7620-0x00000001867C7740
		public override void Tick(float deltaTime); // 0x000000018575A790-0x000000018575A7C0
		protected override void OnRelease(); // 0x0000000186E10840-0x0000000186E108D0
		private void _TimeManagerTick(float timeDelta); // 0x000000018575C310-0x000000018575C4B0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public class LoginEnterGamePanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 81106
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
		public LoginEnterGamePanel(); // 0x0000000187066D90-0x0000000187066DB0
	
		// Methods
		private void _InitIfNot(); // 0x0000000187030250-0x0000000187030320
		public void OnValueChanged(LoginViewModel value); // 0x000000018614F9B0-0x000000018614FAA0
		private void _OnEnterGameClicked(PointerEventData evt); // 0x00000001870AB7B0-0x00000001870AB870
	}

	public class LoginGovTipsPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 81107
	{
		// Fields
		[SerializeField]
		private UIButton _btnOpen; // 0x28
	
		// Constructors
		public LoginGovTipsPanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnInit(); // 0x000000018663AE40-0x000000018663AF10
		public void OnValueChanged(LoginViewModel value); // 0x0000000186BB4520-0x0000000186BB4580
		private void _EventOnOpenAgeTipsClicked(PointerEventData _); // 0x0000000188CC5AC4-0x0000000188CC5B18
		public void __iFixBaseProxy_OnInit(); // 0x0000000188CBEC3C-0x0000000188CBEC44
	}

	public class LoginJudgeDialog : LoginController.Dialog // TypeDefIndex: 81110
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
		public enum Style // TypeDefIndex: 81108
		{
			Center = 0,
			Left = 1
		}
	
		public struct FParams // TypeDefIndex: 81109
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
		public LoginJudgeDialog(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnInit(); // 0x0000000188CC5B18-0x0000000188CC5C68
		public void SetParams(FParams param); // 0x0000000188CC5C68-0x0000000188CC5EB4
		private void _OnPositiveClicked(PointerEventData evt); // 0x0000000188CC5EF4-0x0000000188CC5F34
		private void _OnNegativeClicked(PointerEventData evt); // 0x0000000188CC5EB4-0x0000000188CC5EF4
		public void __iFixBaseProxy_OnInit(); // 0x0000000188CBEED0-0x0000000188CBEED8
	}

	public class LoginMenuPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 81113
	{
		// Fields
		public const string CONTROLLER_STATE_NORMAL = "Normal"; // Metadata: 0x0263E0D0
		public const string CONTROLLER_STATE_SELECT = "Select"; // Metadata: 0x0263E0D7
		public const string PRE_DOWNLOAD_STATE_AVAILABLE = "Available"; // Metadata: 0x0263E0DE
		public const string PRE_DOWNLOAD_STATE_CONTINUE = "Continue"; // Metadata: 0x0263E0E8
		public const string PRE_DOWNLOAD_STATE_COMPLETED = "Completed"; // Metadata: 0x0263E0F1
		public const string PRE_DOWNLOAD_STATE_PAUSE = "Pause"; // Metadata: 0x0263E0FB
		private const double BYTES_PER_MB = 1048576; // Metadata: 0x0263E101
		private const float LOGIN_SUCCESS_TOAST_HIDE_DELAY = 2f; // Metadata: 0x0263E109
		[SerializeField]
		private UIButton _btnAnnounce; // 0x28
		[SerializeField]
		private UIButton _btnSetting; // 0x30
		[SerializeField]
		private UIButton _btnResCheck; // 0x38
		[SerializeField]
		private UIButton _btnPreDownload; // 0x40
		[SerializeField]
		private UIButton _btnLogout; // 0x48
		[SerializeField]
		private UIButton _btnQuitGame; // 0x50
		[SerializeField]
		private UIButton _btnLogin; // 0x58
		[SerializeField]
		private UIButton _btnQR; // 0x60
		[SerializeField]
		private UIStateController _ctrlAnnounce; // 0x68
		[SerializeField]
		private UIStateController _ctrlSetting; // 0x70
		[SerializeField]
		private UIStateController _ctrlResCheck; // 0x78
		[SerializeField]
		private UIStateController _ctrlPreDownload; // 0x80
		[SerializeField]
		private UIStateController _ctrlLogout; // 0x88
		[SerializeField]
		private UIStateController _ctrlQR; // 0x90
		[SerializeField]
		private UISimpleStateController _ctrlRight; // 0x98
		[SerializeField]
		private UISelectableNaviGroup _naviGroupRight; // 0xA0
		[SerializeField]
		private InputBindingGroupMonoTarget _bindingGroupForKeyboard; // 0xA8
		[SerializeField]
		private InputBindingGroupMonoTarget _rootPanelBindingGroup; // 0xB0
		[SerializeField]
		private CanvasGroup _alphaHandler; // 0xB8
		[SerializeField]
		private GameObject _redDotAnnounce; // 0xC0
		[SerializeField]
		private UIAnimationWrapper _transAnim; // 0xC8
		[SerializeField]
		private UIButton _serverZoneBtn; // 0xD0
		[SerializeField]
		private UIText _serverZoneName; // 0xD8
		[SerializeField]
		private GameObject _serverZonePS5; // 0xE0
		[SerializeField]
		private UIText _serverZoneNamePS5; // 0xE8
		[SerializeField]
		private GameObject _toastCell; // 0xF0
		[SerializeField]
		private UIText _toastTipsTxt; // 0xF8
		private UIStateController m_curRightBtnCtrl; // 0x100
		private bool m_hasRedDot; // 0x108
		private int m_rootParentGroupId; // 0x10C
		private IEnumerator m_toastHideRoutine; // 0x110
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 81111
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__56_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188CCA564-0x0000000188CCA5C8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnQuitGameClicked_b__56_0(); // 0x00000001827C6400-0x00000001827C6700
		}
	
		[CompilerGenerated]
		private sealed class __HideLoginSuccessToastCoroutine_d__65 : IEnumerator<object> // TypeDefIndex: 81112
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginMenuPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __HideLoginSuccessToastCoroutine_d__65(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001827C6700-0x00000001827C6B00
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001827C6B00-0x00000001827C6B50
		}
	
		// Constructors
		public LoginMenuPanel(); // 0x0000000187066DB0-0x0000000187066DD0
	
		// Methods
		protected override void OnInit(); // 0x0000000185B308F0-0x0000000185B34000
		public void OnValueChanged(LoginViewModel value); // 0x000000018614FDE0-0x00000001861512A0
		public void InitBulletinAndRedAfterLoginSuc(); // 0x0000000186817090-0x00000001868171B0
		public void ShowLoginSuccessToast(); // 0x00000001827C0450-0x00000001827C1150
		private static void _OnBulletinOpen(); // 0x00000001850D0900-0x00000001850D0980
		private static void _OnBulletinClose(); // 0x00000001850D0870-0x00000001850D0900
		private void Awake(); // 0x00000001870996E0-0x00000001870997D0
		private void OnEnable(); // 0x0000000186979090-0x00000001869792A0
		private void OnDisable(); // 0x00000001869792A0-0x0000000186979490
		protected override void OnDestroy(); // 0x0000000186D43540-0x0000000186D43640
		private void _OnAnnounceClicked(PointerEventData _); // 0x0000000188CC60F0-0x0000000188CC62A8
		private void _OnSettingClicked(PointerEventData _); // 0x0000000188CC6D44-0x0000000188CC6E3C
		private void _OnResCheckClicked(PointerEventData _); // 0x0000000188CC6C10-0x0000000188CC6CE4
		private void _OnPreDownloadClicked(PointerEventData _); // 0x0000000188CC676C-0x0000000188CC6948
		private void _OnCustomServiceClicked(PointerEventData _); // 0x0000000188CC634C-0x0000000188CC6408
		private void _OnAccountCenterClicked(PointerEventData _); // 0x0000000188CC601C-0x0000000188CC60F0
		private void _OnLogoutClicked(PointerEventData _); // 0x0000000188CC6698-0x0000000188CC676C
		private void _OnQuitGameClicked(PointerEventData _); // 0x0000000188CC6A04-0x0000000188CC6BA8
		private void _OnLoginClicked(PointerEventData _); // 0x0000000188CC6630-0x0000000188CC6698
		private void _OnQRClicked(PointerEventData _); // 0x0000000188CC6948-0x0000000188CC6A04
		private void _OnRequestRelogin(); // 0x0000000188CC6BA8-0x0000000188CC6C10
		private void _HideLoginSuccessToastIfFallback(LoginViewModel value); // 0x00000001827C46E0-0x00000001827C4DB0
		private void _HideLoginSuccessToast(); // 0x00000001827C4DB0-0x00000001827C5190
		private bool _TryGetLoginSuccessAccount(out string account); // 0x00000001827C53A0-0x00000001827C63B0
		private void _RestartToastHideRoutine(); // 0x00000001827C5190-0x00000001827C5270
		private void _StopToastHideRoutine(); // 0x00000001827C5270-0x00000001827C53A0
		[IteratorStateMachine(typeof(__HideLoginSuccessToastCoroutine_d__65))]
		private IEnumerator _HideLoginSuccessToastCoroutine(); // 0x00000001827C4330-0x00000001827C46E0
		private bool _CanQRLogin(); // 0x00000001871FDA10-0x00000001871FDA40
		private void _ShowPreDownloadConfirm(string textKey); // 0x0000000188CC70A0-0x0000000188CC71FC
		private void _ShowPausePreDownloadConfirm(); // 0x0000000188CC6F78-0x0000000188CC70A0
		private void _SendPreDownloadEvent(); // 0x0000000188CC6F10-0x0000000188CC6F78
		private void _SendCancelPreDownloadEventIfNeeded(); // 0x0000000188CC6E3C-0x0000000188CC6F10
		private static string _FormatPreDownloadSize(long bytes); // 0x0000000188CC5F3C-0x0000000188CC601C
		private void _UpdatePreDownloadButtonState(LoginViewModel value); // 0x000000018614D1F0-0x000000018614D310
		private bool _ShouldShowPreDownloadButton(); // 0x000000018614C930-0x000000018614C990
		private void _UpdateAnnounceRedDot(); // 0x00000001868171B0-0x0000000186817260
		private void _UpdateServerZone(); // 0x00000001850CCE60-0x00000001850CCF50
		private void _OnServerZoneBtnClicked(); // 0x0000000188CC6CE4-0x0000000188CC6D44
		private void _OnFocusMenuGroup(bool isFocused); // 0x0000000188CC6408-0x0000000188CC64FC
		private void _OnAnnounceClosed(); // 0x0000000188CC62A8-0x0000000188CC634C
		private void _OnReceiveRedDotAndPopup(bool showRedDot); // 0x0000000186817260-0x0000000186817330
		private void _OnUpdateRedDotForSDKListener([IsReadOnly] in EventData<bool> show); // 0x00000001868175C0-0x00000001868175F0
		private void _OnInputChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input); // 0x0000000188CC64FC-0x0000000188CC6630
		[CompilerGenerated]
		private void _OnInit_b__39_0(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001827C1150-0x00000001827C1790
		[CompilerGenerated]
		private void _OnInit_b__39_1(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001827C1790-0x00000001827C1DD0
		[CompilerGenerated]
		private void _OnInit_b__39_2(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001827C1DD0-0x00000001827C2410
		[CompilerGenerated]
		private void _OnInit_b__39_3(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001827C2410-0x00000001827C2A50
		[CompilerGenerated]
		private void _OnInit_b__39_4(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain); // 0x00000001827C2A50-0x00000001827C3090
		[CompilerGenerated]
		private void _OnInit_b__39_5(PointerEventData _); // 0x00000001827C3090-0x00000001827C30F0
		[CompilerGenerated]
		private void _OnInit_b__39_6(bool isFocused); // 0x00000001827C30F0-0x00000001827C3A00
		[CompilerGenerated]
		private void __OnAnnounceClicked_b__49_0(string s); // 0x00000001827C3A00-0x00000001827C4330
		public void __iFixBaseProxy_OnInit(); // 0x0000000188CBEC3C-0x0000000188CBEC44
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000188CC5F34-0x0000000188CC5F3C
	}

	public class LoginMockUIDPanel : MonoBehaviour // TypeDefIndex: 81116
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
		private const string LAST_SELECTED_SERVER_PREF_KEY = "LoginMockUIDPanel.LastSelectedServer"; // Metadata: 0x0263E10D
		private static LoginMockUIDPanel s_instance; // 0x00
	
		// Properties
		public static LoginMockUIDPanel instance { get; } // 0x0000000188CC73CC-0x0000000188CC743C 
	
		// Nested types
		public struct FOptions // TypeDefIndex: 81114
		{
			// Fields
			public string fixedUID; // 0x00
			public LoginContext context; // 0x08
	
			// Methods
			public bool IsUIDFixed(); // 0x0000000186B3D6F0-0x0000000186B3D730
		}
	
		[CompilerGenerated]
		private sealed class _HideAndDestroy_d__22 : IEnumerator<object> // TypeDefIndex: 81115
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginMockUIDPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _HideAndDestroy_d__22(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001863F76E0-0x00000001863F7810
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CCA150-0x0000000188CCA19C
		}
	
		// Constructors
		public LoginMockUIDPanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void LoginWithCallback(FOptions options, Action<string> callback); // 0x0000000186B3B690-0x0000000186B3C210
		public void Refresh(); // 0x0000000188CC71FC-0x0000000188CC7234
		[IteratorStateMachine(typeof(_HideAndDestroy_d__22))]
		public IEnumerator HideAndDestroy(); // 0x0000000186B3B590-0x0000000186B3B610
		private void _UpdateStatus(); // 0x0000000186B3C210-0x0000000186B3D6F0
		private void _InitLoginInfo(); // 0x00000001861207D0-0x0000000186122FF0
		private void _MovePreferredServerToFront(ref int curServerIndex); // 0x0000000186DDF7C0-0x0000000186DDF9A0
		private int _IndexOfServer(string serverName); // 0x0000000186120560-0x0000000186120670
		private void _SaveLastSelectedServer(string serverName); // 0x000000018611EB50-0x000000018611EBF0
		private void _SaveConfig(); // 0x000000018611FC30-0x000000018611FCB0
		private void _OnBtnEnterGame(); // 0x0000000187121E70-0x0000000187121EF0
		private void _SmokeEnterGame(string serverName, string uid); // 0x0000000188CC7280-0x0000000188CC732C
		private void _OnBtnDelLocalFile(); // 0x0000000188CC7244-0x0000000188CC7280
		private void _TryClosePanel(); // 0x0000000188CC732C-0x0000000188CC73CC
		private void _OnSelectServer(int index); // 0x000000018611EC90-0x000000018611FBC0
		private void OnDestroy(); // 0x00000001871F56A0-0x00000001871F56E0
		[CompilerGenerated]
		private void __UpdateStatus_b__23_0(PointerEventData _); // 0x0000000187121E60-0x0000000187121E70
		[CompilerGenerated]
		private void __UpdateStatus_b__23_1(PointerEventData _); // 0x0000000188CC7234-0x0000000188CC723C
		[CompilerGenerated]
		private void __UpdateStatus_b__23_2(PointerEventData _); // 0x0000000188CC723C-0x0000000188CC7244
		[CompilerGenerated]
		private void __InitLoginInfo_b__24_0(int index, UIDropdownOption options, bool isSelected); // 0x0000000185395140-0x0000000185395190
	}

	public class LoginResourcePanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginHotUpdateModel> // TypeDefIndex: 81117
	{
		// Fields
		private const float PROGRESS_LERP_DURATION = 0.2f; // Metadata: 0x0263E132
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
		public LoginResourcePanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void OnValueChanged(LoginHotUpdateModel value); // 0x0000000186151BC0-0x0000000186151C70
		private void _UpdateResourceInfo(); // 0x000000018539A070-0x000000018539A260
		private void Update(); // 0x00000001853998C0-0x0000000185399AA0
	}

	public class LoginRootPanel : MonoBehaviour // TypeDefIndex: 81119
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
		[SerializeField]
		private GameObject _debugPanel; // 0x58
		[SerializeField]
		private UIText _debugNodeNameText; // 0x60
		[SerializeField]
		private UIText _debugTaskIdText; // 0x68
		[SerializeField]
		private UIText _debugTaskStateText; // 0x70
		private int m_loginRootBindingGroupId; // 0x78
	
		// Nested types
		public abstract class ChildPanel : MonoBehaviour, ILoginContextReceiver // TypeDefIndex: 81118
		{
			// Fields
			[CompilerGenerated]
			private UISwitchTween _switchTween_k__BackingField; // 0x18
			[CompilerGenerated]
			private LoginContext _context_k__BackingField; // 0x20
	
			// Properties
			protected UISwitchTween switchTween { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			protected LoginContext context { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
			// Constructors
			protected ChildPanel(); // 0x00000001878364A0-0x00000001878364B8
	
			// Methods
			public void OnLoginContext(LoginContext context); // 0x00000001863F8DC0-0x00000001863F8E10
			protected virtual void OnInit(); // 0x000000018663AF10-0x000000018663AF40
			protected virtual void OnDestroy(); // 0x0000000186D43640-0x0000000186D43690
			protected void SetPanelVisibleByAnimSwitchTween(UIAnimationWrapper anim, bool isVisible, bool forceReset = false /* Metadata: 0x0263E136 */); // 0x0000000188CC49C0-0x0000000188CC4ABC
			protected void SetPanelVisibleByFadeSwitchTween(CanvasGroup canvasGroup, bool isVisible, bool forceReset = false /* Metadata: 0x0263E137 */); // 0x00000001861515D0-0x00000001861516C0
		}
	
		// Constructors
		public LoginRootPanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x0000000185C42540-0x0000000185C42640
		private void OnDestroy(); // 0x0000000185C42640-0x0000000185C43790
		public void Init(LoginContext context); // 0x00000001863F8090-0x00000001863F8C30
		private void _OnNotchPaddingChanged([IsReadOnly] in EventData<float> data); // 0x0000000188CC74DC-0x0000000188CC758C
		private void _InitController(); // 0x000000018663A7A0-0x000000018663A860
		public void ToggleLoginBindingGroup(bool enable); // 0x0000000188CC743C-0x0000000188CC74DC
		public void InitBulletinAndRedAfterLoginSuc(); // 0x00000001863F6530-0x00000001863F6570
		public void ShowLoginSuccessToast(); // 0x00000001827C63B0-0x00000001827C6400
		private void _SetDebugPanelActive(bool active); // 0x0000000186B7BDA0-0x0000000186B7BE70
		private static void _InitChildPanel(ChildPanel childPanel, LoginContext context); // 0x00000001863F8C30-0x00000001863F8DC0
	}

	public class LoginServerSelectItemView : MonoBehaviour // TypeDefIndex: 81121
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
		private const string DEFAULT_TEXT = "--"; // Metadata: 0x0263E138
		private static readonly DelayInfo DEFAULT_SPEED_INFO; // 0x10
		private ServerZoneManager.ServerZoneData m_serverItem; // 0x50
		private LoginContext m_context; // 0x58
		private List<DelayInfo> m_speedInfos; // 0x60
	
		// Nested types
		private struct DelayInfo // TypeDefIndex: 81120
		{
			// Fields
			public UnityEngine.Color color; // 0x00
			public int colorCount; // 0x10
			public int delayMax; // 0x14
			public string text; // 0x18
		}
	
		// Constructors
		public LoginServerSelectItemView(); // 0x0000000186B063B0-0x0000000186B06760
		static LoginServerSelectItemView(); // 0x00000001870A8FE0-0x00000001870A90C0
	
		// Methods
		public void RefreshView(LoginContext context, ServerZoneManager.ServerZoneData serverItem, bool isSelected); // 0x0000000188CC7624-0x0000000188CC7B18
		public void NaviToBtnTarget(); // 0x0000000188CC758C-0x0000000188CC7624
		public void SetSelected(bool isSelected); // 0x0000000188CC7B18-0x0000000188CC7BC8
		private void _OnClicked(PointerEventData _); // 0x0000000188CC7BC8-0x0000000188CC7C2C
	}

	public class LoginServerSelectProp : LoginProperty<LoginServerSelectModel> // TypeDefIndex: 81122
	{
		// Constructors
		public LoginServerSelectProp(LoginWorkFlow workflow); // 0x000000018614BCB0-0x000000018614BD00
	}

	public class LoginServerItem // TypeDefIndex: 81123
	{
		// Fields
		public ServerZoneManager.ServerZoneData serverZoneData; // 0x10
	
		// Constructors
		public LoginServerItem(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class LoginServerSelectModel // TypeDefIndex: 81124
	{
		// Fields
		public bool showPanel; // 0x10
		public int selectedIndex; // 0x14
	
		// Properties
		public List<ServerZoneManager.ServerZoneData> serverList { get; } // 0x0000000188CC7EB4-0x0000000188CC7F4C 
		public ServerZoneManager.ServerZoneData curServerZoneData { get; } // 0x0000000188CC7E18-0x0000000188CC7EB4 
	
		// Constructors
		public LoginServerSelectModel(); // 0x00000001872399B0-0x00000001872399C0
	
		// Methods
		public void InitData(); // 0x0000000188CC7CBC-0x0000000188CC7D20
		public ServerZoneManager.ServerZoneData GetSelectedServer(); // 0x0000000188CC7C2C-0x0000000188CC7CBC
		public bool UpdateSelectedServer(ServerZoneManager.ServerZoneData selectedServer); // 0x0000000188CC7D20-0x0000000188CC7E18
	}

	public class LoginServerSelectPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginServerSelectModel> // TypeDefIndex: 81127
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
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 81125
		{
			// Fields
			public LoginServerSelectPanel __4__this; // 0x10
			public List<ServerZoneManager.ServerZoneData> serverZoneDataList; // 0x18
			public List<SpeedTestServerInfo> serverList; // 0x20
			public Action<SpeedTestResult> callback; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnEnable_b__0(SpeedTestResult result); // 0x0000000188CCA19C-0x0000000188CCA4F4
			internal Task<Hypergryph.SpeedTest.TaskResult> _OnEnable_b__1(); // 0x0000000188CCA4F4-0x0000000188CCA564
		}
	
		[CompilerGenerated]
		private sealed class __WaitingForShowListAwake_d__11 : IEnumerator<object> // TypeDefIndex: 81126
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginServerSelectPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __WaitingForShowListAwake_d__11(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CCA5C8-0x0000000188CCA6BC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CCA6BC-0x0000000188CCA708
		}
	
		// Constructors
		public LoginServerSelectPanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnInit(); // 0x000000018663C0B0-0x000000018663C330
		private void OnDisable(); // 0x0000000188CC7F4C-0x0000000188CC8050
		private void OnEnable(); // 0x0000000188CC8050-0x0000000188CC872C
		[IteratorStateMachine(typeof(__WaitingForShowListAwake_d__11))]
		private IEnumerator _WaitingForShowListAwake(); // 0x0000000188CC8CD4-0x0000000188CC8D6C
		private void _UpdateServerCell(GameObject cell, int index); // 0x0000000188CC8AFC-0x0000000188CC8C0C
		private void _UpdateServerSelected(int index, GameObject cell); // 0x0000000188CC8C0C-0x0000000188CC8CD4
		public void OnValueChanged(LoginServerSelectModel value); // 0x0000000188CC872C-0x0000000188CC8888
		private void _NaviToSelectedItem(); // 0x0000000188CC8888-0x0000000188CC89E0
		private void _OnInputChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input); // 0x0000000188CC8AB0-0x0000000188CC8AFC
		private void _OnCloseClicked(PointerEventData _); // 0x0000000188CC89E0-0x0000000188CC8A48
		private void _OnConfirmClicked(PointerEventData _); // 0x0000000188CC8A48-0x0000000188CC8AB0
		public void __iFixBaseProxy_OnInit(); // 0x0000000188CBEC3C-0x0000000188CBEC44
	}

	public class LoginVersionPanel : MonoBehaviour // TypeDefIndex: 81128
	{
		// Fields
		[SerializeField]
		private UIText _textVersion; // 0x18
	
		// Properties
		public string displayGameVersion { get; } // 0x0000000186C4BA30-0x0000000186C4BBD0 
		private string versionZoneType { get; } // 0x0000000186C4BDB0-0x0000000186C4BE30 
		private string versionPlatform { get; } // 0x0000000186C4BC70-0x0000000186C4BCD0 
		private string versionAppType { get; } // 0x0000000186C4BC10-0x0000000186C4BC70 
		private string versionVersionNum { get; } // 0x0000000186C4BD40-0x0000000186C4BDB0 
		private string versionProjectCL { get; } // 0x0000000186C4BCD0-0x0000000186C4BD40 
	
		// Constructors
		public LoginVersionPanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Start(); // 0x0000000186C4B960-0x0000000186C4BA30
	}

	public class LoginVocResSelDialog : LoginController.Dialog // TypeDefIndex: 81131
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
		public struct FParams // TypeDefIndex: 81129
		{
			// Fields
			public Action onConfirm; // 0x00
		}
	
		public class VocResInfo // TypeDefIndex: 81130
		{
			// Fields
			public string nameTextId; // 0x10
			public EVFSBlockType type; // 0x18
	
			// Constructors
			public VocResInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public LoginVocResSelDialog(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnInit(); // 0x0000000188CC8F7C-0x0000000188CC9318
		private int _ResolveInitialSelectedIndex(); // 0x0000000188CC98EC-0x0000000188CC9A30
		private void _RefreshConfirmInteractable(); // 0x0000000188CC988C-0x0000000188CC98EC
		private void OnEnable(); // 0x0000000188CC8E70-0x0000000188CC8F7C
		private void OnDisable(); // 0x0000000188CC8D6C-0x0000000188CC8E70
		public void SetParams(FParams param); // 0x0000000188CC9318-0x0000000188CC9358
		public void UpdateSelected(EVFSBlockType type); // 0x0000000188CC9358-0x0000000188CC9460
		private void _UpdateList(); // 0x0000000188CC9B1C-0x0000000188CC9BE0
		private void _UpdateSelected(int index, GameObject cell); // 0x0000000188CC9BE0-0x0000000188CC9C98
		private void _UpdateCell(GameObject cell, int index); // 0x0000000188CC9A30-0x0000000188CC9B1C
		[IDTag(1)]
		private void _OnConfirmClicked(PointerEventData evt); // 0x0000000188CC9780-0x0000000188CC9840
		[IDTag(0)]
		private void _OnConfirmClicked(); // 0x0000000188CC95A8-0x0000000188CC9780
		private void _OnInputTypeChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> data); // 0x0000000188CC9840-0x0000000188CC988C
		private void _NaviToSelectedItem(); // 0x0000000188CC9460-0x0000000188CC95A8
		public void __iFixBaseProxy_OnInit(); // 0x0000000188CBEED0-0x0000000188CBEED8
	}

	public class LoginVocResSelItemView : MonoBehaviour // TypeDefIndex: 81132
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
		private const double MB = 1048576; // Metadata: 0x0263E13B
	
		// Constructors
		public LoginVocResSelItemView(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void RefreshView(LoginVocResSelDialog context, LoginVocResSelDialog.VocResInfo info, bool isSelected); // 0x0000000188CC9D30-0x0000000188CCA03C
		public void NaviToBtnTarget(); // 0x0000000188CC9C98-0x0000000188CC9D30
		public void SetSelected(bool isSelected); // 0x0000000188CCA03C-0x0000000188CCA0EC
		private void _OnClicked(PointerEventData _); // 0x0000000188CCA0EC-0x0000000188CCA150
	}
}

namespace Beyond.Scripts.Entry
{
	public static class GameSettingSetter // TypeDefIndex: 81133
	{
		// Methods
		public static void RegisterSettingCallbacks(); // 0x00000001861E9E70-0x00000001861EA710
		private static void _OnAudioGlobalVolumeChange(float volume); // 0x00000001861E7F20-0x00000001861E7FA0
		private static void _OnAudioMusicVolumeChange(float volume); // 0x00000001861E7EA0-0x00000001861E7F20
		private static void _OnAudioVoiceVolumeChange(float volume); // 0x00000001861E8080-0x00000001861E8100
		private static void _OnAudioSfxVolumeChange(float volume); // 0x00000001861E8100-0x00000001861E8180
		private static void _OnAudioSuspendUnfocusedChange(bool suspendUnfocused); // 0x00000001861E85E0-0x00000001861E8670
		private static void _OnAudioBackgroundMusicChange(bool enable); // 0x0000000188CC4ABC-0x0000000188CC4AF4
		private static void _OnAudioSuiteModeChange(Beyond.GameSetting.GameSettingAudioSuiteMode mode); // 0x00000001861E9050-0x00000001861E90F0
		private static void _OnAudioControllerChange(bool enable); // 0x00000001861E8550-0x00000001861E85E0
		private static void _OnAudioSpatialAudioChange(bool enable); // 0x00000001861E83D0-0x00000001861E8440
		private static void _OnCameraDistanceLevelChange(float distance); // 0x00000001871783E0-0x0000000187178470
		private static void _OnControllerMotionChange(bool valid); // 0x00000001861E84C0-0x00000001861E8550
		private static void _OnKeyboardTypeChange(Beyond.GameSetting.KeyboardLayoutType value); // 0x00000001861E8670-0x00000001861E86F0
		private static void _OnLanguageTextChange(EnvLang language); // 0x000000018671D4A0-0x000000018671D6A0
		private static void _OnLanguageAudioChange(Beyond.GameSetting.GameSettingLanguageAudio language); // 0x00000001861E8E10-0x00000001861E8F40
		private static void _OnVideoQualityChange(Beyond.GameSetting.GameSettingVideoQuality quality); // 0x00000001867F1830-0x00000001867F18B0
		private static void _OnVideoFullScreenChange(bool fullScreen); // 0x00000001861E8440-0x00000001861E84C0
		private static void _OnVideoResolutionChange(Beyond.GameSetting.ScreenResolution newResolution); // 0x00000001861E8930-0x00000001861E8C70
		private static void _SetResolution(int width, int height, bool fullScreen); // 0x0000000185E38EF0-0x0000000185E390D0
		private static void _OnVideoNotchPaddingChange(float notchPadding); // 0x0000000188CC4AF4-0x0000000188CC4BB0
		private static void _OnTeammateSkillEffectStrengthChange(Beyond.GameSetting.TeammateSkillEffectStrength strength); // 0x00000001861E86F0-0x00000001861E8790
		private static void _OnTeammateSkillEffectOpacityChange(float opacity); // 0x00000001861E7FA0-0x00000001861E8030
	}

	public class WarmUpProgress : LoginHotUpdateModel.IProgress // TypeDefIndex: 81134
	{
		// Constructors
		public WarmUpProgress(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public double GetTotal(); // 0x0000000188CCA808-0x0000000188CCA894
		public double GetCurrent(); // 0x0000000188CCA708-0x0000000188CCA798
		public string GetInfo(); // 0x0000000188CCA798-0x0000000188CCA808
	}
}

namespace Beyond.SDK
{
	public class PlatformFont : IPlatformFont // TypeDefIndex: 80916
	{
		// Fields
		private const int DEFAULT_FONT_ID = -430371804; // Metadata: 0x0263DE70
		private readonly bool m_forceChineseFont; // 0x10
	
		// Constructors
		public PlatformFont(bool forceChineseFont = false /* Metadata: 0x0263DE6F */); // 0x0000000182A819C0-0x0000000182A819D0
	
		// Methods
		public TMP_FontAsset GetFont(); // 0x0000000188CB3630-0x0000000188CB36C8
	}

	public static class SDKLaunchAuth // TypeDefIndex: 80918
	{
		// Fields
		public const long ERROR_UNKNOWN = 10999; // Metadata: 0x0263DE75
		public const float NETWORK_CFG_TIMEOUT_SECONDS = 1f; // Metadata: 0x0263DE7D
		[CompilerGenerated]
		private static bool _hasFailed_k__BackingField; // 0x00
		private static bool s_waiting; // 0x01
		private static bool s_done; // 0x02
		private static bool s_success; // 0x03
		private static long s_errorCode; // 0x08
		private static string s_filePath; // 0x10
	
		// Properties
		public static bool hasFailed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182758870-0x0000000182758B70 0x0000000182758B70-0x0000000182758E70
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitIfNeeded_d__11 : IEnumerator<object> // TypeDefIndex: 80917
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitIfNeeded_d__11(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018275AFA0-0x000000018275CA20
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018275CA20-0x000000018275CA70
		}
	
		// Methods
		[IteratorStateMachine(typeof(_WaitIfNeeded_d__11))]
		public static IEnumerator WaitIfNeeded(); // 0x0000000182756F20-0x0000000182757250
		public static void OnResult(bool success, long errorCode, string filePath); // 0x0000000182756870-0x0000000182756F20
		private static bool _ShouldRun(); // 0x00000001827584F0-0x0000000182758870
		private static bool _IsExcludedSubChannel(); // 0x0000000182757B20-0x0000000182757EF0
		private static bool _HasNetworkCfg(); // 0x0000000182757250-0x0000000182757B20
		private static bool _IsLaunchAuthEnabled(); // 0x0000000182757EF0-0x00000001827584F0
	}

	public static class SDKNetUtils // TypeDefIndex: 80927
	{
		// Fields
		public const string CONTENT_TYPE_JSON = "application/json"; // Metadata: 0x0263DE81
		private const int GENERAL_TIMEOUT = 30; // Metadata: 0x0263DE92
		private static HTTPImpl s_HTTPImpl; // 0x00
	
		// Nested types
		public struct HttpPostRequest // TypeDefIndex: 80919
		{
			// Fields
			public string url; // 0x00
			public string param; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> header; // 0x18
			public Action<WebHttpResponse> callback; // 0x20
		}
	
		public struct HttpGetRequest // TypeDefIndex: 80920
		{
			// Fields
			public string url; // 0x00
			public Action<WebHttpResponse> callback; // 0x08
		}
	
		public struct WebHttpResponse // TypeDefIndex: 80921
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
	
		private enum HTTPOptType // TypeDefIndex: 80922
		{
			GET = 0,
			POST = 1
		}
	
		private struct HTTPConfig // TypeDefIndex: 80923
		{
			// Fields
			public string url; // 0x00
			public string body; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> header; // 0x18
			public HTTPOptType optType; // 0x20
			public Action<WebHttpResponse> callback; // 0x28
		}
	
		private abstract class HTTPImpl // TypeDefIndex: 80924
		{
			// Constructors
			protected HTTPImpl(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public abstract IEnumerator DoHTTP(HTTPConfig config);
		}
	
		private class BeyondHttp : HTTPImpl // TypeDefIndex: 80926
		{
			// Nested types
			[CompilerGenerated]
			private sealed class _DoHTTP_d__0 : IEnumerator<object> // TypeDefIndex: 80925
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public HTTPConfig config; // 0x20
				private WaitForAsyncTask<HttpSender.Result> _sendTask_5__2; // 0x50
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public _DoHTTP_d__0(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x0000000185B67150-0x0000000185B673A0
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CB3E54-0x0000000188CB3EA0
			}
	
			// Constructors
			public BeyondHttp(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			[IteratorStateMachine(typeof(_DoHTTP_d__0))]
			public override IEnumerator DoHTTP(HTTPConfig config); // 0x0000000186FD1FA0-0x0000000186FD2040
		}
	
		// Constructors
		static SDKNetUtils(); // 0x00000001871CA070-0x00000001871CA0E0
	
		// Methods
		public static void HTTPPost(HttpPostRequest request); // 0x0000000186CA2A80-0x0000000186CA35D0
		public static void HTTPGet(HttpGetRequest request); // 0x0000000188CB36C8-0x0000000188CB38B4
	}

	public static class SDKTextDefines // TypeDefIndex: 80928
	{
		// Fields
		public const string CS_SDK_STO_DESC = "CS_SDK_STO_DESC"; // Metadata: 0x0263DE95
		public const string CS_SDK_COMMON_ERROR = "CS_SDK_COMMON_ERROR"; // Metadata: 0x0263DEA5
		public const string CS_SDK_CREATE_ORDER_ERROR = "CS_SDK_CREATE_ORDER_ERROR"; // Metadata: 0x0263DEB9
		public const string CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT = "CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT"; // Metadata: 0x0263DED3
		public const string CS_SDK_USR_BAN = "CS_SDK_USR_BAN"; // Metadata: 0x0263DEF9
		public const string CS_SDK_USR_BAN_TIME = "CS_SDK_USR_BAN_TIME"; // Metadata: 0x0263DF08
		public const string CS_SDK_LOGIN_FORBID = "CS_SDK_LOGIN_FORBID"; // Metadata: 0x0263DF1C
		public const string CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT = "CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT"; // Metadata: 0x0263DF30
		public const string CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR = "CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR"; // Metadata: 0x0263DF5A
		public const string CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID = "CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID"; // Metadata: 0x0263DF82
	}
}

namespace Beyond.SDK.Impl
{
	public class U8ExternalTools : SDKExternalToolsShortcut // TypeDefIndex: 80936
	{
		// Fields
		private static bool s_inited; // 0x00
		private static bool s_initing; // 0x01
		private static bool s_needRetry; // 0x02
		private static bool s_needQuitGame; // 0x03
		private static FHGSDKInit s_initHGSDK; // 0x04
	
		// Nested types
		private struct FHGSDKInit // TypeDefIndex: 80929
		{
			// Fields
			public bool isIniting; // 0x00
			public bool isInited; // 0x01
		}
	
		private class CaptchaHandler : SDKCaptchaHandler // TypeDefIndex: 80931
		{
			// Fields
			private const int FAILED = 1000; // Metadata: 0x0263DFAA
			private long m_flag; // 0x10
			private string m_desc; // 0x18
	
			// Nested types
			[CompilerGenerated]
			private sealed class _FetchCaptchaCoroutine_d__3 : IEnumerator<object> // TypeDefIndex: 80930
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string captchaParams; // 0x20
				public CaptchaHandler __4__this; // 0x28
				public SDKCaptchaHandler.Result outResult; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
				object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
				// Constructors
				[DebuggerHidden]
				public _FetchCaptchaCoroutine_d__3(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
				private bool MoveNext(); // 0x0000000188CB3EA0-0x0000000188CB3F9C
				[DebuggerHidden]
				void IEnumerator.Reset(); // 0x0000000188CB3F9C-0x0000000188CB3FE8
			}
	
			// Constructors
			public CaptchaHandler(); // 0x0000000187239970-0x0000000187239980
	
			// Methods
			[IteratorStateMachine(typeof(_FetchCaptchaCoroutine_d__3))]
			public override IEnumerator FetchCaptchaCoroutine(string captchaParams, Result outResult); // 0x0000000188CAC5B8-0x0000000188CAC68C
			public void OnGT3Message(Dictionary<string, object> msg); // 0x0000000188CAC68C-0x0000000188CAC788
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80932
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<object> __9__9_0; // 0x08
			public static Action<string> __9__9_1; // 0x10
			public static Action __9__27_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001871E6F20-0x00000001871E6F80
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _InitSDKSystem_b__9_0(object error); // 0x0000000188CB43D8-0x0000000188CB4580
			internal void _InitSDKSystem_b__9_1(string rawExtConfig); // 0x0000000186E61930-0x0000000186E61A20
			internal void __ProcessExtraInfo_b__27_0(); // 0x0000000188CB45A0-0x0000000188CB4608
		}
	
		[CompilerGenerated]
		private sealed class _WaitForInited_d__10 : IEnumerator<object> // TypeDefIndex: 80933
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForInited_d__10(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186FC5030-0x0000000186FC50B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB4D2C-0x0000000188CB4D78
		}
	
		[CompilerGenerated]
		private sealed class _WaitForInitHGSDK_d__15 : IEnumerator<object> // TypeDefIndex: 80934
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForInitHGSDK_d__15(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001870DC6A0-0x00000001870DC710
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CBD370-0x0000000188CBD3BC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 80935
		{
			// Fields
			public Action<SDKExternalTools.POSTResult> callback; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _POSTImplementation_b__0(SDKNetUtils.WebHttpResponse webRequest); // 0x0000000186DDCD00-0x0000000186DDCD70
		}
	
		// Constructors
		public U8ExternalTools(); // 0x000000018721F310-0x000000018721F320
	
		// Methods
		public static bool IsInited(); // 0x0000000188CB61B8-0x0000000188CB6224
		public static bool NeedRetryInit(); // 0x0000000188CB6394-0x0000000188CB6404
		public static bool NeedQuitGame(); // 0x0000000188CB6324-0x0000000188CB6394
		public static void RetryInitSDKSystem(string env); // 0x0000000188CB6404-0x0000000188CB64AC
		public static void PublicSetGameVersion(string version); // 0x0000000185319B60-0x0000000185319BF0
		public static void InitSDKSystem(string env); // 0x0000000186CF3A30-0x0000000186CF5440
		[IteratorStateMachine(typeof(_WaitForInited_d__10))]
		public static IEnumerator WaitForInited(); // 0x0000000186F94440-0x0000000186F944A0
		public static void InitHGSDK(string env); // 0x00000001859BC7A0-0x00000001859BC910
		public static bool IsHGSDKInited(); // 0x0000000188CB6148-0x0000000188CB61B8
		[IteratorStateMachine(typeof(_WaitForInitHGSDK_d__15))]
		public static IEnumerator WaitForInitHGSDK(); // 0x00000001871DCB30-0x00000001871DCB90
		protected override void Log(string content); // 0x0000000188CB62EC-0x0000000188CB6324
		protected override void LogError(string content); // 0x0000000188CB6224-0x0000000188CB62B4
		protected override void LogWarning(string content); // 0x0000000188CB62B4-0x0000000188CB62EC
		protected override string GetSignKey(); // 0x0000000188CB60D8-0x0000000188CB6148
		public override Dictionary<string, string> GetDeviceIDs(); // 0x0000000188CB5D6C-0x0000000188CB5EA4
		public void SetSubChannel(string subChannel); // 0x0000000188CB64AC-0x0000000188CB64EC
		protected override int GetPlatformKey(); // 0x0000000188CB605C-0x0000000188CB60D8
		public override void OnSDKExtraInfo(string jsonData); // 0x00000001859BF150-0x00000001859BF1F0
		protected override string U8RootUrl(); // 0x00000001867A2DE0-0x00000001867A2E60
		protected override void POSTImplementation(POSTRequest request, Action<POSTResult> callback); // 0x00000001856B92F0-0x00000001856B9530
		private static POSTResult _ConvertToPOSTResult(SDKNetUtils.WebHttpResponse response); // 0x0000000186DDCD70-0x0000000186DDCE30
		private void _ProcessExtraInfo(SDKExtraData extraData); // 0x0000000186B84830-0x0000000186B88420
		private static void _ProcessLaunchAuth(Dictionary<string, object> msg); // 0x000000018275CA70-0x000000018275DA10
		private static void _TryGetLaunchAuthDetail(Dictionary<string, object> msg, out long errorCode, out string filePath); // 0x000000018275DA10-0x000000018275F060
		private static void _ProcessGameProtocolUpdateCheck(Dictionary<string, object> msg); // 0x0000000188CB6960-0x0000000188CB6AE8
		private static long _TryGetGameProtocolUpdateCheckErrorCode(Dictionary<string, object> msg); // 0x0000000188CB6AE8-0x0000000188CB6D4C
		private static void _OnRequestExitGame(); // 0x0000000188CB68C0-0x0000000188CB6960
		private static void _OnFakeAccountCenter(); // 0x0000000188CB688C-0x0000000188CB68C0
		protected override SDKCaptchaHandler CreateCaptchaHandler(); // 0x0000000188CB5CE4-0x0000000188CB5D6C
		protected override string GetErrorMessage(ErrMsgMeta meta); // 0x0000000188CB5EA4-0x0000000188CB605C
		private bool _ErrorMsg_GET_TOKEN(ErrMsgMeta meta, out string errorMsg); // 0x0000000188CB6680-0x0000000188CB688C
		private bool _ErrorMsg_CREATE_ORDER(ErrMsgMeta meta, out string errorMsg); // 0x0000000188CB64F4-0x0000000188CB6680
		public string __iFixBaseProxy_GetSignKey(); // 0x0000000185829EC0-0x0000000185829ED0
		public Dictionary<string, string> __iFixBaseProxy_GetDeviceIDs(); // 0x0000000188CB64EC-0x0000000188CB64F4
		public void __iFixBaseProxy_OnSDKExtraInfo(string P0); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class U8Plugin : IExternalPlugin // TypeDefIndex: 80939
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 80937
		{
			// Fields
			public ExternalPluginPayParams args; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Pay_b__0(U8PayResult payResult); // 0x0000000188CBD254-0x0000000188CBD288
			internal void _Pay_b__1(object failMsg); // 0x0000000188CBD288-0x0000000188CBD2A8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 80938
		{
			// Fields
			public ExternalPluginLoginParams args; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __MockLogin_b__0(string uid); // 0x00000001859BC9F0-0x00000001859BCB00
		}
	
		// Constructors
		public U8Plugin(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public string GetPayAddition(); // 0x0000000188CBE084-0x0000000188CBE0C4
		public string GetSDKToken(); // 0x0000000188CBE0C4-0x0000000188CBE104
		public string GetSDKUid(); // 0x0000000188CBE104-0x0000000188CBE144
		public void Init(); // 0x0000000186E61B40-0x0000000186E61B70
		public void Login(ExternalPluginLoginParams args); // 0x00000001859BC910-0x00000001859BC9F0
		public void Logout(ExternalPluginLogoutParams args); // 0x0000000188CBE144-0x0000000188CBE1C0
		public void OnProductListChanged(List<U8ProductInfo> productList); // 0x0000000186ECFBA0-0x0000000186ECFBD0
		public void Pay(ExternalPluginPayParams args); // 0x0000000188CBE1C0-0x0000000188CBE3AC
		public bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta); // 0x00000001859BCE50-0x00000001859BCF40
		private static bool _UseMockVersion(); // 0x00000001859BCF70-0x00000001859BCFE0
		private void _MockLogin(ExternalPluginLoginParams args); // 0x00000001867A3DB0-0x00000001867A3ED0
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 80902
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 80903
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 80904
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 80905
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 80906
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 80907
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 80908
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Beyond.UI
{
	public class SplashController : MonoBehaviour // TypeDefIndex: 80915
	{
		// Fields
		private const string CURSOR_KEY_SPLASH = "SplashController"; // Metadata: 0x0263DE57
		private const string SPLASH_RESOURCES_PATH = "Splash"; // Metadata: 0x0263DE68
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
		public static SplashController instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000188CB39C0-0x0000000188CB39F8 0x0000000188CB3A64-0x0000000188CB3AB8
		public static bool isPlaying { get; } // 0x0000000188CB39F8-0x0000000188CB3A64 
	
		// Nested types
		[Serializable]
		private struct SplashConfig // TypeDefIndex: 80909
		{
			// Fields
			public Sprite sprite; // 0x00
			public bool blackCoverFadeOut; // 0x08
		}
	
		[Serializable]
		private struct SplashConfigOverride // TypeDefIndex: 80910
		{
			// Fields
			public EnvLang envLang; // 0x00
			public SplashConfig[] splashConfigs; // 0x08
		}
	
		[Serializable]
		private struct SplashConfigs // TypeDefIndex: 80911
		{
			// Fields
			public SplashConfig[] splashConfigs; // 0x00
			public SplashConfig[] splashConfigsVNMobile; // 0x08
			public SplashConfigOverride[] i18nSplashConfigOverrides; // 0x10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 80912
		{
			// Fields
			public SplashConfig config; // 0x10
			public SplashController __4__this; // 0x20
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DoStartSplash_b__0(); // 0x0000000187184C70-0x0000000187184CA0
			internal void __DoStartSplash_b__2(); // 0x0000000187120070-0x00000001871200E0
		}
	
		[CompilerGenerated]
		private sealed class __OnSplashCompleteCoroutine_d__33 : IEnumerator<object> // TypeDefIndex: 80913
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SplashController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __OnSplashCompleteCoroutine_d__33(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018531A3E0-0x000000018531A5F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB52E0-0x0000000188CB532C
		}
	
		[CompilerGenerated]
		private sealed class __StartLicenseCoroutine_d__34 : IEnumerator<object> // TypeDefIndex: 80914
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private bool _displayCursor_5__2; // 0x20
			private bool _usingController_5__3; // 0x21
			private bool _isGranted_5__4; // 0x22
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __StartLicenseCoroutine_d__34(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001859BF680-0x00000001859BF8C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CB5C98-0x0000000188CB5CE4
		}
	
		// Constructors
		public SplashController(); // 0x00000001871FD4A0-0x00000001871FD4D0
	
		// Methods
		public static SplashController Show(Action onComplete = null, bool skipLicense = false /* Metadata: 0x0263DE56 */); // 0x000000018531A7A0-0x000000018531AAE0
		public static void Hide(); // 0x000000018531A6A0-0x000000018531A7A0
		public static void CanFinished(); // 0x000000018531A5F0-0x000000018531A6A0
		private void Awake(); // 0x000000018531A290-0x000000018531A350
		private void OnDestroy(); // 0x000000018531A350-0x000000018531A3E0
		private void _Play(Action onComplete, bool skipLicense); // 0x00000001863F8E70-0x00000001863F8F90
		private void _Stop(); // 0x0000000185319BF0-0x0000000185319C70
		private SplashConfig[] _GetSplashConfigs(); // 0x00000001863F8F90-0x00000001863F9090
		private void _DoStartSplash(SplashConfig[] splashConfigs); // 0x00000001869E5B90-0x00000001869E5EF0
		private void _OnTweenFinished(); // 0x00000001870A05F0-0x00000001870A0650
		[IteratorStateMachine(typeof(__OnSplashCompleteCoroutine_d__33))]
		private IEnumerator _OnSplashCompleteCoroutine(); // 0x00000001870A0650-0x00000001870A06D0
		[IteratorStateMachine(typeof(__StartLicenseCoroutine_d__34))]
		private IEnumerator _StartLicenseCoroutine(); // 0x000000018531A220-0x000000018531A290
		[CompilerGenerated]
		private void __DoStartSplash_b__31_1(); // 0x00000001871E84B0-0x00000001871E8500
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 80828
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 81137
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x0000000188CC5A60-0x0000000188CC5AC4
	
		// Methods
		public Beyond.GameState __Gen_Wrap_0(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public void __Gen_Wrap_1(object P0, Beyond.GameState P1); // 0x0000000188B4D6D0-0x0000000188B4D7A0
		public void __Gen_Wrap_2(float P0); // 0x0000000188CC508C-0x0000000188CC5140
		public void __Gen_Wrap_3(bool P0); // 0x00000001887EDB90-0x00000001887EDC44
		public void __Gen_Wrap_4(Beyond.GameSetting.GameSettingAudioSuiteMode P0); // 0x00000001887DBA64-0x00000001887DBB14
		public void __Gen_Wrap_5(Beyond.GameSetting.KeyboardLayoutType P0); // 0x00000001887DBA64-0x00000001887DBB14
		public void __Gen_Wrap_6(EnvLang P0); // 0x00000001887DBA64-0x00000001887DBB14
		public void __Gen_Wrap_7(Beyond.GameSetting.GameSettingLanguageAudio P0); // 0x00000001887DBA64-0x00000001887DBB14
		public void __Gen_Wrap_8(Beyond.GameSetting.GameSettingVideoQuality P0); // 0x00000001887DBA64-0x00000001887DBB14
		public void __Gen_Wrap_9(int P0, int P1, bool P2); // 0x0000000188CC5978-0x0000000188CC5A60
		public void __Gen_Wrap_10(Beyond.GameSetting.ScreenResolution P0); // 0x0000000188CC4BB0-0x0000000188CC4C9C
		public void __Gen_Wrap_11(Beyond.GameSetting.TeammateSkillEffectStrength P0); // 0x00000001887DBA64-0x00000001887DBB14
		public void __Gen_Wrap_12(); // 0x00000001887ED074-0x00000001887ED104
		public void __Gen_Wrap_13(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public bool __Gen_Wrap_14(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public string __Gen_Wrap_15(); // 0x0000000182798820-0x0000000182799040
		public string __Gen_Wrap_16(object P0); // 0x000000018279D310-0x000000018279DC30
		public void __Gen_Wrap_17(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public bool __Gen_Wrap_18(object P0, uint P1); // 0x0000000182460990-0x0000000182460C70
		public GameApp.FileEntry __Gen_Wrap_19(GameApp.PendingFile P0); // 0x00000001827A6740-0x00000001827A7320
		public List<GameApp.FileEntry> __Gen_Wrap_20(object P0, int P1); // 0x00000001827A7320-0x00000001827A7C70
		public int __Gen_Wrap_21(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public string __Gen_Wrap_22(long P0); // 0x00000001827A7C70-0x00000001827A84D0
		public void __Gen_Wrap_23(object P0, object P1, object P2); // 0x0000000182532090-0x00000001825324E0
		public void __Gen_Wrap_24(object P0, object P1, System.DateTime P2, object P3, object P4); // 0x00000001827A84D0-0x00000001827A8DB0
		public void __Gen_Wrap_25(object P0, object P1, int P2, object P3); // 0x00000001825A0C90-0x00000001825A1100
		public void __Gen_Wrap_26(object P0, object P1, int P2); // 0x0000000182528040-0x00000001825283D0
		public bool __Gen_Wrap_27(); // 0x0000000182541760-0x0000000182541930
		public IEnumerator __Gen_Wrap_28(object P0, float P1); // 0x00000001827A8DB0-0x00000001827A9700
		public void __Gen_Wrap_29(int P0); // 0x0000000182220CF0-0x0000000182220EE0
		public IEnumerator __Gen_Wrap_30(); // 0x00000001827A9700-0x00000001827A9F20
		public SplashController.SplashConfig[] __Gen_Wrap_31(object P0); // 0x00000001827A9F20-0x00000001827AA840
		public IEnumerator __Gen_Wrap_32(object P0); // 0x00000001827AA840-0x00000001827AB160
		public void __Gen_Wrap_33(object P0, object P1, bool P2); // 0x00000001825283D0-0x0000000182528770
		public SplashController __Gen_Wrap_34(object P0, bool P1); // 0x00000001827AB160-0x00000001827ABAF0
		public void __Gen_Wrap_35(in EventData<bool, bool> P0); // 0x00000001827ABAF0-0x00000001827AC0A0
		public void __Gen_Wrap_36(object P0, bool P1); // 0x000000018253E590-0x000000018253E870
		public IEnumerator __Gen_Wrap_37(object P0, bool P1); // 0x00000001827AC0A0-0x00000001827ACA30
		public void __Gen_Wrap_38(GameAppExitCode P0); // 0x0000000182220CF0-0x0000000182220EE0
		public bool __Gen_Wrap_39(out string P0); // 0x00000001827ACA30-0x00000001827AD330
		public bool __Gen_Wrap_40(object P0, out LocalResPref P1, out VirtualFileSystem.BlockValidator P2); // 0x00000001827AD330-0x00000001827AE070
		public void __Gen_Wrap_41(object P0, out VirtualFileSystem.BlockValidator P1); // 0x00000001827AE070-0x00000001827AEA70
		public void __Gen_Wrap_42(object P0, in EventData<Beyond.DeviceInfo.InputType> P1); // 0x00000001827AEA70-0x00000001827AF0F0
		public LoginController.MaskCtrl __Gen_Wrap_43(object P0); // 0x00000001827AF0F0-0x00000001827AFA10
		public UISwitchTween __Gen_Wrap_44(object P0, int P1); // 0x00000001827AFA10-0x00000001827B0360
		public IEnumerator __Gen_Wrap_45(object P0, object P1); // 0x00000001827B0360-0x00000001827B0D60
		public void __Gen_Wrap_46(object P0, object P1, LoginController.EMaskType P2, bool P3, bool P4); // 0x00000001824EC7E0-0x00000001824ECBB0
		public UIAnimationLayerMixPlayer __Gen_Wrap_47(object P0); // 0x00000001827B0D60-0x00000001827B1680
		public void __Gen_Wrap_48(object P0, LoginController.FOptions P1); // 0x00000001827B1680-0x00000001827B1D10
		public LoginWorkFlow.FWork __Gen_Wrap_49(); // 0x00000001827B1D10-0x00000001827B2500
		public LoginWorkFlow.ENode __Gen_Wrap_50(ref LoginWorkFlow.FWork P0); // 0x00000001827B2500-0x00000001827B30A0
		public bool __Gen_Wrap_51(LoginWorkFlow.ENode P0, LoginWorkFlow.ENode P1); // 0x0000000182522890-0x0000000182522AA0
		public bool __Gen_Wrap_52(LoginWorkFlow.ENode P0); // 0x0000000182220AF0-0x0000000182220CF0
		public IEnumerator __Gen_Wrap_53(LoginWorkFlow.ENode P0); // 0x00000001827B30A0-0x00000001827B3900
		public CustomYieldInstruction __Gen_Wrap_54(object P0); // 0x00000001827B3900-0x00000001827B4220
		public bool __Gen_Wrap_55(ref LoginWorkFlow.FWork P0); // 0x00000001827B4220-0x00000001827B4DD0
		public void __Gen_Wrap_56(ref LoginWorkFlow.FWork P0); // 0x00000001827B4DD0-0x00000001827B5960
		public void __Gen_Wrap_57(object P0, LoginAlertDialog.FParams P1); // 0x00000001827B5960-0x00000001827B5FD0
		public void __Gen_Wrap_58(object P0, LoginVocResSelDialog.FParams P1); // 0x00000001827B5FD0-0x00000001827B6660
		public void __Gen_Wrap_59(object P0, LoginJudgeDialog.FParams P1); // 0x00000001827B6660-0x00000001827B6CE0
		public void __Gen_Wrap_60(LoginAlertDialog P0, LoginAlertDialog.FParams P1); // 0x00000001827B6CE0-0x00000001827B7350
		public void __Gen_Wrap_61(object P0, bool P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8); // 0x00000001827B7350-0x00000001827B7BC0
		public bool __Gen_Wrap_62(object P0, out LoginWorkFlow.ENode P1); // 0x00000001827B7BC0-0x00000001827B7EC0
		public void __Gen_Wrap_63(Beyond.GameState P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_64(object P0, float P1); // 0x0000000182659420-0x0000000182659700
		public LoginRootPanel __Gen_Wrap_65(object P0); // 0x00000001827B7EC0-0x00000001827B87E0
		public float __Gen_Wrap_66(object P0); // 0x00000001826A2110-0x00000001826A23D0
		public LoginController __Gen_Wrap_67(object P0); // 0x00000001827B87E0-0x00000001827B9100
		public void __Gen_Wrap_68(object P0, object P1, float P2); // 0x00000001827B9100-0x00000001827B94A0
		public List<ServerZoneManager.ServerZoneData> __Gen_Wrap_69(object P0); // 0x00000001827B94A0-0x00000001827B9DC0
		public bool __Gen_Wrap_70(object P0, object P1); // 0x00000001827B9DC0-0x00000001827BA150
		public ServerZoneManager.ServerZoneData __Gen_Wrap_71(object P0); // 0x00000001827BA150-0x00000001827BAA70
		public bool __Gen_Wrap_72(object P0, ELoginEvent P1, object P2); // 0x00000001827BAA70-0x00000001827BAE20
		public void __Gen_Wrap_73(object P0, ELoginEvent P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public void __Gen_Wrap_74(string P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_75(PointerEventData P0); // 0x0000000182510780-0x0000000182510A40
		public bool __Gen_Wrap_76(ref LoginMockUIDPanel.FOptions P0); // 0x00000001827BAE20-0x00000001827BBA10
		public void __Gen_Wrap_77(object P0, ref int P1); // 0x00000001827BBA10-0x00000001827BBD00
		public void __Gen_Wrap_78(int P0, UIDropdownOption P1, bool P2); // 0x00000001827BBD00-0x00000001827BC000
		public void __Gen_Wrap_79(object P0, int P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_80(object P0, LoginMockUIDPanel.FOptions P1, object P2); // 0x00000001827BC000-0x00000001827BC750
		public UISwitchTween __Gen_Wrap_81(object P0); // 0x00000001827BC750-0x00000001827BD070
		public bool __Gen_Wrap_82(object P0, LoginController.EMaskType P1); // 0x0000000182460990-0x0000000182460C70
		public void __Gen_Wrap_83(LoginVocResSelDialog P0, LoginVocResSelDialog.FParams P1); // 0x00000001827BD070-0x00000001827BD700
		public IEnumerator __Gen_Wrap_84(object P0, object P1, object P2, object P3); // 0x00000001827BD700-0x00000001827BE2C0
		public void __Gen_Wrap_85(LoginJudgeDialog P0, LoginJudgeDialog.FParams P1); // 0x00000001827BE2C0-0x00000001827BE940
		public void __Gen_Wrap_86(object P0, object P1, object P2, object P3); // 0x0000000182558BB0-0x00000001825590D0
		public string __Gen_Wrap_87(object P0, object P1, object P2); // 0x0000000188CC5140-0x0000000188CC525C
		public void __Gen_Wrap_88(ref bool P0); // 0x0000000188CC525C-0x0000000188CC5330
		public void __Gen_Wrap_89(object P0, ref bool P1); // 0x0000000188CC5330-0x0000000188CC5424
		public void __Gen_Wrap_90(object P0, LoginManager.FFlowWithMask P1); // 0x0000000188CC5424-0x0000000188CC553C
		public bool __Gen_Wrap_91(ref LoginManager.FFlowCondition P0, LoginWorkFlow.ENode P1); // 0x0000000188CC553C-0x0000000188CC5680
		public IEnumerator __Gen_Wrap_92(object P0, LoginManager.FFlowWithMask P1); // 0x0000000188CC5680-0x0000000188CC57B8
		public TMP_FontAsset __Gen_Wrap_93(object P0); // 0x0000000188CC57B8-0x0000000188CC5898
		public void __Gen_Wrap_94(bool P0, long P1, object P2); // 0x00000001827BE940-0x00000001827BEC30
		public void __Gen_Wrap_95(SDKNetUtils.HttpPostRequest P0); // 0x00000001827BEC30-0x00000001827BF1E0
		public void __Gen_Wrap_96(SDKNetUtils.HttpGetRequest P0); // 0x00000001827BF1E0-0x00000001827BF780
		public IEnumerator __Gen_Wrap_97(object P0, SDKNetUtils.HTTPConfig P1); // 0x00000001827BF780-0x00000001827C0450
		public Dictionary<string, string> __Gen_Wrap_98(object P0); // 0x0000000188CC5898-0x0000000188CC5978
		public int __Gen_Wrap_99(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public long __Gen_Wrap_100(object P0); // 0x0000000188AB6D9C-0x0000000188AB6E5C
		public void __Gen_Wrap_101(object P0, out long P1, out string P2); // 0x0000000182783E80-0x00000001827848D0
		public void __Gen_Wrap_102(object P0, SDKExtraData P1); // 0x00000001827848D0-0x0000000182784F40
		public SDKExternalTools.POSTResult __Gen_Wrap_103(SDKNetUtils.WebHttpResponse P0); // 0x0000000182784F40-0x0000000182785AE0
		public void __Gen_Wrap_104(SDKNetUtils.WebHttpResponse P0); // 0x0000000182785AE0-0x0000000182786090
		public void __Gen_Wrap_105(object P0, SDKExternalTools.POSTRequest P1, object P2); // 0x0000000182786090-0x00000001827867E0
		public SDKCaptchaHandler __Gen_Wrap_106(object P0); // 0x00000001827867E0-0x0000000182787100
		public bool __Gen_Wrap_107(object P0, SDKExternalTools.ErrMsgMeta P1, out string P2); // 0x0000000182787100-0x0000000182787E60
		public string __Gen_Wrap_108(object P0, SDKExternalTools.ErrMsgMeta P1); // 0x0000000182787E60-0x0000000182788B20
		public IEnumerator __Gen_Wrap_109(object P0, object P1, object P2); // 0x0000000182788B20-0x0000000182789610
		public void __Gen_Wrap_110(object P0, ExternalPluginLoginParams P1); // 0x0000000182789610-0x0000000182789C90
		public void __Gen_Wrap_111(object P0, ExternalPluginLogoutParams P1); // 0x0000000182789C90-0x000000018278A300
		public void __Gen_Wrap_112(U8PayResult P0); // 0x000000018278A300-0x000000018278A8A0
		public void __Gen_Wrap_113(object P0, ExternalPluginPayParams P1); // 0x000000018278A8A0-0x000000018278AF10
		public bool __Gen_Wrap_114(object P0, object P1, out SDKMeta P2); // 0x000000018278AF10-0x000000018278BA30
		public LoginWorkFlow.ENode __Gen_Wrap_115(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_116(ref LoginWorkFlow.FWork P0, int P1); // 0x000000018278BA30-0x000000018278C5F0
		public bool __Gen_Wrap_117(object P0, LoginWorkFlow.ENode P1, bool P2); // 0x000000018278C5F0-0x000000018278C900
		public HGDownloader.DownloadProgress __Gen_Wrap_118(object P0); // 0x000000018278C900-0x000000018278D1F0
		public HGDownloader.WorkState __Gen_Wrap_119(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public List<HGFileInfo> __Gen_Wrap_120(object P0, object P1); // 0x000000018278D1F0-0x000000018278DBF0
		public List<HGFolder> __Gen_Wrap_121(object P0, object P1); // 0x000000018278DBF0-0x000000018278E5F0
		public bool __Gen_Wrap_122(object P0, HGRetCodeType P1, int P2); // 0x0000000182508ED0-0x00000001825091C0
		public string __Gen_Wrap_123(double P0); // 0x000000018278E5F0-0x000000018278EE60
		public void __Gen_Wrap_124(object P0, long P1, object P2, object P3, object P4, object P5); // 0x000000018278EE60-0x000000018278F470
		public void __Gen_Wrap_125(object P0, HGDownloader.PauseReason P1); // 0x00000001824828A0-0x0000000182482B70
		public bool __Gen_Wrap_126(object P0, object P1, out LoginGameUpdater.HGLatestGameInfo P2); // 0x000000018278F470-0x000000018278FF90
		public IEnumerator __Gen_Wrap_127(object P0, long P1, object P2); // 0x000000018278FF90-0x00000001827909C0
		public void __Gen_Wrap_128(object P0, long P1, long P2, long P3); // 0x00000001827909C0-0x0000000182790CD0
		public IEnumerator __Gen_Wrap_129(object P0, long P1); // 0x0000000182790CD0-0x0000000182791620
		public LoginGameUpdater.ResAction __Gen_Wrap_130(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_131(object P0, LoginGameUpdater.ResAction P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_132(object P0, long P1, int P2, ref int P3); // 0x0000000182791620-0x0000000182791940
		public void __Gen_Wrap_133(long P0, int P1, ref int P2); // 0x0000000182791940-0x0000000182791B90
		public void __Gen_Wrap_134(ref bool P0, int P1, int P2); // 0x0000000182791B90-0x0000000182791DE0
		public void __Gen_Wrap_135(LoginGameUpdater.PreDownloadErrorChoice P0); // 0x0000000182220CF0-0x0000000182220EE0
		public string __Gen_Wrap_136(int P0); // 0x0000000182791DE0-0x0000000182792640
		public IEnumerator __Gen_Wrap_137(object P0, int P1, object P2); // 0x0000000182792640-0x0000000182793060
		public int __Gen_Wrap_138(long P0, long P1); // 0x000000018265E000-0x000000018265E210
		public void __Gen_Wrap_139(object P0, int P1, long P2, long P3); // 0x0000000182793060-0x0000000182793370
		public int __Gen_Wrap_140(long P0); // 0x0000000188CC4C9C-0x0000000188CC4D5C
		public void __Gen_Wrap_141(object P0, object P1, long P2, long P3); // 0x0000000188CC4D5C-0x0000000188CC4E5C
		public IEnumerator __Gen_Wrap_142(object P0, long P1, bool P2, object P3); // 0x0000000188CC4E5C-0x0000000188CC4F8C
		public void __Gen_Wrap_143(object P0, long P1, long P2); // 0x0000000182500740-0x0000000182500A30
		public void __Gen_Wrap_144(object P0, long P1, long P2, int P3); // 0x0000000182793370-0x0000000182793680
		public void __Gen_Wrap_145(long P0); // 0x0000000182232C20-0x0000000182232E10
		public void __Gen_Wrap_146(ref bool P0, long P1, long P2, int P3); // 0x0000000182793680-0x0000000182793900
		public void __Gen_Wrap_147(long P0, long P1, long P2, long P3, ref int P4); // 0x0000000182793900-0x0000000182793BA0
		public bool __Gen_Wrap_148(int P0); // 0x0000000182220AF0-0x0000000182220CF0
		public bool __Gen_Wrap_149(object P0, object P1, out string P2); // 0x0000000182793BA0-0x00000001827946C0
		public double __Gen_Wrap_150(object P0); // 0x00000001826A9620-0x00000001826A98E0
		public bool __Gen_Wrap_151(bool P0); // 0x00000001822291E0-0x00000001822293E0
		public string __Gen_Wrap_152(object P0, bool P1); // 0x00000001827946C0-0x0000000182795050
		public LoginHotUpdater.HotUpdateInfo __Gen_Wrap_153(object P0, bool P1); // 0x0000000188CC4F8C-0x0000000188CC508C
		public LocalResPref __Gen_Wrap_154(); // 0x0000000182795050-0x0000000182795870
		public ResourceIndex __Gen_Wrap_155(); // 0x0000000182795870-0x0000000182796090
		public string __Gen_Wrap_156(object P0, object P1, bool P2); // 0x0000000182796090-0x0000000182796AD0
		public object __Gen_Wrap_157(); // 0x0000000182796AD0-0x00000001827972F0
		public IEnumerator __Gen_Wrap_158(object P0, object P1, bool P2, object P3); // 0x00000001827972F0-0x0000000182797DF0
		public IEnumerator __Gen_Wrap_159(bool P0, object P1, object P2); // 0x0000000182797DF0-0x0000000182798820
		public LocalResPref __Gen_Wrap_160(object P0, bool P1, object P2, FResourceDiff P3, out int P4); // 0x0000000182799040-0x0000000182799DC0
		public void __Gen_Wrap_161(object P0, ref bool P1, double P2, double P3, int P4, bool P5); // 0x0000000182799DC0-0x000000018279A130
		public bool __Gen_Wrap_162(object P0, EVFSBlockType P1); // 0x0000000182676010-0x00000001826762F0
		public IEnumerator __Gen_Wrap_163(object P0, object P1, bool P2, bool P3); // 0x000000018279A130-0x000000018279AB90
		public LoginHotUpdater __Gen_Wrap_164(object P0, bool P1); // 0x000000018279AB90-0x000000018279B520
		public LoginProgress.FDownloadSize.EUnit __Gen_Wrap_165(double P0); // 0x000000018279B520-0x000000018279B710
		public float __Gen_Wrap_166(double P0, LoginProgress.FDownloadSize.EUnit P1); // 0x000000018279B710-0x000000018279B930
		public string __Gen_Wrap_167(float P0, float P1, LoginProgress.FDownloadSize.EUnit P2); // 0x000000018279B930-0x000000018279C1E0
		public string __Gen_Wrap_168(float P0, LoginProgress.FDownloadSize.EUnit P1); // 0x000000018279C1E0-0x000000018279CA70
		public string __Gen_Wrap_169(float P0, float P1); // 0x000000018279CA70-0x000000018279D310
		public void __Gen_Wrap_170(ref LoginProgress.FDownloadSize P0, double P1, double P2, double P3); // 0x000000018279DC30-0x000000018279E890
		public void __Gen_Wrap_171(ref LoginProgress.FDownloadSize P0, double P1, double P2); // 0x000000018279E890-0x000000018279F4D0
		public void __Gen_Wrap_172(ref LoginProgress.FDownloadSize P0); // 0x000000018279F4D0-0x00000001827A00D0
		public void __Gen_Wrap_173(object P0, GameAppExitCode P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_174(SpeedTestResult P0); // 0x0000000182510780-0x0000000182510A40
		public Task<Hypergryph.SpeedTest.TaskResult> __Gen_Wrap_175(); // 0x00000001827A00D0-0x00000001827A08F0
		public bool __Gen_Wrap_176(object P0, out string P1); // 0x00000001827A08F0-0x00000001827A1300
		public bool __Gen_Wrap_177(ref LoginViewModel.FAgeTipsPolicy P0); // 0x00000001827A1300-0x00000001827A1EB0
		public LoginViewModel.FAgeTipsPolicy __Gen_Wrap_178(); // 0x00000001827A1EB0-0x00000001827A26A0
		public LoginWorkFlow.Node[] __Gen_Wrap_179(object P0); // 0x00000001827A26A0-0x00000001827A2FC0
		public float __Gen_Wrap_180(object P0, out bool P1); // 0x00000001827A2FC0-0x00000001827A32C0
		public TickType __Gen_Wrap_181(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public UIAnimationMixPlayer __Gen_Wrap_182(object P0); // 0x00000001827A32C0-0x00000001827A3BE0
		public void __Gen_Wrap_183(object P0, LoginSceneAnimCtrl.EState P1); // 0x00000001824828A0-0x0000000182482B70
		public List<string> __Gen_Wrap_184(object P0); // 0x00000001827A3BE0-0x00000001827A4500
		public void __Gen_Wrap_185(object P0, LoginViewModel.FAgeTipsPolicy P1); // 0x00000001827A4500-0x00000001827A4B70
		public void __Gen_Wrap_186(object P0, object P1, bool P2, bool P3); // 0x00000001826D4DB0-0x00000001826D5170
		public void __Gen_Wrap_187(bool P0, bool P1, bool P2); // 0x00000001827A4B70-0x00000001827A4DA0
		public void __Gen_Wrap_188(object P0, in EventData<bool> P1); // 0x00000001827A4DA0-0x00000001827A5420
		public LoginMockUIDPanel __Gen_Wrap_189(); // 0x00000001827A5420-0x00000001827A5C40
		public void __Gen_Wrap_190(object P0, in EventData<float> P1); // 0x00000001827A5C40-0x00000001827A62D0
		public void __Gen_Wrap_191(object P0, object P1, object P2, bool P3); // 0x00000001827A62D0-0x00000001827A6740
		public void __Gen_Wrap_192(object P0, int P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public void __Gen_Wrap_193(object P0, EVFSBlockType P1); // 0x0000000182494990-0x0000000182494C60
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 81138
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x0000000188CCA894-0x0000000188CCA944 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x0000000188CCA944-0x0000000188CCA9F4 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000188CCA9F4-0x0000000188CCAAD4
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x00000001887F0184-0x00000001887F0204
		[IDTag(1)]
		private bool MoveNext(); // 0x00000001887EFF14-0x00000001887EFFA4
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x00000001887F0054-0x00000001887F00D4
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 81139
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000188CCACC0-0x0000000188CCAD24
		public static bool IsPatched(int id); // 0x0000000188CCADB0-0x0000000188CCAE2C
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000188CCAB78-0x0000000188CCAC44
		public object CreateWrapper(int id); // 0x0000000188CCAC44-0x0000000188CCACC0
		public object InitWrapperArray(int len); // 0x0000000188CCAD24-0x0000000188CCADB0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000188CCAAD4-0x0000000188CCAB78
	}

	public delegate Beyond.GameState __HotPatchDelegate_0(object P0); // TypeDefIndex: 81140; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum HotPatchIDMAP0 // TypeDefIndex: 81141
	{
		Beyond-GameApp-get_currentState0 = 0,
		Beyond-GameInitState-get_stateId0 = 0,
		Beyond-GameLoginState-get_stateId0 = 0,
		Beyond-GameMainState-get_stateId0 = 0,
		Beyond-GamePreloadState-get_stateId0 = 0,
		Beyond-GameQuitState-get_stateId0 = 0,
		Beyond-GameSoftRestartState-get_stateId0 = 0,
		Beyond-GameStartState-get_stateId0 = 0,
		Beyond-GameStateMachine-get_curState0 = 0,
		Beyond-GameApp-SwitchState0 = 1,
		Beyond-GameStateBase-OnEnter0 = 1,
		Beyond-GameInitState-OnEnter0 = 1,
		Beyond-GameStateBase-OnLeave0 = 1,
		Beyond-GameInitState-OnLeave0 = 1,
		Beyond-GameLoginState-OnEnter0 = 1,
		Beyond-GameLoginState-OnLeave0 = 1,
		Beyond-GameMainState-OnEnter0 = 1,
		Beyond-GameMainState-OnLeave0 = 1,
		Beyond-GamePreloadState-OnEnter0 = 1,
		Beyond-GamePreloadState-OnLeave0 = 1,
		Beyond-GameQuitState-OnEnter0 = 1,
		Beyond-GameQuitState-OnLeave0 = 1,
		Beyond-GameSoftRestartState-OnEnter0 = 1,
		Beyond-GameStartState-OnEnter0 = 1,
		Beyond-GameStartState-OnLeave0 = 1,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioGlobalVolumeChange0 = 2,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioMusicVolumeChange0 = 2,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioVoiceVolumeChange0 = 2,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSfxVolumeChange0 = 2,
		Beyond-Scripts-Entry-GameSettingSetter-_OnCameraDistanceLevelChange0 = 2,
		Beyond-Scripts-Entry-GameSettingSetter-_OnVideoNotchPaddingChange0 = 2,
		Beyond-Scripts-Entry-GameSettingSetter-_OnTeammateSkillEffectOpacityChange0 = 2,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuspendUnfocusedChange0 = 3,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioBackgroundMusicChange0 = 3,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioControllerChange0 = 3,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSpatialAudioChange0 = 3,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerMotionChange0 = 3,
		Beyond-Scripts-Entry-GameSettingSetter-_OnVideoFullScreenChange0 = 3,
		Beyond-Login-LoginHotUpdater-MarkNeedClearFolder0 = 3,
		Beyond-Login-LoginHotUpdater-MarkClearSuccessed0 = 3,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuiteModeChange0 = 4,
		Beyond-Scripts-Entry-GameSettingSetter-_OnKeyboardTypeChange0 = 5,
		Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageTextChange0 = 6,
		Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageAudioChange0 = 7,
		Beyond-Scripts-Entry-GameSettingSetter-_OnVideoQualityChange0 = 8,
		Beyond-Scripts-Entry-GameSettingSetter-_SetResolution0 = 9,
		Beyond-Scripts-Entry-GameSettingSetter-_OnVideoResolutionChange0 = 10,
		Beyond-Scripts-Entry-GameSettingSetter-_OnTeammateSkillEffectStrengthChange0 = 11,
		Beyond-Scripts-Entry-GameSettingSetter-RegisterSettingCallbacks0 = 12,
		Beyond-RenderPipelineDataLoader-LoadSimpleRpData0 = 12,
		Beyond-UI-SplashController-Hide0 = 12,
		Beyond-GameApp-RefreshScreenResolution0 = 12,
		Beyond-GameApp-_OnSystemDisplaySizeChanged0 = 12,
		Beyond-RenderPipelineDataLoader-PreloadFullRpResources0 = 12,
		Beyond-VietnamLoginAgePanel-_UnInit0 = 12,
		Beyond-VietnamLoginAgePanel-_Init0 = 12,
		Beyond-VietnamLoginAgePanel-Init0 = 12,
		Beyond-UI-SplashController-CanFinished0 = 12,
		Beyond-RenderPipelineDataLoader-LoadFullRpResources0 = 12,
		Beyond-GameLoginState-_TryStartLoginWorkflow0 = 12,
		Beyond-LoginManager-OnReleaseMainGame0 = 12,
		Beyond-GameMainState-_ClearUtils0 = 12,
		Beyond-VietnamLoginAgePanel-UnInit0 = 12,
		Beyond-GameQuitState-DoQuit0 = 12,
		Beyond-Login-LoginWorkFlow-ClearEnteredPreloadThisSession0 = 12,
		Beyond-GlobalInitializer-InitGlobalConfig0 = 12,
		Beyond-SDK-Impl-U8ExternalTools-_OnRequestExitGame0 = 12,
		Beyond-SDK-Impl-U8ExternalTools-_OnFakeAccountCenter0 = 12,
		Beyond-Login-LoginHotUpdater-MarkInitialAssetChanged0 = 12,
		Beyond-Login-LoginHotUpdater-MarkSoftRestart0 = 12,
		Beyond-Login-LoginHotUpdater-ClearSoftRestartFlag0 = 12,
		Beyond-Login-LoginHotUpdater-_SetResVersionForLog0 = 12,
		Beyond-Login-LoginWorkFlow-MarkEnteredPreloadThisSession0 = 12,
		Beyond-Login-LoginMenuPanel-_OnBulletinOpen0 = 12,
		Beyond-Login-LoginMenuPanel-_OnBulletinClose0 = 12,
		Beyond-GameApp-_PreInitGameSetting0 = 13,
		Beyond-GameApp-_WorkerLoop0 = 13,
		Beyond-SDK-Impl-U8ExternalTools-PublicSetGameVersion0 = 13,
		Beyond-UI-SplashController-_Stop0 = 13,
		Beyond-UI-SplashController-_OnTweenFinished0 = 13,
		Beyond-GameApp-_InitNotificationCenter0 = 13,
		Beyond-GameApp-_InitGameStateMachine0 = 13,
		Beyond-GameApp-_OnApplicationFocusForLua0 = 13,
		Beyond-GameApp-_OnApplicationPauseForLua0 = 13,
		Beyond-GameApp-_RegisterLuaAfterGCEvent0 = 13,
		Beyond-GameApp-Awake0 = 13,
		Beyond-GameApp-Update0 = 13,
		Beyond-GameApp-LateUpdate0 = 13,
		Beyond-GameApp-OnApplicationQuit0 = 13,
		Beyond-GameApp-_UnInitGameStateMachine0 = 13,
		Beyond-GameApp-_UnInit0 = 13,
		Beyond-GameApp-OnDestroy0 = 13,
		Beyond-GameInitState-_InitAPPDefaultCulture0 = 13,
		Beyond-GameInitState-_InitGameSetting0 = 13,
		Beyond-Login-LoginWorkFlow-Node-OnDispose0 = 13,
		Beyond-Login-LoginWorkFlow-Node-Dispose0 = 13,
		Beyond-Login-LoginWorkFlow-_EnbaleToggleGroup0 = 13,
		Beyond-Login-LoginWorkFlow-Worker-Dispose0 = 13,
		Beyond-Login-LoginWorkFlow-Dispose0 = 13,
		Beyond-LoginManager-AssetLoader-Dispose0 = 13,
		Beyond-LoginContext-_DisposeImpl0 = 13,
		Beyond-LoginController-MaskCtrl-Dispose0 = 13,
		Beyond-LoginContext-Dispose0 = 13,
		Beyond-Login-LoginRootPanel-_InitController0 = 13,
		Beyond-Login-LoginRootPanel-ChildPanel-OnInit0 = 13,
		Beyond-LoginController-_InitVersionBtn0 = 13,
		Beyond-LoginController-_InitImpl0 = 13,
		Beyond-Login-LoginWorkFlow-Worker-_InternalTick0 = 13,
		Beyond-Login-LoginWorkFlow-Worker-TickInEmptyFrame0 = 13,
		Beyond-LoginManager-_PrepareBeforeLoginProcess0 = 13,
		Beyond-LoginManager-_Init0 = 13,
		Beyond-LoginContext-ShutDown0 = 13,
		Beyond-LoginManager-_ReleaseLoginScene0 = 13,
		Beyond-LoginManager-Clear0 = 13,
		Beyond-GamePreloadState-_InitGameSettingStateInPreload0 = 13,
		Beyond-LoginManager-ClearSync0 = 13,
		Beyond-GameStartState-_OnEnterMainGame0 = 13,
		Beyond-GameStateMachine-_RegisterStates0 = 13,
		Beyond-LoginController-Awake0 = 13,
		Beyond-LoginController-Start0 = 13,
		Beyond-Login-LoginWorkFlow-_EventOnOpenAgeTips0 = 13,
		Beyond-Login-LoginWorkFlow-_EventOnCloseAgeTips0 = 13,
		Beyond-Login-LoginWorkFlow-_EventOnConfirmServer0 = 13,
		Beyond-Login-LoginMockUIDPanel-_SaveConfig0 = 13,
		Beyond-Login-LoginMockUIDPanel-_OnBtnEnterGame0 = 13,
		Beyond-Login-LoginMockUIDPanel-_OnBtnDelLocalFile0 = 13,
		Beyond-Login-LoginMockUIDPanel-_TryClosePanel0 = 13,
		Beyond-Login-LoginMockUIDPanel-_InitLoginInfo0 = 13,
		Beyond-Login-LoginMockUIDPanel-_UpdateStatus0 = 13,
		Beyond-LoginController-Dialog-Show0 = 13,
		Beyond-LoginController-Dialog-OnInit0 = 13,
		Beyond-Login-LoginSceneComponent-OnBindToManager0 = 13,
		Beyond-LoginManager-_BindPendingComponents0 = 13,
		Beyond-VietnamLoginAgePanel-OnApplicationQuit0 = 13,
		Beyond-VietnamLoginAgeTipsPanelCtrl-Awake0 = 13,
		Beyond-TailGameLoop-Update0 = 13,
		Beyond-TailGameLoop-LateUpdate0 = 13,
		Beyond-UI-SplashController-Awake0 = 13,
		Beyond-UI-SplashController-OnDestroy0 = 13,
		Beyond-SDK-Impl-U8ExternalTools-InitSDKSystem0 = 13,
		Beyond-SDK-Impl-U8ExternalTools-RetryInitSDKSystem0 = 13,
		Beyond-SDK-Impl-U8ExternalTools-InitHGSDK0 = 13,
		Beyond-SDK-Impl-U8ExternalTools-_ProcessGameProtocolUpdateCheck0 = 13,
		Beyond-SDK-Impl-U8ExternalTools-_ProcessLaunchAuth0 = 13,
		Beyond-SDK-Impl-U8Plugin-Init0 = 13,
		Beyond-Login-LoginGameUpdater-Clear0 = 13,
		Beyond-Login-LoginGameUpdater-ShowWaitProgress0 = 13,
		Beyond-Login-LoginGameUpdater-ClearWaitProgress0 = 13,
		Beyond-Login-LoginGameUpdater-_CreateDirectoryIfNotExists0 = 13,
		Beyond-Login-LoginCreateRoleNode-WorkProcess-Dispose0 = 13,
		Beyond-Login-LoginCreateRoleNode-OnDispose0 = 13,
		Beyond-Login-LoginDownloadTask-Dispose0 = 13,
		Beyond-Login-LoginDownloadTask-_OnDownloadFinish0 = 13,
		Beyond-Login-LoginDownloadTask-_StartDownloadImpl0 = 13,
		Beyond-Login-LoginDownloadTask-_StartDownload0 = 13,
		Beyond-Login-LoginGameUpdater-_OnDownloadStart0 = 13,
		Beyond-Login-LoginGameUpdater-_OnApplyPreDownloadStart0 = 13,
		Beyond-Login-LoginGameUpdater-PreDownloadApplyContext-ResetTaskTrackState0 = 13,
		Beyond-Login-LoginGameUpdater-_OnPreDownloadDownloadStart0 = 13,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ReLoginWhenErrorEncountered0 = 13,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_GlobalLoginSucBusiness0 = 13,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-EnterGame0 = 13,
		Beyond-Login-LoginGSNode-_OnEventLogout0 = 13,
		Beyond-Login-LoginViewModel-RequestResourceRepair0 = 13,
		Beyond-Login-LoginGSNode-_OnEventResourceRepair0 = 13,
		Beyond-Login-LoginViewModel-RequestPreDownload0 = 13,
		Beyond-Login-LoginGSNode-_OnEventPreDownload0 = 13,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-MarkAborting0 = 13,
		Beyond-Login-LoginLocalResTask-Dispose0 = 13,
		Beyond-Login-LoginHotUpdater-Dispose0 = 13,
		Beyond-Login-LoginHotUpdater-_StartDownloadingShaderWarmupIfNeeded0 = 13,
		Beyond-Login-LoginHotUpdater-_StopDownloadingShaderWarmupIfNeeded0 = 13,
		Beyond-Login-LoginHotUpdater-WorkContext-MarkIllegalItemsInLocalRes0 = 13,
		Beyond-Login-LoginViewModel-RequestSkipU8Login0 = 13,
		Beyond-Login-LoginViewModel-RequestCancelPreDownload0 = 13,
		Beyond-Login-PreloadNode-_ShowPreloadResourcePanel0 = 13,
		Beyond-Login-PreloadNode-_OnGetServerListSuc0 = 13,
		Beyond-Login-PreloadNode-_EnterPreLoad0 = 13,
		Beyond-Login-LoginSDKInitNode-_InitSubSDKs0 = 13,
		Beyond-Login-U8LoginNode-_OnSDKViewDisabled0 = 13,
		Beyond-Login-LoginMenuPanel-_UpdateAnnounceRedDot0 = 13,
		Beyond-Login-LoginMenuPanel-InitBulletinAndRedAfterLoginSuc0 = 13,
		Beyond-Login-LoginRootPanel-InitBulletinAndRedAfterLoginSuc0 = 13,
		Beyond-Login-LoginMenuPanel-_StopToastHideRoutine0 = 13,
		Beyond-Login-LoginMenuPanel-_HideLoginSuccessToast0 = 13,
		Beyond-Login-LoginMenuPanel-_RestartToastHideRoutine0 = 13,
		Beyond-Login-LoginMenuPanel-ShowLoginSuccessToast0 = 13,
		Beyond-Login-LoginRootPanel-ShowLoginSuccessToast0 = 13,
		Beyond-Login-U8LoginNode-_OnLoginSuc0 = 13,
		Beyond-Login-U8LoginNode-_OnGameProtocolUpdateCheckSucceeded0 = 13,
		Beyond-Login-U8LoginNode-_OnLoginCanceled0 = 13,
		Beyond-Login-U8LoginNode-_SetCursorOnLoginStart0 = 13,
		Beyond-Login-U8LoginNode-_SetCursorOnLoginFinish0 = 13,
		Beyond-Login-U8LoginNode-_StartGameProtocolUpdateCheck0 = 13,
		Beyond-Login-U8LoginNode-_StartSDKLogin0 = 13,
		Beyond-Login-U8LoginNode-_OnGameProtocolUpdateCheckFailed0 = 13,
		Beyond-Login-U8LoginNode-_ClearGameProtocolUpdateCheckEvents0 = 13,
		Beyond-Login-LoginAgeTipsProp-ClearContentCache0 = 13,
		Beyond-Login-U8LoginNode-_ClearLoginCaches0 = 13,
		Beyond-Login-U8LoginNode-_SkipSDKLogin0 = 13,
		Beyond-Login-LoginWorkFlow-Node-OnInit0 = 13,
		Beyond-Login-HotUpdateNode-OnDispose0 = 13,
		Beyond-Login-WaitForSecondsNode-_NotifyTimeout0 = 13,
		Beyond-Login-WaitForSecondsNode-_DisposeTimer0 = 13,
		Beyond-Login-WaitForSecondsNode-OnDispose0 = 13,
		Beyond-Login-PreloadPostDelayNode-_DisableLoadingPanel0 = 13,
		Beyond-Login-LoginSceneAnimCtrl-OnBindToManager0 = 13,
		Beyond-Login-LoginSceneAnimCtrl-_ResetToA10 = 13,
		Beyond-Login-LoginSceneAnimCtrl-_PlayA1A2Impl0 = 13,
		Beyond-Login-LoginSceneAnimCtrl-_TransitionToA20 = 13,
		Beyond-Login-LoginSceneAnimCtrl-_PlayA1sAndTriggerNext0 = 13,
		Beyond-Login-LoginSceneComponent-Start0 = 13,
		Beyond-Login-LoginSceneAnimCtrl-Start0 = 13,
		Beyond-Login-LoginSceneAnimCtrl-OnRelease0 = 13,
		Beyond-Login-LoginSceneRoot-OnBindToManager0 = 13,
		Beyond-Login-LoginAgeTipsDetailPanel-_ShowContent0 = 13,
		Beyond-Login-LoginAgeTipsPanel-OnInit0 = 13,
		Beyond-Login-LoginAlertDialog-OnInit0 = 13,
		Beyond-Login-LoginDecorateUI-_TriggerTrans2GSLoginImpl0 = 13,
		Beyond-Login-LoginDecorateUI-OnRelease0 = 13,
		Beyond-Login-LoginEnterGamePanel-_InitIfNot0 = 13,
		Beyond-Login-LoginGovTipsPanel-OnInit0 = 13,
		Beyond-Login-LoginJudgeDialog-OnInit0 = 13,
		Beyond-Login-LoginMenuPanel-_OnAnnounceClosed0 = 13,
		Beyond-Login-LoginMenuPanel-_SendCancelPreDownloadEventIfNeeded0 = 13,
		Beyond-Login-LoginMenuPanel-_ShowPausePreDownloadConfirm0 = 13,
		Beyond-Login-LoginMenuPanel-_SendPreDownloadEvent0 = 13,
		Beyond-Login-LoginMenuPanel-_OnServerZoneBtnClicked0 = 13,
		Beyond-Login-LoginMenuPanel-OnInit0 = 13,
		Beyond-Login-LoginMenuPanel-_UpdateServerZone0 = 13,
		Beyond-Login-LoginMenuPanel-Awake0 = 13,
		Beyond-Login-LoginMenuPanel-_OnRequestRelogin0 = 13,
		Beyond-Login-LoginMenuPanel-OnEnable0 = 13,
		Beyond-Login-LoginMenuPanel-OnDisable0 = 13,
		Beyond-Login-LoginRootPanel-ChildPanel-OnDestroy0 = 13,
		Beyond-Login-LoginMenuPanel-OnDestroy0 = 13,
		Beyond-Login-LoginMockUIDPanel-Refresh0 = 13,
		Beyond-Login-LoginMockUIDPanel-OnDestroy0 = 13,
		Beyond-Login-LoginResourcePanel-_UpdateResourceInfo0 = 13,
		Beyond-Login-LoginResourcePanel-Update0 = 13,
		Beyond-Login-LoginRootPanel-Awake0 = 13,
		Beyond-Login-LoginRootPanel-OnDestroy0 = 13,
		Beyond-Login-LoginServerSelectItemView-NaviToBtnTarget0 = 13,
		Beyond-Login-LoginServerSelectModel-InitData0 = 13,
		Beyond-Login-LoginServerSelectPanel-OnInit0 = 13,
		Beyond-Login-LoginServerSelectPanel-_NaviToSelectedItem0 = 13,
		Beyond-Login-LoginServerSelectPanel-OnDisable0 = 13,
		Beyond-Login-LoginServerSelectPanel-OnEnable0 = 13,
		Beyond-Login-LoginVersionPanel-Start0 = 13,
		Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked0 = 13,
		Beyond-Login-LoginVocResSelDialog-_UpdateList0 = 13,
		Beyond-Login-LoginVocResSelDialog-_RefreshConfirmInteractable0 = 13,
		Beyond-Login-LoginVocResSelItemView-NaviToBtnTarget0 = 13,
		Beyond-Login-LoginVocResSelDialog-_NaviToSelectedItem0 = 13,
		Beyond-Login-LoginVocResSelDialog-OnInit0 = 13,
		Beyond-Login-LoginVocResSelDialog-OnEnable0 = 13,
		Beyond-Login-LoginVocResSelDialog-OnDisable0 = 13,
		Beyond-GameApp-_NeedDeepProfilerMode0 = 14,
		Beyond-LoginContext-IsDisposed0 = 14,
		Beyond-LoginManager-IsWorkflowInProgress0 = 14,
		Beyond-LoginController-MaskCtrl-IsCrossSceneMaskTweening0 = 14,
		Beyond-LoginContext-IsWorkflowDisposed0 = 14,
		Beyond-LoginManager-IsReLoginInProgress0 = 14,
		Beyond-GameStateMachine-CheckCanReturnToLoginState0 = 14,
		Beyond-Login-LoginAgeTipsModel-IsContentEmpty0 = 14,
		Beyond-LoginManager-get_firstLogin0 = 14,
		Beyond-LoginManager-IsLoginSceneLoading0 = 14,
		Beyond-Login-LoginCreateRoleNode-CanCancel0 = 14,
		Beyond-Login-LoginCreateRoleNode-WorkProcess-get_keepWaiting0 = 14,
		Beyond-Login-LoginDownloadTask-Tick0 = 14,
		Beyond-Login-NetUsagePolicy-AllowMobileDataInLastCheck0 = 14,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-IsInterruptable0 = 14,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-TryInterrupt0 = 14,
		Beyond-Login-LoginGSNode-_FallbackToInitNodeImpl0 = 14,
		Beyond-Login-LoginGSNode-_LogoutToInitNode0 = 14,
		Beyond-Login-LoginGSNode-_FallbackToResRepairImpl0 = 14,
		Beyond-Login-LoginGSNode-_FallbackToPreDownloadImpl0 = 14,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-get_keepWaiting0 = 14,
		Beyond-Login-LoginHotUpdater-get_keepWaiting0 = 14,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-CheckIfNeedReload0 = 14,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasAssetsChanged0 = 14,
		Beyond-Login-LoginPreDownloadNode-_ConsumePreDownloadRequest0 = 14,
		Beyond-Login-LoginViewModel-IsAgeTipsVisible0 = 14,
		Beyond-Login-LoginViewModel-IsGovTipsVisible0 = 14,
		Beyond-Login-LoginViewModel-IsMenuVisible0 = 14,
		Beyond-Login-LoginAgeTipsModel-CanDisplay0 = 14,
		Beyond-Login-LoginWorkFlow-Node-CanCancel0 = 14,
		Beyond-Login-LoginWorkFlow-Worker-Cancel0 = 14,
		Beyond-Login-WaitForSecondsNode-_IsTimeout0 = 14,
		Beyond-Login-LoginMenuPanel-_ShouldShowPreDownloadButton0 = 14,
		Beyond-Login-LoginMenuPanel-_CanQRLogin0 = 14,
		Beyond-GameApp-_CollectSystemInfo0 = 15,
		Beyond-GameApp-_MakeLongPath0 = 16,
		Beyond-GameApp-_CalculateMd50 = 16,
		Beyond-SDK-Impl-U8ExternalTools-GetSignKey0 = 16,
		Beyond-SDK-Impl-U8ExternalTools-U8RootUrl0 = 16,
		Beyond-SDK-Impl-U8Plugin-GetPayAddition0 = 16,
		Beyond-SDK-Impl-U8Plugin-GetSDKToken0 = 16,
		Beyond-SDK-Impl-U8Plugin-GetSDKUid0 = 16,
		Beyond-Login-LoginCheckForUpdateNode-_GetRequestPram0 = 16,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetInfo0 = 16,
		Beyond-Login-LoginProgress-GetInfo0 = 16,
		Beyond-Login-LoginVersionPanel-get_versionZoneType0 = 16,
		Beyond-Login-LoginVersionPanel-get_versionPlatform0 = 16,
		Beyond-Login-LoginVersionPanel-get_versionAppType0 = 16,
		Beyond-Login-LoginVersionPanel-get_versionVersionNum0 = 16,
		Beyond-Login-LoginVersionPanel-get_versionProjectCL0 = 16,
		Beyond-Login-LoginVersionPanel-get_displayGameVersion0 = 16,
		Beyond-Scripts-Entry-WarmUpProgress-GetInfo0 = 16,
		Beyond-GameApp-_ScanDirectory0 = 17,
		Beyond-UI-SplashController-_DoStartSplash0 = 17,
		Beyond-Login-LoginRootPanel-ChildPanel-OnLoginContext0 = 17,
		Beyond-Login-LoginRootPanel-_InitChildPanel0 = 17,
		Beyond-Login-LoginRootPanel-Init0 = 17,
		Beyond-Login-LoginDecorateUI-OnLoginContext0 = 17,
		Beyond-Login-LoginWorkFlow-Worker-SetCurNode0 = 17,
		Beyond-LoginContext-StartCoroutine0 = 17,
		Beyond-LoginController-InvokeWhenStart0 = 17,
		Beyond-LoginManager-InvokeWhenWorkFlowFinished0 = 17,
		Beyond-LoginController-MaskCtrl-DisableNetMask0 = 17,
		Beyond-Login-LoginWorkFlow-_EventOnSelectServer0 = 17,
		Beyond-LoginController-OnValueChanged0 = 17,
		Beyond-Login-LoginMockUIDPanel-_SaveLastSelectedServer0 = 17,
		Beyond-LoginContext-StopCoroutine0 = 17,
		Beyond-LoginManager-SceneComponentOnly_Bind0 = 17,
		Beyond-LoginManager-VocResSelDialog0 = 17,
		Beyond-LoginManager-MockLoginWithCallback0 = 17,
		Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateTips0 = 17,
		Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateCircle0 = 17,
		Beyond-SDK-Impl-U8ExternalTools-Log0 = 17,
		Beyond-SDK-Impl-U8ExternalTools-LogError0 = 17,
		Beyond-SDK-Impl-U8ExternalTools-LogWarning0 = 17,
		Beyond-SDK-Impl-U8ExternalTools-SetSubChannel0 = 17,
		Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-OnGT3Message0 = 17,
		Beyond-SDK-Impl-U8ExternalTools-OnSDKExtraInfo0 = 17,
		Beyond-SDK-Impl-U8Plugin-OnProductListChanged0 = 17,
		Beyond-Login-LoginHotUpdater-WriteLocalResPrefToFile0 = 17,
		Beyond-Login-PreloadNode-_OnGetServerListFail0 = 17,
		Beyond-Login-U8LoginNode-_OnLoginFail0 = 17,
		Beyond-Login-LoginAgeTipsProp-UpdateContent0 = 17,
		Beyond-Login-LoginWorkFlow-AddEventReceiver0 = 17,
		Beyond-Login-LoginSceneAnimCtrl-OnValueChanged0 = 17,
		Beyond-Login-LoginSceneAnimCtrl-GetAnimationClips0 = 17,
		Beyond-Login-LoginAgeTipsDetailPanel-_EventOnCloseClicked0 = 17,
		Beyond-Login-LoginAgeTipsDetailPanel-Init0 = 17,
		Beyond-Login-LoginAgeTipsDetailPanel-_SplitLongString0 = 17,
		Beyond-Login-LoginAgeTipsDetailPanel-_RenderContent0 = 17,
		Beyond-Login-LoginAgeTipsDetailPanel-OnValueChanged0 = 17,
		Beyond-Login-LoginAgeTipsPanel-_EventOnOpenAgeTipsClicked0 = 17,
		Beyond-Login-LoginAgeTipsPanel-OnValueChanged0 = 17,
		Beyond-Login-LoginAlertDialog-_OnConfirmClicked0 = 17,
		Beyond-Login-LoginDecorateUI-OnValueChanged0 = 17,
		Beyond-Login-LoginEnterGamePanel-_OnEnterGameClicked0 = 17,
		Beyond-Login-LoginEnterGamePanel-OnValueChanged0 = 17,
		Beyond-Login-LoginGovTipsPanel-_EventOnOpenAgeTipsClicked0 = 17,
		Beyond-Login-LoginGovTipsPanel-OnValueChanged0 = 17,
		Beyond-Login-LoginJudgeDialog-_OnPositiveClicked0 = 17,
		Beyond-Login-LoginJudgeDialog-_OnNegativeClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_OnAnnounceClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_OnSettingClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_OnResCheckClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_ShowPreDownloadConfirm0 = 17,
		Beyond-Login-LoginMenuPanel-_OnPreDownloadClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_OnLogoutClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_OnQuitGameClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_OnLoginClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_OnQRClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_HideLoginSuccessToastIfFallback0 = 17,
		Beyond-Login-LoginMenuPanel-_UpdatePreDownloadButtonState0 = 17,
		Beyond-Login-LoginMenuPanel-OnValueChanged0 = 17,
		Beyond-Login-LoginMenuPanel-_OnCustomServiceClicked0 = 17,
		Beyond-Login-LoginMenuPanel-_OnAccountCenterClicked0 = 17,
		Beyond-Login-LoginResourcePanel-OnValueChanged0 = 17,
		Beyond-Login-LoginServerSelectItemView-_OnClicked0 = 17,
		Beyond-Login-LoginServerSelectPanel-_OnConfirmClicked0 = 17,
		Beyond-Login-LoginServerSelectPanel-_OnCloseClicked0 = 17,
		Beyond-Login-LoginServerSelectPanel-OnValueChanged0 = 17,
		Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked1 = 17,
		Beyond-Login-LoginVocResSelItemView-_OnClicked0 = 17,
		Beyond-GameApp-_CanAccess0 = 18,
		Beyond-GameApp-_BuildEntry0 = 19,
		Beyond-GameApp-_ScanParallel0 = 20,
		Beyond-GameApp-_TreeNodeCompare0 = 21,
		Beyond-Login-LoginMockUIDPanel-_IndexOfServer0 = 21,
		Beyond-GameApp-_FormatSize0 = 22,
		Beyond-Login-LoginMenuPanel-_FormatPreDownloadSize0 = 22,
		Beyond-GameApp-_PrintTreeNode0 = 23,
		Beyond-LoginManager-AlertDialog0 = 23,
		Beyond-LoginController-MockLoginWithCallback0 = 23,
		Beyond-Login-LoginSceneComponent-Bind0 = 23,
		Beyond-LoginManager-MockManualSelectServer0 = 23,
		Beyond-Login-LoginWorkFlow-Node-Init0 = 23,
		Beyond-Login-LoginMockUIDPanel-_SmokeEnterGame0 = 23,
		Beyond-GameApp-_WriteTreeReport0 = 24,
		Beyond-GameApp-LaunchScanCoordinator0 = 25,
		Beyond-GameApp-ScanLocalFiles0 = 26,
		Beyond-Login-LoginServerSelectPanel-_UpdateServerCell0 = 26,
		Beyond-Login-LoginVocResSelDialog-_UpdateCell0 = 26,
		Beyond-SDK-SDKLaunchAuth-_IsExcludedSubChannel0 = 27,
		Beyond-SDK-SDKLaunchAuth-_ShouldRun0 = 27,
		Beyond-SDK-SDKLaunchAuth-_HasNetworkCfg0 = 27,
		Beyond-SDK-SDKLaunchAuth-_IsLaunchAuthEnabled0 = 27,
		Beyond-GameApp-get_IsScanRunning0 = 27,
		Beyond-RenderPipelineDataLoader-IsPreLoadFinished0 = 27,
		Beyond-Login-LoginHotUpdater-IsNeedSoftRestart0 = 27,
		Beyond-UI-SplashController-get_isPlaying0 = 27,
		Beyond-SDK-Impl-U8ExternalTools-IsInited0 = 27,
		Beyond-SDK-Impl-U8ExternalTools-NeedRetryInit0 = 27,
		Beyond-SDK-Impl-U8ExternalTools-NeedQuitGame0 = 27,
		Beyond-SDK-Impl-U8ExternalTools-IsHGSDKInited0 = 27,
		Beyond-SDK-Impl-U8Plugin-_UseMockVersion0 = 27,
		Beyond-Login-LoginCheckForUpdateNode-_ShouldUseCloudGameLowScoreTip0 = 27,
		Beyond-Login-LoginWorkFlow-HasEnteredPreloadThisSession0 = 27,
		Beyond-Login-LoginGameUpdater-IsPreDownloadSupportedOnCurrentPlatform0 = 27,
		Beyond-Login-LoginGameUpdater-IsPreDownloadEnabled0 = 27,
		Beyond-Login-LoginHotUpdater-CheckInitialAssetChanged0 = 27,
		Beyond-GameApp-FetchRemoteNetworkCfg0 = 28,
		Beyond-GameApp-QuitGame0 = 29,
		Beyond-SDK-SDKLaunchAuth-WaitIfNeeded0 = 30,
		Beyond-SDK-Impl-U8ExternalTools-WaitForInited0 = 30,
		Beyond-SDK-Impl-U8ExternalTools-WaitForInitHGSDK0 = 30,
		Beyond-Login-LoginCheckForUpdateNode-AlertNoMatchDeviceBeforeLogin0 = 30,
		Beyond-Login-LoginGSNode-_ConfirmServer0 = 30,
		Beyond-UI-SplashController-_GetSplashConfigs0 = 31,
		Beyond-UI-SplashController-_StartLicenseCoroutine0 = 32,
		Beyond-UI-SplashController-_OnSplashCompleteCoroutine0 = 32,
		Beyond-GameApp-_InitSecuritySDK0 = 32,
		Beyond-GameInitState-_DoInit0 = 32,
		Beyond-LoginController-MaskCtrl-WaitForCrossSceneMasks0 = 32,
		Beyond-LoginController-BeforeDestroy0 = 32,
		Beyond-LoginController-_InitCoroutine0 = 32,
		Beyond-Login-LoginWorkFlow-DoWorkFlow0 = 32,
		Beyond-GamePreloadState-_DoPreload0 = 32,
		Beyond-GameSoftRestartState-_SoftRestart0 = 32,
		Beyond-GameStateMachine-ReturnToLoginState0 = 32,
		Beyond-Login-LoginMockUIDPanel-HideAndDestroy0 = 32,
		Beyond-LoginManager-VocResSelDialogWithConfirm0 = 32,
		Beyond-Login-LoginCheckForUpdateNode-_AlertAndQuitForExtraConfigFatalError0 = 32,
		Beyond-Login-LoginCheckForUpdateNode-_AlertStartupHardwareCheckIfNeeded0 = 32,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdatePC0 = 32,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutinePC0 = 32,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutine0 = 32,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutineMobile0 = 32,
		Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutine0 = 32,
		Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutineMobileImpl0 = 32,
		Beyond-Login-LoginGameUpdater-_YieldGameUpdateInfoChangedAndQuit0 = 32,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_EnterGameCoroutine0 = 32,
		Beyond-Login-LoginLocalResTask-Work0 = 32,
		Beyond-Login-LoginHotUpdater-_Work0 = 32,
		Beyond-Login-LoginInitNode-_InitRemoteConfigs0 = 32,
		Beyond-Login-LoginInitNode-_InitCoroutine0 = 32,
		Beyond-Login-LoginPreDownloadNode-_ApplyPreDownloadCoroutine0 = 32,
		Beyond-Login-LoginPreDownloadNode-_DownloadPreDownloadCoroutine0 = 32,
		Beyond-Login-LoginPreDownloadNode-_PreDownloadCoroutine0 = 32,
		Beyond-Login-PreloadNode-_WarmUp0 = 32,
		Beyond-Login-PreloadNode-_GetServerListInfoMock0 = 32,
		Beyond-Login-PreloadNode-_GetServerListInfo0 = 32,
		Beyond-Login-PreloadNode-_GetServerList0 = 32,
		Beyond-Login-PreloadNode-_LoginPreLoad0 = 32,
		Beyond-Login-LoginSDKInitNode-_WaitForSDKInited0 = 32,
		Beyond-Login-LoginSDKInitNode-_SDKInitCoroutine0 = 32,
		Beyond-Login-LoginMenuPanel-_HideLoginSuccessToastCoroutine0 = 32,
		Beyond-Login-U8LoginNode-_FinishLogin0 = 32,
		Beyond-Login-U8LoginNode-_LoginCoroutine0 = 32,
		Beyond-Login-LoginServerSelectPanel-_WaitingForShowListAwake0 = 32,
		Beyond-UI-SplashController-_Play0 = 33,
		Beyond-UI-SplashController-Show0 = 34,
		Beyond-GameApp-_OnSystemScreenSizeChanged0 = 35,
		Beyond-GameApp-_Init0 = 36,
		Beyond-GameApp-OnApplicationFocus0 = 36,
		Beyond-GameApp-_OnApplicationPauseForSecurity0 = 36,
		Beyond-GameApp-OnApplicationPause0 = 36,
		Beyond-Login-LoginWorkFlow-_EnableCursor0 = 36,
		Beyond-Login-LoginRootPanel-_SetDebugPanelActive0 = 36,
		Beyond-Login-LoginDecorateUI-_ToggleGlow0 = 36,
		Beyond-LoginManager-_ClearWorkflowAndContext0 = 36,
		Beyond-Login-LoginRootPanel-ToggleLoginBindingGroup0 = 36,
		Beyond-Login-LoginWorkFlow-_EventOnOpenServerSelect0 = 36,
		Beyond-LoginManager-ToggleLoginBindingGroup0 = 36,
		Beyond-Login-LoginGSNode-_FallbackToInitWithMask0 = 36,
		Beyond-Login-LoginViewModel-SetPreDownloadDownloading0 = 36,
		Beyond-Login-U8LoginNode-_EnableBlurMask0 = 36,
		Beyond-Login-LoginMenuPanel-_OnReceiveRedDotAndPopup0 = 36,
		Beyond-Login-LoginMenuPanel-_OnFocusMenuGroup0 = 36,
		Beyond-Login-LoginServerSelectItemView-SetSelected0 = 36,
		Beyond-Login-LoginVocResSelItemView-SetSelected0 = 36,
		Beyond-GameApp-_DelayInit0 = 37,
		Beyond-LoginManager-InitCoroutine0 = 37,
		Beyond-GameApp-QuitGame1 = 38,
		Beyond-GameApp-PollScanResult0 = 39,
		Beyond-GameInitState-_CheckIfLocalInitialAssetsValid0 = 40,
		Beyond-GameInitState-_InitInitialResourceManager0 = 41,
		Beyond-Login-LoginWorkFlow-_UpdateCursor0 = 42,
		Beyond-Login-LoginMenuPanel-_OnInputChanged0 = 42,
		Beyond-Login-LoginServerSelectPanel-_OnInputChanged0 = 42,
		Beyond-Login-LoginVocResSelDialog-_OnInputTypeChanged0 = 42,
		Beyond-LoginController-get_maskCtrl0 = 43,
		Beyond-LoginController-MaskCtrl-_GetMaskByType0 = 44,
		Beyond-LoginContext-_DisposeCoroutine0 = 45,
		Beyond-Login-LoginWorkFlow-Worker-Work0 = 45,
		Beyond-LoginManager-_LoginWorkFlowCoroutine0 = 45,
		Beyond-Login-LoginWorkFlow-_FetchAgeTipsCoroutine0 = 45,
		Beyond-LoginController-_MockLoginCoroutine0 = 45,
		Beyond-LoginController-Dialog-_CloseCoroutine0 = 45,
		Beyond-LoginManager-AlertDialogWithConfirm0 = 45,
		Beyond-Login-LoginCheckForUpdateNode-_GetOnlineAppVersion0 = 45,
		Beyond-Login-LoginGameUpdater-_GetLastGameInfo0 = 45,
		Beyond-Login-LoginGameUpdater-CheckLastGameInfo0 = 45,
		Beyond-Login-LoginGameUpdater-_YieldErrorAlert0 = 45,
		Beyond-Login-LoginGameUpdater-_DoTaskUpdating0 = 45,
		Beyond-Login-LoginGameUpdater-_UpdateGame0 = 45,
		Beyond-Login-LoginGameUpdater-DoUpdate0 = 45,
		Beyond-Login-LoginGameUpdater-_ApplyPreDownload0 = 45,
		Beyond-Login-LoginGameUpdater-ApplyPreDownload0 = 45,
		Beyond-Login-LoginGameUpdater-_DownloadPreDownload0 = 45,
		Beyond-Login-LoginGameUpdater-_RefreshPreDownloadResAction0 = 45,
		Beyond-Login-LoginGameUpdater-DownloadPreDownload0 = 45,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_OnAuthError0 = 45,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_MockManualSelectServer0 = 45,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_SaveCurrentUserToServerConfig0 = 45,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_YieldAlertError0 = 45,
		Beyond-Login-LoginHotUpdater-_UpdateResVersionDev0 = 45,
		Beyond-Login-LoginHotUpdater-_UpdateResVersionProd0 = 45,
		Beyond-Login-LoginHotUpdater-_UpdateResVersion0 = 45,
		Beyond-Login-LoginHotUpdater-_ReloadResourceIndexes0 = 45,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeDownload0 = 45,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeLocal0 = 45,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeSkip0 = 45,
		Beyond-Login-LoginHotUpdater-_CreateMainCoroutine0 = 45,
		Beyond-Login-LoginHotUpdater-_VitalError0 = 45,
		Beyond-Login-LoginInitNode-_YieldAlertError0 = 45,
		Beyond-LoginController-MaskCtrl-EnableMask0 = 46,
		Beyond-Login-LoginDecorateUI-_EnsureGlowPlayer0 = 47,
		Beyond-LoginController-InitUI0 = 48,
		Beyond-Login-LoginWorkFlow-FWork-Start0 = 49,
		Beyond-Login-LoginWorkFlow-FWork-get_curNode0 = 50,
		Beyond-Login-LoginWorkFlow-IsOnOrAfterWork0 = 51,
		Beyond-Login-LoginWorkFlow-IsBeforeWork0 = 51,
		Beyond-Login-LoginWorkFlow-IsAfterWork0 = 51,
		Beyond-Login-LoginWorkFlow-_CheckIfGameStateNotMatch0 = 52,
		Beyond-Login-LoginWorkFlow-_AdjustCurrentGameState0 = 53,
		Beyond-Login-LoginWorkFlow-Node-Cancel0 = 54,
		Beyond-Login-LoginCheckForUpdateNode-Work0 = 54,
		Beyond-Login-LoginCreateRoleNode-Work0 = 54,
		Beyond-Login-LoginGameUpdateNode-Work0 = 54,
		Beyond-Login-LoginGSNode-Work0 = 54,
		Beyond-Login-LoginInitNode-Work0 = 54,
		Beyond-Login-LoginPreDownloadNode-Work0 = 54,
		Beyond-Login-PreloadNode-Work0 = 54,
		Beyond-Login-LoginSDKInitNode-Work0 = 54,
		Beyond-Login-U8LoginNode-Work0 = 54,
		Beyond-Login-HotUpdateNode-Work0 = 54,
		Beyond-Login-WaitForSecondsNode-Work0 = 54,
		Beyond-Login-PreloadPostDelayNode-Work0 = 54,
		Beyond-Login-Trans2GsLoginNode-Work0 = 54,
		Beyond-Login-FinishNode-Work0 = 54,
		Beyond-Login-LoginWorkFlow-FWork-ConsumeFallback0 = 55,
		Beyond-Login-LoginWorkFlow-FWork-WorkEnd0 = 55,
		Beyond-Login-LoginWorkFlow-FWork-MoveNextIndex0 = 56,
		Beyond-Login-LoginAlertDialog-SetParams0 = 57,
		Beyond-Login-LoginVocResSelDialog-SetParams0 = 58,
		Beyond-Login-LoginJudgeDialog-SetParams0 = 59,
		Beyond-LoginManager-_StartShowJudgeDialogCoroutine0 = 59,
		Beyond-LoginManager-JudgeDialog1 = 59,
		Beyond-LoginContext-Init0 = 60,
		Beyond-Login-LoginWorkFlow-PeekFallbackStatus0 = 61,
		Beyond-GameMainState-ReleaseMainGame0 = 62,
		Beyond-GameStateBase-OnTick0 = 63,
		Beyond-Login-LoginSceneAnimCtrl-Tick0 = 63,
		Beyond-Login-LoginDecorateUI-_TimeManagerTick0 = 63,
		Beyond-Login-LoginDecorateUI-Tick0 = 63,
		Beyond-LoginController-get_rootPanel0 = 64,
		Beyond-LoginController-GetEnterGamePanelPredelay0 = 65,
		Beyond-Login-LoginGameUpdater-GetWaitTime0 = 65,
		Beyond-Login-LoginDownloadTask-GetDecompressProgress0 = 65,
		Beyond-Login-LoginDownloadTask-GetCheckProgress0 = 65,
		Beyond-Login-LoginSceneAnimCtrl-_RandomIntervalA1s0 = 65,
		Beyond-LoginContext-ViewOnlyController0 = 66,
		Beyond-LoginController-MaskCtrl-EnableNetMask0 = 67,
		Beyond-Login-LoginServerSelectModel-get_serverList0 = 68,
		Beyond-Login-LoginServerSelectModel-UpdateSelectedServer0 = 69,
		Beyond-LoginController-Dialog-TryCloseWithCallback0 = 69,
		Beyond-LoginManager-AssetLoader-_CheckDisposedBeforeLoad0 = 69,
		Beyond-Login-LoginGameUpdater-_ConsumePreDownloadCancelRequest0 = 69,
		Beyond-Login-LoginWorkFlow-Worker-UpdateOnce0 = 69,
		Beyond-Login-LoginWorkFlow-UpdateOnce0 = 69,
		Beyond-Login-LoginServerSelectModel-GetSelectedServer0 = 70,
		Beyond-Login-LoginServerSelectModel-get_curServerZoneData0 = 70,
		Beyond-Login-LoginWorkFlow-_HandleGlobalEvent0 = 71,
		Beyond-Login-LoginWorkFlow-Node-OnEvent0 = 71,
		Beyond-Login-LoginGSNode-OnEvent0 = 71,
		Beyond-Login-LoginPreDownloadNode-OnEvent0 = 71,
		Beyond-Login-U8LoginNode-OnEvent0 = 71,
		Beyond-Login-LoginWorkFlow-SendEvent0 = 72,
		Beyond-LoginContext-SendEvent0 = 72,
		Beyond-Login-LoginMockUIDPanel-FOptions-IsUIDFixed0 = 73,
		Beyond-Login-LoginMockUIDPanel-_MovePreferredServerToFront0 = 74,
		Beyond-Login-LoginMockUIDPanel-_OnSelectServer0 = 75,
		Beyond-Login-LoginGameUpdater-OperationContext-CompleteWithCode0 = 75,
		Beyond-Login-LoginGameUpdater-OperationContext-UncompleteWithCode0 = 75,
		Beyond-Login-LoginGameUpdater-_OnApplyPreDownloadProgress0 = 75,
		Beyond-Login-LoginMockUIDPanel-LoginWithCallback0 = 76,
		Beyond-LoginController-MaskCfg-CreateTweenAndHide0 = 77,
		Beyond-LoginController-MaskCtrl-IsMaskTweening0 = 78,
		Beyond-LoginManager-AlertDialogWithResult0 = 79,
		Beyond-LoginManager-FetchRemoteConfigUtilSuc0 = 79,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_NetConnectAndGSLogin0 = 79,
		Beyond-LoginManager-JudgeDialog0 = 80,
		Beyond-LoginManager-_ExtractErrorInfo0 = 81,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ExtractErrorInfo0 = 81,
		Beyond-LoginManager-DevOnlyCheckEnableLocalResMode0 = 82,
		Beyond-LoginManager-DevOnlyUseLocalResVersion0 = 83,
		Beyond-LoginManager-FlowWithMaskMgr-_OnFlowFinished0 = 84,
		Beyond-LoginManager-FlowWithMaskMgr-StartFlow0 = 84,
		Beyond-LoginManager-FFlowCondition-IsTargetMatch0 = 85,
		Beyond-LoginManager-FlowWithMaskMgr-_FlowCoroutine0 = 86,
		Beyond-SDK-PlatformFont-GetFont0 = 87,
		Beyond-SDK-SDKLaunchAuth-OnResult0 = 88,
		Beyond-SDK-SDKNetUtils-HTTPPost0 = 89,
		Beyond-SDK-SDKNetUtils-HTTPGet0 = 90,
		Beyond-SDK-SDKNetUtils-BeyondHttp-DoHTTP0 = 91,
		Beyond-SDK-Impl-U8ExternalTools-GetDeviceIDs0 = 92,
		Beyond-SDK-Impl-U8ExternalTools-GetPlatformKey0 = 93,
		Beyond-Login-LoginGameUpdater-GetNoAlertCode0 = 93,
		Beyond-Login-LoginHotUpdater-_CurrentWorkMode0 = 93,
		Beyond-Login-LoginVocResSelDialog-_ResolveInitialSelectedIndex0 = 93,
		Beyond-SDK-Impl-U8ExternalTools-_TryGetGameProtocolUpdateCheckErrorCode0 = 94,
		Beyond-Login-LoginGameUpdater-GetCachedEstimatedPreDownloadSize0 = 94,
		Beyond-SDK-Impl-U8ExternalTools-_TryGetLaunchAuthDetail0 = 95,
		Beyond-SDK-Impl-U8ExternalTools-_ProcessExtraInfo0 = 96,
		Beyond-SDK-Impl-U8ExternalTools-_ConvertToPOSTResult0 = 97,
		Beyond-SDK-Impl-U8ExternalTools-POSTImplementation0 = 98,
		Beyond-SDK-Impl-U8ExternalTools-CreateCaptchaHandler0 = 99,
		Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_GET_TOKEN0 = 100,
		Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_CREATE_ORDER0 = 100,
		Beyond-SDK-Impl-U8ExternalTools-GetErrorMessage0 = 101,
		Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-FetchCaptchaCoroutine0 = 102,
		Beyond-SDK-Impl-U8Plugin-_MockLogin0 = 103,
		Beyond-SDK-Impl-U8Plugin-Login0 = 103,
		Beyond-SDK-Impl-U8Plugin-Logout0 = 104,
		Beyond-SDK-Impl-U8Plugin-Pay0 = 105,
		Beyond-SDK-Impl-U8Plugin-TryLoadSDKMeta0 = 106,
		Beyond-Login-LoginCheckForUpdateNode-get_type0 = 107,
		Beyond-Login-LoginCreateRoleNode-get_type0 = 107,
		Beyond-Login-LoginGameUpdateNode-get_type0 = 107,
		Beyond-Login-LoginGSNode-get_type0 = 107,
		Beyond-Login-LoginInitNode-get_type0 = 107,
		Beyond-Login-LoginPreDownloadNode-get_type0 = 107,
		Beyond-Login-PreloadNode-get_type0 = 107,
		Beyond-Login-LoginSDKInitNode-get_type0 = 107,
		Beyond-Login-U8LoginNode-get_type0 = 107,
		Beyond-Login-HotUpdateNode-get_type0 = 107,
		Beyond-Login-PreloadPostDelayNode-get_type0 = 107,
		Beyond-Login-Trans2GsLoginNode-get_type0 = 107,
		Beyond-Login-FinishNode-get_type0 = 107,
		Beyond-Login-LoginWorkFlow-FWork-MarkFallback0 = 108,
		Beyond-Login-LoginWorkFlow-Fallback0 = 109,
		Beyond-Login-LoginWorkFlow-CancelAndFallback0 = 109,
		Beyond-Login-LoginDownloadTask-GetDownloadProgress0 = 110,
		Beyond-Login-LoginDownloadTask-GetWorkState0 = 111,
		Beyond-Login-LoginDownloadTask-_GetFileList0 = 112,
		Beyond-Login-LoginDownloadTask-_GetAllFileList0 = 113,
		Beyond-Login-LoginDownloadTask-_OnDownloadError0 = 114,
		Beyond-Login-NetUsagePolicy-_GetPrettySizeStringUpToMB0 = 115,
		Beyond-Login-NetUsagePolicy-CheckIfAllowDownload0 = 116,
		Beyond-Login-LoginDownloadTask-_OnDownloadPaused0 = 117,
		Beyond-Login-LoginGameUpdater-_TryGetLatestGameInfo0 = 118,
		Beyond-Login-LoginGameUpdater-_YieldCheckNetUsagePolicy0 = 119,
		Beyond-Login-LoginGameUpdater-_OnDownloadProgress0 = 120,
		Beyond-Login-LoginGameUpdater-_WaitForTaskCancel0 = 121,
		Beyond-Login-LoginGameUpdater-_CancelAndClearTask0 = 121,
		Beyond-Login-LoginGameUpdater-GetResAction0 = 122,
		Beyond-Login-LoginGameUpdater-RefreshEstimatedPreDownloadSize0 = 123,
		Beyond-Login-LoginGameUpdater-_LogPreDownloadStatusChanged0 = 124,
		Beyond-Login-LoginGameUpdater-_LogPreDownloadApplyProgress0 = 125,
		Beyond-Login-LoginGameUpdater-_EventLogPreApplyProgress0 = 126,
		Beyond-Login-LoginGameUpdater-_GetPreDownloadErrorInfo0 = 127,
		Beyond-Login-LoginGameUpdater-_YieldPreDownloadErrorDialog0 = 128,
		Beyond-Login-LoginGameUpdater-_GetEventLogProgress0 = 129,
		Beyond-Login-LoginGameUpdater-PreDownloadDownloadContext-ResetTaskTrackState0 = 130,
		Beyond-Login-LoginGameUpdater-_BytesToMB0 = 131,
		Beyond-Login-LoginGameUpdater-_EventLogPreDownloadStart0 = 132,
		Beyond-Login-LoginGameUpdater-_CancelPreDownloadTask0 = 133,
		Beyond-Login-LoginGameUpdater-PreDownloadDownloadContext-UpdateSizeTrackState0 = 134,
		Beyond-Login-LoginGameUpdater-_EventLogPreDownloadPause0 = 135,
		Beyond-Login-LoginGameUpdater-_EventLogPreDownloadFinish0 = 136,
		Beyond-Login-LoginGameUpdater-_EventLogPreDownloadProgress0 = 137,
		Beyond-Login-LoginGameUpdater-_LogPreDownloadSizeProgress0 = 138,
		Beyond-Login-LoginGameUpdater-_ShouldClearPreDownloadTask0 = 139,
		Beyond-Login-LoginGameUpdater-_IsSameGameUpdateInfo0 = 140,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetCurrent0 = 141,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetTotal0 = 141,
		Beyond-Login-LoginProgress-GetCurrent0 = 141,
		Beyond-Login-LoginProgress-GetTotal0 = 141,
		Beyond-Scripts-Entry-WarmUpProgress-GetTotal0 = 141,
		Beyond-Scripts-Entry-WarmUpProgress-GetCurrent0 = 141,
		Beyond-Login-LoginHotUpdater-NeedClearFolder0 = 142,
		Beyond-Login-LoginHotUpdater-_GetOnlineResVersion0 = 143,
		Beyond-Login-LoginHotUpdater-WorkContext-GetHotUpdateInfo0 = 144,
		Beyond-Login-LoginHotUpdater-ResourceRootUrl0 = 145,
		Beyond-Login-LoginHotUpdater-_ResourceIndexUrl0 = 145,
		Beyond-Login-LoginHotUpdater-_ResourcePatchUrl0 = 145,
		Beyond-Login-LoginHotUpdater-_ResourceFileUrl0 = 145,
		Beyond-Login-LoginHotUpdater-_ResourcePatchRootUrl0 = 145,
		Beyond-Login-LoginHotUpdater-_LoadOrDownloadResIndex0 = 146,
		Beyond-Login-LoginHotUpdater-_GenResIndex0 = 146,
		Beyond-Login-LoginHotUpdater-_GenRiff0 = 146,
		Beyond-Login-LoginHotUpdater-_DownloadPatchInfo0 = 146,
		Beyond-Login-LoginHotUpdater-_GenLocalRef0 = 146,
		Beyond-Login-LoginHotUpdater-_CheckAndDownloadResource0 = 146,
		Beyond-Login-LoginHotUpdater-_CheckLocalResConsistency0 = 146,
		Beyond-Login-LoginHotUpdater-_LoadStreamingIndex0 = 147,
		Beyond-Login-LoginHotUpdater-_CreateUpdatedLocalResPref0 = 148,
		Beyond-Login-LoginHotUpdater-_EventLogDownloadProgress0 = 149,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasChangedByType0 = 150,
		Beyond-Login-LoginHotUpdater-WorkContext-HasChangedByType0 = 150,
		Beyond-Login-LoginHotUpdater-_ClearDownloadFolder0 = 151,
		Beyond-Login-LoginHotUpdater-StartHotUpdate0 = 152,
		Beyond-Login-LoginProgress-FDownloadSize-_PickUnit0 = 153,
		Beyond-Login-LoginProgress-FDownloadSize-_DisplayWithUnit0 = 154,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatDisplayInfo0 = 155,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatSpeedInfo0 = 156,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatProgressInfo0 = 157,
		Beyond-Login-LoginProgress-FDownloadSize-SetSize0 = 158,
		Beyond-Login-LoginProgress-FDownloadSize-SetProgress0 = 159,
		Beyond-Login-LoginProgress-FDownloadSize-SetIdle0 = 160,
		Beyond-Login-PreloadNode-_QuitGame0 = 161,
		Beyond-Login-LoginMenuPanel-_TryGetLoginSuccessAccount0 = 162,
		Beyond-Login-LoginViewModel-FAgeTipsPolicy-get_display0 = 163,
		Beyond-Login-LoginViewModel-_LoadAgeTipsPolicy0 = 164,
		Beyond-Login-LoginWorkFlow-_RegisterNodes0 = 165,
		Beyond-Login-PreloadPostDelayNode-WaitForSeconds0 = 166,
		Beyond-Login-Trans2GsLoginNode-WaitForSeconds0 = 166,
		Beyond-Login-LoginSceneAnimCtrl-get_tickOption0 = 167,
		Beyond-Login-LoginSceneComponent-get_tickOption0 = 167,
		Beyond-Login-LoginSceneRoot-get_tickOption0 = 167,
		Beyond-Login-LoginDecorateUI-get_tickOption0 = 167,
		Beyond-Login-LoginSceneAnimCtrl-_EnsurePlayer0 = 168,
		Beyond-Login-LoginSceneAnimCtrl-_ChangeToState0 = 169,
		Beyond-Login-LoginAgeTipsDetailPanel-_SplitLicenseToSegments0 = 170,
		Beyond-Login-LoginAgeTipsPanel-_UpdateAgeTipsPolicy0 = 171,
		Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByFadeSwitchTween0 = 172,
		Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByAnimSwitchTween0 = 172,
		Beyond-Login-LoginMenuPanel-_OnUpdateRedDotForSDKListener0 = 173,
		Beyond-Login-LoginMockUIDPanel-get_instance0 = 174,
		Beyond-Login-LoginRootPanel-_OnNotchPaddingChanged0 = 175,
		Beyond-Login-LoginServerSelectItemView-RefreshView0 = 176,
		Beyond-Login-LoginVocResSelItemView-RefreshView0 = 176,
		Beyond-Login-LoginServerSelectPanel-_UpdateServerSelected0 = 177,
		Beyond-Login-LoginVocResSelDialog-_UpdateSelected0 = 177,
		Beyond-Login-LoginVocResSelDialog-UpdateSelected0 = 178
	}

	public delegate void __HotPatchDelegate_1(object P0, Beyond.GameState P1); // TypeDefIndex: 81142; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_2(float P0); // TypeDefIndex: 81143; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_3(bool P0); // TypeDefIndex: 81144; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_4(Beyond.GameSetting.GameSettingAudioSuiteMode P0); // TypeDefIndex: 81145; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_5(Beyond.GameSetting.KeyboardLayoutType P0); // TypeDefIndex: 81146; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_6(EnvLang P0); // TypeDefIndex: 81147; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_7(Beyond.GameSetting.GameSettingLanguageAudio P0); // TypeDefIndex: 81148; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_8(Beyond.GameSetting.GameSettingVideoQuality P0); // TypeDefIndex: 81149; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_9(int P0, int P1, bool P2); // TypeDefIndex: 81150; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_10(Beyond.GameSetting.ScreenResolution P0); // TypeDefIndex: 81151; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_11(Beyond.GameSetting.TeammateSkillEffectStrength P0); // TypeDefIndex: 81152; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_12(); // TypeDefIndex: 81153; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_13(object P0); // TypeDefIndex: 81154; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_14(object P0); // TypeDefIndex: 81155; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_15(); // TypeDefIndex: 81156; 0x0000000185B44B70-0x0000000185B44B80

	public delegate string __HotPatchDelegate_16(object P0); // TypeDefIndex: 81157; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_17(object P0, object P1); // TypeDefIndex: 81158; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_18(object P0, uint P1); // TypeDefIndex: 81159; 0x00000001859B7730-0x00000001859B7740

	public delegate GameApp.FileEntry __HotPatchDelegate_19(GameApp.PendingFile P0); // TypeDefIndex: 81160; 0x00000001852BC110-0x00000001852BC140

	public delegate List<GameApp.FileEntry> __HotPatchDelegate_20(object P0, int P1); // TypeDefIndex: 81161; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_21(object P0, object P1); // TypeDefIndex: 81162; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_22(long P0); // TypeDefIndex: 81163; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_23(object P0, object P1, object P2); // TypeDefIndex: 81164; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_24(object P0, object P1, System.DateTime P2, object P3, object P4); // TypeDefIndex: 81165; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_25(object P0, object P1, int P2, object P3); // TypeDefIndex: 81166; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_26(object P0, object P1, int P2); // TypeDefIndex: 81167; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_27(); // TypeDefIndex: 81168; 0x0000000185B44B70-0x0000000185B44B80

	public delegate IEnumerator __HotPatchDelegate_28(object P0, float P1); // TypeDefIndex: 81169; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_29(int P0); // TypeDefIndex: 81170; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_30(); // TypeDefIndex: 81171; 0x0000000185B44B70-0x0000000185B44B80

	public delegate SplashController.SplashConfig[] __HotPatchDelegate_31(object P0); // TypeDefIndex: 81172; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_32(object P0); // TypeDefIndex: 81173; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_33(object P0, object P1, bool P2); // TypeDefIndex: 81174; 0x00000001811DF7F0-0x00000001811DF810

	public delegate SplashController __HotPatchDelegate_34(object P0, bool P1); // TypeDefIndex: 81175; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_35(in EventData<bool, bool> P0); // TypeDefIndex: 81176; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_36(object P0, bool P1); // TypeDefIndex: 81177; 0x00000001859B7730-0x00000001859B7740

	public delegate IEnumerator __HotPatchDelegate_37(object P0, bool P1); // TypeDefIndex: 81178; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_38(GameAppExitCode P0); // TypeDefIndex: 81179; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_39(out string P0); // TypeDefIndex: 81180; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_40(object P0, out LocalResPref P1, out VirtualFileSystem.BlockValidator P2); // TypeDefIndex: 81181; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_41(object P0, out VirtualFileSystem.BlockValidator P1); // TypeDefIndex: 81182; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_42(object P0, in EventData<Beyond.DeviceInfo.InputType> P1); // TypeDefIndex: 81183; 0x00000001859B7730-0x00000001859B7740

	public delegate LoginController.MaskCtrl __HotPatchDelegate_43(object P0); // TypeDefIndex: 81184; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UISwitchTween __HotPatchDelegate_44(object P0, int P1); // TypeDefIndex: 81185; 0x00000001859B7730-0x00000001859B7740

	public delegate IEnumerator __HotPatchDelegate_45(object P0, object P1); // TypeDefIndex: 81186; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_46(object P0, object P1, LoginController.EMaskType P2, bool P3, bool P4); // TypeDefIndex: 81187; 0x00000001826DF690-0x00000001826DF6C0

	public delegate UIAnimationLayerMixPlayer __HotPatchDelegate_47(object P0); // TypeDefIndex: 81188; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_48(object P0, LoginController.FOptions P1); // TypeDefIndex: 81189; 0x00000001859B7730-0x00000001859B7740

	public delegate LoginWorkFlow.FWork __HotPatchDelegate_49(); // TypeDefIndex: 81190; 0x000000018691BF80-0x000000018691BFC0

	public delegate LoginWorkFlow.ENode __HotPatchDelegate_50(ref LoginWorkFlow.FWork P0); // TypeDefIndex: 81191; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_51(LoginWorkFlow.ENode P0, LoginWorkFlow.ENode P1); // TypeDefIndex: 81192; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_52(LoginWorkFlow.ENode P0); // TypeDefIndex: 81193; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_53(LoginWorkFlow.ENode P0); // TypeDefIndex: 81194; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate CustomYieldInstruction __HotPatchDelegate_54(object P0); // TypeDefIndex: 81195; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_55(ref LoginWorkFlow.FWork P0); // TypeDefIndex: 81196; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_56(ref LoginWorkFlow.FWork P0); // TypeDefIndex: 81197; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_57(object P0, LoginAlertDialog.FParams P1); // TypeDefIndex: 81198; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate void __HotPatchDelegate_58(object P0, LoginVocResSelDialog.FParams P1); // TypeDefIndex: 81199; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_59(object P0, LoginJudgeDialog.FParams P1); // TypeDefIndex: 81200; 0x00000001827C6CC0-0x00000001827C6D00

	public delegate void __HotPatchDelegate_60(object P0, bool P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8); // TypeDefIndex: 81201; 0x00000001823B2550-0x00000001823B25C0

	public delegate bool __HotPatchDelegate_61(object P0, out LoginWorkFlow.ENode P1); // TypeDefIndex: 81202; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_62(Beyond.GameState P0); // TypeDefIndex: 81203; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_63(object P0, float P1); // TypeDefIndex: 81204; 0x00000001859B7730-0x00000001859B7740

	public delegate LoginRootPanel __HotPatchDelegate_64(object P0); // TypeDefIndex: 81205; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_65(object P0); // TypeDefIndex: 81206; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate LoginController __HotPatchDelegate_66(object P0); // TypeDefIndex: 81207; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_67(object P0, object P1, float P2); // TypeDefIndex: 81208; 0x000000018124EAD0-0x000000018124EAF0

	public delegate List<ServerZoneManager.ServerZoneData> __HotPatchDelegate_68(object P0); // TypeDefIndex: 81209; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_69(object P0, object P1); // TypeDefIndex: 81210; 0x00000001859B7730-0x00000001859B7740

	public delegate ServerZoneManager.ServerZoneData __HotPatchDelegate_70(object P0); // TypeDefIndex: 81211; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_71(object P0, ELoginEvent P1, object P2); // TypeDefIndex: 81212; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_72(object P0, ELoginEvent P1, object P2); // TypeDefIndex: 81213; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_73(ref LoginMockUIDPanel.FOptions P0); // TypeDefIndex: 81214; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_74(object P0, ref int P1); // TypeDefIndex: 81215; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_75(object P0, int P1); // TypeDefIndex: 81216; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_76(object P0, LoginMockUIDPanel.FOptions P1, object P2); // TypeDefIndex: 81217; 0x0000000181256E30-0x0000000181256E60

	public delegate UISwitchTween __HotPatchDelegate_77(object P0); // TypeDefIndex: 81218; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_78(object P0, LoginController.EMaskType P1); // TypeDefIndex: 81219; 0x00000001859B7730-0x00000001859B7740

	public delegate IEnumerator __HotPatchDelegate_79(object P0, object P1, object P2, object P3); // TypeDefIndex: 81220; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_80(object P0, object P1, object P2, object P3); // TypeDefIndex: 81221; 0x00000001811CDB70-0x00000001811CDB90

	public delegate string __HotPatchDelegate_81(object P0, object P1, object P2); // TypeDefIndex: 81222; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_82(ref bool P0); // TypeDefIndex: 81223; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_83(object P0, ref bool P1); // TypeDefIndex: 81224; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_84(object P0, LoginManager.FFlowWithMask P1); // TypeDefIndex: 81225; 0x0000000186493DB0-0x0000000186493DF0

	public delegate bool __HotPatchDelegate_85(ref LoginManager.FFlowCondition P0, LoginWorkFlow.ENode P1); // TypeDefIndex: 81226; 0x00000001859B7730-0x00000001859B7740

	public delegate IEnumerator __HotPatchDelegate_86(object P0, LoginManager.FFlowWithMask P1); // TypeDefIndex: 81227; 0x0000000186493DB0-0x0000000186493DF0

	public delegate TMP_FontAsset __HotPatchDelegate_87(object P0); // TypeDefIndex: 81228; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_88(bool P0, long P1, object P2); // TypeDefIndex: 81229; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_89(SDKNetUtils.HttpPostRequest P0); // TypeDefIndex: 81230; 0x0000000186CAA190-0x0000000186CAA1D0

	public delegate void __HotPatchDelegate_90(SDKNetUtils.HttpGetRequest P0); // TypeDefIndex: 81231; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate IEnumerator __HotPatchDelegate_91(object P0, SDKNetUtils.HTTPConfig P1); // TypeDefIndex: 81232; 0x00000001827C6CC0-0x00000001827C6D00

	public delegate Dictionary<string, string> __HotPatchDelegate_92(object P0); // TypeDefIndex: 81233; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_93(object P0); // TypeDefIndex: 81234; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate long __HotPatchDelegate_94(object P0); // TypeDefIndex: 81235; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_95(object P0, out long P1, out string P2); // TypeDefIndex: 81236; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_96(object P0, SDKExtraData P1); // TypeDefIndex: 81237; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate SDKExternalTools.POSTResult __HotPatchDelegate_97(SDKNetUtils.WebHttpResponse P0); // TypeDefIndex: 81238; 0x00000001827C6D00-0x00000001827C6D60

	public delegate void __HotPatchDelegate_98(object P0, SDKExternalTools.POSTRequest P1, object P2); // TypeDefIndex: 81239; 0x00000001827C6B50-0x00000001827C6B90

	public delegate SDKCaptchaHandler __HotPatchDelegate_99(object P0); // TypeDefIndex: 81240; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_100(object P0, SDKExternalTools.ErrMsgMeta P1, out string P2); // TypeDefIndex: 81241; 0x00000001827C6B50-0x00000001827C6B90

	public delegate string __HotPatchDelegate_101(object P0, SDKExternalTools.ErrMsgMeta P1); // TypeDefIndex: 81242; 0x00000001827C6B90-0x00000001827C6BC0

	public delegate IEnumerator __HotPatchDelegate_102(object P0, object P1, object P2); // TypeDefIndex: 81243; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_103(object P0, ExternalPluginLoginParams P1); // TypeDefIndex: 81244; 0x0000000186493DB0-0x0000000186493DF0

	public delegate void __HotPatchDelegate_104(object P0, ExternalPluginLogoutParams P1); // TypeDefIndex: 81245; 0x00000001826DF780-0x00000001826DF7C0

	public delegate void __HotPatchDelegate_105(object P0, ExternalPluginPayParams P1); // TypeDefIndex: 81246; 0x00000001827C6B90-0x00000001827C6BC0

	public delegate bool __HotPatchDelegate_106(object P0, object P1, out SDKMeta P2); // TypeDefIndex: 81247; 0x00000001811DF7F0-0x00000001811DF810

	public delegate LoginWorkFlow.ENode __HotPatchDelegate_107(object P0); // TypeDefIndex: 81248; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_108(ref LoginWorkFlow.FWork P0, int P1); // TypeDefIndex: 81249; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_109(object P0, LoginWorkFlow.ENode P1, bool P2); // TypeDefIndex: 81250; 0x00000001811DF7F0-0x00000001811DF810

	public delegate HGDownloader.DownloadProgress __HotPatchDelegate_110(object P0); // TypeDefIndex: 81251; 0x00000001811D4E00-0x00000001811D4E40

	public delegate HGDownloader.WorkState __HotPatchDelegate_111(object P0); // TypeDefIndex: 81252; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate List<HGFileInfo> __HotPatchDelegate_112(object P0, object P1); // TypeDefIndex: 81253; 0x00000001859B7730-0x00000001859B7740

	public delegate List<HGFolder> __HotPatchDelegate_113(object P0, object P1); // TypeDefIndex: 81254; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_114(object P0, HGRetCodeType P1, int P2); // TypeDefIndex: 81255; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_115(double P0); // TypeDefIndex: 81256; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_116(object P0, long P1, object P2, object P3, object P4, object P5); // TypeDefIndex: 81257; 0x0000000181256340-0x0000000181256360

	public delegate void __HotPatchDelegate_117(object P0, HGDownloader.PauseReason P1); // TypeDefIndex: 81258; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_118(object P0, object P1, out LoginGameUpdater.HGLatestGameInfo P2); // TypeDefIndex: 81259; 0x00000001811DF7F0-0x00000001811DF810

	public delegate IEnumerator __HotPatchDelegate_119(object P0, long P1, object P2); // TypeDefIndex: 81260; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_120(object P0, long P1, long P2, long P3); // TypeDefIndex: 81261; 0x00000001811CDB70-0x00000001811CDB90

	public delegate IEnumerator __HotPatchDelegate_121(object P0, long P1); // TypeDefIndex: 81262; 0x00000001859B7730-0x00000001859B7740

	public delegate LoginGameUpdater.ResAction __HotPatchDelegate_122(object P0); // TypeDefIndex: 81263; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_123(object P0, LoginGameUpdater.ResAction P1); // TypeDefIndex: 81264; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_124(object P0, long P1, int P2, ref int P3); // TypeDefIndex: 81265; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_125(long P0, int P1, ref int P2); // TypeDefIndex: 81266; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_126(ref bool P0, int P1, int P2); // TypeDefIndex: 81267; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_127(int P0); // TypeDefIndex: 81268; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_128(object P0, int P1, object P2); // TypeDefIndex: 81269; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_129(long P0, long P1); // TypeDefIndex: 81270; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_130(object P0, int P1, long P2, long P3); // TypeDefIndex: 81271; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_131(long P0); // TypeDefIndex: 81272; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_132(object P0, object P1, long P2, long P3); // TypeDefIndex: 81273; 0x00000001811CDB70-0x00000001811CDB90

	public delegate IEnumerator __HotPatchDelegate_133(object P0, long P1, bool P2, object P3); // TypeDefIndex: 81274; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_134(object P0, long P1, long P2); // TypeDefIndex: 81275; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_135(object P0, long P1, long P2, int P3); // TypeDefIndex: 81276; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_136(long P0); // TypeDefIndex: 81277; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_137(ref bool P0, long P1, long P2, int P3); // TypeDefIndex: 81278; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_138(long P0, long P1, long P2, long P3, ref int P4); // TypeDefIndex: 81279; 0x00000001812083C0-0x00000001812083E0

	public delegate bool __HotPatchDelegate_139(int P0); // TypeDefIndex: 81280; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_140(object P0, object P1, out string P2); // TypeDefIndex: 81281; 0x00000001811DF7F0-0x00000001811DF810

	public delegate double __HotPatchDelegate_141(object P0); // TypeDefIndex: 81282; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_142(bool P0); // TypeDefIndex: 81283; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_143(object P0, bool P1); // TypeDefIndex: 81284; 0x00000001859B7730-0x00000001859B7740

	public delegate LoginHotUpdater.HotUpdateInfo __HotPatchDelegate_144(object P0, bool P1); // TypeDefIndex: 81285; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_145(object P0, object P1, bool P2); // TypeDefIndex: 81286; 0x00000001811DF7F0-0x00000001811DF810

	public delegate IEnumerator __HotPatchDelegate_146(object P0, object P1, bool P2, object P3); // TypeDefIndex: 81287; 0x00000001811CDB70-0x00000001811CDB90

	public delegate IEnumerator __HotPatchDelegate_147(bool P0, object P1, object P2); // TypeDefIndex: 81288; 0x00000001811DF7F0-0x00000001811DF810

	public delegate LocalResPref __HotPatchDelegate_148(object P0, bool P1, object P2, FResourceDiff P3, out int P4); // TypeDefIndex: 81289; 0x00000001827C6BC0-0x00000001827C6C30

	public delegate void __HotPatchDelegate_149(object P0, ref bool P1, double P2, double P3, int P4, bool P5); // TypeDefIndex: 81290; 0x00000001827C6C30-0x00000001827C6C50

	public delegate bool __HotPatchDelegate_150(object P0, EVFSBlockType P1); // TypeDefIndex: 81291; 0x00000001859B7730-0x00000001859B7740

	public delegate IEnumerator __HotPatchDelegate_151(object P0, object P1, bool P2, bool P3); // TypeDefIndex: 81292; 0x0000000181217F60-0x0000000181217F80

	public delegate LoginHotUpdater __HotPatchDelegate_152(object P0, bool P1); // TypeDefIndex: 81293; 0x00000001859B7730-0x00000001859B7740

	public delegate LoginProgress.FDownloadSize.EUnit __HotPatchDelegate_153(double P0); // TypeDefIndex: 81294; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_154(double P0, LoginProgress.FDownloadSize.EUnit P1); // TypeDefIndex: 81295; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_155(float P0, float P1, LoginProgress.FDownloadSize.EUnit P2); // TypeDefIndex: 81296; 0x0000000182235E70-0x0000000182235E90

	public delegate string __HotPatchDelegate_156(float P0, LoginProgress.FDownloadSize.EUnit P1); // TypeDefIndex: 81297; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_157(float P0, float P1); // TypeDefIndex: 81298; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_158(ref LoginProgress.FDownloadSize P0, double P1, double P2, double P3); // TypeDefIndex: 81299; 0x00000001812250A0-0x00000001812250C0

	public delegate void __HotPatchDelegate_159(ref LoginProgress.FDownloadSize P0, double P1, double P2); // TypeDefIndex: 81300; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_160(ref LoginProgress.FDownloadSize P0); // TypeDefIndex: 81301; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_161(object P0, GameAppExitCode P1); // TypeDefIndex: 81302; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_162(object P0, out string P1); // TypeDefIndex: 81303; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_163(ref LoginViewModel.FAgeTipsPolicy P0); // TypeDefIndex: 81304; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate LoginViewModel.FAgeTipsPolicy __HotPatchDelegate_164(); // TypeDefIndex: 81305; 0x00000001827C6C50-0x00000001827C6C90

	public delegate LoginWorkFlow.Node[] __HotPatchDelegate_165(object P0); // TypeDefIndex: 81306; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_166(object P0, out bool P1); // TypeDefIndex: 81307; 0x00000001859B7730-0x00000001859B7740

	public delegate TickType __HotPatchDelegate_167(object P0); // TypeDefIndex: 81308; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIAnimationMixPlayer __HotPatchDelegate_168(object P0); // TypeDefIndex: 81309; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_169(object P0, LoginSceneAnimCtrl.EState P1); // TypeDefIndex: 81310; 0x00000001859B7730-0x00000001859B7740

	public delegate List<string> __HotPatchDelegate_170(object P0); // TypeDefIndex: 81311; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_171(object P0, LoginViewModel.FAgeTipsPolicy P1); // TypeDefIndex: 81312; 0x00000001827C6C90-0x00000001827C6CC0

	public delegate void __HotPatchDelegate_172(object P0, object P1, bool P2, bool P3); // TypeDefIndex: 81313; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_173(object P0, in EventData<bool> P1); // TypeDefIndex: 81314; 0x00000001859B7730-0x00000001859B7740

	public delegate LoginMockUIDPanel __HotPatchDelegate_174(); // TypeDefIndex: 81315; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_175(object P0, in EventData<float> P1); // TypeDefIndex: 81316; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_176(object P0, object P1, object P2, bool P3); // TypeDefIndex: 81317; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_177(object P0, int P1, object P2); // TypeDefIndex: 81318; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_178(object P0, EVFSBlockType P1); // TypeDefIndex: 81319; 0x00000001859B7730-0x00000001859B7740
}
