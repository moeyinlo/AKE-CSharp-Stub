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

// Image 40: Input.Beyond.dll - Assembly: Input.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55623-55694
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Input
{
	public class ControllerNaviManager // TypeDefIndex: 55632
	{
		// Fields
		public LinkedList<SelectableNaviGroup> layerStackList; // 0x10
		public Selectable curTarget; // 0x18
		private readonly HashSet<string> m_naviLockSet; // 0x20
		private int m_targetInputBindingGroupId; // 0x28
		private int m_naviInputBindingGroupId; // 0x2C
		private Selectable m_lastEnableNaviTarget; // 0x30
		private Dictionary<NavigationBindingType, int> m_naviBindingGroupIds; // 0x40
		private Beyond.Input.InputManager m_inputManager; // 0x48
		private const float SCORE_OFFSET = 10000f; // Metadata: 0x01FD6FAE
	
		// Properties
		public NavigationBindingType navigationBindingType { get; private set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public bool forceEnableNaviForGuide { get; private set; } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
	
		// Constructors
		public ControllerNaviManager() {} // Dummy constructor
		public ControllerNaviManager(Beyond.Input.InputManager inputManager) {} // 0x00000001835A95B0-0x00000001835AA6D0
	
		// Methods
		public void SetNaviBindingType(NavigationBindingType bindingType) {} // 0x00000001835AA6D0-0x00000001835AA8A0
		public void Tick() {} // 0x00000001828532B0-0x0000000182853330
		private bool _RemoveLayer(SelectableNaviGroup group, SelectableNaviGroup curLayer) => default; // 0x0000000182C6FC90-0x0000000182C6FF20
		private void _RemoveLayerFromStack(SelectableNaviGroup group, bool silentMode) {} // 0x0000000182C701C0-0x0000000182C70250
		private void _SetTarget(Selectable target) {} // 0x0000000183A507E0-0x0000000183A508A0
		private void _OnLayerSelected(SelectableNaviGroup topLayer) {} // 0x00000001888A99BC-0x00000001888A9BE8
		private bool _DefaultNavigate(NaviDirection dir) => default; // 0x00000001888A8DA4-0x00000001888A97B4
		private Selectable _TryFindBestNaviTargetInGroup(SelectableNaviGroup group, Vector3 pos, Vector3 dir, double curMaxScore, out double maxScore) {
			maxScore = default;
			return default;
		} // 0x00000001888A9BE8-0x00000001888A9F8C
		private Selectable _TryFindBestNaviTarget(HashSet<Selectable> targets, Vector3 curPos, Vector3 dir, NaviStrategy strategy, double curMaxScore, out double maxScore) {
			maxScore = default;
			return default;
		} // 0x00000001888A9F8C-0x00000001888AA6E4
		private static Vector3 _GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir) => default; // 0x00000001888A97B4-0x00000001888A99BC
		public void SetForceEnableNavi(bool enable) {} // 0x00000001888A89C8-0x00000001888A8A4C
		public void UpdateNaviInputBindingState() {} // 0x00000001824B1C30-0x00000001824B1EA0
		public bool IsNavigationBindingEnabled() => default; // 0x00000001824B1EA0-0x00000001824B1F30
		public void TryRemoveLayer(SelectableNaviGroup group) {} // 0x000000018304D9A0-0x000000018304DAC0
		public bool IsLayerInStack(SelectableNaviGroup group) => default; // 0x0000000182C70150-0x0000000182C701C0
		public bool IsTopLayer(SelectableNaviGroup group) => default; // 0x00000001888A8744-0x00000001888A8840
		public void ChangeAndTrySetNaviBindingType(SelectableNaviGroup naviGroup, NavigationBindingType naviBindingType) {} // 0x00000001836F07B0-0x00000001836F0810
		public void TryAutoSetTarget() {} // 0x00000001888A8C74-0x00000001888A8D64
		public void SetTarget(Selectable target) {} // 0x0000000183A50790-0x0000000183A507E0
		public void SetTargetInSilentModeIfNecessary(SelectableNaviGroup naviGroup, Selectable selectable) {} // 0x00000001888A8A4C-0x00000001888A8B7C
		public bool IsNaviTarget(Selectable target) => default; // 0x00000001888A86B8-0x00000001888A8744
		public Vector3 GetNaviVector(NaviDirection dir) => default; // 0x00000001888A8564-0x00000001888A86B8
		public void Navigate(NaviDirection dir) {} // 0x00000001888A8840-0x00000001888A89C8
		public void ToggleNavigation(string key, bool active) {} // 0x00000001888A8B7C-0x00000001888A8C74
	}

	public enum ActionOnSetNaviTarget // TypeDefIndex: 55633
	{
		None = 0,
		AutoTriggerOnClick = 1,
		PressConfirmTriggerOnClick = 2
	}

	public static class ControllerNaviUtils // TypeDefIndex: 55634
	{
	}

	public class PSTriggerEffectCfg : MonoBehaviour // TypeDefIndex: 55635
	{
		// Fields
		[SerializeField]
		public List<TriggerEffectCommandUnion> commands; // 0x18
	
		// Constructors
		public PSTriggerEffectCfg() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public enum KeyboardKeyCode // TypeDefIndex: 55636
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

	public enum GamepadKeyCode // TypeDefIndex: 55637
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

	public enum InputTimingType // TypeDefIndex: 55638
	{
		OnPress = 0,
		OnRelease = 1,
		OnClick = 2,
		OnLongPress = 3
	}

	public enum InputContinuousTriggerType // TypeDefIndex: 55639
	{
		NormalDelayAndLoopTime = 0,
		EveryTick = 1
	}

	internal abstract class GamepadCheckerBase // TypeDefIndex: 55642
	{
		// Fields
		protected Beyond.Input.InputManager m_inputManager; // 0x10
		protected DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> m_normalBindingInfos; // 0x18
		protected DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>>> m_modifyBindingInfos; // 0x20
		protected HashSet<GamepadKeyCode> m_usedKeyCache; // 0x28
		protected List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x30
	
		// Properties
		internal DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> normalBindingInfos { get; } // 0x00000001888AC1C8-0x00000001888AC214 
		internal DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>>> modifyBindingInfos { get; } // 0x00000001888AC17C-0x00000001888AC1C8 
	
		// Nested types
		public class Binding // TypeDefIndex: 55640
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
	
			// Constructors
			public Binding() {} // Dummy constructor
			public Binding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x01FD70DE */) {} // 0x0000000182856C30-0x0000000182856D10
		}
	
		public enum TriggerType // TypeDefIndex: 55641
		{
			NORMAL = 0,
			CONTINUOUS = 1,
			STOP_CONTINUOUS = 2
		}
	
		// Constructors
		protected GamepadCheckerBase() {} // Dummy constructor
		internal GamepadCheckerBase(Beyond.Input.InputManager inputManager) {} // 0x00000001837CAAD0-0x00000001837CAC80
	
		// Methods
		public virtual Binding OnCreateBinding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x01FD70DD */) => default; // 0x0000000182856930-0x0000000182856B10
		public virtual Binding OnDeleteBinding(GamepadInput input, InputBindingInfo info) => default; // 0x0000000182859010-0x00000001828592F0
		protected DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> GetInputDic(GamepadInput input) => default; // 0x0000000182856B10-0x0000000182856C30
		public virtual void CheckGamepadInput() {} // 0x00000001888ABDD8-0x00000001888ABF1C
		protected virtual void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x00000001888ABD74-0x00000001888ABDD8
		public virtual void TriggerActions() {} // 0x00000001888ABF1C-0x00000001888AC17C
	}

	internal class GamepadChecker : GamepadCheckerBase // TypeDefIndex: 55643
	{
		// Fields
		private Func<GamepadKeyCode, bool> m_checkFunc; // 0x38
	
		// Properties
		public bool isPressChecker { get; private set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
	
		// Constructors
		public GamepadChecker() {} // Dummy constructor
		public GamepadChecker(Func<GamepadKeyCode, bool> checkFunc, bool isPress, Beyond.Input.InputManager inputManager) {} // 0x00000001837CAA80-0x00000001837CAAD0
	
		// Methods
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x00000001888AC214-0x00000001888AC880
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1) {} // 0x00000001888AC880-0x00000001888AC888
	}

	internal class GamepadOnClickChecker : GamepadCheckerBase // TypeDefIndex: 55644
	{
		// Constructors
		public GamepadOnClickChecker() {} // Dummy constructor
		internal GamepadOnClickChecker(Beyond.Input.InputManager inputManager) {} // 0x00000001888AD414-0x00000001888AD41C
	
		// Methods
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x00000001888AC888-0x00000001888ACFEC
		public void ClearKeyPressed(GamepadKeyCode keyCode) {} // 0x00000001888ACFEC-0x00000001888AD414
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1) {} // 0x00000001888AC880-0x00000001888AC888
	}

	internal class GamepadOnLongPressChecker : GamepadCheckerBase // TypeDefIndex: 55646
	{
		// Fields
		private Action<GamepadKeyCode> m_onTriggerOnLongPress; // 0x38
		private Dictionary<GamepadInput, HashSet<Binding>> m_bindings; // 0x40
	
		// Constructors
		public GamepadOnLongPressChecker() {} // Dummy constructor
		public GamepadOnLongPressChecker(Action<GamepadKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager) {} // 0x00000001837CA920-0x00000001837CA9D0
	
		// Methods
		public Action CreateTriggerBindingAction(Binding binding, GamepadKeyCode keyCode) => default; // 0x00000001888ADB44-0x00000001888ADC44
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x00000001888AD41C-0x00000001888ADB44
		private void _OnTriggerBinding(Binding binding, GamepadKeyCode keyCode) {} // 0x00000001888ADE68-0x00000001888AE12C
		public override Binding OnCreateBinding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x01FD70E2 */) => default; // 0x00000001836F95D0-0x00000001836F9730
		public override Binding OnDeleteBinding(GamepadInput input, InputBindingInfo info) => default; // 0x00000001836F94F0-0x00000001836F95D0
		public float GetInputLongPressStartTime(GamepadInput input, int bindingId = 0 /* Metadata: 0x01FD70E3 */) => default; // 0x00000001888ADC44-0x00000001888ADE50
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1) {} // 0x00000001888AC880-0x00000001888AC888
		public Binding __iFixBaseProxy_OnCreateBinding(GamepadInput P0, InputBindingInfo P1, bool P2) => default; // 0x00000001888ADE50-0x00000001888ADE60
		public Binding __iFixBaseProxy_OnDeleteBinding(GamepadInput P0, InputBindingInfo P1) => default; // 0x00000001888ADE60-0x00000001888ADE68
	}

	internal class GamepadOnReleaseChecker : GamepadCheckerBase // TypeDefIndex: 55647
	{
		// Fields
		private readonly Func<GamepadKeyCode, bool> m_checkFunc; // 0x38
		private readonly Dictionary<GamepadKeyCode, HashSet<GamepadKeyCode>> m_modifyBindingPressedDic; // 0x40
	
		// Constructors
		public GamepadOnReleaseChecker() {} // Dummy constructor
		public GamepadOnReleaseChecker(Func<GamepadKeyCode, bool> checkFunc, Beyond.Input.InputManager inputManager) {} // 0x00000001837CA9D0-0x00000001837CAA80
	
		// Methods
		public override void CheckGamepadInput() {} // 0x00000001888AE7B8-0x00000001888AEE9C
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x00000001888AE12C-0x00000001888AE7B8
		public void __iFixBaseProxy_CheckGamepadInput() {} // 0x00000001888AEEC4-0x00000001888AEECC
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1) {} // 0x00000001888AC880-0x00000001888AC888
	}

	[AddComponentMenu("Input/HG Virtual Mouse")]
	public class HGVirtualMouse : MonoBehaviour // TypeDefIndex: 55650
	{
		// Fields
		private const float STANDARD_SCREEN_WIDTH = 1920f; // Metadata: 0x01FD70E5
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
		private bool m_usingHoverSpd; // 0x151
		private int m_encounterHoverCount; // 0x154
		private float m_animatorHoverValue; // 0x158
		private bool m_isIdle; // 0x15C
		[SerializeField]
		private float _hoverAnimationChangeSpeed; // 0x160
		private CanvasGroup m_iconCanvasGroup; // 0x168
	
		// Properties
		public RectTransform cursorTransform { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public float scrollSpeed { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public UnityEngine.InputSystem.Mouse virtualMouse { get => default; } // 0x0000000183D56D30-0x0000000183D56D40 
		public InputActionProperty stickAction { get => default; set {} } // 0x0000000183D6DC30-0x0000000183D6DC50 0x00000001888B15C8-0x00000001888B15F8
		public InputActionProperty leftButtonAction { get => default; set {} } // 0x0000000183D6DBC0-0x0000000183D6DBE0 0x00000001888B1288-0x00000001888B1388
		public InputActionProperty rightButtonAction { get => default; set {} } // 0x0000000183D6DC10-0x0000000183D6DC30 0x00000001888B1490-0x00000001888B1598
		public InputActionProperty middleButtonAction { get => default; set {} } // 0x0000000183D6DBE0-0x0000000183D6DC00 0x00000001888B1388-0x00000001888B1490
		public InputActionProperty forwardButtonAction { get => default; set {} } // 0x0000000183D6DAF0-0x0000000183D6DB10 0x00000001888B1180-0x00000001888B1288
		public InputActionProperty backButtonAction { get => default; set {} } // 0x0000000183D697B0-0x0000000183D697D0 0x00000001888B1078-0x00000001888B1180
		public InputActionProperty scrollWheelAction { get => default; set {} } // 0x0000000183D6B920-0x0000000183D6B940 0x00000001888B1598-0x00000001888B15C8
		public bool isHoverOn { get; private set; } // 0x0000000183D56A80-0x0000000183D56A90 0x0000000183D6CF10-0x0000000183D6CF20
		public bool mouseIconVisible { get; private set; } // 0x0000000183D6DC00-0x0000000183D6DC10 0x0000000183D6DC50-0x0000000183D6DC60
	
		// Nested types
		[Serializable]
		public class CursorSpeedPhase // TypeDefIndex: 55648
		{
			// Fields
			public float maxJsValue; // 0x10
			public float minSpeed; // 0x14
			public float maxSpeed; // 0x18
			public float acceleration; // 0x1C
			public float accelerationSpeed; // 0x20
			public float maxAcceleration; // 0x24
	
			// Constructors
			public CursorSpeedPhase() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public HGVirtualMouse() {} // 0x000000018398A6C0-0x000000018398A850
	
		// Methods
		protected void OnEnable() {} // 0x00000001888AF91C-0x00000001888B00A0
		protected void OnDisable() {} // 0x00000001888AF590-0x00000001888AF91C
		private void _UpdateMotion() {} // 0x00000001888B097C-0x00000001888B1078
		private void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) {} // 0x00000001888B040C-0x00000001888B062C
		public void TriggerLeftButton(bool isPressed) {} // 0x00000001888B011C-0x00000001888B024C
		public void ClearLeftButtonState() {} // 0x00000001888AF198-0x00000001888AF288
		private static void _SetActionCallback(InputActionProperty field, Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x01FD70E4 */) {} // 0x00000001888B062C-0x00000001888B06F0
		private static void _SetAction(ref InputActionProperty field, InputActionProperty value) {} // 0x00000001888B06F0-0x00000001888B0844
		public void OnAfterInputUpdate() {} // 0x00000001888AF418-0x00000001888AF468
		private void Update() {} // 0x00000001888B0264-0x00000001888B0394
		public void ChangeHoverState(Selectable target, bool isHoverOn) {} // 0x00000001888AEF58-0x00000001888AF198
		private void _ChangeHoverState(bool isHoverOn) {} // 0x00000001888B0394-0x00000001888B040C
		public Selectable GetCurHoverSelectable() => default; // 0x00000001888AF288-0x00000001888AF418
		private void OnDestroy() {} // 0x00000001888AF468-0x00000001888AF590
		private void _SyncScale() {} // 0x00000001888B0844-0x00000001888B097C
		private void Awake() {} // 0x00000001888AEECC-0x00000001888AEF58
		public void SetMouseIconVisible(bool active) {} // 0x00000001888B00A0-0x00000001888B011C
	}

	[Serializable]
	public class InputBindingInfo // TypeDefIndex: 55651
	{
		// Fields
		private static uint s_nextEnabledPriority; // 0x00
		private Action m_callback; // 0x18
		public string playerActionId; // 0x28
		public bool forceKeyhintToGrayState; // 0x3C
		private IBindingView m_bindingView; // 0x48
		private string m_text; // 0x50
		public static float s_continuousTriggerFirstDelayTime; // 0x04
		public static float s_continuousTriggerLoopDelayTime; // 0x08
		public static float s_continuousTriggerLoopQuickDelayTime; // 0x0C
		private int m_continuousTriggerTimerId; // 0x58
	
		// Properties
		public int id { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public InputBindingGroup group { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool shouldShowControllerHint { get; private set; } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
		public int controllerHintPriority { get; private set; } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		public bool isCommonOpenUIAction { get; private set; } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		public bool selfEnabled { get; private set; } // 0x0000000183D4F300-0x0000000183D4F310 0x0000000183D4F330-0x0000000183D4F340
		public bool groupEnabled { get; private set; } // 0x0000000183D4F500-0x0000000183D4F510 0x0000000183D4F530-0x0000000183D4F540
		public bool enabled { get => default; } // 0x00000001824AEA80-0x00000001824AEDE0 
		public bool parentIgnored { get; private set; } // 0x0000000183D4F510-0x0000000183D4F520 0x0000000183D4F540-0x0000000183D4F550
		public uint enabledPriority { get; private set; } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
		public int actionPriority { get; private set; } // 0x0000000183D4EE80-0x0000000183D4EE90 0x0000000183D4EEA0-0x0000000183D4EEB0
		public IBindingView bindingView { get => default; set {} } // 0x0000000182BDFF00-0x0000000182BDFF80 0x0000000182692290-0x00000001826922A0
		public string text { get => default; set {} } // 0x0000000182BDFE40-0x0000000182BDFF00 0x0000000182C926C0-0x0000000182C926D0
	
		// Constructors
		public InputBindingInfo() {} // Dummy constructor
		public InputBindingInfo(int id, InputBindingGroup group, Action callback, string playerActionId, PlayerActionInfo actionInfo) {} // 0x00000001828570F0-0x00000001828571E0
		static InputBindingInfo() {} // 0x0000000183D045C0-0x0000000183D04640
	
		// Methods
		private static uint _GetNextEnabledPriority() => default; // 0x00000001828571E0-0x0000000182857250
		public void ChangeGroup(InputBindingGroup newGroup) {} // 0x00000001888B1664-0x00000001888B16E4
		public void SetSelfEnabled(bool value) {} // 0x0000000182C6EFB0-0x0000000182C6F040
		public void OnGroupEnabledChanged(bool value) {} // 0x0000000182858A20-0x0000000182858AC0
		public void SetParentIgnored(bool value) {} // 0x00000001888B173C-0x00000001888B1798
		public void Trigger() {} // 0x000000018362B660-0x000000018362B6A0
		public void StartContinuousTrigger(InputContinuousTriggerType continuousTriggerType) {} // 0x00000001888B1798-0x00000001888B1944
		private void _TryContinuousTrigger() {} // 0x00000001888B1C24-0x00000001888B1C8C
		public void StopContinuousTrigger() {} // 0x0000000182858AC0-0x0000000182858B40
		private void _RealTriggerCallback() {} // 0x000000018362B6A0-0x000000018362B760
		public void OnDelete() {} // 0x0000000182859430-0x0000000182859480
		public object GetCallbackTarget() => default; // 0x00000001888B16E4-0x00000001888B173C
	}

	[Serializable]
	public class InputBindingGroup // TypeDefIndex: 55652
	{
		// Fields
		private IBindingView m_groupView; // 0x30
	
		// Properties
		public int id { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public bool selfEnabled { get; private set; } // 0x0000000183D58C00-0x0000000183D58C10 0x0000000183D58C20-0x0000000183D58C30
		public bool parentEnabled { get; private set; } // 0x0000000183D58C10-0x0000000183D58C20 0x0000000183D58C30-0x0000000183D58C40
		public bool enabled { get => default; } // 0x00000001824B2740-0x00000001824B27D0 
		public bool parentIgnored { get; private set; } // 0x0000000183D6DC60-0x0000000183D6DC70 0x0000000183D6DC70-0x0000000183D6DC80
		public InputBindingGroup parent { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public LinkedList<InputBindingGroup> subGroups { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public LinkedList<InputBindingInfo> subInfos { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public IBindingView groupView { get => default; set {} } // 0x0000000182BDFF80-0x0000000182BDFFF0 0x0000000184270470-0x0000000184270480
	
		// Constructors
		public InputBindingGroup() {} // Dummy constructor
		public InputBindingGroup(int id, InputBindingGroup parent) {} // 0x00000001822B0460-0x00000001822B0540
	
		// Methods
		public void ChangeParent(InputBindingGroup newParent) {} // 0x0000000183610B10-0x0000000183610B70
		public void SetSelfEnabled(bool value) {} // 0x0000000182858400-0x0000000182858490
		public void SetParentIgnored(bool value) {} // 0x00000001888B15F8-0x00000001888B1664
		public void OnParentEnabledChanged(bool value) {} // 0x0000000182858980-0x0000000182858A20
		private void _OnBindingGroupStateChanged() {} // 0x0000000182858490-0x0000000182858980
	}

	public class InputBindingGroupMonoTarget : MonoBehaviour, IBindingGroupTarget // TypeDefIndex: 55653
	{
		// Fields
		private int m_groupId; // 0x18
		private bool m_init; // 0x1C
		private bool m_internalEnabled; // 0x1D
	
		// Properties
		public int groupId { get => default; } // 0x0000000182C70B10-0x0000000182C70B30 
		public bool groupEnabled { get => default; } // 0x00000001837260D0-0x0000000183726160 
		public InputBindingGroupMonoTarget parent { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public IBindingGroupTarget parentTarget { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[Tooltip("\u65E5\u5E38\u5927\u5BB6\u7528\u7EC4\u4EF6\u672C\u8EAB\u7684enabled\u5C31\u53EF\u4EE5\u4E86\u3002\u8FD9\u4E2A\u503C\u662F\u56E0\u4E3A\u6709\u7684\u903B\u8F91\u8FD8\u8981\u5728\u7EC4\u4EF6enable\u7684\u65F6\u5019\u5C4F\u853D\u8F93\u5165\uFF0C\u6240\u4EE5\u989D\u5916\u63D0\u4F9B\u4E86\u8FD9\u4E2A\u3002\u6BD4\u5982UI\u9762\u677F\u7684\u906E\u6321\u903B\u8F91\u5C31\u4F1A\u7528\u8FD9\u4E2A\u503C\uFF0C\u539F\u672C\u7684\u7EC4\u4EF6enable\u4F1A\u7559\u7ED9\u9762\u677F\u81EA\u5DF1\u7684\u903B\u8F91\u53BB\u63A7\u5236\u3002")]
		public bool internalEnabled { get => default; set {} } // 0x0000000183D50D90-0x0000000183D50DA0 0x0000000182C70F60-0x0000000182C70F70
	
		// Constructors
		public InputBindingGroupMonoTarget() {} // 0x0000000183628080-0x00000001836280A0
	
		// Methods
		public void Init() {} // 0x0000000182C70B30-0x0000000182C70DB0
		public void UpdateState() {} // 0x0000000182C70F70-0x0000000182C71020
		public void DeleteGroup() {} // 0x0000000182C70940-0x0000000182C709C0
		private void Awake() {} // 0x0000000182C70AD0-0x0000000182C70B10
		private void OnEnable() {} // 0x0000000182C70DF0-0x0000000182C70E30
		private void OnDisable() {} // 0x0000000182C70DB0-0x0000000182C70DF0
		private void OnDestroy() {} // 0x0000000183854A20-0x0000000183854A60
	}

	public interface IBindingGroupTarget // TypeDefIndex: 55654
	{
		// Properties
		int groupId { get; }
		IBindingGroupTarget parentTarget { get; }
		bool groupEnabled { get; }
	}

	public interface IBindingTarget // TypeDefIndex: 55655
	{
		// Properties
		int bindingId { get; }
		IBindingGroupTarget parentTarget { get; }
		bool bindingEnabled { get; }
	}

	public enum BindingViewState // TypeDefIndex: 55656
	{
		Normal = 0,
		Disabled = 1,
		Hide = 2
	}

	public enum BindingViewActionType // TypeDefIndex: 55657
	{
		Default = 0,
		ButtonClick = 1,
		ButtonLongPress = 2,
		ButtonPressStart = 3,
		ButtonPressEnd = 4,
		ButtonDoubleClick = 5,
		SliderAdd = 6,
		SliderReduce = 7,
		SliderStick = 8
	}

	public interface IBindingView // TypeDefIndex: 55658
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

	public enum InputSettingLevel // TypeDefIndex: 55659
	{
		Default = 0,
		Custom = 1,
		Pending = 2
	}

	public class InputManager : Singleton<Beyond.Input.InputManager>, IDisposable // TypeDefIndex: 55665
	{
		// Fields
		public static float s_longPressTime; // 0x00
		private static Dictionary<Beyond.Input.KeyboardKeyCode, string> s_keyboardKeyCode2StringDict; // 0x08
		private static Dictionary<GamepadKeyCode, string> s_gamepadKeyCode2StringDict; // 0x10
		public bool enableController; // 0x10
		public bool enableMarketingCamera; // 0x11
		private int m_nextInputId; // 0x14
		private int m_nextGroupId; // 0x18
		private InputBindingGroup m_rootGroup; // 0x20
		private Dictionary<int, InputBindingGroup> m_groups; // 0x28
		private Dictionary<int, InputBindingInfo> m_bindingInfos; // 0x30
		private Dictionary<string, HashSet<int>> m_action2BindingDic; // 0x38
		private KeyboardChecker m_onPressKeyboardChecker; // 0x40
		private KeyboardChecker m_onReleaseKeyboardChecker; // 0x48
		private KeyboardOnClickChecker m_onClickKeyboardChecker; // 0x50
		private KeyboardOnLongPressChecker m_onLongPressKeyboardChecker; // 0x58
		private GamepadChecker m_onPressGamepadChecker; // 0x60
		private GamepadOnReleaseChecker m_onReleaseGamepadChecker; // 0x68
		private GamepadOnClickChecker m_onClickGamepadChecker; // 0x70
		private GamepadOnLongPressChecker m_onLongPressGamepadChecker; // 0x78
		private RealCursorManager m_realCursorManager; // 0x80
		public static MultiAction<Rewired.Joystick, Beyond.DeviceInfo.ControllerType> onJoystickChanged; // 0x18
		private int m_touchPanelBtnIndex; // 0xA0
		private int m_leftMenuBtnIndex; // 0xA4
		private KeyCaches m_keyCaches; // 0xA8
		private TickFunction m_lateTickFunction; // 0xB0
		public MultiAction onInputLateTick; // 0xB8
		public Action beforeCheckInput; // 0xC0
		public Action afterCheckInput; // 0xC8
		public bool trimNonTargetInputChecks; // 0xD0
		public bool commonOpenUIActionTriggered; // 0xD1
		private static bool s_isNonSupportPsController; // 0x20
		public bool needProcessTryChange; // 0xD2
		public bool disableChangeInputDeviceCheck; // 0xD3
		private bool m_lastAnyOtherDeviceKey; // 0xD5
		private int m_controllerForbidClickBindingId; // 0xD8
		private bool m_ignoreFirstMouseUpOnFocusBack; // 0xDC
		private static readonly Beyond.Input.KeyboardKeyCode[] S_CACHED_KEYBOARD_KEY_CODES; // 0x28
		private bool m_hasFocusedInputFiled; // 0xDD
		private const float STICK_DEAD_ZONE_MAGNITUDE = 0.2f; // Metadata: 0x01FD7106
		private const float STICK_MIN_VALUE = 0.4f; // Metadata: 0x01FD710A
		private const float STICK_DEAD_ZONE_SQRT_MAGNITUDE = 0.040000003f; // Metadata: 0x01FD710E
		private IAssetLoader m_assetLoader; // 0xE0
		private SerializeFieldDictionary<string, PlayerActionInfo> m_defaultSetting; // 0xE8
		private SerializeFieldDictionary<string, PlayerActionInfo> m_customSetting; // 0xF0
		private SerializeFieldDictionary<string, PlayerActionInfo> m_pendingSetting; // 0xF8
		private InputRebindConfig m_rebindConfig; // 0x100
		private Dictionary<string, InputRebindActionScopeConfig> m_rebindActionScopeConfigs; // 0x108
		private Dictionary<string, PlayerActionInfo> m_anonymousActionInfos; // 0x110
		private int m_nextAnonymousPlayerActionId; // 0x118
		private const string INPUT_MANAGER_CANVAS_PREFAB_PATH = "Assets/Beyond/InitialAssets/Prefabs/Common/InputManagerCanvas.prefab"; // Metadata: 0x01FD7112
		private int m_virtualMouseBindingGroupId; // 0x144
		private List<ControllerHintInfo> m_tmpControllerHintInfoList; // 0x158
		private static GamepadKeyCode s_controllerIndicatorKey; // 0x30
		private static readonly GamepadKeyCode[] s_skillGamepadKeyCodes; // 0x38
		public static GamepadKeyCode s_comboSkillButtonKey; // 0x40
		private static GamepadKeyCode s_attackButtonKey; // 0x44
		private float m_skillIndicatorPressTime; // 0x160
		private int m_skillIndicatorReleaseFrame; // 0x164
		private readonly SkillButtonState[] m_lastFrameSkillButtonStates; // 0x168
		private static ProfilerMarker s_updateControllerIndicatorMarker; // 0x48
		public readonly HashSet<string> guideUseActionIds; // 0x170
		private const float DEFAULT_VIBRATE_LEVEL = 0.5f; // Metadata: 0x01FD7158
		private static Regex s_actIdRegex; // 0x50
		private const string TEXT_SPRITE_FORMAT = "<image=\"{0}\" scale={1}>"; // Metadata: 0x01FD715C
		private const float TEXT_SPRITE_SCALE = 1.6f; // Metadata: 0x01FD7174
		public const string LONG_PRESS_KEY_ICON_POSTFIX = "_press"; // Metadata: 0x01FD7178
		private const string KEY_HINT_ICON_COMMON_FOLDER = "Assets/Beyond/InitialAssets/UI/Sprites/"; // Metadata: 0x01FD717F
		private const string KEYBOARD_KEY_HINT_ICON_PATH = "KeyIcon/icon_key_"; // Metadata: 0x01FD71A7
		private const string GAMEPAD_KEY_HINT_ICON_PATH_PS5 = "KeyIcon/Playstation/icon_playstation_"; // Metadata: 0x01FD71B9
		private const string GAMEPAD_KEY_HINT_ICON_PATH_PS4 = "KeyIcon/Playstation4/icon_playstation4_"; // Metadata: 0x01FD71DF
		private const string GAMEPAD_KEY_HINT_ICON_PATH_XBOX = "KeyIcon/XBox/icon_xbox_"; // Metadata: 0x01FD7207
		private const string GAMEPAD_KEY_HINT_ICON_PATH_FALLBACK = "KeyIcon/XBox/icon_xbox_"; // Metadata: 0x01FD721F
		public static string s_virtualMouseClickHintActionId; // 0x58
		public static string s_virtualMouseLongPressHintActionId; // 0x60
		public MultiAction<Vector2> onStartSwipeTouchPanel; // 0x178
		public MultiAction<Vector2, Vector2> onSwipeTouchPanel; // 0x180
		public MultiAction onEndSwipeTouchPanel; // 0x188
		private Vector2 m_lastTouchPanelPos; // 0x194
		public ControllerNaviManager controllerNaviManager; // 0x1A0
		public bool disableCheckInputForNetMask; // 0x1A8
	
		// Properties
		public bool inHideCursorMode { get => default; } // 0x0000000183334EB0-0x0000000183334EE0 
		public bool needShowCursor { get => default; } // 0x00000001824AFD10-0x00000001824AFD40 
		public static bool cursorVisible { get => default; } // 0x00000001824ADFC0-0x00000001824AE1A0 
		public static bool anyKeyDown { get => default; } // 0x0000000182851290-0x00000001828512E0 
		public static Vector2 mouseScrollDelta { get => default; } // 0x0000000182850010-0x00000001828500A0 
		public static bool multiTouchEnabled { get => default; set {} } // 0x00000001822B4420-0x00000001822B4510 0x000000018382CBD0-0x000000018382CDE0
		public bool usingController { get => default; private set {} } // 0x00000001824AFD40-0x00000001824AFD90 0x00000001888A823C-0x00000001888A82D8
		public bool virtualMouseIconVisible { get => default; } // 0x00000001888A820C-0x00000001888A823C 
		public static int invalidID { get => default; } // 0x0000000181002730-0x0000000181002740 
		public Rewired.Joystick joystick { get; private set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		public IGamepadTemplate gamepadTemplate { get; private set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
		public IDualShock4Extension gamepadDualShock4Extension { get; private set; } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public Dictionary<string, HashSet<int>> action2BindingDic { get => default; } // 0x00000001829E2D20-0x00000001829E2DA0 
		public int rootGroupId { get => default; } // 0x00000001888A81F0-0x00000001888A820C 
		public static bool isNonSupportPsController { get => default; } // 0x00000001888A81A0-0x00000001888A81F0 
		public bool inChangingInputDevice { get; private set; } // 0x0000000183D6D690-0x0000000183D6D6A0 0x0000000183D6DB30-0x0000000183D6DB40
		public HGVirtualMouse virtualMouse { get; private set; } // 0x0000000183D56D50-0x0000000183D56D60 0x0000000184275CA4-0x0000000184275CB8
		public DebugVirtualMouseInput debugVirtualMouse { get; private set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
		public Transform canvasRoot { get; private set; } // 0x0000000183D56D00-0x0000000183D56D10 0x0000000184275CCC-0x0000000184275CE0
		public Transform controllerMask { get; private set; } // 0x0000000183D56EF0-0x0000000183D56F00 0x0000000184275CE0-0x0000000184275CF4
		public bool usingVirtualMouse { get; private set; } // 0x0000000183D576E0-0x0000000183D576F0 0x0000000183D576F0-0x0000000183D57700
		public static Vector3 mousePosition { get => default; } // 0x000000018284FE00-0x000000018284FE70 
		public Transform customControllerMouseTrans { get; private set; } // 0x0000000183D571B0-0x0000000183D571C0 0x00000001858B3DA8-0x00000001858B3DBC
		public Camera customControllerMouseUICamera { get; private set; } // 0x0000000183D57200-0x0000000183D57210 0x00000001858B3DD0-0x00000001858B3DE4
		public bool isSwipingTouchPanel { get; private set; } // 0x0000000183D57C30-0x0000000183D57C40 0x0000000183D5A070-0x0000000183D5A080
	
		// Nested types
		public class KeyCaches // TypeDefIndex: 55660
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
			public KeyCaches() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void UpdateKeyStat() {} // 0x0000000182853C40-0x0000000182853EB0
		}
	
		private enum KeyCodeState // TypeDefIndex: 55661
		{
			Pressed = 0,
			OnPress = 1,
			OnRelease = 2
		}
	
		public class ControllerHintInfo : IComparable<ControllerHintInfo>, IReusable // TypeDefIndex: 55662
		{
			// Fields
			public string actionId; // 0x10
			public int priority; // 0x18
			public InputBindingInfo bind; // 0x20
			public IBindingView hintView; // 0x28
	
			// Constructors
			public ControllerHintInfo() {} // 0x000000018350B670-0x000000018350B680
			public ControllerHintInfo(IBindingView hintView, InputBindingInfo bind) {} // 0x00000001888A8554-0x00000001888A855C
			public ControllerHintInfo(string actionId) {} // 0x00000001888A855C-0x00000001888A8564
	
			// Methods
			[IDTag(0)]
			public void Reset(IBindingView newHintView, InputBindingInfo newBind) {} // 0x00000001888A83F4-0x00000001888A84A0
			[IDTag(1)]
			public void Reset(string resetActionId) {} // 0x00000001888A84A0-0x00000001888A8554
			public int CompareTo(ControllerHintInfo other) => default; // 0x00000001888A82D8-0x00000001888A8338
			public void OnAllocate() {} // 0x00000001888A8338-0x00000001888A837C
			public void OnRecycle() {} // 0x00000001888A837C-0x00000001888A83F4
		}
	
		private enum SkillButtonState // TypeDefIndex: 55663
		{
			None = 0,
			JustPressed = 1
		}
	
		// Constructors
		private InputManager() {} // 0x00000001838278F0-0x0000000183827C10
		static InputManager() {} // 0x00000001834961D0-0x00000001834965C0
	
		// Methods
		public void LateTick(float deltaTime) {} // 0x000000018297A6F0-0x000000018297A790
		private void _Init() {} // 0x0000000182973B20-0x0000000182974430
		public void Release() {} // 0x00000001888A4F98-0x00000001888A4FE8
		private void _ClearTickFunction() {} // 0x00000001888A6690-0x00000001888A6700
		public void OnApplicationQuit() {} // 0x00000001888A4F48-0x00000001888A4F98
		private void _ClearEvents() {} // 0x00000001888A6414-0x00000001888A6690
		private void _OnAfterInputUpdate() {} // 0x00000001828530F0-0x00000001828532B0
		private void _OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x00000001888A783C-0x00000001888A7994
		private void _OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x00000001888A7994-0x00000001888A7A24
		private void _TryFindGamepad() {} // 0x0000000183A29D60-0x0000000183A29FF0
		private void _SetJoystick(Rewired.Joystick js) {} // 0x00000001888A7A24-0x00000001888A8050
		private void _CheckInput() {} // 0x0000000182852DA0-0x00000001828530B0
		private Beyond.DeviceInfo.ControllerType _GetControllerType(Rewired.Joystick js) => default; // 0x00000001888A7214-0x00000001888A74DC
		public void OnApplicationFocus(bool hasFocus) {} // 0x00000001829A6F30-0x00000001829A6FD0
		private void _InitDeviceChangeBinding() {} // 0x0000000183A90AE0-0x0000000183A90C50
		private void _RefreshDeviceChangeBinding() {} // 0x0000000182CAA210-0x0000000182CAA270
		public void CheckUsingController() {} // 0x00000001828519C0-0x0000000182851B00
		private bool _CheckAnyKeyForTouchChangeDevice() => default; // 0x00000001888A63BC-0x00000001888A6414
		private bool _CheckAnyKeyForKeyboardChangeDevice() => default; // 0x00000001888A613C-0x00000001888A63BC
		private bool _AnyKeyDownForKeyboardChangeDevice() => default; // 0x00000001888A5FB8-0x00000001888A6088
		private void _TryChangeInputDeviceType(Beyond.DeviceInfo.InputType inputType) {} // 0x00000001888A8050-0x00000001888A81A0
		private void _SyncUsingControllerState() {} // 0x0000000182CAA370-0x0000000182CAB190
		public void ToggleInputDeviceChangeMode(bool inChanging) {} // 0x00000001888A5C78-0x00000001888A5D10
		public void ToggleForceShowRealCursor(bool forceShow) {} // 0x00000001888A59D8-0x00000001888A5C10
		public void ChangeInputTypeAndSyncState(Beyond.DeviceInfo.InputType inputType) {} // 0x00000001888A2430-0x00000001888A24E8
		private void _OnFocusedInputFieldChanged([IsReadOnly] in EventData<bool> v) {} // 0x0000000183D444E0-0x0000000183D44520
		private void _CreateTickFunction() {} // 0x000000018348A070-0x000000018348A190
		[IDTag(2)]
		private void _RemovePlayerActionCheck(InputBindingInfo info) {} // 0x0000000182858D80-0x0000000182858E50
		[IDTag(2)]
		private void _AddPlayerActionCheck(InputBindingInfo info) {} // 0x00000001828565E0-0x00000001828566B0
		[IDTag(0)]
		private void _AddPlayerActionCheck(KeyboardInput input, InputBindingInfo info) {} // 0x00000001828566B0-0x00000001828567D0
		[IDTag(1)]
		private void _AddPlayerActionCheck(GamepadInput input, InputBindingInfo info) {} // 0x00000001828567D0-0x0000000182856930
		[IDTag(0)]
		private void _RemovePlayerActionCheck(KeyboardInput input, InputBindingInfo info) {} // 0x0000000182858E50-0x0000000182858F00
		[IDTag(1)]
		private void _RemovePlayerActionCheck(GamepadInput input, InputBindingInfo info) {} // 0x0000000182858F00-0x0000000182859010
		public bool GetKey(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x000000018362B4E0-0x000000018362B510
		public bool GetKeyOrDown(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x00000001888A4630-0x00000001888A4664
		public bool GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x0000000182853B30-0x0000000182853BB0
		public bool GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x0000000182853BB0-0x0000000182853C40
		public Vector2 GetGamepadStickValue(bool isLeft, bool checkDeadZone = true /* Metadata: 0x01FD70F8 */) => default; // 0x00000001888A42BC-0x00000001888A43D0
		public static bool CheckGamepadStickInDeadZone(Vector2 stickValue) => default; // 0x00000001888A2684-0x00000001888A26B0
		public static bool CheckGamepadStickInDeadZone(float stickAxisValue) => default; // 0x00000001888A266C-0x00000001888A2684
		public float GetGamepadTriggerValue(bool isLeft) => default; // 0x00000001888A43D0-0x00000001888A4514
		public bool GetKey(GamepadKeyCode keyCode) => default; // 0x00000001888A4674-0x00000001888A4680
		public bool GetKeyDown(GamepadKeyCode keyCode) => default; // 0x00000001888A4514-0x00000001888A4524
		public bool GetKeyUp(GamepadKeyCode keyCode) => default; // 0x00000001888A4664-0x00000001888A4674
		public bool AnyKeyboardKey(string[] actionScopes, out Beyond.Input.KeyboardKeyCode keyCode, out bool isBlackList) {
			keyCode = default;
			isBlackList = default;
			return default;
		} // 0x00000001888A2140-0x00000001888A2330
		private bool _AnyKeyboardKey(Beyond.Input.KeyboardKeyCode[] keyCodes, out Beyond.Input.KeyboardKeyCode keyCode) {
			keyCode = default;
			return default;
		} // 0x00000001888A6088-0x00000001888A613C
		public bool AnyGamepadKey() => default; // 0x0000000182851B00-0x0000000182851B40
		public bool AnyMouseKeyDown() => default; // 0x0000000182852330-0x0000000182852390
		public bool AnyMouseKey() => default; // 0x00000001888A23B0-0x00000001888A2430
		public bool AnyMouseKeyUp() => default; // 0x00000001888A2330-0x00000001888A23B0
		public static bool AnyKeyDown() => default; // 0x00000001828512E0-0x0000000182851400
		private bool _CheckGamepadKeyCode(GamepadKeyCode keyCode, KeyCodeState state) => default; // 0x00000001824ADEA0-0x00000001824ADF80
		[IDTag(1)]
		public int CreateBinding(PlayerActionInfo actionInfo, Action callback, int groupId, out string actionId) {
			actionId = default;
			return default;
		} // 0x00000001888A27A8-0x00000001888A2860
		[IDTag(0)]
		public int CreateBinding(string actionId, Action callback, int groupId) => default; // 0x0000000182C6D680-0x0000000182C6D7A0
		[IDTag(2)]
		public int CreateBinding(Beyond.Input.KeyboardKeyCode key, string modifyKeys, InputTimingType timing, Action callback, int groupId) => default; // 0x00000001888A2860-0x00000001888A2A18
		public int CreateBindingByActionId(string actionId, Action callback, int groupId) => default; // 0x0000000182856D10-0x0000000182856FD0
		public void DeleteBinding(int id) {} // 0x000000018304DC80-0x000000018304DD50
		public void ToggleBinding(int id, bool active) {} // 0x0000000182C6EF00-0x0000000182C6EFB0
		public int CreateGroup(int parentGroupId) => default; // 0x00000001822B02E0-0x00000001822B0460
		public void DeleteGroup(int id) {} // 0x0000000182C721F0-0x0000000182C72290
		public void DeleteInGroup(int groupId) {} // 0x0000000183650B50-0x0000000183650BE0
		public void ToggleGroup(int id, bool active) {} // 0x00000001824B2550-0x00000001824B2740
		public bool IsBindingEnabled(int id, bool needLogError = true /* Metadata: 0x01FD70F9 */) => default; // 0x00000001824AE5D0-0x00000001824AEA80
		public void ForceBindingKeyhintToGray(int id, bool grayState) {} // 0x00000001888A36E8-0x00000001888A37A0
		public bool IsBindingKeyhintGray(int id) => default; // 0x00000001888A4B7C-0x00000001888A4C24
		public bool IsGroupEnabled(int id) => default; // 0x00000001824B2350-0x00000001824B2550
		public void ToggleHideCursor() {} // 0x00000001888A5C10-0x00000001888A5C78
		public void ResetCursorInHideCursorMode() {} // 0x0000000183D1E960-0x0000000183D1E9B0
		public void ToggleCursorInHideCursorMode(string key, bool showCursor) {} // 0x00000001829A7100-0x00000001829A7170
		public void ToggleAllInput(bool active) {} // 0x0000000182D7ABD0-0x0000000182D7AC20
		public void SetBindingView(int bindingId, IBindingView bindingView) {} // 0x00000001888A5624-0x00000001888A56E4
		public void SetGroupView(int groupId, IBindingView groupView) {} // 0x0000000182A73CE0-0x0000000182A73D80
		public void ChangeParent(bool isGroup, int id, int newParentGroupId) {} // 0x0000000183610970-0x0000000183610B10
		public int GetGroupParentId(bool isGroup, int id) => default; // 0x0000000183610890-0x0000000183610970
		public void IgnoreBindingGroupParent(int groupId, bool parentIgnored) {} // 0x00000001888A49F4-0x00000001888A4AB8
		public void IgnoreBindingParent(int bindingId, bool parentIgnored) {} // 0x00000001888A4AB8-0x00000001888A4B7C
		public Beyond.Input.KeyboardKeyCode GetActionKeyboardKeyCode(string actionId, bool isModifyKey, bool isPrimary) => default; // 0x00000001888A3938-0x00000001888A3A78
		public GamepadKeyCode GetActionGamepadKeyCode(string actionId, bool isModifyKey, bool isPrimary, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x01FD70FA */) => default; // 0x00000001834BA190-0x00000001834BA260
		public void DeleteCustomBinding(string actionId, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x01FD70FB */) {} // 0x00000001888A2F10-0x00000001888A3660
		public void DeleteAllCustomBindings(InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x01FD70FC */) {} // 0x0000000182F0CA30-0x0000000182F0CC10
		public void SetBindingText(int id, string text) {} // 0x0000000182C6AD00-0x0000000182C6AE20
		public string GetBindingText(int id) => default; // 0x0000000182BDFD80-0x0000000182BDFE40
		public bool HasBinding(int id) => default; // 0x00000001888A496C-0x00000001888A49F4
		[IDTag(1)]
		public string GetActionText(string actionId) => default; // 0x0000000182BE0100-0x0000000182BE0190
		[IDTag(0)]
		public static string GetActionText(PlayerActionInfo info, string actionId) => default; // 0x0000000182BE0190-0x0000000182BE02B0
		public bool CheckActionKeyCodeConflict(string actionId, Beyond.Input.KeyboardKeyCode keyCode, out bool isPrimary) {
			isPrimary = default;
			return default;
		} // 0x00000001888A2550-0x00000001888A266C
		private void _DeleteGroup(InputBindingGroup group, bool isRootCall) {} // 0x0000000182857390-0x0000000182857470
		private void _DeleteInGroup(InputBindingGroup group) {} // 0x0000000182857470-0x0000000182858400
		private void _RealRemoveBindingInfo(InputBindingInfo info) {} // 0x00000001828592F0-0x0000000182859430
		public float GetAxis(string name) => default; // 0x0000000182913E30-0x0000000182913F30
		public void GetBindingInfo(int bindingId, out string actionId, out IBindingView bindingView) {
			actionId = default;
			bindingView = default;
		} // 0x0000000182BDE7F0-0x0000000182BDE950
		private void _LoadSetting() {} // 0x0000000182C6D7A0-0x0000000182C6DE80
		public void LoadSetting() {} // 0x0000000182C6DF60-0x0000000182C6EDC0
		public bool IsPlayerActionIdValid(string id) => default; // 0x0000000182C6DE80-0x0000000182C6DF60
		public PlayerActionInfo GetPlayerActionInfo(string id, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x01FD70FD */) => default; // 0x0000000182856FD0-0x00000001828570F0
		public void ChangePlayerAction(string id, PlayerActionInfo actionInfo) {} // 0x00000001888A24E8-0x00000001888A2550
		public string AddAnonymousPlayerAction(PlayerActionInfo actionInfo) => default; // 0x00000001888A1FC4-0x00000001888A209C
		private void _LoadCustomInputSetting() {} // 0x0000000183B107B0-0x0000000183B10940
		private PlayerActionInfo _GetOrCreatePendingActionInfo(string actionId) => default; // 0x00000001888A75B0-0x00000001888A783C
		[IDTag(0)]
		public bool CustomizeActionKey(string actionId, Beyond.Input.KeyboardKeyCode key, bool isPrimary, string overrideKeyIconName = null) => default; // 0x00000001888A2CF0-0x00000001888A2F10
		[IDTag(1)]
		public bool CustomizeActionKey(string actionId, GamepadKeyCode? modifyKey, GamepadKeyCode? key, bool isPrimary, string overrideKeyIconName = null) => default; // 0x00000001888A2A18-0x00000001888A2CF0
		public void ClearPendingInputSetting() {} // 0x00000001888A272C-0x00000001888A27A8
		public void SaveCustomInputSetting() {} // 0x0000000182F0BB70-0x0000000182F0C2E0
		private void _CreateCanvas() {} // 0x0000000183801880-0x0000000183801B20
		private void _CreateDebugVirtualMouse() {} // 0x0000000183801B20-0x0000000183801BC0
		private void _CreateVirtualMouse() {} // 0x0000000183801BC0-0x0000000183801D80
		private void _ToggleVirtualMouse(bool active, bool forceUpdate = false /* Metadata: 0x01FD70FE */) {} // 0x00000001829A71D0-0x00000001829A7370
		private void _CheckVirtualMouseState() {} // 0x00000001829A7170-0x00000001829A71D0
		public static Vector3 GetMousePos() => default; // 0x000000018284FE70-0x0000000182850010
		public void SetOnlyVirtualMousePos(Vector2 newPos) {} // 0x00000001888A58C8-0x00000001888A5964
		public static void SetMousePos(Vector2 newPos, bool hideVirtualMouse = false /* Metadata: 0x01FD70FF */) {} // 0x00000001888A56E4-0x00000001888A58C8
		public static bool GetMouseButton(int button) => default; // 0x00000001824AEFE0-0x00000001824AF510
		public static bool IsLeftMouseDown() => default; // 0x000000018284ED60-0x000000018284EE00
		public static bool GetMouseButtonDown(int button) => default; // 0x0000000182850210-0x0000000182850340
		public static bool GetMouseButtonUp(int button) => default; // 0x00000001828500A0-0x00000001828501D0
		public void SetCustomControllerMouse(Transform trans, Camera uiCamera) {} // 0x0000000183D48150-0x0000000183D481C0
		public List<ControllerHintInfo> GetEmptyControllerHintInfoList() => default; // 0x00000001888A4058-0x00000001888A420C
		[IDTag(0)]
		public void GetControllerHintInfos(int groupId, bool ignoreRootEnabled, ref List<ControllerHintInfo> infoList) {} // 0x00000001888A3B28-0x00000001888A3C1C
		[IDTag(1)]
		public void GetControllerHintInfos(List<string> actionIdList, ref List<ControllerHintInfo> infoList) {} // 0x00000001888A3A78-0x00000001888A3B28
		[IDTag(0)]
		private void _GetControllerHintInfos(InputBindingGroup group, bool ignoreRootEnabled, ref List<ControllerHintInfo> infoList) {} // 0x00000001888A6AAC-0x00000001888A7214
		[IDTag(1)]
		private void _GetControllerHintInfos(List<string> actionIdList, ref List<ControllerHintInfo> infoList) {} // 0x00000001888A68D8-0x00000001888A6AAC
		public float GetPlayerActionLongPressStartTime(string actionId, out float longPressTime) {
			longPressTime = default;
			return default;
		} // 0x00000001888A4680-0x00000001888A47C4
		public float GetActionBindingLongPressStartTime(int bindingId, out float longPressTime) {
			longPressTime = default;
			return default;
		} // 0x00000001888A37A0-0x00000001888A3938
		public bool GetControllerIndicatorState() => default; // 0x00000001838C88F0-0x00000001838C8970
		public bool CheckNormalAttackBtn() => default; // 0x0000000183B294E0-0x0000000183B29570
		private void _UpdateControllerIndicator(float deltaTime) {} // 0x000000018297A790-0x000000018297AB10
		public int TryPressControllerIndicatorWhenSkillButtonJustPressed() => default; // 0x00000001888A5DE8-0x00000001888A5EC4
		public void TryClickSkillButtonWhenControllerIndicatorJustRelease(int charIndex) {} // 0x00000001888A5D10-0x00000001888A5DE8
		private void _RefreshControllerBattleButton() {} // 0x00000001837C9F40-0x00000001837CA2B0
		public void AddGuideUseActionId(string actionId) {} // 0x00000001888A209C-0x00000001888A2140
		public void RemoveGuideUseActionId(string actionId) {} // 0x00000001888A4FE8-0x00000001888A508C
		public void ClearGuideUseActionIds() {} // 0x00000001888A26B0-0x00000001888A272C
		public void VibrateController(float time, float level = 0.5f /* Metadata: 0x01FD7100 */) {} // 0x00000001888A5F04-0x00000001888A5FB8
		private static string _GetGamepadKeyIconFolderPath() => default; // 0x00000001888A74DC-0x00000001888A75B0
		public static string GetStringByKeyboardKeyCode(Beyond.Input.KeyboardKeyCode code) => default; // 0x0000000182C73810-0x0000000182C73980
		public static string GetStringByGamepadKeyCode(GamepadKeyCode code) => default; // 0x00000001888A47C4-0x00000001888A496C
		[IDTag(0)]
		public static string GetKeyIconPath(GamepadInput inputInfo, bool isModifyKey, bool isFullPath, bool ignoreOverrideKeyIcon = false /* Metadata: 0x01FD7104 */) => default; // 0x00000001888A4524-0x00000001888A4630
		public static string GetGamepadKeyIconPath(string keyStr, bool isLongPress, bool isFullPath) => default; // 0x00000001888A420C-0x00000001888A42BC
		[IDTag(2)]
		public static string GetKeyIconPath(KeyboardInput inputInfo, bool isModifyKey, bool isFullPath) => default; // 0x0000000182C732D0-0x0000000182C73380
		[IDTag(1)]
		public static string GetKeyIconPath(KeyboardInput inputInfo, bool isModifyKey, bool isLongPress, bool isFullPath) => default; // 0x0000000182C73380-0x0000000182C734E0
		private static string _GetKeyIconPath(string path, string keyStr, bool isLongPress, bool isFullPath) => default; // 0x0000000182C734E0-0x0000000182C73610
		public static string ParseTextActionId(string text) => default; // 0x00000001837680F0-0x0000000183768280
		public void MoveMouseTo(RectTransform target, Camera uiCamera) {} // 0x00000001888A4C24-0x00000001888A4EA0
		public void MoveVirtualMouseTo(RectTransform target, Camera uiCamera, bool hideVirtualMouse = true /* Metadata: 0x01FD7105 */) {} // 0x00000001888A4EA0-0x00000001888A4F48
		public void SetVirtualMouseIconVisible(bool active) {} // 0x00000001888A5964-0x00000001888A59D8
		private void _ControllerTouchPanelTick() {} // 0x00000001888A6700-0x00000001888A68D8
		public static int GetTouchId(PointerEventData eventData) => default; // 0x000000018284E4B0-0x000000018284E520
		public static bool GetPressPosByTouchId(int touchId, out Vector2 position) {
			position = default;
			return default;
		} // 0x0000000182CACD80-0x0000000182CAD100
		public void Dispose() {} // 0x00000001888A3660-0x00000001888A36E8
		public static void RemoveUnusedInput() {} // 0x00000001888A508C-0x00000001888A5624
		private void _OnNetMaskChanged([IsReadOnly] in EventData<bool> v) {} // 0x0000000183A5A340-0x0000000183A5A3C0
		public string GetCurJsInfos() => default; // 0x00000001888A3C1C-0x00000001888A4058
	}

	[CreateAssetMenu(fileName = "InputRebindConfig", menuName = "Beyond/UI/InputRebindConfig")]
	public class InputRebindConfig : ScriptableObject // TypeDefIndex: 55666
	{
		// Fields
		public const string INPUT_REBIND_CONFIG_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Input/InputRebindConfig.asset"; // Metadata: 0x01FD723C
		public InputRebindActionScopeConfig[] actionScopeConfigs; // 0x18
	
		// Constructors
		public InputRebindConfig() {} // 0x000000018286F540-0x000000018286F550
	}

	[Serializable]
	public class InputRebindActionScopeConfig // TypeDefIndex: 55667
	{
		// Fields
		public string name; // 0x10
		public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeWhiteList; // 0x18
		public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeBlackList; // 0x20
	
		// Constructors
		public InputRebindActionScopeConfig() {} // 0x000000018350B670-0x000000018350B680
	}

	public class InputSetting : ScriptableObject // TypeDefIndex: 55668
	{
		// Fields
		public const string CUSTOM_SETTING_DIRECTORY_NAME = "Input"; // Metadata: 0x01FD7283
		public const string CUSTOM_SETTING_JSON_FILE_NAME = "CustomInputSetting.json"; // Metadata: 0x01FD7289
		[SerializeField]
		public SerializeFieldDictionaryPaired<string, PlayerActionInfo> actionInfos; // 0x18
	
		// Constructors
		public InputSetting() {} // 0x000000018286D830-0x000000018286D8C0
	}

	[CreateAssetMenu(fileName = "InputSettingConfig", menuName = "Beyond/UI/InputSettingConfig")]
	public class InputSettingConfig : ScriptableObject // TypeDefIndex: 55669
	{
		// Fields
		public const string INPUT_SETTING_CONFIG_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Input/InputSettingConfig.asset"; // Metadata: 0x01FD72A1
		public List<InputSetting> inputSettingList; // 0x18
	
		// Constructors
		public InputSettingConfig() {} // 0x0000000183CF2860-0x0000000183CF28E0
	}

	public static class InputUtils // TypeDefIndex: 55670
	{
		// Methods
		public static bool HasFlag(InputDeviceFlags value, InputDeviceFlags target) => default; // 0x00000001888B1C8C-0x00000001888B1CE8
	
		// Extension methods
		public static void IgnoreBindingParent(this IBindingTarget target, bool active) {} // 0x00000001888B1D94-0x00000001888B1EA8
		public static void IgnoreBindingGroupParent(this IBindingGroupTarget target, bool active) {} // 0x00000001888B1CE8-0x00000001888B1D94
	}

	internal abstract class KeyboardCheckerBase // TypeDefIndex: 55673
	{
		// Fields
		protected Beyond.Input.InputManager m_inputManager; // 0x10
		protected const int CTRL = 1; // Metadata: 0x01FD72EA
		protected const int SHIFT = 2; // Metadata: 0x01FD72EB
		protected const int ALT = 4; // Metadata: 0x01FD72EC
		protected const int MAX_INDEX = 7; // Metadata: 0x01FD72ED
		protected static int[] s_checkPriority; // 0x00
		protected List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<Binding>>> m_bindingInfos; // 0x18
	
		// Properties
		internal List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<Binding>>> bindingInfos { get; } // 0x00000001888B1EEC-0x00000001888B1F3C 
	
		// Nested types
		public class Binding // TypeDefIndex: 55671
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
			public Binding() {} // Dummy constructor
			public Binding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x01FD72EE */) {} // 0x00000001828572A0-0x0000000182857390
		}
	
		public enum TriggerType // TypeDefIndex: 55672
		{
			NORMAL = 0,
			CONTINUOUS = 1,
			STOP_CONTINUOUS = 2
		}
	
		// Constructors
		protected KeyboardCheckerBase() {} // Dummy constructor
		protected KeyboardCheckerBase(Beyond.Input.InputManager inputManager) {} // 0x0000000182975800-0x0000000182975920
		static KeyboardCheckerBase() {} // 0x0000000183CE3D30-0x0000000183CE3DC0
	
		// Methods
		public static int GetModifyIndex(KeyboardInput input) => default; // 0x0000000182857250-0x00000001828572A0
		public virtual Binding OnCreateBinding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x01FD72E9 */) => default; // 0x00000001828563F0-0x00000001828565E0
		public virtual Binding OnDeleteBinding(KeyboardInput input, InputBindingInfo info) => default; // 0x0000000182859480-0x00000001828597A0
		public virtual void CheckKeyboardInput() {} // 0x00000001888B1EA8-0x00000001888B1EEC
		public virtual void TriggerActions() {} // 0x0000000183415700-0x0000000183415730
	}

	internal class KeyboardChecker : KeyboardCheckerBase // TypeDefIndex: 55674
	{
		// Fields
		private Func<Beyond.Input.KeyboardKeyCode, bool> m_checkFunc; // 0x20
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x30
		private List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x38
	
		// Properties
		public bool isPressChecker { get; private set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
	
		// Constructors
		public KeyboardChecker() {} // Dummy constructor
		public KeyboardChecker(Func<Beyond.Input.KeyboardKeyCode, bool> checkFunc, bool isPress, Beyond.Input.InputManager inputManager) {} // 0x00000001829756A0-0x0000000182975800
	
		// Methods
		public override void CheckKeyboardInput() {} // 0x0000000182853EB0-0x0000000182854960
		public override void TriggerActions() {} // 0x0000000182851D00-0x0000000182852330
		public void __iFixBaseProxy_CheckKeyboardInput() {} // 0x00000001888B1F3C-0x00000001888B1F44
		public void __iFixBaseProxy_TriggerActions() {} // 0x00000001888B1F44-0x00000001888B1F4C
	}

	internal class KeyboardOnClickChecker : KeyboardCheckerBase // TypeDefIndex: 55675
	{
		// Fields
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x20
		private List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x28
		private List<ListSet<Beyond.Input.KeyboardKeyCode>> m_combinationKeyPressedInfo; // 0x30
	
		// Constructors
		public KeyboardOnClickChecker() {} // Dummy constructor
		public KeyboardOnClickChecker(Beyond.Input.InputManager inputManager) {} // 0x00000001838303E0-0x00000001838305E0
	
		// Methods
		public override void CheckKeyboardInput() {} // 0x0000000182854960-0x00000001828563F0
		public override void TriggerActions() {} // 0x0000000182851400-0x00000001828519C0
		public void ClearKeyPressed(Beyond.Input.KeyboardKeyCode keyCode) {} // 0x00000001888B1F4C-0x00000001888B222C
		public void __iFixBaseProxy_CheckKeyboardInput() {} // 0x00000001888B1F3C-0x00000001888B1F44
		public void __iFixBaseProxy_TriggerActions() {} // 0x00000001888B1F44-0x00000001888B1F4C
	}

	internal class KeyboardOnLongPressChecker : KeyboardCheckerBase // TypeDefIndex: 55677
	{
		// Fields
		private Action<Beyond.Input.KeyboardKeyCode> m_onTriggerOnLongPress; // 0x20
		private Dictionary<KeyboardInput, HashSet<Binding>> m_bindings; // 0x28
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x30
	
		// Constructors
		public KeyboardOnLongPressChecker() {} // Dummy constructor
		public KeyboardOnLongPressChecker(Action<Beyond.Input.KeyboardKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager) {} // 0x0000000183B46090-0x0000000183B461B0
	
		// Methods
		public override void CheckKeyboardInput() {} // 0x0000000182852390-0x0000000182852DA0
		private void _OnTriggerBinding(Binding binding, Beyond.Input.KeyboardKeyCode keyCode) {} // 0x00000001888B26EC-0x00000001888B280C
		public override Binding OnCreateBinding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x01FD72F2 */) => default; // 0x00000001888B243C-0x00000001888B25B4
		public override Binding OnDeleteBinding(KeyboardInput input, InputBindingInfo info) => default; // 0x00000001888B25B4-0x00000001888B26D4
		public float GetInputLongPressStartTime(KeyboardInput input, int bindingId = 0 /* Metadata: 0x01FD72F3 */) => default; // 0x00000001888B222C-0x00000001888B243C
		public void __iFixBaseProxy_CheckKeyboardInput() {} // 0x00000001888B1F3C-0x00000001888B1F44
		public Binding __iFixBaseProxy_OnCreateBinding(KeyboardInput P0, InputBindingInfo P1, bool P2) => default; // 0x00000001888B26D4-0x00000001888B26E4
		public Binding __iFixBaseProxy_OnDeleteBinding(KeyboardInput P0, InputBindingInfo P1) => default; // 0x00000001888B26E4-0x00000001888B26EC
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	public class PlayerActionIdAttribute : Attribute // TypeDefIndex: 55678
	{
		// Constructors
		public PlayerActionIdAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Flags]
	public enum InputDeviceFlags : byte // TypeDefIndex: 55679
	{
		None = 0,
		Keyboard = 1,
		Gamepad = 2,
		All = 3
	}

	[Serializable]
	public class PlayerActionInfo // TypeDefIndex: 55680
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
		public PlayerActionInfo() {} // 0x0000000181168960-0x0000000181168970
	
		// Methods
		public void ResetHintProority() {} // 0x00000001888B7CC4-0x00000001888B7DB0
		public bool DeviceInputEquals(PlayerActionInfo other, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x01FD72F8 */) => default; // 0x00000001888B7BBC-0x00000001888B7CC4
		public void DeviceInputCopyFrom(PlayerActionInfo other, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x01FD72F9 */) {} // 0x00000001888B7AE0-0x00000001888B7BBC
	}

	[Serializable]
	public abstract class DeviceInput<T> : IEquatable<T> // TypeDefIndex: 55681
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
		protected DeviceInput() {}
	
		// Methods
		public virtual string GetModifyText() => default;
		public virtual string GetKeyCodeText() => default;
		public virtual int GetKeyCodeEnumIntValue() => default;
		public virtual void SetKeyCodeEnumByIntValue(int value) {}
		public virtual void ClearKeyCode() {}
		public virtual bool IsValid() => default;
		public virtual void CopyFrom(T other) {}
		public abstract bool Equals(T other);
		public override string ToString() => default;
	}

	[Serializable]
	public class KeyboardInput : DeviceInput<KeyboardInput> // TypeDefIndex: 55682
	{
		// Fields
		public Beyond.Input.KeyboardKeyCode key; // 0x30
		public bool useCtrl; // 0x34
		public bool useShift; // 0x35
		public bool useAlt; // 0x36
	
		// Properties
		public string modifyString { get => default; } // 0x00000001888B7A04-0x00000001888B7AE0 
	
		// Constructors
		public KeyboardInput() {} // 0x00000001832E1470-0x00000001832E14B0
	
		// Methods
		public override string GetModifyText() => default; // 0x00000001888B7878-0x00000001888B797C
		public override string GetKeyCodeText() => default; // 0x00000001888B7628-0x00000001888B7878
		public override int GetKeyCodeEnumIntValue() => default; // 0x00000001888B75DC-0x00000001888B7628
		public override void SetKeyCodeEnumByIntValue(int value) {} // 0x00000001888B797C-0x00000001888B79D4
		public override void ClearKeyCode() {} // 0x00000001888B7478-0x00000001888B74D4
		public override bool IsValid() => default; // 0x0000000183C906C0-0x0000000183C906F0
		public override void CopyFrom(KeyboardInput other) {} // 0x00000001888B74D4-0x00000001888B7574
		public override bool Equals(KeyboardInput other) => default; // 0x00000001888B7574-0x00000001888B75DC
		public string __iFixBaseProxy_GetModifyText() => default; // 0x00000001888B79EC-0x00000001888B79F4
		public string __iFixBaseProxy_GetKeyCodeText() => default; // 0x00000001888B79E4-0x00000001888B79EC
		public int __iFixBaseProxy_GetKeyCodeEnumIntValue() => default; // 0x00000001888B79DC-0x00000001888B79E4
		public void __iFixBaseProxy_SetKeyCodeEnumByIntValue(int P0) {} // 0x00000001888B79FC-0x00000001888B7A04
		public void __iFixBaseProxy_ClearKeyCode() {} // 0x00000001888B79D4-0x00000001888B79DC
		public bool __iFixBaseProxy_IsValid() => default; // 0x00000001888B79F4-0x00000001888B79FC
	}

	[Serializable]
	public class GamepadInput : DeviceInput<GamepadInput> // TypeDefIndex: 55683
	{
		// Fields
		public GamepadKeyCode key; // 0x30
		public GamepadKeyCode modifyKey; // 0x34
	
		// Constructors
		public GamepadInput() {} // 0x00000001832E14B0-0x00000001832E14F0
	
		// Methods
		public override string GetModifyText() => default; // 0x00000001888B2EF4-0x00000001888B2F9C
		public override string GetKeyCodeText() => default; // 0x00000001888B2E6C-0x00000001888B2EF4
		public override int GetKeyCodeEnumIntValue() => default; // 0x00000001888B2E20-0x00000001888B2E6C
		public override void SetKeyCodeEnumByIntValue(int value) {} // 0x00000001888B2FEC-0x00000001888B3044
		public override void ClearKeyCode() {} // 0x00000001888B2D2C-0x00000001888B2D8C
		public override bool IsValid() => default; // 0x00000001888B2F9C-0x00000001888B2FEC
		public override void CopyFrom(GamepadInput other) {} // 0x00000001888B2D8C-0x00000001888B2E20
		public override bool Equals(GamepadInput other) => default; // 0x0000000183CB5F60-0x0000000183CB5FB0
		public string __iFixBaseProxy_GetModifyText() => default; // 0x00000001888B305C-0x00000001888B3064
		public string __iFixBaseProxy_GetKeyCodeText() => default; // 0x00000001888B3054-0x00000001888B305C
		public int __iFixBaseProxy_GetKeyCodeEnumIntValue() => default; // 0x00000001888B304C-0x00000001888B3054
		public void __iFixBaseProxy_SetKeyCodeEnumByIntValue(int P0) {} // 0x00000001888B306C-0x00000001888B3074
		public void __iFixBaseProxy_ClearKeyCode() {} // 0x00000001888B3044-0x00000001888B304C
		public bool __iFixBaseProxy_IsValid() => default; // 0x00000001888B3064-0x00000001888B306C
	}

	internal class RealCursorManager // TypeDefIndex: 55684
	{
		// Fields
		private Dictionary<string, bool> m_internalCursorState; // 0x18
	
		// Properties
		public bool forceShowCursorForF5 { get; private set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public bool forceHideCursorForUsingController { get; private set; } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000183D510F0-0x0000000183D51100
		public bool isUsingVirtualMouse { get; private set; } // 0x0000000183D519E0-0x0000000183D519F0 0x0000000183D6B770-0x0000000183D6B780
		public bool forceShowRealCursorForChangeInput { get; private set; } // 0x0000000183D69BB0-0x0000000183D69BC0 0x0000000183D6DC80-0x0000000183D6DC90
	
		// Constructors
		public RealCursorManager() {} // 0x0000000183CEF140-0x0000000183CEF1D0
	
		// Methods
		public void SetForceHideCursorForController(bool forceHide, bool isUsingVirtualMouse) {} // 0x0000000182CAA270-0x0000000182CAA2D0
		public void SetDebugShowCursorMode(bool enableDebug) {} // 0x00000001888B7DB0-0x00000001888B7E18
		public void ToggleForceShowRealCursorForChangeInput(bool forceShow) {} // 0x00000001888B7E18-0x00000001888B7E80
		public bool IsNeedShowCursor() => default; // 0x00000001824AF990-0x00000001824AFD10
		public void ResetCursorInHideCursorMode() {} // 0x00000001829A87E0-0x00000001829A8C90
		public void ToggleCursorInHideCursorMode(string operationKey, bool showCursor) {} // 0x00000001829A7370-0x00000001829A7480
		public void CalcState(bool forceUpdate = false /* Metadata: 0x01FD72FA */) {} // 0x00000001829A7480-0x00000001829A74F0
		private void _ToggleCursorInternal(bool enable, bool forceUpdate = false /* Metadata: 0x01FD72FB */) {} // 0x00000001829A74F0-0x00000001829A7600
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	public class TextIdAttribute : Attribute // TypeDefIndex: 55685
	{
		// Constructors
		public TextIdAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class UIEvent : UnityEvent, IBindingTarget // TypeDefIndex: 55686
	{
		// Fields
		private bool m_bindingInit; // 0x30
		[FormerlySerializedAs("_useBindingKeys")]
		[FormerlySerializedAs("useBindingKeys")]
		public bool useBindingAction; // 0x31
		public string playerActionId; // 0x38
		[SerializeReference]
		public PlayerActionInfo anonymousPlayerActionInfo; // 0x40
		[NonSerialized]
		public string anonymousPlayerActionId; // 0x48
		private Action m_bindAct; // 0x60
		private Action m_onUpdateKeyAct; // 0x68
		private List<UnityAction> m_calls; // 0x70
	
		// Properties
		public bool bindingEnabled { get => default; } // 0x00000001888B867C-0x00000001888B8724 
		public int bindingId { get; private set; } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000183D4EF20-0x0000000183D4EF30
		public IBindingGroupTarget parentTarget { get; private set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public int count { get => default; } // 0x00000001888B8724-0x00000001888B8764 
	
		// Constructors
		public UIEvent() {} // 0x00000001888B866C-0x00000001888B867C
	
		// Methods
		private void _CreatePlayerActionBinding() {} // 0x00000001888B8538-0x00000001888B866C
		public void InitBinding(IBindingGroupTarget parent, Action bindAct, Action onUpdateKeyAct) {} // 0x00000001888B8068-0x00000001888B8140
		public new void Invoke() {} // 0x00000001888B8140-0x00000001888B8210
		public void UpdateKeys() {} // 0x00000001888B8498-0x00000001888B8538
		public void ChangeBindingPlayerAction(string actionId) {} // 0x00000001888B7FFC-0x00000001888B8068
		public new void AddListener(UnityAction call) {} // 0x00000001888B7EAC-0x00000001888B7FFC
		public new void RemoveListener(UnityAction call) {} // 0x00000001888B83C8-0x00000001888B8498
		public new void RemoveAllListeners() {} // 0x00000001888B8210-0x00000001888B83C8
	}

	[Serializable]
	public class UIEvent<T0> : UnityEvent<T0>, IBindingTarget // TypeDefIndex: 55687
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
		private Action m_bindAct;
		private Action m_onUpdateKeyAct;
		private List<UnityAction<T0>> m_calls;
	
		// Properties
		public bool bindingEnabled { get => default; }
		public int bindingId { get; private set; }
		public IBindingGroupTarget parentTarget { get; private set; }
		public int count { get => default; }
	
		// Constructors
		public UIEvent() {}
	
		// Methods
		private void _CreatePlayerActionBinding() {}
		public void InitBinding(IBindingGroupTarget parent, Action bindAct, Action onUpdateKeyAct) {}
		public new void Invoke(T0 arg0) {}
		public PlayerActionInfo GetEventPlayerActionInfo() => default;
		public void UpdateKeys() {}
		public void ChangeBindingPlayerAction(string actionId) {}
		public void StopUseBinding() {}
		public string GetActionId() => default;
		public new void AddListener(UnityAction<T0> call) {}
		public new void RemoveListener(UnityAction<T0> call) {}
		public new void RemoveAllListeners() {}
	}

	[Serializable]
	public class UIEvent<T0, T1> : UnityEvent<T0, T1>, IBindingTarget // TypeDefIndex: 55688
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
		private Action m_bindAct;
		private Action m_onUpdateKeyAct;
		private List<UnityAction<T0, T1>> m_calls;
	
		// Properties
		public bool bindingEnabled { get => default; }
		public int bindingId { get; private set; }
		public IBindingGroupTarget parentTarget { get; private set; }
		public int count { get => default; }
	
		// Constructors
		public UIEvent() {}
	
		// Methods
		private void _CreatePlayerActionBinding() {}
		public void InitBinding(IBindingGroupTarget parent, Action bindAct, Action onUpdateKeyAct) {}
		public new void Invoke(T0 arg0, T1 arg1) {}
		public void UpdateKeys() {}
		public void ChangeBindingPlayerAction(string actionId) {}
		public new void AddListener(UnityAction<T0, T1> call) {}
		public new void RemoveListener(UnityAction<T0, T1> call) {}
		public new void RemoveAllListeners() {}
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 55627
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 55628
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 55629
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 55630
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 55631
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 55624
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 55691
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D06130-0x0000000183D061A0
	
		// Methods
		public bool __Gen_Wrap_0(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public uint __Gen_Wrap_1() => default; // 0x00000001850EF068-0x00000001850EF114
		public void __Gen_Wrap_2(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public void __Gen_Wrap_3(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public void __Gen_Wrap_4(object P0, int P1, bool P2) {} // 0x0000000185477648-0x0000000185477740
		public void __Gen_Wrap_5(object P0, NavigationBindingType P1) {} // 0x000000018549D548-0x000000018549D624
		public bool __Gen_Wrap_6(object P0, int P1) => default; // 0x000000018548C780-0x000000018548C86C
		public void __Gen_Wrap_7(object P0, object P1, bool P2) {} // 0x00000001854790D0-0x00000001854791C8
		public bool __Gen_Wrap_8(object P0, object P1, object P2) => default; // 0x000000018562978C-0x0000000185629894
		public void __Gen_Wrap_9(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public Vector3 __Gen_Wrap_10(object P0, NaviDirection P1) => default; // 0x00000001888B3358-0x00000001888B3474
		public Vector3 __Gen_Wrap_11(object P0, Vector2 P1) => default; // 0x00000001888B3474-0x00000001888B35B8
		public Selectable __Gen_Wrap_12(object P0, object P1, Vector3 P2, Vector3 P3, NaviStrategy P4, double P5, out double P6) {
			P6 = default;
			return default;
		} // 0x00000001888B35B8-0x00000001888B3784
		public Selectable __Gen_Wrap_13(object P0, object P1, Vector3 P2, Vector3 P3, double P4, out double P5) {
			P5 = default;
			return default;
		} // 0x00000001888B3784-0x00000001888B3940
		public bool __Gen_Wrap_14(object P0, NaviDirection P1) => default; // 0x0000000185E7433C-0x0000000185E74414
		public bool __Gen_Wrap_15(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
		public void __Gen_Wrap_16(object P0, object P1, NavigationBindingType P2) {} // 0x000000018516413C-0x0000000185164220
		public void __Gen_Wrap_17(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public void __Gen_Wrap_18(object P0, NaviDirection P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __Gen_Wrap_19(object P0) => default; // 0x00000001888B3940-0x00000001888B3A1C
		public DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>>> __Gen_Wrap_20(object P0) => default; // 0x00000001888B3A1C-0x00000001888B3AF8
		public DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __Gen_Wrap_21(object P0, object P1) => default; // 0x00000001888B3AF8-0x00000001888B3C04
		public GamepadCheckerBase.Binding __Gen_Wrap_22(object P0, object P1, object P2, bool P3) => default; // 0x00000001888B3C04-0x00000001888B3D38
		public GamepadCheckerBase.Binding __Gen_Wrap_23(object P0, object P1, object P2) => default; // 0x00000001888B3D38-0x00000001888B3E60
		public void __Gen_Wrap_24(object P0, object P1, GamepadKeyCode P2) {} // 0x000000018516413C-0x0000000185164220
		public void __Gen_Wrap_25() {} // 0x00000001851624BC-0x0000000185162544
		public void __Gen_Wrap_26(object P0, InputContinuousTriggerType P1) {} // 0x000000018549D548-0x000000018549D624
		public IBindingView __Gen_Wrap_27(object P0) => default; // 0x00000001888B3E60-0x00000001888B3F50
		public void __Gen_Wrap_28(object P0, GamepadKeyCode P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public PlayerActionInfo __Gen_Wrap_29(object P0, object P1, InputSettingLevel P2) => default; // 0x00000001888B3F50-0x00000001888B4074
		public string __Gen_Wrap_30(object P0, object P1) => default; // 0x00000001888B4074-0x00000001888B4180
		public string __Gen_Wrap_31(object P0) => default; // 0x00000001888B4180-0x00000001888B4270
		public Action __Gen_Wrap_32(object P0, object P1, GamepadKeyCode P2) => default; // 0x00000001888B4270-0x00000001888B4384
		public float __Gen_Wrap_33(object P0, object P1, int P2) => default; // 0x00000001888B4384-0x00000001888B4488
		public bool __Gen_Wrap_34(GamepadKeyCode P0) => default; // 0x0000000185151D64-0x0000000185151E1C
		public void __Gen_Wrap_35(InputActionProperty P0, object P1, bool P2) {} // 0x00000001888B4488-0x00000001888B45AC
		public void __Gen_Wrap_36(ref InputActionProperty P0, InputActionProperty P1) {} // 0x00000001888B45AC-0x00000001888B4724
		public void __Gen_Wrap_37(object P0, InputActionProperty P1) {} // 0x00000001888B4724-0x00000001888B482C
		public void __Gen_Wrap_38(object P0, UnityEngine.InputSystem.InputAction.CallbackContext P1) {} // 0x00000001888B482C-0x00000001888B492C
		public int __Gen_Wrap_39(object P0, int P1) => default; // 0x00000001854761A8-0x0000000185476294
		public int __Gen_Wrap_40(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public KeyboardCheckerBase.Binding __Gen_Wrap_41(object P0, object P1, object P2, bool P3) => default; // 0x00000001888B492C-0x00000001888B4A60
		public int __Gen_Wrap_42(object P0, object P1, object P2, int P3) => default; // 0x00000001888B4A60-0x00000001888B4B74
		public bool __Gen_Wrap_43(Selectable P0) => default; // 0x00000001850EF298-0x00000001850EF354
		public Selectable __Gen_Wrap_44(object P0) => default; // 0x00000001888B4B74-0x00000001888B4C50
		public KeyboardCheckerBase.Binding __Gen_Wrap_45(object P0, object P1, object P2) => default; // 0x00000001888B4C50-0x00000001888B4D78
		public void __Gen_Wrap_46(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public object __Gen_Wrap_47(object P0) => default; // 0x00000001888B4D78-0x00000001888B4E54
		public bool __Gen_Wrap_48() => default; // 0x000000018514F380-0x000000018514F42C
		public Vector2 __Gen_Wrap_49(object P0, bool P1, bool P2) => default; // 0x00000001888B4E54-0x00000001888B4F7C
		public Vector2 __Gen_Wrap_50() => default; // 0x00000001888B4F7C-0x00000001888B5048
		public void __Gen_Wrap_51(bool P0) {} // 0x000000018514F660-0x000000018514F720
		public void __Gen_Wrap_52(object P0, bool P1, bool P2) {} // 0x0000000185E3DBF4-0x0000000185E3DCEC
		public void __Gen_Wrap_53(object P0, Beyond.DeviceInfo.InputType P1) {} // 0x000000018549D548-0x000000018549D624
		public Dictionary<string, HashSet<int>> __Gen_Wrap_54(object P0) => default; // 0x00000001888B5048-0x00000001888B5138
		public void __Gen_Wrap_55(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public void __Gen_Wrap_56(object P0, Beyond.Input.KeyboardKeyCode P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public void __Gen_Wrap_57(Beyond.Input.KeyboardKeyCode P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public void __Gen_Wrap_58(GamepadKeyCode P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public Beyond.DeviceInfo.ControllerType __Gen_Wrap_59(object P0, object P1) => default; // 0x00000001850EF354-0x00000001850EF42C
		public string __Gen_Wrap_60(GamepadKeyCode P0) => default; // 0x00000001888B5138-0x00000001888B5224
		public string __Gen_Wrap_61() => default; // 0x00000001888B5224-0x00000001888B52F0
		public string __Gen_Wrap_62(object P0, object P1, bool P2, bool P3) => default; // 0x00000001888B52F0-0x00000001888B5424
		public string __Gen_Wrap_63(object P0, bool P1, bool P2) => default; // 0x00000001888B5424-0x00000001888B554C
		public string __Gen_Wrap_64(object P0, bool P1, bool P2, bool P3) => default; // 0x00000001888B554C-0x00000001888B5680
		public string __Gen_Wrap_65(Beyond.Input.KeyboardKeyCode P0) => default; // 0x00000001888B5680-0x00000001888B576C
		public float __Gen_Wrap_66(object P0, bool P1) => default; // 0x00000001888B576C-0x00000001888B5858
		public void __Gen_Wrap_67(object P0, in EventData<bool> P1) {} // 0x00000001888B5858-0x00000001888B5978
		public bool __Gen_Wrap_68(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2) {
			P2 = default;
			return default;
		} // 0x00000001888B5978-0x00000001888B5A90
		public bool __Gen_Wrap_69(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2, out bool P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x00000001888B5A90-0x00000001888B5BDC
		public bool __Gen_Wrap_70(object P0, GamepadKeyCode P1, Beyond.Input.InputManager.KeyCodeState P2) => default; // 0x000000018561022C-0x0000000185610330
		public int __Gen_Wrap_71(object P0, object P1, object P2, int P3, out string P4) {
			P4 = default;
			return default;
		} // 0x00000001888B5BDC-0x00000001888B5D4C
		public int __Gen_Wrap_72(object P0, Beyond.Input.KeyboardKeyCode P1, object P2, InputTimingType P3, object P4, int P5) => default; // 0x00000001888B5D4C-0x00000001888B5E70
		public bool __Gen_Wrap_73(object P0, int P1, bool P2) => default; // 0x000000018578888C-0x0000000185788990
		public void __Gen_Wrap_74(object P0, int P1, object P2) {} // 0x000000018514F720-0x000000018514F818
		public void __Gen_Wrap_75(object P0, bool P1, int P2, int P3) {} // 0x00000001888B5E70-0x00000001888B5F78
		public int __Gen_Wrap_76(object P0, bool P1, int P2) => default; // 0x00000001888B5F78-0x00000001888B607C
		public Beyond.Input.KeyboardKeyCode __Gen_Wrap_77(object P0, object P1, bool P2, bool P3) => default; // 0x00000001888B607C-0x00000001888B6184
		public GamepadKeyCode __Gen_Wrap_78(object P0, object P1, bool P2, bool P3, InputSettingLevel P4) => default; // 0x00000001888B6184-0x00000001888B62A8
		public bool __Gen_Wrap_79(InputDeviceFlags P0, InputDeviceFlags P1) => default; // 0x0000000185164540-0x000000018516462C
		public bool __Gen_Wrap_80(object P0, object P1, InputDeviceFlags P2) => default; // 0x000000018563A144-0x000000018563A24C
		public void __Gen_Wrap_81(object P0, object P1, InputDeviceFlags P2) {} // 0x0000000185E48B74-0x0000000185E48C6C
		public void __Gen_Wrap_82(object P0, InputDeviceFlags P1) {} // 0x000000018563E0E0-0x000000018563E1BC
		public string __Gen_Wrap_83(object P0, int P1) => default; // 0x00000001888B62A8-0x00000001888B63B4
		public bool __Gen_Wrap_84(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, out bool P3) {
			P3 = default;
			return default;
		} // 0x00000001888B63B4-0x00000001888B64DC
		public float __Gen_Wrap_85(object P0, object P1) => default; // 0x00000001854AB15C-0x00000001854AB248
		public void __Gen_Wrap_86(object P0, int P1, out string P2, out IBindingView P3) {
			P2 = default;
			P3 = default;
		} // 0x00000001888B64DC-0x00000001888B6654
		public PlayerActionInfo __Gen_Wrap_87(object P0, object P1) => default; // 0x00000001888B6654-0x00000001888B6760
		public bool __Gen_Wrap_88(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, bool P3, object P4) => default; // 0x00000001888B6760-0x00000001888B6884
		public bool __Gen_Wrap_89(object P0, object P1, GamepadKeyCode? P2, GamepadKeyCode? P3, bool P4, object P5) => default; // 0x00000001888B6884-0x00000001888B69F4
		public Vector3 __Gen_Wrap_90() => default; // 0x00000001888B69F4-0x00000001888B6AE8
		public void __Gen_Wrap_91(Vector2 P0, bool P1) {} // 0x00000001888B6AE8-0x00000001888B6BF0
		public void __Gen_Wrap_92(object P0, Vector2 P1) {} // 0x00000001888B6BF0-0x00000001888B6CF8
		public bool __Gen_Wrap_93(int P0) => default; // 0x000000018514DE88-0x000000018514DF54
		public List<Beyond.Input.InputManager.ControllerHintInfo> __Gen_Wrap_94(object P0) => default; // 0x00000001888B6CF8-0x00000001888B6DD4
		public void __Gen_Wrap_95(object P0, object P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3) {} // 0x00000001888B6DD4-0x00000001888B6F18
		public void __Gen_Wrap_96(object P0, int P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3) {} // 0x00000001888B6F18-0x00000001888B705C
		public void __Gen_Wrap_97(object P0, object P1, ref List<Beyond.Input.InputManager.ControllerHintInfo> P2) {} // 0x00000001888B705C-0x00000001888B718C
		public float __Gen_Wrap_98(object P0, object P1, out float P2) {
			P2 = default;
			return default;
		} // 0x00000001888B718C-0x00000001888B72B8
		public float __Gen_Wrap_99(object P0, int P1, out float P2) {
			P2 = default;
			return default;
		} // 0x00000001888B72B8-0x00000001888B73E4
		public void __Gen_Wrap_100(object P0, float P1, float P2) {} // 0x00000001854A1120-0x00000001854A1208
		public string __Gen_Wrap_101(System.Text.RegularExpressions.Match P0) => default; // 0x00000001888B3074-0x00000001888B3150
		public void __Gen_Wrap_102(object P0, object P1, object P2, bool P3) {} // 0x0000000185648770-0x0000000185648868
		public bool __Gen_Wrap_103(int P0, out Vector2 P1) {
			P1 = default;
			return default;
		} // 0x00000001888B3150-0x00000001888B327C
		public int __Gen_Wrap_104(object P0, object P1) => default; // 0x00000001850EF354-0x00000001850EF42C
		public List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>>> __Gen_Wrap_105(object P0) => default; // 0x00000001888B327C-0x00000001888B3358
		public void __Gen_Wrap_106(object P0, object P1, Beyond.Input.KeyboardKeyCode P2) {} // 0x000000018516413C-0x0000000185164220
		public void __Gen_Wrap_107(object P0, object P1, object P2, object P3) {} // 0x0000000185160E44-0x0000000185160F3C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 55692
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001888B73E4-0x00000001888B7478
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 55693
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001888B894C-0x00000001888B89B0
		public static bool IsPatched(int id) => default; // 0x00000001824AEDE0-0x00000001824AEE50
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001888B8808-0x00000001888B88D4
		public object CreateWrapper(int id) => default; // 0x00000001888B88D4-0x00000001888B894C
		public object InitWrapperArray(int len) => default; // 0x00000001888B89B0-0x0000000188933120
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001888B8764-0x00000001888B8808
	}

	public enum IDMAP0 // TypeDefIndex: 55694
	{
		Beyond-Input-ControllerNaviManager-SetNaviBindingType0 = 0,
		Beyond-Input-InputManager-ToggleGroup0 = 3,
		Beyond-Input-InputBindingGroup-SetSelfEnabled0 = 5,
		Beyond-Input-InputBindingGroup-_OnBindingGroupStateChanged0 = 8,
		Beyond-Input-InputBindingGroup-get_enabled0 = 9,
		Beyond-Input-InputBindingInfo-OnGroupEnabledChanged0 = 12,
		Beyond-Input-InputBindingInfo-_GetNextEnabledPriority0 = 16,
		Beyond-Input-InputBindingInfo-StopContinuousTrigger0 = 18,
		Beyond-Input-InputBindingGroup-OnParentEnabledChanged0 = 20,
		Beyond-Input-ControllerNaviManager-Tick0 = 22,
		Beyond-Input-ControllerNaviManager-UpdateNaviInputBindingState0 = 23,
		Beyond-Input-InputManager-IsGroupEnabled0 = 25,
		Beyond-Input-ControllerNaviManager-IsNavigationBindingEnabled0 = 26,
		Beyond-Input-ControllerNaviManager-_RemoveLayer0 = 27,
		Beyond-Input-ControllerNaviManager-_RemoveLayerFromStack0 = 28,
		Beyond-Input-ControllerNaviManager-_SetTarget0 = 29,
		Beyond-Input-ControllerNaviManager-_OnLayerSelected0 = 30,
		Beyond-Input-ControllerNaviManager-_DefaultNavigate0 = 31,
		Beyond-Input-ControllerNaviManager-GetNaviVector0 = 32,
		Beyond-Input-ControllerNaviManager-_GetPointOnRectEdge0 = 33,
		Beyond-Input-ControllerNaviManager-_TryFindBestNaviTarget0 = 34,
		Beyond-Input-ControllerNaviManager-_TryFindBestNaviTargetInGroup0 = 35,
		Beyond-Input-ControllerNaviManager-SetTarget0 = 36,
		Beyond-Input-ControllerNaviManager-SetForceEnableNavi0 = 37,
		Beyond-Input-ControllerNaviManager-TryRemoveLayer0 = 39,
		Beyond-Input-ControllerNaviManager-TryAutoSetTarget0 = 40,
		Beyond-Input-ControllerNaviManager-IsLayerInStack0 = 41,
		Beyond-Input-ControllerNaviManager-IsTopLayer0 = 42,
		Beyond-Input-ControllerNaviManager-ChangeAndTrySetNaviBindingType0 = 43,
		Beyond-Input-ControllerNaviManager-SetTargetInSilentModeIfNecessary0 = 44,
		Beyond-Input-ControllerNaviManager-IsNaviTarget0 = 45,
		Beyond-Input-ControllerNaviManager-Navigate0 = 46,
		Beyond-Input-ControllerNaviManager-ToggleNavigation0 = 47,
		Beyond-Input-GamepadCheckerBase-get_normalBindingInfos0 = 48,
		Beyond-Input-GamepadCheckerBase-get_modifyBindingInfos0 = 49,
		Beyond-Input-GamepadCheckerBase-OnCreateBinding0 = 50,
		Beyond-Input-GamepadCheckerBase-GetInputDic0 = 51,
		Beyond-Input-GamepadCheckerBase-OnDeleteBinding0 = 52,
		Beyond-Input-GamepadCheckerBase-CheckGamepadInput0 = 53,
		Beyond-Input-GamepadCheckerBase-CheckDic0 = 54,
		Beyond-Input-GamepadCheckerBase-TriggerActions0 = 55,
		Beyond-Input-InputBindingInfo-Trigger0 = 56,
		Beyond-Input-InputBindingInfo-_RealTriggerCallback0 = 57,
		Beyond-Input-InputBindingInfo-StartContinuousTrigger0 = 58,
		Beyond-Input-InputBindingInfo-_TryContinuousTrigger0 = 60,
		Beyond-Input-InputBindingInfo-get_enabled0 = 61,
		Beyond-Input-GamepadChecker-CheckDic0 = 65,
		Beyond-Input-GamepadOnClickChecker-CheckDic0 = 69,
		Beyond-Input-InputBindingInfo-get_bindingView0 = 70,
		Beyond-Input-InputBindingGroup-get_groupView0 = 72,
		Beyond-Input-GamepadOnClickChecker-ClearKeyPressed0 = 74,
		Beyond-Input-GamepadOnLongPressChecker-CreateTriggerBindingAction0 = 75,
		Beyond-Input-GamepadOnLongPressChecker-_OnTriggerBinding0 = 78,
		Beyond-Input-InputBindingInfo-get_text0 = 79,
		Beyond-Input-InputManager-GetActionText1 = 80,
		Beyond-Input-InputManager-GetPlayerActionInfo0 = 81,
		Beyond-Input-InputManager-GetActionText0 = 82,
		Beyond-Input-GamepadOnLongPressChecker-CheckDic0 = 83,
		Beyond-Input-GamepadOnLongPressChecker-OnCreateBinding0 = 84,
		Beyond-Input-GamepadOnLongPressChecker-OnDeleteBinding0 = 85,
		Beyond-Input-GamepadOnLongPressChecker-GetInputLongPressStartTime0 = 86,
		Beyond-Input-GamepadOnReleaseChecker-CheckGamepadInput0 = 88,
		Beyond-Input-GamepadOnReleaseChecker-CheckDic0 = 90,
		Beyond-Input-HGVirtualMouse-set_leftButtonAction0 = 91,
		Beyond-Input-HGVirtualMouse-_SetActionCallback0 = 92,
		Beyond-Input-HGVirtualMouse-_SetAction0 = 93,
		Beyond-Input-HGVirtualMouse-set_rightButtonAction0 = 94,
		Beyond-Input-HGVirtualMouse-set_middleButtonAction0 = 95,
		Beyond-Input-HGVirtualMouse-set_forwardButtonAction0 = 96,
		Beyond-Input-HGVirtualMouse-set_backButtonAction0 = 97,
		Beyond-Input-HGVirtualMouse-OnEnable0 = 98,
		Beyond-Input-HGVirtualMouse-SetMouseIconVisible0 = 99,
		Beyond-Input-HGVirtualMouse-_OnButtonActionTriggered0 = 102,
		Beyond-Input-InputManager-CreateGroup0 = 103,
		Beyond-Input-HGVirtualMouse-TriggerLeftButton0 = 105,
		Beyond-Input-InputManager-CreateBindingByActionId0 = 106,
		Beyond-Input-InputManager-_AddPlayerActionCheck2 = 107,
		Beyond-Input-InputManager-_AddPlayerActionCheck0 = 108,
		Beyond-Input-KeyboardCheckerBase-OnCreateBinding0 = 109,
		Beyond-Input-KeyboardCheckerBase-GetModifyIndex0 = 110,
		Beyond-Input-InputManager-_AddPlayerActionCheck1 = 111,
		Beyond-Input-HGVirtualMouse-ChangeHoverState0 = 113,
		Beyond-Input-HGVirtualMouse-_ChangeHoverState0 = 117,
		Beyond-Input-HGVirtualMouse-_SyncScale0 = 119,
		Beyond-Input-HGVirtualMouse-OnDisable0 = 120,
		Beyond-Input-HGVirtualMouse-_UpdateMotion0 = 121,
		Beyond-Input-HGVirtualMouse-ClearLeftButtonState0 = 122,
		Beyond-Input-HGVirtualMouse-OnAfterInputUpdate0 = 123,
		Beyond-Input-HGVirtualMouse-Update0 = 124,
		Beyond-Input-HGVirtualMouse-GetCurHoverSelectable0 = 126,
		Beyond-Input-HGVirtualMouse-OnDestroy0 = 127,
		Beyond-Input-InputManager-DeleteGroup0 = 128,
		Beyond-Input-InputManager-_DeleteGroup0 = 129,
		Beyond-Input-InputManager-_DeleteInGroup0 = 130,
		Beyond-Input-InputManager-_RealRemoveBindingInfo0 = 131,
		Beyond-Input-InputManager-_RemovePlayerActionCheck2 = 132,
		Beyond-Input-InputManager-_RemovePlayerActionCheck0 = 133,
		Beyond-Input-KeyboardCheckerBase-OnDeleteBinding0 = 134,
		Beyond-Input-InputManager-_RemovePlayerActionCheck1 = 135,
		Beyond-Input-InputBindingInfo-OnDelete0 = 136,
		Beyond-Input-HGVirtualMouse-Awake0 = 138,
		Beyond-Input-InputBindingInfo-ChangeGroup0 = 139,
		Beyond-Input-InputBindingInfo-SetSelfEnabled0 = 141,
		Beyond-Input-InputBindingInfo-SetParentIgnored0 = 143,
		Beyond-Input-InputBindingInfo-GetCallbackTarget0 = 145,
		Beyond-Input-InputBindingGroup-ChangeParent0 = 146,
		Beyond-Input-InputBindingGroup-SetParentIgnored0 = 148,
		Beyond-Input-InputBindingGroupMonoTarget-get_groupEnabled0 = 150,
		Beyond-Input-InputBindingGroupMonoTarget-Init0 = 151,
		Beyond-Input-InputBindingGroupMonoTarget-UpdateState0 = 154,
		Beyond-Input-InputBindingGroupMonoTarget-DeleteGroup0 = 155,
		Beyond-Input-InputBindingGroupMonoTarget-Awake0 = 156,
		Beyond-Input-InputBindingGroupMonoTarget-OnEnable0 = 157,
		Beyond-Input-InputBindingGroupMonoTarget-OnDisable0 = 158,
		Beyond-Input-InputBindingGroupMonoTarget-OnDestroy0 = 159,
		Beyond-Input-InputManager-get_cursorVisible0 = 160,
		Beyond-Input-InputManager-get_mouseScrollDelta0 = 163,
		Beyond-Input-InputManager-GetGamepadStickValue0 = 164,
		Beyond-Input-InputManager-get_multiTouchEnabled0 = 166,
		Beyond-Input-InputManager-set_multiTouchEnabled0 = 167,
		Beyond-Input-InputManager-set_usingController0 = 168,
		Beyond-Input-InputManager-_TryChangeInputDeviceType0 = 169,
		Beyond-Input-InputManager-ChangeInputTypeAndSyncState0 = 170,
		Beyond-Input-InputManager-_SyncUsingControllerState0 = 171,
		Beyond-Input-InputManager-_CheckVirtualMouseState0 = 173,
		Beyond-Input-InputManager-_ToggleVirtualMouse0 = 174,
		Beyond-Input-RealCursorManager-SetForceHideCursorForController0 = 177,
		Beyond-Input-RealCursorManager-CalcState0 = 180,
		Beyond-Input-RealCursorManager-_ToggleCursorInternal0 = 183,
		Beyond-Input-RealCursorManager-IsNeedShowCursor0 = 186,
		Beyond-Input-InputManager-_RefreshDeviceChangeBinding0 = 187,
		Beyond-Input-InputManager-ToggleBinding0 = 188,
		Beyond-Input-InputManager-ToggleCursorInHideCursorMode0 = 189,
		Beyond-Input-RealCursorManager-ToggleCursorInHideCursorMode0 = 190,
		Beyond-Input-InputManager-get_action2BindingDic0 = 191,
		Beyond-Input-InputManager-LateTick0 = 192,
		Beyond-Input-InputManager-_UpdateControllerIndicator0 = 193,
		Beyond-Input-InputManager-TryClickSkillButtonWhenControllerIndicatorJustRelease0 = 194,
		Beyond-Input-InputManager-_Init0 = 195,
		Beyond-Input-InputManager-_CreateTickFunction0 = 196,
		Beyond-Input-KeyboardOnClickChecker-ClearKeyPressed0 = 198,
		Beyond-Input-InputManager-_LoadSetting0 = 200,
		Beyond-Input-InputManager-_LoadCustomInputSetting0 = 201,
		Beyond-Input-InputManager-_OnControllerConnected0 = 202,
		Beyond-Input-InputManager-_SetJoystick0 = 204,
		Beyond-Input-InputManager-_GetControllerType0 = 209,
		Beyond-Input-InputManager-_OnControllerDisconnected0 = 210,
		Beyond-Input-InputManager-_TryFindGamepad0 = 211,
		Beyond-Input-InputManager-_CreateCanvas0 = 212,
		Beyond-Input-InputManager-_CreateDebugVirtualMouse0 = 217,
		Beyond-Input-InputManager-_CreateVirtualMouse0 = 220,
		Beyond-Input-InputManager-GetKeyIconPath0 = 227,
		Beyond-Input-InputManager-GetStringByGamepadKeyCode0 = 228,
		Beyond-Input-InputManager-GetGamepadKeyIconPath0 = 229,
		Beyond-Input-InputManager-_GetGamepadKeyIconFolderPath0 = 230,
		Beyond-Input-InputManager-_GetKeyIconPath0 = 231,
		Beyond-Input-InputManager-GetKeyIconPath2 = 232,
		Beyond-Input-InputManager-GetKeyIconPath1 = 233,
		Beyond-Input-InputManager-GetStringByKeyboardKeyCode0 = 234,
		Beyond-Input-InputManager-_InitDeviceChangeBinding0 = 235,
		Beyond-Input-InputManager-_OnAfterInputUpdate0 = 238,
		Beyond-Input-InputManager-KeyCaches-UpdateKeyStat0 = 239,
		Beyond-Input-InputManager-_CheckInput0 = 240,
		Beyond-Input-InputManager-CheckUsingController0 = 241,
		Beyond-Input-InputManager-AnyGamepadKey0 = 242,
		Beyond-Input-InputManager-GetGamepadTriggerValue0 = 243,
		Beyond-Input-InputManager-_CheckAnyKeyForTouchChangeDevice0 = 244,
		Beyond-Input-InputManager-_CheckAnyKeyForKeyboardChangeDevice0 = 245,
		Beyond-Input-InputManager-AnyMouseKeyUp0 = 246,
		Beyond-Input-InputManager-_AnyKeyDownForKeyboardChangeDevice0 = 247,
		Beyond-Input-KeyboardCheckerBase-CheckKeyboardInput0 = 248,
		Beyond-Input-KeyboardCheckerBase-TriggerActions0 = 249,
		Beyond-Input-InputManager-_ControllerTouchPanelTick0 = 250,
		Beyond-Input-InputManager-_OnNetMaskChanged0 = 253,
		Beyond-Input-InputManager-_OnFocusedInputFieldChanged0 = 254,
		Beyond-Input-InputManager-Release0 = 255,
		Beyond-Input-InputManager-_ClearTickFunction0 = 256,
		Beyond-Input-InputManager-OnApplicationQuit0 = 257,
		Beyond-Input-InputManager-_ClearEvents0 = 258,
		Beyond-Input-InputManager-OnApplicationFocus0 = 259,
		Beyond-Input-InputManager-ToggleInputDeviceChangeMode0 = 260,
		Beyond-Input-InputManager-ResetCursorInHideCursorMode0 = 262,
		Beyond-Input-RealCursorManager-ResetCursorInHideCursorMode0 = 263,
		Beyond-Input-InputManager-ToggleForceShowRealCursor0 = 264,
		Beyond-Input-RealCursorManager-ToggleForceShowRealCursorForChangeInput0 = 265,
		Beyond-Input-InputManager-AnyKeyboardKey0 = 267,
		Beyond-Input-InputManager-_AnyKeyboardKey0 = 268,
		Beyond-Input-InputManager-AnyMouseKeyDown0 = 269,
		Beyond-Input-InputManager-AnyMouseKey0 = 270,
		Beyond-Input-InputManager-AnyKeyDown0 = 271,
		Beyond-Input-InputManager-_CheckGamepadKeyCode0 = 272,
		Beyond-Input-InputManager-CreateBinding1 = 273,
		Beyond-Input-InputManager-AddAnonymousPlayerAction0 = 274,
		Beyond-Input-InputManager-CreateBinding0 = 275,
		Beyond-Input-InputManager-CreateBinding2 = 276,
		Beyond-Input-InputManager-DeleteBinding0 = 277,
		Beyond-Input-InputManager-DeleteInGroup0 = 278,
		Beyond-Input-InputManager-IsBindingEnabled0 = 279,
		Beyond-Input-InputManager-ForceBindingKeyhintToGray0 = 280,
		Beyond-Input-InputManager-IsBindingKeyhintGray0 = 281,
		Beyond-Input-InputManager-ToggleHideCursor0 = 282,
		Beyond-Input-RealCursorManager-SetDebugShowCursorMode0 = 283,
		Beyond-Input-InputManager-ToggleAllInput0 = 285,
		Beyond-Input-InputManager-SetBindingView0 = 286,
		Beyond-Input-InputManager-SetGroupView0 = 287,
		Beyond-Input-InputManager-ChangeParent0 = 288,
		Beyond-Input-InputManager-GetGroupParentId0 = 289,
		Beyond-Input-InputManager-IgnoreBindingGroupParent0 = 290,
		Beyond-Input-InputManager-IgnoreBindingParent0 = 291,
		Beyond-Input-InputManager-GetActionKeyboardKeyCode0 = 292,
		Beyond-Input-InputManager-GetActionGamepadKeyCode0 = 293,
		Beyond-Input-InputManager-DeleteCustomBinding0 = 294,
		Beyond-Input-PlayerActionInfo-DeviceInputEquals0 = 295,
		Beyond-Input-InputUtils-HasFlag0 = 296,
		Beyond-Input-PlayerActionInfo-DeviceInputCopyFrom0 = 297,
		Beyond-Input-InputManager-DeleteAllCustomBindings0 = 298,
		Beyond-Input-InputManager-_RefreshControllerBattleButton0 = 299,
		Beyond-Input-InputManager-SetBindingText0 = 300,
		Beyond-Input-InputManager-GetBindingText0 = 301,
		Beyond-Input-InputManager-HasBinding0 = 302,
		Beyond-Input-InputManager-CheckActionKeyCodeConflict0 = 303,
		Beyond-Input-InputManager-GetAxis0 = 304,
		Beyond-Input-InputManager-GetBindingInfo0 = 305,
		Beyond-Input-InputManager-LoadSetting0 = 306,
		Beyond-Input-InputManager-IsPlayerActionIdValid0 = 307,
		Beyond-Input-InputManager-ChangePlayerAction0 = 308,
		Beyond-Input-InputManager-_GetOrCreatePendingActionInfo0 = 309,
		Beyond-Input-InputManager-CustomizeActionKey0 = 310,
		Beyond-Input-InputManager-CustomizeActionKey1 = 311,
		Beyond-Input-InputManager-ClearPendingInputSetting0 = 312,
		Beyond-Input-InputManager-SaveCustomInputSetting0 = 313,
		Beyond-Input-InputManager-GetMousePos0 = 314,
		Beyond-Input-InputManager-SetOnlyVirtualMousePos0 = 316,
		Beyond-Input-InputManager-SetMousePos0 = 317,
		Beyond-Input-InputManager-SetVirtualMouseIconVisible0 = 318,
		Beyond-Input-InputManager-GetMouseButton0 = 319,
		Beyond-Input-InputManager-IsLeftMouseDown0 = 320,
		Beyond-Input-InputManager-GetMouseButtonDown0 = 321,
		Beyond-Input-InputManager-GetMouseButtonUp0 = 322,
		Beyond-Input-InputManager-SetCustomControllerMouse0 = 323,
		Beyond-Input-InputManager-GetEmptyControllerHintInfoList0 = 326,
		Beyond-Input-InputManager-GetControllerHintInfos0 = 327,
		Beyond-Input-InputManager-_GetControllerHintInfos0 = 328,
		Beyond-Input-InputManager-ControllerHintInfo-Reset0 = 330,
		Beyond-Input-InputManager-GetControllerHintInfos1 = 332,
		Beyond-Input-InputManager-_GetControllerHintInfos1 = 333,
		Beyond-Input-InputManager-ControllerHintInfo-Reset1 = 334,
		Beyond-Input-InputManager-GetPlayerActionLongPressStartTime0 = 335,
		Beyond-Input-KeyboardOnLongPressChecker-GetInputLongPressStartTime0 = 336,
		Beyond-Input-InputManager-GetActionBindingLongPressStartTime0 = 337,
		Beyond-Input-InputManager-GetControllerIndicatorState0 = 338,
		Beyond-Input-InputManager-CheckNormalAttackBtn0 = 339,
		Beyond-Input-InputManager-TryPressControllerIndicatorWhenSkillButtonJustPressed0 = 340,
		Beyond-Input-InputManager-AddGuideUseActionId0 = 341,
		Beyond-Input-InputManager-RemoveGuideUseActionId0 = 342,
		Beyond-Input-InputManager-ClearGuideUseActionIds0 = 343,
		Beyond-Input-InputManager-VibrateController0 = 344,
		Beyond-Input-InputManager-ParseTextActionId0 = 345,
		Beyond-Input-InputManager-MoveMouseTo0 = 346,
		Beyond-Input-InputManager-MoveVirtualMouseTo0 = 347,
		Beyond-Input-InputManager-GetTouchId0 = 348,
		Beyond-Input-InputManager-GetPressPosByTouchId0 = 349,
		Beyond-Input-InputManager-Dispose0 = 350,
		Beyond-Input-InputManager-RemoveUnusedInput0 = 351,
		Beyond-Input-InputManager-GetCurJsInfos0 = 352,
		Beyond-Input-InputManager-ControllerHintInfo-CompareTo0 = 353,
		Beyond-Input-InputManager-ControllerHintInfo-OnAllocate0 = 354,
		Beyond-Input-InputManager-ControllerHintInfo-OnRecycle0 = 355,
		Beyond-Input-InputUtils-IgnoreBindingParent0 = 356,
		Beyond-Input-InputUtils-IgnoreBindingGroupParent0 = 357,
		Beyond-Input-KeyboardCheckerBase-get_bindingInfos0 = 358,
		Beyond-Input-KeyboardChecker-CheckKeyboardInput0 = 359,
		Beyond-Input-KeyboardChecker-TriggerActions0 = 361,
		Beyond-Input-KeyboardOnClickChecker-CheckKeyboardInput0 = 362,
		Beyond-Input-KeyboardOnClickChecker-TriggerActions0 = 363,
		Beyond-Input-KeyboardOnLongPressChecker-CheckKeyboardInput0 = 364,
		Beyond-Input-KeyboardOnLongPressChecker-_OnTriggerBinding0 = 367,
		Beyond-Input-KeyboardOnLongPressChecker-OnCreateBinding0 = 368,
		Beyond-Input-KeyboardOnLongPressChecker-OnDeleteBinding0 = 369,
		Beyond-Input-PlayerActionInfo-ResetHintProority0 = 370,
		Beyond-Input-KeyboardInput-GetModifyText0 = 371,
		Beyond-Input-KeyboardInput-GetKeyCodeText0 = 372,
		Beyond-Input-KeyboardInput-GetKeyCodeEnumIntValue0 = 373,
		Beyond-Input-KeyboardInput-SetKeyCodeEnumByIntValue0 = 374,
		Beyond-Input-KeyboardInput-get_modifyString0 = 375,
		Beyond-Input-KeyboardInput-ClearKeyCode0 = 376,
		Beyond-Input-KeyboardInput-IsValid0 = 377,
		Beyond-Input-KeyboardInput-CopyFrom0 = 378,
		Beyond-Input-KeyboardInput-Equals0 = 379,
		Beyond-Input-GamepadInput-GetModifyText0 = 380,
		Beyond-Input-GamepadInput-GetKeyCodeText0 = 381,
		Beyond-Input-GamepadInput-GetKeyCodeEnumIntValue0 = 382,
		Beyond-Input-GamepadInput-SetKeyCodeEnumByIntValue0 = 383,
		Beyond-Input-GamepadInput-ClearKeyCode0 = 384,
		Beyond-Input-GamepadInput-IsValid0 = 385,
		Beyond-Input-GamepadInput-CopyFrom0 = 386,
		Beyond-Input-GamepadInput-Equals0 = 387,
		Beyond-Input-UIEvent-get_bindingEnabled0 = 388,
		Beyond-Input-UIEvent-_CreatePlayerActionBinding0 = 390,
		Beyond-Input-UIEvent-InitBinding0 = 393,
		Beyond-Input-UIEvent-Invoke0 = 395,
		Beyond-Input-UIEvent-UpdateKeys0 = 396,
		Beyond-Input-UIEvent-ChangeBindingPlayerAction0 = 397,
		Beyond-Input-UIEvent-AddListener0 = 398,
		Beyond-Input-UIEvent-RemoveListener0 = 399,
		Beyond-Input-UIEvent-RemoveAllListeners0 = 400
	}
}

namespace UnityEngine.InputSystem.UI
{
	[AddComponentMenu("Input/Debug Virtual Mouse")]
	public class DebugVirtualMouseInput : MonoBehaviour // TypeDefIndex: 55626
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
		public RectTransform cursorTransform { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public float cursorSpeed { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public CursorMode cursorMode { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x00000001888AB968-0x00000001888ABA4C
		public Graphic cursorGraphic { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x00000001888AB944-0x00000001888AB968
		public float scrollSpeed { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public UnityEngine.InputSystem.Mouse virtualMouse { get => default; } // 0x0000000183D51950-0x0000000183D51960 
		public InputActionProperty stickAction { get => default; set {} } // 0x0000000183D5D670-0x0000000183D5D690 0x00000001888ABD44-0x00000001888ABD74
		public InputActionProperty leftButtonAction { get => default; set {} } // 0x0000000183D5D690-0x0000000183D5D6B0 0x00000001888ABB04-0x00000001888ABBAC
		public InputActionProperty rightButtonAction { get => default; set {} } // 0x0000000183D68BE0-0x0000000183D68C00 0x00000001888ABC5C-0x00000001888ABD14
		public InputActionProperty middleButtonAction { get => default; set {} } // 0x0000000183D6DB80-0x0000000183D6DBA0 0x00000001888ABBAC-0x00000001888ABC5C
		public InputActionProperty forwardButtonAction { get => default; set {} } // 0x0000000183D6DB60-0x0000000183D6DB80 0x00000001888ABA4C-0x00000001888ABB04
		public InputActionProperty backButtonAction { get => default; set {} } // 0x0000000183D6DB40-0x0000000183D6DB60 0x00000001888AB88C-0x00000001888AB944
		public InputActionProperty scrollWheelAction { get => default; set {} } // 0x0000000183D6DBA0-0x0000000183D6DBC0 0x00000001888ABD14-0x00000001888ABD44
	
		// Nested types
		public enum CursorMode // TypeDefIndex: 55625
		{
			SoftwareCursor = 0,
			HardwareCursorIfAvailable = 1
		}
	
		// Constructors
		public DebugVirtualMouseInput() {} // 0x0000000183D42B50-0x0000000183D42B70
	
		// Methods
		protected void OnEnable() {} // 0x00000001888AA980-0x00000001888AADA8
		protected void OnDisable() {} // 0x00000001888AA6E4-0x00000001888AA980
		private void _TryFindCanvas() {} // 0x00000001888AB43C-0x00000001888AB498
		private void _TryEnableHardwareCursor() {} // 0x00000001888AB244-0x00000001888AB43C
		private void _SyncScale() {} // 0x00000001888AB144-0x00000001888AB244
		private void _UpdateMotion() {} // 0x00000001888AB498-0x00000001888AB88C
		private void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) {} // 0x00000001888AADB0-0x00000001888AAFE0
		private static void _SetActionCallback(InputActionProperty field, Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x01FD6FAB */) {} // 0x00000001888AAFE0-0x00000001888AB04C
		private static void _SetAction(ref InputActionProperty field, InputActionProperty value) {} // 0x00000001888AB04C-0x00000001888AB144
		private void _OnAfterInputUpdate() {} // 0x00000001888AADA8-0x00000001888AADB0
	}
}
