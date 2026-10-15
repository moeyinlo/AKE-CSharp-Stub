/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Beyond;
using Beyond.Input;
using Beyond.PoolCore;
using Beyond.Resource;
using IFix.Core;
using Plugins.LibScePad;
using Rewired;
using Rewired.ControllerExtensions;
using Sirenix.OdinInspector;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 37: Input.Beyond.dll - Assembly: Input.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 85130-85362

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 85217
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_32 E680B0AF74F1D11AFCE59DFB222E2F946D48C66AE24640EE35784361EEA2E0C4; // 0x00 // Static value (base64): BwAAAAMAAAAFAAAABgAAAAEAAAACAAAABAAAAAAAAAA= - Metadata: 0x02644CC0

	// Nested types
	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 85216
	{
	}
}

namespace Beyond.Input
{
	public class NaviScope // TypeDefIndex: 85141
	{
		// Fields
		public readonly string key; // 0x10
		public readonly LinkedList<SelectableNaviGroup> layerStack; // 0x18
	
		// Constructors
		public NaviScope(string key); // 0x000000018497FD90-0x0000000184980400
	}

	public class ControllerNaviManager // TypeDefIndex: 85143
	{
		// Fields
		private const string DEFAULT_SCOPE_KEY = "__DefaultNaviScope"; // Metadata: 0x02644917
		public Selectable curTarget; // 0x10
		private readonly LinkedList<NaviScope> m_scopeStack; // 0x18
		private readonly Dictionary<string, NaviScope> m_scopesByKey; // 0x20
		private readonly Dictionary<int, NaviScope> m_panelScopes; // 0x28
		private readonly HashSet<string> m_naviLockSet; // 0x30
		private int m_targetInputBindingGroupId; // 0x38
		private int m_naviInputBindingGroupId; // 0x3C
		private Selectable m_lastEnableNaviTarget; // 0x40
		[CompilerGenerated]
		private NavigationBindingType _navigationBindingType_k__BackingField; // 0x48
		private Dictionary<NavigationBindingType, int> m_naviBindingGroupIds; // 0x50
		private Beyond.Input.InputManager m_inputManager; // 0x58
		private const float SCORE_OFFSET = 10000f; // Metadata: 0x0264492A
		[CompilerGenerated]
		private bool _forceEnableNaviForGuide_k__BackingField; // 0x60
	
		// Properties
		public NavigationBindingType navigationBindingType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
		public bool forceEnableNaviForGuide { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018226ED70-0x000000018226ED80
		public IReadOnlyCollection<NaviScope> scopeStack { get; } // 0x0000000184978610-0x0000000184978650 
		public IReadOnlyDictionary<string, NaviScope> registeredScopes { get; } // 0x00000001849785D0-0x0000000184978610 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 85142
		{
			// Fields
			public ControllerNaviManager __4__this; // 0x10
			public NaviDirection dir; // 0x18
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool __CreateNavigationBinding_b__0(bool isRepeat, bool allowFailureDelay); // 0x0000000184980400-0x0000000184980440
		}
	
		// Constructors
		public ControllerNaviManager(Beyond.Input.InputManager inputManager); // 0x000000018688CDB0-0x0000000186890090
	
		// Methods
		private void _CreateNavigationBinding(string actionId, NaviDirection dir, int groupId); // 0x000000018688CCA0-0x000000018688CDB0
		public void SetNaviBindingType(NavigationBindingType bindingType); // 0x000000018688CAC0-0x000000018688CCA0
		public void Tick(); // 0x00000001851DED20-0x00000001851DED50
		private NaviScope _GetTopScope(); // 0x0000000184975020-0x0000000184975640
		private SelectableNaviGroup _GetTopLayer(); // 0x00000001849744C0-0x0000000184975020
		private NaviScope _GetOrCreateScope(string key); // 0x0000000184973BE0-0x00000001849744C0
		private NaviScope _ResolveScopeForLayer(SelectableNaviGroup layer); // 0x00000001849771B0-0x0000000184978570
		public void PushScope(string key); // 0x0000000184970D30-0x0000000184971DA0
		[IDTag(1)]
		public void PopScope(string key); // 0x000000018496FE20-0x000000018496FE70
		[IDTag(0)]
		public void PopScope(string key, bool flushLayers); // 0x000000018496FE70-0x0000000184970D30
		public void RegisterPanelScope(int panelId, string key); // 0x0000000184971DA0-0x00000001849723E0
		public void UnregisterPanelScope(int panelId); // 0x00000001849723E0-0x0000000184972730
		public bool IsPanelScopeTop(int panelId); // 0x000000018496FAA0-0x000000018496FE20
		private void _FlushScopeLayers(NaviScope scope, bool silentMode); // 0x0000000184972730-0x0000000184973BE0
		private void _OnTopChanged(SelectableNaviGroup oldTopLayer); // 0x0000000184975E70-0x00000001849771B0
		private bool _RemoveLayer(SelectableNaviGroup group, SelectableNaviGroup curLayer); // 0x0000000185042890-0x0000000185042AB0
		private void _RemoveLayerFromStack(SelectableNaviGroup group, bool silentMode); // 0x0000000185043110-0x0000000185043320
		private void _SetTarget(Selectable target); // 0x0000000186A646E0-0x0000000186A647A0
		private void _OnLayerSelected(SelectableNaviGroup topLayer); // 0x000000018C26621C-0x000000018C266648
		private bool _DefaultNavigate(NaviDirection dir); // 0x000000018C2655D8-0x000000018C266014
		private Selectable _TryFindBestNaviTargetInGroup(SelectableNaviGroup group, Vector3 pos, Vector3 dir, double curMaxScore, out double maxScore); // 0x000000018C266648-0x000000018C2669F0
		private Selectable _TryFindBestNaviTarget(HashSet<Selectable> targets, Vector3 curPos, Vector3 dir, NaviStrategy strategy, double curMaxScore, out double maxScore); // 0x000000018C2669F0-0x000000018C267134
		private static Vector3 _GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir); // 0x000000018C266014-0x000000018C26621C
		public void SetForceEnableNavi(bool enable); // 0x000000018C26545C-0x000000018C2654D4
		public void UpdateNaviInputBindingState(); // 0x00000001851DCE60-0x00000001851DD130
		public bool IsNavigationBindingEnabled(); // 0x00000001851DD130-0x00000001851DD290
		public void TryRemoveLayer(SelectableNaviGroup group); // 0x0000000185043350-0x00000001850443C0
		public bool IsLayerInStack(SelectableNaviGroup group); // 0x0000000185042C40-0x0000000185042E70
		public bool IsLayerTracked(SelectableNaviGroup group); // 0x000000018496E9D0-0x000000018496FAA0
		public bool IsTopLayer(SelectableNaviGroup group); // 0x000000018714C840-0x000000018714CC40
		public void ChangeAndTrySetNaviBindingType(SelectableNaviGroup naviGroup, NavigationBindingType naviBindingType); // 0x000000018680E6B0-0x000000018680E700
		public void TryAutoSetTarget(); // 0x00000001869B6610-0x00000001869B6A10
		public void SetTarget(Selectable target); // 0x0000000186A62F60-0x0000000186A646E0
		public void ClearTargetForListWrap(); // 0x0000000184969D20-0x000000018496AD20
		private void _SetTargetFromNavigation(Selectable target); // 0x0000000184978570-0x00000001849785D0
		public void ClearTargetForPanel(int panelId); // 0x000000018496AD20-0x000000018496BD10
		public void ResetStateForUIDispose(); // 0x000000018C2651B0-0x000000018C26545C
		public bool IsNaviTarget(Selectable target); // 0x000000018C2650BC-0x000000018C265154
		public Vector3 GetNaviVector(NaviDirection dir); // 0x000000018C264F74-0x000000018C2650BC
		public void Navigate(NaviDirection dir); // 0x000000018C265154-0x000000018C2651B0
		private bool _Navigate(NaviDirection dir, bool isRepeat, bool allowFailureDelay); // 0x0000000184975640-0x0000000184975E70
		public void ToggleNavigation(string key, bool active); // 0x000000018C2654D4-0x000000018C2655D8
		public string DumpNaviState(); // 0x000000018496BD10-0x000000018496E9D0
	}

	public enum ActionOnSetNaviTarget // TypeDefIndex: 85144
	{
		None = 0,
		AutoTriggerOnClick = 1,
		PressConfirmTriggerOnClick = 2
	}

	public static class ControllerNaviUtils // TypeDefIndex: 85145
	{
	}

	public class PSTriggerEffectCfg : MonoBehaviour // TypeDefIndex: 85146
	{
		// Fields
		[SerializeField]
		public List<TriggerEffectCommandUnion> commands; // 0x18
	
		// Constructors
		public PSTriggerEffectCfg(); // 0x00000001878364A0-0x00000001878364B8
	}

	public enum KeyboardKeyCode // TypeDefIndex: 85147
	{
		None = 0,
		Backspace = 8,
		Tab = 9,
		Clear = 12,
		Return = 13,
		Pause = 19,
		EscapeOnly = 27,
		Space = 32,
		Exclaim = 33,
		DoubleQuote = 34,
		Hash = 35,
		Dollar = 36,
		Percent = 37,
		Ampersand = 38,
		Quote = 39,
		LeftParen = 40,
		RightParen = 41,
		Asterisk = 42,
		Plus = 43,
		Comma = 44,
		Minus = 45,
		Period = 46,
		Slash = 47,
		Alpha0 = 48,
		Alpha1 = 49,
		Alpha2 = 50,
		Alpha3 = 51,
		Alpha4 = 52,
		Alpha5 = 53,
		Alpha6 = 54,
		Alpha7 = 55,
		Alpha8 = 56,
		Alpha9 = 57,
		Colon = 58,
		Semicolon = 59,
		Less = 60,
		Equals = 61,
		Greater = 62,
		Question = 63,
		At = 64,
		LeftBracket = 91,
		Backslash = 92,
		RightBracket = 93,
		Caret = 94,
		Underscore = 95,
		BackQuote = 96,
		A = 97,
		B = 98,
		C = 99,
		D = 100,
		E = 101,
		F = 102,
		G = 103,
		H = 104,
		I = 105,
		J = 106,
		K = 107,
		L = 108,
		M = 109,
		N = 110,
		O = 111,
		P = 112,
		Q = 113,
		R = 114,
		S = 115,
		T = 116,
		U = 117,
		V = 118,
		W = 119,
		X = 120,
		Y = 121,
		Z = 122,
		LeftCurlyBracket = 123,
		Pipe = 124,
		RightCurlyBracket = 125,
		Tilde = 126,
		Delete = 127,
		Keypad0 = 256,
		Keypad1 = 257,
		Keypad2 = 258,
		Keypad3 = 259,
		Keypad4 = 260,
		Keypad5 = 261,
		Keypad6 = 262,
		Keypad7 = 263,
		Keypad8 = 264,
		Keypad9 = 265,
		KeypadPeriod = 266,
		KeypadDivide = 267,
		KeypadMultiply = 268,
		KeypadMinus = 269,
		KeypadPlus = 270,
		KeypadEnter = 271,
		KeypadEquals = 272,
		UpArrow = 273,
		DownArrow = 274,
		RightArrow = 275,
		LeftArrow = 276,
		Insert = 277,
		Home = 278,
		End = 279,
		PageUp = 280,
		PageDown = 281,
		F1 = 282,
		F2 = 283,
		F3 = 284,
		F4 = 285,
		F5 = 286,
		F6 = 287,
		F7 = 288,
		F8 = 289,
		F9 = 290,
		F10 = 291,
		F11 = 292,
		F12 = 293,
		F13 = 294,
		F14 = 295,
		F15 = 296,
		Numlock = 300,
		CapsLock = 301,
		ScrollLock = 302,
		RightShift = 303,
		LeftShift = 304,
		RightControl = 305,
		LeftControl = 306,
		RightAlt = 307,
		LeftAlt = 308,
		RightApple = 309,
		RightCommand = 309,
		RightMeta = 309,
		LeftApple = 310,
		LeftCommand = 310,
		LeftMeta = 310,
		LeftWindows = 311,
		RightWindows = 312,
		AltGr = 313,
		Help = 315,
		Print = 316,
		SysReq = 317,
		Break = 318,
		Menu = 319,
		Mouse0 = 323,
		Mouse1 = 324,
		Mouse2 = 325,
		Mouse3 = 326,
		Mouse4 = 327,
		Mouse5 = 328,
		Mouse6 = 329,
		EscapeWithRightMouse = 330
	}

	public enum GamepadKeyCode // TypeDefIndex: 85148
	{
		None = 0,
		LeftStickX = 1,
		LeftStickY = 2,
		LeftStickBtn = 3,
		RightStickX = 4,
		RightStickY = 5,
		RightStickBtn = 6,
		ArrowUp = 7,
		ArrowDown = 8,
		ArrowLeft = 9,
		ArrowRight = 10,
		A = 11,
		B = 12,
		X = 13,
		Y = 14,
		LB = 15,
		LT = 16,
		RB = 17,
		RT = 18,
		LeftMenuBtn = 19,
		RightMenuBtn = 20,
		Home = 21,
		TouchPanel = 22,
		LeftStickUp = 23,
		LeftStickDown = 24,
		LeftStickLeft = 25,
		LeftStickRight = 26,
		RightStickUp = 27,
		RightStickDown = 28,
		RightStickLeft = 29,
		RightStickRight = 30
	}

	public enum InputTimingType // TypeDefIndex: 85149
	{
		OnPress = 0,
		OnRelease = 1,
		OnClick = 2,
		OnLongPress = 3
	}

	public enum InputContinuousTriggerType // TypeDefIndex: 85150
	{
		NormalDelayAndLoopTime = 0,
		EveryTick = 1
	}

	public enum KeyboardType // TypeDefIndex: 85151
	{
		None = 0,
		Default = 1,
		QWERTZ = 2,
		AZERTY = 3
	}

	internal abstract class GamepadCheckerBase // TypeDefIndex: 85154
	{
		// Fields
		protected Beyond.Input.InputManager m_inputManager; // 0x10
		protected DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> m_normalBindingInfos; // 0x18
		protected DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>>> m_modifyBindingInfos; // 0x20
		protected HashSet<GamepadKeyCode> m_usedKeyCache; // 0x28
		protected List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x30
	
		// Properties
		internal DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> normalBindingInfos { get; } // 0x000000018C268F04-0x000000018C268F44 
		internal DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>>> modifyBindingInfos { get; } // 0x000000018C268EC4-0x000000018C268F04 
	
		// Nested types
		public class Binding // TypeDefIndex: 85152
		{
			// Fields
			public InputBindingInfo info; // 0x10
			public float pressDownTime; // 0x18
			public bool isUsedForBlock; // 0x1C
			public bool isCommonOpenUIAction; // 0x1D
			public int longPressTimerId; // 0x20
			public float longPressTime; // 0x24
			public bool enableContinuousTrigger; // 0x28
			public InputContinuousTriggerType continuousTriggerType; // 0x2C
			public float maxClickPressTime; // 0x30
	
			// Constructors
			public Binding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x02644A5E */); // 0x000000018568F800-0x000000018568F910
		}
	
		public enum TriggerType // TypeDefIndex: 85153
		{
			NORMAL = 0,
			CONTINUOUS = 1,
			STOP_CONTINUOUS = 2
		}
	
		// Constructors
		internal GamepadCheckerBase(Beyond.Input.InputManager inputManager); // 0x000000018663A9C0-0x000000018663AB70
	
		// Methods
		public virtual Binding OnCreateBinding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x02644A5D */); // 0x000000018568F3A0-0x000000018568F720
		public virtual Binding OnDeleteBinding(GamepadInput input, InputBindingInfo info); // 0x00000001851DB380-0x00000001851DB630
		public bool HasEnabledBinding(GamepadKeyCode key, GamepadKeyCode modifyKey); // 0x000000018C268A24-0x000000018C268C64
		protected DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> GetInputDic(GamepadInput input); // 0x000000018568F720-0x000000018568F800
		public virtual void CheckGamepadInput(); // 0x000000018C2688E0-0x000000018C268A24
		protected virtual void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x000000018C26889C-0x000000018C2688E0
		public virtual void TriggerActions(); // 0x000000018C268C64-0x000000018C268EC4
	}

	internal class GamepadChecker : GamepadCheckerBase // TypeDefIndex: 85155
	{
		// Fields
		private Func<GamepadKeyCode, bool> m_checkFunc; // 0x38
		[CompilerGenerated]
		private bool _isPressChecker_k__BackingField; // 0x40
	
		// Properties
		public bool isPressChecker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
	
		// Constructors
		public GamepadChecker(Func<GamepadKeyCode, bool> checkFunc, bool isPress, Beyond.Input.InputManager inputManager); // 0x000000018663ACD0-0x000000018663AD20
	
		// Methods
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x000000018C268F44-0x000000018C269570
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1); // 0x000000018C269570-0x000000018C269578
	}

	internal class GamepadOnClickChecker : GamepadCheckerBase // TypeDefIndex: 85156
	{
		// Constructors
		internal GamepadOnClickChecker(Beyond.Input.InputManager inputManager); // 0x000000018783C570-0x000000018783C578
	
		// Methods
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x000000018C269578-0x000000018C269CFC
		public void ClearKeyPressed(GamepadKeyCode keyCode); // 0x000000018C269CFC-0x000000018C26A10C
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1); // 0x000000018C269570-0x000000018C269578
	}

	internal class GamepadOnLongPressChecker : GamepadCheckerBase // TypeDefIndex: 85158
	{
		// Fields
		private Action<GamepadKeyCode> m_onTriggerOnLongPress; // 0x38
		private Dictionary<GamepadInput, HashSet<Binding>> m_bindings; // 0x40
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 85157
		{
			// Fields
			public GamepadOnLongPressChecker __4__this; // 0x10
			public GamepadCheckerBase.Binding binding; // 0x18
			public GamepadKeyCode keyCode; // 0x20
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _CreateTriggerBindingAction_b__0(); // 0x000000018C2773B8-0x000000018C2773E4
		}
	
		// Constructors
		public GamepadOnLongPressChecker(Action<GamepadKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager); // 0x000000018663A860-0x000000018663A910
	
		// Methods
		public Action CreateTriggerBindingAction(Binding binding, GamepadKeyCode keyCode); // 0x000000018C26A7F0-0x000000018C26A8F4
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x000000018C26A10C-0x000000018C26A7F0
		private void _OnTriggerBinding(Binding binding, GamepadKeyCode keyCode); // 0x000000018C26AB18-0x000000018C26AFBC
		public override Binding OnCreateBinding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x02644A62 */); // 0x0000000186733810-0x0000000186733970
		public override Binding OnDeleteBinding(GamepadInput input, InputBindingInfo info); // 0x0000000186733710-0x0000000186733810
		public void CancelPendingLongPress(InputBindingInfo info); // 0x00000001851DB630-0x00000001851DB8D0
		public float GetInputLongPressStartTime(GamepadInput input, int bindingId = 0 /* Metadata: 0x02644A63 */); // 0x000000018C26A8F4-0x000000018C26AB00
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1); // 0x000000018C269570-0x000000018C269578
		public Binding __iFixBaseProxy_OnCreateBinding(GamepadInput P0, InputBindingInfo P1, bool P2); // 0x000000018C26AB00-0x000000018C26AB10
		public Binding __iFixBaseProxy_OnDeleteBinding(GamepadInput P0, InputBindingInfo P1); // 0x000000018C26AB10-0x000000018C26AB18
	}

	internal class GamepadOnReleaseChecker : GamepadCheckerBase // TypeDefIndex: 85159
	{
		// Fields
		private readonly Func<GamepadKeyCode, bool> m_checkFunc; // 0x38
		internal readonly Dictionary<GamepadKeyCode, HashSet<GamepadKeyCode>> m_modifyBindingPressedDic; // 0x40
	
		// Constructors
		public GamepadOnReleaseChecker(Func<GamepadKeyCode, bool> checkFunc, Beyond.Input.InputManager inputManager); // 0x000000018663A910-0x000000018663A9C0
	
		// Methods
		public override void CheckGamepadInput(); // 0x000000018C26B608-0x000000018C26BBB8
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x000000018C26AFBC-0x000000018C26B608
		[CompilerGenerated]
		private bool _CheckGamepadInput_b__3_0(GamepadKeyCode keyCode); // 0x000000018C26BBB8-0x000000018C26BBE0
		public void __iFixBaseProxy_CheckGamepadInput(); // 0x000000018C26BBE0-0x000000018C26BBE8
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1); // 0x000000018C269570-0x000000018C269578
	}

	[AddComponentMenu("Input/HG Virtual Mouse")]
	public class HGVirtualMouse : MonoBehaviour // TypeDefIndex: 85162
	{
		// Fields
		private const float STANDARD_SCREEN_WIDTH = 1920f; // Metadata: 0x02644A65
		public bool keepMousePosOnEnable; // 0x18
		[SerializeField]
		[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see \'Cursor Mode\'). Moving the cursor updates the anchored position of the transform.")]
		private RectTransform m_CursorTransform; // 0x20
		[SerializeField]
		private Animator m_animator; // 0x28
		[Header("Motion")]
		public float currentCursorSpeed; // 0x30
		[Header("Motion")]
		public float currentCursorAcc; // 0x34
		[SerializeField]
		public List<CursorSpeedPhase> speedPhaseList; // 0x38
		[SerializeField]
		public List<CursorSpeedPhase> hoverSpeedPhaseList; // 0x40
		[SerializeField]
		public List<CursorSpeedPhase> secondHoverSpeedPhaseList; // 0x48
		[SerializeField]
		[Tooltip("Scale factor to apply to \'Scroll Wheel Action\' when setting the mouse \'scrollWheel\' control.")]
		private float m_ScrollSpeed; // 0x50
		[SerializeField]
		[Space(10f)]
		[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
		private InputActionProperty m_StickAction; // 0x58
		[SerializeField]
		[Tooltip("Button action that triggers a left-click on the mouse.")]
		private InputActionProperty m_LeftButtonAction; // 0x70
		[SerializeField]
		[Tooltip("Button action that triggers a middle-click on the mouse.")]
		private InputActionProperty m_MiddleButtonAction; // 0x88
		[SerializeField]
		[Tooltip("Button action that triggers a right-click on the mouse.")]
		private InputActionProperty m_RightButtonAction; // 0xA0
		[SerializeField]
		[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
		private InputActionProperty m_ForwardButtonAction; // 0xB8
		[SerializeField]
		[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
		private InputActionProperty m_BackButtonAction; // 0xD0
		[SerializeField]
		[Tooltip("Vector2 action that feeds into the mouse \'scrollWheel\' action (scaled by \'Scroll Speed\').")]
		private InputActionProperty m_ScrollWheelAction; // 0xE8
		[SerializeField]
		private RectTransform _canvasTransform; // 0x100
		private UnityEngine.InputSystem.Mouse m_VirtualMouse; // 0x108
		private UnityEngine.InputSystem.Mouse m_SystemMouse; // 0x110
		private Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate; // 0x118
		private double m_LastTime; // 0x120
		private Vector2 m_LastStickValue; // 0x128
		private float m_lastDisabledTime; // 0x130
		[SerializeField]
		private float _resetCursorPosMinInterval; // 0x134
		[NonSerialized]
		public int leftBtnBindingGroupId; // 0x138
		[NonSerialized]
		public int leftBtnPressBindingId; // 0x13C
		[NonSerialized]
		public int leftBtnReleaseBindingId; // 0x140
		private HashSet<Selectable> m_hoverTargets; // 0x148
		[CompilerGenerated]
		private bool _isHoverOn_k__BackingField; // 0x150
		private bool m_usingHoverSpd; // 0x151
		private int m_encounterHoverCount; // 0x154
		private float m_animatorHoverValue; // 0x158
		private bool m_isIdle; // 0x15C
		[SerializeField]
		private float _hoverAnimationChangeSpeed; // 0x160
		[CompilerGenerated]
		private bool _mouseIconVisible_k__BackingField; // 0x164
		private CanvasGroup m_iconCanvasGroup; // 0x168
	
		// Properties
		public RectTransform cursorTransform { get; set; } // 0x000000018C26DF8C-0x000000018C26DFCC 0x000000018C26E3BC-0x000000018C26E3FC
		public float scrollSpeed { get; set; } // 0x000000018C26E168-0x000000018C26E1AC 0x000000018C26E804-0x000000018C26E848
		public UnityEngine.InputSystem.Mouse virtualMouse { get; } // 0x000000018C26E274-0x000000018C26E2B8 
		public InputActionProperty stickAction { get; set; } // 0x000000018C26E214-0x000000018C26E274 0x000000018C26E8C4-0x000000018C26E93C
		public InputActionProperty leftButtonAction { get; set; } // 0x000000018C26E034-0x000000018C26E098 0x000000018C26E500-0x000000018C26E5FC
		public InputActionProperty rightButtonAction { get; set; } // 0x000000018C26E100-0x000000018C26E168 0x000000018C26E700-0x000000018C26E804
		public InputActionProperty middleButtonAction { get; set; } // 0x000000018C26E098-0x000000018C26E100 0x000000018C26E5FC-0x000000018C26E700
		public InputActionProperty forwardButtonAction { get; set; } // 0x000000018C26DFCC-0x000000018C26E034 0x000000018C26E3FC-0x000000018C26E500
		public InputActionProperty backButtonAction { get; set; } // 0x000000018C26DF24-0x000000018C26DF8C 0x000000018C26E2B8-0x000000018C26E3BC
		public InputActionProperty scrollWheelAction { get; set; } // 0x000000018C26E1AC-0x000000018C26E214 0x000000018C26E848-0x000000018C26E8C4
		public bool isHoverOn { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187250B80-0x0000000187250B90 0x0000000187250BA0-0x0000000187250BB0
		public bool mouseIconVisible { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187250B90-0x0000000187250BA0 0x0000000187250BB0-0x0000000187250BC0
	
		// Nested types
		[Serializable]
		public class CursorSpeedPhase // TypeDefIndex: 85160
		{
			// Fields
			public float maxJsValue; // 0x10
			public float minSpeed; // 0x14
			public float maxSpeed; // 0x18
			public float acceleration; // 0x1C
			public float accelerationSpeed; // 0x20
			public float maxAcceleration; // 0x24
	
			// Constructors
			public CursorSpeedPhase(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85161
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Selectable> __9__78_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C2773E4-0x000000018C277480
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ChangeHoverState_b__78_0(Selectable o); // 0x000000018C27736C-0x000000018C2773B8
		}
	
		// Constructors
		public HGVirtualMouse(); // 0x0000000186DD9400-0x0000000186DD9590
	
		// Methods
		protected void OnEnable(); // 0x000000018C26C634-0x000000018C26CDB4
		protected void OnDisable(); // 0x000000018C26C2A4-0x000000018C26C634
		private void _UpdateMotion(); // 0x000000018C26D68C-0x000000018C26DF24
		private void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context); // 0x000000018C26D120-0x000000018C26D344
		public void TriggerLeftButton(bool isPressed); // 0x000000018C26CE28-0x000000018C26CF68
		public void ClearLeftButtonState(); // 0x000000018C26BEA0-0x000000018C26BFA4
		private static void _SetActionCallback(InputActionProperty field, Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x02644A64 */); // 0x000000018C26D344-0x000000018C26D404
		private static void _SetAction(ref InputActionProperty field, InputActionProperty value); // 0x000000018C26D404-0x000000018C26D554
		public void OnAfterInputUpdate(); // 0x000000018C26C140-0x000000018C26C178
		private void Update(); // 0x000000018C26CF80-0x000000018C26D0CC
		public void ChangeHoverState(Selectable target, bool isHoverOn); // 0x000000018C26BC80-0x000000018C26BEA0
		private void _ChangeHoverState(bool isHoverOn); // 0x000000018C26D0CC-0x000000018C26D120
		public Selectable GetCurHoverSelectable(); // 0x000000018C26BFA4-0x000000018C26C140
		private void OnDestroy(); // 0x000000018C26C178-0x000000018C26C2A4
		private void _SyncScale(); // 0x000000018C26D554-0x000000018C26D68C
		private void Awake(); // 0x000000018C26BBE8-0x000000018C26BC80
		public void SetMouseIconVisible(bool active); // 0x000000018C26CDB4-0x000000018C26CE28
		[CompilerGenerated]
		private void _OnEnable_b__32_0(); // 0x000000018C26CF68-0x000000018C26CF74
		[CompilerGenerated]
		private void _OnEnable_b__32_1(); // 0x000000018C26CF74-0x000000018C26CF80
	}

	internal static class InputBindingStateField // TypeDefIndex: 85163
	{
		// Methods
		internal static void Set(ref bool field, bool value); // 0x000000018497C9C0-0x000000018497CD70
	}

	[Serializable]
	public class InputBindingInfo // TypeDefIndex: 85167
	{
		// Fields
		private static uint s_nextEnabledPriority; // 0x00
		[CompilerGenerated]
		private readonly int _id_k__BackingField; // 0x10
		private Func<bool, bool, bool> m_callback; // 0x18
		private object m_callbackTarget; // 0x20
		[CompilerGenerated]
		private InputBindingGroup _group_k__BackingField; // 0x28
		public string playerActionId; // 0x30
		[CompilerGenerated]
		private bool _shouldShowControllerHint_k__BackingField; // 0x38
		[CompilerGenerated]
		private int _controllerHintPriority_k__BackingField; // 0x3C
		[CompilerGenerated]
		private bool _isCommonOpenUIAction_k__BackingField; // 0x40
		private bool m_selfEnabled; // 0x41
		private bool m_groupEnabled; // 0x42
		private bool m_parentIgnored; // 0x43
		private bool m_forceKeyhintToGrayState; // 0x44
		[CompilerGenerated]
		private uint _enabledPriority_k__BackingField; // 0x48
		[CompilerGenerated]
		private int _actionPriority_k__BackingField; // 0x4C
		private IBindingView m_bindingView; // 0x50
		private string m_text; // 0x58
		public static float s_continuousTriggerFirstDelayTime; // 0x04
		public static float s_continuousTriggerLoopDelayTime; // 0x08
		public static float s_continuousTriggerLoopQuickDelayTime; // 0x0C
		public static float s_repeatFailureMaxDelayTime; // 0x10
		private int m_continuousTriggerTimerId; // 0x60
		private uint m_continuousTriggerVersion; // 0x64
	
		// Properties
		public int id { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public InputBindingGroup group { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public bool shouldShowControllerHint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public int controllerHintPriority { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226F000-0x000000018226F010 0x000000018226F010-0x000000018226F020
		public bool isCommonOpenUIAction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public bool selfEnabled { get; private set; } // 0x000000018C26F048-0x000000018C26F080 0x000000018C26F148-0x000000018C26F18C
		public bool groupEnabled { get; private set; } // 0x000000018C26EFD8-0x000000018C26F010 0x000000018C26F0C0-0x000000018C26F104
		public bool enabled { get; } // 0x00000001853A98B0-0x00000001853A9950 
		public bool parentIgnored { get; private set; } // 0x000000018C26F010-0x000000018C26F048 0x000000018C26F104-0x000000018C26F148
		public bool forceKeyhintToGrayState { get; set; } // 0x000000018497C930-0x000000018497C970 0x000000018497C970-0x000000018497C9C0
		public uint enabledPriority { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
		public int actionPriority { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233730-0x0000000187233740 0x0000000187233740-0x0000000187233750
		public IBindingView bindingView { get; set; } // 0x0000000185641650-0x00000001856416D0 0x000000018C26F080-0x000000018C26F0C0
		public string text { get; set; } // 0x0000000185641390-0x0000000185641460 0x000000018C26F18C-0x000000018C26F1CC
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0 // TypeDefIndex: 85164
		{
			// Fields
			public Action callback; // 0x10
	
			// Constructors
			public __c__DisplayClass61_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool __WrapCallback_b__0(bool isRepeat, bool allowFailureDelay); // 0x0000000184980440-0x0000000184980460
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 85165
		{
			// Fields
			public InputBindingInfo __4__this; // 0x10
			public uint version; // 0x18
			public InputContinuousTriggerType continuousTriggerType; // 0x1C
			public bool isNewPress; // 0x20
			public Action __9__4; // 0x28
			public Action __9__3; // 0x30
			public Action __9__2; // 0x38
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __ScheduleContinuousTrigger_b__0(); // 0x0000000184980460-0x00000001849817D0
			internal void __ScheduleContinuousTrigger_b__2(); // 0x0000000184981820-0x0000000184982B80
			internal void __ScheduleContinuousTrigger_b__3(); // 0x0000000184982B80-0x0000000184983EE0
			internal void __ScheduleContinuousTrigger_b__4(); // 0x0000000184983EE0-0x0000000184984220
			internal void __ScheduleContinuousTrigger_b__1(); // 0x00000001849817D0-0x0000000184981820
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0 // TypeDefIndex: 85166
		{
			// Fields
			public InputBindingInfo __4__this; // 0x10
			public int timerId; // 0x18
			public uint version; // 0x1C
			public InputContinuousTriggerType continuousTriggerType; // 0x20
	
			// Constructors
			public __c__DisplayClass76_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __StartRepeatFailureDelay_b__0(); // 0x0000000184984220-0x0000000184984650
		}
	
		// Constructors
		public InputBindingInfo(int id, InputBindingGroup group, Action callback, string playerActionId, PlayerActionInfo actionInfo); // 0x00000001862A4420-0x00000001862A44C0
		public InputBindingInfo(int id, InputBindingGroup group, Func<bool, bool, bool> callback, string playerActionId, PlayerActionInfo actionInfo); // 0x000000018497C8E0-0x000000018497C930
		private InputBindingInfo(int id, InputBindingGroup group, Func<bool, bool, bool> callback, object callbackTarget, string playerActionId, PlayerActionInfo actionInfo); // 0x000000018497C380-0x000000018497C8E0
		static InputBindingInfo(); // 0x00000001871C1420-0x00000001871C14B0
	
		// Methods
		private static uint _GetNextEnabledPriority(); // 0x00000001862A57E0-0x00000001862A5840
		private static Func<bool, bool, bool> _WrapCallback(Action callback); // 0x000000018497B9B0-0x000000018497C380
		public void ChangeGroup(InputBindingGroup newGroup); // 0x000000018C26EC10-0x000000018C26EC88
		public void SetSelfEnabled(bool value); // 0x0000000185043070-0x0000000185043110
		public void OnGroupEnabledChanged(bool value, bool silent = false /* Metadata: 0x02644A69 */); // 0x00000001851DCCC0-0x00000001851DCE60
		public void SetParentIgnored(bool value); // 0x000000018C26ECC8-0x000000018C26ED9C
		public void Trigger(); // 0x0000000185E05150-0x0000000185E05190
		public void StartContinuousTrigger(InputContinuousTriggerType continuousTriggerType); // 0x000000018C26ED9C-0x000000018C26EE48
		private void _ScheduleContinuousTrigger(uint version, InputContinuousTriggerType continuousTriggerType, bool isNewPress); // 0x00000001849796E0-0x000000018497A7D0
		private bool _TryContinuousTrigger(uint version, bool isRepeat, InputContinuousTriggerType continuousTriggerType, float triggerDelayTime, bool allowFailureDelay = true /* Metadata: 0x02644A6A */); // 0x000000018497A7D0-0x000000018497B9B0
		private void _StartRepeatFailureDelay(uint currentVersion, InputContinuousTriggerType continuousTriggerType, float delayTime); // 0x000000018C26EE48-0x000000018C26EFD8
		public void StopContinuousTrigger(); // 0x00000001852361E0-0x0000000185236280
		private bool _RealTriggerCallback(bool isRepeat, bool allowFailureDelay); // 0x0000000184978DE0-0x00000001849796E0
		public void OnDelete(); // 0x000000018568FB80-0x000000018568FC00
		public object GetCallbackTarget(); // 0x000000018C26EC88-0x000000018C26ECC8
	}

	[Serializable]
	public class InputBindingGroup // TypeDefIndex: 85168
	{
		// Fields
		[CompilerGenerated]
		private readonly int _id_k__BackingField; // 0x10
		private bool m_selfEnabled; // 0x14
		private bool m_parentEnabled; // 0x15
		private bool m_parentIgnored; // 0x16
		[CompilerGenerated]
		private InputBindingGroup _parent_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly LinkedList<InputBindingGroup> _subGroups_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly LinkedList<InputBindingInfo> _subInfos_k__BackingField; // 0x28
		private IBindingView m_groupView; // 0x30
		private IBindingGroupTarget m_groupTarget; // 0x38
	
		// Properties
		public int id { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public bool selfEnabled { get; private set; } // 0x000000018C26EA8C-0x000000018C26EAC4 0x000000018C26EBCC-0x000000018C26EC10
		public bool parentEnabled { get; private set; } // 0x000000018C26EA1C-0x000000018C26EA54 0x000000018C26EB44-0x000000018C26EB88
		public bool enabled { get; } // 0x00000001851DE580-0x00000001851DE5C0 
		public bool parentIgnored { get; private set; } // 0x000000018C26EA54-0x000000018C26EA8C 0x000000018C26EB88-0x000000018C26EBCC
		public InputBindingGroup parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public LinkedList<InputBindingGroup> subGroups { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		public LinkedList<InputBindingInfo> subInfos { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		public IBindingView groupView { get; set; } // 0x00000001856416D0-0x0000000185641740 0x000000018C26EB04-0x000000018C26EB44
		public IBindingGroupTarget groupTarget { get; set; } // 0x000000018C26E9C0-0x000000018C26EA1C 0x000000018C26EAC4-0x000000018C26EB04
		public bool targetActiveInHierarchy { get; } // 0x0000000184978650-0x0000000184978DE0 
	
		// Constructors
		public InputBindingGroup(int id, InputBindingGroup parent); // 0x00000001851DC690-0x00000001851DC870
	
		// Methods
		public void ChangeParent(InputBindingGroup newParent); // 0x000000018663C5D0-0x000000018663C630
		public void SetSelfEnabled(bool value); // 0x00000001851DE5C0-0x00000001851DE880
		public void SetParentIgnored(bool value, bool silent = false /* Metadata: 0x02644A6B */); // 0x0000000186843200-0x0000000186843260
		public void OnParentEnabledChanged(bool value, bool silent = false /* Metadata: 0x02644A6C */); // 0x00000001851DDAD0-0x00000001851DDB80
		private void _OnBindingGroupStateChanged(bool silent = false /* Metadata: 0x02644A6D */); // 0x00000001851DD790-0x00000001851DDAD0
	}

	public class InputBindingGroupMonoTarget : MonoBehaviour, IBindingGroupTarget // TypeDefIndex: 85169
	{
		// Fields
		private int m_groupId; // 0x18
		private bool m_init; // 0x1C
		private bool m_internalEnabled; // 0x1D
		[CompilerGenerated]
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x20
	
		// Properties
		public int groupId { get; } // 0x0000000185040BE0-0x0000000185040C20 
		public bool groupEnabled { get; } // 0x0000000186963AA0-0x0000000186963B30 
		public InputBindingGroupMonoTarget parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public IBindingGroupTarget parentTarget { get; } // 0x000000018C26E980-0x000000018C26E9C0 
		[Tooltip("\u65E5\u5E38\u5927\u5BB6\u7528\u7EC4\u4EF6\u672C\u8EAB\u7684enabled\u5C31\u53EF\u4EE5\u4E86\u3002\u8FD9\u4E2A\u503C\u662F\u56E0\u4E3A\u6709\u7684\u903B\u8F91\u8FD8\u8981\u5728\u7EC4\u4EF6enable\u7684\u65F6\u5019\u5C4F\u853D\u8F93\u5165\uFF0C\u6240\u4EE5\u989D\u5916\u63D0\u4F9B\u4E86\u8FD9\u4E2A\u3002\u6BD4\u5982UI\u9762\u677F\u7684\u906E\u6321\u903B\u8F91\u5C31\u4F1A\u7528\u8FD9\u4E2A\u503C\uFF0C\u539F\u672C\u7684\u7EC4\u4EF6enable\u4F1A\u7559\u7ED9\u9762\u677F\u81EA\u5DF1\u7684\u903B\u8F91\u53BB\u63A7\u5236\u3002")]
		public bool internalEnabled { get; set; } // 0x000000018C26E93C-0x000000018C26E980 0x0000000185040FC0-0x0000000185041000
	
		// Constructors
		public InputBindingGroupMonoTarget(); // 0x000000018669E6D0-0x000000018669E700
	
		// Methods
		public void Init(); // 0x0000000185040C20-0x0000000185040EB0
		public void UpdateState(); // 0x0000000185041060-0x0000000185041150
		public void DeleteGroup(); // 0x0000000185040B70-0x0000000185040BE0
		private void Awake(); // 0x0000000185040B40-0x0000000185040B70
		private void OnEnable(); // 0x0000000185041030-0x0000000185041060
		private void OnDisable(); // 0x0000000185041000-0x0000000185041030
		private void OnDestroy(); // 0x0000000185040B10-0x0000000185040B40
	}

	public interface IBindingGroupTarget // TypeDefIndex: 85170
	{
		// Properties
		int groupId { get; }
		IBindingGroupTarget parentTarget { get; }
		bool groupEnabled { get; }
	}

	public interface IBindingTarget // TypeDefIndex: 85171
	{
		// Properties
		int bindingId { get; }
		IBindingGroupTarget parentTarget { get; }
		bool bindingEnabled { get; }
	}

	public enum BindingViewState // TypeDefIndex: 85172
	{
		Normal = 0,
		Disabled = 1,
		Hide = 2
	}

	public enum BindingViewActionType // TypeDefIndex: 85173
	{
		Default = 0,
		ButtonClick = 1,
		ButtonLongPress = 2,
		ButtonPressStart = 3,
		ButtonPressEnd = 4,
		ButtonDoubleClick = 5,
		SliderAdd = 6,
		SliderReduce = 7,
		SliderStick = 8,
		SliderLeftStick = 9
	}

	public interface IBindingView // TypeDefIndex: 85174
	{
		// Properties
		string bindingViewActionId { get; }
		string bindingViewLabelText { get; }
		DisposedUnityEvent bindingViewUpdateEvent { get; }
		bool interactable { get; }
		RectTransform redDotTrans { get; }
		bool bindingEnabled { get; }
		BindingViewState bindingViewState { get; }
	
		// Methods
		string GetBindingViewActionId(BindingViewActionType actionType);
		void OnInputKeyDown(bool isActionTrigger);
		void OnInputKeyUp(bool isActionTrigger);
	}

	public enum InputSettingLevel // TypeDefIndex: 85175
	{
		Default = 0,
		Custom = 1,
		Pending = 2
	}

	public class InputManager : Singleton<Beyond.Input.InputManager>, IDisposable // TypeDefIndex: 85182
	{
		// Fields
		public static float s_longPressTime; // 0x00
		public static float s_maxClickPressTime; // 0x04
		private static Dictionary<Beyond.Input.KeyboardKeyCode, string> s_keyboardKeyCode2StringDict; // 0x08
		private static Dictionary<GamepadKeyCode, string> s_gamepadKeyCode2StringDict; // 0x10
		public MultiAction onKeyboardTypeChange; // 0x10
		public bool enableController; // 0x18
		public bool enableMarketingCamera; // 0x19
		private int m_nextInputId; // 0x1C
		private int m_nextGroupId; // 0x20
		private InputBindingGroup m_rootGroup; // 0x28
		private Dictionary<int, InputBindingGroup> m_groups; // 0x30
		private Dictionary<int, InputBindingInfo> m_bindingInfos; // 0x38
		private Dictionary<string, HashSet<int>> m_action2BindingDic; // 0x40
		private KeyboardChecker m_onPressKeyboardChecker; // 0x48
		private KeyboardChecker m_onReleaseKeyboardChecker; // 0x50
		private KeyboardOnClickChecker m_onClickKeyboardChecker; // 0x58
		private KeyboardOnLongPressChecker m_onLongPressKeyboardChecker; // 0x60
		private GamepadChecker m_onPressGamepadChecker; // 0x68
		private GamepadOnReleaseChecker m_onReleaseGamepadChecker; // 0x70
		private GamepadOnClickChecker m_onClickGamepadChecker; // 0x78
		private GamepadOnLongPressChecker m_onLongPressGamepadChecker; // 0x80
		private RealCursorManager m_realCursorManager; // 0x88
		public static MultiAction<Rewired.Joystick, Beyond.DeviceInfo.ControllerType> onJoystickChanged; // 0x18
		[CompilerGenerated]
		private Rewired.Joystick _joystick_k__BackingField; // 0x90
		[CompilerGenerated]
		private IGamepadTemplate _gamepadTemplate_k__BackingField; // 0x98
		[CompilerGenerated]
		private IDualShock4Extension _gamepadDualShock4Extension_k__BackingField; // 0xA0
		private int m_touchPanelBtnIndex; // 0xA8
		private int m_leftMenuBtnIndex; // 0xAC
		private KeyboardHandler m_keyboardHandler; // 0xB0
		private KeyCaches m_keyCaches; // 0xB8
		private TickFunction m_lateTickFunction; // 0xC0
		public MultiAction onInputLateTick; // 0xC8
		public Action beforeCheckInput; // 0xD0
		public Action afterCheckInput; // 0xD8
		public bool trimNonTargetInputChecks; // 0xE0
		public bool commonOpenUIActionTriggered; // 0xE1
		public bool disableChangeInputDeviceCheck; // 0xE2
		public bool needProcessTryChange; // 0xE3
		[CompilerGenerated]
		private bool _inChangingInputDevice_k__BackingField; // 0xE4
		private bool m_suppressActionsForDeviceSwitch; // 0xE5
		private int m_suppressFramesRemaining; // 0xE8
		private const int DEVICE_SWITCH_SUPPRESS_FRAMES = 3; // Metadata: 0x02644A91
		private bool m_lastAnyOtherDeviceKey; // 0xEC
		private int m_controllerForbidClickBindingId; // 0xF0
		private bool m_ignoreFirstMouseUpOnFocusBack; // 0xF4
		private static readonly Beyond.Input.KeyboardKeyCode[] S_CACHED_KEYBOARD_KEY_CODES; // 0x20
		private static bool s_autoUpdateInputBindingMask; // 0x28
		private bool m_hasFocusedInputFiled; // 0xF5
		private const float STICK_DEAD_ZONE_MAGNITUDE = 0.2f; // Metadata: 0x02644A92
		private const float STICK_MIN_VALUE = 0.4f; // Metadata: 0x02644A96
		private const float STICK_DEAD_ZONE_SQRT_MAGNITUDE = 0.040000003f; // Metadata: 0x02644A9A
		[CompilerGenerated]
		private int _bindingStateVersion_k__BackingField; // 0xF8
		private IAssetLoader m_assetLoader; // 0x100
		private SerializeFieldDictionary<string, PlayerActionInfo> m_defaultSetting; // 0x108
		private SerializeFieldDictionary<string, PlayerActionInfo> m_customSetting; // 0x110
		private SerializeFieldDictionary<string, PlayerActionInfo> m_pendingSetting; // 0x118
		private InputRebindConfig m_rebindConfig; // 0x120
		private Dictionary<string, InputRebindActionScopeConfig> m_rebindActionScopeConfigs; // 0x128
		private Dictionary<string, PlayerActionInfo> m_anonymousActionInfos; // 0x130
		private int m_nextAnonymousPlayerActionId; // 0x138
		private const string INPUT_MANAGER_CANVAS_PREFAB_PATH = "Assets/Beyond/InitialAssets/Prefabs/Common/InputManagerCanvas.prefab"; // Metadata: 0x02644A9E
		[CompilerGenerated]
		private HGVirtualMouse _virtualMouse_k__BackingField; // 0x140
		[CompilerGenerated]
		private DebugVirtualMouseInput _debugVirtualMouse_k__BackingField; // 0x148
		[CompilerGenerated]
		private Transform _canvasRoot_k__BackingField; // 0x150
		[CompilerGenerated]
		private Transform _controllerMask_k__BackingField; // 0x158
		[CompilerGenerated]
		private bool _usingVirtualMouse_k__BackingField; // 0x160
		private int m_virtualMouseBindingGroupId; // 0x164
		private FAssetProxyHandle m_canvasPrefabHandle; // 0x168
		[CompilerGenerated]
		private Transform _customControllerMouseTrans_k__BackingField; // 0x180
		[CompilerGenerated]
		private Camera _customControllerMouseUICamera_k__BackingField; // 0x188
		private List<ControllerHintInfo> m_tmpControllerHintInfoList; // 0x190
		public readonly HashSet<string> guideUseActionIds; // 0x198
		private const float DEFAULT_VIBRATE_LEVEL = 0.5f; // Metadata: 0x02644AE4
		private static Regex s_actIdRegex; // 0x30
		private const string TEXT_SPRITE_FORMAT = "<image=\"{0}\" scale={1}>"; // Metadata: 0x02644AE8
		private const float TEXT_SPRITE_SCALE = 1.6f; // Metadata: 0x02644B00
		public const string LONG_PRESS_KEY_ICON_POSTFIX = "_press"; // Metadata: 0x02644B04
		private const string KEY_HINT_ICON_COMMON_FOLDER = "Assets/Beyond/InitialAssets/UI/Sprites/"; // Metadata: 0x02644B0B
		private const string KEYBOARD_KEY_HINT_ICON_PATH = "KeyIcon/icon_key_"; // Metadata: 0x02644B33
		private const string GAMEPAD_KEY_HINT_ICON_PATH_PS5 = "KeyIcon/Playstation/icon_playstation_"; // Metadata: 0x02644B45
		private const string GAMEPAD_KEY_HINT_ICON_PATH_PS4 = "KeyIcon/Playstation4/icon_playstation4_"; // Metadata: 0x02644B6B
		private const string GAMEPAD_KEY_HINT_ICON_PATH_XBOX = "KeyIcon/XBox/icon_xbox_"; // Metadata: 0x02644B93
		private const string GAMEPAD_KEY_HINT_ICON_PATH_FALLBACK = "KeyIcon/XBox/icon_xbox_"; // Metadata: 0x02644BAB
		public static string s_virtualMouseClickHintActionId; // 0x38
		public static string s_virtualMouseLongPressHintActionId; // 0x40
		public MultiAction<Vector2> onStartSwipeTouchPanel; // 0x1A0
		public MultiAction<Vector2, Vector2> onSwipeTouchPanel; // 0x1A8
		public MultiAction onEndSwipeTouchPanel; // 0x1B0
		[CompilerGenerated]
		private bool _isSwipingTouchPanel_k__BackingField; // 0x1B8
		private Vector2 m_lastTouchPanelPos; // 0x1BC
		public ControllerNaviManager controllerNaviManager; // 0x1C8
		public bool disableCheckInputForNetMask; // 0x1D0
		private List<DelayedComboBinding> m_delayedCombos; // 0x1D8
		private bool m_delayedComboKeyUpdateSubscribed; // 0x1E0
		private static ProfilerMarker s_updateDelayedCombosMarker; // 0x48
		private static IGravitySensor s_gravitySensor; // 0x50
	
		// Properties
		public bool isDebugForceShow { get; } // 0x000000018C27708C-0x000000018C2770E8 
		public static bool cursorVisible { get; } // 0x00000001853AB270-0x00000001853AB430 
		public static bool anyKeyDown { get; } // 0x00000001851D22E0-0x00000001851D2360 
		public static Vector2 mouseScrollDelta { get; } // 0x00000001851D1AC0-0x00000001851D1BA0 
		public static bool multiTouchEnabled { get; set; } // 0x000000018503B6D0-0x000000018503B7A0 0x000000018684FE60-0x000000018684FF80
		public bool usingController { get; private set; } // 0x00000001853A80A0-0x00000001853A8140 0x000000018C2772C8-0x000000018C27736C
		public bool virtualMouseIconVisible { get; } // 0x000000018C277190-0x000000018C2771F4 
		public KeyboardType keyboardType { get; set; } // 0x000000018C2770E8-0x000000018C27713C 0x00000001861E7840-0x00000001861E7910
		public static int invalidID { get; } // 0x000000018503E4A0-0x000000018503E4D0 
		public Rewired.Joystick joystick { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		public IGamepadTemplate gamepadTemplate { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public IDualShock4Extension gamepadDualShock4Extension { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public Dictionary<string, HashSet<int>> action2BindingDic { get; } // 0x000000018C276FD0-0x000000018C277010 
		public int rootGroupId { get; } // 0x000000018C27713C-0x000000018C277190 
		public bool inChangingInputDevice { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723F280-0x000000018723F290 0x000000018723F290-0x000000018723F2A0
		public static bool isInputSuppressedByDeviceSwitch { get; } // 0x00000001853A8140-0x00000001853A8220 
		public static bool autoUpdateInputBindingMask { get; set; } // 0x000000018C277010-0x000000018C27708C 0x000000018C2771F4-0x000000018C2772C8
		public int bindingStateVersion { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828A9D40-0x00000001828A9D50 0x00000001828A9D50-0x00000001828A9D60
		public HGVirtualMouse virtualMouse { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BE50-0x000000018723BE60 0x0000000188DC478C-0x0000000188DC47A0
		public DebugVirtualMouseInput debugVirtualMouse { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BEA0-0x000000018723BEB0 0x0000000188DC4804-0x0000000188DC4818
		public Transform canvasRoot { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BD10-0x000000018723BD20 0x0000000188DC4570-0x0000000188DC4584
		public Transform controllerMask { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BD30-0x000000018723BD40 0x0000000188DC4598-0x0000000188DC45AC
		public bool usingVirtualMouse { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E1F0-0x000000018723E200 0x000000018723E260-0x000000018723E270
		public static Vector3 mousePosition { get; } // 0x0000000185198DF0-0x0000000185198E50 
		public Transform customControllerMouseTrans { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C0D0-0x000000018723C0E0 0x0000000188DC4B88-0x0000000188DC4B9C
		public Camera customControllerMouseUICamera { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723B990-0x000000018723B9A0 0x0000000188DC473C-0x0000000188DC4750
		public bool isSwipingTouchPanel { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187250BC0-0x0000000187250BD0 0x0000000187250BD0-0x0000000187250BE0
	
		// Nested types
		public class KeyCaches // TypeDefIndex: 85176
		{
			// Fields
			public bool escapeKeyDown; // 0x10
			public bool mouse0KeyDown; // 0x11
			public bool mouse1KeyDown; // 0x12
			public bool escapeKeyUp; // 0x13
			public bool mouse0KeyUp; // 0x14
			public bool mouse1KeyUp; // 0x15
			public bool escapeKey; // 0x16
			public bool mouse0Key; // 0x17
			public bool mouse1Key; // 0x18
	
			// Constructors
			public KeyCaches(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void UpdateKeyStat(); // 0x00000001851D2710-0x00000001851D2A20
		}
	
		private enum KeyCodeState // TypeDefIndex: 85177
		{
			Pressed = 0,
			OnPress = 1,
			OnRelease = 2
		}
	
		public class ControllerHintInfo : IComparable<ControllerHintInfo>, IReusable // TypeDefIndex: 85178
		{
			// Fields
			public string actionId; // 0x10
			public int priority; // 0x18
			public InputBindingInfo bind; // 0x20
			public IBindingView hintView; // 0x28
	
			// Constructors
			public ControllerHintInfo(); // 0x0000000186805BA0-0x0000000186805BB0
			public ControllerHintInfo(IBindingView hintView, InputBindingInfo bind); // 0x000000018C2776C8-0x000000018C2776D0
			public ControllerHintInfo(string actionId); // 0x000000018C2776D0-0x000000018C2776D8
	
			// Methods
			[IDTag(0)]
			public void Reset(IBindingView newHintView, InputBindingInfo newBind); // 0x000000018C277574-0x000000018C277608
			[IDTag(1)]
			public void Reset(string resetActionId); // 0x000000018C277608-0x000000018C2776C8
			public int CompareTo(ControllerHintInfo other); // 0x000000018C277480-0x000000018C2774D4
			public void OnAllocate(); // 0x000000018C2774D4-0x000000018C277508
			public void OnRecycle(); // 0x000000018C277508-0x000000018C277574
		}
	
		public enum DelayedComboKind // TypeDefIndex: 85179
		{
			ModifierTapThenTrigger = 0,
			TriggerThenModifier = 1
		}
	
		public class DelayedComboBinding // TypeDefIndex: 85180
		{
			// Fields
			public readonly string modifierActionId; // 0x10
			public readonly string triggerActionId; // 0x18
			public readonly DelayedComboKind kind; // 0x20
			public readonly float maxModifierHoldTime; // 0x24
			public readonly Action onTriggered; // 0x28
			internal GamepadKeyCode modifierKey; // 0x30
			internal GamepadKeyCode triggerKey; // 0x34
			internal float modifierHoldTime; // 0x38
			internal int modifierReleaseFrame; // 0x3C
			[CompilerGenerated]
			private bool _triggerJustPressedLastFrame_k__BackingField; // 0x40
	
			// Properties
			public bool triggerJustPressedLastFrame { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
	
			// Constructors
			internal DelayedComboBinding(string modifierActionId, string triggerActionId, DelayedComboKind kind, float maxModifierHoldTime, Action onTriggered); // 0x000000018696CD80-0x000000018696CDE0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85181
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__105_0; // 0x08
			public static Action __9__252_0; // 0x10
			public static MatchEvaluator __9__311_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001871E6DA0-0x00000001871E6E00
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __InitDeviceChangeBinding_b__105_0(); // 0x0000000186805BA0-0x0000000186805BB0
			internal void __CreateVirtualMouse_b__252_0(); // 0x0000000186805BA0-0x0000000186805BB0
			internal string _ParseTextActionId_b__311_0(System.Text.RegularExpressions.Match match); // 0x00000001849B1C50-0x00000001849B3990
		}
	
		// Constructors
		private InputManager(); // 0x0000000186CA0200-0x0000000186CA2580
		static InputManager(); // 0x0000000186BD4CE0-0x0000000186BD6EA0
	
		// Methods
		public void LateTick(float deltaTime); // 0x00000001859CF020-0x00000001859CF080
		private void _Init(); // 0x000000018663C8B0-0x000000018663F940
		public void Release(); // 0x000000018C273338-0x000000018C273370
		private void _ClearTickFunction(); // 0x000000018C2749E8-0x000000018C274A54
		public void OnApplicationQuit(); // 0x000000018C271EC0-0x000000018C271F28
		private void _ClearEvents(); // 0x000000018C274768-0x000000018C2749E8
		private void _OnAfterInputUpdate(); // 0x00000001851DEA80-0x00000001851DED20
		private void _OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x000000018C276284-0x000000018C2763A4
		private void _OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x000000018C2763A4-0x000000018C276428
		private void _TryFindGamepad(); // 0x0000000186EC38B0-0x0000000186EC3B00
		private bool _IsValidJoystick(Rewired.Joystick js); // 0x000000018C27619C-0x000000018C276284
		private void _SetJoystick(Rewired.Joystick js); // 0x000000018C27673C-0x000000018C276D70
		private void _CheckInput(); // 0x000000018550D840-0x000000018550DD80
		private Beyond.DeviceInfo.ControllerType _GetControllerType(Rewired.Joystick js, out bool isNonSupportPsController); // 0x000000018C275708-0x000000018C275980
		public void OnApplicationFocus(bool hasFocus); // 0x0000000185B0E810-0x0000000185B0E8C0
		private void _ClearAllCheckerPressedStates(); // 0x0000000185B0E8C0-0x0000000185B0EB60
		private static void _ClearKeyboardCheckerBindings(List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>>> bindingInfos); // 0x0000000185B0EF50-0x0000000185B0F440
		private static void _ClearGamepadCheckerBindings(GamepadCheckerBase checker); // 0x0000000185B0EB60-0x0000000185B0ECA0
		private static void _ClearGamepadBindingDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> dic); // 0x0000000185B0ECA0-0x0000000185B0EF50
		private void _InitDeviceChangeBinding(); // 0x0000000186F80F90-0x0000000186F81100
		private void _RefreshDeviceChangeBinding(); // 0x0000000185B0CFD0-0x0000000185B0D040
		public void CheckUsingController(); // 0x000000018550D5C0-0x000000018550D800
		private bool _CheckAnyKeyForTouchChangeDevice(); // 0x000000018C27471C-0x000000018C274768
		private bool _CheckAnyKeyForKeyboardChangeDevice(); // 0x000000018C274464-0x000000018C27471C
		private bool _AnyKeyDownForKeyboardChangeDevice(); // 0x000000018C2742C8-0x000000018C2743AC
		private void _TryChangeInputDeviceType(Beyond.DeviceInfo.InputType inputType); // 0x000000018C276D70-0x000000018C276ECC
		private void _TryStopDeviceSwitchSuppression(); // 0x000000018C276ECC-0x000000018C276F18
		private void _SyncUsingControllerState(); // 0x0000000185B0DA60-0x0000000185B0E080
		private static void _UpdateInputBindingMask(Beyond.DeviceInfo.InputType inputType); // 0x000000018C276F18-0x000000018C276FD0
		private static void _SetInputBindingMask(string group); // 0x000000018C27652C-0x000000018C27673C
		public void ToggleInputDeviceChangeMode(bool inChanging); // 0x000000018C27405C-0x000000018C2740F4
		public void SetCursorOverrideForDeviceChange(bool forceShow); // 0x000000018C2739C8-0x000000018C273C40
		public void ChangeInputTypeAndSyncState(Beyond.DeviceInfo.InputType inputType); // 0x000000018C26F61C-0x000000018C26F6D8
		private void _OnFocusedInputFieldChanged([IsReadOnly] in EventData<bool> v); // 0x00000001871851B0-0x00000001871851E0
		private void _CreateTickFunction(); // 0x0000000186FD5240-0x0000000186FD5360
		[IDTag(2)]
		private void _RemovePlayerActionCheck(InputBindingInfo info); // 0x000000018568ECE0-0x000000018568EE60
		[IDTag(2)]
		private void _AddPlayerActionCheck(InputBindingInfo info); // 0x000000018568F0B0-0x000000018568F230
		[IDTag(0)]
		private void _AddPlayerActionCheck(KeyboardInput input, InputBindingInfo info); // 0x000000018568F910-0x000000018568FA80
		[IDTag(1)]
		private void _AddPlayerActionCheck(GamepadInput input, InputBindingInfo info); // 0x000000018568F230-0x000000018568F3A0
		[IDTag(0)]
		private void _RemovePlayerActionCheck(KeyboardInput input, InputBindingInfo info); // 0x000000018568EE60-0x000000018568EF80
		[IDTag(1)]
		private void _RemovePlayerActionCheck(GamepadInput input, InputBindingInfo info); // 0x000000018568EF80-0x000000018568F0B0
		public bool GetKey(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000186B19450-0x0000000186B194A0
		public bool GetKeyOrDown(Beyond.Input.KeyboardKeyCode keyCode); // 0x000000018C2714F4-0x000000018C271528
		public bool GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode); // 0x00000001851D36B0-0x00000001851D3740
		public bool GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode); // 0x00000001851D3740-0x00000001851D37D0
		public Vector2 GetGamepadStickValue(bool isLeft, bool checkDeadZone = true /* Metadata: 0x02644A7E */); // 0x0000000186C20F40-0x0000000186C20FD0
		public static bool CheckGamepadStickInDeadZone(Vector2 stickValue); // 0x000000018C26F898-0x000000018C26F8C4
		public static bool CheckGamepadStickInDeadZone(float stickAxisValue); // 0x000000018C26F83C-0x000000018C26F898
		public float GetGamepadTriggerValue(bool isLeft); // 0x000000018C271274-0x000000018C2713CC
		public bool GetKey(GamepadKeyCode keyCode); // 0x000000018C271538-0x000000018C271544
		public bool GetKeyDown(GamepadKeyCode keyCode); // 0x000000018C2713CC-0x000000018C2713DC
		public bool GetKeyUp(GamepadKeyCode keyCode); // 0x000000018C271528-0x000000018C271538
		public bool AnyKeyboardKey(string[] actionScopes, out Beyond.Input.KeyboardKeyCode keyCode, out bool isBlackList); // 0x000000018C26F1CC-0x000000018C26F3DC
		private bool _AnyKeyboardKey(Beyond.Input.KeyboardKeyCode[] keyCodes, out Beyond.Input.KeyboardKeyCode keyCode); // 0x000000018C2743AC-0x000000018C274464
		public bool AnyGamepadKey(); // 0x000000018550D800-0x000000018550D840
		public bool AnyMouseKeyDown(); // 0x00000001851D2A20-0x00000001851D2AE0
		public bool AnyMouseKey(); // 0x000000018C26F458-0x000000018C26F4D4
		public bool AnyMouseKeyUp(); // 0x000000018C26F3DC-0x000000018C26F458
		public static bool AnyKeyDown(); // 0x00000001851D2360-0x00000001851D2710
		public static bool AnyTouchBegan(); // 0x000000018C26F560-0x000000018C26F61C
		public static bool AnyTouchActive(); // 0x000000018C26F4D4-0x000000018C26F560
		private bool _CheckGamepadKeyCode(GamepadKeyCode keyCode, KeyCodeState state); // 0x0000000185DFD760-0x0000000185DFD7E0
		[IDTag(1)]
		public int CreateBinding(PlayerActionInfo actionInfo, Action callback, int groupId, out string actionId); // 0x0000000186B122D0-0x0000000186B12350
		[IDTag(0)]
		public int CreateBinding(string actionId, Action callback, int groupId); // 0x0000000185042060-0x00000001850420A0
		[IDTag(2)]
		public int CreateBinding(Beyond.Input.KeyboardKeyCode key, string modifyKeys, InputTimingType timing, Action callback, int groupId); // 0x0000000186B12350-0x0000000186B124D0
		public int CreateBindingByActionId(string actionId, Action callback, int groupId); // 0x00000001850420A0-0x00000001850420E0
		internal int CreateRepeatAwareBindingByActionId(string actionId, Func<bool, bool, bool> repeatAwareCallback, int groupId); // 0x000000018497D4C0-0x000000018497D530
		private int _CreateBindingCore(string actionId, Action callback, Func<bool, bool, bool> repeatAwareCallback, int groupId); // 0x000000018497DB20-0x000000018497F9C0
		public void DeleteBinding(int id); // 0x000000018568E670-0x000000018568E710
		public void MarkBindingStateChanged(); // 0x000000018497D530-0x000000018497D570
		private void _OnAnySelectableInteractableChanged(Selectable selectable); // 0x000000018497F9C0-0x000000018497FD90
		public void ToggleBinding(int id, bool active); // 0x0000000185042F70-0x0000000185043070
		public void CancelPendingLongPress(InputBindingInfo info); // 0x00000001851DB320-0x00000001851DB380
		public int CreateGroup(int parentGroupId, IBindingGroupTarget bindingGroupTarget = null); // 0x00000001851DC870-0x00000001851DCBE0
		public void DeleteGroup(int id); // 0x0000000185042730-0x0000000185042820
		public void DeleteInGroup(int groupId); // 0x0000000186519F00-0x0000000186519F70
		public void ToggleGroup(int id, bool active); // 0x00000001851DE1D0-0x00000001851DE400
		public bool IsBindingEnabled(int id, bool needLogError = true /* Metadata: 0x02644A7F */); // 0x00000001853A96E0-0x00000001853A98B0
		public bool IsGroupParentDisabled(int groupId); // 0x00000001851DE400-0x00000001851DE580
		public void ForceBindingKeyhintToGray(int id, bool grayState); // 0x000000018660F130-0x000000018660F510
		public bool IsBindingKeyhintGray(int id); // 0x000000018C271AEC-0x000000018C271BA0
		public bool IsGroupEnabled(int id); // 0x00000001851DDFD0-0x00000001851DE1D0
		public void ToggleDebugCursorMode(); // 0x000000018C273F98-0x000000018C27405C
		public void ClearAllCursorShowRequests(); // 0x000000018C26F8C4-0x000000018C26F930
		public void SetCursorShowRequest(string key, bool showCursor); // 0x0000000185B0F5C0-0x0000000185B0F650
		public void ToggleAllInput(bool active); // 0x00000001859BE920-0x00000001859BE970
		public void SetBindingView(int bindingId, IBindingView bindingView); // 0x000000018C2738F8-0x000000018C2739C8
		public void SetGroupView(int groupId, IBindingView groupView); // 0x0000000185C874F0-0x0000000185C875E0
		public void ChangeParent(bool isGroup, int id, int newParentGroupId); // 0x000000018663C420-0x000000018663C5D0
		public int GetGroupParentId(bool isGroup, int id); // 0x000000018663C330-0x000000018663C420
		public void IgnoreBindingGroupParent(int groupId, bool parentIgnored); // 0x0000000186843140-0x0000000186843200
		public void IgnoreBindingParent(int bindingId, bool parentIgnored); // 0x000000018C271960-0x000000018C271A30
		public Beyond.Input.KeyboardKeyCode GetActionKeyboardKeyCode(string actionId, bool isModifyKey, bool isPrimary, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x02644A80 */); // 0x000000018574D190-0x000000018574D270
		public GamepadKeyCode GetActionGamepadKeyCode(string actionId, bool isModifyKey, bool isPrimary, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x02644A81 */); // 0x0000000186788FE0-0x00000001867890B0
		public void DeleteCustomBinding(string actionId, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x02644A82 */); // 0x000000018C26FF6C-0x000000018C2706C0
		public void DeleteAllCustomBindings(InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x02644A83 */); // 0x00000001867D5470-0x00000001867D5630
		public void SetBindingText(int id, string text); // 0x0000000186627750-0x0000000186627800
		public string GetBindingText(int id); // 0x000000018563F460-0x000000018563F530
		public bool HasBinding(int id); // 0x000000018C27186C-0x000000018C271900
		[IDTag(1)]
		public string GetActionText(string actionId); // 0x000000018568E560-0x000000018568E5D0
		[IDTag(0)]
		public static string GetActionText(PlayerActionInfo info, string actionId); // 0x000000018568E5D0-0x000000018568E670
		public bool CheckActionKeyCodeConflict(string actionId, Beyond.Input.KeyboardKeyCode keyCode, out bool isPrimary); // 0x000000018C26F71C-0x000000018C26F83C
		private void _DeleteGroup(InputBindingGroup group, bool isRootCall); // 0x00000001851DC5F0-0x00000001851DC690
		private void _DeleteInGroup(InputBindingGroup group); // 0x00000001851DD4A0-0x00000001851DD790
		private void _RealRemoveBindingInfo(InputBindingInfo info); // 0x000000018568FC00-0x0000000185690A80
		public float GetAxis(string name); // 0x00000001851E4230-0x00000001851E43E0
		public void GetBindingInfo(int bindingId, out string actionId, out IBindingView bindingView); // 0x0000000185641560-0x0000000185641650
		private void _LoadSetting(); // 0x00000001850402B0-0x0000000185040A50
		public void LoadSetting(); // 0x0000000185041400-0x0000000185041F20
		public bool IsPlayerActionIdValid(string id); // 0x0000000185041370-0x0000000185041400
		public PlayerActionInfo GetPlayerActionInfo(string id, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x02644A84 */); // 0x000000018568FA80-0x000000018568FB80
		public void ChangePlayerAction(string id, PlayerActionInfo actionInfo); // 0x000000018C26F6D8-0x000000018C26F71C
		public string AddAnonymousPlayerAction(PlayerActionInfo actionInfo); // 0x0000000186B124D0-0x0000000186B125A0
		private void _LoadCustomInputSetting(); // 0x0000000186F8F450-0x0000000186F8F520
		private PlayerActionInfo _GetOrCreatePendingActionInfo(string actionId); // 0x000000018C275C14-0x000000018C275EAC
		[IDTag(0)]
		public bool CustomizeActionKey(string actionId, Beyond.Input.KeyboardKeyCode key, bool isPrimary, string overrideKeyIconName = null); // 0x000000018C26FD50-0x000000018C26FF6C
		[IDTag(1)]
		public bool CustomizeActionKey(string actionId, GamepadKeyCode? modifyKey, GamepadKeyCode? key, bool isPrimary, string overrideKeyIconName = null); // 0x000000018C26FA5C-0x000000018C26FD50
		public void ClearPendingInputSetting(); // 0x000000018C26F9D4-0x000000018C26FA5C
		public void SaveCustomInputSetting(); // 0x00000001867D2D80-0x00000001867D33C0
		private void _CreateCanvas(); // 0x0000000186C37DE0-0x0000000186C38080
		private void _CreateDebugVirtualMouse(); // 0x0000000186C38080-0x0000000186C38130
		private void _CreateVirtualMouse(); // 0x0000000186C38130-0x0000000186C382F0
		private void _ToggleVirtualMouse(bool active, bool forceUpdate = false /* Metadata: 0x02644A85 */); // 0x0000000185B0F6C0-0x0000000185B0F840
		private void _CheckVirtualMouseState(); // 0x0000000185B0F650-0x0000000185B0F6C0
		public static Vector3 GetMousePos(); // 0x0000000185198E50-0x0000000185198F30
		public void SetOnlyVirtualMousePos(Vector2 newPos); // 0x000000018C273E94-0x000000018C273F34
		public static void SetMousePos(Vector2 newPos, bool hideVirtualMouse = false /* Metadata: 0x02644A86 */); // 0x000000018C273CB0-0x000000018C273E94
		public static bool GetMouseButton(int button); // 0x00000001853AAB20-0x00000001853AAFB0
		public static bool IsLeftMouseDown(bool requireActive = false /* Metadata: 0x02644A87 */); // 0x00000001865CF8F0-0x00000001865CF9B0
		public static bool GetMouseButtonDown(int button); // 0x000000018605A590-0x000000018605A6C0
		public static bool GetMouseButtonUp(int button); // 0x0000000185E58030-0x0000000185E58140
		public void SetCustomControllerMouse(Transform trans, Camera uiCamera); // 0x000000018C273C40-0x000000018C273CB0
		public List<ControllerHintInfo> GetEmptyControllerHintInfoList(); // 0x000000018C270FF8-0x000000018C2711BC
		[IDTag(0)]
		public void GetControllerHintInfos(int groupId, bool ignoreRootEnabled, ref List<ControllerHintInfo> infoList); // 0x000000018C270ADC-0x000000018C270BDC
		[IDTag(1)]
		public void GetControllerHintInfos(List<string> actionIdList, ref List<ControllerHintInfo> infoList); // 0x000000018C270A20-0x000000018C270ADC
		[IDTag(0)]
		private void _GetControllerHintInfos(InputBindingGroup group, bool ignoreRootEnabled, ref List<ControllerHintInfo> infoList); // 0x000000018C275014-0x000000018C275708
		[IDTag(1)]
		private void _GetControllerHintInfos(List<string> actionIdList, ref List<ControllerHintInfo> infoList); // 0x000000018C274E34-0x000000018C275014
		public float GetPlayerActionLongPressStartTime(string actionId, out float longPressTime); // 0x000000018C271544-0x000000018C271698
		public float GetActionBindingLongPressStartTime(int bindingId, out float longPressTime); // 0x000000018C27087C-0x000000018C270A20
		internal bool HasEnabledGamepadLongPressBinding(GamepadKeyCode key, GamepadKeyCode modifyKey); // 0x000000018C271900-0x000000018C271960
		public void AddGuideUseActionId(string actionId); // 0x0000000186843610-0x00000001868439C0
		public void RemoveGuideUseActionId(string actionId); // 0x0000000186843260-0x0000000186843610
		public void ClearGuideUseActionIds(); // 0x000000018C26F930-0x000000018C26F9D4
		public bool IsGuideUseAction(string actionId); // 0x00000001853A8D30-0x00000001853A8F30
		public bool IsAnyBindingInGroupGuideUse(int groupId); // 0x000000018C271A30-0x000000018C271AEC
		private bool _IsAnyBindingInGroupGuideUse(InputBindingGroup group); // 0x000000018C275EAC-0x000000018C27619C
		public void VibrateController(float time, float level = 0.5f /* Metadata: 0x02644A88 */); // 0x000000018C274210-0x000000018C2742C8
		private static string _GetGamepadKeyIconFolderPath(); // 0x000000018C275980-0x000000018C275A50
		public static string GetStringByKeyboardKeyCode(Beyond.Input.KeyboardKeyCode code); // 0x00000001856420F0-0x00000001856422B0
		public static string GetStringByGamepadKeyCode(GamepadKeyCode code); // 0x000000018C2716F0-0x000000018C27186C
		public static string GetKeyboardIconPath(string keyName, bool isLongPress, bool isFullPath); // 0x0000000186B76020-0x0000000186B76180
		[IDTag(0)]
		public static string GetKeyIconPath(GamepadInput inputInfo, bool isModifyKey, bool isFullPath, bool ignoreOverrideKeyIcon = false /* Metadata: 0x02644A8C */); // 0x000000018C2713DC-0x000000018C2714F4
		public static string GetGamepadKeyIconPath(string keyStr, bool isLongPress, bool isFullPath); // 0x000000018C2711BC-0x000000018C271274
		[IDTag(2)]
		public static string GetKeyIconPath(KeyboardInput inputInfo, bool isModifyKey, bool isFullPath); // 0x0000000185643330-0x00000001856433D0
		[IDTag(1)]
		public static string GetKeyIconPath(KeyboardInput inputInfo, bool isModifyKey, bool isLongPress, bool isFullPath); // 0x00000001856433D0-0x0000000185643560
		private static string _GetKeyIconPath(string path, string keyStr, bool isLongPress, bool isFullPath); // 0x0000000185643880-0x0000000185643930
		public static string ParseTextActionId(string text); // 0x0000000186A9C9D0-0x0000000186A9CB60
		public void MoveMouseTo(RectTransform target, Camera uiCamera); // 0x000000018C271BA0-0x000000018C271E3C
		public void MoveVirtualMouseTo(RectTransform target, Camera uiCamera, bool hideVirtualMouse = true /* Metadata: 0x02644A8D */); // 0x000000018C271E3C-0x000000018C271EC0
		public void SetVirtualMouseIconVisible(bool active); // 0x000000018C273F34-0x000000018C273F98
		private void _ControllerTouchPanelTick(); // 0x000000018C274A54-0x000000018C274C08
		public static int GetTouchId(PointerEventData eventData); // 0x00000001850358E0-0x0000000185035960
		public static bool GetPressPosByTouchId(int touchId, out Vector2 position); // 0x00000001865670D0-0x00000001865673A0
		public void Dispose(); // 0x000000018C2706C0-0x000000018C27087C
		public static void RemoveUnusedInput(); // 0x000000018C273370-0x000000018C2738F8
		private void _OnNetMaskChanged([IsReadOnly] in EventData<bool> v); // 0x0000000185B0E760-0x0000000185B0E810
		public string GetCurJsInfos(); // 0x000000018C270BDC-0x000000018C270FF8
		public string GetRealCursorState(); // 0x000000018C271698-0x000000018C2716F0
		public void SetMouseSpeedOverride(float multiplier); // 0x000000018497D920-0x000000018497DB20
		public void ClearMouseSpeedOverride(); // 0x000000018497CD70-0x000000018497CE30
		[IDTag(2)]
		public string PrintKeycodeInfo(string keyCode, bool checkKeyboard, bool checkGamepad, bool isDetailed = false /* Metadata: 0x02644A8E */); // 0x000000018C272450-0x000000018C2728E0
		[IDTag(0)]
		public string PrintKeycodeInfo(Beyond.Input.KeyboardKeyCode keyCode, bool isDetailed = false /* Metadata: 0x02644A8F */); // 0x000000018C272E00-0x000000018C273338
		[IDTag(1)]
		public string PrintKeycodeInfo(GamepadKeyCode keyCode, bool isDetailed = false /* Metadata: 0x02644A90 */); // 0x000000018C2728E0-0x000000018C272E00
		public string PrintActionInfo(string actionId); // 0x000000018C271F28-0x000000018C2721A0
		public string PrintBindingInfo(InputBindingInfo bindingInfo); // 0x000000018C2721A0-0x000000018C272450
		private string _GetBindingName(object item); // 0x000000018C274C08-0x000000018C274E34
		private GameObject _GetInputBindingGroupGameObject(InputBindingGroup bindingGroup); // 0x000000018C275B24-0x000000018C275C14
		private GameObject _GetInputBindingGameObject(InputBindingInfo bindingInfo); // 0x000000018C275A50-0x000000018C275B24
		public DelayedComboBinding RegisterDelayedCombo(string modifierActionId, string triggerActionId, DelayedComboKind kind, float maxModifierHoldTime, Action onTriggered); // 0x000000018696CB60-0x000000018696CD80
		public void UnregisterDelayedCombo(DelayedComboBinding binding); // 0x000000018C274174-0x000000018C274210
		private void _OnDelayedComboActionKeyUpdated([IsReadOnly] in EventData<string> data); // 0x000000018C276428-0x000000018C27652C
		private void _RefreshDelayedComboKeys(DelayedComboBinding binding); // 0x000000018696CDE0-0x000000018696CE70
		private void _UpdateDelayedCombos(float deltaTime); // 0x00000001859CF080-0x00000001859CF3C0
		private void _UpdateModifierTapThenTriggerCombo(DelayedComboBinding binding, float deltaTime); // 0x00000001859CF440-0x00000001859CF4E0
		private void _UpdateTriggerThenModifierCombo(DelayedComboBinding binding); // 0x00000001859CF3C0-0x00000001859CF440
		public static void SetGravitySensor(IGravitySensor gravitySensor); // 0x000000018497D570-0x000000018497D920
		public static GravitySensorHandle CreateGravitySensorHandle(); // 0x000000018497CE30-0x000000018497D4C0
		[CompilerGenerated]
		private void __Init_b__69_0(Beyond.Input.KeyboardKeyCode key); // 0x000000018C2740F4-0x000000018C274114
		[CompilerGenerated]
		private void __Init_b__69_1(GamepadKeyCode key); // 0x000000018C274114-0x000000018C274134
		[CompilerGenerated]
		private void __Init_b__69_2(); // 0x0000000185B0E700-0x0000000185B0E760
		[CompilerGenerated]
		private void __Init_b__69_3(); // 0x000000018C274134-0x000000018C274174
	}

	public interface IGravitySensor // TypeDefIndex: 85183
	{
		// Properties
		bool isReady { get; }
		Vector3 gravity { get; }
	
		// Methods
		void Enable();
		void Disable();
	}

	public class LocalGravitySensor : IGravitySensor // TypeDefIndex: 85184
	{
		// Fields
		private static LocalGravitySensor s_instance; // 0x00
	
		// Properties
		public static LocalGravitySensor instance { get; } // 0x00000001849B10E0-0x00000001849B1490 
		public bool isReady { get; } // 0x00000001849B1490-0x00000001849B17D0 
		public Vector3 gravity { get; } // 0x00000001849B01D0-0x00000001849B10E0 
	
		// Constructors
		public LocalGravitySensor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Enable(); // 0x00000001849AF370-0x00000001849B01D0
		public void Disable(); // 0x00000001849AF330-0x00000001849AF370
	}

	public class CloudGravitySensor : IGravitySensor // TypeDefIndex: 85185
	{
		// Fields
		private static CloudGravitySensor s_instance; // 0x00
	
		// Properties
		public static CloudGravitySensor instance { get; } // 0x0000000184984740-0x0000000184984AF0 
		public bool isReady { get; } // 0x0000000184984AF0-0x0000000184984B30 
		public Vector3 gravity { get; } // 0x00000001849846D0-0x0000000184984740 
	
		// Constructors
		public CloudGravitySensor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Enable(); // 0x0000000184984690-0x00000001849846D0
		public void Disable(); // 0x0000000184984650-0x0000000184984690
	}

	public sealed class GravitySensorHandle : IDisposable // TypeDefIndex: 85186
	{
		// Fields
		private IGravitySensor m_sensor; // 0x10
		private bool m_isValid; // 0x18
		private bool m_isEnabled; // 0x19
	
		// Properties
		public bool isReady { get; } // 0x0000000184984F90-0x0000000184985060 
		public Vector3 gravity { get; } // 0x0000000184984DF0-0x0000000184984F90 
	
		// Constructors
		internal GravitySensorHandle(IGravitySensor sensor); // 0x0000000184984D90-0x0000000184984DF0
	
		// Methods
		public void Enable(); // 0x0000000184984CA0-0x0000000184984D90
		public void Disable(); // 0x0000000184984B30-0x0000000184984C40
		public void Dispose(); // 0x0000000184984C40-0x0000000184984CA0
	}

	public class InputRebindConfig : ScriptableObject // TypeDefIndex: 85187
	{
		// Fields
		public const string INPUT_REBIND_CONFIG_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Input/InputRebindConfig.asset"; // Metadata: 0x02644BC8
		public InputRebindActionScopeConfig[] actionScopeConfigs; // 0x18
	
		// Constructors
		public InputRebindConfig(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	[Serializable]
	public class InputRebindActionScopeConfig // TypeDefIndex: 85188
	{
		// Fields
		public string name; // 0x10
		public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeWhiteList; // 0x18
		public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeBlackList; // 0x20
	
		// Constructors
		public InputRebindActionScopeConfig(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class InputSetting : ScriptableObject // TypeDefIndex: 85189
	{
		// Fields
		public const string CUSTOM_SETTING_DIRECTORY_NAME = "Input"; // Metadata: 0x02644C0F
		public const string CUSTOM_SETTING_JSON_FILE_NAME = "CustomInputSetting.json"; // Metadata: 0x02644C15
		[SerializeField]
		public SerializeFieldDictionaryPaired<string, PlayerActionInfo> actionInfos; // 0x18
	
		// Constructors
		public InputSetting(); // 0x0000000185DD4B50-0x0000000185DD4BE0
	}

	public class InputSettingConfig : ScriptableObject // TypeDefIndex: 85190
	{
		// Fields
		public const string INPUT_SETTING_CONFIG_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Input/InputSettingConfig.asset"; // Metadata: 0x02644C2D
		public List<InputSetting> inputSettingList; // 0x18
	
		// Constructors
		public InputSettingConfig(); // 0x0000000187181090-0x0000000187181110
	}

	public static class InputUtils // TypeDefIndex: 85191
	{
		// Methods
		public static bool HasFlag(InputDeviceFlags value, InputDeviceFlags target); // 0x000000018C277BBC-0x000000018C277BF8
	
		// Extension methods
		public static void IgnoreBindingParent(this IBindingTarget target, bool active); // 0x000000018C277BF8-0x000000018C277CEC
		public static void IgnoreBindingGroupParent(this IBindingGroupTarget target, bool active); // 0x00000001868430A0-0x0000000186843140
	}

	internal abstract class KeyboardCheckerBase // TypeDefIndex: 85194
	{
		// Fields
		protected Beyond.Input.InputManager m_inputManager; // 0x10
		protected const int CTRL = 1; // Metadata: 0x02644C76
		protected const int SHIFT = 2; // Metadata: 0x02644C77
		protected const int ALT = 4; // Metadata: 0x02644C78
		protected const int MAX_INDEX = 7; // Metadata: 0x02644C79
		protected static int[] s_checkPriority; // 0x00
		protected List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<Binding>>> m_bindingInfos; // 0x18
	
		// Properties
		internal List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<Binding>>> bindingInfos { get; } // 0x000000018C277D20-0x000000018C277D60 
	
		// Nested types
		public class Binding // TypeDefIndex: 85192
		{
			// Fields
			public InputBindingInfo info; // 0x10
			public float pressDownTime; // 0x18
			public bool isUsedForBlock; // 0x1C
			public int longPressTimerId; // 0x20
			public float longPressTime; // 0x24
			public bool enableContinuousTrigger; // 0x28
			public bool isCommonOpenUIAction; // 0x29
			public InputContinuousTriggerType continuousTriggerType; // 0x2C
	
			// Constructors
			public Binding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x02644C7A */); // 0x000000018568EC20-0x000000018568ECE0
		}
	
		public enum TriggerType // TypeDefIndex: 85193
		{
			NORMAL = 0,
			CONTINUOUS = 1,
			STOP_CONTINUOUS = 2
		}
	
		// Constructors
		protected KeyboardCheckerBase(Beyond.Input.InputManager inputManager); // 0x000000018663C790-0x000000018663C8B0
		static KeyboardCheckerBase(); // 0x0000000187177C90-0x0000000187177D20
	
		// Methods
		public static int GetModifyIndex(KeyboardInput input); // 0x000000018568EBD0-0x000000018568EC20
		public virtual Binding OnCreateBinding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x02644C75 */); // 0x000000018568EA60-0x000000018568EBD0
		public virtual Binding OnDeleteBinding(KeyboardInput input, InputBindingInfo info); // 0x000000018568E710-0x000000018568EA60
		public virtual void CheckKeyboardInput(); // 0x000000018C277CEC-0x000000018C277D20
		public virtual void TriggerActions(); // 0x00000001862F8310-0x00000001862F8340
	}

	internal class KeyboardChecker : KeyboardCheckerBase // TypeDefIndex: 85195
	{
		// Fields
		private Func<Beyond.Input.KeyboardKeyCode, bool> m_checkFunc; // 0x20
		[CompilerGenerated]
		private bool _isPressChecker_k__BackingField; // 0x28
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x30
		private List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x38
	
		// Properties
		public bool isPressChecker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
	
		// Constructors
		public KeyboardChecker(Func<Beyond.Input.KeyboardKeyCode, bool> checkFunc, bool isPress, Beyond.Input.InputManager inputManager); // 0x000000018663C630-0x000000018663C790
	
		// Methods
		public override void CheckKeyboardInput(); // 0x00000001851D5E20-0x00000001851D6A20
		public override void TriggerActions(); // 0x0000000185E04D90-0x0000000185E05150
		public void __iFixBaseProxy_CheckKeyboardInput(); // 0x000000018C277D60-0x000000018C277D68
		public void __iFixBaseProxy_TriggerActions(); // 0x000000018C277D68-0x000000018C277D70
	}

	internal class KeyboardOnClickChecker : KeyboardCheckerBase // TypeDefIndex: 85196
	{
		// Fields
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x20
		private List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x28
		private List<ListSet<Beyond.Input.KeyboardKeyCode>> m_combinationKeyPressedInfo; // 0x30
	
		// Constructors
		public KeyboardOnClickChecker(Beyond.Input.InputManager inputManager); // 0x000000018663B060-0x000000018663B260
	
		// Methods
		public override void CheckKeyboardInput(); // 0x00000001851D6A70-0x00000001851D8050
		public void ClearCombinationKeyPressedInfo(); // 0x0000000185B0F440-0x0000000185B0F5C0
		public override void TriggerActions(); // 0x0000000185E04AA0-0x0000000185E04D90
		public void ClearKeyPressed(Beyond.Input.KeyboardKeyCode keyCode); // 0x000000018C278754-0x000000018C278A40
		public void __iFixBaseProxy_CheckKeyboardInput(); // 0x000000018C277D60-0x000000018C277D68
		public void __iFixBaseProxy_TriggerActions(); // 0x000000018C277D68-0x000000018C277D70
	}

	internal class KeyboardOnLongPressChecker : KeyboardCheckerBase // TypeDefIndex: 85198
	{
		// Fields
		private Action<Beyond.Input.KeyboardKeyCode> m_onTriggerOnLongPress; // 0x20
		private Dictionary<KeyboardInput, HashSet<Binding>> m_bindings; // 0x28
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 85197
		{
			// Fields
			public ValueTuple<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>> key; // 0x10
			public KeyboardCheckerBase.Binding targetBinding; // 0x20
			public KeyboardOnLongPressChecker __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _CheckKeyboardInput_b__0(); // 0x000000018C279B84-0x000000018C279BB0
		}
	
		// Constructors
		public KeyboardOnLongPressChecker(Action<Beyond.Input.KeyboardKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager); // 0x000000018663AF40-0x000000018663B060
	
		// Methods
		public override void CheckKeyboardInput(); // 0x00000001851D2AE0-0x00000001851D36B0
		private void _OnTriggerBinding(Binding binding, Beyond.Input.KeyboardKeyCode keyCode); // 0x000000018C278D94-0x000000018C278FB8
		public override Binding OnCreateBinding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x02644C7E */); // 0x0000000186F81100-0x0000000186F81250
		public override Binding OnDeleteBinding(KeyboardInput input, InputBindingInfo info); // 0x000000018C278C4C-0x000000018C278D7C
		public void CancelPendingLongPress(InputBindingInfo info); // 0x00000001851D9A60-0x00000001851D9D00
		public float GetInputLongPressStartTime(KeyboardInput input, int bindingId = 0 /* Metadata: 0x02644C7F */); // 0x000000018C278A40-0x000000018C278C4C
		public void __iFixBaseProxy_CheckKeyboardInput(); // 0x000000018C277D60-0x000000018C277D68
		public Binding __iFixBaseProxy_OnCreateBinding(KeyboardInput P0, InputBindingInfo P1, bool P2); // 0x000000018C278D7C-0x000000018C278D8C
		public Binding __iFixBaseProxy_OnDeleteBinding(KeyboardInput P0, InputBindingInfo P1); // 0x000000018C278D8C-0x000000018C278D94
	}

	public class KeyboardHandler // TypeDefIndex: 85199
	{
		// Fields
		private static Dictionary<Beyond.Input.KeyboardKeyCode, UnityEngine.InputSystem.Key> s_keyMap; // 0x00
		private Dictionary<Beyond.Input.KeyboardKeyCode, string> m_localizedKeyName; // 0x10
		private Dictionary<string, string> m_localizedIconName; // 0x18
		private Dictionary<KeyboardType, KeyboardOverrideConfig> m_configs; // 0x20
		private KeyboardType m_keyboardType; // 0x28
	
		// Constructors
		static KeyboardHandler(); // 0x000000018696CE70-0x000000018696FFB0
		public KeyboardHandler(); // 0x0000000186BD4BD0-0x0000000186BD4CE0
	
		// Methods
		public static bool GetKey(Beyond.Input.KeyboardKeyCode keyCode); // 0x000000018C278068-0x000000018C278134
		public static bool GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode); // 0x000000018C277ED0-0x000000018C277F9C
		public static bool GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode); // 0x000000018C277F9C-0x000000018C278068
		public void ParseConfig(KeyboardLocalizeConfig keyboardConfig); // 0x00000001861E6A60-0x00000001861E6B50
		public KeyboardType GetKeyboardType(); // 0x000000018C278134-0x000000018C278174
		public void SetKeyboardType(KeyboardType keyboardType); // 0x00000001861E6B50-0x00000001861E6C60
		public string GetEscIconName(); // 0x000000018C277D70-0x000000018C277DAC
		public string GetIconNameByKeyName(string keyName); // 0x000000018C277DAC-0x000000018C277E30
		public string GetIconName(Beyond.Input.KeyboardKeyCode keyCode); // 0x000000018C277E30-0x000000018C277ED0
	}

	public class KeyboardLocalizeConfig : ScriptableObject // TypeDefIndex: 85200
	{
		// Fields
		public const string KEYBOARD_CONFIG_PATH = "Assets/@Options/KeyboardLocalizeConfig.asset"; // Metadata: 0x02644C80
		public KeyboardOverrideConfig[] keyboardConfigs; // 0x18
	
		// Constructors
		public KeyboardLocalizeConfig(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	[Serializable]
	public class KeyboardOverrideConfig // TypeDefIndex: 85201
	{
		// Fields
		public KeyboardType keyboardType; // 0x10
		public KeyboardOverrideIconConfig[] overrideIconConfigs; // 0x18
	
		// Constructors
		public KeyboardOverrideConfig(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class KeyboardOverrideIconConfig // TypeDefIndex: 85202
	{
		// Fields
		public Beyond.Input.KeyboardKeyCode keyCode; // 0x10
		public string keyName; // 0x18
		public string iconName; // 0x20
	
		// Constructors
		public KeyboardOverrideIconConfig(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	public class PlayerActionIdAttribute : Attribute // TypeDefIndex: 85203
	{
		// Constructors
		public PlayerActionIdAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Flags]
	public enum InputDeviceFlags : byte // TypeDefIndex: 85204
	{
		None = 0,
		Keyboard = 1,
		Gamepad = 2,
		All = 3
	}

	[Serializable]
	public class PlayerActionInfo // TypeDefIndex: 85205
	{
		// Fields
		[Tooltip("\u52FE\u9009\u540E\u4E00\u5E27\u5185\u53EA\u4F1A\u89E6\u53D1\u4E00\u4E2A CommonOpenUIAction\uFF0C\u9632\u6B62\u51FA\u73B0\u4E00\u5E27\u5185\u8FDB\u884C\u591A\u4E2A UI \u64CD\u4F5C\u7684\u60C5\u51B5")]
		public bool isCommonOpenUIAction; // 0x10
		[SerializeField]
		public KeyboardInput primaryKeyboardInput; // 0x18
		[SerializeField]
		public GamepadInput primaryGamepadInput; // 0x20
		public int priority; // 0x28
		public bool needShowControllerHint; // 0x2C
		public int controllerHintPriority; // 0x30
		public string overrideTextId; // 0x38
		public bool needSecond; // 0x40
		public bool hideSecondInKeyHint; // 0x41
		[SerializeField]
		public KeyboardInput secondaryKeyboardInput; // 0x48
		[SerializeField]
		public GamepadInput secondaryGamepadInput; // 0x50
	
		// Constructors
		public PlayerActionInfo(); // 0x00000001829D07F0-0x00000001829D0800
	
		// Methods
		public void ResetHintProority(); // 0x000000018C279194-0x000000018C279268
		public bool DeviceInputEquals(PlayerActionInfo other, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x02644CB1 */); // 0x000000018C279090-0x000000018C279194
		public void DeviceInputCopyFrom(PlayerActionInfo other, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x02644CB2 */); // 0x000000018C278FB8-0x000000018C279090
	}

	[Serializable]
	public abstract class DeviceInput<T> : IEquatable<T> // TypeDefIndex: 85206
		where T : DeviceInput<T>
	{
		// Fields
		public InputTimingType timingType;
		[FormerlySerializedAs("isBlockedKeyAfterClick")]
		public bool blockOtherTiming;
		public float longPressTime;
		public bool enableContinuousTrigger;
		public InputContinuousTriggerType continuousTriggerType;
		public string overrideKeyIconName;
	
		// Constructors
		protected DeviceInput();
	
		// Methods
		public virtual string GetModifyText();
		public virtual string GetKeyCodeText();
		public virtual int GetKeyCodeEnumIntValue();
		public virtual void SetKeyCodeEnumByIntValue(int value);
		public virtual void ClearKeyCode();
		public virtual bool IsValid();
		public virtual void CopyFrom(T other);
		public abstract bool Equals(T other);
		public override string ToString();
	}

	[Serializable]
	public class KeyboardInput : DeviceInput<KeyboardInput> // TypeDefIndex: 85207
	{
		// Fields
		public Beyond.Input.KeyboardKeyCode key; // 0x30
		public bool useCtrl; // 0x34
		public bool useShift; // 0x35
		public bool useAlt; // 0x36
	
		// Properties
		public string modifyString { get; } // 0x000000018C278678-0x000000018C278754 
	
		// Constructors
		public KeyboardInput(); // 0x000000018724EEC0-0x000000018724EEE0
	
		// Methods
		public override string GetModifyText(); // 0x000000018C27851C-0x000000018C278620
		public override string GetKeyCodeText(); // 0x000000018C2782F4-0x000000018C27851C
		public override int GetKeyCodeEnumIntValue(); // 0x000000018C2782B4-0x000000018C2782F4
		public override void SetKeyCodeEnumByIntValue(int value); // 0x000000018C278620-0x000000018C278658
		public override void ClearKeyCode(); // 0x000000018C278174-0x000000018C2781BC
		public override bool IsValid(); // 0x00000001870EA5E0-0x00000001870EA610
		public override void CopyFrom(KeyboardInput other); // 0x000000018C2781BC-0x000000018C278268
		public override bool Equals(KeyboardInput other); // 0x000000018C278268-0x000000018C2782B4
		public string __iFixBaseProxy_GetModifyText(); // 0x000000018C278668-0x000000018C278670
		public string __iFixBaseProxy_GetKeyCodeText(); // 0x000000018C278660-0x000000018C278668
		public int __iFixBaseProxy_GetKeyCodeEnumIntValue(); // 0x000000018226EBA0-0x000000018226EBB0
		public void __iFixBaseProxy_SetKeyCodeEnumByIntValue(int P0); // 0x0000000186033510-0x0000000186033520
		public void __iFixBaseProxy_ClearKeyCode(); // 0x000000018C278658-0x000000018C278660
		public bool __iFixBaseProxy_IsValid(); // 0x000000018C278670-0x000000018C278678
	}

	[Serializable]
	public class GamepadInput : DeviceInput<GamepadInput> // TypeDefIndex: 85208
	{
		// Fields
		public GamepadKeyCode key; // 0x30
		public GamepadKeyCode modifyKey; // 0x34
		public float maxClickPressTime; // 0x38
	
		// Constructors
		public GamepadInput(); // 0x000000018651A370-0x000000018651A390
	
		// Methods
		public override string GetModifyText(); // 0x000000018C27797C-0x000000018C277A2C
		public override string GetKeyCodeText(); // 0x000000018C2778EC-0x000000018C27797C
		public override int GetKeyCodeEnumIntValue(); // 0x000000018C2778AC-0x000000018C2778EC
		public override void SetKeyCodeEnumByIntValue(int value); // 0x000000018C277A68-0x000000018C277AA0
		public override void ClearKeyCode(); // 0x000000018C2777C0-0x000000018C277804
		public override bool IsValid(); // 0x000000018C277A2C-0x000000018C277A68
		public override void CopyFrom(GamepadInput other); // 0x000000018C277804-0x000000018C2778AC
		public override bool Equals(GamepadInput other); // 0x0000000186963BC0-0x0000000186965080
		public string __iFixBaseProxy_GetModifyText(); // 0x000000018C277AB0-0x000000018C277AB8
		public string __iFixBaseProxy_GetKeyCodeText(); // 0x000000018C277AA8-0x000000018C277AB0
		public int __iFixBaseProxy_GetKeyCodeEnumIntValue(); // 0x000000018226EBA0-0x000000018226EBB0
		public void __iFixBaseProxy_SetKeyCodeEnumByIntValue(int P0); // 0x0000000186033510-0x0000000186033520
		public void __iFixBaseProxy_ClearKeyCode(); // 0x000000018C277AA0-0x000000018C277AA8
		public bool __iFixBaseProxy_IsValid(); // 0x000000018C277AB8-0x000000018C277AC0
	}

	internal struct CursorRequest // TypeDefIndex: 85209
	{
		// Fields
		public string key; // 0x00
		public int priority; // 0x08
		public bool show; // 0x0C
	
		// Methods
		public override string ToString(); // 0x000000018C2776D8-0x000000018C277770
		public string __iFixBaseProxy_ToString(); // 0x000000018C277770-0x000000018C2777C0
	}

	internal static class CursorPriority // TypeDefIndex: 85210
	{
		// Fields
		public const int DEVICE_CHANGE_OVERRIDE = 0; // Metadata: 0x02644CB3
		public const int CONTROLLER_HIDE = 10; // Metadata: 0x02644CB4
		public const int EDITOR_DEBUG_FORCE_SHOW = 20; // Metadata: 0x02644CB5
		public const int SHOW_REQUEST = 100; // Metadata: 0x02644CB6
	}

	internal class RealCursorManager // TypeDefIndex: 85211
	{
		// Fields
		private Dictionary<string, CursorRequest> m_requests; // 0x10
		private CursorRequest m_activeHighest; // 0x18
		private bool m_isUsingVirtualMouse; // 0x28
		private const int SPI_GETMOUSESPEED = 112; // Metadata: 0x02644CBA
		private const int SPI_SETMOUSESPEED = 113; // Metadata: 0x02644CBC
		private const int SPIF_SENDCHANGE = 2; // Metadata: 0x02644CBE
		private int m_originalMouseSpeed; // 0x2C
		private float m_overrideMultiplier; // 0x30
	
		// Properties
		public bool isDebugForceShow { get; } // 0x000000018C279AEC-0x000000018C279B84 
	
		// Constructors
		public RealCursorManager(); // 0x0000000185B0FE20-0x0000000185B0FEB0
	
		// Methods
		private static extern bool _SystemParametersInfo(int uiAction, int uiParam, ref int pvParam, int fWinIni); // 0x00000001849B1A90-0x00000001849B1B70
		private static extern bool _SystemParametersInfo(int uiAction, int uiParam, IntPtr pvParam, int fWinIni); // 0x00000001849B1B70-0x00000001849B1C50
		public bool HasAnyShowRequestAtPriority(int priority); // 0x000000018C279610-0x000000018C279794
		public void SetRequest(string key, int priority, bool show); // 0x0000000185B0F840-0x0000000185B0FA40
		public void RemoveRequest(string key); // 0x0000000185B0FDC0-0x0000000185B0FE20
		public void RemoveAllRequestsAtPriority(int priority); // 0x000000018C279794-0x000000018C279AEC
		public void SetVirtualMouseActive(bool active); // 0x0000000185B0E6C0-0x0000000185B0E700
		public void CalcState(bool forceUpdate = false /* Metadata: 0x02644CB8 */); // 0x0000000185B0FA40-0x0000000185B0FAA0
		private void _RefreshActiveHighest(); // 0x0000000185B0FBE0-0x0000000185B0FDC0
		private void _ToggleCursorInternal(bool enable, bool forceUpdate = false /* Metadata: 0x02644CB9 */); // 0x0000000185B0FAA0-0x0000000185B0FB60
		public void SetMouseSpeedOverride(float multiplier); // 0x00000001849B18D0-0x00000001849B1A90
		public void ClearMouseSpeedOverride(); // 0x00000001849B17D0-0x00000001849B1850
		public void RestoreMouseSpeed(); // 0x00000001849B1850-0x00000001849B18D0
		public string DumpState(); // 0x000000018C279268-0x000000018C279610
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	public class TextIdAttribute : Attribute // TypeDefIndex: 85212
	{
		// Constructors
		public TextIdAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class UIEvent : UnityEvent, IBindingTarget // TypeDefIndex: 85213
	{
		// Fields
		private bool m_bindingInit; // 0x30
		[FormerlySerializedAs("useBindingKeys")]
		[FormerlySerializedAs("_useBindingKeys")]
		public bool useBindingAction; // 0x31
		public string playerActionId; // 0x38
		[SerializeReference]
		public PlayerActionInfo anonymousPlayerActionInfo; // 0x40
		[NonSerialized]
		public string anonymousPlayerActionId; // 0x48
		[CompilerGenerated]
		private int _bindingId_k__BackingField; // 0x50
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x58
		private Action m_bindAct; // 0x60
		private Action m_onUpdateKeyAct; // 0x68
		private List<UnityAction> m_calls; // 0x70
	
		// Properties
		public bool bindingEnabled { get; } // 0x000000018C27A37C-0x000000018C27A428 
		public int bindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233280-0x0000000187233290 0x00000001854CCF30-0x00000001854CCF40
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public int count { get; } // 0x000000018C27A428-0x000000018C27A4A4 
	
		// Constructors
		public UIEvent(); // 0x000000018C27A36C-0x000000018C27A37C
	
		// Methods
		private void _CreatePlayerActionBinding(); // 0x000000018C27A230-0x000000018C27A36C
		public void InitBinding(IBindingGroupTarget parent, Action bindAct, Action onUpdateKeyAct); // 0x000000018C279D58-0x000000018C279E28
		public new void Invoke(); // 0x000000018C279E28-0x000000018C279EF8
		public void UpdateKeys(); // 0x000000018C27A188-0x000000018C27A230
		public void ChangeBindingPlayerAction(string actionId); // 0x000000018C279D00-0x000000018C279D58
		public new void AddListener(UnityAction call); // 0x000000018C279BB0-0x000000018C279D00
		public new void RemoveListener(UnityAction call); // 0x000000018C27A0AC-0x000000018C27A188
		public new void RemoveAllListeners(); // 0x000000018C279EF8-0x000000018C27A0AC
	}

	[Serializable]
	public class UIEvent<T0> : UnityEvent<T0>, IBindingTarget // TypeDefIndex: 85214
	{
		// Fields
		private bool m_bindingInit;
		[FormerlySerializedAs("_useBindingKeys")]
		[FormerlySerializedAs("useBindingKeys")]
		public bool useBindingAction;
		public string playerActionId;
		[SerializeReference]
		public PlayerActionInfo anonymousPlayerActionInfo;
		[NonSerialized]
		public string anonymousPlayerActionId;
		public bool useAnonymousAction;
		[NonSerialized]
		public bool tempForceEnable;
		[CompilerGenerated]
		private int _bindingId_k__BackingField;
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField;
		private Action m_bindAct;
		private Action m_onUpdateKeyAct;
		private List<UnityAction<T0>> m_calls;
	
		// Properties
		public bool bindingEnabled { get; }
		public int bindingId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int count { get; }
	
		// Constructors
		public UIEvent();
	
		// Methods
		private void _CreatePlayerActionBinding();
		public void InitBinding(IBindingGroupTarget parent, Action bindAct, Action onUpdateKeyAct);
		public new void Invoke(T0 arg0);
		public PlayerActionInfo GetEventPlayerActionInfo();
		public void UpdateKeys();
		public void ChangeBindingPlayerAction(string actionId);
		public void StopUseBinding();
		public string GetActionId();
		public new void AddListener(UnityAction<T0> call);
		public new void RemoveListener(UnityAction<T0> call);
		public new void RemoveAllListeners();
	}

	[Serializable]
	public class UIEvent<T0, T1> : UnityEvent<T0, T1>, IBindingTarget // TypeDefIndex: 85215
	{
		// Fields
		private bool m_bindingInit;
		[FormerlySerializedAs("_useBindingKeys")]
		[FormerlySerializedAs("useBindingKeys")]
		public bool useBindingAction;
		public string playerActionId;
		[SerializeReference]
		public PlayerActionInfo anonymousPlayerActionInfo;
		[NonSerialized]
		public string anonymousPlayerActionId;
		[CompilerGenerated]
		private int _bindingId_k__BackingField;
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField;
		private Action m_bindAct;
		private Action m_onUpdateKeyAct;
		private List<UnityAction<T0, T1>> m_calls;
	
		// Properties
		public bool bindingEnabled { get; }
		public int bindingId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int count { get; }
	
		// Constructors
		public UIEvent();
	
		// Methods
		private void _CreatePlayerActionBinding();
		public void InitBinding(IBindingGroupTarget parent, Action bindAct, Action onUpdateKeyAct);
		public new void Invoke(T0 arg0, T1 arg1);
		public void UpdateKeys();
		public void ChangeBindingPlayerAction(string actionId);
		public new void AddListener(UnityAction<T0, T1> call);
		public new void RemoveListener(UnityAction<T0, T1> call);
		public new void RemoveAllListeners();
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 85134
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 85135
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 85136
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 85137
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 85138
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 85139
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 85140
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 85131
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 85218
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018C277AC0-0x000000018C277B24
	
		// Methods
		public bool __Gen_Wrap_0(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public NaviScope __Gen_Wrap_1(object P0); // 0x0000000184997E60-0x0000000184998780
		public NaviScope __Gen_Wrap_2(object P0, object P1); // 0x000000018499B1E0-0x000000018499BBE0
		public void __Gen_Wrap_3(object P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_4(ref bool P0, bool P1); // 0x00000001849A06B0-0x00000001849A08F0
		public void __Gen_Wrap_5(object P0, bool P1); // 0x000000018936C508-0x000000018936C5D8
		public uint __Gen_Wrap_6(); // 0x00000001825212D0-0x00000001825214A0
		public void __Gen_Wrap_7(object P0, object P1); // 0x0000000182E75140-0x0000000182E754C0
		public void __Gen_Wrap_8(object P0, bool P1, bool P2); // 0x00000001824EC140-0x00000001824EC440
		public void __Gen_Wrap_9(object P0, int P1, bool P2); // 0x000000018258AE50-0x000000018258B140
		public void __Gen_Wrap_10(object P0, NavigationBindingType P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_11(object P0, object P1, bool P2); // 0x00000001825283D0-0x0000000182528770
		public int __Gen_Wrap_12(object P0, int P1, object P2); // 0x0000000182660990-0x0000000182660D30
		public int __Gen_Wrap_13(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public bool __Gen_Wrap_14(object P0, int P1); // 0x0000000182460990-0x0000000182460C70
		public Vector3 __Gen_Wrap_15(object P0, NaviDirection P1); // 0x0000000184994E40-0x0000000184995740
		public Vector3 __Gen_Wrap_16(object P0, Vector2 P1); // 0x0000000184995740-0x00000001849963A0
		public Selectable __Gen_Wrap_17(object P0, object P1, Vector3 P2, Vector3 P3, NaviStrategy P4, double P5, out double P6); // 0x00000001849963A0-0x0000000184997110
		public Selectable __Gen_Wrap_18(object P0, object P1, Vector3 P2, Vector3 P3, double P4, out double P5); // 0x0000000184997110-0x0000000184997E60
		public bool __Gen_Wrap_19(object P0, NaviDirection P1); // 0x0000000182460990-0x0000000182460C70
		public bool __Gen_Wrap_20(object P0, NaviDirection P1, bool P2, bool P3); // 0x000000018334D1D0-0x000000018334D500
		public bool __Gen_Wrap_21(bool P0, bool P1); // 0x000000018262ADA0-0x000000018262AFC0
		public int __Gen_Wrap_22(); // 0x00000001825212D0-0x00000001825214A0
		public PlayerActionInfo __Gen_Wrap_23(object P0, object P1, InputSettingLevel P2); // 0x0000000184998780-0x00000001849991C0
		public KeyboardCheckerBase.Binding __Gen_Wrap_24(object P0, object P1, object P2, bool P3); // 0x00000001849991C0-0x0000000184999CD0
		public void __Gen_Wrap_25(object P0, object P1, object P2); // 0x0000000182532090-0x00000001825324E0
		public DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __Gen_Wrap_26(object P0, object P1); // 0x0000000184999CD0-0x000000018499A6D0
		public GamepadCheckerBase.Binding __Gen_Wrap_27(object P0, object P1, object P2, bool P3); // 0x000000018499A6D0-0x000000018499B1E0
		public int __Gen_Wrap_28(object P0, object P1, object P2, object P3, int P4); // 0x0000000182E859C0-0x0000000182E85F00
		public int __Gen_Wrap_29(object P0, object P1, object P2, int P3); // 0x0000000183B11FB0-0x0000000183B12420
		public void __Gen_Wrap_30(object P0, object P1, NaviDirection P2, int P3); // 0x00000001826538B0-0x0000000182653C60
		public SelectableNaviGroup __Gen_Wrap_31(object P0); // 0x000000018499BBE0-0x000000018499C500
		public void __Gen_Wrap_32(object P0, int P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public void __Gen_Wrap_33(object P0, int P1); // 0x00000001824828A0-0x0000000182482B70
		public bool __Gen_Wrap_34(object P0, object P1, object P2); // 0x000000018252A430-0x000000018252A890
		public bool __Gen_Wrap_35(object P0, object P1); // 0x00000001827B9DC0-0x00000001827BA150
		public void __Gen_Wrap_36(object P0, object P1, NavigationBindingType P2); // 0x0000000182528040-0x00000001825283D0
		public void __Gen_Wrap_37(object P0, NaviDirection P1); // 0x00000001824828A0-0x0000000182482B70
		public IReadOnlyCollection<NaviScope> __Gen_Wrap_38(object P0); // 0x000000018499C500-0x000000018499CE20
		public IReadOnlyDictionary<string, NaviScope> __Gen_Wrap_39(object P0); // 0x000000018499CE20-0x000000018499D740
		public string __Gen_Wrap_40(object P0); // 0x000000018499D740-0x000000018499E060
		public DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __Gen_Wrap_41(object P0); // 0x000000018499E060-0x000000018499E980
		public DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>>> __Gen_Wrap_42(object P0); // 0x000000018499E980-0x000000018499F2A0
		public IBindingView __Gen_Wrap_43(object P0); // 0x000000018499F2A0-0x000000018499FBC0
		public GamepadCheckerBase.Binding __Gen_Wrap_44(object P0, object P1, object P2); // 0x000000018499FBC0-0x00000001849A06B0
		public bool __Gen_Wrap_45(object P0, GamepadKeyCode P1, GamepadKeyCode P2); // 0x0000000182508ED0-0x00000001825091C0
		public void __Gen_Wrap_46(object P0, object P1, GamepadKeyCode P2); // 0x0000000182528040-0x00000001825283D0
		public bool __Gen_Wrap_47(object P0, bool P1, bool P2); // 0x00000001831EF6C0-0x00000001831EF9D0
		public void __Gen_Wrap_48(); // 0x000000018253FC00-0x000000018253FDD0
		public void __Gen_Wrap_49(object P0, uint P1, InputContinuousTriggerType P2, float P3); // 0x00000001833D5390-0x00000001833D56A0
		public bool __Gen_Wrap_50(object P0, uint P1, bool P2, InputContinuousTriggerType P3, float P4, bool P5); // 0x00000001849A08F0-0x00000001849A0C50
		public void __Gen_Wrap_51(object P0, uint P1, InputContinuousTriggerType P2, bool P3); // 0x0000000183219A80-0x0000000183219D90
		public void __Gen_Wrap_52(object P0, InputContinuousTriggerType P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_53(object P0, GamepadKeyCode P1); // 0x00000001824828A0-0x0000000182482B70
		public string __Gen_Wrap_54(object P0, object P1); // 0x00000001849A0C50-0x00000001849A1650
		public Action __Gen_Wrap_55(object P0, object P1, GamepadKeyCode P2); // 0x00000001849A1650-0x00000001849A2090
		public float __Gen_Wrap_56(object P0, object P1, int P2); // 0x000000018346B170-0x000000018346B510
		public bool __Gen_Wrap_57(GamepadKeyCode P0); // 0x0000000182220AF0-0x0000000182220CF0
		public RectTransform __Gen_Wrap_58(object P0); // 0x00000001849A2090-0x00000001849A29B0
		public float __Gen_Wrap_59(object P0); // 0x00000001826A2110-0x00000001826A23D0
		public void __Gen_Wrap_60(object P0, float P1); // 0x0000000182659420-0x0000000182659700
		public UnityEngine.InputSystem.Mouse __Gen_Wrap_61(object P0); // 0x00000001849A29B0-0x00000001849A32D0
		public InputActionProperty __Gen_Wrap_62(object P0); // 0x00000001849A32D0-0x00000001849A3BC0
		public void __Gen_Wrap_63(ref InputActionProperty P0, InputActionProperty P1); // 0x00000001849A3BC0-0x00000001849A48C0
		public void __Gen_Wrap_64(object P0, InputActionProperty P1); // 0x00000001849A48C0-0x00000001849A4F30
		public void __Gen_Wrap_65(InputActionProperty P0, object P1, bool P2); // 0x00000001849A4F30-0x00000001849A55D0
		public void __Gen_Wrap_66(object P0, UnityEngine.InputSystem.InputAction.CallbackContext P1); // 0x00000001849A55D0-0x00000001849A5C40
		public bool __Gen_Wrap_67(Selectable P0); // 0x00000001822262C0-0x0000000182226590
		public Selectable __Gen_Wrap_68(object P0); // 0x00000001849A5C40-0x00000001849A6560
		public KeyboardCheckerBase.Binding __Gen_Wrap_69(object P0, object P1, object P2); // 0x00000001849A6560-0x00000001849A7050
		public Func<bool, bool, bool> __Gen_Wrap_70(object P0); // 0x00000001849A7050-0x00000001849A7970
		public object __Gen_Wrap_71(object P0); // 0x00000001849A7970-0x00000001849A8290
		public IBindingGroupTarget __Gen_Wrap_72(object P0); // 0x00000001849A8290-0x00000001849A8BB0
		public bool __Gen_Wrap_73(); // 0x0000000182541760-0x0000000182541930
		public Vector2 __Gen_Wrap_74(object P0, bool P1, bool P2); // 0x00000001849A8BB0-0x00000001849A94D0
		public float __Gen_Wrap_75(object P0, bool P1); // 0x0000000182652990-0x0000000182652C80
		public Vector2 __Gen_Wrap_76(); // 0x00000001849A94D0-0x00000001849A9CD0
		public void __Gen_Wrap_77(bool P0); // 0x0000000182521C80-0x0000000182521E70
		public void __Gen_Wrap_78(object P0, object P1, int P2, bool P3); // 0x000000018247CB50-0x000000018247CF10
		public void __Gen_Wrap_79(Beyond.DeviceInfo.InputType P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_80(object P0, Beyond.DeviceInfo.InputType P1); // 0x00000001824828A0-0x0000000182482B70
		public KeyboardType __Gen_Wrap_81(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_82(object P0, KeyboardType P1); // 0x00000001824828A0-0x0000000182482B70
		public Dictionary<string, HashSet<int>> __Gen_Wrap_83(object P0); // 0x00000001849A9CD0-0x00000001849AA5F0
		public void __Gen_Wrap_84(object P0, object P1, float P2); // 0x00000001827B9100-0x00000001827B94A0
		public void __Gen_Wrap_85(object P0, Beyond.Input.KeyboardKeyCode P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_86(Beyond.Input.KeyboardKeyCode P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_87(GamepadKeyCode P0); // 0x0000000182220CF0-0x0000000182220EE0
		public Beyond.DeviceInfo.ControllerType __Gen_Wrap_88(object P0, object P1, out bool P2); // 0x0000000184846090-0x0000000184846460
		public string __Gen_Wrap_89(GamepadKeyCode P0); // 0x00000001849AA5F0-0x00000001849AAE50
		public string __Gen_Wrap_90(); // 0x00000001849AAE50-0x00000001849AB670
		public string __Gen_Wrap_91(object P0, object P1, bool P2, bool P3); // 0x00000001849AB670-0x00000001849AC0D0
		public string __Gen_Wrap_92(object P0, bool P1, bool P2); // 0x00000001849AC0D0-0x00000001849ACA50
		public string __Gen_Wrap_93(object P0, bool P1, bool P2, bool P3); // 0x00000001849ACA50-0x00000001849AD3E0
		public void __Gen_Wrap_94(object P0, in EventData<bool> P1); // 0x00000001849AD3E0-0x00000001849ADA60
		public List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>>> __Gen_Wrap_95(object P0); // 0x00000001849ADA60-0x00000001849AE380
		public bool __Gen_Wrap_96(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2); // 0x0000000182E0C230-0x0000000182E0C600
		public bool __Gen_Wrap_97(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2, out bool P3); // 0x00000001849AE380-0x00000001849AE790
		public bool __Gen_Wrap_98(object P0, GamepadKeyCode P1, Beyond.Input.InputManager.KeyCodeState P2); // 0x0000000182508ED0-0x00000001825091C0
		public int __Gen_Wrap_99(object P0, object P1, object P2, int P3, out string P4); // 0x00000001849AE790-0x00000001849AF330
		public int __Gen_Wrap_100(object P0, Beyond.Input.KeyboardKeyCode P1, object P2, InputTimingType P3, object P4, int P5); // 0x0000000183386580-0x0000000183386A30
		public bool __Gen_Wrap_101(object P0, int P1, bool P2); // 0x000000018278C5F0-0x000000018278C900
		public void __Gen_Wrap_102(object P0, bool P1, int P2, int P3); // 0x0000000184985060-0x0000000184985370
		public int __Gen_Wrap_103(object P0, bool P1, int P2); // 0x0000000184985370-0x0000000184985670
		public Beyond.Input.KeyboardKeyCode __Gen_Wrap_104(object P0, object P1, bool P2, bool P3, InputSettingLevel P4); // 0x00000001836A0C10-0x00000001836A0FF0
		public GamepadKeyCode __Gen_Wrap_105(object P0, object P1, bool P2, bool P3, InputSettingLevel P4); // 0x00000001836A0C10-0x00000001836A0FF0
		public bool __Gen_Wrap_106(InputDeviceFlags P0, InputDeviceFlags P1); // 0x0000000184985670-0x0000000184985890
		public bool __Gen_Wrap_107(object P0, object P1, InputDeviceFlags P2); // 0x00000001824764D0-0x0000000182476870
		public void __Gen_Wrap_108(object P0, object P1, InputDeviceFlags P2); // 0x0000000182476870-0x0000000182476C00
		public void __Gen_Wrap_109(object P0, InputDeviceFlags P1); // 0x0000000182494990-0x0000000182494C60
		public string __Gen_Wrap_110(object P0, int P1); // 0x0000000184985890-0x00000001849861E0
		public bool __Gen_Wrap_111(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, out bool P3); // 0x00000001836C5E00-0x00000001836C61E0
		public float __Gen_Wrap_112(object P0, object P1); // 0x0000000182E04540-0x0000000182E048D0
		public void __Gen_Wrap_113(object P0, int P1, out string P2, out IBindingView P3); // 0x00000001849861E0-0x0000000184986F20
		public PlayerActionInfo __Gen_Wrap_114(object P0, object P1); // 0x0000000184986F20-0x0000000184987920
		public bool __Gen_Wrap_115(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, bool P3, object P4); // 0x0000000184987920-0x0000000184987DC0
		public bool __Gen_Wrap_116(object P0, object P1, GamepadKeyCode? P2, GamepadKeyCode? P3, bool P4, object P5); // 0x0000000184987DC0-0x00000001849886E0
		public Vector3 __Gen_Wrap_117(); // 0x00000001849886E0-0x0000000184988ED0
		public void __Gen_Wrap_118(Vector2 P0, bool P1); // 0x0000000184988ED0-0x00000001849894A0
		public void __Gen_Wrap_119(object P0, Vector2 P1); // 0x00000001849894A0-0x0000000184989B20
		public bool __Gen_Wrap_120(int P0); // 0x0000000182220AF0-0x0000000182220CF0
		public bool __Gen_Wrap_121(bool P0); // 0x00000001822291E0-0x00000001822293E0
		public List<Beyond.Input.InputManager.ControllerHintInfo> __Gen_Wrap_122(object P0); // 0x0000000184989B20-0x000000018498A440
		public void __Gen_Wrap_123(object P0, object P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3); // 0x000000018498A440-0x000000018498AFE0
		public void __Gen_Wrap_124(object P0, int P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3); // 0x000000018498AFE0-0x000000018498BAE0
		public void __Gen_Wrap_125(object P0, object P1, ref List<Beyond.Input.InputManager.ControllerHintInfo> P2); // 0x000000018498BAE0-0x000000018498C660
		public float __Gen_Wrap_126(object P0, object P1, out float P2); // 0x000000018498C660-0x000000018498CA30
		public float __Gen_Wrap_127(object P0, int P1, out float P2); // 0x0000000182E9B030-0x0000000182E9B340
		public void __Gen_Wrap_128(object P0, float P1, float P2); // 0x0000000183E99C30-0x0000000183E99F30
		public string __Gen_Wrap_129(Beyond.Input.KeyboardKeyCode P0); // 0x000000018498CA30-0x000000018498D290
		public string __Gen_Wrap_130(System.Text.RegularExpressions.Match P0); // 0x000000018498D290-0x000000018498DBB0
		public void __Gen_Wrap_131(object P0, object P1, object P2, bool P3); // 0x00000001827A62D0-0x00000001827A6740
		public bool __Gen_Wrap_132(int P0, out Vector2 P1); // 0x000000018498DBB0-0x000000018498E430
		public GameObject __Gen_Wrap_133(object P0, object P1); // 0x000000018498E430-0x000000018498EE30
		public string __Gen_Wrap_134(object P0, Beyond.Input.KeyboardKeyCode P1, bool P2); // 0x000000018498EE30-0x000000018498F7A0
		public string __Gen_Wrap_135(object P0, GamepadKeyCode P1, bool P2); // 0x000000018498F7A0-0x0000000184990110
		public string __Gen_Wrap_136(object P0, object P1, bool P2, bool P3, bool P4); // 0x0000000184990110-0x0000000184990B90
		public void __Gen_Wrap_137(object P0, in EventData<string> P1); // 0x0000000184990B90-0x0000000184991210
		public Beyond.Input.InputManager.DelayedComboBinding __Gen_Wrap_138(object P0, object P1, object P2, Beyond.Input.InputManager.DelayedComboKind P3, float P4, object P5); // 0x0000000184991210-0x0000000184991E10
		public GravitySensorHandle __Gen_Wrap_139(); // 0x0000000184991E10-0x0000000184992630
		public int __Gen_Wrap_140(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public LocalGravitySensor __Gen_Wrap_141(); // 0x0000000184992630-0x0000000184992E50
		public Vector3 __Gen_Wrap_142(object P0); // 0x0000000184992E50-0x0000000184993740
		public CloudGravitySensor __Gen_Wrap_143(); // 0x0000000184993740-0x0000000184993F60
		public void __Gen_Wrap_144(object P0, object P1, Beyond.Input.KeyboardKeyCode P2); // 0x0000000182528040-0x00000001825283D0
		public string __Gen_Wrap_145(ref CursorRequest P0); // 0x0000000184993F60-0x0000000184994E40
		public void __Gen_Wrap_146(object P0, object P1, object P2, object P3); // 0x0000000182558BB0-0x00000001825590D0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 85219
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018C277B24-0x000000018C277BBC
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 85220
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018C27A690-0x000000018C27A6F4
		public static bool IsPatched(int id); // 0x000000018C27A780-0x000000018C27A7FC
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018C27A548-0x000000018C27A614
		public object CreateWrapper(int id); // 0x000000018C27A614-0x000000018C27A690
		public object InitWrapperArray(int len); // 0x000000018C27A6F4-0x000000018C27A780
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018C27A4A4-0x000000018C27A548
	}

	public delegate bool __HotPatchDelegate_0(object P0); // TypeDefIndex: 85221; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum HotPatchIDMAP0 // TypeDefIndex: 85222
	{
		Beyond-Input-InputManager-get_usingController0 = 0,
		Beyond-Input-InputBindingGroup-get_selfEnabled0 = 0,
		Beyond-Input-InputBindingGroup-get_parentEnabled0 = 0,
		Beyond-Input-InputBindingGroup-get_parentIgnored0 = 0,
		Beyond-Input-InputBindingGroup-get_enabled0 = 0,
		Beyond-Input-InputBindingInfo-get_groupEnabled0 = 0,
		Beyond-Input-InputBindingInfo-get_selfEnabled0 = 0,
		Beyond-Input-ControllerNaviManager-IsNavigationBindingEnabled0 = 0,
		Beyond-Input-InputBindingInfo-get_parentIgnored0 = 0,
		Beyond-Input-InputBindingGroup-get_targetActiveInHierarchy0 = 0,
		Beyond-Input-InputBindingInfo-get_enabled0 = 0,
		Beyond-Input-InputBindingInfo-get_forceKeyhintToGrayState0 = 0,
		Beyond-Input-InputBindingGroupMonoTarget-get_groupEnabled0 = 0,
		Beyond-Input-InputBindingGroupMonoTarget-get_internalEnabled0 = 0,
		Beyond-Input-RealCursorManager-get_isDebugForceShow0 = 0,
		Beyond-Input-InputManager-get_isDebugForceShow0 = 0,
		Beyond-Input-InputManager-AnyGamepadKey0 = 0,
		Beyond-Input-InputManager-AnyMouseKeyDown0 = 0,
		Beyond-Input-InputManager-get_virtualMouseIconVisible0 = 0,
		Beyond-Input-InputManager-_CheckAnyKeyForTouchChangeDevice0 = 0,
		Beyond-Input-InputManager-AnyMouseKeyUp0 = 0,
		Beyond-Input-InputManager-_AnyKeyDownForKeyboardChangeDevice0 = 0,
		Beyond-Input-InputManager-_CheckAnyKeyForKeyboardChangeDevice0 = 0,
		Beyond-Input-InputManager-AnyMouseKey0 = 0,
		Beyond-Input-LocalGravitySensor-get_isReady0 = 0,
		Beyond-Input-CloudGravitySensor-get_isReady0 = 0,
		Beyond-Input-GravitySensorHandle-get_isReady0 = 0,
		Beyond-Input-KeyboardInput-IsValid0 = 0,
		Beyond-Input-GamepadInput-IsValid0 = 0,
		Beyond-Input-UIEvent-get_bindingEnabled0 = 0,
		Beyond-Input-ControllerNaviManager-_GetTopScope0 = 1,
		Beyond-Input-ControllerNaviManager-_GetOrCreateScope0 = 2,
		Beyond-Input-ControllerNaviManager-_ResolveScopeForLayer0 = 2,
		Beyond-Input-InputManager-MarkBindingStateChanged0 = 3,
		Beyond-Input-InputBindingInfo-StopContinuousTrigger0 = 3,
		Beyond-Input-InputBindingGroupMonoTarget-UpdateState0 = 3,
		Beyond-Input-InputBindingGroupMonoTarget-Init0 = 3,
		Beyond-Input-ControllerNaviManager-UpdateNaviInputBindingState0 = 3,
		Beyond-Input-ControllerNaviManager-Tick0 = 3,
		Beyond-Input-ControllerNaviManager-TryAutoSetTarget0 = 3,
		Beyond-Input-ControllerNaviManager-ClearTargetForListWrap0 = 3,
		Beyond-Input-ControllerNaviManager-ResetStateForUIDispose0 = 3,
		Beyond-Input-GamepadCheckerBase-CheckGamepadInput0 = 3,
		Beyond-Input-InputBindingInfo-Trigger0 = 3,
		Beyond-Input-GamepadCheckerBase-TriggerActions0 = 3,
		Beyond-Input-GamepadOnReleaseChecker-CheckGamepadInput0 = 3,
		Beyond-Input-HGVirtualMouse-_SyncScale0 = 3,
		Beyond-Input-HGVirtualMouse-OnEnable0 = 3,
		Beyond-Input-HGVirtualMouse-OnDisable0 = 3,
		Beyond-Input-HGVirtualMouse-_UpdateMotion0 = 3,
		Beyond-Input-HGVirtualMouse-ClearLeftButtonState0 = 3,
		Beyond-Input-HGVirtualMouse-OnAfterInputUpdate0 = 3,
		Beyond-Input-HGVirtualMouse-Update0 = 3,
		Beyond-Input-InputBindingInfo-OnDelete0 = 3,
		Beyond-Input-HGVirtualMouse-OnDestroy0 = 3,
		Beyond-Input-HGVirtualMouse-Awake0 = 3,
		Beyond-Input-InputBindingGroupMonoTarget-DeleteGroup0 = 3,
		Beyond-Input-InputBindingGroupMonoTarget-Awake0 = 3,
		Beyond-Input-InputBindingGroupMonoTarget-OnEnable0 = 3,
		Beyond-Input-InputBindingGroupMonoTarget-OnDisable0 = 3,
		Beyond-Input-InputBindingGroupMonoTarget-OnDestroy0 = 3,
		Beyond-Input-InputManager-_CheckVirtualMouseState0 = 3,
		Beyond-Input-InputManager-_RefreshDeviceChangeBinding0 = 3,
		Beyond-Input-RealCursorManager-_RefreshActiveHighest0 = 3,
		Beyond-Input-InputManager-_SetInputBindingMask0 = 3,
		Beyond-Input-InputManager-_SyncUsingControllerState0 = 3,
		Beyond-Input-InputManager-_CreateTickFunction0 = 3,
		Beyond-Input-InputManager-_LoadCustomInputSetting0 = 3,
		Beyond-Input-InputManager-_LoadSetting0 = 3,
		Beyond-Input-InputManager-_TryFindGamepad0 = 3,
		Beyond-Input-InputManager-_CreateDebugVirtualMouse0 = 3,
		Beyond-Input-InputManager-_CreateVirtualMouse0 = 3,
		Beyond-Input-InputManager-_CreateCanvas0 = 3,
		Beyond-Input-InputManager-_InitDeviceChangeBinding0 = 3,
		Beyond-Input-InputManager-KeyCaches-UpdateKeyStat0 = 3,
		Beyond-Input-InputManager-CheckUsingController0 = 3,
		Beyond-Input-KeyboardCheckerBase-CheckKeyboardInput0 = 3,
		Beyond-Input-KeyboardCheckerBase-TriggerActions0 = 3,
		Beyond-Input-InputManager-_ControllerTouchPanelTick0 = 3,
		Beyond-Input-InputManager-_CheckInput0 = 3,
		Beyond-Input-InputManager-_TryStopDeviceSwitchSuppression0 = 3,
		Beyond-Input-InputManager-_OnAfterInputUpdate0 = 3,
		Beyond-Input-InputManager-_Init0 = 3,
		Beyond-Input-InputManager-_ClearTickFunction0 = 3,
		Beyond-Input-InputManager-Release0 = 3,
		Beyond-Input-RealCursorManager-RestoreMouseSpeed0 = 3,
		Beyond-Input-InputManager-_ClearEvents0 = 3,
		Beyond-Input-InputManager-OnApplicationQuit0 = 3,
		Beyond-Input-KeyboardOnClickChecker-ClearCombinationKeyPressedInfo0 = 3,
		Beyond-Input-InputManager-_ClearKeyboardCheckerBindings0 = 3,
		Beyond-Input-InputManager-_ClearGamepadBindingDic0 = 3,
		Beyond-Input-InputManager-_ClearGamepadCheckerBindings0 = 3,
		Beyond-Input-InputManager-_ClearAllCheckerPressedStates0 = 3,
		Beyond-Input-InputManager-ClearAllCursorShowRequests0 = 3,
		Beyond-Input-InputManager-ToggleDebugCursorMode0 = 3,
		Beyond-Input-InputManager-LoadSetting0 = 3,
		Beyond-Input-InputManager-ClearPendingInputSetting0 = 3,
		Beyond-Input-InputManager-SaveCustomInputSetting0 = 3,
		Beyond-Input-InputManager-ClearGuideUseActionIds0 = 3,
		Beyond-Input-InputManager-Dispose0 = 3,
		Beyond-Input-RealCursorManager-ClearMouseSpeedOverride0 = 3,
		Beyond-Input-InputManager-ClearMouseSpeedOverride0 = 3,
		Beyond-Input-InputManager-SetGravitySensor0 = 3,
		Beyond-Input-InputManager-ControllerHintInfo-OnAllocate0 = 3,
		Beyond-Input-InputManager-ControllerHintInfo-OnRecycle0 = 3,
		Beyond-Input-LocalGravitySensor-Enable0 = 3,
		Beyond-Input-LocalGravitySensor-Disable0 = 3,
		Beyond-Input-CloudGravitySensor-Enable0 = 3,
		Beyond-Input-CloudGravitySensor-Disable0 = 3,
		Beyond-Input-GravitySensorHandle-Enable0 = 3,
		Beyond-Input-GravitySensorHandle-Disable0 = 3,
		Beyond-Input-GravitySensorHandle-Dispose0 = 3,
		Beyond-Input-KeyboardChecker-CheckKeyboardInput0 = 3,
		Beyond-Input-KeyboardChecker-TriggerActions0 = 3,
		Beyond-Input-KeyboardOnClickChecker-CheckKeyboardInput0 = 3,
		Beyond-Input-KeyboardOnClickChecker-TriggerActions0 = 3,
		Beyond-Input-KeyboardOnLongPressChecker-CheckKeyboardInput0 = 3,
		Beyond-Input-PlayerActionInfo-ResetHintProority0 = 3,
		Beyond-Input-KeyboardInput-ClearKeyCode0 = 3,
		Beyond-Input-GamepadInput-ClearKeyCode0 = 3,
		Beyond-Input-UIEvent-_CreatePlayerActionBinding0 = 3,
		Beyond-Input-UIEvent-Invoke0 = 3,
		Beyond-Input-UIEvent-UpdateKeys0 = 3,
		Beyond-Input-UIEvent-RemoveAllListeners0 = 3,
		Beyond-Input-InputBindingStateField-Set0 = 4,
		Beyond-Input-InputBindingGroup-set_selfEnabled0 = 5,
		Beyond-Input-InputBindingInfo-set_groupEnabled0 = 5,
		Beyond-Input-InputBindingGroup-set_parentEnabled0 = 5,
		Beyond-Input-InputBindingGroup-_OnBindingGroupStateChanged0 = 5,
		Beyond-Input-InputBindingGroup-SetSelfEnabled0 = 5,
		Beyond-Input-ControllerNaviManager-SetForceEnableNavi0 = 5,
		Beyond-Input-HGVirtualMouse-SetMouseIconVisible0 = 5,
		Beyond-Input-HGVirtualMouse-TriggerLeftButton0 = 5,
		Beyond-Input-HGVirtualMouse-_ChangeHoverState0 = 5,
		Beyond-Input-InputBindingInfo-set_selfEnabled0 = 5,
		Beyond-Input-InputBindingInfo-set_parentIgnored0 = 5,
		Beyond-Input-InputBindingInfo-set_forceKeyhintToGrayState0 = 5,
		Beyond-Input-InputBindingInfo-SetSelfEnabled0 = 5,
		Beyond-Input-InputBindingInfo-SetParentIgnored0 = 5,
		Beyond-Input-InputBindingGroup-set_parentIgnored0 = 5,
		Beyond-Input-InputBindingGroupMonoTarget-set_internalEnabled0 = 5,
		Beyond-Input-RealCursorManager-CalcState0 = 5,
		Beyond-Input-RealCursorManager-SetVirtualMouseActive0 = 5,
		Beyond-Input-InputManager-set_usingController0 = 5,
		Beyond-Input-InputManager-OnApplicationFocus0 = 5,
		Beyond-Input-InputManager-ToggleInputDeviceChangeMode0 = 5,
		Beyond-Input-InputManager-SetCursorOverrideForDeviceChange0 = 5,
		Beyond-Input-InputManager-ToggleAllInput0 = 5,
		Beyond-Input-InputManager-SetVirtualMouseIconVisible0 = 5,
		Beyond-Input-InputUtils-IgnoreBindingParent0 = 5,
		Beyond-Input-InputUtils-IgnoreBindingGroupParent0 = 5,
		Beyond-Input-InputBindingInfo-_GetNextEnabledPriority0 = 6,
		Beyond-Input-KeyboardOnLongPressChecker-CancelPendingLongPress0 = 7,
		Beyond-Input-GamepadOnLongPressChecker-CancelPendingLongPress0 = 7,
		Beyond-Input-InputManager-CancelPendingLongPress0 = 7,
		Beyond-Input-ControllerNaviManager-_OnLayerSelected0 = 7,
		Beyond-Input-InputBindingGroup-set_groupTarget0 = 7,
		Beyond-Input-ControllerNaviManager-_SetTarget0 = 7,
		Beyond-Input-ControllerNaviManager-_SetTargetFromNavigation0 = 7,
		Beyond-Input-InputManager-_AddPlayerActionCheck2 = 7,
		Beyond-Input-ControllerNaviManager-_OnTopChanged0 = 7,
		Beyond-Input-ControllerNaviManager-PushScope0 = 7,
		Beyond-Input-ControllerNaviManager-PopScope1 = 7,
		Beyond-Input-ControllerNaviManager-TryRemoveLayer0 = 7,
		Beyond-Input-ControllerNaviManager-SetTarget0 = 7,
		Beyond-Input-HGVirtualMouse-set_cursorTransform0 = 7,
		Beyond-Input-InputManager-_RemovePlayerActionCheck2 = 7,
		Beyond-Input-InputManager-_RealRemoveBindingInfo0 = 7,
		Beyond-Input-InputManager-_DeleteInGroup0 = 7,
		Beyond-Input-InputBindingInfo-set_bindingView0 = 7,
		Beyond-Input-InputBindingInfo-set_text0 = 7,
		Beyond-Input-InputBindingInfo-ChangeGroup0 = 7,
		Beyond-Input-InputBindingGroup-set_groupView0 = 7,
		Beyond-Input-InputBindingGroup-ChangeParent0 = 7,
		Beyond-Input-RealCursorManager-RemoveRequest0 = 7,
		Beyond-Input-InputManager-_UpdateTriggerThenModifierCombo0 = 7,
		Beyond-Input-KeyboardHandler-ParseConfig0 = 7,
		Beyond-Input-InputManager-_OnAnySelectableInteractableChanged0 = 7,
		Beyond-Input-InputManager-_SetJoystick0 = 7,
		Beyond-Input-InputManager-_OnControllerConnected0 = 7,
		Beyond-Input-InputManager-_OnControllerDisconnected0 = 7,
		Beyond-Input-InputManager-ControllerHintInfo-Reset1 = 7,
		Beyond-Input-InputManager-AddGuideUseActionId0 = 7,
		Beyond-Input-InputManager-RemoveGuideUseActionId0 = 7,
		Beyond-Input-InputManager-_RefreshDelayedComboKeys0 = 7,
		Beyond-Input-InputManager-UnregisterDelayedCombo0 = 7,
		Beyond-Input-KeyboardInput-CopyFrom0 = 7,
		Beyond-Input-GamepadInput-CopyFrom0 = 7,
		Beyond-Input-UIEvent-ChangeBindingPlayerAction0 = 7,
		Beyond-Input-UIEvent-AddListener0 = 7,
		Beyond-Input-UIEvent-RemoveListener0 = 7,
		Beyond-Input-InputBindingInfo-OnGroupEnabledChanged0 = 8,
		Beyond-Input-InputBindingGroup-OnParentEnabledChanged0 = 8,
		Beyond-Input-InputBindingGroup-SetParentIgnored0 = 8,
		Beyond-Input-RealCursorManager-_ToggleCursorInternal0 = 8,
		Beyond-Input-InputManager-_ToggleVirtualMouse0 = 8,
		Beyond-Input-InputManager-ToggleGroup0 = 9,
		Beyond-Input-InputManager-ToggleBinding0 = 9,
		Beyond-Input-InputManager-ForceBindingKeyhintToGray0 = 9,
		Beyond-Input-InputManager-IgnoreBindingGroupParent0 = 9,
		Beyond-Input-InputManager-IgnoreBindingParent0 = 9,
		Beyond-Input-ControllerNaviManager-SetNaviBindingType0 = 10,
		Beyond-Input-ControllerNaviManager-_RemoveLayerFromStack0 = 11,
		Beyond-Input-ControllerNaviManager-_FlushScopeLayers0 = 11,
		Beyond-Input-ControllerNaviManager-PopScope0 = 11,
		Beyond-Input-ControllerNaviManager-ToggleNavigation0 = 11,
		Beyond-Input-HGVirtualMouse-ChangeHoverState0 = 11,
		Beyond-Input-InputManager-_DeleteGroup0 = 11,
		Beyond-Input-InputManager-SetCursorShowRequest0 = 11,
		Beyond-Input-InputManager-CreateGroup0 = 12,
		Beyond-Input-InputBindingGroupMonoTarget-get_groupId0 = 13,
		Beyond-Input-KeyboardCheckerBase-GetModifyIndex0 = 13,
		Beyond-Input-InputManager-get_rootGroupId0 = 13,
		Beyond-Input-InputManager-GetTouchId0 = 13,
		Beyond-Input-KeyboardInput-GetKeyCodeEnumIntValue0 = 13,
		Beyond-Input-GamepadInput-GetKeyCodeEnumIntValue0 = 13,
		Beyond-Input-UIEvent-get_count0 = 13,
		Beyond-Input-InputManager-IsGroupEnabled0 = 14,
		Beyond-Input-ControllerNaviManager-IsPanelScopeTop0 = 14,
		Beyond-Input-RealCursorManager-HasAnyShowRequestAtPriority0 = 14,
		Beyond-Input-InputManager-IsGroupParentDisabled0 = 14,
		Beyond-Input-InputManager-IsBindingKeyhintGray0 = 14,
		Beyond-Input-InputManager-HasBinding0 = 14,
		Beyond-Input-InputManager-IsAnyBindingInGroupGuideUse0 = 14,
		Beyond-Input-ControllerNaviManager-GetNaviVector0 = 15,
		Beyond-Input-ControllerNaviManager-_GetPointOnRectEdge0 = 16,
		Beyond-Input-ControllerNaviManager-_TryFindBestNaviTarget0 = 17,
		Beyond-Input-ControllerNaviManager-_TryFindBestNaviTargetInGroup0 = 18,
		Beyond-Input-ControllerNaviManager-_DefaultNavigate0 = 19,
		Beyond-Input-ControllerNaviManager-_Navigate0 = 20,
		Beyond-Input-InputManager-get_invalidID0 = 21,
		Beyond-Input-InputManager-GetPlayerActionInfo0 = 22,
		Beyond-Input-KeyboardCheckerBase-OnCreateBinding0 = 23,
		Beyond-Input-KeyboardOnLongPressChecker-OnCreateBinding0 = 23,
		Beyond-Input-InputManager-_AddPlayerActionCheck0 = 24,
		Beyond-Input-InputManager-_AddPlayerActionCheck1 = 24,
		Beyond-Input-InputManager-_RemovePlayerActionCheck0 = 24,
		Beyond-Input-InputManager-_RemovePlayerActionCheck1 = 24,
		Beyond-Input-InputManager-ChangePlayerAction0 = 24,
		Beyond-Input-InputManager-SetCustomControllerMouse0 = 24,
		Beyond-Input-InputManager-ControllerHintInfo-Reset0 = 24,
		Beyond-Input-InputManager-MoveMouseTo0 = 24,
		Beyond-Input-GamepadCheckerBase-GetInputDic0 = 25,
		Beyond-Input-GamepadCheckerBase-OnCreateBinding0 = 26,
		Beyond-Input-GamepadOnLongPressChecker-OnCreateBinding0 = 26,
		Beyond-Input-InputManager-_CreateBindingCore0 = 27,
		Beyond-Input-InputManager-CreateRepeatAwareBindingByActionId0 = 28,
		Beyond-Input-InputManager-CreateBindingByActionId0 = 28,
		Beyond-Input-InputManager-CreateBinding0 = 28,
		Beyond-Input-ControllerNaviManager-_CreateNavigationBinding0 = 29,
		Beyond-Input-ControllerNaviManager-_GetTopLayer0 = 30,
		Beyond-Input-ControllerNaviManager-RegisterPanelScope0 = 31,
		Beyond-Input-InputManager-SetBindingView0 = 31,
		Beyond-Input-InputManager-SetGroupView0 = 31,
		Beyond-Input-InputManager-SetBindingText0 = 31,
		Beyond-Input-ControllerNaviManager-UnregisterPanelScope0 = 32,
		Beyond-Input-ControllerNaviManager-ClearTargetForPanel0 = 32,
		Beyond-Input-InputManager-DeleteGroup0 = 32,
		Beyond-Input-RealCursorManager-RemoveAllRequestsAtPriority0 = 32,
		Beyond-Input-InputManager-DeleteBinding0 = 32,
		Beyond-Input-InputManager-DeleteInGroup0 = 32,
		Beyond-Input-KeyboardInput-SetKeyCodeEnumByIntValue0 = 32,
		Beyond-Input-GamepadInput-SetKeyCodeEnumByIntValue0 = 32,
		Beyond-Input-ControllerNaviManager-_RemoveLayer0 = 33,
		Beyond-Input-ControllerNaviManager-IsLayerInStack0 = 34,
		Beyond-Input-ControllerNaviManager-IsLayerTracked0 = 34,
		Beyond-Input-ControllerNaviManager-IsTopLayer0 = 34,
		Beyond-Input-ControllerNaviManager-IsNaviTarget0 = 34,
		Beyond-Input-InputManager-IsGuideUseAction0 = 34,
		Beyond-Input-InputManager-_IsValidJoystick0 = 34,
		Beyond-Input-InputManager-IsPlayerActionIdValid0 = 34,
		Beyond-Input-InputManager-_IsAnyBindingInGroupGuideUse0 = 34,
		Beyond-Input-KeyboardInput-Equals0 = 34,
		Beyond-Input-GamepadInput-Equals0 = 34,
		Beyond-Input-ControllerNaviManager-ChangeAndTrySetNaviBindingType0 = 35,
		Beyond-Input-ControllerNaviManager-Navigate0 = 36,
		Beyond-Input-ControllerNaviManager-get_scopeStack0 = 37,
		Beyond-Input-ControllerNaviManager-get_registeredScopes0 = 38,
		Beyond-Input-ControllerNaviManager-DumpNaviState0 = 39,
		Beyond-Input-InputBindingInfo-get_text0 = 39,
		Beyond-Input-InputManager-ParseTextActionId0 = 39,
		Beyond-Input-InputManager-GetCurJsInfos0 = 39,
		Beyond-Input-RealCursorManager-DumpState0 = 39,
		Beyond-Input-InputManager-GetRealCursorState0 = 39,
		Beyond-Input-KeyboardInput-GetModifyText0 = 39,
		Beyond-Input-KeyboardInput-GetKeyCodeText0 = 39,
		Beyond-Input-KeyboardInput-get_modifyString0 = 39,
		Beyond-Input-GamepadInput-GetModifyText0 = 39,
		Beyond-Input-GamepadInput-GetKeyCodeText0 = 39,
		Beyond-Input-GamepadCheckerBase-get_normalBindingInfos0 = 40,
		Beyond-Input-GamepadCheckerBase-get_modifyBindingInfos0 = 41,
		Beyond-Input-InputBindingGroup-get_groupView0 = 42,
		Beyond-Input-InputBindingInfo-get_bindingView0 = 42,
		Beyond-Input-GamepadCheckerBase-OnDeleteBinding0 = 43,
		Beyond-Input-GamepadOnLongPressChecker-OnDeleteBinding0 = 43,
		Beyond-Input-GamepadCheckerBase-HasEnabledBinding0 = 44,
		Beyond-Input-InputManager-HasEnabledGamepadLongPressBinding0 = 44,
		Beyond-Input-GamepadCheckerBase-CheckDic0 = 45,
		Beyond-Input-GamepadChecker-CheckDic0 = 45,
		Beyond-Input-GamepadOnClickChecker-CheckDic0 = 45,
		Beyond-Input-GamepadOnLongPressChecker-_OnTriggerBinding0 = 45,
		Beyond-Input-GamepadOnLongPressChecker-CheckDic0 = 45,
		Beyond-Input-GamepadOnReleaseChecker-CheckDic0 = 45,
		Beyond-Input-InputBindingInfo-_RealTriggerCallback0 = 46,
		Beyond-Input-InputBindingInfo-_StartRepeatFailureDelay0 = 47,
		Beyond-Input-InputBindingInfo-_TryContinuousTrigger0 = 48,
		Beyond-Input-InputBindingInfo-_ScheduleContinuousTrigger0 = 49,
		Beyond-Input-InputBindingInfo-StartContinuousTrigger0 = 50,
		Beyond-Input-GamepadOnClickChecker-ClearKeyPressed0 = 51,
		Beyond-Input-InputManager-GetActionText0 = 52,
		Beyond-Input-InputManager-GetActionText1 = 52,
		Beyond-Input-InputManager-AddAnonymousPlayerAction0 = 52,
		Beyond-Input-InputManager-_GetBindingName0 = 52,
		Beyond-Input-InputManager-PrintBindingInfo0 = 52,
		Beyond-Input-InputManager-PrintActionInfo0 = 52,
		Beyond-Input-GamepadOnLongPressChecker-CreateTriggerBindingAction0 = 53,
		Beyond-Input-GamepadOnLongPressChecker-GetInputLongPressStartTime0 = 54,
		Beyond-Input-KeyboardOnLongPressChecker-GetInputLongPressStartTime0 = 54,
		Beyond-Input-HGVirtualMouse-get_cursorTransform0 = 55,
		Beyond-Input-HGVirtualMouse-get_scrollSpeed0 = 56,
		Beyond-Input-HGVirtualMouse-set_scrollSpeed0 = 57,
		Beyond-Input-InputManager-_UpdateDelayedCombos0 = 57,
		Beyond-Input-InputManager-LateTick0 = 57,
		Beyond-Input-RealCursorManager-SetMouseSpeedOverride0 = 57,
		Beyond-Input-InputManager-SetMouseSpeedOverride0 = 57,
		Beyond-Input-HGVirtualMouse-get_virtualMouse0 = 58,
		Beyond-Input-HGVirtualMouse-get_stickAction0 = 59,
		Beyond-Input-HGVirtualMouse-get_leftButtonAction0 = 59,
		Beyond-Input-HGVirtualMouse-get_rightButtonAction0 = 59,
		Beyond-Input-HGVirtualMouse-get_middleButtonAction0 = 59,
		Beyond-Input-HGVirtualMouse-get_forwardButtonAction0 = 59,
		Beyond-Input-HGVirtualMouse-get_backButtonAction0 = 59,
		Beyond-Input-HGVirtualMouse-get_scrollWheelAction0 = 59,
		Beyond-Input-HGVirtualMouse-_SetAction0 = 60,
		Beyond-Input-HGVirtualMouse-set_stickAction0 = 61,
		Beyond-Input-HGVirtualMouse-set_leftButtonAction0 = 61,
		Beyond-Input-HGVirtualMouse-set_rightButtonAction0 = 61,
		Beyond-Input-HGVirtualMouse-set_middleButtonAction0 = 61,
		Beyond-Input-HGVirtualMouse-set_forwardButtonAction0 = 61,
		Beyond-Input-HGVirtualMouse-set_backButtonAction0 = 61,
		Beyond-Input-HGVirtualMouse-set_scrollWheelAction0 = 61,
		Beyond-Input-HGVirtualMouse-_SetActionCallback0 = 62,
		Beyond-Input-HGVirtualMouse-_OnButtonActionTriggered0 = 63,
		Beyond-Input-HGVirtualMouse-GetCurHoverSelectable0 = 64,
		Beyond-Input-KeyboardCheckerBase-OnDeleteBinding0 = 65,
		Beyond-Input-KeyboardOnLongPressChecker-OnDeleteBinding0 = 65,
		Beyond-Input-InputBindingInfo-_WrapCallback0 = 66,
		Beyond-Input-InputBindingInfo-GetCallbackTarget0 = 67,
		Beyond-Input-InputBindingGroup-get_groupTarget0 = 68,
		Beyond-Input-InputBindingGroupMonoTarget-get_parentTarget0 = 68,
		Beyond-Input-InputManager-get_cursorVisible0 = 69,
		Beyond-Input-InputManager-get_isInputSuppressedByDeviceSwitch0 = 69,
		Beyond-Input-InputManager-AnyKeyDown0 = 69,
		Beyond-Input-InputManager-AnyTouchBegan0 = 69,
		Beyond-Input-InputManager-get_anyKeyDown0 = 69,
		Beyond-Input-InputManager-get_multiTouchEnabled0 = 69,
		Beyond-Input-InputManager-get_autoUpdateInputBindingMask0 = 69,
		Beyond-Input-InputManager-AnyTouchActive0 = 69,
		Beyond-Input-InputManager-GetGamepadStickValue0 = 70,
		Beyond-Input-InputManager-GetGamepadTriggerValue0 = 71,
		Beyond-Input-InputManager-get_mouseScrollDelta0 = 72,
		Beyond-Input-InputManager-set_multiTouchEnabled0 = 73,
		Beyond-Input-InputManager-set_autoUpdateInputBindingMask0 = 73,
		Beyond-Input-RealCursorManager-SetRequest0 = 74,
		Beyond-Input-InputManager-_UpdateInputBindingMask0 = 75,
		Beyond-Input-InputManager-ChangeInputTypeAndSyncState0 = 76,
		Beyond-Input-InputManager-_TryChangeInputDeviceType0 = 76,
		Beyond-Input-KeyboardHandler-GetKeyboardType0 = 77,
		Beyond-Input-InputManager-get_keyboardType0 = 77,
		Beyond-Input-KeyboardHandler-SetKeyboardType0 = 78,
		Beyond-Input-InputManager-set_keyboardType0 = 78,
		Beyond-Input-InputManager-get_action2BindingDic0 = 79,
		Beyond-Input-InputManager-_UpdateModifierTapThenTriggerCombo0 = 80,
		Beyond-Input-KeyboardOnClickChecker-ClearKeyPressed0 = 81,
		Beyond-Input-InputManager-_GetControllerType0 = 82,
		Beyond-Input-InputManager-GetStringByGamepadKeyCode0 = 83,
		Beyond-Input-InputManager-_GetGamepadKeyIconFolderPath0 = 84,
		Beyond-Input-InputManager-_GetKeyIconPath0 = 85,
		Beyond-Input-InputManager-GetGamepadKeyIconPath0 = 86,
		Beyond-Input-InputManager-GetKeyIconPath2 = 86,
		Beyond-Input-InputManager-GetKeyboardIconPath0 = 86,
		Beyond-Input-InputManager-GetKeyIconPath0 = 87,
		Beyond-Input-InputManager-GetKeyIconPath1 = 87,
		Beyond-Input-InputManager-_OnNetMaskChanged0 = 88,
		Beyond-Input-InputManager-_OnFocusedInputFieldChanged0 = 88,
		Beyond-Input-KeyboardCheckerBase-get_bindingInfos0 = 89,
		Beyond-Input-InputManager-_AnyKeyboardKey0 = 90,
		Beyond-Input-InputManager-AnyKeyboardKey0 = 91,
		Beyond-Input-InputManager-_CheckGamepadKeyCode0 = 92,
		Beyond-Input-InputManager-CreateBinding1 = 93,
		Beyond-Input-InputManager-CreateBinding2 = 94,
		Beyond-Input-InputManager-IsBindingEnabled0 = 95,
		Beyond-Input-InputManager-ChangeParent0 = 96,
		Beyond-Input-InputManager-GetGroupParentId0 = 97,
		Beyond-Input-InputManager-GetActionKeyboardKeyCode0 = 98,
		Beyond-Input-InputManager-GetActionGamepadKeyCode0 = 99,
		Beyond-Input-InputUtils-HasFlag0 = 100,
		Beyond-Input-PlayerActionInfo-DeviceInputEquals0 = 101,
		Beyond-Input-PlayerActionInfo-DeviceInputCopyFrom0 = 102,
		Beyond-Input-InputManager-DeleteCustomBinding0 = 102,
		Beyond-Input-InputManager-DeleteAllCustomBindings0 = 103,
		Beyond-Input-InputManager-GetBindingText0 = 104,
		Beyond-Input-InputManager-CheckActionKeyCodeConflict0 = 105,
		Beyond-Input-InputManager-GetAxis0 = 106,
		Beyond-Input-InputManager-GetBindingInfo0 = 107,
		Beyond-Input-InputManager-_GetOrCreatePendingActionInfo0 = 108,
		Beyond-Input-InputManager-CustomizeActionKey0 = 109,
		Beyond-Input-InputManager-CustomizeActionKey1 = 110,
		Beyond-Input-InputManager-GetMousePos0 = 111,
		Beyond-Input-InputManager-get_mousePosition0 = 111,
		Beyond-Input-InputManager-SetMousePos0 = 112,
		Beyond-Input-InputManager-SetOnlyVirtualMousePos0 = 113,
		Beyond-Input-InputManager-GetMouseButton0 = 114,
		Beyond-Input-InputManager-GetMouseButtonDown0 = 114,
		Beyond-Input-InputManager-GetMouseButtonUp0 = 114,
		Beyond-Input-InputManager-IsLeftMouseDown0 = 115,
		Beyond-Input-InputManager-GetEmptyControllerHintInfoList0 = 116,
		Beyond-Input-InputManager-_GetControllerHintInfos0 = 117,
		Beyond-Input-InputManager-GetControllerHintInfos0 = 118,
		Beyond-Input-InputManager-_GetControllerHintInfos1 = 119,
		Beyond-Input-InputManager-GetControllerHintInfos1 = 119,
		Beyond-Input-InputManager-GetPlayerActionLongPressStartTime0 = 120,
		Beyond-Input-InputManager-GetActionBindingLongPressStartTime0 = 121,
		Beyond-Input-InputManager-VibrateController0 = 122,
		Beyond-Input-InputManager-GetStringByKeyboardKeyCode0 = 123,
		Beyond-Input-InputManager-MoveVirtualMouseTo0 = 124,
		Beyond-Input-InputManager-GetPressPosByTouchId0 = 125,
		Beyond-Input-InputManager-RemoveUnusedInput0 = 126,
		Beyond-Input-InputManager-_GetInputBindingGroupGameObject0 = 127,
		Beyond-Input-InputManager-_GetInputBindingGameObject0 = 127,
		Beyond-Input-InputManager-PrintKeycodeInfo0 = 128,
		Beyond-Input-InputManager-PrintKeycodeInfo1 = 129,
		Beyond-Input-InputManager-PrintKeycodeInfo2 = 130,
		Beyond-Input-InputManager-_OnDelayedComboActionKeyUpdated0 = 131,
		Beyond-Input-InputManager-RegisterDelayedCombo0 = 132,
		Beyond-Input-InputManager-CreateGravitySensorHandle0 = 133,
		Beyond-Input-InputManager-ControllerHintInfo-CompareTo0 = 134,
		Beyond-Input-LocalGravitySensor-get_instance0 = 135,
		Beyond-Input-LocalGravitySensor-get_gravity0 = 136,
		Beyond-Input-CloudGravitySensor-get_gravity0 = 136,
		Beyond-Input-GravitySensorHandle-get_gravity0 = 136,
		Beyond-Input-CloudGravitySensor-get_instance0 = 137,
		Beyond-Input-KeyboardOnLongPressChecker-_OnTriggerBinding0 = 138,
		Beyond-Input-CursorRequest-ToString0 = 139,
		Beyond-Input-UIEvent-InitBinding0 = 140
	}

	public delegate NaviScope __HotPatchDelegate_1(object P0); // TypeDefIndex: 85223; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate NaviScope __HotPatchDelegate_2(object P0, object P1); // TypeDefIndex: 85224; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_3(object P0); // TypeDefIndex: 85225; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_4(ref bool P0, bool P1); // TypeDefIndex: 85226; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_5(object P0, bool P1); // TypeDefIndex: 85227; 0x00000001859B7730-0x00000001859B7740

	public delegate uint __HotPatchDelegate_6(); // TypeDefIndex: 85228; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_7(object P0, object P1); // TypeDefIndex: 85229; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_8(object P0, bool P1, bool P2); // TypeDefIndex: 85230; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_9(object P0, int P1, bool P2); // TypeDefIndex: 85231; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_10(object P0, NavigationBindingType P1); // TypeDefIndex: 85232; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_11(object P0, object P1, bool P2); // TypeDefIndex: 85233; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_12(object P0, int P1, object P2); // TypeDefIndex: 85234; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_13(object P0); // TypeDefIndex: 85235; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_14(object P0, int P1); // TypeDefIndex: 85236; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector3 __HotPatchDelegate_15(object P0, NaviDirection P1); // TypeDefIndex: 85237; 0x0000000186AEB300-0x0000000186AEB340

	public delegate Vector3 __HotPatchDelegate_16(object P0, Vector2 P1); // TypeDefIndex: 85238; 0x0000000186AEB300-0x0000000186AEB340

	public delegate Selectable __HotPatchDelegate_17(object P0, object P1, Vector3 P2, Vector3 P3, NaviStrategy P4, double P5, out double P6); // TypeDefIndex: 85239; 0x00000001849B3990-0x00000001849B3A10

	public delegate Selectable __HotPatchDelegate_18(object P0, object P1, Vector3 P2, Vector3 P3, double P4, out double P5); // TypeDefIndex: 85240; 0x00000001849B3A10-0x00000001849B4DE0

	public delegate bool __HotPatchDelegate_19(object P0, NaviDirection P1); // TypeDefIndex: 85241; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_20(object P0, NaviDirection P1, bool P2, bool P3); // TypeDefIndex: 85242; 0x0000000181217F60-0x0000000181217F80

	public delegate int __HotPatchDelegate_21(); // TypeDefIndex: 85243; 0x0000000185B44B70-0x0000000185B44B80

	public delegate PlayerActionInfo __HotPatchDelegate_22(object P0, object P1, InputSettingLevel P2); // TypeDefIndex: 85244; 0x00000001811DF7F0-0x00000001811DF810

	public delegate KeyboardCheckerBase.Binding __HotPatchDelegate_23(object P0, object P1, object P2, bool P3); // TypeDefIndex: 85245; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_24(object P0, object P1, object P2); // TypeDefIndex: 85246; 0x00000001811DF7F0-0x00000001811DF810

	public delegate DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __HotPatchDelegate_25(object P0, object P1); // TypeDefIndex: 85247; 0x00000001859B7730-0x00000001859B7740

	public delegate GamepadCheckerBase.Binding __HotPatchDelegate_26(object P0, object P1, object P2, bool P3); // TypeDefIndex: 85248; 0x0000000181217F60-0x0000000181217F80

	public delegate int __HotPatchDelegate_27(object P0, object P1, object P2, object P3, int P4); // TypeDefIndex: 85249; 0x00000001812083C0-0x00000001812083E0

	public delegate int __HotPatchDelegate_28(object P0, object P1, object P2, int P3); // TypeDefIndex: 85250; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_29(object P0, object P1, NaviDirection P2, int P3); // TypeDefIndex: 85251; 0x00000001811CDB70-0x00000001811CDB90

	public delegate SelectableNaviGroup __HotPatchDelegate_30(object P0); // TypeDefIndex: 85252; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_31(object P0, int P1, object P2); // TypeDefIndex: 85253; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_32(object P0, int P1); // TypeDefIndex: 85254; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_33(object P0, object P1, object P2); // TypeDefIndex: 85255; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_34(object P0, object P1); // TypeDefIndex: 85256; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_35(object P0, object P1, NavigationBindingType P2); // TypeDefIndex: 85257; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_36(object P0, NaviDirection P1); // TypeDefIndex: 85258; 0x00000001859B7730-0x00000001859B7740

	public delegate IReadOnlyCollection<NaviScope> __HotPatchDelegate_37(object P0); // TypeDefIndex: 85259; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IReadOnlyDictionary<string, NaviScope> __HotPatchDelegate_38(object P0); // TypeDefIndex: 85260; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_39(object P0); // TypeDefIndex: 85261; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __HotPatchDelegate_40(object P0); // TypeDefIndex: 85262; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>>> __HotPatchDelegate_41(object P0); // TypeDefIndex: 85263; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IBindingView __HotPatchDelegate_42(object P0); // TypeDefIndex: 85264; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate GamepadCheckerBase.Binding __HotPatchDelegate_43(object P0, object P1, object P2); // TypeDefIndex: 85265; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_44(object P0, GamepadKeyCode P1, GamepadKeyCode P2); // TypeDefIndex: 85266; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_45(object P0, object P1, GamepadKeyCode P2); // TypeDefIndex: 85267; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_46(object P0, bool P1, bool P2); // TypeDefIndex: 85268; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_47(object P0, uint P1, InputContinuousTriggerType P2, float P3); // TypeDefIndex: 85269; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_48(object P0, uint P1, bool P2, InputContinuousTriggerType P3, float P4, bool P5); // TypeDefIndex: 85270; 0x000000018121C6C0-0x000000018121C6E0

	public delegate void __HotPatchDelegate_49(object P0, uint P1, InputContinuousTriggerType P2, bool P3); // TypeDefIndex: 85271; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_50(object P0, InputContinuousTriggerType P1); // TypeDefIndex: 85272; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_51(object P0, GamepadKeyCode P1); // TypeDefIndex: 85273; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_52(object P0, object P1); // TypeDefIndex: 85274; 0x00000001859B7730-0x00000001859B7740

	public delegate Action __HotPatchDelegate_53(object P0, object P1, GamepadKeyCode P2); // TypeDefIndex: 85275; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_54(object P0, object P1, int P2); // TypeDefIndex: 85276; 0x00000001811DF7F0-0x00000001811DF810

	public delegate RectTransform __HotPatchDelegate_55(object P0); // TypeDefIndex: 85277; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_56(object P0); // TypeDefIndex: 85278; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_57(object P0, float P1); // TypeDefIndex: 85279; 0x00000001859B7730-0x00000001859B7740

	public delegate UnityEngine.InputSystem.Mouse __HotPatchDelegate_58(object P0); // TypeDefIndex: 85280; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate InputActionProperty __HotPatchDelegate_59(object P0); // TypeDefIndex: 85281; 0x00000001811D4E00-0x00000001811D4E40

	public delegate void __HotPatchDelegate_60(ref InputActionProperty P0, InputActionProperty P1); // TypeDefIndex: 85282; 0x00000001826DF780-0x00000001826DF7C0

	public delegate void __HotPatchDelegate_61(object P0, InputActionProperty P1); // TypeDefIndex: 85283; 0x00000001826DF780-0x00000001826DF7C0

	public delegate void __HotPatchDelegate_62(InputActionProperty P0, object P1, bool P2); // TypeDefIndex: 85284; 0x0000000184175D60-0x0000000184175DA0

	public delegate void __HotPatchDelegate_63(object P0, UnityEngine.InputSystem.InputAction.CallbackContext P1); // TypeDefIndex: 85285; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate Selectable __HotPatchDelegate_64(object P0); // TypeDefIndex: 85286; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate KeyboardCheckerBase.Binding __HotPatchDelegate_65(object P0, object P1, object P2); // TypeDefIndex: 85287; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Func<bool, bool, bool> __HotPatchDelegate_66(object P0); // TypeDefIndex: 85288; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate object __HotPatchDelegate_67(object P0); // TypeDefIndex: 85289; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IBindingGroupTarget __HotPatchDelegate_68(object P0); // TypeDefIndex: 85290; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_69(); // TypeDefIndex: 85291; 0x0000000185B44B70-0x0000000185B44B80

	public delegate Vector2 __HotPatchDelegate_70(object P0, bool P1, bool P2); // TypeDefIndex: 85292; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_71(object P0, bool P1); // TypeDefIndex: 85293; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector2 __HotPatchDelegate_72(); // TypeDefIndex: 85294; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_73(bool P0); // TypeDefIndex: 85295; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_74(object P0, object P1, int P2, bool P3); // TypeDefIndex: 85296; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_75(Beyond.DeviceInfo.InputType P0); // TypeDefIndex: 85297; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_76(object P0, Beyond.DeviceInfo.InputType P1); // TypeDefIndex: 85298; 0x00000001859B7730-0x00000001859B7740

	public delegate KeyboardType __HotPatchDelegate_77(object P0); // TypeDefIndex: 85299; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_78(object P0, KeyboardType P1); // TypeDefIndex: 85300; 0x00000001859B7730-0x00000001859B7740

	public delegate Dictionary<string, HashSet<int>> __HotPatchDelegate_79(object P0); // TypeDefIndex: 85301; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_80(object P0, object P1, float P2); // TypeDefIndex: 85302; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_81(object P0, Beyond.Input.KeyboardKeyCode P1); // TypeDefIndex: 85303; 0x00000001859B7730-0x00000001859B7740

	public delegate Beyond.DeviceInfo.ControllerType __HotPatchDelegate_82(object P0, object P1, out bool P2); // TypeDefIndex: 85304; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_83(GamepadKeyCode P0); // TypeDefIndex: 85305; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_84(); // TypeDefIndex: 85306; 0x0000000185B44B70-0x0000000185B44B80

	public delegate string __HotPatchDelegate_85(object P0, object P1, bool P2, bool P3); // TypeDefIndex: 85307; 0x0000000181217F60-0x0000000181217F80

	public delegate string __HotPatchDelegate_86(object P0, bool P1, bool P2); // TypeDefIndex: 85308; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_87(object P0, bool P1, bool P2, bool P3); // TypeDefIndex: 85309; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_88(object P0, in EventData<bool> P1); // TypeDefIndex: 85310; 0x00000001859B7730-0x00000001859B7740

	public delegate List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>>> __HotPatchDelegate_89(object P0); // TypeDefIndex: 85311; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_90(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2); // TypeDefIndex: 85312; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_91(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2, out bool P3); // TypeDefIndex: 85313; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_92(object P0, GamepadKeyCode P1, Beyond.Input.InputManager.KeyCodeState P2); // TypeDefIndex: 85314; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_93(object P0, object P1, object P2, int P3, out string P4); // TypeDefIndex: 85315; 0x00000001812083C0-0x00000001812083E0

	public delegate int __HotPatchDelegate_94(object P0, Beyond.Input.KeyboardKeyCode P1, object P2, InputTimingType P3, object P4, int P5); // TypeDefIndex: 85316; 0x0000000181256340-0x0000000181256360

	public delegate bool __HotPatchDelegate_95(object P0, int P1, bool P2); // TypeDefIndex: 85317; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_96(object P0, bool P1, int P2, int P3); // TypeDefIndex: 85318; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_97(object P0, bool P1, int P2); // TypeDefIndex: 85319; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Beyond.Input.KeyboardKeyCode __HotPatchDelegate_98(object P0, object P1, bool P2, bool P3, InputSettingLevel P4); // TypeDefIndex: 85320; 0x00000001826EA060-0x00000001826EA080

	public delegate GamepadKeyCode __HotPatchDelegate_99(object P0, object P1, bool P2, bool P3, InputSettingLevel P4); // TypeDefIndex: 85321; 0x00000001826EA060-0x00000001826EA080

	public delegate bool __HotPatchDelegate_100(InputDeviceFlags P0, InputDeviceFlags P1); // TypeDefIndex: 85322; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_101(object P0, object P1, InputDeviceFlags P2); // TypeDefIndex: 85323; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_102(object P0, object P1, InputDeviceFlags P2); // TypeDefIndex: 85324; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_103(object P0, InputDeviceFlags P1); // TypeDefIndex: 85325; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_104(object P0, int P1); // TypeDefIndex: 85326; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_105(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, out bool P3); // TypeDefIndex: 85327; 0x00000001811CDB70-0x00000001811CDB90

	public delegate float __HotPatchDelegate_106(object P0, object P1); // TypeDefIndex: 85328; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_107(object P0, int P1, out string P2, out IBindingView P3); // TypeDefIndex: 85329; 0x00000001811CDB70-0x00000001811CDB90

	public delegate PlayerActionInfo __HotPatchDelegate_108(object P0, object P1); // TypeDefIndex: 85330; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_109(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, bool P3, object P4); // TypeDefIndex: 85331; 0x00000001826EA060-0x00000001826EA080

	public delegate bool __HotPatchDelegate_110(object P0, object P1, GamepadKeyCode? P2, GamepadKeyCode? P3, bool P4, object P5); // TypeDefIndex: 85332; 0x000000018129A720-0x000000018129A740

	public delegate Vector3 __HotPatchDelegate_111(); // TypeDefIndex: 85333; 0x000000018691BF80-0x000000018691BFC0

	public delegate void __HotPatchDelegate_112(Vector2 P0, bool P1); // TypeDefIndex: 85334; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_113(object P0, Vector2 P1); // TypeDefIndex: 85335; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_114(int P0); // TypeDefIndex: 85336; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_115(bool P0); // TypeDefIndex: 85337; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate List<Beyond.Input.InputManager.ControllerHintInfo> __HotPatchDelegate_116(object P0); // TypeDefIndex: 85338; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_117(object P0, object P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3); // TypeDefIndex: 85339; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_118(object P0, int P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3); // TypeDefIndex: 85340; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_119(object P0, object P1, ref List<Beyond.Input.InputManager.ControllerHintInfo> P2); // TypeDefIndex: 85341; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_120(object P0, object P1, out float P2); // TypeDefIndex: 85342; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_121(object P0, int P1, out float P2); // TypeDefIndex: 85343; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_122(object P0, float P1, float P2); // TypeDefIndex: 85344; 0x000000018238E680-0x000000018238E6A0

	public delegate string __HotPatchDelegate_123(Beyond.Input.KeyboardKeyCode P0); // TypeDefIndex: 85345; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_124(object P0, object P1, object P2, bool P3); // TypeDefIndex: 85346; 0x0000000181217F60-0x0000000181217F80

	public delegate bool __HotPatchDelegate_125(int P0, out Vector2 P1); // TypeDefIndex: 85347; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_126(); // TypeDefIndex: 85348; 0x0000000185B44B70-0x0000000185B44B80

	public delegate GameObject __HotPatchDelegate_127(object P0, object P1); // TypeDefIndex: 85349; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_128(object P0, Beyond.Input.KeyboardKeyCode P1, bool P2); // TypeDefIndex: 85350; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_129(object P0, GamepadKeyCode P1, bool P2); // TypeDefIndex: 85351; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_130(object P0, object P1, bool P2, bool P3, bool P4); // TypeDefIndex: 85352; 0x00000001826DF690-0x00000001826DF6C0

	public delegate void __HotPatchDelegate_131(object P0, in EventData<string> P1); // TypeDefIndex: 85353; 0x00000001859B7730-0x00000001859B7740

	public delegate Beyond.Input.InputManager.DelayedComboBinding __HotPatchDelegate_132(object P0, object P1, object P2, Beyond.Input.InputManager.DelayedComboKind P3, float P4, object P5); // TypeDefIndex: 85354; 0x0000000181256340-0x0000000181256360

	public delegate GravitySensorHandle __HotPatchDelegate_133(); // TypeDefIndex: 85355; 0x0000000185B44B70-0x0000000185B44B80

	public delegate int __HotPatchDelegate_134(object P0, object P1); // TypeDefIndex: 85356; 0x00000001859B7730-0x00000001859B7740

	public delegate LocalGravitySensor __HotPatchDelegate_135(); // TypeDefIndex: 85357; 0x0000000185B44B70-0x0000000185B44B80

	public delegate Vector3 __HotPatchDelegate_136(object P0); // TypeDefIndex: 85358; 0x0000000185D32980-0x0000000185D329C0

	public delegate CloudGravitySensor __HotPatchDelegate_137(); // TypeDefIndex: 85359; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_138(object P0, object P1, Beyond.Input.KeyboardKeyCode P2); // TypeDefIndex: 85360; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_139(ref CursorRequest P0); // TypeDefIndex: 85361; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_140(object P0, object P1, object P2, object P3); // TypeDefIndex: 85362; 0x00000001811CDB70-0x00000001811CDB90
}

namespace UnityEngine.InputSystem.UI
{
	[AddComponentMenu("Input/Debug Virtual Mouse")]
	public class DebugVirtualMouseInput : MonoBehaviour // TypeDefIndex: 85133
	{
		// Fields
		[Header("Cursor")]
		[SerializeField]
		[Tooltip("Whether the component should set the cursor position of the hardware mouse cursor, if one is available. If so, the software cursor pointed (to by \'Cursor Graphic\') will be hidden.")]
		private CursorMode m_CursorMode; // 0x18
		[SerializeField]
		[Tooltip("The graphic that represents the software cursor. This is hidden if a hardware cursor (see \'Cursor Mode\') is used.")]
		private Graphic m_CursorGraphic; // 0x20
		[SerializeField]
		[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see \'Cursor Mode\'). Moving the cursor updates the anchored position of the transform.")]
		private RectTransform m_CursorTransform; // 0x28
		[SerializeField]
		private RectTransform _canvasTransform; // 0x30
		[SerializeField]
		private Canvas m_Canvas; // 0x38
		[Header("Motion")]
		[SerializeField]
		[Tooltip("Speed in pixels per second with which to move the cursor. Scaled by the input from \'Stick Action\'.")]
		private float m_CursorSpeed; // 0x40
		[SerializeField]
		[Tooltip("Scale factor to apply to \'Scroll Wheel Action\' when setting the mouse \'scrollWheel\' control.")]
		private float m_ScrollSpeed; // 0x44
		[SerializeField]
		[Space(10f)]
		[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
		private InputActionProperty m_StickAction; // 0x48
		[SerializeField]
		[Tooltip("Button action that triggers a left-click on the mouse.")]
		private InputActionProperty m_LeftButtonAction; // 0x60
		[SerializeField]
		[Tooltip("Button action that triggers a middle-click on the mouse.")]
		private InputActionProperty m_MiddleButtonAction; // 0x78
		[SerializeField]
		[Tooltip("Button action that triggers a right-click on the mouse.")]
		private InputActionProperty m_RightButtonAction; // 0x90
		[SerializeField]
		[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
		private InputActionProperty m_ForwardButtonAction; // 0xA8
		[SerializeField]
		[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
		private InputActionProperty m_BackButtonAction; // 0xC0
		[SerializeField]
		[Tooltip("Vector2 action that feeds into the mouse \'scrollWheel\' action (scaled by \'Scroll Speed\').")]
		private InputActionProperty m_ScrollWheelAction; // 0xD8
		private UnityEngine.InputSystem.Mouse m_VirtualMouse; // 0xF0
		private UnityEngine.InputSystem.Mouse m_SystemMouse; // 0xF8
		private Action m_AfterInputUpdateDelegate; // 0x100
		private Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate; // 0x108
		private double m_LastTime; // 0x110
		private Vector2 m_LastStickValue; // 0x118
		private float m_canvasScale; // 0x120
	
		// Properties
		public RectTransform cursorTransform { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public float cursorSpeed { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public CursorMode cursorMode { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018C26848C-0x000000018C268574
		public Graphic cursorGraphic { get; set; } // 0x000000018225E800-0x000000018225E810 0x000000018C268468-0x000000018C26848C
		public float scrollSpeed { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public UnityEngine.InputSystem.Mouse virtualMouse { get; } // 0x000000018723C070-0x000000018723C080 
		public InputActionProperty stickAction { get; set; } // 0x000000018723CE90-0x000000018723CEB0 0x000000018C26886C-0x000000018C26889C
		public InputActionProperty leftButtonAction { get; set; } // 0x0000000187240780-0x00000001872407A0 0x000000018C26862C-0x000000018C2686D4
		public InputActionProperty rightButtonAction { get; set; } // 0x000000018724BCA0-0x000000018724BCC0 0x000000018C268784-0x000000018C26883C
		public InputActionProperty middleButtonAction { get; set; } // 0x0000000187250B40-0x0000000187250B60 0x000000018C2686D4-0x000000018C268784
		public InputActionProperty forwardButtonAction { get; set; } // 0x0000000187250B20-0x0000000187250B40 0x000000018C268574-0x000000018C26862C
		public InputActionProperty backButtonAction { get; set; } // 0x0000000187250B00-0x0000000187250B20 0x000000018C2683B0-0x000000018C268468
		public InputActionProperty scrollWheelAction { get; set; } // 0x0000000187250B60-0x0000000187250B80 0x000000018C26883C-0x000000018C26886C
	
		// Nested types
		public enum CursorMode // TypeDefIndex: 85132
		{
			SoftwareCursor = 0,
			HardwareCursorIfAvailable = 1
		}
	
		// Constructors
		public DebugVirtualMouseInput(); // 0x000000018721E740-0x000000018721E770
	
		// Methods
		protected void OnEnable(); // 0x000000018C2673D4-0x000000018C2677FC
		protected void OnDisable(); // 0x000000018C267134-0x000000018C2673D4
		private void _TryFindCanvas(); // 0x000000018C267E94-0x000000018C267EF0
		private void _TryEnableHardwareCursor(); // 0x000000018C267C9C-0x000000018C267E94
		private void _SyncScale(); // 0x000000018C267B9C-0x000000018C267C9C
		private void _UpdateMotion(); // 0x000000018C267EF0-0x000000018C2683B0
		private void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context); // 0x000000018C267804-0x000000018C267A38
		private static void _SetActionCallback(InputActionProperty field, Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x02644914 */); // 0x000000018C267A38-0x000000018C267AA4
		private static void _SetAction(ref InputActionProperty field, InputActionProperty value); // 0x000000018C267AA4-0x000000018C267B9C
		private void _OnAfterInputUpdate(); // 0x000000018C2677FC-0x000000018C267804
	}
}
