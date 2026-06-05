/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine.UI;

// Image 39: Input.Beyond.dll - Assembly: Input.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56357-56435

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 56431
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_32 E680B0AF74F1D11AFCE59DFB222E2F946D48C66AE24640EE35784361EEA2E0C4; // 0x00 // Static value (base64): BwAAAAMAAAAFAAAABgAAAAEAAAACAAAABAAAAAAAAAA= - Metadata: 0x0207CB3C

	// Nested types
	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 56430
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond.Input
{
	public class ControllerNaviManager // TypeDefIndex: 56366
	{
		// Fields
		public LinkedList<SelectableNaviGroup> layerStackList; // 0x10
		public Selectable curTarget; // 0x18
		private readonly HashSet<string> m_naviLockSet; // 0x20
		private int m_targetInputBindingGroupId; // 0x28
		private int m_naviInputBindingGroupId; // 0x2C
		private Selectable m_lastEnableNaviTarget; // 0x30
		private NavigationBindingType _navigationBindingType_k__BackingField; // 0x38
		private Dictionary<NavigationBindingType, int> m_naviBindingGroupIds; // 0x40
		private Beyond.Input.InputManager m_inputManager; // 0x48
		private const float SCORE_OFFSET = 10000f; // Metadata: 0x0207C7AC
		private bool _forceEnableNaviForGuide_k__BackingField; // 0x50
	
		// Properties
		public NavigationBindingType navigationBindingType { get; private set; } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public bool forceEnableNaviForGuide { get; private set; } // 0x00000001813ECBE0-0x00000001813ECBF0 0x00000001813EE9A0-0x00000001813EE9B0
	
		// Constructors
		public ControllerNaviManager() {} // Dummy constructor
		public ControllerNaviManager(Beyond.Input.InputManager inputManager) {} // 0x00000001856308B0-0x00000001856319F0
	
		// Methods
		public void SetNaviBindingType(NavigationBindingType bindingType) {} // 0x00000001856319F0-0x0000000185631BC0
		public void Tick() {} // 0x0000000184331D90-0x0000000184331E10
		private bool _RemoveLayer(SelectableNaviGroup group, SelectableNaviGroup curLayer) => default; // 0x000000018422C7E0-0x000000018422CA70
		private void _RemoveLayerFromStack(SelectableNaviGroup group, bool silentMode) {} // 0x000000018422CD10-0x000000018422CDA0
		private void _SetTarget(Selectable target) {} // 0x0000000185C58240-0x0000000185C58300
		private void _OnLayerSelected(SelectableNaviGroup topLayer) {} // 0x000000018A9BB3FC-0x000000018A9BB628
		private bool _DefaultNavigate(NaviDirection dir) => default; // 0x000000018A9BA7E4-0x000000018A9BB1F4
		private Selectable _TryFindBestNaviTargetInGroup(SelectableNaviGroup group, Vector3 pos, Vector3 dir, double curMaxScore, out double maxScore) {
			maxScore = default;
			return default;
		} // 0x000000018A9BB628-0x000000018A9BB9CC
		private Selectable _TryFindBestNaviTarget(HashSet<Selectable> targets, Vector3 curPos, Vector3 dir, NaviStrategy strategy, double curMaxScore, out double maxScore) {
			maxScore = default;
			return default;
		} // 0x000000018A9BB9CC-0x000000018A9BC124
		private static Vector3 _GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir) => default; // 0x000000018A9BB1F4-0x000000018A9BB3FC
		private LinkedListNode<SelectableNaviGroup> _GetDummyLayerLastGroupInStack(SelectableNaviGroup dummyLayer) => default; // 0x0000000183A288D0-0x0000000183A297C0
		public void SetForceEnableNavi(bool enable) {} // 0x000000018A9BA538-0x000000018A9BA5BC
		public void UpdateNaviInputBindingState() {} // 0x00000001843300D0-0x0000000184330340
		public bool IsNavigationBindingEnabled() => default; // 0x00000001843304D0-0x0000000184330560
		public void TryRemoveLayer(SelectableNaviGroup group) {} // 0x000000018422AD90-0x000000018422C280
		public bool IsLayerInStack(SelectableNaviGroup group) => default; // 0x000000018422CCA0-0x000000018422CD10
		public bool IsTopLayer(SelectableNaviGroup group) => default; // 0x000000018A9BA2B4-0x000000018A9BA3B0
		public void ChangeAndTrySetNaviBindingType(SelectableNaviGroup naviGroup, NavigationBindingType naviBindingType) {} // 0x00000001857E6B60-0x00000001857E6BC0
		public void TryAutoSetTarget() {} // 0x000000018A9BA6B4-0x000000018A9BA7A4
		public SelectableNaviGroup GetTopDummyLayerGroup() => default; // 0x0000000183A258F0-0x0000000183A26760
		public void SetTarget(Selectable target) {} // 0x0000000185C581F0-0x0000000185C58240
		public void ResetStateForUIDispose() {} // 0x0000000183A26760-0x0000000183A273F0
		public void SetTargetInSilentModeIfNecessary(SelectableNaviGroup naviGroup, Selectable selectable, SelectableNaviGroup needTopDummyGroup = null) {} // 0x0000000183A273F0-0x0000000183A288D0
		public bool IsNaviTarget(Selectable target) => default; // 0x000000018A9BA228-0x000000018A9BA2B4
		public Vector3 GetNaviVector(NaviDirection dir) => default; // 0x000000018A9BA0D4-0x000000018A9BA228
		public void Navigate(NaviDirection dir) {} // 0x000000018A9BA3B0-0x000000018A9BA538
		public void ToggleNavigation(string key, bool active) {} // 0x000000018A9BA5BC-0x000000018A9BA6B4
		private void _.ctor_b__12_0() {} // 0x000000018A9BA7A4-0x000000018A9BA7B4
		private void _.ctor_b__12_1() {} // 0x000000018A9BA7D4-0x000000018A9BA7E4
		private void _.ctor_b__12_2() {} // 0x000000018A9BA7B4-0x000000018A9BA7C4
		private void _.ctor_b__12_3() {} // 0x000000018A9BA7C4-0x000000018A9BA7D4
		private void _.ctor_b__12_4() {} // 0x000000018A9BA7B4-0x000000018A9BA7C4
		private void _.ctor_b__12_5() {} // 0x000000018A9BA7C4-0x000000018A9BA7D4
		private void _.ctor_b__12_6() {} // 0x000000018A9BA7A4-0x000000018A9BA7B4
		private void _.ctor_b__12_7() {} // 0x000000018A9BA7D4-0x000000018A9BA7E4
		private void _.ctor_b__12_8() {} // 0x000000018A9BA7A4-0x000000018A9BA7B4
		private void _.ctor_b__12_9() {} // 0x000000018A9BA7D4-0x000000018A9BA7E4
		private void _.ctor_b__12_10() {} // 0x000000018A9BA7B4-0x000000018A9BA7C4
		private void _.ctor_b__12_11() {} // 0x000000018A9BA7C4-0x000000018A9BA7D4
		private void _.ctor_b__12_12() {} // 0x000000018A9BA7B4-0x000000018A9BA7C4
		private void _.ctor_b__12_13() {} // 0x000000018A9BA7C4-0x000000018A9BA7D4
		private void _.ctor_b__12_14() {} // 0x000000018A9BA7A4-0x000000018A9BA7B4
		private void _.ctor_b__12_15() {} // 0x000000018A9BA7D4-0x000000018A9BA7E4
		private void _.ctor_b__12_16() {} // 0x000000018A9BA7A4-0x000000018A9BA7B4
		private void _.ctor_b__12_17() {} // 0x000000018A9BA7D4-0x000000018A9BA7E4
		private void _.ctor_b__12_18() {} // 0x000000018A9BA7B4-0x000000018A9BA7C4
		private void _.ctor_b__12_19() {} // 0x000000018A9BA7C4-0x000000018A9BA7D4
		private void _.ctor_b__12_20() {} // 0x000000018A9BA7B4-0x000000018A9BA7C4
		private void _.ctor_b__12_21() {} // 0x000000018A9BA7C4-0x000000018A9BA7D4
		private void _.ctor_b__12_22() {} // 0x000000018A9BA7A4-0x000000018A9BA7B4
		private void _.ctor_b__12_23() {} // 0x000000018A9BA7D4-0x000000018A9BA7E4
		private void _.ctor_b__12_24() {} // 0x000000018A9BA7A4-0x000000018A9BA7B4
		private void _.ctor_b__12_25() {} // 0x000000018A9BA7D4-0x000000018A9BA7E4
		private void _.ctor_b__12_26() {} // 0x000000018A9BA7B4-0x000000018A9BA7C4
		private void _.ctor_b__12_27() {} // 0x000000018A9BA7C4-0x000000018A9BA7D4
		private void _.ctor_b__12_28() {} // 0x000000018A9BA7B4-0x000000018A9BA7C4
		private void _.ctor_b__12_29() {} // 0x000000018A9BA7C4-0x000000018A9BA7D4
		private void _.ctor_b__12_30() {} // 0x000000018A9BA7A4-0x000000018A9BA7B4
		private void _.ctor_b__12_31() {} // 0x000000018A9BA7D4-0x000000018A9BA7E4
	}

	public enum ActionOnSetNaviTarget // TypeDefIndex: 56367
	{
		None = 0,
		AutoTriggerOnClick = 1,
		PressConfirmTriggerOnClick = 2
	}

	public static class ControllerNaviUtils // TypeDefIndex: 56368
	{
	}

	public class PSTriggerEffectCfg : MonoBehaviour // TypeDefIndex: 56369
	{
		// Fields
		public List<TriggerEffectCommandUnion> commands; // 0x18
	
		// Constructors
		public PSTriggerEffectCfg() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public enum KeyboardKeyCode // TypeDefIndex: 56370
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

	public enum GamepadKeyCode // TypeDefIndex: 56371
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

	public enum InputTimingType // TypeDefIndex: 56372
	{
		OnPress = 0,
		OnRelease = 1,
		OnClick = 2,
		OnLongPress = 3
	}

	public enum InputContinuousTriggerType // TypeDefIndex: 56373
	{
		NormalDelayAndLoopTime = 0,
		EveryTick = 1
	}

	public enum KeyboardType // TypeDefIndex: 56374
	{
		None = 0,
		Default = 1,
		QWERTZ = 2,
		AZERTY = 3
	}

	internal abstract class GamepadCheckerBase // TypeDefIndex: 56377
	{
		// Fields
		protected Beyond.Input.InputManager m_inputManager; // 0x10
		protected DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> m_normalBindingInfos; // 0x18
		protected DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>>> m_modifyBindingInfos; // 0x20
		protected HashSet<GamepadKeyCode> m_usedKeyCache; // 0x28
		protected List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x30
	
		// Properties
		internal DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> normalBindingInfos { get; } // 0x000000018A9BDBBC-0x000000018A9BDC08 
		internal DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>>> modifyBindingInfos { get; } // 0x00000001859060E0-0x0000000185906290 
	
		// Nested types
		public class Binding // TypeDefIndex: 56375
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
			public Binding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0207C8E0 */) {} // 0x000000018A9BDC08-0x000000018A9BDC54
		}
	
		public enum TriggerType // TypeDefIndex: 56376
		{
			NORMAL = 0,
			CONTINUOUS = 1,
			STOP_CONTINUOUS = 2
		}
	
		// Constructors
		protected GamepadCheckerBase() {} // Dummy constructor
		internal GamepadCheckerBase(Beyond.Input.InputManager inputManager) {} // 0x0000000183FE6C70-0x0000000183FE6E50
	
		// Methods
		public virtual Binding OnCreateBinding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0207C8DF */) => default; // 0x0000000183FE6640-0x0000000183FE6920
		public virtual Binding OnDeleteBinding(GamepadInput input, InputBindingInfo info) => default; // 0x0000000183FE6E50-0x0000000183FE6F70
		protected DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> GetInputDic(GamepadInput input) => default; // 0x000000018A9BD818-0x000000018A9BD95C
		public virtual void CheckGamepadInput() {} // 0x000000018A9BD7B4-0x000000018A9BD818
		protected virtual void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x000000018A9BD95C-0x000000018A9BDBBC
		public virtual void TriggerActions() {} // 0x0000000183FE6F70-0x0000000183FE7050
	}

	internal class GamepadChecker : GamepadCheckerBase // TypeDefIndex: 56378
	{
		// Fields
		private Func<GamepadKeyCode, bool> m_checkFunc; // 0x38
		private bool _isPressChecker_k__BackingField; // 0x40
	
		// Properties
		public bool isPressChecker { get; private set; } // 0x0000000185FB0650-0x0000000185FB0660 0x0000000185FB0660-0x0000000185FB0670
	
		// Constructors
		public GamepadChecker() {} // Dummy constructor
		public GamepadChecker(Func<GamepadKeyCode, bool> checkFunc, bool isPress, Beyond.Input.InputManager inputManager) {} // 0x0000000185906090-0x00000001859060E0
	
		// Methods
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x000000018A9BDC54-0x000000018A9BE2C0
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1) {} // 0x000000018A9BE2C0-0x000000018A9BE2C8
	}

	internal class GamepadOnClickChecker : GamepadCheckerBase // TypeDefIndex: 56379
	{
		// Constructors
		public GamepadOnClickChecker() {} // Dummy constructor
		internal GamepadOnClickChecker(Beyond.Input.InputManager inputManager) {} // 0x000000018A9BEE54-0x000000018A9BEE5C
	
		// Methods
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x000000018A9BE2C8-0x000000018A9BEA2C
		public void ClearKeyPressed(GamepadKeyCode keyCode) {} // 0x000000018A9BEA2C-0x000000018A9BEE54
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1) {} // 0x000000018A9BE2C0-0x000000018A9BE2C8
	}

	internal class GamepadOnLongPressChecker : GamepadCheckerBase // TypeDefIndex: 56381
	{
		// Fields
		private Action<GamepadKeyCode> m_onTriggerOnLongPress; // 0x38
		private Dictionary<GamepadInput, HashSet<Binding>> m_bindings; // 0x40
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 56380
		{
			// Fields
			public GamepadOnLongPressChecker __4__this; // 0x10
			public GamepadCheckerBase.Binding binding; // 0x18
			public GamepadKeyCode keyCode; // 0x20
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x0000000185905F30-0x0000000185905FE0
	
			// Methods
			internal void _CreateTriggerBindingAction_b__0() {} // 0x000000018A9BF584-0x000000018A9BF684
		}
	
		// Constructors
		public GamepadOnLongPressChecker() {} // Dummy constructor
		public GamepadOnLongPressChecker(Action<GamepadKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager) {} // 0x000000018A9BEE5C-0x000000018A9BF584
	
		// Methods
		public Action CreateTriggerBindingAction(Binding binding, GamepadKeyCode keyCode) => default; // 0x000000018A9BF8A8-0x000000018A9BFC8C
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x00000001857F10B0-0x00000001857F1210
		private void _OnTriggerBinding(Binding binding, GamepadKeyCode keyCode) {} // 0x00000001857F0FD0-0x00000001857F10B0
		public override Binding OnCreateBinding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0207C8E4 */) => default; // 0x0000000183A297C0-0x0000000183A2B0E0
		public override Binding OnDeleteBinding(GamepadInput input, InputBindingInfo info) => default; // 0x000000018A9BF684-0x000000018A9BF890
		public void CancelPendingLongPress(InputBindingInfo info) {} // 0x000000018A9BE2C0-0x000000018A9BE2C8
		public float GetInputLongPressStartTime(GamepadInput input, int bindingId = 0 /* Metadata: 0x0207C8E5 */) => default; // 0x000000018A9BF890-0x000000018A9BF8A0
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1) {} // 0x000000018A9BF8A0-0x000000018A9BF8A8
		public Binding __iFixBaseProxy_OnCreateBinding(GamepadInput P0, InputBindingInfo P1, bool P2) => default; // 0x0000000185492010-0x0000000185492020
		public Binding __iFixBaseProxy_OnDeleteBinding(GamepadInput P0, InputBindingInfo P1) => default; // 0x000000018A9C445C-0x000000018A9C4488
	}

	internal class GamepadOnReleaseChecker : GamepadCheckerBase // TypeDefIndex: 56382
	{
		// Fields
		private readonly Func<GamepadKeyCode, bool> m_checkFunc; // 0x38
		private readonly Dictionary<GamepadKeyCode, HashSet<GamepadKeyCode>> m_modifyBindingPressedDic; // 0x40
	
		// Constructors
		public GamepadOnReleaseChecker() {} // Dummy constructor
		public GamepadOnReleaseChecker(Func<GamepadKeyCode, bool> checkFunc, Beyond.Input.InputManager inputManager) {} // 0x0000000185905FE0-0x0000000185906090
	
		// Methods
		public override void CheckGamepadInput() {} // 0x000000018A9C0318-0x000000018A9C09FC
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey) {} // 0x000000018A9BFC8C-0x000000018A9C0318
		private bool _CheckGamepadInput_b__3_0(GamepadKeyCode keyCode) => default; // 0x000000018A9C09FC-0x000000018A9C0A24
		public void __iFixBaseProxy_CheckGamepadInput() {} // 0x000000018A9C0A24-0x000000018A9C0A2C
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1) {} // 0x000000018A9BE2C0-0x000000018A9BE2C8
	}

	public class HGVirtualMouse : MonoBehaviour // TypeDefIndex: 56385
	{
		// Fields
		private const float STANDARD_SCREEN_WIDTH = 1920f; // Metadata: 0x0207C8E7
		public bool keepMousePosOnEnable; // 0x18
		private RectTransform m_CursorTransform; // 0x20
		private Animator m_animator; // 0x28
		public float currentCursorSpeed; // 0x30
		public float currentCursorAcc; // 0x34
		public List<CursorSpeedPhase> speedPhaseList; // 0x38
		public List<CursorSpeedPhase> hoverSpeedPhaseList; // 0x40
		public List<CursorSpeedPhase> secondHoverSpeedPhaseList; // 0x48
		private float m_ScrollSpeed; // 0x50
		private InputActionProperty m_StickAction; // 0x58
		private InputActionProperty m_LeftButtonAction; // 0x70
		private InputActionProperty m_MiddleButtonAction; // 0x88
		private InputActionProperty m_RightButtonAction; // 0xA0
		private InputActionProperty m_ForwardButtonAction; // 0xB8
		private InputActionProperty m_BackButtonAction; // 0xD0
		private InputActionProperty m_ScrollWheelAction; // 0xE8
		private RectTransform _canvasTransform; // 0x100
		private UnityEngine.InputSystem.Mouse m_VirtualMouse; // 0x108
		private UnityEngine.InputSystem.Mouse m_SystemMouse; // 0x110
		private Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate; // 0x118
		private double m_LastTime; // 0x120
		private Vector2 m_LastStickValue; // 0x128
		private float m_lastDisabledTime; // 0x130
		private float _resetCursorPosMinInterval; // 0x134
		[NonSerialized]
		public int leftBtnBindingGroupId; // 0x138
		[NonSerialized]
		public int leftBtnPressBindingId; // 0x13C
		[NonSerialized]
		public int leftBtnReleaseBindingId; // 0x140
		private HashSet<Selectable> m_hoverTargets; // 0x148
		private bool _isHoverOn_k__BackingField; // 0x150
		private bool m_usingHoverSpd; // 0x151
		private int m_encounterHoverCount; // 0x154
		private float m_animatorHoverValue; // 0x158
		private bool m_isIdle; // 0x15C
		private float _hoverAnimationChangeSpeed; // 0x160
		private bool _mouseIconVisible_k__BackingField; // 0x164
		private CanvasGroup m_iconCanvasGroup; // 0x168
	
		// Properties
		public RectTransform cursorTransform { get => default; set {} } // 0x0000000181ABEDF0-0x0000000181ABEE00 0x0000000185FCE860-0x0000000185FCE880
		public float scrollSpeed { get => default; set {} } // 0x000000018A9C3138-0x000000018A9C3168 0x0000000185FCE7F0-0x0000000185FCE810
		public UnityEngine.InputSystem.Mouse virtualMouse { get => default; } // 0x000000018A9C2DF8-0x000000018A9C2EF8 
		public InputActionProperty stickAction { get => default; set {} } // 0x0000000185FCE840-0x0000000185FCE860 0x000000018A9C3000-0x000000018A9C3108
		public InputActionProperty leftButtonAction { get => default; set {} } // 0x0000000185FCE810-0x0000000185FCE830 0x000000018A9C2EF8-0x000000018A9C3000
		public InputActionProperty rightButtonAction { get => default; set {} } // 0x0000000185FCE730-0x0000000185FCE750 0x000000018A9C2CF0-0x000000018A9C2DF8
		public InputActionProperty middleButtonAction { get => default; set {} } // 0x0000000185FCA450-0x0000000185FCA470 0x000000018A9C2BE8-0x000000018A9C2CF0
		public InputActionProperty forwardButtonAction { get => default; set {} } // 0x0000000185FCC5A0-0x0000000185FCC5C0 0x000000018A9C3108-0x000000018A9C3138
		public InputActionProperty backButtonAction { get => default; set {} } // 0x000000018A9C1480-0x000000018A9C1C08 0x000000018A9C10F4-0x000000018A9C1480
		public InputActionProperty scrollWheelAction { get => default; set {} } // 0x000000018A9C24E8-0x000000018A9C2BE8 0x000000018A9C1F78-0x000000018A9C2198
		public bool isHoverOn { get; private set; } // 0x000000018A9C1F00-0x000000018A9C1F78 0x000000018A9C0DEC-0x000000018A9C0F7C
		public bool mouseIconVisible { get; private set; } // 0x0000000185263D90-0x0000000185263F20 0x000000018A9C1DB4-0x000000018A9C1DC0
	
		// Nested types
		[Serializable]
		public class CursorSpeedPhase // TypeDefIndex: 56383
		{
			// Fields
			public float maxJsValue; // 0x10
			public float minSpeed; // 0x14
			public float maxSpeed; // 0x18
			public float acceleration; // 0x1C
			public float accelerationSpeed; // 0x20
			public float maxAcceleration; // 0x24
	
			// Constructors
			public CursorSpeedPhase() {} // 0x00000001813B31A0-0x00000001813B31B0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56384
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Selectable> __9__78_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018646EE40-0x000000018646EE50
			public __c() {} // 0x0000000185FB3000-0x0000000185FB3010
	
			// Methods
			internal bool _ChangeHoverState_b__78_0(Selectable o) => default; // 0x0000000185FB3010-0x0000000185FB3020
		}
	
		// Constructors
		public HGVirtualMouse() {} // 0x000000018A9C4488-0x000000018A9C44EC
	
		// Methods
		protected void OnEnable() {} // 0x000000018A9C1C84-0x000000018A9C1DB4
		protected void OnDisable() {} // 0x000000018A9C0CF8-0x000000018A9C0DEC
		private void _UpdateMotion() {} // 0x000000018A9C2198-0x000000018A9C225C
		private void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) {} // 0x000000018A9C225C-0x000000018A9C23B0
		public void TriggerLeftButton(bool isPressed) {} // 0x000000018A9C0F7C-0x000000018A9C0FCC
		public void ClearLeftButtonState() {} // 0x0000000185FB8290-0x0000000185FB82A0
		private static void _SetActionCallback(InputActionProperty field, Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x0207C8E6 */) {} // 0x0000000185FCDB70-0x0000000185FCDB80
		private static void _SetAction(ref InputActionProperty field, InputActionProperty value) {} // 0x000000018A9C1DCC-0x000000018A9C1F00
		public void OnAfterInputUpdate() {} // 0x000000018A9C0AB8-0x000000018A9C0CF8
		private void Update() {} // 0x000000018A9C0FCC-0x000000018A9C10F4
		public void ChangeHoverState(Selectable target, bool isHoverOn) {} // 0x000000018A9C23B0-0x000000018A9C24E8
		private void _ChangeHoverState(bool isHoverOn) {} // 0x0000000185FCE830-0x0000000185FCE840
		public Selectable GetCurHoverSelectable() => default; // 0x0000000185FCE880-0x0000000185FCE890
		private void OnDestroy() {} // 0x000000018A9C0A2C-0x000000018A9C0AB8
		private void _SyncScale() {} // 0x000000018A9C1C08-0x000000018A9C1C84
		private void Awake() {} // 0x000000018A9C1DC0-0x000000018A9C1DCC
		public void SetMouseIconVisible(bool active) {} // 0x0000000185492010-0x0000000185492020
		private void _OnEnable_b__32_0() {} // 0x0000000185492010-0x0000000185492020
		private void _OnEnable_b__32_1() {} // 0x000000018A9C4410-0x000000018A9C445C
	}

	[Serializable]
	public class InputBindingInfo // TypeDefIndex: 56386
	{
		// Fields
		private static uint s_nextEnabledPriority; // 0x00
		private readonly int _id_k__BackingField; // 0x10
		private Action m_callback; // 0x18
		private InputBindingGroup _group_k__BackingField; // 0x20
		public string playerActionId; // 0x28
		private bool _shouldShowControllerHint_k__BackingField; // 0x30
		private int _controllerHintPriority_k__BackingField; // 0x34
		private bool _isCommonOpenUIAction_k__BackingField; // 0x38
		private bool _selfEnabled_k__BackingField; // 0x39
		private bool _groupEnabled_k__BackingField; // 0x3A
		private bool _parentIgnored_k__BackingField; // 0x3B
		public bool forceKeyhintToGrayState; // 0x3C
		private uint _enabledPriority_k__BackingField; // 0x40
		private int _actionPriority_k__BackingField; // 0x44
		private IBindingView m_bindingView; // 0x48
		private string m_text; // 0x50
		public static float s_continuousTriggerFirstDelayTime; // 0x04
		public static float s_continuousTriggerLoopDelayTime; // 0x08
		public static float s_continuousTriggerLoopQuickDelayTime; // 0x0C
		private int m_continuousTriggerTimerId; // 0x58
	
		// Properties
		public int id { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		public InputBindingGroup group { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public bool shouldShowControllerHint { get; private set; } // 0x00000001814294C0-0x00000001814294D0 0x000000018142A360-0x000000018142A370
		public int controllerHintPriority { get; private set; } // 0x0000000185FB07C0-0x0000000185FB07D0 0x0000000185FB07E0-0x0000000185FB07F0
		public bool isCommonOpenUIAction { get; private set; } // 0x0000000185FB0700-0x0000000185FB0710 0x0000000185FAFE20-0x0000000185FAFE30
		public bool selfEnabled { get; private set; } // 0x0000000185FB0710-0x0000000185FB0720 0x0000000185FB0720-0x0000000185FB0730
		public bool groupEnabled { get; private set; } // 0x0000000185FB0B20-0x0000000185FB0B30 0x0000000185FB0B50-0x0000000185FB0B60
		public bool enabled { get => default; } // 0x000000018443AD00-0x000000018443B060 
		public bool parentIgnored { get; private set; } // 0x0000000185FB0B30-0x0000000185FB0B40 0x0000000185FB0B60-0x0000000185FB0B70
		public uint enabledPriority { get; private set; } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
		public int actionPriority { get; private set; } // 0x0000000183908D10-0x0000000183908D20 0x0000000183909010-0x0000000183909020
		public IBindingView bindingView { get => default; set {} } // 0x000000018527BE10-0x000000018527BE90 0x000000018571FEC0-0x000000018571FED0
		public string text { get => default; set {} } // 0x000000018527BD50-0x000000018527BE10 0x0000000184A4E570-0x0000000184A4E580
	
		// Constructors
		public InputBindingInfo() {} // Dummy constructor
		public InputBindingInfo(int id, InputBindingGroup group, Action callback, string playerActionId, PlayerActionInfo actionInfo) {} // 0x0000000183FE7430-0x0000000183FE7520
		static InputBindingInfo() {} // 0x0000000185F62DE0-0x0000000185F62E60
	
		// Methods
		private static uint _GetNextEnabledPriority() => default; // 0x0000000183FE7520-0x0000000183FE7590
		public void ChangeGroup(InputBindingGroup newGroup) {} // 0x000000018A9C3168-0x000000018A9C31EC
		public void SetSelfEnabled(bool value) {} // 0x000000018422E0F0-0x000000018422ED70
		public void OnGroupEnabledChanged(bool value, bool silent = false /* Metadata: 0x0207C8EB */) {} // 0x0000000183A2E0E0-0x0000000183A2ED70
		public void SetParentIgnored(bool value) {} // 0x000000018A9C3244-0x000000018A9C32A0
		public void Trigger() {} // 0x0000000184EBE040-0x0000000184EBE080
		public void StartContinuousTrigger(InputContinuousTriggerType continuousTriggerType) {} // 0x000000018A9C32A0-0x000000018A9C344C
		private void _TryContinuousTrigger() {} // 0x000000018A9C372C-0x000000018A9C3794
		public void StopContinuousTrigger() {} // 0x0000000183FE5290-0x0000000183FE5310
		private void _RealTriggerCallback() {} // 0x0000000184EBE080-0x0000000184EBE140
		public void OnDelete() {} // 0x0000000183FE48C0-0x0000000183FE5290
		public object GetCallbackTarget() => default; // 0x000000018A9C31EC-0x000000018A9C3244
		private void _StartContinuousTrigger_b__64_0() {} // 0x000000018A9C344C-0x000000018A9C3540
		private void _StartContinuousTrigger_b__64_1() {} // 0x000000018A9C3540-0x000000018A9C3634
		private void _StartContinuousTrigger_b__64_2() {} // 0x000000018A9C3634-0x000000018A9C372C
	}

	[Serializable]
	public class InputBindingGroup // TypeDefIndex: 56387
	{
		// Fields
		private readonly int _id_k__BackingField; // 0x10
		private bool _selfEnabled_k__BackingField; // 0x14
		private bool _parentEnabled_k__BackingField; // 0x15
		private bool _parentIgnored_k__BackingField; // 0x16
		private InputBindingGroup _parent_k__BackingField; // 0x18
		private readonly LinkedList<InputBindingGroup> _subGroups_k__BackingField; // 0x20
		private readonly LinkedList<InputBindingInfo> _subInfos_k__BackingField; // 0x28
		private IBindingView m_groupView; // 0x30
		private IBindingGroupTarget m_groupTarget; // 0x38
	
		// Properties
		public int id { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		public bool selfEnabled { get; private set; } // 0x0000000185FBA190-0x0000000185FBA1A0 0x0000000185FBA1B0-0x0000000185FBA1C0
		public bool parentEnabled { get; private set; } // 0x0000000185FBA1A0-0x0000000185FBA1B0 0x0000000185FBA1C0-0x0000000185FBA1D0
		public bool enabled { get => default; } // 0x0000000184330D70-0x0000000184330E00 
		public bool parentIgnored { get; private set; } // 0x0000000185FCE890-0x0000000185FCE8A0 0x0000000185FCE8A0-0x0000000185FCE8B0
		public InputBindingGroup parent { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public LinkedList<InputBindingGroup> subGroups { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public LinkedList<InputBindingInfo> subInfos { get; } // 0x00000001813B8590-0x00000001813B85A0 
		public IBindingView groupView { get => default; set {} } // 0x000000018527BE90-0x000000018527BF00 0x00000001864721F0-0x0000000186472200
		public IBindingGroupTarget groupTarget { get => default; set {} } // 0x0000000183A2D4E0-0x0000000183A2E0E0 0x000000018142E6F0-0x000000018142E750
	
		// Constructors
		public InputBindingGroup() {} // Dummy constructor
		public InputBindingGroup(int id, InputBindingGroup parent) {} // 0x00000001849DA890-0x00000001849DA970
	
		// Methods
		public void ChangeParent(InputBindingGroup newParent) {} // 0x00000001849DA820-0x00000001849DA890
		public void SetSelfEnabled(bool value) {} // 0x000000018502B840-0x000000018502B8E0
		public void SetParentIgnored(bool value, bool silent = false /* Metadata: 0x0207C8EC */) {} // 0x0000000183A2B7A0-0x0000000183A2BE60
		public void OnParentEnabledChanged(bool value, bool silent = false /* Metadata: 0x0207C8ED */) {} // 0x0000000183A2B0E0-0x0000000183A2B7A0
		private void _OnBindingGroupStateChanged(bool silent = false /* Metadata: 0x0207C8EE */) {} // 0x0000000183A2BE60-0x0000000183A2D4E0
	}

	public class InputBindingGroupMonoTarget : MonoBehaviour, IBindingGroupTarget // TypeDefIndex: 56388
	{
		// Fields
		private int m_groupId; // 0x18
		private bool m_init; // 0x1C
		private bool m_internalEnabled; // 0x1D
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x20
	
		// Properties
		public int groupId { get => default; } // 0x00000001849D74F0-0x00000001849D7510 
		public bool groupEnabled { get => default; } // 0x00000001849D8470-0x00000001849D8500 
		public InputBindingGroupMonoTarget parent { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public IBindingGroupTarget parentTarget { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public bool internalEnabled { get => default; set {} } // 0x0000000185FB2240-0x0000000185FB2250 0x00000001849D7940-0x00000001849D7950
	
		// Constructors
		public InputBindingGroupMonoTarget() {} // 0x00000001856DADD0-0x00000001856DADF0
	
		// Methods
		public void Init() {} // 0x00000001849D7510-0x00000001849D7790
		public void UpdateState() {} // 0x00000001849D7950-0x00000001849D7A00
		public void DeleteGroup() {} // 0x00000001849D7320-0x00000001849D73A0
		private void Awake() {} // 0x00000001849D74B0-0x00000001849D74F0
		private void OnEnable() {} // 0x00000001849D77D0-0x00000001849D7810
		private void OnDisable() {} // 0x00000001849D7790-0x00000001849D77D0
		private void OnDestroy() {} // 0x00000001849D7A00-0x00000001849D7A40
	}

	public interface IBindingGroupTarget // TypeDefIndex: 56389
	{
		// Properties
		int groupId { get; }
		IBindingGroupTarget parentTarget { get; }
		bool groupEnabled { get; }
	}

	public interface IBindingTarget // TypeDefIndex: 56390
	{
		// Properties
		int bindingId { get; }
		IBindingGroupTarget parentTarget { get; }
		bool bindingEnabled { get; }
	}

	public enum BindingViewState // TypeDefIndex: 56391
	{
		Normal = 0,
		Disabled = 1,
		Hide = 2
	}

	public enum BindingViewActionType // TypeDefIndex: 56392
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

	public interface IBindingView // TypeDefIndex: 56393
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

	public enum InputSettingLevel // TypeDefIndex: 56394
	{
		Default = 0,
		Custom = 1,
		Pending = 2
	}

	public class InputManager : Singleton<Beyond.Input.InputManager>, IDisposable // TypeDefIndex: 56400
	{
		// Fields
		public static float s_longPressTime; // 0x00
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
		private Rewired.Joystick _joystick_k__BackingField; // 0x90
		private IGamepadTemplate _gamepadTemplate_k__BackingField; // 0x98
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
		private static bool s_isNonSupportPsController; // 0x20
		public bool disableChangeInputDeviceCheck; // 0xE2
		public bool needProcessTryChange; // 0xE3
		private bool _inChangingInputDevice_k__BackingField; // 0xE4
		private bool m_suppressActionsForDeviceSwitch; // 0xE5
		private int m_suppressFramesRemaining; // 0xE8
		private const int DEVICE_SWITCH_SUPPRESS_FRAMES = 3; // Metadata: 0x0207C910
		private bool m_lastAnyOtherDeviceKey; // 0xEC
		private int m_controllerForbidClickBindingId; // 0xF0
		private bool m_ignoreFirstMouseUpOnFocusBack; // 0xF4
		private static readonly Beyond.Input.KeyboardKeyCode[] S_CACHED_KEYBOARD_KEY_CODES; // 0x28
		private static bool s_autoUpdateInputBindingMask; // 0x30
		private bool m_hasFocusedInputFiled; // 0xF5
		private const float STICK_DEAD_ZONE_MAGNITUDE = 0.2f; // Metadata: 0x0207C911
		private const float STICK_MIN_VALUE = 0.4f; // Metadata: 0x0207C915
		private const float STICK_DEAD_ZONE_SQRT_MAGNITUDE = 0.040000003f; // Metadata: 0x0207C919
		private IAssetLoader m_assetLoader; // 0xF8
		private SerializeFieldDictionary<string, PlayerActionInfo> m_defaultSetting; // 0x100
		private SerializeFieldDictionary<string, PlayerActionInfo> m_customSetting; // 0x108
		private SerializeFieldDictionary<string, PlayerActionInfo> m_pendingSetting; // 0x110
		private InputRebindConfig m_rebindConfig; // 0x118
		private Dictionary<string, InputRebindActionScopeConfig> m_rebindActionScopeConfigs; // 0x120
		private Dictionary<string, PlayerActionInfo> m_anonymousActionInfos; // 0x128
		private int m_nextAnonymousPlayerActionId; // 0x130
		private const string INPUT_MANAGER_CANVAS_PREFAB_PATH = "Assets/Beyond/InitialAssets/Prefabs/Common/InputManagerCanvas.prefab"; // Metadata: 0x0207C91D
		private HGVirtualMouse _virtualMouse_k__BackingField; // 0x138
		private DebugVirtualMouseInput _debugVirtualMouse_k__BackingField; // 0x140
		private Transform _canvasRoot_k__BackingField; // 0x148
		private Transform _controllerMask_k__BackingField; // 0x150
		private bool _usingVirtualMouse_k__BackingField; // 0x158
		private int m_virtualMouseBindingGroupId; // 0x15C
		private Transform _customControllerMouseTrans_k__BackingField; // 0x160
		private Camera _customControllerMouseUICamera_k__BackingField; // 0x168
		private List<ControllerHintInfo> m_tmpControllerHintInfoList; // 0x170
		private static GamepadKeyCode s_controllerIndicatorKey; // 0x34
		private static readonly GamepadKeyCode[] s_skillGamepadKeyCodes; // 0x38
		public static GamepadKeyCode s_comboSkillButtonKey; // 0x40
		private static GamepadKeyCode s_attackButtonKey; // 0x44
		private float m_skillIndicatorPressTime; // 0x178
		private int m_skillIndicatorReleaseFrame; // 0x17C
		private readonly SkillButtonState[] m_lastFrameSkillButtonStates; // 0x180
		private static ProfilerMarker s_updateControllerIndicatorMarker; // 0x48
		public readonly HashSet<string> guideUseActionIds; // 0x188
		private const float DEFAULT_VIBRATE_LEVEL = 0.5f; // Metadata: 0x0207C963
		private static Regex s_actIdRegex; // 0x50
		private const string TEXT_SPRITE_FORMAT = "<image=\"{0}\" scale={1}>"; // Metadata: 0x0207C967
		private const float TEXT_SPRITE_SCALE = 1.6f; // Metadata: 0x0207C97F
		public const string LONG_PRESS_KEY_ICON_POSTFIX = "_press"; // Metadata: 0x0207C983
		private const string KEY_HINT_ICON_COMMON_FOLDER = "Assets/Beyond/InitialAssets/UI/Sprites/"; // Metadata: 0x0207C98A
		private const string KEYBOARD_KEY_HINT_ICON_PATH = "KeyIcon/icon_key_"; // Metadata: 0x0207C9B2
		private const string GAMEPAD_KEY_HINT_ICON_PATH_PS5 = "KeyIcon/Playstation/icon_playstation_"; // Metadata: 0x0207C9C4
		private const string GAMEPAD_KEY_HINT_ICON_PATH_PS4 = "KeyIcon/Playstation4/icon_playstation4_"; // Metadata: 0x0207C9EA
		private const string GAMEPAD_KEY_HINT_ICON_PATH_XBOX = "KeyIcon/XBox/icon_xbox_"; // Metadata: 0x0207CA12
		private const string GAMEPAD_KEY_HINT_ICON_PATH_FALLBACK = "KeyIcon/XBox/icon_xbox_"; // Metadata: 0x0207CA2A
		public static string s_virtualMouseClickHintActionId; // 0x58
		public static string s_virtualMouseLongPressHintActionId; // 0x60
		public MultiAction<Vector2> onStartSwipeTouchPanel; // 0x190
		public MultiAction<Vector2, Vector2> onSwipeTouchPanel; // 0x198
		public MultiAction onEndSwipeTouchPanel; // 0x1A0
		private bool _isSwipingTouchPanel_k__BackingField; // 0x1A8
		private Vector2 m_lastTouchPanelPos; // 0x1AC
		public ControllerNaviManager controllerNaviManager; // 0x1B8
		public bool disableCheckInputForNetMask; // 0x1C0
	
		// Properties
		public bool isDebugForceShow { get => default; } // 0x00000001873350D4-0x00000001873350E8 
		public static bool cursorVisible { get => default; } // 0x0000000185FB0520-0x0000000185FB0530 
		public static bool anyKeyDown { get => default; } // 0x000000018646EBCC-0x000000018646EBE0 
		public static Vector2 mouseScrollDelta { get => default; } // 0x000000018427B2A0-0x000000018427B320 
		public static bool multiTouchEnabled { get => default; set {} } // 0x000000018A9B9D60-0x000000018A9B9D7C 0x0000000185996AD0-0x0000000185999040
		public bool usingController { get => default; private set {} } // 0x00000001846DE170-0x00000001846DE210 0x00000001849DABF0-0x00000001849DE9A0
		public bool virtualMouseIconVisible { get => default; } // 0x000000018A9B6D9C-0x000000018A9B6DEC 
		public KeyboardType keyboardType { get => default; set {} } // 0x000000018A9B81C4-0x000000018A9B8234 0x000000018A9B6D4C-0x000000018A9B6D9C
		public static int invalidID { get => default; } // 0x000000018A9B7F48-0x000000018A9B81C4 
		public Rewired.Joystick joystick { get; private set; } // 0x0000000184330E00-0x0000000184331D90 0x000000018A9B9334-0x000000018A9B9454
		public IGamepadTemplate gamepadTemplate { get; private set; } // 0x000000018A9B9454-0x000000018A9B94E4 0x0000000185C2D5A0-0x0000000185C2EA00
		public IDualShock4Extension gamepadDualShock4Extension { get; private set; } // 0x0000000183A1F480-0x0000000183A20110 0x000000018A9B94E4-0x000000018A9B9BC0
		public Dictionary<string, HashSet<int>> action2BindingDic { get => default; } // 0x000000018432F0B0-0x0000000184330090 
		public int rootGroupId { get => default; } // 0x000000018A9B9D10-0x000000018A9B9D60 
		public static bool isNonSupportPsController { get => default; } // 0x0000000183A22710-0x0000000183A22A20 
		public bool inChangingInputDevice { get; private set; } // 0x0000000183A20110-0x0000000183A21140 0x000000018A9B77DC-0x000000018A9B7884
		public static bool isInputSuppressedByDeviceSwitch { get => default; } // 0x0000000183A18810-0x0000000183A19EF0 
		public static bool autoUpdateInputBindingMask { get => default; set {} } // 0x00000001856E2160-0x00000001856E26E0 0x000000018A9B6424-0x000000018A9B6458
		public HGVirtualMouse virtualMouse { get; private set; } // 0x000000018432EEA0-0x000000018432EF10 0x000000018432EF10-0x000000018432F0B0
		public DebugVirtualMouseInput debugVirtualMouse { get; private set; } // 0x000000018A9B76CC-0x000000018A9B7768 0x000000018A9B74E8-0x000000018A9B76CC
		public Transform canvasRoot { get; private set; } // 0x000000018457CF80-0x000000018457E690 0x0000000184CD2FD0-0x0000000184CD3070
		public Transform controllerMask { get; private set; } // 0x000000018513EDB0-0x00000001851404A0 0x0000000184EBF990-0x0000000184EC1060
		public bool usingVirtualMouse { get; private set; } // 0x0000000185FB8520-0x0000000185FB8530 0x0000000187A4762C-0x0000000187A47640
		public static Vector3 mousePosition { get => default; } // 0x000000018A9B5844-0x000000018A9B58F4 
		public Transform customControllerMouseTrans { get; private set; } // 0x000000018A9B795C-0x000000018A9B7A38 0x000000018A9B7884-0x000000018A9B795C
		public Camera customControllerMouseUICamera { get; private set; } // 0x000000018505F530-0x000000018505F900 0x000000018A9B3F98-0x000000018A9B403C
		public bool isSwipingTouchPanel { get; private set; } // 0x0000000183A1B8B0-0x0000000183A1D590 0x0000000183A1E450-0x0000000183A1F480
	
		// Nested types
		public class KeyCaches // TypeDefIndex: 56395
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
			public KeyCaches() {} // 0x0000000184439510-0x000000018443A420
	
			// Methods
			public void UpdateKeyStat() {} // 0x0000000183A22A20-0x0000000183A22A50
		}
	
		private enum KeyCodeState // TypeDefIndex: 56396
		{
			Pressed = 0,
			OnPress = 1,
			OnRelease = 2
		}
	
		public class ControllerHintInfo : IComparable<ControllerHintInfo>, IReusable // TypeDefIndex: 56397
		{
			// Fields
			public string actionId; // 0x10
			public int priority; // 0x18
			public InputBindingInfo bind; // 0x20
			public IBindingView hintView; // 0x28
	
			// Constructors
			public ControllerHintInfo() {} // 0x0000000184CD5060-0x0000000184CD5BC0
			public ControllerHintInfo(IBindingView hintView, InputBindingInfo bind) {} // 0x0000000184CD3350-0x0000000184CD4210
			public ControllerHintInfo(string actionId) {} // 0x0000000183FB4CE0-0x0000000183FB4DD0
	
			// Methods
			public void Reset(IBindingView newHintView, InputBindingInfo newBind) {} // 0x00000001859A2DD0-0x00000001859A2F80
			public void Reset(string resetActionId) {} // 0x0000000184330390-0x00000001843303E0
			public int CompareTo(ControllerHintInfo other) => default; // 0x000000018A9B9DAC-0x000000018A9B9E48
			public void OnAllocate() {} // 0x000000018A9B9D7C-0x000000018A9B9DAC
			public void OnRecycle() {} // 0x0000000183A23070-0x0000000183A230A0
		}
	
		private enum SkillButtonState // TypeDefIndex: 56398
		{
			None = 0,
			JustPressed = 1
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56399
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__103_0; // 0x08
			public static Action __9__239_0; // 0x10
			public static MatchEvaluator __9__309_0; // 0x18
	
			// Constructors
			static __c() {} // 0x0000000183A23CE0-0x0000000183A258F0
			public __c() {} // 0x00000001813AE580-0x00000001813AE590
	
			// Methods
			internal void __InitDeviceChangeBinding_b__103_0() {} // 0x0000000181B5FFD0-0x0000000181B5FFE0
			internal void __CreateVirtualMouse_b__239_0() {} // 0x00000001873CBEA8-0x00000001873CBEBC
			internal string _ParseTextActionId_b__309_0(System.Text.RegularExpressions.Match match) => default; // 0x0000000181E336C0-0x0000000181E336D0
		}
	
		// Constructors
		private InputManager() {} // 0x000000018A9B8D0C-0x000000018A9B8FD4
		static InputManager() {} // 0x0000000185F76510-0x0000000185F76570
	
		// Methods
		public void LateTick(float deltaTime) {} // 0x00000001847716B0-0x0000000184771750
		private void _Init() {} // 0x0000000185FB9D20-0x0000000185FB9D30
		public void Release() {} // 0x0000000185FBD870-0x0000000185FBD880
		private void _ClearTickFunction() {} // 0x0000000183A22A50-0x0000000183A23070
		public void OnApplicationQuit() {} // 0x0000000185CA3EB0-0x0000000185CA4020
		private void _ClearEvents() {} // 0x000000018539DB10-0x000000018539DB70
		private void _OnAfterInputUpdate() {} // 0x0000000184BEF1A0-0x0000000184BEF2E0
		private void _OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x000000018A9B7EF0-0x000000018A9B7F48
		private void _OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x000000018A9B7C70-0x000000018A9B7EF0
		private void _TryFindGamepad() {} // 0x000000018A9B7AEC-0x000000018A9B7BBC
		private bool _IsValidJoystick(Rewired.Joystick js) => default; // 0x000000018A9B9BC0-0x000000018A9B9D10
		private void _SetJoystick(Rewired.Joystick js) {} // 0x0000000183A21140-0x0000000183A217C0
		private void _CheckInput() {} // 0x000000018539BCF0-0x000000018539DA70
		private Beyond.DeviceInfo.ControllerType _GetControllerType(Rewired.Joystick js) => default; // 0x0000000183A230A0-0x0000000183A23CE0
		public void OnApplicationFocus(bool hasFocus) {} // 0x0000000183A217C0-0x0000000183A22710
		private void _InitDeviceChangeBinding() {} // 0x000000018A9B432C-0x000000018A9B43E4
		private void _RefreshDeviceChangeBinding() {} // 0x0000000185FA48E0-0x0000000185FA4920
		public void CheckUsingController() {} // 0x0000000185489780-0x00000001854898A0
		private bool _CheckAnyKeyForTouchChangeDevice() => default; // 0x0000000183FE5690-0x0000000183FE5760
		private bool _CheckAnyKeyForKeyboardChangeDevice() => default; // 0x0000000183FE6920-0x0000000183FE69F0
		private bool _AnyKeyDownForKeyboardChangeDevice() => default; // 0x0000000183FE69F0-0x0000000183FE6B10
		private void _TryChangeInputDeviceType(Beyond.DeviceInfo.InputType inputType) {} // 0x0000000183FE6B10-0x0000000183FE6C70
		private void _TryStopDeviceSwitchSuppression() {} // 0x0000000183FE5760-0x0000000183FE5810
		private void _SyncUsingControllerState() {} // 0x0000000183FE64C0-0x0000000183FE65D0
		private static void _UpdateInputBindingMask(Beyond.DeviceInfo.InputType inputType) {} // 0x0000000184331F70-0x0000000184332520
		private static void _SetInputBindingMask(string group) {} // 0x0000000184332520-0x0000000184332AD0
		public void ToggleInputDeviceChangeMode(bool inChanging) {} // 0x000000018A9B6088-0x000000018A9B61B0
		public void SetCursorOverrideForDeviceChange(bool forceShow) {} // 0x000000018A9B4580-0x000000018A9B45AC
		public void ChangeInputTypeAndSyncState(Beyond.DeviceInfo.InputType inputType) {} // 0x000000018A9B4568-0x000000018A9B4580
		private void _OnFocusedInputFieldChanged(in EventData<bool> v) {} // 0x000000018A9B61B0-0x000000018A9B6308
		private void _CreateTickFunction() {} // 0x000000018A9B6468-0x000000018A9B6474
		private void _RemovePlayerActionCheck(InputBindingInfo info) {} // 0x000000018A9B6308-0x000000018A9B6318
		private void _AddPlayerActionCheck(InputBindingInfo info) {} // 0x000000018A9B6458-0x000000018A9B6468
		private void _AddPlayerActionCheck(KeyboardInput input, InputBindingInfo info) {} // 0x000000018A9B403C-0x000000018A9B422C
		private void _AddPlayerActionCheck(GamepadInput input, InputBindingInfo info) {} // 0x000000018A9B7BBC-0x000000018A9B7C70
		private void _RemovePlayerActionCheck(KeyboardInput input, InputBindingInfo info) {} // 0x0000000184BEF2E0-0x0000000184BEF320
		private void _RemovePlayerActionCheck(GamepadInput input, InputBindingInfo info) {} // 0x0000000184CD69E0-0x0000000184CD6A40
		public bool GetKey(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x000000018A9B42AC-0x000000018A9B432C
		public bool GetKeyOrDown(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x000000018A9B422C-0x000000018A9B42AC
		public bool GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x0000000184CD5BC0-0x0000000184CD69E0
		public bool GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x0000000183A0A510-0x0000000183A0AF20
		public Vector2 GetGamepadStickValue(bool isLeft, bool checkDeadZone = true /* Metadata: 0x0207C8FE */) => default; // 0x000000018443B0D0-0x0000000184443DF0
		public static bool CheckGamepadStickInDeadZone(Vector2 stickValue) => default; // 0x000000018A9B46A4-0x000000018A9B475C
		public static bool CheckGamepadStickInDeadZone(float stickAxisValue) => default; // 0x0000000183FE65D0-0x0000000183FE6640
		public float GetGamepadTriggerValue(bool isLeft) => default; // 0x000000018A9B475C-0x000000018A9B4914
		public bool GetKey(GamepadKeyCode keyCode) => default; // 0x0000000183FE7050-0x0000000183FE7310
		public bool GetKeyDown(GamepadKeyCode keyCode) => default; // 0x000000018422A2B0-0x000000018422A380
		public bool GetKeyUp(GamepadKeyCode keyCode) => default; // 0x000000018422E040-0x000000018422E0F0
		public bool AnyKeyboardKey(string[] actionScopes, out Beyond.Input.KeyboardKeyCode keyCode, out bool isBlackList) {
			keyCode = default;
			isBlackList = default;
			return default;
		} // 0x0000000183A0AF20-0x0000000183A0B5D0
		private bool _AnyKeyboardKey(Beyond.Input.KeyboardKeyCode[] keyCodes, out Beyond.Input.KeyboardKeyCode keyCode) {
			keyCode = default;
			return default;
		} // 0x0000000183A0BC60-0x0000000183A0D220
		public bool AnyGamepadKey() => default; // 0x00000001849D6000-0x00000001849D60A0
		public bool AnyMouseKeyDown() => default; // 0x00000001849D9720-0x00000001849D97B0
		public bool AnyMouseKey() => default; // 0x0000000184330B80-0x0000000184330D70
		public bool AnyMouseKeyUp() => default; // 0x000000018443A850-0x000000018443AD00
		public static bool AnyKeyDown() => default; // 0x000000018A9B55F0-0x000000018A9B56A8
		public static bool AnyTouchBegan() => default; // 0x000000018A9B6980-0x000000018A9B6A28
		private bool _CheckGamepadKeyCode(GamepadKeyCode keyCode, KeyCodeState state) => default; // 0x0000000184330980-0x0000000184330B80
		public int CreateBinding(PlayerActionInfo actionInfo, Action callback, int groupId, out string actionId) {
			actionId = default;
			return default;
		} // 0x0000000183A1A600-0x0000000183A1AF70
		public int CreateBinding(string actionId, Action callback, int groupId) => default; // 0x0000000183A0B5D0-0x0000000183A0BC60
		public int CreateBinding(Beyond.Input.KeyboardKeyCode key, string modifyKeys, InputTimingType timing, Action callback, int groupId) => default; // 0x0000000183A19EF0-0x0000000183A1A600
		public int CreateBindingByActionId(string actionId, Action callback, int groupId) => default; // 0x000000018476D8A0-0x000000018476D8F0
		public void DeleteBinding(int id) {} // 0x000000018A9B7428-0x000000018A9B74E8
		public void ToggleBinding(int id, bool active) {} // 0x0000000185192450-0x00000001851924F0
		public void CancelPendingLongPress(InputBindingInfo info) {} // 0x00000001849D9580-0x00000001849D9720
		public int CreateGroup(int parentGroupId, IBindingGroupTarget bindingGroupTarget = null) => default; // 0x00000001849D94A0-0x00000001849D9580
		public void DeleteGroup(int id) {} // 0x000000018A9B67F4-0x000000018A9B68BC
		public void DeleteInGroup(int groupId) {} // 0x000000018A9B68BC-0x000000018A9B6980
		public void ToggleGroup(int id, bool active) {} // 0x0000000183A0D220-0x0000000183A0E170
		public bool IsBindingEnabled(int id, bool needLogError = true /* Metadata: 0x0207C8FF */) => default; // 0x0000000184D9B640-0x0000000184D9B710
		public void ForceBindingKeyhintToGray(int id, bool grayState) {} // 0x000000018A9B4E0C-0x000000018A9B5568
		public bool IsBindingKeyhintGray(int id) => default; // 0x0000000184D970E0-0x0000000184D972C0
		public bool IsGroupEnabled(int id) => default; // 0x0000000185609160-0x0000000185609310
		public void ToggleDebugCursorMode() {} // 0x000000018527BC90-0x000000018527BD50
		public void ClearAllCursorShowRequests() {} // 0x000000018A9B676C-0x000000018A9B67F4
		public void SetCursorShowRequest(string key, bool showCursor) {} // 0x000000018527BF90-0x000000018527C020
		public void ToggleAllInput(bool active) {} // 0x000000018527C020-0x000000018527C1A0
		public void SetBindingView(int bindingId, IBindingView bindingView) {} // 0x000000018A9B444C-0x000000018A9B4568
		public void SetGroupView(int groupId, IBindingView groupView) {} // 0x00000001849D97B0-0x00000001849D9890
		public void ChangeParent(bool isGroup, int id, int newParentGroupId) {} // 0x00000001849D9890-0x00000001849DA820
		public int GetGroupParentId(bool isGroup, int id) => default; // 0x0000000183FE5550-0x0000000183FE5690
		public void IgnoreBindingGroupParent(int groupId, bool parentIgnored) {} // 0x0000000184677A90-0x0000000184678420
		public void IgnoreBindingParent(int bindingId, bool parentIgnored) {} // 0x000000018527B740-0x000000018527B840
		public Beyond.Input.KeyboardKeyCode GetActionKeyboardKeyCode(string actionId, bool isModifyKey, bool isPrimary, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x0207C900 */) => default; // 0x0000000185060910-0x0000000185062960
		public GamepadKeyCode GetActionGamepadKeyCode(string actionId, bool isModifyKey, bool isPrimary, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x0207C901 */) => default; // 0x000000018505FAB0-0x0000000185060910
		public void DeleteCustomBinding(string actionId, InputDeviceFlags deviceFlags = InputDeviceFlags.All /* Metadata: 0x0207C902 */) {} // 0x000000018505F9D0-0x000000018505FAB0
		public void DeleteAllCustomBindings(InputDeviceFlags deviceFlags = InputDeviceFlags.All /* Metadata: 0x0207C903 */) {} // 0x0000000183FE7310-0x0000000183FE7430
		public void SetBindingText(int id, string text) {} // 0x000000018A9B43E4-0x000000018A9B444C
		public string GetBindingText(int id) => default; // 0x000000018A9B3EC0-0x000000018A9B3F98
		public bool HasBinding(int id) => default; // 0x000000018505F900-0x000000018505F9D0
		public string GetActionText(string actionId) => default; // 0x000000018A9B90A8-0x000000018A9B9334
		public static string GetActionText(PlayerActionInfo info, string actionId) => default; // 0x000000018A9B4BEC-0x000000018A9B4E0C
		public bool CheckActionKeyCodeConflict(string actionId, Beyond.Input.KeyboardKeyCode keyCode, out bool isPrimary) {
			isPrimary = default;
			return default;
		} // 0x000000018A9B4914-0x000000018A9B4BEC
		private void _DeleteGroup(InputBindingGroup group, bool isRootCall) {} // 0x000000018A9B4628-0x000000018A9B46A4
		private void _DeleteInGroup(InputBindingGroup group) {} // 0x0000000184D98E20-0x0000000184D994A0
		private void _RealRemoveBindingInfo(InputBindingInfo info) {} // 0x0000000185FB8720-0x0000000185FB8730
		public float GetAxis(string name) => default; // 0x00000001864735CC-0x00000001864735E0
		public void GetBindingInfo(int bindingId, out string actionId, out IBindingView bindingView) {
			actionId = default;
			bindingView = default;
		} // 0x0000000185FB85F0-0x0000000185FB8600
		private void _LoadSetting() {} // 0x0000000187A47758-0x0000000187A4776C
		public void LoadSetting() {} // 0x0000000185FB8610-0x0000000185FB8620
		public bool IsPlayerActionIdValid(string id) => default; // 0x0000000187A47780-0x0000000187A47794
		public PlayerActionInfo GetPlayerActionInfo(string id, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x0207C904 */) => default; // 0x0000000185FB84D0-0x0000000185FB84E0
		public void ChangePlayerAction(string id, PlayerActionInfo actionInfo) {} // 0x0000000187A475C8-0x0000000187A475DC
		public string AddAnonymousPlayerAction(PlayerActionInfo actionInfo) => default; // 0x0000000185FBC3E0-0x0000000185FBC3F0
		private void _LoadCustomInputSetting() {} // 0x0000000185FBC3F0-0x0000000185FBC400
		private PlayerActionInfo _GetOrCreatePendingActionInfo(string actionId) => default; // 0x000000018539F860-0x000000018539FB00
		public bool CustomizeActionKey(string actionId, Beyond.Input.KeyboardKeyCode key, bool isPrimary, string overrideKeyIconName = null) => default; // 0x000000018539FB00-0x000000018539FBA0
		public bool CustomizeActionKey(string actionId, GamepadKeyCode? modifyKey, GamepadKeyCode? key, bool isPrimary, string overrideKeyIconName = null) => default; // 0x000000018539FBA0-0x000000018539FD60
		public void ClearPendingInputSetting() {} // 0x000000018539E550-0x000000018539F860
		public void SaveCustomInputSetting() {} // 0x000000018539DBF0-0x000000018539E550
		private void _CreateCanvas() {} // 0x0000000185FB88D0-0x0000000185FB88E0
		private void _CreateDebugVirtualMouse() {} // 0x0000000187A47BE0-0x0000000187A47BF4
		private void _CreateVirtualMouse() {} // 0x0000000185FA8540-0x0000000185FA85B0
		private void _ToggleVirtualMouse(bool active, bool forceUpdate = false /* Metadata: 0x0207C905 */) {} // 0x000000018A9B5E24-0x000000018A9B5FD8
		private void _CheckVirtualMouseState() {} // 0x000000018A9B58F4-0x000000018A9B59E8
		public static Vector3 GetMousePos() => default; // 0x000000018A9B85E0-0x000000018A9B8D0C
		public void SetOnlyVirtualMousePos(Vector2 newPos) {} // 0x000000018A9B840C-0x000000018A9B85E0
		public static void SetMousePos(Vector2 newPos, bool hideVirtualMouse = false /* Metadata: 0x0207C906 */) {} // 0x000000018A9B6474-0x000000018A9B65C4
		public static bool GetMouseButton(int button) => default; // 0x000000018A9B56A8-0x000000018A9B5844
		public static bool IsLeftMouseDown() => default; // 0x0000000185A672D0-0x0000000185A67C30
		public static bool GetMouseButtonDown(int button) => default; // 0x0000000185D50790-0x0000000185D51460
		public static bool GetMouseButtonUp(int button) => default; // 0x00000001846DE210-0x00000001846DE590
		public void SetCustomControllerMouse(Transform trans, Camera uiCamera) {} // 0x000000018A9B6DEC-0x000000018A9B6E90
		public List<ControllerHintInfo> GetEmptyControllerHintInfoList() => default; // 0x000000018A9B45AC-0x000000018A9B4628
		public void GetControllerHintInfos(int groupId, bool ignoreRootEnabled, ref List<ControllerHintInfo> infoList) {} // 0x000000018A9B7A38-0x000000018A9B7AEC
		public void GetControllerHintInfos(List<string> actionIdList, ref List<ControllerHintInfo> infoList) {} // 0x000000018A9B8FD4-0x000000018A9B90A8
		private void _GetControllerHintInfos(InputBindingGroup group, bool ignoreRootEnabled, ref List<ControllerHintInfo> infoList) {} // 0x00000001854229D0-0x0000000185422B40
		private void _GetControllerHintInfos(List<string> actionIdList, ref List<ControllerHintInfo> infoList) {} // 0x000000018A9B65C4-0x000000018A9B676C
		public float GetPlayerActionLongPressStartTime(string actionId, out float longPressTime) {
			longPressTime = default;
			return default;
		} // 0x0000000183A0E170-0x0000000183A0F060
		public float GetActionBindingLongPressStartTime(int bindingId, out float longPressTime) {
			longPressTime = default;
			return default;
		} // 0x000000018A9B6318-0x000000018A9B6424
		public bool GetControllerIndicatorState() => default; // 0x000000018A9B5FD8-0x000000018A9B6088
		public bool CheckNormalAttackBtn() => default; // 0x0000000183FE79E0-0x0000000183FE7A90
		private void _UpdateControllerIndicator(float deltaTime) {} // 0x0000000183FE7A90-0x0000000183FE8A60
		public int TryPressControllerIndicatorWhenSkillButtonJustPressed() => default; // 0x0000000183FE8A60-0x0000000183FE8B90
		public void TryClickSkillButtonWhenControllerIndicatorJustRelease(int charIndex) {} // 0x000000018587E110-0x000000018587E2A0
		private void _RefreshControllerBattleButton() {} // 0x000000018A9B6A28-0x000000018A9B6CA4
		public void AddGuideUseActionId(string actionId) {} // 0x000000018A9B6CA4-0x000000018A9B6D4C
		public void RemoveGuideUseActionId(string actionId) {} // 0x000000018A9B7768-0x000000018A9B77DC
		public void ClearGuideUseActionIds() {} // 0x0000000185FBA410-0x0000000185FBA420
		public void VibrateController(float time, float level = 0.5f /* Metadata: 0x0207C907 */) {} // 0x0000000185FBDA00-0x0000000185FBDA10
		private static string _GetGamepadKeyIconFolderPath() => default; // 0x000000018A9B8234-0x000000018A9B840C
		public static string GetStringByKeyboardKeyCode(Beyond.Input.KeyboardKeyCode code) => default; // 0x0000000184FC1550-0x0000000184FC15C0
		public static string GetStringByGamepadKeyCode(GamepadKeyCode code) => default; // 0x0000000184FC3530-0x0000000184FC38B0
		public static string GetKeyboardIconPath(string keyName, bool isLongPress, bool isFullPath) => default; // 0x000000018A9B5568-0x000000018A9B55F0
		public static string GetKeyIconPath(GamepadInput inputInfo, bool isModifyKey, bool isFullPath, bool ignoreOverrideKeyIcon = false /* Metadata: 0x0207C90B */) => default; // 0x000000018A9B6E90-0x000000018A9B7428
		public static string GetGamepadKeyIconPath(string keyStr, bool isLongPress, bool isFullPath) => default; // 0x0000000185C65AC0-0x0000000185C65B40
		public static string GetKeyIconPath(KeyboardInput inputInfo, bool isModifyKey, bool isFullPath) => default; // 0x000000018A9B59E8-0x000000018A9B5E24
		public static string GetKeyIconPath(KeyboardInput inputInfo, bool isModifyKey, bool isLongPress, bool isFullPath) => default; // 0x0000000183A0F060-0x0000000183A0F6E0
		private static string _GetKeyIconPath(string path, string keyStr, bool isLongPress, bool isFullPath) => default; // 0x0000000183A12D50-0x0000000183A14310
		public static string ParseTextActionId(string text) => default; // 0x0000000183A16580-0x0000000183A18810
		public void MoveMouseTo(RectTransform target, Camera uiCamera) {} // 0x0000000183A14310-0x0000000183A16580
		public void MoveVirtualMouseTo(RectTransform target, Camera uiCamera, bool hideVirtualMouse = true /* Metadata: 0x0207C90C */) {} // 0x0000000183A0F6E0-0x0000000183A113F0
		public void SetVirtualMouseIconVisible(bool active) {} // 0x0000000183A113F0-0x0000000183A12D50
		private void _ControllerTouchPanelTick() {} // 0x0000000183A1D590-0x0000000183A1E450
		public static int GetTouchId(PointerEventData eventData) => default; // 0x000000018549ADC0-0x000000018549D260
		public static bool GetPressPosByTouchId(int touchId, out Vector2 position) {
			position = default;
			return default;
		} // 0x0000000183A1AF70-0x0000000183A1AF90
		public void Dispose() {} // 0x0000000183A1AF90-0x0000000183A1AFB0
		public static void RemoveUnusedInput() {} // 0x0000000183A1AFB0-0x0000000183A1B5B0
		private void _OnNetMaskChanged(in EventData<bool> v) {} // 0x0000000183A1B5B0-0x0000000183A1B8B0
		public string GetCurJsInfos() => default; // 0x0000000184332AD0-0x00000001843337D0
		public string GetRealCursorState() => default; // 0x0000000185492010-0x0000000185492020
		public string PrintKeycodeInfo(string keyCode, bool checkKeyboard, bool checkGamepad, bool isDetailed = false /* Metadata: 0x0207C90D */) => default; // 0x0000000185492010-0x0000000185492020
		public string PrintKeycodeInfo(Beyond.Input.KeyboardKeyCode keyCode, bool isDetailed = false /* Metadata: 0x0207C90E */) => default; // 0x000000018A9BA0C4-0x000000018A9BA0CC
		public string PrintKeycodeInfo(GamepadKeyCode keyCode, bool isDetailed = false /* Metadata: 0x0207C90F */) => default; // 0x000000018A9BA0CC-0x000000018A9BA0D4
		public string PrintActionInfo(string actionId) => default; // 0x000000018A9B9F64-0x000000018A9BA010
		public string PrintBindingInfo(InputBindingInfo bindingInfo) => default; // 0x000000018A9BA010-0x000000018A9BA0C4
		private string _GetBindingName(object item) => default; // 0x000000018A9B9E48-0x000000018A9B9EA8
		private GameObject _GetInputBindingGroupGameObject(InputBindingGroup bindingGroup) => default; // 0x000000018A9B9EA8-0x000000018A9B9EEC
		private GameObject _GetInputBindingGameObject(InputBindingInfo bindingInfo) => default; // 0x000000018A9B9EEC-0x000000018A9B9F64
		private void __Init_b__68_0(Beyond.Input.KeyboardKeyCode key) {} // 0x0000000185492010-0x0000000185492020
		private void __Init_b__68_1(GamepadKeyCode key) {} // 0x0000000185492010-0x0000000185492020
		private void __Init_b__68_2() {} // 0x0000000185492010-0x0000000185492020
		private void __Init_b__68_3() {} // 0x0000000183A30690-0x0000000183A32FB0
	}

	public class InputRebindConfig : ScriptableObject // TypeDefIndex: 56401
	{
		// Fields
		public const string INPUT_REBIND_CONFIG_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Input/InputRebindConfig.asset"; // Metadata: 0x0207CA47
		public InputRebindActionScopeConfig[] actionScopeConfigs; // 0x18
	
		// Constructors
		public InputRebindConfig() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	[Serializable]
	public class InputRebindActionScopeConfig // TypeDefIndex: 56402
	{
		// Fields
		public string name; // 0x10
		public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeWhiteList; // 0x18
		public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeBlackList; // 0x20
	
		// Constructors
		public InputRebindActionScopeConfig() {} // 0x0000000185492010-0x0000000185492020
	}

	public class InputSetting : ScriptableObject // TypeDefIndex: 56403
	{
		// Fields
		public const string CUSTOM_SETTING_DIRECTORY_NAME = "Input"; // Metadata: 0x0207CA8E
		public const string CUSTOM_SETTING_JSON_FILE_NAME = "CustomInputSetting.json"; // Metadata: 0x0207CA94
		public SerializeFieldDictionaryPaired<string, PlayerActionInfo> actionInfos; // 0x18
	
		// Constructors
		public InputSetting() {} // 0x0000000185712CB0-0x0000000185712D40
	}

	public class InputSettingConfig : ScriptableObject // TypeDefIndex: 56404
	{
		// Fields
		public const string INPUT_SETTING_CONFIG_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Input/InputSettingConfig.asset"; // Metadata: 0x0207CAAC
		public List<InputSetting> inputSettingList; // 0x18
	
		// Constructors
		public InputSettingConfig() {} // 0x0000000185F4EEB0-0x0000000185F4EF30
	}

	public static class InputUtils // TypeDefIndex: 56405
	{
		// Methods
		public static void IgnoreBindingParent(IBindingTarget target, bool active) {} // 0x000000018A9C389C-0x000000018A9C39B0
		public static void IgnoreBindingGroupParent(IBindingGroupTarget target, bool active) {} // 0x000000018A9C37F0-0x000000018A9C389C
		public static bool HasFlag(InputDeviceFlags value, InputDeviceFlags target) => default; // 0x000000018A9C3794-0x000000018A9C37F0
	}

	internal abstract class KeyboardCheckerBase // TypeDefIndex: 56408
	{
		// Fields
		protected Beyond.Input.InputManager m_inputManager; // 0x10
		protected const int CTRL = 1; // Metadata: 0x0207CAF5
		protected const int SHIFT = 2; // Metadata: 0x0207CAF6
		protected const int ALT = 4; // Metadata: 0x0207CAF7
		protected const int MAX_INDEX = 7; // Metadata: 0x0207CAF8
		protected static int[] s_checkPriority; // 0x00
		protected List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<Binding>>> m_bindingInfos; // 0x18
	
		// Properties
		internal List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<Binding>>> bindingInfos { get; } // 0x00000001849DAAD0-0x00000001849DABF0 
	
		// Nested types
		public class Binding // TypeDefIndex: 56406
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
			public Binding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0207CAF9 */) {} // 0x000000018A9C39F4-0x000000018A9C3A44
		}
	
		public enum TriggerType // TypeDefIndex: 56407
		{
			NORMAL = 0,
			CONTINUOUS = 1,
			STOP_CONTINUOUS = 2
		}
	
		// Constructors
		protected KeyboardCheckerBase() {} // Dummy constructor
		protected KeyboardCheckerBase(Beyond.Input.InputManager inputManager) {} // 0x0000000183FE7780-0x0000000183FE77D0
		static KeyboardCheckerBase() {} // 0x0000000183FE77D0-0x0000000183FE78C0
	
		// Methods
		public static int GetModifyIndex(KeyboardInput input) => default; // 0x0000000183FE7590-0x0000000183FE7780
		public virtual Binding OnCreateBinding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0207CAF4 */) => default; // 0x0000000183FE45A0-0x0000000183FE48C0
		public virtual Binding OnDeleteBinding(KeyboardInput input, InputBindingInfo info) => default; // 0x000000018A9C39B0-0x000000018A9C39F4
		public virtual void CheckKeyboardInput() {} // 0x00000001853EFFE0-0x00000001853F0010
		public virtual void TriggerActions() {} // 0x0000000185F3F880-0x0000000185F3F910
	}

	internal class KeyboardChecker : KeyboardCheckerBase // TypeDefIndex: 56409
	{
		// Fields
		private Func<Beyond.Input.KeyboardKeyCode, bool> m_checkFunc; // 0x20
		private bool _isPressChecker_k__BackingField; // 0x28
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x30
		private List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x38
	
		// Properties
		public bool isPressChecker { get; private set; } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
	
		// Constructors
		public KeyboardChecker() {} // Dummy constructor
		public KeyboardChecker(Func<Beyond.Input.KeyboardKeyCode, bool> checkFunc, bool isPress, Beyond.Input.InputManager inputManager) {} // 0x00000001849DA970-0x00000001849DAAD0
	
		// Methods
		public override void CheckKeyboardInput() {} // 0x00000001843337D0-0x0000000184334110
		public override void TriggerActions() {} // 0x0000000184EBDA10-0x0000000184EBE040
		public void __iFixBaseProxy_CheckKeyboardInput() {} // 0x000000018A9C3A44-0x000000018A9C3A4C
		public void __iFixBaseProxy_TriggerActions() {} // 0x000000018A9C3A4C-0x000000018A9C3A54
	}

	internal class KeyboardOnClickChecker : KeyboardCheckerBase // TypeDefIndex: 56410
	{
		// Fields
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x20
		private List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x28
		private List<ListSet<Beyond.Input.KeyboardKeyCode>> m_combinationKeyPressedInfo; // 0x30
	
		// Constructors
		public KeyboardOnClickChecker() {} // Dummy constructor
		public KeyboardOnClickChecker(Beyond.Input.InputManager inputManager) {} // 0x00000001859A8000-0x00000001859A8200
	
		// Methods
		public override void CheckKeyboardInput() {} // 0x0000000184334160-0x0000000184335FC0
		public override void TriggerActions() {} // 0x0000000184EBD450-0x0000000184EBDA10
		public void ClearKeyPressed(Beyond.Input.KeyboardKeyCode keyCode) {} // 0x000000018A9C3A54-0x000000018A9C3D34
		public void __iFixBaseProxy_CheckKeyboardInput() {} // 0x000000018A9C3A44-0x000000018A9C3A4C
		public void __iFixBaseProxy_TriggerActions() {} // 0x000000018A9C3A4C-0x000000018A9C3A54
	}

	internal class KeyboardOnLongPressChecker : KeyboardCheckerBase // TypeDefIndex: 56412
	{
		// Fields
		private Action<Beyond.Input.KeyboardKeyCode> m_onTriggerOnLongPress; // 0x20
		private Dictionary<KeyboardInput, HashSet<Binding>> m_bindings; // 0x28
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x30
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 56411
		{
			// Fields
			public ValueTuple<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>> key; // 0x10
			public KeyboardCheckerBase.Binding targetBinding; // 0x20
			public KeyboardOnLongPressChecker __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x0000000185D798F0-0x0000000185D79A10
	
			// Methods
			internal void _CheckKeyboardInput_b__0() {} // 0x0000000184DB0920-0x0000000184DB1430
		}
	
		// Constructors
		public KeyboardOnLongPressChecker() {} // Dummy constructor
		public KeyboardOnLongPressChecker(Action<Beyond.Input.KeyboardKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager) {} // 0x000000018A9C41F4-0x000000018A9C4410
	
		// Methods
		public override void CheckKeyboardInput() {} // 0x000000018A9C3F44-0x000000018A9C40BC
		private void _OnTriggerBinding(Binding binding, Beyond.Input.KeyboardKeyCode keyCode) {} // 0x000000018A9C40BC-0x000000018A9C41DC
		public override Binding OnCreateBinding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0207CAFD */) => default; // 0x0000000183A2ED70-0x0000000183A30690
		public override Binding OnDeleteBinding(KeyboardInput input, InputBindingInfo info) => default; // 0x000000018A9C3D34-0x000000018A9C3F44
		public void CancelPendingLongPress(InputBindingInfo info) {} // 0x000000018A9C3A44-0x000000018A9C3A4C
		public float GetInputLongPressStartTime(KeyboardInput input, int bindingId = 0 /* Metadata: 0x0207CAFE */) => default; // 0x000000018A9C41DC-0x000000018A9C41EC
		public void __iFixBaseProxy_CheckKeyboardInput() {} // 0x000000018A9C41EC-0x000000018A9C41F4
		public Binding __iFixBaseProxy_OnCreateBinding(KeyboardInput P0, InputBindingInfo P1, bool P2) => default; // 0x0000000185492010-0x0000000185492020
		public Binding __iFixBaseProxy_OnDeleteBinding(KeyboardInput P0, InputBindingInfo P1) => default; // 0x000000018A9C5200-0x000000018A9C522C
	}

	public class KeyboardHandler // TypeDefIndex: 56413
	{
		// Fields
		private static Dictionary<Beyond.Input.KeyboardKeyCode, UnityEngine.InputSystem.Key> s_keyMap; // 0x00
		private Dictionary<Beyond.Input.KeyboardKeyCode, string> m_localizedKeyName; // 0x10
		private Dictionary<string, string> m_localizedIconName; // 0x18
		private Dictionary<KeyboardType, KeyboardOverrideConfig> m_configs; // 0x20
		private KeyboardType m_keyboardType; // 0x28
	
		// Constructors
		static KeyboardHandler() {} // 0x0000000183A5D2F0-0x0000000183A60550
		public KeyboardHandler() {} // 0x0000000183A60550-0x0000000183A61560
	
		// Methods
		public static bool GetKey(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x0000000183A5A310-0x0000000183A5AC90
		public static bool GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x0000000183A59010-0x0000000183A59990
		public static bool GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x0000000183A59990-0x0000000183A5A310
		public void ParseConfig(KeyboardLocalizeConfig keyboardConfig) {} // 0x0000000183A5B300-0x0000000183A5BF60
		public KeyboardType GetKeyboardType() => default; // 0x0000000183A5AC90-0x0000000183A5B300
		public void SetKeyboardType(KeyboardType keyboardType) {} // 0x0000000183A5BF60-0x0000000183A5D2F0
		public string GetEscIconName() => default; // 0x0000000183A57E60-0x0000000183A58160
		public string GetIconNameByKeyName(string keyName) => default; // 0x0000000183A58160-0x0000000183A58760
		public string GetIconName(Beyond.Input.KeyboardKeyCode keyCode) => default; // 0x0000000183A58760-0x0000000183A59010
	}

	public class KeyboardLocalizeConfig : ScriptableObject // TypeDefIndex: 56414
	{
		// Fields
		public const string KEYBOARD_CONFIG_PATH = "Assets/@Options/KeyboardLocalizeConfig.asset"; // Metadata: 0x0207CAFF
		public KeyboardOverrideConfig[] keyboardConfigs; // 0x18
	
		// Constructors
		public KeyboardLocalizeConfig() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	[Serializable]
	public class KeyboardOverrideConfig // TypeDefIndex: 56415
	{
		// Fields
		public KeyboardType keyboardType; // 0x10
		public KeyboardOverrideIconConfig[] overrideIconConfigs; // 0x18
	
		// Constructors
		public KeyboardOverrideConfig() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class KeyboardOverrideIconConfig // TypeDefIndex: 56416
	{
		// Fields
		public Beyond.Input.KeyboardKeyCode keyCode; // 0x10
		public string keyName; // 0x18
		public string iconName; // 0x20
	
		// Constructors
		public KeyboardOverrideIconConfig() {} // 0x0000000185492010-0x0000000185492020
	}

	public class PlayerActionIdAttribute : Attribute // TypeDefIndex: 56417
	{
		// Constructors
		public PlayerActionIdAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum InputDeviceFlags : byte // TypeDefIndex: 56418
	{
		None = 0,
		Keyboard = 1,
		Gamepad = 2,
		All = 3
	}

	[Serializable]
	public class PlayerActionInfo // TypeDefIndex: 56419
	{
		// Fields
		public bool isCommonOpenUIAction; // 0x10
		public KeyboardInput primaryKeyboardInput; // 0x18
		public GamepadInput primaryGamepadInput; // 0x20
		public int priority; // 0x28
		public bool needShowControllerHint; // 0x2C
		public int controllerHintPriority; // 0x30
		public string overrideTextId; // 0x38
		public bool needSecond; // 0x40
		public bool hideSecondInKeyHint; // 0x41
		public KeyboardInput secondaryKeyboardInput; // 0x48
		public GamepadInput secondaryGamepadInput; // 0x50
	
		// Constructors
		public PlayerActionInfo() {} // 0x0000000181B9A230-0x0000000181B9A240
	
		// Methods
		public void ResetHintProority() {} // 0x000000018A9C5114-0x000000018A9C5200
		public bool DeviceInputEquals(PlayerActionInfo other, InputDeviceFlags deviceFlags = InputDeviceFlags.All /* Metadata: 0x0207CB30 */) => default; // 0x000000018A9C500C-0x000000018A9C5114
		public void DeviceInputCopyFrom(PlayerActionInfo other, InputDeviceFlags deviceFlags = InputDeviceFlags.All /* Metadata: 0x0207CB31 */) {} // 0x000000018A9C4F30-0x000000018A9C500C
	}

	[Serializable]
	public abstract class DeviceInput<T> : IEquatable<T> // TypeDefIndex: 56420
		where T : DeviceInput<T>
	{
		// Fields
		public InputTimingType timingType;
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
	public class KeyboardInput : DeviceInput<KeyboardInput> // TypeDefIndex: 56421
	{
		// Fields
		public Beyond.Input.KeyboardKeyCode key; // 0x30
		public bool useCtrl; // 0x34
		public bool useShift; // 0x35
		public bool useAlt; // 0x36
	
		// Properties
		public string modifyString { get => default; } // 0x000000018A9C4E54-0x000000018A9C4F30 
	
		// Constructors
		public KeyboardInput() {} // 0x000000018524A610-0x000000018524A650
	
		// Methods
		public override string GetModifyText() => default; // 0x000000018A9C4CC8-0x000000018A9C4DCC
		public override string GetKeyCodeText() => default; // 0x000000018A9C4A78-0x000000018A9C4CC8
		public override int GetKeyCodeEnumIntValue() => default; // 0x000000018A9C4A2C-0x000000018A9C4A78
		public override void SetKeyCodeEnumByIntValue(int value) {} // 0x000000018A9C4DCC-0x000000018A9C4E24
		public override void ClearKeyCode() {} // 0x000000018A9C48C8-0x000000018A9C4924
		public override bool IsValid() => default; // 0x0000000185EDC180-0x0000000185EDC1B0
		public override void CopyFrom(KeyboardInput other) {} // 0x000000018A9C4924-0x000000018A9C49C4
		public override bool Equals(KeyboardInput other) => default; // 0x000000018A9C49C4-0x000000018A9C4A2C
		public string __iFixBaseProxy_GetModifyText() => default; // 0x000000018A9C4E3C-0x000000018A9C4E44
		public string __iFixBaseProxy_GetKeyCodeText() => default; // 0x000000018A9C4E34-0x000000018A9C4E3C
		public int __iFixBaseProxy_GetKeyCodeEnumIntValue() => default; // 0x000000018A9C4E2C-0x000000018A9C4E34
		public void __iFixBaseProxy_SetKeyCodeEnumByIntValue(int P0) {} // 0x000000018A9C4E4C-0x000000018A9C4E54
		public void __iFixBaseProxy_ClearKeyCode() {} // 0x000000018A9C4E24-0x000000018A9C4E2C
		public bool __iFixBaseProxy_IsValid() => default; // 0x000000018A9C4E44-0x000000018A9C4E4C
	}

	[Serializable]
	public class GamepadInput : DeviceInput<GamepadInput> // TypeDefIndex: 56422
	{
		// Fields
		public GamepadKeyCode key; // 0x30
		public GamepadKeyCode modifyKey; // 0x34
	
		// Constructors
		public GamepadInput() {} // 0x000000018524A650-0x000000018524A690
	
		// Methods
		public override string GetModifyText() => default; // 0x000000018A9C46B4-0x000000018A9C475C
		public override string GetKeyCodeText() => default; // 0x000000018A9C462C-0x000000018A9C46B4
		public override int GetKeyCodeEnumIntValue() => default; // 0x000000018A9C45E0-0x000000018A9C462C
		public override void SetKeyCodeEnumByIntValue(int value) {} // 0x000000018A9C47AC-0x000000018A9C4804
		public override void ClearKeyCode() {} // 0x000000018A9C44EC-0x000000018A9C454C
		public override bool IsValid() => default; // 0x000000018A9C475C-0x000000018A9C47AC
		public override void CopyFrom(GamepadInput other) {} // 0x000000018A9C454C-0x000000018A9C45E0
		public override bool Equals(GamepadInput other) => default; // 0x000000018420B680-0x000000018420B6D0
		public string __iFixBaseProxy_GetModifyText() => default; // 0x000000018A9C481C-0x000000018A9C4824
		public string __iFixBaseProxy_GetKeyCodeText() => default; // 0x000000018A9C4814-0x000000018A9C481C
		public int __iFixBaseProxy_GetKeyCodeEnumIntValue() => default; // 0x000000018A9C480C-0x000000018A9C4814
		public void __iFixBaseProxy_SetKeyCodeEnumByIntValue(int P0) {} // 0x000000018A9C482C-0x000000018A9C4834
		public void __iFixBaseProxy_ClearKeyCode() {} // 0x000000018A9C4804-0x000000018A9C480C
		public bool __iFixBaseProxy_IsValid() => default; // 0x000000018A9C4824-0x000000018A9C482C
	}

	internal struct CursorRequest // TypeDefIndex: 56423
	{
		// Fields
		public string key; // 0x00
		public int priority; // 0x08
		public bool show; // 0x0C
	
		// Methods
		public override string ToString() => default; // 0x0000000183A32FB0-0x0000000183A33B80
		public string __iFixBaseProxy_ToString() => default; // 0x0000000183A33B80-0x0000000183A33EB0
	}

	internal static class CursorPriority // TypeDefIndex: 56424
	{
		// Fields
		public const int DEVICE_CHANGE_OVERRIDE = 0; // Metadata: 0x0207CB32
		public const int CONTROLLER_HIDE = 10; // Metadata: 0x0207CB33
		public const int EDITOR_DEBUG_FORCE_SHOW = 20; // Metadata: 0x0207CB34
		public const int SHOW_REQUEST = 100; // Metadata: 0x0207CB35
	}

	internal class RealCursorManager // TypeDefIndex: 56425
	{
		// Fields
		private Dictionary<string, CursorRequest> m_requests; // 0x10
		private CursorRequest m_activeHighest; // 0x18
		private bool m_isUsingVirtualMouse; // 0x28
	
		// Properties
		public bool isDebugForceShow { get => default; } // 0x0000000183A68FD0-0x0000000183A6C770 
	
		// Constructors
		public RealCursorManager() {} // 0x0000000185589220-0x00000001855892A0
	
		// Methods
		public bool HasAnyShowRequestAtPriority(int priority) => default; // 0x0000000183A632C0-0x0000000183A64400
		public void SetRequest(string key, int priority, bool show) {} // 0x0000000183A66D00-0x0000000183A677B0
		public void RemoveRequest(string key) {} // 0x0000000183A663A0-0x0000000183A66D00
		public void RemoveAllRequestsAtPriority(int priority) {} // 0x0000000183A64400-0x0000000183A663A0
		public void SetVirtualMouseActive(bool active) {} // 0x0000000183A677B0-0x0000000183A67E50
		public void CalcState(bool forceUpdate = false /* Metadata: 0x0207CB37 */) {} // 0x00000001855892A0-0x0000000185589C00
		private void _RefreshActiveHighest() {} // 0x0000000183A67E50-0x0000000183A68FD0
		private void _ToggleCursorInternal(bool enable, bool forceUpdate = false /* Metadata: 0x0207CB38 */) {} // 0x0000000185589C00-0x000000018558AB60
		public string DumpState() => default; // 0x0000000183A61560-0x0000000183A632C0
	}

	public class TextIdAttribute : Attribute // TypeDefIndex: 56426
	{
		// Constructors
		public TextIdAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class UIEvent : UnityEvent, IBindingTarget // TypeDefIndex: 56427
	{
		// Fields
		private bool m_bindingInit; // 0x30
		public bool useBindingAction; // 0x31
		public string playerActionId; // 0x38
		public PlayerActionInfo anonymousPlayerActionInfo; // 0x40
		[NonSerialized]
		public string anonymousPlayerActionId; // 0x48
		private int _bindingId_k__BackingField; // 0x50
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x58
		private Action m_bindAct; // 0x60
		private Action m_onUpdateKeyAct; // 0x68
		private List<UnityAction> m_calls; // 0x70
	
		// Properties
		public bool bindingEnabled { get => default; } // 0x000000018A9C59FC-0x000000018A9C5AA4 
		public int bindingId { get; private set; } // 0x0000000185FB0680-0x0000000185FB0690 0x0000000185FB06B0-0x0000000185FB06C0
		public IBindingGroupTarget parentTarget { get; private set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public int count { get => default; } // 0x000000018A9C5AA4-0x000000018A9C5AE4 
	
		// Constructors
		public UIEvent() {} // 0x000000018A9C59EC-0x000000018A9C59FC
	
		// Methods
		private void _CreatePlayerActionBinding() {} // 0x000000018A9C58B8-0x000000018A9C59EC
		public void InitBinding(IBindingGroupTarget parent, Action bindAct, Action onUpdateKeyAct) {} // 0x000000018A9C53E8-0x000000018A9C54C0
		public new void Invoke() {} // 0x000000018A9C54C0-0x000000018A9C5590
		public void UpdateKeys() {} // 0x000000018A9C5818-0x000000018A9C58B8
		public void ChangeBindingPlayerAction(string actionId) {} // 0x000000018A9C537C-0x000000018A9C53E8
		public new void AddListener(UnityAction call) {} // 0x000000018A9C522C-0x000000018A9C537C
		public new void RemoveListener(UnityAction call) {} // 0x000000018A9C5748-0x000000018A9C5818
		public new void RemoveAllListeners() {} // 0x000000018A9C5590-0x000000018A9C5748
	}

	[Serializable]
	public class UIEvent<T0> : UnityEvent<T0>, IBindingTarget // TypeDefIndex: 56428
	{
		// Fields
		private bool m_bindingInit;
		public bool useBindingAction;
		public string playerActionId;
		public PlayerActionInfo anonymousPlayerActionInfo;
		[NonSerialized]
		public string anonymousPlayerActionId;
		public bool useAnonymousAction;
		[NonSerialized]
		public bool tempForceEnable;
		private int _bindingId_k__BackingField;
		private IBindingGroupTarget _parentTarget_k__BackingField;
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
	public class UIEvent<T0, T1> : UnityEvent<T0, T1>, IBindingTarget // TypeDefIndex: 56429
	{
		// Fields
		private bool m_bindingInit;
		public bool useBindingAction;
		public string playerActionId;
		public PlayerActionInfo anonymousPlayerActionInfo;
		[NonSerialized]
		public string anonymousPlayerActionId;
		private int _bindingId_k__BackingField;
		private IBindingGroupTarget _parentTarget_k__BackingField;
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
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 56361
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 56362
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 56363
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 56364
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 56365
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 56358
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 56432
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64A20-0x0000000185F64A90
	
		// Methods
		public bool __Gen_Wrap_0(object P0) => default; // 0x000000018735B960-0x000000018735BA30
		public uint __Gen_Wrap_1() => default; // 0x000000018735B550-0x000000018735B5FC
		public void __Gen_Wrap_2(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public void __Gen_Wrap_3(object P0, object P1) {} // 0x00000001815704E0-0x0000000181570890
		public void __Gen_Wrap_4(object P0, bool P1, bool P2) {} // 0x000000018203EF20-0x000000018203F220
		public void __Gen_Wrap_5(object P0, bool P1) {} // 0x0000000181570FE0-0x00000001815712C0
		public void __Gen_Wrap_6(object P0, int P1, bool P2) {} // 0x0000000181F2E230-0x0000000181F2E520
		public void __Gen_Wrap_7(object P0, NavigationBindingType P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public bool __Gen_Wrap_8(object P0, int P1) => default; // 0x0000000181551EC0-0x00000001815521B0
		public void __Gen_Wrap_9(object P0, object P1, bool P2) {} // 0x0000000181570C20-0x0000000181570FE0
		public bool __Gen_Wrap_10(object P0, object P1, object P2) => default; // 0x00000001816ADC00-0x00000001816AE0A0
		public Vector3 __Gen_Wrap_11(object P0, NaviDirection P1) => default; // 0x0000000183A3BFA0-0x0000000183A3C8A0
		public Vector3 __Gen_Wrap_12(object P0, Vector2 P1) => default; // 0x0000000183A3C8A0-0x0000000183A3D510
		public Selectable __Gen_Wrap_13(object P0, object P1, Vector3 P2, Vector3 P3, NaviStrategy P4, double P5, out double P6) {
			P6 = default;
			return default;
		} // 0x0000000183A3D510-0x0000000183A3E290
		public Selectable __Gen_Wrap_14(object P0, object P1, Vector3 P2, Vector3 P3, double P4, out double P5) {
			P5 = default;
			return default;
		} // 0x0000000183A3E290-0x0000000183A3EFF0
		public bool __Gen_Wrap_15(object P0, NaviDirection P1) => default; // 0x0000000181889FD0-0x000000018188A2B0
		public LinkedListNode<SelectableNaviGroup> __Gen_Wrap_16(object P0, object P1) => default; // 0x0000000183A3EFF0-0x0000000183A3FA10
		public bool __Gen_Wrap_17(object P0, object P1) => default; // 0x00000001815D5950-0x00000001815D5D10
		public void __Gen_Wrap_18(object P0, object P1, NavigationBindingType P2) {} // 0x00000001815A0BB0-0x00000001815A0F50
		public SelectableNaviGroup __Gen_Wrap_19(object P0) => default; // 0x0000000183A3FA10-0x0000000183A40340
		public void __Gen_Wrap_20(object P0, object P1, object P2, object P3) {} // 0x0000000183A40340-0x0000000183A40860
		public void __Gen_Wrap_21(object P0, NaviDirection P1) {} // 0x000000018155EB40-0x000000018155EE10
		public DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __Gen_Wrap_22(object P0) => default; // 0x0000000183A40860-0x0000000183A41190
		public DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>>> __Gen_Wrap_23(object P0) => default; // 0x0000000183A41190-0x0000000183A41AC0
		public DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __Gen_Wrap_24(object P0, object P1) => default; // 0x0000000183A41AC0-0x0000000183A424F0
		public GamepadCheckerBase.Binding __Gen_Wrap_25(object P0, object P1, object P2, bool P3) => default; // 0x0000000183A424F0-0x0000000183A43040
		public GamepadCheckerBase.Binding __Gen_Wrap_26(object P0, object P1, object P2) => default; // 0x0000000183A43040-0x0000000183A43B60
		public void __Gen_Wrap_27(object P0, object P1, GamepadKeyCode P2) {} // 0x00000001815A0BB0-0x00000001815A0F50
		public void __Gen_Wrap_28() {} // 0x0000000183A43B60-0x0000000183A43D30
		public void __Gen_Wrap_29(object P0, InputContinuousTriggerType P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public IBindingView __Gen_Wrap_30(object P0) => default; // 0x0000000183A43D30-0x0000000183A44670
		public void __Gen_Wrap_31(object P0, GamepadKeyCode P1) {} // 0x000000018155EB40-0x000000018155EE10
		public PlayerActionInfo __Gen_Wrap_32(object P0, object P1, InputSettingLevel P2) => default; // 0x0000000183A44670-0x0000000183A450D0
		public string __Gen_Wrap_33(object P0, object P1) => default; // 0x0000000183A450D0-0x0000000183A45B00
		public string __Gen_Wrap_34(object P0) => default; // 0x0000000183A45B00-0x0000000183A46440
		public Action __Gen_Wrap_35(object P0, object P1, GamepadKeyCode P2) => default; // 0x0000000183A46440-0x0000000183A46E90
		public float __Gen_Wrap_36(object P0, object P1, int P2) => default; // 0x00000001823B9F10-0x00000001823BA2E0
		public bool __Gen_Wrap_37(GamepadKeyCode P0) => default; // 0x000000018139FD70-0x000000018139FF70
		public void __Gen_Wrap_38(InputActionProperty P0, object P1, bool P2) {} // 0x0000000183A46E90-0x0000000183A47530
		public void __Gen_Wrap_39(ref InputActionProperty P0, InputActionProperty P1) {} // 0x0000000183A47530-0x0000000183A48230
		public void __Gen_Wrap_40(object P0, InputActionProperty P1) {} // 0x0000000183A48230-0x0000000183A488A0
		public void __Gen_Wrap_41(object P0, UnityEngine.InputSystem.InputAction.CallbackContext P1) {} // 0x0000000183A488A0-0x0000000183A48F10
		public int __Gen_Wrap_42(object P0, int P1, object P2) => default; // 0x000000018220F750-0x000000018220FB30
		public int __Gen_Wrap_43(object P0) => default; // 0x0000000181375C70-0x0000000181375F30
		public KeyboardCheckerBase.Binding __Gen_Wrap_44(object P0, object P1, object P2, bool P3) => default; // 0x0000000183A48F10-0x0000000183A49A60
		public void __Gen_Wrap_45(object P0, object P1, object P2) {} // 0x00000001816167B0-0x0000000181616C40
		public int __Gen_Wrap_46(object P0, object P1, object P2, int P3) => default; // 0x0000000183A49A60-0x0000000183A49F20
		public bool __Gen_Wrap_47(Selectable P0) => default; // 0x00000001813541F0-0x00000001813544C0
		public Selectable __Gen_Wrap_48(object P0) => default; // 0x0000000183A49F20-0x0000000183A4A850
		public KeyboardCheckerBase.Binding __Gen_Wrap_49(object P0, object P1, object P2) => default; // 0x0000000183A4A850-0x0000000183A4B370
		public void __Gen_Wrap_50(object P0, int P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public object __Gen_Wrap_51(object P0) => default; // 0x0000000183A4B370-0x0000000183A4BCA0
		public bool __Gen_Wrap_52() => default; // 0x000000018138FF00-0x00000001813900C0
		public Vector2 __Gen_Wrap_53(object P0, bool P1, bool P2) => default; // 0x0000000183A4BCA0-0x0000000183A4C5D0
		public Vector2 __Gen_Wrap_54() => default; // 0x0000000183A4C5D0-0x0000000183A4CDE0
		public void __Gen_Wrap_55(bool P0) {} // 0x0000000181390A70-0x0000000181390C60
		public void __Gen_Wrap_56(object P0, object P1, int P2, bool P3) {} // 0x00000001815DD690-0x00000001815DDA70
		public void __Gen_Wrap_57(Beyond.DeviceInfo.InputType P0) {} // 0x0000000181389D90-0x0000000181389F80
		public void __Gen_Wrap_58(object P0, Beyond.DeviceInfo.InputType P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public void __Gen_Wrap_59(object P0, KeyboardType P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public Dictionary<string, HashSet<int>> __Gen_Wrap_60(object P0) => default; // 0x0000000183A4CDE0-0x0000000183A4D720
		public void __Gen_Wrap_61(object P0, float P1) {} // 0x0000000181362020-0x0000000181362300
		public void __Gen_Wrap_62(object P0, Beyond.Input.KeyboardKeyCode P1) {} // 0x000000018155EB40-0x000000018155EE10
		public void __Gen_Wrap_63(Beyond.Input.KeyboardKeyCode P0) {} // 0x0000000181355200-0x00000001813553F0
		public void __Gen_Wrap_64(GamepadKeyCode P0) {} // 0x0000000181355200-0x00000001813553F0
		public Beyond.DeviceInfo.ControllerType __Gen_Wrap_65(object P0, object P1) => default; // 0x000000018135A390-0x000000018135A720
		public string __Gen_Wrap_66(GamepadKeyCode P0) => default; // 0x0000000183A4D720-0x0000000183A4DFA0
		public string __Gen_Wrap_67() => default; // 0x0000000183A4DFA0-0x0000000183A4E7E0
		public string __Gen_Wrap_68(object P0, object P1, bool P2, bool P3) => default; // 0x0000000183A4E7E0-0x0000000183A4F260
		public string __Gen_Wrap_69(object P0, bool P1, bool P2) => default; // 0x0000000183A4F260-0x0000000183A4FBF0
		public string __Gen_Wrap_70(object P0, bool P1, bool P2, bool P3) => default; // 0x0000000183A4FBF0-0x0000000183A505A0
		public float __Gen_Wrap_71(object P0, bool P1) => default; // 0x0000000183A505A0-0x0000000183A50890
		public void __Gen_Wrap_72(object P0, in EventData<bool> P1) {} // 0x0000000183A50890-0x0000000183A50F30
		public bool __Gen_Wrap_73(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2) {
			P2 = default;
			return default;
		} // 0x000000018252FE10-0x00000001825301E0
		public bool __Gen_Wrap_74(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2, out bool P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x0000000183A50F30-0x0000000183A51340
		public bool __Gen_Wrap_75(object P0, GamepadKeyCode P1, Beyond.Input.InputManager.KeyCodeState P2) => default; // 0x00000001815E6DF0-0x00000001815E7100
		public int __Gen_Wrap_76(object P0, object P1, object P2, int P3, out string P4) {
			P4 = default;
			return default;
		} // 0x0000000183A51340-0x0000000183A51EF0
		public int __Gen_Wrap_77(object P0, Beyond.Input.KeyboardKeyCode P1, object P2, InputTimingType P3, object P4, int P5) => default; // 0x0000000183A51EF0-0x0000000183A523A0
		public bool __Gen_Wrap_78(object P0, int P1, bool P2) => default; // 0x0000000181872B60-0x0000000181872E70
		public void __Gen_Wrap_79(object P0, int P1, object P2) {} // 0x0000000181391570-0x0000000181391940
		public void __Gen_Wrap_80(object P0, bool P1, int P2, int P3) {} // 0x0000000183A523A0-0x0000000183A526C0
		public int __Gen_Wrap_81(object P0, bool P1, int P2) => default; // 0x0000000183A526C0-0x0000000183A529C0
		public Beyond.Input.KeyboardKeyCode __Gen_Wrap_82(object P0, object P1, bool P2, bool P3, InputSettingLevel P4) => default; // 0x00000001825A18D0-0x00000001825A1CE0
		public GamepadKeyCode __Gen_Wrap_83(object P0, object P1, bool P2, bool P3, InputSettingLevel P4) => default; // 0x00000001825A18D0-0x00000001825A1CE0
		public bool __Gen_Wrap_84(InputDeviceFlags P0, InputDeviceFlags P1) => default; // 0x0000000181678660-0x0000000181678890
		public bool __Gen_Wrap_85(object P0, object P1, InputDeviceFlags P2) => default; // 0x000000018173B7E0-0x000000018173BBB0
		public void __Gen_Wrap_86(object P0, object P1, InputDeviceFlags P2) {} // 0x0000000181570C20-0x0000000181570FE0
		public void __Gen_Wrap_87(object P0, InputDeviceFlags P1) {} // 0x0000000181570FE0-0x00000001815712C0
		public string __Gen_Wrap_88(object P0, int P1) => default; // 0x0000000183A529C0-0x0000000183A53320
		public bool __Gen_Wrap_89(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, out bool P3) {
			P3 = default;
			return default;
		} // 0x0000000183A53320-0x0000000183A53700
		public float __Gen_Wrap_90(object P0, object P1) => default; // 0x0000000183A53700-0x0000000183A53AB0
		public void __Gen_Wrap_91(object P0, int P1, out string P2, out IBindingView P3) {
			P2 = default;
			P3 = default;
		} // 0x0000000183A53AB0-0x0000000183A547F0
		public PlayerActionInfo __Gen_Wrap_92(object P0, object P1) => default; // 0x0000000183A547F0-0x0000000183A55220
		public bool __Gen_Wrap_93(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, bool P3, object P4) => default; // 0x0000000183A55220-0x0000000183A55720
		public bool __Gen_Wrap_94(object P0, object P1, GamepadKeyCode? P2, GamepadKeyCode? P3, bool P4, object P5) => default; // 0x0000000183A55720-0x0000000183A560D0
		public Vector3 __Gen_Wrap_95() => default; // 0x0000000183A560D0-0x0000000183A568E0
		public void __Gen_Wrap_96(Vector2 P0, bool P1) {} // 0x0000000183A568E0-0x0000000183A56EB0
		public void __Gen_Wrap_97(object P0, Vector2 P1) {} // 0x0000000183A56EB0-0x0000000183A57530
		public bool __Gen_Wrap_98(int P0) => default; // 0x0000000181388120-0x0000000181388320
		public List<Beyond.Input.InputManager.ControllerHintInfo> __Gen_Wrap_99(object P0) => default; // 0x0000000183A57530-0x0000000183A57E60
		public void __Gen_Wrap_100(object P0, object P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3) {} // 0x0000000183A33EB0-0x0000000183A34A60
		public void __Gen_Wrap_101(object P0, int P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3) {} // 0x0000000183A34A60-0x0000000183A35530
		public void __Gen_Wrap_102(object P0, object P1, ref List<Beyond.Input.InputManager.ControllerHintInfo> P2) {} // 0x0000000183A35530-0x0000000183A360C0
		public float __Gen_Wrap_103(object P0, object P1, out float P2) {
			P2 = default;
			return default;
		} // 0x0000000183A360C0-0x0000000183A364D0
		public float __Gen_Wrap_104(object P0, int P1, out float P2) {
			P2 = default;
			return default;
		} // 0x0000000181F63360-0x0000000181F636A0
		public void __Gen_Wrap_105(object P0, float P1, float P2) {} // 0x00000001817989E0-0x0000000181798CE0
		public string __Gen_Wrap_106(Beyond.Input.KeyboardKeyCode P0) => default; // 0x0000000183A364D0-0x0000000183A36D50
		public string __Gen_Wrap_107(System.Text.RegularExpressions.Match P0) => default; // 0x0000000183A36D50-0x0000000183A37680
		public void __Gen_Wrap_108(object P0, object P1, object P2, bool P3) {} // 0x000000018154F3D0-0x000000018154F840
		public bool __Gen_Wrap_109(int P0, out Vector2 P1) {
			P1 = default;
			return default;
		} // 0x0000000183A37680-0x0000000183A37F50
		public GameObject __Gen_Wrap_110(object P0, object P1) => default; // 0x0000000183A37F50-0x0000000183A38970
		public string __Gen_Wrap_111(object P0, Beyond.Input.KeyboardKeyCode P1, bool P2) => default; // 0x0000000183A38970-0x0000000183A39330
		public string __Gen_Wrap_112(object P0, GamepadKeyCode P1, bool P2) => default; // 0x0000000183A39330-0x0000000183A39CF0
		public string __Gen_Wrap_113(object P0, object P1, bool P2, bool P3, bool P4) => default; // 0x0000000183A39CF0-0x0000000183A3A780
		public int __Gen_Wrap_114(object P0, object P1) => default; // 0x000000018135A390-0x000000018135A720
		public List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>>> __Gen_Wrap_115(object P0) => default; // 0x0000000183A3A780-0x0000000183A3B0B0
		public void __Gen_Wrap_116(object P0, object P1, Beyond.Input.KeyboardKeyCode P2) {} // 0x00000001815A0BB0-0x00000001815A0F50
		public KeyboardType __Gen_Wrap_117(object P0) => default; // 0x00000001815570F0-0x00000001815573B0
		public string __Gen_Wrap_118(ref CursorRequest P0) => default; // 0x0000000183A3B0B0-0x0000000183A3BFA0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 56433
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018A9C4834-0x000000018A9C48C8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 56434
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018A9C5CCC-0x000000018A9C5D30
		public static bool IsPatched(int id) => default; // 0x000000018443B060-0x000000018443B0D0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018A9C5B88-0x000000018A9C5C54
		public object CreateWrapper(int id) => default; // 0x000000018A9C5C54-0x000000018A9C5CCC
		public object InitWrapperArray(int len) => default; // 0x000000018A9C5D30-0x000000018AA46078
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018A9C5AE4-0x000000018A9C5B88
	}

	public enum IDMAP0 // TypeDefIndex: 56435
	{
		Beyond-Input-ControllerNaviManager-SetNaviBindingType0 = 0,
		Beyond-Input-InputManager-ToggleGroup0 = 3,
		Beyond-Input-InputBindingGroup-SetSelfEnabled0 = 5,
		Beyond-Input-InputBindingGroup-_OnBindingGroupStateChanged0 = 8,
		Beyond-Input-InputBindingGroup-get_enabled0 = 9,
		Beyond-Input-InputBindingInfo-OnGroupEnabledChanged0 = 12,
		Beyond-Input-InputBindingInfo-_GetNextEnabledPriority0 = 16,
		Beyond-Input-InputBindingInfo-StopContinuousTrigger0 = 18,
		Beyond-Input-InputManager-CancelPendingLongPress0 = 19,
		Beyond-Input-KeyboardOnLongPressChecker-CancelPendingLongPress0 = 20,
		Beyond-Input-GamepadOnLongPressChecker-CancelPendingLongPress0 = 21,
		Beyond-Input-InputBindingGroup-OnParentEnabledChanged0 = 23,
		Beyond-Input-ControllerNaviManager-Tick0 = 25,
		Beyond-Input-ControllerNaviManager-UpdateNaviInputBindingState0 = 26,
		Beyond-Input-InputManager-IsGroupEnabled0 = 28,
		Beyond-Input-ControllerNaviManager-IsNavigationBindingEnabled0 = 29,
		Beyond-Input-ControllerNaviManager-_RemoveLayer0 = 30,
		Beyond-Input-ControllerNaviManager-_RemoveLayerFromStack0 = 31,
		Beyond-Input-ControllerNaviManager-_SetTarget0 = 32,
		Beyond-Input-ControllerNaviManager-_OnLayerSelected0 = 33,
		Beyond-Input-ControllerNaviManager-_DefaultNavigate0 = 34,
		Beyond-Input-ControllerNaviManager-GetNaviVector0 = 35,
		Beyond-Input-ControllerNaviManager-_GetPointOnRectEdge0 = 36,
		Beyond-Input-ControllerNaviManager-_TryFindBestNaviTarget0 = 37,
		Beyond-Input-ControllerNaviManager-_TryFindBestNaviTargetInGroup0 = 38,
		Beyond-Input-ControllerNaviManager-SetTarget0 = 39,
		Beyond-Input-ControllerNaviManager-_GetDummyLayerLastGroupInStack0 = 40,
		Beyond-Input-ControllerNaviManager-SetForceEnableNavi0 = 41,
		Beyond-Input-ControllerNaviManager-TryRemoveLayer0 = 43,
		Beyond-Input-ControllerNaviManager-TryAutoSetTarget0 = 44,
		Beyond-Input-ControllerNaviManager-IsLayerInStack0 = 45,
		Beyond-Input-ControllerNaviManager-IsTopLayer0 = 46,
		Beyond-Input-ControllerNaviManager-ChangeAndTrySetNaviBindingType0 = 47,
		Beyond-Input-ControllerNaviManager-GetTopDummyLayerGroup0 = 48,
		Beyond-Input-ControllerNaviManager-ResetStateForUIDispose0 = 49,
		Beyond-Input-ControllerNaviManager-SetTargetInSilentModeIfNecessary0 = 50,
		Beyond-Input-ControllerNaviManager-IsNaviTarget0 = 51,
		Beyond-Input-ControllerNaviManager-Navigate0 = 52,
		Beyond-Input-ControllerNaviManager-ToggleNavigation0 = 53,
		Beyond-Input-GamepadCheckerBase-get_normalBindingInfos0 = 54,
		Beyond-Input-GamepadCheckerBase-get_modifyBindingInfos0 = 55,
		Beyond-Input-GamepadCheckerBase-OnCreateBinding0 = 56,
		Beyond-Input-GamepadCheckerBase-GetInputDic0 = 57,
		Beyond-Input-GamepadCheckerBase-OnDeleteBinding0 = 58,
		Beyond-Input-GamepadCheckerBase-CheckGamepadInput0 = 59,
		Beyond-Input-GamepadCheckerBase-CheckDic0 = 60,
		Beyond-Input-GamepadCheckerBase-TriggerActions0 = 61,
		Beyond-Input-InputBindingInfo-Trigger0 = 62,
		Beyond-Input-InputBindingInfo-_RealTriggerCallback0 = 63,
		Beyond-Input-InputBindingInfo-StartContinuousTrigger0 = 64,
		Beyond-Input-InputBindingInfo-_TryContinuousTrigger0 = 66,
		Beyond-Input-InputBindingInfo-get_enabled0 = 67,
		Beyond-Input-GamepadChecker-CheckDic0 = 71,
		Beyond-Input-GamepadOnClickChecker-CheckDic0 = 75,
		Beyond-Input-InputBindingInfo-get_bindingView0 = 76,
		Beyond-Input-InputBindingGroup-get_groupView0 = 78,
		Beyond-Input-GamepadOnClickChecker-ClearKeyPressed0 = 80,
		Beyond-Input-GamepadOnLongPressChecker-CreateTriggerBindingAction0 = 81,
		Beyond-Input-GamepadOnLongPressChecker-_OnTriggerBinding0 = 84,
		Beyond-Input-InputBindingInfo-get_text0 = 87,
		Beyond-Input-InputManager-GetActionText1 = 88,
		Beyond-Input-InputManager-GetPlayerActionInfo0 = 89,
		Beyond-Input-InputManager-GetActionText0 = 90,
		Beyond-Input-GamepadOnLongPressChecker-CheckDic0 = 91,
		Beyond-Input-GamepadOnLongPressChecker-OnCreateBinding0 = 92,
		Beyond-Input-GamepadOnLongPressChecker-OnDeleteBinding0 = 93,
		Beyond-Input-GamepadOnLongPressChecker-GetInputLongPressStartTime0 = 94,
		Beyond-Input-GamepadOnReleaseChecker-CheckGamepadInput0 = 95,
		Beyond-Input-GamepadOnReleaseChecker-CheckDic0 = 97,
		Beyond-Input-HGVirtualMouse-set_leftButtonAction0 = 98,
		Beyond-Input-HGVirtualMouse-_SetActionCallback0 = 99,
		Beyond-Input-HGVirtualMouse-_SetAction0 = 100,
		Beyond-Input-HGVirtualMouse-set_rightButtonAction0 = 101,
		Beyond-Input-HGVirtualMouse-set_middleButtonAction0 = 102,
		Beyond-Input-HGVirtualMouse-set_forwardButtonAction0 = 103,
		Beyond-Input-HGVirtualMouse-set_backButtonAction0 = 104,
		Beyond-Input-HGVirtualMouse-OnEnable0 = 105,
		Beyond-Input-HGVirtualMouse-SetMouseIconVisible0 = 106,
		Beyond-Input-HGVirtualMouse-_OnButtonActionTriggered0 = 109,
		Beyond-Input-InputManager-CreateGroup0 = 110,
		Beyond-Input-HGVirtualMouse-TriggerLeftButton0 = 112,
		Beyond-Input-InputManager-CreateBindingByActionId0 = 113,
		Beyond-Input-InputManager-_AddPlayerActionCheck2 = 114,
		Beyond-Input-InputManager-_AddPlayerActionCheck0 = 115,
		Beyond-Input-KeyboardCheckerBase-OnCreateBinding0 = 116,
		Beyond-Input-KeyboardCheckerBase-GetModifyIndex0 = 117,
		Beyond-Input-InputManager-_AddPlayerActionCheck1 = 118,
		Beyond-Input-HGVirtualMouse-ChangeHoverState0 = 120,
		Beyond-Input-HGVirtualMouse-_ChangeHoverState0 = 124,
		Beyond-Input-HGVirtualMouse-_SyncScale0 = 126,
		Beyond-Input-HGVirtualMouse-OnDisable0 = 127,
		Beyond-Input-HGVirtualMouse-_UpdateMotion0 = 128,
		Beyond-Input-HGVirtualMouse-ClearLeftButtonState0 = 129,
		Beyond-Input-HGVirtualMouse-OnAfterInputUpdate0 = 130,
		Beyond-Input-HGVirtualMouse-Update0 = 131,
		Beyond-Input-HGVirtualMouse-GetCurHoverSelectable0 = 133,
		Beyond-Input-HGVirtualMouse-OnDestroy0 = 134,
		Beyond-Input-InputManager-DeleteGroup0 = 135,
		Beyond-Input-InputManager-_DeleteGroup0 = 136,
		Beyond-Input-InputManager-_DeleteInGroup0 = 137,
		Beyond-Input-InputManager-_RealRemoveBindingInfo0 = 138,
		Beyond-Input-InputManager-_RemovePlayerActionCheck2 = 139,
		Beyond-Input-InputManager-_RemovePlayerActionCheck0 = 140,
		Beyond-Input-KeyboardCheckerBase-OnDeleteBinding0 = 141,
		Beyond-Input-InputManager-_RemovePlayerActionCheck1 = 142,
		Beyond-Input-InputBindingInfo-OnDelete0 = 143,
		Beyond-Input-HGVirtualMouse-Awake0 = 144,
		Beyond-Input-InputBindingInfo-ChangeGroup0 = 145,
		Beyond-Input-InputBindingInfo-SetSelfEnabled0 = 147,
		Beyond-Input-InputBindingInfo-SetParentIgnored0 = 149,
		Beyond-Input-InputBindingInfo-GetCallbackTarget0 = 151,
		Beyond-Input-InputBindingGroup-ChangeParent0 = 152,
		Beyond-Input-InputBindingGroup-SetParentIgnored0 = 154,
		Beyond-Input-InputBindingGroupMonoTarget-get_groupEnabled0 = 156,
		Beyond-Input-InputBindingGroupMonoTarget-Init0 = 157,
		Beyond-Input-InputBindingGroupMonoTarget-UpdateState0 = 160,
		Beyond-Input-InputBindingGroupMonoTarget-DeleteGroup0 = 161,
		Beyond-Input-InputBindingGroupMonoTarget-Awake0 = 162,
		Beyond-Input-InputBindingGroupMonoTarget-OnEnable0 = 163,
		Beyond-Input-InputBindingGroupMonoTarget-OnDisable0 = 164,
		Beyond-Input-InputBindingGroupMonoTarget-OnDestroy0 = 165,
		Beyond-Input-InputManager-get_cursorVisible0 = 166,
		Beyond-Input-InputManager-get_mouseScrollDelta0 = 169,
		Beyond-Input-InputManager-GetGamepadStickValue0 = 170,
		Beyond-Input-InputManager-get_multiTouchEnabled0 = 172,
		Beyond-Input-InputManager-set_multiTouchEnabled0 = 173,
		Beyond-Input-InputManager-set_usingController0 = 174,
		Beyond-Input-InputManager-_TryChangeInputDeviceType0 = 175,
		Beyond-Input-InputManager-ChangeInputTypeAndSyncState0 = 176,
		Beyond-Input-InputManager-_SyncUsingControllerState0 = 177,
		Beyond-Input-InputManager-_CheckVirtualMouseState0 = 179,
		Beyond-Input-RealCursorManager-HasAnyShowRequestAtPriority0 = 180,
		Beyond-Input-InputManager-_ToggleVirtualMouse0 = 181,
		Beyond-Input-RealCursorManager-SetVirtualMouseActive0 = 184,
		Beyond-Input-RealCursorManager-CalcState0 = 185,
		Beyond-Input-RealCursorManager-_ToggleCursorInternal0 = 186,
		Beyond-Input-InputManager-_RefreshDeviceChangeBinding0 = 187,
		Beyond-Input-InputManager-ToggleBinding0 = 188,
		Beyond-Input-RealCursorManager-SetRequest0 = 189,
		Beyond-Input-RealCursorManager-_RefreshActiveHighest0 = 190,
		Beyond-Input-RealCursorManager-RemoveRequest0 = 191,
		Beyond-Input-InputManager-_UpdateInputBindingMask0 = 192,
		Beyond-Input-InputManager-_SetInputBindingMask0 = 193,
		Beyond-Input-InputManager-SetCursorShowRequest0 = 194,
		Beyond-Input-InputManager-set_keyboardType0 = 195,
		Beyond-Input-KeyboardHandler-SetKeyboardType0 = 196,
		Beyond-Input-InputManager-get_action2BindingDic0 = 197,
		Beyond-Input-InputManager-LateTick0 = 198,
		Beyond-Input-InputManager-_UpdateControllerIndicator0 = 199,
		Beyond-Input-InputManager-TryClickSkillButtonWhenControllerIndicatorJustRelease0 = 200,
		Beyond-Input-InputManager-_Init0 = 201,
		Beyond-Input-InputManager-_CreateTickFunction0 = 202,
		Beyond-Input-KeyboardOnClickChecker-ClearKeyPressed0 = 204,
		Beyond-Input-InputManager-_LoadSetting0 = 206,
		Beyond-Input-KeyboardHandler-ParseConfig0 = 207,
		Beyond-Input-InputManager-_LoadCustomInputSetting0 = 208,
		Beyond-Input-InputManager-_OnControllerConnected0 = 209,
		Beyond-Input-InputManager-_IsValidJoystick0 = 211,
		Beyond-Input-InputManager-_SetJoystick0 = 212,
		Beyond-Input-InputManager-_GetControllerType0 = 217,
		Beyond-Input-InputManager-_OnControllerDisconnected0 = 218,
		Beyond-Input-InputManager-_TryFindGamepad0 = 219,
		Beyond-Input-InputManager-_CreateCanvas0 = 220,
		Beyond-Input-InputManager-_CreateDebugVirtualMouse0 = 225,
		Beyond-Input-InputManager-_CreateVirtualMouse0 = 228,
		Beyond-Input-InputManager-GetKeyIconPath0 = 235,
		Beyond-Input-InputManager-GetStringByGamepadKeyCode0 = 236,
		Beyond-Input-InputManager-GetGamepadKeyIconPath0 = 237,
		Beyond-Input-InputManager-_GetGamepadKeyIconFolderPath0 = 238,
		Beyond-Input-InputManager-_GetKeyIconPath0 = 239,
		Beyond-Input-InputManager-GetKeyIconPath2 = 240,
		Beyond-Input-InputManager-GetKeyIconPath1 = 241,
		Beyond-Input-InputManager-_InitDeviceChangeBinding0 = 242,
		Beyond-Input-InputManager-_OnAfterInputUpdate0 = 245,
		Beyond-Input-InputManager-KeyCaches-UpdateKeyStat0 = 246,
		Beyond-Input-InputManager-_CheckInput0 = 247,
		Beyond-Input-InputManager-CheckUsingController0 = 248,
		Beyond-Input-InputManager-AnyGamepadKey0 = 249,
		Beyond-Input-InputManager-GetGamepadTriggerValue0 = 250,
		Beyond-Input-InputManager-_CheckAnyKeyForTouchChangeDevice0 = 251,
		Beyond-Input-InputManager-_CheckAnyKeyForKeyboardChangeDevice0 = 252,
		Beyond-Input-InputManager-AnyMouseKeyUp0 = 253,
		Beyond-Input-InputManager-_AnyKeyDownForKeyboardChangeDevice0 = 254,
		Beyond-Input-KeyboardCheckerBase-CheckKeyboardInput0 = 255,
		Beyond-Input-KeyboardCheckerBase-TriggerActions0 = 256,
		Beyond-Input-InputManager-_ControllerTouchPanelTick0 = 257,
		Beyond-Input-InputManager-_TryStopDeviceSwitchSuppression0 = 260,
		Beyond-Input-InputManager-_OnNetMaskChanged0 = 261,
		Beyond-Input-InputManager-_OnFocusedInputFieldChanged0 = 262,
		Beyond-Input-InputManager-Release0 = 263,
		Beyond-Input-InputManager-_ClearTickFunction0 = 264,
		Beyond-Input-InputManager-OnApplicationQuit0 = 265,
		Beyond-Input-InputManager-_ClearEvents0 = 266,
		Beyond-Input-InputManager-OnApplicationFocus0 = 267,
		Beyond-Input-InputManager-set_autoUpdateInputBindingMask0 = 268,
		Beyond-Input-InputManager-ToggleInputDeviceChangeMode0 = 269,
		Beyond-Input-InputManager-ClearAllCursorShowRequests0 = 271,
		Beyond-Input-RealCursorManager-RemoveAllRequestsAtPriority0 = 272,
		Beyond-Input-InputManager-SetCursorOverrideForDeviceChange0 = 273,
		Beyond-Input-InputManager-AnyKeyboardKey0 = 274,
		Beyond-Input-InputManager-_AnyKeyboardKey0 = 275,
		Beyond-Input-InputManager-AnyMouseKeyDown0 = 276,
		Beyond-Input-InputManager-AnyMouseKey0 = 277,
		Beyond-Input-InputManager-AnyKeyDown0 = 278,
		Beyond-Input-InputManager-AnyTouchBegan0 = 279,
		Beyond-Input-InputManager-_CheckGamepadKeyCode0 = 280,
		Beyond-Input-InputManager-CreateBinding1 = 281,
		Beyond-Input-InputManager-AddAnonymousPlayerAction0 = 282,
		Beyond-Input-InputManager-CreateBinding0 = 283,
		Beyond-Input-InputManager-CreateBinding2 = 284,
		Beyond-Input-InputManager-DeleteBinding0 = 285,
		Beyond-Input-InputManager-DeleteInGroup0 = 286,
		Beyond-Input-InputManager-IsBindingEnabled0 = 287,
		Beyond-Input-InputManager-ForceBindingKeyhintToGray0 = 288,
		Beyond-Input-InputManager-IsBindingKeyhintGray0 = 289,
		Beyond-Input-InputManager-ToggleDebugCursorMode0 = 290,
		Beyond-Input-InputManager-ToggleAllInput0 = 291,
		Beyond-Input-InputManager-SetBindingView0 = 292,
		Beyond-Input-InputManager-SetGroupView0 = 293,
		Beyond-Input-InputManager-ChangeParent0 = 294,
		Beyond-Input-InputManager-GetGroupParentId0 = 295,
		Beyond-Input-InputManager-IgnoreBindingGroupParent0 = 296,
		Beyond-Input-InputManager-IgnoreBindingParent0 = 297,
		Beyond-Input-InputManager-GetActionKeyboardKeyCode0 = 298,
		Beyond-Input-InputManager-GetActionGamepadKeyCode0 = 299,
		Beyond-Input-InputManager-DeleteCustomBinding0 = 300,
		Beyond-Input-PlayerActionInfo-DeviceInputEquals0 = 301,
		Beyond-Input-InputUtils-HasFlag0 = 302,
		Beyond-Input-PlayerActionInfo-DeviceInputCopyFrom0 = 303,
		Beyond-Input-InputManager-DeleteAllCustomBindings0 = 304,
		Beyond-Input-InputManager-_RefreshControllerBattleButton0 = 305,
		Beyond-Input-InputManager-SetBindingText0 = 306,
		Beyond-Input-InputManager-GetBindingText0 = 307,
		Beyond-Input-InputManager-HasBinding0 = 308,
		Beyond-Input-InputManager-CheckActionKeyCodeConflict0 = 309,
		Beyond-Input-InputManager-GetAxis0 = 310,
		Beyond-Input-InputManager-GetBindingInfo0 = 311,
		Beyond-Input-InputManager-LoadSetting0 = 312,
		Beyond-Input-InputManager-IsPlayerActionIdValid0 = 313,
		Beyond-Input-InputManager-ChangePlayerAction0 = 314,
		Beyond-Input-InputManager-_GetOrCreatePendingActionInfo0 = 315,
		Beyond-Input-InputManager-CustomizeActionKey0 = 316,
		Beyond-Input-InputManager-CustomizeActionKey1 = 317,
		Beyond-Input-InputManager-ClearPendingInputSetting0 = 318,
		Beyond-Input-InputManager-SaveCustomInputSetting0 = 319,
		Beyond-Input-InputManager-GetMousePos0 = 320,
		Beyond-Input-InputManager-SetOnlyVirtualMousePos0 = 322,
		Beyond-Input-InputManager-SetMousePos0 = 323,
		Beyond-Input-InputManager-SetVirtualMouseIconVisible0 = 324,
		Beyond-Input-InputManager-GetMouseButton0 = 325,
		Beyond-Input-InputManager-IsLeftMouseDown0 = 326,
		Beyond-Input-InputManager-GetMouseButtonDown0 = 327,
		Beyond-Input-InputManager-GetMouseButtonUp0 = 328,
		Beyond-Input-InputManager-SetCustomControllerMouse0 = 329,
		Beyond-Input-InputManager-GetEmptyControllerHintInfoList0 = 332,
		Beyond-Input-InputManager-GetControllerHintInfos0 = 333,
		Beyond-Input-InputManager-_GetControllerHintInfos0 = 334,
		Beyond-Input-InputManager-ControllerHintInfo-Reset0 = 336,
		Beyond-Input-InputManager-GetControllerHintInfos1 = 338,
		Beyond-Input-InputManager-_GetControllerHintInfos1 = 339,
		Beyond-Input-InputManager-ControllerHintInfo-Reset1 = 340,
		Beyond-Input-InputManager-GetPlayerActionLongPressStartTime0 = 341,
		Beyond-Input-KeyboardOnLongPressChecker-GetInputLongPressStartTime0 = 342,
		Beyond-Input-InputManager-GetActionBindingLongPressStartTime0 = 343,
		Beyond-Input-InputManager-GetControllerIndicatorState0 = 344,
		Beyond-Input-InputManager-CheckNormalAttackBtn0 = 345,
		Beyond-Input-InputManager-TryPressControllerIndicatorWhenSkillButtonJustPressed0 = 346,
		Beyond-Input-InputManager-AddGuideUseActionId0 = 347,
		Beyond-Input-InputManager-RemoveGuideUseActionId0 = 348,
		Beyond-Input-InputManager-ClearGuideUseActionIds0 = 349,
		Beyond-Input-InputManager-VibrateController0 = 350,
		Beyond-Input-InputManager-GetStringByKeyboardKeyCode0 = 351,
		Beyond-Input-InputManager-GetKeyboardIconPath0 = 352,
		Beyond-Input-InputManager-ParseTextActionId0 = 353,
		Beyond-Input-InputManager-MoveMouseTo0 = 354,
		Beyond-Input-InputManager-MoveVirtualMouseTo0 = 355,
		Beyond-Input-InputManager-GetTouchId0 = 356,
		Beyond-Input-InputManager-GetPressPosByTouchId0 = 357,
		Beyond-Input-InputManager-Dispose0 = 358,
		Beyond-Input-InputManager-RemoveUnusedInput0 = 359,
		Beyond-Input-InputManager-GetCurJsInfos0 = 360,
		Beyond-Input-InputManager-GetRealCursorState0 = 361,
		Beyond-Input-RealCursorManager-DumpState0 = 362,
		Beyond-Input-InputManager-PrintKeycodeInfo2 = 363,
		Beyond-Input-InputManager-PrintKeycodeInfo0 = 364,
		Beyond-Input-InputManager-PrintBindingInfo0 = 365,
		Beyond-Input-InputManager-_GetBindingName0 = 366,
		Beyond-Input-InputManager-_GetInputBindingGroupGameObject0 = 367,
		Beyond-Input-InputManager-_GetInputBindingGameObject0 = 368,
		Beyond-Input-InputManager-PrintKeycodeInfo1 = 369,
		Beyond-Input-InputManager-PrintActionInfo0 = 370,
		Beyond-Input-InputManager-ControllerHintInfo-CompareTo0 = 371,
		Beyond-Input-InputManager-ControllerHintInfo-OnAllocate0 = 372,
		Beyond-Input-InputManager-ControllerHintInfo-OnRecycle0 = 373,
		Beyond-Input-InputUtils-IgnoreBindingParent0 = 374,
		Beyond-Input-InputUtils-IgnoreBindingGroupParent0 = 375,
		Beyond-Input-KeyboardCheckerBase-get_bindingInfos0 = 376,
		Beyond-Input-KeyboardChecker-CheckKeyboardInput0 = 377,
		Beyond-Input-KeyboardChecker-TriggerActions0 = 379,
		Beyond-Input-KeyboardOnClickChecker-CheckKeyboardInput0 = 380,
		Beyond-Input-KeyboardOnClickChecker-TriggerActions0 = 381,
		Beyond-Input-KeyboardOnLongPressChecker-CheckKeyboardInput0 = 382,
		Beyond-Input-KeyboardOnLongPressChecker-_OnTriggerBinding0 = 385,
		Beyond-Input-KeyboardOnLongPressChecker-OnCreateBinding0 = 386,
		Beyond-Input-KeyboardOnLongPressChecker-OnDeleteBinding0 = 387,
		Beyond-Input-KeyboardHandler-GetKeyboardType0 = 388,
		Beyond-Input-PlayerActionInfo-ResetHintProority0 = 389,
		Beyond-Input-KeyboardInput-GetModifyText0 = 390,
		Beyond-Input-KeyboardInput-GetKeyCodeText0 = 391,
		Beyond-Input-KeyboardInput-GetKeyCodeEnumIntValue0 = 392,
		Beyond-Input-KeyboardInput-SetKeyCodeEnumByIntValue0 = 393,
		Beyond-Input-KeyboardInput-get_modifyString0 = 394,
		Beyond-Input-KeyboardInput-ClearKeyCode0 = 395,
		Beyond-Input-KeyboardInput-IsValid0 = 396,
		Beyond-Input-KeyboardInput-CopyFrom0 = 397,
		Beyond-Input-KeyboardInput-Equals0 = 398,
		Beyond-Input-GamepadInput-GetModifyText0 = 399,
		Beyond-Input-GamepadInput-GetKeyCodeText0 = 400,
		Beyond-Input-GamepadInput-GetKeyCodeEnumIntValue0 = 401,
		Beyond-Input-GamepadInput-SetKeyCodeEnumByIntValue0 = 402,
		Beyond-Input-GamepadInput-ClearKeyCode0 = 403,
		Beyond-Input-GamepadInput-IsValid0 = 404,
		Beyond-Input-GamepadInput-CopyFrom0 = 405,
		Beyond-Input-GamepadInput-Equals0 = 406,
		Beyond-Input-CursorRequest-ToString0 = 407,
		Beyond-Input-UIEvent-get_bindingEnabled0 = 408,
		Beyond-Input-UIEvent-_CreatePlayerActionBinding0 = 410,
		Beyond-Input-UIEvent-InitBinding0 = 413,
		Beyond-Input-UIEvent-Invoke0 = 415,
		Beyond-Input-UIEvent-UpdateKeys0 = 416,
		Beyond-Input-UIEvent-ChangeBindingPlayerAction0 = 417,
		Beyond-Input-UIEvent-AddListener0 = 418,
		Beyond-Input-UIEvent-RemoveListener0 = 419,
		Beyond-Input-UIEvent-RemoveAllListeners0 = 420
	}
}

namespace UnityEngine.InputSystem.UI
{
	public class DebugVirtualMouseInput : MonoBehaviour // TypeDefIndex: 56360
	{
		// Fields
		private CursorMode m_CursorMode; // 0x18
		private Graphic m_CursorGraphic; // 0x20
		private RectTransform m_CursorTransform; // 0x28
		private RectTransform _canvasTransform; // 0x30
		private Canvas m_Canvas; // 0x38
		private float m_CursorSpeed; // 0x40
		private float m_ScrollSpeed; // 0x44
		private InputActionProperty m_StickAction; // 0x48
		private InputActionProperty m_LeftButtonAction; // 0x60
		private InputActionProperty m_MiddleButtonAction; // 0x78
		private InputActionProperty m_RightButtonAction; // 0x90
		private InputActionProperty m_ForwardButtonAction; // 0xA8
		private InputActionProperty m_BackButtonAction; // 0xC0
		private InputActionProperty m_ScrollWheelAction; // 0xD8
		private UnityEngine.InputSystem.Mouse m_VirtualMouse; // 0xF0
		private UnityEngine.InputSystem.Mouse m_SystemMouse; // 0xF8
		private Action m_AfterInputUpdateDelegate; // 0x100
		private Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate; // 0x108
		private double m_LastTime; // 0x110
		private Vector2 m_LastStickValue; // 0x118
		private float m_canvasScale; // 0x120
	
		// Properties
		public RectTransform cursorTransform { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public float cursorSpeed { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public CursorMode cursorMode { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x000000018A9BD3A8-0x000000018A9BD48C
		public Graphic cursorGraphic { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018A9BD384-0x000000018A9BD3A8
		public float scrollSpeed { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public UnityEngine.InputSystem.Mouse virtualMouse { get => default; } // 0x0000000185FB87A0-0x0000000185FB87B0 
		public InputActionProperty stickAction { get => default; set {} } // 0x0000000185FBEBC0-0x0000000185FBEBE0 0x000000018A9BD784-0x000000018A9BD7B4
		public InputActionProperty leftButtonAction { get => default; set {} } // 0x0000000185FBEBE0-0x0000000185FBEC00 0x000000018A9BD544-0x000000018A9BD5EC
		public InputActionProperty rightButtonAction { get => default; set {} } // 0x0000000185FC9A20-0x0000000185FC9A40 0x000000018A9BD69C-0x000000018A9BD754
		public InputActionProperty middleButtonAction { get => default; set {} } // 0x0000000185FCE7B0-0x0000000185FCE7D0 0x000000018A9BD5EC-0x000000018A9BD69C
		public InputActionProperty forwardButtonAction { get => default; set {} } // 0x0000000185FCE790-0x0000000185FCE7B0 0x000000018A9BD48C-0x000000018A9BD544
		public InputActionProperty backButtonAction { get => default; set {} } // 0x0000000185FCE770-0x0000000185FCE790 0x000000018A9BD2CC-0x000000018A9BD384
		public InputActionProperty scrollWheelAction { get => default; set {} } // 0x0000000185FCE7D0-0x0000000185FCE7F0 0x000000018A9BD754-0x000000018A9BD784
	
		// Nested types
		public enum CursorMode // TypeDefIndex: 56359
		{
			SoftwareCursor = 0,
			HardwareCursorIfAvailable = 1
		}
	
		// Constructors
		public DebugVirtualMouseInput() {} // 0x0000000185FA2A60-0x0000000185FA2A80
	
		// Methods
		protected void OnEnable() {} // 0x000000018A9BC3C0-0x000000018A9BC7E8
		protected void OnDisable() {} // 0x000000018A9BC124-0x000000018A9BC3C0
		private void _TryFindCanvas() {} // 0x000000018A9BCE7C-0x000000018A9BCED8
		private void _TryEnableHardwareCursor() {} // 0x000000018A9BCC84-0x000000018A9BCE7C
		private void _SyncScale() {} // 0x000000018A9BCB84-0x000000018A9BCC84
		private void _UpdateMotion() {} // 0x000000018A9BCED8-0x000000018A9BD2CC
		private void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) {} // 0x000000018A9BC7F0-0x000000018A9BCA20
		private static void _SetActionCallback(InputActionProperty field, Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x0207C7A9 */) {} // 0x000000018A9BCA20-0x000000018A9BCA8C
		private static void _SetAction(ref InputActionProperty field, InputActionProperty value) {} // 0x000000018A9BCA8C-0x000000018A9BCB84
		private void _OnAfterInputUpdate() {} // 0x000000018A9BC7E8-0x000000018A9BC7F0
	}
}
