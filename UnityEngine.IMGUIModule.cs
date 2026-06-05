/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngineInternal;

// Image 52: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58027-58071

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 58071
{
	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor

	// Methods
	internal static uint ComputeStringHash(string s) => default; // 0x0000000187809354-0x00000001878093A8
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 58028
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 58029
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine
{
	public sealed class Event // TypeDefIndex: 58030
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private static Event s_Current; // 0x00
		private static Event s_MasterEvent; // 0x08
	
		// Properties
		public EventType rawType { get => default; } // 0x0000000184A15310-0x0000000184A15350 
		public Vector2 mousePosition { get => default; set {} } // 0x000000018BF12C98-0x000000018BF12CBC 0x000000018BF12FA4-0x000000018BF12FC0
		public Vector2 delta { get => default; set {} } // 0x000000018BF12B78-0x000000018BF12B9C 0x000000018BF12EC4-0x000000018BF12EE0
		public PointerType pointerType { get => default; } // 0x000000018BF12CBC-0x000000018BF12CF0 
		public int button { get => default; } // 0x000000018BF12A30-0x000000018BF12A64 
		public EventModifiers modifiers { get => default; set {} } // 0x0000000184A15950-0x0000000184A15990 0x000000018BF12F20-0x000000018BF12F60
		public float pressure { get => default; } // 0x000000018BF12CF0-0x000000018BF12D24 
		public int clickCount { get => default; } // 0x000000018BF12A64-0x000000018BF12A98 
		public char character { get => default; set {} } // 0x0000000184A159D0-0x0000000184A15A10 0x000000018BF12D70-0x000000018BF12DB4
		public KeyCode keyCode { get => default; set {} } // 0x0000000184A15990-0x0000000184A159D0 0x000000018BF12EE0-0x000000018BF12F20
		public int displayIndex { get => default; set {} } // 0x000000018BF12B9C-0x000000018BF12BD0 0x0000000184D704F0-0x0000000184D70540
		public EventType type { get => default; set {} } // 0x000000018BF12D3C-0x000000018BF12D70 0x000000018BF12FC0-0x000000018BF13000
		public string commandName { get => default; set {} } // 0x000000018BF12A98-0x000000018BF12ACC 0x000000018BF12DB4-0x000000018BF12DF8
		public bool shift { get => default; } // 0x000000018BF12D24-0x000000018BF12D3C 
		public bool control { get => default; } // 0x000000018BF12AE4-0x000000018BF12AFC 
		public bool alt { get => default; } // 0x000000018BF12A18-0x000000018BF12A30 
		public bool command { get => default; } // 0x000000018BF12ACC-0x000000018BF12AE4 
		public static Event current { get => default; set {} } // 0x000000018BF12AFC-0x000000018BF12B34 0x000000018BF12DF8-0x000000018BF12E80
		public bool isKey { get => default; } // 0x000000018BF12C08-0x000000018BF12C28 
		public bool isMouse { get => default; } // 0x000000018BF12C28-0x000000018BF12C54 
		internal bool isDirectManipulationDevice { get => default; } // 0x000000018BF12BD0-0x000000018BF12C08 
	
		// Constructors
		public Event() {} // 0x0000000184D71460-0x0000000184D71480
		public Event(int displayIndex) {} // 0x0000000184D70B30-0x0000000184D70B50
	
		// Methods
		private void Internal_Use() {} // 0x000000018BF11418-0x000000018BF1144C
		private static IntPtr Internal_Create(int displayIndex) => default; // 0x0000000184D71480-0x0000000184D714C0
		private static void Internal_Destroy(IntPtr ptr) {} // 0x0000000185A93030-0x0000000185A93070
		public EventType GetTypeForControl(int controlID) => default; // 0x000000018BF113D8-0x000000018BF11418
		internal void CopyFromPtr(IntPtr ptr) {} // 0x000000018BF11188-0x000000018BF111CC
		public static bool PopEvent(Event outEvent) => default; // 0x0000000184A152D0-0x0000000184A15310
		private static void Internal_SetNativeEvent(IntPtr ptr) {} // 0x0000000184D704B0-0x0000000184D704F0
		internal static void Internal_MakeMasterEventCurrent(int displayIndex) {} // 0x0000000184D70340-0x0000000184D704B0
		internal static int GetDoubleClickTime() => default; // 0x000000018BF1133C-0x000000018BF11368
		~Event() {} // 0x0000000185A92F90-0x0000000185A93030
		internal void CopyFrom(Event e) {} // 0x000000018BF111CC-0x000000018BF111F8
		public static Event KeyboardEvent(string key) => default; // 0x000000018BF1144C-0x000000018BF123F8
		public override int GetHashCode() => default; // 0x000000018BF11368-0x000000018BF113D8
		public override bool Equals(object obj) => default; // 0x000000018BF111F8-0x000000018BF1133C
		public override string ToString() => default; // 0x000000018BF123F8-0x000000018BF12904
		public void Use() {} // 0x000000018BF12904-0x000000018BF12A18
		private void get_mousePosition_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF12C54-0x000000018BF12C98
		private void set_mousePosition_Injected(ref Vector2 value) {} // 0x000000018BF12F60-0x000000018BF12FA4
		private void get_delta_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF12B34-0x000000018BF12B78
		private void set_delta_Injected(ref Vector2 value) {} // 0x000000018BF12E80-0x000000018BF12EC4
	}

	public enum EventType // TypeDefIndex: 58031
	{
		MouseDown = 0,
		mouseDown = 0,
		MouseUp = 1,
		mouseUp = 1,
		MouseMove = 2,
		mouseMove = 2,
		MouseDrag = 3,
		mouseDrag = 3,
		KeyDown = 4,
		keyDown = 4,
		KeyUp = 5,
		keyUp = 5,
		ScrollWheel = 6,
		scrollWheel = 6,
		Repaint = 7,
		repaint = 7,
		Layout = 8,
		layout = 8,
		DragUpdated = 9,
		dragUpdated = 9,
		DragPerform = 10,
		dragPerform = 10,
		Ignore = 11,
		ignore = 11,
		Used = 12,
		used = 12,
		ValidateCommand = 13,
		ExecuteCommand = 14,
		DragExited = 15,
		ContextClick = 16,
		MouseEnterWindow = 20,
		MouseLeaveWindow = 21,
		TouchDown = 30,
		TouchUp = 31,
		TouchMove = 32,
		TouchEnter = 33,
		TouchLeave = 34,
		TouchStationary = 35
	}

	public enum EventModifiers // TypeDefIndex: 58032
	{
		None = 0,
		Shift = 1,
		Control = 2,
		Alt = 4,
		Command = 8,
		Numeric = 16,
		CapsLock = 32,
		FunctionKey = 64
	}

	public enum PointerType // TypeDefIndex: 58033
	{
		Mouse = 0,
		Touch = 1,
		Pen = 2
	}

	internal struct EventInterests // TypeDefIndex: 58034
	{
		// Fields
		private bool _wantsMouseMove_k__BackingField; // 0x00
		private bool _wantsMouseEnterLeaveWindow_k__BackingField; // 0x01
		private bool _wantsLessLayoutEvents_k__BackingField; // 0x02
	
		// Properties
		public bool wantsMouseMove { get; set; } // 0x00000001835E3010-0x00000001835E3020 0x0000000185FB0F60-0x0000000185FB0F70
		public bool wantsMouseEnterLeaveWindow { get; set; } // 0x00000001838F1DD0-0x00000001838F1DE0 0x00000001838F1DE0-0x00000001838F1DF0
		public bool wantsLessLayoutEvents { get; } // 0x0000000185FB6C30-0x0000000185FB6C40 
	
		// Methods
		public bool WantsEvent(EventType type) => default; // 0x000000018BF110F8-0x000000018BF11114
		public bool WantsLayoutPass(EventType type) => default; // 0x000000018BF11114-0x000000018BF11188
	}

	public class GUI // TypeDefIndex: 58036
	{
		// Fields
		private static int s_ScrollControlId; // 0x00
		private static int s_HotTextField; // 0x04
		private static readonly int s_BoxHash; // 0x08
		private static readonly int s_ButonHash; // 0x0C
		private static readonly int s_RepeatButtonHash; // 0x10
		private static readonly int s_ToggleHash; // 0x14
		private static readonly int s_ButtonGridHash; // 0x18
		private static readonly int s_SliderHash; // 0x1C
		private static readonly int s_BeginGroupHash; // 0x20
		private static readonly int s_ScrollviewHash; // 0x24
		private static int _scrollTroughSide_k__BackingField; // 0x28
		private static System.DateTime _nextScrollStepTime_k__BackingField; // 0x30
		private static GUISkin s_Skin; // 0x38
		internal static Rect s_ToolTipRect; // 0x40
		private static GenericStack _scrollViewStates_k__BackingField; // 0x50
	
		// Properties
		public static Color color { get => default; set {} } // 0x000000018BF22D4C-0x000000018BF22D98 0x000000018BF23190-0x000000018BF231DC
		public static Color backgroundColor { get => default; set {} } // 0x000000018BF22ED0-0x000000018BF22F1C 0x000000018BF232C4-0x000000018BF23310
		public static Color contentColor { get => default; set {} } // 0x000000018BF22DF0-0x000000018BF22E1C 0x000000018BF231DC-0x000000018BF23210
		public static bool changed { get => default; set {} } // 0x000000018BF22F1C-0x000000018BF22F48 0x000000018BF23310-0x000000018BF23344
		public static bool enabled { get => default; set {} } // 0x000000018BF23130-0x000000018BF2315C 0x000000018BF22D98-0x000000018BF22DC4
		internal static bool usePageScrollbars { get => default; } // 0x000000018BF22DC4-0x000000018BF22DF0 
		internal static Material blendMaterial { get => default; } // 0x000000018BF22FE0-0x000000018BF2300C 
		internal static Material blitMaterial { get => default; } // 0x000000018BF2300C-0x000000018BF23038 
		internal static Material roundedRectMaterial { get => default; } // 0x000000018BF20D74-0x000000018BF20DA8 
		internal static Material roundedRectWithColorPerBorderMaterial { get => default; } // 0x000000018BF218E4-0x000000018BF21918 
		internal static int scrollTroughSide { get; set; } // 0x000000018BF22F90-0x000000018BF22FE0 0x000000018BF2337C-0x000000018BF233D4
		internal static System.DateTime nextScrollStepTime { get; set; } // 0x000000018BF23428-0x000000018BF23478 0x000000018BF230D8-0x000000018BF23130
		public static GUISkin skin { get => default; set {} } // 0x000000018BF22F48-0x000000018BF22F90 0x000000018BF1F454-0x000000018BF1F4F8
		public static Matrix4x4 matrix { get => default; set {} } // 0x000000018BF21CC0-0x000000018BF21D64 0x000000018BF21C2C-0x000000018BF21CC0
		internal static GenericStack scrollViewStates { get; } // 0x000000018BF1DB9C-0x000000018BF1E4C4 
	
		// Nested types
		public delegate void WindowFunction(int id); // TypeDefIndex: 58035; 0x000000018BF23244-0x000000018BF23290
	
		// Constructors
		public GUI() {} // Dummy constructor
		static GUI() {} // 0x000000018BF233D4-0x000000018BF23428
	
		// Methods
		public static void GrabMouseControl(int id) {} // 0x000000018BF21E70-0x000000018BF21E9C
		public static bool HasMouseControl(int id) => default; // 0x000000018BF21AE8-0x000000018BF21B14
		public static void ReleaseMouseControl() {} // 0x000000018BF21B74-0x000000018BF21C2C
		internal static void InternalRepaintEditorWindow() {} // 0x000000018BF1FADC-0x000000018BF1FB28
		private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) => default; // 0x000000018BF22AB8-0x000000018BF22D18
		public static void DragWindow(Rect position) {} // 0x000000018BF23038-0x000000018BF23088
		internal static void DoSetSkin(GUISkin newSkin) {} // 0x000000018BF23344-0x000000018BF2337C
		public static void Label(Rect position, string text) {} // 0x000000018BF21D64-0x000000018BF21DD8
		public static void Label(Rect position, string text, GUIStyle style) {} // 0x000000018BF204E8-0x000000018BF20548
		public static void Label(Rect position, GUIContent content, GUIStyle style) {} // 0x000000018BF20474-0x000000018BF204E8
		public static void DrawTexture(Rect position, Texture image) {} // 0x000000018BF1FB28-0x000000018BF1FBB4
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) {} // 0x000000018BF202AC-0x000000018BF2036C
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) {} // 0x000000018BF2036C-0x000000018BF20474
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) {} // 0x000000018BF1FBB4-0x000000018BF1FCB8
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) {} // 0x000000018BF201B8-0x000000018BF202AC
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) {} // 0x000000018BF200AC-0x000000018BF201B8
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) {} // 0x000000018BF1FCB8-0x000000018BF200AC
		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) {} // 0x000000018BF1E9B0-0x000000018BF1EB44
		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) {} // 0x000000018BF1E6B0-0x000000018BF1E754
		internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) => default; // 0x000000018BF1E5B8-0x000000018BF1E6B0
		public static void Box(Rect position, string text) {} // 0x000000018BF1E754-0x000000018BF1E7F8
		public static void Box(Rect position, GUIContent content, GUIStyle style) {} // 0x000000018BF1E7F8-0x000000018BF1E88C
		public static bool Button(Rect position, string text) => default; // 0x000000018BF1E88C-0x000000018BF1E928
		public static bool Button(Rect position, string text, GUIStyle style) => default; // 0x000000018BF1E928-0x000000018BF1E9B0
		public static bool Button(Rect position, GUIContent content, GUIStyle style) => default; // 0x000000018BF1F268-0x000000018BF1F454
		internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) => default; // 0x000000018BF225A0-0x000000018BF22678
		private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) => default; // 0x000000018BF21DD8-0x000000018BF21E70
		public static string TextField(Rect position, string text) => default; // 0x000000018BF1F4F8-0x000000018BF1F594
		internal static string PasswordFieldGetStrToShow(string password, char maskChar) => default; // 0x000000018BF1F830-0x000000018BF1F8E8
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) {} // 0x000000018BF1F594-0x000000018BF1F830
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) {} // 0x000000018BF21590-0x000000018BF218E4
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) {} // 0x000000018BF21028-0x000000018BF21590
		private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) {} // 0x000000018BF20DA8-0x000000018BF21028
		private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) {} // 0x000000018BF22678-0x000000018BF22730
		private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor) {} // 0x000000018BF22730-0x000000018BF227E8
		public static bool Toggle(Rect position, bool value, string text) => default; // 0x000000018BF1EDF4-0x000000018BF1F064
		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) => default; // 0x000000018BF1F064-0x000000018BF1F268
		internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) => default; // 0x000000018BF1F8E8-0x000000018BF1F9B4
		private static void DoLabel(Rect position, GUIContent content, GUIStyle style) {} // 0x000000018BF1ED30-0x000000018BF1EDF4
		internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) => default; // 0x000000018BF22450-0x000000018BF225A0
		internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) => default; // 0x000000018BF21918-0x000000018BF21AE8
		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) => default; // 0x000000018BF21E9C-0x000000018BF22050
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) => default; // 0x000000018BF227E8-0x000000018BF229B8
		internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) => default; // 0x000000018BF22050-0x000000018BF22450
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) => default; // 0x000000018BF1DB14-0x000000018BF1DB9C
		internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) => default; // 0x000000018BF1D984-0x000000018BF1DB14
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) {} // 0x000000018BF20548-0x000000018BF20560
		internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) {} // 0x000000018BF23088-0x000000018BF230D8
		public static void EndGroup() {} // 0x000000018BF1E4C4-0x000000018BF1E5B8
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect) => default; // 0x000000018BF20560-0x000000018BF205A4
		internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) => default; // 0x000000018BF205A4-0x000000018BF20D74
		public static void EndScrollView() {} // 0x000000018BF229B8-0x000000018BF22AB8
		public static void EndScrollView(bool handleScrollWheel) {} // 0x000000018BF1F9B4-0x000000018BF1FAA8
		public static Rect Window(int id, Rect clientRect, WindowFunction func, string text) => default; // 0x000000018BF1EB44-0x000000018BF1ED30
		private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) => default; // 0x000000018BF22E1C-0x000000018BF22E50
		internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) {} // 0x000000018BF23210-0x000000018BF23244
		private static void get_color_Injected(out Color ret) {
			ret = default;
		} // 0x000000018BF22D18-0x000000018BF22D4C
		private static void set_color_Injected(ref Color value) {} // 0x000000018BF2315C-0x000000018BF23190
		private static void get_backgroundColor_Injected(out Color ret) {
			ret = default;
		} // 0x000000018BF22E9C-0x000000018BF22ED0
		private static void set_backgroundColor_Injected(ref Color value) {} // 0x000000018BF23290-0x000000018BF232C4
		private static void get_contentColor_Injected(out Color ret) {
			ret = default;
		} // 0x000000018BF21B14-0x000000018BF21B74
		private static void set_contentColor_Injected(ref Color value) {} // 0x000000018BF1FAA8-0x000000018BF1FADC
		private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) {
			ret = default;
		} // 0x000000018789F4A4-0x000000018789F56C
		private static void DragWindow_Injected(ref Rect position) {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	internal sealed class GUIClip // TypeDefIndex: 58038
	{
		// Properties
		internal static Rect visibleRect { get => default; } // 0x000000018BF131E0-0x000000018BF1320C 
	
		// Nested types
		internal struct ParentClipScope : IDisposable // TypeDefIndex: 58037
		{
			// Fields
			private bool m_Disposed; // 0x00
	
			// Constructors
			public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect) {
				m_Disposed = default;
			} // 0x000000018BF1351C-0x000000018BF1353C
	
			// Methods
			public void Dispose() {} // 0x000000018BF1334C-0x000000018BF13378
		}
	
		// Constructors
		public GUIClip() {} // Dummy constructor
	
		// Methods
		internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) {} // 0x000000018BF13188-0x000000018BF131B4
		internal static void Internal_Pop() {} // 0x000000018BF134AC-0x000000018BF134D8
		internal static int Internal_GetCount() => default; // 0x000000018BF1342C-0x000000018BF13458
		private static Vector2 Unclip_Vector2(Vector2 pos) => default; // 0x000000018BF130EC-0x000000018BF13118
		private static Vector2 UnclipToWindow_Vector2(Vector2 pos) => default; // 0x000000018BF1315C-0x000000018BF13188
		private static Vector2 ClipToWindow_Vector2(Vector2 absolutePos) => default; // 0x000000018BF133D8-0x000000018BF133E8
		internal static Matrix4x4 GetMatrix() => default; // 0x000000018BF13260-0x000000018BF132D4
		internal static void SetMatrix(Matrix4x4 m) {} // 0x000000018BF132D4-0x000000018BF132E8
		internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) {} // 0x000000018BF131B4-0x000000018BF131E0
		internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) {} // 0x000000018BF13380-0x000000018BF133A4
		internal static void Internal_PopParentClip() {} // 0x000000018BF13378-0x000000018BF13380
		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) {} // 0x000000018BF134D8-0x000000018BF134E8
		internal static void Pop() {} // 0x000000018BF13458-0x000000018BF13468
		public static Vector2 Unclip(Vector2 pos) => default; // 0x000000018BF13118-0x000000018BF13128
		public static Vector2 UnclipToWindow(Vector2 pos) => default; // 0x000000018BF134E8-0x000000018BF1351C
		public static Vector2 ClipToWindow(Vector2 absolutePos) => default; // 0x000000018BF132E8-0x000000018BF1334C
		private static void get_visibleRect_Injected(out Rect ret) {
			ret = default;
		} // 0x000000018BF13468-0x000000018BF134AC
		private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) {} // 0x000000018BF133E8-0x000000018BF1342C
		private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF130A8-0x000000018BF130EC
		private static void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF13128-0x000000018BF1315C
		private static void ClipToWindow_Vector2_Injected(ref Vector2 absolutePos, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF133A4-0x000000018BF133D8
		private static void GetMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BF1320C-0x000000018BF13260
		private static void SetMatrix_Injected(ref Matrix4x4 m) {} // 0x000000018BF23814-0x000000018BF23900
		private static void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect) {} // 0x000000018BF23804-0x000000018BF23814
	}

	[Serializable]
	public class GUIContent // TypeDefIndex: 58039
	{
		// Fields
		private string m_Text; // 0x10
		private Texture m_Image; // 0x18
		private string m_Tooltip; // 0x20
		private static readonly GUIContent s_Text; // 0x00
		private static readonly GUIContent s_Image; // 0x08
		private static readonly GUIContent s_TextImage; // 0x10
		public static GUIContent none; // 0x18
	
		// Properties
		public string text { get => default; set {} } // 0x0000000185FC7990-0x0000000185FC79A0 0x0000000184096E30-0x0000000184096EF0
		public Texture image { set {} } // 0x0000000184088E70-0x0000000184088E80
		public string tooltip { get => default; set {} } // 0x0000000185FE66B0-0x0000000185FE66C0 0x000000018646EE40-0x000000018646EE50
		internal int hash { get => default; } // 0x000000018BF13B0C-0x000000018BF13B30 
	
		// Constructors
		public GUIContent() {} // 0x000000018BF13A48-0x000000018BF13AB0
		public GUIContent(string text) {} // 0x000000018BF13AB0-0x000000018BF13B0C
		public GUIContent(string text, string tooltip) {} // 0x000000018BF1397C-0x000000018BF1399C
		public GUIContent(string text, Texture image, string tooltip) {} // 0x000000018BF138C4-0x000000018BF1397C
		public GUIContent(GUIContent src) {} // 0x000000018BF1399C-0x000000018BF13A48
		static GUIContent() {} // 0x000000018BF13760-0x000000018BF138C4
	
		// Methods
		internal static GUIContent Temp(string t) => default; // 0x000000018BF13688-0x000000018BF1373C
		internal static void ClearStaticCache() {} // 0x000000018BF1353C-0x000000018BF13688
		public override string ToString() => default; // 0x000000018BF1373C-0x000000018BF13760
	}

	public enum ScaleMode // TypeDefIndex: 58040
	{
		StretchToFill = 0,
		ScaleAndCrop = 1,
		ScaleToFit = 2
	}

	public enum FocusType // TypeDefIndex: 58041
	{
		Native = 0,
		Keyboard = 1,
		Passive = 2
	}

	public class GUILayout // TypeDefIndex: 58042
	{
		// Constructors
		public GUILayout() {} // Dummy constructor
	
		// Methods
		public static void Label(string text, GUILayoutOption[] options) {} // 0x000000018BF177A8-0x000000018BF17834
		public static void Label(string text, GUIStyle style, GUILayoutOption[] options) {} // 0x000000018BF17834-0x000000018BF178A0
		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) {} // 0x000000018BF170B8-0x000000018BF17160
		public static bool Toggle(bool value, string text, GUIStyle style, GUILayoutOption[] options) => default; // 0x000000018BF17A78-0x000000018BF17AF8
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) => default; // 0x000000018BF17AF8-0x000000018BF17B08
		private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) => default; // 0x000000018BF17160-0x000000018BF1721C
		public static void Space(float pixels) {} // 0x000000018BF178A0-0x000000018BF17A78
		public static void FlexibleSpace() {} // 0x000000018BF17520-0x000000018BF1771C
		public static void BeginHorizontal(GUILayoutOption[] options) {} // 0x000000018BF169E0-0x000000018BF16A64
		public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) {} // 0x000000018BF16A64-0x000000018BF16BA8
		public static void EndHorizontal() {} // 0x000000018BF17334-0x000000018BF17374
		public static void BeginVertical(GUILayoutOption[] options) {} // 0x000000018BF16FD0-0x000000018BF17054
		public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) {} // 0x000000018BF17054-0x000000018BF170B8
		public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) {} // 0x000000018BF16E8C-0x000000018BF16FD0
		public static void EndVertical() {} // 0x000000018BF173E0-0x000000018BF17420
		public static void BeginArea(Rect screenRect) {} // 0x000000018BF167D4-0x000000018BF16864
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) {} // 0x000000018BF16864-0x000000018BF169E0
		public static void EndArea() {} // 0x000000018BF1721C-0x000000018BF17334
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) => default; // 0x000000018BF16BA8-0x000000018BF16C68
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) => default; // 0x000000018BF16C68-0x000000018BF16E8C
		public static void EndScrollView() {} // 0x000000018BF17374-0x000000018BF17380
		internal static void EndScrollView(bool handleScrollWheel) {} // 0x000000018BF17380-0x000000018BF173E0
		public static GUILayoutOption Width(float width) => default; // 0x000000018BF17B08-0x000000018BF17B94
		public static GUILayoutOption Height(float height) => default; // 0x000000018BF1771C-0x000000018BF177A8
		public static GUILayoutOption ExpandWidth(bool expand) => default; // 0x000000018BF174A0-0x000000018BF17520
		public static GUILayoutOption ExpandHeight(bool expand) => default; // 0x000000018BF17420-0x000000018BF174A0
	}

	public sealed class GUILayoutOption // TypeDefIndex: 58044
	{
		// Fields
		internal Type type; // 0x10
		internal object value; // 0x18
	
		// Nested types
		internal enum Type // TypeDefIndex: 58043
		{
			fixedWidth = 0,
			fixedHeight = 1,
			minWidth = 2,
			maxWidth = 3,
			minHeight = 4,
			maxHeight = 5,
			stretchWidth = 6,
			stretchHeight = 7,
			alignStart = 8,
			alignMiddle = 9,
			alignEnd = 10,
			alignJustify = 11,
			equalSize = 12,
			spacing = 13
		}
	
		// Constructors
		public GUILayoutOption() {} // Dummy constructor
		internal GUILayoutOption(Type type, object value) {} // 0x000000018646E950-0x000000018646E960
	}

	public class GUILayoutUtility // TypeDefIndex: 58046
	{
		// Fields
		private static readonly Dictionary<int, LayoutCache> s_StoredLayouts; // 0x00
		private static readonly Dictionary<int, LayoutCache> s_StoredWindows; // 0x08
		internal static LayoutCache current; // 0x10
		internal static readonly Rect kDummyRect; // 0x18
		private static int _unbalancedgroupscount_k__BackingField; // 0x28
		private static GUIStyle s_SpaceStyle; // 0x30
	
		// Properties
		internal static int unbalancedgroupscount { get; set; } // 0x000000018BF14E44-0x000000018BF15080 0x000000018BF14518-0x000000018BF146A0
		internal static GUIStyle spaceStyle { get => default; } // 0x000000018BF15A30-0x000000018BF15A70 
	
		// Nested types
		internal sealed class LayoutCache // TypeDefIndex: 58045
		{
			// Fields
			private int _id_k__BackingField; // 0x10
			internal GUILayoutGroup topLevel; // 0x18
			internal GenericStack layoutGroups; // 0x20
			internal GUILayoutGroup windows; // 0x28
	
			// Properties
			private int id { get; set; } // 0x000000018BF159D8-0x000000018BF15A30
	
			// Constructors
			public LayoutCache() {} // Dummy constructor
			internal LayoutCache(int instanceID = -1 /* Metadata: 0x0207F40D */) {} // 0x000000018BF15A70-0x000000018BF15AC8
	
			// Methods
			public void ResetCursor() {} // 0x000000018BF16730-0x000000018BF16780
		}
	
		// Constructors
		public GUILayoutUtility() {} // Dummy constructor
		static GUILayoutUtility() {} // 0x0000000181378230-0x0000000181378240
	
		// Methods
		private static Rect Internal_GetWindowRect(int windowID) => default; // 0x000000018BF16780-0x000000018BF167D4
		private static void Internal_MoveWindow(int windowID, Rect r) {} // 0x000000018BF16348-0x000000018BF164EC
		internal static LayoutCache SelectIDList(int instanceID, bool isWindow) => default; // 0x000000018BF14B44-0x000000018BF14E44
		internal static void Begin(int instanceID) {} // 0x000000018BF1612C-0x000000018BF16348
		internal static void BeginContainer(LayoutCache cache) {} // 0x000000018BF15DD4-0x000000018BF15F98
		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) {} // 0x000000018BF15C3C-0x000000018BF15DD4
		internal static void Layout() {} // 0x000000018BF15AC8-0x000000018BF15C3C
		internal static void LayoutFromEditorWindow() {} // 0x000000018BF15F98-0x000000018BF1612C
		internal static void LayoutFromContainer(float w, float h) {} // 0x000000018BF15080-0x000000018BF15184
		internal static void LayoutFreeGroup(GUILayoutGroup toplevel) {} // 0x000000018BF148D0-0x000000018BF14B44
		private static void LayoutSingleGroup(GUILayoutGroup i) {} // 0x000000018BF155EC-0x000000018BF157B8
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType) => default; // 0x000000018BF146A0-0x000000018BF148D0
		internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, System.Type layoutType) => default; // 0x000000018BF15910-0x000000018BF15998
		internal static void EndLayoutGroup() {} // 0x000000018BF15320-0x000000018BF155EC
		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, System.Type layoutType) => default; // 0x000000018BF1586C-0x000000018BF15910
		public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) => default; // 0x000000018BF15184-0x000000018BF15320
		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) => default; // 0x000000018BF157B8-0x000000018BF1586C
		public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) => default; // 0x000000018BF16640-0x000000018BF16730
		private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) => default; // 0x000000018BF164EC-0x000000018BF16640
		public static Rect GetLastRect() => default; // 0x000000018BF15998-0x000000018BF159D8
		private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) {
			ret = default;
		} // 0x000000018BF23714-0x000000018BF23804
		private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) {} // 0x000000018BF23478-0x000000018BF23714
	}

	[Serializable]
	public sealed class GUISettings // TypeDefIndex: 58047
	{
		// Fields
		private bool m_DoubleClickSelectsWord; // 0x10
		private bool m_TripleClickSelectsLine; // 0x11
		private Color m_CursorColor; // 0x14
		private float m_CursorFlashSpeed; // 0x24
		private Color m_SelectionColor; // 0x28
	
		// Properties
		public bool doubleClickSelectsWord { get => default; } // 0x0000000185FE8B10-0x0000000185FE8B20 
		public bool tripleClickSelectsLine { get => default; } // 0x0000000185FE8B30-0x0000000185FE8B40 
		public Color cursorColor { get => default; } // 0x0000000185FC2290-0x0000000185FC22A0 
		public float cursorFlashSpeed { get => default; } // 0x000000018BF17BF8-0x000000018BF17C18 
		public Color selectionColor { get => default; } // 0x0000000185FE8B20-0x0000000185FE8B30 
	
		// Constructors
		public GUISettings() {} // 0x000000018BF17BC0-0x000000018BF17BF8
	
		// Methods
		private static float Internal_GetCursorFlashSpeed() => default; // 0x000000018BF17B94-0x000000018BF17BC0
	}

	[Serializable]
	public sealed class GUISkin : ScriptableObject // TypeDefIndex: 58049
	{
		// Fields
		private Font m_Font; // 0x18
		private GUIStyle m_box; // 0x20
		private GUIStyle m_button; // 0x28
		private GUIStyle m_toggle; // 0x30
		private GUIStyle m_label; // 0x38
		private GUIStyle m_textField; // 0x40
		private GUIStyle m_textArea; // 0x48
		private GUIStyle m_window; // 0x50
		private GUIStyle m_horizontalSlider; // 0x58
		private GUIStyle m_horizontalSliderThumb; // 0x60
		[NonSerialized]
		private GUIStyle m_horizontalSliderThumbExtent; // 0x68
		private GUIStyle m_verticalSlider; // 0x70
		private GUIStyle m_verticalSliderThumb; // 0x78
		[NonSerialized]
		private GUIStyle m_verticalSliderThumbExtent; // 0x80
		[NonSerialized]
		private GUIStyle m_SliderMixed; // 0x88
		private GUIStyle m_horizontalScrollbar; // 0x90
		private GUIStyle m_horizontalScrollbarThumb; // 0x98
		private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
		private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
		private GUIStyle m_verticalScrollbar; // 0xB0
		private GUIStyle m_verticalScrollbarThumb; // 0xB8
		private GUIStyle m_verticalScrollbarUpButton; // 0xC0
		private GUIStyle m_verticalScrollbarDownButton; // 0xC8
		private GUIStyle m_ScrollView; // 0xD0
		internal GUIStyle[] m_CustomStyles; // 0xD8
		private GUISettings m_Settings; // 0xE0
		internal static GUIStyle ms_Error; // 0x00
		private Dictionary<string, GUIStyle> m_Styles; // 0xE8
		internal static SkinChangedDelegate m_SkinChanged; // 0x08
		internal static GUISkin current; // 0x10
	
		// Properties
		public Font font { get => default; set {} } // 0x0000000185FE66B0-0x0000000185FE66C0 0x000000018BF190E4-0x000000018BF19108
		public GUIStyle box { get => default; set {} } // 0x0000000185FE7CE0-0x0000000185FE7CF0 0x000000018BF19310-0x000000018BF19334
		public GUIStyle label { get => default; set {} } // 0x0000000185FE8B00-0x0000000185FE8B10 0x000000018BF193A8-0x000000018BF193CC
		public GUIStyle textField { get => default; set {} } // 0x0000000185FE8BF0-0x0000000185FE8C00 0x000000018BF19384-0x000000018BF193A8
		public GUIStyle textArea { get => default; set {} } // 0x0000000185FE7B00-0x0000000185FE7B10 0x000000018BF19108-0x000000018BF1912C
		public GUIStyle button { get => default; set {} } // 0x0000000185FE7B40-0x0000000185FE7B50 0x000000018BF193CC-0x000000018BF193F0
		public GUIStyle toggle { get => default; set {} } // 0x0000000185FE8C70-0x0000000185FE8C80 0x000000018BF19500-0x000000018BF19524
		public GUIStyle window { get => default; set {} } // 0x0000000185FE8BB0-0x0000000185FE8BC0 0x000000018BF192EC-0x000000018BF19310
		public GUIStyle horizontalSlider { get => default; set {} } // 0x0000000185FE8BA0-0x0000000185FE8BB0 0x000000018BF192C8-0x000000018BF192EC
		public GUIStyle horizontalSliderThumb { get => default; set {} } // 0x0000000185FE8B90-0x0000000185FE8BA0 0x000000018BF192A4-0x000000018BF192C8
		internal GUIStyle horizontalSliderThumbExtent { get => default; set {} } // 0x0000000185FE8BE0-0x0000000185FE8BF0 0x000000018BF1935C-0x000000018BF19384
		internal GUIStyle sliderMixed { get => default; set {} } // 0x0000000185FE8C60-0x0000000185FE8C70 0x000000018BF194DC-0x000000018BF19500
		public GUIStyle verticalSlider { get => default; set {} } // 0x0000000185FE8C50-0x0000000185FE8C60 0x000000018BF194B8-0x000000018BF194DC
		public GUIStyle verticalSliderThumb { get => default; set {} } // 0x0000000185FE8C40-0x0000000185FE8C50 0x000000018BF19490-0x000000018BF194B8
		internal GUIStyle verticalSliderThumbExtent { get => default; set {} } // 0x0000000185FE8B80-0x0000000185FE8B90 0x000000018BF1927C-0x000000018BF192A4
		public GUIStyle horizontalScrollbar { get => default; set {} } // 0x0000000185FE8B70-0x0000000185FE8B80 0x000000018BF19254-0x000000018BF1927C
		public GUIStyle horizontalScrollbarThumb { get => default; set {} } // 0x0000000185FE8B50-0x0000000185FE8B60 0x000000018BF19204-0x000000018BF1922C
		public GUIStyle horizontalScrollbarLeftButton { get => default; set {} } // 0x0000000185FE8B60-0x0000000185FE8B70 0x000000018BF1922C-0x000000018BF19254
		public GUIStyle horizontalScrollbarRightButton { get => default; set {} } // 0x0000000185FE8C30-0x0000000185FE8C40 0x000000018BF19468-0x000000018BF19490
		public GUIStyle verticalScrollbar { get => default; set {} } // 0x0000000185FE8C10-0x0000000185FE8C20 0x000000018BF19418-0x000000018BF19440
		public GUIStyle verticalScrollbarThumb { get => default; set {} } // 0x0000000185FE8C20-0x0000000185FE8C30 0x000000018BF19440-0x000000018BF19468
		public GUIStyle verticalScrollbarUpButton { get => default; set {} } // 0x0000000185FE8C00-0x0000000185FE8C10 0x000000018BF193F0-0x000000018BF19418
		public GUIStyle verticalScrollbarDownButton { get => default; set {} } // 0x0000000185FE8BC0-0x0000000185FE8BD0 0x000000018BF19334-0x000000018BF1935C
		public GUIStyle scrollView { get => default; set {} } // 0x0000000185FE8B40-0x0000000185FE8B50 0x000000018BF1912C-0x000000018BF19154
		public GUIStyle[] customStyles { get => default; set {} } // 0x0000000185FE8BD0-0x0000000185FE8BE0 0x000000018BF19010-0x000000018BF190E4
		public GUISettings settings { get => default; } // 0x000000018BF17C18-0x000000018BF17C7C 
		internal static GUIStyle error { get => default; } // 0x000000018BF17C7C-0x000000018BF18B54 
	
		// Nested types
		internal delegate void SkinChangedDelegate(); // TypeDefIndex: 58048; 0x000000018BF18F50-0x000000018BF18F58
	
		// Constructors
		public GUISkin() {} // 0x000000018BF18B54-0x000000018BF18BC8
	
		// Methods
		internal void OnEnable() {} // 0x0000000185FC2A70-0x0000000185FC2A80
		internal static void CleanupRoots() {} // 0x000000018BF19154-0x000000018BF19204
		internal void Apply() {} // 0x000000018BF18D04-0x000000018BF18EB0
		private void BuildStyleCache() {} // 0x000000018BF18BC8-0x000000018BF18C4C
		public GUIStyle GetStyle(string styleName) => default; // 0x000000018BF18EB0-0x000000018BF18F50
		public GUIStyle FindStyle(string styleName) => default; // 0x000000018BF18C4C-0x000000018BF18D04
		internal void MakeCurrent() {} // 0x00000001864BC330-0x00000001864BC3F4
		public IEnumerator GetEnumerator() => default; // 0x00000001864BC320-0x00000001864BC330
	}

	internal class GUIStateObjects // TypeDefIndex: 58050
	{
		// Fields
		private static Dictionary<int, object> s_StateCache; // 0x00
	
		// Constructors
		public GUIStateObjects() {} // Dummy constructor
		static GUIStateObjects() {} // 0x000000018BF196B4-0x000000018BF19740
	
		// Methods
		internal static object GetStateObject(System.Type t, int controlID) => default; // 0x000000018BF19524-0x000000018BF1961C
		internal static object QueryStateObject(System.Type t, int controlID) => default; // 0x000000018BF1961C-0x000000018BF196B4
	}

	[Serializable]
	public sealed class GUIStyleState // TypeDefIndex: 58051
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private readonly GUIStyle m_SourceStyle; // 0x18
	
		// Properties
		public Texture2D background { get => default; set {} } // 0x000000018BF198B0-0x000000018BF198E4 0x000000018BF19954-0x000000018BF19998
		public Color textColor { get => default; set {} } // 0x000000018BF19928-0x000000018BF19954 0x000000018BF199DC-0x000000018BF199F0
	
		// Constructors
		public GUIStyleState() {} // 0x000000018BF19894-0x000000018BF198B0
		private GUIStyleState(GUIStyle sourceStyle, IntPtr source) {} // 0x000000018BEC6FDC-0x000000018BEC6FFC
	
		// Methods
		private static IntPtr Init() => default; // 0x000000018BF19868-0x000000018BF19894
		private void Cleanup() {} // 0x000000018BF19740-0x000000018BF19774
		internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) => default; // 0x000000018BF197F8-0x000000018BF19868
		~GUIStyleState() {} // 0x000000018BF19774-0x000000018BF197F8
		private void get_textColor_Injected(out Color ret) {
			ret = default;
		} // 0x000000018BF198E4-0x000000018BF19928
		private void set_textColor_Injected(ref Color value) {} // 0x000000018BF19998-0x000000018BF199DC
	}

	[Serializable]
	public sealed class GUIStyle // TypeDefIndex: 58052
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		[NonSerialized]
		private GUIStyleState m_Normal; // 0x18
		[NonSerialized]
		private GUIStyleState m_Hover; // 0x20
		[NonSerialized]
		private GUIStyleState m_Active; // 0x28
		[NonSerialized]
		private GUIStyleState m_Focused; // 0x30
		[NonSerialized]
		private GUIStyleState m_OnNormal; // 0x38
		[NonSerialized]
		private GUIStyleState m_OnHover; // 0x40
		[NonSerialized]
		private GUIStyleState m_OnActive; // 0x48
		[NonSerialized]
		private GUIStyleState m_OnFocused; // 0x50
		[NonSerialized]
		private RectOffset m_Border; // 0x58
		[NonSerialized]
		private RectOffset m_Padding; // 0x60
		[NonSerialized]
		private RectOffset m_Margin; // 0x68
		[NonSerialized]
		private RectOffset m_Overflow; // 0x70
		[NonSerialized]
		private string m_Name; // 0x78
		internal static bool showKeyboardFocus; // 0x00
		private static GUIStyle s_None; // 0x08
	
		// Properties
		internal string rawName { get => default; set {} } // 0x000000018BF1B60C-0x000000018BF1B640 0x000000018BF1BBB8-0x000000018BF1BBFC
		public Font font { get => default; set {} } // 0x000000018BF1B0C4-0x000000018BF1B0F8 0x000000018BF1B9C4-0x000000018BF1BA08
		public ImagePosition imagePosition { get => default; set {} } // 0x000000018BF1B140-0x000000018BF1B174 0x000000018BF1BA2C-0x000000018BF1BA6C
		public TextAnchor alignment { get => default; set {} } // 0x000000018BF1AE48-0x000000018BF1AE7C 0x000000018BF1B794-0x000000018BF1B7D4
		public bool wordWrap { get => default; set {} } // 0x000000018BF1B6DC-0x000000018BF1B710 0x000000018BF1BCC8-0x000000018BF1BD0C
		public TextClipping clipping { get => default; set {} } // 0x000000018BF1AF10-0x000000018BF1AF44 0x000000018BF1B7F8-0x000000018BF1B838
		public Vector2 contentOffset { get => default; set {} } // 0x000000018BF1AF88-0x000000018BF1AFAC 0x000000018BF1B87C-0x000000018BF1B898
		public float fixedWidth { get => default; set {} } // 0x000000018BF1AFE0-0x000000018BF1B014 0x000000018BF1B8DC-0x000000018BF1B920
		public float fixedHeight { get => default; set {} } // 0x000000018BF1AFAC-0x000000018BF1AFE0 0x000000018BF1B898-0x000000018BF1B8DC
		public bool stretchWidth { get => default; set {} } // 0x000000018BF1B6A8-0x000000018BF1B6DC 0x000000018BF1BC84-0x000000018BF1BCC8
		public bool stretchHeight { get => default; set {} } // 0x000000018BF1B674-0x000000018BF1B6A8 0x000000018BF1BC40-0x000000018BF1BC84
		public int fontSize { get => default; set {} } // 0x000000018BF1B05C-0x000000018BF1B090 0x000000018BF1B944-0x000000018BF1B984
		public FontStyle fontStyle { get => default; set {} } // 0x000000018BF1B090-0x000000018BF1B0C4 0x000000018BF1B984-0x000000018BF1B9C4
		public bool richText { get => default; set {} } // 0x000000018BF1B640-0x000000018BF1B674 0x000000018BF1BBFC-0x000000018BF1BC40
		internal Vector2 Internal_clipOffset { set {} } // 0x000000018BF1B754-0x000000018BF1B770
		public string name { get => default; set {} } // 0x000000018BF1B2AC-0x000000018BF1B2E0 0x000000018BF1BA90-0x000000018BF1BABC
		public GUIStyleState normal { get => default; set {} } // 0x000000018BF1B380-0x000000018BF1B3C4 0x000000018BF1BABC-0x000000018BF1BAE0
		public GUIStyleState hover { get => default; set {} } // 0x000000018BF1B0F8-0x000000018BF1B140 0x000000018BF1BA08-0x000000018BF1BA2C
		public GUIStyleState active { get => default; set {} } // 0x000000018BF1AE00-0x000000018BF1AE48 0x000000018BF1B770-0x000000018BF1B794
		public GUIStyleState onNormal { get => default; set {} } // 0x000000018BF1B49C-0x000000018BF1B4E4 0x000000018BF1BB4C-0x000000018BF1BB70
		public GUIStyleState onHover { get => default; set {} } // 0x000000018BF1B454-0x000000018BF1B49C 0x000000018BF1BB28-0x000000018BF1BB4C
		public GUIStyleState onActive { get => default; set {} } // 0x000000018BF1B3C4-0x000000018BF1B40C 0x000000018BF1BAE0-0x000000018BF1BB04
		public GUIStyleState focused { get => default; set {} } // 0x000000018BF1B014-0x000000018BF1B05C 0x000000018BF1B920-0x000000018BF1B944
		public GUIStyleState onFocused { get => default; set {} } // 0x000000018BF1B40C-0x000000018BF1B454 0x000000018BF1BB04-0x000000018BF1BB28
		public RectOffset border { get => default; set {} } // 0x000000018BF1AE7C-0x000000018BF1AF10 0x000000018BF1B7D4-0x000000018BF1B7F8
		public RectOffset margin { get => default; set {} } // 0x000000018BF1B218-0x000000018BF1B2AC 0x000000018BF1BA6C-0x000000018BF1BA90
		public RectOffset padding { get => default; set {} } // 0x000000018BF1B578-0x000000018BF1B60C 0x000000018BF1BB94-0x000000018BF1BBB8
		public RectOffset overflow { get => default; set {} } // 0x000000018BF1B4E4-0x000000018BF1B578 0x000000018BF1BB70-0x000000018BF1BB94
		public float lineHeight { get => default; } // 0x000000018BF1B1C4-0x000000018BF1B218 
		public static GUIStyle none { get => default; } // 0x000000018BF1B2E0-0x000000018BF1B380 
		public bool isHeightDependantOnWidth { get => default; } // 0x000000018BF1B174-0x000000018BF1B1C4 
	
		// Constructors
		public GUIStyle() {} // 0x000000018BF1ADB0-0x000000018BF1AE00
		public GUIStyle(GUIStyle other) {} // 0x000000018BF1AD18-0x000000018BF1ADB0
		static GUIStyle() {} // 0x000000018BF1ACE0-0x000000018BF1AD18
	
		// Methods
		private static IntPtr Internal_Create(GUIStyle self) => default; // 0x000000018BF1A65C-0x000000018BF1A690
		private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) => default; // 0x000000018BF1A618-0x000000018BF1A65C
		private static void Internal_Destroy(IntPtr self) {} // 0x000000018BF1A690-0x000000018BF1A6C4
		private IntPtr GetStyleStatePtr(int idx) => default; // 0x000000018BF1A400-0x000000018BF1A440
		private void AssignStyleState(int idx, IntPtr srcStyleState) {} // 0x000000018BF19A40-0x000000018BF19A90
		private IntPtr GetRectOffsetPtr(int idx) => default; // 0x000000018BF1A3C0-0x000000018BF1A400
		private void AssignRectOffset(int idx, IntPtr srcRectOffset) {} // 0x000000018BF199F0-0x000000018BF19A40
		private static float Internal_GetLineHeight(IntPtr target) => default; // 0x000000018BF1AA88-0x000000018BF1AABC
		private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x000000018BF1A90C-0x000000018BF1A944
		private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) {} // 0x000000018BF1A728-0x000000018BF1A748
		private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) {} // 0x000000018BF1A7AC-0x000000018BF1A7D0
		private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) {} // 0x000000018BF1A838-0x000000018BF1A8A8
		internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) => default; // 0x000000018BF1A9D4-0x000000018BF1AA00
		internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) => default; // 0x000000018BF1AA64-0x000000018BF1AA88
		internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) => default; // 0x000000018BF1AB20-0x000000018BF1AB40
		internal Vector2 Internal_CalcSize(GUIContent content) => default; // 0x000000018BF1A5F4-0x000000018BF1A618
		internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) => default; // 0x000000018BF1A570-0x000000018BF1A5A0
		private float Internal_CalcHeight(GUIContent content, float width) => default; // 0x000000018BF1A440-0x000000018BF1A494
		private Vector2 Internal_CalcMinMaxWidth(GUIContent content) => default; // 0x000000018BF1A4E8-0x000000018BF1A50C
		internal static void SetMouseTooltip(string tooltip, Rect screenRect) {} // 0x000000018BF1ABEC-0x000000018BF1AC48
		internal static bool IsTooltipActive(string tooltip) => default; // 0x000000018BF1AB40-0x000000018BF1AB74
		private static float Internal_GetCursorFlashOffset() => default; // 0x000000018BF1A944-0x000000018BF1A970
		internal static void SetDefaultFont(Font font) {} // 0x000000018BF1AB74-0x000000018BF1ABA8
		~GUIStyle() {} // 0x000000018BF1A2C0-0x000000018BF1A378
		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x000000018BF1A14C-0x000000018BF1A1F4
		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x000000018BF1A104-0x000000018BF1A14C
		public void Draw(Rect position, GUIContent content, int controlID) {} // 0x000000018BF1A1F4-0x000000018BF1A228
		public void Draw(Rect position, GUIContent content, int controlID, bool on) {} // 0x000000018BF1A058-0x000000018BF1A098
		public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) {} // 0x000000018BF1A228-0x000000018BF1A2C0
		private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x000000018BF1A098-0x000000018BF1A104
		public void DrawCursor(Rect position, GUIContent content, int controlID, int character) {} // 0x000000018BF19B00-0x000000018BF19CC0
		internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) {} // 0x000000018BF19CC0-0x000000018BF19ECC
		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) {} // 0x000000018BF19F0C-0x000000018BF1A058
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) {} // 0x000000018BF19ECC-0x000000018BF19F0C
		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) => default; // 0x000000018BF1A378-0x000000018BF1A39C
		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) => default; // 0x000000018BF1A39C-0x000000018BF1A3C0
		public Vector2 CalcSize(GUIContent content) => default; // 0x000000018BF19AEC-0x000000018BF19B00
		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) => default; // 0x000000018BF19AD8-0x000000018BF19AEC
		public float CalcHeight(GUIContent content, float width) => default; // 0x000000018BF19A90-0x000000018BF19A9C
		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) {
			minWidth = default;
			maxWidth = default;
		} // 0x000000018BF19A9C-0x000000018BF19AD8
		public override string ToString() => default; // 0x000000018BF1AC48-0x000000018BF1ACE0
		private void get_contentOffset_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1AF44-0x000000018BF1AF88
		private void set_contentOffset_Injected(ref Vector2 value) {} // 0x000000018BF1B838-0x000000018BF1B87C
		private void set_Internal_clipOffset_Injected(ref Vector2 value) {} // 0x000000018BF1B710-0x000000018BF1B754
		private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {} // 0x000000018BF1A8A8-0x000000018BF1A90C
		private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) {} // 0x000000018BF1A6C4-0x000000018BF1A728
		private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) {} // 0x000000018BF1A748-0x000000018BF1A7AC
		private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) {} // 0x000000018BF1A7D0-0x000000018BF1A838
		private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1A970-0x000000018BF1A9D4
		private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) => default; // 0x000000018BF1AA00-0x000000018BF1AA64
		private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) => default; // 0x000000018BF1AABC-0x000000018BF1AB20
		private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1A5A0-0x000000018BF1A5F4
		private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1A50C-0x000000018BF1A570
		private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1A494-0x000000018BF1A4E8
		private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) {} // 0x000000018BF1ABA8-0x000000018BF1ABEC
	}

	public enum ImagePosition // TypeDefIndex: 58053
	{
		ImageLeft = 0,
		ImageAbove = 1,
		ImageOnly = 2,
		TextOnly = 3
	}

	public enum TextClipping // TypeDefIndex: 58054
	{
		Overflow = 0,
		Clip = 1
	}

	public class GUITargetAttribute : Attribute // TypeDefIndex: 58055
	{
		// Fields
		internal int displayMask; // 0x10
	
		// Constructors
		public GUITargetAttribute() {} // Dummy constructor
	
		// Methods
		private static int GetGUITargetAttrValue(System.Type klass, string methodName) => default; // 0x000000018BF1BD0C-0x000000018BF1BE24
	}

	public class GUIUtility // TypeDefIndex: 58056
	{
		// Fields
		internal static int s_ControlCount; // 0x00
		internal static int s_SkinMode; // 0x04
		internal static int s_OriginalID; // 0x08
		internal static Action takeCapture; // 0x10
		internal static Action releaseCapture; // 0x18
		internal static Func<int, IntPtr, bool> processEvent; // 0x20
		internal static Action cleanupRoots; // 0x28
		internal static Func<Exception, bool> endContainerGUIFromException; // 0x30
		internal static Action guiChanged; // 0x38
		private static bool _guiIsExiting_k__BackingField; // 0x40
		internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x48
	
		// Properties
		public static bool hasModalWindow { get => default; } // 0x000000018BF1D5F0-0x000000018BF1D61C 
		internal static float pixelsPerPoint { get => default; } // 0x000000018BF1D6B8-0x000000018BF1D6E4 
		internal static int guiDepth { get => default; } // 0x000000018BF1D58C-0x000000018BF1D5B8 
		internal static Vector2 s_EditorScreenPointOffset { get => default; set {} } // 0x000000018BF1D718-0x000000018BF1D73C 0x000000018BF1D900-0x000000018BF1D91C
		internal static bool mouseUsed { get => default; set {} } // 0x000000018BF1D68C-0x000000018BF1D6B8 0x000000018BF1D898-0x000000018BF1D8CC
		internal static bool textFieldInput { get => default; set {} } // 0x000000018BF1D768-0x000000018BF1D794 0x000000018BF1D950-0x000000018BF1D984
		internal static bool manualTex2SRGBEnabled { get => default; set {} } // 0x000000018BF1D660-0x000000018BF1D68C 0x000000018BF1D864-0x000000018BF1D898
		public static string systemCopyBuffer { get => default; set {} } // 0x000000018BF1D73C-0x000000018BF1D768 0x000000018BF1D91C-0x000000018BF1D950
		internal static string compositionString { get => default; } // 0x000000018BF1D560-0x000000018BF1D58C 
		internal static IMECompositionMode imeCompositionMode { get => default; set {} } // 0x000000018BF1D628-0x000000018BF1D654 0x000000018BF1D828-0x000000018BF1D85C
		internal static Vector2 compositionCursorPos { get => default; set {} } // 0x000000018BF1D53C-0x000000018BF1D560 0x000000018BF1D7C8-0x000000018BF1D7E4
		internal static bool guiIsExiting { get; set; } // 0x000000018BF1D5B8-0x000000018BF1D5F0 0x000000018BF1D7E4-0x000000018BF1D820
		public static int hotControl { get => default; set {} } // 0x000000018BF1D61C-0x000000018BF1D628 0x000000018BF1D820-0x000000018BF1D828
		public static int keyboardControl { get => default; set {} } // 0x000000018BF1D654-0x000000018BF1D660 0x000000018BF1D85C-0x000000018BF1D864
	
		// Constructors
		public GUIUtility() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) => default; // 0x000000018BF1C9C8-0x000000018BF1C9DC
		public static int GetControlID(int hint, FocusType focusType, Rect rect) => default; // 0x000000018BF1C438-0x000000018BF1C4AC
		internal static void BeginContainerFromOwner(ScriptableObject owner) {} // 0x000000018BF1BF14-0x000000018BF1BF48
		internal static void BeginContainer(ObjectGUIState objectGUIState) {} // 0x000000018BF1BF48-0x000000018BF1BF7C
		internal static void Internal_EndContainer() {} // 0x000000018BF1C8EC-0x000000018BF1C918
		internal static int GetPermanentControlID() => default; // 0x000000018BF1C5E4-0x000000018BF1C610
		internal static int CheckForTabEvent(Event evt) => default; // 0x000000018BF1C00C-0x000000018BF1C040
		internal static void SetKeyboardControlToFirstControlId() {} // 0x000000018BF1D460-0x000000018BF1D48C
		internal static void SetKeyboardControlToLastControlId() {} // 0x000000018BF1D48C-0x000000018BF1D4B8
		internal static bool HasFocusableControls() => default; // 0x000000018BF1C668-0x000000018BF1C694
		internal static bool OwnsId(int id) => default; // 0x000000018BF1CC10-0x000000018BF1CC44
		public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) {
			widthInPixels = default;
			heightInPixels = default;
			return default;
		} // 0x000000018BF1BE88-0x000000018BF1BEC4
		internal static Vector3 Internal_MultiplyPoint(Vector3 point, Matrix4x4 transform) => default; // 0x000000018BF1CABC-0x000000018BF1CAF0
		internal static bool GetChanged() => default; // 0x000000018BF1C3C8-0x000000018BF1C3F4
		internal static void SetChanged(bool changed) {} // 0x000000018BF1D3F8-0x000000018BF1D42C
		internal static void SetDidGUIWindowsEatLastEvent(bool value) {} // 0x000000018BF1D42C-0x000000018BF1D460
		private static int Internal_GetHotControl() => default; // 0x000000018BF1CA10-0x000000018BF1CA3C
		private static int Internal_GetKeyboardControl() => default; // 0x000000018BF1CA3C-0x000000018BF1CA68
		private static void Internal_SetHotControl(int value) {} // 0x000000018BF1CAF0-0x000000018BF1CB24
		private static void Internal_SetKeyboardControl(int value) {} // 0x000000018BF1CB24-0x000000018BF1CB58
		private static object Internal_GetDefaultSkin(int skinMode) => default; // 0x000000018BF1C9DC-0x000000018BF1CA10
		private static Object Internal_GetBuiltinSkin(int skin) => default; // 0x000000018BF1C944-0x000000018BF1C978
		private static void Internal_ExitGUI() {} // 0x000000018BF1C918-0x000000018BF1C944
		private static Vector2 InternalWindowToScreenPoint(Vector2 windowPoint) => default; // 0x000000018BF1C8C0-0x000000018BF1C8EC
		private static Vector2 InternalScreenToWindowPoint(Vector2 screenPoint) => default; // 0x000000018BF1C850-0x000000018BF1C87C
		private static void MarkGUIChanged() {} // 0x000000018BF1CBCC-0x000000018BF1CC10
		public static int GetControlID(FocusType focus) => default; // 0x000000018BF1C4AC-0x000000018BF1C4BC
		public static int GetControlID(GUIContent contents, FocusType focus) => default; // 0x000000018BF1C4BC-0x000000018BF1C4E8
		public static int GetControlID(FocusType focus, Rect position) => default; // 0x000000018BF1C3F4-0x000000018BF1C418
		public static int GetControlID(GUIContent contents, FocusType focus, Rect position) => default; // 0x000000018BF1C4E8-0x000000018BF1C530
		public static int GetControlID(int hint, FocusType focus) => default; // 0x000000018BF1C418-0x000000018BF1C438
		public static object GetStateObject(System.Type t, int controlID) => default; // 0x000000018BF1C610-0x000000018BF1C668
		public static object QueryStateObject(System.Type t, int controlID) => default; // 0x000000018BF1CCB8-0x000000018BF1CD10
		internal static void TakeCapture() {} // 0x000000018BF1D4C4-0x000000018BF1D508
		internal static void RemoveCapture() {} // 0x000000018BF1CD10-0x000000018BF1CD54
		internal static bool HasKeyFocus(int controlID) => default; // 0x000000018BF1C694-0x000000018BF1C708
		public static void ExitGUI() {} // 0x000000018BF1C2B0-0x000000018BF1C2FC
		internal static GUISkin GetDefaultSkin(int skinMode) => default; // 0x000000018BF1C530-0x000000018BF1C580
		internal static GUISkin GetDefaultSkin() => default; // 0x000000018BF1C580-0x000000018BF1C5E4
		internal static GUISkin GetBuiltinSkin(int skin) => default; // 0x000000018BF1C378-0x000000018BF1C3C8
		internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) {
			result = default;
		} // 0x000000018BF1CC44-0x000000018BF1CCB8
		internal static void EndContainer() {} // 0x000000018BF1C14C-0x000000018BF1C164
		internal static void CleanupRoots() {} // 0x000000018BF1C0AC-0x000000018BF1C0F0
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) {} // 0x000000018BF1BF7C-0x000000018BF1C00C
		internal static void EndGUI(int layoutType) {} // 0x000000018BF1C184-0x000000018BF1C2B0
		internal static bool EndGUIFromException(Exception exception) => default; // 0x000000018BF1C164-0x000000018BF1C184
		internal static bool EndContainerGUIFromException(Exception exception) => default; // 0x000000018BF1C0F0-0x000000018BF1C14C
		internal static void ResetGlobalState() {} // 0x000000018BF1CD54-0x000000018BF1CDB8
		internal static bool IsExitGUIException(Exception exception) => default; // 0x000000018BF1CB58-0x000000018BF1CBCC
		internal static bool ShouldRethrowException(Exception exception) => default; // 0x000000018BF1D4B8-0x000000018BF1D4C4
		internal static void CheckOnGUI() {} // 0x000000018BF1C040-0x000000018BF1C0AC
		internal static float RoundToPixelGrid(float v) => default; // 0x000000018BF1D098-0x000000018BF1D0D8
		public static Vector2 GUIToScreenPoint(Vector2 guiPoint) => default; // 0x000000018BF1C2FC-0x000000018BF1C318
		public static Rect GUIToScreenRect(Rect guiRect) => default; // 0x000000018BF1C318-0x000000018BF1C378
		public static Vector2 ScreenToGUIPoint(Vector2 screenPoint) => default; // 0x000000018BF1D37C-0x000000018BF1D398
		public static Rect ScreenToGUIRect(Rect screenRect) => default; // 0x000000018BF1D398-0x000000018BF1D3F8
		public static void RotateAroundPivot(float angle, Vector2 pivotPoint) {} // 0x000000018BF1CDB8-0x000000018BF1D098
		public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint) {} // 0x000000018BF1D0D8-0x000000018BF1D37C
		public static Rect AlignRectToDevice(Rect rect) => default; // 0x000000018BF1BEC4-0x000000018BF1BF14
		public static bool HitTest(Rect rect, Vector2 point, int offset) => default; // 0x000000018BF1C770-0x000000018BF1C7E8
		public static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) => default; // 0x000000018BF1C7E8-0x000000018BF1C80C
		public static bool HitTest(Rect rect, Event evt) => default; // 0x000000018BF1C708-0x000000018BF1C770
		private static void get_s_EditorScreenPointOffset_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1D6E4-0x000000018BF1D718
		private static void set_s_EditorScreenPointOffset_Injected(ref Vector2 value) {} // 0x000000018BF1D8CC-0x000000018BF1D900
		private static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) => default; // 0x000000018BF1C978-0x000000018BF1C9C8
		private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) {
			widthInPixels = default;
			heightInPixels = default;
			ret = default;
		} // 0x000000018BF1BE24-0x000000018BF1BE88
		private static void get_compositionCursorPos_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1D508-0x000000018BF1D53C
		private static void set_compositionCursorPos_Injected(ref Vector2 value) {} // 0x000000018BF1D794-0x000000018BF1D7C8
		private static void Internal_MultiplyPoint_Injected(ref Vector3 point, ref Matrix4x4 transform, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF1CA68-0x000000018BF1CABC
		private static void InternalWindowToScreenPoint_Injected(ref Vector2 windowPoint, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1C87C-0x000000018BF1C8C0
		private static void InternalScreenToWindowPoint_Injected(ref Vector2 screenPoint, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF1C80C-0x000000018BF1C850
	}

	public sealed class ExitGUIException : Exception // TypeDefIndex: 58057
	{
		// Constructors
		public ExitGUIException() {} // 0x000000018BF13000-0x000000018BF13050
		internal ExitGUIException(string message) {} // 0x000000018BF13050-0x000000018BF130A8
	}

	internal class GUILayoutEntry // TypeDefIndex: 58058
	{
		// Fields
		public float minWidth; // 0x10
		public float maxWidth; // 0x14
		public float minHeight; // 0x18
		public float maxHeight; // 0x1C
		public Rect rect; // 0x20
		public int stretchWidth; // 0x30
		public int stretchHeight; // 0x34
		public bool consideredForMargin; // 0x38
		private GUIStyle m_Style; // 0x40
		internal static Rect kDummyRect; // 0x00
		protected static int indent; // 0x10
	
		// Properties
		public GUIStyle style { get => default; set {} } // 0x0000000185FE8B00-0x0000000185FE8B10 0x000000018BF144D0-0x000000018BF14518
		public virtual int marginLeft { get => default; } // 0x000000018BF14408-0x000000018BF14438 
		public virtual int marginRight { get => default; } // 0x000000018BF14438-0x000000018BF14468 
		public virtual int marginTop { get => default; } // 0x000000018BF14468-0x000000018BF14498 
		public virtual int marginBottom { get => default; } // 0x000000018BF143A0-0x000000018BF143D0 
		public int marginHorizontal { get => default; } // 0x000000018BF143D0-0x000000018BF14408 
		public int marginVertical { get => default; } // 0x000000018BF14498-0x000000018BF144D0 
	
		// Constructors
		public GUILayoutEntry() {} // Dummy constructor
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) {} // 0x000000018BF14210-0x000000018BF142DC
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) {} // 0x000000018BF142DC-0x000000018BF143A0
		static GUILayoutEntry() {} // 0x000000018BF141BC-0x000000018BF14210
	
		// Methods
		public virtual void CalcWidth() {} // 0x0000000185492010-0x0000000185492020
		public virtual void CalcHeight() {} // 0x0000000185492010-0x0000000185492020
		public virtual void SetHorizontal(float x, float width) {} // 0x0000000185FE8AE0-0x0000000185FE8AF0
		public virtual void SetVertical(float y, float height) {} // 0x0000000185FE8AF0-0x0000000185FE8B00
		protected virtual void ApplyStyleSettings(GUIStyle style) {} // 0x000000018BF13D60-0x000000018BF13DFC
		public virtual void ApplyOptions(GUILayoutOption[] options) {} // 0x000000018BF13B30-0x000000018BF13D60
		public override string ToString() => default; // 0x000000018BF13DFC-0x000000018BF141BC
	}

	internal sealed class GUIWordWrapSizer : GUILayoutEntry // TypeDefIndex: 58059
	{
		// Fields
		private readonly GUIContent m_Content; // 0x48
		private readonly float m_ForcedMinHeight; // 0x50
		private readonly float m_ForcedMaxHeight; // 0x54
	
		// Constructors
		public GUIWordWrapSizer() {} // Dummy constructor
		public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options) {} // 0x000000018BF267C8-0x000000018BF268A0
	
		// Methods
		public override void CalcWidth() {} // 0x000000018BF2671C-0x000000018BF267C8
		public override void CalcHeight() {} // 0x000000018BF2669C-0x000000018BF2671C
	}

	internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 58060
	{
		// Fields
		public List<GUILayoutEntry> entries; // 0x48
		public bool isVertical; // 0x50
		public bool resetCoords; // 0x51
		public float spacing; // 0x54
		public bool sameSize; // 0x58
		public bool isWindow; // 0x59
		public int windowID; // 0x5C
		private int m_Cursor; // 0x60
		protected int m_StretchableCountX; // 0x64
		protected int m_StretchableCountY; // 0x68
		protected bool m_UserSpecifiedWidth; // 0x6C
		protected bool m_UserSpecifiedHeight; // 0x6D
		protected float m_ChildMinWidth; // 0x70
		protected float m_ChildMaxWidth; // 0x74
		protected float m_ChildMinHeight; // 0x78
		protected float m_ChildMaxHeight; // 0x7C
		protected int m_MarginLeft; // 0x80
		protected int m_MarginRight; // 0x84
		protected int m_MarginTop; // 0x88
		protected int m_MarginBottom; // 0x8C
		private static readonly GUILayoutEntry none; // 0x00
	
		// Properties
		public override int marginLeft { get => default; } // 0x000000018140C930-0x000000018140C940 
		public override int marginRight { get => default; } // 0x0000000182FB0000-0x0000000182FB0010 
		public override int marginTop { get => default; } // 0x00000001834A1F30-0x00000001834A1F40 
		public override int marginBottom { get => default; } // 0x000000018349D720-0x000000018349D730 
	
		// Constructors
		public GUILayoutGroup() {} // 0x000000018BF2604C-0x000000018BF26158
		static GUILayoutGroup() {} // 0x000000018BF25F7C-0x000000018BF2604C
	
		// Methods
		public override void ApplyOptions(GUILayoutOption[] options) {} // 0x000000018BF23954-0x000000018BF23A24
		protected override void ApplyStyleSettings(GUIStyle style) {} // 0x000000018BF23A24-0x000000018BF23AA4
		public void ResetCursor() {} // 0x0000000185FE8C80-0x0000000185FE8C90
		public GUILayoutEntry GetNext() => default; // 0x000000018BF24A94-0x000000018BF24CE8
		public Rect GetLast() => default; // 0x000000018BF2480C-0x000000018BF24A94
		public void Add(GUILayoutEntry e) {} // 0x000000018BF23900-0x000000018BF23954
		public override void CalcWidth() {} // 0x000000018BF24120-0x000000018BF2480C
		public override void SetHorizontal(float x, float width) {} // 0x000000018BF24CE8-0x000000018BF25450
		public override void CalcHeight() {} // 0x000000018BF23AA4-0x000000018BF24120
		public override void SetVertical(float y, float height) {} // 0x000000018BF25450-0x000000018BF25C30
		public override string ToString() => default; // 0x000000018BF25C30-0x000000018BF25F7C
	}

	internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 58061
	{
		// Fields
		public float calcMinWidth; // 0x90
		public float calcMaxWidth; // 0x94
		public float calcMinHeight; // 0x98
		public float calcMaxHeight; // 0x9C
		public float clientWidth; // 0xA0
		public float clientHeight; // 0xA4
		public bool allowHorizontalScroll; // 0xA8
		public bool allowVerticalScroll; // 0xA9
		public bool needsHorizontalScrollbar; // 0xAA
		public bool needsVerticalScrollbar; // 0xAB
		public GUIStyle horizontalScrollbar; // 0xB0
		public GUIStyle verticalScrollbar; // 0xB8
	
		// Constructors
		public GUIScrollGroup() {} // 0x000000018BF26648-0x000000018BF2669C
	
		// Methods
		public override void CalcWidth() {} // 0x000000018BF26270-0x000000018BF26304
		public override void SetHorizontal(float x, float width) {} // 0x000000018BF26304-0x000000018BF2643C
		public override void CalcHeight() {} // 0x000000018BF26158-0x000000018BF26270
		public override void SetVertical(float y, float height) {} // 0x000000018BF2643C-0x000000018BF26648
	}

	internal class ObjectGUIState : IDisposable // TypeDefIndex: 58062
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public ObjectGUIState() {} // 0x000000018BF269E8-0x000000018BF26A04
	
		// Methods
		public void Dispose() {} // 0x000000018BF268CC-0x000000018BF26918
		~ObjectGUIState() {} // 0x000000018BF26918-0x000000018BF26988
		private void Destroy() {} // 0x000000018BF268A0-0x000000018BF268CC
		private static IntPtr Internal_Create() => default; // 0x000000018BF26988-0x000000018BF269B4
		private static void Internal_Destroy(IntPtr ptr) {} // 0x000000018BF269B4-0x000000018BF269E8
	}

	internal class ScrollViewState // TypeDefIndex: 58063
	{
		// Fields
		public Rect position; // 0x10
		public Rect visibleRect; // 0x20
		public Rect viewRect; // 0x30
		public Vector2 scrollPosition; // 0x40
		public bool apply; // 0x48
		public bool isDuringTouchScroll; // 0x49
		public Vector2 touchScrollStartMousePosition; // 0x4C
		public Vector2 touchScrollStartPosition; // 0x54
		public Vector2 velocity; // 0x5C
		public float previousTimeSinceStartup; // 0x64
	
		// Constructors
		public ScrollViewState() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class SliderState // TypeDefIndex: 58064
	{
		// Fields
		public float dragStartPos; // 0x10
		public float dragStartValue; // 0x14
		public bool isDragging; // 0x18
	
		// Constructors
		public SliderState() {} // 0x0000000185492010-0x0000000185492020
	}

	internal struct SliderHandler // TypeDefIndex: 58065
	{
		// Fields
		private readonly Rect position; // 0x00
		private readonly float currentValue; // 0x10
		private readonly float size; // 0x14
		private readonly float start; // 0x18
		private readonly float end; // 0x1C
		private readonly GUIStyle slider; // 0x20
		private readonly GUIStyle thumb; // 0x28
		private readonly GUIStyle thumbExtent; // 0x30
		private readonly bool horiz; // 0x38
		private readonly int id; // 0x3C
	
		// Constructors
		public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) {
			this.position = default;
			this.currentValue = default;
			this.size = default;
			this.start = default;
			this.end = default;
			this.slider = default;
			this.thumb = default;
			this.thumbExtent = default;
			this.horiz = default;
			this.id = default;
		} // 0x000000018BF27D64-0x000000018BF27DE4
	
		// Methods
		public float Handle() => default; // 0x000000018BF26B20-0x000000018BF26BA8
		private float OnMouseDown() => default; // 0x000000018BF26E04-0x000000018BF27158
		private float OnMouseDrag() => default; // 0x000000018BF27158-0x000000018BF27238
		private float OnMouseUp() => default; // 0x000000018BF27238-0x000000018BF27280
		private float OnRepaint() => default; // 0x000000018BF27280-0x000000018BF275FC
		private EventType CurrentEventType() => default; // 0x000000018BF26A44-0x000000018BF26A74
		private int CurrentScrollTroughSide() => default; // 0x000000018BF26A80-0x000000018BF26B20
		private bool IsEmptySlider() => default; // 0x000000018BF26D5C-0x000000018BF26D70
		private bool SupportsPageMovements() => default; // 0x000000018BF277C8-0x000000018BF27824
		private float PageMovementValue() => default; // 0x000000018BF275FC-0x000000018BF2768C
		private float PageUpMovementBound() => default; // 0x000000018BF2768C-0x000000018BF276EC
		private Event CurrentEvent() => default; // 0x000000018BF26A74-0x000000018BF26A80
		private float ValueForCurrentMousePosition() => default; // 0x000000018BF27A28-0x000000018BF27AF8
		private float Clamp(float value) => default; // 0x000000018BF26A04-0x000000018BF26A34
		private Rect ThumbSelectionRect() => default; // 0x000000018BF27940-0x000000018BF2796C
		private void StartDraggingWithValue(float dragStartValue) {} // 0x000000018BF27774-0x000000018BF277C8
		private SliderState SliderState() => default; // 0x000000018BF276EC-0x000000018BF27774
		private Rect ThumbExtRect() => default; // 0x000000018BF27824-0x000000018BF27904
		private Rect ThumbRect() => default; // 0x000000018BF27904-0x000000018BF27940
		private Rect VerticalThumbRect() => default; // 0x000000018BF27BB0-0x000000018BF27D64
		private Rect HorizontalThumbRect() => default; // 0x000000018BF26BA8-0x000000018BF26D5C
		private float ClampedCurrentValue() => default; // 0x000000018BF26A34-0x000000018BF26A44
		private float MousePosition() => default; // 0x000000018BF26D94-0x000000018BF26E04
		private float ValuesPerPixel() => default; // 0x000000018BF27AF8-0x000000018BF27BB0
		private float ThumbSize() => default; // 0x000000018BF2796C-0x000000018BF27A28
		private float MaxValue() => default; // 0x000000018BF26D70-0x000000018BF26D84
		private float MinValue() => default; // 0x000000018BF26D84-0x000000018BF26D94
	}

	public class TextEditor // TypeDefIndex: 58070
	{
		// Fields
		public TouchScreenKeyboard keyboardOnScreen; // 0x10
		public int controlID; // 0x18
		public GUIStyle style; // 0x20
		public bool multiline; // 0x28
		public bool hasHorizontalCursorPos; // 0x29
		public bool isPasswordField; // 0x2A
		internal bool m_HasFocus; // 0x2B
		public Vector2 scrollOffset; // 0x2C
		private GUIContent m_Content; // 0x38
		private Rect m_Position; // 0x40
		private int m_CursorIndex; // 0x50
		private int m_SelectIndex; // 0x54
		private bool m_RevealCursor; // 0x58
		public Vector2 graphicalCursorPos; // 0x5C
		public Vector2 graphicalSelectCursorPos; // 0x64
		private bool m_MouseDragSelectsWholeWords; // 0x6C
		private int m_DblClickInitPos; // 0x70
		private DblClickSnapping m_DblClickSnap; // 0x74
		private bool m_bJustSelected; // 0x75
		private int m_iAltCursorPos; // 0x78
		private string oldText; // 0x80
		private int oldPos; // 0x88
		private int oldSelectPos; // 0x8C
		private static Dictionary<Event, TextEditOp> s_Keyactions; // 0x00
	
		// Properties
		public string text { get => default; set {} } // 0x000000018B4B5248-0x000000018B4B5264 0x000000018BF2BEEC-0x000000018BF2BF70
		public Rect position { get => default; set {} } // 0x0000000185FE8CD0-0x0000000185FE8CE0 0x000000018BF2BE54-0x000000018BF2BEB0
		internal virtual Rect localPosition { get => default; } // 0x0000000185FE8CC0-0x0000000185FE8CD0 
		public int cursorIndex { get => default; set {} } // 0x0000000185FE6500-0x0000000185FE6510 0x000000018BF2BE14-0x000000018BF2BE54
		public int selectIndex { get => default; set {} } // 0x0000000185FE8CE0-0x0000000185FE8CF0 0x000000018BF2BEB0-0x000000018BF2BEEC
		public int altCursorPosition { get => default; } // 0x0000000185FE8CB0-0x0000000185FE8CC0 
		public bool hasSelection { get => default; } // 0x000000018BF2BE08-0x000000018BF2BE14 
		public string SelectedText { get => default; } // 0x000000018BF2BD80-0x000000018BF2BE08 
	
		// Nested types
		public enum DblClickSnapping : byte // TypeDefIndex: 58066
		{
			WORDS = 0,
			PARAGRAPHS = 1
		}
	
		private enum CharacterType // TypeDefIndex: 58067
		{
			LetterLike = 0,
			Symbol = 1,
			Symbol2 = 2,
			WhiteSpace = 3
		}
	
		private enum Direction // TypeDefIndex: 58068
		{
			Forward = 0,
			Backward = 1
		}
	
		private enum TextEditOp // TypeDefIndex: 58069
		{
			MoveLeft = 0,
			MoveRight = 1,
			MoveUp = 2,
			MoveDown = 3,
			MoveLineStart = 4,
			MoveLineEnd = 5,
			MoveTextStart = 6,
			MoveTextEnd = 7,
			MovePageUp = 8,
			MovePageDown = 9,
			MoveGraphicalLineStart = 10,
			MoveGraphicalLineEnd = 11,
			MoveWordLeft = 12,
			MoveWordRight = 13,
			MoveParagraphForward = 14,
			MoveParagraphBackward = 15,
			MoveToStartOfNextWord = 16,
			MoveToEndOfPreviousWord = 17,
			SelectLeft = 18,
			SelectRight = 19,
			SelectUp = 20,
			SelectDown = 21,
			SelectTextStart = 22,
			SelectTextEnd = 23,
			SelectPageUp = 24,
			SelectPageDown = 25,
			ExpandSelectGraphicalLineStart = 26,
			ExpandSelectGraphicalLineEnd = 27,
			SelectGraphicalLineStart = 28,
			SelectGraphicalLineEnd = 29,
			SelectWordLeft = 30,
			SelectWordRight = 31,
			SelectToEndOfPreviousWord = 32,
			SelectToStartOfNextWord = 33,
			SelectParagraphBackward = 34,
			SelectParagraphForward = 35,
			Delete = 36,
			Backspace = 37,
			DeleteWordBack = 38,
			DeleteWordForward = 39,
			DeleteLineBack = 40,
			Cut = 41,
			Copy = 42,
			Paste = 43,
			SelectAll = 44,
			SelectNone = 45,
			ScrollStart = 46,
			ScrollEnd = 47,
			ScrollPageUp = 48,
			ScrollPageDown = 49
		}
	
		// Constructors
		public TextEditor() {} // 0x000000018BF2BCB0-0x000000018BF2BD80
	
		// Methods
		private void ClearCursorPos() {} // 0x0000000185FE8C90-0x0000000185FE8CA0
		public void OnFocus() {} // 0x000000018BF2A7F4-0x000000018BF2A830
		public void OnLostFocus() {} // 0x000000018BF2A830-0x000000018BF2A83C
		private void GrabGraphicalCursorPos() {} // 0x000000018BF29048-0x000000018BF2912C
		public bool HandleKeyEvent(Event e) => default; // 0x000000018BF2924C-0x000000018BF2925C
		internal bool HandleKeyEvent(Event e, bool textIsReadOnly) => default; // 0x000000018BF2912C-0x000000018BF2924C
		public bool DeleteLineBack() => default; // 0x000000018BF28084-0x000000018BF28178
		public bool DeleteWordBack() => default; // 0x000000018BF2830C-0x000000018BF283C0
		public bool DeleteWordForward() => default; // 0x000000018BF283C0-0x000000018BF2846C
		public bool Delete() => default; // 0x000000018BF2846C-0x000000018BF28524
		public bool CanPaste() => default; // 0x000000018BF27EA0-0x000000018BF27EC4
		public bool Backspace() => default; // 0x000000018BF27DE4-0x000000018BF27EA0
		public void SelectAll() {} // 0x000000018BF2AF64-0x000000018BF2AFA8
		public void SelectNone() {} // 0x000000018BF2B238-0x000000018BF2B260
		public bool DeleteSelection() => default; // 0x000000018BF28178-0x000000018BF2830C
		public void ReplaceSelection(string replace) {} // 0x000000018BF2AE90-0x000000018BF2AF28
		public void Insert(char c) {} // 0x000000018BF29B9C-0x000000018BF29BF0
		public void MoveSelectionToAltCursor() {} // 0x000000018BF2A364-0x000000018BF2A444
		public void MoveRight() {} // 0x000000018BF2A304-0x000000018BF2A364
		public void MoveLeft() {} // 0x000000018BF2A084-0x000000018BF2A0D8
		public void MoveUp() {} // 0x000000018BF2A564-0x000000018BF2A634
		public void MoveDown() {} // 0x000000018BF29EEC-0x000000018BF29FEC
		public void MoveLineStart() {} // 0x000000018BF2A170-0x000000018BF2A1FC
		public void MoveLineEnd() {} // 0x000000018BF2A0D8-0x000000018BF2A170
		public void MoveGraphicalLineStart() {} // 0x000000018BF2A038-0x000000018BF2A084
		public void MoveGraphicalLineEnd() {} // 0x000000018BF29FEC-0x000000018BF2A038
		public void MoveTextStart() {} // 0x000000018BF2A48C-0x000000018BF2A4B4
		public void MoveTextEnd() {} // 0x000000018BF2A444-0x000000018BF2A48C
		private int IndexOfEndOfLine(int startIndex) => default; // 0x000000018BF2925C-0x000000018BF292B4
		public void MoveParagraphForward() {} // 0x000000018BF2A28C-0x000000018BF2A304
		public void MoveParagraphBackward() {} // 0x000000018BF2A1FC-0x000000018BF2A28C
		public void MoveCursorToPosition(Vector2 cursorPosition) {} // 0x000000018BF29EA0-0x000000018BF29EEC
		protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) {} // 0x000000018BF29DE0-0x000000018BF29EA0
		public void MoveAltCursorToPosition(Vector2 cursorPosition) {} // 0x000000018BF29D30-0x000000018BF29DE0
		public void SelectToPosition(Vector2 cursorPosition) {} // 0x000000018BF2B458-0x000000018BF2B6FC
		public void SelectLeft() {} // 0x000000018BF2B1D8-0x000000018BF2B238
		public void SelectRight() {} // 0x000000018BF2B388-0x000000018BF2B3E8
		public void SelectUp() {} // 0x000000018BF2B730-0x000000018BF2B7C0
		public void SelectDown() {} // 0x000000018BF2B0BC-0x000000018BF2B170
		public void SelectTextEnd() {} // 0x000000018BF2B3E8-0x000000018BF2B418
		public void SelectTextStart() {} // 0x000000018BF2B418-0x000000018BF2B424
		public void MouseDragSelectsWholeWords(bool on) {} // 0x0000000185FE8CA0-0x0000000185FE8CB0
		public void DblClickSnap(DblClickSnapping snapping) {} // 0x0000000185FBD4F0-0x0000000185FBD500
		private int GetGraphicalLineStart(int p) => default; // 0x000000018BF28F6C-0x000000018BF29048
		private int GetGraphicalLineEnd(int p) => default; // 0x000000018BF28E7C-0x000000018BF28F6C
		private int FindNextSeperator(int startPos) => default; // 0x000000018BF28BE0-0x000000018BF28C68
		private int FindPrevSeperator(int startPos) => default; // 0x000000018BF28C68-0x000000018BF28D08
		public void MoveWordRight() {} // 0x000000018BF2A684-0x000000018BF2A6E8
		public void MoveToStartOfNextWord() {} // 0x000000018BF2A50C-0x000000018BF2A564
		public void MoveToEndOfPreviousWord() {} // 0x000000018BF2A4B4-0x000000018BF2A50C
		public void SelectToStartOfNextWord() {} // 0x000000018BF2B6FC-0x000000018BF2B730
		public void SelectToEndOfPreviousWord() {} // 0x000000018BF2B424-0x000000018BF2B458
		private CharacterType ClassifyChar(int index) => default; // 0x000000018BF27F04-0x000000018BF27FDC
		public int FindStartOfNextWord(int p) => default; // 0x000000018BF28D08-0x000000018BF28E7C
		private int FindEndOfPreviousWord(int p) => default; // 0x000000018BF28B2C-0x000000018BF28BE0
		public void MoveWordLeft() {} // 0x000000018BF2A634-0x000000018BF2A684
		public void SelectWordRight() {} // 0x000000018BF2B844-0x000000018BF2B8C8
		public void SelectWordLeft() {} // 0x000000018BF2B7C0-0x000000018BF2B844
		public void ExpandSelectGraphicalLineStart() {} // 0x000000018BF28994-0x000000018BF289F8
		public void ExpandSelectGraphicalLineEnd() {} // 0x000000018BF28930-0x000000018BF28994
		public void SelectGraphicalLineStart() {} // 0x000000018BF2B1A4-0x000000018BF2B1D8
		public void SelectGraphicalLineEnd() {} // 0x000000018BF2B170-0x000000018BF2B1A4
		public void SelectParagraphForward() {} // 0x000000018BF2B300-0x000000018BF2B388
		public void SelectParagraphBackward() {} // 0x000000018BF2B260-0x000000018BF2B300
		public void SelectCurrentWord() {} // 0x000000018BF2B030-0x000000018BF2B0BC
		private int FindEndOfClassification(int p, Direction dir) => default; // 0x000000018BF289F8-0x000000018BF28B2C
		public void SelectCurrentParagraph() {} // 0x000000018BF2AFA8-0x000000018BF2B030
		public void UpdateScrollOffsetIfNeeded(Event evt) {} // 0x000000018BF2B8C8-0x000000018BF2B918
		internal void UpdateScrollOffset() {} // 0x000000018BF2B918-0x000000018BF2BCB0
		public void DrawCursor(string newText) {} // 0x000000018BF28524-0x000000018BF288EC
		private bool PerformOperation(TextEditOp operation, bool textIsReadOnly) => default; // 0x000000018BF2A8C0-0x000000018BF2AD70
		public void SaveBackup() {} // 0x000000018BF2AF28-0x000000018BF2AF64
		public bool Cut() => default; // 0x000000018BF28058-0x000000018BF28084
		public void Copy() {} // 0x000000018BF27FDC-0x000000018BF28058
		private static string ReplaceNewlinesWithSpaces(string value) => default; // 0x000000018BF2AE04-0x000000018BF2AE90
		public bool Paste() => default; // 0x000000018BF2A83C-0x000000018BF2A8C0
		private static void MapKey(string key, TextEditOp action) {} // 0x000000018BF29CA8-0x000000018BF29D30
		private void InitKeyActions() {} // 0x000000018BF292B4-0x000000018BF29B9C
		public void DetectFocusChange() {} // 0x000000018B71F490-0x000000018B71F4A0
		internal virtual void OnDetectFocusChange() {} // 0x000000018BF2A79C-0x000000018BF2A7F4
		internal virtual void OnCursorIndexChange() {} // 0x0000000185492010-0x0000000185492020
		internal virtual void OnSelectIndexChange() {} // 0x0000000185492010-0x0000000185492020
		private void ClampTextIndex(ref int index) {} // 0x000000018BF27EC4-0x000000018BF27F04
		private void EnsureValidCodePointIndex(ref int index) {} // 0x000000018BF288EC-0x000000018BF28930
		private bool IsValidCodePointIndex(int index) => default; // 0x000000018BF29BF0-0x000000018BF29CA8
		private int PreviousCodePointIndex(int index) => default; // 0x000000018BF2AD70-0x000000018BF2AE04
		private int NextCodePointIndex(int index) => default; // 0x000000018BF2A6E8-0x000000018BF2A79C
	}
}
