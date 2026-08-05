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

// Image 39: Input.Beyond.dll - Assembly: Input.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58855-58934
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 58930
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_32 E680B0AF74F1D11AFCE59DFB222E2F946D48C66AE24640EE35784361EEA2E0C4; // 0x00 // Static value (base64): BwAAAAMAAAAFAAAABgAAAAEAAAACAAAABAAAAAAAAAA= - Metadata: 0x0234C314

	// Nested types
	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 58929
	{
	}
}

namespace Beyond.Input
{
	public class ControllerNaviManager // TypeDefIndex: 58864
	{
		// Fields
		public LinkedList<SelectableNaviGroup> layerStackList; // 0x10
		public Selectable curTarget; // 0x18
		private readonly HashSet<string> m_naviLockSet; // 0x20
		private int m_targetInputBindingGroupId; // 0x28
		private int m_naviInputBindingGroupId; // 0x2C
		private Selectable m_lastEnableNaviTarget; // 0x30
		[CompilerGenerated]
		private NavigationBindingType _navigationBindingType_k__BackingField; // 0x38
		private Dictionary<NavigationBindingType, int> m_naviBindingGroupIds; // 0x40
		private Beyond.Input.InputManager m_inputManager; // 0x48
		private const float SCORE_OFFSET = 10000f; // Metadata: 0x0234BF83
		[CompilerGenerated]
		private bool _forceEnableNaviForGuide_k__BackingField; // 0x50
	
		// Properties
		public NavigationBindingType navigationBindingType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public bool forceEnableNaviForGuide { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
	
		// Constructors
		public ControllerNaviManager(Beyond.Input.InputManager inputManager); // 0x00000001844BBBD0-0x00000001844BCD10
	
		// Methods
		public void SetNaviBindingType(NavigationBindingType bindingType); // 0x00000001844BCD10-0x00000001844BCEE0
		public void Tick(); // 0x0000000183304A00-0x0000000183304A60
		private bool _RemoveLayer(SelectableNaviGroup group, SelectableNaviGroup curLayer); // 0x00000001837D1060-0x00000001837D1280
		private void _RemoveLayerFromStack(SelectableNaviGroup group, bool silentMode); // 0x00000001837D1460-0x00000001837D14D0
		private void _SetTarget(Selectable target); // 0x00000001839D0480-0x00000001839D0550
		private void _OnLayerSelected(SelectableNaviGroup topLayer); // 0x0000000189E31810-0x0000000189E31A3C
		private bool _DefaultNavigate(NaviDirection dir); // 0x0000000189E30ABC-0x0000000189E314CC
		private Selectable _TryFindBestNaviTargetInGroup(SelectableNaviGroup group, Vector3 pos, Vector3 dir, double curMaxScore, out double maxScore); // 0x0000000189E31A3C-0x0000000189E31DE0
		private Selectable _TryFindBestNaviTarget(HashSet<Selectable> targets, Vector3 curPos, Vector3 dir, NaviStrategy strategy, double curMaxScore, out double maxScore); // 0x0000000189E31DE0-0x0000000189E32538
		private static Vector3 _GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir); // 0x0000000189E31608-0x0000000189E31810
		private LinkedListNode<SelectableNaviGroup> _GetDummyLayerLastGroupInStack(SelectableNaviGroup dummyLayer); // 0x0000000189E314CC-0x0000000189E31608
		public void SetForceEnableNavi(bool enable); // 0x0000000189E307C8-0x0000000189E3084C
		public void UpdateNaviInputBindingState(); // 0x0000000183794810-0x0000000183794A30
		public bool IsNavigationBindingEnabled(); // 0x0000000183794A30-0x0000000183794C00
		public void TryRemoveLayer(SelectableNaviGroup group); // 0x00000001839D0120-0x00000001839D0240
		public bool IsLayerInStack(SelectableNaviGroup group); // 0x00000001837D1410-0x00000001837D1460
		public bool IsTopLayer(SelectableNaviGroup group); // 0x0000000189E30414-0x0000000189E30510
		public void ChangeAndTrySetNaviBindingType(SelectableNaviGroup naviGroup, NavigationBindingType naviBindingType); // 0x00000001844F3C80-0x00000001844F3CE0
		public void TryAutoSetTarget(); // 0x00000001839CFAE0-0x00000001839CFBA0
		public SelectableNaviGroup GetTopDummyLayerGroup(); // 0x0000000189E302CC-0x0000000189E30388
		public void SetTarget(Selectable target); // 0x0000000189E30918-0x0000000189E30984
		public void ResetStateForUIDispose(); // 0x0000000189E30708-0x0000000189E307C8
		[IDTag(0)]
		public void SetTargetInSilentModeIfNecessary(Selectable selectable, SelectableNaviGroup needTopDummyGroup = null); // 0x0000000184B6AF20-0x0000000184B6B010
		public void ClearTargetIfNecessary(SelectableNaviGroup needTopDummyGroup = null); // 0x0000000189E300A8-0x0000000189E30178
		[IDTag(1)]
		public void SetTargetInSilentModeIfNecessary(SelectableNaviGroup naviGroup, Selectable selectable, SelectableNaviGroup needTopDummyGroup = null); // 0x0000000189E3084C-0x0000000189E30918
		public bool IsNaviTarget(Selectable target); // 0x0000000189E30388-0x0000000189E30414
		public Vector3 GetNaviVector(NaviDirection dir); // 0x0000000189E30178-0x0000000189E302CC
		public void Navigate(NaviDirection dir); // 0x0000000189E30510-0x0000000189E30708
		public void ToggleNavigation(string key, bool active); // 0x0000000189E30984-0x0000000189E30A7C
		[CompilerGenerated]
		private void _.ctor_b__12_0(); // 0x0000000189E30A7C-0x0000000189E30A8C
		[CompilerGenerated]
		private void _.ctor_b__12_1(); // 0x0000000189E30AAC-0x0000000189E30ABC
		[CompilerGenerated]
		private void _.ctor_b__12_2(); // 0x0000000189E30A8C-0x0000000189E30A9C
		[CompilerGenerated]
		private void _.ctor_b__12_3(); // 0x0000000189E30A9C-0x0000000189E30AAC
		[CompilerGenerated]
		private void _.ctor_b__12_4(); // 0x0000000189E30A8C-0x0000000189E30A9C
		[CompilerGenerated]
		private void _.ctor_b__12_5(); // 0x0000000189E30A9C-0x0000000189E30AAC
		[CompilerGenerated]
		private void _.ctor_b__12_6(); // 0x0000000189E30A7C-0x0000000189E30A8C
		[CompilerGenerated]
		private void _.ctor_b__12_7(); // 0x0000000189E30AAC-0x0000000189E30ABC
		[CompilerGenerated]
		private void _.ctor_b__12_8(); // 0x0000000189E30A7C-0x0000000189E30A8C
		[CompilerGenerated]
		private void _.ctor_b__12_9(); // 0x0000000189E30AAC-0x0000000189E30ABC
		[CompilerGenerated]
		private void _.ctor_b__12_10(); // 0x0000000189E30A8C-0x0000000189E30A9C
		[CompilerGenerated]
		private void _.ctor_b__12_11(); // 0x0000000189E30A9C-0x0000000189E30AAC
		[CompilerGenerated]
		private void _.ctor_b__12_12(); // 0x0000000189E30A8C-0x0000000189E30A9C
		[CompilerGenerated]
		private void _.ctor_b__12_13(); // 0x0000000189E30A9C-0x0000000189E30AAC
		[CompilerGenerated]
		private void _.ctor_b__12_14(); // 0x0000000189E30A7C-0x0000000189E30A8C
		[CompilerGenerated]
		private void _.ctor_b__12_15(); // 0x0000000189E30AAC-0x0000000189E30ABC
		[CompilerGenerated]
		private void _.ctor_b__12_16(); // 0x0000000189E30A7C-0x0000000189E30A8C
		[CompilerGenerated]
		private void _.ctor_b__12_17(); // 0x0000000189E30AAC-0x0000000189E30ABC
		[CompilerGenerated]
		private void _.ctor_b__12_18(); // 0x0000000189E30A8C-0x0000000189E30A9C
		[CompilerGenerated]
		private void _.ctor_b__12_19(); // 0x0000000189E30A9C-0x0000000189E30AAC
		[CompilerGenerated]
		private void _.ctor_b__12_20(); // 0x0000000189E30A8C-0x0000000189E30A9C
		[CompilerGenerated]
		private void _.ctor_b__12_21(); // 0x0000000189E30A9C-0x0000000189E30AAC
		[CompilerGenerated]
		private void _.ctor_b__12_22(); // 0x0000000189E30A7C-0x0000000189E30A8C
		[CompilerGenerated]
		private void _.ctor_b__12_23(); // 0x0000000189E30AAC-0x0000000189E30ABC
		[CompilerGenerated]
		private void _.ctor_b__12_24(); // 0x0000000189E30A7C-0x0000000189E30A8C
		[CompilerGenerated]
		private void _.ctor_b__12_25(); // 0x0000000189E30AAC-0x0000000189E30ABC
		[CompilerGenerated]
		private void _.ctor_b__12_26(); // 0x0000000189E30A8C-0x0000000189E30A9C
		[CompilerGenerated]
		private void _.ctor_b__12_27(); // 0x0000000189E30A9C-0x0000000189E30AAC
		[CompilerGenerated]
		private void _.ctor_b__12_28(); // 0x0000000189E30A8C-0x0000000189E30A9C
		[CompilerGenerated]
		private void _.ctor_b__12_29(); // 0x0000000189E30A9C-0x0000000189E30AAC
		[CompilerGenerated]
		private void _.ctor_b__12_30(); // 0x0000000189E30A7C-0x0000000189E30A8C
		[CompilerGenerated]
		private void _.ctor_b__12_31(); // 0x0000000189E30AAC-0x0000000189E30ABC
	}

	public enum ActionOnSetNaviTarget // TypeDefIndex: 58865
	{
		None = 0,
		AutoTriggerOnClick = 1,
		PressConfirmTriggerOnClick = 2
	}

	public static class ControllerNaviUtils // TypeDefIndex: 58866
	{
	}

	public class PSTriggerEffectCfg : MonoBehaviour // TypeDefIndex: 58867
	{
		// Fields
		[SerializeField]
		public List<TriggerEffectCommandUnion> commands; // 0x18
	
		// Constructors
		public PSTriggerEffectCfg(); // 0x0000000185393520-0x0000000185393538
	}

	public enum KeyboardKeyCode // TypeDefIndex: 58868
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

	public enum GamepadKeyCode // TypeDefIndex: 58869
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

	public enum InputTimingType // TypeDefIndex: 58870
	{
		OnPress = 0,
		OnRelease = 1,
		OnClick = 2,
		OnLongPress = 3
	}

	public enum InputContinuousTriggerType // TypeDefIndex: 58871
	{
		NormalDelayAndLoopTime = 0,
		EveryTick = 1
	}

	public enum KeyboardType // TypeDefIndex: 58872
	{
		None = 0,
		Default = 1,
		QWERTZ = 2,
		AZERTY = 3
	}

	internal abstract class GamepadCheckerBase // TypeDefIndex: 58875
	{
		// Fields
		protected Beyond.Input.InputManager m_inputManager; // 0x10
		protected DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> m_normalBindingInfos; // 0x18
		protected DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>>> m_modifyBindingInfos; // 0x20
		protected HashSet<GamepadKeyCode> m_usedKeyCache; // 0x28
		protected List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x30
	
		// Properties
		internal DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> normalBindingInfos { get; } // 0x0000000189E340DC-0x0000000189E34128 
		internal DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>>> modifyBindingInfos { get; } // 0x0000000189E34090-0x0000000189E340DC 
	
		// Nested types
		public class Binding // TypeDefIndex: 58873
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
			public Binding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0234C0B7 */); // 0x00000001837D0550-0x00000001837D0610
		}
	
		public enum TriggerType // TypeDefIndex: 58874
		{
			NORMAL = 0,
			CONTINUOUS = 1,
			STOP_CONTINUOUS = 2
		}
	
		// Constructors
		internal GamepadCheckerBase(Beyond.Input.InputManager inputManager); // 0x00000001842B6C40-0x00000001842B6E40
	
		// Methods
		public virtual Binding OnCreateBinding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0234C0B6 */); // 0x00000001837D02F0-0x00000001837D0470
		public virtual Binding OnDeleteBinding(GamepadInput input, InputBindingInfo info); // 0x00000001837CFCA0-0x00000001837CFEE0
		protected DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> GetInputDic(GamepadInput input); // 0x00000001837D0470-0x00000001837D0550
		public virtual void CheckGamepadInput(); // 0x0000000189E33CEC-0x0000000189E33E30
		protected virtual void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x0000000189E33C88-0x0000000189E33CEC
		public virtual void TriggerActions(); // 0x0000000189E33E30-0x0000000189E34090
	}

	internal class GamepadChecker : GamepadCheckerBase // TypeDefIndex: 58876
	{
		// Fields
		private Func<GamepadKeyCode, bool> m_checkFunc; // 0x38
		[CompilerGenerated]
		private bool _isPressChecker_k__BackingField; // 0x40
	
		// Properties
		public bool isPressChecker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
	
		// Constructors
		public GamepadChecker(Func<GamepadKeyCode, bool> checkFunc, bool isPress, Beyond.Input.InputManager inputManager); // 0x00000001842B62F0-0x00000001842B6340
	
		// Methods
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x0000000189E34128-0x0000000189E34794
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1); // 0x0000000189E34794-0x0000000189E3479C
	}

	internal class GamepadOnClickChecker : GamepadCheckerBase // TypeDefIndex: 58877
	{
		// Constructors
		internal GamepadOnClickChecker(Beyond.Input.InputManager inputManager); // 0x00000001853973D4-0x00000001853973DC
	
		// Methods
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x0000000189E3479C-0x0000000189E34F00
		public void ClearKeyPressed(GamepadKeyCode keyCode); // 0x0000000189E34F00-0x0000000189E35328
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1); // 0x0000000189E34794-0x0000000189E3479C
	}

	internal class GamepadOnLongPressChecker : GamepadCheckerBase // TypeDefIndex: 58879
	{
		// Fields
		private Action<GamepadKeyCode> m_onTriggerOnLongPress; // 0x38
		private Dictionary<GamepadInput, HashSet<Binding>> m_bindings; // 0x40
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 58878
		{
			// Fields
			public GamepadOnLongPressChecker __4__this; // 0x10
			public GamepadCheckerBase.Binding binding; // 0x18
			public GamepadKeyCode keyCode; // 0x20
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CreateTriggerBindingAction_b__0(); // 0x0000000189E3ABB0-0x0000000189E3ABDC
		}
	
		// Constructors
		public GamepadOnLongPressChecker(Action<GamepadKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager); // 0x00000001842B6600-0x00000001842B66B0
	
		// Methods
		public Action CreateTriggerBindingAction(Binding binding, GamepadKeyCode keyCode); // 0x0000000189E35A50-0x0000000189E35B50
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x0000000189E35328-0x0000000189E35A50
		private void _OnTriggerBinding(Binding binding, GamepadKeyCode keyCode); // 0x0000000189E35D74-0x0000000189E3622C
		public override Binding OnCreateBinding(GamepadInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0234C0BB */); // 0x0000000184611F30-0x0000000184612090
		public override Binding OnDeleteBinding(GamepadInput input, InputBindingInfo info); // 0x0000000184611E50-0x0000000184611F30
		public void CancelPendingLongPress(InputBindingInfo info); // 0x00000001837CFEE0-0x00000001837D0130
		public float GetInputLongPressStartTime(GamepadInput input, int bindingId = 0 /* Metadata: 0x0234C0BC */); // 0x0000000189E35B50-0x0000000189E35D5C
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1); // 0x0000000189E34794-0x0000000189E3479C
		public Binding __iFixBaseProxy_OnCreateBinding(GamepadInput P0, InputBindingInfo P1, bool P2); // 0x0000000189E35D5C-0x0000000189E35D6C
		public Binding __iFixBaseProxy_OnDeleteBinding(GamepadInput P0, InputBindingInfo P1); // 0x0000000189E35D6C-0x0000000189E35D74
	}

	internal class GamepadOnReleaseChecker : GamepadCheckerBase // TypeDefIndex: 58880
	{
		// Fields
		private readonly Func<GamepadKeyCode, bool> m_checkFunc; // 0x38
		private readonly Dictionary<GamepadKeyCode, HashSet<GamepadKeyCode>> m_modifyBindingPressedDic; // 0x40
	
		// Constructors
		public GamepadOnReleaseChecker(Func<GamepadKeyCode, bool> checkFunc, Beyond.Input.InputManager inputManager); // 0x00000001842B6550-0x00000001842B6600
	
		// Methods
		public override void CheckGamepadInput(); // 0x0000000189E368B8-0x0000000189E36E50
		protected override void CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> dic, GamepadKeyCode modifyKey); // 0x0000000189E3622C-0x0000000189E368B8
		[CompilerGenerated]
		private bool _CheckGamepadInput_b__3_0(GamepadKeyCode keyCode); // 0x0000000189E36E50-0x0000000189E36E78
		public void __iFixBaseProxy_CheckGamepadInput(); // 0x0000000189E36E78-0x0000000189E36E80
		public void __iFixBaseProxy_CheckDic(DynamicFastLookupCollection<GamepadKeyCode, HashSet<Binding>> P0, GamepadKeyCode P1); // 0x0000000189E34794-0x0000000189E3479C
	}

	[AddComponentMenu("Input/HG Virtual Mouse")]
	public class HGVirtualMouse : MonoBehaviour // TypeDefIndex: 58883
	{
		// Fields
		private const float STANDARD_SCREEN_WIDTH = 1920f; // Metadata: 0x0234C0BE
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
		public RectTransform cursorTransform { get; set; } // 0x0000000189E39298-0x0000000189E392E4 0x0000000189E3974C-0x0000000189E397AC
		public float scrollSpeed { get; set; } // 0x0000000189E394C0-0x0000000189E3950C 0x0000000189E39BC4-0x0000000189E39C1C
		public UnityEngine.InputSystem.Mouse virtualMouse { get; } // 0x0000000189E395F8-0x0000000189E39644 
		public InputActionProperty stickAction { get; set; } // 0x0000000189E39588-0x0000000189E395F8 0x0000000189E39CB0-0x0000000189E39D3C
		public InputActionProperty leftButtonAction { get; set; } // 0x0000000189E3935C-0x0000000189E393D0 0x0000000189E398B4-0x0000000189E399B4
		public InputActionProperty rightButtonAction { get; set; } // 0x0000000189E39448-0x0000000189E394C0 0x0000000189E39ABC-0x0000000189E39BC4
		public InputActionProperty middleButtonAction { get; set; } // 0x0000000189E393D0-0x0000000189E39448 0x0000000189E399B4-0x0000000189E39ABC
		public InputActionProperty forwardButtonAction { get; set; } // 0x0000000189E392E4-0x0000000189E3935C 0x0000000189E397AC-0x0000000189E398B4
		public InputActionProperty backButtonAction { get; set; } // 0x0000000189E39220-0x0000000189E39298 0x0000000189E39644-0x0000000189E3974C
		public InputActionProperty scrollWheelAction { get; set; } // 0x0000000189E3950C-0x0000000189E39588 0x0000000189E39C1C-0x0000000189E39CB0
		public bool isHoverOn { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA2F60-0x0000000184DA2F70 0x0000000184DA2F80-0x0000000184DA2F90
		public bool mouseIconVisible { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA2F70-0x0000000184DA2F80 0x0000000184DA2F90-0x0000000184DA2FA0
	
		// Nested types
		[Serializable]
		public class CursorSpeedPhase // TypeDefIndex: 58881
		{
			// Fields
			public float maxJsValue; // 0x10
			public float minSpeed; // 0x14
			public float maxSpeed; // 0x18
			public float acceleration; // 0x1C
			public float accelerationSpeed; // 0x20
			public float maxAcceleration; // 0x24
	
			// Constructors
			public CursorSpeedPhase(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58882
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Selectable> __9__78_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189E3ABDC-0x0000000189E3AC40
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ChangeHoverState_b__78_0(Selectable o); // 0x0000000189E3AB64-0x0000000189E3ABB0
		}
	
		// Constructors
		public HGVirtualMouse(); // 0x00000001840F9790-0x00000001840F9920
	
		// Methods
		protected void OnEnable(); // 0x0000000189E378E0-0x0000000189E38074
		protected void OnDisable(); // 0x0000000189E37554-0x0000000189E378E0
		private void _UpdateMotion(); // 0x0000000189E38974-0x0000000189E39220
		private void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context); // 0x0000000189E383F0-0x0000000189E38614
		public void TriggerLeftButton(bool isPressed); // 0x0000000189E380F4-0x0000000189E38228
		public void ClearLeftButtonState(); // 0x0000000189E37158-0x0000000189E3724C
		private static void _SetActionCallback(InputActionProperty field, Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x0234C0BD */); // 0x0000000189E38614-0x0000000189E386D8
		private static void _SetAction(ref InputActionProperty field, InputActionProperty value); // 0x0000000189E386D8-0x0000000189E3882C
		public void OnAfterInputUpdate(); // 0x0000000189E373DC-0x0000000189E3742C
		private void Update(); // 0x0000000189E38240-0x0000000189E38374
		public void ChangeHoverState(Selectable target, bool isHoverOn); // 0x0000000189E36F14-0x0000000189E37158
		private void _ChangeHoverState(bool isHoverOn); // 0x0000000189E38374-0x0000000189E383F0
		public Selectable GetCurHoverSelectable(); // 0x0000000189E3724C-0x0000000189E373DC
		private void OnDestroy(); // 0x0000000189E3742C-0x0000000189E37554
		private void _SyncScale(); // 0x0000000189E3882C-0x0000000189E38974
		private void Awake(); // 0x0000000189E36E80-0x0000000189E36F14
		public void SetMouseIconVisible(bool active); // 0x0000000189E38074-0x0000000189E380F4
		[CompilerGenerated]
		private void _OnEnable_b__32_0(); // 0x0000000189E38228-0x0000000189E38234
		[CompilerGenerated]
		private void _OnEnable_b__32_1(); // 0x0000000189E38234-0x0000000189E38240
	}

	[Serializable]
	public class InputBindingInfo // TypeDefIndex: 58884
	{
		// Fields
		private static uint s_nextEnabledPriority; // 0x00
		[CompilerGenerated]
		private readonly int _id_k__BackingField; // 0x10
		private Action m_callback; // 0x18
		[CompilerGenerated]
		private InputBindingGroup _group_k__BackingField; // 0x20
		public string playerActionId; // 0x28
		[CompilerGenerated]
		private bool _shouldShowControllerHint_k__BackingField; // 0x30
		[CompilerGenerated]
		private int _controllerHintPriority_k__BackingField; // 0x34
		[CompilerGenerated]
		private bool _isCommonOpenUIAction_k__BackingField; // 0x38
		[CompilerGenerated]
		private bool _selfEnabled_k__BackingField; // 0x39
		[CompilerGenerated]
		private bool _groupEnabled_k__BackingField; // 0x3A
		[CompilerGenerated]
		private bool _parentIgnored_k__BackingField; // 0x3B
		public bool forceKeyhintToGrayState; // 0x3C
		[CompilerGenerated]
		private uint _enabledPriority_k__BackingField; // 0x40
		[CompilerGenerated]
		private int _actionPriority_k__BackingField; // 0x44
		private IBindingView m_bindingView; // 0x48
		private string m_text; // 0x50
		public static float s_continuousTriggerFirstDelayTime; // 0x04
		public static float s_continuousTriggerLoopDelayTime; // 0x08
		public static float s_continuousTriggerLoopQuickDelayTime; // 0x0C
		private int m_continuousTriggerTimerId; // 0x58
	
		// Properties
		public int id { [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		public InputBindingGroup group { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool shouldShowControllerHint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
		public int controllerHintPriority { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public bool isCommonOpenUIAction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		public bool selfEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86650-0x0000000184D86660 0x0000000184D86680-0x0000000184D86690
		public bool groupEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86660-0x0000000184D86670 0x0000000184D86690-0x0000000184D866A0
		public bool enabled { get; } // 0x00000001837CE190-0x00000001837CE220 
		public bool parentIgnored { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86D10-0x0000000184D86D20 0x0000000184D86D20-0x0000000184D86D30
		public uint enabledPriority { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		public int actionPriority { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
		public IBindingView bindingView { get; set; } // 0x00000001837D5340-0x00000001837D53C0 0x0000000189E3A584-0x0000000189E3A5E8
		public string text { get; set; } // 0x0000000189E3A49C-0x0000000189E3A584 0x00000001843EF260-0x00000001843EF2A0
	
		// Constructors
		public InputBindingInfo(int id, InputBindingGroup group, Action callback, string playerActionId, PlayerActionInfo actionInfo); // 0x00000001837CE370-0x00000001837CE430
		static InputBindingInfo(); // 0x0000000184D35BB0-0x0000000184D35C30
	
		// Methods
		private static uint _GetNextEnabledPriority(); // 0x00000001837D0130-0x00000001837D0190
		public void ChangeGroup(InputBindingGroup newGroup); // 0x0000000189E39E70-0x0000000189E39EF4
		public void SetSelfEnabled(bool value); // 0x00000001837D0F80-0x00000001837D1010
		public void OnGroupEnabledChanged(bool value, bool silent = false /* Metadata: 0x0234C0C2 */); // 0x00000001837CEA10-0x00000001837CEB00
		public void SetParentIgnored(bool value); // 0x0000000189E39F4C-0x0000000189E39FA8
		public void Trigger(); // 0x0000000183629C00-0x0000000183629C40
		public void StartContinuousTrigger(InputContinuousTriggerType continuousTriggerType); // 0x0000000189E39FA8-0x0000000189E3A154
		private void _TryContinuousTrigger(); // 0x0000000189E3A434-0x0000000189E3A49C
		public void StopContinuousTrigger(); // 0x00000001837CF850-0x00000001837CF8B0
		private void _RealTriggerCallback(); // 0x0000000183629C40-0x0000000183629CD0
		public void OnDelete(); // 0x00000001837D0610-0x00000001837D0680
		public object GetCallbackTarget(); // 0x0000000189E39EF4-0x0000000189E39F4C
		[CompilerGenerated]
		private void _StartContinuousTrigger_b__64_0(); // 0x0000000189E3A154-0x0000000189E3A248
		[CompilerGenerated]
		private void _StartContinuousTrigger_b__64_1(); // 0x0000000189E3A248-0x0000000189E3A33C
		[CompilerGenerated]
		private void _StartContinuousTrigger_b__64_2(); // 0x0000000189E3A33C-0x0000000189E3A434
	}

	[Serializable]
	public class InputBindingGroup // TypeDefIndex: 58885
	{
		// Fields
		[CompilerGenerated]
		private readonly int _id_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _selfEnabled_k__BackingField; // 0x14
		[CompilerGenerated]
		private bool _parentEnabled_k__BackingField; // 0x15
		[CompilerGenerated]
		private bool _parentIgnored_k__BackingField; // 0x16
		[CompilerGenerated]
		private InputBindingGroup _parent_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly LinkedList<InputBindingGroup> _subGroups_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly LinkedList<InputBindingInfo> _subInfos_k__BackingField; // 0x28
		private IBindingView m_groupView; // 0x30
		private IBindingGroupTarget m_groupTarget; // 0x38
	
		// Properties
		public int id { [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		public bool selfEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8EE50-0x0000000184D8EE60 0x0000000184D8EE70-0x0000000184D8EE80
		public bool parentEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8EE60-0x0000000184D8EE70 0x0000000184D8EE80-0x0000000184D8EE90
		public bool enabled { get; } // 0x0000000183794D70-0x0000000183794DE0 
		public bool parentIgnored { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA2FA0-0x0000000184DA2FB0 0x0000000184DA2FB0-0x0000000184DA2FC0
		public InputBindingGroup parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public LinkedList<InputBindingGroup> subGroups { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public LinkedList<InputBindingInfo> subInfos { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		public IBindingView groupView { get; set; } // 0x00000001837D53C0-0x00000001837D5430 0x0000000183EAD8D0-0x0000000183EAD940
		public IBindingGroupTarget groupTarget { get; set; } // 0x0000000189E39E0C-0x0000000189E39E70 0x00000001837932F0-0x0000000183793360
	
		// Constructors
		public InputBindingGroup(int id, InputBindingGroup parent); // 0x0000000183793360-0x0000000183793450
	
		// Methods
		public void ChangeParent(InputBindingGroup newParent); // 0x00000001842B5BC0-0x00000001842B5C30
		public void SetSelfEnabled(bool value); // 0x0000000183793CB0-0x0000000183793D30
		public void SetParentIgnored(bool value, bool silent = false /* Metadata: 0x0234C0C3 */); // 0x0000000189E39D8C-0x0000000189E39E0C
		public void OnParentEnabledChanged(bool value, bool silent = false /* Metadata: 0x0234C0C4 */); // 0x0000000183794770-0x0000000183794810
		private void _OnBindingGroupStateChanged(bool silent = false /* Metadata: 0x0234C0C5 */); // 0x00000001837943E0-0x0000000183794770
	}

	public class InputBindingGroupMonoTarget : MonoBehaviour, IBindingGroupTarget // TypeDefIndex: 58886
	{
		// Fields
		private int m_groupId; // 0x18
		private bool m_init; // 0x1C
		private bool m_internalEnabled; // 0x1D
		[CompilerGenerated]
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x20
	
		// Properties
		public int groupId { get; } // 0x00000001837D42E0-0x00000001837D4340 
		public bool groupEnabled { get; } // 0x00000001837D3480-0x00000001837D3510 
		public InputBindingGroupMonoTarget parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public IBindingGroupTarget parentTarget { get; } // 0x0000000189E39D3C-0x0000000189E39D8C 
		[Tooltip("\u65E5\u5E38\u5927\u5BB6\u7528\u7EC4\u4EF6\u672C\u8EAB\u7684enabled\u5C31\u53EF\u4EE5\u4E86\u3002\u8FD9\u4E2A\u503C\u662F\u56E0\u4E3A\u6709\u7684\u903B\u8F91\u8FD8\u8981\u5728\u7EC4\u4EF6enable\u7684\u65F6\u5019\u5C4F\u853D\u8F93\u5165\uFF0C\u6240\u4EE5\u989D\u5916\u63D0\u4F9B\u4E86\u8FD9\u4E2A\u3002\u6BD4\u5982UI\u9762\u677F\u7684\u906E\u6321\u903B\u8F91\u5C31\u4F1A\u7528\u8FD9\u4E2A\u503C\uFF0C\u539F\u672C\u7684\u7EC4\u4EF6enable\u4F1A\u7559\u7ED9\u9762\u677F\u81EA\u5DF1\u7684\u903B\u8F91\u53BB\u63A7\u5236\u3002")]
		public bool internalEnabled { get; set; } // 0x0000000183C73B10-0x0000000183C73B70 0x00000001837D46C0-0x00000001837D4710
	
		// Constructors
		public InputBindingGroupMonoTarget(); // 0x00000001844F3520-0x00000001844F3550
	
		// Methods
		public void Init(); // 0x00000001837D4340-0x00000001837D45D0
		public void UpdateState(); // 0x00000001837D4790-0x00000001837D4820
		public void DeleteGroup(); // 0x00000001837D4180-0x00000001837D41E0
		private void Awake(); // 0x00000001837D42A0-0x00000001837D42E0
		private void OnEnable(); // 0x00000001837D4750-0x00000001837D4790
		private void OnDisable(); // 0x00000001837D4710-0x00000001837D4750
		private void OnDestroy(); // 0x00000001837D3D00-0x00000001837D3D40
	}

	public interface IBindingGroupTarget // TypeDefIndex: 58887
	{
		// Properties
		int groupId { get; }
		IBindingGroupTarget parentTarget { get; }
		bool groupEnabled { get; }
	}

	public interface IBindingTarget // TypeDefIndex: 58888
	{
		// Properties
		int bindingId { get; }
		IBindingGroupTarget parentTarget { get; }
		bool bindingEnabled { get; }
	}

	public enum BindingViewState // TypeDefIndex: 58889
	{
		Normal = 0,
		Disabled = 1,
		Hide = 2
	}

	public enum BindingViewActionType // TypeDefIndex: 58890
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

	public interface IBindingView // TypeDefIndex: 58891
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

	public enum InputSettingLevel // TypeDefIndex: 58892
	{
		Default = 0,
		Custom = 1,
		Pending = 2
	}

	public class InputManager : Singleton<Beyond.Input.InputManager>, IDisposable // TypeDefIndex: 58899
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
		private const int DEVICE_SWITCH_SUPPRESS_FRAMES = 3; // Metadata: 0x0234C0E8
		private bool m_lastAnyOtherDeviceKey; // 0xEC
		private int m_controllerForbidClickBindingId; // 0xF0
		private bool m_ignoreFirstMouseUpOnFocusBack; // 0xF4
		private static readonly Beyond.Input.KeyboardKeyCode[] S_CACHED_KEYBOARD_KEY_CODES; // 0x20
		private static bool s_autoUpdateInputBindingMask; // 0x28
		private bool m_hasFocusedInputFiled; // 0xF5
		private const float STICK_DEAD_ZONE_MAGNITUDE = 0.2f; // Metadata: 0x0234C0E9
		private const float STICK_MIN_VALUE = 0.4f; // Metadata: 0x0234C0ED
		private const float STICK_DEAD_ZONE_SQRT_MAGNITUDE = 0.040000003f; // Metadata: 0x0234C0F1
		private IAssetLoader m_assetLoader; // 0xF8
		private SerializeFieldDictionary<string, PlayerActionInfo> m_defaultSetting; // 0x100
		private SerializeFieldDictionary<string, PlayerActionInfo> m_customSetting; // 0x108
		private SerializeFieldDictionary<string, PlayerActionInfo> m_pendingSetting; // 0x110
		private InputRebindConfig m_rebindConfig; // 0x118
		private Dictionary<string, InputRebindActionScopeConfig> m_rebindActionScopeConfigs; // 0x120
		private Dictionary<string, PlayerActionInfo> m_anonymousActionInfos; // 0x128
		private int m_nextAnonymousPlayerActionId; // 0x130
		private const string INPUT_MANAGER_CANVAS_PREFAB_PATH = "Assets/Beyond/InitialAssets/Prefabs/Common/InputManagerCanvas.prefab"; // Metadata: 0x0234C0F5
		[CompilerGenerated]
		private HGVirtualMouse _virtualMouse_k__BackingField; // 0x138
		[CompilerGenerated]
		private DebugVirtualMouseInput _debugVirtualMouse_k__BackingField; // 0x140
		[CompilerGenerated]
		private Transform _canvasRoot_k__BackingField; // 0x148
		[CompilerGenerated]
		private Transform _controllerMask_k__BackingField; // 0x150
		[CompilerGenerated]
		private bool _usingVirtualMouse_k__BackingField; // 0x158
		private int m_virtualMouseBindingGroupId; // 0x15C
		private FAssetProxyHandle m_canvasPrefabHandle; // 0x160
		[CompilerGenerated]
		private Transform _customControllerMouseTrans_k__BackingField; // 0x178
		[CompilerGenerated]
		private Camera _customControllerMouseUICamera_k__BackingField; // 0x180
		private List<ControllerHintInfo> m_tmpControllerHintInfoList; // 0x188
		public readonly HashSet<string> guideUseActionIds; // 0x190
		private const float DEFAULT_VIBRATE_LEVEL = 0.5f; // Metadata: 0x0234C13B
		private static Regex s_actIdRegex; // 0x30
		private const string TEXT_SPRITE_FORMAT = "<image=\"{0}\" scale={1}>"; // Metadata: 0x0234C13F
		private const float TEXT_SPRITE_SCALE = 1.6f; // Metadata: 0x0234C157
		public const string LONG_PRESS_KEY_ICON_POSTFIX = "_press"; // Metadata: 0x0234C15B
		private const string KEY_HINT_ICON_COMMON_FOLDER = "Assets/Beyond/InitialAssets/UI/Sprites/"; // Metadata: 0x0234C162
		private const string KEYBOARD_KEY_HINT_ICON_PATH = "KeyIcon/icon_key_"; // Metadata: 0x0234C18A
		private const string GAMEPAD_KEY_HINT_ICON_PATH_PS5 = "KeyIcon/Playstation/icon_playstation_"; // Metadata: 0x0234C19C
		private const string GAMEPAD_KEY_HINT_ICON_PATH_PS4 = "KeyIcon/Playstation4/icon_playstation4_"; // Metadata: 0x0234C1C2
		private const string GAMEPAD_KEY_HINT_ICON_PATH_XBOX = "KeyIcon/XBox/icon_xbox_"; // Metadata: 0x0234C1EA
		private const string GAMEPAD_KEY_HINT_ICON_PATH_FALLBACK = "KeyIcon/XBox/icon_xbox_"; // Metadata: 0x0234C202
		public static string s_virtualMouseClickHintActionId; // 0x38
		public static string s_virtualMouseLongPressHintActionId; // 0x40
		public MultiAction<Vector2> onStartSwipeTouchPanel; // 0x198
		public MultiAction<Vector2, Vector2> onSwipeTouchPanel; // 0x1A0
		public MultiAction onEndSwipeTouchPanel; // 0x1A8
		[CompilerGenerated]
		private bool _isSwipingTouchPanel_k__BackingField; // 0x1B0
		private Vector2 m_lastTouchPanelPos; // 0x1B4
		public ControllerNaviManager controllerNaviManager; // 0x1C0
		public bool disableCheckInputForNetMask; // 0x1C8
		private List<DelayedComboBinding> m_delayedCombos; // 0x1D0
		private bool m_delayedComboKeyUpdateSubscribed; // 0x1D8
		private static ProfilerMarker s_updateDelayedCombosMarker; // 0x48
	
		// Properties
		public bool isDebugForceShow { get; } // 0x0000000189E2FB84-0x0000000189E2FBE4 
		public static bool cursorVisible { get; } // 0x00000001833FDFC0-0x00000001833FE1F0 
		public static bool anyKeyDown { get; } // 0x00000001837CF460-0x00000001837CF500 
		public static Vector2 mouseScrollDelta { get; } // 0x00000001837CF710-0x00000001837CF7C0 
		public static bool multiTouchEnabled { get; set; } // 0x000000018429EE70-0x000000018429EF50 0x00000001846DA760-0x00000001846DA880
		public bool usingController { get; private set; } // 0x00000001833FD440-0x00000001833FD550 0x0000000189E2FD80-0x0000000189E2FE1C
		public bool virtualMouseIconVisible { get; } // 0x0000000189E2FC40-0x0000000189E2FCAC 
		public KeyboardType keyboardType { get; set; } // 0x0000000189E2FBE4-0x0000000189E2FC40 0x0000000184731010-0x00000001847310D0
		public static int invalidID { get; } // 0x00000001837CE430-0x00000001837CE450 
		public Rewired.Joystick joystick { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
		public IGamepadTemplate gamepadTemplate { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public IDualShock4Extension gamepadDualShock4Extension { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public Dictionary<string, HashSet<int>> action2BindingDic { get; } // 0x00000001837CE220-0x00000001837CE280 
		public int rootGroupId { get; } // 0x0000000184D2BAF0-0x0000000184D2BB30 
		public bool inChangingInputDevice { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D91930-0x0000000184D91940 0x0000000184D919A0-0x0000000184D919B0
		public static bool isInputSuppressedByDeviceSwitch { get; } // 0x00000001833FE910-0x00000001833FE9D0 
		public static bool autoUpdateInputBindingMask { get; set; } // 0x0000000183DF9D10-0x0000000183DF9D80 0x0000000189E2FCAC-0x0000000189E2FD80
		public HGVirtualMouse virtualMouse { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DC90-0x0000000184D8DCA0 0x0000000185397184-0x0000000185397198
		public DebugVirtualMouseInput debugVirtualMouse { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DA60-0x0000000184D8DA70 0x0000000186B8B404-0x0000000186B8B418
		public Transform canvasRoot { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DAC0-0x0000000184D8DAD0 0x0000000186B8B468-0x0000000186B8B47C
		public Transform controllerMask { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D890-0x0000000184D8D8A0 0x0000000186B8B224-0x0000000186B8B238
		public bool usingVirtualMouse { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D907E0-0x0000000184D907F0 0x0000000184D907F0-0x0000000184D90800
		public static Vector3 mousePosition { get; } // 0x00000001834021D0-0x0000000183402260 
		public Transform customControllerMouseTrans { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DEE0-0x0000000184D8DEF0 0x0000000186B8B92C-0x0000000186B8B940
		public Camera customControllerMouseUICamera { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DD60-0x0000000184D8DD70 0x0000000186B8B774-0x0000000186B8B788
		public bool isSwipingTouchPanel { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90970-0x0000000184D90980 0x0000000184D909A0-0x0000000184D909B0
	
		// Nested types
		public class KeyCaches // TypeDefIndex: 58893
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
			public KeyCaches(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void UpdateKeyStat(); // 0x0000000183304DD0-0x0000000183304F20
		}
	
		private enum KeyCodeState // TypeDefIndex: 58894
		{
			Pressed = 0,
			OnPress = 1,
			OnRelease = 2
		}
	
		public class ControllerHintInfo : IComparable<ControllerHintInfo>, IReusable // TypeDefIndex: 58895
		{
			// Fields
			public string actionId; // 0x10
			public int priority; // 0x18
			public InputBindingInfo bind; // 0x20
			public IBindingView hintView; // 0x28
	
			// Constructors
			public ControllerHintInfo(); // 0x00000001841E1670-0x00000001841E1680
			public ControllerHintInfo(IBindingView hintView, InputBindingInfo bind); // 0x0000000189E30098-0x0000000189E300A0
			public ControllerHintInfo(string actionId); // 0x0000000189E300A0-0x0000000189E300A8
	
			// Methods
			[IDTag(0)]
			public void Reset(IBindingView newHintView, InputBindingInfo newBind); // 0x0000000189E2FF38-0x0000000189E2FFE4
			[IDTag(1)]
			public void Reset(string resetActionId); // 0x0000000189E2FFE4-0x0000000189E30098
			public int CompareTo(ControllerHintInfo other); // 0x0000000189E2FE1C-0x0000000189E2FE7C
			public void OnAllocate(); // 0x0000000189E2FE7C-0x0000000189E2FEC0
			public void OnRecycle(); // 0x0000000189E2FEC0-0x0000000189E2FF38
		}
	
		public enum DelayedComboKind // TypeDefIndex: 58896
		{
			ModifierTapThenTrigger = 0,
			TriggerThenModifier = 1
		}
	
		public class DelayedComboBinding // TypeDefIndex: 58897
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
			public bool triggerJustPressedLastFrame { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
	
			// Constructors
			internal DelayedComboBinding(string modifierActionId, string triggerActionId, DelayedComboKind kind, float maxModifierHoldTime, Action onTriggered); // 0x0000000184490470-0x00000001844904D0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58898
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__100_0; // 0x08
			public static Action __9__239_0; // 0x10
			public static MatchEvaluator __9__297_0; // 0x18
	
			// Constructors
			static __c(); // 0x0000000184D4A230-0x0000000184D4A290
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __InitDeviceChangeBinding_b__100_0(); // 0x00000001841E1670-0x00000001841E1680
			internal void __CreateVirtualMouse_b__239_0(); // 0x00000001841E1670-0x00000001841E1680
			internal string _ParseTextActionId_b__297_0(System.Text.RegularExpressions.Match match); // 0x0000000182D480C0-0x0000000182D4A050
		}
	
		// Constructors
		private InputManager(); // 0x00000001847C6070-0x00000001847C6390
		static InputManager(); // 0x000000018432BE50-0x000000018432E100
	
		// Methods
		public void LateTick(float deltaTime); // 0x00000001836E7D40-0x00000001836E7DC0
		private void _Init(); // 0x00000001842B4D70-0x00000001842B56C0
		public void Release(); // 0x0000000189E2C000-0x0000000189E2C050
		private void _ClearTickFunction(); // 0x0000000189E2D720-0x0000000189E2D790
		public void OnApplicationQuit(); // 0x0000000189E2ABCC-0x0000000189E2AC1C
		private void _ClearEvents(); // 0x0000000189E2D4A4-0x0000000189E2D720
		private void _OnAfterInputUpdate(); // 0x0000000183304780-0x0000000183304A00
		private void _OnControllerConnected(ControllerStatusChangedEventArgs args); // 0x0000000189E2ED94-0x0000000189E2EEB8
		private void _OnControllerDisconnected(ControllerStatusChangedEventArgs args); // 0x0000000189E2EEB8-0x0000000189E2EF48
		private void _TryFindGamepad(); // 0x0000000184A318A0-0x0000000184A31AE0
		private bool _IsValidJoystick(Rewired.Joystick js); // 0x0000000189E2ECB8-0x0000000189E2ED94
		private void _SetJoystick(Rewired.Joystick js); // 0x0000000189E2F260-0x0000000189E2F920
		private void _CheckInput(); // 0x00000001834DEF90-0x00000001834DFA80
		private Beyond.DeviceInfo.ControllerType _GetControllerType(Rewired.Joystick js, out bool isNonSupportPsController); // 0x0000000182D45EA0-0x0000000182D480A0
		public void OnApplicationFocus(bool hasFocus); // 0x0000000183A74530-0x0000000183A745D0
		private void _InitDeviceChangeBinding(); // 0x00000001842B6930-0x00000001842B6AA0
		private void _RefreshDeviceChangeBinding(); // 0x0000000183DF9CB0-0x0000000183DF9D10
		public void CheckUsingController(); // 0x00000001834DEB50-0x00000001834DECC0
		private bool _CheckAnyKeyForTouchChangeDevice(); // 0x0000000189E2D44C-0x0000000189E2D4A4
		private bool _CheckAnyKeyForKeyboardChangeDevice(); // 0x0000000189E2D1CC-0x0000000189E2D44C
		private bool _AnyKeyDownForKeyboardChangeDevice(); // 0x0000000189E2D048-0x0000000189E2D118
		private void _TryChangeInputDeviceType(Beyond.DeviceInfo.InputType inputType); // 0x0000000189E2F920-0x0000000189E2FA70
		private void _TryStopDeviceSwitchSuppression(); // 0x0000000189E2FA70-0x0000000189E2FAD4
		private void _SyncUsingControllerState(); // 0x0000000183DF8DC0-0x0000000183DF96D0
		private static void _UpdateInputBindingMask(Beyond.DeviceInfo.InputType inputType); // 0x0000000189E2FAD4-0x0000000189E2FB84
		private static void _SetInputBindingMask(string group); // 0x0000000189E2F04C-0x0000000189E2F260
		public void ToggleInputDeviceChangeMode(bool inChanging); // 0x0000000189E2CE14-0x0000000189E2CEBC
		public void SetCursorOverrideForDeviceChange(bool forceShow); // 0x0000000189E2C74C-0x0000000189E2C9CC
		public void ChangeInputTypeAndSyncState(Beyond.DeviceInfo.InputType inputType); // 0x0000000189E279BC-0x0000000189E27A74
		private void _OnFocusedInputFieldChanged([IsReadOnly] in EventData<bool> v); // 0x0000000183CD4D00-0x0000000183CD4D40
		private void _CreateTickFunction(); // 0x00000001842B6810-0x00000001842B6930
		[IDTag(2)]
		private void _RemovePlayerActionCheck(InputBindingInfo info); // 0x00000001837D0760-0x00000001837D0830
		[IDTag(2)]
		private void _AddPlayerActionCheck(InputBindingInfo info); // 0x00000001837CE710-0x00000001837CE7E0
		[IDTag(0)]
		private void _AddPlayerActionCheck(KeyboardInput input, InputBindingInfo info); // 0x00000001837CE7E0-0x00000001837CE900
		[IDTag(1)]
		private void _AddPlayerActionCheck(GamepadInput input, InputBindingInfo info); // 0x00000001837D0190-0x00000001837D02F0
		[IDTag(0)]
		private void _RemovePlayerActionCheck(KeyboardInput input, InputBindingInfo info); // 0x00000001837D0830-0x00000001837D08E0
		[IDTag(1)]
		private void _RemovePlayerActionCheck(GamepadInput input, InputBindingInfo info); // 0x00000001837CE900-0x00000001837CEA10
		public bool GetKey(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000184774970-0x00000001847749C0
		public bool GetKeyOrDown(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000189E2A080-0x0000000189E2A0B4
		public bool GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000183305AC0-0x0000000183305B50
		public bool GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000183305B50-0x00000001833068F0
		public Vector2 GetGamepadStickValue(bool isLeft, bool checkDeadZone = true /* Metadata: 0x0234C0D5 */); // 0x0000000189E29CF8-0x0000000189E29E14
		public static bool CheckGamepadStickInDeadZone(Vector2 stickValue); // 0x0000000189E28160-0x0000000189E2818C
		public static bool CheckGamepadStickInDeadZone(float stickAxisValue); // 0x0000000189E27BF8-0x0000000189E28160
		public float GetGamepadTriggerValue(bool isLeft); // 0x0000000189E29E14-0x0000000189E29F64
		public bool GetKey(GamepadKeyCode keyCode); // 0x0000000189E2A0C4-0x0000000189E2A0D0
		public bool GetKeyDown(GamepadKeyCode keyCode); // 0x0000000189E29F64-0x0000000189E29F74
		public bool GetKeyUp(GamepadKeyCode keyCode); // 0x0000000189E2A0B4-0x0000000189E2A0C4
		public bool AnyKeyboardKey(string[] actionScopes, out Beyond.Input.KeyboardKeyCode keyCode, out bool isBlackList); // 0x0000000189E27608-0x0000000189E277F8
		private bool _AnyKeyboardKey(Beyond.Input.KeyboardKeyCode[] keyCodes, out Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000189E2D118-0x0000000189E2D1CC
		public bool AnyGamepadKey(); // 0x00000001834DECC0-0x00000001834DED20
		public bool AnyMouseKeyDown(); // 0x00000001837CF620-0x00000001837CF710
		public bool AnyMouseKey(); // 0x0000000189E27878-0x0000000189E278F8
		public bool AnyMouseKeyUp(); // 0x0000000189E277F8-0x0000000189E27878
		public static bool AnyKeyDown(); // 0x00000001837CF500-0x00000001837CF620
		public static bool AnyTouchBegan(); // 0x0000000189E278F8-0x0000000189E279BC
		public static bool AnyTouchActive(); // 0x0000000182D45020-0x0000000182D454E0
		private bool _CheckGamepadKeyCode(GamepadKeyCode keyCode, KeyCodeState state); // 0x0000000183B72340-0x0000000183B723C0
		[IDTag(1)]
		public int CreateBinding(PlayerActionInfo actionInfo, Action callback, int groupId, out string actionId); // 0x0000000189E28284-0x0000000189E2833C
		[IDTag(0)]
		public int CreateBinding(string actionId, Action callback, int groupId); // 0x00000001837D16F0-0x00000001837D17D0
		[IDTag(2)]
		public int CreateBinding(Beyond.Input.KeyboardKeyCode key, string modifyKeys, InputTimingType timing, Action callback, int groupId); // 0x0000000189E2833C-0x0000000189E284F4
		public int CreateBindingByActionId(string actionId, Action callback, int groupId); // 0x00000001837CE450-0x00000001837CE640
		public void DeleteBinding(int id); // 0x00000001839D03E0-0x00000001839D0480
		public void ToggleBinding(int id, bool active); // 0x00000001837D0EF0-0x00000001837D0F80
		public void CancelPendingLongPress(InputBindingInfo info); // 0x00000001837CFA30-0x00000001837CFA90
		public int CreateGroup(int parentGroupId, IBindingGroupTarget bindingGroupTarget = null); // 0x0000000183793000-0x00000001837932F0
		public void DeleteGroup(int id); // 0x000000018351DCF0-0x000000018351DDA0
		public void DeleteInGroup(int groupId); // 0x000000018453B150-0x000000018453B1C0
		public void ToggleGroup(int id, bool active); // 0x0000000183793B30-0x0000000183793CB0
		public bool IsBindingEnabled(int id, bool needLogError = true /* Metadata: 0x0234C0D6 */); // 0x00000001837CDD30-0x00000001837CE190
		public bool IsGroupParentDisabled(int groupId); // 0x0000000182FAA7F0-0x0000000182FAA9F0
		public void ForceBindingKeyhintToGray(int id, bool grayState); // 0x0000000189E29210-0x0000000189E292C8
		public bool IsBindingKeyhintGray(int id); // 0x0000000189E2A810-0x0000000189E2A8B8
		public bool IsGroupEnabled(int id); // 0x0000000183794C00-0x0000000183794D70
		public void ToggleDebugCursorMode(); // 0x0000000189E2CD58-0x0000000189E2CE14
		public void ClearAllCursorShowRequests(); // 0x0000000183C11A30-0x0000000183C11A90
		public void SetCursorShowRequest(string key, bool showCursor); // 0x0000000183A73590-0x0000000183A73630
		public void ToggleAllInput(bool active); // 0x00000001849D6C20-0x00000001849D6C70
		public void SetBindingView(int bindingId, IBindingView bindingView); // 0x0000000189E2C68C-0x0000000189E2C74C
		public void SetGroupView(int groupId, IBindingView groupView); // 0x0000000183EAD820-0x0000000183EAD8D0
		public void ChangeParent(bool isGroup, int id, int newParentGroupId); // 0x00000001842B5A20-0x00000001842B5BC0
		public int GetGroupParentId(bool isGroup, int id); // 0x00000001842B5940-0x00000001842B5A20
		public void IgnoreBindingGroupParent(int groupId, bool parentIgnored); // 0x0000000189E2A5D8-0x0000000189E2A6A0
		public void IgnoreBindingParent(int bindingId, bool parentIgnored); // 0x0000000189E2A6A0-0x0000000189E2A764
		public Beyond.Input.KeyboardKeyCode GetActionKeyboardKeyCode(string actionId, bool isModifyKey, bool isPrimary, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x0234C0D7 */); // 0x00000001835C6510-0x00000001835C65E0
		public GamepadKeyCode GetActionGamepadKeyCode(string actionId, bool isModifyKey, bool isPrimary, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x0234C0D8 */); // 0x00000001843D1B10-0x00000001843D1BE0
		public void DeleteCustomBinding(string actionId, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x0234C0D9 */); // 0x0000000189E28A0C-0x0000000189E29168
		public void DeleteAllCustomBindings(InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x0234C0DA */); // 0x0000000183C1A700-0x0000000183C1A8B0
		public void SetBindingText(int id, string text); // 0x00000001843EF1A0-0x00000001843EF260
		public string GetBindingText(int id); // 0x0000000189E29464-0x0000000189E29558
		public bool HasBinding(int id); // 0x0000000189E2A550-0x0000000189E2A5D8
		[IDTag(1)]
		public string GetActionText(string actionId); // 0x0000000183CDE140-0x0000000183CDE1B0
		[IDTag(0)]
		public static string GetActionText(PlayerActionInfo info, string actionId); // 0x0000000183CDE1B0-0x0000000183CDE260
		public bool CheckActionKeyCodeConflict(string actionId, Beyond.Input.KeyboardKeyCode keyCode, out bool isPrimary); // 0x0000000189E27ADC-0x0000000189E27BF8
		private void _DeleteGroup(InputBindingGroup group, bool isRootCall); // 0x0000000183792F20-0x0000000183793000
		private void _DeleteInGroup(InputBindingGroup group); // 0x0000000183793D30-0x00000001837943E0
		private void _RealRemoveBindingInfo(InputBindingInfo info); // 0x00000001837D0680-0x00000001837D0760
		public float GetAxis(string name); // 0x00000001832FEEA0-0x00000001832FEF50
		public void GetBindingInfo(int bindingId, out string actionId, out IBindingView bindingView); // 0x00000001837D5240-0x00000001837D5340
		private void _LoadSetting(); // 0x00000001837D17D0-0x00000001837D2230
		public void LoadSetting(); // 0x00000001837D22D0-0x00000001837D2DD0
		public bool IsPlayerActionIdValid(string id); // 0x00000001837D2230-0x00000001837D22D0
		public PlayerActionInfo GetPlayerActionInfo(string id, InputSettingLevel level = InputSettingLevel.Pending /* Metadata: 0x0234C0DB */); // 0x00000001837CE640-0x00000001837CE710
		public void ChangePlayerAction(string id, PlayerActionInfo actionInfo); // 0x0000000189E27A74-0x0000000189E27ADC
		public string AddAnonymousPlayerAction(PlayerActionInfo actionInfo); // 0x0000000189E2748C-0x0000000189E27564
		private void _LoadCustomInputSetting(); // 0x0000000184B0B910-0x0000000184B0B9E0
		private PlayerActionInfo _GetOrCreatePendingActionInfo(string actionId); // 0x0000000189E2E744-0x0000000189E2E9D0
		[IDTag(0)]
		public bool CustomizeActionKey(string actionId, Beyond.Input.KeyboardKeyCode key, bool isPrimary, string overrideKeyIconName = null); // 0x0000000189E287DC-0x0000000189E28A0C
		[IDTag(1)]
		public bool CustomizeActionKey(string actionId, GamepadKeyCode? modifyKey, GamepadKeyCode? key, bool isPrimary, string overrideKeyIconName = null); // 0x0000000189E284F4-0x0000000189E287DC
		public void ClearPendingInputSetting(); // 0x0000000189E28208-0x0000000189E28284
		public void SaveCustomInputSetting(); // 0x0000000183C194D0-0x0000000183C19B50
		private void _CreateCanvas(); // 0x000000018479F7E0-0x000000018479FA80
		private void _CreateDebugVirtualMouse(); // 0x000000018479FA80-0x000000018479FB20
		private void _CreateVirtualMouse(); // 0x000000018479FB20-0x000000018479FCE0
		private void _ToggleVirtualMouse(bool active, bool forceUpdate = false /* Metadata: 0x0234C0DC */); // 0x0000000183A736A0-0x0000000183A73820
		private void _CheckVirtualMouseState(); // 0x0000000183A73630-0x0000000183A736A0
		public static Vector3 GetMousePos(); // 0x0000000183401A40-0x00000001834021D0
		public void SetOnlyVirtualMousePos(Vector2 newPos); // 0x0000000189E2CC48-0x0000000189E2CCE4
		public static void SetMousePos(Vector2 newPos, bool hideVirtualMouse = false /* Metadata: 0x0234C0DD */); // 0x0000000189E2CA5C-0x0000000189E2CC48
		public static bool GetMouseButton(int button); // 0x00000001833FE1F0-0x00000001833FE6A0
		public static bool IsLeftMouseDown(bool requireActive = false /* Metadata: 0x0234C0DE */); // 0x0000000182D454E0-0x0000000182D45EA0
		public static bool GetMouseButtonDown(int button); // 0x0000000183E50260-0x0000000183E50380
		public static bool GetMouseButtonUp(int button); // 0x0000000183E2F900-0x0000000183E2FA40
		public void SetCustomControllerMouse(Transform trans, Camera uiCamera); // 0x0000000189E2C9CC-0x0000000189E2CA5C
		public List<ControllerHintInfo> GetEmptyControllerHintInfoList(); // 0x0000000189E29A94-0x0000000189E29C48
		[IDTag(0)]
		public void GetControllerHintInfos(int groupId, bool ignoreRootEnabled, ref List<ControllerHintInfo> infoList); // 0x0000000189E29608-0x0000000189E296FC
		[IDTag(1)]
		public void GetControllerHintInfos(List<string> actionIdList, ref List<ControllerHintInfo> infoList); // 0x0000000189E29558-0x0000000189E29608
		[IDTag(0)]
		private void _GetControllerHintInfos(InputBindingGroup group, bool ignoreRootEnabled, ref List<ControllerHintInfo> infoList); // 0x0000000189E2DD40-0x0000000189E2E4BC
		[IDTag(1)]
		private void _GetControllerHintInfos(List<string> actionIdList, ref List<ControllerHintInfo> infoList); // 0x0000000189E2DB6C-0x0000000189E2DD40
		public float GetPlayerActionLongPressStartTime(string actionId, out float longPressTime); // 0x0000000189E2A1BC-0x0000000189E2A30C
		public float GetActionBindingLongPressStartTime(int bindingId, out float longPressTime); // 0x0000000189E292C8-0x0000000189E29464
		public void AddGuideUseActionId(string actionId); // 0x0000000189E27564-0x0000000189E27608
		public void RemoveGuideUseActionId(string actionId); // 0x0000000189E2C050-0x0000000189E2C0F4
		public void ClearGuideUseActionIds(); // 0x0000000189E2818C-0x0000000189E28208
		public bool IsGuideUseAction(string actionId); // 0x00000001833FDC80-0x00000001833FDED0
		public bool IsAnyBindingInGroupGuideUse(int groupId); // 0x0000000189E2A764-0x0000000189E2A810
		private bool _IsAnyBindingInGroupGuideUse(InputBindingGroup group); // 0x0000000189E2E9D0-0x0000000189E2ECB8
		public void VibrateController(float time, float level = 0.5f /* Metadata: 0x0234C0DF */); // 0x0000000189E2CF94-0x0000000189E2D048
		private static string _GetGamepadKeyIconFolderPath(); // 0x0000000189E2E4BC-0x0000000189E2E590
		public static string GetStringByKeyboardKeyCode(Beyond.Input.KeyboardKeyCode code); // 0x00000001836D48E0-0x00000001836D4A00
		public static string GetStringByGamepadKeyCode(GamepadKeyCode code); // 0x0000000189E2A368-0x0000000189E2A550
		public static string GetKeyboardIconPath(string keyName, bool isLongPress, bool isFullPath); // 0x0000000189E2A0D0-0x0000000189E2A1BC
		[IDTag(0)]
		public static string GetKeyIconPath(GamepadInput inputInfo, bool isModifyKey, bool isFullPath, bool ignoreOverrideKeyIcon = false /* Metadata: 0x0234C0E3 */); // 0x0000000189E29F74-0x0000000189E2A080
		public static string GetGamepadKeyIconPath(string keyStr, bool isLongPress, bool isFullPath); // 0x0000000189E29C48-0x0000000189E29CF8
		[IDTag(2)]
		public static string GetKeyIconPath(KeyboardInput inputInfo, bool isModifyKey, bool isFullPath); // 0x00000001836D41E0-0x00000001836D4280
		[IDTag(1)]
		public static string GetKeyIconPath(KeyboardInput inputInfo, bool isModifyKey, bool isLongPress, bool isFullPath); // 0x00000001836D4280-0x00000001836D4410
		private static string _GetKeyIconPath(string path, string keyStr, bool isLongPress, bool isFullPath); // 0x00000001836D4410-0x00000001836D44D0
		public static string ParseTextActionId(string text); // 0x000000018489C040-0x000000018489C1B0
		public void MoveMouseTo(RectTransform target, Camera uiCamera); // 0x0000000189E2A8B8-0x0000000189E2AB24
		public void MoveVirtualMouseTo(RectTransform target, Camera uiCamera, bool hideVirtualMouse = true /* Metadata: 0x0234C0E4 */); // 0x0000000189E2AB24-0x0000000189E2ABCC
		public void SetVirtualMouseIconVisible(bool active); // 0x0000000189E2CCE4-0x0000000189E2CD58
		private void _ControllerTouchPanelTick(); // 0x0000000189E2D790-0x0000000189E2D944
		public static int GetTouchId(PointerEventData eventData); // 0x0000000183798D80-0x0000000183798DF0
		public static bool GetPressPosByTouchId(int touchId, out Vector2 position); // 0x00000001842EE640-0x00000001842EE960
		public void Dispose(); // 0x0000000189E29168-0x0000000189E29210
		public static void RemoveUnusedInput(); // 0x0000000189E2C0F4-0x0000000189E2C68C
		private void _OnNetMaskChanged([IsReadOnly] in EventData<bool> v); // 0x0000000183A73460-0x0000000183A734E0
		public string GetCurJsInfos(); // 0x0000000189E296FC-0x0000000189E29A94
		public string GetRealCursorState(); // 0x0000000189E2A30C-0x0000000189E2A368
		[IDTag(2)]
		public string PrintKeycodeInfo(string keyCode, bool checkKeyboard, bool checkGamepad, bool isDetailed = false /* Metadata: 0x0234C0E5 */); // 0x0000000189E2B134-0x0000000189E2B5B8
		[IDTag(0)]
		public string PrintKeycodeInfo(Beyond.Input.KeyboardKeyCode keyCode, bool isDetailed = false /* Metadata: 0x0234C0E6 */); // 0x0000000189E2BAD0-0x0000000189E2C000
		[IDTag(1)]
		public string PrintKeycodeInfo(GamepadKeyCode keyCode, bool isDetailed = false /* Metadata: 0x0234C0E7 */); // 0x0000000189E2B5B8-0x0000000189E2BAD0
		public string PrintActionInfo(string actionId); // 0x0000000189E2AC1C-0x0000000189E2AE94
		public string PrintBindingInfo(InputBindingInfo bindingInfo); // 0x0000000189E2AE94-0x0000000189E2B134
		private string _GetBindingName(object item); // 0x0000000189E2D944-0x0000000189E2DB6C
		private GameObject _GetInputBindingGroupGameObject(InputBindingGroup bindingGroup); // 0x0000000189E2E660-0x0000000189E2E744
		private GameObject _GetInputBindingGameObject(InputBindingInfo bindingInfo); // 0x0000000189E2E590-0x0000000189E2E660
		public DelayedComboBinding RegisterDelayedCombo(string modifierActionId, string triggerActionId, DelayedComboKind kind, float maxModifierHoldTime, Action onTriggered); // 0x0000000184490250-0x0000000184490470
		public void UnregisterDelayedCombo(DelayedComboBinding binding); // 0x0000000189E2CEFC-0x0000000189E2CF94
		private void _OnDelayedComboActionKeyUpdated([IsReadOnly] in EventData<string> data); // 0x0000000189E2EF48-0x0000000189E2F04C
		private void _RefreshDelayedComboKeys(DelayedComboBinding binding); // 0x00000001844904D0-0x0000000184490560
		private void _UpdateDelayedCombos(float deltaTime); // 0x00000001836E8640-0x00000001836E9110
		private void _UpdateModifierTapThenTriggerCombo(DelayedComboBinding binding, float deltaTime); // 0x00000001836E9110-0x00000001836E91E0
		private void _UpdateTriggerThenModifierCombo(DelayedComboBinding binding); // 0x00000001836E91E0-0x00000001836E9610
		[CompilerGenerated]
		private void __Init_b__68_0(Beyond.Input.KeyboardKeyCode key); // 0x0000000189E2CEBC-0x0000000189E2CEDC
		[CompilerGenerated]
		private void __Init_b__68_1(GamepadKeyCode key); // 0x0000000189E2CEDC-0x0000000189E2CEFC
		[CompilerGenerated]
		private void __Init_b__68_2(); // 0x0000000183A73530-0x0000000183A73590
		[CompilerGenerated]
		private void __Init_b__68_3(); // 0x0000000183A734E0-0x0000000183A73530
	}

	public class InputRebindConfig : ScriptableObject // TypeDefIndex: 58900
	{
		// Fields
		public const string INPUT_REBIND_CONFIG_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Input/InputRebindConfig.asset"; // Metadata: 0x0234C21F
		public InputRebindActionScopeConfig[] actionScopeConfigs; // 0x18
	
		// Constructors
		public InputRebindConfig(); // 0x0000000183573370-0x0000000183573380
	}

	[Serializable]
	public class InputRebindActionScopeConfig // TypeDefIndex: 58901
	{
		// Fields
		public string name; // 0x10
		public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeWhiteList; // 0x18
		public Beyond.Input.KeyboardKeyCode[] keyboardKeyCodeBlackList; // 0x20
	
		// Constructors
		public InputRebindActionScopeConfig(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class InputSetting : ScriptableObject // TypeDefIndex: 58902
	{
		// Fields
		public const string CUSTOM_SETTING_DIRECTORY_NAME = "Input"; // Metadata: 0x0234C266
		public const string CUSTOM_SETTING_JSON_FILE_NAME = "CustomInputSetting.json"; // Metadata: 0x0234C26C
		[SerializeField]
		public SerializeFieldDictionaryPaired<string, PlayerActionInfo> actionInfos; // 0x18
	
		// Constructors
		public InputSetting(); // 0x000000018454B380-0x000000018454B410
	}

	public class InputSettingConfig : ScriptableObject // TypeDefIndex: 58903
	{
		// Fields
		public const string INPUT_SETTING_CONFIG_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Input/InputSettingConfig.asset"; // Metadata: 0x0234C284
		public List<InputSetting> inputSettingList; // 0x18
	
		// Constructors
		public InputSettingConfig(); // 0x0000000184D22DA0-0x0000000184D22E20
	}

	public static class InputUtils // TypeDefIndex: 58904
	{
		// Methods
		public static bool HasFlag(InputDeviceFlags value, InputDeviceFlags target); // 0x0000000189E3A5E8-0x0000000189E3A644
	
		// Extension methods
		public static void IgnoreBindingParent(this IBindingTarget target, bool active); // 0x0000000189E3A6F0-0x0000000189E3A7E0
		public static void IgnoreBindingGroupParent(this IBindingGroupTarget target, bool active); // 0x0000000189E3A644-0x0000000189E3A6F0
	}

	internal abstract class KeyboardCheckerBase // TypeDefIndex: 58907
	{
		// Fields
		protected Beyond.Input.InputManager m_inputManager; // 0x10
		protected const int CTRL = 1; // Metadata: 0x0234C2CD
		protected const int SHIFT = 2; // Metadata: 0x0234C2CE
		protected const int ALT = 4; // Metadata: 0x0234C2CF
		protected const int MAX_INDEX = 7; // Metadata: 0x0234C2D0
		protected static int[] s_checkPriority; // 0x00
		protected List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<Binding>>> m_bindingInfos; // 0x18
	
		// Properties
		internal List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<Binding>>> bindingInfos { get; } // 0x0000000189E3A824-0x0000000189E3A874 
	
		// Nested types
		public class Binding // TypeDefIndex: 58905
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
			public Binding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0234C2D1 */); // 0x00000001837D0D30-0x00000001837D0DF0
		}
	
		public enum TriggerType // TypeDefIndex: 58906
		{
			NORMAL = 0,
			CONTINUOUS = 1,
			STOP_CONTINUOUS = 2
		}
	
		// Constructors
		protected KeyboardCheckerBase(Beyond.Input.InputManager inputManager); // 0x00000001842B5820-0x00000001842B5940
		static KeyboardCheckerBase(); // 0x0000000184D17B50-0x0000000184D17BE0
	
		// Methods
		public static int GetModifyIndex(KeyboardInput input); // 0x00000001837D0CD0-0x00000001837D0D30
		public virtual Binding OnCreateBinding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0234C2CC */); // 0x00000001837D0B50-0x00000001837D0CD0
		public virtual Binding OnDeleteBinding(KeyboardInput input, InputBindingInfo info); // 0x00000001837D08E0-0x00000001837D0B50
		public virtual void CheckKeyboardInput(); // 0x0000000189E3A7E0-0x0000000189E3A824
		public virtual void TriggerActions(); // 0x0000000184066A20-0x0000000184066A70
	}

	internal class KeyboardChecker : KeyboardCheckerBase // TypeDefIndex: 58908
	{
		// Fields
		private Func<Beyond.Input.KeyboardKeyCode, bool> m_checkFunc; // 0x20
		[CompilerGenerated]
		private bool _isPressChecker_k__BackingField; // 0x28
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x30
		private List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x38
	
		// Properties
		public bool isPressChecker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
	
		// Constructors
		public KeyboardChecker(Func<Beyond.Input.KeyboardKeyCode, bool> checkFunc, bool isPress, Beyond.Input.InputManager inputManager); // 0x00000001842B56C0-0x00000001842B5820
	
		// Methods
		public override void CheckKeyboardInput(); // 0x0000000183307E80-0x0000000183308790
		public override void TriggerActions(); // 0x0000000183629670-0x0000000183629C00
		public void __iFixBaseProxy_CheckKeyboardInput(); // 0x0000000189E3A874-0x0000000189E3A87C
		public void __iFixBaseProxy_TriggerActions(); // 0x0000000189E3A87C-0x0000000189E3A884
	}

	internal class KeyboardOnClickChecker : KeyboardCheckerBase // TypeDefIndex: 58909
	{
		// Fields
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x20
		private List<ValueTuple<Binding, TriggerType>> m_tmpNeedTriggerCallbacks; // 0x28
		private List<ListSet<Beyond.Input.KeyboardKeyCode>> m_combinationKeyPressedInfo; // 0x30
	
		// Constructors
		public KeyboardOnClickChecker(Beyond.Input.InputManager inputManager); // 0x00000001842B5DB0-0x00000001842B5FB0
	
		// Methods
		public override void CheckKeyboardInput(); // 0x0000000183306AA0-0x0000000183307E80
		public override void TriggerActions(); // 0x0000000183629260-0x0000000183629670
		public void ClearKeyPressed(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000189E3A884-0x0000000189E3AB64
		public void __iFixBaseProxy_CheckKeyboardInput(); // 0x0000000189E3A874-0x0000000189E3A87C
		public void __iFixBaseProxy_TriggerActions(); // 0x0000000189E3A87C-0x0000000189E3A884
	}

	internal class KeyboardOnLongPressChecker : KeyboardCheckerBase // TypeDefIndex: 58911
	{
		// Fields
		private Action<Beyond.Input.KeyboardKeyCode> m_onTriggerOnLongPress; // 0x20
		private Dictionary<KeyboardInput, HashSet<Binding>> m_bindings; // 0x28
		private HashSet<Beyond.Input.KeyboardKeyCode> m_usedKeyCache; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 58910
		{
			// Fields
			public ValueTuple<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>> key; // 0x10
			public KeyboardCheckerBase.Binding targetBinding; // 0x20
			public KeyboardOnLongPressChecker __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CheckKeyboardInput_b__0(); // 0x0000000189E40C1C-0x0000000189E40C48
		}
	
		// Constructors
		public KeyboardOnLongPressChecker(Action<Beyond.Input.KeyboardKeyCode> onTriggerOnLongPress, Beyond.Input.InputManager inputManager); // 0x00000001842B5FB0-0x00000001842B60D0
	
		// Methods
		public override void CheckKeyboardInput(); // 0x0000000183304F20-0x0000000183305AC0
		private void _OnTriggerBinding(Binding binding, Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000189E40240-0x0000000189E40460
		public override Binding OnCreateBinding(KeyboardInput input, InputBindingInfo info, bool isUsedForBlock = false /* Metadata: 0x0234C2D5 */); // 0x0000000189E3FF90-0x0000000189E40108
		public override Binding OnDeleteBinding(KeyboardInput input, InputBindingInfo info); // 0x0000000189E40108-0x0000000189E40228
		public void CancelPendingLongPress(InputBindingInfo info); // 0x00000001837CFA90-0x00000001837CFCA0
		public float GetInputLongPressStartTime(KeyboardInput input, int bindingId = 0 /* Metadata: 0x0234C2D6 */); // 0x0000000189E3FD80-0x0000000189E3FF90
		public void __iFixBaseProxy_CheckKeyboardInput(); // 0x0000000189E3A874-0x0000000189E3A87C
		public Binding __iFixBaseProxy_OnCreateBinding(KeyboardInput P0, InputBindingInfo P1, bool P2); // 0x0000000189E40228-0x0000000189E40238
		public Binding __iFixBaseProxy_OnDeleteBinding(KeyboardInput P0, InputBindingInfo P1); // 0x0000000189E40238-0x0000000189E40240
	}

	public class KeyboardHandler // TypeDefIndex: 58912
	{
		// Fields
		private static Dictionary<Beyond.Input.KeyboardKeyCode, UnityEngine.InputSystem.Key> s_keyMap; // 0x00
		private Dictionary<Beyond.Input.KeyboardKeyCode, string> m_localizedKeyName; // 0x10
		private Dictionary<string, string> m_localizedIconName; // 0x18
		private Dictionary<KeyboardType, KeyboardOverrideConfig> m_configs; // 0x20
		private KeyboardType m_keyboardType; // 0x28
	
		// Constructors
		static KeyboardHandler(); // 0x00000001844B64B0-0x00000001844B80F0
		public KeyboardHandler(); // 0x000000018432BD40-0x000000018432BE50
	
		// Methods
		public static bool GetKey(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000189E3F604-0x0000000189E3F6CC
		public static bool GetKeyDown(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000189E3F474-0x0000000189E3F53C
		public static bool GetKeyUp(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000189E3F53C-0x0000000189E3F604
		public void ParseConfig(KeyboardLocalizeConfig keyboardConfig); // 0x00000001847310D0-0x00000001847311B0
		public KeyboardType GetKeyboardType(); // 0x0000000189E3F6CC-0x0000000189E3F718
		public void SetKeyboardType(KeyboardType keyboardType); // 0x00000001847311B0-0x00000001847312B0
		public string GetEscIconName(); // 0x0000000189E3F314-0x0000000189E3F350
		public string GetIconNameByKeyName(string keyName); // 0x0000000189E3F350-0x0000000189E3F3D4
		public string GetIconName(Beyond.Input.KeyboardKeyCode keyCode); // 0x0000000189E3F3D4-0x0000000189E3F474
	}

	public class KeyboardLocalizeConfig : ScriptableObject // TypeDefIndex: 58913
	{
		// Fields
		public const string KEYBOARD_CONFIG_PATH = "Assets/@Options/KeyboardLocalizeConfig.asset"; // Metadata: 0x0234C2D7
		public KeyboardOverrideConfig[] keyboardConfigs; // 0x18
	
		// Constructors
		public KeyboardLocalizeConfig(); // 0x0000000183573370-0x0000000183573380
	}

	[Serializable]
	public class KeyboardOverrideConfig // TypeDefIndex: 58914
	{
		// Fields
		public KeyboardType keyboardType; // 0x10
		public KeyboardOverrideIconConfig[] overrideIconConfigs; // 0x18
	
		// Constructors
		public KeyboardOverrideConfig(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class KeyboardOverrideIconConfig // TypeDefIndex: 58915
	{
		// Fields
		public Beyond.Input.KeyboardKeyCode keyCode; // 0x10
		public string keyName; // 0x18
		public string iconName; // 0x20
	
		// Constructors
		public KeyboardOverrideIconConfig(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	public class PlayerActionIdAttribute : Attribute // TypeDefIndex: 58916
	{
		// Constructors
		public PlayerActionIdAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Flags]
	public enum InputDeviceFlags : byte // TypeDefIndex: 58917
	{
		None = 0,
		Keyboard = 1,
		Gamepad = 2,
		All = 3
	}

	[Serializable]
	public class PlayerActionInfo // TypeDefIndex: 58918
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
		public PlayerActionInfo(); // 0x00000001815EFCD0-0x00000001815EFCE0
	
		// Methods
		public void ResetHintProority(); // 0x0000000189E40644-0x0000000189E40730
		public bool DeviceInputEquals(PlayerActionInfo other, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x0234C308 */); // 0x0000000189E4053C-0x0000000189E40644
		public void DeviceInputCopyFrom(PlayerActionInfo other, InputDeviceFlags deviceFlags = InputDeviceFlags.None | InputDeviceFlags.Keyboard | InputDeviceFlags.Gamepad | InputDeviceFlags.All /* Metadata: 0x0234C309 */); // 0x0000000189E40460-0x0000000189E4053C
	}

	[Serializable]
	public abstract class DeviceInput<T> : IEquatable<T> // TypeDefIndex: 58919
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
	public class KeyboardInput : DeviceInput<KeyboardInput> // TypeDefIndex: 58920
	{
		// Fields
		public Beyond.Input.KeyboardKeyCode key; // 0x30
		public bool useCtrl; // 0x34
		public bool useShift; // 0x35
		public bool useAlt; // 0x36
	
		// Properties
		public string modifyString { get; } // 0x0000000189E3FCA4-0x0000000189E3FD80 
	
		// Constructors
		public KeyboardInput(); // 0x0000000184DA0C20-0x0000000184DA0C40
	
		// Methods
		public override string GetModifyText(); // 0x0000000189E3FB18-0x0000000189E3FC1C
		public override string GetKeyCodeText(); // 0x0000000189E3F8C8-0x0000000189E3FB18
		public override int GetKeyCodeEnumIntValue(); // 0x0000000189E3F87C-0x0000000189E3F8C8
		public override void SetKeyCodeEnumByIntValue(int value); // 0x0000000189E3FC1C-0x0000000189E3FC74
		public override void ClearKeyCode(); // 0x0000000189E3F718-0x0000000189E3F774
		public override bool IsValid(); // 0x0000000184CC5BB0-0x0000000184CC5BE0
		public override void CopyFrom(KeyboardInput other); // 0x0000000189E3F774-0x0000000189E3F814
		public override bool Equals(KeyboardInput other); // 0x0000000189E3F814-0x0000000189E3F87C
		public string __iFixBaseProxy_GetModifyText(); // 0x0000000189E3FC8C-0x0000000189E3FC94
		public string __iFixBaseProxy_GetKeyCodeText(); // 0x0000000189E3FC84-0x0000000189E3FC8C
		public int __iFixBaseProxy_GetKeyCodeEnumIntValue(); // 0x0000000189E3FC7C-0x0000000189E3FC84
		public void __iFixBaseProxy_SetKeyCodeEnumByIntValue(int P0); // 0x0000000189E3FC9C-0x0000000189E3FCA4
		public void __iFixBaseProxy_ClearKeyCode(); // 0x0000000189E3FC74-0x0000000189E3FC7C
		public bool __iFixBaseProxy_IsValid(); // 0x0000000189E3FC94-0x0000000189E3FC9C
	}

	[Serializable]
	public class GamepadInput : DeviceInput<GamepadInput> // TypeDefIndex: 58921
	{
		// Fields
		public GamepadKeyCode key; // 0x30
		public GamepadKeyCode modifyKey; // 0x34
	
		// Constructors
		public GamepadInput(); // 0x0000000184DA0C20-0x0000000184DA0C40
	
		// Methods
		public override string GetModifyText(); // 0x0000000189E3AEEC-0x0000000189E3AF94
		public override string GetKeyCodeText(); // 0x0000000189E3AE64-0x0000000189E3AEEC
		public override int GetKeyCodeEnumIntValue(); // 0x0000000189E3AE18-0x0000000189E3AE64
		public override void SetKeyCodeEnumByIntValue(int value); // 0x0000000189E3AFE4-0x0000000189E3B03C
		public override void ClearKeyCode(); // 0x0000000189E3AD24-0x0000000189E3AD84
		public override bool IsValid(); // 0x0000000189E3AF94-0x0000000189E3AFE4
		public override void CopyFrom(GamepadInput other); // 0x0000000189E3AD84-0x0000000189E3AE18
		public override bool Equals(GamepadInput other); // 0x0000000184CB2580-0x0000000184CB25D0
		public string __iFixBaseProxy_GetModifyText(); // 0x0000000189E3B054-0x0000000189E3B05C
		public string __iFixBaseProxy_GetKeyCodeText(); // 0x0000000189E3B04C-0x0000000189E3B054
		public int __iFixBaseProxy_GetKeyCodeEnumIntValue(); // 0x0000000189E3B044-0x0000000189E3B04C
		public void __iFixBaseProxy_SetKeyCodeEnumByIntValue(int P0); // 0x0000000189E3B064-0x0000000189E3B06C
		public void __iFixBaseProxy_ClearKeyCode(); // 0x0000000189E3B03C-0x0000000189E3B044
		public bool __iFixBaseProxy_IsValid(); // 0x0000000189E3B05C-0x0000000189E3B064
	}

	internal struct CursorRequest // TypeDefIndex: 58922
	{
		// Fields
		public string key; // 0x00
		public int priority; // 0x08
		public bool show; // 0x0C
	
		// Methods
		public override string ToString(); // 0x0000000189E3AC40-0x0000000189E3ACD4
		public string __iFixBaseProxy_ToString(); // 0x0000000189E3ACD4-0x0000000189E3AD24
	}

	internal static class CursorPriority // TypeDefIndex: 58923
	{
		// Fields
		public const int DEVICE_CHANGE_OVERRIDE = 0; // Metadata: 0x0234C30A
		public const int CONTROLLER_HIDE = 10; // Metadata: 0x0234C30B
		public const int EDITOR_DEBUG_FORCE_SHOW = 20; // Metadata: 0x0234C30C
		public const int SHOW_REQUEST = 100; // Metadata: 0x0234C30D
	}

	internal class RealCursorManager // TypeDefIndex: 58924
	{
		// Fields
		private Dictionary<string, CursorRequest> m_requests; // 0x10
		private CursorRequest m_activeHighest; // 0x18
		private bool m_isUsingVirtualMouse; // 0x28
	
		// Properties
		public bool isDebugForceShow { get; } // 0x0000000189E40B90-0x0000000189E40C1C 
	
		// Constructors
		public RealCursorManager(); // 0x00000001842B64C0-0x00000001842B6550
	
		// Methods
		public bool HasAnyShowRequestAtPriority(int priority); // 0x0000000189E40A10-0x0000000189E40B90
		public void SetRequest(string key, int priority, bool show); // 0x0000000183A73820-0x0000000183A738E0
		public void RemoveRequest(string key); // 0x0000000183A73C70-0x0000000183A73CF0
		public void RemoveAllRequestsAtPriority(int priority); // 0x000000018485D800-0x000000018485DC60
		public void SetVirtualMouseActive(bool active); // 0x0000000183DF9C70-0x0000000183DF9CB0
		public void CalcState(bool forceUpdate = false /* Metadata: 0x0234C30F */); // 0x0000000183A738E0-0x0000000183A73950
		private void _RefreshActiveHighest(); // 0x0000000183A73A90-0x0000000183A73C70
		private void _ToggleCursorInternal(bool enable, bool forceUpdate = false /* Metadata: 0x0234C310 */); // 0x0000000183A73950-0x0000000183A73A10
		public string DumpState(); // 0x0000000189E40730-0x0000000189E40A10
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	public class TextIdAttribute : Attribute // TypeDefIndex: 58925
	{
		// Constructors
		public TextIdAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class UIEvent : UnityEvent, IBindingTarget // TypeDefIndex: 58926
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
		public bool bindingEnabled { get; } // 0x0000000189E41418-0x0000000189E414C0 
		public int bindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86550-0x0000000184D86560 0x0000000184D865A0-0x0000000184D865B0
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public int count { get; } // 0x0000000189E414C0-0x0000000189E4153C 
	
		// Constructors
		public UIEvent(); // 0x0000000189E41408-0x0000000189E41418
	
		// Methods
		private void _CreatePlayerActionBinding(); // 0x0000000189E412D4-0x0000000189E41408
		public void InitBinding(IBindingGroupTarget parent, Action bindAct, Action onUpdateKeyAct); // 0x0000000189E40E04-0x0000000189E40EDC
		public new void Invoke(); // 0x0000000189E40EDC-0x0000000189E40FAC
		public void UpdateKeys(); // 0x0000000189E41234-0x0000000189E412D4
		public void ChangeBindingPlayerAction(string actionId); // 0x0000000189E40D98-0x0000000189E40E04
		public new void AddListener(UnityAction call); // 0x0000000189E40C48-0x0000000189E40D98
		public new void RemoveListener(UnityAction call); // 0x0000000189E41164-0x0000000189E41234
		public new void RemoveAllListeners(); // 0x0000000189E40FAC-0x0000000189E41164
	}

	[Serializable]
	public class UIEvent<T0> : UnityEvent<T0>, IBindingTarget // TypeDefIndex: 58927
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
	public class UIEvent<T0, T1> : UnityEvent<T0, T1>, IBindingTarget // TypeDefIndex: 58928
	{
		// Fields
		private bool m_bindingInit;
		[FormerlySerializedAs("useBindingKeys")]
		[FormerlySerializedAs("_useBindingKeys")]
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
	internal class DataNAttribute : Attribute // TypeDefIndex: 58859
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 58860
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 58861
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 58862
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 58863
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 58856
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58931
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37AA0-0x0000000184D37B10
	
		// Methods
		public bool __Gen_Wrap_0(object P0); // 0x00000001863632E4-0x00000001863633B4
		public uint __Gen_Wrap_1(); // 0x00000001863621C4-0x0000000186362270
		public void __Gen_Wrap_2(object P0); // 0x00000001863633B4-0x0000000186363474
		public void __Gen_Wrap_3(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public void __Gen_Wrap_4(object P0, bool P1, bool P2); // 0x0000000187199240-0x0000000187199338
		public void __Gen_Wrap_5(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public void __Gen_Wrap_6(object P0, int P1, bool P2); // 0x00000001866C44C0-0x00000001866C45B8
		public void __Gen_Wrap_7(object P0, NavigationBindingType P1); // 0x00000001866F3838-0x00000001866F3914
		public bool __Gen_Wrap_8(object P0, int P1); // 0x00000001866E0A9C-0x00000001866E0B88
		public void __Gen_Wrap_9(object P0, object P1, bool P2); // 0x00000001866C43C8-0x00000001866C44C0
		public bool __Gen_Wrap_10(object P0, object P1, object P2); // 0x0000000187195DFC-0x0000000187195F04
		public int __Gen_Wrap_11(object P0, int P1, object P2); // 0x00000001871BADB4-0x00000001871BAEB8
		public int __Gen_Wrap_12(object P0); // 0x0000000186360E84-0x0000000186360F54
		public Vector3 __Gen_Wrap_13(object P0, NaviDirection P1); // 0x0000000189E3B710-0x0000000189E3B82C
		public Vector3 __Gen_Wrap_14(object P0, Vector2 P1); // 0x0000000189E3B82C-0x0000000189E3B970
		public Selectable __Gen_Wrap_15(object P0, object P1, Vector3 P2, Vector3 P3, NaviStrategy P4, double P5, out double P6); // 0x0000000189E3B970-0x0000000189E3BB3C
		public Selectable __Gen_Wrap_16(object P0, object P1, Vector3 P2, Vector3 P3, double P4, out double P5); // 0x0000000189E3BB3C-0x0000000189E3BCF8
		public bool __Gen_Wrap_17(object P0, NaviDirection P1); // 0x00000001869AB898-0x00000001869AB970
		public LinkedListNode<SelectableNaviGroup> __Gen_Wrap_18(object P0, object P1); // 0x0000000189E3BCF8-0x0000000189E3BE04
		public bool __Gen_Wrap_19(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public void __Gen_Wrap_20(object P0, object P1, NavigationBindingType P2); // 0x00000001863778A4-0x0000000186377988
		public SelectableNaviGroup __Gen_Wrap_21(object P0); // 0x0000000189E3BE04-0x0000000189E3BEF4
		public void __Gen_Wrap_22(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public void __Gen_Wrap_23(object P0, object P1, object P2, object P3); // 0x0000000186373E64-0x0000000186373F5C
		public void __Gen_Wrap_24(object P0, NaviDirection P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __Gen_Wrap_25(object P0); // 0x0000000189E3BEF4-0x0000000189E3BFD0
		public DynamicFastLookupCollection<GamepadKeyCode, DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>>> __Gen_Wrap_26(object P0); // 0x0000000189E3BFD0-0x0000000189E3C0AC
		public DynamicFastLookupCollection<GamepadKeyCode, HashSet<GamepadCheckerBase.Binding>> __Gen_Wrap_27(object P0, object P1); // 0x0000000189E3C0AC-0x0000000189E3C1B8
		public GamepadCheckerBase.Binding __Gen_Wrap_28(object P0, object P1, object P2, bool P3); // 0x0000000189E3C1B8-0x0000000189E3C2EC
		public GamepadCheckerBase.Binding __Gen_Wrap_29(object P0, object P1, object P2); // 0x0000000189E3C2EC-0x0000000189E3C414
		public void __Gen_Wrap_30(object P0, object P1, GamepadKeyCode P2); // 0x00000001863778A4-0x0000000186377988
		public void __Gen_Wrap_31(); // 0x00000001863761FC-0x0000000186376284
		public void __Gen_Wrap_32(object P0, InputContinuousTriggerType P1); // 0x00000001866F3838-0x00000001866F3914
		public IBindingView __Gen_Wrap_33(object P0); // 0x0000000189E3C414-0x0000000189E3C504
		public void __Gen_Wrap_34(object P0, GamepadKeyCode P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public PlayerActionInfo __Gen_Wrap_35(object P0, object P1, InputSettingLevel P2); // 0x0000000189E3C504-0x0000000189E3C628
		public string __Gen_Wrap_36(object P0, object P1); // 0x0000000189E3C628-0x0000000189E3C734
		public string __Gen_Wrap_37(object P0); // 0x0000000189E3C734-0x0000000189E3C824
		public Action __Gen_Wrap_38(object P0, object P1, GamepadKeyCode P2); // 0x0000000189E3C824-0x0000000189E3C938
		public float __Gen_Wrap_39(object P0, object P1, int P2); // 0x0000000189E3C938-0x0000000189E3CA3C
		public bool __Gen_Wrap_40(GamepadKeyCode P0); // 0x00000001863655AC-0x0000000186365664
		public RectTransform __Gen_Wrap_41(object P0); // 0x0000000189E3CA3C-0x0000000189E3CB2C
		public float __Gen_Wrap_42(object P0); // 0x0000000189E3CB2C-0x0000000189E3CBE8
		public void __Gen_Wrap_43(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public UnityEngine.InputSystem.Mouse __Gen_Wrap_44(object P0); // 0x0000000189E3CBE8-0x0000000189E3CCD8
		public InputActionProperty __Gen_Wrap_45(object P0); // 0x0000000189E3CCD8-0x0000000189E3CDDC
		public void __Gen_Wrap_46(ref InputActionProperty P0, InputActionProperty P1); // 0x0000000189E3CDDC-0x0000000189E3CF54
		public void __Gen_Wrap_47(object P0, InputActionProperty P1); // 0x0000000189E3CF54-0x0000000189E3D05C
		public void __Gen_Wrap_48(InputActionProperty P0, object P1, bool P2); // 0x0000000189E3D05C-0x0000000189E3D180
		public void __Gen_Wrap_49(object P0, UnityEngine.InputSystem.InputAction.CallbackContext P1); // 0x0000000189E3D180-0x0000000189E3D280
		public int __Gen_Wrap_50(); // 0x00000001863621C4-0x0000000186362270
		public KeyboardCheckerBase.Binding __Gen_Wrap_51(object P0, object P1, object P2, bool P3); // 0x0000000189E3D280-0x0000000189E3D3B4
		public int __Gen_Wrap_52(object P0, object P1, object P2, int P3); // 0x0000000189E3D3B4-0x0000000189E3D4C8
		public bool __Gen_Wrap_53(Selectable P0); // 0x00000001866C53B4-0x00000001866C5470
		public Selectable __Gen_Wrap_54(object P0); // 0x0000000189E3D4C8-0x0000000189E3D5A4
		public KeyboardCheckerBase.Binding __Gen_Wrap_55(object P0, object P1, object P2); // 0x0000000189E3D5A4-0x0000000189E3D6CC
		public void __Gen_Wrap_56(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public object __Gen_Wrap_57(object P0); // 0x0000000189E3D6CC-0x0000000189E3D7A8
		public IBindingGroupTarget __Gen_Wrap_58(object P0); // 0x0000000189E3D7A8-0x0000000189E3D884
		public bool __Gen_Wrap_59(); // 0x00000001863623A8-0x0000000186362454
		public Vector2 __Gen_Wrap_60(object P0, bool P1, bool P2); // 0x0000000189E3D884-0x0000000189E3D9AC
		public float __Gen_Wrap_61(object P0, bool P1); // 0x0000000189E3D9AC-0x0000000189E3DA98
		public Vector2 __Gen_Wrap_62(); // 0x0000000189E3DA98-0x0000000189E3DB64
		public void __Gen_Wrap_63(bool P0); // 0x0000000186375088-0x0000000186375148
		public void __Gen_Wrap_64(object P0, object P1, int P2, bool P3); // 0x0000000189E3DB64-0x0000000189E3DC6C
		public void __Gen_Wrap_65(Beyond.DeviceInfo.InputType P0); // 0x000000018635FF24-0x000000018635FFE4
		public void __Gen_Wrap_66(object P0, Beyond.DeviceInfo.InputType P1); // 0x00000001866F3838-0x00000001866F3914
		public KeyboardType __Gen_Wrap_67(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public void __Gen_Wrap_68(object P0, KeyboardType P1); // 0x00000001866F3838-0x00000001866F3914
		public Dictionary<string, HashSet<int>> __Gen_Wrap_69(object P0); // 0x0000000189E3DC6C-0x0000000189E3DD5C
		public void __Gen_Wrap_70(object P0, object P1, float P2); // 0x00000001871C15C8-0x00000001871C16C4
		public void __Gen_Wrap_71(object P0, Beyond.Input.KeyboardKeyCode P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public void __Gen_Wrap_72(Beyond.Input.KeyboardKeyCode P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_73(GamepadKeyCode P0); // 0x0000000186301ED4-0x0000000186301F80
		public Beyond.DeviceInfo.ControllerType __Gen_Wrap_74(object P0, object P1, out bool P2); // 0x0000000182D541E0-0x0000000182D54B10
		public string __Gen_Wrap_75(GamepadKeyCode P0); // 0x0000000189E3DD5C-0x0000000189E3DE48
		public string __Gen_Wrap_76(); // 0x0000000189E3DE48-0x0000000189E3DF14
		public string __Gen_Wrap_77(object P0, object P1, bool P2, bool P3); // 0x0000000189E3DF14-0x0000000189E3E048
		public string __Gen_Wrap_78(object P0, bool P1, bool P2); // 0x0000000189E3E048-0x0000000189E3E170
		public string __Gen_Wrap_79(object P0, bool P1, bool P2, bool P3); // 0x0000000189E3E170-0x0000000189E3E2A4
		public void __Gen_Wrap_80(object P0, in EventData<bool> P1); // 0x0000000189E3E2A4-0x0000000189E3E3C4
		public bool __Gen_Wrap_81(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2); // 0x0000000189E3E3C4-0x0000000189E3E4DC
		public bool __Gen_Wrap_82(object P0, object P1, out Beyond.Input.KeyboardKeyCode P2, out bool P3); // 0x0000000189E3E4DC-0x0000000189E3E628
		public bool __Gen_Wrap_83(object P0, GamepadKeyCode P1, Beyond.Input.InputManager.KeyCodeState P2); // 0x0000000186A2DAF8-0x0000000186A2DBFC
		public int __Gen_Wrap_84(object P0, object P1, object P2, int P3, out string P4); // 0x0000000189E3E628-0x0000000189E3E798
		public int __Gen_Wrap_85(object P0, Beyond.Input.KeyboardKeyCode P1, object P2, InputTimingType P3, object P4, int P5); // 0x0000000189E3E798-0x0000000189E3E8BC
		public bool __Gen_Wrap_86(object P0, int P1, bool P2); // 0x0000000189E3E8BC-0x0000000189E3E9C0
		public void __Gen_Wrap_87(object P0, int P1, object P2); // 0x00000001866F4C88-0x00000001866F4D80
		public void __Gen_Wrap_88(object P0, bool P1, int P2, int P3); // 0x0000000189E3E9C0-0x0000000189E3EAC8
		public int __Gen_Wrap_89(object P0, bool P1, int P2); // 0x0000000189E3EAC8-0x0000000189E3EBCC
		public Beyond.Input.KeyboardKeyCode __Gen_Wrap_90(object P0, object P1, bool P2, bool P3, InputSettingLevel P4); // 0x0000000189E3EBCC-0x0000000189E3ECF0
		public GamepadKeyCode __Gen_Wrap_91(object P0, object P1, bool P2, bool P3, InputSettingLevel P4); // 0x0000000189E3EBCC-0x0000000189E3ECF0
		public bool __Gen_Wrap_92(InputDeviceFlags P0, InputDeviceFlags P1); // 0x0000000186373694-0x0000000186373780
		public bool __Gen_Wrap_93(object P0, object P1, InputDeviceFlags P2); // 0x0000000189E3ECF0-0x0000000189E3EDF8
		public void __Gen_Wrap_94(object P0, object P1, InputDeviceFlags P2); // 0x00000001871BBFCC-0x00000001871BC0C4
		public void __Gen_Wrap_95(object P0, InputDeviceFlags P1); // 0x0000000189E3EDF8-0x0000000189E3EED4
		public string __Gen_Wrap_96(object P0, int P1); // 0x0000000189E3EED4-0x0000000189E3EFE0
		public bool __Gen_Wrap_97(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, out bool P3); // 0x0000000189E3EFE0-0x0000000189E3F108
		public float __Gen_Wrap_98(object P0, object P1); // 0x00000001866C0800-0x00000001866C08EC
		public void __Gen_Wrap_99(object P0, int P1, out string P2, out IBindingView P3); // 0x0000000189E3F108-0x0000000189E3F280
		public PlayerActionInfo __Gen_Wrap_100(object P0, object P1); // 0x0000000189E3B06C-0x0000000189E3B178
		public bool __Gen_Wrap_101(object P0, object P1, Beyond.Input.KeyboardKeyCode P2, bool P3, object P4); // 0x0000000189E3B178-0x0000000189E3B29C
		public bool __Gen_Wrap_102(object P0, object P1, GamepadKeyCode? P2, GamepadKeyCode? P3, bool P4, object P5); // 0x0000000189E3B29C-0x0000000189E3B40C
		public Vector3 __Gen_Wrap_103(); // 0x0000000189E3B40C-0x0000000189E3B500
		public void __Gen_Wrap_104(Vector2 P0, bool P1); // 0x0000000189E3B500-0x0000000189E3B608
		public void __Gen_Wrap_105(object P0, Vector2 P1); // 0x0000000189E3B608-0x0000000189E3B710
		public bool __Gen_Wrap_106(int P0); // 0x0000000186361FA4-0x0000000186362070
		public bool __Gen_Wrap_107(bool P0); // 0x0000000182D4A050-0x0000000182D4A250
		public List<Beyond.Input.InputManager.ControllerHintInfo> __Gen_Wrap_108(object P0); // 0x0000000182D4A250-0x0000000182D4AB80
		public void __Gen_Wrap_109(object P0, object P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3); // 0x0000000182D4AB80-0x0000000182D4B730
		public void __Gen_Wrap_110(object P0, int P1, bool P2, ref List<Beyond.Input.InputManager.ControllerHintInfo> P3); // 0x0000000182D4B730-0x0000000182D4C200
		public void __Gen_Wrap_111(object P0, object P1, ref List<Beyond.Input.InputManager.ControllerHintInfo> P2); // 0x0000000182D4C200-0x0000000182D4CD90
		public float __Gen_Wrap_112(object P0, object P1, out float P2); // 0x0000000182D4CD90-0x0000000182D4D1A0
		public float __Gen_Wrap_113(object P0, int P1, out float P2); // 0x0000000181774E60-0x00000001817751A0
		public void __Gen_Wrap_114(object P0, float P1, float P2); // 0x0000000182D4D1A0-0x0000000182D4D4A0
		public string __Gen_Wrap_115(Beyond.Input.KeyboardKeyCode P0); // 0x0000000182D4D4A0-0x0000000182D4DD20
		public string __Gen_Wrap_116(System.Text.RegularExpressions.Match P0); // 0x0000000182D4DD20-0x0000000182D4E650
		public void __Gen_Wrap_117(object P0, object P1, object P2, bool P3); // 0x0000000181527A20-0x0000000181527E90
		public bool __Gen_Wrap_118(int P0, out Vector2 P1); // 0x0000000182D4E650-0x0000000182D4EF20
		public GameObject __Gen_Wrap_119(object P0, object P1); // 0x0000000182D4EF20-0x0000000182D4F940
		public string __Gen_Wrap_120(object P0, Beyond.Input.KeyboardKeyCode P1, bool P2); // 0x0000000182D4F940-0x0000000182D50300
		public string __Gen_Wrap_121(object P0, GamepadKeyCode P1, bool P2); // 0x0000000182D50300-0x0000000182D50CC0
		public string __Gen_Wrap_122(object P0, object P1, bool P2, bool P3, bool P4); // 0x0000000182D50CC0-0x0000000182D51750
		public void __Gen_Wrap_123(object P0, in EventData<string> P1); // 0x0000000182D51750-0x0000000182D51DD0
		public Beyond.Input.InputManager.DelayedComboBinding __Gen_Wrap_124(object P0, object P1, object P2, Beyond.Input.InputManager.DelayedComboKind P3, float P4, object P5); // 0x0000000182D51DD0-0x0000000182D529C0
		public int __Gen_Wrap_125(object P0, object P1); // 0x0000000181353F60-0x00000001813542F0
		public List<DynamicFastLookupCollection<Beyond.Input.KeyboardKeyCode, HashSet<KeyboardCheckerBase.Binding>>> __Gen_Wrap_126(object P0); // 0x0000000182D529C0-0x0000000182D532F0
		public void __Gen_Wrap_127(object P0, object P1, Beyond.Input.KeyboardKeyCode P2); // 0x0000000181412530-0x00000001814128D0
		public string __Gen_Wrap_128(ref CursorRequest P0); // 0x0000000182D532F0-0x0000000182D541E0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 58932
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000189E3F280-0x0000000189E3F314
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 58933
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000189E41724-0x0000000189E41788
		public static bool IsPatched(int id); // 0x0000000182FAA9F0-0x0000000182FAAA40
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000189E415E0-0x0000000189E416AC
		public object CreateWrapper(int id); // 0x0000000189E416AC-0x0000000189E41724
		public object InitWrapperArray(int len); // 0x0000000189E41788-0x0000000189EB3494
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000189E4153C-0x0000000189E415E0
	}

	public enum IDMAP0 // TypeDefIndex: 58934
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
		Beyond-Input-InputManager-get_usingController0 = 30,
		Beyond-Input-ControllerNaviManager-_RemoveLayer0 = 31,
		Beyond-Input-ControllerNaviManager-_RemoveLayerFromStack0 = 32,
		Beyond-Input-ControllerNaviManager-_SetTarget0 = 33,
		Beyond-Input-ControllerNaviManager-_OnLayerSelected0 = 34,
		Beyond-Input-InputBindingGroupMonoTarget-get_groupId0 = 35,
		Beyond-Input-InputBindingGroupMonoTarget-Init0 = 36,
		Beyond-Input-InputManager-CreateGroup0 = 39,
		Beyond-Input-InputBindingGroup-set_groupTarget0 = 40,
		Beyond-Input-InputBindingGroupMonoTarget-UpdateState0 = 41,
		Beyond-Input-ControllerNaviManager-_DefaultNavigate0 = 42,
		Beyond-Input-ControllerNaviManager-GetNaviVector0 = 43,
		Beyond-Input-ControllerNaviManager-_GetPointOnRectEdge0 = 44,
		Beyond-Input-ControllerNaviManager-_TryFindBestNaviTarget0 = 45,
		Beyond-Input-ControllerNaviManager-_TryFindBestNaviTargetInGroup0 = 46,
		Beyond-Input-ControllerNaviManager-SetTarget0 = 47,
		Beyond-Input-ControllerNaviManager-_GetDummyLayerLastGroupInStack0 = 48,
		Beyond-Input-ControllerNaviManager-SetForceEnableNavi0 = 49,
		Beyond-Input-ControllerNaviManager-TryRemoveLayer0 = 51,
		Beyond-Input-ControllerNaviManager-TryAutoSetTarget0 = 52,
		Beyond-Input-ControllerNaviManager-IsLayerInStack0 = 53,
		Beyond-Input-ControllerNaviManager-IsTopLayer0 = 54,
		Beyond-Input-ControllerNaviManager-ChangeAndTrySetNaviBindingType0 = 55,
		Beyond-Input-ControllerNaviManager-GetTopDummyLayerGroup0 = 56,
		Beyond-Input-ControllerNaviManager-ResetStateForUIDispose0 = 57,
		Beyond-Input-ControllerNaviManager-SetTargetInSilentModeIfNecessary0 = 58,
		Beyond-Input-ControllerNaviManager-ClearTargetIfNecessary0 = 59,
		Beyond-Input-ControllerNaviManager-SetTargetInSilentModeIfNecessary1 = 60,
		Beyond-Input-ControllerNaviManager-IsNaviTarget0 = 61,
		Beyond-Input-ControllerNaviManager-Navigate0 = 62,
		Beyond-Input-ControllerNaviManager-ToggleNavigation0 = 63,
		Beyond-Input-GamepadCheckerBase-get_normalBindingInfos0 = 64,
		Beyond-Input-GamepadCheckerBase-get_modifyBindingInfos0 = 65,
		Beyond-Input-GamepadCheckerBase-OnCreateBinding0 = 66,
		Beyond-Input-GamepadCheckerBase-GetInputDic0 = 67,
		Beyond-Input-GamepadCheckerBase-OnDeleteBinding0 = 68,
		Beyond-Input-GamepadCheckerBase-CheckGamepadInput0 = 69,
		Beyond-Input-GamepadCheckerBase-CheckDic0 = 70,
		Beyond-Input-GamepadCheckerBase-TriggerActions0 = 71,
		Beyond-Input-InputBindingInfo-Trigger0 = 72,
		Beyond-Input-InputBindingInfo-_RealTriggerCallback0 = 73,
		Beyond-Input-InputBindingInfo-StartContinuousTrigger0 = 74,
		Beyond-Input-InputBindingInfo-_TryContinuousTrigger0 = 76,
		Beyond-Input-InputBindingInfo-get_enabled0 = 77,
		Beyond-Input-InputManager-IsGuideUseAction0 = 79,
		Beyond-Input-GamepadChecker-CheckDic0 = 82,
		Beyond-Input-GamepadOnClickChecker-CheckDic0 = 86,
		Beyond-Input-InputBindingInfo-get_bindingView0 = 87,
		Beyond-Input-InputBindingGroup-get_groupView0 = 89,
		Beyond-Input-GamepadOnClickChecker-ClearKeyPressed0 = 91,
		Beyond-Input-GamepadOnLongPressChecker-CreateTriggerBindingAction0 = 92,
		Beyond-Input-GamepadOnLongPressChecker-_OnTriggerBinding0 = 95,
		Beyond-Input-InputBindingInfo-get_text0 = 98,
		Beyond-Input-InputManager-GetActionText1 = 99,
		Beyond-Input-InputManager-GetPlayerActionInfo0 = 100,
		Beyond-Input-InputManager-GetActionText0 = 101,
		Beyond-Input-GamepadOnLongPressChecker-CheckDic0 = 102,
		Beyond-Input-GamepadOnLongPressChecker-OnCreateBinding0 = 103,
		Beyond-Input-GamepadOnLongPressChecker-OnDeleteBinding0 = 104,
		Beyond-Input-GamepadOnLongPressChecker-GetInputLongPressStartTime0 = 105,
		Beyond-Input-GamepadOnReleaseChecker-CheckGamepadInput0 = 106,
		Beyond-Input-GamepadOnReleaseChecker-CheckDic0 = 108,
		Beyond-Input-HGVirtualMouse-get_cursorTransform0 = 109,
		Beyond-Input-HGVirtualMouse-set_cursorTransform0 = 110,
		Beyond-Input-HGVirtualMouse-get_scrollSpeed0 = 111,
		Beyond-Input-HGVirtualMouse-set_scrollSpeed0 = 112,
		Beyond-Input-HGVirtualMouse-get_virtualMouse0 = 113,
		Beyond-Input-HGVirtualMouse-get_stickAction0 = 114,
		Beyond-Input-HGVirtualMouse-set_stickAction0 = 115,
		Beyond-Input-HGVirtualMouse-_SetAction0 = 116,
		Beyond-Input-HGVirtualMouse-get_leftButtonAction0 = 117,
		Beyond-Input-HGVirtualMouse-set_leftButtonAction0 = 118,
		Beyond-Input-HGVirtualMouse-_SetActionCallback0 = 119,
		Beyond-Input-HGVirtualMouse-get_rightButtonAction0 = 120,
		Beyond-Input-HGVirtualMouse-set_rightButtonAction0 = 121,
		Beyond-Input-HGVirtualMouse-get_middleButtonAction0 = 122,
		Beyond-Input-HGVirtualMouse-set_middleButtonAction0 = 123,
		Beyond-Input-HGVirtualMouse-get_forwardButtonAction0 = 124,
		Beyond-Input-HGVirtualMouse-set_forwardButtonAction0 = 125,
		Beyond-Input-HGVirtualMouse-get_backButtonAction0 = 126,
		Beyond-Input-HGVirtualMouse-set_backButtonAction0 = 127,
		Beyond-Input-HGVirtualMouse-get_scrollWheelAction0 = 128,
		Beyond-Input-HGVirtualMouse-set_scrollWheelAction0 = 129,
		Beyond-Input-HGVirtualMouse-OnEnable0 = 130,
		Beyond-Input-HGVirtualMouse-SetMouseIconVisible0 = 131,
		Beyond-Input-HGVirtualMouse-_OnButtonActionTriggered0 = 134,
		Beyond-Input-HGVirtualMouse-TriggerLeftButton0 = 136,
		Beyond-Input-InputManager-CreateBindingByActionId0 = 137,
		Beyond-Input-InputManager-get_invalidID0 = 138,
		Beyond-Input-InputManager-_AddPlayerActionCheck2 = 139,
		Beyond-Input-InputManager-_AddPlayerActionCheck0 = 140,
		Beyond-Input-KeyboardCheckerBase-OnCreateBinding0 = 141,
		Beyond-Input-KeyboardCheckerBase-GetModifyIndex0 = 142,
		Beyond-Input-InputManager-_AddPlayerActionCheck1 = 143,
		Beyond-Input-HGVirtualMouse-ChangeHoverState0 = 145,
		Beyond-Input-HGVirtualMouse-_ChangeHoverState0 = 149,
		Beyond-Input-HGVirtualMouse-_SyncScale0 = 151,
		Beyond-Input-HGVirtualMouse-OnDisable0 = 152,
		Beyond-Input-HGVirtualMouse-_UpdateMotion0 = 153,
		Beyond-Input-HGVirtualMouse-ClearLeftButtonState0 = 154,
		Beyond-Input-HGVirtualMouse-OnAfterInputUpdate0 = 155,
		Beyond-Input-HGVirtualMouse-Update0 = 156,
		Beyond-Input-HGVirtualMouse-GetCurHoverSelectable0 = 158,
		Beyond-Input-HGVirtualMouse-OnDestroy0 = 159,
		Beyond-Input-InputManager-DeleteGroup0 = 160,
		Beyond-Input-InputManager-_DeleteGroup0 = 161,
		Beyond-Input-InputManager-_DeleteInGroup0 = 162,
		Beyond-Input-InputManager-_RealRemoveBindingInfo0 = 163,
		Beyond-Input-InputManager-_RemovePlayerActionCheck2 = 164,
		Beyond-Input-InputManager-_RemovePlayerActionCheck0 = 165,
		Beyond-Input-KeyboardCheckerBase-OnDeleteBinding0 = 166,
		Beyond-Input-InputManager-_RemovePlayerActionCheck1 = 167,
		Beyond-Input-InputBindingInfo-OnDelete0 = 168,
		Beyond-Input-HGVirtualMouse-Awake0 = 169,
		Beyond-Input-InputBindingInfo-set_bindingView0 = 170,
		Beyond-Input-InputBindingInfo-set_text0 = 171,
		Beyond-Input-InputBindingInfo-ChangeGroup0 = 172,
		Beyond-Input-InputBindingInfo-SetSelfEnabled0 = 174,
		Beyond-Input-InputBindingInfo-SetParentIgnored0 = 176,
		Beyond-Input-InputBindingInfo-GetCallbackTarget0 = 178,
		Beyond-Input-InputBindingGroup-set_groupView0 = 179,
		Beyond-Input-InputBindingGroup-get_groupTarget0 = 180,
		Beyond-Input-InputBindingGroup-ChangeParent0 = 181,
		Beyond-Input-InputBindingGroup-SetParentIgnored0 = 183,
		Beyond-Input-InputBindingGroupMonoTarget-get_groupEnabled0 = 185,
		Beyond-Input-InputBindingGroupMonoTarget-get_parentTarget0 = 186,
		Beyond-Input-InputBindingGroupMonoTarget-get_internalEnabled0 = 187,
		Beyond-Input-InputBindingGroupMonoTarget-set_internalEnabled0 = 188,
		Beyond-Input-InputBindingGroupMonoTarget-DeleteGroup0 = 189,
		Beyond-Input-InputBindingGroupMonoTarget-Awake0 = 190,
		Beyond-Input-InputBindingGroupMonoTarget-OnEnable0 = 191,
		Beyond-Input-InputBindingGroupMonoTarget-OnDisable0 = 192,
		Beyond-Input-InputBindingGroupMonoTarget-OnDestroy0 = 193,
		Beyond-Input-InputManager-get_isDebugForceShow0 = 194,
		Beyond-Input-RealCursorManager-get_isDebugForceShow0 = 195,
		Beyond-Input-InputManager-get_cursorVisible0 = 196,
		Beyond-Input-InputManager-get_anyKeyDown0 = 199,
		Beyond-Input-InputManager-AnyKeyDown0 = 200,
		Beyond-Input-InputManager-get_isInputSuppressedByDeviceSwitch0 = 201,
		Beyond-Input-InputManager-AnyGamepadKey0 = 202,
		Beyond-Input-InputManager-GetGamepadStickValue0 = 204,
		Beyond-Input-InputManager-GetGamepadTriggerValue0 = 206,
		Beyond-Input-InputManager-AnyMouseKeyDown0 = 207,
		Beyond-Input-InputManager-AnyTouchBegan0 = 208,
		Beyond-Input-InputManager-get_mouseScrollDelta0 = 209,
		Beyond-Input-InputManager-get_multiTouchEnabled0 = 210,
		Beyond-Input-InputManager-set_multiTouchEnabled0 = 211,
		Beyond-Input-InputManager-set_usingController0 = 212,
		Beyond-Input-InputManager-_TryChangeInputDeviceType0 = 213,
		Beyond-Input-InputManager-ChangeInputTypeAndSyncState0 = 214,
		Beyond-Input-InputManager-_SyncUsingControllerState0 = 215,
		Beyond-Input-InputManager-_CheckVirtualMouseState0 = 217,
		Beyond-Input-RealCursorManager-HasAnyShowRequestAtPriority0 = 218,
		Beyond-Input-InputManager-_ToggleVirtualMouse0 = 219,
		Beyond-Input-RealCursorManager-SetVirtualMouseActive0 = 222,
		Beyond-Input-RealCursorManager-CalcState0 = 223,
		Beyond-Input-RealCursorManager-_ToggleCursorInternal0 = 224,
		Beyond-Input-InputManager-_RefreshDeviceChangeBinding0 = 225,
		Beyond-Input-InputManager-ToggleBinding0 = 226,
		Beyond-Input-RealCursorManager-SetRequest0 = 227,
		Beyond-Input-RealCursorManager-_RefreshActiveHighest0 = 228,
		Beyond-Input-RealCursorManager-RemoveRequest0 = 229,
		Beyond-Input-InputManager-get_autoUpdateInputBindingMask0 = 230,
		Beyond-Input-InputManager-_UpdateInputBindingMask0 = 231,
		Beyond-Input-InputManager-_SetInputBindingMask0 = 232,
		Beyond-Input-InputManager-SetCursorShowRequest0 = 233,
		Beyond-Input-InputManager-get_virtualMouseIconVisible0 = 234,
		Beyond-Input-InputManager-get_keyboardType0 = 235,
		Beyond-Input-KeyboardHandler-GetKeyboardType0 = 236,
		Beyond-Input-InputManager-set_keyboardType0 = 237,
		Beyond-Input-KeyboardHandler-SetKeyboardType0 = 238,
		Beyond-Input-InputManager-get_action2BindingDic0 = 239,
		Beyond-Input-InputManager-get_rootGroupId0 = 240,
		Beyond-Input-InputManager-LateTick0 = 241,
		Beyond-Input-InputManager-_UpdateDelayedCombos0 = 242,
		Beyond-Input-InputManager-_UpdateModifierTapThenTriggerCombo0 = 243,
		Beyond-Input-InputManager-_UpdateTriggerThenModifierCombo0 = 244,
		Beyond-Input-InputManager-_Init0 = 247,
		Beyond-Input-InputManager-_CreateTickFunction0 = 248,
		Beyond-Input-KeyboardOnClickChecker-ClearKeyPressed0 = 250,
		Beyond-Input-InputManager-_LoadSetting0 = 252,
		Beyond-Input-KeyboardHandler-ParseConfig0 = 253,
		Beyond-Input-InputManager-_LoadCustomInputSetting0 = 254,
		Beyond-Input-InputManager-_OnControllerConnected0 = 255,
		Beyond-Input-InputManager-_IsValidJoystick0 = 256,
		Beyond-Input-InputManager-_SetJoystick0 = 257,
		Beyond-Input-InputManager-_GetControllerType0 = 262,
		Beyond-Input-InputManager-_OnControllerDisconnected0 = 263,
		Beyond-Input-InputManager-_TryFindGamepad0 = 264,
		Beyond-Input-InputManager-_CreateCanvas0 = 265,
		Beyond-Input-InputManager-_CreateDebugVirtualMouse0 = 270,
		Beyond-Input-InputManager-_CreateVirtualMouse0 = 273,
		Beyond-Input-InputManager-GetKeyIconPath0 = 280,
		Beyond-Input-InputManager-GetStringByGamepadKeyCode0 = 281,
		Beyond-Input-InputManager-GetGamepadKeyIconPath0 = 282,
		Beyond-Input-InputManager-_GetGamepadKeyIconFolderPath0 = 283,
		Beyond-Input-InputManager-_GetKeyIconPath0 = 284,
		Beyond-Input-InputManager-GetKeyIconPath2 = 285,
		Beyond-Input-InputManager-GetKeyIconPath1 = 286,
		Beyond-Input-InputManager-_InitDeviceChangeBinding0 = 287,
		Beyond-Input-InputManager-_OnAfterInputUpdate0 = 290,
		Beyond-Input-InputManager-KeyCaches-UpdateKeyStat0 = 291,
		Beyond-Input-InputManager-_CheckInput0 = 292,
		Beyond-Input-InputManager-CheckUsingController0 = 293,
		Beyond-Input-InputManager-_CheckAnyKeyForTouchChangeDevice0 = 294,
		Beyond-Input-InputManager-_CheckAnyKeyForKeyboardChangeDevice0 = 295,
		Beyond-Input-InputManager-AnyMouseKeyUp0 = 296,
		Beyond-Input-InputManager-_AnyKeyDownForKeyboardChangeDevice0 = 297,
		Beyond-Input-KeyboardCheckerBase-CheckKeyboardInput0 = 298,
		Beyond-Input-KeyboardCheckerBase-TriggerActions0 = 299,
		Beyond-Input-InputManager-_ControllerTouchPanelTick0 = 300,
		Beyond-Input-InputManager-_TryStopDeviceSwitchSuppression0 = 303,
		Beyond-Input-InputManager-_OnNetMaskChanged0 = 304,
		Beyond-Input-InputManager-_OnFocusedInputFieldChanged0 = 305,
		Beyond-Input-InputManager-Release0 = 306,
		Beyond-Input-InputManager-_ClearTickFunction0 = 307,
		Beyond-Input-InputManager-OnApplicationQuit0 = 308,
		Beyond-Input-InputManager-_ClearEvents0 = 309,
		Beyond-Input-InputManager-OnApplicationFocus0 = 310,
		Beyond-Input-InputManager-set_autoUpdateInputBindingMask0 = 311,
		Beyond-Input-InputManager-ToggleInputDeviceChangeMode0 = 312,
		Beyond-Input-InputManager-ClearAllCursorShowRequests0 = 314,
		Beyond-Input-RealCursorManager-RemoveAllRequestsAtPriority0 = 315,
		Beyond-Input-InputManager-SetCursorOverrideForDeviceChange0 = 316,
		Beyond-Input-InputManager-AnyKeyboardKey0 = 317,
		Beyond-Input-InputManager-_AnyKeyboardKey0 = 318,
		Beyond-Input-InputManager-AnyMouseKey0 = 319,
		Beyond-Input-InputManager-AnyTouchActive0 = 320,
		Beyond-Input-InputManager-_CheckGamepadKeyCode0 = 321,
		Beyond-Input-InputManager-CreateBinding1 = 322,
		Beyond-Input-InputManager-AddAnonymousPlayerAction0 = 323,
		Beyond-Input-InputManager-CreateBinding0 = 324,
		Beyond-Input-InputManager-CreateBinding2 = 325,
		Beyond-Input-InputManager-DeleteBinding0 = 326,
		Beyond-Input-InputManager-DeleteInGroup0 = 327,
		Beyond-Input-InputManager-IsBindingEnabled0 = 328,
		Beyond-Input-InputManager-IsGroupParentDisabled0 = 329,
		Beyond-Input-InputManager-ForceBindingKeyhintToGray0 = 330,
		Beyond-Input-InputManager-IsBindingKeyhintGray0 = 331,
		Beyond-Input-InputManager-ToggleDebugCursorMode0 = 332,
		Beyond-Input-InputManager-ToggleAllInput0 = 333,
		Beyond-Input-InputManager-SetBindingView0 = 334,
		Beyond-Input-InputManager-SetGroupView0 = 335,
		Beyond-Input-InputManager-ChangeParent0 = 336,
		Beyond-Input-InputManager-GetGroupParentId0 = 337,
		Beyond-Input-InputManager-IgnoreBindingGroupParent0 = 338,
		Beyond-Input-InputManager-IgnoreBindingParent0 = 339,
		Beyond-Input-InputManager-GetActionKeyboardKeyCode0 = 340,
		Beyond-Input-InputManager-GetActionGamepadKeyCode0 = 341,
		Beyond-Input-InputManager-DeleteCustomBinding0 = 342,
		Beyond-Input-PlayerActionInfo-DeviceInputEquals0 = 343,
		Beyond-Input-InputUtils-HasFlag0 = 344,
		Beyond-Input-PlayerActionInfo-DeviceInputCopyFrom0 = 345,
		Beyond-Input-InputManager-DeleteAllCustomBindings0 = 346,
		Beyond-Input-InputManager-SetBindingText0 = 347,
		Beyond-Input-InputManager-GetBindingText0 = 348,
		Beyond-Input-InputManager-HasBinding0 = 349,
		Beyond-Input-InputManager-CheckActionKeyCodeConflict0 = 350,
		Beyond-Input-InputManager-GetAxis0 = 351,
		Beyond-Input-InputManager-GetBindingInfo0 = 352,
		Beyond-Input-InputManager-LoadSetting0 = 353,
		Beyond-Input-InputManager-IsPlayerActionIdValid0 = 354,
		Beyond-Input-InputManager-ChangePlayerAction0 = 355,
		Beyond-Input-InputManager-_GetOrCreatePendingActionInfo0 = 356,
		Beyond-Input-InputManager-CustomizeActionKey0 = 357,
		Beyond-Input-InputManager-CustomizeActionKey1 = 358,
		Beyond-Input-InputManager-ClearPendingInputSetting0 = 359,
		Beyond-Input-InputManager-SaveCustomInputSetting0 = 360,
		Beyond-Input-InputManager-get_mousePosition0 = 361,
		Beyond-Input-InputManager-GetMousePos0 = 362,
		Beyond-Input-InputManager-SetOnlyVirtualMousePos0 = 364,
		Beyond-Input-InputManager-SetMousePos0 = 365,
		Beyond-Input-InputManager-SetVirtualMouseIconVisible0 = 366,
		Beyond-Input-InputManager-GetMouseButton0 = 367,
		Beyond-Input-InputManager-IsLeftMouseDown0 = 368,
		Beyond-Input-InputManager-GetMouseButtonDown0 = 369,
		Beyond-Input-InputManager-GetMouseButtonUp0 = 370,
		Beyond-Input-InputManager-SetCustomControllerMouse0 = 371,
		Beyond-Input-InputManager-GetEmptyControllerHintInfoList0 = 374,
		Beyond-Input-InputManager-GetControllerHintInfos0 = 375,
		Beyond-Input-InputManager-_GetControllerHintInfos0 = 376,
		Beyond-Input-InputManager-ControllerHintInfo-Reset0 = 378,
		Beyond-Input-InputManager-GetControllerHintInfos1 = 380,
		Beyond-Input-InputManager-_GetControllerHintInfos1 = 381,
		Beyond-Input-InputManager-ControllerHintInfo-Reset1 = 382,
		Beyond-Input-InputManager-GetPlayerActionLongPressStartTime0 = 383,
		Beyond-Input-KeyboardOnLongPressChecker-GetInputLongPressStartTime0 = 384,
		Beyond-Input-InputManager-GetActionBindingLongPressStartTime0 = 385,
		Beyond-Input-InputManager-AddGuideUseActionId0 = 386,
		Beyond-Input-InputManager-RemoveGuideUseActionId0 = 387,
		Beyond-Input-InputManager-ClearGuideUseActionIds0 = 388,
		Beyond-Input-InputManager-IsAnyBindingInGroupGuideUse0 = 389,
		Beyond-Input-InputManager-_IsAnyBindingInGroupGuideUse0 = 390,
		Beyond-Input-InputManager-VibrateController0 = 391,
		Beyond-Input-InputManager-GetStringByKeyboardKeyCode0 = 392,
		Beyond-Input-InputManager-GetKeyboardIconPath0 = 393,
		Beyond-Input-InputManager-ParseTextActionId0 = 394,
		Beyond-Input-InputManager-MoveMouseTo0 = 395,
		Beyond-Input-InputManager-MoveVirtualMouseTo0 = 396,
		Beyond-Input-InputManager-GetTouchId0 = 397,
		Beyond-Input-InputManager-GetPressPosByTouchId0 = 398,
		Beyond-Input-InputManager-Dispose0 = 399,
		Beyond-Input-InputManager-RemoveUnusedInput0 = 400,
		Beyond-Input-InputManager-GetCurJsInfos0 = 401,
		Beyond-Input-InputManager-GetRealCursorState0 = 402,
		Beyond-Input-RealCursorManager-DumpState0 = 403,
		Beyond-Input-InputManager-PrintKeycodeInfo2 = 404,
		Beyond-Input-InputManager-PrintKeycodeInfo0 = 405,
		Beyond-Input-InputManager-PrintBindingInfo0 = 406,
		Beyond-Input-InputManager-_GetBindingName0 = 407,
		Beyond-Input-InputManager-_GetInputBindingGroupGameObject0 = 408,
		Beyond-Input-InputManager-_GetInputBindingGameObject0 = 409,
		Beyond-Input-InputManager-PrintKeycodeInfo1 = 410,
		Beyond-Input-InputManager-PrintActionInfo0 = 411,
		Beyond-Input-InputManager-RegisterDelayedCombo0 = 412,
		Beyond-Input-InputManager-_RefreshDelayedComboKeys0 = 413,
		Beyond-Input-InputManager-_OnDelayedComboActionKeyUpdated0 = 414,
		Beyond-Input-InputManager-UnregisterDelayedCombo0 = 415,
		Beyond-Input-InputManager-ControllerHintInfo-CompareTo0 = 416,
		Beyond-Input-InputManager-ControllerHintInfo-OnAllocate0 = 417,
		Beyond-Input-InputManager-ControllerHintInfo-OnRecycle0 = 418,
		Beyond-Input-InputUtils-IgnoreBindingParent0 = 419,
		Beyond-Input-InputUtils-IgnoreBindingGroupParent0 = 420,
		Beyond-Input-KeyboardCheckerBase-get_bindingInfos0 = 421,
		Beyond-Input-KeyboardChecker-CheckKeyboardInput0 = 422,
		Beyond-Input-KeyboardChecker-TriggerActions0 = 424,
		Beyond-Input-KeyboardOnClickChecker-CheckKeyboardInput0 = 425,
		Beyond-Input-KeyboardOnClickChecker-TriggerActions0 = 426,
		Beyond-Input-KeyboardOnLongPressChecker-CheckKeyboardInput0 = 427,
		Beyond-Input-KeyboardOnLongPressChecker-_OnTriggerBinding0 = 430,
		Beyond-Input-KeyboardOnLongPressChecker-OnCreateBinding0 = 431,
		Beyond-Input-KeyboardOnLongPressChecker-OnDeleteBinding0 = 432,
		Beyond-Input-PlayerActionInfo-ResetHintProority0 = 433,
		Beyond-Input-KeyboardInput-GetModifyText0 = 434,
		Beyond-Input-KeyboardInput-GetKeyCodeText0 = 435,
		Beyond-Input-KeyboardInput-GetKeyCodeEnumIntValue0 = 436,
		Beyond-Input-KeyboardInput-SetKeyCodeEnumByIntValue0 = 437,
		Beyond-Input-KeyboardInput-get_modifyString0 = 438,
		Beyond-Input-KeyboardInput-ClearKeyCode0 = 439,
		Beyond-Input-KeyboardInput-IsValid0 = 440,
		Beyond-Input-KeyboardInput-CopyFrom0 = 441,
		Beyond-Input-KeyboardInput-Equals0 = 442,
		Beyond-Input-GamepadInput-GetModifyText0 = 443,
		Beyond-Input-GamepadInput-GetKeyCodeText0 = 444,
		Beyond-Input-GamepadInput-GetKeyCodeEnumIntValue0 = 445,
		Beyond-Input-GamepadInput-SetKeyCodeEnumByIntValue0 = 446,
		Beyond-Input-GamepadInput-ClearKeyCode0 = 447,
		Beyond-Input-GamepadInput-IsValid0 = 448,
		Beyond-Input-GamepadInput-CopyFrom0 = 449,
		Beyond-Input-GamepadInput-Equals0 = 450,
		Beyond-Input-CursorRequest-ToString0 = 451,
		Beyond-Input-UIEvent-get_bindingEnabled0 = 452,
		Beyond-Input-UIEvent-_CreatePlayerActionBinding0 = 454,
		Beyond-Input-UIEvent-InitBinding0 = 457,
		Beyond-Input-UIEvent-Invoke0 = 459,
		Beyond-Input-UIEvent-UpdateKeys0 = 460,
		Beyond-Input-UIEvent-ChangeBindingPlayerAction0 = 461,
		Beyond-Input-UIEvent-get_count0 = 462,
		Beyond-Input-UIEvent-AddListener0 = 463,
		Beyond-Input-UIEvent-RemoveListener0 = 464,
		Beyond-Input-UIEvent-RemoveAllListeners0 = 465
	}
}

namespace UnityEngine.InputSystem.UI
{
	[AddComponentMenu("Input/Debug Virtual Mouse")]
	public class DebugVirtualMouseInput : MonoBehaviour // TypeDefIndex: 58858
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
		public RectTransform cursorTransform { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public float cursorSpeed { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public CursorMode cursorMode { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x0000000189E3387C-0x0000000189E33960
		public Graphic cursorGraphic { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000189E33858-0x0000000189E3387C
		public float scrollSpeed { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public UnityEngine.InputSystem.Mouse virtualMouse { get; } // 0x0000000184D8D1A0-0x0000000184D8D1B0 
		public InputActionProperty stickAction { get; set; } // 0x0000000184D92750-0x0000000184D92770 0x0000000189E33C58-0x0000000189E33C88
		public InputActionProperty leftButtonAction { get; set; } // 0x0000000184D92770-0x0000000184D92790 0x0000000189E33A18-0x0000000189E33AC0
		public InputActionProperty rightButtonAction { get; set; } // 0x0000000184D9DCA0-0x0000000184D9DCC0 0x0000000189E33B70-0x0000000189E33C28
		public InputActionProperty middleButtonAction { get; set; } // 0x0000000184DA2F20-0x0000000184DA2F40 0x0000000189E33AC0-0x0000000189E33B70
		public InputActionProperty forwardButtonAction { get; set; } // 0x0000000184DA2F00-0x0000000184DA2F20 0x0000000189E33960-0x0000000189E33A18
		public InputActionProperty backButtonAction { get; set; } // 0x0000000184DA2EE0-0x0000000184DA2F00 0x0000000189E337A0-0x0000000189E33858
		public InputActionProperty scrollWheelAction { get; set; } // 0x0000000184DA2F40-0x0000000184DA2F60 0x0000000189E33C28-0x0000000189E33C58
	
		// Nested types
		public enum CursorMode // TypeDefIndex: 58857
		{
			SoftwareCursor = 0,
			HardwareCursorIfAvailable = 1
		}
	
		// Constructors
		public DebugVirtualMouseInput(); // 0x0000000184D77730-0x0000000184D77760
	
		// Methods
		protected void OnEnable(); // 0x0000000189E327D4-0x0000000189E32BFC
		protected void OnDisable(); // 0x0000000189E32538-0x0000000189E327D4
		private void _TryFindCanvas(); // 0x0000000189E33290-0x0000000189E332EC
		private void _TryEnableHardwareCursor(); // 0x0000000189E33098-0x0000000189E33290
		private void _SyncScale(); // 0x0000000189E32F98-0x0000000189E33098
		private void _UpdateMotion(); // 0x0000000189E332EC-0x0000000189E337A0
		private void _OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context); // 0x0000000189E32C04-0x0000000189E32E34
		private static void _SetActionCallback(InputActionProperty field, Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, bool install = true /* Metadata: 0x0234BF80 */); // 0x0000000189E32E34-0x0000000189E32EA0
		private static void _SetAction(ref InputActionProperty field, InputActionProperty value); // 0x0000000189E32EA0-0x0000000189E32F98
		private void _OnAfterInputUpdate(); // 0x0000000189E32BFC-0x0000000189E32C04
	}
}
