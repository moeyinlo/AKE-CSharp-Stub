/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngineInternal;

// Image 53: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 87991-88035

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 88035
{
	// Methods
	internal static uint ComputeStringHash(string s); // 0x0000000188B56950-0x0000000188B569A4
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 87992
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 87993
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine
{
	[NativeHeader("Modules/IMGUI/Event.bindings.h")]
	[StaticAccessor("GUIEvent", StaticAccessorType.DoubleColon)]
	public sealed class Event // TypeDefIndex: 87994
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private static Event s_Current; // 0x00
		private static Event s_MasterEvent; // 0x08
	
		// Properties
		[NativeProperty("type", false, UnityEngine.Bindings.TargetType.Field)]
		public EventType rawType { get; } // 0x0000000185A07950-0x0000000185A07990 
		[NativeProperty("mousePosition", false, UnityEngine.Bindings.TargetType.Field)]
		public Vector2 mousePosition { get; set; } // 0x000000018D528DF8-0x000000018D528E1C 0x000000018D529104-0x000000018D529120
		[NativeProperty("delta", false, UnityEngine.Bindings.TargetType.Field)]
		public Vector2 delta { get; set; } // 0x000000018D528CD8-0x000000018D528CFC 0x000000018D529024-0x000000018D529040
		[NativeProperty("pointerType", false, UnityEngine.Bindings.TargetType.Field)]
		public PointerType pointerType { get; } // 0x000000018D528E1C-0x000000018D528E50 
		[NativeProperty("button", false, UnityEngine.Bindings.TargetType.Field)]
		public int button { get; } // 0x000000018D528BC8-0x000000018D528BFC 
		[NativeProperty("modifiers", false, UnityEngine.Bindings.TargetType.Field)]
		public EventModifiers modifiers { get; set; } // 0x0000000185A06330-0x0000000185A06370 0x000000018D529080-0x000000018D5290C0
		[NativeProperty("pressure", false, UnityEngine.Bindings.TargetType.Field)]
		public float pressure { get; } // 0x000000018D528E50-0x000000018D528E84 
		[NativeProperty("clickCount", false, UnityEngine.Bindings.TargetType.Field)]
		public int clickCount { get; } // 0x000000018D528BFC-0x000000018D528C30 
		[NativeProperty("character", false, UnityEngine.Bindings.TargetType.Field)]
		public char character { get; set; } // 0x0000000185A06180-0x0000000185A061C0 0x000000018D528ED0-0x000000018D528F14
		[NativeProperty("keycode", false, UnityEngine.Bindings.TargetType.Field)]
		public KeyCode keyCode { get; set; } // 0x0000000185A06370-0x0000000185A063B0 0x000000018D529040-0x000000018D529080
		[NativeProperty("displayIndex", false, UnityEngine.Bindings.TargetType.Field)]
		public int displayIndex { get; set; } // 0x000000018D528CFC-0x000000018D528D30 0x0000000185E77300-0x0000000185E77350
		public EventType type { [FreeFunction("GUIEvent::GetType", HasExplicitThis = true)] get; [FreeFunction("GUIEvent::SetType", HasExplicitThis = true)] set; } // 0x000000018D528E9C-0x000000018D528ED0 0x000000018D529120-0x000000018D529160
		public string commandName { [FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = true)] get; [FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = true)] set; } // 0x000000018D528C30-0x000000018D528C64 0x000000018D528F14-0x000000018D528F58
		public bool shift { get; } // 0x000000018D528E84-0x000000018D528E9C 
		public bool control { get; } // 0x000000018D528C7C-0x000000018D528C94 
		public bool alt { get; } // 0x000000018D528BB0-0x000000018D528BC8 
		public bool command { get; } // 0x000000018D528C64-0x000000018D528C7C 
		public static Event current { get; set; } // 0x0000000187261E20-0x0000000187261E40 0x000000018D528F58-0x000000018D528FE0
		public bool isKey { get; } // 0x000000018D528D68-0x000000018D528D88 
		public bool isMouse { get; } // 0x000000018D528D88-0x000000018D528DB4 
		internal bool isDirectManipulationDevice { get; } // 0x000000018D528D30-0x000000018D528D68 
	
		// Constructors
		public Event(); // 0x0000000185E79260-0x0000000185E79280
		public Event(int displayIndex); // 0x0000000185E77940-0x0000000185E77960
	
		// Methods
		[NativeMethod("Use")]
		private void Internal_Use(); // 0x000000018D5275B0-0x000000018D5275E4
		[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(int displayIndex); // 0x0000000185E79280-0x0000000185E792C0
		[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr); // 0x0000000186AF0EC0-0x0000000186AF0F00
		[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = true)]
		public EventType GetTypeForControl(int controlID); // 0x000000018D527570-0x000000018D5275B0
		[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = true, HasExplicitThis = true)]
		[VisibleToOtherModules(new string[1] {"UnityEngine.UIElementsModule" })]
		internal void CopyFromPtr(IntPtr ptr); // 0x000000018D527320-0x000000018D527364
		public static bool PopEvent([NotNull("ArgumentNullException")] Event outEvent); // 0x0000000185A07910-0x0000000185A07950
		private static void Internal_SetNativeEvent(IntPtr ptr); // 0x0000000185E772C0-0x0000000185E77300
		[RequiredByNativeCode]
		internal static void Internal_MakeMasterEventCurrent(int displayIndex); // 0x0000000185E77110-0x0000000185E772C0
		[VisibleToOtherModules(new string[1] {"UnityEngine.UIElementsModule" })]
		internal static int GetDoubleClickTime(); // 0x000000018D5274D4-0x000000018D527500
		~Event(); // 0x0000000186AF0E20-0x0000000186AF0EC0
		internal void CopyFrom(Event e); // 0x000000018D527364-0x000000018D527390
		public static Event KeyboardEvent(string key); // 0x000000018D5275E4-0x000000018D528590
		public override int GetHashCode(); // 0x000000018D527500-0x000000018D527570
		public override bool Equals(object obj); // 0x000000018D527390-0x000000018D5274D4
		public override string ToString(); // 0x000000018D528590-0x000000018D528A9C
		public void Use(); // 0x000000018D528A9C-0x000000018D528BB0
		private void get_mousePosition_Injected(out Vector2 ret); // 0x000000018D528DB4-0x000000018D528DF8
		private void set_mousePosition_Injected(ref Vector2 value); // 0x000000018D5290C0-0x000000018D529104
		private void get_delta_Injected(out Vector2 ret); // 0x000000018D528C94-0x000000018D528CD8
		private void set_delta_Injected(ref Vector2 value); // 0x000000018D528FE0-0x000000018D529024
	}

	public enum EventType // TypeDefIndex: 87995
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

	[Flags]
	public enum EventModifiers // TypeDefIndex: 87996
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

	public enum PointerType // TypeDefIndex: 87997
	{
		Mouse = 0,
		Touch = 1,
		Pen = 2
	}

	internal struct EventInterests // TypeDefIndex: 87998
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _wantsMouseMove_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _wantsMouseEnterLeaveWindow_k__BackingField; // 0x01
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _wantsLessLayoutEvents_k__BackingField; // 0x02
	
		// Properties
		public bool wantsMouseMove { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AD2A0-0x00000001844AD2B0 0x0000000187233BE0-0x0000000187233BF0
		public bool wantsMouseEnterLeaveWindow { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001844AD300-0x00000001844AD310 0x0000000187239F70-0x0000000187239F80
		public bool wantsLessLayoutEvents { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000187239B80-0x0000000187239B90 
	
		// Methods
		public bool WantsEvent(EventType type); // 0x000000018D527290-0x000000018D5272AC
		public bool WantsLayoutPass(EventType type); // 0x000000018D5272AC-0x000000018D527320
	}

	[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	public class GUI // TypeDefIndex: 88000
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static int _scrollTroughSide_k__BackingField; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static System.DateTime _nextScrollStepTime_k__BackingField; // 0x30
		private static GUISkin s_Skin; // 0x38
		internal static Rect s_ToolTipRect; // 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static GenericStack _scrollViewStates_k__BackingField; // 0x50
	
		// Properties
		public static Color color { get; set; } // 0x000000018D538FBC-0x000000018D539008 0x000000018D5393B0-0x000000018D5393FC
		public static Color backgroundColor { get; set; } // 0x000000018D538EB8-0x000000018D538F04 0x000000018D5392FC-0x000000018D539348
		public static Color contentColor { get; set; } // 0x000000018D53903C-0x000000018D539088 0x000000018D539430-0x000000018D53947C
		public static bool changed { get; set; } // 0x000000018D538F5C-0x000000018D538F88 0x000000018D539348-0x000000018D53937C
		public static bool enabled { get; set; } // 0x000000018D539088-0x000000018D5390B4 0x000000018D53947C-0x000000018D5394B0
		internal static bool usePageScrollbars { get; } // 0x000000018D53929C-0x000000018D5392C8 
		internal static Material blendMaterial { [FreeFunction("GetGUIBlendMaterial")] get; } // 0x000000018D538F04-0x000000018D538F30 
		internal static Material blitMaterial { [FreeFunction("GetGUIBlitMaterial")] get; } // 0x000000018D538F30-0x000000018D538F5C 
		internal static Material roundedRectMaterial { [FreeFunction("GetGUIRoundedRectMaterial")] get; } // 0x000000018D53914C-0x000000018D539178 
		internal static Material roundedRectWithColorPerBorderMaterial { [FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")] get; } // 0x000000018D539178-0x000000018D5391A4 
		internal static int scrollTroughSide { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D5391A4-0x000000018D5391F4 0x000000018D539540-0x000000018D539594
		internal static System.DateTime nextScrollStepTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D5390FC-0x000000018D53914C 0x000000018D5394E8-0x000000018D539540
		public static GUISkin skin { get; set; } // 0x000000018D539244-0x000000018D53929C 0x000000018D539594-0x000000018D5395C8
		public static Matrix4x4 matrix { get; set; } // 0x000000018D5390B4-0x000000018D5390FC 0x000000018D5394B0-0x000000018D5394E8
		internal static GenericStack scrollViewStates { [CompilerGenerated] get; } // 0x000000018D5391F4-0x000000018D539244 
	
		// Nested types
		public delegate void WindowFunction(int id); // TypeDefIndex: 87999; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		static GUI(); // 0x000000018D538C20-0x000000018D538E84
	
		// Methods
		public static void GrabMouseControl(int id); // 0x000000018D536E88-0x000000018D536EBC
		public static bool HasMouseControl(int id); // 0x000000018D537A40-0x000000018D537A74
		public static void ReleaseMouseControl(); // 0x000000018D537FA8-0x000000018D537FD4
		internal static void InternalRepaintEditorWindow(); // 0x000000018D537C48-0x000000018D537C74
		private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout); // 0x000000018D537CD4-0x000000018D537D90
		public static void DragWindow(Rect position); // 0x000000018D535B3C-0x000000018D535B88
		internal static void DoSetSkin(GUISkin newSkin); // 0x000000018D5354D0-0x000000018D53554C
		public static void Label(Rect position, string text); // 0x000000018D537DFC-0x000000018D537EA0
		public static void Label(Rect position, string text, GUIStyle style); // 0x000000018D537D90-0x000000018D537DFC
		public static void Label(Rect position, GUIContent content, GUIStyle style); // 0x000000018D537EA0-0x000000018D537F00
		public static void DrawTexture(Rect position, Texture image); // 0x000000018D53658C-0x000000018D5365EC
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode); // 0x000000018D536514-0x000000018D53658C
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend); // 0x000000018D535B88-0x000000018D535C14
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect); // 0x000000018D536344-0x000000018D536408
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius); // 0x000000018D536408-0x000000018D536514
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius); // 0x000000018D535C14-0x000000018D535D1C
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses); // 0x000000018D53624C-0x000000018D536344
		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners); // 0x000000018D53613C-0x000000018D53624C
		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners); // 0x000000018D535D1C-0x000000018D53613C
		internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect); // 0x000000018D534A34-0x000000018D534BC8
		public static void Box(Rect position, string text); // 0x000000018D534790-0x000000018D534834
		public static void Box(Rect position, GUIContent content, GUIStyle style); // 0x000000018D5346A4-0x000000018D534790
		public static bool Button(Rect position, string text); // 0x000000018D534834-0x000000018D5348B0
		public static bool Button(Rect position, string text, GUIStyle style); // 0x000000018D5348B0-0x000000018D534944
		public static bool Button(Rect position, GUIContent content, GUIStyle style); // 0x000000018D534944-0x000000018D5349C8
		internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style); // 0x000000018D5349C8-0x000000018D534A34
		private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType); // 0x000000018D5352BC-0x000000018D5354D0
		public static string TextField(Rect position, string text); // 0x000000018D5386FC-0x000000018D5387DC
		internal static string PasswordFieldGetStrToShow(string password, char maskChar); // 0x000000018D537F00-0x000000018D537FA8
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style); // 0x000000018D53554C-0x000000018D5355F0
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText); // 0x000000018D535888-0x000000018D535940
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar); // 0x000000018D5355F0-0x000000018D535888
		private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor); // 0x000000018D5376D8-0x000000018D537A40
		private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor); // 0x000000018D537154-0x000000018D5376D8
		private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor); // 0x000000018D536EBC-0x000000018D537154
		public static bool Toggle(Rect position, bool value, string text); // 0x000000018D5387DC-0x000000018D538894
		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style); // 0x000000018D538894-0x000000018D53894C
		internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style); // 0x000000018D534E74-0x000000018D5350D4
		private static void DoLabel(Rect position, GUIContent content, GUIStyle style); // 0x000000018D5350D4-0x000000018D5352BC
		internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style); // 0x000000018D535940-0x000000018D535A14
		internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style); // 0x000000018D534DC4-0x000000018D534E74
		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null); // 0x000000018D5385A8-0x000000018D5386FC
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style); // 0x000000018D537A74-0x000000018D537C48
		internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style); // 0x000000018D537FD4-0x000000018D538190
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style); // 0x000000018D53894C-0x000000018D538B20
		internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz); // 0x000000018D538190-0x000000018D5385A8
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style); // 0x000000018D533BD4-0x000000018D533C60
		internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset); // 0x000000018D533A2C-0x000000018D533BD4
		public static void EndGroup(); // 0x000000018D5365EC-0x000000018D536604
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect); // 0x000000018D5345AC-0x000000018D5346A4
		internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background); // 0x000000018D533C60-0x000000018D5345AC
		public static void EndScrollView(); // 0x000000018D536604-0x000000018D536648
		public static void EndScrollView(bool handleScrollWheel); // 0x000000018D536648-0x000000018D536E88
		public static Rect Window(int id, Rect clientRect, WindowFunction func, string text); // 0x000000018D538B20-0x000000018D538C20
		private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout); // 0x000000018D535A14-0x000000018D535B08
		[RequiredByNativeCode]
		internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style); // 0x000000018D534BC8-0x000000018D534DC4
		private static void get_color_Injected(out Color ret); // 0x000000018D538F88-0x000000018D538FBC
		private static void set_color_Injected(ref Color value); // 0x000000018D53937C-0x000000018D5393B0
		private static void get_backgroundColor_Injected(out Color ret); // 0x000000018D538E84-0x000000018D538EB8
		private static void set_backgroundColor_Injected(ref Color value); // 0x000000018D5392C8-0x000000018D5392FC
		private static void get_contentColor_Injected(out Color ret); // 0x000000018D539008-0x000000018D53903C
		private static void set_contentColor_Injected(ref Color value); // 0x000000018D5393FC-0x000000018D539430
		private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret); // 0x000000018D537C74-0x000000018D537CD4
		private static void DragWindow_Injected(ref Rect position); // 0x000000018D535B08-0x000000018D535B3C
	}

	[NativeHeader("Modules/IMGUI/GUIClip.h")]
	[NativeHeader("Modules/IMGUI/GUIState.h")]
	internal sealed class GUIClip // TypeDefIndex: 88002
	{
		// Properties
		internal static Rect visibleRect { [FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")] get; } // 0x000000018D52967C-0x000000018D52969C 
	
		// Nested types
		internal struct ParentClipScope : IDisposable // TypeDefIndex: 88001
		{
			// Fields
			private bool m_Disposed; // 0x00
	
			// Constructors
			public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect); // 0x000000018D539958-0x000000018D539A44
	
			// Methods
			public void Dispose(); // 0x000000018D539948-0x000000018D539958
		}
	
		// Methods
		internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset); // 0x000000018D5294AC-0x000000018D5294D8
		internal static void Internal_Pop(); // 0x000000018D529340-0x000000018D52936C
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
		internal static int Internal_GetCount(); // 0x000000018D5292E8-0x000000018D529314
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.Unclip")]
		private static Vector2 Unclip_Vector2(Vector2 pos); // 0x000000018D52960C-0x000000018D529638
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.UnclipToWindow")]
		private static Vector2 UnclipToWindow_Vector2(Vector2 pos); // 0x000000018D52958C-0x000000018D5295B8
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.ClipToWindow")]
		private static Vector2 ClipToWindow_Vector2(Vector2 absolutePos); // 0x000000018D52924C-0x000000018D529278
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
		internal static Matrix4x4 GetMatrix(); // 0x000000018D5292BC-0x000000018D5292E8
		internal static void SetMatrix(Matrix4x4 m); // 0x000000018D529538-0x000000018D529548
		internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect); // 0x000000018D5293C0-0x000000018D529434
		internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect); // 0x000000018D529434-0x000000018D529448
		internal static void Internal_PopParentClip(); // 0x000000018D529314-0x000000018D529340
		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset); // 0x000000018D5294E0-0x000000018D529504
		internal static void Pop(); // 0x000000018D5294D8-0x000000018D5294E0
		public static Vector2 Unclip(Vector2 pos); // 0x000000018D529638-0x000000018D529648
		public static Vector2 UnclipToWindow(Vector2 pos); // 0x000000018D5295B8-0x000000018D5295C8
		public static Vector2 ClipToWindow(Vector2 absolutePos); // 0x000000018D529278-0x000000018D529288
		private static void get_visibleRect_Injected(out Rect ret); // 0x000000018D529648-0x000000018D52967C
		private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset); // 0x000000018D529448-0x000000018D5294AC
		private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret); // 0x000000018D5295C8-0x000000018D52960C
		private static void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret); // 0x000000018D529548-0x000000018D52958C
		private static void ClipToWindow_Vector2_Injected(ref Vector2 absolutePos, out Vector2 ret); // 0x000000018D529208-0x000000018D52924C
		private static void GetMatrix_Injected(out Matrix4x4 ret); // 0x000000018D529288-0x000000018D5292BC
		private static void SetMatrix_Injected(ref Matrix4x4 m); // 0x000000018D529504-0x000000018D529538
		private static void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect); // 0x000000018D52936C-0x000000018D5293C0
	}

	[Serializable]
	[NativeHeader("Modules/IMGUI/GUIContent.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public class GUIContent // TypeDefIndex: 88003
	{
		// Fields
		[SerializeField]
		private string m_Text; // 0x10
		[SerializeField]
		private Texture m_Image; // 0x18
		[SerializeField]
		private string m_Tooltip; // 0x20
		private static readonly GUIContent s_Text; // 0x00
		private static readonly GUIContent s_Image; // 0x08
		private static readonly GUIContent s_TextImage; // 0x10
		public static GUIContent none; // 0x18
	
		// Properties
		public string text { get; set; } // 0x0000000187249840-0x0000000187249850 0x0000000184FD2410-0x0000000184FD2420
		public Texture image { set; } // 0x0000000187835500-0x0000000187835510
		public string tooltip { get; set; } // 0x000000018725FED0-0x000000018725FEE0 0x0000000187835950-0x0000000187835960
		internal int hash { get; } // 0x000000018D529C20-0x000000018D529C44 
	
		// Constructors
		public GUIContent(); // 0x000000018D529B58-0x000000018D529BC0
		public GUIContent(string text); // 0x000000018D529BC0-0x000000018D529C20
		public GUIContent(string text, string tooltip); // 0x000000018D529A8C-0x000000018D529AAC
		public GUIContent(string text, Texture image, string tooltip); // 0x000000018D5299D4-0x000000018D529A8C
		public GUIContent(GUIContent src); // 0x000000018D529AAC-0x000000018D529B58
		static GUIContent(); // 0x000000018D529870-0x000000018D5299D4
	
		// Methods
		internal static GUIContent Temp(string t); // 0x000000018D5297C0-0x000000018D52984C
		internal static void ClearStaticCache(); // 0x000000018D52969C-0x000000018D5297C0
		public override string ToString(); // 0x000000018D52984C-0x000000018D529870
	}

	public enum ScaleMode // TypeDefIndex: 88004
	{
		StretchToFill = 0,
		ScaleAndCrop = 1,
		ScaleToFit = 2
	}

	public enum FocusType // TypeDefIndex: 88005
	{
		Native = 0,
		Keyboard = 1,
		Passive = 2
	}

	public class GUILayout // TypeDefIndex: 88006
	{
		// Methods
		public static void Label(string text, params GUILayoutOption[] options); // 0x000000018D52D940-0x000000018D52D9CC
		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options); // 0x000000018D52D9CC-0x000000018D52DA38
		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options); // 0x000000018D52D238-0x000000018D52D2E4
		public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options); // 0x000000018D52DC14-0x000000018D52DC94
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options); // 0x000000018D52DC94-0x000000018D52DCA4
		private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options); // 0x000000018D52D2E4-0x000000018D52D3A4
		public static void Space(float pixels); // 0x000000018D52DA38-0x000000018D52DC14
		public static void FlexibleSpace(); // 0x000000018D52D6B0-0x000000018D52D8B4
		public static void BeginHorizontal(params GUILayoutOption[] options); // 0x000000018D52CB54-0x000000018D52CBD8
		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options); // 0x000000018D52CBD8-0x000000018D52CD1C
		public static void EndHorizontal(); // 0x000000018D52D4C4-0x000000018D52D504
		public static void BeginVertical(params GUILayoutOption[] options); // 0x000000018D52D150-0x000000018D52D1D4
		public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options); // 0x000000018D52D1D4-0x000000018D52D238
		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options); // 0x000000018D52D00C-0x000000018D52D150
		public static void EndVertical(); // 0x000000018D52D570-0x000000018D52D5B0
		public static void BeginArea(Rect screenRect); // 0x000000018D52C93C-0x000000018D52C9CC
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style); // 0x000000018D52C9CC-0x000000018D52CB54
		public static void EndArea(); // 0x000000018D52D3A4-0x000000018D52D4C4
		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options); // 0x000000018D52CD1C-0x000000018D52CDE0
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options); // 0x000000018D52CDE0-0x000000018D52D00C
		public static void EndScrollView(); // 0x000000018D52D504-0x000000018D52D510
		internal static void EndScrollView(bool handleScrollWheel); // 0x000000018D52D510-0x000000018D52D570
		public static GUILayoutOption Width(float width); // 0x000000018D52DCA4-0x000000018D52DD30
		public static GUILayoutOption Height(float height); // 0x000000018D52D8B4-0x000000018D52D940
		public static GUILayoutOption ExpandWidth(bool expand); // 0x000000018D52D630-0x000000018D52D6B0
		public static GUILayoutOption ExpandHeight(bool expand); // 0x000000018D52D5B0-0x000000018D52D630
	}

	public sealed class GUILayoutOption // TypeDefIndex: 88008
	{
		// Fields
		internal Type type; // 0x10
		internal object value; // 0x18
	
		// Nested types
		internal enum Type // TypeDefIndex: 88007
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
		internal GUILayoutOption(Type type, object value); // 0x0000000185CF10D0-0x0000000185CF1300
	}

	[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
	public class GUILayoutUtility // TypeDefIndex: 88010
	{
		// Fields
		private static readonly Dictionary<int, LayoutCache> s_StoredLayouts; // 0x00
		private static readonly Dictionary<int, LayoutCache> s_StoredWindows; // 0x08
		internal static LayoutCache current; // 0x10
		internal static readonly Rect kDummyRect; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static int _unbalancedgroupscount_k__BackingField; // 0x28
		private static GUIStyle s_SpaceStyle; // 0x30
	
		// Properties
		internal static int unbalancedgroupscount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D52C898-0x000000018D52C8E8 0x000000018D52C8E8-0x000000018D52C93C
		internal static GUIStyle spaceStyle { get; } // 0x000000018D52C7A8-0x000000018D52C898 
	
		// Nested types
		[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
		internal sealed class LayoutCache // TypeDefIndex: 88009
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int _id_k__BackingField; // 0x10
			internal GUILayoutGroup topLevel; // 0x18
			internal GenericStack layoutGroups; // 0x20
			internal GUILayoutGroup windows; // 0x28
	
			// Properties
			private int id { [CompilerGenerated] set; } // 0x0000000182234E90-0x0000000182234EA0
	
			// Constructors
			internal LayoutCache(int instanceID = -1 /* Metadata: 0x02647EF4 */); // 0x000000018D539858-0x000000018D539948
	
			// Methods
			public void ResetCursor(); // 0x000000018D5395C8-0x000000018D539858
		}
	
		// Constructors
		static GUILayoutUtility(); // 0x000000018D52C654-0x000000018D52C7A8
	
		// Methods
		private static Rect Internal_GetWindowRect(int windowID); // 0x000000018D52BB64-0x000000018D52BBBC
		private static void Internal_MoveWindow(int windowID, Rect r); // 0x000000018D52BBFC-0x000000018D52BC54
		internal static LayoutCache SelectIDList(int instanceID, bool isWindow); // 0x000000018D52C4D8-0x000000018D52C654
		internal static void Begin(int instanceID); // 0x000000018D52AFA8-0x000000018D52B1E8
		internal static void BeginContainer(LayoutCache cache); // 0x000000018D52A644-0x000000018D52A7D0
		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options); // 0x000000018D52ACA0-0x000000018D52AFA8
		internal static void Layout(); // 0x000000018D52C2BC-0x000000018D52C4D8
		internal static void LayoutFromEditorWindow(); // 0x000000018D52BF64-0x000000018D52C128
		internal static void LayoutFromContainer(float w, float h); // 0x000000018D52BDCC-0x000000018D52BF64
		internal static void LayoutFreeGroup(GUILayoutGroup toplevel); // 0x000000018D52BC54-0x000000018D52BDCC
		private static void LayoutSingleGroup(GUILayoutGroup i); // 0x000000018D52C128-0x000000018D52C2BC
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType); // 0x000000018D52B1E8-0x000000018D52B2EC
		internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, System.Type layoutType); // 0x000000018D52AA14-0x000000018D52ACA0
		internal static void EndLayoutGroup(); // 0x000000018D52B76C-0x000000018D52B938
		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, System.Type layoutType); // 0x000000018D52A7D0-0x000000018D52AA14
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options); // 0x000000018D52BA98-0x000000018D52BB24
		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options); // 0x000000018D52B490-0x000000018D52B76C
		public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options); // 0x000000018D52B9F4-0x000000018D52BA98
		private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options); // 0x000000018D52B2EC-0x000000018D52B490
		public static Rect GetLastRect(); // 0x000000018D52B938-0x000000018D52B9F4
		private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret); // 0x000000018D52BB24-0x000000018D52BB64
		private static void Internal_MoveWindow_Injected(int windowID, ref Rect r); // 0x000000018D52BBBC-0x000000018D52BBFC
	}

	[Serializable]
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	public sealed class GUISettings // TypeDefIndex: 88011
	{
		// Fields
		[SerializeField]
		private bool m_DoubleClickSelectsWord; // 0x10
		[SerializeField]
		private bool m_TripleClickSelectsLine; // 0x11
		[SerializeField]
		private Color m_CursorColor; // 0x14
		[SerializeField]
		private float m_CursorFlashSpeed; // 0x24
		[SerializeField]
		private Color m_SelectionColor; // 0x28
	
		// Properties
		public bool doubleClickSelectsWord { get; } // 0x0000000187261E70-0x0000000187261E80 
		public bool tripleClickSelectsLine { get; } // 0x0000000187261E90-0x0000000187261EA0 
		public Color cursorColor { get; } // 0x0000000187243910-0x0000000187243920 
		public float cursorFlashSpeed { get; } // 0x000000018D52DD94-0x000000018D52DDB4 
		public Color selectionColor { get; } // 0x0000000187261E80-0x0000000187261E90 
	
		// Constructors
		public GUISettings(); // 0x000000018D52DD5C-0x000000018D52DD94
	
		// Methods
		private static float Internal_GetCursorFlashSpeed(); // 0x000000018D52DD30-0x000000018D52DD5C
	}

	[Serializable]
	[AssetFileNameExtension("guiskin", new string[0])]
	[ExecuteInEditMode]
	[RequiredByNativeCode]
	public sealed class GUISkin : ScriptableObject // TypeDefIndex: 88013
	{
		// Fields
		[SerializeField]
		private Font m_Font; // 0x18
		[SerializeField]
		private GUIStyle m_box; // 0x20
		[SerializeField]
		private GUIStyle m_button; // 0x28
		[SerializeField]
		private GUIStyle m_toggle; // 0x30
		[SerializeField]
		private GUIStyle m_label; // 0x38
		[SerializeField]
		private GUIStyle m_textField; // 0x40
		[SerializeField]
		private GUIStyle m_textArea; // 0x48
		[SerializeField]
		private GUIStyle m_window; // 0x50
		[SerializeField]
		private GUIStyle m_horizontalSlider; // 0x58
		[SerializeField]
		private GUIStyle m_horizontalSliderThumb; // 0x60
		[NonSerialized]
		private GUIStyle m_horizontalSliderThumbExtent; // 0x68
		[SerializeField]
		private GUIStyle m_verticalSlider; // 0x70
		[SerializeField]
		private GUIStyle m_verticalSliderThumb; // 0x78
		[NonSerialized]
		private GUIStyle m_verticalSliderThumbExtent; // 0x80
		[NonSerialized]
		private GUIStyle m_SliderMixed; // 0x88
		[SerializeField]
		private GUIStyle m_horizontalScrollbar; // 0x90
		[SerializeField]
		private GUIStyle m_horizontalScrollbarThumb; // 0x98
		[SerializeField]
		private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
		[SerializeField]
		private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
		[SerializeField]
		private GUIStyle m_verticalScrollbar; // 0xB0
		[SerializeField]
		private GUIStyle m_verticalScrollbarThumb; // 0xB8
		[SerializeField]
		private GUIStyle m_verticalScrollbarUpButton; // 0xC0
		[SerializeField]
		private GUIStyle m_verticalScrollbarDownButton; // 0xC8
		[SerializeField]
		private GUIStyle m_ScrollView; // 0xD0
		[SerializeField]
		internal GUIStyle[] m_CustomStyles; // 0xD8
		[SerializeField]
		private GUISettings m_Settings; // 0xE0
		internal static GUIStyle ms_Error; // 0x00
		private Dictionary<string, GUIStyle> m_Styles; // 0xE8
		internal static SkinChangedDelegate m_SkinChanged; // 0x08
		internal static GUISkin current; // 0x10
	
		// Properties
		public Font font { get; set; } // 0x0000000187244530-0x0000000187244540 0x000000018D52F2E8-0x000000018D52F398
		public GUIStyle box { get; set; } // 0x000000018725FED0-0x000000018725FEE0 0x000000018D52F278-0x000000018D52F29C
		public GUIStyle label { get; set; } // 0x00000001872615B0-0x00000001872615C0 0x000000018D52F4A4-0x000000018D52F4C8
		public GUIStyle textField { get; set; } // 0x0000000187261E60-0x0000000187261E70 0x000000018D52F53C-0x000000018D52F560
		public GUIStyle textArea { get; set; } // 0x0000000187261F50-0x0000000187261F60 0x000000018D52F518-0x000000018D52F53C
		public GUIStyle button { get; set; } // 0x0000000187261370-0x0000000187261380 0x000000018D52F29C-0x000000018D52F2C0
		public GUIStyle toggle { get; set; } // 0x00000001872613B0-0x00000001872613C0 0x000000018D52F560-0x000000018D52F584
		public GUIStyle window { get; set; } // 0x0000000187261FD0-0x0000000187261FE0 0x000000018D52F694-0x000000018D52F6B8
		public GUIStyle horizontalSlider { get; set; } // 0x0000000187261F10-0x0000000187261F20 0x000000018D52F480-0x000000018D52F4A4
		public GUIStyle horizontalSliderThumb { get; set; } // 0x0000000187261F00-0x0000000187261F10 0x000000018D52F45C-0x000000018D52F480
		internal GUIStyle horizontalSliderThumbExtent { get; set; } // 0x0000000187261EF0-0x0000000187261F00 0x000000018D52F438-0x000000018D52F45C
		internal GUIStyle sliderMixed { get; set; } // 0x0000000187261F40-0x0000000187261F50 0x000000018D52F4F0-0x000000018D52F518
		public GUIStyle verticalSlider { get; set; } // 0x0000000187261FC0-0x0000000187261FD0 0x000000018D52F670-0x000000018D52F694
		public GUIStyle verticalSliderThumb { get; set; } // 0x0000000187261FB0-0x0000000187261FC0 0x000000018D52F64C-0x000000018D52F670
		internal GUIStyle verticalSliderThumbExtent { get; set; } // 0x0000000187261FA0-0x0000000187261FB0 0x000000018D52F624-0x000000018D52F64C
		public GUIStyle horizontalScrollbar { get; set; } // 0x0000000187261EE0-0x0000000187261EF0 0x000000018D52F410-0x000000018D52F438
		public GUIStyle horizontalScrollbarThumb { get; set; } // 0x0000000187261ED0-0x0000000187261EE0 0x000000018D52F3E8-0x000000018D52F410
		public GUIStyle horizontalScrollbarLeftButton { get; set; } // 0x0000000187261EB0-0x0000000187261EC0 0x000000018D52F398-0x000000018D52F3C0
		public GUIStyle horizontalScrollbarRightButton { get; set; } // 0x0000000187261EC0-0x0000000187261ED0 0x000000018D52F3C0-0x000000018D52F3E8
		public GUIStyle verticalScrollbar { get; set; } // 0x0000000187261F90-0x0000000187261FA0 0x000000018D52F5FC-0x000000018D52F624
		public GUIStyle verticalScrollbarThumb { get; set; } // 0x0000000187261F70-0x0000000187261F80 0x000000018D52F5AC-0x000000018D52F5D4
		public GUIStyle verticalScrollbarUpButton { get; set; } // 0x0000000187261F80-0x0000000187261F90 0x000000018D52F5D4-0x000000018D52F5FC
		public GUIStyle verticalScrollbarDownButton { get; set; } // 0x0000000187261F60-0x0000000187261F70 0x000000018D52F584-0x000000018D52F5AC
		public GUIStyle scrollView { get; set; } // 0x0000000187261F20-0x0000000187261F30 0x000000018D52F4C8-0x000000018D52F4F0
		public GUIStyle[] customStyles { get; set; } // 0x0000000187261EA0-0x0000000187261EB0 0x000000018D52F2C0-0x000000018D52F2E8
		public GUISettings settings { get; } // 0x0000000187261F30-0x0000000187261F40 
		internal static GUIStyle error { get; } // 0x000000018D52F1A4-0x000000018D52F278 
	
		// Nested types
		internal delegate void SkinChangedDelegate(); // TypeDefIndex: 88012; 0x0000000185B44B70-0x0000000185B44B80
	
		// Constructors
		public GUISkin(); // 0x000000018D52F0E8-0x000000018D52F1A4
	
		// Methods
		internal void OnEnable(); // 0x000000018D52F0E0-0x000000018D52F0E8
		internal static void CleanupRoots(); // 0x000000018D52ECFC-0x000000018D52ED78
		internal void Apply(); // 0x000000018D52DDB4-0x000000018D52DE18
		private void BuildStyleCache(); // 0x000000018D52DE18-0x000000018D52ECFC
		public GUIStyle GetStyle(string styleName); // 0x000000018D52EEB4-0x000000018D52F064
		public GUIStyle FindStyle(string styleName); // 0x000000018D52ED78-0x000000018D52EDFC
		internal void MakeCurrent(); // 0x000000018D52F064-0x000000018D52F0E0
		public IEnumerator GetEnumerator(); // 0x000000018D52EDFC-0x000000018D52EEB4
	}

	internal class GUIStateObjects // TypeDefIndex: 88014
	{
		// Fields
		private static Dictionary<int, object> s_StateCache; // 0x00
	
		// Constructors
		static GUIStateObjects(); // 0x000000018D52F84C-0x000000018D52F8D8
	
		// Methods
		internal static object GetStateObject(System.Type t, int controlID); // 0x000000018D52F6B8-0x000000018D52F7B4
		internal static object QueryStateObject(System.Type t, int controlID); // 0x000000018D52F7B4-0x000000018D52F84C
	}

	[Serializable]
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	public sealed class GUIStyleState // TypeDefIndex: 88015
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private readonly GUIStyle m_SourceStyle; // 0x18
	
		// Properties
		[NativeProperty("Background", false, UnityEngine.Bindings.TargetType.Function)]
		public Texture2D background { get; set; } // 0x000000018D52FA4C-0x000000018D52FA80 0x000000018D52FAF0-0x000000018D52FB34
		[NativeProperty("textColor", false, UnityEngine.Bindings.TargetType.Field)]
		public Color textColor { get; set; } // 0x000000018D52FAC4-0x000000018D52FAF0 0x000000018D52FB78-0x000000018D52FB8C
	
		// Constructors
		public GUIStyleState(); // 0x000000018D52FA30-0x000000018D52FA4C
		private GUIStyleState(GUIStyle sourceStyle, IntPtr source); // 0x000000018D4E15EC-0x000000018D4E160C
	
		// Methods
		[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = true)]
		private static IntPtr Init(); // 0x000000018D52FA04-0x000000018D52FA30
		[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		private void Cleanup(); // 0x000000018D52F8D8-0x000000018D52F90C
		internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source); // 0x000000018D52F994-0x000000018D52FA04
		~GUIStyleState(); // 0x000000018D52F90C-0x000000018D52F994
		private void get_textColor_Injected(out Color ret); // 0x000000018D52FA80-0x000000018D52FAC4
		private void set_textColor_Injected(ref Color value); // 0x000000018D52FB34-0x000000018D52FB78
	}

	[Serializable]
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[NativeHeader("IMGUIScriptingClasses.h")]
	[RequiredByNativeCode]
	public sealed class GUIStyle // TypeDefIndex: 88016
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
		[NativeProperty("Name", false, UnityEngine.Bindings.TargetType.Function)]
		internal string rawName { get; set; } // 0x000000018D5317C8-0x000000018D5317FC 0x000000018D531D74-0x000000018D531DB8
		[NativeProperty("Font", false, UnityEngine.Bindings.TargetType.Function)]
		public Font font { get; set; } // 0x000000018D5312A0-0x000000018D5312D4 0x000000018D531B80-0x000000018D531BC4
		[NativeProperty("m_ImagePosition", false, UnityEngine.Bindings.TargetType.Field)]
		public ImagePosition imagePosition { get; set; } // 0x000000018D53131C-0x000000018D531350 0x000000018D531BE8-0x000000018D531C28
		[NativeProperty("m_Alignment", false, UnityEngine.Bindings.TargetType.Field)]
		public TextAnchor alignment { get; set; } // 0x000000018D531024-0x000000018D531058 0x000000018D531950-0x000000018D531990
		[NativeProperty("m_WordWrap", false, UnityEngine.Bindings.TargetType.Field)]
		public bool wordWrap { get; set; } // 0x000000018D531898-0x000000018D5318CC 0x000000018D531E84-0x000000018D531EC8
		[NativeProperty("m_Clipping", false, UnityEngine.Bindings.TargetType.Field)]
		public TextClipping clipping { get; set; } // 0x000000018D5310EC-0x000000018D531120 0x000000018D5319B4-0x000000018D5319F4
		[NativeProperty("m_ContentOffset", false, UnityEngine.Bindings.TargetType.Field)]
		public Vector2 contentOffset { get; set; } // 0x000000018D531164-0x000000018D531188 0x000000018D531A38-0x000000018D531A54
		[NativeProperty("m_FixedWidth", false, UnityEngine.Bindings.TargetType.Field)]
		public float fixedWidth { get; set; } // 0x000000018D5311BC-0x000000018D5311F0 0x000000018D531A98-0x000000018D531ADC
		[NativeProperty("m_FixedHeight", false, UnityEngine.Bindings.TargetType.Field)]
		public float fixedHeight { get; set; } // 0x000000018D531188-0x000000018D5311BC 0x000000018D531A54-0x000000018D531A98
		[NativeProperty("m_StretchWidth", false, UnityEngine.Bindings.TargetType.Field)]
		public bool stretchWidth { get; set; } // 0x000000018D531864-0x000000018D531898 0x000000018D531E40-0x000000018D531E84
		[NativeProperty("m_StretchHeight", false, UnityEngine.Bindings.TargetType.Field)]
		public bool stretchHeight { get; set; } // 0x000000018D531830-0x000000018D531864 0x000000018D531DFC-0x000000018D531E40
		[NativeProperty("m_FontSize", false, UnityEngine.Bindings.TargetType.Field)]
		public int fontSize { get; set; } // 0x000000018D531238-0x000000018D53126C 0x000000018D531B00-0x000000018D531B40
		[NativeProperty("m_FontStyle", false, UnityEngine.Bindings.TargetType.Field)]
		public FontStyle fontStyle { get; set; } // 0x000000018D53126C-0x000000018D5312A0 0x000000018D531B40-0x000000018D531B80
		[NativeProperty("m_RichText", false, UnityEngine.Bindings.TargetType.Field)]
		public bool richText { get; set; } // 0x000000018D5317FC-0x000000018D531830 0x000000018D531DB8-0x000000018D531DFC
		[NativeProperty("m_ClipOffset", false, UnityEngine.Bindings.TargetType.Field)]
		internal Vector2 Internal_clipOffset { set; } // 0x000000018D531910-0x000000018D53192C
		public string name { get; set; } // 0x000000018D531488-0x000000018D5314BC 0x000000018D531C4C-0x000000018D531C78
		public GUIStyleState normal { get; set; } // 0x000000018D53155C-0x000000018D5315A0 0x000000018D531C78-0x000000018D531C9C
		public GUIStyleState hover { get; set; } // 0x000000018D5312D4-0x000000018D53131C 0x000000018D531BC4-0x000000018D531BE8
		public GUIStyleState active { get; set; } // 0x000000018D530FDC-0x000000018D531024 0x000000018D53192C-0x000000018D531950
		public GUIStyleState onNormal { get; set; } // 0x000000018D531678-0x000000018D5316C0 0x000000018D531D08-0x000000018D531D2C
		public GUIStyleState onHover { get; set; } // 0x000000018D531630-0x000000018D531678 0x000000018D531CE4-0x000000018D531D08
		public GUIStyleState onActive { get; set; } // 0x000000018D5315A0-0x000000018D5315E8 0x000000018D531C9C-0x000000018D531CC0
		public GUIStyleState focused { get; set; } // 0x000000018D5311F0-0x000000018D531238 0x000000018D531ADC-0x000000018D531B00
		public GUIStyleState onFocused { get; set; } // 0x000000018D5315E8-0x000000018D531630 0x000000018D531CC0-0x000000018D531CE4
		public RectOffset border { get; set; } // 0x000000018D531058-0x000000018D5310EC 0x000000018D531990-0x000000018D5319B4
		public RectOffset margin { get; set; } // 0x000000018D5313F4-0x000000018D531488 0x000000018D531C28-0x000000018D531C4C
		public RectOffset padding { get; set; } // 0x000000018D531754-0x000000018D5317C8 0x000000018D531D50-0x000000018D531D74
		public RectOffset overflow { get; set; } // 0x000000018D5316C0-0x000000018D531754 0x000000018D531D2C-0x000000018D531D50
		public float lineHeight { get; } // 0x000000018D5313A0-0x000000018D5313F4 
		public static GUIStyle none { get; } // 0x000000018D5314BC-0x000000018D53155C 
		public bool isHeightDependantOnWidth { get; } // 0x000000018D531350-0x000000018D5313A0 
	
		// Constructors
		public GUIStyle(); // 0x000000018D530F8C-0x000000018D530FDC
		public GUIStyle(GUIStyle other); // 0x000000018D530EF4-0x000000018D530F8C
		static GUIStyle(); // 0x000000018D530EBC-0x000000018D530EF4
	
		// Methods
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = true)]
		private static IntPtr Internal_Create(GUIStyle self); // 0x000000018D530834-0x000000018D530868
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = true)]
		private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other); // 0x000000018D5307F0-0x000000018D530834
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr self); // 0x000000018D530868-0x000000018D53089C
		[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = true, HasExplicitThis = true)]
		private IntPtr GetStyleStatePtr(int idx); // 0x000000018D5305D8-0x000000018D530618
		[FreeFunction(Name = "GUIStyle_Bindings::AssignStyleState", HasExplicitThis = true)]
		private void AssignStyleState(int idx, IntPtr srcStyleState); // 0x000000018D52FBDC-0x000000018D52FC2C
		[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = true)]
		private IntPtr GetRectOffsetPtr(int idx); // 0x000000018D530598-0x000000018D5305D8
		[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = true)]
		private void AssignRectOffset(int idx, IntPtr srcRectOffset); // 0x000000018D52FB8C-0x000000018D52FBDC
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetLineHeight")]
		private static float Internal_GetLineHeight(IntPtr target); // 0x000000018D530C64-0x000000018D530C98
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = true)]
		private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus); // 0x000000018D530AE8-0x000000018D530B20
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = true)]
		private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on); // 0x000000018D530900-0x000000018D530920
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = true)]
		private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor); // 0x000000018D530984-0x000000018D5309A8
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = true)]
		private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor); // 0x000000018D530A10-0x000000018D530A84
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorPixelPosition", HasExplicitThis = true)]
		internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex); // 0x000000018D530BB0-0x000000018D530BDC
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorStringIndex", HasExplicitThis = true)]
		internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition); // 0x000000018D530C40-0x000000018D530C64
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetSelectedRenderedText", HasExplicitThis = true)]
		internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex); // 0x000000018D530CFC-0x000000018D530D1C
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSize(GUIContent content); // 0x000000018D5307CC-0x000000018D5307F0
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize); // 0x000000018D530748-0x000000018D530778
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = true)]
		private float Internal_CalcHeight(GUIContent content, float width); // 0x000000018D530618-0x000000018D53066C
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = true)]
		private Vector2 Internal_CalcMinMaxWidth(GUIContent content); // 0x000000018D5306C0-0x000000018D5306E4
		[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
		internal static void SetMouseTooltip(string tooltip, Rect screenRect); // 0x000000018D530DC8-0x000000018D530E24
		[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
		internal static bool IsTooltipActive(string tooltip); // 0x000000018D530D1C-0x000000018D530D50
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
		private static float Internal_GetCursorFlashOffset(); // 0x000000018D530B20-0x000000018D530B4C
		[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
		internal static void SetDefaultFont(Font font); // 0x000000018D530D50-0x000000018D530D84
		~GUIStyle(); // 0x000000018D530494-0x000000018D530550
		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus); // 0x000000018D530310-0x000000018D5303C4
		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus); // 0x000000018D5302BC-0x000000018D530310
		public void Draw(Rect position, GUIContent content, int controlID); // 0x000000018D5303C4-0x000000018D5303F8
		public void Draw(Rect position, GUIContent content, int controlID, bool on); // 0x000000018D53020C-0x000000018D53024C
		public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover); // 0x000000018D5303F8-0x000000018D530494
		private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus); // 0x000000018D53024C-0x000000018D5302BC
		public void DrawCursor(Rect position, GUIContent content, int controlID, int character); // 0x000000018D52FC9C-0x000000018D52FE64
		internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor); // 0x000000018D52FE64-0x000000018D53007C
		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition); // 0x000000018D5300BC-0x000000018D53020C
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter); // 0x000000018D53007C-0x000000018D5300BC
		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex); // 0x000000018D530550-0x000000018D530574
		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition); // 0x000000018D530574-0x000000018D530598
		public Vector2 CalcSize(GUIContent content); // 0x000000018D52FC88-0x000000018D52FC9C
		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints); // 0x000000018D52FC74-0x000000018D52FC88
		public float CalcHeight(GUIContent content, float width); // 0x000000018D52FC2C-0x000000018D52FC38
		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth); // 0x000000018D52FC38-0x000000018D52FC74
		public override string ToString(); // 0x000000018D530E24-0x000000018D530EBC
		private void get_contentOffset_Injected(out Vector2 ret); // 0x000000018D531120-0x000000018D531164
		private void set_contentOffset_Injected(ref Vector2 value); // 0x000000018D5319F4-0x000000018D531A38
		private void set_Internal_clipOffset_Injected(ref Vector2 value); // 0x000000018D5318CC-0x000000018D531910
		private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus); // 0x000000018D530A84-0x000000018D530AE8
		private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on); // 0x000000018D53089C-0x000000018D530900
		private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor); // 0x000000018D530920-0x000000018D530984
		private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor); // 0x000000018D5309A8-0x000000018D530A10
		private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret); // 0x000000018D530B4C-0x000000018D530BB0
		private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition); // 0x000000018D530BDC-0x000000018D530C40
		private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex); // 0x000000018D530C98-0x000000018D530CFC
		private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret); // 0x000000018D530778-0x000000018D5307CC
		private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret); // 0x000000018D5306E4-0x000000018D530748
		private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret); // 0x000000018D53066C-0x000000018D5306C0
		private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect); // 0x000000018D530D84-0x000000018D530DC8
	}

	public enum ImagePosition // TypeDefIndex: 88017
	{
		ImageLeft = 0,
		ImageAbove = 1,
		ImageOnly = 2,
		TextOnly = 3
	}

	public enum TextClipping // TypeDefIndex: 88018
	{
		Overflow = 0,
		Clip = 1
	}

	[AttributeUsage(AttributeTargets.Method)]
	public class GUITargetAttribute : Attribute // TypeDefIndex: 88019
	{
		// Fields
		internal int displayMask; // 0x10
	
		// Methods
		[RequiredByNativeCode]
		private static int GetGUITargetAttrValue(System.Type klass, string methodName); // 0x000000018D531EC8-0x000000018D531FF8
	}

	[NativeHeader("Modules/IMGUI/GUIUtility.h")]
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Runtime/Input/InputBindings.h")]
	[NativeHeader("Runtime/Utilities/CopyPaste.h")]
	[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
	[NativeHeader("Modules/IMGUI/GUIManager.h")]
	public class GUIUtility // TypeDefIndex: 88020
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static bool _guiIsExiting_k__BackingField; // 0x40
		internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x48
	
		// Properties
		public static bool hasModalWindow { get; } // 0x000000018D5336CC-0x000000018D5336F8 
		[NativeProperty("GetGUIState().m_PixelsPerPoint", true, UnityEngine.Bindings.TargetType.Field)]
		internal static float pixelsPerPoint { get; } // 0x000000018D533794-0x000000018D5337C0 
		[NativeProperty("GetGUIState().m_OnGUIDepth", true, UnityEngine.Bindings.TargetType.Field)]
		internal static int guiDepth { get; } // 0x000000018D533668-0x000000018D533694 
		internal static Vector2 s_EditorScreenPointOffset { [NativeMethod("GetGUIState().GetGUIPixelOffset", true)] get; [NativeMethod("GetGUIState().SetGUIPixelOffset", true)] set; } // 0x000000018D5337F4-0x000000018D533818 0x000000018D5339DC-0x000000018D5339F8
		[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", true, UnityEngine.Bindings.TargetType.Field)]
		internal static bool mouseUsed { get; set; } // 0x000000018D533768-0x000000018D533794 0x000000018D533974-0x000000018D5339A8
		[StaticAccessor("GetInputManager()", StaticAccessorType.Dot)]
		internal static bool textFieldInput { get; set; } // 0x000000018D533844-0x000000018D533870 0x000000018D5339F8-0x000000018D533A2C
		internal static bool manualTex2SRGBEnabled { [FreeFunction("GUITexture::IsManualTex2SRGBEnabled")] get; [FreeFunction("GUITexture::SetManualTex2SRGBEnabled")] set; } // 0x000000018D53373C-0x000000018D533768 0x000000018D533940-0x000000018D533974
		public static string systemCopyBuffer { [FreeFunction("GetCopyBuffer")] get; [FreeFunction("SetCopyBuffer")] set; } // 0x000000018D533818-0x000000018D533844 0x0000000186215010-0x0000000186215050
		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static string compositionString { get; } // 0x000000018D53363C-0x000000018D533668 
		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static IMECompositionMode imeCompositionMode { get; set; } // 0x000000018D533704-0x000000018D533730 0x000000018D533904-0x000000018D533938
		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static Vector2 compositionCursorPos { get; set; } // 0x000000018D533618-0x000000018D53363C 0x000000018D5338A4-0x000000018D5338C0
		internal static bool guiIsExiting { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D533694-0x000000018D5336CC 0x000000018D5338C0-0x000000018D5338FC
		public static int hotControl { get; set; } // 0x000000018D5336F8-0x000000018D533704 0x000000018D5338FC-0x000000018D533904
		public static int keyboardControl { get; set; } // 0x000000018D533730-0x000000018D53373C 0x000000018D533938-0x000000018D533940
	
		// Constructors
		public GUIUtility(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[FreeFunction("GetGUIState().GetControlID")]
		private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect); // 0x000000018D532AB0-0x000000018D532AC4
		public static int GetControlID(int hint, FocusType focusType, Rect rect); // 0x000000018D5325B4-0x000000018D5325EC
		internal static void BeginContainerFromOwner(ScriptableObject owner); // 0x000000018D5320E8-0x000000018D53211C
		internal static void BeginContainer(ObjectGUIState objectGUIState); // 0x000000018D53211C-0x000000018D532150
		[NativeMethod("EndContainer")]
		internal static void Internal_EndContainer(); // 0x000000018D5329D4-0x000000018D532A00
		[FreeFunction("GetSpecificGUIState(0).m_EternalGUIState->GetNextUniqueID")]
		internal static int GetPermanentControlID(); // 0x000000018D5326FC-0x000000018D532728
		internal static int CheckForTabEvent(Event evt); // 0x000000018D5321B0-0x000000018D5321E4
		internal static void SetKeyboardControlToFirstControlId(); // 0x000000018D53353C-0x000000018D533568
		internal static void SetKeyboardControlToLastControlId(); // 0x000000018D533568-0x000000018D533594
		internal static bool HasFocusableControls(); // 0x000000018D532780-0x000000018D5327AC
		internal static bool OwnsId(int id); // 0x000000018D532CF4-0x000000018D532D28
		public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels); // 0x000000018D53205C-0x000000018D532098
		internal static Vector3 Internal_MultiplyPoint(Vector3 point, Matrix4x4 transform); // 0x000000018D532BA4-0x000000018D532BD8
		internal static bool GetChanged(); // 0x000000018D532544-0x000000018D532570
		internal static void SetChanged(bool changed); // 0x000000018D5334D4-0x000000018D533508
		internal static void SetDidGUIWindowsEatLastEvent(bool value); // 0x000000018D533508-0x000000018D53353C
		private static int Internal_GetHotControl(); // 0x000000018D532AF8-0x000000018D532B24
		private static int Internal_GetKeyboardControl(); // 0x000000018D532B24-0x000000018D532B50
		private static void Internal_SetHotControl(int value); // 0x000000018D532BD8-0x000000018D532C0C
		private static void Internal_SetKeyboardControl(int value); // 0x000000018D532C0C-0x000000018D532C40
		private static object Internal_GetDefaultSkin(int skinMode); // 0x000000018D532AC4-0x000000018D532AF8
		private static Object Internal_GetBuiltinSkin(int skin); // 0x000000018D532A2C-0x000000018D532A60
		private static void Internal_ExitGUI(); // 0x000000018D532A00-0x000000018D532A2C
		private static Vector2 InternalWindowToScreenPoint(Vector2 windowPoint); // 0x000000018D5329A8-0x000000018D5329D4
		private static Vector2 InternalScreenToWindowPoint(Vector2 screenPoint); // 0x000000018D532938-0x000000018D532964
		[RequiredByNativeCode]
		private static void MarkGUIChanged(); // 0x000000018D532CB0-0x000000018D532CF4
		public static int GetControlID(FocusType focus); // 0x000000018D5325EC-0x000000018D5325FC
		public static int GetControlID(GUIContent contents, FocusType focus); // 0x000000018D5325FC-0x000000018D532628
		public static int GetControlID(FocusType focus, Rect position); // 0x000000018D532570-0x000000018D532594
		public static int GetControlID(GUIContent contents, FocusType focus, Rect position); // 0x000000018D532628-0x000000018D532670
		public static int GetControlID(int hint, FocusType focus); // 0x000000018D532594-0x000000018D5325B4
		public static object GetStateObject(System.Type t, int controlID); // 0x000000018D532728-0x000000018D532780
		public static object QueryStateObject(System.Type t, int controlID); // 0x000000018D532D9C-0x000000018D532DF4
		[RequiredByNativeCode]
		internal static void TakeCapture(); // 0x000000018D5335A0-0x000000018D5335E4
		[RequiredByNativeCode]
		internal static void RemoveCapture(); // 0x000000018D532DF4-0x000000018D532E38
		internal static bool HasKeyFocus(int controlID); // 0x000000018D5327AC-0x000000018D5327F0
		public static void ExitGUI(); // 0x000000018D53242C-0x000000018D532478
		internal static GUISkin GetDefaultSkin(int skinMode); // 0x000000018D532670-0x000000018D5326C0
		internal static GUISkin GetDefaultSkin(); // 0x000000018D5326C0-0x000000018D5326FC
		internal static GUISkin GetBuiltinSkin(int skin); // 0x000000018D5324F4-0x000000018D532544
		[RequiredByNativeCode]
		internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result); // 0x000000018D532D28-0x000000018D532D9C
		internal static void EndContainer(); // 0x000000018D5322F0-0x000000018D532308
		internal static void CleanupRoots(); // 0x000000018D532250-0x000000018D532294
		[RequiredByNativeCode]
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout); // 0x000000018D532150-0x000000018D5321B0
		[RequiredByNativeCode]
		internal static void EndGUI(int layoutType); // 0x000000018D532328-0x000000018D53242C
		[RequiredByNativeCode]
		internal static bool EndGUIFromException(Exception exception); // 0x000000018D532308-0x000000018D532328
		[RequiredByNativeCode]
		internal static bool EndContainerGUIFromException(Exception exception); // 0x000000018D532294-0x000000018D5322F0
		internal static void ResetGlobalState(); // 0x000000018D532E38-0x000000018D532E80
		internal static bool IsExitGUIException(Exception exception); // 0x000000018D532C40-0x000000018D532CB0
		internal static bool ShouldRethrowException(Exception exception); // 0x000000018D533594-0x000000018D5335A0
		internal static void CheckOnGUI(); // 0x000000018D5321E4-0x000000018D532250
		internal static float RoundToPixelGrid(float v); // 0x000000018D53316C-0x000000018D5331AC
		public static Vector2 GUIToScreenPoint(Vector2 guiPoint); // 0x000000018D532478-0x000000018D532494
		public static Rect GUIToScreenRect(Rect guiRect); // 0x000000018D532494-0x000000018D5324F4
		public static Vector2 ScreenToGUIPoint(Vector2 screenPoint); // 0x000000018D533458-0x000000018D533474
		public static Rect ScreenToGUIRect(Rect screenRect); // 0x000000018D533474-0x000000018D5334D4
		public static void RotateAroundPivot(float angle, Vector2 pivotPoint); // 0x000000018D532E80-0x000000018D53316C
		public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint); // 0x000000018D5331AC-0x000000018D533458
		public static Rect AlignRectToDevice(Rect rect); // 0x000000018D532098-0x000000018D5320E8
		public static bool HitTest(Rect rect, Vector2 point, int offset); // 0x000000018D532858-0x000000018D5328D0
		public static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice); // 0x000000018D5328D0-0x000000018D5328F4
		public static bool HitTest(Rect rect, Event evt); // 0x000000018D5327F0-0x000000018D532858
		private static void get_s_EditorScreenPointOffset_Injected(out Vector2 ret); // 0x000000018D5337C0-0x000000018D5337F4
		private static void set_s_EditorScreenPointOffset_Injected(ref Vector2 value); // 0x000000018D5339A8-0x000000018D5339DC
		private static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect); // 0x000000018D532A60-0x000000018D532AB0
		private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret); // 0x000000018D531FF8-0x000000018D53205C
		private static void get_compositionCursorPos_Injected(out Vector2 ret); // 0x000000018D5335E4-0x000000018D533618
		private static void set_compositionCursorPos_Injected(ref Vector2 value); // 0x000000018D533870-0x000000018D5338A4
		private static void Internal_MultiplyPoint_Injected(ref Vector3 point, ref Matrix4x4 transform, out Vector3 ret); // 0x000000018D532B50-0x000000018D532BA4
		private static void InternalWindowToScreenPoint_Injected(ref Vector2 windowPoint, out Vector2 ret); // 0x000000018D532964-0x000000018D5329A8
		private static void InternalScreenToWindowPoint_Injected(ref Vector2 screenPoint, out Vector2 ret); // 0x000000018D5328F4-0x000000018D532938
	}

	public sealed class ExitGUIException : Exception // TypeDefIndex: 88021
	{
		// Constructors
		public ExitGUIException(); // 0x000000018D529160-0x000000018D5291B0
		internal ExitGUIException(string message); // 0x000000018D5291B0-0x000000018D529208
	}

	internal class GUILayoutEntry // TypeDefIndex: 88022
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
		public GUIStyle style { get; set; } // 0x0000000187261E60-0x0000000187261E70 0x000000018D52A5F8-0x000000018D52A644
		public virtual int marginLeft { get; } // 0x000000018D52A530-0x000000018D52A560 
		public virtual int marginRight { get; } // 0x000000018D52A560-0x000000018D52A590 
		public virtual int marginTop { get; } // 0x000000018D52A590-0x000000018D52A5C0 
		public virtual int marginBottom { get; } // 0x000000018D52A4C8-0x000000018D52A4F8 
		public int marginHorizontal { get; } // 0x000000018D52A4F8-0x000000018D52A530 
		public int marginVertical { get; } // 0x000000018D52A5C0-0x000000018D52A5F8 
	
		// Constructors
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style); // 0x000000018D52A338-0x000000018D52A404
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options); // 0x000000018D52A404-0x000000018D52A4C8
		static GUILayoutEntry(); // 0x000000018D52A2E4-0x000000018D52A338
	
		// Methods
		public virtual void CalcWidth(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void CalcHeight(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void SetHorizontal(float x, float width); // 0x0000000187261E40-0x0000000187261E50
		public virtual void SetVertical(float y, float height); // 0x0000000187261E50-0x0000000187261E60
		protected virtual void ApplyStyleSettings(GUIStyle style); // 0x000000018D529E88-0x000000018D529F24
		public virtual void ApplyOptions(GUILayoutOption[] options); // 0x000000018D529C44-0x000000018D529E88
		public override string ToString(); // 0x000000018D529F24-0x000000018D52A2E4
	}

	internal sealed class GUIWordWrapSizer : GUILayoutEntry // TypeDefIndex: 88023
	{
		// Fields
		private readonly GUIContent m_Content; // 0x48
		private readonly float m_ForcedMinHeight; // 0x50
		private readonly float m_ForcedMaxHeight; // 0x54
	
		// Constructors
		public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options); // 0x000000018D53C8F8-0x000000018D53C9D4
	
		// Methods
		public override void CalcWidth(); // 0x000000018D53C844-0x000000018D53C8F8
		public override void CalcHeight(); // 0x000000018D53C7C4-0x000000018D53C844
	}

	[VisibleToOtherModules(new string[2] {"UnityEngine.UIElementsModule", "Unity.UIElements" })]
	internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 88024
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
		public override int marginLeft { get; } // 0x0000000187233080-0x0000000187233090 
		public override int marginRight { get; } // 0x000000018723DA60-0x000000018723DA70 
		public override int marginTop { get; } // 0x0000000187233450-0x0000000187233460 
		public override int marginBottom { get; } // 0x0000000187233660-0x0000000187233670 
	
		// Constructors
		public GUILayoutGroup(); // 0x000000018D53C160-0x000000018D53C278
		static GUILayoutGroup(); // 0x000000018D53C08C-0x000000018D53C160
	
		// Methods
		public override void ApplyOptions(GUILayoutOption[] options); // 0x000000018D539A98-0x000000018D539B74
		protected override void ApplyStyleSettings(GUIStyle style); // 0x000000018D539B74-0x000000018D539BF4
		public void ResetCursor(); // 0x0000000187261FE0-0x0000000187261FF0
		public GUILayoutEntry GetNext(); // 0x000000018D53ABCC-0x000000018D53AE30
		public Rect GetLast(); // 0x000000018D53A92C-0x000000018D53ABCC
		public void Add(GUILayoutEntry e); // 0x000000018D539A44-0x000000018D539A98
		public override void CalcWidth(); // 0x000000018D53A258-0x000000018D53A92C
		public override void SetHorizontal(float x, float width); // 0x000000018D53AE30-0x000000018D53B570
		public override void CalcHeight(); // 0x000000018D539BF4-0x000000018D53A258
		public override void SetVertical(float y, float height); // 0x000000018D53B570-0x000000018D53BD3C
		public override string ToString(); // 0x000000018D53BD3C-0x000000018D53C08C
	}

	internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 88025
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
		[RequiredByNativeCode]
		public GUIScrollGroup(); // 0x000000018D53C770-0x000000018D53C7C4
	
		// Methods
		public override void CalcWidth(); // 0x000000018D53C394-0x000000018D53C42C
		public override void SetHorizontal(float x, float width); // 0x000000018D53C42C-0x000000018D53C564
		public override void CalcHeight(); // 0x000000018D53C278-0x000000018D53C394
		public override void SetVertical(float y, float height); // 0x000000018D53C564-0x000000018D53C770
	}

	[NativeHeader("Modules/IMGUI/GUIState.h")]
	internal class ObjectGUIState : IDisposable // TypeDefIndex: 88026
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public ObjectGUIState(); // 0x000000018D53CB20-0x000000018D53CB3C
	
		// Methods
		public void Dispose(); // 0x000000018D53CA00-0x000000018D53CA4C
		~ObjectGUIState(); // 0x000000018D53CA4C-0x000000018D53CAC0
		private void Destroy(); // 0x000000018D53C9D4-0x000000018D53CA00
		private static IntPtr Internal_Create(); // 0x000000018D53CAC0-0x000000018D53CAEC
		[NativeMethod(IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr); // 0x000000018D53CAEC-0x000000018D53CB20
	}

	internal class ScrollViewState // TypeDefIndex: 88027
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
		[RequiredByNativeCode]
		public ScrollViewState(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class SliderState // TypeDefIndex: 88028
	{
		// Fields
		public float dragStartPos; // 0x10
		public float dragStartValue; // 0x14
		public bool isDragging; // 0x18
	
		// Constructors
		[RequiredByNativeCode]
		public SliderState(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal struct SliderHandler // TypeDefIndex: 88029
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
		public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null); // 0x000000018D53DEC8-0x000000018D53DF48
	
		// Methods
		public float Handle(); // 0x000000018D53CC54-0x000000018D53CCDC
		private float OnMouseDown(); // 0x000000018D53CF40-0x000000018D53D2A8
		private float OnMouseDrag(); // 0x000000018D53D2A8-0x000000018D53D390
		private float OnMouseUp(); // 0x000000018D53D390-0x000000018D53D3DC
		private float OnRepaint(); // 0x000000018D53D3DC-0x000000018D53D76C
		private EventType CurrentEventType(); // 0x000000018D53CB78-0x000000018D53CBAC
		private int CurrentScrollTroughSide(); // 0x000000018D53CBAC-0x000000018D53CC54
		private bool IsEmptySlider(); // 0x000000018D53CE90-0x000000018D53CEA4
		private bool SupportsPageMovements(); // 0x000000018D53D938-0x000000018D53D994
		private float PageMovementValue(); // 0x000000018D53D76C-0x000000018D53D7FC
		private float PageUpMovementBound(); // 0x000000018D53D7FC-0x000000018D53D85C
		private Event CurrentEvent(); // 0x0000000187261E20-0x0000000187261E40
		private float ValueForCurrentMousePosition(); // 0x000000018D53DB8C-0x000000018D53DC5C
		private float Clamp(float value); // 0x000000018D53CB3C-0x000000018D53CB68
		private Rect ThumbSelectionRect(); // 0x000000018D53DAB4-0x000000018D53DAE0
		private void StartDraggingWithValue(float dragStartValue); // 0x000000018D53D8E4-0x000000018D53D938
		private SliderState SliderState(); // 0x000000018D53D85C-0x000000018D53D8E4
		private Rect ThumbExtRect(); // 0x000000018D53D994-0x000000018D53DA78
		private Rect ThumbRect(); // 0x000000018D53DA78-0x000000018D53DAB4
		private Rect VerticalThumbRect(); // 0x000000018D53DD14-0x000000018D53DEC8
		private Rect HorizontalThumbRect(); // 0x000000018D53CCDC-0x000000018D53CE90
		private float ClampedCurrentValue(); // 0x000000018D53CB68-0x000000018D53CB78
		private float MousePosition(); // 0x000000018D53CEC8-0x000000018D53CF40
		private float ValuesPerPixel(); // 0x000000018D53DC5C-0x000000018D53DD14
		private float ThumbSize(); // 0x000000018D53DAE0-0x000000018D53DB8C
		private float MaxValue(); // 0x000000018D53CEA4-0x000000018D53CEB8
		private float MinValue(); // 0x000000018D53CEB8-0x000000018D53CEC8
	}

	public class TextEditor // TypeDefIndex: 88034
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
		public string text { get; set; } // 0x000000018CB314B4-0x000000018CB314D0 0x000000018D5420F8-0x000000018D54217C
		public Rect position { get; set; } // 0x0000000187262030-0x0000000187262040 0x000000018D542060-0x000000018D5420BC
		internal virtual Rect localPosition { get; } // 0x0000000187262020-0x0000000187262030 
		public int cursorIndex { get; set; } // 0x000000018725FD10-0x000000018725FD20 0x000000018D542020-0x000000018D542060
		public int selectIndex { get; set; } // 0x0000000187262040-0x0000000187262050 0x000000018D5420BC-0x000000018D5420F8
		public int altCursorPosition { get; } // 0x0000000187262010-0x0000000187262020 
		public bool hasSelection { get; } // 0x000000018D542014-0x000000018D542020 
		public string SelectedText { get; } // 0x000000018D541F8C-0x000000018D542014 
	
		// Nested types
		public enum DblClickSnapping : byte // TypeDefIndex: 88030
		{
			WORDS = 0,
			PARAGRAPHS = 1
		}
	
		private enum CharacterType // TypeDefIndex: 88031
		{
			LetterLike = 0,
			Symbol = 1,
			Symbol2 = 2,
			WhiteSpace = 3
		}
	
		private enum Direction // TypeDefIndex: 88032
		{
			Forward = 0,
			Backward = 1
		}
	
		private enum TextEditOp // TypeDefIndex: 88033
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
		[RequiredByNativeCode]
		public TextEditor(); // 0x000000018D541EB8-0x000000018D541F8C
	
		// Methods
		private void ClearCursorPos(); // 0x0000000187261FF0-0x0000000187262000
		public void OnFocus(); // 0x000000018D5409E0-0x000000018D540A1C
		public void OnLostFocus(); // 0x000000018D540A1C-0x000000018D540A28
		private void GrabGraphicalCursorPos(); // 0x000000018D53F1C4-0x000000018D53F2B0
		public bool HandleKeyEvent(Event e); // 0x000000018D53F3D0-0x000000018D53F3E0
		[VisibleToOtherModules]
		internal bool HandleKeyEvent(Event e, bool textIsReadOnly); // 0x000000018D53F2B0-0x000000018D53F3D0
		public bool DeleteLineBack(); // 0x000000018D53E1EC-0x000000018D53E2E0
		public bool DeleteWordBack(); // 0x000000018D53E478-0x000000018D53E52C
		public bool DeleteWordForward(); // 0x000000018D53E52C-0x000000018D53E5D8
		public bool Delete(); // 0x000000018D53E5D8-0x000000018D53E690
		public bool CanPaste(); // 0x000000018D53E004-0x000000018D53E028
		public bool Backspace(); // 0x000000018D53DF48-0x000000018D53E004
		public void SelectAll(); // 0x000000018D541154-0x000000018D54119C
		public void SelectNone(); // 0x000000018D541428-0x000000018D541450
		public bool DeleteSelection(); // 0x000000018D53E2E0-0x000000018D53E478
		public void ReplaceSelection(string replace); // 0x000000018D54107C-0x000000018D541118
		public void Insert(char c); // 0x000000018D53FD20-0x000000018D53FD74
		public void MoveSelectionToAltCursor(); // 0x000000018D540530-0x000000018D540614
		public void MoveRight(); // 0x000000018D5404CC-0x000000018D540530
		public void MoveLeft(); // 0x000000018D540230-0x000000018D540284
		public void MoveUp(); // 0x000000018D54073C-0x000000018D540810
		public void MoveDown(); // 0x000000018D540080-0x000000018D540188
		public void MoveLineStart(); // 0x000000018D540324-0x000000018D5403B4
		public void MoveLineEnd(); // 0x000000018D540284-0x000000018D540324
		public void MoveGraphicalLineStart(); // 0x000000018D5401DC-0x000000018D540230
		public void MoveGraphicalLineEnd(); // 0x000000018D540188-0x000000018D5401DC
		public void MoveTextStart(); // 0x000000018D54065C-0x000000018D540684
		public void MoveTextEnd(); // 0x000000018D540614-0x000000018D54065C
		private int IndexOfEndOfLine(int startIndex); // 0x000000018D53F3E0-0x000000018D53F438
		public void MoveParagraphForward(); // 0x000000018D54044C-0x000000018D5404CC
		public void MoveParagraphBackward(); // 0x000000018D5403B4-0x000000018D54044C
		public void MoveCursorToPosition(Vector2 cursorPosition); // 0x000000018D54002C-0x000000018D540080
		protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift); // 0x000000018D53FF68-0x000000018D54002C
		public void MoveAltCursorToPosition(Vector2 cursorPosition); // 0x000000018D53FEB4-0x000000018D53FF68
		public void SelectToPosition(Vector2 cursorPosition); // 0x000000018D541650-0x000000018D5418E8
		public void SelectLeft(); // 0x000000018D5413C8-0x000000018D541428
		public void SelectRight(); // 0x000000018D541580-0x000000018D5415E0
		public void SelectUp(); // 0x000000018D54191C-0x000000018D5419B0
		public void SelectDown(); // 0x000000018D5412A8-0x000000018D541360
		public void SelectTextEnd(); // 0x000000018D5415E0-0x000000018D541610
		public void SelectTextStart(); // 0x000000018D541610-0x000000018D54161C
		public void MouseDragSelectsWholeWords(bool on); // 0x0000000187262000-0x0000000187262010
		public void DblClickSnap(DblClickSnapping snapping); // 0x0000000182271CD0-0x0000000182271CE0
		private int GetGraphicalLineStart(int p); // 0x000000018D53F0E4-0x000000018D53F1C4
		private int GetGraphicalLineEnd(int p); // 0x000000018D53EFF8-0x000000018D53F0E4
		private int FindNextSeperator(int startPos); // 0x000000018D53ED60-0x000000018D53EDE8
		private int FindPrevSeperator(int startPos); // 0x000000018D53EDE8-0x000000018D53EE74
		public void MoveWordRight(); // 0x000000018D540868-0x000000018D5408D4
		public void MoveToStartOfNextWord(); // 0x000000018D5406E0-0x000000018D54073C
		public void MoveToEndOfPreviousWord(); // 0x000000018D540684-0x000000018D5406E0
		public void SelectToStartOfNextWord(); // 0x000000018D5418E8-0x000000018D54191C
		public void SelectToEndOfPreviousWord(); // 0x000000018D54161C-0x000000018D541650
		private CharacterType ClassifyChar(int index); // 0x000000018D53E068-0x000000018D53E140
		public int FindStartOfNextWord(int p); // 0x000000018D53EE74-0x000000018D53EFF8
		private int FindEndOfPreviousWord(int p); // 0x000000018D53ECAC-0x000000018D53ED60
		public void MoveWordLeft(); // 0x000000018D540810-0x000000018D540868
		public void SelectWordRight(); // 0x000000018D541A3C-0x000000018D541AC8
		public void SelectWordLeft(); // 0x000000018D5419B0-0x000000018D541A3C
		public void ExpandSelectGraphicalLineStart(); // 0x000000018D53EB10-0x000000018D53EB78
		public void ExpandSelectGraphicalLineEnd(); // 0x000000018D53EAA8-0x000000018D53EB10
		public void SelectGraphicalLineStart(); // 0x000000018D541394-0x000000018D5413C8
		public void SelectGraphicalLineEnd(); // 0x000000018D541360-0x000000018D541394
		public void SelectParagraphForward(); // 0x000000018D5414F4-0x000000018D541580
		public void SelectParagraphBackward(); // 0x000000018D541450-0x000000018D5414F4
		public void SelectCurrentWord(); // 0x000000018D541228-0x000000018D5412A8
		private int FindEndOfClassification(int p, Direction dir); // 0x000000018D53EB78-0x000000018D53ECAC
		public void SelectCurrentParagraph(); // 0x000000018D54119C-0x000000018D541228
		public void UpdateScrollOffsetIfNeeded(Event evt); // 0x000000018D541AC8-0x000000018D541B18
		[VisibleToOtherModules]
		internal void UpdateScrollOffset(); // 0x000000018D541B18-0x000000018D541EB8
		public void DrawCursor(string newText); // 0x000000018D53E690-0x000000018D53EA64
		private bool PerformOperation(TextEditOp operation, bool textIsReadOnly); // 0x000000018D540AAC-0x000000018D540F5C
		public void SaveBackup(); // 0x000000018D541118-0x000000018D541154
		public bool Cut(); // 0x000000018D53E1C0-0x000000018D53E1EC
		public void Copy(); // 0x000000018D53E140-0x000000018D53E1C0
		private static string ReplaceNewlinesWithSpaces(string value); // 0x000000018D540FF0-0x000000018D54107C
		public bool Paste(); // 0x000000018D540A28-0x000000018D540AAC
		private static void MapKey(string key, TextEditOp action); // 0x000000018D53FE2C-0x000000018D53FEB4
		private void InitKeyActions(); // 0x000000018D53F438-0x000000018D53FD20
		public void DetectFocusChange(); // 0x000000018CDCD15C-0x000000018CDCD16C
		internal virtual void OnDetectFocusChange(); // 0x000000018D540988-0x000000018D5409E0
		internal virtual void OnCursorIndexChange(); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void OnSelectIndexChange(); // 0x0000000186805BA0-0x0000000186805BB0
		private void ClampTextIndex(ref int index); // 0x000000018D53E028-0x000000018D53E068
		private void EnsureValidCodePointIndex(ref int index); // 0x000000018D53EA64-0x000000018D53EAA8
		private bool IsValidCodePointIndex(int index); // 0x000000018D53FD74-0x000000018D53FE2C
		private int PreviousCodePointIndex(int index); // 0x000000018D540F5C-0x000000018D540FF0
		private int NextCodePointIndex(int index); // 0x000000018D5408D4-0x000000018D540988
	}
}
