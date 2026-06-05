/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Beyond;
using Beyond.Cfg;
using Beyond.GEnums;
using Beyond.Gameplay;
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

// Image 28: Entry.Beyond.dll - Assembly: Entry.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53809-54095

public class RenderSilhouetteRT : MonoBehaviour // TypeDefIndex: 53810
{
	// Fields
	public Camera cameraRT; // 0x18
	public Camera mainCamera; // 0x20
	public Material materialSilhouette; // 0x28
	private static Texture s_mSilhouetteRT; // 0x00
	private static RenderTexture s_mSilhouetteRth; // 0x08

	// Constructors
	public RenderSilhouetteRT() {} // 0x000000018646DB20-0x000000018646DB28

	// Methods
	private void Update() {} // 0x0000000184F213B0-0x0000000184F21740
	private void OnDestroy() {} // 0x0000000184F21740-0x0000000184F21890
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 54091
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_52 DF6EA5B59F0E6C03F390AD5FEA0BBC199EC3524C0A682913148FD071AF1898EC; // 0x00 // Static value (base64): AQAAAAIAAAADAAAABAAAAAUAAAAGAAAABwAAAAgAAAAJAAAACgAAAAsAAAAMAAAADQAAAA== - Metadata: 0x0207901C

	// Nested types
	private struct __StaticArrayInitTypeSize_52 // TypeDefIndex: 54090
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond
{
	public class GameApp : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 53821
	{
		// Fields
		private GameStateMachine m_stateMachine; // 0x18
		private static GameApp _instance_k__BackingField; // 0x00
		private bool m_hasFocus; // 0x20
		private bool m_needCallLuaFocus; // 0x21
		private bool m_pauseStatus; // 0x22
		private bool m_needCallLuaPause; // 0x23
		private const uint FILE_ATTRIBUTE_DIRECTORY = 16; // Metadata: 0x02078385
		private const uint FILE_ATTRIBUTE_READONLY = 1; // Metadata: 0x02078386
		private const uint FILE_ATTRIBUTE_NORMAL = 128; // Metadata: 0x02078387
		private const uint FILE_ATTRIBUTE_REPARSE_POINT = 1024; // Metadata: 0x02078389
		private static readonly IntPtr INVALID_HANDLE_VALUE; // 0x08
		private const uint GENERIC_READ = 2147483648; // Metadata: 0x0207838B
		private const uint GENERIC_WRITE = 1073741824; // Metadata: 0x02078390
		private const uint FILE_SHARE_READ = 1; // Metadata: 0x02078395
		private const uint FILE_SHARE_WRITE = 2; // Metadata: 0x02078396
		private const uint FILE_SHARE_DELETE = 4; // Metadata: 0x02078397
		private const uint OPEN_EXISTING = 3; // Metadata: 0x02078398
		private const uint FILE_FLAG_SEQUENTIAL_SCAN = 134217728; // Metadata: 0x02078399
		private const int ERROR_FILE_NOT_FOUND = 2; // Metadata: 0x0207839D
		private const int ERROR_PATH_NOT_FOUND = 3; // Metadata: 0x0207839E
		private const int ERROR_NO_MORE_FILES = 18; // Metadata: 0x0207839F
		private static byte[] s_md5Buffer; // 0x80000000
		private static int s_scanRunning; // 0x10
		private static string s_pendingScanOutput; // 0x18
	
		// Properties
		public static GameApp instance { get; private set; } // 0x000000018791F598-0x000000018791F694 0x000000018791F694-0x0000000187920840
		public GameState currentState { get => default; } // 0x0000000187920840-0x0000000187920924 
		public static bool IsScanRunning { get => default; } // 0x0000000181845CA0-0x0000000181846960 
	
		// Nested types
		private struct WIN32_FIND_DATA // TypeDefIndex: 53812
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
	
		private class FileEntry // TypeDefIndex: 53813
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
			public FileEntry() {} // 0x0000000187920A3C-0x0000000187920F94
		}
	
		private struct PendingFile // TypeDefIndex: 53814
		{
			// Fields
			public string fullPath; // 0x00
			public long size; // 0x08
			public bool readOnlyAttr; // 0x10
		}
	
		private class ScanContext // TypeDefIndex: 53815
		{
			// Fields
			public readonly ConcurrentQueue<string> dirQueue; // 0x10
			public readonly ConcurrentQueue<PendingFile> fileQueue; // 0x18
			public readonly ConcurrentBag<FileEntry> results; // 0x20
			public int pendingDirs; // 0x28
			public int pendingFiles; // 0x2C
	
			// Constructors
			public ScanContext() {} // 0x0000000187920F94-0x0000000187921308
		}
	
		private class TreeNode // TypeDefIndex: 53816
		{
			// Fields
			public string name; // 0x10
			public FileEntry fileEntry; // 0x18
			public Dictionary<string, TreeNode> children; // 0x20
	
			// Constructors
			public TreeNode() {} // 0x00000001842A98F0-0x00000001842A9930
		}
	
		private sealed class __DelayInit_d__14 : IEnumerator<object> // TypeDefIndex: 53817
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameApp __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181833B10-0x00000001818344A0 
			object IEnumerator.Current { get => default; } // 0x0000000181835C60-0x00000001818362C0 
	
			// Constructors
			public __DelayInit_d__14() {} // Dummy constructor
			public __DelayInit_d__14(int __1__state) {} // 0x0000000185B47D40-0x0000000185B47DB0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184B2CFF0-0x0000000184B2F2F0
			private bool MoveNext() => default; // 0x0000000181837230-0x0000000181838200
			void IEnumerator.Reset() {} // 0x0000000185A5EF70-0x0000000185A5F090
		}
	
		private sealed class __InitSecuritySDK_d__34 : IEnumerator<object> // TypeDefIndex: 53818
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameApp __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184771A90-0x0000000184771BC0 
			object IEnumerator.Current { get => default; } // 0x000000018509BD40-0x000000018509ECE0 
	
			// Constructors
			public __InitSecuritySDK_d__34() {} // Dummy constructor
			public __InitSecuritySDK_d__34(int __1__state) {} // 0x00000001844B3480-0x00000001844B3750
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184CAD2E0-0x0000000184CAD390
			private bool MoveNext() => default; // 0x000000018791EEDC-0x000000018791F104
			void IEnumerator.Reset() {} // 0x00000001849C7C40-0x00000001849C7DF0
		}
	
		private sealed class __FetchRemoteConfigUtilSuc_d__36 : IEnumerator<object> // TypeDefIndex: 53819
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private RemoteNetworkCfg _config_5__2; // 0x20
			private Beyond.Misc.ObjectRef _resultRef_5__3; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184B2B340-0x0000000184B2B560 
			object IEnumerator.Current { get => default; } // 0x0000000184B2B880-0x0000000184B2B920 
	
			// Constructors
			public __FetchRemoteConfigUtilSuc_d__36() {} // Dummy constructor
			public __FetchRemoteConfigUtilSuc_d__36(int __1__state) {} // 0x000000018509BB60-0x000000018509BC10
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018791F104-0x000000018791F400
			private bool MoveNext() => default; // 0x0000000184FA9830-0x0000000184FA9A60
			void IEnumerator.Reset() {} // 0x00000001879209AC-0x0000000187920A3C
		}
	
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 53820
		{
			// Fields
			public string capturedRoot; // 0x10
			public int capturedThreads; // 0x18
			public string capturedOutput; // 0x20
			public string capturedSysInfo; // 0x28
	
			// Constructors
			public __c__DisplayClass70_0() {} // 0x0000000187920924-0x00000001879209AC
	
			// Methods
			internal void _LaunchScanCoordinator_b__0() {} // 0x000000018791F400-0x000000018791F598
		}
	
		// Constructors
		public GameApp() {} // 0x0000000185492010-0x0000000185492020
		static GameApp() {} // 0x0000000181844630-0x0000000181845CA0
	
		// Methods
		public void SwitchState(GameState state) {} // 0x0000000184B2B560-0x0000000184B2B5D0
		private void Awake() {} // 0x000000018425EE20-0x000000018425EEB0
		private bool _NeedDeepProfilerMode() => default; // 0x0000000185F5F2A0-0x0000000185F5F300
		private IEnumerator _DelayInit() => default; // 0x0000000181834580-0x0000000181834720
		private void _RegisterLuaAfterGCEvent() {} // 0x0000000181834720-0x00000001818348B0
		private void _InitNotificationCenter() {} // 0x00000001818344A0-0x0000000181834580
		private void Update() {} // 0x00000001818339F0-0x0000000181833B10
		private void LateUpdate() {} // 0x000000018183A530-0x000000018183A640
		private void OnApplicationQuit() {} // 0x000000018182FA00-0x000000018182FAE0
		private void OnApplicationFocus(bool hasFocus) {} // 0x0000000181843310-0x0000000181843630
		private void _OnApplicationFocusForLua() {} // 0x000000018182A410-0x000000018182AE00
		private void OnApplicationPause(bool pauseStatus) {} // 0x000000018182AE00-0x000000018182C640
		private void _OnApplicationPauseForLua() {} // 0x0000000181828EA0-0x000000018182A410
		private void OnDestroy() {} // 0x000000018183C120-0x000000018183DBF0
		private void _PreInitGameSetting() {} // 0x000000018183EBA0-0x000000018183FF20
		private void _Init() {} // 0x000000018183A640-0x000000018183C120
		private void _UnInit() {} // 0x00000001818362C0-0x0000000181837230
		private void _InitGameStateMachine() {} // 0x000000018182C640-0x000000018182D800
		private void _UnInitGameStateMachine() {} // 0x000000018182F040-0x000000018182FA00
		public static void QuitGame(int exitCode) {} // 0x000000018182D800-0x000000018182F040
		public static void RefreshScreenResolution() {} // 0x000000018182FAE0-0x00000001818339F0
		private static void _OnSystemDisplaySizeChanged() {} // 0x000000018183FF20-0x0000000181843010
		private static void _OnSystemScreenSizeChanged(in EventData<bool, bool> data) {} // 0x0000000181838200-0x000000018183A530
		private IEnumerator _InitSecuritySDK() => default; // 0x000000018183DBF0-0x000000018183EBA0
		private void _OnApplicationPauseForSecurity(bool pauseStatus) {} // 0x00000001818348B0-0x0000000181835C60
		private IEnumerator _FetchRemoteConfigUtilSuc() => default; // 0x0000000185C20250-0x0000000185C20260
		private static extern IntPtr _FindFirstFileW(string lpFileName, out WIN32_FIND_DATA lpFindFileData); // 0x0000000181843010-0x0000000181843310
		private static extern bool _FindNextFileW(IntPtr hFindFile, out WIN32_FIND_DATA lpFindFileData); // 0x0000000185492010-0x0000000185492020
		private static extern bool _FindClose(IntPtr hFindFile); // 0x0000000181843630-0x0000000181844630
		private static extern IntPtr _CreateFileW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile); // 0x0000000185492010-0x0000000185492020
		private static extern bool _ReadFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped); // 0x0000000181378230-0x0000000181378240
		private static extern bool _CloseHandle(IntPtr hObject); // 0x0000000185492010-0x0000000185492020
		public static bool PollScanResult(out string gzOutputPath) {
			gzOutputPath = default;
			return default;
		} // 0x0000000181377E40-0x0000000181377E50
		public static void ScanLocalFiles(string rootDir = null, string outputPath = null, int threadCount = 0 /* Metadata: 0x02078384 */) {} // 0x0000000181846960-0x00000001818469B0
		internal static void LaunchScanCoordinator(string rootDir, string outputPath, int threadCount, string systemInfo = null) {} // 0x0000000181377E40-0x0000000181377E50
		private static List<FileEntry> _ScanParallel(string root, int threadCount) => default; // 0x0000000181378230-0x0000000181378240
		private static void _WorkerLoop(object state) {} // 0x0000000185492010-0x0000000185492020
		private static void _ScanDirectory(ScanContext ctx, string dir) {} // 0x0000000181848370-0x000000018184A310
		private static string _MakeLongPath(string path) => default; // 0x0000000181377E40-0x0000000181377E50
		private static FileEntry _BuildEntry(PendingFile pf) => default; // 0x000000018184A310-0x000000018184AA30
		private static bool _CanAccess(string path, uint desiredAccess) => default; // 0x0000000181377E40-0x0000000181377E50
		private static string _CalculateMd5(string path) => default; // 0x0000000181378230-0x0000000181378240
		private static string _CollectSystemInfo() => default; // 0x0000000185492010-0x0000000185492020
		private static void _WriteTreeReport(List<FileEntry> entries, string root, System.DateTime scanStart, string outputPath, string systemInfo = null) {} // 0x00000001818469B0-0x0000000181848320
		private static void _PrintTreeNode(StringBuilder sb, TreeNode node, string prefix) {} // 0x0000000181377E40-0x0000000181377E50
		private static int _TreeNodeCompare(TreeNode a, TreeNode b) => default; // 0x0000000181848320-0x0000000181848370
		private static string _FormatSize(long bytes) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public interface IMemoryPackProxy // TypeDefIndex: 53822
	{
		// Methods
		void Init();
	}

	public class MemoryPackProxyModule // TypeDefIndex: 53823
	{
		// Fields
		private static IMemoryPackProxy s_memoryPackProxy; // 0x00
	
		// Constructors
		public MemoryPackProxyModule() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void RegisterProxy(IMemoryPackProxy memoryPackProxy) {} // 0x0000000187922ED0-0x0000000187922F20
		public static IMemoryPackProxy GetMemoryPackProxy() => default; // 0x0000000187922E98-0x0000000187922ED0
	}

	public class GameInitState : GameStateBase // TypeDefIndex: 53825
	{
		// Properties
		public override GameState stateId { get => default; } // 0x0000000184FA9D90-0x0000000184FA9ED0 
	
		// Nested types
		private sealed class __DoInit_d__5 : IEnumerator<object> // TypeDefIndex: 53824
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameInitState __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184016410-0x00000001840164B0 
			object IEnumerator.Current { get => default; } // 0x000000018504AAA0-0x000000018504BF90 
	
			// Constructors
			public __DoInit_d__5() {} // Dummy constructor
			public __DoInit_d__5(int __1__state) {} // 0x00000001813AE580-0x00000001813AE590
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184096E30-0x0000000184096EF0
			private bool MoveNext() => default; // 0x0000000184B2CBD0-0x0000000184B2CCC0
			void IEnumerator.Reset() {} // 0x0000000184B2CCC0-0x0000000184B2CD30
		}
	
		// Constructors
		public GameInitState() {} // Dummy constructor
		public GameInitState(GameStateMachine stateMachine) {} // 0x000000018504C050-0x000000018504C1E0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000185355010-0x00000001853555C0
		public override void OnLeave(GameState toStateId) {} // 0x0000000187921308-0x0000000187921310
		private IEnumerator _DoInit() => default; // 0x0000000187921310-0x0000000187921318
		private void _InitInitialResourceManager(out VirtualFileSystem.BlockValidator blockValidator) {
			blockValidator = default;
		} // 0x0000000181378230-0x0000000181378240
		private bool _CheckIfLocalInitialAssetsValid(out LocalResPref outputLocalResPref, out VirtualFileSystem.BlockValidator blockValidator) {
			outputLocalResPref = default;
			blockValidator = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		private void _InitAPPDefaultCulture() {} // 0x00000001852D5AD0-0x00000001852D99A0
		private void _InitGameSetting() {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x00000001879239F4-0x0000000187923A40
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class GameLoginState : GameStateBase // TypeDefIndex: 53826
	{
		// Properties
		public override GameState stateId { get => default; } // 0x0000000185FB6A00-0x0000000185FB6A10 
	
		// Constructors
		public GameLoginState() {} // Dummy constructor
		public GameLoginState(GameStateMachine stateMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000184B2CD30-0x0000000184B2CE40
		public override void OnLeave(GameState toStateId) {} // 0x00000001859EBE30-0x00000001859EBEB0
		private static void _TryStartLoginWorkflow() {} // 0x000000018425EEB0-0x000000018425EF90
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x0000000187921308-0x0000000187921310
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x0000000187921310-0x0000000187921318
	}

	public class GameMainState : GameStateBase // TypeDefIndex: 53827
	{
		// Fields
		private bool m_isFirstEnter; // 0x18
	
		// Properties
		public override GameState stateId { get => default; } // 0x0000000185FB6A10-0x0000000185FB6A20 
	
		// Constructors
		public GameMainState() {} // Dummy constructor
		public GameMainState(GameStateMachine stateMachine) {} // 0x0000000186471D98-0x0000000186471DAC
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000185757E00-0x0000000185757F00
		public override void OnLeave(GameState toStateId) {} // 0x00000001859EBDE0-0x00000001859EBE30
		public static void ReleaseMainGame(GameState toStateId) {} // 0x00000001859EBF70-0x00000001859EF100
		private static void _ClearUtils() {} // 0x0000000186474B54-0x0000000186474C3C
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x0000000187921308-0x0000000187921310
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x0000000187921310-0x0000000187921318
	}

	public class GamePreloadState : GameStateBase // TypeDefIndex: 53829
	{
		// Fields
		private Tables.AsyncLoadTask m_asyncTask; // 0x18
	
		// Properties
		public override GameState stateId { get => default; } // 0x0000000187921308-0x0000000187921310 
	
		// Nested types
		private sealed class __DoPreload_d__6 : IEnumerator<object> // TypeDefIndex: 53828
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GamePreloadState __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185F4FBE0-0x0000000185F4FC50 
			object IEnumerator.Current { get => default; } // 0x0000000185355890-0x00000001853593F0 
	
			// Constructors
			public __DoPreload_d__6() {} // Dummy constructor
			public __DoPreload_d__6(int __1__state) {} // 0x0000000185FB6A20-0x0000000185FB6A30
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184096E30-0x0000000184096EF0
			private bool MoveNext() => default; // 0x0000000185D74470-0x0000000185D74510
			void IEnumerator.Reset() {} // 0x0000000185D74510-0x0000000185D74580
		}
	
		// Constructors
		public GamePreloadState() {} // Dummy constructor
		public GamePreloadState(GameStateMachine stateMachine) {} // 0x0000000187921310-0x0000000187921318
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000181378230-0x0000000181378240
		public override void OnLeave(GameState toStateId) {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator _DoPreload() => default; // 0x00000001852D5060-0x00000001852D5610
		private void _InitGameSettingStateInPreload() {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x0000000187923A40-0x0000000187923A8C
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class GameQuitState : GameStateBase // TypeDefIndex: 53830
	{
		// Properties
		public override GameState stateId { get => default; } // 0x0000000185FB6A30-0x0000000185FB6A40 
	
		// Constructors
		public GameQuitState() {} // Dummy constructor
		public GameQuitState(GameStateMachine stateMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000187921754-0x00000001879217BC
		public override void OnLeave(GameState toStateId) {} // 0x00000001879217BC-0x0000000187921820
		public static void DoQuit() {} // 0x0000000187921318-0x0000000187921754
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x0000000187921308-0x0000000187921310
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x0000000187921310-0x0000000187921318
	}

	public class GameSoftRestartState : GameStateBase // TypeDefIndex: 53832
	{
		// Fields
		private const string CLEAR_SCENE_PATH = "Assets/Beyond/Scenes/BuildScenes/Clear.unity"; // Metadata: 0x020783A0
	
		// Properties
		public override GameState stateId { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class __SoftRestart_d__5 : IEnumerator<object> // TypeDefIndex: 53831
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameSoftRestartState __4__this; // 0x20
			private AsyncOperation _clearSceneOp_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001879218D8-0x0000000187921968 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public __SoftRestart_d__5() {} // Dummy constructor
			public __SoftRestart_d__5(int __1__state) {} // 0x0000000181D27740-0x0000000181D27750
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184096E30-0x0000000184096EF0
			private bool MoveNext() => default; // 0x0000000187921820-0x00000001879218D8
			void IEnumerator.Reset() {} // 0x0000000187921308-0x0000000187921310
		}
	
		// Constructors
		public GameSoftRestartState() {} // Dummy constructor
		public GameSoftRestartState(GameStateMachine stateMachine) {} // 0x0000000187923BBC-0x0000000187924484
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _SoftRestart() => default; // 0x0000000187924484-0x00000001879244D0
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class GameStartState : GameStateBase // TypeDefIndex: 53833
	{
		// Properties
		public override GameState stateId { get => default; } // 0x0000000185FB6A40-0x0000000185FB6A50 
	
		// Constructors
		public GameStartState() {} // Dummy constructor
		public GameStartState(GameStateMachine stateMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000185D212A0-0x0000000185D213F0
		public override void OnLeave(GameState toStateId) {} // 0x0000000185DAC010-0x0000000185DAC110
		private void _OnEnterMainGame() {} // 0x0000000185D79F70-0x0000000185D7A030
		private void __OnEnterMainGame_b__5_0() {} // 0x00000001852D31E0-0x00000001852D3230
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x0000000187921308-0x0000000187921310
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x0000000187921310-0x0000000187921318
	}

	public abstract class GameStateBase : ISimpleStateNode<GameState>, ILuaCallCSharp // TypeDefIndex: 53834
	{
		// Fields
		protected readonly GameStateMachine m_stateMachine; // 0x10
	
		// Properties
		public abstract GameState stateId { get; }
	
		// Constructors
		protected GameStateBase() {} // Dummy constructor
		protected GameStateBase(GameStateMachine stateMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public virtual void OnEnter(GameState fromStateId) {} // 0x000000018525CA80-0x000000018525CB10
		public virtual void OnLeave(GameState toStateId) {} // 0x000000018525CB10-0x000000018525CBA0
		public virtual void OnTick(float deltaTime) {} // 0x0000000187921968-0x00000001879219BC
	}

	public class GameStateMachine : SimpleEnumStateMachine<GameState>, IGameStateMachine, ILuaCallCSharp // TypeDefIndex: 53836
	{
		// Fields
		private readonly GameApp _app_k__BackingField; // 0x30
	
		// Properties
		public GameApp app { get; } // 0x0000000181378230-0x0000000181378240 
		public GameState curState { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class _ReturnToLoginState_d__8 : IEnumerator<object> // TypeDefIndex: 53835
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public GameStateMachine __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184B2B110-0x0000000184B2B340 
			object IEnumerator.Current { get => default; } // 0x0000000185EE04D0-0x0000000185EE0540 
	
			// Constructors
			public _ReturnToLoginState_d__8() {} // Dummy constructor
			public _ReturnToLoginState_d__8(int __1__state) {} // 0x00000001813B51D0-0x00000001813B51E0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184BF10F0-0x0000000184BF1190
			private bool MoveNext() => default; // 0x0000000184B2B920-0x0000000184B2B980
			void IEnumerator.Reset() {} // 0x00000001852D30A0-0x00000001852D3100
		}
	
		// Constructors
		public GameStateMachine() {} // Dummy constructor
		public GameStateMachine(GameApp gameApp) {} // 0x00000001852D3230-0x00000001852D4D20
	
		// Methods
		private void _RegisterStates() {} // 0x0000000181377E40-0x0000000181377E50
		public bool CheckCanReturnToLoginState() => default; // 0x0000000187923408-0x0000000187923454
		public IEnumerator ReturnToLoginState() => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public static class GlobalInitializer // TypeDefIndex: 53837
	{
		// Methods
		public static void InitGlobalConfig() {} // 0x0000000185FADB70-0x0000000185FADB90
	}

	public interface IHotFixCommon // TypeDefIndex: 53838
	{
	}

	public interface IHotFixPatchManagerProxy : IHotFixCommon // TypeDefIndex: 53839
	{
		// Methods
		void InitManager();
		void ReleaseManager();
		void RegisterHotfixSDKEvent();
		void UnregisterHotfixSDKEvent();
		bool TryProcessHotfixSDKExtraInfo(int code, Dictionary<string, object> msg);
		void PatchInitAssemble();
		void PatchRemoteInitAssemble();
		void PatchRemoteInjectedLua();
		void PatchRemoteInjectedLua(string url);
		void PatchMainAssemble();
		void PatchRemoteMainAssemble();
	}

	public class HotFixPatchModules // TypeDefIndex: 53840
	{
		// Fields
		private static Dictionary<System.Type, IHotFixCommon> s_hotFixModules; // 0x00
	
		// Constructors
		public HotFixPatchModules() {} // 0x0000000185492010-0x0000000185492020
		static HotFixPatchModules() {} // 0x0000000185F3FBE0-0x0000000185F3FC70
	
		// Methods
		public static void Register<T>(T module)
			where T : class, IHotFixCommon {}
		public static void UnRegister<T>()
			where T : class, IHotFixCommon {}
		public static T GetModule<T>()
			where T : class, IHotFixCommon => default;
		public static bool TryGetModule<T>(out ref T module)
			where T : class, IHotFixCommon {
			module = default;
			return default;
		}
	}

	public static class InitialPathDef // TypeDefIndex: 53841
	{
		// Fields
		public const string LOGIN_SCENE_PATH = "Assets/Beyond/InitialAssets/Scenes/Login.unity"; // Metadata: 0x020783CD
		public const string LOGIN_SK_ACTOR_M = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_male.prefab"; // Metadata: 0x020783FC
		public const string LOGIN_SK_ACTOR_F = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_female.prefab"; // Metadata: 0x0207843A
		public const string LOGIN_SK_ACTOR_NO_GENDER = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_no_gender.prefab"; // Metadata: 0x0207847A
		public const string LOGIN_MOCK_UID_PANEL = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginMockUIDPanel.prefab"; // Metadata: 0x020784BE
		public const string LOGIN_CONTROLLER_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginController.prefab"; // Metadata: 0x02078502
		public const string LOGIN_ROOT_PANEL_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginRootPanel.prefab"; // Metadata: 0x02078544
		public const string LOGIN_ALERT_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginAlertDialog.prefab"; // Metadata: 0x02078584
		public const string LOGIN_JUDGE_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginJudgeDialog.prefab"; // Metadata: 0x020785C7
		public const string LOGIN_VOC_RES_SELECT_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginVocResSelDialog.prefab"; // Metadata: 0x0207860A
	}

	public class LoginController : MonoBehaviour, ILoginBinder<LoginViewModel> // TypeDefIndex: 53857
	{
		// Fields
		private Transform _uiFunc; // 0x18
		private Transform _uiDialog; // 0x20
		private UIButton _versionBtn; // 0x28
		private LoginDecorateUI _uiDecorate; // 0x30
		private MaskCfg _maskBlur; // 0x38
		private MaskCfg _maskBlack; // 0x40
		private MaskCfg _maskWhite; // 0x48
		private float _enterGamePanelPredelay; // 0x50
		private Canvas _uiRootCanvas; // 0x58
		private UICanvasScaleHelper _uiRootCanvasScaleHelper; // 0x60
		private Canvas _uiDecoCanvas; // 0x68
		private UICanvasScaleHelper _uiDecoCanvasScaleHelper; // 0x70
		private bool m_isInited; // 0x78
		private FOptions m_options; // 0x80
		private LatchUtils.InvokeWhenUnlock m_startLatch; // 0x88
		private LatchUtils.InvokeWhenUnlock m_initLatch; // 0x90
		private LoginWorkFlow.ENode m_lastNode; // 0x98
		private MaskCtrl m_maskCtrl; // 0xA0
		private LoginRootPanel m_rootPanel; // 0xA8
		private IEnumerator m_mockLoginRoutine; // 0xB0
		private Action<string> m_onMockLogin; // 0xB8
	
		// Properties
		public MaskCtrl maskCtrl { get => default; }
		public LoginRootPanel rootPanel { get => default; }
	
		// Events
		private event Action<string> m_onMockLogin;
	
		// Nested types
		public struct FOptions // TypeDefIndex: 53842
		{
			// Fields
			public LoginContext context; // 0x00
		}
	
		public abstract class Dialog : MonoBehaviour // TypeDefIndex: 53845
		{
			// Fields
			private UISwitchTween m_switchTween; // 0x18
			private LoginController m_controller; // 0x20
			public string showAudioEvent; // 0x28
			public string closeAudioEvent; // 0x30
	
			// Nested types
			private sealed class __CloseCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 53843
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public Dialog __4__this; // 0x20
				public Action callback; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185F89B10-0x0000000185F89B60 
				object IEnumerator.Current { get => default; } // 0x000000018420F490-0x000000018420F510 
	
				// Constructors
				public __CloseCoroutine_d__4() {} // Dummy constructor
				public __CloseCoroutine_d__4(int __1__state) {} // 0x0000000184B90070-0x0000000184B90110
	
				// Methods
				void IDisposable.Dispose() {} // 0x000000018349D730-0x000000018349D740
				private bool MoveNext() => default; // 0x0000000185F55560-0x0000000185F555D0
				void IEnumerator.Reset() {} // 0x0000000184B921D0-0x0000000184B92200
			}
	
			private sealed class _Create_d__8<TDialog> : IEnumerator<object> // TypeDefIndex: 53844
				where TDialog : Dialog
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public Beyond.Misc.ObjectRef outRef;
				public LoginController controller;
				public string resPath;
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; }
				object IEnumerator.Current { get => default; } // 0x0000000185EC4F00-0x0000000185EC4F70 
	
				// Constructors
				public _Create_d__8() {} // Dummy constructor
				public _Create_d__8(int __1__state) {} // 0x0000000184B91E40-0x0000000184B91FF0
	
				// Methods
				void IDisposable.Dispose() {} // 0x00000001844ED860-0x00000001844ED8B0
				private bool MoveNext() => default; // 0x0000000185C287B0-0x0000000185C28820
				void IEnumerator.Reset() {} // 0x0000000185EC4EB0-0x0000000185EC4F00
			}
	
			// Constructors
			protected Dialog() {} // 0x0000000185B9F9B0-0x0000000185B9FAE0
	
			// Methods
			private IEnumerator _CloseCoroutine(Action callback) => default; // 0x0000000184B926C0-0x0000000184B92760
			public bool TryCloseWithCallback(Action callback) => default; // 0x0000000185B40ED0-0x0000000185B40F60
			public void Show() {} // 0x0000000185B40F60-0x0000000185B40FF0
			protected virtual void OnInit() {} // 0x0000000185B40D40-0x0000000185B40E40
			public static IEnumerator Create<TDialog>(string resPath, LoginController controller, Beyond.Misc.ObjectRef outRef)
				where TDialog : Dialog => default; // 0x0000000185B40E40-0x0000000185B40ED0
		}
	
		public static class MaskConsts // TypeDefIndex: 53846
		{
			// Fields
			public const float DELAY_WAIT_NODE = 0.2f; // Metadata: 0x02078651
			public const string INIT = "init"; // Metadata: 0x02078655
			public const string U8_LOGIN = "u8_login"; // Metadata: 0x0207865A
			public const string FROM_GS_LOGIN = "from_gs_login"; // Metadata: 0x02078663
			public const string FROM_CREATE_ROLE = "from_create_role"; // Metadata: 0x02078671
			public const string NET_AGE_TIPS = "age_tips"; // Metadata: 0x02078682
		}
	
		public enum EMaskType // TypeDefIndex: 53847
		{
			None = 0,
			Black = 1,
			Blur = 2,
			White = 3
		}
	
		[Serializable]
		private class MaskCfg // TypeDefIndex: 53848
		{
			// Fields
			public CanvasGroup target; // 0x10
			public float showDuration; // 0x18
			public float hideDuration; // 0x1C
	
			// Constructors
			public MaskCfg() {} // 0x000000018791ED7C-0x000000018791EE24
	
			// Methods
			public UISwitchTween CreateTweenAndHide() => default; // 0x0000000185FAEBF0-0x0000000185FAEC00
		}
	
		public class MaskCtrl : IDisposable // TypeDefIndex: 53851
		{
			// Fields
			private static readonly int[] CROSS_SCENE_MASKS; // 0x00
			private ListDict<int, HashSet<string>> m_maskRefs; // 0x10
			private ListDict<int, UISwitchTween> m_maskTweens; // 0x18
			private ListDict<string, NetMaskRef> m_netMasks; // 0x20
	
			// Nested types
			private class NetMaskRef // TypeDefIndex: 53849
			{
				// Fields
				private string _key_k__BackingField; // 0x10
				public int maskId; // 0x18
				public bool isEnabled; // 0x1C
	
				// Properties
				public string key { get; private set; } // 0x000000018791EC38-0x000000018791ED7C 0x000000018791EB4C-0x000000018791EC38
	
				// Constructors
				public NetMaskRef() {} // Dummy constructor
				public NetMaskRef(string key) {} // 0x000000018791EB08-0x000000018791EB4C
			}
	
			private sealed class _WaitForCrossSceneMasks_d__10 : IEnumerator<object> // TypeDefIndex: 53850
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public MaskCtrl __4__this; // 0x20
				private int[] __7__wrap1; // 0x28
				private int __7__wrap2; // 0x30
				private UISwitchTween _mask_5__4; // 0x38
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
				object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
				// Constructors
				public _WaitForCrossSceneMasks_d__10() {} // Dummy constructor
				public _WaitForCrossSceneMasks_d__10(int __1__state) {}
	
				// Methods
				void IDisposable.Dispose() {} // 0x000000018646DB20-0x000000018646DB28
				private bool MoveNext() => default; // 0x0000000181378230-0x0000000181378240
				void IEnumerator.Reset() {} // 0x0000000187923890-0x000000018792395C
			}
	
			// Constructors
			public MaskCtrl() {} // Dummy constructor
			public MaskCtrl(LoginController controller) {} // 0x000000018792395C-0x00000001879239A8
			static MaskCtrl() {} // 0x0000000185FB6A50-0x0000000185FB6A60
	
			// Methods
			public void Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			public void EnableMask(string key, EMaskType type, bool enable, bool reset = false /* Metadata: 0x0207868F */) {}
			public bool IsMaskTweening(EMaskType type) => default;
			public bool IsCrossSceneMaskTweening() => default;
			public IEnumerator WaitForCrossSceneMasks() => default;
			public void EnableNetMask(string key, float timeoutSecs) {}
			public void DisableNetMask(string key) {}
			private UISwitchTween _GetMaskByType(int type) => default; // 0x0000000184B8C0A0-0x0000000184B8C140
		}
	
		private sealed class _BeforeDestroy_d__35 : IEnumerator<object> // TypeDefIndex: 53852
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184B8EAD0-0x0000000184B8EB20 
			object IEnumerator.Current { get => default; } // 0x0000000187922E08-0x0000000187922E98 
	
			// Constructors
			public _BeforeDestroy_d__35() {} // Dummy constructor
			public _BeforeDestroy_d__35(int __1__state) {} // 0x0000000184B8BEA0-0x0000000184B8C0A0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184B8F0A0-0x0000000184B8FB50
			private bool MoveNext() => default; // 0x0000000184B8EB20-0x0000000184B8ED00
			void IEnumerator.Reset() {} // 0x0000000184B8FBB0-0x0000000184B8FC80
		}
	
		private sealed class __InstantiateUIFromRes_d__36<T> : IEnumerator<object> // TypeDefIndex: 53853
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185F09F10-0x0000000185F09FA0 
			object IEnumerator.Current { get => default; } // 0x0000000184096E30-0x0000000184096EF0 
	
			// Constructors
			public __InstantiateUIFromRes_d__36() {} // Dummy constructor
			public __InstantiateUIFromRes_d__36(int __1__state) {} // 0x0000000187922C48-0x0000000187922E08
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187922B5C-0x0000000187922C48
			private bool MoveNext() => default; // 0x0000000184B8ED00-0x0000000184B8ED90
			void IEnumerator.Reset() {} // 0x000000018346D130-0x000000018346D140
		}
	
		private sealed class __InitCoroutine_d__38 : IEnumerator<object> // TypeDefIndex: 53854
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
			private LoginContext _context_5__2; // 0x28
			private Beyond.Misc.ObjectRef _panelRef_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018792371C-0x0000000187923844 
			object IEnumerator.Current { get => default; } // 0x0000000187923844-0x0000000187923890 
	
			// Constructors
			public __InitCoroutine_d__38() {} // Dummy constructor
			public __InitCoroutine_d__38(int __1__state) {} // 0x0000000184096E30-0x0000000184096EF0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181378230-0x0000000181378240
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 53855
		{
			// Fields
			public Beyond.Misc.ObjectRef objRef; // 0x10
	
			// Constructors
			public __c__DisplayClass45_0() {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			internal void __MockLoginCoroutine_b__0(string pUID) {} // 0x0000000181378230-0x0000000181378240
		}
	
		private sealed class __MockLoginCoroutine_d__45 : IEnumerator<object> // TypeDefIndex: 53856
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController __4__this; // 0x20
			private __c__DisplayClass45_0 __8__1; // 0x28
			public string fixedUID; // 0x30
			private LoginMockUIDPanel _nullablePanel_5__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187923324-0x0000000187923370 
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public __MockLoginCoroutine_d__45() {} // Dummy constructor
			public __MockLoginCoroutine_d__45(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184B8FCF0-0x0000000184B8FD80
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		public LoginController() {} // 0x0000000187923B70-0x0000000187923BBC
	
		// Methods
		protected void Awake() {}
		protected void Start() {}
		public float GetEnterGamePanelPredelay() => default;
		public void OnValueChanged(LoginViewModel viewModel) {} // 0x0000000181378230-0x0000000181378240
		public void InitUI(FOptions options) {} // 0x0000000185492010-0x0000000185492020
		public void InvokeWhenStart(Action callback) {} // 0x0000000184B918D0-0x0000000184B91B00
		public IEnumerator BeforeDestroy() => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _InstantiateUIFromRes<T>(string resPath, Transform parent, Beyond.Misc.ObjectRef objRef)
			where T : Component => default; // 0x0000000187923AD8-0x0000000187923B24
		private void _InitImpl() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _InitCoroutine() => default; // 0x0000000185492010-0x0000000185492020
		private void _InitVersionBtn() {} // 0x00000001846573E0-0x0000000184657410
		public void MockLoginWithCallback(string fixedUID, Action<string> callback) {} // 0x0000000184B92B40-0x0000000184B92F00
		private IEnumerator _MockLoginCoroutine(string fixedUID) => default; // 0x0000000181377E40-0x0000000181377E50
		private void _MockLoginWithCallback_b__44_0() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class LoginContext : IDisposable // TypeDefIndex: 53859
	{
		// Fields
		private LoginController m_controller; // 0x10
		private bool m_isDisposed; // 0x18
		private bool _quickStart_k__BackingField; // 0x19
		private bool _firstLogin_k__BackingField; // 0x1A
		private LoginWorkFlow _workflow_k__BackingField; // 0x20
		private LoginViewProperty _viewProp_k__BackingField; // 0x28
		private LoginManager.AssetLoader _loader_k__BackingField; // 0x30
		private LoginManager.FlowWithMaskMgr _flowWithMask_k__BackingField; // 0x38
		private NetUsagePolicy _netUsagePolicy_k__BackingField; // 0x40
		private LoginGameUpdater _gameUpdater_k__BackingField; // 0x48
		private bool _startConnectServer_k__BackingField; // 0x50
	
		// Properties
		public bool quickStart { get; private set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public bool firstLogin { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public LoginWorkFlow workflow { get; private set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public LoginViewProperty viewProp { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public LoginManager.AssetLoader loader { get; private set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public LoginManager.FlowWithMaskMgr flowWithMask { get; private set; } // 0x00000001813ECBE0-0x00000001813ECBF0 0x00000001813EE9A0-0x00000001813EE9B0
		public NetUsagePolicy netUsagePolicy { get; private set; } // 0x0000000184B8FFD0-0x0000000184B90000 0x00000001844ED390-0x00000001844ED470
		public LoginGameUpdater gameUpdater { get; private set; } // 0x00000001852590D0-0x0000000185259150 0x0000000187921BB0-0x0000000187921C2C
		public bool startConnectServer { get; set; } // 0x0000000187921A5C-0x0000000187921ADC 0x0000000185758B80-0x0000000185758CA0
	
		// Nested types
		private sealed class __DisposeCoroutine_d__48 : IEnumerator<object> // TypeDefIndex: 53858
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginController legacyController; // 0x20
			public Action disposeAction; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FB0740-0x0000000185FB0750 
			object IEnumerator.Current { get => default; } // 0x000000018646EE40-0x000000018646EE50 
	
			// Constructors
			public __DisposeCoroutine_d__48() {} // Dummy constructor
			public __DisposeCoroutine_d__48(int __1__state) {} // 0x0000000181A73E90-0x0000000181A73EA0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181A73EB0-0x0000000181A73EC0
			private bool MoveNext() => default; // 0x0000000185FB0730-0x0000000185FB0740
			void IEnumerator.Reset() {} // 0x00000001813B31A0-0x00000001813B31B0
		}
	
		// Constructors
		public LoginContext() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public LoginController ViewOnlyController() => default; // 0x0000000187921ADC-0x0000000187921BB0
		public void Init(bool quickStart, LoginController controller, LoginWorkFlow workflow, LoginViewProperty viewProp, LoginManager.AssetLoader loader, LoginManager.FlowWithMaskMgr flowWithMask, NetUsagePolicy netUsagePolicy, LoginGameUpdater gameUpdater) {} // 0x0000000187921A08-0x0000000187921A5C
		public void StartCoroutine(IEnumerator routine) {} // 0x00000001879219BC-0x0000000187921A08
		public void StopCoroutine(IEnumerator routine) {} // 0x00000001844ED470-0x00000001844ED4D0
		public void SendEvent(ELoginEvent evt, object param = null) {} // 0x0000000185758CA0-0x0000000185758D30
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
		public void ShutDown() {} // 0x0000000181378230-0x0000000181378240
		public bool IsWorkflowDisposed() => default; // 0x0000000185492010-0x0000000185492020
		public bool IsDisposed() => default; // 0x0000000185C286B0-0x0000000185C287B0
		private void _DisposeImpl() {} // 0x0000000181377E40-0x0000000181377E50
		private static IEnumerator _DisposeCoroutine(LoginController legacyController, Action disposeAction) => default; // 0x00000001879239A8-0x00000001879239F4
	}

	public enum ELoginEvent // TypeDefIndex: 53860
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

	public static class LoginTextDefines // TypeDefIndex: 53861
	{
		// Fields
		public const string CS_LOGIN_CONN_FAIL = "CS_LOGIN_CONN_FAIL"; // Metadata: 0x0207869E
		public const string HOTUPDATE_INDEX_FAILED = "HOTUPDATE_INDEX_FAILED"; // Metadata: 0x020786B1
		public const string HOTUPDATE_IO_FAILED = "HOTUPDATE_IO_FAILED"; // Metadata: 0x020786C8
		public const string HOTUPDATE_CHECK_VERSION = "HOTUPDATE_CHECK_VERSION"; // Metadata: 0x020786DC
		public const string HOTUPDATE_DOWNLOADING = "HOTUPDATE_DOWNLOADING"; // Metadata: 0x020786F4
		public const string HOTUPDATE_DECOMPRESSING = "HOTUPDATE_DECOMPRESSING"; // Metadata: 0x0207870A
		public const string HOTUPDATE_DOWNLOAD_ERROR = "HOTUPDATE_DOWNLOAD_ERROR"; // Metadata: 0x02078722
		public const string HOTUPDATE_DOWNLOAD_DISKFULL = "HOTUPDATE_DOWNLOAD_DISKFULL"; // Metadata: 0x0207873B
		public const string HOTUPDATE_LOCAL_RES_CHECK = "HOTUPDATE_LOCAL_RES_CHECK"; // Metadata: 0x02078757
		public const string HOTUPDATE_PRELOAD_RES = "HOTUPDATE_PRELOAD_RES"; // Metadata: 0x02078771
		public const string HOTUPDATE_INVALID_LOCAL_FILES = "HOTUPDATE_INVALID_LOCAL_FILES"; // Metadata: 0x02078787
		public const string HOTUPDATE_INIT_RES_CHANGED = "HOTUPDATE_INIT_RES_CHANGED"; // Metadata: 0x020787A5
		public const string HOTUPDATE_DOWNLOAD_IO_ERROR = "HOTUPDATE_DOWNLOAD_IO_ERROR"; // Metadata: 0x020787C0
		public const string HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR = "HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR"; // Metadata: 0x020787DC
		public const string HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR = "HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR"; // Metadata: 0x02078800
		public const string HOTUPDATE_DECOMPRESS_ERROR = "HOTUPDATE_DECOMPRESS_ERROR"; // Metadata: 0x02078828
		public const string REMOTE_CFG_GAME_CFG_ERROR = "REMOTE_CFG_GAME_CFG_ERROR"; // Metadata: 0x02078843
		public const string REMOTE_CFG_GAME_CFG_TIMEOUT = "REMOTE_CFG_GAME_CFG_TIMEOUT"; // Metadata: 0x0207885D
		public const string REMOTE_CFG_NETWORK_CFG_ERROR = "REMOTE_CFG_NETWORK_CFG_ERROR"; // Metadata: 0x02078879
		public const string REMOTE_CFG_NETWORK_CFG_TIMEOUT = "REMOTE_CFG_NETWORK_CFG_TIMEOUT"; // Metadata: 0x02078896
		public const string REMOTE_CFG_RES_VERSION_ERROR = "REMOTE_CFG_RES_VERSION_ERROR"; // Metadata: 0x020788B5
		public const string REMOTE_CFG_RES_VERSION_TIMEOUT = "REMOTE_CFG_RES_VERSION_TIMEOUT"; // Metadata: 0x020788D2
		public const string REMOTE_CFG_GAME_VERSION_ERROR = "REMOTE_CFG_GAME_VERSION_ERROR"; // Metadata: 0x020788F1
		public const string REMOTE_CFG_GAME_VERSION_TIMEOUT = "REMOTE_CFG_GAME_VERSION_TIMEOUT"; // Metadata: 0x0207890F
		public const string LOGIN_JUDGE_EXIT_GAME = "LOGIN_JUDGE_EXIT_GAME"; // Metadata: 0x0207892F
		public const string LOGIN_JUDGE_LOGOUT = "LOGIN_JUDGE_LOGOUT"; // Metadata: 0x02078945
		public const string LOGIN_JUDGE_RES_REPAIR = "LOGIN_JUDGE_RES_REPAIR"; // Metadata: 0x02078958
		public const string LOGIN_AGE_TIPS_FAILED = "LOGIN_AGE_TIPS_FAILED"; // Metadata: 0x0207896F
		public const string LOGIN_TXT_DIALOG_CONFIRM = "LOGIN_TXT_DIALOG_CONFIRM"; // Metadata: 0x02078985
		public const string LOGIN_TXT_DIALOG_CANCEL = "LOGIN_TXT_DIALOG_CANCEL"; // Metadata: 0x0207899E
		public const string LOGIN_AUDIO_LANG_CN = "UI_LOGIN_ROOT_VOICE_CN"; // Metadata: 0x020789B6
		public const string LOGIN_AUDIO_LANG_JP = "UI_LOGIN_ROOT_VOICE_JP"; // Metadata: 0x020789CD
		public const string LOGIN_AUDIO_LANG_EN = "UI_LOGIN_ROOT_VOICE_EN"; // Metadata: 0x020789E4
		public const string LOGIN_AUDIO_LANG_KR = "UI_LOGIN_ROOT_VOICE_KR"; // Metadata: 0x020789FB
		public const string LOGIN_TXT_NETWORK_ERROR = "LOGIN_TXT_NETWORK_ERROR"; // Metadata: 0x02078A12
		public const string LOGIN_GAME_UPGRADED = "LOGIN_GAME_UPGRADED"; // Metadata: 0x02078A2A
		public const string LOGIN_TXT_SERVER_CLOSED = "LOGIN_TXT_SERVER_CLOSED"; // Metadata: 0x02078A3E
		public const string LOGIN_TXT_SERVER_CLOSED_DATETIME = "LOGIN_TXT_SERVER_CLOSED_DATETIME"; // Metadata: 0x02078A56
		public const string LOGIN_TXT_USR_BAN_DATETIME = "LOGIN_TXT_USR_BAN_DATETIME"; // Metadata: 0x02078A77
		public const string LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER = "LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER"; // Metadata: 0x02078A92
		public const string LOGIN_GET_SERVER_LIST_FAILED = "LOGIN_GET_SERVER_LIST_FAILED"; // Metadata: 0x02078ABC
		public const string LOGIN_TEXT_SERVER_ZONE_FAILED = "LOGIN_TEXT_SERVER_ZONE_FAILED"; // Metadata: 0x02078AD9
		public const string LOGIN_TEXT_GET_APP_VERSION_FAILED = "LOGIN_TEXT_GET_APP_VERSION_FAILED"; // Metadata: 0x02078AF7
		public const string LOGIN_TEXT_ALERT_CARRIER_NETWORK = "LOGIN_TEXT_ALERT_CARRIER_NETWORK"; // Metadata: 0x02078B19
		public const string LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED = "LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED"; // Metadata: 0x02078B3A
		public const string LOGIN_SHADER_WARM_UP_PRELOAD_RES = "LOGIN_SHADER_WARM_UP_PRELOAD_RES"; // Metadata: 0x02078B69
		public const string LOGIN_GAME_UPDATE_TIPS_DOWNLOADING = "LOGIN_GAME_UPDATE_TIPS_DOWNLOADING"; // Metadata: 0x02078B8A
		public const string LOGIN_GAME_UPDATE_TIPS_PAUSE = "LOGIN_GAME_UPDATE_TIPS_PAUSE"; // Metadata: 0x02078BAD
		public const string LOGIN_GAME_UPDATE_ALERT_NEWER = "LOGIN_GAME_UPDATE_ALERT_NEWER"; // Metadata: 0x02078BCA
		public const string LOGIN_GAME_UPDATE_ERROR_DISK_FULL = "LOGIN_GAME_UPDATE_ERROR_DISK_FULL"; // Metadata: 0x02078BE8
		public const string LOGIN_GAME_UPDATE_ALERT_SUC = "LOGIN_GAME_UPDATE_ALERT_SUC"; // Metadata: 0x02078C0A
		public const string LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON = "LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON"; // Metadata: 0x02078C26
		public const string LOGIN_GAME_UPDATE_ERROR_COMMON = "LOGIN_GAME_UPDATE_ERROR_COMMON"; // Metadata: 0x02078C56
		public const string LOGIN_GAME_UPDATE_TITLE = "LOGIN_GAME_UPDATE_TITLE"; // Metadata: 0x02078C75
		public const string LOGIN_GOTO_SHOP_FOR_GAME_UPDATE = "LOGIN_GOTO_SHOP_FOR_GAME_UPDATE"; // Metadata: 0x02078C8D
		public const string LOGIN_SDK_INIT_FAILED = "LOGIN_SDK_INIT_FAILED"; // Metadata: 0x02078CAD
		public const string LOGIN_DOWNLOADING_SPEED_HINT = "LOGIN_DOWNLOADING_SPEED_HINT"; // Metadata: 0x02078CC3
		public const string LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME = "LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME"; // Metadata: 0x02078CE0
		public const string LOGIN_NETWORK_CONGESTION_TITLE = "LOGIN_NETWORK_CONGESTION_TITLE"; // Metadata: 0x02078D05
		public const string LOGIN_LOW_SCORE_DEVICE_TIP = "LOGIN_LOW_SCORE_DEVICE_TIP"; // Metadata: 0x02078D24
		public const string LOGIN_REGISTRY_WRITE_FAILED = "LOGIN_REGISTRY_WRITE_FAILED"; // Metadata: 0x02078D3F
	}

	public class LoginManager : ExplicitSingleton<LoginManager> // TypeDefIndex: 53880
	{
		// Fields
		public const long MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI = 104857600; // Metadata: 0x02078D5B
		private ISceneHandle m_sceneHandle; // 0x10
		private LoginContext m_context; // 0x18
		private LatchUtils.InvokeWhenUnlock m_workflowFinishLatch; // 0x20
		private LatchUtils.InvokeWhenUnlock m_workflowStartLatch; // 0x28
		private Queue<WeakReference<LoginSceneComponent>> m_pendingSceneComps; // 0x30
		private HashSet<LoginSceneComponent> m_sceneComps; // 0x38
		private bool _quickStart_k__BackingField; // 0x40
		private object m_dialogBlocker; // 0x48
	
		// Properties
		public bool quickStart { get; private set; } // 0x0000000185492010-0x0000000185492020 0x0000000187923180-0x00000001879232D8
		public bool firstLogin { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		public class AssetLoader : IDisposable // TypeDefIndex: 53862
		{
			// Fields
			private Dictionary<string, FAssetProxyHandle> m_assetHandles; // 0x10
	
			// Constructors
			public AssetLoader() {} // 0x000000018792228C-0x00000001879223A4
	
			// Methods
			public FAssetProxyHandle CachedLoad<T>(string path)
				where T : UnityEngine.Object => default; // 0x0000000185FB0650-0x0000000185FB0660
			public FAssetProxyHandle CachedLoadAsync<T>(string path)
				where T : UnityEngine.Object => default; // 0x0000000185FB0660-0x0000000185FB0670
			private bool _CheckDisposedBeforeLoad(string path) => default; // 0x0000000187922B4C-0x0000000187922B5C
			public void Dispose() {} // 0x0000000185F1C520-0x0000000185F1C5A0
		}
	
		public class FlowWithMaskMgr // TypeDefIndex: 53864
		{
			// Fields
			private LoginContext m_context; // 0x10
			private HashSet<string> m_activeFlows; // 0x18
	
			// Nested types
			private sealed class __FlowCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 53863
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public FlowWithMaskMgr __4__this; // 0x20
				public FFlowWithMask flow; // 0x28
				private LoginController.MaskCtrl _maskCtrl_5__2; // 0x50
				private bool _isFlowSuc_5__3; // 0x58
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185757F00-0x0000000185757F40 
				object IEnumerator.Current { get => default; } // 0x0000000185D7A030-0x0000000185D7A080 
	
				// Constructors
				public __FlowCoroutine_d__4() {} // Dummy constructor
				public __FlowCoroutine_d__4(int __1__state) {} // 0x0000000186474D94-0x0000000186474E20
	
				// Methods
				void IDisposable.Dispose() {} // 0x0000000185FA2840-0x0000000185FA2870
				private bool MoveNext() => default; // 0x0000000187921FA4-0x0000000187922004
				void IEnumerator.Reset() {} // 0x0000000185758830-0x0000000185758910
			}
	
			// Constructors
			public FlowWithMaskMgr() {} // Dummy constructor
			public FlowWithMaskMgr(LoginContext context) {} // 0x000000018425F550-0x000000018425F680
	
			// Methods
			public void StartFlow(FFlowWithMask flow) {} // 0x0000000184B8FE20-0x0000000184B8FFD0
			private IEnumerator _FlowCoroutine(FFlowWithMask flow) => default; // 0x0000000187922690-0x0000000187922754
			private void _OnFlowFinished(FFlowWithMask flow) {} // 0x0000000187921DBC-0x0000000187921FA4
		}
	
		public struct FFlowWithMask // TypeDefIndex: 53865
		{
			// Fields
			public string key; // 0x00
			public LoginController.EMaskType maskType; // 0x08
			public Func<bool> flowAction; // 0x10
			public FFlowCondition condition; // 0x18
			public float disableDelay; // 0x20
		}
	
		public struct FFlowCondition // TypeDefIndex: 53866
		{
			// Fields
			private LoginWorkFlow.ENode _priTarget_k__BackingField; // 0x00
			private LoginWorkFlow.ENode _secTarget_k__BackingField; // 0x04
	
			// Properties
			public LoginWorkFlow.ENode priTarget { get; private set; } // 0x00000001879227E4-0x0000000187922984 0x0000000187922754-0x00000001879227E4
			public LoginWorkFlow.ENode secTarget { get; private set; } // 0x0000000187921CD4-0x0000000187921DBC 0x0000000187921C2C-0x0000000187921CD4
	
			// Constructors
			public FFlowCondition(LoginWorkFlow.ENode target) : this() {
				<priTarget>k__BackingField = default;
				<secTarget>k__BackingField = default;
			} // 0x0000000187922440-0x0000000187922530
			public FFlowCondition(LoginWorkFlow.ENode first, LoginWorkFlow.ENode second) : this() {
				<priTarget>k__BackingField = default;
				<secTarget>k__BackingField = default;
			} // 0x00000001879223A4-0x0000000187922440
	
			// Methods
			public bool IsTargetMatch(LoginWorkFlow.ENode node) => default; // 0x0000000187922984-0x0000000187922B4C
		}
	
		private sealed class _InitCoroutine_d__17 : IEnumerator<object> // TypeDefIndex: 53867
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public bool quickStart; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001844ED8E0-0x00000001844EDEC0 
			object IEnumerator.Current { get => default; } // 0x00000001844ED600-0x00000001844ED680 
	
			// Constructors
			public _InitCoroutine_d__17() {} // Dummy constructor
			public _InitCoroutine_d__17(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184B91810-0x0000000184B918D0
			private bool MoveNext() => default; // 0x0000000187922530-0x0000000187922690
			void IEnumerator.Reset() {} // 0x000000018425F440-0x000000018425F4C0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53868
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<LoginAlertDialog, LoginAlertDialog.FParams> __9__29_0; // 0x08
			public static Action<LoginVocResSelDialog, LoginVocResSelDialog.FParams> __9__30_0; // 0x10
			public static Action<LoginJudgeDialog, LoginJudgeDialog.FParams> __9__36_0; // 0x18
	
			// Constructors
			static __c() {} // 0x0000000185EBB870-0x0000000185EBB900
			public __c() {} // 0x0000000185757F40-0x0000000185758010
	
			// Methods
			internal void _AlertDialog_b__29_0(LoginAlertDialog param1, LoginAlertDialog.FParams param2) {} // 0x0000000185048210-0x00000001850482D0
			internal void _VocResSelDialog_b__30_0(LoginVocResSelDialog param1, LoginVocResSelDialog.FParams param2) {} // 0x00000001855EDB30-0x00000001855EDBC0
			internal void __StartShowJudgeDialogCoroutine_b__36_0(LoginJudgeDialog param1, LoginJudgeDialog.FParams param2) {} // 0x0000000187922004-0x0000000187922084
		}
	
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 53869
		{
			// Fields
			public object wait; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0() {} // 0x0000000187922084-0x000000018792228C
	
			// Methods
			internal void _VocResSelDialogWithConfirm_b__0() {} // 0x0000000185CA7320-0x0000000185CA7460
		}
	
		private sealed class _VocResSelDialogWithConfirm_d__31 : IEnumerator<object> // TypeDefIndex: 53870
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			private __c__DisplayClass31_0 __8__1; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001844EC9A0-0x00000001844ECD40 
			object IEnumerator.Current { get => default; } // 0x00000001844ED570-0x00000001844ED600 
	
			// Constructors
			public _VocResSelDialogWithConfirm_d__31() {} // Dummy constructor
			public _VocResSelDialogWithConfirm_d__31(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default; // 0x0000000184EC9EE0-0x0000000184EC9F50
			void IEnumerator.Reset() {} // 0x00000001844ED700-0x00000001844ED780
		}
	
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 53871
		{
			// Fields
			public Beyond.Misc.ObjectRef outRef; // 0x10
			public Action<Beyond.Misc.ObjectRef> callback; // 0x18
	
			// Constructors
			public __c__DisplayClass32_0() {} // 0x00000001852573C0-0x0000000185257500
	
			// Methods
			internal void _AlertDialogWithResult_b__0() {} // 0x0000000185257500-0x00000001852575B0
		}
	
		private sealed class _AlertDialogWithResult_d__32 : IEnumerator<object> // TypeDefIndex: 53872
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Beyond.Misc.ObjectRef outRef; // 0x20
			public Action<Beyond.Misc.ObjectRef> callback; // 0x28
			public LoginManager __4__this; // 0x30
			public string desc; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184B8ED90-0x0000000184B8EF90 
			object IEnumerator.Current { get => default; } // 0x0000000187923A8C-0x0000000187923AD8 
	
			// Constructors
			public _AlertDialogWithResult_d__32() {} // Dummy constructor
			public _AlertDialogWithResult_d__32(int __1__state) {} // 0x000000018791EE24-0x000000018791EEDC
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181378230-0x0000000181378240
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 53873
		{
			// Fields
			public object wait; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			internal void _AlertDialogWithConfirm_b__0() {} // 0x00000001818226B0-0x00000001818226C0
		}
	
		private sealed class _AlertDialogWithConfirm_d__33 : IEnumerator<object> // TypeDefIndex: 53874
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public string desc; // 0x28
			private __c__DisplayClass33_0 __8__1; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FB69F0-0x0000000185FB6A00 
			object IEnumerator.Current { get => default; } // 0x0000000184B8FB50-0x0000000184B8FBB0 
	
			// Constructors
			public _AlertDialogWithConfirm_d__33() {} // Dummy constructor
			public _AlertDialogWithConfirm_d__33(int __1__state) {} // 0x00000001818AA390-0x00000001818AA3A0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018357CBC0-0x000000018357CBD0
			private bool MoveNext() => default; // 0x0000000185FB2BA0-0x0000000185FB2BB0
			void IEnumerator.Reset() {} // 0x000000018357CB90-0x000000018357CBA0
		}
	
		private sealed class __ShowDialogCoroutine_d__37<TDialog, TParam> : IEnumerator<object> // TypeDefIndex: 53875
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __ShowDialogCoroutine_d__37() {} // Dummy constructor
			public __ShowDialogCoroutine_d__37(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x00000001844EC940-0x00000001844EC9A0
			void IEnumerator.Reset() {} // 0x00000001879233BC-0x0000000187923408
		}
	
		private sealed class __c__DisplayClass39_0 // TypeDefIndex: 53876
		{
			// Fields
			public Action callback; // 0x10
	
			// Constructors
			public __c__DisplayClass39_0() {} // 0x0000000187923530-0x0000000187923594
	
			// Methods
			internal void _MockManualSelectServer_b__0(string _) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass40_0 // TypeDefIndex: 53877
		{
			// Fields
			public LoginController controller; // 0x10
			public LoginManager __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass40_0() {} // 0x0000000187923454-0x0000000187923484
	
			// Methods
			internal void __Init_b__0() {} // 0x0000000187923484-0x00000001879234AC
		}
	
		private sealed class __LoginWorkFlowCoroutine_d__43 : IEnumerator<object> // TypeDefIndex: 53878
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginManager __4__this; // 0x20
			public LoginController nullableCtrl; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x0000000187923594-0x00000001879236D0 
	
			// Constructors
			public __LoginWorkFlowCoroutine_d__43() {} // Dummy constructor
			public __LoginWorkFlowCoroutine_d__43(int __1__state) {} // 0x00000001879234AC-0x00000001879234F0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185633D30-0x0000000185633D50
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class _FetchRemoteConfigUtilSuc_d__45 : IEnumerator<object> // TypeDefIndex: 53879
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public IRemoteConfig config; // 0x20
			public string configEnv; // 0x28
			public string keyErrorWithCode; // 0x30
			public string keyTimeout; // 0x38
			private FRemoteConfigRequest _request_5__2; // 0x40
			private bool _isServiceSuc_5__3; // 0x68
			private Beyond.Misc.ObjectRef _resultRef_5__4; // 0x70
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public _FetchRemoteConfigUtilSuc_d__45() {} // Dummy constructor
			public _FetchRemoteConfigUtilSuc_d__45(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001879236D0-0x000000018792371C
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x00000001879234F0-0x0000000187923530
		}
	
		// Constructors
		public LoginManager() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public IEnumerator InitCoroutine(bool quickStart) => default; // 0x00000001879232D8-0x0000000187923324
		public bool IsReLoginInProgress() => default; // 0x0000000181377E40-0x0000000181377E50
		public static void OnReleaseMainGame() {} // 0x0000000185492010-0x0000000185492020
		public bool IsWorkflowInProgress() => default; // 0x0000000185633D30-0x0000000185633D50
		public void ClearSync() {} // 0x0000000181378230-0x0000000181378240
		public void Clear() {} // 0x0000000185492010-0x0000000185492020
		private void _ReleaseLoginScene() {} // 0x0000000187922FE4-0x0000000187923134
		public void InvokeWhenWorkFlowFinished(Action callback) {} // 0x0000000181377E40-0x0000000181377E50
		public void SceneComponentOnly_Bind(LoginSceneComponent comp) {} // 0x0000000187923134-0x0000000187923180
		private void _BindPendingComponents() {} // 0x0000000181377E40-0x0000000181377E50
		public void ToggleLoginBindingGroup(bool enable) {}
		public void AlertDialog(string desc, Action callback = null) {}
		public void VocResSelDialog(Action callback = null) {}
		public IEnumerator VocResSelDialogWithConfirm() => default;
		public IEnumerator AlertDialogWithResult(string desc, Beyond.Misc.ObjectRef outRef, Action<Beyond.Misc.ObjectRef> callback = null) => default;
		public IEnumerator AlertDialogWithConfirm(string desc) => default;
		public void JudgeDialog(string desc, Action onPositive, Action onNegative) {} // 0x0000000185492010-0x0000000185492020
		public void JudgeDialog(LoginJudgeDialog.FParams param) {} // 0x00000001830EEE80-0x00000001830EEE90
		private void _StartShowJudgeDialogCoroutine(LoginJudgeDialog.FParams param) {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator _ShowDialogCoroutine<TDialog, TParam>(string resPath, TParam param, Action<TDialog, TParam> setParamFunc)
			where TDialog : LoginController.Dialog => default; // 0x0000000185EBB830-0x0000000185EBB870
		public void MockLoginWithCallback(Action<string> callback) {} // 0x0000000181378230-0x0000000181378240
		public void MockManualSelectServer(string uid, Action callback) {} // 0x0000000185492010-0x0000000185492020
		private void _Init() {} // 0x000000018425F900-0x000000018425FA30
		public bool IsLoginSceneLoading() => default; // 0x0000000181377E40-0x0000000181377E50
		private void _PrepareBeforeLoginProcess() {} // 0x0000000187923B24-0x0000000187923B70
		private IEnumerator _LoginWorkFlowCoroutine(LoginController nullableCtrl) => default; // 0x0000000181377E40-0x0000000181377E50
		private void _ClearWorkflowAndContext(bool isShutDownMode) {} // 0x0000000181378230-0x0000000181378240
		public static IEnumerator FetchRemoteConfigUtilSuc(IRemoteConfig config, string configEnv, string keyErrorWithCode, string keyTimeout) => default; // 0x0000000185492010-0x0000000185492020
		private static string _ExtractErrorInfo(HttpSender.Result result, string keyErrorWithCode, string keyTimeout) => default; // 0x00000001855EDC20-0x00000001855EFFA0
		public static void DevOnlyCheckEnableLocalResMode(ref bool enable) {} // 0x0000000181377E40-0x0000000181377E50
		public static void DevOnlyUseLocalResVersion(ResVersionDevCfg config, ref bool useLocalResVersion) {} // 0x0000000187923370-0x00000001879233BC
	}

	public class VietnamLoginAgePanel : MonoBehaviour // TypeDefIndex: 53881
	{
		// Fields
		private const string PREFAB_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/AgeTipsPanel.prefab"; // Metadata: 0x02078D63
		private static FAssetProxyHandle s_prefabAssetHandle; // 0x00
		public static GameObject instance; // 0x18
	
		// Constructors
		public VietnamLoginAgePanel() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public static void Init() {} // 0x0000000184B92430-0x0000000184B92490
		public static void UnInit() {} // 0x00000001879245BC-0x0000000187924634
		private static void _Init() {} // 0x0000000187924634-0x00000001879248BC
		private static void _UnInit() {} // 0x00000001879248BC-0x0000000187924990
		private void OnApplicationQuit() {} // 0x00000001879244D0-0x00000001879245BC
	}

	public class VietnamLoginAgeTipsPanelCtrl : MonoBehaviour // TypeDefIndex: 53882
	{
		// Fields
		private UIDrag _UIDrag; // 0x18
		private UIButton _tipsBtn; // 0x20
		private UIButton _circleBtn; // 0x28
		private UIStateController _stateController; // 0x30
	
		// Constructors
		public VietnamLoginAgeTipsPanelCtrl() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Awake() {} // 0x0000000187924990-0x0000000187924BCC
		private void _SetStateTips(PointerEventData eventData) {} // 0x0000000187924C68-0x0000000187924D04
		private void _SetStateCircle(PointerEventData eventData) {} // 0x0000000187924BCC-0x0000000187924C68
	}

	public static class RenderPipelineDataLoader // TypeDefIndex: 53883
	{
		// Fields
		public static FAssetProxyHandle s_globalSettings; // 0x00
		public static FAssetProxyHandle s_pipelineAsset; // 0x14
	
		// Methods
		public static void LoadSimpleRpData() {} // 0x00000001840164B0-0x00000001840165D0
		public static void PreloadFullRpResources() {} // 0x0000000184B2CE40-0x0000000184B2CFF0
		public static bool IsPreLoadFinished() => default; // 0x00000001852D5A10-0x00000001852D5AD0
		public static void LoadFullRpResources() {} // 0x0000000184016680-0x00000001840167F0
	}

	public class TailGameLoop : MonoBehaviour // TypeDefIndex: 53884
	{
		// Constructors
		public TailGameLoop() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Update() {} // 0x0000000184DCCAD0-0x0000000184DCCB80
		private void LateUpdate() {} // 0x000000018442C130-0x000000018442C1E0
	}
}

namespace Beyond.Login
{
	public class LoginCheckForUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 53926
	{
		// Fields
		private LoginGameUpdater m_sdk; // 0x20
		private bool m_checkSuccess; // 0x28
		private const string REQUEST_API = "/api/game/get_latest"; // Metadata: 0x02078EEB
		private const string REQUEST_PARAM_FORMAT = "appcode={0}&channel={1}&version={2}&platform={3}&sub_channel={4}&source={5}"; // Metadata: 0x02078F00
		private const string REQUEST_URL_FORMAT = "{0}{1}?{2}"; // Metadata: 0x02078F4D
		private const string PRAM_SOURCE = "game"; // Metadata: 0x02078F58
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000185AD4F40-0x0000000185AD6E90 
	
		// Nested types
		private class AppVersionRespone // TypeDefIndex: 53919
		{
			// Fields
			public int action; // 0x10
			public int state; // 0x14
	
			// Constructors
			public AppVersionRespone() {} // 0x0000000181B87DE0-0x0000000181B87DF0
		}
	
		private sealed class __CheckForUpdateCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 53920
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187925FCC-0x000000018792605C 
			object IEnumerator.Current { get => default; } // 0x0000000185D53710-0x0000000185D53780 
	
			// Constructors
			public __CheckForUpdateCoroutine_d__4() {} // Dummy constructor
			public __CheckForUpdateCoroutine_d__4(int __1__state) {} // 0x0000000185259370-0x0000000185259470
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185259470-0x00000001852594E0
			private bool MoveNext() => default; // 0x0000000185F61680-0x0000000185F616E0
			void IEnumerator.Reset() {} // 0x0000000185F4C500-0x0000000185F4C570
		}
	
		private sealed class _AlertNoMatchDeviceBeforeLogin_d__5 : IEnumerator<object> // TypeDefIndex: 53921
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _AlertNoMatchDeviceBeforeLogin_d__5() {} // Dummy constructor
			public _AlertNoMatchDeviceBeforeLogin_d__5(int __1__state) {} // 0x0000000185AD6E90-0x0000000185AD6F20
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184260280-0x0000000184260490
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		private sealed class __CheckForUpdateCoroutineMobile_d__6 : IEnumerator<object> // TypeDefIndex: 53922
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			private LoginGameUpdater.Result _result_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __CheckForUpdateCoroutineMobile_d__6() {} // Dummy constructor
			public __CheckForUpdateCoroutineMobile_d__6(int __1__state) {} // 0x000000018425F130-0x000000018425F440
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018792AEF0-0x000000018792AF3C
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		private sealed class __CheckForUpdateCoroutinePC_d__8 : IEnumerator<object> // TypeDefIndex: 53923
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __CheckForUpdateCoroutinePC_d__8() {} // Dummy constructor
			public __CheckForUpdateCoroutinePC_d__8(int __1__state) {} // 0x0000000185D630C0-0x0000000185D63170
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x0000000187929D50-0x0000000187929D9C
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		private sealed class __CheckForUpdatePC_d__9 : IEnumerator<object> // TypeDefIndex: 53924
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			private Beyond.Misc.ObjectRef _actionRef_5__2; // 0x28
			private string _errorInfo_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __CheckForUpdatePC_d__9() {} // Dummy constructor
			public __CheckForUpdatePC_d__9(int __1__state) {} // 0x000000018792AC0C-0x000000018792AE58
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018792AE58-0x000000018792AEA4
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		private sealed class __GetOnlineAppVersion_d__11 : IEnumerator<object> // TypeDefIndex: 53925
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginCheckForUpdateNode __4__this; // 0x20
			public Beyond.Misc.ObjectRef outRef; // 0x28
			private string _url_5__2; // 0x30
			private WaitForAsyncTask<HttpSender.Result<AppVersionRespone>> _httpResIndex_5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __GetOnlineAppVersion_d__11() {} // Dummy constructor
			public __GetOnlineAppVersion_d__11(int __1__state) {} // 0x0000000185D536A0-0x0000000185D53710
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018792AEA4-0x000000018792AEF0
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public LoginCheckForUpdateNode() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _CheckForUpdateCoroutine() => default; // 0x000000018792AF3C-0x000000018792AF88
		public static IEnumerator AlertNoMatchDeviceBeforeLogin() => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _CheckForUpdateCoroutineMobile() => default; // 0x0000000181378230-0x0000000181378240
		private IEnumerator _CheckForUpdateCoroutinePC() => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerator _CheckForUpdatePC() => default; // 0x00000001855ECC40-0x00000001855ECF00
		private IEnumerator _GetOnlineAppVersion(Beyond.Misc.ObjectRef outRef) => default; // 0x0000000181377E40-0x0000000181377E50
		private string _GetRequestPram() => default; // 0x000000018792C02C-0x000000018792C078
	}

	public class LoginCreateRoleNode : LoginWorkFlow.Node // TypeDefIndex: 53928
	{
		// Fields
		public const string LUA_SYS_NAME = "LeadingCharacter"; // Metadata: 0x02078F5D
		private WorkProcess m_activeProcess; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000185EEA4B0-0x0000000185EEA550 
	
		// Nested types
		private class WorkProcess : CustomYieldInstruction, IDisposable // TypeDefIndex: 53927
		{
			// Fields
			private LoginCreateRoleNode m_closure; // 0x10
			private bool m_isFinished; // 0x18
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x00000001858C7D40-0x00000001858C7D90 
	
			// Constructors
			public WorkProcess() {} // Dummy constructor
			public WorkProcess(LoginCreateRoleNode closure) {} // 0x0000000181B75290-0x0000000181B752A0
	
			// Methods
			public void Dispose() {} // 0x000000018792605C-0x00000001879260A8
		}
	
		// Constructors
		public LoginCreateRoleNode() {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void OnDispose() {} // 0x0000000185492010-0x0000000185492020
		public override bool CanCancel() => default; // 0x00000001879260B0-0x00000001879260B8
		public override CustomYieldInstruction Work() => default; // 0x00000001879260A8-0x00000001879260B0
		public void __iFixBaseProxy_OnDispose() {} // 0x0000000185F61D60-0x0000000185F61D70
		public bool __iFixBaseProxy_CanCancel() => default; // 0x000000018792EA34-0x000000018792EAA8
	}

	public class LoginDownloadTask : IDisposable // TypeDefIndex: 53931
	{
		// Fields
		private bool m_isDownloadFinished; // 0x10
		private HGDownloader.TaskHandler m_downloadTask; // 0x18
		private FResourceDiff m_resDiff; // 0x20
		private LocalResPref m_localResPref; // 0x60
		private string m_patchInfo; // 0x68
		private IEnumerator m_mockCoroutine; // 0x70
		private bool m_isInitial; // 0x78
		private string _vitalError_k__BackingField; // 0x80
		private NetUsagePolicy m_netUsagePolicy; // 0x88
	
		// Properties
		public string vitalError { get; private set; } // 0x00000001879262A0-0x000000018792630C 0x00000001879260B8-0x0000000187926144
	
		// Nested types
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 53929
		{
			// Fields
			public LoginDownloadTask __4__this; // 0x10
			public HGDownloader.PauseReason reason; // 0x18
	
			// Constructors
			public __c__DisplayClass24_0() {} // 0x000000018184CC00-0x000000018184CD90
	
			// Methods
			internal void __OnDownloadPaused_b__1() {} // 0x000000018140CF50-0x000000018140CF60
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53930
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__24_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001873CBE98-0x00000001873CBEA8
			public __c() {} // 0x00000001879261A8-0x0000000187926240
	
			// Methods
			internal void __OnDownloadPaused_b__24_0() {} // 0x0000000187926144-0x00000001879261A8
		}
	
		// Constructors
		public LoginDownloadTask() {} // Dummy constructor
		public LoginDownloadTask(FResourceDiff resDiff, LocalResPref localResPref, string patchInfo, bool isInitial, NetUsagePolicy netUsagePolicy) {} // 0x0000000187926240-0x00000001879262A0
	
		// Methods
		public HGDownloader.DownloadProgress GetDownloadProgress() => default; // 0x0000000187926EF0-0x00000001879271F0
		public float GetDecompressProgress() => default; // 0x0000000187926A1C-0x0000000187926EF0
		public HGDownloader.WorkState GetWorkState() => default; // 0x000000018184AA30-0x000000018184CC00
		public bool Tick() => default; // 0x000000018792630C-0x000000018792654C
		public void Dispose() {} // 0x0000000187926768-0x00000001879267B8
		private void _StartDownload() {} // 0x000000018792654C-0x0000000187926768
		private void _StartDownloadImpl() {} // 0x00000001879267B8-0x0000000187926A1C
		private List<HGFolder> _GetAllFileList(LocalResPref localResPref) => default; // 0x0000000185492010-0x0000000185492020
		private List<HGFileInfo> _GetFileList(string rootUrl) => default; // 0x0000000181850B70-0x0000000181850EB0
		private void _OnDownloadFinish() {} // 0x000000018792AB10-0x000000018792AB74
		private bool _OnDownloadError(HGRetCodeType codeType, int errorCode) => default; // 0x0000000185492010-0x0000000185492020
		private void _OnDownloadPaused(HGDownloader.PauseReason reason) {} // 0x000000018184FBE0-0x0000000181850B70
	}

	public class LoginGameSettingInitializer : MonoBehaviour // TypeDefIndex: 53932
	{
		// Fields
		private static bool s_isInitialized; // 0x00
		private RectTransform m_rectTransform; // 0x18
		private UICanvasScaleHelper m_canvasScaleHelper; // 0x20
	
		// Constructors
		public LoginGameSettingInitializer() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x0000000185B57810-0x0000000185B57870
		private void OnEnable() {} // 0x0000000185B57870-0x0000000185B578F0
		private void _TryInitializeComponents() {} // 0x0000000185B57970-0x0000000185B57A60
		private void _InitGameSettingStateInLogin() {} // 0x0000000185B578F0-0x0000000185B57970
		private void _InitGameSettingNotchPadding() {} // 0x000000018570F7F0-0x0000000185712230
	}

	public class LoginGameUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 53935
	{
		// Fields
		private LoginGameUpdater m_sdk; // 0x20
		private NetUsagePolicy m_netUsagePolicy; // 0x28
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class __GameUpdateCoroutine_d__5 : IEnumerator<object> // TypeDefIndex: 53933
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187927958-0x00000001879279E8 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public __GameUpdateCoroutine_d__5() {} // Dummy constructor
			public __GameUpdateCoroutine_d__5(int __1__state) {} // 0x0000000181D1CE70-0x0000000181D1CE80
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185259A00-0x0000000185259B10
			private bool MoveNext() => default; // 0x0000000185259B10-0x0000000185259B70
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __GameUpdateCoroutineMobileImpl_d__6 : IEnumerator<object> // TypeDefIndex: 53934
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdateNode __4__this; // 0x20
			private LoginGameUpdater.Result _result_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018792B7C0-0x000000018792B80C 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public __GameUpdateCoroutineMobileImpl_d__6() {} // Dummy constructor
			public __GameUpdateCoroutineMobileImpl_d__6(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FADBE0-0x0000000185FADBF0
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		public LoginGameUpdateNode() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x000000018792B598-0x000000018792B774
		private IEnumerator _GameUpdateCoroutine() => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _GameUpdateCoroutineMobileImpl() => default; // 0x000000018792B774-0x000000018792B7C0
	}

	public class LoginGameUpdater // TypeDefIndex: 53957
	{
		// Fields
		private const float COOLDOWN_INSTALL = 1f; // Metadata: 0x02078F6E
		private const int ERROR_CODE_NETWORK = 1103; // Metadata: 0x02078F72
		private const int ERROR_INIT_FAILED = -11101; // Metadata: 0x02078F74
		private const int ERROR_DESERIALIZE_FAILED = -10001; // Metadata: 0x02078F78
		public const int ERROR_ACTION = -20000; // Metadata: 0x02078F7C
		private const int WAIT_TIME_SECONDS_MIN = 5; // Metadata: 0x02078F80
		private const int WAIT_TIME_SECONDS_MAX = 9; // Metadata: 0x02078F81
		private Options m_options; // 0x10
		private IGameUpdateInterface m_sdkImpl; // 0x28
		private bool m_hasUpdateAlerted; // 0x30
		private Context m_context; // 0x38
		private LoginProgress m_progress; // 0x40
		private LoginHotUpdateProp m_hotUpdateProp; // 0x48
	
		// Nested types
		public enum CodeType // TypeDefIndex: 53936
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
	
		public enum UpdateType // TypeDefIndex: 53937
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
	
		public enum UpdateCode // TypeDefIndex: 53938
		{
			Success = 0
		}
	
		public enum UpdateAction // TypeDefIndex: 53939
		{
			Invalid = -1,
			Latest = 0,
			ForcedUpdate = 1,
			OptionalUpdate = 2,
			Error = 3,
			Congestion = 200
		}
	
		public class HGLatestGameInfo // TypeDefIndex: 53940
		{
			// Fields
			public int code; // 0x10
			public string version; // 0x18
			public int action; // 0x20
			public int updateType; // 0x24
			public string updateInfo; // 0x28
			public int state; // 0x30
	
			// Constructors
			public HGLatestGameInfo() {} // 0x0000000185259150-0x00000001852591C0
		}
	
		public class NotificationTitleConfig // TypeDefIndex: 53941
		{
			// Fields
			public string downloading; // 0x10
			public string pause; // 0x18
	
			// Constructors
			public NotificationTitleConfig() {} // 0x00000001844ED4D0-0x00000001844ED570
		}
	
		public class HGUpdateConfig // TypeDefIndex: 53942
		{
			// Fields
			public string downloadPath; // 0x10
	
			// Constructors
			public HGUpdateConfig() {} // 0x00000001879279E8-0x0000000187927A90
		}
	
		public struct Options // TypeDefIndex: 53943
		{
			// Fields
			public NetUsagePolicy netUsagePolicy; // 0x00
			public Action<string, Action> alertDialog; // 0x08
			public LoginContext loginContext; // 0x10
		}
	
		public class Result // TypeDefIndex: 53944
		{
			// Fields
			public bool needRetry; // 0x10
			public string errorInfo; // 0x18
			public int code; // 0x20
			public bool auditing; // 0x24
	
			// Constructors
			public Result() {} // 0x0000000187927A90-0x0000000187927B38
		}
	
		private class Context // TypeDefIndex: 53945
		{
			// Fields
			public long taskId; // 0x10
			public string errorInfo; // 0x18
			public string logError; // 0x20
			public bool needClear; // 0x28
			public HGLatestGameInfo gameInfo; // 0x30
			private bool _complete_k__BackingField; // 0x38
			private int _code_k__BackingField; // 0x3C
	
			// Properties
			public bool complete { get; private set; } // 0x0000000187927F34-0x0000000187927FDC 0x0000000187928224-0x00000001879282CC
			public int code { get; private set; } // 0x0000000187927E8C-0x0000000187927F34 0x00000001879280DC-0x0000000187928224
	
			// Constructors
			public Context() {} // 0x000000018792836C-0x000000018792840C
	
			// Methods
			public void CompleteWithCode(int pCode) {} // 0x0000000187927FDC-0x00000001879280DC
			public void UncompleteWithCode(int pCode) {} // 0x000000018792840C-0x00000001879284B4
		}
	
		private sealed class _CheckLastGameInfo_d__23 : IEnumerator<object> // TypeDefIndex: 53946
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Result result; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187927CDC-0x0000000187927E20 
			object IEnumerator.Current { get => default; } // 0x0000000187927B88-0x0000000187927CDC 
	
			// Constructors
			public _CheckLastGameInfo_d__23() {} // Dummy constructor
			public _CheckLastGameInfo_d__23(int __1__state) {} // 0x00000001879282CC-0x000000018792836C
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187927E20-0x0000000187927E8C
			private bool MoveNext() => default; // 0x0000000185256FF0-0x00000001852570C0
			void IEnumerator.Reset() {} // 0x0000000187927B38-0x0000000187927B88
		}
	
		private sealed class _DoUpdate_d__24 : IEnumerator<object> // TypeDefIndex: 53947
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Result result; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000185FAFE20-0x0000000185FAFE30 
	
			// Constructors
			public _DoUpdate_d__24() {} // Dummy constructor
			public _DoUpdate_d__24(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000185FB0700-0x0000000185FB0710
		}
	
		private sealed class __GetLastGameInfo_d__25 : IEnumerator<object> // TypeDefIndex: 53948
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public Context context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187925858-0x00000001879258B4 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public __GetLastGameInfo_d__25() {} // Dummy constructor
			public __GetLastGameInfo_d__25(int __1__state) {} // 0x0000000185FB0790-0x0000000185FB07A0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FB07A0-0x0000000185FB07B0
			private bool MoveNext() => default; // 0x00000001879257FC-0x0000000187925858
			void IEnumerator.Reset() {} // 0x00000001879258B4-0x000000018792591C
		}
	
		private sealed class __UpdateGame_d__26 : IEnumerator<object> // TypeDefIndex: 53949
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187929FE0-0x000000018792A02C 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public __UpdateGame_d__26() {} // Dummy constructor
			public __UpdateGame_d__26(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187929D9C-0x0000000187929FE0
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __DoTaskUpdating_d__27 : IEnumerator<object> // TypeDefIndex: 53950
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018792A670-0x000000018792A6BC 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public __DoTaskUpdating_d__27() {} // Dummy constructor
			public __DoTaskUpdating_d__27(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018792A314-0x000000018792A670
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 53951
		{
			// Fields
			public bool wait; // 0x10
	
			// Constructors
			public __c__DisplayClass32_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal void __YieldErrorAlert_b__0() {} // 0x000000018792B80C-0x000000018792BFE0
		}
	
		private sealed class __YieldErrorAlert_d__32 : IEnumerator<object> // TypeDefIndex: 53952
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public string desc; // 0x28
			private __c__DisplayClass32_0 __8__1; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x000000018792C630-0x000000018792CCAC 
	
			// Constructors
			public __YieldErrorAlert_d__32() {} // Dummy constructor
			public __YieldErrorAlert_d__32(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018792BFE0-0x000000018792C02C
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 53953
		{
			// Fields
			public bool rejected; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __c__DisplayClass33_1 // TypeDefIndex: 53954
		{
			// Fields
			public bool complete; // 0x10
			public __c__DisplayClass33_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass33_1() {} // 0x000000018792CCAC-0x000000018792CCF8
	
			// Methods
			internal void __YieldCheckNetUsagePolicy_b__0() {} // 0x0000000181377E40-0x0000000181377E50
			internal void __YieldCheckNetUsagePolicy_b__1() {} // 0x0000000181378230-0x0000000181378240
			internal void __YieldCheckNetUsagePolicy_b__2() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __YieldCheckNetUsagePolicy_d__33 : IEnumerator<object> // TypeDefIndex: 53955
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private __c__DisplayClass33_0 __8__1; // 0x20
			public LoginGameUpdater __4__this; // 0x28
			public long downloadSize; // 0x30
			private __c__DisplayClass33_1 __8__2; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185FB6A70-0x0000000185FB6A80 
	
			// Constructors
			public __YieldCheckNetUsagePolicy_d__33() {} // Dummy constructor
			public __YieldCheckNetUsagePolicy_d__33(int __1__state) {} // 0x000000018792B020-0x000000018792B500
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018792B500-0x000000018792B54C
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __WaitForTaskCancel_d__34 : IEnumerator<object> // TypeDefIndex: 53956
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginGameUpdater __4__this; // 0x20
			public long taskId; // 0x28
			private bool _isCanceled_5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __WaitForTaskCancel_d__34() {} // Dummy constructor
			public __WaitForTaskCancel_d__34(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018792D378-0x000000018792D4B4
			void IEnumerator.Reset() {} // 0x000000018792D4B4-0x000000018792D500
		}
	
		// Constructors
		public LoginGameUpdater() {} // Dummy constructor
		public LoginGameUpdater(Options options) {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Clear() {} // 0x0000000185492010-0x0000000185492020
		public IEnumerator CheckLastGameInfo(Result result) => default; // 0x0000000181B9A230-0x0000000181B9A240
		public IEnumerator DoUpdate(Result result) => default; // 0x000000018792AA98-0x000000018792AAB8
		private IEnumerator _GetLastGameInfo(Context context) => default; // 0x0000000181B9A230-0x0000000181B9A240
		private IEnumerator _UpdateGame(Context context) => default; // 0x0000000181378230-0x0000000181378240
		private IEnumerator _DoTaskUpdating(Context context) => default; // 0x0000000185492010-0x0000000185492020
		private void _OnDownloadStart() {} // 0x000000018792D0C0-0x000000018792D32C
		private void _OnDownloadProgress(long curSize, long totalSize, long speed) {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _YieldErrorAlert(string desc) => default; // 0x000000018792D32C-0x000000018792D378
		private IEnumerator _YieldCheckNetUsagePolicy(long downloadSize) => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _WaitForTaskCancel(long taskId) => default; // 0x0000000181378230-0x0000000181378240
		private static void _CreateDirectoryIfNotExists(string folderPath) {} // 0x0000000185492010-0x0000000185492020
		public void ClearWaitProgress() {} // 0x000000018792CECC-0x000000018792CF4C
		public void ShowWaitProgress() {} // 0x0000000181377E40-0x0000000181377E50
		public int GetNoAlertCode() => default; // 0x000000018792CF4C-0x000000018792CF98
		public float GetWaitTime() => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class LoginGSNode : LoginWorkFlow.Node // TypeDefIndex: 53967
	{
		// Fields
		private const int FLOW_NONE = 0; // Metadata: 0x02078FAA
		private const int FLOW_WORKING = 1; // Metadata: 0x02078FAB
		private const int FLOW_FINISH = 2; // Metadata: 0x02078FAC
		private const int FLOW_ABORTING = 3; // Metadata: 0x02078FAD
		private EnterGameServiceFlow m_flow; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x000000018792C3A8-0x000000018792C3F4 
	
		// Nested types
		private class EnterGameServiceFlow : CustomYieldInstruction // TypeDefIndex: 53965
		{
			// Fields
			private LoginContext m_context; // 0x10
			private LoginGSNode m_curNode; // 0x18
			private Beyond.Misc.ObjectRef m_dialogBlocker; // 0x20
			private int m_state; // 0x28
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x0000000184CB9550-0x0000000184CB9880 
	
			// Nested types
			private sealed class __EnterGameCoroutine_d__11 : IEnumerator<object> // TypeDefIndex: 53958
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
				object IEnumerator<System.Object>.Current { get => default; } // 0x00000001855A7D00-0x00000001855A7D60 
				object IEnumerator.Current { get => default; } // 0x00000001879276D0-0x0000000187927814 
	
				// Constructors
				public __EnterGameCoroutine_d__11() {} // Dummy constructor
				public __EnterGameCoroutine_d__11(int __1__state) {} // 0x0000000181DDC740-0x0000000181DDC750
	
				// Methods
				void IDisposable.Dispose() {} // 0x0000000185259B70-0x0000000185259CB0
				private bool MoveNext() => default; // 0x00000001855A6BA0-0x00000001855A6C40
				void IEnumerator.Reset() {} // 0x00000001879273B0-0x0000000187927534
			}
	
			private sealed class __NetConnectAndGSLogin_d__12 : IEnumerator<object> // TypeDefIndex: 53959
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
				object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187927534-0x0000000187927614 
				object IEnumerator.Current { get => default; } // 0x00000001879271F8-0x0000000187927204 
	
				// Constructors
				public __NetConnectAndGSLogin_d__12() {} // Dummy constructor
				public __NetConnectAndGSLogin_d__12(int __1__state) {} // 0x0000000187927814-0x0000000187927958
	
				// Methods
				void IDisposable.Dispose() {} // 0x0000000187927614-0x00000001879276D0
				private bool MoveNext() => default; // 0x0000000187927330-0x00000001879273B0
				void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
			}
	
			private sealed class __YieldAlertError_d__14 : IEnumerator<object> // TypeDefIndex: 53960
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string errorInfo; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185F4C2B0-0x0000000185F4C330 
				object IEnumerator.Current { get => default; } // 0x00000001855A7890-0x00000001855A79B0 
	
				// Constructors
				public __YieldAlertError_d__14() {} // Dummy constructor
				public __YieldAlertError_d__14(int __1__state) {} // 0x0000000187927204-0x0000000187927330
	
				// Methods
				void IDisposable.Dispose() {} // 0x00000001879271F0-0x00000001879271F8
				private bool MoveNext() => default; // 0x00000001852CED30-0x00000001852CED40
				void IEnumerator.Reset() {} // 0x000000018792597C-0x00000001879259D4
			}
	
			private sealed class __SaveCurrentUserToServerConfig_d__15 : IEnumerator<object> // TypeDefIndex: 53961
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public EnterGameServiceFlow __4__this; // 0x20
				public string uid; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x00000001855A7A20-0x00000001855A7AE0 
				object IEnumerator.Current { get => default; } // 0x0000000187925CE0-0x0000000187925D7C 
	
				// Constructors
				public __SaveCurrentUserToServerConfig_d__15() {} // Dummy constructor
				public __SaveCurrentUserToServerConfig_d__15(int __1__state) {} // 0x000000018792591C-0x000000018792597C
	
				// Methods
				void IDisposable.Dispose() {} // 0x00000001879259D4-0x0000000187925A3C
				private bool MoveNext() => default; // 0x00000001855A79B0-0x00000001855A7A20
				void IEnumerator.Reset() {} // 0x0000000187925A3C-0x0000000187925B38
			}
	
			private sealed class __c__DisplayClass16_0 // TypeDefIndex: 53962
			{
				// Fields
				public Beyond.Misc.ObjectRef waitForCallback; // 0x10
	
				// Constructors
				public __c__DisplayClass16_0() {} // 0x0000000184CB9950-0x0000000184CB99E0
	
				// Methods
				internal void __MockManualSelectServer_b__0() {} // 0x0000000187925B38-0x0000000187925BD4
			}
	
			private sealed class __MockManualSelectServer_d__16 : IEnumerator<object> // TypeDefIndex: 53963
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string uid; // 0x20
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FAF3E0-0x0000000185FAF3F0 
				object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
				// Constructors
				public __MockManualSelectServer_d__16() {} // Dummy constructor
				public __MockManualSelectServer_d__16(int __1__state) {} // 0x0000000187925BD4-0x0000000187925C7C
	
				// Methods
				void IDisposable.Dispose() {} // 0x0000000187925C7C-0x0000000187925CE0
				private bool MoveNext() => default; // 0x00000001857506B0-0x0000000185750770
				void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
			}
	
			private sealed class __OnAuthError_d__17 : IEnumerator<object> // TypeDefIndex: 53964
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public object rejectInfo; // 0x20
				public EnterGameServiceFlow __4__this; // 0x28
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
				object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
				// Constructors
				public __OnAuthError_d__17() {} // Dummy constructor
				public __OnAuthError_d__17(int __1__state) {} // 0x00000001855A7F10-0x00000001855ABDD0
	
				// Methods
				void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
				private bool MoveNext() => default; // 0x000000018792B54C-0x000000018792B598
				void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
			}
	
			// Constructors
			public EnterGameServiceFlow() {} // Dummy constructor
			public EnterGameServiceFlow(LoginGSNode node) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			public void MarkAborting() {} // 0x000000018792C3F4-0x000000018792C440
			public void EnterGame() {} // 0x0000000181377E40-0x0000000181377E50
			public bool IsInterruptable() => default; // 0x0000000181378230-0x0000000181378240
			public bool TryInterrupt() => default; // 0x0000000185492010-0x0000000185492020
			private IEnumerator _EnterGameCoroutine() => default; // 0x000000018792CFE4-0x000000018792D074
			private IEnumerator _NetConnectAndGSLogin(string uid, string token, Beyond.Misc.ObjectRef loginRespRef) => default; // 0x0000000181377E40-0x0000000181377E50
			private static string _ExtractErrorInfo(HttpSender.Result result, string keyErrorWithCode, string keyTimeout) => default; // 0x000000018792D074-0x000000018792D0C0
			private IEnumerator _YieldAlertError(string errorInfo) => default; // 0x0000000181377E40-0x0000000181377E50
			private IEnumerator _SaveCurrentUserToServerConfig(string uid) => default; // 0x0000000181378230-0x0000000181378240
			private IEnumerator _MockManualSelectServer(string uid) => default; // 0x0000000185492010-0x0000000185492020
			private IEnumerator _OnAuthError(object rejectInfo) => default; // 0x00000001850482D0-0x00000001850483B0
			private void _ReLoginWhenErrorEncountered() {} // 0x0000000181377E40-0x0000000181377E50
			private static void _GlobalLoginSucBusiness(MSG_B1 msg) {} // 0x000000018792C598-0x000000018792C5E4
			private bool __EnterGameCoroutine_b__11_0() => default; // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __ConfirmServer_d__10 : IEnumerator<object> // TypeDefIndex: 53966
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private SDKPromiseEnumerator<U8ConfirmServerResult> _confirmPromise_5__2; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __ConfirmServer_d__10() {} // Dummy constructor
			public __ConfirmServer_d__10(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018792AA10-0x000000018792AA34
			private bool MoveNext() => default; // 0x0000000181378230-0x0000000181378240
			void IEnumerator.Reset() {} // 0x000000018792C250-0x000000018792C3A8
		}
	
		// Constructors
		public LoginGSNode() {} // 0x0000000185751850-0x0000000185754B80
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000181377E40-0x0000000181377E50
		public override bool OnEvent(ELoginEvent evt, object param) => default; // 0x0000000181378230-0x0000000181378240
		private static IEnumerator _ConfirmServer() => default; // 0x0000000185492010-0x0000000185492020
		private void _FallbackToInitWithMask(bool bLogoutAccount) {} // 0x000000018792C440-0x000000018792C500
		private void _OnEventLogout() {} // 0x0000000181377E40-0x0000000181377E50
		private void _OnEventResourceRepair() {} // 0x000000018792C500-0x000000018792C54C
		private bool _LogoutToInitNode() => default; // 0x0000000181377E40-0x0000000181377E50
		private bool _FallbackToInitNodeImpl() => default; // 0x0000000181378230-0x0000000181378240
		private bool _FallbackToResRepairImpl() => default; // 0x0000000185492010-0x0000000185492020
		private void __OnEventLogout_b__12_0() {} // 0x0000000181377E40-0x0000000181377E50
		private void __OnEventResourceRepair_b__13_0() {} // 0x000000018792AF88-0x000000018792AFD4
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class LoginHotUpdateProp : LoginProperty<LoginHotUpdateModel> // TypeDefIndex: 53968
	{
		// Constructors
		public LoginHotUpdateProp() {} // Dummy constructor
		public LoginHotUpdateProp(LoginWorkFlow workflow) {} // 0x00000001852570C0-0x0000000185257160
	}

	public class LoginHotUpdateModel // TypeDefIndex: 53971
	{
		// Fields
		public string title; // 0x10
		public string desc; // 0x18
		public IProgress progress; // 0x20
	
		// Nested types
		public interface IProgress // TypeDefIndex: 53969
		{
			// Methods
			double GetTotal(); // 0x0000000185492010-0x0000000185492020
			double GetCurrent();
			string GetInfo();
		}
	
		public class SimpleProgress : Beyond.Login.LoginHotUpdateModel.IProgress // TypeDefIndex: 53970
		{
			// Fields
			public double current; // 0x10
	
			// Constructors
			public SimpleProgress() {} // 0x00000001842325A0-0x00000001842325D0
	
			// Methods
			public double GetCurrent() => default;
			public double GetTotal() => default; // 0x0000000184232340-0x0000000184232370
			public string GetInfo() => default; // 0x0000000184232510-0x00000001842325A0
		}
	
		// Constructors
		public LoginHotUpdateModel() {} // 0x0000000185492010-0x0000000185492020
	}

	public class LoginHotUpdater : CustomYieldInstruction, IDisposable // TypeDefIndex: 53997
	{
		// Fields
		private const int MODE_SKIP = 0; // Metadata: 0x02078FAE
		private const int MODE_DOWNLOAD = 1; // Metadata: 0x02078FAF
		private const int MODE_LOCAL = 2; // Metadata: 0x02078FB0
		private static bool s_hasInitialAssetChanged; // 0x00
		private static bool s_isNeedSoftRestart; // 0x01
		private LoginContext m_loginCxt; // 0x10
		private IEnumerator m_mainRoutine; // 0x18
		private LoginProgress m_progress; // 0x20
		private LoginHotUpdateProp m_hotupdateProp; // 0x28
		private LoginDownloadTask m_downloadTask; // 0x30
		private LoginLocalResTask m_localResTask; // 0x38
		private bool m_resRepairMode; // 0x40
		public const string URL_GET_SPLIT = "/"; // Metadata: 0x02078FB1
	
		// Properties
		public override bool keepWaiting { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		public class HotUpdateInfo // TypeDefIndex: 53972
		{
			// Fields
			public FResourceDiff resDiff; // 0x10
			public LocalResPref localResPref; // 0x50
	
			// Constructors
			public HotUpdateInfo() {} // 0x0000000187928774-0x00000001879287F8
	
			// Methods
			public bool CheckIfNeedReload() => default; // 0x0000000187928614-0x0000000187928680
			public bool HasChangedByType(EVFSBlockType type) => default; // 0x00000001879284B4-0x0000000187928520
			public bool HasAssetsChanged() => default; // 0x0000000187928680-0x0000000187928708
		}
	
		public class WorkContext // TypeDefIndex: 53973
		{
			// Fields
			public HotUpdateInfo updateInitial; // 0x10
			public HotUpdateInfo updateMain; // 0x18
			public string vitalError; // 0x20
			public bool reboot; // 0x28
			public NetUsagePolicy netUsagePolicy; // 0x30
			public ResourceIndex resIndex; // 0x38
			private bool _illegalItemsInLocalRes_k__BackingField; // 0x40
	
			// Properties
			public bool illegalItemsInLocalRes { get; private set; } // 0x000000018792858C-0x0000000187928614 0x0000000187928708-0x0000000187928774
	
			// Constructors
			public WorkContext() {} // 0x00000001847EB9E0-0x00000001847EB9F0
	
			// Methods
			public void MarkIllegalItemsInLocalRes() {} // 0x0000000187928520-0x000000018792858C
			public HotUpdateInfo GetHotUpdateInfo(bool isInitial) => default; // 0x0000000185B3D160-0x0000000185B3D1B0
			public bool HasChangedByType(EVFSBlockType type) => default; // 0x0000000185257320-0x00000001852573C0
		}
	
		private sealed class __Work_d__27 : IEnumerator<object> // TypeDefIndex: 53974
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			private WorkContext _workContext_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001855EC880-0x00000001855EC910 
			object IEnumerator.Current { get => default; } // 0x0000000187929430-0x00000001879294D8 
	
			// Constructors
			public __Work_d__27() {} // Dummy constructor
			public __Work_d__27(int __1__state) {} // 0x00000001858C7ED0-0x00000001858C8010
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001852575B0-0x0000000185257660
			private bool MoveNext() => default; // 0x0000000185257660-0x00000001852576D0
			void IEnumerator.Reset() {} // 0x0000000184357560-0x00000001843575F0
		}
	
		private sealed class __CreateMainCoroutine_d__28 : IEnumerator<object> // TypeDefIndex: 53975
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext workContext; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001879287F8-0x00000001879288B4 
			object IEnumerator.Current { get => default; } // 0x0000000185D6A3C0-0x0000000185D6A440 
	
			// Constructors
			public __CreateMainCoroutine_d__28() {} // Dummy constructor
			public __CreateMainCoroutine_d__28(int __1__state) {} // 0x00000001855EC7F0-0x00000001855EC880
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001855ECFB0-0x00000001855ED080
			private bool MoveNext() => default; // 0x0000000187929118-0x00000001879291EC
			void IEnumerator.Reset() {} // 0x00000001879297D4-0x000000018792985C
		}
	
		private sealed class __MainCoroutineModeSkip_d__29 : IEnumerator<object> // TypeDefIndex: 53976
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187929590-0x0000000187929658 
			object IEnumerator.Current { get => default; } // 0x0000000185D4AF80-0x0000000185D4B000 
	
			// Constructors
			public __MainCoroutineModeSkip_d__29() {} // Dummy constructor
			public __MainCoroutineModeSkip_d__29(int __1__state) {} // 0x000000018792971C-0x00000001879297D4
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001879294D8-0x0000000187929590
			private bool MoveNext() => default; // 0x0000000187929658-0x000000018792971C
			void IEnumerator.Reset() {} // 0x0000000187929388-0x0000000187929430
		}
	
		private sealed class __MainCoroutineModeLocal_d__30 : IEnumerator<object> // TypeDefIndex: 53977
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext context; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018184CD90-0x000000018184FBD0 
			object IEnumerator.Current { get => default; } // 0x0000000187928A10-0x0000000187928AEC 
	
			// Constructors
			public __MainCoroutineModeLocal_d__30() {} // Dummy constructor
			public __MainCoroutineModeLocal_d__30(int __1__state) {} // 0x00000001879291EC-0x00000001879292C8
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187928F60-0x000000018792903C
			private bool MoveNext() => default; // 0x000000018792903C-0x0000000187929118
			void IEnumerator.Reset() {} // 0x0000000187928E90-0x0000000187928F60
		}
	
		private sealed class __UpdateResVersion_d__31 : IEnumerator<object> // TypeDefIndex: 53978
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext workContext; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187928AEC-0x0000000187928BC8 
			object IEnumerator.Current { get => default; } // 0x00000001879292C8-0x0000000187929388 
	
			// Constructors
			public __UpdateResVersion_d__31() {} // Dummy constructor
			public __UpdateResVersion_d__31(int __1__state) {} // 0x0000000187928D78-0x0000000187928E90
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187928C9C-0x0000000187928D78
			private bool MoveNext() => default; // 0x0000000187928BC8-0x0000000187928C9C
			void IEnumerator.Reset() {} // 0x000000018792985C-0x0000000187929904
		}
	
		private sealed class __UpdateResVersionDev_d__35 : IEnumerator<object> // TypeDefIndex: 53979
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private ResVersionDevCfg _config_5__2; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185BB7250-0x0000000185BB72B0 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __UpdateResVersionDev_d__35() {} // Dummy constructor
			public __UpdateResVersionDev_d__35(int __1__state) {} // 0x00000001879288B4-0x0000000187928A10
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001843575F0-0x0000000184357680
			private bool MoveNext() => default; // 0x0000000187925D7C-0x0000000187925F28
			void IEnumerator.Reset() {} // 0x0000000187925F28-0x0000000187925FCC
		}
	
		private sealed class __UpdateResVersionProd_d__37 : IEnumerator<object> // TypeDefIndex: 53980
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
			private ResVersionCfg _config_5__2; // 0x28
			private Beyond.Misc.ObjectRef _resultRef_5__3; // 0x30
			private string _url_5__4; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018792E980-0x000000018792E9E4 
			object IEnumerator.Current { get => default; } // 0x00000001855EC910-0x00000001855EC980 
	
			// Constructors
			public __UpdateResVersionProd_d__37() {} // Dummy constructor
			public __UpdateResVersionProd_d__37(int __1__state) {} // 0x0000000185FB0650-0x0000000185FB0660
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FB0660-0x0000000185FB0670
			private bool MoveNext() => default; // 0x000000018792E9E4-0x000000018792EA34
			void IEnumerator.Reset() {} // 0x0000000185BB71E0-0x0000000185BB7250
		}
	
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 53981
		{
			// Fields
			public bool isInitial; // 0x10
	
			// Constructors
			public __c__DisplayClass42_0() {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			internal LocalResPref __MainCoroutineModeDownload_b__0() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53982
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__42_1; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001855EC660-0x00000001855EC7F0
			public __c() {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			internal void __MainCoroutineModeDownload_b__42_1() {} // 0x000000018792CF98-0x000000018792CFE4
		}
	
		private sealed class __MainCoroutineModeDownload_d__42 : IEnumerator<object> // TypeDefIndex: 53983
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public WorkContext workContext; // 0x28
			private __c__DisplayClass42_0 __8__1; // 0x30
			private bool _initialDownloaded_5__2; // 0x38
			private bool _needDeleteInitial_5__3; // 0x39
			private bool _neewDeleteMain_5__4; // 0x3A
			private int _initialOrMain_5__5; // 0x3C
			private string _onlineResVersion_5__6; // 0x40
			private WaitForAsyncTask<LocalResPref> _waitForResPref_5__7; // 0x48
			private HotUpdateInfo _info_5__8; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184357460-0x0000000184357560 
			object IEnumerator.Current { get => default; } // 0x000000018792AFD4-0x000000018792B020 
	
			// Constructors
			public __MainCoroutineModeDownload_d__42() {} // Dummy constructor
			public __MainCoroutineModeDownload_d__42(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181378230-0x0000000181378240
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __ReloadResourceIndexes_d__43 : IEnumerator<object> // TypeDefIndex: 53984
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185D4AEE0-0x0000000185D4AF80 
			object IEnumerator.Current { get => default; } // 0x000000018792C204-0x000000018792C250 
	
			// Constructors
			public __ReloadResourceIndexes_d__43() {} // Dummy constructor
			public __ReloadResourceIndexes_d__43(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181378230-0x0000000181378240
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 53985
		{
			// Fields
			public string filePath; // 0x10
			public ResourceIndex resIndex; // 0x18
			public Func<ResourceIndex> __9__1; // 0x20
	
			// Constructors
			public __c__DisplayClass44_0() {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			internal ResourceIndex __LoadOrDownloadResIndex_b__1() => default; // 0x0000000181378230-0x0000000181378240
			internal object __LoadOrDownloadResIndex_b__0() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __LoadOrDownloadResIndex_d__44 : IEnumerator<object> // TypeDefIndex: 53986
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool isInitial; // 0x20
			private __c__DisplayClass44_0 __8__1; // 0x28
			public string onlineVer; // 0x30
			public Beyond.Misc.ObjectRef resIndexRef; // 0x38
			public LoginHotUpdater __4__this; // 0x40
			private string _indexUrl_5__2; // 0x48
			private Beyond.Misc.ObjectRef _resultRef_5__3; // 0x50
			private WaitForAsyncTask<ResourceIndex> _loadTask_5__4; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __LoadOrDownloadResIndex_d__44() {} // Dummy constructor
			public __LoadOrDownloadResIndex_d__44(int __1__state) {} // 0x000000018792C078-0x000000018792C1B8
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018792C1B8-0x000000018792C204
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		private sealed class __GenResIndex_d__45 : IEnumerator<object> // TypeDefIndex: 53987
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __GenResIndex_d__45() {} // Dummy constructor
			public __GenResIndex_d__45(int __1__state) {} // 0x0000000185D6A340-0x0000000185D6A3C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018792CE80-0x000000018792CECC
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		private sealed class __GenRiff_d__46 : IEnumerator<object> // TypeDefIndex: 53988
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __GenRiff_d__46() {} // Dummy constructor
			public __GenRiff_d__46(int __1__state) {} // 0x000000018792CCF8-0x000000018792CDE8
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018792CDE8-0x000000018792CE34
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		private sealed class __GenLocalRef_d__48 : IEnumerator<object> // TypeDefIndex: 53989
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public WorkContext workContext; // 0x20
			public bool isInitial; // 0x28
			public string onlineVer; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x00000001879320FC-0x0000000187932170 
	
			// Constructors
			public __GenLocalRef_d__48() {} // Dummy constructor
			public __GenLocalRef_d__48(int __1__state) {} // 0x00000001855ED130-0x00000001855ED410
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x000000018792CE34-0x000000018792CE80
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __CheckAndDownloadResource_d__49 : IEnumerator<object> // TypeDefIndex: 53990
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
			private Beyond.Misc.ObjectRef _patchInfoRef_5__12; // 0x70
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x0000000187934794-0x0000000187935CB0 
	
			// Constructors
			public __CheckAndDownloadResource_d__49() {} // Dummy constructor
			public __CheckAndDownloadResource_d__49(int __1__state) {} // 0x00000001879322FC-0x0000000187932360
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x00000001879310EC-0x0000000187931CC8
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __DownloadPatchInfo_d__51 : IEnumerator<object> // TypeDefIndex: 53991
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x00000001845C69E0-0x00000001845C6DD0 
	
			// Constructors
			public __DownloadPatchInfo_d__51() {} // Dummy constructor
			public __DownloadPatchInfo_d__51(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187935CB0-0x0000000187935CFC
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __ClearDownloadFolder_d__52 : IEnumerator<object> // TypeDefIndex: 53992
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000187932170-0x00000001879321AC 
	
			// Constructors
			public __ClearDownloadFolder_d__52() {} // Dummy constructor
			public __ClearDownloadFolder_d__52(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187935CFC-0x0000000187935D48
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x00000001879321AC-0x000000018793220C
		}
	
		private sealed class __CheckLocalResConsistency_d__53 : IEnumerator<object> // TypeDefIndex: 53993
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __CheckLocalResConsistency_d__53() {} // Dummy constructor
			public __CheckLocalResConsistency_d__53(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018793406C-0x00000001879346B0
			void IEnumerator.Reset() {} // 0x00000001879346B0-0x00000001879346FC
		}
	
		private sealed class __VitalError_d__54 : IEnumerator<object> // TypeDefIndex: 53994
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginHotUpdater __4__this; // 0x20
			public string error; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __VitalError_d__54() {} // Dummy constructor
			public __VitalError_d__54(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000187933380-0x00000001879334BC
			void IEnumerator.Reset() {} // 0x00000001879334BC-0x0000000187933508
		}
	
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 53995
		{
			// Fields
			public RuntimeFileUtils.StreamingResult indexRet; // 0x10
	
			// Constructors
			public __c__DisplayClass55_0() {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			internal ResourceIndex __LoadStreamingIndex_b__0() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __LoadStreamingIndex_d__55 : IEnumerator<object> // TypeDefIndex: 53996
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool isInitial; // 0x20
			private __c__DisplayClass55_0 __8__1; // 0x28
			public Beyond.Misc.ObjectRef resultRef; // 0x30
			public WorkContext workContext; // 0x38
			private string _indexPath_5__2; // 0x40
			private WaitForAsyncTask<ResourceIndex> _waitForIndex_5__3; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __LoadStreamingIndex_d__55() {} // Dummy constructor
			public __LoadStreamingIndex_d__55(int __1__state) {} // 0x0000000187933508-0x00000001879338BC
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			private bool MoveNext() => default; // 0x00000001879338BC-0x0000000187933908
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public LoginHotUpdater() {} // Dummy constructor
		private LoginHotUpdater(LoginContext context, bool resRepairMode) {} // 0x0000000181859E00-0x0000000181859E50
	
		// Methods
		protected static void MarkInitialAssetChanged() {} // 0x0000000181865580-0x0000000181865FD0
		protected static bool CheckInitialAssetChanged() => default; // 0x0000000181377E40-0x0000000181377E50
		protected static void MarkNeedClearFolder(bool isInitial) {} // 0x0000000181865FD0-0x0000000181866020
		protected static bool NeedClearFolder(bool isInitial) => default; // 0x0000000181377E40-0x0000000181377E50
		protected static void MarkClearSuccessed(bool isInitial) {} // 0x0000000181378230-0x0000000181378240
		public static void MarkSoftRestart() {} // 0x0000000185492010-0x0000000185492020
		public static void ClearSoftRestartFlag() {} // 0x0000000181856130-0x0000000181859E00
		public static bool IsNeedSoftRestart() => default; // 0x0000000181377E40-0x0000000181377E50
		public void Dispose() {} // 0x0000000181378230-0x0000000181378240
		public static LoginHotUpdater StartHotUpdate(LoginContext context, bool resRepairMode) => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerator _Work() => default; // 0x0000000181861160-0x0000000181863580
		private IEnumerator _CreateMainCoroutine(WorkContext workContext) => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _MainCoroutineModeSkip(WorkContext context) => default; // 0x0000000181863580-0x00000001818635D0
		private IEnumerator _MainCoroutineModeLocal(WorkContext context) => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _UpdateResVersion(WorkContext workContext) => default; // 0x0000000181378230-0x0000000181378240
		private static void _SetResVersionForLog() {} // 0x0000000185492010-0x0000000185492020
		private string _GetOnlineResVersion(bool isInitial) => default; // 0x000000018185D700-0x0000000181861110
		public string ResourceRootUrl(string version, bool isInitial) => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _UpdateResVersionDev(WorkContext workContext) => default; // 0x0000000181861110-0x0000000181861160
		private IEnumerator _UpdateResVersionProd(WorkContext workContext) => default; // 0x0000000181377E40-0x0000000181377E50
		private string _ResourcePatchUrl(string version, bool isInitial) => default; // 0x0000000181378230-0x0000000181378240
		private string _ResourceFileUrl(string version, bool isInitial) => default; // 0x0000000185492010-0x0000000185492020
		private string _ResourcePatchRootUrl(string version, bool isInitial) => default; // 0x0000000181859E50-0x000000018185D6B0
		private string _ResourceIndexUrl(string version, bool isInitial) => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _MainCoroutineModeDownload(WorkContext workContext) => default; // 0x000000018185D6B0-0x000000018185D700
		private IEnumerator _ReloadResourceIndexes(WorkContext workContext) => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _LoadOrDownloadResIndex(string onlineVer, bool isInitial, Beyond.Misc.ObjectRef resIndexRef) => default; // 0x0000000181378230-0x0000000181378240
		private IEnumerator _GenResIndex(string onlineVer, bool isInitial, WorkContext workContext) => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerator _GenRiff(string onlineVer, bool isInitial, WorkContext workContext) => default; // 0x0000000181868790-0x0000000181869470
		private static LocalResPref _CreateUpdatedLocalResPref(string onlineVer, bool isInitial, LocalResPref oldLocalResPref, FResourceDiff resDiff, out int removedFileCount) {
			removedFileCount = default;
			return default;
		} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _GenLocalRef(string onlineVer, bool isInitial, WorkContext workContext) => default; // 0x0000000181869470-0x000000018186A530
		private IEnumerator _CheckAndDownloadResource(string onlineVer, bool isInitial, WorkContext workContext) => default; // 0x0000000181377E40-0x0000000181377E50
		private void _EventLogDownloadProgress(ref bool first, double current, double total, int target, bool isInitial) {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator _DownloadPatchInfo(string onlineVer, bool isInitial, Beyond.Misc.ObjectRef patchInfoRef) => default; // 0x0000000181855400-0x0000000181855430
		private IEnumerator _ClearDownloadFolder(WorkContext workContext, bool needDeleteInitial, bool needDeleteMain) => default; // 0x0000000181378230-0x0000000181378240
		private IEnumerator _CheckLocalResConsistency(string onlineVer, bool isInitial, WorkContext context) => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerator _VitalError(string error) => default; // 0x0000000181866020-0x0000000181868740
		private static IEnumerator _LoadStreamingIndex(bool isInitial, WorkContext workContext, Beyond.Misc.ObjectRef resultRef) => default; // 0x0000000181377E40-0x0000000181377E50
		public static void WriteLocalResPrefToFile(LocalResPref localResPref, WorkContext workContext) {} // 0x0000000181868740-0x0000000181868790
		private static int _CurrentWorkMode(LoginContext context) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class LoginProgress : LoginHotUpdateModel.IProgress // TypeDefIndex: 54000
	{
		// Fields
		public const int MODE_PROG = 0; // Metadata: 0x02078FB3
		public const int MODE_SIZE = 1; // Metadata: 0x02078FB4
		public const int MODE_IDEL = 2; // Metadata: 0x02078FB5
		public int mode; // 0x10
		public double current; // 0x18
		public double total; // 0x20
		public double speed; // 0x28
		private FDownloadSize m_downloadSize; // 0x30
	
		// Nested types
		private struct FDownloadSize // TypeDefIndex: 53999
		{
			// Fields
			private const double MB = 1048576; // Metadata: 0x02078FB6
			private const double KB = 1024; // Metadata: 0x02078FBE
			private EUnit m_unit; // 0x00
			private float m_displayCurrent; // 0x04
			private float m_displayTotal; // 0x08
			private float m_displaySpeed; // 0x0C
			public string displayInfo; // 0x10
			private float m_current; // 0x18
			private float m_total; // 0x1C
	
			// Nested types
			private enum EUnit // TypeDefIndex: 53998
			{
				NONE = 0,
				B = 1,
				KB = 2,
				MB = 3
			}
	
			// Methods
			public void SetProgress(double current, double total) {} // 0x000000018792FC64-0x000000018792FCB4
			public void SetIdle() {} // 0x000000018792FD60-0x000000018792FDB0
			public void SetSize(double current, double total, double speed) {} // 0x000000018792FCB4-0x000000018792FD60
			private static EUnit _PickUnit(double number) => default; // 0x0000000185492010-0x0000000185492020
			private static float _DisplayWithUnit(double number, EUnit unit) => default; // 0x000000018792F1F4-0x000000018792F304
			private static string _FormatDisplayInfo(float current, float total, EUnit unit) => default; // 0x000000018792F128-0x000000018792F1F4
			private static string _FormatSpeedInfo(float speed, EUnit unit) => default; // 0x000000018792F304-0x000000018792F504
			private static string _FormatProgressInfo(float current, float total) => default; // 0x000000018792F878-0x000000018792F8FC
		}
	
		// Constructors
		public LoginProgress() {} // 0x000000018792F6D8-0x000000018792F788
	
		// Methods
		public double GetCurrent() => default; // 0x000000018792F504-0x000000018792F5A4
		public double GetTotal() => default; // 0x000000018792F5A4-0x000000018792F6D8
		public string GetInfo() => default; // 0x000000018792F788-0x000000018792F878
	}

	public class LoginInitNode : LoginWorkFlow.Node // TypeDefIndex: 54004
	{
		// Fields
		private bool m_isSDKInited; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000181378230-0x0000000181378240 
	
		// Nested types
		private sealed class __InitCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 54001
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginInitNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185A1A320-0x0000000185A1A390 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __InitCoroutine_d__4() {} // Dummy constructor
			public __InitCoroutine_d__4(int __1__state) {} // 0x0000000181C44E90-0x0000000181C44EA0
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001852598B0-0x0000000185259990
			private bool MoveNext() => default; // 0x0000000185259990-0x0000000185259A00
			void IEnumerator.Reset() {} // 0x000000018792FAF4-0x000000018792FB90
		}
	
		private sealed class __InitRemoteConfigs_d__5 : IEnumerator<object> // TypeDefIndex: 54002
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginInitNode __4__this; // 0x20
			private NetConfigInterface.InitYiedInstruction _initNetConfig_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __InitRemoteConfigs_d__5() {} // Dummy constructor
			public __InitRemoteConfigs_d__5(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185A1A260-0x0000000185A1A320
			void IEnumerator.Reset() {} // 0x0000000187933F88-0x0000000187933FD4
		}
	
		private sealed class __YieldAlertError_d__6 : IEnumerator<object> // TypeDefIndex: 54003
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string errorInfo; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __YieldAlertError_d__6() {} // Dummy constructor
			public __YieldAlertError_d__6(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185049530-0x0000000185049800
			void IEnumerator.Reset() {} // 0x0000000187933FD4-0x0000000187934020
		}
	
		// Constructors
		public LoginInitNode() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerator _InitCoroutine() => default; // 0x0000000187935E2C-0x0000000187935EBC
		private IEnumerator _InitRemoteConfigs() => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _YieldAlertError(string errorInfo) => default; // 0x0000000187935EBC-0x0000000187935F08
	}

	public class LoginLocalResTask : IDisposable // TypeDefIndex: 54007
	{
		// Fields
		private LoginContext m_loginCxt; // 0x10
		private LoginHotUpdater.WorkContext m_workCxt; // 0x18
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 54005
		{
			// Fields
			public string indexPath; // 0x10
			public string prefPath; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x00000001841BC230-0x00000001841BC260
	
			// Methods
			internal ResourceIndex _Work_b__0() => default; // 0x000000018792FBD4-0x000000018792FC64
			internal LocalResPref _Work_b__1() => default; // 0x000000018792FB90-0x000000018792FBD4
		}
	
		private sealed class _Work_d__3 : IEnumerator<object> // TypeDefIndex: 54006
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
			object IEnumerator.Current { get => default; } // 0x00000001879323AC-0x00000001879332E8 
	
			// Constructors
			public _Work_d__3() {} // Dummy constructor
			public _Work_d__3(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018793207C-0x00000001879320CC
			private bool MoveNext() => default; // 0x00000001879320CC-0x00000001879320FC
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public LoginLocalResTask() {} // Dummy constructor
		public LoginLocalResTask(LoginContext loginContext, LoginHotUpdater.WorkContext workContext) {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public IEnumerator Work() => default; // 0x00000001879332E8-0x0000000187933334
		public void Dispose() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class PreloadNode : LoginWorkFlow.Node // TypeDefIndex: 54015
	{
		// Fields
		private LoginHotUpdateModel.SimpleProgress m_progress; // 0x20
		private bool m_getServerListSuc; // 0x28
		private string m_errorMsg; // 0x30
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 54008
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<bool> __9__5_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000181E1B510-0x0000000181E1B520
			public __c() {} // 0x0000000185259E60-0x000000018525BA90
	
			// Methods
			internal bool _Work_b__5_0() => default; // 0x0000000185257160-0x0000000185257260
		}
	
		private sealed class __LoginPreLoad_d__7 : IEnumerator<object> // TypeDefIndex: 54009
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185B46EE0-0x0000000185B47D40 
			object IEnumerator.Current { get => default; } // 0x0000000187930F98-0x0000000187931028 
	
			// Constructors
			public __LoginPreLoad_d__7() {} // Dummy constructor
			public __LoginPreLoad_d__7(int __1__state) {} // 0x000000018525BA90-0x000000018525BB00
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185B46E70-0x0000000185B46EE0
			private bool MoveNext() => default; // 0x0000000185B46E00-0x0000000185B46E70
			void IEnumerator.Reset() {} // 0x0000000185751560-0x00000001857515D0
		}
	
		private sealed class __WarmUp_d__8 : IEnumerator<object> // TypeDefIndex: 54010
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185F79090-0x0000000185F790F0 
			object IEnumerator.Current { get => default; } // 0x00000001842A8DD0-0x00000001842A98F0 
	
			// Constructors
			public __WarmUp_d__8() {} // Dummy constructor
			public __WarmUp_d__8(int __1__state) {} // 0x00000001857508A0-0x0000000185751470
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187931028-0x00000001879310E4
			private bool MoveNext() => default; // 0x000000018476B130-0x000000018476B1B0
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __GetServerList_d__9 : IEnumerator<object> // TypeDefIndex: 54011
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __GetServerList_d__9() {} // Dummy constructor
			public __GetServerList_d__9(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185B45B70-0x0000000185B46E00
			void IEnumerator.Reset() {} // 0x0000000187934748-0x0000000187934794
		}
	
		private sealed class __GetServerListInfoMock_d__11 : IEnumerator<object> // TypeDefIndex: 54012
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __GetServerListInfoMock_d__11() {} // Dummy constructor
			public __GetServerListInfoMock_d__11(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018584ED90-0x000000018584EF00
			void IEnumerator.Reset() {} // 0x0000000187935DE0-0x0000000187935E2C
		}
	
		private sealed class __GetServerListInfo_d__12 : IEnumerator<object> // TypeDefIndex: 54013
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PreloadNode __4__this; // 0x20
			private SDKPromiseEnumerator<List<U8ServerInfo>> _getServerListPromise_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __GetServerListInfo_d__12() {} // Dummy constructor
			public __GetServerListInfo_d__12(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185751470-0x0000000185751560
			void IEnumerator.Reset() {} // 0x0000000187933F3C-0x0000000187933F88
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 54014
		{
			// Fields
			public List<ServerZoneManager.ServerZoneData> serverZoneDataList; // 0x10
			public List<SpeedTestServerInfo> serverList; // 0x18
			public Action<SpeedTestResult> callback; // 0x20
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			internal void __OnGetServerListSuc_b__0(SpeedTestResult result) {} // 0x0000000185492010-0x0000000185492020
			internal Task<Hypergryph.SpeedTest.TaskResult> __OnGetServerListSuc_b__1() => default; // 0x0000000185750480-0x0000000185750540
		}
	
		// Constructors
		public PreloadNode() {} // 0x0000000187932014-0x000000018793207C
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000187933908-0x0000000187933954
		private void _ShowPreloadResourcePanel() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _LoginPreLoad() => default; // 0x0000000181378230-0x0000000181378240
		private IEnumerator _WarmUp() => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerator _GetServerList() => default; // 0x0000000187933954-0x0000000187933EF0
		private void _EnterPreLoad() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _GetServerListInfoMock() => default; // 0x0000000187933EF0-0x0000000187933F3C
		private IEnumerator _GetServerListInfo() => default; // 0x0000000181377E40-0x0000000181377E50
		private void _OnGetServerListSuc() {} // 0x0000000185492010-0x0000000185492020
		private void _OnGetServerListFail(string errorInfo) {} // 0x0000000187931CC8-0x0000000187932014
	}

	public class LoginSDKInitNode : LoginWorkFlow.Node // TypeDefIndex: 54019
	{
		// Fields
		private bool m_isSDKInited; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000181378230-0x0000000181378240 
	
		// Nested types
		private sealed class __SDKInitCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 54016
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginSDKInitNode __4__this; // 0x20
			private string _env_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018525C3B0-0x000000018525C410 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public __SDKInitCoroutine_d__4() {} // Dummy constructor
			public __SDKInitCoroutine_d__4(int __1__state) {} // 0x0000000181C6A970-0x0000000181C6A980
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001852594E0-0x00000001852595C0
			private bool MoveNext() => default; // 0x00000001852595C0-0x0000000185259630
			void IEnumerator.Reset() {} // 0x000000018525BC20-0x000000018525BCA0
		}
	
		private sealed class __WaitForSDKInited_d__5 : IEnumerator<object> // TypeDefIndex: 54017
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __WaitForSDKInited_d__5() {} // Dummy constructor
			public __WaitForSDKInited_d__5(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x000000018525CDA0-0x000000018525FC20
			void IEnumerator.Reset() {} // 0x0000000187935D48-0x0000000187935D94
		}
	
		private sealed class __InitSubSDKs_d__6 : IEnumerator<object> // TypeDefIndex: 54018
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public string env; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __InitSubSDKs_d__6() {} // Dummy constructor
			public __InitSubSDKs_d__6(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185CA5B90-0x0000000185CA6C30
			void IEnumerator.Reset() {} // 0x0000000187935D94-0x0000000187935DE0
		}
	
		// Constructors
		public LoginSDKInitNode() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerator _SDKInitCoroutine() => default; // 0x0000000184FA9ED0-0x0000000184FAA090
		private IEnumerator _WaitForSDKInited() => default; // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _InitSubSDKs(string env) => default; // 0x0000000187934020-0x000000018793406C
	}

	public class U8LoginNode : LoginWorkFlow.Node // TypeDefIndex: 54022
	{
		// Fields
		private bool m_loginSuc; // 0x20
		private bool m_isSDKLoginFinished; // 0x21
		private int m_rqstSkipLoginCache; // 0x24
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000184B92680-0x0000000184B926C0 
	
		// Nested types
		private sealed class __LoginCoroutine_d__6 : IEnumerator<object> // TypeDefIndex: 54020
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public U8LoginNode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185259070-0x00000001852590D0 
			object IEnumerator.Current { get => default; } // 0x000000018525C760-0x000000018525C9C0 
	
			// Constructors
			public __LoginCoroutine_d__6() {} // Dummy constructor
			public __LoginCoroutine_d__6(int __1__state) {} // 0x0000000181D27740-0x0000000181D27750
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185259760-0x0000000185259840
			private bool MoveNext() => default; // 0x0000000185259840-0x00000001852598B0
			void IEnumerator.Reset() {} // 0x0000000187935F08-0x0000000187935F8C
		}
	
		private sealed class __FinishLogin_d__7 : IEnumerator<object> // TypeDefIndex: 54021
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private string _env_5__2; // 0x20
			private SDKPromiseEnumerator<U8AuthV2Result> _authPromise_5__3; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185256E60-0x0000000185256F40 
			object IEnumerator.Current { get => default; } // 0x0000000187936110-0x0000000187936238 
	
			// Constructors
			public __FinishLogin_d__7() {} // Dummy constructor
			public __FinishLogin_d__7(int __1__state) {} // 0x00000001857515D0-0x0000000185751650
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185751740-0x00000001857517C0
			private bool MoveNext() => default; // 0x0000000187936238-0x0000000187936304
			void IEnumerator.Reset() {} // 0x0000000184B91750-0x0000000184B91810
		}
	
		// Constructors
		public U8LoginNode() {} // 0x000000018476F200-0x000000018476F540
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000187936064-0x0000000187936110
		private IEnumerator _LoginCoroutine() => default; // 0x0000000184B8FD80-0x0000000184B8FE20
		private IEnumerator _FinishLogin() => default; // 0x0000000185492010-0x0000000185492020
		public override bool OnEvent(ELoginEvent evt, object param) => default; // 0x0000000185751650-0x0000000185751700
		private void _StartSDKLogin() {} // 0x0000000187935F8C-0x0000000187936064
		private void _SetCursorOnLoginStart() {} // 0x00000001879271F0-0x00000001879271F8
		private void _SetCursorOnLoginFinish() {} // 0x0000000181378230-0x0000000181378240
		private void _SkipSDKLogin() {} // 0x0000000185492010-0x0000000185492020
		private void _ClearLoginCaches() {} // 0x00000001852576D0-0x0000000185259070
		private void _OnLoginSuc() {} // 0x0000000181377E40-0x0000000181377E50
		private void _OnLoginFail(object rawInfo) {} // 0x00000001879346FC-0x0000000187934748
		private void _OnSDKViewDisabled() {} // 0x0000000181377E40-0x0000000181377E50
		private void _OnLoginCanceled() {} // 0x0000000181378230-0x0000000181378240
		private void _EnableBlurMask(bool enable) {} // 0x0000000185492010-0x0000000185492020
		private void __StartSDKLogin_b__9_0(string sessionToken) {} // 0x0000000181377E40-0x0000000181377E50
		private void __StartSDKLogin_b__9_1(object pram) {} // 0x0000000187933334-0x0000000187933380
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class LoginProperty<T> : LoginWorkFlow.IWorkerUpdateOnce // TypeDefIndex: 54023
		where T : class, new()
	{
		// Fields
		private T m_value;
		private HashSet<ILoginBinder<T>> m_binders;
		private LoginWorkFlow m_workflow;
		private bool _isDataChanged_k__BackingField;
	
		// Properties
		public bool isDataChanged { get; private set; }
		public T value { get => default; }
	
		// Constructors
		public LoginProperty() {} // Dummy constructor
		public LoginProperty(LoginWorkFlow workflow) {}
	
		// Methods
		public void NotifyDataChanged() {}
		public void Bind(ILoginBinder<T> binder) {}
		public void Worker_UpdateOnce() {}
	}

	public interface ILoginBinder<T> // TypeDefIndex: 54024
	{
		// Methods
		void OnValueChanged(T value);
	}

	public interface ILoginContextReceiver // TypeDefIndex: 54025
	{
		// Methods
		void OnLoginContext(LoginContext context);
	}

	public class LoginViewModel // TypeDefIndex: 54027
	{
		// Fields
		public LoginWorkFlow.ENode workCachedCurNode; // 0x10
		public LoginWorkFlow.ENode workCurNode; // 0x14
		public bool isFirstLogin; // 0x18
		private int _rqstSkipU8Login_k__BackingField; // 0x1C
		public bool isU8LoginCancelled; // 0x20
		private int _rqstResRepairCode_k__BackingField; // 0x24
		public FAgeTipsPolicy ageTipsPolicy; // 0x28
	
		// Properties
		public int rqstSkipU8Login { get; private set; } // 0x00000001813AE9D0-0x00000001813AE9E0 0x0000000181424480-0x0000000181424490
		public int rqstResRepairCode { get; private set; } // 0x0000000181424940-0x0000000181424950 0x000000018420F5A0-0x000000018420F620
	
		// Nested types
		public struct FAgeTipsPolicy // TypeDefIndex: 54026
		{
			// Fields
			public bool canOpenDetail; // 0x00
			public bool displayCN; // 0x01
			public bool displayKR; // 0x02
	
			// Properties
			public bool display { get => default; } // 0x0000000185EF5DA0-0x0000000185EF5DD0 
		}
	
		// Constructors
		public LoginViewModel() {} // 0x00000001813AE570-0x00000001813AE580
	
		// Methods
		public bool IsAgeTipsVisible() => default; // 0x000000018420F460-0x000000018420F490
		public bool IsGovTipsVisible() => default; // 0x000000018420F630-0x000000018420F700
		public bool IsMenuVisible() => default; // 0x000000018792FE1C-0x000000018792FE68
		public void RequestResourceRepair() {} // 0x000000018792FE68-0x000000018792FEB4
		public void RequestSkipU8Login() {} // 0x0000000185EF5DD0-0x0000000185EF5E40
		private static FAgeTipsPolicy _LoadAgeTipsPolicy() => default; // 0x000000018420F620-0x000000018420F630
	}

	public class LoginViewProperty : LoginProperty<LoginViewModel> // TypeDefIndex: 54028
	{
		// Fields
		private LoginHotUpdateProp _hotUpdateProp_k__BackingField; // 0x30
		private LoginAgeTipsProp _ageTipsProp_k__BackingField; // 0x38
		private LoginServerSelectProp _serverSelectProp_k__BackingField; // 0x40
	
		// Properties
		public LoginHotUpdateProp hotUpdateProp { get; private set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public LoginAgeTipsProp ageTipsProp { get; private set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public LoginServerSelectProp serverSelectProp { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
	
		// Constructors
		public LoginViewProperty() {} // Dummy constructor
		public LoginViewProperty(LoginWorkFlow workflow) {} // 0x0000000185256D00-0x0000000185256E10
	}

	public class LoginAgeTipsModel // TypeDefIndex: 54029
	{
		// Fields
		public string contentCache; // 0x10
		public bool isShow; // 0x18
		public bool isFetchingContent; // 0x19
	
		// Constructors
		public LoginAgeTipsModel() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsContentEmpty() => default; // 0x0000000185256FB0-0x0000000185256FF0
		public bool CanDisplay() => default; // 0x0000000185EBAF30-0x0000000185EBB020
	}

	public class LoginAgeTipsProp : LoginProperty<LoginAgeTipsModel> // TypeDefIndex: 54030
	{
		// Constructors
		public LoginAgeTipsProp() {} // Dummy constructor
		public LoginAgeTipsProp(LoginWorkFlow workflow) {} // 0x0000000185256F40-0x0000000185256FB0
	
		// Methods
		public void ClearContentCache() {} // 0x000000018792F980-0x000000018792FA44
		public void UpdateContent(string content) {} // 0x000000018792FA44-0x000000018792FAF4
	}

	public class LoginWorkFlow : IDisposable // TypeDefIndex: 54041
	{
		// Fields
		public const string CURSOR_KEY_LOGIN = "login"; // Metadata: 0x02078FCC
		private static bool s_hasEnteredPreloadThisSession; // 0x00
		private static readonly ENode[] NODE_ORDER; // 0x08
		private const ENode NEED_GAME_LOGIN_STATE_BEFORE_NODE = ENode.Preload; // Metadata: 0x02078FD2
		private readonly Node[] m_nodes; // 0x10
		private readonly LoginContext m_context; // 0x18
		private FWork m_work; // 0x20
		private Worker m_worker; // 0x30
		private HashSet<IEventReceiver> m_evtRecvrs; // 0x38
		private List<IEventReceiver> m_recvrBuffer; // 0x40
		private bool _isDisposed_k__BackingField; // 0x48
	
		// Properties
		public bool isDisposed { get; private set; } // 0x0000000185FB6A80-0x0000000185FB6A90 0x0000000185FB6A90-0x0000000185FB6AA0
	
		// Nested types
		public abstract class Node // TypeDefIndex: 54031
		{
			// Fields
			private LoginContext _context_k__BackingField; // 0x10
			private LoginWorkFlow _workflow_k__BackingField; // 0x18
	
			// Properties
			protected LoginContext context { get; private set; } // 0x0000000181852130-0x0000000181852A70 0x0000000181850EB0-0x00000001818517F0
			protected LoginWorkFlow workflow { get; private set; } // 0x00000001818517F0-0x0000000181852130 0x000000018476C170-0x000000018476C4D0
			public abstract ENode type { get; } // 0x000000018476BD70-0x000000018476BEF0 
	
			// Constructors
			protected Node() {} // 0x000000018792FEB4-0x000000018792FF44
	
			// Methods
			public void Init(LoginContext context, LoginWorkFlow workflow) {} // 0x0000000185FB0750-0x0000000185FB0760
			public void Dispose() {} // 0x0000000185FB0770-0x0000000185FB0780
			public abstract CustomYieldInstruction Work(); // 0x0000000185F4C490-0x0000000185F4C500
			public virtual bool CanCancel() => default; // 0x000000018476BEF0-0x000000018476C0A0
			public virtual CustomYieldInstruction Cancel() => default; // 0x00000001858C8010-0x00000001858C80C0
			protected virtual void OnInit() {} // 0x000000018792FFD8-0x0000000187930234
			public virtual void OnDispose() {} // 0x000000018792FF44-0x000000018792FFD8
			public virtual bool OnEvent(ELoginEvent evt, object param) => default; // 0x00000001855A67B0-0x00000001855A6B30
		}
	
		public enum ENode // TypeDefIndex: 54032
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
	
		public interface IWorkerUpdateOnce // TypeDefIndex: 54033
		{
			// Methods
			void Worker_UpdateOnce(); // 0x00000001856A5960-0x00000001856A59C0
		}
	
		public interface IEventReceiver // TypeDefIndex: 54034
		{
			// Methods
			void OnEvent(ELoginEvent evt, object param); // 0x000000018420C4E0-0x000000018420C550
		}
	
		private class Worker : IDisposable // TypeDefIndex: 54036
		{
			// Fields
			private HashSet<IWorkerUpdateOnce> m_updateOnce; // 0x10
			private List<IWorkerUpdateOnce> m_buffer; // 0x18
			private CustomYieldInstruction m_curWork; // 0x20
			private bool _isCancelled_k__BackingField; // 0x28
			private bool _isDisposed_k__BackingField; // 0x29
			private Node _curNode_k__BackingField; // 0x30
	
			// Properties
			public bool isCancelled { get; private set; } // 0x0000000187930800-0x00000001879308E0 0x0000000187930420-0x00000001879305BC
			public bool isDisposed { get; private set; } // 0x000000018525C9C0-0x000000018525CA80 0x0000000187930988-0x0000000187930AD0
			public Node curNode { get; private set; } // 0x000000018476D830-0x000000018476D8A0 0x00000001879308E0-0x0000000187930988
	
			// Nested types
			private sealed class _Work_d__20 : IEnumerator<object> // TypeDefIndex: 54035
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public Worker __4__this; // 0x20
				public CustomYieldInstruction work; // 0x28
				private CustomYieldInstruction _cancelTask_5__2; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x00000001879305BC-0x0000000187930730 
				object IEnumerator.Current { get => default; } // 0x0000000187930730-0x0000000187930800 
	
				// Constructors
				public _Work_d__20() {} // Dummy constructor
				public _Work_d__20(int __1__state) {} // 0x000000018420DDF0-0x000000018420DEC0
	
				// Methods
				void IDisposable.Dispose() {} // 0x0000000187930234-0x00000001879302F8
				private bool MoveNext() => default; // 0x00000001855A6B30-0x00000001855A6BA0
				void IEnumerator.Reset() {} // 0x00000001879302F8-0x0000000187930420
			}
	
			// Constructors
			public Worker() {} // 0x000000018476C0E0-0x000000018476C140
	
			// Methods
			public bool Cancel() => default; // 0x000000018420B6D0-0x000000018420C460
			public void Dispose() {} // 0x0000000185B93B90-0x0000000185B93C00
			public void SetCurNode(Node node) {} // 0x0000000185F3CCC0-0x0000000185F3D8D0
			public bool UpdateOnce(IWorkerUpdateOnce inst) => default; // 0x000000018346D130-0x000000018346D140
			public void TickInEmptyFrame() {} // 0x0000000184096E30-0x0000000184096EF0
			public IEnumerator Work(CustomYieldInstruction work) => default; // 0x0000000181377E40-0x0000000181377E50
			private void _InternalTick() {} // 0x0000000184088E70-0x0000000184088E80
		}
	
		private struct FWork // TypeDefIndex: 54037
		{
			// Fields
			public static readonly FWork IDLE; // 0x00
			private bool _didFallback_k__BackingField; // 0x00
			private int _nodeIndex_k__BackingField; // 0x04
			private bool _isWorking_k__BackingField; // 0x08
	
			// Properties
			public bool didFallback { get; private set; } // 0x000000018476C0A0-0x000000018476C0E0 
			public int nodeIndex { get; private set; } // 0x0000000187930F00-0x0000000187930F4C
			public bool isWorking { get; private set; } // 0x0000000187930F4C-0x0000000187930F98 0x000000018476C140-0x000000018476C170
			public ENode curNode { get => default; }
	
			// Constructors
			static FWork() {
				IDLE = default;
			} // 0x00000001813B4840-0x00000001813B4850
	
			// Methods
			public void MarkFallback(int newIndex) {} // 0x00000001858C7E30-0x00000001858C7E60
			public bool ConsumeFallback() => default; // 0x00000001855A6C40-0x00000001855A6C80
			public void MoveNextIndex() {} // 0x0000000185492010-0x0000000185492020
			public static FWork Start() => default;
			public bool WorkEnd() => default; // 0x00000001813B31B0-0x00000001813B31C0
		}
	
		private sealed class _DoWorkFlow_d__25 : IEnumerator<object> // TypeDefIndex: 54038
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001864721F0-0x0000000186472200 
			object IEnumerator.Current { get => default; } // 0x0000000185F52420-0x0000000185F524A0 
	
			// Constructors
			public _DoWorkFlow_d__25() {} // Dummy constructor
			public _DoWorkFlow_d__25(int __1__state) {} // 0x00000001813B34D0-0x00000001813B34E0
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001813B4850-0x00000001813B4860
			private bool MoveNext() => default; // 0x00000001813B51D0-0x00000001813B51E0
			void IEnumerator.Reset() {} // 0x0000000187936304-0x0000000187936850
		}
	
		private sealed class __FetchAgeTipsCoroutine_d__45 : IEnumerator<object> // TypeDefIndex: 54039
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001858E2F30-0x00000001858E2FC0 
			object IEnumerator.Current { get => default; } // 0x0000000185EE4B10-0x0000000185EE4BD0 
	
			// Constructors
			public __FetchAgeTipsCoroutine_d__45() {} // Dummy constructor
			public __FetchAgeTipsCoroutine_d__45(int __1__state) {} // 0x000000018525CBA0-0x000000018525CC50
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001856A59C0-0x00000001856A5A40
			private bool MoveNext() => default; // 0x0000000184F105A0-0x0000000184F105E0
			void IEnumerator.Reset() {} // 0x0000000184F10720-0x0000000184F10B50
		}
	
		private sealed class __AdjustCurrentGameState_d__47 : IEnumerator<object> // TypeDefIndex: 54040
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ENode curNode; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public __AdjustCurrentGameState_d__47() {} // Dummy constructor
			public __AdjustCurrentGameState_d__47(int __1__state) {} // 0x0000000181378230-0x0000000181378240
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000184F105E0-0x0000000184F10720
			void IEnumerator.Reset() {} // 0x0000000187932360-0x00000001879323AC
		}
	
		// Constructors
		public LoginWorkFlow() {} // Dummy constructor
		public LoginWorkFlow(LoginContext context) {} // 0x000000018792F8FC-0x000000018792F980
		static LoginWorkFlow() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static void MarkEnteredPreloadThisSession() {} // 0x00000001835E3010-0x00000001835E3020
		public static void ClearEnteredPreloadThisSession() {} // 0x0000000185FB0F60-0x0000000185FB0F70
		public static bool HasEnteredPreloadThisSession() => default; // 0x000000018357CBC0-0x000000018357CBD0
		private Node[] _RegisterNodes() => default; // 0x0000000185FB2BA0-0x0000000185FB2BB0
		public IEnumerator DoWorkFlow() => default; // 0x0000000185A59FD0-0x0000000185A5A030
		public void Dispose() {} // 0x0000000185A812C0-0x0000000185A813B0
		public bool PeekFallbackStatus(out ENode fallbackNode) {
			fallbackNode = default;
			return default;
		} // 0x0000000185F402A0-0x0000000185F40330
		public bool Fallback(ENode target, bool validCheck = true /* Metadata: 0x02078FCA */) => default; // 0x00000001859F2220-0x00000001859F22D0
		public bool CancelAndFallback(ENode target, bool validCheck = true /* Metadata: 0x02078FCB */) => default; // 0x00000001858B96E0-0x00000001858B9B70
		public void SendEvent(ELoginEvent evt, object param = null) {} // 0x0000000185492010-0x0000000185492020
		public void AddEventReceiver(IEventReceiver receiver) {} // 0x0000000181378230-0x0000000181378240
		public bool UpdateOnce(IWorkerUpdateOnce inst) => default; // 0x0000000185492010-0x0000000185492020
		public static bool IsBeforeWork(ENode curNode, ENode check) => default; // 0x0000000181852A70-0x00000001818553B0
		public static bool IsOnOrAfterWork(ENode curNode, ENode check) => default; // 0x0000000181377E40-0x0000000181377E50
		public static bool IsAfterWork(ENode target, ENode check) => default; // 0x00000001818553B0-0x0000000181855400
		private bool _HandleGlobalEvent(ELoginEvent evt, object param) => default; // 0x0000000181377E40-0x0000000181377E50
		private void _EventOnOpenAgeTips() {} // 0x0000000181378230-0x0000000181378240
		private void _EventOnCloseAgeTips() {} // 0x0000000185492010-0x0000000185492020
		private void _EventOnOpenServerSelect(bool isOpen) {} // 0x00000001818635D0-0x0000000181865530
		private void _EventOnSelectServer(ServerZoneManager.ServerZoneData serverZoneData) {} // 0x0000000181377E40-0x0000000181377E50
		private void _EventOnConfirmServer() {} // 0x0000000181865530-0x0000000181865580
		private void _EnableCursor(bool enabled) {} // 0x0000000181377E40-0x0000000181377E50
		private void _UpdateCursor(in EventData<Beyond.DeviceInfo.InputType> input) {} // 0x0000000181378230-0x0000000181378240
		private void _EnbaleToggleGroup() {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator _FetchAgeTipsCoroutine(LoginAgeTipsProp prop) => default; // 0x0000000181855430-0x00000001818560E0
		private static bool _CheckIfGameStateNotMatch(ENode curNode) => default; // 0x0000000181377E40-0x0000000181377E50
		private static IEnumerator _AdjustCurrentGameState(ENode curNode) => default; // 0x00000001818560E0-0x0000000181856130
	}

	public class HotUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 54042
	{
		// Fields
		private LoginHotUpdater m_updater; // 0x20
		private int m_cachedResRepairCode; // 0x28
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000181D409B0-0x0000000181D40CF0 
	
		// Constructors
		public HotUpdateNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000184B90110-0x0000000184B916A0
		public override void OnDispose() {} // 0x00000001858C7D90-0x00000001858C7DF0
		public void __iFixBaseProxy_OnDispose() {} // 0x00000001879260B0-0x00000001879260B8
	}

	public abstract class WaitForSecondsNode : LoginWorkFlow.Node // TypeDefIndex: 54043
	{
		// Fields
		private int? m_timerId; // 0x20
	
		// Constructors
		protected WaitForSecondsNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000185259CB0-0x0000000185259E60
		private bool _IsTimeout() => default; // 0x0000000185A5F340-0x0000000185A5F390
		private void _NotifyTimeout() {} // 0x0000000185F664E0-0x0000000185F66510
		private void _DisposeTimer() {} // 0x00000001858C7E60-0x00000001858C7ED0
		protected abstract float WaitForSeconds(out bool unscaled);
		public override void OnDispose() {} // 0x00000001858C7DF0-0x00000001858C7E30
		public void __iFixBaseProxy_OnDispose() {} // 0x00000001879260B0-0x00000001879260B8
	}

	public class PreloadPostDelayNode : WaitForSecondsNode // TypeDefIndex: 54044
	{
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183056920-0x0000000183056930 
	
		// Constructors
		public PreloadPostDelayNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override float WaitForSeconds(out bool unscaled) {
			unscaled = default;
			return default;
		} // 0x0000000185FA4220-0x0000000185FA4260
		public override CustomYieldInstruction Work() => default; // 0x0000000185259630-0x0000000185259670
		private void _DisableLoadingPanel() {} // 0x0000000185257260-0x0000000185257320
		public CustomYieldInstruction __iFixBaseProxy_Work() => default; // 0x00000001879310E4-0x00000001879310EC
	}

	public class Trans2GsLoginNode : WaitForSecondsNode // TypeDefIndex: 54045
	{
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000185FB6A00-0x0000000185FB6A10 
	
		// Constructors
		public Trans2GsLoginNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override float WaitForSeconds(out bool unscaled) {
			unscaled = default;
			return default;
		} // 0x0000000184B916A0-0x0000000184B91750
		public override CustomYieldInstruction Work() => default; // 0x0000000185259670-0x00000001852596E0
		public CustomYieldInstruction __iFixBaseProxy_Work() => default; // 0x00000001879310E4-0x00000001879310EC
	}

	public class FinishNode : LoginWorkFlow.Node // TypeDefIndex: 54046
	{
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000181B75270-0x0000000181B75280 
	
		// Constructors
		public FinishNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x00000001852596E0-0x0000000185259760
	}

	public struct CarrierDownloadCache // TypeDefIndex: 54047
	{
		// Fields
		public static readonly CarrierDownloadCache EMPTY; // 0x00
		public long size; // 0x00
		public bool isAllowed; // 0x08
	
		// Constructors
		static CarrierDownloadCache() {
			EMPTY = default;
		} // 0x0000000185F861B0-0x0000000185F862D0
	}

	public class NetUsagePolicy // TypeDefIndex: 54050
	{
		// Fields
		private const int NOT_REACHABLE_ERROR_CODE = 30000; // Metadata: 0x02078FE1
		private CarrierDownloadCache m_mobileDataCache; // 0x10
		private NetworkReachability m_lastNetworkState; // 0x20
		private Options m_options; // 0x28
	
		// Nested types
		public struct Options // TypeDefIndex: 54048
		{
			// Fields
			public long minBytesToNotifyCarrier; // 0x00
		}
	
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 54049
		{
			// Fields
			public long downloadSize; // 0x10
			public NetUsagePolicy __4__this; // 0x18
			public Action onAllowed; // 0x20
			public Action onRejected; // 0x28
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x00000001844ED7F0-0x00000001844ED860
	
			// Methods
			internal void _CheckIfAllowDownload_b__0() {} // 0x0000000187930B28-0x0000000187930E78
			internal void _CheckIfAllowDownload_b__1() {} // 0x0000000187930AD0-0x0000000187930B28
		}
	
		// Constructors
		public NetUsagePolicy() {} // Dummy constructor
		public NetUsagePolicy(Options options) {} // 0x0000000187930E78-0x0000000187930F00
	
		// Methods
		public void CheckIfAllowDownload(long downloadSize, Action onAllowed, Action onRejected, Action onReachable = null) {} // 0x0000000185492010-0x0000000185492020
		public bool AllowMobileDataInLastCheck() => default; // 0x000000018793220C-0x000000018793228C
		private static string _GetPrettySizeStringUpToMB(double number) => default; // 0x000000018793228C-0x00000001879322FC
	}

	public class LoginSceneAnimCtrl : LoginSceneComponent, ILoginBinder<LoginViewModel>, IAnimationClipSource // TypeDefIndex: 54052
	{
		// Fields
		private const float COUNT_DOWN_EMPTY = -1f; // Metadata: 0x02078FE5
		private Animator _target; // 0x78
		private AnimationClip _clipA1; // 0x80
		private AnimationClip _clipA1s; // 0x88
		private float _transA1; // 0x90
		private float _transA1s; // 0x94
		private UnityEngine.Vector2 _randomRangeA1s; // 0x98
		private AnimationClip _clipA1A2; // 0xA0
		private float _predelayA1A2; // 0xA8
		private float _transA1A2; // 0xAC
		private AnimationClip _clipA2; // 0xB0
		private float _transA2; // 0xB8
		private UIAnimationMixPlayer m_player; // 0xC0
		private EState m_state; // 0xC8
		private float m_countDownA1s; // 0xCC
		private float m_countDownA1A2; // 0xD0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Nested types
		private enum EState // TypeDefIndex: 54051
		{
			NONE = 0,
			A1 = 1,
			A2 = 2
		}
	
		// Constructors
		public LoginSceneAnimCtrl() {} // 0x0000000185D912F0-0x0000000185D91350
	
		// Methods
		protected override void OnBindToManager() {} // 0x0000000184B91B00-0x0000000184B91B80
		private UIAnimationMixPlayer _EnsurePlayer() => default; // 0x0000000184F427B0-0x0000000184F42880
		private void _ChangeToState(EState target) {} // 0x000000018420DD70-0x000000018420DDF0
		private void _ResetToA1() {} // 0x0000000184F423E0-0x0000000184F425B0
		private void _TransitionToA2() {} // 0x0000000185B966E0-0x0000000185B967C0
		private void _PlayA1sAndTriggerNext() {} // 0x0000000184F42240-0x0000000184F423E0
		private float _RandomIntervalA1s() => default; // 0x0000000184F42A00-0x0000000184F42B20
		private void _PlayA1A2Impl() {} // 0x0000000184F425B0-0x0000000184F427B0
		public void OnValueChanged(LoginViewModel value) {} // 0x000000018420DCD0-0x000000018420DD70
		protected override void Start() {} // 0x000000018425EF90-0x000000018425F040
		public override void Tick(float deltaTime) {} // 0x00000001844C1C30-0x00000001844C1EE0
		protected override void OnRelease() {} // 0x0000000185B730A0-0x0000000185B73170
		public void GetAnimationClips(List<AnimationClip> results) {} // 0x000000018792FDB0-0x000000018792FE04
		public void __iFixBaseProxy_OnBindToManager() {} // 0x000000018792FE04-0x000000018792FE0C
		public void __iFixBaseProxy_Start() {} // 0x000000018792FE14-0x000000018792FE1C
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
	}

	public abstract class LoginSceneComponent : TickableMono // TypeDefIndex: 54053
	{
		// Fields
		private LoginContext _context_k__BackingField; // 0x68
		private LoginController _controller_k__BackingField; // 0x70
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001813AE580-0x00000001813AE590 
		protected LoginContext context { get; private set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		protected LoginController controller { get; private set; } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
	
		// Constructors
		protected LoginSceneComponent() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected virtual void Start() {} // 0x000000018425F0C0-0x000000018425F130
		public void Bind(LoginContext context, LoginController controller) {} // 0x0000000184B90000-0x0000000184B90070
		protected virtual void OnBindToManager() {} // 0x0000000184B91E10-0x0000000184B91E40
	}

	public class LoginSceneRoot : LoginSceneComponent // TypeDefIndex: 54054
	{
		// Properties
		protected override TickType tickOption { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public LoginSceneRoot() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected override void OnBindToManager() {} // 0x0000000184B92490-0x0000000184B92640
		public void __iFixBaseProxy_OnBindToManager() {} // 0x000000018792FE04-0x000000018792FE0C
	}

	public class LoginAgeTipsDetailPanel : MonoBehaviour, ILoginBinder<LoginAgeTipsModel> // TypeDefIndex: 54055
	{
		// Fields
		private UIAnimationWrapper _anim; // 0x18
		private RectTransform _content; // 0x20
		private UIText _txtTitle; // 0x28
		private UIText _lineTmpl; // 0x30
		private UIButton _btnClose; // 0x38
		private UIScrollRect _scroll; // 0x40
		private InputBindingGroupMonoTarget _ageTipsBindingGroup; // 0x48
		private LoginContext m_context; // 0x50
		private UISwitchTween m_switchTween; // 0x58
		private DG.Tweening.Tween m_displayDelayTween; // 0x60
		private const int MAX_TEXT_STRLEN = 10000; // Metadata: 0x02078FEC
		private const int MIN_TEXT_STRLEN = 1000; // Metadata: 0x02078FF0
	
		// Constructors
		public LoginAgeTipsDetailPanel() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Init(LoginContext context) {} // 0x00000001849D9300-0x00000001849D94A0
		public void OnValueChanged(LoginAgeTipsModel value) {} // 0x0000000185EBAE70-0x0000000185EBAF30
		private void _RenderContent(string contentStr) {} // 0x0000000187937F84-0x00000001879380F4
		private void _ShowContent() {} // 0x00000001879380F4-0x0000000187938150
		private void _EventOnCloseClicked(PointerEventData _) {} // 0x0000000187937F0C-0x0000000187937F84
		private static List<string> _SplitLicenseToSegments(string content) => default; // 0x0000000187938150-0x0000000187938434
		private static void _SplitLongString(string longStr, List<string> outputList) {} // 0x0000000187938434-0x0000000187938500
	}

	public class LoginAgeTipsPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 54056
	{
		// Fields
		private LoginAgeTipsDetailPanel _detailPanel; // 0x28
		private UIButton _ageTipsCN; // 0x30
		private GameObject _ageTipsKR; // 0x38
		private CanvasGroup _canvasVersionTop; // 0x40
	
		// Constructors
		public LoginAgeTipsPanel() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnInit() {} // 0x0000000185AE46F0-0x0000000185AE4810
		public void OnValueChanged(LoginViewModel value) {} // 0x000000018420F510-0x000000018420F5A0
		private void _UpdateAgeTipsPolicy(LoginViewModel.FAgeTipsPolicy policy) {} // 0x000000018420FBF0-0x000000018420FC70
		private void _EventOnOpenAgeTipsClicked(PointerEventData _) {} // 0x0000000187938508-0x0000000187938580
		public void __iFixBaseProxy_OnInit() {} // 0x0000000187938500-0x0000000187938508
	}

	public class LoginAlertDialog : LoginController.Dialog // TypeDefIndex: 54058
	{
		// Fields
		private UIButton _btnConfirm; // 0x38
		private UIText _text; // 0x40
		private FParams m_params; // 0x48
	
		// Nested types
		public struct FParams // TypeDefIndex: 54057
		{
			// Fields
			public string text; // 0x00
			public Action onConfirm; // 0x08
		}
	
		// Constructors
		public LoginAlertDialog() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnInit() {} // 0x0000000187938580-0x0000000187938664
		public void SetParams(FParams param) {} // 0x0000000187938664-0x00000001879386EC
		private void _OnConfirmClicked(PointerEventData evt) {} // 0x00000001879386F4-0x0000000187938758
		public void __iFixBaseProxy_OnInit() {} // 0x00000001879386EC-0x00000001879386F4
	}

	public class LoginDecorateUI : TickableUIMono, ILoginBinder<LoginViewModel>, ILoginContextReceiver // TypeDefIndex: 54059
	{
		// Fields
		private CanvasGroup _imgLogo; // 0x68
		private float _durationLogo; // 0x70
		private AnimationClip _clipLoopGlow; // 0x78
		private AnimationClip _clipInGlow; // 0x80
		private Animator _targetGlow; // 0x88
		private float _delay; // 0x90
		private LoginContext m_context; // 0x98
		private bool m_isOnTransNode; // 0xA0
		private Interpolator.FLerpByTime m_hideLogoLerp; // 0xA8
		private UIAnimationLayerMixPlayer m_glowPlayer; // 0xC8
		private bool m_isGlowEnabled; // 0xD0
		private float m_countDownDelay; // 0xD4
		private float m_countDownDisableGlow; // 0xD8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public LoginDecorateUI() {} // 0x0000000185EC3A40-0x0000000185EC3AE0
	
		// Methods
		public void OnLoginContext(LoginContext context) {} // 0x0000000184B92760-0x0000000184B92810
		public void OnValueChanged(LoginViewModel value) {} // 0x000000018420F700-0x000000018420F8B0
		private void _TriggerTrans2GSLoginImpl() {} // 0x0000000184F41EA0-0x0000000184F42020
		private void _ToggleGlow(bool enable) {} // 0x0000000184F42020-0x0000000184F42130
		private UIAnimationLayerMixPlayer _EnsureGlowPlayer() => default; // 0x0000000184F42130-0x0000000184F42240
		public override void Tick(float deltaTime) {} // 0x0000000184F41AE0-0x0000000184F41B70
		protected override void OnRelease() {} // 0x0000000185B73020-0x0000000185B730A0
		private void _TimeManagerTick(float timeDelta) {} // 0x0000000184F41B70-0x0000000184F41DA0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
	}

	public class LoginEnterGamePanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 54060
	{
		// Fields
		private CanvasGroup _canvasGroup; // 0x28
		private UIButton _btnEnterGame; // 0x30
		private UIText _textEnterGame; // 0x38
		private float _delayEnterGame; // 0x40
		private bool m_isPanelActive; // 0x44
		private double m_panelActiveTime; // 0x48
		private bool m_isInited; // 0x50
	
		// Constructors
		public LoginEnterGamePanel() {} // 0x0000000185F38910-0x0000000185F38920
	
		// Methods
		private void _InitIfNot() {} // 0x0000000185D902C0-0x0000000185D90390
		public void OnValueChanged(LoginViewModel value) {} // 0x000000018420FB00-0x000000018420FBF0
		private void _OnEnterGameClicked(PointerEventData evt) {} // 0x00000001855A6700-0x00000001855A67B0
	}

	public class LoginGovTipsPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 54061
	{
		// Fields
		private UIButton _btnOpen; // 0x28
	
		// Constructors
		public LoginGovTipsPanel() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnInit() {} // 0x0000000185AE4810-0x0000000185AE48E0
		public void OnValueChanged(LoginViewModel value) {} // 0x000000018420F400-0x000000018420F460
		private void _EventOnOpenAgeTipsClicked(PointerEventData _) {} // 0x0000000187938758-0x00000001879387C0
		public void __iFixBaseProxy_OnInit() {} // 0x0000000187938500-0x0000000187938508
	}

	public class LoginJudgeDialog : LoginController.Dialog // TypeDefIndex: 54064
	{
		// Fields
		private UIButton _btnPositive; // 0x38
		private UIButton _btnNegative; // 0x40
		private UIText _text; // 0x48
		private UIText _text2; // 0x50
		private UIText _textPositive; // 0x58
		private UIText _textNegative; // 0x60
		private FParams m_params; // 0x68
	
		// Nested types
		public enum Style // TypeDefIndex: 54062
		{
			Center = 0,
			Left = 1
		}
	
		public struct FParams // TypeDefIndex: 54063
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
		public LoginJudgeDialog() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnInit() {} // 0x00000001879387C0-0x000000018793890C
		public void SetParams(FParams param) {} // 0x000000018793890C-0x0000000187938B50
		private void _OnPositiveClicked(PointerEventData evt) {} // 0x0000000187938BB4-0x0000000187938C18
		private void _OnNegativeClicked(PointerEventData evt) {} // 0x0000000187938B50-0x0000000187938BB4
		public void __iFixBaseProxy_OnInit() {} // 0x00000001879386EC-0x00000001879386F4
	}

	public class LoginMenuPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 54066
	{
		// Fields
		public const string CONTROLLER_STATE_NORMAL = "Normal"; // Metadata: 0x02078FF4
		public const string CONTROLLER_STATE_SELECT = "Select"; // Metadata: 0x02078FFB
		private UIButton _btnAnnounce; // 0x28
		private UIButton _btnSetting; // 0x30
		private UIButton _btnResCheck; // 0x38
		private UIButton _btnLogout; // 0x40
		private UIButton _btnQuitGame; // 0x48
		private UIButton _btnLogin; // 0x50
		private UIButton _btnQR; // 0x58
		private UIStateController _ctrlAnnounce; // 0x60
		private UIStateController _ctrlSetting; // 0x68
		private UIStateController _ctrlResCheck; // 0x70
		private UIStateController _ctrlLogout; // 0x78
		private UIStateController _ctrlQR; // 0x80
		private UISimpleStateController _ctrlRight; // 0x88
		private UISelectableNaviGroup _naviGroupRight; // 0x90
		private InputBindingGroupMonoTarget _bindingGroupForKeyboard; // 0x98
		private InputBindingGroupMonoTarget _rootPanelBindingGroup; // 0xA0
		private CanvasGroup _alphaHandler; // 0xA8
		private GameObject _redDotAnnounce; // 0xB0
		private UIAnimationWrapper _transAnim; // 0xB8
		private UIButton _serverZoneBtn; // 0xC0
		private UIText _serverZoneName; // 0xC8
		private GameObject _serverZonePS5; // 0xD0
		private UIText _serverZoneNamePS5; // 0xD8
		private UIStateController m_curRightBtnCtrl; // 0xE0
		private bool m_hasRedDot; // 0xE8
		private int m_rootParentGroupId; // 0xEC
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 54065
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__43_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000184B60CE0-0x0000000184B613E0
			public __c() {} // 0x000000018420DEC0-0x000000018420F400
	
			// Methods
			internal void __OnQuitGameClicked_b__43_0() {} // 0x00000001859A0810-0x00000001859A0910
		}
	
		// Constructors
		public LoginMenuPanel() {} // 0x0000000187938D30-0x0000000187938DBC
	
		// Methods
		protected override void OnInit() {} // 0x0000000185FA2C30-0x0000000185FA2CA0
		public void OnValueChanged(LoginViewModel value) {} // 0x0000000185F8A830-0x0000000185F8A8C0
		public void InitBulletinAndRedAfterLoginSuc() {} // 0x0000000185EBCA70-0x0000000185EBCB60
		private static void _OnBulletinOpen() {} // 0x00000001850D5A20-0x00000001850D5C20
		private static void _OnBulletinClose() {} // 0x00000001850D5C20-0x00000001850D5E10
		private void Awake() {} // 0x0000000184B8BC60-0x0000000184B8BD50
		private void OnEnable() {} // 0x0000000187939048-0x00000001879391E0
		private void OnDisable() {} // 0x0000000187939A7C-0x0000000187939B68
		protected override void OnDestroy() {} // 0x0000000187939948-0x0000000187939A10
		private void _OnAnnounceClicked(PointerEventData _) {} // 0x0000000187939280-0x0000000187939330
		private void _OnSettingClicked(PointerEventData _) {} // 0x0000000187938F80-0x0000000187939048
		private void _OnResCheckClicked(PointerEventData _) {} // 0x00000001879395C4-0x000000018793968C
		private void _OnCustomServiceClicked(PointerEventData _) {} // 0x000000018793973C-0x00000001879398DC
		private void _OnAccountCenterClicked(PointerEventData _) {} // 0x000000018793954C-0x00000001879395C4
		private void _OnLogoutClicked(PointerEventData _) {} // 0x000000018793968C-0x000000018793973C
		private void _OnQuitGameClicked(PointerEventData _) {} // 0x00000001879398DC-0x0000000187939948
		private void _OnLoginClicked(PointerEventData _) {} // 0x0000000185F86980-0x0000000185F869B0
		private void _OnQRClicked(PointerEventData _) {} // 0x00000001859A0910-0x00000001859A0990
		private void _OnRequestRelogin() {} // 0x00000001855A7D60-0x00000001855A7E50
		private bool _CanQRLogin() => default; // 0x0000000187939A10-0x0000000187939A7C
		private void _UpdateAnnounceRedDot() {} // 0x0000000187939330-0x0000000187939420
		private void _UpdateServerZone() {} // 0x00000001879391E0-0x0000000187939280
		private void _OnServerZoneBtnClicked() {} // 0x00000001859A0A30-0x00000001859A1860
		private void _OnFocusMenuGroup(bool isFocused) {} // 0x00000001859A07D0-0x00000001859A0810
		private void _OnAnnounceClosed() {} // 0x0000000187939420-0x000000018793954C
		private void _OnReceiveRedDotAndPopup(bool showRedDot) {} // 0x0000000185F38920-0x0000000185F38940
		private void _OnUpdateRedDotForSDKListener(in EventData<bool> show) {} // 0x0000000187938C18-0x0000000187938CA4
		private void _OnInputChanged(in EventData<Beyond.DeviceInfo.InputType> input) {} // 0x0000000187938CA4-0x0000000187938D30
		private void _OnInit_b__28_0(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain) {} // 0x0000000187938DBC-0x0000000187938E48
		private void _OnInit_b__28_1(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain) {} // 0x0000000187938E48-0x0000000187938EDC
		private void _OnInit_b__28_2(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain) {} // 0x0000000187938EDC-0x0000000187938EE4
		private void _OnInit_b__28_3(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain) {} // 0x0000000187938EE4-0x0000000187938EEC
		private void _OnInit_b__28_4(bool isTarget, bool isGroupChanged, bool isOnNaviTargetEnabledAgain) {} // 0x0000000187938EF4-0x0000000187938F80
		private void _OnInit_b__28_5(PointerEventData _) {} // 0x0000000187938500-0x0000000187938508
		private void _OnInit_b__28_6(bool isFocused) {} // 0x0000000187938EEC-0x0000000187938EF4
		private void __OnAnnounceClicked_b__37_0(string s) {} // 0x000000018793D4D0-0x000000018793D534
		public void __iFixBaseProxy_OnInit() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018793CB9C-0x000000018793D0F4
	}

	public class LoginMockUIDPanel : MonoBehaviour // TypeDefIndex: 54069
	{
		// Fields
		private CanvasGroup _canvas; // 0x18
		private UIInputField _userIdInputField; // 0x20
		private UIButton _btnEnterGame; // 0x28
		private UIButton _btnDelLocalFile; // 0x30
		private UIDropdown _serverDropdown; // 0x38
		private GameObject _hintSelectServer; // 0x40
		private UIButton _btnClose; // 0x48
		private UIText _selectedServerLabel; // 0x50
		private bool m_isInited; // 0x58
		private UISwitchTween m_switchTween; // 0x60
		private List<ServerDesc> m_serverDescList; // 0x68
		private ServerList m_serverListObj; // 0x70
		private ServerConfig m_serverConfig; // 0x78
		private Action<string> m_callback; // 0x80
		private FOptions m_options; // 0x88
		private static LoginMockUIDPanel s_instance; // 0x00
	
		// Properties
		public static LoginMockUIDPanel instance { get => default; } // 0x0000000185F0AD50-0x0000000185F0ADD0 
	
		// Nested types
		public struct FOptions // TypeDefIndex: 54067
		{
			// Fields
			public string fixedUID; // 0x00
			public LoginContext context; // 0x08
	
			// Methods
			public bool IsUIDFixed() => default; // 0x0000000187939D60-0x0000000187939D98
		}
	
		private sealed class _HideAndDestroy_d__21 : IEnumerator<object> // TypeDefIndex: 54068
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginMockUIDPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185047CA0-0x0000000185047E70 
			object IEnumerator.Current { get => default; } // 0x0000000185049F90-0x000000018504A010 
	
			// Constructors
			public _HideAndDestroy_d__21() {} // Dummy constructor
			public _HideAndDestroy_d__21(int __1__state) {} // 0x0000000184B8B0C0-0x0000000184B8B1F0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000187939B68-0x0000000187939BB8
			private bool MoveNext() => default; // 0x0000000184B92F00-0x0000000184B92F70
			void IEnumerator.Reset() {} // 0x0000000185049800-0x0000000185049B10
		}
	
		// Constructors
		public LoginMockUIDPanel() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void LoginWithCallback(FOptions options, Action<string> callback) {} // 0x0000000187939C0C-0x0000000187939CC4
		public void Refresh() {} // 0x0000000187939BC8-0x0000000187939C0C
		public IEnumerator HideAndDestroy() => default; // 0x0000000187939CC4-0x0000000187939D60
		private void _UpdateStatus() {} // 0x0000000185049EA0-0x0000000185049F30
		private void _InitLoginInfo() {} // 0x0000000184B8BC20-0x0000000184B8BC60
		private void _SaveConfig() {} // 0x000000018646DB20-0x000000018646DB28
		private void _OnBtnEnterGame() {} // 0x0000000185F0AD40-0x0000000185F0AD50
		private void _SmokeEnterGame(string serverName, string uid) {} // 0x0000000187939BB8-0x0000000187939BC0
		private void _OnBtnDelLocalFile() {} // 0x0000000187939BC0-0x0000000187939BC8
		private void _TryClosePanel() {} // 0x0000000184BC61E0-0x0000000184BC6260
		private void _OnSelectServer(int index) {} // 0x0000000185047E70-0x0000000185047EB0
		private void OnDestroy() {} // 0x0000000181378230-0x0000000181378240
		private void __UpdateStatus_b__22_0(PointerEventData _) {} // 0x0000000184B8EF90-0x0000000184B8F0A0
		private void __UpdateStatus_b__22_1(PointerEventData _) {} // 0x0000000181377E40-0x0000000181377E50
		private void __UpdateStatus_b__22_2(PointerEventData _) {} // 0x000000018793CB50-0x000000018793CB9C
		private void __InitLoginInfo_b__23_0(int index, UIDropdownOption options, bool isSelected) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class LoginResourcePanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginHotUpdateModel> // TypeDefIndex: 54070
	{
		// Fields
		private const float PROGRESS_LERP_DURATION = 0.2f; // Metadata: 0x02079002
		private CanvasGroup _alphaHandler; // 0x28
		private UISlider _progressBar; // 0x30
		private UIText _textTitle; // 0x38
		private UIText _textInfo; // 0x40
		private LoginHotUpdateModel.IProgress m_progress; // 0x48
		private TweenUtils.FLerpByTime m_progressLerper; // 0x50
		private string m_resInfoCache; // 0x80
	
		// Constructors
		public LoginResourcePanel() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void OnValueChanged(LoginHotUpdateModel value) {} // 0x0000000185BA7960-0x0000000185BA7A10
		private void _UpdateResourceInfo() {} // 0x0000000184232370-0x0000000184232510
		private void Update() {} // 0x0000000184232210-0x0000000184232340
	}

	public class LoginRootPanel : MonoBehaviour // TypeDefIndex: 54072
	{
		// Fields
		private NotchAdapter _notchAdapter; // 0x18
		private LoginMenuPanel _menuPanel; // 0x20
		private LoginAgeTipsPanel _ageTipsPanel; // 0x28
		private LoginGovTipsPanel _govTipsPanel; // 0x30
		private LoginResourcePanel _resPanel; // 0x38
		private LoginEnterGamePanel _enterGamePanel; // 0x40
		private LoginServerSelectPanel _serverSelectPanel; // 0x48
		private InputBindingGroupMonoTarget _bindingGroup; // 0x50
		private int m_loginRootBindingGroupId; // 0x58
	
		// Nested types
		public abstract class ChildPanel : MonoBehaviour, ILoginContextReceiver // TypeDefIndex: 54071
		{
			// Fields
			private UISwitchTween _switchTween_k__BackingField; // 0x18
			private LoginContext _context_k__BackingField; // 0x20
	
			// Properties
			protected UISwitchTween switchTween { get; private set; } // 0x00000001850D41A0-0x00000001850D42A0 0x00000001850D42A0-0x00000001850D4390
			protected LoginContext context { get; private set; } // 0x0000000184B91B80-0x0000000184B91C70 0x0000000187939E2C-0x0000000187939ED0
	
			// Constructors
			protected ChildPanel() {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			public void OnLoginContext(LoginContext context) {} // 0x00000001849D9230-0x00000001849D9300
			protected virtual void OnInit() {} // 0x0000000187939D98-0x0000000187939E2C
			protected virtual void OnDestroy() {} // 0x0000000184B92640-0x0000000184B92680
			protected void SetPanelVisibleByAnimSwitchTween(UIAnimationWrapper anim, bool isVisible, bool forceReset = false /* Metadata: 0x02079006 */) {} // 0x0000000184B91C70-0x0000000184B91DC0
			protected void SetPanelVisibleByFadeSwitchTween(CanvasGroup canvasGroup, bool isVisible, bool forceReset = false /* Metadata: 0x02079007 */) {} // 0x000000018646DB20-0x000000018646DB28
		}
	
		// Constructors
		public LoginRootPanel() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x0000000184088E70-0x0000000184088E80
		private void OnDestroy() {} // 0x00000001813B31A0-0x00000001813B31B0
		public void Init(LoginContext context) {} // 0x000000018646EE40-0x000000018646EE50
		private void _OnNotchPaddingChanged(in EventData<float> data) {} // 0x0000000184B91DC0-0x0000000184B91E10
		private void _InitController() {} // 0x0000000185AE48E0-0x0000000185AE4910
		public void ToggleLoginBindingGroup(bool enable) {} // 0x0000000184B8BE10-0x0000000184B8BE60
		public void InitBulletinAndRedAfterLoginSuc() {} // 0x0000000187936850-0x0000000187936948
		private static void _InitChildPanel(ChildPanel childPanel, LoginContext context) {} // 0x000000018420F8B0-0x000000018420F9A0
	}

	public class LoginServerSelectItemView : MonoBehaviour // TypeDefIndex: 54074
	{
		// Fields
		private UIText _serverName; // 0x18
		private UIImage _playerIcon; // 0x20
		private UIText _playerLevel; // 0x28
		private UIImage[] _delayImages; // 0x30
		private UIText _delayText; // 0x38
		private UIButton _btnSelect; // 0x40
		private UIStateController _stateController; // 0x48
		private static readonly UnityEngine.Color DEFAULT_COLOR; // 0x00
		private const string DEFAULT_TEXT = "--"; // Metadata: 0x02079008
		private static readonly DelayInfo DEFAULT_SPEED_INFO; // 0x10
		private ServerZoneManager.ServerZoneData m_serverItem; // 0x50
		private LoginContext m_context; // 0x58
		private List<DelayInfo> m_speedInfos; // 0x60
	
		// Nested types
		private struct DelayInfo // TypeDefIndex: 54073
		{
			// Fields
			public UnityEngine.Color color; // 0x00
			public int colorCount; // 0x10
			public int delayMax; // 0x14
			public string text; // 0x18
		}
	
		// Constructors
		public LoginServerSelectItemView() {} // 0x00000001857C3C90-0x00000001857C3FA0
		static LoginServerSelectItemView() {} // 0x0000000185ECA220-0x0000000185ECA2F0
	
		// Methods
		public void RefreshView(LoginContext context, ServerZoneManager.ServerZoneData serverItem, bool isSelected) {} // 0x0000000187939F60-0x000000018793A460
		public void NaviToBtnTarget() {} // 0x0000000187939ED0-0x0000000187939F60
		public void SetSelected(bool isSelected) {} // 0x000000018793A460-0x000000018793A504
		private void _OnClicked(PointerEventData _) {} // 0x000000018793A504-0x000000018793A57C
	}

	public class LoginServerSelectProp : LoginProperty<LoginServerSelectModel> // TypeDefIndex: 54075
	{
		// Constructors
		public LoginServerSelectProp() {} // Dummy constructor
		public LoginServerSelectProp(LoginWorkFlow workflow) {} // 0x0000000185256E10-0x0000000185256E60
	}

	public class LoginServerItem // TypeDefIndex: 54076
	{
		// Fields
		public ServerZoneManager.ServerZoneData serverZoneData; // 0x10
	
		// Constructors
		public LoginServerItem() {} // 0x0000000185492010-0x0000000185492020
	}

	public class LoginServerSelectModel // TypeDefIndex: 54077
	{
		// Fields
		public bool showPanel; // 0x10
		public int selectedIndex; // 0x14
	
		// Properties
		public List<ServerZoneManager.ServerZoneData> serverList { get => default; } // 0x000000018793A7B0-0x000000018793A844 
		public ServerZoneManager.ServerZoneData curServerZoneData { get => default; } // 0x000000018793A758-0x000000018793A7B0 
	
		// Constructors
		public LoginServerSelectModel() {} // 0x0000000185FB6AA0-0x0000000185FB6AB0
	
		// Methods
		public void InitData() {} // 0x000000018793A600-0x000000018793A668
		public ServerZoneManager.ServerZoneData GetSelectedServer() => default; // 0x000000018793A57C-0x000000018793A600
		public bool UpdateSelectedServer(ServerZoneManager.ServerZoneData selectedServer) => default; // 0x000000018793A668-0x000000018793A758
	}

	public class LoginServerSelectPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginServerSelectModel> // TypeDefIndex: 54080
	{
		// Fields
		private UIButton _btnBack; // 0x28
		private UIButton _btnConfirm; // 0x30
		private UIAnimationWrapper _showAnim; // 0x38
		private UIScrollList _showList; // 0x40
		private UISelectableNaviGroup _naviGroup; // 0x48
		private InputBindingGroupMonoTarget _bindingGroup; // 0x50
		private InputBindingGroupMonoTarget _rootPanelBindingGroup; // 0x58
		private LoginServerSelectModel m_viewModel; // 0x60
	
		// Nested types
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 54078
		{
			// Fields
			public LoginServerSelectPanel __4__this; // 0x10
			public List<ServerZoneManager.ServerZoneData> serverZoneDataList; // 0x18
			public List<SpeedTestServerInfo> serverList; // 0x20
			public Action<SpeedTestResult> callback; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x00000001849D8850-0x00000001849D8AE0
	
			// Methods
			internal void _OnEnable_b__0(SpeedTestResult result) {} // 0x000000018793A844-0x000000018793A948
			internal Task<Hypergryph.SpeedTest.TaskResult> _OnEnable_b__1() => default; // 0x000000018793A948-0x000000018793B36C
		}
	
		private sealed class __WaitingForShowListAwake_d__11 : IEnumerator<object> // TypeDefIndex: 54079
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LoginServerSelectPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018793B36C-0x000000018793B4C4 
			object IEnumerator.Current { get => default; } // 0x000000018793B6FC-0x000000018793B760 
	
			// Constructors
			public __WaitingForShowListAwake_d__11() {} // Dummy constructor
			public __WaitingForShowListAwake_d__11(int __1__state) {} // 0x000000018793B92C-0x000000018793B9BC
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018793B760-0x000000018793B86C
			private bool MoveNext() => default; // 0x000000018793B86C-0x000000018793B92C
			void IEnumerator.Reset() {} // 0x000000018793B4C4-0x000000018793B60C
		}
	
		// Constructors
		public LoginServerSelectPanel() {} // 0x000000018793D624-0x000000018793D670
	
		// Methods
		protected override void OnInit() {} // 0x000000018793B60C-0x000000018793B684
		private void OnDisable() {} // 0x000000018793B684-0x000000018793B6FC
		private void OnEnable() {} // 0x000000018646DB20-0x000000018646DB28
		private IEnumerator _WaitingForShowListAwake() => default; // 0x0000000187938500-0x0000000187938508
		private void _UpdateServerCell(GameObject cell, int index) {} // 0x0000000185492010-0x0000000185492020
		private void _UpdateServerSelected(int index, GameObject cell) {} // 0x000000018793D0F4-0x000000018793D468
		public void OnValueChanged(LoginServerSelectModel value) {} // 0x000000018793D468-0x000000018793D4D0
		private void _NaviToSelectedItem() {} // 0x0000000181378230-0x0000000181378240
		private void _OnInputChanged(in EventData<Beyond.DeviceInfo.InputType> input) {} // 0x0000000185492010-0x0000000185492020
		private void _OnCloseClicked(PointerEventData _) {} // 0x000000018793D534-0x000000018793D624
		private void _OnConfirmClicked(PointerEventData _) {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_OnInit() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class LoginVersionPanel : MonoBehaviour // TypeDefIndex: 54081
	{
		// Fields
		private UIText _textVersion; // 0x18
	
		// Properties
		public string displayGameVersion { get => default; } // 0x00000001859E47E0-0x00000001859E4980 
		private string versionZoneType { get => default; } // 0x00000001859E4AA0-0x00000001859E4AF0 
		private string versionPlatform { get => default; } // 0x00000001859E49B0-0x00000001859E49E0 
		private string versionAppType { get => default; } // 0x00000001859E4980-0x00000001859E49B0 
		private string versionVersionNum { get => default; } // 0x00000001859E4A20-0x00000001859E4A60 
		private string versionProjectCL { get => default; } // 0x00000001859E49E0-0x00000001859E4A20 
	
		// Constructors
		public LoginVersionPanel() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Start() {} // 0x00000001859E4740-0x00000001859E47E0
	}

	public class LoginVocResSelDialog : LoginController.Dialog // TypeDefIndex: 54084
	{
		// Fields
		private FParams m_params; // 0x38
		private UIButton _btnConfirm; // 0x40
		private UIScrollList _showList; // 0x48
		private UISelectableNaviGroup _naviGroup; // 0x50
		private InputBindingGroupMonoTarget _bindingGroup; // 0x58
		private List<VocResInfo> m_vocResInfos; // 0x60
		private int m_selectedIndex; // 0x68
	
		// Nested types
		public struct FParams // TypeDefIndex: 54082
		{
			// Fields
			public Action onConfirm; // 0x00
		}
	
		public class VocResInfo // TypeDefIndex: 54083
		{
			// Fields
			public string nameTextId; // 0x10
			public EVFSBlockType type; // 0x18
	
			// Constructors
			public VocResInfo() {} // 0x000000018793BBC8-0x000000018793BF48
		}
	
		// Constructors
		public LoginVocResSelDialog() {} // 0x00000001879386EC-0x00000001879386F4
	
		// Methods
		protected override void OnInit() {} // 0x000000018793BAC0-0x000000018793BBC8
		private void OnEnable() {} // 0x000000018793B9BC-0x000000018793BAC0
		private void OnDisable() {} // 0x000000018793BF48-0x000000018793BFAC
		public void SetParams(FParams param) {} // 0x000000018793BFAC-0x000000018793C0A0
		public void UpdateSelected(EVFSBlockType type) {} // 0x000000018793C550-0x000000018793C610
		private void _UpdateList() {} // 0x000000018793C610-0x000000018793C6C0
		private void _UpdateSelected(int index, GameObject cell) {} // 0x000000018793C470-0x000000018793C550
		private void _UpdateCell(GameObject cell, int index) {} // 0x000000018793C358-0x000000018793C40C
		private void _OnConfirmClicked(PointerEventData evt) {} // 0x000000018793C1D0-0x000000018793C358
		private void _OnConfirmClicked() {} // 0x000000018793C40C-0x000000018793C470
		private void _OnInputTypeChanged(in EventData<Beyond.DeviceInfo.InputType> data) {} // 0x000000018793C0A0-0x000000018793C1D0
		private void _NaviToSelectedItem() {} // 0x000000018646DB20-0x000000018646DB28
		public void __iFixBaseProxy_OnInit() {} // 0x0000000185492010-0x0000000185492020
	}

	public class LoginVocResSelItemView : MonoBehaviour // TypeDefIndex: 54085
	{
		// Fields
		private UIText _name; // 0x18
		private UIText _size; // 0x20
		private UIButton _btnSelect; // 0x28
		private UIStateController _stateController; // 0x30
		private LoginVocResSelDialog.VocResInfo m_info; // 0x38
		private LoginVocResSelDialog m_context; // 0x40
		private const double MB = 1048576; // Metadata: 0x0207900B
	
		// Constructors
		public LoginVocResSelItemView() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void RefreshView(LoginVocResSelDialog context, LoginVocResSelDialog.VocResInfo info, bool isSelected) {} // 0x000000018793C750-0x000000018793CA38
		public void NaviToBtnTarget() {} // 0x000000018793C6C0-0x000000018793C750
		public void SetSelected(bool isSelected) {} // 0x000000018793CA38-0x000000018793CADC
		private void _OnClicked(PointerEventData _) {} // 0x000000018793CADC-0x000000018793CB50
	}
}

namespace Beyond.SDK
{
	public class PlatformFont : IPlatformFont // TypeDefIndex: 53897
	{
		// Fields
		private const int DEFAULT_FONT_ID = -430371804; // Metadata: 0x02078DBB
		private readonly bool m_forceChineseFont; // 0x10
	
		// Constructors
		public PlatformFont() {} // Dummy constructor
		public PlatformFont(bool forceChineseFont = false /* Metadata: 0x02078DBA */) {} // 0x000000018184FBD0-0x000000018184FBE0
	
		// Methods
		public TMP_FontAsset GetFont() => default; // 0x0000000187929904-0x000000018792999C
	}

	public static class SDKNetUtils // TypeDefIndex: 53906
	{
		// Fields
		public const string CONTENT_TYPE_JSON = "application/json"; // Metadata: 0x02078DC0
		private const int GENERAL_TIMEOUT = 30; // Metadata: 0x02078DD1
		private static HTTPImpl s_HTTPImpl; // 0x00
	
		// Nested types
		public struct HttpPostRequest // TypeDefIndex: 53898
		{
			// Fields
			public string url; // 0x00
			public string param; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> header; // 0x18
			public Action<WebHttpResponse> callback; // 0x20
		}
	
		public struct HttpGetRequest // TypeDefIndex: 53899
		{
			// Fields
			public string url; // 0x00
			public Action<WebHttpResponse> callback; // 0x08
		}
	
		public struct WebHttpResponse // TypeDefIndex: 53900
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
	
		private enum HTTPOptType // TypeDefIndex: 53901
		{
			GET = 0,
			POST = 1
		}
	
		private struct HTTPConfig // TypeDefIndex: 53902
		{
			// Fields
			public string url; // 0x00
			public string body; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> header; // 0x18
			public HTTPOptType optType; // 0x20
			public Action<WebHttpResponse> callback; // 0x28
		}
	
		private abstract class HTTPImpl // TypeDefIndex: 53903
		{
			// Constructors
			protected HTTPImpl() {} // 0x000000018792999C-0x0000000187929AF4
	
			// Methods
			public abstract IEnumerator DoHTTP(HTTPConfig config); // 0x0000000187929AF4-0x0000000187929CE0
		}
	
		private class BeyondHttp : HTTPImpl // TypeDefIndex: 53905
		{
			// Nested types
			private sealed class _DoHTTP_d__0 : IEnumerator<object> // TypeDefIndex: 53904
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public HTTPConfig config; // 0x20
				private WaitForAsyncTask<HttpSender.Result> _sendTask_5__2; // 0x50
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187925578-0x0000000187925640 
				object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
				// Constructors
				public _DoHTTP_d__0() {} // Dummy constructor
				public _DoHTTP_d__0(int __1__state) {} // 0x0000000187929CE0-0x0000000187929D50
	
				// Methods
				void IDisposable.Dispose() {}
				private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
				void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
			}
	
			// Constructors
			public BeyondHttp() {} // 0x000000018792A02C-0x000000018792A2C8
	
			// Methods
			public override IEnumerator DoHTTP(HTTPConfig config) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		static SDKNetUtils() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static void HTTPPost(HttpPostRequest request) {} // 0x0000000181377E40-0x0000000181377E50
		public static void HTTPGet(HttpGetRequest request) {} // 0x000000018792A2C8-0x000000018792A314
	}

	public static class SDKTextDefines // TypeDefIndex: 53907
	{
		// Fields
		public const string CS_SDK_STO_DESC = "CS_SDK_STO_DESC"; // Metadata: 0x02078DD4
		public const string CS_SDK_COMMON_ERROR = "CS_SDK_COMMON_ERROR"; // Metadata: 0x02078DE4
		public const string CS_SDK_CREATE_ORDER_ERROR = "CS_SDK_CREATE_ORDER_ERROR"; // Metadata: 0x02078DF8
		public const string CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT = "CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT"; // Metadata: 0x02078E12
		public const string CS_SDK_USR_BAN = "CS_SDK_USR_BAN"; // Metadata: 0x02078E38
		public const string CS_SDK_USR_BAN_TIME = "CS_SDK_USR_BAN_TIME"; // Metadata: 0x02078E47
		public const string CS_SDK_LOGIN_FORBID = "CS_SDK_LOGIN_FORBID"; // Metadata: 0x02078E5B
		public const string CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT = "CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT"; // Metadata: 0x02078E6F
		public const string CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR = "CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR"; // Metadata: 0x02078E99
		public const string CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID = "CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID"; // Metadata: 0x02078EC1
	}
}

namespace Beyond.SDK.Impl
{
	public class U8ExternalTools : SDKExternalToolsShortcut // TypeDefIndex: 53915
	{
		// Fields
		private static bool s_inited; // 0x00
		private static bool s_initing; // 0x01
		private static bool s_needRetry; // 0x02
		private static bool s_needQuitGame; // 0x03
		private static FHGSDKInit s_initHGSDK; // 0x04
	
		// Nested types
		private struct FHGSDKInit // TypeDefIndex: 53908
		{
			// Fields
			public bool isIniting; // 0x00
			public bool isInited; // 0x01
		}
	
		private class CaptchaHandler : SDKCaptchaHandler // TypeDefIndex: 53910
		{
			// Fields
			private const int FAILED = 1000; // Metadata: 0x02078EE9
			private long m_flag; // 0x10
			private string m_desc; // 0x18
	
			// Nested types
			private sealed class _FetchCaptchaCoroutine_d__3 : IEnumerator<object> // TypeDefIndex: 53909
			{
				// Fields
				private int __1__state; // 0x10
				private object __2__current; // 0x18
				public string captchaParams; // 0x20
				public CaptchaHandler __4__this; // 0x28
				public SDKCaptchaHandler.Result outResult; // 0x30
	
				// Properties
				object IEnumerator<System.Object>.Current { get => default; } // 0x000000018792DDA0-0x000000018792DE40 
				object IEnumerator.Current { get => default; } // 0x0000000184B92FE0-0x0000000184B93300 
	
				// Constructors
				public _FetchCaptchaCoroutine_d__3() {} // Dummy constructor
				public _FetchCaptchaCoroutine_d__3(int __1__state) {} // 0x000000018792D9C0-0x000000018792DA2C
	
				// Methods
				void IDisposable.Dispose() {} // 0x0000000185F81EC0-0x0000000185F81F10
				private bool MoveNext() => default; // 0x0000000185CA6C90-0x0000000185CA6CE0
				void IEnumerator.Reset() {} // 0x0000000185F4E730-0x0000000185F4E7B0
			}
	
			// Constructors
			public CaptchaHandler() {} // 0x000000018792D954-0x000000018792D9C0
	
			// Methods
			public override IEnumerator FetchCaptchaCoroutine(string captchaParams, Result outResult) => default; // 0x0000000185CA6C30-0x0000000185CA6C90
			public void OnGT3Message(Dictionary<string, object> msg) {} // 0x0000000184F66680-0x0000000184F667F0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53911
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<object> __9__9_0; // 0x08
			public static Action<string> __9__9_1; // 0x10
			public static Action __9__27_0; // 0x18
	
			// Constructors
			static __c() {} // 0x0000000184FA9AC0-0x0000000184FA9B20
			public __c() {} // 0x000000018792DB0C-0x000000018792DB60
	
			// Methods
			internal void _InitSDKSystem_b__9_0(object error) {} // 0x000000018792DA2C-0x000000018792DAB8
			internal void _InitSDKSystem_b__9_1(string rawExtConfig) {} // 0x000000018792DAB8-0x000000018792DB0C
			internal void __ProcessExtraInfo_b__27_0() {} // 0x000000018792D8E8-0x000000018792D954
		}
	
		private sealed class _WaitForInited_d__10 : IEnumerator<object> // TypeDefIndex: 53912
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185839ED0-0x0000000185839F60 
			object IEnumerator.Current { get => default; } // 0x000000018792DB60-0x000000018792DDA0 
	
			// Constructors
			public _WaitForInited_d__10() {} // Dummy constructor
			public _WaitForInited_d__10(int __1__state) {} // 0x000000018792D57C-0x000000018792D6B0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018792DE40-0x000000018792DEA4
			private bool MoveNext() => default; // 0x000000018792D870-0x000000018792D8E8
			void IEnumerator.Reset() {} // 0x000000018792DEAC-0x000000018792DF3C
		}
	
		private sealed class _WaitForInitHGSDK_d__15 : IEnumerator<object> // TypeDefIndex: 53913
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018792E3E8-0x000000018792E428 
			object IEnumerator.Current { get => default; } // 0x000000018792D6B0-0x000000018792D870 
	
			// Constructors
			public _WaitForInitHGSDK_d__15() {} // Dummy constructor
			public _WaitForInitHGSDK_d__15(int __1__state) {} // 0x000000018792DF3C-0x000000018792E040
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018583A0D0-0x000000018583DC40
			private bool MoveNext() => default; // 0x000000018792E428-0x000000018792E4C4
			void IEnumerator.Reset() {} // 0x000000018792D500-0x000000018792D57C
		}
	
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 53914
		{
			// Fields
			public Action<SDKExternalTools.POSTResult> callback; // 0x10
	
			// Constructors
			public __c__DisplayClass25_0() {} // 0x000000018792E1E0-0x000000018792E3E8
	
			// Methods
			internal void _POSTImplementation_b__0(SDKNetUtils.WebHttpResponse webRequest) {} // 0x000000018792E040-0x000000018792E1E0
		}
	
		// Constructors
		public U8ExternalTools() {} // 0x000000018792AB74-0x000000018792ABC0
	
		// Methods
		public static bool IsInited() => default; // 0x0000000185FA2A80-0x0000000185FA2A90
		public static bool NeedRetryInit() => default; // 0x00000001813AE580-0x00000001813AE590
		public static bool NeedQuitGame() => default; // 0x000000018792DEA4-0x000000018792DEAC
		public static void RetryInitSDKSystem(string env) {} // 0x0000000185492010-0x0000000185492020
		public static void PublicSetGameVersion(string version) {} // 0x0000000187925640-0x0000000187925708
		public static void InitSDKSystem(string env) {} // 0x0000000187925708-0x00000001879257FC
		public static IEnumerator WaitForInited() => default; // 0x0000000185FB6A60-0x0000000185FB6A70
		public static void InitHGSDK(string env) {} // 0x0000000181378230-0x0000000181378240
		public static bool IsHGSDKInited() => default; // 0x0000000185492010-0x0000000185492020
		public static IEnumerator WaitForInitHGSDK() => default; // 0x000000018792A6BC-0x000000018792A7B0
		protected override void Log(string content) {} // 0x0000000181377E40-0x0000000181377E50
		protected override void LogError(string content) {} // 0x000000018792A7B0-0x000000018792A7FC
		protected override void LogWarning(string content) {} // 0x0000000181377E40-0x0000000181377E50
		protected override string GetSignKey() => default; // 0x0000000185F77050-0x0000000185F770B0
		public override Dictionary<string, string> GetDeviceIDs() => default; // 0x0000000185492010-0x0000000185492020
		public void SetSubChannel(string subChannel) {} // 0x000000018792A7FC-0x000000018792A9A8
		protected override int GetPlatformKey() => default; // 0x000000018458B8E0-0x000000018458B9D0
		public override void OnSDKExtraInfo(string jsonData) {} // 0x000000018792A9A8-0x000000018792AA10
		protected override string U8RootUrl() => default; // 0x0000000181378230-0x0000000181378240
		protected override void POSTImplementation(POSTRequest request, Action<POSTResult> callback) {} // 0x0000000185492010-0x0000000185492020
		private static POSTResult _ConvertToPOSTResult(SDKNetUtils.WebHttpResponse response) => default; // 0x0000000185D6F460-0x0000000185D6F4D0
		private void _ProcessExtraInfo(SDKExtraData extraData) {} // 0x0000000181377E40-0x0000000181377E50
		private static void _OnRequestExitGame() {} // 0x000000018792ABC0-0x000000018792AC0C
		private static void _OnFakeAccountCenter() {} // 0x0000000181377E40-0x0000000181377E50
		protected override SDKCaptchaHandler CreateCaptchaHandler() => default; // 0x0000000181378230-0x0000000181378240
		protected override string GetErrorMessage(ErrMsgMeta meta) => default; // 0x0000000185492010-0x0000000185492020
		private bool _ErrorMsg_GET_TOKEN(ErrMsgMeta meta, out string errorMsg) {
			errorMsg = default;
			return default;
		} // 0x0000000185EEA8A0-0x0000000185EEA910
		private bool _ErrorMsg_CREATE_ORDER(ErrMsgMeta meta, out string errorMsg) {
			errorMsg = default;
			return default;
		} // 0x0000000181377E40-0x0000000181377E50
		public string __iFixBaseProxy_GetSignKey() => default; // 0x0000000181377E40-0x0000000181377E50
		public Dictionary<string, string> __iFixBaseProxy_GetDeviceIDs() => default; // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnSDKExtraInfo(string P0) {} // 0x000000018792AA34-0x000000018792AA98
	}

	public class U8Plugin : IExternalPlugin // TypeDefIndex: 53918
	{
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 53916
		{
			// Fields
			public ExternalPluginPayParams args; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018792E4C4-0x000000018792E510
	
			// Methods
			internal void _Pay_b__0(U8PayResult payResult) {} // 0x000000018792E510-0x000000018792E55C
			internal void _Pay_b__1(object failMsg) {} // 0x000000018792E55C-0x000000018792E5A8
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 53917
		{
			// Fields
			public ExternalPluginLoginParams args; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018458A550-0x000000018458A580
	
			// Methods
			internal void __MockLogin_b__0(string uid) {} // 0x0000000184F66870-0x0000000184F66940
		}
	
		// Constructors
		public U8Plugin() {} // 0x000000018476C940-0x000000018476CA40
	
		// Methods
		public string GetPayAddition() => default; // 0x000000018792E5A8-0x000000018792E630
		public string GetSDKToken() => default; // 0x000000018792E630-0x000000018792E684
		public string GetSDKUid() => default; // 0x000000018792E684-0x000000018792E868
		public void Init() {} // 0x000000018792E868-0x000000018792E980
		public void Login(ExternalPluginLoginParams args) {} // 0x0000000184F66940-0x0000000184F669A0
		public void Logout(ExternalPluginLogoutParams args) {} // 0x0000000184B93300-0x0000000184B93420
		public void OnProductListChanged(List<U8ProductInfo> productList) {} // 0x0000000185492010-0x0000000185492020
		public void Pay(ExternalPluginPayParams args) {} // 0x0000000185492010-0x0000000185492020
		public bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta) {
			meta = default;
			return default;
		} // 0x000000018792AAB8-0x000000018792AAF0
		private static bool _UseMockVersion() => default; // 0x000000018792AAF0-0x000000018792AB10
		private void _MockLogin(ExternalPluginLoginParams args) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Beyond.Scripts.Entry
{
	public static class GameSettingSetter // TypeDefIndex: 54088
	{
		// Fields
		private static GameSettingSetterItem<float> _audioGlobalVolume_k__BackingField; // 0x00
		private static GameSettingSetterItem<float> _audioMusicVolume_k__BackingField; // 0x08
		private static GameSettingSetterItem<float> _audioVoiceVolume_k__BackingField; // 0x10
		private static GameSettingSetterItem<float> _audioSfxVolume_k__BackingField; // 0x18
		private static GameSettingSetterItem<bool> _audioSuspendUnfocused_k__BackingField; // 0x20
		private static GameSettingSetterItem<bool> _audioBackgroundMusic_k__BackingField; // 0x28
		private static GameSettingSetterItem<GameSetting.GameSettingAudioSuiteMode> _audioSuiteMode_k__BackingField; // 0x30
		private static GameSettingSetterItem<bool> _audioController_k__BackingField; // 0x38
		private static GameSettingSetterItem<bool> _audioSpatial_k__BackingField; // 0x40
		private static GameSettingSetterItem<float> _controllerCameraSpeedX_k__BackingField; // 0x48
		private static GameSettingSetterItem<float> _controllerCameraSpeedY_k__BackingField; // 0x50
		private static GameSettingSetterItem<float> _controllerCameraTopViewSpeed_k__BackingField; // 0x58
		private static GameSettingSetterItem<float> _controllerWalkRunRatio_k__BackingField; // 0x60
		private static GameSettingSetterItem<float> _cameraDistanceLevel_k__BackingField; // 0x68
		private static GameSettingSetterItem<GameSetting.CameraImpulseLevel> _cameraImpulseLevel_k__BackingField; // 0x70
		private static GameSettingSetterItem<bool> _controllerCameraReverseX_k__BackingField; // 0x78
		private static GameSettingSetterItem<bool> _controllerCameraReverseY_k__BackingField; // 0x80
		private static GameSettingSetterItem<GameSetting.GameSettingControllerAutoLockTarget> _controllerAutoLockTarget_k__BackingField; // 0x88
		private static GameSettingSetterItem<GameSetting.ComboSkillCameraAlpha> _comboSkillCameraAlpha_k__BackingField; // 0x90
		private static GameSettingSetterItem<bool> _controllerAutoSprint_k__BackingField; // 0x98
		private static GameSettingSetterItem<bool> _controllerMotion_k__BackingField; // 0xA0
		private static GameSettingSetterItem<bool> _controllerTriggerEffect_k__BackingField; // 0xA8
		private static GameSettingSetterItem<bool> _enableAutoAttackTouch_k__BackingField; // 0xB0
		private static GameSettingSetterItem<bool> _enableAutoAttackGamepad_k__BackingField; // 0xB8
		private static GameSettingSetterItem<GameSetting.KeyboardLayoutType> _keyboardType_k__BackingField; // 0xC0
		private static GameSettingSetterItem<EnvLang> _languageText_k__BackingField; // 0xC8
		private static GameSettingSetterItem<GameSetting.GameSettingLanguageAudio> _languageAudio_k__BackingField; // 0xD0
		private static GameSettingSetterItem<GameSetting.GameSettingVideoQuality> _graphicsQuality_k__BackingField; // 0xD8
		private static GameSettingSetterItem<bool> _graphicsFullScreen_k__BackingField; // 0xE0
		private static GameSettingSetterItem<int, int> _graphicsResolution_k__BackingField; // 0xE8
		private static GameSettingSetterItem<float> _graphicsNotchPadding_k__BackingField; // 0xF0
		private static GameSettingSetterItem<bool> _otherShowSmartAlert_k__BackingField; // 0xF8
		private static GameSettingSetterItem<bool> _staminaRecover_k__BackingField; // 0x100
		private static GameSettingSetterItem<bool> _staminaDrugExpire_k__BackingField; // 0x108
		public static bool s_stageInitFinished; // 0x110
	
		// Properties
		public static GameSettingSetterItem<float> audioGlobalVolume { get; private set; } // 0x000000018793758C-0x00000001879375E0 0x0000000187936CCC-0x0000000187936D04
		public static GameSettingSetterItem<float> audioMusicVolume { get; private set; } // 0x000000018793743C-0x0000000187937490 0x0000000187936D74-0x0000000187936DAC
		public static GameSettingSetterItem<float> audioVoiceVolume { get; private set; } // 0x0000000187937538-0x000000018793758C 0x0000000187936BEC-0x0000000187936C24
		public static GameSettingSetterItem<float> audioSfxVolume { get; private set; } // 0x00000001879372F0-0x0000000187937344 0x0000000187936D3C-0x0000000187936D74
		public static GameSettingSetterItem<bool> audioSuspendUnfocused { get; private set; } // 0x00000001879374E4-0x0000000187937538 0x0000000187936C24-0x0000000187936C5C
		public static GameSettingSetterItem<bool> audioBackgroundMusic { get; private set; } // 0x0000000187937344-0x0000000187937398 0x0000000187936D04-0x0000000187936D3C
		public static GameSettingSetterItem<GameSetting.GameSettingAudioSuiteMode> audioSuiteMode { get; private set; } // 0x0000000187937490-0x00000001879374E4 0x0000000187936F7C-0x0000000187936FB4
		public static GameSettingSetterItem<bool> audioController { get; private set; } // 0x0000000187937848-0x000000018793789C 0x0000000187936FB4-0x0000000187936FEC
		public static GameSettingSetterItem<bool> audioSpatial { get; private set; } // 0x000000018793789C-0x00000001879378F0 0x0000000187936FEC-0x0000000187937024
		public static GameSettingSetterItem<float> controllerCameraSpeedX { get; private set; } // 0x00000001879378F0-0x0000000187937944 0x000000018793709C-0x00000001879370D4
		public static GameSettingSetterItem<float> controllerCameraSpeedY { get; private set; } // 0x00000001879379FC-0x0000000187937A50 0x0000000187936DE4-0x0000000187936E1C
		public static GameSettingSetterItem<float> controllerCameraTopViewSpeed { get; private set; } // 0x00000001879375E0-0x0000000187937634 0x0000000187936E1C-0x0000000187936E54
		public static GameSettingSetterItem<float> controllerWalkRunRatio { get; private set; } // 0x0000000187937634-0x0000000187937688 0x0000000187936F08-0x0000000187936F40
		public static GameSettingSetterItem<float> cameraDistanceLevel { get; private set; } // 0x000000018793779C-0x00000001879377F0 0x0000000187936F40-0x0000000187936F7C
		public static GameSettingSetterItem<GameSetting.CameraImpulseLevel> cameraImpulseLevel { get; private set; } // 0x00000001879377F0-0x0000000187937848 0x0000000187936E90-0x0000000187936ECC
		public static GameSettingSetterItem<bool> controllerCameraReverseX { get; private set; } // 0x00000001879376E4-0x0000000187937740 0x0000000187936E54-0x0000000187936E90
		public static GameSettingSetterItem<bool> controllerCameraReverseY { get; private set; } // 0x0000000187937688-0x00000001879376E4 0x0000000187936ECC-0x0000000187936F08
		public static GameSettingSetterItem<GameSetting.GameSettingControllerAutoLockTarget> controllerAutoLockTarget { get; private set; } // 0x0000000187937740-0x000000018793779C 0x0000000187937024-0x0000000187937060
		public static GameSettingSetterItem<GameSetting.ComboSkillCameraAlpha> comboSkillCameraAlpha { get; private set; } // 0x0000000187937944-0x00000001879379A0 0x0000000187937060-0x000000018793709C
		public static GameSettingSetterItem<bool> controllerAutoSprint { get; private set; } // 0x00000001879379A0-0x00000001879379FC 0x0000000187937110-0x000000018793714C
		public static GameSettingSetterItem<bool> controllerMotion { get; private set; } // 0x0000000187937AAC-0x0000000187937B08 0x00000001879370D4-0x0000000187937110
		public static GameSettingSetterItem<bool> controllerTriggerEffect { get; private set; } // 0x0000000187937A50-0x0000000187937AAC 0x000000018186C260-0x000000018186C560
		public static GameSettingSetterItem<bool> enableAutoAttackTouch { get; private set; } // 0x000000018186CB60-0x000000018186CED0 0x0000000187937278-0x00000001879372B4
		public static GameSettingSetterItem<bool> enableAutoAttackGamepad { get; private set; } // 0x0000000187937CD4-0x0000000187937D30 0x000000018793723C-0x0000000187937278
		public static GameSettingSetterItem<GameSetting.KeyboardLayoutType> keyboardType { get; private set; } // 0x0000000187937C78-0x0000000187937CD4 0x00000001879371C4-0x0000000187937200
		public static GameSettingSetterItem<EnvLang> languageText { get; private set; } // 0x0000000187937BC0-0x0000000187937C1C 0x000000018793714C-0x0000000187937188
		public static GameSettingSetterItem<GameSetting.GameSettingLanguageAudio> languageAudio { get; private set; } // 0x0000000187937B08-0x0000000187937B64 0x0000000187937200-0x000000018793723C
		public static GameSettingSetterItem<GameSetting.GameSettingVideoQuality> graphicsQuality { get; private set; } // 0x0000000187937C1C-0x0000000187937C78 0x0000000187937188-0x00000001879371C4
		public static GameSettingSetterItem<bool> graphicsFullScreen { get; private set; } // 0x0000000187937B64-0x0000000187937BC0 0x00000001879372B4-0x00000001879372F0
		public static GameSettingSetterItem<int, int> graphicsResolution { get; private set; } // 0x0000000187937D30-0x0000000187937D8C 0x000000018186C860-0x000000018186CB60
		public static GameSettingSetterItem<float> graphicsNotchPadding { get; private set; } // 0x000000018186D240-0x000000018186D5B0 0x000000018186C560-0x000000018186C860
		public static GameSettingSetterItem<bool> otherShowSmartAlert { get; private set; } // 0x000000018186CED0-0x000000018186D240 0x0000000184D72820-0x0000000184D77D80
		public static GameSettingSetterItem<bool> staminaRecover { get; private set; } // 0x0000000184A7ACE0-0x0000000184A7AD50 0x0000000184A7AC70-0x0000000184A7ACE0
		public static GameSettingSetterItem<bool> staminaDrugExpire { get; private set; } // 0x0000000184A7AC00-0x0000000184A7AC70 0x0000000184A7AD50-0x0000000184A7ADC0
	
		// Nested types
		public class GameSettingSetterItem<T> // TypeDefIndex: 54086
		{
			// Fields
			private readonly string m_settingId;
			private readonly Action<T> m_otherSystemSet;
	
			// Constructors
			public GameSettingSetterItem() {} // Dummy constructor
			public GameSettingSetterItem(string settingId) {} // 0x0000000187936C5C-0x0000000187936C94
			public GameSettingSetterItem(string settingId, Action<T> otherSystemSet) {} // 0x0000000187937398-0x00000001879373E8
	
			// Methods
			public void Set(T value, bool forceSetOtherSystem = false /* Metadata: 0x02079013 */) {} // 0x0000000187936C94-0x0000000187936CCC
		}
	
		public class GameSettingSetterItem<T1, T2> // TypeDefIndex: 54087
		{
			// Fields
			private readonly string m_mainSettingId;
			private readonly string m_settingId1;
			private readonly string m_settingId2;
			private readonly Action<T1, T2> m_otherSystemSet;
	
			// Constructors
			public GameSettingSetterItem() {} // Dummy constructor
			public GameSettingSetterItem(string mainSettingId, string settingId1, string settingId2, Action<T1, T2> otherSystemSet) {} // 0x00000001879373E8-0x000000018793743C
	
			// Methods
			public void Set(T1 value1, T2 value2, bool forceSetOtherSystem = false /* Metadata: 0x02079014 */) {} // 0x0000000187936DAC-0x0000000187936DE4
		}
	
		// Methods
		public static void InitSetterItems() {} // 0x0000000185F0A100-0x0000000185F0A190
		private static void _OnAudioGlobalVolumeChange(float volume) {} // 0x0000000187936948-0x0000000187936998
		private static void _OnAudioMusicVolumeChange(float volume) {} // 0x0000000184A7B6D0-0x0000000184A7B760
		private static void _OnAudioVoiceVolumeChange(float volume) {} // 0x0000000184A7AED0-0x0000000184A7AF50
		private static void _OnAudioSfxVolumeChange(float volume) {} // 0x0000000184A7AE60-0x0000000184A7AED0
		private static void _OnAudioSuspendUnfocusedChange(bool suspendUnfocused) {} // 0x0000000184A7AB30-0x0000000184A7AC00
		private static void _OnAudioBackgroundMusicChange(bool enable) {} // 0x0000000184A7AA60-0x0000000184A7AB30
		private static void _OnAudioSuiteModeChange(GameSetting.GameSettingAudioSuiteMode mode) {} // 0x0000000185F369B0-0x0000000185F36A80
		private static void _OnAudioControllerChange(bool enable) {} // 0x0000000184A7A990-0x0000000184A7AA60
		private static void _OnAudioSpatialAudioChange(bool enable) {} // 0x0000000185EBD080-0x0000000185EBD190
		private static void _OnControllerCameraSpeedXChange(float cameraSpeed) {} // 0x000000018519CF40-0x000000018519CFE0
		private static void _OnControllerCameraSpeedYChange(float cameraSpeed) {} // 0x0000000184A7B1D0-0x0000000184A7B270
		private static void _OnControllerCameraTopViewSpeedChange(float cameraSpeed) {} // 0x0000000184A7B130-0x0000000184A7B1D0
		private static void _OnControllerWalkRunRatioChange(float walkRunRatio) {} // 0x000000018519CEA0-0x000000018519CF40
		private static void _OnCameraDistanceLevelChange(float distance) {} // 0x000000018519CE00-0x000000018519CEA0
		private static void _OnCameraImpulseLevelChange(GameSetting.CameraImpulseLevel level) {} // 0x0000000187936998-0x0000000187936A40
		private static void _OnControllerCameraReverseXChange(bool isReverse) {} // 0x0000000184A7B270-0x0000000184A7B380
		private static void _OnControllerCameraReverseYChange(bool isReverse) {} // 0x0000000184A7B090-0x0000000184A7B130
		private static void _OnControllerAutoLockTargetChange(GameSetting.GameSettingControllerAutoLockTarget mode) {} // 0x0000000187936A40-0x0000000187936AE8
		private static void _OnComboSkillCameraAlphaChange(GameSetting.ComboSkillCameraAlpha alpha) {} // 0x0000000184A7AFF0-0x0000000184A7B090
		private static void _OnControllerAutoSprintChange(bool valid) {} // 0x000000018186A530-0x000000018186B000
		private static void _OnControllerMotionChange(bool valid) {} // 0x0000000184FA8F60-0x0000000184FA9120
		private static void _OnControllerTriggerEffectChange(bool enable) {} // 0x000000018519CFE0-0x000000018519D100
		private static void _OnEnableAutoAttackTouchChange(bool enable) {} // 0x0000000187936B70-0x0000000187936BEC
		private static void _OnEnableAutoAttackGamepadChange(bool enable) {} // 0x0000000187936AE8-0x0000000187936B70
		private static void _OnKeyboardTypeChange(GameSetting.KeyboardLayoutType value) {} // 0x0000000185706660-0x0000000185706BC0
		private static void _OnLanguageTextChange(EnvLang language) {} // 0x0000000185706CE0-0x0000000185706EC0
		private static void _OnLanguageAudioChange(GameSetting.GameSettingLanguageAudio language) {} // 0x000000018570E480-0x000000018570E590
		private static void _OnGraphicsQualityChange(GameSetting.GameSettingVideoQuality quality) {} // 0x0000000184A7AF50-0x0000000184A7AFF0
		private static void _OnGraphicsFullScreenChanged(bool fullScreen) {} // 0x000000018186B930-0x000000018186C260
		private static void _OnGraphicsResolutionChange(int width, int height) {} // 0x000000018186B000-0x000000018186B930
		private static void _SetResolution(int width, int height, bool fullScreen) {}
		private static void _OnGraphicsNotchPaddingChange(float notchPadding) {}
		private static void _OnOtherShowSmartAlertChange(bool show) {}
		private static void _OnStaminaRecoverChange(bool show) {}
		private static void _OnStaminaDrugExpireChange(bool show) {}
	}

	public class WarmUpProgress : LoginHotUpdateModel.IProgress // TypeDefIndex: 54089
	{
		// Constructors
		public WarmUpProgress() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public double GetTotal() => default; // 0x000000018793D76C-0x000000018793D7F4
		public double GetCurrent() => default; // 0x000000018793D670-0x000000018793D700
		public string GetInfo() => default; // 0x000000018793D700-0x000000018793D76C
	}
}

namespace Beyond.SourceGenerator
{
	internal class DataNAttribute : Attribute // TypeDefIndex: 53885
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 53886
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 53887
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 53888
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 53889
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Beyond.UI
{
	public class SplashController : MonoBehaviour // TypeDefIndex: 53896
	{
		// Fields
		private const string CURSOR_KEY_SPLASH = "SplashController"; // Metadata: 0x02078DA2
		private const string SPLASH_RESOURCES_PATH = "Splash"; // Metadata: 0x02078DB3
		private float _initialFadeTime; // 0x18
		private float _regularFadeTime; // 0x1C
		private float _showTime; // 0x20
		private Image _blackCoverImage; // 0x28
		private Image _splashImage; // 0x30
		private SplashConfigs _splashConfigsCN; // 0x38
		private SplashConfigs _splashConfigsOS; // 0x50
		private DG.Tweening.Sequence m_tween; // 0x68
		private Action m_onComplete; // 0x70
		private bool m_skipLicense; // 0x78
		private static bool s_isPlaying; // 0x00
		private bool m_canBeHide; // 0x79
		private static SplashController _instance_k__BackingField; // 0x08
	
		// Properties
		public static SplashController instance { get; private set; } // 0x0000000185F8CAC0-0x0000000185F8CAE0 0x0000000185F7A490-0x0000000185F7A4E0
		public static bool isPlaying { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		[Serializable]
		private struct SplashConfig // TypeDefIndex: 53890
		{
			// Fields
			public Sprite sprite; // 0x00
			public bool blackCoverFadeOut; // 0x08
		}
	
		[Serializable]
		private struct SplashConfigOverride // TypeDefIndex: 53891
		{
			// Fields
			public EnvLang envLang; // 0x00
			public SplashConfig[] splashConfigs; // 0x08
		}
	
		[Serializable]
		private struct SplashConfigs // TypeDefIndex: 53892
		{
			// Fields
			public SplashConfig[] splashConfigs; // 0x00
			public SplashConfig[] splashConfigsVNMobile; // 0x08
			public SplashConfigOverride[] i18nSplashConfigOverrides; // 0x10
		}
	
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 53893
		{
			// Fields
			public SplashConfig config; // 0x10
			public SplashController __4__this; // 0x20
	
			// Constructors
			public __c__DisplayClass31_0() {} // 0x0000000187922F20-0x0000000187922F58
	
			// Methods
			internal void __DoStartSplash_b__0() {} // 0x0000000187922F90-0x0000000187922FE4
			internal void __DoStartSplash_b__2() {} // 0x0000000187922F58-0x0000000187922F90
		}
	
		private sealed class __OnSplashCompleteCoroutine_d__33 : IEnumerator<object> // TypeDefIndex: 53894
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SplashController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184017640-0x00000001840176D0 
			object IEnumerator.Current { get => default; } // 0x0000000184B92220-0x0000000184B92330 
	
			// Constructors
			public __OnSplashCompleteCoroutine_d__33() {} // Dummy constructor
			public __OnSplashCompleteCoroutine_d__33(int __1__state) {} // 0x0000000184017EC0-0x0000000184018140
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184017DE0-0x0000000184017EC0
			private bool MoveNext() => default; // 0x0000000184017D50-0x0000000184017DE0
			void IEnumerator.Reset() {} // 0x00000001840176D0-0x0000000184017760
		}
	
		private sealed class __StartLicenseCoroutine_d__34 : IEnumerator<object> // TypeDefIndex: 53895
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private bool _displayCursor_5__2; // 0x20
			private bool _usingController_5__3; // 0x21
			private bool _isGranted_5__4; // 0x22
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185EBB6B0-0x0000000185EBB710 
			object IEnumerator.Current { get => default; } // 0x00000001840175E0-0x0000000184017640 
	
			// Constructors
			public __StartLicenseCoroutine_d__34() {} // Dummy constructor
			public __StartLicenseCoroutine_d__34(int __1__state) {} // 0x0000000184B8FC80-0x0000000184B8FCF0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184B92330-0x0000000184B92430
			private bool MoveNext() => default; // 0x00000001844A4870-0x00000001844A4BB0
			void IEnumerator.Reset() {} // 0x0000000185EBB710-0x0000000185EBB7E0
		}
	
		// Constructors
		public SplashController() {} // 0x000000018792C5E4-0x000000018792C630
	
		// Methods
		public static SplashController Show(Action onComplete = null, bool skipLicense = false /* Metadata: 0x02078DA1 */) => default; // 0x0000000185F51700-0x0000000185F51730
		public static void Hide() {} // 0x0000000185F1D020-0x0000000185F1D090
		public static void CanFinished() {} // 0x0000000181378230-0x0000000181378240
		private void Awake() {} // 0x0000000185492010-0x0000000185492020
		private void OnDestroy() {} // 0x0000000184017760-0x0000000184017970
		private void _Play(Action onComplete, bool skipLicense) {} // 0x0000000181377E40-0x0000000181377E50
		private void _Stop() {} // 0x000000018792C54C-0x000000018792C598
		private SplashConfig[] _GetSplashConfigs() => default; // 0x0000000181377E40-0x0000000181377E50
		private void _DoStartSplash(SplashConfig[] splashConfigs) {} // 0x0000000181378230-0x0000000181378240
		private void _OnTweenFinished() {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator _OnSplashCompleteCoroutine() => default; // 0x000000018476F600-0x000000018476F850
		private IEnumerator _StartLicenseCoroutine() => default; // 0x0000000181377E40-0x0000000181377E50
		private void __DoStartSplash_b__31_1() {} // 0x0000000181377E40-0x0000000181377E50
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 53811
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 54092
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64710-0x0000000185F64780
	
		// Methods
		public void __Gen_Wrap_0(object P0, GameState P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public void __Gen_Wrap_1(float P0) {} // 0x0000000187937D8C-0x0000000187937E4C
		public void __Gen_Wrap_2(bool P0) {} // 0x0000000187350984-0x0000000187350A44
		public void __Gen_Wrap_3(GameSetting.GameSettingAudioSuiteMode P0) {} // 0x0000000187937E4C-0x0000000187937F0C
		public void __Gen_Wrap_4(GameSetting.CameraImpulseLevel P0) {} // 0x0000000187937E4C-0x0000000187937F0C
		public void __Gen_Wrap_5(GameSetting.GameSettingControllerAutoLockTarget P0) {} // 0x0000000187937E4C-0x0000000187937F0C
		public void __Gen_Wrap_6(GameSetting.ComboSkillCameraAlpha P0) {} // 0x0000000187937E4C-0x0000000187937F0C
		public void __Gen_Wrap_7(GameSetting.KeyboardLayoutType P0) {} // 0x0000000181355200-0x00000001813553F0
		public void __Gen_Wrap_8(EnvLang P0) {} // 0x0000000181389D90-0x0000000181389F80
		public void __Gen_Wrap_9(GameSetting.GameSettingLanguageAudio P0) {} // 0x0000000181389D90-0x0000000181389F80
		public void __Gen_Wrap_10(GameSetting.GameSettingVideoQuality P0) {} // 0x0000000181355200-0x00000001813553F0
		public void __Gen_Wrap_11(int P0, int P1, bool P2) {} // 0x0000000181876610-0x0000000181876860
		public void __Gen_Wrap_12(int P0, int P1) {} // 0x000000018156F000-0x000000018156F210
		public void __Gen_Wrap_13() {} // 0x000000018136DA00-0x000000018136DBB0
		public void __Gen_Wrap_14(object P0) {} // 0x000000018135B620-0x000000018135B8D0
		public bool __Gen_Wrap_15(object P0) => default; // 0x0000000181370BF0-0x0000000181370EB0
		public SplashController.SplashConfig[] __Gen_Wrap_16(object P0) => default; // 0x00000001818868F0-0x0000000181887220
		public IEnumerator __Gen_Wrap_17(object P0) => default; // 0x0000000181887220-0x0000000181887B60
		public void __Gen_Wrap_18(object P0, object P1) {} // 0x00000001815704E0-0x0000000181570890
		public void __Gen_Wrap_19(object P0, object P1, bool P2) {} // 0x0000000181887B60-0x0000000181887F00
		public SplashController __Gen_Wrap_20(object P0, bool P1) => default; // 0x0000000181887F00-0x00000001818888A0
		public void __Gen_Wrap_21(in EventData<bool, bool> P0) {} // 0x00000001818888A0-0x0000000181888E50
		public string __Gen_Wrap_22() => default; // 0x0000000181888E50-0x0000000181889690
		public string __Gen_Wrap_23(object P0) => default; // 0x0000000181889690-0x0000000181889FD0
		public bool __Gen_Wrap_24(object P0, uint P1) => default; // 0x0000000181889FD0-0x000000018188A2B0
		public GameApp.FileEntry __Gen_Wrap_25(GameApp.PendingFile P0) => default; // 0x000000018188A2B0-0x000000018188AEB0
		public List<GameApp.FileEntry> __Gen_Wrap_26(object P0, int P1) => default; // 0x000000018188AEB0-0x000000018188B850
		public int __Gen_Wrap_27(object P0, object P1) => default; // 0x000000018135A390-0x000000018135A720
		public string __Gen_Wrap_28(long P0) => default; // 0x000000018188B850-0x000000018188C0D0
		public void __Gen_Wrap_29(object P0, object P1, object P2) {} // 0x00000001816167B0-0x0000000181616C40
		public void __Gen_Wrap_30(object P0, object P1, System.DateTime P2, object P3, object P4) {} // 0x000000018188C0D0-0x000000018188C9B0
		public void __Gen_Wrap_31(object P0, object P1, int P2, object P3) {} // 0x00000001815FAC80-0x00000001815FB0F0
		public void __Gen_Wrap_32(object P0, object P1, int P2) {} // 0x00000001815A0BB0-0x00000001815A0F50
		public void __Gen_Wrap_33(object P0, bool P1) {} // 0x0000000181570FE0-0x00000001815712C0
		public void __Gen_Wrap_34(int P0) {} // 0x0000000181389D90-0x0000000181389F80
		public bool __Gen_Wrap_35(out string P0) {
			P0 = default;
			return default;
		} // 0x000000018188C9B0-0x000000018188D2F0
		public bool __Gen_Wrap_36(object P0, out LocalResPref P1, out VirtualFileSystem.BlockValidator P2) {
			P1 = default;
			P2 = default;
			return default;
		} // 0x000000018188D2F0-0x000000018188E050
		public void __Gen_Wrap_37(object P0, out VirtualFileSystem.BlockValidator P1) {
			P1 = default;
		} // 0x000000018188E050-0x000000018188EA70
		public bool __Gen_Wrap_38() => default; // 0x000000018138FF00-0x00000001813900C0
		public void __Gen_Wrap_39(object P0, in EventData<Beyond.DeviceInfo.InputType> P1) {} // 0x000000018188EA70-0x000000018188F0F0
		public LoginController.MaskCtrl __Gen_Wrap_40(object P0) => default; // 0x000000018188F0F0-0x000000018188FA30
		public UISwitchTween __Gen_Wrap_41(object P0, int P1) => default; // 0x000000018188FA30-0x0000000181890390
		public IEnumerator __Gen_Wrap_42(object P0, object P1) => default; // 0x0000000181890390-0x0000000181890DC0
		public void __Gen_Wrap_43(object P0, object P1, LoginController.EMaskType P2, bool P3, bool P4) {} // 0x0000000181890DC0-0x00000001818911D0
		public UIAnimationLayerMixPlayer __Gen_Wrap_44(object P0) => default; // 0x00000001818911D0-0x0000000181891B10
		public void __Gen_Wrap_45(object P0, LoginController.FOptions P1) {} // 0x0000000181891B10-0x0000000181892190
		public LoginWorkFlow.FWork __Gen_Wrap_46() => default; // 0x0000000181892190-0x00000001818929A0
		public bool __Gen_Wrap_47(LoginWorkFlow.ENode P0, LoginWorkFlow.ENode P1) => default; // 0x000000018156F210-0x000000018156F430
		public bool __Gen_Wrap_48(LoginWorkFlow.ENode P0) => default; // 0x000000018139FD70-0x000000018139FF70
		public IEnumerator __Gen_Wrap_49(LoginWorkFlow.ENode P0) => default; // 0x00000001818929A0-0x0000000181893220
		public CustomYieldInstruction __Gen_Wrap_50(object P0) => default; // 0x0000000181893220-0x0000000181893B60
		public bool __Gen_Wrap_51(ref LoginWorkFlow.FWork P0) => default; // 0x0000000181893B60-0x0000000181894730
		public void __Gen_Wrap_52(ref LoginWorkFlow.FWork P0) {} // 0x0000000181894730-0x00000001818952E0
		public void __Gen_Wrap_53(object P0, LoginAlertDialog.FParams P1) {} // 0x00000001818952E0-0x0000000181895950
		public void __Gen_Wrap_54(object P0, LoginVocResSelDialog.FParams P1) {} // 0x0000000181895950-0x0000000181895FE0
		public void __Gen_Wrap_55(object P0, LoginJudgeDialog.FParams P1) {} // 0x0000000181895FE0-0x0000000181896680
		public void __Gen_Wrap_56(LoginAlertDialog P0, LoginAlertDialog.FParams P1) {} // 0x0000000181896680-0x0000000181896CF0
		public void __Gen_Wrap_57(object P0, bool P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8) {} // 0x0000000181896CF0-0x0000000181897640
		public IEnumerator __Gen_Wrap_58(object P0, bool P1) => default; // 0x0000000181897640-0x0000000181897FA0
		public bool __Gen_Wrap_59(object P0, out LoginWorkFlow.ENode P1) {
			P1 = default;
			return default;
		} // 0x0000000181897FA0-0x00000001818982C0
		public void __Gen_Wrap_60(GameState P0) {} // 0x0000000181389D90-0x0000000181389F80
		public void __Gen_Wrap_61(object P0, float P1) {} // 0x0000000181362020-0x0000000181362300
		public float __Gen_Wrap_62(object P0) => default; // 0x00000001816A5430-0x00000001816A56F0
		public LoginController __Gen_Wrap_63(object P0) => default; // 0x00000001818982C0-0x0000000181898C00
		public void __Gen_Wrap_64(object P0, object P1, float P2) {} // 0x000000018170E3A0-0x000000018170E740
		public List<ServerZoneManager.ServerZoneData> __Gen_Wrap_65(object P0) => default; // 0x0000000181898C00-0x0000000181899540
		public bool __Gen_Wrap_66(object P0, object P1) => default; // 0x00000001815D5950-0x00000001815D5D10
		public ServerZoneManager.ServerZoneData __Gen_Wrap_67(object P0) => default; // 0x0000000181899540-0x0000000181899E80
		public bool __Gen_Wrap_68(object P0, ELoginEvent P1, object P2) => default; // 0x0000000181361A80-0x0000000181361E60
		public void __Gen_Wrap_69(object P0, ELoginEvent P1, object P2) {} // 0x0000000181391570-0x0000000181391940
		public void __Gen_Wrap_70(string P0) {} // 0x0000000181354D40-0x0000000181355000
		public void __Gen_Wrap_71(PointerEventData P0) {} // 0x0000000181354D40-0x0000000181355000
		public bool __Gen_Wrap_72(ref LoginMockUIDPanel.FOptions P0) => default; // 0x0000000181899E80-0x000000018189AA90
		public void __Gen_Wrap_73(int P0, UIDropdownOption P1, bool P2) {} // 0x0000000181366EE0-0x00000001813671E0
		public void __Gen_Wrap_74(object P0, int P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public void __Gen_Wrap_75(object P0, LoginMockUIDPanel.FOptions P1, object P2) {} // 0x000000018189AA90-0x000000018189B200
		public UISwitchTween __Gen_Wrap_76(object P0) => default; // 0x000000018189B200-0x000000018189BB40
		public bool __Gen_Wrap_77(object P0, LoginController.EMaskType P1) => default; // 0x0000000181551EC0-0x00000001815521B0
		public void __Gen_Wrap_78(LoginVocResSelDialog P0, LoginVocResSelDialog.FParams P1) {} // 0x000000018189BB40-0x000000018189C1D0
		public IEnumerator __Gen_Wrap_79(object P0, object P1, object P2, object P3) => default; // 0x000000018189C1D0-0x000000018189CD60
		public void __Gen_Wrap_80(LoginJudgeDialog P0, LoginJudgeDialog.FParams P1) {} // 0x000000018189CD60-0x000000018189D3E0
		public void __Gen_Wrap_81(object P0, object P1, object P2, object P3) {} // 0x00000001815B7830-0x00000001815B7DA0
		public string __Gen_Wrap_82(object P0, object P1, object P2) => default; // 0x000000018189D3E0-0x000000018189DF00
		public void __Gen_Wrap_83(ref bool P0) {} // 0x000000018189DF00-0x000000018189E120
		public void __Gen_Wrap_84(object P0, ref bool P1) {} // 0x000000018189E120-0x000000018189E420
		public void __Gen_Wrap_85(object P0, LoginManager.FFlowWithMask P1) {} // 0x000000018189E420-0x000000018189EAC0
		public bool __Gen_Wrap_86(ref LoginManager.FFlowCondition P0, LoginWorkFlow.ENode P1) => default; // 0x000000018189EAC0-0x000000018189F6C0
		public IEnumerator __Gen_Wrap_87(object P0, LoginManager.FFlowWithMask P1) => default; // 0x000000018189F6C0-0x00000001818A03B0
		public TMP_FontAsset __Gen_Wrap_88(object P0) => default; // 0x00000001818A03B0-0x00000001818A0CE0
		public void __Gen_Wrap_89(SDKNetUtils.HttpPostRequest P0) {} // 0x00000001818A0CE0-0x00000001818A1290
		public void __Gen_Wrap_90(SDKNetUtils.HttpGetRequest P0) {} // 0x00000001818A1290-0x00000001818A1830
		public IEnumerator __Gen_Wrap_91(object P0, SDKNetUtils.HTTPConfig P1) => default; // 0x00000001818A1830-0x00000001818A2510
		public IEnumerator __Gen_Wrap_92() => default; // 0x00000001818A2510-0x00000001818A2D50
		public Dictionary<string, string> __Gen_Wrap_93(object P0) => default; // 0x00000001818A2D50-0x00000001818A3680
		public int __Gen_Wrap_94(object P0) => default; // 0x0000000181375C70-0x0000000181375F30
		public void __Gen_Wrap_95(object P0, SDKExtraData P1) {} // 0x00000001818A3680-0x00000001818A3D00
		public SDKExternalTools.POSTResult __Gen_Wrap_96(SDKNetUtils.WebHttpResponse P0) => default; // 0x00000001818A3D00-0x00000001818A48A0
		public void __Gen_Wrap_97(SDKNetUtils.WebHttpResponse P0) {} // 0x00000001818A48A0-0x00000001818A4E50
		public void __Gen_Wrap_98(object P0, SDKExternalTools.POSTRequest P1, object P2) {} // 0x00000001818A4E50-0x00000001818A55A0
		public SDKCaptchaHandler __Gen_Wrap_99(object P0) => default; // 0x00000001818A55A0-0x00000001818A67F0
		public bool __Gen_Wrap_100(object P0, SDKExternalTools.ErrMsgMeta P1, out string P2) {
			P2 = default;
			return default;
		} // 0x000000018186D5B0-0x000000018186E330
		public string __Gen_Wrap_101(object P0, SDKExternalTools.ErrMsgMeta P1) => default; // 0x000000018186E330-0x000000018186F010
		public IEnumerator __Gen_Wrap_102(object P0, object P1, object P2) => default; // 0x000000018186F010-0x000000018186FB10
		public void __Gen_Wrap_103(object P0, ExternalPluginLoginParams P1) {} // 0x000000018186FB10-0x00000001818701B0
		public void __Gen_Wrap_104(object P0, ExternalPluginLogoutParams P1) {} // 0x00000001818701B0-0x0000000181870820
		public void __Gen_Wrap_105(U8PayResult P0) {} // 0x0000000181870820-0x0000000181870DC0
		public void __Gen_Wrap_106(object P0, ExternalPluginPayParams P1) {} // 0x0000000181870DC0-0x0000000181871430
		public bool __Gen_Wrap_107(object P0, object P1, out SDKMeta P2) {
			P2 = default;
			return default;
		} // 0x0000000181871430-0x0000000181871F70
		public void __Gen_Wrap_108(ref LoginWorkFlow.FWork P0, int P1) {} // 0x0000000181871F70-0x0000000181872B60
		public bool __Gen_Wrap_109(object P0, LoginWorkFlow.ENode P1, bool P2) => default; // 0x0000000181872B60-0x0000000181872E70
		public HGDownloader.DownloadProgress __Gen_Wrap_110(object P0) => default; // 0x0000000181872E70-0x0000000181873770
		public HGDownloader.WorkState __Gen_Wrap_111(object P0) => default; // 0x00000001815570F0-0x00000001815573B0
		public List<HGFileInfo> __Gen_Wrap_112(object P0, object P1) => default; // 0x0000000181873770-0x0000000181874190
		public List<HGFolder> __Gen_Wrap_113(object P0, object P1) => default; // 0x0000000181874190-0x0000000181874BB0
		public bool __Gen_Wrap_114(object P0, HGRetCodeType P1, int P2) => default; // 0x000000018155CEC0-0x000000018155D1C0
		public string __Gen_Wrap_115(double P0) => default; // 0x0000000181874BB0-0x0000000181875430
		public void __Gen_Wrap_116(object P0, long P1, object P2, object P3, object P4) {} // 0x0000000181875430-0x0000000181875960
		public void __Gen_Wrap_117(object P0, HGDownloader.PauseReason P1) {} // 0x000000018155EB40-0x000000018155EE10
		public IEnumerator __Gen_Wrap_118(object P0, long P1) => default; // 0x0000000181875960-0x0000000181876300
		public void __Gen_Wrap_119(object P0, long P1, long P2, long P3) {} // 0x0000000181876300-0x0000000181876610
		public double __Gen_Wrap_120(object P0) => default; // 0x00000001816AB380-0x00000001816AB640
		public bool __Gen_Wrap_121(bool P0) => default; // 0x00000001816A2220-0x00000001816A2420
		public string __Gen_Wrap_122(object P0, bool P1) => default; // 0x0000000181876860-0x0000000181877200
		public LocalResPref __Gen_Wrap_123() => default; // 0x0000000181877200-0x0000000181877A40
		public LoginHotUpdater.HotUpdateInfo __Gen_Wrap_124(object P0, bool P1) => default; // 0x0000000181877A40-0x00000001818783E0
		public ResourceIndex __Gen_Wrap_125() => default; // 0x00000001818783E0-0x0000000181878C20
		public string __Gen_Wrap_126(object P0, object P1, bool P2) => default; // 0x0000000181878C20-0x0000000181879670
		public object __Gen_Wrap_127() => default; // 0x0000000181879670-0x0000000181879EB0
		public IEnumerator __Gen_Wrap_128(object P0, object P1, bool P2, object P3) => default; // 0x0000000181879EB0-0x000000018187A9D0
		public IEnumerator __Gen_Wrap_129(bool P0, object P1, object P2) => default; // 0x000000018187A9D0-0x000000018187B410
		public LocalResPref __Gen_Wrap_130(object P0, bool P1, object P2, FResourceDiff P3, out int P4) {
			P4 = default;
			return default;
		} // 0x000000018187B410-0x000000018187C170
		public void __Gen_Wrap_131(object P0, ref bool P1, double P2, double P3, int P4, bool P5) {} // 0x000000018187C170-0x000000018187C4E0
		public bool __Gen_Wrap_132(object P0, EVFSBlockType P1) => default; // 0x000000018187C4E0-0x000000018187C7D0
		public IEnumerator __Gen_Wrap_133(object P0, object P1, bool P2, bool P3) => default; // 0x000000018187C7D0-0x000000018187D240
		public LoginHotUpdater __Gen_Wrap_134(object P0, bool P1) => default; // 0x000000018187D240-0x000000018187DBE0
		public LoginProgress.FDownloadSize.EUnit __Gen_Wrap_135(double P0) => default; // 0x000000018187DBE0-0x000000018187DDE0
		public float __Gen_Wrap_136(double P0, LoginProgress.FDownloadSize.EUnit P1) => default; // 0x000000018187DDE0-0x000000018187E010
		public string __Gen_Wrap_137(float P0, float P1, LoginProgress.FDownloadSize.EUnit P2) => default; // 0x000000018187E010-0x000000018187E900
		public string __Gen_Wrap_138(float P0, LoginProgress.FDownloadSize.EUnit P1) => default; // 0x000000018187E900-0x000000018187F1B0
		public string __Gen_Wrap_139(float P0, float P1) => default; // 0x000000018187F1B0-0x000000018187FA80
		public void __Gen_Wrap_140(ref LoginProgress.FDownloadSize P0, double P1, double P2, double P3) {} // 0x000000018187FA80-0x0000000181880750
		public void __Gen_Wrap_141(ref LoginProgress.FDownloadSize P0, double P1, double P2) {} // 0x0000000181880750-0x0000000181881400
		public void __Gen_Wrap_142(ref LoginProgress.FDownloadSize P0) {} // 0x0000000181881400-0x0000000181882010
		public void __Gen_Wrap_143(SpeedTestResult P0) {} // 0x0000000181354D40-0x0000000181355000
		public Task<Hypergryph.SpeedTest.TaskResult> __Gen_Wrap_144() => default; // 0x0000000181882010-0x0000000181882850
		public LoginViewModel.FAgeTipsPolicy __Gen_Wrap_145() => default; // 0x0000000181882850-0x0000000181883060
		public LoginWorkFlow.Node[] __Gen_Wrap_146(object P0) => default; // 0x0000000181883060-0x00000001818839A0
		public float __Gen_Wrap_147(object P0, out bool P1) {
			P1 = default;
			return default;
		} // 0x00000001818839A0-0x0000000181883CA0
		public UIAnimationMixPlayer __Gen_Wrap_148(object P0) => default; // 0x0000000181883CA0-0x00000001818845E0
		public void __Gen_Wrap_149(object P0, LoginSceneAnimCtrl.EState P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public List<string> __Gen_Wrap_150(object P0) => default; // 0x00000001818845E0-0x0000000181884F20
		public void __Gen_Wrap_151(object P0, LoginViewModel.FAgeTipsPolicy P1) {} // 0x0000000181884F20-0x00000001818855B0
		public void __Gen_Wrap_152(object P0, object P1, bool P2, bool P3) {} // 0x00000001818855B0-0x0000000181885990
		public void __Gen_Wrap_153(bool P0, bool P1, bool P2) {} // 0x0000000181885990-0x0000000181885BC0
		public void __Gen_Wrap_154(object P0, in EventData<bool> P1) {} // 0x0000000181885BC0-0x0000000181886260
		public void __Gen_Wrap_155(object P0, in EventData<float> P1) {} // 0x0000000181886260-0x00000001818868F0
		public void __Gen_Wrap_156(object P0, object P1, object P2, bool P3) {} // 0x000000018154F3D0-0x000000018154F840
		public void __Gen_Wrap_157(object P0, int P1, object P2) {} // 0x000000018156A670-0x000000018156AA00
		public void __Gen_Wrap_158(object P0, EVFSBlockType P1) {} // 0x00000001816908F0-0x0000000181690BC0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 54093
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { get => default; } // 0x000000018793D7F4-0x000000018793D8A0 
		object IEnumerator.Current { get => default; } // 0x000000018793D8A0-0x000000018793D94C 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018793D94C-0x000000018793DA28
	
		// Methods
		void IDisposable.Dispose() {} // 0x00000001873416FC-0x0000000187341778
		private bool MoveNext() => default; // 0x0000000187341518-0x00000001873415A4
		void IEnumerator.Reset() {} // 0x00000001872E7280-0x00000001872E72FC
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 54094
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018793DC10-0x000000018793DC74
		public static bool IsPatched(int id) => default; // 0x00000001844C1FB0-0x00000001844C2020
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018793DACC-0x000000018793DB98
		public object CreateWrapper(int id) => default; // 0x000000018793DB98-0x000000018793DC10
		public object InitWrapperArray(int len) => default; // 0x000000018793DC74-0x000000018793E118
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018793DA28-0x000000018793DACC
	}

	public enum IDMAP0 // TypeDefIndex: 54095
	{
		Beyond-GameApp-SwitchState0 = 0,
		Beyond-GameApp-Awake0 = 1,
		Beyond-GameApp-_PreInitGameSetting0 = 2,
		Beyond-Scripts-Entry-GameSettingSetter-InitSetterItems0 = 3,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioGlobalVolumeChange0 = 4,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioMusicVolumeChange0 = 6,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioVoiceVolumeChange0 = 8,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSfxVolumeChange0 = 10,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuspendUnfocusedChange0 = 12,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioBackgroundMusicChange0 = 14,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSuiteModeChange0 = 16,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioControllerChange0 = 18,
		Beyond-Scripts-Entry-GameSettingSetter-_OnAudioSpatialAudioChange0 = 20,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedXChange0 = 22,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraSpeedYChange0 = 24,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraTopViewSpeedChange0 = 26,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerWalkRunRatioChange0 = 28,
		Beyond-Scripts-Entry-GameSettingSetter-_OnCameraDistanceLevelChange0 = 30,
		Beyond-Scripts-Entry-GameSettingSetter-_OnCameraImpulseLevelChange0 = 32,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseXChange0 = 34,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerCameraReverseYChange0 = 36,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoLockTargetChange0 = 38,
		Beyond-Scripts-Entry-GameSettingSetter-_OnComboSkillCameraAlphaChange0 = 40,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerAutoSprintChange0 = 42,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerMotionChange0 = 44,
		Beyond-Scripts-Entry-GameSettingSetter-_OnControllerTriggerEffectChange0 = 46,
		Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackTouchChange0 = 48,
		Beyond-Scripts-Entry-GameSettingSetter-_OnEnableAutoAttackGamepadChange0 = 50,
		Beyond-Scripts-Entry-GameSettingSetter-_OnKeyboardTypeChange0 = 52,
		Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageTextChange0 = 54,
		Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageAudioChange0 = 56,
		Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsQualityChange0 = 58,
		Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsFullScreenChanged0 = 60,
		Beyond-Scripts-Entry-GameSettingSetter-_SetResolution0 = 61,
		Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsResolutionChange0 = 63,
		Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsNotchPaddingChange0 = 65,
		Beyond-Scripts-Entry-GameSettingSetter-_OnOtherShowSmartAlertChange0 = 67,
		Beyond-Scripts-Entry-GameSettingSetter-_OnStaminaRecoverChange0 = 69,
		Beyond-Scripts-Entry-GameSettingSetter-_OnStaminaDrugExpireChange0 = 71,
		Beyond-GameApp-_InitNotificationCenter0 = 74,
		Beyond-GameApp-_NeedDeepProfilerMode0 = 75,
		Beyond-UI-SplashController-Show0 = 76,
		Beyond-RenderPipelineDataLoader-LoadSimpleRpData0 = 77,
		Beyond-UI-SplashController-_Play0 = 79,
		Beyond-UI-SplashController-_GetSplashConfigs0 = 80,
		Beyond-UI-SplashController-_DoStartSplash0 = 81,
		Beyond-UI-SplashController-_OnTweenFinished0 = 86,
		Beyond-UI-SplashController-_OnSplashCompleteCoroutine0 = 87,
		Beyond-SDK-Impl-U8ExternalTools-PublicSetGameVersion0 = 91,
		Beyond-UI-SplashController-_StartLicenseCoroutine0 = 92,
		Beyond-UI-SplashController-Hide0 = 99,
		Beyond-UI-SplashController-_Stop0 = 100,
		Beyond-GameApp-_Init0 = 107,
		Beyond-GameApp-_InitSecuritySDK0 = 108,
		Beyond-GameApp-_FetchRemoteConfigUtilSuc0 = 112,
		Beyond-GameApp-_InitGameStateMachine0 = 122,
		Beyond-GameApp-_RegisterLuaAfterGCEvent0 = 123,
		Beyond-GameApp-_OnApplicationFocusForLua0 = 124,
		Beyond-GameApp-_OnApplicationPauseForLua0 = 125,
		Beyond-GameApp-_OnSystemDisplaySizeChanged0 = 126,
		Beyond-GameApp-RefreshScreenResolution0 = 127,
		Beyond-GameApp-_OnSystemScreenSizeChanged0 = 128,
		Beyond-GameApp-ScanLocalFiles0 = 130,
		Beyond-GameApp-_CollectSystemInfo0 = 131,
		Beyond-GameApp-LaunchScanCoordinator0 = 132,
		Beyond-GameApp-_ScanParallel0 = 135,
		Beyond-GameApp-_WorkerLoop0 = 136,
		Beyond-GameApp-_ScanDirectory0 = 137,
		Beyond-GameApp-_MakeLongPath0 = 138,
		Beyond-GameApp-_BuildEntry0 = 139,
		Beyond-GameApp-_CanAccess0 = 140,
		Beyond-GameApp-_CalculateMd50 = 141,
		Beyond-GameApp-_WriteTreeReport0 = 142,
		Beyond-GameApp-_PrintTreeNode0 = 143,
		Beyond-GameApp-_TreeNodeCompare0 = 144,
		Beyond-GameApp-_FormatSize0 = 145,
		Beyond-GameApp-_DelayInit0 = 146,
		Beyond-GameApp-Update0 = 153,
		Beyond-GameApp-LateUpdate0 = 154,
		Beyond-GameApp-OnApplicationQuit0 = 155,
		Beyond-GameApp-OnApplicationFocus0 = 156,
		Beyond-GameApp-OnApplicationPause0 = 157,
		Beyond-GameApp-_OnApplicationPauseForSecurity0 = 158,
		Beyond-GameApp-OnDestroy0 = 159,
		Beyond-GameApp-_UnInit0 = 160,
		Beyond-GameApp-_UnInitGameStateMachine0 = 161,
		Beyond-GameApp-QuitGame0 = 162,
		Beyond-GameApp-PollScanResult0 = 163,
		Beyond-GameInitState-OnEnter0 = 164,
		Beyond-GameStateBase-OnEnter0 = 165,
		Beyond-GameInitState-_DoInit0 = 166,
		Beyond-GameInitState-_InitInitialResourceManager0 = 170,
		Beyond-GameInitState-_CheckIfLocalInitialAssetsValid0 = 171,
		Beyond-GameInitState-_InitAPPDefaultCulture0 = 172,
		Beyond-RenderPipelineDataLoader-PreloadFullRpResources0 = 173,
		Beyond-VietnamLoginAgePanel-Init0 = 174,
		Beyond-VietnamLoginAgePanel-_Init0 = 175,
		Beyond-VietnamLoginAgePanel-_UnInit0 = 176,
		Beyond-GameInitState-_InitGameSetting0 = 177,
		Beyond-RenderPipelineDataLoader-IsPreLoadFinished0 = 189,
		Beyond-GameInitState-OnLeave0 = 193,
		Beyond-GameStateBase-OnLeave0 = 194,
		Beyond-GameLoginState-OnEnter0 = 195,
		Beyond-UI-SplashController-CanFinished0 = 196,
		Beyond-RenderPipelineDataLoader-LoadFullRpResources0 = 197,
		Beyond-GameLoginState-_TryStartLoginWorkflow0 = 198,
		Beyond-LoginManager-IsWorkflowInProgress0 = 199,
		Beyond-LoginContext-IsDisposed0 = 200,
		Beyond-LoginManager-InitCoroutine0 = 201,
		Beyond-LoginContext-Dispose0 = 205,
		Beyond-LoginContext-_DisposeImpl0 = 206,
		Beyond-Login-LoginWorkFlow-Dispose0 = 208,
		Beyond-Login-LoginWorkFlow-Node-Dispose0 = 211,
		Beyond-Login-LoginWorkFlow-Node-OnDispose0 = 212,
		Beyond-Login-LoginWorkFlow-_UpdateCursor0 = 213,
		Beyond-Login-LoginWorkFlow-_EnableCursor0 = 214,
		Beyond-Login-LoginWorkFlow-_EnbaleToggleGroup0 = 215,
		Beyond-Login-LoginWorkFlow-Worker-Dispose0 = 216,
		Beyond-LoginManager-AssetLoader-Dispose0 = 220,
		Beyond-LoginContext-_DisposeCoroutine0 = 221,
		Beyond-LoginController-BeforeDestroy0 = 225,
		Beyond-LoginController-get_maskCtrl0 = 229,
		Beyond-LoginController-MaskCtrl-IsCrossSceneMaskTweening0 = 230,
		Beyond-LoginController-MaskCtrl-_GetMaskByType0 = 231,
		Beyond-LoginController-MaskCtrl-WaitForCrossSceneMasks0 = 232,
		Beyond-LoginController-MaskCtrl-Dispose0 = 239,
		Beyond-LoginContext-IsWorkflowDisposed0 = 246,
		Beyond-LoginManager-_Init0 = 248,
		Beyond-LoginManager-_LoginWorkFlowCoroutine0 = 251,
		Beyond-LoginController-InitUI0 = 255,
		Beyond-LoginController-MaskCtrl-EnableMask0 = 256,
		Beyond-LoginController-_InitImpl0 = 257,
		Beyond-LoginController-_InitCoroutine0 = 258,
		Beyond-Login-LoginRootPanel-Init0 = 262,
		Beyond-Login-LoginRootPanel-_InitController0 = 264,
		Beyond-Login-LoginRootPanel-_InitChildPanel0 = 265,
		Beyond-Login-LoginRootPanel-ChildPanel-OnLoginContext0 = 266,
		Beyond-Login-LoginRootPanel-ChildPanel-OnInit0 = 268,
		Beyond-Login-LoginDecorateUI-OnLoginContext0 = 270,
		Beyond-Login-LoginDecorateUI-_ToggleGlow0 = 271,
		Beyond-Login-LoginDecorateUI-_EnsureGlowPlayer0 = 272,
		Beyond-LoginController-_InitVersionBtn0 = 273,
		Beyond-Login-LoginWorkFlow-DoWorkFlow0 = 277,
		Beyond-Login-LoginWorkFlow-FWork-Start0 = 282,
		Beyond-Login-LoginWorkFlow-_CheckIfGameStateNotMatch0 = 286,
		Beyond-Login-LoginWorkFlow-IsBeforeWork0 = 287,
		Beyond-Login-LoginWorkFlow-IsOnOrAfterWork0 = 288,
		Beyond-Login-LoginWorkFlow-_AdjustCurrentGameState0 = 289,
		Beyond-Login-LoginWorkFlow-Worker-SetCurNode0 = 296,
		Beyond-Login-LoginWorkFlow-Worker-Work0 = 299,
		Beyond-Login-LoginWorkFlow-Worker-_InternalTick0 = 305,
		Beyond-Login-LoginWorkFlow-Node-Cancel0 = 307,
		Beyond-Login-LoginHotUpdater-IsNeedSoftRestart0 = 311,
		Beyond-Login-LoginWorkFlow-Worker-TickInEmptyFrame0 = 312,
		Beyond-Login-LoginWorkFlow-FWork-ConsumeFallback0 = 313,
		Beyond-Login-LoginWorkFlow-FWork-MoveNextIndex0 = 315,
		Beyond-Login-LoginWorkFlow-FWork-WorkEnd0 = 317,
		Beyond-LoginManager-_PrepareBeforeLoginProcess0 = 324,
		Beyond-LoginManager-AlertDialog0 = 326,
		Beyond-Login-LoginAlertDialog-SetParams0 = 330,
		Beyond-Login-LoginVocResSelDialog-SetParams0 = 332,
		Beyond-Login-LoginJudgeDialog-SetParams0 = 334,
		Beyond-LoginContext-StartCoroutine0 = 335,
		Beyond-LoginContext-Init0 = 337,
		Beyond-LoginController-InvokeWhenStart0 = 344,
		Beyond-GameLoginState-OnLeave0 = 348,
		Beyond-GameMainState-OnEnter0 = 349,
		Beyond-LoginManager-Clear0 = 350,
		Beyond-LoginManager-_ClearWorkflowAndContext0 = 351,
		Beyond-LoginContext-ShutDown0 = 352,
		Beyond-LoginManager-_ReleaseLoginScene0 = 353,
		Beyond-GameMainState-OnLeave0 = 354,
		Beyond-GameMainState-ReleaseMainGame0 = 355,
		Beyond-LoginManager-OnReleaseMainGame0 = 356,
		Beyond-LoginManager-IsReLoginInProgress0 = 357,
		Beyond-Login-LoginWorkFlow-IsAfterWork0 = 358,
		Beyond-Login-LoginWorkFlow-PeekFallbackStatus0 = 359,
		Beyond-GameMainState-_ClearUtils0 = 360,
		Beyond-GamePreloadState-OnEnter0 = 361,
		Beyond-GamePreloadState-_DoPreload0 = 362,
		Beyond-GamePreloadState-_InitGameSettingStateInPreload0 = 366,
		Beyond-GamePreloadState-OnLeave0 = 390,
		Beyond-GameQuitState-OnEnter0 = 391,
		Beyond-GameQuitState-DoQuit0 = 392,
		Beyond-VietnamLoginAgePanel-UnInit0 = 393,
		Beyond-GameQuitState-OnLeave0 = 394,
		Beyond-GameSoftRestartState-OnEnter0 = 395,
		Beyond-GameSoftRestartState-_SoftRestart0 = 396,
		Beyond-LoginManager-ClearSync0 = 400,
		Beyond-Login-LoginWorkFlow-ClearEnteredPreloadThisSession0 = 401,
		Beyond-GameStartState-OnEnter0 = 405,
		Beyond-GameStartState-_OnEnterMainGame0 = 406,
		Beyond-LoginManager-InvokeWhenWorkFlowFinished0 = 408,
		Beyond-GameStartState-OnLeave0 = 409,
		Beyond-GameStateBase-OnTick0 = 410,
		Beyond-GameStateMachine-_RegisterStates0 = 411,
		Beyond-GameStateMachine-CheckCanReturnToLoginState0 = 412,
		Beyond-GameStateMachine-ReturnToLoginState0 = 413,
		Beyond-GlobalInitializer-InitGlobalConfig0 = 420,
		Beyond-LoginController-Awake0 = 421,
		Beyond-LoginController-Start0 = 422,
		Beyond-LoginController-GetEnterGamePanelPredelay0 = 423,
		Beyond-LoginController-OnValueChanged0 = 424,
		Beyond-Login-LoginWorkFlow-SendEvent0 = 425,
		Beyond-Login-LoginWorkFlow-_HandleGlobalEvent0 = 426,
		Beyond-Login-LoginWorkFlow-_EventOnOpenAgeTips0 = 427,
		Beyond-Login-LoginAgeTipsModel-IsContentEmpty0 = 429,
		Beyond-Login-LoginWorkFlow-_FetchAgeTipsCoroutine0 = 430,
		Beyond-LoginContext-ViewOnlyController0 = 434,
		Beyond-LoginController-MaskCtrl-EnableNetMask0 = 435,
		Beyond-LoginController-MaskCtrl-DisableNetMask0 = 436,
		Beyond-Login-LoginRootPanel-ToggleLoginBindingGroup0 = 440,
		Beyond-Login-LoginWorkFlow-_EventOnCloseAgeTips0 = 441,
		Beyond-Login-LoginWorkFlow-_EventOnOpenServerSelect0 = 442,
		Beyond-Login-LoginWorkFlow-_EventOnSelectServer0 = 445,
		Beyond-Login-LoginServerSelectModel-UpdateSelectedServer0 = 446,
		Beyond-Login-LoginServerSelectModel-get_serverList0 = 447,
		Beyond-Login-LoginWorkFlow-_EventOnConfirmServer0 = 448,
		Beyond-Login-LoginServerSelectModel-GetSelectedServer0 = 449,
		Beyond-Login-LoginWorkFlow-Node-OnEvent0 = 450,
		Beyond-LoginController-MockLoginWithCallback0 = 451,
		Beyond-LoginController-_MockLoginCoroutine0 = 454,
		Beyond-Login-LoginMockUIDPanel-LoginWithCallback0 = 460,
		Beyond-Login-LoginMockUIDPanel-_UpdateStatus0 = 461,
		Beyond-Login-LoginMockUIDPanel-_OnBtnEnterGame0 = 463,
		Beyond-Login-LoginMockUIDPanel-_SaveConfig0 = 464,
		Beyond-Login-LoginMockUIDPanel-_OnBtnDelLocalFile0 = 466,
		Beyond-Login-LoginMockUIDPanel-_TryClosePanel0 = 468,
		Beyond-Login-LoginMockUIDPanel-FOptions-IsUIDFixed0 = 469,
		Beyond-Login-LoginMockUIDPanel-_InitLoginInfo0 = 470,
		Beyond-Login-LoginMockUIDPanel-_OnSelectServer0 = 472,
		Beyond-Login-LoginMockUIDPanel-HideAndDestroy0 = 473,
		Beyond-LoginController-Dialog-_CloseCoroutine0 = 484,
		Beyond-LoginController-Dialog-TryCloseWithCallback0 = 491,
		Beyond-LoginController-Dialog-Show0 = 492,
		Beyond-LoginController-Dialog-OnInit0 = 493,
		Beyond-LoginController-MaskCfg-CreateTweenAndHide0 = 494,
		Beyond-LoginController-MaskCtrl-IsMaskTweening0 = 495,
		Beyond-LoginContext-StopCoroutine0 = 496,
		Beyond-LoginContext-SendEvent0 = 497,
		Beyond-LoginManager-SceneComponentOnly_Bind0 = 498,
		Beyond-LoginManager-_BindPendingComponents0 = 499,
		Beyond-Login-LoginSceneComponent-Bind0 = 500,
		Beyond-Login-LoginSceneComponent-OnBindToManager0 = 503,
		Beyond-LoginManager-ToggleLoginBindingGroup0 = 504,
		Beyond-LoginManager-VocResSelDialog0 = 505,
		Beyond-LoginManager-VocResSelDialogWithConfirm0 = 506,
		Beyond-LoginManager-AlertDialogWithResult0 = 515,
		Beyond-LoginManager-AlertDialogWithConfirm0 = 524,
		Beyond-LoginManager-JudgeDialog0 = 533,
		Beyond-LoginManager-_StartShowJudgeDialogCoroutine0 = 534,
		Beyond-LoginManager-JudgeDialog1 = 535,
		Beyond-LoginManager-MockLoginWithCallback0 = 536,
		Beyond-LoginManager-MockManualSelectServer0 = 537,
		Beyond-LoginManager-IsLoginSceneLoading0 = 540,
		Beyond-LoginManager-FetchRemoteConfigUtilSuc0 = 541,
		Beyond-LoginManager-_ExtractErrorInfo0 = 545,
		Beyond-LoginManager-DevOnlyCheckEnableLocalResMode0 = 549,
		Beyond-LoginManager-DevOnlyUseLocalResVersion0 = 550,
		Beyond-LoginManager-AssetLoader-_CheckDisposedBeforeLoad0 = 551,
		Beyond-LoginManager-FlowWithMaskMgr-StartFlow0 = 552,
		Beyond-LoginManager-FlowWithMaskMgr-_FlowCoroutine0 = 553,
		Beyond-LoginManager-FlowWithMaskMgr-_OnFlowFinished0 = 557,
		Beyond-LoginManager-FFlowCondition-IsTargetMatch0 = 558,
		Beyond-VietnamLoginAgePanel-OnApplicationQuit0 = 564,
		Beyond-VietnamLoginAgeTipsPanelCtrl-Awake0 = 565,
		Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateTips0 = 566,
		Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateCircle0 = 567,
		Beyond-TailGameLoop-Update0 = 568,
		Beyond-TailGameLoop-LateUpdate0 = 569,
		Beyond-UI-SplashController-Awake0 = 570,
		Beyond-UI-SplashController-OnDestroy0 = 571,
		Beyond-SDK-PlatformFont-GetFont0 = 572,
		Beyond-SDK-SDKNetUtils-HTTPPost0 = 573,
		Beyond-SDK-SDKNetUtils-HTTPGet0 = 574,
		Beyond-SDK-SDKNetUtils-BeyondHttp-DoHTTP0 = 575,
		Beyond-SDK-Impl-U8ExternalTools-IsInited0 = 582,
		Beyond-SDK-Impl-U8ExternalTools-NeedRetryInit0 = 583,
		Beyond-SDK-Impl-U8ExternalTools-NeedQuitGame0 = 584,
		Beyond-SDK-Impl-U8ExternalTools-RetryInitSDKSystem0 = 585,
		Beyond-SDK-Impl-U8ExternalTools-InitSDKSystem0 = 586,
		Beyond-SDK-Impl-U8ExternalTools-_OnRequestExitGame0 = 587,
		Beyond-SDK-Impl-U8ExternalTools-WaitForInited0 = 593,
		Beyond-SDK-Impl-U8ExternalTools-InitHGSDK0 = 600,
		Beyond-SDK-Impl-U8ExternalTools-IsHGSDKInited0 = 601,
		Beyond-SDK-Impl-U8ExternalTools-WaitForInitHGSDK0 = 602,
		Beyond-SDK-Impl-U8ExternalTools-Log0 = 609,
		Beyond-SDK-Impl-U8ExternalTools-LogError0 = 610,
		Beyond-SDK-Impl-U8ExternalTools-LogWarning0 = 611,
		Beyond-SDK-Impl-U8ExternalTools-GetSignKey0 = 612,
		Beyond-SDK-Impl-U8ExternalTools-GetDeviceIDs0 = 613,
		Beyond-SDK-Impl-U8ExternalTools-SetSubChannel0 = 614,
		Beyond-SDK-Impl-U8ExternalTools-GetPlatformKey0 = 615,
		Beyond-SDK-Impl-U8ExternalTools-OnSDKExtraInfo0 = 616,
		Beyond-SDK-Impl-U8ExternalTools-_ProcessExtraInfo0 = 617,
		Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-OnGT3Message0 = 618,
		Beyond-SDK-Impl-U8ExternalTools-U8RootUrl0 = 619,
		Beyond-SDK-Impl-U8ExternalTools-POSTImplementation0 = 620,
		Beyond-SDK-Impl-U8ExternalTools-_ConvertToPOSTResult0 = 623,
		Beyond-SDK-Impl-U8ExternalTools-_OnFakeAccountCenter0 = 624,
		Beyond-SDK-Impl-U8ExternalTools-CreateCaptchaHandler0 = 625,
		Beyond-SDK-Impl-U8ExternalTools-GetErrorMessage0 = 626,
		Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_GET_TOKEN0 = 627,
		Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_CREATE_ORDER0 = 628,
		Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-FetchCaptchaCoroutine0 = 629,
		Beyond-SDK-Impl-U8Plugin-GetPayAddition0 = 636,
		Beyond-SDK-Impl-U8Plugin-GetSDKToken0 = 637,
		Beyond-SDK-Impl-U8Plugin-GetSDKUid0 = 638,
		Beyond-SDK-Impl-U8Plugin-Init0 = 639,
		Beyond-SDK-Impl-U8Plugin-Login0 = 640,
		Beyond-SDK-Impl-U8Plugin-_UseMockVersion0 = 641,
		Beyond-SDK-Impl-U8Plugin-_MockLogin0 = 642,
		Beyond-SDK-Impl-U8Plugin-Logout0 = 645,
		Beyond-SDK-Impl-U8Plugin-OnProductListChanged0 = 646,
		Beyond-SDK-Impl-U8Plugin-Pay0 = 647,
		Beyond-SDK-Impl-U8Plugin-TryLoadSDKMeta0 = 651,
		Beyond-Login-LoginCheckForUpdateNode-Work0 = 652,
		Beyond-Login-LoginGameUpdater-Clear0 = 655,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutine0 = 656,
		Beyond-Login-LoginCheckForUpdateNode-AlertNoMatchDeviceBeforeLogin0 = 660,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutinePC0 = 667,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdatePC0 = 671,
		Beyond-Login-LoginCheckForUpdateNode-_GetOnlineAppVersion0 = 675,
		Beyond-Login-LoginCheckForUpdateNode-_GetRequestPram0 = 679,
		Beyond-Login-LoginGameUpdater-ShowWaitProgress0 = 683,
		Beyond-Login-LoginGameUpdater-GetWaitTime0 = 684,
		Beyond-Login-LoginGameUpdater-ClearWaitProgress0 = 691,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutineMobile0 = 695,
		Beyond-Login-LoginGameUpdater-CheckLastGameInfo0 = 699,
		Beyond-Login-LoginGameUpdater-_GetLastGameInfo0 = 703,
		Beyond-Login-LoginGameUpdater-_CreateDirectoryIfNotExists0 = 707,
		Beyond-Login-LoginGameUpdater-Context-CompleteWithCode0 = 708,
		Beyond-Login-LoginGameUpdater-Context-UncompleteWithCode0 = 711,
		Beyond-Login-LoginGameUpdater-GetNoAlertCode0 = 712,
		Beyond-Login-LoginWorkFlow-Fallback0 = 722,
		Beyond-Login-LoginWorkFlow-FWork-MarkFallback0 = 723,
		Beyond-Login-LoginCreateRoleNode-OnDispose0 = 727,
		Beyond-Login-LoginCreateRoleNode-WorkProcess-Dispose0 = 728,
		Beyond-Login-LoginCreateRoleNode-CanCancel0 = 729,
		Beyond-Login-LoginCreateRoleNode-Work0 = 730,
		Beyond-Login-LoginDownloadTask-GetDownloadProgress0 = 731,
		Beyond-Login-LoginDownloadTask-GetDecompressProgress0 = 732,
		Beyond-Login-LoginDownloadTask-GetWorkState0 = 733,
		Beyond-Login-LoginDownloadTask-Tick0 = 734,
		Beyond-Login-LoginDownloadTask-Dispose0 = 735,
		Beyond-Login-LoginDownloadTask-_StartDownload0 = 736,
		Beyond-Login-LoginDownloadTask-_GetFileList0 = 737,
		Beyond-Login-LoginDownloadTask-_StartDownloadImpl0 = 738,
		Beyond-Login-LoginDownloadTask-_GetAllFileList0 = 739,
		Beyond-Login-LoginWorkFlow-HasEnteredPreloadThisSession0 = 740,
		Beyond-Login-NetUsagePolicy-AllowMobileDataInLastCheck0 = 741,
		Beyond-Login-LoginDownloadTask-_OnDownloadFinish0 = 742,
		Beyond-Login-LoginDownloadTask-_OnDownloadError0 = 743,
		Beyond-Login-LoginDownloadTask-_OnDownloadPaused0 = 745,
		Beyond-Login-NetUsagePolicy-CheckIfAllowDownload0 = 751,
		Beyond-Login-NetUsagePolicy-_GetPrettySizeStringUpToMB0 = 755,
		Beyond-Login-LoginGameSettingInitializer-Awake0 = 756,
		Beyond-Login-LoginGameSettingInitializer-_TryInitializeComponents0 = 757,
		Beyond-Login-LoginGameSettingInitializer-OnEnable0 = 758,
		Beyond-Login-LoginGameSettingInitializer-_InitGameSettingStateInLogin0 = 759,
		Beyond-Login-LoginGameSettingInitializer-_InitGameSettingNotchPadding0 = 760,
		Beyond-Login-LoginGameUpdateNode-Work0 = 762,
		Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutine0 = 764,
		Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutineMobileImpl0 = 771,
		Beyond-Login-LoginGameUpdater-DoUpdate0 = 775,
		Beyond-Login-LoginGameUpdater-_UpdateGame0 = 779,
		Beyond-Login-LoginGameUpdater-_YieldCheckNetUsagePolicy0 = 783,
		Beyond-Login-LoginGameUpdater-_YieldErrorAlert0 = 795,
		Beyond-Login-LoginGameUpdater-_DoTaskUpdating0 = 804,
		Beyond-Login-LoginGameUpdater-_OnDownloadStart0 = 808,
		Beyond-Login-LoginGameUpdater-_OnDownloadProgress0 = 809,
		Beyond-Login-LoginGameUpdater-_WaitForTaskCancel0 = 816,
		Beyond-Login-LoginGSNode-Work0 = 829,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-EnterGame0 = 830,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_EnterGameCoroutine0 = 831,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_OnAuthError0 = 836,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ReLoginWhenErrorEncountered0 = 840,
		Beyond-Login-LoginGSNode-_FallbackToInitWithMask0 = 841,
		Beyond-Login-LoginGSNode-_FallbackToInitNodeImpl0 = 843,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-TryInterrupt0 = 844,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-IsInterruptable0 = 845,
		Beyond-Login-LoginGSNode-_LogoutToInitNode0 = 846,
		Beyond-Login-LoginGSNode-_ConfirmServer0 = 850,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_NetConnectAndGSLogin0 = 857,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_SaveCurrentUserToServerConfig0 = 861,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_MockManualSelectServer0 = 865,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_GlobalLoginSucBusiness0 = 880,
		Beyond-Login-LoginGSNode-OnEvent0 = 885,
		Beyond-Login-LoginGSNode-_OnEventLogout0 = 886,
		Beyond-Login-LoginGSNode-_OnEventResourceRepair0 = 888,
		Beyond-Login-LoginGSNode-_FallbackToResRepairImpl0 = 890,
		Beyond-Login-LoginViewModel-RequestResourceRepair0 = 891,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-MarkAborting0 = 894,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ExtractErrorInfo0 = 895,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_YieldAlertError0 = 896,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetCurrent0 = 903,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetTotal0 = 904,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetInfo0 = 905,
		Beyond-Login-LoginHotUpdater-MarkInitialAssetChanged0 = 906,
		Beyond-Login-LoginHotUpdater-CheckInitialAssetChanged0 = 907,
		Beyond-Login-LoginHotUpdater-MarkNeedClearFolder0 = 908,
		Beyond-Login-LoginHotUpdater-NeedClearFolder0 = 909,
		Beyond-Login-LoginHotUpdater-MarkClearSuccessed0 = 910,
		Beyond-Login-LoginHotUpdater-MarkSoftRestart0 = 911,
		Beyond-Login-LoginHotUpdater-ClearSoftRestartFlag0 = 912,
		Beyond-Login-LoginHotUpdater-Dispose0 = 913,
		Beyond-Login-LoginLocalResTask-Dispose0 = 914,
		Beyond-Login-LoginHotUpdater-StartHotUpdate0 = 915,
		Beyond-Login-LoginHotUpdater-_Work0 = 916,
		Beyond-Login-LoginHotUpdater-_UpdateResVersion0 = 920,
		Beyond-Login-LoginHotUpdater-_UpdateResVersionDev0 = 924,
		Beyond-Login-LoginHotUpdater-_UpdateResVersionProd0 = 931,
		Beyond-Login-LoginHotUpdater-_SetResVersionForLog0 = 941,
		Beyond-Login-LoginHotUpdater-_CreateMainCoroutine0 = 942,
		Beyond-Login-LoginHotUpdater-_CurrentWorkMode0 = 946,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeDownload0 = 947,
		Beyond-Login-LoginHotUpdater-_GetOnlineResVersion0 = 953,
		Beyond-Login-LoginHotUpdater-WorkContext-GetHotUpdateInfo0 = 954,
		Beyond-Login-LoginHotUpdater-_CheckAndDownloadResource0 = 955,
		Beyond-Login-LoginHotUpdater-_GenResIndex0 = 959,
		Beyond-Login-LoginHotUpdater-_LoadOrDownloadResIndex0 = 963,
		Beyond-Login-LoginHotUpdater-_ResourceIndexUrl0 = 970,
		Beyond-Login-LoginHotUpdater-ResourceRootUrl0 = 971,
		Beyond-Login-LoginHotUpdater-_GenRiff0 = 978,
		Beyond-Login-LoginHotUpdater-_ResourcePatchUrl0 = 982,
		Beyond-Login-LoginHotUpdater-_ResourceFileUrl0 = 983,
		Beyond-Login-LoginHotUpdater-_LoadStreamingIndex0 = 984,
		Beyond-Login-LoginHotUpdater-_DownloadPatchInfo0 = 996,
		Beyond-Login-LoginHotUpdater-_ResourcePatchRootUrl0 = 1000,
		Beyond-Login-LoginHotUpdater-_CreateUpdatedLocalResPref0 = 1004,
		Beyond-Login-LoginHotUpdater-_EventLogDownloadProgress0 = 1006,
		Beyond-Login-LoginHotUpdater-_GenLocalRef0 = 1007,
		Beyond-Login-LoginHotUpdater-WriteLocalResPrefToFile0 = 1011,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-CheckIfNeedReload0 = 1018,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasChangedByType0 = 1019,
		Beyond-Login-LoginHotUpdater-_CheckLocalResConsistency0 = 1020,
		Beyond-Login-LoginHotUpdater-WorkContext-MarkIllegalItemsInLocalRes0 = 1024,
		Beyond-Login-LoginHotUpdater-_ClearDownloadFolder0 = 1033,
		Beyond-Login-LoginHotUpdater-_ReloadResourceIndexes0 = 1040,
		Beyond-Login-LoginHotUpdater-WorkContext-HasChangedByType0 = 1044,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeLocal0 = 1051,
		Beyond-Login-LoginLocalResTask-Work0 = 1055,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeSkip0 = 1068,
		Beyond-Login-LoginHotUpdater-_VitalError0 = 1078,
		Beyond-Login-LoginViewModel-RequestSkipU8Login0 = 1082,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasAssetsChanged0 = 1091,
		Beyond-Login-LoginProgress-GetCurrent0 = 1092,
		Beyond-Login-LoginProgress-GetTotal0 = 1093,
		Beyond-Login-LoginProgress-GetInfo0 = 1094,
		Beyond-Login-LoginProgress-FDownloadSize-SetSize0 = 1095,
		Beyond-Login-LoginProgress-FDownloadSize-_PickUnit0 = 1096,
		Beyond-Login-LoginProgress-FDownloadSize-_DisplayWithUnit0 = 1097,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatDisplayInfo0 = 1098,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatSpeedInfo0 = 1099,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatProgressInfo0 = 1100,
		Beyond-Login-LoginProgress-FDownloadSize-SetProgress0 = 1101,
		Beyond-Login-LoginProgress-FDownloadSize-SetIdle0 = 1102,
		Beyond-Login-LoginInitNode-Work0 = 1103,
		Beyond-Login-LoginInitNode-_InitCoroutine0 = 1104,
		Beyond-Login-LoginInitNode-_InitRemoteConfigs0 = 1108,
		Beyond-Login-LoginInitNode-_YieldAlertError0 = 1112,
		Beyond-Login-PreloadNode-Work0 = 1125,
		Beyond-Login-LoginWorkFlow-MarkEnteredPreloadThisSession0 = 1126,
		Beyond-Login-PreloadNode-_ShowPreloadResourcePanel0 = 1127,
		Beyond-Login-PreloadNode-_LoginPreLoad0 = 1128,
		Beyond-Login-PreloadNode-_WarmUp0 = 1132,
		Beyond-Login-PreloadNode-_GetServerList0 = 1139,
		Beyond-Login-PreloadNode-_GetServerListInfoMock0 = 1143,
		Beyond-Login-PreloadNode-_OnGetServerListSuc0 = 1147,
		Beyond-Login-PreloadNode-_GetServerListInfo0 = 1154,
		Beyond-Login-PreloadNode-_OnGetServerListFail0 = 1158,
		Beyond-Login-PreloadNode-_EnterPreLoad0 = 1165,
		Beyond-Login-LoginSDKInitNode-Work0 = 1172,
		Beyond-Login-LoginSDKInitNode-_SDKInitCoroutine0 = 1173,
		Beyond-Login-LoginSDKInitNode-_WaitForSDKInited0 = 1177,
		Beyond-Login-LoginSDKInitNode-_InitSubSDKs0 = 1184,
		Beyond-Login-U8LoginNode-Work0 = 1194,
		Beyond-Login-U8LoginNode-_LoginCoroutine0 = 1195,
		Beyond-Login-U8LoginNode-_ClearLoginCaches0 = 1199,
		Beyond-Login-U8LoginNode-_SkipSDKLogin0 = 1200,
		Beyond-Login-U8LoginNode-_EnableBlurMask0 = 1201,
		Beyond-Login-U8LoginNode-_OnLoginSuc0 = 1202,
		Beyond-Login-U8LoginNode-_OnSDKViewDisabled0 = 1203,
		Beyond-Login-LoginRootPanel-InitBulletinAndRedAfterLoginSuc0 = 1204,
		Beyond-Login-LoginMenuPanel-InitBulletinAndRedAfterLoginSuc0 = 1205,
		Beyond-Login-LoginMenuPanel-_UpdateAnnounceRedDot0 = 1206,
		Beyond-Login-LoginMenuPanel-_OnReceiveRedDotAndPopup0 = 1207,
		Beyond-Login-LoginMenuPanel-_OnBulletinOpen0 = 1208,
		Beyond-Login-LoginMenuPanel-_OnBulletinClose0 = 1209,
		Beyond-Login-U8LoginNode-_StartSDKLogin0 = 1210,
		Beyond-Login-U8LoginNode-_SetCursorOnLoginStart0 = 1211,
		Beyond-Login-U8LoginNode-_SetCursorOnLoginFinish0 = 1213,
		Beyond-Login-U8LoginNode-_OnLoginFail0 = 1215,
		Beyond-Login-U8LoginNode-_OnLoginCanceled0 = 1216,
		Beyond-Login-U8LoginNode-_FinishLogin0 = 1217,
		Beyond-Login-U8LoginNode-OnEvent0 = 1227,
		Beyond-Login-LoginViewModel-IsAgeTipsVisible0 = 1228,
		Beyond-Login-LoginViewModel-IsGovTipsVisible0 = 1229,
		Beyond-Login-LoginViewModel-IsMenuVisible0 = 1230,
		Beyond-Login-LoginViewModel-_LoadAgeTipsPolicy0 = 1231,
		Beyond-Login-LoginAgeTipsModel-CanDisplay0 = 1232,
		Beyond-Login-LoginAgeTipsProp-ClearContentCache0 = 1233,
		Beyond-Login-LoginAgeTipsProp-UpdateContent0 = 1234,
		Beyond-Login-LoginWorkFlow-_RegisterNodes0 = 1235,
		Beyond-Login-LoginWorkFlow-CancelAndFallback0 = 1236,
		Beyond-Login-LoginWorkFlow-Worker-Cancel0 = 1237,
		Beyond-Login-LoginWorkFlow-Node-CanCancel0 = 1238,
		Beyond-Login-LoginWorkFlow-AddEventReceiver0 = 1239,
		Beyond-Login-LoginWorkFlow-UpdateOnce0 = 1240,
		Beyond-Login-LoginWorkFlow-Worker-UpdateOnce0 = 1241,
		Beyond-Login-LoginWorkFlow-Node-Init0 = 1242,
		Beyond-Login-LoginWorkFlow-Node-OnInit0 = 1245,
		Beyond-Login-HotUpdateNode-Work0 = 1246,
		Beyond-Login-HotUpdateNode-OnDispose0 = 1247,
		Beyond-Login-WaitForSecondsNode-Work0 = 1248,
		Beyond-Login-WaitForSecondsNode-_NotifyTimeout0 = 1249,
		Beyond-Login-WaitForSecondsNode-_IsTimeout0 = 1250,
		Beyond-Login-WaitForSecondsNode-_DisposeTimer0 = 1251,
		Beyond-Login-WaitForSecondsNode-OnDispose0 = 1252,
		Beyond-Login-PreloadPostDelayNode-WaitForSeconds0 = 1253,
		Beyond-Login-PreloadPostDelayNode-Work0 = 1254,
		Beyond-Login-PreloadPostDelayNode-_DisableLoadingPanel0 = 1255,
		Beyond-Login-Trans2GsLoginNode-WaitForSeconds0 = 1256,
		Beyond-Login-Trans2GsLoginNode-Work0 = 1257,
		Beyond-Login-FinishNode-Work0 = 1258,
		Beyond-Login-LoginSceneAnimCtrl-OnBindToManager0 = 1259,
		Beyond-Login-LoginSceneAnimCtrl-_EnsurePlayer0 = 1261,
		Beyond-Login-LoginSceneAnimCtrl-_ChangeToState0 = 1262,
		Beyond-Login-LoginSceneAnimCtrl-_ResetToA10 = 1263,
		Beyond-Login-LoginSceneAnimCtrl-_RandomIntervalA1s0 = 1264,
		Beyond-Login-LoginSceneAnimCtrl-_TransitionToA20 = 1265,
		Beyond-Login-LoginSceneAnimCtrl-_PlayA1A2Impl0 = 1266,
		Beyond-Login-LoginSceneAnimCtrl-_PlayA1sAndTriggerNext0 = 1267,
		Beyond-Login-LoginSceneAnimCtrl-OnValueChanged0 = 1268,
		Beyond-Login-LoginSceneAnimCtrl-Start0 = 1269,
		Beyond-Login-LoginSceneComponent-Start0 = 1270,
		Beyond-Login-LoginSceneAnimCtrl-Tick0 = 1271,
		Beyond-Login-LoginSceneAnimCtrl-OnRelease0 = 1272,
		Beyond-Login-LoginSceneAnimCtrl-GetAnimationClips0 = 1273,
		Beyond-Login-LoginSceneRoot-OnBindToManager0 = 1274,
		Beyond-Login-LoginAgeTipsDetailPanel-Init0 = 1275,
		Beyond-Login-LoginAgeTipsDetailPanel-_EventOnCloseClicked0 = 1276,
		Beyond-Login-LoginAgeTipsDetailPanel-OnValueChanged0 = 1277,
		Beyond-Login-LoginAgeTipsDetailPanel-_RenderContent0 = 1278,
		Beyond-Login-LoginAgeTipsDetailPanel-_SplitLicenseToSegments0 = 1279,
		Beyond-Login-LoginAgeTipsDetailPanel-_SplitLongString0 = 1280,
		Beyond-Login-LoginAgeTipsDetailPanel-_ShowContent0 = 1281,
		Beyond-Login-LoginAgeTipsPanel-OnInit0 = 1282,
		Beyond-Login-LoginAgeTipsPanel-_EventOnOpenAgeTipsClicked0 = 1284,
		Beyond-Login-LoginAgeTipsPanel-OnValueChanged0 = 1285,
		Beyond-Login-LoginAgeTipsPanel-_UpdateAgeTipsPolicy0 = 1286,
		Beyond-Login-LoginAlertDialog-OnInit0 = 1287,
		Beyond-Login-LoginAlertDialog-_OnConfirmClicked0 = 1288,
		Beyond-Login-LoginDecorateUI-OnValueChanged0 = 1289,
		Beyond-Login-LoginDecorateUI-_TriggerTrans2GSLoginImpl0 = 1290,
		Beyond-Login-LoginDecorateUI-Tick0 = 1291,
		Beyond-Login-LoginDecorateUI-_TimeManagerTick0 = 1292,
		Beyond-Login-LoginDecorateUI-OnRelease0 = 1293,
		Beyond-Login-LoginEnterGamePanel-_InitIfNot0 = 1294,
		Beyond-Login-LoginEnterGamePanel-_OnEnterGameClicked0 = 1295,
		Beyond-Login-LoginEnterGamePanel-OnValueChanged0 = 1296,
		Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByFadeSwitchTween0 = 1297,
		Beyond-Login-LoginGovTipsPanel-OnInit0 = 1300,
		Beyond-Login-LoginGovTipsPanel-_EventOnOpenAgeTipsClicked0 = 1301,
		Beyond-Login-LoginGovTipsPanel-OnValueChanged0 = 1302,
		Beyond-Login-LoginJudgeDialog-OnInit0 = 1303,
		Beyond-Login-LoginJudgeDialog-_OnPositiveClicked0 = 1304,
		Beyond-Login-LoginJudgeDialog-_OnNegativeClicked0 = 1305,
		Beyond-Login-LoginMenuPanel-OnInit0 = 1306,
		Beyond-Login-LoginMenuPanel-_OnAnnounceClicked0 = 1307,
		Beyond-Login-LoginMenuPanel-_OnAnnounceClosed0 = 1309,
		Beyond-Login-LoginMenuPanel-_OnSettingClicked0 = 1311,
		Beyond-Login-LoginMenuPanel-_OnResCheckClicked0 = 1313,
		Beyond-Login-LoginMenuPanel-_OnLogoutClicked0 = 1315,
		Beyond-Login-LoginMenuPanel-_OnQuitGameClicked0 = 1317,
		Beyond-Login-LoginMenuPanel-_OnLoginClicked0 = 1321,
		Beyond-Login-LoginMenuPanel-_OnQRClicked0 = 1322,
		Beyond-Login-LoginMenuPanel-_OnServerZoneBtnClicked0 = 1325,
		Beyond-Login-LoginMenuPanel-_OnFocusMenuGroup0 = 1327,
		Beyond-Login-LoginMenuPanel-OnValueChanged0 = 1328,
		Beyond-Login-LoginMenuPanel-_CanQRLogin0 = 1329,
		Beyond-Login-LoginMenuPanel-Awake0 = 1330,
		Beyond-Login-LoginMenuPanel-_UpdateServerZone0 = 1331,
		Beyond-Login-LoginMenuPanel-OnEnable0 = 1332,
		Beyond-Login-LoginMenuPanel-_OnRequestRelogin0 = 1333,
		Beyond-Login-LoginMenuPanel-_OnInputChanged0 = 1334,
		Beyond-Login-LoginMenuPanel-_OnUpdateRedDotForSDKListener0 = 1335,
		Beyond-Login-LoginMenuPanel-OnDisable0 = 1336,
		Beyond-Login-LoginMenuPanel-OnDestroy0 = 1337,
		Beyond-Login-LoginRootPanel-ChildPanel-OnDestroy0 = 1338,
		Beyond-Login-LoginMenuPanel-_OnCustomServiceClicked0 = 1339,
		Beyond-Login-LoginMenuPanel-_OnAccountCenterClicked0 = 1340,
		Beyond-Login-LoginMockUIDPanel-Refresh0 = 1341,
		Beyond-Login-LoginMockUIDPanel-_SmokeEnterGame0 = 1342,
		Beyond-Login-LoginMockUIDPanel-OnDestroy0 = 1343,
		Beyond-Login-LoginResourcePanel-OnValueChanged0 = 1344,
		Beyond-Login-LoginResourcePanel-_UpdateResourceInfo0 = 1345,
		Beyond-Login-LoginResourcePanel-Update0 = 1346,
		Beyond-Login-LoginRootPanel-Awake0 = 1347,
		Beyond-Login-LoginRootPanel-_OnNotchPaddingChanged0 = 1348,
		Beyond-Login-LoginRootPanel-OnDestroy0 = 1349,
		Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByAnimSwitchTween0 = 1350,
		Beyond-Login-LoginServerSelectItemView-RefreshView0 = 1351,
		Beyond-Login-LoginServerSelectItemView-_OnClicked0 = 1352,
		Beyond-Login-LoginServerSelectItemView-NaviToBtnTarget0 = 1353,
		Beyond-Login-LoginServerSelectItemView-SetSelected0 = 1354,
		Beyond-Login-LoginServerSelectModel-InitData0 = 1355,
		Beyond-Login-LoginServerSelectPanel-OnInit0 = 1356,
		Beyond-Login-LoginServerSelectPanel-_OnConfirmClicked0 = 1357,
		Beyond-Login-LoginServerSelectPanel-_OnCloseClicked0 = 1358,
		Beyond-Login-LoginServerSelectPanel-_UpdateServerCell0 = 1359,
		Beyond-Login-LoginServerSelectPanel-OnDisable0 = 1360,
		Beyond-Login-LoginServerSelectPanel-_OnInputChanged0 = 1361,
		Beyond-Login-LoginServerSelectPanel-_NaviToSelectedItem0 = 1362,
		Beyond-Login-LoginServerSelectPanel-OnEnable0 = 1363,
		Beyond-Login-LoginServerSelectPanel-_WaitingForShowListAwake0 = 1367,
		Beyond-Login-LoginServerSelectPanel-_UpdateServerSelected0 = 1374,
		Beyond-Login-LoginServerSelectPanel-OnValueChanged0 = 1375,
		Beyond-Login-LoginVersionPanel-Start0 = 1376,
		Beyond-Login-LoginVersionPanel-get_displayGameVersion0 = 1377,
		Beyond-Login-LoginVocResSelDialog-OnInit0 = 1378,
		Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked1 = 1379,
		Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked0 = 1380,
		Beyond-Login-LoginVocResSelDialog-_UpdateCell0 = 1381,
		Beyond-Login-LoginVocResSelItemView-RefreshView0 = 1382,
		Beyond-Login-LoginVocResSelItemView-_OnClicked0 = 1383,
		Beyond-Login-LoginVocResSelDialog-UpdateSelected0 = 1384,
		Beyond-Login-LoginVocResSelDialog-_UpdateList0 = 1385,
		Beyond-Login-LoginVocResSelDialog-_UpdateSelected0 = 1386,
		Beyond-Login-LoginVocResSelItemView-SetSelected0 = 1387,
		Beyond-Login-LoginVocResSelDialog-_NaviToSelectedItem0 = 1388,
		Beyond-Login-LoginVocResSelItemView-NaviToBtnTarget0 = 1389,
		Beyond-Login-LoginVocResSelDialog-OnEnable0 = 1390,
		Beyond-Login-LoginVocResSelDialog-_OnInputTypeChanged0 = 1391,
		Beyond-Login-LoginVocResSelDialog-OnDisable0 = 1392,
		Beyond-Scripts-Entry-WarmUpProgress-GetTotal0 = 1393,
		Beyond-Scripts-Entry-WarmUpProgress-GetCurrent0 = 1394,
		Beyond-Scripts-Entry-WarmUpProgress-GetInfo0 = 1395
	}
}
