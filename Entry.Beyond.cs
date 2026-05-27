/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

// Image 29: Entry.Beyond.dll - Assembly: Entry.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53005-53284
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class RenderSilhouetteRT : MonoBehaviour // TypeDefIndex: 53006
{
	// Fields
	public Camera cameraRT; // 0x18
	public Camera mainCamera; // 0x20
	public Material materialSilhouette; // 0x28
	private static Texture s_mSilhouetteRT; // 0x00
	private static RenderTexture s_mSilhouetteRth; // 0x08

	// Constructors
	public RenderSilhouetteRT() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	private void Update() {} // 0x00000001828AD320-0x00000001828AD6B0
	private void OnDestroy() {} // 0x00000001832FA2B0-0x00000001832FA400
}

namespace Beyond
{
	public class GameApp : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 53010
	{
		// Fields
		private GameStateMachine m_stateMachine; // 0x18
		private bool m_hasFocus; // 0x20
		private bool m_needCallLuaFocus; // 0x21
		private bool m_pauseStatus; // 0x22
		private bool m_needCallLuaPause; // 0x23
	
		// Properties
		public static GameApp instance { get; private set; } // 0x000000018576CF50-0x000000018576CF88 0x000000018576CF88-0x000000018576CFD8
		public GameState currentState { get => default; } // 0x00000001828AC670-0x00000001828AC6B0 
	
		// Constructors
		public GameApp() {} // 0x0000000183A1E660-0x0000000183A1E670
	
		// Methods
		public void SwitchState(GameState state) {} // 0x0000000182C35180-0x0000000182C351F0
		private void Awake() {} // 0x0000000183157A50-0x0000000183157C50
		private void _RegisterLuaAfterGCEvent() {} // 0x000000018332FD80-0x000000018332FEA0
		private void Update() {} // 0x0000000182632400-0x00000001826326D0
		private void LateUpdate() {} // 0x0000000182EC53C0-0x0000000182EC5470
		private void OnApplicationQuit() {} // 0x000000018576C72C-0x000000018576C954
		private void OnApplicationFocus(bool hasFocus) {} // 0x00000001829A6920-0x00000001829A6A50
		private void _OnApplicationFocusForLua() {} // 0x0000000182B54CB0-0x0000000182B54E80
		private void OnApplicationPause(bool pauseStatus) {} // 0x0000000183134CA0-0x0000000183134EB0
		private void _OnApplicationPauseForLua() {} // 0x0000000183134F90-0x0000000183135040
		private void OnDestroy() {} // 0x000000018576C954-0x000000018576CB5C
		private void _PreInitGameSetting() {} // 0x0000000182954CA0-0x0000000182954ED0
		private void _Init() {} // 0x0000000183156EB0-0x00000001831570D0
		private void _UnInit() {} // 0x000000018576CEC0-0x000000018576CF50
		private void _InitGameStateMachine() {} // 0x00000001831573F0-0x0000000183157490
		private void _UnInitGameStateMachine() {} // 0x000000018576CE38-0x000000018576CEC0
		public static void QuitGame(int exitCode) {} // 0x000000018576CB5C-0x000000018576CC18
		public static void RefreshScreenResolution() {} // 0x000000018576CC18-0x000000018576CD18
		private static void _OnSystemDisplaySizeChanged() {} // 0x000000018576CD18-0x000000018576CD58
		private static void _OnSystemScreenSizeChanged([IsReadOnly] in EventData<bool, bool> data) {} // 0x000000018576CD58-0x000000018576CE38
		[IteratorStateMachine(typeof(__InitSecuritySDK_d__31))]
		private IEnumerator _InitSecuritySDK() => default; // 0x00000001831570D0-0x0000000183157140
		private void _OnApplicationPauseForSecurity(bool pauseStatus) {} // 0x0000000182C3E8C0-0x0000000182C3E950
		[IteratorStateMachine(typeof(__FetchRemoteConfigUtilSuc_d__33))]
		private IEnumerator _FetchRemoteConfigUtilSuc() => default; // 0x0000000183D006E0-0x0000000183D00740
	}

	public interface IMemoryPackProxy // TypeDefIndex: 53011
	{
		// Methods
		void Init();
	}

	public class MemoryPackProxyModule // TypeDefIndex: 53012
	{
		// Fields
		private static IMemoryPackProxy s_memoryPackProxy; // 0x00
	
		// Constructors
		public MemoryPackProxyModule() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void RegisterProxy(IMemoryPackProxy memoryPackProxy) {} // 0x000000018576EBA0-0x000000018576EBF0
		public static IMemoryPackProxy GetMemoryPackProxy() => default; // 0x000000018576EB68-0x000000018576EBA0
	}

	public class GameInitState : GameStateBase // TypeDefIndex: 53014
	{
		// Properties
		public override GameState stateId { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public GameInitState() {} // Dummy constructor
		public GameInitState(GameStateMachine stateMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000183157630-0x0000000183157720
		public override void OnLeave(GameState toStateId) {} // 0x0000000182EAA390-0x0000000182EAA430
		[IteratorStateMachine(typeof(__DoInit_d__5))]
		private IEnumerator _DoInit() => default; // 0x0000000183157720-0x0000000183157790
		private void _InitInitialResourceManager(out VirtualFileSystem.BlockValidator blockValidator) {
			blockValidator = default;
		} // 0x000000018315ACC0-0x000000018315AE20
		private bool _CheckIfLocalInitialAssetsValid(out LocalResPref outputLocalResPref, out VirtualFileSystem.BlockValidator blockValidator) {
			outputLocalResPref = default;
			blockValidator = default;
			return default;
		} // 0x0000000182955380-0x00000001829554C0
		private void _InitAPPDefaultCulture() {} // 0x000000018307F820-0x000000018307F9B0
		private void _InitGameSetting() {} // 0x0000000182AB7540-0x0000000182AB7AF0
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x000000018576CFD8-0x000000018576CFE0
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x000000018576CFE0-0x000000018576CFE8
	}

	public class GameLoginState : GameStateBase // TypeDefIndex: 53015
	{
		// Properties
		public override GameState stateId { get => default; } // 0x0000000183D55730-0x0000000183D55740 
	
		// Constructors
		public GameLoginState() {} // Dummy constructor
		public GameLoginState(GameStateMachine stateMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000183157790-0x00000001831578A0
		public override void OnLeave(GameState toStateId) {} // 0x0000000183102F10-0x0000000183102F90
		private static void _TryStartLoginWorkflow() {} // 0x0000000182C3E7E0-0x0000000182C3E8C0
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x000000018576CFD8-0x000000018576CFE0
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x000000018576CFE0-0x000000018576CFE8
	}

	public class GameMainState : GameStateBase // TypeDefIndex: 53016
	{
		// Fields
		private bool m_isFirstEnter; // 0x18
	
		// Properties
		public override GameState stateId { get => default; } // 0x0000000183D55740-0x0000000183D55750 
	
		// Constructors
		public GameMainState() {} // Dummy constructor
		public GameMainState(GameStateMachine stateMachine) {} // 0x00000001842759A8-0x00000001842759BC
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000182EA8690-0x0000000182EA8790
		public override void OnLeave(GameState toStateId) {} // 0x0000000183D22EE0-0x0000000183D22F30
		public static void ReleaseMainGame(GameState toStateId) {} // 0x0000000183102F90-0x0000000183103210
		private static void _ClearUtils() {} // 0x00000001842753D4-0x00000001842754BC
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x000000018576CFD8-0x000000018576CFE0
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x000000018576CFE0-0x000000018576CFE8
	}

	public class GamePreloadState : GameStateBase // TypeDefIndex: 53018
	{
		// Fields
		private Beyond.Cfg.Tables.AsyncLoadTask m_asyncTask; // 0x18
	
		// Properties
		public override GameState stateId { get => default; } // 0x0000000183D55750-0x0000000183D55760 
	
		// Constructors
		public GamePreloadState() {} // Dummy constructor
		public GamePreloadState(GameStateMachine stateMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000183B41720-0x0000000183B417C0
		public override void OnLeave(GameState toStateId) {} // 0x0000000183CF3610-0x0000000183CF3680
		[IteratorStateMachine(typeof(__DoPreload_d__6))]
		private IEnumerator _DoPreload() => default; // 0x0000000183B417C0-0x0000000183B41830
		private void _InitGameSettingStateInPreload() {} // 0x0000000182AB7DC0-0x0000000182ABBBC0
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x000000018576CFD8-0x000000018576CFE0
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x000000018576CFE0-0x000000018576CFE8
	}

	public class GameQuitState : GameStateBase // TypeDefIndex: 53019
	{
		// Properties
		public override GameState stateId { get => default; } // 0x0000000183D55760-0x0000000183D55770 
	
		// Constructors
		public GameQuitState() {} // Dummy constructor
		public GameQuitState(GameStateMachine stateMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x000000018576D424-0x000000018576D48C
		public override void OnLeave(GameState toStateId) {} // 0x000000018576D48C-0x000000018576D4F0
		public static void DoQuit() {} // 0x000000018576CFE8-0x000000018576D424
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x000000018576CFD8-0x000000018576CFE0
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x000000018576CFE0-0x000000018576CFE8
	}

	public class GameSoftRestartState : GameStateBase // TypeDefIndex: 53021
	{
		// Fields
		private const string CLEAR_SCENE_PATH = "Assets/Beyond/Scenes/BuildScenes/Clear.unity"; // Metadata: 0x01FD3343
	
		// Properties
		public override GameState stateId { get => default; } // 0x0000000183D51100-0x0000000183D51110 
	
		// Constructors
		public GameSoftRestartState() {} // Dummy constructor
		public GameSoftRestartState(GameStateMachine stateMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x000000018576D4F0-0x000000018576D5A8
		[IteratorStateMachine(typeof(__SoftRestart_d__5))]
		private IEnumerator _SoftRestart() => default; // 0x000000018576D5A8-0x000000018576D638
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x000000018576CFD8-0x000000018576CFE0
	}

	public class GameStartState : GameStateBase // TypeDefIndex: 53022
	{
		// Properties
		public override GameState stateId { get => default; } // 0x0000000183D55770-0x0000000183D55780 
	
		// Constructors
		public GameStartState() {} // Dummy constructor
		public GameStartState(GameStateMachine stateMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void OnEnter(GameState fromStateId) {} // 0x0000000183B0DAE0-0x0000000183B0DC30
		public override void OnLeave(GameState toStateId) {} // 0x0000000183B6EA40-0x0000000183B6EB40
		private void _OnEnterMainGame() {} // 0x0000000183B46620-0x0000000183B466E0
		public void __iFixBaseProxy_OnEnter(GameState P0) {} // 0x000000018576CFD8-0x000000018576CFE0
		public void __iFixBaseProxy_OnLeave(GameState P0) {} // 0x000000018576CFE0-0x000000018576CFE8
	}

	public abstract class GameStateBase : ISimpleStateNode<GameState>, ILuaCallCSharp // TypeDefIndex: 53023
	{
		// Fields
		protected readonly GameStateMachine m_stateMachine; // 0x10
	
		// Properties
		public abstract GameState stateId { get; }
	
		// Constructors
		protected GameStateBase() {} // Dummy constructor
		protected GameStateBase(GameStateMachine stateMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public virtual void OnEnter(GameState fromStateId) {} // 0x0000000182C384A0-0x0000000182C38530
		public virtual void OnLeave(GameState toStateId) {} // 0x0000000182C38530-0x0000000182C385C0
		public virtual void OnTick(float deltaTime) {} // 0x000000018576D638-0x000000018576D68C
	}

	public class GameStateMachine : SimpleEnumStateMachine<GameState>, IGameStateMachine, ILuaCallCSharp // TypeDefIndex: 53025
	{
		// Properties
		public GameApp app { get; } // 0x0000000181003830-0x0000000181003840 
		public GameState curState { get => default; } // 0x0000000182DEEA70-0x0000000182DEEB70 
	
		// Constructors
		public GameStateMachine() {} // Dummy constructor
		public GameStateMachine(GameApp gameApp) {} // 0x0000000183157490-0x00000001831574F0
	
		// Methods
		private void _RegisterStates() {} // 0x0000000183156C80-0x0000000183156EB0
		public bool CheckCanReturnToLoginState() => default; // 0x0000000182C35000-0x0000000182C35060
		[IteratorStateMachine(typeof(_ReturnToLoginState_d__8))]
		public IEnumerator ReturnToLoginState() => default; // 0x0000000183C94800-0x0000000183C94870
	}

	public static class GlobalInitializer // TypeDefIndex: 53026
	{
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void InitGlobalConfig() {} // 0x0000000183D4C3A0-0x0000000183D4C3C0
	}

	public interface IHotFixCommon // TypeDefIndex: 53027
	{
	}

	public interface IHotFixPatchManagerProxy : IHotFixCommon // TypeDefIndex: 53028
	{
		// Methods
		void InitManager();
		void ReleaseManager();
		void PatchInitAssemble();
		void PatchRemoteInitAssemble();
		void PatchRemoteInjectedLua();
		void PatchMainAssemble();
		void PatchRemoteMainAssemble();
	}

	public class HotFixPatchModules // TypeDefIndex: 53029
	{
		// Fields
		private static Dictionary<System.Type, IHotFixCommon> s_hotFixModules; // 0x00
	
		// Constructors
		public HotFixPatchModules() {} // 0x000000018350B670-0x000000018350B680
		static HotFixPatchModules() {} // 0x0000000183CE4090-0x0000000183CE4120
	
		// Methods
		public static void Register<T>(T module)
			where T : class, IHotFixCommon {}
		public static void UnRegister<T>()
			where T : class, IHotFixCommon {}
		public static T GetModule<T>()
			where T : class, IHotFixCommon => default;
	}

	public static class InitialPathDef // TypeDefIndex: 53030
	{
		// Fields
		public const string LOGIN_SCENE_PATH = "Assets/Beyond/InitialAssets/Scenes/Login.unity"; // Metadata: 0x01FD3370
		public const string LOGIN_SK_ACTOR_M = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_male.prefab"; // Metadata: 0x01FD339F
		public const string LOGIN_SK_ACTOR_F = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_female.prefab"; // Metadata: 0x01FD33DD
		public const string LOGIN_SK_ACTOR_NO_GENDER = "Assets/Beyond/InitialAssets/Intro/Prefab/SK_actor_no_gender.prefab"; // Metadata: 0x01FD341D
		public const string LOGIN_MOCK_UID_PANEL = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginMockUIDPanel.prefab"; // Metadata: 0x01FD3461
		public const string LOGIN_CONTROLLER_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginController.prefab"; // Metadata: 0x01FD34A5
		public const string LOGIN_ROOT_PANEL_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginRootPanel.prefab"; // Metadata: 0x01FD34E7
		public const string LOGIN_ALERT_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginAlertDialog.prefab"; // Metadata: 0x01FD3527
		public const string LOGIN_JUDGE_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginJudgeDialog.prefab"; // Metadata: 0x01FD356A
		public const string LOGIN_VOC_RES_SELECT_DIALOG_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/LoginVocResSelDialog.prefab"; // Metadata: 0x01FD35AD
	}

	public class LoginController : MonoBehaviour, ILoginBinder<LoginViewModel> // TypeDefIndex: 53046
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
	
		// Properties
		public MaskCtrl maskCtrl { get => default; } // 0x0000000182EA9AB0-0x0000000182EA9B50 
		public LoginRootPanel rootPanel { get => default; } // 0x0000000183D4EB10-0x0000000183D4EB20 
	
		// Events
		private event Action<string> m_onMockLogin;
	
		// Nested types
		public struct FOptions // TypeDefIndex: 53031
		{
			// Fields
			public LoginContext context; // 0x00
		}
	
		public abstract class Dialog : MonoBehaviour // TypeDefIndex: 53034
		{
			// Fields
			private UISwitchTween m_switchTween; // 0x18
			private LoginController m_controller; // 0x20
			[AudioString]
			public string showAudioEvent; // 0x28
			[AudioString]
			public string closeAudioEvent; // 0x30
	
			// Constructors
			protected Dialog() {} // 0x000000018426FE60-0x000000018426FE68
	
			// Methods
			[IteratorStateMachine(typeof(__CloseCoroutine_d__4))]
			private IEnumerator _CloseCoroutine(Action callback) => default; // 0x000000018576C5CC-0x000000018576C674
			public bool TryCloseWithCallback(Action callback) => default; // 0x000000018576C488-0x000000018576C5CC
			public void Show() {} // 0x000000018576C39C-0x000000018576C488
			protected virtual void OnInit() {} // 0x000000018576C358-0x000000018576C39C
			[IteratorStateMachine(typeof(_Create_d__8<TDialog>))]
			public static IEnumerator Create<TDialog>(string resPath, LoginController controller, Beyond.Misc.ObjectRef outRef)
				where TDialog : Dialog => default;
		}
	
		public static class MaskConsts // TypeDefIndex: 53035
		{
			// Fields
			public const float DELAY_WAIT_NODE = 0.2f; // Metadata: 0x01FD35F4
			public const string INIT = "init"; // Metadata: 0x01FD35F8
			public const string U8_LOGIN = "u8_login"; // Metadata: 0x01FD35FD
			public const string FROM_GS_LOGIN = "from_gs_login"; // Metadata: 0x01FD3606
			public const string FROM_CREATE_ROLE = "from_create_role"; // Metadata: 0x01FD3614
			public const string NET_AGE_TIPS = "age_tips"; // Metadata: 0x01FD3625
		}
	
		public enum EMaskType // TypeDefIndex: 53036
		{
			None = 0,
			Black = 1,
			Blur = 2,
			White = 3
		}
	
		[Serializable]
		private class MaskCfg // TypeDefIndex: 53037
		{
			// Fields
			public CanvasGroup target; // 0x10
			public float showDuration; // 0x18
			public float hideDuration; // 0x1C
	
			// Constructors
			public MaskCfg() {} // 0x0000000183D55780-0x0000000183D55790
	
			// Methods
			public UISwitchTween CreateTweenAndHide() => default; // 0x00000001836531D0-0x0000000183653270
		}
	
		public class MaskCtrl : IDisposable // TypeDefIndex: 53040
		{
			// Fields
			private static readonly int[] CROSS_SCENE_MASKS; // 0x00
			private ListDict<int, HashSet<string>> m_maskRefs; // 0x10
			private ListDict<int, UISwitchTween> m_maskTweens; // 0x18
			private ListDict<string, NetMaskRef> m_netMasks; // 0x20
	
			// Nested types
			private class NetMaskRef // TypeDefIndex: 53038
			{
				// Fields
				public int maskId; // 0x18
				public bool isEnabled; // 0x1C
	
				// Properties
				public string key { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
				// Constructors
				public NetMaskRef() {} // Dummy constructor
				public NetMaskRef(string key) {} // 0x000000018426FEE0-0x000000018426FEF0
			}
	
			// Constructors
			public MaskCtrl() {} // Dummy constructor
			public MaskCtrl(LoginController controller) {} // 0x0000000183652FD0-0x00000001836531D0
			static MaskCtrl() {} // 0x0000000183CB7120-0x0000000183CB71B0
	
			// Methods
			public void Dispose() {} // 0x0000000182C3D490-0x0000000182C3DF40
			public void EnableMask(string key, EMaskType type, bool enable, bool reset = false /* Metadata: 0x01FD3632 */) {} // 0x0000000182C3C4E0-0x0000000182C3C6C0
			public bool IsMaskTweening(EMaskType type) => default; // 0x0000000182C3C490-0x0000000182C3C4E0
			public bool IsCrossSceneMaskTweening() => default; // 0x0000000182EAA010-0x0000000182EAA0E0
			[IteratorStateMachine(typeof(_WaitForCrossSceneMasks_d__10))]
			public IEnumerator WaitForCrossSceneMasks() => default; // 0x000000018576EAD8-0x000000018576EB68
			public void EnableNetMask(string key, float timeoutSecs) {} // 0x000000018576E918-0x000000018576EAD8
			public void DisableNetMask(string key) {} // 0x000000018576E82C-0x000000018576E918
			private UISwitchTween _GetMaskByType(int type) => default; // 0x0000000182C3C6C0-0x0000000182C3C750
		}
	
		// Constructors
		public LoginController() {} // 0x00000001839BB5F0-0x00000001839BB720
	
		// Methods
		protected void Awake() {} // 0x0000000183CF9140-0x0000000183CF91B0
		protected void Start() {} // 0x0000000183D2A520-0x0000000183D2A570
		public float GetEnterGamePanelPredelay() => default; // 0x0000000182EA9B50-0x0000000182EA9B80
		public void OnValueChanged(LoginViewModel viewModel) {} // 0x0000000182C3B440-0x0000000182C3B4C0
		public void InitUI(FOptions options) {} // 0x0000000182EA8DE0-0x0000000182EA8F90
		public void InvokeWhenStart(Action callback) {} // 0x00000001828D52F0-0x00000001828D5340
		[IteratorStateMachine(typeof(_BeforeDestroy_d__35))]
		public IEnumerator BeforeDestroy() => default; // 0x0000000183A24780-0x0000000183A247F0
		[IteratorStateMachine(typeof(__InstantiateUIFromRes_d__36<T>))]
		private IEnumerator _InstantiateUIFromRes<T>(string resPath, Transform parent, Beyond.Misc.ObjectRef objRef)
			where T : Component => default;
		private void _InitImpl() {} // 0x0000000183C86380-0x0000000183C863D0
		[IteratorStateMachine(typeof(__InitCoroutine_d__38))]
		private IEnumerator _InitCoroutine() => default; // 0x0000000183C863D0-0x0000000183C86440
		private void _InitVersionBtn() {} // 0x0000000182EA9E00-0x0000000182EA9EA0
		public void MockLoginWithCallback(string fixedUID, Action<string> callback) {} // 0x0000000182EAA8A0-0x0000000182EAA9A0
		[IteratorStateMachine(typeof(__MockLoginCoroutine_d__45))]
		private IEnumerator _MockLoginCoroutine(string fixedUID) => default; // 0x0000000182EAA9A0-0x0000000182EAAA30
	}

	public class LoginContext : IDisposable // TypeDefIndex: 53048
	{
		// Fields
		private LoginController m_controller; // 0x10
		private bool m_isDisposed; // 0x18
	
		// Properties
		public bool quickStart { get; private set; } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public bool firstLogin { get; set; } // 0x0000000183D4EFA0-0x0000000183D4EFB0 0x0000000183D4EFD0-0x0000000183D4EFE0
		public LoginWorkFlow workflow { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public LoginViewProperty viewProp { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public LoginManager.AssetLoader loader { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public LoginManager.FlowWithMaskMgr flowWithMask { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public NetUsagePolicy netUsagePolicy { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public LoginGameUpdater gameUpdater { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public bool startConnectServer { get; set; } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
	
		// Constructors
		public LoginContext() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public LoginController ViewOnlyController() => default; // 0x0000000182EA9A10-0x0000000182EA9A40
		public void Init(bool quickStart, LoginController controller, LoginWorkFlow workflow, LoginViewProperty viewProp, LoginManager.AssetLoader loader, LoginManager.FlowWithMaskMgr flowWithMask, NetUsagePolicy netUsagePolicy, LoginGameUpdater gameUpdater) {} // 0x00000001828D4BE0-0x00000001828D4CC0
		public void StartCoroutine(IEnumerator routine) {} // 0x0000000182D77950-0x0000000182D779D0
		public void StopCoroutine(IEnumerator routine) {} // 0x000000018576D880-0x000000018576D8FC
		public void SendEvent(ELoginEvent evt, object param = null) {} // 0x000000018576D72C-0x000000018576D7AC
		public void Dispose() {} // 0x0000000182EAAB50-0x0000000182EAAC70
		public void ShutDown() {} // 0x000000018576D7AC-0x000000018576D880
		public bool IsWorkflowDisposed() => default; // 0x000000018576D6D8-0x000000018576D72C
		public bool IsDisposed() => default; // 0x000000018576D68C-0x000000018576D6D8
		private void _DisposeImpl() {} // 0x00000001828D4CC0-0x00000001828D4D20
		[IteratorStateMachine(typeof(__DisposeCoroutine_d__48))]
		private static IEnumerator _DisposeCoroutine(LoginController legacyController, Action disposeAction) => default; // 0x0000000182EAAC70-0x0000000182EAAD00
	}

	public enum ELoginEvent // TypeDefIndex: 53049
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

	public static class LoginTextDefines // TypeDefIndex: 53050
	{
		// Fields
		public const string CS_LOGIN_CONN_FAIL = "CS_LOGIN_CONN_FAIL"; // Metadata: 0x01FD3641
		public const string HOTUPDATE_INDEX_FAILED = "HOTUPDATE_INDEX_FAILED"; // Metadata: 0x01FD3654
		public const string HOTUPDATE_IO_FAILED = "HOTUPDATE_IO_FAILED"; // Metadata: 0x01FD366B
		public const string HOTUPDATE_CHECK_VERSION = "HOTUPDATE_CHECK_VERSION"; // Metadata: 0x01FD367F
		public const string HOTUPDATE_DOWNLOADING = "HOTUPDATE_DOWNLOADING"; // Metadata: 0x01FD3697
		public const string HOTUPDATE_DECOMPRESSING = "HOTUPDATE_DECOMPRESSING"; // Metadata: 0x01FD36AD
		public const string HOTUPDATE_DOWNLOAD_ERROR = "HOTUPDATE_DOWNLOAD_ERROR"; // Metadata: 0x01FD36C5
		public const string HOTUPDATE_DOWNLOAD_DISKFULL = "HOTUPDATE_DOWNLOAD_DISKFULL"; // Metadata: 0x01FD36DE
		public const string HOTUPDATE_LOCAL_RES_CHECK = "HOTUPDATE_LOCAL_RES_CHECK"; // Metadata: 0x01FD36FA
		public const string HOTUPDATE_PRELOAD_RES = "HOTUPDATE_PRELOAD_RES"; // Metadata: 0x01FD3714
		public const string HOTUPDATE_INVALID_LOCAL_FILES = "HOTUPDATE_INVALID_LOCAL_FILES"; // Metadata: 0x01FD372A
		public const string HOTUPDATE_INIT_RES_CHANGED = "HOTUPDATE_INIT_RES_CHANGED"; // Metadata: 0x01FD3748
		public const string HOTUPDATE_DOWNLOAD_IO_ERROR = "HOTUPDATE_DOWNLOAD_IO_ERROR"; // Metadata: 0x01FD3763
		public const string HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR = "HOTUPDATE_DOWNLOAD_DATA_CHECK_ERROR"; // Metadata: 0x01FD377F
		public const string HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR = "HOTUPDATE_DOWNLOAD_START_DOWNLOAD_ERROR"; // Metadata: 0x01FD37A3
		public const string HOTUPDATE_DECOMPRESS_ERROR = "HOTUPDATE_DECOMPRESS_ERROR"; // Metadata: 0x01FD37CB
		public const string REMOTE_CFG_GAME_CFG_ERROR = "REMOTE_CFG_GAME_CFG_ERROR"; // Metadata: 0x01FD37E6
		public const string REMOTE_CFG_GAME_CFG_TIMEOUT = "REMOTE_CFG_GAME_CFG_TIMEOUT"; // Metadata: 0x01FD3800
		public const string REMOTE_CFG_NETWORK_CFG_ERROR = "REMOTE_CFG_NETWORK_CFG_ERROR"; // Metadata: 0x01FD381C
		public const string REMOTE_CFG_NETWORK_CFG_TIMEOUT = "REMOTE_CFG_NETWORK_CFG_TIMEOUT"; // Metadata: 0x01FD3839
		public const string REMOTE_CFG_RES_VERSION_ERROR = "REMOTE_CFG_RES_VERSION_ERROR"; // Metadata: 0x01FD3858
		public const string REMOTE_CFG_RES_VERSION_TIMEOUT = "REMOTE_CFG_RES_VERSION_TIMEOUT"; // Metadata: 0x01FD3875
		public const string REMOTE_CFG_GAME_VERSION_ERROR = "REMOTE_CFG_GAME_VERSION_ERROR"; // Metadata: 0x01FD3894
		public const string REMOTE_CFG_GAME_VERSION_TIMEOUT = "REMOTE_CFG_GAME_VERSION_TIMEOUT"; // Metadata: 0x01FD38B2
		public const string LOGIN_JUDGE_EXIT_GAME = "LOGIN_JUDGE_EXIT_GAME"; // Metadata: 0x01FD38D2
		public const string LOGIN_JUDGE_LOGOUT = "LOGIN_JUDGE_LOGOUT"; // Metadata: 0x01FD38E8
		public const string LOGIN_JUDGE_RES_REPAIR = "LOGIN_JUDGE_RES_REPAIR"; // Metadata: 0x01FD38FB
		public const string LOGIN_AGE_TIPS_FAILED = "LOGIN_AGE_TIPS_FAILED"; // Metadata: 0x01FD3912
		public const string LOGIN_TXT_DIALOG_CONFIRM = "LOGIN_TXT_DIALOG_CONFIRM"; // Metadata: 0x01FD3928
		public const string LOGIN_TXT_DIALOG_CANCEL = "LOGIN_TXT_DIALOG_CANCEL"; // Metadata: 0x01FD3941
		public const string LOGIN_AUDIO_LANG_CN = "UI_LOGIN_ROOT_VOICE_CN"; // Metadata: 0x01FD3959
		public const string LOGIN_AUDIO_LANG_JP = "UI_LOGIN_ROOT_VOICE_JP"; // Metadata: 0x01FD3970
		public const string LOGIN_AUDIO_LANG_EN = "UI_LOGIN_ROOT_VOICE_EN"; // Metadata: 0x01FD3987
		public const string LOGIN_AUDIO_LANG_KR = "UI_LOGIN_ROOT_VOICE_KR"; // Metadata: 0x01FD399E
		public const string LOGIN_TXT_NETWORK_ERROR = "LOGIN_TXT_NETWORK_ERROR"; // Metadata: 0x01FD39B5
		public const string LOGIN_GAME_UPGRADED = "LOGIN_GAME_UPGRADED"; // Metadata: 0x01FD39CD
		public const string LOGIN_TXT_SERVER_CLOSED = "LOGIN_TXT_SERVER_CLOSED"; // Metadata: 0x01FD39E1
		public const string LOGIN_TXT_SERVER_CLOSED_DATETIME = "LOGIN_TXT_SERVER_CLOSED_DATETIME"; // Metadata: 0x01FD39F9
		public const string LOGIN_TXT_USR_BAN_DATETIME = "LOGIN_TXT_USR_BAN_DATETIME"; // Metadata: 0x01FD3A1A
		public const string LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER = "LOGIN_TXT_HOTUPDATE_CLEAR_DOWNLOAD_FOLDER"; // Metadata: 0x01FD3A35
		public const string LOGIN_GET_SERVER_LIST_FAILED = "LOGIN_GET_SERVER_LIST_FAILED"; // Metadata: 0x01FD3A5F
		public const string LOGIN_TEXT_SERVER_ZONE_FAILED = "LOGIN_TEXT_SERVER_ZONE_FAILED"; // Metadata: 0x01FD3A7C
		public const string LOGIN_TEXT_GET_APP_VERSION_FAILED = "LOGIN_TEXT_GET_APP_VERSION_FAILED"; // Metadata: 0x01FD3A9A
		public const string LOGIN_TEXT_ALERT_CARRIER_NETWORK = "LOGIN_TEXT_ALERT_CARRIER_NETWORK"; // Metadata: 0x01FD3ABC
		public const string LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED = "LOGIN_TEXT_ERROR_DOWNLOAD_HOTUPDATE_RES_FAILED"; // Metadata: 0x01FD3ADD
		public const string LOGIN_SHADER_WARM_UP_PRELOAD_RES = "LOGIN_SHADER_WARM_UP_PRELOAD_RES"; // Metadata: 0x01FD3B0C
		public const string LOGIN_GAME_UPDATE_TIPS_DOWNLOADING = "LOGIN_GAME_UPDATE_TIPS_DOWNLOADING"; // Metadata: 0x01FD3B2D
		public const string LOGIN_GAME_UPDATE_TIPS_PAUSE = "LOGIN_GAME_UPDATE_TIPS_PAUSE"; // Metadata: 0x01FD3B50
		public const string LOGIN_GAME_UPDATE_ALERT_NEWER = "LOGIN_GAME_UPDATE_ALERT_NEWER"; // Metadata: 0x01FD3B6D
		public const string LOGIN_GAME_UPDATE_ERROR_DISK_FULL = "LOGIN_GAME_UPDATE_ERROR_DISK_FULL"; // Metadata: 0x01FD3B8B
		public const string LOGIN_GAME_UPDATE_ALERT_SUC = "LOGIN_GAME_UPDATE_ALERT_SUC"; // Metadata: 0x01FD3BAD
		public const string LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON = "LOGIN_GAME_UPDATE_ERROR_CHECK_FOR_UPDATE_COMMON"; // Metadata: 0x01FD3BC9
		public const string LOGIN_GAME_UPDATE_ERROR_COMMON = "LOGIN_GAME_UPDATE_ERROR_COMMON"; // Metadata: 0x01FD3BF9
		public const string LOGIN_GAME_UPDATE_TITLE = "LOGIN_GAME_UPDATE_TITLE"; // Metadata: 0x01FD3C18
		public const string LOGIN_GOTO_SHOP_FOR_GAME_UPDATE = "LOGIN_GOTO_SHOP_FOR_GAME_UPDATE"; // Metadata: 0x01FD3C30
		public const string LOGIN_SDK_INIT_FAILED = "LOGIN_SDK_INIT_FAILED"; // Metadata: 0x01FD3C50
		public const string LOGIN_DOWNLOADING_SPEED_HINT = "LOGIN_DOWNLOADING_SPEED_HINT"; // Metadata: 0x01FD3C66
		public const string LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME = "LOGIN_SDK_INIT_FAILED_NEED_QUIT_GAME"; // Metadata: 0x01FD3C83
		public const string LOGIN_NETWORK_CONGESTION_TITLE = "LOGIN_NETWORK_CONGESTION_TITLE"; // Metadata: 0x01FD3CA8
		public const string LOGIN_LOW_SCORE_DEVICE_TIP = "LOGIN_LOW_SCORE_DEVICE_TIP"; // Metadata: 0x01FD3CC7
		public const string LOGIN_REGISTRY_WRITE_FAILED = "LOGIN_REGISTRY_WRITE_FAILED"; // Metadata: 0x01FD3CE2
	}

	public class LoginManager : ExplicitSingleton<LoginManager> // TypeDefIndex: 53069
	{
		// Fields
		public const long MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI = 104857600; // Metadata: 0x01FD3CFE
		private ISceneHandle m_sceneHandle; // 0x10
		private LoginContext m_context; // 0x18
		private LatchUtils.InvokeWhenUnlock m_workflowFinishLatch; // 0x20
		private LatchUtils.InvokeWhenUnlock m_workflowStartLatch; // 0x28
		private Queue<WeakReference<LoginSceneComponent>> m_pendingSceneComps; // 0x30
		private HashSet<LoginSceneComponent> m_sceneComps; // 0x38
		private object m_dialogBlocker; // 0x48
	
		// Properties
		public bool quickStart { get; private set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		public bool firstLogin { get => default; } // 0x000000018576E81C-0x000000018576E82C 
	
		// Nested types
		public class AssetLoader : IDisposable // TypeDefIndex: 53051
		{
			// Fields
			private Dictionary<string, FAssetProxyHandle> m_assetHandles; // 0x10
	
			// Constructors
			public AssetLoader() {} // 0x00000001828D5190-0x00000001828D5210
	
			// Methods
			public FAssetProxyHandle CachedLoad<T>(string path)
				where T : UnityEngine.Object => default;
			public FAssetProxyHandle CachedLoadAsync<T>(string path)
				where T : UnityEngine.Object => default;
			private bool _CheckDisposedBeforeLoad(string path) => default; // 0x0000000182AD71E0-0x0000000182AD7250
			public void Dispose() {} // 0x00000001828D3CF0-0x00000001828D4090
		}
	
		public class FlowWithMaskMgr // TypeDefIndex: 53053
		{
			// Fields
			private LoginContext m_context; // 0x10
			private HashSet<string> m_activeFlows; // 0x18
	
			// Constructors
			public FlowWithMaskMgr() {} // Dummy constructor
			public FlowWithMaskMgr(LoginContext context) {} // 0x00000001828D4DC0-0x00000001828D4E50
	
			// Methods
			public void StartFlow(FFlowWithMask flow) {} // 0x0000000182D773E0-0x0000000182D77520
			[IteratorStateMachine(typeof(__FlowCoroutine_d__4))]
			private IEnumerator _FlowCoroutine(FFlowWithMask flow) => default; // 0x0000000182D77520-0x0000000182D775D0
			private void _OnFlowFinished(FFlowWithMask flow) {} // 0x000000018576C674-0x000000018576C72C
		}
	
		public struct FFlowWithMask // TypeDefIndex: 53054
		{
			// Fields
			public string key; // 0x00
			public LoginController.EMaskType maskType; // 0x08
			public Func<bool> flowAction; // 0x10
			public FFlowCondition condition; // 0x18
			public float disableDelay; // 0x20
		}
	
		public struct FFlowCondition // TypeDefIndex: 53055
		{
			// Properties
			public LoginWorkFlow.ENode priTarget { [IsReadOnly] get; private set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
			public LoginWorkFlow.ENode secTarget { [IsReadOnly] get; private set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
	
			// Constructors
			public FFlowCondition(LoginWorkFlow.ENode target) : this() {} // 0x0000000183D55720-0x0000000183D55730
			public FFlowCondition(LoginWorkFlow.ENode first, LoginWorkFlow.ENode second) : this() {} // 0x0000000183D4E4B0-0x0000000183D4E4C0
	
			// Methods
			public bool IsTargetMatch(LoginWorkFlow.ENode node) => default; // 0x0000000182C3DF80-0x0000000182C3DFE0
		}
	
		// Constructors
		public LoginManager() {} // 0x0000000183A93590-0x0000000183A936D0
	
		// Methods
		[IteratorStateMachine(typeof(_InitCoroutine_d__17))]
		public IEnumerator InitCoroutine(bool quickStart) => default; // 0x0000000183CC4260-0x0000000183CC42E0
		public bool IsReLoginInProgress() => default; // 0x000000018576DF5C-0x000000018576E074
		public static void OnReleaseMainGame() {} // 0x0000000184275714-0x00000001842757A0
		public bool IsWorkflowInProgress() => default; // 0x0000000183D42930-0x0000000183D42960
		public void ClearSync() {} // 0x000000018576DC74-0x000000018576DCD4
		public void Clear() {} // 0x0000000182EA8790-0x0000000182EA87D0
		private void _ReleaseLoginScene() {} // 0x0000000182EA8340-0x0000000182EA8420
		public void InvokeWhenWorkFlowFinished(Action callback) {} // 0x0000000183B466E0-0x0000000183B46730
		public void SceneComponentOnly_Bind(LoginSceneComponent comp) {} // 0x0000000182C3CFE0-0x0000000182C3D110
		private void _BindPendingComponents() {} // 0x0000000182EA9860-0x0000000182EA9A10
		public void ToggleLoginBindingGroup(bool enable) {} // 0x000000018576E360-0x000000018576E424
		public void AlertDialog(string desc, Action callback = null) {} // 0x000000018576DA8C-0x000000018576DC74
		public void VocResSelDialog(Action callback = null) {} // 0x000000018576E4B4-0x000000018576E654
		[IteratorStateMachine(typeof(_VocResSelDialogWithConfirm_d__31))]
		public IEnumerator VocResSelDialogWithConfirm() => default; // 0x000000018576E424-0x000000018576E4B4
		[IteratorStateMachine(typeof(_AlertDialogWithResult_d__32))]
		public IEnumerator AlertDialogWithResult(string desc, Beyond.Misc.ObjectRef outRef, Action<Beyond.Misc.ObjectRef> callback = null) => default; // 0x000000018576D9A4-0x000000018576DA8C
		[IteratorStateMachine(typeof(_AlertDialogWithConfirm_d__33))]
		public IEnumerator AlertDialogWithConfirm(string desc) => default; // 0x000000018576D8FC-0x000000018576D9A4
		[IDTag(0)]
		public void JudgeDialog(string desc, Action onPositive, Action onNegative) {} // 0x000000018576E110-0x000000018576E200
		[IDTag(1)]
		public void JudgeDialog(LoginJudgeDialog.FParams param) {} // 0x000000018576E074-0x000000018576E110
		private void _StartShowJudgeDialogCoroutine(LoginJudgeDialog.FParams param) {} // 0x000000018576E654-0x000000018576E81C
		[IteratorStateMachine(typeof(__ShowDialogCoroutine_d__37<TDialog, TParam>))]
		private IEnumerator _ShowDialogCoroutine<TDialog, TParam>(string resPath, TParam param, Action<TDialog, TParam> setParamFunc)
			where TDialog : LoginController.Dialog => default;
		public void MockLoginWithCallback(Action<string> callback) {} // 0x0000000182EA9500-0x0000000182EA95C0
		public void MockManualSelectServer(string uid, Action callback) {} // 0x000000018576E200-0x000000018576E360
		private void _Init() {} // 0x00000001828D5370-0x00000001828D5950
		public bool IsLoginSceneLoading() => default; // 0x0000000182C3CED0-0x0000000182C3CF50
		private void _PrepareBeforeLoginProcess() {} // 0x00000001828D4E50-0x00000001828D4ED0
		[IteratorStateMachine(typeof(__LoginWorkFlowCoroutine_d__43))]
		private IEnumerator _LoginWorkFlowCoroutine(LoginController nullableCtrl) => default; // 0x0000000183C7DAA0-0x0000000183C7DB30
		private void _ClearWorkflowAndContext(bool isShutDownMode) {} // 0x0000000182EA8D10-0x0000000182EA8DE0
		[IteratorStateMachine(typeof(_FetchRemoteConfigUtilSuc_d__45))]
		public static IEnumerator FetchRemoteConfigUtilSuc(IRemoteConfig config, string configEnv, string keyErrorWithCode, string keyTimeout) => default; // 0x000000018315A7B0-0x000000018315A870
		private static string _ExtractErrorInfo(HttpSender.Result result, string keyErrorWithCode, string keyTimeout) => default; // 0x0000000182C36F20-0x0000000182C36FB0
		[Conditional("DEVELOPMENT_BUILD")]
		public static void DevOnlyCheckEnableLocalResMode(ref bool enable) {} // 0x000000018576DCD4-0x000000018576DD54
		[Conditional("DEVELOPMENT_BUILD")]
		public static void DevOnlyUseLocalResVersion(ResVersionDevCfg config, ref bool useLocalResVersion) {} // 0x000000018576DD54-0x000000018576DF5C
	}

	public class VietnamLoginAgePanel : MonoBehaviour // TypeDefIndex: 53070
	{
		// Fields
		private const string PREFAB_PATH = "Assets/Beyond/InitialAssets/Prefabs/Login/AgeTipsPanel.prefab"; // Metadata: 0x01FD3D06
		private static FAssetProxyHandle s_prefabAssetHandle; // 0x00
		public static GameObject instance; // 0x18
	
		// Constructors
		public VietnamLoginAgePanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static void Init() {} // 0x0000000182EA8AA0-0x0000000182EA8B00
		public static void UnInit() {} // 0x00000001857718A8-0x0000000185771920
		private static void _Init() {} // 0x0000000185771920-0x0000000185771BA8
		private static void _UnInit() {} // 0x0000000185771BA8-0x0000000185771C7C
		private void OnApplicationQuit() {} // 0x00000001857717BC-0x00000001857718A8
	}

	public class VietnamLoginAgeTipsPanelCtrl : MonoBehaviour // TypeDefIndex: 53071
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
		public VietnamLoginAgeTipsPanelCtrl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Awake() {} // 0x0000000185771C7C-0x0000000185771EB8
		private void _SetStateTips(PointerEventData eventData) {} // 0x0000000185771F54-0x000000018577288C
		private void _SetStateCircle(PointerEventData eventData) {} // 0x0000000185771EB8-0x0000000185771F54
	}

	public static class RenderPipelineDataLoader // TypeDefIndex: 53072
	{
		// Fields
		public static FAssetProxyHandle s_globalSettings; // 0x00
		public static FAssetProxyHandle s_pipelineAsset; // 0x14
	
		// Methods
		public static void LoadSimpleRpData() {} // 0x0000000182EAA430-0x0000000182EAA550
		public static void PreloadFullRpResources() {} // 0x00000001831578A0-0x0000000183157A50
		public static bool IsPreLoadFinished() => default; // 0x0000000182C38320-0x0000000182C383E0
		public static void LoadFullRpResources() {} // 0x0000000182EAA600-0x0000000182EAA770
	}

	[DefaultExecutionOrder(22000)]
	public class TailGameLoop : MonoBehaviour // TypeDefIndex: 53073
	{
		// Constructors
		public TailGameLoop() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Update() {} // 0x0000000182F88BB0-0x0000000182F88C60
		private void LateUpdate() {} // 0x0000000182E69680-0x0000000182E69730
	}
}

namespace Beyond.Login
{
	public class LoginCheckForUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 53115
	{
		// Fields
		private LoginGameUpdater m_sdk; // 0x20
		private bool m_checkSuccess; // 0x28
		private const string REQUEST_API = "/api/game/get_latest"; // Metadata: 0x01FD3E8D
		private const string REQUEST_PARAM_FORMAT = "appcode={0}&channel={1}&version={2}&platform={3}&sub_channel={4}&source={5}"; // Metadata: 0x01FD3EA2
		private const string REQUEST_URL_FORMAT = "{0}{1}?{2}"; // Metadata: 0x01FD3EEF
		private const string PRAM_SOURCE = "game"; // Metadata: 0x01FD3EFA
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Nested types
		private class AppVersionRespone // TypeDefIndex: 53108
		{
			// Fields
			public int action; // 0x10
			public int state; // 0x14
	
			// Constructors
			public AppVersionRespone() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public LoginCheckForUpdateNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x00000001836BC910-0x00000001836BCA10
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutine_d__4))]
		private IEnumerator _CheckForUpdateCoroutine() => default; // 0x00000001836BCA10-0x00000001836BCA80
		[IteratorStateMachine(typeof(_AlertNoMatchDeviceBeforeLogin_d__5))]
		public static IEnumerator AlertNoMatchDeviceBeforeLogin() => default; // 0x0000000183D02BC0-0x0000000183D02C20
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutineMobile_d__6))]
		private IEnumerator _CheckForUpdateCoroutineMobile() => default; // 0x0000000185773218-0x00000001857732A8
		[IteratorStateMachine(typeof(__CheckForUpdateCoroutinePC_d__8))]
		private IEnumerator _CheckForUpdateCoroutinePC() => default; // 0x0000000183CEFE20-0x0000000183CEFE90
		[IteratorStateMachine(typeof(__CheckForUpdatePC_d__9))]
		private IEnumerator _CheckForUpdatePC() => default; // 0x0000000183B29910-0x0000000183B29980
		[IteratorStateMachine(typeof(__GetOnlineAppVersion_d__11))]
		private IEnumerator _GetOnlineAppVersion(Beyond.Misc.ObjectRef outRef) => default; // 0x0000000183922450-0x00000001839224E0
		private string _GetRequestPram() => default; // 0x000000018229CC40-0x000000018229CE50
	}

	public class LoginCreateRoleNode : LoginWorkFlow.Node // TypeDefIndex: 53117
	{
		// Fields
		public const string LUA_SYS_NAME = "LeadingCharacter"; // Metadata: 0x01FD3EFF
		private WorkProcess m_activeProcess; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D557A0-0x0000000183D557B0 
	
		// Nested types
		private class WorkProcess : CustomYieldInstruction, IDisposable // TypeDefIndex: 53116
		{
			// Fields
			private LoginCreateRoleNode m_closure; // 0x10
			private bool m_isFinished; // 0x18
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x0000000183D032E0-0x0000000183D032F0 
	
			// Constructors
			public WorkProcess() {} // Dummy constructor
			public WorkProcess(LoginCreateRoleNode closure) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public void Dispose() {} // 0x000000018577BEA8-0x000000018577BF1C
		}
	
		// Constructors
		public LoginCreateRoleNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void OnDispose() {} // 0x000000018379F750-0x000000018379F7A0
		public override bool CanCancel() => default; // 0x00000001857732A8-0x00000001857732F4
		public override CustomYieldInstruction Work() => default; // 0x0000000183C9BCF0-0x0000000183C9BD90
		public void __iFixBaseProxy_OnDispose() {} // 0x00000001857732FC-0x0000000185773304
		public bool __iFixBaseProxy_CanCancel() => default; // 0x00000001857732F4-0x00000001857732FC
	}

	public class LoginDownloadTask : IDisposable // TypeDefIndex: 53120
	{
		// Fields
		private bool m_isDownloadFinished; // 0x10
		private HGDownloader.TaskHandler m_downloadTask; // 0x18
		private FResourceDiff m_resDiff; // 0x20
		private LocalResPref m_localResPref; // 0x60
		private string m_patchInfo; // 0x68
		private IEnumerator m_mockCoroutine; // 0x70
		private bool m_isInitial; // 0x78
		private NetUsagePolicy m_netUsagePolicy; // 0x88
	
		// Properties
		public string vitalError { get; private set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
	
		// Constructors
		public LoginDownloadTask() {} // Dummy constructor
		public LoginDownloadTask(FResourceDiff resDiff, LocalResPref localResPref, string patchInfo, bool isInitial, NetUsagePolicy netUsagePolicy) {} // 0x00000001810393E0-0x0000000181039570
	
		// Methods
		public HGDownloader.DownloadProgress GetDownloadProgress() => default; // 0x00000001857733F4-0x000000018577348C
		public float GetDecompressProgress() => default; // 0x0000000185773390-0x00000001857733F4
		public HGDownloader.WorkState GetWorkState() => default; // 0x000000018577348C-0x00000001857734EC
		public bool Tick() => default; // 0x00000001857734EC-0x0000000185773558
		public void Dispose() {} // 0x0000000185773304-0x0000000185773390
		private void _StartDownload() {} // 0x00000001857740DC-0x00000001857743DC
		private void _StartDownloadImpl() {} // 0x0000000185773C68-0x00000001857740DC
		private List<HGFolder> _GetAllFileList(LocalResPref localResPref) => default; // 0x0000000181037210-0x00000001810393E0
		private List<HGFileInfo> _GetFileList(string rootUrl) => default; // 0x0000000185773558-0x0000000185773798
		private void _OnDownloadFinish() {} // 0x00000001857739B4-0x0000000185773A04
		private bool _OnDownloadError(HGRetCodeType codeType, int errorCode) => default; // 0x0000000185773798-0x00000001857739B4
		private void _OnDownloadPaused(HGDownloader.PauseReason reason) {} // 0x0000000185773A04-0x0000000185773C68
	}

	public class LoginGameSettingInitializer : MonoBehaviour // TypeDefIndex: 53121
	{
		// Fields
		private static bool s_isInitialized; // 0x00
		private RectTransform m_rectTransform; // 0x18
		private UICanvasScaleHelper m_canvasScaleHelper; // 0x20
	
		// Constructors
		public LoginGameSettingInitializer() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x000000018398C690-0x000000018398C6F0
		private void OnEnable() {} // 0x000000018398C6F0-0x000000018398C770
		private void _TryInitializeComponents() {} // 0x000000018398C7F0-0x000000018398C8E0
		private void _InitGameSettingStateInLogin() {} // 0x000000018398C770-0x000000018398C7F0
		private void _InitGameSettingNotchPadding() {} // 0x0000000182E3B510-0x0000000182E3B6D0
	}

	public class LoginGameUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 53124
	{
		// Fields
		private LoginGameUpdater m_sdk; // 0x20
		private NetUsagePolicy m_netUsagePolicy; // 0x28
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		public LoginGameUpdateNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x00000001836BCA80-0x00000001836BCB90
		[IteratorStateMachine(typeof(__GameUpdateCoroutine_d__5))]
		private IEnumerator _GameUpdateCoroutine() => default; // 0x00000001836BCB90-0x00000001836BCBF0
		[IteratorStateMachine(typeof(__GameUpdateCoroutineMobileImpl_d__6))]
		private IEnumerator _GameUpdateCoroutineMobileImpl() => default; // 0x0000000185774B44-0x0000000185774BD4
	}

	public class LoginGameUpdater // TypeDefIndex: 53146
	{
		// Fields
		private const float COOLDOWN_INSTALL = 1f; // Metadata: 0x01FD3F10
		private const int ERROR_CODE_NETWORK = 1103; // Metadata: 0x01FD3F14
		private const int ERROR_INIT_FAILED = -11101; // Metadata: 0x01FD3F16
		private const int ERROR_DESERIALIZE_FAILED = -10001; // Metadata: 0x01FD3F1A
		public const int ERROR_ACTION = -20000; // Metadata: 0x01FD3F1E
		private const int WAIT_TIME_SECONDS_MIN = 5; // Metadata: 0x01FD3F22
		private const int WAIT_TIME_SECONDS_MAX = 9; // Metadata: 0x01FD3F23
		private Options m_options; // 0x10
		private IGameUpdateInterface m_sdkImpl; // 0x28
		private bool m_hasUpdateAlerted; // 0x30
		private Context m_context; // 0x38
		private LoginProgress m_progress; // 0x40
		private LoginHotUpdateProp m_hotUpdateProp; // 0x48
	
		// Nested types
		public enum CodeType // TypeDefIndex: 53125
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
	
		public enum UpdateType // TypeDefIndex: 53126
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
	
		public enum UpdateCode // TypeDefIndex: 53127
		{
			Success = 0
		}
	
		public enum UpdateAction // TypeDefIndex: 53128
		{
			Invalid = -1,
			Latest = 0,
			ForcedUpdate = 1,
			OptionalUpdate = 2,
			Error = 3,
			Congestion = 200
		}
	
		public class HGLatestGameInfo // TypeDefIndex: 53129
		{
			// Fields
			public int code; // 0x10
			public string version; // 0x18
			public int action; // 0x20
			public int updateType; // 0x24
			public string updateInfo; // 0x28
			public int state; // 0x30
	
			// Constructors
			public HGLatestGameInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class NotificationTitleConfig // TypeDefIndex: 53130
		{
			// Fields
			public string downloading; // 0x10
			public string pause; // 0x18
	
			// Constructors
			public NotificationTitleConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class HGUpdateConfig // TypeDefIndex: 53131
		{
			// Fields
			public string downloadPath; // 0x10
	
			// Constructors
			public HGUpdateConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public struct Options // TypeDefIndex: 53132
		{
			// Fields
			public NetUsagePolicy netUsagePolicy; // 0x00
			public Action<string, Action> alertDialog; // 0x08
			public LoginContext loginContext; // 0x10
		}
	
		public class Result // TypeDefIndex: 53133
		{
			// Fields
			public bool needRetry; // 0x10
			public string errorInfo; // 0x18
			public int code; // 0x20
			public bool auditing; // 0x24
	
			// Constructors
			public Result() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class Context // TypeDefIndex: 53134
		{
			// Fields
			public long taskId; // 0x10
			public string errorInfo; // 0x18
			public string logError; // 0x20
			public bool needClear; // 0x28
			public HGLatestGameInfo gameInfo; // 0x30
	
			// Properties
			public bool complete { get; private set; } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
			public int code { get; private set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183D4EDC0-0x0000000183D4EDD0
	
			// Constructors
			public Context() {} // 0x0000000185772B00-0x0000000185772B68
	
			// Methods
			public void CompleteWithCode(int pCode) {} // 0x0000000185772A48-0x0000000185772AA4
			public void UncompleteWithCode(int pCode) {} // 0x0000000185772AA4-0x0000000185772B00
		}
	
		// Constructors
		public LoginGameUpdater() {} // Dummy constructor
		public LoginGameUpdater(Options options) {} // 0x00000001828D4D20-0x00000001828D4DC0
	
		// Methods
		public void Clear() {} // 0x00000001836BD0C0-0x00000001836BD130
		[IteratorStateMachine(typeof(_CheckLastGameInfo_d__23))]
		public IEnumerator CheckLastGameInfo(Result result) => default; // 0x0000000185774BD4-0x0000000185774C7C
		[IteratorStateMachine(typeof(_DoUpdate_d__24))]
		public IEnumerator DoUpdate(Result result) => default; // 0x0000000185774C7C-0x0000000185774D24
		[IteratorStateMachine(typeof(__GetLastGameInfo_d__25))]
		private IEnumerator _GetLastGameInfo(Context context) => default; // 0x0000000185775120-0x00000001857751C8
		[IteratorStateMachine(typeof(__UpdateGame_d__26))]
		private IEnumerator _UpdateGame(Context context) => default; // 0x0000000185775410-0x00000001857754B8
		[IteratorStateMachine(typeof(__DoTaskUpdating_d__27))]
		private IEnumerator _DoTaskUpdating(Context context) => default; // 0x0000000185775078-0x0000000185775120
		private void _OnDownloadStart() {} // 0x00000001857752C8-0x0000000185775410
		private void _OnDownloadProgress(long curSize, long totalSize, long speed) {} // 0x00000001857751C8-0x00000001857752C8
		[IteratorStateMachine(typeof(__YieldErrorAlert_d__32))]
		private IEnumerator _YieldErrorAlert(string desc) => default; // 0x00000001857755F8-0x00000001857756A0
		[IteratorStateMachine(typeof(__YieldCheckNetUsagePolicy_d__33))]
		private IEnumerator _YieldCheckNetUsagePolicy(long downloadSize) => default; // 0x0000000185775558-0x00000001857755F8
		[IteratorStateMachine(typeof(__WaitForTaskCancel_d__34))]
		private IEnumerator _WaitForTaskCancel(long taskId) => default; // 0x00000001857754B8-0x0000000185775558
		private static void _CreateDirectoryIfNotExists(string folderPath) {} // 0x000000018577500C-0x0000000185775078
		public void ClearWaitProgress() {} // 0x00000001828D47D0-0x00000001828D48A0
		public void ShowWaitProgress() {} // 0x0000000185774EC8-0x000000018577500C
		public int GetNoAlertCode() => default; // 0x0000000185774D24-0x0000000185774D74
		public float GetWaitTime() => default; // 0x0000000185774D74-0x0000000185774EC8
	}

	public class LoginGSNode : LoginWorkFlow.Node // TypeDefIndex: 53156
	{
		// Fields
		private const int FLOW_NONE = 0; // Metadata: 0x01FD3F4C
		private const int FLOW_WORKING = 1; // Metadata: 0x01FD3F4D
		private const int FLOW_FINISH = 2; // Metadata: 0x01FD3F4E
		private const int FLOW_ABORTING = 3; // Metadata: 0x01FD3F4F
		private EnterGameServiceFlow m_flow; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D557B0-0x0000000183D557C0 
	
		// Nested types
		private class EnterGameServiceFlow : CustomYieldInstruction // TypeDefIndex: 53154
		{
			// Fields
			private LoginContext m_context; // 0x10
			private LoginGSNode m_curNode; // 0x18
			private Beyond.Misc.ObjectRef m_dialogBlocker; // 0x20
			private int m_state; // 0x28
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x000000018333FE90-0x000000018333FEA0 
	
			// Constructors
			public EnterGameServiceFlow() {} // Dummy constructor
			public EnterGameServiceFlow(LoginGSNode node) {} // 0x00000001839CF140-0x00000001839CF1C0
	
			// Methods
			public void MarkAborting() {} // 0x0000000185772BC8-0x0000000185772C20
			public void EnterGame() {} // 0x0000000182D77780-0x0000000182D778A0
			public bool IsInterruptable() => default; // 0x0000000185772B68-0x0000000185772BC8
			public bool TryInterrupt() => default; // 0x0000000185772C20-0x0000000185772C88
			[IteratorStateMachine(typeof(__EnterGameCoroutine_d__11))]
			private IEnumerator _EnterGameCoroutine() => default; // 0x0000000182D778A0-0x0000000182D77910
			[IteratorStateMachine(typeof(__NetConnectAndGSLogin_d__12))]
			private IEnumerator _NetConnectAndGSLogin(string uid, string token, Beyond.Misc.ObjectRef loginRespRef) => default; // 0x0000000182D77BD0-0x0000000182D77C90
			private static string _ExtractErrorInfo(HttpSender.Result result, string keyErrorWithCode, string keyTimeout) => default; // 0x0000000185772C88-0x0000000185772D84
			[IteratorStateMachine(typeof(__YieldAlertError_d__14))]
			private IEnumerator _YieldAlertError(string errorInfo) => default; // 0x0000000185772F2C-0x0000000185772FC8
			[IteratorStateMachine(typeof(__SaveCurrentUserToServerConfig_d__15))]
			private IEnumerator _SaveCurrentUserToServerConfig(string uid) => default; // 0x000000018229C660-0x000000018229C6F0
			[IteratorStateMachine(typeof(__MockManualSelectServer_d__16))]
			private IEnumerator _MockManualSelectServer(string uid) => default; // 0x0000000185772D84-0x0000000185772E20
			[IteratorStateMachine(typeof(__OnAuthError_d__17))]
			private IEnumerator _OnAuthError(object rejectInfo) => default; // 0x0000000185772E20-0x0000000185772EC8
			private void _ReLoginWhenErrorEncountered() {} // 0x0000000185772EC8-0x0000000185772F2C
			private static void _GlobalLoginSucBusiness(MSG_B1 msg) {} // 0x0000000182D759B0-0x0000000182D75A70
		}
	
		// Constructors
		public LoginGSNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x00000001839CEFB0-0x00000001839CF0F0
		public override bool OnEvent(ELoginEvent evt, object param) => default; // 0x0000000182D75850-0x0000000182D758F0
		[IteratorStateMachine(typeof(__ConfirmServer_d__10))]
		private static IEnumerator _ConfirmServer() => default; // 0x0000000182D78290-0x0000000182D782F0
		private void _FallbackToInitWithMask(bool bLogoutAccount) {} // 0x000000018577459C-0x0000000185774720
		private void _OnEventLogout() {} // 0x00000001857748BC-0x0000000185774A00
		private void _OnEventResourceRepair() {} // 0x0000000185774A00-0x0000000185774B44
		private bool _LogoutToInitNode() => default; // 0x0000000185774800-0x00000001857748BC
		private bool _FallbackToInitNodeImpl() => default; // 0x000000018577451C-0x000000018577459C
		private bool _FallbackToResRepairImpl() => default; // 0x0000000185774720-0x0000000185774800
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1) => default; // 0x00000001857743DC-0x00000001857743E4
	}

	public class LoginHotUpdateProp : LoginProperty<LoginHotUpdateModel> // TypeDefIndex: 53157
	{
		// Constructors
		public LoginHotUpdateProp() {} // Dummy constructor
		public LoginHotUpdateProp(LoginWorkFlow workflow) {} // 0x00000001828D48A0-0x00000001828D4940
	}

	public class LoginHotUpdateModel // TypeDefIndex: 53160
	{
		// Fields
		public string title; // 0x10
		public string desc; // 0x18
		public IProgress progress; // 0x20
	
		// Nested types
		public interface IProgress // TypeDefIndex: 53158
		{
			// Methods
			double GetTotal();
			double GetCurrent();
			string GetInfo();
		}
	
		public class SimpleProgress : Beyond.Login.LoginHotUpdateModel.IProgress // TypeDefIndex: 53159
		{
			// Fields
			public double current; // 0x10
	
			// Constructors
			public SimpleProgress() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public double GetCurrent() => default; // 0x00000001832F1360-0x00000001832F1390
			public double GetTotal() => default; // 0x00000001832F1530-0x00000001832F15C0
			public string GetInfo() => default; // 0x00000001832F15C0-0x00000001832F1670
		}
	
		// Constructors
		public LoginHotUpdateModel() {} // 0x000000018350B670-0x000000018350B680
	}

	public class LoginHotUpdater : CustomYieldInstruction, IDisposable // TypeDefIndex: 53186
	{
		// Fields
		private const int MODE_SKIP = 0; // Metadata: 0x01FD3F50
		private const int MODE_DOWNLOAD = 1; // Metadata: 0x01FD3F51
		private const int MODE_LOCAL = 2; // Metadata: 0x01FD3F52
		private static bool s_hasInitialAssetChanged; // 0x00
		private static bool s_isNeedSoftRestart; // 0x01
		private LoginContext m_loginCxt; // 0x10
		private IEnumerator m_mainRoutine; // 0x18
		private LoginProgress m_progress; // 0x20
		private LoginHotUpdateProp m_hotupdateProp; // 0x28
		private LoginDownloadTask m_downloadTask; // 0x30
		private LoginLocalResTask m_localResTask; // 0x38
		private bool m_resRepairMode; // 0x40
		public const string URL_GET_SPLIT = "/"; // Metadata: 0x01FD3F53
	
		// Properties
		public override bool keepWaiting { get => default; } // 0x0000000182702DB0-0x0000000182702DC0 
	
		// Nested types
		public class HotUpdateInfo // TypeDefIndex: 53161
		{
			// Fields
			public FResourceDiff resDiff; // 0x10
			public LocalResPref localResPref; // 0x50
	
			// Constructors
			public HotUpdateInfo() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool CheckIfNeedReload() => default; // 0x0000000185772FC8-0x0000000185773174
			public bool HasChangedByType(EVFSBlockType type) => default; // 0x00000001839CF700-0x00000001839CF760
			public bool HasAssetsChanged() => default; // 0x0000000185773174-0x0000000185773218
		}
	
		public class WorkContext // TypeDefIndex: 53162
		{
			// Fields
			public HotUpdateInfo updateInitial; // 0x10
			public HotUpdateInfo updateMain; // 0x18
			public string vitalError; // 0x20
			public bool reboot; // 0x28
			public NetUsagePolicy netUsagePolicy; // 0x30
			public ResourceIndex resIndex; // 0x38
	
			// Properties
			public bool illegalItemsInLocalRes { get; private set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
	
			// Constructors
			public WorkContext() {} // 0x0000000182F42420-0x0000000182F42490
	
			// Methods
			public void MarkIllegalItemsInLocalRes() {} // 0x000000018577BE58-0x000000018577BEA8
			public HotUpdateInfo GetHotUpdateInfo(bool isInitial) => default; // 0x000000018577BDF4-0x000000018577BE58
			public bool HasChangedByType(EVFSBlockType type) => default; // 0x00000001839CF690-0x00000001839CF700
		}
	
		// Constructors
		public LoginHotUpdater() {} // Dummy constructor
		private LoginHotUpdater(LoginContext context, bool resRepairMode) {} // 0x0000000183CA90B0-0x0000000183CA9150
	
		// Methods
		protected static void MarkInitialAssetChanged() {} // 0x0000000185775800-0x000000018577586C
		protected static bool CheckInitialAssetChanged() => default; // 0x00000001857756A0-0x000000018577570C
		protected static void MarkNeedClearFolder(bool isInitial) {} // 0x000000018577586C-0x00000001857758F4
		protected static bool NeedClearFolder(bool isInitial) => default; // 0x0000000185775960-0x00000001857759E4
		protected static void MarkClearSuccessed(bool isInitial) {} // 0x0000000185775778-0x0000000185775800
		public static void MarkSoftRestart() {} // 0x00000001857758F4-0x0000000185775960
		public static void ClearSoftRestartFlag() {} // 0x000000018577570C-0x0000000185775778
		public static bool IsNeedSoftRestart() => default; // 0x0000000182C38960-0x0000000182C389B0
		public void Dispose() {} // 0x000000018379F8E0-0x000000018379FA20
		public static LoginHotUpdater StartHotUpdate(LoginContext context, bool resRepairMode) => default; // 0x0000000182C36CB0-0x0000000182C36D60
		[IteratorStateMachine(typeof(__Work_d__27))]
		private IEnumerator _Work() => default; // 0x0000000182C36D60-0x0000000182C36DD0
		[IteratorStateMachine(typeof(__CreateMainCoroutine_d__28))]
		private IEnumerator _CreateMainCoroutine(WorkContext workContext) => default; // 0x0000000182F42390-0x0000000182F42420
		[IteratorStateMachine(typeof(__MainCoroutineModeSkip_d__29))]
		private IEnumerator _MainCoroutineModeSkip(WorkContext context) => default; // 0x000000018399EAC0-0x000000018399EB50
		[IteratorStateMachine(typeof(__MainCoroutineModeLocal_d__30))]
		private IEnumerator _MainCoroutineModeLocal(WorkContext context) => default; // 0x000000018577661C-0x00000001857766C4
		[IteratorStateMachine(typeof(__UpdateResVersion_d__31))]
		private IEnumerator _UpdateResVersion(WorkContext workContext) => default; // 0x0000000182F42300-0x0000000182F42390
		private static void _SetResVersionForLog() {} // 0x0000000182F43200-0x0000000182F432D0
		private string _GetOnlineResVersion(bool isInitial) => default; // 0x0000000185776304-0x00000001857763D8
		public string ResourceRootUrl(string version, bool isInitial) => default; // 0x00000001857759E4-0x0000000185775AA0
		[IteratorStateMachine(typeof(__UpdateResVersionDev_d__35))]
		private IEnumerator _UpdateResVersionDev(WorkContext workContext) => default; // 0x00000001857769C0-0x0000000185776A48
		[IteratorStateMachine(typeof(__UpdateResVersionProd_d__37))]
		private IEnumerator _UpdateResVersionProd(WorkContext workContext) => default; // 0x0000000183B38830-0x0000000183B388B0
		private string _ResourcePatchUrl(string version, bool isInitial) => default; // 0x0000000185776908-0x00000001857769C0
		private string _ResourceFileUrl(string version, bool isInitial) => default; // 0x00000001857766C4-0x000000018577677C
		private string _ResourcePatchRootUrl(string version, bool isInitial) => default; // 0x0000000185776844-0x0000000185776908
		private string _ResourceIndexUrl(string version, bool isInitial) => default; // 0x000000018577677C-0x0000000185776844
		[IteratorStateMachine(typeof(__MainCoroutineModeDownload_d__42))]
		private IEnumerator _MainCoroutineModeDownload(WorkContext workContext) => default; // 0x0000000185776574-0x000000018577661C
		[IteratorStateMachine(typeof(__ReloadResourceIndexes_d__43))]
		private IEnumerator _ReloadResourceIndexes(WorkContext workContext) => default; // 0x0000000183B21C20-0x0000000183B21CA0
		[IteratorStateMachine(typeof(__LoadOrDownloadResIndex_d__44))]
		private IEnumerator _LoadOrDownloadResIndex(string onlineVer, bool isInitial, Beyond.Misc.ObjectRef resIndexRef) => default; // 0x00000001857763D8-0x00000001857764B4
		[IteratorStateMachine(typeof(__GenResIndex_d__45))]
		private IEnumerator _GenResIndex(string onlineVer, bool isInitial, WorkContext workContext) => default; // 0x000000018577614C-0x0000000185776228
		[IteratorStateMachine(typeof(__GenRiff_d__46))]
		private IEnumerator _GenRiff(string onlineVer, bool isInitial, WorkContext workContext) => default; // 0x0000000185776228-0x0000000185776304
		private static LocalResPref _CreateUpdatedLocalResPref(string onlineVer, bool isInitial, LocalResPref oldLocalResPref, FResourceDiff resDiff, out int removedFileCount) {
			removedFileCount = default;
			return default;
		} // 0x0000000181039570-0x000000018103C3B0
		[IteratorStateMachine(typeof(__GenLocalRef_d__48))]
		private IEnumerator _GenLocalRef(string onlineVer, bool isInitial, WorkContext workContext) => default; // 0x000000018577607C-0x000000018577614C
		[IteratorStateMachine(typeof(__CheckAndDownloadResource_d__49))]
		private IEnumerator _CheckAndDownloadResource(string onlineVer, bool isInitial, WorkContext workContext) => default; // 0x0000000185775BFC-0x0000000185775CD8
		private void _EventLogDownloadProgress(ref bool first, double current, double total, int target, bool isInitial) {} // 0x0000000185775F64-0x000000018577607C
		[IteratorStateMachine(typeof(__DownloadPatchInfo_d__51))]
		private IEnumerator _DownloadPatchInfo(string onlineVer, bool isInitial, Beyond.Misc.ObjectRef patchInfoRef) => default; // 0x0000000185775E88-0x0000000185775F64
		[IteratorStateMachine(typeof(__ClearDownloadFolder_d__52))]
		private IEnumerator _ClearDownloadFolder(WorkContext workContext, bool needDeleteInitial, bool needDeleteMain) => default; // 0x0000000185775DB4-0x0000000185775E88
		[IteratorStateMachine(typeof(__CheckLocalResConsistency_d__53))]
		private IEnumerator _CheckLocalResConsistency(string onlineVer, bool isInitial, WorkContext context) => default; // 0x0000000185775CD8-0x0000000185775DB4
		[IteratorStateMachine(typeof(__VitalError_d__54))]
		private IEnumerator _VitalError(string error) => default; // 0x0000000185776A48-0x0000000185776AF0
		[IteratorStateMachine(typeof(__LoadStreamingIndex_d__55))]
		private static IEnumerator _LoadStreamingIndex(bool isInitial, WorkContext workContext, Beyond.Misc.ObjectRef resultRef) => default; // 0x00000001857764B4-0x0000000185776574
		public static void WriteLocalResPrefToFile(LocalResPref localResPref, WorkContext workContext) {} // 0x0000000185775AA0-0x0000000185775BFC
		private static int _CurrentWorkMode(LoginContext context) => default; // 0x000000018399EB50-0x000000018399EBE0
	}

	public class LoginProgress : LoginHotUpdateModel.IProgress // TypeDefIndex: 53189
	{
		// Fields
		public const int MODE_PROG = 0; // Metadata: 0x01FD3F55
		public const int MODE_SIZE = 1; // Metadata: 0x01FD3F56
		public const int MODE_IDEL = 2; // Metadata: 0x01FD3F57
		public int mode; // 0x10
		public double current; // 0x18
		public double total; // 0x20
		public double speed; // 0x28
		private FDownloadSize m_downloadSize; // 0x30
	
		// Nested types
		private struct FDownloadSize // TypeDefIndex: 53188
		{
			// Fields
			private const double MB = 1048576; // Metadata: 0x01FD3F58
			private const double KB = 1024; // Metadata: 0x01FD3F60
			private EUnit m_unit; // 0x00
			private float m_displayCurrent; // 0x04
			private float m_displayTotal; // 0x08
			private float m_displaySpeed; // 0x0C
			public string displayInfo; // 0x10
			private float m_current; // 0x18
			private float m_total; // 0x1C
	
			// Nested types
			private enum EUnit // TypeDefIndex: 53187
			{
				NONE = 0,
				B = 1,
				KB = 2,
				MB = 3
			}
	
			// Methods
			public void SetProgress(double current, double total) {} // 0x000000018577C668-0x000000018577C778
			public void SetIdle() {} // 0x000000018577C59C-0x000000018577C668
			public void SetSize(double current, double total, double speed) {} // 0x000000018577C778-0x000000018577C978
			private static EUnit _PickUnit(double number) => default; // 0x000000018577CCEC-0x000000018577CD70
			private static float _DisplayWithUnit(double number, EUnit unit) => default; // 0x000000018577C978-0x000000018577CA18
			private static string _FormatDisplayInfo(float current, float total, EUnit unit) => default; // 0x000000018577CA18-0x000000018577CB4C
			private static string _FormatSpeedInfo(float speed, EUnit unit) => default; // 0x000000018577CBFC-0x000000018577CCEC
			private static string _FormatProgressInfo(float current, float total) => default; // 0x000000018577CB4C-0x000000018577CBFC
		}
	
		// Constructors
		public LoginProgress() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public double GetCurrent() => default; // 0x000000018577ED44-0x000000018577ED94
		public double GetTotal() => default; // 0x000000018577EE40-0x000000018577EE90
		public string GetInfo() => default; // 0x000000018577ED94-0x000000018577EE40
	}

	public class LoginInitNode : LoginWorkFlow.Node // TypeDefIndex: 53193
	{
		// Fields
		private bool m_isSDKInited; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	
		// Constructors
		public LoginInitNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x00000001836BCBF0-0x00000001836BCCD0
		[IteratorStateMachine(typeof(__InitCoroutine_d__4))]
		private IEnumerator _InitCoroutine() => default; // 0x00000001836BCCD0-0x00000001836BCD40
		[IteratorStateMachine(typeof(__InitRemoteConfigs_d__5))]
		private IEnumerator _InitRemoteConfigs() => default; // 0x0000000183893CB0-0x0000000183893D20
		[IteratorStateMachine(typeof(__YieldAlertError_d__6))]
		private IEnumerator _YieldAlertError(string errorInfo) => default; // 0x000000018577D82C-0x000000018577D8C8
	}

	public class LoginLocalResTask : IDisposable // TypeDefIndex: 53196
	{
		// Fields
		private LoginContext m_loginCxt; // 0x10
		private LoginHotUpdater.WorkContext m_workCxt; // 0x18
	
		// Constructors
		public LoginLocalResTask() {} // Dummy constructor
		public LoginLocalResTask(LoginContext loginContext, LoginHotUpdater.WorkContext workContext) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		[IteratorStateMachine(typeof(_Work_d__3))]
		public IEnumerator Work() => default; // 0x000000018577DD64-0x000000018577DDF4
		public void Dispose() {} // 0x000000018577DD20-0x000000018577DD64
	}

	public class PreloadNode : LoginWorkFlow.Node // TypeDefIndex: 53204
	{
		// Fields
		private LoginHotUpdateModel.SimpleProgress m_progress; // 0x20
		private bool m_getServerListSuc; // 0x28
		private string m_errorMsg; // 0x30
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public PreloadNode() {} // 0x00000001837B81F0-0x00000001837B8270
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000182C362C0-0x0000000182C36460
		private void _ShowPreloadResourcePanel() {} // 0x00000001828D4940-0x00000001828D4A40
		[IteratorStateMachine(typeof(__LoginPreLoad_d__7))]
		private IEnumerator _LoginPreLoad() => default; // 0x0000000182C36460-0x0000000182C364D0
		[IteratorStateMachine(typeof(__WarmUp_d__8))]
		private IEnumerator _WarmUp() => default; // 0x0000000182C34EE0-0x0000000182C34F50
		[IteratorStateMachine(typeof(__GetServerList_d__9))]
		private IEnumerator _GetServerList() => default; // 0x0000000182C34E70-0x0000000182C34EE0
		private void _EnterPreLoad() {} // 0x0000000182C34F50-0x0000000182C34FA0
		[IteratorStateMachine(typeof(__GetServerListInfoMock_d__11))]
		private IEnumerator _GetServerListInfoMock() => default; // 0x0000000182D77060-0x0000000182D770D0
		[IteratorStateMachine(typeof(__GetServerListInfo_d__12))]
		private IEnumerator _GetServerListInfo() => default; // 0x000000018578006C-0x00000001857800FC
		private void _OnGetServerListSuc() {} // 0x0000000182D763A0-0x0000000182D76F70
		private void _OnGetServerListFail(string errorInfo) {} // 0x00000001857800FC-0x00000001857801B8
	}

	public class LoginSDKInitNode : LoginWorkFlow.Node // TypeDefIndex: 53208
	{
		// Fields
		private bool m_isSDKInited; // 0x20
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public LoginSDKInitNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x00000001836BCD40-0x00000001836BCE20
		[IteratorStateMachine(typeof(__SDKInitCoroutine_d__4))]
		private IEnumerator _SDKInitCoroutine() => default; // 0x00000001836BCE20-0x00000001836BCE90
		[IteratorStateMachine(typeof(__WaitForSDKInited_d__5))]
		private IEnumerator _WaitForSDKInited() => default; // 0x0000000182D78350-0x0000000182D783B0
		[IteratorStateMachine(typeof(__InitSubSDKs_d__6))]
		private IEnumerator _InitSubSDKs(string env) => default; // 0x0000000182D77C90-0x0000000182D77D10
	}

	public class U8LoginNode : LoginWorkFlow.Node // TypeDefIndex: 53211
	{
		// Fields
		private bool m_loginSuc; // 0x20
		private bool m_isSDKLoginFinished; // 0x21
		private int m_rqstSkipLoginCache; // 0x24
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D51100-0x0000000183D51110 
	
		// Constructors
		public U8LoginNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x00000001836BCE90-0x00000001836BCF70
		[IteratorStateMachine(typeof(__LoginCoroutine_d__6))]
		private IEnumerator _LoginCoroutine() => default; // 0x00000001836BCF70-0x00000001836BCFE0
		[IteratorStateMachine(typeof(__FinishLogin_d__7))]
		private IEnumerator _FinishLogin() => default; // 0x0000000182D783B0-0x0000000182D78410
		public override bool OnEvent(ELoginEvent evt, object param) => default; // 0x0000000185782484-0x0000000185782508
		private void _StartSDKLogin() {} // 0x0000000182C37AE0-0x0000000182C37D40
		private void _SetCursorOnLoginStart() {} // 0x0000000182D770D0-0x0000000182D77150
		private void _SetCursorOnLoginFinish() {} // 0x0000000182D77240-0x0000000182D772C0
		private void _SkipSDKLogin() {} // 0x00000001857827B4-0x0000000185782880
		private void _ClearLoginCaches() {} // 0x00000001828D4640-0x00000001828D4720
		private void _OnLoginSuc() {} // 0x0000000182EA95C0-0x0000000182EA9680
		private void _OnLoginFail(object rawInfo) {} // 0x000000018578268C-0x00000001857827B4
		private void _OnSDKViewDisabled() {} // 0x0000000182EA9BE0-0x0000000182EA9C20
		private void _OnLoginCanceled() {} // 0x00000001857825E0-0x000000018578268C
		private void _EnableBlurMask(bool enable) {} // 0x0000000182EA97C0-0x0000000182EA9860
		public bool __iFixBaseProxy_OnEvent(ELoginEvent P0, object P1) => default; // 0x00000001857743DC-0x00000001857743E4
	}

	public class LoginProperty<T> : LoginWorkFlow.IWorkerUpdateOnce // TypeDefIndex: 53212
		where T : class, new()
	{
		// Fields
		private T m_value;
		private HashSet<ILoginBinder<T>> m_binders;
		private LoginWorkFlow m_workflow;
	
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

	public interface ILoginBinder<T> // TypeDefIndex: 53213
	{
		// Methods
		void OnValueChanged(T value);
	}

	public interface ILoginContextReceiver // TypeDefIndex: 53214
	{
		// Methods
		void OnLoginContext(LoginContext context);
	}

	public class LoginViewModel // TypeDefIndex: 53216
	{
		// Fields
		public LoginWorkFlow.ENode workCachedCurNode; // 0x10
		public LoginWorkFlow.ENode workCurNode; // 0x14
		public bool isFirstLogin; // 0x18
		public bool isU8LoginCancelled; // 0x20
		public FAgeTipsPolicy ageTipsPolicy; // 0x28
	
		// Properties
		public int rqstSkipU8Login { get; private set; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public int rqstResRepairCode { get; private set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
	
		// Nested types
		public struct FAgeTipsPolicy // TypeDefIndex: 53215
		{
			// Fields
			public bool canOpenDetail; // 0x00
			public bool displayCN; // 0x01
			public bool displayKR; // 0x02
	
			// Properties
			public bool display { get => default; } // 0x0000000182C3B5D0-0x0000000182C3B5E0 
		}
	
		// Constructors
		public LoginViewModel() {} // 0x0000000183CA4880-0x0000000183CA48B0
	
		// Methods
		public bool IsAgeTipsVisible() => default; // 0x0000000182C3B550-0x0000000182C3B5D0
		public bool IsGovTipsVisible() => default; // 0x0000000182C3B410-0x0000000182C3B440
		public bool IsMenuVisible() => default; // 0x0000000182C3B5E0-0x0000000182C3B6B0
		public void RequestResourceRepair() {} // 0x000000018577EEF4-0x000000018577EF40
		public void RequestSkipU8Login() {} // 0x000000018577EF40-0x000000018577EF8C
		private static FAgeTipsPolicy _LoadAgeTipsPolicy() => default; // 0x0000000183CA48B0-0x0000000183CA4920
	}

	public class LoginViewProperty : LoginProperty<LoginViewModel> // TypeDefIndex: 53217
	{
		// Properties
		public LoginHotUpdateProp hotUpdateProp { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public LoginAgeTipsProp ageTipsProp { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public LoginServerSelectProp serverSelectProp { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
	
		// Constructors
		public LoginViewProperty() {} // Dummy constructor
		public LoginViewProperty(LoginWorkFlow workflow) {} // 0x00000001828D44E0-0x00000001828D45F0
	}

	public class LoginAgeTipsModel // TypeDefIndex: 53218
	{
		// Fields
		public string contentCache; // 0x10
		public bool isShow; // 0x18
		public bool isFetchingContent; // 0x19
	
		// Constructors
		public LoginAgeTipsModel() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool IsContentEmpty() => default; // 0x00000001828D4790-0x00000001828D47D0
		public bool CanDisplay() => default; // 0x0000000183C7D0D0-0x0000000183C7D1C0
	}

	public class LoginAgeTipsProp : LoginProperty<LoginAgeTipsModel> // TypeDefIndex: 53219
	{
		// Constructors
		public LoginAgeTipsProp() {} // Dummy constructor
		public LoginAgeTipsProp(LoginWorkFlow workflow) {} // 0x00000001828D4720-0x00000001828D4790
	
		// Methods
		public void ClearContentCache() {} // 0x000000018577D468-0x000000018577D52C
		public void UpdateContent(string content) {} // 0x000000018577D52C-0x000000018577D5DC
	}

	public class LoginWorkFlow : IDisposable // TypeDefIndex: 53230
	{
		// Fields
		public const string CURSOR_KEY_LOGIN = "login"; // Metadata: 0x01FD3F6E
		private static readonly ENode[] NODE_ORDER; // 0x00
		private const ENode NEED_GAME_LOGIN_STATE_BEFORE_NODE = ENode.Preload; // Metadata: 0x01FD3F74
		private readonly Node[] m_nodes; // 0x10
		private readonly LoginContext m_context; // 0x18
		private FWork m_work; // 0x20
		private Worker m_worker; // 0x30
		private HashSet<IEventReceiver> m_evtRecvrs; // 0x38
		private List<IEventReceiver> m_recvrBuffer; // 0x40
	
		// Properties
		public bool isDisposed { get; private set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
	
		// Nested types
		public abstract class Node // TypeDefIndex: 53220
		{
			// Properties
			protected LoginContext context { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
			protected LoginWorkFlow workflow { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public abstract ENode type { get; }
	
			// Constructors
			protected Node() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Init(LoginContext context, LoginWorkFlow workflow) {} // 0x0000000182C388D0-0x0000000182C38930
			public void Dispose() {} // 0x0000000182C389B0-0x0000000182C389F0
			public abstract CustomYieldInstruction Work();
			public virtual bool CanCancel() => default; // 0x000000018577FFD4-0x0000000185780020
			public virtual CustomYieldInstruction Cancel() => default; // 0x0000000185780020-0x000000018578006C
			protected virtual void OnInit() {} // 0x0000000182C38930-0x0000000182C38960
			public virtual void OnDispose() {} // 0x000000018379F840-0x000000018379F870
			public virtual bool OnEvent(ELoginEvent evt, object param) => default; // 0x0000000182D758F0-0x0000000182D75930
		}
	
		public enum ENode // TypeDefIndex: 53221
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
	
		public interface IWorkerUpdateOnce // TypeDefIndex: 53222
		{
			// Methods
			void Worker_UpdateOnce();
		}
	
		public interface IEventReceiver // TypeDefIndex: 53223
		{
			// Methods
			void OnEvent(ELoginEvent evt, object param);
		}
	
		private class Worker : IDisposable // TypeDefIndex: 53225
		{
			// Fields
			private HashSet<IWorkerUpdateOnce> m_updateOnce; // 0x10
			private List<IWorkerUpdateOnce> m_buffer; // 0x18
			private CustomYieldInstruction m_curWork; // 0x20
	
			// Properties
			public bool isCancelled { get; private set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
			public bool isDisposed { get; private set; } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000183D4F2B0-0x0000000183D4F2C0
			public Node curNode { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
			// Constructors
			public Worker() {} // 0x0000000183C95FE0-0x0000000183C960A0
	
			// Methods
			public bool Cancel() => default; // 0x0000000185782880-0x0000000185782DCC
			public void Dispose() {} // 0x0000000183CF6170-0x0000000183CF61F0
			public void SetCurNode(Node node) {} // 0x0000000182C386D0-0x0000000182C38780
			public bool UpdateOnce(IWorkerUpdateOnce inst) => default; // 0x00000001836007F0-0x0000000183600870
			public void TickInEmptyFrame() {} // 0x000000018306D640-0x000000018306D680
			[IteratorStateMachine(typeof(_Work_d__20))]
			public IEnumerator Work(CustomYieldInstruction work) => default; // 0x0000000182C389F0-0x0000000182C38A80
			private void _InternalTick() {} // 0x000000018306D7C0-0x000000018306DBF0
		}
	
		private struct FWork // TypeDefIndex: 53226
		{
			// Fields
			public static readonly FWork IDLE; // 0x00
	
			// Properties
			public bool didFallback { [IsReadOnly] get; private set; } // 0x0000000183D51020-0x0000000183D51030 0x0000000183D4F9D0-0x0000000183D4F9E0
			public int nodeIndex { [IsReadOnly] get; private set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
			public bool isWorking { [IsReadOnly] get; private set; } // 0x0000000183D557D0-0x0000000183D557E0 0x0000000183D557E0-0x0000000183D557F0
			public ENode curNode { get => default; } // 0x0000000182C39460-0x0000000182C39510 
	
			// Constructors
			static FWork() {
				IDLE = default;
			} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void MarkFallback(int newIndex) {} // 0x000000018577CD70-0x000000018577CDF4
			public bool ConsumeFallback() => default; // 0x0000000182C39570-0x0000000182C395D0
			public void MoveNextIndex() {} // 0x0000000182C39510-0x0000000182C39570
			public static FWork Start() => default; // 0x0000000183CE47E0-0x0000000183CE4870
			public bool WorkEnd() => default; // 0x0000000182C38DB0-0x0000000182C38E60
		}
	
		// Constructors
		public LoginWorkFlow() {} // Dummy constructor
		public LoginWorkFlow(LoginContext context) {} // 0x0000000182C38A80-0x0000000182C38C00
		static LoginWorkFlow() {} // 0x0000000183CE3B80-0x0000000183CE3C10
	
		// Methods
		private Node[] _RegisterNodes() => default; // 0x00000001837B7E90-0x00000001837B81F0
		[IteratorStateMachine(typeof(_DoWorkFlow_d__21))]
		public IEnumerator DoWorkFlow() => default; // 0x0000000182EA9D50-0x0000000182EA9DC0
		public void Dispose() {} // 0x0000000182C38C00-0x0000000182C38DB0
		public bool PeekFallbackStatus(out ENode fallbackNode) {
			fallbackNode = default;
			return default;
		} // 0x000000018379FA20-0x000000018379FAD0
		public bool Fallback(ENode target, bool validCheck = true /* Metadata: 0x01FD3F6C */) => default; // 0x000000018577F0B0-0x000000018577F308
		public bool CancelAndFallback(ENode target, bool validCheck = true /* Metadata: 0x01FD3F6D */) => default; // 0x000000018577F01C-0x000000018577F0B0
		public void SendEvent(ELoginEvent evt, object param = null) {} // 0x0000000182D75460-0x0000000182D757E0
		public void AddEventReceiver(IEventReceiver receiver) {} // 0x000000018577EF8C-0x000000018577F01C
		public bool UpdateOnce(IWorkerUpdateOnce inst) => default; // 0x0000000183600790-0x00000001836007F0
		public static bool IsBeforeWork(ENode curNode, ENode check) => default; // 0x0000000182C396F0-0x0000000182C39760
		public static bool IsOnOrAfterWork(ENode curNode, ENode check) => default; // 0x0000000182C3B000-0x0000000182C3B0D0
		public static bool IsAfterWork(ENode target, ENode check) => default; // 0x000000018577F308-0x000000018577F3CC
		private bool _HandleGlobalEvent(ELoginEvent evt, object param) => default; // 0x0000000182D757E0-0x0000000182D75850
		private void _EventOnOpenAgeTips() {} // 0x000000018577F690-0x000000018577F804
		private void _EventOnCloseAgeTips() {} // 0x000000018577F3CC-0x000000018577F4F4
		private void _EventOnOpenServerSelect(bool isOpen) {} // 0x000000018577F804-0x000000018577F8D4
		private void _EventOnSelectServer(ServerZoneManager.ServerZoneData serverZoneData) {} // 0x000000018577F8D4-0x000000018577F9B4
		private void _EventOnConfirmServer() {} // 0x000000018577F4F4-0x000000018577F690
		private void _EnableCursor(bool enabled) {} // 0x0000000182C383E0-0x0000000182C384A0
		private void _UpdateCursor([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input) {} // 0x000000018577FA5C-0x000000018577FBA4
		private void _EnbaleToggleGroup() {} // 0x0000000182D7AB60-0x0000000182D7ABD0
		[IteratorStateMachine(typeof(__FetchAgeTipsCoroutine_d__41))]
		private IEnumerator _FetchAgeTipsCoroutine(LoginAgeTipsProp prop) => default; // 0x000000018577F9B4-0x000000018577FA5C
		private static bool _CheckIfGameStateNotMatch(ENode curNode) => default; // 0x0000000182C395D0-0x0000000182C39670
		[IteratorStateMachine(typeof(__AdjustCurrentGameState_d__43))]
		private static IEnumerator _AdjustCurrentGameState(ENode curNode) => default; // 0x0000000182C38660-0x0000000182C386D0
	}

	public class HotUpdateNode : LoginWorkFlow.Node // TypeDefIndex: 53231
	{
		// Fields
		private LoginHotUpdater m_updater; // 0x20
		private int m_cachedResRepairCode; // 0x28
	
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D51110-0x0000000183D51120 
	
		// Constructors
		public HotUpdateNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000182C36DD0-0x0000000182C36E80
		public override void OnDispose() {} // 0x000000018379F7A0-0x000000018379F800
		public void __iFixBaseProxy_OnDispose() {} // 0x00000001857732FC-0x0000000185773304
	}

	public abstract class WaitForSecondsNode : LoginWorkFlow.Node // TypeDefIndex: 53232
	{
		// Fields
		private int? m_timerId; // 0x20
	
		// Constructors
		protected WaitForSecondsNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000182C36A50-0x0000000182C36C00
		private bool _IsTimeout() => default; // 0x00000001838C19F0-0x00000001838C1A40
		private void _NotifyTimeout() {} // 0x0000000183D07940-0x0000000183D07970
		private void _DisposeTimer() {} // 0x000000018379F870-0x000000018379F8E0
		protected abstract float WaitForSeconds(out bool unscaled);
		public override void OnDispose() {} // 0x000000018379F800-0x000000018379F840
		public void __iFixBaseProxy_OnDispose() {} // 0x00000001857732FC-0x0000000185773304
	}

	public class PreloadPostDelayNode : WaitForSecondsNode // TypeDefIndex: 53233
	{
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D55810-0x0000000183D55820 
	
		// Constructors
		public PreloadPostDelayNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override float WaitForSeconds(out bool unscaled) {
			unscaled = default;
			return default;
		} // 0x0000000183D43E20-0x0000000183D43E60
		public override CustomYieldInstruction Work() => default; // 0x0000000182C37580-0x0000000182C375C0
		private void _DisableLoadingPanel() {} // 0x00000001828D4A40-0x00000001828D4B00
		public CustomYieldInstruction __iFixBaseProxy_Work() => default; // 0x00000001857801B8-0x00000001857801C0
	}

	public class Trans2GsLoginNode : WaitForSecondsNode // TypeDefIndex: 53234
	{
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D55730-0x0000000183D55740 
	
		// Constructors
		public Trans2GsLoginNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override float WaitForSeconds(out bool unscaled) {
			unscaled = default;
			return default;
		} // 0x0000000182EA9680-0x0000000182EA9730
		public override CustomYieldInstruction Work() => default; // 0x0000000182C37130-0x0000000182C371A0
		public CustomYieldInstruction __iFixBaseProxy_Work() => default; // 0x00000001857801B8-0x00000001857801C0
	}

	public class FinishNode : LoginWorkFlow.Node // TypeDefIndex: 53235
	{
		// Properties
		public override LoginWorkFlow.ENode type { get => default; } // 0x0000000183D557F0-0x0000000183D55800 
	
		// Constructors
		public FinishNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override CustomYieldInstruction Work() => default; // 0x0000000182C370B0-0x0000000182C37130
	}

	public struct CarrierDownloadCache // TypeDefIndex: 53236
	{
		// Fields
		public static readonly CarrierDownloadCache EMPTY; // 0x00
		public long size; // 0x00
		public bool isAllowed; // 0x08
	
		// Constructors
		static CarrierDownloadCache() {
			EMPTY = default;
		} // 0x0000000183D26E90-0x0000000183D26FB0
	}

	public class NetUsagePolicy // TypeDefIndex: 53239
	{
		// Fields
		private const int NOT_REACHABLE_ERROR_CODE = 30000; // Metadata: 0x01FD3F83
		private CarrierDownloadCache m_mobileDataCache; // 0x10
		private NetworkReachability m_lastNetworkState; // 0x20
		private Options m_options; // 0x28
	
		// Nested types
		public struct Options // TypeDefIndex: 53237
		{
			// Fields
			public long minBytesToNotifyCarrier; // 0x00
		}
	
		// Constructors
		public NetUsagePolicy() {} // Dummy constructor
		public NetUsagePolicy(Options options) {} // 0x00000001828D5280-0x00000001828D52F0
	
		// Methods
		public void CheckIfAllowDownload(long downloadSize, Action onAllowed, Action onRejected, Action onReachable = null) {} // 0x000000018577FBFC-0x000000018577FF4C
		public bool AllowMobileDataInLastCheck() => default; // 0x000000018577FBA4-0x000000018577FBFC
		private static string _GetPrettySizeStringUpToMB(double number) => default; // 0x000000018577FF4C-0x000000018577FFD4
	}

	public class LoginSceneAnimCtrl : LoginSceneComponent, ILoginBinder<LoginViewModel>, IAnimationClipSource // TypeDefIndex: 53241
	{
		// Fields
		private const float COUNT_DOWN_EMPTY = -1f; // Metadata: 0x01FD3F87
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Nested types
		private enum EState // TypeDefIndex: 53240
		{
			NONE = 0,
			A1 = 1,
			A2 = 2
		}
	
		// Constructors
		public LoginSceneAnimCtrl() {} // 0x0000000183B5CD10-0x0000000183B5CD70
	
		// Methods
		protected override void OnBindToManager() {} // 0x0000000182EA91C0-0x0000000182EA9240
		private UIAnimationMixPlayer _EnsurePlayer() => default; // 0x0000000183099C10-0x0000000183099CE0
		private void _ChangeToState(EState target) {} // 0x0000000182C3AF80-0x0000000182C3B000
		private void _ResetToA1() {} // 0x0000000183099840-0x0000000183099A10
		private void _TransitionToA2() {} // 0x00000001839B3B00-0x00000001839B3BE0
		private void _PlayA1sAndTriggerNext() {} // 0x00000001830996A0-0x0000000183099840
		private float _RandomIntervalA1s() => default; // 0x0000000183099E60-0x0000000183099F80
		private void _PlayA1A2Impl() {} // 0x0000000183099A10-0x0000000183099C10
		public void OnValueChanged(LoginViewModel value) {} // 0x0000000182C3AEE0-0x0000000182C3AF80
		protected override void Start() {} // 0x0000000182C3CA20-0x0000000182C3CAD0
		public override void Tick(float deltaTime) {} // 0x000000018262E210-0x000000018262E4C0
		protected override void OnRelease() {} // 0x00000001839A13E0-0x00000001839A14B0
		public void GetAnimationClips(List<AnimationClip> results) {} // 0x000000018577EE90-0x000000018577EEE4
		public void __iFixBaseProxy_OnBindToManager() {} // 0x000000018577EEE4-0x000000018577EEEC
		public void __iFixBaseProxy_Start() {} // 0x000000018577EEEC-0x000000018577EEF4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public abstract class LoginSceneComponent : TickableMono // TypeDefIndex: 53242
	{
		// Properties
		protected override TickType tickOption { get; } // 0x0000000181002730-0x0000000181002740 
		protected LoginContext context { get; private set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		protected LoginController controller { get; private set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
	
		// Constructors
		protected LoginSceneComponent() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected virtual void Start() {} // 0x0000000182C3CB50-0x0000000182C3CBC0
		public void Bind(LoginContext context, LoginController controller) {} // 0x0000000182EA9A40-0x0000000182EA9AB0
		protected virtual void OnBindToManager() {} // 0x0000000182EA94D0-0x0000000182EA9500
	}

	public class LoginSceneRoot : LoginSceneComponent // TypeDefIndex: 53243
	{
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public LoginSceneRoot() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected override void OnBindToManager() {} // 0x0000000182EA88F0-0x0000000182EA8AA0
		public void __iFixBaseProxy_OnBindToManager() {} // 0x000000018577EEE4-0x000000018577EEEC
	}

	public class LoginAgeTipsDetailPanel : MonoBehaviour, ILoginBinder<LoginAgeTipsModel> // TypeDefIndex: 53244
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
		private const int MAX_TEXT_STRLEN = 10000; // Metadata: 0x01FD3F8E
		private const int MIN_TEXT_STRLEN = 1000; // Metadata: 0x01FD3F92
	
		// Constructors
		public LoginAgeTipsDetailPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Init(LoginContext context) {} // 0x0000000183610BA0-0x0000000183610D40
		public void OnValueChanged(LoginAgeTipsModel value) {} // 0x0000000183C7D010-0x0000000183C7D0D0
		private void _RenderContent(string contentStr) {} // 0x000000018577CE6C-0x000000018577CFDC
		private void _ShowContent() {} // 0x000000018577CFDC-0x000000018577D038
		private void _EventOnCloseClicked(PointerEventData _) {} // 0x000000018577CDF4-0x000000018577CE6C
		private static List<string> _SplitLicenseToSegments(string content) => default; // 0x000000018577D038-0x000000018577D31C
		private static void _SplitLongString(string longStr, List<string> outputList) {} // 0x000000018577D31C-0x000000018577D3E8
	}

	public class LoginAgeTipsPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 53245
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
		public LoginAgeTipsPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnInit() {} // 0x0000000183610410-0x0000000183610530
		public void OnValueChanged(LoginViewModel value) {} // 0x0000000182C3B4C0-0x0000000182C3B550
		private void _UpdateAgeTipsPolicy(LoginViewModel.FAgeTipsPolicy policy) {} // 0x0000000182C3BBA0-0x0000000182C3BC20
		private void _EventOnOpenAgeTipsClicked(PointerEventData _) {} // 0x000000018577D3F0-0x000000018577D468
		public void __iFixBaseProxy_OnInit() {} // 0x000000018577D3E8-0x000000018577D3F0
	}

	public class LoginAlertDialog : LoginController.Dialog // TypeDefIndex: 53247
	{
		// Fields
		[SerializeField]
		private UIButton _btnConfirm; // 0x38
		[SerializeField]
		private UIText _text; // 0x40
		private FParams m_params; // 0x48
	
		// Nested types
		public struct FParams // TypeDefIndex: 53246
		{
			// Fields
			public string text; // 0x00
			public Action onConfirm; // 0x08
		}
	
		// Constructors
		public LoginAlertDialog() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnInit() {} // 0x000000018577D5DC-0x000000018577D6C0
		public void SetParams(FParams param) {} // 0x000000018577D6C0-0x000000018577D748
		private void _OnConfirmClicked(PointerEventData evt) {} // 0x000000018577D750-0x000000018577D7B4
		public void __iFixBaseProxy_OnInit() {} // 0x000000018577D748-0x000000018577D750
	}

	public class LoginDecorateUI : TickableUIMono, ILoginBinder<LoginViewModel>, ILoginContextReceiver // TypeDefIndex: 53248
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public LoginDecorateUI() {} // 0x0000000183C85980-0x0000000183C85A20
	
		// Methods
		public void OnLoginContext(LoginContext context) {} // 0x0000000182EA9EA0-0x0000000182EA9F50
		public void OnValueChanged(LoginViewModel value) {} // 0x0000000182C3B6B0-0x0000000182C3B860
		private void _TriggerTrans2GSLoginImpl() {} // 0x0000000183099310-0x0000000183099490
		private void _ToggleGlow(bool enable) {} // 0x0000000182C3BF30-0x0000000182C3C0A0
		private UIAnimationLayerMixPlayer _EnsureGlowPlayer() => default; // 0x0000000183099490-0x00000001830995A0
		public override void Tick(float deltaTime) {} // 0x0000000183099050-0x00000001830990E0
		protected override void OnRelease() {} // 0x00000001839A1360-0x00000001839A13E0
		private void _TimeManagerTick(float timeDelta) {} // 0x00000001830990E0-0x0000000183099310
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public class LoginEnterGamePanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 53249
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
		public LoginEnterGamePanel() {} // 0x0000000183CDE0E0-0x0000000183CDE0F0
	
		// Methods
		private void _InitIfNot() {} // 0x0000000183B5BDA0-0x0000000183B5BE70
		public void OnValueChanged(LoginViewModel value) {} // 0x0000000182C3BAB0-0x0000000182C3BBA0
		private void _OnEnterGameClicked(PointerEventData evt) {} // 0x0000000182D753B0-0x0000000182D75460
	}

	public class LoginGovTipsPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 53250
	{
		// Fields
		[SerializeField]
		private UIButton _btnOpen; // 0x28
	
		// Constructors
		public LoginGovTipsPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnInit() {} // 0x0000000183610530-0x0000000183610600
		public void OnValueChanged(LoginViewModel value) {} // 0x0000000182C3B3B0-0x0000000182C3B410
		private void _EventOnOpenAgeTipsClicked(PointerEventData _) {} // 0x000000018577D7C4-0x000000018577D82C
		public void __iFixBaseProxy_OnInit() {} // 0x000000018577D3E8-0x000000018577D3F0
	}

	public class LoginJudgeDialog : LoginController.Dialog // TypeDefIndex: 53253
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
		public enum Style // TypeDefIndex: 53251
		{
			Center = 0,
			Left = 1
		}
	
		public struct FParams // TypeDefIndex: 53252
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
		public LoginJudgeDialog() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnInit() {} // 0x000000018577D8C8-0x000000018577DA14
		public void SetParams(FParams param) {} // 0x000000018577DA14-0x000000018577DC58
		private void _OnPositiveClicked(PointerEventData evt) {} // 0x000000018577DCBC-0x000000018577DD20
		private void _OnNegativeClicked(PointerEventData evt) {} // 0x000000018577DC58-0x000000018577DCBC
		public void __iFixBaseProxy_OnInit() {} // 0x000000018577D748-0x000000018577D750
	}

	public class LoginMenuPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginViewModel> // TypeDefIndex: 53255
	{
		// Fields
		public const string CONTROLLER_STATE_NORMAL = "Normal"; // Metadata: 0x01FD3F96
		public const string CONTROLLER_STATE_SELECT = "Select"; // Metadata: 0x01FD3F9D
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
	
		// Constructors
		public LoginMenuPanel() {} // 0x0000000183CDE0F0-0x0000000183CDE110
	
		// Methods
		protected override void OnInit() {} // 0x0000000182D9D470-0x0000000182D9DB70
		public void OnValueChanged(LoginViewModel value) {} // 0x0000000182C3B0D0-0x0000000182C3B3B0
		public void InitBulletinAndRedAfterLoginSuc() {} // 0x0000000182EAA0E0-0x0000000182EAA1E0
		private static void _OnBulletinOpen() {} // 0x0000000183D42D10-0x0000000183D42D80
		private static void _OnBulletinClose() {} // 0x0000000183D2B470-0x0000000183D2B500
		private void Awake() {} // 0x0000000183C7EF60-0x0000000183C7F050
		private void OnEnable() {} // 0x00000001829749B0-0x0000000182974BB0
		private void OnDisable() {} // 0x0000000182974BB0-0x0000000182974DA0
		protected override void OnDestroy() {} // 0x0000000183C7AE80-0x0000000183C7AF70
		private void _OnAnnounceClicked(PointerEventData _) {} // 0x000000018577E224-0x000000018577E3BC
		private void _OnSettingClicked(PointerEventData _) {} // 0x000000018577EC58-0x000000018577ED44
		private void _OnResCheckClicked(PointerEventData _) {} // 0x000000018577EB24-0x000000018577EBEC
		private void _OnCustomServiceClicked(PointerEventData _) {} // 0x000000018577E45C-0x000000018577E50C
		private void _OnAccountCenterClicked(PointerEventData _) {} // 0x000000018577E15C-0x000000018577E224
		private void _OnLogoutClicked(PointerEventData _) {} // 0x000000018577E7A0-0x000000018577E868
		private void _OnQuitGameClicked(PointerEventData _) {} // 0x000000018577E918-0x000000018577EAB8
		private void _OnLoginClicked(PointerEventData _) {} // 0x000000018577E728-0x000000018577E7A0
		private void _OnQRClicked(PointerEventData _) {} // 0x000000018577E868-0x000000018577E918
		private void _OnRequestRelogin() {} // 0x000000018577EAB8-0x000000018577EB24
		private bool _CanQRLogin() => default; // 0x0000000183D276A0-0x0000000183D276D0
		private void _UpdateAnnounceRedDot() {} // 0x0000000182EAA1E0-0x0000000182EAA260
		private void _UpdateServerZone() {} // 0x0000000182D791F0-0x0000000182D792E0
		private void _OnServerZoneBtnClicked() {} // 0x000000018577EBEC-0x000000018577EC58
		private void _OnFocusMenuGroup(bool isFocused) {} // 0x000000018577E50C-0x000000018577E5FC
		private void _OnAnnounceClosed() {} // 0x000000018577E3BC-0x000000018577E45C
		private void _OnReceiveRedDotAndPopup(bool showRedDot) {} // 0x0000000182EAA260-0x0000000182EAA2F0
		private void _OnUpdateRedDotForSDKListener([IsReadOnly] in EventData<bool> show) {} // 0x00000001839DD5A0-0x00000001839DD5E0
		private void _OnInputChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input) {} // 0x000000018577E5FC-0x000000018577E728
		public void __iFixBaseProxy_OnInit() {} // 0x000000018577D3E8-0x000000018577D3F0
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018577E0C8-0x000000018577E0D0
	}

	public class LoginMockUIDPanel : MonoBehaviour // TypeDefIndex: 53258
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
		private static LoginMockUIDPanel s_instance; // 0x00
	
		// Properties
		public static LoginMockUIDPanel instance { get => default; } // 0x0000000185788EC0-0x0000000185788EF8 
	
		// Nested types
		public struct FOptions // TypeDefIndex: 53256
		{
			// Fields
			public string fixedUID; // 0x00
			public LoginContext context; // 0x08
	
			// Methods
			public bool IsUIDFixed() => default; // 0x0000000183159690-0x00000001831596D0
		}
	
		// Constructors
		public LoginMockUIDPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void LoginWithCallback(FOptions options, Action<string> callback) {} // 0x0000000183652EA0-0x0000000183652FD0
		public void Refresh() {} // 0x0000000185788CC8-0x0000000185788D18
		[IteratorStateMachine(typeof(_HideAndDestroy_d__21))]
		public IEnumerator HideAndDestroy() => default; // 0x0000000183652DC0-0x0000000183652E30
		private void _UpdateStatus() {} // 0x00000001831594C0-0x0000000183159690
		private void _InitLoginInfo() {} // 0x000000018315B0F0-0x000000018315B400
		private void _SaveConfig() {} // 0x000000018315B880-0x000000018315B900
		private void _OnBtnEnterGame() {} // 0x0000000183CB7FC0-0x0000000183CB8040
		private void _SmokeEnterGame(string serverName, string uid) {} // 0x0000000185788D6C-0x0000000185788E24
		private void _OnBtnDelLocalFile() {} // 0x0000000185788D28-0x0000000185788D6C
		private void _TryClosePanel() {} // 0x0000000185788E24-0x0000000185788EC0
		private void _OnSelectServer(int index) {} // 0x000000018315B790-0x000000018315B820
		private void OnDestroy() {} // 0x0000000183D1EE60-0x0000000183D1EEA0
	}

	public class LoginResourcePanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginHotUpdateModel> // TypeDefIndex: 53259
	{
		// Fields
		private const float PROGRESS_LERP_DURATION = 0.2f; // Metadata: 0x01FD3FA4
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
		public LoginResourcePanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void OnValueChanged(LoginHotUpdateModel value) {} // 0x0000000182C3D280-0x0000000182C3D330
		private void _UpdateResourceInfo() {} // 0x00000001832F1390-0x00000001832F1530
		private void Update() {} // 0x00000001832F1230-0x00000001832F1360
	}

	public class LoginRootPanel : MonoBehaviour // TypeDefIndex: 53261
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
		public abstract class ChildPanel : MonoBehaviour, ILoginContextReceiver // TypeDefIndex: 53260
		{
			// Properties
			protected UISwitchTween switchTween { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			protected LoginContext context { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
			// Constructors
			protected ChildPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
			// Methods
			public void OnLoginContext(LoginContext context) {} // 0x0000000182EA9480-0x0000000182EA94D0
			protected virtual void OnInit() {} // 0x0000000183610B70-0x0000000183610BA0
			protected virtual void OnDestroy() {} // 0x0000000182C3D440-0x0000000182C3D490
			protected void SetPanelVisibleByAnimSwitchTween(UIAnimationWrapper anim, bool isVisible, bool forceReset = false /* Metadata: 0x01FD3FA8 */) {} // 0x0000000185782DCC-0x0000000185782EC4
			protected void SetPanelVisibleByFadeSwitchTween(CanvasGroup canvasGroup, bool isVisible, bool forceReset = false /* Metadata: 0x01FD3FA9 */) {} // 0x0000000182C3B860-0x0000000182C3B950
		}
	
		// Constructors
		public LoginRootPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x0000000183197210-0x0000000183197310
		private void OnDestroy() {} // 0x0000000183197310-0x0000000183197400
		public void Init(LoginContext context) {} // 0x0000000182EA9240-0x0000000182EA9330
		private void _OnNotchPaddingChanged([IsReadOnly] in EventData<float> data) {} // 0x0000000185788F8C-0x0000000185789030
		private void _InitController() {} // 0x0000000182EA9F50-0x0000000182EAA010
		public void ToggleLoginBindingGroup(bool enable) {} // 0x0000000185788EF8-0x0000000185788F8C
		public void InitBulletinAndRedAfterLoginSuc() {} // 0x0000000182EA9BA0-0x0000000182EA9BE0
		private static void _InitChildPanel(ChildPanel childPanel, LoginContext context) {} // 0x0000000182EA9330-0x0000000182EA9480
	}

	public class LoginServerSelectItemView : MonoBehaviour // TypeDefIndex: 53263
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
		private const string DEFAULT_TEXT = "--"; // Metadata: 0x01FD3FAA
		private static readonly DelayInfo DEFAULT_SPEED_INFO; // 0x10
		private ServerZoneManager.ServerZoneData m_serverItem; // 0x50
		private LoginContext m_context; // 0x58
		private List<DelayInfo> m_speedInfos; // 0x60
	
		// Nested types
		private struct DelayInfo // TypeDefIndex: 53262
		{
			// Fields
			public UnityEngine.Color color; // 0x00
			public int colorCount; // 0x10
			public int delayMax; // 0x14
			public string text; // 0x18
		}
	
		// Constructors
		public LoginServerSelectItemView() {} // 0x00000001836D52B0-0x00000001836D55C0
		static LoginServerSelectItemView() {} // 0x0000000183C8A1C0-0x0000000183C8A290
	
		// Methods
		public void RefreshView(LoginContext context, ServerZoneManager.ServerZoneData serverItem, bool isSelected) {} // 0x00000001857890C0-0x00000001857895C0
		public void NaviToBtnTarget() {} // 0x0000000185789030-0x00000001857890C0
		public void SetSelected(bool isSelected) {} // 0x00000001857895C0-0x0000000185789664
		private void _OnClicked(PointerEventData _) {} // 0x0000000185789664-0x00000001857896DC
	}

	public class LoginServerSelectProp : LoginProperty<LoginServerSelectModel> // TypeDefIndex: 53264
	{
		// Constructors
		public LoginServerSelectProp() {} // Dummy constructor
		public LoginServerSelectProp(LoginWorkFlow workflow) {} // 0x00000001828D45F0-0x00000001828D4640
	}

	public class LoginServerItem // TypeDefIndex: 53265
	{
		// Fields
		public ServerZoneManager.ServerZoneData serverZoneData; // 0x10
	
		// Constructors
		public LoginServerItem() {} // 0x000000018350B670-0x000000018350B680
	}

	public class LoginServerSelectModel // TypeDefIndex: 53266
	{
		// Fields
		public bool showPanel; // 0x10
		public int selectedIndex; // 0x14
	
		// Properties
		public List<ServerZoneManager.ServerZoneData> serverList { get => default; } // 0x0000000185789910-0x00000001857899A4 
		public ServerZoneManager.ServerZoneData curServerZoneData { get => default; } // 0x00000001857898B8-0x0000000185789910 
	
		// Constructors
		public LoginServerSelectModel() {} // 0x0000000183D55820-0x0000000183D55830
	
		// Methods
		public void InitData() {} // 0x0000000185789760-0x00000001857897C8
		public ServerZoneManager.ServerZoneData GetSelectedServer() => default; // 0x00000001857896DC-0x0000000185789760
		public bool UpdateSelectedServer(ServerZoneManager.ServerZoneData selectedServer) => default; // 0x00000001857897C8-0x00000001857898B8
	}

	public class LoginServerSelectPanel : LoginRootPanel.ChildPanel, ILoginBinder<LoginServerSelectModel> // TypeDefIndex: 53269
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
	
		// Constructors
		public LoginServerSelectPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnInit() {} // 0x0000000183610600-0x0000000183610890
		private void OnDisable() {} // 0x00000001857899A4-0x0000000185789AA8
		private void OnEnable() {} // 0x0000000185789AA8-0x000000018578A4CC
		[IteratorStateMachine(typeof(__WaitingForShowListAwake_d__11))]
		private IEnumerator _WaitingForShowListAwake() => default; // 0x000000018578AA8C-0x000000018578AB1C
		private void _UpdateServerCell(GameObject cell, int index) {} // 0x000000018578A8C0-0x000000018578A9CC
		private void _UpdateServerSelected(int index, GameObject cell) {} // 0x000000018578A9CC-0x000000018578AA8C
		public void OnValueChanged(LoginServerSelectModel value) {} // 0x000000018578A4CC-0x000000018578A624
		private void _NaviToSelectedItem() {} // 0x000000018578A624-0x000000018578A76C
		private void _OnInputChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> input) {} // 0x000000018578A85C-0x000000018578A8C0
		private void _OnCloseClicked(PointerEventData _) {} // 0x000000018578A76C-0x000000018578A7E4
		private void _OnConfirmClicked(PointerEventData _) {} // 0x000000018578A7E4-0x000000018578A85C
		public void __iFixBaseProxy_OnInit() {} // 0x000000018577D3E8-0x000000018577D3F0
	}

	public class LoginVersionPanel : MonoBehaviour // TypeDefIndex: 53270
	{
		// Fields
		[SerializeField]
		private UIText _textVersion; // 0x18
	
		// Properties
		public string displayGameVersion { get => default; } // 0x000000018386CE50-0x000000018386CFF0 
		private string versionZoneType { get => default; } // 0x000000018386D110-0x000000018386D160 
		private string versionPlatform { get => default; } // 0x000000018386D020-0x000000018386D050 
		private string versionAppType { get => default; } // 0x000000018386CFF0-0x000000018386D020 
		private string versionVersionNum { get => default; } // 0x000000018386D090-0x000000018386D0D0 
		private string versionProjectCL { get => default; } // 0x000000018386D050-0x000000018386D090 
	
		// Constructors
		public LoginVersionPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Start() {} // 0x000000018386CDB0-0x000000018386CE50
	}

	public class LoginVocResSelDialog : LoginController.Dialog // TypeDefIndex: 53273
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
		public struct FParams // TypeDefIndex: 53271
		{
			// Fields
			public Action onConfirm; // 0x00
		}
	
		public class VocResInfo // TypeDefIndex: 53272
		{
			// Fields
			public string nameTextId; // 0x10
			public EVFSBlockType type; // 0x18
	
			// Constructors
			public VocResInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public LoginVocResSelDialog() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnInit() {} // 0x000000018578AD28-0x000000018578B0A8
		private void OnEnable() {} // 0x000000018578AC20-0x000000018578AD28
		private void OnDisable() {} // 0x000000018578AB1C-0x000000018578AC20
		public void SetParams(FParams param) {} // 0x000000018578B0A8-0x000000018578B10C
		public void UpdateSelected(EVFSBlockType type) {} // 0x000000018578B10C-0x000000018578B200
		private void _UpdateList() {} // 0x000000018578B6B0-0x000000018578B770
		private void _UpdateSelected(int index, GameObject cell) {} // 0x000000018578B770-0x000000018578B820
		private void _UpdateCell(GameObject cell, int index) {} // 0x000000018578B5D0-0x000000018578B6B0
		[IDTag(1)]
		private void _OnConfirmClicked(PointerEventData evt) {} // 0x000000018578B4B8-0x000000018578B56C
		[IDTag(0)]
		private void _OnConfirmClicked() {} // 0x000000018578B330-0x000000018578B4B8
		private void _OnInputTypeChanged([IsReadOnly] in EventData<Beyond.DeviceInfo.InputType> data) {} // 0x000000018578B56C-0x000000018578B5D0
		private void _NaviToSelectedItem() {} // 0x000000018578B200-0x000000018578B330
		public void __iFixBaseProxy_OnInit() {} // 0x000000018577D748-0x000000018577D750
	}

	public class LoginVocResSelItemView : MonoBehaviour // TypeDefIndex: 53274
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
		private const double MB = 1048576; // Metadata: 0x01FD3FAD
	
		// Constructors
		public LoginVocResSelItemView() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void RefreshView(LoginVocResSelDialog context, LoginVocResSelDialog.VocResInfo info, bool isSelected) {} // 0x000000018578B8B0-0x000000018578BB98
		public void NaviToBtnTarget() {} // 0x000000018578B820-0x000000018578B8B0
		public void SetSelected(bool isSelected) {} // 0x000000018578BB98-0x000000018578BC3C
		private void _OnClicked(PointerEventData _) {} // 0x000000018578BC3C-0x000000018578BCB0
	}
}

namespace Beyond.Scripts.Entry
{
	public static class GameSettingSetter // TypeDefIndex: 53277
	{
		// Fields
		public static bool s_stageInitFinished; // 0xF8
	
		// Properties
		public static GameSettingSetterItem<float> audioGlobalVolume { get; private set; } // 0x00000001857831D8-0x0000000185783210 0x0000000185783914-0x0000000185783964
		public static GameSettingSetterItem<float> audioMusicVolume { get; private set; } // 0x0000000185783210-0x0000000185783248 0x0000000185783964-0x00000001857839B8
		public static GameSettingSetterItem<float> audioVoiceVolume { get; private set; } // 0x0000000185783328-0x0000000185783360 0x0000000185783B08-0x0000000185783B5C
		public static GameSettingSetterItem<float> audioSfxVolume { get; private set; } // 0x0000000185783248-0x0000000185783280 0x00000001857839B8-0x0000000185783A0C
		public static GameSettingSetterItem<bool> audioSuspendUnfocused { get; private set; } // 0x00000001857832F0-0x0000000185783328 0x0000000185783AB4-0x0000000185783B08
		public static GameSettingSetterItem<bool> audioBackgroundMusic { get; private set; } // 0x0000000185783168-0x00000001857831A0 0x000000018578386C-0x00000001857838C0
		public static GameSettingSetterItem<GameSetting.GameSettingAudioSuiteMode> audioSuiteMode { get; private set; } // 0x00000001857832B8-0x00000001857832F0 0x0000000185783A60-0x0000000185783AB4
		public static GameSettingSetterItem<bool> audioController { get; private set; } // 0x00000001857831A0-0x00000001857831D8 0x00000001857838C0-0x0000000185783914
		public static GameSettingSetterItem<bool> audioSpatial { get; private set; } // 0x0000000185783280-0x00000001857832B8 0x0000000185783A0C-0x0000000185783A60
		public static GameSettingSetterItem<float> controllerCameraSpeedX { get; private set; } // 0x00000001857834F8-0x0000000185783530 0x0000000185783DC4-0x0000000185783E18
		public static GameSettingSetterItem<float> controllerCameraSpeedY { get; private set; } // 0x0000000185783530-0x0000000185783568 0x0000000185783E18-0x0000000185783E6C
		public static GameSettingSetterItem<float> controllerCameraTopViewSpeed { get; private set; } // 0x0000000185783568-0x00000001857835A0 0x0000000185783E6C-0x0000000185783EC0
		public static GameSettingSetterItem<float> controllerWalkRunRatio { get; private set; } // 0x0000000185783618-0x0000000185783650 0x0000000185783F78-0x0000000185783FCC
		public static GameSettingSetterItem<float> cameraDistanceLevel { get; private set; } // 0x0000000185783360-0x0000000185783398 0x0000000185783B5C-0x0000000185783BB0
		public static GameSettingSetterItem<GameSetting.CameraImpulseLevel> cameraImpulseLevel { get; private set; } // 0x0000000185783398-0x00000001857833D0 0x0000000185783BB0-0x0000000185783C04
		public static GameSettingSetterItem<bool> controllerCameraReverseX { get; private set; } // 0x0000000185783484-0x00000001857834BC 0x0000000185783D18-0x0000000185783D6C
		public static GameSettingSetterItem<bool> controllerCameraReverseY { get; private set; } // 0x00000001857834BC-0x00000001857834F8 0x0000000185783D6C-0x0000000185783DC4
		public static GameSettingSetterItem<GameSetting.GameSettingControllerAutoLockTarget> controllerAutoLockTarget { get; private set; } // 0x000000018578340C-0x0000000185783448 0x0000000185783C60-0x0000000185783CBC
		public static GameSettingSetterItem<GameSetting.ComboSkillCameraAlpha> comboSkillCameraAlpha { get; private set; } // 0x00000001857833D0-0x000000018578340C 0x0000000185783C04-0x0000000185783C60
		public static GameSettingSetterItem<bool> controllerAutoSprint { get; private set; } // 0x0000000185783448-0x0000000185783484 0x0000000185783CBC-0x0000000185783D18
		public static GameSettingSetterItem<bool> controllerMotion { get; private set; } // 0x00000001857835A0-0x00000001857835DC 0x0000000185783EC0-0x0000000185783F1C
		public static GameSettingSetterItem<bool> controllerTriggerEffect { get; private set; } // 0x00000001857835DC-0x0000000185783618 0x0000000185783F1C-0x0000000185783F78
		public static GameSettingSetterItem<bool> enableAutoAttackTouch { get; private set; } // 0x000000018578368C-0x00000001857836C8 0x0000000185784028-0x0000000185784084
		public static GameSettingSetterItem<bool> enableAutoAttackGamepad { get; private set; } // 0x0000000185783650-0x000000018578368C 0x0000000185783FCC-0x0000000185784028
		public static GameSettingSetterItem<EnvLang> languageText { get; private set; } // 0x00000001857837F4-0x0000000185783830 0x0000000185784250-0x00000001857842AC
		public static GameSettingSetterItem<GameSetting.GameSettingLanguageAudio> languageAudio { get; private set; } // 0x00000001857837B8-0x00000001857837F4 0x00000001857841F4-0x0000000185784250
		public static GameSettingSetterItem<GameSetting.GameSettingVideoQuality> graphicsQuality { get; private set; } // 0x0000000185783740-0x000000018578377C 0x000000018578413C-0x0000000185784198
		public static GameSettingSetterItem<bool> graphicsFullScreen { get; private set; } // 0x00000001857836C8-0x0000000185783704 0x0000000185784084-0x00000001857840E0
		public static GameSettingSetterItem<int, int> graphicsResolution { get; private set; } // 0x000000018578377C-0x00000001857837B8 0x0000000185784198-0x00000001857841F4
		public static GameSettingSetterItem<float> graphicsNotchPadding { get; private set; } // 0x0000000185783704-0x0000000185783740 0x00000001857840E0-0x000000018578413C
		public static GameSettingSetterItem<bool> otherShowSmartAlert { get; private set; } // 0x0000000185783830-0x000000018578386C 0x00000001857842AC-0x0000000185784308
	
		// Nested types
		public class GameSettingSetterItem<T> // TypeDefIndex: 53275
		{
			// Fields
			private readonly string m_settingId;
			private readonly Action<T> m_otherSystemSet;
	
			// Constructors
			public GameSettingSetterItem() {} // Dummy constructor
			public GameSettingSetterItem(string settingId) {}
			public GameSettingSetterItem(string settingId, Action<T> otherSystemSet) {}
	
			// Methods
			public void Set(T value, bool forceSetOtherSystem = false /* Metadata: 0x01FD3FB5 */) {}
		}
	
		public class GameSettingSetterItem<T1, T2> // TypeDefIndex: 53276
		{
			// Fields
			private readonly string m_mainSettingId;
			private readonly string m_settingId1;
			private readonly string m_settingId2;
			private readonly Action<T1, T2> m_otherSystemSet;
	
			// Constructors
			public GameSettingSetterItem() {} // Dummy constructor
			public GameSettingSetterItem(string mainSettingId, string settingId1, string settingId2, Action<T1, T2> otherSystemSet) {}
	
			// Methods
			public void Set(T1 value1, T2 value2, bool forceSetOtherSystem = false /* Metadata: 0x01FD3FB6 */) {}
		}
	
		// Methods
		public static void InitSetterItems() {} // 0x0000000182DF66E0-0x0000000182DF7F90
		private static void _OnAudioGlobalVolumeChange(float volume) {} // 0x00000001838BF640-0x00000001838BF6B0
		private static void _OnAudioMusicVolumeChange(float volume) {} // 0x00000001838BF5D0-0x00000001838BF640
		private static void _OnAudioVoiceVolumeChange(float volume) {} // 0x00000001838BF560-0x00000001838BF5D0
		private static void _OnAudioSfxVolumeChange(float volume) {} // 0x0000000183D06600-0x0000000183D06670
		private static void _OnAudioSuspendUnfocusedChange(bool suspendUnfocused) {} // 0x0000000183CB7310-0x0000000183CB73A0
		private static void _OnAudioBackgroundMusicChange(bool enable) {} // 0x0000000185782EC4-0x0000000185782F14
		private static void _OnAudioSuiteModeChange(GameSetting.GameSettingAudioSuiteMode mode) {} // 0x0000000182EA2F10-0x0000000182EA2FA0
		private static void _OnAudioControllerChange(bool enable) {} // 0x0000000182A01010-0x0000000182A01090
		private static void _OnAudioSpatialAudioChange(bool enable) {} // 0x0000000182A00FA0-0x0000000182A01010
		private static void _OnControllerCameraSpeedXChange(float cameraSpeed) {} // 0x00000001838BF490-0x00000001838BF560
		private static void _OnControllerCameraSpeedYChange(float cameraSpeed) {} // 0x00000001838BF3C0-0x00000001838BF490
		private static void _OnControllerCameraTopViewSpeedChange(float cameraSpeed) {} // 0x0000000183CDCF60-0x0000000183CDD030
		private static void _OnControllerWalkRunRatioChange(float walkRunRatio) {} // 0x00000001838BF2F0-0x00000001838BF3C0
		private static void _OnCameraDistanceLevelChange(float distance) {} // 0x0000000183C7F390-0x0000000183C7F4A0
		private static void _OnCameraImpulseLevelChange(GameSetting.CameraImpulseLevel level) {} // 0x0000000182952D20-0x0000000182952DC0
		private static void _OnControllerCameraReverseXChange(bool isReverse) {} // 0x0000000182A01390-0x0000000182A01430
		private static void _OnControllerCameraReverseYChange(bool isReverse) {} // 0x0000000182A012F0-0x0000000182A01390
		private static void _OnControllerAutoLockTargetChange(GameSetting.GameSettingControllerAutoLockTarget mode) {} // 0x0000000182952C80-0x0000000182952D20
		private static void _OnComboSkillCameraAlphaChange(GameSetting.ComboSkillCameraAlpha alpha) {} // 0x0000000182952BE0-0x0000000182952C80
		private static void _OnControllerAutoSprintChange(bool valid) {} // 0x0000000185782F14-0x0000000185782FBC
		private static void _OnControllerMotionChange(bool valid) {} // 0x0000000182A014D0-0x0000000182A015E0
		private static void _OnControllerTriggerEffectChange(bool enable) {} // 0x0000000182A01250-0x0000000182A012F0
		private static void _OnEnableAutoAttackTouchChange(bool enable) {} // 0x0000000185782FBC-0x0000000185783064
		private static void _OnEnableAutoAttackGamepadChange(bool enable) {} // 0x0000000182A011B0-0x0000000182A01250
		private static void _OnLanguageTextChange(EnvLang language) {} // 0x0000000182954590-0x0000000182954750
		private static void _OnLanguageAudioChange(GameSetting.GameSettingLanguageAudio language) {} // 0x0000000182952DC0-0x0000000182952EE0
		private static void _OnGraphicsQualityChange(GameSetting.GameSettingVideoQuality quality) {} // 0x00000001857830EC-0x0000000185783168
		private static void _OnGraphicsFullScreenChanged(bool fullScreen) {} // 0x0000000185783064-0x00000001857830EC
		private static void _OnGraphicsResolutionChange(int width, int height) {} // 0x00000001836366C0-0x0000000183636C20
		private static void _SetResolution(int width, int height, bool fullScreen) {} // 0x0000000183637410-0x00000001836375E0
		private static void _OnGraphicsNotchPaddingChange(float notchPadding) {} // 0x0000000182E3B730-0x0000000182E3B840
		private static void _OnOtherShowSmartAlertChange(bool show) {} // 0x0000000182A01110-0x0000000182A011B0
	}

	public class WarmUpProgress : LoginHotUpdateModel.IProgress // TypeDefIndex: 53278
	{
		// Constructors
		public WarmUpProgress() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public double GetTotal() => default; // 0x000000018578C380-0x000000018578C408
		public double GetCurrent() => default; // 0x000000018578C284-0x000000018578C314
		public string GetInfo() => default; // 0x000000018578C314-0x000000018578C380
	}
}

namespace Beyond.SDK
{
	public class PlatformFont : IPlatformFont // TypeDefIndex: 53086
	{
		// Fields
		private const int DEFAULT_FONT_ID = -430371804; // Metadata: 0x01FD3D5D
	
		// Constructors
		public PlatformFont() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public TMP_FontAsset GetFont() => default; // 0x000000018576EBF0-0x000000018576EC6C
	}

	public static class SDKNetUtils // TypeDefIndex: 53095
	{
		// Fields
		public const string CONTENT_TYPE_JSON = "application/json"; // Metadata: 0x01FD3D62
		private const int GENERAL_TIMEOUT = 30; // Metadata: 0x01FD3D73
		private static HTTPImpl s_HTTPImpl; // 0x00
	
		// Nested types
		public struct HttpPostRequest // TypeDefIndex: 53087
		{
			// Fields
			public string url; // 0x00
			public string param; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> header; // 0x18
			public Action<WebHttpResponse> callback; // 0x20
		}
	
		public struct HttpGetRequest // TypeDefIndex: 53088
		{
			// Fields
			public string url; // 0x00
			public Action<WebHttpResponse> callback; // 0x08
		}
	
		public struct WebHttpResponse // TypeDefIndex: 53089
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
	
		private enum HTTPOptType // TypeDefIndex: 53090
		{
			GET = 0,
			POST = 1
		}
	
		private struct HTTPConfig // TypeDefIndex: 53091
		{
			// Fields
			public string url; // 0x00
			public string body; // 0x08
			public string contentType; // 0x10
			public Dictionary<string, string> header; // 0x18
			public HTTPOptType optType; // 0x20
			public Action<WebHttpResponse> callback; // 0x28
		}
	
		private abstract class HTTPImpl // TypeDefIndex: 53092
		{
			// Constructors
			protected HTTPImpl() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public abstract IEnumerator DoHTTP(HTTPConfig config);
		}
	
		private class BeyondHttp : HTTPImpl // TypeDefIndex: 53094
		{
			// Constructors
			public BeyondHttp() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			[IteratorStateMachine(typeof(_DoHTTP_d__0))]
			public override IEnumerator DoHTTP(HTTPConfig config) => default; // 0x000000018576C290-0x000000018576C358
		}
	
		// Constructors
		static SDKNetUtils() {} // 0x000000018576EFB0-0x000000018576F020
	
		// Methods
		public static void HTTPPost(HttpPostRequest request) {} // 0x000000018576EDC4-0x000000018576EFB0
		public static void HTTPGet(HttpGetRequest request) {} // 0x000000018576EC6C-0x000000018576EDC4
	}

	public static class SDKTextDefines // TypeDefIndex: 53096
	{
		// Fields
		public const string CS_SDK_STO_DESC = "CS_SDK_STO_DESC"; // Metadata: 0x01FD3D76
		public const string CS_SDK_COMMON_ERROR = "CS_SDK_COMMON_ERROR"; // Metadata: 0x01FD3D86
		public const string CS_SDK_CREATE_ORDER_ERROR = "CS_SDK_CREATE_ORDER_ERROR"; // Metadata: 0x01FD3D9A
		public const string CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT = "CS_SDK_CREATE_ORDER_ERROR_LIMIT_COUNT"; // Metadata: 0x01FD3DB4
		public const string CS_SDK_USR_BAN = "CS_SDK_USR_BAN"; // Metadata: 0x01FD3DDA
		public const string CS_SDK_USR_BAN_TIME = "CS_SDK_USR_BAN_TIME"; // Metadata: 0x01FD3DE9
		public const string CS_SDK_LOGIN_FORBID = "CS_SDK_LOGIN_FORBID"; // Metadata: 0x01FD3DFD
		public const string CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT = "CS_SDK_CREATE_ORDER_ERROR_NETWORK_TIMEOUT"; // Metadata: 0x01FD3E11
		public const string CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR = "CS_SDK_CREATE_ORDER_ERROR_NETWORK_ERROR"; // Metadata: 0x01FD3E3B
		public const string CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID = "CS_SDK_CREATE_ORDER_ERROR_TOKEN_INVALID"; // Metadata: 0x01FD3E63
	}
}

namespace Beyond.SDK.Impl
{
	public class U8ExternalTools : SDKExternalToolsShortcut // TypeDefIndex: 53104
	{
		// Fields
		private static bool s_inited; // 0x00
		private static bool s_initing; // 0x01
		private static bool s_needRetry; // 0x02
		private static bool s_needQuitGame; // 0x03
		private static FHGSDKInit s_initHGSDK; // 0x04
	
		// Nested types
		private struct FHGSDKInit // TypeDefIndex: 53097
		{
			// Fields
			public bool isIniting; // 0x00
			public bool isInited; // 0x01
		}
	
		private class CaptchaHandler : SDKCaptchaHandler // TypeDefIndex: 53099
		{
			// Fields
			private const int FAILED = 1000; // Metadata: 0x01FD3E8B
			private long m_flag; // 0x10
			private string m_desc; // 0x18
	
			// Constructors
			public CaptchaHandler() {} // 0x0000000183D55790-0x0000000183D557A0
	
			// Methods
			[IteratorStateMachine(typeof(_FetchCaptchaCoroutine_d__3))]
			public override IEnumerator FetchCaptchaCoroutine(string captchaParams, Result outResult) => default; // 0x000000018577288C-0x0000000185772954
			public void OnGT3Message(Dictionary<string, object> msg) {} // 0x0000000185772954-0x0000000185772A48
		}
	
		// Constructors
		public U8ExternalTools() {} // 0x0000000183D42B70-0x0000000183D42B80
	
		// Methods
		public static bool IsInited() => default; // 0x0000000185770CB8-0x0000000185770D24
		public static bool NeedRetryInit() => default; // 0x0000000182D77A20-0x0000000182D77A70
		public static bool NeedQuitGame() => default; // 0x0000000183A94040-0x0000000183A94090
		public static void RetryInitSDKSystem(string env) {} // 0x0000000185771098-0x0000000185771138
		public static void PublicSetGameVersion(string version) {} // 0x0000000183CF20E0-0x0000000183CF2160
		public static void InitSDKSystem(string env) {} // 0x00000001838E3210-0x00000001838E3530
		[IteratorStateMachine(typeof(_WaitForInited_d__10))]
		public static IEnumerator WaitForInited() => default; // 0x0000000183A93FE0-0x0000000183A94040
		public static void InitHGSDK(string env) {} // 0x0000000182D78AA0-0x0000000182D78C10
		public static bool IsHGSDKInited() => default; // 0x0000000185770C4C-0x0000000185770CB8
		[IteratorStateMachine(typeof(_WaitForInitHGSDK_d__15))]
		public static IEnumerator WaitForInitHGSDK() => default; // 0x0000000182954F30-0x0000000182954F90
		protected override void Log(string content) {} // 0x0000000185770E04-0x0000000185770E58
		protected override void LogError(string content) {} // 0x0000000185770D24-0x0000000185770DB0
		protected override void LogWarning(string content) {} // 0x0000000185770DB0-0x0000000185770E04
		protected override string GetSignKey() => default; // 0x0000000185770BE0-0x0000000185770C4C
		public override Dictionary<string, string> GetDeviceIDs() => default; // 0x0000000185770874-0x00000001857709A8
		public void SetSubChannel(string subChannel) {} // 0x0000000185771138-0x000000018577119C
		protected override int GetPlatformKey() => default; // 0x0000000185770B68-0x0000000185770BE0
		public override void OnSDKExtraInfo(string jsonData) {} // 0x00000001826922A0-0x0000000182692330
		protected override string U8RootUrl() => default; // 0x00000001857711A4-0x0000000185771234
		protected override void POSTImplementation(POSTRequest request, Action<POSTResult> callback) {} // 0x0000000185770E58-0x0000000185771098
		private static POSTResult _ConvertToPOSTResult(SDKNetUtils.WebHttpResponse response) => default; // 0x0000000185771234-0x0000000185771338
		private void _ProcessExtraInfo(SDKExtraData extraData) {} // 0x0000000182692800-0x0000000182692BF0
		private static void _OnRequestExitGame() {} // 0x0000000185771720-0x00000001857717BC
		private static void _OnFakeAccountCenter() {} // 0x00000001857716E0-0x0000000185771720
		protected override SDKCaptchaHandler CreateCaptchaHandler() => default; // 0x00000001857707F8-0x0000000185770874
		protected override string GetErrorMessage(ErrMsgMeta meta) => default; // 0x00000001857709A8-0x0000000185770B68
		private bool _ErrorMsg_GET_TOKEN(ErrMsgMeta meta, out string errorMsg) {
			errorMsg = default;
			return default;
		} // 0x00000001857714D8-0x00000001857716E0
		private bool _ErrorMsg_CREATE_ORDER(ErrMsgMeta meta, out string errorMsg) {
			errorMsg = default;
			return default;
		} // 0x0000000185771338-0x00000001857714D8
		public string __iFixBaseProxy_GetSignKey() => default; // 0x0000000181002730-0x0000000181002740
		public Dictionary<string, string> __iFixBaseProxy_GetDeviceIDs() => default; // 0x000000018577119C-0x00000001857711A4
		public void __iFixBaseProxy_OnSDKExtraInfo(string P0) {} // 0x000000018350B670-0x000000018350B680
	}

	public class U8Plugin : IExternalPlugin // TypeDefIndex: 53107
	{
		// Constructors
		public U8Plugin() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public string GetPayAddition() => default; // 0x000000018577B938-0x000000018577B984
		public string GetSDKToken() => default; // 0x000000018577B984-0x000000018577B9D0
		public string GetSDKUid() => default; // 0x000000018577B9D0-0x000000018577BA1C
		public void Init() {} // 0x00000001839CAD40-0x00000001839CAD70
		public void Login(ExternalPluginLoginParams args) {} // 0x0000000182D775D0-0x0000000182D776A0
		public void Logout(ExternalPluginLogoutParams args) {} // 0x000000018577BA1C-0x000000018577BAA4
		public void OnProductListChanged(List<U8ProductInfo> productList) {} // 0x000000018577BAA4-0x000000018577BAF8
		public void Pay(ExternalPluginPayParams args) {} // 0x000000018577BAF8-0x000000018577BCDC
		public bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta) {
			meta = default;
			return default;
		} // 0x000000018577BCDC-0x000000018577BDF4
		private static bool _UseMockVersion() => default; // 0x0000000182D776A0-0x0000000182D77700
		private void _MockLogin(ExternalPluginLoginParams args) {} // 0x0000000182EA87D0-0x0000000182EA88F0
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 53074
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 53075
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 53076
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 53077
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 53078
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Beyond.UI
{
	public class SplashController : MonoBehaviour // TypeDefIndex: 53085
	{
		// Fields
		private const string CURSOR_KEY_SPLASH = "SplashController"; // Metadata: 0x01FD3D45
		private const string SPLASH_RESOURCES_PATH = "Splash"; // Metadata: 0x01FD3D56
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
	
		// Properties
		public static SplashController instance { get; private set; } // 0x000000018576F020-0x000000018576F058 0x000000018576F090-0x000000018576F0E4
		public static bool isPlaying { get => default; } // 0x000000018576F058-0x000000018576F090 
	
		// Nested types
		[Serializable]
		private struct SplashConfig // TypeDefIndex: 53079
		{
			// Fields
			public Sprite sprite; // 0x00
			public bool blackCoverFadeOut; // 0x08
		}
	
		[Serializable]
		private struct SplashConfigOverride // TypeDefIndex: 53080
		{
			// Fields
			public EnvLang envLang; // 0x00
			public SplashConfig[] splashConfigs; // 0x08
		}
	
		[Serializable]
		private struct SplashConfigs // TypeDefIndex: 53081
		{
			// Fields
			public SplashConfig[] splashConfigs; // 0x00
			public SplashConfig[] splashConfigsVNMobile; // 0x08
			public SplashConfigOverride[] i18nSplashConfigOverrides; // 0x10
		}
	
		// Constructors
		public SplashController() {} // 0x0000000183D2D710-0x0000000183D2D730
	
		// Methods
		public static SplashController Show(Action onComplete = null, bool skipLicense = false /* Metadata: 0x01FD3D44 */) => default; // 0x000000018229EA10-0x000000018229EC90
		public static void Hide() {} // 0x000000018229E930-0x000000018229EA10
		public static void CanFinished() {} // 0x000000018229E8A0-0x000000018229E930
		private void Awake() {} // 0x000000018229E570-0x000000018229E600
		private void OnDestroy() {} // 0x000000018229E600-0x000000018229E690
		private void _Play(Action onComplete, bool skipLicense) {} // 0x0000000182EA8B00-0x0000000182EA8C10
		private void _Stop() {} // 0x0000000183C81D30-0x0000000183C81DA0
		private SplashConfig[] _GetSplashConfigs() => default; // 0x0000000182EA8C10-0x0000000182EA8D10
		private void _DoStartSplash(SplashConfig[] splashConfigs) {} // 0x0000000182D4CE30-0x0000000182D4D170
		private void _OnTweenFinished() {} // 0x0000000183C7D880-0x0000000183C7D8E0
		[IteratorStateMachine(typeof(__OnSplashCompleteCoroutine_d__33))]
		private IEnumerator _OnSplashCompleteCoroutine() => default; // 0x0000000183C7D8E0-0x0000000183C7DA10
		[IteratorStateMachine(typeof(__StartLicenseCoroutine_d__34))]
		private IEnumerator _StartLicenseCoroutine() => default; // 0x000000018229E510-0x000000018229E570
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 53007
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 53281
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05E20-0x0000000183D05E90
	
		// Methods
		public void __Gen_Wrap_0(object P0, GameState P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_1(float P0) {} // 0x0000000185784998-0x0000000185784A58
		public void __Gen_Wrap_2(bool P0) {} // 0x000000018514F660-0x000000018514F720
		public void __Gen_Wrap_3(GameSetting.GameSettingAudioSuiteMode P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public void __Gen_Wrap_4(GameSetting.CameraImpulseLevel P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public void __Gen_Wrap_5(GameSetting.GameSettingControllerAutoLockTarget P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public void __Gen_Wrap_6(GameSetting.ComboSkillCameraAlpha P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public void __Gen_Wrap_7(EnvLang P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public void __Gen_Wrap_8(GameSetting.GameSettingLanguageAudio P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public void __Gen_Wrap_9(GameSetting.GameSettingVideoQuality P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public void __Gen_Wrap_10(int P0, int P1, bool P2) {} // 0x0000000185784400-0x00000001857844F8
		public void __Gen_Wrap_11(int P0, int P1) {} // 0x00000001856458FC-0x00000001856459D4
		public void __Gen_Wrap_12() {} // 0x00000001850F3444-0x00000001850F34E0
		public void __Gen_Wrap_13(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public SplashController.SplashConfig[] __Gen_Wrap_14(object P0) => default; // 0x00000001857844F8-0x00000001857845D4
		public IEnumerator __Gen_Wrap_15(object P0) => default; // 0x00000001857845D4-0x00000001857846C4
		public void __Gen_Wrap_16(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public void __Gen_Wrap_17(object P0, object P1, bool P2) {} // 0x00000001857846C4-0x00000001857847A8
		public SplashController __Gen_Wrap_18(object P0, bool P1) => default; // 0x00000001857847A8-0x00000001857848A0
		public void __Gen_Wrap_19(in EventData<bool, bool> P0) {} // 0x00000001857848A0-0x0000000185784998
		public void __Gen_Wrap_20(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public void __Gen_Wrap_21(int P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public bool __Gen_Wrap_22(object P0, out LocalResPref P1, out VirtualFileSystem.BlockValidator P2) {
			P1 = default;
			P2 = default;
			return default;
		} // 0x0000000185784A58-0x0000000185784BE0
		public void __Gen_Wrap_23(object P0, out VirtualFileSystem.BlockValidator P1) {
			P1 = default;
		} // 0x0000000185784BE0-0x0000000185784D08
		public bool __Gen_Wrap_24() => default; // 0x000000018514F380-0x000000018514F42C
		public bool __Gen_Wrap_25(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public void __Gen_Wrap_26(object P0, in EventData<Beyond.DeviceInfo.InputType> P1) {} // 0x0000000185784D08-0x0000000185784E1C
		public LoginController.MaskCtrl __Gen_Wrap_27(object P0) => default; // 0x0000000185784E1C-0x0000000185784F0C
		public UISwitchTween __Gen_Wrap_28(object P0, int P1) => default; // 0x0000000185784F0C-0x0000000185785018
		public IEnumerator __Gen_Wrap_29(object P0, object P1) => default; // 0x0000000185785018-0x0000000185785124
		public void __Gen_Wrap_30(object P0, object P1, LoginController.EMaskType P2, bool P3, bool P4) {} // 0x0000000185785124-0x0000000185785238
		public UIAnimationLayerMixPlayer __Gen_Wrap_31(object P0) => default; // 0x0000000185785238-0x0000000185785328
		public void __Gen_Wrap_32(object P0, LoginController.FOptions P1) {} // 0x0000000185785328-0x0000000185785438
		public LoginWorkFlow.FWork __Gen_Wrap_33() => default; // 0x0000000185785438-0x000000018578552C
		public bool __Gen_Wrap_34(LoginWorkFlow.ENode P0, LoginWorkFlow.ENode P1) => default; // 0x000000018560DC74-0x000000018560DD5C
		public bool __Gen_Wrap_35(LoginWorkFlow.ENode P0) => default; // 0x000000018514DE88-0x000000018514DF54
		public IEnumerator __Gen_Wrap_36(LoginWorkFlow.ENode P0) => default; // 0x000000018578552C-0x0000000185785618
		public CustomYieldInstruction __Gen_Wrap_37(object P0) => default; // 0x0000000185785618-0x0000000185785708
		public bool __Gen_Wrap_38(ref LoginWorkFlow.FWork P0) => default; // 0x0000000185785708-0x000000018578585C
		public void __Gen_Wrap_39(ref LoginWorkFlow.FWork P0) {} // 0x000000018578585C-0x00000001857859A0
		public void __Gen_Wrap_40(object P0, LoginAlertDialog.FParams P1) {} // 0x00000001857859A0-0x0000000185785AA0
		public void __Gen_Wrap_41(object P0, LoginVocResSelDialog.FParams P1) {} // 0x0000000185785AA0-0x0000000185785BA0
		public void __Gen_Wrap_42(object P0, LoginJudgeDialog.FParams P1) {} // 0x0000000185785BA0-0x0000000185785CC4
		public void __Gen_Wrap_43(LoginAlertDialog P0, LoginAlertDialog.FParams P1) {} // 0x0000000185785CC4-0x0000000185785DC4
		public void __Gen_Wrap_44(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public void __Gen_Wrap_45(object P0, bool P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8) {} // 0x0000000185785DC4-0x0000000185785F1C
		public IEnumerator __Gen_Wrap_46(object P0, bool P1) => default; // 0x0000000185785F1C-0x0000000185786028
		public bool __Gen_Wrap_47(object P0, out LoginWorkFlow.ENode P1) {
			P1 = default;
			return default;
		} // 0x0000000185786028-0x0000000185786134
		public void __Gen_Wrap_48(GameState P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public void __Gen_Wrap_49(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public float __Gen_Wrap_50(object P0) => default; // 0x00000001854AB08C-0x00000001854AB15C
		public LoginController __Gen_Wrap_51(object P0) => default; // 0x0000000185786134-0x0000000185786224
		public void __Gen_Wrap_52(object P0, object P1, float P2) {} // 0x0000000185625660-0x0000000185625744
		public List<ServerZoneManager.ServerZoneData> __Gen_Wrap_53(object P0) => default; // 0x0000000185786224-0x0000000185786314
		public bool __Gen_Wrap_54(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
		public ServerZoneManager.ServerZoneData __Gen_Wrap_55(object P0) => default; // 0x0000000185786314-0x0000000185786404
		public bool __Gen_Wrap_56(object P0, ELoginEvent P1, object P2) => default; // 0x0000000185786404-0x0000000185786508
		public void __Gen_Wrap_57(object P0, ELoginEvent P1, object P2) {} // 0x000000018514F720-0x000000018514F818
		public void __Gen_Wrap_58(string P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public void __Gen_Wrap_59(PointerEventData P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public bool __Gen_Wrap_60(ref LoginMockUIDPanel.FOptions P0) => default; // 0x0000000185786508-0x0000000185786654
		public void __Gen_Wrap_61(int P0, UIDropdownOption P1, bool P2) {} // 0x00000001850F1438-0x00000001850F151C
		public void __Gen_Wrap_62(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_63(object P0, LoginMockUIDPanel.FOptions P1, object P2) {} // 0x0000000185786654-0x0000000185786780
		public UISwitchTween __Gen_Wrap_64(object P0) => default; // 0x0000000185786780-0x0000000185786870
		public bool __Gen_Wrap_65(object P0, LoginController.EMaskType P1) => default; // 0x000000018548C780-0x000000018548C86C
		public void __Gen_Wrap_66(LoginVocResSelDialog P0, LoginVocResSelDialog.FParams P1) {} // 0x0000000185786870-0x0000000185786970
		public IEnumerator __Gen_Wrap_67(object P0, object P1, object P2, object P3) => default; // 0x0000000185786970-0x0000000185786AA8
		public void __Gen_Wrap_68(LoginJudgeDialog P0, LoginJudgeDialog.FParams P1) {} // 0x0000000185786AA8-0x0000000185786BB8
		public void __Gen_Wrap_69(object P0, object P1, object P2, object P3) {} // 0x0000000185496D84-0x0000000185496E8C
		public string __Gen_Wrap_70(object P0, object P1, object P2) => default; // 0x0000000185786BB8-0x0000000185786CE0
		public void __Gen_Wrap_71(ref bool P0) {} // 0x0000000185786CE0-0x0000000185786DB4
		public void __Gen_Wrap_72(object P0, ref bool P1) {} // 0x0000000185786DB4-0x0000000185786EA4
		public void __Gen_Wrap_73(object P0, LoginManager.FFlowWithMask P1) {} // 0x0000000185786EA4-0x0000000185786FC8
		public bool __Gen_Wrap_74(ref LoginManager.FFlowCondition P0, LoginWorkFlow.ENode P1) => default; // 0x0000000185786FC8-0x000000018578711C
		public IEnumerator __Gen_Wrap_75(object P0, LoginManager.FFlowWithMask P1) => default; // 0x000000018578711C-0x000000018578725C
		public TMP_FontAsset __Gen_Wrap_76(object P0) => default; // 0x000000018578725C-0x0000000185787338
		public void __Gen_Wrap_77(SDKNetUtils.HttpPostRequest P0) {} // 0x0000000185787338-0x000000018578742C
		public void __Gen_Wrap_78(SDKNetUtils.HttpGetRequest P0) {} // 0x000000018578742C-0x0000000185787510
		public IEnumerator __Gen_Wrap_79(object P0, SDKNetUtils.HTTPConfig P1) => default; // 0x0000000185787510-0x0000000185787640
		public IEnumerator __Gen_Wrap_80() => default; // 0x0000000185787640-0x000000018578770C
		public string __Gen_Wrap_81(object P0) => default; // 0x000000018578770C-0x00000001857877FC
		public Dictionary<string, string> __Gen_Wrap_82(object P0) => default; // 0x00000001857877FC-0x00000001857878D8
		public int __Gen_Wrap_83(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public void __Gen_Wrap_84(object P0, SDKExtraData P1) {} // 0x00000001857878D8-0x00000001857879EC
		public SDKExternalTools.POSTResult __Gen_Wrap_85(SDKNetUtils.WebHttpResponse P0) => default; // 0x00000001857879EC-0x0000000185787B24
		public void __Gen_Wrap_86(SDKNetUtils.WebHttpResponse P0) {} // 0x0000000185787B24-0x0000000185787C18
		public void __Gen_Wrap_87(object P0, SDKExternalTools.POSTRequest P1, object P2) {} // 0x0000000185787C18-0x0000000185787D3C
		public SDKCaptchaHandler __Gen_Wrap_88(object P0) => default; // 0x0000000185787D3C-0x0000000185787E18
		public bool __Gen_Wrap_89(object P0, SDKExternalTools.ErrMsgMeta P1, out string P2) {
			P2 = default;
			return default;
		} // 0x0000000185787E18-0x0000000185787F84
		public string __Gen_Wrap_90(object P0, SDKExternalTools.ErrMsgMeta P1) => default; // 0x0000000185787F84-0x00000001857880AC
		public IEnumerator __Gen_Wrap_91(object P0, object P1, object P2) => default; // 0x00000001857880AC-0x00000001857881C0
		public void __Gen_Wrap_92(object P0, ExternalPluginLoginParams P1) {} // 0x00000001857881C0-0x00000001857882E4
		public void __Gen_Wrap_93(object P0, ExternalPluginLogoutParams P1) {} // 0x00000001857882E4-0x00000001857883EC
		public void __Gen_Wrap_94(U8PayResult P0) {} // 0x00000001857883EC-0x00000001857884D8
		public void __Gen_Wrap_95(object P0, ExternalPluginPayParams P1) {} // 0x00000001857884D8-0x00000001857885E0
		public bool __Gen_Wrap_96(object P0, object P1, out SDKMeta P2) {
			P2 = default;
			return default;
		} // 0x00000001857885E0-0x0000000185788730
		public void __Gen_Wrap_97(ref LoginWorkFlow.FWork P0, int P1) {} // 0x0000000185788730-0x000000018578888C
		public bool __Gen_Wrap_98(object P0, LoginWorkFlow.ENode P1, bool P2) => default; // 0x000000018578888C-0x0000000185788990
		public HGDownloader.DownloadProgress __Gen_Wrap_99(object P0) => default; // 0x0000000185788990-0x0000000185788A94
		public HGDownloader.WorkState __Gen_Wrap_100(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public List<HGFileInfo> __Gen_Wrap_101(object P0, object P1) => default; // 0x0000000185784308-0x0000000185784400
		public List<HGFolder> __Gen_Wrap_102(object P0, object P1) => default; // 0x000000018104E7F0-0x000000018104F210
		public bool __Gen_Wrap_103(object P0, HGRetCodeType P1, int P2) => default; // 0x000000018104F210-0x000000018104F510
		public string __Gen_Wrap_104(double P0) => default; // 0x000000018104F510-0x000000018104FD90
		public void __Gen_Wrap_105(object P0, long P1, object P2, object P3, object P4) {} // 0x000000018104FD90-0x00000001810502C0
		public void __Gen_Wrap_106(object P0, HGDownloader.PauseReason P1) {} // 0x00000001810502C0-0x0000000181050590
		public IEnumerator __Gen_Wrap_107(object P0, long P1) => default; // 0x0000000181050590-0x0000000181050F30
		public void __Gen_Wrap_108(object P0, long P1, long P2, long P3) {} // 0x0000000181050F30-0x0000000181051240
		public double __Gen_Wrap_109(object P0) => default; // 0x0000000181051240-0x0000000181051500
		public bool __Gen_Wrap_110(bool P0) => default; // 0x0000000181051500-0x0000000181051700
		public string __Gen_Wrap_111(object P0, bool P1) => default; // 0x0000000181051700-0x00000001810520A0
		public LocalResPref __Gen_Wrap_112() => default; // 0x00000001810520A0-0x00000001810528E0
		public LoginHotUpdater.HotUpdateInfo __Gen_Wrap_113(object P0, bool P1) => default; // 0x00000001810528E0-0x0000000181053280
		public ResourceIndex __Gen_Wrap_114() => default; // 0x0000000181053280-0x0000000181053AC0
		public string __Gen_Wrap_115(object P0, object P1, bool P2) => default; // 0x0000000181053AC0-0x0000000181054510
		public object __Gen_Wrap_116() => default; // 0x0000000181054510-0x0000000181054D50
		public IEnumerator __Gen_Wrap_117(object P0, object P1, bool P2, object P3) => default; // 0x0000000181054D50-0x0000000181055870
		public IEnumerator __Gen_Wrap_118(bool P0, object P1, object P2) => default; // 0x0000000181055870-0x00000001810562B0
		public LocalResPref __Gen_Wrap_119(object P0, bool P1, object P2, FResourceDiff P3, out int P4) {
			P4 = default;
			return default;
		} // 0x00000001810562B0-0x0000000181057010
		public void __Gen_Wrap_120(object P0, ref bool P1, double P2, double P3, int P4, bool P5) {} // 0x0000000181057010-0x0000000181057380
		public bool __Gen_Wrap_121(object P0, EVFSBlockType P1) => default; // 0x0000000181057380-0x0000000181057670
		public IEnumerator __Gen_Wrap_122(object P0, object P1, bool P2, bool P3) => default; // 0x0000000181057670-0x00000001810580E0
		public LoginHotUpdater __Gen_Wrap_123(object P0, bool P1) => default; // 0x00000001810580E0-0x0000000181058A40
		public LoginProgress.FDownloadSize.EUnit __Gen_Wrap_124(double P0) => default; // 0x0000000181058A40-0x0000000181058C40
		public float __Gen_Wrap_125(double P0, LoginProgress.FDownloadSize.EUnit P1) => default; // 0x0000000181058C40-0x0000000181058E70
		public string __Gen_Wrap_126(float P0, float P1, LoginProgress.FDownloadSize.EUnit P2) => default; // 0x0000000181058E70-0x0000000181059760
		public string __Gen_Wrap_127(float P0, LoginProgress.FDownloadSize.EUnit P1) => default; // 0x0000000181059760-0x000000018105A010
		public string __Gen_Wrap_128(float P0, float P1) => default; // 0x000000018105A010-0x000000018105A8E0
		public void __Gen_Wrap_129(ref LoginProgress.FDownloadSize P0, double P1, double P2, double P3) {} // 0x000000018105A8E0-0x000000018105B5B0
		public void __Gen_Wrap_130(ref LoginProgress.FDownloadSize P0, double P1, double P2) {} // 0x000000018105B5B0-0x000000018105C260
		public void __Gen_Wrap_131(ref LoginProgress.FDownloadSize P0) {} // 0x000000018105C260-0x000000018105CE70
		public void __Gen_Wrap_132(SpeedTestResult P0) {} // 0x000000018105CE70-0x000000018105D130
		public Task<Hypergryph.SpeedTest.TaskResult> __Gen_Wrap_133() => default; // 0x000000018105D130-0x000000018105D970
		public LoginViewModel.FAgeTipsPolicy __Gen_Wrap_134() => default; // 0x000000018105D970-0x000000018105E180
		public LoginWorkFlow.Node[] __Gen_Wrap_135(object P0) => default; // 0x000000018105E180-0x000000018105EAC0
		public float __Gen_Wrap_136(object P0, out bool P1) {
			P1 = default;
			return default;
		} // 0x000000018105EAC0-0x000000018105EDE0
		public UIAnimationMixPlayer __Gen_Wrap_137(object P0) => default; // 0x000000018105EDE0-0x000000018105F720
		public void __Gen_Wrap_138(object P0, LoginSceneAnimCtrl.EState P1) {} // 0x000000018105F720-0x000000018105FA00
		public List<string> __Gen_Wrap_139(object P0) => default; // 0x000000018105FA00-0x0000000181060340
		public void __Gen_Wrap_140(object P0, LoginViewModel.FAgeTipsPolicy P1) {} // 0x0000000181060340-0x00000001810609D0
		public void __Gen_Wrap_141(object P0, object P1, bool P2, bool P3) {} // 0x00000001810609D0-0x0000000181060DB0
		public void __Gen_Wrap_142(bool P0, bool P1, bool P2) {} // 0x0000000181060DB0-0x0000000181060FE0
		public void __Gen_Wrap_143(object P0, in EventData<bool> P1) {} // 0x0000000181060FE0-0x0000000181061680
		public void __Gen_Wrap_144(object P0, in EventData<float> P1) {} // 0x0000000181061680-0x0000000181061D10
		public void __Gen_Wrap_145(object P0, object P1, object P2, bool P3) {} // 0x0000000181061D10-0x0000000181062180
		public void __Gen_Wrap_146(object P0, object P1, int P2) {} // 0x0000000181062180-0x0000000181062520
		public void __Gen_Wrap_147(object P0, int P1, object P2) {} // 0x0000000181062520-0x00000001810628B0
		public void __Gen_Wrap_148(object P0, EVFSBlockType P1) {} // 0x00000001810628B0-0x0000000181062B80
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 53282
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get => default; } // 0x0000000185788A94-0x0000000185788B40 
		object IEnumerator.Current { [IDTag(4)] get => default; } // 0x0000000185788B40-0x0000000185788BEC 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000185788BEC-0x0000000185788CC8
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose() {} // 0x0000000185152EA8-0x0000000185152F24
		[IDTag(1)]
		private bool MoveNext() => default; // 0x0000000185152C48-0x0000000185152CD4
		[IDTag(3)]
		void IEnumerator.Reset() {} // 0x0000000185152D80-0x0000000185152DFC
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 53283
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018578C5F0-0x000000018578C654
		public static bool IsPatched(int id) => default; // 0x000000018262E590-0x000000018262E600
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018578C4AC-0x000000018578C578
		public object CreateWrapper(int id) => default; // 0x000000018578C578-0x000000018578C5F0
		public object InitWrapperArray(int len) => default; // 0x000000018578C654-0x000000018578CAF8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018578C408-0x000000018578C4AC
	}

	public enum IDMAP0 // TypeDefIndex: 53284
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
		Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageTextChange0 = 52,
		Beyond-Scripts-Entry-GameSettingSetter-_OnLanguageAudioChange0 = 54,
		Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsQualityChange0 = 56,
		Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsFullScreenChanged0 = 58,
		Beyond-Scripts-Entry-GameSettingSetter-_SetResolution0 = 59,
		Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsResolutionChange0 = 61,
		Beyond-Scripts-Entry-GameSettingSetter-_OnGraphicsNotchPaddingChange0 = 63,
		Beyond-Scripts-Entry-GameSettingSetter-_OnOtherShowSmartAlertChange0 = 65,
		Beyond-UI-SplashController-Show0 = 68,
		Beyond-RenderPipelineDataLoader-LoadSimpleRpData0 = 69,
		Beyond-UI-SplashController-_Play0 = 71,
		Beyond-UI-SplashController-_GetSplashConfigs0 = 72,
		Beyond-UI-SplashController-_DoStartSplash0 = 73,
		Beyond-UI-SplashController-_OnTweenFinished0 = 78,
		Beyond-UI-SplashController-_OnSplashCompleteCoroutine0 = 79,
		Beyond-SDK-Impl-U8ExternalTools-PublicSetGameVersion0 = 83,
		Beyond-UI-SplashController-_StartLicenseCoroutine0 = 84,
		Beyond-UI-SplashController-Hide0 = 91,
		Beyond-UI-SplashController-_Stop0 = 92,
		Beyond-GameApp-_Init0 = 99,
		Beyond-GameApp-_InitSecuritySDK0 = 100,
		Beyond-GameApp-_FetchRemoteConfigUtilSuc0 = 104,
		Beyond-GameApp-_InitGameStateMachine0 = 114,
		Beyond-GameApp-_RegisterLuaAfterGCEvent0 = 115,
		Beyond-GameApp-_OnApplicationFocusForLua0 = 116,
		Beyond-GameApp-_OnApplicationPauseForLua0 = 117,
		Beyond-GameApp-_OnSystemDisplaySizeChanged0 = 118,
		Beyond-GameApp-_OnSystemScreenSizeChanged0 = 119,
		Beyond-GameApp-Update0 = 121,
		Beyond-GameApp-LateUpdate0 = 122,
		Beyond-GameApp-OnApplicationQuit0 = 123,
		Beyond-GameApp-OnApplicationFocus0 = 124,
		Beyond-GameApp-OnApplicationPause0 = 125,
		Beyond-GameApp-_OnApplicationPauseForSecurity0 = 126,
		Beyond-GameApp-OnDestroy0 = 127,
		Beyond-GameApp-_UnInit0 = 128,
		Beyond-GameApp-_UnInitGameStateMachine0 = 129,
		Beyond-GameApp-QuitGame0 = 130,
		Beyond-GameApp-RefreshScreenResolution0 = 131,
		Beyond-GameInitState-OnEnter0 = 132,
		Beyond-GameStateBase-OnEnter0 = 133,
		Beyond-GameInitState-_DoInit0 = 134,
		Beyond-GameInitState-_InitInitialResourceManager0 = 138,
		Beyond-GameInitState-_CheckIfLocalInitialAssetsValid0 = 139,
		Beyond-GameInitState-_InitAPPDefaultCulture0 = 140,
		Beyond-RenderPipelineDataLoader-PreloadFullRpResources0 = 141,
		Beyond-VietnamLoginAgePanel-Init0 = 142,
		Beyond-VietnamLoginAgePanel-_Init0 = 143,
		Beyond-VietnamLoginAgePanel-_UnInit0 = 144,
		Beyond-GameInitState-_InitGameSetting0 = 145,
		Beyond-RenderPipelineDataLoader-IsPreLoadFinished0 = 157,
		Beyond-GameInitState-OnLeave0 = 161,
		Beyond-GameStateBase-OnLeave0 = 162,
		Beyond-GameLoginState-OnEnter0 = 163,
		Beyond-UI-SplashController-CanFinished0 = 164,
		Beyond-RenderPipelineDataLoader-LoadFullRpResources0 = 165,
		Beyond-GameLoginState-_TryStartLoginWorkflow0 = 166,
		Beyond-LoginManager-IsWorkflowInProgress0 = 167,
		Beyond-LoginContext-IsDisposed0 = 168,
		Beyond-LoginManager-InitCoroutine0 = 169,
		Beyond-LoginContext-Dispose0 = 173,
		Beyond-LoginContext-_DisposeImpl0 = 174,
		Beyond-Login-LoginWorkFlow-Dispose0 = 176,
		Beyond-Login-LoginWorkFlow-Node-Dispose0 = 179,
		Beyond-Login-LoginWorkFlow-Node-OnDispose0 = 180,
		Beyond-Login-LoginWorkFlow-_UpdateCursor0 = 181,
		Beyond-Login-LoginWorkFlow-_EnableCursor0 = 182,
		Beyond-Login-LoginWorkFlow-_EnbaleToggleGroup0 = 183,
		Beyond-Login-LoginWorkFlow-Worker-Dispose0 = 184,
		Beyond-LoginManager-AssetLoader-Dispose0 = 188,
		Beyond-LoginContext-_DisposeCoroutine0 = 189,
		Beyond-LoginController-BeforeDestroy0 = 193,
		Beyond-LoginController-get_maskCtrl0 = 197,
		Beyond-LoginController-MaskCtrl-IsCrossSceneMaskTweening0 = 198,
		Beyond-LoginController-MaskCtrl-_GetMaskByType0 = 199,
		Beyond-LoginController-MaskCtrl-WaitForCrossSceneMasks0 = 200,
		Beyond-LoginController-MaskCtrl-Dispose0 = 207,
		Beyond-LoginContext-IsWorkflowDisposed0 = 214,
		Beyond-LoginManager-_Init0 = 216,
		Beyond-LoginManager-_LoginWorkFlowCoroutine0 = 219,
		Beyond-LoginController-InitUI0 = 223,
		Beyond-LoginController-MaskCtrl-EnableMask0 = 224,
		Beyond-LoginController-_InitImpl0 = 225,
		Beyond-LoginController-_InitCoroutine0 = 226,
		Beyond-Login-LoginRootPanel-Init0 = 230,
		Beyond-Login-LoginRootPanel-_InitController0 = 232,
		Beyond-Login-LoginRootPanel-_InitChildPanel0 = 233,
		Beyond-Login-LoginRootPanel-ChildPanel-OnLoginContext0 = 234,
		Beyond-Login-LoginRootPanel-ChildPanel-OnInit0 = 236,
		Beyond-Login-LoginDecorateUI-OnLoginContext0 = 238,
		Beyond-Login-LoginDecorateUI-_ToggleGlow0 = 239,
		Beyond-Login-LoginDecorateUI-_EnsureGlowPlayer0 = 240,
		Beyond-LoginController-_InitVersionBtn0 = 241,
		Beyond-Login-LoginWorkFlow-DoWorkFlow0 = 245,
		Beyond-Login-LoginWorkFlow-FWork-Start0 = 250,
		Beyond-Login-LoginWorkFlow-_CheckIfGameStateNotMatch0 = 254,
		Beyond-Login-LoginWorkFlow-IsBeforeWork0 = 255,
		Beyond-Login-LoginWorkFlow-IsOnOrAfterWork0 = 256,
		Beyond-Login-LoginWorkFlow-_AdjustCurrentGameState0 = 257,
		Beyond-Login-LoginWorkFlow-Worker-SetCurNode0 = 264,
		Beyond-Login-LoginWorkFlow-Worker-Work0 = 267,
		Beyond-Login-LoginWorkFlow-Worker-_InternalTick0 = 273,
		Beyond-Login-LoginWorkFlow-Node-Cancel0 = 275,
		Beyond-Login-LoginHotUpdater-IsNeedSoftRestart0 = 279,
		Beyond-Login-LoginWorkFlow-Worker-TickInEmptyFrame0 = 280,
		Beyond-Login-LoginWorkFlow-FWork-ConsumeFallback0 = 281,
		Beyond-Login-LoginWorkFlow-FWork-MoveNextIndex0 = 283,
		Beyond-Login-LoginWorkFlow-FWork-WorkEnd0 = 285,
		Beyond-LoginManager-_PrepareBeforeLoginProcess0 = 292,
		Beyond-LoginManager-AlertDialog0 = 294,
		Beyond-Login-LoginAlertDialog-SetParams0 = 298,
		Beyond-Login-LoginVocResSelDialog-SetParams0 = 300,
		Beyond-Login-LoginJudgeDialog-SetParams0 = 302,
		Beyond-LoginContext-StartCoroutine0 = 303,
		Beyond-LoginContext-Init0 = 305,
		Beyond-LoginController-InvokeWhenStart0 = 312,
		Beyond-GameLoginState-OnLeave0 = 316,
		Beyond-GameMainState-OnEnter0 = 317,
		Beyond-LoginManager-Clear0 = 318,
		Beyond-LoginManager-_ClearWorkflowAndContext0 = 319,
		Beyond-LoginContext-ShutDown0 = 320,
		Beyond-LoginManager-_ReleaseLoginScene0 = 321,
		Beyond-GameMainState-OnLeave0 = 322,
		Beyond-GameMainState-ReleaseMainGame0 = 323,
		Beyond-LoginManager-OnReleaseMainGame0 = 324,
		Beyond-LoginManager-IsReLoginInProgress0 = 325,
		Beyond-Login-LoginWorkFlow-IsAfterWork0 = 326,
		Beyond-Login-LoginWorkFlow-PeekFallbackStatus0 = 327,
		Beyond-GameMainState-_ClearUtils0 = 328,
		Beyond-GamePreloadState-OnEnter0 = 329,
		Beyond-GamePreloadState-_DoPreload0 = 330,
		Beyond-GamePreloadState-_InitGameSettingStateInPreload0 = 334,
		Beyond-GamePreloadState-OnLeave0 = 355,
		Beyond-GameQuitState-OnEnter0 = 356,
		Beyond-GameQuitState-DoQuit0 = 357,
		Beyond-VietnamLoginAgePanel-UnInit0 = 358,
		Beyond-GameQuitState-OnLeave0 = 359,
		Beyond-GameSoftRestartState-OnEnter0 = 360,
		Beyond-GameSoftRestartState-_SoftRestart0 = 361,
		Beyond-LoginManager-ClearSync0 = 365,
		Beyond-GameStartState-OnEnter0 = 369,
		Beyond-GameStartState-_OnEnterMainGame0 = 370,
		Beyond-LoginManager-InvokeWhenWorkFlowFinished0 = 372,
		Beyond-GameStartState-OnLeave0 = 373,
		Beyond-GameStateBase-OnTick0 = 374,
		Beyond-GameStateMachine-_RegisterStates0 = 375,
		Beyond-GameStateMachine-CheckCanReturnToLoginState0 = 376,
		Beyond-GameStateMachine-ReturnToLoginState0 = 377,
		Beyond-GlobalInitializer-InitGlobalConfig0 = 384,
		Beyond-LoginController-Awake0 = 385,
		Beyond-LoginController-Start0 = 386,
		Beyond-LoginController-GetEnterGamePanelPredelay0 = 387,
		Beyond-LoginController-OnValueChanged0 = 388,
		Beyond-Login-LoginWorkFlow-SendEvent0 = 389,
		Beyond-Login-LoginWorkFlow-_HandleGlobalEvent0 = 390,
		Beyond-Login-LoginWorkFlow-_EventOnOpenAgeTips0 = 391,
		Beyond-Login-LoginAgeTipsModel-IsContentEmpty0 = 393,
		Beyond-Login-LoginWorkFlow-_FetchAgeTipsCoroutine0 = 394,
		Beyond-LoginContext-ViewOnlyController0 = 398,
		Beyond-LoginController-MaskCtrl-EnableNetMask0 = 399,
		Beyond-LoginController-MaskCtrl-DisableNetMask0 = 400,
		Beyond-Login-LoginRootPanel-ToggleLoginBindingGroup0 = 404,
		Beyond-Login-LoginWorkFlow-_EventOnCloseAgeTips0 = 405,
		Beyond-Login-LoginWorkFlow-_EventOnOpenServerSelect0 = 406,
		Beyond-Login-LoginWorkFlow-_EventOnSelectServer0 = 409,
		Beyond-Login-LoginServerSelectModel-UpdateSelectedServer0 = 410,
		Beyond-Login-LoginServerSelectModel-get_serverList0 = 411,
		Beyond-Login-LoginWorkFlow-_EventOnConfirmServer0 = 412,
		Beyond-Login-LoginServerSelectModel-GetSelectedServer0 = 413,
		Beyond-Login-LoginWorkFlow-Node-OnEvent0 = 414,
		Beyond-LoginController-MockLoginWithCallback0 = 415,
		Beyond-LoginController-_MockLoginCoroutine0 = 418,
		Beyond-Login-LoginMockUIDPanel-LoginWithCallback0 = 424,
		Beyond-Login-LoginMockUIDPanel-_UpdateStatus0 = 425,
		Beyond-Login-LoginMockUIDPanel-_OnBtnEnterGame0 = 427,
		Beyond-Login-LoginMockUIDPanel-_SaveConfig0 = 428,
		Beyond-Login-LoginMockUIDPanel-_OnBtnDelLocalFile0 = 430,
		Beyond-Login-LoginMockUIDPanel-_TryClosePanel0 = 432,
		Beyond-Login-LoginMockUIDPanel-FOptions-IsUIDFixed0 = 433,
		Beyond-Login-LoginMockUIDPanel-_InitLoginInfo0 = 434,
		Beyond-Login-LoginMockUIDPanel-_OnSelectServer0 = 436,
		Beyond-Login-LoginMockUIDPanel-HideAndDestroy0 = 437,
		Beyond-LoginController-Dialog-_CloseCoroutine0 = 448,
		Beyond-LoginController-Dialog-TryCloseWithCallback0 = 455,
		Beyond-LoginController-Dialog-Show0 = 456,
		Beyond-LoginController-Dialog-OnInit0 = 457,
		Beyond-LoginController-MaskCfg-CreateTweenAndHide0 = 458,
		Beyond-LoginController-MaskCtrl-IsMaskTweening0 = 459,
		Beyond-LoginContext-StopCoroutine0 = 460,
		Beyond-LoginContext-SendEvent0 = 461,
		Beyond-LoginManager-SceneComponentOnly_Bind0 = 462,
		Beyond-LoginManager-_BindPendingComponents0 = 463,
		Beyond-Login-LoginSceneComponent-Bind0 = 464,
		Beyond-Login-LoginSceneComponent-OnBindToManager0 = 467,
		Beyond-LoginManager-ToggleLoginBindingGroup0 = 468,
		Beyond-LoginManager-VocResSelDialog0 = 469,
		Beyond-LoginManager-VocResSelDialogWithConfirm0 = 470,
		Beyond-LoginManager-AlertDialogWithResult0 = 479,
		Beyond-LoginManager-AlertDialogWithConfirm0 = 488,
		Beyond-LoginManager-JudgeDialog0 = 497,
		Beyond-LoginManager-_StartShowJudgeDialogCoroutine0 = 498,
		Beyond-LoginManager-JudgeDialog1 = 499,
		Beyond-LoginManager-MockLoginWithCallback0 = 500,
		Beyond-LoginManager-MockManualSelectServer0 = 501,
		Beyond-LoginManager-IsLoginSceneLoading0 = 504,
		Beyond-LoginManager-FetchRemoteConfigUtilSuc0 = 505,
		Beyond-LoginManager-_ExtractErrorInfo0 = 509,
		Beyond-LoginManager-DevOnlyCheckEnableLocalResMode0 = 513,
		Beyond-LoginManager-DevOnlyUseLocalResVersion0 = 514,
		Beyond-LoginManager-AssetLoader-_CheckDisposedBeforeLoad0 = 515,
		Beyond-LoginManager-FlowWithMaskMgr-StartFlow0 = 516,
		Beyond-LoginManager-FlowWithMaskMgr-_FlowCoroutine0 = 517,
		Beyond-LoginManager-FlowWithMaskMgr-_OnFlowFinished0 = 521,
		Beyond-LoginManager-FFlowCondition-IsTargetMatch0 = 522,
		Beyond-VietnamLoginAgePanel-OnApplicationQuit0 = 528,
		Beyond-VietnamLoginAgeTipsPanelCtrl-Awake0 = 529,
		Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateTips0 = 530,
		Beyond-VietnamLoginAgeTipsPanelCtrl-_SetStateCircle0 = 531,
		Beyond-TailGameLoop-Update0 = 532,
		Beyond-TailGameLoop-LateUpdate0 = 533,
		Beyond-UI-SplashController-Awake0 = 534,
		Beyond-UI-SplashController-OnDestroy0 = 535,
		Beyond-SDK-PlatformFont-GetFont0 = 536,
		Beyond-SDK-SDKNetUtils-HTTPPost0 = 537,
		Beyond-SDK-SDKNetUtils-HTTPGet0 = 538,
		Beyond-SDK-SDKNetUtils-BeyondHttp-DoHTTP0 = 539,
		Beyond-SDK-Impl-U8ExternalTools-IsInited0 = 546,
		Beyond-SDK-Impl-U8ExternalTools-NeedRetryInit0 = 547,
		Beyond-SDK-Impl-U8ExternalTools-NeedQuitGame0 = 548,
		Beyond-SDK-Impl-U8ExternalTools-RetryInitSDKSystem0 = 549,
		Beyond-SDK-Impl-U8ExternalTools-InitSDKSystem0 = 550,
		Beyond-SDK-Impl-U8ExternalTools-_OnRequestExitGame0 = 551,
		Beyond-SDK-Impl-U8ExternalTools-WaitForInited0 = 557,
		Beyond-SDK-Impl-U8ExternalTools-InitHGSDK0 = 564,
		Beyond-SDK-Impl-U8ExternalTools-IsHGSDKInited0 = 565,
		Beyond-SDK-Impl-U8ExternalTools-WaitForInitHGSDK0 = 566,
		Beyond-SDK-Impl-U8ExternalTools-Log0 = 573,
		Beyond-SDK-Impl-U8ExternalTools-LogError0 = 574,
		Beyond-SDK-Impl-U8ExternalTools-LogWarning0 = 575,
		Beyond-SDK-Impl-U8ExternalTools-GetSignKey0 = 576,
		Beyond-SDK-Impl-U8ExternalTools-GetDeviceIDs0 = 577,
		Beyond-SDK-Impl-U8ExternalTools-SetSubChannel0 = 578,
		Beyond-SDK-Impl-U8ExternalTools-GetPlatformKey0 = 579,
		Beyond-SDK-Impl-U8ExternalTools-OnSDKExtraInfo0 = 580,
		Beyond-SDK-Impl-U8ExternalTools-_ProcessExtraInfo0 = 581,
		Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-OnGT3Message0 = 582,
		Beyond-SDK-Impl-U8ExternalTools-U8RootUrl0 = 583,
		Beyond-SDK-Impl-U8ExternalTools-POSTImplementation0 = 584,
		Beyond-SDK-Impl-U8ExternalTools-_ConvertToPOSTResult0 = 587,
		Beyond-SDK-Impl-U8ExternalTools-_OnFakeAccountCenter0 = 588,
		Beyond-SDK-Impl-U8ExternalTools-CreateCaptchaHandler0 = 589,
		Beyond-SDK-Impl-U8ExternalTools-GetErrorMessage0 = 590,
		Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_GET_TOKEN0 = 591,
		Beyond-SDK-Impl-U8ExternalTools-_ErrorMsg_CREATE_ORDER0 = 592,
		Beyond-SDK-Impl-U8ExternalTools-CaptchaHandler-FetchCaptchaCoroutine0 = 593,
		Beyond-SDK-Impl-U8Plugin-GetPayAddition0 = 600,
		Beyond-SDK-Impl-U8Plugin-GetSDKToken0 = 601,
		Beyond-SDK-Impl-U8Plugin-GetSDKUid0 = 602,
		Beyond-SDK-Impl-U8Plugin-Init0 = 603,
		Beyond-SDK-Impl-U8Plugin-Login0 = 604,
		Beyond-SDK-Impl-U8Plugin-_UseMockVersion0 = 605,
		Beyond-SDK-Impl-U8Plugin-_MockLogin0 = 606,
		Beyond-SDK-Impl-U8Plugin-Logout0 = 609,
		Beyond-SDK-Impl-U8Plugin-OnProductListChanged0 = 610,
		Beyond-SDK-Impl-U8Plugin-Pay0 = 611,
		Beyond-SDK-Impl-U8Plugin-TryLoadSDKMeta0 = 615,
		Beyond-Login-LoginCheckForUpdateNode-Work0 = 616,
		Beyond-Login-LoginGameUpdater-Clear0 = 619,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutine0 = 620,
		Beyond-Login-LoginCheckForUpdateNode-AlertNoMatchDeviceBeforeLogin0 = 624,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutinePC0 = 631,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdatePC0 = 635,
		Beyond-Login-LoginCheckForUpdateNode-_GetOnlineAppVersion0 = 639,
		Beyond-Login-LoginCheckForUpdateNode-_GetRequestPram0 = 643,
		Beyond-Login-LoginGameUpdater-ShowWaitProgress0 = 647,
		Beyond-Login-LoginGameUpdater-GetWaitTime0 = 648,
		Beyond-Login-LoginGameUpdater-ClearWaitProgress0 = 655,
		Beyond-Login-LoginCheckForUpdateNode-_CheckForUpdateCoroutineMobile0 = 659,
		Beyond-Login-LoginGameUpdater-CheckLastGameInfo0 = 663,
		Beyond-Login-LoginGameUpdater-_GetLastGameInfo0 = 667,
		Beyond-Login-LoginGameUpdater-_CreateDirectoryIfNotExists0 = 671,
		Beyond-Login-LoginGameUpdater-Context-CompleteWithCode0 = 672,
		Beyond-Login-LoginGameUpdater-Context-UncompleteWithCode0 = 675,
		Beyond-Login-LoginGameUpdater-GetNoAlertCode0 = 676,
		Beyond-Login-LoginWorkFlow-Fallback0 = 686,
		Beyond-Login-LoginWorkFlow-FWork-MarkFallback0 = 687,
		Beyond-Login-LoginCreateRoleNode-OnDispose0 = 691,
		Beyond-Login-LoginCreateRoleNode-WorkProcess-Dispose0 = 692,
		Beyond-Login-LoginCreateRoleNode-CanCancel0 = 693,
		Beyond-Login-LoginCreateRoleNode-Work0 = 694,
		Beyond-Login-LoginDownloadTask-GetDownloadProgress0 = 695,
		Beyond-Login-LoginDownloadTask-GetDecompressProgress0 = 696,
		Beyond-Login-LoginDownloadTask-GetWorkState0 = 697,
		Beyond-Login-LoginDownloadTask-Tick0 = 698,
		Beyond-Login-LoginDownloadTask-Dispose0 = 699,
		Beyond-Login-LoginDownloadTask-_StartDownload0 = 700,
		Beyond-Login-LoginDownloadTask-_GetFileList0 = 701,
		Beyond-Login-LoginDownloadTask-_StartDownloadImpl0 = 702,
		Beyond-Login-LoginDownloadTask-_GetAllFileList0 = 703,
		Beyond-Login-NetUsagePolicy-AllowMobileDataInLastCheck0 = 704,
		Beyond-Login-LoginDownloadTask-_OnDownloadFinish0 = 705,
		Beyond-Login-LoginDownloadTask-_OnDownloadError0 = 706,
		Beyond-Login-LoginDownloadTask-_OnDownloadPaused0 = 708,
		Beyond-Login-NetUsagePolicy-CheckIfAllowDownload0 = 714,
		Beyond-Login-NetUsagePolicy-_GetPrettySizeStringUpToMB0 = 718,
		Beyond-Login-LoginGameSettingInitializer-Awake0 = 719,
		Beyond-Login-LoginGameSettingInitializer-_TryInitializeComponents0 = 720,
		Beyond-Login-LoginGameSettingInitializer-OnEnable0 = 721,
		Beyond-Login-LoginGameSettingInitializer-_InitGameSettingStateInLogin0 = 722,
		Beyond-Login-LoginGameSettingInitializer-_InitGameSettingNotchPadding0 = 723,
		Beyond-Login-LoginGameUpdateNode-Work0 = 725,
		Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutine0 = 727,
		Beyond-Login-LoginGameUpdateNode-_GameUpdateCoroutineMobileImpl0 = 734,
		Beyond-Login-LoginGameUpdater-DoUpdate0 = 738,
		Beyond-Login-LoginGameUpdater-_UpdateGame0 = 742,
		Beyond-Login-LoginGameUpdater-_YieldCheckNetUsagePolicy0 = 746,
		Beyond-Login-LoginGameUpdater-_YieldErrorAlert0 = 758,
		Beyond-Login-LoginGameUpdater-_DoTaskUpdating0 = 767,
		Beyond-Login-LoginGameUpdater-_OnDownloadStart0 = 771,
		Beyond-Login-LoginGameUpdater-_OnDownloadProgress0 = 772,
		Beyond-Login-LoginGameUpdater-_WaitForTaskCancel0 = 779,
		Beyond-Login-LoginGSNode-Work0 = 792,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-EnterGame0 = 793,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_EnterGameCoroutine0 = 794,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_OnAuthError0 = 799,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ReLoginWhenErrorEncountered0 = 803,
		Beyond-Login-LoginGSNode-_FallbackToInitWithMask0 = 804,
		Beyond-Login-LoginGSNode-_FallbackToInitNodeImpl0 = 806,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-TryInterrupt0 = 807,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-IsInterruptable0 = 808,
		Beyond-Login-LoginGSNode-_LogoutToInitNode0 = 809,
		Beyond-Login-LoginGSNode-_ConfirmServer0 = 813,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_NetConnectAndGSLogin0 = 820,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_SaveCurrentUserToServerConfig0 = 824,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_MockManualSelectServer0 = 828,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_GlobalLoginSucBusiness0 = 843,
		Beyond-Login-LoginGSNode-OnEvent0 = 848,
		Beyond-Login-LoginGSNode-_OnEventLogout0 = 849,
		Beyond-Login-LoginGSNode-_OnEventResourceRepair0 = 851,
		Beyond-Login-LoginGSNode-_FallbackToResRepairImpl0 = 853,
		Beyond-Login-LoginViewModel-RequestResourceRepair0 = 854,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-MarkAborting0 = 857,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_ExtractErrorInfo0 = 858,
		Beyond-Login-LoginGSNode-EnterGameServiceFlow-_YieldAlertError0 = 859,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetCurrent0 = 866,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetTotal0 = 867,
		Beyond-Login-LoginHotUpdateModel-SimpleProgress-GetInfo0 = 868,
		Beyond-Login-LoginHotUpdater-MarkInitialAssetChanged0 = 869,
		Beyond-Login-LoginHotUpdater-CheckInitialAssetChanged0 = 870,
		Beyond-Login-LoginHotUpdater-MarkNeedClearFolder0 = 871,
		Beyond-Login-LoginHotUpdater-NeedClearFolder0 = 872,
		Beyond-Login-LoginHotUpdater-MarkClearSuccessed0 = 873,
		Beyond-Login-LoginHotUpdater-MarkSoftRestart0 = 874,
		Beyond-Login-LoginHotUpdater-ClearSoftRestartFlag0 = 875,
		Beyond-Login-LoginHotUpdater-Dispose0 = 876,
		Beyond-Login-LoginLocalResTask-Dispose0 = 877,
		Beyond-Login-LoginHotUpdater-StartHotUpdate0 = 878,
		Beyond-Login-LoginHotUpdater-_Work0 = 879,
		Beyond-Login-LoginHotUpdater-_UpdateResVersion0 = 883,
		Beyond-Login-LoginHotUpdater-_UpdateResVersionDev0 = 887,
		Beyond-Login-LoginHotUpdater-_UpdateResVersionProd0 = 894,
		Beyond-Login-LoginHotUpdater-_SetResVersionForLog0 = 904,
		Beyond-Login-LoginHotUpdater-_CreateMainCoroutine0 = 905,
		Beyond-Login-LoginHotUpdater-_CurrentWorkMode0 = 909,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeDownload0 = 910,
		Beyond-Login-LoginHotUpdater-_GetOnlineResVersion0 = 916,
		Beyond-Login-LoginHotUpdater-WorkContext-GetHotUpdateInfo0 = 917,
		Beyond-Login-LoginHotUpdater-_CheckAndDownloadResource0 = 918,
		Beyond-Login-LoginHotUpdater-_GenResIndex0 = 922,
		Beyond-Login-LoginHotUpdater-_LoadOrDownloadResIndex0 = 926,
		Beyond-Login-LoginHotUpdater-_ResourceIndexUrl0 = 933,
		Beyond-Login-LoginHotUpdater-ResourceRootUrl0 = 934,
		Beyond-Login-LoginHotUpdater-_GenRiff0 = 941,
		Beyond-Login-LoginHotUpdater-_ResourcePatchUrl0 = 945,
		Beyond-Login-LoginHotUpdater-_ResourceFileUrl0 = 946,
		Beyond-Login-LoginHotUpdater-_LoadStreamingIndex0 = 947,
		Beyond-Login-LoginHotUpdater-_DownloadPatchInfo0 = 959,
		Beyond-Login-LoginHotUpdater-_ResourcePatchRootUrl0 = 963,
		Beyond-Login-LoginHotUpdater-_CreateUpdatedLocalResPref0 = 967,
		Beyond-Login-LoginHotUpdater-_EventLogDownloadProgress0 = 969,
		Beyond-Login-LoginHotUpdater-_GenLocalRef0 = 970,
		Beyond-Login-LoginHotUpdater-WriteLocalResPrefToFile0 = 974,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-CheckIfNeedReload0 = 981,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasChangedByType0 = 982,
		Beyond-Login-LoginHotUpdater-_CheckLocalResConsistency0 = 983,
		Beyond-Login-LoginHotUpdater-WorkContext-MarkIllegalItemsInLocalRes0 = 987,
		Beyond-Login-LoginHotUpdater-_ClearDownloadFolder0 = 996,
		Beyond-Login-LoginHotUpdater-_ReloadResourceIndexes0 = 1003,
		Beyond-Login-LoginHotUpdater-WorkContext-HasChangedByType0 = 1007,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeLocal0 = 1014,
		Beyond-Login-LoginLocalResTask-Work0 = 1018,
		Beyond-Login-LoginHotUpdater-_MainCoroutineModeSkip0 = 1031,
		Beyond-Login-LoginHotUpdater-_VitalError0 = 1041,
		Beyond-Login-LoginViewModel-RequestSkipU8Login0 = 1045,
		Beyond-Login-LoginHotUpdater-HotUpdateInfo-HasAssetsChanged0 = 1054,
		Beyond-Login-LoginProgress-GetCurrent0 = 1055,
		Beyond-Login-LoginProgress-GetTotal0 = 1056,
		Beyond-Login-LoginProgress-GetInfo0 = 1057,
		Beyond-Login-LoginProgress-FDownloadSize-SetSize0 = 1058,
		Beyond-Login-LoginProgress-FDownloadSize-_PickUnit0 = 1059,
		Beyond-Login-LoginProgress-FDownloadSize-_DisplayWithUnit0 = 1060,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatDisplayInfo0 = 1061,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatSpeedInfo0 = 1062,
		Beyond-Login-LoginProgress-FDownloadSize-_FormatProgressInfo0 = 1063,
		Beyond-Login-LoginProgress-FDownloadSize-SetProgress0 = 1064,
		Beyond-Login-LoginProgress-FDownloadSize-SetIdle0 = 1065,
		Beyond-Login-LoginInitNode-Work0 = 1066,
		Beyond-Login-LoginInitNode-_InitCoroutine0 = 1067,
		Beyond-Login-LoginInitNode-_InitRemoteConfigs0 = 1071,
		Beyond-Login-LoginInitNode-_YieldAlertError0 = 1075,
		Beyond-Login-PreloadNode-Work0 = 1088,
		Beyond-Login-PreloadNode-_ShowPreloadResourcePanel0 = 1089,
		Beyond-Login-PreloadNode-_LoginPreLoad0 = 1090,
		Beyond-Login-PreloadNode-_WarmUp0 = 1094,
		Beyond-Login-PreloadNode-_GetServerList0 = 1101,
		Beyond-Login-PreloadNode-_GetServerListInfoMock0 = 1105,
		Beyond-Login-PreloadNode-_OnGetServerListSuc0 = 1109,
		Beyond-Login-PreloadNode-_GetServerListInfo0 = 1116,
		Beyond-Login-PreloadNode-_OnGetServerListFail0 = 1120,
		Beyond-Login-PreloadNode-_EnterPreLoad0 = 1127,
		Beyond-Login-LoginSDKInitNode-Work0 = 1134,
		Beyond-Login-LoginSDKInitNode-_SDKInitCoroutine0 = 1135,
		Beyond-Login-LoginSDKInitNode-_WaitForSDKInited0 = 1139,
		Beyond-Login-LoginSDKInitNode-_InitSubSDKs0 = 1146,
		Beyond-Login-U8LoginNode-Work0 = 1156,
		Beyond-Login-U8LoginNode-_LoginCoroutine0 = 1157,
		Beyond-Login-U8LoginNode-_ClearLoginCaches0 = 1161,
		Beyond-Login-U8LoginNode-_SkipSDKLogin0 = 1162,
		Beyond-Login-U8LoginNode-_EnableBlurMask0 = 1163,
		Beyond-Login-U8LoginNode-_OnLoginSuc0 = 1164,
		Beyond-Login-U8LoginNode-_OnSDKViewDisabled0 = 1165,
		Beyond-Login-LoginRootPanel-InitBulletinAndRedAfterLoginSuc0 = 1166,
		Beyond-Login-LoginMenuPanel-InitBulletinAndRedAfterLoginSuc0 = 1167,
		Beyond-Login-LoginMenuPanel-_UpdateAnnounceRedDot0 = 1168,
		Beyond-Login-LoginMenuPanel-_OnReceiveRedDotAndPopup0 = 1169,
		Beyond-Login-LoginMenuPanel-_OnBulletinOpen0 = 1170,
		Beyond-Login-LoginMenuPanel-_OnBulletinClose0 = 1171,
		Beyond-Login-U8LoginNode-_StartSDKLogin0 = 1172,
		Beyond-Login-U8LoginNode-_SetCursorOnLoginStart0 = 1173,
		Beyond-Login-U8LoginNode-_SetCursorOnLoginFinish0 = 1175,
		Beyond-Login-U8LoginNode-_OnLoginFail0 = 1177,
		Beyond-Login-U8LoginNode-_OnLoginCanceled0 = 1178,
		Beyond-Login-U8LoginNode-_FinishLogin0 = 1179,
		Beyond-Login-U8LoginNode-OnEvent0 = 1189,
		Beyond-Login-LoginViewModel-IsAgeTipsVisible0 = 1190,
		Beyond-Login-LoginViewModel-IsGovTipsVisible0 = 1191,
		Beyond-Login-LoginViewModel-IsMenuVisible0 = 1192,
		Beyond-Login-LoginViewModel-_LoadAgeTipsPolicy0 = 1193,
		Beyond-Login-LoginAgeTipsModel-CanDisplay0 = 1194,
		Beyond-Login-LoginAgeTipsProp-ClearContentCache0 = 1195,
		Beyond-Login-LoginAgeTipsProp-UpdateContent0 = 1196,
		Beyond-Login-LoginWorkFlow-_RegisterNodes0 = 1197,
		Beyond-Login-LoginWorkFlow-CancelAndFallback0 = 1198,
		Beyond-Login-LoginWorkFlow-Worker-Cancel0 = 1199,
		Beyond-Login-LoginWorkFlow-Node-CanCancel0 = 1200,
		Beyond-Login-LoginWorkFlow-AddEventReceiver0 = 1201,
		Beyond-Login-LoginWorkFlow-UpdateOnce0 = 1202,
		Beyond-Login-LoginWorkFlow-Worker-UpdateOnce0 = 1203,
		Beyond-Login-LoginWorkFlow-Node-Init0 = 1204,
		Beyond-Login-LoginWorkFlow-Node-OnInit0 = 1207,
		Beyond-Login-HotUpdateNode-Work0 = 1208,
		Beyond-Login-HotUpdateNode-OnDispose0 = 1209,
		Beyond-Login-WaitForSecondsNode-Work0 = 1210,
		Beyond-Login-WaitForSecondsNode-_NotifyTimeout0 = 1211,
		Beyond-Login-WaitForSecondsNode-_IsTimeout0 = 1212,
		Beyond-Login-WaitForSecondsNode-_DisposeTimer0 = 1213,
		Beyond-Login-WaitForSecondsNode-OnDispose0 = 1214,
		Beyond-Login-PreloadPostDelayNode-WaitForSeconds0 = 1215,
		Beyond-Login-PreloadPostDelayNode-Work0 = 1216,
		Beyond-Login-PreloadPostDelayNode-_DisableLoadingPanel0 = 1217,
		Beyond-Login-Trans2GsLoginNode-WaitForSeconds0 = 1218,
		Beyond-Login-Trans2GsLoginNode-Work0 = 1219,
		Beyond-Login-FinishNode-Work0 = 1220,
		Beyond-Login-LoginSceneAnimCtrl-OnBindToManager0 = 1221,
		Beyond-Login-LoginSceneAnimCtrl-_EnsurePlayer0 = 1223,
		Beyond-Login-LoginSceneAnimCtrl-_ChangeToState0 = 1224,
		Beyond-Login-LoginSceneAnimCtrl-_ResetToA10 = 1225,
		Beyond-Login-LoginSceneAnimCtrl-_RandomIntervalA1s0 = 1226,
		Beyond-Login-LoginSceneAnimCtrl-_TransitionToA20 = 1227,
		Beyond-Login-LoginSceneAnimCtrl-_PlayA1A2Impl0 = 1228,
		Beyond-Login-LoginSceneAnimCtrl-_PlayA1sAndTriggerNext0 = 1229,
		Beyond-Login-LoginSceneAnimCtrl-OnValueChanged0 = 1230,
		Beyond-Login-LoginSceneAnimCtrl-Start0 = 1231,
		Beyond-Login-LoginSceneComponent-Start0 = 1232,
		Beyond-Login-LoginSceneAnimCtrl-Tick0 = 1233,
		Beyond-Login-LoginSceneAnimCtrl-OnRelease0 = 1234,
		Beyond-Login-LoginSceneAnimCtrl-GetAnimationClips0 = 1235,
		Beyond-Login-LoginSceneRoot-OnBindToManager0 = 1236,
		Beyond-Login-LoginAgeTipsDetailPanel-Init0 = 1237,
		Beyond-Login-LoginAgeTipsDetailPanel-_EventOnCloseClicked0 = 1238,
		Beyond-Login-LoginAgeTipsDetailPanel-OnValueChanged0 = 1239,
		Beyond-Login-LoginAgeTipsDetailPanel-_RenderContent0 = 1240,
		Beyond-Login-LoginAgeTipsDetailPanel-_SplitLicenseToSegments0 = 1241,
		Beyond-Login-LoginAgeTipsDetailPanel-_SplitLongString0 = 1242,
		Beyond-Login-LoginAgeTipsDetailPanel-_ShowContent0 = 1243,
		Beyond-Login-LoginAgeTipsPanel-OnInit0 = 1244,
		Beyond-Login-LoginAgeTipsPanel-_EventOnOpenAgeTipsClicked0 = 1246,
		Beyond-Login-LoginAgeTipsPanel-OnValueChanged0 = 1247,
		Beyond-Login-LoginAgeTipsPanel-_UpdateAgeTipsPolicy0 = 1248,
		Beyond-Login-LoginAlertDialog-OnInit0 = 1249,
		Beyond-Login-LoginAlertDialog-_OnConfirmClicked0 = 1250,
		Beyond-Login-LoginDecorateUI-OnValueChanged0 = 1251,
		Beyond-Login-LoginDecorateUI-_TriggerTrans2GSLoginImpl0 = 1252,
		Beyond-Login-LoginDecorateUI-Tick0 = 1253,
		Beyond-Login-LoginDecorateUI-_TimeManagerTick0 = 1254,
		Beyond-Login-LoginDecorateUI-OnRelease0 = 1255,
		Beyond-Login-LoginEnterGamePanel-_InitIfNot0 = 1256,
		Beyond-Login-LoginEnterGamePanel-_OnEnterGameClicked0 = 1257,
		Beyond-Login-LoginEnterGamePanel-OnValueChanged0 = 1258,
		Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByFadeSwitchTween0 = 1259,
		Beyond-Login-LoginGovTipsPanel-OnInit0 = 1262,
		Beyond-Login-LoginGovTipsPanel-_EventOnOpenAgeTipsClicked0 = 1263,
		Beyond-Login-LoginGovTipsPanel-OnValueChanged0 = 1264,
		Beyond-Login-LoginJudgeDialog-OnInit0 = 1265,
		Beyond-Login-LoginJudgeDialog-_OnPositiveClicked0 = 1266,
		Beyond-Login-LoginJudgeDialog-_OnNegativeClicked0 = 1267,
		Beyond-Login-LoginMenuPanel-OnInit0 = 1268,
		Beyond-Login-LoginMenuPanel-_OnAnnounceClicked0 = 1269,
		Beyond-Login-LoginMenuPanel-_OnAnnounceClosed0 = 1271,
		Beyond-Login-LoginMenuPanel-_OnSettingClicked0 = 1273,
		Beyond-Login-LoginMenuPanel-_OnResCheckClicked0 = 1275,
		Beyond-Login-LoginMenuPanel-_OnLogoutClicked0 = 1277,
		Beyond-Login-LoginMenuPanel-_OnQuitGameClicked0 = 1279,
		Beyond-Login-LoginMenuPanel-_OnLoginClicked0 = 1283,
		Beyond-Login-LoginMenuPanel-_OnQRClicked0 = 1284,
		Beyond-Login-LoginMenuPanel-_OnServerZoneBtnClicked0 = 1287,
		Beyond-Login-LoginMenuPanel-_OnFocusMenuGroup0 = 1289,
		Beyond-Login-LoginMenuPanel-OnValueChanged0 = 1290,
		Beyond-Login-LoginMenuPanel-_CanQRLogin0 = 1291,
		Beyond-Login-LoginMenuPanel-Awake0 = 1292,
		Beyond-Login-LoginMenuPanel-_UpdateServerZone0 = 1293,
		Beyond-Login-LoginMenuPanel-OnEnable0 = 1294,
		Beyond-Login-LoginMenuPanel-_OnRequestRelogin0 = 1295,
		Beyond-Login-LoginMenuPanel-_OnInputChanged0 = 1296,
		Beyond-Login-LoginMenuPanel-_OnUpdateRedDotForSDKListener0 = 1297,
		Beyond-Login-LoginMenuPanel-OnDisable0 = 1298,
		Beyond-Login-LoginMenuPanel-OnDestroy0 = 1299,
		Beyond-Login-LoginRootPanel-ChildPanel-OnDestroy0 = 1300,
		Beyond-Login-LoginMenuPanel-_OnCustomServiceClicked0 = 1301,
		Beyond-Login-LoginMenuPanel-_OnAccountCenterClicked0 = 1302,
		Beyond-Login-LoginMockUIDPanel-Refresh0 = 1303,
		Beyond-Login-LoginMockUIDPanel-_SmokeEnterGame0 = 1304,
		Beyond-Login-LoginMockUIDPanel-OnDestroy0 = 1305,
		Beyond-Login-LoginResourcePanel-OnValueChanged0 = 1306,
		Beyond-Login-LoginResourcePanel-_UpdateResourceInfo0 = 1307,
		Beyond-Login-LoginResourcePanel-Update0 = 1308,
		Beyond-Login-LoginRootPanel-Awake0 = 1309,
		Beyond-Login-LoginRootPanel-_OnNotchPaddingChanged0 = 1310,
		Beyond-Login-LoginRootPanel-OnDestroy0 = 1311,
		Beyond-Login-LoginRootPanel-ChildPanel-SetPanelVisibleByAnimSwitchTween0 = 1312,
		Beyond-Login-LoginServerSelectItemView-RefreshView0 = 1313,
		Beyond-Login-LoginServerSelectItemView-_OnClicked0 = 1314,
		Beyond-Login-LoginServerSelectItemView-NaviToBtnTarget0 = 1315,
		Beyond-Login-LoginServerSelectItemView-SetSelected0 = 1316,
		Beyond-Login-LoginServerSelectModel-InitData0 = 1317,
		Beyond-Login-LoginServerSelectPanel-OnInit0 = 1318,
		Beyond-Login-LoginServerSelectPanel-_OnConfirmClicked0 = 1319,
		Beyond-Login-LoginServerSelectPanel-_OnCloseClicked0 = 1320,
		Beyond-Login-LoginServerSelectPanel-_UpdateServerCell0 = 1321,
		Beyond-Login-LoginServerSelectPanel-OnDisable0 = 1322,
		Beyond-Login-LoginServerSelectPanel-_OnInputChanged0 = 1323,
		Beyond-Login-LoginServerSelectPanel-_NaviToSelectedItem0 = 1324,
		Beyond-Login-LoginServerSelectPanel-OnEnable0 = 1325,
		Beyond-Login-LoginServerSelectPanel-_WaitingForShowListAwake0 = 1329,
		Beyond-Login-LoginServerSelectPanel-_UpdateServerSelected0 = 1336,
		Beyond-Login-LoginServerSelectPanel-OnValueChanged0 = 1337,
		Beyond-Login-LoginVersionPanel-Start0 = 1338,
		Beyond-Login-LoginVersionPanel-get_displayGameVersion0 = 1339,
		Beyond-Login-LoginVocResSelDialog-OnInit0 = 1340,
		Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked1 = 1341,
		Beyond-Login-LoginVocResSelDialog-_OnConfirmClicked0 = 1342,
		Beyond-Login-LoginVocResSelDialog-_UpdateCell0 = 1343,
		Beyond-Login-LoginVocResSelItemView-RefreshView0 = 1344,
		Beyond-Login-LoginVocResSelItemView-_OnClicked0 = 1345,
		Beyond-Login-LoginVocResSelDialog-UpdateSelected0 = 1346,
		Beyond-Login-LoginVocResSelDialog-_UpdateList0 = 1347,
		Beyond-Login-LoginVocResSelDialog-_UpdateSelected0 = 1348,
		Beyond-Login-LoginVocResSelItemView-SetSelected0 = 1349,
		Beyond-Login-LoginVocResSelDialog-_NaviToSelectedItem0 = 1350,
		Beyond-Login-LoginVocResSelItemView-NaviToBtnTarget0 = 1351,
		Beyond-Login-LoginVocResSelDialog-OnEnable0 = 1352,
		Beyond-Login-LoginVocResSelDialog-_OnInputTypeChanged0 = 1353,
		Beyond-Login-LoginVocResSelDialog-OnDisable0 = 1354,
		Beyond-Scripts-Entry-WarmUpProgress-GetTotal0 = 1355,
		Beyond-Scripts-Entry-WarmUpProgress-GetCurrent0 = 1356,
		Beyond-Scripts-Entry-WarmUpProgress-GetInfo0 = 1357
	}
}
